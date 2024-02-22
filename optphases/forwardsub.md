Diffs are based on <span style="color:#1460aa">2,447,867</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,492,573</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">9,803 (0.40%)</span>, diff: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitNoForwardSub=1


<details>
<summary>Overall (<span style="color:green">-1,835,021</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,335,474|<span style="color:green">-47,396</span>|<span style="color:green">-0.68%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,552,826|<span style="color:green">-127,170</span>|<span style="color:green">-1.71%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,714,674|<span style="color:green">-12,452</span>|<span style="color:green">-0.56%</span>|
|coreclr_tests.run.windows.x64.checked.mch|386,663,759|<span style="color:green">-427,801</span>|<span style="color:green">-0.49%</span>|
|libraries.crossgen2.windows.x64.checked.mch|44,991,166|<span style="color:green">-109,721</span>|<span style="color:green">-0.59%</span>|
|libraries.pmi.windows.x64.checked.mch|61,385,102|<span style="color:green">-216,107</span>|<span style="color:green">-0.59%</span>|
|libraries_tests.run.windows.x64.Release.mch|284,868,541|<span style="color:green">-382,655</span>|<span style="color:red">+0.07%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|135,796,023|<span style="color:green">-434,561</span>|<span style="color:green">-0.35%</span>|
|realworld.run.windows.x64.checked.mch|13,923,185|<span style="color:green">-62,371</span>|<span style="color:green">-0.33%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,124,260|<span style="color:green">-14,787</span>|<span style="color:green">-0.13%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-1,835,021</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,335,114|<span style="color:green">-47,396</span>|<span style="color:green">-0.68%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,650,202|<span style="color:green">-127,170</span>|<span style="color:green">-1.71%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,481,891|<span style="color:green">-12,452</span>|<span style="color:green">-0.56%</span>|
|coreclr_tests.run.windows.x64.checked.mch|106,220,610|<span style="color:green">-427,801</span>|<span style="color:green">-0.49%</span>|
|libraries.crossgen2.windows.x64.checked.mch|44,989,979|<span style="color:green">-109,721</span>|<span style="color:green">-0.59%</span>|
|libraries.pmi.windows.x64.checked.mch|61,271,608|<span style="color:green">-216,107</span>|<span style="color:green">-0.59%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,221,522|<span style="color:green">-382,655</span>|<span style="color:red">+0.07%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|125,503,144|<span style="color:green">-434,561</span>|<span style="color:green">-0.35%</span>|
|realworld.run.windows.x64.checked.mch|13,537,017|<span style="color:green">-62,371</span>|<span style="color:green">-0.33%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,123,313|<span style="color:green">-14,787</span>|<span style="color:green">-0.13%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-50.00%</span>) : 17541.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimePropertyInfo>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
+;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;
 ; Lcl frame size = 0
 
@@ -19,21 +19,15 @@ G_M13496_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M13496_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x18]
-       ; gcrRegs +[rax]
-       test     rax, rax
-       sete     al
-       ; gcrRegs -[rax]
-       movzx    rax, al
-       test     eax, eax
-       sete     al
-       movzx    rax, al
-						;; size=21 bbWeight=1 PerfScore 5.00
+       xor      eax, eax
+       cmp      gword ptr [rcx+0x18], 0
+       setne    al
+						;; size=10 bbWeight=1 PerfScore 4.25
 G_M13496_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 6.00, instruction count 8, allocated bytes for code 22 (MethodHash=7667cb47) for method System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
+; Total bytes of code 11, prolog size 0, PerfScore 5.25, instruction count 4, allocated bytes for code 11 (MethodHash=7667cb47) for method System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-50.00%</span>) : 17542.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimePropertyInfo>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
+;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;
 ; Lcl frame size = 0
 
@@ -19,21 +19,15 @@ G_M7927_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M7927_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x20]
-       ; gcrRegs +[rax]
-       test     rax, rax
-       sete     al
-       ; gcrRegs -[rax]
-       movzx    rax, al
-       test     eax, eax
-       sete     al
-       movzx    rax, al
-						;; size=21 bbWeight=1 PerfScore 5.00
+       xor      eax, eax
+       cmp      gword ptr [rcx+0x20], 0
+       setne    al
+						;; size=10 bbWeight=1 PerfScore 4.25
 G_M7927_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 6.00, instruction count 8, allocated bytes for code 22 (MethodHash=354be108) for method System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)
+; Total bytes of code 11, prolog size 0, PerfScore 5.25, instruction count 4, allocated bytes for code 11 (MethodHash=354be108) for method System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-50.00%</span>) : 7510.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimePropertyInfo>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
+;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;
 ; Lcl frame size = 0
 
@@ -19,21 +19,15 @@ G_M13496_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M13496_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x18]
-       ; gcrRegs +[rax]
-       test     rax, rax
-       sete     al
-       ; gcrRegs -[rax]
-       movzx    rax, al
-       test     eax, eax
-       sete     al
-       movzx    rax, al
-						;; size=21 bbWeight=1 PerfScore 5.00
+       xor      eax, eax
+       cmp      gword ptr [rcx+0x18], 0
+       setne    al
+						;; size=10 bbWeight=1 PerfScore 4.25
 G_M13496_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 6.00, instruction count 8, allocated bytes for code 22 (MethodHash=7667cb47) for method System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
+; Total bytes of code 11, prolog size 0, PerfScore 5.25, instruction count 4, allocated bytes for code 11 (MethodHash=7667cb47) for method System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+24</span> (<span style="color:red">+23.53%</span>) : 9044.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:<ConvertToSymbolicRegexNode>g__EnsureNewlinePredicateInitialized|4_0():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,21 +9,25 @@
 ;
 ;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.RegexNodeConverter>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rsi         class-hnd single-def "non-inline candidate call" <<unknown class>>
-;  V03 tmp2         [V03,T04] (  2,  2   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <<unknown class>>
-;  V04 tmp3         [V04,T02] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
-;  V05 cse0         [V05,T03] (  3,  3   )     ref  ->  rcx         "CSE - aggressive"
-;  V06 cse1         [V06,T05] (  3,  1.50)     ref  ->  rcx         "CSE - moderate"
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "non-inline candidate call" <<unknown class>>
+;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <<unknown class>>
+;  V04 tmp3         [V04,T01] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
+;  V05 tmp4         [V05,T02] (  2,  4   )     ref  ->  rsi         single-def "argument with side effect"
+;  V06 cse0         [V06,T03] (  3,  3   )     ref  ->  rcx         "CSE - aggressive"
+;  V07 cse1         [V07,T04] (  3,  1.50)     ref  ->  [rsp+0x28]  spill-single-def "CSE - moderate"
+;  TEMP_01                                   byref  ->  [rsp+0x30]
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M3085_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
+       xor      eax, eax
+       mov      qword ptr [rsp+0x30], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
+						;; size=16 bbWeight=1 PerfScore 3.75
 G_M3085_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rbx+0x10]
        ; gcrRegs +[rcx]
@@ -48,32 +52,43 @@ G_M3085_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
 G_M3085_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rcx, gword ptr [rbx+0x10]
        ; gcrRegs +[rcx]
-       mov      rbx, rcx
-       mov      rcx, gword ptr [rcx+0x08]
+       mov      gword ptr [rsp+0x28], rcx
+       ; GC ptr vars +{V07}
+       lea      rcx, bword ptr [rcx+0x88]
+       ; gcrRegs -[rcx]
+       ; byrRegs +[rcx]
+       mov      bword ptr [rsp+0x30], rcx
+       mov      rdx, gword ptr [rsp+0x28]
+       ; gcrRegs +[rdx]
+       mov      rcx, gword ptr [rdx+0x08]
+       ; gcrRegs +[rcx]
+       ; byrRegs -[rcx]
        mov      edx, 10
+       ; gcrRegs -[rdx]
        cmp      dword ptr [rcx], ecx
+       ; GC ptr vars -{V07}
        call     [System.Text.RegularExpressions.Symbolic.CharSetSolver:CreateBDDFromChar(ushort):System.Text.RegularExpressions.Symbolic.BDD:this]
-       ; gcrRegs -[rcx] +[rax]
+       ; gcrRegs -[rcx rbx] +[rax]
        ; gcr arg pop 0
-       lea      rcx, bword ptr [rbx+0x88]
+       mov      rcx, bword ptr [rsp+0x30]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
-       ; gcrRegs -[rax rdx rbx]
+       ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
-						;; size=39 bbWeight=0.50 PerfScore 6.12
+						;; size=56 bbWeight=0.50 PerfScore 8.00
 G_M3085_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        nop      
 						;; size=1 bbWeight=1 PerfScore 0.25
 G_M3085_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 56
        pop      rbx
        pop      rsi
        ret      
 						;; size=7 bbWeight=1 PerfScore 2.25
 
-; Total bytes of code 102, prolog size 6, PerfScore 28.12, instruction count 29, allocated bytes for code 102 (MethodHash=ceb5f3f2) for method System.Text.RegularExpressions.Symbolic.RegexNodeConverter:<ConvertToSymbolicRegexNode>g__EnsureNewlinePredicateInitialized|4_0():this (FullOpts)
+; Total bytes of code 126, prolog size 13, PerfScore 31.25, instruction count 34, allocated bytes for code 126 (MethodHash=ceb5f3f2) for method System.Text.RegularExpressions.Symbolic.RegexNodeConverter:<ConvertToSymbolicRegexNode>g__EnsureNewlinePredicateInitialized|4_0():this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -86,6 +101,6 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+38.89%</span>) : 22011.dasm - Microsoft.Extensions.Configuration.JsonConfigurationExtensions+<>c__DisplayClass5_0:<AddJsonStream>b__0(Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,32 +9,35 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Extensions.Configuration.JsonConfigurationExtensions+<>c__DisplayClass5_0>
-;  V01 arg1         [V01,T01] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource>
+;  V01 arg1         [V01,T01] (  3,  3   )     ref  ->  [rsp+0x10]  class-hnd single-def <Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T02] (  2,  4   )     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.IO.Stream>
+;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.IO.Stream>
 ;
 ; Lcl frame size = 0
 
 G_M15057_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M15057_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs +[rcx rdx]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       lea      rcx, bword ptr [rdx+0x08]
+       mov      gword ptr [rsp+0x10], rdx
+       ; GC ptr vars +{V01}
+						;; size=5 bbWeight=1 PerfScore 1.00
+G_M15057_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V01}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[rcx]
+       mov      rdx, gword ptr [rcx+0x08]
+       ; gcrRegs +[rdx]
+       mov      rcx, gword ptr [rsp+0x10]
+       lea      rcx, bword ptr [rcx+0x08]
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       mov      rdx, rax
+       ; GC ptr vars -{V01}
        call     CORINFO_HELP_ASSIGN_REF
-       ; gcrRegs -[rax rdx]
+       ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        nop      
-						;; size=17 bbWeight=1 PerfScore 4.00
+						;; size=19 bbWeight=1 PerfScore 4.75
 G_M15057_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 18, prolog size 0, PerfScore 5.00, instruction count 6, allocated bytes for code 18 (MethodHash=89a3c52e) for method Microsoft.Extensions.Configuration.JsonConfigurationExtensions+<>c__DisplayClass5_0:<AddJsonStream>b__0(Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource):this (FullOpts)
+; Total bytes of code 25, prolog size 0, PerfScore 6.75, instruction count 7, allocated bytes for code 25 (MethodHash=89a3c52e) for method Microsoft.Extensions.Configuration.JsonConfigurationExtensions+<>c__DisplayClass5_0:<AddJsonStream>b__0(Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+42</span> (<span style="color:red">+53.16%</span>) : 35453.dasm - System.Numerics.Tests.Perf_Matrix4x4:TranslationBenchmark():System.Numerics.Vector3:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,20 +12,17 @@
 ;  V01 RetBuf       [V01,T00] (  4,  4   )   byref  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op <System.Numerics.Matrix4x4>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T01] (  2,  2   )  struct (64) [rsp+0x08]  do-not-enreg[S] must-init ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix4x4+Impl>
-;* V05 tmp2         [V05    ] (  0,  0   )  struct (64) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix4x4+Impl>
-;  V06 tmp3         [V06,T02] (  2,  4   )  simd12  ->  mm0         ld-addr-op "NewObj constructor temp" <System.Numerics.Vector3>
-;* V07 tmp4         [V07    ] (  0,  0   )  simd16  ->  zero-ref    single-def "field V05.X (fldOffset=0x0)" P-INDEP
-;* V08 tmp5         [V08    ] (  0,  0   )  simd16  ->  zero-ref    single-def "field V05.Y (fldOffset=0x10)" P-INDEP
-;* V09 tmp6         [V09    ] (  0,  0   )  simd16  ->  zero-ref    single-def "field V05.Z (fldOffset=0x20)" P-INDEP
-;* V10 tmp7         [V10,T03] (  0,  0   )  simd16  ->  zero-ref    single-def "field V05.W (fldOffset=0x30)" P-INDEP
+;* V04 tmp1         [V04    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix4x4+Impl>
+;  V05 tmp2         [V05    ] (  5,  5   )  struct (64) [rsp+0x08]  do-not-enreg[SF] must-init ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix4x4+Impl>
+;* V06 tmp3         [V06    ] (  0,  0   )  simd12  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector3>
+;  V07 tmp4         [V07,T01] (  2,  2   )  simd16  ->  [rsp+0x08]  do-not-enreg[S] single-def "field V05.X (fldOffset=0x0)" P-DEP
+;  V08 tmp5         [V08,T02] (  2,  2   )  simd16  ->  [rsp+0x18]  do-not-enreg[S] single-def "field V05.Y (fldOffset=0x10)" P-DEP
+;  V09 tmp6         [V09,T03] (  2,  2   )  simd16  ->  [rsp+0x28]  do-not-enreg[S] single-def "field V05.Z (fldOffset=0x20)" P-DEP
+;  V10 tmp7         [V10,T04] (  2,  2   )  simd16  ->  [rsp+0x38]  do-not-enreg[S] single-def "field V05.W (fldOffset=0x30)" P-DEP
 ;* V11 tmp8         [V11    ] (  0,  0   )  simd16  ->  zero-ref    "V02.[000..016)"
 ;* V12 tmp9         [V12    ] (  0,  0   )  simd16  ->  zero-ref    "V02.[016..032)"
 ;* V13 tmp10        [V13    ] (  0,  0   )  simd16  ->  zero-ref    "V02.[032..048)"
 ;* V14 tmp11        [V14    ] (  0,  0   )  simd12  ->  zero-ref    "V02.[048..060)"
-;* V15 tmp12        [V15    ] (  0,  0   )  simd16  ->  zero-ref    single-def "V04.[000..016)"
-;* V16 tmp13        [V16    ] (  0,  0   )  simd16  ->  zero-ref    single-def "V04.[016..032)"
-;* V17 tmp14        [V17    ] (  0,  0   )  simd16  ->  zero-ref    single-def "V04.[032..048)"
 ;
 ; Lcl frame size = 72
 
@@ -41,6 +38,12 @@ G_M22215_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M22215_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
        vmovups  xmm0, xmmword ptr [reloc @RWD00]
+       vmovups  xmmword ptr [rsp+0x08], xmm0
+       vmovups  xmm0, xmmword ptr [reloc @RWD16]
+       vmovups  xmmword ptr [rsp+0x18], xmm0
+       vmovups  xmm0, xmmword ptr [reloc @RWD32]
+       vmovups  xmmword ptr [rsp+0x28], xmm0
+       vmovups  xmm0, xmmword ptr [reloc @RWD48]
        vmovups  xmmword ptr [rsp+0x38], xmm0
        vmovsd   xmm0, qword ptr [rsp+0x38]
        vinsertps xmm0, xmm0, dword ptr [rsp+0x40], 40
@@ -48,15 +51,18 @@ G_M22215_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        vextractps dword ptr [rdx+0x08], xmm0, 2
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=42 bbWeight=1 PerfScore 15.25
+						;; size=84 bbWeight=1 PerfScore 27.25
 G_M22215_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 72
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-RWD00  	dq	0000000000000000h, 3F80000000000000h
+RWD00  	dq	000000003F800000h, 0000000000000000h
+RWD16  	dq	3F80000000000000h, 0000000000000000h
+RWD32  	dq	0000000000000000h, 000000003F800000h
+RWD48  	dq	0000000000000000h, 3F80000000000000h
 
 
-; Total bytes of code 79, prolog size 32, PerfScore 23.33, instruction count 16, allocated bytes for code 79 (MethodHash=883da938) for method System.Numerics.Tests.Perf_Matrix4x4:TranslationBenchmark():System.Numerics.Vector3:this (FullOpts)
+; Total bytes of code 121, prolog size 32, PerfScore 35.33, instruction count 22, allocated bytes for code 121 (MethodHash=883da938) for method System.Numerics.Tests.Perf_Matrix4x4:TranslationBenchmark():System.Numerics.Vector3:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-13</span> (<span style="color:green">-56.52%</span>) : 68249.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,8 +9,8 @@
 ;
 ;  V00 arg0         [V00,T00] (  3,  3   )    long  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
-;  V02 loc0         [V02,T02] (  2,  2   )     int  ->  rdx         single-def
-;  V03 loc1         [V03,T03] (  2,  2   )    long  ->  rax         single-def
+;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
+;* V03 loc1         [V03    ] (  0,  0   )    long  ->  zero-ref   
 ;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -18,18 +18,15 @@
 G_M58437_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58437_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       and      edx, 63
-       mov      eax, 1
-       shlx     rax, rax, rdx
-       test     rcx, rax
-       setne    al
-       movzx    rax, al
-						;; size=22 bbWeight=1 PerfScore 2.50
+       xor      eax, eax
+       bt       rcx, rdx
+       setb     al
+						;; size=9 bbWeight=1 PerfScore 1.75
 G_M58437_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 23, prolog size 0, PerfScore 3.50, instruction count 7, allocated bytes for code 23 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
+; Total bytes of code 10, prolog size 0, PerfScore 2.75, instruction count 4, allocated bytes for code 10 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-50.00%</span>) : 99528.dasm - System.Decimal:CreateChecked[System.Decimal](System.Decimal):System.Decimal (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,16 +7,16 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T01] (  6,  6   )   byref  ->  rcx         single-def
-;  V01 arg0         [V01,T00] (  5, 10   )   byref  ->  rdx         single-def
+;  V00 RetBuf       [V00,T01] (  4,  4   )   byref  ->  rcx         single-def
+;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Decimal>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     int  ->  zero-ref    "field V01._flags (fldOffset=0x0)" P-INDEP
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref    "field V01._hi32 (fldOffset=0x4)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "field V01._lo64 (fldOffset=0x8)" P-INDEP
-;  V07 tmp4         [V07,T02] (  2,  2   )     int  ->  rax         "field V02._flags (fldOffset=0x0)" P-INDEP
-;  V08 tmp5         [V08,T03] (  2,  2   )     int  ->   r8         "field V02._hi32 (fldOffset=0x4)" P-INDEP
-;  V09 tmp6         [V09,T04] (  2,  2   )    long  ->  rdx         "field V02._lo64 (fldOffset=0x8)" P-INDEP
+;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    "field V02._flags (fldOffset=0x0)" P-INDEP
+;* V08 tmp5         [V08    ] (  0,  0   )     int  ->  zero-ref    "field V02._hi32 (fldOffset=0x4)" P-INDEP
+;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V02._lo64 (fldOffset=0x8)" P-INDEP
 ;* V10 tmp7         [V10    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Decimal>
 ;
 ; Lcl frame size = 0
@@ -25,21 +25,16 @@ G_M25118_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M25118_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
-       mov      eax, dword ptr [rdx]
-       mov      r8d, dword ptr [rdx+0x04]
-       mov      rdx, qword ptr [rdx+0x08]
-       ; byrRegs -[rdx]
-       mov      dword ptr [rcx], eax
-       mov      dword ptr [rcx+0x04], r8d
-       mov      qword ptr [rcx+0x08], rdx
+       vmovups  xmm0, xmmword ptr [rdx]
+       vmovups  xmmword ptr [rcx], xmm0
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=23 bbWeight=1 PerfScore 9.25
+						;; size=11 bbWeight=1 PerfScore 6.25
 G_M25118_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 24, prolog size 0, PerfScore 10.25, instruction count 8, allocated bytes for code 24 (MethodHash=72169de1) for method System.Decimal:CreateChecked[System.Decimal](System.Decimal):System.Decimal (Tier1)
+; Total bytes of code 12, prolog size 0, PerfScore 7.25, instruction count 4, allocated bytes for code 12 (MethodHash=72169de1) for method System.Decimal:CreateChecked[System.Decimal](System.Decimal):System.Decimal (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-50.00%</span>) : 99534.dasm - System.Decimal:CreateTruncating[System.Decimal](System.Decimal):System.Decimal (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,16 +7,16 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T01] (  6,  6   )   byref  ->  rcx         single-def
-;  V01 arg0         [V01,T00] (  5, 10   )   byref  ->  rdx         single-def
+;  V00 RetBuf       [V00,T01] (  4,  4   )   byref  ->  rcx         single-def
+;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Decimal>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     int  ->  zero-ref    "field V01._flags (fldOffset=0x0)" P-INDEP
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref    "field V01._hi32 (fldOffset=0x4)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "field V01._lo64 (fldOffset=0x8)" P-INDEP
-;  V07 tmp4         [V07,T02] (  2,  2   )     int  ->  rax         "field V02._flags (fldOffset=0x0)" P-INDEP
-;  V08 tmp5         [V08,T03] (  2,  2   )     int  ->   r8         "field V02._hi32 (fldOffset=0x4)" P-INDEP
-;  V09 tmp6         [V09,T04] (  2,  2   )    long  ->  rdx         "field V02._lo64 (fldOffset=0x8)" P-INDEP
+;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    "field V02._flags (fldOffset=0x0)" P-INDEP
+;* V08 tmp5         [V08    ] (  0,  0   )     int  ->  zero-ref    "field V02._hi32 (fldOffset=0x4)" P-INDEP
+;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V02._lo64 (fldOffset=0x8)" P-INDEP
 ;* V10 tmp7         [V10    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Decimal>
 ;
 ; Lcl frame size = 0
@@ -25,21 +25,16 @@ G_M16658_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M16658_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
-       mov      eax, dword ptr [rdx]
-       mov      r8d, dword ptr [rdx+0x04]
-       mov      rdx, qword ptr [rdx+0x08]
-       ; byrRegs -[rdx]
-       mov      dword ptr [rcx], eax
-       mov      dword ptr [rcx+0x04], r8d
-       mov      qword ptr [rcx+0x08], rdx
+       vmovups  xmm0, xmmword ptr [rdx]
+       vmovups  xmmword ptr [rcx], xmm0
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=23 bbWeight=1 PerfScore 9.25
+						;; size=11 bbWeight=1 PerfScore 6.25
 G_M16658_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 24, prolog size 0, PerfScore 10.25, instruction count 8, allocated bytes for code 24 (MethodHash=7070beed) for method System.Decimal:CreateTruncating[System.Decimal](System.Decimal):System.Decimal (Tier1)
+; Total bytes of code 12, prolog size 0, PerfScore 7.25, instruction count 4, allocated bytes for code 12 (MethodHash=7070beed) for method System.Decimal:CreateTruncating[System.Decimal](System.Decimal):System.Decimal (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+8</span> (<span style="color:red">+17.78%</span>) : 71871.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:get_Reachable():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,50 +9,55 @@
 ; 1 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  3,  3   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T00] (  4,  4   )   byref  ->  rcx         this single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )   byref  ->  rax         single-def "Inlining Arg"
-;  V03 tmp2         [V03,T04] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V04 tmp3         [V04,T02] (  2,  4   )   byref  ->  rcx         single-def "Inlining Arg"
+;* V02 tmp1         [V02    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;  V03 tmp2         [V03,T02] (  3,  2   )   ubyte  ->  rcx         "Inline return value spill temp"
+;  V04 tmp3         [V04,T01] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
 ;* V05 tmp4         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V06 tmp5         [V06,T05] (  2,  2   )    long  ->  rax        
+;  V06 tmp5         [V06,T03] (  2,  2   )    long  ->  rcx        
 ;* V07 tmp6         [V07    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V08 tmp7         [V08    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V09 tmp8         [V09    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;  V10 cse0         [V10,T03] (  3,  3   )   byref  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M59635_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M59635_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M59635_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        ; byrRegs +[rcx]
+       cmp      dword ptr [rcx+0x18], 0
+       jle      SHORT G_M59635_IG05
        add      rcx, 8
-       mov      rax, rcx
-       ; byrRegs +[rax]
-       cmp      dword ptr [rax+0x10], 0
-       jle      SHORT G_M59635_IG04
-       mov      rax, qword ptr [rcx+0x08]
-       ; byrRegs -[rax]
-       and      eax, 1
+       cmp      dword ptr [rcx+0x10], 0
+       jle      SHORT G_M59635_IG07
+       mov      rcx, qword ptr [rcx+0x08]
+       ; byrRegs -[rcx]
+       and      ecx, 1
+						;; size=23 bbWeight=1 PerfScore 10.50
+G_M59635_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       xor      eax, eax
+       test     ecx, ecx
        sete     al
-       movzx    rax, al
-						;; size=26 bbWeight=1 PerfScore 8.00
-G_M59635_IG03:        ; bbWeight=1, epilog, nogc, extend
+						;; size=7 bbWeight=1 PerfScore 1.50
+G_M59635_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M59635_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rcx]
+G_M59635_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M59635_IG05:        ; bbWeight=0, epilog, nogc, extend
+G_M59635_IG06:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0 PerfScore 0.00
+G_M59635_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       xor      ecx, ecx
+       jmp      SHORT G_M59635_IG03
+						;; size=4 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 45, prolog size 4, PerfScore 9.50, instruction count 14, allocated bytes for code 45 (MethodHash=2287170c) for method Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:get_Reachable():ubyte:this (Tier1)
+; Total bytes of code 53, prolog size 4, PerfScore 13.50, instruction count 18, allocated bytes for code 53 (MethodHash=2287170c) for method Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:get_Reachable():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+18.52%</span>) : 17173.dasm - (dynamicClass):IL_STUB_PInvoke(uint,ulong):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,51 +8,57 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  3,  3   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  3,  3   )    long  ->  rdx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )    long  ->  rbx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
-;  V03 loc1         [V03,T03] (  2,  2   )    long  ->  rcx        
+;  V03 loc1         [V03,T03] (  2,  2   )    long  ->  rsi        
 ;* V04 loc2         [V04    ] (  0,  0   )    long  ->  zero-ref   
 ;* V05 loc3         [V05    ] (  0,  0   )     int  ->  zero-ref   
-;  V06 loc4         [V06,T04] (  2,  2   )     int  ->  rbx        
+;* V06 loc4         [V06    ] (  0,  0   )     int  ->  zero-ref   
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T05] (  2,  2   )    long  ->  [rbp-0x10]  do-not-enreg[V] "stub argument"
-;  V09 tmp2         [V09,T02] (  2,  4   )    long  ->  rax         "impImportIndirectCall"
+;  V08 tmp1         [V08,T04] (  2,  2   )    long  ->  [rbp-0x20]  do-not-enreg[V] "stub argument"
+;  V09 tmp2         [V09,T02] (  2,  4   )    long  ->  rdi         "impImportIndirectCall"
 ;
 ; Lcl frame size = 40
 
 G_M27570_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbp
+       push     rdi
+       push     rsi
        push     rbx
        sub      rsp, 40
-       lea      rbp, [rsp+0x30]
-       mov      qword ptr [rbp-0x10], r10
-						;; size=15 bbWeight=1 PerfScore 3.75
-G_M27570_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      ecx, ecx
-       mov      rax, qword ptr [rbp-0x10]
-       mov      rax, qword ptr [rax+0x40]
-						;; size=10 bbWeight=1 PerfScore 3.25
-G_M27570_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       call     rax
-       mov      ebx, eax
+       lea      rbp, [rsp+0x40]
+       mov      qword ptr [rbp-0x20], r10
+       mov      rbx, rdx
+						;; size=20 bbWeight=1 PerfScore 6.00
+G_M27570_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      esi, ecx
+       mov      rcx, qword ptr [rbp-0x20]
+       mov      rdi, qword ptr [rcx+0x40]
        cmp      dword ptr [(reloc)], 0
        jne      SHORT G_M27570_IG06
-						;; size=13 bbWeight=1 PerfScore 7.25
+						;; size=19 bbWeight=1 PerfScore 7.25
+G_M27570_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, rsi
+       mov      rdx, rbx
+						;; size=6 bbWeight=1 PerfScore 0.50
 G_M27570_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, ebx
-						;; size=2 bbWeight=1 PerfScore 0.25
+       call     rdi
+       nop      
+						;; size=3 bbWeight=1 PerfScore 3.25
 G_M27570_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M27570_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        call     CORINFO_HELP_POLL_GC
-       jmp      SHORT G_M27570_IG04
+       jmp      SHORT G_M27570_IG03
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 54, prolog size 15, PerfScore 16.75, instruction count 19, allocated bytes for code 54 (MethodHash=2380944d) for method (dynamicClass):IL_STUB_PInvoke(uint,ulong):int (FullOpts)
+; Total bytes of code 64, prolog size 17, PerfScore 20.25, instruction count 25, allocated bytes for code 64 (MethodHash=2380944d) for method (dynamicClass):IL_STUB_PInvoke(uint,ulong):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -60,11 +66,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+17</span> (<span style="color:red">+21.79%</span>) : 71725.dasm - Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,46 +9,46 @@
 ; 1 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  7,  3.67)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis>
+;  V00 this         [V00,T00] (  9,  4.67)     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    "location for address-of(RValue)" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ISymbol]>
 ;* V03 tmp2         [V03    ] (  0,  0   )  struct ( 8) zero-ref    "guarded devirt return temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ISymbol]>
-;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis>
-;  V05 tmp4         [V05,T02] (  2,  4   )   byref  ->  rax         single-def "Inlining Arg"
-;  V06 tmp5         [V06,T00] (  5,  6   )   byref  ->  rbx         single-def "Inlining Arg"
+;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis>
+;* V05 tmp4         [V05    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;  V06 tmp5         [V06,T01] (  5,  6   )   byref  ->  rbx         single-def "Inlining Arg"
 ;* V07 tmp6         [V07    ] (  0,  0   )     ref  ->  zero-ref    "field V02.array (fldOffset=0x0)" P-INDEP
 ;* V08 tmp7         [V08    ] (  0,  0   )     ref  ->  zero-ref    "field V03.array (fldOffset=0x0)" P-INDEP
-;  V09 cse0         [V09,T03] (  4,  3   )   byref  ->  rbx         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
 G_M10823_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
        sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M10823_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rcx]
-       lea      rbx, bword ptr [rcx+0xC0]
-       ; byrRegs +[rbx]
-       mov      rax, rbx
-       ; byrRegs +[rax]
-       cmp      byte  ptr [rax], 0
+       mov      rbx, rcx
+       ; gcrRegs +[rbx]
+						;; size=8 bbWeight=1 PerfScore 1.50
+G_M10823_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       cmp      byte  ptr [rbx+0xC0], 0
        jne      SHORT G_M10823_IG04
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M10823_IG03:        ; bbWeight=0.33, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref, isz
-       ; byrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
-       cmp      qword ptr [rcx], rax
+						;; size=9 bbWeight=1 PerfScore 4.00
+G_M10823_IG03:        ; bbWeight=0.33, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
+       cmp      qword ptr [rbx], rcx
        jne      SHORT G_M10823_IG07
+       mov      rcx, rbx
+       ; gcrRegs +[rcx]
        call     [Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_DataFlowsIn():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ISymbol]:this]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-						;; size=21 bbWeight=0.33 PerfScore 2.42
-G_M10823_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=24 bbWeight=0.33 PerfScore 2.50
+G_M10823_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
+       add      rbx, 192
+       ; gcrRegs -[rbx]
+       ; byrRegs +[rbx]
        cmp      byte  ptr [rbx], 0
        je       SHORT G_M10823_IG08
-						;; size=5 bbWeight=1 PerfScore 4.00
+						;; size=12 bbWeight=1 PerfScore 4.25
 G_M10823_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        movzx    rax, byte  ptr [rbx+0x01]
 						;; size=4 bbWeight=1 PerfScore 2.00
@@ -57,16 +57,22 @@ G_M10823_IG06:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
-G_M10823_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+G_M10823_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rbx]
+       ; byrRegs -[rbx]
+       mov      rcx, rbx
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rcx]
+       mov      rax, qword ptr [rbx]
        mov      rax, qword ptr [rax+0x48]
        call     [rax+0x28]<unknown method>
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
+       add      rbx, 192
+       ; gcrRegs -[rbx]
+       ; byrRegs +[rbx]
        cmp      byte  ptr [rbx], 0
        jne      SHORT G_M10823_IG05
-						;; size=15 bbWeight=0 PerfScore 0.00
+						;; size=25 bbWeight=0 PerfScore 0.00
 G_M10823_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        ; byrRegs -[rbx]
@@ -75,7 +81,7 @@ G_M10823_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 78, prolog size 5, PerfScore 16.17, instruction count 23, allocated bytes for code 78 (MethodHash=afbfd5b8) for method Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)
+; Total bytes of code 95, prolog size 5, PerfScore 16.00, instruction count 26, allocated bytes for code 95 (MethodHash=afbfd5b8) for method Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-13</span> (<span style="color:green">-56.52%</span>) : 43823.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,8 +9,8 @@
 ;
 ;  V00 arg0         [V00,T00] (  3,  3   )    long  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
-;  V02 loc0         [V02,T02] (  2,  2   )     int  ->  rdx         single-def
-;  V03 loc1         [V03,T03] (  2,  2   )    long  ->  rax         single-def
+;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
+;* V03 loc1         [V03    ] (  0,  0   )    long  ->  zero-ref   
 ;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -18,18 +18,15 @@
 G_M58437_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58437_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       and      edx, 63
-       mov      eax, 1
-       shlx     rax, rax, rdx
-       test     rcx, rax
-       setne    al
-       movzx    rax, al
-						;; size=22 bbWeight=1 PerfScore 2.50
+       xor      eax, eax
+       bt       rcx, rdx
+       setb     al
+						;; size=9 bbWeight=1 PerfScore 1.75
 G_M58437_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 23, prolog size 0, PerfScore 3.50, instruction count 7, allocated bytes for code 23 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
+; Total bytes of code 10, prolog size 0, PerfScore 2.75, instruction count 4, allocated bytes for code 10 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-50.00%</span>) : 28097.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimePropertyInfo>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
+;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;
 ; Lcl frame size = 0
 
@@ -19,21 +19,15 @@ G_M7927_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M7927_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x20]
-       ; gcrRegs +[rax]
-       test     rax, rax
-       sete     al
-       ; gcrRegs -[rax]
-       movzx    rax, al
-       test     eax, eax
-       sete     al
-       movzx    rax, al
-						;; size=21 bbWeight=1 PerfScore 5.00
+       xor      eax, eax
+       cmp      gword ptr [rcx+0x20], 0
+       setne    al
+						;; size=10 bbWeight=1 PerfScore 4.25
 G_M7927_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 6.00, instruction count 8, allocated bytes for code 22 (MethodHash=354be108) for method System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (Tier1)
+; Total bytes of code 11, prolog size 0, PerfScore 5.25, instruction count 4, allocated bytes for code 11 (MethodHash=354be108) for method System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-50.00%</span>) : 28130.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimePropertyInfo>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
+;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;
 ; Lcl frame size = 0
 
@@ -19,21 +19,15 @@ G_M13496_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M13496_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x18]
-       ; gcrRegs +[rax]
-       test     rax, rax
-       sete     al
-       ; gcrRegs -[rax]
-       movzx    rax, al
-       test     eax, eax
-       sete     al
-       movzx    rax, al
-						;; size=21 bbWeight=1 PerfScore 5.00
+       xor      eax, eax
+       cmp      gword ptr [rcx+0x18], 0
+       setne    al
+						;; size=10 bbWeight=1 PerfScore 4.25
 G_M13496_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 6.00, instruction count 8, allocated bytes for code 22 (MethodHash=7667cb47) for method System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (Tier1)
+; Total bytes of code 11, prolog size 0, PerfScore 5.25, instruction count 4, allocated bytes for code 11 (MethodHash=7667cb47) for method System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+30</span> (<span style="color:red">+9.90%</span>) : 44337.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+MembersAndInitializersBuilder:ToReadOnlyAndFree(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]):System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,40 +8,40 @@
 ; 0 inlinees with PGO data; 17 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T07] (  7,  8.50)     ref  ->  rbx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
-;  V01 loc0         [V01,T16] (  3,  3   )     ref  ->  rdi         class-hnd exact single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
+;  V00 arg0         [V00,T07] (  8, 12.50)     ref  ->  rbx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
+;  V01 loc0         [V01,T12] (  3,  5   )     ref  ->  rdi         class-hnd exact single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
 ;* V02 loc1         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
-;  V03 loc2         [V03,T13] (  2,  4   )     ref  ->  rcx         class-hnd exact <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]>
+;* V03 loc2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]>
-;  V06 tmp2         [V06,T14] (  2,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;  V07 tmp3         [V07,T19] (  2,  2   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;  V08 tmp4         [V08,T17] (  3,  3   )     ref  ->  rdi         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
-;  V09 tmp5         [V09,T18] (  3,  3   )     int  ->  rsi         "Inlining Arg"
-;  V10 tmp6         [V10,T20] (  2,  2   )     ref  ->  rdx         class-hnd exact single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
+;* V06 tmp2         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;* V07 tmp3         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V08 tmp4         [V08,T13] (  3,  3   )     ref  ->  rdi         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
+;  V09 tmp5         [V09,T14] (  3,  3   )     int  ->  rsi         "Inlining Arg"
+;* V10 tmp6         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
 ;* V11 tmp7         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
 ;* V12 tmp8         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
 ;* V13 tmp9         [V13    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V14 tmp10        [V14,T10] (  2,  8   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;  V15 tmp11        [V15,T00] (  7, 28   )     ref  ->  r14         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
-;  V16 tmp12        [V16,T08] (  5, 10   )     int  ->  r15         "Inline stloc first use temp"
+;  V14 tmp10        [V14,T02] (  3, 24   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V15 tmp11        [V15,T00] (  7, 52   )     ref  ->  r14         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]>
+;  V16 tmp12        [V16,T06] (  5, 16   )     int  ->  r15         "Inline stloc first use temp"
 ;* V17 tmp13        [V17    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V18 tmp14        [V18,T12] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
-;  V19 tmp15        [V19,T05] (  3, 12   )     int  ->  rdx         "Inlining Arg"
+;  V18 tmp14        [V18,T11] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
+;  V19 tmp15        [V19,T08] (  3, 12   )     int  ->  rdx         "Inlining Arg"
 ;* V20 tmp16        [V20    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V21 tmp17        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
-;  V22 tmp18        [V22,T02] (  2, 16   )     ref  ->  rax         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;* V23 tmp19        [V23,T22] (  0,  0   )     ref  ->  zero-ref    single-def "field V02._builder (fldOffset=0x0)" P-INDEP
-;  V24 tmp20        [V24,T01] (  6, 16.50)     int  ->  rsi         "field V02._index (fldOffset=0x8)" P-INDEP
-;  V25 tmp21        [V25,T15] (  2,  4   )     ref  ->  rbp         "field V05.array (fldOffset=0x0)" P-INDEP
-;* V26 tmp22        [V26,T23] (  0,  0   )     ref  ->  zero-ref    single-def "field V11._builder (fldOffset=0x0)" P-INDEP
-;* V27 tmp23        [V27,T24] (  0,  0   )     int  ->  zero-ref    single-def "field V11._index (fldOffset=0x8)" P-INDEP
-;  V28 tmp24        [V28,T03] (  3, 12   )     ref  ->  rcx         "arr expr"
-;  V29 tmp25        [V29,T04] (  3, 12   )     ref  ->  rcx         "arr expr"
-;  V30 tmp26        [V30,T06] (  3, 12   )     int  ->  rdx         "index expr"
-;  V31 cse0         [V31,T11] (  3,  6   )     ref  ->  rcx         "CSE - moderate"
+;* V22 tmp18        [V22    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;* V23 tmp19        [V23,T17] (  0,  0   )     ref  ->  zero-ref    single-def "field V02._builder (fldOffset=0x0)" P-INDEP
+;  V24 tmp20        [V24,T01] (  7, 24.50)     int  ->  rsi         "field V02._index (fldOffset=0x8)" P-INDEP
+;  V25 tmp21        [V25,T10] (  2,  8   )     ref  ->  rbp         "field V05.array (fldOffset=0x0)" P-INDEP
+;* V26 tmp22        [V26,T18] (  0,  0   )     ref  ->  zero-ref    single-def "field V11._builder (fldOffset=0x0)" P-INDEP
+;* V27 tmp23        [V27,T19] (  0,  0   )     int  ->  zero-ref    single-def "field V11._index (fldOffset=0x8)" P-INDEP
+;  V28 tmp24        [V28,T03] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V29 tmp25        [V29,T04] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V30 tmp26        [V30,T05] (  3, 24   )     int  ->  rdx         "index expr"
+;  V31 cse0         [V31,T15] (  3,  2.50)     int  ->  rsi         "CSE - moderate"
 ;  V32 cse1         [V32,T09] (  3, 10   )     ref  ->  rcx         "CSE - aggressive"
-;  V33 cse2         [V33,T21] (  3,  1.50)     ref  ->  rcx         "CSE - moderate"
+;  V33 cse2         [V33,T16] (  3,  1.50)     ref  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
@@ -59,9 +59,10 @@ G_M16387_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M16387_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rbx+0x08]
        ; gcrRegs +[rcx]
-       cmp      dword ptr [rcx+0x10], 0
+       mov      esi, dword ptr [rcx+0x10]
+       test     esi, esi
        jne      SHORT G_M16387_IG05
-						;; size=10 bbWeight=1 PerfScore 6.00
+						;; size=11 bbWeight=1 PerfScore 5.25
 G_M16387_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        mov      rcx, rbx
@@ -86,11 +87,7 @@ G_M16387_IG04:        ; bbWeight=0.50, epilog, nogc, extend
 						;; size=13 bbWeight=0.50 PerfScore 2.12
 G_M16387_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax] +[rbx]
-       mov      rcx, gword ptr [rbx+0x08]
-       ; gcrRegs +[rcx]
-       mov      esi, dword ptr [rcx+0x10]
        mov      rcx, 0xD1FFAB1E
-       ; gcrRegs -[rcx]
        mov      edx, 80
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        ; gcr arg pop 0
@@ -105,9 +102,8 @@ G_M16387_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs +[rdi]
        mov      rcx, gword ptr [rdi+0x08]
        ; gcrRegs +[rcx]
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
-       mov      rdx, gword ptr [rdx+0x08]
        cmp      dword ptr [rdx+0x08], esi
        jge      SHORT G_M16387_IG06
        mov      edx, esi
@@ -115,13 +111,20 @@ G_M16387_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        call     [System.Collections.Immutable.ImmutableArray`1+Builder[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]:set_Capacity(int):this]
        ; gcrRegs -[rax rcx]
        ; gcr arg pop 0
-						;; size=75 bbWeight=0.50 PerfScore 12.75
-G_M16387_IG06:        ; bbWeight=0.50, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      esi, -1
-       jmp      SHORT G_M16387_IG10
-						;; size=7 bbWeight=0.50 PerfScore 1.12
-G_M16387_IG07:        ; bbWeight=2, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref, isz
+						;; size=65 bbWeight=0.50 PerfScore 10.62
+G_M16387_IG06:        ; bbWeight=0.50, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
+       xor      esi, esi
+       mov      rcx, gword ptr [rbx+0x08]
        ; gcrRegs +[rcx]
+       cmp      dword ptr [rcx+0x10], 0
+       jle      G_M16387_IG11
+						;; size=16 bbWeight=0.50 PerfScore 3.12
+G_M16387_IG07:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, gword ptr [rbx+0x08]
+       ; gcrRegs +[rcx]
+       cmp      esi, dword ptr [rcx+0x10]
+       jge      G_M16387_IG14
        mov      rcx, gword ptr [rcx+0x08]
        cmp      esi, dword ptr [rcx+0x08]
        jae      G_M16387_IG13
@@ -140,22 +143,25 @@ G_M16387_IG07:        ; bbWeight=2, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000
        mov      rcx, gword ptr [r14+0x08]
        ; gcrRegs +[rcx]
        cmp      dword ptr [rcx+0x08], r15d
-       jge      SHORT G_M16387_IG09
+       jge      SHORT G_M16387_IG10
+						;; size=65 bbWeight=4 PerfScore 123.00
+G_M16387_IG08:        ; bbWeight=2, gcrefRegs=40AA {rcx rbx rbp rdi r14}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rax]
        mov      edx, dword ptr [rcx+0x08]
        add      edx, edx
        cmp      edx, r15d
-       jge      SHORT G_M16387_IG08
+       jge      SHORT G_M16387_IG09
        mov      edx, r15d
-						;; size=65 bbWeight=2 PerfScore 57.00
-G_M16387_IG08:        ; bbWeight=2, gcrefRegs=40A8 {rbx rbp rdi r14}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rcx]
+						;; size=13 bbWeight=2 PerfScore 7.50
+G_M16387_IG09:        ; bbWeight=2, gcrefRegs=40A8 {rbx rbp rdi r14}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rcx]
        lea      rcx, bword ptr [r14+0x08]
        ; byrRegs +[rcx]
        call     [System.Array:Resize[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]](byref,int)]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
 						;; size=10 bbWeight=2 PerfScore 7.00
-G_M16387_IG09:        ; bbWeight=2, gcrefRegs=40A8 {rbx rbp rdi r14}, byrefRegs=0000 {}, byref, isz
+G_M16387_IG10:        ; bbWeight=4, gcrefRegs=40A8 {rbx rbp rdi r14}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [r14+0x08]
        ; gcrRegs +[rcx]
        mov      edx, dword ptr [r14+0x10]
@@ -170,19 +176,14 @@ G_M16387_IG09:        ; bbWeight=2, gcrefRegs=40A8 {rbx rbp rdi r14}, byrefRegs=
        ; gcrRegs -[rdx rbp]
        ; byrRegs -[rcx]
        mov      dword ptr [r14+0x10], r15d
-						;; size=30 bbWeight=2 PerfScore 22.50
-G_M16387_IG10:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[r14]
        inc      esi
        mov      rcx, gword ptr [rbx+0x08]
        ; gcrRegs +[rcx]
-       mov      rax, rcx
-       ; gcrRegs +[rax]
-       cmp      esi, dword ptr [rax+0x10]
-       jl       SHORT G_M16387_IG07
-						;; size=14 bbWeight=4 PerfScore 26.00
+       cmp      esi, dword ptr [rcx+0x10]
+       jl       G_M16387_IG07
+						;; size=45 bbWeight=4 PerfScore 70.00
 G_M16387_IG11:        ; bbWeight=0.50, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rcx]
+       ; gcrRegs -[rcx r14]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]:Free():this]
@@ -208,11 +209,16 @@ G_M16387_IG12:        ; bbWeight=0.50, epilog, nogc, extend
 G_M16387_IG13:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        call     CORINFO_HELP_RNGCHKFAIL
+       ; gcr arg pop 0
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M16387_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     [System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]:ThrowIndexOutOfRangeException()]
        ; gcr arg pop 0
        int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
+						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 303, prolog size 12, PerfScore 150.25, instruction count 93, allocated bytes for code 303 (MethodHash=4933bffc) for method Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+MembersAndInitializersBuilder:ToReadOnlyAndFree(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]):System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]] (Tier1)
+; Total bytes of code 333, prolog size 12, PerfScore 244.38, instruction count 97, allocated bytes for code 333 (MethodHash=4933bffc) for method Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+MembersAndInitializersBuilder:ToReadOnlyAndFree(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]):System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]] (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+12.82%</span>) : 44017.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache:GetCacheHash(int,ubyte,Microsoft.CodeAnalysis.GreenNode):int (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,40 +8,43 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T01] (  3,  3   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T02] (  3,  3   )   ubyte  ->  rdx         single-def
+;  V00 arg0         [V00,T01] (  3,  3   )     int  ->  rbx         single-def
+;  V01 arg1         [V01,T02] (  3,  3   )   ubyte  ->  rsi         single-def
 ;  V02 arg2         [V02,T00] (  3,  3   )     ref  ->   r8         class-hnd single-def <Microsoft.CodeAnalysis.GreenNode>
-;  V03 loc0         [V03,T03] (  4,  4   )     int  ->  rbx        
+;* V03 loc0         [V03    ] (  0,  0   )     int  ->  zero-ref   
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T04] (  2,  4   )     int  ->  rax         "Inlining Arg"
+;* V05 tmp1         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M45845_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rsi
        push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+       mov      ebx, ecx
+       mov      esi, edx
+						;; size=10 bbWeight=1 PerfScore 2.75
 G_M45845_IG02:        ; bbWeight=1, gcrefRegs=0100 {r8}, byrefRegs=0000 {}, byref
        ; gcrRegs +[r8]
-       movzx    rbx, dl
-       xor      ebx, ecx
        mov      rcx, r8
        ; gcrRegs +[rcx]
        call     <unknown method>
        ; gcrRegs -[rcx r8]
        ; gcr arg pop 0
-       imul     ebx, ebx, 0xD1FFAB1E
-       add      ebx, eax
-       mov      eax, ebx
+       movzx    rcx, sil
+       xor      ecx, ebx
+       imul     ecx, ecx, 0xD1FFAB1E
+       add      eax, ecx
        and      eax, 0xD1FFAB1E
-						;; size=28 bbWeight=1 PerfScore 4.50
+						;; size=27 bbWeight=1 PerfScore 4.25
 G_M45845_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
+       pop      rsi
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=7 bbWeight=1 PerfScore 2.25
 
-; Total bytes of code 39, prolog size 5, PerfScore 7.50, instruction count 13, allocated bytes for code 39 (MethodHash=32984cea) for method Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache:GetCacheHash(int,ubyte,Microsoft.CodeAnalysis.GreenNode):int (Tier1)
+; Total bytes of code 44, prolog size 6, PerfScore 9.25, instruction count 16, allocated bytes for code 44 (MethodHash=32984cea) for method Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache:GetCacheHash(int,ubyte,Microsoft.CodeAnalysis.GreenNode):int (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -49,10 +52,11 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x06
+  CountOfUnwindCodes: 3
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+13.46%</span>) : 43741.dasm - Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,43 +8,43 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  5,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis>
+;  V00 this         [V00,T00] (  6,  5   )     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    "location for address-of(RValue)" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ISymbol]>
-;  V03 tmp2         [V03,T02] (  2,  4   )   byref  ->  rax         single-def "Inlining Arg"
+;* V03 tmp2         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;  V04 tmp3         [V04,T01] (  3,  6   )   byref  ->  rbx         single-def "Inlining Arg"
 ;* V05 tmp4         [V05    ] (  0,  0   )     ref  ->  zero-ref    "field V02.array (fldOffset=0x0)" P-INDEP
-;  V06 cse0         [V06,T03] (  3,  3   )   byref  ->  rbx         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
 G_M10823_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
        sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M10823_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rcx]
-       lea      rbx, bword ptr [rcx+0xC0]
-       ; byrRegs +[rbx]
-       mov      rax, rbx
-       ; byrRegs +[rax]
-       cmp      byte  ptr [rax], 0
+       mov      rbx, rcx
+       ; gcrRegs +[rbx]
+						;; size=8 bbWeight=1 PerfScore 1.50
+G_M10823_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       cmp      byte  ptr [rbx+0xC0], 0
        jne      SHORT G_M10823_IG04
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M10823_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
-       ; byrRegs -[rax]
-       mov      rax, qword ptr [rcx]
+						;; size=9 bbWeight=1 PerfScore 4.00
+G_M10823_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       mov      rcx, rbx
+       ; gcrRegs +[rcx]
+       mov      rax, qword ptr [rbx]
        mov      rax, qword ptr [rax+0x48]
        call     [rax+0x28]<unknown method>
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-						;; size=10 bbWeight=0.50 PerfScore 3.50
-G_M10823_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=13 bbWeight=0.50 PerfScore 3.62
+G_M10823_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
+       add      rbx, 192
+       ; gcrRegs -[rbx]
+       ; byrRegs +[rbx]
        cmp      byte  ptr [rbx], 0
        je       SHORT G_M10823_IG06
        movzx    rax, byte  ptr [rbx+0x01]
-						;; size=9 bbWeight=1 PerfScore 6.00
+						;; size=16 bbWeight=1 PerfScore 6.25
 G_M10823_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
@@ -57,7 +57,7 @@ G_M10823_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 52, prolog size 5, PerfScore 17.25, instruction count 17, allocated bytes for code 52 (MethodHash=afbfd5b8) for method Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)
+; Total bytes of code 59, prolog size 5, PerfScore 17.12, instruction count 18, allocated bytes for code 59 (MethodHash=afbfd5b8) for method Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-23</span> (<span style="color:green">-95.83%</span>) : 247726.dasm - Test_GitHub_16041:Test_GitHub_16041(StructX) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,35 +8,26 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  3,  6   )   byref  ->  rcx         ld-addr-op single-def
+;* V00 arg0         [V00,T00] (  0,  0   )   byref  ->  zero-ref    ld-addr-op single-def
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SB] <StructY>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03    ] (  1,  1   )  struct (16) [rsp+0x08]  do-not-enreg[SB] ld-addr-op "Inline ldloca(s) first use temp" <StructY>
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <StructY>
 ;* V04 tmp2         [V04    ] (  0,  0   )     int  ->  zero-ref    "field V00.A (fldOffset=0x0)" P-INDEP
 ;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "field V00.B (fldOffset=0x4)" P-INDEP
 ;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V00.C (fldOffset=0x8)" P-INDEP
-;* V07 tmp5         [V07,T02] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V01.Padding (fldOffset=0x0)" P-DEP
-;  V08 tmp6         [V08,T01] (  1,  1   )     int  ->  [rsp+0x08]  do-not-enreg[] "field V03.Padding (fldOffset=0x0)" P-DEP
+;* V07 tmp5         [V07,T01] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V01.Padding (fldOffset=0x0)" P-DEP
+;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "field V03.Padding (fldOffset=0x0)" P-INDEP
 ;* V09 tmp7         [V09    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <StructX>
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M39790_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M39790_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
-       ; byrRegs +[rcx]
-       mov      rax, qword ptr [rcx]
-       mov      qword ptr [rsp+0x08], rax
-       mov      eax, dword ptr [rcx+0x08]
-       mov      dword ptr [rsp+0x10], eax
-						;; size=15 bbWeight=1 PerfScore 6.00
-G_M39790_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M39790_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 24, prolog size 4, PerfScore 7.50, instruction count 7, allocated bytes for code 24 (MethodHash=fec16491) for method Test_GitHub_16041:Test_GitHub_16041(StructX) (FullOpts)
+; Total bytes of code 1, prolog size 0, PerfScore 1.00, instruction count 1, allocated bytes for code 1 (MethodHash=fec16491) for method Test_GitHub_16041:Test_GitHub_16041(StructX) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -44,9 +35,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>

<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-72.41%</span>) : 232812.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,48 +8,33 @@
 ; 0 inlinees with PGO data; 9 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;* V00 loc0         [V00    ] (  0,  0   )   float  ->  zero-ref    single-def
-;* V01 loc1         [V01    ] (  0,  0   )   float  ->  zero-ref    single-def
+;  V00 loc0         [V00,T00] (  2,  2   )   float  ->  mm0         single-def
+;* V01 loc1         [V01    ] (  0,  0   )   float  ->  zero-ref   
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03    ] (  0,  0   )   float  ->  zero-ref    single-def "Inline stloc first use temp"
-;* V04 tmp2         [V04    ] (  0,  0   )   float  ->  zero-ref    single-def "Inline stloc first use temp"
-;* V05 tmp3         [V05    ] (  0,  0   )   float  ->  zero-ref    single-def "Inline stloc first use temp"
-;* V06 tmp4         [V06    ] (  0,  0   )   float  ->  zero-ref    single-def "Inline stloc first use temp"
-;  V07 tmp5         [V07,T00] (  3,  2.50)   float  ->  mm0         single-def "Inline stloc first use temp"
-;* V08 tmp6         [V08    ] (  0,  0   )   float  ->  zero-ref    single-def "Inline stloc first use temp"
-;  V09 cse0         [V09,T01] (  3,  2.50)   float  ->  mm1         "CSE - aggressive"
+;* V03 tmp1         [V03    ] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V04 tmp2         [V04    ] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V05 tmp3         [V05    ] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V06 tmp4         [V06    ] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V07 tmp5         [V07    ] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V08 tmp6         [V08    ] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V09 cse0         [V09,T01] (  0,  0   )   float  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M1823_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M1823_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M1823_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M1823_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     [Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float]
        ; gcr arg pop 0
-       vmovss   xmm1, dword ptr [reloc @RWD00]
-       vucomiss xmm0, xmm1
-       jp       SHORT G_M1823_IG05
-       jne      SHORT G_M1823_IG05
-						;; size=22 bbWeight=1 PerfScore 10.00
-G_M1823_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       vmovss   xmm2, dword ptr [reloc @RWD00]
-       vucomiss xmm2, xmm1
-       jb       SHORT G_M1823_IG05
-       vmovss   xmm0, dword ptr [reloc @RWD00]
-						;; size=22 bbWeight=0.50 PerfScore 4.50
-G_M1823_IG04:        ; bbWeight=0.50, epilog, nogc, extend
+       nop      
+						;; size=7 bbWeight=1 PerfScore 3.25
+G_M1823_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M1823_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 40
-       ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-RWD00  	dd	41200000h		;        10
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-
-; Total bytes of code 58, prolog size 4, PerfScore 16.00, instruction count 14, allocated bytes for code 58 (MethodHash=df23f8e0) for method Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=df23f8e0) for method Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-40</span> (<span style="color:green">-71.43%</span>) : 232730.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,45 +8,28 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 loc0         [V00,T00] (  3,  2.50)   float  ->  mm0         single-def
-;* V01 loc1         [V01    ] (  0,  0   )   float  ->  zero-ref    single-def
-;* V02 loc2         [V02    ] (  0,  0   )   float  ->  zero-ref    single-def
+;  V00 loc0         [V00,T00] (  2,  2   )   float  ->  mm0         single-def
+;* V01 loc1         [V01    ] (  0,  0   )   float  ->  zero-ref   
+;* V02 loc2         [V02    ] (  0,  0   )   float  ->  zero-ref   
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 cse0         [V04,T01] (  3,  2.50)   float  ->  mm1         "CSE - aggressive"
+;* V04 cse0         [V04,T01] (  0,  0   )   float  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M23313_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M23313_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M23313_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M23313_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     [Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float]
        ; gcr arg pop 0
-       vmovss   xmm1, dword ptr [reloc @RWD00]
-       vucomiss xmm0, xmm1
-       jp       SHORT G_M23313_IG06
-       jne      SHORT G_M23313_IG06
-						;; size=22 bbWeight=1 PerfScore 10.00
-G_M23313_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       vucomiss xmm1, dword ptr [reloc @RWD00]
-       jp       SHORT G_M23313_IG04
-       je       SHORT G_M23313_IG06
-						;; size=12 bbWeight=0.50 PerfScore 3.00
-G_M23313_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vmovss   xmm0, dword ptr [reloc @RWD00]
-						;; size=8 bbWeight=0.50 PerfScore 1.50
-G_M23313_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       nop      
+						;; size=7 bbWeight=1 PerfScore 3.25
+G_M23313_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M23313_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 40
-       ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-RWD00  	dd	41200000h		;        10
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-
-; Total bytes of code 56, prolog size 4, PerfScore 16.00, instruction count 14, allocated bytes for code 56 (MethodHash=c974a4ee) for method Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=c974a4ee) for method Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+27</span> (<span style="color:red">+27.55%</span>) : 240032.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,24 +8,23 @@
 ; 0 inlinees with PGO data; 11 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T06] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LookupResult>
+;  V00 arg0         [V00,T05] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LookupResult>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbol]>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T08] (  3,  3   )     ref  ->  rbx         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol]>
+;  V03 tmp1         [V03,T06] (  3,  3   )     ref  ->  rbx         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbol]>
 ;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
 ;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V07 tmp5         [V07,T05] (  2,  8   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V07 tmp5         [V07,T01] (  3, 24   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
 ;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V09 tmp7         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
-;  V10 tmp8         [V10,T01] (  2, 16   )     ref  ->  rax         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;  V11 tmp9         [V11,T07] (  2,  4.50)     ref  ->  rbx         single-def "field V01._builder (fldOffset=0x0)" P-INDEP
-;  V12 tmp10        [V12,T00] (  6, 16.50)     int  ->  rsi         "field V01._index (fldOffset=0x8)" P-INDEP
-;  V13 tmp11        [V13,T09] (  2,  1   )     ref  ->  rbx         single-def "field V04._builder (fldOffset=0x0)" P-INDEP
-;* V14 tmp12        [V14,T10] (  0,  0   )     int  ->  zero-ref    single-def "field V04._index (fldOffset=0x8)" P-INDEP
-;  V15 tmp13        [V15,T02] (  3, 12   )     ref  ->  rcx         "arr expr"
-;  V16 tmp14        [V16,T03] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V17 cse0         [V17,T04] (  3, 10   )     ref  ->  rcx         "CSE - aggressive"
+;* V10 tmp8         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V11 tmp9         [V11,T04] (  4,  9   )     ref  ->  rbx         single-def "field V01._builder (fldOffset=0x0)" P-INDEP
+;  V12 tmp10        [V12,T00] (  7, 24.50)     int  ->  rsi         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V13 tmp11        [V13,T07] (  2,  1   )     ref  ->  rbx         single-def "field V04._builder (fldOffset=0x0)" P-INDEP
+;* V14 tmp12        [V14,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V04._index (fldOffset=0x8)" P-INDEP
+;  V15 tmp13        [V15,T02] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V16 tmp14        [V16,T03] (  3, 24   )     ref  ->  rcx         "argument with side effect"
 ;
 ; Lcl frame size = 40
 
@@ -54,13 +53,20 @@ G_M51640_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rbx, gword ptr [rcx+0x08]
        ; gcrRegs +[rbx]
        cmp      byte  ptr [rbx], bl
-       mov      esi, -1
-       jmp      SHORT G_M51640_IG07
-						;; size=13 bbWeight=0.50 PerfScore 3.62
-G_M51640_IG06:        ; bbWeight=2, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
+       xor      esi, esi
+       mov      rcx, gword ptr [rbx+0x08]
+       cmp      dword ptr [rcx+0x10], 0
+       jle      SHORT G_M51640_IG03
+						;; size=18 bbWeight=0.50 PerfScore 5.62
+G_M51640_IG06:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, gword ptr [rbx+0x08]
+       ; gcrRegs +[rcx]
+       cmp      esi, dword ptr [rcx+0x10]
+       jge      SHORT G_M51640_IG11
        mov      rcx, gword ptr [rcx+0x08]
        cmp      esi, dword ptr [rcx+0x08]
-       jae      SHORT G_M51640_IG11
+       jae      SHORT G_M51640_IG10
        mov      eax, esi
        mov      rcx, gword ptr [rcx+8*rax+0x10]
        mov      rax, qword ptr [rcx]
@@ -69,37 +75,38 @@ G_M51640_IG06:        ; bbWeight=2, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        cmp      eax, 12
-       je       SHORT G_M51640_IG09
-						;; size=30 bbWeight=2 PerfScore 33.00
-G_M51640_IG07:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       je       SHORT G_M51640_IG08
        inc      esi
-       mov      rcx, gword ptr [rbx+0x08]
-       ; gcrRegs +[rcx]
-       mov      rax, rcx
+       mov      rax, gword ptr [rbx+0x08]
        ; gcrRegs +[rax]
        cmp      esi, dword ptr [rax+0x10]
        jl       SHORT G_M51640_IG06
-						;; size=14 bbWeight=4 PerfScore 26.00
-G_M51640_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax rcx rbx]
+						;; size=50 bbWeight=4 PerfScore 115.00
+G_M51640_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rax rbx]
        jmp      SHORT G_M51640_IG03
 						;; size=2 bbWeight=0.50 PerfScore 1.00
-G_M51640_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M51640_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M51640_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+G_M51640_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rsi
        ret      
 						;; size=7 bbWeight=0.50 PerfScore 1.12
-G_M51640_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M51640_IG10:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
+       ; gcr arg pop 0
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M51640_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     [System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]:ThrowIndexOutOfRangeException()]
        ; gcr arg pop 0
        int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
+						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 98, prolog size 6, PerfScore 72.38, instruction count 37, allocated bytes for code 98 (MethodHash=e74d3647) for method Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
+; Total bytes of code 125, prolog size 6, PerfScore 130.38, instruction count 43, allocated bytes for code 125 (MethodHash=e74d3647) for method Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+37</span> (<span style="color:red">+28.91%</span>) : 248070.dasm - Program:TestEntryPoint():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,48 +8,54 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 tmp1         [V01,T00] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
-;  V02 tmp2         [V02,T01] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
-;  V03 tmp3         [V03,T02] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
-;  V04 tmp4         [V04,T03] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
-;  V05 tmp5         [V05,T04] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
-;  V06 tmp6         [V06,T05] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
-;  V07 tmp7         [V07,T06] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
+;* V01 tmp1         [V01    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;* V02 tmp2         [V02    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;* V03 tmp3         [V03    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;* V04 tmp4         [V04    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;* V05 tmp5         [V05    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;* V06 tmp6         [V06    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;* V07 tmp7         [V07    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;  TEMP_01                                     int  ->  [rsp+0x24]
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M13170_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M13170_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        call     [<unknown method>]
        ; gcr arg pop 0
-       mov      ebx, eax
-       and      ebx, 1
+       and      eax, 1
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       and      ebx, eax
+       and      eax, dword ptr [rsp+0x24]
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       and      ebx, eax
+       and      eax, dword ptr [rsp+0x24]
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       and      ebx, eax
+       and      eax, dword ptr [rsp+0x24]
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       and      ebx, eax
+       and      eax, dword ptr [rsp+0x24]
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       and      ebx, eax
+       and      eax, dword ptr [rsp+0x24]
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       and      ebx, eax
+       and      eax, dword ptr [rsp+0x24]
+       mov      dword ptr [rsp+0x24], eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       test     eax, ebx
+       test     dword ptr [rsp+0x24], eax
        je       SHORT G_M13170_IG05
-						;; size=69 bbWeight=1 PerfScore 27.25
+						;; size=109 bbWeight=1 PerfScore 46.25
 G_M13170_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
@@ -59,10 +65,9 @@ G_M13170_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        mov      eax, 100
 						;; size=21 bbWeight=0.50 PerfScore 1.75
 G_M13170_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
+						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M13170_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
@@ -72,12 +77,11 @@ G_M13170_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      eax, 101
 						;; size=21 bbWeight=0.50 PerfScore 1.75
 G_M13170_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
+						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 128, prolog size 5, PerfScore 33.75, instruction count 32, allocated bytes for code 128 (MethodHash=eaa4cc8d) for method Program:TestEntryPoint():int (FullOpts)
+; Total bytes of code 165, prolog size 4, PerfScore 51.25, instruction count 35, allocated bytes for code 165 (MethodHash=eaa4cc8d) for method Program:TestEntryPoint():int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -85,10 +89,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:red">+40</span> (<span style="color:red">+75.47%</span>) : 189685.dasm - EarlyLiveness_ForwardSub:Test1():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,37 +7,46 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 loc0         [V00    ] (  1,  1   )  struct (24) [rsp+0x38]  do-not-enreg[XS] must-init addr-exposed <EarlyLiveness_ForwardSub+S1>
-;  V01 loc1         [V01    ] (  1,  1   )  struct (24) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <EarlyLiveness_ForwardSub+S1>
+;* V00 loc0         [V00    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[S] <EarlyLiveness_ForwardSub+S1>
+;  V01 loc1         [V01,T00] (  3,  3   )  struct (24) [rsp+0x38]  do-not-enreg[S] ld-addr-op <EarlyLiveness_ForwardSub+S1>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  2,  4   )     int  ->  rbx         "non-inline candidate call"
+;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
+;  V04 tmp2         [V04    ] (  4,  8   )  struct (24) [rsp+0x20]  do-not-enreg[XS] addr-exposed "by-value struct argument" <EarlyLiveness_ForwardSub+S1>
 ;
 ; Lcl frame size = 80
 
 G_M37521_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
        sub      rsp, 80
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
-       vmovdqa  xmmword ptr [rsp+0x40], xmm4
-						;; size=21 bbWeight=1 PerfScore 5.58
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M37521_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       vxorps   xmm0, xmm0, xmm0
+       vmovdqu  xmmword ptr [rsp+0x38], xmm0
+       vmovdqu  xmmword ptr [rsp+0x3C], xmm0
+       vmovdqu  xmm0, xmmword ptr [rsp+0x38]
+       vmovdqu  xmmword ptr [rsp+0x20], xmm0
+       mov      ecx, dword ptr [rsp+0x48]
+       mov      dword ptr [rsp+0x30], ecx
        lea      rcx, [rsp+0x20]
        call     [<unknown method>]
        ; gcr arg pop 0
        mov      ebx, eax
-       lea      rcx, [rsp+0x38]
+       vmovdqu  xmm0, xmmword ptr [rsp+0x38]
+       vmovdqu  xmmword ptr [rsp+0x20], xmm0
+       mov      ecx, dword ptr [rsp+0x48]
+       mov      dword ptr [rsp+0x30], ecx
+       lea      rcx, [rsp+0x20]
        call     [<unknown method>]
        ; gcr arg pop 0
        add      eax, ebx
-						;; size=26 bbWeight=1 PerfScore 7.50
+						;; size=82 bbWeight=1 PerfScore 21.83
 G_M37521_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 80
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 53, prolog size 21, PerfScore 14.83, instruction count 14, allocated bytes for code 53 (MethodHash=12746d6e) for method EarlyLiveness_ForwardSub:Test1():int (FullOpts)
+; Total bytes of code 93, prolog size 5, PerfScore 24.83, instruction count 22, allocated bytes for code 93 (MethodHash=12746d6e) for method EarlyLiveness_ForwardSub:Test1():int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-64.71%</span>) : 33449.dasm - Microsoft.Diagnostics.Tracing.EventPipeEventHeader:GetTotalEventSize(ulong,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,36 +8,25 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  3   )    long  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
-;* V02 loc0         [V02    ] (  0,  0   )    long  ->  zero-ref    single-def
-;* V03 loc1         [V03    ] (  0,  0   )    long  ->  zero-ref    single-def
+;  V00 arg0         [V00,T00] (  3,  3   )    long  ->  rcx         single-def
+;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
+;* V02 loc0         [V02    ] (  0,  0   )    long  ->  zero-ref   
+;* V03 loc1         [V03    ] (  0,  0   )    long  ->  zero-ref   
 ;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
 
-G_M15084_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M15084_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
-G_M15084_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      edx, 3
-       jg       SHORT G_M15084_IG05
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M15084_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M15084_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, dword ptr [rcx]
        add      eax, 4
-						;; size=5 bbWeight=0.50 PerfScore 1.12
-G_M15084_IG04:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=5 bbWeight=1 PerfScore 2.25
+G_M15084_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M15084_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      eax, dword ptr [rcx]
-       add      eax, 4
-						;; size=5 bbWeight=0.50 PerfScore 1.12
-G_M15084_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 17, prolog size 0, PerfScore 4.50, instruction count 8, allocated bytes for code 17 (MethodHash=6976c513) for method Microsoft.Diagnostics.Tracing.EventPipeEventHeader:GetTotalEventSize(ulong,int):int (FullOpts)
+; Total bytes of code 6, prolog size 0, PerfScore 3.25, instruction count 3, allocated bytes for code 6 (MethodHash=6976c513) for method Microsoft.Diagnostics.Tracing.EventPipeEventHeader:GetTotalEventSize(ulong,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-61.54%</span>) : 190175.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,31 +8,26 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  3,  3   )    long  ->  rax         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )    long  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
-;  V02 loc0         [V02,T02] (  2,  2   )     int  ->  rcx         single-def
-;  V03 loc1         [V03,T03] (  2,  2   )    long  ->  rdx         single-def
+;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
+;* V03 loc1         [V03    ] (  0,  0   )    long  ->  zero-ref   
 ;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
 
 G_M58437_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       mov      rax, rcx
-						;; size=3 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58437_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      ecx, edx
-       and      ecx, 63
-       mov      edx, 1
-       shl      rdx, cl
-       test     rax, rdx
-       setne    al
-       movzx    rax, al
-						;; size=22 bbWeight=1 PerfScore 4.25
+       xor      eax, eax
+       bt       rcx, rdx
+       setb     al
+						;; size=9 bbWeight=1 PerfScore 1.75
 G_M58437_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 26, prolog size 0, PerfScore 5.50, instruction count 9, allocated bytes for code 26 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (FullOpts)
+; Total bytes of code 10, prolog size 0, PerfScore 2.75, instruction count 4, allocated bytes for code 10 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-60.00%</span>) : 259484.dasm - System.Drawing.PointF:ToVector2():System.Numerics.Vector2:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )   byref  ->  rcx         this single-def
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )   simd8  ->  mm0         ld-addr-op "NewObj constructor temp" <System.Numerics.Vector2>
+;* V02 tmp1         [V02    ] (  0,  0   )   simd8  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector2>
 ;
 ; Lcl frame size = 0
 
@@ -18,14 +18,13 @@ G_M25358_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M25358_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       movsd    xmm0, qword ptr [rcx]
-       movd     rax, xmm0
-						;; size=9 bbWeight=1 PerfScore 6.00
+       mov      rax, qword ptr [rcx]
+						;; size=3 bbWeight=1 PerfScore 2.00
 G_M25358_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 7.00, instruction count 3, allocated bytes for code 10 (MethodHash=28c09cf1) for method System.Drawing.PointF:ToVector2():System.Numerics.Vector2:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=28c09cf1) for method System.Drawing.PointF:ToVector2():System.Numerics.Vector2:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+126.09%</span>) : 18018.dasm - System.Span`1[ubyte]:GetEnumerator():System.Span`1+Enumerator[ubyte]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,37 +9,45 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Span`1+Enumerator[ubyte]>
+;  V03 tmp1         [V03,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Span`1+Enumerator[ubyte]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Span`1[ubyte]>
-;  V05 tmp3         [V05,T02] (  2,  2   )   byref  ->  rax         single-def "field V04._reference (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T03] (  2,  2   )     int  ->  rcx         "field V04._length (fldOffset=0x8)" P-INDEP
-;* V07 tmp5         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def "V03.[000..008)"
-;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V03.[008..012)"
-;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
+;* V05 tmp3         [V05    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M7866_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M7866_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
+       sub      rsp, 24
+       xorps    xmm4, xmm4
+       movaps   xmmword ptr [rsp], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x10], rax
+						;; size=18 bbWeight=1 PerfScore 3.83
+G_M7866_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, nogc
        ; byrRegs +[rcx rdx]
-       mov      rax, bword ptr [rcx]
-       ; byrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       mov      bword ptr [rdx], rax
-       mov      dword ptr [rdx+0x08], ecx
+       movups   xmm0, xmmword ptr [rcx]
+       movups   xmmword ptr [rsp], xmm0
+						;; size=7 bbWeight=1 PerfScore 5.00
+G_M7866_IG03:        ; bbWeight=1, nogc, extend
+       movups   xmmword ptr [rdx], xmm0
+       mov      rax, qword ptr [rsp+0x10]
+       mov      qword ptr [rdx+0x10], rax
+						;; size=12 bbWeight=1 PerfScore 4.00
+G_M7866_IG04:        ; bbWeight=1, extend
        mov      dword ptr [rdx+0x10], -1
        mov      rax, rdx
-						;; size=22 bbWeight=1 PerfScore 7.25
-G_M7866_IG03:        ; bbWeight=1, epilog, nogc, extend
+       ; byrRegs +[rax]
+						;; size=10 bbWeight=1 PerfScore 1.25
+G_M7866_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 23, prolog size 0, PerfScore 8.25, instruction count 7, allocated bytes for code 23 (MethodHash=a5d0e145) for method System.Span`1[ubyte]:GetEnumerator():System.Span`1+Enumerator[ubyte]:this (FullOpts)
+; Total bytes of code 52, prolog size 18, PerfScore 15.33, instruction count 14, allocated bytes for code 52 (MethodHash=a5d0e145) for method System.Span`1[ubyte]:GetEnumerator():System.Span`1+Enumerator[ubyte]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -47,8 +55,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+126.09%</span>) : 17997.dasm - System.ReadOnlySpan`1[ubyte]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[ubyte]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,37 +9,45 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1+Enumerator[ubyte]>
+;  V03 tmp1         [V03,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1+Enumerator[ubyte]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
-;  V05 tmp3         [V05,T02] (  2,  2   )   byref  ->  rax         single-def "field V04._reference (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T03] (  2,  2   )     int  ->  rcx         "field V04._length (fldOffset=0x8)" P-INDEP
-;* V07 tmp5         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def "V03.[000..008)"
-;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V03.[008..012)"
-;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
+;* V05 tmp3         [V05    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M14458_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M14458_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
+       sub      rsp, 24
+       xorps    xmm4, xmm4
+       movaps   xmmword ptr [rsp], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x10], rax
+						;; size=18 bbWeight=1 PerfScore 3.83
+G_M14458_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, nogc
        ; byrRegs +[rcx rdx]
-       mov      rax, bword ptr [rcx]
-       ; byrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       mov      bword ptr [rdx], rax
-       mov      dword ptr [rdx+0x08], ecx
+       movups   xmm0, xmmword ptr [rcx]
+       movups   xmmword ptr [rsp], xmm0
+						;; size=7 bbWeight=1 PerfScore 5.00
+G_M14458_IG03:        ; bbWeight=1, nogc, extend
+       movups   xmmword ptr [rdx], xmm0
+       mov      rax, qword ptr [rsp+0x10]
+       mov      qword ptr [rdx+0x10], rax
+						;; size=12 bbWeight=1 PerfScore 4.00
+G_M14458_IG04:        ; bbWeight=1, extend
        mov      dword ptr [rdx+0x10], -1
        mov      rax, rdx
-						;; size=22 bbWeight=1 PerfScore 7.25
-G_M14458_IG03:        ; bbWeight=1, epilog, nogc, extend
+       ; byrRegs +[rax]
+						;; size=10 bbWeight=1 PerfScore 1.25
+G_M14458_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 23, prolog size 0, PerfScore 8.25, instruction count 7, allocated bytes for code 23 (MethodHash=8edac785) for method System.ReadOnlySpan`1[ubyte]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[ubyte]:this (FullOpts)
+; Total bytes of code 52, prolog size 18, PerfScore 15.33, instruction count 14, allocated bytes for code 52 (MethodHash=8edac785) for method System.ReadOnlySpan`1[ubyte]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[ubyte]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -47,8 +55,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+126.09%</span>) : 13176.dasm - System.Span`1[System.__Canon]:GetEnumerator():System.Span`1+Enumerator[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,38 +9,46 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;* V02 TypeCtx      [V02    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V04 loc1         [V04    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Span`1+Enumerator[System.__Canon]>
+;  V04 loc1         [V04,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Span`1+Enumerator[System.__Canon]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Span`1[System.__Canon]>
-;  V06 tmp3         [V06,T02] (  2,  2   )   byref  ->  rax         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V07 tmp4         [V07,T03] (  2,  2   )     int  ->  rcx         "field V05._length (fldOffset=0x8)" P-INDEP
-;* V08 tmp5         [V08    ] (  0,  0   )   byref  ->  zero-ref    single-def "V04.[000..008)"
-;* V09 tmp6         [V09    ] (  0,  0   )     int  ->  zero-ref    "V04.[008..012)"
-;* V10 tmp7         [V10    ] (  0,  0   )     int  ->  zero-ref    "V04.[016..020)"
+;* V06 tmp3         [V06    ] (  0,  0   )   byref  ->  zero-ref    "field V05._reference (fldOffset=0x0)" P-INDEP
+;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;* V08 tmp5         [V08    ] (  0,  0   )     int  ->  zero-ref    "V04.[016..020)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M62522_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M62522_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
+       sub      rsp, 24
+       xorps    xmm4, xmm4
+       movaps   xmmword ptr [rsp], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x10], rax
+						;; size=18 bbWeight=1 PerfScore 3.83
+G_M62522_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, nogc
        ; byrRegs +[rcx rdx]
-       mov      rax, bword ptr [rcx]
-       ; byrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       mov      bword ptr [rdx], rax
-       mov      dword ptr [rdx+0x08], ecx
+       movups   xmm0, xmmword ptr [rcx]
+       movups   xmmword ptr [rsp], xmm0
+						;; size=7 bbWeight=1 PerfScore 5.00
+G_M62522_IG03:        ; bbWeight=1, nogc, extend
+       movups   xmmword ptr [rdx], xmm0
+       mov      rax, qword ptr [rsp+0x10]
+       mov      qword ptr [rdx+0x10], rax
+						;; size=12 bbWeight=1 PerfScore 4.00
+G_M62522_IG04:        ; bbWeight=1, extend
        mov      dword ptr [rdx+0x10], -1
        mov      rax, rdx
-						;; size=22 bbWeight=1 PerfScore 7.25
-G_M62522_IG03:        ; bbWeight=1, epilog, nogc, extend
+       ; byrRegs +[rax]
+						;; size=10 bbWeight=1 PerfScore 1.25
+G_M62522_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 23, prolog size 0, PerfScore 8.25, instruction count 7, allocated bytes for code 23 (MethodHash=fa580bc5) for method System.Span`1[System.__Canon]:GetEnumerator():System.Span`1+Enumerator[System.__Canon]:this (FullOpts)
+; Total bytes of code 52, prolog size 18, PerfScore 15.33, instruction count 14, allocated bytes for code 52 (MethodHash=fa580bc5) for method System.Span`1[System.__Canon]:GetEnumerator():System.Span`1+Enumerator[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -48,8 +56,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-36</span> (<span style="color:green">-69.23%</span>) : 310767.dasm - Xunit.Assert:Contains[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5, 10   )   byref  ->  rcx         single-def
+;  V00 arg0         [V00,T00] (  3,  6   )   byref  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  6   )   byref  ->  rdx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlyMemory`1[ubyte]>
@@ -19,46 +19,33 @@
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    "field V01._object (fldOffset=0x0)" P-INDEP
 ;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "field V01._index (fldOffset=0x8)" P-INDEP
 ;* V10 tmp8         [V10    ] (  0,  0   )     int  ->  zero-ref    "field V01._length (fldOffset=0xc)" P-INDEP
-;* V11 tmp9         [V11    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._object (fldOffset=0x0)" P-INDEP
+;* V11 tmp9         [V11    ] (  0,  0   )     ref  ->  zero-ref    "field V03._object (fldOffset=0x0)" P-INDEP
 ;* V12 tmp10        [V12    ] (  0,  0   )     int  ->  zero-ref    "field V03._index (fldOffset=0x8)" P-INDEP
 ;* V13 tmp11        [V13    ] (  0,  0   )     int  ->  zero-ref    "field V03._length (fldOffset=0xc)" P-INDEP
-;  V14 tmp12        [V14,T02] (  2,  2   )     ref  ->  rax         single-def "field V04._object (fldOffset=0x0)" P-INDEP
-;  V15 tmp13        [V15,T03] (  2,  2   )     int  ->   r8         "field V04._index (fldOffset=0x8)" P-INDEP
-;  V16 tmp14        [V16,T04] (  2,  2   )     int  ->  rcx         "field V04._length (fldOffset=0xc)" P-INDEP
+;* V14 tmp12        [V14    ] (  0,  0   )     ref  ->  zero-ref    "field V04._object (fldOffset=0x0)" P-INDEP
+;* V15 tmp13        [V15    ] (  0,  0   )     int  ->  zero-ref    "field V04._index (fldOffset=0x8)" P-INDEP
+;* V16 tmp14        [V16    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0xc)" P-INDEP
 ;* V17 tmp15        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Memory`1[ubyte]>
 ;* V18 tmp16        [V18    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlyMemory`1[ubyte]>
-;  V19 tmp17        [V19    ] (  4,  8   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlyMemory`1[ubyte]>
 ;
-; Lcl frame size = 56
+; Lcl frame size = 40
 
 G_M37443_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
-						;; size=11 bbWeight=1 PerfScore 1.50
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M37443_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
-       mov      rax, gword ptr [rcx]
-       ; gcrRegs +[rax]
-       mov      r8d, dword ptr [rcx+0x08]
-       mov      ecx, dword ptr [rcx+0x0C]
-       ; byrRegs -[rcx]
-       mov      gword ptr [rsp+0x28], rax
-       mov      dword ptr [rsp+0x30], r8d
-       mov      dword ptr [rsp+0x34], ecx
-       lea      rcx, [rsp+0x28]
        call     [Xunit.Assert:Contains[ubyte](System.ReadOnlyMemory`1[ubyte],System.ReadOnlyMemory`1[ubyte])]
-       ; gcrRegs -[rax]
-       ; byrRegs -[rdx]
+       ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        nop      
-						;; size=36 bbWeight=1 PerfScore 12.75
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M37443_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 52, prolog size 11, PerfScore 15.50, instruction count 14, allocated bytes for code 52 (MethodHash=14e96dbc) for method Xunit.Assert:Contains[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=14e96dbc) for method Xunit.Assert:Contains[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -71,4 +58,4 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:green">-36</span> (<span style="color:green">-69.23%</span>) : 310799.dasm - Xunit.Assert:Equal[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5, 10   )   byref  ->  rcx         single-def
+;  V00 arg0         [V00,T00] (  3,  6   )   byref  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  6   )   byref  ->  rdx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlyMemory`1[ubyte]>
@@ -19,46 +19,33 @@
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    "field V01._object (fldOffset=0x0)" P-INDEP
 ;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "field V01._index (fldOffset=0x8)" P-INDEP
 ;* V10 tmp8         [V10    ] (  0,  0   )     int  ->  zero-ref    "field V01._length (fldOffset=0xc)" P-INDEP
-;* V11 tmp9         [V11    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._object (fldOffset=0x0)" P-INDEP
+;* V11 tmp9         [V11    ] (  0,  0   )     ref  ->  zero-ref    "field V03._object (fldOffset=0x0)" P-INDEP
 ;* V12 tmp10        [V12    ] (  0,  0   )     int  ->  zero-ref    "field V03._index (fldOffset=0x8)" P-INDEP
 ;* V13 tmp11        [V13    ] (  0,  0   )     int  ->  zero-ref    "field V03._length (fldOffset=0xc)" P-INDEP
-;  V14 tmp12        [V14,T02] (  2,  2   )     ref  ->  rax         single-def "field V04._object (fldOffset=0x0)" P-INDEP
-;  V15 tmp13        [V15,T03] (  2,  2   )     int  ->   r8         "field V04._index (fldOffset=0x8)" P-INDEP
-;  V16 tmp14        [V16,T04] (  2,  2   )     int  ->  rcx         "field V04._length (fldOffset=0xc)" P-INDEP
+;* V14 tmp12        [V14    ] (  0,  0   )     ref  ->  zero-ref    "field V04._object (fldOffset=0x0)" P-INDEP
+;* V15 tmp13        [V15    ] (  0,  0   )     int  ->  zero-ref    "field V04._index (fldOffset=0x8)" P-INDEP
+;* V16 tmp14        [V16    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0xc)" P-INDEP
 ;* V17 tmp15        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Memory`1[ubyte]>
 ;* V18 tmp16        [V18    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlyMemory`1[ubyte]>
-;  V19 tmp17        [V19    ] (  4,  8   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlyMemory`1[ubyte]>
 ;
-; Lcl frame size = 56
+; Lcl frame size = 40
 
 G_M53132_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
-						;; size=11 bbWeight=1 PerfScore 1.50
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M53132_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
-       mov      rax, gword ptr [rcx]
-       ; gcrRegs +[rax]
-       mov      r8d, dword ptr [rcx+0x08]
-       mov      ecx, dword ptr [rcx+0x0C]
-       ; byrRegs -[rcx]
-       mov      gword ptr [rsp+0x28], rax
-       mov      dword ptr [rsp+0x30], r8d
-       mov      dword ptr [rsp+0x34], ecx
-       lea      rcx, [rsp+0x28]
        call     [Xunit.Assert:Equal[ubyte](System.ReadOnlyMemory`1[ubyte],System.ReadOnlyMemory`1[ubyte])]
-       ; gcrRegs -[rax]
-       ; byrRegs -[rdx]
+       ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        nop      
-						;; size=36 bbWeight=1 PerfScore 12.75
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M53132_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 52, prolog size 11, PerfScore 15.50, instruction count 14, allocated bytes for code 52 (MethodHash=22853073) for method Xunit.Assert:Equal[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=22853073) for method Xunit.Assert:Equal[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -71,4 +58,4 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:green">-36</span> (<span style="color:green">-69.23%</span>) : 310768.dasm - Xunit.Assert:Contains[ubyte](System.ReadOnlyMemory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,8 +8,8 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T01] (  3,  6   )   byref  ->  rcx         single-def
-;  V01 arg1         [V01,T00] (  5, 10   )   byref  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  6   )   byref  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  6   )   byref  ->  rdx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlyMemory`1[ubyte]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Memory`1[ubyte]>
@@ -19,46 +19,33 @@
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    "field V01._object (fldOffset=0x0)" P-INDEP
 ;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "field V01._index (fldOffset=0x8)" P-INDEP
 ;* V10 tmp8         [V10    ] (  0,  0   )     int  ->  zero-ref    "field V01._length (fldOffset=0xc)" P-INDEP
-;* V11 tmp9         [V11    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._object (fldOffset=0x0)" P-INDEP
+;* V11 tmp9         [V11    ] (  0,  0   )     ref  ->  zero-ref    "field V03._object (fldOffset=0x0)" P-INDEP
 ;* V12 tmp10        [V12    ] (  0,  0   )     int  ->  zero-ref    "field V03._index (fldOffset=0x8)" P-INDEP
 ;* V13 tmp11        [V13    ] (  0,  0   )     int  ->  zero-ref    "field V03._length (fldOffset=0xc)" P-INDEP
-;  V14 tmp12        [V14,T02] (  2,  2   )     ref  ->  rax         single-def "field V04._object (fldOffset=0x0)" P-INDEP
-;  V15 tmp13        [V15,T03] (  2,  2   )     int  ->   r8         "field V04._index (fldOffset=0x8)" P-INDEP
-;  V16 tmp14        [V16,T04] (  2,  2   )     int  ->  rdx         "field V04._length (fldOffset=0xc)" P-INDEP
+;* V14 tmp12        [V14    ] (  0,  0   )     ref  ->  zero-ref    "field V04._object (fldOffset=0x0)" P-INDEP
+;* V15 tmp13        [V15    ] (  0,  0   )     int  ->  zero-ref    "field V04._index (fldOffset=0x8)" P-INDEP
+;* V16 tmp14        [V16    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0xc)" P-INDEP
 ;* V17 tmp15        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlyMemory`1[ubyte]>
 ;* V18 tmp16        [V18    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Memory`1[ubyte]>
-;  V19 tmp17        [V19    ] (  4,  8   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlyMemory`1[ubyte]>
 ;
-; Lcl frame size = 56
+; Lcl frame size = 40
 
 G_M40963_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
-						;; size=11 bbWeight=1 PerfScore 1.50
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M40963_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
-       mov      rax, gword ptr [rdx]
-       ; gcrRegs +[rax]
-       mov      r8d, dword ptr [rdx+0x08]
-       mov      edx, dword ptr [rdx+0x0C]
-       ; byrRegs -[rdx]
-       mov      gword ptr [rsp+0x28], rax
-       mov      dword ptr [rsp+0x30], r8d
-       mov      dword ptr [rsp+0x34], edx
-       lea      rdx, [rsp+0x28]
        call     [Xunit.Assert:Contains[ubyte](System.ReadOnlyMemory`1[ubyte],System.ReadOnlyMemory`1[ubyte])]
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
+       ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        nop      
-						;; size=36 bbWeight=1 PerfScore 12.75
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M40963_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 52, prolog size 11, PerfScore 15.50, instruction count 14, allocated bytes for code 52 (MethodHash=8c655ffc) for method Xunit.Assert:Contains[ubyte](System.ReadOnlyMemory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=8c655ffc) for method Xunit.Assert:Contains[ubyte](System.ReadOnlyMemory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -71,4 +58,4 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:red">+24</span> (<span style="color:red">+80.00%</span>) : 18463.dasm - System.MemoryExtensions:IndexOfAnyExceptInRange[double](System.Span`1[double],double,double):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,30 +9,30 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         single-def
-;  V01 arg1         [V01,T14] (  3,  3   )  double  ->  mm1         single-def
-;  V02 arg2         [V02,T15] (  3,  3   )  double  ->  mm2         single-def
+;  V01 arg1         [V01,T12] (  3,  3   )  double  ->  mm1         single-def
+;  V02 arg2         [V02,T13] (  3,  3   )  double  ->  mm2         single-def
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[double]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[double]>
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[double]>
-;  V07 tmp4         [V07,T02] (  2,  4   )     int  ->  rax         "Inlining Arg"
+;  V07 tmp4         [V07,T02] (  2,  4   )     int  ->  rcx         "Inlining Arg"
 ;  V08 tmp5         [V08,T01] (  2,  4   )   byref  ->   r9         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V10 tmp7         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V11 tmp8         [V11,T04] (  2,  2   )     int  ->  rax         "Inline return value spill temp"
-;* V12 tmp9         [V12,T16] (  0,  0   )  double  ->  zero-ref    do-not-enreg[F] ld-addr-op "Inlining Arg"
-;* V13 tmp10        [V13,T17] (  0,  0   )  double  ->  zero-ref    do-not-enreg[F] ld-addr-op "Inlining Arg"
-;* V14 tmp11        [V14,T05] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;  V11 tmp8         [V11,T06] (  2,  2   )     int  ->  rax         "Inline return value spill temp"
+;  V12 tmp9         [V12,T14] (  2,  4   )  double  ->  [rsp+0x30]  do-not-enreg[F] ld-addr-op "Inlining Arg"
+;  V13 tmp10        [V13,T15] (  2,  4   )  double  ->  [rsp+0x28]  do-not-enreg[F] ld-addr-op "Inlining Arg"
+;* V14 tmp11        [V14    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V15 tmp12        [V15    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;* V16 tmp13        [V16,T06] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V16 tmp13        [V16    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V17 tmp14        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;* V18 tmp15        [V18,T07] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V18 tmp15        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V19 tmp16        [V19    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[double]>
-;* V20 tmp17        [V20,T10] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;* V21 tmp18        [V21,T08] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;* V22 tmp19        [V22,T11] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;* V23 tmp20        [V23,T12] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;* V24 tmp21        [V24,T13] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V20 tmp17        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V21 tmp18        [V21,T10] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V22 tmp19        [V22    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V23 tmp20        [V23    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V24 tmp21        [V24,T11] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V25 tmp22        [V25    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[double]>
 ;* V26 tmp23        [V26    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp24        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -75,14 +75,14 @@
 ;* V64 tmp61        [V64    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[double]>
 ;* V65 tmp62        [V65    ] (  0,  0   )   byref  ->  zero-ref    "field V00._reference (fldOffset=0x0)" P-INDEP
 ;* V66 tmp63        [V66    ] (  0,  0   )     int  ->  zero-ref    "field V00._length (fldOffset=0x8)" P-INDEP
-;* V67 tmp64        [V67    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V04._reference (fldOffset=0x0)" P-INDEP
+;* V67 tmp64        [V67    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
 ;* V68 tmp65        [V68    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
 ;  V69 tmp66        [V69,T03] (  2,  2   )   byref  ->   r9         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V70 tmp67        [V70,T09] (  2,  2   )     int  ->  rcx         "field V05._length (fldOffset=0x8)" P-INDEP
-;* V71 tmp68        [V71    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V06._reference (fldOffset=0x0)" P-INDEP
-;* V72 tmp69        [V72    ] (  0,  0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
-;* V73 tmp70        [V73    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V19._reference (fldOffset=0x0)" P-INDEP
-;* V74 tmp71        [V74    ] (  0,  0   )     int  ->  zero-ref    "field V19._length (fldOffset=0x8)" P-INDEP
+;  V70 tmp67        [V70,T07] (  2,  2   )     int  ->  rcx         "field V05._length (fldOffset=0x8)" P-INDEP
+;  V71 tmp68        [V71,T04] (  2,  2   )   byref  ->   r9         single-def "field V06._reference (fldOffset=0x0)" P-INDEP
+;  V72 tmp69        [V72,T08] (  2,  2   )     int  ->  rcx         "field V06._length (fldOffset=0x8)" P-INDEP
+;  V73 tmp70        [V73,T05] (  2,  2   )   byref  ->   r9         single-def "field V19._reference (fldOffset=0x0)" P-INDEP
+;  V74 tmp71        [V74,T09] (  2,  2   )     int  ->  rax         "field V19._length (fldOffset=0x8)" P-INDEP
 ;* V75 tmp72        [V75    ] (  0,  0   )   byref  ->  zero-ref    "field V25._reference (fldOffset=0x0)" P-INDEP
 ;* V76 tmp73        [V76    ] (  0,  0   )     int  ->  zero-ref    "field V25._length (fldOffset=0x8)" P-INDEP
 ;* V77 tmp74        [V77    ] (  0,  0   )   byref  ->  zero-ref    "field V33._reference (fldOffset=0x0)" P-INDEP
@@ -95,10 +95,10 @@
 ;* V84 tmp81        [V84    ] (  0,  0   )     int  ->  zero-ref    "field V64._length (fldOffset=0x8)" P-INDEP
 ;* V85 tmp82        [V85    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[double]>
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M64792_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
+       sub      rsp, 56
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M64792_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
@@ -107,21 +107,25 @@ G_M64792_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      ecx, dword ptr [rcx+0x08]
        ; byrRegs -[rcx]
        mov      eax, ecx
+       vmovsd   qword ptr [rsp+0x30], xmm1
+       vmovsd   qword ptr [rsp+0x28], xmm2
        mov      rcx, r9
        ; byrRegs +[rcx]
+       vmovsd   xmm1, qword ptr [rsp+0x30]
+       vmovsd   xmm2, qword ptr [rsp+0x28]
        mov      r9d, eax
        ; byrRegs -[r9]
        call     [System.SpanHelpers:IndexOfAnyExceptInRange[double](byref,double,double,int):int]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        nop      
-						;; size=21 bbWeight=1 PerfScore 8.00
+						;; size=45 bbWeight=1 PerfScore 16.00
 G_M64792_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 56
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 30, prolog size 4, PerfScore 9.50, instruction count 10, allocated bytes for code 30 (MethodHash=52a202e7) for method System.MemoryExtensions:IndexOfAnyExceptInRange[double](System.Span`1[double],double,double):int (FullOpts)
+; Total bytes of code 54, prolog size 4, PerfScore 17.50, instruction count 14, allocated bytes for code 54 (MethodHash=52a202e7) for method System.MemoryExtensions:IndexOfAnyExceptInRange[double](System.Span`1[double],double,double):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -134,4 +138,4 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:red">+39</span> (<span style="color:red">+169.57%</span>) : 19109.dasm - System.Span`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.Span`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,37 +8,46 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Span`1+Enumerator[System.Numerics.Vector`1[float]]>
+;  V03 tmp1         [V03,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Span`1+Enumerator[System.Numerics.Vector`1[float]]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Span`1[System.Numerics.Vector`1[float]]>
-;  V05 tmp3         [V05,T02] (  2,  2   )   byref  ->  rax         single-def "field V04._reference (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T03] (  2,  2   )     int  ->  rcx         "field V04._length (fldOffset=0x8)" P-INDEP
-;* V07 tmp5         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def "V03.[000..008)"
-;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V03.[008..012)"
-;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
+;* V05 tmp3         [V05    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M9978_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M9978_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
+       sub      rsp, 24
+       vxorps   xmm4, xmm4, xmm4
+       vmovdqa  xmmword ptr [rsp], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x10], rax
+						;; size=20 bbWeight=1 PerfScore 3.83
+G_M9978_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, nogc
        ; byrRegs +[rcx rdx]
-       mov      rax, bword ptr [rcx]
-       ; byrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       mov      bword ptr [rdx], rax
-       mov      dword ptr [rdx+0x08], ecx
+       vmovdqu  xmm0, xmmword ptr [rcx]
+       vmovdqu  xmmword ptr [rsp], xmm0
+						;; size=9 bbWeight=1 PerfScore 5.00
+G_M9978_IG03:        ; bbWeight=1, nogc, extend
+       vmovdqu  xmm0, xmmword ptr [rsp]
+       vmovdqu  xmmword ptr [rdx], xmm0
+       mov      rax, qword ptr [rsp+0x10]
+       mov      qword ptr [rdx+0x10], rax
+						;; size=18 bbWeight=1 PerfScore 7.00
+G_M9978_IG04:        ; bbWeight=1, extend
        mov      dword ptr [rdx+0x10], -1
        mov      rax, rdx
-						;; size=22 bbWeight=1 PerfScore 7.25
-G_M9978_IG03:        ; bbWeight=1, epilog, nogc, extend
+       ; byrRegs +[rax]
+						;; size=10 bbWeight=1 PerfScore 1.25
+G_M9978_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 23, prolog size 0, PerfScore 8.25, instruction count 7, allocated bytes for code 23 (MethodHash=9336d905) for method System.Span`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.Span`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)
+; Total bytes of code 62, prolog size 20, PerfScore 18.33, instruction count 15, allocated bytes for code 62 (MethodHash=9336d905) for method System.Span`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.Span`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -46,8 +55,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>

<details>
<summary><span style="color:red">+39</span> (<span style="color:red">+169.57%</span>) : 18971.dasm - System.ReadOnlySpan`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,37 +8,46 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1+Enumerator[System.Numerics.Vector`1[float]]>
+;  V03 tmp1         [V03,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1+Enumerator[System.Numerics.Vector`1[float]]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[System.Numerics.Vector`1[float]]>
-;  V05 tmp3         [V05,T02] (  2,  2   )   byref  ->  rax         single-def "field V04._reference (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T03] (  2,  2   )     int  ->  rcx         "field V04._length (fldOffset=0x8)" P-INDEP
-;* V07 tmp5         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def "V03.[000..008)"
-;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V03.[008..012)"
-;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
+;* V05 tmp3         [V05    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M34746_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M34746_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
+       sub      rsp, 24
+       vxorps   xmm4, xmm4, xmm4
+       vmovdqa  xmmword ptr [rsp], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x10], rax
+						;; size=20 bbWeight=1 PerfScore 3.83
+G_M34746_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, nogc
        ; byrRegs +[rcx rdx]
-       mov      rax, bword ptr [rcx]
-       ; byrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       mov      bword ptr [rdx], rax
-       mov      dword ptr [rdx+0x08], ecx
+       vmovdqu  xmm0, xmmword ptr [rcx]
+       vmovdqu  xmmword ptr [rsp], xmm0
+						;; size=9 bbWeight=1 PerfScore 5.00
+G_M34746_IG03:        ; bbWeight=1, nogc, extend
+       vmovdqu  xmm0, xmmword ptr [rsp]
+       vmovdqu  xmmword ptr [rdx], xmm0
+       mov      rax, qword ptr [rsp+0x10]
+       mov      qword ptr [rdx+0x10], rax
+						;; size=18 bbWeight=1 PerfScore 7.00
+G_M34746_IG04:        ; bbWeight=1, extend
        mov      dword ptr [rdx+0x10], -1
        mov      rax, rdx
-						;; size=22 bbWeight=1 PerfScore 7.25
-G_M34746_IG03:        ; bbWeight=1, epilog, nogc, extend
+       ; byrRegs +[rax]
+						;; size=10 bbWeight=1 PerfScore 1.25
+G_M34746_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 23, prolog size 0, PerfScore 8.25, instruction count 7, allocated bytes for code 23 (MethodHash=e9527845) for method System.ReadOnlySpan`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)
+; Total bytes of code 62, prolog size 20, PerfScore 18.33, instruction count 15, allocated bytes for code 62 (MethodHash=e9527845) for method System.ReadOnlySpan`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -46,8 +55,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-26</span> (<span style="color:green">-59.09%</span>) : 607640.dasm - (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,32 +14,26 @@
 ;* V03 arg2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Object>
 ;* V04 arg3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Object>
 ;# V05 OutArgs      [V05    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid>
+;* V06 tmp1         [V06    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid>
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M58873_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58873_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
        vmovdqu  xmm0, xmmword ptr [rdx]
-       vmovdqu  xmmword ptr [rsp], xmm0
-       mov      eax, dword ptr [rdx+0x10]
-       mov      dword ptr [rsp+0x10], eax
-       vmovdqu  xmm0, xmmword ptr [rsp]
        vmovdqu  xmmword ptr [rcx], xmm0
-       mov      eax, dword ptr [rsp+0x10]
+       mov      eax, dword ptr [rdx+0x10]
        mov      dword ptr [rcx+0x10], eax
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=35 bbWeight=1 PerfScore 15.25
+						;; size=17 bbWeight=1 PerfScore 9.25
 G_M58873_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 44, prolog size 4, PerfScore 16.75, instruction count 12, allocated bytes for code 44 (MethodHash=56071a06) for method (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 10.25, instruction count 6, allocated bytes for code 18 (MethodHash=56071a06) for method (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -47,9 +41,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>

<details>
<summary><span style="color:green">-13</span> (<span style="color:green">-56.52%</span>) : 55186.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,8 +9,8 @@
 ;
 ;  V00 arg0         [V00,T00] (  3,  3   )    long  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
-;  V02 loc0         [V02,T02] (  2,  2   )     int  ->  rdx         single-def
-;  V03 loc1         [V03,T03] (  2,  2   )    long  ->  rax         single-def
+;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
+;* V03 loc1         [V03    ] (  0,  0   )    long  ->  zero-ref   
 ;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -18,18 +18,15 @@
 G_M58437_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58437_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       and      edx, 63
-       mov      eax, 1
-       shlx     rax, rax, rdx
-       test     rcx, rax
-       setne    al
-       movzx    rax, al
-						;; size=22 bbWeight=1 PerfScore 2.50
+       xor      eax, eax
+       bt       rcx, rdx
+       setb     al
+						;; size=9 bbWeight=1 PerfScore 1.75
 G_M58437_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 23, prolog size 0, PerfScore 3.50, instruction count 7, allocated bytes for code 23 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
+; Total bytes of code 10, prolog size 0, PerfScore 2.75, instruction count 4, allocated bytes for code 10 (MethodHash=32011bba) for method Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-5</span> (<span style="color:green">-55.56%</span>) : 613065.dasm - System.Text.Json.Serialization.Tests.CollectionTests+RefCountedList`1[int]:<System.Collections.Generic.IEnumerable<T>.GetEnumerator>b__6_0():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Text.Json.Serialization.Tests.CollectionTests+RefCountedList`1[int]>
-;  V01 loc0         [V01,T01] (  2,  2   )     int  ->  rax         single-def
+;* V01 loc0         [V01    ] (  0,  0   )     int  ->  zero-ref   
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
@@ -19,15 +19,13 @@ G_M36694_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M36694_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      eax, dword ptr [rcx+0x18]
-       dec      eax
-       mov      dword ptr [rcx+0x18], eax
-						;; size=8 bbWeight=1 PerfScore 3.25
+       dec      dword ptr [rcx+0x18]
+						;; size=3 bbWeight=1 PerfScore 3.00
 G_M36694_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 4.25, instruction count 4, allocated bytes for code 9 (MethodHash=24c870a9) for method System.Text.Json.Serialization.Tests.CollectionTests+RefCountedList`1[int]:<System.Collections.Generic.IEnumerable<T>.GetEnumerator>b__6_0():this (Tier1)
+; Total bytes of code 4, prolog size 0, PerfScore 4.00, instruction count 2, allocated bytes for code 4 (MethodHash=24c870a9) for method System.Text.Json.Serialization.Tests.CollectionTests+RefCountedList`1[int]:<System.Collections.Generic.IEnumerable<T>.GetEnumerator>b__6_0():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+33</span> (<span style="color:red">+75.00%</span>) : 112076.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -13,40 +13,48 @@
 ;  V01 RetBuf       [V01,T00] (  7,  4.99)   byref  ->  rbx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[S] ld-addr-op <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V04 tmp1         [V04    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
+;  V04 tmp1         [V04,T02] (  2,  3.96)  struct (16) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>
-;  V06 tmp3         [V06,T02] (  2,  1.98)     ref  ->  rdx         single-def "field V05._contexts (fldOffset=0x0)" P-INDEP
+;* V06 tmp3         [V06    ] (  0,  0   )     ref  ->  zero-ref    "field V05._contexts (fldOffset=0x0)" P-INDEP
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "V04.[000..001)"
-;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    "V04.[008..016)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 16
 
 G_M48622_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
+       sub      rsp, 16
+       xor      eax, eax
+       mov      qword ptr [rsp], rax
+       mov      qword ptr [rsp+0x08], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=4 bbWeight=1 PerfScore 1.25
+						;; size=19 bbWeight=1 PerfScore 3.75
 G_M48622_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref, isz
        ; byrRegs +[rcx]
        cmp      dword ptr [rcx], 2
-       jne      SHORT G_M48622_IG05
+       jne      SHORT G_M48622_IG06
 						;; size=5 bbWeight=1 PerfScore 4.00
-G_M48622_IG03:        ; bbWeight=0.99, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
-       mov      rdx, gword ptr [rcx+0x08]
-       ; gcrRegs +[rdx]
+G_M48622_IG03:        ; bbWeight=0.99, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref, nogc
+       mov      rdx, qword ptr [rcx+0x08]
+       mov      qword ptr [rsp+0x08], rdx
+						;; size=9 bbWeight=0.99 PerfScore 2.97
+G_M48622_IG04:        ; bbWeight=0.99, extend
        mov      byte  ptr [rbx], 1
        lea      rcx, bword ptr [rbx+0x08]
+       mov      rdx, gword ptr [rsp+0x08]
+       ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=19 bbWeight=0.99 PerfScore 4.70
-G_M48622_IG04:        ; bbWeight=0.99, epilog, nogc, extend
+						;; size=20 bbWeight=0.99 PerfScore 3.71
+G_M48622_IG05:        ; bbWeight=0.99, epilog, nogc, extend
+       add      rsp, 16
        pop      rbx
        ret      
-						;; size=2 bbWeight=0.99 PerfScore 1.48
-G_M48622_IG05:        ; bbWeight=0.01, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+						;; size=6 bbWeight=0.99 PerfScore 1.73
+G_M48622_IG06:        ; bbWeight=0.01, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        ; byrRegs -[rax]
        xor      eax, eax
        mov      qword ptr [rbx], rax
@@ -54,12 +62,13 @@ G_M48622_IG05:        ; bbWeight=0.01, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=12 bbWeight=0.01 PerfScore 0.03
-G_M48622_IG06:        ; bbWeight=0.01, epilog, nogc, extend
+G_M48622_IG07:        ; bbWeight=0.01, epilog, nogc, extend
+       add      rsp, 16
        pop      rbx
        ret      
-						;; size=2 bbWeight=0.01 PerfScore 0.02
+						;; size=6 bbWeight=0.01 PerfScore 0.02
 
-; Total bytes of code 44, prolog size 1, PerfScore 11.48, instruction count 17, allocated bytes for code 44 (MethodHash=ff884211) for method Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
+; Total bytes of code 77, prolog size 16, PerfScore 16.20, instruction count 25, allocated bytes for code 77 (MethodHash=ff884211) for method Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -67,9 +76,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x01
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+33</span> (<span style="color:red">+75.00%</span>) : 84624.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -13,40 +13,48 @@
 ;  V01 RetBuf       [V01,T00] (  7,  4.95)   byref  ->  rbx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[S] ld-addr-op <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V04 tmp1         [V04    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
+;  V04 tmp1         [V04,T02] (  2,  3.81)  struct (16) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>
-;  V06 tmp3         [V06,T02] (  2,  1.90)     ref  ->  rdx         single-def "field V05._contexts (fldOffset=0x0)" P-INDEP
+;* V06 tmp3         [V06    ] (  0,  0   )     ref  ->  zero-ref    "field V05._contexts (fldOffset=0x0)" P-INDEP
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "V04.[000..001)"
-;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    "V04.[008..016)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 16
 
 G_M48622_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
+       sub      rsp, 16
+       xor      eax, eax
+       mov      qword ptr [rsp], rax
+       mov      qword ptr [rsp+0x08], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=4 bbWeight=1 PerfScore 1.25
+						;; size=19 bbWeight=1 PerfScore 3.75
 G_M48622_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref, isz
        ; byrRegs +[rcx]
        cmp      dword ptr [rcx], 2
-       jne      SHORT G_M48622_IG05
+       jne      SHORT G_M48622_IG06
 						;; size=5 bbWeight=1 PerfScore 4.00
-G_M48622_IG03:        ; bbWeight=0.95, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
-       mov      rdx, gword ptr [rcx+0x08]
-       ; gcrRegs +[rdx]
+G_M48622_IG03:        ; bbWeight=0.95, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref, nogc
+       mov      rdx, qword ptr [rcx+0x08]
+       mov      qword ptr [rsp+0x08], rdx
+						;; size=9 bbWeight=0.95 PerfScore 2.86
+G_M48622_IG04:        ; bbWeight=0.95, extend
        mov      byte  ptr [rbx], 1
        lea      rcx, bword ptr [rbx+0x08]
+       mov      rdx, gword ptr [rsp+0x08]
+       ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=19 bbWeight=0.95 PerfScore 4.52
-G_M48622_IG04:        ; bbWeight=0.95, epilog, nogc, extend
+						;; size=20 bbWeight=0.95 PerfScore 3.57
+G_M48622_IG05:        ; bbWeight=0.95, epilog, nogc, extend
+       add      rsp, 16
        pop      rbx
        ret      
-						;; size=2 bbWeight=0.95 PerfScore 1.43
-G_M48622_IG05:        ; bbWeight=0.05, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+						;; size=6 bbWeight=0.95 PerfScore 1.67
+G_M48622_IG06:        ; bbWeight=0.05, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        ; byrRegs -[rax]
        xor      eax, eax
        mov      qword ptr [rbx], rax
@@ -54,12 +62,13 @@ G_M48622_IG05:        ; bbWeight=0.05, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=12 bbWeight=0.05 PerfScore 0.12
-G_M48622_IG06:        ; bbWeight=0.05, epilog, nogc, extend
+G_M48622_IG07:        ; bbWeight=0.05, epilog, nogc, extend
+       add      rsp, 16
        pop      rbx
        ret      
-						;; size=2 bbWeight=0.05 PerfScore 0.07
+						;; size=6 bbWeight=0.05 PerfScore 0.08
 
-; Total bytes of code 44, prolog size 1, PerfScore 11.39, instruction count 17, allocated bytes for code 44 (MethodHash=ff884211) for method Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
+; Total bytes of code 77, prolog size 16, PerfScore 16.05, instruction count 25, allocated bytes for code 77 (MethodHash=ff884211) for method Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -67,9 +76,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x01
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+33</span> (<span style="color:red">+75.00%</span>) : 184829.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -13,40 +13,48 @@
 ;  V01 RetBuf       [V01,T00] (  7,  4.97)   byref  ->  rbx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[S] ld-addr-op <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V04 tmp1         [V04    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
+;  V04 tmp1         [V04,T02] (  2,  3.89)  struct (16) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>
-;  V06 tmp3         [V06,T02] (  2,  1.94)     ref  ->  rdx         single-def "field V05._contexts (fldOffset=0x0)" P-INDEP
+;* V06 tmp3         [V06    ] (  0,  0   )     ref  ->  zero-ref    "field V05._contexts (fldOffset=0x0)" P-INDEP
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "V04.[000..001)"
-;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    "V04.[008..016)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 16
 
 G_M48622_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
+       sub      rsp, 16
+       xor      eax, eax
+       mov      qword ptr [rsp], rax
+       mov      qword ptr [rsp+0x08], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=4 bbWeight=1 PerfScore 1.25
+						;; size=19 bbWeight=1 PerfScore 3.75
 G_M48622_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref, isz
        ; byrRegs +[rcx]
        cmp      dword ptr [rcx], 2
-       jne      SHORT G_M48622_IG05
+       jne      SHORT G_M48622_IG06
 						;; size=5 bbWeight=1 PerfScore 4.00
-G_M48622_IG03:        ; bbWeight=0.97, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
-       mov      rdx, gword ptr [rcx+0x08]
-       ; gcrRegs +[rdx]
+G_M48622_IG03:        ; bbWeight=0.97, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref, nogc
+       mov      rdx, qword ptr [rcx+0x08]
+       mov      qword ptr [rsp+0x08], rdx
+						;; size=9 bbWeight=0.97 PerfScore 2.92
+G_M48622_IG04:        ; bbWeight=0.97, extend
        mov      byte  ptr [rbx], 1
        lea      rcx, bword ptr [rbx+0x08]
+       mov      rdx, gword ptr [rsp+0x08]
+       ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=19 bbWeight=0.97 PerfScore 4.62
-G_M48622_IG04:        ; bbWeight=0.97, epilog, nogc, extend
+						;; size=20 bbWeight=0.97 PerfScore 3.65
+G_M48622_IG05:        ; bbWeight=0.97, epilog, nogc, extend
+       add      rsp, 16
        pop      rbx
        ret      
-						;; size=2 bbWeight=0.97 PerfScore 1.46
-G_M48622_IG05:        ; bbWeight=0.03, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+						;; size=6 bbWeight=0.97 PerfScore 1.70
+G_M48622_IG06:        ; bbWeight=0.03, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        ; byrRegs -[rax]
        xor      eax, eax
        mov      qword ptr [rbx], rax
@@ -54,12 +62,13 @@ G_M48622_IG05:        ; bbWeight=0.03, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=12 bbWeight=0.03 PerfScore 0.07
-G_M48622_IG06:        ; bbWeight=0.03, epilog, nogc, extend
+G_M48622_IG07:        ; bbWeight=0.03, epilog, nogc, extend
+       add      rsp, 16
        pop      rbx
        ret      
-						;; size=2 bbWeight=0.03 PerfScore 0.04
+						;; size=6 bbWeight=0.03 PerfScore 0.05
 
-; Total bytes of code 44, prolog size 1, PerfScore 11.44, instruction count 17, allocated bytes for code 44 (MethodHash=ff884211) for method Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
+; Total bytes of code 77, prolog size 16, PerfScore 16.13, instruction count 25, allocated bytes for code 77 (MethodHash=ff884211) for method Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -67,9 +76,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x01
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-26</span> (<span style="color:green">-59.09%</span>) : 278152.dasm - (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,32 +14,26 @@
 ;* V03 arg2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Object>
 ;* V04 arg3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Object>
 ;# V05 OutArgs      [V05    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid>
+;* V06 tmp1         [V06    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid>
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M58873_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58873_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
        vmovdqu  xmm0, xmmword ptr [rdx]
-       vmovdqu  xmmword ptr [rsp], xmm0
-       mov      eax, dword ptr [rdx+0x10]
-       mov      dword ptr [rsp+0x10], eax
-       vmovdqu  xmm0, xmmword ptr [rsp]
        vmovdqu  xmmword ptr [rcx], xmm0
-       mov      eax, dword ptr [rsp+0x10]
+       mov      eax, dword ptr [rdx+0x10]
        mov      dword ptr [rcx+0x10], eax
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=35 bbWeight=1 PerfScore 15.25
+						;; size=17 bbWeight=1 PerfScore 9.25
 G_M58873_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 44, prolog size 4, PerfScore 16.75, instruction count 12, allocated bytes for code 44 (MethodHash=56071a06) for method (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 10.25, instruction count 6, allocated bytes for code 18 (MethodHash=56071a06) for method (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -47,9 +41,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>

<details>
<summary><span style="color:green">-5</span> (<span style="color:green">-55.56%</span>) : 39073.dasm - Microsoft.Extensions.Diagnostics.Tests.MetricsSubscriptionManagerTests+FakeListener:Initialize(Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Extensions.Diagnostics.Tests.MetricsSubscriptionManagerTests+FakeListener>
 ;* V01 arg1         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource>
-;  V02 loc0         [V02,T01] (  2,  2   )     int  ->  rax         single-def
+;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
@@ -20,15 +20,13 @@ G_M35550_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M35550_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      dword ptr [rcx+0x08], eax
-						;; size=8 bbWeight=1 PerfScore 3.25
+       inc      dword ptr [rcx+0x08]
+						;; size=3 bbWeight=1 PerfScore 3.00
 G_M35550_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 4.25, instruction count 4, allocated bytes for code 9 (MethodHash=bb057521) for method Microsoft.Extensions.Diagnostics.Tests.MetricsSubscriptionManagerTests+FakeListener:Initialize(Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource):this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 4.00, instruction count 2, allocated bytes for code 4 (MethodHash=bb057521) for method Microsoft.Extensions.Diagnostics.Tests.MetricsSubscriptionManagerTests+FakeListener:Initialize(Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-5</span> (<span style="color:green">-55.56%</span>) : 102113.dasm - System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass9_0:<MeterDisposalsTest>b__9(System.Diagnostics.Metrics.Instrument,System.Decimal,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,7 +12,7 @@
 ;* V02 arg2         [V02    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;* V03 arg3         [V03    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;* V04 arg4         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Object>
-;  V05 loc0         [V05,T01] (  2,  2   )     int  ->  rax         single-def
+;* V05 loc0         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;# V06 OutArgs      [V06    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V07 tmp1         [V07    ] (  0,  0   )     int  ->  zero-ref    "field V02._flags (fldOffset=0x0)" P-INDEP
 ;* V08 tmp2         [V08    ] (  0,  0   )     int  ->  zero-ref    "field V02._hi32 (fldOffset=0x4)" P-INDEP
@@ -28,15 +28,13 @@ G_M24484_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M24484_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      dword ptr [rcx+0x08], eax
-						;; size=8 bbWeight=1 PerfScore 3.25
+       inc      dword ptr [rcx+0x08]
+						;; size=3 bbWeight=1 PerfScore 3.00
 G_M24484_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 4.25, instruction count 4, allocated bytes for code 9 (MethodHash=a7aca05b) for method System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass9_0:<MeterDisposalsTest>b__9(System.Diagnostics.Metrics.Instrument,System.Decimal,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 4.00, instruction count 2, allocated bytes for code 4 (MethodHash=a7aca05b) for method System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass9_0:<MeterDisposalsTest>b__9(System.Diagnostics.Metrics.Instrument,System.Decimal,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+37</span> (<span style="color:red">+39.36%</span>) : 152355.dasm - System.SpanTests.SpanTests:EmptySpansNotUnified() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -23,7 +23,7 @@
 ;* V12 tmp10        [V12,T09] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V13 tmp11        [V13    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
 ;* V14 tmp12        [V14    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
-;* V15 tmp13        [V15,T03] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
+;* V15 tmp13        [V15    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V16 tmp14        [V16    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V17 tmp15        [V17    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Nullable`1[ubyte]>
 ;  V18 tmp16        [V18,T06] (  2,  2   )   byref  ->  rsi         "field V00._reference (fldOffset=0x0)" P-INDEP
@@ -35,7 +35,7 @@
 ;* V24 tmp22        [V24    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V07._reference (fldOffset=0x0)" P-INDEP
 ;* V25 tmp23        [V25    ] (  0,  0   )     int  ->  zero-ref    single-def "field V07._length (fldOffset=0x8)" P-INDEP
 ;* V26 tmp24        [V26,T12] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V08.hasValue (fldOffset=0x0)" P-INDEP
-;  V27 tmp25        [V27,T05] (  3,  2   )   ubyte  ->  rdx         single-def "field V08.value (fldOffset=0x1)" P-INDEP
+;  V27 tmp25        [V27,T04] (  3,  2   )   ubyte  ->  rdx         single-def "field V08.value (fldOffset=0x1)" P-INDEP
 ;* V28 tmp26        [V28    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V09.hasValue (fldOffset=0x0)" P-INDEP
 ;* V29 tmp27        [V29    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V09.value (fldOffset=0x1)" P-INDEP
 ;* V30 tmp28        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V10._reference (fldOffset=0x0)" P-INDEP
@@ -47,12 +47,12 @@
 ;* V36 tmp34        [V36    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V14._reference (fldOffset=0x0)" P-INDEP
 ;* V37 tmp35        [V37    ] (  0,  0   )     int  ->  zero-ref    single-def "field V14._length (fldOffset=0x8)" P-INDEP
 ;* V38 tmp36        [V38,T13] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V16.hasValue (fldOffset=0x0)" P-INDEP
-;* V39 tmp37        [V39,T14] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V16.value (fldOffset=0x1)" P-INDEP
+;  V39 tmp37        [V39,T05] (  3,  2   )   ubyte  ->  rax         single-def "field V16.value (fldOffset=0x1)" P-INDEP
 ;* V40 tmp38        [V40    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V17.hasValue (fldOffset=0x0)" P-INDEP
 ;* V41 tmp39        [V41    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V17.value (fldOffset=0x1)" P-INDEP
-;  V42 tmp40        [V42,T15] (  3,  0   )  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
-;  V43 cse0         [V43,T00] (  2,  2   )     int  ->  rdx         "CSE - moderate"
-;  V44 cse1         [V44,T04] (  3,  3   )    long  ->  rbx         "CSE - aggressive"
+;  V42 tmp40        [V42,T14] (  6,  0   )  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
+;  V43 cse0         [V43,T00] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V44 cse1         [V44,T03] (  3,  3   )    long  ->  rbx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -77,12 +77,16 @@ G_M45607_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        add      rax, 16
        ; gcrRegs -[rax]
        ; byrRegs +[rax]
-       xor      edx, edx
        cmp      rsi, rax
-       sete     dl
+       sete     al
+       ; byrRegs -[rax]
+       movzx    rax, al
+       mov      edx, eax
        test     edx, edx
        jne      SHORT G_M45607_IG04
-						;; size=50 bbWeight=1 PerfScore 6.75
+       test     eax, eax
+       jne      SHORT G_M45607_IG05
+						;; size=57 bbWeight=1 PerfScore 8.25
 G_M45607_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
@@ -90,7 +94,7 @@ G_M45607_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=7 bbWeight=1 PerfScore 2.25
 G_M45607_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rax rsi]
+       ; byrRegs -[rsi]
        mov      byte  ptr [rsp+0x20], 1
        mov      byte  ptr [rsp+0x21], dl
        movzx    rdx, word  ptr [rsp+0x20]
@@ -103,11 +107,26 @@ G_M45607_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        ; gcrRegs +[rcx]
        call     CORINFO_HELP_THROW
        ; gcrRegs -[rax rcx]
+       ; gcr arg pop 0
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M45607_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      byte  ptr [rsp+0x20], 1
+       mov      byte  ptr [rsp+0x21], al
+       movzx    rdx, word  ptr [rsp+0x20]
+       xor      rcx, rcx
+       ; gcrRegs +[rcx]
+       call     [<unknown method>]
+       ; gcrRegs -[rcx] +[rax]
+       ; gcr arg pop 0
+       mov      rcx, rax
+       ; gcrRegs +[rcx]
+       call     CORINFO_HELP_THROW
+       ; gcrRegs -[rax rcx]
        ; gcr arg pop 0
        int3     
 						;; size=31 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 94, prolog size 6, PerfScore 11.25, instruction count 29, allocated bytes for code 94 (MethodHash=d95a4dd8) for method System.SpanTests.SpanTests:EmptySpansNotUnified() (FullOpts)
+; Total bytes of code 131, prolog size 6, PerfScore 12.75, instruction count 39, allocated bytes for code 131 (MethodHash=d95a4dd8) for method System.SpanTests.SpanTests:EmptySpansNotUnified() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+37</span> (<span style="color:red">+39.36%</span>) : 153516.dasm - System.SpanTests.ReadOnlySpanTests:EmptySpansNotUnified() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -23,7 +23,7 @@
 ;* V12 tmp10        [V12,T09] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V13 tmp11        [V13    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[int]>
 ;* V14 tmp12        [V14    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[int]>
-;* V15 tmp13        [V15,T03] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
+;* V15 tmp13        [V15    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V16 tmp14        [V16    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V17 tmp15        [V17    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Nullable`1[ubyte]>
 ;  V18 tmp16        [V18,T06] (  2,  2   )   byref  ->  rsi         "field V00._reference (fldOffset=0x0)" P-INDEP
@@ -35,7 +35,7 @@
 ;* V24 tmp22        [V24    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V07._reference (fldOffset=0x0)" P-INDEP
 ;* V25 tmp23        [V25    ] (  0,  0   )     int  ->  zero-ref    single-def "field V07._length (fldOffset=0x8)" P-INDEP
 ;* V26 tmp24        [V26,T12] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V08.hasValue (fldOffset=0x0)" P-INDEP
-;  V27 tmp25        [V27,T05] (  3,  2   )   ubyte  ->  rdx         single-def "field V08.value (fldOffset=0x1)" P-INDEP
+;  V27 tmp25        [V27,T04] (  3,  2   )   ubyte  ->  rdx         single-def "field V08.value (fldOffset=0x1)" P-INDEP
 ;* V28 tmp26        [V28    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V09.hasValue (fldOffset=0x0)" P-INDEP
 ;* V29 tmp27        [V29    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V09.value (fldOffset=0x1)" P-INDEP
 ;* V30 tmp28        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V10._reference (fldOffset=0x0)" P-INDEP
@@ -47,12 +47,12 @@
 ;* V36 tmp34        [V36    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V14._reference (fldOffset=0x0)" P-INDEP
 ;* V37 tmp35        [V37    ] (  0,  0   )     int  ->  zero-ref    single-def "field V14._length (fldOffset=0x8)" P-INDEP
 ;* V38 tmp36        [V38,T13] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V16.hasValue (fldOffset=0x0)" P-INDEP
-;* V39 tmp37        [V39,T14] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V16.value (fldOffset=0x1)" P-INDEP
+;  V39 tmp37        [V39,T05] (  3,  2   )   ubyte  ->  rax         single-def "field V16.value (fldOffset=0x1)" P-INDEP
 ;* V40 tmp38        [V40    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V17.hasValue (fldOffset=0x0)" P-INDEP
 ;* V41 tmp39        [V41    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V17.value (fldOffset=0x1)" P-INDEP
-;  V42 tmp40        [V42,T15] (  3,  0   )  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
-;  V43 cse0         [V43,T00] (  2,  2   )     int  ->  rdx         "CSE - moderate"
-;  V44 cse1         [V44,T04] (  3,  3   )    long  ->  rbx         "CSE - aggressive"
+;  V42 tmp40        [V42,T14] (  6,  0   )  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
+;  V43 cse0         [V43,T00] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V44 cse1         [V44,T03] (  3,  3   )    long  ->  rbx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -77,12 +77,16 @@ G_M33121_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        add      rax, 16
        ; gcrRegs -[rax]
        ; byrRegs +[rax]
-       xor      edx, edx
        cmp      rsi, rax
-       sete     dl
+       sete     al
+       ; byrRegs -[rax]
+       movzx    rax, al
+       mov      edx, eax
        test     edx, edx
        jne      SHORT G_M33121_IG04
-						;; size=50 bbWeight=1 PerfScore 6.75
+       test     eax, eax
+       jne      SHORT G_M33121_IG05
+						;; size=57 bbWeight=1 PerfScore 8.25
 G_M33121_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
@@ -90,7 +94,7 @@ G_M33121_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=7 bbWeight=1 PerfScore 2.25
 G_M33121_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rax rsi]
+       ; byrRegs -[rsi]
        mov      byte  ptr [rsp+0x20], 1
        mov      byte  ptr [rsp+0x21], dl
        movzx    rdx, word  ptr [rsp+0x20]
@@ -103,11 +107,26 @@ G_M33121_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        ; gcrRegs +[rcx]
        call     CORINFO_HELP_THROW
        ; gcrRegs -[rax rcx]
+       ; gcr arg pop 0
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M33121_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      byte  ptr [rsp+0x20], 1
+       mov      byte  ptr [rsp+0x21], al
+       movzx    rdx, word  ptr [rsp+0x20]
+       xor      rcx, rcx
+       ; gcrRegs +[rcx]
+       call     [<unknown method>]
+       ; gcrRegs -[rcx] +[rax]
+       ; gcr arg pop 0
+       mov      rcx, rax
+       ; gcrRegs +[rcx]
+       call     CORINFO_HELP_THROW
+       ; gcrRegs -[rax rcx]
        ; gcr arg pop 0
        int3     
 						;; size=31 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 94, prolog size 6, PerfScore 11.25, instruction count 29, allocated bytes for code 94 (MethodHash=9acf7e9e) for method System.SpanTests.ReadOnlySpanTests:EmptySpansNotUnified() (FullOpts)
+; Total bytes of code 131, prolog size 6, PerfScore 12.75, instruction count 39, allocated bytes for code 131 (MethodHash=9acf7e9e) for method System.SpanTests.ReadOnlySpanTests:EmptySpansNotUnified() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+25</span> (<span style="color:red">+64.10%</span>) : 69701.dasm - System.Collections.Concurrent.Tests.PartitionerStaticTests+<>c__DisplayClass7_1:<TestExceptions>b__0():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,41 +7,53 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Concurrent.Tests.PartitionerStaticTests+<>c__DisplayClass7_1>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  [rsp+0x30]  this class-hnd single-def <System.Collections.Concurrent.Tests.PartitionerStaticTests+<>c__DisplayClass7_1>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <<unknown class>>
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <<unknown class>>
+;  TEMP_01                                   byref  ->  [rsp+0x20]
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M6846_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+       xor      eax, eax
+       mov      qword ptr [rsp+0x20], rax
+						;; size=11 bbWeight=1 PerfScore 1.50
 G_M6846_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rbx, gword ptr [rcx+0x08]
-       ; gcrRegs +[rbx]
-       mov      edx, dword ptr [rcx+0x10]
+       mov      gword ptr [rsp+0x30], rcx
+       ; GC ptr vars +{V00}
+       mov      rdx, gword ptr [rcx+0x08]
+       ; gcrRegs +[rdx]
+       lea      rcx, bword ptr [rdx+0x08]
+       ; gcrRegs -[rcx]
+       ; byrRegs +[rcx]
+       mov      bword ptr [rsp+0x20], rcx
+       mov      rdx, gword ptr [rsp+0x30]
+       mov      edx, dword ptr [rdx+0x10]
+       ; gcrRegs -[rdx]
        xor      rcx, rcx
+       ; gcrRegs +[rcx]
+       ; byrRegs -[rcx]
+       ; GC ptr vars -{V00}
        call     [System.Collections.Concurrent.Tests.PartitionerStaticTests:PartitioningWithAlgorithm[int](int[],int):System.Collections.Concurrent.OrderablePartitioner`1[int]]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       lea      rcx, bword ptr [rbx+0x08]
+       mov      rcx, bword ptr [rsp+0x20]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
-       ; gcrRegs -[rax rdx rbx]
+       ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
        nop      
-						;; size=28 bbWeight=1 PerfScore 9.25
+						;; size=48 bbWeight=1 PerfScore 13.25
 G_M6846_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 39, prolog size 5, PerfScore 12.25, instruction count 13, allocated bytes for code 39 (MethodHash=c358e541) for method System.Collections.Concurrent.Tests.PartitionerStaticTests+<>c__DisplayClass7_1:<TestExceptions>b__0():this (FullOpts)
+; Total bytes of code 64, prolog size 11, PerfScore 16.00, instruction count 17, allocated bytes for code 64 (MethodHash=c358e541) for method System.Collections.Concurrent.Tests.PartitionerStaticTests+<>c__DisplayClass7_1:<TestExceptions>b__0():this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -49,10 +61,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-64.29%</span>) : 9711.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadMultipleMethodSemantics@2366-3:Invoke(System.Tuple`3[int,int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]]):FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,27 +12,24 @@
 ;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <System.Tuple`3[int,int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]]>
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;* V03 loc1         [V03    ] (  0,  0   )     int  ->  zero-ref   
-;  V04 loc2         [V04    ] (  2,  2   )  struct ( 8) [rsp+0x00]  do-not-enreg[S] <FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]>
+;* V04 loc2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[S] <FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]>
 ;# V05 OutArgs      [V05    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T01] (  2,  2   )     int  ->  [rsp+0x00]  do-not-enreg[] "field V04.tag@ (fldOffset=0x0)" P-DEP
-;  V07 tmp2         [V07,T02] (  2,  2   )     int  ->  [rsp+0x04]  do-not-enreg[] "field V04.index@ (fldOffset=0x4)" P-DEP
+;* V06 tmp1         [V06    ] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V04.tag@ (fldOffset=0x0)" P-DEP
+;* V07 tmp2         [V07    ] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V04.index@ (fldOffset=0x4)" P-DEP
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M27744_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M27744_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
        mov      rax, qword ptr [rdx+0x10]
-       mov      qword ptr [rsp], rax
-						;; size=8 bbWeight=1 PerfScore 3.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M27744_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 1, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=077a939f) for method FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadMultipleMethodSemantics@2366-3:Invoke(System.Tuple`3[int,int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]]):FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=077a939f) for method FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadMultipleMethodSemantics@2366-3:Invoke(System.Tuple`3[int,int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]]):FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -40,9 +37,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x01
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08

```


</div></details>

<details>
<summary><span style="color:green">-5</span> (<span style="color:green">-55.56%</span>) : 36382.dasm - System.Management.Automation.ModuleIntrinsics:DecrementModuleNestingCount():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Management.Automation.ModuleIntrinsics>
-;  V01 loc0         [V01,T01] (  2,  2   )     int  ->  rax         single-def
+;* V01 loc0         [V01    ] (  0,  0   )     int  ->  zero-ref   
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -18,15 +18,13 @@ G_M33438_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M33438_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      eax, dword ptr [rcx+0x18]
-       dec      eax
-       mov      dword ptr [rcx+0x18], eax
-						;; size=8 bbWeight=1 PerfScore 3.25
+       dec      dword ptr [rcx+0x18]
+						;; size=3 bbWeight=1 PerfScore 3.00
 G_M33438_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 4.25, instruction count 4, allocated bytes for code 9 (MethodHash=fab57d61) for method System.Management.Automation.ModuleIntrinsics:DecrementModuleNestingCount():this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 4.00, instruction count 2, allocated bytes for code 4 (MethodHash=fab57d61) for method System.Management.Automation.ModuleIntrinsics:DecrementModuleNestingCount():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-4</span> (<span style="color:green">-50.00%</span>) : 15176.dasm - SixLabors.ImageSharp.Image:get_Height():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <SixLabors.ImageSharp.Image>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )   byref  ->  rcx         single-def "Inlining Arg"
+;* V02 tmp1         [V02    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 0
 
@@ -18,16 +18,13 @@ G_M60889_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M60889_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       add      rcx, 36
-       ; gcrRegs -[rcx]
-       ; byrRegs +[rcx]
-       mov      eax, dword ptr [rcx+0x04]
-						;; size=7 bbWeight=1 PerfScore 2.25
+       mov      eax, dword ptr [rcx+0x28]
+						;; size=3 bbWeight=1 PerfScore 2.00
 G_M60889_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 8, prolog size 0, PerfScore 3.25, instruction count 3, allocated bytes for code 8 (MethodHash=af3b1226) for method SixLabors.ImageSharp.Image:get_Height():int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=af3b1226) for method SixLabors.ImageSharp.Image:get_Height():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+27</span> (<span style="color:red">+27.55%</span>) : 21741.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,24 +8,23 @@
 ; 0 inlinees with PGO data; 11 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T06] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LookupResult>
+;  V00 arg0         [V00,T05] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LookupResult>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbol]>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T08] (  3,  3   )     ref  ->  rbx         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol]>
+;  V03 tmp1         [V03,T06] (  3,  3   )     ref  ->  rbx         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbol]>
 ;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
 ;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V07 tmp5         [V07,T05] (  2,  8   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V07 tmp5         [V07,T01] (  3, 24   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
 ;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V09 tmp7         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
-;  V10 tmp8         [V10,T01] (  2, 16   )     ref  ->  rax         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;  V11 tmp9         [V11,T07] (  2,  4.50)     ref  ->  rbx         single-def "field V01._builder (fldOffset=0x0)" P-INDEP
-;  V12 tmp10        [V12,T00] (  6, 16.50)     int  ->  rsi         "field V01._index (fldOffset=0x8)" P-INDEP
-;  V13 tmp11        [V13,T09] (  2,  1   )     ref  ->  rbx         single-def "field V04._builder (fldOffset=0x0)" P-INDEP
-;* V14 tmp12        [V14,T10] (  0,  0   )     int  ->  zero-ref    single-def "field V04._index (fldOffset=0x8)" P-INDEP
-;  V15 tmp13        [V15,T02] (  3, 12   )     ref  ->  rcx         "arr expr"
-;  V16 tmp14        [V16,T03] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V17 cse0         [V17,T04] (  3, 10   )     ref  ->  rcx         "CSE - aggressive"
+;* V10 tmp8         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V11 tmp9         [V11,T04] (  4,  9   )     ref  ->  rbx         single-def "field V01._builder (fldOffset=0x0)" P-INDEP
+;  V12 tmp10        [V12,T00] (  7, 24.50)     int  ->  rsi         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V13 tmp11        [V13,T07] (  2,  1   )     ref  ->  rbx         single-def "field V04._builder (fldOffset=0x0)" P-INDEP
+;* V14 tmp12        [V14,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V04._index (fldOffset=0x8)" P-INDEP
+;  V15 tmp13        [V15,T02] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V16 tmp14        [V16,T03] (  3, 24   )     ref  ->  rcx         "argument with side effect"
 ;
 ; Lcl frame size = 40
 
@@ -54,13 +53,20 @@ G_M51640_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rbx, gword ptr [rcx+0x08]
        ; gcrRegs +[rbx]
        cmp      byte  ptr [rbx], bl
-       mov      esi, -1
-       jmp      SHORT G_M51640_IG07
-						;; size=13 bbWeight=0.50 PerfScore 3.62
-G_M51640_IG06:        ; bbWeight=2, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
+       xor      esi, esi
+       mov      rcx, gword ptr [rbx+0x08]
+       cmp      dword ptr [rcx+0x10], 0
+       jle      SHORT G_M51640_IG03
+						;; size=18 bbWeight=0.50 PerfScore 5.62
+G_M51640_IG06:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, gword ptr [rbx+0x08]
+       ; gcrRegs +[rcx]
+       cmp      esi, dword ptr [rcx+0x10]
+       jge      SHORT G_M51640_IG11
        mov      rcx, gword ptr [rcx+0x08]
        cmp      esi, dword ptr [rcx+0x08]
-       jae      SHORT G_M51640_IG11
+       jae      SHORT G_M51640_IG10
        mov      eax, esi
        mov      rcx, gword ptr [rcx+8*rax+0x10]
        mov      rax, qword ptr [rcx]
@@ -69,37 +75,38 @@ G_M51640_IG06:        ; bbWeight=2, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        cmp      eax, 12
-       je       SHORT G_M51640_IG09
-						;; size=30 bbWeight=2 PerfScore 33.00
-G_M51640_IG07:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       je       SHORT G_M51640_IG08
        inc      esi
-       mov      rcx, gword ptr [rbx+0x08]
-       ; gcrRegs +[rcx]
-       mov      rax, rcx
+       mov      rax, gword ptr [rbx+0x08]
        ; gcrRegs +[rax]
        cmp      esi, dword ptr [rax+0x10]
        jl       SHORT G_M51640_IG06
-						;; size=14 bbWeight=4 PerfScore 26.00
-G_M51640_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax rcx rbx]
+						;; size=50 bbWeight=4 PerfScore 115.00
+G_M51640_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rax rbx]
        jmp      SHORT G_M51640_IG03
 						;; size=2 bbWeight=0.50 PerfScore 1.00
-G_M51640_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M51640_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M51640_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+G_M51640_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rsi
        ret      
 						;; size=7 bbWeight=0.50 PerfScore 1.12
-G_M51640_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M51640_IG10:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
+       ; gcr arg pop 0
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M51640_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     [System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]:ThrowIndexOutOfRangeException()]
        ; gcr arg pop 0
        int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
+						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 98, prolog size 6, PerfScore 72.38, instruction count 37, allocated bytes for code 98 (MethodHash=e74d3647) for method Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
+; Total bytes of code 125, prolog size 6, PerfScore 130.38, instruction count 43, allocated bytes for code 125 (MethodHash=e74d3647) for method Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+32</span> (<span style="color:red">+27.59%</span>) : 26357.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:All[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon],System.Func`2[System.__Canon,ubyte]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,21 +10,24 @@
 ;
 ;* V00 TypeCtx      [V00    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;  V01 arg0         [V01,T04] (  3,  3   )     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
-;  V02 arg1         [V02,T03] (  4,  6   )     ref  ->  rbx         class-hnd single-def <System.Func`2[System.__Canon,ubyte]>
-;  V03 loc0         [V03    ] (  7, 37   )  struct (16) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[System.__Canon]>
-;  V04 loc1         [V04,T05] (  2,  4   )     ref  ->  rdx         class-hnd <System.__Canon>
+;  V02 arg1         [V02,T03] (  4, 10   )     ref  ->  rbx         class-hnd single-def <System.Func`2[System.__Canon,ubyte]>
+;  V03 loc0         [V03    ] ( 11, 29   )  struct (16) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[System.__Canon]>
+;* V04 loc1         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.__Canon>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V07 tmp2         [V07    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V08 tmp3         [V08,T02] (  2, 32   )     int  ->  rcx         "impAppendStmt"
-;  V09 tmp4         [V09,T00] (  2, 32   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
-;  V10 tmp5         [V10,T01] (  2, 32   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
-;  V11 tmp6         [V11    ] (  3, 11   )     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V03._builder (fldOffset=0x0)" P-DEP
-;  V12 tmp7         [V12    ] (  5, 27   )     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V03._index (fldOffset=0x8)" P-DEP
+;  V08 tmp3         [V08,T01] (  4, 20   )     int  ->  rsi         "impAppendStmt"
+;  V09 tmp4         [V09,T00] (  4, 20   )     ref  ->  rdi         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]>
+;* V10 tmp5         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[System.__Canon]>
+;  V11 tmp6         [V11    ] (  4, 10   )     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V03._builder (fldOffset=0x0)" P-DEP
+;  V12 tmp7         [V12    ] (  8, 20   )     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V03._index (fldOffset=0x8)" P-DEP
+;  V13 tmp8         [V13,T02] (  2, 16   )     ref  ->  rdx         "argument with side effect"
 ;
 ; Lcl frame size = 48
 
 G_M43571_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     rdi
+       push     rsi
        push     rbx
        sub      rsp, 48
        xor      eax, eax
@@ -34,16 +37,26 @@ G_M43571_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        ; gcrRegs +[rcx]
        mov      rbx, r8
        ; gcrRegs +[rbx]
-						;; size=23 bbWeight=1 PerfScore 4.00
+						;; size=25 bbWeight=1 PerfScore 6.00
 G_M43571_IG02:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
        lea      rdx, [rsp+0x20]
        cmp      dword ptr [rcx], ecx
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[System.__Canon]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       jmp      SHORT G_M43571_IG04
-						;; size=15 bbWeight=1 PerfScore 8.50
-G_M43571_IG03:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, dword ptr [rsp+0x28]
+       inc      ecx
+       mov      dword ptr [rsp+0x28], ecx
+       mov      esi, dword ptr [rsp+0x28]
+       mov      rdi, gword ptr [rsp+0x20]
+       ; gcrRegs +[rdi]
+       mov      rcx, gword ptr [rdi+0x08]
+       ; gcrRegs +[rcx]
+       cmp      esi, dword ptr [rcx+0x10]
+       jge      SHORT G_M43571_IG04
+						;; size=41 bbWeight=1 PerfScore 16.75
+G_M43571_IG03:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx rdi]
        mov      rcx, gword ptr [rsp+0x20]
        ; gcrRegs +[rcx]
        mov      edx, dword ptr [rsp+0x28]
@@ -59,38 +72,41 @@ G_M43571_IG03:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
        test     eax, eax
-       je       SHORT G_M43571_IG07
-						;; size=31 bbWeight=2 PerfScore 29.00
-G_M43571_IG04:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      ecx, dword ptr [rsp+0x28]
-       inc      ecx
-       mov      dword ptr [rsp+0x28], ecx
-       mov      ecx, dword ptr [rsp+0x28]
-       mov      rdx, gword ptr [rsp+0x20]
-       ; gcrRegs +[rdx]
-       mov      rdx, gword ptr [rdx+0x08]
-       cmp      ecx, dword ptr [rdx+0x10]
+       je       SHORT G_M43571_IG06
+       mov      eax, dword ptr [rsp+0x28]
+       inc      eax
+       mov      dword ptr [rsp+0x28], eax
+       mov      esi, dword ptr [rsp+0x28]
+       mov      rdi, gword ptr [rsp+0x20]
+       ; gcrRegs +[rdi]
+       mov      rax, gword ptr [rdi+0x08]
+       ; gcrRegs +[rax]
+       cmp      esi, dword ptr [rax+0x10]
        jl       SHORT G_M43571_IG03
-						;; size=28 bbWeight=8 PerfScore 82.00
-G_M43571_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rdx rbx]
+						;; size=59 bbWeight=4 PerfScore 99.00
+G_M43571_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax rbx rdi]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M43571_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+G_M43571_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 48
        pop      rbx
+       pop      rsi
+       pop      rdi
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
-G_M43571_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=8 bbWeight=0.50 PerfScore 1.38
+G_M43571_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M43571_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+G_M43571_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 48
        pop      rbx
+       pop      rsi
+       pop      rdi
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 
-; Total bytes of code 116, prolog size 17, PerfScore 125.50, instruction count 36, allocated bytes for code 116 (MethodHash=795d55cc) for method Microsoft.CodeAnalysis.ArrayBuilderExtensions:All[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon],System.Func`2[System.__Canon,ubyte]):ubyte (FullOpts)
+; Total bytes of code 148, prolog size 19, PerfScore 124.75, instruction count 49, allocated bytes for code 148 (MethodHash=795d55cc) for method Microsoft.CodeAnalysis.ArrayBuilderExtensions:All[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon],System.Func`2[System.__Canon,ubyte]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -98,10 +114,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x07
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+31.82%</span>) : 10349.dasm - FSharp.Compiler.NameResolution+WithNewTypecheckResultsSink@2025:System.IDisposable.Dispose():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <FSharp.Compiler.NameResolution+WithNewTypecheckResultsSink@2025>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  [rsp+0x08]  this class-hnd single-def <FSharp.Compiler.NameResolution+WithNewTypecheckResultsSink@2025>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rdx         class-hnd exact single-def "Inlining Arg" <FSharp.Compiler.NameResolution+TcResultsSink>
-;  V03 tmp2         [V03,T02] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.NameResolution+ITypecheckResultsSink]>
+;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <FSharp.Compiler.NameResolution+TcResultsSink>
+;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.NameResolution+ITypecheckResultsSink]>
 ;
 ; Lcl frame size = 0
 
@@ -19,24 +19,26 @@ G_M10433_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M10433_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x08], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
-       mov      rax, gword ptr [rcx+0x10]
-       ; gcrRegs +[rax]
        lea      rcx, bword ptr [rdx+0x08]
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       mov      rdx, rax
+       mov      rdx, gword ptr [rsp+0x08]
+       mov      rdx, gword ptr [rdx+0x10]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_ASSIGN_REF
-       ; gcrRegs -[rax rdx]
+       ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        nop      
-						;; size=21 bbWeight=1 PerfScore 6.00
+						;; size=28 bbWeight=1 PerfScore 7.75
 G_M10433_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 7.00, instruction count 7, allocated bytes for code 22 (MethodHash=1528d73e) for method FSharp.Compiler.NameResolution+WithNewTypecheckResultsSink@2025:System.IDisposable.Dispose():this (FullOpts)
+; Total bytes of code 29, prolog size 0, PerfScore 8.75, instruction count 8, allocated bytes for code 29 (MethodHash=1528d73e) for method FSharp.Compiler.NameResolution+WithNewTypecheckResultsSink@2025:System.IDisposable.Dispose():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-46</span> (<span style="color:green">-64.79%</span>) : 24821.dasm - System.Buffers.IndexOfAnyAsciiSearcher+Default:PackSources(System.Runtime.Intrinsics.Vector256`1[ushort],System.Runtime.Intrinsics.Vector256`1[ushort]):System.Runtime.Intrinsics.Vector256`1[ubyte] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,8 +8,8 @@
 ; Final local variable assignments
 ;
 ;  V00 RetBuf       [V00,T02] (  4,  4   )   byref  ->  rbx         single-def
-;  V01 arg0         [V01,T00] (  4,  8   )   byref  ->  rdx         single-def
-;  V02 arg1         [V02,T01] (  4,  8   )   byref  ->   r8         single-def
+;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
+;  V02 arg1         [V02,T01] (  3,  6   )   byref  ->   r8         single-def
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )  struct (32) zero-ref    "impAppendStmt" <System.Runtime.Intrinsics.Vector256`1[short]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct (32) zero-ref    "spilled call-like call argument" <System.Runtime.Intrinsics.Vector256`1[short]>
@@ -23,52 +23,38 @@
 ;* V13 tmp10        [V13    ] (  0,  0   )  simd16  ->  zero-ref    "field V04._upper (fldOffset=0x10)" P-INDEP
 ;* V14 tmp11        [V14    ] (  0,  0   )  simd16  ->  zero-ref    "field V05._lower (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15    ] (  0,  0   )  simd16  ->  zero-ref    "field V05._upper (fldOffset=0x10)" P-INDEP
-;  V16 tmp13        [V16,T03] (  2,  2   )  simd16  ->  mm0         "field V06._lower (fldOffset=0x0)" P-INDEP
-;  V17 tmp14        [V17,T04] (  2,  2   )  simd16  ->  mm1         "field V06._upper (fldOffset=0x10)" P-INDEP
-;  V18 tmp15        [V18,T05] (  2,  2   )  simd16  ->  mm2         "field V07._lower (fldOffset=0x0)" P-INDEP
-;  V19 tmp16        [V19,T06] (  2,  2   )  simd16  ->  mm3         "field V07._upper (fldOffset=0x10)" P-INDEP
+;* V16 tmp13        [V16    ] (  0,  0   )  simd16  ->  zero-ref    "field V06._lower (fldOffset=0x0)" P-INDEP
+;* V17 tmp14        [V17    ] (  0,  0   )  simd16  ->  zero-ref    "field V06._upper (fldOffset=0x10)" P-INDEP
+;* V18 tmp15        [V18    ] (  0,  0   )  simd16  ->  zero-ref    "field V07._lower (fldOffset=0x0)" P-INDEP
+;* V19 tmp16        [V19    ] (  0,  0   )  simd16  ->  zero-ref    "field V07._upper (fldOffset=0x10)" P-INDEP
 ;* V20 tmp17        [V20    ] (  0,  0   )  struct (32) zero-ref    "Promoted implicit byref" <System.Runtime.Intrinsics.Vector256`1[ushort]>
 ;* V21 tmp18        [V21    ] (  0,  0   )  struct (32) zero-ref    "Promoted implicit byref" <System.Runtime.Intrinsics.Vector256`1[ushort]>
-;  V22 tmp19        [V22    ] (  3,  6   )  struct (32) [rsp+0x40]  do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Runtime.Intrinsics.Vector256`1[short]>
-;  V23 tmp20        [V23    ] (  3,  6   )  struct (32) [rsp+0x20]  do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Runtime.Intrinsics.Vector256`1[short]>
 ;
-; Lcl frame size = 96
+; Lcl frame size = 32
 
 G_M15236_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 96
+       sub      rsp, 32
        mov      rbx, rcx
        ; byrRegs +[rbx]
 						;; size=8 bbWeight=1 PerfScore 1.50
 G_M15236_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=010C {rdx rbx r8}, byref
        ; byrRegs +[rdx r8]
-       movups   xmm0, xmmword ptr [rdx]
-       movups   xmm1, xmmword ptr [rdx+0x10]
-       movups   xmm2, xmmword ptr [r8]
-       movups   xmm3, xmmword ptr [r8+0x10]
-       movups   xmmword ptr [rsp+0x40], xmm0
-       movups   xmmword ptr [rsp+0x50], xmm1
-       movups   xmmword ptr [rsp+0x20], xmm2
-       movups   xmmword ptr [rsp+0x30], xmm3
-       lea      rdx, [rsp+0x40]
-       ; byrRegs -[rdx]
-       lea      r8, [rsp+0x20]
-       ; byrRegs -[r8]
        mov      rcx, rbx
        ; byrRegs +[rcx]
        call     System.Runtime.Intrinsics.X86.Avx2:PackUnsignedSaturate(System.Runtime.Intrinsics.Vector256`1[short],System.Runtime.Intrinsics.Vector256`1[short]):System.Runtime.Intrinsics.Vector256`1[ubyte]
-       ; byrRegs -[rcx]
+       ; byrRegs -[rcx rdx r8]
        ; gcr arg pop 0
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=57 bbWeight=1 PerfScore 22.50
+						;; size=11 bbWeight=1 PerfScore 1.50
 G_M15236_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 96
+       add      rsp, 32
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 71, prolog size 5, PerfScore 25.75, instruction count 19, allocated bytes for code 71 (MethodHash=7973c47b) for method System.Buffers.IndexOfAnyAsciiSearcher+Default:PackSources(System.Runtime.Intrinsics.Vector256`1[ushort],System.Runtime.Intrinsics.Vector256`1[ushort]):System.Runtime.Intrinsics.Vector256`1[ubyte] (FullOpts)
+; Total bytes of code 25, prolog size 5, PerfScore 4.75, instruction count 9, allocated bytes for code 25 (MethodHash=7973c47b) for method System.Buffers.IndexOfAnyAsciiSearcher+Default:PackSources(System.Runtime.Intrinsics.Vector256`1[ushort],System.Runtime.Intrinsics.Vector256`1[ushort]):System.Runtime.Intrinsics.Vector256`1[ubyte] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -81,5 +67,5 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 11 * 8 + 8 = 96 = 0x60
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-58.54%</span>) : 23692.dasm - System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,41 +10,31 @@
 ;  V00 RetBuf       [V00,T00] (  4,  4   )   byref  ->  rcx         single-def
 ;  V01 arg0         [V01,T01] (  3,  3   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T02] (  2,  2   )  struct (64) [rsp+0x08]  do-not-enreg[S] "Inline return value spill temp" <System.Runtime.Intrinsics.Vector512`1[ubyte]>
-;* V04 tmp2         [V04    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inline stloc first use temp"
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] "Inline return value spill temp" <System.Runtime.Intrinsics.Vector512`1[ubyte]>
+;* V04 tmp2         [V04    ] (  0,  0   )   byref  ->  zero-ref    "Inline stloc first use temp"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 0
 
 G_M48179_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M48179_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
        movups   xmm0, xmmword ptr [rdx]
-       movups   xmmword ptr [rsp+0x08], xmm0
-       movups   xmm0, xmmword ptr [rdx+0x10]
-       movups   xmmword ptr [rsp+0x18], xmm0
-       movups   xmm0, xmmword ptr [rdx+0x20]
-       movups   xmmword ptr [rsp+0x28], xmm0
-       movups   xmm0, xmmword ptr [rdx+0x30]
-       movups   xmmword ptr [rsp+0x38], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x08]
        movups   xmmword ptr [rcx], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x18]
+       movups   xmm0, xmmword ptr [rdx+0x10]
        movups   xmmword ptr [rcx+0x10], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x28]
+       movups   xmm0, xmmword ptr [rdx+0x20]
        movups   xmmword ptr [rcx+0x20], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x38]
+       movups   xmm0, xmmword ptr [rdx+0x30]
        movups   xmmword ptr [rcx+0x30], xmm0
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=73 bbWeight=1 PerfScore 40.25
+						;; size=33 bbWeight=1 PerfScore 24.25
 G_M48179_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 72
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 82, prolog size 4, PerfScore 41.75, instruction count 20, allocated bytes for code 82 (MethodHash=72be43cc) for method System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 25.25, instruction count 10, allocated bytes for code 34 (MethodHash=72be43cc) for method System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -52,9 +42,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48

```


</div></details>

<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-58.54%</span>) : 26860.dasm - System.Runtime.Intrinsics.Vector512:AsByte[ulong](System.Runtime.Intrinsics.Vector512`1[ulong]):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,40 +10,30 @@
 ;  V00 RetBuf       [V00,T01] (  4,  4   )   byref  ->  rcx         single-def
 ;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T02] (  2,  4   )  struct (64) [rsp+0x08]  do-not-enreg[S] ld-addr-op "Inlining Arg" <System.Runtime.Intrinsics.Vector512`1[ulong]>
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inlining Arg" <System.Runtime.Intrinsics.Vector512`1[ulong]>
 ;
-; Lcl frame size = 72
+; Lcl frame size = 0
 
 G_M39598_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M39598_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
        movups   xmm0, xmmword ptr [rdx]
-       movups   xmmword ptr [rsp+0x08], xmm0
-       movups   xmm0, xmmword ptr [rdx+0x10]
-       movups   xmmword ptr [rsp+0x18], xmm0
-       movups   xmm0, xmmword ptr [rdx+0x20]
-       movups   xmmword ptr [rsp+0x28], xmm0
-       movups   xmm0, xmmword ptr [rdx+0x30]
-       movups   xmmword ptr [rsp+0x38], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x08]
        movups   xmmword ptr [rcx], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x18]
+       movups   xmm0, xmmword ptr [rdx+0x10]
        movups   xmmword ptr [rcx+0x10], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x28]
+       movups   xmm0, xmmword ptr [rdx+0x20]
        movups   xmmword ptr [rcx+0x20], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x38]
+       movups   xmm0, xmmword ptr [rdx+0x30]
        movups   xmmword ptr [rcx+0x30], xmm0
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=73 bbWeight=1 PerfScore 40.25
+						;; size=33 bbWeight=1 PerfScore 24.25
 G_M39598_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 72
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 82, prolog size 4, PerfScore 41.75, instruction count 20, allocated bytes for code 82 (MethodHash=213c6551) for method System.Runtime.Intrinsics.Vector512:AsByte[ulong](System.Runtime.Intrinsics.Vector512`1[ulong]):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 25.25, instruction count 10, allocated bytes for code 34 (MethodHash=213c6551) for method System.Runtime.Intrinsics.Vector512:AsByte[ulong](System.Runtime.Intrinsics.Vector512`1[ulong]):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -51,9 +41,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+87.76%</span>) : 5467.dasm - System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo:get_MetadataName():System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,44 +9,53 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo>
-;* V01 loc0         [V01    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op <Internal.Metadata.NativeFormat.Property>
+;  V01 loc0         [V01,T01] (  2,  2   )  struct (64) [rsp+0x38]  do-not-enreg[S] ld-addr-op <Internal.Metadata.NativeFormat.Property>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <Internal.Metadata.NativeFormat.ConstantStringValueHandle>
-;  V04 tmp2         [V04,T01] (  2,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Internal.Metadata.NativeFormat.MetadataReader>
+;* V04 tmp2         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Internal.Metadata.NativeFormat.MetadataReader>
 ;  V05 tmp3         [V05    ] (  2,  2   )  struct (24) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <Internal.Metadata.NativeFormat.ConstantStringValue>
-;  V06 tmp4         [V06,T02] (  2,  2   )     int  ->   r8         "field V03._value (fldOffset=0x0)" P-INDEP
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V03._value (fldOffset=0x0)" P-INDEP
 ;  V07 tmp5         [V07    ] (  1,  1   )     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V05._reader (fldOffset=0x0)" P-DEP
 ;  V08 tmp6         [V08    ] (  2,  2   )     ref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V05._value (fldOffset=0x8)" P-DEP
 ;  V09 tmp7         [V09    ] (  1,  1   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V05._handle (fldOffset=0x10)" P-DEP
-;* V10 tmp8         [V10    ] (  0,  0   )     int  ->  zero-ref    "V01.[016..020)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 120
 
 G_M965_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
+       sub      rsp, 120
        xorps    xmm4, xmm4
        movaps   xmmword ptr [rsp+0x20], xmm4
        xor      eax, eax
        mov      qword ptr [rsp+0x30], rax
 						;; size=19 bbWeight=1 PerfScore 3.83
-G_M965_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+G_M965_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
        ; gcrRegs +[rcx]
-       mov      r8d, dword ptr [rcx+0x78]
+       movups   xmm0, xmmword ptr [rcx+0x68]
+       movups   xmmword ptr [rsp+0x38], xmm0
+       movups   xmm0, xmmword ptr [rcx+0x78]
+       movups   xmmword ptr [rsp+0x48], xmm0
+       movups   xmm0, xmmword ptr [rcx+0x88]
+       movups   xmmword ptr [rsp+0x58], xmm0
+       movups   xmm0, xmmword ptr [rcx+0x98]
+       movups   xmmword ptr [rsp+0x68], xmm0
+						;; size=42 bbWeight=1 PerfScore 20.00
+G_M965_IG03:        ; bbWeight=1, extend
        mov      rcx, gword ptr [rcx+0x58]
        lea      rdx, [rsp+0x20]
+       mov      r8d, dword ptr [rsp+0x48]
        cmp      dword ptr [rcx], ecx
        call     Internal.Metadata.NativeFormat.MetadataReader:GetConstantStringValue(Internal.Metadata.NativeFormat.ConstantStringValueHandle):Internal.Metadata.NativeFormat.ConstantStringValue:this
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        mov      rax, gword ptr [rsp+0x28]
        ; gcrRegs +[rax]
-						;; size=25 bbWeight=1 PerfScore 9.50
-G_M965_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+						;; size=26 bbWeight=1 PerfScore 8.50
+G_M965_IG04:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 120
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 49, prolog size 19, PerfScore 14.58, instruction count 13, allocated bytes for code 49 (MethodHash=14d7fc3a) for method System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo:get_MetadataName():System.String:this (FullOpts)
+; Total bytes of code 92, prolog size 19, PerfScore 33.58, instruction count 21, allocated bytes for code 92 (MethodHash=14d7fc3a) for method System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo:get_MetadataName():System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -59,4 +68,4 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+87.76%</span>) : 5500.dasm - System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:get_Name():System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,43 +10,52 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V02 tmp1         [V02    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <Internal.Metadata.NativeFormat.Property>
+;  V02 tmp1         [V02,T01] (  2,  2   )  struct (64) [rsp+0x38]  do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <Internal.Metadata.NativeFormat.Property>
 ;* V03 tmp2         [V03    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <Internal.Metadata.NativeFormat.ConstantStringValueHandle>
-;  V04 tmp3         [V04,T01] (  2,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Internal.Metadata.NativeFormat.MetadataReader>
+;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Internal.Metadata.NativeFormat.MetadataReader>
 ;  V05 tmp4         [V05    ] (  2,  2   )  struct (24) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <Internal.Metadata.NativeFormat.ConstantStringValue>
-;  V06 tmp5         [V06,T02] (  2,  2   )     int  ->   r8         "field V03._value (fldOffset=0x0)" P-INDEP
+;* V06 tmp5         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V03._value (fldOffset=0x0)" P-INDEP
 ;  V07 tmp6         [V07    ] (  1,  1   )     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V05._reader (fldOffset=0x0)" P-DEP
 ;  V08 tmp7         [V08    ] (  2,  2   )     ref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V05._value (fldOffset=0x8)" P-DEP
 ;  V09 tmp8         [V09    ] (  1,  1   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V05._handle (fldOffset=0x10)" P-DEP
-;* V10 tmp9         [V10    ] (  0,  0   )     int  ->  zero-ref    "V02.[016..020)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 120
 
 G_M12390_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
+       sub      rsp, 120
        xorps    xmm4, xmm4
        movaps   xmmword ptr [rsp+0x20], xmm4
        xor      eax, eax
        mov      qword ptr [rsp+0x30], rax
 						;; size=19 bbWeight=1 PerfScore 3.83
-G_M12390_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+G_M12390_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
        ; gcrRegs +[rcx]
-       mov      r8d, dword ptr [rcx+0x78]
+       movups   xmm0, xmmword ptr [rcx+0x68]
+       movups   xmmword ptr [rsp+0x38], xmm0
+       movups   xmm0, xmmword ptr [rcx+0x78]
+       movups   xmmword ptr [rsp+0x48], xmm0
+       movups   xmm0, xmmword ptr [rcx+0x88]
+       movups   xmmword ptr [rsp+0x58], xmm0
+       movups   xmm0, xmmword ptr [rcx+0x98]
+       movups   xmmword ptr [rsp+0x68], xmm0
+						;; size=42 bbWeight=1 PerfScore 20.00
+G_M12390_IG03:        ; bbWeight=1, extend
        mov      rcx, gword ptr [rcx+0x58]
        lea      rdx, [rsp+0x20]
+       mov      r8d, dword ptr [rsp+0x48]
        cmp      dword ptr [rcx], ecx
        call     Internal.Metadata.NativeFormat.MetadataReader:GetConstantStringValue(Internal.Metadata.NativeFormat.ConstantStringValueHandle):Internal.Metadata.NativeFormat.ConstantStringValue:this
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        mov      rax, gword ptr [rsp+0x28]
        ; gcrRegs +[rax]
-						;; size=25 bbWeight=1 PerfScore 9.50
-G_M12390_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+						;; size=26 bbWeight=1 PerfScore 8.50
+G_M12390_IG04:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 120
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 49, prolog size 19, PerfScore 14.58, instruction count 13, allocated bytes for code 49 (MethodHash=efa7cf99) for method System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:get_Name():System.String:this (FullOpts)
+; Total bytes of code 92, prolog size 19, PerfScore 33.58, instruction count 21, allocated bytes for code 92 (MethodHash=efa7cf99) for method System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:get_Name():System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -59,4 +68,4 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+126.09%</span>) : 31119.dasm - System.ReadOnlySpan`1[System.__Canon]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,38 +7,46 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;* V02 TypeCtx      [V02    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V04 loc1         [V04    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1+Enumerator[System.__Canon]>
+;  V04 loc1         [V04,T02] (  2,  4   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1+Enumerator[System.__Canon]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[System.__Canon]>
-;  V06 tmp3         [V06,T02] (  2,  2   )   byref  ->  rax         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V07 tmp4         [V07,T03] (  2,  2   )     int  ->  rcx         "field V05._length (fldOffset=0x8)" P-INDEP
-;* V08 tmp5         [V08    ] (  0,  0   )   byref  ->  zero-ref    single-def "V04.[000..008)"
-;* V09 tmp6         [V09    ] (  0,  0   )     int  ->  zero-ref    "V04.[008..012)"
-;* V10 tmp7         [V10    ] (  0,  0   )     int  ->  zero-ref    "V04.[016..020)"
+;* V06 tmp3         [V06    ] (  0,  0   )   byref  ->  zero-ref    "field V05._reference (fldOffset=0x0)" P-INDEP
+;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;* V08 tmp5         [V08    ] (  0,  0   )     int  ->  zero-ref    "V04.[016..020)"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M60474_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
-G_M60474_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
+       sub      rsp, 24
+       xorps    xmm4, xmm4
+       movaps   xmmword ptr [rsp], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x10], rax
+						;; size=18 bbWeight=1 PerfScore 3.83
+G_M60474_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, nogc
        ; byrRegs +[rcx rdx]
-       mov      rax, bword ptr [rcx]
-       ; byrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       mov      bword ptr [rdx], rax
-       mov      dword ptr [rdx+0x08], ecx
+       movups   xmm0, xmmword ptr [rcx]
+       movups   xmmword ptr [rsp], xmm0
+						;; size=7 bbWeight=1 PerfScore 5.00
+G_M60474_IG03:        ; bbWeight=1, nogc, extend
+       movups   xmmword ptr [rdx], xmm0
+       mov      rax, qword ptr [rsp+0x10]
+       mov      qword ptr [rdx+0x10], rax
+						;; size=12 bbWeight=1 PerfScore 4.00
+G_M60474_IG04:        ; bbWeight=1, extend
        mov      dword ptr [rdx+0x10], -1
        mov      rax, rdx
-						;; size=22 bbWeight=1 PerfScore 7.25
-G_M60474_IG03:        ; bbWeight=1, epilog, nogc, extend
+       ; byrRegs +[rax]
+						;; size=10 bbWeight=1 PerfScore 1.25
+G_M60474_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 23, prolog size 0, PerfScore 8.25, instruction count 7, allocated bytes for code 23 (MethodHash=a10713c5) for method System.ReadOnlySpan`1[System.__Canon]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.__Canon]:this (FullOpts)
+; Total bytes of code 52, prolog size 18, PerfScore 15.33, instruction count 14, allocated bytes for code 52 (MethodHash=a10713c5) for method System.ReadOnlySpan`1[System.__Canon]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -46,8 +54,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 2 * 8 + 8 = 24 = 0x18

```


</div></details>


</div></details>


</div></details>

<details>
<summary>Details</summary>
<div style="margin-left:1em">

#### Improvements/regressions per collection

|Collection|Contexts with diffs|Improvements|Regressions|Same size|Improvements (bytes)|Regressions (bytes)|PerfScore Overall (FullOpts)|
|---|--:|--:|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,100|<span style="color:green">5,087</span>|<span style="color:red">599</span>|<span style="color:blue">5,414</span>|<span style="color:green">-54,137</span>|<span style="color:red">+6,741</span>|<span style="color:green">-0.2123%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|18,053|<span style="color:green">10,661</span>|<span style="color:red">2,022</span>|<span style="color:blue">5,370</span>|<span style="color:green">-145,591</span>|<span style="color:red">+18,421</span>|<span style="color:green">-0.5940%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,030|<span style="color:green">1,638</span>|<span style="color:red">169</span>|<span style="color:blue">1,223</span>|<span style="color:green">-13,713</span>|<span style="color:red">+1,261</span>|<span style="color:green">-0.0967%</span>|
|coreclr_tests.run.windows.x64.checked.mch|107,038|<span style="color:green">51,926</span>|<span style="color:red">3,313</span>|<span style="color:blue">51,799</span>|<span style="color:green">-495,030</span>|<span style="color:red">+67,229</span>|<span style="color:green">-0.2261%</span>|
|libraries.crossgen2.windows.x64.checked.mch|50,892|<span style="color:green">12,504</span>|<span style="color:red">2,623</span>|<span style="color:blue">35,765</span>|<span style="color:green">-130,415</span>|<span style="color:red">+20,694</span>|<span style="color:green">-0.1099%</span>|
|libraries.pmi.windows.x64.checked.mch|66,010|<span style="color:green">25,629</span>|<span style="color:red">4,035</span>|<span style="color:blue">36,346</span>|<span style="color:green">-254,176</span>|<span style="color:red">+38,069</span>|<span style="color:green">-0.1238%</span>|
|libraries_tests.run.windows.x64.Release.mch|83,274|<span style="color:green">39,805</span>|<span style="color:red">12,521</span>|<span style="color:blue">30,948</span>|<span style="color:green">-529,634</span>|<span style="color:red">+146,979</span>|<span style="color:red">+0.0278%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|110,532|<span style="color:green">43,724</span>|<span style="color:red">12,247</span>|<span style="color:blue">54,561</span>|<span style="color:green">-591,976</span>|<span style="color:red">+157,415</span>|<span style="color:green">-0.1297%</span>|
|realworld.run.windows.x64.checked.mch|12,068|<span style="color:green">5,204</span>|<span style="color:red">870</span>|<span style="color:blue">5,994</span>|<span style="color:green">-72,447</span>|<span style="color:red">+10,076</span>|<span style="color:green">-0.1073%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|7,081|<span style="color:green">3,147</span>|<span style="color:red">535</span>|<span style="color:blue">3,399</span>|<span style="color:green">-22,091</span>|<span style="color:red">+7,304</span>|<span style="color:green">-0.0280%</span>|
||469,078|<span style="color:green">199,325</span>|<span style="color:red">38,934</span>|<span style="color:blue">230,819</span>|<span style="color:green">-2,309,210</span>|<span style="color:red">+474,189</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,777|4|35,773|318 (0.88%)|188 (0.52%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,800|49,607|52,193|59 (0.06%)|33 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|54,992|37,307|17,685|49 (0.09%)|36 (0.07%)|
|coreclr_tests.run.windows.x64.checked.mch|581,339|347,882|233,457|2,748 (0.47%)|2,567 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,507|15|275,492|263 (0.10%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|312,673|6|312,667|1,614 (0.51%)|1,206 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|696,881|498,513|198,368|3,276 (0.47%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|319,785|21,946|297,839|1,109 (0.35%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,622|3|36,619|280 (0.76%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,491|11|32,480|87 (0.27%)|41 (0.13%)|
||2,447,867|955,294|1,492,573|9,803 (0.40%)|7,147 (0.29%)|


---

#### jit-analyze output

<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 11335474 (overridden on cmd)
Total bytes of diff: 11288078 (overridden on cmd)
Total bytes of delta: -47396 (-0.42 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         253 : 31576.dasm (13.45% of base)
         200 : 26344.dasm (8.65% of base)
         155 : 7718.dasm (9.20% of base)
         155 : 17810.dasm (9.20% of base)
         144 : 15771.dasm (2.92% of base)
         144 : 7349.dasm (2.92% of base)
         139 : 27451.dasm (3.96% of base)
         108 : 12353.dasm (11.48% of base)
          84 : 18258.dasm (2.06% of base)
          84 : 3508.dasm (2.06% of base)
          68 : 31592.dasm (0.78% of base)
          68 : 18605.dasm (0.78% of base)
          68 : 3869.dasm (0.78% of base)
          67 : 25671.dasm (1.44% of base)
          62 : 30410.dasm (1.29% of base)
          61 : 26014.dasm (2.03% of base)
          57 : 27948.dasm (4.66% of base)
          53 : 17600.dasm (0.87% of base)
          53 : 29569.dasm (3.73% of base)
          53 : 3567.dasm (7.23% of base)

Top file improvements (bytes):
        -480 : 19649.dasm (-13.19% of base)
        -331 : 19650.dasm (-4.33% of base)
        -301 : 9460.dasm (-7.18% of base)
        -300 : 19798.dasm (-25.40% of base)
        -278 : 17441.dasm (-7.06% of base)
        -278 : 6834.dasm (-7.06% of base)
        -274 : 17706.dasm (-7.75% of base)
        -274 : 21539.dasm (-7.73% of base)
        -254 : 20969.dasm (-9.75% of base)
        -245 : 32116.dasm (-22.05% of base)
        -244 : 19651.dasm (-16.26% of base)
        -225 : 24425.dasm (-20.42% of base)
        -225 : 11854.dasm (-20.42% of base)
        -218 : 35413.dasm (-7.68% of base)
        -213 : 15953.dasm (-7.53% of base)
        -205 : 7950.dasm (-3.65% of base)
        -197 : 29032.dasm (-1.57% of base)
        -180 : 5399.dasm (-15.08% of base)
        -158 : 20965.dasm (-8.13% of base)
        -156 : 24402.dasm (-5.55% of base)

80 total files with Code Size differences (41 improved, 39 regressed), 20 unchanged.

Top method regressions (bytes):
         253 (13.45% of base) : 31576.dasm - System.Threading.Tests.Perf_CancellationToken:CreateManyRegisterMultipleDispose():this (FullOpts)
         200 ( 8.65% of base) : 26344.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MakeAcyclicInterfaces(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol]:this (FullOpts)
         155 ( 9.20% of base) : 7718.dasm - ProtoBuf.Internal.Serializers.DefaultValueDecorator:EmitBranchIfDefaultValue(ProtoBuf.Compiler.CompilerContext,ProtoBuf.Compiler.CodeLabel):this (FullOpts)
         155 ( 9.20% of base) : 17810.dasm - ProtoBuf.Internal.Serializers.DefaultValueDecorator:EmitBranchIfDefaultValue(ProtoBuf.Compiler.CompilerContext,ProtoBuf.Compiler.CodeLabel):this (FullOpts)
         144 ( 2.92% of base) : 15771.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:.cctor() (FullOpts)
         144 ( 2.92% of base) : 7349.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:.cctor() (FullOpts)
         139 ( 3.96% of base) : 27451.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager:AssignTemplatesNamesAndCompile(Microsoft.CodeAnalysis.CSharp.MethodCompiler,Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (FullOpts)
         108 (11.48% of base) : 12353.dasm - EMFloat:AddSubInternalFPF(ubyte,byref,byref,byref) (FullOpts)
          84 ( 2.06% of base) : 18258.dasm - Sigil.Emit`1[System.__Canon]:ValidateTryCatchFinallyBranches():this (FullOpts)
          84 ( 2.06% of base) : 3508.dasm - Sigil.Emit`1[System.__Canon]:ValidateTryCatchFinallyBranches():this (FullOpts)
          68 ( 0.78% of base) : 18605.dasm - Jil.Deserialize.Methods:ParseISO8601Date(System.IO.TextReader,ushort[],int,int):System.DateTime (FullOpts)
          68 ( 0.78% of base) : 3869.dasm - Jil.Deserialize.Methods:ParseISO8601Date(System.IO.TextReader,ushort[],int,int):System.DateTime (FullOpts)
          68 ( 0.78% of base) : 31592.dasm - Jil.Deserialize.Methods:ParseISO8601DateThunkReader(byref,ushort[],int,int):System.DateTime (FullOpts)
          67 ( 1.44% of base) : 25671.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (FullOpts)
          62 ( 1.29% of base) : 30410.dasm - System.Diagnostics.Process:StartWithCreateProcess(System.Diagnostics.ProcessStartInfo):ubyte:this (FullOpts)
          61 ( 2.03% of base) : 26014.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol:LoadMembers():this (FullOpts)
          57 ( 4.66% of base) : 27948.dasm - Microsoft.Cci.MetadataWriter:PopulateGenericParameters(System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.IGenericParameter]):this (FullOpts)
          53 ( 0.87% of base) : 17600.dasm - ProtoBuf.Meta.MetaType:ApplyDefaultBehaviourImpl(int):this (FullOpts)
          53 ( 3.73% of base) : 29569.dasm - System.Diagnostics.NtProcessInfoHelper:GetProcessInfos(System.ReadOnlySpan`1[ubyte],System.Nullable`1[int],System.String):System.Diagnostics.ProcessInfo[] (FullOpts)
          53 ( 7.23% of base) : 3567.dasm - System.Linq.Enumerable:MinMaxInteger[int,System.Linq.Enumerable+MinCalc`1[int]](System.Collections.Generic.IEnumerable`1[int]):int (FullOpts)

Top method improvements (bytes):
        -480 (-13.19% of base) : 19649.dasm - System.Numerics.Tensors.TensorPrimitives:InvokeSpanSpanIntoSpan[int,System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[int]](System.ReadOnlySpan`1[int],System.ReadOnlySpan`1[int],System.Span`1[int]) (FullOpts)
        -331 (-4.33% of base) : 19650.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanSpanIntoSpan>g__Vectorized512|232_3[int,System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[int]](byref,byref,byref,ulong) (FullOpts)
        -301 (-7.18% of base) : 9460.dasm - Newtonsoft.Json.JsonWriter:WriteValue(Newtonsoft.Json.JsonWriter,int,System.Object) (FullOpts)
        -300 (-25.40% of base) : 19798.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarSpanIntoSpan>g__Vectorized512|238_3[float,System.Numerics.Tensors.TensorPrimitives+AddMultiplyOperator`1[float]](byref,float,byref,byref,ulong) (FullOpts)
        -278 (-7.06% of base) : 17441.dasm - System.Text.Json.JsonDocument:TryParseValue(byref,byref,ubyte,ubyte):ubyte (FullOpts)
        -278 (-7.06% of base) : 6834.dasm - System.Text.Json.JsonDocument:TryParseValue(byref,byref,ubyte,ubyte):ubyte (FullOpts)
        -274 (-7.75% of base) : 17706.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (FullOpts)
        -274 (-7.73% of base) : 21539.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (FullOpts)
        -254 (-9.75% of base) : 20969.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:MyEventsListerItemTaskSerializeHandler(System.Text.Json.Utf8JsonWriter,MicroBenchmarks.Serializers.MyEventsListerItemTask):this (FullOpts)
        -245 (-22.05% of base) : 32116.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarSpanIntoSpan>g__Vectorized256|238_2[int,System.Numerics.Tensors.TensorPrimitives+AddMultiplyOperator`1[int]](byref,int,byref,byref,ulong) (FullOpts)
        -244 (-16.26% of base) : 19651.dasm - System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[int]:Invoke(System.Runtime.Intrinsics.Vector512`1[int],System.Runtime.Intrinsics.Vector512`1[int]):System.Runtime.Intrinsics.Vector512`1[int] (FullOpts)
        -225 (-20.42% of base) : 24425.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarSpanIntoSpan>g__Vectorized256|238_2[double,System.Numerics.Tensors.TensorPrimitives+AddMultiplyOperator`1[double]](byref,double,byref,byref,ulong) (FullOpts)
        -225 (-20.42% of base) : 11854.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarSpanIntoSpan>g__Vectorized256|238_2[float,System.Numerics.Tensors.TensorPrimitives+AddMultiplyOperator`1[float]](byref,float,byref,byref,ulong) (FullOpts)
        -218 (-7.68% of base) : 35413.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:CollectionsOfPrimitivesSerializeHandler(System.Text.Json.Utf8JsonWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives):this (FullOpts)
        -213 (-7.53% of base) : 15953.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:CollectionsOfPrimitivesSerializeHandler(System.Text.Json.Utf8JsonWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives):this (FullOpts)
        -205 (-3.65% of base) : 7950.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (FullOpts)
        -197 (-1.57% of base) : 29032.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte,ubyte) (FullOpts)
        -180 (-15.08% of base) : 5399.dasm - System.IO.Hashing.Crc64:UpdateVectorized(ulong,System.ReadOnlySpan`1[ubyte]):ulong (FullOpts)
        -158 (-8.13% of base) : 20965.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:MyEventsListerViewModelSerializeHandler(System.Text.Json.Utf8JsonWriter,MicroBenchmarks.Serializers.MyEventsListerViewModel):this (FullOpts)
        -156 (-5.55% of base) : 24402.dasm - System.Enum:GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType):System.Array (FullOpts)

Top method regressions (percentages):
          42 (53.16% of base) : 35453.dasm - System.Numerics.Tests.Perf_Matrix4x4:TranslationBenchmark():System.Numerics.Vector3:this (FullOpts)
           7 (38.89% of base) : 22011.dasm - Microsoft.Extensions.Configuration.JsonConfigurationExtensions+<>c__DisplayClass5_0:<AddJsonStream>b__0(Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource):this (FullOpts)
           4 (23.53% of base) : 34987.dasm - System.Collections.ContainsTrueComparer`1+WrapDefaultComparer[int]:Compare(int,int):int:this (FullOpts)
          24 (23.53% of base) : 9044.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:<ConvertToSymbolicRegexNode>g__EnsureNewlinePredicateInitialized|4_0():this (FullOpts)
          32 (20.78% of base) : 11789.dasm - System.MathF:ILogB(float):int (FullOpts)
          20 (20.41% of base) : 15740.dasm - System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (FullOpts)
          23 (17.56% of base) : 2656.dasm - Newtonsoft.Json.Linq.JObject:WriteTo(Newtonsoft.Json.JsonWriter,Newtonsoft.Json.JsonConverter[]):this (FullOpts)
          23 (17.56% of base) : 20407.dasm - Newtonsoft.Json.Linq.JObject:WriteTo(Newtonsoft.Json.JsonWriter,Newtonsoft.Json.JsonConverter[]):this (FullOpts)
          35 (16.91% of base) : 29611.dasm - System.Math:ILogB(double):int (FullOpts)
         253 (13.45% of base) : 31576.dasm - System.Threading.Tests.Perf_CancellationToken:CreateManyRegisterMultipleDispose():this (FullOpts)
           5 (12.82% of base) : 25217.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache:GetCacheHash(int,ubyte,Microsoft.CodeAnalysis.GreenNode):int (FullOpts)
          11 (12.79% of base) : 9869.dasm - System.Xml.XmlTextReaderImpl:ElementNamespaceLookup():this (FullOpts)
           2 (12.50% of base) : 9024.dasm - System.Threading.Tests.Perf_Interlocked:Decrement_int():int:this (FullOpts)
           2 (12.50% of base) : 2837.dasm - System.Threading.Tests.Perf_Interlocked:Increment_int():int:this (FullOpts)
           8 (11.94% of base) : 26348.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol:GetDeclaredInterfaces(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol]:this (FullOpts)
           8 (11.94% of base) : 26346.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol:InterfacesNoUseSiteDiagnostics(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol]:this (FullOpts)
          51 (11.81% of base) : 7049.dasm - System.Threading.ThreadLocal`1+FinalizationHelper[System.__Canon]:Finalize():this (FullOpts)
           2 (11.76% of base) : 32509.dasm - System.Threading.Tests.Perf_Interlocked:Add_int():int:this (FullOpts)
           9 (11.69% of base) : 27391.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:GetRefKindsOrNull(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte]):System.Collections.Immutable.ImmutableArray`1[ubyte] (FullOpts)
          10 (11.63% of base) : 21152.dasm - System.Tests.Perf_Int128:CopySign(System.Int128,System.Int128):System.Int128:this (FullOpts)

Top method improvements (percentages):
         -32 (-50.00% of base) : 10047.dasm - System.Memory.ReadOnlySequence:Slice_Start():System.Buffers.ReadOnlySequence`1[ubyte]:this (FullOpts)
         -11 (-50.00% of base) : 7510.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
         -11 (-50.00% of base) : 17541.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
         -11 (-50.00% of base) : 17542.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)
         -11 (-50.00% of base) : 7511.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)
         -11 (-50.00% of base) : 5726.dasm - Utf8Json.Resolvers.Internal.DynamicObjectTypeBuilder+<>c:<BuildType>b__6_0(Utf8Json.Internal.Emit.MetaMember):ubyte:this (FullOpts)
         -29 (-48.33% of base) : 10224.dasm - System.Threading.Tasks.ValueTask`1[System.__Canon]:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter`1[System.__Canon]:this (FullOpts)
         -29 (-48.33% of base) : 16279.dasm - System.Threading.Tasks.ValueTask`1[System.__Canon]:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter`1[System.__Canon]:this (FullOpts)
         -35 (-47.95% of base) : 20114.dasm - System.Text.Json.Serialization.Converters.NullableConverter`1[System.DateTimeOffset]:Write(System.Text.Json.Utf8JsonWriter,System.Nullable`1[System.DateTimeOffset],System.Text.Json.JsonSerializerOptions):this (FullOpts)
         -35 (-47.95% of base) : 6977.dasm - System.Text.Json.Serialization.Converters.NullableConverter`1[System.DateTimeOffset]:Write(System.Text.Json.Utf8JsonWriter,System.Nullable`1[System.DateTimeOffset],System.Text.Json.JsonSerializerOptions):this (FullOpts)
         -34 (-47.89% of base) : 24820.dasm - Newtonsoft.Json.JsonWriter:WriteValue(System.Nullable`1[System.DateTimeOffset]):this (FullOpts)
         -26 (-47.27% of base) : 15792.dasm - System.Text.Encodings.Web.DefaultJavaScriptEncoder+EscaperImplementation:.ctor(ubyte):this (FullOpts)
         -26 (-47.27% of base) : 1757.dasm - System.Text.Encodings.Web.DefaultJavaScriptEncoder+EscaperImplementation:.ctor(ubyte):this (FullOpts)
         -38 (-37.25% of base) : 30288.dasm - Microsoft.Extensions.Configuration.Xml.XmlStreamConfigurationProvider:<ProvideConfiguration>g__ProcessElementContent|7_2(Microsoft.Extensions.Configuration.Xml.Prefix,Microsoft.Extensions.Configuration.Xml.XmlConfigurationElement,byref) (FullOpts)
          -4 (-36.36% of base) : 21673.dasm - Newtonsoft.Json.JsonSerializer:get_Formatting():int:this (FullOpts)
          -4 (-36.36% of base) : 35054.dasm - System.Tests.Perf_Enum:Compare():int:this (FullOpts)
          -4 (-33.33% of base) : 27941.dasm - Microsoft.Cci.FullMetadataWriter:GetEventDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IEventDefinition]:this (FullOpts)
          -4 (-33.33% of base) : 27874.dasm - Microsoft.Cci.FullMetadataWriter:GetMethodDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IMethodDefinition]:this (FullOpts)
          -4 (-33.33% of base) : 9475.dasm - Newtonsoft.Json.JsonSerializer:get_CheckAdditionalContent():ubyte:this (FullOpts)
          -3 (-33.33% of base) : 20615.dasm - System.Collections.ReferenceType:GetHashCode():int:this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 35552826 (overridden on cmd)
Total bytes of diff: 35425656 (overridden on cmd)
Total bytes of delta: -127170 (-0.36 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         183 : 67749.dasm (7.03% of base)
         169 : 69144.dasm (10.30% of base)
         140 : 68264.dasm (7.79% of base)
         139 : 68118.dasm (2.62% of base)
         117 : 72195.dasm (2.23% of base)
         105 : 95259.dasm (6.80% of base)
         105 : 97824.dasm (6.80% of base)
          88 : 35432.dasm (5.46% of base)
          80 : 90480.dasm (1.76% of base)
          74 : 16569.dasm (1.64% of base)
          69 : 97544.dasm (4.12% of base)
          69 : 27280.dasm (4.05% of base)
          67 : 92229.dasm (1.78% of base)
          63 : 50403.dasm (1.24% of base)
          63 : 74444.dasm (1.25% of base)
          57 : 68069.dasm (3.08% of base)
          55 : 58980.dasm (1.24% of base)
          55 : 45229.dasm (1.67% of base)
          54 : 43582.dasm (2.50% of base)
          54 : 88218.dasm (2.50% of base)

Top file improvements (bytes):
        -354 : 50902.dasm (-8.53% of base)
        -350 : 27828.dasm (-8.40% of base)
        -272 : 36821.dasm (-7.57% of base)
        -193 : 97558.dasm (-3.11% of base)
        -190 : 87477.dasm (-2.35% of base)
        -188 : 95376.dasm (-6.51% of base)
        -185 : 87778.dasm (-5.93% of base)
        -185 : 82963.dasm (-5.90% of base)
        -180 : 97935.dasm (-6.29% of base)
        -175 : 33075.dasm (-3.85% of base)
        -164 : 68113.dasm (-1.76% of base)
        -161 : 97563.dasm (-5.08% of base)
        -161 : 97848.dasm (-2.08% of base)
        -153 : 75905.dasm (-4.39% of base)
        -151 : 86990.dasm (-2.44% of base)
        -148 : 95377.dasm (-6.04% of base)
        -148 : 97936.dasm (-6.07% of base)
        -140 : 75903.dasm (-4.05% of base)
        -135 : 87779.dasm (-5.44% of base)
        -135 : 82964.dasm (-5.44% of base)

78 total files with Code Size differences (42 improved, 36 regressed), 20 unchanged.

Top method regressions (bytes):
         183 ( 7.03% of base) : 67749.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:DoVisitList[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon]:this (Tier1)
         169 (10.30% of base) : 69144.dasm - Microsoft.Cci.MetadataWriter:SerializeCustomAttributeNamedArguments(byref,System.Reflection.Metadata.Ecma335.NamedArgumentsEncoder,Microsoft.Cci.ICustomAttribute):this (Tier1)
         140 ( 7.79% of base) : 68264.dasm - Microsoft.CodeAnalysis.CSharp.BoundConversion:Update(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Conversion,ubyte,ubyte,ubyte,Microsoft.CodeAnalysis.ConstantValue,Microsoft.CodeAnalysis.CSharp.ConversionGroup,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):Microsoft.CodeAnalysis.CSharp.BoundConversion:this (Tier1)
         139 ( 2.62% of base) : 68118.dasm - Microsoft.CodeAnalysis.CSharp.MethodCompiler:BindMethodBody(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.TypeCompilationState,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Microsoft.CodeAnalysis.CSharp.BoundNode,ubyte,byref,byref,byref,byref):Microsoft.CodeAnalysis.CSharp.BoundBlock (Tier1)
         117 ( 2.23% of base) : 72195.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseLocalDeclarationStatement(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax]):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax:this (Tier1)
         105 ( 6.80% of base) : 95259.dasm - System.Text.RegularExpressions.Symbolic.MintermClassifier:.ctor(System.Text.RegularExpressions.Symbolic.BDD[],System.Text.RegularExpressions.Symbolic.CharSetSolver):this (Tier1)
         105 ( 6.80% of base) : 97824.dasm - System.Text.RegularExpressions.Symbolic.MintermClassifier:.ctor(System.Text.RegularExpressions.Symbolic.BDD[],System.Text.RegularExpressions.Symbolic.CharSetSolver):this (Tier1)
          88 ( 5.46% of base) : 35432.dasm - EMFloat:AddSubInternalFPF(ubyte,byref,byref,byref) (Tier1)
          80 ( 1.76% of base) : 90480.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          74 ( 1.64% of base) : 16569.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          69 ( 4.12% of base) : 97544.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong]:CreateLoop(System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],ubyte,int,int):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
          69 ( 4.05% of base) : 27280.dasm - System.Threading.ThreadPoolWorkQueue:Dispatch():ubyte (Tier1-OSR)
          67 ( 1.78% of base) : 92229.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength4To7,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1)
          63 ( 1.24% of base) : 50403.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
          63 ( 1.25% of base) : 74444.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          57 ( 3.08% of base) : 68069.dasm - System.Threading.Tasks.Parallel:ForWorker[System.__Canon,int](int,int,System.Threading.Tasks.ParallelOptions,System.Action`1[int],System.Action`2[int,System.Threading.Tasks.ParallelLoopState],System.Func`4[int,System.__Canon,System.__Canon,System.__Canon],System.Func`1[System.__Canon],System.Action`1[System.__Canon]):System.Threading.Tasks.ParallelLoopResult (Tier1)
          55 ( 1.24% of base) : 58980.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          55 ( 1.67% of base) : 45229.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          54 ( 2.50% of base) : 43582.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength4To7,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1-OSR)
          54 ( 2.50% of base) : 88218.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength4To7,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1-OSR)

Top method improvements (bytes):
        -354 (-8.53% of base) : 50902.dasm - System.Buffers.Text.Base64:Avx2Encode(byref,byref,ulong,int,int,ulong,ulong) (Tier1-OSR)
        -350 (-8.40% of base) : 27828.dasm - System.Buffers.Text.Base64:Avx2Encode(byref,byref,ulong,int,int,ulong,ulong) (Tier1-OSR)
        -272 (-7.57% of base) : 36821.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (Tier0-FullOpts)
        -193 (-3.11% of base) : 97558.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1)
        -190 (-2.35% of base) : 87477.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -188 (-6.51% of base) : 95376.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]:Scan(System.ReadOnlySpan`1[ushort]):this (Tier1)
        -185 (-5.93% of base) : 87778.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]:Scan(System.ReadOnlySpan`1[ushort]):this (Tier1)
        -185 (-5.90% of base) : 82963.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]:Scan(System.ReadOnlySpan`1[ushort]):this (Tier1)
        -180 (-6.29% of base) : 97935.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]:Scan(System.ReadOnlySpan`1[ushort]):this (Tier1)
        -175 (-3.85% of base) : 33075.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:CreateAlternate(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],ubyte,ubyte):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong] (Tier1)
        -164 (-1.76% of base) : 68113.dasm - Microsoft.CodeAnalysis.CSharp.MethodCompiler:CompileMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,int,byref,Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.CSharp.TypeCompilationState):this (Tier1)
        -161 (-2.08% of base) : 97848.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:.ctor(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],int,System.Text.RegularExpressions.RegexFindOptimizations,System.TimeSpan):this (Tier1)
        -161 (-5.08% of base) : 97563.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]:Scan(System.ReadOnlySpan`1[ushort]):this (Tier1)
        -153 (-4.39% of base) : 75905.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -151 (-2.44% of base) : 86990.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1)
        -148 (-6.04% of base) : 95377.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindMatch(int,System.ReadOnlySpan`1[ushort],int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):System.Text.RegularExpressions.Symbolic.SymbolicMatch:this (Tier1)
        -148 (-6.07% of base) : 97936.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindMatch(int,System.ReadOnlySpan`1[ushort],int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):System.Text.RegularExpressions.Symbolic.SymbolicMatch:this (Tier1)
        -140 (-4.05% of base) : 75903.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -135 (-5.44% of base) : 87779.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindMatch(int,System.ReadOnlySpan`1[ushort],int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):System.Text.RegularExpressions.Symbolic.SymbolicMatch:this (Tier1)
        -135 (-5.44% of base) : 82964.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindMatch(int,System.ReadOnlySpan`1[ushort],int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):System.Text.RegularExpressions.Symbolic.SymbolicMatch:this (Tier1)

Top method regressions (percentages):
          17 (21.79% of base) : 71725.dasm - Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)
          10 (18.52% of base) : 17173.dasm - (dynamicClass):IL_STUB_PInvoke(uint,ulong):int (FullOpts)
           8 (17.78% of base) : 71871.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:get_Reachable():ubyte:this (Tier1)
           8 (17.78% of base) : 68245.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:get_Reachable():ubyte:this (Tier1)
          15 (13.04% of base) : 55224.dasm - System.Diagnostics.Stopwatch:Start():this (Tier1)
          12 (12.90% of base) : 8428.dasm - System.Diagnostics.Stopwatch:QueryPerformanceCounter():long (Tier1)
           5 (12.82% of base) : 72163.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache:GetCacheHash(int,ubyte,Microsoft.CodeAnalysis.GreenNode):int (Tier1)
          18 (12.33% of base) : 55232.dasm - System.Diagnostics.Stopwatch:Stop():this (Tier1)
          15 (12.20% of base) : 55221.dasm - System.Diagnostics.Stopwatch:GetRawElapsedTicks():long:this (Tier1)
          29 (10.86% of base) : 90138.dasm - System.Threading.Tasks.ValueTask`1[ubyte]:AsTask():System.Threading.Tasks.Task`1[ubyte]:this (Tier1)
          20 (10.47% of base) : 88233.dasm - System.Buffers.StringSearchValuesHelper:ValidateReadPosition(System.ReadOnlySpan`1[ushort],byref,int) (Tier1)
         169 (10.30% of base) : 69144.dasm - Microsoft.Cci.MetadataWriter:SerializeCustomAttributeNamedArguments(byref,System.Reflection.Metadata.Ecma335.NamedArgumentsEncoder,Microsoft.Cci.ICustomAttribute):this (Tier1)
           4 ( 9.76% of base) : 67644.dasm - Microsoft.CodeAnalysis.CSharpExtensions:IsKind(Microsoft.CodeAnalysis.SyntaxNode,ushort):ubyte (Tier1)
           5 ( 9.62% of base) : 8405.dasm - (dynamicClass):IL_STUB_PInvoke(ulong):uint (FullOpts)
         140 ( 7.79% of base) : 68264.dasm - Microsoft.CodeAnalysis.CSharp.BoundConversion:Update(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Conversion,ubyte,ubyte,ubyte,Microsoft.CodeAnalysis.ConstantValue,Microsoft.CodeAnalysis.CSharp.ConversionGroup,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):Microsoft.CodeAnalysis.CSharp.BoundConversion:this (Tier1)
           2 ( 7.69% of base) : 34644.dasm - System.PackedSpanHelpers:ComputeFirstIndex(byref,byref,System.Runtime.Intrinsics.Vector256`1[ubyte]):int (Tier1)
          47 ( 7.37% of base) : 97070.dasm - System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c[System.__Canon]:<.cctor>b__4_0(System.Object):this (Tier1)
           2 ( 7.14% of base) : 67663.dasm - Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag:GetInstance(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag (Tier1)
         183 ( 7.03% of base) : 67749.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:DoVisitList[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon]:this (Tier1)
         105 ( 6.80% of base) : 95259.dasm - System.Text.RegularExpressions.Symbolic.MintermClassifier:.ctor(System.Text.RegularExpressions.Symbolic.BDD[],System.Text.RegularExpressions.Symbolic.CharSetSolver):this (Tier1)

Top method improvements (percentages):
         -13 (-56.52% of base) : 68249.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
          -4 (-50.00% of base) : 68316.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:get_InstructionsEmitted():int:this (Tier1)
         -12 (-50.00% of base) : 99528.dasm - System.Decimal:CreateChecked[System.Decimal](System.Decimal):System.Decimal (Tier1)
         -12 (-50.00% of base) : 99534.dasm - System.Decimal:CreateTruncating[System.Decimal](System.Decimal):System.Decimal (Tier1)
         -32 (-45.71% of base) : 68512.dasm - Microsoft.CodeAnalysis.SyntaxTriviaList:Reverse():Microsoft.CodeAnalysis.SyntaxTriviaList+Reversed:this (Tier1)
         -18 (-40.91% of base) : 18907.dasm - System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable:GetAwaiter():System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable+ConfiguredValueTaskAwaiter:this (Tier1)
         -18 (-40.91% of base) : 18863.dasm - System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1[int]:GetAwaiter():System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter[int]:this (Tier1)
         -18 (-40.91% of base) : 19068.dasm - System.Threading.Tasks.ValueTask:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter:this (Tier1)
         -18 (-40.91% of base) : 17142.dasm - System.Threading.Tasks.ValueTask`1[int]:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter`1[int]:this (Tier1)
          -4 (-40.00% of base) : 17137.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle+OverlappedValueTaskSource:get_Version():short:this (Tier1)
          -4 (-40.00% of base) : 27101.dasm - System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder`1+StateMachineBox[int]:get_Version():short:this (Tier1)
          -3 (-37.50% of base) : 68440.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:get_MaxStack():ushort:this (Tier1)
          -4 (-33.33% of base) : 69006.dasm - Microsoft.Cci.FullMetadataWriter:GetEventDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IEventDefinition]:this (Tier1)
          -4 (-33.33% of base) : 69011.dasm - Microsoft.Cci.FullMetadataWriter:GetFieldDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IFieldDefinition]:this (Tier1)
          -4 (-33.33% of base) : 69004.dasm - Microsoft.Cci.FullMetadataWriter:GetMethodDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IMethodDefinition]:this (Tier1)
          -4 (-33.33% of base) : 69012.dasm - Microsoft.Cci.FullMetadataWriter:GetParameterDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IParameterDefinition]:this (Tier1)
          -4 (-33.33% of base) : 69065.dasm - Microsoft.Cci.FullMetadataWriter:GetPropertyDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IPropertyDefinition]:this (Tier1)
          -4 (-33.33% of base) : 69001.dasm - Microsoft.Cci.FullMetadataWriter:GetTypeDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.ITypeDefinition]:this (Tier1)
         -20 (-32.26% of base) : 69162.dasm - System.Reflection.Metadata.Ecma335.ScalarEncoder:Constant(System.Object):this (Tier1)
          -3 (-30.00% of base) : 67301.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol:get_MethodKind():int:this (Tier1)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 12714674 (overridden on cmd)
Total bytes of diff: 12702222 (overridden on cmd)
Total bytes of delta: -12452 (-0.10 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         108 : 24735.dasm (11.48% of base)
          62 : 40273.dasm (2.14% of base)
          51 : 5717.dasm (9.43% of base)
          51 : 40709.dasm (2.44% of base)
          39 : 2261.dasm (4.03% of base)
          30 : 44337.dasm (9.90% of base)
          29 : 18079.dasm (0.10% of base)
          29 : 41690.dasm (1.83% of base)
          29 : 2679.dasm (5.12% of base)
          25 : 2623.dasm (6.76% of base)
          23 : 40695.dasm (4.09% of base)
          21 : 41904.dasm (3.11% of base)
          19 : 17082.dasm (9.27% of base)
          17 : 34381.dasm (2.08% of base)
          17 : 42154.dasm (3.43% of base)
          17 : 30042.dasm (3.83% of base)
          16 : 42138.dasm (1.95% of base)
          16 : 40125.dasm (1.06% of base)
          16 : 41933.dasm (3.72% of base)
          16 : 42137.dasm (2.22% of base)

Top file improvements (bytes):
        -270 : 25243.dasm (-7.45% of base)
        -205 : 24447.dasm (-3.65% of base)
        -153 : 45484.dasm (-4.44% of base)
        -140 : 45482.dasm (-3.99% of base)
        -135 : 33126.dasm (-3.87% of base)
        -112 : 28645.dasm (-5.58% of base)
        -110 : 30375.dasm (-5.41% of base)
        -104 : 26352.dasm (-6.74% of base)
        -100 : 19569.dasm (-5.59% of base)
         -97 : 4162.dasm (-14.52% of base)
         -86 : 18295.dasm (-5.67% of base)
         -84 : 25459.dasm (-7.30% of base)
         -80 : 5575.dasm (-8.61% of base)
         -80 : 15844.dasm (-2.24% of base)
         -78 : 40103.dasm (-2.84% of base)
         -76 : 25341.dasm (-2.75% of base)
         -72 : 28053.dasm (-2.74% of base)
         -70 : 47773.dasm (-4.98% of base)
         -69 : 50051.dasm (-2.90% of base)
         -65 : 32806.dasm (-3.01% of base)

76 total files with Code Size differences (42 improved, 34 regressed), 20 unchanged.

Top method regressions (bytes):
         108 (11.48% of base) : 24735.dasm - EMFloat:AddSubInternalFPF(ubyte,byref,byref,byref) (Tier1)
          62 ( 2.14% of base) : 40273.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol:LoadMembers():this (Tier1)
          51 ( 2.44% of base) : 40709.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbolExtensions:VisitType[System.__Canon](Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.Func`4[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.__Canon,ubyte,ubyte],System.Func`4[System.__Canon,System.__Canon,ubyte,ubyte],System.__Canon,ubyte,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (Tier1)
          51 ( 9.43% of base) : 5717.dasm - System.Threading.ThreadLocal`1[System.__Canon]:SetValueSlow(System.__Canon,System.Threading.ThreadLocal`1+LinkedSlotVolatile[System.__Canon][]):this (Tier1)
          39 ( 4.03% of base) : 2261.dasm - System.RuntimeType:MakeGenericType(System.Type[]):System.Type:this (Tier1)
          30 ( 9.90% of base) : 44337.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+MembersAndInitializersBuilder:ToReadOnlyAndFree(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]):System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]] (Tier1)
          29 ( 0.10% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
          29 ( 1.83% of base) : 41690.dasm - System.Buffers.StringSearchValues:Create(System.ReadOnlySpan`1[System.String],ubyte):System.Buffers.SearchValues`1[System.String] (Tier1)
          29 ( 5.12% of base) : 2679.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:MergeWithGlobalList(System.__Canon[]):this (Tier1)
          25 ( 6.76% of base) : 2623.dasm - System.Number:Dragon4Double(double,int,ubyte,byref) (Tier1)
          23 ( 4.09% of base) : 40695.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode:ComputeSyntaxTree(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):Microsoft.CodeAnalysis.SyntaxTree (Tier1)
          21 ( 3.11% of base) : 41904.dasm - Benchmarks.SIMD.RayTracer.RayTracer:Shade(Benchmarks.SIMD.RayTracer.ISect,Benchmarks.SIMD.RayTracer.Scene,int):Benchmarks.SIMD.RayTracer.Color:this (Tier1)
          19 ( 9.27% of base) : 17082.dasm - System.IO.Strategies.OSFileStreamStrategy:ReadAsync(System.Memory`1[ubyte],System.Threading.CancellationToken):System.Threading.Tasks.ValueTask`1[int]:this (Tier1)
          17 ( 3.83% of base) : 30042.dasm - Benchstone.BenchF.DMath:Bench(int):ubyte (Tier1-OSR)
          17 ( 2.08% of base) : 34381.dasm - System.Reflection.FieldAccessor:Initialize():this (Tier1)
          17 ( 3.43% of base) : 42154.dasm - System.Resources.ResourceManager:IsDefaultType(System.String,System.String):ubyte (Tier1)
          16 ( 3.72% of base) : 41933.dasm - Benchmarks.SIMD.RayTracer.RayTracer:RenderSequential(Benchmarks.SIMD.RayTracer.Scene,int[]):this (Tier1)
          16 ( 1.06% of base) : 40125.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:GetTypeOfTypeDef(System.Reflection.Metadata.TypeDefinitionHandle,byref,ubyte):System.__Canon:this (Tier1)
          16 ( 1.95% of base) : 42138.dasm - System.Resources.ResourceManager:GetFirstResourceSet(System.Globalization.CultureInfo):System.Resources.ResourceSet:this (Tier1)
          16 ( 2.22% of base) : 42137.dasm - System.Resources.ResourceManager:GetString(System.String,System.Globalization.CultureInfo):System.String:this (Tier1)

Top method improvements (bytes):
        -270 (-7.45% of base) : 25243.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (Tier0-FullOpts)
        -205 (-3.65% of base) : 24447.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1)
        -153 (-4.44% of base) : 45484.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -140 (-3.99% of base) : 45482.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -135 (-3.87% of base) : 33126.dasm - System.IO.File+<WriteToFileAsync>d__110:MoveNext():this (Tier1)
        -112 (-5.58% of base) : 28645.dasm - System.IO.Pipelines.Tests.Perf_Pipe+<ReadAsync>d__7:MoveNext():this (Tier1-OSR)
        -110 (-5.41% of base) : 30375.dasm - System.IO.Pipelines.Tests.Perf_Pipe+<ReadAsyncWithCancellationToken>d__11:MoveNext():this (Tier1-OSR)
        -104 (-6.74% of base) : 26352.dasm - System.Reflection.MethodBaseInvoker:InvokeWithFewArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (Tier1)
        -100 (-5.59% of base) : 19569.dasm - Microsoft.AspNetCore.Server.Kestrel.Performance.PipeThroughputBenchmark+<Parse_SequentialAsync>d__15:MoveNext():this (Tier1-OSR)
         -97 (-14.52% of base) : 4162.dasm - System.Reflection.MethodBaseInvoker:CheckArguments(System.ReadOnlySpan`1[System.Object],System.Span`1[System.Object],System.Span`1[ubyte],System.Reflection.Binder,System.Globalization.CultureInfo,int):this (Tier1)
         -86 (-5.67% of base) : 18295.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         -84 (-7.30% of base) : 25459.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -80 (-2.24% of base) : 15844.dasm - MicroBenchmarks.Serializers.Location:proto_1(byref,MicroBenchmarks.Serializers.Location) (FullOpts)
         -80 (-8.61% of base) : 5575.dasm - System.Reflection.MethodBaseInvoker:InvokePropertySetter(System.Object,int,System.Reflection.Binder,System.Object,System.Globalization.CultureInfo):this (Tier1)
         -78 (-2.84% of base) : 40103.dasm - Microsoft.CodeAnalysis.PEModule:GetTargetAttributeSignatureIndex(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.CustomAttributeHandle,Microsoft.CodeAnalysis.AttributeDescription,byref):int (Tier1)
         -76 (-2.75% of base) : 25341.dasm - MicroBenchmarks.Serializers.ActiveOrUpcomingEvent:proto_7(byref,MicroBenchmarks.Serializers.ActiveOrUpcomingEvent) (FullOpts)
         -72 (-2.74% of base) : 28053.dasm - MicroBenchmarks.Serializers.MyEventsListerItem:proto_7(byref,MicroBenchmarks.Serializers.MyEventsListerItem) (FullOpts)
         -70 (-4.98% of base) : 47773.dasm - Microsoft.AspNetCore.Server.Kestrel.Performance.PipeThroughputBenchmark+<ParallelReader>d__14:MoveNext():this (Tier1)
         -69 (-2.90% of base) : 50051.dasm - MicroBenchmarks.Serializers.MyEventsListerItem:proto_8(byref,MicroBenchmarks.Serializers.MyEventsListerItem):MicroBenchmarks.Serializers.MyEventsListerItem (FullOpts)
         -65 (-3.01% of base) : 32806.dasm - MicroBenchmarks.Serializers.ActiveOrUpcomingEvent:proto_8(byref,MicroBenchmarks.Serializers.ActiveOrUpcomingEvent):MicroBenchmarks.Serializers.ActiveOrUpcomingEvent (FullOpts)

Top method regressions (percentages):
           7 (13.46% of base) : 43741.dasm - Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis:get_Succeeded():ubyte:this (Tier1)
           5 (12.82% of base) : 44017.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache:GetCacheHash(int,ubyte,Microsoft.CodeAnalysis.GreenNode):int (Tier1)
         108 (11.48% of base) : 24735.dasm - EMFloat:AddSubInternalFPF(ubyte,byref,byref,byref) (Tier1)
          30 ( 9.90% of base) : 44337.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+MembersAndInitializersBuilder:ToReadOnlyAndFree(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]]):System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer]] (Tier1)
          51 ( 9.43% of base) : 5717.dasm - System.Threading.ThreadLocal`1[System.__Canon]:SetValueSlow(System.__Canon,System.Threading.ThreadLocal`1+LinkedSlotVolatile[System.__Canon][]):this (Tier1)
          19 ( 9.27% of base) : 17082.dasm - System.IO.Strategies.OSFileStreamStrategy:ReadAsync(System.Memory`1[ubyte],System.Threading.CancellationToken):System.Threading.Tasks.ValueTask`1[int]:this (Tier1)
           2 ( 9.09% of base) : 35948.dasm - System.SpanHelpers:ComputeFirstIndex[ubyte](byref,byref,System.Runtime.Intrinsics.Vector256`1[ubyte]):int (Tier1)
           4 ( 8.70% of base) : 54015.dasm - System.Linq.Expressions.Compiler.LambdaCompiler:GetLambdaArgument(int):int:this (Tier1)
          14 ( 8.00% of base) : 25622.dasm - System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (Tier1-OSR)
           2 ( 7.69% of base) : 8715.dasm - System.PackedSpanHelpers:ComputeFirstIndex(byref,byref,System.Runtime.Intrinsics.Vector256`1[ubyte]):int (Tier1)
           2 ( 7.14% of base) : 41039.dasm - Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag:GetInstance(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag (Tier1)
          25 ( 6.76% of base) : 2623.dasm - System.Number:Dragon4Double(double,int,ubyte,byref) (Tier1)
           9 ( 6.67% of base) : 41022.dasm - Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator:ReleaseExpressionTemps():this (Tier1)
           2 ( 6.06% of base) : 24542.dasm - System.IO.RandomAccess+CallbackResetEvent:ReleaseRefCount(ulong):this (Tier1)
           5 ( 5.81% of base) : 6629.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
           2 ( 5.56% of base) : 33401.dasm - System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[short]:FirstIndex[System.Buffers.IndexOfAnyAsciiSearcher+Negate](byref,byref,System.Runtime.Intrinsics.Vector256`1[ubyte]):int (Tier1)
          29 ( 5.12% of base) : 2679.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:MergeWithGlobalList(System.__Canon[]):this (Tier1)
           1 ( 5.00% of base) : 40155.dasm - Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[System.__Canon]:get_Current():System.__Canon:this (Tier1)
           2 ( 4.88% of base) : 43978.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:Reset(byref):this (Tier1)
           3 ( 4.41% of base) : 28099.dasm - System.Reflection.RtFieldInfo:GetSignature():System.Signature:this (Tier1)

Top method improvements (percentages):
         -13 (-56.52% of base) : 43823.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
         -12 (-50.00% of base) : 54374.dasm - System.Decimal:CreateChecked[System.Decimal](System.Decimal):System.Decimal (Tier1)
         -12 (-50.00% of base) : 54376.dasm - System.Decimal:CreateTruncating[System.Decimal](System.Decimal):System.Decimal (Tier1)
         -11 (-50.00% of base) : 28130.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (Tier1)
         -11 (-50.00% of base) : 28097.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (Tier1)
         -18 (-40.91% of base) : 8637.dasm - System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable:GetAwaiter():System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable+ConfiguredValueTaskAwaiter:this (Tier1)
         -18 (-40.91% of base) : 8481.dasm - System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1[int]:GetAwaiter():System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter[int]:this (Tier1)
         -18 (-40.91% of base) : 8926.dasm - System.Threading.Tasks.ValueTask:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter:this (Tier1)
         -18 (-40.91% of base) : 8955.dasm - System.Threading.Tasks.ValueTask`1[int]:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter`1[int]:this (Tier1)
          -4 (-40.00% of base) : 13797.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle+OverlappedValueTaskSource:get_Version():short:this (Tier1)
          -4 (-40.00% of base) : 8672.dasm - System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder`1+StateMachineBox[int]:get_Version():short:this (Tier1)
          -3 (-30.00% of base) : 40691.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol:get_MethodKind():int:this (Tier1)
          -3 (-30.00% of base) : 8424.dasm - System.Net.Sockets.Socket:get_SafeHandle():System.Net.Sockets.SafeSocketHandle:this (Tier1)
          -3 (-30.00% of base) : 52986.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:get_IsNullable():ubyte:this (Tier1)
          -4 (-26.67% of base) : 8423.dasm - Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid:get_IsInvalid():ubyte:this (Tier1)
          -4 (-26.67% of base) : 24413.dasm - System.IO.Compression.Inflater:get_IsInputBufferHandleAllocated():ubyte:this (Tier1)
          -8 (-25.81% of base) : 42208.dasm - System.Buffers.BitVector256:Contains(ubyte):ubyte:this (Tier1)
          -3 (-25.00% of base) : 8843.dasm - System.Int32:System.Numerics.INumberBase<System.Int32>.TryConvertToTruncating[ushort](int,byref):ubyte (Tier1)
          -4 (-25.00% of base) : 5581.dasm - System.Runtime.InteropServices.MemoryMarshal:GetArrayDataReference(System.Array):byref (Tier1)
          -3 (-25.00% of base) : 46554.dasm - System.UInt16:TryConvertFromTruncating[ushort](ushort,byref):ubyte (Tier1)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 386663759 (overridden on cmd)
Total bytes of diff: 386235958 (overridden on cmd)
Total bytes of delta: -427801 (-0.11 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        3535 : 233512.dasm (3.99% of base)
        3338 : 233448.dasm (3.72% of base)
        3224 : 8002.dasm (68.42% of base)
        3224 : 11811.dasm (68.36% of base)
        1525 : 15682.dasm (32.63% of base)
        1525 : 4191.dasm (32.63% of base)
        1224 : 3216.dasm (4.98% of base)
         574 : 291216.dasm (3.23% of base)
         300 : 291149.dasm (2.79% of base)
         277 : 291379.dasm (2.81% of base)
         274 : 581144.dasm (4.24% of base)
         272 : 8875.dasm (55.28% of base)
         272 : 12684.dasm (55.28% of base)
         267 : 291367.dasm (1.60% of base)
         265 : 307574.dasm (2.81% of base)
         261 : 579010.dasm (4.03% of base)
         225 : 291045.dasm (3.85% of base)
         223 : 3189.dasm (1.02% of base)
         220 : 3222.dasm (1.02% of base)
         218 : 3227.dasm (1.00% of base)

Top file improvements (bytes):
       -2235 : 233201.dasm (-2.42% of base)
       -1408 : 233017.dasm (-4.30% of base)
       -1378 : 233544.dasm (-1.37% of base)
       -1105 : 138980.dasm (-6.93% of base)
       -1105 : 138983.dasm (-6.93% of base)
       -1037 : 232672.dasm (-1.94% of base)
       -1037 : 236777.dasm (-1.94% of base)
        -911 : 291327.dasm (-6.02% of base)
        -854 : 233852.dasm (-0.90% of base)
        -755 : 575494.dasm (-15.94% of base)
        -691 : 579858.dasm (-14.26% of base)
        -640 : 172162.dasm (-18.51% of base)
        -518 : 77047.dasm (-12.98% of base)
        -518 : 77039.dasm (-12.98% of base)
        -518 : 76879.dasm (-12.98% of base)
        -518 : 76887.dasm (-12.98% of base)
        -518 : 76903.dasm (-12.98% of base)
        -518 : 77023.dasm (-12.98% of base)
        -518 : 77031.dasm (-12.98% of base)
        -518 : 76895.dasm (-12.98% of base)

79 total files with Code Size differences (45 improved, 34 regressed), 20 unchanged.

Top method regressions (bytes):
        3535 ( 3.99% of base) : 233512.dasm - r8div:TestEntryPoint():int (FullOpts)
        3338 ( 3.72% of base) : 233448.dasm - r4div:TestEntryPoint():int (FullOpts)
        3224 (68.42% of base) : 8002.dasm - testout1:TestEntryPoint():int (FullOpts)
        3224 (68.36% of base) : 11811.dasm - testout1:TestEntryPoint():int (FullOpts)
        1525 (32.63% of base) : 15682.dasm - testout1:TestEntryPoint():int (FullOpts)
        1525 (32.63% of base) : 4191.dasm - testout1:TestEntryPoint():int (FullOpts)
        1224 ( 4.98% of base) : 3216.dasm - lclfldrem:TestEntryPoint():int (FullOpts)
         574 ( 3.23% of base) : 291216.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         300 ( 2.79% of base) : 291149.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         277 ( 2.81% of base) : 291379.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         274 ( 4.24% of base) : 581144.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.InliningInfoNode:GetData(ILCompiler.DependencyAnalysis.NodeFactory,ubyte):ILCompiler.DependencyAnalysis.ObjectNode+ObjectData:this (Tier1-OSR)
         272 (55.28% of base) : 8875.dasm - testout1:TestEntryPoint():int (FullOpts)
         272 (55.28% of base) : 12684.dasm - testout1:TestEntryPoint():int (FullOpts)
         267 ( 1.60% of base) : 291367.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         265 ( 2.81% of base) : 307574.dasm - Program+TestReflectionInvoke:Run() (FullOpts)
         261 ( 4.03% of base) : 579010.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.InliningInfoNode:GetData(ILCompiler.DependencyAnalysis.NodeFactory,ubyte):ILCompiler.DependencyAnalysis.ObjectNode+ObjectData:this (Tier1-OSR)
         225 ( 3.85% of base) : 291045.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         223 ( 1.02% of base) : 3189.dasm - lclflddiv:TestEntryPoint():int (FullOpts)
         220 ( 1.02% of base) : 3222.dasm - lclfldsub:TestEntryPoint():int (FullOpts)
         218 ( 1.00% of base) : 3227.dasm - lclfldsub:TestEntryPoint():int (FullOpts)

Top method improvements (bytes):
       -2235 (-2.42% of base) : 233201.dasm - i4rem:TestEntryPoint():int (FullOpts)
       -1408 (-4.30% of base) : 233017.dasm - decimalMDArrTest:TestEntryPoint():int (FullOpts)
       -1378 (-1.37% of base) : 233544.dasm - r8rem:TestEntryPoint():int (FullOpts)
       -1105 (-6.93% of base) : 138980.dasm - IntelHardwareIntrinsicTest._Avx2.Program:ShiftLeftLogicalVariable() (FullOpts)
       -1105 (-6.93% of base) : 138983.dasm - IntelHardwareIntrinsicTest._Avx2.Program:ShiftRightLogicalVariable() (FullOpts)
       -1037 (-1.94% of base) : 232672.dasm - Test_1000w1d.testout1:Func_0():int (FullOpts)
       -1037 (-1.94% of base) : 236777.dasm - Test_1000w1d.testout1:Func_0():int (FullOpts)
        -911 (-6.02% of base) : 291327.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
        -854 (-0.90% of base) : 233852.dasm - u4rem:TestEntryPoint():int (FullOpts)
        -755 (-15.94% of base) : 575494.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:TryAddOrGetExisting(System.__Canon,byref):System.__Canon:this (Tier1)
        -691 (-14.26% of base) : 579858.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:TryAddOrGetExisting(System.__Canon,byref):System.__Canon:this (Tier1)
        -640 (-18.51% of base) : 172162.dasm - TestClass:RunHFAsTest(System.Random):ubyte:this (FullOpts)
        -518 (-12.98% of base) : 76879.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementByte0:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 76895.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementByte15:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 76903.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementByte31:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 76887.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementByte7:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 77023.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementSByte0:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 77039.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementSByte15:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 77047.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementSByte31:RunBasicScenario(int,ubyte):this (FullOpts)
        -518 (-12.98% of base) : 77031.dasm - JIT.HardwareIntrinsics.General._Vector512_1.VectorGetAndWithElement__GetAndWithElementSByte7:RunBasicScenario(int,ubyte):this (FullOpts)

Top method regressions (percentages):
          40 (75.47% of base) : 189685.dasm - EarlyLiveness_ForwardSub:Test1():int (FullOpts)
        3224 (68.42% of base) : 8002.dasm - testout1:TestEntryPoint():int (FullOpts)
        3224 (68.36% of base) : 11811.dasm - testout1:TestEntryPoint():int (FullOpts)
         272 (55.28% of base) : 8875.dasm - testout1:TestEntryPoint():int (FullOpts)
         272 (55.28% of base) : 12684.dasm - testout1:TestEntryPoint():int (FullOpts)
          81 (38.94% of base) : 240256.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
          94 (38.68% of base) : 7436.dasm - testout1:Sub_Funclet_454():int (FullOpts)
          94 (38.68% of base) : 7051.dasm - testout1:Sub_Funclet_454():int (FullOpts)
          99 (38.37% of base) : 232113.dasm - Test_10w5d.testout1:Func_0_3_2_2_2():long (FullOpts)
        1525 (32.63% of base) : 15682.dasm - testout1:TestEntryPoint():int (FullOpts)
        1525 (32.63% of base) : 4191.dasm - testout1:TestEntryPoint():int (FullOpts)
          37 (28.91% of base) : 248070.dasm - Program:TestEntryPoint():int (FullOpts)
          27 (27.55% of base) : 240032.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
          20 (27.40% of base) : 248392.dasm - Program:TestEntryPoint():int (FullOpts)
          15 (26.32% of base) : 171640.dasm - (dynamicClass):IL_STUB_PInvoke(ulong,ulong):ubyte (FullOpts)
         126 (25.87% of base) : 26018.dasm - Program:TestEntryPoint():int (FullOpts)
          14 (22.95% of base) : 243551.dasm - IntrinsicsMisoptimizationTest.Program:TestEntryPoint():int (FullOpts)
           2 (22.22% of base) : 178312.dasm - Test_Rotate:rol64_32_inplace(ulong,ulong):ulong (FullOpts)
           2 (22.22% of base) : 178319.dasm - Test_Rotate:ror64_32_inplace(ulong,ulong):ulong (FullOpts)
           4 (21.05% of base) : 248479.dasm - j:b(c):int:this (FullOpts)

Top method improvements (percentages):
         -23 (-95.83% of base) : 247726.dasm - Test_GitHub_16041:Test_GitHub_16041(StructX) (FullOpts)
         -83 (-81.37% of base) : 242167.dasm - Program:TestSHL() (FullOpts)
         -83 (-81.37% of base) : 242168.dasm - Program:TestSHR() (FullOpts)
         -83 (-81.37% of base) : 242169.dasm - Program:TestSZR() (FullOpts)
         -67 (-80.72% of base) : 180947.dasm - System.Numerics.Vector:Sum[long](System.Numerics.Vector`1[long]):long (FullOpts)
         -67 (-80.72% of base) : 180962.dasm - System.Numerics.Vector:Sum[ulong](System.Numerics.Vector`1[ulong]):ulong (FullOpts)
         -42 (-72.41% of base) : 232812.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -40 (-71.43% of base) : 232730.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -39 (-70.91% of base) : 232763.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -38 (-70.37% of base) : 232735.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -30 (-65.22% of base) : 232752.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -29 (-64.44% of base) : 232725.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -24 (-60.00% of base) : 232815.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -24 (-60.00% of base) : 232814.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -24 (-60.00% of base) : 232802.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -24 (-60.00% of base) : 232789.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -24 (-60.00% of base) : 232784.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -24 (-60.00% of base) : 232731.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          -5 (-55.56% of base) : 190554.dasm - Runtime:WriteLine[ubyte](System.String,ubyte):this (FullOpts)
          -5 (-55.56% of base) : 311211.dasm - Tracing.Tests.PauseOnStartValidation.PauseOnStartValidation+<>c__DisplayClass2_0:<TEST_MultipleSessionsCanBeStartedWhilepaused>b__2(Microsoft.Diagnostics.Tracing.Parsers.ClrPrivate.StartupTraceData):this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 44991166 (overridden on cmd)
Total bytes of diff: 44881445 (overridden on cmd)
Total bytes of delta: -109721 (-0.24 % of base)
    diff is an improvement.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         644 : 152949.dasm (933.33% of base)
         581 : 164352.dasm (25.93% of base)
         379 : 185273.dasm (10.37% of base)
         180 : 154007.dasm (4.81% of base)
         157 : 20699.dasm (12.84% of base)
         146 : 20687.dasm (15.15% of base)
         136 : 20700.dasm (11.49% of base)
         133 : 231074.dasm (9.34% of base)
         133 : 200857.dasm (9.34% of base)
         132 : 234060.dasm (216.39% of base)
         132 : 189107.dasm (216.39% of base)
         132 : 189106.dasm (216.39% of base)
         123 : 23004.dasm (4.76% of base)
         123 : 20688.dasm (13.33% of base)
         111 : 163668.dasm (10.87% of base)
         107 : 55014.dasm (2.27% of base)
          98 : 144851.dasm (15.43% of base)
          98 : 85995.dasm (15.43% of base)
          77 : 158180.dasm (6.41% of base)
          71 : 55841.dasm (1.99% of base)

Top file improvements (bytes):
        -436 : 92079.dasm (-8.21% of base)
        -435 : 250604.dasm (-8.27% of base)
        -410 : 206782.dasm (-12.39% of base)
        -410 : 89571.dasm (-12.39% of base)
        -402 : 260040.dasm (-28.61% of base)
        -359 : 87882.dasm (-6.47% of base)
        -316 : 17216.dasm (-9.40% of base)
        -308 : 137422.dasm (-14.12% of base)
        -308 : 77559.dasm (-13.22% of base)
        -290 : 206883.dasm (-7.14% of base)
        -274 : 91535.dasm (-12.62% of base)
        -262 : 139216.dasm (-8.50% of base)
        -262 : 79548.dasm (-8.30% of base)
        -244 : 177018.dasm (-6.08% of base)
        -243 : 78152.dasm (-4.17% of base)
        -238 : 176920.dasm (-5.70% of base)
        -235 : 178063.dasm (-24.82% of base)
        -235 : 174923.dasm (-2.46% of base)
        -228 : 110911.dasm (-4.95% of base)
        -225 : 221409.dasm (-19.91% of base)

76 total files with Code Size differences (40 improved, 36 regressed), 20 unchanged.

Top method regressions (bytes):
         644 (933.33% of base) : 152949.dasm - System.Xml.Serialization.XmlSerializationReader:ReadTypedNull(System.Xml.XmlQualifiedName):System.Object:this (FullOpts)
         581 (25.93% of base) : 164352.dasm - System.Data.DataTable:SerializeTableSchema(System.Runtime.Serialization.SerializationInfo,ubyte):this (FullOpts)
         379 (10.37% of base) : 185273.dasm - System.Reflection.Metadata.Ecma335.MetadataSizes:.ctor(System.Collections.Immutable.ImmutableArray`1[int],System.Collections.Immutable.ImmutableArray`1[int],System.Collections.Immutable.ImmutableArray`1[int],int,ubyte):this (FullOpts)
         180 ( 4.81% of base) : 154007.dasm - System.Xml.XmlTextReaderImpl:ParseXmlDeclaration(ubyte):ubyte:this (FullOpts)
         157 (12.84% of base) : 20699.dasm - System.Globalization.OrdinalCasing:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         146 (15.15% of base) : 20687.dasm - System.Globalization.InvariantModeCasing:IndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         136 (11.49% of base) : 20700.dasm - System.Globalization.OrdinalCasing:LastIndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         133 ( 9.34% of base) : 231074.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.List`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ReferencedAssemblyIdentity[System.__Canon,System.__Canon]]],ubyte,byref,byref,byref,byref) (FullOpts)
         133 ( 9.34% of base) : 200857.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.List`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ReferencedAssemblyIdentity[System.__Canon,System.__Canon]]],ubyte,byref,byref,byref,byref) (FullOpts)
         132 (216.39% of base) : 234060.dasm - System.IO.Hashing.XxHashShared:Accumulate512(ulong,ulong,ulong) (FullOpts)
         132 (216.39% of base) : 189106.dasm - System.IO.Hashing.XxHashShared:Accumulate512(ulong,ulong,ulong) (FullOpts)
         132 (216.39% of base) : 189107.dasm - System.IO.Hashing.XxHashShared:Accumulate512Inlined(ulong,ulong,ulong) (FullOpts)
         123 ( 4.76% of base) : 23004.dasm - System.Globalization.CalendricalCalculationsHelper:SumLongSequenceOfPeriodicTerms(double):double (FullOpts)
         123 (13.33% of base) : 20688.dasm - System.Globalization.InvariantModeCasing:LastIndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         111 (10.87% of base) : 163668.dasm - System.Data.DataSet:SerializeDataSet(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext,int):this (FullOpts)
         107 ( 2.27% of base) : 55014.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInterpolatedStringHandlerInMemberCall(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],byref,int,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
          98 (15.43% of base) : 144851.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousDelegatePublicSymbol:CreateMembers():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol]:this (FullOpts)
          98 (15.43% of base) : 85995.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousDelegatePublicSymbol:CreateMembers():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol]:this (FullOpts)
          77 ( 6.41% of base) : 158180.dasm - System.Xml.Xsl.Runtime.XmlQueryStaticData:GetObjectData(byref,byref):this (FullOpts)
          71 ( 1.99% of base) : 55841.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:MakeTestsAndBindingsForRecursivePattern(Microsoft.CodeAnalysis.CSharp.BoundDagTemp,Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern,byref,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundPatternBinding]):Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+Tests:this (FullOpts)

Top method improvements (bytes):
        -436 (-8.21% of base) : 92079.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceAssemblySymbol:DecodeWellKnownAttribute(byref):this (FullOpts)
        -435 (-8.27% of base) : 250604.dasm - System.Formats.Asn1.WellKnownOids:GetValue(System.ReadOnlySpan`1[ubyte]):System.String (FullOpts)
        -410 (-12.39% of base) : 206782.dasm - System.Security.Cryptography.Asn1.GeneralNameAsn:DecodeCore(byref,System.ReadOnlyMemory`1[ubyte],byref) (FullOpts)
        -410 (-12.39% of base) : 89571.dasm - System.Security.Cryptography.Asn1.GeneralNameAsn:DecodeCore(byref,System.ReadOnlyMemory`1[ubyte],byref) (FullOpts)
        -402 (-28.61% of base) : 260040.dasm - Microsoft.Extensions.DependencyInjection.SocketsHttpHandlerBuilderExtensions:ParseSocketsHttpHandlerConfiguration(Microsoft.Extensions.Configuration.IConfiguration):Microsoft.Extensions.DependencyInjection.SocketsHttpHandlerBuilderExtensions+SocketsHttpHandlerConfiguration (FullOpts)
        -359 (-6.47% of base) : 87882.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BetterFunctionMember[System.__Canon](Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],ubyte,byref):int:this (FullOpts)
        -316 (-9.40% of base) : 17216.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (FullOpts)
        -308 (-14.12% of base) : 137422.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData:ShouldEmitAttribute(Microsoft.CodeAnalysis.CSharp.Symbol,ubyte,ubyte):ubyte:this (FullOpts)
        -308 (-13.22% of base) : 77559.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData:ShouldEmitAttribute(Microsoft.CodeAnalysis.CSharp.Symbol,ubyte,ubyte):ubyte:this (FullOpts)
        -290 (-7.14% of base) : 206883.dasm - System.Security.Cryptography.X509Certificates.Asn1.TbsCertificateAsn:DecodeCore(byref,System.Formats.Asn1.Asn1Tag,System.ReadOnlyMemory`1[ubyte],byref) (FullOpts)
        -274 (-12.62% of base) : 91535.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.VisualBasicAttributeData:ShouldEmitAttribute(Microsoft.CodeAnalysis.VisualBasic.Symbol,ubyte,ubyte):ubyte:this (FullOpts)
        -262 (-8.50% of base) : 139216.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolBase:DecodeWellKnownAttributeImpl(byref):this (FullOpts)
        -262 (-8.30% of base) : 79548.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolBase:DecodeWellKnownAttributeImpl(byref):this (FullOpts)
        -244 (-6.08% of base) : 177018.dasm - Newtonsoft.Json.JsonWriter:WriteValue(Newtonsoft.Json.JsonWriter,int,System.Object) (FullOpts)
        -243 (-4.17% of base) : 78152.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol:DecodeWellKnownAttribute(byref,int,ubyte):this (FullOpts)
        -238 (-5.70% of base) : 176920.dasm - Newtonsoft.Json.JsonWriter:WriteValueAsync(Newtonsoft.Json.JsonWriter,int,System.Object,System.Threading.CancellationToken):System.Threading.Tasks.Task (FullOpts)
        -235 (-2.46% of base) : 174923.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:bindUserDefinedConversion(Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,ubyte,byref,ubyte):ubyte:this (FullOpts)
        -235 (-24.82% of base) : 178063.dasm - Newtonsoft.Json.Schema.JsonSchemaModel:Combine(Newtonsoft.Json.Schema.JsonSchemaModel,Newtonsoft.Json.Schema.JsonSchema) (FullOpts)
        -228 (-4.95% of base) : 110911.dasm - Microsoft.CodeAnalysis.VisualBasic.OverloadResolution:MatchArguments(Microsoft.CodeAnalysis.VisualBasic.BoundMethodOrPropertyGroup,byref,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],Microsoft.CodeAnalysis.VisualBasic.Binder,byref,Microsoft.CodeAnalysis.SyntaxNode,ubyte,byref) (FullOpts)
        -225 (-19.91% of base) : 221409.dasm - Microsoft.CodeAnalysis.CompilationOptions:EqualsHelper(Microsoft.CodeAnalysis.CompilationOptions):ubyte:this (FullOpts)

Top method regressions (percentages):
         644 (933.33% of base) : 152949.dasm - System.Xml.Serialization.XmlSerializationReader:ReadTypedNull(System.Xml.XmlQualifiedName):System.Object:this (FullOpts)
         132 (216.39% of base) : 234060.dasm - System.IO.Hashing.XxHashShared:Accumulate512(ulong,ulong,ulong) (FullOpts)
         132 (216.39% of base) : 189106.dasm - System.IO.Hashing.XxHashShared:Accumulate512(ulong,ulong,ulong) (FullOpts)
         132 (216.39% of base) : 189107.dasm - System.IO.Hashing.XxHashShared:Accumulate512Inlined(ulong,ulong,ulong) (FullOpts)
          29 (126.09% of base) : 13153.dasm - System.ReadOnlySpan`1[System.__Canon]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.__Canon]:this (FullOpts)
          29 (126.09% of base) : 17997.dasm - System.ReadOnlySpan`1[ubyte]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[ubyte]:this (FullOpts)
          29 (126.09% of base) : 13176.dasm - System.Span`1[System.__Canon]:GetEnumerator():System.Span`1+Enumerator[System.__Canon]:this (FullOpts)
          29 (126.09% of base) : 18018.dasm - System.Span`1[ubyte]:GetEnumerator():System.Span`1+Enumerator[ubyte]:this (FullOpts)
          14 (73.68% of base) : 226678.dasm - Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator:get_MethodId():System.Nullable`1[Microsoft.CodeAnalysis.CodeGen.DebugId]:this (FullOpts)
          19 (54.29% of base) : 255463.dasm - System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:get_MetadataToken():int:this (FullOpts)
          19 (54.29% of base) : 266169.dasm - System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:get_MetadataToken():int:this (FullOpts)
          19 (54.29% of base) : 266185.dasm - System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:get_MetadataToken():int:this (FullOpts)
          19 (54.29% of base) : 255478.dasm - System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:get_MetadataToken():int:this (FullOpts)
          65 (39.16% of base) : 199038.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager+AnalyzerExecutionContext+<>c__DisplayClass13_0:<GetCompilationAnalysisScopeAsync>b__0():Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope:this (FullOpts)
          65 (39.16% of base) : 229282.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager+AnalyzerExecutionContext+<>c__DisplayClass13_0:<GetCompilationAnalysisScopeAsync>b__0():Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope:this (FullOpts)
           7 (36.84% of base) : 261960.dasm - Microsoft.Extensions.Logging.ConsoleLoggerExtensions+<>c__DisplayClass11_0:<AddFormatterWithName>b__0(Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions):this (FullOpts)
          37 (27.41% of base) : 209673.dasm - System.Transactions.TransactionScope:SaveTLSContextData():this (FullOpts)
          63 (27.39% of base) : 89187.dasm - Internal.Cryptography.Pal.AnyOS.ManagedPkcsPal+ManagedKeyAgreePal:get_RecipientIdentifier():System.Security.Cryptography.Pkcs.SubjectIdentifier:this (FullOpts)
           7 (26.92% of base) : 260053.dasm - Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions+<>c__DisplayClass22_0:<RedactLoggedHeaders>b__0(Microsoft.Extensions.Http.HttpClientFactoryOptions):this (FullOpts)
          23 (26.14% of base) : 164420.dasm - System.Data.Merger:MergeConstraints(System.Data.DataSet):this (FullOpts)

Top method improvements (percentages):
         -52 (-67.53% of base) : 191407.dasm - Microsoft.CodeAnalysis.MemoryExtensions:IsNullOrWhiteSpace(System.Nullable`1[System.ReadOnlyMemory`1[ushort]]):ubyte (FullOpts)
         -52 (-67.53% of base) : 222041.dasm - Microsoft.CodeAnalysis.MemoryExtensions:IsNullOrWhiteSpace(System.Nullable`1[System.ReadOnlyMemory`1[ushort]]):ubyte (FullOpts)
         -11 (-64.71% of base) : 33449.dasm - Microsoft.Diagnostics.Tracing.EventPipeEventHeader:GetTotalEventSize(ulong,int):int (FullOpts)
         -16 (-61.54% of base) : 190175.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (FullOpts)
         -15 (-60.00% of base) : 27101.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
          -6 (-60.00% of base) : 259484.dasm - System.Drawing.PointF:ToVector2():System.Numerics.Vector2:this (FullOpts)
          -6 (-60.00% of base) : 259615.dasm - System.Drawing.SizeF:ToVector2():System.Numerics.Vector2:this (FullOpts)
         -48 (-58.54% of base) : 18359.dasm - System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.Load(ulong):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
         -48 (-58.54% of base) : 18362.dasm - System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
          -4 (-57.14% of base) : 243003.dasm - System.CommandLine.Parsing.CliParser:<SplitCommandLine>g__Advance|2_0(byref) (FullOpts)
         -42 (-56.00% of base) : 177006.dasm - Newtonsoft.Json.JsonWriter:WriteValue(System.Nullable`1[System.Decimal]):this (FullOpts)
          -5 (-55.56% of base) : 26937.dasm - Microsoft.FSharp.Core.Operators:Decrement(Microsoft.FSharp.Core.FSharpRef`1[int]) (FullOpts)
          -5 (-55.56% of base) : 26936.dasm - Microsoft.FSharp.Core.Operators:Increment(Microsoft.FSharp.Core.FSharpRef`1[int]) (FullOpts)
         -43 (-50.59% of base) : 18363.dasm - System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref,ulong):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
          -4 (-50.00% of base) : 196781.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:get_InstructionsEmitted():int:this (FullOpts)
          -4 (-50.00% of base) : 176462.dasm - Newtonsoft.Json.JsonSerializerSettings:get_DateFormatHandling():int:this (FullOpts)
          -4 (-50.00% of base) : 176460.dasm - Newtonsoft.Json.JsonSerializerSettings:get_Formatting():int:this (FullOpts)
          -9 (-50.00% of base) : 4774.dasm - System.Numerics.Vector2:get_Zero():System.Numerics.Vector2 (FullOpts)
         -11 (-50.00% of base) : 9768.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
         -11 (-50.00% of base) : 9769.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 61385102 (overridden on cmd)
Total bytes of diff: 61168995 (overridden on cmd)
Total bytes of delta: -216107 (-0.35 % of base)
    diff is an improvement.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         759 : 19198.dasm (10.13% of base)
         758 : 19179.dasm (10.07% of base)
         644 : 140278.dasm (933.33% of base)
         566 : 19192.dasm (9.15% of base)
         566 : 19173.dasm (9.09% of base)
         336 : 218915.dasm (2.66% of base)
         315 : 60349.dasm (40.91% of base)
         262 : 98175.dasm (7.58% of base)
         200 : 100038.dasm (5.23% of base)
         192 : 64053.dasm (7.75% of base)
         183 : 120116.dasm (13.38% of base)
         171 : 92483.dasm (13.85% of base)
         159 : 86106.dasm (8.23% of base)
         152 : 303935.dasm (5.81% of base)
         150 : 122751.dasm (2.53% of base)
         146 : 65584.dasm (4.51% of base)
         146 : 62775.dasm (13.15% of base)
         142 : 62730.dasm (3.51% of base)
         140 : 234987.dasm (8.76% of base)
         129 : 176061.dasm (3.82% of base)

Top file improvements (bytes):
       -1540 : 147202.dasm (-7.29% of base)
       -1540 : 187929.dasm (-7.29% of base)
        -480 : 30444.dasm (-10.09% of base)
        -480 : 30442.dasm (-7.83% of base)
        -471 : 98418.dasm (-6.13% of base)
        -435 : 213964.dasm (-8.27% of base)
        -393 : 30450.dasm (-31.80% of base)
        -385 : 118891.dasm (-9.31% of base)
        -373 : 136975.dasm (-12.23% of base)
        -367 : 246839.dasm (-25.10% of base)
        -360 : 118892.dasm (-9.52% of base)
        -359 : 57222.dasm (-9.39% of base)
        -336 : 149354.dasm (-12.62% of base)
        -336 : 190017.dasm (-12.62% of base)
        -326 : 142476.dasm (-2.95% of base)
        -325 : 83705.dasm (-4.28% of base)
        -314 : 57853.dasm (-12.51% of base)
        -301 : 164456.dasm (-7.05% of base)
        -297 : 164360.dasm (-6.92% of base)
        -296 : 120206.dasm (-35.11% of base)

86 total files with Code Size differences (48 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
         759 (10.13% of base) : 19198.dasm - System.SpanHelpers:LastIndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
         758 (10.07% of base) : 19179.dasm - System.SpanHelpers:IndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
         644 (933.33% of base) : 140278.dasm - System.Xml.Serialization.XmlSerializationReader:ReadTypedNull(System.Xml.XmlQualifiedName):System.Object:this (FullOpts)
         566 ( 9.09% of base) : 19173.dasm - System.SpanHelpers:IndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
         566 ( 9.15% of base) : 19192.dasm - System.SpanHelpers:LastIndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
         336 ( 2.66% of base) : 218915.dasm - System.Management.ManagementClassGenerator:AddToDateTimeFunction():this (FullOpts)
         315 (40.91% of base) : 60349.dasm - Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression:get_Display():System.Object:this (FullOpts)
         262 ( 7.58% of base) : 98175.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.NamespaceSymbol:LookupMetadataType(byref):Microsoft.CodeAnalysis.VisualBasic.Symbols.NamedTypeSymbol:this (FullOpts)
         200 ( 5.23% of base) : 100038.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.ReducedExtensionMethodSymbol:Create(Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol,Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol,int,byref):Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol (FullOpts)
         192 ( 7.75% of base) : 64053.dasm - Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter:VisitInitializer(Microsoft.CodeAnalysis.CSharp.BoundExpression,byref):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
         183 (13.38% of base) : 120116.dasm - Microsoft.CodeAnalysis.VisualBasic.TypeUnification:AddSubstitution(byref,Microsoft.CodeAnalysis.VisualBasic.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeParameterSymbol,Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeWithModifiers) (FullOpts)
         171 (13.85% of base) : 92483.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousDelegatePublicSymbol:CreateMembers():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol]:this (FullOpts)
         159 ( 8.23% of base) : 86106.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MergeConstraintTypesForPartialDeclarations(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause]],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause]:this (FullOpts)
         152 ( 5.81% of base) : 303935.dasm - System.ServiceModel.Syndication.AtomPub10ServiceDocumentFormatter:ReadCollection(System.Xml.XmlReader,System.ServiceModel.Syndication.Workspace):System.ServiceModel.Syndication.ResourceCollectionInfo:this (FullOpts)
         150 ( 2.53% of base) : 122751.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeManager+AnonymousDelegatePublicSymbol:.ctor(Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeManager,Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeDescriptor):this (FullOpts)
         146 (13.15% of base) : 62775.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:LearnFromEqualsMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BoundCall,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitArgumentResult]):this (FullOpts)
         146 ( 4.51% of base) : 65584.dasm - Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor:AddTypeParameterConstraints(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ITypeSymbol]):this (FullOpts)
         142 ( 3.51% of base) : 62730.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitObjectCreationInitializer(int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase,ubyte):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]:this (FullOpts)
         140 ( 8.76% of base) : 234987.dasm - System.Text.Json.Utf8JsonReader:CheckLiteralMultiSegment(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],byref):ubyte:this (FullOpts)
         129 ( 3.82% of base) : 176061.dasm - Microsoft.Build.Evaluation.ToolsetReader:ReadAllToolsets(System.Collections.Generic.Dictionary`2[System.String,Microsoft.Build.Evaluation.Toolset],Microsoft.Build.Evaluation.ToolsetConfigurationReader,Microsoft.Build.Collections.PropertyDictionary`1[Microsoft.Build.Execution.ProjectPropertyInstance],Microsoft.Build.Collections.PropertyDictionary`1[Microsoft.Build.Execution.ProjectPropertyInstance],int):System.String (FullOpts)

Top method improvements (bytes):
       -1540 (-7.29% of base) : 147202.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -1540 (-7.29% of base) : 187929.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
        -480 (-7.83% of base) : 30442.dasm - Internal.JitInterface.InstructionSetFlags:ExpandInstructionSetByImplicationHelper(int,Internal.JitInterface.InstructionSetFlags):Internal.JitInterface.InstructionSetFlags (FullOpts)
        -480 (-10.09% of base) : 30444.dasm - Internal.JitInterface.InstructionSetFlags:ExpandInstructionSetByReverseImplicationHelper(int,Internal.JitInterface.InstructionSetFlags):Internal.JitInterface.InstructionSetFlags (FullOpts)
        -471 (-6.13% of base) : 98418.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceAssemblySymbol:DecodeWellKnownAttribute(byref):this (FullOpts)
        -435 (-8.27% of base) : 213964.dasm - System.Formats.Asn1.WellKnownOids:GetValue(System.ReadOnlySpan`1[ubyte]):System.String (FullOpts)
        -393 (-31.80% of base) : 30450.dasm - Internal.JitInterface.InstructionSetFlags:Set64BitInstructionSetVariantsUnconditionally(int):this (FullOpts)
        -385 (-9.31% of base) : 118891.dasm - Microsoft.CodeAnalysis.VisualBasic.LocalRewriter:LateSet(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.BoundLateMemberAccess,Microsoft.CodeAnalysis.VisualBasic.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],ubyte):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
        -373 (-12.23% of base) : 136975.dasm - System.Xml.Xsl.Runtime.DecimalFormatter:.ctor(System.String,System.Xml.Xsl.Runtime.DecimalFormat):this (FullOpts)
        -367 (-25.10% of base) : 246839.dasm - Microsoft.Extensions.DependencyInjection.SocketsHttpHandlerBuilderExtensions:ParseSocketsHttpHandlerConfiguration(Microsoft.Extensions.Configuration.IConfiguration):Microsoft.Extensions.DependencyInjection.SocketsHttpHandlerBuilderExtensions+SocketsHttpHandlerConfiguration (FullOpts)
        -360 (-9.52% of base) : 118892.dasm - Microsoft.CodeAnalysis.VisualBasic.LocalRewriter:LateIndexSet(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.BoundLateInvocation,Microsoft.CodeAnalysis.VisualBasic.BoundExpression,ubyte):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
        -359 (-9.39% of base) : 57222.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<TryBindIndexOrRangeImplicitIndexerParts>g__tryBindUnderlyingIndexerOrSliceAccess|519_0(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundImplicitIndexerReceiverPlaceholder,ubyte,byref,byref,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref):ubyte:this (FullOpts)
        -336 (-12.62% of base) : 149354.dasm - Microsoft.CodeAnalysis.SyntaxDiffer:GetNextAction():Microsoft.CodeAnalysis.SyntaxDiffer+DiffAction:this (FullOpts)
        -336 (-12.62% of base) : 190017.dasm - Microsoft.CodeAnalysis.SyntaxDiffer:GetNextAction():Microsoft.CodeAnalysis.SyntaxDiffer+DiffAction:this (FullOpts)
        -326 (-2.95% of base) : 142476.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:bindUserDefinedConversion(Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,ubyte,byref,ubyte):ubyte:this (FullOpts)
        -325 (-4.28% of base) : 83705.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol:DecodeWellKnownAttribute(byref,int,ubyte):this (FullOpts)
        -314 (-12.51% of base) : 57853.dasm - Microsoft.CodeAnalysis.CSharp.PatternExplainer:ShortestPathToNode(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode],Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode,ubyte,byref):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode] (FullOpts)
        -301 (-7.05% of base) : 164456.dasm - Newtonsoft.Json.JsonWriter:WriteValue(Newtonsoft.Json.JsonWriter,int,System.Object) (FullOpts)
        -297 (-6.92% of base) : 164360.dasm - Newtonsoft.Json.JsonWriter:WriteValueAsync(Newtonsoft.Json.JsonWriter,int,System.Object,System.Threading.CancellationToken):System.Threading.Tasks.Task (FullOpts)
        -296 (-35.11% of base) : 120206.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions:.ctor(Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions):this (FullOpts)

Top method regressions (percentages):
         644 (933.33% of base) : 140278.dasm - System.Xml.Serialization.XmlSerializationReader:ReadTypedNull(System.Xml.XmlQualifiedName):System.Object:this (FullOpts)
          39 (169.57% of base) : 18971.dasm - System.ReadOnlySpan`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)
          39 (169.57% of base) : 19109.dasm - System.Span`1[System.Numerics.Vector`1[float]]:GetEnumerator():System.Span`1+Enumerator[System.Numerics.Vector`1[float]]:this (FullOpts)
          24 (80.00% of base) : 18463.dasm - System.MemoryExtensions:IndexOfAnyExceptInRange[double](System.Span`1[double],double,double):int (FullOpts)
          24 (80.00% of base) : 18453.dasm - System.MemoryExtensions:IndexOfAnyInRange[double](System.Span`1[double],double,double):int (FullOpts)
          24 (80.00% of base) : 18483.dasm - System.MemoryExtensions:LastIndexOfAnyExceptInRange[double](System.Span`1[double],double,double):int (FullOpts)
          24 (80.00% of base) : 18473.dasm - System.MemoryExtensions:LastIndexOfAnyInRange[double](System.Span`1[double],double,double):int (FullOpts)
          24 (75.00% of base) : 18344.dasm - System.MemoryExtensions:ContainsAnyExceptInRange[double](System.ReadOnlySpan`1[double],double,double):ubyte (FullOpts)
          24 (75.00% of base) : 18339.dasm - System.MemoryExtensions:ContainsAnyInRange[double](System.ReadOnlySpan`1[double],double,double):ubyte (FullOpts)
          14 (73.68% of base) : 154735.dasm - Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator:get_MethodId():System.Nullable`1[Microsoft.CodeAnalysis.CodeGen.DebugId]:this (FullOpts)
          24 (70.59% of base) : 18301.dasm - System.MemoryExtensions:ContainsAnyExceptInRange[double](System.Span`1[double],double,double):ubyte (FullOpts)
          24 (70.59% of base) : 18296.dasm - System.MemoryExtensions:ContainsAnyInRange[double](System.Span`1[double],double,double):ubyte (FullOpts)
          25 (65.79% of base) : 33129.dasm - ILCompiler.IBC.IBCDataReader+<>c__DisplayClass36_0:<ReadInternal>b__2():this (FullOpts)
          25 (53.19% of base) : 33127.dasm - ILCompiler.IBC.IBCDataReader+<>c__DisplayClass36_0:<ReadInternal>b__0():this (FullOpts)
          25 (53.19% of base) : 33128.dasm - ILCompiler.IBC.IBCDataReader+<>c__DisplayClass36_0:<ReadInternal>b__1():this (FullOpts)
          50 (42.74% of base) : 158572.dasm - Microsoft.CodeAnalysis.GeneratorDriver+<>c__DisplayClass17_0:<RunGeneratorsCore>b__2(System.TimeSpan):System.TimeSpan:this (FullOpts)
          50 (42.74% of base) : 198993.dasm - Microsoft.CodeAnalysis.GeneratorDriver+<>c__DisplayClass17_0:<RunGeneratorsCore>b__3(System.TimeSpan):System.TimeSpan:this (FullOpts)
          68 (40.96% of base) : 201803.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager+AnalyzerExecutionContext+<>c__DisplayClass13_0:<GetCompilationAnalysisScopeAsync>b__0():Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope:this (FullOpts)
          68 (40.96% of base) : 161394.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager+AnalyzerExecutionContext+<>c__DisplayClass13_0:<GetCompilationAnalysisScopeAsync>b__0():Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope:this (FullOpts)
         315 (40.91% of base) : 60349.dasm - Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression:get_Display():System.Object:this (FullOpts)

Top method improvements (percentages):
         -68 (-85.00% of base) : 23386.dasm - System.Runtime.Intrinsics.Vector128:Sum[int](System.Runtime.Intrinsics.Vector128`1[int]):int (FullOpts)
         -80 (-83.33% of base) : 310766.dasm - Xunit.Assert:Contains[ubyte](System.Memory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
         -80 (-83.33% of base) : 310778.dasm - Xunit.Assert:DoesNotContain[ubyte](System.Memory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
         -80 (-83.33% of base) : 310798.dasm - Xunit.Assert:Equal[ubyte](System.Memory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
         -67 (-80.72% of base) : 20856.dasm - System.Numerics.Vector:Sum[long](System.Numerics.Vector`1[long]):long (FullOpts)
         -50 (-70.42% of base) : 188294.dasm - Microsoft.CodeAnalysis.MemoryExtensions:IsNullOrWhiteSpace(System.Nullable`1[System.ReadOnlyMemory`1[ushort]]):ubyte (FullOpts)
         -50 (-70.42% of base) : 147577.dasm - Microsoft.CodeAnalysis.MemoryExtensions:IsNullOrWhiteSpace(System.Nullable`1[System.ReadOnlyMemory`1[ushort]]):ubyte (FullOpts)
         -36 (-69.23% of base) : 310767.dasm - Xunit.Assert:Contains[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
         -36 (-69.23% of base) : 310768.dasm - Xunit.Assert:Contains[ubyte](System.ReadOnlyMemory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
         -36 (-69.23% of base) : 310779.dasm - Xunit.Assert:DoesNotContain[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
         -36 (-69.23% of base) : 310780.dasm - Xunit.Assert:DoesNotContain[ubyte](System.ReadOnlyMemory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
         -36 (-69.23% of base) : 310799.dasm - Xunit.Assert:Equal[ubyte](System.Memory`1[ubyte],System.ReadOnlyMemory`1[ubyte]) (FullOpts)
         -36 (-69.23% of base) : 310800.dasm - Xunit.Assert:Equal[ubyte](System.ReadOnlyMemory`1[ubyte],System.Memory`1[ubyte]) (FullOpts)
         -42 (-67.74% of base) : 4106.dasm - Microsoft.FSharp.Linq.NullableOperators:op_GreaterEqualsQmark[System.Numerics.Vector`1[float]](System.Numerics.Vector`1[float],System.Nullable`1[System.Numerics.Vector`1[float]]):ubyte (FullOpts)
         -42 (-67.74% of base) : 4112.dasm - Microsoft.FSharp.Linq.NullableOperators:op_GreaterQmark[System.Numerics.Vector`1[float]](System.Numerics.Vector`1[float],System.Nullable`1[System.Numerics.Vector`1[float]]):ubyte (FullOpts)
         -42 (-67.74% of base) : 4118.dasm - Microsoft.FSharp.Linq.NullableOperators:op_LessEqualsQmark[System.Numerics.Vector`1[float]](System.Numerics.Vector`1[float],System.Nullable`1[System.Numerics.Vector`1[float]]):ubyte (FullOpts)
         -42 (-67.74% of base) : 4076.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreater[System.Numerics.Vector`1[float]](System.Nullable`1[System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):ubyte (FullOpts)
         -42 (-67.74% of base) : 4070.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreaterEquals[System.Numerics.Vector`1[float]](System.Nullable`1[System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):ubyte (FullOpts)
         -42 (-67.74% of base) : 4088.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkLess[System.Numerics.Vector`1[float]](System.Nullable`1[System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):ubyte (FullOpts)
         -42 (-67.74% of base) : 4082.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkLessEquals[System.Numerics.Vector`1[float]](System.Nullable`1[System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):ubyte (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 284868541 (overridden on cmd)
Total bytes of diff: 284485886 (overridden on cmd)
Total bytes of delta: -382655 (-0.13 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        5336 : 37696.dasm (51.55% of base)
        1484 : 63771.dasm (13.94% of base)
         878 : 326562.dasm (12.65% of base)
         779 : 54827.dasm (4.42% of base)
         721 : 185575.dasm (5.04% of base)
         703 : 326458.dasm (10.93% of base)
         643 : 191051.dasm (4.10% of base)
         594 : 656244.dasm (10.67% of base)
         567 : 421908.dasm (10.04% of base)
         562 : 659986.dasm (3.30% of base)
         457 : 447327.dasm (6.66% of base)
         385 : 326510.dasm (8.74% of base)
         378 : 333336.dasm (3.21% of base)
         343 : 226737.dasm (6.46% of base)
         335 : 421912.dasm (5.97% of base)
         324 : 671867.dasm (5.13% of base)
         319 : 653597.dasm (9.64% of base)
         279 : 599496.dasm (9.86% of base)
         272 : 370053.dasm (10.88% of base)
         260 : 371639.dasm (3.67% of base)

Top file improvements (bytes):
       -1532 : 634058.dasm (-13.40% of base)
        -997 : 63487.dasm (-4.08% of base)
        -839 : 191593.dasm (-5.92% of base)
        -677 : 338899.dasm (-14.70% of base)
        -669 : 191592.dasm (-6.70% of base)
        -633 : 94778.dasm (-7.98% of base)
        -601 : 641943.dasm (-2.64% of base)
        -600 : 652055.dasm (-2.79% of base)
        -578 : 597348.dasm (-8.00% of base)
        -494 : 659871.dasm (-3.67% of base)
        -483 : 406184.dasm (-9.12% of base)
        -469 : 653855.dasm (-4.57% of base)
        -469 : 540163.dasm (-8.87% of base)
        -460 : 91749.dasm (-2.46% of base)
        -448 : 654641.dasm (-5.53% of base)
        -444 : 535724.dasm (-8.42% of base)
        -438 : 407134.dasm (-11.60% of base)
        -431 : 614228.dasm (-7.26% of base)
        -430 : 94605.dasm (-6.20% of base)
        -401 : 462354.dasm (-2.34% of base)

82 total files with Code Size differences (43 improved, 39 regressed), 20 unchanged.

Top method regressions (bytes):
        5336 (51.55% of base) : 37696.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
        1484 (13.94% of base) : 63771.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes:<DecodeUnmanagedCallersOnlyAttribute>g__DecodeUnmanagedCallersOnlyAttributeData|72_1(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes,Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData (Tier1)
         878 (12.65% of base) : 326562.dasm - System.IO.Tests.Directory_GetFileSystemEntries_str_str:SearchPatternWithTrailingStar():this (Tier1)
         779 ( 4.42% of base) : 54827.dasm - Microsoft.CodeAnalysis.CSharp.Binder:TryPerformConstructorOverloadResolution(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.String,Microsoft.CodeAnalysis.Location,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref,byref,ubyte,ubyte):ubyte:this (Tier1)
         721 ( 5.04% of base) : 185575.dasm - Microsoft.CodeAnalysis.CSharp.Binder:TryPerformConstructorOverloadResolution(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.String,Microsoft.CodeAnalysis.Location,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref,byref,ubyte,ubyte):ubyte:this (Tier1)
         703 (10.93% of base) : 326458.dasm - System.IO.Tests.Directory_GetFileSystemEntries_str_str:SearchPatternWithLeadingStar():this (Tier1)
         643 ( 4.10% of base) : 191051.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindClassCreationExpression(Microsoft.CodeAnalysis.SyntaxNode,System.String,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
         594 (10.67% of base) : 656244.dasm - Microsoft.CodeAnalysis.CSharp.ClosureConversion:RemapLocalFunction(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,byref,byref,byref,byref):this (Tier1)
         567 (10.04% of base) : 421908.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__Vectorized256|227_2[float,float,System.Numerics.Tensors.TensorPrimitives+Exp2Operator`1[float]](byref,byref,ulong) (Tier1)
         562 ( 3.30% of base) : 659986.dasm - Microsoft.Cci.MetadataWriter:PopulateTypeDefTableRows():this (Tier1)
         457 ( 6.66% of base) : 447327.dasm - System.Xml.XslCompiledTransformApiTests.CArgAddParam:AddParam16(System.Object,int,int,int,int):this (Tier1)
         385 ( 8.74% of base) : 326510.dasm - System.IO.Tests.Directory_GetFileSystemEntries_str_str:SearchPatternDotIsStar():this (Tier1)
         378 ( 3.21% of base) : 333336.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         343 ( 6.46% of base) : 226737.dasm - System.Collections.Frozen.OrdinalStringFrozenSet:.ctor(System.String[],System.Collections.Generic.IEqualityComparer`1[System.String],int,int,int,int):this (Tier1)
         335 ( 5.97% of base) : 421912.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__Vectorized256|227_2[float,float,System.Numerics.Tensors.TensorPrimitives+Exp10Operator`1[float]](byref,byref,ulong) (Tier1)
         324 ( 5.13% of base) : 671867.dasm - System.Xml.XmlTextReaderImpl:ParseXmlDeclaration(ubyte):ubyte:this (Tier1)
         319 ( 9.64% of base) : 653597.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol:AddSynthesizedAttributes(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder,byref):this (Tier1)
         279 ( 9.86% of base) : 599496.dasm - Xunit.Sdk.ReflectionMethodInfo:GetParent(System.Reflection.MethodInfo):System.Reflection.MethodInfo (Tier1)
         272 (10.88% of base) : 370053.dasm - System.SpanTests.ReadOnlySpanTests:TestMatchThree_Byte() (Tier1-OSR)
         260 ( 3.67% of base) : 371639.dasm - System.SpanTests.SpanTests:TestMatchIndexOfAny_TwoInteger() (Tier1-OSR)

Top method improvements (bytes):
       -1532 (-13.40% of base) : 634058.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:GetRuntimeMember(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol],byref,Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer`5[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):Microsoft.CodeAnalysis.CSharp.Symbol (Tier1)
        -997 (-4.08% of base) : 63487.dasm - Microsoft.CodeAnalysis.CSharp.Binder:MakeDeconstructionConversion(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Binder+DeconstructionVariable],byref):ubyte:this (Tier1)
        -839 (-5.92% of base) : 191593.dasm - Microsoft.CodeAnalysis.CSharp.BestTypeInferrer:GetBestType(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],Microsoft.CodeAnalysis.CSharp.ConversionsBase,byref):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (Tier1)
        -677 (-14.70% of base) : 338899.dasm - Xunit.Sdk.ReflectionMethodInfo:GetParent(System.Reflection.MethodInfo):System.Reflection.MethodInfo (Tier1)
        -669 (-6.70% of base) : 191592.dasm - Microsoft.CodeAnalysis.CSharp.BestTypeInferrer:InferBestTypeForConditionalOperator(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Conversions,byref,byref):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (Tier1)
        -633 (-7.98% of base) : 94778.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis:CheckInvocationArgMixingWithUpdatedRules(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[int],uint,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (Tier1)
        -601 (-2.64% of base) : 641943.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindConstructorInitializerCore(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
        -600 (-2.79% of base) : 652055.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:VisitBinaryLogicalOperatorChildren(Microsoft.CodeAnalysis.CSharp.BoundExpression):this (Tier1)
        -578 (-8.00% of base) : 597348.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryWrite(System.Text.Json.Utf8JsonWriter,System.__Canon,System.Text.Json.JsonSerializerOptions,byref):ubyte:this (Tier1)
        -494 (-3.67% of base) : 659871.dasm - Microsoft.Cci.MetadataWriter:SerializeMethodBodies(System.Reflection.Metadata.BlobBuilder,Microsoft.Cci.PdbWriter,byref):int[]:this (Tier1)
        -483 (-9.12% of base) : 406184.dasm - System.Formats.Asn1.WellKnownOids:GetValue(System.ReadOnlySpan`1[ubyte]):System.String (Tier1)
        -469 (-4.57% of base) : 653855.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindExtensionMethod(Microsoft.CodeAnalysis.SyntaxNode,System.String,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.CSharp.MethodGroupResolution:this (Tier1)
        -469 (-8.87% of base) : 540163.dasm - System.Formats.Asn1.WellKnownOids:GetValue(System.ReadOnlySpan`1[ubyte]):System.String (Tier1)
        -460 (-2.46% of base) : 91749.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindAttributeCore(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundAttribute:this (Tier1)
        -448 (-5.53% of base) : 654641.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitCompoundAssignmentOperator(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
        -444 (-8.42% of base) : 535724.dasm - System.Formats.Asn1.WellKnownOids:GetValue(System.ReadOnlySpan`1[ubyte]):System.String (Tier1)
        -438 (-11.60% of base) : 407134.dasm - System.Net.Security.SslSessionsCache:CacheCredential(System.Net.Security.SafeFreeCredentials,ubyte[],int,ubyte,int,ubyte,ubyte,ubyte) (Tier1)
        -431 (-7.26% of base) : 614228.dasm - System.Text.Json.Serialization.JsonDictionaryConverter`3[System.Text.Json.Serialization.Tests.StructWrapperForIDictionary,System.__Canon,System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (Tier1)
        -430 (-6.20% of base) : 94605.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer:HaveSameParameterTypes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap,int,int):ubyte (Tier1)
        -401 (-2.34% of base) : 462354.dasm - System.Xml.Tests.TCNamespace:TestNamespace6():int:this (Tier1)

Top method regressions (percentages):
          33 (75.00% of base) : 112076.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
          33 (75.00% of base) : 53672.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
          33 (75.00% of base) : 633770.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
          33 (75.00% of base) : 84624.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
          33 (75.00% of base) : 184829.dasm - Roslyn.Utilities.SingleInitNullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:ReadIfInitialized():System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap]:this (Tier1)
        5336 (51.55% of base) : 37696.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
          50 (42.74% of base) : 60139.dasm - Microsoft.CodeAnalysis.GeneratorDriver+<>c__DisplayClass17_0:<RunGeneratorsCore>b__3(System.TimeSpan):System.TimeSpan:this (Tier1)
          85 (41.67% of base) : 185221.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
          85 (41.67% of base) : 54149.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
          68 (40.96% of base) : 94088.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager+AnalyzerExecutionContext+<>c__DisplayClass13_0:<GetCompilationAnalysisScopeAsync>b__0():Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope:this (Tier1)
          82 (39.61% of base) : 112642.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
          82 (39.61% of base) : 91788.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
          82 (39.61% of base) : 634986.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
           7 (38.89% of base) : 558910.dasm - Moq.Behaviors.ReturnValue:Execute(Moq.Invocation):this (Tier1)
         161 (35.31% of base) : 645602.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2227_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          83 (32.81% of base) : 297031.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,System.Type,System.Object,System.Object,System.Object):ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.formalParameter.cnstrctor004.cnstrctor004.MyType (FullOpts)
          19 (27.94% of base) : 456629.dasm - OLEDB.Test.ModuleCore.CTestCase+<>c__DisplayClass7_1:<TestCases>b__0():int:this (Tier1)
          29 (25.66% of base) : 91200.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1014_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (Tier1)
          29 (25.66% of base) : 184822.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1014_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (Tier1)
          29 (25.66% of base) : 635247.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1014_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (Tier1)

Top method improvements (percentages):
         -26 (-59.09% of base) : 607640.dasm - (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)
         -13 (-56.52% of base) : 55186.dasm - Microsoft.CodeAnalysis.BitVector:IsTrue(ulong,int):ubyte (Tier1)
          -5 (-55.56% of base) : 619534.dasm - System.Text.Json.Serialization.Tests.CollectionTests+RefCountedDictionary`2[int,int]:<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator>b__6_0():this (Tier1)
          -5 (-55.56% of base) : 613065.dasm - System.Text.Json.Serialization.Tests.CollectionTests+RefCountedList`1[int]:<System.Collections.Generic.IEnumerable<T>.GetEnumerator>b__6_0():this (Tier1)
          -6 (-54.55% of base) : 65199.dasm - Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (Tier1)
          -4 (-50.00% of base) : 191055.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:get_InstructionsEmitted():int:this (Tier1)
          -4 (-50.00% of base) : 351872.dasm - System.Linq.Parallel.GroupByGrouping`2[int,int]:System.Linq.IGrouping<TGroupKey,TElement>.get_Key():int:this (Tier1)
         -27 (-50.00% of base) : 421275.dasm - System.Numerics.Tensors.TensorPrimitives:Sigmoid[double](System.ReadOnlySpan`1[double],System.Span`1[double]) (Tier1)
         -27 (-50.00% of base) : 421668.dasm - System.Numerics.Tensors.TensorPrimitives:Sigmoid[float](System.ReadOnlySpan`1[float],System.Span`1[float]) (Tier1)
         -27 (-50.00% of base) : 416008.dasm - System.Numerics.Tensors.TensorPrimitives:Sigmoid[float](System.ReadOnlySpan`1[float],System.Span`1[float]) (Tier1)
         -27 (-50.00% of base) : 419731.dasm - System.Numerics.Tensors.TensorPrimitives:Sigmoid[System.Half](System.ReadOnlySpan`1[System.Half],System.Span`1[System.Half]) (Tier1)
         -27 (-50.00% of base) : 418191.dasm - System.Numerics.Tensors.TensorPrimitives:Sigmoid[System.Half](System.ReadOnlySpan`1[System.Half],System.Span`1[System.Half]) (Tier1)
         -11 (-50.00% of base) : 81603.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (Instrumented Tier1)
         -11 (-50.00% of base) : 433869.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (Tier1)
         -11 (-50.00% of base) : 81055.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (Instrumented Tier1)
         -11 (-50.00% of base) : 432801.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (Tier1)
         -29 (-48.33% of base) : 61135.dasm - System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1[Roslyn.Utilities.SemaphoreSlimExtensions+SemaphoreDisposer]:GetAwaiter():System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter[Roslyn.Utilities.SemaphoreSlimExtensions+SemaphoreDisposer]:this (Tier1)
         -29 (-48.33% of base) : 38635.dasm - System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1[System.__Canon]:GetAwaiter():System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter[System.__Canon]:this (Instrumented Tier1)
         -29 (-48.33% of base) : 42489.dasm - System.Threading.Tasks.ValueTask`1[System.__Canon]:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter`1[System.__Canon]:this (Instrumented Tier1)
         -29 (-48.33% of base) : 66466.dasm - System.Threading.Tasks.ValueTask`1[System.__Canon]:GetAwaiter():System.Runtime.CompilerServices.ValueTaskAwaiter`1[System.__Canon]:this (Tier1)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 135796023 (overridden on cmd)
Total bytes of diff: 135361462 (overridden on cmd)
Total bytes of delta: -434561 (-0.32 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1468 : 168767.dasm (18.27% of base)
        1444 : 169021.dasm (17.70% of base)
        1444 : 168029.dasm (17.70% of base)
         560 : 45699.dasm (4.28% of base)
         560 : 51522.dasm (4.28% of base)
         390 : 69432.dasm (63.62% of base)
         381 : 218240.dasm (4.64% of base)
         367 : 170060.dasm (12.73% of base)
         366 : 191373.dasm (26.31% of base)
         355 : 168027.dasm (7.93% of base)
         354 : 168755.dasm (7.75% of base)
         336 : 149671.dasm (2.66% of base)
         284 : 221525.dasm (10.29% of base)
         284 : 201245.dasm (10.29% of base)
         276 : 151767.dasm (10.10% of base)
         228 : 151410.dasm (7.40% of base)
         206 : 153406.dasm (3.37% of base)
         200 : 153231.dasm (56.34% of base)
         195 : 270976.dasm (3.71% of base)
         195 : 270489.dasm (3.68% of base)

Top file improvements (bytes):
       -6136 : 258329.dasm (-15.73% of base)
       -6136 : 274817.dasm (-15.73% of base)
       -1540 : 20703.dasm (-7.29% of base)
        -890 : 199919.dasm (-44.28% of base)
        -890 : 199960.dasm (-44.28% of base)
        -890 : 199837.dasm (-44.28% of base)
        -758 : 276249.dasm (-19.69% of base)
        -683 : 12366.dasm (-5.88% of base)
        -626 : 203435.dasm (-4.10% of base)
        -534 : 199782.dasm (-41.82% of base)
        -534 : 199375.dasm (-41.82% of base)
        -534 : 199194.dasm (-41.82% of base)
        -528 : 160953.dasm (-3.52% of base)
        -521 : 96162.dasm (-20.23% of base)
        -519 : 250707.dasm (-10.32% of base)
        -494 : 263515.dasm (-7.76% of base)
        -483 : 275533.dasm (-15.69% of base)
        -481 : 276394.dasm (-17.65% of base)
        -449 : 14761.dasm (-10.58% of base)
        -435 : 22001.dasm (-8.27% of base)

84 total files with Code Size differences (46 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
        1468 (18.27% of base) : 168767.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarIntoSpan>g__Vectorized256|235_2[ubyte,System.Numerics.Tensors.TensorPrimitives+IdentityOperator`1[ubyte],System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[ubyte]](byref,ubyte,byref,ulong) (FullOpts)
        1444 (17.70% of base) : 169021.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarIntoSpan>g__Vectorized256|235_2[short,System.Numerics.Tensors.TensorPrimitives+IdentityOperator`1[short],System.Numerics.Tensors.TensorPrimitives+InvertedBinaryOperator`2[System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[short],short]](byref,short,byref,ulong) (FullOpts)
        1444 (17.70% of base) : 168029.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanScalarIntoSpan>g__Vectorized256|235_2[short,System.Numerics.Tensors.TensorPrimitives+IdentityOperator`1[short],System.Numerics.Tensors.TensorPrimitives+InvertedBinaryOperator`2[System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[short],short]](byref,short,byref,ulong) (FullOpts)
         560 ( 4.28% of base) : 45699.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte) (FullOpts)
         560 ( 4.28% of base) : 51522.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte) (FullOpts)
         390 (63.62% of base) : 69432.dasm - System.Collections.Tests.IEnumerable_Generic_Tests`1[int]:<IEnumerable_Generic_Enumerator_Reset>b__55_1(System.Collections.Generic.IEnumerator`1[int],int[],int):this (FullOpts)
         381 ( 4.64% of base) : 218240.dasm - System.Tests.EnumTests:ToString_TryFormat(ubyte,ubyte) (FullOpts)
         367 (12.73% of base) : 170060.dasm - System.Numerics.Tests.Matrix4x4Tests:Matrix4x4CreateFromAxisAngleTest():this (FullOpts)
         366 (26.31% of base) : 191373.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:GetBlobReader_VirtualBlob():this (FullOpts)
         355 ( 7.93% of base) : 168027.dasm - System.Numerics.Tensors.TensorPrimitives:InvokeSpanScalarIntoSpan[short,System.Numerics.Tensors.TensorPrimitives+IdentityOperator`1[short],System.Numerics.Tensors.TensorPrimitives+InvertedBinaryOperator`2[System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[short],short]](System.ReadOnlySpan`1[short],short,System.Span`1[short]) (FullOpts)
         354 ( 7.75% of base) : 168755.dasm - System.Numerics.Tensors.TensorPrimitives:InvokeSpanScalarIntoSpan[ubyte,System.Numerics.Tensors.TensorPrimitives+IdentityOperator`1[ubyte],System.Numerics.Tensors.TensorPrimitives+InvertedBinaryOperator`2[System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[ubyte],ubyte]](System.ReadOnlySpan`1[ubyte],ubyte,System.Span`1[ubyte]) (FullOpts)
         336 ( 2.66% of base) : 149671.dasm - System.Management.ManagementClassGenerator:AddToDateTimeFunction():this (FullOpts)
         284 (10.29% of base) : 221525.dasm - System.Tests.StringTests:ZeroLengthCompareTo_StringComparison() (FullOpts)
         284 (10.29% of base) : 201245.dasm - System.Tests.StringTests:ZeroLengthCompareTo_StringComparison() (FullOpts)
         276 (10.10% of base) : 151767.dasm - System.SpanTests.SpanTests:TestMatchTwo_Byte() (FullOpts)
         228 ( 7.40% of base) : 151410.dasm - System.Buffers.Tests.ArrayBufferWriterTests_Byte:WriteAndCopyToStream(ubyte):this (FullOpts)
         206 ( 3.37% of base) : 153406.dasm - System.Memory.Tests.SequenceReader.ReadTo:TryReadTo_Span(ubyte,ubyte):this (FullOpts)
         200 (56.34% of base) : 153231.dasm - System.Memory.Tests.SequenceReader.Rewind:RewindZero_DoesNothing():this (FullOpts)
         195 ( 3.71% of base) : 270976.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:InvalidJsonDueToWritingMultipleValues(System.Text.Json.JsonWriterOptions,ubyte):this (FullOpts)
         195 ( 3.68% of base) : 270489.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:InvalidJsonDueToWritingMultipleValuesWithComments(System.Text.Json.JsonWriterOptions,ubyte):this (FullOpts)

Top method improvements (bytes):
       -6136 (-15.73% of base) : 258329.dasm - System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters:Equals(System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters):ubyte:this (FullOpts)
       -6136 (-15.73% of base) : 274817.dasm - System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters:Equals(System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters):ubyte:this (FullOpts)
       -1540 (-7.29% of base) : 20703.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
        -890 (-44.28% of base) : 199837.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector512Tests:ExpSingleTest(float,float,float):this (FullOpts)
        -890 (-44.28% of base) : 199960.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector512Tests:Log2SingleTest(float,float,float):this (FullOpts)
        -890 (-44.28% of base) : 199919.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector512Tests:LogSingleTest(float,float,float):this (FullOpts)
        -758 (-19.69% of base) : 276249.dasm - System.Text.Json.Tests.Utf8JsonReaderTests:TestSkipPartial(System.String,ubyte) (FullOpts)
        -683 (-5.88% of base) : 12366.dasm - ComInterfaceGenerator.Unit.Tests.ByValueContentsMarshalling+<ByValueMarshalAttributeOnCustomCollections>d__3:MoveNext():ubyte:this (FullOpts)
        -626 (-4.10% of base) : 203435.dasm - System.Numerics.Tests.ComparisonTest:RunPositiveTests(System.Random) (FullOpts)
        -534 (-41.82% of base) : 199194.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:ExpSingleTest(float,float,float):this (FullOpts)
        -534 (-41.82% of base) : 199375.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:Log2SingleTest(float,float,float):this (FullOpts)
        -534 (-41.82% of base) : 199782.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:LogSingleTest(float,float,float):this (FullOpts)
        -528 (-3.52% of base) : 160953.dasm - Systen.Net.Mail.Tests.LoopbackSmtpServer+<HandleConnectionAsync>d__62:MoveNext():this (FullOpts)
        -521 (-20.23% of base) : 96162.dasm - System.Data.Tests.SqlTypes.SqlInt16Test:ArithmeticMethods():this (FullOpts)
        -519 (-10.32% of base) : 250707.dasm - System.Text.Json.SourceGeneration.Tests.ReferenceHandlerTests_Default+ReferenceHandlerTestsContext_Default:EmployeeSerializeHandler(System.Text.Json.Utf8JsonWriter,System.Text.Json.Serialization.Tests.ReferenceHandlerTests+Employee):this (FullOpts)
        -494 (-7.76% of base) : 263515.dasm - System.Text.Json.SourceGeneration.Tests.NodeInteropTests_Default+NodeInteropTestsContext_Default:TestClassWithInitializedPropertiesSerializeHandler(System.Text.Json.Utf8JsonWriter,System.Text.Json.Serialization.Tests.TestClassWithInitializedProperties):this (FullOpts)
        -483 (-15.69% of base) : 275533.dasm - System.Text.Json.Tests.Utf8JsonReaderTests:SkipIncomplete(System.String,int,ubyte) (FullOpts)
        -481 (-17.65% of base) : 276394.dasm - System.Text.Json.Tests.Utf8JsonReaderTests:SkipInvalid() (FullOpts)
        -449 (-10.58% of base) : 14761.dasm - Microsoft.CodeAnalysis.CSharp.Formatting.TokenBasedFormattingRule:GetAdjustSpacesOperation(byref,byref,byref):Microsoft.CodeAnalysis.Formatting.Rules.AdjustSpacesOperation:this (FullOpts)
        -435 (-8.27% of base) : 22001.dasm - System.Formats.Asn1.WellKnownOids:GetValue(System.ReadOnlySpan`1[ubyte]):System.String (FullOpts)

Top method regressions (percentages):
          59 (453.85% of base) : 215433.dasm - System.Tests.ArraySegment_Tests+<>c__DisplayClass21_0:<GetSetItem_NotInRange_Invalid>b__4():System.Object:this (FullOpts)
          52 (162.50% of base) : 167348.dasm - System.Numerics.Tensors.Tests.GenericIntegerTensorPrimitivesTests`1[uint]:RemoveSignedMinValue(System.Span`1[uint]):this (FullOpts)
          25 (64.10% of base) : 69701.dasm - System.Collections.Concurrent.Tests.PartitionerStaticTests+<>c__DisplayClass7_1:<TestExceptions>b__0():this (FullOpts)
         390 (63.62% of base) : 69432.dasm - System.Collections.Tests.IEnumerable_Generic_Tests`1[int]:<IEnumerable_Generic_Enumerator_Reset>b__55_1(System.Collections.Generic.IEnumerator`1[int],int[],int):this (FullOpts)
          50 (59.52% of base) : 195114.dasm - System.Runtime.CompilerServices.UnsafeTests:RefIsAddressLessThan() (FullOpts)
         200 (56.34% of base) : 153231.dasm - System.Memory.Tests.SequenceReader.Rewind:RewindZero_DoesNothing():this (FullOpts)
          50 (42.74% of base) : 10033.dasm - Microsoft.CodeAnalysis.GeneratorDriver+<>c__DisplayClass17_0:<RunGeneratorsCore>b__3(System.TimeSpan):System.TimeSpan:this (FullOpts)
          68 (40.96% of base) : 8209.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager+AnalyzerExecutionContext+<>c__DisplayClass13_0:<GetCompilationAnalysisScopeAsync>b__0():Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope:this (FullOpts)
          37 (39.36% of base) : 153516.dasm - System.SpanTests.ReadOnlySpanTests:EmptySpansNotUnified() (FullOpts)
          37 (39.36% of base) : 152355.dasm - System.SpanTests.SpanTests:EmptySpansNotUnified() (FullOpts)
          47 (39.17% of base) : 151477.dasm - System.Memory.Tests.ReadOnlySequenceTestsDefault:Default_Enumerator():this (FullOpts)
          81 (38.94% of base) : 6628.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
           7 (38.89% of base) : 34011.dasm - Microsoft.Extensions.Configuration.IniConfigurationExtensions+<>c__DisplayClass5_0:<AddIniStream>b__0(Microsoft.Extensions.Configuration.Ini.IniStreamConfigurationSource):this (FullOpts)
           7 (38.89% of base) : 30206.dasm - Microsoft.Extensions.Configuration.JsonConfigurationExtensions+<>c__DisplayClass5_0:<AddJsonStream>b__0(Microsoft.Extensions.Configuration.Json.JsonStreamConfigurationSource):this (FullOpts)
           7 (38.89% of base) : 34846.dasm - Microsoft.Extensions.Configuration.XmlConfigurationExtensions+<>c__DisplayClass5_0:<AddXmlStream>b__0(Microsoft.Extensions.Configuration.Xml.XmlStreamConfigurationSource):this (FullOpts)
           7 (38.89% of base) : 41478.dasm - Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions+<>c__DisplayClass22_0:<RedactLoggedHeaders>b__0(Microsoft.Extensions.Http.HttpClientFactoryOptions):this (FullOpts)
           7 (38.89% of base) : 42094.dasm - Microsoft.Extensions.Logging.ConsoleLoggerExtensions+<>c__DisplayClass11_0:<AddFormatterWithName>b__0(Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions):this (FullOpts)
           7 (38.89% of base) : 58165.dasm - Microsoft.Extensions.Options.Tests.OptionsBuilderTest+<>c:<ConfigureOptionsWithSingletonDepWillUpdate>b__6_0(Microsoft.Extensions.Options.Tests.FakeOptions,Microsoft.Extensions.Options.Tests.OptionsBuilderTest+SomeService):this (FullOpts)
           7 (38.89% of base) : 33664.dasm - Moq.Behaviors.ReturnValue:Execute(Moq.Invocation):this (FullOpts)
          17 (38.64% of base) : 156322.dasm - System.Net.Http.Headers.WarningHeaderValue:get_Date():System.Nullable`1[System.DateTimeOffset]:this (FullOpts)

Top method improvements (percentages):
        -179 (-63.48% of base) : 199204.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector64Tests:AssertEqual(System.Runtime.Intrinsics.Vector64`1[float],System.Runtime.Intrinsics.Vector64`1[float],System.Runtime.Intrinsics.Vector64`1[float]) (FullOpts)
         -26 (-59.09% of base) : 278152.dasm - (dynamicClass):.ctor(System.Nullable`1[System.Guid],System.Object,System.Object,System.Object):System.Text.Json.Serialization.Tests.ConstructorTests+TypeWithNullableGuid (FullOpts)
          -5 (-55.56% of base) : 39073.dasm - Microsoft.Extensions.Diagnostics.Tests.MetricsSubscriptionManagerTests+FakeListener:Initialize(Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource):this (FullOpts)
          -5 (-55.56% of base) : 41894.dasm - Microsoft.Extensions.Http.DefaultHttpClientFactoryTest+<>c__DisplayClass11_0:<Factory_MultipleCalls_DoesNotCacheHttpClient>b__0(System.Net.Http.HttpClient):this (FullOpts)
          -5 (-55.56% of base) : 41892.dasm - Microsoft.Extensions.Http.DefaultHttpClientFactoryTest+<>c__DisplayClass15_0:<Factory_CreateClient_WithoutName_UsesDefaultOptions>b__0(System.Net.Http.HttpClient):this (FullOpts)
          -5 (-55.56% of base) : 41955.dasm - Microsoft.Extensions.Http.DefaultHttpClientFactoryTest+<>c__DisplayClass16_0:<Factory_CreateClient_WithName_UsesNamedOptions>b__0(System.Net.Http.HttpClient):this (FullOpts)
          -5 (-55.56% of base) : 58468.dasm - Microsoft.Extensions.Primitives.CompositeChangeTokenTest+<>c__DisplayClass6_0:<ShouldNotCollectDisposablesIfChangedTokenEncountered>b__1():this (FullOpts)
          -5 (-55.56% of base) : 86471.dasm - System.ComponentModel.Composition.AttributedModel.MyNotifyImportExporter:OnImportsSatisfied():this (FullOpts)
          -5 (-55.56% of base) : 86472.dasm - System.ComponentModel.Composition.AttributedModel.MyNotifyImportImporter:OnImportsSatisfied():this (FullOpts)
          -5 (-55.56% of base) : 91398.dasm - System.Composition.Runtime.Tests.ExportFactoryTMetadataTests:<ExportCreator>b__11_0():this (FullOpts)
          -5 (-55.56% of base) : 91400.dasm - System.Compostition.Runtime.Tests.ExportTests+<>c__DisplayClass1_0:<Dispose_MultipleTimes_InvokesDisposeAction>b__0():this (FullOpts)
          -5 (-55.56% of base) : 102053.dasm - System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass10_0:<ListenerDisposalsTest>b__6(System.Diagnostics.Metrics.Instrument,short,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)
          -5 (-55.56% of base) : 102052.dasm - System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass10_0:<ListenerDisposalsTest>b__7(System.Diagnostics.Metrics.Instrument,int,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)
          -5 (-55.56% of base) : 102054.dasm - System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass10_0:<ListenerDisposalsTest>b__9(System.Diagnostics.Metrics.Instrument,double,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)
          -5 (-55.56% of base) : 102113.dasm - System.Diagnostics.Metrics.Tests.MetricsTests+<>c__DisplayClass9_0:<MeterDisposalsTest>b__9(System.Diagnostics.Metrics.Instrument,System.Decimal,System.ReadOnlySpan`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]],System.Object):this (FullOpts)
          -5 (-55.56% of base) : 278567.dasm - System.Text.Json.Serialization.Tests.CollectionTests+RefCountedList`1[int]:<System.Collections.Generic.IEnumerable<T>.GetEnumerator>b__6_0():this (FullOpts)
          -5 (-55.56% of base) : 317063.dasm - System.Threading.Tests.EtwTests+<>c__DisplayClass0_0:<TestEtw>b__3(System.Threading.Barrier):this (FullOpts)
          -5 (-55.56% of base) : 182725.dasm - System.Xml.XmlDocumentTests.NodeInsertingTests+<>c__DisplayClass0_0:<CreateElementAndModifyInnerText>b__0(System.Object,System.Xml.XmlNodeChangedEventArgs):this (FullOpts)
          -5 (-55.56% of base) : 182723.dasm - System.Xml.XmlDocumentTests.NodeInsertingTests+<>c__DisplayClass1_0:<InsertNodeAfter>b__0(System.Object,System.Xml.XmlNodeChangedEventArgs):this (FullOpts)
          -5 (-55.56% of base) : 182727.dasm - System.Xml.XmlDocumentTests.NodeInsertingTests+<>c__DisplayClass2_0:<InsertNodeBefore>b__0(System.Object,System.Xml.XmlNodeChangedEventArgs):this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 13923185 (overridden on cmd)
Total bytes of diff: 13860814 (overridden on cmd)
Total bytes of delta: -62371 (-0.45 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         238 : 1017.dasm (2.50% of base)
         205 : 1375.dasm (23.32% of base)
         193 : 23108.dasm (8.41% of base)
         192 : 1382.dasm (41.83% of base)
         160 : 23862.dasm (8.37% of base)
         142 : 28090.dasm (3.59% of base)
         137 : 24957.dasm (4.31% of base)
         127 : 26035.dasm (4.74% of base)
         104 : 949.dasm (2.53% of base)
         100 : 1045.dasm (0.55% of base)
          94 : 25668.dasm (4.40% of base)
          85 : 23849.dasm (11.41% of base)
          84 : 18829.dasm (0.28% of base)
          81 : 22322.dasm (38.94% of base)
          78 : 1153.dasm (9.29% of base)
          74 : 28628.dasm (1.67% of base)
          69 : 16243.dasm (3.41% of base)
          69 : 1357.dasm (4.12% of base)
          67 : 21236.dasm (1.44% of base)
          62 : 14613.dasm (1.29% of base)

Top file improvements (bytes):
       -3593 : 5805.dasm (-3.94% of base)
       -1520 : 10868.dasm (-11.23% of base)
        -676 : 4540.dasm (-43.73% of base)
        -534 : 16430.dasm (-5.92% of base)
        -465 : 12489.dasm (-2.08% of base)
        -461 : 8092.dasm (-5.53% of base)
        -420 : 1058.dasm (-2.66% of base)
        -411 : 1082.dasm (-2.43% of base)
        -379 : 7982.dasm (-3.03% of base)
        -360 : 28621.dasm (-9.85% of base)
        -331 : 22415.dasm (-4.36% of base)
        -317 : 26839.dasm (-2.72% of base)
        -304 : 26515.dasm (-10.40% of base)
        -279 : 1007.dasm (-3.17% of base)
        -274 : 12190.dasm (-7.73% of base)
        -225 : 1432.dasm (-5.38% of base)
        -225 : 31101.dasm (-9.12% of base)
        -223 : 31682.dasm (-10.47% of base)
        -222 : 9129.dasm (-1.12% of base)
        -221 : 32725.dasm (-3.38% of base)

82 total files with Code Size differences (45 improved, 37 regressed), 20 unchanged.

Top method regressions (bytes):
         238 ( 2.50% of base) : 1017.dasm - BepuPhysics.CollisionDetection.SweepTasks.GJKDistanceTester`6[BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder]:FindClosestPoint(byref,byref,byref,byref,byref) (FullOpts)
         205 (23.32% of base) : 1375.dasm - BepuPhysics.Trees.Tree:BinnedRefine(int,byref,int,byref,byref,BepuUtilities.Memory.BufferPool):this (FullOpts)
         193 ( 8.41% of base) : 23108.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MakeAcyclicInterfaces(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol]:this (FullOpts)
         192 (41.83% of base) : 1382.dasm - BepuPhysics.Trees.Tree:ReifyStagingNode(int,int,ulong,int,byref,byref,byref):int:this (FullOpts)
         160 ( 8.37% of base) : 23862.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MergeConstraintTypesForPartialDeclarations(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause]],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause]:this (FullOpts)
         142 ( 3.59% of base) : 28090.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitObjectCreationInitializer(int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase,ubyte):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]:this (FullOpts)
         137 ( 4.31% of base) : 24957.dasm - Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor:AddTypeParameterConstraints(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ITypeSymbol]):this (FullOpts)
         127 ( 4.74% of base) : 26035.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis:GetInvocationArgumentsForEscape(Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[int],ubyte,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+MixableDestination],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+EscapeArgument]):this (FullOpts)
         104 ( 2.53% of base) : 949.dasm - DemoBenchmarks.BenchmarkHelper:CreateShapes(System.Random,BepuUtilities.Memory.BufferPool,BepuPhysics.Collidables.Shapes) (FullOpts)
         100 ( 0.55% of base) : 1045.dasm - BepuPhysics.CollisionDetection.CollisionTasks.TriangleCylinderTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
          94 ( 4.40% of base) : 25668.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindConstructorBody(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
          85 (11.41% of base) : 23849.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MergeConstraintKindsForPartialDeclarations(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause]]):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause]:this (FullOpts)
          84 ( 0.28% of base) : 18829.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments:this (FullOpts)
          81 (38.94% of base) : 22322.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
          78 ( 9.29% of base) : 1153.dasm - DemoBenchmarks.TwoBodyConstraintBenchmarks:DistanceServo():System.ValueTuple`2[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
          74 ( 1.67% of base) : 28628.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:MakeTestsAndBindingsForRecursivePattern(Microsoft.CodeAnalysis.CSharp.BoundDagTemp,Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern,byref,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundPatternBinding]):Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+Tests:this (FullOpts)
          69 ( 4.12% of base) : 1357.dasm - BepuPhysics.PoseIntegrator`1[DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks]:PredictBoundingBoxes(int,int,float,byref,int):this (FullOpts)
          69 ( 3.41% of base) : 16243.dasm - Microsoft.ML.Data.DataViewUtils+Splitter:ConsolidateCore(Microsoft.ML.Runtime.IChannelProvider,Microsoft.ML.DataViewRowCursor[],byref,Microsoft.ML.Runtime.IChannel):Microsoft.ML.DataViewRowCursor (FullOpts)
          67 ( 1.44% of base) : 21236.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (FullOpts)
          62 ( 1.29% of base) : 14613.dasm - System.Diagnostics.Process:StartWithCreateProcess(System.Diagnostics.ProcessStartInfo):ubyte:this (FullOpts)

Top method improvements (bytes):
       -3593 (-3.94% of base) : 5805.dasm - FSharp.Compiler.TcGlobals+TcGlobals:.ctor(ubyte,FSharp.Compiler.AbstractIL.IL+ILGlobals,FSharp.Compiler.TypedTree+CcuThunk,System.String,ubyte,ubyte,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpList`1[System.String],Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+CcuThunk]]],ubyte,ubyte,Internal.Utilities.PathMap,FSharp.Compiler.Features+LanguageVersion):this (FullOpts)
       -1520 (-11.23% of base) : 10868.dasm - FSharp.Compiler.AugmentWithHashCompare:CheckAugmentationAttribs(ubyte,FSharp.Compiler.TcGlobals+TcGlobals,FSharp.Compiler.Import+ImportMap,FSharp.Compiler.TypedTree+Entity) (FullOpts)
        -676 (-43.73% of base) : 4540.dasm - FSharp.Compiler.Parser:checkEndOfFileError(FSharp.Compiler.ParseHelpers+LexerContinuation) (FullOpts)
        -534 (-5.92% of base) : 16430.dasm - Microsoft.ML.Trainers.SdcaTrainerBase`3[System.__Canon,System.__Canon,System.__Canon]:TrainCore(Microsoft.ML.Runtime.IChannel,Microsoft.ML.Data.RoleMappedData,Microsoft.ML.Trainers.LinearModelParameters,int):System.__Canon:this (FullOpts)
        -465 (-2.08% of base) : 12489.dasm - FSharp.Compiler.CheckComputationExpressions+tryTrans@776-1:Invoke(Microsoft.FSharp.Core.Unit):Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.Syntax.SynExpr]:this (FullOpts)
        -461 (-5.53% of base) : 8092.dasm - FSharp.Compiler.NameResolution:ResolveExprLongIdentPrim(FSharp.Compiler.NameResolution+TcResultsSink,FSharp.Compiler.NameResolution+NameResolver,ubyte,FSharp.Compiler.NameResolution+FullyQualifiedFlag,FSharp.Compiler.Text.Range,FSharp.Compiler.AccessibilityLogic+AccessorDomain,FSharp.Compiler.NameResolution+NameResolutionEnv,FSharp.Compiler.NameResolution+TypeNameResolutionInfo,FSharp.Compiler.Syntax.Ident,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.Syntax.Ident],ubyte):Internal.Utilities.Library.ResultOrException`1[System.Tuple`3[Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.TypedTree+TType],FSharp.Compiler.NameResolution+Item,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.Syntax.Ident]]] (FullOpts)
        -420 (-2.66% of base) : 1058.dasm - BepuPhysics.CollisionDetection.CollisionTasks.BoxCylinderTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
        -411 (-2.43% of base) : 1082.dasm - BepuPhysics.CollisionDetection.CollisionTasks.BoxPairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
        -379 (-3.03% of base) : 7982.dasm - FSharp.Compiler.CheckExpressions:TcExprUndelayed(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.ConstraintSolver+OverallTy,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.Syntax.SynExpr):System.Tuple`2[FSharp.Compiler.TypedTree+Expr,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
        -360 (-9.85% of base) : 28621.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<TryBindIndexOrRangeImplicitIndexerParts>g__tryBindUnderlyingIndexerOrSliceAccess|519_0(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundImplicitIndexerReceiverPlaceholder,ubyte,byref,byref,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref):ubyte:this (FullOpts)
        -331 (-4.36% of base) : 22415.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol:DecodeWellKnownAttribute(byref,int,ubyte):this (FullOpts)
        -317 (-2.72% of base) : 26839.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:LearnFromDecisionDag(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundDecisionDag,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState,System.Nullable`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+PossiblyConditionalState]):Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol,System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,ubyte]]:this (FullOpts)
        -304 (-10.40% of base) : 26515.dasm - Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer:MergeOrRemoveCandidates(System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Collections.Generic.HashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Predicate`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.ConversionsBase,short,byref) (FullOpts)
        -279 (-3.17% of base) : 1007.dasm - BepuPhysics.CollisionDetection.SweepTasks.ConvexPairSweepTask`5[BepuPhysics.Collidables.Sphere,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.CollisionDetection.SweepTasks.SphereBoxDistanceTester]:Sweep[BepuPhysics.CollisionDetection.SweepTasks.ConvexPairSweepTask`5+OffsetSweep[BepuPhysics.Collidables.Sphere,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.CollisionDetection.SweepTasks.SphereBoxDistanceTester]](ulong,byref,byref,ulong,byref,byref,byref,float,float,float,int,byref,byref,byref,byref,byref):ubyte (FullOpts)
        -274 (-7.73% of base) : 12190.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (FullOpts)
        -225 (-5.38% of base) : 1432.dasm - BepuPhysics.Solver`1[DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks]:PrepareConstraintIntegrationResponsibilities(BepuUtilities.IThreadDispatcher):BepuUtilities.Collections.IndexSet:this (FullOpts)
        -225 (-9.12% of base) : 31101.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:ZipAsArray[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField](System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Func`3[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField]):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField] (FullOpts)
        -223 (-10.47% of base) : 31682.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData:ShouldEmitAttribute(Microsoft.CodeAnalysis.CSharp.Symbol,ubyte,ubyte):ubyte:this (FullOpts)
        -222 (-1.12% of base) : 9129.dasm - FSharp.Compiler.ConstraintSolver+SolveMemberConstraint@1402-8:Invoke(Microsoft.FSharp.Core.Unit):FSharp.Compiler.ErrorLogger+OperationResult`1[FSharp.Compiler.ConstraintSolver+TraitConstraintSolution]:this (FullOpts)
        -221 (-3.38% of base) : 32725.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (FullOpts)

Top method regressions (percentages):
         192 (41.83% of base) : 1382.dasm - BepuPhysics.Trees.Tree:ReifyStagingNode(int,int,ulong,int,byref,byref,byref):int:this (FullOpts)
          81 (38.94% of base) : 22322.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
           7 (31.82% of base) : 10349.dasm - FSharp.Compiler.NameResolution+WithNewTypecheckResultsSink@2025:System.IDisposable.Dispose():this (FullOpts)
          32 (27.59% of base) : 26357.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:All[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon],System.Func`2[System.__Canon,ubyte]):ubyte (FullOpts)
          27 (27.55% of base) : 21741.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableNamespace|1013_2(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
          21 (27.27% of base) : 27263.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+PlaceholderRegion:Dispose():this (FullOpts)
          32 (26.67% of base) : 27119.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:Any[Microsoft.CodeAnalysis.SyntaxList`1[System.__Canon]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.SyntaxList`1[System.__Canon]],System.Func`2[Microsoft.CodeAnalysis.SyntaxList`1[System.__Canon],ubyte]):ubyte (FullOpts)
           7 (25.93% of base) : 9611.dasm - FSharp.Compiler.ConstraintSolver+TransactMemberConstraintSolution@1857-1:Invoke(Microsoft.FSharp.Core.Unit):Microsoft.FSharp.Core.Unit:this (FullOpts)
          26 (24.07% of base) : 24671.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol:IsUnique(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.String):ubyte (FullOpts)
         205 (23.32% of base) : 1375.dasm - BepuPhysics.Trees.Tree:BinnedRefine(int,byref,int,byref,byref,BepuUtilities.Memory.BufferPool):this (FullOpts)
          26 (23.21% of base) : 24385.dasm - Microsoft.CodeAnalysis.CSharp.ConversionsBase:HasIdentityConversionToAny(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol]]):ubyte (FullOpts)
          32 (22.22% of base) : 28011.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:FreeAll[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon],System.Func`2[System.__Canon,System.__Canon]) (FullOpts)
          31 (18.34% of base) : 21740.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol>g__isViableType|1013_1(Microsoft.CodeAnalysis.CSharp.LookupResult):ubyte (FullOpts)
          38 (18.01% of base) : 18985.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser:AddWarnings(System.Collections.Generic.Dictionary`2[System.String,int],int,System.ReadOnlyMemory`1[ushort]) (FullOpts)
          16 (17.20% of base) : 27118.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:Any[ubyte](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte],System.Func`2[ubyte,ubyte]):ubyte (FullOpts)
          55 (16.87% of base) : 22326.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:TryGetBestResult(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]],byref):ubyte (FullOpts)
          46 (16.85% of base) : 35397.dasm - System.Management.Automation.Language.CommandAst:InternalVisit(System.Management.Automation.Language.AstVisitor):int:this (FullOpts)
           3 (16.67% of base) : 8132.dasm - FSharp.Compiler.CheckExpressions+ApplicableExpr:get_Type():FSharp.Compiler.TypedTree+TType:this (FullOpts)
          41 (16.53% of base) : 24577.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbolExtensions:FindEnclosingTypeParameter(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,System.String):Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol (FullOpts)
          34 (16.43% of base) : 27262.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+PlaceholderRegion:.ctor(Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase,uint]]):this (FullOpts)

Top method improvements (percentages):
          -9 (-64.29% of base) : 9711.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadMultipleMethodSemantics@2366-3:Invoke(System.Tuple`3[int,int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]]):FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]:this (FullOpts)
          -5 (-55.56% of base) : 36382.dasm - System.Management.Automation.ModuleIntrinsics:DecrementModuleNestingCount():this (FullOpts)
          -4 (-50.00% of base) : 15176.dasm - SixLabors.ImageSharp.Image:get_Height():int:this (FullOpts)
         -11 (-50.00% of base) : 33086.dasm - System.Reflection.RuntimePropertyInfo:get_CanRead():ubyte:this (FullOpts)
         -11 (-50.00% of base) : 33100.dasm - System.Reflection.RuntimePropertyInfo:get_CanWrite():ubyte:this (FullOpts)
         -18 (-48.65% of base) : 5843.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadGenericParamConstraints@1786-4:Invoke(System.Tuple`2[int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+TypeDefOrRefTag]]):FSharp.Compiler.AbstractIL.IL+ILType:this (FullOpts)
         -18 (-48.65% of base) : 5792.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadInterfaceImpls@1746-4:Invoke(System.Tuple`2[int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+TypeDefOrRefTag]]):FSharp.Compiler.AbstractIL.IL+ILType:this (FullOpts)
        -676 (-43.73% of base) : 4540.dasm - FSharp.Compiler.Parser:checkEndOfFileError(FSharp.Compiler.ParseHelpers+LexerContinuation) (FullOpts)
          -3 (-42.86% of base) : 15175.dasm - SixLabors.ImageSharp.Image:get_Width():int:this (FullOpts)
         -34 (-39.53% of base) : 26819.dasm - Microsoft.CodeAnalysis.Shared.Collections.TemporaryArray`1+Enumerator[System.__Canon]:.ctor(byref):this (FullOpts)
          -3 (-37.50% of base) : 5672.dasm - FSharp.Compiler.TypedTree+MakeRecdFieldsTable@5688:Invoke(FSharp.Compiler.TypedTree+RecdField):System.String:this (FullOpts)
          -3 (-37.50% of base) : 5713.dasm - FSharp.Compiler.TypedTree+MakeUnionCases@5694:Invoke(FSharp.Compiler.TypedTree+UnionCase):System.String:this (FullOpts)
          -3 (-37.50% of base) : 12343.dasm - FSharp.Compiler.TypedTreeOps+PrettyTypes+alreadyInUse@2703:Invoke(FSharp.Compiler.TypedTree+Typar):System.String:this (FullOpts)
          -3 (-37.50% of base) : 26228.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol:GetDeclaratorSyntax():Microsoft.CodeAnalysis.SyntaxNode:this (FullOpts)
         -60 (-36.36% of base) : 4525.dasm - FSharp.Compiler.LexFilter+LexFilterImpl:returnToken(FSharp.Compiler.LexFilter+LexbufState,FSharp.Compiler.Parser+token):FSharp.Compiler.Parser+token:this (FullOpts)
         -23 (-35.94% of base) : 24698.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol:AddNullableTransforms(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte]):this (FullOpts)
         -23 (-35.94% of base) : 25439.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol:AddNullableTransforms(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte]):this (FullOpts)
          -4 (-33.33% of base) : 32042.dasm - Microsoft.Cci.FullMetadataWriter:GetMethodDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IMethodDefinition]:this (FullOpts)
          -4 (-33.33% of base) : 32169.dasm - Microsoft.Cci.FullMetadataWriter:GetParameterDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IParameterDefinition]:this (FullOpts)
          -4 (-33.33% of base) : 32171.dasm - Microsoft.Cci.FullMetadataWriter:GetPropertyDefs():System.Collections.Generic.IReadOnlyList`1[Microsoft.Cci.IPropertyDefinition]:this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">

To reproduce these diffs on Windows x64:
```
superpmi.py asmdiffs -target_os windows -target_arch x64 -arch x64
```

```

Summary of Code Size diffs:
(Lower is better)

Total bytes of base: 5124260 (overridden on cmd)
Total bytes of diff: 5109473 (overridden on cmd)
Total bytes of delta: -14787 (-0.29 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         156 : 20528.dasm (12.43% of base)
         156 : 2681.dasm (12.43% of base)
         156 : 17846.dasm (12.43% of base)
         156 : 23209.dasm (12.43% of base)
         156 : 8675.dasm (12.43% of base)
         146 : 2683.dasm (15.29% of base)
         146 : 8677.dasm (15.29% of base)
         146 : 17848.dasm (15.29% of base)
         146 : 23212.dasm (15.29% of base)
         146 : 20530.dasm (15.29% of base)
         123 : 8525.dasm (4.85% of base)
         123 : 14180.dasm (4.85% of base)
         104 : 11202.dasm (24.41% of base)
         104 : 6028.dasm (24.41% of base)
          78 : 5276.dasm (97.50% of base)
          78 : 1652.dasm (97.50% of base)
          76 : 19369.dasm (95.00% of base)
          74 : 9656.dasm (97.37% of base)
          74 : 3933.dasm (97.37% of base)
          72 : 16771.dasm (90.00% of base)

Top file improvements (bytes):
        -155 : 7822.dasm (-5.51% of base)
        -155 : 12689.dasm (-5.51% of base)
         -97 : 13392.dasm (-6.55% of base)
         -97 : 8201.dasm (-6.55% of base)
         -86 : 974.dasm (-16.80% of base)
         -86 : 4468.dasm (-16.80% of base)
         -72 : 16160.dasm (-14.91% of base)
         -72 : 21510.dasm (-14.91% of base)
         -70 : 27998.dasm (-12.30% of base)
         -70 : 28031.dasm (-13.04% of base)
         -70 : 29539.dasm (-12.73% of base)
         -68 : 31400.dasm (-29.44% of base)
         -67 : 7738.dasm (-3.72% of base)
         -67 : 13291.dasm (-3.75% of base)
         -65 : 11795.dasm (-5.74% of base)
         -64 : 26655.dasm (-18.55% of base)
         -63 : 27215.dasm (-21.50% of base)
         -61 : 27677.dasm (-18.54% of base)
         -61 : 27649.dasm (-22.85% of base)
         -60 : 27672.dasm (-19.17% of base)

87 total files with Code Size differences (53 improved, 34 regressed), 20 unchanged.

Top method regressions (bytes):
         156 (12.43% of base) : 20528.dasm - System.Globalization.OrdinalCasing:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         156 (12.43% of base) : 2681.dasm - System.Globalization.OrdinalCasing:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         156 (12.43% of base) : 17846.dasm - System.Globalization.OrdinalCasing:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         156 (12.43% of base) : 23209.dasm - System.Globalization.OrdinalCasing:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         156 (12.43% of base) : 8675.dasm - System.Globalization.OrdinalCasing:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         146 (15.29% of base) : 2683.dasm - System.Globalization.InvariantModeCasing:IndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         146 (15.29% of base) : 8677.dasm - System.Globalization.InvariantModeCasing:IndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         146 (15.29% of base) : 17848.dasm - System.Globalization.InvariantModeCasing:IndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         146 (15.29% of base) : 23212.dasm - System.Globalization.InvariantModeCasing:IndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         146 (15.29% of base) : 20530.dasm - System.Globalization.InvariantModeCasing:IndexOfIgnoreCase(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int (FullOpts)
         123 ( 4.85% of base) : 8525.dasm - System.Globalization.CalendricalCalculationsHelper:SumLongSequenceOfPeriodicTerms(double):double (FullOpts)
         123 ( 4.85% of base) : 14180.dasm - System.Globalization.CalendricalCalculationsHelper:SumLongSequenceOfPeriodicTerms(double):double (FullOpts)
         104 (24.41% of base) : 11202.dasm - Internal.Runtime.TypeLoader.MethodSignatureComparer:IsMatchingNativeLayoutMethodSignature(Internal.Runtime.CompilerServices.RuntimeSignature):ubyte:this (FullOpts)
         104 (24.41% of base) : 6028.dasm - Internal.Runtime.TypeLoader.MethodSignatureComparer:IsMatchingNativeLayoutMethodSignature(Internal.Runtime.CompilerServices.RuntimeSignature):ubyte:this (FullOpts)
          78 (97.50% of base) : 5276.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          78 (97.50% of base) : 1652.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          76 (95.00% of base) : 19369.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          74 (97.37% of base) : 9656.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_Name():System.String:this (FullOpts)
          74 (97.37% of base) : 3933.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_Name():System.String:this (FullOpts)
          72 (90.00% of base) : 16771.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)

Top method improvements (bytes):
        -155 (-5.51% of base) : 7822.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions:TryParseConstantArray(Internal.Metadata.NativeFormat.Handle,Internal.Metadata.NativeFormat.MetadataReader,byref):System.Array (FullOpts)
        -155 (-5.51% of base) : 12689.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions:TryParseConstantArray(Internal.Metadata.NativeFormat.Handle,Internal.Metadata.NativeFormat.MetadataReader,byref):System.Array (FullOpts)
         -97 (-6.55% of base) : 13392.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions:TryParseConstantEnumArray(Internal.Metadata.NativeFormat.ConstantEnumArrayHandle,Internal.Metadata.NativeFormat.MetadataReader,byref):System.Array (FullOpts)
         -97 (-6.55% of base) : 8201.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions:TryParseConstantEnumArray(Internal.Metadata.NativeFormat.ConstantEnumArrayHandle,Internal.Metadata.NativeFormat.MetadataReader,byref):System.Array (FullOpts)
         -86 (-16.80% of base) : 974.dasm - System.Globalization.Ordinal:EqualsIgnoreCase_Vector[System.Runtime.Intrinsics.Vector128`1[ushort]](byref,byref,int):ubyte (FullOpts)
         -86 (-16.80% of base) : 4468.dasm - System.Globalization.Ordinal:EqualsIgnoreCase_Vector[System.Runtime.Intrinsics.Vector128`1[ushort]](byref,byref,int):ubyte (FullOpts)
         -72 (-14.91% of base) : 16160.dasm - System.Globalization.Ordinal:EqualsIgnoreCase_Vector[System.Runtime.Intrinsics.Vector128`1[ushort]](byref,byref,int):ubyte (FullOpts)
         -72 (-14.91% of base) : 21510.dasm - System.Globalization.Ordinal:EqualsIgnoreCase_Vector[System.Runtime.Intrinsics.Vector128`1[ushort]](byref,byref,int):ubyte (FullOpts)
         -70 (-13.04% of base) : 28031.dasm - System.SpanHelpers:<LastIndexOfValueType>g__SimdImpl|87_0[int,System.SpanHelpers+DontNegate`1[int],System.Runtime.Intrinsics.Vector512`1[int]](byref,int,int):int (FullOpts)
         -70 (-12.30% of base) : 27998.dasm - System.SpanHelpers:<LastIndexOfValueType>g__SimdImpl|87_0[long,System.SpanHelpers+DontNegate`1[long],System.Runtime.Intrinsics.Vector512`1[long]](byref,long,int):int (FullOpts)
         -70 (-12.73% of base) : 29539.dasm - System.SpanHelpers:<LastIndexOfValueType>g__SimdImpl|87_0[ubyte,System.SpanHelpers+DontNegate`1[ubyte],System.Runtime.Intrinsics.Vector512`1[ubyte]](byref,ubyte,int):int (FullOpts)
         -68 (-29.44% of base) : 31400.dasm - System.Enum:GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType):System.Array (FullOpts)
         -67 (-3.72% of base) : 7738.dasm - Internal.Runtime.TypeLoader.TypeBuilder:ParseNativeLayoutInfo(Internal.Runtime.TypeLoader.TypeBuilderState,Internal.TypeSystem.TypeDesc):this (FullOpts)
         -67 (-3.75% of base) : 13291.dasm - Internal.Runtime.TypeLoader.TypeBuilder:ParseNativeLayoutInfo(Internal.Runtime.TypeLoader.TypeBuilderState,Internal.TypeSystem.TypeDesc):this (FullOpts)
         -65 (-5.74% of base) : 11795.dasm - System.Linq.Expressions.Interpreter.LightCompiler:CompileStringSwitchExpression(System.Linq.Expressions.SwitchExpression):this (FullOpts)
         -64 (-18.55% of base) : 26655.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyLookup[System.Buffers.IndexOfAnyAsciiSearcher+Negate,System.Buffers.IndexOfAnyAsciiSearcher+Default](System.Runtime.Intrinsics.Vector256`1[short],System.Runtime.Intrinsics.Vector256`1[short],System.Runtime.Intrinsics.Vector256`1[ubyte]):System.Runtime.Intrinsics.Vector256`1[ubyte] (FullOpts)
         -63 (-21.50% of base) : 27215.dasm - System.SpanHelpers:IndexOf[uint](byref,uint,int):int (FullOpts)
         -61 (-18.54% of base) : 27677.dasm - System.PackedSpanHelpers:ComputeFirstIndexOverlapped(byref,byref,byref,System.Runtime.Intrinsics.Vector512`1[ubyte]):int (FullOpts)
         -61 (-22.85% of base) : 27649.dasm - System.PackedSpanHelpers:FixUpPackedVector512Result(System.Runtime.Intrinsics.Vector512`1[ubyte]):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
         -60 (-19.17% of base) : 27672.dasm - System.PackedSpanHelpers:ComputeFirstIndex(byref,byref,System.Runtime.Intrinsics.Vector512`1[ubyte]):int (FullOpts)

Top method regressions (percentages):
          29 (126.09% of base) : 31119.dasm - System.ReadOnlySpan`1[System.__Canon]:GetEnumerator():System.ReadOnlySpan`1+Enumerator[System.__Canon]:this (FullOpts)
          78 (97.50% of base) : 5276.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          78 (97.50% of base) : 1652.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          74 (97.37% of base) : 9656.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_Name():System.String:this (FullOpts)
          74 (97.37% of base) : 3933.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_Name():System.String:this (FullOpts)
          76 (95.00% of base) : 19369.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          72 (90.00% of base) : 16771.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          72 (90.00% of base) : 22094.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_NamespaceChain():System.Reflection.Runtime.General.NamespaceChain:this (FullOpts)
          43 (87.76% of base) : 5467.dasm - System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo:get_MetadataName():System.String:this (FullOpts)
          43 (87.76% of base) : 11414.dasm - System.Reflection.Runtime.PropertyInfos.NativeFormat.NativeFormatRuntimePropertyInfo:get_MetadataName():System.String:this (FullOpts)
          43 (87.76% of base) : 5500.dasm - System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:get_Name():System.String:this (FullOpts)
          43 (87.76% of base) : 11444.dasm - System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:get_Name():System.String:this (FullOpts)
          69 (82.14% of base) : 5507.dasm - System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:WithDebugName():System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:this (FullOpts)
          69 (82.14% of base) : 11448.dasm - System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:WithDebugName():System.Reflection.Runtime.PropertyInfos.RuntimePropertyInfo:this (FullOpts)
          27 (81.82% of base) : 7195.dasm - System.Reflection.Runtime.ParameterInfos.NativeFormat.NativeFormatMethodParameterInfo:get_Name():System.String:this (FullOpts)
          27 (81.82% of base) : 12019.dasm - System.Reflection.Runtime.ParameterInfos.NativeFormat.NativeFormatMethodParameterInfo:get_Name():System.String:this (FullOpts)
          27 (77.14% of base) : 27100.dasm - System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:get_MethodSignature():Internal.Metadata.NativeFormat.MethodSignature:this (FullOpts)
          37 (75.51% of base) : 11392.dasm - System.Reflection.Runtime.EventInfos.NativeFormat.NativeFormatRuntimeEventInfo:get_MetadataName():System.String:this (FullOpts)
          37 (75.51% of base) : 11408.dasm - System.Reflection.Runtime.EventInfos.RuntimeEventInfo:get_Name():System.String:this (FullOpts)
          37 (75.51% of base) : 5520.dasm - System.Reflection.Runtime.EventInfos.RuntimeEventInfo:get_Name():System.String:this (FullOpts)

Top method improvements (percentages):
         -46 (-64.79% of base) : 24821.dasm - System.Buffers.IndexOfAnyAsciiSearcher+Default:PackSources(System.Runtime.Intrinsics.Vector256`1[ushort],System.Runtime.Intrinsics.Vector256`1[ushort]):System.Runtime.Intrinsics.Vector256`1[ubyte] (FullOpts)
         -48 (-58.54% of base) : 26860.dasm - System.Runtime.Intrinsics.Vector512:AsByte[ulong](System.Runtime.Intrinsics.Vector512`1[ulong]):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
         -48 (-58.54% of base) : 27548.dasm - System.Runtime.Intrinsics.Vector512:AsInt16[ushort](System.Runtime.Intrinsics.Vector512`1[ushort]):System.Runtime.Intrinsics.Vector512`1[short] (FullOpts)
         -48 (-58.54% of base) : 29581.dasm - System.Runtime.Intrinsics.Vector512:AsInt64[ubyte](System.Runtime.Intrinsics.Vector512`1[ubyte]):System.Runtime.Intrinsics.Vector512`1[long] (FullOpts)
         -48 (-58.54% of base) : 27543.dasm - System.Runtime.Intrinsics.Vector512:Load[ushort](ulong):System.Runtime.Intrinsics.Vector512`1[ushort] (FullOpts)
         -48 (-58.54% of base) : 24895.dasm - System.Runtime.Intrinsics.Vector512:LoadUnsafe(byref):System.Runtime.Intrinsics.Vector512`1[ushort] (FullOpts)
         -48 (-58.54% of base) : 23692.dasm - System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
         -44 (-51.16% of base) : 25370.dasm - System.Runtime.Intrinsics.Vector512:LoadUnsafe(byref,ulong):System.Runtime.Intrinsics.Vector512`1[ushort] (FullOpts)
         -43 (-50.59% of base) : 23691.dasm - System.Runtime.Intrinsics.Vector512`1[ubyte]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.LoadUnsafe(byref,ulong):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
          -4 (-44.44% of base) : 6123.dasm - System.Double:System.IConvertible.ToSingle(System.IFormatProvider):float:this (FullOpts)
          -4 (-44.44% of base) : 11469.dasm - System.Double:System.IConvertible.ToSingle(System.IFormatProvider):float:this (FullOpts)
          -4 (-44.44% of base) : 11401.dasm - System.Reflection.Runtime.MethodInfos.RuntimeNamedMethodInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_RuntimeDeclaringType():System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo:this (FullOpts)
          -4 (-44.44% of base) : 4010.dasm - System.Reflection.Runtime.TypeInfos.RuntimeConstructedGenericTypeInfo:get_InternalRuntimeGenericTypeArguments():System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo[]:this (FullOpts)
          -4 (-44.44% of base) : 4009.dasm - System.Reflection.Runtime.TypeInfos.RuntimeConstructedGenericTypeInfo:get_InternalTypeHandleIfAvailable():System.RuntimeTypeHandle:this (FullOpts)
          -4 (-44.44% of base) : 16076.dasm - System.Reflection.Runtime.TypeInfos.RuntimeConstructedGenericTypeInfo:get_InternalTypeHandleIfAvailable():System.RuntimeTypeHandle:this (FullOpts)
          -4 (-44.44% of base) : 880.dasm - System.Reflection.Runtime.TypeInfos.RuntimeFunctionPointerTypeInfo:get_InternalTypeHandleIfAvailable():System.RuntimeTypeHandle:this (FullOpts)
          -4 (-44.44% of base) : 9704.dasm - System.Reflection.Runtime.TypeInfos.RuntimeFunctionPointerTypeInfo:get_IsUnmanagedFunctionPointer():ubyte:this (FullOpts)
          -4 (-44.44% of base) : 21443.dasm - System.Reflection.Runtime.TypeInfos.RuntimeHasElementTypeInfo:get_InternalTypeHandleIfAvailable():System.RuntimeTypeHandle:this (FullOpts)
          -4 (-44.44% of base) : 18723.dasm - System.Reflection.Runtime.TypeInfos.RuntimeHasElementTypeInfo:get_InternalTypeHandleIfAvailable():System.RuntimeTypeHandle:this (FullOpts)
          -4 (-44.44% of base) : 9103.dasm - System.Single:System.IConvertible.ToDouble(System.IFormatProvider):double:this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
