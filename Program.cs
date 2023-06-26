using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Globalization;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;

namespace perf_diff_finder
{
    internal class Program
    {
        static void Main()
        {
            List<Benchmark> benchmarks = ReadBenchmarks().OrderBy(x => x.Ratio).ToList();

            foreach (Benchmark benchmark in benchmarks.OrderByDescending(b => b.Name.Contains("MultiplyByMatrixOperatorBenchmark") || b.Name.Contains("IterateTryGetTenSegments")))
            {
                Console.WriteLine("{0:F3}%: {1}", benchmark.Ratio * 100, benchmark.Name);
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

                string cleanPath = Path.Combine(@"C:\dev\dotnet\perf-diff-finder\results", cleanName);
                if (Directory.Exists(cleanPath) && File.Exists(Path.Combine(cleanPath, "error.txt")))
                {
                    Console.WriteLine("  skipped: {0} already exists", cleanPath);
                    continue;
                }

                DirectoryInfo dir = Directory.CreateDirectory(cleanPath);

                try
                {
                    (string benchmarkName, string[] paramFilters) = ParseBenchmarkName(benchmark.Name);

                    const string BenchmarksDir = @"C:\dev\dotnet\performance\src\benchmarks\micro";
                    const string CheckedCoreRoot = @"C:\dev\dotnet\runtime2\artifacts\tests\coreclr\windows.x64.Checked\Tests\Core_Root\";
                    const string ReleaseCoreRoot = @"C:\dev\dotnet\runtime2\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\";
                    List<string> args = new();

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
                        args.Add(benchmarkName);
                        args.Add("--corerun");
                        args.Add($"{ReleaseCoreRoot}corerun.exe");
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
                    Trace.Assert(traceLineIndex != -1);
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

                        const string InstructionsRetiredExplorerDir = @"C:\dev\dotnet\InstructionsRetiredExplorer\src";
                        result = Invoke("dotnet.exe", InstructionsRetiredExplorerDir, args.ToArray(), false, outputPath);
                    }
                    else
                    {
                        result = File.ReadAllText(outputPath);
                    }

                    List<HotFunction> hotFunctions = ExtractHotFunctions(result).ToList();

                    const string CheckedShimCollector = $"{CheckedCoreRoot}superpmi-shim-collector.dll";
                    const string ReleaseShimCollector = $"{ReleaseCoreRoot}superpmi-shim-collector.dll";

                    if (!File.Exists(ReleaseShimCollector))
                        File.Copy(CheckedShimCollector, ReleaseShimCollector);

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
                        args.Add(benchmark.Name);
                        args.Add("--corerun");
                        args.Add($"{ReleaseCoreRoot}corerun.exe");
                        args.Add("--envvars");
                        args.Add($@"DOTNET_JitName:superpmi-shim-collector.dll");
                        args.Add($@"SuperPMIShimPath:{CheckedCoreRoot}clrjit.dll");
                        args.Add(@"SuperPMIShimLogPath:" + dir.FullName);
                    outputPath = Path.Combine(dir.FullName, "bdn_collect_base_mc.txt");
                        result = Invoke("dotnet.exe", BenchmarksDir, args.ToArray(), false, outputPath);
                        File.Move(dir.GetFiles("*.mc").Single().FullName, baseMC);
                    }

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
                        args.Add(benchmark.Name);
                        args.Add("--corerun");
                        args.Add($"{ReleaseCoreRoot}corerun.exe");
                        args.Add("--envvars");
                        args.Add(@"DOTNET_JitEnablePhysicalPromotion:1");
                        args.Add($@"DOTNET_JitName:superpmi-shim-collector.dll");
                        args.Add($@"SuperPMIShimPath:{CheckedCoreRoot}clrjit.dll");
                        args.Add(@"SuperPMIShimLogPath:" + dir.FullName);
                        outputPath = Path.Combine(dir.FullName, "bdn_collect_diff_mc.txt");
                        result = Invoke("dotnet.exe", BenchmarksDir, args.ToArray(), false, outputPath);
                        File.Move(dir.GetFiles("*.mc").Where(fi => fi.Name != "base.mc").Single().FullName, diffMC);
                    }

                    // Step 5: Extract diffs
                    Console.WriteLine("  Extract diffs");
                    List<string> disasms = new();
                    foreach (HotFunction hf in hotFunctions)
                    {
                        if (hf.Fraction < 1)
                        {
                            break;
                        }

                        if (hf.CodeType == "native" || hf.CodeType == "?")
                            continue;

                        // Remove all instantiations, module name, and parameters
                        string name = RemoveMatched(hf.Name, '(', ')');
                        name = RemoveMatched(name, '[', ']');

                        int lastDot = name.LastIndexOf('.');
                        string className = name[..lastDot];
                        string methodName = name[(lastDot + 1)..];
                        string jitName = $"*{className}:*{methodName}";
                        disasms.Add(jitName);

                        Console.WriteLine("    {0:F2}% {1} {2} (JIT name: {3})", hf.Fraction, hf.CodeType, hf.Name, jitName);
                    }

                    // Step 6: Generate base disassembly
                    Console.WriteLine("  Generate base disasm");
                    string baseDasmFile = Path.Combine(dir.FullName, "base.dasm");
                    if (!File.Exists(baseDasmFile))
                    {
                        // Generate these in multiple invocation to avoid
                        // annoying reorderings due to the tiering queue.
                        foreach (string disasm in disasms)
                        {
                            Console.WriteLine("    {0}", disasm);
                            args.Clear();
                            args.Add($"{CheckedCoreRoot}clrjit.dll");
                            args.Add(baseMC);
                            args.Add("-jitoption");
                            args.Add("JitDisasm=" + disasm);
                            args.Add("-jitoption");
                            args.Add("JitDisasmDiffable=1");
                            args.Add("-jitoption");
                            args.Add("JitStdOutFile=" + baseDasmFile);
                            outputPath = Path.Combine(dir.FullName, "spmi_dasm_base.txt");
                            Invoke($"{CheckedCoreRoot}superpmi.exe", CheckedCoreRoot, args.ToArray(), false, outputPath, code => code == 0 || code == 3);
                        }
                    }

                    // Step 7: Generate diff disassembly
                    Console.WriteLine("  Generate diff disasm");
                    string diffDasmFile = Path.Combine(dir.FullName, "diff.dasm");
                    if (!File.Exists(diffDasmFile))
                    {
                        foreach (string disasm in disasms)
                        {
                            Console.WriteLine("    {0}", disasm);
                            args.Clear();
                            args.Add($"{CheckedCoreRoot}clrjit.dll");
                            args.Add(diffMC);
                            args.Add("-jitoption");
                            args.Add("JitEnablePhysicalPromotion=1");
                            args.Add("-jitoption");
                            args.Add("JitDisasm=" + disasm);
                            args.Add("-jitoption");
                            args.Add("JitDisasmDiffable=1");
                            args.Add("-jitoption");
                            args.Add("JitStdOutFile=" + diffDasmFile);
                            outputPath = Path.Combine(dir.FullName, "spmi_dasm_diff.txt");
                            Invoke($"{CheckedCoreRoot}superpmi.exe", CheckedCoreRoot, args.ToArray(), false, outputPath, code => code == 0 || code == 3);
                        }
                    }

                    // Step 8: Check for diffs
                    Console.WriteLine("  Check for diffs");
                    string hasDiffFile = Path.Combine(dir.FullName, "hasdiff.txt");
                    string noDiffFile = Path.Combine(dir.FullName, "nodiff.txt");
                    bool hasDiff = false;
                    File.Delete(hasDiffFile);
                    File.Delete(noDiffFile);
                    if (!File.Exists(hasDiffFile) && !File.Exists(noDiffFile))
                    {
                        args.Clear();
                        args.Add("--base");
                        args.Add(Path.Combine(dir.FullName, "base.dasm"));
                        args.Add("--diff");
                        args.Add(Path.Combine(dir.FullName, "diff.dasm"));
                        outputPath = Path.Combine(dir.FullName, "jitanalyze.txt");
                        result = Invoke($"jit-analyze.exe", CheckedCoreRoot, args.ToArray(), false, outputPath, code =>
                        {
                            hasDiff = code != 0;
                            return code == 0 || code == -1;
                        });

                        if (hasDiff)
                        {
                            File.WriteAllText(hasDiffFile, "");
                        }
                        else
                        {
                            File.WriteAllText(noDiffFile, "");
                        }
                    }
                    else
                    {
                        hasDiff = File.Exists(hasDiffFile);
                    }

                    if (hasDiff)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  Success with diff");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  Success without diff");
                    }

                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("  Failure");
                    File.WriteAllText(Path.Combine(dir.FullName, "error.txt"), ex.ToString());
                }

                Console.WriteLine();
            }
        }

        private static (string name, string[] parameterFilters) ParseBenchmarkName(string name)
        {
            int indexOfParens = name.IndexOf('(');
            if (indexOfParens == -1)
                return (name, Array.Empty<string>());

            string shortName = name[..indexOfParens];
            string args = name[(indexOfParens + 1)..^1];

            List<string> paramFilters = new();
            int index = 0;
            while (index < args.Length)
            {
                Match match = Regex.Match(args[index..], "^([A-Za-z_][A-Za-z0-9_]*): ");
                if (!match.Success)
                    throw new Exception("Expected match");

                string paramName = match.Groups[1].Value;
                string paramValue;
                index += paramName.Length + 2;
                if (args[index] == '"')
                {
                    int startIndex = ++index;
                    while (args[index] != '"')
                        index++;

                    paramValue = args[startIndex..index];
                    index++;
                }
                else
                {
                    match = Regex.Match(args[index..], ", [A-Za-z_][A-Za-z0-9_]*:");
                    if (!match.Success)
                    {
                        paramValue = args[index..];
                        index = args.Length;
                    }
                    else
                    {
                        paramValue = args[index..(index + match.Index)];
                        index += match.Index;
                    }
                }

                paramFilters.Add($"{paramName}:{paramValue}");

                if (index >= args.Length)
                    break;

                if (args[index] != ',' || args[index + 1] != ' ')
                {
                    throw new Exception("Expected , ");
                }
                index += 2;
            }

            return (shortName, paramFilters.ToArray());
        }

        private static IEnumerable<Benchmark> ReadBenchmarks()
        {
            using TextFieldParser parser = new TextFieldParser(@"C:\dev\dotnet\perf-diff-finder\regressions.csv");
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

        private static string Invoke(string fileName, string workingDir, string[] args, bool printOutput, string outputPath, Func<int, bool>? checkExitCode = null)
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

            string all = command + Environment.NewLine + Environment.NewLine + "STDOUT:" + Environment.NewLine + stdout + Environment.NewLine + Environment.NewLine + "STDERR:" + Environment.NewLine + stderr;
            File.WriteAllText(outputPath, all);

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