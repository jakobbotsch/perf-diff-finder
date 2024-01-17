using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Web;

namespace perf_diff_finder
{
    internal class Program
    {
        static void Main()
        {
            //const string BenchmarksPath = @"C:\dev\dotnet\perf-diff-finder\improvements.csv";
            //const string ResultsPath = @"C:\dev\dotnet\perf-diff-finder\improvements";
            //const string BenchmarksPath = @"C:\dev\dotnet\perf-diff-finder\regressions.csv";
            //const string ResultsPath = @"C:\dev\dotnet\perf-diff-finder\regressions";
            const string BaseReleaseCoreRoot = @"C:\dev\temp\perf\base";
            const string DiffReleaseCoreRoot = @"C:\dev\temp\perf\diff";

            const string RuntimeRepo = @"C:\dev\dotnet\runtime4";
            const string CoreRootsDir = @"D:\dev\core_roots";
            const string ResultsPath = @"C:\dev\dotnet\perf-diff-finder\adhoc";
            const string BenchmarksDir = @"C:\dev\dotnet\performance\src\benchmarks\micro";
            string BaseCheckedCoreRoot = FindCheckedCoreRoot(BaseReleaseCoreRoot, RuntimeRepo, CoreRootsDir);
            string DiffCheckedCoreRoot = FindCheckedCoreRoot(DiffReleaseCoreRoot, RuntimeRepo, CoreRootsDir);
            const string InstructionsRetiredExplorerDir = @"C:\dev\dotnet\InstructionsRetiredExplorer\src";
            const string JitName = "clrjit.dll";
            const bool AltJit = false;

            using StreamWriter fullReport = File.CreateText(Path.Combine(ResultsPath, "results.md"));

            //List<Benchmark> benchmarks = ReadBenchmarks(BenchmarksPath).OrderByDescending(x => x.Ratio).ToList();
            //List<Benchmark> benchmarks = new List<string>()
            //{
            //    "System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: \"Twain\", Options: None)",
            //}.ConvertAll(s => new Benchmark { Name = s, Ratio = double.NaN });
            List<Benchmark> benchmarks = ParseFromPerfIssue(@"https://github.com/dotnet/perf-autofiling-issues/issues/27332");

            int numBenchmarks = 0;

            foreach (Benchmark benchmark in benchmarks)
            {
                StringWriter sw = new();
                sw.WriteLine("# ``{0}``", benchmark.Name);
                sw.WriteLine();
                if (!double.IsNaN(benchmark.Ratio))
                {
                    sw.WriteLine("{0} by {1:F2}%", benchmark.Ratio < 1 ? "Regressed" : "Improved", Math.Abs(benchmark.Ratio - 1) * 100);
                    sw.WriteLine();
                    Console.WriteLine("({0}/{1}) {2:F2}%: {3}", ++numBenchmarks, benchmarks.Count, benchmark.Ratio * 100, benchmark.Name);
                }
                else
                {
                    Console.WriteLine("({0}/{1}) {2}", ++numBenchmarks, benchmarks.Count, benchmark.Name);
                }

                string cleanName = benchmark.Name;
                if (cleanName.Length > 100)
                {
                    int parensIndex = cleanName.IndexOf('(');
                    static string Last(string s, int num) => s.Length < num ? s : s[^num..];
                    if (parensIndex == -1)
                    {
                        cleanName = Last(cleanName, 100);
                    }
                    else
                    {
                        string benchmarkName = cleanName[..parensIndex];
                        string paramsStr = cleanName[(parensIndex + 1)..^1];
                        cleanName = Last(benchmarkName, Math.Max(50, 100 - paramsStr.Length)) + "(" + Last(paramsStr, Math.Max(50, 100 - benchmarkName.Length)) + ")";
                    }
                }

                foreach (char illegalChar in Path.GetInvalidFileNameChars())
                    cleanName = cleanName.Replace(illegalChar, '_');

                cleanName = cleanName.Replace(' ', '_');

                string cleanPath = Path.Combine(ResultsPath, cleanName);

                if (Directory.Exists(cleanPath) && File.Exists(Path.Combine(cleanPath, "error.txt")))
                {
                    sw.WriteLine("**Not included in report due to an error**");
                    sw.WriteLine();
                    fullReport.Write(sw.GetStringBuilder());
                    Console.WriteLine("  Skipped (error)");
                    continue;
                }

                DirectoryInfo dir = Directory.CreateDirectory(cleanPath);

                try
                {
                    List<string> args = new();

                    string filterBenchmarkName = benchmark.Name.Replace('(', '?').Replace(')', '?');

                    // Step 1: Get a trace of the benchmark
                    Console.WriteLine("  Collect trace");
                    string outputPath = Path.Combine(dir.FullName, "bdn_collect_etl.txt");
                    string result;
                    if (!File.Exists(outputPath))
                    {
                        args.Clear();
                        args.Add("run");
                        args.Add("-c");
                        args.Add("Release");
                        args.Add("-f");
                        args.Add("net8.0");
                        args.Add("--");
                        args.Add("--filter");
                        args.Add(filterBenchmarkName);
                        args.Add("--corerun");
                        args.Add(Path.Combine(BaseReleaseCoreRoot, "corerun.exe"));
                        args.Add("--profiler");
                        args.Add("ETW");

                        result = Invoke("dotnet.exe", BenchmarksDir, args.ToArray(), false, outputPath);
                    }
                    else
                    {
                        result = File.ReadAllText(outputPath);
                    }

                    string[] resultLines = result.ReplaceLineEndings().Split(Environment.NewLine);
                    int traceLineIndex = Array.FindIndex(resultLines, l => Regex.IsMatch(l, "Exported \\d+ trace file\\(s\\)\\. Example:"));
                    if (traceLineIndex == -1)
                        throw new Exception("Could not get trace");

                    string path = resultLines[traceLineIndex + 1];

                    // Step 2: Run InstructionRetiredExplorer
                    Console.WriteLine("  Find hot functions");
                    outputPath = Path.Combine(dir.FullName, "hotfunctions.txt");
                    if (!File.Exists(outputPath))
                    {
                        args.Clear();
                        args.Add("run");
                        args.Add("-c");
                        args.Add("Release");
                        args.Add("--");
                        args.Add(path);
                        args.Add("-benchmark");
                        args.Add("-process");
                        args.Add("corerun");

                        result = Invoke("dotnet.exe", InstructionsRetiredExplorerDir, args.ToArray(), false, outputPath);
                    }
                    else
                    {
                        result = File.ReadAllText(outputPath);
                    }

                    List<HotFunction> hotFunctions = ExtractHotFunctions(result).ToList();

                    string baseCheckedShimCollector = Path.Combine(BaseCheckedCoreRoot, "superpmi-shim-collector.dll");
                    string baseReleaseShimCollector = Path.Combine(BaseReleaseCoreRoot, "superpmi-shim-collector.dll");

                    if (!File.Exists(baseReleaseShimCollector))
                        File.Copy(baseCheckedShimCollector, baseReleaseShimCollector);

                    // Step 3: Generate SPMI collection for base
                    Console.WriteLine("  Collect SPMI collection for base");
                    string baseMC = Path.Combine(dir.FullName, "base.mc");
                    if (!File.Exists(baseMC))
                    {
                        args.Clear();
                        args.Add("run");
                        args.Add("-c");
                        args.Add("Release");
                        args.Add("-f");
                        args.Add("net8.0");
                        args.Add("--");
                        args.Add("--filter");
                        args.Add(filterBenchmarkName);
                        args.Add("--corerun");
                        args.Add(Path.Combine(BaseReleaseCoreRoot, "corerun.exe"));
                        args.Add("--envvars");
                        if (AltJit)
                        {
                            args.Add("DOTNET_AltJitName:superpmi-shim-collector.dll");
                            args.Add("DOTNET_AltJit:*");
                        }
                        else
                        {
                            args.Add("DOTNET_JitName:superpmi-shim-collector.dll");
                        }
                        args.Add($"SuperPMIShimPath:{Path.Combine(BaseCheckedCoreRoot, JitName)}");
                        args.Add(@"SuperPMIShimLogPath:" + dir.FullName);
                        outputPath = Path.Combine(dir.FullName, "bdn_collect_base_mc.txt");
                        result = Invoke("dotnet.exe", BenchmarksDir, args.ToArray(), false, outputPath);
                        File.Move(dir.GetFiles("*.mc").Single().FullName, baseMC);
                    }

                    string diffCheckedShimCollector = Path.Combine(DiffCheckedCoreRoot, "superpmi-shim-collector.dll");
                    string diffReleaseShimCollector = Path.Combine(DiffReleaseCoreRoot, "superpmi-shim-collector.dll");
                    if (!File.Exists(diffReleaseShimCollector))
                        File.Copy(diffCheckedShimCollector, diffReleaseShimCollector);

                    // Step 4: Generate SPMI collections for diff
                    Console.WriteLine("  Collect SPMI collection for diff");
                    string diffMC = Path.Combine(dir.FullName, "diff.mc");
                    if (!File.Exists(diffMC))
                    {
                        args.Clear();
                        args.Add("run");
                        args.Add("-c");
                        args.Add("Release");
                        args.Add("-f");
                        args.Add("net8.0");
                        args.Add("--");
                        args.Add("--filter");
                        args.Add(filterBenchmarkName);
                        args.Add("--corerun");
                        args.Add(Path.Combine(DiffReleaseCoreRoot, "corerun.exe"));
                        args.Add("--envvars");
                        if (AltJit)
                        {
                            args.Add("DOTNET_AltJitName:superpmi-shim-collector.dll");
                            args.Add("DOTNET_AltJit:*");
                            args.Add("DOTNET_AltJitOS:linux");
                        }
                        else
                        {
                            args.Add("DOTNET_JitName:superpmi-shim-collector.dll");
                        }
                        args.Add($"SuperPMIShimPath:{Path.Combine(DiffCheckedCoreRoot, JitName)}");
                        args.Add(@"SuperPMIShimLogPath:" + dir.FullName);
                        outputPath = Path.Combine(dir.FullName, "bdn_collect_diff_mc.txt");
                        result = Invoke("dotnet.exe", BenchmarksDir, args.ToArray(), false, outputPath);
                        File.Move(dir.GetFiles("*.mc").Where(fi => fi.Name != "base.mc").Single().FullName, diffMC);
                    }

                    // Step 5: Extract diffs
                    Console.WriteLine("  Extract diffs");
                    List<(HotFunction hf, string jitName, string friendlyName)> disasms = new();
                    foreach (HotFunction hf in hotFunctions)
                    {
                        if (hf.Fraction < 1)
                            continue;

                        if (hf.CodeType == "native" || hf.CodeType == "?")
                            continue;

                        // Hack: for explicit interface implementations we have an ambiguous string like
                        // [System.Collections.Immutable]System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]].System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId

                        // However we can at least use the presence of the class instantiation as a hint to handle some of these.
                        int classNameStart = hf.Name.IndexOf(']') + 1;
                        int classInstantiationStart = hf.Name.IndexOf('[', classNameStart); // skip module name
                        // Remove all instantiations, module name, and parameters
                        string name = RemoveMatched(hf.Name, '(', ')');
                        name = RemoveMatched(name, '[', ']');

                        int lastDot = name.LastIndexOf('.');
                        while (name[lastDot - 1] == '.')
                            lastDot--;
                        string methodName = name[(lastDot + 1)..];
                        string className = name[..lastDot];
                        if (classInstantiationStart != -1 && classInstantiationStart < lastDot)
                        {
                            className = hf.Name[classNameStart..classInstantiationStart];
                        }
                        string jitName = $"*{className}:*{methodName}";
                        disasms.Add((hf, jitName, $"{className}.{methodName}"));

                        Console.WriteLine("    {0:F2}% {1} {2} (JIT name: {3})", hf.Fraction, hf.CodeType, hf.Name, jitName);
                    }

                    string GetDasmFileName(string friendlyName)
                    {
                        string fileName = friendlyName + ".dasm";
                        foreach (char illegalChar in Path.GetInvalidFileNameChars())
                            fileName = fileName.Replace(illegalChar, '_');
                        fileName = fileName.Replace(' ', '_');
                        return fileName;
                    }

                    void CreateDasm(bool isDiff)
                    {
                        string checkedCoreRoot = isDiff ? DiffCheckedCoreRoot : BaseCheckedCoreRoot;
                        string baseOrDiff = isDiff ? "diff" : "base";
                        Console.WriteLine("  Generate {0} disasm", baseOrDiff);
                        string dasmDir = Path.Combine(dir.FullName, baseOrDiff);
                        Directory.CreateDirectory(dasmDir);
                        // Generate these in multiple invocation to avoid
                        // annoying reorderings due to the tiering queue.
                        foreach ((HotFunction hf, string jitDisasm, string friendlyName) in disasms)
                        {
                            string dasmFile = Path.Combine(dasmDir, GetDasmFileName(friendlyName));
                            Console.WriteLine("    {0}", jitDisasm);
                            if (!File.Exists(dasmFile))
                            {
                                string tmpFile = Path.GetTempFileName();

                                args.Clear();
                                args.Add(Path.Combine(checkedCoreRoot, JitName));
                                args.Add(isDiff ? diffMC : baseMC);
                                args.Add("-jitoption");
                                args.Add("JitDisasm=" + jitDisasm);
                                args.Add("-jitoption");
                                args.Add("JitDisasmDiffable=1");
                                //args.Add("-jitoption");
                                //args.Add("JitDisasmWithAlignmentBoundaries=1");
                                args.Add("-jitoption");
                                args.Add("JitStdOutFile=" + tmpFile);
                                outputPath = Path.Combine(dir.FullName, $"spmi_dasm_{baseOrDiff}.txt");
                                Invoke(Path.Combine(checkedCoreRoot, "superpmi.exe"), checkedCoreRoot, args.ToArray(), false, outputPath, code => code == 0 || code == 3);
                                File.Move(tmpFile, dasmFile, true);
                            }

                            string dumpFile = Path.Combine(dasmDir, Path.ChangeExtension(GetDasmFileName(friendlyName), ".jitdump.txt"));
                            if (!File.Exists(dumpFile))
                            {
                                string tmpFile = Path.GetTempFileName();

                                args.Clear();
                                args.Add(Path.Combine(checkedCoreRoot, JitName));
                                args.Add(isDiff ? diffMC : baseMC);
                                args.Add("-jitoption");
                                args.Add("JitDump=" + jitDisasm);
                                args.Add("-jitoption");
                                args.Add("JitStdOutFile=" + tmpFile);
                                outputPath = Path.Combine(dir.FullName, $"spmi_dump_{baseOrDiff}.txt");
                                Invoke(Path.Combine(checkedCoreRoot, "superpmi.exe"), checkedCoreRoot, args.ToArray(), false, outputPath, code => code == 0 || code == 3);
                                File.Move(tmpFile, dumpFile, true);
                            }
                        }
                    }

                    // Step 6: Generate base disassembly
                    CreateDasm(false);

                    // Step 7: Generate diff disassembly
                    CreateDasm(true);

                    // Step 8: Check for diffs
                    Console.WriteLine("  Check for diffs");
                    sw.WriteLine("Hot functions:");
                    sw.WriteLine();
                    List<(HotFunction hf, string basePath, string diffPath)> toDiff = new();
                    foreach ((HotFunction hf, string jitDisasm, string friendlyName) in disasms)
                    {
                        sw.WriteLine("- ({0:F2}%) ``{1}`` ({2})", hf.Fraction, friendlyName, hf.CodeType);

                        string baseDasmFile = Path.Combine(dir.FullName, "base", GetDasmFileName(friendlyName));
                        string diffDasmFile = Path.Combine(dir.FullName, "diff", GetDasmFileName(friendlyName));

                        if (!File.Exists(baseDasmFile))
                        {
                            sw.WriteLine("  - **Error obtaining base dasm**");
                            continue;
                        }

                        if (!File.Exists(diffDasmFile))
                        {
                            sw.WriteLine("  - **Error obtaining diff dasm**");
                            continue;
                        }

                        args.Clear();
                        args.Add("--base");
                        args.Add(baseDasmFile);
                        args.Add("--diff");
                        args.Add(diffDasmFile);
                        outputPath = Path.Combine(dir.FullName, "jitanalyze.txt");
                        bool hasDiff = false;
                        result = Invoke($"jit-analyze.exe", Environment.CurrentDirectory, args.ToArray(), false, outputPath, code =>
                        {
                            hasDiff = code != 0;
                            return code == 0 || code == -1;
                        });

                        if (hasDiff)
                        {
                            sw.WriteLine("  - **Has diffs**");
                            toDiff.Add((hf, baseDasmFile, diffDasmFile));
                        }
                        else
                        {
                            sw.WriteLine("  - No diffs");
                        }
                    }

                    //// Step 9: Check for physical promotions
                    //Console.WriteLine("  Check for physical promotions");
                    //sw.WriteLine("Hot functions:");
                    //sw.WriteLine();
                    //List<(HotFunction hf, string basePath, string diffPath)> toDiff = new();
                    //bool anyPhysicalPromotions = false;
                    //foreach ((HotFunction hf, string jitDisasm, string friendlyName) in disasms)
                    //{
                    //    sw.WriteLine("- ({0:F2}%) ``{1}`` ({2})", hf.Fraction, friendlyName, hf.CodeType);

                    //    string baseDasmFile = Path.Combine(dir.FullName, "base", GetDasmFileName(friendlyName));
                    //    string diffDasmFile = Path.Combine(dir.FullName, "diff", GetDasmFileName(friendlyName));

                    //    if (!File.Exists(baseDasmFile))
                    //    {
                    //        sw.WriteLine("  - **Error obtaining base dasm**");
                    //        continue;
                    //    }

                    //    if (!File.Exists(diffDasmFile))
                    //    {
                    //        sw.WriteLine("  - **Error obtaining diff dasm**");
                    //        continue;
                    //    }

                    //    string baseDasm = File.ReadAllText(baseDasmFile);
                    //    string diffDasm = File.ReadAllText(diffDasmFile);

                    //    if (string.IsNullOrWhiteSpace(baseDasm))
                    //    {
                    //        sw.WriteLine("  - **Error obtaining base dasm**");
                    //        continue;
                    //    }

                    //    if (string.IsNullOrWhiteSpace(diffDasm))
                    //    {
                    //        sw.WriteLine("  - **Error obtaining diff dasm**");
                    //        continue;
                    //    }

                    //    bool hasPhysicalPromotions = Regex.IsMatch(File.ReadAllText(diffDasmFile), "\"V\\d+\\.\\[\\d+\\.\\.\\d+\\)");
                    //    anyPhysicalPromotions |= hasPhysicalPromotions;
                    //    if (!hasPhysicalPromotions)
                    //    {
                    //        sw.WriteLine("  - No physical promotion");
                    //    }
                    //    else
                    //    {
                    //        sw.WriteLine("  - **Has physical promotion**");
                    //        toDiff.Add((hf, baseDasmFile, diffDasmFile));
                    //    }
                    //}

                    sw.WriteLine();
                    if (toDiff.Count > 0)
                    {
                        sw.WriteLine("<details>");
                        sw.WriteLine();
                        sw.WriteLine("<summary>Diffs</summary>");
                        sw.WriteLine();
                        foreach ((HotFunction hf, string baseDasm, string diffDasm) in toDiff)
                        {
                            sw.WriteLine("### ``{0}``", hf.Name);
                            sw.WriteLine();

                            args.Clear();
                            args.Add("diff");
                            args.Add("--no-index");
                            args.Add("--exit-code");
                            args.Add(baseDasm);
                            args.Add(diffDasm);
                            bool hasDiff = false;
                            result = Invoke($"git.exe", Environment.CurrentDirectory, args.ToArray(), false, outputPath, code =>
                            {
                                hasDiff = code != 0;
                                return code == 0 || code == 1;
                            });

                            string withoutHeader = string.Join(Environment.NewLine, result.ReplaceLineEndings(Environment.NewLine).Split(Environment.NewLine)[5..]);

                            if (hasDiff)
                            {
                                sw.WriteLine("```diff");
                                sw.WriteLine(withoutHeader);
                                sw.WriteLine("```");
                            }
                            else
                            {
                                sw.WriteLine(" No diff found");
                            }

                            sw.WriteLine();
                        }
                        sw.WriteLine("</details>");
                        sw.WriteLine();
                    }

                    fullReport.Write(sw.GetStringBuilder());

                    //if (!File.Exists(hasPhysicalPromotionsFile) && !File.Exists(noPhysicalPromotionsFile)) {
                    //    string diffDasm = File.ReadAllText(diffDasmFile);
                    //    hasPhysicalPromotions = Regex.IsMatch(diffDasm, "\"V\\d+\\.\\[\\d+\\.\\.\\d+\\)");
                    //    if (hasPhysicalPromotions)
                    //    {
                    //        File.WriteAllText(hasPhysicalPromotionsFile, "");
                    //    }
                    //    else
                    //    {
                    //        File.WriteAllText(noPhysicalPromotionsFile, "");
                    //    }
                    //}
                    //else
                    //{
                    //    hasPhysicalPromotions = File.Exists(hasPhysicalPromotionsFile);
                    //}

                        //args.Clear();
                        //args.Add("diff");
                        //args.Add("--no-index");
                        //args.Add("--exit-code");
                        //args.Add(Path.Combine(dir.FullName, "base.dasm"));
                        //args.Add(Path.Combine(dir.FullName, "diff.dasm"));
                        //result = Invoke($"git.exe", CheckedCoreRoot, args.ToArray(), false, outputPath, code =>
                        //{
                        //    hasDiff = code != 0;
                        //    return code == 0 || code == 1;
                        //});

                    if (toDiff.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  Success with diffs");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  Success without diffs");
                    }

                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("  Failure");
                    File.WriteAllText(Path.Combine(dir.FullName, "error.txt"), ex.ToString());
                    sw.WriteLine("Error occured");
                    fullReport.WriteLine(sw.GetStringBuilder());
                }

                Console.WriteLine();
            }
        }

        private static string FindCheckedCoreRoot(string releaseCoreRoot, string runtimeRepo, string coreRootsDir, string? hash = null)
        {
            if (hash == null)
            {
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Path.Combine(releaseCoreRoot, "clrjit.dll"));
                if (fvi.ProductVersion == null)
                    throw new Exception("Could not get product version");

                Match match = Regex.Match(fvi.ProductVersion, "@Commit: ([0-9a-f]+)");
                if (!match.Success)
                    throw new Exception("Could not extract hash");

                hash = match.Groups[1].Value;
            }

            List<string> args = new();
            args.Add("log");
            args.Add(hash);
            args.Add("-1");
            args.Add("--pretty=format:%H");
            args.Add("--");
            args.Add("src/coreclr/jit/*");
            string hashWithJitChange = Invoke("git.exe", runtimeRepo, args.ToArray(), false, null).Trim();
            string coreRoot = Path.Combine(coreRootsDir, hashWithJitChange);
            if (!Directory.Exists(coreRoot) || !File.Exists(Path.Combine(coreRoot, "clrjit.dll")))
            {
                throw new Exception($"Could not find valid checked core_root at " + coreRoot);
            }

            return coreRoot;
        }

        private static IEnumerable<Benchmark> ReadBenchmarks(string path)
        {
            using TextFieldParser parser = new TextFieldParser(path);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(new string[] { "," });
            parser.HasFieldsEnclosedInQuotes = true;

            string[]? cols = parser.ReadFields();
            if (cols == null)
            {
                throw new Exception("Unexpected");
            }

            int nameIndex = Array.IndexOf(cols, "TestName");
            int ratioIndex = Array.IndexOf(cols, "Ratio");

            List<Benchmark> benchmarks = new();
            while (!parser.EndOfData)
            {
                string[]? row = parser.ReadFields();
                if (row == null)
                {
                    throw new Exception("Unexpected");
                }

                Benchmark b = new Benchmark { Name = row[nameIndex], Ratio = double.Parse(row[ratioIndex], CultureInfo.InvariantCulture) };
                yield return b;
            }
        }

        private static List<Benchmark> ParseFromPerfIssue(string webPage)
        {
            string source = new HttpClient().GetStringAsync(webPage).Result;
            // https://pvscmdupload.blob.core.windows.net/reports/allTestHistory/refs/heads/main_x64_Windows%2010.0.22621/amd/System.Buffers.Text.Tests.Utf8ParserTests.TryParseUInt32(value%3a%204294967295).html
            Regex regex = new Regex("https://pvscmdupload.blob.core.windows.net/reports/allTestHistory/(.*?)\\.html\"");
            MatchCollection matches = regex.Matches(source);
            List<Benchmark> benchmarks = new();
            foreach (Match match in matches)
            {
                string url = match.Groups[1].Value;
                string name = url[(url.LastIndexOf('/') + 1)..];
                name = HttpUtility.UrlDecode(name);
                benchmarks.Add(new Benchmark { Name = name, Ratio = double.NaN });
            }

            return benchmarks;
        }

        private static IEnumerable<HotFunction> ExtractHotFunctions(string output)
        {
            string[] resultLines = output.ReplaceLineEndings(Environment.NewLine).Split(Environment.NewLine);
            int tableLineIndex = Array.FindIndex(resultLines, l => l.StartsWith("Benchmark: found"));
            tableLineIndex -= 2;
            while (!string.IsNullOrWhiteSpace(resultLines[tableLineIndex]))
                tableLineIndex--;

            tableLineIndex++;
            while (!string.IsNullOrWhiteSpace(resultLines[tableLineIndex]))
            {
                Match match = Regex.Match(resultLines[tableLineIndex], "([0-9.]+)%\\s+[0-9.E+]+\\s+(MinOpt|FullOpt|Tier-0|Tier-1|OSR|native|jit \\?\\?\\?|\\?)\\s+(.*)");
                if (!match.Success)
                    throw new Exception("Regex failure");
                double fraction = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                string codeType = match.Groups[2].Value;
                string funcName = match.Groups[3].Value;

                yield return new HotFunction { Fraction = fraction, CodeType = codeType, Name = funcName };
                tableLineIndex++;
            }
        }

        private static string RemoveMatched(string text, char open, char close)
        {
            StringBuilder newString = new StringBuilder(text.Length);
            int nest = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == open)
                {
                    nest++;
                }
                else if (nest > 0 && text[i] == close)
                {
                    nest--;
                }
                else if (nest == 0)
                {
                    newString.Append(text[i]);
                }
            }

            return newString.ToString();
        }

        private static string Invoke(string fileName, string workingDir, string[] args, bool printOutput, string? outputPath, Func<int, bool>? checkExitCode = null)
        {
            var psi = new ProcessStartInfo(fileName)
            {
                FileName = fileName,
                WorkingDirectory = workingDir,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            };
            foreach (string a in args)
                psi.ArgumentList.Add(a);

            string command = fileName + " " + string.Join(" ", args.Select(a => "\"" + a + "\""));

            using Process? p = Process.Start(psi);
            if (p == null)
                throw new Exception("Could not start child process " + fileName);

            StringBuilder stdout = new();
            StringBuilder stderr = new();
            p.OutputDataReceived += (sender, args) =>
            {
                if (printOutput)
                {
                    Console.WriteLine(args.Data);
                }
                stdout.AppendLine(args.Data);
            };
            p.ErrorDataReceived += (sender, args) =>
            {
                if (printOutput)
                {
                    Console.Error.WriteLine(args.Data);
                }
                stderr.AppendLine(args.Data);
            };
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.WaitForExit();

            if (outputPath != null)
            {
                string all = command + Environment.NewLine + Environment.NewLine + "STDOUT:" + Environment.NewLine + stdout + Environment.NewLine + Environment.NewLine + "STDERR:" + Environment.NewLine + stderr;
                File.AppendAllText(outputPath, all);
            }

            if (checkExitCode == null ? p.ExitCode != 0 : !checkExitCode(p.ExitCode))
            {
                throw new Exception(
                    $@"
Child process '{fileName}' exited with error code {p.ExitCode}
stdout:
{stdout.ToString().Trim()}

stderr:
{stderr}".Trim());
            }


            return stdout.ToString();
        }

        private class Benchmark
        {
            public required string Name { get; init; }
            public required double Ratio { get; set; }
        }

        private class HotFunction
        {
            public required double Fraction { get; set; }
            public required string CodeType { get; set; }
            public required string Name { get; set; }
        }
    }
}