Diffs are based on <span style="color:#1460aa">2,439,636</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,484,342</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">17,355 (0.71%)</span>, diff: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitDoAssertionProp=0


<details>
<summary>Overall (<span style="color:green">-9,841,591</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,581,162|<span style="color:green">-234,994</span>|<span style="color:green">-5.11%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,797,207|<span style="color:green">-413,426</span>|<span style="color:green">-6.43%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,784,211|<span style="color:green">-82,216</span>|<span style="color:green">-4.75%</span>|
|coreclr_tests.run.windows.x64.checked.mch|388,461,743|<span style="color:green">-2,511,380</span>|<span style="color:green">-10.24%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,279,466|<span style="color:green">-687,197</span>|<span style="color:green">-6.95%</span>|
|libraries.pmi.windows.x64.checked.mch|61,662,542|<span style="color:green">-887,670</span>|<span style="color:green">-5.61%</span>|
|libraries_tests.run.windows.x64.Release.mch|285,588,718|<span style="color:green">-2,168,986</span>|<span style="color:green">-4.23%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|137,193,054|<span style="color:green">-2,568,762</span>|<span style="color:green">-5.64%</span>|
|realworld.run.windows.x64.checked.mch|13,858,724|<span style="color:green">-209,222</span>|<span style="color:green">-12.65%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,054,270|<span style="color:green">-77,738</span>|<span style="color:green">-6.78%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-9,841,591</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,580,802|<span style="color:green">-234,994</span>|<span style="color:green">-5.11%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,894,583|<span style="color:green">-413,426</span>|<span style="color:green">-6.43%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,551,428|<span style="color:green">-82,216</span>|<span style="color:green">-4.75%</span>|
|coreclr_tests.run.windows.x64.checked.mch|108,018,594|<span style="color:green">-2,511,380</span>|<span style="color:green">-10.24%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,278,279|<span style="color:green">-687,197</span>|<span style="color:green">-6.95%</span>|
|libraries.pmi.windows.x64.checked.mch|61,549,048|<span style="color:green">-887,670</span>|<span style="color:green">-5.61%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,941,699|<span style="color:green">-2,168,986</span>|<span style="color:green">-4.23%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|126,900,175|<span style="color:green">-2,568,762</span>|<span style="color:green">-5.64%</span>|
|realworld.run.windows.x64.checked.mch|13,472,556|<span style="color:green">-209,222</span>|<span style="color:green">-12.65%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,053,323|<span style="color:green">-77,738</span>|<span style="color:green">-6.78%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-72.73%</span>) : 32417.dasm - System.Collections.Concurrent.ConcurrentDictionaryTypeProps`1[int]:IsWriteAtomicPrivate():ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,33 +10,22 @@
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )     int  ->  zero-ref   
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  2   )     int  ->  rax         "Inline return value spill temp"
-;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rax         "Inline return value spill temp"
+;* V02 tmp1         [V02,T00] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V03 tmp2         [V03,T01] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.RuntimeType>
-;  V05 rat0         [V05,T00] (  2,  4   )     int  ->  rax         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 0
 
-G_M2423_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M2423_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
-G_M2423_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      eax, 9
-       add      eax, -3
-       cmp      eax, 11
-       ja       SHORT G_M2423_IG04
+G_M2423_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, 1
-						;; size=18 bbWeight=1 PerfScore 2.00
+						;; size=5 bbWeight=1 PerfScore 0.25
 G_M2423_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M2423_IG04:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M2423_IG05:        ; bbWeight=0.50, epilog, nogc, extend
-       ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 22, prolog size 0, PerfScore 3.62, instruction count 8, allocated bytes for code 22 (MethodHash=cd29f688) for method System.Collections.Concurrent.ConcurrentDictionaryTypeProps`1[int]:IsWriteAtomicPrivate():ubyte (FullOpts)
+; Total bytes of code 6, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 6 (MethodHash=cd29f688) for method System.Collections.Concurrent.ConcurrentDictionaryTypeProps`1[int]:IsWriteAtomicPrivate():ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-59.49%</span>) : 28656.dasm - System.Numerics.Tests.Perf_Matrix4x4:NegateBenchmark():System.Numerics.Matrix4x4:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Numerics.Tests.Perf_Matrix4x4>
-;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rdx         single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] "spilled call-like call argument" <System.Numerics.Matrix4x4>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix4x4+Impl>
@@ -17,19 +17,19 @@
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Numerics.Matrix4x4>
 ;* V07 tmp5         [V07    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix4x4+Impl>
 ;* V08 tmp6         [V08    ] (  0,  0   )  struct (64) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix4x4+Impl>
-;  V09 tmp7         [V09,T02] (  2,  2   )  simd16  ->  mm0         "field V05.X (fldOffset=0x0)" P-INDEP
-;  V10 tmp8         [V10,T03] (  2,  2   )  simd16  ->  mm1         "field V05.Y (fldOffset=0x10)" P-INDEP
-;  V11 tmp9         [V11,T04] (  2,  2   )  simd16  ->  mm2         "field V05.Z (fldOffset=0x20)" P-INDEP
-;  V12 tmp10        [V12,T05] (  2,  2   )  simd16  ->  mm3         "field V05.W (fldOffset=0x30)" P-INDEP
-;  V13 tmp11        [V13,T06] (  2,  2   )  simd16  ->  mm0         "field V08.X (fldOffset=0x0)" P-INDEP
-;  V14 tmp12        [V14,T07] (  2,  2   )  simd16  ->  mm1         "field V08.Y (fldOffset=0x10)" P-INDEP
-;  V15 tmp13        [V15,T08] (  2,  2   )  simd16  ->  mm2         "field V08.Z (fldOffset=0x20)" P-INDEP
-;  V16 tmp14        [V16,T09] (  2,  2   )  simd16  ->  mm3         "field V08.W (fldOffset=0x30)" P-INDEP
+;* V09 tmp7         [V09,T01] (  0,  0   )  simd16  ->  zero-ref    "field V05.X (fldOffset=0x0)" P-INDEP
+;* V10 tmp8         [V10,T02] (  0,  0   )  simd16  ->  zero-ref    "field V05.Y (fldOffset=0x10)" P-INDEP
+;* V11 tmp9         [V11,T03] (  0,  0   )  simd16  ->  zero-ref    "field V05.Z (fldOffset=0x20)" P-INDEP
+;* V12 tmp10        [V12,T04] (  0,  0   )  simd16  ->  zero-ref    "field V05.W (fldOffset=0x30)" P-INDEP
+;* V13 tmp11        [V13,T05] (  0,  0   )  simd16  ->  zero-ref    "field V08.X (fldOffset=0x0)" P-INDEP
+;* V14 tmp12        [V14,T06] (  0,  0   )  simd16  ->  zero-ref    "field V08.Y (fldOffset=0x10)" P-INDEP
+;* V15 tmp13        [V15,T07] (  0,  0   )  simd16  ->  zero-ref    "field V08.Z (fldOffset=0x20)" P-INDEP
+;* V16 tmp14        [V16,T08] (  0,  0   )  simd16  ->  zero-ref    "field V08.W (fldOffset=0x30)" P-INDEP
 ;* V17 tmp15        [V17    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[000..016)"
 ;* V18 tmp16        [V18    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[016..032)"
 ;* V19 tmp17        [V19    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[032..048)"
 ;* V20 tmp18        [V20    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[048..064)"
-;  V21 cse0         [V21,T01] (  5,  5   )  simd16  ->  mm4         "CSE - aggressive"
+;* V21 cse0         [V21,T09] (  0,  0   )  simd16  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -37,33 +37,22 @@ G_M5209_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M5209_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovups  xmm0, xmmword ptr [reloc @RWD00]
-       vmovups  xmm1, xmmword ptr [reloc @RWD16]
-       vmovups  xmm2, xmmword ptr [reloc @RWD32]
-       vmovups  xmm3, xmmword ptr [reloc @RWD48]
-       vmovups  xmm4, xmmword ptr [reloc @RWD64]
-       vxorps   xmm0, xmm4, xmm0
-       vxorps   xmm1, xmm4, xmm1
-       vxorps   xmm2, xmm4, xmm2
-       vxorps   xmm3, xmm4, xmm3
-       vmovups  xmmword ptr [rdx], xmm0
-       vmovups  xmmword ptr [rdx+0x10], xmm1
-       vmovups  xmmword ptr [rdx+0x20], xmm2
-       vmovups  xmmword ptr [rdx+0x30], xmm3
+       vmovups  ymm0, ymmword ptr [reloc @RWD00]
+       vmovups  ymmword ptr [rdx], ymm0
+       vmovups  ymm0, ymmword ptr [reloc @RWD32]
+       vmovups  ymmword ptr [rdx+0x20], ymm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=78 bbWeight=1 PerfScore 24.58
+						;; size=28 bbWeight=1 PerfScore 12.25
 G_M5209_IG03:        ; bbWeight=1, epilog, nogc, extend
+       vzeroupper 
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
-RWD00  	dq	000000003F800000h, 0000000000000000h
-RWD16  	dq	3F80000000000000h, 0000000000000000h
-RWD32  	dq	0000000000000000h, 000000003F800000h
-RWD48  	dq	0000000000000000h, 3F80000000000000h
-RWD64  	dq	8000000080000000h, 8000000080000000h
+						;; size=4 bbWeight=1 PerfScore 2.00
+RWD00  	dq	80000000BF800000h, 8000000080000000h, BF80000080000000h, 8000000080000000h
+RWD32  	dq	8000000080000000h, 80000000BF800000h, 8000000080000000h, BF80000080000000h
 
 
-; Total bytes of code 79, prolog size 0, PerfScore 25.58, instruction count 15, allocated bytes for code 79 (MethodHash=bd5deba6) for method System.Numerics.Tests.Perf_Matrix4x4:NegateBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
+; Total bytes of code 32, prolog size 0, PerfScore 14.25, instruction count 7, allocated bytes for code 32 (MethodHash=bd5deba6) for method System.Numerics.Tests.Perf_Matrix4x4:NegateBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-59.49%</span>) : 21364.dasm - System.Numerics.Tests.Perf_Matrix4x4:NegationOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Numerics.Tests.Perf_Matrix4x4>
-;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rdx         single-def
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] "spilled call-like call argument" <System.Numerics.Matrix4x4>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix4x4+Impl>
@@ -17,19 +17,19 @@
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Numerics.Matrix4x4>
 ;* V07 tmp5         [V07    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[S] ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix4x4+Impl>
 ;* V08 tmp6         [V08    ] (  0,  0   )  struct (64) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix4x4+Impl>
-;  V09 tmp7         [V09,T02] (  2,  2   )  simd16  ->  mm0         "field V05.X (fldOffset=0x0)" P-INDEP
-;  V10 tmp8         [V10,T03] (  2,  2   )  simd16  ->  mm1         "field V05.Y (fldOffset=0x10)" P-INDEP
-;  V11 tmp9         [V11,T04] (  2,  2   )  simd16  ->  mm2         "field V05.Z (fldOffset=0x20)" P-INDEP
-;  V12 tmp10        [V12,T05] (  2,  2   )  simd16  ->  mm3         "field V05.W (fldOffset=0x30)" P-INDEP
-;  V13 tmp11        [V13,T06] (  2,  2   )  simd16  ->  mm0         "field V08.X (fldOffset=0x0)" P-INDEP
-;  V14 tmp12        [V14,T07] (  2,  2   )  simd16  ->  mm1         "field V08.Y (fldOffset=0x10)" P-INDEP
-;  V15 tmp13        [V15,T08] (  2,  2   )  simd16  ->  mm2         "field V08.Z (fldOffset=0x20)" P-INDEP
-;  V16 tmp14        [V16,T09] (  2,  2   )  simd16  ->  mm3         "field V08.W (fldOffset=0x30)" P-INDEP
+;* V09 tmp7         [V09,T01] (  0,  0   )  simd16  ->  zero-ref    "field V05.X (fldOffset=0x0)" P-INDEP
+;* V10 tmp8         [V10,T02] (  0,  0   )  simd16  ->  zero-ref    "field V05.Y (fldOffset=0x10)" P-INDEP
+;* V11 tmp9         [V11,T03] (  0,  0   )  simd16  ->  zero-ref    "field V05.Z (fldOffset=0x20)" P-INDEP
+;* V12 tmp10        [V12,T04] (  0,  0   )  simd16  ->  zero-ref    "field V05.W (fldOffset=0x30)" P-INDEP
+;* V13 tmp11        [V13,T05] (  0,  0   )  simd16  ->  zero-ref    "field V08.X (fldOffset=0x0)" P-INDEP
+;* V14 tmp12        [V14,T06] (  0,  0   )  simd16  ->  zero-ref    "field V08.Y (fldOffset=0x10)" P-INDEP
+;* V15 tmp13        [V15,T07] (  0,  0   )  simd16  ->  zero-ref    "field V08.Z (fldOffset=0x20)" P-INDEP
+;* V16 tmp14        [V16,T08] (  0,  0   )  simd16  ->  zero-ref    "field V08.W (fldOffset=0x30)" P-INDEP
 ;* V17 tmp15        [V17    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[000..016)"
 ;* V18 tmp16        [V18    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[016..032)"
 ;* V19 tmp17        [V19    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[032..048)"
 ;* V20 tmp18        [V20    ] (  0,  0   )  simd16  ->  zero-ref    "V06.[048..064)"
-;  V21 cse0         [V21,T01] (  5,  5   )  simd16  ->  mm4         "CSE - aggressive"
+;* V21 cse0         [V21,T09] (  0,  0   )  simd16  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -37,33 +37,22 @@ G_M43284_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M43284_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovups  xmm0, xmmword ptr [reloc @RWD00]
-       vmovups  xmm1, xmmword ptr [reloc @RWD16]
-       vmovups  xmm2, xmmword ptr [reloc @RWD32]
-       vmovups  xmm3, xmmword ptr [reloc @RWD48]
-       vmovups  xmm4, xmmword ptr [reloc @RWD64]
-       vxorps   xmm0, xmm4, xmm0
-       vxorps   xmm1, xmm4, xmm1
-       vxorps   xmm2, xmm4, xmm2
-       vxorps   xmm3, xmm4, xmm3
-       vmovups  xmmword ptr [rdx], xmm0
-       vmovups  xmmword ptr [rdx+0x10], xmm1
-       vmovups  xmmword ptr [rdx+0x20], xmm2
-       vmovups  xmmword ptr [rdx+0x30], xmm3
+       vmovups  ymm0, ymmword ptr [reloc @RWD00]
+       vmovups  ymmword ptr [rdx], ymm0
+       vmovups  ymm0, ymmword ptr [reloc @RWD32]
+       vmovups  ymmword ptr [rdx+0x20], ymm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=78 bbWeight=1 PerfScore 24.58
+						;; size=28 bbWeight=1 PerfScore 12.25
 G_M43284_IG03:        ; bbWeight=1, epilog, nogc, extend
+       vzeroupper 
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
-RWD00  	dq	000000003F800000h, 0000000000000000h
-RWD16  	dq	3F80000000000000h, 0000000000000000h
-RWD32  	dq	0000000000000000h, 000000003F800000h
-RWD48  	dq	0000000000000000h, 3F80000000000000h
-RWD64  	dq	8000000080000000h, 8000000080000000h
+						;; size=4 bbWeight=1 PerfScore 2.00
+RWD00  	dq	80000000BF800000h, 8000000080000000h, BF80000080000000h, 8000000080000000h
+RWD32  	dq	8000000080000000h, 80000000BF800000h, 8000000080000000h, BF80000080000000h
 
 
-; Total bytes of code 79, prolog size 0, PerfScore 25.58, instruction count 15, allocated bytes for code 79 (MethodHash=aba756eb) for method System.Numerics.Tests.Perf_Matrix4x4:NegationOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
+; Total bytes of code 32, prolog size 0, PerfScore 14.25, instruction count 7, allocated bytes for code 32 (MethodHash=aba756eb) for method System.Numerics.Tests.Perf_Matrix4x4:NegationOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+32</span> (<span style="color:red">+28.83%</span>) : 22290.dasm - System.Numerics.Tests.Perf_Matrix4x4:AddBenchmark():System.Numerics.Matrix4x4:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -26,10 +26,10 @@
 ;* V15 tmp13        [V15,T15] (  0,  0   )  simd16  ->  zero-ref    "field V06.Y (fldOffset=0x10)" P-INDEP
 ;* V16 tmp14        [V16,T16] (  0,  0   )  simd16  ->  zero-ref    "field V06.Z (fldOffset=0x20)" P-INDEP
 ;* V17 tmp15        [V17,T17] (  0,  0   )  simd16  ->  zero-ref    "field V06.W (fldOffset=0x30)" P-INDEP
-;  V18 tmp16        [V18,T02] (  3,  3   )  simd16  ->  mm0         "field V08.X (fldOffset=0x0)" P-INDEP
-;  V19 tmp17        [V19,T03] (  3,  3   )  simd16  ->  mm1         "field V08.Y (fldOffset=0x10)" P-INDEP
-;  V20 tmp18        [V20,T04] (  3,  3   )  simd16  ->  mm2         "field V08.Z (fldOffset=0x20)" P-INDEP
-;  V21 tmp19        [V21,T05] (  3,  3   )  simd16  ->  mm3         "field V08.W (fldOffset=0x30)" P-INDEP
+;  V18 tmp16        [V18,T06] (  2,  2   )  simd16  ->  mm0         "field V08.X (fldOffset=0x0)" P-INDEP
+;  V19 tmp17        [V19,T07] (  2,  2   )  simd16  ->  mm1         "field V08.Y (fldOffset=0x10)" P-INDEP
+;  V20 tmp18        [V20,T08] (  2,  2   )  simd16  ->  mm2         "field V08.Z (fldOffset=0x20)" P-INDEP
+;  V21 tmp19        [V21,T09] (  2,  2   )  simd16  ->  mm3         "field V08.W (fldOffset=0x30)" P-INDEP
 ;  V22 tmp20        [V22,T10] (  2,  2   )  simd16  ->  mm0         "field V13.X (fldOffset=0x0)" P-INDEP
 ;  V23 tmp21        [V23,T11] (  2,  2   )  simd16  ->  mm1         "field V13.Y (fldOffset=0x10)" P-INDEP
 ;  V24 tmp22        [V24,T12] (  2,  2   )  simd16  ->  mm2         "field V13.Z (fldOffset=0x20)" P-INDEP
@@ -46,10 +46,10 @@
 ;* V35 tmp33        [V35    ] (  0,  0   )  simd16  ->  zero-ref    "V04.[016..032)"
 ;* V36 tmp34        [V36    ] (  0,  0   )  simd16  ->  zero-ref    "V04.[032..048)"
 ;* V37 tmp35        [V37    ] (  0,  0   )  simd16  ->  zero-ref    "V04.[048..064)"
-;  V38 cse0         [V38,T06] (  2,  2   )  simd16  ->  mm0         "CSE - aggressive"
-;  V39 cse1         [V39,T07] (  2,  2   )  simd16  ->  mm1         "CSE - aggressive"
-;  V40 cse2         [V40,T08] (  2,  2   )  simd16  ->  mm2         "CSE - aggressive"
-;  V41 cse3         [V41,T09] (  2,  2   )  simd16  ->  mm3         "CSE - aggressive"
+;  V38 cse0         [V38,T02] (  2,  2   )  simd16  ->  mm0         "CSE - aggressive"
+;  V39 cse1         [V39,T03] (  2,  2   )  simd16  ->  mm1         "CSE - aggressive"
+;  V40 cse2         [V40,T04] (  2,  2   )  simd16  ->  mm2         "CSE - aggressive"
+;  V41 cse3         [V41,T05] (  2,  2   )  simd16  ->  mm3         "CSE - aggressive"
 ;
 ; Lcl frame size = 72
 
@@ -62,10 +62,14 @@ G_M37316_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        vmovups  xmm1, xmmword ptr [reloc @RWD16]
        vmovups  xmm2, xmmword ptr [reloc @RWD32]
        vmovups  xmm3, xmmword ptr [reloc @RWD48]
-       vmovups  xmmword ptr [rsp+0x08], xmm0
-       vmovups  xmmword ptr [rsp+0x18], xmm1
-       vmovups  xmmword ptr [rsp+0x28], xmm2
-       vmovups  xmmword ptr [rsp+0x38], xmm3
+       vmovups  xmm4, xmmword ptr [reloc @RWD00]
+       vmovups  xmmword ptr [rsp+0x08], xmm4
+       vmovups  xmm4, xmmword ptr [reloc @RWD16]
+       vmovups  xmmword ptr [rsp+0x18], xmm4
+       vmovups  xmm4, xmmword ptr [reloc @RWD32]
+       vmovups  xmmword ptr [rsp+0x28], xmm4
+       vmovups  xmm4, xmmword ptr [reloc @RWD48]
+       vmovups  xmmword ptr [rsp+0x38], xmm4
        lea      rax, bword ptr [rsp+0x08]
        ; byrRegs +[rax]
        vaddps   xmm0, xmm0, xmmword ptr [rax]
@@ -77,7 +81,7 @@ G_M37316_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        vmovups  xmmword ptr [rdx+0x20], xmm2
        vmovups  xmmword ptr [rdx+0x30], xmm3
        mov      rax, rdx
-						;; size=102 bbWeight=1 PerfScore 48.75
+						;; size=134 bbWeight=1 PerfScore 60.75
 G_M37316_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 72
        ret      
@@ -88,7 +92,7 @@ RWD32  	dq	0000000000000000h, 000000003F800000h
 RWD48  	dq	0000000000000000h, 3F80000000000000h
 
 
-; Total bytes of code 111, prolog size 4, PerfScore 50.25, instruction count 21, allocated bytes for code 111 (MethodHash=89726e3b) for method System.Numerics.Tests.Perf_Matrix4x4:AddBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
+; Total bytes of code 143, prolog size 4, PerfScore 62.25, instruction count 25, allocated bytes for code 143 (MethodHash=89726e3b) for method System.Numerics.Tests.Perf_Matrix4x4:AddBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+32</span> (<span style="color:red">+28.83%</span>) : 35795.dasm - System.Numerics.Tests.Perf_Matrix4x4:AddOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -26,10 +26,10 @@
 ;* V15 tmp13        [V15,T15] (  0,  0   )  simd16  ->  zero-ref    "field V06.Y (fldOffset=0x10)" P-INDEP
 ;* V16 tmp14        [V16,T16] (  0,  0   )  simd16  ->  zero-ref    "field V06.Z (fldOffset=0x20)" P-INDEP
 ;* V17 tmp15        [V17,T17] (  0,  0   )  simd16  ->  zero-ref    "field V06.W (fldOffset=0x30)" P-INDEP
-;  V18 tmp16        [V18,T02] (  3,  3   )  simd16  ->  mm0         "field V08.X (fldOffset=0x0)" P-INDEP
-;  V19 tmp17        [V19,T03] (  3,  3   )  simd16  ->  mm1         "field V08.Y (fldOffset=0x10)" P-INDEP
-;  V20 tmp18        [V20,T04] (  3,  3   )  simd16  ->  mm2         "field V08.Z (fldOffset=0x20)" P-INDEP
-;  V21 tmp19        [V21,T05] (  3,  3   )  simd16  ->  mm3         "field V08.W (fldOffset=0x30)" P-INDEP
+;  V18 tmp16        [V18,T06] (  2,  2   )  simd16  ->  mm0         "field V08.X (fldOffset=0x0)" P-INDEP
+;  V19 tmp17        [V19,T07] (  2,  2   )  simd16  ->  mm1         "field V08.Y (fldOffset=0x10)" P-INDEP
+;  V20 tmp18        [V20,T08] (  2,  2   )  simd16  ->  mm2         "field V08.Z (fldOffset=0x20)" P-INDEP
+;  V21 tmp19        [V21,T09] (  2,  2   )  simd16  ->  mm3         "field V08.W (fldOffset=0x30)" P-INDEP
 ;  V22 tmp20        [V22,T10] (  2,  2   )  simd16  ->  mm0         "field V13.X (fldOffset=0x0)" P-INDEP
 ;  V23 tmp21        [V23,T11] (  2,  2   )  simd16  ->  mm1         "field V13.Y (fldOffset=0x10)" P-INDEP
 ;  V24 tmp22        [V24,T12] (  2,  2   )  simd16  ->  mm2         "field V13.Z (fldOffset=0x20)" P-INDEP
@@ -46,10 +46,10 @@
 ;* V35 tmp33        [V35    ] (  0,  0   )  simd16  ->  zero-ref    "V04.[016..032)"
 ;* V36 tmp34        [V36    ] (  0,  0   )  simd16  ->  zero-ref    "V04.[032..048)"
 ;* V37 tmp35        [V37    ] (  0,  0   )  simd16  ->  zero-ref    "V04.[048..064)"
-;  V38 cse0         [V38,T06] (  2,  2   )  simd16  ->  mm0         "CSE - aggressive"
-;  V39 cse1         [V39,T07] (  2,  2   )  simd16  ->  mm1         "CSE - aggressive"
-;  V40 cse2         [V40,T08] (  2,  2   )  simd16  ->  mm2         "CSE - aggressive"
-;  V41 cse3         [V41,T09] (  2,  2   )  simd16  ->  mm3         "CSE - aggressive"
+;  V38 cse0         [V38,T02] (  2,  2   )  simd16  ->  mm0         "CSE - aggressive"
+;  V39 cse1         [V39,T03] (  2,  2   )  simd16  ->  mm1         "CSE - aggressive"
+;  V40 cse2         [V40,T04] (  2,  2   )  simd16  ->  mm2         "CSE - aggressive"
+;  V41 cse3         [V41,T05] (  2,  2   )  simd16  ->  mm3         "CSE - aggressive"
 ;
 ; Lcl frame size = 72
 
@@ -62,10 +62,14 @@ G_M29412_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        vmovups  xmm1, xmmword ptr [reloc @RWD16]
        vmovups  xmm2, xmmword ptr [reloc @RWD32]
        vmovups  xmm3, xmmword ptr [reloc @RWD48]
-       vmovups  xmmword ptr [rsp+0x08], xmm0
-       vmovups  xmmword ptr [rsp+0x18], xmm1
-       vmovups  xmmword ptr [rsp+0x28], xmm2
-       vmovups  xmmword ptr [rsp+0x38], xmm3
+       vmovups  xmm4, xmmword ptr [reloc @RWD00]
+       vmovups  xmmword ptr [rsp+0x08], xmm4
+       vmovups  xmm4, xmmword ptr [reloc @RWD16]
+       vmovups  xmmword ptr [rsp+0x18], xmm4
+       vmovups  xmm4, xmmword ptr [reloc @RWD32]
+       vmovups  xmmword ptr [rsp+0x28], xmm4
+       vmovups  xmm4, xmmword ptr [reloc @RWD48]
+       vmovups  xmmword ptr [rsp+0x38], xmm4
        lea      rax, bword ptr [rsp+0x08]
        ; byrRegs +[rax]
        vaddps   xmm0, xmm0, xmmword ptr [rax]
@@ -77,7 +81,7 @@ G_M29412_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        vmovups  xmmword ptr [rdx+0x20], xmm2
        vmovups  xmmword ptr [rdx+0x30], xmm3
        mov      rax, rdx
-						;; size=102 bbWeight=1 PerfScore 48.75
+						;; size=134 bbWeight=1 PerfScore 60.75
 G_M29412_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 72
        ret      
@@ -88,7 +92,7 @@ RWD32  	dq	0000000000000000h, 000000003F800000h
 RWD48  	dq	0000000000000000h, 3F80000000000000h
 
 
-; Total bytes of code 111, prolog size 4, PerfScore 50.25, instruction count 21, allocated bytes for code 111 (MethodHash=a2f78d1b) for method System.Numerics.Tests.Perf_Matrix4x4:AddOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
+; Total bytes of code 143, prolog size 4, PerfScore 62.25, instruction count 25, allocated bytes for code 143 (MethodHash=a2f78d1b) for method System.Numerics.Tests.Perf_Matrix4x4:AddOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+15</span> (<span style="color:red">+45.45%</span>) : 34824.dasm - HardwareIntrinsics.RayTracer.Surfaces+<>c:<.cctor>b__5_4(HardwareIntrinsics.RayTracer.VectorPacket256):HardwareIntrinsics.RayTracer.VectorPacket256:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,11 +16,11 @@
 ;* V05 tmp2         [V05    ] (  0,  0   )  simd32  ->  zero-ref    "field V02.Xs (fldOffset=0x0)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )  simd32  ->  zero-ref    "field V02.Ys (fldOffset=0x20)" P-INDEP
 ;* V07 tmp4         [V07    ] (  0,  0   )  simd32  ->  zero-ref    "field V02.Zs (fldOffset=0x40)" P-INDEP
-;* V08 tmp5         [V08,T04] (  0,  0   )  simd32  ->  zero-ref    "field V04.Xs (fldOffset=0x0)" P-INDEP
-;  V09 tmp6         [V09,T03] (  2,  2   )  simd32  ->  mm1         "field V04.Ys (fldOffset=0x20)" P-INDEP
-;  V10 tmp7         [V10,T02] (  3,  3   )  simd32  ->  mm0         "field V04.Zs (fldOffset=0x40)" P-INDEP
+;* V08 tmp5         [V08,T02] (  0,  0   )  simd32  ->  zero-ref    "field V04.Xs (fldOffset=0x0)" P-INDEP
+;* V09 tmp6         [V09,T03] (  0,  0   )  simd32  ->  zero-ref    "field V04.Ys (fldOffset=0x20)" P-INDEP
+;* V10 tmp7         [V10,T04] (  0,  0   )  simd32  ->  zero-ref    "field V04.Zs (fldOffset=0x40)" P-INDEP
 ;* V11 tmp8         [V11    ] (  0,  0   )  struct (96) zero-ref    "Promoted implicit byref" <HardwareIntrinsics.RayTracer.VectorPacket256>
-;  V12 cse0         [V12,T01] (  3,  3   )  simd32  ->  mm0         "CSE - aggressive"
+;* V12 cse0         [V12,T01] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -28,22 +28,23 @@ G_M21497_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M21497_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovups  ymm0, ymmword ptr [reloc @RWD00]
-       vmovaps  ymm1, ymm0
-       vmovups  ymmword ptr [rdx], ymm1
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
+       vmovups  ymmword ptr [rdx], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x20], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x40], ymm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=29 bbWeight=1 PerfScore 10.50
+						;; size=44 bbWeight=1 PerfScore 18.25
 G_M21497_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.00
-RWD00  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+RWD00  	dq	3F8000003F800000h, 3F8000003F800000h
 
 
-; Total bytes of code 33, prolog size 0, PerfScore 12.50, instruction count 8, allocated bytes for code 33 (MethodHash=a655ac06) for method HardwareIntrinsics.RayTracer.Surfaces+<>c:<.cctor>b__5_4(HardwareIntrinsics.RayTracer.VectorPacket256):HardwareIntrinsics.RayTracer.VectorPacket256:this (FullOpts)
+; Total bytes of code 48, prolog size 0, PerfScore 20.25, instruction count 9, allocated bytes for code 48 (MethodHash=a655ac06) for method HardwareIntrinsics.RayTracer.Surfaces+<>c:<.cctor>b__5_4(HardwareIntrinsics.RayTracer.VectorPacket256):HardwareIntrinsics.RayTracer.VectorPacket256:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-40.91%</span>) : 63143.dasm - System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 TypeCtx      [V00    ] (  0,  0   )    long  ->  zero-ref    single-def
-;  V01 arg0         [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
+;  V01 arg0         [V01,T00] (  4,  4   )   byref  ->  rdx         single-def
 ;* V02 arg1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
 ;* V03 arg2         [V03    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -31,12 +31,10 @@
 G_M43397_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M43397_IG02:        ; bbWeight=1, gcrefRegs=0300 {r8 r9}, byrefRegs=0004 {rdx}, byref, isz
+G_M43397_IG02:        ; bbWeight=1, gcrefRegs=0300 {r8 r9}, byrefRegs=0004 {rdx}, byref
        ; gcrRegs +[r8-r9]
        ; byrRegs +[rdx]
        cmp      byte  ptr [rdx], dl
-       test     rdx, rdx
-       je       SHORT G_M43397_IG04
        mov      rcx, rdx
        ; byrRegs +[rcx]
        mov      rdx, r8
@@ -48,20 +46,13 @@ G_M43397_IG02:        ; bbWeight=1, gcrefRegs=0300 {r8 r9}, byrefRegs=0004 {rdx}
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        nop      
-						;; size=22 bbWeight=1 PerfScore 6.25
+						;; size=17 bbWeight=1 PerfScore 5.00
 G_M43397_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M43397_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowNullReferenceException()
-       call     [rax]System.ThrowHelper:ThrowNullReferenceException()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 44, prolog size 4, PerfScore 7.75, instruction count 14, allocated bytes for code 44 (MethodHash=22ff567a) for method System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)
+; Total bytes of code 26, prolog size 4, PerfScore 6.50, instruction count 9, allocated bytes for code 26 (MethodHash=22ff567a) for method System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-43</span> (<span style="color:green">-33.08%</span>) : 97365.dasm - SciMark2.FFT:inverse(double[]) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -5,17 +5,17 @@
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 8
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 8
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T02] (  7, 364037.00)     ref  ->  rbx         class-hnd single-def <double[]>
-;  V01 loc0         [V01,T03] (  6, 364036   )     int  ->  rcx         single-def
+;  V00 arg0         [V00,T02] (  5, 360395.68)     ref  ->  rbx         class-hnd single-def <double[]>
+;  V01 loc0         [V01,T03] (  5, 360395.68)     int  ->  rax         single-def
 ;* V02 loc1         [V02    ] (  0,      0   )     int  ->  zero-ref   
-;  V03 loc2         [V03,T05] (  3, 364033   )  double  ->  mm0         single-def
-;  V04 loc3         [V04,T01] ( 11,1459770.32)     int  ->  rdx        
+;  V03 loc2         [V03,T05] (  2, 360392.68)  double  ->  mm0         single-def
+;  V04 loc3         [V04,T01] (  5,1441567.72)     int  ->  rcx        
 ;  V05 OutArgs      [V05    ] (  1,      1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T00] (  6,2184192   )   byref  ->  registers   "dup spill"
-;  V07 cse0         [V07,T04] (  3,   3642.32)     int  ->  rax         "CSE - aggressive"
+;  V06 tmp1         [V06,T00] (  3,2162350.08)   byref  ->  rdx         "dup spill"
+;  V07 cse0         [V07,T04] (  2,      2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -34,66 +34,38 @@ G_M10854_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcr arg pop 0
        mov      eax, dword ptr [rbx+0x08]
        mov      ecx, eax
-       mov      edx, ecx
-       shr      edx, 31
-       add      edx, ecx
-       sar      edx, 1
+       shr      ecx, 31
+       add      ecx, eax
+       sar      ecx, 1
        vxorps   xmm0, xmm0, xmm0
-       vcvtsi2sd xmm0, xmm0, edx
+       vcvtsi2sd xmm0, xmm0, ecx
        vmovsd   xmm1, qword ptr [reloc @RWD00]
        vdivsd   xmm0, xmm1, xmm0
-       xor      edx, edx
-       cmp      edx, ecx
-       jge      SHORT G_M10854_IG07
-						;; size=54 bbWeight=1 PerfScore 30.08
-G_M10854_IG03:        ; bbWeight=1.00, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     rbx, rbx
-       je       SHORT G_M10854_IG06
-						;; size=5 bbWeight=1.00 PerfScore 1.25
-G_M10854_IG04:        ; bbWeight=360391.68, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, edx
-       lea      rax, bword ptr [rbx+8*rax+0x10]
-       ; byrRegs +[rax]
-       vmulsd   xmm1, xmm0, qword ptr [rax]
-       vmovsd   qword ptr [rax], xmm1
-       inc      edx
-       cmp      edx, ecx
-       jl       SHORT G_M10854_IG04
+       xor      ecx, ecx
+       test     eax, eax
+       jle      SHORT G_M10854_IG04
+						;; size=52 bbWeight=1 PerfScore 29.83
+G_M10854_IG03:        ; bbWeight=360391.68, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      edx, ecx
+       lea      rdx, bword ptr [rbx+8*rdx+0x10]
+       ; byrRegs +[rdx]
+       vmulsd   xmm1, xmm0, qword ptr [rdx]
+       vmovsd   qword ptr [rdx], xmm1
+       inc      ecx
+       cmp      ecx, eax
+       jl       SHORT G_M10854_IG03
 						;; size=21 bbWeight=360391.68 PerfScore 3874210.56
-G_M10854_IG05:        ; bbWeight=0.00, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M10854_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rbx]
-       ; byrRegs -[rax]
-       jmp      SHORT G_M10854_IG07
-						;; size=2 bbWeight=0.00 PerfScore 0.00
-G_M10854_IG06:        ; bbWeight=3640.32, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rbx]
-       cmp      edx, eax
-       jae      SHORT G_M10854_IG08
-       mov      r8d, edx
-       lea      r8, bword ptr [rbx+8*r8+0x10]
-       ; byrRegs +[r8]
-       vmulsd   xmm1, xmm0, qword ptr [r8]
-       vmovsd   qword ptr [r8], xmm1
-       inc      edx
-       cmp      edx, ecx
-       jl       SHORT G_M10854_IG06
-						;; size=28 bbWeight=3640.32 PerfScore 43683.84
-G_M10854_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       ; byrRegs -[r8]
+       ; byrRegs -[rdx]
        add      rsp, 32
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
-G_M10854_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 RWD00  	dq	3FF0000000000000h	;            1
 
 
-; Total bytes of code 130, prolog size 8, PerfScore 3917928.98, instruction count 43, allocated bytes for code 130 (MethodHash=c9bbd599) for method SciMark2.FFT:inverse(double[]) (Tier1)
+; Total bytes of code 87, prolog size 8, PerfScore 3874243.64, instruction count 28, allocated bytes for code 87 (MethodHash=c9bbd599) for method SciMark2.FFT:inverse(double[]) (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-29</span> (<span style="color:green">-31.18%</span>) : 41510.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T02] (  6,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V03 tmp2         [V03,T01] (  7,  3   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V02 tmp1         [V02,T01] (  6,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V03 tmp2         [V03,T02] (  2,  2   )     int  ->  rax         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;
 ; Lcl frame size = 40
@@ -23,55 +23,40 @@ G_M54145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
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
-       cmp      ecx, 1
-       jbe      SHORT G_M54145_IG05
+       je       SHORT G_M54145_IG06
        cmp      word  ptr [rdx+0x02], 63
        jne      SHORT G_M54145_IG03
-						;; size=24 bbWeight=0 PerfScore 0.00
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
 
-; Total bytes of code 93, prolog size 4, PerfScore 12.25, instruction count 32, allocated bytes for code 93 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
+; Total bytes of code 64, prolog size 4, PerfScore 11.00, instruction count 21, allocated bytes for code 64 (MethodHash=b9322c7e) for method System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+6.28%</span>) : 99201.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 3 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 11,  6   )   byref  ->  [rsp+0x40]  this single-def
+;  V00 this         [V00,T00] ( 12,  6   )   byref  ->  [rsp+0x40]  this single-def
 ;  V01 arg1         [V01,T01] ( 10,  4   )     int  ->  rsi         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;  V03 loc1         [V03,T02] (  7,  6   )     int  ->  rcx        
@@ -17,38 +17,39 @@
 ;  V05 tmp1         [V05,T07] (  2,  0   )     int  ->  rcx        
 ;* V06 tmp2         [V06    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V07 tmp3         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V08 tmp4         [V08,T06] (  2,  2   )     int  ->  rdx        
+;  V08 tmp4         [V08,T06] (  3,  2   )     int  ->  rdi        
 ;  V09 tmp5         [V09,T08] (  3,  0   )     int  ->  rcx        
 ;* V10 tmp6         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V11 tmp7         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V12 tmp8         [V12    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V13 tmp9         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V14 cse0         [V14,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V15 cse1         [V15,T04] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V16 cse2         [V16,T05] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V14 cse0         [V14,T04] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V15 cse1         [V15,T05] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse2         [V16,T03] (  5,  3   )     int  ->  rdi         "CSE - aggressive"
 ;  V17 rat0         [V17,T09] (  3,  0   )     int  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;  V18 rat1         [V18,T10] (  3,  0   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M55570_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        vzeroupper 
        mov      rbx, rcx
        ; byrRegs +[rbx]
        mov      esi, edx
-						;; size=14 bbWeight=1 PerfScore 3.75
+						;; size=15 bbWeight=1 PerfScore 4.75
 G_M55570_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        cmp      esi, -1
-       jl       SHORT G_M55570_IG09
+       jl       SHORT G_M55570_IG11
        test     esi, esi
-       jge      G_M55570_IG10
+       jge      G_M55570_IG12
 						;; size=13 bbWeight=1 PerfScore 2.50
 G_M55570_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        cmp      dword ptr [rbx], 10
-       jge      G_M55570_IG11
+       jge      G_M55570_IG13
 						;; size=9 bbWeight=1 PerfScore 4.00
 G_M55570_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        call     <unknown method>
@@ -67,7 +68,7 @@ G_M55570_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
 G_M55570_IG05:        ; bbWeight=1, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rbx]
        cmp      ecx, 0x400
-       jge      G_M55570_IG16
+       jge      G_M55570_IG18
        mov      rax, 0xD1FFAB1E      ; function address
 						;; size=22 bbWeight=1 PerfScore 1.50
 G_M55570_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
@@ -81,21 +82,25 @@ G_M55570_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M55570_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rbx, bword ptr [rsp+0x40]
        ; byrRegs +[rbx]
-       mov      ecx, dword ptr [rbx]
-       mov      edx, 10
-       lea      eax, [rcx+0x01]
-       cmp      ecx, 0xD1FFAB1E
-       cmovne   edx, eax
-       mov      dword ptr [rbx], edx
-						;; size=26 bbWeight=1 PerfScore 5.25
-G_M55570_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       mov      edi, dword ptr [rbx]
+       cmp      edi, 0xD1FFAB1E
+       je       G_M55570_IG19
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M55570_IG08:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; GC ptr vars -{V00}
+       inc      edi
+						;; size=2 bbWeight=1 PerfScore 0.25
+G_M55570_IG09:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       mov      dword ptr [rbx], edi
+						;; size=2 bbWeight=1 PerfScore 1.00
+G_M55570_IG10:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
-G_M55570_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
-       ; GC ptr vars -{V00}
+						;; size=8 bbWeight=1 PerfScore 2.75
+G_M55570_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        mov      rdx, 0xD1FFAB1E
@@ -106,7 +111,7 @@ G_M55570_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        test     esi, esi
        jl       G_M55570_IG03
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M55570_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M55570_IG12:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        xor      ecx, ecx
        cmp      esi, 10
        setge    cl
@@ -122,23 +127,23 @@ G_M55570_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        cmp      dword ptr [rbx], 10
        jl       G_M55570_IG04
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M55570_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        cmp      dword ptr [rbx], esi
-       jl       SHORT G_M55570_IG12
+       jl       SHORT G_M55570_IG14
        test     esi, esi
-       jge      SHORT G_M55570_IG13
+       jge      SHORT G_M55570_IG15
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M55570_IG12:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        mov      ecx, dword ptr [rbx]
        add      ecx, -10
        test     cl, 1
        jne      G_M55570_IG04
        cmp      dword ptr [rbx], esi
-       jl       SHORT G_M55570_IG14
+       jl       SHORT G_M55570_IG16
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        test     esi, esi
-       jl       SHORT G_M55570_IG14
+       jl       SHORT G_M55570_IG16
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -146,7 +151,7 @@ G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG07
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; GC ptr vars -{V00}
        mov      ecx, dword ptr [rbx]
        add      ecx, -10
@@ -164,7 +169,7 @@ G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        lea      eax, [rax+4*rax]
        sub      ecx, eax
        cmp      ecx, 4
-       jne      SHORT G_M55570_IG15
+       jne      SHORT G_M55570_IG17
        xor      ecx, ecx
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -172,7 +177,7 @@ G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG07
 						;; size=63 bbWeight=0 PerfScore 0.00
-G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M55570_IG17:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; GC ptr vars -{V00}
        call     <unknown method>
        ; gcr arg pop 0
@@ -180,14 +185,23 @@ G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG07
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M55570_IG16:        ; bbWeight=0, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M55570_IG18:        ; bbWeight=0, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rbx]
        call     [<unknown method>]
        ; gcr arg pop 0
-       jmp      G_M55570_IG07
-						;; size=11 bbWeight=0 PerfScore 0.00
+       mov      rbx, bword ptr [rsp+0x40]
+       ; byrRegs +[rbx]
+       mov      edi, dword ptr [rbx]
+       cmp      edi, 0xD1FFAB1E
+       jne      G_M55570_IG08
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M55570_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; GC ptr vars -{V00}
+       mov      edi, 10
+       jmp      G_M55570_IG09
+						;; size=10 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 366, prolog size 9, PerfScore 34.00, instruction count 97, allocated bytes for code 366 (MethodHash=565b26ed) for method System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
+; Total bytes of code 389, prolog size 10, PerfScore 35.75, instruction count 103, allocated bytes for code 389 (MethodHash=565b26ed) for method System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -195,11 +209,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x07
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+6.28%</span>) : 19614.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 3 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 11,  6   )   byref  ->  [rsp+0x40]  this single-def
+;  V00 this         [V00,T00] ( 12,  6   )   byref  ->  [rsp+0x40]  this single-def
 ;  V01 arg1         [V01,T01] ( 10,  4   )     int  ->  rsi         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;  V03 loc1         [V03,T02] (  7,  6   )     int  ->  rcx        
@@ -17,38 +17,39 @@
 ;  V05 tmp1         [V05,T07] (  2,  0   )     int  ->  rcx        
 ;* V06 tmp2         [V06    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V07 tmp3         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V08 tmp4         [V08,T06] (  2,  2   )     int  ->  rdx        
+;  V08 tmp4         [V08,T06] (  3,  2   )     int  ->  rdi        
 ;  V09 tmp5         [V09,T08] (  3,  0   )     int  ->  rcx        
 ;* V10 tmp6         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V11 tmp7         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V12 tmp8         [V12    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V13 tmp9         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V14 cse0         [V14,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V15 cse1         [V15,T04] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V16 cse2         [V16,T05] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V14 cse0         [V14,T04] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V15 cse1         [V15,T05] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse2         [V16,T03] (  5,  3   )     int  ->  rdi         "CSE - aggressive"
 ;  V17 rat0         [V17,T09] (  3,  0   )     int  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;  V18 rat1         [V18,T10] (  3,  0   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M55570_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        vzeroupper 
        mov      rbx, rcx
        ; byrRegs +[rbx]
        mov      esi, edx
-						;; size=14 bbWeight=1 PerfScore 3.75
+						;; size=15 bbWeight=1 PerfScore 4.75
 G_M55570_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        cmp      esi, -1
-       jl       SHORT G_M55570_IG09
+       jl       SHORT G_M55570_IG11
        test     esi, esi
-       jge      G_M55570_IG10
+       jge      G_M55570_IG12
 						;; size=13 bbWeight=1 PerfScore 2.50
 G_M55570_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        cmp      dword ptr [rbx], 10
-       jge      G_M55570_IG11
+       jge      G_M55570_IG13
 						;; size=9 bbWeight=1 PerfScore 4.00
 G_M55570_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        call     <unknown method>
@@ -67,7 +68,7 @@ G_M55570_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
 G_M55570_IG05:        ; bbWeight=1, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rbx]
        cmp      ecx, 0x400
-       jge      G_M55570_IG16
+       jge      G_M55570_IG18
        mov      rax, 0xD1FFAB1E      ; function address
 						;; size=22 bbWeight=1 PerfScore 1.50
 G_M55570_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
@@ -81,21 +82,25 @@ G_M55570_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M55570_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rbx, bword ptr [rsp+0x40]
        ; byrRegs +[rbx]
-       mov      ecx, dword ptr [rbx]
-       mov      edx, 10
-       lea      eax, [rcx+0x01]
-       cmp      ecx, 0xD1FFAB1E
-       cmovne   edx, eax
-       mov      dword ptr [rbx], edx
-						;; size=26 bbWeight=1 PerfScore 5.25
-G_M55570_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       mov      edi, dword ptr [rbx]
+       cmp      edi, 0xD1FFAB1E
+       je       G_M55570_IG19
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M55570_IG08:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; GC ptr vars -{V00}
+       inc      edi
+						;; size=2 bbWeight=1 PerfScore 0.25
+G_M55570_IG09:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       mov      dword ptr [rbx], edi
+						;; size=2 bbWeight=1 PerfScore 1.00
+G_M55570_IG10:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
-G_M55570_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
-       ; GC ptr vars -{V00}
+						;; size=8 bbWeight=1 PerfScore 2.75
+G_M55570_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        mov      rdx, 0xD1FFAB1E
@@ -106,7 +111,7 @@ G_M55570_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        test     esi, esi
        jl       G_M55570_IG03
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M55570_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M55570_IG12:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        xor      ecx, ecx
        cmp      esi, 10
        setge    cl
@@ -122,23 +127,23 @@ G_M55570_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        cmp      dword ptr [rbx], 10
        jl       G_M55570_IG04
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M55570_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        cmp      dword ptr [rbx], esi
-       jl       SHORT G_M55570_IG12
+       jl       SHORT G_M55570_IG14
        test     esi, esi
-       jge      SHORT G_M55570_IG13
+       jge      SHORT G_M55570_IG15
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M55570_IG12:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        mov      ecx, dword ptr [rbx]
        add      ecx, -10
        test     cl, 1
        jne      G_M55570_IG04
        cmp      dword ptr [rbx], esi
-       jl       SHORT G_M55570_IG14
+       jl       SHORT G_M55570_IG16
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        test     esi, esi
-       jl       SHORT G_M55570_IG14
+       jl       SHORT G_M55570_IG16
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -146,7 +151,7 @@ G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG07
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; GC ptr vars -{V00}
        mov      ecx, dword ptr [rbx]
        add      ecx, -10
@@ -164,7 +169,7 @@ G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        lea      eax, [rax+4*rax]
        sub      ecx, eax
        cmp      ecx, 4
-       jne      SHORT G_M55570_IG15
+       jne      SHORT G_M55570_IG17
        xor      ecx, ecx
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -172,7 +177,7 @@ G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG07
 						;; size=63 bbWeight=0 PerfScore 0.00
-G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M55570_IG17:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; GC ptr vars -{V00}
        call     <unknown method>
        ; gcr arg pop 0
@@ -180,14 +185,23 @@ G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG07
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M55570_IG16:        ; bbWeight=0, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M55570_IG18:        ; bbWeight=0, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rbx]
        call     [<unknown method>]
        ; gcr arg pop 0
-       jmp      G_M55570_IG07
-						;; size=11 bbWeight=0 PerfScore 0.00
+       mov      rbx, bword ptr [rsp+0x40]
+       ; byrRegs +[rbx]
+       mov      edi, dword ptr [rbx]
+       cmp      edi, 0xD1FFAB1E
+       jne      G_M55570_IG08
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M55570_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; GC ptr vars -{V00}
+       mov      edi, 10
+       jmp      G_M55570_IG09
+						;; size=10 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 366, prolog size 9, PerfScore 34.00, instruction count 97, allocated bytes for code 366 (MethodHash=565b26ed) for method System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
+; Total bytes of code 389, prolog size 10, PerfScore 35.75, instruction count 103, allocated bytes for code 389 (MethodHash=565b26ed) for method System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -195,11 +209,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x07
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+6.34%</span>) : 76376.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,40 +9,41 @@
 ; 3 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 11,  6   )   byref  ->  [rsp+0x40]  this single-def
+;  V00 this         [V00,T00] ( 12,  6   )   byref  ->  [rsp+0x40]  this single-def
 ;  V01 arg1         [V01,T01] (  9,  5   )     int  ->  rsi         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;  V03 loc1         [V03,T02] (  7,  6   )     int  ->  rcx        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T03] (  2,  2   )     int  ->  rax        
+;  V05 tmp1         [V05,T04] (  2,  2   )     int  ->  rax        
 ;* V06 tmp2         [V06    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V07 tmp3         [V07    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V08 tmp4         [V08,T07] (  2,  2   )     int  ->  rdx        
+;  V08 tmp4         [V08,T07] (  3,  2   )     int  ->  rdi        
 ;  V09 tmp5         [V09,T08] (  3,  0   )     int  ->  rcx        
 ;* V10 tmp6         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V11 tmp7         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V12 tmp8         [V12    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V13 tmp9         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V14 cse0         [V14,T04] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V15 cse1         [V15,T05] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V16 cse2         [V16,T06] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V14 cse0         [V14,T05] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V15 cse1         [V15,T06] (  3,  3   )     int  ->  rax         "CSE - aggressive"
+;  V16 cse2         [V16,T03] (  5,  3   )     int  ->  rdi         "CSE - aggressive"
 ;  V17 rat0         [V17,T09] (  3,  0   )     int  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;  V18 rat1         [V18,T10] (  3,  0   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M55570_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        vzeroupper 
        mov      rbx, rcx
        ; byrRegs +[rbx]
        mov      esi, edx
-						;; size=14 bbWeight=1 PerfScore 3.75
+						;; size=15 bbWeight=1 PerfScore 4.75
 G_M55570_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        cmp      esi, -1
-       jl       G_M55570_IG10
+       jl       G_M55570_IG12
 						;; size=9 bbWeight=1 PerfScore 1.25
 G_M55570_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        test     esi, esi
@@ -51,11 +52,11 @@ G_M55570_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        cmp      esi, 10
        setge    al
        test     al, al
-       je       G_M55570_IG11
+       je       G_M55570_IG13
 						;; size=20 bbWeight=1 PerfScore 4.00
 G_M55570_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        cmp      dword ptr [rbx], 10
-       jge      G_M55570_IG12
+       jge      G_M55570_IG14
 						;; size=9 bbWeight=1 PerfScore 4.00
 G_M55570_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        call     <unknown method>
@@ -74,7 +75,7 @@ G_M55570_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
 G_M55570_IG06:        ; bbWeight=1, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rbx]
        cmp      ecx, 0x400
-       jge      G_M55570_IG17
+       jge      G_M55570_IG19
        mov      rax, 0xD1FFAB1E      ; function address
 						;; size=22 bbWeight=1 PerfScore 1.50
 G_M55570_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
@@ -88,21 +89,25 @@ G_M55570_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M55570_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rbx, bword ptr [rsp+0x40]
        ; byrRegs +[rbx]
-       mov      ecx, dword ptr [rbx]
-       mov      edx, 10
-       lea      eax, [rcx+0x01]
-       cmp      ecx, 0xD1FFAB1E
-       cmovne   edx, eax
-       mov      dword ptr [rbx], edx
-						;; size=26 bbWeight=1 PerfScore 5.25
-G_M55570_IG09:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       mov      edi, dword ptr [rbx]
+       cmp      edi, 0xD1FFAB1E
+       je       G_M55570_IG20
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M55570_IG09:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; GC ptr vars -{V00}
+       inc      edi
+						;; size=2 bbWeight=1 PerfScore 0.25
+G_M55570_IG10:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       mov      dword ptr [rbx], edi
+						;; size=2 bbWeight=1 PerfScore 1.00
+G_M55570_IG11:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
-G_M55570_IG10:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
-       ; GC ptr vars -{V00}
+						;; size=8 bbWeight=1 PerfScore 2.75
+G_M55570_IG12:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        mov      rdx, 0xD1FFAB1E
@@ -112,7 +117,7 @@ G_M55570_IG10:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        ; gcr arg pop 0
        jmp      G_M55570_IG03
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M55570_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        mov      rdx, 0xD1FFAB1E
@@ -123,23 +128,23 @@ G_M55570_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        cmp      dword ptr [rbx], 10
        jl       G_M55570_IG05
 						;; size=35 bbWeight=0 PerfScore 0.00
-G_M55570_IG12:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        cmp      dword ptr [rbx], esi
-       jl       SHORT G_M55570_IG13
+       jl       SHORT G_M55570_IG15
        test     esi, esi
-       jge      SHORT G_M55570_IG14
+       jge      SHORT G_M55570_IG16
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M55570_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        mov      ecx, dword ptr [rbx]
        add      ecx, -10
        test     cl, 1
        jne      G_M55570_IG05
        cmp      dword ptr [rbx], esi
-       jl       SHORT G_M55570_IG15
+       jl       SHORT G_M55570_IG17
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        test     esi, esi
-       jl       SHORT G_M55570_IG15
+       jl       SHORT G_M55570_IG17
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -147,7 +152,7 @@ G_M55570_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG08
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M55570_IG17:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; GC ptr vars -{V00}
        mov      ecx, dword ptr [rbx]
        add      ecx, -10
@@ -165,7 +170,7 @@ G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        lea      eax, [rax+4*rax]
        sub      ecx, eax
        cmp      ecx, 4
-       jne      SHORT G_M55570_IG16
+       jne      SHORT G_M55570_IG18
        xor      ecx, ecx
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -173,7 +178,7 @@ G_M55570_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG08
 						;; size=63 bbWeight=0 PerfScore 0.00
-G_M55570_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M55570_IG18:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; GC ptr vars -{V00}
        call     <unknown method>
        ; gcr arg pop 0
@@ -181,14 +186,23 @@ G_M55570_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; GC ptr vars +{V00}
        jmp      G_M55570_IG08
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M55570_IG17:        ; bbWeight=0, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M55570_IG19:        ; bbWeight=0, gcVars=0000000000000001 {V00}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rbx]
        call     [<unknown method>]
        ; gcr arg pop 0
-       jmp      G_M55570_IG08
-						;; size=11 bbWeight=0 PerfScore 0.00
+       mov      rbx, bword ptr [rsp+0x40]
+       ; byrRegs +[rbx]
+       mov      edi, dword ptr [rbx]
+       cmp      edi, 0xD1FFAB1E
+       jne      G_M55570_IG09
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M55570_IG20:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; GC ptr vars -{V00}
+       mov      edi, 10
+       jmp      G_M55570_IG10
+						;; size=10 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 363, prolog size 9, PerfScore 36.75, instruction count 96, allocated bytes for code 363 (MethodHash=565b26ed) for method System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
+; Total bytes of code 386, prolog size 10, PerfScore 38.50, instruction count 102, allocated bytes for code 386 (MethodHash=565b26ed) for method System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -196,11 +210,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x07
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-41.03%</span>) : 26330.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier:FromServiceType(System.Type):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -12,46 +12,36 @@
 ;  V01 arg0         [V01,T01] (  3,  3   )     ref  ->  rdx         class-hnd single-def <System.Type>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier>
-;  V04 tmp2         [V04,T02] (  2,  2   )     ref  ->  rax         single-def "field V03.<ServiceKey>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V05 tmp3         [V05,T03] (  2,  2   )     ref  ->  rsi         single-def "field V03.<ServiceType>k__BackingField (fldOffset=0x8)" P-INDEP
+;* V04 tmp2         [V04,T03] (  0,  0   )     ref  ->  zero-ref    single-def "field V03.<ServiceKey>k__BackingField (fldOffset=0x0)" P-INDEP
+;  V05 tmp3         [V05,T02] (  2,  2   )     ref  ->  rdx         single-def "field V03.<ServiceType>k__BackingField (fldOffset=0x8)" P-INDEP
 ;
 ; Lcl frame size = 0
 
 G_M49819_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
        push     rbx
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=5 bbWeight=1 PerfScore 2.25
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M49819_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rdx]
-       xor      rax, rax
-       ; gcrRegs +[rax]
-       mov      rsi, rdx
-       ; gcrRegs +[rsi]
-       mov      rcx, rbx
-       ; byrRegs +[rcx]
-       mov      rdx, rax
-       call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       ; gcrRegs -[rax rdx]
-       ; byrRegs -[rcx]
+       xor      rcx, rcx
+       ; gcrRegs +[rcx]
+       mov      gword ptr [rbx], rcx
        lea      rcx, bword ptr [rbx+0x08]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       mov      rdx, rsi
-       ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       ; gcrRegs -[rdx rsi]
+       ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=31 bbWeight=1 PerfScore 4.00
+						;; size=17 bbWeight=1 PerfScore 3.00
 G_M49819_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
-       pop      rsi
        ret      
-						;; size=3 bbWeight=1 PerfScore 2.00
+						;; size=2 bbWeight=1 PerfScore 1.50
 
-; Total bytes of code 39, prolog size 2, PerfScore 8.25, instruction count 15, allocated bytes for code 39 (MethodHash=0cfc3d64) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier:FromServiceType(System.Type):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier (Tier1)
+; Total bytes of code 23, prolog size 1, PerfScore 5.75, instruction count 9, allocated bytes for code 23 (MethodHash=0cfc3d64) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier:FromServiceType(System.Type):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -59,10 +49,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x02
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x01
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-18</span> (<span style="color:green">-40.91%</span>) : 35566.dasm - System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 TypeCtx      [V00    ] (  0,  0   )    long  ->  zero-ref    single-def
-;  V01 arg0         [V01,T00] (  5,  5   )   byref  ->  rdx         single-def
+;  V01 arg0         [V01,T00] (  4,  4   )   byref  ->  rdx         single-def
 ;* V02 arg1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
 ;* V03 arg2         [V03    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -31,12 +31,10 @@
 G_M43397_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M43397_IG02:        ; bbWeight=1, gcrefRegs=0300 {r8 r9}, byrefRegs=0004 {rdx}, byref, isz
+G_M43397_IG02:        ; bbWeight=1, gcrefRegs=0300 {r8 r9}, byrefRegs=0004 {rdx}, byref
        ; gcrRegs +[r8-r9]
        ; byrRegs +[rdx]
        cmp      byte  ptr [rdx], dl
-       test     rdx, rdx
-       je       SHORT G_M43397_IG04
        mov      rcx, rdx
        ; byrRegs +[rcx]
        mov      rdx, r8
@@ -48,20 +46,13 @@ G_M43397_IG02:        ; bbWeight=1, gcrefRegs=0300 {r8 r9}, byrefRegs=0004 {rdx}
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        nop      
-						;; size=22 bbWeight=1 PerfScore 6.25
+						;; size=17 bbWeight=1 PerfScore 5.00
 G_M43397_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M43397_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowNullReferenceException()
-       call     [rax]System.ThrowHelper:ThrowNullReferenceException()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 44, prolog size 4, PerfScore 7.75, instruction count 14, allocated bytes for code 44 (MethodHash=22ff567a) for method System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)
+; Total bytes of code 26, prolog size 4, PerfScore 6.50, instruction count 9, allocated bytes for code 26 (MethodHash=22ff567a) for method System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-43</span> (<span style="color:green">-33.08%</span>) : 53648.dasm - SciMark2.FFT:inverse(double[]) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,14 +7,14 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T02] (  7,  8.50)     ref  ->  rbx         class-hnd single-def <double[]>
-;  V01 loc0         [V01,T03] (  6,  8   )     int  ->  rcx         single-def
+;  V00 arg0         [V00,T02] (  5,  7.96)     ref  ->  rbx         class-hnd single-def <double[]>
+;  V01 loc0         [V01,T03] (  5,  7.96)     int  ->  rax         single-def
 ;* V02 loc1         [V02    ] (  0,  0   )     int  ->  zero-ref   
-;  V03 loc2         [V03,T05] (  3,  5   )  double  ->  mm0         single-def
-;  V04 loc3         [V04,T01] ( 11, 18.04)     int  ->  rdx        
+;  V03 loc2         [V03,T05] (  2,  4.96)  double  ->  mm0         single-def
+;  V04 loc3         [V04,T01] (  5, 16.84)     int  ->  rcx        
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T00] (  6, 24   )   byref  ->  registers   "dup spill"
-;  V07 cse0         [V07,T04] (  3,  2.04)     int  ->  rax         "CSE - aggressive"
+;  V06 tmp1         [V06,T00] (  3, 23.76)   byref  ->  rdx         "dup spill"
+;  V07 cse0         [V07,T04] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -33,66 +33,38 @@ G_M10854_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcr arg pop 0
        mov      eax, dword ptr [rbx+0x08]
        mov      ecx, eax
-       mov      edx, ecx
-       shr      edx, 31
-       add      edx, ecx
-       sar      edx, 1
+       shr      ecx, 31
+       add      ecx, eax
+       sar      ecx, 1
        vxorps   xmm0, xmm0, xmm0
-       vcvtsi2sd xmm0, xmm0, edx
+       vcvtsi2sd xmm0, xmm0, ecx
        vmovsd   xmm1, qword ptr [reloc @RWD00]
        vdivsd   xmm0, xmm1, xmm0
-       xor      edx, edx
-       cmp      edx, ecx
-       jge      SHORT G_M10854_IG07
-						;; size=54 bbWeight=1 PerfScore 30.08
-G_M10854_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     rbx, rbx
-       je       SHORT G_M10854_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M10854_IG04:        ; bbWeight=3.96, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, edx
-       lea      rax, bword ptr [rbx+8*rax+0x10]
-       ; byrRegs +[rax]
-       vmulsd   xmm1, xmm0, qword ptr [rax]
-       vmovsd   qword ptr [rax], xmm1
-       inc      edx
-       cmp      edx, ecx
-       jl       SHORT G_M10854_IG04
+       xor      ecx, ecx
+       test     eax, eax
+       jle      SHORT G_M10854_IG04
+						;; size=52 bbWeight=1 PerfScore 29.83
+G_M10854_IG03:        ; bbWeight=3.96, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      edx, ecx
+       lea      rdx, bword ptr [rbx+8*rdx+0x10]
+       ; byrRegs +[rdx]
+       vmulsd   xmm1, xmm0, qword ptr [rdx]
+       vmovsd   qword ptr [rdx], xmm1
+       inc      ecx
+       cmp      ecx, eax
+       jl       SHORT G_M10854_IG03
 						;; size=21 bbWeight=3.96 PerfScore 42.57
-G_M10854_IG05:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M10854_IG04:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rbx]
-       ; byrRegs -[rax]
-       jmp      SHORT G_M10854_IG07
-						;; size=2 bbWeight=1.98 PerfScore 3.96
-G_M10854_IG06:        ; bbWeight=0.04, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rbx]
-       cmp      edx, eax
-       jae      SHORT G_M10854_IG08
-       mov      r8d, edx
-       lea      r8, bword ptr [rbx+8*r8+0x10]
-       ; byrRegs +[r8]
-       vmulsd   xmm1, xmm0, qword ptr [r8]
-       vmovsd   qword ptr [r8], xmm1
-       inc      edx
-       cmp      edx, ecx
-       jl       SHORT G_M10854_IG06
-						;; size=28 bbWeight=0.04 PerfScore 0.48
-G_M10854_IG07:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       ; byrRegs -[r8]
+       ; byrRegs -[rdx]
        add      rsp, 32
        pop      rbx
        ret      
 						;; size=6 bbWeight=1.98 PerfScore 3.46
-G_M10854_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 RWD00  	dq	3FF0000000000000h	;            1
 
 
-; Total bytes of code 130, prolog size 8, PerfScore 82.68, instruction count 43, allocated bytes for code 130 (MethodHash=c9bbd599) for method SciMark2.FFT:inverse(double[]) (Tier1)
+; Total bytes of code 87, prolog size 8, PerfScore 77.37, instruction count 28, allocated bytes for code 87 (MethodHash=c9bbd599) for method SciMark2.FFT:inverse(double[]) (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+47</span> (<span style="color:red">+3.78%</span>) : 54989.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemTaskFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,29 +10,29 @@
 ;
 ;  V00 arg0         [V00,T00] ( 18, 34   )     ref  ->  rbx         class-hnd single-def <System.Runtime.Serialization.XmlReaderDelegator>
 ;  V01 arg1         [V01,T01] ( 17, 29   )     ref  ->  rsi         class-hnd single-def <System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson>
-;  V02 arg2         [V02,T17] (  4,  6   )     ref  ->  rdi         class-hnd single-def <System.Xml.XmlDictionaryString>
-;  V03 arg3         [V03,T18] (  4,  6   )     ref  ->  rbp         class-hnd single-def <System.Xml.XmlDictionaryString>
+;  V02 arg2         [V02,T16] (  4,  6   )     ref  ->  rdi         class-hnd single-def <System.Xml.XmlDictionaryString>
+;  V03 arg3         [V03,T17] (  4,  6   )     ref  ->  rbp         class-hnd single-def <System.Xml.XmlDictionaryString>
 ;* V04 arg4         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Runtime.Serialization.DataContracts.CollectionDataContract>
-;  V05 loc0         [V05,T04] (  9, 15   )     ref  ->  r14         class-hnd exact single-def <<unknown class>>
+;  V05 loc0         [V05,T03] (  9, 15   )     ref  ->  r14         class-hnd exact single-def <<unknown class>>
 ;* V06 loc1         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.String>
-;  V07 loc2         [V07,T03] (  6, 17   )     int  ->  r15        
-;  V08 loc3         [V08,T32] (  3,  6   )     ref  ->   r8         class-hnd <<unknown class>>
+;  V07 loc2         [V07,T02] (  6, 17   )     int  ->  r15        
+;  V08 loc3         [V08,T31] (  3,  6   )     ref  ->   r8         class-hnd <<unknown class>>
 ;  V09 OutArgs      [V09    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V10 tmp1         [V10,T33] (  3,  6   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V10 tmp1         [V10,T32] (  3,  6   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V11 tmp2         [V11    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.RuntimeTypeHandle>
-;  V12 tmp3         [V12,T24] (  3,  6   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V12 tmp3         [V12,T23] (  3,  6   )   ubyte  ->  rax         "Inline return value spill temp"
 ;* V13 tmp4         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <<unknown class>>
 ;* V14 tmp5         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.String>
-;  V15 tmp6         [V15,T31] (  4,  6.50)     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Object>
-;  V16 tmp7         [V16,T40] (  2,  4   )     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Object>
+;  V15 tmp6         [V15,T30] (  4,  6.50)     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Object>
+;  V16 tmp7         [V16,T39] (  2,  4   )     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Object>
 ;  V17 tmp8         [V17    ] (  3,  6   )     ref  ->  [rsp+0x50]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V18 tmp9         [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V19 tmp10        [V19    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V20 tmp11        [V20,T19] (  4,  8   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
+;  V20 tmp11        [V20,T18] (  4,  8   )     ref  ->  r13         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V21 tmp12        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V22 tmp13        [V22    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V23 tmp14        [V23,T20] (  4,  8   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V24 tmp15        [V24,T06] (  6, 12   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
+;  V23 tmp14        [V23,T19] (  4,  8   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
+;  V24 tmp15        [V24,T05] (  6, 12   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V25 tmp16        [V25    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.RuntimeTypeHandle>
 ;* V26 tmp17        [V26    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.RuntimeTypeHandle>
 ;* V27 tmp18        [V27    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Object>
@@ -40,47 +40,47 @@
 ;* V29 tmp20        [V29    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
 ;* V30 tmp21        [V30    ] (  0,  0   )     ref  ->  zero-ref   
 ;  V31 tmp22        [V31    ] (  7, 14   )     ref  ->  [rsp+0x48]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V32 tmp23        [V32,T41] (  2,  4   )     ref  ->  r12         class-hnd exact "Inline stloc first use temp" <System.String>
-;  V33 tmp24        [V33,T13] (  5, 10   )     ref  ->  [rsp+0x40]  class-hnd spill-single-def "Inline stloc first use temp" <System.Object>
-;  V34 tmp25        [V34,T26] (  2,  8   )     ref  ->  [rsp+0x38]  class-hnd spill-single-def "non-inline candidate call" <System.Runtime.Serialization.ISerializationSurrogateProvider>
+;  V32 tmp23        [V32,T40] (  2,  4   )     ref  ->  r13         class-hnd exact "Inline stloc first use temp" <System.String>
+;  V33 tmp24        [V33,T12] (  5, 10   )     ref  ->  r12         class-hnd "Inline stloc first use temp" <System.Object>
+;  V34 tmp25        [V34,T25] (  2,  8   )     ref  ->  [rsp+0x40]  class-hnd spill-single-def "non-inline candidate call" <System.Runtime.Serialization.ISerializationSurrogateProvider>
 ;* V35 tmp26        [V35    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Object>
 ;  V36 tmp27        [V36,T44] (  2,  0   )     ref  ->  rbx         class-hnd exact "non-inline candidate call" <System.String>
 ;  V37 tmp28        [V37,T43] (  4,  0   )     ref  ->  rsi         class-hnd exact "NewObj constructor temp" <System.Runtime.Serialization.InvalidDataContractException>
-;  V38 tmp29        [V38,T14] (  5, 10   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Type>
-;  V39 tmp30        [V39,T27] (  2,  8   )     ref  ->  r12         class-hnd "Inlining Arg" <System.Runtime.Serialization.ISerializationSurrogateProvider>
-;  V40 tmp31        [V40,T28] (  2,  8   )     ref  ->  rax         class-hnd "dup spill" <System.Type>
-;  V41 tmp32        [V41,T21] (  4,  8   )     ref  ->  r12        
+;  V38 tmp29        [V38,T13] (  5, 10   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Type>
+;  V39 tmp30        [V39,T26] (  2,  8   )     ref  ->  r13         class-hnd "Inlining Arg" <System.Runtime.Serialization.ISerializationSurrogateProvider>
+;  V40 tmp31        [V40,T27] (  2,  8   )     ref  ->  rax         class-hnd "dup spill" <System.Type>
+;  V41 tmp32        [V41,T20] (  4,  8   )     ref  ->  r12        
 ;* V42 tmp33        [V42    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.RuntimeTypeHandle>
 ;* V43 tmp34        [V43    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V44 tmp35        [V44    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V45 tmp36        [V45,T22] (  4,  8   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
+;  V45 tmp36        [V45,T21] (  4,  8   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;* V46 tmp37        [V46    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V47 tmp38        [V47,T36] (  3,  6   )     int  ->  r12         "Inline stloc first use temp"
+;  V47 tmp38        [V47,T35] (  3,  6   )     int  ->  r12         "Inline stloc first use temp"
 ;* V48 tmp39        [V48    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V49 tmp40        [V49,T23] (  4,  8   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
-;  V50 tmp41        [V50,T07] (  6, 12   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
+;  V49 tmp40        [V49,T22] (  4,  8   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Runtime.Serialization.DataContracts.DataContract>
+;  V50 tmp41        [V50,T06] (  6, 12   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <System.Runtime.Serialization.DataContracts.DataContract>
 ;  V51 tmp42        [V51,T45] (  2,  0   )     ref  ->  rbx         class-hnd exact "Inlining Arg" <System.String>
-;  V52 tmp43        [V52,T15] (  5, 10   )     ref  ->  registers   class-hnd "Inline return value spill temp" <System.Object>
-;  V53 tmp44        [V53,T29] (  2,  8   )     ref  ->  rcx         class-hnd "Inlining Arg" <System.Type>
-;  V54 tmp45        [V54,T34] (  3,  6   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V55 tmp46        [V55,T25] (  4,  8   )     int  ->  rdx         "Inline stloc first use temp"
-;  V56 tmp47        [V56,T37] (  2,  4   )     int  ->  rax         "Inline return value spill temp"
-;  V57 tmp48        [V57,T39] (  2,  4   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V58 tmp49        [V58,T02] ( 12, 22   )     ref  ->  r13         "field V11.m_type (fldOffset=0x0)" P-INDEP
+;  V52 tmp43        [V52,T14] (  5, 10   )     ref  ->  [rsp+0x38]  class-hnd "Inline return value spill temp" <System.Object>
+;  V53 tmp44        [V53,T28] (  2,  8   )     ref  ->  rcx         class-hnd "Inlining Arg" <System.Type>
+;  V54 tmp45        [V54,T33] (  3,  6   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V55 tmp46        [V55,T24] (  4,  8   )     int  ->  rdx         "Inline stloc first use temp"
+;  V56 tmp47        [V56,T36] (  2,  4   )     int  ->  rax         "Inline return value spill temp"
+;  V57 tmp48        [V57,T38] (  2,  4   )   ubyte  ->  rax         "Inline return value spill temp"
+;* V58 tmp49        [V58,T42] (  0,  0   )     ref  ->  zero-ref    "field V11.m_type (fldOffset=0x0)" P-INDEP
 ;* V59 tmp50        [V59    ] (  0,  0   )     ref  ->  zero-ref    "field V25.m_type (fldOffset=0x0)" P-INDEP
 ;* V60 tmp51        [V60    ] (  0,  0   )     ref  ->  zero-ref    "field V26.m_type (fldOffset=0x0)" P-INDEP
-;  V61 tmp52        [V61,T16] (  5, 10   )     ref  ->  [rsp+0x30]  spill-single-def "field V42.m_type (fldOffset=0x0)" P-INDEP
-;  V62 tmp53        [V62,T42] (  2,  2   )     ref  ->  rcx         single-def "Field obj"
-;  V63 tmp54        [V63,T08] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V64 tmp55        [V64,T09] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V65 tmp56        [V65,T10] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V66 tmp57        [V66,T11] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V67 tmp58        [V67,T12] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V68 tmp59        [V68,T30] (  2,  8   )     int  ->  rcx         "argument with side effect"
+;  V61 tmp52        [V61,T15] (  5, 10   )     ref  ->  r13         "field V42.m_type (fldOffset=0x0)" P-INDEP
+;  V62 tmp53        [V62,T41] (  2,  2   )     ref  ->  rcx         single-def "Field obj"
+;  V63 tmp54        [V63,T07] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V64 tmp55        [V64,T08] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V65 tmp56        [V65,T09] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V66 tmp57        [V66,T10] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V67 tmp58        [V67,T11] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V68 tmp59        [V68,T29] (  2,  8   )     int  ->  rcx         "argument with side effect"
 ;  V69 tmp60        [V69,T46] (  2,  0   )     ref  ->  rdx         "argument with side effect"
-;  V70 cse0         [V70,T35] (  3,  6   )     ref  ->  r12         "CSE - moderate"
-;  V71 rat0         [V71,T05] (  5, 15   )     ref  ->   r8         "replacement local"
-;  V72 rat1         [V72,T38] (  3,  5   )    long  ->  rcx         "CSE for expectedClsNode"
+;  V70 cse0         [V70,T34] (  3,  6   )     ref  ->  r13         "CSE - moderate"
+;  V71 rat0         [V71,T04] (  5, 15   )     ref  ->   r8         "replacement local"
+;  V72 rat1         [V72,T37] (  3,  5   )    long  ->  rcx         "CSE for expectedClsNode"
 ;
 ; Lcl frame size = 88
 
@@ -175,37 +175,30 @@ G_M38359_IG06:        ; bbWeight=2, gcrefRegs=40E8 {rbx rbp rsi rdi r14}, byrefR
        call     [System.Runtime.Serialization.XmlObjectSerializerContext:IncrementItemCount(int):this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       call     CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPEHANDLE
-       ; gcrRegs +[rax]
-       ; gcr arg pop 0
-       mov      r13, rax
+       mov      r13, gword ptr [rsi+0xA8]
        ; gcrRegs +[r13]
-       mov      r12, gword ptr [rsi+0xA8]
-       ; gcrRegs +[r12]
-       test     r12, r12
+       test     r13, r13
        jne      G_M38359_IG12
        cmp      byte  ptr [rsi+0xA0], 0
        je       SHORT G_M38359_IG07
-       mov      rdx, r13
+       mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        mov      ecx, 5
        xor      r8, r8
        ; gcrRegs +[r8]
        call     [System.Runtime.Serialization.DataContracts.DataContract:GetGetOnlyCollectionDataContract(int,System.RuntimeTypeHandle,System.Type):System.Runtime.Serialization.DataContracts.DataContract]
-       ; gcrRegs -[rdx r8 r12]
+       ; gcrRegs -[rdx r8 r13] +[rax]
        ; gcr arg pop 0
-       mov      r12, rax
-       ; gcrRegs +[r12]
+       mov      r13, rax
+       ; gcrRegs +[r13]
        jmp      SHORT G_M38359_IG11
-						;; size=87 bbWeight=2 PerfScore 39.00
-G_M38359_IG07:        ; bbWeight=2, gcrefRegs=60E8 {rbx rbp rsi rdi r13 r14}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax r12]
+						;; size=76 bbWeight=2 PerfScore 36.00
+G_M38359_IG07:        ; bbWeight=2, gcrefRegs=40E8 {rbx rbp rsi rdi r14}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rax r13]
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
        mov      edx, 5
-       cmp      dword ptr [rcx], ecx
        call     [<unknown method>]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
@@ -213,7 +206,7 @@ G_M38359_IG07:        ; bbWeight=2, gcrefRegs=60E8 {rbx rbp rsi rdi r13 r14}, by
        ; gcrRegs +[rcx]
        test     rcx, rcx
        jne      SHORT G_M38359_IG08
-       mov      rdx, r13
+       mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        mov      ecx, 5
        ; gcrRegs -[rcx]
@@ -225,8 +218,8 @@ G_M38359_IG07:        ; bbWeight=2, gcrefRegs=60E8 {rbx rbp rsi rdi r13 r14}, by
        mov      rcx, rax
        ; gcrRegs +[rcx]
        jmp      SHORT G_M38359_IG09
-						;; size=56 bbWeight=2 PerfScore 32.00
-G_M38359_IG08:        ; bbWeight=2, gcrefRegs=60EA {rcx rbx rbp rsi rdi r13 r14}, byrefRegs=0000 {}, byref, isz
+						;; size=61 bbWeight=2 PerfScore 26.00
+G_M38359_IG08:        ; bbWeight=2, gcrefRegs=40EA {rcx rbx rbp rsi rdi r14}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        mov      edx, 1
        mov      rax, qword ptr [rcx]
@@ -236,12 +229,12 @@ G_M38359_IG08:        ; bbWeight=2, gcrefRegs=60EA {rcx rbx rbp rsi rdi r13 r14}
        ; gcr arg pop 0
        jmp      SHORT G_M38359_IG10
 						;; size=17 bbWeight=2 PerfScore 18.50
-G_M38359_IG09:        ; bbWeight=2, gcrefRegs=60EA {rcx rbx rbp rsi rdi r13 r14}, byrefRegs=0000 {}, byref
+G_M38359_IG09:        ; bbWeight=2, gcrefRegs=40EA {rcx rbx rbp rsi rdi r14}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax] +[rcx]
        mov      rax, rcx
        ; gcrRegs +[rax]
 						;; size=3 bbWeight=2 PerfScore 0.50
-G_M38359_IG10:        ; bbWeight=2, gcrefRegs=60E9 {rax rbx rbp rsi rdi r13 r14}, byrefRegs=0000 {}, byref
+G_M38359_IG10:        ; bbWeight=2, gcrefRegs=40E9 {rax rbx rbp rsi rdi r14}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        mov      rcx, rax
        ; gcrRegs +[rcx]
@@ -252,20 +245,23 @@ G_M38359_IG10:        ; bbWeight=2, gcrefRegs=60E9 {rax rbx rbp rsi rdi r13 r14}
        call     [rax+0x20]<unknown method>
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       mov      r12, rax
-       ; gcrRegs +[r12]
+       mov      r13, rax
+       ; gcrRegs +[r13]
 						;; size=18 bbWeight=2 PerfScore 15.50
-G_M38359_IG11:        ; bbWeight=2, gcrefRegs=70E8 {rbx rbp rsi rdi r12 r13 r14}, byrefRegs=0000 {}, byref
+G_M38359_IG11:        ; bbWeight=2, gcrefRegs=60E8 {rbx rbp rsi rdi r13 r14}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
-       mov      rcx, r12
+       mov      rcx, r13
        ; gcrRegs +[rcx]
        call     [System.Runtime.Serialization.Json.DataContractJsonSerializer:CheckIfTypeIsReference(System.Runtime.Serialization.DataContracts.DataContract)]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      gword ptr [rsp+0x50], r12
-       mov      gword ptr [rsp+0x20], r13
+       mov      gword ptr [rsp+0x50], r13
+       mov      r9, 0xD1FFAB1E
+       ; gcrRegs +[r9]
+       mov      gword ptr [rsp+0x20], r9
        ; gcr arg write
        lea      r9, [rsp+0x50]
+       ; gcrRegs -[r9]
        mov      qword ptr [rsp+0x28], r9
        mov      r9, 0xD1FFAB1E      ; string handle
        mov      r9, gword ptr [r9]
@@ -278,7 +274,7 @@ G_M38359_IG11:        ; bbWeight=2, gcrefRegs=70E8 {rbx rbp rsi rdi r12 r13 r14}
        mov      rdx, rbx
        ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx r8-r9 r12-r13] +[rax]
+       ; gcrRegs -[rcx rdx r8-r9 r13] +[rax]
        ; gcr arg pop 0
        mov      rdx, rax
        ; gcrRegs +[rdx]
@@ -286,36 +282,37 @@ G_M38359_IG11:        ; bbWeight=2, gcrefRegs=70E8 {rbx rbp rsi rdi r12 r13 r14}
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x50], rcx
        jmp      G_M38359_IG24
-						;; size=82 bbWeight=2 PerfScore 36.50
-G_M38359_IG12:        ; bbWeight=2, gcrefRegs=70E8 {rbx rbp rsi rdi r12 r13 r14}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax rcx rdx] +[r12-r13]
-       mov      rcx, r13
+						;; size=92 bbWeight=2 PerfScore 37.00
+G_M38359_IG12:        ; bbWeight=2, gcrefRegs=60E8 {rbx rbp rsi rdi r13 r14}, byrefRegs=0000 {}, byref, isz
...

```


</div></details>

<details>
<summary><span style="color:red">+3</span> (<span style="color:red">+4.29%</span>) : 5540.dasm - System.Number:<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(uint):System.String (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;  V00 arg0         [V00,T00] (  5,  5   )     int  ->  rbx         single-def
 ;* V01 loc0         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <System.String>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  3,  6   )     ref  ->  rsi         class-hnd exact single-def "impAppendStmt" <<unknown class>>
-;  V04 tmp2         [V04,T02] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def "dup spill" <System.String>
+;  V03 tmp1         [V03,T02] (  2,  4   )     ref  ->  rsi         class-hnd exact single-def "impAppendStmt" <<unknown class>>
+;  V04 tmp2         [V04,T01] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def "dup spill" <System.String>
 ;
 ; Lcl frame size = 32
 
@@ -32,7 +32,7 @@ G_M27827_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; gcr arg pop 0
        mov      rdi, rax
        ; gcrRegs +[rdi]
-       cmp      ebx, dword ptr [rsi+0x08]
+       cmp      ebx, 300
        jae      SHORT G_M27827_IG04
        mov      ecx, ebx
        lea      rcx, bword ptr [rsi+8*rcx+0x10]
@@ -44,7 +44,7 @@ G_M27827_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs -[rcx]
        mov      rax, rdi
        ; gcrRegs +[rax]
-						;; size=47 bbWeight=1 PerfScore 12.50
+						;; size=50 bbWeight=1 PerfScore 9.75
 G_M27827_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
@@ -59,7 +59,7 @@ G_M27827_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 70, prolog size 7, PerfScore 18.75, instruction count 24, allocated bytes for code 70 (MethodHash=3035934c) for method System.Number:<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(uint):System.String (Tier1)
+; Total bytes of code 73, prolog size 7, PerfScore 16.00, instruction count 24, allocated bytes for code 73 (MethodHash=3035934c) for method System.Number:<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(uint):System.String (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+3</span> (<span style="color:red">+7.32%</span>) : 41214.dasm - Microsoft.CodeAnalysis.WellKnownTypes:GetMetadataName(int):System.String (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,9 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T01] (  3,  3   )     int  ->  rcx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )     int  ->  rcx         single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         single-def "arr expr"
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         single-def "arr expr"
 ;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
@@ -22,10 +22,10 @@ G_M60139_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        mov      rax, gword ptr [rax]
        ; gcrRegs +[rax]
        add      ecx, -47
-       cmp      ecx, dword ptr [rax+0x08]
+       cmp      ecx, 275
        jae      SHORT G_M60139_IG04
        mov      rax, gword ptr [rax+8*rcx+0x10]
-						;; size=26 bbWeight=1 PerfScore 8.50
+						;; size=29 bbWeight=1 PerfScore 5.75
 G_M60139_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -37,7 +37,7 @@ G_M60139_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 41, prolog size 4, PerfScore 10.00, instruction count 11, allocated bytes for code 41 (MethodHash=8d3b1514) for method Microsoft.CodeAnalysis.WellKnownTypes:GetMetadataName(int):System.String (Tier1)
+; Total bytes of code 44, prolog size 4, PerfScore 7.25, instruction count 11, allocated bytes for code 44 (MethodHash=8d3b1514) for method Microsoft.CodeAnalysis.WellKnownTypes:GetMetadataName(int):System.String (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-93.33%</span>) : 245660.dasm - Runtime_81460:Test():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V01 tmp1         [V01    ] (  0,  0   )  double  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V02 tmp2         [V02,T00] (  2,  2   )     int  ->  rax         "Inline return value spill temp"
-;  V03 tmp3         [V03,T01] (  2,  2   )   short  ->  rax         "Inline stloc first use temp"
+;* V02 tmp2         [V02,T00] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V03 tmp3         [V03,T01] (  0,  0   )   short  ->  zero-ref    "Inline stloc first use temp"
 ;* V04 tmp4         [V04    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V05 tmp5         [V05    ] (  0,  0   )   short  ->  zero-ref    "Inlining Arg"
 ;
@@ -20,26 +20,13 @@
 G_M33702_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M33702_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vmovsd   xmm0, qword ptr [reloc @RWD00]
-       vmovd    rax, xmm0
-       shr      rax, 52
-       and      eax, 0x7FF
-       add      eax, -0x3FF
-       cwde     
-       movzx    rax, ax
-       lzcnt    eax, eax
-       add      eax, -16
-       cwde     
-       neg      eax
-       add      eax, 16
-						;; size=44 bbWeight=1 PerfScore 9.50
+       xor      eax, eax
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M33702_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-RWD00  	dq	3FF0000000000000h	;            1
 
-
-; Total bytes of code 45, prolog size 0, PerfScore 10.50, instruction count 13, allocated bytes for code 45 (MethodHash=735b7c59) for method Runtime_81460:Test():int (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=735b7c59) for method Runtime_81460:Test():int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-32</span> (<span style="color:green">-91.43%</span>) : 245451.dasm - Runtime_71156:Problem():ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,29 +8,22 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 loc0         [V00,T01] (  2,  2   )   float  ->  mm0         ld-addr-op single-def
-;  V01 loc1         [V01,T00] (  2,  2   )     int  ->  [rsp+0x04]  do-not-enreg[F] ld-addr-op
+;* V00 loc0         [V00,T01] (  0,  0   )   float  ->  zero-ref    ld-addr-op single-def
+;* V01 loc1         [V01,T00] (  0,  0   )     int  ->  zero-ref    do-not-enreg[F] ld-addr-op
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M50584_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M50584_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      dword ptr [rsp+0x04], 0xD1FFAB1E
-       vmovss   xmm0, dword ptr [rsp+0x04]
-       vmovd    eax, xmm0
-       cmp      eax, 0xD1FFAB1E
-       setne    al
-       movzx    rax, al
-						;; size=29 bbWeight=1 PerfScore 7.50
+       xor      eax, eax
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M50584_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 35, prolog size 1, PerfScore 9.75, instruction count 9, allocated bytes for code 35 (MethodHash=b3b43a67) for method Runtime_71156:Problem():ubyte (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=b3b43a67) for method Runtime_71156:Problem():ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -38,9 +31,8 @@ Unwind Info:
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
<summary><span style="color:green">-31</span> (<span style="color:green">-83.78%</span>) : 240798.dasm - ILGEN_940455031:main():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,32 +8,22 @@
 ; Final local variable assignments
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )     int  ->  zero-ref   
-;  V01 loc1         [V01,T01] (  1,  1   )  double  ->  mm0         must-init
-;  V02 loc2         [V02,T00] (  1,  1   )    long  ->  rax         must-init
+;* V01 loc1         [V01    ] (  0,  0   )  double  ->  zero-ref   
+;* V02 loc2         [V02    ] (  0,  0   )    long  ->  zero-ref   
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
 
 G_M21262_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       xor      eax, eax
-       vxorps   xmm0, xmm0, xmm0
-						;; size=6 bbWeight=1 PerfScore 0.58
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M21262_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       neg      rax
-       add      rax, 2
-       neg      rax
-       inc      rax
-       vcvttsd2si  rcx, xmm0
-       cmp      rax, rcx
-       setg     al
-       movzx    rax, al
-       add      eax, 100
-						;; size=30 bbWeight=1 PerfScore 8.75
+       mov      eax, 100
+						;; size=5 bbWeight=1 PerfScore 0.25
 G_M21262_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 37, prolog size 0, PerfScore 10.33, instruction count 12, allocated bytes for code 37 (MethodHash=7e45acf1) for method ILGEN_940455031:main():int (FullOpts)
+; Total bytes of code 6, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 6 (MethodHash=7e45acf1) for method ILGEN_940455031:main():int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+13</span> (<span style="color:red">+20.97%</span>) : 290034.dasm - HardwareEh+<>c:<PosTest19>b__20_0():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,10 +11,10 @@
 ;* V01 loc0         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;* V02 loc1         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T00] (  6, 12   )     ref  ->  rax         single-def "MD array shared temp"
-;  V05 tmp2         [V05,T01] (  3,  6   )     int  ->  rcx         "MD array shared temp"
-;  V06 tmp3         [V06,T02] (  3,  6   )     int  ->   r8         "MD array shared temp"
-;  V07 cse0         [V07,T03] (  3,  3   )     int  ->  rdx         "CSE - aggressive"
+;* V04 tmp1         [V04,T03] (  0,  0   )     ref  ->  zero-ref    single-def "MD array shared temp"
+;  V05 tmp2         [V05,T00] (  3,  6   )     int  ->  rax         "MD array shared temp"
+;  V06 tmp3         [V06,T01] (  3,  6   )     int  ->  rdx         "MD array shared temp"
+;  V07 cse0         [V07,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -22,24 +22,21 @@ G_M59806_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M59806_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       xor      rax, rax
-       ; gcrRegs +[rax]
-       mov      ecx, 2
-       sub      ecx, dword ptr [rax+0x18]
-       cmp      ecx, dword ptr [rax+0x10]
+       mov      eax, 2
+       sub      eax, dword ptr [0x0000]
+       cmp      eax, dword ptr [0x0000]
        jae      SHORT G_M59806_IG04
-       mov      edx, dword ptr [rax+0x14]
-       imul     ecx, edx
-       xor      r8d, r8d
-       sub      r8d, dword ptr [rax+0x1C]
-       cmp      r8d, edx
-       jae      SHORT G_M59806_IG04
-       add      ecx, r8d
+       mov      ecx, dword ptr [0x0000]
+       imul     eax, ecx
        xor      edx, edx
-       mov      dword ptr [rax+4*rcx+0x20], edx
+       sub      edx, dword ptr [0x0000]
+       cmp      edx, ecx
+       jae      SHORT G_M59806_IG04
+       add      eax, edx
+       xor      ecx, ecx
+       mov      dword ptr [4*rax+0x20], ecx
        mov      eax, 1
-       ; gcrRegs -[rax]
-						;; size=47 bbWeight=1 PerfScore 17.75
+						;; size=60 bbWeight=1 PerfScore 17.50
 G_M59806_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -50,7 +47,7 @@ G_M59806_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 62, prolog size 4, PerfScore 19.25, instruction count 20, allocated bytes for code 62 (MethodHash=e2ae1661) for method HardwareEh+<>c:<PosTest19>b__20_0():ubyte:this (FullOpts)
+; Total bytes of code 75, prolog size 4, PerfScore 19.00, instruction count 19, allocated bytes for code 75 (MethodHash=e2ae1661) for method HardwareEh+<>c:<PosTest19>b__20_0():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+27</span> (<span style="color:red">+29.35%</span>) : 250215.dasm - bug1:TestEntryPoint() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V01 cse0         [V01,T01] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
-;  V02 cse1         [V02,T00] (  5,  5   )    long  ->  rax         "CSE - aggressive"
+;  V02 cse1         [V02,T00] (  2,  2   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -23,14 +23,17 @@ G_M5006_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M5006_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      dword ptr [rax], 3
-       mov      dword ptr [rax+0x04], 2
-       mov      rcx, 0xD1FFAB1E
-       mov      qword ptr [rax+0x08], rcx
-       mov      qword ptr [rax+0x10], 1
+       mov      rax, 0xD1FFAB1E      ; global ptr
+       mov      dword ptr [rax], 2
+       mov      rax, 0xD1FFAB1E
+       mov      rcx, 0xD1FFAB1E      ; global ptr
+       mov      qword ptr [rcx], rax
+       mov      rax, 0xD1FFAB1E      ; global ptr
+       mov      qword ptr [rax], 1
        call     [bug1:f():int]
        ; gcr arg pop 0
        nop      
-						;; size=52 bbWeight=1 PerfScore 7.75
+						;; size=79 bbWeight=1 PerfScore 8.50
 G_M5006_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -43,7 +46,7 @@ G_M5006_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        jmp      SHORT G_M5006_IG03
 						;; size=22 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 92, prolog size 4, PerfScore 13.25, instruction count 17, allocated bytes for code 92 (MethodHash=c14fec71) for method bug1:TestEntryPoint() (FullOpts)
+; Total bytes of code 119, prolog size 4, PerfScore 14.00, instruction count 20, allocated bytes for code 119 (MethodHash=c14fec71) for method bug1:TestEntryPoint() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+15</span> (<span style="color:red">+45.45%</span>) : 197587.dasm - Surfaces+<>c:<.cctor>b__5_4(VectorPacket256):VectorPacket256:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -16,11 +16,11 @@
 ;* V05 tmp2         [V05    ] (  0,  0   )  simd32  ->  zero-ref    "field V02.Xs (fldOffset=0x0)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )  simd32  ->  zero-ref    "field V02.Ys (fldOffset=0x20)" P-INDEP
 ;* V07 tmp4         [V07    ] (  0,  0   )  simd32  ->  zero-ref    "field V02.Zs (fldOffset=0x40)" P-INDEP
-;* V08 tmp5         [V08,T04] (  0,  0   )  simd32  ->  zero-ref    "field V04.Xs (fldOffset=0x0)" P-INDEP
-;  V09 tmp6         [V09,T03] (  2,  2   )  simd32  ->  mm1         "field V04.Ys (fldOffset=0x20)" P-INDEP
-;  V10 tmp7         [V10,T02] (  3,  3   )  simd32  ->  mm0         "field V04.Zs (fldOffset=0x40)" P-INDEP
+;* V08 tmp5         [V08,T02] (  0,  0   )  simd32  ->  zero-ref    "field V04.Xs (fldOffset=0x0)" P-INDEP
+;* V09 tmp6         [V09,T03] (  0,  0   )  simd32  ->  zero-ref    "field V04.Ys (fldOffset=0x20)" P-INDEP
+;* V10 tmp7         [V10,T04] (  0,  0   )  simd32  ->  zero-ref    "field V04.Zs (fldOffset=0x40)" P-INDEP
 ;* V11 tmp8         [V11    ] (  0,  0   )  struct (96) zero-ref    "Promoted implicit byref" <VectorPacket256>
-;  V12 cse0         [V12,T01] (  3,  3   )  simd32  ->  mm0         "CSE - aggressive"
+;* V12 cse0         [V12,T01] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -28,22 +28,23 @@ G_M2514_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M2514_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovups  ymm0, ymmword ptr [reloc @RWD00]
-       vmovaps  ymm1, ymm0
-       vmovups  ymmword ptr [rdx], ymm1
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
+       vmovups  ymmword ptr [rdx], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x20], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x40], ymm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=29 bbWeight=1 PerfScore 10.50
+						;; size=44 bbWeight=1 PerfScore 18.25
 G_M2514_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.00
-RWD00  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+RWD00  	dq	3F8000003F800000h, 3F8000003F800000h
 
 
-; Total bytes of code 33, prolog size 0, PerfScore 12.50, instruction count 8, allocated bytes for code 33 (MethodHash=9991f62d) for method Surfaces+<>c:<.cctor>b__5_4(VectorPacket256):VectorPacket256:this (FullOpts)
+; Total bytes of code 48, prolog size 0, PerfScore 20.25, instruction count 9, allocated bytes for code 48 (MethodHash=9991f62d) for method Surfaces+<>c:<.cctor>b__5_4(VectorPacket256):VectorPacket256:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-78.57%</span>) : 197796.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,24 +11,20 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  2,  2   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
+;* V02 tmp1         [V02,T00] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M27674_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M27674_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      eax, eax
-       mov      dword ptr [rsp], eax
-       mov      eax, dword ptr [rsp]
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M27674_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 1, PerfScore 4.50, instruction count 6, allocated bytes for code 14 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -36,9 +32,8 @@ Unwind Info:
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
<summary><span style="color:green">-11</span> (<span style="color:green">-78.57%</span>) : 228051.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,24 +11,20 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  2,  2   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
+;* V02 tmp1         [V02,T00] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M27674_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M27674_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      eax, eax
-       mov      dword ptr [rsp], eax
-       mov      eax, dword ptr [rsp]
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M27674_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 1, PerfScore 4.50, instruction count 6, allocated bytes for code 14 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -36,9 +32,8 @@ Unwind Info:
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
<summary><span style="color:green">-26</span> (<span style="color:green">-68.42%</span>) : 19050.dasm - System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -24,24 +24,16 @@ G_M36138_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M36138_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       xor      eax, eax
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-       mov      eax, 1
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-       mov      eax, 2
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-       mov      eax, 3
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-						;; size=37 bbWeight=1 PerfScore 6.00
+       mov      dword ptr [rcx], edx
+       mov      dword ptr [rcx+0x04], edx
+       mov      dword ptr [rcx+0x08], edx
+       mov      dword ptr [rcx+0x0C], edx
+						;; size=11 bbWeight=1 PerfScore 4.00
 G_M36138_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 38, prolog size 0, PerfScore 7.00, instruction count 13, allocated bytes for code 38 (MethodHash=62e772d5) for method System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)
+; Total bytes of code 12, prolog size 0, PerfScore 5.00, instruction count 5, allocated bytes for code 12 (MethodHash=62e772d5) for method System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+9.76%</span>) : 13100.dasm - System.Memory`1[System.__Canon]:.ctor(System.__Canon[],int,int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -15,22 +15,23 @@
 ;  V04 arg3         [V04,T04] (  3,  1.50)     int  ->  rbp         single-def
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
 G_M7810_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
-       mov      qword ptr [rsp+0x20], rdx
+       sub      rsp, 48
+       mov      qword ptr [rsp+0x28], rdx
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      rbx, r8
        ; gcrRegs +[rbx]
        mov      edi, r9d
-       mov      ebp, dword ptr [rsp+0x70]
-						;; size=26 bbWeight=1 PerfScore 7.00
+       mov      ebp, dword ptr [rsp+0x80]
+						;; size=31 bbWeight=1 PerfScore 8.00
 G_M7810_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref, isz
        test     rbx, rbx
        jne      SHORT G_M7810_IG05
@@ -44,19 +45,21 @@ G_M7810_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, b
        mov      qword ptr [rsi+0x08], rcx
 						;; size=13 bbWeight=0.50 PerfScore 1.75
 G_M7810_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M7810_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, gcvars, byref, isz
        ; gcrRegs +[rbx]
+       mov      r14, qword ptr [rbx]
        mov      rcx, rdx
        call     [CORINFO_HELP_READYTORUN_GENERIC_HANDLE]
        ; gcr arg pop 0
-       cmp      qword ptr [rbx], rax
+       cmp      r14, rax
        jne      SHORT G_M7810_IG07
        mov      ecx, edi
        mov      edx, ebp
@@ -73,15 +76,16 @@ G_M7810_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008
        ; byrRegs -[rcx]
        mov      dword ptr [rsi+0x08], edi
        mov      dword ptr [rsi+0x0C], ebp
-						;; size=47 bbWeight=0.50 PerfScore 8.38
+						;; size=50 bbWeight=0.50 PerfScore 8.00
 G_M7810_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M7810_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rsi]
        call     [System.ThrowHelper:ThrowArrayTypeMismatchException()]
@@ -94,7 +98,7 @@ G_M7810_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 123, prolog size 13, PerfScore 21.62, instruction count 48, allocated bytes for code 123 (MethodHash=fec1e17d) for method System.Memory`1[System.__Canon]:.ctor(System.__Canon[],int,int):this (FullOpts)
+; Total bytes of code 135, prolog size 15, PerfScore 22.75, instruction count 52, allocated bytes for code 135 (MethodHash=fec1e17d) for method System.Memory`1[System.__Canon]:.ctor(System.__Canon[],int,int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -102,13 +106,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>

<details>
<summary><span style="color:red">+9</span> (<span style="color:red">+11.54%</span>) : 177649.dasm - Newtonsoft.Json.Serialization.JsonSerializerInternalReader:HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -13,51 +13,58 @@
 ;  V01 arg1         [V01,T00] (  6,  4.50)     ref  ->  rbx         class-hnd single-def <Newtonsoft.Json.Serialization.JsonContract>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M30830_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     rsi
        push     rbx
-       sub      rsp, 32
+       sub      rsp, 40
        mov      rbx, rdx
        ; gcrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
+						;; size=9 bbWeight=1 PerfScore 2.50
 G_M30830_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        test     rbx, rbx
        je       SHORT G_M30830_IG05
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M30830_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rsi, gword ptr [rbx+0x40]
+       ; gcrRegs +[rsi]
        mov      rcx, qword ptr [(reloc)]      ; <unknown class>
        call     [CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       cmp      gword ptr [rbx+0x40], rax
+       cmp      rsi, rax
        je       SHORT G_M30830_IG05
        cmp      dword ptr [rbx+0x64], 8
        je       SHORT G_M30830_IG05
+       mov      rbx, gword ptr [rbx+0x40]
        mov      rcx, qword ptr [(reloc)]      ; <unknown class>
        call     [CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE]
+       ; gcrRegs -[rsi]
        ; gcr arg pop 0
-       cmp      gword ptr [rbx+0x40], rax
+       cmp      rbx, rax
        sete     al
        ; gcrRegs -[rax]
        movzx    rax, al
-						;; size=48 bbWeight=0.50 PerfScore 11.12
+						;; size=54 bbWeight=0.50 PerfScore 10.38
 G_M30830_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
+       pop      rsi
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
+						;; size=7 bbWeight=0.50 PerfScore 1.12
 G_M30830_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rbx]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M30830_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
+       pop      rsi
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
+						;; size=7 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 78, prolog size 5, PerfScore 15.75, instruction count 23, allocated bytes for code 78 (MethodHash=174d8791) for method Newtonsoft.Json.Serialization.JsonSerializerInternalReader:HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract):ubyte:this (FullOpts)
+; Total bytes of code 87, prolog size 6, PerfScore 16.50, instruction count 28, allocated bytes for code 87 (MethodHash=174d8791) for method Newtonsoft.Json.Serialization.JsonSerializerInternalReader:HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -65,10 +72,11 @@ Unwind Info:
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
<summary><span style="color:red">+8</span> (<span style="color:red">+15.38%</span>) : 92581.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.Metadata.PE.PEParameterSymbol:EnsureParameterNameNotEmpty(System.String,byref):System.String (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,44 +8,59 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )     ref  ->  rbx         class-hnd single-def <System.String>
-;  V01 arg1         [V01,T01] (  4,  4   )   byref  ->  rsi         single-def
+;  V00 arg0         [V00,T01] (  4,  3.50)     ref  ->  rsi         class-hnd single-def <System.String>
+;  V01 arg1         [V01,T00] (  4,  4   )   byref  ->  rbx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 40
 
-G_M11963_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M11963_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rsi
        push     rbx
        sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-       mov      rsi, rdx
-       ; byrRegs +[rsi]
+       mov      rsi, rcx
+       ; gcrRegs +[rsi]
+       mov      rbx, rdx
+       ; byrRegs +[rbx]
 						;; size=12 bbWeight=1 PerfScore 2.75
-G_M11963_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref
-       mov      rcx, rbx
+G_M11963_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+       mov      rcx, rsi
        ; gcrRegs +[rcx]
        call     [<unknown method>]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        test     eax, eax
        sete     al
-       mov      byte  ptr [rsi], al
+       mov      byte  ptr [rbx], al
+       cmp      byte  ptr [rbx], 0
+       jne      SHORT G_M11963_IG05
+						;; size=21 bbWeight=1 PerfScore 9.50
+G_M11963_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rsi]
+       ; byrRegs -[rbx]
        mov      rax, qword ptr [(reloc)]      ; const ptr
-       cmp      byte  ptr [rsi], 0
        mov      rax, gword ptr [rax]
        ; gcrRegs +[rax]
-       cmovne   rax, rbx
-						;; size=33 bbWeight=1 PerfScore 12.75
-G_M11963_IG03:        ; bbWeight=1, epilog, nogc, extend
+						;; size=10 bbWeight=0.50 PerfScore 2.00
+G_M11963_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rsi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=7 bbWeight=0.50 PerfScore 1.12
+G_M11963_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs -[rax] +[rsi]
+       mov      rax, rsi
+       ; gcrRegs +[rax]
+						;; size=3 bbWeight=0.50 PerfScore 0.12
+G_M11963_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
+       pop      rbx
+       pop      rsi
+       ret      
+						;; size=7 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 52, prolog size 6, PerfScore 17.75, instruction count 18, allocated bytes for code 52 (MethodHash=5025d144) for method Microsoft.CodeAnalysis.VisualBasic.Symbols.Metadata.PE.PEParameterSymbol:EnsureParameterNameNotEmpty(System.String,byref):System.String (FullOpts)
+; Total bytes of code 60, prolog size 6, PerfScore 16.62, instruction count 23, allocated bytes for code 60 (MethodHash=5025d144) for method Microsoft.CodeAnalysis.VisualBasic.Symbols.Metadata.PE.PEParameterSymbol:EnsureParameterNameNotEmpty(System.String,byref):System.String (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-43</span> (<span style="color:green">-84.31%</span>) : 98447.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField:IContextualNamedEntity_AssociateWithMetadataWriter(Microsoft.Cci.MetadataWriter):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,52 +8,25 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField>
-;  V01 arg1         [V01,T02] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Cci.MetadataWriter>
-;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T04] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
-;  V04 rat0         [V04,T00] (  3,  5   )     ref  ->  rax         "replacement local"
-;  V05 rat1         [V05,T03] (  3,  2   )    long  ->   r8         "CSE for expectedClsNode"
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField>
+;  V01 arg1         [V01,T01] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Cci.MetadataWriter>
+;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03,T02] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M33487_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M33487_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M33487_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx rdx]
-       mov      rax, rcx
-       ; gcrRegs +[rax]
-       test     rax, rax
-       je       SHORT G_M33487_IG04
-						;; size=8 bbWeight=1 PerfScore 1.50
-G_M33487_IG03:        ; bbWeight=0.50, gcrefRegs=0007 {rax rcx rdx}, byrefRegs=0000 {}, byref, isz
-       mov      r8, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField
-       cmp      qword ptr [rax], r8
-       jne      SHORT G_M33487_IG06
-						;; size=15 bbWeight=0.50 PerfScore 2.12
-G_M33487_IG04:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
        cmp      dword ptr [rcx], ecx
 						;; size=2 bbWeight=1 PerfScore 3.00
-G_M33487_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+G_M33487_IG03:        ; bbWeight=1, epilog, nogc, extend
        tail.jmp [Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField:AssociateWithMetadataWriter(Microsoft.Cci.MetadataWriter):this]
        ; gcr arg pop 0
-						;; size=10 bbWeight=1 PerfScore 2.25
-G_M33487_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rdx]
-       mov      rdx, rcx
-       ; gcrRegs +[rdx]
-       mov      rcx, r8
-       ; gcrRegs -[rcx]
-       call     CORINFO_HELP_CHKCASTCLASS
-       ; gcrRegs -[rdx] +[rax]
-       ; gcr arg pop 0
-       int3     
-						;; size=12 bbWeight=0 PerfScore 0.00
+						;; size=6 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 51, prolog size 4, PerfScore 9.12, instruction count 14, allocated bytes for code 51 (MethodHash=31e27d30) for method Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField:IContextualNamedEntity_AssociateWithMetadataWriter(Microsoft.Cci.MetadataWriter):this (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 2, allocated bytes for code 8 (MethodHash=31e27d30) for method Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField:IContextualNamedEntity_AssociateWithMetadataWriter(Microsoft.Cci.MetadataWriter):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -61,9 +34,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-78.57%</span>) : 198952.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,24 +10,20 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  2,  2   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
+;* V02 tmp1         [V02,T00] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M27674_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M27674_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      eax, eax
-       mov      dword ptr [rsp], eax
-       mov      eax, dword ptr [rsp]
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M27674_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 1, PerfScore 4.50, instruction count 6, allocated bytes for code 14 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -35,9 +31,8 @@ Unwind Info:
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
<summary><span style="color:green">-11</span> (<span style="color:green">-78.57%</span>) : 158527.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,24 +10,20 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  2,  2   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
+;* V02 tmp1         [V02,T00] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M27674_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M27674_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      eax, eax
-       mov      dword ptr [rsp], eax
-       mov      eax, dword ptr [rsp]
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M27674_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 1, PerfScore 4.50, instruction count 6, allocated bytes for code 14 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -35,9 +31,8 @@ Unwind Info:
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
<summary><span style="color:red">+18</span> (<span style="color:red">+17.31%</span>) : 185681.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[System.Numerics.Vector`1[float]](System.Func`2[System.Numerics.Vector`1[float],System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):System.Numerics.Vector`1[float]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,37 +22,38 @@
 ;* V11 tmp6         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V04.[000..001)"
 ;* V12 tmp7         [V12    ] (  0,  0   )  simd32  ->  zero-ref    "V04.[008..040)"
 ;* V13 tmp8         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "V08.[000..001)"
-;  V14 tmp9         [V14,T06] (  2,  1   )  simd32  ->  mm0         "V08.[008..040)"
+;  V14 tmp9         [V14,T06] (  2,  1   )  simd32  ->  mm6         "V08.[008..040)"
 ;  V15 tmp10        [V15,T04] (  3,  2   )   ubyte  ->  rdx         "V07.[000..001)"
-;  V16 tmp11        [V16,T05] (  3,  1.50)  simd32  ->  mm0         "V07.[008..040)"
+;  V16 tmp11        [V16,T05] (  3,  1.50)  simd32  ->  mm6         "V07.[008..040)"
 ;* V17 tmp12        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V09.[000..001)"
-;  V18 tmp13        [V18,T07] (  2,  1   )  simd32  ->  mm0         "V09.[008..040)"
+;* V18 tmp13        [V18,T07] (  0,  0   )  simd32  ->  zero-ref    "V09.[008..040)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 104
 
 G_M30557_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rsi
        push     rbx
-       sub      rsp, 72
+       sub      rsp, 104
+       vmovaps  xmmword ptr [rsp+0x50], xmm6
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      rbx, rdx
        ; byrRegs +[rbx]
        mov      rax, r8
        ; gcrRegs +[rax]
-						;; size=15 bbWeight=1 PerfScore 3.00
+						;; size=21 bbWeight=1 PerfScore 5.00
 G_M30557_IG02:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0248 {rbx rsi r9}, byref, isz
        ; byrRegs +[r9]
        cmp      dword ptr [rsi], 2
        je       SHORT G_M30557_IG04
 						;; size=5 bbWeight=1 PerfScore 4.00
 G_M30557_IG03:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0248 {rbx rsi r9}, byref, isz
-       vxorps   ymm0, ymm0, ymm0
        xor      edx, edx
+       vxorps   ymm6, ymm6, ymm6
        jmp      SHORT G_M30557_IG05
 						;; size=8 bbWeight=0.50 PerfScore 1.29
 G_M30557_IG04:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0248 {rbx rsi r9}, byref
-       vmovups  ymm0, ymmword ptr [rsi+0x08]
+       vmovups  ymm6, ymmword ptr [rsi+0x08]
        mov      edx, 1
 						;; size=10 bbWeight=0.50 PerfScore 2.62
 G_M30557_IG05:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0248 {rbx rsi r9}, byref, isz
@@ -82,26 +83,28 @@ G_M30557_IG06:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0248 {rbx
 						;; size=35 bbWeight=0.50 PerfScore 5.00
 G_M30557_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 72
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       add      rsp, 104
        pop      rbx
        pop      rsi
        ret      
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 G_M30557_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        ; byrRegs -[rax]
-       vmovups  ymmword ptr [rbx], ymm0
+       vmovups  ymmword ptr [rbx], ymm6
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=7 bbWeight=0.50 PerfScore 1.12
 G_M30557_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 72
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       add      rsp, 104
        pop      rbx
        pop      rsi
        ret      
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 
-; Total bytes of code 104, prolog size 6, PerfScore 21.54, instruction count 36, allocated bytes for code 104 (MethodHash=cbda88a2) for method Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[System.Numerics.Vector`1[float]](System.Func`2[System.Numerics.Vector`1[float],System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):System.Numerics.Vector`1[float]:this (FullOpts)
+; Total bytes of code 122, prolog size 12, PerfScore 27.54, instruction count 39, allocated bytes for code 122 (MethodHash=cbda88a2) for method Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[System.Numerics.Vector`1[float]](System.Func`2[System.Numerics.Vector`1[float],System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):System.Numerics.Vector`1[float]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -109,11 +112,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 5 * 16 = 80 = 0x00050
+    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+18</span> (<span style="color:red">+17.31%</span>) : 185682.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[long](System.Func`2[long,System.Numerics.Vector`1[float]],long):System.Numerics.Vector`1[float]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,36 +22,37 @@
 ;* V11 tmp6         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V04.[000..001)"
 ;* V12 tmp7         [V12    ] (  0,  0   )  simd32  ->  zero-ref    "V04.[008..040)"
 ;* V13 tmp8         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "V08.[000..001)"
-;  V14 tmp9         [V14,T06] (  2,  1   )  simd32  ->  mm0         "V08.[008..040)"
+;  V14 tmp9         [V14,T06] (  2,  1   )  simd32  ->  mm6         "V08.[008..040)"
 ;  V15 tmp10        [V15,T04] (  3,  2   )   ubyte  ->  rdx         "V07.[000..001)"
-;  V16 tmp11        [V16,T05] (  3,  1.50)  simd32  ->  mm0         "V07.[008..040)"
+;  V16 tmp11        [V16,T05] (  3,  1.50)  simd32  ->  mm6         "V07.[008..040)"
 ;* V17 tmp12        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V09.[000..001)"
-;  V18 tmp13        [V18,T07] (  2,  1   )  simd32  ->  mm0         "V09.[008..040)"
+;* V18 tmp13        [V18,T07] (  0,  0   )  simd32  ->  zero-ref    "V09.[008..040)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 104
 
 G_M29652_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rsi
        push     rbx
-       sub      rsp, 72
+       sub      rsp, 104
+       vmovaps  xmmword ptr [rsp+0x50], xmm6
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      rbx, rdx
        ; byrRegs +[rbx]
        mov      rax, r8
        ; gcrRegs +[rax]
-						;; size=15 bbWeight=1 PerfScore 3.00
+						;; size=21 bbWeight=1 PerfScore 5.00
 G_M29652_IG02:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0048 {rbx rsi}, byref, isz
        cmp      dword ptr [rsi], 2
        je       SHORT G_M29652_IG04
 						;; size=5 bbWeight=1 PerfScore 4.00
 G_M29652_IG03:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0048 {rbx rsi}, byref, isz
-       vxorps   ymm0, ymm0, ymm0
        xor      edx, edx
+       vxorps   ymm6, ymm6, ymm6
        jmp      SHORT G_M29652_IG05
 						;; size=8 bbWeight=0.50 PerfScore 1.29
 G_M29652_IG04:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0048 {rbx rsi}, byref
-       vmovups  ymm0, ymmword ptr [rsi+0x08]
+       vmovups  ymm6, ymmword ptr [rsi+0x08]
        mov      edx, 1
 						;; size=10 bbWeight=0.50 PerfScore 2.62
 G_M29652_IG05:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0048 {rbx rsi}, byref, isz
@@ -79,26 +80,28 @@ G_M29652_IG06:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0048 {rbx
 						;; size=35 bbWeight=0.50 PerfScore 5.00
 G_M29652_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 72
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       add      rsp, 104
        pop      rbx
        pop      rsi
        ret      
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 G_M29652_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        ; byrRegs -[rax]
-       vmovups  ymmword ptr [rbx], ymm0
+       vmovups  ymmword ptr [rbx], ymm6
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=7 bbWeight=0.50 PerfScore 1.12
 G_M29652_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 72
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       add      rsp, 104
        pop      rbx
        pop      rsi
        ret      
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 
-; Total bytes of code 104, prolog size 6, PerfScore 21.54, instruction count 36, allocated bytes for code 104 (MethodHash=f3e38c2b) for method Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[long](System.Func`2[long,System.Numerics.Vector`1[float]],long):System.Numerics.Vector`1[float]:this (FullOpts)
+; Total bytes of code 122, prolog size 12, PerfScore 27.54, instruction count 39, allocated bytes for code 122 (MethodHash=f3e38c2b) for method Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[long](System.Func`2[long,System.Numerics.Vector`1[float]],long):System.Numerics.Vector`1[float]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -106,11 +109,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 5 * 16 = 80 = 0x00050
+    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+18</span> (<span style="color:red">+17.48%</span>) : 185680.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[double](System.Func`2[double,System.Numerics.Vector`1[float]],double):System.Numerics.Vector`1[float]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,35 +22,36 @@
 ;* V11 tmp6         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V04.[000..001)"
 ;* V12 tmp7         [V12    ] (  0,  0   )  simd32  ->  zero-ref    "V04.[008..040)"
 ;* V13 tmp8         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "V08.[000..001)"
-;  V14 tmp9         [V14,T06] (  2,  1   )  simd32  ->  mm2         "V08.[008..040)"
+;  V14 tmp9         [V14,T06] (  2,  1   )  simd32  ->  mm6         "V08.[008..040)"
 ;  V15 tmp10        [V15,T03] (  3,  2   )   ubyte  ->  rdx         "V07.[000..001)"
-;  V16 tmp11        [V16,T05] (  3,  1.50)  simd32  ->  mm2         "V07.[008..040)"
+;  V16 tmp11        [V16,T05] (  3,  1.50)  simd32  ->  mm6         "V07.[008..040)"
 ;* V17 tmp12        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V09.[000..001)"
-;  V18 tmp13        [V18,T07] (  2,  1   )  simd32  ->  mm2         "V09.[008..040)"
+;* V18 tmp13        [V18,T07] (  0,  0   )  simd32  ->  zero-ref    "V09.[008..040)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 104
 
 G_M15275_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rsi
        push     rbx
-       sub      rsp, 72
+       sub      rsp, 104
+       vmovaps  xmmword ptr [rsp+0x50], xmm6
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=12 bbWeight=1 PerfScore 2.75
+						;; size=18 bbWeight=1 PerfScore 4.75
 G_M15275_IG02:        ; bbWeight=1, gcrefRegs=0100 {r8}, byrefRegs=0048 {rbx rsi}, byref, isz
        ; gcrRegs +[r8]
        cmp      dword ptr [rsi], 2
        je       SHORT G_M15275_IG04
 						;; size=5 bbWeight=1 PerfScore 4.00
 G_M15275_IG03:        ; bbWeight=0.50, gcrefRegs=0100 {r8}, byrefRegs=0048 {rbx rsi}, byref, isz
-       vxorps   ymm2, ymm2, ymm2
        xor      edx, edx
+       vxorps   ymm6, ymm6, ymm6
        jmp      SHORT G_M15275_IG05
 						;; size=8 bbWeight=0.50 PerfScore 1.29
 G_M15275_IG04:        ; bbWeight=0.50, gcrefRegs=0100 {r8}, byrefRegs=0048 {rbx rsi}, byref
-       vmovups  ymm2, ymmword ptr [rsi+0x08]
+       vmovups  ymm6, ymmword ptr [rsi+0x08]
        mov      edx, 1
 						;; size=10 bbWeight=0.50 PerfScore 2.62
 G_M15275_IG05:        ; bbWeight=1, gcrefRegs=0100 {r8}, byrefRegs=0048 {rbx rsi}, byref, isz
@@ -78,26 +79,28 @@ G_M15275_IG06:        ; bbWeight=0.50, gcrefRegs=0100 {r8}, byrefRegs=0048 {rbx
 						;; size=37 bbWeight=0.50 PerfScore 5.00
 G_M15275_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 72
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       add      rsp, 104
        pop      rbx
        pop      rsi
        ret      
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 G_M15275_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref
        ; byrRegs -[rax]
-       vmovups  ymmword ptr [rbx], ymm2
+       vmovups  ymmword ptr [rbx], ymm6
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=7 bbWeight=0.50 PerfScore 1.12
 G_M15275_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 72
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       add      rsp, 104
        pop      rbx
        pop      rsi
        ret      
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 
-; Total bytes of code 103, prolog size 6, PerfScore 21.29, instruction count 35, allocated bytes for code 103 (MethodHash=2c63c454) for method Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[double](System.Func`2[double,System.Numerics.Vector`1[float]],double):System.Numerics.Vector`1[float]:this (FullOpts)
+; Total bytes of code 121, prolog size 12, PerfScore 27.29, instruction count 38, allocated bytes for code 121 (MethodHash=2c63c454) for method Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[double](System.Func`2[double,System.Numerics.Vector`1[float]],double):System.Numerics.Vector`1[float]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -105,11 +108,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 5 * 16 = 80 = 0x00050
+    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-60.98%</span>) : 419489.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,10 +16,10 @@
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Runtime.InteropServices.OSPlatform>
 ;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V06 tmp4         [V06    ] (  0,  0   )     ref  ->  zero-ref    single-def "spilling varStr"
-;* V07 tmp5         [V07,T03] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
+;* V07 tmp5         [V07,T02] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "NewObj constructor temp" <System.Buffers.BoundedMemory+UnixImplementation`1[System.Half]>
 ;* V09 tmp7         [V09    ] (  0,  0   )     ref  ->  zero-ref    "field V03.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V10 tmp8         [V10,T02] (  3,  3   )     ref  ->  rax         single-def "field V04.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
+;* V10 tmp8         [V10,T03] (  0,  0   )     ref  ->  zero-ref    single-def "field V04.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
 ;
 ; Lcl frame size = 40
 
@@ -27,24 +27,17 @@ G_M10508_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M10508_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       mov      rax, gword ptr [rax+0x08]
-       mov      r8, qword ptr [rax+0x0C]
-       mov      rax, qword ptr [rax+0x12]
-       ; gcrRegs -[rax]
        call     [System.Buffers.BoundedMemory:AllocateWithoutDataPopulationWindows[System.Half](int,int):System.Buffers.BoundedMemory+WindowsImplementation`1[System.Half]]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
        nop      
-						;; size=32 bbWeight=1 PerfScore 11.50
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M10508_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 41, prolog size 4, PerfScore 13.00, instruction count 10, allocated bytes for code 41 (MethodHash=df70d6f3) for method System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=df70d6f3) for method System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-60.98%</span>) : 415906.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[double](int,int):System.Buffers.BoundedMemory`1[double] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,10 +16,10 @@
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Runtime.InteropServices.OSPlatform>
 ;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V06 tmp4         [V06    ] (  0,  0   )     ref  ->  zero-ref    single-def "spilling varStr"
-;* V07 tmp5         [V07,T03] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
+;* V07 tmp5         [V07,T02] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "NewObj constructor temp" <System.Buffers.BoundedMemory+UnixImplementation`1[double]>
 ;* V09 tmp7         [V09    ] (  0,  0   )     ref  ->  zero-ref    "field V03.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V10 tmp8         [V10,T02] (  3,  3   )     ref  ->  rax         single-def "field V04.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
+;* V10 tmp8         [V10,T03] (  0,  0   )     ref  ->  zero-ref    single-def "field V04.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
 ;
 ; Lcl frame size = 40
 
@@ -27,24 +27,17 @@ G_M57932_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M57932_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       mov      rax, gword ptr [rax+0x08]
-       mov      r8, qword ptr [rax+0x0C]
-       mov      rax, qword ptr [rax+0x12]
-       ; gcrRegs -[rax]
        call     [System.Buffers.BoundedMemory:AllocateWithoutDataPopulationWindows[double](int,int):System.Buffers.BoundedMemory+WindowsImplementation`1[double]]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
        nop      
-						;; size=32 bbWeight=1 PerfScore 11.50
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M57932_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 41, prolog size 4, PerfScore 13.00, instruction count 10, allocated bytes for code 41 (MethodHash=77c91db3) for method System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[double](int,int):System.Buffers.BoundedMemory`1[double] (Tier1)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=77c91db3) for method System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[double](int,int):System.Buffers.BoundedMemory`1[double] (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-60.98%</span>) : 417506.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,10 +16,10 @@
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Runtime.InteropServices.OSPlatform>
 ;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V06 tmp4         [V06    ] (  0,  0   )     ref  ->  zero-ref    single-def "spilling varStr"
-;* V07 tmp5         [V07,T03] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
+;* V07 tmp5         [V07,T02] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "NewObj constructor temp" <System.Buffers.BoundedMemory+UnixImplementation`1[System.Half]>
 ;* V09 tmp7         [V09    ] (  0,  0   )     ref  ->  zero-ref    "field V03.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V10 tmp8         [V10,T02] (  3,  3   )     ref  ->  rax         single-def "field V04.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
+;* V10 tmp8         [V10,T03] (  0,  0   )     ref  ->  zero-ref    single-def "field V04.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
 ;
 ; Lcl frame size = 40
 
@@ -27,24 +27,17 @@ G_M10508_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
 G_M10508_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       mov      rax, gword ptr [rax+0x08]
-       mov      r8, qword ptr [rax+0x0C]
-       mov      rax, qword ptr [rax+0x12]
-       ; gcrRegs -[rax]
        call     [System.Buffers.BoundedMemory:AllocateWithoutDataPopulationWindows[System.Half](int,int):System.Buffers.BoundedMemory+WindowsImplementation`1[System.Half]]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
        nop      
-						;; size=32 bbWeight=1 PerfScore 11.50
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M10508_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 41, prolog size 4, PerfScore 13.00, instruction count 10, allocated bytes for code 41 (MethodHash=df70d6f3) for method System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)
+; Total bytes of code 16, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 16 (MethodHash=df70d6f3) for method System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+11.11%</span>) : 64465.dasm - NuGet.Configuration.AddItem:GetValueAsPath():System.String:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,32 +9,32 @@
 ; 10 inlinees with PGO data; 7 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  9,  5   )     ref  ->  rcx         this class-hnd single-def <NuGet.Configuration.AddItem>
+;  V00 this         [V00,T00] (  9,  5   )     ref  ->  rcx         this class-hnd single-def <NuGet.Configuration.AddItem>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T07] (  4,  2   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <System.String>
-;  V03 tmp2         [V03,T08] (  4,  2   )     ref  ->  rsi         class-hnd exact single-def "impAppendStmt" <System.String>
+;  V02 tmp1         [V02,T06] (  4,  2   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <System.String>
+;  V03 tmp2         [V03,T07] (  4,  2   )     ref  ->  rsi         class-hnd exact single-def "impAppendStmt" <System.String>
 ;  V04 tmp3         [V04,T02] (  6,  4   )     ref  ->  rdi         "guarded devirt return temp"
 ;* V05 tmp4         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <NuGet.Configuration.SourceItem>
 ;* V06 tmp5         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <NuGet.Configuration.SettingsFile>
 ;* V07 tmp6         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <NuGet.Configuration.SettingsFile>
-;  V08 tmp7         [V08,T00] (  5,  8.00)     ref  ->  rcx         class-hnd single-def "spilling ret_expr" <System.Collections.Generic.Dictionary`2[System.String,System.String]>
-;  V09 tmp8         [V09,T04] (  7,  4.90)     ref  ->  rcx         "guarded devirt return temp"
+;  V08 tmp7         [V08,T01] (  4,  6.00)     ref  ->  rcx         class-hnd single-def "spilling ret_expr" <System.Collections.Generic.Dictionary`2[System.String,System.String]>
+;  V09 tmp8         [V09,T04] (  6,  3.90)     ref  ->  rcx         "guarded devirt return temp"
 ;* V10 tmp9         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Collections.Generic.Dictionary`2[System.String,System.String]>
 ;  V11 tmp10        [V11,T05] (  3,  3.00)   byref  ->  rax         single-def "Inline stloc first use temp"
 ;* V12 tmp11        [V12    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inline ldloca(s) first use temp" <System.String>
-;  V13 tmp12        [V13,T09] (  3,  3.00)     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
+;  V13 tmp12        [V13,T09] (  3,  2.00)     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
 ;* V14 tmp13        [V14,T14] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V15 tmp14        [V15,T10] (  3,  2.00)     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
-;  V16 tmp15        [V16,T11] (  3,  2   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
+;  V15 tmp14        [V15,T11] (  2,  2.00)     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
+;  V16 tmp15        [V16,T10] (  3,  2   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
 ;  V17 tmp16        [V17,T13] (  2,  1   )     ref  ->  rcx         ld-addr-op class-hnd single-def "Inline ldloca(s) first use temp" <System.Uri>
-;  V18 tmp17        [V18,T12] (  3,  2   )   ubyte  ->  rbp         "Inline return value spill temp"
-;  V19 tmp18        [V19    ] (  4,  4   )     ref  ->  [rsp+0x30]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V18 tmp17        [V18,T08] (  4,  2   )   ubyte  ->  rbp         "Inline return value spill temp"
+;  V19 tmp18        [V19    ] (  5,  4   )     ref  ->  [rsp+0x30]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline stloc first use temp" <<unknown class>>
 ;  V20 tmp19        [V20    ] (  2,  2   )  struct ( 8) [rsp+0x28]  do-not-enreg[XS] addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <System.UriCreationOptions>
 ;  V21 tmp20        [V21,T15] (  2,  0   )   ubyte  ->  rcx         "Inline return value spill temp"
 ;  V22 tmp21        [V22,T16] (  2,  0   )   ubyte  ->  rcx         "Inline return value spill temp"
 ;  V23 tmp22        [V23    ] (  2,  2   )   ubyte  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V20._disablePathAndQueryCanonicalization (fldOffset=0x0)" P-DEP
 ;  V24 cse0         [V24,T03] (  4,  4   )     ref  ->  rdx         "CSE - aggressive"
-;  V25 cse1         [V25,T06] (  3,  2.79)     int  ->  rax         "CSE - aggressive"
+;  V25 cse1         [V25,T12] (  2,  1.79)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 56
 
@@ -52,7 +52,7 @@ G_M5714_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        mov      rdx, gword ptr [rcx+0x18]
        ; gcrRegs +[rdx]
        test     rdx, rdx
-       je       G_M5714_IG17
+       je       G_M5714_IG11
        mov      rbx, gword ptr [rdx+0x10]
        ; gcrRegs +[rbx]
        mov      rsi, gword ptr [rdx+0x08]
@@ -60,14 +60,13 @@ G_M5714_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        mov      rdx, 0xD1FFAB1E      ; NuGet.Configuration.SourceItem
        ; gcrRegs -[rdx]
        cmp      qword ptr [rcx], rdx
-       jne      G_M5714_IG14
+       jne      G_M5714_IG16
 						;; size=40 bbWeight=1 PerfScore 11.50
 G_M5714_IG03:        ; bbWeight=1.00, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rcx, gword ptr [rcx+0x48]
        mov      rdx, 0xD1FFAB1E      ; System.Collections.Generic.Dictionary`2[System.String,System.String]
        cmp      qword ptr [rcx], rdx
-       jne      G_M5714_IG20
-       cmp      byte  ptr [rcx], cl
+       jne      G_M5714_IG14
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        call     [<unknown method>]
@@ -75,29 +74,27 @@ G_M5714_IG03:        ; bbWeight=1.00, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=00
        ; byrRegs +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       G_M5714_IG19
+       je       G_M5714_IG13
        mov      rcx, gword ptr [rax]
        ; gcrRegs +[rcx]
-						;; size=53 bbWeight=1.00 PerfScore 15.75
-G_M5714_IG04:        ; bbWeight=1.00, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
+						;; size=51 bbWeight=1.00 PerfScore 12.75
+G_M5714_IG04:        ; bbWeight=1.00, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
        ; byrRegs -[rax]
        test     rcx, rcx
-       je       SHORT G_M5714_IG12
-						;; size=5 bbWeight=1.00 PerfScore 1.25
-G_M5714_IG05:        ; bbWeight=0.90, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       je       G_M5714_IG15
+						;; size=9 bbWeight=1.00 PerfScore 1.25
+G_M5714_IG05:        ; bbWeight=0.90, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
        mov      eax, dword ptr [rcx+0x08]
        test     eax, eax
-       je       SHORT G_M5714_IG12
-						;; size=7 bbWeight=0.90 PerfScore 2.92
-G_M5714_IG06:        ; bbWeight=1.00, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
-       test     eax, eax
-       je       SHORT G_M5714_IG13
+       je       G_M5714_IG15
+						;; size=11 bbWeight=0.90 PerfScore 2.92
+G_M5714_IG06:        ; bbWeight=1.00, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
        call     [System.Environment:ExpandEnvironmentVariablesCore(System.String):System.String]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        mov      rdi, rax
        ; gcrRegs +[rdi]
-						;; size=13 bbWeight=1.00 PerfScore 4.50
+						;; size=9 bbWeight=1.00 PerfScore 3.25
 G_M5714_IG07:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        test     rdi, rdi
@@ -120,25 +117,23 @@ G_M5714_IG07:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000
        mov      rcx, rax
        ; gcrRegs +[rcx]
        cmp      gword ptr [rsp+0x30], 0
-       je       SHORT G_M5714_IG15
-						;; size=61 bbWeight=1 PerfScore 12.50
+       je       G_M5714_IG17
+						;; size=65 bbWeight=1 PerfScore 12.50
 G_M5714_IG08:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rcx]
        xor      ebp, ebp
-						;; size=2 bbWeight=1 PerfScore 0.25
-G_M5714_IG09:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        xor      rax, rax
        ; gcrRegs +[rax]
        mov      gword ptr [rsp+0x30], rax
        test     ebp, ebp
-       jne      SHORT G_M5714_IG16
-						;; size=11 bbWeight=1 PerfScore 2.50
-G_M5714_IG10:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
+       jne      G_M5714_IG18
+						;; size=17 bbWeight=1 PerfScore 2.75
+G_M5714_IG09:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rbx rsi]
        mov      rax, rdi
        ; gcrRegs +[rax]
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M5714_IG11:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+G_M5714_IG10:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rdi]
        add      rsp, 56
        pop      rbx
@@ -147,66 +142,7 @@ G_M5714_IG11:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byre
        pop      rdi
        ret      
 						;; size=9 bbWeight=1 PerfScore 3.25
-G_M5714_IG12:        ; bbWeight=1.00, gcVars=0000000000000000 {}, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs -[rax] +[rcx rbx rsi]
-       mov      rdi, rcx
-       ; gcrRegs +[rdi]
-       jmp      SHORT G_M5714_IG07
-						;; size=5 bbWeight=1.00 PerfScore 2.25
-G_M5714_IG13:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rdi]
-       mov      rdi, rcx
-       ; gcrRegs +[rdi]
-       jmp      SHORT G_M5714_IG07
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M5714_IG14:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rdi]
-       mov      rax, qword ptr [rcx]
-       mov      rax, qword ptr [rax+0x58]
-       call     [rax+0x08]NuGet.Configuration.AddItem:get_Value():System.String:this
-       ; gcrRegs -[rcx] +[rax]
-       ; gcr arg pop 0
-       mov      rdi, rax
-       ; gcrRegs +[rdi]
-       jmp      SHORT G_M5714_IG07
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M5714_IG15:        ; bbWeight=0, gcrefRegs=00CA {rcx rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax] +[rcx]
-       xor      rdx, rdx
-       ; gcrRegs +[rdx]
-       call     [System.Uri:op_Inequality(System.Uri,System.Uri):ubyte]
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-       mov      ebp, eax
-       jmp      SHORT G_M5714_IG09
-						;; size=12 bbWeight=0 PerfScore 0.00
-G_M5714_IG16:        ; bbWeight=0, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
-       test     rbx, rbx
-       je       SHORT G_M5714_IG10
-       xor      ecx, ecx
-       cmp      dword ptr [rbx+0x08], 0
-       sete     cl
-       test     ecx, ecx
-       jne      SHORT G_M5714_IG10
-       test     rsi, rsi
-       je       SHORT G_M5714_IG10
-       xor      ecx, ecx
-       cmp      dword ptr [rsi+0x08], 0
-       sete     cl
-       test     ecx, ecx
-       jne      SHORT G_M5714_IG10
-       mov      rcx, rbx
-       ; gcrRegs +[rcx]
-       mov      rdx, rsi
-       ; gcrRegs +[rdx]
-       mov      r8, rdi
-       ; gcrRegs +[r8]
-       call     [NuGet.Configuration.Settings:ResolveRelativePath(System.String,System.String,System.String):System.String]
-       ; gcrRegs -[rcx rdx rbx rsi rdi r8] +[rax]
-       ; gcr arg pop 0
-       jmp      SHORT G_M5714_IG11
-						;; size=53 bbWeight=0 PerfScore 0.00
-G_M5714_IG17:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+G_M5714_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax] +[rcx]
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x58]
@@ -215,7 +151,7 @@ G_M5714_IG17:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        ; gcr arg pop 0
        nop      
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M5714_IG18:        ; bbWeight=0, epilog, nogc, extend
+G_M5714_IG12:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -223,7 +159,7 @@ G_M5714_IG18:        ; bbWeight=0, epilog, nogc, extend
        pop      rdi
        ret      
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M5714_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M5714_IG13:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        mov      rcx, 0xD1FFAB1E      ; <unknown method>
        mov      rdx, 0xD1FFAB1E
@@ -233,7 +169,7 @@ G_M5714_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        ; gcr arg pop 0
        int3     
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M5714_IG20:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
+G_M5714_IG14:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx rbx rsi]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        mov      rdx, 0xD1FFAB1E
@@ -245,8 +181,66 @@ G_M5714_IG20:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000
        ; gcrRegs +[rcx]
        jmp      G_M5714_IG04
 						;; size=31 bbWeight=0 PerfScore 0.00
+G_M5714_IG15:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax]
+       mov      rdi, rcx
+       ; gcrRegs +[rdi]
+       jmp      G_M5714_IG07
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M5714_IG16:        ; bbWeight=0, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rdi]
+       mov      rax, qword ptr [rcx]
...

```


</div></details>

<details>
<summary><span style="color:red">+22</span> (<span style="color:red">+14.47%</span>) : 61446.dasm - Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,9 +16,9 @@
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V05 tmp4         [V05    ] (  0,  0   )     ref  ->  zero-ref    "spilling varStr"
 ;* V06 tmp5         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V07 tmp6         [V07,T03] (  2,  0   )   ubyte  ->  rcx         single-def "field V04.hasValue (fldOffset=0x0)" P-INDEP
-;  V08 tmp7         [V08,T04] (  2,  0   )   ubyte  ->  rax         single-def "field V04.value (fldOffset=0x1)" P-INDEP
-;  V09 cse0         [V09,T00] (  5,  4   )   byref  ->  rbx         "CSE - aggressive"
+;* V07 tmp6         [V07,T04] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V04.hasValue (fldOffset=0x0)" P-INDEP
+;  V08 tmp7         [V08,T03] (  2,  0   )   ubyte  ->  rax         single-def "field V04.value (fldOffset=0x1)" P-INDEP
+;  V09 cse0         [V09,T00] (  4,  3   )   byref  ->  rbx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -33,11 +33,13 @@ G_M26216_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        cmp      byte  ptr [rbx], 0
        je       SHORT G_M26216_IG05
        cmp      byte  ptr [rbx], 0
-       je       SHORT G_M26216_IG08
-						;; size=20 bbWeight=1 PerfScore 8.25
-G_M26216_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
-       movzx    rax, byte  ptr [rbx+0x01]
-						;; size=4 bbWeight=1 PerfScore 2.00
+       je       G_M26216_IG08
+						;; size=24 bbWeight=1 PerfScore 8.25
+G_M26216_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; byrRegs -[rbx]
+       mov      rax, 0xD1FFAB1E      ; global ptr
+       movzx    rax, byte  ptr [rax]
+						;; size=13 bbWeight=1 PerfScore 2.25
 G_M26216_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
@@ -45,6 +47,7 @@ G_M26216_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=7 bbWeight=1 PerfScore 2.25
 G_M26216_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+       ; byrRegs +[rbx]
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        call     [System.Environment:GetEnvironmentVariable(System.String):System.String]
@@ -75,15 +78,15 @@ G_M26216_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 G_M26216_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        mov      eax, 1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M26216_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M26216_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        movzx    rax, al
-       mov      ecx, 1
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      byte  ptr [rdx], cl
-       mov      byte  ptr [rdx+0x01], al
+       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+       mov      byte  ptr [rcx], 1
+       mov      rcx, 0xD1FFAB1E
+       mov      byte  ptr [rcx], al
        cmp      byte  ptr [rbx], 0
-       jne      SHORT G_M26216_IG03
-						;; size=28 bbWeight=0 PerfScore 0.00
+       jne      G_M26216_IG03
+						;; size=37 bbWeight=0 PerfScore 0.00
 G_M26216_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rbx]
        call     [System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()]
@@ -91,7 +94,7 @@ G_M26216_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 152, prolog size 6, PerfScore 14.75, instruction count 37, allocated bytes for code 152 (MethodHash=48599997) for method Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)
+; Total bytes of code 174, prolog size 6, PerfScore 15.00, instruction count 38, allocated bytes for code 174 (MethodHash=48599997) for method Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+22</span> (<span style="color:red">+14.47%</span>) : 83801.dasm - Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,9 +16,9 @@
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V05 tmp4         [V05    ] (  0,  0   )     ref  ->  zero-ref    "spilling varStr"
 ;* V06 tmp5         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V07 tmp6         [V07,T03] (  2,  0   )   ubyte  ->  rcx         single-def "field V04.hasValue (fldOffset=0x0)" P-INDEP
-;  V08 tmp7         [V08,T04] (  2,  0   )   ubyte  ->  rax         single-def "field V04.value (fldOffset=0x1)" P-INDEP
-;  V09 cse0         [V09,T00] (  5,  4   )   byref  ->  rbx         "CSE - aggressive"
+;* V07 tmp6         [V07,T04] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V04.hasValue (fldOffset=0x0)" P-INDEP
+;  V08 tmp7         [V08,T03] (  2,  0   )   ubyte  ->  rax         single-def "field V04.value (fldOffset=0x1)" P-INDEP
+;  V09 cse0         [V09,T00] (  4,  3   )   byref  ->  rbx         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -33,11 +33,13 @@ G_M26216_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        cmp      byte  ptr [rbx], 0
        je       SHORT G_M26216_IG05
        cmp      byte  ptr [rbx], 0
-       je       SHORT G_M26216_IG08
-						;; size=20 bbWeight=1 PerfScore 8.25
-G_M26216_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
-       movzx    rax, byte  ptr [rbx+0x01]
-						;; size=4 bbWeight=1 PerfScore 2.00
+       je       G_M26216_IG08
+						;; size=24 bbWeight=1 PerfScore 8.25
+G_M26216_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; byrRegs -[rbx]
+       mov      rax, 0xD1FFAB1E      ; global ptr
+       movzx    rax, byte  ptr [rax]
+						;; size=13 bbWeight=1 PerfScore 2.25
 G_M26216_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
@@ -45,6 +47,7 @@ G_M26216_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=7 bbWeight=1 PerfScore 2.25
 G_M26216_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+       ; byrRegs +[rbx]
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        call     [System.Environment:GetEnvironmentVariable(System.String):System.String]
@@ -75,15 +78,15 @@ G_M26216_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 G_M26216_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        mov      eax, 1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M26216_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M26216_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        movzx    rax, al
-       mov      ecx, 1
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      byte  ptr [rdx], cl
-       mov      byte  ptr [rdx+0x01], al
+       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+       mov      byte  ptr [rcx], 1
+       mov      rcx, 0xD1FFAB1E
+       mov      byte  ptr [rcx], al
        cmp      byte  ptr [rbx], 0
-       jne      SHORT G_M26216_IG03
-						;; size=28 bbWeight=0 PerfScore 0.00
+       jne      G_M26216_IG03
+						;; size=37 bbWeight=0 PerfScore 0.00
 G_M26216_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rbx]
        call     [System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()]
@@ -91,7 +94,7 @@ G_M26216_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 152, prolog size 6, PerfScore 14.75, instruction count 37, allocated bytes for code 152 (MethodHash=48599997) for method Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)
+; Total bytes of code 174, prolog size 6, PerfScore 15.00, instruction count 38, allocated bytes for code 174 (MethodHash=48599997) for method Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-96.15%</span>) : 231836.dasm - System.Security.Cryptography.ProtectedData:CheckPlatformSupport() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,28 +14,19 @@
 ;* V03 tmp3         [V03    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Runtime.InteropServices.OSPlatform>
 ;* V04 tmp4         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V05 tmp5         [V05    ] (  0,  0   )     ref  ->  zero-ref    single-def "spilling varStr"
-;* V06 tmp6         [V06,T01] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
+;* V06 tmp6         [V06,T00] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
 ;* V07 tmp7         [V07    ] (  0,  0   )     ref  ->  zero-ref    "field V01.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V08 tmp8         [V08,T00] (  3,  3   )     ref  ->  rax         single-def "field V03.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
+;* V08 tmp8         [V08,T01] (  0,  0   )     ref  ->  zero-ref    single-def "field V03.<Name>k__BackingField (fldOffset=0x0)" P-INDEP
 ;
 ; Lcl frame size = 0
 
 G_M63334_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
-G_M63334_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       mov      rax, gword ptr [rax+0x08]
-       mov      rcx, qword ptr [rax+0x0C]
-       mov      rax, qword ptr [rax+0x12]
-       ; gcrRegs -[rax]
-						;; size=25 bbWeight=1 PerfScore 8.25
-G_M63334_IG03:        ; bbWeight=1, epilog, nogc, extend
+G_M63334_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 26, prolog size 0, PerfScore 9.25, instruction count 6, allocated bytes for code 26 (MethodHash=cfad0899) for method System.Security.Cryptography.ProtectedData:CheckPlatformSupport() (FullOpts)
+; Total bytes of code 1, prolog size 0, PerfScore 1.00, instruction count 1, allocated bytes for code 1 (MethodHash=cfad0899) for method System.Security.Cryptography.ProtectedData:CheckPlatformSupport() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-19</span> (<span style="color:green">-95.00%</span>) : 88926.dasm - System.ComponentModel.Design.Serialization.Tests.MemberRelationshipTests:Empty_Get_ReturnsExpected():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,26 +22,18 @@
 ;* V11 tmp9         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V06.value (fldOffset=0x1)" P-INDEP
 ;* V12 tmp10        [V12    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V07.hasValue (fldOffset=0x0)" P-INDEP
 ;* V13 tmp11        [V13    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V07.value (fldOffset=0x1)" P-INDEP
-;  V14 tmp12        [V14,T00] (  3,  6   )     ref  ->  rax         single-def "BlockOp address local"
+;* V14 tmp12        [V14,T00] (  0,  0   )     ref  ->  zero-ref    single-def "BlockOp address local"
 ;* V15 tmp13        [V15    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
 ;
 ; Lcl frame size = 0
 
 G_M41626_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
-G_M41626_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       mov      ecx, dword ptr [rax+0x08]
-       mov      eax, dword ptr [rax+0x10]
-       ; gcrRegs -[rax]
-						;; size=19 bbWeight=1 PerfScore 6.25
-G_M41626_IG03:        ; bbWeight=1, epilog, nogc, extend
+G_M41626_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 7.25, instruction count 5, allocated bytes for code 20 (MethodHash=62cd5d65) for method System.ComponentModel.Design.Serialization.Tests.MemberRelationshipTests:Empty_Get_ReturnsExpected():this (FullOpts)
+; Total bytes of code 1, prolog size 0, PerfScore 1.00, instruction count 1, allocated bytes for code 1 (MethodHash=62cd5d65) for method System.ComponentModel.Design.Serialization.Tests.MemberRelationshipTests:Empty_Get_ReturnsExpected():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-15</span> (<span style="color:green">-93.75%</span>) : 54741.dasm - Microsoft.Extensions.Logging.Abstractions.NullLoggerTest:IsEnabled_AlwaysFalse():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.Logging.Abstractions.NullLoggerTest>
-;  V01 loc0         [V01,T00] (  2,  2   )     ref  ->  rax         class-hnd exact single-def <Microsoft.Extensions.Logging.Abstractions.NullLogger>
+;* V01 loc0         [V01,T00] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <Microsoft.Extensions.Logging.Abstractions.NullLogger>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Nullable`1[ubyte]>
@@ -53,17 +53,11 @@
 
 G_M57518_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
-G_M57518_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; const ptr
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
-						;; size=15 bbWeight=1 PerfScore 5.25
-G_M57518_IG03:        ; bbWeight=1, epilog, nogc, extend
+G_M57518_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 16, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 16 (MethodHash=26ec1f51) for method Microsoft.Extensions.Logging.Abstractions.NullLoggerTest:IsEnabled_AlwaysFalse():this (FullOpts)
+; Total bytes of code 1, prolog size 0, PerfScore 1.00, instruction count 1, allocated bytes for code 1 (MethodHash=26ec1f51) for method Microsoft.Extensions.Logging.Abstractions.NullLoggerTest:IsEnabled_AlwaysFalse():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+38.46%</span>) : 241865.dasm - System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateReferencedCategories_NullCategory_ThrowsArgumentNullException>b__11_0():System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rcx         single-def "argument with side effect"
+;* V02 tmp1         [V02,T00] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
 ;
 ; Lcl frame size = 0
 
@@ -19,14 +19,14 @@ G_M19554_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M19554_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      rcx, rcx
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rcx]
+       mov      rax, qword ptr [0x0000]
        mov      rax, qword ptr [rax+0x48]
-						;; size=9 bbWeight=1 PerfScore 4.25
+						;; size=14 bbWeight=1 PerfScore 4.25
 G_M19554_IG03:        ; bbWeight=1, epilog, nogc, extend
        tail.jmp [rax+0x38]<unknown method>
 						;; size=4 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 13, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 13 (MethodHash=1e77b39d) for method System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateReferencedCategories_NullCategory_ThrowsArgumentNullException>b__11_0():System.Object:this (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 18 (MethodHash=1e77b39d) for method System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateReferencedCategories_NullCategory_ThrowsArgumentNullException>b__11_0():System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+38.46%</span>) : 242041.dasm - System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateInlineCategories_NullCategory_ThrowsArgumentNullException>b__9_0():System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rcx         single-def "argument with side effect"
+;* V02 tmp1         [V02,T00] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
 ;
 ; Lcl frame size = 0
 
@@ -19,14 +19,14 @@ G_M41021_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M41021_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      rcx, rcx
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rcx]
+       mov      rax, qword ptr [0x0000]
        mov      rax, qword ptr [rax+0x48]
-						;; size=9 bbWeight=1 PerfScore 4.25
+						;; size=14 bbWeight=1 PerfScore 4.25
 G_M41021_IG03:        ; bbWeight=1, epilog, nogc, extend
        tail.jmp [rax+0x30]<unknown method>
 						;; size=4 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 13, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 13 (MethodHash=66cd5fc2) for method System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateInlineCategories_NullCategory_ThrowsArgumentNullException>b__9_0():System.Object:this (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 18 (MethodHash=66cd5fc2) for method System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateInlineCategories_NullCategory_ThrowsArgumentNullException>b__9_0():System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+45</span> (<span style="color:red">+48.39%</span>) : 194855.dasm - System.Runtime.Caching.CacheExpires:UtcCalcExpiresBucket(System.DateTime):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -13,27 +13,38 @@
 ;* V02 loc1         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )    long  ->  zero-ref    "impAppendStmt"
-;  V05 tmp2         [V05,T02] (  2,  2   )    long  ->  rcx         single-def "field V00._dateData (fldOffset=0x0)" P-INDEP
+;  V05 tmp2         [V05,T05] (  2,  2   )    long  ->  rcx         single-def "field V00._dateData (fldOffset=0x0)" P-INDEP
 ;  V06 tmp3         [V06,T00] (  4,  8   )    long  ->  rcx         "fgMakeTemp is creating a new local variable"
-;  V07 rat0         [V07,T01] (  3,  6   )    long  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V07 rat0         [V07,T01] (  3,  6   )    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V08 rat1         [V08,T02] (  3,  6   )    long  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V09 rat2         [V09,T03] (  3,  6   )    long  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V10 rat3         [V10,T04] (  3,  6   )    long  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 0
 
 G_M38161_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M38161_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E
-       and      rax, rcx
-       mov      rcx, 0xD1FFAB1E      ; static handle
-       ; byrRegs +[rcx]
-       cqo      
-       idiv     rdx:rax, qword ptr [rcx]
-       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      r8, 0xD1FFAB1E
+       and      rcx, r8
+       mov      rdx, 0xD1FFAB1E
        mov      rax, rdx
-       cqo      
-       idiv     rdx:rax, qword ptr [rcx]
-       lea      rcx, [rax+0x01]
-       ; byrRegs -[rcx]
+       imul     rdx:rax, rcx
+       mov      rax, rdx
+       shr      rax, 63
+       sar      rdx, 27
+       add      rax, rdx
+       mov      rdx, 0xD1FFAB1E
+       imul     rax, rdx
+       mov      rdx, rcx
+       sub      rdx, rax
+       mov      rcx, 0xD1FFAB1E
+       mov      rax, rcx
+       imul     rdx:rax, rdx
+       mov      rax, rdx
+       shr      rax, 63
+       sar      rdx, 26
+       lea      rcx, [rdx+rax+0x01]
        mov      rdx, 0xD1FFAB1E
        mov      rax, rdx
        imul     rdx:rax, rcx
@@ -45,12 +56,12 @@ G_M38161_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        imul     rax, rax, 30
        sub      rcx, rax
        mov      eax, ecx
-						;; size=92 bbWeight=1 PerfScore 146.50
+						;; size=137 bbWeight=1 PerfScore 21.75
 G_M38161_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 93, prolog size 0, PerfScore 147.50, instruction count 22, allocated bytes for code 93 (MethodHash=1c156aee) for method System.Runtime.Caching.CacheExpires:UtcCalcExpiresBucket(System.DateTime):int (FullOpts)
+; Total bytes of code 138, prolog size 0, PerfScore 22.75, instruction count 32, allocated bytes for code 138 (MethodHash=1c156aee) for method System.Runtime.Caching.CacheExpires:UtcCalcExpiresBucket(System.DateTime):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-78.57%</span>) : 20421.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,24 +10,20 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  2,  2   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
+;* V02 tmp1         [V02,T00] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <Microsoft.CodeAnalysis.RealParser+FloatUnion>
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M27674_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M27674_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      eax, eax
-       mov      dword ptr [rsp], eax
-       mov      eax, dword ptr [rsp]
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M27674_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 1, PerfScore 4.50, instruction count 6, allocated bytes for code 14 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
+; Total bytes of code 3, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 3 (MethodHash=62ff93e5) for method Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -35,9 +31,8 @@ Unwind Info:
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
<summary><span style="color:green">-24</span> (<span style="color:green">-37.50%</span>) : 26050.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)</summary>
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
-;  V10 tmp7         [V10,T01] (  5, 14   )     int  ->  rdx         "Inline stloc first use temp"
-;* V11 tmp8         [V11,T08] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12,T00] (  7, 16   )     int  ->  registers   "field V01._index (fldOffset=0x8)" P-INDEP
+;  V10 tmp7         [V10,T02] (  2,  8   )     int  ->  rdx         "Inline stloc first use temp"
+;* V11 tmp8         [V11,T07] (  0,  0   )     ref  ->  zero-ref    single-def "field V01._array (fldOffset=0x0)" P-INDEP
+;  V12 tmp9         [V12,T00] (  4, 13   )     int  ->  rdx         "field V01._index (fldOffset=0x8)" P-INDEP
 ;  V13 tmp10        [V13,T05] (  2,  2   )     ref  ->  rax         single-def "field V06.array (fldOffset=0x0)" P-INDEP
 ;* V14 tmp11        [V14,T06] (  0,  0   )     ref  ->  zero-ref    single-def "field V07._array (fldOffset=0x0)" P-INDEP
-;  V15 tmp12        [V15,T07] (  2,  2   )     int  ->  rdx         single-def "field V07._index (fldOffset=0x8)" P-INDEP
-;  V16 cse0         [V16,T03] (  4, 10   )     int  ->  rax         "CSE - aggressive"
+;* V15 tmp12        [V15,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x8)" P-INDEP
+;  V16 cse0         [V16,T04] (  3,  6   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -37,25 +37,20 @@ G_M56839_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; gcrRegs +[rax]
        mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
-       mov      edx, -1
-       inc      edx
-       mov      r8d, edx
-       cmp      eax, r8d
+       xor      edx, edx
+       test     eax, eax
        jle      SHORT G_M56839_IG04
-						;; size=22 bbWeight=1 PerfScore 6.00
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
@@ -64,15 +59,8 @@ G_M56839_IG05:        ; bbWeight=1, epilog, nogc, extend
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
 
-; Total bytes of code 64, prolog size 4, PerfScore 45.50, instruction count 22, allocated bytes for code 64 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
+; Total bytes of code 40, prolog size 4, PerfScore 38.00, instruction count 15, allocated bytes for code 40 (MethodHash=893d21f8) for method Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis+LocalScope:Dispose():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-46</span> (<span style="color:green">-35.94%</span>) : 20661.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow:AdvanceIfMatches(System.String):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,15 +8,15 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  6,  9.96)     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow>
-;  V01 arg1         [V01,T02] (  8,  8.04)     ref  ->  rsi         class-hnd single-def <System.String>
-;  V02 loc0         [V02,T03] (  5,  7.98)     int  ->  rdi         single-def
-;  V03 loc1         [V03,T00] ( 13, 22.04)     int  ->  rbp        
+;  V00 this         [V00,T01] (  5,  9.92)     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow>
+;  V01 arg1         [V01,T02] (  5,  7.46)     ref  ->  rsi         class-hnd single-def <System.String>
+;  V02 loc0         [V02,T03] (  4,  7.94)     int  ->  rdi         single-def
+;  V03 loc1         [V03,T00] (  6, 20.80)     int  ->  rbp        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 40
 
-G_M24588_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M24588_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
        push     rbp
@@ -30,14 +30,12 @@ G_M24588_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M24588_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      edi, dword ptr [rsi+0x08]
        xor      ebp, ebp
-       cmp      ebp, edi
-       jge      SHORT G_M24588_IG07
+       test     edi, edi
+       jle      SHORT G_M24588_IG05
 						;; size=9 bbWeight=1 PerfScore 3.50
-G_M24588_IG03:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       test     rsi, rsi
-       je       SHORT G_M24588_IG06
+G_M24588_IG03:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        mov      ecx, dword ptr [rsi+0x08]
-						;; size=8 bbWeight=0.50 PerfScore 1.62
+						;; size=3 bbWeight=0.50 PerfScore 1.00
 G_M24588_IG04:        ; bbWeight=3.96, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, rbx
        ; gcrRegs +[rcx]
@@ -48,39 +46,17 @@ G_M24588_IG04:        ; bbWeight=3.96, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000
        mov      ecx, ebp
        movzx    rcx, word  ptr [rsi+2*rcx+0x0C]
        cmp      eax, ecx
-       jne      SHORT G_M24588_IG09
+       jne      SHORT G_M24588_IG07
        inc      ebp
        cmp      ebp, edi
        jl       SHORT G_M24588_IG04
 						;; size=28 bbWeight=3.96 PerfScore 33.66
-G_M24588_IG05:        ; bbWeight=1.98, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rsi]
-       jmp      SHORT G_M24588_IG07
-						;; size=2 bbWeight=1.98 PerfScore 3.96
-G_M24588_IG06:        ; bbWeight=0.04, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rsi]
-       mov      rcx, rbx
-       ; gcrRegs +[rcx]
-       mov      edx, ebp
-       call     [Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow:PeekChar(int):ushort:this]
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
-       cmp      ebp, dword ptr [rsi+0x08]
-       jae      SHORT G_M24588_IG11
-       mov      ecx, ebp
-       movzx    rcx, word  ptr [rsi+2*rcx+0x0C]
-       cmp      eax, ecx
-       jne      SHORT G_M24588_IG09
-       inc      ebp
-       cmp      ebp, edi
-       jl       SHORT G_M24588_IG06
-						;; size=33 bbWeight=0.04 PerfScore 0.50
-G_M24588_IG07:        ; bbWeight=1.98, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M24588_IG05:        ; bbWeight=1.98, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rsi]
        add      dword ptr [rbx+0x24], edi
        mov      eax, 1
 						;; size=8 bbWeight=1.98 PerfScore 6.43
-G_M24588_IG08:        ; bbWeight=1.98, epilog, nogc, extend
+G_M24588_IG06:        ; bbWeight=1.98, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rbp
@@ -88,11 +64,11 @@ G_M24588_IG08:        ; bbWeight=1.98, epilog, nogc, extend
        pop      rdi
        ret      
 						;; size=9 bbWeight=1.98 PerfScore 6.44
-G_M24588_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M24588_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rbx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M24588_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+G_M24588_IG08:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rbp
@@ -100,13 +76,8 @@ G_M24588_IG10:        ; bbWeight=0.50, epilog, nogc, extend
        pop      rdi
        ret      
 						;; size=9 bbWeight=0.50 PerfScore 1.62
-G_M24588_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       call     CORINFO_HELP_RNGCHKFAIL
-       ; gcr arg pop 0
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 128, prolog size 8, PerfScore 62.61, instruction count 54, allocated bytes for code 128 (MethodHash=d0dc9ff3) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow:AdvanceIfMatches(System.String):ubyte:this (FullOpts)
+; Total bytes of code 82, prolog size 8, PerfScore 57.53, instruction count 37, allocated bytes for code 82 (MethodHash=d0dc9ff3) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow:AdvanceIfMatches(System.String):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+3</span> (<span style="color:red">+14.29%</span>) : 29752.dasm - Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,25 +10,24 @@
 ;
 ;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V01 tmp1         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CodeGen.LocalDebugId>
-;* V02 tmp2         [V02,T02] (  0,  0   )     int  ->  zero-ref    "field V01.SyntaxOffset (fldOffset=0x0)" P-INDEP
-;  V03 tmp3         [V03,T00] (  3,  3   )     int  ->  rax         "field V01.Ordinal (fldOffset=0x4)" P-INDEP
-;  V04 cse0         [V04,T01] (  3,  3   )    long  ->  rcx         "CSE - aggressive"
+;* V02 tmp2         [V02,T01] (  0,  0   )     int  ->  zero-ref    "field V01.SyntaxOffset (fldOffset=0x0)" P-INDEP
+;* V03 tmp3         [V03,T02] (  0,  0   )     int  ->  zero-ref    "field V01.Ordinal (fldOffset=0x4)" P-INDEP
+;  V04 cse0         [V04,T00] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M2835_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M2835_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, -1
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      dword ptr [rcx], eax
-       mov      dword ptr [rcx+0x04], eax
-						;; size=20 bbWeight=1 PerfScore 2.50
+       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+       mov      dword ptr [rax], -1
+       mov      dword ptr [rax+0x04], -1
+						;; size=23 bbWeight=1 PerfScore 2.25
 G_M2835_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 21, prolog size 0, PerfScore 3.50, instruction count 5, allocated bytes for code 21 (MethodHash=4dbaf4ec) for method Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)
+; Total bytes of code 24, prolog size 0, PerfScore 3.25, instruction count 4, allocated bytes for code 24 (MethodHash=4dbaf4ec) for method Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+41.67%</span>) : 1216.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Cylinder():BepuPhysics.Collidables.CylinderWide:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -13,9 +13,9 @@
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
-;* V06 tmp3         [V06,T03] (  0,  0   )  simd32  ->  zero-ref    "field V02.Radius (fldOffset=0x0)" P-INDEP
-;  V07 tmp4         [V07,T01] (  3,  3   )  simd32  ->  mm0         "field V02.HalfLength (fldOffset=0x20)" P-INDEP
-;  V08 cse0         [V08,T02] (  2,  2   )  simd32  ->  mm0         "CSE - aggressive"
+;* V06 tmp3         [V06,T02] (  0,  0   )  simd32  ->  zero-ref    "field V02.Radius (fldOffset=0x0)" P-INDEP
+;* V07 tmp4         [V07,T03] (  0,  0   )  simd32  ->  zero-ref    "field V02.HalfLength (fldOffset=0x20)" P-INDEP
+;* V08 cse0         [V08,T01] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -23,20 +23,21 @@ G_M44635_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M44635_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovups  ymm0, ymmword ptr [reloc @RWD00]
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x20], ymm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=20 bbWeight=1 PerfScore 8.25
+						;; size=30 bbWeight=1 PerfScore 12.25
 G_M44635_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.00
-RWD00  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+RWD00  	dq	3F8000003F800000h, 3F8000003F800000h
 
 
-; Total bytes of code 24, prolog size 0, PerfScore 10.25, instruction count 6, allocated bytes for code 24 (MethodHash=484851a4) for method DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Cylinder():BepuPhysics.Collidables.CylinderWide:this (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 14.25, instruction count 7, allocated bytes for code 34 (MethodHash=484851a4) for method DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Cylinder():BepuPhysics.Collidables.CylinderWide:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+19</span> (<span style="color:red">+65.52%</span>) : 1214.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Box():BepuPhysics.Collidables.BoxWide:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,10 +14,10 @@
 ;* V04 tmp1         [V04    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
 ;* V05 tmp2         [V05    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
 ;* V06 tmp3         [V06    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[float]>
-;* V07 tmp4         [V07,T03] (  0,  0   )  simd32  ->  zero-ref    "field V02.HalfWidth (fldOffset=0x0)" P-INDEP
-;* V08 tmp5         [V08,T04] (  0,  0   )  simd32  ->  zero-ref    "field V02.HalfHeight (fldOffset=0x20)" P-INDEP
-;  V09 tmp6         [V09,T01] (  4,  4   )  simd32  ->  mm0         "field V02.HalfLength (fldOffset=0x40)" P-INDEP
-;  V10 cse0         [V10,T02] (  2,  2   )  simd32  ->  mm0         "CSE - aggressive"
+;* V07 tmp4         [V07,T02] (  0,  0   )  simd32  ->  zero-ref    "field V02.HalfWidth (fldOffset=0x0)" P-INDEP
+;* V08 tmp5         [V08,T03] (  0,  0   )  simd32  ->  zero-ref    "field V02.HalfHeight (fldOffset=0x20)" P-INDEP
+;* V09 tmp6         [V09,T04] (  0,  0   )  simd32  ->  zero-ref    "field V02.HalfLength (fldOffset=0x40)" P-INDEP
+;* V10 cse0         [V10,T01] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -25,21 +25,23 @@ G_M5339_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M5339_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovups  ymm0, ymmword ptr [reloc @RWD00]
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x20], ymm0
+       vbroadcasti128 ymm0, xmmword ptr [reloc @RWD00]
        vmovups  ymmword ptr [rdx+0x40], ymm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=25 bbWeight=1 PerfScore 10.25
+						;; size=44 bbWeight=1 PerfScore 18.25
 G_M5339_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.00
-RWD00  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+RWD00  	dq	3F8000003F800000h, 3F8000003F800000h
 
 
-; Total bytes of code 29, prolog size 0, PerfScore 12.25, instruction count 7, allocated bytes for code 29 (MethodHash=dd38eb24) for method DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Box():BepuPhysics.Collidables.BoxWide:this (FullOpts)
+; Total bytes of code 48, prolog size 0, PerfScore 20.25, instruction count 9, allocated bytes for code 48 (MethodHash=dd38eb24) for method DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Box():BepuPhysics.Collidables.BoxWide:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-26</span> (<span style="color:green">-68.42%</span>) : 29913.dasm - System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,24 +22,16 @@ G_M36138_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M36138_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       xor      eax, eax
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-       mov      eax, 1
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-       mov      eax, 2
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-       mov      eax, 3
-       cdqe     
-       mov      dword ptr [rcx+4*rax], edx
-						;; size=37 bbWeight=1 PerfScore 6.00
+       mov      dword ptr [rcx], edx
+       mov      dword ptr [rcx+0x04], edx
+       mov      dword ptr [rcx+0x08], edx
+       mov      dword ptr [rcx+0x0C], edx
+						;; size=11 bbWeight=1 PerfScore 4.00
 G_M36138_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 38, prolog size 0, PerfScore 7.00, instruction count 13, allocated bytes for code 38 (MethodHash=62e772d5) for method System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)
+; Total bytes of code 12, prolog size 0, PerfScore 5.00, instruction count 5, allocated bytes for code 12 (MethodHash=62e772d5) for method System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-66.67%</span>) : 15653.dasm - Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -15,17 +15,13 @@
 G_M10122_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M10122_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       lzcnt    rax, rax
-       cmp      rax, 64
-       sete     al
-       movzx    rax, al
-						;; size=17 bbWeight=1 PerfScore 3.75
+       mov      eax, 1
+						;; size=5 bbWeight=1 PerfScore 0.25
 G_M10122_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 18, prolog size 0, PerfScore 4.75, instruction count 6, allocated bytes for code 18 (MethodHash=275bd875) for method Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
+; Total bytes of code 6, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 6 (MethodHash=275bd875) for method Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-66.67%</span>) : 23274.dasm - Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -15,17 +15,13 @@
 G_M10122_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M10122_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       lzcnt    rax, rax
-       cmp      rax, 64
-       sete     al
-       movzx    rax, al
-						;; size=17 bbWeight=1 PerfScore 3.75
+       mov      eax, 1
+						;; size=5 bbWeight=1 PerfScore 0.25
 G_M10122_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 18, prolog size 0, PerfScore 4.75, instruction count 6, allocated bytes for code 18 (MethodHash=275bd875) for method Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
+; Total bytes of code 6, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 6 (MethodHash=275bd875) for method Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+7.97%</span>) : 31759.dasm - ReflectionTest+TestLinqInvocation:Run() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,14 +10,14 @@
 ;* V00 loc0         [V00    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;  V01 loc1         [V01,T07] (  3,  3   )     ref  ->  rbx         class-hnd single-def <System.Linq.Expressions.ParameterExpression>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def "dup spill" <System.Linq.Expressions.ParameterExpression[]>
+;  V03 tmp1         [V03,T00] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def "dup spill" <System.Linq.Expressions.ParameterExpression[]>
 ;  V04 tmp2         [V04,T04] (  2,  4   )     ref  ->  rsi         class-hnd single-def "impAppendStmt" <System.Linq.Expressions.InvocationExpression>
 ;  V05 tmp3         [V05,T05] (  2,  4   )     ref  ->  rdx         class-hnd exact single-def "dup spill" <<unknown class>>
-;  V06 tmp4         [V06,T02] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <<unknown class>>
+;  V06 tmp4         [V06,T01] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "impAppendStmt" <<unknown class>>
 ;* V07 tmp5         [V07    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V08 tmp6         [V08,T06] (  4,  3.50)     ref  ->  rdx        
 ;  V09 tmp7         [V09,T03] (  4,  4   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
-;  V10 tmp8         [V10,T00] (  8, 13   )     ref  ->  rbx         class-hnd "Inlining Arg" <System.Type>
+;  V10 tmp8         [V10,T02] (  3,  5   )     ref  ->  rbx         class-hnd "Inlining Arg" <System.Type>
 ;  V11 tmp9         [V11,T08] (  3,  3   )   ubyte  ->  rsi         single-def "Inline stloc first use temp"
 ;
 ; Lcl frame size = 48
@@ -31,32 +31,33 @@ G_M10398_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M10398_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        lea      rbx, gword ptr [(reloc)]
        ; gcrRegs +[rbx]
-       mov      rcx, rbx
+       lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
        mov      edx, 1
        call     System.Linq.Expressions.Expression:Validate(System.Type,ubyte)
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      rcx, rbx
+       lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rbx]
+       mov      rax, qword ptr [(reloc)]
        call     [rax+0xC0]<unknown method>
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        mov      esi, eax
        test     esi, esi
        je       SHORT G_M10398_IG04
-						;; size=38 bbWeight=1 PerfScore 8.75
-G_M10398_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       mov      rcx, rbx
+						;; size=50 bbWeight=1 PerfScore 9.25
+G_M10398_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rbx]
+       lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rbx]
+       mov      rax, qword ptr [(reloc)]
        call     [rax+0x120]<unknown method>
-       ; gcrRegs -[rcx rbx] +[rax]
+       ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        mov      rbx, rax
        ; gcrRegs +[rbx]
-						;; size=15 bbWeight=0.50 PerfScore 2.75
+						;; size=23 bbWeight=0.50 PerfScore 2.88
 G_M10398_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        mov      rcx, rbx
@@ -155,7 +156,7 @@ G_M10398_IG07:        ; bbWeight=1, epilog, nogc, extend
        tail.jmp [rax+0x20]<unknown method>
 						;; size=11 bbWeight=1 PerfScore 3.75
 
-; Total bytes of code 251, prolog size 7, PerfScore 45.38, instruction count 66, allocated bytes for code 251 (MethodHash=008fd761) for method ReflectionTest+TestLinqInvocation:Run() (FullOpts)
+; Total bytes of code 271, prolog size 7, PerfScore 46.00, instruction count 66, allocated bytes for code 271 (MethodHash=008fd761) for method ReflectionTest+TestLinqInvocation:Run() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+9.33%</span>) : 26699.dasm - System.Enum:TryFormatUnconstrained[ubyte](ubyte,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,7 +11,7 @@
 ;  V01 arg1         [V01,T01] (  4,  6   )   byref  ->  rax         single-def
 ;  V02 arg2         [V02,T02] (  4,  3   )   byref  ->  r10         single-def
 ;  V03 arg3         [V03,T00] (  4,  7   )   byref  ->   r9         ld-addr-op single-def
-;  V04 loc0         [V04,T04] (  3,  2   )     ref  ->  rcx         class-hnd exact single-def <<unknown class>>
+;* V04 loc0         [V04,T04] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
 ;* V05 loc1         [V05,T05] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V07 tmp1         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Single-def Box Helper" <<unknown class>>
@@ -35,14 +35,14 @@ G_M64589_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=14 bbWeight=1 PerfScore 1.75
 G_M64589_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref, isz
        ; byrRegs +[r9]
-       lea      rcx, gword ptr [(reloc)]
-       ; gcrRegs +[rcx]
        cmp      dword ptr [r9+0x08], 0
        jne      SHORT G_M64589_IG04
-						;; size=14 bbWeight=1 PerfScore 4.50
-G_M64589_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0401 {rax r10}, byref, isz
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M64589_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
        ; byrRegs -[r9]
        movzx    rdx, byte  ptr [rsp+0x30]
+       lea      rcx, gword ptr [(reloc)]
+       ; gcrRegs +[rcx]
        mov      r8, rax
        ; byrRegs +[r8]
        mov      r9, r10
@@ -52,13 +52,14 @@ G_M64589_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0401 {rax
        ; byrRegs -[rax r8-r10]
        ; gcr arg pop 0
        jmp      SHORT G_M64589_IG05
-						;; size=18 bbWeight=0.50 PerfScore 2.25
-G_M64589_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0601 {rax r9 r10}, byref
-       ; gcrRegs +[rcx]
+						;; size=25 bbWeight=0.50 PerfScore 2.50
+G_M64589_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref
        ; byrRegs +[rax r9-r10]
        mov      bword ptr [rsp+0x20], r9
        ; byr arg write
        movzx    rdx, byte  ptr [rsp+0x30]
+       lea      rcx, gword ptr [(reloc)]
+       ; gcrRegs +[rcx]
        mov      r8, rax
        ; byrRegs +[r8]
        mov      r9, r10
@@ -66,7 +67,7 @@ G_M64589_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0601 {rax
        ; gcrRegs -[rcx]
        ; byrRegs -[rax r8-r10]
        ; gcr arg pop 0
-						;; size=21 bbWeight=0.50 PerfScore 1.75
+						;; size=28 bbWeight=0.50 PerfScore 2.00
 G_M64589_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
@@ -75,7 +76,7 @@ G_M64589_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 75, prolog size 4, PerfScore 11.75, instruction count 20, allocated bytes for code 75 (MethodHash=c26b03b2) for method System.Enum:TryFormatUnconstrained[ubyte](ubyte,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
+; Total bytes of code 82, prolog size 4, PerfScore 11.75, instruction count 21, allocated bytes for code 82 (MethodHash=c26b03b2) for method System.Enum:TryFormatUnconstrained[ubyte](ubyte,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+9.59%</span>) : 26705.dasm - System.Enum:TryFormatUnconstrained[int](int,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,7 +11,7 @@
 ;  V01 arg1         [V01,T01] (  4,  6   )   byref  ->  rax         single-def
 ;  V02 arg2         [V02,T02] (  4,  3   )   byref  ->  r10         single-def
 ;  V03 arg3         [V03,T00] (  4,  7   )   byref  ->   r9         ld-addr-op single-def
-;  V04 loc0         [V04,T04] (  3,  2   )     ref  ->  rcx         class-hnd exact single-def <<unknown class>>
+;* V04 loc0         [V04,T04] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
 ;* V05 loc1         [V05,T05] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V07 tmp1         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Single-def Box Helper" <<unknown class>>
@@ -35,13 +35,13 @@ G_M41677_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=14 bbWeight=1 PerfScore 1.75
 G_M41677_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref, isz
        ; byrRegs +[r9]
-       lea      rcx, gword ptr [(reloc)]
-       ; gcrRegs +[rcx]
        cmp      dword ptr [r9+0x08], 0
        jne      SHORT G_M41677_IG04
-						;; size=14 bbWeight=1 PerfScore 4.50
-G_M41677_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0401 {rax r10}, byref, isz
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M41677_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
        ; byrRegs -[r9]
+       lea      rcx, gword ptr [(reloc)]
+       ; gcrRegs +[rcx]
        mov      edx, dword ptr [rsp+0x30]
        mov      r8, rax
        ; byrRegs +[r8]
@@ -52,12 +52,13 @@ G_M41677_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0401 {rax
        ; byrRegs -[rax r8-r10]
        ; gcr arg pop 0
        jmp      SHORT G_M41677_IG05
-						;; size=17 bbWeight=0.50 PerfScore 2.25
-G_M41677_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0601 {rax r9 r10}, byref
-       ; gcrRegs +[rcx]
+						;; size=24 bbWeight=0.50 PerfScore 2.50
+G_M41677_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref
        ; byrRegs +[rax r9-r10]
        mov      bword ptr [rsp+0x20], r9
        ; byr arg write
+       lea      rcx, gword ptr [(reloc)]
+       ; gcrRegs +[rcx]
        mov      edx, dword ptr [rsp+0x30]
        mov      r8, rax
        ; byrRegs +[r8]
@@ -66,7 +67,7 @@ G_M41677_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0601 {rax
        ; gcrRegs -[rcx]
        ; byrRegs -[rax r8-r10]
        ; gcr arg pop 0
-						;; size=20 bbWeight=0.50 PerfScore 1.75
+						;; size=27 bbWeight=0.50 PerfScore 2.00
 G_M41677_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
@@ -75,7 +76,7 @@ G_M41677_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 73, prolog size 4, PerfScore 11.75, instruction count 20, allocated bytes for code 73 (MethodHash=c8c45d32) for method System.Enum:TryFormatUnconstrained[int](int,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
+; Total bytes of code 80, prolog size 4, PerfScore 11.75, instruction count 21, allocated bytes for code 80 (MethodHash=c8c45d32) for method System.Enum:TryFormatUnconstrained[int](int,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
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
|benchmarks.run.windows.x64.checked.mch|11,673|<span style="color:green">10,071</span>|<span style="color:red">495</span>|<span style="color:blue">1,107</span>|<span style="color:green">-239,644</span>|<span style="color:red">+4,650</span>|<span style="color:green">-1.7006%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|20,009|<span style="color:green">18,729</span>|<span style="color:red">411</span>|<span style="color:blue">869</span>|<span style="color:green">-416,725</span>|<span style="color:red">+3,299</span>|<span style="color:green">-2.5182%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|4,224|<span style="color:green">3,916</span>|<span style="color:red">85</span>|<span style="color:blue">223</span>|<span style="color:green">-82,729</span>|<span style="color:red">+513</span>|<span style="color:green">-1.1561%</span>|
|coreclr_tests.run.windows.x64.checked.mch|96,612|<span style="color:green">87,093</span>|<span style="color:red">6,803</span>|<span style="color:blue">2,716</span>|<span style="color:green">-2,542,467</span>|<span style="color:red">+31,087</span>|<span style="color:green">-4.3976%</span>|
|libraries.crossgen2.windows.x64.checked.mch|43,975|<span style="color:green">39,704</span>|<span style="color:red">960</span>|<span style="color:blue">3,311</span>|<span style="color:green">-689,397</span>|<span style="color:red">+2,200</span>|<span style="color:green">-1.1465%</span>|
|libraries.pmi.windows.x64.checked.mch|53,251|<span style="color:green">46,990</span>|<span style="color:red">1,440</span>|<span style="color:blue">4,821</span>|<span style="color:green">-892,746</span>|<span style="color:red">+5,076</span>|<span style="color:green">-0.9815%</span>|
|libraries_tests.run.windows.x64.Release.mch|87,768|<span style="color:green">80,871</span>|<span style="color:red">2,514</span>|<span style="color:blue">4,383</span>|<span style="color:green">-2,188,517</span>|<span style="color:red">+19,531</span>|<span style="color:green">-1.9067%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|111,666|<span style="color:green">103,557</span>|<span style="color:red">3,721</span>|<span style="color:blue">4,388</span>|<span style="color:green">-2,600,511</span>|<span style="color:red">+31,749</span>|<span style="color:green">-2.1724%</span>|
|realworld.run.windows.x64.checked.mch|12,483|<span style="color:green">11,426</span>|<span style="color:red">305</span>|<span style="color:blue">752</span>|<span style="color:green">-212,236</span>|<span style="color:red">+3,014</span>|<span style="color:green">-4.5315%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,783|<span style="color:green">4,872</span>|<span style="color:red">375</span>|<span style="color:blue">536</span>|<span style="color:green">-79,940</span>|<span style="color:red">+2,202</span>|<span style="color:green">-1.2520%</span>|
||447,444|<span style="color:green">407,229</span>|<span style="color:red">17,109</span>|<span style="color:blue">23,106</span>|<span style="color:green">-9,944,912</span>|<span style="color:red">+103,321</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,684|4|35,680|377 (1.04%)|188 (0.52%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,756|49,607|52,149|88 (0.09%)|33 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|54,985|37,307|17,678|49 (0.09%)|36 (0.07%)|
|coreclr_tests.run.windows.x64.checked.mch|579,880|347,882|231,998|4,166 (0.71%)|2,567 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|274,692|15|274,677|1,078 (0.39%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|311,557|6|311,551|2,582 (0.82%)|1,206 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|695,363|498,513|196,850|4,419 (0.63%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|317,087|21,946|295,141|3,808 (1.19%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,395|3|36,392|449 (1.22%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,237|11|32,226|339 (1.04%)|41 (0.13%)|
||2,439,636|955,294|1,484,342|17,355 (0.71%)|7,147 (0.29%)|


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

Total bytes of base: 11581162 (overridden on cmd)
Total bytes of diff: 11346168 (overridden on cmd)
Total bytes of delta: -234994 (-2.03 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1007 : 13108.dasm (17.83% of base)
        1007 : 751.dasm (17.83% of base)
          99 : 20907.dasm (15.62% of base)
          69 : 36061.dasm (2.27% of base)
          60 : 22207.dasm (1.72% of base)
          51 : 18568.dasm (3.49% of base)
          51 : 3839.dasm (3.49% of base)
          47 : 32074.dasm (3.69% of base)
          47 : 36062.dasm (3.78% of base)
          47 : 36064.dasm (3.78% of base)
          42 : 6302.dasm (3.52% of base)
          42 : 14673.dasm (3.52% of base)
          41 : 32073.dasm (1.57% of base)
          32 : 22290.dasm (28.83% of base)
          32 : 21219.dasm (25.20% of base)
          32 : 11883.dasm (18.93% of base)
          32 : 35795.dasm (28.83% of base)
          32 : 36031.dasm (24.06% of base)
          32 : 29377.dasm (25.20% of base)
          32 : 11461.dasm (23.53% of base)

Top file improvements (bytes):
       -4000 : 13944.dasm (-23.41% of base)
       -4000 : 4585.dasm (-23.41% of base)
       -3562 : 26005.dasm (-36.74% of base)
       -2680 : 25645.dasm (-14.19% of base)
       -2566 : 19650.dasm (-25.96% of base)
       -1606 : 19649.dasm (-33.71% of base)
       -1452 : 3163.dasm (-6.63% of base)
       -1452 : 17951.dasm (-6.63% of base)
       -1422 : 25725.dasm (-37.99% of base)
       -1204 : 405.dasm (-19.29% of base)
       -1204 : 12762.dasm (-19.29% of base)
       -1058 : 8780.dasm (-3.35% of base)
        -965 : 629.dasm (-40.01% of base)
        -965 : 12986.dasm (-40.01% of base)
        -945 : 13806.dasm (-41.56% of base)
        -945 : 4500.dasm (-41.56% of base)
        -944 : 28284.dasm (-19.31% of base)
        -944 : 30082.dasm (-19.31% of base)
        -926 : 29806.dasm (-21.96% of base)
        -785 : 26060.dasm (-32.51% of base)

83 total files with Code Size differences (51 improved, 32 regressed), 20 unchanged.

Top method regressions (bytes):
        1007 (17.83% of base) : 13108.dasm - System.Reflection.Emit.OpCodes:.cctor() (FullOpts)
        1007 (17.83% of base) : 751.dasm - System.Reflection.Emit.OpCodes:.cctor() (FullOpts)
          99 (15.62% of base) : 20907.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (FullOpts)
          69 ( 2.27% of base) : 36061.dasm - (dynamicClass):ReadMyEventsListerViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          60 ( 1.72% of base) : 22207.dasm - (dynamicClass):ReadCollectionsOfPrimitivesFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          51 ( 3.49% of base) : 18568.dasm - Jil.Deserialize.InlineDeserializer`1[System.__Canon]:ReadNumber(System.Type):this (FullOpts)
          51 ( 3.49% of base) : 3839.dasm - Jil.Deserialize.InlineDeserializer`1[System.__Canon]:ReadNumber(System.Type):this (FullOpts)
          47 ( 3.69% of base) : 32074.dasm - (dynamicClass):ReadArrayOfActiveOrUpcomingEventFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 36062.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 36064.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemTaskFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          42 ( 3.52% of base) : 6302.dasm - System.Security.Cryptography.X509Certificates.ChainPal:.cctor() (FullOpts)
          42 ( 3.52% of base) : 14673.dasm - System.Security.Cryptography.X509Certificates.ChainPal:.cctor() (FullOpts)
          41 ( 1.57% of base) : 32073.dasm - (dynamicClass):ReadIndexViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          32 (28.83% of base) : 22290.dasm - System.Numerics.Tests.Perf_Matrix4x4:AddBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (28.83% of base) : 35795.dasm - System.Numerics.Tests.Perf_Matrix4x4:AddOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (24.06% of base) : 36031.dasm - System.Numerics.Tests.Perf_Matrix4x4:EqualityOperatorBenchmark():ubyte:this (FullOpts)
          32 (23.53% of base) : 11461.dasm - System.Numerics.Tests.Perf_Matrix4x4:InequalityOperatorBenchmark():ubyte:this (FullOpts)
          32 (18.93% of base) : 24347.dasm - System.Numerics.Tests.Perf_Matrix4x4:MultiplyByMatrixBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (18.93% of base) : 11883.dasm - System.Numerics.Tests.Perf_Matrix4x4:MultiplyByMatrixOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (25.20% of base) : 29377.dasm - System.Numerics.Tests.Perf_Matrix4x4:SubtractBenchmark():System.Numerics.Matrix4x4:this (FullOpts)

Top method improvements (bytes):
       -4000 (-23.41% of base) : 13944.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -4000 (-23.41% of base) : 4585.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -3562 (-36.74% of base) : 26005.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -2680 (-14.19% of base) : 25645.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2566 (-25.96% of base) : 19650.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanSpanIntoSpan>g__Vectorized512|232_3[int,System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[int]](byref,byref,byref,ulong) (FullOpts)
       -1606 (-33.71% of base) : 19649.dasm - System.Numerics.Tensors.TensorPrimitives:InvokeSpanSpanIntoSpan[int,System.Numerics.Tensors.TensorPrimitives+DivideOperator`1[int]](System.ReadOnlySpan`1[int],System.ReadOnlySpan`1[int],System.Span`1[int]) (FullOpts)
       -1452 (-6.63% of base) : 3163.dasm - Jil.Options:.cctor() (FullOpts)
       -1452 (-6.63% of base) : 17951.dasm - Jil.Options:.cctor() (FullOpts)
       -1422 (-37.99% of base) : 25725.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForFileAssembly(Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager+AssemblyDataForFile,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref,Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol) (FullOpts)
       -1204 (-19.29% of base) : 405.dasm - System.Diagnostics.FileVersionInfo:GetVersionInfoForCodePage(ulong,System.String):ubyte:this (FullOpts)
       -1204 (-19.29% of base) : 12762.dasm - System.Diagnostics.FileVersionInfo:GetVersionInfoForCodePage(ulong,System.String):ubyte:this (FullOpts)
       -1058 (-3.35% of base) : 8780.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -965 (-40.01% of base) : 629.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -965 (-40.01% of base) : 12986.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -945 (-41.56% of base) : 13806.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -945 (-41.56% of base) : 4500.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -944 (-19.31% of base) : 28284.dasm - System.Memory.Slice`1[ubyte]:MemoryStartSpan():System.Memory`1[ubyte]:this (FullOpts)
        -944 (-19.31% of base) : 30082.dasm - System.Memory.Slice`1[ubyte]:ReadOnlyMemoryStartSpan():System.ReadOnlyMemory`1[ubyte]:this (FullOpts)
        -926 (-21.96% of base) : 29806.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -785 (-32.51% of base) : 26060.dasm - Microsoft.CodeAnalysis.SpecialMembers:.cctor() (FullOpts)

Top method regressions (percentages):
          15 (45.45% of base) : 34824.dasm - HardwareIntrinsics.RayTracer.Surfaces+<>c:<.cctor>b__5_4(HardwareIntrinsics.RayTracer.VectorPacket256):HardwareIntrinsics.RayTracer.VectorPacket256:this (FullOpts)
          32 (28.83% of base) : 22290.dasm - System.Numerics.Tests.Perf_Matrix4x4:AddBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (28.83% of base) : 35795.dasm - System.Numerics.Tests.Perf_Matrix4x4:AddOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (25.20% of base) : 29377.dasm - System.Numerics.Tests.Perf_Matrix4x4:SubtractBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (25.20% of base) : 21219.dasm - System.Numerics.Tests.Perf_Matrix4x4:SubtractOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (24.06% of base) : 36031.dasm - System.Numerics.Tests.Perf_Matrix4x4:EqualityOperatorBenchmark():ubyte:this (FullOpts)
           8 (23.53% of base) : 29763.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateTranslationFromVectorBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          32 (23.53% of base) : 11461.dasm - System.Numerics.Tests.Perf_Matrix4x4:InequalityOperatorBenchmark():ubyte:this (FullOpts)
          20 (21.51% of base) : 19655.dasm - System.Numerics.Tests.Perf_Matrix3x2:AddBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          20 (21.51% of base) : 32685.dasm - System.Numerics.Tests.Perf_Matrix3x2:AddOperatorBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          20 (21.51% of base) : 24896.dasm - System.Numerics.Tests.Perf_Matrix3x2:SubtractBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          20 (21.51% of base) : 10176.dasm - System.Numerics.Tests.Perf_Matrix3x2:SubtractOperatorBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          32 (18.93% of base) : 24347.dasm - System.Numerics.Tests.Perf_Matrix4x4:MultiplyByMatrixBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          32 (18.93% of base) : 11883.dasm - System.Numerics.Tests.Perf_Matrix4x4:MultiplyByMatrixOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          20 (18.02% of base) : 34893.dasm - System.Numerics.Tests.Perf_Matrix3x2:EqualityOperatorBenchmark():ubyte:this (FullOpts)
        1007 (17.83% of base) : 13108.dasm - System.Reflection.Emit.OpCodes:.cctor() (FullOpts)
        1007 (17.83% of base) : 751.dasm - System.Reflection.Emit.OpCodes:.cctor() (FullOpts)
          20 (17.54% of base) : 35454.dasm - System.Numerics.Tests.Perf_Matrix3x2:InequalityOperatorBenchmark():ubyte:this (FullOpts)
          99 (15.62% of base) : 20907.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (FullOpts)
           3 (14.29% of base) : 35569.dasm - BenchmarksGame.ReverseComplement_1+Index:.cctor() (FullOpts)

Top method improvements (percentages):
        -130 (-77.84% of base) : 20628.dasm - System.Tests.Perf_DateTime:.ctor():this (FullOpts)
        -130 (-77.84% of base) : 7971.dasm - System.Tests.Perf_DateTime:.ctor():this (FullOpts)
        -170 (-75.56% of base) : 24404.dasm - System.Numerics.Tests.Perf_Matrix4x4:CreateFromQuaternionBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
         -16 (-72.73% of base) : 32417.dasm - System.Collections.Concurrent.ConcurrentDictionaryTypeProps`1[int]:IsWriteAtomicPrivate():ubyte (FullOpts)
         -56 (-70.89% of base) : 17487.dasm - System.Numerics.Tests.Perf_Matrix4x4:MultiplyByScalarOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
        -136 (-67.66% of base) : 35777.dasm - System.Globalization.HebrewCalendar:.cctor() (FullOpts)
        -184 (-67.15% of base) : 22898.dasm - ProtoBuf.BclHelpers:.cctor() (FullOpts)
         -63 (-66.32% of base) : 32063.dasm - MessagePack.Internal.DateTimeConstants:.cctor() (FullOpts)
        -112 (-65.88% of base) : 5553.dasm - System.Numerics.Tests.Perf_Plane:CreateFromVerticesBenchmark():System.Numerics.Plane:this (FullOpts)
         -69 (-65.09% of base) : 30556.dasm - System.Xml.Tests.Perf_XmlConvert:.ctor():this (FullOpts)
         -47 (-59.49% of base) : 24989.dasm - System.Numerics.Tests.Perf_Matrix4x4:MultiplyByScalarBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
         -47 (-59.49% of base) : 28656.dasm - System.Numerics.Tests.Perf_Matrix4x4:NegateBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
         -47 (-59.49% of base) : 21364.dasm - System.Numerics.Tests.Perf_Matrix4x4:NegationOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
         -32 (-58.18% of base) : 19653.dasm - System.Numerics.Tests.Perf_Matrix4x4:CreateTranslationFromScalarXYZ():System.Numerics.Matrix4x4:this (FullOpts)
        -143 (-54.79% of base) : 21317.dasm - System.Tests.Perf_DateTimeOffset:.ctor():this (FullOpts)
         -52 (-51.49% of base) : 18263.dasm - Sigil.Impl.ExtensionMethods:IsPrefix(System.Reflection.Emit.OpCode):ubyte (FullOpts)
         -52 (-51.49% of base) : 3513.dasm - Sigil.Impl.ExtensionMethods:IsPrefix(System.Reflection.Emit.OpCode):ubyte (FullOpts)
        -169 (-51.37% of base) : 6410.dasm - Benchstone.BenchF.Trap:Test():ubyte:this (FullOpts)
         -32 (-48.48% of base) : 28281.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateScaleFromVectorWithCenterBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
        -190 (-46.80% of base) : 3964.dasm - System.Dynamic.Utils.TypeExtensions:MatchesArgumentTypes(System.Reflection.MethodInfo,System.Type[]):ubyte (FullOpts)

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

Total bytes of base: 35797207 (overridden on cmd)
Total bytes of diff: 35383781 (overridden on cmd)
Total bytes of delta: -413426 (-1.15 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         351 : 54513.dasm (10.32% of base)
         287 : 87014.dasm (7.95% of base)
         130 : 78807.dasm (3.79% of base)
         108 : 86528.dasm (3.31% of base)
          69 : 100994.dasm (2.27% of base)
          55 : 43869.dasm (1.56% of base)
          53 : 88974.dasm (2.70% of base)
          52 : 88976.dasm (2.65% of base)
          47 : 101000.dasm (3.78% of base)
          47 : 100995.dasm (3.78% of base)
          47 : 87544.dasm (3.69% of base)
          44 : 87543.dasm (1.71% of base)
          44 : 73725.dasm (1.26% of base)
          30 : 36014.dasm (5.39% of base)
          30 : 27088.dasm (5.41% of base)
          30 : 7694.dasm (5.41% of base)
          27 : 27089.dasm (5.47% of base)
          27 : 86183.dasm (4.90% of base)
          27 : 81227.dasm (5.09% of base)
          27 : 50188.dasm (4.86% of base)

Top file improvements (bytes):
       -1058 : 26827.dasm (-3.35% of base)
        -922 : 75905.dasm (-21.67% of base)
        -554 : 73162.dasm (-16.18% of base)
        -536 : 75903.dasm (-13.91% of base)
        -473 : 14942.dasm (-1.40% of base)
        -450 : 26246.dasm (-8.71% of base)
        -450 : 48682.dasm (-8.71% of base)
        -450 : 51769.dasm (-8.71% of base)
        -450 : 85466.dasm (-8.71% of base)
        -448 : 55697.dasm (-8.55% of base)
        -448 : 73708.dasm (-8.55% of base)
        -448 : 75811.dasm (-8.55% of base)
        -441 : 49638.dasm (-16.07% of base)
        -441 : 53262.dasm (-16.05% of base)
        -433 : 73148.dasm (-17.85% of base)
        -433 : 73161.dasm (-17.85% of base)
        -417 : 97793.dasm (-16.27% of base)
        -413 : 51903.dasm (-7.68% of base)
        -400 : 71621.dasm (-6.53% of base)
        -391 : 63823.dasm (-35.26% of base)

72 total files with Code Size differences (41 improved, 31 regressed), 20 unchanged.

Top method regressions (bytes):
         351 (10.32% of base) : 54513.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
         287 ( 7.95% of base) : 87014.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
         130 ( 3.79% of base) : 78807.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         108 ( 3.31% of base) : 86528.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
          69 ( 2.27% of base) : 100994.dasm - (dynamicClass):ReadMyEventsListerViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          55 ( 1.56% of base) : 43869.dasm - (dynamicClass):ReadCollectionsOfPrimitivesFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          53 ( 2.70% of base) : 88974.dasm - BenchmarksGame.pidigits:compose_l(int,int,int,int):this (Tier1)
          52 ( 2.65% of base) : 88976.dasm - BenchmarksGame.pidigits:compose_r(int,int,int,int):this (Tier1)
          47 ( 3.69% of base) : 87544.dasm - (dynamicClass):ReadArrayOfActiveOrUpcomingEventFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 100995.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 101000.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemTaskFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          44 ( 1.71% of base) : 87543.dasm - (dynamicClass):ReadIndexViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          44 ( 1.26% of base) : 73725.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          30 ( 5.39% of base) : 36014.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          30 ( 5.41% of base) : 27088.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          30 ( 5.41% of base) : 7694.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 4.90% of base) : 86183.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 4.86% of base) : 50188.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 4.91% of base) : 78822.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 5.47% of base) : 27089.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)

Top method improvements (bytes):
       -1058 (-3.35% of base) : 26827.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -922 (-21.67% of base) : 75905.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -554 (-16.18% of base) : 73162.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1)
        -536 (-13.91% of base) : 75903.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -473 (-1.40% of base) : 14942.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -450 (-8.71% of base) : 26246.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -450 (-8.71% of base) : 48682.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -450 (-8.71% of base) : 51769.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -450 (-8.71% of base) : 85466.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -448 (-8.55% of base) : 55697.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -448 (-8.55% of base) : 73708.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -448 (-8.55% of base) : 75811.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -441 (-16.07% of base) : 49638.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -441 (-16.05% of base) : 53262.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
        -433 (-17.85% of base) : 73148.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -433 (-17.85% of base) : 73161.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -417 (-16.27% of base) : 97793.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[System.__Canon]:Transform[ulong](System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.__Canon],System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Func`3[System.__Canon,System.__Canon,ulong]):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
        -413 (-7.68% of base) : 51903.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -400 (-6.53% of base) : 71621.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:Analyze(byref,Microsoft.CodeAnalysis.DiagnosticBag):this (Tier1)
        -391 (-35.26% of base) : 63823.dasm - System.Reflection.MethodInvokerCommon:Initialize(System.RuntimeType[],byref,byref,byref) (Tier1)

Top method regressions (percentages):
         351 (10.32% of base) : 54513.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
         287 ( 7.95% of base) : 87014.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
          23 ( 6.34% of base) : 76376.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          23 ( 6.28% of base) : 99201.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          23 ( 6.28% of base) : 19614.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          16 ( 5.71% of base) : 90138.dasm - System.Threading.Tasks.ValueTask`1[ubyte]:AsTask():System.Threading.Tasks.Task`1[ubyte]:this (Tier1)
          27 ( 5.53% of base) : 78823.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          23 ( 5.48% of base) : 76374.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 5.47% of base) : 27089.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          27 ( 5.47% of base) : 7695.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          27 ( 5.47% of base) : 50189.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          30 ( 5.41% of base) : 27088.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          30 ( 5.41% of base) : 7694.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          30 ( 5.39% of base) : 36014.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          23 ( 5.32% of base) : 99200.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          23 ( 5.32% of base) : 19613.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 5.09% of base) : 81227.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          27 ( 4.91% of base) : 78822.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 4.90% of base) : 86183.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)
          27 ( 4.86% of base) : 50188.dasm - System.Threading.SpinWait:SpinOnce(int):this (Tier1)

Top method improvements (percentages):
         -18 (-40.91% of base) : 63143.dasm - System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)
        -391 (-35.26% of base) : 63823.dasm - System.Reflection.MethodInvokerCommon:Initialize(System.RuntimeType[],byref,byref,byref) (Tier1)
        -391 (-35.26% of base) : 75845.dasm - System.Reflection.MethodInvokerCommon:Initialize(System.RuntimeType[],byref,byref,byref) (Tier1)
         -43 (-33.08% of base) : 97365.dasm - SciMark2.FFT:inverse(double[]) (Tier1)
         -60 (-31.91% of base) : 75623.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 82349.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 85543.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 29411.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 46671.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 69638.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 38409.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 95821.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 69352.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 42885.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 89025.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 77125.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 83809.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 100233.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 23169.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-31.91% of base) : 40620.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)

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

Total bytes of base: 12784211 (overridden on cmd)
Total bytes of diff: 12701995 (overridden on cmd)
Total bytes of delta: -82216 (-0.64 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          69 : 54986.dasm (2.27% of base)
          63 : 29019.dasm (1.83% of base)
          47 : 54989.dasm (3.78% of base)
          47 : 54987.dasm (3.78% of base)
          47 : 49210.dasm (3.69% of base)
          44 : 49209.dasm (1.72% of base)
          20 : 28189.dasm (1.62% of base)
          11 : 9089.dasm (0.41% of base)
          10 : 53480.dasm (1.87% of base)
           8 : 8541.dasm (1.55% of base)
           6 : 20487.dasm (0.52% of base)
           5 : 28187.dasm (3.60% of base)
           5 : 28158.dasm (3.60% of base)
           5 : 8250.dasm (0.26% of base)
           4 : 41173.dasm (2.94% of base)
           4 : 47521.dasm (1.20% of base)
           4 : 6686.dasm (1.09% of base)
           4 : 2673.dasm (1.27% of base)
           3 : 5540.dasm (4.29% of base)
           3 : 2591.dasm (3.37% of base)

Top file improvements (bytes):
       -1058 : 18079.dasm (-3.35% of base)
        -965 : 8857.dasm (-40.01% of base)
        -926 : 45484.dasm (-21.96% of base)
        -657 : 33413.dasm (-9.89% of base)
        -568 : 52858.dasm (-6.59% of base)
        -487 : 45482.dasm (-12.63% of base)
        -476 : 42524.dasm (-19.51% of base)
        -473 : 16786.dasm (-1.40% of base)
        -434 : 42519.dasm (-17.92% of base)
        -431 : 32239.dasm (-8.30% of base)
        -344 : 54091.dasm (-22.15% of base)
        -335 : 4150.dasm (-37.51% of base)
        -299 : 17028.dasm (-1.70% of base)
        -282 : 41178.dasm (-4.86% of base)
        -280 : 54083.dasm (-40.40% of base)
        -273 : 31896.dasm (-5.52% of base)
        -265 : 41403.dasm (-3.09% of base)
        -261 : 48105.dasm (-1.58% of base)
        -250 : 30389.dasm (-6.77% of base)
        -243 : 13545.dasm (-11.21% of base)

78 total files with Code Size differences (52 improved, 26 regressed), 20 unchanged.

Top method regressions (bytes):
          69 ( 2.27% of base) : 54986.dasm - (dynamicClass):ReadMyEventsListerViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          63 ( 1.83% of base) : 29019.dasm - (dynamicClass):ReadCollectionsOfPrimitivesFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          47 ( 3.69% of base) : 49210.dasm - (dynamicClass):ReadArrayOfActiveOrUpcomingEventFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 54987.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 54989.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemTaskFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          44 ( 1.72% of base) : 49209.dasm - (dynamicClass):ReadIndexViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          20 ( 1.62% of base) : 28189.dasm - ProtoBuf.Meta.ValueMember:BuildSerializer():ProtoBuf.Internal.Serializers.IRuntimeProtoSerializerNode:this (Tier1)
          11 ( 0.41% of base) : 9089.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
          10 ( 1.87% of base) : 53480.dasm - System.Net.Sockets.SocketAsyncEventArgs:SetBuffer(ubyte[],int,int):this (Tier1)
           8 ( 1.55% of base) : 8541.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Security.SslSessionsCache+SslCredKey,System.__Canon]:TryGetValue(System.Net.Security.SslSessionsCache+SslCredKey,byref):ubyte:this (Tier1)
           6 ( 0.52% of base) : 20487.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (Tier1)
           5 ( 3.60% of base) : 28187.dasm - ProtoBuf.Helpers:GetGetMethod(System.Reflection.PropertyInfo,ubyte,ubyte):System.Reflection.MethodInfo (Tier1)
           5 ( 3.60% of base) : 28158.dasm - ProtoBuf.Helpers:GetSetMethod(System.Reflection.PropertyInfo,ubyte,ubyte):System.Reflection.MethodInfo (Tier1)
           5 ( 0.26% of base) : 8250.dasm - System.Reflection.Emit.SignatureHelper:AddOneArgTypeHelperWorker(System.Type,ubyte):this (Tier1)
           4 ( 2.94% of base) : 41173.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:VisitBlock(Microsoft.CodeAnalysis.CSharp.BoundBlock):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
           4 ( 1.20% of base) : 47521.dasm - System.IO.Enumeration.FileSystemEntry:Join(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):System.String (Tier1)
           4 ( 1.27% of base) : 2673.dasm - System.RuntimeType+RuntimeTypeCache+Filter:Match(System.MdUtf8String):ubyte:this (Tier1)
           4 ( 1.09% of base) : 6686.dasm - System.Threading.Timer:.ctor(System.Threading.TimerCallback,System.Object,int,int):this (Tier1)
           3 ( 7.32% of base) : 41214.dasm - Microsoft.CodeAnalysis.WellKnownTypes:GetMetadataName(int):System.String (Tier1)
           3 ( 4.29% of base) : 5540.dasm - System.Number:<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(uint):System.String (Tier1)

Top method improvements (bytes):
       -1058 (-3.35% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -965 (-40.01% of base) : 8857.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -926 (-21.96% of base) : 45484.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -657 (-9.89% of base) : 33413.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
        -568 (-6.59% of base) : 52858.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:ConvertToSymbolicRegexNode(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.Text.RegularExpressions.Symbolic.BDD]:this (Tier1)
        -487 (-12.63% of base) : 45482.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -476 (-19.51% of base) : 42524.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1)
        -473 (-1.40% of base) : 16786.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -434 (-17.92% of base) : 42519.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -431 (-8.30% of base) : 32239.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -344 (-22.15% of base) : 54091.dasm - System.Linq.Expressions.Expression:ValidateLambdaArgs(System.Type,byref,System.Collections.ObjectModel.ReadOnlyCollection`1[System.Linq.Expressions.ParameterExpression],System.String) (Tier1)
        -335 (-37.51% of base) : 4150.dasm - System.Reflection.MethodInvokerCommon:Initialize(System.RuntimeType[],byref,byref,byref) (Tier1)
        -299 (-1.70% of base) : 17028.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
        -282 (-4.86% of base) : 41178.dasm - Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator:EmitExpressionCore(Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte):this (Tier1)
        -280 (-40.40% of base) : 54083.dasm - System.Dynamic.Utils.ExpressionUtils:ValidateArgumentTypes(System.Reflection.MethodBase,int,byref,System.String) (Tier1)
        -273 (-5.52% of base) : 31896.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -265 (-3.09% of base) : 41403.dasm - Benchstone.BenchF.LLoops:Main1(int):this (Tier1)
        -261 (-1.58% of base) : 48105.dasm - (dynamicClass):_DynamicMethod1(byref,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
        -250 (-6.77% of base) : 30389.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1)
        -243 (-11.21% of base) : 13545.dasm - System.Text.CompositeFormat:TryParseLiterals(System.ReadOnlySpan`1[ushort],System.Collections.Generic.List`1[System.ValueTuple`4[System.String,int,int,System.String]],byref,byref):ubyte (Tier0-FullOpts)

Top method regressions (percentages):
           3 ( 7.32% of base) : 41214.dasm - Microsoft.CodeAnalysis.WellKnownTypes:GetMetadataName(int):System.String (Tier1)
           3 ( 4.29% of base) : 5540.dasm - System.Number:<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(uint):System.String (Tier1)
          47 ( 3.78% of base) : 54987.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.78% of base) : 54989.dasm - (dynamicClass):ReadArrayOfMyEventsListerItemTaskFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
          47 ( 3.69% of base) : 49210.dasm - (dynamicClass):ReadArrayOfActiveOrUpcomingEventFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString,System.Runtime.Serialization.DataContracts.CollectionDataContract):System.Object (FullOpts)
           5 ( 3.60% of base) : 28187.dasm - ProtoBuf.Helpers:GetGetMethod(System.Reflection.PropertyInfo,ubyte,ubyte):System.Reflection.MethodInfo (Tier1)
           5 ( 3.60% of base) : 28158.dasm - ProtoBuf.Helpers:GetSetMethod(System.Reflection.PropertyInfo,ubyte,ubyte):System.Reflection.MethodInfo (Tier1)
           2 ( 3.45% of base) : 2319.dasm - System.Reflection.TypeNameParser+NamespaceTypeName:ResolveType(byref,System.String):System.Type:this (Tier1)
           3 ( 3.37% of base) : 2591.dasm - System.Number:UInt32ToDecStrForKnownSmallNumber(uint):System.String (Tier1)
           1 ( 3.03% of base) : 33346.dasm - System.Text.RegularExpressions.Regex:.ctor(System.String,int):this (Tier1)
           4 ( 2.94% of base) : 41173.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:VisitBlock(Microsoft.CodeAnalysis.CSharp.BoundBlock):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
           2 ( 2.56% of base) : 4741.dasm - System.Security.Cryptography.HashProviderDispenser:CreateHashProvider(System.String):System.Security.Cryptography.HashProvider (Tier1)
          69 ( 2.27% of base) : 54986.dasm - (dynamicClass):ReadMyEventsListerViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
          10 ( 1.87% of base) : 53480.dasm - System.Net.Sockets.SocketAsyncEventArgs:SetBuffer(ubyte[],int,int):this (Tier1)
          63 ( 1.83% of base) : 29019.dasm - (dynamicClass):ReadCollectionsOfPrimitivesFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
           1 ( 1.79% of base) : 8550.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Security.SslSessionsCache+SslCredKey,System.__Canon]:AcquirePostFirstLock(System.Collections.Concurrent.ConcurrentDictionary`2+Tables[System.Net.Security.SslSessionsCache+SslCredKey,System.__Canon],byref) (Tier1)
          44 ( 1.72% of base) : 49209.dasm - (dynamicClass):ReadIndexViewModelFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
           3 ( 1.63% of base) : 22869.dasm - System.Threading.Tasks.ValueTask`1[ubyte]:AsTask():System.Threading.Tasks.Task`1[ubyte]:this (Tier1)
          20 ( 1.62% of base) : 28189.dasm - ProtoBuf.Meta.ValueMember:BuildSerializer():ProtoBuf.Internal.Serializers.IRuntimeProtoSerializerNode:this (Tier1)
           8 ( 1.55% of base) : 8541.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Security.SslSessionsCache+SslCredKey,System.__Canon]:TryGetValue(System.Net.Security.SslSessionsCache+SslCredKey,byref):ubyte:this (Tier1)

Top method improvements (percentages):
        -190 (-46.80% of base) : 53959.dasm - System.Dynamic.Utils.TypeExtensions:MatchesArgumentTypes(System.Reflection.MethodInfo,System.Type[]):ubyte (Tier1)
         -54 (-46.15% of base) : 40002.dasm - Roslyn.Utilities.StringTable:TextEqualsASCII(System.String,System.ReadOnlySpan`1[ubyte]):ubyte (Tier1)
         -16 (-41.03% of base) : 26330.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier:FromServiceType(System.Type):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier (Tier1)
         -18 (-40.91% of base) : 35566.dasm - System.Collections.Immutable.ImmutableInterlocked:InterlockedCompareExchange[System.__Canon](byref,System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (Tier1)
        -280 (-40.40% of base) : 54083.dasm - System.Dynamic.Utils.ExpressionUtils:ValidateArgumentTypes(System.Reflection.MethodBase,int,byref,System.String) (Tier1)
        -965 (-40.01% of base) : 8857.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
        -335 (-37.51% of base) : 4150.dasm - System.Reflection.MethodInvokerCommon:Initialize(System.RuntimeType[],byref,byref,byref) (Tier1)
         -43 (-33.08% of base) : 53648.dasm - SciMark2.FFT:inverse(double[]) (Tier1)
         -60 (-32.79% of base) : 25587.dasm - SeekUnroll:FindByte(byref):int (Tier1)
         -22 (-31.43% of base) : 28167.dasm - System.Diagnostics.DebuggerDisplayAttribute:.ctor(System.String):this (Tier1)
         -39 (-30.00% of base) : 6629.dasm - System.String:Equals(System.Object):ubyte:this (Tier1)
         -60 (-28.04% of base) : 24730.dasm - EMFloat:memmove(byref,byref) (Tier1)
         -10 (-27.78% of base) : 43577.dasm - Roslyn.Utilities.OneOrMany:Create[System.__Canon](System.__Canon):Roslyn.Utilities.OneOrMany`1[System.__Canon] (Tier1)
         -25 (-27.78% of base) : 4053.dasm - System.IO.PathInternal:IsExtended(System.ReadOnlySpan`1[ushort]):ubyte (Tier1)
         -72 (-27.69% of base) : 25586.dasm - SeekUnroll:InnerLoop(byref,byref) (Tier1-OSR)
         -63 (-27.63% of base) : 8939.dasm - System.Net.Security.TlsFrameHelper:TryGetFrameHeader(System.ReadOnlySpan`1[ubyte],byref):ubyte (Tier1)
        -147 (-27.43% of base) : 8205.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (Tier0-FullOpts)
         -10 (-27.03% of base) : 40739.dasm - System.Linq.ImmutableArrayExtensions:FirstOrDefault[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.__Canon (Tier1)
         -60 (-26.79% of base) : 26066.dasm - EMFloatClass:memmove(EMFloatClass+InternalFPF,EMFloatClass+InternalFPF) (Tier1)
        -202 (-25.44% of base) : 25405.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)

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

Total bytes of base: 388461743 (overridden on cmd)
Total bytes of diff: 385950363 (overridden on cmd)
Total bytes of delta: -2511380 (-0.65 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         930 : 233007.dasm (0.57% of base)
         930 : 233012.dasm (0.57% of base)
         494 : 189778.dasm (20.01% of base)
         454 : 189772.dasm (17.91% of base)
         322 : 462307.dasm (10.06% of base)
         183 : 233476.dasm (1.04% of base)
         174 : 184819.dasm (3.68% of base)
         159 : 233529.dasm (0.89% of base)
         158 : 239263.dasm (0.88% of base)
         118 : 233519.dasm (0.69% of base)
         118 : 239259.dasm (0.69% of base)
          94 : 233539.dasm (0.54% of base)
          94 : 239267.dasm (0.54% of base)
          87 : 239261.dasm (0.49% of base)
          87 : 233524.dasm (0.49% of base)
          72 : 232830.dasm (18.80% of base)
          71 : 250435.dasm (25.36% of base)
          62 : 224033.dasm (1.01% of base)
          62 : 189644.dasm (3.00% of base)
          62 : 222693.dasm (1.01% of base)

Top file improvements (bytes):
      -15081 : 233544.dasm (-13.18% of base)
      -14935 : 233480.dasm (-12.91% of base)
      -10239 : 233448.dasm (-9.90% of base)
      -10151 : 233512.dasm (-9.93% of base)
       -9733 : 233857.dasm (-9.98% of base)
       -8896 : 233208.dasm (-9.09% of base)
       -7942 : 233847.dasm (-8.15% of base)
       -7484 : 233752.dasm (-15.61% of base)
       -6502 : 233194.dasm (-7.05% of base)
       -5827 : 291045.dasm (-48.97% of base)
       -5078 : 233201.dasm (-5.33% of base)
       -3843 : 285536.dasm (-17.42% of base)
       -3657 : 286388.dasm (-16.95% of base)
       -3646 : 285042.dasm (-17.14% of base)
       -3633 : 286114.dasm (-16.97% of base)
       -3562 : 193261.dasm (-36.74% of base)
       -3528 : 291327.dasm (-19.88% of base)
       -3464 : 286354.dasm (-16.47% of base)
       -3416 : 285923.dasm (-16.44% of base)
       -3314 : 284424.dasm (-16.11% of base)

93 total files with Code Size differences (57 improved, 36 regressed), 20 unchanged.

Top method regressions (bytes):
         930 ( 0.57% of base) : 233007.dasm - decimaldiv:TestEntryPoint():int (FullOpts)
         930 ( 0.57% of base) : 233012.dasm - decimalrem:TestEntryPoint():int (FullOpts)
         494 (20.01% of base) : 189778.dasm - ImplicitByrefTailCalls:TestEntryPoint():int (FullOpts)
         454 (17.91% of base) : 189772.dasm - ImplicitByrefTailCalls:TestEntryPoint():int (FullOpts)
         322 (10.06% of base) : 462307.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]],int,ubyte):this (Tier1)
         183 ( 1.04% of base) : 233476.dasm - r4NaNsub:TestEntryPoint():int (FullOpts)
         174 ( 3.68% of base) : 184819.dasm - TailcallVerify.Program:Run(System.String):int (FullOpts)
         159 ( 0.89% of base) : 233529.dasm - r8NaNmul:TestEntryPoint():int (FullOpts)
         158 ( 0.88% of base) : 239263.dasm - r8NaNmul:TestEntryPoint():int (FullOpts)
         118 ( 0.69% of base) : 233519.dasm - r8NaNadd:TestEntryPoint():int (FullOpts)
         118 ( 0.69% of base) : 239259.dasm - r8NaNadd:TestEntryPoint():int (FullOpts)
          94 ( 0.54% of base) : 233539.dasm - r8NaNsub:TestEntryPoint():int (FullOpts)
          94 ( 0.54% of base) : 239267.dasm - r8NaNsub:TestEntryPoint():int (FullOpts)
          87 ( 0.49% of base) : 239261.dasm - r8NaNdiv:TestEntryPoint():int (FullOpts)
          87 ( 0.49% of base) : 233524.dasm - r8NaNdiv:TestEntryPoint():int (FullOpts)
          72 (18.80% of base) : 232830.dasm - Test_200w1d_02.testout1:TestEntryPoint():int (FullOpts)
          71 (25.36% of base) : 250435.dasm - testout1:Func(testout1+CL,testout1+VT):long (FullOpts)
          62 ( 1.01% of base) : 224033.dasm - TestApp:RunAllTests():int (FullOpts)
          62 ( 1.01% of base) : 222693.dasm - TestApp:RunAllTests():int (FullOpts)
          62 ( 3.00% of base) : 189644.dasm - VirtFunc.CTest:TestEntryPoint():int (FullOpts)

Top method improvements (bytes):
      -15081 (-13.18% of base) : 233544.dasm - r8rem:TestEntryPoint():int (FullOpts)
      -14935 (-12.91% of base) : 233480.dasm - r4rem:TestEntryPoint():int (FullOpts)
      -10239 (-9.90% of base) : 233448.dasm - r4div:TestEntryPoint():int (FullOpts)
      -10151 (-9.93% of base) : 233512.dasm - r8div:TestEntryPoint():int (FullOpts)
       -9733 (-9.98% of base) : 233857.dasm - u8div:TestEntryPoint():int (FullOpts)
       -8896 (-9.09% of base) : 233208.dasm - i8div:TestEntryPoint():int (FullOpts)
       -7942 (-8.15% of base) : 233847.dasm - u4div:TestEntryPoint():int (FullOpts)
       -7484 (-15.61% of base) : 233752.dasm - Test_throwinfinallyrecursive_20_cs.Class1:.cctor() (FullOpts)
       -6502 (-7.05% of base) : 233194.dasm - i4div:TestEntryPoint():int (FullOpts)
       -5827 (-48.97% of base) : 291045.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -5078 (-5.33% of base) : 233201.dasm - i4rem:TestEntryPoint():int (FullOpts)
       -3843 (-17.42% of base) : 285536.dasm - Generated934:CalliTest() (FullOpts)
       -3657 (-16.95% of base) : 286388.dasm - Generated960:CalliTest() (FullOpts)
       -3646 (-17.14% of base) : 285042.dasm - Generated920:CalliTest() (FullOpts)
       -3633 (-16.97% of base) : 286114.dasm - Generated952:CalliTest() (FullOpts)
       -3562 (-36.74% of base) : 193261.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -3528 (-19.88% of base) : 291327.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -3464 (-16.47% of base) : 286354.dasm - Generated959:CalliTest() (FullOpts)
       -3416 (-16.44% of base) : 285923.dasm - Generated946:CalliTest() (FullOpts)
       -3314 (-16.11% of base) : 284424.dasm - Generated902:CalliTest() (FullOpts)

Top method regressions (percentages):
          15 (45.45% of base) : 197587.dasm - Surfaces+<>c:<.cctor>b__5_4(VectorPacket256):VectorPacket256:this (FullOpts)
          27 (29.35% of base) : 250215.dasm - bug1:TestEntryPoint() (FullOpts)
          71 (25.36% of base) : 250435.dasm - testout1:Func(testout1+CL,testout1+VT):long (FullOpts)
          58 (21.17% of base) : 20398.dasm - Mutual_recursion:fifth():int (FullOpts)
          58 (21.17% of base) : 20403.dasm - Mutual_recursion:sixth():int (FullOpts)
          13 (20.97% of base) : 290034.dasm - HardwareEh+<>c:<PosTest19>b__20_0():ubyte:this (FullOpts)
         494 (20.01% of base) : 189778.dasm - ImplicitByrefTailCalls:TestEntryPoint():int (FullOpts)
           1 (20.00% of base) : 247399.dasm - DevDiv_544983:Test(int):int (FullOpts)
           5 (20.00% of base) : 211502.dasm - GetEnumUnderlyingType+<>c:<TestGetEnumUnderlyingType>b__0_4():this (FullOpts)
           1 (20.00% of base) : 22502.dasm - TestStructReturns:TestLessNativeIntCall1():int (FullOpts)
           1 (20.00% of base) : 22503.dasm - TestStructReturns:TestLessNativeIntCall2():int (FullOpts)
           5 (19.23% of base) : 290007.dasm - HardwareEh+<>c:<PosTest3>b__6_0():ubyte:this (FullOpts)
          18 (19.15% of base) : 178381.dasm - StaticValueField:TestEntryPoint():int (FullOpts)
          72 (18.80% of base) : 232830.dasm - Test_200w1d_02.testout1:TestEntryPoint():int (FullOpts)
           3 (18.75% of base) : 247184.dasm - GitHub_23199_64Bit.Program:GetNoPointer2():GitHub_23199_64Bit.Program+NoPointer2 (FullOpts)
           5 (18.52% of base) : 211478.dasm - Program+<>c:<TestIsAssignableFrom>b__24_2():this (FullOpts)
          44 (18.41% of base) : 20653.dasm - NativeVarargTest.VarArg:TestEchoFourDoubleStructManaged():ubyte (FullOpts)
          44 (18.41% of base) : 20688.dasm - NativeVarargTest.VarArg:TestEchoFourDoubleStructManagedViaAddress():ubyte (FullOpts)
         454 (17.91% of base) : 189772.dasm - ImplicitByrefTailCalls:TestEntryPoint():int (FullOpts)
          34 (16.83% of base) : 20649.dasm - NativeVarargTest.VarArg:TestEchoThreeDoubleStructManaged():ubyte (FullOpts)

Top method improvements (percentages):
        -410 (-97.16% of base) : 248384.dasm - N.C:Test():int (FullOpts)
         -79 (-96.34% of base) : 308219.dasm - Microsoft.Build.Framework.NativeMethods:get_IsBSD():ubyte (FullOpts)
        -134 (-93.71% of base) : 220186.dasm - Test15:Test() (FullOpts)
        -134 (-93.71% of base) : 220174.dasm - Test5:Test() (FullOpts)
         -42 (-93.33% of base) : 245660.dasm - Runtime_81460:Test():int (FullOpts)
        -217 (-91.95% of base) : 242167.dasm - Program:TestSHL() (FullOpts)
        -217 (-91.95% of base) : 242168.dasm - Program:TestSHR() (FullOpts)
        -217 (-91.95% of base) : 242169.dasm - Program:TestSZR() (FullOpts)
         -32 (-91.43% of base) : 245451.dasm - Runtime_71156:Problem():ubyte (FullOpts)
        -144 (-91.14% of base) : 190639.dasm - Z:TestEntryPoint():int (FullOpts)
         -85 (-90.43% of base) : 220189.dasm - Test17:Test() (FullOpts)
         -85 (-90.43% of base) : 220172.dasm - Test3:Test() (FullOpts)
         -98 (-87.50% of base) : 240771.dasm - ILGEN_939264028:main():int (FullOpts)
         -62 (-87.32% of base) : 220173.dasm - Test4:Test() (FullOpts)
         -62 (-87.32% of base) : 220175.dasm - Test6:Test() (FullOpts)
         -88 (-86.27% of base) : 189721.dasm - Z:TestEntryPoint():int (FullOpts)
         -85 (-85.86% of base) : 189698.dasm - Program:TestEntryPoint():int (FullOpts)
         -85 (-85.86% of base) : 190630.dasm - Test_sharedoverride:TestEntryPoint():int (FullOpts)
         -31 (-83.78% of base) : 240798.dasm - ILGEN_940455031:main():int (FullOpts)
         -29 (-82.86% of base) : 235631.dasm - JitTest_accum_il.CI:Main():int (FullOpts)

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

Total bytes of base: 45279466 (overridden on cmd)
Total bytes of diff: 44592269 (overridden on cmd)
Total bytes of delta: -687197 (-1.52 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          50 : 173637.dasm (1.75% of base)
          31 : 173192.dasm (2.89% of base)
          26 : 167561.dasm (1.89% of base)
          24 : 41321.dasm (2.31% of base)
          22 : 167575.dasm (1.56% of base)
          21 : 124510.dasm (3.08% of base)
          21 : 62218.dasm (3.08% of base)
          20 : 167576.dasm (1.83% of base)
          18 : 22384.dasm (0.47% of base)
          18 : 22385.dasm (0.47% of base)
          17 : 210596.dasm (1.72% of base)
          16 : 64081.dasm (8.65% of base)
          16 : 223635.dasm (1.39% of base)
          16 : 126192.dasm (8.65% of base)
          16 : 167562.dasm (1.79% of base)
          16 : 167235.dasm (4.48% of base)
          16 : 16877.dasm (0.86% of base)
          16 : 193060.dasm (1.39% of base)
          15 : 64075.dasm (7.04% of base)
          15 : 126184.dasm (7.04% of base)

Top file improvements (bytes):
       -6483 : 193189.dasm (-35.32% of base)
       -6197 : 223759.dasm (-35.28% of base)
       -6119 : 36131.dasm (-6.88% of base)
       -4095 : 39398.dasm (-32.80% of base)
       -3952 : 40487.dasm (-32.72% of base)
       -3369 : 53308.dasm (-26.62% of base)
       -3203 : 193192.dasm (-33.09% of base)
       -3190 : 223762.dasm (-33.08% of base)
       -2901 : 211094.dasm (-19.54% of base)
       -2287 : 38317.dasm (-6.50% of base)
       -2012 : 53373.dasm (-14.56% of base)
       -1886 : 259460.dasm (-31.89% of base)
       -1872 : 37651.dasm (-30.40% of base)
       -1745 : 151368.dasm (-10.68% of base)
       -1731 : 245440.dasm (-31.44% of base)
       -1666 : 36722.dasm (-7.65% of base)
       -1527 : 97114.dasm (-4.72% of base)
       -1485 : 36400.dasm (-6.38% of base)
       -1405 : 219723.dasm (-11.06% of base)
       -1296 : 192157.dasm (-32.18% of base)

90 total files with Code Size differences (53 improved, 37 regressed), 20 unchanged.

Top method regressions (bytes):
          50 ( 1.75% of base) : 173637.dasm - System.Linq.Expressions.Interpreter.LightCompiler:CompileTryExpression(System.Linq.Expressions.Expression):this (FullOpts)
          31 ( 2.89% of base) : 173192.dasm - System.Linq.Expressions.UnaryExpression:ReduceIndex():System.Linq.Expressions.Expression:this (FullOpts)
          26 ( 1.89% of base) : 167561.dasm - System.Text.Json.Utf8JsonReader:ConsumeNextTokenFromLastNonCommentToken():ubyte:this (FullOpts)
          24 ( 2.31% of base) : 41321.dasm - Microsoft.Diagnostics.Tracing.Parsers.Symbol.FileVersionTraceData:ToXml(System.Text.StringBuilder):System.Text.StringBuilder:this (FullOpts)
          22 ( 1.56% of base) : 167575.dasm - System.Text.Json.Utf8JsonReader:ConsumeNextTokenFromLastNonCommentTokenMultiSegment():ubyte:this (FullOpts)
          21 ( 3.08% of base) : 124510.dasm - Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter:GetBinaryOperatorName(int,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,byref,byref,byref):System.String (FullOpts)
          21 ( 3.08% of base) : 62218.dasm - Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter:GetBinaryOperatorName(int,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,byref,byref,byref):System.String (FullOpts)
          20 ( 1.83% of base) : 167576.dasm - System.Text.Json.Utf8JsonReader:ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(ubyte):ubyte:this (FullOpts)
          18 ( 0.47% of base) : 22385.dasm - System.Globalization.TimeSpanParse:ProcessTerminal_HM_S_D(byref,ubyte,byref):ubyte (FullOpts)
          18 ( 0.47% of base) : 22384.dasm - System.Globalization.TimeSpanParse:ProcessTerminal_HMS_F_D(byref,ubyte,byref):ubyte (FullOpts)
          17 ( 1.72% of base) : 210596.dasm - System.Net.Http.MultipartContent:TryComputeLength(byref):ubyte:this (FullOpts)
          16 ( 8.65% of base) : 64081.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:EnumDeclaration(Microsoft.CodeAnalysis.SyntaxToken):Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax (FullOpts)
          16 ( 8.65% of base) : 126192.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:EnumDeclaration(Microsoft.CodeAnalysis.SyntaxToken):Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax (FullOpts)
          16 ( 1.39% of base) : 223635.dasm - Microsoft.CodeAnalysis.SyntaxTreeExtensions:VerifySource(Microsoft.CodeAnalysis.SyntaxTree,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Text.TextChangeRange]) (FullOpts)
          16 ( 1.39% of base) : 193060.dasm - Microsoft.CodeAnalysis.SyntaxTreeExtensions:VerifySource(Microsoft.CodeAnalysis.SyntaxTree,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Text.TextChangeRange]) (FullOpts)
          16 ( 4.48% of base) : 167235.dasm - System.Text.Json.JsonReaderHelper:TryGetFloatingPointConstant(System.ReadOnlySpan`1[ubyte],byref):ubyte (FullOpts)
          16 ( 1.79% of base) : 167562.dasm - System.Text.Json.Utf8JsonReader:ConsumeNextTokenUntilAfterAllCommentsAreSkipped(ubyte):ubyte:this (FullOpts)
          16 ( 0.86% of base) : 16877.dasm - System.Threading.Tasks.Task:WaitAllCore(System.Threading.Tasks.Task[],int,System.Threading.CancellationToken):ubyte (FullOpts)
          15 ( 4.36% of base) : 122682.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions:.ctor(int,ubyte,System.String,System.String,System.String,System.Collections.Generic.IEnumerable`1[System.String],int,ubyte,ubyte,System.String,System.String,System.Collections.Immutable.ImmutableArray`1[ubyte],System.Nullable`1[ubyte],int,int,int,System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.String,int]],ubyte,ubyte,Microsoft.CodeAnalysis.XmlReferenceResolver,Microsoft.CodeAnalysis.SourceReferenceResolver,Microsoft.CodeAnalysis.MetadataReferenceResolver,Microsoft.CodeAnalysis.AssemblyIdentityComparer,Microsoft.CodeAnalysis.StrongNameProvider):this (FullOpts)
          15 ( 4.36% of base) : 60051.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions:.ctor(int,ubyte,System.String,System.String,System.String,System.Collections.Generic.IEnumerable`1[System.String],int,ubyte,ubyte,System.String,System.String,System.Collections.Immutable.ImmutableArray`1[ubyte],System.Nullable`1[ubyte],int,int,int,System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.String,int]],ubyte,ubyte,Microsoft.CodeAnalysis.XmlReferenceResolver,Microsoft.CodeAnalysis.SourceReferenceResolver,Microsoft.CodeAnalysis.MetadataReferenceResolver,Microsoft.CodeAnalysis.AssemblyIdentityComparer,Microsoft.CodeAnalysis.StrongNameProvider):this (FullOpts)

Top method improvements (bytes):
       -6483 (-35.32% of base) : 193189.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -6197 (-35.28% of base) : 223759.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -6119 (-6.88% of base) : 36131.dasm - Microsoft.Diagnostics.Tracing.Parsers.ApplicationServerTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -4095 (-32.80% of base) : 39398.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIPTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -3952 (-32.72% of base) : 40487.dasm - Microsoft.Diagnostics.Tracing.Parsers.WpfTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -3369 (-26.62% of base) : 53308.dasm - System.Text.RegularExpressions.RegexCharClass:.cctor() (FullOpts)
       -3203 (-33.09% of base) : 193192.dasm - Microsoft.CodeAnalysis.WellKnownTypes:.cctor() (FullOpts)
       -3190 (-33.08% of base) : 223762.dasm - Microsoft.CodeAnalysis.WellKnownTypes:.cctor() (FullOpts)
       -2901 (-19.54% of base) : 211094.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -2287 (-6.50% of base) : 38317.dasm - Microsoft.Diagnostics.Tracing.Parsers.KernelTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -2012 (-14.56% of base) : 53373.dasm - System.Text.RegularExpressions.RegexCompiler:.cctor() (FullOpts)
       -1886 (-31.89% of base) : 259460.dasm - System.Drawing.KnownColorNames:.cctor() (FullOpts)
       -1872 (-30.40% of base) : 37651.dasm - Microsoft.Diagnostics.Tracing.Parsers.IisTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1745 (-10.68% of base) : 151368.dasm - System.Xml.Schema.XsdBuilder:.cctor() (FullOpts)
       -1731 (-31.44% of base) : 245440.dasm - Microsoft.VisualBasic.VBCodeGenerator:.cctor() (FullOpts)
       -1666 (-7.65% of base) : 36722.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1527 (-4.72% of base) : 97114.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.VisualBasic.VisualBasicCommandLineArguments:this (FullOpts)
       -1485 (-6.38% of base) : 36400.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrPrivateTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1405 (-11.06% of base) : 219723.dasm - System.DirectoryServices.ActiveDirectory.Utils:GetReplicaList(System.DirectoryServices.ActiveDirectory.DirectoryContext,System.String,System.String,ubyte,ubyte,ubyte):System.Collections.ArrayList (FullOpts)
       -1296 (-32.18% of base) : 192157.dasm - Microsoft.CodeAnalysis.SpecialMembers:.cctor() (FullOpts)

Top method regressions (percentages):
           8 (15.38% of base) : 92581.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.Metadata.PE.PEParameterSymbol:EnsureParameterNameNotEmpty(System.String,byref):System.String (FullOpts)
           9 (11.54% of base) : 177649.dasm - Newtonsoft.Json.Serialization.JsonSerializerInternalReader:HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract):ubyte:this (FullOpts)
          12 ( 9.76% of base) : 13100.dasm - System.Memory`1[System.__Canon]:.ctor(System.__Canon[],int,int):this (FullOpts)
          16 ( 8.65% of base) : 64081.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:EnumDeclaration(Microsoft.CodeAnalysis.SyntaxToken):Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax (FullOpts)
          16 ( 8.65% of base) : 126192.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:EnumDeclaration(Microsoft.CodeAnalysis.SyntaxToken):Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax (FullOpts)
          10 ( 7.94% of base) : 254610.dasm - System.Runtime.Caching.CacheMemoryMonitor:get_AutoPrivateBytesLimit():long (FullOpts)
          10 ( 7.94% of base) : 13165.dasm - System.Span`1[System.__Canon]:.ctor(System.__Canon[],int,int):this (FullOpts)
          15 ( 7.04% of base) : 126184.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:ClassDeclaration(System.String):Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax (FullOpts)
          15 ( 7.04% of base) : 64070.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:ClassDeclaration(System.String):Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax (FullOpts)
          15 ( 7.04% of base) : 64079.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:InterfaceDeclaration(System.String):Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax (FullOpts)
          15 ( 7.04% of base) : 126190.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:InterfaceDeclaration(System.String):Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax (FullOpts)
          15 ( 7.04% of base) : 64075.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:StructDeclaration(System.String):Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax (FullOpts)
          15 ( 7.04% of base) : 126187.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxFactory:StructDeclaration(System.String):Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax (FullOpts)
           6 ( 6.74% of base) : 13099.dasm - System.Memory`1[System.__Canon]:.ctor(System.__Canon[]):this (FullOpts)
           4 ( 4.94% of base) : 13164.dasm - System.Span`1[System.__Canon]:.ctor(System.__Canon[]):this (FullOpts)
           3 ( 4.69% of base) : 185876.dasm - System.Reflection.Metadata.FieldDefinition:GetProjectedFlags():int:this (FullOpts)
          16 ( 4.48% of base) : 167235.dasm - System.Text.Json.JsonReaderHelper:TryGetFloatingPointConstant(System.ReadOnlySpan`1[ubyte],byref):ubyte (FullOpts)
          10 ( 4.42% of base) : 262257.dasm - System.Net.Sockets.Socket:DuplicateAndClose(int):System.Net.Sockets.SocketInformation:this (FullOpts)
          15 ( 4.36% of base) : 122682.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions:.ctor(int,ubyte,System.String,System.String,System.String,System.Collections.Generic.IEnumerable`1[System.String],int,ubyte,ubyte,System.String,System.String,System.Collections.Immutable.ImmutableArray`1[ubyte],System.Nullable`1[ubyte],int,int,int,System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.String,int]],ubyte,ubyte,Microsoft.CodeAnalysis.XmlReferenceResolver,Microsoft.CodeAnalysis.SourceReferenceResolver,Microsoft.CodeAnalysis.MetadataReferenceResolver,Microsoft.CodeAnalysis.AssemblyIdentityComparer,Microsoft.CodeAnalysis.StrongNameProvider):this (FullOpts)
          15 ( 4.36% of base) : 60051.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions:.ctor(int,ubyte,System.String,System.String,System.String,System.Collections.Generic.IEnumerable`1[System.String],int,ubyte,ubyte,System.String,System.String,System.Collections.Immutable.ImmutableArray`1[ubyte],System.Nullable`1[ubyte],int,int,int,System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.String,int]],ubyte,ubyte,Microsoft.CodeAnalysis.XmlReferenceResolver,Microsoft.CodeAnalysis.SourceReferenceResolver,Microsoft.CodeAnalysis.MetadataReferenceResolver,Microsoft.CodeAnalysis.AssemblyIdentityComparer,Microsoft.CodeAnalysis.StrongNameProvider):this (FullOpts)

Top method improvements (percentages):
         -11 (-78.57% of base) : 197796.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
         -11 (-78.57% of base) : 228051.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
         -26 (-68.42% of base) : 18667.dasm - System.Numerics.Vector`1[int]:.ctor(int):this (FullOpts)
         -26 (-68.42% of base) : 19050.dasm - System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)
        -143 (-66.20% of base) : 5284.dasm - System.Globalization.HebrewCalendar:.cctor() (FullOpts)
        -179 (-65.81% of base) : 5500.dasm - System.Globalization.PersianCalendar:.cctor() (FullOpts)
         -83 (-64.34% of base) : 4720.dasm - System.Numerics.Vector:Narrow(System.Numerics.Vector`1[long],System.Numerics.Vector`1[long]):System.Numerics.Vector`1[int] (FullOpts)
         -83 (-64.34% of base) : 4723.dasm - System.Numerics.Vector:Narrow(System.Numerics.Vector`1[ulong],System.Numerics.Vector`1[ulong]):System.Numerics.Vector`1[uint] (FullOpts)
         -10 (-62.50% of base) : 197797.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Infinity():ulong:this (FullOpts)
         -10 (-62.50% of base) : 228052.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Infinity():ulong:this (FullOpts)
         -53 (-62.35% of base) : 8399.dasm - System.Runtime.Intrinsics.Vector64:WidenUpper(System.Runtime.Intrinsics.Vector64`1[ushort]):System.Runtime.Intrinsics.Vector64`1[uint] (FullOpts)
         -30 (-61.22% of base) : 8400.dasm - System.Runtime.Intrinsics.Vector64:WidenUpper(System.Runtime.Intrinsics.Vector64`1[uint]):System.Runtime.Intrinsics.Vector64`1[ulong] (FullOpts)
         -53 (-60.92% of base) : 8395.dasm - System.Runtime.Intrinsics.Vector64:WidenUpper(System.Runtime.Intrinsics.Vector64`1[short]):System.Runtime.Intrinsics.Vector64`1[int] (FullOpts)
         -91 (-60.67% of base) : 8346.dasm - System.Runtime.Intrinsics.Vector64:Narrow(System.Runtime.Intrinsics.Vector64`1[uint],System.Runtime.Intrinsics.Vector64`1[uint]):System.Runtime.Intrinsics.Vector64`1[ushort] (FullOpts)
        -114 (-60.32% of base) : 8385.dasm - System.Runtime.Intrinsics.Vector64:Widen(System.Runtime.Intrinsics.Vector64`1[ushort]):System.ValueTuple`2[System.Runtime.Intrinsics.Vector64`1[uint],System.Runtime.Intrinsics.Vector64`1[uint]] (FullOpts)
         -12 (-60.00% of base) : 18762.dasm - System.Numerics.Vector`1[long]:.ctor(long):this (FullOpts)
         -12 (-60.00% of base) : 19118.dasm - System.Numerics.Vector`1[ulong]:.ctor(ulong):this (FullOpts)
         -30 (-60.00% of base) : 8396.dasm - System.Runtime.Intrinsics.Vector64:WidenUpper(System.Runtime.Intrinsics.Vector64`1[int]):System.Runtime.Intrinsics.Vector64`1[long] (FullOpts)
        -147 (-59.27% of base) : 5656.dasm - System.Globalization.UmAlQuraCalendar:.cctor() (FullOpts)
         -42 (-59.15% of base) : 8292.dasm - System.Runtime.Intrinsics.Vector64:Create(short):System.Runtime.Intrinsics.Vector64`1[short] (FullOpts)

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

Total bytes of base: 61662542 (overridden on cmd)
Total bytes of diff: 60774872 (overridden on cmd)
Total bytes of delta: -887670 (-1.44 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         206 : 210131.dasm (3.91% of base)
         115 : 56647.dasm (2.54% of base)
          77 : 175324.dasm (9.51% of base)
          71 : 277858.dasm (14.73% of base)
          69 : 70036.dasm (8.89% of base)
          59 : 83373.dasm (2.95% of base)
          48 : 245507.dasm (3.22% of base)
          48 : 109880.dasm (3.78% of base)
          44 : 56334.dasm (0.72% of base)
          42 : 230638.dasm (3.52% of base)
          38 : 64356.dasm (7.34% of base)
          32 : 245053.dasm (2.96% of base)
          30 : 292192.dasm (10.64% of base)
          28 : 235007.dasm (1.75% of base)
          27 : 30513.dasm (3.76% of base)
          26 : 277552.dasm (2.69% of base)
          26 : 234963.dasm (1.83% of base)
          25 : 273473.dasm (2.36% of base)
          24 : 117047.dasm (4.46% of base)
          24 : 235392.dasm (4.25% of base)

Top file improvements (bytes):
       -4000 : 221206.dasm (-23.41% of base)
       -3734 : 19198.dasm (-31.16% of base)
       -3593 : 190558.dasm (-35.75% of base)
       -3562 : 149896.dasm (-36.74% of base)
       -3505 : 19179.dasm (-29.73% of base)
       -3270 : 19173.dasm (-32.49% of base)
       -3265 : 19192.dasm (-32.60% of base)
       -3230 : 135892.dasm (-45.22% of base)
       -2680 : 148795.dasm (-14.19% of base)
       -2680 : 189480.dasm (-14.19% of base)
       -2622 : 147202.dasm (-11.80% of base)
       -2622 : 187929.dasm (-11.80% of base)
       -2268 : 90512.dasm (-43.58% of base)
       -1802 : 92548.dasm (-43.61% of base)
       -1651 : 57863.dasm (-50.74% of base)
       -1578 : 233051.dasm (-20.87% of base)
       -1483 : 90513.dasm (-38.60% of base)
       -1240 : 273256.dasm (-17.98% of base)
       -1209 : 64593.dasm (-32.99% of base)
       -1145 : 59906.dasm (-7.88% of base)

86 total files with Code Size differences (47 improved, 39 regressed), 20 unchanged.

Top method regressions (bytes):
         206 ( 3.91% of base) : 210131.dasm - System.Data.Common.SqlConvert:ChangeType2(System.Object,int,System.Type,System.IFormatProvider):System.Object (FullOpts)
         115 ( 2.54% of base) : 56647.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInterpolatedStringAppendCalls(System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundInterpolatedStringHandlerPlaceholder,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.ValueTuple`5[System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression]],ubyte,System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`3[ubyte,ubyte,ubyte]]],int,int]:this (FullOpts)
          77 ( 9.51% of base) : 175324.dasm - Microsoft.Build.Logging.BuildEventArgsReader:Read():Microsoft.Build.Framework.BuildEventArgs:this (FullOpts)
          71 (14.73% of base) : 277858.dasm - System.IO.Compression.ZipArchiveEntry:LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded():ubyte:this (FullOpts)
          69 ( 8.89% of base) : 70036.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap:GetEntry(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax,Microsoft.CodeAnalysis.Text.SourceText,Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax]):Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax]:this (FullOpts)
          59 ( 2.95% of base) : 83373.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:MergeEquivalentTypeArguments(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,short,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations]):ubyte (FullOpts)
          48 ( 3.78% of base) : 109880.dasm - Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.SyntaxFactory:MissingToken(ushort):Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.SyntaxToken (FullOpts)
          48 ( 3.22% of base) : 245507.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ExpressionResolverBuilder:.cctor() (FullOpts)
          44 ( 0.72% of base) : 56334.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckConstantBounds(byte,System.Decimal,byref):ubyte (FullOpts)
          42 ( 3.52% of base) : 230638.dasm - System.Security.Cryptography.X509Certificates.ChainPal:.cctor() (FullOpts)
          38 ( 7.34% of base) : 64356.dasm - Microsoft.CodeAnalysis.CSharp.LocalStateTracingInstrumenter:GetLocalOrParameterStoreLogger(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbol,System.Nullable`1[ubyte],Microsoft.CodeAnalysis.SyntaxNode):Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol:this (FullOpts)
          32 ( 2.96% of base) : 245053.dasm - Microsoft.Extensions.DependencyInjection.ActivatorUtilities:.cctor() (FullOpts)
          30 (10.64% of base) : 292192.dasm - System.Net.NetEventSource:WriteEvent(int,System.String,int,int,int,int,int,int,int):this (FullOpts)
          28 ( 1.75% of base) : 235007.dasm - System.Text.Json.Utf8JsonReader:ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(ubyte):ubyte:this (FullOpts)
          27 ( 3.76% of base) : 30513.dasm - Internal.TypeSystem.CallingConventionExtensions:AccumulateCallingConventions(int,Internal.TypeSystem.MetadataType):int (FullOpts)
          26 ( 2.69% of base) : 277552.dasm - System.Formats.Tar.TarWriter:WriteEntryInternal(System.Formats.Tar.TarEntry):this (FullOpts)
          26 ( 1.83% of base) : 234963.dasm - System.Text.Json.Utf8JsonReader:ConsumeNextTokenFromLastNonCommentToken():ubyte:this (FullOpts)
          25 ( 2.36% of base) : 273473.dasm - System.Diagnostics.PerformanceCounterLib:get_CategoryTable():System.Collections.Hashtable:this (FullOpts)
          24 ( 4.46% of base) : 117047.dasm - Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory:DeclareFunctionStatement(System.String,Microsoft.CodeAnalysis.VisualBasic.Syntax.LiteralExpressionSyntax):Microsoft.CodeAnalysis.VisualBasic.Syntax.DeclareStatementSyntax (FullOpts)
          24 ( 4.25% of base) : 235392.dasm - System.Text.Json.JsonSerializer:TryGetReferenceForValue(System.Object,byref,System.Text.Json.Utf8JsonWriter):ubyte (FullOpts)

Top method improvements (bytes):
       -4000 (-23.41% of base) : 221206.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -3734 (-31.16% of base) : 19198.dasm - System.SpanHelpers:LastIndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
       -3593 (-35.75% of base) : 190558.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -3562 (-36.74% of base) : 149896.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -3505 (-29.73% of base) : 19179.dasm - System.SpanHelpers:IndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
       -3270 (-32.49% of base) : 19173.dasm - System.SpanHelpers:IndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
       -3265 (-32.60% of base) : 19192.dasm - System.SpanHelpers:LastIndexOfAny[System.Numerics.Vector`1[float]](byref,System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],int):int (FullOpts)
       -3230 (-45.22% of base) : 135892.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
       -2680 (-14.19% of base) : 148795.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2680 (-14.19% of base) : 189480.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2622 (-11.80% of base) : 147202.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -2622 (-11.80% of base) : 187929.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -2268 (-43.58% of base) : 90512.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForRetargetingAssembly(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref,Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol) (FullOpts)
       -1802 (-43.61% of base) : 92548.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousTypeTemplateSymbol:.ctor(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager,Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor):this (FullOpts)
       -1651 (-50.74% of base) : 57863.dasm - Microsoft.CodeAnalysis.CSharp.PatternExplainer:<SamplePatternForPathToDagNode>g__gatherConstraintsAndEvaluations|3_1(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode],byref,byref) (FullOpts)
       -1578 (-20.87% of base) : 233051.dasm - System.Speech.Internal.SrgsCompiler.Backend:InitFromBinaryGrammar(System.Speech.Internal.StreamMarshaler):this (FullOpts)
       -1483 (-38.60% of base) : 90513.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForFileAssembly(Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager+AssemblyDataForFile,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref,Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol) (FullOpts)
       -1240 (-17.98% of base) : 273256.dasm - System.Diagnostics.FileVersionInfo:GetVersionInfoForCodePage(ulong,System.String):ubyte:this (FullOpts)
       -1209 (-32.99% of base) : 64593.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:CreateAndPopulateSpanFromInlineArray(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],ubyte,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol]):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
       -1145 (-7.88% of base) : 59906.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor`2[double,System.Nullable`1[int]]:VisitInternal(Microsoft.CodeAnalysis.CSharp.BoundNode,double):System.Nullable`1[int]:this (FullOpts)

Top method regressions (percentages):
          18 (17.48% of base) : 185680.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[double](System.Func`2[double,System.Numerics.Vector`1[float]],double):System.Numerics.Vector`1[float]:this (FullOpts)
          18 (17.31% of base) : 185679.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[int](System.Func`2[int,System.Numerics.Vector`1[float]],int):System.Numerics.Vector`1[float]:this (FullOpts)
          18 (17.31% of base) : 185682.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[long](System.Func`2[long,System.Numerics.Vector`1[float]],long):System.Numerics.Vector`1[float]:this (FullOpts)
          18 (17.31% of base) : 185681.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[System.Numerics.Vector`1[float]](System.Func`2[System.Numerics.Vector`1[float],System.Numerics.Vector`1[float]],System.Numerics.Vector`1[float]):System.Numerics.Vector`1[float]:this (FullOpts)
          18 (16.82% of base) : 185676.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[System.__Canon](System.Func`2[System.__Canon,System.Numerics.Vector`1[float]],System.__Canon):System.Numerics.Vector`1[float]:this (FullOpts)
          18 (16.67% of base) : 185678.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[short](System.Func`2[short,System.Numerics.Vector`1[float]],short):System.Numerics.Vector`1[float]:this (FullOpts)
          18 (16.67% of base) : 185677.dasm - Roslyn.Utilities.SingleInitNullable`1[System.Numerics.Vector`1[float]]:Initialize[ubyte](System.Func`2[ubyte,System.Numerics.Vector`1[float]],ubyte):System.Numerics.Vector`1[float]:this (FullOpts)
          71 (14.73% of base) : 277858.dasm - System.IO.Compression.ZipArchiveEntry:LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded():ubyte:this (FullOpts)
           3 (14.29% of base) : 197729.dasm - Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)
           3 (14.29% of base) : 157287.dasm - Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)
          30 (10.64% of base) : 292192.dasm - System.Net.NetEventSource:WriteEvent(int,System.String,int,int,int,int,int,int,int):this (FullOpts)
           2 (10.53% of base) : 193193.dasm - Microsoft.CodeAnalysis.Operations.BranchOperation:MoveNext(int,int):System.ValueTuple`3[ubyte,int,int]:this (FullOpts)
           2 (10.53% of base) : 152619.dasm - Microsoft.CodeAnalysis.Operations.BranchOperation:MoveNext(int,int):System.ValueTuple`3[ubyte,int,int]:this (FullOpts)
          18 (10.00% of base) : 299897.dasm - System.Runtime.Caching.CacheMemoryMonitor:get_AutoPrivateBytesLimit():long (FullOpts)
          77 ( 9.51% of base) : 175324.dasm - Microsoft.Build.Logging.BuildEventArgsReader:Read():Microsoft.Build.Framework.BuildEventArgs:this (FullOpts)
          69 ( 8.89% of base) : 70036.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap:GetEntry(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax,Microsoft.CodeAnalysis.Text.SourceText,Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax]):Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax]:this (FullOpts)
          14 ( 8.54% of base) : 65687.dasm - Microsoft.CodeAnalysis.CSharp.TypeUnification:CanUnifyHelper(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,byref):ubyte (FullOpts)
           8 ( 8.25% of base) : 278751.dasm - System.IO.Hashing.XxHashShared:DeriveSecretFromSeed(ulong,ulong) (FullOpts)
           8 ( 8.25% of base) : 184614.dasm - System.IO.Hashing.XxHashShared:DeriveSecretFromSeed(ulong,ulong) (FullOpts)
          38 ( 7.34% of base) : 64356.dasm - Microsoft.CodeAnalysis.CSharp.LocalStateTracingInstrumenter:GetLocalOrParameterStoreLogger(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbol,System.Nullable`1[ubyte],Microsoft.CodeAnalysis.SyntaxNode):Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol:this (FullOpts)

Top method improvements (percentages):
         -79 (-96.34% of base) : 171184.dasm - Microsoft.Build.Framework.NativeMethods:get_IsBSD():ubyte (FullOpts)
         -43 (-84.31% of base) : 98447.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField:IContextualNamedEntity_AssociateWithMetadataWriter(Microsoft.Cci.MetadataWriter):this (FullOpts)
         -11 (-78.57% of base) : 158527.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
         -11 (-78.57% of base) : 198952.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
         -16 (-72.73% of base) : 259549.dasm - System.Collections.Concurrent.ConcurrentDictionaryTypeProps`1[ubyte]:IsWriteAtomicPrivate():ubyte (FullOpts)
         -34 (-70.83% of base) : 21117.dasm - System.Globalization.CalendricalCalculationsHelper:MiddayAtPersianObservationSite(double):double (FullOpts)
         -27 (-69.23% of base) : 23386.dasm - System.Runtime.Intrinsics.Vector128:Sum[int](System.Runtime.Intrinsics.Vector128`1[int]):int (FullOpts)
         -24 (-68.57% of base) : 248663.dasm - Newtonsoft.Json.Bson.Utilities.CollectionUtils:ArrayEmpty[ubyte]():ubyte[] (FullOpts)
         -63 (-66.32% of base) : 166647.dasm - Newtonsoft.Json.Converters.UnixDateTimeConverter:.cctor() (FullOpts)
         -27 (-62.79% of base) : 20856.dasm - System.Numerics.Vector:Sum[long](System.Numerics.Vector`1[long]):long (FullOpts)
         -10 (-62.50% of base) : 198953.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Infinity():ulong:this (FullOpts)
         -10 (-62.50% of base) : 158528.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Infinity():ulong:this (FullOpts)
         -26 (-61.90% of base) : 21067.dasm - System.Numerics.Vector`1[long]:.ctor(long):this (FullOpts)
         -50 (-60.98% of base) : 272821.dasm - System.Diagnostics.EventLogEntry:.cctor() (FullOpts)
         -50 (-60.98% of base) : 278008.dasm - System.IO.Compression.ZipHelper:.cctor() (FullOpts)
        -642 (-60.06% of base) : 21466.dasm - System.Buffers.Text.Base64:Avx512Encode(byref,byref,ulong,int,int,ulong,ulong) (FullOpts)
         -42 (-59.15% of base) : 24165.dasm - System.Runtime.Intrinsics.Vector64:Create[short](short):System.Runtime.Intrinsics.Vector64`1[short] (FullOpts)
        -159 (-59.11% of base) : 24187.dasm - System.Runtime.Intrinsics.Vector64:CreateSequence[int](int,int):System.Runtime.Intrinsics.Vector64`1[int] (FullOpts)
        -744 (-57.94% of base) : 162967.dasm - Microsoft.VisualBasic.FileIO.TextFieldParser:ValidateDelimiters(System.String[]):this (FullOpts)
         -11 (-57.89% of base) : 23389.dasm - System.Runtime.Intrinsics.Vector128:Sum[long](System.Runtime.Intrinsics.Vector128`1[long]):long (FullOpts)

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

Total bytes of base: 285588718 (overridden on cmd)
Total bytes of diff: 283419732 (overridden on cmd)
Total bytes of delta: -2168986 (-0.76 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         459 : 185845.dasm (7.88% of base)
         392 : 59387.dasm (6.33% of base)
         346 : 658566.dasm (4.34% of base)
         327 : 535650.dasm (2.91% of base)
         327 : 539532.dasm (3.00% of base)
         327 : 405962.dasm (2.90% of base)
         323 : 90130.dasm (1.72% of base)
         318 : 57344.dasm (2.80% of base)
         208 : 55453.dasm (2.81% of base)
         180 : 191051.dasm (1.11% of base)
         163 : 616150.dasm (3.08% of base)
         145 : 279019.dasm (1.44% of base)
         139 : 635545.dasm (0.75% of base)
         137 : 660187.dasm (5.26% of base)
         132 : 62304.dasm (4.96% of base)
         132 : 643422.dasm (1.47% of base)
         129 : 660340.dasm (1.59% of base)
         128 : 417050.dasm (3.07% of base)
         128 : 415890.dasm (3.07% of base)
         128 : 420660.dasm (3.07% of base)

Top file improvements (bytes):
       -7186 : 368493.dasm (-53.69% of base)
       -5763 : 668186.dasm (-21.70% of base)
       -5716 : 73998.dasm (-34.31% of base)
       -5630 : 70047.dasm (-33.92% of base)
       -5563 : 371834.dasm (-65.73% of base)
       -5498 : 368645.dasm (-63.81% of base)
       -3805 : 369646.dasm (-71.39% of base)
       -3767 : 370670.dasm (-70.48% of base)
       -3752 : 369377.dasm (-40.03% of base)
       -3445 : 368365.dasm (-46.59% of base)
       -3271 : 359683.dasm (-47.50% of base)
       -3204 : 368557.dasm (-29.51% of base)
       -3147 : 638214.dasm (-36.49% of base)
       -3129 : 444218.dasm (-44.04% of base)
       -3115 : 370532.dasm (-60.16% of base)
       -3094 : 371297.dasm (-63.98% of base)
       -3025 : 371594.dasm (-27.86% of base)
       -2883 : 667868.dasm (-43.05% of base)
       -2766 : 434179.dasm (-26.45% of base)
       -2720 : 128729.dasm (-39.20% of base)

76 total files with Code Size differences (37 improved, 39 regressed), 20 unchanged.

Top method regressions (bytes):
         459 ( 7.88% of base) : 185845.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper:ResolveBounds(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo],byref,Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds (Tier1)
         392 ( 6.33% of base) : 59387.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper:ResolveBounds(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo],byref,Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds (Tier1)
         346 ( 4.34% of base) : 658566.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState,System.__Canon]:VisitSwitchStatement(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
         327 ( 2.91% of base) : 535650.dasm - System.Formats.Asn1.WellKnownOids:GetContents(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ubyte] (Tier1)
         327 ( 3.00% of base) : 539532.dasm - System.Formats.Asn1.WellKnownOids:GetContents(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ubyte] (Tier1)
         327 ( 2.90% of base) : 405962.dasm - System.Formats.Asn1.WellKnownOids:GetContents(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ubyte] (Tier1)
         323 ( 1.72% of base) : 90130.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
         318 ( 2.80% of base) : 57344.dasm - Microsoft.Interop.BoundGenerators:Create(System.Collections.Immutable.ImmutableArray`1[Microsoft.Interop.TypePositionInfo],Microsoft.Interop.IMarshallingGeneratorResolver,Microsoft.Interop.StubCodeContext,Microsoft.Interop.IMarshallingGenerator,byref):Microsoft.Interop.BoundGenerators (Tier1)
         208 ( 2.81% of base) : 55453.dasm - Microsoft.CodeAnalysis.CSharp.MethodCompiler:CompileMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,int,byref,Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.CSharp.TypeCompilationState):this (Tier1)
         180 ( 1.11% of base) : 191051.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindClassCreationExpression(Microsoft.CodeAnalysis.SyntaxNode,System.String,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
         163 ( 3.08% of base) : 616150.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:WriteNumbers(System.Text.Json.JsonWriterOptions,System.String):this (Tier1-OSR)
         145 ( 1.44% of base) : 279019.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         139 ( 0.75% of base) : 635545.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindAttributeCore(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundAttribute:this (Tier1)
         137 ( 5.26% of base) : 660187.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5094_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         132 ( 1.47% of base) : 643422.dasm - Microsoft.Cci.MetadataWriter:PopulateMethodTableRows(int[]):this (Tier1-OSR)
         132 ( 4.96% of base) : 62304.dasm - Microsoft.Interop.ComMethodInfo:GetMethodsFromInterface(System.ValueTuple`2[Microsoft.Interop.ComInterfaceInfo,Microsoft.CodeAnalysis.INamedTypeSymbol],System.Threading.CancellationToken):Microsoft.Interop.SequenceEqualImmutableArray`1[Microsoft.Interop.DiagnosticOr`1[System.ValueTuple`2[Microsoft.Interop.ComMethodInfo,Microsoft.CodeAnalysis.IMethodSymbol]]] (Tier1)
         129 ( 1.59% of base) : 660340.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInlineArrayElementRefMethod:GenerateMethodBody(Microsoft.CodeAnalysis.CSharp.TypeCompilationState,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
         128 ( 3.07% of base) : 417050.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__Vectorized256|227_2[double,double,System.Numerics.Tensors.TensorPrimitives+RoundToEvenOperator`1[double]](byref,byref,ulong) (Tier1)
         128 ( 3.07% of base) : 420660.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__Vectorized256|227_2[double,double,System.Numerics.Tensors.TensorPrimitives+RoundToEvenOperator`1[double]](byref,byref,ulong) (Tier1)
         128 ( 3.07% of base) : 415890.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__Vectorized256|227_2[float,float,System.Numerics.Tensors.TensorPrimitives+RoundToEvenOperator`1[float]](byref,byref,ulong) (Tier1)

Top method improvements (bytes):
       -7186 (-53.69% of base) : 368493.dasm - System.SpanTests.SpanTests:TestMatchMany_Char() (Tier1-OSR)
       -5763 (-21.70% of base) : 668186.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex33236_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
       -5716 (-34.31% of base) : 73998.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
       -5630 (-33.92% of base) : 70047.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
       -5563 (-65.73% of base) : 371834.dasm - System.SpanTests.SpanTests:TestMatchFour_Char() (Tier1-OSR)
       -5498 (-63.81% of base) : 368645.dasm - System.SpanTests.SpanTests:TestMatchFive_Char() (Tier1-OSR)
       -3805 (-71.39% of base) : 369646.dasm - System.SpanTests.ReadOnlySpanTests:TestMatchFour_Char() (Tier1-OSR)
       -3767 (-70.48% of base) : 370670.dasm - System.SpanTests.ReadOnlySpanTests:TestMatchFive_Char() (Tier1-OSR)
       -3752 (-40.03% of base) : 369377.dasm - System.SpanTests.SpanTests:TestMatchMany_Byte() (Tier1-OSR)
       -3445 (-46.59% of base) : 368365.dasm - System.SpanTests.ReadOnlySpanTests:TestMatchMany_Char() (Tier1-OSR)
       -3271 (-47.50% of base) : 359683.dasm - System.Linq.Tests.EnumerableTests+AnagramEqualityComparer:Equals(System.String,System.String):ubyte:this (Tier1)
       -3204 (-29.51% of base) : 368557.dasm - System.SpanTests.SpanTests:TestMatchTwo_Byte() (Tier1-OSR)
       -3147 (-36.49% of base) : 638214.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<BindNamespaceOrTypeOrAliasSymbol>g__bindAlias|1005_3(byref):Microsoft.CodeAnalysis.CSharp.Binder+NamespaceOrTypeOrAliasSymbolWithAnnotations:this (Tier1)
       -3129 (-44.04% of base) : 444218.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (Tier1)
       -3115 (-60.16% of base) : 370532.dasm - System.SpanTests.SpanTests:DefaultFilledIndexOfFive_Char() (Tier1-OSR)
       -3094 (-63.98% of base) : 371297.dasm - System.SpanTests.SpanTests:DefaultFilledIndexOfFour_Char() (Tier1-OSR)
       -3025 (-27.86% of base) : 371594.dasm - System.SpanTests.SpanTests:TestMatchThree_Byte() (Tier1-OSR)
       -2883 (-43.05% of base) : 667868.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter:LowerDecisionDagCore(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundStatement]:this (Tier1)
       -2766 (-26.45% of base) : 434179.dasm - System.Reflection.Emit.CustomAttributeBuilder:.ctor(System.Reflection.ConstructorInfo,System.Object[],System.Reflection.PropertyInfo[],System.Object[],System.Reflection.FieldInfo[],System.Object[]):this (Tier1)
       -2720 (-39.20% of base) : 128729.dasm - Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns.PatternBuilder:Build(System.String):Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern:this (Tier1)

Top method regressions (percentages):
         102 (15.36% of base) : 226606.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (Tier1)
         102 (15.36% of base) : 524552.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (Tier1)
         102 (15.36% of base) : 216085.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (Tier1)
         102 (15.36% of base) : 238114.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (Tier1)
          99 (14.95% of base) : 543577.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (Tier1)
          98 (14.92% of base) : 456405.dasm - System.Convert:ConvertToBase64Array(ulong,ulong,int,int,ubyte):int (Tier1)
          22 (14.47% of base) : 61446.dasm - Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)
          22 (14.47% of base) : 83801.dasm - Microsoft.CodeAnalysis.Shared.TestHooks.AsynchronousOperationListenerProvider:get_IsEnabled():ubyte (Tier1)
          43 (11.11% of base) : 64465.dasm - NuGet.Configuration.AddItem:GetValueAsPath():System.String:this (Tier1)
           4 (10.81% of base) : 60587.dasm - NuGet.Protocol.Core.Types.ResourceProvider:.ctor(System.Type,System.String):this (Tier1)
           2 (10.53% of base) : 92951.dasm - Microsoft.CodeAnalysis.Operations.TypeOfOperation:MoveNext(int,int):System.ValueTuple`3[ubyte,int,int]:this (Tier1)
          43 ( 9.98% of base) : 188655.dasm - Microsoft.CodeAnalysis.CSharp.BoundCall:.ctor(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],System.Collections.Immutable.ImmutableArray`1[ubyte],ubyte,ubyte,ubyte,System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.BitVector,ubyte,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):this (Tier1)
          24 ( 9.72% of base) : 447052.dasm - System.Xml.XmlDiff.XmlDiffDocument:InsertAttribute(System.Xml.XmlDiff.XmlDiffElement,System.Xml.XmlDiff.XmlDiffAttribute):this (Tier1)
          13 ( 8.18% of base) : 445922.dasm - System.Xml.Xsl.Xslt.QilGenerator:CreateGlobalVarPars():this (Tier1)
         459 ( 7.88% of base) : 185845.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper:ResolveBounds(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo],byref,Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds (Tier1)
          34 ( 7.87% of base) : 281243.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          34 ( 7.87% of base) : 318551.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          34 ( 7.87% of base) : 130455.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          34 ( 7.87% of base) : 675312.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)
          34 ( 7.87% of base) : 386647.dasm - System.Threading.SpinWait:SpinOnceCore(int):this (Tier1)

Top method improvements (percentages):
         -79 (-96.34% of base) : 314290.dasm - System.PlatformDetection:get_IsAndroid():ubyte (Tier1)
         -79 (-96.34% of base) : 314288.dasm - System.PlatformDetection:get_IsBrowser():ubyte (Tier1)
         -71 (-95.95% of base) : 632546.dasm - System.PlatformDetection:get_IsMobile():ubyte (Tier1)
         -75 (-92.59% of base) : 201861.dasm - System.PlatformDetection:get_IsWindows():ubyte (Tier1)
       -3805 (-71.39% of base) : 369646.dasm - System.SpanTests.ReadOnlySpanTests:TestMatchFour_Char() (Tier1-OSR)
       -3767 (-70.48% of base) : 370670.dasm - System.SpanTests.ReadOnlySpanTests:TestMatchFive_Char() (Tier1-OSR)
         -81 (-68.64% of base) : 326942.dasm - System.PlatformDetection:get_IsNotWindows():ubyte (Tier1)
       -5563 (-65.73% of base) : 371834.dasm - System.SpanTests.SpanTests:TestMatchFour_Char() (Tier1-OSR)
         -66 (-64.08% of base) : 542105.dasm - System.PlatformDetection:get_IsFreeBSD():ubyte (Tier1)
         -66 (-64.08% of base) : 542106.dasm - System.PlatformDetection:get_Isillumos():ubyte (Tier1)
         -66 (-64.08% of base) : 542107.dasm - System.PlatformDetection:get_IsSolaris():ubyte (Tier1)
       -3094 (-63.98% of base) : 371297.dasm - System.SpanTests.SpanTests:DefaultFilledIndexOfFour_Char() (Tier1-OSR)
         -71 (-63.96% of base) : 328483.dasm - System.PlatformDetection:get_IsNotBrowser():ubyte (Tier1)
       -5498 (-63.81% of base) : 368645.dasm - System.SpanTests.SpanTests:TestMatchFive_Char() (Tier1-OSR)
         -25 (-60.98% of base) : 415906.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[double](int,int):System.Buffers.BoundedMemory`1[double] (Tier1)
         -25 (-60.98% of base) : 417506.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)
         -25 (-60.98% of base) : 419489.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[System.Half](int,int):System.Buffers.BoundedMemory`1[System.Half] (Tier1)
         -25 (-60.98% of base) : 421476.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[ubyte](int,int):System.Buffers.BoundedMemory`1[ubyte] (Tier1)
         -25 (-60.98% of base) : 561282.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[ubyte](int,int):System.Buffers.BoundedMemory`1[ubyte] (Tier1)
         -25 (-60.98% of base) : 373445.dasm - System.Buffers.BoundedMemory:AllocateWithoutDataPopulation[ushort](int,int):System.Buffers.BoundedMemory`1[ushort] (Tier1)

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

Total bytes of base: 137193054 (overridden on cmd)
Total bytes of diff: 134624292 (overridden on cmd)
Total bytes of delta: -2568762 (-1.87 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         457 : 87599.dasm (6.12% of base)
         320 : 183621.dasm (10.19% of base)
         261 : 297797.dasm (3.45% of base)
         206 : 94379.dasm (3.96% of base)
         156 : 152669.dasm (2.14% of base)
         154 : 216459.dasm (4.59% of base)
         135 : 297787.dasm (2.15% of base)
         131 : 203954.dasm (3.56% of base)
         131 : 203801.dasm (3.56% of base)
         123 : 217866.dasm (1.45% of base)
         111 : 150294.dasm (2.71% of base)
         110 : 191093.dasm (2.42% of base)
         108 : 276139.dasm (3.57% of base)
         104 : 244356.dasm (3.18% of base)
         102 : 244244.dasm (3.58% of base)
         102 : 203897.dasm (2.75% of base)
         102 : 203638.dasm (2.75% of base)
          95 : 98907.dasm (3.14% of base)
          93 : 31539.dasm (2.09% of base)
          91 : 290564.dasm (4.21% of base)

Top file improvements (bytes):
       -9071 : 186603.dasm (-91.33% of base)
       -5759 : 298657.dasm (-21.70% of base)
       -4000 : 20359.dasm (-23.41% of base)
       -3593 : 5725.dasm (-35.75% of base)
       -3417 : 155051.dasm (-19.22% of base)
       -3270 : 217219.dasm (-43.90% of base)
       -3262 : 45246.dasm (-39.25% of base)
       -3262 : 51184.dasm (-39.06% of base)
       -3230 : 178010.dasm (-45.22% of base)
       -3220 : 202093.dasm (-11.85% of base)
       -3220 : 211982.dasm (-11.85% of base)
       -2973 : 218000.dasm (-74.23% of base)
       -2957 : 49919.dasm (-16.44% of base)
       -2897 : 44096.dasm (-16.40% of base)
       -2830 : 217465.dasm (-66.93% of base)
       -2766 : 203435.dasm (-15.88% of base)
       -2697 : 210901.dasm (-15.14% of base)
       -2680 : 4705.dasm (-14.19% of base)
       -2622 : 20703.dasm (-11.80% of base)
       -2550 : 300879.dasm (-10.15% of base)

88 total files with Code Size differences (47 improved, 41 regressed), 20 unchanged.

Top method regressions (bytes):
         457 ( 6.12% of base) : 87599.dasm - Castle.Proxies.TypeProxy:.cctor() (FullOpts)
         320 (10.19% of base) : 183621.dasm - System.Xml.XmlWriterApiTests.TCErrorConditionWriter:var_21(System.Xml.XmlWriterApiTests.XmlWriterUtils,int):this (FullOpts)
         261 ( 3.45% of base) : 297797.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4860_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         206 ( 3.96% of base) : 94379.dasm - System.Data.Common.SqlConvert:ChangeType2(System.Object,int,System.Type,System.IFormatProvider):System.Object (FullOpts)
         156 ( 2.14% of base) : 152669.dasm - System.Buffers.Binary.Tests.BinaryReaderUnitTests:SpanWriteAndReadBigEndianHeterogeneousStruct():this (FullOpts)
         154 ( 4.59% of base) : 216459.dasm - Castle.Proxies.EncodingProxy:.cctor() (FullOpts)
         135 ( 2.15% of base) : 297787.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4858_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         131 ( 3.56% of base) : 203801.dasm - System.Numerics.Tests.ComplexTests_GenericMath:MinMagnitudeNumberTest() (FullOpts)
         131 ( 3.56% of base) : 203954.dasm - System.Numerics.Tests.ComplexTests_GenericMath:MinMagnitudeTest() (FullOpts)
         123 ( 1.45% of base) : 217866.dasm - System.Tests.DecimalTests_GenericMath:IsIntegerTest() (FullOpts)
         111 ( 2.71% of base) : 150294.dasm - System.Memory.Tests.SequenceReader.ReaderBasicTests`1[ubyte]:UnreadSequence():this (FullOpts)
         110 ( 2.42% of base) : 191093.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateFieldDef(System.Reflection.Metadata.MetadataReader,uint,uint,ubyte):this (FullOpts)
         108 ( 3.57% of base) : 276139.dasm - System.Text.Json.Tests.Utf8JsonReaderTests:TestPartialLargeJsonReader(ubyte,int,System.String) (FullOpts)
         104 ( 3.18% of base) : 244356.dasm - Castle.Proxies.MemoryStreamProxy:.cctor() (FullOpts)
         102 ( 3.58% of base) : 244244.dasm - Castle.Proxies.StreamProxy:.cctor() (FullOpts)
         102 ( 2.75% of base) : 203638.dasm - System.Numerics.Tests.ComplexTests_GenericMath:MaxMagnitudeNumberTest() (FullOpts)
         102 ( 2.75% of base) : 203897.dasm - System.Numerics.Tests.ComplexTests_GenericMath:MaxMagnitudeTest() (FullOpts)
          95 ( 3.14% of base) : 98907.dasm - System.Data.Tests.SqlTypes.SqlDoubleTest:ThanOrEqualOperators():this (FullOpts)
          93 ( 2.09% of base) : 31539.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInterpolatedStringAppendCalls(System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundInterpolatedStringHandlerPlaceholder,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.ValueTuple`5[System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression]],ubyte,System.Collections.Immutable.ImmutableArray`1[System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`3[ubyte,ubyte,ubyte]]],int,int]:this (FullOpts)
          91 ( 4.21% of base) : 290564.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1353_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method improvements (bytes):
       -9071 (-91.33% of base) : 186603.dasm - TestType:meth1():int (FullOpts)
       -5759 (-21.70% of base) : 298657.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5070_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
       -4000 (-23.41% of base) : 20359.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -3593 (-35.75% of base) : 5725.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -3417 (-19.22% of base) : 155051.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -3270 (-43.90% of base) : 217219.dasm - System.Tests.TimeZoneInfoTests:ConvertTime_DateTime_LocalToSystem() (FullOpts)
       -3262 (-39.25% of base) : 45246.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -3262 (-39.06% of base) : 51184.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -3230 (-45.22% of base) : 178010.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
       -3220 (-11.85% of base) : 202093.dasm - System.Tests.UriCreateStringTests+<Path_Query_Fragment_TestData>d__8:MoveNext():ubyte:this (FullOpts)
       -3220 (-11.85% of base) : 211982.dasm - System.Tests.UriCreateStringTests+<Path_Query_Fragment_TestData>d__8:MoveNext():ubyte:this (FullOpts)
       -2973 (-74.23% of base) : 218000.dasm - System.Tests.TimeZoneInfoTests:ConvertTime_DateTime_PerthRules() (FullOpts)
       -2957 (-16.44% of base) : 49919.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2897 (-16.40% of base) : 44096.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2830 (-66.93% of base) : 217465.dasm - System.Tests.TimeZoneInfoTests:ConverTime_DateTime_VariousSystemTimeZonesTest() (FullOpts)
       -2766 (-15.88% of base) : 203435.dasm - System.Numerics.Tests.ComparisonTest:RunPositiveTests(System.Random) (FullOpts)
       -2697 (-15.14% of base) : 210901.dasm - (dynamicClass):WritePrimitiveContainerToXml(System.Runtime.Serialization.XmlWriterDelegator,System.Object,System.Runtime.Serialization.XmlObjectSerializerWriteContext,System.Runtime.Serialization.DataContracts.ClassDataContract) (FullOpts)
       -2680 (-14.19% of base) : 4705.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2622 (-11.80% of base) : 20703.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -2550 (-10.15% of base) : 300879.dasm - System.Text.RegularExpressions.Tests.AttRegexTests+<Match_MemberData_Cases>d__1:MoveNext():ubyte:this (FullOpts)

Top method regressions (percentages):
          45 (48.39% of base) : 194855.dasm - System.Runtime.Caching.CacheExpires:UtcCalcExpiresBucket(System.DateTime):int (FullOpts)
           5 (38.46% of base) : 242041.dasm - System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateInlineCategories_NullCategory_ThrowsArgumentNullException>b__9_0():System.Object:this (FullOpts)
           5 (38.46% of base) : 241865.dasm - System.ServiceModel.Syndication.Tests.ServiceDocumentFormatterTests+<>c:<CreateReferencedCategories_NullCategory_ThrowsArgumentNullException>b__11_0():System.Object:this (FullOpts)
          19 (26.76% of base) : 125429.dasm - System.RandomDataGenerator:GetDateTime(int):System.DateTime:this (FullOpts)
           5 (26.32% of base) : 92952.dasm - MonoTests.System.Configuration.GenericEnumConverterTest+<>c__DisplayClass16_0:<ConvertTo_NullError>b__0():System.Object:this (FullOpts)
          71 (14.73% of base) : 129485.dasm - System.IO.Compression.ZipArchiveEntry:LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded():ubyte:this (FullOpts)
           3 (14.29% of base) : 56862.dasm - Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)
          20 (13.79% of base) : 173166.dasm - System.PrivateUri.Tests.UriEscapingTest:UriUnescapeInvalid_Regex_LeftAlone():this (FullOpts)
          20 (13.79% of base) : 196432.dasm - System.Tests.ExpandEnvironmentVariables:VariableThatDoesNotExistGoesThroughUnexpanded():this (FullOpts)
           3 (13.64% of base) : 89767.dasm - System.ComponentModel.TypeConverterTests.RectangleConverterTests:get_Default():System.Drawing.Rectangle:this (FullOpts)
          20 (13.42% of base) : 225262.dasm - System.Tests.NullableTests+<>c:<GetUnderlyingType_NullType_ThrowsArgumentNullException>b__6_0():System.Object:this (FullOpts)
           3 (13.04% of base) : 222490.dasm - System.Tests.HalfTests_GenericMath:MaxValueTest() (FullOpts)
           3 (13.04% of base) : 222500.dasm - System.Tests.HalfTests_GenericMath:MinValueTest() (FullOpts)
           3 (13.04% of base) : 222518.dasm - System.Tests.HalfTests_GenericMath:MultiplicativeIdentityTest() (FullOpts)
           3 (13.04% of base) : 222549.dasm - System.Tests.HalfTests_GenericMath:OneTest() (FullOpts)
           8 (12.90% of base) : 203978.dasm - System.Numerics.Tests.ComplexTests_GenericMath:MultiplicativeIdentityTest() (FullOpts)
           8 (12.90% of base) : 203974.dasm - System.Numerics.Tests.ComplexTests_GenericMath:OneTest() (FullOpts)
          38 (12.67% of base) : 173195.dasm - System.PrivateUri.Tests.UriEscapingTest:UriUnescapeInvalid_IncompleteUtf8IriOn_LeftAlone():this (FullOpts)
          34 (12.50% of base) : 36981.dasm - DryIoc.CurrentScopeReuse:.cctor() (FullOpts)
           5 (11.90% of base) : 217984.dasm - System.Tests.EnumTests+<>c:<GetValues_NullEnumType_ThrowsArgumentNullException>b__88_0():System.Object:this (FullOpts)

Top method improvements (percentages):
        -189 (-96.92% of base) : 186591.dasm - TestType:meth1():int (FullOpts)
         -86 (-96.63% of base) : 197166.dasm - System.Runtime.InteropServices.Tests.CULongTests:get_NativeIntConstructorCannotOverflow():ubyte (FullOpts)
         -86 (-96.63% of base) : 230088.dasm - System.Security.Cryptography.Pkcs.EnvelopedCmsTests.Tests.ContentEncryptionAlgorithmTests:get_DoesNotSupportRc4():ubyte (FullOpts)
         -86 (-96.63% of base) : 230099.dasm - System.Security.Cryptography.Pkcs.EnvelopedCmsTests.Tests.KeyAgreeRecipientInfoTests:get_DoesNotSupportDiffieHellman():ubyte (FullOpts)
         -86 (-96.63% of base) : 230102.dasm - System.Security.Cryptography.Pkcs.EnvelopedCmsTests.Tests.KeyTransRecipientInfoRsaOaepCertTests:get_DoesNotSupportRsaOaepCerts():ubyte (FullOpts)
         -79 (-96.34% of base) : 34875.dasm - System.PlatformDetection:get_IsBrowser():ubyte (FullOpts)
         -79 (-96.34% of base) : 164351.dasm - System.PlatformDetection:get_IsOpenSslSupported():ubyte (FullOpts)
         -25 (-96.15% of base) : 231836.dasm - System.Security.Cryptography.ProtectedData:CheckPlatformSupport() (FullOpts)
         -19 (-95.00% of base) : 88926.dasm - System.ComponentModel.Design.Serialization.Tests.MemberRelationshipTests:Empty_Get_ReturnsExpected():this (FullOpts)
         -15 (-93.75% of base) : 54741.dasm - Microsoft.Extensions.Logging.Abstractions.NullLoggerTest:IsEnabled_AlwaysFalse():this (FullOpts)
         -84 (-93.33% of base) : 32290.dasm - System.PlatformDetection:get_IsNotBrowser():ubyte (FullOpts)
         -84 (-93.33% of base) : 154072.dasm - System.PlatformDetection:get_LocalEchoServerIsNotAvailable():ubyte (FullOpts)
        -113 (-92.62% of base) : 225237.dasm - System.Tests.DateOnlyTests:OperatorsTest() (FullOpts)
         -75 (-92.59% of base) : 38709.dasm - Microsoft.Extensions.DependencyModel.EnvironmentWrapper:IsWindows():ubyte:this (FullOpts)
         -75 (-92.59% of base) : 58644.dasm - System.PlatformDetection:get_IsWindows():ubyte (FullOpts)
         -75 (-92.59% of base) : 197167.dasm - System.Runtime.InteropServices.Tests.CLongTests:get_NativeIntConstructorCanOverflow():ubyte (FullOpts)
         -75 (-92.59% of base) : 197165.dasm - System.Runtime.InteropServices.Tests.CULongTests:get_NativeIntConstructorCanOverflow():ubyte (FullOpts)
         -75 (-92.59% of base) : 230087.dasm - System.Security.Cryptography.Pkcs.EnvelopedCmsTests.Tests.ContentEncryptionAlgorithmTests:get_SupportsRc4():ubyte (FullOpts)
       -9071 (-91.33% of base) : 186603.dasm - TestType:meth1():int (FullOpts)
         -79 (-90.80% of base) : 230092.dasm - System.Security.Cryptography.Pkcs.EnvelopedCmsTests.Tests.EdgeCasesTests:.cctor() (FullOpts)

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

Total bytes of base: 13858724 (overridden on cmd)
Total bytes of diff: 13649502 (overridden on cmd)
Total bytes of delta: -209222 (-1.51 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1007 : 751.dasm (17.83% of base)
         543 : 16063.dasm (4.23% of base)
         291 : 29383.dasm (7.30% of base)
         117 : 11080.dasm (9.34% of base)
         106 : 27572.dasm (5.56% of base)
          96 : 1380.dasm (2.21% of base)
          36 : 27492.dasm (8.11% of base)
          29 : 15202.dasm (4.67% of base)
          23 : 16381.dasm (0.99% of base)
          21 : 24436.dasm (0.40% of base)
          19 : 1214.dasm (65.52% of base)
          17 : 17367.dasm (0.85% of base)
          16 : 16065.dasm (9.20% of base)
          13 : 22411.dasm (4.04% of base)
          12 : 35940.dasm (1.17% of base)
          12 : 22645.dasm (1.00% of base)
          11 : 25229.dasm (0.59% of base)
          11 : 4678.dasm (0.41% of base)
          11 : 26275.dasm (4.87% of base)
          10 : 1216.dasm (41.67% of base)

Top file improvements (bytes):
       -4000 : 17607.dasm (-23.41% of base)
       -3562 : 22493.dasm (-36.74% of base)
       -2680 : 21021.dasm (-14.19% of base)
       -2201 : 32698.dasm (-11.65% of base)
       -1939 : 14905.dasm (-23.59% of base)
       -1778 : 33489.dasm (-1.32% of base)
       -1569 : 31107.dasm (-42.67% of base)
       -1384 : 21285.dasm (-38.18% of base)
       -1204 : 404.dasm (-19.29% of base)
       -1177 : 33041.dasm (-25.74% of base)
        -965 : 629.dasm (-40.01% of base)
        -932 : 1082.dasm (-5.35% of base)
        -785 : 25882.dasm (-32.51% of base)
        -768 : 1017.dasm (-7.29% of base)
        -767 : 30220.dasm (-38.76% of base)
        -705 : 24957.dasm (-17.53% of base)
        -693 : 25823.dasm (-16.92% of base)
        -690 : 21589.dasm (-6.09% of base)
        -678 : 26770.dasm (-14.35% of base)
        -657 : 32717.dasm (-9.89% of base)

81 total files with Code Size differences (51 improved, 30 regressed), 20 unchanged.

Top method regressions (bytes):
        1007 (17.83% of base) : 751.dasm - System.Reflection.Emit.OpCodes:.cctor() (FullOpts)
         543 ( 4.23% of base) : 16063.dasm - Microsoft.ML.Data.Conversion.Conversions:.ctor():this (FullOpts)
         291 ( 7.30% of base) : 29383.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         117 ( 9.34% of base) : 11080.dasm - FSharp.Compiler.TypedTreeOps:remapAttribImpl(FSharp.Compiler.TypedTreeOps+RemapContext,FSharp.Compiler.TypedTreeOps+Remap,FSharp.Compiler.TypedTree+Attrib):FSharp.Compiler.TypedTree+Attrib (FullOpts)
         106 ( 5.56% of base) : 27572.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:MergeEquivalentTypeArguments(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,short,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations]):ubyte (FullOpts)
          96 ( 2.21% of base) : 1380.dasm - BepuPhysics.Trees.Tree:FindPartitionBinned(byref,int,int,byref,byref,byref,byref,byref):this (FullOpts)
          36 ( 8.11% of base) : 27492.dasm - Microsoft.CodeAnalysis.CSharp.BoundForEachStatement:Update(Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo,Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol],Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo,Microsoft.CodeAnalysis.CSharp.BoundStatement,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol):Microsoft.CodeAnalysis.CSharp.BoundForEachStatement:this (FullOpts)
          29 ( 4.67% of base) : 15202.dasm - System.Threading.Tasks.Task:InternalRunSynchronously(System.Threading.Tasks.TaskScheduler,ubyte):this (FullOpts)
          23 ( 0.99% of base) : 16381.dasm - System.Threading.Tasks.Task:WaitAllCore(System.Threading.Tasks.Task[],int,System.Threading.CancellationToken):ubyte (FullOpts)
          21 ( 0.40% of base) : 24436.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckConstantBounds(byte,System.Decimal,byref):ubyte (FullOpts)
          19 (65.52% of base) : 1214.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Box():BepuPhysics.Collidables.BoxWide:this (FullOpts)
          17 ( 0.85% of base) : 17367.dasm - Microsoft.ML.Data.TextLoader+Parser:ParseSlotNames(Microsoft.ML.Data.TextLoader,System.ReadOnlyMemory`1[ushort],Microsoft.ML.Data.TextLoader+ColInfo[],Microsoft.ML.Data.VBuffer`1[System.ReadOnlyMemory`1[ushort]][]) (FullOpts)
          16 ( 9.20% of base) : 16065.dasm - Microsoft.ML.Data.Conversion.Conversions:AddStd[int,float](Microsoft.ML.Data.ValueMapper`2[int,float]):this (FullOpts)
          13 ( 4.04% of base) : 22411.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:DecodeWellKnownAttribute(byref):this (FullOpts)
          12 ( 1.00% of base) : 22645.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ImportInfo,System.Collections.Immutable.ImmutableArray`1[System.__Canon]]:TryUpdateInternal(System.Collections.Concurrent.ConcurrentDictionary`2+Tables[Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ImportInfo,System.Collections.Immutable.ImmutableArray`1[System.__Canon]],Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ImportInfo,System.Nullable`1[int],System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):ubyte:this (FullOpts)
          12 ( 1.17% of base) : 35940.dasm - System.Management.Automation.Runspaces.Runspace:UpdateRunspaceAvailability(int,ubyte,System.Nullable`1[System.Guid]):this (FullOpts)
          11 ( 4.87% of base) : 26275.dasm - Microsoft.CodeAnalysis.CSharp.NullabilityRewriter:VisitLocalDeclaration(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
          11 ( 0.59% of base) : 25229.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:GetEffectiveParametersInExpandedForm[System.__Canon](System.__Canon,int,System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte],ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Binder,byref):Microsoft.CodeAnalysis.CSharp.OverloadResolution+EffectiveParameters (FullOpts)
          11 ( 0.41% of base) : 4678.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (FullOpts)
          10 (41.67% of base) : 1216.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Cylinder():BepuPhysics.Collidables.CylinderWide:this (FullOpts)

Top method improvements (bytes):
       -4000 (-23.41% of base) : 17607.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -3562 (-36.74% of base) : 22493.dasm - Microsoft.CodeAnalysis.WellKnownMembers:.cctor() (FullOpts)
       -2680 (-14.19% of base) : 21021.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -2201 (-11.65% of base) : 32698.dasm - System.Management.Automation.Runspaces.InitialSessionState:get_BuiltInAliases():System.Management.Automation.Runspaces.SessionStateAliasEntry[] (FullOpts)
       -1939 (-23.59% of base) : 14905.dasm - SixLabors.ImageSharp.Color:.cctor() (FullOpts)
       -1778 (-1.32% of base) : 33489.dasm - System.Management.Automation.Runspaces.TypeTable:Process_Types_Ps1Xml(System.String,System.Collections.Concurrent.ConcurrentBag`1[System.String]):this (FullOpts)
       -1569 (-42.67% of base) : 31107.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousTypeTemplateSymbol:.ctor(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager,Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor):this (FullOpts)
       -1384 (-38.18% of base) : 21285.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForFileAssembly(Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager+AssemblyDataForFile,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref,Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol) (FullOpts)
       -1204 (-19.29% of base) : 404.dasm - System.Diagnostics.FileVersionInfo:GetVersionInfoForCodePage(ulong,System.String):ubyte:this (FullOpts)
       -1177 (-25.74% of base) : 33041.dasm - System.Management.Automation.LanguagePrimitives:.cctor() (FullOpts)
        -965 (-40.01% of base) : 629.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -932 (-5.35% of base) : 1082.dasm - BepuPhysics.CollisionDetection.CollisionTasks.BoxPairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
        -785 (-32.51% of base) : 25882.dasm - Microsoft.CodeAnalysis.SpecialMembers:.cctor() (FullOpts)
        -768 (-7.29% of base) : 1017.dasm - BepuPhysics.CollisionDetection.SweepTasks.GJKDistanceTester`6[BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder]:FindClosestPoint(byref,byref,byref,byref,byref) (FullOpts)
        -767 (-38.76% of base) : 30220.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter:LowerDecisionDagCore(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundStatement]:this (FullOpts)
        -705 (-17.53% of base) : 24957.dasm - Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor:AddTypeParameterConstraints(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.ITypeSymbol]):this (FullOpts)
        -693 (-16.92% of base) : 25823.dasm - Microsoft.CodeAnalysis.CSharp.Binder:MethodIsCompatibleWithDelegateOrFunctionPointer(Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
        -690 (-6.09% of base) : 21589.dasm - System.Text.RegularExpressions.RegexCompiler:.cctor() (FullOpts)
        -678 (-14.35% of base) : 26770.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ConvertPatternExpression(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,byref,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
        -657 (-9.89% of base) : 32717.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (FullOpts)

Top method regressions (percentages):
          19 (65.52% of base) : 1214.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Box():BepuPhysics.Collidables.BoxWide:this (FullOpts)
          10 (41.67% of base) : 1216.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Cylinder():BepuPhysics.Collidables.CylinderWide:this (FullOpts)
        1007 (17.83% of base) : 751.dasm - System.Reflection.Emit.OpCodes:.cctor() (FullOpts)
           3 (14.29% of base) : 29752.dasm - Microsoft.CodeAnalysis.CodeGen.LocalDebugId:.cctor() (FullOpts)
         117 ( 9.34% of base) : 11080.dasm - FSharp.Compiler.TypedTreeOps:remapAttribImpl(FSharp.Compiler.TypedTreeOps+RemapContext,FSharp.Compiler.TypedTreeOps+Remap,FSharp.Compiler.TypedTree+Attrib):FSharp.Compiler.TypedTree+Attrib (FullOpts)
          16 ( 9.20% of base) : 16065.dasm - Microsoft.ML.Data.Conversion.Conversions:AddStd[int,float](Microsoft.ML.Data.ValueMapper`2[int,float]):this (FullOpts)
          36 ( 8.11% of base) : 27492.dasm - Microsoft.CodeAnalysis.CSharp.BoundForEachStatement:Update(Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo,Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol],Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo,Microsoft.CodeAnalysis.CSharp.BoundStatement,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol):Microsoft.CodeAnalysis.CSharp.BoundForEachStatement:this (FullOpts)
         291 ( 7.30% of base) : 29383.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
           9 ( 6.87% of base) : 12706.dasm - FSharp.Compiler.Lexer+Ranges+isInt64BadMax@45:Invoke(System.String):ubyte:this (FullOpts)
           2 ( 6.25% of base) : 1212.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Capsule():BepuPhysics.Collidables.CapsuleWide:this (FullOpts)
           7 ( 5.93% of base) : 25132.dasm - System.Collections.Immutable.DisposableEnumeratorAdapter`2[System.__Canon,System.Collections.Immutable.ImmutableHashSet`1+Enumerator[System.__Canon]]:get_Current():System.__Canon:this (FullOpts)
         106 ( 5.56% of base) : 27572.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:MergeEquivalentTypeArguments(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,short,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations]):ubyte (FullOpts)
           3 ( 5.17% of base) : 31040.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:VisitScope(Microsoft.CodeAnalysis.CSharp.BoundScope):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
           8 ( 5.03% of base) : 1444.dasm - BepuPhysics.Helpers:BuildOrthonormalBasis(byref,byref,byref) (FullOpts)
          11 ( 4.87% of base) : 26275.dasm - Microsoft.CodeAnalysis.CSharp.NullabilityRewriter:VisitLocalDeclaration(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
          29 ( 4.67% of base) : 15202.dasm - System.Threading.Tasks.Task:InternalRunSynchronously(System.Threading.Tasks.TaskScheduler,ubyte):this (FullOpts)
           6 ( 4.58% of base) : 7078.dasm - FSharp.Compiler.Lexer+Ranges+isInt32BadMax@42:Invoke(System.String):ubyte:this (FullOpts)
           3 ( 4.29% of base) : 643.dasm - System.Number:<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(uint):System.String (FullOpts)
         543 ( 4.23% of base) : 16063.dasm - Microsoft.ML.Data.Conversion.Conversions:.ctor():this (FullOpts)
           3 ( 4.23% of base) : 30510.dasm - Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator:AllocateTemp(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.SyntaxNode,ubyte):Microsoft.CodeAnalysis.CodeGen.LocalDefinition:this (FullOpts)

Top method improvements (percentages):
         -79 (-96.34% of base) : 3237.dasm - Microsoft.Build.Shared.NativeMethodsShared:get_IsBSD():ubyte (FullOpts)
         -11 (-78.57% of base) : 20421.dasm - Microsoft.CodeAnalysis.RealParser+FloatFloatingPointType:get_Zero():ulong:this (FullOpts)
         -83 (-49.40% of base) : 3234.dasm - Microsoft.Build.Shared.NativeMethodsShared:get_IsWindows():ubyte (FullOpts)
        -150 (-46.88% of base) : 14960.dasm - SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
        -190 (-46.80% of base) : 36625.dasm - System.Dynamic.Utils.TypeExtensions:MatchesArgumentTypes(System.Reflection.MethodInfo,System.Type[]):ubyte (FullOpts)
        -181 (-46.41% of base) : 28673.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetCommonTypeOrReturnType[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (FullOpts)
         -54 (-46.15% of base) : 21114.dasm - Roslyn.Utilities.StringTable:TextEqualsASCII(System.String,System.ReadOnlySpan`1[ubyte]):ubyte (FullOpts)
        -261 (-45.87% of base) : 35004.dasm - System.Management.Automation.DotNetAdapter:SameSignature(System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)
        -374 (-44.21% of base) : 22494.dasm - Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor:InitializeFromStream(System.IO.Stream,System.String[]):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor] (FullOpts)
        -168 (-43.98% of base) : 23842.dasm - Microsoft.CodeAnalysis.CSharp.Binder:RemoveInvalidConstraints(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax]],ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)
        -460 (-42.95% of base) : 28377.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousTypeConstructorSymbol:.ctor(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousTypePropertySymbol]):this (FullOpts)
       -1569 (-42.67% of base) : 31107.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager+AnonymousTypeTemplateSymbol:.ctor(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager,Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor):this (FullOpts)
        -475 (-42.37% of base) : 23843.dasm - Microsoft.CodeAnalysis.CSharp.Binder:RemoveInvalidConstraints(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax],ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause (FullOpts)
        -378 (-41.04% of base) : 28053.dasm - Microsoft.CodeAnalysis.CSharp.DiagnosticsPass:CheckForDeconstructionAssignmentToSelf(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression):this (FullOpts)
         -86 (-40.95% of base) : 3213.dasm - FSharp.Compiler.CompilerImports:isPoundRReference@325(FSharp.Compiler.Text.Range):ubyte (FullOpts)
        -280 (-40.40% of base) : 33130.dasm - System.Dynamic.Utils.ExpressionUtils:ValidateArgumentTypes(System.Reflection.MethodBase,int,byref,System.String) (FullOpts)
        -283 (-40.31% of base) : 22601.dasm - System.Linq.ImmutableArrayExtensions:SequenceEqual[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant],System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]](System.Collections.Immutable.ImmutableArray`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]],System.Collections.Immutable.ImmutableArray`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]],System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]]):ubyte (FullOpts)
         -81 (-40.30% of base) : 14962.dasm - SixLabors.ImageSharp.Formats.Tga.TgaImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
        -965 (-40.01% of base) : 629.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -515 (-39.98% of base) : 26370.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:WhereAsArrayImpl[System.__Canon,System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Func`2[System.__Canon,ubyte],System.Func`3[System.__Canon,System.__Canon,ubyte],System.__Canon):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (FullOpts)

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

Total bytes of base: 5054270 (overridden on cmd)
Total bytes of diff: 4976532 (overridden on cmd)
Total bytes of delta: -77738 (-1.54 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          60 : 7329.dasm (2.56% of base)
          58 : 29536.dasm (8.27% of base)
          58 : 27728.dasm (8.27% of base)
          53 : 26997.dasm (7.86% of base)
          53 : 27995.dasm (7.86% of base)
          28 : 13119.dasm (2.59% of base)
          21 : 9911.dasm (6.33% of base)
          20 : 31596.dasm (7.97% of base)
          20 : 31759.dasm (7.97% of base)
          14 : 15599.dasm (7.73% of base)
          14 : 696.dasm (7.73% of base)
          14 : 5690.dasm (5.20% of base)
          14 : 17440.dasm (4.35% of base)
          14 : 20949.dasm (7.73% of base)
          14 : 22062.dasm (6.60% of base)
          14 : 22845.dasm (5.96% of base)
          14 : 20059.dasm (4.35% of base)
          14 : 20474.dasm (5.98% of base)
          14 : 16670.dasm (4.35% of base)
          14 : 20185.dasm (5.96% of base)

Top file improvements (bytes):
       -1412 : 17995.dasm (-27.69% of base)
        -894 : 1524.dasm (-38.53% of base)
        -891 : 1535.dasm (-40.63% of base)
        -536 : 15305.dasm (-12.92% of base)
        -536 : 20654.dasm (-12.96% of base)
        -465 : 23343.dasm (-11.53% of base)
        -413 : 22091.dasm (-70.84% of base)
        -413 : 1649.dasm (-70.84% of base)
        -413 : 5273.dasm (-70.84% of base)
        -413 : 19366.dasm (-70.84% of base)
        -413 : 16767.dasm (-70.84% of base)
        -400 : 13319.dasm (-37.63% of base)
        -257 : 10888.dasm (-40.22% of base)
        -256 : 10243.dasm (-30.73% of base)
        -256 : 6024.dasm (-30.33% of base)
        -232 : 18384.dasm (-19.46% of base)
        -232 : 474.dasm (-21.38% of base)
        -232 : 18383.dasm (-21.34% of base)
        -232 : 475.dasm (-19.45% of base)
        -232 : 15777.dasm (-19.46% of base)

77 total files with Code Size differences (45 improved, 32 regressed), 20 unchanged.

Top method regressions (bytes):
          60 ( 2.56% of base) : 7329.dasm - System.Diagnostics.NtProcessManager:GetProcessInfos(System.Diagnostics.PerformanceCounterLib,int,int,System.ReadOnlySpan`1[ubyte]):System.Diagnostics.ProcessInfo[] (FullOpts)
          58 ( 8.27% of base) : 29536.dasm - System.Enum:TryFormatUnconstrained[ushort](ushort,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          58 ( 8.27% of base) : 27728.dasm - System.Enum:TryFormatUnconstrained[ushort](ushort,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          53 ( 7.86% of base) : 27995.dasm - System.Enum:TryFormatUnconstrained[long](long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          53 ( 7.86% of base) : 26997.dasm - System.Enum:TryFormatUnconstrained[ulong](ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          28 ( 2.59% of base) : 13119.dasm - System.Linq.Expressions.UnaryExpression:ReduceIndex():System.Linq.Expressions.Expression:this (FullOpts)
          21 ( 6.33% of base) : 9911.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:.ctor(int,int,System.IFormatProvider):this (FullOpts)
          20 ( 7.97% of base) : 31596.dasm - ReflectionTest+TestLinqInvocation:Run() (FullOpts)
          20 ( 7.97% of base) : 31759.dasm - ReflectionTest+TestLinqInvocation:Run() (FullOpts)
          14 ( 7.73% of base) : 15599.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 696.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 20949.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 3224.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 18228.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 4.35% of base) : 20059.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendCustomFormatter[ubyte](ubyte,System.String):this (FullOpts)
          14 ( 4.35% of base) : 16670.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendCustomFormatter[ubyte](ubyte,System.String):this (FullOpts)
          14 ( 4.35% of base) : 17435.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendCustomFormatter[ubyte](ubyte,System.String):this (FullOpts)
          14 ( 4.35% of base) : 17440.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendCustomFormatter[ushort](ushort,System.String):this (FullOpts)
          14 ( 4.35% of base) : 23226.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendCustomFormatter[ushort](ushort,System.String):this (FullOpts)
          14 ( 5.96% of base) : 22845.dasm - System.Text.StringBuilder+AppendInterpolatedStringHandler:AppendCustomFormatter[long](long,System.String):this (FullOpts)

Top method improvements (bytes):
       -1412 (-27.69% of base) : 17995.dasm - Program:Main():int (FullOpts)
        -894 (-38.53% of base) : 1524.dasm - System.Guid:TryParseExactD(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -891 (-40.63% of base) : 1535.dasm - System.Guid:TryParseExactN(System.ReadOnlySpan`1[ushort],byref):ubyte (FullOpts)
        -536 (-12.92% of base) : 15305.dasm - Program:Main():int (FullOpts)
        -536 (-12.96% of base) : 20654.dasm - Program:Main():int (FullOpts)
        -465 (-11.53% of base) : 23343.dasm - Program:Main():int (FullOpts)
        -413 (-70.84% of base) : 22091.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 1649.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 5273.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 19366.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 16767.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -400 (-37.63% of base) : 13319.dasm - System.Linq.Expressions.Expression:ValidateAccessorArgumentTypes(System.Reflection.MethodInfo,System.Reflection.ParameterInfo[],byref,System.String) (FullOpts)
        -257 (-40.22% of base) : 10888.dasm - System.Dynamic.Utils.ExpressionUtils:ValidateArgumentTypes(System.Reflection.MethodBase,int,byref,System.String) (FullOpts)
        -256 (-30.73% of base) : 10243.dasm - System.Reflection.Runtime.MethodInfos.RuntimeMethodHelpers:GetRuntimeParameters[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon](byref,System.Reflection.MethodBase,System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo[],byref):System.Reflection.Runtime.ParameterInfos.RuntimeParameterInfo[] (FullOpts)
        -256 (-30.33% of base) : 6024.dasm - System.Reflection.Runtime.MethodInfos.RuntimeMethodHelpers:GetRuntimeParameters[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon](byref,System.Reflection.MethodBase,System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo[],byref):System.Reflection.Runtime.ParameterInfos.RuntimeParameterInfo[] (FullOpts)
        -232 (-19.46% of base) : 18384.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -232 (-19.45% of base) : 475.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -232 (-19.46% of base) : 15777.dasm - System.Enum:TryFormatPrimitiveNonDefault[long,ulong](System.RuntimeType,long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -232 (-21.38% of base) : 474.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -232 (-21.34% of base) : 18383.dasm - System.Enum:TryFormatPrimitiveNonDefault[ulong,ulong](System.RuntimeType,ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method regressions (percentages):
           7 ( 9.59% of base) : 26705.dasm - System.Enum:TryFormatUnconstrained[int](int,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
           7 ( 9.33% of base) : 26699.dasm - System.Enum:TryFormatUnconstrained[ubyte](ubyte,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          58 ( 8.27% of base) : 29536.dasm - System.Enum:TryFormatUnconstrained[ushort](ushort,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          58 ( 8.27% of base) : 27728.dasm - System.Enum:TryFormatUnconstrained[ushort](ushort,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          20 ( 7.97% of base) : 31596.dasm - ReflectionTest+TestLinqInvocation:Run() (FullOpts)
          20 ( 7.97% of base) : 31759.dasm - ReflectionTest+TestLinqInvocation:Run() (FullOpts)
          53 ( 7.86% of base) : 27995.dasm - System.Enum:TryFormatUnconstrained[long](long,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          53 ( 7.86% of base) : 26997.dasm - System.Enum:TryFormatUnconstrained[ulong](ulong,System.Span`1[ushort],byref,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          14 ( 7.73% of base) : 15599.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 696.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 20949.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 3224.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 7.73% of base) : 18228.dasm - System.Globalization.NumberFormatInfo:<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider):System.Globalization.NumberFormatInfo (FullOpts)
          14 ( 6.60% of base) : 22062.dasm - System.Text.StringBuilder+AppendInterpolatedStringHandler:AppendCustomFormatter[System.__Canon](System.__Canon,System.String):this (FullOpts)
          14 ( 6.60% of base) : 16704.dasm - System.Text.StringBuilder+AppendInterpolatedStringHandler:AppendCustomFormatter[System.__Canon](System.__Canon,System.String):this (FullOpts)
          14 ( 6.60% of base) : 1478.dasm - System.Text.StringBuilder+AppendInterpolatedStringHandler:AppendCustomFormatter[System.__Canon](System.__Canon,System.String):this (FullOpts)
          14 ( 6.60% of base) : 19472.dasm - System.Text.StringBuilder+AppendInterpolatedStringHandler:AppendCustomFormatter[System.__Canon](System.__Canon,System.String):this (FullOpts)
          21 ( 6.33% of base) : 9911.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:.ctor(int,int,System.IFormatProvider):this (FullOpts)
          10 ( 6.25% of base) : 6382.dasm - System.Globalization.DateTimeFormatInfo:GetInstance(System.IFormatProvider):System.Globalization.DateTimeFormatInfo (FullOpts)
          10 ( 6.25% of base) : 12147.dasm - System.Globalization.DateTimeFormatInfo:GetInstance(System.IFormatProvider):System.Globalization.DateTimeFormatInfo (FullOpts)

Top method improvements (percentages):
        -413 (-70.84% of base) : 22091.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 1649.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 5273.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 19366.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
        -413 (-70.84% of base) : 16767.dasm - System.Reflection.Runtime.General.Helpers:EscapeTypeNameIdentifier(System.String):System.String (FullOpts)
         -26 (-68.42% of base) : 29913.dasm - System.Numerics.Vector`1[uint]:.ctor(uint):this (FullOpts)
         -12 (-66.67% of base) : 18297.dasm - Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
         -12 (-66.67% of base) : 23274.dasm - Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
         -12 (-66.67% of base) : 21012.dasm - Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
         -12 (-66.67% of base) : 15653.dasm - Program+<>c:<Main>b__0_19():ubyte:this (FullOpts)
         -17 (-65.38% of base) : 10035.dasm - Generics+TestSlotsInHierarchy:Run() (FullOpts)
         -17 (-65.38% of base) : 32069.dasm - Generics+TestSlotsInHierarchy:Run() (FullOpts)
         -10 (-62.50% of base) : 18299.dasm - Program+<>c:<Main>b__0_18():ubyte:this (FullOpts)
         -10 (-62.50% of base) : 21015.dasm - Program+<>c:<Main>b__0_18():ubyte:this (FullOpts)
         -10 (-62.50% of base) : 15655.dasm - Program+<>c:<Main>b__0_18():ubyte:this (FullOpts)
         -10 (-62.50% of base) : 23276.dasm - Program+<>c:<Main>b__0_18():ubyte:this (FullOpts)
        -115 (-61.17% of base) : 32095.dasm - Interfaces+TestDefaultInterfaceVariance:Run() (FullOpts)
        -115 (-61.17% of base) : 10082.dasm - Interfaces+TestDefaultInterfaceVariance:Run() (FullOpts)
         -12 (-60.00% of base) : 29886.dasm - System.Numerics.Vector`1[ulong]:.ctor(ulong):this (FullOpts)
         -42 (-59.15% of base) : 28291.dasm - System.Runtime.Intrinsics.Vector64:Create[short](short):System.Runtime.Intrinsics.Vector64`1[short] (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
