Diffs are based on <span style="color:#1460aa">2,450,563</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,495,269</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitDoRangeAnalysis=0


<details>
<summary>Overall (<span style="color:green">-711,109</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,443,296|<span style="color:green">-26,364</span>|<span style="color:green">-3.46%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,491,760|<span style="color:green">-34,747</span>|<span style="color:green">-2.81%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,718,511|<span style="color:green">-7,268</span>|<span style="color:green">-3.65%</span>|
|coreclr_tests.run.windows.x64.checked.mch|386,883,600|<span style="color:green">-71,501</span>|<span style="color:green">-4.19%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,138,944|<span style="color:green">-39,851</span>|<span style="color:green">-2.69%</span>|
|libraries.pmi.windows.x64.checked.mch|61,513,553|<span style="color:green">-75,169</span>|<span style="color:green">-3.19%</span>|
|libraries_tests.run.windows.x64.Release.mch|285,321,424|<span style="color:green">-296,057</span>|<span style="color:green">-2.15%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|136,504,381|<span style="color:green">-121,019</span>|<span style="color:green">-2.48%</span>|
|realworld.run.windows.x64.checked.mch|14,000,976|<span style="color:green">-21,040</span>|<span style="color:green">-2.90%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,135,469|<span style="color:green">-18,093</span>|<span style="color:green">-3.79%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-711,109</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,442,936|<span style="color:green">-26,364</span>|<span style="color:green">-3.46%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,589,136|<span style="color:green">-34,747</span>|<span style="color:green">-2.81%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,485,728|<span style="color:green">-7,268</span>|<span style="color:green">-3.65%</span>|
|coreclr_tests.run.windows.x64.checked.mch|106,440,451|<span style="color:green">-71,501</span>|<span style="color:green">-4.19%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,137,757|<span style="color:green">-39,851</span>|<span style="color:green">-2.69%</span>|
|libraries.pmi.windows.x64.checked.mch|61,400,059|<span style="color:green">-75,169</span>|<span style="color:green">-3.19%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,674,405|<span style="color:green">-296,057</span>|<span style="color:green">-2.15%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|126,211,502|<span style="color:green">-121,019</span>|<span style="color:green">-2.48%</span>|
|realworld.run.windows.x64.checked.mch|13,614,808|<span style="color:green">-21,040</span>|<span style="color:green">-2.90%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,134,522|<span style="color:green">-18,093</span>|<span style="color:green">-3.79%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 27052.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,23 +8,23 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  5,  8   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  5,  8   )   byref  ->  rcx         this single-def
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T04] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
+;  V04 tmp1         [V04,T03] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
 ;* V05 tmp2         [V05    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T01] (  4, 13   )     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T02] (  2,  8   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T05] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T03] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -38,23 +38,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=4 PerfScore 33.00
+						;; size=12 bbWeight=4 PerfScore 26.00
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -63,15 +59,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 45.25, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
+; Total bytes of code 40, prolog size 4, PerfScore 38.00, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-20</span> (<span style="color:green">-29.41%</span>) : 10576.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,17 +9,17 @@
 ;
 ;  V00 arg0         [V00,T00] (  6,  4.50)     ref  ->  rcx         class-hnd single-def <System.String>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  5,  3.50)     int  ->  rdx         "CSE - aggressive"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M58937_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M58937_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M58937_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      edx, dword ptr [rcx+0x08]
-       cmp      edx, 3
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, 3
        jge      SHORT G_M58937_IG05
 						;; size=8 bbWeight=1 PerfScore 3.25
 G_M58937_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
@@ -32,32 +32,20 @@ G_M58937_IG04:        ; bbWeight=0.50, epilog, nogc, extend
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M58937_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx]
-       test     edx, edx
-       je       SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0C], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 1
-       jbe      SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0E], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 2
-       jbe      SHORT G_M58937_IG07
        xor      eax, eax
        cmp      word  ptr [rcx+0x10], 95
        setne    al
-						;; size=38 bbWeight=0.50 PerfScore 8.00
+						;; size=24 bbWeight=0.50 PerfScore 6.12
 G_M58937_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M58937_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 68, prolog size 4, PerfScore 12.88, instruction count 24, allocated bytes for code 68 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
+; Total bytes of code 48, prolog size 4, PerfScore 11.00, instruction count 16, allocated bytes for code 48 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-20</span> (<span style="color:green">-29.41%</span>) : 18941.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,17 +9,17 @@
 ;
 ;  V00 arg0         [V00,T00] (  6,  4.50)     ref  ->  rcx         class-hnd single-def <System.String>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  5,  3.50)     int  ->  rdx         "CSE - aggressive"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M58937_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M58937_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M58937_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      edx, dword ptr [rcx+0x08]
-       cmp      edx, 3
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, 3
        jge      SHORT G_M58937_IG05
 						;; size=8 bbWeight=1 PerfScore 3.25
 G_M58937_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
@@ -32,32 +32,20 @@ G_M58937_IG04:        ; bbWeight=0.50, epilog, nogc, extend
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M58937_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx]
-       test     edx, edx
-       je       SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0C], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 1
-       jbe      SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0E], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 2
-       jbe      SHORT G_M58937_IG07
        xor      eax, eax
        cmp      word  ptr [rcx+0x10], 95
        setne    al
-						;; size=38 bbWeight=0.50 PerfScore 8.00
+						;; size=24 bbWeight=0.50 PerfScore 6.12
 G_M58937_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M58937_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 68, prolog size 4, PerfScore 12.88, instruction count 24, allocated bytes for code 68 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
+; Total bytes of code 48, prolog size 4, PerfScore 11.00, instruction count 16, allocated bytes for code 48 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-0.09%</span>) : 16197.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,8 +16,8 @@
 ;* V05 arg5         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Globalization.CultureInfo>
 ;  V06 arg6         [V06,T107] (  6,  7   )     ref  ->  [rbp+0x40]  class-hnd single-def <System.String[]>
 ;  V07 arg7         [V07,T136] (  3,  2   )   byref  ->  [rbp+0x48]  single-def
-;  V08 loc0         [V08,T16] ( 54, 58.41)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
-;  V09 loc1         [V09,T01] (122,226.53)     int  ->  [rbp-0x3C] 
+;  V08 loc0         [V08,T16] ( 53, 58.37)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
+;  V09 loc1         [V09,T01] (121,226.49)     int  ->  [rbp-0x3C] 
 ;  V10 loc2         [V10,T00] (110,467.32)     int  ->  [rbp-0x40] 
 ;  V11 loc3         [V11,T12] ( 57, 67.80)     ref  ->  r13         class-hnd exact single-def <<unknown class>>
 ;  V12 loc4         [V12,T29] ( 37, 36.27)     ref  ->  r12         class-hnd exact single-def <System.Type[]>
@@ -401,8 +401,6 @@ G_M46529_IG16:        ; bbWeight=1.98, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4
        jmp      G_M46529_IG29
 						;; size=5 bbWeight=1.98 PerfScore 3.96
 G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4008 {rbx r14}, byref, isz
-       cmp      r12d, dword ptr [r15+0x08]
-       jae      G_M46529_IG228
        mov      ecx, r12d
        mov      rcx, gword ptr [r15+8*rcx+0x10]
        ; gcrRegs +[rcx]
@@ -417,7 +415,7 @@ G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4
        ; gcrRegs +[rcx]
        cmp      edx, dword ptr [rcx+0x08]
        jg       SHORT G_M46529_IG19
-						;; size=43 bbWeight=0.04 PerfScore 0.83
+						;; size=33 bbWeight=0.04 PerfScore 0.67
 G_M46529_IG18:        ; bbWeight=0.02, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4008 {rbx r14}, byref, isz
        ; gcrRegs -[rcx]
        mov      rdx, gword ptr [rbx]
@@ -4333,7 +4331,7 @@ G_M46529_IG241:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 10607, prolog size 77, PerfScore 6135.68, instruction count 2471, allocated bytes for code 10607 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
+; Total bytes of code 10597, prolog size 77, PerfScore 6135.52, instruction count 2469, allocated bytes for code 10597 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-0.09%</span>) : 1859.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,8 +16,8 @@
 ;* V05 arg5         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Globalization.CultureInfo>
 ;  V06 arg6         [V06,T107] (  6,  7   )     ref  ->  [rbp+0x40]  class-hnd single-def <System.String[]>
 ;  V07 arg7         [V07,T136] (  3,  2   )   byref  ->  [rbp+0x48]  single-def
-;  V08 loc0         [V08,T16] ( 54, 58.41)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
-;  V09 loc1         [V09,T01] (122,226.53)     int  ->  [rbp-0x3C] 
+;  V08 loc0         [V08,T16] ( 53, 58.37)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
+;  V09 loc1         [V09,T01] (121,226.49)     int  ->  [rbp-0x3C] 
 ;  V10 loc2         [V10,T00] (110,467.32)     int  ->  [rbp-0x40] 
 ;  V11 loc3         [V11,T12] ( 57, 67.80)     ref  ->  r13         class-hnd exact single-def <<unknown class>>
 ;  V12 loc4         [V12,T29] ( 37, 36.27)     ref  ->  r12         class-hnd exact single-def <System.Type[]>
@@ -401,8 +401,6 @@ G_M46529_IG16:        ; bbWeight=1.98, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4
        jmp      G_M46529_IG29
 						;; size=5 bbWeight=1.98 PerfScore 3.96
 G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4008 {rbx r14}, byref, isz
-       cmp      r12d, dword ptr [r15+0x08]
-       jae      G_M46529_IG228
        mov      ecx, r12d
        mov      rcx, gword ptr [r15+8*rcx+0x10]
        ; gcrRegs +[rcx]
@@ -417,7 +415,7 @@ G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4
        ; gcrRegs +[rcx]
        cmp      edx, dword ptr [rcx+0x08]
        jg       SHORT G_M46529_IG19
-						;; size=43 bbWeight=0.04 PerfScore 0.83
+						;; size=33 bbWeight=0.04 PerfScore 0.67
 G_M46529_IG18:        ; bbWeight=0.02, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4008 {rbx r14}, byref, isz
        ; gcrRegs -[rcx]
        mov      rdx, gword ptr [rbx]
@@ -4333,7 +4331,7 @@ G_M46529_IG241:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 10608, prolog size 78, PerfScore 6135.68, instruction count 2471, allocated bytes for code 10608 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
+; Total bytes of code 10598, prolog size 78, PerfScore 6135.52, instruction count 2469, allocated bytes for code 10598 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary>+0 (0.00%) : 25682.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,7 +22,7 @@
 ;  V11 arg10        [V11,T39] (  5,  5   )   byref  ->  r15         single-def
 ;  V12 loc0         [V12,T13] (  6, 20.50)     ref  ->  [rbp-0x80]  class-hnd exact spill-single-def <<unknown class>>
 ;  V13 loc1         [V13,T33] (  6,  6.98)   ubyte  ->  [rbp-0x44] 
-;  V14 loc2         [V14,T12] ( 17, 21.10)     int  ->  [rbp-0x48] 
+;  V14 loc2         [V14,T12] ( 16, 21.06)     int  ->  [rbp-0x48] 
 ;* V15 loc3         [V15    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]>
 ;  V16 loc4         [V16,T47] (  4,  4   )     int  ->   r8        
 ;  V17 loc5         [V17,T48] (  4,  4   )     int  ->  [rbp-0x4C] 
@@ -118,7 +118,7 @@
 ;  V107 cse4        [V107,T16] (  7, 17.82)    long  ->  [rbp-0x70]  spill-single-def "CSE - moderate"
 ;  V108 cse5        [V108,T38] (  3,  5.94)     ref  ->  rdx         "CSE - moderate"
 ;  V109 cse6        [V109,T62] (  3,  0.06)     ref  ->  rdx         "CSE - conservative"
-;  V110 cse7        [V110,T27] (  8,  8.54)     int  ->  [rbp-0x74]  spill-single-def "CSE - moderate"
+;  V110 cse7        [V110,T27] (  7,  8.50)     int  ->  [rbp-0x74]  spill-single-def "CSE - moderate"
 ;  V111 cse8        [V111,T15] ( 18, 18   )     ref  ->  rdx         multi-def "CSE - moderate"
 ;  V112 rat0        [V112,T52] (  3,  2.80)    long  ->  r11         "fgMakeTemp is creating a new local variable"
 ;  V113 rat1        [V113,T55] (  3,  1   )    long  ->  rsi         "runtime lookup"
@@ -498,10 +498,9 @@ G_M44622_IG19:        ; bbWeight=1.98, gcrefRegs=00C0 {rsi rdi}, byrefRegs=9000
 G_M44622_IG20:        ; bbWeight=3.96, gcVars=0000000000002000 {V12}, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref
        ; GC ptr vars -{V01}
        inc      r11d
-       mov      r9d, dword ptr [rbp-0x74]
-       cmp      r9d, r11d
+       cmp      dword ptr [rbp-0x74], r11d
        jg       G_M44622_IG07
-						;; size=16 bbWeight=3.96 PerfScore 9.90
+						;; size=13 bbWeight=3.96 PerfScore 12.87
 G_M44622_IG21:        ; bbWeight=1.98, gcrefRegs=2040 {rsi r13}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        ; byrRegs -[r12 r15]
@@ -512,14 +511,12 @@ G_M44622_IG21:        ; bbWeight=1.98, gcrefRegs=2040 {rsi r13}, byrefRegs=0000
 G_M44622_IG22:        ; bbWeight=0.04, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, byref
        ; gcrRegs -[rax] +[rdi]
        ; byrRegs +[r12 r15]
-       cmp      r11d, r9d
-       jae      G_M44622_IG63
        mov      ecx, r11d
        shl      rcx, 5
        mov      r8d, dword ptr [rsi+rcx+0x10]
        test     r8d, r8d
        je       G_M44622_IG25
-						;; size=30 bbWeight=0.04 PerfScore 0.21
+						;; size=21 bbWeight=0.04 PerfScore 0.16
 G_M44622_IG23:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, byref, isz
        mov      ecx, r11d
        shl      rcx, 5
@@ -528,7 +525,7 @@ G_M44622_IG23:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9
        mov      bword ptr [rbp-0xD0], rdx
        ; GC ptr vars +{V105}
        cmp      byte  ptr [rdx+0x04], 1
-       jne      SHORT G_M44622_IG26
+       jne      G_M44622_IG26
        mov      gword ptr [rbp+0x18], r13
        ; GC ptr vars +{V01}
        mov      rcx, bword ptr [rbp+0x58]
@@ -564,20 +561,22 @@ G_M44622_IG23:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9
        ; gcr arg pop 0
        mov      rax, gword ptr [rbp-0x80]
        ; gcrRegs +[rax]
+       mov      r9d, dword ptr [rbp-0x74]
        mov      r11d, dword ptr [rbp-0x48]
        mov      r13, gword ptr [rbp+0x18]
        ; gcrRegs +[r13]
        jmp      G_M44622_IG34
-						;; size=118 bbWeight=0.02 PerfScore 0.69
+						;; size=126 bbWeight=0.02 PerfScore 0.71
 G_M44622_IG24:        ; bbWeight=0.01, gcrefRegs=00C0 {rsi rdi}, byrefRegs=9000 {r12 r15}, byref
        ; gcrRegs -[rax r13]
        mov      rax, gword ptr [rbp-0x80]
        ; gcrRegs +[rax]
+       mov      r9d, dword ptr [rbp-0x74]
        mov      r11d, dword ptr [rbp-0x48]
        mov      r13, gword ptr [rbp+0x18]
        ; gcrRegs +[r13]
        jmp      G_M44622_IG34
-						;; size=17 bbWeight=0.01 PerfScore 0.05
+						;; size=21 bbWeight=0.01 PerfScore 0.06
 G_M44622_IG25:        ; bbWeight=0.02, gcVars=0000000000002000 {V12}, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V01}
@@ -774,15 +773,15 @@ G_M44622_IG33:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9
        mov      dword ptr [rbp-0x44], eax
        mov      rax, gword ptr [rbp-0x80]
        ; gcrRegs +[rax]
+       mov      r9d, dword ptr [rbp-0x74]
        mov      r11d, dword ptr [rbp-0x48]
-						;; size=41 bbWeight=0.02 PerfScore 0.20
+						;; size=45 bbWeight=0.02 PerfScore 0.22
 G_M44622_IG34:        ; bbWeight=0.04, gcVars=0000000000002000 {V12}, gcrefRegs=20C1 {rax rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref, isz
        ; GC ptr vars -{V105}
        inc      r11d
-       mov      r9d, dword ptr [rbp-0x74]
        cmp      r9d, r11d
        jg       SHORT G_M44622_IG40
-						;; size=12 bbWeight=0.04 PerfScore 0.10
+						;; size=8 bbWeight=0.04 PerfScore 0.06
 G_M44622_IG35:        ; bbWeight=1.98, gcrefRegs=2041 {rax rsi r13}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rdi]
        ; byrRegs -[r12 r15]
@@ -1073,7 +1072,7 @@ G_M44622_IG67:        ; bbWeight=0, funclet epilog, nogc, extend
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 2125, prolog size 73, PerfScore 1187.68, instruction count 505, allocated bytes for code 2125 (MethodHash=1e0151b1) for method Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)
+; Total bytes of code 2125, prolog size 73, PerfScore 1190.61, instruction count 504, allocated bytes for code 2125 (MethodHash=1e0151b1) for method Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-13</span> (<span style="color:green">-28.89%</span>) : 51977.dasm - System.Text.Json.JsonWriterHelper:NeedsEscaping(ubyte):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,33 +16,26 @@
 ;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V06 tmp4         [V06    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V03._reference (fldOffset=0x0)" P-INDEP
 ;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "field V03._length (fldOffset=0x8)" P-INDEP
-;  V08 cse0         [V08,T01] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V08 cse0         [V08,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
 G_M29625_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M29625_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M29625_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, cl
-       cmp      eax, 256
-       jae      SHORT G_M29625_IG04
        mov      rcx, 0xD1FFAB1E      ; static handle
        cmp      byte  ptr [rax+rcx], 0
        sete     al
        movzx    rax, al
-						;; size=30 bbWeight=1 PerfScore 6.00
+						;; size=23 bbWeight=1 PerfScore 4.75
 G_M29625_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M29625_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 45, prolog size 4, PerfScore 7.50, instruction count 12, allocated bytes for code 45 (MethodHash=ce598c46) for method System.Text.Json.JsonWriterHelper:NeedsEscaping(ubyte):ubyte (Tier1)
+; Total bytes of code 32, prolog size 4, PerfScore 6.25, instruction count 8, allocated bytes for code 32 (MethodHash=ce598c46) for method System.Text.Json.JsonWriterHelper:NeedsEscaping(ubyte):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-24</span> (<span style="color:green">-27.27%</span>) : 41510.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  6,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  3   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  6,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rax         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;
 ; Lcl frame size = 40
@@ -23,53 +23,40 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; byrRegs +[rcx]
        mov      rdx, bword ptr [rcx]
        ; byrRegs +[rdx]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       cmp      ecx, 4
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, 4
        jl       SHORT G_M54145_IG03
-       test     ecx, ecx
-       je       SHORT G_M54145_IG05
        cmp      word  ptr [rdx], 92
-       je       SHORT G_M54145_IG06
-						;; size=21 bbWeight=1 PerfScore 10.50
+       je       SHORT G_M54145_IG05
+						;; size=17 bbWeight=1 PerfScore 9.25
 G_M54145_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rdx]
+       ; byrRegs -[rcx rdx]
        xor      eax, eax
 						;; size=2 bbWeight=1 PerfScore 0.25
 G_M54145_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M54145_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M54145_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
+G_M54145_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, gcvars, byref, isz
        ; byrRegs +[rdx]
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG05
        cmp      word  ptr [rdx+0x02], 92
-       je       SHORT G_M54145_IG07
+       je       SHORT G_M54145_IG06
        cmp      word  ptr [rdx+0x02], 63
        jne      SHORT G_M54145_IG03
-						;; size=19 bbWeight=0 PerfScore 0.00
-G_M54145_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG05
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M54145_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
        cmp      word  ptr [rdx+0x04], 63
        jne      SHORT G_M54145_IG03
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG05
        xor      eax, eax
        cmp      word  ptr [rdx+0x06], 92
        sete     al
-						;; size=27 bbWeight=0 PerfScore 0.00
-G_M54145_IG08:        ; bbWeight=0, epilog, nogc, extend
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M54145_IG07:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 88, prolog size 4, PerfScore 12.25, instruction count 30, allocated bytes for code 88 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
+; Total bytes of code 64, prolog size 4, PerfScore 11.00, instruction count 21, allocated bytes for code 64 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-24</span> (<span style="color:green">-27.27%</span>) : 44934.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  6,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  3   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  6,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rax         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;
 ; Lcl frame size = 40
@@ -23,53 +23,40 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; byrRegs +[rcx]
        mov      rdx, bword ptr [rcx]
        ; byrRegs +[rdx]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; byrRegs -[rcx]
-       cmp      ecx, 4
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, 4
        jl       SHORT G_M54145_IG03
-       test     ecx, ecx
-       je       SHORT G_M54145_IG05
        cmp      word  ptr [rdx], 92
-       je       SHORT G_M54145_IG06
-						;; size=21 bbWeight=1 PerfScore 10.50
+       je       SHORT G_M54145_IG05
+						;; size=17 bbWeight=1 PerfScore 9.25
 G_M54145_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rdx]
+       ; byrRegs -[rcx rdx]
        xor      eax, eax
 						;; size=2 bbWeight=1 PerfScore 0.25
 G_M54145_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M54145_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M54145_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
+G_M54145_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, gcvars, byref, isz
        ; byrRegs +[rdx]
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG05
        cmp      word  ptr [rdx+0x02], 92
-       je       SHORT G_M54145_IG07
+       je       SHORT G_M54145_IG06
        cmp      word  ptr [rdx+0x02], 63
        jne      SHORT G_M54145_IG03
-						;; size=19 bbWeight=0 PerfScore 0.00
-G_M54145_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG05
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M54145_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
        cmp      word  ptr [rdx+0x04], 63
        jne      SHORT G_M54145_IG03
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG05
        xor      eax, eax
        cmp      word  ptr [rdx+0x06], 92
        sete     al
-						;; size=27 bbWeight=0 PerfScore 0.00
-G_M54145_IG08:        ; bbWeight=0, epilog, nogc, extend
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M54145_IG07:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 88, prolog size 4, PerfScore 12.25, instruction count 30, allocated bytes for code 88 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
+; Total bytes of code 64, prolog size 4, PerfScore 11.00, instruction count 21, allocated bytes for code 64 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-0.09%</span>) : 24118.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,10 +9,10 @@
 ; 69 inlinees with PGO data; 92 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T144] (  3,   3   )    long  ->  rcx         single-def
-;  V01 arg1         [V01,T145] (  3,   3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T146] (  3,   3   )     int  ->   r8         single-def
-;  V03 arg3         [V03,T143] (  4,   3   )   ubyte  ->  rbx         single-def
+;  V00 arg0         [V00,T143] (  3,   3   )    long  ->  rcx         single-def
+;  V01 arg1         [V01,T144] (  3,   3   )     int  ->  rdx         single-def
+;  V02 arg2         [V02,T145] (  3,   3   )     int  ->   r8         single-def
+;  V03 arg3         [V03,T142] (  4,   3   )   ubyte  ->  rbx         single-def
 ;  V04 arg4         [V04,T220] (  1,   1   )     int  ->  [rsp+0x1590]  single-def ptr
 ;  V05 arg5         [V05,T218] (  3,   1   )   ubyte  ->  [rsp+0x1598]  single-def
 ;  V06 arg6         [V06,T188] (  1,   2   )   byref  ->  rax         ld-addr-op single-def
@@ -27,11 +27,11 @@
 ;  V15 loc7         [V15,T116] (  3,  18.41)   ubyte  ->  [rsp+0x150C]  ptr
 ;  V16 loc8         [V16,T186] (  2,   2   )   ubyte  ->  rcx        
 ;  V17 loc9         [V17,T117] (  9,  17.48)     int  ->  [rsp+0x1508]  ptr
-;  V18 loc10        [V18,T152] (  5,   4.15)     int  ->  [rsp+0x1504]  spill-single-def ptr
+;  V18 loc10        [V18,T151] (  5,   4.15)     int  ->  [rsp+0x1504]  spill-single-def ptr
 ;  V19 loc11        [V19,T90] (  5,  33.86)   ubyte  ->  registers   ptr
 ;  V20 loc12        [V20,T91] (  5,  33.86)   ubyte  ->  registers   ptr
 ;  V21 loc13        [V21,T67] ( 17,  49.89)     int  ->  rdi        
-;  V22 loc14        [V22,T157] (  5,   3.79)   ubyte  ->  r14        
+;  V22 loc14        [V22,T156] (  5,   3.79)   ubyte  ->  r14        
 ;* V23 loc15        [V23    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;  V24 loc16        [V24    ] (  3,   0   )  struct (464) [rsp+0x1F8]  do-not-enreg[XS] addr-exposed ld-addr-op unsafe-buffer <System.Number+BigInteger>
 ;  V25 loc17        [V25    ] ( 10,  33.76)  struct (464) [rsp+0xCD8]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer <System.Number+BigInteger>
@@ -45,7 +45,7 @@
 ;* V33 loc25        [V33    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;  V34 tmp0         [V34,T221] (  1,   1   )     int  ->  [rsp+0x14F8]  do-not-enreg[V] "GSCookie dummy"
 ;  V35 OutArgs      [V35    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V36 tmp2         [V36,T156] (  2,   4   )     int  ->  rbp         "dup spill"
+;  V36 tmp2         [V36,T155] (  2,   4   )     int  ->  rbp         "dup spill"
 ;  V37 tmp3         [V37,T202] (  2,   1.15)     int  ->  rcx        
 ;  V38 tmp4         [V38,T241] (  3,   0   )     int  ->  rcx        
 ;  V39 tmp5         [V39,T231] (  4,   0.02)     int  ->  rdx        
@@ -73,7 +73,7 @@
 ;  V61 tmp27        [V61,T134] (  5,   6.19)    long  ->  rdx         "Inlining Arg"
 ;* V62 tmp28        [V62    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V63 tmp29        [V63,T195] (  2,   1.94)     int  ->  rbx         ld-addr-op "Inline ldloca(s) first use temp"
-;  V64 tmp30        [V64,T147] (  5,   4.86)     int  ->  [rsp+0x14E8]  spill-single-def ptr "Inline stloc first use temp"
+;  V64 tmp30        [V64,T146] (  5,   4.86)     int  ->  [rsp+0x14E8]  spill-single-def ptr "Inline stloc first use temp"
 ;* V65 tmp31        [V65    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V66 tmp32        [V66    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V67 tmp33        [V67    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
@@ -89,7 +89,7 @@
 ;* V77 tmp43        [V77    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[uint]>
 ;  V78 tmp44        [V78    ] (  4,   2.70)  struct (464) [rsp+0x768]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V79 tmp45        [V79,T70] (  6,  46.75)     int  ->  [rsp+0x14E4]  ptr "Inlining Arg"
-;  V80 tmp46        [V80,T140] (  3,   5.39)     int  ->  rcx         "Span.get_Item index"
+;  V80 tmp46        [V80,T165] (  2,   3.60)     int  ->  rcx         "Span.get_Item index"
 ;  V81 tmp47        [V81,T121] ( 11,  16.18)   byref  ->  [rsp+0x1448]  ptr "Inline stloc first use temp"
 ;  V82 tmp48        [V82    ] (  2,   1.80)  struct (464) [rsp+0x28]  do-not-enreg[XSF] addr-exposed ld-addr-op unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V83 tmp49        [V83,T31] ( 13, 209.68)   byref  ->  [rsp+0x1440]  ptr "Inline stloc first use temp"
@@ -98,12 +98,12 @@
 ;  V86 tmp52        [V86    ] (  4,   8.99)   byref  ->  [rsp+0x14D8]  must-init pinned ptr "Inline stloc first use temp"
 ;* V87 tmp53        [V87    ] (  0,   0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;  V88 tmp54        [V88,T129] (  6,   8.09)   byref  ->   r8         "Inline stloc first use temp"
-;  V89 tmp55        [V89,T142] (  2,   5.39)   byref  ->  r10         "Inline stloc first use temp"
+;  V89 tmp55        [V89,T141] (  2,   5.39)   byref  ->  r10         "Inline stloc first use temp"
 ;* V90 tmp56        [V90    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
 ;* V91 tmp57        [V91    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
 ;* V92 tmp58        [V92    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V93 tmp59        [V93    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
-;  V94 tmp60        [V94,T141] (  3,   5.39)     int  ->  rcx         "Inlining Arg"
+;  V94 tmp60        [V94,T140] (  3,   5.39)     int  ->  rcx         "Inlining Arg"
 ;* V95 tmp61        [V95    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
 ;* V96 tmp62        [V96    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
 ;  V97 tmp63        [V97,T33] (  5, 195.98)   byref  ->  [rsp+0x1438]  ptr "Inline stloc first use temp"
@@ -127,20 +127,20 @@
 ;  V115 tmp81       [V115,T128] (  5,   8.63)    long  ->   r8         "Inlining Arg"
 ;* V116 tmp82       [V116    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V117 tmp83       [V117,T178] (  3,   2.70)     int  ->  rcx         "Inline stloc first use temp"
-;  V118 tmp84       [V118,T162] (  3,   3.60)   byref  ->  rdx         single-def "Inlining Arg"
+;  V118 tmp84       [V118,T161] (  3,   3.60)   byref  ->  rdx         single-def "Inlining Arg"
 ;  V119 tmp85       [V119,T166] (  2,   3.60)    long  ->   r8         "Inlining Arg"
-;  V120 tmp86       [V120,T163] (  3,   3.60)   byref  ->  rcx         single-def "spilling arg"
-;  V121 tmp87       [V121,T149] (  3,   4.49)    long  ->   r8         "spilling arg"
+;  V120 tmp86       [V120,T162] (  3,   3.60)   byref  ->  rcx         single-def "spilling arg"
+;  V121 tmp87       [V121,T148] (  3,   4.49)    long  ->   r8         "spilling arg"
 ;  V122 tmp88       [V122    ] ( 10,   5.39)  struct (464) [rsp+0x598]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V123 tmp89       [V123,T179] (  3,   2.70)     int  ->  rcx         "Inline stloc first use temp"
 ;  V124 tmp90       [V124,T167] (  2,   3.60)    long  ->   r8         "Inlining Arg"
-;  V125 tmp91       [V125,T164] (  3,   3.60)   byref  ->  rcx         single-def "spilling arg"
-;  V126 tmp92       [V126,T165] (  3,   3.60)   byref  ->  rdx         single-def "spilling arg"
-;  V127 tmp93       [V127,T150] (  3,   4.49)    long  ->   r8         "spilling arg"
+;  V125 tmp91       [V125,T163] (  3,   3.60)   byref  ->  rcx         single-def "spilling arg"
+;  V126 tmp92       [V126,T164] (  3,   3.60)   byref  ->  rdx         single-def "spilling arg"
+;  V127 tmp93       [V127,T149] (  3,   4.49)    long  ->   r8         "spilling arg"
 ;  V128 tmp94       [V128,T54] (  4,  64.88)   byref  ->  [rsp+0x1430]  ptr "Inline stloc first use temp"
 ;  V129 tmp95       [V129,T92] (  5,  33.79)     int  ->  [rsp+0x14C4]  ptr "Inline stloc first use temp"
 ;  V130 tmp96       [V130,T87] (  5,  36.48)   byref  ->  [rsp+0x1428]  ptr "Inline stloc first use temp"
-;  V131 tmp97       [V131,T153] (  6,   4.04)     int  ->  [rsp+0x14C0]  ptr "Inline stloc first use temp"
+;  V131 tmp97       [V131,T152] (  6,   4.04)     int  ->  [rsp+0x14C0]  ptr "Inline stloc first use temp"
 ;  V132 tmp98       [V132,T176] (  6,   2.70)     int  ->  [rsp+0x14BC]  spill-single-def ptr "Inline stloc first use temp"
 ;  V133 tmp99       [V133,T84] (  6,  39.62)     int  ->  rcx         "Inline stloc first use temp"
 ;  V134 tmp100      [V134,T138] (  4,   5.61)     int  ->  [rsp+0x14B8]  ptr "Inline stloc first use temp"
@@ -169,7 +169,7 @@
 ;  V157 tmp123      [V157,T213] (  3,   1.56)    long  ->  rdx         "Inline stloc first use temp"
 ;  V158 tmp124      [V158,T243] (  3,   0   )     int  ->  rcx        
 ;  V159 tmp125      [V159,T191] (  5,   1.98)     int  ->  rdx         "Inline return value spill temp"
-;  V160 tmp126      [V160,T161] (  4,   3.65)     int  ->  rcx         "Inline stloc first use temp"
+;  V160 tmp126      [V160,T160] (  4,   3.65)     int  ->  rcx         "Inline stloc first use temp"
 ;  V161 tmp127      [V161,T192] (  3,   1.98)     int  ->  r13         "Inline stloc first use temp"
 ;  V162 tmp128      [V162,T184] (  3,   2.13)     int  ->  rdx         "Inline stloc first use temp"
 ;  V163 tmp129      [V163,T136] (  7,   5.84)     int  ->  rcx         "Inline stloc first use temp"
@@ -200,7 +200,7 @@
 ;* V188 tmp154      [V188    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V189 tmp155      [V189    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V190 tmp156      [V190    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
-;  V191 tmp157      [V191,T158] (  5,   3.65)    long  ->  rdx         "Inlining Arg"
+;  V191 tmp157      [V191,T157] (  5,   3.65)    long  ->  rdx         "Inlining Arg"
 ;* V192 tmp158      [V192    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V193 tmp159      [V193,T204] (  3,   1.72)     int  ->   r8         "Inline stloc first use temp"
 ;  V194 tmp160      [V194,T124] (  5,  15.05)     int  ->  [rsp+0x1498]  ld-addr-op spill-single-def ptr "Inline ldloca(s) first use temp"
@@ -217,7 +217,7 @@
 ;* V205 tmp171      [V205    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V206 tmp172      [V206    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V207 tmp173      [V207    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
-;  V208 tmp174      [V208,T159] (  5,   3.65)    long  ->  rdx         "Inlining Arg"
+;  V208 tmp174      [V208,T158] (  5,   3.65)    long  ->  rdx         "Inlining Arg"
 ;* V209 tmp175      [V209    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V210 tmp176      [V210,T205] (  3,   1.72)     int  ->   r8         "Inline stloc first use temp"
 ;  V211 tmp177      [V211,T125] (  5,  15.05)     int  ->  [rsp+0x1484]  ld-addr-op spill-single-def ptr "Inline ldloca(s) first use temp"
@@ -234,7 +234,7 @@
 ;* V222 tmp188      [V222    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V223 tmp189      [V223    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V224 tmp190      [V224    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
-;  V225 tmp191      [V225,T160] (  5,   3.65)    long  ->  rdx         "Inlining Arg"
+;  V225 tmp191      [V225,T159] (  5,   3.65)    long  ->  rdx         "Inlining Arg"
 ;* V226 tmp192      [V226    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V227 tmp193      [V227    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V228 tmp194      [V228    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -322,7 +322,7 @@
 ;  V310 tmp276      [V310,T172] (  4,   2.91)     int  ->  rcx         "Inline stloc first use temp"
 ;  V311 tmp277      [V311,T210] (  3,   1.58)     int  ->  rax         "Inline stloc first use temp"
 ;  V312 tmp278      [V312,T209] (  3,   1.70)     int  ->  rdx         "Inline stloc first use temp"
-;  V313 tmp279      [V313,T148] (  7,   4.67)     int  ->  rcx         "Inline stloc first use temp"
+;  V313 tmp279      [V313,T147] (  7,   4.67)     int  ->  rcx         "Inline stloc first use temp"
 ;  V314 tmp280      [V314,T189] (  3,   2.00)    long  ->  rdx         "Inline stloc first use temp"
 ;* V315 tmp281      [V315    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V316 tmp282      [V316    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -352,7 +352,7 @@
 ;  V340 tmp306      [V340,T233] (  2,   0.01)    long  ->  rcx         "argument with side effect"
 ;  V341 tmp307      [V341,T169] (  3,   3.11)    long  ->  rcx         "Cast away GC"
 ;  V342 tmp308      [V342,T127] (  2,  10.79)    long  ->  rcx         "Cast away GC"
-;  V343 tmp309      [V343,T151] (  3,   4.32)    long  ->  [rsp+0x1460]  spill-single-def ptr "Cast away GC"
+;  V343 tmp309      [V343,T150] (  3,   4.32)    long  ->  [rsp+0x1460]  spill-single-def ptr "Cast away GC"
 ;  V344 tmp310      [V344,T214] (  3,   1.44)    long  ->  rcx         "Cast away GC"
 ;  V345 tmp311      [V345,T245] (  2,   0   )     int  ->  rdx         "argument with side effect"
 ;  V346 tmp312      [V346,T246] (  2,   0   )     int  ->  rdx         "argument with side effect"
@@ -369,10 +369,10 @@
 ;* V357 tmp323      [V357    ] (  0,   0   )    long  ->  zero-ref    "Cast away GC"
 ;* V358 tmp324      [V358    ] (  0,   0   )    long  ->  zero-ref    "argument with side effect"
 ;  V359 GsCookie    [V359    ] (  1,   1   )    long  ->  [rsp+0x1520]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
-;  V360 tmp326      [V360,T155] (  7,   4.00)    long  ->  [rsp+0x1458]  spill-single-def ptr "shadowVar"
+;  V360 tmp326      [V360,T154] (  7,   4.00)    long  ->  [rsp+0x1458]  spill-single-def ptr "shadowVar"
 ;  V361 tmp327      [V361,T132] ( 13,   6.91)     int  ->  r14         "shadowVar"
 ;  V362 tmp328      [V362,T187] (  2,   2   )     int  ->  rbp         "shadowVar"
-;  V363 tmp329      [V363,T154] ( 10,   4.03)     int  ->  [rsp+0x1454]  spill-single-def ptr "shadowVar"
+;  V363 tmp329      [V363,T153] ( 10,   4.03)     int  ->  [rsp+0x1454]  spill-single-def ptr "shadowVar"
 ;  V364 tmp330      [V364,T171] (  3,   3   )   byref  ->  rax         single-def "shadowVar"
 ;  V365 tmp331      [V365,T185] (  6,   2   )   byref  ->  [rsp+0x1418]  spill-single-def ptr "shadowVar"
 ;  V366 cse0        [V366,T227] (  4,   0.17)    long  ->  r10         "CSE - conservative"
@@ -676,15 +676,13 @@ G_M41408_IG27:        ; bbWeight=0.90, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        je       G_M41408_IG86
        mov      ecx, ebp
        and      ecx, 7
-       cmp      ecx, 10
-       jae      G_M41408_IG254
        mov      rdx, 0xD1FFAB1E      ; static handle
        mov      ecx, dword ptr [rdx+4*rcx]
        test     ecx, ecx
        je       G_M41408_IG265
        mov      dword ptr [rsp+0x76C], ecx
        mov      dword ptr [rsp+0x768], 1
-						;; size=67 bbWeight=0.90 PerfScore 9.21
+						;; size=58 bbWeight=0.90 PerfScore 8.09
 G_M41408_IG28:        ; bbWeight=0.90, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        lea      r14, bword ptr [rsp+0x768]
        ; byrRegs +[r14]
@@ -3575,7 +3573,7 @@ RWD00  	dq	3FD34413509F79FFh	;  0.301029996
 RWD08  	dq	3FE6147AE147AE14h	;         0.69
 
 
-; Total bytes of code 9685, prolog size 67, PerfScore 26009.74, instruction count 2000, allocated bytes for code 9686 (MethodHash=ef215e3f) for method System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
+; Total bytes of code 9676, prolog size 67, PerfScore 26008.62, instruction count 1998, allocated bytes for code 9677 (MethodHash=ef215e3f) for method System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-0.09%</span>) : 13448.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,10 +9,10 @@
 ; 69 inlinees with PGO data; 92 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T144] (  3,   3   )    long  ->  rcx         single-def
-;  V01 arg1         [V01,T145] (  3,   3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T146] (  3,   3   )     int  ->   r8         single-def
-;  V03 arg3         [V03,T143] (  4,   3   )   ubyte  ->  rbx         single-def
+;  V00 arg0         [V00,T143] (  3,   3   )    long  ->  rcx         single-def
+;  V01 arg1         [V01,T144] (  3,   3   )     int  ->  rdx         single-def
+;  V02 arg2         [V02,T145] (  3,   3   )     int  ->   r8         single-def
+;  V03 arg3         [V03,T142] (  4,   3   )   ubyte  ->  rbx         single-def
 ;  V04 arg4         [V04,T221] (  1,   1   )     int  ->  [rsp+0x1580]  single-def ptr
 ;  V05 arg5         [V05,T218] (  3,   1.00)   ubyte  ->  [rsp+0x1588]  single-def
 ;  V06 arg6         [V06,T190] (  1,   2   )   byref  ->  rax         ld-addr-op single-def
@@ -27,7 +27,7 @@
 ;  V15 loc7         [V15,T118] (  3,  18.41)   ubyte  ->  [rsp+0x1508]  ptr
 ;  V16 loc8         [V16,T188] (  2,   2   )   ubyte  ->  rcx        
 ;  V17 loc9         [V17,T121] (  9,  17.48)     int  ->  [rsp+0x1504]  ptr
-;  V18 loc10        [V18,T153] (  5,   4.15)     int  ->  [rsp+0x1500]  spill-single-def ptr
+;  V18 loc10        [V18,T152] (  5,   4.15)     int  ->  [rsp+0x1500]  spill-single-def ptr
 ;  V19 loc11        [V19,T92] (  5,  33.85)   ubyte  ->  registers   ptr
 ;  V20 loc12        [V20,T93] (  5,  33.85)   ubyte  ->  registers   ptr
 ;  V21 loc13        [V21,T68] ( 17,  49.88)     int  ->  registers   ptr
@@ -38,14 +38,14 @@
 ;* V26 loc18        [V26    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;  V27 loc19        [V27,T230] (  4,   0.04)     int  ->  rax        
 ;  V28 loc20        [V28,T183] (  4,   2.30)     int  ->  [rsp+0x14FC]  spill-single-def ptr
-;  V29 loc21        [V29,T142] ( 10,   5.74)     int  ->  [rsp+0x14F8]  spill-single-def ptr
+;  V29 loc21        [V29,T141] ( 10,   5.74)     int  ->  [rsp+0x14F8]  spill-single-def ptr
 ;  V30 loc22        [V30    ] (  9, 600.31)  struct (464) [rsp+0xB08]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer <System.Number+BigInteger>
 ;  V31 loc23        [V31,T100] (  3,  32.84)     int  ->  rbp        
 ;* V32 loc24        [V32    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;* V33 loc25        [V33    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;  V34 tmp0         [V34,T222] (  1,   1   )     int  ->  [rsp+0x14F4]  do-not-enreg[V] "GSCookie dummy"
 ;  V35 OutArgs      [V35    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V36 tmp2         [V36,T160] (  2,   4   )     int  ->  r14         "dup spill"
+;  V36 tmp2         [V36,T159] (  2,   4   )     int  ->  r14         "dup spill"
 ;  V37 tmp3         [V37,T202] (  2,   1.15)     int  ->  rcx        
 ;  V38 tmp4         [V38,T241] (  3,   0   )     int  ->  rcx        
 ;  V39 tmp5         [V39,T231] (  4,   0.02)     int  ->  rdx        
@@ -73,7 +73,7 @@
 ;  V61 tmp27        [V61,T134] (  5,   6.29)    long  ->  r10         "Inlining Arg"
 ;* V62 tmp28        [V62    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V63 tmp29        [V63,T197] (  2,   1.98)     int  ->  rbx         ld-addr-op "Inline ldloca(s) first use temp"
-;  V64 tmp30        [V64,T149] (  5,   4.94)     int  ->  [rsp+0x14E4]  spill-single-def ptr "Inline stloc first use temp"
+;  V64 tmp30        [V64,T148] (  5,   4.94)     int  ->  [rsp+0x14E4]  spill-single-def ptr "Inline stloc first use temp"
 ;* V65 tmp31        [V65    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V66 tmp32        [V66    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V67 tmp33        [V67    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
@@ -89,7 +89,7 @@
 ;* V77 tmp43        [V77    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[uint]>
 ;  V78 tmp44        [V78    ] (  4,   3   )  struct (464) [rsp+0x768]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V79 tmp45        [V79,T67] (  6,  52   )     int  ->  [rsp+0x14E0]  ptr "Inlining Arg"
-;  V80 tmp46        [V80,T138] (  3,   6   )     int  ->  rcx         "Span.get_Item index"
+;  V80 tmp46        [V80,T160] (  2,   4   )     int  ->  rcx         "Span.get_Item index"
 ;  V81 tmp47        [V81,T119] ( 11,  18   )   byref  ->  [rsp+0x1440]  ptr "Inline stloc first use temp"
 ;  V82 tmp48        [V82    ] (  2,   2   )  struct (464) [rsp+0x28]  do-not-enreg[XSF] addr-exposed ld-addr-op unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V83 tmp49        [V83,T31] ( 13, 232.16)   byref  ->  [rsp+0x1438]  ptr "Inline stloc first use temp"
@@ -98,12 +98,12 @@
 ;  V86 tmp52        [V86    ] (  4,  10.00)   byref  ->  [rsp+0x14D0]  must-init pinned ptr "Inline stloc first use temp"
 ;* V87 tmp53        [V87    ] (  0,   0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;  V88 tmp54        [V88,T129] (  6,   9.00)   byref  ->   r8         "Inline stloc first use temp"
-;  V89 tmp55        [V89,T140] (  2,   6   )   byref  ->  r10         "Inline stloc first use temp"
+;  V89 tmp55        [V89,T139] (  2,   6   )   byref  ->  r10         "Inline stloc first use temp"
 ;* V90 tmp56        [V90    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
 ;* V91 tmp57        [V91    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
 ;* V92 tmp58        [V92    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V93 tmp59        [V93    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
-;  V94 tmp60        [V94,T139] (  3,   6   )     int  ->  rcx         "Inlining Arg"
+;  V94 tmp60        [V94,T138] (  3,   6   )     int  ->  rcx         "Inlining Arg"
 ;* V95 tmp61        [V95    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
 ;* V96 tmp62        [V96    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
 ;  V97 tmp63        [V97,T33] (  5, 216.92)   byref  ->  rsi         "Inline stloc first use temp"
@@ -127,20 +127,20 @@
 ;  V115 tmp81       [V115,T128] (  5,   9.60)    long  ->   r8         "Inlining Arg"
 ;* V116 tmp82       [V116    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V117 tmp83       [V117,T175] (  3,   3   )     int  ->  rcx         "Inline stloc first use temp"
-;  V118 tmp84       [V118,T156] (  3,   4   )   byref  ->   r8         single-def "Inlining Arg"
+;  V118 tmp84       [V118,T155] (  3,   4   )   byref  ->   r8         single-def "Inlining Arg"
 ;  V119 tmp85       [V119,T161] (  2,   4   )    long  ->  rcx         "Inlining Arg"
-;  V120 tmp86       [V120,T157] (  3,   4   )   byref  ->  r10         single-def "spilling arg"
-;  V121 tmp87       [V121,T147] (  3,   5   )    long  ->   r9         "spilling arg"
+;  V120 tmp86       [V120,T156] (  3,   4   )   byref  ->  r10         single-def "spilling arg"
+;  V121 tmp87       [V121,T146] (  3,   5   )    long  ->   r9         "spilling arg"
 ;  V122 tmp88       [V122    ] ( 10,   6   )  struct (464) [rsp+0x598]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V123 tmp89       [V123,T176] (  3,   3   )     int  ->  rcx         "Inline stloc first use temp"
 ;  V124 tmp90       [V124,T162] (  2,   4   )    long  ->   r8         "Inlining Arg"
-;  V125 tmp91       [V125,T158] (  3,   4   )   byref  ->  rcx         single-def "spilling arg"
-;  V126 tmp92       [V126,T159] (  3,   4   )   byref  ->  r10         single-def "spilling arg"
-;  V127 tmp93       [V127,T148] (  3,   5   )    long  ->   r8         "spilling arg"
+;  V125 tmp91       [V125,T157] (  3,   4   )   byref  ->  rcx         single-def "spilling arg"
+;  V126 tmp92       [V126,T158] (  3,   4   )   byref  ->  r10         single-def "spilling arg"
+;  V127 tmp93       [V127,T147] (  3,   5   )    long  ->   r8         "spilling arg"
 ;  V128 tmp94       [V128,T51] (  4,  71.81)   byref  ->  [rsp+0x1430]  ptr "Inline stloc first use temp"
 ;  V129 tmp95       [V129,T86] (  5,  37.40)     int  ->  [rsp+0x14B8]  ptr "Inline stloc first use temp"
 ;  V130 tmp96       [V130,T85] (  5,  40.40)   byref  ->  [rsp+0x1428]  ptr "Inline stloc first use temp"
-;  V131 tmp97       [V131,T152] (  6,   4.50)     int  ->  [rsp+0x14B4]  ptr "Inline stloc first use temp"
+;  V131 tmp97       [V131,T151] (  6,   4.50)     int  ->  [rsp+0x14B4]  ptr "Inline stloc first use temp"
 ;  V132 tmp98       [V132,T172] (  6,   3   )     int  ->  [rsp+0x14B0]  spill-single-def ptr "Inline stloc first use temp"
 ;  V133 tmp99       [V133,T74] (  6,  43.89)     int  ->  rsi         "Inline stloc first use temp"
 ;  V134 tmp100      [V134,T135] (  4,   6.24)     int  ->  [rsp+0x14AC]  ptr "Inline stloc first use temp"
@@ -172,7 +172,7 @@
 ;  V160 tmp126      [V160,T167] (  4,   3.64)     int  ->  rcx         "Inline stloc first use temp"
 ;  V161 tmp127      [V161,T194] (  3,   1.98)     int  ->  rsi         "Inline stloc first use temp"
 ;  V162 tmp128      [V162,T184] (  3,   2.13)     int  ->   r8         "Inline stloc first use temp"
-;  V163 tmp129      [V163,T141] (  7,   5.84)     int  ->  rcx         "Inline stloc first use temp"
+;  V163 tmp129      [V163,T140] (  7,   5.84)     int  ->  rcx         "Inline stloc first use temp"
 ;  V164 tmp130      [V164,T180] (  3,   2.50)    long  ->   r8         "Inline stloc first use temp"
 ;* V165 tmp131      [V165    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V166 tmp132      [V166    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -322,7 +322,7 @@
 ;  V310 tmp276      [V310,T179] (  4,   2.93)     int  ->  rax         "Inline stloc first use temp"
 ;  V311 tmp277      [V311,T211] (  3,   1.59)     int  ->   r8         "Inline stloc first use temp"
 ;  V312 tmp278      [V312,T209] (  3,   1.71)     int  ->  rdx         "Inline stloc first use temp"
-;  V313 tmp279      [V313,T151] (  7,   4.69)     int  ->  rax         "Inline stloc first use temp"
+;  V313 tmp279      [V313,T150] (  7,   4.69)     int  ->  rax         "Inline stloc first use temp"
 ;  V314 tmp280      [V314,T185] (  3,   2.01)    long  ->  rdx         "Inline stloc first use temp"
 ;* V315 tmp281      [V315    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V316 tmp282      [V316    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -352,7 +352,7 @@
 ;  V340 tmp306      [V340,T233] (  2,   0.01)    long  ->  rcx         "argument with side effect"
 ;  V341 tmp307      [V341,T170] (  3,   3.16)    long  ->  rcx         "Cast away GC"
 ;  V342 tmp308      [V342,T127] (  2,  12.00)    long  ->  rcx         "Cast away GC"
-;  V343 tmp309      [V343,T150] (  3,   4.80)    long  ->  [rsp+0x1460]  spill-single-def ptr "Cast away GC"
+;  V343 tmp309      [V343,T149] (  3,   4.80)    long  ->  [rsp+0x1460]  spill-single-def ptr "Cast away GC"
 ;  V344 tmp310      [V344,T210] (  3,   1.60)    long  ->  [rsp+0x1458]  spill-single-def "Cast away GC"
 ;  V345 tmp311      [V345,T245] (  2,   0   )     int  ->  rdx         "argument with side effect"
 ;  V346 tmp312      [V346,T246] (  2,   0   )     int  ->  rdx         "argument with side effect"
@@ -369,10 +369,10 @@
 ;* V357 tmp323      [V357    ] (  0,   0   )    long  ->  zero-ref    "Cast away GC"
 ;* V358 tmp324      [V358    ] (  0,   0   )    long  ->  zero-ref    "argument with side effect"
 ;  V359 GsCookie    [V359    ] (  1,   1   )    long  ->  [rsp+0x1510]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
-;  V360 tmp326      [V360,T155] (  7,   4   )    long  ->  [rsp+0x1450]  spill-single-def ptr "shadowVar"
+;  V360 tmp326      [V360,T154] (  7,   4   )    long  ->  [rsp+0x1450]  spill-single-def ptr "shadowVar"
 ;  V361 tmp327      [V361,T132] ( 13,   6.96)     int  ->  r15         "shadowVar"
 ;  V362 tmp328      [V362,T189] (  2,   2   )     int  ->  r14         "shadowVar"
-;  V363 tmp329      [V363,T154] ( 10,   4.04)     int  ->  [rsp+0x144C]  spill-single-def ptr "shadowVar"
+;  V363 tmp329      [V363,T153] ( 10,   4.04)     int  ->  [rsp+0x144C]  spill-single-def ptr "shadowVar"
 ;  V364 tmp330      [V364,T173] (  3,   3   )   byref  ->  rax         single-def "shadowVar"
 ;  V365 tmp331      [V365,T186] (  6,   2   )   byref  ->  [rsp+0x1418]  spill-single-def ptr "shadowVar"
 ;  V366 cse0        [V366,T227] (  4,   0.17)    long  ->   r8         "CSE - conservative"
@@ -704,15 +704,13 @@ G_M41408_IG28:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        je       G_M41408_IG43
        mov      ecx, r14d
        and      ecx, 7
-       cmp      ecx, 10
-       jae      G_M41408_IG253
        mov      r8, 0xD1FFAB1E      ; static handle
        mov      ecx, dword ptr [r8+4*rcx]
        test     ecx, ecx
        je       G_M41408_IG265
        mov      dword ptr [rsp+0x76C], ecx
        mov      dword ptr [rsp+0x768], 1
-						;; size=126 bbWeight=1 PerfScore 42.33
+						;; size=117 bbWeight=1 PerfScore 41.08
 G_M41408_IG29:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        lea      r15, bword ptr [rsp+0x768]
        ; byrRegs +[r15]
@@ -3572,7 +3570,7 @@ RWD00  	dq	3FD34413509F79FFh	;  0.301029996
 RWD08  	dq	3FE6147AE147AE14h	;         0.69
 
 
-; Total bytes of code 9688, prolog size 67, PerfScore 26422.23, instruction count 1999, allocated bytes for code 9689 (MethodHash=ef215e3f) for method System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
+; Total bytes of code 9679, prolog size 67, PerfScore 26420.98, instruction count 1997, allocated bytes for code 9680 (MethodHash=ef215e3f) for method System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-0.09%</span>) : 87666.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -27,11 +27,11 @@
 ;  V15 loc7         [V15,T115] (  3,  18.42)   ubyte  ->  [rsp+0x14FC]  ptr
 ;  V16 loc8         [V16,T180] (  2,   2   )   ubyte  ->  rcx        
 ;  V17 loc9         [V17,T116] (  9,  17.48)     int  ->  [rsp+0x14F8]  ptr
-;  V18 loc10        [V18,T149] (  5,   4.03)     int  ->  [rsp+0x14F4]  spill-single-def ptr
+;  V18 loc10        [V18,T148] (  5,   4.03)     int  ->  [rsp+0x14F4]  spill-single-def ptr
 ;  V19 loc11        [V19,T88] (  5,  33.88)   ubyte  ->  registers   ptr
 ;  V20 loc12        [V20,T89] (  5,  33.88)   ubyte  ->  registers   ptr
 ;  V21 loc13        [V21,T64] ( 17,  49.90)     int  ->  rdi        
-;  V22 loc14        [V22,T152] (  5,   3.77)   ubyte  ->  r14        
+;  V22 loc14        [V22,T151] (  5,   3.77)   ubyte  ->  r14        
 ;* V23 loc15        [V23    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;  V24 loc16        [V24    ] (  3,   0   )  struct (464) [rsp+0x1F0]  do-not-enreg[XS] addr-exposed ld-addr-op unsafe-buffer <System.Number+BigInteger>
 ;  V25 loc17        [V25    ] ( 10,  31.22)  struct (464) [rsp+0xCD0]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer <System.Number+BigInteger>
@@ -45,7 +45,7 @@
 ;* V33 loc25        [V33    ] (  0,   0   )     int  ->  zero-ref    ptr
 ;  V34 tmp0         [V34,T216] (  1,   1   )     int  ->  [rsp+0x14E8]  do-not-enreg[V] "GSCookie dummy"
 ;  V35 OutArgs      [V35    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V36 tmp2         [V36,T151] (  2,   4   )     int  ->  rbp         "dup spill"
+;  V36 tmp2         [V36,T150] (  2,   4   )     int  ->  rbp         "dup spill"
 ;  V37 tmp3         [V37,T196] (  2,   1.03)     int  ->  rcx        
 ;  V38 tmp4         [V38,T236] (  3,   0   )     int  ->  rcx        
 ;  V39 tmp5         [V39,T226] (  4,   0.02)     int  ->  rdx        
@@ -73,7 +73,7 @@
 ;  V61 tmp27        [V61,T135] (  5,   5.50)    long  ->  rdx         "Inlining Arg"
 ;* V62 tmp28        [V62    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V63 tmp29        [V63,T189] (  2,   1.74)     int  ->  rbx         ld-addr-op "Inline ldloca(s) first use temp"
-;  V64 tmp30        [V64,T147] (  5,   4.36)     int  ->  [rsp+0x14D8]  spill-single-def ptr "Inline stloc first use temp"
+;  V64 tmp30        [V64,T146] (  5,   4.36)     int  ->  [rsp+0x14D8]  spill-single-def ptr "Inline stloc first use temp"
 ;* V65 tmp31        [V65    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V66 tmp32        [V66    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V67 tmp33        [V67    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
@@ -90,7 +90,7 @@
 ;* V78 tmp44        [V78    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[uint]>
 ;  V79 tmp45        [V79    ] (  4,   2.21)  struct (464) [rsp+0x760]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V80 tmp46        [V80,T76] (  6,  38.29)     int  ->  [rsp+0x14D4]  ptr "Inlining Arg"
-;  V81 tmp47        [V81,T144] (  3,   4.42)     int  ->  rcx         "Span.get_Item index"
+;  V81 tmp47        [V81,T161] (  2,   2.95)     int  ->  rcx         "Span.get_Item index"
 ;  V82 tmp48        [V82,T123] ( 11,  13.25)   byref  ->  [rsp+0x1440]  ptr "Inline stloc first use temp"
 ;  V83 tmp49        [V83    ] (  2,   1.47)  struct (464) [rsp+0x20]  do-not-enreg[XSF] addr-exposed ld-addr-op unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V84 tmp50        [V84,T31] ( 13, 172.27)   byref  ->  [rsp+0x1438]  ptr "Inline stloc first use temp"
@@ -99,12 +99,12 @@
 ;  V87 tmp53        [V87    ] (  4,   7.36)   byref  ->  [rsp+0x14C8]  must-init pinned ptr "Inline stloc first use temp"
 ;* V88 tmp54        [V88    ] (  0,   0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;  V89 tmp55        [V89,T129] (  6,   6.63)   byref  ->   r8         "Inline stloc first use temp"
-;  V90 tmp56        [V90,T146] (  2,   4.42)   byref  ->  r10         "Inline stloc first use temp"
+;  V90 tmp56        [V90,T145] (  2,   4.42)   byref  ->  r10         "Inline stloc first use temp"
 ;* V91 tmp57        [V91    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
 ;* V92 tmp58        [V92    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
 ;* V93 tmp59        [V93    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V94 tmp60        [V94    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
-;  V95 tmp61        [V95,T145] (  3,   4.42)     int  ->  rcx         "Inlining Arg"
+;  V95 tmp61        [V95,T144] (  3,   4.42)     int  ->  rcx         "Inlining Arg"
 ;* V96 tmp62        [V96    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[uint]>
 ;* V97 tmp63        [V97    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
 ;  V98 tmp64        [V98,T33] (  5, 161.04)   byref  ->  [rsp+0x1430]  ptr "Inline stloc first use temp"
@@ -128,7 +128,7 @@
 ;  V116 tmp82       [V116,T127] (  5,   7.00)    long  ->   r8         "Inlining Arg"
 ;* V117 tmp83       [V117    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V118 tmp84       [V118,T175] (  3,   2.21)     int  ->   r8         "Inline stloc first use temp"
-;  V119 tmp85       [V119,T161] (  2,   2.95)   byref  ->  rdx         single-def "Inlining Arg"
+;  V119 tmp85       [V119,T160] (  2,   2.95)   byref  ->  rdx         single-def "Inlining Arg"
 ;  V120 tmp86       [V120,T162] (  2,   2.95)    long  ->   r8         "Inlining Arg"
 ;  V121 tmp87       [V121    ] ( 10,   4.42)  struct (464) [rsp+0x590]  do-not-enreg[XSF] addr-exposed ld-addr-op ptr unsafe-buffer "Inline ldloca(s) first use temp" <System.Number+BigInteger>
 ;  V122 tmp88       [V122,T176] (  3,   2.21)     int  ->   r8         "Inline stloc first use temp"
@@ -136,7 +136,7 @@
 ;  V124 tmp90       [V124,T63] (  4,  53.31)   byref  ->  [rsp+0x1428]  ptr "Inline stloc first use temp"
 ;  V125 tmp91       [V125,T104] (  5,  27.76)     int  ->  [rsp+0x14B8]  ptr "Inline stloc first use temp"
 ;  V126 tmp92       [V126,T100] (  5,  29.97)   byref  ->  [rsp+0x1420]  ptr "Inline stloc first use temp"
-;  V127 tmp93       [V127,T156] (  6,   3.31)     int  ->  [rsp+0x14B4]  ptr "Inline stloc first use temp"
+;  V127 tmp93       [V127,T155] (  6,   3.31)     int  ->  [rsp+0x14B4]  ptr "Inline stloc first use temp"
 ;  V128 tmp94       [V128,T173] (  6,   2.21)     int  ->  [rsp+0x14B0]  spill-single-def ptr "Inline stloc first use temp"
 ;  V129 tmp95       [V129,T99] (  6,  32.54)     int  ->  rcx         "Inline stloc first use temp"
 ;  V130 tmp96       [V130,T141] (  4,   4.60)     int  ->  rdx         "Inline stloc first use temp"
@@ -155,7 +155,7 @@
 ;  V143 tmp109      [V143,T101] (  4,  29.39)   byref  ->  rcx         single-def "Inline stloc first use temp"
 ;  V144 tmp110      [V144,T187] (  2,   1.98)   byref  ->   r8        
 ;  V145 tmp111      [V145,T102] (  3,  28.87)   byref  ->   r8         single-def "Inline stloc first use temp"
-;  V146 tmp112      [V146,T155] (  6,   3.50)     int  ->  [rsp+0x14AC]  spill-single-def ptr "Inline stloc first use temp"
+;  V146 tmp112      [V146,T154] (  6,   3.50)     int  ->  [rsp+0x14AC]  spill-single-def ptr "Inline stloc first use temp"
 ;  V147 tmp113      [V147,T103] (  3,  28.87)     int  ->  rdx         "Inline stloc first use temp"
 ;  V148 tmp114      [V148,T59] (  7,  56.81)    long  ->  registers   ptr "Inline stloc first use temp"
 ;  V149 tmp115      [V149,T42] (  9,  84.75)     int  ->   r9         "Inline stloc first use temp"
@@ -165,7 +165,7 @@
 ;  V153 tmp119      [V153,T195] (  3,   1.58)    long  ->  rdx         "Inline stloc first use temp"
 ;  V154 tmp120      [V154,T238] (  3,   0   )     int  ->  rcx        
 ;  V155 tmp121      [V155,T184] (  5,   1.98)     int  ->  rdx         "Inline return value spill temp"
-;  V156 tmp122      [V156,T153] (  4,   3.65)     int  ->  rcx         "Inline stloc first use temp"
+;  V156 tmp122      [V156,T152] (  4,   3.65)     int  ->  rcx         "Inline stloc first use temp"
 ;  V157 tmp123      [V157,T185] (  3,   1.98)     int  ->  r13         "Inline stloc first use temp"
 ;  V158 tmp124      [V158,T177] (  3,   2.13)     int  ->  rdx         "Inline stloc first use temp"
 ;  V159 tmp125      [V159,T133] (  7,   5.85)     int  ->  rcx         "Inline stloc first use temp"
@@ -196,7 +196,7 @@
 ;* V184 tmp150      [V184    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V185 tmp151      [V185    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V186 tmp152      [V186    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
-;  V187 tmp153      [V187,T157] (  5,   3.25)    long  ->  rdx         "Inlining Arg"
+;  V187 tmp153      [V187,T156] (  5,   3.25)    long  ->  rdx         "Inlining Arg"
 ;* V188 tmp154      [V188    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V189 tmp155      [V189,T198] (  3,   1.54)     int  ->   r8         "Inline stloc first use temp"
 ;  V190 tmp156      [V190,T121] (  5,  13.51)     int  ->  [rsp+0x1490]  ld-addr-op spill-single-def ptr "Inline ldloca(s) first use temp"
@@ -213,7 +213,7 @@
 ;* V201 tmp167      [V201    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V202 tmp168      [V202    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V203 tmp169      [V203    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
-;  V204 tmp170      [V204,T158] (  5,   3.25)    long  ->  rdx         "Inlining Arg"
+;  V204 tmp170      [V204,T157] (  5,   3.25)    long  ->  rdx         "Inlining Arg"
 ;* V205 tmp171      [V205    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V206 tmp172      [V206,T199] (  3,   1.54)     int  ->   r8         "Inline stloc first use temp"
 ;  V207 tmp173      [V207,T122] (  5,  13.51)     int  ->  [rsp+0x147C]  ld-addr-op spill-single-def ptr "Inline ldloca(s) first use temp"
@@ -230,7 +230,7 @@
 ;* V218 tmp184      [V218    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V219 tmp185      [V219    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V220 tmp186      [V220    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
-;  V221 tmp187      [V221,T159] (  5,   3.25)    long  ->  rdx         "Inlining Arg"
+;  V221 tmp187      [V221,T158] (  5,   3.25)    long  ->  rdx         "Inlining Arg"
 ;* V222 tmp188      [V222    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V223 tmp189      [V223    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V224 tmp190      [V224    ] (  0,   0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -348,7 +348,7 @@
 ;  V336 tmp302      [V336,T228] (  2,   0.01)    long  ->  rcx         "argument with side effect"
 ;  V337 tmp303      [V337,T165] (  3,   2.76)    long  ->  rcx         "Cast away GC"
 ;  V338 tmp304      [V338,T126] (  2,   8.84)    long  ->  rcx         "Cast away GC"
-;  V339 tmp305      [V339,T154] (  3,   3.50)    long  ->  [rsp+0x1458]  spill-single-def ptr "Cast away GC"
+;  V339 tmp305      [V339,T153] (  3,   3.50)    long  ->  [rsp+0x1458]  spill-single-def ptr "Cast away GC"
 ;  V340 tmp306      [V340,T208] (  3,   1.17)    long  ->  rcx         "Cast away GC"
 ;  V341 tmp307      [V341,T240] (  2,   0   )     int  ->  rdx         "argument with side effect"
 ;  V342 tmp308      [V342,T241] (  2,   0   )     int  ->  rdx         "argument with side effect"
@@ -365,11 +365,11 @@
 ;* V353 tmp319      [V353    ] (  0,   0   )    long  ->  zero-ref    "Cast away GC"
 ;* V354 tmp320      [V354    ] (  0,   0   )    long  ->  zero-ref    "argument with side effect"
 ;  V355 GsCookie    [V355    ] (  1,   1   )    long  ->  [rsp+0x1510]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
-;  V356 tmp322      [V356,T150] (  7,   4   )    long  ->  [rsp+0x1450]  spill-single-def ptr "shadowVar"
+;  V356 tmp322      [V356,T149] (  7,   4   )    long  ->  [rsp+0x1450]  spill-single-def ptr "shadowVar"
 ;  V357 tmp323      [V357,T131] ( 13,   6.61)     int  ->  r14         "shadowVar"
 ;  V358 tmp324      [V358,T181] (  2,   2   )     int  ->  rbp         "shadowVar"
-;  V359 tmp325      [V359,T148] ( 10,   4.03)     int  ->  [rsp+0x144C]  spill-single-def ptr "shadowVar"
-;  V360 tmp326      [V360,T160] (  3,   3   )   byref  ->  rax         single-def "shadowVar"
+;  V359 tmp325      [V359,T147] ( 10,   4.03)     int  ->  [rsp+0x144C]  spill-single-def ptr "shadowVar"
+;  V360 tmp326      [V360,T159] (  3,   3   )   byref  ->  rax         single-def "shadowVar"
 ;  V361 tmp327      [V361,T179] (  6,   2   )   byref  ->  [rsp+0x1410]  spill-single-def ptr "shadowVar"
 ;  V362 cse0        [V362,T222] (  4,   0.16)    long  ->  r10         "CSE - conservative"
 ;  V363 cse1        [V363,T80] (  9,  37.46)     int  ->  rsi         multi-def "CSE - conservative"
@@ -671,15 +671,13 @@ G_M41408_IG27:        ; bbWeight=0.74, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        je       G_M41408_IG81
        mov      ecx, ebp
        and      ecx, 7
-       cmp      ecx, 10
-       jae      G_M41408_IG250
        mov      rdx, 0xD1FFAB1E      ; static handle
        mov      ecx, dword ptr [rdx+4*rcx]
        test     ecx, ecx
        je       G_M41408_IG261
        mov      dword ptr [rsp+0x764], ecx
        mov      dword ptr [rsp+0x760], 1
-						;; size=67 bbWeight=0.74 PerfScore 7.55
+						;; size=58 bbWeight=0.74 PerfScore 6.63
 G_M41408_IG28:        ; bbWeight=0.74, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        lea      r14, bword ptr [rsp+0x760]
        ; byrRegs +[r14]
@@ -3554,7 +3552,7 @@ RWD00  	dq	3FD34413509F79FFh	;  0.301029996
 RWD08  	dq	3FE6147AE147AE14h	;         0.69
 
 
-; Total bytes of code 9688, prolog size 67, PerfScore 25082.49, instruction count 1995, allocated bytes for code 9689 (MethodHash=ef215e3f) for method System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
+; Total bytes of code 9679, prolog size 67, PerfScore 25081.57, instruction count 1993, allocated bytes for code 9680 (MethodHash=ef215e3f) for method System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-49</span> (<span style="color:green">-28.49%</span>) : 25587.dasm - SeekUnroll:FindByte(byref):int (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -24,41 +24,29 @@ G_M41267_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; byrRegs +[rcx]
        vmovups  ymm0, ymmword ptr [rcx]
        xor      eax, eax
-       mov      ecx, 4
-       ; byrRegs -[rcx]
-       test     ecx, ecx
-       je       G_M41267_IG06
        vmovd    rcx, xmm0
+       ; byrRegs -[rcx]
        test     rcx, rcx
        jne      SHORT G_M41267_IG04
-						;; size=29 bbWeight=1 PerfScore 10.00
+						;; size=16 bbWeight=1 PerfScore 8.50
 G_M41267_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      eax, 1
-       mov      ecx, 4
-       cmp      ecx, 1
-       jbe      SHORT G_M41267_IG06
        vmovaps  ymm1, ymm0
        vpextrq  rcx, xmm1, 1
        test     rcx, rcx
        jne      SHORT G_M41267_IG04
        mov      eax, 2
-       mov      ecx, 4
-       cmp      ecx, 2
-       jbe      SHORT G_M41267_IG06
        vextracti128 xmm1, ymm0, 1
        vmovd    rcx, xmm1
        test     rcx, rcx
        jne      SHORT G_M41267_IG04
        mov      eax, 3
-       mov      ecx, 4
-       cmp      ecx, 3
-       jbe      SHORT G_M41267_IG06
        vextracti128 xmm0, ymm0, 1
        vpextrq  rcx, xmm0, 1
        mov      edx, 4
        test     rcx, rcx
        cmove    eax, edx
-						;; size=99 bbWeight=0.50 PerfScore 10.38
+						;; size=69 bbWeight=0.50 PerfScore 8.12
 G_M41267_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        blsmsk   rcx, rcx
        mov      rdx, 0xD1FFAB1E
@@ -71,13 +59,8 @@ G_M41267_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=8 bbWeight=1 PerfScore 2.25
-G_M41267_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_THROW_ARGUMENTOUTOFRANGEEXCEPTION
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 172, prolog size 4, PerfScore 26.62, instruction count 44, allocated bytes for code 172 (MethodHash=ed2e5ecc) for method SeekUnroll:FindByte(byref):int (Tier1)
+; Total bytes of code 123, prolog size 4, PerfScore 22.88, instruction count 30, allocated bytes for code 123 (MethodHash=ed2e5ecc) for method SeekUnroll:FindByte(byref):int (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-27.78%</span>) : 4053.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,14 +9,14 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  4   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
+;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
-G_M54145_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M54145_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
@@ -29,30 +29,22 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        jl       SHORT G_M54145_IG06
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M54145_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M54145_IG08
        cmp      word  ptr [rax], 92
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG08
-       movzx    rdx, word  ptr [rax+0x02]
-       cmp      edx, 92
+       movzx    rcx, word  ptr [rax+0x02]
+       cmp      ecx, 92
        je       SHORT G_M54145_IG04
-       cmp      edx, 63
+       cmp      ecx, 63
        jne      SHORT G_M54145_IG06
-						;; size=29 bbWeight=0.50 PerfScore 5.50
+						;; size=20 bbWeight=0.50 PerfScore 4.25
 G_M54145_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x04], 63
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x06], 92
        sete     al
        ; byrRegs -[rax]
        movzx    rax, al
-						;; size=28 bbWeight=0.50 PerfScore 5.38
+						;; size=18 bbWeight=0.50 PerfScore 4.12
 G_M54145_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -64,13 +56,8 @@ G_M54145_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M54145_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 90, prolog size 4, PerfScore 17.75, instruction count 32, allocated bytes for code 90 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
+; Total bytes of code 65, prolog size 4, PerfScore 15.25, instruction count 22, allocated bytes for code 65 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-27.03%</span>) : 40739.dasm - System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -12,17 +12,17 @@
 ;* V02 loc0         [V02    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd <System.__Canon>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 tmp1         [V04,T00] (  3,  2.50)     ref  ->  rdx         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V05 cse0         [V05,T01] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V05 cse0         [V05,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M7353_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M7353_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M7353_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rdx]
-       mov      ecx, dword ptr [rdx+0x08]
-       test     ecx, ecx
+       mov      eax, dword ptr [rdx+0x08]
+       test     eax, eax
        jne      SHORT G_M7353_IG05
 						;; size=7 bbWeight=1 PerfScore 3.25
 G_M7353_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
@@ -34,25 +34,17 @@ G_M7353_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M7353_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M7353_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax] +[rdx]
-       test     ecx, ecx
-       je       SHORT G_M7353_IG07
        mov      rax, gword ptr [rdx+0x10]
        ; gcrRegs +[rax]
-						;; size=8 bbWeight=0.50 PerfScore 1.62
+						;; size=4 bbWeight=0.50 PerfScore 1.00
 G_M7353_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M7353_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax rdx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 37, prolog size 4, PerfScore 6.50, instruction count 14, allocated bytes for code 37 (MethodHash=7c22e346) for method System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (Tier1)
+; Total bytes of code 27, prolog size 4, PerfScore 5.88, instruction count 10, allocated bytes for code 27 (MethodHash=7c22e346) for method System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-0.27%</span>) : 40574.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:<LoadAndValidateAttributes>g__removeObsoleteDiagnosticsForForwardedTypes|199_0(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],byref):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -14,7 +14,7 @@
 ;  V03 arg3         [V03,T53] (  9,  5.50)   byref  ->  rdi         single-def
 ;  V04 loc0         [V04,T04] (  8, 38.98)     ref  ->  r15         class-hnd exact single-def <<unknown class>>
 ;  V05 loc1         [V05,T60] (  5,  5.25)     int  ->  r13         single-def
-;  V06 loc2         [V06,T18] ( 13, 18.56)     int  ->  r12        
+;  V06 loc2         [V06,T18] ( 12, 18.54)     int  ->  r12        
 ;  V07 loc3         [V07,T14] ( 14, 20   )     ref  ->  [rbp-0xB8]  class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
 ;* V08 loc4         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.Location>
 ;* V09 loc5         [V09    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.TypedConstant]>
@@ -115,7 +115,7 @@
 ;* V104 tmp83       [V104    ] (  0,  0   )     ref  ->  zero-ref   
 ;  V105 tmp84       [V105,T33] (  3, 12   )     ref  ->  r13         class-hnd "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V106 tmp85       [V106,T37] (  7,  6.79)     ref  ->  rbx         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V107 tmp86       [V107,T59] (  6,  3.77)     ref  ->  r14         single-def "field V02.array (fldOffset=0x0)" P-INDEP
+;  V107 tmp86       [V107,T59] (  5,  3.75)     ref  ->  r14         single-def "field V02.array (fldOffset=0x0)" P-INDEP
 ;  V108 tmp87       [V108,T56] (  6,  6   )     ref  ->  rax         "field V09.array (fldOffset=0x0)" P-INDEP
 ;* V109 tmp88       [V109    ] (  0,  0   )     ref  ->  zero-ref    "field V10._type (fldOffset=0x0)" P-INDEP
 ;  V110 tmp89       [V110,T63] (  4,  4   )     ref  ->  rdx         "field V10._value (fldOffset=0x8)" P-INDEP
@@ -855,8 +855,6 @@ G_M61315_IG43:        ; bbWeight=0.02, extend
        ; gcr arg pop 0
        test     rax, rax
        je       G_M61315_IG60
-       cmp      r12d, dword ptr [r14+0x08]
-       jae      G_M61315_IG84
        mov      ecx, r12d
        mov      rdx, gword ptr [r14+8*rcx+0x10]
        ; gcrRegs +[rdx]
@@ -891,13 +889,13 @@ G_M61315_IG43:        ; bbWeight=0.02, extend
        ; GC ptr vars +{V59}
        test     rax, rax
        je       G_M61315_IG47
-						;; size=215 bbWeight=0.02 PerfScore 1.18
-G_M61315_IG44:        ; bbWeight=0.02, isz, extend
        mov      rcx, gword ptr [rbp-0xD0]
        ; gcrRegs +[rcx]
        mov      edx, 1
        mov      gword ptr [rbp-0xD0], rcx
        mov      r8, qword ptr [rcx]
+						;; size=227 bbWeight=0.02 PerfScore 1.19
+G_M61315_IG44:        ; bbWeight=0.02, isz, extend
        mov      r8, qword ptr [r8+0x50]
        ; GC ptr vars -{V58}
        call     [r8]Microsoft.CodeAnalysis.SyntaxNode:GetChildPosition(int):int:this
@@ -918,7 +916,7 @@ G_M61315_IG44:        ; bbWeight=0.02, isz, extend
        ; gcrRegs +[rdx]
        test     rdx, rdx
        je       SHORT G_M61315_IG46
-						;; size=64 bbWeight=0.02 PerfScore 0.40
+						;; size=42 bbWeight=0.02 PerfScore 0.32
 G_M61315_IG45:        ; bbWeight=0.01, gcrefRegs=C04D {rax rdx rbx rsi r14 r15}, byrefRegs=0080 {rdi}, byref
        mov      rcx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
        cmp      qword ptr [rdx], rcx
@@ -1753,7 +1751,7 @@ G_M61315_IG102:        ; bbWeight=0, funclet epilog, nogc, extend
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 3696, prolog size 105, PerfScore 1753.33, instruction count 846, allocated bytes for code 3696 (MethodHash=b559107c) for method Microsoft.CodeAnalysis.CSharp.Symbol:<LoadAndValidateAttributes>g__removeObsoleteDiagnosticsForForwardedTypes|199_0(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],byref):this (Tier1)
+; Total bytes of code 3686, prolog size 105, PerfScore 1753.25, instruction count 844, allocated bytes for code 3686 (MethodHash=b559107c) for method Microsoft.CodeAnalysis.CSharp.Symbol:<LoadAndValidateAttributes>g__removeObsoleteDiagnosticsForForwardedTypes|199_0(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],byref):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-0.16%</span>) : 2040.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier0-FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -34,7 +34,7 @@
 ;  V23 loc19        [V23    ] (  2, 16   )   byref  ->  [rsp+0x280]  must-init pinned ptr
 ;* V24 loc20        [V24    ] (  0,  0   )     int  ->  zero-ref   
 ;* V25 loc21        [V25    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[int]>
-;  V26 loc22        [V26,T114] (  6,  6   )     ref  ->  [rsp+0x190]  class-hnd spill-single-def ptr <int[]>
+;  V26 loc22        [V26,T147] (  5,  5.50)     ref  ->  [rsp+0x190]  class-hnd spill-single-def ptr <int[]>
 ;  V27 loc23        [V27,T82] (  6, 12.50)     int  ->  [rsp+0x27C]  ptr
 ;  V28 loc24        [V28,T66] (  7, 17.50)     int  ->  [rsp+0x278]  ptr
 ;  V29 loc25        [V29,T152] (  3,  5   )     int  ->  [rsp+0x274]  spill-single-def ptr
@@ -45,7 +45,7 @@
 ;  V34 loc30        [V34,T11] ( 11, 65   )    long  ->  r14        
 ;  V35 loc31        [V35    ] (  2,  2   )   byref  ->  [rsp+0x260]  must-init pinned ptr
 ;  V36 loc32        [V36,T33] (  8, 33   )    long  ->  r12        
-;  V37 loc33        [V37,T123] (  3,  6   )   ubyte  ->  [rsp+0x25C] 
+;  V37 loc33        [V37,T122] (  3,  6   )   ubyte  ->  [rsp+0x25C] 
 ;  V38 loc34        [V38,T47] (  6, 24   )     int  ->  [rsp+0x258] 
 ;* V39 loc35        [V39    ] (  0,  0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -65,14 +65,14 @@
 ;  V54 tmp14        [V54,T108] (  2,  8   )     int  ->  rdi         "impSpillLclRefs"
 ;  V55 tmp15        [V55,T35] (  2, 32   )     int  ->  rdi         "impSpillLclRefs"
 ;  V56 tmp16        [V56,T13] (  2, 64   )     int  ->  rdi         "dup spill"
-;  V57 tmp17        [V57,T124] (  3,  6   )     int  ->  [rsp+0x254]  ptr
+;  V57 tmp17        [V57,T123] (  3,  6   )     int  ->  [rsp+0x254]  ptr
 ;* V58 tmp18        [V58    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V59 tmp19        [V59    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V60 tmp20        [V60    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;  V61 tmp21        [V61,T83] (  3, 12   )    long  ->  rdx         "impSpillLclRefs"
 ;  V62 tmp22        [V62,T99] (  4,  8   )     int  ->  rdx        
 ;* V63 tmp23        [V63    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V64 tmp24        [V64,T125] (  3,  6   )     int  ->   r8        
+;  V64 tmp24        [V64,T124] (  3,  6   )     int  ->   r8        
 ;  V65 tmp25        [V65,T36] (  2, 32   )     int  ->  rdi         "impSpillLclRefs"
 ;* V66 tmp26        [V66    ] (  0,  0   )   byref  ->  zero-ref    ptr
 ;  V67 tmp27        [V67,T37] (  2, 32   )    long  ->  r12         "impSpillLclRefs"
@@ -174,7 +174,7 @@
 ;* V163 tmp123      [V163    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V164 tmp124      [V164    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V165 tmp125      [V165    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V166 tmp126      [V166,T126] (  3,  6   )     int  ->  [rsp+0x23C]  spill-single-def ptr "Inline stloc first use temp"
+;  V166 tmp126      [V166,T125] (  3,  6   )     int  ->  [rsp+0x23C]  spill-single-def ptr "Inline stloc first use temp"
 ;* V167 tmp127      [V167    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V168 tmp128      [V168    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V169 tmp129      [V169    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -201,7 +201,7 @@
 ;* V190 tmp150      [V190    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V191 tmp151      [V191    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V192 tmp152      [V192    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V193 tmp153      [V193,T127] (  3,  6   )     int  ->  [rsp+0x230]  spill-single-def ptr "Inline stloc first use temp"
+;  V193 tmp153      [V193,T126] (  3,  6   )     int  ->  [rsp+0x230]  spill-single-def ptr "Inline stloc first use temp"
 ;* V194 tmp154      [V194    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V195 tmp155      [V195    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V196 tmp156      [V196    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -228,7 +228,7 @@
 ;* V217 tmp177      [V217    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V218 tmp178      [V218    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V219 tmp179      [V219    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V220 tmp180      [V220,T128] (  3,  6   )     int  ->  [rsp+0x224]  spill-single-def ptr "Inline stloc first use temp"
+;  V220 tmp180      [V220,T127] (  3,  6   )     int  ->  [rsp+0x224]  spill-single-def ptr "Inline stloc first use temp"
 ;* V221 tmp181      [V221    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V222 tmp182      [V222    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V223 tmp183      [V223    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -255,7 +255,7 @@
 ;* V244 tmp204      [V244    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V245 tmp205      [V245    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V246 tmp206      [V246    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V247 tmp207      [V247,T129] (  3,  6   )     int  ->  [rsp+0x21C]  spill-single-def ptr "Inline stloc first use temp"
+;  V247 tmp207      [V247,T128] (  3,  6   )     int  ->  [rsp+0x21C]  spill-single-def ptr "Inline stloc first use temp"
 ;* V248 tmp208      [V248    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V249 tmp209      [V249    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V250 tmp210      [V250    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -397,101 +397,101 @@
 ;* V386 tmp346      [V386    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V144._reference (fldOffset=0x0)" P-INDEP
 ;* V387 tmp347      [V387    ] (  0,  0   )     int  ->  zero-ref    ptr "field V144._length (fldOffset=0x8)" P-INDEP
 ;  V388 tmp348      [V388,T158] (  2,  4   )   byref  ->   r8         "field V146._reference (fldOffset=0x0)" P-INDEP
-;  V389 tmp349      [V389,T130] (  3,  6   )     int  ->  rsi         "field V146._length (fldOffset=0x8)" P-INDEP
+;  V389 tmp349      [V389,T129] (  3,  6   )     int  ->  rsi         "field V146._length (fldOffset=0x8)" P-INDEP
 ;* V390 tmp350      [V390    ] (  0,  0   )   byref  ->  zero-ref    "field V148._reference (fldOffset=0x0)" P-INDEP
 ;* V391 tmp351      [V391    ] (  0,  0   )     int  ->  zero-ref    "field V148._length (fldOffset=0x8)" P-INDEP
 ;* V392 tmp352      [V392    ] (  0,  0   )   byref  ->  zero-ref    "field V150._reference (fldOffset=0x0)" P-INDEP
 ;* V393 tmp353      [V393    ] (  0,  0   )     int  ->  zero-ref    "field V150._length (fldOffset=0x8)" P-INDEP
-;  V394 tmp354      [V394,T115] (  3,  6   )   byref  ->  [rsp+0x120]  ptr "field V153._reference (fldOffset=0x0)" P-INDEP
-;  V395 tmp355      [V395,T131] (  3,  6   )     int  ->  [rsp+0x1F4]  ptr "field V153._length (fldOffset=0x8)" P-INDEP
+;  V394 tmp354      [V394,T114] (  3,  6   )   byref  ->  [rsp+0x120]  ptr "field V153._reference (fldOffset=0x0)" P-INDEP
+;  V395 tmp355      [V395,T130] (  3,  6   )     int  ->  [rsp+0x1F4]  ptr "field V153._length (fldOffset=0x8)" P-INDEP
 ;  V396 tmp356      [V396,T159] (  2,  4   )   byref  ->  [rsp+0x118]  spill-single-def ptr "field V155._reference (fldOffset=0x0)" P-INDEP
 ;  V397 tmp357      [V397,T178] (  2,  4   )     int  ->  [rsp+0x1F0]  spill-single-def ptr "field V155._length (fldOffset=0x8)" P-INDEP
 ;* V398 tmp358      [V398    ] (  0,  0   )   byref  ->  zero-ref    "field V156._reference (fldOffset=0x0)" P-INDEP
 ;* V399 tmp359      [V399    ] (  0,  0   )     int  ->  zero-ref    "field V156._length (fldOffset=0x8)" P-INDEP
-;  V400 tmp360      [V400,T116] (  3,  6   )   byref  ->  [rsp+0x110]  spill-single-def ptr "field V163._reference (fldOffset=0x0)" P-INDEP
+;  V400 tmp360      [V400,T115] (  3,  6   )   byref  ->  [rsp+0x110]  spill-single-def ptr "field V163._reference (fldOffset=0x0)" P-INDEP
 ;* V401 tmp361      [V401    ] (  0,  0   )     int  ->  zero-ref    ptr "field V163._length (fldOffset=0x8)" P-INDEP
 ;  V402 tmp362      [V402,T160] (  2,  4   )   byref  ->  [rsp+0x108]  spill-single-def ptr "field V167._reference (fldOffset=0x0)" P-INDEP
-;  V403 tmp363      [V403,T132] (  3,  6   )     int  ->  [rsp+0x1EC]  spill-single-def ptr "field V167._length (fldOffset=0x8)" P-INDEP
+;  V403 tmp363      [V403,T131] (  3,  6   )     int  ->  [rsp+0x1EC]  spill-single-def ptr "field V167._length (fldOffset=0x8)" P-INDEP
 ;* V404 tmp364      [V404    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V168._reference (fldOffset=0x0)" P-INDEP
 ;* V405 tmp365      [V405    ] (  0,  0   )     int  ->  zero-ref    "field V168._length (fldOffset=0x8)" P-INDEP
 ;  V406 tmp366      [V406,T161] (  2,  4   )   byref  ->  [rsp+0x100]  spill-single-def ptr "field V173._reference (fldOffset=0x0)" P-INDEP
-;  V407 tmp367      [V407,T133] (  3,  6   )     int  ->  [rsp+0x1E8]  spill-single-def ptr "field V173._length (fldOffset=0x8)" P-INDEP
+;  V407 tmp367      [V407,T132] (  3,  6   )     int  ->  [rsp+0x1E8]  spill-single-def ptr "field V173._length (fldOffset=0x8)" P-INDEP
 ;* V408 tmp368      [V408    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V174._reference (fldOffset=0x0)" P-INDEP
 ;* V409 tmp369      [V409    ] (  0,  0   )     int  ->  zero-ref    ptr "field V174._length (fldOffset=0x8)" P-INDEP
 ;* V410 tmp370      [V410    ] (  0,  0   )   byref  ->  zero-ref    "field V175._reference (fldOffset=0x0)" P-INDEP
 ;* V411 tmp371      [V411    ] (  0,  0   )     int  ->  zero-ref    "field V175._length (fldOffset=0x8)" P-INDEP
 ;* V412 tmp372      [V412    ] (  0,  0   )   byref  ->  zero-ref    "field V177._reference (fldOffset=0x0)" P-INDEP
 ;* V413 tmp373      [V413    ] (  0,  0   )     int  ->  zero-ref    "field V177._length (fldOffset=0x8)" P-INDEP
-;  V414 tmp374      [V414,T117] (  3,  6   )   byref  ->  [rsp+0xF8]  ptr "field V180._reference (fldOffset=0x0)" P-INDEP
-;  V415 tmp375      [V415,T134] (  3,  6   )     int  ->  [rsp+0x1E4]  ptr "field V180._length (fldOffset=0x8)" P-INDEP
+;  V414 tmp374      [V414,T116] (  3,  6   )   byref  ->  [rsp+0xF8]  ptr "field V180._reference (fldOffset=0x0)" P-INDEP
+;  V415 tmp375      [V415,T133] (  3,  6   )     int  ->  [rsp+0x1E4]  ptr "field V180._length (fldOffset=0x8)" P-INDEP
 ;  V416 tmp376      [V416,T162] (  2,  4   )   byref  ->  [rsp+0xF0]  spill-single-def ptr "field V182._reference (fldOffset=0x0)" P-INDEP
 ;  V417 tmp377      [V417,T179] (  2,  4   )     int  ->  [rsp+0x1E0]  spill-single-def ptr "field V182._length (fldOffset=0x8)" P-INDEP
 ;* V418 tmp378      [V418    ] (  0,  0   )   byref  ->  zero-ref    "field V183._reference (fldOffset=0x0)" P-INDEP
 ;* V419 tmp379      [V419    ] (  0,  0   )     int  ->  zero-ref    "field V183._length (fldOffset=0x8)" P-INDEP
-;  V420 tmp380      [V420,T118] (  3,  6   )   byref  ->  [rsp+0xE8]  spill-single-def ptr "field V190._reference (fldOffset=0x0)" P-INDEP
+;  V420 tmp380      [V420,T117] (  3,  6   )   byref  ->  [rsp+0xE8]  spill-single-def ptr "field V190._reference (fldOffset=0x0)" P-INDEP
 ;* V421 tmp381      [V421    ] (  0,  0   )     int  ->  zero-ref    ptr "field V190._length (fldOffset=0x8)" P-INDEP
 ;  V422 tmp382      [V422,T163] (  2,  4   )   byref  ->  [rsp+0xE0]  spill-single-def ptr "field V194._reference (fldOffset=0x0)" P-INDEP
-;  V423 tmp383      [V423,T135] (  3,  6   )     int  ->  [rsp+0x1DC]  spill-single-def ptr "field V194._length (fldOffset=0x8)" P-INDEP
+;  V423 tmp383      [V423,T134] (  3,  6   )     int  ->  [rsp+0x1DC]  spill-single-def ptr "field V194._length (fldOffset=0x8)" P-INDEP
 ;* V424 tmp384      [V424    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V195._reference (fldOffset=0x0)" P-INDEP
 ;* V425 tmp385      [V425    ] (  0,  0   )     int  ->  zero-ref    "field V195._length (fldOffset=0x8)" P-INDEP
 ;  V426 tmp386      [V426,T164] (  2,  4   )   byref  ->  [rsp+0xD8]  spill-single-def ptr "field V200._reference (fldOffset=0x0)" P-INDEP
-;  V427 tmp387      [V427,T136] (  3,  6   )     int  ->  [rsp+0x1D8]  spill-single-def ptr "field V200._length (fldOffset=0x8)" P-INDEP
+;  V427 tmp387      [V427,T135] (  3,  6   )     int  ->  [rsp+0x1D8]  spill-single-def ptr "field V200._length (fldOffset=0x8)" P-INDEP
 ;* V428 tmp388      [V428    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V201._reference (fldOffset=0x0)" P-INDEP
 ;* V429 tmp389      [V429    ] (  0,  0   )     int  ->  zero-ref    ptr "field V201._length (fldOffset=0x8)" P-INDEP
 ;* V430 tmp390      [V430    ] (  0,  0   )   byref  ->  zero-ref    "field V202._reference (fldOffset=0x0)" P-INDEP
 ;* V431 tmp391      [V431    ] (  0,  0   )     int  ->  zero-ref    "field V202._length (fldOffset=0x8)" P-INDEP
 ;* V432 tmp392      [V432    ] (  0,  0   )   byref  ->  zero-ref    "field V204._reference (fldOffset=0x0)" P-INDEP
 ;* V433 tmp393      [V433    ] (  0,  0   )     int  ->  zero-ref    "field V204._length (fldOffset=0x8)" P-INDEP
-;  V434 tmp394      [V434,T119] (  3,  6   )   byref  ->  [rsp+0xD0]  ptr "field V207._reference (fldOffset=0x0)" P-INDEP
-;  V435 tmp395      [V435,T137] (  3,  6   )     int  ->  [rsp+0x1D4]  ptr "field V207._length (fldOffset=0x8)" P-INDEP
+;  V434 tmp394      [V434,T118] (  3,  6   )   byref  ->  [rsp+0xD0]  ptr "field V207._reference (fldOffset=0x0)" P-INDEP
+;  V435 tmp395      [V435,T136] (  3,  6   )     int  ->  [rsp+0x1D4]  ptr "field V207._length (fldOffset=0x8)" P-INDEP
 ;  V436 tmp396      [V436,T165] (  2,  4   )   byref  ->  [rsp+0xC8]  spill-single-def ptr "field V209._reference (fldOffset=0x0)" P-INDEP
 ;  V437 tmp397      [V437,T180] (  2,  4   )     int  ->  [rsp+0x1D0]  spill-single-def ptr "field V209._length (fldOffset=0x8)" P-INDEP
 ;* V438 tmp398      [V438    ] (  0,  0   )   byref  ->  zero-ref    "field V210._reference (fldOffset=0x0)" P-INDEP
 ;* V439 tmp399      [V439    ] (  0,  0   )     int  ->  zero-ref    "field V210._length (fldOffset=0x8)" P-INDEP
-;  V440 tmp400      [V440,T120] (  3,  6   )   byref  ->  [rsp+0xC0]  spill-single-def ptr "field V217._reference (fldOffset=0x0)" P-INDEP
+;  V440 tmp400      [V440,T119] (  3,  6   )   byref  ->  [rsp+0xC0]  spill-single-def ptr "field V217._reference (fldOffset=0x0)" P-INDEP
 ;* V441 tmp401      [V441    ] (  0,  0   )     int  ->  zero-ref    ptr "field V217._length (fldOffset=0x8)" P-INDEP
 ;  V442 tmp402      [V442,T166] (  2,  4   )   byref  ->  [rsp+0xB8]  spill-single-def ptr "field V221._reference (fldOffset=0x0)" P-INDEP
-;  V443 tmp403      [V443,T138] (  3,  6   )     int  ->  [rsp+0x1CC]  spill-single-def ptr "field V221._length (fldOffset=0x8)" P-INDEP
+;  V443 tmp403      [V443,T137] (  3,  6   )     int  ->  [rsp+0x1CC]  spill-single-def ptr "field V221._length (fldOffset=0x8)" P-INDEP
 ;* V444 tmp404      [V444    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V222._reference (fldOffset=0x0)" P-INDEP
 ;* V445 tmp405      [V445    ] (  0,  0   )     int  ->  zero-ref    "field V222._length (fldOffset=0x8)" P-INDEP
 ;  V446 tmp406      [V446,T167] (  2,  4   )   byref  ->  [rsp+0xB0]  spill-single-def ptr "field V227._reference (fldOffset=0x0)" P-INDEP
-;  V447 tmp407      [V447,T139] (  3,  6   )     int  ->  [rsp+0x1C8]  spill-single-def ptr "field V227._length (fldOffset=0x8)" P-INDEP
+;  V447 tmp407      [V447,T138] (  3,  6   )     int  ->  [rsp+0x1C8]  spill-single-def ptr "field V227._length (fldOffset=0x8)" P-INDEP
 ;* V448 tmp408      [V448    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V228._reference (fldOffset=0x0)" P-INDEP
 ;* V449 tmp409      [V449    ] (  0,  0   )     int  ->  zero-ref    ptr "field V228._length (fldOffset=0x8)" P-INDEP
 ;* V450 tmp410      [V450    ] (  0,  0   )   byref  ->  zero-ref    "field V229._reference (fldOffset=0x0)" P-INDEP
 ;* V451 tmp411      [V451    ] (  0,  0   )     int  ->  zero-ref    "field V229._length (fldOffset=0x8)" P-INDEP
 ;* V452 tmp412      [V452    ] (  0,  0   )   byref  ->  zero-ref    "field V231._reference (fldOffset=0x0)" P-INDEP
 ;* V453 tmp413      [V453    ] (  0,  0   )     int  ->  zero-ref    "field V231._length (fldOffset=0x8)" P-INDEP
-;  V454 tmp414      [V454,T121] (  3,  6   )   byref  ->  [rsp+0xA8]  ptr "field V234._reference (fldOffset=0x0)" P-INDEP
-;  V455 tmp415      [V455,T140] (  3,  6   )     int  ->  [rsp+0x1C4]  ptr "field V234._length (fldOffset=0x8)" P-INDEP
+;  V454 tmp414      [V454,T120] (  3,  6   )   byref  ->  [rsp+0xA8]  ptr "field V234._reference (fldOffset=0x0)" P-INDEP
+;  V455 tmp415      [V455,T139] (  3,  6   )     int  ->  [rsp+0x1C4]  ptr "field V234._length (fldOffset=0x8)" P-INDEP
 ;  V456 tmp416      [V456,T168] (  2,  4   )   byref  ->   r8         "field V236._reference (fldOffset=0x0)" P-INDEP
 ;  V457 tmp417      [V457,T181] (  2,  4   )     int  ->  rdx         "field V236._length (fldOffset=0x8)" P-INDEP
 ;* V458 tmp418      [V458    ] (  0,  0   )   byref  ->  zero-ref    "field V237._reference (fldOffset=0x0)" P-INDEP
 ;* V459 tmp419      [V459    ] (  0,  0   )     int  ->  zero-ref    "field V237._length (fldOffset=0x8)" P-INDEP
-;  V460 tmp420      [V460,T122] (  3,  6   )   byref  ->  [rsp+0xA0]  spill-single-def ptr "field V244._reference (fldOffset=0x0)" P-INDEP
+;  V460 tmp420      [V460,T121] (  3,  6   )   byref  ->  [rsp+0xA0]  spill-single-def ptr "field V244._reference (fldOffset=0x0)" P-INDEP
 ;* V461 tmp421      [V461    ] (  0,  0   )     int  ->  zero-ref    ptr "field V244._length (fldOffset=0x8)" P-INDEP
 ;  V462 tmp422      [V462,T169] (  2,  4   )   byref  ->  [rsp+0x98]  spill-single-def ptr "field V248._reference (fldOffset=0x0)" P-INDEP
-;  V463 tmp423      [V463,T141] (  3,  6   )     int  ->  [rsp+0x1C0]  spill-single-def ptr "field V248._length (fldOffset=0x8)" P-INDEP
+;  V463 tmp423      [V463,T140] (  3,  6   )     int  ->  [rsp+0x1C0]  spill-single-def ptr "field V248._length (fldOffset=0x8)" P-INDEP
 ;* V464 tmp424      [V464    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V249._reference (fldOffset=0x0)" P-INDEP
 ;* V465 tmp425      [V465    ] (  0,  0   )     int  ->  zero-ref    "field V249._length (fldOffset=0x8)" P-INDEP
 ;  V466 tmp426      [V466,T170] (  2,  4   )   byref  ->  [rsp+0x90]  spill-single-def ptr "field V254._reference (fldOffset=0x0)" P-INDEP
-;  V467 tmp427      [V467,T142] (  3,  6   )     int  ->  [rsp+0x1BC]  spill-single-def ptr "field V254._length (fldOffset=0x8)" P-INDEP
+;  V467 tmp427      [V467,T141] (  3,  6   )     int  ->  [rsp+0x1BC]  spill-single-def ptr "field V254._length (fldOffset=0x8)" P-INDEP
 ;* V468 tmp428      [V468    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V255._reference (fldOffset=0x0)" P-INDEP
 ;* V469 tmp429      [V469    ] (  0,  0   )     int  ->  zero-ref    ptr "field V255._length (fldOffset=0x8)" P-INDEP
 ;  V470 tmp430      [V470,T77] (  2, 16   )   byref  ->  [rsp+0x88]  spill-single-def ptr "field V261._reference (fldOffset=0x0)" P-INDEP
 ;  V471 tmp431      [V471,T58] (  3, 24   )     int  ->  rsi         "field V261._length (fldOffset=0x8)" P-INDEP
 ;  V472 tmp432      [V472,T171] (  2,  4   )   byref  ->  [rsp+0x80]  spill-single-def ptr "field V268._reference (fldOffset=0x0)" P-INDEP
-;  V473 tmp433      [V473,T143] (  3,  6   )     int  ->  [rsp+0x1B8]  spill-single-def ptr "field V268._length (fldOffset=0x8)" P-INDEP
+;  V473 tmp433      [V473,T142] (  3,  6   )     int  ->  [rsp+0x1B8]  spill-single-def ptr "field V268._length (fldOffset=0x8)" P-INDEP
 ;  V474 tmp434      [V474,T172] (  2,  4   )   byref  ->  [rsp+0x78]  spill-single-def ptr "field V271._reference (fldOffset=0x0)" P-INDEP
-;  V475 tmp435      [V475,T144] (  3,  6   )     int  ->  [rsp+0x1B4]  spill-single-def ptr "field V271._length (fldOffset=0x8)" P-INDEP
+;  V475 tmp435      [V475,T143] (  3,  6   )     int  ->  [rsp+0x1B4]  spill-single-def ptr "field V271._length (fldOffset=0x8)" P-INDEP
 ;  V476 tmp436      [V476,T173] (  2,  4   )   byref  ->  [rsp+0x70]  spill-single-def ptr "field V274._reference (fldOffset=0x0)" P-INDEP
-;  V477 tmp437      [V477,T145] (  3,  6   )     int  ->  [rsp+0x1B0]  spill-single-def ptr "field V274._length (fldOffset=0x8)" P-INDEP
+;  V477 tmp437      [V477,T144] (  3,  6   )     int  ->  [rsp+0x1B0]  spill-single-def ptr "field V274._length (fldOffset=0x8)" P-INDEP
 ;  V478 tmp438      [V478,T174] (  2,  4   )   byref  ->  rdx         "field V279._reference (fldOffset=0x0)" P-INDEP
-;  V479 tmp439      [V479,T146] (  3,  6   )     int  ->  rax         "field V279._length (fldOffset=0x8)" P-INDEP
+;  V479 tmp439      [V479,T145] (  3,  6   )     int  ->  rax         "field V279._length (fldOffset=0x8)" P-INDEP
 ;  V480 tmp440      [V480,T78] (  2, 16   )   byref  ->  rdx         "field V284._reference (fldOffset=0x0)" P-INDEP
 ;  V481 tmp441      [V481,T59] (  3, 24   )     int  ->  rax         "field V284._length (fldOffset=0x8)" P-INDEP
 ;  V482 tmp442      [V482,T175] (  2,  4   )   byref  ->  rdx         "field V288._reference (fldOffset=0x0)" P-INDEP
-;  V483 tmp443      [V483,T147] (  3,  6   )     int  ->  rax         "field V288._length (fldOffset=0x8)" P-INDEP
+;  V483 tmp443      [V483,T146] (  3,  6   )     int  ->  rax         "field V288._length (fldOffset=0x8)" P-INDEP
 ;* V484 tmp444      [V484    ] (  0,  0   )   byref  ->  zero-ref    "field V290._reference (fldOffset=0x0)" P-INDEP
 ;* V485 tmp445      [V485    ] (  0,  0   )     int  ->  zero-ref    "field V290._length (fldOffset=0x8)" P-INDEP
 ;* V486 tmp446      [V486    ] (  0,  0   )   byref  ->  zero-ref    "field V292._reference (fldOffset=0x0)" P-INDEP
@@ -1042,13 +1042,11 @@ G_M54741_IG54:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000
        je       SHORT G_M54741_IG55
        mov      r12, gword ptr [rsp+0x190]
        ; gcrRegs +[r12]
-       cmp      dword ptr [r12+0x08], 0
-       jbe      G_M54741_IG178
        mov      r12d, dword ptr [r12+0x10]
        ; gcrRegs -[r12]
        mov      dword ptr [rsp+0x278], r12d
-						;; size=121 bbWeight=0.50 PerfScore 13.38
-G_M54741_IG55:        ; bbWeight=0.50, gcVars=000000000000000000000000000000000004000000000000C000500000000000 {V26 V308 V500 V508 V510}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
+						;; size=109 bbWeight=0.50 PerfScore 11.38
+G_M54741_IG55:        ; bbWeight=0.50, gcVars=000000000000000000000000000800000000000000000000C000500000000000 {V26 V308 V500 V508 V510}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
        mov      r12d, dword ptr [rsp+0x278]
        mov      dword ptr [rsp+0x270], r12d
        xor      r12d, r12d
@@ -1107,7 +1105,7 @@ G_M54741_IG57:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14},
        ; GC ptr vars +{V308}
        mov      r9d, dword ptr [rsp+0x2B8]
 						;; size=102 bbWeight=2 PerfScore 33.00
-G_M54741_IG58:        ; bbWeight=4, gcVars=000000000000000000000000000000000004000000000000C000500000000000 {V26 V308 V500 V508 V510}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG58:        ; bbWeight=4, gcVars=000000000000000000000000000800000000000000000000C000500000000000 {V26 V308 V500 V508 V510}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; byrRegs -[rdx r12 r14]
        mov      ecx, dword ptr [rsp+0x290]
        mov      dword ptr [rsp+0x1FC], ebx
@@ -1324,7 +1322,7 @@ G_M54741_IG73:        ; bbWeight=0.25, gcVars=0000000000000000000000000000000000
 G_M54741_IG74:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=5020 {rbp r12 r14}, byref
        jmp      G_M54741_IG64
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M54741_IG75:        ; bbWeight=2, gcVars=000000000000000000000000000000000004000000000000C000500000000000 {V26 V308 V500 V508 V510}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
+G_M54741_IG75:        ; bbWeight=2, gcVars=000000000000000000000000000800000000000000000000C000500000000000 {V26 V308 V500 V508 V510}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
        ; byrRegs -[r12]
        ; GC ptr vars -{V44 V46 V62} +{V26}
        jmp      G_M54741_IG58
@@ -1807,7 +1805,7 @@ G_M54741_IG116:        ; bbWeight=2, gcVars=000000000000000000000000000000000000
        ; byrRegs -[rdx]
        mov      dword ptr [rsp+0x1F4], edx
 						;; size=90 bbWeight=2 PerfScore 26.50
-G_M54741_IG117:        ; bbWeight=2, gcVars=000000000000000000000000000000000008000000000000C000400000000000 {V308 V394 V508 V510}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG117:        ; bbWeight=2, gcVars=000000000000000000000000000000000004000000000000C000400000000000 {V308 V394 V508 V510}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; GC ptr vars -{V69 V154 V158 V396}
        mov      rdx, bword ptr [rsp+0x120]
        ; byrRegs +[rdx]
@@ -1970,7 +1968,7 @@ G_M54741_IG126:        ; bbWeight=2, gcVars=000000000000000000000000000000000000
        ; byrRegs -[r8]
        mov      dword ptr [rsp+0x1E4], r8d
 						;; size=96 bbWeight=2 PerfScore 26.50
-G_M54741_IG127:        ; bbWeight=2, gcVars=000000000000000000000000000000000020000000000000C000400000000000 {V308 V414 V508 V510}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG127:        ; bbWeight=2, gcVars=000000000000000000000000000000000010000000000000C000400000000000 {V308 V414 V508 V510}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; GC ptr vars -{V181 V185 V416}
        mov      r8, bword ptr [rsp+0xF8]
...

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-0.09%</span>) : 28218.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,8 +16,8 @@
 ;* V05 arg5         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Globalization.CultureInfo>
 ;  V06 arg6         [V06,T107] (  6,  7   )     ref  ->  [rbp+0x40]  class-hnd single-def <System.String[]>
 ;  V07 arg7         [V07,T136] (  3,  2   )   byref  ->  [rbp+0x48]  single-def
-;  V08 loc0         [V08,T16] ( 54, 58.41)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
-;  V09 loc1         [V09,T01] (122,226.53)     int  ->  [rbp-0x3C] 
+;  V08 loc0         [V08,T16] ( 53, 58.37)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
+;  V09 loc1         [V09,T01] (121,226.49)     int  ->  [rbp-0x3C] 
 ;  V10 loc2         [V10,T00] (110,467.32)     int  ->  [rbp-0x40] 
 ;  V11 loc3         [V11,T12] ( 57, 67.80)     ref  ->  r13         class-hnd exact single-def <<unknown class>>
 ;  V12 loc4         [V12,T29] ( 37, 36.27)     ref  ->  r12         class-hnd exact single-def <System.Type[]>
@@ -401,8 +401,6 @@ G_M46529_IG16:        ; bbWeight=1.98, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4
        jmp      G_M46529_IG29
 						;; size=5 bbWeight=1.98 PerfScore 3.96
 G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4008 {rbx r14}, byref, isz
-       cmp      r12d, dword ptr [r15+0x08]
-       jae      G_M46529_IG228
        mov      ecx, r12d
        mov      rcx, gword ptr [r15+8*rcx+0x10]
        ; gcrRegs +[rcx]
@@ -417,7 +415,7 @@ G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4
        ; gcrRegs +[rcx]
        cmp      edx, dword ptr [rcx+0x08]
        jg       SHORT G_M46529_IG19
-						;; size=43 bbWeight=0.04 PerfScore 0.83
+						;; size=33 bbWeight=0.04 PerfScore 0.67
 G_M46529_IG18:        ; bbWeight=0.02, gcrefRegs=A040 {rsi r13 r15}, byrefRegs=4008 {rbx r14}, byref, isz
        ; gcrRegs -[rcx]
        mov      rdx, gword ptr [rbx]
@@ -4333,7 +4331,7 @@ G_M46529_IG241:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 10608, prolog size 78, PerfScore 6135.68, instruction count 2471, allocated bytes for code 10608 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
+; Total bytes of code 10598, prolog size 78, PerfScore 6135.52, instruction count 2469, allocated bytes for code 10598 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-32.26%</span>) : 186082.dasm - Tests:ZeroInBounds(int[]) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <int[]>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -22,24 +22,17 @@ G_M1557_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        test     eax, eax
        je       SHORT G_M1557_IG04
 						;; size=7 bbWeight=1 PerfScore 3.25
-G_M1557_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
-       test     eax, eax
-       je       SHORT G_M1557_IG05
+G_M1557_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        xor      eax, eax
        mov      dword ptr [rcx+0x10], eax
-						;; size=9 bbWeight=0.50 PerfScore 1.25
+						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M1557_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx]
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M1557_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 31, prolog size 4, PerfScore 6.00, instruction count 12, allocated bytes for code 31 (MethodHash=5785f9ea) for method Tests:ZeroInBounds(int[]) (FullOpts)
+; Total bytes of code 21, prolog size 4, PerfScore 5.38, instruction count 8, allocated bytes for code 21 (MethodHash=5785f9ea) for method Tests:ZeroInBounds(int[]) (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-31.43%</span>) : 186081.dasm - Tests:EqualsReversedInBound(int[]) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <int[]>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -22,23 +22,16 @@ G_M8831_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        cmp      eax, 6
        jne      SHORT G_M8831_IG04
 						;; size=8 bbWeight=1 PerfScore 3.25
-G_M8831_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
-       cmp      eax, 5
-       jbe      SHORT G_M8831_IG05
+G_M8831_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        mov      dword ptr [rcx+0x24], 1
-						;; size=12 bbWeight=0.50 PerfScore 1.12
+						;; size=7 bbWeight=0.50 PerfScore 0.50
 G_M8831_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx]
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M8831_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 35, prolog size 4, PerfScore 5.88, instruction count 11, allocated bytes for code 35 (MethodHash=4583dd80) for method Tests:EqualsReversedInBound(int[]) (FullOpts)
+; Total bytes of code 24, prolog size 4, PerfScore 5.25, instruction count 7, allocated bytes for code 24 (MethodHash=4583dd80) for method Tests:EqualsReversedInBound(int[]) (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-31.43%</span>) : 186091.dasm - Program+<>c:<TestEntryPoint>b__2_0(int[]):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,7 +11,7 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Program+<>c>
 ;  V01 arg1         [V01,T00] (  4,  3.50)     ref  ->  rdx         class-hnd single-def <int[]>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 cse0         [V03,T01] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
+;  V03 cse0         [V03,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -24,23 +24,16 @@ G_M48389_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byr
        cmp      eax, 6
        jne      SHORT G_M48389_IG04
 						;; size=8 bbWeight=1 PerfScore 3.25
-G_M48389_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
-       cmp      eax, 5
-       jbe      SHORT G_M48389_IG05
+G_M48389_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        mov      dword ptr [rdx+0x24], 1
-						;; size=12 bbWeight=0.50 PerfScore 1.12
+						;; size=7 bbWeight=0.50 PerfScore 0.50
 G_M48389_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rdx]
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M48389_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 35, prolog size 4, PerfScore 5.88, instruction count 11, allocated bytes for code 35 (MethodHash=711642fa) for method Program+<>c:<TestEntryPoint>b__2_0(int[]):this (FullOpts)
+; Total bytes of code 24, prolog size 4, PerfScore 5.25, instruction count 7, allocated bytes for code 24 (MethodHash=711642fa) for method Program+<>c:<TestEntryPoint>b__2_0(int[]):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-0.08%</span>) : 173352.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:bindUserDefinedConversion(Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,ubyte,byref,ubyte):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -39,7 +39,7 @@
 ;  V28 loc21        [V28,T103] (  7,  4.50)     int  ->  [rsp+0x1CC] 
 ;  V29 loc22        [V29,T94] (  6,  7   )     int  ->  [rsp+0x1C8] 
 ;* V30 loc23        [V30    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <Microsoft.CSharp.RuntimeBinder.Semantics.MethWithInst>
-;  V31 loc24        [V31,T113] (  7,  3.50)     ref  ->  r14         class-hnd <Microsoft.CSharp.RuntimeBinder.Semantics.Expr>
+;  V31 loc24        [V31,T112] (  7,  3.50)     ref  ->  r14         class-hnd <Microsoft.CSharp.RuntimeBinder.Semantics.Expr>
 ;  V32 loc25        [V32    ] (  3,  1.50)     ref  ->  [rsp+0x1C0]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <Microsoft.CSharp.RuntimeBinder.Semantics.Expr>
 ;  V33 loc26        [V33,T79] ( 10, 16.54)     int  ->  [rsp+0x1BC] 
 ;  V34 loc27        [V34,T19] ( 20,204   )     ref  ->  [rsp+0x118]  class-hnd <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
@@ -71,7 +71,7 @@
 ;  V60 tmp1         [V60,T146] (  3,  1.50)     int  ->  rcx        
 ;* V61 tmp2         [V61    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
 ;* V62 tmp3         [V62    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
-;  V63 tmp4         [V63,T115] (  3,  3   )     ref  ->  [rsp+0x100]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Collections.Generic.List`1[Microsoft.CSharp.RuntimeBinder.Semantics.UdConvInfo]>
+;  V63 tmp4         [V63,T114] (  3,  3   )     ref  ->  [rsp+0x100]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Collections.Generic.List`1[Microsoft.CSharp.RuntimeBinder.Semantics.UdConvInfo]>
 ;  V64 tmp5         [V64,T67] (  8, 32   )     int  ->   r8        
 ;  V65 tmp6         [V65,T38] (  4,128   )     int  ->  rax         "dup spill"
 ;  V66 tmp7         [V66,T45] (  6, 96   )     int  ->  registers  
@@ -92,12 +92,12 @@
 ;  V81 tmp22        [V81,T104] (  5,  4.25)     ref  ->  r13         class-hnd exact "impAppendStmt" <Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol>
 ;* V82 tmp23        [V82    ] (  0,  0   )  struct (16) zero-ref    "location for address-of(RValue)" <Microsoft.CSharp.RuntimeBinder.Semantics.UdConvInfo>
 ;  V83 tmp24        [V83,T77] ( 18, 18   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CSharp.RuntimeBinder.Semantics.MethWithInst>
-;  V84 tmp25        [V84,T116] (  3,  3   )     ref  ->  r14         class-hnd single-def "impAppendStmt" <Microsoft.CSharp.RuntimeBinder.Semantics.CType>
-;  V85 tmp26        [V85,T117] (  3,  3   )     ref  ->  r14         class-hnd single-def "impAppendStmt" <Microsoft.CSharp.RuntimeBinder.Semantics.CType>
+;  V84 tmp25        [V84,T115] (  3,  3   )     ref  ->  r14         class-hnd single-def "impAppendStmt" <Microsoft.CSharp.RuntimeBinder.Semantics.CType>
+;  V85 tmp26        [V85,T116] (  3,  3   )     ref  ->  r14         class-hnd single-def "impAppendStmt" <Microsoft.CSharp.RuntimeBinder.Semantics.CType>
 ;  V86 tmp27        [V86,T147] (  3,  1.50)     int  ->  rdx        
 ;  V87 tmp28        [V87,T125] (  2,  2   )     ref  ->  r12         class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.NullableType>
 ;  V88 tmp29        [V88,T134] (  3,  1.50)     ref  ->  rdx         class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.NullableType>
-;  V89 tmp30        [V89,T109] (  4,  4   )     int  ->  rdx         "impSpillLclRefs"
+;  V89 tmp30        [V89,T121] (  3,  3   )     int  ->  rdx         "impSpillLclRefs"
 ;* V90 tmp31        [V90    ] (  0,  0   )     int  ->  zero-ref    "impSpillLclRefs"
 ;  V91 tmp32        [V91,T148] (  3,  1.50)     int  ->  rcx        
 ;  V92 tmp33        [V92,T127] (  2,  2   )     ref  ->  rcx         class-hnd "spilling QMark2" <<unknown class>>
@@ -178,7 +178,7 @@
 ;  V167 tmp108      [V167,T62] (  5, 36   )     ref  ->  [rsp+0x60]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CSharp.RuntimeBinder.Semantics.SubstContext>
 ;* V168 tmp109      [V168    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CSharp.RuntimeBinder.Semantics.SubstContext>
 ;* V169 tmp110      [V169    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.MethWithType>
-;  V170 tmp111      [V170,T114] (  4,  3.50)     ref  ->  r14         single-def "CASTCLASS eval op1"
+;  V170 tmp111      [V170,T113] (  4,  3.50)     ref  ->  r14         single-def "CASTCLASS eval op1"
 ;* V171 tmp112      [V171    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol>
 ;* V172 tmp113      [V172    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.MethWithType>
 ;  V173 tmp114      [V173,T128] (  2,  2   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
@@ -191,7 +191,7 @@
 ;  V180 tmp121      [V180,T122] (  4,  2.75)     ref  ->  rcx         single-def "CASTCLASS eval op1"
 ;  V181 tmp122      [V181,T136] (  3,  1.50)     ref  ->  rax         class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol>
 ;  V182 tmp123      [V182,T129] (  2,  2   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray>
-;  V183 tmp124      [V183,T118] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
+;  V183 tmp124      [V183,T117] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
 ;* V184 tmp125      [V184    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V185 tmp126      [V185    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V186 tmp127      [V186,T137] (  3,  1.50)     ref  ->  r13        
@@ -200,11 +200,11 @@
 ;* V189 tmp130      [V189    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inline stloc first use temp" <Microsoft.CSharp.RuntimeBinder.Semantics.SubstContext>
 ;  V190 tmp131      [V190,T123] (  4,  2.75)     ref  ->  rcx         single-def "CASTCLASS eval op1"
 ;  V191 tmp132      [V191,T138] (  3,  1.50)     ref  ->  rax         class-hnd "spilling QMark2" <Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol>
-;  V192 tmp133      [V192,T119] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
+;  V192 tmp133      [V192,T118] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>
 ;* V193 tmp134      [V193    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V194 tmp135      [V194    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V195 tmp136      [V195,T139] (  3,  1.50)     ref  ->  r12        
-;  V196 tmp137      [V196,T112] (  8,  3.75)     ref  ->  r12         class-hnd "Inline return value spill temp" <Microsoft.CSharp.RuntimeBinder.Semantics.CType>
+;  V196 tmp137      [V196,T111] (  8,  3.75)     ref  ->  r12         class-hnd "Inline return value spill temp" <Microsoft.CSharp.RuntimeBinder.Semantics.CType>
 ;  V197 tmp138      [V197,T108] (  4,  4   )     ref  ->  [rsp+0x58]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CSharp.RuntimeBinder.Semantics.SubstContext>
 ;* V198 tmp139      [V198    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inline stloc first use temp" <Microsoft.CSharp.RuntimeBinder.Semantics.SubstContext>
 ;  V199 tmp140      [V199,T86] ( 10, 10   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CSharp.RuntimeBinder.Semantics.ExprCall>
@@ -230,9 +230,9 @@
 ;* V219 tmp160      [V219    ] (  0,  0   )   ubyte  ->  zero-ref    "field V70.DstImplicit (fldOffset=0x9)" P-INDEP
 ;* V220 tmp161      [V220    ] (  0,  0   )     ref  ->  zero-ref    "field V78.Meth (fldOffset=0x0)" P-INDEP
 ;* V221 tmp162      [V221    ] (  0,  0   )   ubyte  ->  zero-ref    "field V78.SrcImplicit (fldOffset=0x8)" P-INDEP
-;  V222 tmp163      [V222,T110] (  2,  4   )   ubyte  ->  r11         "field V78.DstImplicit (fldOffset=0x9)" P-INDEP
+;  V222 tmp163      [V222,T109] (  2,  4   )   ubyte  ->  r11         "field V78.DstImplicit (fldOffset=0x9)" P-INDEP
 ;* V223 tmp164      [V223    ] (  0,  0   )     ref  ->  zero-ref    "field V79.Meth (fldOffset=0x0)" P-INDEP
-;  V224 tmp165      [V224,T111] (  2,  4   )   ubyte  ->  r11         "field V79.SrcImplicit (fldOffset=0x8)" P-INDEP
+;  V224 tmp165      [V224,T110] (  2,  4   )   ubyte  ->  r11         "field V79.SrcImplicit (fldOffset=0x8)" P-INDEP
 ;* V225 tmp166      [V225    ] (  0,  0   )   ubyte  ->  zero-ref    "field V79.DstImplicit (fldOffset=0x9)" P-INDEP
 ;  V226 tmp167      [V226,T155] (  2,  1   )     ref  ->  rax         single-def "field V80.Meth (fldOffset=0x0)" P-INDEP
 ;* V227 tmp168      [V227    ] (  0,  0   )   ubyte  ->  zero-ref    "field V80.SrcImplicit (fldOffset=0x8)" P-INDEP
@@ -253,9 +253,9 @@
 ;  V242 tmp183      [V242,T71] (  3, 24   )     ref  ->  rsi         "arr expr"
 ;  V243 tmp184      [V243,T83] (  3, 12   )     ref  ->  [rsp+0x48]  spill-single-def "arr expr"
 ;  V244 tmp185      [V244,T84] (  3, 12   )     ref  ->  [rsp+0x40]  spill-single-def "arr expr"
-;  V245 tmp186      [V245,T120] (  3,  3   )     ref  ->  rcx         single-def "arr expr"
+;  V245 tmp186      [V245,T119] (  3,  3   )     ref  ->  rcx         single-def "arr expr"
 ;* V246 tmp187      [V246,T156] (  0,  0   )     ref  ->  zero-ref    single-def "arr expr"
-;  V247 tmp188      [V247,T121] (  3,  3   )     ref  ->  rcx         single-def "arr expr"
+;  V247 tmp188      [V247,T120] (  3,  3   )     ref  ->  rcx         single-def "arr expr"
 ;  V248 tmp189      [V248,T132] (  2,  2   )     ref  ->   r8         single-def "argument with side effect"
 ;  V249 cse0        [V249,T142] (  3,  1.50)   byref  ->  rcx         "CSE - conservative"
 ;  V250 cse1        [V250,T150] (  3,  1.50)     int  ->  rdx         "CSE - conservative"
@@ -484,8 +484,6 @@ G_M57484_IG13:        ; bbWeight=0.50, gcrefRegs=C4A0 {rbp rdi r10 r14 r15}, byr
        mov      edx, dword ptr [rsp+0x1E8]
        lea      ecx, [rdx+0x01]
        mov      dword ptr [rsp+0x1E8], ecx
-       cmp      edx, 2
-       jae      G_M57484_IG229
        mov      ecx, edx
        mov      r8, gword ptr [rsp+0x148]
        ; gcrRegs +[r8]
@@ -496,7 +494,7 @@ G_M57484_IG13:        ; bbWeight=0.50, gcrefRegs=C4A0 {rbp rdi r10 r14 r15}, byr
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx r8]
        ; byrRegs -[rcx]
-						;; size=79 bbWeight=0.50 PerfScore 9.25
+						;; size=70 bbWeight=0.50 PerfScore 8.62
 G_M57484_IG14:        ; bbWeight=0.50, gcrefRegs=C0A0 {rbp rdi r14 r15}, byrefRegs=0008 {rbx}, byref, isz
        cmp      dword ptr [rsp+0x1E4], 0
        je       SHORT G_M57484_IG16
@@ -4298,7 +4296,7 @@ G_M57484_IG234:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 10723, prolog size 87, PerfScore 20338.89, instruction count 2113, allocated bytes for code 10723 (MethodHash=7f9a1f73) for method Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:bindUserDefinedConversion(Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,ubyte,byref,ubyte):ubyte:this (FullOpts)
+; Total bytes of code 10714, prolog size 87, PerfScore 20338.27, instruction count 2111, allocated bytes for code 10714 (MethodHash=7f9a1f73) for method Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:bindUserDefinedConversion(Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,ubyte,byref,ubyte):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-8</span> (<span style="color:green">-0.08%</span>) : 240010.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol+AliasesAndUsings:<GetUsingsAndDiagnostics>g__buildUsings|16_0(Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax],Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,System.Nullable`1[ubyte],Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol+AliasesAndUsings+UsingsAndDiagnostics:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -21,7 +21,7 @@
 ;  V10 loc4         [V10,T05] ( 22, 39   )     ref  ->  rdi         class-hnd <Microsoft.CodeAnalysis.DiagnosticBag>
 ;  V11 loc5         [V11,T61] (  7, 13   )     ref  ->  [rsp+0x360]  class-hnd exact spill-single-def <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
 ;  V12 loc6         [V12,T43] ( 11, 18.50)     ref  ->  [rsp+0x358]  ld-addr-op class-hnd <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
-;  V13 loc7         [V13,T11] ( 17, 30.50)     ref  ->  [rsp+0x350]  class-hnd <<unknown class>>
+;  V13 loc7         [V13,T10] ( 17, 30.50)     ref  ->  [rsp+0x350]  class-hnd <<unknown class>>
 ;  V14 loc8         [V14,T118] (  7, 10.50)     ref  ->  [rsp+0x348]  class-hnd <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
 ;  V15 loc9         [V15,T117] (  6, 11   )     ref  ->  [rsp+0x340]  class-hnd <Microsoft.CodeAnalysis.CSharp.Binder>
 ;  V16 loc10        [V16    ] (  5,  9.50)     ref  ->  [rsp+0x5E8]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <Microsoft.CodeAnalysis.PooledObjects.PooledHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]>
@@ -32,14 +32,14 @@
 ;  V21 loc15        [V21,T01] ( 54,108   )     ref  ->  [rsp+0x338]  class-hnd exact <Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
 ;  V22 loc16        [V22    ] (  7, 12   )  struct (24) [rsp+0x5C8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V23 loc17        [V23,T119] (  5, 10   )     ref  ->  [rsp+0x330]  class-hnd spill-single-def <Microsoft.CodeAnalysis.Location>
-;  V24 loc18        [V24,T03] ( 13, 56.34)     ref  ->  [rsp+0x328]  class-hnd exact <System.String>
+;  V24 loc18        [V24,T02] ( 13, 56.34)     ref  ->  [rsp+0x328]  class-hnd exact <System.String>
 ;  V25 loc19        [V25,T215] (  3,  6   )   ubyte  ->  [rsp+0x5C4] 
 ;  V26 loc20        [V26    ] (  6, 12   )  struct (16) [rsp+0x5B0]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
 ;  V27 loc21        [V27    ] ( 33, 66   )  struct (24) [rsp+0x598]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.SyntaxToken>
 ;* V28 loc22        [V28    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective]>
 ;  V29 loc23        [V29,T216] (  3,  6   )     int  ->  r13        
 ;  V30 loc24        [V30,T120] (  5, 10   )     ref  ->  [rsp+0x320]  class-hnd exact spill-single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
-;  V31 loc25        [V31,T07] ( 17, 34   )     ref  ->  [rsp+0x318]  class-hnd spill-single-def <Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
+;  V31 loc25        [V31,T06] ( 17, 34   )     ref  ->  [rsp+0x318]  class-hnd spill-single-def <Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
 ;* V32 loc26        [V32,T285] (  0,  0   )   ubyte  ->  zero-ref   
 ;* V33 loc27        [V33    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.Location>
 ;  V34 loc28        [V34    ] (  4,  8   )  struct (40) [rsp+0x570]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.Binder+NamespaceOrTypeOrAliasSymbolWithAnnotations>
@@ -49,8 +49,8 @@
 ;  V38 OutArgs      [V38    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V39 tmp1         [V39    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V40 tmp2         [V40    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticBag>
-;  V41 tmp3         [V41,T35] (  5, 20   )  struct (24) [rsp+0x558]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
-;  V42 tmp4         [V42,T28] (  5, 20   )     ref  ->  [rsp+0x308]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
+;  V41 tmp3         [V41,T34] (  5, 20   )  struct (24) [rsp+0x558]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V42 tmp4         [V42,T27] (  5, 20   )     ref  ->  [rsp+0x308]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V43 tmp5         [V43,T151] (  2,  8   )     ref  ->  [rsp+0x300]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
 ;  V44 tmp6         [V44,T152] (  2,  8   )     ref  ->  rax         class-hnd "Strict ordering of exceptions for Array store" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
 ;  V45 tmp7         [V45,T69] (  3, 12   )     ref  ->  [rsp+0x2F8]  class-hnd exact spill-single-def "Single-def Box Helper" <Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument>
@@ -58,8 +58,8 @@
 ;  V47 tmp9         [V47,T71] (  3, 12   )     ref  ->  [rsp+0x2F0]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V48 tmp10        [V48,T153] (  2,  8   )     ref  ->  [rsp+0x2E8]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
 ;  V49 tmp11        [V49,T72] (  3, 12   )     ref  ->  [rsp+0x2E0]  class-hnd exact spill-single-def "Single-def Box Helper" <Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument>
-;  V50 tmp12        [V50,T36] (  5, 20   )  struct (24) [rsp+0x540]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
-;  V51 tmp13        [V51,T37] (  5, 20   )  struct (24) [rsp+0x528]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V50 tmp12        [V50,T35] (  5, 20   )  struct (24) [rsp+0x540]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V51 tmp13        [V51,T36] (  5, 20   )  struct (24) [rsp+0x528]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V52 tmp14        [V52,T154] (  2,  8   )     ref  ->  [rsp+0x2D8]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V53 tmp15        [V53    ] (  7, 28   )  struct (24) [rsp+0x510]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
 ;* V54 tmp16        [V54    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
@@ -73,7 +73,7 @@
 ;  V62 tmp24        [V62,T156] (  2,  8   )     ref  ->  [rsp+0x2B8]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
 ;  V63 tmp25        [V63,T75] (  3, 12   )     ref  ->  [rsp+0x2B0]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V64 tmp26        [V64,T157] (  2,  8   )     ref  ->  [rsp+0x2A8]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
-;  V65 tmp27        [V65,T38] (  5, 20   )  struct (24) [rsp+0x4F0]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V65 tmp27        [V65,T37] (  5, 20   )  struct (24) [rsp+0x4F0]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V66 tmp28        [V66,T158] (  2,  8   )     ref  ->  [rsp+0x2A0]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V67 tmp29        [V67    ] (  7, 28   )  struct (24) [rsp+0x4D8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
 ;* V68 tmp30        [V68    ] (  0,  0   )     ref  ->  zero-ref   
@@ -84,9 +84,9 @@
 ;* V73 tmp35        [V73    ] (  0,  0   )  struct ( 8) zero-ref    "impAppendStmt" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V74 tmp36        [V74,T77] (  3, 12   )     ref  ->  [rsp+0x288]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V75 tmp37        [V75,T160] (  2,  8   )     ref  ->  [rsp+0x280]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
-;  V76 tmp38        [V76,T29] (  5, 20   )     ref  ->  [rsp+0x278]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.BinderFactory>
-;  V77 tmp39        [V77,T39] (  5, 20   )  struct (24) [rsp+0x4B8]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
-;  V78 tmp40        [V78,T40] (  5, 20   )  struct (24) [rsp+0x4A0]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V76 tmp38        [V76,T28] (  5, 20   )     ref  ->  [rsp+0x278]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.BinderFactory>
+;  V77 tmp39        [V77,T38] (  5, 20   )  struct (24) [rsp+0x4B8]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V78 tmp40        [V78,T39] (  5, 20   )  struct (24) [rsp+0x4A0]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V79 tmp41        [V79,T219] (  3,  6   )     int  ->  rax        
 ;* V80 tmp42        [V80    ] (  0,  0   )  struct (24) zero-ref    "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
 ;  V81 tmp43        [V81,T78] (  3, 12   )     ref  ->  [rsp+0x270]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
@@ -131,21 +131,21 @@
 ;* V120 tmp82       [V120    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "dup spill" <Microsoft.CodeAnalysis.GreenNode>
 ;* V121 tmp83       [V121    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V122 tmp84       [V122    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
-;  V123 tmp85       [V123,T30] (  5, 20   )   byref  ->  [rsp+0x250]  spill-single-def "Inlining Arg"
+;  V123 tmp85       [V123,T29] (  5, 20   )   byref  ->  [rsp+0x250]  spill-single-def "Inlining Arg"
 ;  V124 tmp86       [V124,T129] (  4,  8   )     ref  ->  [rsp+0x248]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V125 tmp87       [V125,T130] (  4,  8   )     ref  ->  [rsp+0x240]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V126 tmp88       [V126    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V127 tmp89       [V127,T163] (  2,  8   )     ref  ->  rdx         class-hnd exact "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V128 tmp90       [V128    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V129 tmp91       [V129    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
-;  V130 tmp92       [V130,T31] (  5, 20   )   byref  ->  [rsp+0x238]  spill-single-def "Inlining Arg"
+;  V130 tmp92       [V130,T30] (  5, 20   )   byref  ->  [rsp+0x238]  spill-single-def "Inlining Arg"
 ;  V131 tmp93       [V131,T65] (  6, 12   )     ref  ->  [rsp+0x230]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V132 tmp94       [V132,T131] (  4,  8   )     ref  ->  [rsp+0x228]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V133 tmp95       [V133    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V134 tmp96       [V134,T164] (  2,  8   )     ref  ->  rdx         class-hnd exact "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V135 tmp97       [V135    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V136 tmp98       [V136    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
-;  V137 tmp99       [V137,T32] (  5, 20   )   byref  ->  [rsp+0x220]  spill-single-def "Inlining Arg"
+;  V137 tmp99       [V137,T31] (  5, 20   )   byref  ->  [rsp+0x220]  spill-single-def "Inlining Arg"
 ;  V138 tmp100      [V138,T66] (  6, 12   )     ref  ->  [rsp+0x218]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V139 tmp101      [V139,T132] (  4,  8   )     ref  ->  [rsp+0x210]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V140 tmp102      [V140    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
@@ -162,7 +162,7 @@
 ;* V151 tmp113      [V151    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V152 tmp114      [V152    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V153 tmp115      [V153,T81] (  3, 12   )     ref  ->  [rsp+0x208]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V154 tmp116      [V154,T25] (  6, 20.00)     ref  ->  [rsp+0x200]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V154 tmp116      [V154,T24] (  6, 20.00)     ref  ->  [rsp+0x200]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V155 tmp117      [V155    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V156 tmp118      [V156,T145] (  3,  8.00)     ref  ->  [rsp+0x1F8]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V157 tmp119      [V157    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxToken>
@@ -175,7 +175,7 @@
 ;* V164 tmp126      [V164    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V165 tmp127      [V165    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V166 tmp128      [V166,T82] (  3, 12   )     ref  ->  r15         class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V167 tmp129      [V167,T26] (  6, 20.00)     ref  ->  [rsp+0x1F0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V167 tmp129      [V167,T25] (  6, 20.00)     ref  ->  [rsp+0x1F0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V168 tmp130      [V168    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V169 tmp131      [V169,T146] (  3,  8.00)     ref  ->  [rsp+0x1E8]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V170 tmp132      [V170,T203] (  3,  6   )     ref  ->  rcx         class-hnd "Inline return value spill temp" <System.String>
@@ -202,7 +202,7 @@
 ;  V191 tmp153      [V191    ] (  1,  2   )  struct (16) [rsp+0x428]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
 ;* V192 tmp154      [V192    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableDictionary`2+Comparers[System.__Canon,Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
 ;* V193 tmp155      [V193    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
-;  V194 tmp156      [V194,T33] (  5, 20   )   byref  ->  [rsp+0x1D0]  spill-single-def "Inlining Arg"
+;  V194 tmp156      [V194,T32] (  5, 20   )   byref  ->  [rsp+0x1D0]  spill-single-def "Inlining Arg"
 ;  V195 tmp157      [V195,T135] (  4,  8   )     ref  ->  [rsp+0x1C8]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
 ;  V196 tmp158      [V196,T136] (  4,  8   )     ref  ->  [rsp+0x1C0]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V197 tmp159      [V197    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
@@ -211,7 +211,7 @@
 ;* V200 tmp162      [V200    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
 ;* V201 tmp163      [V201    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V202 tmp164      [V202,T84] (  3, 12   )     ref  ->  [rsp+0x1B8]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V203 tmp165      [V203,T17] (  6, 24   )     ref  ->  [rsp+0x1B0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V203 tmp165      [V203,T16] (  6, 24   )     ref  ->  [rsp+0x1B0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V204 tmp166      [V204    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V205 tmp167      [V205,T85] (  3, 12   )     ref  ->  [rsp+0x1A8]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V206 tmp168      [V206    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective]>
@@ -220,7 +220,7 @@
 ;* V209 tmp171      [V209    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
 ;  V210 tmp172      [V210,T00] (  5,108.68)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.String>
 ;  V211 tmp173      [V211,T42] (  2, 16   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V212 tmp174      [V212,T09] (  2, 32   )   byref  ->  rcx         "impAppendStmt"
+;  V212 tmp174      [V212,T08] (  2, 32   )   byref  ->  rcx         "impAppendStmt"
 ;* V213 tmp175      [V213    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V214 tmp176      [V214    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V215 tmp177      [V215    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -228,10 +228,10 @@
 ;* V217 tmp179      [V217    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V218 tmp180      [V218    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V219 tmp181      [V219,T86] (  3, 12   )     ref  ->  [rsp+0x1A0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V220 tmp182      [V220,T18] (  6, 24   )     ref  ->  [rsp+0x198]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V220 tmp182      [V220,T17] (  6, 24   )     ref  ->  [rsp+0x198]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V221 tmp183      [V221    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V222 tmp184      [V222,T87] (  3, 12   )     ref  ->  [rsp+0x190]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V223 tmp185      [V223,T02] (  5, 66   )     int  ->  rdx         "Inline stloc first use temp"
+;  V223 tmp185      [V223,T04] (  4, 50   )     int  ->  rdx         "Inline stloc first use temp"
 ;  V224 tmp186      [V224,T237] (  2,  4   )   byref  ->  [rsp+0x188]  spill-single-def
 ;* V225 tmp187      [V225    ] (  0,  0   )   byref  ->  zero-ref   
 ;  V226 tmp188      [V226,T238] (  2,  4   )     ref  ->  rax        
@@ -243,7 +243,7 @@
 ;  V232 tmp194      [V232,T185] (  2,  8   )     int  ->   r8         "Inlining Arg"
 ;* V233 tmp195      [V233    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V234 tmp196      [V234    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
-;  V235 tmp197      [V235,T13] (  7, 28   )     ref  ->  [rsp+0x180]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
+;  V235 tmp197      [V235,T12] (  7, 28   )     ref  ->  [rsp+0x180]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
 ;  V236 tmp198      [V236,T126] (  5,  8.40)     int  ->  [rsp+0x424]  spill-single-def "Inline stloc first use temp"
 ;* V237 tmp199      [V237    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V238 tmp200      [V238,T228] (  3,  4   )     int  ->  rdx         "Inline return value spill temp"
@@ -259,7 +259,7 @@
 ;* V248 tmp210      [V248    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V249 tmp211      [V249    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]]>
 ;* V250 tmp212      [V250    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
-;  V251 tmp213      [V251,T34] (  5, 20   )   byref  ->  [rsp+0x170]  spill-single-def "Inlining Arg"
+;  V251 tmp213      [V251,T33] (  5, 20   )   byref  ->  [rsp+0x170]  spill-single-def "Inlining Arg"
 ;  V252 tmp214      [V252,T137] (  4,  8   )     ref  ->  [rsp+0x168]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
 ;  V253 tmp215      [V253,T138] (  4,  8   )     ref  ->  [rsp+0x160]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V254 tmp216      [V254    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
@@ -293,7 +293,7 @@
 ;* V282 tmp244      [V282    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
 ;  V283 tmp245      [V283,T172] (  2,  8   )     ref  ->  rdx         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V284 tmp246      [V284,T139] (  4,  8   )     ref  ->  rdx        
-;  V285 tmp247      [V285,T19] (  6, 24   )     ref  ->  [rsp+0x158]  class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxNode>
+;  V285 tmp247      [V285,T18] (  6, 24   )     ref  ->  [rsp+0x158]  class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxNode>
 ;  V286 tmp248      [V286,T286] (  2,  4   )     int  ->  [rsp+0x404]  spill-single-def "Inline stloc first use temp"
 ;* V287 tmp249      [V287    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Binder>
 ;  V288 tmp250      [V288,T53] (  7, 14   )     ref  ->  [rsp+0x150]  class-hnd exact spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.BinderFactory+BinderFactoryVisitor>
@@ -316,7 +316,7 @@
 ;* V305 tmp267      [V305    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V306 tmp268      [V306    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V307 tmp269      [V307,T90] (  3, 12   )     ref  ->  [rsp+0x140]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V308 tmp270      [V308,T20] (  6, 24   )     ref  ->  [rsp+0x138]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V308 tmp270      [V308,T19] (  6, 24   )     ref  ->  [rsp+0x138]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V309 tmp271      [V309    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V310 tmp272      [V310,T91] (  3, 12   )     ref  ->  [rsp+0x130]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V311 tmp273      [V311,T92] (  3, 12   )     ref  ->  rax         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.PooledHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]>
@@ -338,7 +338,7 @@
 ;  V327 tmp289      [V327,T177] (  2,  8   )     ref  ->  rcx         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V328 tmp290      [V328,T124] (  5, 10   )     ref  ->  rcx        
 ;* V329 tmp291      [V329    ] (  0,  0   )  struct (24) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
-;  V330 tmp292      [V330,T14] (  7, 28   )     ref  ->  [rsp+0x120]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
+;  V330 tmp292      [V330,T13] (  7, 28   )     ref  ->  [rsp+0x120]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V331 tmp293      [V331,T127] (  5,  8.40)     int  ->  [rsp+0x3F4]  spill-single-def "Inline stloc first use temp"
 ;* V332 tmp294      [V332    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V333 tmp295      [V333,T229] (  3,  4   )     int  ->  rdx         "Inline return value spill temp"
@@ -353,7 +353,7 @@
 ;* V342 tmp304      [V342    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V343 tmp305      [V343    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V344 tmp306      [V344,T95] (  3, 12   )     ref  ->  [rsp+0x118]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V345 tmp307      [V345,T21] (  6, 24   )     ref  ->  [rsp+0x110]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V345 tmp307      [V345,T20] (  6, 24   )     ref  ->  [rsp+0x110]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V346 tmp308      [V346    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V347 tmp309      [V347,T96] (  3, 12   )     ref  ->  [rsp+0x108]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V348 tmp310      [V348    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxToken>
@@ -366,7 +366,7 @@
 ;* V355 tmp317      [V355    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V356 tmp318      [V356    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V357 tmp319      [V357,T97] (  3, 12   )     ref  ->  [rsp+0x100]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V358 tmp320      [V358,T27] (  6, 20.00)     ref  ->  [rsp+0xF8]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V358 tmp320      [V358,T26] (  6, 20.00)     ref  ->  [rsp+0xF8]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V359 tmp321      [V359    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V360 tmp322      [V360,T147] (  3,  8.00)     ref  ->  [rsp+0xF0]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V361 tmp323      [V361,T98] (  3, 12   )     ref  ->  rax         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.PooledHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]>
@@ -387,7 +387,7 @@
 ;  V376 tmp338      [V376,T187] (  2,  8   )     int  ->   r8         "Inlining Arg"
 ;* V377 tmp339      [V377    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V378 tmp340      [V378    ] (  0,  0   )  struct ( 8) zero-ref    "Inline return value spill temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V379 tmp341      [V379,T08] (  8, 28   )     ref  ->  [rsp+0xE8]  class-hnd spill-single-def "Inlining Arg" <<unknown class>>
+;  V379 tmp341      [V379,T07] (  8, 28   )     ref  ->  [rsp+0xE8]  class-hnd spill-single-def "Inlining Arg" <<unknown class>>
 ;* V380 tmp342      [V380,T227] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V381 tmp343      [V381,T241] (  2,  4   )   byref  ->  [rsp+0xE0]  spill-single-def
 ;* V382 tmp344      [V382    ] (  0,  0   )   byref  ->  zero-ref   
@@ -395,14 +395,14 @@
 ;  V384 tmp346      [V384,T179] (  2,  8   )     ref  ->  rcx         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V385 tmp347      [V385,T125] (  5, 10   )     ref  ->  rcx        
 ;* V386 tmp348      [V386    ] (  0,  0   )  struct (24) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
-;  V387 tmp349      [V387,T15] (  7, 28   )     ref  ->  [rsp+0xD8]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
+;  V387 tmp349      [V387,T14] (  7, 28   )     ref  ->  [rsp+0xD8]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V388 tmp350      [V388,T128] (  5,  8.40)     int  ->  [rsp+0x3CC]  spill-single-def "Inline stloc first use temp"
 ;* V389 tmp351      [V389    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V390 tmp352      [V390,T230] (  3,  4   )     int  ->  rdx         "Inline return value spill temp"
 ;  V391 tmp353      [V391,T116] (  3, 11.21)     int  ->  rdx         "Inlining Arg"
 ;* V392 tmp354      [V392    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument>
 ;* V393 tmp355      [V393,T188] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V394 tmp356      [V394,T41] (  3, 20   )     int  ->  [rsp+0x3C8]  spill-single-def "Inline stloc first use temp"
+;  V394 tmp356      [V394,T40] (  3, 20   )     int  ->  [rsp+0x3C8]  spill-single-def "Inline stloc first use temp"
 ;  V395 tmp357      [V395,T60] (  4, 14   )     int  ->  registers   "Inline return value spill temp"
 ;* V396 tmp358      [V396    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxNode>
 ;  V397 tmp359      [V397,T180] (  2,  8   )     ref  ->  r13         class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
@@ -410,13 +410,13 @@
 ;  V399 tmp361      [V399,T49] (  4, 16   )     ref  ->  rcx         class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
 ;  V400 tmp362      [V400,T144] (  4,  8   )     int  ->  r13         "Inline stloc first use temp"
 ;  V401 tmp363      [V401,T243] (  2,  2   )     ref  ->  r14         single-def "field V01._node (fldOffset=0x0)" P-INDEP
-;  V402 tmp364      [V402,T22] (  3, 19   )     ref  ->  r12         single-def "field V06.array (fldOffset=0x0)" P-INDEP
-;  V403 tmp365      [V403,T16] ( 15, 26   )     ref  ->  [rsp+0xD0]  "field V08.array (fldOffset=0x0)" P-INDEP
+;  V402 tmp364      [V402,T21] (  3, 19   )     ref  ->  r12         single-def "field V06.array (fldOffset=0x0)" P-INDEP
+;  V403 tmp365      [V403,T15] ( 15, 26   )     ref  ->  [rsp+0xD0]  "field V08.array (fldOffset=0x0)" P-INDEP
...

```


</div></details>

<details>
<summary>+0 (0.00%) : 192815.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,7 +22,7 @@
 ;  V11 arg10        [V11,T38] (  5,  5   )   byref  ->  r15         single-def
 ;  V12 loc0         [V12,T13] (  6, 20.50)     ref  ->  [rbp-0x80]  class-hnd exact spill-single-def <<unknown class>>
 ;  V13 loc1         [V13,T33] (  6,  6.98)   ubyte  ->  [rbp-0x44] 
-;  V14 loc2         [V14,T12] ( 17, 21.10)     int  ->  [rbp-0x48] 
+;  V14 loc2         [V14,T12] ( 16, 21.06)     int  ->  [rbp-0x48] 
 ;* V15 loc3         [V15    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]>
 ;  V16 loc4         [V16,T47] (  4,  4   )     int  ->   r8        
 ;  V17 loc5         [V17,T48] (  4,  4   )     int  ->  [rbp-0x4C] 
@@ -118,7 +118,7 @@
 ;  V107 cse4        [V107,T16] (  7, 17.82)    long  ->  [rbp-0x70]  spill-single-def "CSE - moderate"
 ;  V108 cse5        [V108,T37] (  3,  5.94)     ref  ->  rdx         "CSE - moderate"
 ;  V109 cse6        [V109,T62] (  3,  0.06)     ref  ->  rdx         "CSE - conservative"
-;  V110 cse7        [V110,T26] (  8,  8.54)     int  ->  [rbp-0x74]  spill-single-def "CSE - moderate"
+;  V110 cse7        [V110,T26] (  7,  8.50)     int  ->  [rbp-0x74]  spill-single-def "CSE - moderate"
 ;  V111 cse8        [V111,T15] ( 18, 18   )     ref  ->  rdx         multi-def "CSE - moderate"
 ;  V112 rat0        [V112,T52] (  3,  2.80)    long  ->  r11         "fgMakeTemp is creating a new local variable"
 ;  V113 rat1        [V113,T55] (  3,  1   )    long  ->  rsi         "runtime lookup"
@@ -490,10 +490,9 @@ G_M44622_IG18:        ; bbWeight=1.98, gcrefRegs=00C0 {rsi rdi}, byrefRegs=9000
 G_M44622_IG19:        ; bbWeight=3.96, gcVars=0000000000002000 {V12}, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref
        ; GC ptr vars -{V01}
        inc      r11d
-       mov      r9d, dword ptr [rbp-0x74]
-       cmp      r9d, r11d
+       cmp      dword ptr [rbp-0x74], r11d
        jg       G_M44622_IG07
-						;; size=16 bbWeight=3.96 PerfScore 9.90
+						;; size=13 bbWeight=3.96 PerfScore 12.87
 G_M44622_IG20:        ; bbWeight=1.98, gcrefRegs=2040 {rsi r13}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        ; byrRegs -[r12 r15]
@@ -518,14 +517,12 @@ G_M44622_IG22:        ; bbWeight=0.39, gcrefRegs=02C1 {rax rsi rdi r9}, byrefReg
 G_M44622_IG23:        ; bbWeight=0.04, gcVars=0000000000002000 {V12}, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref
        ; gcrRegs -[rax r9] +[r13]
        ; GC ptr vars -{V01 V18 V90}
-       cmp      r11d, r9d
-       jae      G_M44622_IG65
        mov      ecx, r11d
        shl      rcx, 5
        mov      r8d, dword ptr [rsi+rcx+0x10]
        test     r8d, r8d
        je       G_M44622_IG26
-						;; size=30 bbWeight=0.04 PerfScore 0.21
+						;; size=21 bbWeight=0.04 PerfScore 0.16
 G_M44622_IG24:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, byref, isz
        mov      ecx, r11d
        shl      rcx, 5
@@ -534,7 +531,7 @@ G_M44622_IG24:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9
        mov      bword ptr [rbp-0xD0], rdx
        ; GC ptr vars +{V105}
        cmp      byte  ptr [rdx+0x04], 1
-       jne      SHORT G_M44622_IG27
+       jne      G_M44622_IG27
        mov      gword ptr [rbp+0x18], r13
        ; GC ptr vars +{V01}
        mov      rcx, bword ptr [rbp+0x58]
@@ -570,20 +567,22 @@ G_M44622_IG24:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9
        ; gcr arg pop 0
        mov      rax, gword ptr [rbp-0x80]
        ; gcrRegs +[rax]
+       mov      r9d, dword ptr [rbp-0x74]
        mov      r11d, dword ptr [rbp-0x48]
        mov      r13, gword ptr [rbp+0x18]
        ; gcrRegs +[r13]
        jmp      G_M44622_IG34
-						;; size=118 bbWeight=0.02 PerfScore 0.69
+						;; size=126 bbWeight=0.02 PerfScore 0.71
 G_M44622_IG25:        ; bbWeight=0.01, gcrefRegs=00C0 {rsi rdi}, byrefRegs=9000 {r12 r15}, byref
        ; gcrRegs -[rax r13]
        mov      rax, gword ptr [rbp-0x80]
        ; gcrRegs +[rax]
+       mov      r9d, dword ptr [rbp-0x74]
        mov      r11d, dword ptr [rbp-0x48]
        mov      r13, gword ptr [rbp+0x18]
        ; gcrRegs +[r13]
        jmp      G_M44622_IG34
-						;; size=17 bbWeight=0.01 PerfScore 0.05
+						;; size=21 bbWeight=0.01 PerfScore 0.06
 G_M44622_IG26:        ; bbWeight=0.02, gcVars=0000000000002000 {V12}, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V01}
@@ -771,15 +770,15 @@ G_M44622_IG33:        ; bbWeight=0.02, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=9
        mov      dword ptr [rbp-0x44], eax
        mov      rax, gword ptr [rbp-0x80]
        ; gcrRegs +[rax]
+       mov      r9d, dword ptr [rbp-0x74]
        mov      r11d, dword ptr [rbp-0x48]
-						;; size=41 bbWeight=0.02 PerfScore 0.20
+						;; size=45 bbWeight=0.02 PerfScore 0.22
 G_M44622_IG34:        ; bbWeight=0.04, gcVars=0000000000002000 {V12}, gcrefRegs=20C1 {rax rsi rdi r13}, byrefRegs=9000 {r12 r15}, gcvars, byref, isz
        ; GC ptr vars -{V105}
        inc      r11d
-       mov      r9d, dword ptr [rbp-0x74]
        cmp      r9d, r11d
        jg       SHORT G_M44622_IG40
-						;; size=12 bbWeight=0.04 PerfScore 0.10
+						;; size=8 bbWeight=0.04 PerfScore 0.06
 G_M44622_IG35:        ; bbWeight=1.98, gcrefRegs=2041 {rax rsi r13}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rdi]
        ; byrRegs -[r12 r15]
@@ -1085,7 +1084,7 @@ G_M44622_IG69:        ; bbWeight=0, funclet epilog, nogc, extend
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 2153, prolog size 73, PerfScore 1180.07, instruction count 505, allocated bytes for code 2153 (MethodHash=1e0151b1) for method Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)
+; Total bytes of code 2153, prolog size 73, PerfScore 1183.00, instruction count 504, allocated bytes for code 2153 (MethodHash=1e0151b1) for method Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-21</span> (<span style="color:green">-30.43%</span>) : 244592.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,17 +10,17 @@
 ;
 ;  V00 arg0         [V00,T00] (  6,  4.50)     ref  ->  rcx         class-hnd single-def <System.String>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  5,  3.50)     int  ->  rdx         "CSE - aggressive"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M58937_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M58937_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M58937_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      edx, dword ptr [rcx+0x08]
-       cmp      edx, 3
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, 3
        jge      SHORT G_M58937_IG05
 						;; size=8 bbWeight=1 PerfScore 3.25
 G_M58937_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
@@ -33,32 +33,20 @@ G_M58937_IG04:        ; bbWeight=0.50, epilog, nogc, extend
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M58937_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx]
-       test     edx, edx
-       je       SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0C], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 1
-       jbe      SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0E], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 2
-       jbe      SHORT G_M58937_IG07
        xor      eax, eax
        cmp      word  ptr [rcx+0x10], 95
        setne    al
-						;; size=38 bbWeight=0.50 PerfScore 8.00
+						;; size=24 bbWeight=0.50 PerfScore 6.12
 G_M58937_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M58937_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       call     [CORINFO_HELP_RNGCHKFAIL]
-       ; gcr arg pop 0
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 69, prolog size 4, PerfScore 12.88, instruction count 24, allocated bytes for code 69 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
+; Total bytes of code 48, prolog size 4, PerfScore 11.00, instruction count 16, allocated bytes for code 48 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-21</span> (<span style="color:green">-30.43%</span>) : 158302.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,17 +10,17 @@
 ;
 ;  V00 arg0         [V00,T00] (  6,  4.50)     ref  ->  rcx         class-hnd single-def <System.String>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  5,  3.50)     int  ->  rdx         "CSE - aggressive"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M58937_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M58937_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M58937_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      edx, dword ptr [rcx+0x08]
-       cmp      edx, 3
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, 3
        jge      SHORT G_M58937_IG05
 						;; size=8 bbWeight=1 PerfScore 3.25
 G_M58937_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
@@ -33,32 +33,20 @@ G_M58937_IG04:        ; bbWeight=0.50, epilog, nogc, extend
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M58937_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx]
-       test     edx, edx
-       je       SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0C], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 1
-       jbe      SHORT G_M58937_IG07
        cmp      word  ptr [rcx+0x0E], 95
        jne      SHORT G_M58937_IG03
-       cmp      edx, 2
-       jbe      SHORT G_M58937_IG07
        xor      eax, eax
        cmp      word  ptr [rcx+0x10], 95
        setne    al
-						;; size=38 bbWeight=0.50 PerfScore 8.00
+						;; size=24 bbWeight=0.50 PerfScore 6.12
 G_M58937_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M58937_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       call     [CORINFO_HELP_RNGCHKFAIL]
-       ; gcr arg pop 0
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 69, prolog size 4, PerfScore 12.88, instruction count 24, allocated bytes for code 69 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
+; Total bytes of code 48, prolog size 4, PerfScore 11.00, instruction count 16, allocated bytes for code 48 (MethodHash=045c19c6) for method System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-14</span> (<span style="color:green">-29.79%</span>) : 91179.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode):Microsoft.CodeAnalysis.VisualBasic.BoundNode:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -15,9 +15,9 @@
 ;* V03 loc1         [V03    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op single-def <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundNode]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V06 tmp2         [V06,T03] (  3,  2.50)     ref  ->  rax         "field V03.array (fldOffset=0x0)" P-INDEP
-;  V07 cse0         [V07,T05] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
-;  V08 cse1         [V08,T02] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V06 tmp2         [V06,T02] (  3,  2.50)     ref  ->  rax         "field V03.array (fldOffset=0x0)" P-INDEP
+;  V07 cse0         [V07,T05] (  2,  1   )     int  ->  rcx         "CSE - moderate"
+;  V08 cse1         [V08,T03] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -39,25 +39,16 @@ G_M63243_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rax]
        jmp      SHORT G_M63243_IG05
 						;; size=4 bbWeight=0.50 PerfScore 1.12
-G_M63243_IG04:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
-       lea      edx, [rcx-0x01]
-       cmp      edx, ecx
-       jae      SHORT G_M63243_IG06
-       mov      ecx, edx
+G_M63243_IG04:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       dec      ecx
        mov      rax, gword ptr [rax+8*rcx+0x10]
-						;; size=14 bbWeight=0.50 PerfScore 2.00
+						;; size=7 bbWeight=0.50 PerfScore 1.12
 G_M63243_IG05:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M63243_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       call     [CORINFO_HELP_RNGCHKFAIL]
-       ; gcr arg pop 0
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 47, prolog size 4, PerfScore 10.88, instruction count 16, allocated bytes for code 47 (MethodHash=3e7e08f4) for method Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode):Microsoft.CodeAnalysis.VisualBasic.BoundNode:this (FullOpts)
+; Total bytes of code 33, prolog size 4, PerfScore 10.00, instruction count 11, allocated bytes for code 33 (MethodHash=3e7e08f4) for method Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode):Microsoft.CodeAnalysis.VisualBasic.BoundNode:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-44</span> (<span style="color:green">-0.07%</span>) : 25120.dasm - Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter:ConvExprToLinqInContext(Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter+ConvEnv,Microsoft.FSharp.Quotations.FSharpExpr):System.Linq.Expressions.Expression (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -24,13 +24,13 @@
 ;  V13 loc11        [V13,T289] (  4,   9   )     ref  ->  r15         class-hnd <<unknown class>>
 ;* V14 loc12        [V14    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;  V15 loc13        [V15,T54] ( 41,  30.50)     ref  ->  [rbp-0xA60]  class-hnd <<unknown class>>
-;  V16 loc14        [V16,T188] (  5,  14   )     ref  ->  rdi         class-hnd <<unknown class>>
-;  V17 loc15        [V17,T773] (  5,   7   )     ref  ->  r13         class-hnd <<unknown class>>
+;  V16 loc14        [V16,T187] (  5,  14   )     ref  ->  rdi         class-hnd <<unknown class>>
+;  V17 loc15        [V17,T773] (  4,   6.50)     ref  ->  r13         class-hnd <<unknown class>>
 ;  V18 loc16        [V18,T868] (  3,   4.50)     ref  ->  rax         class-hnd <<unknown class>>
 ;  V19 loc17        [V19,T85] ( 16,  20   )     ref  ->  rdi         class-hnd <<unknown class>>
 ;  V20 loc18        [V20,T290] (  4,   9   )     ref  ->  r12         class-hnd <<unknown class>>
-;  V21 loc19        [V21,T189] (  5,  14   )     ref  ->  r14         class-hnd <<unknown class>>
-;  V22 loc20        [V22,T774] (  5,   7   )     ref  ->  r12         class-hnd <<unknown class>>
+;  V21 loc19        [V21,T188] (  5,  14   )     ref  ->  r14         class-hnd <<unknown class>>
+;  V22 loc20        [V22,T774] (  4,   6.50)     ref  ->  r12         class-hnd <<unknown class>>
 ;  V23 loc21        [V23,T869] (  3,   4.50)     ref  ->  rax         class-hnd <<unknown class>>
 ;  V24 loc22        [V24,T291] (  4,   9   )     ref  ->  r14         class-hnd <<unknown class>>
 ;  V25 loc23        [V25,T277] ( 14,  10.50)     ref  ->  registers   class-hnd <<unknown class>>
@@ -54,7 +54,7 @@
 ;  V43 loc41        [V43,T87] (  5,  20   )     ref  ->  r15         class-hnd <<unknown class>>
 ;  V44 loc42        [V44,T218] ( 10,  12   )     ref  ->  registers   class-hnd <Microsoft.FSharp.Quotations.FSharpExpr>
 ;  V45 loc43        [V45,T279] (  4,  10.50)     ref  ->  [rbp-0xA70]  class-hnd <<unknown class>>
-;  V46 loc44        [V46,T186] (  6,  14.50)     ref  ->  registers   class-hnd <<unknown class>>
+;  V46 loc44        [V46,T185] (  6,  14.50)     ref  ->  registers   class-hnd <<unknown class>>
 ;  V47 loc45        [V47,T934] ( 12,   3   )     ref  ->  rcx         class-hnd <<unknown class>>
 ;  V48 loc46        [V48    ] (  3,   1.50)     ref  ->  [rbp-0x98]  must-init class-hnd <<unknown class>>
 ;* V49 loc47        [V49    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
@@ -67,8 +67,8 @@
 ;  V56 loc54        [V56    ] (  2,   1   )     ref  ->  [rbp-0xE8]  must-init class-hnd <<unknown class>>
 ;  V57 loc55        [V57    ] (  2,   1   )     ref  ->  [rbp-0xF0]  must-init class-hnd <<unknown class>>
 ;* V58 loc56        [V58    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
-;  V59 loc57        [V59,T190] (  5,  14   )     ref  ->  rdi         class-hnd <<unknown class>>
-;  V60 loc58        [V60,T185] ( 10,  15.50)     ref  ->  r13         class-hnd <<unknown class>>
+;  V59 loc57        [V59,T189] (  5,  14   )     ref  ->  rdi         class-hnd <<unknown class>>
+;  V60 loc58        [V60,T191] (  9,  13.50)     ref  ->  r13         class-hnd <<unknown class>>
 ;  V61 loc59        [V61,T217] ( 18,  12   )     ref  ->  [rbp-0xA80]  class-hnd <<unknown class>>
 ;  V62 loc60        [V62,T936] (  6,   3   )     ref  ->  [rbp-0xA88]  class-hnd <<unknown class>>
 ;  V63 loc61        [V63,T192] (  5,  12.50)     ref  ->  rdi         class-hnd <<unknown class>>
@@ -76,7 +76,7 @@
 ;  V65 loc63        [V65,T52] ( 57,  35   )     ref  ->  r13         class-hnd <<unknown class>>
 ;  V66 loc64        [V66,T193] (  5,  12.50)     ref  ->  rdi         class-hnd <<unknown class>>
 ;  V67 loc65        [V67,T89] ( 12,  19.50)     ref  ->  rax         class-hnd <<unknown class>>
-;  V68 loc66        [V68,T187] ( 10,  14   )     ref  ->  rdx         class-hnd <<unknown class>>
+;  V68 loc66        [V68,T186] ( 10,  14   )     ref  ->  rdx         class-hnd <<unknown class>>
 ;  V69 loc67        [V69,T53] ( 20,  34   )     ref  ->  rdi         class-hnd <<unknown class>>
 ;  V70 loc68        [V70,T286] (  6,   9   )     ref  ->  registers   class-hnd <<unknown class>>
 ;  V71 loc69        [V71,T964] (  2,   2.50)     ref  ->  rdx         class-hnd exact <<unknown class>>
@@ -376,7 +376,7 @@
 ;  V365 loc363      [V365,T925] (  3,   4.50)     ref  ->  rax         class-hnd <<unknown class>>
 ;  V366 loc364      [V366,T271] (  4,  12   )     ref  ->  rdi         class-hnd <<unknown class>>
 ;  V367 loc365      [V367,T926] (  3,   4.50)     ref  ->  rax         class-hnd <<unknown class>>
-;  V368 loc366      [V368,T191] (  5,  14   )     ref  ->  rdi         class-hnd <<unknown class>>
+;  V368 loc366      [V368,T190] (  5,  14   )     ref  ->  rdi         class-hnd <<unknown class>>
 ;  V369 loc367      [V369,T294] (  7,   8   )     ref  ->  r13         class-hnd <<unknown class>>
 ;  V370 loc368      [V370,T832] (  4,   6.50)     ref  ->  rax         class-hnd <<unknown class>>
 ;  V371 loc369      [V371,T927] (  3,   4.50)     ref  ->  r13         class-hnd exact <<unknown class>>
@@ -1776,7 +1776,7 @@ G_M12913_IG14:        ; bbWeight=2, gcrefRegs=D0C8 {rbx rsi rdi r12 r14 r15}, by
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        cmp      gword ptr [rax+0x10], 0
-       je       G_M12913_IG15
+       je       SHORT G_M12913_IG15
        mov      rcx, gword ptr [rdi+0x08]
        ; gcrRegs +[rcx]
        call     [<unknown method>]
@@ -1794,8 +1794,6 @@ G_M12913_IG14:        ; bbWeight=2, gcrefRegs=D0C8 {rbx rsi rdi r12 r14 r15}, by
        ; GC ptr vars +{V45}
        cmp      gword ptr [rcx+0x10], 0
        jne      SHORT G_M12913_IG15
-       cmp      dword ptr [r13+0x08], 2
-       jbe      G_M12913_IG977
        mov      rdx, gword ptr [r13+0x20]
        ; gcrRegs +[rdx]
        mov      gword ptr [rbp-0xA60], rdx
@@ -1818,7 +1816,7 @@ G_M12913_IG14:        ; bbWeight=2, gcrefRegs=D0C8 {rbx rsi rdi r12 r14 r15}, by
        mov      r13, gword ptr [rbp-0xA60]
        cmp      rax, r13
        je       G_M12913_IG790
-						;; size=196 bbWeight=2 PerfScore 133.00
+						;; size=181 bbWeight=2 PerfScore 125.00
 G_M12913_IG15:        ; bbWeight=4, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 {}, gcrefRegs=D048 {rbx rsi r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax rdi r13]
        ; GC ptr vars -{V15 V45 V61}
@@ -22190,10 +22188,8 @@ G_M12913_IG758:        ; bbWeight=0.50, gcrefRegs=2041 {rax rsi r13}, byrefRegs=
        ; gcrRegs -[rdi]
        mov      rdi, gword ptr [rax+0x08]
        ; gcrRegs +[rdi]
-       cmp      dword ptr [r13+0x08], 0
-       jbe      G_M12913_IG977
        mov      r13, gword ptr [r13+0x10]
-						;; size=19 bbWeight=0.50 PerfScore 4.00
+						;; size=8 bbWeight=0.50 PerfScore 2.00
 G_M12913_IG759:        ; bbWeight=0.50, gcrefRegs=20C0 {rsi rdi r13}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        mov      rcx, rsi
@@ -22317,8 +22313,6 @@ G_M12913_IG763:        ; bbWeight=0.50, gcrefRegs=1041 {rax rsi r12}, byrefRegs=
        ; gcrRegs -[r14] +[rsi r12]
        mov      rdi, gword ptr [rax+0x08]
        ; gcrRegs +[rdi]
-       cmp      dword ptr [r12+0x08], 0
-       jbe      G_M12913_IG977
        mov      r13, gword ptr [r12+0x10]
        ; gcrRegs +[r13]
        mov      rcx, rsi
@@ -22339,7 +22333,7 @@ G_M12913_IG763:        ; bbWeight=0.50, gcrefRegs=1041 {rax rsi r12}, byrefRegs=
        mov      r14, rax
        ; gcrRegs +[r14]
        jmp      G_M12913_IG781
-						;; size=64 bbWeight=0.50 PerfScore 9.50
+						;; size=52 bbWeight=0.50 PerfScore 7.50
 G_M12913_IG764:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax] +[rsi]
        mov      rcx, gword ptr [r14+0x08]
@@ -22795,7 +22789,7 @@ G_M12913_IG780:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0000
        ; gcr arg pop 0
        mov      gword ptr [rbp-0x98], rax
        cmp      gword ptr [rbp-0x98], 0
-       je       G_M12913_IG978
+       je       G_M12913_IG977
        mov      rcx, gword ptr [rbp-0x98]
        ; gcrRegs +[rcx]
        mov      rdx, gword ptr [rbp-0x50]
@@ -27944,7 +27938,7 @@ G_M12913_IG937:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        test     rax, rax
-       je       G_M12913_IG979
+       je       G_M12913_IG978
        jmp      SHORT G_M12913_IG939
 						;; size=159 bbWeight=0.50 PerfScore 23.75
 G_M12913_IG938:        ; bbWeight=0.50, gcrefRegs=4008 {rbx r14}, byrefRegs=0000 {}, byref, isz
@@ -29387,10 +29381,6 @@ G_M12913_IG976:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
 						;; size=17 bbWeight=0.50 PerfScore 2.75
 G_M12913_IG977:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax r14]
-       call     [CORINFO_HELP_RNGCHKFAIL]
-       ; gcr arg pop 0
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M12913_IG978:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     [CORINFO_HELP_READYTORUN_NEW]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
@@ -29409,7 +29399,7 @@ G_M12913_IG978:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M12913_IG979:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M12913_IG978:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     [CORINFO_HELP_READYTORUN_NEW]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
@@ -29429,7 +29419,7 @@ G_M12913_IG979:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcr arg pop 0
        int3     
 						;; size=50 bbWeight=0 PerfScore 0.00
-G_M12913_IG980:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, funclet prolog, nogc
+G_M12913_IG979:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, funclet prolog, nogc
        ; GC ptr vars +{V51 V419}
        push     rbp
        push     r15
@@ -29444,9 +29434,9 @@ G_M12913_IG980:        ; bbWeight=0, gcVars=000000000000000000000000000000000000
        mov      qword ptr [rsp+0x48], rbp
        lea      rbp, [rbp+0xB20]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M12913_IG981:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M12913_IG980:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        cmp      gword ptr [rbp-0xAC8], 0
-       je       SHORT G_M12913_IG983
+       je       SHORT G_M12913_IG982
        mov      rcx, gword ptr [rbp-0xAC8]
        ; gcrRegs +[rcx]
        lea      r11, [(reloc)]      ; function address
@@ -29456,7 +29446,7 @@ G_M12913_IG981:        ; bbWeight=0, gcVars=000000000000000000000000000000000000
        ; gcr arg pop 0
        nop      
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M12913_IG982:        ; bbWeight=0, funclet epilog, nogc, extend
+G_M12913_IG981:        ; bbWeight=0, funclet epilog, nogc, extend
        add      rsp, 88
        pop      rbx
        pop      rsi
@@ -29468,7 +29458,7 @@ G_M12913_IG982:        ; bbWeight=0, funclet epilog, nogc, extend
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12913_IG983:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet epilog, nogc
+G_M12913_IG982:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet epilog, nogc
        add      rsp, 88
        pop      rbx
        pop      rsi
@@ -29480,7 +29470,7 @@ G_M12913_IG983:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12913_IG984:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, funclet prolog, nogc
+G_M12913_IG983:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, funclet prolog, nogc
        ; GC ptr vars +{V51 V419}
        push     rbp
        push     r15
@@ -29495,9 +29485,9 @@ G_M12913_IG984:        ; bbWeight=0, gcVars=000000000000000000000000000000000000
        mov      qword ptr [rsp+0x48], rbp
        lea      rbp, [rbp+0xB20]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M12913_IG985:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M12913_IG984:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        cmp      gword ptr [rbp-0xAC8], 0
-       je       SHORT G_M12913_IG987
+       je       SHORT G_M12913_IG986
        mov      rcx, gword ptr [rbp-0xAC8]
        ; gcrRegs +[rcx]
        lea      r11, [(reloc)]      ; function address
@@ -29507,7 +29497,7 @@ G_M12913_IG985:        ; bbWeight=0, gcVars=000000000000000000000000000000000000
        ; gcr arg pop 0
        nop      
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M12913_IG986:        ; bbWeight=0, funclet epilog, nogc, extend
+G_M12913_IG985:        ; bbWeight=0, funclet epilog, nogc, extend
        add      rsp, 88
        pop      rbx
        pop      rsi
@@ -29519,7 +29509,7 @@ G_M12913_IG986:        ; bbWeight=0, funclet epilog, nogc, extend
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12913_IG987:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet epilog, nogc
+G_M12913_IG986:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet epilog, nogc
        add      rsp, 88
        pop      rbx
        pop      rsi
@@ -29531,7 +29521,7 @@ G_M12913_IG987:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12913_IG988:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, funclet prolog, nogc
+G_M12913_IG987:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, funclet prolog, nogc
        ; GC ptr vars +{V51 V419}
        push     rbp
        push     r15
@@ -29546,9 +29536,9 @@ G_M12913_IG988:        ; bbWeight=0, gcVars=000000000000000000000000000000000000
        mov      qword ptr [rsp+0x48], rbp
        lea      rbp, [rbp+0xB20]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M12913_IG989:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M12913_IG988:        ; bbWeight=0, gcVars=0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008000000000000 {V419}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        cmp      gword ptr [rbp-0xAC8], 0
-       je       SHORT G_M12913_IG991
+       je       SHORT G_M12913_IG990
        mov      rcx, gword ptr [rbp-0xAC8]
        ; gcrRegs +[rcx]
        lea      r11, [(reloc)]      ; function address
...

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+1.75%</span>) : 54626.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,7 +17,7 @@
 ;  V05 arg5         [V05,T19] (  2,  2   )     ref  ->  r13         class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V06 arg6         [V06,T20] (  2,  2   )     ref  ->  r12         class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V07 arg7         [V07,T14] (  6,  6   )     ref  ->  r14         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
-;  V08 loc0         [V08,T01] ( 22, 21.32)     int  ->  [rsp+0xD4] 
+;  V08 loc0         [V08,T01] ( 21, 21.28)     int  ->  [rsp+0xD4] 
 ;  V09 loc1         [V09,T03] ( 10, 12   )     ref  ->  [rsp+0x60]  class-hnd exact <Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
 ;  V10 loc2         [V10,T15] (  4,  6   )     ref  ->  [rsp+0x58]  class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
 ;  V11 loc3         [V11,T05] (  8, 10   )     ref  ->  [rsp+0x50]  class-hnd <Microsoft.CodeAnalysis.CSharp.Binder>
@@ -30,15 +30,15 @@
 ;  V18 OutArgs      [V18    ] (  1,  1   )  struct (56) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V19 tmp1         [V19,T10] (  4,  8   )     ref  ->  [rsp+0x40]  class-hnd "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
 ;  V20 tmp2         [V20,T11] (  4,  8   )     ref  ->   r8         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
-;  V21 tmp3         [V21,T09] (  8,  8   )     ref  ->   r8        
-;  V22 tmp4         [V22,T07] (  6,  6.04)     ref  ->  rsi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
+;  V21 tmp3         [V21,T08] (  8,  8   )     ref  ->   r8        
+;  V22 tmp4         [V22,T06] (  6,  6.04)     ref  ->  rsi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
 ;  V23 tmp5         [V23,T12] (  4,  6   )     ref  ->  rbp         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V24 tmp6         [V24,T08] (  6,  6.04)     ref  ->  rdi         single-def "field V02.array (fldOffset=0x0)" P-INDEP
+;  V24 tmp6         [V24,T07] (  6,  6.04)     ref  ->  rdi         single-def "field V02.array (fldOffset=0x0)" P-INDEP
 ;  V25 tmp7         [V25    ] (  4,  4   )     ref  ->  [rsp+0xC0]  do-not-enreg[X] addr-exposed "field V15.Item1 (fldOffset=0x0)" P-DEP
 ;  V26 tmp8         [V26    ] (  4,  4   )     ref  ->  [rsp+0xC8]  do-not-enreg[X] addr-exposed "field V15.Item2 (fldOffset=0x8)" P-DEP
 ;  V27 tmp9         [V27    ] (  4,  8   )  struct (32) [rsp+0x78]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V28 tmp10        [V28,T13] (  4,  8   )     ref  ->  rax         "argument with side effect"
-;  V29 cse0         [V29,T06] (  9,  8.04)     int  ->  [rsp+0x74]  spill-single-def "CSE - aggressive"
+;  V29 cse0         [V29,T09] (  8,  8   )     int  ->  [rsp+0x74]  spill-single-def "CSE - aggressive"
 ;  V30 cse1         [V30,T00] (  6, 21.78)    long  ->  [rsp+0x68]  spill-single-def "CSE - aggressive"
 ;
 ; Lcl frame size = 216
@@ -83,27 +83,27 @@ G_M18462_IG02:        ; bbWeight=1, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14
        mov      edx, dword ptr [rbp+0x08]
        mov      dword ptr [rsp+0x74], edx
        test     edx, edx
-       jle      G_M18462_IG21
+       jle      G_M18462_IG27
 						;; size=17 bbWeight=1 PerfScore 4.50
 G_M18462_IG03:        ; bbWeight=0.50, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        test     rdi, rdi
-       je       G_M18462_IG14
+       je       G_M18462_IG12
        test     rsi, rsi
-       je       G_M18462_IG14
+       je       G_M18462_IG11
        test     rbx, rbx
-       je       G_M18462_IG14
+       je       G_M18462_IG10
        test     r15, r15
-       je       G_M18462_IG14
+       je       G_M18462_IG09
        cmp      dword ptr [rdi+0x08], edx
-       jl       G_M18462_IG14
+       jl       G_M18462_IG08
        cmp      dword ptr [rsi+0x08], edx
-       jl       G_M18462_IG14
+       jl       G_M18462_IG07
        cmp      dword ptr [rbx+0x08], edx
-       jl       G_M18462_IG14
-       cmp      dword ptr [r15+0x08], edx
        jl       G_M18462_IG06
+       cmp      dword ptr [r15+0x08], edx
+       jl       G_M18462_IG20
 						;; size=73 bbWeight=0.50 PerfScore 10.50
-G_M18462_IG04:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref, isz
+G_M18462_IG04:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        mov      dword ptr [rsp+0xD4], eax
        mov      r8d, eax
        mov      qword ptr [rsp+0x68], r8
@@ -127,8 +127,8 @@ G_M18462_IG04:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        mov      gword ptr [rsp+0x48], rax
        ; GC ptr vars +{V12}
        test     rax, rax
-       jne      SHORT G_M18462_IG07
-						;; size=66 bbWeight=3.96 PerfScore 73.26
+       jne      G_M18462_IG13
+						;; size=70 bbWeight=3.96 PerfScore 73.26
 G_M18462_IG05:        ; bbWeight=1.98, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V12}
@@ -166,13 +166,30 @@ G_M18462_IG05:        ; bbWeight=1.98, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        call     [CORINFO_HELP_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       jmp      G_M18462_IG11
+       jmp      G_M18462_IG17
 						;; size=100 bbWeight=1.98 PerfScore 54.94
 G_M18462_IG06:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
-       mov      edx, dword ptr [rsp+0x74]
-       jmp      G_M18462_IG14
-						;; size=9 bbWeight=0.25 PerfScore 0.75
-G_M18462_IG07:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG07:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG08:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG09:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG10:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG11:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG12:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG13:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; GC ptr vars +{V03 V04 V05 V09 V11 V12}
        lea      rdx, [rsp+0xA0]
        mov      rcx, gword ptr [rsp+0x50]
@@ -197,7 +214,7 @@ G_M18462_IG07:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gc
        mov      r8, gword ptr [rdx+rcx]
        ; gcrRegs +[r8]
        test     r8, r8
-       jne      G_M18462_IG13
+       jne      G_M18462_IG19
        mov      gword ptr [rsp+0x60], rdx
        mov      rcx, rdx
        ; gcrRegs +[rcx]
@@ -209,7 +226,7 @@ G_M18462_IG07:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gc
        ; gcrRegs +[r8]
        mov      rax, gword ptr [rsp+0x40]
 						;; size=91 bbWeight=1.98 PerfScore 49.50
-G_M18462_IG08:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F1E9 {rax rbx rbp rsi rdi r8 r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG14:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F1E9 {rax rbx rbp rsi rdi r8 r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; GC ptr vars -{V19}
        lea      r9, [rsp+0xA0]
        mov      rcx, gword ptr [rsp+0x50]
@@ -222,13 +239,13 @@ G_M18462_IG08:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gc
        ; gcr arg pop 0
        mov      dword ptr [rsp+0x9C], eax
 						;; size=29 bbWeight=1.98 PerfScore 11.38
-G_M18462_IG09:        ; bbWeight=1.98, nogc, extend
+G_M18462_IG15:        ; bbWeight=1.98, nogc, extend
        movups   xmm0, xmmword ptr [rsp+0xA0]
        movups   xmmword ptr [rsp+0x78], xmm0
        movups   xmm0, xmmword ptr [rsp+0xB0]
        movups   xmmword ptr [rsp+0x88], xmm0
 						;; size=29 bbWeight=1.98 PerfScore 15.84
-G_M18462_IG10:        ; bbWeight=1.98, extend
+G_M18462_IG16:        ; bbWeight=1.98, extend
        lea      r8, [rsp+0x78]
        mov      rcx, r14
        ; gcrRegs +[rcx]
@@ -256,38 +273,35 @@ G_M18462_IG10:        ; bbWeight=1.98, extend
        ; gcrRegs -[rax rcx r8]
        ; gcr arg pop 0
 						;; size=63 bbWeight=1.98 PerfScore 39.10
-G_M18462_IG11:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG17:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        mov      eax, dword ptr [rsp+0xD4]
        inc      eax
-       mov      edx, dword ptr [rsp+0x74]
-       cmp      edx, eax
+       cmp      dword ptr [rsp+0x74], eax
        jg       G_M18462_IG04
-						;; size=21 bbWeight=3.96 PerfScore 13.86
-G_M18462_IG12:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=19 bbWeight=3.96 PerfScore 16.83
+G_M18462_IG18:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx rbp rsi rdi r12-r15]
-       jmp      G_M18462_IG21
+       jmp      G_M18462_IG27
 						;; size=5 bbWeight=1.98 PerfScore 3.96
-G_M18462_IG13:        ; bbWeight=0.99, gcVars=0000000000000430 {V11 V12 V19}, gcrefRegs=F1EC {rdx rbx rbp rsi rdi r8 r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG19:        ; bbWeight=0.99, gcVars=0000000000000430 {V11 V12 V19}, gcrefRegs=F1EC {rdx rbx rbp rsi rdi r8 r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs +[rdx rbx rbp rsi rdi r8 r12-r15]
        ; GC ptr vars +{V04 V05 V10 V11 V12 V19}
        mov      gword ptr [rsp+0x60], rdx
        ; GC ptr vars +{V09}
        mov      rax, gword ptr [rsp+0x40]
        ; gcrRegs +[rax]
-       jmp      G_M18462_IG08
+       jmp      G_M18462_IG14
 						;; size=15 bbWeight=0.99 PerfScore 3.96
-G_M18462_IG14:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG20:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax rdx r8]
        ; GC ptr vars -{V04 V05 V09 V10 V11 V12 V19}
-       cmp      eax, edx
-       jae      G_M18462_IG23
        mov      ecx, eax
        mov      rcx, gword ptr [rbp+8*rcx+0x10]
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x60], rcx
        ; GC ptr vars +{V09}
        cmp      eax, dword ptr [rdi+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      ecx, eax
        ; gcrRegs -[rcx]
        mov      r9, gword ptr [rdi+8*rcx+0x10]
@@ -295,14 +309,14 @@ G_M18462_IG14:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E
        mov      gword ptr [rsp+0x58], r9
        ; GC ptr vars +{V10}
        cmp      eax, dword ptr [rsi+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      ecx, eax
        mov      rcx, gword ptr [rsi+8*rcx+0x10]
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x50], rcx
        ; GC ptr vars +{V11}
        cmp      eax, dword ptr [rbx+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      dword ptr [rsp+0xD4], eax
        mov      ecx, eax
        ; gcrRegs -[rcx]
@@ -314,9 +328,9 @@ G_M18462_IG14:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E
        mov      gword ptr [rsp+0x48], rax
        ; GC ptr vars +{V12}
        test     rax, rax
-       jne      G_M18462_IG16
-						;; size=105 bbWeight=0.04 PerfScore 1.26
-G_M18462_IG15:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jne      G_M18462_IG22
+						;; size=97 bbWeight=0.04 PerfScore 1.21
+G_M18462_IG21:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V12}
        mov      gword ptr [rsp+0x20], r13
@@ -348,10 +362,10 @@ G_M18462_IG15:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        mov      rdx, gword ptr [rsp+0xC8]
        ; gcrRegs +[rdx]
        test     r15, r15
-       je       G_M18462_IG20
+       je       G_M18462_IG26
        mov      eax, dword ptr [rsp+0xD4]
        cmp      eax, dword ptr [r15+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      dword ptr [rsp+0xD4], eax
        mov      ecx, eax
        lea      rcx, bword ptr [r15+8*rcx+0x10]
@@ -359,9 +373,9 @@ G_M18462_IG15:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        call     [CORINFO_HELP_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       jmp      G_M18462_IG20
+       jmp      G_M18462_IG26
 						;; size=130 bbWeight=0.02 PerfScore 0.69
-G_M18462_IG16:        ; bbWeight=0.02, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG22:        ; bbWeight=0.02, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; GC ptr vars +{V03 V04 V05 V09 V11 V12}
        lea      rdx, [rsp+0xA0]
...

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+1.76%</span>) : 117870.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,7 +17,7 @@
 ;  V05 arg5         [V05,T19] (  2,  2   )     ref  ->  r13         class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V06 arg6         [V06,T20] (  2,  2   )     ref  ->  r12         class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V07 arg7         [V07,T14] (  6,  6   )     ref  ->  r14         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
-;  V08 loc0         [V08,T01] ( 22, 21.32)     int  ->  [rsp+0xD4] 
+;  V08 loc0         [V08,T01] ( 21, 21.28)     int  ->  [rsp+0xD4] 
 ;  V09 loc1         [V09,T03] ( 10, 12   )     ref  ->  [rsp+0x60]  class-hnd exact <Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
 ;  V10 loc2         [V10,T15] (  4,  6   )     ref  ->  [rsp+0x58]  class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
 ;  V11 loc3         [V11,T05] (  8, 10   )     ref  ->  [rsp+0x50]  class-hnd <Microsoft.CodeAnalysis.CSharp.Binder>
@@ -30,15 +30,15 @@
 ;  V18 OutArgs      [V18    ] (  1,  1   )  struct (56) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V19 tmp1         [V19,T10] (  4,  8   )     ref  ->  [rsp+0x40]  class-hnd "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
 ;  V20 tmp2         [V20,T11] (  4,  8   )     ref  ->  r10         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
-;  V21 tmp3         [V21,T09] (  8,  8   )     ref  ->  r10        
-;  V22 tmp4         [V22,T07] (  6,  6.04)     ref  ->  rsi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
+;  V21 tmp3         [V21,T08] (  8,  8   )     ref  ->  r10        
+;  V22 tmp4         [V22,T06] (  6,  6.04)     ref  ->  rsi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
 ;  V23 tmp5         [V23,T12] (  4,  6   )     ref  ->  rbp         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V24 tmp6         [V24,T08] (  6,  6.04)     ref  ->  rdi         single-def "field V02.array (fldOffset=0x0)" P-INDEP
+;  V24 tmp6         [V24,T07] (  6,  6.04)     ref  ->  rdi         single-def "field V02.array (fldOffset=0x0)" P-INDEP
 ;  V25 tmp7         [V25    ] (  4,  4   )     ref  ->  [rsp+0xC0]  do-not-enreg[X] addr-exposed "field V15.Item1 (fldOffset=0x0)" P-DEP
 ;  V26 tmp8         [V26    ] (  4,  4   )     ref  ->  [rsp+0xC8]  do-not-enreg[X] addr-exposed "field V15.Item2 (fldOffset=0x8)" P-DEP
 ;  V27 tmp9         [V27    ] (  4,  8   )  struct (32) [rsp+0x78]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V28 tmp10        [V28,T13] (  4,  8   )     ref  ->  rax         "argument with side effect"
-;  V29 cse0         [V29,T06] (  9,  8.04)     int  ->  [rsp+0x74]  spill-single-def "CSE - aggressive"
+;  V29 cse0         [V29,T09] (  8,  8   )     int  ->  [rsp+0x74]  spill-single-def "CSE - aggressive"
 ;  V30 cse1         [V30,T00] (  6, 21.78)    long  ->  [rsp+0x68]  spill-single-def "CSE - aggressive"
 ;
 ; Lcl frame size = 216
@@ -83,27 +83,27 @@ G_M18462_IG02:        ; bbWeight=1, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14
        mov      edx, dword ptr [rbp+0x08]
        mov      dword ptr [rsp+0x74], edx
        test     edx, edx
-       jle      G_M18462_IG21
+       jle      G_M18462_IG27
 						;; size=17 bbWeight=1 PerfScore 4.50
 G_M18462_IG03:        ; bbWeight=0.50, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        test     rdi, rdi
-       je       G_M18462_IG14
+       je       G_M18462_IG12
        test     rsi, rsi
-       je       G_M18462_IG14
+       je       G_M18462_IG11
        test     rbx, rbx
-       je       G_M18462_IG14
+       je       G_M18462_IG10
        test     r15, r15
-       je       G_M18462_IG14
+       je       G_M18462_IG09
        cmp      dword ptr [rdi+0x08], edx
-       jl       G_M18462_IG14
+       jl       G_M18462_IG08
        cmp      dword ptr [rsi+0x08], edx
-       jl       G_M18462_IG14
+       jl       G_M18462_IG07
        cmp      dword ptr [rbx+0x08], edx
-       jl       G_M18462_IG14
-       cmp      dword ptr [r15+0x08], edx
        jl       G_M18462_IG06
+       cmp      dword ptr [r15+0x08], edx
+       jl       G_M18462_IG20
 						;; size=73 bbWeight=0.50 PerfScore 10.50
-G_M18462_IG04:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref, isz
+G_M18462_IG04:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        mov      dword ptr [rsp+0xD4], eax
        mov      r8d, eax
        mov      qword ptr [rsp+0x68], r8
@@ -127,8 +127,8 @@ G_M18462_IG04:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        mov      gword ptr [rsp+0x48], rax
        ; GC ptr vars +{V12}
        test     rax, rax
-       jne      SHORT G_M18462_IG07
-						;; size=66 bbWeight=3.96 PerfScore 73.26
+       jne      G_M18462_IG13
+						;; size=70 bbWeight=3.96 PerfScore 73.26
 G_M18462_IG05:        ; bbWeight=1.98, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V12}
@@ -166,13 +166,30 @@ G_M18462_IG05:        ; bbWeight=1.98, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        call     [CORINFO_HELP_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       jmp      G_M18462_IG11
+       jmp      G_M18462_IG17
 						;; size=100 bbWeight=1.98 PerfScore 54.94
 G_M18462_IG06:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
-       mov      edx, dword ptr [rsp+0x74]
-       jmp      G_M18462_IG14
-						;; size=9 bbWeight=0.25 PerfScore 0.75
-G_M18462_IG07:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG07:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG08:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG09:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG10:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG11:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG12:        ; bbWeight=0.25, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jmp      G_M18462_IG20
+						;; size=5 bbWeight=0.25 PerfScore 0.50
+G_M18462_IG13:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; GC ptr vars +{V03 V04 V05 V09 V11 V12}
        lea      rdx, [rsp+0xA0]
        mov      rcx, gword ptr [rsp+0x50]
@@ -196,7 +213,7 @@ G_M18462_IG07:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gc
        mov      r10, gword ptr [r8+rcx]
        ; gcrRegs +[r10]
        test     r10, r10
-       jne      G_M18462_IG13
+       jne      G_M18462_IG19
        mov      gword ptr [rsp+0x60], r8
        mov      rcx, r8
        ; gcrRegs +[rcx]
@@ -207,7 +224,7 @@ G_M18462_IG07:        ; bbWeight=1.98, gcVars=0000000000000038 {V09 V11 V12}, gc
        mov      r10, rax
        ; gcrRegs +[r10]
 						;; size=88 bbWeight=1.98 PerfScore 48.51
-G_M18462_IG08:        ; bbWeight=1.98, gcrefRegs=F4E8 {rbx rbp rsi rdi r10 r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG14:        ; bbWeight=1.98, gcrefRegs=F4E8 {rbx rbp rsi rdi r10 r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        lea      r9, [rsp+0xA0]
        mov      rcx, gword ptr [rsp+0x50]
@@ -222,13 +239,13 @@ G_M18462_IG08:        ; bbWeight=1.98, gcrefRegs=F4E8 {rbx rbp rsi rdi r10 r12 r
        ; gcr arg pop 0
        mov      dword ptr [rsp+0x9C], eax
 						;; size=34 bbWeight=1.98 PerfScore 13.36
-G_M18462_IG09:        ; bbWeight=1.98, nogc, extend
+G_M18462_IG15:        ; bbWeight=1.98, nogc, extend
        movups   xmm0, xmmword ptr [rsp+0xA0]
        movups   xmmword ptr [rsp+0x78], xmm0
        movups   xmm0, xmmword ptr [rsp+0xB0]
        movups   xmmword ptr [rsp+0x88], xmm0
 						;; size=29 bbWeight=1.98 PerfScore 15.84
-G_M18462_IG10:        ; bbWeight=1.98, extend
+G_M18462_IG16:        ; bbWeight=1.98, extend
        lea      r8, [rsp+0x78]
        mov      rcx, r14
        ; gcrRegs +[rcx]
@@ -256,36 +273,33 @@ G_M18462_IG10:        ; bbWeight=1.98, extend
        ; gcrRegs -[rax rcx r8]
        ; gcr arg pop 0
 						;; size=63 bbWeight=1.98 PerfScore 39.10
-G_M18462_IG11:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG17:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        mov      eax, dword ptr [rsp+0xD4]
        inc      eax
-       mov      edx, dword ptr [rsp+0x74]
-       cmp      edx, eax
+       cmp      dword ptr [rsp+0x74], eax
        jg       G_M18462_IG04
-						;; size=21 bbWeight=3.96 PerfScore 13.86
-G_M18462_IG12:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=19 bbWeight=3.96 PerfScore 16.83
+G_M18462_IG18:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx rbp rsi rdi r12-r15]
-       jmp      G_M18462_IG21
+       jmp      G_M18462_IG27
 						;; size=5 bbWeight=1.98 PerfScore 3.96
-G_M18462_IG13:        ; bbWeight=0.99, gcVars=0000000000000430 {V11 V12 V19}, gcrefRegs=F5E8 {rbx rbp rsi rdi r8 r10 r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG19:        ; bbWeight=0.99, gcVars=0000000000000430 {V11 V12 V19}, gcrefRegs=F5E8 {rbx rbp rsi rdi r8 r10 r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs +[rbx rbp rsi rdi r8 r10 r12-r15]
        ; GC ptr vars +{V04 V05 V10 V11 V12 V19}
        mov      gword ptr [rsp+0x60], r8
        ; GC ptr vars +{V09}
-       jmp      G_M18462_IG08
+       jmp      G_M18462_IG14
 						;; size=10 bbWeight=0.99 PerfScore 2.97
-G_M18462_IG14:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG20:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[r8 r10]
        ; GC ptr vars -{V04 V05 V09 V10 V11 V12 V19}
-       cmp      eax, edx
-       jae      G_M18462_IG23
        mov      ecx, eax
        mov      rcx, gword ptr [rbp+8*rcx+0x10]
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x60], rcx
        ; GC ptr vars +{V09}
        cmp      eax, dword ptr [rdi+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      ecx, eax
        ; gcrRegs -[rcx]
        mov      r9, gword ptr [rdi+8*rcx+0x10]
@@ -293,14 +307,14 @@ G_M18462_IG14:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E
        mov      gword ptr [rsp+0x58], r9
        ; GC ptr vars +{V10}
        cmp      eax, dword ptr [rsi+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      ecx, eax
        mov      rcx, gword ptr [rsi+8*rcx+0x10]
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x50], rcx
        ; GC ptr vars +{V11}
        cmp      eax, dword ptr [rbx+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      dword ptr [rsp+0xD4], eax
        mov      ecx, eax
        ; gcrRegs -[rcx]
@@ -312,9 +326,9 @@ G_M18462_IG14:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=F0E
        mov      gword ptr [rsp+0x48], rax
        ; GC ptr vars +{V12}
        test     rax, rax
-       jne      G_M18462_IG16
-						;; size=105 bbWeight=0.04 PerfScore 1.26
-G_M18462_IG15:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
+       jne      G_M18462_IG22
+						;; size=97 bbWeight=0.04 PerfScore 1.21
+G_M18462_IG21:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V12}
        mov      gword ptr [rsp+0x20], r13
@@ -346,10 +360,10 @@ G_M18462_IG15:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        mov      rdx, gword ptr [rsp+0xC8]
        ; gcrRegs +[rdx]
        test     r15, r15
-       je       G_M18462_IG20
+       je       G_M18462_IG26
        mov      eax, dword ptr [rsp+0xD4]
        cmp      eax, dword ptr [r15+0x08]
-       jae      G_M18462_IG23
+       jae      G_M18462_IG29
        mov      dword ptr [rsp+0xD4], eax
        mov      ecx, eax
        lea      rcx, bword ptr [r15+8*rcx+0x10]
@@ -357,9 +371,9 @@ G_M18462_IG15:        ; bbWeight=0.02, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r
        call     [CORINFO_HELP_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       jmp      G_M18462_IG20
+       jmp      G_M18462_IG26
 						;; size=130 bbWeight=0.02 PerfScore 0.69
-G_M18462_IG16:        ; bbWeight=0.02, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+G_M18462_IG22:        ; bbWeight=0.02, gcVars=0000000000000038 {V09 V11 V12}, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; GC ptr vars +{V03 V04 V05 V09 V11 V12}
        lea      rdx, [rsp+0xA0]
        mov      rcx, gword ptr [rsp+0x50]
@@ -383,7 +397,7 @@ G_M18462_IG16:        ; bbWeight=0.02, gcVars=0000000000000038 {V09 V11 V12}, gc
...

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-15</span> (<span style="color:green">-34.88%</span>) : 83893.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor:AssertIsGood():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,13 +16,13 @@
 ;* V05 tmp3         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField]>
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField]>
 ;* V07 tmp5         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField[]>
-;  V08 tmp6         [V08,T01] (  4, 13   )     int  ->  rcx         "Inline stloc first use temp"
+;  V08 tmp6         [V08,T01] (  2,  8   )     int  ->  rcx         "Inline stloc first use temp"
 ;* V09 tmp7         [V09,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V10 tmp8         [V10,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V10 tmp8         [V10,T00] (  4, 13   )     int  ->  rcx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V11 tmp9         [V11,T04] (  2,  2   )     ref  ->  rax         single-def "field V05.array (fldOffset=0x0)" P-INDEP
 ;* V12 tmp10        [V12,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V06._array (fldOffset=0x0)" P-INDEP
 ;* V13 tmp11        [V13,T07] (  0,  0   )     int  ->  zero-ref    single-def "field V06._index (fldOffset=0x8)" P-INDEP
-;  V14 cse0         [V14,T02] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;  V14 cse0         [V14,T02] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -37,29 +37,20 @@ G_M28475_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; gcrRegs -[rax]
        xor      ecx, ecx
        ; byrRegs -[rcx]
-       xor      edx, edx
        test     eax, eax
        jle      SHORT G_M28475_IG04
-						;; size=15 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M28475_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, eax
-       jae      SHORT G_M28475_IG05
-       lea      ecx, [rdx+0x01]
-       mov      edx, ecx
-       cmp      eax, edx
+       inc      ecx
+       cmp      eax, ecx
        jg       SHORT G_M28475_IG03
-						;; size=13 bbWeight=4 PerfScore 13.00
+						;; size=6 bbWeight=4 PerfScore 6.00
 G_M28475_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M28475_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 43, prolog size 4, PerfScore 20.25, instruction count 17, allocated bytes for code 43 (MethodHash=0eb590c4) for method Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor:AssertIsGood():this (FullOpts)
+; Total bytes of code 28, prolog size 4, PerfScore 13.00, instruction count 11, allocated bytes for code 28 (MethodHash=0eb590c4) for method Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor:AssertIsGood():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-15</span> (<span style="color:green">-34.88%</span>) : 98560.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeDescriptor:AssertGood():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,14 +16,14 @@
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeField]>
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeField]>
 ;* V07 tmp4         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeField[]>
-;  V08 tmp5         [V08,T01] (  4, 13   )     int  ->  rcx         "Inline stloc first use temp"
+;  V08 tmp5         [V08,T01] (  2,  8   )     int  ->  rcx         "Inline stloc first use temp"
 ;* V09 tmp6         [V09,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V10 tmp7         [V10,T00] (  4, 13   )     int  ->  rcx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;* V11 tmp8         [V11    ] (  0,  0   )     ref  ->  zero-ref    "field V02.array (fldOffset=0x0)" P-INDEP
 ;  V12 tmp9         [V12,T04] (  2,  2   )     ref  ->  rax         single-def "field V05.array (fldOffset=0x0)" P-INDEP
 ;* V13 tmp10        [V13,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V06._array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T07] (  0,  0   )     int  ->  zero-ref    single-def "field V06._index (fldOffset=0x8)" P-INDEP
-;  V15 cse0         [V15,T02] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;  V15 cse0         [V15,T02] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -38,29 +38,20 @@ G_M12404_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; gcrRegs -[rax]
        xor      ecx, ecx
        ; byrRegs -[rcx]
-       xor      edx, edx
        test     eax, eax
        jle      SHORT G_M12404_IG04
-						;; size=15 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M12404_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, eax
-       jae      SHORT G_M12404_IG05
-       lea      ecx, [rdx+0x01]
-       mov      edx, ecx
-       cmp      eax, edx
+       inc      ecx
+       cmp      eax, ecx
        jg       SHORT G_M12404_IG03
-						;; size=13 bbWeight=4 PerfScore 13.00
+						;; size=6 bbWeight=4 PerfScore 6.00
 G_M12404_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M12404_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 43, prolog size 4, PerfScore 20.25, instruction count 17, allocated bytes for code 43 (MethodHash=0463cf8b) for method Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeDescriptor:AssertGood():this (FullOpts)
+; Total bytes of code 28, prolog size 4, PerfScore 13.00, instruction count 11, allocated bytes for code 28 (MethodHash=0463cf8b) for method Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeDescriptor:AssertGood():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 90042.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,23 +8,23 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  5,  8   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  5,  8   )   byref  ->  rcx         this single-def
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T04] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
+;  V04 tmp1         [V04,T03] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
 ;* V05 tmp2         [V05    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T01] (  4, 13   )     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T02] (  2,  8   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T05] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T03] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -38,23 +38,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=4 PerfScore 33.00
+						;; size=12 bbWeight=4 PerfScore 26.00
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -63,15 +59,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 45.25, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
+; Total bytes of code 40, prolog size 4, PerfScore 38.00, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-4</span> (<span style="color:green">-0.07%</span>) : 119617.dasm - Microsoft.CodeAnalysis.VisualBasic.OverloadResolution:ValidateOverloadedOperator(Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol,Microsoft.CodeAnalysis.VisualBasic.OverloadResolution+OperatorInfo,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag,Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,7 +14,7 @@
 ;  V03 arg3         [V03,T39] (  3,  2.50)     ref  ->  rdi         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol>
 ;  V04 loc0         [V04,T88] (  3,  2   )   ubyte  ->  rax        
 ;  V05 loc1         [V05,T38] (  6,  4.50)   ubyte  ->  registers  
-;  V06 loc2         [V06,T22] (  5,  6   )     ref  ->  r13         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.NamedTypeSymbol>
+;  V06 loc2         [V06,T21] (  5,  6   )     ref  ->  r13         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.NamedTypeSymbol>
 ;  V07 loc3         [V07,T41] (  5,  4   )   ubyte  ->  r12        
 ;  V08 loc4         [V08,T75] (  5,  2.50)     int  ->  [rsp+0x1A4] 
 ;  V09 loc5         [V09,T117] (  3,  1.50)   ubyte  ->  [rsp+0x1A0] 
@@ -25,9 +25,9 @@
 ;* V14 loc10        [V14    ] (  0,  0   )     int  ->  zero-ref   
 ;* V15 loc11        [V15    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.ParameterSymbol]>
 ;* V16 loc12        [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.VisualBasic.Symbols.ParameterSymbol]>
-;  V17 loc13        [V17,T04] (  4, 16   )     ref  ->  [rsp+0xE0]  class-hnd spill-single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.ParameterSymbol>
-;  V18 loc14        [V18,T23] ( 11,  5.50)     ref  ->  rbp         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol>
-;  V19 loc15        [V19,T21] ( 13,  6.50)     ref  ->  r12         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol>
+;  V17 loc13        [V17,T03] (  4, 16   )     ref  ->  [rsp+0xE0]  class-hnd spill-single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.ParameterSymbol>
+;  V18 loc14        [V18,T22] ( 11,  5.50)     ref  ->  rbp         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol>
+;  V19 loc15        [V19,T20] ( 13,  6.50)     ref  ->  r12         class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol>
 ;  V20 OutArgs      [V20    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V21 tmp1         [V21    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;  V22 tmp2         [V22,T114] (  2,  2   )  struct (32) [rsp+0x160]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol]>
@@ -71,93 +71,93 @@
 ;* V60 tmp40        [V60    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "non-inline candidate call" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;* V61 tmp41        [V61    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol]>
 ;* V62 tmp42        [V62    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol>
-;  V63 tmp43        [V63,T09] (  8,  8   )     ref  ->  [rsp+0xC0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V63 tmp43        [V63,T08] (  8,  8   )     ref  ->  [rsp+0xC0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V64 tmp44        [V64,T47] (  3,  3   )     ref  ->  [rsp+0xB8]  class-hnd exact spill-single-def "Inlining Arg" <<unknown class>>
 ;  V65 tmp45        [V65,T48] (  3,  3   )     ref  ->  [rsp+0xB0]  class-hnd spill-single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V66 tmp46        [V66    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V67 tmp47        [V67,T92] (  2,  2   )     ref  ->  [rsp+0xA8]  class-hnd spill-single-def "Inlining Arg" <System.__Canon>
-;  V68 tmp48        [V68,T25] (  6,  5.00)     ref  ->  [rsp+0xA0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V68 tmp48        [V68,T24] (  6,  5.00)     ref  ->  [rsp+0xA0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V69 tmp49        [V69,T77] (  3,  2.00)     ref  ->  [rsp+0x98]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V70 tmp50        [V70,T10] (  8,  8   )     ref  ->  [rsp+0x90]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V70 tmp50        [V70,T09] (  8,  8   )     ref  ->  [rsp+0x90]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V71 tmp51        [V71,T49] (  3,  3   )     ref  ->  [rsp+0x88]  class-hnd exact spill-single-def "Inlining Arg" <<unknown class>>
 ;  V72 tmp52        [V72,T50] (  3,  3   )     ref  ->  [rsp+0x80]  class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V73 tmp53        [V73    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V74 tmp54        [V74,T93] (  2,  2   )     ref  ->  [rsp+0x78]  class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V75 tmp55        [V75,T26] (  6,  5.00)     ref  ->  [rsp+0x70]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V75 tmp55        [V75,T25] (  6,  5.00)     ref  ->  [rsp+0x70]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V76 tmp56        [V76,T78] (  3,  2.00)     ref  ->  [rsp+0x68]  class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V77 tmp57        [V77,T11] (  8,  8   )     ref  ->  [rsp+0x60]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V77 tmp57        [V77,T10] (  8,  8   )     ref  ->  [rsp+0x60]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V78 tmp58        [V78,T51] (  3,  3   )     ref  ->  [rsp+0x58]  class-hnd exact spill-single-def "Inlining Arg" <<unknown class>>
 ;  V79 tmp59        [V79,T52] (  3,  3   )     ref  ->  [rsp+0x50]  class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V80 tmp60        [V80    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V81 tmp61        [V81,T94] (  2,  2   )     ref  ->  [rsp+0x48]  class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V82 tmp62        [V82,T27] (  6,  5.00)     ref  ->  [rsp+0x40]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V82 tmp62        [V82,T26] (  6,  5.00)     ref  ->  [rsp+0x40]  class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V83 tmp63        [V83,T79] (  3,  2.00)     ref  ->  [rsp+0x38]  class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V84 tmp64        [V84    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.ParameterSymbol]>
 ;* V85 tmp65        [V85    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.VisualBasic.Symbols.ParameterSymbol]>
 ;* V86 tmp66        [V86    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
-;  V87 tmp67        [V87,T03] (  5, 16.50)     int  ->   r8         "Inline stloc first use temp"
-;  V88 tmp68        [V88,T12] (  8,  8   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V87 tmp67        [V87,T06] (  4, 12.50)     int  ->   r8         "Inline stloc first use temp"
+;  V88 tmp68        [V88,T11] (  8,  8   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V89 tmp69        [V89,T53] (  3,  3   )     ref  ->  rbp         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V90 tmp70        [V90,T54] (  3,  3   )     ref  ->  rbx         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V91 tmp71        [V91    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V92 tmp72        [V92,T95] (  2,  2   )     ref  ->  rdi         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V93 tmp73        [V93,T28] (  6,  5.00)     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V93 tmp73        [V93,T27] (  6,  5.00)     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V94 tmp74        [V94,T80] (  3,  2.00)     ref  ->  r15         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V95 tmp75        [V95,T13] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V95 tmp75        [V95,T12] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V96 tmp76        [V96,T55] (  3,  3   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V97 tmp77        [V97,T96] (  2,  2   )     ref  ->  r12         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V98 tmp78        [V98,T56] (  3,  3   )     ref  ->  rsi         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V99 tmp79        [V99    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V100 tmp80       [V100,T97] (  2,  2   )     ref  ->  r15         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V101 tmp81       [V101,T29] (  6,  5.00)     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V101 tmp81       [V101,T28] (  6,  5.00)     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V102 tmp82       [V102,T81] (  3,  2.00)     ref  ->  rbp         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V103 tmp83       [V103,T14] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V103 tmp83       [V103,T13] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V104 tmp84       [V104,T57] (  3,  3   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V105 tmp85       [V105,T98] (  2,  2   )     ref  ->  rbp         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V106 tmp86       [V106,T58] (  3,  3   )     ref  ->  rsi         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V107 tmp87       [V107    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V108 tmp88       [V108,T99] (  2,  2   )     ref  ->  r15         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V109 tmp89       [V109,T30] (  6,  5.00)     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V109 tmp89       [V109,T29] (  6,  5.00)     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V110 tmp90       [V110,T82] (  3,  2.00)     ref  ->  r12         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V111 tmp91       [V111,T15] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V111 tmp91       [V111,T14] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V112 tmp92       [V112,T59] (  3,  3   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V113 tmp93       [V113,T100] (  2,  2   )     ref  ->  r12         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V114 tmp94       [V114,T60] (  3,  3   )     ref  ->  rsi         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V115 tmp95       [V115    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V116 tmp96       [V116,T101] (  2,  2   )     ref  ->  r15         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V117 tmp97       [V117,T31] (  6,  5.00)     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V117 tmp97       [V117,T30] (  6,  5.00)     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V118 tmp98       [V118,T83] (  3,  2.00)     ref  ->  r13         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V119 tmp99       [V119,T16] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V119 tmp99       [V119,T15] (  8,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V120 tmp100      [V120,T61] (  3,  3   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V121 tmp101      [V121,T102] (  2,  2   )     ref  ->  r13         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V122 tmp102      [V122,T62] (  3,  3   )     ref  ->  r12         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V123 tmp103      [V123    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V124 tmp104      [V124,T103] (  2,  2   )     ref  ->  rbp         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V125 tmp105      [V125,T32] (  6,  5.00)     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V125 tmp105      [V125,T31] (  6,  5.00)     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V126 tmp106      [V126,T84] (  3,  2.00)     ref  ->  r15         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V127 tmp107      [V127,T17] (  8,  8   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V127 tmp107      [V127,T16] (  8,  8   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V128 tmp108      [V128,T63] (  3,  3   )     ref  ->  rdi         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V129 tmp109      [V129,T104] (  2,  2   )     ref  ->  rbp         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V130 tmp110      [V130,T64] (  3,  3   )     ref  ->  rsi         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V131 tmp111      [V131    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V132 tmp112      [V132,T105] (  2,  2   )     ref  ->  r12         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V133 tmp113      [V133,T33] (  6,  5.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V133 tmp113      [V133,T32] (  6,  5.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V134 tmp114      [V134,T85] (  3,  2.00)     ref  ->  rbx         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V135 tmp115      [V135,T18] (  8,  8   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V135 tmp115      [V135,T17] (  8,  8   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V136 tmp116      [V136,T65] (  3,  3   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V137 tmp117      [V137,T106] (  2,  2   )     ref  ->  rbp         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V138 tmp118      [V138,T66] (  3,  3   )     ref  ->  rsi         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V139 tmp119      [V139    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V140 tmp120      [V140,T107] (  2,  2   )     ref  ->  r12         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V141 tmp121      [V141,T34] (  6,  5.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V141 tmp121      [V141,T33] (  6,  5.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V142 tmp122      [V142,T86] (  3,  2.00)     ref  ->  rbx         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V143 tmp123      [V143,T19] (  8,  8   )     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
+;  V143 tmp123      [V143,T18] (  8,  8   )     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticInfo>
 ;  V144 tmp124      [V144,T67] (  3,  3   )     ref  ->  rdi         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;  V145 tmp125      [V145,T108] (  2,  2   )     ref  ->  r14         class-hnd single-def "Inlining Arg" <System.Object[]>
 ;  V146 tmp126      [V146,T68] (  3,  3   )     ref  ->  rsi         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.DiagnosticBag>
 ;* V147 tmp127      [V147    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V148 tmp128      [V148,T109] (  2,  2   )     ref  ->  rbx         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V149 tmp129      [V149,T35] (  6,  5.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
+;  V149 tmp129      [V149,T34] (  6,  5.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.VisualBasic.VBDiagnostic>
 ;  V150 tmp130      [V150,T87] (  3,  2.00)     ref  ->  r13         class-hnd single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V151 tmp131      [V151,T74] (  3,  3   )  struct (32) [rsp+0x120]  do-not-enreg[S] must-init "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol]>
 ;  V152 tmp132      [V152,T110] (  2,  2   )     ref  ->   r9         class-hnd single-def "dup spill" <<unknown class>>
@@ -165,7 +165,7 @@
 ;* V154 tmp134      [V154    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol]>
 ;  V155 tmp135      [V155,T76] (  4,  2   )     ref  ->   r9        
 ;  V156 tmp136      [V156,T111] (  2,  2   )     ref  ->  rbx         class-hnd single-def "Inlining Arg" <System.__Canon>
-;  V157 tmp137      [V157,T36] (  5,  5   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V157 tmp137      [V157,T35] (  5,  5   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;  V158 tmp138      [V158,T69] (  3,  3   )     ref  ->  rdx         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;* V159 tmp139      [V159    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V160 tmp140      [V160    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol]>
@@ -173,7 +173,7 @@
 ;  V162 tmp142      [V162,T02] ( 36, 18   )     ref  ->  rax         "field V13.array (fldOffset=0x0)" P-INDEP
 ;  V163 tmp143      [V163,T37] (  9,  4.50)     ref  ->  registers   "field V15.array (fldOffset=0x0)" P-INDEP
 ;  V164 tmp144      [V164,T40] (  2,  4.50)     ref  ->  [rsp+0x30]  single-def "field V16._array (fldOffset=0x0)" P-INDEP
-;  V165 tmp145      [V165,T06] (  4, 12.50)     int  ->  [rsp+0x11C]  "field V16._index (fldOffset=0x8)" P-INDEP
+;  V165 tmp145      [V165,T05] (  4, 12.50)     int  ->  [rsp+0x11C]  "field V16._index (fldOffset=0x8)" P-INDEP
 ;* V166 tmp146      [V166    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V84.array (fldOffset=0x0)" P-INDEP
 ;  V167 tmp147      [V167,T127] (  2,  1   )     ref  ->  rax         single-def "field V85._array (fldOffset=0x0)" P-INDEP
 ;* V168 tmp148      [V168,T130] (  0,  0   )     int  ->  zero-ref    single-def "field V85._index (fldOffset=0x8)" P-INDEP
@@ -189,17 +189,17 @@
 ;  V178 tmp158      [V178,T112] (  2,  2   )     ref  ->   r8         single-def "argument with side effect"
 ;  V179 tmp159      [V179,T72] (  3,  3   )     ref  ->  rax         single-def "argument with side effect"
 ;  V180 tmp160      [V180,T113] (  2,  2   )     ref  ->  rdx         single-def "argument with side effect"
-;  V181 tmp161      [V181,T05] (  2, 16   )     ref  ->  rdx         "argument with side effect"
+;  V181 tmp161      [V181,T04] (  2, 16   )     ref  ->  rdx         "argument with side effect"
 ;  V182 tmp162      [V182,T73] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
 ;  V183 tmp163      [V183    ] (  2,  2   )  struct (32) [rsp+0xF8]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[System.__Canon]>
-;* V184 cse0        [V184,T24] (  0,  0   )    long  ->  zero-ref    multi-def "CSE - aggressive"
+;* V184 cse0        [V184,T23] (  0,  0   )    long  ->  zero-ref    multi-def "CSE - aggressive"
 ;* V185 cse1        [V185,T131] (  0,  0   )    long  ->  zero-ref    "CSE - conservative"
-;  V186 cse2        [V186,T20] ( 14,  7   )    long  ->  r15         "CSE - moderate"
+;  V186 cse2        [V186,T19] ( 14,  7   )    long  ->  r15         "CSE - moderate"
 ;  V187 cse3        [V187,T07] (  3, 12   )    long  ->  [rsp+0xF0]  spill-single-def "CSE - aggressive"
 ;  V188 cse4        [V188,T42] (  5,  3.50)    long  ->  rbp         "CSE - conservative"
 ;  V189 cse5        [V189,T125] (  3,  1.50)    long  ->  rdi         "CSE - conservative"
 ;  V190 cse6        [V190,T126] (  3,  1.50)    long  ->  r13         "CSE - conservative"
-;  V191 cse7        [V191,T08] (  4,  9   )     int  ->  [rsp+0xEC]  "CSE - moderate"
+;  V191 cse7        [V191,T36] (  3,  5   )     int  ->  [rsp+0xEC]  "CSE - moderate"
 ;
 ; Lcl frame size = 424
 
@@ -412,7 +412,7 @@ G_M60426_IG15:        ; bbWeight=0.50, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0
        test     byte  ptr [(reloc)], 1      ; global ptr
        je       G_M60426_IG85
 						;; size=112 bbWeight=0.50 PerfScore 8.50
-G_M60426_IG16:        ; bbWeight=0.50, gcVars=000000000000000000000000000000000000200000000200 {V55 V63}, gcrefRegs=2049 {rax rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref
+G_M60426_IG16:        ; bbWeight=0.50, gcVars=000000000000000000000000000000000000200000000100 {V55 V63}, gcrefRegs=2049 {rax rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      r8, gword ptr [rcx]
        ; gcrRegs +[r8]
@@ -423,7 +423,7 @@ G_M60426_IG16:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000
        test     byte  ptr [(reloc)], 1      ; global ptr
        je       G_M60426_IG86
 						;; size=37 bbWeight=0.50 PerfScore 3.75
-G_M60426_IG17:        ; bbWeight=0.50, gcVars=000000000000000000000000000000000000A00000000200 {V55 V63 V64}, gcrefRegs=204D {rax rdx rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M60426_IG17:        ; bbWeight=0.50, gcVars=000000000000000000000000000000000000A00000000100 {V55 V63 V64}, gcrefRegs=204D {rax rdx rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[r8]
        lea      rcx, bword ptr [rax+0x08]
        ; byrRegs +[rcx]
@@ -527,7 +527,7 @@ G_M60426_IG19:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000
        mov      edi, dword ptr [rsp+0x1A0]
        jmp      G_M60426_IG33
 						;; size=27 bbWeight=0.50 PerfScore 2.38
-G_M60426_IG20:        ; bbWeight=0.00, gcVars=000000000000000000000000000020000000000002000000 {V68 V69}, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M60426_IG20:        ; bbWeight=0.00, gcVars=000000000000000000000000000020000000000001000000 {V68 V69}, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref, isz
        ; GC ptr vars +{V68 V69 V77}
        mov      rcx, gword ptr [rsp+0x98]
        ; gcrRegs +[rcx]
@@ -902,13 +902,11 @@ G_M60426_IG33:        ; bbWeight=0.50, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0
        xor      r8d, r8d
        xor      r10d, r10d
        mov      dword ptr [rsp+0x11C], r10d
+       mov      dword ptr [rsp+0xEC], edx
        test     edx, edx
        jle      G_M60426_IG39
-						;; size=31 bbWeight=0.50 PerfScore 4.00
+						;; size=38 bbWeight=0.50 PerfScore 4.50
 G_M60426_IG34:        ; bbWeight=4, gcrefRegs=2049 {rax rbx rsi r13}, byrefRegs=0000 {}, byref, isz
-       mov      dword ptr [rsp+0xEC], edx
-       cmp      r8d, edx
-       jae      G_M60426_IG83
        mov      ecx, r8d
        mov      gword ptr [rsp+0x30], rax
        ; GC ptr vars +{V164}
@@ -933,7 +931,7 @@ G_M60426_IG34:        ; bbWeight=4, gcrefRegs=2049 {rax rbx rsi r13}, byrefRegs=
        ; gcr arg pop 0
        test     eax, eax
        je       SHORT G_M60426_IG36
-						;; size=78 bbWeight=4 PerfScore 78.00
+						;; size=62 bbWeight=4 PerfScore 69.00
 G_M60426_IG35:        ; bbWeight=2, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0000 {}, byref
        mov      r12d, 1
 						;; size=6 bbWeight=2 PerfScore 0.50
@@ -971,11 +969,11 @@ G_M60426_IG38:        ; bbWeight=4, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0000
        mov      ecx, dword ptr [rsp+0xEC]
        cmp      ecx, r10d
        mov      dword ptr [rsp+0x11C], r10d
-       mov      edx, ecx
+       mov      dword ptr [rsp+0xEC], ecx
        mov      rax, gword ptr [rsp+0x30]
        ; gcrRegs +[rax]
        jg       G_M60426_IG34
-						;; size=45 bbWeight=4 PerfScore 24.00
+						;; size=50 bbWeight=4 PerfScore 27.00
 G_M60426_IG39:        ; bbWeight=0.50, gcVars=000000000000000000000000000000000000000000000000 {}, gcrefRegs=2048 {rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V164}
@@ -2203,9 +2201,9 @@ G_M60426_IG84:        ; bbWeight=0, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000
        ; gcr arg pop 0
        jmp      G_M60426_IG03
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M60426_IG85:        ; bbWeight=0, gcVars=000000000000000000000000000000000000200000000200 {V55 V63}, gcrefRegs=2049 {rax rbx rsi r13}, byrefRegs=0000 {}, gcvars, byref
...

```


</div></details>

<details>
<summary><span style="color:green">-14</span> (<span style="color:green">-0.07%</span>) : 37965.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,15 +12,15 @@
 ;  V02 arg2         [V02,T08] (  6, 10   )     ref  ->  rbx         class-hnd single-def <System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]>
 ;  V03 loc0         [V03,T23] (  3,  5   )     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
 ;  V04 loc1         [V04,T00] (147, 73.50)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
-;  V05 loc2         [V05,T16] (  3,  6   )     ref  ->  r14         class-hnd single-def <<unknown class>>
-;  V06 loc3         [V06,T07] (  6, 21   )     int  ->  r15        
+;  V05 loc2         [V05,T15] (  3,  6   )     ref  ->  r14         class-hnd single-def <<unknown class>>
+;  V06 loc3         [V06,T07] (  5, 17   )     int  ->  r15        
 ;  V07 loc4         [V07,T04] (  9, 34   )     ref  ->  r12         class-hnd <Microsoft.Diagnostics.Tracing.TraceEvent>
-;  V08 loc5         [V08,T19] (  3,  6   )   ubyte  ->  [rbp-0x3C] 
+;  V08 loc5         [V08,T18] (  3,  6   )   ubyte  ->  [rbp-0x3C] 
 ;  V09 loc6         [V09    ] (  6, 38   )  struct (24) [rbp-0x58]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Collections.Generic.List`1+Enumerator[Microsoft.Diagnostics.Tracing.TraceEvent]>
 ;* V10 loc7         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.Diagnostics.Tracing.TraceEvent>
-;  V11 loc8         [V11,T17] (  3,  6   )     ref  ->  rax         class-hnd <Microsoft.Diagnostics.Tracing.TraceEvent>
+;  V11 loc8         [V11,T16] (  3,  6   )     ref  ->  rax         class-hnd <Microsoft.Diagnostics.Tracing.TraceEvent>
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (88) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V13 tmp1         [V13,T18] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V13 tmp1         [V13,T17] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V14 tmp2         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.String>
 ;  V15 tmp3         [V15,T24] (  3,  3   )     ref  ->  [rbp-0xF28]  class-hnd exact spill-single-def "NewObj constructor temp" <<unknown class>>
 ;  V16 tmp4         [V16    ] (  2,  2   )  struct (16) [rbp-0x68]  do-not-enreg[XS] addr-exposed "finalizable newobj spill" <System.Guid>
@@ -521,8 +521,8 @@
 ;  V511 tmp499      [V511,T284] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Strict ordering of exceptions for Array store" <<unknown class>>
 ;  V512 tmp500      [V512,T285] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Strict ordering of exceptions for Array store" <<unknown class>>
 ;  V513 tmp501      [V513,T286] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Strict ordering of exceptions for Array store" <<unknown class>>
-;  V514 tmp502      [V514,T13] (  2,  8   )     ref  ->  [rbp-0x1408]  spill-single-def "argument with side effect"
-;  V515 tmp503      [V515,T14] (  2,  8   )     ref  ->   r8         "argument with side effect"
+;  V514 tmp502      [V514,T12] (  2,  8   )     ref  ->  [rbp-0x1408]  spill-single-def "argument with side effect"
+;  V515 tmp503      [V515,T13] (  2,  8   )     ref  ->   r8         "argument with side effect"
 ;  V516 tmp504      [V516,T01] (  2, 64   )     ref  ->  rcx         "argument with side effect"
 ;  V517 PSPSym      [V517,T287] (  1,  1   )    long  ->  [rbp-0x1438]  do-not-enreg[V] "PSPSym"
 ;* V518 cse0        [V518,T288] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
@@ -532,8 +532,8 @@
 ;  V522 cse4        [V522,T05] ( 45, 22.50)     ref  ->  [rbp-0x1410]  spill-single-def "CSE - aggressive"
 ;  V523 cse5        [V523,T11] ( 21, 10.50)    long  ->  r12         "CSE - moderate"
 ;  V524 cse6        [V524,T10] ( 21, 10.50)     ref  ->  [rbp-0x1418]  spill-single-def "CSE - moderate"
-;  V525 cse7        [V525,T12] (  4, 10   )     int  ->  r13         "CSE - moderate"
-;  V526 cse8        [V526,T15] ( 13,  6.50)     ref  ->  [rbp-0x1420]  spill-single-def "CSE - conservative"
+;  V525 cse7        [V525,T19] (  3,  6   )     int  ->  r13         "CSE - moderate"
+;  V526 cse8        [V526,T14] ( 13,  6.50)     ref  ->  [rbp-0x1420]  spill-single-def "CSE - conservative"
 ;  V527 cse9        [V527,T20] ( 10,  5   )     ref  ->  [rbp-0x1428]  spill-single-def "CSE - conservative"
 ;  V528 cse10       [V528,T22] ( 10,  5   )    long  ->  [rbp-0xF20]  spill-single-def "CSE - conservative"
 ;  V529 cse11       [V529,T21] ( 10,  5   )     ref  ->  [rbp-0x1430]  spill-single-def "CSE - conservative"
@@ -566,7 +566,7 @@ G_M51703_IG01:        ; bbWeight=1, gcVars=0000000000000000000000000000000000000
 						;; size=64 bbWeight=1 PerfScore 15.33
 G_M51703_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        test     byte  ptr [(reloc)], 1      ; global ptr
-       je       G_M51703_IG83
+       je       G_M51703_IG82
 						;; size=13 bbWeight=1 PerfScore 4.00
 G_M51703_IG03:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
@@ -6615,14 +6615,12 @@ G_M51703_IG71:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        jle      G_M51703_IG81
 						;; size=56 bbWeight=1 PerfScore 10.50
 G_M51703_IG72:        ; bbWeight=4, gcrefRegs=40C8 {rbx rsi rdi r14}, byrefRegs=0000 {}, byref, isz
-       cmp      r15d, r13d
-       jae      G_M51703_IG82
        mov      ecx, r15d
        mov      r12, gword ptr [r14+8*rcx+0x10]
        ; gcrRegs +[r12]
        test     rsi, rsi
        je       SHORT G_M51703_IG74
-						;; size=22 bbWeight=4 PerfScore 19.00
+						;; size=13 bbWeight=4 PerfScore 14.00
 G_M51703_IG73:        ; bbWeight=2, gcrefRegs=50C8 {rbx rsi rdi r12 r14}, byrefRegs=0000 {}, byref
        mov      rcx, r12
        ; gcrRegs +[rcx]
@@ -6763,11 +6761,7 @@ G_M51703_IG81:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        pop      rbp
        ret      
 						;; size=20 bbWeight=1 PerfScore 5.25
-G_M51703_IG82:        ; bbWeight=0, gcVars=00000000000000000000000000000000000000000000000000000000000000000000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M51703_IG83:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M51703_IG82:        ; bbWeight=0, gcVars=00000000000000000000000000000000000000000000000000000000000000000000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs +[rbx rsi]
        mov      rcx, 0xD1FFAB1E
        mov      edx, 256
@@ -6775,7 +6769,7 @@ G_M51703_IG83:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcr arg pop 0
        jmp      G_M51703_IG03
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M51703_IG84:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet prolog, nogc
+G_M51703_IG83:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet prolog, nogc
        ; gcrRegs -[rbx rsi]
        push     rbp
        push     r15
@@ -6790,14 +6784,14 @@ G_M51703_IG84:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        mov      qword ptr [rsp+0x58], rbp
        lea      rbp, [rbp+0x1490]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M51703_IG85:        ; bbWeight=0, gcVars=00000000000000000000000000000000000000000000000000000000000000000000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M51703_IG84:        ; bbWeight=0, gcVars=00000000000000000000000000000000000000000000000000000000000000000000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        lea      rcx, [rbp-0x58]
        mov      rdx, 0xD1FFAB1E      ; System.Collections.Generic.List`1+Enumerator[Microsoft.Diagnostics.Tracing.TraceEvent]
        call     [<unknown method>]
        ; gcr arg pop 0
        nop      
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M51703_IG86:        ; bbWeight=0, funclet epilog, nogc, extend
+G_M51703_IG85:        ; bbWeight=0, funclet epilog, nogc, extend
        add      rsp, 104
        pop      rbx
        pop      rsi
@@ -6810,7 +6804,7 @@ G_M51703_IG86:        ; bbWeight=0, funclet epilog, nogc, extend
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 21050, prolog size 64, PerfScore 2293.67, instruction count 3517, allocated bytes for code 21050 (MethodHash=a75e3608) for method Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
+; Total bytes of code 21036, prolog size 64, PerfScore 2288.67, instruction count 3514, allocated bytes for code 21036 (MethodHash=a75e3608) for method Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -6854,4 +6848,4 @@ Unwind Info:
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
 *************** EH table for Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this
 1 EH table entries, 0 duplicate clauses, 0 cloned finallys, 1 total EH entries reported to VM
-EH#0: try [G_M51703_IG75..G_M51703_IG79) handled by [G_M51703_IG84..END) (fault)
+EH#0: try [G_M51703_IG75..G_M51703_IG79) handled by [G_M51703_IG83..END) (fault)

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+0.20%</span>) : 56260.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,7 +16,7 @@
 ;  V05 arg5         [V05,T32] (  2,  2   )     ref  ->  [rsp+0x188]  class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V06 arg6         [V06,T33] (  2,  2   )     ref  ->  [rsp+0x190]  class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V07 arg7         [V07,T06] ( 14, 14   )     ref  ->  rbx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
-;  V08 loc0         [V08,T02] ( 22, 21.32)     int  ->  [rsp+0x114] 
+;  V08 loc0         [V08,T02] ( 21, 21.28)     int  ->  [rsp+0x114] 
 ;  V09 loc1         [V09,T09] ( 10, 12   )     ref  ->  [rsp+0x78]  class-hnd exact <Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
 ;  V10 loc2         [V10,T27] (  4,  6   )     ref  ->  [rsp+0x70]  class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
 ;  V11 loc3         [V11,T12] (  8, 10   )     ref  ->  [rsp+0x68]  class-hnd <Microsoft.CodeAnalysis.CSharp.Binder>
@@ -32,28 +32,28 @@
 ;  V21 tmp3         [V21,T03] ( 10, 20   )     ref  ->  [rsp+0x50]  class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
 ;  V22 tmp4         [V22,T21] (  4,  8   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
 ;  V23 tmp5         [V23,T22] (  4,  8   )     ref  ->   r8         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
-;  V24 tmp6         [V24,T17] (  8,  8   )     ref  ->   r8        
+;  V24 tmp6         [V24,T16] (  8,  8   )     ref  ->   r8        
 ;  V25 tmp7         [V25,T11] (  6, 12   )  struct (32) [rsp+0xB8]  do-not-enreg[S] must-init "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V26 tmp8         [V26,T23] (  4,  8   )     ref  ->   r9         class-hnd "dup spill" <<unknown class>>
 ;* V27 tmp9         [V27    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V28 tmp10        [V28    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V29 tmp11        [V29,T18] (  8,  8   )     ref  ->   r9        
+;  V29 tmp11        [V29,T17] (  8,  8   )     ref  ->   r9        
 ;  V30 tmp12        [V30,T04] ( 10, 20   )     ref  ->  [rsp+0x48]  class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;  V31 tmp13        [V31,T10] (  6, 12   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <<unknown class>>
 ;* V32 tmp14        [V32    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V33 tmp15        [V33    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V34 tmp16        [V34,T15] (  6,  6.04)     ref  ->  rdi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
+;  V34 tmp16        [V34,T14] (  6,  6.04)     ref  ->  rdi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
 ;  V35 tmp17        [V35,T24] (  4,  6   )     ref  ->  r14         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V36 tmp18        [V36,T16] (  6,  6.04)     ref  ->  rbp         single-def "field V02.array (fldOffset=0x0)" P-INDEP
+;  V36 tmp18        [V36,T15] (  6,  6.04)     ref  ->  rbp         single-def "field V02.array (fldOffset=0x0)" P-INDEP
 ;  V37 tmp19        [V37    ] (  4,  4   )     ref  ->  [rsp+0x100]  do-not-enreg[X] addr-exposed "field V15.Item1 (fldOffset=0x0)" P-DEP
 ;  V38 tmp20        [V38    ] (  4,  4   )     ref  ->  [rsp+0x108]  do-not-enreg[X] addr-exposed "field V15.Item2 (fldOffset=0x8)" P-DEP
 ;  V39 tmp21        [V39,T26] (  6,  6   )     ref  ->  registers   "V20.[016..024)"
-;  V40 tmp22        [V40,T19] (  8,  8   )   ubyte  ->  registers   "V20.[025..026)"
+;  V40 tmp22        [V40,T18] (  8,  8   )   ubyte  ->  registers   "V20.[025..026)"
 ;  V41 tmp23        [V41,T29] (  4,  4   )     ref  ->  rdx         "V33.[008..016)"
 ;  V42 tmp24        [V42    ] (  4,  8   )  struct (32) [rsp+0x98]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[System.__Canon]>
 ;  V43 tmp25        [V43,T25] (  4,  8   )     ref  ->  rax         "argument with side effect"
 ;* V44 cse0         [V44,T34] (  0,  0   )    long  ->  zero-ref    multi-def "CSE - aggressive"
-;  V45 cse1         [V45,T14] (  9,  8.04)     int  ->  [rsp+0x94]  spill-single-def "CSE - aggressive"
+;  V45 cse1         [V45,T19] (  8,  8   )     int  ->  [rsp+0x94]  spill-single-def "CSE - aggressive"
 ;  V46 cse2         [V46,T01] (  6, 21.78)    long  ->  [rsp+0x88]  spill-single-def "CSE - aggressive"
 ;  V47 rat0         [V47,T05] (  3, 17.82)     ref  ->  rdx         "Spilling to split statement for tree"
 ;  V48 rat1         [V48,T00] (  5, 29.70)     ref  ->  r12         "replacement local"
@@ -99,23 +99,23 @@ G_M18462_IG02:        ; bbWeight=1, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, by
        mov      r8d, dword ptr [r14+0x08]
        mov      dword ptr [rsp+0x94], r8d
        test     r8d, r8d
-       jle      G_M18462_IG42
+       jle      G_M18462_IG41
 						;; size=23 bbWeight=1 PerfScore 4.50
 G_M18462_IG03:        ; bbWeight=0.50, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, byref
        test     rbp, rbp
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        test     rdi, rdi
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        test     rsi, rsi
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        test     r15, r15
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        cmp      dword ptr [rbp+0x08], r8d
-       jl       G_M18462_IG25
+       jl       G_M18462_IG24
        cmp      dword ptr [rdi+0x08], r8d
-       jl       G_M18462_IG25
+       jl       G_M18462_IG24
        cmp      dword ptr [rsi+0x08], r8d
-       jl       G_M18462_IG25
+       jl       G_M18462_IG24
        cmp      dword ptr [r15+0x08], r8d
        jl       G_M18462_IG09
 						;; size=76 bbWeight=0.50 PerfScore 10.50
@@ -218,7 +218,7 @@ G_M18462_IG08:        ; bbWeight=1.98, gcrefRegs=CAE8 {rbx rbp rsi rdi r9 r11 r1
 G_M18462_IG09:        ; bbWeight=0.25, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[r12-r13]
        mov      r8d, dword ptr [rsp+0x94]
-       jmp      G_M18462_IG25
+       jmp      G_M18462_IG24
 						;; size=13 bbWeight=0.25 PerfScore 0.75
 G_M18462_IG10:        ; bbWeight=1.98, gcVars=0000000000001000 {V11}, gcrefRegs=D2E8 {rbx rbp rsi rdi r9 r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[r9 r12]
@@ -298,7 +298,7 @@ G_M18462_IG14:        ; bbWeight=1.98, gcVars=0000000000001200 {V09 V11}, gcrefR
        mov      r8, gword ptr [rdx+0x10]
        ; gcrRegs +[r8]
        test     r8, r8
-       jne      G_M18462_IG24
+       jne      G_M18462_IG23
        mov      gword ptr [rsp+0x78], rdx
        mov      rcx, rdx
        ; gcrRegs +[rcx]
@@ -347,7 +347,7 @@ G_M18462_IG17:        ; bbWeight=1.98, isz, extend
        mov      rdx, gword ptr [rcx]
        ; gcrRegs +[rdx]
        test     rdx, rdx
-       je       G_M18462_IG45
+       je       G_M18462_IG44
        mov      gword ptr [rsp+0x48], r9
        ; GC ptr vars +{V30}
        lea      rcx, bword ptr [r9+0x08]
@@ -420,26 +420,21 @@ G_M18462_IG20:        ; bbWeight=1.98, gcrefRegs=D0E8 {rbx rbp rsi rdi r12 r14 r
        mov      r13, gword ptr [rsp+0x188]
        ; gcrRegs +[r13]
 						;; size=62 bbWeight=1.98 PerfScore 19.80
-G_M18462_IG21:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref, isz
+G_M18462_IG21:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        mov      edx, dword ptr [rsp+0x114]
        inc      edx
-       mov      eax, dword ptr [rsp+0x94]
-       cmp      eax, edx
+       cmp      dword ptr [rsp+0x94], edx
        mov      gword ptr [rsp+0x188], r13
        mov      gword ptr [rsp+0x190], r12
-       jg       SHORT G_M18462_IG23
-						;; size=36 bbWeight=3.96 PerfScore 21.78
+       mov      eax, edx
+       jg       G_M18462_IG04
+						;; size=40 bbWeight=3.96 PerfScore 25.74
 G_M18462_IG22:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx rbp rsi rdi r12-r15]
-       jmp      G_M18462_IG42
+       jmp      G_M18462_IG41
 						;; size=5 bbWeight=1.98 PerfScore 3.96
-G_M18462_IG23:        ; bbWeight=1.98, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, byref
-       ; gcrRegs +[rbx rbp rsi rdi r14-r15]
-       mov      eax, edx
-       jmp      G_M18462_IG04
-						;; size=7 bbWeight=1.98 PerfScore 4.46
-G_M18462_IG24:        ; bbWeight=0.99, gcVars=0000000000101000 {V11 V19}, gcrefRegs=D1EC {rdx rbx rbp rsi rdi r8 r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs +[rdx r8 r12]
+G_M18462_IG23:        ; bbWeight=0.99, gcVars=0000000000101000 {V11 V19}, gcrefRegs=D1EC {rdx rbx rbp rsi rdi r8 r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[rdx rbx rbp rsi rdi r8 r12 r14-r15]
        ; GC ptr vars +{V11 V12 V19}
        mov      gword ptr [rsp+0x78], rdx
        ; GC ptr vars +{V09}
@@ -447,18 +442,16 @@ G_M18462_IG24:        ; bbWeight=0.99, gcVars=0000000000101000 {V11 V19}, gcrefR
        ; gcrRegs +[rax]
        jmp      G_M18462_IG15
 						;; size=15 bbWeight=0.99 PerfScore 3.96
-G_M18462_IG25:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M18462_IG24:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax rdx r8 r12]
        ; GC ptr vars -{V09 V11 V12 V19}
-       cmp      eax, r8d
-       jae      G_M18462_IG44
        mov      edx, eax
        mov      rdx, gword ptr [r14+8*rdx+0x10]
        ; gcrRegs +[rdx]
        mov      gword ptr [rsp+0x78], rdx
        ; GC ptr vars +{V09}
        cmp      eax, dword ptr [rbp+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      edx, eax
        ; gcrRegs -[rdx]
        mov      r11, gword ptr [rbp+8*rdx+0x10]
@@ -466,14 +459,14 @@ G_M18462_IG25:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E
        mov      gword ptr [rsp+0x70], r11
        ; GC ptr vars +{V10}
        cmp      eax, dword ptr [rdi+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      edx, eax
        mov      rcx, gword ptr [rdi+8*rdx+0x10]
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x68], rcx
        ; GC ptr vars +{V11}
        cmp      eax, dword ptr [rsi+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      dword ptr [rsp+0x114], eax
        mov      edx, eax
        mov      rdx, gword ptr [rsi+8*rdx+0x10]
@@ -485,17 +478,17 @@ G_M18462_IG25:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E
        mov      r10, gword ptr [rsp+0x78]
        ; gcrRegs +[r10]
        mov      r11, gword ptr [rsp+0x68]
-       je       SHORT G_M18462_IG28
-						;; size=109 bbWeight=0.04 PerfScore 1.23
-G_M18462_IG26:        ; bbWeight=0.02, gcVars=0000001008000000 {V10 V50}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
+       je       SHORT G_M18462_IG27
+						;; size=100 bbWeight=0.04 PerfScore 1.18
+G_M18462_IG25:        ; bbWeight=0.02, gcVars=0000001008000000 {V10 V50}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rdx]
        ; GC ptr vars -{V09 V11}
        mov      rdx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        mov      qword ptr [rsp+0x80], rdx
        cmp      qword ptr [rcx], rdx
-       je       SHORT G_M18462_IG28
+       je       SHORT G_M18462_IG27
 						;; size=23 bbWeight=0.02 PerfScore 0.11
-G_M18462_IG27:        ; bbWeight=0.01, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG26:        ; bbWeight=0.01, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        mov      gword ptr [rsp+0x78], r10
        ; GC ptr vars +{V09}
@@ -510,20 +503,21 @@ G_M18462_IG27:        ; bbWeight=0.01, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r
        ; gcr arg pop 0
        mov      rcx, rax
        ; gcrRegs +[rcx]
+       mov      r8d, dword ptr [rsp+0x94]
        mov      r10, gword ptr [rsp+0x78]
        ; gcrRegs +[r10]
        mov      r11, gword ptr [rsp+0x68]
        ; gcrRegs +[r11]
-						;; size=41 bbWeight=0.01 PerfScore 0.07
-G_M18462_IG28:        ; bbWeight=0.04, gcVars=0000000008000000 {V10}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+						;; size=49 bbWeight=0.01 PerfScore 0.08
+G_M18462_IG27:        ; bbWeight=0.04, gcVars=0000000008000000 {V10}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V09 V11}
        mov      gword ptr [rsp+0x60], rcx
        ; GC ptr vars +{V12}
        test     rcx, rcx
-       jne      G_M18462_IG30
+       jne      G_M18462_IG29
 						;; size=14 bbWeight=0.04 PerfScore 0.09
-G_M18462_IG29:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG28:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        ; GC ptr vars -{V12}
        mov      r13, gword ptr [rsp+0x188]
@@ -559,10 +553,10 @@ G_M18462_IG29:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r
        mov      rdx, gword ptr [rsp+0x108]
        ; gcrRegs +[rdx]
        test     r15, r15
-       je       G_M18462_IG41
+       je       G_M18462_IG40
        mov      eax, dword ptr [rsp+0x114]
        cmp      eax, dword ptr [r15+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      dword ptr [rsp+0x114], eax
        mov      ecx, eax
        lea      rcx, bword ptr [r15+8*rcx+0x10]
@@ -570,9 +564,9 @@ G_M18462_IG29:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       jmp      G_M18462_IG41
+       jmp      G_M18462_IG40
 						;; size=140 bbWeight=0.02 PerfScore 0.62
-G_M18462_IG30:        ; bbWeight=0.02, gcVars=0000000000000080 {V12}, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M18462_IG29:        ; bbWeight=0.02, gcVars=0000000000000080 {V12}, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[r12-r13] +[r10-r11]
        ; GC ptr vars +{V07 V12}
        mov      gword ptr [rsp+0x68], r11
...

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 58536.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -19,13 +19,13 @@
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T03] (  4,  5.12)     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T03] (  2,  2.74)     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T01] (  4,  5.12)     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T01] (  4,  5.12)     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T05] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T04] (  4,  4.74)     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  3.37)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -39,23 +39,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=1.37, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=1.37 PerfScore 11.32
+						;; size=12 bbWeight=1.37 PerfScore 8.92
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -64,15 +60,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 23.57, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
+; Total bytes of code 40, prolog size 4, PerfScore 20.92, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 638569.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -19,13 +19,13 @@
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T06] (  4,  1.97)     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T06] (  2,  0.64)     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T03] (  4,  1.97)     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T03] (  4,  1.97)     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T02] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T04] (  4,  2.64)     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  2.32)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -39,23 +39,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=0.32, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=0.32 PerfScore 2.66
+						;; size=12 bbWeight=0.32 PerfScore 2.10
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -64,15 +60,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 14.91, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
+; Total bytes of code 40, prolog size 4, PerfScore 14.10, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 92171.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -19,13 +19,13 @@
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T05] (  4,  2.04)     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T06] (  2,  0.70)     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T02] (  4,  2.04)     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T02] (  4,  2.04)     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T03] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
-;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
+;* V14 tmp11        [V14,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T04] (  4,  2.70)     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  2.35)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -39,23 +39,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=0.35, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=0.35 PerfScore 2.87
+						;; size=12 bbWeight=0.35 PerfScore 2.26
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -64,15 +60,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 15.12, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
+; Total bytes of code 40, prolog size 4, PerfScore 14.26, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+18</span> (<span style="color:red">+0.77%</span>) : 275072.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,7 +16,7 @@
 ;  V04 loc1         [V04,T31] ( 15,  2   )     ref  ->  r15         class-hnd <System.Object[]>
 ;  V05 loc2         [V05,T42] (  7,  1   )     ref  ->  registers   class-hnd <System.Attribute[]>
 ;  V06 loc3         [V06,T32] (  7,  2   )     ref  ->  rdi         class-hnd <System.Reflection.ParameterInfo>
-;  V07 loc4         [V07,T43] (  7,  1   )     int  ->  [rbp-0x3C] 
+;  V07 loc4         [V07,T43] (  6,  1   )     int  ->  [rbp-0x3C] 
 ;  V08 loc5         [V08,T53] (  4,  0   )     ref  ->  [rbp-0xB0]  class-hnd exact spill-single-def <System.RuntimeType>
 ;* V09 loc6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.AttributeUsageAttribute>
 ;  V10 loc7         [V10,T45] (  9,  0   )     int  ->  r12        
@@ -135,7 +135,7 @@
 ;  V123 tmp103      [V123,T76] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
 ;  V124 cse0        [V124,T26] (  3,  3   )     int  ->  r15         "CSE - moderate"
 ;  V125 cse1        [V125,T15] (  4,  4   )     ref  ->  rax         "CSE - moderate"
-;  V126 cse2        [V126,T09] (  7,  5.12)     int  ->  [rbp-0x94]  "CSE - aggressive"
+;  V126 cse2        [V126,T09] (  6,  5.12)     int  ->  [rbp-0x94]  "CSE - aggressive"
 ;  V127 cse3        [V127,T12] (  9,  4   )    long  ->  r12         "CSE - moderate"
 ;  V128 cse4        [V128,T14] (  5,  4   )    long  ->  [rbp-0xA0]  spill-single-def "CSE - moderate"
 ;  V129 rat0        [V129,T02] (  5,  7.50)     ref  ->  rbx         "replacement local"
@@ -198,13 +198,13 @@ G_M62006_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rax]
        mov      qword ptr [rbp-0xA0], rax
        cmp      r12, rax
-       jne      G_M62006_IG72
+       jne      G_M62006_IG73
        test     rbx, rbx
-       je       G_M62006_IG65
+       je       G_M62006_IG66
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        ; gcrRegs -[rcx]
        cmp      qword ptr [rbx], rcx
-       jne      G_M62006_IG66
+       jne      G_M62006_IG67
        mov      rdx, rbx
        ; gcrRegs +[rdx]
 						;; size=173 bbWeight=1 PerfScore 24.00
@@ -216,7 +216,7 @@ G_M62006_IG03:        ; bbWeight=1, gcVars=00000000000000000000020000000000 {V03
 G_M62006_IG04:        ; bbWeight=0.50, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rdx], rcx
-       jne      G_M62006_IG67
+       jne      G_M62006_IG68
 						;; size=19 bbWeight=0.50 PerfScore 2.12
 G_M62006_IG05:        ; bbWeight=1, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      r8, rdx
@@ -224,9 +224,9 @@ G_M62006_IG05:        ; bbWeight=1, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000
        mov      gword ptr [rbp-0xC0], r8
        ; GC ptr vars +{V29}
        test     r8, r8
-       je       G_M62006_IG67
-       test     dword ptr [rsi+0x40], 0xD1FFAB1E
        je       G_M62006_IG68
+       test     dword ptr [rsi+0x40], 0xD1FFAB1E
+       je       G_M62006_IG69
        mov      ecx, r15d
        call     [<unknown method>]
        ; gcrRegs -[rdx r8]
@@ -315,9 +315,9 @@ G_M62006_IG16:        ; bbWeight=0.25, gcrefRegs=014D {rax rdx rbx rsi r8}, byre
 G_M62006_IG17:        ; bbWeight=1, gcrefRegs=054C {rdx rbx rsi r8 r10}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        test     r8, r8
-       jne      G_M62006_IG69
+       jne      G_M62006_IG70
        test     rdx, rdx
-       je       G_M62006_IG70
+       je       G_M62006_IG71
        mov      rcx, gword ptr [rdx+0x08]
        ; gcrRegs +[rcx]
        call     <unknown method>
@@ -374,11 +374,11 @@ G_M62006_IG21:        ; bbWeight=1, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {},
        xor      eax, eax
        mov      edx, dword ptr [r15+0x08]
        test     edx, edx
-       jg       G_M62006_IG73
+       jg       G_M62006_IG36
 						;; size=14 bbWeight=1 PerfScore 3.50
 G_M62006_IG22:        ; bbWeight=3.12, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {}, byref
        test     edx, edx
-       jne      G_M62006_IG79
+       jne      G_M62006_IG82
 						;; size=8 bbWeight=3.12 PerfScore 3.91
 G_M62006_IG23:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[r15]
@@ -390,15 +390,15 @@ G_M62006_IG23:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        test     eax, eax
-       jne      G_M62006_IG37
+       jne      G_M62006_IG38
        xor      ecx, ecx
        mov      dword ptr [rbp-0x60], ecx
        mov      r15d, dword ptr [rbp-0x60]
        test     r15d, r15d
-       jl       G_M62006_IG76
+       jl       G_M62006_IG79
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rbx], rcx
-       jne      G_M62006_IG77
+       jne      G_M62006_IG80
        mov      gword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
        mov      rcx, rbx
@@ -413,11 +413,11 @@ G_M62006_IG24:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
 G_M62006_IG25:        ; bbWeight=0.50, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        mov      r8, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rcx], r8
-       jne      G_M62006_IG78
+       jne      G_M62006_IG81
 						;; size=19 bbWeight=0.50 PerfScore 2.12
 G_M62006_IG26:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        test     rcx, rcx
-       je       G_M62006_IG78
+       je       G_M62006_IG81
        mov      gword ptr [rbp-0x70], rcx
        xor      rcx, rcx
        mov      gword ptr [rbp-0x68], rcx
@@ -431,7 +431,7 @@ G_M62006_IG26:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        lea      r8, bword ptr [rbp-0x80]
        ; byrRegs +[r8]
        test     rcx, rcx
-       je       G_M62006_IG36
+       je       G_M62006_IG37
 						;; size=53 bbWeight=1 PerfScore 9.08
 G_M62006_IG27:        ; bbWeight=1.01, gcrefRegs=000A {rcx rbx}, byrefRegs=0100 {r8}, byref
        mov      rdx, qword ptr [rcx+0x18]
@@ -510,17 +510,23 @@ G_M62006_IG34:        ; bbWeight=0.25, gcrefRegs=0004 {rdx}, byrefRegs=0000 {},
 						;; size=8 bbWeight=0.25 PerfScore 0.31
 G_M62006_IG35:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
-       jmp      SHORT G_M62006_IG38
+       jmp      SHORT G_M62006_IG39
 						;; size=2 bbWeight=1 PerfScore 2.00
-G_M62006_IG36:        ; bbWeight=0.00, gcVars=00000000000000000000020000000002 {V00 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0100 {r8}, gcvars, byref
-       ; byrRegs +[r8]
+G_M62006_IG36:        ; bbWeight=0.50, gcVars=00000000000000000000020000000002 {V00 V03}, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[r15]
        ; GC ptr vars -{V00 V01}
+       mov      dword ptr [rbp-0x94], edx
+       jmp      G_M62006_IG74
+						;; size=11 bbWeight=0.50 PerfScore 1.50
+G_M62006_IG37:        ; bbWeight=0.00, gcrefRegs=0008 {rbx}, byrefRegs=0100 {r8}, byref
+       ; gcrRegs -[r15]
+       ; byrRegs +[r8]
        xor      edx, edx
        mov      gword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
        jmp      G_M62006_IG28
 						;; size=11 bbWeight=0.00 PerfScore 0.00
-G_M62006_IG37:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG38:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; byrRegs -[r8]
        ; GC ptr vars -{V01}
        mov      rcx, 0xD1FFAB1E      ; System.Attribute[]
@@ -532,20 +538,20 @@ G_M62006_IG37:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; GC ptr vars +{V01}
        mov      rbx, rax
 						;; size=24 bbWeight=1 PerfScore 2.75
-G_M62006_IG38:        ; bbWeight=1, gcVars=00000000000000000000020000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M62006_IG39:        ; bbWeight=1, gcVars=00000000000000000000020000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax]
        ; GC ptr vars +{V00}
        mov      r15, qword ptr [rbp-0xA0]
        cmp      r12, r15
-       jne      SHORT G_M62006_IG48
+       jne      SHORT G_M62006_IG49
 						;; size=12 bbWeight=1 PerfScore 2.25
-G_M62006_IG39:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG40:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rsi, gword ptr [rbp+0x10]
        ; gcrRegs +[rsi]
        mov      rcx, gword ptr [rsi+0x18]
        ; gcrRegs +[rcx]
 						;; size=8 bbWeight=1 PerfScore 3.00
-G_M62006_IG40:        ; bbWeight=1, gcVars=00000000000000000000020000000001 {V01 V03}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M62006_IG41:        ; bbWeight=1, gcVars=00000000000000000000020000000001 {V01 V03}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
        ; GC ptr vars -{V00 V01}
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x48]
@@ -553,64 +559,64 @@ G_M62006_IG40:        ; bbWeight=1, gcVars=00000000000000000000020000000001 {V01
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       SHORT G_M62006_IG47
+       je       SHORT G_M62006_IG48
        test     dil, dil
-       je       SHORT G_M62006_IG47
+       je       SHORT G_M62006_IG48
        mov      ecx, 1
        call     [<unknown method>]
        ; gcrRegs -[rax]
        ; gcr arg pop 0
        cmp      r12, r15
-       jne      G_M62006_IG82
+       jne      G_M62006_IG85
        mov      rdi, gword ptr [rsi+0x18]
        ; gcrRegs +[rdi]
 						;; size=44 bbWeight=1 PerfScore 16.00
-G_M62006_IG41:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG42:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       je       SHORT G_M62006_IG43
+       je       SHORT G_M62006_IG44
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M62006_IG42:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG43:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, 0xD1FFAB1E      ; System.Reflection.RuntimeMethodInfo
        cmp      qword ptr [rdi], rcx
-       jne      SHORT G_M62006_IG45
+       jne      SHORT G_M62006_IG46
 						;; size=15 bbWeight=0.50 PerfScore 2.12
-G_M62006_IG43:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG44:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       je       SHORT G_M62006_IG45
+       je       SHORT G_M62006_IG46
        test     byte  ptr [rdi+0x5C], 64
-       jne      G_M62006_IG83
+       jne      G_M62006_IG86
 						;; size=15 bbWeight=1 PerfScore 5.25
-G_M62006_IG44:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M62006_IG45:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
        test     rdi, rdi
-       jne      G_M62006_IG84
+       jne      G_M62006_IG87
 						;; size=11 bbWeight=1 PerfScore 1.50
-G_M62006_IG45:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG46:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rsi rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M62006_IG46:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG47:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       jne      SHORT G_M62006_IG49
+       jne      SHORT G_M62006_IG50
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M62006_IG47:        ; bbWeight=0, gcVars=00000000000000000000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+G_M62006_IG48:        ; bbWeight=0, gcVars=00000000000000000000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rdi]
        ; GC ptr vars -{V03}
        mov      rax, rbx
        ; gcrRegs +[rax]
-       jmp      G_M62006_IG63
+       jmp      G_M62006_IG64
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M62006_IG48:        ; bbWeight=0.50, gcVars=00000000000000000000020000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+G_M62006_IG49:        ; bbWeight=0.50, gcVars=00000000000000000000020000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
...

```


</div></details>

<details>
<summary><span style="color:red">+18</span> (<span style="color:red">+0.78%</span>) : 490914.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,7 +16,7 @@
 ;  V04 loc1         [V04,T31] ( 15,  2   )     ref  ->  r15         class-hnd <System.Object[]>
 ;  V05 loc2         [V05,T43] (  7,  1   )     ref  ->  registers   class-hnd <System.Attribute[]>
 ;  V06 loc3         [V06,T32] (  7,  2   )     ref  ->  rdi         class-hnd <System.Reflection.ParameterInfo>
-;  V07 loc4         [V07,T44] (  7,  1   )     int  ->  [rbp-0x3C] 
+;  V07 loc4         [V07,T44] (  6,  1   )     int  ->  [rbp-0x3C] 
 ;  V08 loc5         [V08,T54] (  4,  0   )     ref  ->  [rbp-0xB0]  class-hnd exact spill-single-def <System.RuntimeType>
 ;* V09 loc6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.AttributeUsageAttribute>
 ;  V10 loc7         [V10,T46] (  9,  0   )     int  ->  r12        
@@ -135,7 +135,7 @@
 ;  V123 tmp103      [V123,T76] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
 ;  V124 cse0        [V124,T27] (  3,  3   )     int  ->  r15         "CSE - moderate"
 ;  V125 cse1        [V125,T14] (  4,  4   )     ref  ->  rax         "CSE - moderate"
-;  V126 cse2        [V126,T21] (  7,  3.37)     int  ->  [rbp-0x94]  "CSE - moderate"
+;  V126 cse2        [V126,T21] (  6,  3.37)     int  ->  [rbp-0x94]  "CSE - moderate"
 ;  V127 cse3        [V127,T11] (  9,  4   )    long  ->  r12         "CSE - moderate"
 ;  V128 cse4        [V128,T13] (  5,  4   )    long  ->  [rbp-0xA0]  spill-single-def "CSE - moderate"
 ;  V129 rat0        [V129,T02] (  5,  7.50)     ref  ->  rbx         "replacement local"
@@ -198,13 +198,13 @@ G_M62006_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rax]
        mov      qword ptr [rbp-0xA0], rax
        cmp      r12, rax
-       jne      G_M62006_IG73
+       jne      G_M62006_IG74
        test     rbx, rbx
-       je       G_M62006_IG67
+       je       G_M62006_IG68
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        ; gcrRegs -[rcx]
        cmp      qword ptr [rbx], rcx
-       jne      G_M62006_IG68
+       jne      G_M62006_IG69
        mov      rdx, rbx
        ; gcrRegs +[rdx]
 						;; size=173 bbWeight=1 PerfScore 24.00
@@ -216,7 +216,7 @@ G_M62006_IG03:        ; bbWeight=1, gcVars=00000000000000000000040000000000 {V03
 G_M62006_IG04:        ; bbWeight=0.50, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rdx], rcx
-       jne      G_M62006_IG69
+       jne      G_M62006_IG70
 						;; size=19 bbWeight=0.50 PerfScore 2.12
 G_M62006_IG05:        ; bbWeight=1, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      r8, rdx
@@ -224,9 +224,9 @@ G_M62006_IG05:        ; bbWeight=1, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000
        mov      gword ptr [rbp-0xC0], r8
        ; GC ptr vars +{V29}
        test     r8, r8
-       je       G_M62006_IG69
-       test     dword ptr [rsi+0x40], 0xD1FFAB1E
        je       G_M62006_IG70
+       test     dword ptr [rsi+0x40], 0xD1FFAB1E
+       je       G_M62006_IG71
        mov      ecx, r15d
        call     [<unknown method>]
        ; gcrRegs -[rdx r8]
@@ -330,7 +330,7 @@ G_M62006_IG18:        ; bbWeight=0.50, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0
 G_M62006_IG19:        ; bbWeight=0.50, gcrefRegs=8148 {rbx rsi r8 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax] +[r8 r15]
        test     r8, r8
-       je       G_M62006_IG71
+       je       G_M62006_IG72
        mov      rcx, gword ptr [r8+0x08]
        ; gcrRegs +[rcx]
        call     <unknown method>
@@ -387,11 +387,11 @@ G_M62006_IG23:        ; bbWeight=1, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {},
        xor      eax, eax
        mov      edx, dword ptr [r15+0x08]
        test     edx, edx
-       jg       G_M62006_IG74
+       jg       G_M62006_IG38
 						;; size=14 bbWeight=1 PerfScore 3.50
 G_M62006_IG24:        ; bbWeight=1.37, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {}, byref
        test     edx, edx
-       jne      G_M62006_IG80
+       jne      G_M62006_IG83
 						;; size=8 bbWeight=1.37 PerfScore 1.71
 G_M62006_IG25:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[r15]
@@ -403,15 +403,15 @@ G_M62006_IG25:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        test     eax, eax
-       jne      G_M62006_IG39
+       jne      G_M62006_IG40
        xor      ecx, ecx
        mov      dword ptr [rbp-0x60], ecx
        mov      r15d, dword ptr [rbp-0x60]
        test     r15d, r15d
-       jl       G_M62006_IG77
+       jl       G_M62006_IG80
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rbx], rcx
-       jne      G_M62006_IG78
+       jne      G_M62006_IG81
        mov      gword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
        mov      rcx, rbx
@@ -426,11 +426,11 @@ G_M62006_IG26:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
 G_M62006_IG27:        ; bbWeight=0.50, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        mov      r8, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rcx], r8
-       jne      G_M62006_IG79
+       jne      G_M62006_IG82
 						;; size=19 bbWeight=0.50 PerfScore 2.12
 G_M62006_IG28:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        test     rcx, rcx
-       je       G_M62006_IG79
+       je       G_M62006_IG82
        mov      gword ptr [rbp-0x70], rcx
        xor      rcx, rcx
        mov      gword ptr [rbp-0x68], rcx
@@ -444,7 +444,7 @@ G_M62006_IG28:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        lea      r8, bword ptr [rbp-0x80]
        ; byrRegs +[r8]
        test     rcx, rcx
-       je       G_M62006_IG38
+       je       G_M62006_IG39
 						;; size=53 bbWeight=1 PerfScore 9.08
 G_M62006_IG29:        ; bbWeight=1.01, gcrefRegs=000A {rcx rbx}, byrefRegs=0100 {r8}, byref
        mov      rdx, qword ptr [rcx+0x18]
@@ -523,17 +523,23 @@ G_M62006_IG36:        ; bbWeight=0.25, gcrefRegs=0004 {rdx}, byrefRegs=0000 {},
 						;; size=8 bbWeight=0.25 PerfScore 0.31
 G_M62006_IG37:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
-       jmp      SHORT G_M62006_IG40
+       jmp      SHORT G_M62006_IG41
 						;; size=2 bbWeight=1 PerfScore 2.00
-G_M62006_IG38:        ; bbWeight=0.00, gcVars=00000000000000000000040000000002 {V00 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0100 {r8}, gcvars, byref
-       ; byrRegs +[r8]
+G_M62006_IG38:        ; bbWeight=0.50, gcVars=00000000000000000000040000000002 {V00 V03}, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[r15]
        ; GC ptr vars -{V00 V01}
+       mov      dword ptr [rbp-0x94], edx
+       jmp      G_M62006_IG75
+						;; size=11 bbWeight=0.50 PerfScore 1.50
+G_M62006_IG39:        ; bbWeight=0.00, gcrefRegs=0008 {rbx}, byrefRegs=0100 {r8}, byref
+       ; gcrRegs -[r15]
+       ; byrRegs +[r8]
        xor      edx, edx
        mov      gword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
        jmp      G_M62006_IG30
 						;; size=11 bbWeight=0.00 PerfScore 0.00
-G_M62006_IG39:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG40:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; byrRegs -[r8]
        ; GC ptr vars -{V01}
        mov      rcx, 0xD1FFAB1E      ; System.Attribute[]
@@ -545,20 +551,20 @@ G_M62006_IG39:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; GC ptr vars +{V01}
        mov      rbx, rax
 						;; size=24 bbWeight=1 PerfScore 2.75
-G_M62006_IG40:        ; bbWeight=1, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M62006_IG41:        ; bbWeight=1, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax]
        ; GC ptr vars +{V00}
        mov      r15, qword ptr [rbp-0xA0]
        cmp      r12, r15
-       jne      SHORT G_M62006_IG50
+       jne      SHORT G_M62006_IG51
 						;; size=12 bbWeight=1 PerfScore 2.25
-G_M62006_IG41:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG42:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rsi, gword ptr [rbp+0x10]
        ; gcrRegs +[rsi]
        mov      rcx, gword ptr [rsi+0x18]
        ; gcrRegs +[rcx]
 						;; size=8 bbWeight=1 PerfScore 3.00
-G_M62006_IG42:        ; bbWeight=1, gcVars=00000000000000000000040000000001 {V01 V03}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M62006_IG43:        ; bbWeight=1, gcVars=00000000000000000000040000000001 {V01 V03}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
        ; GC ptr vars -{V00 V01}
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x48]
@@ -566,64 +572,64 @@ G_M62006_IG42:        ; bbWeight=1, gcVars=00000000000000000000040000000001 {V01
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       SHORT G_M62006_IG49
+       je       SHORT G_M62006_IG50
        test     dil, dil
-       je       SHORT G_M62006_IG49
+       je       SHORT G_M62006_IG50
        mov      ecx, 1
        call     [<unknown method>]
        ; gcrRegs -[rax]
        ; gcr arg pop 0
        cmp      r12, r15
-       jne      G_M62006_IG83
+       jne      G_M62006_IG86
        mov      rdi, gword ptr [rsi+0x18]
        ; gcrRegs +[rdi]
 						;; size=44 bbWeight=1 PerfScore 16.00
-G_M62006_IG43:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG44:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       je       SHORT G_M62006_IG45
+       je       SHORT G_M62006_IG46
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M62006_IG44:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG45:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, 0xD1FFAB1E      ; System.Reflection.RuntimeMethodInfo
        cmp      qword ptr [rdi], rcx
-       jne      SHORT G_M62006_IG47
+       jne      SHORT G_M62006_IG48
 						;; size=15 bbWeight=0.50 PerfScore 2.12
-G_M62006_IG45:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG46:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       je       SHORT G_M62006_IG47
+       je       SHORT G_M62006_IG48
        test     byte  ptr [rdi+0x5C], 64
-       jne      G_M62006_IG84
+       jne      G_M62006_IG87
 						;; size=15 bbWeight=1 PerfScore 5.25
-G_M62006_IG46:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M62006_IG47:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
        test     rdi, rdi
-       jne      G_M62006_IG85
+       jne      G_M62006_IG88
 						;; size=11 bbWeight=1 PerfScore 1.50
-G_M62006_IG47:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG48:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rsi rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M62006_IG48:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG49:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       jne      SHORT G_M62006_IG51
+       jne      SHORT G_M62006_IG52
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M62006_IG49:        ; bbWeight=0, gcVars=00000000000000000000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+G_M62006_IG50:        ; bbWeight=0, gcVars=00000000000000000000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rdi]
        ; GC ptr vars -{V03}
        mov      rax, rbx
        ; gcrRegs +[rax]
-       jmp      G_M62006_IG65
+       jmp      G_M62006_IG66
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M62006_IG50:        ; bbWeight=0.50, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+G_M62006_IG51:        ; bbWeight=0.50, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars +{V00 V01 V03 V42}
        mov      rsi, gword ptr [rbp+0x10]
...

```


</div></details>

<details>
<summary><span style="color:red">+18</span> (<span style="color:red">+0.78%</span>) : 683493.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,7 +16,7 @@
 ;  V04 loc1         [V04,T30] ( 15,  2   )     ref  ->  r15         class-hnd <System.Object[]>
 ;  V05 loc2         [V05,T43] (  7,  1   )     ref  ->  registers   class-hnd <System.Attribute[]>
 ;  V06 loc3         [V06,T31] (  7,  2   )     ref  ->  rdi         class-hnd <System.Reflection.ParameterInfo>
-;  V07 loc4         [V07,T44] (  7,  1   )     int  ->  [rbp-0x3C] 
+;  V07 loc4         [V07,T44] (  6,  1   )     int  ->  [rbp-0x3C] 
 ;  V08 loc5         [V08,T54] (  4,  0   )     ref  ->  [rbp-0xB0]  class-hnd exact spill-single-def <System.RuntimeType>
 ;* V09 loc6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.AttributeUsageAttribute>
 ;  V10 loc7         [V10,T46] (  9,  0   )     int  ->  r12        
@@ -135,7 +135,7 @@
 ;  V123 tmp103      [V123,T76] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
 ;  V124 cse0        [V124,T26] (  3,  3   )     int  ->  r15         "CSE - moderate"
 ;  V125 cse1        [V125,T15] (  4,  4   )     ref  ->  rax         "CSE - moderate"
-;  V126 cse2        [V126,T11] (  7,  4.13)     int  ->  [rbp-0x94]  "CSE - moderate"
+;  V126 cse2        [V126,T11] (  6,  4.13)     int  ->  [rbp-0x94]  "CSE - moderate"
 ;  V127 cse3        [V127,T12] (  9,  4   )    long  ->  r12         "CSE - moderate"
 ;  V128 cse4        [V128,T14] (  5,  4   )    long  ->  [rbp-0xA0]  spill-single-def "CSE - moderate"
 ;  V129 rat0        [V129,T02] (  5,  7.50)     ref  ->  rbx         "replacement local"
@@ -198,13 +198,13 @@ G_M62006_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rax]
        mov      qword ptr [rbp-0xA0], rax
        cmp      r12, rax
-       jne      G_M62006_IG73
+       jne      G_M62006_IG74
        test     rbx, rbx
-       je       G_M62006_IG67
+       je       G_M62006_IG68
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        ; gcrRegs -[rcx]
        cmp      qword ptr [rbx], rcx
-       jne      G_M62006_IG68
+       jne      G_M62006_IG69
        mov      rdx, rbx
        ; gcrRegs +[rdx]
 						;; size=173 bbWeight=1 PerfScore 24.00
@@ -216,7 +216,7 @@ G_M62006_IG03:        ; bbWeight=1, gcVars=00000000000000000000040000000000 {V03
 G_M62006_IG04:        ; bbWeight=0.50, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rdx], rcx
-       jne      G_M62006_IG69
+       jne      G_M62006_IG70
 						;; size=19 bbWeight=0.50 PerfScore 2.12
 G_M62006_IG05:        ; bbWeight=1, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      r8, rdx
@@ -224,9 +224,9 @@ G_M62006_IG05:        ; bbWeight=1, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000
        mov      gword ptr [rbp-0xC0], r8
        ; GC ptr vars +{V29}
        test     r8, r8
-       je       G_M62006_IG69
-       test     dword ptr [rsi+0x40], 0xD1FFAB1E
        je       G_M62006_IG70
+       test     dword ptr [rsi+0x40], 0xD1FFAB1E
+       je       G_M62006_IG71
        mov      ecx, r15d
        call     [<unknown method>]
        ; gcrRegs -[rdx r8]
@@ -320,7 +320,7 @@ G_M62006_IG17:        ; bbWeight=1, gcrefRegs=814C {rdx rbx rsi r8 r15}, byrefRe
 G_M62006_IG18:        ; bbWeight=0.74, gcrefRegs=8148 {rbx rsi r8 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdx]
        test     r8, r8
-       je       G_M62006_IG71
+       je       G_M62006_IG72
        mov      rcx, gword ptr [r8+0x08]
        ; gcrRegs +[rcx]
        call     <unknown method>
@@ -390,11 +390,11 @@ G_M62006_IG23:        ; bbWeight=1, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {},
        xor      eax, eax
        mov      edx, dword ptr [r15+0x08]
        test     edx, edx
-       jg       G_M62006_IG74
+       jg       G_M62006_IG38
 						;; size=14 bbWeight=1 PerfScore 3.50
 G_M62006_IG24:        ; bbWeight=2.13, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {}, byref
        test     edx, edx
-       jne      G_M62006_IG80
+       jne      G_M62006_IG83
 						;; size=8 bbWeight=2.13 PerfScore 2.66
 G_M62006_IG25:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[r15]
@@ -406,15 +406,15 @@ G_M62006_IG25:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        test     eax, eax
-       jne      G_M62006_IG39
+       jne      G_M62006_IG40
        xor      ecx, ecx
        mov      dword ptr [rbp-0x60], ecx
        mov      r15d, dword ptr [rbp-0x60]
        test     r15d, r15d
-       jl       G_M62006_IG77
+       jl       G_M62006_IG80
        mov      rcx, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rbx], rcx
-       jne      G_M62006_IG78
+       jne      G_M62006_IG81
        mov      gword ptr [rbp+0x18], rbx
        mov      rcx, rbx
        ; gcrRegs +[rcx]
@@ -428,11 +428,11 @@ G_M62006_IG26:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
 G_M62006_IG27:        ; bbWeight=0.50, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        mov      r8, 0xD1FFAB1E      ; System.RuntimeType
        cmp      qword ptr [rcx], r8
-       jne      G_M62006_IG79
+       jne      G_M62006_IG82
 						;; size=19 bbWeight=0.50 PerfScore 2.12
 G_M62006_IG28:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        test     rcx, rcx
-       je       G_M62006_IG79
+       je       G_M62006_IG82
        mov      gword ptr [rbp-0x70], rcx
        xor      rcx, rcx
        mov      gword ptr [rbp-0x68], rcx
@@ -446,7 +446,7 @@ G_M62006_IG28:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        lea      r8, bword ptr [rbp-0x80]
        ; byrRegs +[r8]
        test     rcx, rcx
-       je       G_M62006_IG38
+       je       G_M62006_IG39
 						;; size=53 bbWeight=1 PerfScore 9.08
 G_M62006_IG29:        ; bbWeight=1.01, gcrefRegs=000A {rcx rbx}, byrefRegs=0100 {r8}, byref
        mov      rdx, qword ptr [rcx+0x18]
@@ -525,17 +525,23 @@ G_M62006_IG36:        ; bbWeight=0.25, gcrefRegs=0004 {rdx}, byrefRegs=0000 {},
 						;; size=8 bbWeight=0.25 PerfScore 0.31
 G_M62006_IG37:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
-       jmp      SHORT G_M62006_IG40
+       jmp      SHORT G_M62006_IG41
 						;; size=2 bbWeight=1 PerfScore 2.00
-G_M62006_IG38:        ; bbWeight=0.00, gcVars=00000000000000000000040000000002 {V00 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0100 {r8}, gcvars, byref
-       ; byrRegs +[r8]
+G_M62006_IG38:        ; bbWeight=0.50, gcVars=00000000000000000000040000000002 {V00 V03}, gcrefRegs=8008 {rbx r15}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[r15]
        ; GC ptr vars -{V00 V01}
+       mov      dword ptr [rbp-0x94], edx
+       jmp      G_M62006_IG75
+						;; size=11 bbWeight=0.50 PerfScore 1.50
+G_M62006_IG39:        ; bbWeight=0.00, gcrefRegs=0008 {rbx}, byrefRegs=0100 {r8}, byref
+       ; gcrRegs -[r15]
+       ; byrRegs +[r8]
        xor      edx, edx
        mov      gword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
        jmp      G_M62006_IG30
 						;; size=11 bbWeight=0.00 PerfScore 0.00
-G_M62006_IG39:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG40:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; byrRegs -[r8]
        ; GC ptr vars -{V01}
        mov      rcx, 0xD1FFAB1E      ; System.Attribute[]
@@ -547,20 +553,20 @@ G_M62006_IG39:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; GC ptr vars +{V01}
        mov      rbx, rax
 						;; size=24 bbWeight=1 PerfScore 2.75
-G_M62006_IG40:        ; bbWeight=1, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M62006_IG41:        ; bbWeight=1, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax]
        ; GC ptr vars +{V00}
        mov      r15, qword ptr [rbp-0xA0]
        cmp      r12, r15
-       jne      SHORT G_M62006_IG50
+       jne      SHORT G_M62006_IG51
 						;; size=12 bbWeight=1 PerfScore 2.25
-G_M62006_IG41:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG42:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rsi, gword ptr [rbp+0x10]
        ; gcrRegs +[rsi]
        mov      rcx, gword ptr [rsi+0x18]
        ; gcrRegs +[rcx]
 						;; size=8 bbWeight=1 PerfScore 3.00
-G_M62006_IG42:        ; bbWeight=1, gcVars=00000000000000000000040000000001 {V01 V03}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M62006_IG43:        ; bbWeight=1, gcVars=00000000000000000000040000000001 {V01 V03}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
        ; GC ptr vars -{V00 V01}
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x48]
@@ -568,64 +574,64 @@ G_M62006_IG42:        ; bbWeight=1, gcVars=00000000000000000000040000000001 {V01
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       SHORT G_M62006_IG49
+       je       SHORT G_M62006_IG50
        test     dil, dil
-       je       SHORT G_M62006_IG49
+       je       SHORT G_M62006_IG50
        mov      ecx, 1
        call     [<unknown method>]
        ; gcrRegs -[rax]
        ; gcr arg pop 0
        cmp      r12, r15
-       jne      G_M62006_IG83
+       jne      G_M62006_IG86
        mov      rdi, gword ptr [rsi+0x18]
        ; gcrRegs +[rdi]
 						;; size=44 bbWeight=1 PerfScore 16.00
-G_M62006_IG43:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG44:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       je       SHORT G_M62006_IG45
+       je       SHORT G_M62006_IG46
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M62006_IG44:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG45:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, 0xD1FFAB1E      ; System.Reflection.RuntimeMethodInfo
        cmp      qword ptr [rdi], rcx
-       jne      SHORT G_M62006_IG47
+       jne      SHORT G_M62006_IG48
 						;; size=15 bbWeight=0.50 PerfScore 2.12
-G_M62006_IG45:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG46:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       je       SHORT G_M62006_IG47
+       je       SHORT G_M62006_IG48
        test     byte  ptr [rdi+0x5C], 64
-       jne      G_M62006_IG84
+       jne      G_M62006_IG87
 						;; size=15 bbWeight=1 PerfScore 5.25
-G_M62006_IG46:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M62006_IG47:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
        test     rdi, rdi
-       jne      G_M62006_IG85
+       jne      G_M62006_IG88
 						;; size=11 bbWeight=1 PerfScore 1.50
-G_M62006_IG47:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M62006_IG48:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rsi rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M62006_IG48:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M62006_IG49:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        test     rdi, rdi
-       jne      SHORT G_M62006_IG51
+       jne      SHORT G_M62006_IG52
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M62006_IG49:        ; bbWeight=0, gcVars=00000000000000000000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+G_M62006_IG50:        ; bbWeight=0, gcVars=00000000000000000000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rdi]
        ; GC ptr vars -{V03}
        mov      rax, rbx
        ; gcrRegs +[rax]
-       jmp      G_M62006_IG65
+       jmp      G_M62006_IG66
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M62006_IG50:        ; bbWeight=0.50, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+G_M62006_IG51:        ; bbWeight=0.50, gcVars=00000000000000000000040000000003 {V00 V01 V03}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars +{V00 V01 V03 V42}
        mov      rsi, gword ptr [rbp+0x10]
...

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 7710.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,23 +8,23 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  5,  8   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  5,  8   )   byref  ->  rcx         this single-def
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T04] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
+;  V04 tmp1         [V04,T03] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
 ;* V05 tmp2         [V05    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T01] (  4, 13   )     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T02] (  2,  8   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T05] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T03] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -38,23 +38,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=4 PerfScore 33.00
+						;; size=12 bbWeight=4 PerfScore 26.00
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -63,15 +59,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 45.25, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
+; Total bytes of code 40, prolog size 4, PerfScore 38.00, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-24</span> (<span style="color:green">-29.63%</span>) : 223067.dasm - System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__0():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,8 +14,8 @@
 ;  V03 loc2         [V03    ] (  1,  0   )     ref  ->  [rsp+0x30]  pinned class-hnd single-def <<unknown class>>
 ;  V04 loc3         [V04    ] (  1,  0   )     ref  ->  [rsp+0x28]  must-init pinned class-hnd single-def <<unknown class>>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T01] (  5,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V07 tmp2         [V07,T02] (  5,  0   )     ref  ->  rcx         class-hnd single-def "dup spill" <<unknown class>>
+;  V06 tmp1         [V06,T01] (  4,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V07 tmp2         [V07,T02] (  4,  0   )     ref  ->  rcx         class-hnd single-def "dup spill" <<unknown class>>
 ;* V08 tmp3         [V08    ] (  0,  0   )    long  ->  zero-ref    "Cast away GC"
 ;* V09 tmp4         [V09    ] (  0,  0   )    long  ->  zero-ref    "Cast away GC"
 ;
@@ -33,36 +33,25 @@ G_M22930_IG02:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        mov      gword ptr [rsp+0x30], rax
        test     rax, rax
        je       SHORT G_M22930_IG03
-       cmp      dword ptr [rax+0x08], 0
-       je       SHORT G_M22930_IG03
-       cmp      dword ptr [rax+0x08], 0
-       jbe      SHORT G_M22930_IG05
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M22930_IG03:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M22930_IG03:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rcx+0x10]
        mov      gword ptr [rsp+0x28], rcx
        test     rcx, rcx
        je       SHORT G_M22930_IG04
-       cmp      dword ptr [rcx+0x08], 0
-       je       SHORT G_M22930_IG04
-       cmp      dword ptr [rcx+0x08], 0
-       jbe      SHORT G_M22930_IG05
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M22930_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      ecx, dword ptr [rcx+0x08]
        ; gcrRegs -[rcx]
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M22930_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      ecx, 43
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
        ; gcr arg pop 0
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M22930_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 81, prolog size 11, PerfScore 0.00, instruction count 24, allocated bytes for code 81 (MethodHash=d482a66d) for method System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__0():this (FullOpts)
+; Total bytes of code 57, prolog size 11, PerfScore 0.00, instruction count 16, allocated bytes for code 57 (MethodHash=d482a66d) for method System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__0():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-24</span> (<span style="color:green">-29.63%</span>) : 223068.dasm - System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__1():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,8 +14,8 @@
 ;  V03 loc2         [V03    ] (  1,  0   )     ref  ->  [rsp+0x30]  pinned class-hnd single-def <<unknown class>>
 ;  V04 loc3         [V04    ] (  1,  0   )     ref  ->  [rsp+0x28]  must-init pinned class-hnd single-def <<unknown class>>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T01] (  5,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V07 tmp2         [V07,T02] (  5,  0   )     ref  ->  rcx         class-hnd single-def "dup spill" <<unknown class>>
+;  V06 tmp1         [V06,T01] (  4,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V07 tmp2         [V07,T02] (  4,  0   )     ref  ->  rcx         class-hnd single-def "dup spill" <<unknown class>>
 ;* V08 tmp3         [V08    ] (  0,  0   )    long  ->  zero-ref    "Cast away GC"
 ;* V09 tmp4         [V09    ] (  0,  0   )    long  ->  zero-ref    "Cast away GC"
 ;
@@ -33,36 +33,25 @@ G_M54707_IG02:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        mov      gword ptr [rsp+0x30], rax
        test     rax, rax
        je       SHORT G_M54707_IG03
-       cmp      dword ptr [rax+0x08], 0
-       je       SHORT G_M54707_IG03
-       cmp      dword ptr [rax+0x08], 0
-       jbe      SHORT G_M54707_IG05
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M54707_IG03:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M54707_IG03:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rcx+0x10]
        mov      gword ptr [rsp+0x28], rcx
        test     rcx, rcx
        je       SHORT G_M54707_IG04
-       cmp      dword ptr [rcx+0x08], 0
-       je       SHORT G_M54707_IG04
-       cmp      dword ptr [rcx+0x08], 0
-       jbe      SHORT G_M54707_IG05
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M54707_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      ecx, dword ptr [rcx+0x08]
        ; gcrRegs -[rcx]
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M54707_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      ecx, 43
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
        ; gcr arg pop 0
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M54707_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 81, prolog size 11, PerfScore 0.00, instruction count 24, allocated bytes for code 81 (MethodHash=82122a4c) for method System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__1():this (FullOpts)
+; Total bytes of code 57, prolog size 11, PerfScore 0.00, instruction count 16, allocated bytes for code 57 (MethodHash=82122a4c) for method System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__1():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+2</span> (<span style="color:red">+0.03%</span>) : 190844.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateNamespaceChildren(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.NamespaceDefinitionHandle,System.String[],System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]],System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]]):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,29 +8,29 @@
 ; 12 inlinees with PGO data; 201 single block inlinees; 88 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T81] (  3,  6   )     ref  ->  [rsp+0x2D0]  this class-hnd single-def <System.Reflection.Metadata.Tests.MetadataReaderTests>
+;  V00 this         [V00,T81] (  3,  6   )     ref  ->  [rsp+0x2E0]  this class-hnd single-def <System.Reflection.Metadata.Tests.MetadataReaderTests>
 ;  V01 arg1         [V01,T01] ( 25, 72   )     ref  ->  rbx         class-hnd single-def <System.Reflection.Metadata.MetadataReader>
 ;* V02 arg2         [V02    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.Reflection.Metadata.NamespaceDefinitionHandle>
-;  V03 arg3         [V03,T70] (  7,  9   )     ref  ->  rsi         class-hnd single-def <System.String[]>
+;  V03 arg3         [V03,T67] (  7,  9   )     ref  ->  rsi         class-hnd single-def <System.String[]>
 ;  V04 arg4         [V04,T118] (  5,  7   )     ref  ->  r14         class-hnd <System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]]>
-;  V05 arg5         [V05,T119] (  5,  7   )     ref  ->  [rsp+0x2F8]  class-hnd <System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]]>
-;  V06 loc0         [V06,T42] ( 12, 16   )     ref  ->  r13         class-hnd exact single-def <System.Reflection.Metadata.Tests.MetadataReaderTests+<>c__DisplayClass35_0>
+;  V05 arg5         [V05,T119] (  5,  7   )     ref  ->  [rsp+0x308]  class-hnd <System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]]>
+;  V06 loc0         [V06,T39] ( 12, 16   )     ref  ->  r13         class-hnd exact single-def <System.Reflection.Metadata.Tests.MetadataReaderTests+<>c__DisplayClass35_0>
 ;* V07 loc1         [V07    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Reflection.Metadata.NamespaceDefinition>
 ;* V08 loc2         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <System.String>
 ;* V09 loc3         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <System.String>
-;  V10 loc4         [V10,T218] (  3,  2.50)   ubyte  ->  [rsp+0x284]  spill-single-def
-;  V11 loc5         [V11,T71] (  6, 10.50)     ref  ->  [rsp+0x180]  class-hnd <System.String[]>
-;  V12 loc6         [V12,T75] (  4, 10   )     int  ->  [rsp+0x280] 
-;  V13 loc7         [V13,T72] (  5, 10   )     ref  ->  r12         class-hnd <System.String[]>
-;  V14 loc8         [V14,T76] (  4, 10   )     int  ->  [rsp+0x27C] 
-;  V15 loc9         [V15,T122] (  4,  6   )     ref  ->  r15         class-hnd <System.Collections.Generic.IList`1[System.String]>
-;  V16 loc10        [V16,T77] (  4, 10   )     int  ->  r13        
+;  V10 loc4         [V10,T218] (  3,  2.50)   ubyte  ->  [rsp+0x294]  spill-single-def
+;  V11 loc5         [V11,T68] (  6, 10.50)     ref  ->  [rsp+0x190]  class-hnd <System.String[]>
+;  V12 loc6         [V12,T75] (  4, 10   )     int  ->  [rsp+0x290] 
+;  V13 loc7         [V13,T69] (  5, 10   )     ref  ->  [rsp+0x188]  class-hnd <System.String[]>
+;  V14 loc8         [V14,T76] (  4, 10   )     int  ->  [rsp+0x28C] 
+;  V15 loc9         [V15,T122] (  4,  6   )     ref  ->  rbp         class-hnd <System.Collections.Generic.IList`1[System.String]>
+;  V16 loc10        [V16,T77] (  4, 10   )     int  ->  r15        
 ;* V17 loc11        [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[System.Reflection.Metadata.TypeDefinitionHandle]>
 ;* V18 loc12        [V18    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1[System.Reflection.Metadata.TypeDefinitionHandle]>
 ;* V19 loc13        [V19    ] (  0,  0   )  struct ( 8) zero-ref    <System.Reflection.Metadata.TypeDefinitionHandle>
 ;* V20 loc14        [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Reflection.Metadata.TypeDefinition>
-;  V21 loc15        [V21,T89] (  2,  8   )     ref  ->  r12         class-hnd exact <System.String>
-;  V22 loc16        [V22,T63] (  5, 12   )     ref  ->  [rsp+0x178]  class-hnd exact spill-single-def <System.String>
+;  V21 loc15        [V21,T89] (  2,  8   )     ref  ->  [rsp+0x180]  class-hnd exact spill-single-def <System.String>
+;  V22 loc16        [V22,T60] (  5, 12   )     ref  ->  [rsp+0x178]  class-hnd exact spill-single-def <System.String>
 ;* V23 loc17        [V23    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[System.Reflection.Metadata.ExportedTypeHandle]>
 ;* V24 loc18        [V24    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1[System.Reflection.Metadata.ExportedTypeHandle]>
 ;* V25 loc19        [V25    ] (  0,  0   )  struct ( 8) zero-ref    <System.Reflection.Metadata.ExportedTypeHandle>
@@ -40,7 +40,7 @@
 ;* V29 loc23        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[System.Reflection.Metadata.NamespaceDefinitionHandle]>
 ;* V30 loc24        [V30    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1[System.Reflection.Metadata.NamespaceDefinitionHandle]>
 ;* V31 loc25        [V31    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Reflection.Metadata.NamespaceDefinitionHandle>
-;  V32 loc26        [V32,T43] (  4, 16   )     ref  ->  [rsp+0x170]  class-hnd exact spill-single-def <System.String>
+;  V32 loc26        [V32,T40] (  4, 16   )     ref  ->  [rsp+0x170]  class-hnd exact spill-single-def <System.String>
 ;* V33 loc27        [V33    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Reflection.Metadata.NamespaceDefinition>
 ;  V34 loc28        [V34,T05] (  9, 32   )     ref  ->  [rsp+0x168]  class-hnd exact spill-single-def <System.String>
 ;  V35 OutArgs      [V35    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -50,7 +50,7 @@
 ;* V39 tmp4         [V39    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.StringHandle>
 ;* V40 tmp5         [V40    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.StringHandle>
 ;* V41 tmp6         [V41    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.StringHandle>
-;  V42 tmp7         [V42,T158] (  4,  4   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V42 tmp7         [V42,T158] (  4,  4   )     ref  ->  rbp         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V43 tmp8         [V43    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.StringHandle>
 ;* V44 tmp9         [V44    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.StringHandle>
 ;* V45 tmp10        [V45    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.StringHandle>
@@ -73,28 +73,28 @@
 ;* V62 tmp27        [V62    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;  V63 tmp28        [V63,T123] (  3,  6   )     ref  ->  [rsp+0x158]  class-hnd exact spill-single-def "NewObj constructor temp" <<unknown class>>
 ;  V64 tmp29        [V64,T124] (  3,  6   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
-;  V65 tmp30        [V65    ] (  2,  4   )  ushort  ->  [rsp+0x278]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
+;  V65 tmp30        [V65    ] (  2,  4   )  ushort  ->  [rsp+0x288]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
 ;* V66 tmp31        [V66    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V67 tmp32        [V67    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <System.String>
 ;* V68 tmp33        [V68    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String[]>
-;  V69 tmp34        [V69    ] (  2,  2   )   ubyte  ->  [rsp+0x270]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V69 tmp34        [V69    ] (  2,  2   )   ubyte  ->  [rsp+0x280]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;  V70 tmp35        [V70,T209] (  5,  3   )     ref  ->  [rsp+0x150]  class-hnd spill-single-def "Inline stloc first use temp" <System.String>
 ;  V71 tmp36        [V71,T160] (  3,  4   )   byref  ->  [rsp+0x148]  spill-single-def "impAppendStmt"
 ;  V72 tmp37        [V72,T207] (  7,  3   )     ref  ->  [rsp+0x140]  class-hnd "Inline return value spill temp" <System.String>
 ;* V73 tmp38        [V73    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
 ;  V74 tmp39        [V74,T156] (  4,  5   )     ref  ->  [rsp+0x138]  class-hnd spill-single-def "Inlining Arg" <System.Reflection.Metadata.MetadataStringDecoder>
-;  V75 tmp40        [V75    ] (  3,  3   )  struct ( 8) [rsp+0x268]  do-not-enreg[XS] addr-exposed ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
+;  V75 tmp40        [V75    ] (  3,  3   )  struct ( 8) [rsp+0x278]  do-not-enreg[XS] addr-exposed ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
 ;  V76 tmp41        [V76,T249] (  2,  1   )     int  ->  rcx        
 ;  V77 tmp42        [V77,T241] (  3,  1.50)  ushort  ->  rax         single-def "Inline stloc first use temp"
 ;  V78 tmp43        [V78,T159] (  4,  4   )   byref  ->  [rsp+0x130]  spill-single-def "impAppendStmt"
 ;* V79 tmp44        [V79    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inline ldloca(s) first use temp"
-;  V80 tmp45        [V80,T155] (  5,  5   )     int  ->  [rsp+0x264]  spill-single-def "Inlining Arg"
+;  V80 tmp45        [V80,T155] (  5,  5   )     int  ->  [rsp+0x274]  spill-single-def "Inlining Arg"
 ;* V81 tmp46        [V81    ] (  0,  0   )     int  ->  zero-ref    single-def "Inline stloc first use temp"
 ;* V82 tmp47        [V82    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V83 tmp48        [V83,T239] (  3,  1.50)     int  ->   r8        
 ;  V84 tmp49        [V84,T208] (  6,  3   )     int  ->   r8         "Inline stloc first use temp"
 ;* V85 tmp50        [V85    ] (  0,  0   )     int  ->  zero-ref    "dup spill"
-;  V86 tmp51        [V86,T151] (  5,  5.00)     int  ->  [rsp+0x260]  spill-single-def "Inlining Arg"
+;  V86 tmp51        [V86,T151] (  5,  5.00)     int  ->  [rsp+0x270]  spill-single-def "Inlining Arg"
 ;  V87 tmp52        [V87,T233] (  2,  2.00)    long  ->  rcx         "Inlining Arg"
 ;* V88 tmp53        [V88    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V89 tmp54        [V89    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
@@ -125,21 +125,21 @@
 ;* V114 tmp79       [V114    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V115 tmp80       [V115    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V116 tmp81       [V116    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V117 tmp82       [V117,T236] (  2,  2   )     int  ->  [rsp+0x25C]  spill-single-def "Inlining Arg"
+;  V117 tmp82       [V117,T236] (  2,  2   )     int  ->  [rsp+0x26C]  spill-single-def "Inlining Arg"
 ;  V118 tmp83       [V118,T221] (  2,  2   )   byref  ->  [rsp+0x128]  spill-single-def "Inlining Arg"
 ;* V119 tmp84       [V119    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V120 tmp85       [V120    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V121 tmp86       [V121    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V122 tmp87       [V122,T237] (  2,  2   )     int  ->  [rsp+0x258]  spill-single-def "Inlining Arg"
+;  V122 tmp87       [V122,T237] (  2,  2   )     int  ->  [rsp+0x268]  spill-single-def "Inlining Arg"
 ;  V123 tmp88       [V123,T222] (  2,  2   )   byref  ->  [rsp+0x120]  spill-single-def "Inlining Arg"
 ;  V124 tmp89       [V124,T213] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
-;  V125 tmp90       [V125    ] (  2,  2   )  ushort  ->  [rsp+0x254]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
+;  V125 tmp90       [V125    ] (  2,  2   )  ushort  ->  [rsp+0x264]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
 ;* V126 tmp91       [V126    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V127 tmp92       [V127    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[System.Reflection.Metadata.TypeDefinitionHandle]>
 ;* V128 tmp93       [V128    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[System.Reflection.Metadata.TypeDefinitionHandle]>
 ;* V129 tmp94       [V129    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Reflection.Metadata.TypeDefinitionHandle[]>
 ;* V130 tmp95       [V130    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.TypeDefinition>
-;  V131 tmp96       [V131,T19] (  9, 22   )     int  ->  [rsp+0x250]  "Inline return value spill temp"
+;  V131 tmp96       [V131,T19] (  9, 22   )     int  ->  [rsp+0x260]  "Inline return value spill temp"
 ;* V132 tmp97       [V132    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.TypeDefinitionHandle>
 ;* V133 tmp98       [V133    ] (  0,  0   )  struct ( 8) zero-ref    "Inline return value spill temp" <System.Reflection.Metadata.StringHandle>
 ;  V134 tmp99       [V134,T21] (  5, 20   )   byref  ->  rcx         "impAppendStmt"
@@ -147,7 +147,7 @@
 ;* V136 tmp101      [V136    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V137 tmp102      [V137    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.TypeDefinitionHandle>
 ;* V138 tmp103      [V138    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.TypeDefinitionHandle>
-;  V139 tmp104      [V139,T171] (  2,  4   )     int  ->  [rsp+0x24C]  spill-single-def "Inline stloc first use temp"
+;  V139 tmp104      [V139,T171] (  2,  4   )     int  ->  [rsp+0x25C]  spill-single-def "Inline stloc first use temp"
 ;  V140 tmp105      [V140,T132] (  3,  6   )     int  ->  rcx         "Inline return value spill temp"
 ;* V141 tmp106      [V141    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;  V142 tmp107      [V142,T22] (  5, 20   )   byref  ->   r9         "Inlining Arg"
@@ -158,20 +158,20 @@
 ;* V147 tmp112      [V147    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V148 tmp113      [V148    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V149 tmp114      [V149    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.StringHandle>
-;  V150 tmp115      [V150,T23] (  5, 20   )   byref  ->   r9         "impAppendStmt"
+;  V150 tmp115      [V150,T23] (  5, 20   )   byref  ->  rcx         "impAppendStmt"
 ;* V151 tmp116      [V151    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.TypeDefinitionHandle>
 ;* V152 tmp117      [V152    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Reflection.Metadata.StringHandle>
-;  V153 tmp118      [V153,T134] (  3,  6   )   ubyte  ->  rbp         "Inline stloc first use temp"
+;  V153 tmp118      [V153,T134] (  3,  6   )   ubyte  ->   r9         "Inline stloc first use temp"
 ;* V154 tmp119      [V154    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Reflection.Metadata.StringHandle>
 ;* V155 tmp120      [V155    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V156 tmp121      [V156    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.TypeDefinitionHandle>
 ;* V157 tmp122      [V157    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.TypeDefinitionHandle>
-;  V158 tmp123      [V158,T172] (  2,  4   )     int  ->  rcx         "Inline stloc first use temp"
-;  V159 tmp124      [V159,T73] (  5, 10   )     int  ->   r9         "Inline return value spill temp"
+;  V158 tmp123      [V158,T172] (  2,  4   )     int  ->   r9         "Inline stloc first use temp"
+;  V159 tmp124      [V159,T70] (  5, 10   )     int  ->  r10         "Inline return value spill temp"
 ;* V160 tmp125      [V160    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;  V161 tmp126      [V161,T24] (  5, 20   )   byref  ->  r12         "Inlining Arg"
-;  V162 tmp127      [V162,T30] (  5, 20   )     int  ->  rcx         "Inlining Arg"
-;  V163 tmp128      [V163,T135] (  3,  6   )     int  ->   r9         "Inline stloc first use temp"
+;  V162 tmp127      [V162,T30] (  5, 20   )     int  ->   r9         "Inlining Arg"
+;  V163 tmp128      [V163,T135] (  3,  6   )     int  ->  r10         "Inline stloc first use temp"
 ;* V164 tmp129      [V164    ] (  0,  0   )  ushort  ->  zero-ref    "Inline return value spill temp"
 ;* V165 tmp130      [V165    ] (  0,  0   )  ushort  ->  zero-ref    "Inline stloc first use temp"
 ;* V166 tmp131      [V166    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
@@ -181,22 +181,22 @@
 ;* V170 tmp135      [V170    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V171 tmp136      [V171    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.StringHandle>
 ;* V172 tmp137      [V172    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V173 tmp138      [V173,T51] (  3, 16   )   byref  ->  r12         "impAppendStmt"
-;  V174 tmp139      [V174,T82] (  3,  8   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.String>
+;  V173 tmp138      [V173,T48] (  3, 16   )   byref  ->  [rsp+0x118]  spill-single-def "impAppendStmt"
+;  V174 tmp139      [V174,T82] (  3,  8   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
 ;* V175 tmp140      [V175    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
-;  V176 tmp141      [V176,T35] (  4, 20   )     ref  ->  [rsp+0x118]  class-hnd spill-single-def "Inlining Arg" <System.Reflection.Metadata.MetadataStringDecoder>
-;  V177 tmp142      [V177    ] (  3, 12   )  struct ( 8) [rsp+0x240]  do-not-enreg[XS] addr-exposed ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
+;  V176 tmp141      [V176,T35] (  4, 20   )     ref  ->  [rsp+0x110]  class-hnd spill-single-def "Inlining Arg" <System.Reflection.Metadata.MetadataStringDecoder>
+;  V177 tmp142      [V177    ] (  3, 12   )  struct ( 8) [rsp+0x250]  do-not-enreg[XS] addr-exposed ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
 ;  V178 tmp143      [V178,T136] (  3,  6   )     int  ->  rcx        
 ;  V179 tmp144      [V179,T137] (  3,  6   )  ushort  ->  rax         "Inline stloc first use temp"
-;  V180 tmp145      [V180,T44] (  4, 16   )   byref  ->  r12         "impAppendStmt"
+;  V180 tmp145      [V180,T41] (  4, 16   )   byref  ->  [rsp+0x108]  spill-single-def "impAppendStmt"
 ;* V181 tmp146      [V181    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inline ldloca(s) first use temp"
-;  V182 tmp147      [V182,T31] (  5, 20   )     int  ->  [rsp+0x23C]  spill-single-def "Inlining Arg"
+;  V182 tmp147      [V182,T31] (  5, 20   )     int  ->  [rsp+0x24C]  spill-single-def "Inlining Arg"
 ;* V183 tmp148      [V183    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V184 tmp149      [V184    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V185 tmp150      [V185,T121] (  3,  6.00)     int  ->   r8        
-;  V186 tmp151      [V186,T74] (  5, 10   )     int  ->   r8         "Inline stloc first use temp"
+;  V186 tmp151      [V186,T71] (  5, 10   )     int  ->   r8         "Inline stloc first use temp"
 ;* V187 tmp152      [V187    ] (  0,  0   )     int  ->  zero-ref    "dup spill"
-;  V188 tmp153      [V188,T20] (  5, 20.00)     int  ->  [rsp+0x238]  spill-single-def "Inlining Arg"
+;  V188 tmp153      [V188,T20] (  5, 20.00)     int  ->  [rsp+0x248]  spill-single-def "Inlining Arg"
 ;  V189 tmp154      [V189,T96] (  2,  8.00)    long  ->  rcx         "Inlining Arg"
 ;* V190 tmp155      [V190    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V191 tmp156      [V191    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
@@ -211,7 +211,7 @@
 ;* V200 tmp165      [V200    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V201 tmp166      [V201    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V202 tmp167      [V202    ] (  0,  0   )   ubyte  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V203 tmp168      [V203,T97] (  2,  8   )   ubyte  ->   r9         ld-addr-op "Inlining Arg"
+;  V203 tmp168      [V203,T97] (  2,  8   )   ubyte  ->  rax         ld-addr-op "Inlining Arg"
 ;* V204 tmp169      [V204    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V205 tmp170      [V205    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V206 tmp171      [V206,T200] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -221,10 +221,10 @@
 ;* V210 tmp175      [V210    ] (  0,  0   )   ubyte  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V211 tmp176      [V211    ] (  0,  0   )   ubyte  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V212 tmp177      [V212    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
-;  V213 tmp178      [V213,T125] (  3,  6   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.String>
+;  V213 tmp178      [V213,T125] (  3,  6   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
 ;  V214 tmp179      [V214,T98] (  2,  8   )    long  ->  rdx         "Inlining Arg"
 ;* V215 tmp180      [V215    ] (  0,  0   )  struct ( 8) zero-ref    "Inline return value spill temp" <System.Reflection.Metadata.StringHandle>
-;  V216 tmp181      [V216,T25] (  5, 20   )   byref  ->  rax         "impAppendStmt"
+;  V216 tmp181      [V216,T25] (  5, 20   )   byref  ->  rdx         "impAppendStmt"
 ;* V217 tmp182      [V217    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Reflection.Metadata.TypeDefinitionHandle>
 ;* V218 tmp183      [V218    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V219 tmp184      [V219    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.TypeDefinitionHandle>
@@ -232,7 +232,7 @@
 ;  V221 tmp186      [V221,T173] (  2,  4   )     int  ->  rcx         "Inline stloc first use temp"
 ;  V222 tmp187      [V222,T138] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
 ;* V223 tmp188      [V223    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V224 tmp189      [V224,T26] (  5, 20   )   byref  ->  rdx         "Inlining Arg"
+;  V224 tmp189      [V224,T26] (  5, 20   )   byref  ->   r8         "Inlining Arg"
 ;  V225 tmp190      [V225,T32] (  5, 20   )     int  ->  rcx         "Inlining Arg"
 ;  V226 tmp191      [V226,T139] (  3,  6   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V227 tmp192      [V227    ] (  0,  0   )  ushort  ->  zero-ref    "Inline return value spill temp"
@@ -248,7 +248,7 @@
 ;  V237 tmp202      [V237,T174] (  2,  4   )     int  ->  rcx         "Inline stloc first use temp"
 ;  V238 tmp203      [V238,T140] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
 ;* V239 tmp204      [V239    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V240 tmp205      [V240,T28] (  5, 20   )   byref  ->  rax         "Inlining Arg"
+;  V240 tmp205      [V240,T28] (  5, 20   )   byref  ->   r8         "Inlining Arg"
 ;  V241 tmp206      [V241,T33] (  5, 20   )     int  ->  rcx         "Inlining Arg"
 ;  V242 tmp207      [V242,T141] (  3,  6   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V243 tmp208      [V243    ] (  0,  0   )  ushort  ->  zero-ref    "Inline return value spill temp"
@@ -256,16 +256,16 @@
 ;* V245 tmp210      [V245    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V246 tmp211      [V246    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V247 tmp212      [V247    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.StringHandle>
-;  V248 tmp213      [V248,T52] (  3, 16   )   byref  ->  [rsp+0x110]  spill-single-def "impAppendStmt"
+;  V248 tmp213      [V248,T49] (  3, 16   )   byref  ->  [rsp+0x100]  spill-single-def "impAppendStmt"
 ;  V249 tmp214      [V249,T79] (  4,  8   )     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.String>
 ;* V250 tmp215      [V250    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
-;  V251 tmp216      [V251,T36] (  4, 20   )     ref  ->  [rsp+0x108]  class-hnd spill-single-def "Inlining Arg" <System.Reflection.Metadata.MetadataStringDecoder>
-;  V252 tmp217      [V252    ] (  3, 12   )  struct ( 8) [rsp+0x230]  do-not-enreg[XS] addr-exposed ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
+;  V251 tmp216      [V251,T36] (  4, 20   )     ref  ->  [rsp+0xF8]  class-hnd spill-single-def "Inlining Arg" <System.Reflection.Metadata.MetadataStringDecoder>
+;  V252 tmp217      [V252    ] (  3, 12   )  struct ( 8) [rsp+0x240]  do-not-enreg[XS] addr-exposed ld-addr-op "Inlining Arg" <System.Reflection.Metadata.StringHandle>
 ;  V253 tmp218      [V253,T142] (  3,  6   )     int  ->   r8        
 ;  V254 tmp219      [V254,T175] (  2,  4   )  ushort  ->   r9         "Inline stloc first use temp"
-;  V255 tmp220      [V255,T45] (  4, 16   )   byref  ->  [rsp+0x100]  spill-single-def "impAppendStmt"
-;  V256 tmp221      [V256    ] (  1,  2   )     int  ->  [rsp+0x228]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
-;  V257 tmp222      [V257,T48] (  4, 16   )     int  ->  [rsp+0x224]  spill-single-def "Inlining Arg"
+;  V255 tmp220      [V255,T42] (  4, 16   )   byref  ->  [rsp+0xF0]  spill-single-def "impAppendStmt"
+;  V256 tmp221      [V256    ] (  1,  2   )     int  ->  [rsp+0x238]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V257 tmp222      [V257,T45] (  4, 16   )     int  ->  [rsp+0x234]  spill-single-def "Inlining Arg"
 ;  V258 tmp223      [V258,T143] (  3,  6   )     int  ->  rax         "Inline stloc first use temp"
 ;  V259 tmp224      [V259,T126] (  3,  6   )     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.String>
...

```


</div></details>

<details>
<summary><span style="color:red">+22</span> (<span style="color:red">+0.54%</span>) : 38879.dasm - Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests:FactoryDITest():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,37 +9,37 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests>
-;  V01 loc0         [V01,T28] (  5,  5   )     ref  ->  rbx         class-hnd exact single-def <Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests+<>c__DisplayClass0_0>
+;  V01 loc0         [V01,T27] (  5,  5   )     ref  ->  rbx         class-hnd exact single-def <Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests+<>c__DisplayClass0_0>
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <Microsoft.Extensions.DependencyInjection.ServiceCollection>
-;  V03 loc2         [V03,T08] ( 18, 15   )     ref  ->  [rbp-0x1B8]  class-hnd EH-live single-def <System.Diagnostics.Metrics.IMeterFactory>
+;  V03 loc2         [V03,T07] ( 18, 15   )     ref  ->  [rbp-0x1B0]  class-hnd EH-live spill-single-def <System.Diagnostics.Metrics.IMeterFactory>
 ;* V04 loc3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <System.Diagnostics.Metrics.MeterOptions>
-;  V05 loc4         [V05,T30] (  4,  4   )     ref  ->  r14         class-hnd single-def <System.Diagnostics.Metrics.Meter>
-;  V06 loc5         [V06,T40] (  3,  3   )     ref  ->  rsi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
-;  V07 loc6         [V07,T41] (  3,  3   )     ref  ->  rsi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
-;  V08 loc7         [V08,T26] (  5,  3.50)     ref  ->  rbx         class-hnd exact single-def <System.Object>
-;  V09 loc8         [V09,T73] (  2,  2   )  struct (144) [rbp-0xC8]  do-not-enreg[SF] must-init ld-addr-op <System.Diagnostics.TagList>
+;  V05 loc4         [V05,T29] (  4,  4   )     ref  ->  r14         class-hnd single-def <System.Diagnostics.Metrics.Meter>
+;  V06 loc5         [V06,T39] (  3,  3   )     ref  ->  rsi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
+;  V07 loc6         [V07,T40] (  3,  3   )     ref  ->  rsi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
+;  V08 loc7         [V08,T25] (  5,  3.50)     ref  ->  rbx         class-hnd exact single-def <System.Object>
+;  V09 loc8         [V09,T72] (  2,  2   )  struct (144) [rbp-0xC0]  do-not-enreg[SF] must-init ld-addr-op <System.Diagnostics.TagList>
 ;* V10 loc9         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
 ;* V11 loc10        [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
-;  V12 loc11        [V12,T18] (  6,  6   )     ref  ->  rbx         class-hnd single-def <System.Diagnostics.Metrics.Meter>
-;  V13 loc12        [V13,T69] (  2,  2   )     ref  ->  rsi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
-;  V14 loc13        [V14,T70] (  2,  2   )     ref  ->  rdi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
+;  V12 loc11        [V12,T17] (  6,  6   )     ref  ->  rbx         class-hnd single-def <System.Diagnostics.Metrics.Meter>
+;  V13 loc12        [V13,T68] (  2,  2   )     ref  ->  rsi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
+;  V14 loc13        [V14,T69] (  2,  2   )     ref  ->  rdi         class-hnd single-def <System.Diagnostics.Metrics.Meter>
 ;  V15 loc14        [V15,T05] ( 10, 16   )     ref  ->  rsi         class-hnd <<unknown class>>
 ;* V16 loc15        [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Diagnostics.Metrics.Meter>
-;  V17 loc16        [V17    ] ( 19, 19   )  struct (144) [rbp-0x158]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Diagnostics.TagList>
-;  V18 loc17        [V18,T02] (  6, 21   )     int  ->  rbx        
+;  V17 loc16        [V17    ] ( 19, 19   )  struct (144) [rbp-0x150]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Diagnostics.TagList>
+;  V18 loc17        [V18,T04] (  5, 17   )     int  ->  rbx        
 ;  V19 OutArgs      [V19    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V20 tmp1         [V20    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests+<>c__DisplayClass0_0>
 ;  V21 tmp2         [V21,T13] (  5, 10   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <Microsoft.Extensions.DependencyInjection.ServiceCollection>
-;  V22 tmp3         [V22,T15] (  4,  8   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <System.Func`1[System.Object]>
-;  V23 tmp4         [V23,T03] ( 10, 20   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
-;  V24 tmp5         [V24,T19] (  3,  6   )     ref  ->  r14         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.TagList>
+;  V22 tmp3         [V22,T14] (  4,  8   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <System.Func`1[System.Object]>
+;  V23 tmp4         [V23,T02] ( 10, 20   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
+;  V24 tmp5         [V24,T18] (  3,  6   )     ref  ->  r14         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.TagList>
 ;* V25 tmp6         [V25    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.String>
 ;* V26 tmp7         [V26    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.String>
-;  V27 tmp8         [V27,T31] (  2,  4   )     ref  ->  r13         class-hnd exact single-def "impAppendStmt" <System.String>
-;  V28 tmp9         [V28,T32] (  2,  4   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <System.String>
-;  V29 tmp10        [V29,T20] (  3,  6   )     ref  ->  r12         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.TagList>
+;  V27 tmp8         [V27,T30] (  2,  4   )     ref  ->  r15         class-hnd exact single-def "impAppendStmt" <System.String>
+;  V28 tmp9         [V28,T31] (  2,  4   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <System.String>
+;  V29 tmp10        [V29,T19] (  3,  6   )     ref  ->  r13         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.TagList>
 ;* V30 tmp11        [V30    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <System.Object>
-;  V31 tmp12        [V31,T00] ( 50, 76.00)     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V31 tmp12        [V31,T00] ( 50, 76.00)     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V32 tmp13        [V32    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V33 tmp14        [V33    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V34 tmp15        [V34    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
@@ -48,7 +48,7 @@
 ;* V37 tmp18        [V37    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V38 tmp19        [V38    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V39 tmp20        [V39    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V40 tmp21        [V40,T04] ( 10, 20   )     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V40 tmp21        [V40,T03] ( 10, 20   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V41 tmp22        [V41    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V42 tmp23        [V42    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V43 tmp24        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
@@ -57,12 +57,12 @@
 ;* V46 tmp27        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V47 tmp28        [V47    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V48 tmp29        [V48    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V49 tmp30        [V49,T16] (  4,  8   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.TagList>
+;  V49 tmp30        [V49,T15] (  4,  8   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.TagList>
 ;* V50 tmp31        [V50    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V51 tmp32        [V51    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.String>
-;  V52 tmp33        [V52,T21] (  3,  6   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V52 tmp33        [V52,T20] (  3,  6   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V53 tmp34        [V53    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "non-inline candidate call" <<unknown class>>
-;  V54 tmp35        [V54,T22] (  3,  6   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.Extensions.DependencyInjection.ServiceProvider>
+;  V54 tmp35        [V54,T21] (  3,  6   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.Extensions.DependencyInjection.ServiceProvider>
 ;* V55 tmp36        [V55    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V56 tmp37        [V56    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V57 tmp38        [V57    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Diagnostics.TagList>
@@ -76,56 +76,56 @@
 ;* V65 tmp46        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V66 tmp47        [V66    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V67 tmp48        [V67    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V68 tmp49        [V68,T61] (  3,  2.49)     ref  ->  rsi         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V69 tmp50        [V69,T44] (  4,  2.98)     int  ->  rdx         single-def "Inline stloc first use temp"
+;  V68 tmp49        [V68,T60] (  3,  2.49)     ref  ->  rsi         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V69 tmp50        [V69,T43] (  4,  2.98)     int  ->  rdx         single-def "Inline stloc first use temp"
 ;* V70 tmp51        [V70    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V71 tmp52        [V71,T62] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V72 tmp53        [V72,T45] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
+;  V71 tmp52        [V71,T61] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V72 tmp53        [V72,T44] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
 ;* V73 tmp54        [V73    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V74 tmp55        [V74,T63] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V75 tmp56        [V75,T46] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
+;  V74 tmp55        [V74,T62] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V75 tmp56        [V75,T45] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
 ;* V76 tmp57        [V76    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V77 tmp58        [V77,T64] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V78 tmp59        [V78,T47] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
+;  V77 tmp58        [V77,T63] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V78 tmp59        [V78,T46] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
 ;* V79 tmp60        [V79    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V80 tmp61        [V80,T65] (  3,  2.49)     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V81 tmp62        [V81,T48] (  4,  2.98)     int  ->  rdx         single-def "Inline stloc first use temp"
+;  V80 tmp61        [V80,T64] (  3,  2.49)     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V81 tmp62        [V81,T47] (  4,  2.98)     int  ->  rdx         single-def "Inline stloc first use temp"
 ;* V82 tmp63        [V82    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V83 tmp64        [V83,T66] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V84 tmp65        [V84,T49] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
+;  V83 tmp64        [V83,T65] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V84 tmp65        [V84,T48] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
 ;* V85 tmp66        [V85    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V86 tmp67        [V86,T67] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V87 tmp68        [V87,T50] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
+;  V86 tmp67        [V86,T66] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V87 tmp68        [V87,T49] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
 ;* V88 tmp69        [V88    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V89 tmp70        [V89,T68] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V90 tmp71        [V90,T51] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
+;  V89 tmp70        [V89,T67] (  3,  2.49)     ref  ->  rdx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V90 tmp71        [V90,T50] (  4,  2.98)     int  ->  rcx         single-def "Inline stloc first use temp"
 ;* V91 tmp72        [V91    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
 ;* V92 tmp73        [V92    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V93 tmp74        [V93    ] (  1,  1   )     int  ->  [rbp-0x160]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V93 tmp74        [V93    ] (  1,  1   )     int  ->  [rbp-0x158]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V94 tmp75        [V94    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V95 tmp76        [V95    ] (  1,  1   )     int  ->  [rbp-0x168]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V95 tmp76        [V95    ] (  1,  1   )     int  ->  [rbp-0x160]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V96 tmp77        [V96    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V97 tmp78        [V97    ] (  1,  1   )     int  ->  [rbp-0x170]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V97 tmp78        [V97    ] (  1,  1   )     int  ->  [rbp-0x168]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V98 tmp79        [V98    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V99 tmp80        [V99    ] (  1,  1   )     int  ->  [rbp-0x178]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V99 tmp80        [V99    ] (  1,  1   )     int  ->  [rbp-0x170]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V100 tmp81       [V100    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V101 tmp82       [V101    ] (  1,  1   )     int  ->  [rbp-0x180]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V101 tmp82       [V101    ] (  1,  1   )     int  ->  [rbp-0x178]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V102 tmp83       [V102    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V103 tmp84       [V103    ] (  1,  1   )     int  ->  [rbp-0x188]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V103 tmp84       [V103    ] (  1,  1   )     int  ->  [rbp-0x180]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V104 tmp85       [V104    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V105 tmp86       [V105    ] (  1,  1   )     int  ->  [rbp-0x190]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V105 tmp86       [V105    ] (  1,  1   )     int  ->  [rbp-0x188]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V106 tmp87       [V106    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V107 tmp88       [V107    ] (  1,  1   )     int  ->  [rbp-0x198]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
-;  V108 tmp89       [V108,T09] (  6, 12   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
+;  V107 tmp88       [V107    ] (  1,  1   )     int  ->  [rbp-0x190]  do-not-enreg[X] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V108 tmp89       [V108,T08] (  6, 12   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
 ;* V109 tmp90       [V109    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V110 tmp91       [V110,T10] (  6, 12   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
+;  V110 tmp91       [V110,T09] (  6, 12   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
 ;* V111 tmp92       [V111    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V112 tmp93       [V112    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V113 tmp94       [V113,T37] (  2,  4   )     int  ->  rdi         "Inlining Arg"
-;  V114 tmp95       [V114,T23] (  3,  6   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <Xunit.Sdk.AssertEqualityComparer`1[int]>
+;  V113 tmp94       [V113,T36] (  2,  4   )     int  ->  rdi         "Inlining Arg"
+;  V114 tmp95       [V114,T22] (  3,  6   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <Xunit.Sdk.AssertEqualityComparer`1[int]>
 ;* V115 tmp96       [V115    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V116 tmp97       [V116    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon>
-;  V117 tmp98       [V117,T11] (  6, 12   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
+;  V117 tmp98       [V117,T10] (  6, 12   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Diagnostics.Metrics.MeterOptions>
 ;* V118 tmp99       [V118    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V119 tmp100      [V119    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V120 tmp101      [V120    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -155,7 +155,7 @@
 ;* V144 tmp125      [V144,T94] (  0,  0   )     ref  ->  zero-ref    single-def "field V43.key (fldOffset=0x0)" P-INDEP
 ;* V145 tmp126      [V145,T95] (  0,  0   )     ref  ->  zero-ref    single-def "field V43.value (fldOffset=0x8)" P-INDEP
 ;* V146 tmp127      [V146,T96] (  0,  0   )     ref  ->  zero-ref    single-def "field V44.key (fldOffset=0x0)" P-INDEP
-;  V147 tmp128      [V147,T71] (  2,  2   )     ref  ->  rbx         single-def "field V44.value (fldOffset=0x8)" P-INDEP
+;  V147 tmp128      [V147,T70] (  2,  2   )     ref  ->  rbx         single-def "field V44.value (fldOffset=0x8)" P-INDEP
 ;* V148 tmp129      [V148,T97] (  0,  0   )     ref  ->  zero-ref    single-def "field V45.key (fldOffset=0x0)" P-INDEP
 ;* V149 tmp130      [V149,T98] (  0,  0   )     ref  ->  zero-ref    single-def "field V45.value (fldOffset=0x8)" P-INDEP
 ;* V150 tmp131      [V150,T99] (  0,  0   )     ref  ->  zero-ref    single-def "field V46.key (fldOffset=0x0)" P-INDEP
@@ -164,7 +164,7 @@
 ;* V153 tmp134      [V153,T102] (  0,  0   )     ref  ->  zero-ref    single-def "field V47.value (fldOffset=0x8)" P-INDEP
 ;* V154 tmp135      [V154,T103] (  0,  0   )     ref  ->  zero-ref    single-def "field V48.key (fldOffset=0x0)" P-INDEP
 ;* V155 tmp136      [V155,T104] (  0,  0   )     ref  ->  zero-ref    single-def "field V48.value (fldOffset=0x8)" P-INDEP
-;  V156 tmp137      [V156,T72] (  2,  2   )     ref  ->  rdx         single-def "field V50.key (fldOffset=0x0)" P-INDEP
+;  V156 tmp137      [V156,T71] (  2,  2   )     ref  ->  rdx         single-def "field V50.key (fldOffset=0x0)" P-INDEP
 ;* V157 tmp138      [V157,T105] (  0,  0   )     ref  ->  zero-ref    single-def "field V50.value (fldOffset=0x8)" P-INDEP
 ;* V158 tmp139      [V158,T106] (  0,  0   )     ref  ->  zero-ref    single-def "field V55.key (fldOffset=0x0)" P-INDEP
 ;* V159 tmp140      [V159,T107] (  0,  0   )     ref  ->  zero-ref    single-def "field V55.value (fldOffset=0x8)" P-INDEP
@@ -222,68 +222,65 @@
 ;* V211 tmp192      [V211    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V104.value (fldOffset=0x8)" P-INDEP
 ;* V212 tmp193      [V212    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V106.key (fldOffset=0x0)" P-INDEP
 ;* V213 tmp194      [V213    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V106.value (fldOffset=0x8)" P-INDEP
-;* V214 tmp195      [V214,T39] (  0,  0   )   ubyte  ->  zero-ref    "field V122.hasValue (fldOffset=0x0)" P-INDEP
-;  V215 tmp196      [V215,T38] (  2,  4   )   ubyte  ->  r13         "field V122.value (fldOffset=0x1)" P-INDEP
+;* V214 tmp195      [V214,T38] (  0,  0   )   ubyte  ->  zero-ref    "field V122.hasValue (fldOffset=0x0)" P-INDEP
+;  V215 tmp196      [V215,T37] (  2,  4   )   ubyte  ->  r14         "field V122.value (fldOffset=0x1)" P-INDEP
 ;* V216 tmp197      [V216    ] (  0,  0   )   ubyte  ->  zero-ref    "field V123.hasValue (fldOffset=0x0)" P-INDEP
 ;* V217 tmp198      [V217    ] (  0,  0   )   ubyte  ->  zero-ref    "field V123.value (fldOffset=0x1)" P-INDEP
-;  V218 tmp199      [V218,T43] (  3,  3   )     int  ->  r14         single-def "V09.[008..012)"
-;  V219 tmp200      [V219,T33] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
-;  V220 tmp201      [V220,T34] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
-;  V221 tmp202      [V221,T29] (  3,  4.50)     ref  ->  rax         single-def "argument with side effect"
-;  V222 tmp203      [V222,T35] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
-;  V223 tmp204      [V223,T36] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
-;  V224 tmp205      [V224    ] ( 84,120.52)  struct (16) [rbp-0x1A8]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
-;  V225 tmp206      [V225,T52] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V226 tmp207      [V226,T53] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V227 tmp208      [V227,T54] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V228 tmp209      [V228,T55] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V229 tmp210      [V229,T56] (  3,  2.93)   byref  ->  rcx         single-def "BlockOp address local"
-;  V230 tmp211      [V230,T57] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V231 tmp212      [V231,T58] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V232 tmp213      [V232,T59] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
-;  V233 tmp214      [V233,T24] (  3,  6   )   byref  ->  rdi         single-def "BlockOp address local"
-;  V234 tmp215      [V234,T07] (  2, 16   )     ref  ->  rcx         "argument with side effect"
-;  V235 tmp216      [V235,T132] (  3,  0   )  struct ( 8) [rbp-0x1B0]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
+;  V218 tmp199      [V218,T42] (  3,  3   )     int  ->  r14         single-def "V09.[008..012)"
+;  V219 tmp200      [V219,T32] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
+;  V220 tmp201      [V220,T33] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
+;  V221 tmp202      [V221,T28] (  3,  4.50)     ref  ->  rax         single-def "argument with side effect"
+;  V222 tmp203      [V222,T34] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
+;  V223 tmp204      [V223,T35] (  2,  4   )     ref  ->  rdx         single-def "argument with side effect"
+;  V224 tmp205      [V224    ] ( 84,120.52)  struct (16) [rbp-0x1A0]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Collections.Generic.KeyValuePair`2[System.String,System.Object]>
+;  V225 tmp206      [V225,T51] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V226 tmp207      [V226,T52] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V227 tmp208      [V227,T53] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V228 tmp209      [V228,T54] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V229 tmp210      [V229,T55] (  3,  2.93)   byref  ->  rcx         single-def "BlockOp address local"
+;  V230 tmp211      [V230,T56] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V231 tmp212      [V231,T57] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V232 tmp213      [V232,T58] (  3,  2.93)   byref  ->  rdx         single-def "BlockOp address local"
+;  V233 tmp214      [V233,T23] (  3,  6   )   byref  ->  rdi         single-def "BlockOp address local"
+;  V234 tmp215      [V234,T06] (  2, 16   )     ref  ->  rcx         "argument with side effect"
+;  V235 tmp216      [V235,T132] (  3,  0   )  struct ( 8) [rbp-0x1A8]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
 ;* V236 tmp217      [V236    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
 ;* V237 tmp218      [V237    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
 ;* V238 tmp219      [V238    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
 ;  V239 PSPSym      [V239,T130] (  1,  1   )    long  ->  [rbp-0x1C0]  do-not-enreg[V] "PSPSym"
 ;* V240 cse0        [V240,T131] (  0,  0   )    long  ->  zero-ref    "CSE - conservative"
-;  V241 cse1        [V241,T25] (  3,  6   )     int  ->  r14         "CSE - moderate"
-;  V242 cse2        [V242,T42] (  3,  3   )     ref  ->  rsi         "CSE - conservative"
-;  V243 cse3        [V243,T14] (  4, 10   )     int  ->  rdi         "CSE - aggressive"
+;  V241 cse1        [V241,T24] (  3,  6   )     int  ->  rdi         "CSE - moderate"
+;  V242 cse2        [V242,T41] (  3,  3   )     ref  ->  rsi         "CSE - conservative"
+;  V243 cse3        [V243,T73] (  2,  2   )     int  ->  rdi         "CSE - aggressive"
 ;* V244 cse4        [V244,T12] (  0,  0   )     ref  ->  zero-ref    "CSE - aggressive"
-;  V245 cse5        [V245,T06] (  4, 16   )     int  ->  rbx         "CSE - aggressive"
-;* V246 cse6        [V246,T17] (  0,  0   )     ref  ->  zero-ref    "CSE - moderate"
-;  V247 rat0        [V247,T27] (  3,  5   )     ref  ->  rdx         "replacement local"
-;  V248 rat1        [V248,T60] (  3,  2.50)    long  ->  rcx         "CSE for expectedClsNode"
+;  V245 cse5        [V245,T11] (  3, 12   )     int  ->  rbx         "CSE - aggressive"
+;* V246 cse6        [V246,T16] (  0,  0   )     ref  ->  zero-ref    "CSE - moderate"
...

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+1.82%</span>) : 291437.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2804_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,14 +12,14 @@
 ;  V01 arg1         [V01,T35] (  4,  8   )   byref  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V03 loc1         [V03,T54] (  6,  5   )     int  ->  r14         single-def
-;  V04 loc2         [V04,T06] ( 28, 58.50)     int  ->  registers  
+;  V04 loc2         [V04,T06] ( 28, 58.50)     int  ->  [rsp+0x54] 
 ;* V05 loc3         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V06 loc4         [V06,T04] ( 18, 89   )     int  ->  r15        
-;  V07 loc5         [V07,T16] (  7, 27   )     int  ->  [rsp+0x54] 
+;  V07 loc5         [V07,T15] (  7, 27   )     int  ->  [rsp+0x50] 
 ;  V08 loc6         [V08,T22] (  4, 18   )     int  ->  rbp        
-;  V09 loc7         [V09,T09] ( 11, 36   )     int  ->  registers  
-;  V10 loc8         [V10,T50] (  5,  6   )     int  ->  [rsp+0x50] 
-;  V11 loc9         [V11,T70] (  5,  2.50)     int  ->  [rsp+0x4C] 
+;  V09 loc7         [V09,T09] ( 11, 36   )     int  ->  [rsp+0x4C] 
+;  V10 loc8         [V10,T50] (  5,  6   )     int  ->  r12        
+;  V11 loc9         [V11,T70] (  5,  2.50)     int  ->  [rsp+0x48] 
 ;  V12 loc10        [V12,T56] (  2,  4.50)     int  ->  r10        
 ;* V13 loc11        [V13    ] (  0,  0   )     int  ->  zero-ref   
 ;  V14 OutArgs      [V14    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -31,15 +31,15 @@
 ;* V20 tmp6         [V20    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V21 tmp7         [V21    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V22 tmp8         [V22    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V23 tmp9         [V23,T19] (  3, 24   )     int  ->  [rsp+0x48]  spill-single-def "Inlining Arg"
+;  V23 tmp9         [V23,T18] (  3, 24   )     int  ->  [rsp+0x44]  spill-single-def "Inlining Arg"
 ;  V24 tmp10        [V24,T26] (  2, 16   )   byref  ->  r13         "Inlining Arg"
 ;* V25 tmp11        [V25    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V26 tmp12        [V26    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V27 tmp13        [V27,T15] (  4, 28   )     int  ->  [rsp+0x44]  "Inlining Arg"
-;  V28 tmp14        [V28,T10] (  5, 36   )     int  ->  [rsp+0x40]  "Inlining Arg"
+;  V27 tmp13        [V27,T14] (  4, 28   )     int  ->  [rsp+0x40]  "Inlining Arg"
+;  V28 tmp14        [V28,T10] (  5, 36   )     int  ->  [rsp+0x3C]  "Inlining Arg"
 ;* V29 tmp15        [V29    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V30 tmp16        [V30,T25] (  4, 16   )     int  ->  r10         "Inline stloc first use temp"
-;  V31 tmp17        [V31,T17] (  3, 24   )     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
+;  V31 tmp17        [V31,T16] (  3, 24   )     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
 ;* V32 tmp18        [V32    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;  V33 tmp19        [V33,T34] (  3, 12   )     int  ->  rbp         "Inlining Arg"
 ;  V34 tmp20        [V34,T39] (  2,  8   )   byref  ->  r13         "Inlining Arg"
@@ -74,23 +74,23 @@
 ;* V63 tmp49        [V63    ] (  0,  0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V64 tmp50        [V64    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V65 tmp51        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V66 tmp52        [V66,T66] (  3,  3   )     int  ->  r12         "Inlining Arg"
+;  V66 tmp52        [V66,T66] (  3,  3   )     int  ->  rbp         "Inlining Arg"
 ;  V67 tmp53        [V67,T72] (  2,  2   )   byref  ->  r13         "Inlining Arg"
 ;* V68 tmp54        [V68    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V69 tmp55        [V69    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;  V70 tmp56        [V70,T52] (  3,  6   )     int  ->  rcx         "Inline stloc first use temp"
-;  V71 tmp57        [V71,T37] (  4,  8   )     int  ->  r11         "Inline stloc first use temp"
+;  V71 tmp57        [V71,T37] (  4,  8   )     int  ->   r8         "Inline stloc first use temp"
 ;  V72 tmp58        [V72,T27] (  3, 12   )     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
 ;* V73 tmp59        [V73    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.RegularExpressions.Match>
 ;  V74 tmp60        [V74,T28] (  3, 12   )   byref  ->  rcx         "dup spill"
 ;* V75 tmp61        [V75    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V76 tmp62        [V76,T67] (  3,  3   )     int  ->  [rsp+0x3C]  spill-single-def "Inlining Arg"
-;  V77 tmp63        [V77,T73] (  2,  2   )   byref  ->  r13         "Inlining Arg"
+;  V76 tmp62        [V76,T67] (  3,  3   )     int  ->  [rsp+0x38]  spill-single-def "Inlining Arg"
+;  V77 tmp63        [V77,T73] (  2,  2   )   byref  ->  [rsp+0x28]  spill-single-def "Inlining Arg"
 ;* V78 tmp64        [V78    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V79 tmp65        [V79    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V80 tmp66        [V80,T82] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;  V81 tmp67        [V81,T61] (  3,  3   )     ref  ->  r11         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Match>
-;  V82 tmp68        [V82,T76] (  3,  1.50)     ref  ->  [rsp+0x28]  class-hnd spill-single-def "Inline stloc first use temp" <<unknown class>>
+;  V82 tmp68        [V82,T76] (  3,  1.50)     ref  ->  [rsp+0x20]  class-hnd spill-single-def "Inline stloc first use temp" <<unknown class>>
 ;* V83 tmp69        [V83    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V84 tmp70        [V84    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V85 tmp71        [V85    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -110,8 +110,8 @@
 ;* V99 tmp85        [V99    ] (  0,  0   )     int  ->  zero-ref    "field V01._length (fldOffset=0x8)" P-INDEP
 ;  V100 tmp86       [V100,T36] (  5,  8.50)   byref  ->  rsi         single-def "field V02._reference (fldOffset=0x0)" P-INDEP
 ;  V101 tmp87       [V101,T23] ( 11, 17   )     int  ->  rdi         single-def "field V02._length (fldOffset=0x8)" P-INDEP
-;  V102 tmp88       [V102,T24] (  9, 17   )   byref  ->  r13         "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V103 tmp89       [V103,T14] ( 13, 28   )     int  ->  [rsp+0x38]  "field V05._length (fldOffset=0x8)" P-INDEP
+;  V102 tmp88       [V102,T24] (  9, 17   )   byref  ->  registers   "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V103 tmp89       [V103,T20] ( 11, 23.50)     int  ->  [rsp+0x34]  "field V05._length (fldOffset=0x8)" P-INDEP
 ;  V104 tmp90       [V104,T74] (  2,  2   )   byref  ->  r13         single-def "field V17._reference (fldOffset=0x0)" P-INDEP
 ;  V105 tmp91       [V105,T75] (  2,  2   )     int  ->  r12         single-def "field V17._length (fldOffset=0x8)" P-INDEP
 ;  V106 tmp92       [V106,T40] (  2,  8   )   byref  ->  r13         "field V22._reference (fldOffset=0x0)" P-INDEP
@@ -125,8 +125,8 @@
 ;* V114 tmp100      [V114    ] (  0,  0   )   byref  ->  zero-ref    "field V64._reference (fldOffset=0x0)" P-INDEP
 ;* V115 tmp101      [V115    ] (  0,  0   )     int  ->  zero-ref    "field V64._length (fldOffset=0x8)" P-INDEP
 ;  V116 tmp102      [V116,T78] (  2,  1   )   byref  ->  r13         "field V65._reference (fldOffset=0x0)" P-INDEP
-;  V117 tmp103      [V117,T80] (  2,  1   )     int  ->  r12         "field V65._length (fldOffset=0x8)" P-INDEP
-;  V118 tmp104      [V118,T79] (  2,  1   )   byref  ->  r13         "field V75._reference (fldOffset=0x0)" P-INDEP
+;  V117 tmp103      [V117,T80] (  2,  1   )     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
+;  V118 tmp104      [V118,T79] (  2,  1   )   byref  ->   r8         "field V75._reference (fldOffset=0x0)" P-INDEP
 ;  V119 tmp105      [V119,T81] (  2,  1   )     int  ->  r10         "field V75._length (fldOffset=0x8)" P-INDEP
 ;* V120 tmp106      [V120    ] (  0,  0   )   byref  ->  zero-ref    "field V83._reference (fldOffset=0x0)" P-INDEP
 ;* V121 tmp107      [V121    ] (  0,  0   )     int  ->  zero-ref    "field V83._length (fldOffset=0x8)" P-INDEP
@@ -135,20 +135,20 @@
 ;  V124 tmp110      [V124,T63] (  3,  3   )     ref  ->  r11         "arr expr"
 ;  V125 tmp111      [V125,T68] (  3,  3   )     int  ->  rcx         "index expr"
 ;  V126 tmp112      [V126,T64] (  3,  3   )     ref  ->  r11         "arr expr"
-;  V127 tmp113      [V127,T41] (  2,  8   )     ref  ->  r11         "arr expr"
+;  V127 tmp113      [V127,T41] (  2,  8   )     ref  ->   r8         "arr expr"
 ;  V128 tmp114      [V128,T31] (  3, 12   )     ref  ->  rdx         "arr expr"
 ;  V129 tmp115      [V129,T32] (  3, 12   )     ref  ->  rcx         "arr expr"
 ;  V130 tmp116      [V130,T33] (  3, 12   )     ref  ->   r8         "arr expr"
 ;  V131 tmp117      [V131,T03] (  3, 96   )     ref  ->  rcx         "arr expr"
 ;  V132 cse0        [V132,T77] (  3,  1.50)     int  ->  rcx         "CSE - conservative"
 ;  V133 cse1        [V133,T11] (  4, 36   )     ref  ->   r8         "CSE - aggressive"
-;  V134 cse2        [V134,T18] (  3, 24   )     ref  ->  rcx         "CSE - moderate"
+;  V134 cse2        [V134,T17] (  3, 24   )     ref  ->  rcx         "CSE - moderate"
 ;  V135 cse3        [V135,T48] (  4,  7   )     ref  ->  rdx         "CSE - conservative"
 ;  V136 cse4        [V136,T49] (  3,  6.25)     ref  ->  rax         hoist "CSE - conservative"
 ;  V137 cse5        [V137,T65] (  3,  3   )     ref  ->   r9         "CSE - conservative"
 ;  V138 cse6        [V138,T21] ( 18, 18   )     ref  ->  rdx         multi-def "CSE - moderate"
-;  V139 cse7        [V139,T20] (  3, 24   )     int  ->  r10         "CSE - moderate"
-;  V140 cse8        [V140,T69] (  3,  3   )     int  ->  [rsp+0x34]  spill-single-def "CSE - conservative"
+;  V139 cse7        [V139,T19] (  3, 24   )     int  ->  r10         "CSE - moderate"
+;  V140 cse8        [V140,T69] (  3,  3   )     int  ->  [rsp+0x30]  spill-single-def "CSE - conservative"
 ;
 ; Lcl frame size = 88
 
@@ -174,7 +174,7 @@ G_M34553_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0004 {rdx},
        mov      r14d, ebp
        xor      r15d, r15d
        cmp      r14d, edi
-       ja       G_M34553_IG39
+       ja       G_M34553_IG40
        mov      ecx, r14d
        lea      r13, bword ptr [rsi+2*rcx]
        ; byrRegs +[r13]
@@ -194,7 +194,7 @@ G_M34553_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi
 						;; size=19 bbWeight=0.50 PerfScore 1.75
 G_M34553_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref
        xor      eax, eax
-       mov      dword ptr [rsp+0x54], eax
+       mov      dword ptr [rsp+0x50], eax
 						;; size=6 bbWeight=1 PerfScore 1.25
 G_M34553_IG05:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref, isz
        mov      rdx, gword ptr [rbx+0x18]
@@ -229,40 +229,38 @@ G_M34553_IG07:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r1
        sub      r8d, dword ptr [rbx+0x58]
        mov      r10d, dword ptr [rdx+0x08]
        cmp      r15d, r10d
-       jae      G_M34553_IG38
+       jae      G_M34553_IG39
        mov      r9d, r15d
        mov      dword ptr [rdx+4*r9+0x10], r8d
        inc      r15d
        cmp      r15d, r10d
-       jae      G_M34553_IG38
+       jae      G_M34553_IG39
        mov      edx, r15d
        ; gcrRegs -[rdx]
        mov      dword ptr [rcx+4*rdx+0x10], ebp
        inc      r15d
-       mov      eax, dword ptr [rsp+0x54]
+       mov      eax, dword ptr [rsp+0x50]
        inc      eax
-       mov      dword ptr [rsp+0x54], eax
+       mov      dword ptr [rsp+0x50], eax
        test     r12d, r12d
        je       G_M34553_IG16
 						;; size=81 bbWeight=8 PerfScore 162.00
 G_M34553_IG08:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref, isz
        ; gcrRegs -[rcx]
-       test     r12d, r12d
-       je       G_M34553_IG38
        cmp      word  ptr [r13], 40
        jne      G_M34553_IG16
        lea      ecx, [rbp+0x01]
        mov      r12d, ecx
        cmp      r12d, edi
-       ja       G_M34553_IG39
+       ja       G_M34553_IG40
        mov      ecx, r12d
        lea      r13, bword ptr [rsi+2*rcx]
        mov      r8d, edi
        sub      r8d, r12d
-       mov      dword ptr [rsp+0x48], r8d
+       mov      dword ptr [rsp+0x44], r8d
        test     r8d, r8d
        jge      SHORT G_M34553_IG10
-						;; size=59 bbWeight=4 PerfScore 43.00
+						;; size=50 bbWeight=4 PerfScore 38.00
 G_M34553_IG09:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
@@ -273,33 +271,33 @@ G_M34553_IG09:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r1
        ; gcr arg pop 0
 						;; size=19 bbWeight=2 PerfScore 7.00
 G_M34553_IG10:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref, isz
-       mov      r8d, dword ptr [rsp+0x48]
-       mov      dword ptr [rsp+0x38], r8d
+       mov      r8d, dword ptr [rsp+0x44]
+       mov      dword ptr [rsp+0x34], r8d
        mov      r8d, ebp
        mov      r9d, r12d
        cmp      r9d, r8d
        jge      SHORT G_M34553_IG12
 						;; size=21 bbWeight=4 PerfScore 15.00
 G_M34553_IG11:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref
-       mov      dword ptr [rsp+0x44], ebp
-       mov      dword ptr [rsp+0x40], r12d
-       mov      r8d, dword ptr [rsp+0x40]
-       mov      r9d, dword ptr [rsp+0x44]
+       mov      dword ptr [rsp+0x40], ebp
+       mov      dword ptr [rsp+0x3C], r12d
+       mov      r8d, dword ptr [rsp+0x3C]
+       mov      r9d, dword ptr [rsp+0x40]
 						;; size=19 bbWeight=2 PerfScore 8.00
 G_M34553_IG12:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref, isz
        cmp      dword ptr [rbx+0x58], 0
        jne      SHORT G_M34553_IG14
 						;; size=6 bbWeight=4 PerfScore 16.00
 G_M34553_IG13:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref
-       mov      dword ptr [rsp+0x40], r8d
-       mov      dword ptr [rsp+0x44], r9d
+       mov      dword ptr [rsp+0x3C], r8d
+       mov      dword ptr [rsp+0x40], r9d
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        call     [System.Text.RegularExpressions.RegexRunner:DoubleCrawl():this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      r8d, dword ptr [rsp+0x40]
-       mov      r9d, dword ptr [rsp+0x44]
+       mov      r8d, dword ptr [rsp+0x3C]
+       mov      r9d, dword ptr [rsp+0x40]
 						;; size=29 bbWeight=2 PerfScore 14.50
 G_M34553_IG14:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref
        mov      rcx, gword ptr [rbx+0x20]
@@ -308,7 +306,7 @@ G_M34553_IG14:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r1
        dec      r10d
        mov      dword ptr [rbx+0x58], r10d
        cmp      r10d, dword ptr [rcx+0x08]
-       jae      G_M34553_IG38
+       jae      G_M34553_IG39
        mov      dword ptr [rcx+4*r10+0x10], 1
        sub      r9d, r8d
        mov      rcx, gword ptr [rbx+0x28]
@@ -317,11 +315,11 @@ G_M34553_IG14:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r1
        call     [<unknown method>]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      ebp, dword ptr [rsp+0x54]
+       mov      ebp, dword ptr [rsp+0x50]
        test     ebp, ebp
-       mov      dword ptr [rsp+0x54], ebp
+       mov      dword ptr [rsp+0x50], ebp
        mov      ebp, r12d
-       mov      r12d, dword ptr [rsp+0x38]
+       mov      r12d, dword ptr [rsp+0x34]
        jle      G_M34553_IG05
 						;; size=78 bbWeight=4 PerfScore 93.00
 G_M34553_IG15:        ; bbWeight=0.25, gcrefRegs=0008 {rbx}, byrefRegs=2040 {rsi r13}, byref
...

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-35</span> (<span style="color:green">-32.11%</span>) : 14967.dasm - SixLabors.ImageSharp.Formats.Gif.GifImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,14 +12,14 @@
 ;  V01 arg1         [V01,T00] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
-;  V04 tmp2         [V04,T02] (  7,  4   )   byref  ->  rax         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
-;  V05 tmp3         [V05,T01] (  8,  5   )     int  ->  rcx         single-def "field V01._length (fldOffset=0x8)" P-INDEP
+;  V04 tmp2         [V04,T01] (  7,  4   )   byref  ->  rax         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
+;  V05 tmp3         [V05,T02] (  2,  2   )     int  ->  rcx         single-def "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ubyte]>
-;  V07 cse0         [V07,T03] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
+;  V07 cse0         [V07,T03] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
-G_M210_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M210_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M210_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
@@ -32,38 +32,26 @@ G_M210_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M210_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
        ; byrRegs -[rdx]
-       test     ecx, ecx
-       je       SHORT G_M210_IG08
        cmp      byte  ptr [rax], 71
        jne      SHORT G_M210_IG06
-       cmp      ecx, 1
-       jbe      SHORT G_M210_IG08
        cmp      byte  ptr [rax+0x01], 73
        jne      SHORT G_M210_IG06
-       cmp      ecx, 2
-       jbe      SHORT G_M210_IG08
        cmp      byte  ptr [rax+0x02], 70
        jne      SHORT G_M210_IG06
-       cmp      ecx, 3
-       jbe      SHORT G_M210_IG08
        cmp      byte  ptr [rax+0x03], 56
        jne      SHORT G_M210_IG06
-       cmp      ecx, 4
-       jbe      SHORT G_M210_IG08
-       movzx    rdx, byte  ptr [rax+0x04]
-       cmp      edx, 57
+       movzx    rcx, byte  ptr [rax+0x04]
+       cmp      ecx, 57
        je       SHORT G_M210_IG04
-       cmp      edx, 55
+       cmp      ecx, 55
        jne      SHORT G_M210_IG06
-						;; size=61 bbWeight=0.50 PerfScore 13.38
-G_M210_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       cmp      ecx, 5
-       jbe      SHORT G_M210_IG08
+						;; size=37 bbWeight=0.50 PerfScore 10.25
+G_M210_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref
        cmp      byte  ptr [rax+0x05], 97
        sete     al
        ; byrRegs -[rax]
        movzx    rax, al
-						;; size=15 bbWeight=0.50 PerfScore 2.75
+						;; size=10 bbWeight=0.50 PerfScore 2.12
 G_M210_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -75,13 +63,8 @@ G_M210_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M210_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 109, prolog size 4, PerfScore 23.00, instruction count 40, allocated bytes for code 109 (MethodHash=76abff2d) for method SixLabors.ImageSharp.Formats.Gif.GifImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
+; Total bytes of code 74, prolog size 4, PerfScore 19.25, instruction count 26, allocated bytes for code 74 (MethodHash=76abff2d) for method SixLabors.ImageSharp.Formats.Gif.GifImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-31.03%</span>) : 26050.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,23 +8,23 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  5,  8   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  5,  8   )   byref  ->  rcx         this single-def
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T04] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
+;  V04 tmp1         [V04,T03] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
 ;* V05 tmp2         [V05    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]>
 ;* V08 tmp5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon[]>
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis>
-;  V10 tmp7         [V10,T01] (  4, 13   )     int  ->  rdx         "Inline stloc first use temp"
+;  V10 tmp7         [V10,T02] (  2,  8   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->   r8         "field V01._index (fldOffset=0x8)" P-INDEP
+;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T05] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
 ;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T03] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse0         [V16,T04] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -38,23 +38,19 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        xor      edx, edx
-       xor      r8d, r8d
        test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=16 bbWeight=1 PerfScore 5.75
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M56839_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       cmp      edx, eax
-       jae      SHORT G_M56839_IG06
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
-       lea      edx, [r8+0x01]
-       ; gcrRegs -[rdx]
-       mov      r8d, edx
-       cmp      eax, r8d
+       mov      r8, gword ptr [rcx]
+       ; gcrRegs +[r8]
+       cmp      byte  ptr [r8], r8b
+       inc      edx
+       cmp      eax, edx
        jg       SHORT G_M56839_IG03
-						;; size=21 bbWeight=4 PerfScore 33.00
+						;; size=12 bbWeight=4 PerfScore 26.00
 G_M56839_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       ; gcrRegs -[r8]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
        dec      dword ptr [rax+0x0C]
@@ -63,15 +59,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M56839_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       ; byrRegs -[rcx]
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 45.25, instruction count 21, allocated bytes for code 58 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
+; Total bytes of code 40, prolog size 4, PerfScore 38.00, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-27.78%</span>) : 387.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,14 +9,14 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  4   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
+;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
-G_M54145_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M54145_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
@@ -29,30 +29,22 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        jl       SHORT G_M54145_IG06
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M54145_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M54145_IG08
        cmp      word  ptr [rax], 92
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG08
-       movzx    rdx, word  ptr [rax+0x02]
-       cmp      edx, 92
+       movzx    rcx, word  ptr [rax+0x02]
+       cmp      ecx, 92
        je       SHORT G_M54145_IG04
-       cmp      edx, 63
+       cmp      ecx, 63
        jne      SHORT G_M54145_IG06
-						;; size=29 bbWeight=0.50 PerfScore 5.50
+						;; size=20 bbWeight=0.50 PerfScore 4.25
 G_M54145_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x04], 63
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x06], 92
        sete     al
        ; byrRegs -[rax]
        movzx    rax, al
-						;; size=28 bbWeight=0.50 PerfScore 5.38
+						;; size=18 bbWeight=0.50 PerfScore 4.12
 G_M54145_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -64,13 +56,8 @@ G_M54145_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M54145_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 90, prolog size 4, PerfScore 17.75, instruction count 32, allocated bytes for code 90 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
+; Total bytes of code 65, prolog size 4, PerfScore 15.25, instruction count 22, allocated bytes for code 65 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-8</span> (<span style="color:green">-0.08%</span>) : 22032.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol+AliasesAndUsings:<GetUsingsAndDiagnostics>g__buildUsings|16_0(Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax],Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,System.Nullable`1[ubyte],Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol+AliasesAndUsings+UsingsAndDiagnostics:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -21,7 +21,7 @@
 ;  V10 loc4         [V10,T05] ( 22, 39   )     ref  ->  rdi         class-hnd <Microsoft.CodeAnalysis.DiagnosticBag>
 ;  V11 loc5         [V11,T62] (  7, 13   )     ref  ->  [rsp+0x380]  class-hnd exact spill-single-def <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
 ;  V12 loc6         [V12,T44] ( 11, 18.50)     ref  ->  [rsp+0x378]  ld-addr-op class-hnd <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
-;  V13 loc7         [V13,T13] ( 17, 30.50)     ref  ->  [rsp+0x370]  class-hnd <<unknown class>>
+;  V13 loc7         [V13,T12] ( 17, 30.50)     ref  ->  [rsp+0x370]  class-hnd <<unknown class>>
 ;  V14 loc8         [V14,T123] (  7, 10.50)     ref  ->  [rsp+0x368]  class-hnd <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
 ;  V15 loc9         [V15,T122] (  6, 11   )     ref  ->  [rsp+0x360]  class-hnd <Microsoft.CodeAnalysis.CSharp.Binder>
 ;  V16 loc10        [V16    ] (  5,  9.50)     ref  ->  [rsp+0x608]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <Microsoft.CodeAnalysis.PooledObjects.PooledHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]>
@@ -39,7 +39,7 @@
 ;* V28 loc22        [V28    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Collections.Immutable.ImmutableArray`1+Enumerator[Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective]>
 ;  V29 loc23        [V29,T218] (  3,  6   )     int  ->  r13        
 ;  V30 loc24        [V30,T125] (  5, 10   )     ref  ->  [rsp+0x340]  class-hnd exact spill-single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
-;  V31 loc25        [V31,T07] ( 17, 34   )     ref  ->  [rsp+0x338]  class-hnd spill-single-def <Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
+;  V31 loc25        [V31,T06] ( 17, 34   )     ref  ->  [rsp+0x338]  class-hnd spill-single-def <Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
 ;* V32 loc26        [V32,T287] (  0,  0   )   ubyte  ->  zero-ref   
 ;* V33 loc27        [V33    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.CodeAnalysis.Location>
 ;  V34 loc28        [V34    ] (  4,  8   )  struct (40) [rsp+0x590]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.Binder+NamespaceOrTypeOrAliasSymbolWithAnnotations>
@@ -49,8 +49,8 @@
 ;  V38 OutArgs      [V38    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V39 tmp1         [V39    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V40 tmp2         [V40    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.DiagnosticBag>
-;  V41 tmp3         [V41,T37] (  5, 20   )  struct (24) [rsp+0x578]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
-;  V42 tmp4         [V42,T30] (  5, 20   )     ref  ->  [rsp+0x328]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
+;  V41 tmp3         [V41,T36] (  5, 20   )  struct (24) [rsp+0x578]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V42 tmp4         [V42,T29] (  5, 20   )     ref  ->  [rsp+0x328]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V43 tmp5         [V43,T153] (  2,  8   )     ref  ->  [rsp+0x320]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
 ;  V44 tmp6         [V44,T154] (  2,  8   )     ref  ->  rax         class-hnd "Strict ordering of exceptions for Array store" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
 ;  V45 tmp7         [V45,T69] (  3, 12   )     ref  ->  [rsp+0x318]  class-hnd exact spill-single-def "Single-def Box Helper" <Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument>
@@ -58,8 +58,8 @@
 ;  V47 tmp9         [V47,T71] (  3, 12   )     ref  ->  [rsp+0x310]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V48 tmp10        [V48,T155] (  2,  8   )     ref  ->  [rsp+0x308]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
 ;  V49 tmp11        [V49,T72] (  3, 12   )     ref  ->  [rsp+0x300]  class-hnd exact spill-single-def "Single-def Box Helper" <Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument>
-;  V50 tmp12        [V50,T38] (  5, 20   )  struct (24) [rsp+0x560]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
-;  V51 tmp13        [V51,T39] (  5, 20   )  struct (24) [rsp+0x548]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V50 tmp12        [V50,T37] (  5, 20   )  struct (24) [rsp+0x560]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V51 tmp13        [V51,T38] (  5, 20   )  struct (24) [rsp+0x548]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V52 tmp14        [V52,T156] (  2,  8   )     ref  ->  [rsp+0x2F8]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V53 tmp15        [V53    ] (  7, 28   )  struct (24) [rsp+0x530]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
 ;* V54 tmp16        [V54    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
@@ -73,7 +73,7 @@
 ;  V62 tmp24        [V62,T158] (  2,  8   )     ref  ->  [rsp+0x2D8]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
 ;  V63 tmp25        [V63,T75] (  3, 12   )     ref  ->  [rsp+0x2D0]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V64 tmp26        [V64,T159] (  2,  8   )     ref  ->  [rsp+0x2C8]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
-;  V65 tmp27        [V65,T40] (  5, 20   )  struct (24) [rsp+0x510]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V65 tmp27        [V65,T39] (  5, 20   )  struct (24) [rsp+0x510]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V66 tmp28        [V66,T160] (  2,  8   )     ref  ->  [rsp+0x2C0]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V67 tmp29        [V67    ] (  7, 28   )  struct (24) [rsp+0x4F8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
 ;* V68 tmp30        [V68    ] (  0,  0   )     ref  ->  zero-ref   
@@ -84,9 +84,9 @@
 ;* V73 tmp35        [V73    ] (  0,  0   )  struct ( 8) zero-ref    "impAppendStmt" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V74 tmp36        [V74,T77] (  3, 12   )     ref  ->  [rsp+0x2A8]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
 ;  V75 tmp37        [V75,T162] (  2,  8   )     ref  ->  [rsp+0x2A0]  class-hnd spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.Location>
-;  V76 tmp38        [V76,T31] (  5, 20   )     ref  ->  [rsp+0x298]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.BinderFactory>
-;  V77 tmp39        [V77,T41] (  5, 20   )  struct (24) [rsp+0x4D8]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
-;  V78 tmp40        [V78,T42] (  5, 20   )  struct (24) [rsp+0x4C0]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V76 tmp38        [V76,T30] (  5, 20   )     ref  ->  [rsp+0x298]  class-hnd exact spill-single-def "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.BinderFactory>
+;  V77 tmp39        [V77,T40] (  5, 20   )  struct (24) [rsp+0x4D8]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
+;  V78 tmp40        [V78,T41] (  5, 20   )  struct (24) [rsp+0x4C0]  do-not-enreg[HS] must-init hidden-struct-arg "impAppendStmt" <Microsoft.CodeAnalysis.SyntaxToken>
 ;  V79 tmp41        [V79,T221] (  3,  6   )     int  ->  rax        
 ;* V80 tmp42        [V80    ] (  0,  0   )  struct (24) zero-ref    "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
 ;  V81 tmp43        [V81,T78] (  3, 12   )     ref  ->  [rsp+0x290]  class-hnd exact spill-single-def "dup spill" <System.Object[]>
@@ -131,21 +131,21 @@
 ;* V120 tmp82       [V120    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "dup spill" <Microsoft.CodeAnalysis.GreenNode>
 ;* V121 tmp83       [V121    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V122 tmp84       [V122    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
-;  V123 tmp85       [V123,T32] (  5, 20   )   byref  ->  [rsp+0x270]  spill-single-def "Inlining Arg"
+;  V123 tmp85       [V123,T31] (  5, 20   )   byref  ->  [rsp+0x270]  spill-single-def "Inlining Arg"
 ;  V124 tmp86       [V124,T134] (  4,  8   )     ref  ->  [rsp+0x268]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V125 tmp87       [V125,T135] (  4,  8   )     ref  ->  [rsp+0x260]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V126 tmp88       [V126    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V127 tmp89       [V127,T165] (  2,  8   )     ref  ->  rdx         class-hnd exact "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V128 tmp90       [V128    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V129 tmp91       [V129    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
-;  V130 tmp92       [V130,T33] (  5, 20   )   byref  ->  [rsp+0x258]  spill-single-def "Inlining Arg"
+;  V130 tmp92       [V130,T32] (  5, 20   )   byref  ->  [rsp+0x258]  spill-single-def "Inlining Arg"
 ;  V131 tmp93       [V131,T66] (  6, 12   )     ref  ->  [rsp+0x250]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V132 tmp94       [V132,T136] (  4,  8   )     ref  ->  [rsp+0x248]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V133 tmp95       [V133    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V134 tmp96       [V134,T166] (  2,  8   )     ref  ->  rdx         class-hnd exact "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V135 tmp97       [V135    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;* V136 tmp98       [V136    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
-;  V137 tmp99       [V137,T34] (  5, 20   )   byref  ->  [rsp+0x240]  spill-single-def "Inlining Arg"
+;  V137 tmp99       [V137,T33] (  5, 20   )   byref  ->  [rsp+0x240]  spill-single-def "Inlining Arg"
 ;  V138 tmp100      [V138,T67] (  6, 12   )     ref  ->  [rsp+0x238]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
 ;  V139 tmp101      [V139,T137] (  4,  8   )     ref  ->  [rsp+0x230]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V140 tmp102      [V140    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax>
@@ -162,7 +162,7 @@
 ;* V151 tmp113      [V151    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V152 tmp114      [V152    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V153 tmp115      [V153,T81] (  3, 12   )     ref  ->  [rsp+0x228]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V154 tmp116      [V154,T19] (  6, 24   )     ref  ->  [rsp+0x220]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V154 tmp116      [V154,T18] (  6, 24   )     ref  ->  [rsp+0x220]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V155 tmp117      [V155    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V156 tmp118      [V156,T82] (  3, 12   )     ref  ->  [rsp+0x218]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V157 tmp119      [V157    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxToken>
@@ -175,7 +175,7 @@
 ;* V164 tmp126      [V164    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V165 tmp127      [V165    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V166 tmp128      [V166,T83] (  3, 12   )     ref  ->  r15         class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V167 tmp129      [V167,T20] (  6, 24   )     ref  ->  [rsp+0x210]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V167 tmp129      [V167,T19] (  6, 24   )     ref  ->  [rsp+0x210]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V168 tmp130      [V168    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V169 tmp131      [V169,T84] (  3, 12   )     ref  ->  [rsp+0x208]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V170 tmp132      [V170,T205] (  3,  6   )     ref  ->  rcx         class-hnd "Inline return value spill temp" <System.String>
@@ -202,7 +202,7 @@
 ;  V191 tmp153      [V191    ] (  1,  2   )  struct (16) [rsp+0x448]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
 ;* V192 tmp154      [V192    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableDictionary`2+Comparers[System.__Canon,Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
 ;* V193 tmp155      [V193    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
-;  V194 tmp156      [V194,T35] (  5, 20   )   byref  ->  [rsp+0x1F0]  spill-single-def "Inlining Arg"
+;  V194 tmp156      [V194,T34] (  5, 20   )   byref  ->  [rsp+0x1F0]  spill-single-def "Inlining Arg"
 ;  V195 tmp157      [V195,T140] (  4,  8   )     ref  ->  [rsp+0x1E8]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
 ;  V196 tmp158      [V196,T141] (  4,  8   )     ref  ->  [rsp+0x1E0]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V197 tmp159      [V197    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
@@ -211,7 +211,7 @@
 ;* V200 tmp162      [V200    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
 ;* V201 tmp163      [V201    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V202 tmp164      [V202,T86] (  3, 12   )     ref  ->  [rsp+0x1D8]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V203 tmp165      [V203,T21] (  6, 24   )     ref  ->  [rsp+0x1D0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V203 tmp165      [V203,T20] (  6, 24   )     ref  ->  [rsp+0x1D0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V204 tmp166      [V204    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V205 tmp167      [V205,T87] (  3, 12   )     ref  ->  [rsp+0x1C8]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V206 tmp168      [V206    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective]>
@@ -219,14 +219,14 @@
 ;* V208 tmp170      [V208    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective[]>
 ;* V209 tmp171      [V209    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
 ;  V210 tmp172      [V210,T00] (  5,112   )     ref  ->  [rsp+0x1C0]  class-hnd exact spill-single-def "Inlining Arg" <System.String>
-;  V211 tmp173      [V211,T09] (  2, 16   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V212 tmp174      [V212,T11] (  2, 32   )   byref  ->  rcx         "impAppendStmt"
+;  V211 tmp173      [V211,T08] (  2, 16   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V212 tmp174      [V212,T10] (  2, 32   )   byref  ->  rcx         "impAppendStmt"
 ;* V213 tmp175      [V213    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V214 tmp176      [V214,T88] (  3, 12   )     ref  ->  [rsp+0x1B8]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V215 tmp177      [V215,T22] (  6, 24   )     ref  ->  [rsp+0x1B0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V215 tmp177      [V215,T21] (  6, 24   )     ref  ->  [rsp+0x1B0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V216 tmp178      [V216    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V217 tmp179      [V217,T89] (  3, 12   )     ref  ->  [rsp+0x1A8]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
-;  V218 tmp180      [V218,T03] (  5, 66   )     int  ->  rdx         "Inline stloc first use temp"
+;  V218 tmp180      [V218,T04] (  4, 50   )     int  ->  rdx         "Inline stloc first use temp"
 ;  V219 tmp181      [V219,T239] (  2,  4   )   byref  ->  [rsp+0x1A0]  spill-single-def
 ;* V220 tmp182      [V220    ] (  0,  0   )   byref  ->  zero-ref   
 ;  V221 tmp183      [V221,T240] (  2,  4   )     ref  ->  rax        
@@ -238,7 +238,7 @@
 ;  V227 tmp189      [V227,T187] (  2,  8   )     int  ->   r8         "Inlining Arg"
 ;* V228 tmp190      [V228    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V229 tmp191      [V229    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
-;  V230 tmp192      [V230,T15] (  7, 28   )     ref  ->  [rsp+0x198]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
+;  V230 tmp192      [V230,T14] (  7, 28   )     ref  ->  [rsp+0x198]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]>
 ;  V231 tmp193      [V231,T131] (  5, 10   )     int  ->  [rsp+0x444]  spill-single-def "Inline stloc first use temp"
 ;* V232 tmp194      [V232    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V233 tmp195      [V233,T227] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
@@ -254,7 +254,7 @@
 ;* V243 tmp205      [V243    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V244 tmp206      [V244    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective]]>
 ;* V245 tmp207      [V245    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
-;  V246 tmp208      [V246,T36] (  5, 20   )   byref  ->  [rsp+0x188]  spill-single-def "Inlining Arg"
+;  V246 tmp208      [V246,T35] (  5, 20   )   byref  ->  [rsp+0x188]  spill-single-def "Inlining Arg"
 ;  V247 tmp209      [V247,T142] (  4,  8   )     ref  ->  [rsp+0x180]  class-hnd "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
 ;  V248 tmp210      [V248,T143] (  4,  8   )     ref  ->  [rsp+0x178]  class-hnd spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.GreenNode>
 ;* V249 tmp211      [V249    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
@@ -288,7 +288,7 @@
 ;* V277 tmp239      [V277    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
 ;  V278 tmp240      [V278,T174] (  2,  8   )     ref  ->  rdx         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V279 tmp241      [V279,T144] (  4,  8   )     ref  ->  rdx        
-;  V280 tmp242      [V280,T23] (  6, 24   )     ref  ->  [rsp+0x170]  class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxNode>
+;  V280 tmp242      [V280,T22] (  6, 24   )     ref  ->  [rsp+0x170]  class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxNode>
 ;  V281 tmp243      [V281,T288] (  2,  4   )     int  ->  [rsp+0x424]  spill-single-def "Inline stloc first use temp"
 ;* V282 tmp244      [V282    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.Binder>
 ;  V283 tmp245      [V283,T54] (  7, 14   )     ref  ->  [rsp+0x168]  class-hnd exact spill-single-def "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.BinderFactory+BinderFactoryVisitor>
@@ -311,7 +311,7 @@
 ;* V300 tmp262      [V300    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V301 tmp263      [V301    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V302 tmp264      [V302,T92] (  3, 12   )     ref  ->  [rsp+0x158]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V303 tmp265      [V303,T24] (  6, 24   )     ref  ->  [rsp+0x150]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V303 tmp265      [V303,T23] (  6, 24   )     ref  ->  [rsp+0x150]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V304 tmp266      [V304    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V305 tmp267      [V305,T93] (  3, 12   )     ref  ->  [rsp+0x148]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V306 tmp268      [V306,T94] (  3, 12   )     ref  ->  rax         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.PooledHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]>
@@ -333,7 +333,7 @@
 ;  V322 tmp284      [V322,T179] (  2,  8   )     ref  ->  rcx         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V323 tmp285      [V323,T129] (  5, 10   )     ref  ->  rcx        
 ;* V324 tmp286      [V324    ] (  0,  0   )  struct (24) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
-;  V325 tmp287      [V325,T16] (  7, 28   )     ref  ->  [rsp+0x138]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
+;  V325 tmp287      [V325,T15] (  7, 28   )     ref  ->  [rsp+0x138]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V326 tmp288      [V326,T132] (  5, 10   )     int  ->  [rsp+0x414]  spill-single-def "Inline stloc first use temp"
 ;* V327 tmp289      [V327    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V328 tmp290      [V328,T228] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
@@ -348,7 +348,7 @@
 ;* V337 tmp299      [V337    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V338 tmp300      [V338    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V339 tmp301      [V339,T97] (  3, 12   )     ref  ->  [rsp+0x130]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V340 tmp302      [V340,T25] (  6, 24   )     ref  ->  [rsp+0x128]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V340 tmp302      [V340,T24] (  6, 24   )     ref  ->  [rsp+0x128]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V341 tmp303      [V341    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V342 tmp304      [V342,T98] (  3, 12   )     ref  ->  [rsp+0x120]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V343 tmp305      [V343    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxToken>
@@ -361,7 +361,7 @@
 ;* V350 tmp312      [V350    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V351 tmp313      [V351    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V352 tmp314      [V352,T99] (  3, 12   )     ref  ->  [rsp+0x118]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V353 tmp315      [V353,T26] (  6, 24   )     ref  ->  [rsp+0x110]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V353 tmp315      [V353,T25] (  6, 24   )     ref  ->  [rsp+0x110]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V354 tmp316      [V354    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V355 tmp317      [V355,T100] (  3, 12   )     ref  ->  [rsp+0x108]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;  V356 tmp318      [V356,T101] (  3, 12   )     ref  ->  rax         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.PooledHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]>
@@ -382,7 +382,7 @@
 ;  V371 tmp333      [V371,T189] (  2,  8   )     int  ->   r8         "Inlining Arg"
 ;* V372 tmp334      [V372    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V373 tmp335      [V373    ] (  0,  0   )  struct ( 8) zero-ref    "Inline return value spill temp" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V374 tmp336      [V374,T08] (  8, 28   )     ref  ->  [rsp+0x100]  class-hnd spill-single-def "Inlining Arg" <<unknown class>>
+;  V374 tmp336      [V374,T07] (  8, 28   )     ref  ->  [rsp+0x100]  class-hnd spill-single-def "Inlining Arg" <<unknown class>>
 ;* V375 tmp337      [V375,T232] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V376 tmp338      [V376,T243] (  2,  4   )   byref  ->  [rsp+0xF8]  spill-single-def
 ;* V377 tmp339      [V377    ] (  0,  0   )   byref  ->  zero-ref   
@@ -390,19 +390,19 @@
 ;  V379 tmp341      [V379,T181] (  2,  8   )     ref  ->  rcx         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V380 tmp342      [V380,T130] (  5, 10   )     ref  ->  rcx        
 ;* V381 tmp343      [V381    ] (  0,  0   )  struct (24) zero-ref    "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
-;  V382 tmp344      [V382,T17] (  7, 28   )     ref  ->  [rsp+0xF0]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
+;  V382 tmp344      [V382,T16] (  7, 28   )     ref  ->  [rsp+0xF0]  class-hnd exact spill-single-def "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective]>
 ;  V383 tmp345      [V383,T133] (  5, 10   )     int  ->  [rsp+0x3EC]  spill-single-def "Inline stloc first use temp"
 ;* V384 tmp346      [V384    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;  V385 tmp347      [V385,T229] (  3,  6   )     int  ->  rdx         "Inline return value spill temp"
 ;  V386 tmp348      [V386,T117] (  3, 12   )     int  ->  rdx         "Inlining Arg"
 ;* V387 tmp349      [V387    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
 ;  V388 tmp350      [V388,T104] (  3, 12   )     ref  ->  [rsp+0xE8]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo>
-;  V389 tmp351      [V389,T27] (  6, 24   )     ref  ->  [rsp+0xE0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
+;  V389 tmp351      [V389,T26] (  6, 24   )     ref  ->  [rsp+0xE0]  class-hnd exact spill-single-def "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;* V390 tmp352      [V390    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
 ;  V391 tmp353      [V391,T105] (  3, 12   )     ref  ->  [rsp+0xD8]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueue`1[Microsoft.CodeAnalysis.Diagnostic]>
 ;* V392 tmp354      [V392    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument>
 ;* V393 tmp355      [V393,T190] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V394 tmp356      [V394,T43] (  3, 20   )     int  ->  [rsp+0x3E8]  spill-single-def "Inline stloc first use temp"
+;  V394 tmp356      [V394,T42] (  3, 20   )     int  ->  [rsp+0x3E8]  spill-single-def "Inline stloc first use temp"
 ;  V395 tmp357      [V395,T61] (  4, 14   )     int  ->  registers   "Inline return value spill temp"
 ;* V396 tmp358      [V396    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxNode>
 ;  V397 tmp359      [V397,T182] (  2,  8   )     ref  ->  r13         class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
@@ -410,13 +410,13 @@
 ;  V399 tmp361      [V399,T50] (  4, 16   )     ref  ->  rcx         class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
 ;  V400 tmp362      [V400,T149] (  4,  8   )     int  ->  r13         "Inline stloc first use temp"
 ;  V401 tmp363      [V401,T245] (  2,  2   )     ref  ->  r14         single-def "field V01._node (fldOffset=0x0)" P-INDEP
-;  V402 tmp364      [V402,T28] (  3, 19   )     ref  ->  r12         single-def "field V06.array (fldOffset=0x0)" P-INDEP
-;  V403 tmp365      [V403,T18] ( 15, 26   )     ref  ->  [rsp+0xD0]  "field V08.array (fldOffset=0x0)" P-INDEP
+;  V402 tmp364      [V402,T27] (  3, 19   )     ref  ->  r12         single-def "field V06.array (fldOffset=0x0)" P-INDEP
+;  V403 tmp365      [V403,T17] ( 15, 26   )     ref  ->  [rsp+0xD0]  "field V08.array (fldOffset=0x0)" P-INDEP
 ;  V404 tmp366      [V404,T202] (  5,  6   )     ref  ->  [rsp+0xC8]  "field V09.array (fldOffset=0x0)" P-INDEP
 ;* V405 tmp367      [V405    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V18.hasValue (fldOffset=0x0)" P-INDEP
 ;* V406 tmp368      [V406    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V18.value (fldOffset=0x1)" P-INDEP
 ;  V407 tmp369      [V407,T53] (  4, 15   )     int  ->  [rsp+0x3E4]  "field V20._index (fldOffset=0x0)" P-INDEP
-;  V408 tmp370      [V408,T29] (  8, 21   )     ref  ->  r14         single-def "field V20._list (fldOffset=0x8)" P-INDEP
...

```


</div></details>

<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-0.08%</span>) : 1075.dasm - BepuPhysics.CollisionDetection.CollisionTasks.TriangleConvexHullTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -100,7 +100,7 @@
 ;  V89 loc80        [V89    ] (  4,  3.50)  struct (96) [rbp+0x860]  do-not-enreg[XS] addr-exposed ld-addr-op <BepuUtilities.Vector3Wide>
 ;  V90 loc81        [V90,T230] (  2,  2.50)  simd32  ->  [rbp+0x830]  ld-addr-op spill-single-def <System.Numerics.Vector`1[float]>
 ;  V91 loc82        [V91,T27] (  6, 15   )     int  ->  r12        
-;  V92 loc83        [V92,T14] (  9, 22.50)    long  ->  [rbp+0x828]  spill-single-def
+;  V92 loc83        [V92,T13] (  9, 22.50)    long  ->  [rbp+0x828]  spill-single-def
 ;  V93 loc84        [V93,T267] (  2,  1   )  simd32  ->  mm0         <System.Numerics.Vector`1[int]>
 ;  V94 loc85        [V94    ] ( 14, 11   )  simd32  ->  [rbp+0x7F0]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Numerics.Vector`1[float]>
 ;  V95 loc86        [V95    ] (  2,  1   )  simd32  ->  [rbp+0x7D0]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Numerics.Vector`1[float]>
@@ -111,7 +111,7 @@
 ;  V100 loc91       [V100    ] (  2,  4   )     int  ->  [rbp+0x700]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V101 loc92       [V101,T71] (  3,  6   )     int  ->  rax        
 ;  V102 loc93       [V102    ] (  1,  2   )  simd12  ->  [rbp+0x6F0]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Numerics.Vector3>
-;  V103 loc94       [V103,T12] (  8, 24.50)     int  ->  [rbp+0x6EC] 
+;  V103 loc94       [V103,T11] (  8, 24.50)     int  ->  [rbp+0x6EC] 
 ;  V104 loc95       [V104,T18] (  3, 20   )   byref  ->  rdx        
 ;  V105 loc96       [V105    ] (  3,  6   )  simd12  ->  [rbp+0x6D0]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Numerics.Vector3>
 ;  V106 loc97       [V106,T104] (  7, 62   )  simd12  ->  [rbp+0x6C0]  ld-addr-op <System.Numerics.Vector3>
@@ -191,7 +191,7 @@
 ;* V180 tmp4        [V180    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
 ;* V181 tmp5        [V181    ] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
 ;* V182 tmp6        [V182    ] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
-;  V183 tmp7        [V183,T13] (  2, 16   )     int  ->  rdi        
+;  V183 tmp7        [V183,T12] (  2, 16   )     int  ->  rdi        
 ;  V184 tmp8        [V184,T05] (  3, 48   )     int  ->  r14         "impSpillLclRefs"
 ;  V185 tmp9        [V185,T136] (  3, 12   )  simd16  ->  mm16         "Cloning non-constant for Math.Max/Min"
 ;  V186 tmp10       [V186,T137] (  3, 12   )  simd16  ->  mm19         "Cloning non-constant for Math.Max/Min"
@@ -240,7 +240,7 @@
 ;* V229 tmp53       [V229    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Vector`1[float]>
 ;* V230 tmp54       [V230    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
 ;  V231 tmp55       [V231    ] (  4,  5   )  struct (96) [rbp+0x520]  do-not-enreg[XS] addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <BepuUtilities.Vector3Wide>
-;  V232 tmp56       [V232,T11] (  8, 25   )     int  ->  rcx         "Inline stloc first use temp"
+;  V232 tmp56       [V232,T15] (  7, 21   )     int  ->  rcx         "Inline stloc first use temp"
 ;* V233 tmp57       [V233    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
 ;* V234 tmp58       [V234    ] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
 ;* V235 tmp59       [V235    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -448,7 +448,7 @@
 ;  V437 tmp261      [V437    ] (  1,  2   )   float  ->  [rbp+0x6F4]  do-not-enreg[X] addr-exposed "field V102.Y (fldOffset=0x4)" P-DEP
 ;  V438 tmp262      [V438    ] (  1,  2   )   float  ->  [rbp+0x6F8]  do-not-enreg[X] addr-exposed "field V102.Z (fldOffset=0x8)" P-DEP
 ;  V439 tmp263      [V439,T19] (  3, 20   )    long  ->   r9         "field V107.Memory (fldOffset=0x0)" P-INDEP
-;  V440 tmp264      [V440,T15] (  4, 22   )     int  ->  rcx         "field V107.length (fldOffset=0x8)" P-INDEP
+;  V440 tmp264      [V440,T14] (  4, 22   )     int  ->  rcx         "field V107.length (fldOffset=0x8)" P-INDEP
 ;* V441 tmp265      [V441    ] (  0,  0   )     int  ->  zero-ref    "field V107.Id (fldOffset=0xc)" P-INDEP
 ;  V442 tmp266      [V442,T86] (  2,  4   )  ushort  ->  r14         "field V121.BundleIndex (fldOffset=0x0)" P-INDEP
 ;  V443 tmp267      [V443,T87] (  2,  4   )  ushort  ->  r15         "field V121.InnerIndex (fldOffset=0x2)" P-INDEP
@@ -1025,12 +1025,10 @@ G_M41203_IG09:        ; bbWeight=1, extend
 						;; size=127 bbWeight=1 PerfScore 65.42
 G_M41203_IG10:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=8088 {rbx rdi r15}, byref, isz
        ; byrRegs -[rdx r8 r14]
-       cmp      ecx, 8
-       jae      G_M41203_IG79
        mov      r8d, dword ptr [rbp+4*rcx+0xEB0]
        test     r8d, r8d
        jl       SHORT G_M41203_IG12
-						;; size=22 bbWeight=4 PerfScore 18.00
+						;; size=13 bbWeight=4 PerfScore 13.00
 G_M41203_IG11:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=8088 {rbx rdi r15}, byref
        mov      r8, qword ptr [rbx]
        movsxd   r9, ecx
@@ -2657,7 +2655,7 @@ RWD320 	dq	BF7FFFEFBF7FFFEFh, BF7FFFEFBF7FFFEFh, BF7FFFEFBF7FFFEFh, BF7FFFEFBF7F
 RWD352 	dq	0000800000008000h, 0000800000008000h, 0000800000008000h, 0000800000008000h
 
 
-; Total bytes of code 11776, prolog size 180, PerfScore 9713.71, instruction count 1884, allocated bytes for code 11780 (MethodHash=895d5f0c) for method BepuPhysics.CollisionDetection.CollisionTasks.TriangleConvexHullTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
+; Total bytes of code 11767, prolog size 180, PerfScore 9708.71, instruction count 1882, allocated bytes for code 11771 (MethodHash=895d5f0c) for method BepuPhysics.CollisionDetection.CollisionTasks.TriangleConvexHullTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+0.21%</span>) : 22053.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,7 +16,7 @@
 ;  V05 arg5         [V05,T32] (  2,  2   )     ref  ->  [rsp+0x188]  class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V06 arg6         [V06,T33] (  2,  2   )     ref  ->  [rsp+0x190]  class-hnd single-def <System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax]>
 ;  V07 arg7         [V07,T06] ( 14, 14   )     ref  ->  rbx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
-;  V08 loc0         [V08,T02] ( 22, 21.32)     int  ->  [rsp+0x114] 
+;  V08 loc0         [V08,T02] ( 21, 21.28)     int  ->  [rsp+0x114] 
 ;  V09 loc1         [V09,T09] ( 10, 12   )     ref  ->  [rsp+0x78]  class-hnd exact <Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
 ;  V10 loc2         [V10,T27] (  4,  6   )     ref  ->  [rsp+0x70]  class-hnd <Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
 ;  V11 loc3         [V11,T11] (  8, 10   )     ref  ->  [rsp+0x68]  class-hnd <Microsoft.CodeAnalysis.CSharp.Binder>
@@ -32,27 +32,27 @@
 ;  V21 tmp3         [V21,T03] ( 10, 20   )     ref  ->  [rsp+0x50]  class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
 ;  V22 tmp4         [V22,T20] (  4,  8   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
 ;  V23 tmp5         [V23,T21] (  4,  8   )     ref  ->   r8         class-hnd "dup spill" <Microsoft.CodeAnalysis.SyntaxTree>
-;  V24 tmp6         [V24,T16] (  8,  8   )     ref  ->   r8        
+;  V24 tmp6         [V24,T15] (  8,  8   )     ref  ->   r8        
 ;  V25 tmp7         [V25,T10] (  6, 12   )  struct (32) [rsp+0xB8]  do-not-enreg[S] must-init "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V26 tmp8         [V26,T22] (  4,  8   )     ref  ->   r9         class-hnd "dup spill" <<unknown class>>
 ;* V27 tmp9         [V27    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V28 tmp10        [V28    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V29 tmp11        [V29,T17] (  8,  8   )     ref  ->   r9        
+;  V29 tmp11        [V29,T16] (  8,  8   )     ref  ->   r9        
 ;  V30 tmp12        [V30,T04] ( 10, 20   )     ref  ->  [rsp+0x48]  class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;  V31 tmp13        [V31,T23] (  4,  8   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <<unknown class>>
 ;* V32 tmp14        [V32    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V33 tmp15        [V33    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V34 tmp16        [V34,T14] (  6,  6.04)     ref  ->  rdi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
+;  V34 tmp16        [V34,T13] (  6,  6.04)     ref  ->  rdi         single-def "field V00.array (fldOffset=0x0)" P-INDEP
 ;  V35 tmp17        [V35,T24] (  4,  6   )     ref  ->  r14         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V36 tmp18        [V36,T15] (  6,  6.04)     ref  ->  rbp         single-def "field V02.array (fldOffset=0x0)" P-INDEP
+;  V36 tmp18        [V36,T14] (  6,  6.04)     ref  ->  rbp         single-def "field V02.array (fldOffset=0x0)" P-INDEP
 ;  V37 tmp19        [V37    ] (  4,  4   )     ref  ->  [rsp+0x100]  do-not-enreg[X] addr-exposed "field V15.Item1 (fldOffset=0x0)" P-DEP
 ;  V38 tmp20        [V38    ] (  4,  4   )     ref  ->  [rsp+0x108]  do-not-enreg[X] addr-exposed "field V15.Item2 (fldOffset=0x8)" P-DEP
 ;  V39 tmp21        [V39,T26] (  6,  6   )     ref  ->  registers   "V20.[016..024)"
-;  V40 tmp22        [V40,T18] (  8,  8   )   ubyte  ->  registers   "V20.[025..026)"
+;  V40 tmp22        [V40,T17] (  8,  8   )   ubyte  ->  registers   "V20.[025..026)"
 ;  V41 tmp23        [V41,T29] (  4,  4   )     ref  ->  rdx         "V33.[008..016)"
 ;  V42 tmp24        [V42    ] (  4,  8   )  struct (32) [rsp+0x98]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[System.__Canon]>
 ;  V43 tmp25        [V43,T25] (  4,  8   )     ref  ->  rax         "argument with side effect"
-;  V44 cse0         [V44,T13] (  9,  8.04)     int  ->  [rsp+0x94]  spill-single-def "CSE - aggressive"
+;  V44 cse0         [V44,T18] (  8,  8   )     int  ->  [rsp+0x94]  spill-single-def "CSE - aggressive"
 ;  V45 cse1         [V45,T01] (  6, 21.78)    long  ->  [rsp+0x88]  spill-single-def "CSE - aggressive"
 ;  V46 rat0         [V46,T05] (  3, 17.82)     ref  ->  rdx         "Spilling to split statement for tree"
 ;  V47 rat1         [V47,T00] (  5, 29.70)     ref  ->  r12         "replacement local"
@@ -98,23 +98,23 @@ G_M18462_IG02:        ; bbWeight=1, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, by
        mov      r8d, dword ptr [r14+0x08]
        mov      dword ptr [rsp+0x94], r8d
        test     r8d, r8d
-       jle      G_M18462_IG42
+       jle      G_M18462_IG41
 						;; size=23 bbWeight=1 PerfScore 4.50
 G_M18462_IG03:        ; bbWeight=0.50, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, byref
        test     rbp, rbp
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        test     rdi, rdi
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        test     rsi, rsi
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        test     r15, r15
-       je       G_M18462_IG25
+       je       G_M18462_IG24
        cmp      dword ptr [rbp+0x08], r8d
-       jl       G_M18462_IG25
+       jl       G_M18462_IG24
        cmp      dword ptr [rdi+0x08], r8d
-       jl       G_M18462_IG25
+       jl       G_M18462_IG24
        cmp      dword ptr [rsi+0x08], r8d
-       jl       G_M18462_IG25
+       jl       G_M18462_IG24
        cmp      dword ptr [r15+0x08], r8d
        jl       G_M18462_IG09
 						;; size=76 bbWeight=0.50 PerfScore 10.50
@@ -217,7 +217,7 @@ G_M18462_IG08:        ; bbWeight=1.98, gcrefRegs=CAE8 {rbx rbp rsi rdi r9 r11 r1
 G_M18462_IG09:        ; bbWeight=0.25, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[r12-r13]
        mov      r8d, dword ptr [rsp+0x94]
-       jmp      G_M18462_IG25
+       jmp      G_M18462_IG24
 						;; size=13 bbWeight=0.25 PerfScore 0.75
 G_M18462_IG10:        ; bbWeight=1.98, gcVars=0000000000000800 {V11}, gcrefRegs=D2E8 {rbx rbp rsi rdi r9 r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[r9 r12]
@@ -296,7 +296,7 @@ G_M18462_IG14:        ; bbWeight=1.98, gcVars=0000000000000A00 {V09 V11}, gcrefR
        mov      r8, gword ptr [rdx+0x10]
        ; gcrRegs +[r8]
        test     r8, r8
-       jne      G_M18462_IG24
+       jne      G_M18462_IG23
        mov      gword ptr [rsp+0x78], rdx
        mov      rcx, rdx
        ; gcrRegs +[rcx]
@@ -412,26 +412,21 @@ G_M18462_IG20:        ; bbWeight=1.98, gcrefRegs=D0E8 {rbx rbp rsi rdi r12 r14 r
        mov      r13, gword ptr [rsp+0x188]
        ; gcrRegs +[r13]
 						;; size=62 bbWeight=1.98 PerfScore 19.80
-G_M18462_IG21:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref, isz
+G_M18462_IG21:        ; bbWeight=3.96, gcrefRegs=F0E8 {rbx rbp rsi rdi r12 r13 r14 r15}, byrefRegs=0000 {}, byref
        mov      edx, dword ptr [rsp+0x114]
        inc      edx
-       mov      eax, dword ptr [rsp+0x94]
-       cmp      eax, edx
+       cmp      dword ptr [rsp+0x94], edx
        mov      gword ptr [rsp+0x188], r13
        mov      gword ptr [rsp+0x190], r12
-       jg       SHORT G_M18462_IG23
-						;; size=36 bbWeight=3.96 PerfScore 21.78
+       mov      eax, edx
+       jg       G_M18462_IG04
+						;; size=40 bbWeight=3.96 PerfScore 25.74
 G_M18462_IG22:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx rbp rsi rdi r12-r15]
-       jmp      G_M18462_IG42
+       jmp      G_M18462_IG41
 						;; size=5 bbWeight=1.98 PerfScore 3.96
-G_M18462_IG23:        ; bbWeight=1.98, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, byref
-       ; gcrRegs +[rbx rbp rsi rdi r14-r15]
-       mov      eax, edx
-       jmp      G_M18462_IG04
-						;; size=7 bbWeight=1.98 PerfScore 4.46
-G_M18462_IG24:        ; bbWeight=0.99, gcVars=0000000000080800 {V11 V19}, gcrefRegs=D1EC {rdx rbx rbp rsi rdi r8 r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs +[rdx r8 r12]
+G_M18462_IG23:        ; bbWeight=0.99, gcVars=0000000000080800 {V11 V19}, gcrefRegs=D1EC {rdx rbx rbp rsi rdi r8 r12 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[rdx rbx rbp rsi rdi r8 r12 r14-r15]
        ; GC ptr vars +{V11 V19}
        mov      gword ptr [rsp+0x78], rdx
        ; GC ptr vars +{V09}
@@ -439,32 +434,30 @@ G_M18462_IG24:        ; bbWeight=0.99, gcVars=0000000000080800 {V11 V19}, gcrefR
        ; gcrRegs +[rax]
        jmp      G_M18462_IG15
 						;; size=15 bbWeight=0.99 PerfScore 3.96
-G_M18462_IG25:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M18462_IG24:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E8 {rbx rbp rsi rdi r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax rdx r8 r12]
        ; GC ptr vars -{V09 V11 V19}
-       cmp      eax, r8d
-       jae      G_M18462_IG44
        mov      edx, eax
        mov      r10, gword ptr [r14+8*rdx+0x10]
        ; gcrRegs +[r10]
        mov      gword ptr [rsp+0x78], r10
        ; GC ptr vars +{V09}
        cmp      eax, dword ptr [rbp+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      edx, eax
        mov      r11, gword ptr [rbp+8*rdx+0x10]
        ; gcrRegs +[r11]
        mov      gword ptr [rsp+0x70], r11
        ; GC ptr vars +{V10}
        cmp      eax, dword ptr [rdi+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      edx, eax
        mov      rcx, gword ptr [rdi+8*rdx+0x10]
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x68], rcx
        ; GC ptr vars +{V11}
        cmp      eax, dword ptr [rsi+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      dword ptr [rsp+0x114], eax
        mov      edx, eax
        mov      rdx, gword ptr [rsi+8*rdx+0x10]
@@ -475,17 +468,17 @@ G_M18462_IG25:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=C0E
        test     rcx, rcx
        mov      r10, gword ptr [rsp+0x78]
        mov      r11, gword ptr [rsp+0x68]
-       je       SHORT G_M18462_IG28
-						;; size=109 bbWeight=0.04 PerfScore 1.23
-G_M18462_IG26:        ; bbWeight=0.02, gcVars=0000000808000000 {V10 V49}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
+       je       SHORT G_M18462_IG27
+						;; size=100 bbWeight=0.04 PerfScore 1.18
+G_M18462_IG25:        ; bbWeight=0.02, gcVars=0000000808000000 {V10 V49}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rdx]
        ; GC ptr vars -{V09 V11}
        mov      rdx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        mov      qword ptr [rsp+0x80], rdx
        cmp      qword ptr [rcx], rdx
-       je       SHORT G_M18462_IG28
+       je       SHORT G_M18462_IG27
 						;; size=23 bbWeight=0.02 PerfScore 0.11
-G_M18462_IG27:        ; bbWeight=0.01, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG26:        ; bbWeight=0.01, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        mov      gword ptr [rsp+0x78], r10
        ; GC ptr vars +{V09}
@@ -500,20 +493,21 @@ G_M18462_IG27:        ; bbWeight=0.01, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r
        ; gcr arg pop 0
        mov      rcx, rax
        ; gcrRegs +[rcx]
+       mov      r8d, dword ptr [rsp+0x94]
        mov      r10, gword ptr [rsp+0x78]
        ; gcrRegs +[r10]
        mov      r11, gword ptr [rsp+0x68]
        ; gcrRegs +[r11]
-						;; size=41 bbWeight=0.01 PerfScore 0.07
-G_M18462_IG28:        ; bbWeight=0.04, gcVars=0000000008000000 {V10}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref
+						;; size=49 bbWeight=0.01 PerfScore 0.08
+G_M18462_IG27:        ; bbWeight=0.04, gcVars=0000000008000000 {V10}, gcrefRegs=CCEA {rcx rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        ; GC ptr vars -{V09 V11}
        mov      gword ptr [rsp+0x60], rcx
        ; GC ptr vars +{V12}
        test     rcx, rcx
-       jne      G_M18462_IG30
+       jne      G_M18462_IG29
 						;; size=14 bbWeight=0.04 PerfScore 0.09
-G_M18462_IG29:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
+G_M18462_IG28:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        ; GC ptr vars -{V12}
        mov      r13, gword ptr [rsp+0x188]
@@ -549,10 +543,10 @@ G_M18462_IG29:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r
        mov      rdx, gword ptr [rsp+0x108]
        ; gcrRegs +[rdx]
        test     r15, r15
-       je       G_M18462_IG41
+       je       G_M18462_IG40
        mov      eax, dword ptr [rsp+0x114]
        cmp      eax, dword ptr [r15+0x08]
-       jae      G_M18462_IG44
+       jae      G_M18462_IG43
        mov      dword ptr [rsp+0x114], eax
        mov      ecx, eax
        lea      rcx, bword ptr [r15+8*rcx+0x10]
@@ -560,9 +554,9 @@ G_M18462_IG29:        ; bbWeight=0.02, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       jmp      G_M18462_IG41
+       jmp      G_M18462_IG40
 						;; size=140 bbWeight=0.02 PerfScore 0.62
-G_M18462_IG30:        ; bbWeight=0.02, gcVars=0000000000000080 {V12}, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M18462_IG29:        ; bbWeight=0.02, gcVars=0000000000000080 {V12}, gcrefRegs=CCE8 {rbx rbp rsi rdi r10 r11 r14 r15}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[r12-r13] +[r10-r11]
        ; GC ptr vars +{V07 V12}
        mov      gword ptr [rsp+0x68], r11
@@ -572,7 +566,7 @@ G_M18462_IG30:        ; bbWeight=0.02, gcVars=0000000000000080 {V12}, gcrefRegs=
        mov      r9, rdx
        ; gcrRegs +[r9]
        cmp      gword ptr [r9+0xC8], 0
-       jne      SHORT G_M18462_IG31
+       jne      SHORT G_M18462_IG30
        mov      gword ptr [rsp+0x78], r10
        ; GC ptr vars +{V09}
        mov      rcx, gword ptr [r9+0xD0]
@@ -585,36 +579,37 @@ G_M18462_IG30:        ; bbWeight=0.02, gcVars=0000000000000080 {V12}, gcrefRegs=
        call     [Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:CreateSourceAssemblyForCompilation(Microsoft.CodeAnalysis.CSharp.CSharpCompilation):this]
...

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-27.78%</span>) : 20393.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,14 +9,14 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  4   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
+;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
-G_M54145_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M54145_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
@@ -29,30 +29,22 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        jl       SHORT G_M54145_IG06
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M54145_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M54145_IG08
        cmp      word  ptr [rax], 92
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG08
-       movzx    rdx, word  ptr [rax+0x02]
-       cmp      edx, 92
+       movzx    rcx, word  ptr [rax+0x02]
+       cmp      ecx, 92
        je       SHORT G_M54145_IG04
-       cmp      edx, 63
+       cmp      ecx, 63
        jne      SHORT G_M54145_IG06
-						;; size=29 bbWeight=0.50 PerfScore 5.50
+						;; size=20 bbWeight=0.50 PerfScore 4.25
 G_M54145_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x04], 63
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x06], 92
        sete     al
        ; byrRegs -[rax]
        movzx    rax, al
-						;; size=28 bbWeight=0.50 PerfScore 5.38
+						;; size=18 bbWeight=0.50 PerfScore 4.12
 G_M54145_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -64,13 +56,8 @@ G_M54145_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M54145_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 90, prolog size 4, PerfScore 17.75, instruction count 32, allocated bytes for code 90 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
+; Total bytes of code 65, prolog size 4, PerfScore 15.25, instruction count 22, allocated bytes for code 65 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-27.78%</span>) : 17711.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,14 +9,14 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  4   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
+;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
-G_M54145_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M54145_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
@@ -29,30 +29,22 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        jl       SHORT G_M54145_IG06
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M54145_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M54145_IG08
        cmp      word  ptr [rax], 92
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG08
-       movzx    rdx, word  ptr [rax+0x02]
-       cmp      edx, 92
+       movzx    rcx, word  ptr [rax+0x02]
+       cmp      ecx, 92
        je       SHORT G_M54145_IG04
-       cmp      edx, 63
+       cmp      ecx, 63
        jne      SHORT G_M54145_IG06
-						;; size=29 bbWeight=0.50 PerfScore 5.50
+						;; size=20 bbWeight=0.50 PerfScore 4.25
 G_M54145_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x04], 63
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x06], 92
        sete     al
        ; byrRegs -[rax]
        movzx    rax, al
-						;; size=28 bbWeight=0.50 PerfScore 5.38
+						;; size=18 bbWeight=0.50 PerfScore 4.12
 G_M54145_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -64,13 +56,8 @@ G_M54145_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M54145_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 90, prolog size 4, PerfScore 17.75, instruction count 32, allocated bytes for code 90 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
+; Total bytes of code 65, prolog size 4, PerfScore 15.25, instruction count 22, allocated bytes for code 65 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-27.78%</span>) : 2581.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,14 +9,14 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  6,  4   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  5,  3   )   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rdx         "CSE - moderate"
+;  V05 cse0         [V05,T03] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
-G_M54145_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M54145_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
@@ -29,30 +29,22 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        jl       SHORT G_M54145_IG06
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M54145_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M54145_IG08
        cmp      word  ptr [rax], 92
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG08
-       movzx    rdx, word  ptr [rax+0x02]
-       cmp      edx, 92
+       movzx    rcx, word  ptr [rax+0x02]
+       cmp      ecx, 92
        je       SHORT G_M54145_IG04
-       cmp      edx, 63
+       cmp      ecx, 63
        jne      SHORT G_M54145_IG06
-						;; size=29 bbWeight=0.50 PerfScore 5.50
+						;; size=20 bbWeight=0.50 PerfScore 4.25
 G_M54145_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       cmp      ecx, 2
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x04], 63
        jne      SHORT G_M54145_IG06
-       cmp      ecx, 3
-       jbe      SHORT G_M54145_IG08
        cmp      word  ptr [rax+0x06], 92
        sete     al
        ; byrRegs -[rax]
        movzx    rax, al
-						;; size=28 bbWeight=0.50 PerfScore 5.38
+						;; size=18 bbWeight=0.50 PerfScore 4.12
 G_M54145_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -64,13 +56,8 @@ G_M54145_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M54145_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 90, prolog size 4, PerfScore 17.75, instruction count 32, allocated bytes for code 90 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
+; Total bytes of code 65, prolog size 4, PerfScore 15.25, instruction count 22, allocated bytes for code 65 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-0.16%</span>) : 16432.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -33,7 +33,7 @@
 ;  V23 loc19        [V23    ] (  2, 16   )   byref  ->  [rsp+0x2F0]  must-init pinned ptr
 ;* V24 loc20        [V24    ] (  0,  0   )     int  ->  zero-ref   
 ;* V25 loc21        [V25    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[int]>
-;  V26 loc22        [V26,T113] (  6,  6   )     ref  ->  [rsp+0x1D8]  class-hnd spill-single-def ptr <int[]>
+;  V26 loc22        [V26,T146] (  5,  5.50)     ref  ->  [rsp+0x1D8]  class-hnd spill-single-def ptr <int[]>
 ;  V27 loc23        [V27,T81] (  6, 12.50)     int  ->  [rsp+0x2EC]  ptr
 ;  V28 loc24        [V28,T65] (  7, 17.50)     int  ->  [rsp+0x2E8]  ptr
 ;  V29 loc25        [V29,T151] (  3,  5   )     int  ->  [rsp+0x2E4]  spill-single-def ptr
@@ -44,7 +44,7 @@
 ;  V34 loc30        [V34,T11] ( 11, 65   )    long  ->  r14        
 ;  V35 loc31        [V35    ] (  2,  2   )   byref  ->  [rsp+0x2D0]  must-init pinned ptr
 ;  V36 loc32        [V36,T32] (  8, 33   )    long  ->  r12        
-;  V37 loc33        [V37,T122] (  3,  6   )   ubyte  ->  [rsp+0x2CC] 
+;  V37 loc33        [V37,T121] (  3,  6   )   ubyte  ->  [rsp+0x2CC] 
 ;  V38 loc34        [V38,T45] (  6, 24   )     int  ->  [rsp+0x2C8] 
 ;* V39 loc35        [V39    ] (  0,  0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -63,14 +63,14 @@
 ;  V53 tmp13        [V53,T107] (  2,  8   )     int  ->  rdi         "impSpillLclRefs"
 ;  V54 tmp14        [V54,T34] (  2, 32   )     int  ->  rdi         "impSpillLclRefs"
 ;  V55 tmp15        [V55,T13] (  2, 64   )     int  ->  rdi         "dup spill"
-;  V56 tmp16        [V56,T123] (  3,  6   )     int  ->  [rsp+0x2C4]  ptr
+;  V56 tmp16        [V56,T122] (  3,  6   )     int  ->  [rsp+0x2C4]  ptr
 ;* V57 tmp17        [V57    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V58 tmp18        [V58    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V59 tmp19        [V59    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;  V60 tmp20        [V60,T82] (  3, 12   )    long  ->  rdx         "impSpillLclRefs"
 ;  V61 tmp21        [V61,T98] (  4,  8   )     int  ->  rdx        
 ;* V62 tmp22        [V62    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V63 tmp23        [V63,T124] (  3,  6   )     int  ->   r8        
+;  V63 tmp23        [V63,T123] (  3,  6   )     int  ->   r8        
 ;  V64 tmp24        [V64,T35] (  2, 32   )     int  ->  rdi         "impSpillLclRefs"
 ;* V65 tmp25        [V65    ] (  0,  0   )   byref  ->  zero-ref    ptr
 ;  V66 tmp26        [V66,T36] (  2, 32   )    long  ->  r12         "impSpillLclRefs"
@@ -169,7 +169,7 @@
 ;* V159 tmp119      [V159    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V160 tmp120      [V160    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V161 tmp121      [V161    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V162 tmp122      [V162,T125] (  3,  6   )     int  ->  [rsp+0x2A4]  spill-single-def ptr "Inline stloc first use temp"
+;  V162 tmp122      [V162,T124] (  3,  6   )     int  ->  [rsp+0x2A4]  spill-single-def ptr "Inline stloc first use temp"
 ;* V163 tmp123      [V163    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V164 tmp124      [V164    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V165 tmp125      [V165    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -193,7 +193,7 @@
 ;* V183 tmp143      [V183    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V184 tmp144      [V184    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V185 tmp145      [V185    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V186 tmp146      [V186,T126] (  3,  6   )     int  ->  [rsp+0x298]  spill-single-def ptr "Inline stloc first use temp"
+;  V186 tmp146      [V186,T125] (  3,  6   )     int  ->  [rsp+0x298]  spill-single-def ptr "Inline stloc first use temp"
 ;* V187 tmp147      [V187    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V188 tmp148      [V188    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V189 tmp149      [V189    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -217,7 +217,7 @@
 ;* V207 tmp167      [V207    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V208 tmp168      [V208    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V209 tmp169      [V209    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V210 tmp170      [V210,T127] (  3,  6   )     int  ->  [rsp+0x28C]  spill-single-def ptr "Inline stloc first use temp"
+;  V210 tmp170      [V210,T126] (  3,  6   )     int  ->  [rsp+0x28C]  spill-single-def ptr "Inline stloc first use temp"
 ;* V211 tmp171      [V211    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V212 tmp172      [V212    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V213 tmp173      [V213    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -241,7 +241,7 @@
 ;* V231 tmp191      [V231    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V232 tmp192      [V232    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V233 tmp193      [V233    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V234 tmp194      [V234,T128] (  3,  6   )     int  ->  [rsp+0x284]  spill-single-def ptr "Inline stloc first use temp"
+;  V234 tmp194      [V234,T127] (  3,  6   )     int  ->  [rsp+0x284]  spill-single-def ptr "Inline stloc first use temp"
 ;* V235 tmp195      [V235    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V236 tmp196      [V236    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V237 tmp197      [V237    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -377,101 +377,101 @@
 ;* V367 tmp327      [V367    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V143._reference (fldOffset=0x0)" P-INDEP
 ;* V368 tmp328      [V368    ] (  0,  0   )     int  ->  zero-ref    ptr "field V143._length (fldOffset=0x8)" P-INDEP
 ;  V369 tmp329      [V369,T157] (  2,  4   )   byref  ->  [rsp+0x140]  spill-single-def ptr "field V145._reference (fldOffset=0x0)" P-INDEP
-;  V370 tmp330      [V370,T129] (  3,  6   )     int  ->   r8         "field V145._length (fldOffset=0x8)" P-INDEP
+;  V370 tmp330      [V370,T128] (  3,  6   )     int  ->   r8         "field V145._length (fldOffset=0x8)" P-INDEP
 ;* V371 tmp331      [V371    ] (  0,  0   )   byref  ->  zero-ref    "field V147._reference (fldOffset=0x0)" P-INDEP
 ;* V372 tmp332      [V372    ] (  0,  0   )     int  ->  zero-ref    "field V147._length (fldOffset=0x8)" P-INDEP
 ;* V373 tmp333      [V373    ] (  0,  0   )   byref  ->  zero-ref    "field V148._reference (fldOffset=0x0)" P-INDEP
 ;* V374 tmp334      [V374    ] (  0,  0   )     int  ->  zero-ref    "field V148._length (fldOffset=0x8)" P-INDEP
-;  V375 tmp335      [V375,T114] (  3,  6   )   byref  ->  [rsp+0x138]  ptr "field V149._reference (fldOffset=0x0)" P-INDEP
-;  V376 tmp336      [V376,T130] (  3,  6   )     int  ->  [rsp+0x248]  ptr "field V149._length (fldOffset=0x8)" P-INDEP
+;  V375 tmp335      [V375,T113] (  3,  6   )   byref  ->  [rsp+0x138]  ptr "field V149._reference (fldOffset=0x0)" P-INDEP
+;  V376 tmp336      [V376,T129] (  3,  6   )     int  ->  [rsp+0x248]  ptr "field V149._length (fldOffset=0x8)" P-INDEP
 ;  V377 tmp337      [V377,T158] (  2,  4   )   byref  ->  [rsp+0x130]  spill-single-def ptr "field V151._reference (fldOffset=0x0)" P-INDEP
 ;  V378 tmp338      [V378,T177] (  2,  4   )     int  ->  [rsp+0x244]  spill-single-def ptr "field V151._length (fldOffset=0x8)" P-INDEP
 ;* V379 tmp339      [V379    ] (  0,  0   )   byref  ->  zero-ref    "field V152._reference (fldOffset=0x0)" P-INDEP
 ;* V380 tmp340      [V380    ] (  0,  0   )     int  ->  zero-ref    "field V152._length (fldOffset=0x8)" P-INDEP
-;  V381 tmp341      [V381,T115] (  3,  6   )   byref  ->  [rsp+0x128]  spill-single-def ptr "field V159._reference (fldOffset=0x0)" P-INDEP
+;  V381 tmp341      [V381,T114] (  3,  6   )   byref  ->  [rsp+0x128]  spill-single-def ptr "field V159._reference (fldOffset=0x0)" P-INDEP
 ;* V382 tmp342      [V382    ] (  0,  0   )     int  ->  zero-ref    ptr "field V159._length (fldOffset=0x8)" P-INDEP
 ;  V383 tmp343      [V383,T159] (  2,  4   )   byref  ->  [rsp+0x120]  spill-single-def ptr "field V163._reference (fldOffset=0x0)" P-INDEP
-;  V384 tmp344      [V384,T131] (  3,  6   )     int  ->  [rsp+0x240]  spill-single-def ptr "field V163._length (fldOffset=0x8)" P-INDEP
+;  V384 tmp344      [V384,T130] (  3,  6   )     int  ->  [rsp+0x240]  spill-single-def ptr "field V163._length (fldOffset=0x8)" P-INDEP
 ;* V385 tmp345      [V385    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V164._reference (fldOffset=0x0)" P-INDEP
 ;* V386 tmp346      [V386    ] (  0,  0   )     int  ->  zero-ref    "field V164._length (fldOffset=0x8)" P-INDEP
 ;  V387 tmp347      [V387,T160] (  2,  4   )   byref  ->  [rsp+0x118]  spill-single-def ptr "field V169._reference (fldOffset=0x0)" P-INDEP
-;  V388 tmp348      [V388,T132] (  3,  6   )     int  ->  [rsp+0x23C]  spill-single-def ptr "field V169._length (fldOffset=0x8)" P-INDEP
+;  V388 tmp348      [V388,T131] (  3,  6   )     int  ->  [rsp+0x23C]  spill-single-def ptr "field V169._length (fldOffset=0x8)" P-INDEP
 ;* V389 tmp349      [V389    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V170._reference (fldOffset=0x0)" P-INDEP
 ;* V390 tmp350      [V390    ] (  0,  0   )     int  ->  zero-ref    ptr "field V170._length (fldOffset=0x8)" P-INDEP
 ;* V391 tmp351      [V391    ] (  0,  0   )   byref  ->  zero-ref    "field V171._reference (fldOffset=0x0)" P-INDEP
 ;* V392 tmp352      [V392    ] (  0,  0   )     int  ->  zero-ref    "field V171._length (fldOffset=0x8)" P-INDEP
 ;* V393 tmp353      [V393    ] (  0,  0   )   byref  ->  zero-ref    "field V172._reference (fldOffset=0x0)" P-INDEP
 ;* V394 tmp354      [V394    ] (  0,  0   )     int  ->  zero-ref    "field V172._length (fldOffset=0x8)" P-INDEP
-;  V395 tmp355      [V395,T116] (  3,  6   )   byref  ->  [rsp+0x110]  ptr "field V173._reference (fldOffset=0x0)" P-INDEP
-;  V396 tmp356      [V396,T133] (  3,  6   )     int  ->  [rsp+0x238]  ptr "field V173._length (fldOffset=0x8)" P-INDEP
+;  V395 tmp355      [V395,T115] (  3,  6   )   byref  ->  [rsp+0x110]  ptr "field V173._reference (fldOffset=0x0)" P-INDEP
+;  V396 tmp356      [V396,T132] (  3,  6   )     int  ->  [rsp+0x238]  ptr "field V173._length (fldOffset=0x8)" P-INDEP
 ;  V397 tmp357      [V397,T161] (  2,  4   )   byref  ->  [rsp+0x108]  spill-single-def ptr "field V175._reference (fldOffset=0x0)" P-INDEP
 ;  V398 tmp358      [V398,T178] (  2,  4   )     int  ->  [rsp+0x234]  spill-single-def ptr "field V175._length (fldOffset=0x8)" P-INDEP
 ;* V399 tmp359      [V399    ] (  0,  0   )   byref  ->  zero-ref    "field V176._reference (fldOffset=0x0)" P-INDEP
 ;* V400 tmp360      [V400    ] (  0,  0   )     int  ->  zero-ref    "field V176._length (fldOffset=0x8)" P-INDEP
-;  V401 tmp361      [V401,T117] (  3,  6   )   byref  ->  [rsp+0x100]  spill-single-def ptr "field V183._reference (fldOffset=0x0)" P-INDEP
+;  V401 tmp361      [V401,T116] (  3,  6   )   byref  ->  [rsp+0x100]  spill-single-def ptr "field V183._reference (fldOffset=0x0)" P-INDEP
 ;* V402 tmp362      [V402    ] (  0,  0   )     int  ->  zero-ref    ptr "field V183._length (fldOffset=0x8)" P-INDEP
 ;  V403 tmp363      [V403,T162] (  2,  4   )   byref  ->  [rsp+0xF8]  spill-single-def ptr "field V187._reference (fldOffset=0x0)" P-INDEP
-;  V404 tmp364      [V404,T134] (  3,  6   )     int  ->  [rsp+0x230]  spill-single-def ptr "field V187._length (fldOffset=0x8)" P-INDEP
+;  V404 tmp364      [V404,T133] (  3,  6   )     int  ->  [rsp+0x230]  spill-single-def ptr "field V187._length (fldOffset=0x8)" P-INDEP
 ;* V405 tmp365      [V405    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V188._reference (fldOffset=0x0)" P-INDEP
 ;* V406 tmp366      [V406    ] (  0,  0   )     int  ->  zero-ref    "field V188._length (fldOffset=0x8)" P-INDEP
 ;  V407 tmp367      [V407,T163] (  2,  4   )   byref  ->  [rsp+0xF0]  spill-single-def ptr "field V193._reference (fldOffset=0x0)" P-INDEP
-;  V408 tmp368      [V408,T135] (  3,  6   )     int  ->  [rsp+0x22C]  spill-single-def ptr "field V193._length (fldOffset=0x8)" P-INDEP
+;  V408 tmp368      [V408,T134] (  3,  6   )     int  ->  [rsp+0x22C]  spill-single-def ptr "field V193._length (fldOffset=0x8)" P-INDEP
 ;* V409 tmp369      [V409    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V194._reference (fldOffset=0x0)" P-INDEP
 ;* V410 tmp370      [V410    ] (  0,  0   )     int  ->  zero-ref    ptr "field V194._length (fldOffset=0x8)" P-INDEP
 ;* V411 tmp371      [V411    ] (  0,  0   )   byref  ->  zero-ref    "field V195._reference (fldOffset=0x0)" P-INDEP
 ;* V412 tmp372      [V412    ] (  0,  0   )     int  ->  zero-ref    "field V195._length (fldOffset=0x8)" P-INDEP
 ;* V413 tmp373      [V413    ] (  0,  0   )   byref  ->  zero-ref    "field V196._reference (fldOffset=0x0)" P-INDEP
 ;* V414 tmp374      [V414    ] (  0,  0   )     int  ->  zero-ref    "field V196._length (fldOffset=0x8)" P-INDEP
-;  V415 tmp375      [V415,T118] (  3,  6   )   byref  ->  [rsp+0xE8]  ptr "field V197._reference (fldOffset=0x0)" P-INDEP
-;  V416 tmp376      [V416,T136] (  3,  6   )     int  ->  [rsp+0x228]  ptr "field V197._length (fldOffset=0x8)" P-INDEP
+;  V415 tmp375      [V415,T117] (  3,  6   )   byref  ->  [rsp+0xE8]  ptr "field V197._reference (fldOffset=0x0)" P-INDEP
+;  V416 tmp376      [V416,T135] (  3,  6   )     int  ->  [rsp+0x228]  ptr "field V197._length (fldOffset=0x8)" P-INDEP
 ;  V417 tmp377      [V417,T164] (  2,  4   )   byref  ->  [rsp+0xE0]  spill-single-def ptr "field V199._reference (fldOffset=0x0)" P-INDEP
 ;  V418 tmp378      [V418,T179] (  2,  4   )     int  ->  [rsp+0x224]  spill-single-def ptr "field V199._length (fldOffset=0x8)" P-INDEP
 ;* V419 tmp379      [V419    ] (  0,  0   )   byref  ->  zero-ref    "field V200._reference (fldOffset=0x0)" P-INDEP
 ;* V420 tmp380      [V420    ] (  0,  0   )     int  ->  zero-ref    "field V200._length (fldOffset=0x8)" P-INDEP
-;  V421 tmp381      [V421,T119] (  3,  6   )   byref  ->  [rsp+0xD8]  spill-single-def ptr "field V207._reference (fldOffset=0x0)" P-INDEP
+;  V421 tmp381      [V421,T118] (  3,  6   )   byref  ->  [rsp+0xD8]  spill-single-def ptr "field V207._reference (fldOffset=0x0)" P-INDEP
 ;* V422 tmp382      [V422    ] (  0,  0   )     int  ->  zero-ref    ptr "field V207._length (fldOffset=0x8)" P-INDEP
 ;  V423 tmp383      [V423,T165] (  2,  4   )   byref  ->  [rsp+0xD0]  spill-single-def ptr "field V211._reference (fldOffset=0x0)" P-INDEP
-;  V424 tmp384      [V424,T137] (  3,  6   )     int  ->  [rsp+0x220]  spill-single-def ptr "field V211._length (fldOffset=0x8)" P-INDEP
+;  V424 tmp384      [V424,T136] (  3,  6   )     int  ->  [rsp+0x220]  spill-single-def ptr "field V211._length (fldOffset=0x8)" P-INDEP
 ;* V425 tmp385      [V425    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V212._reference (fldOffset=0x0)" P-INDEP
 ;* V426 tmp386      [V426    ] (  0,  0   )     int  ->  zero-ref    "field V212._length (fldOffset=0x8)" P-INDEP
 ;  V427 tmp387      [V427,T166] (  2,  4   )   byref  ->  [rsp+0xC8]  spill-single-def ptr "field V217._reference (fldOffset=0x0)" P-INDEP
-;  V428 tmp388      [V428,T138] (  3,  6   )     int  ->  [rsp+0x21C]  spill-single-def ptr "field V217._length (fldOffset=0x8)" P-INDEP
+;  V428 tmp388      [V428,T137] (  3,  6   )     int  ->  [rsp+0x21C]  spill-single-def ptr "field V217._length (fldOffset=0x8)" P-INDEP
 ;* V429 tmp389      [V429    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V218._reference (fldOffset=0x0)" P-INDEP
 ;* V430 tmp390      [V430    ] (  0,  0   )     int  ->  zero-ref    ptr "field V218._length (fldOffset=0x8)" P-INDEP
 ;* V431 tmp391      [V431    ] (  0,  0   )   byref  ->  zero-ref    "field V219._reference (fldOffset=0x0)" P-INDEP
 ;* V432 tmp392      [V432    ] (  0,  0   )     int  ->  zero-ref    "field V219._length (fldOffset=0x8)" P-INDEP
 ;* V433 tmp393      [V433    ] (  0,  0   )   byref  ->  zero-ref    "field V220._reference (fldOffset=0x0)" P-INDEP
 ;* V434 tmp394      [V434    ] (  0,  0   )     int  ->  zero-ref    "field V220._length (fldOffset=0x8)" P-INDEP
-;  V435 tmp395      [V435,T120] (  3,  6   )   byref  ->  [rsp+0xC0]  ptr "field V221._reference (fldOffset=0x0)" P-INDEP
-;  V436 tmp396      [V436,T139] (  3,  6   )     int  ->  [rsp+0x218]  ptr "field V221._length (fldOffset=0x8)" P-INDEP
+;  V435 tmp395      [V435,T119] (  3,  6   )   byref  ->  [rsp+0xC0]  ptr "field V221._reference (fldOffset=0x0)" P-INDEP
+;  V436 tmp396      [V436,T138] (  3,  6   )     int  ->  [rsp+0x218]  ptr "field V221._length (fldOffset=0x8)" P-INDEP
 ;  V437 tmp397      [V437,T167] (  2,  4   )   byref  ->   r8         "field V223._reference (fldOffset=0x0)" P-INDEP
 ;  V438 tmp398      [V438,T180] (  2,  4   )     int  ->  rdx         "field V223._length (fldOffset=0x8)" P-INDEP
 ;* V439 tmp399      [V439    ] (  0,  0   )   byref  ->  zero-ref    "field V224._reference (fldOffset=0x0)" P-INDEP
 ;* V440 tmp400      [V440    ] (  0,  0   )     int  ->  zero-ref    "field V224._length (fldOffset=0x8)" P-INDEP
-;  V441 tmp401      [V441,T121] (  3,  6   )   byref  ->  [rsp+0xB8]  spill-single-def ptr "field V231._reference (fldOffset=0x0)" P-INDEP
+;  V441 tmp401      [V441,T120] (  3,  6   )   byref  ->  [rsp+0xB8]  spill-single-def ptr "field V231._reference (fldOffset=0x0)" P-INDEP
 ;* V442 tmp402      [V442    ] (  0,  0   )     int  ->  zero-ref    ptr "field V231._length (fldOffset=0x8)" P-INDEP
 ;  V443 tmp403      [V443,T168] (  2,  4   )   byref  ->  [rsp+0xB0]  spill-single-def ptr "field V235._reference (fldOffset=0x0)" P-INDEP
-;  V444 tmp404      [V444,T140] (  3,  6   )     int  ->  [rsp+0x214]  spill-single-def ptr "field V235._length (fldOffset=0x8)" P-INDEP
+;  V444 tmp404      [V444,T139] (  3,  6   )     int  ->  [rsp+0x214]  spill-single-def ptr "field V235._length (fldOffset=0x8)" P-INDEP
 ;* V445 tmp405      [V445    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V236._reference (fldOffset=0x0)" P-INDEP
 ;* V446 tmp406      [V446    ] (  0,  0   )     int  ->  zero-ref    "field V236._length (fldOffset=0x8)" P-INDEP
 ;  V447 tmp407      [V447,T169] (  2,  4   )   byref  ->  [rsp+0xA8]  spill-single-def ptr "field V241._reference (fldOffset=0x0)" P-INDEP
-;  V448 tmp408      [V448,T141] (  3,  6   )     int  ->  [rsp+0x210]  spill-single-def ptr "field V241._length (fldOffset=0x8)" P-INDEP
+;  V448 tmp408      [V448,T140] (  3,  6   )     int  ->  [rsp+0x210]  spill-single-def ptr "field V241._length (fldOffset=0x8)" P-INDEP
 ;* V449 tmp409      [V449    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V242._reference (fldOffset=0x0)" P-INDEP
 ;* V450 tmp410      [V450    ] (  0,  0   )     int  ->  zero-ref    ptr "field V242._length (fldOffset=0x8)" P-INDEP
 ;  V451 tmp411      [V451,T76] (  2, 16   )   byref  ->  [rsp+0xA0]  spill-single-def ptr "field V245._reference (fldOffset=0x0)" P-INDEP
 ;  V452 tmp412      [V452,T56] (  3, 24   )     int  ->  rsi         "field V245._length (fldOffset=0x8)" P-INDEP
 ;  V453 tmp413      [V453,T170] (  2,  4   )   byref  ->  [rsp+0x98]  spill-single-def ptr "field V249._reference (fldOffset=0x0)" P-INDEP
-;  V454 tmp414      [V454,T142] (  3,  6   )     int  ->  [rsp+0x20C]  spill-single-def ptr "field V249._length (fldOffset=0x8)" P-INDEP
+;  V454 tmp414      [V454,T141] (  3,  6   )     int  ->  [rsp+0x20C]  spill-single-def ptr "field V249._length (fldOffset=0x8)" P-INDEP
 ;  V455 tmp415      [V455,T171] (  2,  4   )   byref  ->  [rsp+0x90]  spill-single-def ptr "field V252._reference (fldOffset=0x0)" P-INDEP
-;  V456 tmp416      [V456,T143] (  3,  6   )     int  ->  [rsp+0x208]  spill-single-def ptr "field V252._length (fldOffset=0x8)" P-INDEP
+;  V456 tmp416      [V456,T142] (  3,  6   )     int  ->  [rsp+0x208]  spill-single-def ptr "field V252._length (fldOffset=0x8)" P-INDEP
 ;  V457 tmp417      [V457,T172] (  2,  4   )   byref  ->  [rsp+0x88]  spill-single-def ptr "field V255._reference (fldOffset=0x0)" P-INDEP
-;  V458 tmp418      [V458,T144] (  3,  6   )     int  ->  [rsp+0x204]  spill-single-def ptr "field V255._length (fldOffset=0x8)" P-INDEP
+;  V458 tmp418      [V458,T143] (  3,  6   )     int  ->  [rsp+0x204]  spill-single-def ptr "field V255._length (fldOffset=0x8)" P-INDEP
 ;  V459 tmp419      [V459,T173] (  2,  4   )   byref  ->  [rsp+0x80]  spill-single-def ptr "field V259._reference (fldOffset=0x0)" P-INDEP
-;  V460 tmp420      [V460,T145] (  3,  6   )     int  ->  [rsp+0x200]  spill-single-def ptr "field V259._length (fldOffset=0x8)" P-INDEP
+;  V460 tmp420      [V460,T144] (  3,  6   )     int  ->  [rsp+0x200]  spill-single-def ptr "field V259._length (fldOffset=0x8)" P-INDEP
 ;  V461 tmp421      [V461,T77] (  2, 16   )   byref  ->  [rsp+0x78]  spill-single-def ptr "field V263._reference (fldOffset=0x0)" P-INDEP
 ;  V462 tmp422      [V462,T57] (  3, 24   )     int  ->  rbx         "field V263._length (fldOffset=0x8)" P-INDEP
 ;  V463 tmp423      [V463,T174] (  2,  4   )   byref  ->  [rsp+0x70]  spill-single-def ptr "field V266._reference (fldOffset=0x0)" P-INDEP
-;  V464 tmp424      [V464,T146] (  3,  6   )     int  ->  [rsp+0x1FC]  spill-single-def ptr "field V266._length (fldOffset=0x8)" P-INDEP
+;  V464 tmp424      [V464,T145] (  3,  6   )     int  ->  [rsp+0x1FC]  spill-single-def ptr "field V266._length (fldOffset=0x8)" P-INDEP
 ;* V465 tmp425      [V465    ] (  0,  0   )   byref  ->  zero-ref    "field V268._reference (fldOffset=0x0)" P-INDEP
 ;* V466 tmp426      [V466    ] (  0,  0   )     int  ->  zero-ref    "field V268._length (fldOffset=0x8)" P-INDEP
 ;* V467 tmp427      [V467    ] (  0,  0   )   byref  ->  zero-ref    "field V269._reference (fldOffset=0x0)" P-INDEP
@@ -1013,13 +1013,11 @@ G_M54741_IG53:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000
        je       SHORT G_M54741_IG54
        mov      r12, gword ptr [rsp+0x1D8]
        ; gcrRegs +[r12]
-       cmp      dword ptr [r12+0x08], 0
-       jbe      G_M54741_IG179
        mov      r12d, dword ptr [r12+0x10]
        ; gcrRegs -[r12]
        mov      dword ptr [rsp+0x2E8], r12d
-						;; size=121 bbWeight=0.50 PerfScore 13.38
-G_M54741_IG54:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000020000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
+						;; size=109 bbWeight=0.50 PerfScore 11.38
+G_M54741_IG54:        ; bbWeight=0.50, gcVars=0000000000000000000000000004000000000000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
        mov      r12d, dword ptr [rsp+0x2E8]
        mov      dword ptr [rsp+0x2E0], r12d
        xor      r12d, r12d
@@ -1078,7 +1076,7 @@ G_M54741_IG56:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14},
        ; GC ptr vars +{V289}
        mov      r9d, dword ptr [rsp+0x328]
 						;; size=98 bbWeight=2 PerfScore 29.50
-G_M54741_IG57:        ; bbWeight=4, gcVars=0000000000000000000000000000000000020000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG57:        ; bbWeight=4, gcVars=0000000000000000000000000004000000000000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; byrRegs -[rdx r12 r14]
        mov      ecx, dword ptr [rsp+0x300]
        mov      dword ptr [rsp+0x260], ebx
@@ -1331,7 +1329,7 @@ G_M54741_IG76:        ; bbWeight=0.25, gcVars=0000000000000000000000000000000000
 G_M54741_IG77:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=5020 {rbp r12 r14}, byref
        jmp      G_M54741_IG64
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M54741_IG78:        ; bbWeight=2, gcVars=0000000000000000000000000000000000020000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
+G_M54741_IG78:        ; bbWeight=2, gcVars=0000000000000000000000000004000000000000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
        ; byrRegs -[r12]
        ; GC ptr vars +{V26}
        jmp      G_M54741_IG57
@@ -1805,7 +1803,7 @@ G_M54741_IG117:        ; bbWeight=2, gcVars=000000000000000000000000000000000000
        ; byrRegs -[rdx]
        mov      dword ptr [rsp+0x248], edx
 						;; size=90 bbWeight=2 PerfScore 26.50
-G_M54741_IG118:        ; bbWeight=2, gcVars=0000000000000000000000000000000000040000000000006800000000000000 {V289 V375 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG118:        ; bbWeight=2, gcVars=0000000000000000000000000000000000020000000000006800000000000000 {V289 V375 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; GC ptr vars -{V68 V150 V154 V377}
        mov      rdx, bword ptr [rsp+0x138]
        ; byrRegs +[rdx]
@@ -1967,7 +1965,7 @@ G_M54741_IG127:        ; bbWeight=2, gcVars=000000000000000000000000000000000000
        ; byrRegs -[r8]
        mov      dword ptr [rsp+0x238], r8d
 						;; size=96 bbWeight=2 PerfScore 26.50
-G_M54741_IG128:        ; bbWeight=2, gcVars=0000000000000000000000000000000000100000000000006800000000000000 {V289 V395 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG128:        ; bbWeight=2, gcVars=0000000000000000000000000000000000080000000000006800000000000000 {V289 V395 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; GC ptr vars -{V174 V178 V397}
        mov      r8, bword ptr [rsp+0x110]
...

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-0.16%</span>) : 21715.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -33,7 +33,7 @@
 ;  V23 loc19        [V23    ] (  2, 16   )   byref  ->  [rsp+0x2F0]  must-init pinned ptr
 ;* V24 loc20        [V24    ] (  0,  0   )     int  ->  zero-ref   
 ;* V25 loc21        [V25    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[int]>
-;  V26 loc22        [V26,T113] (  6,  6   )     ref  ->  [rsp+0x1D8]  class-hnd spill-single-def ptr <int[]>
+;  V26 loc22        [V26,T146] (  5,  5.50)     ref  ->  [rsp+0x1D8]  class-hnd spill-single-def ptr <int[]>
 ;  V27 loc23        [V27,T81] (  6, 12.50)     int  ->  [rsp+0x2EC]  ptr
 ;  V28 loc24        [V28,T65] (  7, 17.50)     int  ->  [rsp+0x2E8]  ptr
 ;  V29 loc25        [V29,T151] (  3,  5   )     int  ->  [rsp+0x2E4]  spill-single-def ptr
@@ -44,7 +44,7 @@
 ;  V34 loc30        [V34,T11] ( 11, 65   )    long  ->  r14        
 ;  V35 loc31        [V35    ] (  2,  2   )   byref  ->  [rsp+0x2D0]  must-init pinned ptr
 ;  V36 loc32        [V36,T32] (  8, 33   )    long  ->  r12        
-;  V37 loc33        [V37,T122] (  3,  6   )   ubyte  ->  [rsp+0x2CC] 
+;  V37 loc33        [V37,T121] (  3,  6   )   ubyte  ->  [rsp+0x2CC] 
 ;  V38 loc34        [V38,T45] (  6, 24   )     int  ->  [rsp+0x2C8] 
 ;* V39 loc35        [V39    ] (  0,  0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -63,14 +63,14 @@
 ;  V53 tmp13        [V53,T107] (  2,  8   )     int  ->  rdi         "impSpillLclRefs"
 ;  V54 tmp14        [V54,T34] (  2, 32   )     int  ->  rdi         "impSpillLclRefs"
 ;  V55 tmp15        [V55,T13] (  2, 64   )     int  ->  rdi         "dup spill"
-;  V56 tmp16        [V56,T123] (  3,  6   )     int  ->  [rsp+0x2C4]  ptr
+;  V56 tmp16        [V56,T122] (  3,  6   )     int  ->  [rsp+0x2C4]  ptr
 ;* V57 tmp17        [V57    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V58 tmp18        [V58    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V59 tmp19        [V59    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;  V60 tmp20        [V60,T82] (  3, 12   )    long  ->  rdx         "impSpillLclRefs"
 ;  V61 tmp21        [V61,T98] (  4,  8   )     int  ->  rdx        
 ;* V62 tmp22        [V62    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V63 tmp23        [V63,T124] (  3,  6   )     int  ->   r8        
+;  V63 tmp23        [V63,T123] (  3,  6   )     int  ->   r8        
 ;  V64 tmp24        [V64,T35] (  2, 32   )     int  ->  rdi         "impSpillLclRefs"
 ;* V65 tmp25        [V65    ] (  0,  0   )   byref  ->  zero-ref    ptr
 ;  V66 tmp26        [V66,T36] (  2, 32   )    long  ->  r12         "impSpillLclRefs"
@@ -169,7 +169,7 @@
 ;* V159 tmp119      [V159    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V160 tmp120      [V160    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V161 tmp121      [V161    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V162 tmp122      [V162,T125] (  3,  6   )     int  ->  [rsp+0x2A4]  spill-single-def ptr "Inline stloc first use temp"
+;  V162 tmp122      [V162,T124] (  3,  6   )     int  ->  [rsp+0x2A4]  spill-single-def ptr "Inline stloc first use temp"
 ;* V163 tmp123      [V163    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V164 tmp124      [V164    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V165 tmp125      [V165    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -193,7 +193,7 @@
 ;* V183 tmp143      [V183    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V184 tmp144      [V184    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V185 tmp145      [V185    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V186 tmp146      [V186,T126] (  3,  6   )     int  ->  [rsp+0x298]  spill-single-def ptr "Inline stloc first use temp"
+;  V186 tmp146      [V186,T125] (  3,  6   )     int  ->  [rsp+0x298]  spill-single-def ptr "Inline stloc first use temp"
 ;* V187 tmp147      [V187    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V188 tmp148      [V188    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V189 tmp149      [V189    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -217,7 +217,7 @@
 ;* V207 tmp167      [V207    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V208 tmp168      [V208    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V209 tmp169      [V209    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V210 tmp170      [V210,T127] (  3,  6   )     int  ->  [rsp+0x28C]  spill-single-def ptr "Inline stloc first use temp"
+;  V210 tmp170      [V210,T126] (  3,  6   )     int  ->  [rsp+0x28C]  spill-single-def ptr "Inline stloc first use temp"
 ;* V211 tmp171      [V211    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V212 tmp172      [V212    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V213 tmp173      [V213    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -241,7 +241,7 @@
 ;* V231 tmp191      [V231    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V232 tmp192      [V232    ] (  0,  0   )     int  ->  zero-ref    ptr "Inline stloc first use temp"
 ;* V233 tmp193      [V233    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V234 tmp194      [V234,T128] (  3,  6   )     int  ->  [rsp+0x284]  spill-single-def ptr "Inline stloc first use temp"
+;  V234 tmp194      [V234,T127] (  3,  6   )     int  ->  [rsp+0x284]  spill-single-def ptr "Inline stloc first use temp"
 ;* V235 tmp195      [V235    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V236 tmp196      [V236    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V237 tmp197      [V237    ] (  0,  0   )   byref  ->  zero-ref    ptr "Inlining Arg"
@@ -377,101 +377,101 @@
 ;* V367 tmp327      [V367    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V143._reference (fldOffset=0x0)" P-INDEP
 ;* V368 tmp328      [V368    ] (  0,  0   )     int  ->  zero-ref    ptr "field V143._length (fldOffset=0x8)" P-INDEP
 ;  V369 tmp329      [V369,T157] (  2,  4   )   byref  ->  [rsp+0x140]  spill-single-def ptr "field V145._reference (fldOffset=0x0)" P-INDEP
-;  V370 tmp330      [V370,T129] (  3,  6   )     int  ->   r8         "field V145._length (fldOffset=0x8)" P-INDEP
+;  V370 tmp330      [V370,T128] (  3,  6   )     int  ->   r8         "field V145._length (fldOffset=0x8)" P-INDEP
 ;* V371 tmp331      [V371    ] (  0,  0   )   byref  ->  zero-ref    "field V147._reference (fldOffset=0x0)" P-INDEP
 ;* V372 tmp332      [V372    ] (  0,  0   )     int  ->  zero-ref    "field V147._length (fldOffset=0x8)" P-INDEP
 ;* V373 tmp333      [V373    ] (  0,  0   )   byref  ->  zero-ref    "field V148._reference (fldOffset=0x0)" P-INDEP
 ;* V374 tmp334      [V374    ] (  0,  0   )     int  ->  zero-ref    "field V148._length (fldOffset=0x8)" P-INDEP
-;  V375 tmp335      [V375,T114] (  3,  6   )   byref  ->  [rsp+0x138]  ptr "field V149._reference (fldOffset=0x0)" P-INDEP
-;  V376 tmp336      [V376,T130] (  3,  6   )     int  ->  [rsp+0x248]  ptr "field V149._length (fldOffset=0x8)" P-INDEP
+;  V375 tmp335      [V375,T113] (  3,  6   )   byref  ->  [rsp+0x138]  ptr "field V149._reference (fldOffset=0x0)" P-INDEP
+;  V376 tmp336      [V376,T129] (  3,  6   )     int  ->  [rsp+0x248]  ptr "field V149._length (fldOffset=0x8)" P-INDEP
 ;  V377 tmp337      [V377,T158] (  2,  4   )   byref  ->  [rsp+0x130]  spill-single-def ptr "field V151._reference (fldOffset=0x0)" P-INDEP
 ;  V378 tmp338      [V378,T177] (  2,  4   )     int  ->  [rsp+0x244]  spill-single-def ptr "field V151._length (fldOffset=0x8)" P-INDEP
 ;* V379 tmp339      [V379    ] (  0,  0   )   byref  ->  zero-ref    "field V152._reference (fldOffset=0x0)" P-INDEP
 ;* V380 tmp340      [V380    ] (  0,  0   )     int  ->  zero-ref    "field V152._length (fldOffset=0x8)" P-INDEP
-;  V381 tmp341      [V381,T115] (  3,  6   )   byref  ->  [rsp+0x128]  spill-single-def ptr "field V159._reference (fldOffset=0x0)" P-INDEP
+;  V381 tmp341      [V381,T114] (  3,  6   )   byref  ->  [rsp+0x128]  spill-single-def ptr "field V159._reference (fldOffset=0x0)" P-INDEP
 ;* V382 tmp342      [V382    ] (  0,  0   )     int  ->  zero-ref    ptr "field V159._length (fldOffset=0x8)" P-INDEP
 ;  V383 tmp343      [V383,T159] (  2,  4   )   byref  ->  [rsp+0x120]  spill-single-def ptr "field V163._reference (fldOffset=0x0)" P-INDEP
-;  V384 tmp344      [V384,T131] (  3,  6   )     int  ->  [rsp+0x240]  spill-single-def ptr "field V163._length (fldOffset=0x8)" P-INDEP
+;  V384 tmp344      [V384,T130] (  3,  6   )     int  ->  [rsp+0x240]  spill-single-def ptr "field V163._length (fldOffset=0x8)" P-INDEP
 ;* V385 tmp345      [V385    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V164._reference (fldOffset=0x0)" P-INDEP
 ;* V386 tmp346      [V386    ] (  0,  0   )     int  ->  zero-ref    "field V164._length (fldOffset=0x8)" P-INDEP
 ;  V387 tmp347      [V387,T160] (  2,  4   )   byref  ->  [rsp+0x118]  spill-single-def ptr "field V169._reference (fldOffset=0x0)" P-INDEP
-;  V388 tmp348      [V388,T132] (  3,  6   )     int  ->  [rsp+0x23C]  spill-single-def ptr "field V169._length (fldOffset=0x8)" P-INDEP
+;  V388 tmp348      [V388,T131] (  3,  6   )     int  ->  [rsp+0x23C]  spill-single-def ptr "field V169._length (fldOffset=0x8)" P-INDEP
 ;* V389 tmp349      [V389    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V170._reference (fldOffset=0x0)" P-INDEP
 ;* V390 tmp350      [V390    ] (  0,  0   )     int  ->  zero-ref    ptr "field V170._length (fldOffset=0x8)" P-INDEP
 ;* V391 tmp351      [V391    ] (  0,  0   )   byref  ->  zero-ref    "field V171._reference (fldOffset=0x0)" P-INDEP
 ;* V392 tmp352      [V392    ] (  0,  0   )     int  ->  zero-ref    "field V171._length (fldOffset=0x8)" P-INDEP
 ;* V393 tmp353      [V393    ] (  0,  0   )   byref  ->  zero-ref    "field V172._reference (fldOffset=0x0)" P-INDEP
 ;* V394 tmp354      [V394    ] (  0,  0   )     int  ->  zero-ref    "field V172._length (fldOffset=0x8)" P-INDEP
-;  V395 tmp355      [V395,T116] (  3,  6   )   byref  ->  [rsp+0x110]  ptr "field V173._reference (fldOffset=0x0)" P-INDEP
-;  V396 tmp356      [V396,T133] (  3,  6   )     int  ->  [rsp+0x238]  ptr "field V173._length (fldOffset=0x8)" P-INDEP
+;  V395 tmp355      [V395,T115] (  3,  6   )   byref  ->  [rsp+0x110]  ptr "field V173._reference (fldOffset=0x0)" P-INDEP
+;  V396 tmp356      [V396,T132] (  3,  6   )     int  ->  [rsp+0x238]  ptr "field V173._length (fldOffset=0x8)" P-INDEP
 ;  V397 tmp357      [V397,T161] (  2,  4   )   byref  ->  [rsp+0x108]  spill-single-def ptr "field V175._reference (fldOffset=0x0)" P-INDEP
 ;  V398 tmp358      [V398,T178] (  2,  4   )     int  ->  [rsp+0x234]  spill-single-def ptr "field V175._length (fldOffset=0x8)" P-INDEP
 ;* V399 tmp359      [V399    ] (  0,  0   )   byref  ->  zero-ref    "field V176._reference (fldOffset=0x0)" P-INDEP
 ;* V400 tmp360      [V400    ] (  0,  0   )     int  ->  zero-ref    "field V176._length (fldOffset=0x8)" P-INDEP
-;  V401 tmp361      [V401,T117] (  3,  6   )   byref  ->  [rsp+0x100]  spill-single-def ptr "field V183._reference (fldOffset=0x0)" P-INDEP
+;  V401 tmp361      [V401,T116] (  3,  6   )   byref  ->  [rsp+0x100]  spill-single-def ptr "field V183._reference (fldOffset=0x0)" P-INDEP
 ;* V402 tmp362      [V402    ] (  0,  0   )     int  ->  zero-ref    ptr "field V183._length (fldOffset=0x8)" P-INDEP
 ;  V403 tmp363      [V403,T162] (  2,  4   )   byref  ->  [rsp+0xF8]  spill-single-def ptr "field V187._reference (fldOffset=0x0)" P-INDEP
-;  V404 tmp364      [V404,T134] (  3,  6   )     int  ->  [rsp+0x230]  spill-single-def ptr "field V187._length (fldOffset=0x8)" P-INDEP
+;  V404 tmp364      [V404,T133] (  3,  6   )     int  ->  [rsp+0x230]  spill-single-def ptr "field V187._length (fldOffset=0x8)" P-INDEP
 ;* V405 tmp365      [V405    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V188._reference (fldOffset=0x0)" P-INDEP
 ;* V406 tmp366      [V406    ] (  0,  0   )     int  ->  zero-ref    "field V188._length (fldOffset=0x8)" P-INDEP
 ;  V407 tmp367      [V407,T163] (  2,  4   )   byref  ->  [rsp+0xF0]  spill-single-def ptr "field V193._reference (fldOffset=0x0)" P-INDEP
-;  V408 tmp368      [V408,T135] (  3,  6   )     int  ->  [rsp+0x22C]  spill-single-def ptr "field V193._length (fldOffset=0x8)" P-INDEP
+;  V408 tmp368      [V408,T134] (  3,  6   )     int  ->  [rsp+0x22C]  spill-single-def ptr "field V193._length (fldOffset=0x8)" P-INDEP
 ;* V409 tmp369      [V409    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V194._reference (fldOffset=0x0)" P-INDEP
 ;* V410 tmp370      [V410    ] (  0,  0   )     int  ->  zero-ref    ptr "field V194._length (fldOffset=0x8)" P-INDEP
 ;* V411 tmp371      [V411    ] (  0,  0   )   byref  ->  zero-ref    "field V195._reference (fldOffset=0x0)" P-INDEP
 ;* V412 tmp372      [V412    ] (  0,  0   )     int  ->  zero-ref    "field V195._length (fldOffset=0x8)" P-INDEP
 ;* V413 tmp373      [V413    ] (  0,  0   )   byref  ->  zero-ref    "field V196._reference (fldOffset=0x0)" P-INDEP
 ;* V414 tmp374      [V414    ] (  0,  0   )     int  ->  zero-ref    "field V196._length (fldOffset=0x8)" P-INDEP
-;  V415 tmp375      [V415,T118] (  3,  6   )   byref  ->  [rsp+0xE8]  ptr "field V197._reference (fldOffset=0x0)" P-INDEP
-;  V416 tmp376      [V416,T136] (  3,  6   )     int  ->  [rsp+0x228]  ptr "field V197._length (fldOffset=0x8)" P-INDEP
+;  V415 tmp375      [V415,T117] (  3,  6   )   byref  ->  [rsp+0xE8]  ptr "field V197._reference (fldOffset=0x0)" P-INDEP
+;  V416 tmp376      [V416,T135] (  3,  6   )     int  ->  [rsp+0x228]  ptr "field V197._length (fldOffset=0x8)" P-INDEP
 ;  V417 tmp377      [V417,T164] (  2,  4   )   byref  ->  [rsp+0xE0]  spill-single-def ptr "field V199._reference (fldOffset=0x0)" P-INDEP
 ;  V418 tmp378      [V418,T179] (  2,  4   )     int  ->  [rsp+0x224]  spill-single-def ptr "field V199._length (fldOffset=0x8)" P-INDEP
 ;* V419 tmp379      [V419    ] (  0,  0   )   byref  ->  zero-ref    "field V200._reference (fldOffset=0x0)" P-INDEP
 ;* V420 tmp380      [V420    ] (  0,  0   )     int  ->  zero-ref    "field V200._length (fldOffset=0x8)" P-INDEP
-;  V421 tmp381      [V421,T119] (  3,  6   )   byref  ->  [rsp+0xD8]  spill-single-def ptr "field V207._reference (fldOffset=0x0)" P-INDEP
+;  V421 tmp381      [V421,T118] (  3,  6   )   byref  ->  [rsp+0xD8]  spill-single-def ptr "field V207._reference (fldOffset=0x0)" P-INDEP
 ;* V422 tmp382      [V422    ] (  0,  0   )     int  ->  zero-ref    ptr "field V207._length (fldOffset=0x8)" P-INDEP
 ;  V423 tmp383      [V423,T165] (  2,  4   )   byref  ->  [rsp+0xD0]  spill-single-def ptr "field V211._reference (fldOffset=0x0)" P-INDEP
-;  V424 tmp384      [V424,T137] (  3,  6   )     int  ->  [rsp+0x220]  spill-single-def ptr "field V211._length (fldOffset=0x8)" P-INDEP
+;  V424 tmp384      [V424,T136] (  3,  6   )     int  ->  [rsp+0x220]  spill-single-def ptr "field V211._length (fldOffset=0x8)" P-INDEP
 ;* V425 tmp385      [V425    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V212._reference (fldOffset=0x0)" P-INDEP
 ;* V426 tmp386      [V426    ] (  0,  0   )     int  ->  zero-ref    "field V212._length (fldOffset=0x8)" P-INDEP
 ;  V427 tmp387      [V427,T166] (  2,  4   )   byref  ->  [rsp+0xC8]  spill-single-def ptr "field V217._reference (fldOffset=0x0)" P-INDEP
-;  V428 tmp388      [V428,T138] (  3,  6   )     int  ->  [rsp+0x21C]  spill-single-def ptr "field V217._length (fldOffset=0x8)" P-INDEP
+;  V428 tmp388      [V428,T137] (  3,  6   )     int  ->  [rsp+0x21C]  spill-single-def ptr "field V217._length (fldOffset=0x8)" P-INDEP
 ;* V429 tmp389      [V429    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V218._reference (fldOffset=0x0)" P-INDEP
 ;* V430 tmp390      [V430    ] (  0,  0   )     int  ->  zero-ref    ptr "field V218._length (fldOffset=0x8)" P-INDEP
 ;* V431 tmp391      [V431    ] (  0,  0   )   byref  ->  zero-ref    "field V219._reference (fldOffset=0x0)" P-INDEP
 ;* V432 tmp392      [V432    ] (  0,  0   )     int  ->  zero-ref    "field V219._length (fldOffset=0x8)" P-INDEP
 ;* V433 tmp393      [V433    ] (  0,  0   )   byref  ->  zero-ref    "field V220._reference (fldOffset=0x0)" P-INDEP
 ;* V434 tmp394      [V434    ] (  0,  0   )     int  ->  zero-ref    "field V220._length (fldOffset=0x8)" P-INDEP
-;  V435 tmp395      [V435,T120] (  3,  6   )   byref  ->  [rsp+0xC0]  ptr "field V221._reference (fldOffset=0x0)" P-INDEP
-;  V436 tmp396      [V436,T139] (  3,  6   )     int  ->  [rsp+0x218]  ptr "field V221._length (fldOffset=0x8)" P-INDEP
+;  V435 tmp395      [V435,T119] (  3,  6   )   byref  ->  [rsp+0xC0]  ptr "field V221._reference (fldOffset=0x0)" P-INDEP
+;  V436 tmp396      [V436,T138] (  3,  6   )     int  ->  [rsp+0x218]  ptr "field V221._length (fldOffset=0x8)" P-INDEP
 ;  V437 tmp397      [V437,T167] (  2,  4   )   byref  ->   r8         "field V223._reference (fldOffset=0x0)" P-INDEP
 ;  V438 tmp398      [V438,T180] (  2,  4   )     int  ->  rdx         "field V223._length (fldOffset=0x8)" P-INDEP
 ;* V439 tmp399      [V439    ] (  0,  0   )   byref  ->  zero-ref    "field V224._reference (fldOffset=0x0)" P-INDEP
 ;* V440 tmp400      [V440    ] (  0,  0   )     int  ->  zero-ref    "field V224._length (fldOffset=0x8)" P-INDEP
-;  V441 tmp401      [V441,T121] (  3,  6   )   byref  ->  [rsp+0xB8]  spill-single-def ptr "field V231._reference (fldOffset=0x0)" P-INDEP
+;  V441 tmp401      [V441,T120] (  3,  6   )   byref  ->  [rsp+0xB8]  spill-single-def ptr "field V231._reference (fldOffset=0x0)" P-INDEP
 ;* V442 tmp402      [V442    ] (  0,  0   )     int  ->  zero-ref    ptr "field V231._length (fldOffset=0x8)" P-INDEP
 ;  V443 tmp403      [V443,T168] (  2,  4   )   byref  ->  [rsp+0xB0]  spill-single-def ptr "field V235._reference (fldOffset=0x0)" P-INDEP
-;  V444 tmp404      [V444,T140] (  3,  6   )     int  ->  [rsp+0x214]  spill-single-def ptr "field V235._length (fldOffset=0x8)" P-INDEP
+;  V444 tmp404      [V444,T139] (  3,  6   )     int  ->  [rsp+0x214]  spill-single-def ptr "field V235._length (fldOffset=0x8)" P-INDEP
 ;* V445 tmp405      [V445    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V236._reference (fldOffset=0x0)" P-INDEP
 ;* V446 tmp406      [V446    ] (  0,  0   )     int  ->  zero-ref    "field V236._length (fldOffset=0x8)" P-INDEP
 ;  V447 tmp407      [V447,T169] (  2,  4   )   byref  ->  [rsp+0xA8]  spill-single-def ptr "field V241._reference (fldOffset=0x0)" P-INDEP
-;  V448 tmp408      [V448,T141] (  3,  6   )     int  ->  [rsp+0x210]  spill-single-def ptr "field V241._length (fldOffset=0x8)" P-INDEP
+;  V448 tmp408      [V448,T140] (  3,  6   )     int  ->  [rsp+0x210]  spill-single-def ptr "field V241._length (fldOffset=0x8)" P-INDEP
 ;* V449 tmp409      [V449    ] (  0,  0   )   byref  ->  zero-ref    ptr "field V242._reference (fldOffset=0x0)" P-INDEP
 ;* V450 tmp410      [V450    ] (  0,  0   )     int  ->  zero-ref    ptr "field V242._length (fldOffset=0x8)" P-INDEP
 ;  V451 tmp411      [V451,T76] (  2, 16   )   byref  ->  [rsp+0xA0]  spill-single-def ptr "field V245._reference (fldOffset=0x0)" P-INDEP
 ;  V452 tmp412      [V452,T56] (  3, 24   )     int  ->  rsi         "field V245._length (fldOffset=0x8)" P-INDEP
 ;  V453 tmp413      [V453,T170] (  2,  4   )   byref  ->  [rsp+0x98]  spill-single-def ptr "field V249._reference (fldOffset=0x0)" P-INDEP
-;  V454 tmp414      [V454,T142] (  3,  6   )     int  ->  [rsp+0x20C]  spill-single-def ptr "field V249._length (fldOffset=0x8)" P-INDEP
+;  V454 tmp414      [V454,T141] (  3,  6   )     int  ->  [rsp+0x20C]  spill-single-def ptr "field V249._length (fldOffset=0x8)" P-INDEP
 ;  V455 tmp415      [V455,T171] (  2,  4   )   byref  ->  [rsp+0x90]  spill-single-def ptr "field V252._reference (fldOffset=0x0)" P-INDEP
-;  V456 tmp416      [V456,T143] (  3,  6   )     int  ->  [rsp+0x208]  spill-single-def ptr "field V252._length (fldOffset=0x8)" P-INDEP
+;  V456 tmp416      [V456,T142] (  3,  6   )     int  ->  [rsp+0x208]  spill-single-def ptr "field V252._length (fldOffset=0x8)" P-INDEP
 ;  V457 tmp417      [V457,T172] (  2,  4   )   byref  ->  [rsp+0x88]  spill-single-def ptr "field V255._reference (fldOffset=0x0)" P-INDEP
-;  V458 tmp418      [V458,T144] (  3,  6   )     int  ->  [rsp+0x204]  spill-single-def ptr "field V255._length (fldOffset=0x8)" P-INDEP
+;  V458 tmp418      [V458,T143] (  3,  6   )     int  ->  [rsp+0x204]  spill-single-def ptr "field V255._length (fldOffset=0x8)" P-INDEP
 ;  V459 tmp419      [V459,T173] (  2,  4   )   byref  ->  [rsp+0x80]  spill-single-def ptr "field V259._reference (fldOffset=0x0)" P-INDEP
-;  V460 tmp420      [V460,T145] (  3,  6   )     int  ->  [rsp+0x200]  spill-single-def ptr "field V259._length (fldOffset=0x8)" P-INDEP
+;  V460 tmp420      [V460,T144] (  3,  6   )     int  ->  [rsp+0x200]  spill-single-def ptr "field V259._length (fldOffset=0x8)" P-INDEP
 ;  V461 tmp421      [V461,T77] (  2, 16   )   byref  ->  [rsp+0x78]  spill-single-def ptr "field V263._reference (fldOffset=0x0)" P-INDEP
 ;  V462 tmp422      [V462,T57] (  3, 24   )     int  ->  rbx         "field V263._length (fldOffset=0x8)" P-INDEP
 ;  V463 tmp423      [V463,T174] (  2,  4   )   byref  ->  [rsp+0x70]  spill-single-def ptr "field V266._reference (fldOffset=0x0)" P-INDEP
-;  V464 tmp424      [V464,T146] (  3,  6   )     int  ->  [rsp+0x1FC]  spill-single-def ptr "field V266._length (fldOffset=0x8)" P-INDEP
+;  V464 tmp424      [V464,T145] (  3,  6   )     int  ->  [rsp+0x1FC]  spill-single-def ptr "field V266._length (fldOffset=0x8)" P-INDEP
 ;* V465 tmp425      [V465    ] (  0,  0   )   byref  ->  zero-ref    "field V268._reference (fldOffset=0x0)" P-INDEP
 ;* V466 tmp426      [V466    ] (  0,  0   )     int  ->  zero-ref    "field V268._length (fldOffset=0x8)" P-INDEP
 ;* V467 tmp427      [V467    ] (  0,  0   )   byref  ->  zero-ref    "field V269._reference (fldOffset=0x0)" P-INDEP
@@ -1013,13 +1013,11 @@ G_M54741_IG53:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000
        je       SHORT G_M54741_IG54
        mov      r12, gword ptr [rsp+0x1D8]
        ; gcrRegs +[r12]
-       cmp      dword ptr [r12+0x08], 0
-       jbe      G_M54741_IG179
        mov      r12d, dword ptr [r12+0x10]
        ; gcrRegs -[r12]
        mov      dword ptr [rsp+0x2E8], r12d
-						;; size=121 bbWeight=0.50 PerfScore 13.38
-G_M54741_IG54:        ; bbWeight=0.50, gcVars=0000000000000000000000000000000000020000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
+						;; size=109 bbWeight=0.50 PerfScore 11.38
+G_M54741_IG54:        ; bbWeight=0.50, gcVars=0000000000000000000000000004000000000000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
        mov      r12d, dword ptr [rsp+0x2E8]
        mov      dword ptr [rsp+0x2E0], r12d
        xor      r12d, r12d
@@ -1078,7 +1076,7 @@ G_M54741_IG56:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14},
        ; GC ptr vars +{V289}
        mov      r9d, dword ptr [rsp+0x328]
 						;; size=98 bbWeight=2 PerfScore 29.50
-G_M54741_IG57:        ; bbWeight=4, gcVars=0000000000000000000000000000000000020000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG57:        ; bbWeight=4, gcVars=0000000000000000000000000004000000000000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; byrRegs -[rdx r12 r14]
        mov      ecx, dword ptr [rsp+0x300]
        mov      dword ptr [rsp+0x260], ebx
@@ -1331,7 +1329,7 @@ G_M54741_IG76:        ; bbWeight=0.25, gcVars=0000000000000000000000000000000000
 G_M54741_IG77:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=5020 {rbp r12 r14}, byref
        jmp      G_M54741_IG64
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M54741_IG78:        ; bbWeight=2, gcVars=0000000000000000000000000000000000020000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
+G_M54741_IG78:        ; bbWeight=2, gcVars=0000000000000000000000000004000000000000000000006800080000000000 {V26 V289 V481 V489 V491}, gcrefRegs=0000 {}, byrefRegs=4020 {rbp r14}, gcvars, byref
        ; byrRegs -[r12]
        ; GC ptr vars +{V26}
        jmp      G_M54741_IG57
@@ -1805,7 +1803,7 @@ G_M54741_IG117:        ; bbWeight=2, gcVars=000000000000000000000000000000000000
        ; byrRegs -[rdx]
        mov      dword ptr [rsp+0x248], edx
 						;; size=90 bbWeight=2 PerfScore 26.50
-G_M54741_IG118:        ; bbWeight=2, gcVars=0000000000000000000000000000000000040000000000006800000000000000 {V289 V375 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG118:        ; bbWeight=2, gcVars=0000000000000000000000000000000000020000000000006800000000000000 {V289 V375 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; GC ptr vars -{V68 V150 V154 V377}
        mov      rdx, bword ptr [rsp+0x138]
        ; byrRegs +[rdx]
@@ -1967,7 +1965,7 @@ G_M54741_IG127:        ; bbWeight=2, gcVars=000000000000000000000000000000000000
        ; byrRegs -[r8]
        mov      dword ptr [rsp+0x238], r8d
 						;; size=96 bbWeight=2 PerfScore 26.50
-G_M54741_IG128:        ; bbWeight=2, gcVars=0000000000000000000000000000000000100000000000006800000000000000 {V289 V395 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
+G_M54741_IG128:        ; bbWeight=2, gcVars=0000000000000000000000000000000000080000000000006800000000000000 {V289 V395 V489 V491}, gcrefRegs=0000 {}, byrefRegs=0020 {rbp}, gcvars, byref, isz
        ; GC ptr vars -{V174 V178 V397}
        mov      r8, bword ptr [rsp+0x110]
...

```


</div></details>

<details>
<summary><span style="color:green">-9</span> (<span style="color:green">-0.10%</span>) : 11561.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,7 +16,7 @@
 ;  V06 arg6         [V06,T90] (  6,  7   )     ref  ->  [rbp+0x40]  class-hnd single-def <System.String[]>
 ;  V07 arg7         [V07,T115] (  3,  2   )   byref  ->  [rbp+0x48]  single-def
 ;  V08 loc0         [V08,T23] ( 26, 33.48)     ref  ->  r15         class-hnd single-def <System.Reflection.MethodBase[]>
-;  V09 loc1         [V09,T01] (120,226.49)     int  ->  [rbp-0x3C] 
+;  V09 loc1         [V09,T01] (119,226.45)     int  ->  [rbp-0x3C] 
 ;  V10 loc2         [V10,T00] (100,417.48)     int  ->  [rbp-0x40] 
 ;  V11 loc3         [V11,T12] ( 46, 53.80)     ref  ->  r12         class-hnd exact single-def <<unknown class>>
 ;  V12 loc4         [V12,T22] ( 37, 36.27)     ref  ->  [rbp-0xC0]  class-hnd exact spill-single-def <System.Type[]>
@@ -179,7 +179,7 @@
 ;  V169 cse7        [V169,T79] (  3,  9.90)     ref  ->  rcx         "CSE - conservative"
 ;  V170 cse8        [V170,T114] (  3,  2.97)     ref  ->  rcx         "CSE - conservative"
 ;  V171 cse9        [V171,T10] ( 28, 72.16)     int  ->  [rbp-0xB4]  multi-def "CSE - aggressive"
-;  V172 cse10       [V172,T27] ( 28, 26.89)     int  ->  r13         "CSE - moderate"
+;  V172 cse10       [V172,T27] ( 27, 26.85)     int  ->  r13         "CSE - moderate"
 ;  V173 cse11       [V173,T37] ( 37, 19.36)     int  ->  [rbp-0xB8]  hoist multi-def "CSE - moderate"
 ;
 ; Lcl frame size = 264
@@ -360,8 +360,6 @@ G_M46529_IG16:        ; bbWeight=1.98, gcrefRegs=9040 {rsi r12 r15}, byrefRegs=4
        jmp      G_M46529_IG29
 						;; size=5 bbWeight=1.98 PerfScore 3.96
 G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=9040 {rsi r12 r15}, byrefRegs=4008 {rbx r14}, byref, isz
-       cmp      eax, r13d
-       jae      G_M46529_IG204
        mov      dword ptr [rbp-0x3C], eax
        mov      ecx, eax
        mov      rcx, gword ptr [r15+8*rcx+0x10]
@@ -376,7 +374,7 @@ G_M46529_IG17:        ; bbWeight=0.04, gcrefRegs=9040 {rsi r12 r15}, byrefRegs=4
        ; gcrRegs +[rcx]
        cmp      edx, dword ptr [rcx+0x08]
        jg       SHORT G_M46529_IG19
-						;; size=41 bbWeight=0.04 PerfScore 0.68
+						;; size=32 bbWeight=0.04 PerfScore 0.63
 G_M46529_IG18:        ; bbWeight=0.02, gcrefRegs=9040 {rsi r12 r15}, byrefRegs=4008 {rbx r14}, byref, isz
        ; gcrRegs -[rcx]
        mov      rdx, gword ptr [rbx]
@@ -3780,7 +3778,7 @@ G_M46529_IG207:        ; bbWeight=0, gcrefRegs=8000 {r15}, byrefRegs=0000 {}, by
        int3     
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 8652, prolog size 78, PerfScore 4586.65, instruction count 2128, allocated bytes for code 8652 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
+; Total bytes of code 8643, prolog size 78, PerfScore 4586.60, instruction count 2126, allocated bytes for code 8643 (MethodHash=29b54a3e) for method System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

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
|benchmarks.run.windows.x64.checked.mch|1,293|<span style="color:green">1,292</span>|<span style="color:red">0</span>|<span style="color:blue">1</span>|<span style="color:green">-26,364</span>|<span style="color:red">+0</span>|<span style="color:green">-0.1268%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|2,565|<span style="color:green">2,565</span>|<span style="color:red">0</span>|<span style="color:blue">0</span>|<span style="color:green">-34,747</span>|<span style="color:red">+0</span>|<span style="color:green">-0.1401%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|318|<span style="color:green">318</span>|<span style="color:red">0</span>|<span style="color:blue">0</span>|<span style="color:green">-7,268</span>|<span style="color:red">+0</span>|<span style="color:green">-0.0668%</span>|
|coreclr_tests.run.windows.x64.checked.mch|3,458|<span style="color:green">3,457</span>|<span style="color:red">0</span>|<span style="color:blue">1</span>|<span style="color:green">-71,501</span>|<span style="color:red">+0</span>|<span style="color:green">-0.0633%</span>|
|libraries.crossgen2.windows.x64.checked.mch|2,494|<span style="color:green">2,492</span>|<span style="color:red">2</span>|<span style="color:blue">0</span>|<span style="color:green">-39,891</span>|<span style="color:red">+40</span>|<span style="color:green">-0.0246%</span>|
|libraries.pmi.windows.x64.checked.mch|4,909|<span style="color:green">4,907</span>|<span style="color:red">2</span>|<span style="color:blue">0</span>|<span style="color:green">-75,252</span>|<span style="color:red">+83</span>|<span style="color:green">-0.0508%</span>|
|libraries_tests.run.windows.x64.Release.mch|16,496|<span style="color:green">16,470</span>|<span style="color:red">26</span>|<span style="color:blue">0</span>|<span style="color:green">-296,906</span>|<span style="color:red">+849</span>|<span style="color:green">-0.1802%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|6,683|<span style="color:green">6,677</span>|<span style="color:red">3</span>|<span style="color:blue">3</span>|<span style="color:green">-121,066</span>|<span style="color:red">+47</span>|<span style="color:green">-0.0561%</span>|
|realworld.run.windows.x64.checked.mch|1,216|<span style="color:green">1,215</span>|<span style="color:red">1</span>|<span style="color:blue">0</span>|<span style="color:green">-21,044</span>|<span style="color:red">+4</span>|<span style="color:green">-0.0976%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|932|<span style="color:green">932</span>|<span style="color:red">0</span>|<span style="color:blue">0</span>|<span style="color:green">-18,093</span>|<span style="color:red">+0</span>|<span style="color:green">-0.1107%</span>|
||40,364|<span style="color:green">40,325</span>|<span style="color:red">34</span>|<span style="color:blue">5</span>|<span style="color:green">-712,132</span>|<span style="color:red">+1,023</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,911|4|35,907|188 (0.52%)|188 (0.52%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,827|49,607|52,220|33 (0.03%)|33 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|55,006|37,307|17,699|36 (0.07%)|36 (0.07%)|
|coreclr_tests.run.windows.x64.checked.mch|581,524|347,882|233,642|2,567 (0.44%)|2,567 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,705|15|275,690|65 (0.02%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|313,093|6|313,087|1,206 (0.38%)|1,206 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|697,494|498,513|198,981|2,679 (0.38%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|320,777|21,946|298,831|118 (0.04%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,689|3|36,686|214 (0.58%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,537|11|32,526|41 (0.13%)|41 (0.13%)|
||2,450,563|955,294|1,495,269|7,147 (0.29%)|7,147 (0.29%)|


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

Total bytes of base: 11443296 (overridden on cmd)
Total bytes of diff: 11416932 (overridden on cmd)
Total bytes of delta: -26364 (-0.23 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file improvements (bytes):
        -754 : 8780.dasm (-2.41% of base)
        -515 : 3668.dasm (-1.52% of base)
        -381 : 12986.dasm (-20.84% of base)
        -381 : 629.dasm (-20.84% of base)
        -372 : 13806.dasm (-21.87% of base)
        -372 : 4500.dasm (-21.87% of base)
        -200 : 22647.dasm (-30.12% of base)
        -186 : 18280.dasm (-16.76% of base)
        -181 : 18310.dasm (-16.76% of base)
        -172 : 3567.dasm (-17.95% of base)
        -148 : 10765.dasm (-9.28% of base)
        -148 : 19179.dasm (-9.30% of base)
        -133 : 23880.dasm (-13.41% of base)
        -128 : 23681.dasm (-29.22% of base)
        -126 : 35942.dasm (-10.03% of base)
        -117 : 22710.dasm (-7.68% of base)
        -117 : 23409.dasm (-7.67% of base)
        -111 : 8971.dasm (-4.69% of base)
        -102 : 7970.dasm (-28.10% of base)
        -102 : 20566.dasm (-28.10% of base)

89 total files with Code Size differences (89 improved, 0 regressed), 1 unchanged.

Top method improvements (bytes):
        -754 (-2.41% of base) : 8780.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -515 (-1.52% of base) : 3668.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -381 (-20.84% of base) : 12986.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -381 (-20.84% of base) : 629.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -372 (-21.87% of base) : 13806.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -372 (-21.87% of base) : 4500.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -200 (-30.12% of base) : 22647.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeG(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (FullOpts)
        -186 (-16.76% of base) : 18280.dasm - System.Linq.Enumerable:MinMaxInteger[ulong,System.Linq.Enumerable+MinCalc`1[ulong]](System.Collections.Generic.IEnumerable`1[ulong]):ulong (FullOpts)
        -181 (-16.76% of base) : 18310.dasm - System.Linq.Enumerable:MinMaxInteger[int,System.Linq.Enumerable+MinCalc`1[int]](System.Collections.Generic.IEnumerable`1[int]):int (FullOpts)
        -172 (-17.95% of base) : 3567.dasm - System.Linq.Enumerable:MinMaxInteger[int,System.Linq.Enumerable+MinCalc`1[int]](System.Collections.Generic.IEnumerable`1[int]):int (FullOpts)
        -148 (-9.28% of base) : 10765.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (FullOpts)
        -148 (-9.30% of base) : 19179.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (FullOpts)
        -133 (-13.41% of base) : 23880.dasm - System.Net.WebUtility:UrlDecodeInternal(System.String,System.Text.Encoding):System.String (FullOpts)
        -128 (-29.22% of base) : 23681.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt16X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
        -126 (-10.03% of base) : 35942.dasm - System.DateTimeParse:TryParseFormatO(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -117 (-7.68% of base) : 22710.dasm - Algorithms.VectorFloatRenderer:RenderSingleThreadedNoADT(float,float,float,float,float):this (FullOpts)
        -117 (-7.67% of base) : 23409.dasm - Algorithms.VectorFloatRenderer:RenderSingleThreadedWithADT(float,float,float,float,float):this (FullOpts)
        -111 (-4.69% of base) : 8971.dasm - BilinearTest:BilinearInterpol_Vector(double[],double[],double,double,double[],double,double,double):double[]:this (FullOpts)
        -102 (-28.10% of base) : 7970.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 20566.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)

Top method improvements (percentages):
         -18 (-31.03% of base) : 27052.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
        -200 (-30.12% of base) : 22647.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeG(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (FullOpts)
         -20 (-29.41% of base) : 10576.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
         -20 (-29.41% of base) : 18941.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
        -128 (-29.22% of base) : 23681.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt16X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 7970.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 20566.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
         -25 (-27.78% of base) : 388.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 12745.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -88 (-26.19% of base) : 7969.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -88 (-26.19% of base) : 20565.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -88 (-25.29% of base) : 13567.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt64X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -88 (-25.29% of base) : 9580.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt64X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -16 (-25.00% of base) : 30317.dasm - Span.IndexerBench:TestIndexer1(System.Span`1[ubyte]):ubyte (FullOpts)
         -16 (-25.00% of base) : 2967.dasm - Span.IndexerBench:TestReadOnlyIndexer1(System.ReadOnlySpan`1[ubyte]):ubyte (FullOpts)
         -50 (-23.26% of base) : 14523.dasm - System.Net.Security.TlsFrameHelper:TryGetFrameHeader(System.ReadOnlySpan`1[ubyte],byref):ubyte (FullOpts)
         -50 (-23.26% of base) : 6220.dasm - System.Net.Security.TlsFrameHelper:TryGetFrameHeader(System.ReadOnlySpan`1[ubyte],byref):ubyte (FullOpts)
         -13 (-23.21% of base) : 32330.dasm - System.Collections.IterateFor`1[System.__Canon]:ImmutableArray():System.__Canon:this (FullOpts)
         -14 (-22.95% of base) : 30854.dasm - System.Tests.Perf_Char:GetUnicodeCategory(ushort):int:this (FullOpts)
         -11 (-22.00% of base) : 23822.dasm - Struct.SpanWrapper:SumSpan(System.ReadOnlySpan`1[int]):int:this (FullOpts)

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

Total bytes of base: 35491760 (overridden on cmd)
Total bytes of diff: 35457013 (overridden on cmd)
Total bytes of delta: -34747 (-0.10 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file improvements (bytes):
        -754 : 26827.dasm (-2.41% of base)
        -515 : 14942.dasm (-1.52% of base)
        -126 : 29219.dasm (-3.62% of base)
        -126 : 94534.dasm (-3.90% of base)
        -126 : 90924.dasm (-3.90% of base)
        -126 : 69906.dasm (-3.90% of base)
        -126 : 37397.dasm (-3.61% of base)
        -126 : 73511.dasm (-3.90% of base)
         -93 : 51903.dasm (-1.84% of base)
         -82 : 88097.dasm (-2.61% of base)
         -72 : 30003.dasm (-2.80% of base)
         -71 : 88113.dasm (-4.12% of base)
         -65 : 38016.dasm (-0.54% of base)
         -64 : 41084.dasm (-25.81% of base)
         -64 : 36969.dasm (-25.81% of base)
         -63 : 51040.dasm (-1.29% of base)
         -63 : 49678.dasm (-1.32% of base)
         -61 : 81774.dasm (-4.34% of base)
         -61 : 43638.dasm (-24.40% of base)
         -61 : 47584.dasm (-24.50% of base)

88 total files with Code Size differences (88 improved, 0 regressed), 0 unchanged.

Top method improvements (bytes):
        -754 (-2.41% of base) : 26827.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -515 (-1.52% of base) : 14942.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -126 (-3.62% of base) : 29219.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -126 (-3.90% of base) : 94534.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -126 (-3.90% of base) : 90924.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -126 (-3.90% of base) : 69906.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -126 (-3.61% of base) : 37397.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -126 (-3.90% of base) : 73511.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
         -93 (-1.84% of base) : 51903.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -82 (-2.61% of base) : 88097.dasm - System.Buffers.StringSearchValues:Create(System.ReadOnlySpan`1[System.String],ubyte):System.Buffers.SearchValues`1[System.String] (Tier1)
         -72 (-2.80% of base) : 30003.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -71 (-4.12% of base) : 88113.dasm - System.Buffers.StringSearchValues:CreateForSingleValue(System.String,System.Collections.Generic.HashSet`1[System.String],ubyte,ubyte,ubyte):System.Buffers.SearchValues`1[System.String] (Tier1)
         -65 (-0.54% of base) : 38016.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
         -64 (-25.81% of base) : 41084.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -64 (-25.81% of base) : 36969.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -63 (-1.29% of base) : 51040.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -63 (-1.32% of base) : 49678.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -61 (-24.40% of base) : 43638.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -61 (-24.50% of base) : 47584.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -61 (-4.34% of base) : 81774.dasm - System.IO.PathHelper:Normalize(System.String):System.String (Tier1)

Top method improvements (percentages):
         -13 (-28.89% of base) : 51977.dasm - System.Text.Json.JsonWriterHelper:NeedsEscaping(ubyte):ubyte (Tier1)
         -24 (-27.27% of base) : 81748.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 41510.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 32948.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 10764.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 16953.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 44934.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 53746.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -10 (-27.03% of base) : 67330.dasm - System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (Tier1)
         -64 (-25.81% of base) : 41084.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -64 (-25.81% of base) : 36969.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -61 (-24.50% of base) : 47584.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -61 (-24.40% of base) : 43638.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -13 (-22.81% of base) : 53927.dasm - System.Text.RegularExpressions.RegexParser:IsQuantifier(ushort):ubyte (Tier1)
         -13 (-22.81% of base) : 100424.dasm - System.Text.RegularExpressions.RegexParser:IsQuantifier(ushort):ubyte (Tier1)
         -13 (-22.81% of base) : 100423.dasm - System.Text.RegularExpressions.RegexParser:IsSpecial(ushort):ubyte (Tier1)
         -13 (-22.81% of base) : 95078.dasm - System.Text.RegularExpressions.RegexParser:IsSpecial(ushort):ubyte (Tier1)
         -13 (-22.81% of base) : 23885.dasm - System.Text.RegularExpressions.RegexParser:IsSpecial(ushort):ubyte (Tier1)
         -13 (-22.81% of base) : 97669.dasm - System.Text.RegularExpressions.RegexParser:IsSpecial(ushort):ubyte (Tier1)
         -13 (-22.81% of base) : 53926.dasm - System.Text.RegularExpressions.RegexParser:IsSpecial(ushort):ubyte (Tier1)

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

Total bytes of base: 12718511 (overridden on cmd)
Total bytes of diff: 12711243 (overridden on cmd)
Total bytes of delta: -7268 (-0.06 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file improvements (bytes):
        -754 : 18079.dasm (-2.41% of base)
        -515 : 16786.dasm (-1.52% of base)
        -381 : 8857.dasm (-20.84% of base)
        -113 : 31031.dasm (-8.44% of base)
        -113 : 29505.dasm (-8.44% of base)
         -96 : 32239.dasm (-1.98% of base)
         -72 : 8856.dasm (-13.46% of base)
         -72 : 23635.dasm (-3.09% of base)
         -69 : 12504.dasm (-12.06% of base)
         -67 : 47512.dasm (-17.22% of base)
         -66 : 31896.dasm (-1.39% of base)
         -66 : 31791.dasm (-1.43% of base)
         -65 : 25881.dasm (-0.54% of base)
         -61 : 25586.dasm (-24.50% of base)
         -57 : 31567.dasm (-4.85% of base)
         -57 : 32315.dasm (-5.00% of base)
         -57 : 34921.dasm (-8.93% of base)
         -56 : 44094.dasm (-1.48% of base)
         -50 : 8939.dasm (-23.26% of base)
         -49 : 25587.dasm (-28.49% of base)

85 total files with Code Size differences (85 improved, 0 regressed), 0 unchanged.

Top method improvements (bytes):
        -754 (-2.41% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -515 (-1.52% of base) : 16786.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -381 (-20.84% of base) : 8857.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -113 (-8.44% of base) : 29505.dasm - Algorithms.VectorFloatRenderer:RenderSingleThreadedNoADT(float,float,float,float,float):this (Tier1-OSR)
        -113 (-8.44% of base) : 31031.dasm - Algorithms.VectorFloatRenderer:RenderSingleThreadedWithADT(float,float,float,float,float):this (Tier1-OSR)
         -96 (-1.98% of base) : 32239.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -72 (-13.46% of base) : 8856.dasm - System.Guid:TryParseGuid(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
         -72 (-3.09% of base) : 23635.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -69 (-12.06% of base) : 12504.dasm - System.IO.Path:Populate83FileNameFromRandomBytes(ulong,int,System.Span`1[ushort]) (Tier1)
         -67 (-17.22% of base) : 47512.dasm - System.IO.PathInternal:GetRootLength(System.ReadOnlySpan`1[ushort]):int (Tier1)
         -66 (-1.39% of base) : 31896.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -66 (-1.43% of base) : 31791.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -65 (-0.54% of base) : 25881.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
         -61 (-24.50% of base) : 25586.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -57 (-4.85% of base) : 31567.dasm - Algorithms.VectorDoubleRenderer:RenderSingleThreadedNoADT(float,float,float,float,float):this (Tier1-OSR)
         -57 (-5.00% of base) : 32315.dasm - Algorithms.VectorDoubleRenderer:RenderSingleThreadedWithADT(float,float,float,float,float):this (Tier1-OSR)
         -57 (-8.93% of base) : 34921.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken:Create(ushort,Microsoft.CodeAnalysis.GreenNode,Microsoft.CodeAnalysis.GreenNode):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken (Tier1)
         -56 (-1.48% of base) : 44094.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParsePostFixExpression(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax:this (Tier1)
         -50 (-23.26% of base) : 8939.dasm - System.Net.Security.TlsFrameHelper:TryGetFrameHeader(System.ReadOnlySpan`1[ubyte],byref):ubyte (Tier1)
         -49 (-28.49% of base) : 25587.dasm - SeekUnroll:FindByte(byref):int (Tier1)

Top method improvements (percentages):
         -49 (-28.49% of base) : 25587.dasm - SeekUnroll:FindByte(byref):int (Tier1)
         -25 (-27.78% of base) : 4053.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -10 (-27.03% of base) : 40739.dasm - System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (Tier1)
         -61 (-24.50% of base) : 25586.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -24 (-23.30% of base) : 5594.dasm - System.Guid:DecodeByte(ushort,ushort,byref):ubyte (Tier1)
         -50 (-23.26% of base) : 8939.dasm - System.Net.Security.TlsFrameHelper:TryGetFrameHeader(System.ReadOnlySpan`1[ubyte],byref):ubyte (Tier1)
         -13 (-22.03% of base) : 30507.dasm - System.Text.RegularExpressions.RegexParser:IsQuantifier(ushort):ubyte (Tier1)
         -13 (-22.03% of base) : 30505.dasm - System.Text.RegularExpressions.RegexParser:IsSpecial(ushort):ubyte (Tier1)
         -14 (-21.54% of base) : 30523.dasm - System.Char:GetUnicodeCategory(ushort):int (Tier1)
        -381 (-20.84% of base) : 8857.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
         -13 (-20.63% of base) : 47520.dasm - System.IO.Path:EndsInDirectorySeparator(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -14 (-20.59% of base) : 2308.dasm - System.Char:IsWhiteSpace(ushort):ubyte (Tier1)
         -17 (-19.77% of base) : 30802.dasm - System.Text.RegularExpressions.RegexCharClass:CanEasilyEnumerateSetContents(System.String,byref):ubyte (Tier1)
         -13 (-19.70% of base) : 47502.dasm - System.IO.PathInternal:EndsInDirectorySeparator(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -19 (-19.39% of base) : 12507.dasm - System.IO.Path:IsPathRooted(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -37 (-19.07% of base) : 4049.dasm - System.IO.PathInternal:IsPartiallyQualified(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -13 (-18.84% of base) : 8391.dasm - System.IO.PathInternal:EndsInDirectorySeparator(System.String):ubyte (Tier1)
         -38 (-18.81% of base) : 5593.dasm - System.MemoryExtensions:Trim(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ushort] (Tier1)
         -15 (-18.75% of base) : 48849.dasm - System.Text.RegularExpressions.RegexPrefixAnalyzer:<SortFixedDistanceSetsByQuality>g__SumFrequencies|3_2(ushort[]):float (Tier1)
         -11 (-18.33% of base) : 43966.dasm - Roslyn.Utilities.Hash:CombineFNVHash(int,System.ReadOnlySpan`1[ushort]):int (Tier1)

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

Total bytes of base: 386883600 (overridden on cmd)
Total bytes of diff: 386812099 (overridden on cmd)
Total bytes of delta: -71501 (-0.02 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file improvements (bytes):
        -616 : 180449.dasm (-24.83% of base)
        -603 : 180775.dasm (-16.69% of base)
        -603 : 180779.dasm (-16.69% of base)
        -380 : 315780.dasm (-17.88% of base)
        -317 : 180532.dasm (-7.94% of base)
        -261 : 180165.dasm (-10.20% of base)
        -252 : 160983.dasm (-14.47% of base)
        -172 : 197155.dasm (-17.95% of base)
        -148 : 306525.dasm (-3.16% of base)
        -144 : 180811.dasm (-5.84% of base)
        -144 : 180827.dasm (-6.55% of base)
        -144 : 196749.dasm (-8.85% of base)
        -144 : 180815.dasm (-6.55% of base)
        -135 : 158199.dasm (-15.19% of base)
        -131 : 180891.dasm (-12.71% of base)
        -125 : 579498.dasm (-11.56% of base)
        -125 : 551894.dasm (-11.56% of base)
        -125 : 501531.dasm (-11.56% of base)
        -125 : 563496.dasm (-11.56% of base)
        -125 : 572416.dasm (-11.56% of base)

89 total files with Code Size differences (89 improved, 0 regressed), 1 unchanged.

Top method improvements (bytes):
        -616 (-24.83% of base) : 180449.dasm - VectorTest:TestEntryPoint():int (FullOpts)
        -603 (-16.69% of base) : 180775.dasm - VectorTest:TestEntryPoint():int (FullOpts)
        -603 (-16.69% of base) : 180779.dasm - VectorTest:TestEntryPoint():int (FullOpts)
        -380 (-17.88% of base) : 315780.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Instrumented Tier1)
        -317 (-7.94% of base) : 180532.dasm - VectorTest:TestEntryPoint():int (FullOpts)
        -261 (-10.20% of base) : 180165.dasm - VectorTest:TestEntryPoint():int (FullOpts)
        -252 (-14.47% of base) : 160983.dasm - GitHub_22815.Program:Test() (FullOpts)
        -172 (-17.95% of base) : 197155.dasm - System.Linq.Enumerable:MinMaxInteger[int,System.Linq.Enumerable+MaxCalc`1[int]](System.Collections.Generic.IEnumerable`1[int]):int (FullOpts)
        -148 (-3.16% of base) : 306525.dasm - EventPipeTests.EventPipe:ValidateAllTypesEvent(Microsoft.Diagnostics.Tracing.TraceEvent):ubyte (FullOpts)
        -144 (-8.85% of base) : 196749.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (FullOpts)
        -144 (-5.84% of base) : 180811.dasm - VectorTest+VectorMulTest`1[float]:VectorMul(float,float,float,float,float):int (FullOpts)
        -144 (-6.55% of base) : 180815.dasm - VectorTest+VectorMulTest`1[int]:VectorMul(int,int,int,int,int):int (FullOpts)
        -144 (-6.55% of base) : 180827.dasm - VectorTest+VectorMulTest`1[uint]:VectorMul(uint,uint,uint,uint,uint):int (FullOpts)
        -135 (-15.19% of base) : 158199.dasm - System.Linq.Enumerable:MinMaxInteger[ushort,System.Linq.Enumerable+MinCalc`1[ushort]](System.Collections.Generic.IEnumerable`1[ushort]):ushort (FullOpts)
        -131 (-12.71% of base) : 180891.dasm - VectorTest:VectorTReturnTest():int (FullOpts)
        -125 (-11.56% of base) : 579498.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle:CreateFile(System.String,int,int,int,int):Microsoft.Win32.SafeHandles.SafeFileHandle (Instrumented Tier1)
        -125 (-11.56% of base) : 551894.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle:CreateFile(System.String,int,int,int,int):Microsoft.Win32.SafeHandles.SafeFileHandle (Instrumented Tier1)
        -125 (-11.56% of base) : 501531.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle:CreateFile(System.String,int,int,int,int):Microsoft.Win32.SafeHandles.SafeFileHandle (Instrumented Tier1)
        -125 (-11.56% of base) : 563496.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle:CreateFile(System.String,int,int,int,int):Microsoft.Win32.SafeHandles.SafeFileHandle (Instrumented Tier1)
        -125 (-11.56% of base) : 572416.dasm - Microsoft.Win32.SafeHandles.SafeFileHandle:CreateFile(System.String,int,int,int,int):Microsoft.Win32.SafeHandles.SafeFileHandle (Instrumented Tier1)

Top method improvements (percentages):
         -98 (-51.85% of base) : 248095.dasm - GitHub_21625.test:TestEntryPoint():int (FullOpts)
         -10 (-32.26% of base) : 186082.dasm - Tests:ZeroInBounds(int[]) (FullOpts)
         -11 (-31.43% of base) : 186091.dasm - Program+<>c:<TestEntryPoint>b__2_0(int[]):this (FullOpts)
         -11 (-31.43% of base) : 186092.dasm - Program+<>c:<TestEntryPoint>b__2_1(int[]):this (FullOpts)
         -11 (-31.43% of base) : 186079.dasm - Tests:EqualsInBound(int[]) (FullOpts)
         -11 (-31.43% of base) : 186081.dasm - Tests:EqualsReversedInBound(int[]) (FullOpts)
         -11 (-31.43% of base) : 186077.dasm - Tests:GreaterEqualInBound(int[]) (FullOpts)
         -11 (-31.43% of base) : 186076.dasm - Tests:GreaterInBound(int[]) (FullOpts)
         -11 (-31.43% of base) : 186080.dasm - Tests:LessEqualsInBound(int[]) (FullOpts)
         -11 (-31.43% of base) : 186078.dasm - Tests:LessInBound(int[]) (FullOpts)
         -18 (-31.03% of base) : 194331.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
         -10 (-30.30% of base) : 186109.dasm - Program+<>c:<TestEntryPoint>b__2_13(int[]):this (FullOpts)
         -11 (-29.73% of base) : 190205.dasm - ModLength:Test3(int[],int):int (FullOpts)
         -10 (-29.41% of base) : 186107.dasm - Program+<>c:<TestEntryPoint>b__2_11(int[]):this (FullOpts)
         -10 (-29.41% of base) : 186108.dasm - Program+<>c:<TestEntryPoint>b__2_12(int[]):this (FullOpts)
         -11 (-28.21% of base) : 185377.dasm - Tests:Test140_cns(int):ubyte (FullOpts)
         -11 (-28.21% of base) : 441090.dasm - Tests:Test140_cns(int):ubyte (Tier1)
         -11 (-28.21% of base) : 185473.dasm - Tests:Test188_cns(int):ubyte (FullOpts)
         -11 (-28.21% of base) : 441186.dasm - Tests:Test188_cns(int):ubyte (Tier1)
         -11 (-28.21% of base) : 185825.dasm - Tests:Test364_cns(int):ubyte (FullOpts)

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

Total bytes of base: 45138944 (overridden on cmd)
Total bytes of diff: 45099093 (overridden on cmd)
Total bytes of delta: -39851 (-0.09 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          20 : 117870.dasm (1.76% of base)
          20 : 54626.dasm (1.75% of base)

Top file improvements (bytes):
        -408 : 15805.dasm (-22.91% of base)
        -386 : 15806.dasm (-23.83% of base)
        -345 : 16649.dasm (-23.74% of base)
        -286 : 16650.dasm (-22.17% of base)
        -201 : 16648.dasm (-30.32% of base)
        -160 : 19999.dasm (-13.51% of base)
        -160 : 19964.dasm (-12.37% of base)
        -138 : 90465.dasm (-4.89% of base)
        -134 : 180261.dasm (-0.52% of base)
        -129 : 16671.dasm (-29.79% of base)
        -126 : 22188.dasm (-10.10% of base)
        -125 : 249595.dasm (-9.06% of base)
        -113 : 185869.dasm (-22.51% of base)
        -109 : 110911.dasm (-2.43% of base)
        -103 : 16992.dasm (-28.30% of base)
         -92 : 54149.dasm (-3.16% of base)
         -90 : 16670.dasm (-28.57% of base)
         -89 : 16672.dasm (-26.89% of base)
         -89 : 16673.dasm (-25.95% of base)
         -84 : 19955.dasm (-8.90% of base)

91 total files with Code Size differences (89 improved, 2 regressed), 0 unchanged.

Top method regressions (bytes):
          20 ( 1.76% of base) : 117870.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)
          20 ( 1.75% of base) : 54626.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)

Top method improvements (bytes):
        -408 (-22.91% of base) : 15805.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -386 (-23.83% of base) : 15806.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -345 (-23.74% of base) : 16649.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeOffsetO(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (FullOpts)
        -286 (-22.17% of base) : 16650.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeOffsetR(System.ReadOnlySpan`1[ubyte],uint,byref,byref):ubyte (FullOpts)
        -201 (-30.32% of base) : 16648.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeG(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (FullOpts)
        -160 (-12.37% of base) : 19964.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -160 (-13.51% of base) : 19999.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -138 (-4.89% of base) : 90465.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:ReportUnspecificProcedures(Microsoft.CodeAnalysis.Location,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbol],Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag,ubyte) (FullOpts)
        -134 (-0.52% of base) : 180261.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
        -129 (-29.79% of base) : 16671.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt16X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
        -126 (-10.10% of base) : 22188.dasm - System.DateTimeParse:TryParseFormatO(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -125 (-9.06% of base) : 249595.dasm - System.Net.HttpListenerRequest+Helpers:UrlDecodeStringFromStringInternal(System.String,System.Text.Encoding):System.String (FullOpts)
        -113 (-22.51% of base) : 185869.dasm - System.Reflection.Metadata.BlobContentId:FromHash(System.ReadOnlySpan`1[ubyte]):System.Reflection.Metadata.BlobContentId (FullOpts)
        -109 (-2.43% of base) : 110911.dasm - Microsoft.CodeAnalysis.VisualBasic.OverloadResolution:MatchArguments(Microsoft.CodeAnalysis.VisualBasic.BoundMethodOrPropertyGroup,byref,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],Microsoft.CodeAnalysis.VisualBasic.Binder,byref,Microsoft.CodeAnalysis.SyntaxNode,ubyte,byref) (FullOpts)
        -103 (-28.30% of base) : 16992.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
         -92 (-3.16% of base) : 54149.dasm - System.Text.RegularExpressions.RegexCompiler+<>c__DisplayClass158_0:<EmitTryMatchAtCurrentPosition>g__EmitSingleCharLazy|22(System.Text.RegularExpressions.RegexNode,System.Text.RegularExpressions.RegexNode,ubyte):this (FullOpts)
         -90 (-28.57% of base) : 16670.dasm - System.Buffers.Text.Utf8Parser:TryParseByteX(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -89 (-26.89% of base) : 16672.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -89 (-25.95% of base) : 16673.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt64X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -84 (-8.90% of base) : 19955.dasm - System.Enum:TryFormatPrimitiveNonDefault[int,uint](System.RuntimeType,int,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method regressions (percentages):
          20 ( 1.76% of base) : 117870.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)
          20 ( 1.75% of base) : 54626.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)

Top method improvements (percentages):
         -21 (-30.43% of base) : 244592.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
         -21 (-30.43% of base) : 158302.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
        -201 (-30.32% of base) : 16648.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeG(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (FullOpts)
        -129 (-29.79% of base) : 16671.dasm - System.Buffers.Text.Utf8Parser:TryParseUInt16X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -14 (-29.79% of base) : 91179.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode):Microsoft.CodeAnalysis.VisualBasic.BoundNode:this (FullOpts)
         -25 (-29.41% of base) : 219.dasm - System.Decimal:GetBits(System.Decimal,System.Span`1[int]):int (FullOpts)
         -17 (-29.31% of base) : 250325.dasm - Newtonsoft.Json.Bson.Utilities.StringUtils:EndsWith(System.String,ushort):ubyte (FullOpts)
         -17 (-29.31% of base) : 177332.dasm - Newtonsoft.Json.Utilities.StringUtils:EndsWith(System.String,ushort):ubyte (FullOpts)
         -11 (-28.95% of base) : 240366.dasm - System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (FullOpts)
         -90 (-28.57% of base) : 16670.dasm - System.Buffers.Text.Utf8Parser:TryParseByteX(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
         -26 (-28.57% of base) : 233939.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -26 (-28.57% of base) : 256365.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -26 (-28.57% of base) : 259455.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -26 (-28.57% of base) : 21156.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -26 (-28.57% of base) : 259085.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -21 (-28.38% of base) : 269447.dasm - System.Net.Security.TlsFrameHelper:TryGetAlertInfo(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (FullOpts)
        -103 (-28.30% of base) : 16992.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
         -18 (-28.12% of base) : 212395.dasm - System.Net.Http.Headers.ContentDispositionHeaderValue:IsQuoted(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -27 (-27.55% of base) : 220.dasm - System.Decimal:TryGetBits(System.Decimal,System.Span`1[int],byref):ubyte (FullOpts)
         -11 (-27.50% of base) : 179928.dasm - Microsoft.VisualBasic.CompilerServices.CharType:FromString(System.String):ushort (FullOpts)

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

Total bytes of base: 61513553 (overridden on cmd)
Total bytes of diff: 61438384 (overridden on cmd)
Total bytes of delta: -75169 (-0.12 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          79 : 100680.dasm (2.54% of base)
           4 : 56260.dasm (0.20% of base)

Top file improvements (bytes):
        -162 : 209604.dasm (-5.83% of base)
        -162 : 211708.dasm (-5.78% of base)
        -162 : 271496.dasm (-5.83% of base)
        -159 : 17115.dasm (-9.36% of base)
        -144 : 128405.dasm (-8.85% of base)
        -129 : 284689.dasm (-23.67% of base)
        -120 : 176335.dasm (-5.23% of base)
        -118 : 272047.dasm (-4.31% of base)
        -115 : 17113.dasm (-5.88% of base)
        -115 : 17111.dasm (-6.25% of base)
        -115 : 17112.dasm (-5.87% of base)
        -110 : 291514.dasm (-8.93% of base)
        -109 : 168245.dasm (-21.21% of base)
        -108 : 104130.dasm (-6.11% of base)
        -107 : 162618.dasm (-0.37% of base)
         -99 : 201426.dasm (-2.03% of base)
         -97 : 254843.dasm (-11.98% of base)
         -97 : 139061.dasm (-2.57% of base)
         -93 : 54451.dasm (-9.14% of base)
         -92 : 206629.dasm (-4.08% of base)

98 total files with Code Size differences (96 improved, 2 regressed), 0 unchanged.

Top method regressions (bytes):
          79 ( 2.54% of base) : 100680.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceMemberContainerTypeSymbol:ProcessPartialMethodsIfAny(System.Collections.Generic.Dictionary`2[System.String,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbol]],Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):this (FullOpts)
           4 ( 0.20% of base) : 56260.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)

Top method improvements (bytes):
        -162 (-5.83% of base) : 209604.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -162 (-5.78% of base) : 211708.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -162 (-5.83% of base) : 271496.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -159 (-9.36% of base) : 17115.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,long](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -144 (-8.85% of base) : 128405.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (FullOpts)
        -129 (-23.67% of base) : 284689.dasm - System.Linq.Enumerable:SumSignedIntegersVectorized[int](System.ReadOnlySpan`1[int]):int (FullOpts)
        -120 (-5.23% of base) : 176335.dasm - Microsoft.Build.Evaluation.ExpressionShredder:GetReferencedItemNamesAndMetadata(System.String,int,int,byref,int) (FullOpts)
        -118 (-4.31% of base) : 272047.dasm - System.Diagnostics.DiagnosticSourceEventSource+FilterAndTransform:AddNewActivitySourceTransform(System.String,int,int,System.Diagnostics.DiagnosticSourceEventSource) (FullOpts)
        -115 (-5.88% of base) : 17113.dasm - System.Enum:TryFormatPrimitiveNonDefault[int,long](System.RuntimeType,int,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -115 (-5.87% of base) : 17112.dasm - System.Enum:TryFormatPrimitiveNonDefault[short,long](System.RuntimeType,short,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -115 (-6.25% of base) : 17111.dasm - System.Enum:TryFormatPrimitiveNonDefault[ubyte,long](System.RuntimeType,ubyte,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -110 (-8.93% of base) : 291514.dasm - System.Net.HttpWebResponse:get_CharacterSet():System.String:this (FullOpts)
        -109 (-21.21% of base) : 168245.dasm - System.Reflection.Metadata.BlobContentId:FromHash(System.ReadOnlySpan`1[ubyte]):System.Reflection.Metadata.BlobContentId (FullOpts)
        -108 (-6.11% of base) : 104130.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation:CommonCreateAnonymousTypeSymbol(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ITypeSymbol],System.Collections.Immutable.ImmutableArray`1[System.String],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.Location],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[ubyte]):Microsoft.CodeAnalysis.INamedTypeSymbol:this (FullOpts)
        -107 (-0.37% of base) : 162618.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
         -99 (-2.03% of base) : 201426.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetPropertyMatcherRegex_1+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
         -97 (-11.98% of base) : 254843.dasm - System.CommandLine.EnvironmentVariablesDirective+EnvironmentVariablesDirectiveAction:SetEnvVars(System.CommandLine.ParseResult):this (FullOpts)
         -97 (-2.57% of base) : 139061.dasm - System.Xml.Serialization.TempAssembly:GenerateSerializerToStream(System.Xml.Serialization.XmlMapping[],System.Type[],System.String,System.Reflection.Assembly,System.Collections.Hashtable,System.IO.Stream):ubyte (FullOpts)
         -93 (-9.14% of base) : 54451.dasm - System.Net.HeaderInfoTable:ParseValueHelper(System.String,ubyte):System.String[] (FullOpts)
         -92 (-4.08% of base) : 206629.dasm - System.Data.DataTable:ParseSortString(System.String):System.Data.IndexField[]:this (FullOpts)

Top method regressions (percentages):
          79 ( 2.54% of base) : 100680.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceMemberContainerTypeSymbol:ProcessPartialMethodsIfAny(System.Collections.Generic.Dictionary`2[System.String,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbol]],Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):this (FullOpts)
           4 ( 0.20% of base) : 56260.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)

Top method improvements (percentages):
         -15 (-34.88% of base) : 83893.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor:AssertIsGood():this (FullOpts)
         -15 (-34.88% of base) : 98560.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.AnonymousTypeDescriptor:AssertGood():this (FullOpts)
         -18 (-31.03% of base) : 90042.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
         -15 (-30.61% of base) : 146695.dasm - Microsoft.CodeAnalysis.Compilation:AssertNoScriptTrees():this (FullOpts)
         -15 (-30.61% of base) : 187476.dasm - Microsoft.CodeAnalysis.Compilation:AssertNoScriptTrees():this (FullOpts)
         -24 (-30.00% of base) : 277154.dasm - System.Formats.Cbor.CborHelpers:GetBitsFromDecimal(System.Decimal,System.Span`1[int]) (FullOpts)
         -13 (-29.55% of base) : 249396.dasm - System.Linq.ImmutableArrayExtensions:First[int](System.Collections.Immutable.ImmutableArray`1[int]):int (FullOpts)
         -20 (-29.41% of base) : 126344.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
         -20 (-29.41% of base) : 257761.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
         -13 (-28.89% of base) : 249399.dasm - System.Linq.ImmutableArrayExtensions:First[long](System.Collections.Immutable.ImmutableArray`1[long]):long (FullOpts)
         -13 (-28.89% of base) : 249394.dasm - System.Linq.ImmutableArrayExtensions:First[ubyte](System.Collections.Immutable.ImmutableArray`1[ubyte]):ubyte (FullOpts)
         -13 (-28.89% of base) : 235697.dasm - System.Text.Json.JsonWriterHelper:NeedsEscaping(ubyte):ubyte (FullOpts)
         -13 (-28.26% of base) : 97274.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode):Microsoft.CodeAnalysis.VisualBasic.BoundNode:this (FullOpts)
         -13 (-28.26% of base) : 249382.dasm - System.Linq.ImmutableArrayExtensions:ElementAtOrDefault[int](System.Collections.Immutable.ImmutableArray`1[int],int):int (FullOpts)
         -13 (-28.26% of base) : 249397.dasm - System.Linq.ImmutableArrayExtensions:First[double](System.Collections.Immutable.ImmutableArray`1[double]):double (FullOpts)
         -13 (-28.26% of base) : 249395.dasm - System.Linq.ImmutableArrayExtensions:First[short](System.Collections.Immutable.ImmutableArray`1[short]):short (FullOpts)
         -16 (-28.07% of base) : 248712.dasm - Newtonsoft.Json.Bson.Utilities.StringUtils:EndsWith(System.String,ushort):ubyte (FullOpts)
         -16 (-28.07% of base) : 165157.dasm - Newtonsoft.Json.Utilities.StringUtils:EndsWith(System.String,ushort):ubyte (FullOpts)
         -25 (-27.78% of base) : 277258.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 278605.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

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

Total bytes of base: 285321424 (overridden on cmd)
Total bytes of diff: 285025367 (overridden on cmd)
Total bytes of delta: -296057 (-0.10 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         503 : 654908.dasm (4.72% of base)
          18 : 260777.dasm (0.77% of base)
          18 : 275072.dasm (0.77% of base)
          18 : 490914.dasm (0.78% of base)
          18 : 392261.dasm (0.77% of base)
          18 : 393846.dasm (0.77% of base)
          18 : 683493.dasm (0.78% of base)
          18 : 378885.dasm (0.77% of base)
          17 : 558933.dasm (0.72% of base)
          17 : 695194.dasm (0.73% of base)
          17 : 279207.dasm (0.73% of base)
          17 : 691741.dasm (0.74% of base)
          17 : 111511.dasm (0.74% of base)
          17 : 692539.dasm (0.73% of base)
          17 : 690829.dasm (0.73% of base)
          17 : 258690.dasm (0.74% of base)
          17 : 339190.dasm (0.74% of base)
          17 : 383147.dasm (0.74% of base)
          13 : 128621.dasm (0.56% of base)
          13 : 318162.dasm (0.54% of base)

Top file improvements (bytes):
        -375 : 29855.dasm (-17.57% of base)
        -374 : 284872.dasm (-19.14% of base)
        -374 : 435669.dasm (-19.14% of base)
        -374 : 523745.dasm (-19.14% of base)
        -374 : 617938.dasm (-19.14% of base)
        -374 : 50460.dasm (-19.14% of base)
        -370 : 385443.dasm (-20.99% of base)
        -336 : 373118.dasm (-15.56% of base)
        -300 : 373117.dasm (-14.11% of base)
        -274 : 672943.dasm (-17.27% of base)
        -270 : 433269.dasm (-18.33% of base)
        -270 : 89128.dasm (-18.31% of base)
        -270 : 60537.dasm (-18.31% of base)
        -249 : 73347.dasm (-9.26% of base)
        -240 : 73354.dasm (-10.78% of base)
        -214 : 322704.dasm (-8.55% of base)
        -206 : 373105.dasm (-20.36% of base)
        -195 : 479719.dasm (-6.11% of base)
        -183 : 73308.dasm (-8.82% of base)
        -166 : 79376.dasm (-6.70% of base)

79 total files with Code Size differences (59 improved, 20 regressed), 0 unchanged.

Top method regressions (bytes):
         503 ( 4.72% of base) : 654908.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex6723_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          18 ( 0.77% of base) : 260777.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 275072.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.78% of base) : 490914.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 392261.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 393846.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.78% of base) : 683493.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 378885.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.72% of base) : 558933.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 695194.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 279207.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 691741.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 111511.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 692539.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 690829.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 258690.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 339190.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 383147.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          13 ( 0.56% of base) : 128621.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          13 ( 0.54% of base) : 318162.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)

Top method improvements (bytes):
        -375 (-17.57% of base) : 29855.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Instrumented Tier1)
        -374 (-19.14% of base) : 284872.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -374 (-19.14% of base) : 435669.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -374 (-19.14% of base) : 523745.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -374 (-19.14% of base) : 617938.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -374 (-19.14% of base) : 50460.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -370 (-20.99% of base) : 385443.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (Instrumented Tier1)
        -336 (-15.56% of base) : 373118.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeOffsetO(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (Instrumented Tier1)
        -300 (-14.11% of base) : 373117.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeOffsetR(System.ReadOnlySpan`1[ubyte],uint,byref,byref):ubyte (Instrumented Tier1)
        -274 (-17.27% of base) : 672943.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (Tier1)
        -270 (-18.33% of base) : 433269.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (Tier1)
        -270 (-18.31% of base) : 89128.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (Tier1)
        -270 (-18.31% of base) : 60537.dasm - System.Xml.XmlConvert:DecodeName(System.String):System.String (Tier1)
        -249 (-9.26% of base) : 73347.dasm - LibraryImportGenerator.IntegrationTests.NativeExportsNE+MarshallingFails:NegateBoolsOut2D(SharedTypes.BoolStruct[][],int,int[],byref) (Tier0-FullOpts)
        -240 (-10.78% of base) : 73354.dasm - LibraryImportGenerator.IntegrationTests.NativeExportsNE+MarshallingFails:NegateBoolsRef2D_ClearMarshalling(byref,int,int[]) (Tier0-FullOpts)
        -214 (-8.55% of base) : 322704.dasm - System.Security.AccessControl.Win32:GetSecurityInfo(int,System.String,System.Runtime.InteropServices.SafeHandle,int,byref):int (Tier1)
        -206 (-20.36% of base) : 373105.dasm - System.Buffers.Text.Utf8Parser:TryParseDateTimeG(System.ReadOnlySpan`1[ubyte],byref,byref,byref):ubyte (Instrumented Tier1)
        -195 (-6.11% of base) : 479719.dasm - System.IO.PathHelper:TryExpandShortFileName(byref,System.String):System.String (Tier1)
        -183 (-8.82% of base) : 73308.dasm - LibraryImportGenerator.IntegrationTests.NativeExportsNE+MarshallingFails:FillRangeArray2D(SharedTypes.IntStructWrapper[][],int,int[],int):ubyte (Tier0-FullOpts)
        -166 (-6.70% of base) : 79376.dasm - System.String:SplitWithPostProcessing(System.ReadOnlySpan`1[int],System.ReadOnlySpan`1[int],int,int,int):System.String[]:this (Instrumented Tier1)

Top method regressions (percentages):
         503 ( 4.72% of base) : 654908.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex6723_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          18 ( 0.78% of base) : 490914.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.78% of base) : 683493.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 260777.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 275072.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 392261.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 393846.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          18 ( 0.77% of base) : 378885.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 691741.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 111511.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 258690.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 339190.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.74% of base) : 383147.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 695194.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 279207.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 692539.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.73% of base) : 690829.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          17 ( 0.72% of base) : 558933.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          13 ( 0.56% of base) : 128621.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)
          13 ( 0.54% of base) : 318162.dasm - System.Attribute:InternalParamGetCustomAttributes(System.Reflection.ParameterInfo,System.Type,ubyte):System.Attribute[] (Tier1)

Top method improvements (percentages):
         -18 (-31.03% of base) : 92171.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
         -18 (-31.03% of base) : 58536.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
         -18 (-31.03% of base) : 638569.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
         -18 (-31.03% of base) : 191904.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (Tier1)
        -109 (-29.70% of base) : 607432.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (Tier1)
         -20 (-29.41% of base) : 433222.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (Tier1)
         -13 (-28.89% of base) : 614143.dasm - System.Text.Json.JsonWriterHelper:NeedsEscaping(ubyte):ubyte (Tier1)
         -24 (-27.27% of base) : 69577.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 69442.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 95367.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 532164.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 4422.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 559908.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 321954.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 126691.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 135686.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 67620.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 134820.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 72260.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -24 (-27.27% of base) : 129986.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)

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

Total bytes of base: 136504381 (overridden on cmd)
Total bytes of diff: 136383362 (overridden on cmd)
Total bytes of delta: -121019 (-0.09 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          23 : 291437.dasm (1.82% of base)
          22 : 38879.dasm (0.54% of base)
           2 : 190844.dasm (0.03% of base)

Top file improvements (bytes):
        -364 : 62977.dasm (-6.02% of base)
        -244 : 19090.dasm (-9.25% of base)
        -235 : 19096.dasm (-10.66% of base)
        -186 : 212560.dasm (-7.33% of base)
        -186 : 201243.dasm (-7.33% of base)
        -180 : 19057.dasm (-8.70% of base)
        -172 : 148568.dasm (-17.95% of base)
        -172 : 25472.dasm (-17.95% of base)
        -165 : 298977.dasm (-4.15% of base)
        -162 : 97954.dasm (-5.83% of base)
        -162 : 100164.dasm (-5.83% of base)
        -162 : 100470.dasm (-5.78% of base)
        -159 : 300373.dasm (-3.15% of base)
        -154 : 169451.dasm (-14.26% of base)
        -154 : 169698.dasm (-10.89% of base)
        -146 : 169403.dasm (-22.85% of base)
        -146 : 171291.dasm (-15.22% of base)
        -146 : 169390.dasm (-23.25% of base)
        -146 : 169488.dasm (-14.46% of base)
        -146 : 169467.dasm (-22.92% of base)

88 total files with Code Size differences (85 improved, 3 regressed), 3 unchanged.

Top method regressions (bytes):
          23 ( 1.82% of base) : 291437.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2804_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          22 ( 0.54% of base) : 38879.dasm - Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests:FactoryDITest():this (FullOpts)
           2 ( 0.03% of base) : 190844.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateNamespaceChildren(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.NamespaceDefinitionHandle,System.String[],System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]],System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]]):this (FullOpts)

Top method improvements (bytes):
        -364 (-6.02% of base) : 62977.dasm - Microsoft.XmlSerializer.Generator.Sgen:Run(System.String[]):int:this (FullOpts)
        -244 (-9.25% of base) : 19090.dasm - LibraryImportGenerator.IntegrationTests.NativeExportsNE+MarshallingFails:NegateBoolsOut2D(SharedTypes.BoolStruct[][],int,int[],byref) (FullOpts)
        -235 (-10.66% of base) : 19096.dasm - LibraryImportGenerator.IntegrationTests.NativeExportsNE+MarshallingFails:NegateBoolsRef2D_ClearMarshalling(byref,int,int[]) (FullOpts)
        -186 (-7.33% of base) : 212560.dasm - System.Text.Tests.StringBuilderTests:AppendFormat(System.String,System.IFormatProvider,System.String,System.Object[],System.String) (FullOpts)
        -186 (-7.33% of base) : 201243.dasm - System.Text.Tests.StringBuilderTests:AppendFormat(System.String,System.IFormatProvider,System.String,System.Object[],System.String) (FullOpts)
        -180 (-8.70% of base) : 19057.dasm - LibraryImportGenerator.IntegrationTests.NativeExportsNE+MarshallingFails:FillRangeArray2D(SharedTypes.IntStructWrapper[][],int,int[],int):ubyte (FullOpts)
        -172 (-17.95% of base) : 25472.dasm - System.Linq.Enumerable:MinMaxInteger[int,System.Linq.Enumerable+MaxCalc`1[int]](System.Collections.Generic.IEnumerable`1[int]):int (FullOpts)
        -172 (-17.95% of base) : 148568.dasm - System.Linq.Enumerable:MinMaxInteger[uint,System.Linq.Enumerable+MaxCalc`1[uint]](System.Collections.Generic.IEnumerable`1[uint]):uint (FullOpts)
        -165 (-4.15% of base) : 298977.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5194_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -162 (-5.83% of base) : 97954.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -162 (-5.83% of base) : 100164.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -162 (-5.78% of base) : 100470.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -159 (-3.15% of base) : 300373.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex7632_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -154 (-14.26% of base) : 169451.dasm - System.Numerics.Tests.GenericVectorTests:TestConditionalSelect[uint]():this (FullOpts)
        -154 (-10.89% of base) : 169698.dasm - System.Numerics.Tests.GenericVectorTests:TestDivisionReflection[int]():this (FullOpts)
        -146 (-22.85% of base) : 169403.dasm - System.Numerics.Tests.GenericVectorTests:TestMin[uint]():this (FullOpts)
        -146 (-14.46% of base) : 169488.dasm - System.Numerics.Tests.GenericVectorTests:TestMultiplicationWithScalar[int]():this (FullOpts)
        -146 (-22.92% of base) : 169467.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorGreaterThan[uint]():this (FullOpts)
        -146 (-23.25% of base) : 169390.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorLessThan[int]():this (FullOpts)
        -146 (-15.22% of base) : 171291.dasm - System.Numerics.Tests.GenericVectorTests:WidenInt16():this (FullOpts)

Top method regressions (percentages):
          23 ( 1.82% of base) : 291437.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2804_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          22 ( 0.54% of base) : 38879.dasm - Microsoft.Extensions.Diagnostics.Metrics.Tests.DefaultMetricsFactoryTests:FactoryDITest():this (FullOpts)
           2 ( 0.03% of base) : 190844.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateNamespaceChildren(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.NamespaceDefinitionHandle,System.String[],System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]],System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IList`1[System.String]]):this (FullOpts)

Top method improvements (percentages):
         -18 (-31.03% of base) : 7710.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
         -24 (-29.63% of base) : 223067.dasm - System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__0():this (FullOpts)
         -24 (-29.63% of base) : 223068.dasm - System.Tests.BufferTests+<>c__DisplayClass10_0:<MemoryCopy_Invalid>b__1():this (FullOpts)
         -20 (-29.41% of base) : 63379.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
         -20 (-29.41% of base) : 66941.dasm - System.CSharpHelpers:IsPrefixTwoUnderscore(System.String):ubyte (FullOpts)
         -25 (-27.78% of base) : 130140.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 17119.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 124798.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 123570.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 130863.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -17 (-26.98% of base) : 156654.dasm - System.Net.Http.Headers.ContentDispositionHeaderValue:IsQuoted(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -17 (-26.98% of base) : 158243.dasm - System.Net.Http.Headers.ContentDispositionHeaderValue:IsQuoted(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -15 (-26.79% of base) : 113744.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.context.operate.regclass.regstrct008.regstrct008.Extension:Method(int[]):int (FullOpts)
         -13 (-26.53% of base) : 51420.dasm - Microsoft.CodeAnalysis.CSharp.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
         -13 (-26.53% of base) : 44735.dasm - Microsoft.CodeAnalysis.CSharp.MemberSemanticModel:GetLowerBoundNode(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
         -10 (-25.64% of base) : 59236.dasm - Microsoft.VisualBasic.CompilerServices.Conversions:ToChar(System.String):ushort (FullOpts)
          -9 (-24.32% of base) : 169738.dasm - System.Numerics.Tests.GenericVectorTests+<>c__DisplayClass57_0`1[int]:<TestConstructorArrayTooSmallException>b__0():this (FullOpts)
        -129 (-23.67% of base) : 146861.dasm - System.Linq.Enumerable:SumSignedIntegersVectorized[int](System.ReadOnlySpan`1[int]):int (FullOpts)
        -138 (-23.35% of base) : 169321.dasm - System.Numerics.Tests.GenericVectorTests:TestShiftLeft[uint]():this (FullOpts)
        -138 (-23.35% of base) : 169761.dasm - System.Numerics.Tests.GenericVectorTests:TestShiftRightLogical[int]():this (FullOpts)

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

Total bytes of base: 14000976 (overridden on cmd)
Total bytes of diff: 13979936 (overridden on cmd)
Total bytes of delta: -21040 (-0.15 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
           4 : 22053.dasm (0.21% of base)

Top file improvements (bytes):
        -381 : 629.dasm (-20.84% of base)
        -182 : 17284.dasm (-4.94% of base)
        -172 : 17417.dasm (-17.95% of base)
        -154 : 16580.dasm (-1.88% of base)
        -150 : 14960.dasm (-46.88% of base)
        -148 : 1007.dasm (-1.71% of base)
        -139 : 35544.dasm (-6.73% of base)
        -109 : 32579.dasm (-21.21% of base)
        -108 : 29385.dasm (-2.45% of base)
        -107 : 5326.dasm (-1.66% of base)
        -103 : 16598.dasm (-3.21% of base)
        -100 : 20504.dasm (-9.48% of base)
         -94 : 17405.dasm (-6.82% of base)
         -94 : 17378.dasm (-1.11% of base)
         -91 : 1017.dasm (-0.92% of base)
         -85 : 16200.dasm (-1.86% of base)
         -81 : 14962.dasm (-40.30% of base)
         -81 : 17747.dasm (-4.85% of base)
         -72 : 628.dasm (-13.46% of base)
         -72 : 29383.dasm (-1.66% of base)

89 total files with Code Size differences (88 improved, 1 regressed), 0 unchanged.

Top method regressions (bytes):
           4 ( 0.21% of base) : 22053.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)

Top method improvements (bytes):
        -381 (-20.84% of base) : 629.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -182 (-4.94% of base) : 17284.dasm - Microsoft.ML.Internal.Utilities.VBufferUtils:ApplyInto[float,float,float](byref,byref,byref,System.Func`4[int,float,float,float]) (FullOpts)
        -172 (-17.95% of base) : 17417.dasm - System.Linq.Enumerable:MinMaxInteger[int,System.Linq.Enumerable+MaxCalc`1[int]](System.Collections.Generic.IEnumerable`1[int]):int (FullOpts)
        -154 (-1.88% of base) : 16580.dasm - Microsoft.ML.Trainers.SdcaMulticlassTrainerBase`1[System.__Canon]:TrainWithoutLock(Microsoft.ML.Runtime.IProgressChannelProvider,Microsoft.ML.Trainers.FloatLabelCursor+Factory,System.Random,Microsoft.ML.Trainers.SdcaTrainerBase`3+IdToIdxLookup[System.__Canon,System.__Canon,System.__Canon],int,Microsoft.ML.Trainers.SdcaTrainerBase`3+DualsTableBase[System.__Canon,System.__Canon,System.__Canon],float[],float[],float,Microsoft.ML.Data.VBuffer`1[float][],float[],Microsoft.ML.Data.VBuffer`1[float][],float[],float[]):this (FullOpts)
        -150 (-46.88% of base) : 14960.dasm - SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
        -148 (-1.71% of base) : 1007.dasm - BepuPhysics.CollisionDetection.SweepTasks.ConvexPairSweepTask`5[BepuPhysics.Collidables.Sphere,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.CollisionDetection.SweepTasks.SphereBoxDistanceTester]:Sweep[BepuPhysics.CollisionDetection.SweepTasks.ConvexPairSweepTask`5+OffsetSweep[BepuPhysics.Collidables.Sphere,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.CollisionDetection.SweepTasks.SphereBoxDistanceTester]](ulong,byref,byref,ulong,byref,byref,byref,float,float,float,int,byref,byref,byref,byref,byref):ubyte (FullOpts)
        -139 (-6.73% of base) : 35544.dasm - System.String:SplitWithPostProcessing(System.ReadOnlySpan`1[int],System.ReadOnlySpan`1[int],int,int,int):System.String[]:this (FullOpts)
        -109 (-21.21% of base) : 32579.dasm - System.Reflection.Metadata.BlobContentId:FromHash(System.ReadOnlySpan`1[ubyte]):System.Reflection.Metadata.BlobContentId (FullOpts)
        -108 (-2.45% of base) : 29385.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -107 (-1.66% of base) : 5326.dasm - FSharp.Compiler.TypedTreePickle:unpickleObjWithDanglingCcus[System.__Canon](System.String,FSharp.Compiler.AbstractIL.IL+ILScopeRef,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.AbstractIL.IL+ILModuleDef],Microsoft.FSharp.Core.FSharpFunc`2[System.__Canon,System.__Canon],FSharp.Compiler.IO.ReadOnlyByteMemory):FSharp.Compiler.TypedTreePickle+PickledDataWithReferences`1[System.__Canon] (FullOpts)
        -103 (-3.21% of base) : 16598.dasm - Microsoft.ML.Trainers.SdcaMulticlassTrainerBase`1[System.__Canon]:CheckConvergence(Microsoft.ML.Runtime.IProgressChannel,int,Microsoft.ML.Trainers.FloatLabelCursor+Factory,Microsoft.ML.Trainers.SdcaTrainerBase`3+DualsTableBase[System.__Canon,System.__Canon,System.__Canon],Microsoft.ML.Trainers.SdcaTrainerBase`3+IdToIdxLookup[System.__Canon,System.__Canon,System.__Canon],Microsoft.ML.Data.VBuffer`1[float][],Microsoft.ML.Data.VBuffer`1[float][],float[],float[],float[],float[],long,double[],byref,byref):ubyte:this (FullOpts)
        -100 (-9.48% of base) : 20504.dasm - System.Numerics.BigInteger:TryGetBytes(int,System.Span`1[ubyte],ubyte,ubyte,byref):ubyte[]:this (FullOpts)
         -94 (-1.11% of base) : 17378.dasm - Microsoft.ML.Transforms.Text.TextFeaturizingEstimator:Fit(Microsoft.ML.IDataView):Microsoft.ML.ITransformer:this (FullOpts)
         -94 (-6.82% of base) : 17405.dasm - System.Enum:TryParseByName[uint](System.RuntimeType,System.ReadOnlySpan`1[ushort],ubyte,ubyte,byref):ubyte (FullOpts)
         -91 (-0.92% of base) : 1017.dasm - BepuPhysics.CollisionDetection.SweepTasks.GJKDistanceTester`6[BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder]:FindClosestPoint(byref,byref,byref,byref,byref) (FullOpts)
         -85 (-1.86% of base) : 16200.dasm - Microsoft.ML.Transforms.ValueToKeyMappingTransformer:Train(Microsoft.ML.Runtime.IHostEnvironment,Microsoft.ML.Runtime.IChannel,Microsoft.ML.Transforms.ValueToKeyMappingTransformer+ColInfo[],Microsoft.ML.IDataView,Microsoft.ML.Transforms.ValueToKeyMappingEstimator+ColumnOptionsBase[],Microsoft.ML.IDataView,ubyte):Microsoft.ML.Transforms.ValueToKeyMappingTransformer+TermMap[] (FullOpts)
         -81 (-40.30% of base) : 14962.dasm - SixLabors.ImageSharp.Formats.Tga.TgaImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
         -81 (-4.85% of base) : 17747.dasm - System.UriBuilder:ToString():System.String:this (FullOpts)
         -72 (-13.46% of base) : 628.dasm - System.Guid:TryParseGuid(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
         -72 (-1.66% of base) : 29383.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method regressions (percentages):
           4 ( 0.21% of base) : 22053.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[],Microsoft.CodeAnalysis.CSharp.BoundAttribute[],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Action`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)

Top method improvements (percentages):
        -150 (-46.88% of base) : 14960.dasm - SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
         -81 (-40.30% of base) : 14962.dasm - SixLabors.ImageSharp.Formats.Tga.TgaImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
         -35 (-32.11% of base) : 14967.dasm - SixLabors.ImageSharp.Formats.Gif.GifImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
         -18 (-31.03% of base) : 26050.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
         -25 (-27.78% of base) : 387.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -18 (-25.00% of base) : 6309.dasm - FSharp.Compiler.Syntax.PrettyNaming:IsActivePatternName(System.String):ubyte (FullOpts)
         -10 (-23.81% of base) : 6696.dasm - Internal.Utilities.Library.String:isLeadingIdentifierCharacterUpperCase(System.String):ubyte (FullOpts)
         -50 (-23.26% of base) : 18051.dasm - System.Net.Security.TlsFrameHelper:TryGetFrameHeader(System.ReadOnlySpan`1[ubyte],byref):ubyte (FullOpts)
         -16 (-22.22% of base) : 18844.dasm - Roslyn.Utilities.PathUtilities:IsDriveRootedAbsolutePath(System.String):ubyte (FullOpts)
         -10 (-21.28% of base) : 30487.dasm - Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator:IsMultidimensionalInitializer(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression]):ubyte (FullOpts)
         -10 (-21.28% of base) : 22723.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:TryGetFirstLocation():Microsoft.CodeAnalysis.Location:this (FullOpts)
        -109 (-21.21% of base) : 32579.dasm - System.Reflection.Metadata.BlobContentId:FromHash(System.ReadOnlySpan`1[ubyte]):System.Reflection.Metadata.BlobContentId (FullOpts)
        -381 (-20.84% of base) : 629.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
         -10 (-20.00% of base) : 903.dasm - System.Linq.Enumerable:Sum[double,double](System.ReadOnlySpan`1[double]):double (FullOpts)
         -17 (-19.77% of base) : 21573.dasm - System.Text.RegularExpressions.RegexCharClass:CanEasilyEnumerateSetContents(System.String,byref):ubyte (FullOpts)
         -16 (-19.51% of base) : 19040.dasm - Roslyn.Utilities.StringExtensions:Unquote(System.String,byref):System.String (FullOpts)
         -19 (-19.39% of base) : 1611.dasm - System.IO.Path:IsPathRooted(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -14 (-19.18% of base) : 34432.dasm - System.Management.Automation.Language.CharExtensions:ForceStartNewToken(ushort):ubyte (FullOpts)
         -37 (-19.07% of base) : 381.dasm - System.IO.PathInternal:IsPartiallyQualified(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -13 (-18.84% of base) : 393.dasm - System.IO.PathInternal:EndsInDirectorySeparator(System.String):ubyte (FullOpts)

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

Total bytes of base: 5135469 (overridden on cmd)
Total bytes of diff: 5117376 (overridden on cmd)
Total bytes of delta: -18093 (-0.35 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file improvements (bytes):
        -421 : 1524.dasm (-22.79% of base)
        -399 : 1535.dasm (-23.46% of base)
        -159 : 15777.dasm (-14.21% of base)
        -159 : 475.dasm (-14.20% of base)
        -159 : 15776.dasm (-15.68% of base)
        -159 : 21118.dasm (-15.68% of base)
        -159 : 18383.dasm (-15.68% of base)
        -159 : 3611.dasm (-15.71% of base)
        -159 : 3612.dasm (-14.20% of base)
        -159 : 21120.dasm (-14.21% of base)
        -159 : 18384.dasm (-14.21% of base)
        -159 : 474.dasm (-15.71% of base)
        -107 : 27001.dasm (-14.36% of base)
        -102 : 16165.dasm (-28.10% of base)
        -102 : 18785.dasm (-28.10% of base)
        -102 : 4218.dasm (-28.10% of base)
        -102 : 21515.dasm (-28.10% of base)
        -102 : 983.dasm (-28.10% of base)
         -83 : 15780.dasm (-12.43% of base)
         -83 : 21121.dasm (-12.43% of base)

88 total files with Code Size differences (88 improved, 0 regressed), 0 unchanged.

Top method improvements (bytes):
        -421 (-22.79% of base) : 1524.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -399 (-23.46% of base) : 1535.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -159 (-14.21% of base) : 15777.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-14.20% of base) : 475.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-14.20% of base) : 3612.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-14.21% of base) : 21120.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-14.21% of base) : 18384.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-15.68% of base) : 15776.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-15.68% of base) : 21118.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-15.68% of base) : 18383.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-15.71% of base) : 3611.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -159 (-15.71% of base) : 474.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -107 (-14.36% of base) : 27001.dasm - System.Enum:TryFormatNumberAsHex[ulong](byref,System.Span`1[ushort],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 16165.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 18785.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 4218.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 21515.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 983.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
         -83 (-12.43% of base) : 15780.dasm - System.Enum:TryFormatPrimitiveNonDefault[uint,uint](System.RuntimeType,uint,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -83 (-12.43% of base) : 21121.dasm - System.Enum:TryFormatPrimitiveNonDefault[uint,uint](System.RuntimeType,uint,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method improvements (percentages):
        -102 (-28.10% of base) : 16165.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 18785.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 4218.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 21515.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
        -102 (-28.10% of base) : 983.dasm - System.Text.Rune:TryEncodeToUtf8(System.Text.Rune,System.Span`1[ubyte],byref):ubyte (FullOpts)
         -25 (-27.78% of base) : 2581.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 20393.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 23067.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 7899.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -25 (-27.78% of base) : 17711.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -11 (-26.19% of base) : 858.dasm - System.EETypePtr:get_CorElementType():ubyte:this (FullOpts)
         -11 (-26.19% of base) : 16100.dasm - System.EETypePtr:get_CorElementType():ubyte:this (FullOpts)
         -11 (-26.19% of base) : 3965.dasm - System.EETypePtr:get_CorElementType():ubyte:this (FullOpts)
         -11 (-26.19% of base) : 21406.dasm - System.EETypePtr:get_CorElementType():ubyte:this (FullOpts)
         -11 (-26.19% of base) : 18839.dasm - System.EETypePtr:get_CorElementType():ubyte:this (FullOpts)
        -399 (-23.46% of base) : 1535.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -421 (-22.79% of base) : 1524.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
         -16 (-21.92% of base) : 20239.dasm - System.Globalization.IcuLocaleData:GetString(System.ReadOnlySpan`1[ubyte]):System.String (FullOpts)
         -16 (-21.92% of base) : 2452.dasm - System.Globalization.IcuLocaleData:GetString(System.ReadOnlySpan`1[ubyte]):System.String (FullOpts)
         -16 (-21.92% of base) : 7916.dasm - System.Globalization.IcuLocaleData:GetString(System.ReadOnlySpan`1[ubyte]):System.String (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
