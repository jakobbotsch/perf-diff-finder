Diffs are based on <span style="color:#1460aa">2,448,162</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,492,868</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">9,548 (0.39%)</span>, diff: <span style="color:#d35400">6,965 (0.28%)</span>

Base JIT options: JitEnablePhysicalPromotion=0


<details>
<summary>Overall (<span style="color:green">-1,151,494</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,351,603|<span style="color:green">-24,096</span>|<span style="color:green">-7.32%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,236,667|<span style="color:green">-5,341</span>|<span style="color:green">-5.50%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,674,703|<span style="color:green">-4,804</span>|<span style="color:green">-10.77%</span>|
|coreclr_tests.run.windows.x64.checked.mch|386,868,437|<span style="color:green">-307,690</span>|<span style="color:green">-7.43%</span>|
|libraries.crossgen2.windows.x64.checked.mch|44,901,308|<span style="color:green">-51,331</span>|<span style="color:green">-10.22%</span>|
|libraries.pmi.windows.x64.checked.mch|61,272,632|<span style="color:green">-214,343</span>|<span style="color:green">-8.30%</span>|
|libraries_tests.run.windows.x64.Release.mch|284,463,335|<span style="color:green">-265,929</span>|<span style="color:green">-5.81%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|135,664,861|<span style="color:green">-196,270</span>|<span style="color:green">-7.77%</span>|
|realworld.run.windows.x64.checked.mch|13,687,708|<span style="color:green">-70,101</span>|<span style="color:green">-5.88%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,099,419|<span style="color:green">-11,589</span>|<span style="color:green">-30.53%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-1,151,494</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,351,243|<span style="color:green">-24,096</span>|<span style="color:green">-7.32%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,334,043|<span style="color:green">-5,341</span>|<span style="color:green">-5.50%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,441,920|<span style="color:green">-4,804</span>|<span style="color:green">-10.77%</span>|
|coreclr_tests.run.windows.x64.checked.mch|106,425,357|<span style="color:green">-307,690</span>|<span style="color:green">-7.43%</span>|
|libraries.crossgen2.windows.x64.checked.mch|44,900,121|<span style="color:green">-51,331</span>|<span style="color:green">-10.22%</span>|
|libraries.pmi.windows.x64.checked.mch|61,159,138|<span style="color:green">-214,343</span>|<span style="color:green">-8.30%</span>|
|libraries_tests.run.windows.x64.Release.mch|104,816,316|<span style="color:green">-265,929</span>|<span style="color:green">-5.81%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|125,371,982|<span style="color:green">-196,270</span>|<span style="color:green">-7.77%</span>|
|realworld.run.windows.x64.checked.mch|13,301,540|<span style="color:green">-70,101</span>|<span style="color:green">-5.88%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,098,472|<span style="color:green">-11,589</span>|<span style="color:green">-30.53%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-35</span> (<span style="color:green">-60.34%</span>) : 32621.dasm - System.Tests.Perf_Guid:NotEqualsOperator():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,33 +10,29 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Tests.Perf_Guid>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )  struct (16) [rsp+0x18]  do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
-;  V03 tmp2         [V03,T02] (  2,  4   )  struct (16) [rsp+0x08]  do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
+;* V02 tmp1         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
+;* V03 tmp2         [V03    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
 ;* V04 tmp3         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V05 tmp4         [V05    ] (  0,  0   )  simd16  ->  zero-ref    "V02.[000..016)"
+;* V06 tmp5         [V06    ] (  0,  0   )  simd16  ->  zero-ref    "V03.[000..016)"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M16691_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M16691_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
        vmovups  xmm0, xmmword ptr [rcx+0x10]
-       vmovups  xmmword ptr [rsp+0x18], xmm0
-       vmovups  xmm0, xmmword ptr [rcx+0x20]
-       vmovups  xmmword ptr [rsp+0x08], xmm0
-       vmovups  xmm0, xmmword ptr [rsp+0x18]
-       vpcmpeqb k1, xmm0, xmmword ptr [rsp+0x08]
+       vpcmpeqb k1, xmm0, xmmword ptr [rcx+0x20]
        kortestw k1, k1
        setae    al
        movzx    rax, al
-						;; size=49 bbWeight=1 PerfScore 17.25
+						;; size=22 bbWeight=1 PerfScore 9.25
 G_M16691_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 18.75, instruction count 12, allocated bytes for code 60 (MethodHash=1038becc) for method System.Tests.Perf_Guid:NotEqualsOperator():ubyte:this (FullOpts)
+; Total bytes of code 23, prolog size 0, PerfScore 10.25, instruction count 6, allocated bytes for code 25 (MethodHash=1038becc) for method System.Tests.Perf_Guid:NotEqualsOperator():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -44,9 +40,8 @@ Unwind Info:
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
<summary><span style="color:green">-35</span> (<span style="color:green">-60.34%</span>) : 32016.dasm - System.Tests.Perf_Guid:EqualsOperator():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,33 +10,29 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Tests.Perf_Guid>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )  struct (16) [rsp+0x18]  do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
-;  V03 tmp2         [V03,T02] (  2,  4   )  struct (16) [rsp+0x08]  do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
+;* V02 tmp1         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
+;* V03 tmp2         [V03    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
 ;* V04 tmp3         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V05 tmp4         [V05    ] (  0,  0   )  simd16  ->  zero-ref    "V02.[000..016)"
+;* V06 tmp5         [V06    ] (  0,  0   )  simd16  ->  zero-ref    "V03.[000..016)"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M35302_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M35302_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
        vmovups  xmm0, xmmword ptr [rcx+0x10]
-       vmovups  xmmword ptr [rsp+0x18], xmm0
-       vmovups  xmm0, xmmword ptr [rcx+0x20]
-       vmovups  xmmword ptr [rsp+0x08], xmm0
-       vmovups  xmm0, xmmword ptr [rsp+0x18]
-       vpcmpeqb k1, xmm0, xmmword ptr [rsp+0x08]
+       vpcmpeqb k1, xmm0, xmmword ptr [rcx+0x20]
        kortestw k1, k1
        setb     al
        movzx    rax, al
-						;; size=49 bbWeight=1 PerfScore 17.25
+						;; size=22 bbWeight=1 PerfScore 9.25
 G_M35302_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 18.75, instruction count 12, allocated bytes for code 60 (MethodHash=b0f87619) for method System.Tests.Perf_Guid:EqualsOperator():ubyte:this (FullOpts)
+; Total bytes of code 23, prolog size 0, PerfScore 10.25, instruction count 6, allocated bytes for code 25 (MethodHash=b0f87619) for method System.Tests.Perf_Guid:EqualsOperator():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -44,9 +40,8 @@ Unwind Info:
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
<summary><span style="color:green">-26</span> (<span style="color:green">-53.06%</span>) : 24835.dasm - System.Tests.Perf_Guid:EqualsNotSame():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,34 +10,28 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Tests.Perf_Guid>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )   byref  ->  rax         single-def "Inlining Arg"
-;  V03 tmp2         [V03,T02] (  2,  4   )  struct (16) [rsp+0x08]  do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
+;* V02 tmp1         [V02    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;* V03 tmp2         [V03    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Guid>
 ;* V04 tmp3         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V05 tmp4         [V05    ] (  0,  0   )  simd16  ->  zero-ref    "V03.[000..016)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M58441_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M58441_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       lea      rax, bword ptr [rcx+0x10]
-       ; byrRegs +[rax]
-       vmovups  xmm0, xmmword ptr [rcx+0x30]
-       vmovups  xmmword ptr [rsp+0x08], xmm0
-       vmovups  xmm0, xmmword ptr [rax]
-       vpcmpeqb k1, xmm0, xmmword ptr [rsp+0x08]
+       vmovups  xmm0, xmmword ptr [rcx+0x10]
+       vpcmpeqb k1, xmm0, xmmword ptr [rcx+0x30]
        kortestw k1, k1
        setb     al
-       ; byrRegs -[rax]
        movzx    rax, al
-						;; size=40 bbWeight=1 PerfScore 13.75
+						;; size=22 bbWeight=1 PerfScore 9.25
 G_M58441_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 49, prolog size 4, PerfScore 15.25, instruction count 11, allocated bytes for code 51 (MethodHash=4d831bb6) for method System.Tests.Perf_Guid:EqualsNotSame():ubyte:this (FullOpts)
+; Total bytes of code 23, prolog size 0, PerfScore 10.25, instruction count 6, allocated bytes for code 25 (MethodHash=4d831bb6) for method System.Tests.Perf_Guid:EqualsNotSame():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -45,9 +39,8 @@ Unwind Info:
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
<summary><span style="color:red">+18</span> (<span style="color:red">+22.78%</span>) : 31002.dasm - System.Numerics.Tests.Perf_Matrix3x2:GetDeterminantBenchmark():float:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,16 +9,21 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Numerics.Tests.Perf_Matrix3x2>
-;  V01 loc0         [V01,T00] (  6,  6   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op <System.Numerics.Matrix3x2>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <System.Numerics.Matrix3x2>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix3x2+Impl>
-;* V04 tmp2         [V04    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix3x2+Impl>
+;  V04 tmp2         [V04    ] (  7,  7   )  struct (24) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix3x2+Impl>
 ;* V05 tmp3         [V05    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.X (fldOffset=0x0)" P-INDEP
 ;* V06 tmp4         [V06    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.Y (fldOffset=0x8)" P-INDEP
 ;* V07 tmp5         [V07    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.Z (fldOffset=0x10)" P-INDEP
-;* V08 tmp6         [V08,T01] (  0,  0   )   simd8  ->  zero-ref    single-def "field V04.X (fldOffset=0x0)" P-INDEP
-;* V09 tmp7         [V09,T02] (  0,  0   )   simd8  ->  zero-ref    single-def "field V04.Y (fldOffset=0x8)" P-INDEP
-;* V10 tmp8         [V10,T03] (  0,  0   )   simd8  ->  zero-ref    single-def "field V04.Z (fldOffset=0x10)" P-INDEP
+;  V08 tmp6         [V08,T00] (  5,  5   )   simd8  ->  [rsp+0x00]  do-not-enreg[S] single-def "field V04.X (fldOffset=0x0)" P-DEP
+;  V09 tmp7         [V09,T01] (  5,  5   )   simd8  ->  [rsp+0x08]  do-not-enreg[S] single-def "field V04.Y (fldOffset=0x8)" P-DEP
+;  V10 tmp8         [V10,T02] (  5,  5   )   simd8  ->  [rsp+0x10]  do-not-enreg[S] single-def "field V04.Z (fldOffset=0x10)" P-DEP
+;  V11 tmp9         [V11,T03] (  2,  2   )   float  ->  mm0         single-def "V01.[000..004)"
+;  V12 tmp10        [V12,T04] (  2,  2   )   float  ->  mm1         single-def "V01.[004..008)"
+;  V13 tmp11        [V13,T05] (  2,  2   )   float  ->  mm2         single-def "V01.[008..012)"
+;  V14 tmp12        [V14,T06] (  2,  2   )   float  ->  mm3         single-def "V01.[012..016)"
+;* V15 tmp13        [V15    ] (  0,  0   )   simd8  ->  zero-ref    "V01.[016..024)"
 ;
 ; Lcl frame size = 24
 
@@ -34,12 +39,16 @@ G_M33935_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        vmovsd   qword ptr [rsp], xmm0
        vmovsd   xmm0, qword ptr [reloc @RWD08]
        vmovsd   qword ptr [rsp+0x08], xmm0
+       vxorps   xmm0, xmm0, xmm0
+       vmovsd   qword ptr [rsp+0x10], xmm0
        vmovss   xmm0, dword ptr [rsp]
-       vmulss   xmm0, xmm0, dword ptr [rsp+0x0C]
-       vmovss   xmm1, dword ptr [rsp+0x08]
-       vmulss   xmm1, xmm1, dword ptr [rsp+0x04]
+       vmovss   xmm1, dword ptr [rsp+0x04]
+       vmovss   xmm2, dword ptr [rsp+0x08]
+       vmovss   xmm3, dword ptr [rsp+0x0C]
+       vmulss   xmm0, xmm0, xmm3
+       vmulss   xmm1, xmm2, xmm1
        vsubss   xmm0, xmm0, xmm1
-						;; size=54 bbWeight=1 PerfScore 27.00
+						;; size=72 bbWeight=1 PerfScore 30.33
 G_M33935_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 24
        ret      
@@ -48,7 +57,7 @@ RWD00  	dq	000000003F800000h
 RWD08  	dq	3F80000000000000h
 
 
-; Total bytes of code 79, prolog size 20, PerfScore 32.08, instruction count 16, allocated bytes for code 79 (MethodHash=96117b70) for method System.Numerics.Tests.Perf_Matrix3x2:GetDeterminantBenchmark():float:this (FullOpts)
+; Total bytes of code 97, prolog size 20, PerfScore 35.42, instruction count 20, allocated bytes for code 97 (MethodHash=96117b70) for method System.Numerics.Tests.Perf_Matrix3x2:GetDeterminantBenchmark():float:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+23.47%</span>) : 9799.dasm - System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,57 +10,77 @@
 ;
 ;  V00 this         [V00,T03] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.ActivityTagsCollection>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V02 tmp1         [V02    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Diagnostics.ActivityTagsCollection+Enumerator>
-;  V03 tmp2         [V03,T01] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.ActivityTagsCollection+Enumerator>
-;  V04 tmp3         [V04,T02] (  3,  6   )     ref  ->  rcx         class-hnd single-def "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
-;  V05 tmp4         [V05,T00] (  4,  8   )  struct (32) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;  V02 tmp1         [V02,T02] (  3,  6   )  struct (32) [rsp+0x48]  do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Diagnostics.ActivityTagsCollection+Enumerator>
+;  V03 tmp2         [V03,T00] (  5, 10   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.ActivityTagsCollection+Enumerator>
+;  V04 tmp3         [V04,T01] (  3,  6   )     ref  ->  rsi         class-hnd single-def "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;  V05 tmp4         [V05,T05] (  1,  2   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;* V06 tmp5         [V06    ] (  0,  0   )     ref  ->  zero-ref    single-def "V05.[000..008)"
+;* V07 tmp6         [V07    ] (  0,  0   )     int  ->  zero-ref    "V05.[008..012)"
+;  V08 tmp7         [V08,T04] (  2,  2   )     int  ->  rbx         "V05.[012..016)"
+;* V09 tmp8         [V09    ] (  0,  0   )     ref  ->  zero-ref    single-def "V02.[000..008)"
+;* V10 tmp9         [V10    ] (  0,  0   )     int  ->  zero-ref    "V02.[008..012)"
+;* V11 tmp10        [V11    ] (  0,  0   )     int  ->  zero-ref    "V02.[012..016)"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 104
 
 G_M49529_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 104
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
-						;; size=17 bbWeight=1 PerfScore 5.58
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
+						;; size=30 bbWeight=1 PerfScore 8.83
 G_M49529_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rcx, gword ptr [rcx+0x08]
-       mov      gword ptr [rsp+0x20], rcx
-       mov      ecx, dword ptr [rcx+0x14]
-       ; gcrRegs -[rcx]
-       mov      dword ptr [rsp+0x2C], ecx
-       vxorps   xmm0, xmm0, xmm0
-       vmovdqu  xmmword ptr [rsp+0x30], xmm0
+       mov      rsi, gword ptr [rcx+0x08]
+       ; gcrRegs +[rsi]
+       mov      ebx, dword ptr [rsi+0x14]
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M49529_IG03:        ; bbWeight=1, nogc, extend
+       vmovdqu  ymm0, ymmword ptr [rsp+0x28]
+       vmovdqu  ymmword ptr [rsp+0x48], ymm0
+						;; size=12 bbWeight=1 PerfScore 5.00
+G_M49529_IG04:        ; bbWeight=1, extend
        mov      rcx, 0xD1FFAB1E      ; System.Diagnostics.ActivityTagsCollection+Enumerator
+       ; gcrRegs -[rcx]
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-       lea      rdi, bword ptr [rbx+0x08]
+       mov      rbp, rax
+       ; gcrRegs +[rbp]
+       mov      gword ptr [rsp+0x48], rsi
+       lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x20]
+       lea      rsi, bword ptr [rsp+0x48]
+       ; gcrRegs -[rsi]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
        ; gcrRegs -[rax]
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
-       mov      rax, rbx
+       xor      eax, eax
+       mov      dword ptr [rbp+0x10], eax
+       mov      dword ptr [rbp+0x14], ebx
+       mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=73 bbWeight=1 PerfScore 14.08
-G_M49529_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+						;; size=60 bbWeight=1 PerfScore 10.00
+G_M49529_IG05:        ; bbWeight=1, epilog, nogc, extend
+       vzeroupper 
+       add      rsp, 104
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=12 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 98, prolog size 17, PerfScore 22.42, instruction count 27, allocated bytes for code 98 (MethodHash=aa073e86) for method System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
+; Total bytes of code 121, prolog size 30, PerfScore 32.08, instruction count 35, allocated bytes for code 121 (MethodHash=aa073e86) for method System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -68,12 +88,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+23.47%</span>) : 15476.dasm - System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,57 +10,77 @@
 ;
 ;  V00 this         [V00,T03] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.ActivityTagsCollection>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V02 tmp1         [V02    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Diagnostics.ActivityTagsCollection+Enumerator>
-;  V03 tmp2         [V03,T01] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.ActivityTagsCollection+Enumerator>
-;  V04 tmp3         [V04,T02] (  3,  6   )     ref  ->  rcx         class-hnd single-def "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
-;  V05 tmp4         [V05,T00] (  4,  8   )  struct (32) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;  V02 tmp1         [V02,T02] (  3,  6   )  struct (32) [rsp+0x48]  do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Diagnostics.ActivityTagsCollection+Enumerator>
+;  V03 tmp2         [V03,T00] (  5, 10   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.ActivityTagsCollection+Enumerator>
+;  V04 tmp3         [V04,T01] (  3,  6   )     ref  ->  rsi         class-hnd single-def "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;  V05 tmp4         [V05,T05] (  1,  2   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;* V06 tmp5         [V06    ] (  0,  0   )     ref  ->  zero-ref    single-def "V05.[000..008)"
+;* V07 tmp6         [V07    ] (  0,  0   )     int  ->  zero-ref    "V05.[008..012)"
+;  V08 tmp7         [V08,T04] (  2,  2   )     int  ->  rbx         "V05.[012..016)"
+;* V09 tmp8         [V09    ] (  0,  0   )     ref  ->  zero-ref    single-def "V02.[000..008)"
+;* V10 tmp9         [V10    ] (  0,  0   )     int  ->  zero-ref    "V02.[008..012)"
+;* V11 tmp10        [V11    ] (  0,  0   )     int  ->  zero-ref    "V02.[012..016)"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 104
 
 G_M49529_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 104
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
-						;; size=17 bbWeight=1 PerfScore 5.58
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
+						;; size=30 bbWeight=1 PerfScore 8.83
 G_M49529_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rcx, gword ptr [rcx+0x08]
-       mov      gword ptr [rsp+0x20], rcx
-       mov      ecx, dword ptr [rcx+0x14]
-       ; gcrRegs -[rcx]
-       mov      dword ptr [rsp+0x2C], ecx
-       vxorps   xmm0, xmm0, xmm0
-       vmovdqu  xmmword ptr [rsp+0x30], xmm0
+       mov      rsi, gword ptr [rcx+0x08]
+       ; gcrRegs +[rsi]
+       mov      ebx, dword ptr [rsi+0x14]
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M49529_IG03:        ; bbWeight=1, nogc, extend
+       vmovdqu  ymm0, ymmword ptr [rsp+0x28]
+       vmovdqu  ymmword ptr [rsp+0x48], ymm0
+						;; size=12 bbWeight=1 PerfScore 5.00
+G_M49529_IG04:        ; bbWeight=1, extend
        mov      rcx, 0xD1FFAB1E      ; System.Diagnostics.ActivityTagsCollection+Enumerator
+       ; gcrRegs -[rcx]
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-       lea      rdi, bword ptr [rbx+0x08]
+       mov      rbp, rax
+       ; gcrRegs +[rbp]
+       mov      gword ptr [rsp+0x48], rsi
+       lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x20]
+       lea      rsi, bword ptr [rsp+0x48]
+       ; gcrRegs -[rsi]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
        ; gcrRegs -[rax]
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
-       mov      rax, rbx
+       xor      eax, eax
+       mov      dword ptr [rbp+0x10], eax
+       mov      dword ptr [rbp+0x14], ebx
+       mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=73 bbWeight=1 PerfScore 14.08
-G_M49529_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+						;; size=60 bbWeight=1 PerfScore 10.00
+G_M49529_IG05:        ; bbWeight=1, epilog, nogc, extend
+       vzeroupper 
+       add      rsp, 104
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=12 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 98, prolog size 17, PerfScore 22.42, instruction count 27, allocated bytes for code 98 (MethodHash=aa073e86) for method System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
+; Total bytes of code 121, prolog size 30, PerfScore 32.08, instruction count 35, allocated bytes for code 121 (MethodHash=aa073e86) for method System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -68,12 +88,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-22</span> (<span style="color:green">-41.51%</span>) : 35789.dasm - System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:LessThan(byref,byref):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,25 +11,23 @@
 ;  V00 arg0         [V00,T00] (  3,  3   )   byref  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  3   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T04] (  2,  4   )  struct (32) [rsp+0x08]  do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;  V04 tmp2         [V04,T05] (  3,  1.50)     int  ->  rdx         "Inline return value spill temp"
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
+;  V04 tmp2         [V04,T04] (  3,  1.50)     int  ->  rdx         "Inline return value spill temp"
 ;  V05 tmp3         [V05,T02] (  3,  4.39)   byref  ->  rcx         single-def "Inlining Arg"
-;  V06 tmp4         [V06,T03] (  3,  4.39)     int  ->  rax         "Inlining Arg"
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;  V07 tmp5         [V07,T03] (  3,  2.20)     int  ->  rax         "V03.[012..016)"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M45845_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M45845_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
        ; byrRegs +[rcx rdx]
-       vmovdqu  ymm0, ymmword ptr [rdx]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
+       mov      eax, dword ptr [rdx+0x0C]
        add      rcx, 12
-       mov      eax, dword ptr [rsp+0x14]
        cmp      dword ptr [rcx], eax
        jge      SHORT G_M45845_IG06
-						;; size=22 bbWeight=1 PerfScore 11.25
+						;; size=11 bbWeight=1 PerfScore 6.25
 G_M45845_IG03:        ; bbWeight=0.30, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rcx rdx]
        mov      edx, -1
@@ -39,10 +37,8 @@ G_M45845_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        shr      eax, 31
 						;; size=5 bbWeight=1 PerfScore 0.75
 G_M45845_IG05:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 40
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 G_M45845_IG06:        ; bbWeight=0.20, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, gcvars, byref, isz
        ; byrRegs +[rcx]
        xor      edx, edx
@@ -51,7 +47,7 @@ G_M45845_IG06:        ; bbWeight=0.20, gcVars=0000000000000000 {}, gcrefRegs=000
        jmp      SHORT G_M45845_IG04
 						;; size=9 bbWeight=0.20 PerfScore 1.23
 
-; Total bytes of code 53, prolog size 4, PerfScore 15.80, instruction count 17, allocated bytes for code 53 (MethodHash=7df54cea) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:LessThan(byref,byref):ubyte (Tier1)
+; Total bytes of code 31, prolog size 0, PerfScore 9.30, instruction count 12, allocated bytes for code 31 (MethodHash=7df54cea) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:LessThan(byref,byref):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -59,9 +55,8 @@ Unwind Info:
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
<summary><span style="color:green">-22</span> (<span style="color:green">-40.00%</span>) : 35787.dasm - System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:GreaterThan(byref,byref):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,25 +11,23 @@
 ;  V00 arg0         [V00,T00] (  3,  3   )   byref  ->  rcx         single-def
 ;  V01 arg1         [V01,T01] (  3,  3   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T04] (  2,  4   )  struct (32) [rsp+0x08]  do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;  V04 tmp2         [V04,T05] (  3,  1.50)     int  ->  rdx         "Inline return value spill temp"
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
+;  V04 tmp2         [V04,T04] (  3,  1.50)     int  ->  rdx         "Inline return value spill temp"
 ;  V05 tmp3         [V05,T02] (  3,  4.39)   byref  ->  rcx         single-def "Inlining Arg"
-;  V06 tmp4         [V06,T03] (  3,  4.39)     int  ->  rax         "Inlining Arg"
+;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;  V07 tmp5         [V07,T03] (  3,  2.20)     int  ->  rax         "V03.[012..016)"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M15598_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M15598_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
        ; byrRegs +[rcx rdx]
-       vmovdqu  ymm0, ymmword ptr [rdx]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
+       mov      eax, dword ptr [rdx+0x0C]
        add      rcx, 12
-       mov      eax, dword ptr [rsp+0x14]
        cmp      dword ptr [rcx], eax
        jge      SHORT G_M15598_IG06
-						;; size=22 bbWeight=1 PerfScore 11.25
+						;; size=11 bbWeight=1 PerfScore 6.25
 G_M15598_IG03:        ; bbWeight=0.30, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rcx rdx]
        mov      edx, -1
@@ -40,10 +38,8 @@ G_M15598_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        setg     al
 						;; size=7 bbWeight=1 PerfScore 1.50
 G_M15598_IG05:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 40
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 G_M15598_IG06:        ; bbWeight=0.20, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, gcvars, byref, isz
        ; byrRegs +[rcx]
        xor      edx, edx
@@ -52,7 +48,7 @@ G_M15598_IG06:        ; bbWeight=0.20, gcVars=0000000000000000 {}, gcrefRegs=000
        jmp      SHORT G_M15598_IG04
 						;; size=9 bbWeight=0.20 PerfScore 1.23
 
-; Total bytes of code 55, prolog size 4, PerfScore 16.55, instruction count 18, allocated bytes for code 55 (MethodHash=1a5fc311) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:GreaterThan(byref,byref):ubyte (Tier1)
+; Total bytes of code 33, prolog size 0, PerfScore 10.05, instruction count 13, allocated bytes for code 33 (MethodHash=1a5fc311) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:GreaterThan(byref,byref):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -60,9 +56,8 @@ Unwind Info:
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
<summary><span style="color:green">-39</span> (<span style="color:green">-31.20%</span>) : 67134.dasm - System.Threading.Tasks.RangeManager:RegisterNewWorker():System.Threading.Tasks.RangeWorker:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,30 +9,32 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  7,  7   )     ref  ->  rcx         this class-hnd single-def <System.Threading.Tasks.RangeManager>
-;  V01 RetBuf       [V01,T03] (  4,  4   )   byref  ->  rbx         single-def
-;  V02 loc0         [V02,T07] (  2,  2   )     int  ->  rdx        
+;  V01 RetBuf       [V01,T00] (  9,  9   )   byref  ->  rbx         single-def
+;  V02 loc0         [V02,T06] (  2,  2   )     int  ->  rsi        
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T00] (  7, 14   )  struct (40) [rsp+0x08]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Threading.Tasks.RangeWorker>
+;* V04 tmp1         [V04    ] (  0,  0   )  struct (40) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Threading.Tasks.RangeWorker>
 ;* V05 tmp2         [V05    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V06 tmp3         [V06,T04] (  2,  4   )     ref  ->   r8         class-hnd exact single-def "Inlining Arg" <System.Threading.Tasks.IndexRange[]>
-;  V07 tmp4         [V07,T05] (  2,  4   )   ubyte  ->  rcx         "Inlining Arg"
-;  V08 tmp5         [V08,T02] (  4,  8   )    long  ->  rax         "Inlining Arg"
-;  V09 cse0         [V09,T06] (  3,  3   )     ref  ->   r8         "CSE - aggressive"
+;  V06 tmp3         [V06,T03] (  2,  4   )     ref  ->  rdx         class-hnd exact single-def "Inlining Arg" <System.Threading.Tasks.IndexRange[]>
+;  V07 tmp4         [V07,T04] (  2,  4   )   ubyte  ->  rbp         "Inlining Arg"
+;  V08 tmp5         [V08,T02] (  4,  8   )    long  ->  rdi         "Inlining Arg"
+;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    "V04.[000..008)"
+;* V10 tmp7         [V10    ] (  0,  0   )    long  ->  zero-ref    "V04.[008..016)"
+;* V11 tmp8         [V11    ] (  0,  0   )    long  ->  zero-ref    "V04.[016..024)"
+;* V12 tmp9         [V12    ] (  0,  0   )    long  ->  zero-ref    "V04.[024..032)"
+;* V13 tmp10        [V13    ] (  0,  0   )     int  ->  zero-ref    "V04.[032..036)"
+;* V14 tmp11        [V14    ] (  0,  0   )   ubyte  ->  zero-ref    "V04.[036..037)"
+;  V15 cse0         [V15,T05] (  3,  3   )     ref  ->   r8         "CSE - aggressive"
 ;
-; Lcl frame size = 48
+; Lcl frame size = 0
 
 G_M24033_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 48
-       xor      eax, eax
-       mov      qword ptr [rsp+0x08], rax
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x10], ymm4
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=27 bbWeight=1 PerfScore 7.08
+						;; size=7 bbWeight=1 PerfScore 4.25
 G_M24033_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
        cmp      byte  ptr [rcx], cl
@@ -47,36 +49,35 @@ G_M24033_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        ; byrRegs -[rax]
        cdq      
        idiv     edx:eax, dword ptr [r8+0x08]
-       mov      rax, qword ptr [rcx+0x10]
-       movzx    rcx, byte  ptr [rcx+0x1C]
+       mov      esi, edx
+       mov      rdx, r8
+       ; gcrRegs +[rdx]
+       mov      rdi, qword ptr [rcx+0x10]
+       movzx    rbp, byte  ptr [rcx+0x1C]
+       mov      rcx, rbx
        ; gcrRegs -[rcx]
-       mov      gword ptr [rsp+0x08], r8
-       mov      byte  ptr [rsp+0x2C], cl
-       mov      dword ptr [rsp+0x28], edx
-       mov      qword ptr [rsp+0x10], rax
-       mov      qword ptr [rsp+0x18], rax
-       shl      rax, 4
-       mov      qword ptr [rsp+0x20], rax
-       mov      rdi, rbx
-       ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x08]
-       ; byrRegs +[rsi]
-       call     CORINFO_HELP_ASSIGN_BYREF
-       ; gcrRegs -[r8]
-       mov      ecx, 4
-       rep movsq 
+       ; byrRegs +[rcx]
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+       ; gcrRegs -[rdx r8]
+       ; byrRegs -[rcx]
+       mov      qword ptr [rbx+0x08], rdi
+       mov      qword ptr [rbx+0x10], rdi
+       shl      rdi, 4
+       mov      qword ptr [rbx+0x18], rdi
+       mov      dword ptr [rbx+0x20], esi
+       mov      byte  ptr [rbx+0x24], bpl
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=90 bbWeight=1 PerfScore 86.25
+						;; size=74 bbWeight=1 PerfScore 60.00
 G_M24033_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 48
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=5 bbWeight=1 PerfScore 3.00
 
-; Total bytes of code 125, prolog size 24, PerfScore 96.08, instruction count 38, allocated bytes for code 125 (MethodHash=ac70a21e) for method System.Threading.Tasks.RangeManager:RegisterNewWorker():System.Threading.Tasks.RangeWorker:this (Tier1)
+; Total bytes of code 86, prolog size 4, PerfScore 67.25, instruction count 32, allocated bytes for code 86 (MethodHash=ac70a21e) for method System.Threading.Tasks.RangeManager:RegisterNewWorker():System.Threading.Tasks.RangeWorker:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -84,12 +85,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
+  SizeOfProlog      : 0x04
   CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+37</span> (<span style="color:red">+13.86%</span>) : 33052.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -11,20 +11,20 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
-;  V01 arg1         [V01,T13] (  4,  5.00)   byref  ->  rbx         ld-addr-op single-def
-;  V02 arg2         [V02,T14] (  5,  4.84)   byref  ->  rsi         single-def
+;  V01 arg1         [V01,T11] (  4,  7   )   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg2         [V02,T12] (  5,  4.84)   byref  ->  rbx         single-def
 ;* V03 arg3         [V03    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;* V04 loc0         [V04    ] (  0,  0   )     int  ->  zero-ref   
 ;* V05 loc1         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc2         [V06    ] (  0,  0   )     int  ->  zero-ref   
 ;* V07 loc3         [V07    ] (  0,  0   )     int  ->  zero-ref   
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
-;  V09 loc5         [V09,T12] (  1,100.00)  struct (32) [rsp+0x580]  do-not-enreg[SF] tier0-frame <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
+;  V09 loc5         [V09,T16] (  1,  1   )  struct (32) [rsp+0x590]  do-not-enreg[SF] tier0-frame <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V10 loc6         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <ushort[]>
-;  V11 loc7         [V11,T09] (  3,102.42)  struct (16) [rsp+0x568]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V11 loc7         [V11,T13] (  3,  3   )  struct (16) [rsp+0x578]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V12 loc8         [V12    ] (  0,  0   )     int  ->  zero-ref   
-;  V13 loc9         [V13,T11] (  2,100.00)   byref  ->  rdi        
-;  V14 loc10        [V14,T01] (  7,502.84)     int  ->  [rsp+0x554]  tier0-frame
+;  V13 loc9         [V13,T10] (  2,100.00)   byref  ->  rsi        
+;  V14 loc10        [V14,T01] (  7,502.84)     int  ->  [rsp+0x564]  tier0-frame
 ;* V15 loc11        [V15    ] (  0,  0   )     int  ->  zero-ref   
 ;* V16 loc12        [V16    ] (  0,  0   )     int  ->  zero-ref   
 ;* V17 loc13        [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
@@ -46,8 +46,8 @@
 ;* V33 loc29        [V33    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.RegexNode>
 ;* V34 loc30        [V34    ] (  0,  0   )  struct (24) zero-ref    <System.ValueTuple`4[ushort,System.String,int,ushort[]]>
 ;* V35 loc31        [V35    ] (  0,  0   )     int  ->  zero-ref   
-;  V36 loc32        [V36,T15] (  1,  1   )  struct (40) [rsp+0x440]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
-;  V37 loc33        [V37,T16] (  1,  1   )  struct (16) [rsp+0x430]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V36 loc32        [V36,T17] (  1,  1   )  struct (40) [rsp+0x450]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
+;  V37 loc33        [V37,T18] (  1,  1   )  struct (16) [rsp+0x440]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V38 loc34        [V38    ] (  0,  0   )     int  ->  zero-ref   
 ;* V39 loc35        [V39    ] (  0,  0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -209,13 +209,13 @@
 ;* V196 tmp156      [V196    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V197 tmp157      [V197    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V198 tmp158      [V198    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V199 tmp159      [V199,T10] (  3,100.07)   ubyte  ->  rax         "Inline return value spill temp"
-;  V200 tmp160      [V200,T02] (  4,399.93)     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V199 tmp159      [V199,T09] (  3,100.07)   ubyte  ->  rax         "Inline return value spill temp"
+;  V200 tmp160      [V200,T02] (  4,399.93)     ref  ->  rdx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;  V201 tmp161      [V201,T00] (  6,600.14)  ushort  ->  rcx         "Inlining Arg"
-;  V202 tmp162      [V202,T07] (  3,200.14)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
-;  V203 tmp163      [V203,T03] (  3,299.93)     int  ->  rax         "Inline stloc first use temp"
-;  V204 tmp164      [V204,T04] (  3,299.78)     int  ->   r8         "Inline stloc first use temp"
-;  V205 tmp165      [V205,T05] (  3,299.78)     int  ->  rax         "Inline stloc first use temp"
+;* V202 tmp162      [V202    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
+;  V203 tmp163      [V203,T03] (  3,299.93)     int  ->   r8         "Inline stloc first use temp"
+;  V204 tmp164      [V204,T04] (  3,299.78)     int  ->  rdx         "Inline stloc first use temp"
+;  V205 tmp165      [V205,T05] (  3,299.78)     int  ->   r8         "Inline stloc first use temp"
 ;* V206 tmp166      [V206    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V207 tmp167      [V207    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V208 tmp168      [V208    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
@@ -614,101 +614,117 @@
 ;* V601 tmp561      [V601    ] (  0,  0   )     int  ->  zero-ref    "field V408._length (fldOffset=0x8)" P-INDEP
 ;* V602 tmp562      [V602    ] (  0,  0   )   byref  ->  zero-ref    "field V409._reference (fldOffset=0x0)" P-INDEP
 ;* V603 tmp563      [V603    ] (  0,  0   )     int  ->  zero-ref    "field V409._length (fldOffset=0x8)" P-INDEP
-;* V604 tmp564      [V604    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;* V605 tmp565      [V605    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;* V606 tmp566      [V606    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V607 tmp567      [V607    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V608 tmp568      [V608    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V609 tmp569      [V609    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Span`1[ushort]>
-;  V610 cse0        [V610,T06] (  4,202.84)     int  ->  rbp         "CSE - aggressive"
-;  V611 cse1        [V611,T08] (  2,200.00)     int  ->  r10         "CSE - aggressive"
+;* V604 tmp564      [V604    ] (  0,  0   )   byref  ->  zero-ref    "V01.[000..008)"
+;  V605 tmp565      [V605,T15] (  2,  1.00)     int  ->  rdi         "V01.[008..012)"
+;  V606 tmp566      [V606,T14] (  3,  1.07)     ref  ->  rbp         single-def "V09.[000..008)"
+;  V607 tmp567      [V607,T08] (  2,101.00)   byref  ->  r14         single-def "V11.[000..008)"
+;  V608 tmp568      [V608,T06] (  4,202.42)     int  ->  r15         "V11.[008..012)"
+;* V609 tmp569      [V609    ] (  0,  0   )     ref  ->  zero-ref    "V43.[000..008)"
+;* V610 tmp570      [V610    ] (  0,  0   )     ref  ->  zero-ref    "V43.[008..016)"
+;* V611 tmp571      [V611    ] (  0,  0   )     ref  ->  zero-ref    "V43.[016..024)"
+;* V612 tmp572      [V612    ] (  0,  0   )     int  ->  zero-ref    "V43.[024..028)"
+;* V613 tmp573      [V613    ] (  0,  0   )  ushort  ->  zero-ref    "V43.[028..030)"
+;* V614 tmp574      [V614    ] (  0,  0   )   byref  ->  zero-ref    "Spilling address for field-by-field copy"
+;* V615 tmp575      [V615    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;* V616 tmp576      [V616    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;* V617 tmp577      [V617    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V618 tmp578      [V618    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V619 tmp579      [V619    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V620 tmp580      [V620    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Span`1[ushort]>
+;  V621 cse0        [V621,T07] (  2,200.00)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
-G_M53443_IG01:        ; bbWeight=1.42, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-       mov      qword ptr [rsp+0x5E8], r14
+G_M53443_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       sub      rsp, 88
+       mov      qword ptr [rsp+0x5F8], r15
+       mov      qword ptr [rsp+0x5F0], r14
+       mov      qword ptr [rsp+0x5E8], r13
        mov      qword ptr [rsp+0x5E0], rdi
        mov      qword ptr [rsp+0x5D8], rsi
        mov      qword ptr [rsp+0x5D0], rbx
-       mov      rbx, bword ptr [rsp+0x608]
+       mov      rdx, bword ptr [rsp+0x618]
+       ; byrRegs +[rdx]
+       mov      rbx, bword ptr [rsp+0x620]
        ; byrRegs +[rbx]
-       mov      rsi, bword ptr [rsp+0x610]
+       mov      rsi, bword ptr [rsp+0x568]
        ; byrRegs +[rsi]
-       mov      rdi, bword ptr [rsp+0x558]
-       ; byrRegs +[rdi]
-						;; size=60 bbWeight=1.42 PerfScore 14.58
-G_M53443_IG02:        ; bbWeight=1.42, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, byref
-       mov      ebp, dword ptr [rsp+0x570]
-       mov      r14d, dword ptr [rsp+0x554]
-       cmp      r14d, ebp
+						;; size=76 bbWeight=1 PerfScore 12.25
+G_M53443_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=004C {rdx rbx rsi}, byref
+       mov      edi, dword ptr [rdx+0x08]
+       mov      rbp, gword ptr [rsp+0x590]
+       ; gcrRegs +[rbp]
+       mov      r14, bword ptr [rsp+0x578]
+       ; byrRegs +[r14]
+       mov      r15d, dword ptr [rsp+0x580]
+       mov      r13d, dword ptr [rsp+0x564]
+       cmp      r13d, r15d
        jge      G_M53443_IG12
-						;; size=24 bbWeight=1.42 PerfScore 4.62
-G_M53443_IG03:        ; bbWeight=100.00, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
-       cmp      r14d, ebp
+						;; size=44 bbWeight=1 PerfScore 7.25
+G_M53443_IG03:        ; bbWeight=100.00, gcrefRegs=0020 {rbp}, byrefRegs=4048 {rbx rsi r14}, byref, isz
+       ; byrRegs -[rdx]
+       cmp      r13d, r15d
        jae      G_M53443_IG14
-       mov      rcx, bword ptr [rsp+0x568]
-       ; byrRegs +[rcx]
-       mov      edx, r14d
-       movzx    rcx, word  ptr [rcx+2*rdx]
-       ; byrRegs -[rcx]
-       mov      rdx, gword ptr [rsp+0x580]
+       mov      ecx, r13d
+       movzx    rcx, word  ptr [r14+2*rcx]
+       mov      rdx, gword ptr [rsi]
        ; gcrRegs +[rdx]
-       mov      r8, gword ptr [rdi]
-       ; gcrRegs +[r8]
-       test     r8, r8
+       test     rdx, rdx
        je       SHORT G_M53443_IG06
-       mov      eax, ecx
-       sar      eax, 4
-       mov      r10d, dword ptr [r8+0x08]
-       cmp      r10d, eax
+       mov      r8d, ecx
+       sar      r8d, 4
+       mov      eax, dword ptr [rdx+0x08]
+       cmp      eax, r8d
        jbe      SHORT G_M53443_IG06
-						;; size=54 bbWeight=100.00 PerfScore 1275.00
-G_M53443_IG04:        ; bbWeight=99.93, gcrefRegs=0104 {rdx r8}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
-       mov      eax, eax
-       mov      r8d, dword ptr [r8+4*rax+0x10]
-       ; gcrRegs -[r8]
-       mov      eax, ecx
-       and      eax, 15
-       add      eax, eax
-       mov      r10d, 1
-       shlx     eax, r10d, eax
-       test     r8d, eax
-       je       SHORT G_M53443_IG06
-       add      eax, eax
-       test     r8d, eax
-       je       SHORT G_M53443_IG08
-						;; size=37 bbWeight=99.93 PerfScore 649.53
-G_M53443_IG05:        ; bbWeight=49.96, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, byref, isz
+						;; size=40 bbWeight=100.00 PerfScore 1075.00
+G_M53443_IG04:        ; bbWeight=99.93, gcrefRegs=0024 {rdx rbp}, byrefRegs=4048 {rbx rsi r14}, byref, isz
+       mov      r8d, r8d
+       mov      edx, dword ptr [rdx+4*r8+0x10]
        ; gcrRegs -[rdx]
-       ; byrRegs -[rbx rdi]
+       mov      r8d, ecx
+       and      r8d, 15
+       add      r8d, r8d
+       mov      eax, 1
+       shlx     r8d, eax, r8d
+       test     edx, r8d
+       je       SHORT G_M53443_IG06
+       add      r8d, r8d
+       test     edx, r8d
+       je       SHORT G_M53443_IG08
+						;; size=41 bbWeight=99.93 PerfScore 649.53
+G_M53443_IG05:        ; bbWeight=49.96, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rbp]
+       ; byrRegs -[rsi r14]
        jmp      SHORT G_M53443_IG10
 						;; size=2 bbWeight=49.96 PerfScore 99.93
-G_M53443_IG06:        ; bbWeight=0.07, gcrefRegs=0004 {rdx}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
-       ; gcrRegs +[rdx]
-       ; byrRegs +[rbx rdi]
+G_M53443_IG06:        ; bbWeight=0.07, gcrefRegs=0020 {rbp}, byrefRegs=4048 {rbx rsi r14}, byref, isz
+       ; gcrRegs +[rbp]
+       ; byrRegs +[rsi r14]
        cmp      ecx, 128
        jl       SHORT G_M53443_IG15
+       mov      rdx, rbp
+       ; gcrRegs +[rdx]
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
-						;; size=17 bbWeight=0.07 PerfScore 0.33
-G_M53443_IG07:        ; bbWeight=100.00, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
+						;; size=20 bbWeight=0.07 PerfScore 0.34
+G_M53443_IG07:        ; bbWeight=100.00, gcrefRegs=0020 {rbp}, byrefRegs=4048 {rbx rsi r14}, byref, isz
        test     eax, eax
        jne      SHORT G_M53443_IG10
 						;; size=4 bbWeight=100.00 PerfScore 125.00
-G_M53443_IG08:        ; bbWeight=100, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
-       inc      r14d
-       cmp      r14d, ebp
+G_M53443_IG08:        ; bbWeight=100, gcrefRegs=0020 {rbp}, byrefRegs=4048 {rbx rsi r14}, byref, isz
+       inc      r13d
+       cmp      r13d, r15d
        jge      SHORT G_M53443_IG12
 						;; size=8 bbWeight=100 PerfScore 150.00
-G_M53443_IG09:        ; bbWeight=0.71, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
+G_M53443_IG09:        ; bbWeight=0.71, gcrefRegs=0020 {rbp}, byrefRegs=4048 {rbx rsi r14}, byref, isz
        jmp      SHORT G_M53443_IG03
 						;; size=2 bbWeight=0.71 PerfScore 1.42
-G_M53443_IG10:        ; bbWeight=1.42, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, byref
-       ; byrRegs -[rbx rdi]
-       add      dword ptr [rsi], r14d
+G_M53443_IG10:        ; bbWeight=1.42, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs -[rbp]
+       ; byrRegs -[rsi r14]
+       add      dword ptr [rbx], r13d
        mov      eax, 1
 						;; size=8 bbWeight=1.42 PerfScore 4.62
 G_M53443_IG11:        ; bbWeight=1.42, epilog, nogc, extend
@@ -716,43 +732,47 @@ G_M53443_IG11:        ; bbWeight=1.42, epilog, nogc, extend
        pop      rbx
        pop      rsi
        pop      rdi
+       pop      r13
        pop      r14
+       pop      r15
        pop      rbp
...

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+14.11%</span>) : 68170.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,18 +9,22 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T04] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Binder>
-;  V01 RetBuf       [V01,T01] (  4,  4   )   byref  ->  rbx         single-def
-;  V02 arg1         [V02,T02] (  4,  3.50)     ref  ->  rbp         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
+;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rbx         single-def
+;  V02 arg1         [V02,T03] (  4,  3.50)     ref  ->  rbp         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  5,  5   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V05 tmp2         [V05,T00] (  5,  6   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
-;  V06 tmp3         [V06,T05] (  2,  2   )     ref  ->  r15         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
+;  V04 tmp1         [V04,T02] (  3,  6   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
+;  V05 tmp2         [V05,T01] (  5,  6   )     ref  ->  r14         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
+;  V06 tmp3         [V06,T06] (  2,  2   )     ref  ->  r15         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
+;  V07 tmp4         [V07,T05] (  3,  2   )     ref  ->  r13         "V04.[016..024)"
+;  V08 tmp5         [V08,T07] (  4,  1.50)   ubyte  ->  r12         "V04.[025..026)"
 ;
 ; Lcl frame size = 72
 
 G_M51640_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
@@ -35,7 +39,7 @@ G_M51640_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs +[rbx]
        mov      rbp, r8
        ; gcrRegs +[rbp]
-						;; size=40 bbWeight=1 PerfScore 11.33
+						;; size=44 bbWeight=1 PerfScore 13.33
 G_M51640_IG02:        ; bbWeight=1, gcrefRegs=0022 {rcx rbp}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs +[rcx]
        mov      r14, gword ptr [rcx+0x08]
@@ -47,40 +51,47 @@ G_M51640_IG03:        ; bbWeight=1, gcrefRegs=4020 {rbp r14}, byrefRegs=0008 {rb
        ; gcrRegs -[rcx]
        mov      r15, gword ptr [r14+0xC8]
        ; gcrRegs +[r15]
+       xor      r13, r13
+       ; gcrRegs +[r13]
        vxorps   ymm0, ymm0, ymm0
        vmovdqu  ymmword ptr [rsp+0x28], ymm0
        test     rbp, rbp
        je       SHORT G_M51640_IG08
-						;; size=22 bbWeight=1 PerfScore 4.58
-G_M51640_IG04:        ; bbWeight=0.50, gcrefRegs=8020 {rbp r15}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=25 bbWeight=1 PerfScore 4.83
+G_M51640_IG04:        ; bbWeight=0.50, gcrefRegs=A020 {rbp r13 r15}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[r14]
        cmp      gword ptr [rbp+0x10], 0
        jne      SHORT G_M51640_IG09
-       mov      byte  ptr [rsp+0x41], 1
-						;; size=12 bbWeight=0.50 PerfScore 2.50
-G_M51640_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       mov      r12d, 1
+						;; size=13 bbWeight=0.50 PerfScore 2.12
+G_M51640_IG05:        ; bbWeight=1, gcrefRegs=2000 {r13}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rbp r15]
+       mov      gword ptr [rsp+0x38], r13
        mov      rdi, rbx
        ; byrRegs +[rdi]
        lea      rsi, bword ptr [rsp+0x28]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[r13]
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
        movsq    
+       mov      byte  ptr [rbx+0x19], r12b
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=28 bbWeight=1 PerfScore 5.00
+						;; size=37 bbWeight=1 PerfScore 7.00
 G_M51640_IG06:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 72
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r12
+       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
+						;; size=17 bbWeight=1 PerfScore 5.25
 G_M51640_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=4020 {rbp r14}, byrefRegs=0008 {rbx}, gcvars, byref, isz
        ; gcrRegs +[rbp r14]
        ; byrRegs -[rax rsi rdi]
@@ -94,18 +105,20 @@ G_M51640_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=4020 {
        ; gcr arg pop 0
        jmp      SHORT G_M51640_IG03
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M51640_IG08:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       ; gcrRegs -[rbp r14]
-       mov      byte  ptr [rsp+0x41], 2
+G_M51640_IG08:        ; bbWeight=0, gcrefRegs=2000 {r13}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rbp r14] +[r13]
+       mov      r12d, 2
        jmp      SHORT G_M51640_IG05
-						;; size=7 bbWeight=0 PerfScore 0.00
+						;; size=8 bbWeight=0 PerfScore 0.00
 G_M51640_IG09:        ; bbWeight=0, gcrefRegs=8000 {r15}, byrefRegs=0008 {rbx}, byref, isz
-       ; gcrRegs +[r15]
-       mov      gword ptr [rsp+0x38], r15
+       ; gcrRegs -[r13] +[r15]
+       xor      r12d, r12d
+       mov      r13, r15
+       ; gcrRegs +[r13]
        jmp      SHORT G_M51640_IG05
-						;; size=7 bbWeight=0 PerfScore 0.00
+						;; size=8 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 163, prolog size 34, PerfScore 33.67, instruction count 49, allocated bytes for code 163 (MethodHash=2afd3647) for method Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (Tier1)
+; Total bytes of code 186, prolog size 38, PerfScore 38.54, instruction count 57, allocated bytes for code 186 (MethodHash=2afd3647) for method Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -113,15 +126,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x10
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r12 (12)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+21.38%</span>) : 36213.dasm - System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -9,93 +9,103 @@
 ; with Dynamic PGO: edge weights are valid, and fgCalledCount is 102.06
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T03] (  5,404.61)   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T00] (  7,604.61)   byref  ->  rdx         ld-addr-op single-def
-;  V02 arg2         [V02,T08] (  3,101.90)    long  ->   r8         single-def
-;  V03 loc0         [V03,T01] (  8,600.57)    long  ->  [rsp+0x70]  tier0-frame
-;  V04 loc1         [V04,T02] (  7,599.51)     int  ->  [rsp+0x6C]  tier0-frame
-;  V05 loc2         [V05,T05] (  3,299.71)     int  ->  r11        
-;  V06 loc3         [V06,T04] (  3,299.71)   byref  ->   r9        
+;  V00 arg0         [V00,T11] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
+;  V01 arg1         [V01,T12] (  5,  9   )   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg2         [V02,T07] (  3,101.90)    long  ->   r8         single-def
+;  V03 loc0         [V03,T00] (  8,600.57)    long  ->  [rsp+0x80]  tier0-frame
+;  V04 loc1         [V04,T01] (  7,599.51)     int  ->  [rsp+0x7C]  tier0-frame
+;  V05 loc2         [V05,T03] (  3,299.71)     int  ->  rsi        
+;  V06 loc3         [V06,T02] (  3,299.71)   byref  ->  r11        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 cse0         [V08,T06] (  3,299.71)     int  ->  rbx         "CSE - aggressive"
-;  V09 cse1         [V09,T07] (  3,299.71)    long  ->   r9         "CSE - aggressive"
+;  V08 tmp1         [V08,T08] (  2,100.90)   byref  ->  rax         single-def "V00.[000..008)"
+;  V09 tmp2         [V09,T10] (  2,100.90)     int  ->  rcx         "V00.[008..012)"
+;  V10 tmp3         [V10,T09] (  2,100.90)   byref  ->  r10         single-def "V01.[000..008)"
+;  V11 tmp4         [V11,T06] (  4,200.90)     int  ->  rdx         "V01.[008..012)"
+;  V12 cse0         [V12,T04] (  3,299.71)     int  ->  rdi         "CSE - aggressive"
+;  V13 cse1         [V13,T05] (  3,299.71)    long  ->  r11         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
-G_M60135_IG01:        ; bbWeight=0.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
+G_M60135_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       sub      rsp, 56
+       mov      qword ptr [rsp+0xB8], rdi
+       mov      qword ptr [rsp+0xB0], rsi
        mov      qword ptr [rsp+0xA8], rbx
-       mov      rcx, bword ptr [rsp+0xC0]
+       mov      rcx, bword ptr [rsp+0xD0]
        ; byrRegs +[rcx]
-       mov      rdx, bword ptr [rsp+0xC8]
+       mov      rdx, bword ptr [rsp+0xD8]
        ; byrRegs +[rdx]
-       mov      r8, qword ptr [rsp+0xD0]
-						;; size=36 bbWeight=0.10 PerfScore 0.71
-G_M60135_IG02:        ; bbWeight=0.10, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
-       mov      eax, dword ptr [rsp+0x6C]
-       cmp      eax, dword ptr [rdx+0x08]
-       jge      SHORT G_M60135_IG09
-						;; size=9 bbWeight=0.10 PerfScore 0.49
-G_M60135_IG03:        ; bbWeight=99.90, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
-       cmp      eax, dword ptr [rdx+0x08]
-       jae      SHORT G_M60135_IG10
+       mov      r8, qword ptr [rsp+0xE0]
+						;; size=52 bbWeight=1 PerfScore 9.25
+G_M60135_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
+       mov      rax, bword ptr [rcx]
+       ; byrRegs +[rax]
+       mov      ecx, dword ptr [rcx+0x08]
+       ; byrRegs -[rcx]
        mov      r10, bword ptr [rdx]
        ; byrRegs +[r10]
-       mov      r9d, eax
-       mov      r10d, dword ptr [r10+4*r9]
-       ; byrRegs -[r10]
-       imul     r10, r8
-       add      r10, qword ptr [rsp+0x70]
-       mov      r11d, r10d
-       shr      r10, 32
-       cmp      eax, dword ptr [rcx+0x08]
+       mov      edx, dword ptr [rdx+0x08]
+       ; byrRegs -[rdx]
+       mov      r9d, dword ptr [rsp+0x7C]
+       cmp      r9d, edx
+       jge      SHORT G_M60135_IG09
+						;; size=22 bbWeight=1 PerfScore 10.25
+G_M60135_IG03:        ; bbWeight=99.90, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
+       cmp      r9d, edx
        jae      SHORT G_M60135_IG10
-       mov      rbx, bword ptr [rcx]
-       ; byrRegs +[rbx]
-       lea      r9, bword ptr [rbx+4*r9]
-       ; byrRegs +[r9]
-       mov      ebx, dword ptr [r9]
-       ; byrRegs -[rbx]
-       cmp      ebx, r11d
+       mov      r11d, r9d
+       mov      ebx, dword ptr [r10+4*r11]
+       imul     rbx, r8
+       add      rbx, qword ptr [rsp+0x80]
+       mov      esi, ebx
+       shr      rbx, 32
+       cmp      r9d, ecx
+       jae      SHORT G_M60135_IG10
+       lea      r11, bword ptr [rax+4*r11]
+       ; byrRegs +[r11]
+       mov      edi, dword ptr [r11]
+       cmp      edi, esi
        jae      SHORT G_M60135_IG05
-						;; size=51 bbWeight=99.90 PerfScore 2272.77
-G_M60135_IG04:        ; bbWeight=50.48, gcrefRegs=0000 {}, byrefRegs=0206 {rcx rdx r9}, byref
-       inc      r10
+						;; size=46 bbWeight=99.90 PerfScore 1323.70
+G_M60135_IG04:        ; bbWeight=50.48, gcrefRegs=0000 {}, byrefRegs=0C01 {rax r10 r11}, byref
+       inc      rbx
 						;; size=3 bbWeight=50.48 PerfScore 12.62
-G_M60135_IG05:        ; bbWeight=99.90, gcrefRegs=0000 {}, byrefRegs=0206 {rcx rdx r9}, byref, isz
-       sub      ebx, r11d
-       mov      dword ptr [r9], ebx
-       inc      eax
-       cmp      eax, dword ptr [rdx+0x08]
+G_M60135_IG05:        ; bbWeight=99.90, gcrefRegs=0000 {}, byrefRegs=0C01 {rax r10 r11}, byref, isz
+       sub      edi, esi
+       mov      dword ptr [r11], edi
+       inc      r9d
+       cmp      r9d, edx
        jl       SHORT G_M60135_IG08
-						;; size=13 bbWeight=99.90 PerfScore 549.46
+						;; size=13 bbWeight=99.90 PerfScore 274.73
 G_M60135_IG06:        ; bbWeight=0.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rcx rdx r9]
-       mov      eax, r10d
-						;; size=3 bbWeight=0.10 PerfScore 0.02
+       ; byrRegs -[rax r10-r11]
+       mov      eax, ebx
+						;; size=2 bbWeight=0.10 PerfScore 0.02
 G_M60135_IG07:        ; bbWeight=0.10, epilog, nogc, extend
        add      rsp, 168
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=10 bbWeight=0.10 PerfScore 0.22
-G_M60135_IG08:        ; bbWeight=49.95, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, gcvars, byref, isz
-       ; byrRegs +[rcx rdx]
-       mov      qword ptr [rsp+0x70], r10
+						;; size=12 bbWeight=0.10 PerfScore 0.32
+G_M60135_IG08:        ; bbWeight=49.95, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, gcvars, byref, isz
+       ; byrRegs +[rax r10]
+       mov      qword ptr [rsp+0x80], rbx
        jmp      SHORT G_M60135_IG03
-						;; size=7 bbWeight=49.95 PerfScore 149.85
+						;; size=10 bbWeight=49.95 PerfScore 149.85
 G_M60135_IG09:        ; bbWeight=0.05, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[rcx rdx]
-       mov      r10, qword ptr [rsp+0x70]
+       ; byrRegs -[rax r10]
+       mov      rbx, qword ptr [rsp+0x80]
        jmp      SHORT G_M60135_IG06
-						;; size=7 bbWeight=0.05 PerfScore 0.15
+						;; size=10 bbWeight=0.05 PerfScore 0.15
 G_M60135_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 145, prolog size 36, PerfScore 2986.30, instruction count 41, allocated bytes for code 145 (MethodHash=01ed1518) for method System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)
+; Total bytes of code 176, prolog size 52, PerfScore 1780.89, instruction count 47, allocated bytes for code 176 (MethodHash=01ed1518) for method System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -103,14 +113,18 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 10
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 21 * 8 = 168 = 0x000A8
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 22 * 8 = 176 = 0x000B0
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 23 * 8 = 184 = 0x000B8
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
       Size: 17 * 8 = 136 = 0x00088
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-43</span> (<span style="color:green">-54.43%</span>) : 28087.dasm - ProtoBuf.Internal.BasicList:GetEnumerator():ProtoBuf.Internal.BasicList+NodeEnumerator:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,56 +9,47 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <ProtoBuf.Internal.BasicList>
-;  V01 RetBuf       [V01,T02] (  4,  4   )   byref  ->  rbx         single-def
+;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  4,  8   )  struct (24) [rsp+0x08]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <ProtoBuf.Internal.BasicList+NodeEnumerator>
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <ProtoBuf.Internal.BasicList+NodeEnumerator>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <ProtoBuf.Internal.BasicList+Node>
-;  V05 tmp3         [V05,T03] (  2,  2   )     ref  ->  rax         single-def "field V04.data (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T04] (  2,  2   )     int  ->  rcx         "field V04.<Length>k__BackingField (fldOffset=0x8)" P-INDEP
+;  V05 tmp3         [V05,T02] (  2,  2   )     ref  ->  rdx         single-def "field V04.data (fldOffset=0x0)" P-INDEP
+;  V06 tmp4         [V06,T03] (  2,  2   )     int  ->  rsi         "field V04.<Length>k__BackingField (fldOffset=0x8)" P-INDEP
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V03.[000..004)"
+;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    single-def "V03.[008..016)"
+;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "V03.[016..020)"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 0
 
 G_M44506_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 32
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqu  xmmword ptr [rsp+0x08], xmm4
-       xor      eax, eax
-       mov      qword ptr [rsp+0x18], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=27 bbWeight=1 PerfScore 7.08
+						;; size=5 bbWeight=1 PerfScore 2.25
 G_M44506_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       mov      ecx, dword ptr [rcx+0x10]
+       mov      rdx, gword ptr [rcx+0x08]
+       ; gcrRegs +[rdx]
+       mov      esi, dword ptr [rcx+0x10]
+       mov      dword ptr [rbx], -1
+       lea      rcx, bword ptr [rbx+0x08]
        ; gcrRegs -[rcx]
-       mov      dword ptr [rsp+0x08], -1
-       mov      gword ptr [rsp+0x10], rax
-       mov      dword ptr [rsp+0x18], ecx
-       mov      rdi, rbx
-       ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x08]
-       ; byrRegs +[rsi]
-       movsq    
-       call     CORINFO_HELP_ASSIGN_BYREF
-       ; gcrRegs -[rax]
-       movsq    
+       ; byrRegs +[rcx]
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+       ; gcrRegs -[rdx]
+       ; byrRegs -[rcx]
+       mov      dword ptr [rbx+0x10], esi
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=44 bbWeight=1 PerfScore 11.00
+						;; size=28 bbWeight=1 PerfScore 7.75
 G_M44506_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
        pop      rbx
        pop      rsi
-       pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 79, prolog size 24, PerfScore 20.83, instruction count 25, allocated bytes for code 79 (MethodHash=01195225) for method ProtoBuf.Internal.BasicList:GetEnumerator():ProtoBuf.Internal.BasicList+NodeEnumerator:this (Tier1)
+; Total bytes of code 36, prolog size 2, PerfScore 12.00, instruction count 13, allocated bytes for code 36 (MethodHash=01195225) for method ProtoBuf.Internal.BasicList:GetEnumerator():ProtoBuf.Internal.BasicList+NodeEnumerator:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -66,12 +57,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x02
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-38</span> (<span style="color:green">-50.67%</span>) : 17622.dasm - System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]]):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,64 +10,53 @@
 ;
 ;  V00 this         [V00,T03] (  3,  3   )     ref  ->  rbx         this class-hnd single-def <System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]>
 ;  V01 arg1         [V01,T00] (  3,  6   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 loc0         [V02,T07] (  2,  2   )  struct (24) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op <System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]>
+;* V02 loc0         [V02    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V05 tmp2         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V06 tmp3         [V06,T04] (  3,  5   )     ref  ->  rcx         class-hnd exact single-def "dup spill" <System.Collections.Immutable.ImmutableList`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
+;* V06 tmp3         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "dup spill" <System.Collections.Immutable.ImmutableList`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
 ;* V07 tmp4         [V07    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;* V08 cse0         [V08,T06] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
-;* V09 rat0         [V09,T05] (  0,  0   )    long  ->  zero-ref    "Spilling to split statement for tree"
-;* V10 rat1         [V10,T08] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
-;* V11 rat2         [V11,T01] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
-;* V12 rat3         [V12,T09] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
-;* V13 rat4         [V13,T02] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
+;  V08 tmp5         [V08,T06] (  3,  2.50)     ref  ->  rcx         single-def "V02.[000..008)"
+;* V09 cse0         [V09,T05] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
+;* V10 rat0         [V10,T04] (  0,  0   )    long  ->  zero-ref    "Spilling to split statement for tree"
+;* V11 rat1         [V11,T07] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;* V12 rat2         [V12,T01] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
+;* V13 rat3         [V13,T08] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;* V14 rat4         [V14,T02] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 48
 
 G_M20412_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 64
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqa  xmmword ptr [rsp+0x20], xmm4
-       xor      eax, eax
-       mov      qword ptr [rsp+0x30], rax
-       mov      qword ptr [rsp+0x38], rcx
+       sub      rsp, 48
+       mov      qword ptr [rsp+0x28], rcx
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=30 bbWeight=1 PerfScore 6.08
-G_M20412_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0004 {rdx}, byref
+						;; size=13 bbWeight=1 PerfScore 2.50
+G_M20412_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0004 {rdx}, byref, isz
        ; byrRegs +[rdx]
        cmp      dword ptr [rbx], ebx
-						;; size=2 bbWeight=1 PerfScore 3.00
-G_M20412_IG03:        ; bbWeight=1, nogc, extend
-       vmovdqu  xmm0, xmmword ptr [rdx+0x08]
-       vmovdqu  xmmword ptr [rsp+0x20], xmm0
-       mov      rcx, qword ptr [rdx+0x18]
-       mov      qword ptr [rsp+0x30], rcx
-						;; size=20 bbWeight=1 PerfScore 8.00
-G_M20412_IG04:        ; bbWeight=1, isz, extend
-       mov      rcx, gword ptr [rsp+0x20]
+       mov      rcx, gword ptr [rdx+0x08]
        ; gcrRegs +[rcx]
        test     rcx, rcx
-       je       SHORT G_M20412_IG06
-						;; size=10 bbWeight=1 PerfScore 2.25
-G_M20412_IG05:        ; bbWeight=0.50, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
+       je       SHORT G_M20412_IG04
+						;; size=11 bbWeight=1 PerfScore 6.25
+G_M20412_IG03:        ; bbWeight=0.50, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref
        ; byrRegs -[rdx]
        call     [System.Collections.Immutable.ImmutableList`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:Freeze():this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
 						;; size=6 bbWeight=0.50 PerfScore 1.50
-G_M20412_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M20412_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        nop      
 						;; size=1 bbWeight=1 PerfScore 0.25
-G_M20412_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+G_M20412_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 48
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 75, prolog size 27, PerfScore 22.83, instruction count 21, allocated bytes for code 75 (MethodHash=5457b043) for method System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]]):this (Tier1)
+; Total bytes of code 37, prolog size 10, PerfScore 12.25, instruction count 13, allocated bytes for code 37 (MethodHash=5457b043) for method System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]]):this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -80,5 +69,5 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-42.86%</span>) : 44330.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList:GetEnumerator():Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList+Enumerator:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,53 +8,50 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  3,  3   )   byref  ->  rcx         this single-def
-;  V01 RetBuf       [V01,T01] (  4,  4   )   byref  ->  rbx         single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
+;  V01 RetBuf       [V01,T00] (  8,  8   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  4,  8   )  struct (32) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList+Enumerator>
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList+Enumerator>
 ;* V04 tmp2         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <Microsoft.CodeAnalysis.GreenNode>
+;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    "V03.[000..008)"
+;* V06 tmp4         [V06    ] (  0,  0   )     ref  ->  zero-ref    "V03.[008..016)"
+;* V07 tmp5         [V07    ] (  0,  0   )     ref  ->  zero-ref    "V03.[016..024)"
+;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V03.[024..028)"
+;* V09 tmp7         [V09    ] (  0,  0   )     int  ->  zero-ref    "V03.[028..032)"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 0
 
 G_M2490_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rdi
-       push     rsi
        push     rbx
-       sub      rsp, 32
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp], ymm4
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=19 bbWeight=1 PerfScore 5.83
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M2490_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
        ; byrRegs +[rcx]
-       mov      rax, gword ptr [rcx]
-       ; gcrRegs +[rax]
-       mov      gword ptr [rsp], rax
-       mov      dword ptr [rsp+0x18], -1
-       mov      dword ptr [rsp+0x1C], -1
-       mov      rdi, rbx
-       ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp]
-       ; byrRegs +[rsi]
-       call     CORINFO_HELP_ASSIGN_BYREF
-       ; gcrRegs -[rax]
+       mov      rdx, gword ptr [rcx]
+       ; gcrRegs +[rdx]
+       mov      rcx, rbx
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+       ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       call     CORINFO_HELP_ASSIGN_BYREF
-       call     CORINFO_HELP_ASSIGN_BYREF
-       movsq    
+       xor      rax, rax
+       ; gcrRegs +[rax]
+       mov      gword ptr [rbx+0x08], rax
+						;; size=17 bbWeight=1 PerfScore 4.50
+G_M2490_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs -[rax]
+       mov      gword ptr [rbx+0x10], rax
+       mov      dword ptr [rbx+0x18], -1
+       mov      dword ptr [rbx+0x1C], -1
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=50 bbWeight=1 PerfScore 10.00
-G_M2490_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
+						;; size=21 bbWeight=1 PerfScore 3.25
+G_M2490_IG04:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
-       pop      rsi
-       pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=2 bbWeight=1 PerfScore 1.50
 
-; Total bytes of code 77, prolog size 16, PerfScore 18.58, instruction count 23, allocated bytes for code 77 (MethodHash=cda0f645) for method Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList:GetEnumerator():Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList+Enumerator:this (Tier1)
+; Total bytes of code 44, prolog size 1, PerfScore 10.50, instruction count 13, allocated bytes for code 44 (MethodHash=cda0f645) for method Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList:GetEnumerator():Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList+Enumerator:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -62,12 +59,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x01
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+16</span> (<span style="color:red">+11.59%</span>) : 20847.dasm - System.Linq.Enumerable+SelectRangeIterator`1[System.__Canon]:Fill(System.Span`1[System.__Canon],int,System.Func`2[int,System.__Canon]) (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -9,80 +9,85 @@
 ; Final local variable assignments
 ;
 ;* V00 TypeCtx      [V00    ] (  0,  0   )    long  ->  zero-ref    single-def
-;  V01 arg0         [V01,T00] (  7, 31   )   byref  ->  rbx         ld-addr-op single-def
-;  V02 arg1         [V02,T02] (  5, 14   )     int  ->  rsi        
-;  V03 arg2         [V03,T03] (  4, 10   )     ref  ->  rdi         class-hnd single-def <System.Func`2[int,System.__Canon]>
-;  V04 loc0         [V04,T01] (  6, 21   )     int  ->  [rsp+0x8C]  tier0-frame
+;  V01 arg0         [V01,T04] (  5,  5.04)   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg1         [V02,T01] (  5, 14   )     int  ->  rbx        
+;  V03 arg2         [V03,T02] (  4, 10   )     ref  ->  rsi         class-hnd single-def <System.Func`2[int,System.__Canon]>
+;  V04 loc0         [V04,T00] (  6, 21   )     int  ->  [rsp+0x9C]  tier0-frame
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )   byref  ->  zero-ref    "non-inline candidate call"
-;  TEMP_01                                   byref  ->  [rsp+0x20]
+;  V07 tmp2         [V07,T05] (  2,  4.01)   byref  ->  rdi         single-def "V01.[000..008)"
+;  V08 tmp3         [V08,T03] (  4,  9.01)     int  ->  rbp         "V01.[008..012)"
+;  TEMP_01                                   byref  ->  [rsp+0x28]
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
-G_M58477_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-       mov      qword ptr [rsp+0xC8], rdi
-       mov      qword ptr [rsp+0xC0], rsi
-       mov      qword ptr [rsp+0xB8], rbx
+G_M58477_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       sub      rsp, 88
+       mov      qword ptr [rsp+0xD8], r14
+       mov      qword ptr [rsp+0xD0], rdi
+       mov      qword ptr [rsp+0xC8], rsi
+       mov      qword ptr [rsp+0xC0], rbx
        xor      eax, eax
-       mov      qword ptr [rsp+0x20], rax
-       mov      rbx, bword ptr [rsp+0xE8]
-       ; byrRegs +[rbx]
-       mov      esi, dword ptr [rsp+0xF0]
-       mov      rdi, gword ptr [rsp+0xF8]
-       ; gcrRegs +[rdi]
-						;; size=58 bbWeight=1 PerfScore 10.50
-G_M58477_IG02:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0008 {rbx}, byref, isz
-       mov      ebp, dword ptr [rsp+0x8C]
-       cmp      ebp, dword ptr [rbx+0x08]
-       jge      SHORT G_M58477_IG04
-						;; size=12 bbWeight=1 PerfScore 5.00
-G_M58477_IG03:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0008 {rbx}, byref, isz
-       cmp      ebp, dword ptr [rbx+0x08]
-       jae      SHORT G_M58477_IG05
-       mov      rdx, bword ptr [rbx]
+       mov      qword ptr [rsp+0x28], rax
+       mov      rdx, bword ptr [rsp+0xF8]
        ; byrRegs +[rdx]
-       mov      ecx, ebp
-       lea      rcx, bword ptr [rdx+8*rcx]
-       ; byrRegs +[rcx]
-       mov      bword ptr [rsp+0x20], rcx
-       mov      edx, esi
+       mov      ebx, dword ptr [rsp+0x100]
+       mov      rsi, gword ptr [rsp+0x108]
+       ; gcrRegs +[rsi]
+						;; size=66 bbWeight=0.01 PerfScore 0.12
+G_M58477_IG02:        ; bbWeight=0.01, gcrefRegs=0040 {rsi}, byrefRegs=0004 {rdx}, byref, isz
+       mov      rdi, bword ptr [rdx]
+       ; byrRegs +[rdi]
+       mov      ebp, dword ptr [rdx+0x08]
+       mov      r14d, dword ptr [rsp+0x9C]
+       cmp      r14d, ebp
+       jge      SHORT G_M58477_IG04
+						;; size=19 bbWeight=0.01 PerfScore 0.06
+G_M58477_IG03:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref, isz
        ; byrRegs -[rdx]
-       mov      rcx, gword ptr [rdi+0x08]
+       cmp      r14d, ebp
+       jae      SHORT G_M58477_IG05
+       mov      edx, r14d
+       lea      rcx, bword ptr [rdi+8*rdx]
+       ; byrRegs +[rcx]
+       mov      bword ptr [rsp+0x28], rcx
+       mov      edx, ebx
+       mov      rcx, gword ptr [rsi+0x08]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
-       call     [rdi+0x18]<unknown method>
+       call     [rsi+0x18]<unknown method>
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       mov      rcx, bword ptr [rsp+0x20]
+       mov      rcx, bword ptr [rsp+0x28]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
-       inc      ebp
-       inc      esi
-       cmp      ebp, dword ptr [rbx+0x08]
+       inc      r14d
+       inc      ebx
+       cmp      r14d, ebp
        jl       SHORT G_M58477_IG03
-						;; size=50 bbWeight=4 PerfScore 79.00
+						;; size=49 bbWeight=4 PerfScore 49.00
 G_M58477_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rdi]
-       ; byrRegs -[rbx]
-       add      rsp, 184
+       ; gcrRegs -[rsi]
+       ; byrRegs -[rdi]
+       add      rsp, 192
        pop      rbx
        pop      rsi
        pop      rdi
+       pop      r14
        pop      rbp
        ret      
-						;; size=12 bbWeight=1 PerfScore 3.25
+						;; size=14 bbWeight=1 PerfScore 3.75
 G_M58477_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 138, prolog size 35, PerfScore 97.75, instruction count 36, allocated bytes for code 138 (MethodHash=3a911b92) for method System.Linq.Enumerable+SelectRangeIterator`1[System.__Canon]:Fill(System.Span`1[System.__Canon],int,System.Func`2[int,System.__Canon]) (Tier1-OSR)
+; Total bytes of code 154, prolog size 43, PerfScore 52.93, instruction count 39, allocated bytes for code 154 (MethodHash=3a911b92) for method System.Linq.Enumerable+SelectRangeIterator`1[System.__Canon]:Fill(System.Span`1[System.__Canon],int,System.Func`2[int,System.__Canon]) (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -90,18 +95,20 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x1C
-  CountOfUnwindCodes: 10
+  SizeOfProlog      : 0x24
+  CountOfUnwindCodes: 12
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 23 * 8 = 184 = 0x000B8
-    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+    CodeOffset: 0x24 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 24 * 8 = 192 = 0x000C0
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
       Scaled Small Offset: 25 * 8 = 200 = 0x000C8
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 26 * 8 = 208 = 0x000D0
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: r14 (14)
+      Scaled Small Offset: 27 * 8 = 216 = 0x000D8
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 10 * 8 + 8 = 88 = 0x58
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
       Size: 17 * 8 = 136 = 0x00088
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+21.38%</span>) : 25647.dasm - System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -8,93 +8,103 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T03] (  5, 21   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T00] (  7, 31   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 arg2         [V02,T08] (  3,  6   )    long  ->   r8         single-def
-;  V03 loc0         [V03,T01] (  8, 25   )    long  ->  [rsp+0x70]  tier0-frame
-;  V04 loc1         [V04,T02] (  7, 25   )     int  ->  [rsp+0x6C]  tier0-frame
-;  V05 loc2         [V05,T05] (  3, 12   )     int  ->  r11        
-;  V06 loc3         [V06,T04] (  3, 12   )   byref  ->   r9        
+;  V00 arg0         [V00,T08] (  5,  5.04)   byref  ->  rcx         ld-addr-op single-def
+;  V01 arg1         [V01,T09] (  5,  5.04)   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg2         [V02,T07] (  3,  6   )    long  ->   r8         single-def
+;  V03 loc0         [V03,T00] (  8, 25   )    long  ->  [rsp+0x80]  tier0-frame
+;  V04 loc1         [V04,T01] (  7, 25   )     int  ->  [rsp+0x7C]  tier0-frame
+;  V05 loc2         [V05,T03] (  3, 12   )     int  ->  rsi        
+;  V06 loc3         [V06,T02] (  3, 12   )   byref  ->  r11        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 cse0         [V08,T06] (  3, 12   )     int  ->  rbx         "CSE - aggressive"
-;  V09 cse1         [V09,T07] (  3, 12   )    long  ->   r9         "CSE - aggressive"
+;  V08 tmp1         [V08,T10] (  2,  4.01)   byref  ->  rax         single-def "V00.[000..008)"
+;  V09 tmp2         [V09,T12] (  2,  4.01)     int  ->  rcx         "V00.[008..012)"
+;  V10 tmp3         [V10,T11] (  2,  4.01)   byref  ->  r10         single-def "V01.[000..008)"
+;  V11 tmp4         [V11,T06] (  4,  9.01)     int  ->  rdx         "V01.[008..012)"
+;  V12 cse0         [V12,T04] (  3, 12   )     int  ->  rdi         "CSE - aggressive"
+;  V13 cse1         [V13,T05] (  3, 12   )    long  ->  r11         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
-G_M60135_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
+G_M60135_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       sub      rsp, 56
+       mov      qword ptr [rsp+0xB8], rdi
+       mov      qword ptr [rsp+0xB0], rsi
        mov      qword ptr [rsp+0xA8], rbx
-       mov      rcx, bword ptr [rsp+0xC0]
+       mov      rcx, bword ptr [rsp+0xD0]
        ; byrRegs +[rcx]
-       mov      rdx, bword ptr [rsp+0xC8]
+       mov      rdx, bword ptr [rsp+0xD8]
        ; byrRegs +[rdx]
-       mov      r8, qword ptr [rsp+0xD0]
-						;; size=36 bbWeight=1 PerfScore 7.25
-G_M60135_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
-       mov      eax, dword ptr [rsp+0x6C]
-       cmp      eax, dword ptr [rdx+0x08]
-       jge      SHORT G_M60135_IG09
-						;; size=9 bbWeight=1 PerfScore 5.00
-G_M60135_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
-       cmp      eax, dword ptr [rdx+0x08]
-       jae      SHORT G_M60135_IG10
+       mov      r8, qword ptr [rsp+0xE0]
+						;; size=52 bbWeight=0.01 PerfScore 0.09
+G_M60135_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref, isz
+       mov      rax, bword ptr [rcx]
+       ; byrRegs +[rax]
+       mov      ecx, dword ptr [rcx+0x08]
+       ; byrRegs -[rcx]
        mov      r10, bword ptr [rdx]
        ; byrRegs +[r10]
-       mov      r9d, eax
-       mov      r10d, dword ptr [r10+4*r9]
-       ; byrRegs -[r10]
-       imul     r10, r8
-       add      r10, qword ptr [rsp+0x70]
-       mov      r11d, r10d
-       shr      r10, 32
-       cmp      eax, dword ptr [rcx+0x08]
+       mov      edx, dword ptr [rdx+0x08]
+       ; byrRegs -[rdx]
+       mov      r9d, dword ptr [rsp+0x7C]
+       cmp      r9d, edx
+       jge      SHORT G_M60135_IG09
+						;; size=22 bbWeight=0.01 PerfScore 0.10
+G_M60135_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
+       cmp      r9d, edx
        jae      SHORT G_M60135_IG10
-       mov      rbx, bword ptr [rcx]
-       ; byrRegs +[rbx]
-       lea      r9, bword ptr [rbx+4*r9]
-       ; byrRegs +[r9]
-       mov      ebx, dword ptr [r9]
-       ; byrRegs -[rbx]
-       cmp      ebx, r11d
+       mov      r11d, r9d
+       mov      ebx, dword ptr [r10+4*r11]
+       imul     rbx, r8
+       add      rbx, qword ptr [rsp+0x80]
+       mov      esi, ebx
+       shr      rbx, 32
+       cmp      r9d, ecx
+       jae      SHORT G_M60135_IG10
+       lea      r11, bword ptr [rax+4*r11]
+       ; byrRegs +[r11]
+       mov      edi, dword ptr [r11]
+       cmp      edi, esi
        jae      SHORT G_M60135_IG05
-						;; size=51 bbWeight=4 PerfScore 91.00
-G_M60135_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0206 {rcx rdx r9}, byref
-       inc      r10
+						;; size=46 bbWeight=4 PerfScore 53.00
+G_M60135_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0C01 {rax r10 r11}, byref
+       inc      rbx
 						;; size=3 bbWeight=2 PerfScore 0.50
-G_M60135_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0206 {rcx rdx r9}, byref, isz
-       sub      ebx, r11d
-       mov      dword ptr [r9], ebx
-       inc      eax
-       cmp      eax, dword ptr [rdx+0x08]
+G_M60135_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0C01 {rax r10 r11}, byref, isz
+       sub      edi, esi
+       mov      dword ptr [r11], edi
+       inc      r9d
+       cmp      r9d, edx
        jl       SHORT G_M60135_IG08
-						;; size=13 bbWeight=4 PerfScore 22.00
+						;; size=13 bbWeight=4 PerfScore 11.00
 G_M60135_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rcx rdx r9]
-       mov      eax, r10d
-						;; size=3 bbWeight=1 PerfScore 0.25
+       ; byrRegs -[rax r10-r11]
+       mov      eax, ebx
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M60135_IG07:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 168
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=10 bbWeight=1 PerfScore 2.25
-G_M60135_IG08:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, gcvars, byref, isz
-       ; byrRegs +[rcx rdx]
-       mov      qword ptr [rsp+0x70], r10
+						;; size=12 bbWeight=1 PerfScore 3.25
+G_M60135_IG08:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, gcvars, byref, isz
+       ; byrRegs +[rax r10]
+       mov      qword ptr [rsp+0x80], rbx
        jmp      SHORT G_M60135_IG03
-						;; size=7 bbWeight=2 PerfScore 6.00
+						;; size=10 bbWeight=2 PerfScore 6.00
 G_M60135_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[rcx rdx]
-       mov      r10, qword ptr [rsp+0x70]
+       ; byrRegs -[rax r10]
+       mov      rbx, qword ptr [rsp+0x80]
        jmp      SHORT G_M60135_IG06
-						;; size=7 bbWeight=0.50 PerfScore 1.50
+						;; size=10 bbWeight=0.50 PerfScore 1.50
 G_M60135_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 145, prolog size 36, PerfScore 135.75, instruction count 41, allocated bytes for code 145 (MethodHash=01ed1518) for method System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)
+; Total bytes of code 176, prolog size 52, PerfScore 75.69, instruction count 47, allocated bytes for code 176 (MethodHash=01ed1518) for method System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -102,14 +112,18 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 10
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 21 * 8 = 168 = 0x000A8
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 22 * 8 = 176 = 0x000B0
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 23 * 8 = 184 = 0x000B8
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
       Size: 17 * 8 = 136 = 0x00088
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+41</span> (<span style="color:red">+27.70%</span>) : 25622.dasm - System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -9,84 +9,97 @@
 ; Final local variable assignments
 ;
 ;* V00 TypeCtx      [V00    ] (  0,  0   )    long  ->  zero-ref    single-def
-;  V01 arg0         [V01,T02] (  5, 21   )   byref  ->  rsi         ld-addr-op single-def
-;  V02 arg1         [V02,T00] (  7, 31   )   byref  ->  rbx         ld-addr-op single-def
-;  V03 arg2         [V03,T03] (  4, 10   )     ref  ->  rdi         class-hnd single-def <System.Func`2[double,System.__Canon]>
-;  V04 loc0         [V04,T01] (  7, 25   )     int  ->  [rsp+0x8C]  tier0-frame
+;  V01 arg0         [V01,T04] (  5,  5.04)   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg1         [V02,T05] (  5,  5.04)   byref  ->   r8         ld-addr-op single-def
+;  V03 arg2         [V03,T01] (  4, 10   )     ref  ->  rbx         class-hnd single-def <System.Func`2[double,System.__Canon]>
+;  V04 loc0         [V04,T00] (  7, 25   )     int  ->  [rsp+0xAC]  tier0-frame
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )   byref  ->  zero-ref    "non-inline candidate call"
-;  V07 cse0         [V07,T04] (  3, 12   )    long  ->  rax         "CSE - aggressive"
-;  TEMP_01                                   byref  ->  [rsp+0x20]
+;  V07 tmp2         [V07,T06] (  2,  4.01)   byref  ->  rsi         single-def "V01.[000..008)"
+;  V08 tmp3         [V08,T08] (  2,  4.01)     int  ->  rdi         "V01.[008..012)"
+;  V09 tmp4         [V09,T07] (  2,  4.01)   byref  ->  rbp         single-def "V02.[000..008)"
+;  V10 tmp5         [V10,T03] (  4,  9.01)     int  ->  r14         "V02.[008..012)"
+;  V11 cse0         [V11,T02] (  3, 12   )    long  ->  [rsp+0x28]  spill-single-def "CSE - aggressive"
+;  TEMP_01                                   byref  ->  [rsp+0x30]
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
-G_M59879_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-       mov      qword ptr [rsp+0xC8], rdi
-       mov      qword ptr [rsp+0xC0], rsi
-       mov      qword ptr [rsp+0xB8], rbx
+G_M59879_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       sub      rsp, 104
+       mov      qword ptr [rsp+0xE8], r15
+       mov      qword ptr [rsp+0xE0], r14
+       mov      qword ptr [rsp+0xD8], rdi
+       mov      qword ptr [rsp+0xD0], rsi
+       mov      qword ptr [rsp+0xC8], rbx
        xor      eax, eax
-       mov      qword ptr [rsp+0x20], rax
-       mov      rsi, bword ptr [rsp+0xE8]
-       ; byrRegs +[rsi]
-       mov      rbx, bword ptr [rsp+0xF0]
-       ; byrRegs +[rbx]
-       mov      rdi, gword ptr [rsp+0xF8]
-       ; gcrRegs +[rdi]
-						;; size=59 bbWeight=1 PerfScore 10.50
-G_M59879_IG02:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0048 {rbx rsi}, byref, isz
-       mov      ebp, dword ptr [rsp+0x8C]
-       cmp      ebp, dword ptr [rbx+0x08]
-       jge      SHORT G_M59879_IG04
-						;; size=12 bbWeight=1 PerfScore 5.00
-G_M59879_IG03:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0048 {rbx rsi}, byref, isz
-       cmp      ebp, dword ptr [rbx+0x08]
-       jae      SHORT G_M59879_IG05
-       mov      rcx, bword ptr [rbx]
-       ; byrRegs +[rcx]
-       mov      eax, ebp
-       lea      rcx, bword ptr [rcx+8*rax]
-       mov      bword ptr [rsp+0x20], rcx
-       cmp      ebp, dword ptr [rsi+0x08]
-       jae      SHORT G_M59879_IG05
-       mov      rdx, bword ptr [rsi]
+       mov      qword ptr [rsp+0x30], rax
+       mov      rdx, bword ptr [rsp+0x108]
        ; byrRegs +[rdx]
-       vmovsd   xmm1, qword ptr [rdx+8*rax]
-       mov      rcx, gword ptr [rdi+0x08]
+       mov      r8, bword ptr [rsp+0x110]
+       ; byrRegs +[r8]
+       mov      rbx, gword ptr [rsp+0x118]
+       ; gcrRegs +[rbx]
+						;; size=75 bbWeight=0.01 PerfScore 0.12
+G_M59879_IG02:        ; bbWeight=0.01, gcrefRegs=0008 {rbx}, byrefRegs=0104 {rdx r8}, byref, isz
+       mov      rsi, bword ptr [rdx]
+       ; byrRegs +[rsi]
+       mov      edi, dword ptr [rdx+0x08]
+       mov      rbp, bword ptr [r8]
+       ; byrRegs +[rbp]
+       mov      r14d, dword ptr [r8+0x08]
+       mov      r15d, dword ptr [rsp+0xAC]
+       cmp      r15d, r14d
+       jge      SHORT G_M59879_IG04
+						;; size=26 bbWeight=0.01 PerfScore 0.10
+G_M59879_IG03:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0060 {rbp rsi}, byref, isz
+       ; byrRegs -[rdx r8]
+       cmp      r15d, r14d
+       jae      SHORT G_M59879_IG05
+       mov      ecx, r15d
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, bword ptr [rbp+8*rcx]
+       ; byrRegs +[rcx]
+       mov      bword ptr [rsp+0x30], rcx
+       cmp      r15d, edi
+       jae      SHORT G_M59879_IG05
+       mov      rax, qword ptr [rsp+0x28]
+       vmovsd   xmm1, qword ptr [rsi+8*rax]
+       mov      rcx, gword ptr [rbx+0x08]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
-       call     [rdi+0x18]<unknown method>
+       call     [rbx+0x18]<unknown method>
        ; gcrRegs -[rcx] +[rax]
-       ; byrRegs -[rdx]
        ; gcr arg pop 0
-       mov      rcx, bword ptr [rsp+0x20]
+       mov      rcx, bword ptr [rsp+0x30]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
-       inc      ebp
-       cmp      ebp, dword ptr [rbx+0x08]
+       inc      r15d
+       cmp      r15d, r14d
        jl       SHORT G_M59879_IG03
-						;; size=59 bbWeight=4 PerfScore 117.00
+						;; size=66 bbWeight=4 PerfScore 82.00
 G_M59879_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rdi]
-       ; byrRegs -[rbx rsi]
-       add      rsp, 184
+       ; gcrRegs -[rbx]
+       ; byrRegs -[rbp rsi]
+       add      rsp, 200
        pop      rbx
        pop      rsi
        pop      rdi
+       pop      r14
+       pop      r15
        pop      rbp
        ret      
-						;; size=12 bbWeight=1 PerfScore 3.25
+						;; size=16 bbWeight=1 PerfScore 4.25
 G_M59879_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 148, prolog size 35, PerfScore 135.75, instruction count 38, allocated bytes for code 148 (MethodHash=193a1618) for method System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (Tier1-OSR)
+; Total bytes of code 189, prolog size 51, PerfScore 86.48, instruction count 46, allocated bytes for code 189 (MethodHash=193a1618) for method System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -94,18 +107,22 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x1C
-  CountOfUnwindCodes: 10
+  SizeOfProlog      : 0x2C
+  CountOfUnwindCodes: 14
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 23 * 8 = 184 = 0x000B8
-    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
-      Scaled Small Offset: 24 * 8 = 192 = 0x000C0
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+    CodeOffset: 0x2C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 25 * 8 = 200 = 0x000C8
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x24 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 26 * 8 = 208 = 0x000D0
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 27 * 8 = 216 = 0x000D8
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: r14 (14)
+      Scaled Small Offset: 28 * 8 = 224 = 0x000E0
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: r15 (15)
+      Scaled Small Offset: 29 * 8 = 232 = 0x000E8
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
       Size: 17 * 8 = 136 = 0x00088
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-46</span> (<span style="color:green">-92.00%</span>) : 247200.dasm - C:Test64Bit(int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,33 +8,24 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  3,  3   )     int  ->  rcx         single-def
-;  V01 loc0         [V01,T01] (  2,  2   )  struct ( 8) [rsp+0x10]  do-not-enreg[SF] must-init ld-addr-op <S>
-;  V02 loc1         [V02,T02] (  2,  2   )  struct (16) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op <T>
+;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op <S>
+;* V02 loc1         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op <T>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V04 tmp1         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[006..007)"
+;* V05 tmp2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "V02.[010..011)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M53363_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqa  xmmword ptr [rsp], xmm4
-       xor      eax, eax
-       mov      qword ptr [rsp+0x10], rax
-						;; size=20 bbWeight=1 PerfScore 3.83
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M53363_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      byte  ptr [rsp+0x16], cl
-       mov      eax, dword ptr [rsp+0x10]
-       mov      dword ptr [rsp+0x04], eax
-       mov      eax, dword ptr [rsp+0x13]
-       mov      dword ptr [rsp+0x07], eax
-       movzx    rax, byte  ptr [rsp+0x0A]
-						;; size=25 bbWeight=1 PerfScore 6.00
+       movzx    rax, cl
+						;; size=3 bbWeight=1 PerfScore 0.25
 G_M53363_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 50, prolog size 20, PerfScore 11.08, instruction count 13, allocated bytes for code 50 (MethodHash=44b82f8c) for method C:Test64Bit(int):int (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 4 (MethodHash=44b82f8c) for method C:Test64Bit(int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +33,8 @@ Unwind Info:
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
<summary><span style="color:green">-40</span> (<span style="color:green">-71.43%</span>) : 247796.dasm - Program:TestEntryPoint():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,34 +7,24 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 loc0         [V00,T01] (  3,  3   )  struct (24) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <S0>
+;* V00 loc0         [V00    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <S0>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     int  ->  rax         "dup spill"
+;* V02 tmp1         [V02    ] (  0,  0   )     int  ->  zero-ref    "dup spill"
+;* V03 tmp2         [V03    ] (  0,  0   )     int  ->  zero-ref    "V00.[000..004)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M13170_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M13170_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vxorps   xmm0, xmm0, xmm0
-       vmovdqu  xmmword ptr [rsp], xmm0
-       vmovdqu  xmmword ptr [rsp+0x08], xmm0
-       mov      dword ptr [rsp], 0x10001
-       movzx    rax, word  ptr [rsp]
-       mov      dword ptr [(reloc)], eax
-       mov      ecx, 100
-       xor      edx, edx
-       cmp      eax, 1
-       mov      eax, edx
-       cmove    eax, ecx
-						;; size=47 bbWeight=1 PerfScore 6.58
+       mov      dword ptr [(reloc)], 1      ; data for <unknown class>:<unknown field>
+       mov      eax, 100
+						;; size=15 bbWeight=1 PerfScore 1.25
 G_M13170_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 56, prolog size 4, PerfScore 8.08, instruction count 14, allocated bytes for code 56 (MethodHash=eaa4cc8d) for method Program:TestEntryPoint():int (FullOpts)
+; Total bytes of code 16, prolog size 0, PerfScore 2.25, instruction count 3, allocated bytes for code 16 (MethodHash=eaa4cc8d) for method Program:TestEntryPoint():int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +32,8 @@ Unwind Info:
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
<summary><span style="color:green">-27</span> (<span style="color:green">-67.50%</span>) : 184834.dasm - TailcallVerify.Condition4:Callee2():TailcallVerify.ValueType3Bytes (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,34 +7,28 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T00] (  4,  4   )   byref  ->  rcx         single-def
-;  V01 loc0         [V01,T01] (  3,  3   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <TailcallVerify.ValueType3Bytes>
+;  V00 RetBuf       [V00,T00] (  5,  5   )   byref  ->  rcx         single-def
+;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op <TailcallVerify.ValueType3Bytes>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[000..001)"
+;* V04 tmp2         [V04    ] (  0,  0   )   short  ->  zero-ref    "V01.[001..003)"
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M38869_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M38869_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       xor      eax, eax
-       mov      word  ptr [rsp], ax
-       mov      byte  ptr [rsp+0x02], al
-       mov      word  ptr [rsp+0x01], 0x7FFF
-       mov      ax, word  ptr [rsp]
-       mov      word  ptr [rcx], ax
-       mov      al, byte  ptr [rsp+0x02]
-       mov      byte  ptr [rcx+0x02], al
+       mov      byte  ptr [rcx], 0
+       mov      word  ptr [rcx+0x01], 0x7FFF
        mov      rax, rcx
        ; byrRegs +[rax]
-						;; size=34 bbWeight=1 PerfScore 7.50
+						;; size=12 bbWeight=1 PerfScore 2.25
 G_M38869_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 40, prolog size 1, PerfScore 9.75, instruction count 12, allocated bytes for code 40 (MethodHash=23cc682a) for method TailcallVerify.Condition4:Callee2():TailcallVerify.ValueType3Bytes (FullOpts)
+; Total bytes of code 13, prolog size 0, PerfScore 3.25, instruction count 4, allocated bytes for code 13 (MethodHash=23cc682a) for method TailcallVerify.Condition4:Callee2():TailcallVerify.ValueType3Bytes (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +36,8 @@ Unwind Info:
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
<summary><span style="color:red">+15</span> (<span style="color:red">+27.78%</span>) : 22306.dasm - TestAssignFieldsBetweenPromotedNotPromotedStructs:TestStructCasts() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,25 +8,31 @@
 ; 0 inlinees with PGO data; 5 single block inlinees; 3 inlinees without PGO data
 ; Final local variable assignments
 ;
-;* V00 loc0         [V00    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <TestAssignFieldsBetweenPromotedNotPromotedStructs+PromotedStruct>
+;  V00 loc0         [V00    ] (  3,  3   )  struct (16) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op <TestAssignFieldsBetweenPromotedNotPromotedStructs+PromotedStruct>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )  struct (16) [rsp+0x28]  do-not-enreg[SF] "dup spill" <TestAssignFieldsBetweenPromotedNotPromotedStructs+NotPromotedStruct>
+;* V02 tmp1         [V02    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] "dup spill" <TestAssignFieldsBetweenPromotedNotPromotedStructs+NotPromotedStruct>
 ;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V04 tmp3         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp4         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;* V06 tmp5         [V06,T02] (  0,  0   )    long  ->  zero-ref    single-def "field V00.promotedField (fldOffset=0x0)" P-INDEP
-;* V07 tmp6         [V07,T03] (  0,  0   )    long  ->  zero-ref    single-def "field V00.anotherField (fldOffset=0x8)" P-INDEP
-;  V08 cse0         [V08,T01] (  3,  3   )     ref  ->  rdx         "CSE - aggressive"
+;  V06 tmp5         [V06,T01] (  2,  2   )    long  ->  [rsp+0x28]  do-not-enreg[] single-def "field V00.promotedField (fldOffset=0x0)" P-DEP
+;  V07 tmp6         [V07,T02] (  2,  2   )    long  ->  [rsp+0x30]  do-not-enreg[] single-def "field V00.anotherField (fldOffset=0x8)" P-DEP
+;  V08 tmp7         [V08,T03] (  2,  2   )   ubyte  ->  rcx         single-def "V02.[000..001)"
+;* V09 tmp8         [V09    ] (  0,  0   )    long  ->  zero-ref    single-def "V02.[008..016)"
+;  V10 cse0         [V10,T00] (  3,  3   )     ref  ->  rdx         "CSE - aggressive"
 ;
 ; Lcl frame size = 56
 
 G_M14859_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
+       mov      qword ptr [rsp+0x30], rax
+						;; size=16 bbWeight=1 PerfScore 2.50
 G_M14859_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      qword ptr [rsp+0x28], 4
        mov      qword ptr [rsp+0x30], 5
-       cmp      byte  ptr [rsp+0x28], 4
+       movzx    rcx, byte  ptr [rsp+0x28]
+       cmp      ecx, 4
        je       SHORT G_M14859_IG03
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
@@ -35,7 +41,7 @@ G_M14859_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-						;; size=44 bbWeight=1 PerfScore 8.50
+						;; size=47 bbWeight=1 PerfScore 7.75
 G_M14859_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        nop      
 						;; size=1 bbWeight=1 PerfScore 0.25
@@ -44,7 +50,7 @@ G_M14859_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 54, prolog size 4, PerfScore 10.25, instruction count 11, allocated bytes for code 54 (MethodHash=3413c5f4) for method TestAssignFieldsBetweenPromotedNotPromotedStructs:TestStructCasts() (FullOpts)
+; Total bytes of code 69, prolog size 16, PerfScore 11.75, instruction count 15, allocated bytes for code 69 (MethodHash=3413c5f4) for method TestAssignFieldsBetweenPromotedNotPromotedStructs:TestStructCasts() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+29.58%</span>) : 22346.dasm - SevenByteStruct:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,37 +7,41 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 loc0         [V00,T00] (  9,  9   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <S0>
+;* V00 loc0         [V00    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op <S0>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V02 tmp1         [V02    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[000..001)"
+;* V03 tmp2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[001..002)"
+;* V04 tmp3         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[002..003)"
+;* V05 tmp4         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[003..004)"
+;* V06 tmp5         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[004..005)"
+;* V07 tmp6         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[005..006)"
+;* V08 tmp7         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "V00.[006..007)"
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M35920_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M35920_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       mov      dword ptr [rsp], eax
-       mov      dword ptr [rsp+0x03], eax
-       mov      byte  ptr [rsp], 1
-       mov      byte  ptr [rsp+0x01], 2
-       mov      byte  ptr [rsp+0x02], 3
-       mov      byte  ptr [rsp+0x03], 4
-       mov      byte  ptr [rsp+0x04], 5
-       mov      byte  ptr [rsp+0x05], 6
-       mov      byte  ptr [rsp+0x06], 7
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      ecx, dword ptr [rsp]
-       mov      dword ptr [rax], ecx
-       mov      ecx, dword ptr [rsp+0x03]
-       mov      dword ptr [rax+0x03], ecx
-						;; size=65 bbWeight=1 PerfScore 13.50
+       mov      rax, 0xD1FFAB1E      ; static handle
+       mov      byte  ptr [rax], 1
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 2
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 3
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 4
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 5
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 6
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 7
+						;; size=91 bbWeight=1 PerfScore 8.75
 G_M35920_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 71, prolog size 1, PerfScore 15.75, instruction count 18, allocated bytes for code 71 (MethodHash=940573af) for method SevenByteStruct:.cctor() (FullOpts)
+; Total bytes of code 92, prolog size 0, PerfScore 9.75, instruction count 15, allocated bytes for code 92 (MethodHash=940573af) for method SevenByteStruct:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -45,9 +49,8 @@ Unwind Info:
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
<summary><span style="color:red">+37</span> (<span style="color:red">+40.66%</span>) : 22032.dasm - PhysicalPromotion:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,41 +8,50 @@
 ; Final local variable assignments
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <PhysicalPromotion+S>
-;  V01 loc1         [V01,T00] ( 10, 10   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <PhysicalPromotion+S2>
+;* V01 loc1         [V01    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op <PhysicalPromotion+S2>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T02] (  0,  0   )     int  ->  zero-ref    single-def "field V00.A (fldOffset=0x0)" P-INDEP
-;* V04 tmp2         [V04,T03] (  0,  0   )     int  ->  zero-ref    single-def "field V00.B (fldOffset=0x4)" P-INDEP
-;  V05 cse0         [V05,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
+;* V03 tmp1         [V03,T01] (  0,  0   )     int  ->  zero-ref    single-def "field V00.A (fldOffset=0x0)" P-INDEP
+;* V04 tmp2         [V04,T02] (  0,  0   )     int  ->  zero-ref    single-def "field V00.B (fldOffset=0x4)" P-INDEP
+;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[000..001)"
+;* V06 tmp4         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[001..002)"
+;* V07 tmp5         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[002..003)"
+;* V08 tmp6         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[003..004)"
+;* V09 tmp7         [V09    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[004..005)"
+;* V10 tmp8         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[005..006)"
+;* V11 tmp9         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[006..007)"
+;* V12 tmp10        [V12    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[007..008)"
+;  V13 cse0         [V13,T00] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M44064_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M44064_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      dword ptr [rax], 0xD1FFAB1E
        mov      dword ptr [rax+0x04], 0xD1FFAB1E
-       xor      eax, eax
-       mov      qword ptr [rsp], rax
-       mov      byte  ptr [rsp], 18
-       mov      byte  ptr [rsp+0x01], 52
-       mov      byte  ptr [rsp+0x02], 86
-       mov      byte  ptr [rsp+0x03], 120
-       mov      byte  ptr [rsp+0x04], 154
-       mov      byte  ptr [rsp+0x05], 188
-       mov      byte  ptr [rsp+0x06], 222
-       mov      byte  ptr [rsp+0x07], 240
-       mov      rax, qword ptr [rsp]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      qword ptr [rcx], rax
-						;; size=85 bbWeight=1 PerfScore 13.75
+       mov      rax, 0xD1FFAB1E      ; static handle
+       mov      byte  ptr [rax], 18
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 52
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 86
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 120
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 154
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 188
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 222
+       mov      rax, 0xD1FFAB1E
+       mov      byte  ptr [rax], 240
+						;; size=127 bbWeight=1 PerfScore 12.25
 G_M44064_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 8
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 91, prolog size 1, PerfScore 16.00, instruction count 19, allocated bytes for code 91 (MethodHash=4f8d53df) for method PhysicalPromotion:.cctor() (FullOpts)
+; Total bytes of code 128, prolog size 0, PerfScore 13.25, instruction count 20, allocated bytes for code 128 (MethodHash=4f8d53df) for method PhysicalPromotion:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -50,9 +59,8 @@ Unwind Info:
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


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-90.38%</span>) : 57548.dasm - Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,34 +11,23 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )  struct (56) [rsp+0x00]  do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
+;* V02 tmp1         [V02    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
+;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    "V02.[024..032)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M6972_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M6972_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M6972_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movups   xmm0, xmmword ptr [rcx+0x58]
-       movups   xmmword ptr [rsp], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x68]
-       movups   xmmword ptr [rsp+0x10], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x78]
-       movups   xmmword ptr [rsp+0x20], xmm0
-       mov      rax, qword ptr [rcx+0x88]
-       mov      qword ptr [rsp+0x30], rax
-						;; size=38 bbWeight=1 PerfScore 18.00
-G_M6972_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp+0x18]
+       mov      rax, gword ptr [rcx+0x70]
        ; gcrRegs +[rax]
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M6972_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M6972_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 52, prolog size 4, PerfScore 20.50, instruction count 12, allocated bytes for code 52 (MethodHash=b5f3e4c3) for method Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=b5f3e4c3) for method Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -46,9 +35,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-90.38%</span>) : 120506.dasm - Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,34 +11,23 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )  struct (56) [rsp+0x00]  do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
+;* V02 tmp1         [V02    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
+;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    "V02.[024..032)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M6972_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M6972_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M6972_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movups   xmm0, xmmword ptr [rcx+0x58]
-       movups   xmmword ptr [rsp], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x68]
-       movups   xmmword ptr [rsp+0x10], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x78]
-       movups   xmmword ptr [rsp+0x20], xmm0
-       mov      rax, qword ptr [rcx+0x88]
-       mov      qword ptr [rsp+0x30], rax
-						;; size=38 bbWeight=1 PerfScore 18.00
-G_M6972_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp+0x18]
+       mov      rax, gword ptr [rcx+0x70]
        ; gcrRegs +[rax]
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M6972_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M6972_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 52, prolog size 4, PerfScore 20.50, instruction count 12, allocated bytes for code 52 (MethodHash=b5f3e4c3) for method Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=b5f3e4c3) for method Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -46,9 +35,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:green">-45</span> (<span style="color:green">-90.00%</span>) : 268352.dasm - System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,32 +10,23 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.InstanceData>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (64) [rsp+0x08]  do-not-enreg[SF] ld-addr-op <System.Diagnostics.CounterSample>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op <System.Diagnostics.CounterSample>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )    long  ->  zero-ref    "V01.[000..008)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 0
 
 G_M37667_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M37667_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movups   xmm0, xmmword ptr [rcx+0x10]
-       movups   xmmword ptr [rsp+0x08], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x20]
-       movups   xmmword ptr [rsp+0x18], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x30]
-       movups   xmmword ptr [rsp+0x28], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x40]
-       movups   xmmword ptr [rsp+0x38], xmm0
-       mov      rax, qword ptr [rsp+0x08]
-						;; size=41 bbWeight=1 PerfScore 21.00
+       mov      rax, qword ptr [rcx+0x10]
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M37667_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 72
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 50, prolog size 4, PerfScore 22.50, instruction count 12, allocated bytes for code 50 (MethodHash=0d196cdc) for method System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=0d196cdc) for method System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -43,9 +34,8 @@ Unwind Info:
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
<summary><span style="color:red">+48</span> (<span style="color:red">+21.15%</span>) : 132981.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender:ReadNodeOrToken(int,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,93 +9,117 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  3,  3   )   byref  ->  rsi         this single-def
-;  V01 RetBuf       [V01,T01] (  4,  4   )   byref  ->  rbx         single-def
+;  V00 this         [V00,T00] (  8,  8   )   byref  ->  [rsp+0x110]  this single-def
+;  V01 RetBuf       [V01,T02] (  4,  4   )   byref  ->  rbx         single-def
 ;  V02 arg1         [V02,T03] (  3,  3   )     int  ->  rbp         single-def
 ;  V03 arg2         [V03,T04] (  3,  3   )   ubyte  ->  r14         single-def
-;  V04 loc0         [V04    ] (  9,  9   )  struct (80) [rsp+0x70]  do-not-enreg[XSF] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender+Reader>
+;  V04 loc0         [V04    ] (  9,  9   )  struct (80) [rsp+0x78]  do-not-enreg[XSF] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender+Reader>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T00] (  9, 18   )  struct (80) [rsp+0x20]  do-not-enreg[SF] "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender>
+;  V06 tmp1         [V06,T01] (  4,  8   )  struct (80) [rsp+0x28]  do-not-enreg[SF] "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender>
+;  V07 tmp2         [V07,T05] (  2,  2   )     ref  ->  r15         single-def "V06.[000..008)"
+;  V08 tmp3         [V08,T06] (  2,  2   )     ref  ->  r13         single-def "V06.[008..016)"
+;  V09 tmp4         [V09,T07] (  2,  2   )     int  ->  r12         single-def "V06.[016..020)"
+;  V10 tmp5         [V10,T08] (  2,  2   )     int  ->  [rsp+0x24]  spill-single-def "V06.[020..024)"
+;  V11 tmp6         [V11,T09] (  2,  2   )     int  ->  [rsp+0x20]  spill-single-def "V06.[024..028)"
 ;
-; Lcl frame size = 192
+; Lcl frame size = 200
 
 G_M56261_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 192
+       sub      rsp, 200
+       xor      eax, eax
+       mov      qword ptr [rsp+0x78], rax
        xorps    xmm4, xmm4
-       movaps   xmmword ptr [rsp+0x70], xmm4
        movaps   xmmword ptr [rsp+0x80], xmm4
        movaps   xmmword ptr [rsp+0x90], xmm4
        movaps   xmmword ptr [rsp+0xA0], xmm4
        movaps   xmmword ptr [rsp+0xB0], xmm4
-       mov      rsi, rcx
-       ; byrRegs +[rsi]
+       mov      qword ptr [rsp+0xC0], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
        mov      ebp, r8d
        mov      r14d, r9d
-						;; size=65 bbWeight=1 PerfScore 16.58
-G_M56261_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref
-       lea      rdi, bword ptr [rsp+0x20]
+						;; size=78 bbWeight=1 PerfScore 19.58
+G_M56261_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
+       ; byrRegs +[rcx]
+       mov      r15, gword ptr [rcx]
+       ; gcrRegs +[r15]
+       mov      r13, gword ptr [rcx+0x08]
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [rcx+0x10]
+       mov      eax, dword ptr [rcx+0x14]
+       mov      dword ptr [rsp+0x24], eax
+       mov      bword ptr [rsp+0x110], rcx
+       ; GC ptr vars +{V00}
+       mov      edx, dword ptr [rcx+0x18]
+       mov      dword ptr [rsp+0x20], edx
+       lea      rdi, bword ptr [rsp+0x28]
        ; byrRegs +[rdi]
+       mov      rsi, bword ptr [rsp+0x110]
+       ; byrRegs +[rsi]
        mov      ecx, 10
+       ; byrRegs -[rcx]
        rep movsq 
-       mov      r9, gword ptr [rsp+0x20]
-       ; gcrRegs +[r9]
-       mov      gword ptr [rsp+0x70], r9
-						;; size=23 bbWeight=1 PerfScore 27.75
+       mov      gword ptr [rsp+0x78], r15
+						;; size=59 bbWeight=1 PerfScore 40.75
 G_M56261_IG03:        ; bbWeight=1, nogc, extend
-       movups   xmm0, xmmword ptr [rsp+0x40]
-       movups   xmmword ptr [rsp+0x90], xmm0
-       movups   xmm0, xmmword ptr [rsp+0x50]
-       movups   xmmword ptr [rsp+0xA0], xmm0
+       movups   xmm0, xmmword ptr [rsp+0x48]
+       movups   xmmword ptr [rsp+0x98], xmm0
+       movups   xmm0, xmmword ptr [rsp+0x58]
+       movups   xmmword ptr [rsp+0xA8], xmm0
 						;; size=26 bbWeight=1 PerfScore 8.00
 G_M56261_IG04:        ; bbWeight=1, extend
-       mov      r9, gword ptr [rsp+0x28]
-       mov      gword ptr [rsp+0x78], r9
-       mov      r9d, dword ptr [rsp+0x30]
-       ; gcrRegs -[r9]
-       mov      dword ptr [rsp+0x80], r9d
-       mov      r9d, dword ptr [rsp+0x34]
-       mov      dword ptr [rsp+0x84], r9d
-						;; size=36 bbWeight=1 PerfScore 6.00
+       mov      gword ptr [rsp+0x80], r13
+       mov      dword ptr [rsp+0x88], r12d
+       mov      r15d, dword ptr [rsp+0x24]
+       ; gcrRegs -[r15]
+       mov      dword ptr [rsp+0x8C], r15d
+						;; size=29 bbWeight=1 PerfScore 4.00
 G_M56261_IG05:        ; bbWeight=1, nogc, extend
-       mov      r9, qword ptr [rsp+0x60]
-       mov      qword ptr [rsp+0xB0], r9
-						;; size=13 bbWeight=1 PerfScore 2.00
-G_M56261_IG06:        ; bbWeight=1, nogc, extend
        mov      r9, qword ptr [rsp+0x68]
        mov      qword ptr [rsp+0xB8], r9
 						;; size=13 bbWeight=1 PerfScore 2.00
+G_M56261_IG06:        ; bbWeight=1, nogc, extend
+       mov      r9, qword ptr [rsp+0x70]
+       mov      qword ptr [rsp+0xC0], r9
+						;; size=13 bbWeight=1 PerfScore 2.00
 G_M56261_IG07:        ; bbWeight=1, extend
-       mov      r9d, dword ptr [rsp+0x38]
-       mov      dword ptr [rsp+0x88], r9d
+       mov      r15d, dword ptr [rsp+0x20]
+       mov      dword ptr [rsp+0x90], r15d
        movzx    r9, r14b
-       lea      rcx, [rsp+0x70]
+       lea      rcx, [rsp+0x78]
        mov      rdx, rbx
        ; byrRegs +[rdx]
        mov      r8d, ebp
+       ; GC ptr vars -{V00}
        call     [<unknown method>]
+       ; gcrRegs -[r13]
        ; byrRegs -[rdx rsi rdi]
        ; gcr arg pop 0
        mov      rax, rbx
        ; byrRegs +[rax]
 						;; size=37 bbWeight=1 PerfScore 6.50
 G_M56261_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 192
+       add      rsp, 200
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r12
+       pop      r13
        pop      r14
+       pop      r15
        ret      
-						;; size=14 bbWeight=1 PerfScore 3.75
+						;; size=20 bbWeight=1 PerfScore 5.25
 
-; Total bytes of code 227, prolog size 53, PerfScore 72.58, instruction count 50, allocated bytes for code 227 (MethodHash=ab30243a) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender:ReadNodeOrToken(int,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode:this (FullOpts)
+; Total bytes of code 275, prolog size 69, PerfScore 88.08, instruction count 63, allocated bytes for code 275 (MethodHash=ab30243a) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender:ReadNodeOrToken(int,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -103,15 +127,18 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0D
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x13
+  CountOfUnwindCodes: 10
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0D UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 24 * 8 = 192 = 0x000C0
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x13 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 25 * 8 = 200 = 0x000C8
+    CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r12 (12)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+23.26%</span>) : 223624.dasm - Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,52 +11,59 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V01 RetBuf       [V01,T01] (  4,  4   )   byref  ->  rsi         single-def
-;  V02 arg1         [V02,T02] (  4,  4   )  struct ( 8) [rsp+0x50]  do-not-enreg[SF] ld-addr-op single-def <Microsoft.CodeAnalysis.Text.TextSpan>
-;  V03 arg2         [V03,T03] (  3,  3   )   byref  ->  rdi         single-def
+;  V02 arg1         [V02,T02] (  4,  4   )  struct ( 8) [rsp+0x60]  do-not-enreg[SF] ld-addr-op single-def <Microsoft.CodeAnalysis.Text.TextSpan>
+;  V03 arg2         [V03,T04] (  3,  3   )   byref  ->  rdi         single-def
 ;* V04 loc0         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Threading.CancellationToken>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T04] (  2,  4   )     int  ->  rdx         "impAppendStmt"
+;* V06 tmp1         [V06    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V07 tmp2         [V07    ] (  0,  0   )  struct ( 8) zero-ref    "impAppendStmt" <Microsoft.CodeAnalysis.Text.TextSpan>
-;* V08 tmp3         [V08,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V04._source (fldOffset=0x0)" P-INDEP
-;* V09 tmp4         [V09    ] (  0,  0   )     int  ->  zero-ref    single-def "field V07.<Start>k__BackingField (fldOffset=0x0)" P-INDEP
-;* V10 tmp5         [V10    ] (  0,  0   )     int  ->  zero-ref    single-def "field V07.<Length>k__BackingField (fldOffset=0x4)" P-INDEP
+;* V08 tmp3         [V08,T08] (  0,  0   )     ref  ->  zero-ref    single-def "field V04._source (fldOffset=0x0)" P-INDEP
+;  V09 tmp4         [V09,T06] (  2,  2   )     int  ->  rbp         single-def "field V07.<Start>k__BackingField (fldOffset=0x0)" P-INDEP
+;  V10 tmp5         [V10,T07] (  2,  2   )     int  ->   r8         single-def "field V07.<Length>k__BackingField (fldOffset=0x4)" P-INDEP
+;  V11 tmp6         [V11,T05] (  3,  3   )     int  ->  rbp         single-def "V02.[000..004)"
+;  V12 tmp7         [V12,T03] (  3,  6   )  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <Microsoft.CodeAnalysis.Text.TextSpan>
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M38766_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 32
-       mov      qword ptr [rsp+0x50], r8
+       sub      rsp, 40
+       mov      qword ptr [rsp+0x60], r8
        mov      rbx, rcx
        ; gcrRegs +[rbx]
        mov      rsi, rdx
        ; byrRegs +[rsi]
        mov      rdi, r9
        ; byrRegs +[rdi]
-						;; size=21 bbWeight=1 PerfScore 5.00
+						;; size=22 bbWeight=1 PerfScore 6.00
 G_M38766_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=00C0 {rsi rdi}, byref
-       mov      edx, dword ptr [rsp+0x50]
+       mov      ebp, dword ptr [rsp+0x60]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        xor      r8, r8
        ; gcrRegs +[r8]
+       mov      edx, ebp
        lea      r11, [(reloc)]      ; function address
        cmp      dword ptr [rcx], ecx
        call     [r11]<unknown method>
        ; gcrRegs -[rcx r8]
        ; gcr arg pop 0
        cmp      eax, 1
-       sete     cl
-       mov      byte  ptr [rdi], cl
-       mov      rcx, rbx
-       ; gcrRegs +[rcx]
+       sete     r8b
+       mov      byte  ptr [rdi], r8b
+       mov      r8d, dword ptr [rsp+0x64]
+       mov      dword ptr [rsp+0x20], ebp
+       mov      dword ptr [rsp+0x24], r8d
+       mov      r8, qword ptr [rsp+0x20]
        xor      r9, r9
        ; gcrRegs +[r9]
        mov      rdx, rsi
        ; byrRegs +[rdx]
-       mov      r8, qword ptr [rsp+0x50]
+       mov      rcx, rbx
+       ; gcrRegs +[rcx]
        lea      r11, [(reloc)]      ; function address
        call     [r11]<unknown method>
        ; gcrRegs -[rcx rbx r9]
@@ -64,16 +71,17 @@ G_M38766_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=00C0 {rsi rd
        ; gcr arg pop 0
        mov      rax, rsi
        ; byrRegs +[rax]
-						;; size=57 bbWeight=1 PerfScore 15.75
+						;; size=75 bbWeight=1 PerfScore 19.00
 G_M38766_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=9 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 86, prolog size 7, PerfScore 23.50, instruction count 29, allocated bytes for code 86 (MethodHash=c70a6891) for method Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)
+; Total bytes of code 106, prolog size 8, PerfScore 28.25, instruction count 35, allocated bytes for code 106 (MethodHash=c70a6891) for method Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -81,12 +89,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+23.26%</span>) : 193048.dasm - Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,52 +11,59 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.SyntaxTree>
 ;  V01 RetBuf       [V01,T01] (  4,  4   )   byref  ->  rsi         single-def
-;  V02 arg1         [V02,T02] (  4,  4   )  struct ( 8) [rsp+0x50]  do-not-enreg[SF] ld-addr-op single-def <Microsoft.CodeAnalysis.Text.TextSpan>
-;  V03 arg2         [V03,T03] (  3,  3   )   byref  ->  rdi         single-def
+;  V02 arg1         [V02,T02] (  4,  4   )  struct ( 8) [rsp+0x60]  do-not-enreg[SF] ld-addr-op single-def <Microsoft.CodeAnalysis.Text.TextSpan>
+;  V03 arg2         [V03,T04] (  3,  3   )   byref  ->  rdi         single-def
 ;* V04 loc0         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Threading.CancellationToken>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T04] (  2,  4   )     int  ->  rdx         "impAppendStmt"
+;* V06 tmp1         [V06    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V07 tmp2         [V07    ] (  0,  0   )  struct ( 8) zero-ref    "impAppendStmt" <Microsoft.CodeAnalysis.Text.TextSpan>
-;* V08 tmp3         [V08,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V04._source (fldOffset=0x0)" P-INDEP
-;* V09 tmp4         [V09    ] (  0,  0   )     int  ->  zero-ref    single-def "field V07.<Start>k__BackingField (fldOffset=0x0)" P-INDEP
-;* V10 tmp5         [V10    ] (  0,  0   )     int  ->  zero-ref    single-def "field V07.<Length>k__BackingField (fldOffset=0x4)" P-INDEP
+;* V08 tmp3         [V08,T08] (  0,  0   )     ref  ->  zero-ref    single-def "field V04._source (fldOffset=0x0)" P-INDEP
+;  V09 tmp4         [V09,T06] (  2,  2   )     int  ->  rbp         single-def "field V07.<Start>k__BackingField (fldOffset=0x0)" P-INDEP
+;  V10 tmp5         [V10,T07] (  2,  2   )     int  ->   r8         single-def "field V07.<Length>k__BackingField (fldOffset=0x4)" P-INDEP
+;  V11 tmp6         [V11,T05] (  3,  3   )     int  ->  rbp         single-def "V02.[000..004)"
+;  V12 tmp7         [V12,T03] (  3,  6   )  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <Microsoft.CodeAnalysis.Text.TextSpan>
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M38766_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 32
-       mov      qword ptr [rsp+0x50], r8
+       sub      rsp, 40
+       mov      qword ptr [rsp+0x60], r8
        mov      rbx, rcx
        ; gcrRegs +[rbx]
        mov      rsi, rdx
        ; byrRegs +[rsi]
        mov      rdi, r9
        ; byrRegs +[rdi]
-						;; size=21 bbWeight=1 PerfScore 5.00
+						;; size=22 bbWeight=1 PerfScore 6.00
 G_M38766_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=00C0 {rsi rdi}, byref
-       mov      edx, dword ptr [rsp+0x50]
+       mov      ebp, dword ptr [rsp+0x60]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        xor      r8, r8
        ; gcrRegs +[r8]
+       mov      edx, ebp
        lea      r11, [(reloc)]      ; function address
        cmp      dword ptr [rcx], ecx
        call     [r11]<unknown method>
        ; gcrRegs -[rcx r8]
        ; gcr arg pop 0
        cmp      eax, 1
-       sete     cl
-       mov      byte  ptr [rdi], cl
-       mov      rcx, rbx
-       ; gcrRegs +[rcx]
+       sete     r8b
+       mov      byte  ptr [rdi], r8b
+       mov      r8d, dword ptr [rsp+0x64]
+       mov      dword ptr [rsp+0x20], ebp
+       mov      dword ptr [rsp+0x24], r8d
+       mov      r8, qword ptr [rsp+0x20]
        xor      r9, r9
        ; gcrRegs +[r9]
        mov      rdx, rsi
        ; byrRegs +[rdx]
-       mov      r8, qword ptr [rsp+0x50]
+       mov      rcx, rbx
+       ; gcrRegs +[rcx]
        lea      r11, [(reloc)]      ; function address
        call     [r11]<unknown method>
        ; gcrRegs -[rcx rbx r9]
@@ -64,16 +71,17 @@ G_M38766_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=00C0 {rsi rd
        ; gcr arg pop 0
        mov      rax, rsi
        ; byrRegs +[rax]
-						;; size=57 bbWeight=1 PerfScore 15.75
+						;; size=75 bbWeight=1 PerfScore 19.00
 G_M38766_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=9 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 86, prolog size 7, PerfScore 23.50, instruction count 29, allocated bytes for code 86 (MethodHash=c70a6891) for method Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)
+; Total bytes of code 106, prolog size 8, PerfScore 28.25, instruction count 35, allocated bytes for code 106 (MethodHash=c70a6891) for method Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -81,12 +89,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-34</span> (<span style="color:green">-87.18%</span>) : 273393.dasm - System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,29 +9,23 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.InstanceData>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (64) [rsp+0x08]  do-not-enreg[SF] ld-addr-op <System.Diagnostics.CounterSample>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op <System.Diagnostics.CounterSample>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )    long  ->  zero-ref    "V01.[000..008)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 0
 
 G_M37667_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M37667_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x10]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
-       vmovdqu  ymm0, ymmword ptr [rcx+0x30]
-       vmovdqu  ymmword ptr [rsp+0x28], ymm0
-       mov      rax, qword ptr [rsp+0x08]
-						;; size=27 bbWeight=1 PerfScore 13.00
+       mov      rax, qword ptr [rcx+0x10]
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M37667_IG03:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 72
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 39, prolog size 4, PerfScore 15.50, instruction count 9, allocated bytes for code 39 (MethodHash=0d196cdc) for method System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=0d196cdc) for method System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -39,9 +33,8 @@ Unwind Info:
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
<summary><span style="color:green">-33</span> (<span style="color:green">-86.84%</span>) : 59265.dasm - Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,31 +10,23 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  2,  4   )  struct (56) [rsp+0x00]  do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
+;* V02 tmp1         [V02    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
+;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    "V02.[024..032)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M6972_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M6972_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M6972_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x58]
-       vmovdqu  ymmword ptr [rsp], ymm0
-       vmovdqu  ymm0, ymmword ptr [rcx+0x70]
-       vmovdqu  ymmword ptr [rsp+0x18], ymm0
-						;; size=21 bbWeight=1 PerfScore 12.00
-G_M6972_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp+0x18]
+       mov      rax, gword ptr [rcx+0x70]
        ; gcrRegs +[rax]
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M6972_IG04:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 56
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M6972_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 38, prolog size 4, PerfScore 15.50, instruction count 9, allocated bytes for code 38 (MethodHash=b5f3e4c3) for method Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=b5f3e4c3) for method Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +34,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:green">-25</span> (<span style="color:green">-86.21%</span>) : 174052.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[int,System.Nullable`1[int]]:get_Current():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,30 +9,25 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )   byref  ->  rcx         this single-def
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (16) [rsp+0x08]  do-not-enreg[SF] ld-addr-op <System.Collections.Generic.KeyValuePair`2[int,System.Nullable`1[int]]>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op <System.Collections.Generic.KeyValuePair`2[int,System.Nullable`1[int]]>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V04 tmp2         [V04    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "V01.[000..004)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M33908_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M33908_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       mov      rax, qword ptr [rcx+0x24]
-       mov      qword ptr [rsp+0x08], rax
-       mov      eax, dword ptr [rcx+0x2C]
-       mov      dword ptr [rsp+0x10], eax
-       mov      eax, dword ptr [rsp+0x08]
-						;; size=20 bbWeight=1 PerfScore 7.00
+       mov      eax, dword ptr [rcx+0x24]
+						;; size=3 bbWeight=1 PerfScore 2.00
 G_M33908_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 29, prolog size 4, PerfScore 8.50, instruction count 8, allocated bytes for code 29 (MethodHash=2dbf7b8b) for method Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[int,System.Nullable`1[int]]:get_Current():int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=2dbf7b8b) for method Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[int,System.Nullable`1[int]]:get_Current():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -40,9 +35,8 @@ Unwind Info:
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
<summary><span style="color:red">+45</span> (<span style="color:red">+67.16%</span>) : 273388.dasm - System.Diagnostics.CounterSample:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,31 +9,55 @@
 ; Final local variable assignments
 ;
 ;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 tmp1         [V01,T00] (  3,  6   )  struct (64) [rsp+0x08]  do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Diagnostics.CounterSample>
+;* V01 tmp1         [V01    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Diagnostics.CounterSample>
+;* V02 tmp2         [V02    ] (  0,  0   )    long  ->  zero-ref    "V01.[000..008)"
+;* V03 tmp3         [V03    ] (  0,  0   )    long  ->  zero-ref    "V01.[008..016)"
+;* V04 tmp4         [V04    ] (  0,  0   )    long  ->  zero-ref    "V01.[016..024)"
+;* V05 tmp5         [V05    ] (  0,  0   )    long  ->  zero-ref    "V01.[024..032)"
+;* V06 tmp6         [V06    ] (  0,  0   )     int  ->  zero-ref    "V01.[032..036)"
+;* V07 tmp7         [V07    ] (  0,  0   )    long  ->  zero-ref    "V01.[040..048)"
+;* V08 tmp8         [V08    ] (  0,  0   )    long  ->  zero-ref    "V01.[048..056)"
+;* V09 tmp9         [V09    ] (  0,  0   )    long  ->  zero-ref    "V01.[056..064)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 0
 
 G_M6629_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M6629_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vxorps   ymm0, ymm0, ymm0
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
-       vmovdqu  ymmword ptr [rsp+0x28], ymm0
-       mov      dword ptr [rsp+0x28], 0x10000
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       vmovdqu  ymm0, ymmword ptr [rsp+0x08]
-       vmovdqu  ymmword ptr [rax], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x28]
-       vmovdqu  ymmword ptr [rax+0x20], ymm0
-						;; size=55 bbWeight=1 PerfScore 15.58
-G_M6629_IG03:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 72
+       xor      eax, eax
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      qword ptr [rcx], rax
+						;; size=15 bbWeight=1 PerfScore 1.50
+G_M6629_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+       mov      rax, 0xD1FFAB1E
+       mov      dword ptr [rax], 0x10000
+       xor      eax, eax
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=44 bbWeight=1 PerfScore 4.00
+G_M6629_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG08:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 67, prolog size 4, PerfScore 18.08, instruction count 13, allocated bytes for code 67 (MethodHash=8448e61a) for method System.Diagnostics.CounterSample:.cctor() (FullOpts)
+; Total bytes of code 112, prolog size 0, PerfScore 11.50, instruction count 19, allocated bytes for code 112 (MethodHash=8448e61a) for method System.Diagnostics.CounterSample:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -41,9 +65,8 @@ Unwind Info:
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
<summary><span style="color:red">+17</span> (<span style="color:red">+77.27%</span>) : 28376.dasm - System.Diagnostics.Tracing.PropertyValue:.ctor(System.Decimal):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,15 +8,19 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  5,  5   )   byref  ->  rcx         this single-def
-;  V01 arg1         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T02] (  5,  5   )   byref  ->  rcx         this single-def
+;  V01 arg1         [V01,T00] (  5, 10   )   byref  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Diagnostics.Tracing.PropertyValue+Scalar>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T02] (  2,  4   )  struct (16) mm0         "Inlining Arg" <System.Diagnostics.Tracing.PropertyValue+Scalar>
+;* V04 tmp1         [V04    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.Diagnostics.Tracing.PropertyValue+Scalar>
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref    "field V01._flags (fldOffset=0x0)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V01._hi32 (fldOffset=0x4)" P-INDEP
 ;* V07 tmp4         [V07    ] (  0,  0   )    long  ->  zero-ref    "field V01._lo64 (fldOffset=0x8)" P-INDEP
-;* V08 tmp5         [V08    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Decimal>
+;  V08 tmp5         [V08,T03] (  2,  2   )     int  ->  rax         "V04.[000..004)"
+;  V09 tmp6         [V09,T04] (  2,  2   )     int  ->   r8         "V04.[004..008)"
+;  V10 tmp7         [V10,T05] (  2,  2   )    long  ->  rdx         "V04.[008..016)"
+;  V11 tmp8         [V11,T01] (  4,  8   )   byref  ->  r10         single-def "Spilling address for field-by-field copy"
+;* V12 tmp9         [V12    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Decimal>
 ;
 ; Lcl frame size = 0
 
@@ -24,18 +28,26 @@ G_M7566_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M7566_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
-       vmovups  xmm0, xmmword ptr [rdx]
-       xor      rax, rax
-       ; gcrRegs +[rax]
-       mov      gword ptr [rcx], rax
-       vmovups  xmmword ptr [rcx+0x10], xmm0
+       mov      eax, dword ptr [rdx]
+       mov      r8d, dword ptr [rdx+0x04]
+       mov      rdx, qword ptr [rdx+0x08]
+       ; byrRegs -[rdx]
+       xor      r10, r10
+       ; gcrRegs +[r10]
+       mov      gword ptr [rcx], r10
+       lea      r10, bword ptr [rcx+0x10]
+       ; gcrRegs -[r10]
+       ; byrRegs +[r10]
+       mov      dword ptr [r10], eax
+       mov      dword ptr [r10+0x04], r8d
+       mov      qword ptr [r10+0x08], rdx
        mov      dword ptr [rcx+0x08], 16
-						;; size=21 bbWeight=1 PerfScore 8.25
+						;; size=38 bbWeight=1 PerfScore 11.75
 G_M7566_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 9.25, instruction count 6, allocated bytes for code 22 (MethodHash=d855e271) for method System.Diagnostics.Tracing.PropertyValue:.ctor(System.Decimal):this (FullOpts)
+; Total bytes of code 39, prolog size 0, PerfScore 12.75, instruction count 11, allocated bytes for code 39 (MethodHash=d855e271) for method System.Diagnostics.Tracing.PropertyValue:.ctor(System.Decimal):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+18</span> (<span style="color:red">+81.82%</span>) : 28374.dasm - System.Diagnostics.Tracing.PropertyValue:.ctor(System.DateTimeOffset):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,14 +8,17 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  5,  5   )   byref  ->  rcx         this single-def
-;  V01 arg1         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
+;  V00 this         [V00,T02] (  5,  5   )   byref  ->  rcx         this single-def
+;  V01 arg1         [V01,T00] (  5, 10   )   byref  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Diagnostics.Tracing.PropertyValue+Scalar>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T02] (  2,  4   )  struct (16) mm0         "Inlining Arg" <System.Diagnostics.Tracing.PropertyValue+Scalar>
+;  V04 tmp1         [V04,T03] (  2,  4   )  struct (16) mm0         "Inlining Arg" <System.Diagnostics.Tracing.PropertyValue+Scalar>
 ;* V05 tmp2         [V05    ] (  0,  0   )   short  ->  zero-ref    "field V01._offsetMinutes (fldOffset=0x0)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "field V01._dateTime (fldOffset=0x8)" P-INDEP
-;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.DateTimeOffset>
+;  V07 tmp4         [V07,T04] (  2,  2   )   short  ->  rax         "V04.[000..002)"
+;  V08 tmp5         [V08,T05] (  2,  2   )    long  ->   r8         "V04.[008..016)"
+;  V09 tmp6         [V09,T01] (  4,  8   )   byref  ->  rdx         single-def "Spilling address for field-by-field copy"
+;* V10 tmp7         [V10    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.DateTimeOffset>
 ;
 ; Lcl frame size = 0
 
@@ -23,18 +26,26 @@ G_M33993_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M33993_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0006 {rcx rdx}, byref
        ; byrRegs +[rcx rdx]
+       movsx    rax, word  ptr [rdx]
+       mov      r8, qword ptr [rdx+0x08]
        vmovups  xmm0, xmmword ptr [rdx]
-       xor      rax, rax
-       ; gcrRegs +[rax]
-       mov      gword ptr [rcx], rax
-       vmovups  xmmword ptr [rcx+0x10], xmm0
+       xor      rdx, rdx
+       ; gcrRegs +[rdx]
+       ; byrRegs -[rdx]
+       mov      gword ptr [rcx], rdx
+       lea      rdx, bword ptr [rcx+0x10]
+       ; gcrRegs -[rdx]
+       ; byrRegs +[rdx]
+       vmovups  xmmword ptr [rdx], xmm0
+       mov      word  ptr [rdx], ax
+       mov      qword ptr [rdx+0x08], r8
        mov      dword ptr [rcx+0x08], 16
-						;; size=21 bbWeight=1 PerfScore 8.25
+						;; size=39 bbWeight=1 PerfScore 16.75
 G_M33993_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 9.25, instruction count 6, allocated bytes for code 22 (MethodHash=8a3a7b36) for method System.Diagnostics.Tracing.PropertyValue:.ctor(System.DateTimeOffset):this (FullOpts)
+; Total bytes of code 40, prolog size 0, PerfScore 17.75, instruction count 11, allocated bytes for code 40 (MethodHash=8a3a7b36) for method System.Diagnostics.Tracing.PropertyValue:.ctor(System.DateTimeOffset):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-86.84%</span>) : 54878.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_Resolution():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,30 +11,22 @@
 ;  V00 this         [V00,T00] (  3,  3   )   byref  ->  rcx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  2,  4   )  struct (56) [rsp+0x00]  do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] "location for address-of(RValue)" <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
+;* V04 tmp2         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "V03.[004..005)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M29767_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M29767_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M29767_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x18]
-       vmovdqu  ymmword ptr [rsp], ymm0
-       vmovdqu  ymm0, ymmword ptr [rcx+0x30]
-       vmovdqu  ymmword ptr [rsp+0x18], ymm0
-						;; size=21 bbWeight=1 PerfScore 12.00
-G_M29767_IG03:        ; bbWeight=1, extend
-       movzx    rax, byte  ptr [rsp+0x04]
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M29767_IG04:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 56
+       movzx    rax, byte  ptr [rcx+0x1C]
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M29767_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 38, prolog size 4, PerfScore 15.50, instruction count 9, allocated bytes for code 38 (MethodHash=aac58bb8) for method Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_Resolution():ubyte:this (Tier1)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=aac58bb8) for method Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_Resolution():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +34,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:green">-27</span> (<span style="color:green">-84.38%</span>) : 65520.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,30 +9,23 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.Diagnostics.AnalysisScope>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (24) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <System.Nullable`1[Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile]>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <System.Nullable`1[Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile]>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[000..001)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M30380_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M30380_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M30380_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       vmovdqu  xmm0, xmmword ptr [rcx+0x18]
-       vmovdqu  xmmword ptr [rsp], xmm0
-       mov      rax, qword ptr [rcx+0x28]
-       mov      qword ptr [rsp+0x10], rax
-						;; size=19 bbWeight=1 PerfScore 8.00
-G_M30380_IG03:        ; bbWeight=1, extend
-       movzx    rax, byte  ptr [rsp]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M30380_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
+       movzx    rax, byte  ptr [rcx+0x18]
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M30380_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 32, prolog size 4, PerfScore 10.50, instruction count 8, allocated bytes for code 32 (MethodHash=ba3b8953) for method Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (Tier1)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=ba3b8953) for method Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -40,9 +33,8 @@ Unwind Info:
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
<summary><span style="color:green">-33</span> (<span style="color:green">-67.35%</span>) : 54150.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,37 +10,29 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )   byref  ->  rcx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
-;  V02 loc0         [V02,T01] (  2,  2   )  struct (56) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
+;* V02 loc0         [V02    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V04 tmp1         [V04,T01] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
 ;* V05 tmp2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V06 tmp3         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "V02.[004..005)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M48037_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M48037_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M48037_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x18]
-       vmovdqu  ymmword ptr [rsp], ymm0
-       vmovdqu  ymm0, ymmword ptr [rcx+0x30]
-       vmovdqu  ymmword ptr [rsp+0x18], ymm0
-						;; size=21 bbWeight=1 PerfScore 12.00
-G_M48037_IG03:        ; bbWeight=1, extend
-       movzx    rax, byte  ptr [rsp+0x04]
+       movzx    rax, byte  ptr [rcx+0x1C]
        dec      eax
        cmp      eax, 1
        setbe    al
        movzx    rax, al
-						;; size=16 bbWeight=1 PerfScore 2.75
-G_M48037_IG04:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 56
+						;; size=15 bbWeight=1 PerfScore 3.75
+G_M48037_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 49, prolog size 4, PerfScore 17.25, instruction count 13, allocated bytes for code 49 (MethodHash=e95c445a) for method Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (Tier1)
+; Total bytes of code 16, prolog size 0, PerfScore 4.75, instruction count 6, allocated bytes for code 16 (MethodHash=e95c445a) for method Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -48,9 +40,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+16.67%</span>) : 658470.dasm - Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalFunctionState:.ctor(Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,15 +8,17 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalFunctionState>
+;  V00 this         [V00,T00] (  6,  6   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalFunctionState>
 ;  V01 arg1         [V01,T01] (  4,  4   )  struct ( 8) [rsp+0x10]  do-not-enreg[SF] ld-addr-op single-def <Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct ( 8) zero-ref    "impAppendStmt" <Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState>
-;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "field V03.Alive (fldOffset=0x0)" P-INDEP
-;* V06 tmp4         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "field V03.Reported (fldOffset=0x1)" P-INDEP
-;* V07 tmp5         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "field V04.Alive (fldOffset=0x0)" P-INDEP
-;* V08 tmp6         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "field V04.Reported (fldOffset=0x1)" P-INDEP
+;  V05 tmp3         [V05,T04] (  2,  2   )   ubyte  ->  rax         "field V03.Alive (fldOffset=0x0)" P-INDEP
+;  V06 tmp4         [V06,T05] (  2,  2   )   ubyte  ->  rdx         "field V03.Reported (fldOffset=0x1)" P-INDEP
+;  V07 tmp5         [V07,T02] (  3,  3   )   ubyte  ->  rax         "field V04.Alive (fldOffset=0x0)" P-INDEP
+;  V08 tmp6         [V08,T03] (  3,  3   )   ubyte  ->  rdx         "field V04.Reported (fldOffset=0x1)" P-INDEP
+;  V09 tmp7         [V09,T06] (  2,  2   )   ubyte  ->  rax         "V01.[000..001)"
+;  V10 tmp8         [V10,T07] (  2,  2   )   ubyte  ->  rdx         "V01.[001..002)"
 ;
 ; Lcl frame size = 0
 
@@ -25,16 +27,18 @@ G_M29403_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 1.00
 G_M29403_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movzx    rax, word  ptr [rsp+0x10]
-       mov      word  ptr [rcx+0x09], ax
-       movzx    rax, word  ptr [rsp+0x10]
-       mov      word  ptr [rcx+0x0B], ax
-						;; size=18 bbWeight=1 PerfScore 4.00
+       movzx    rax, byte  ptr [rsp+0x10]
+       movzx    rdx, byte  ptr [rsp+0x11]
+       mov      byte  ptr [rcx+0x09], al
+       mov      byte  ptr [rcx+0x0A], dl
+       mov      byte  ptr [rcx+0x0B], al
+       mov      byte  ptr [rcx+0x0C], dl
+						;; size=22 bbWeight=1 PerfScore 6.00
 G_M29403_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 24, prolog size 0, PerfScore 6.00, instruction count 6, allocated bytes for code 24 (MethodHash=d1a68d24) for method Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalFunctionState:.ctor(Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState):this (Tier1)
+; Total bytes of code 28, prolog size 0, PerfScore 8.00, instruction count 8, allocated bytes for code 28 (MethodHash=d1a68d24) for method Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalFunctionState:.ctor(Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+18.92%</span>) : 651924.dasm - Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult:Applicable(Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature,Microsoft.CodeAnalysis.CSharp.Conversion):Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,49 +8,54 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T03] (  4,  4   )   byref  ->  rbx         single-def
-;  V01 arg0         [V01,T01] (  3,  6   )   byref  ->  rdx         single-def
-;  V02 arg1         [V02,T02] (  3,  6   )   byref  ->   r8         single-def
+;  V00 RetBuf       [V00,T01] (  6,  6   )   byref  ->  rbx         single-def
+;  V01 arg0         [V01,T02] (  3,  6   )   byref  ->  rdx         single-def
+;  V02 arg1         [V02,T00] (  4,  8   )   byref  ->   r8         single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T00] (  4,  8   )  struct (64) [rsp+0x00]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
+;  V04 tmp1         [V04,T03] (  3,  6   )  struct (64) [rsp+0x08]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
 ;* V05 tmp2         [V05    ] (  0,  0   )     ref  ->  zero-ref    "field V02._uncommonData (fldOffset=0x0)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "field V02._kind (fldOffset=0x8)" P-INDEP
-;* V07 tmp4         [V07    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <Microsoft.CodeAnalysis.CSharp.Conversion>
+;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "V04.[000..001)"
+;  V08 tmp5         [V08,T04] (  2,  2   )     ref  ->  rax         single-def "V04.[048..056)"
+;  V09 tmp6         [V09,T05] (  2,  2   )   ubyte  ->  rbp         "V04.[056..057)"
+;* V10 tmp7         [V10    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <Microsoft.CodeAnalysis.CSharp.Conversion>
 ;
-; Lcl frame size = 64
+; Lcl frame size = 72
 
 G_M46487_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 72
+       xor      eax, eax
+       mov      qword ptr [rsp+0x08], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp], ymm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqu  ymmword ptr [rsp+0x10], ymm4
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=25 bbWeight=1 PerfScore 7.83
-G_M46487_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=010C {rdx rbx r8}, byref
+						;; size=39 bbWeight=1 PerfScore 11.08
+G_M46487_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=010C {rdx rbx r8}, byref, nogc
        ; byrRegs +[rdx r8]
-       mov      byte  ptr [rsp], 3
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M46487_IG03:        ; bbWeight=1, nogc, extend
        vmovdqu  ymm0, ymmword ptr [rdx]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
+       vmovdqu  ymmword ptr [rsp+0x10], ymm0
        mov      rax, qword ptr [rdx+0x20]
-       mov      qword ptr [rsp+0x28], rax
+       mov      qword ptr [rsp+0x30], rax
 						;; size=19 bbWeight=1 PerfScore 9.00
-G_M46487_IG04:        ; bbWeight=1, nogc, extend
-       vmovdqu  xmm0, xmmword ptr [r8]
-       vmovdqu  xmmword ptr [rsp+0x30], xmm0
-						;; size=11 bbWeight=1 PerfScore 5.00
-G_M46487_IG05:        ; bbWeight=1, extend
+G_M46487_IG03:        ; bbWeight=1, extend
+       mov      rax, gword ptr [r8]
+       ; gcrRegs +[rax]
+       movzx    rbp, byte  ptr [r8+0x08]
+       mov      gword ptr [rsp+0x38], rax
        mov      rdi, rbx
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp]
+       lea      rsi, bword ptr [rsp+0x08]
        ; byrRegs +[rsi]
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[rax]
        ; byrRegs -[rdx r8]
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
@@ -58,19 +63,22 @@ G_M46487_IG05:        ; bbWeight=1, extend
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        movsq    
+       mov      byte  ptr [rbx], 3
+       mov      byte  ptr [rbx+0x38], bpl
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=41 bbWeight=1 PerfScore 9.00
-G_M46487_IG06:        ; bbWeight=1, epilog, nogc, extend
+						;; size=62 bbWeight=1 PerfScore 16.00
+G_M46487_IG04:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 64
+       add      rsp, 72
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=1 PerfScore 3.75
+						;; size=12 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 111, prolog size 22, PerfScore 35.58, instruction count 32, allocated bytes for code 111 (MethodHash=61704a68) for method Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult:Applicable(Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature,Microsoft.CodeAnalysis.CSharp.Conversion):Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult (Tier1)
+; Total bytes of code 132, prolog size 36, PerfScore 40.33, instruction count 39, allocated bytes for code 132 (MethodHash=61704a68) for method Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult:Applicable(Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature,Microsoft.CodeAnalysis.CSharp.Conversion):Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -78,12 +86,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+47</span> (<span style="color:red">+19.50%</span>) : 54497.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper+CheckConstraintsArgs:.ctor(Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.ConversionsBase,ubyte,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,22 +8,29 @@
 ; 2 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  8,  8   )   byref  ->  rdi         this single-def
-;  V01 arg1         [V01,T01] (  7,  5.00)     ref  ->  rbx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
-;  V02 arg2         [V02,T03] (  3,  3   )     ref  ->  rbp         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.ConversionsBase>
-;  V03 arg3         [V03,T04] (  3,  3   )   ubyte  ->  r14         single-def
-;  V04 arg4         [V04,T07] (  1,  1   )     ref  ->  [rsp+0xA0]  class-hnd single-def <Microsoft.CodeAnalysis.Location>
-;  V05 arg5         [V05,T05] (  3,  2.50)     ref  ->  r15         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
+;  V00 this         [V00,T00] (  8,  8   )   byref  ->  rbx         this single-def
+;  V01 arg1         [V01,T01] (  7,  5.00)     ref  ->  rbp         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
+;  V02 arg2         [V02,T04] (  3,  3   )     ref  ->  r14         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.ConversionsBase>
+;  V03 arg3         [V03,T05] (  3,  3   )   ubyte  ->  r15         single-def
+;  V04 arg4         [V04,T10] (  1,  1   )     ref  ->  [rsp+0xB0]  class-hnd single-def <Microsoft.CodeAnalysis.Location>
+;  V05 arg5         [V05,T06] (  3,  2.50)     ref  ->  r13         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T02] (  5,  5   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
-;  V08 tmp2         [V08,T06] (  2,  2.36)     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
-;* V09 tmp3         [V09    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
+;* V07 tmp1         [V07    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
+;  V08 tmp2         [V08,T07] (  2,  2.36)     ref  ->  rsi         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
+;  V09 tmp3         [V09,T03] (  3,  6   )  struct (32) [rsp+0x28]  do-not-enreg[S] must-init "Inlining Arg" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
+;  V10 tmp4         [V10,T08] (  3,  2.18)     ref  ->  registers   "V07.[016..024)"
+;  V11 tmp5         [V11,T09] (  4,  1.50)   ubyte  ->  [rsp+0x24]  "V07.[025..026)"
+;* V12 tmp6         [V12    ] (  0,  0   )     ref  ->  zero-ref    single-def "V09.[016..024)"
+;* V13 tmp7         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "V09.[025..026)"
+;  V14 tmp8         [V14,T02] (  3,  6   )   byref  ->  rbx         single-def "Spilling address for field-by-field copy"
 ;
 ; Lcl frame size = 72
 
 G_M41257_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
@@ -34,90 +41,101 @@ G_M41257_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vxorps   xmm4, xmm4, xmm4
        vmovdqa  xmmword ptr [rsp+0x30], xmm4
        mov      qword ptr [rsp+0x40], rax
-       mov      rdi, rcx
-       ; byrRegs +[rdi]
-       mov      rbx, rdx
-       ; gcrRegs +[rbx]
-       mov      rbp, r8
+       mov      rbx, rcx
+       ; byrRegs +[rbx]
+       mov      rbp, rdx
        ; gcrRegs +[rbp]
-       mov      r14d, r9d
-       mov      r15, gword ptr [rsp+0xA8]
-       ; gcrRegs +[r15]
-						;; size=54 bbWeight=1 PerfScore 12.83
-G_M41257_IG02:        ; bbWeight=1, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0080 {rdi}, byref
-       cmp      gword ptr [rbx+0xC8], 0
+       mov      r14, r8
+       ; gcrRegs +[r14]
+       mov      r15d, r9d
+       mov      r13, gword ptr [rsp+0xB8]
+       ; gcrRegs +[r13]
+						;; size=58 bbWeight=1 PerfScore 14.83
+G_M41257_IG02:        ; bbWeight=1, gcrefRegs=6020 {rbp r13 r14}, byrefRegs=0008 {rbx}, byref
+       cmp      gword ptr [rbp+0xC8], 0
        je       G_M41257_IG08
 						;; size=14 bbWeight=1 PerfScore 4.00
-G_M41257_IG03:        ; bbWeight=1, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0080 {rdi}, byref
-       mov      rcx, gword ptr [rbx+0xC8]
-       ; gcrRegs +[rcx]
+G_M41257_IG03:        ; bbWeight=1, gcrefRegs=6020 {rbp r13 r14}, byrefRegs=0008 {rbx}, byref
+       mov      rsi, gword ptr [rbp+0xC8]
+       ; gcrRegs +[rsi]
+       xor      r12, r12
+       ; gcrRegs +[r12]
+       test     r13, r13
+       je       G_M41257_IG10
+						;; size=19 bbWeight=1 PerfScore 3.50
+G_M41257_IG04:        ; bbWeight=0.50, gcrefRegs=7060 {rbp rsi r12 r13 r14}, byrefRegs=0008 {rbx}, byref
+       cmp      gword ptr [r13+0x10], 0
+       jne      G_M41257_IG09
+						;; size=11 bbWeight=0.50 PerfScore 2.00
+G_M41257_IG05:        ; bbWeight=0.32, gcrefRegs=7020 {rbp r12 r13 r14}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs -[rsi]
+       mov      edi, 1
+       mov      dword ptr [rsp+0x24], edi
+						;; size=9 bbWeight=0.32 PerfScore 0.40
+G_M41257_IG06:        ; bbWeight=1, gcrefRegs=7020 {rbp r12 r13 r14}, byrefRegs=0008 {rbx}, byref
        vxorps   ymm0, ymm0, ymm0
        vmovdqu  ymmword ptr [rsp+0x28], ymm0
-       test     r15, r15
-       je       G_M41257_IG10
-						;; size=26 bbWeight=1 PerfScore 4.58
-G_M41257_IG04:        ; bbWeight=0.50, gcrefRegs=802A {rcx rbx rbp r15}, byrefRegs=0080 {rdi}, byref, isz
-       cmp      gword ptr [r15+0x10], 0
-       jne      SHORT G_M41257_IG09
-						;; size=7 bbWeight=0.50 PerfScore 2.00
-G_M41257_IG05:        ; bbWeight=0.32, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0080 {rdi}, byref
-       ; gcrRegs -[rcx]
-       mov      byte  ptr [rsp+0x41], 1
-						;; size=5 bbWeight=0.32 PerfScore 0.32
-G_M41257_IG06:        ; bbWeight=1, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0080 {rdi}, byref
-       mov      rcx, rdi
-       ; byrRegs +[rcx]
-       mov      rdx, rbx
-       ; gcrRegs +[rdx]
-       call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       ; gcrRegs -[rdx rbx]
-       ; byrRegs -[rcx]
-       lea      rcx, bword ptr [rdi+0x08]
+       mov      rcx, rbx
        ; byrRegs +[rcx]
        mov      rdx, rbp
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx rbp]
        ; byrRegs -[rcx]
-       mov      byte  ptr [rdi+0x20], r14b
-       lea      rcx, bword ptr [rdi+0x10]
+       lea      rcx, bword ptr [rbx+0x08]
        ; byrRegs +[rcx]
-       mov      rdx, gword ptr [rsp+0xA0]
+       mov      rdx, r14
+       ; gcrRegs +[rdx]
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+       ; gcrRegs -[rdx r14]
+       ; byrRegs -[rcx]
+       mov      byte  ptr [rbx+0x20], r15b
+       lea      rcx, bword ptr [rbx+0x10]
+       ; byrRegs +[rcx]
+       mov      rdx, gword ptr [rsp+0xB0]
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       lea      rcx, bword ptr [rdi+0x18]
+       lea      rcx, bword ptr [rbx+0x18]
        ; byrRegs +[rcx]
-       mov      rdx, r15
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       ; gcrRegs -[rdx r15]
+       ; gcrRegs -[rdx r13]
        ; byrRegs -[rcx]
-       add      rdi, 40
+       mov      gword ptr [rsp+0x38], r12
+       add      rbx, 40
+       mov      rdi, rbx
+       ; byrRegs +[rdi]
        lea      rsi, bword ptr [rsp+0x28]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[r12]
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
        movsq    
-						;; size=82 bbWeight=1 PerfScore 13.25
+       mov      r12d, dword ptr [rsp+0x24]
+       mov      byte  ptr [rbx+0x19], r12b
+						;; size=109 bbWeight=1 PerfScore 17.83
 G_M41257_IG07:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 72
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r12
+       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M41257_IG08:        ; bbWeight=0.00, gcVars=0000000000000000 {}, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0080 {rdi}, gcvars, byref
-       ; gcrRegs +[rbx rbp r15]
-       ; byrRegs -[rsi]
-       mov      rcx, gword ptr [rbx+0xD0]
+						;; size=17 bbWeight=1 PerfScore 5.25
+G_M41257_IG08:        ; bbWeight=0.00, gcVars=0000000000000000 {}, gcrefRegs=6020 {rbp r13 r14}, byrefRegs=0008 {rbx}, gcvars, byref
+       ; gcrRegs +[rbp r13-r14]
+       ; byrRegs -[rsi rdi]
+       mov      rcx, gword ptr [rbp+0xD0]
        ; gcrRegs +[rcx]
-       mov      rdx, rbx
+       mov      rdx, rbp
        ; gcrRegs +[rdx]
        cmp      dword ptr [rcx], ecx
        call     [Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:CreateSourceAssemblyForCompilation(Microsoft.CodeAnalysis.CSharp.CSharpCompilation):this]
@@ -125,18 +143,22 @@ G_M41257_IG08:        ; bbWeight=0.00, gcVars=0000000000000000 {}, gcrefRegs=802
        ; gcr arg pop 0
        jmp      G_M41257_IG03
 						;; size=23 bbWeight=0.00 PerfScore 0.01
-G_M41257_IG09:        ; bbWeight=0.18, gcrefRegs=802A {rcx rbx rbp r15}, byrefRegs=0080 {rdi}, byref, isz
-       ; gcrRegs +[rcx]
-       mov      gword ptr [rsp+0x38], rcx
-       jmp      SHORT G_M41257_IG06
-						;; size=7 bbWeight=0.18 PerfScore 0.54
-G_M41257_IG10:        ; bbWeight=0, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0080 {rdi}, byref
-       ; gcrRegs -[rcx]
-       mov      byte  ptr [rsp+0x41], 2
+G_M41257_IG09:        ; bbWeight=0.18, gcrefRegs=6060 {rbp rsi r13 r14}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs +[rsi]
+       xor      edi, edi
+       mov      dword ptr [rsp+0x24], edi
+       mov      r12, rsi
+       ; gcrRegs +[r12]
        jmp      G_M41257_IG06
-						;; size=10 bbWeight=0 PerfScore 0.00
+						;; size=14 bbWeight=0.18 PerfScore 0.63
+G_M41257_IG10:        ; bbWeight=0, gcrefRegs=7020 {rbp r12 r13 r14}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs -[rsi]
+       mov      esi, 2
+       mov      dword ptr [rsp+0x24], esi
+       jmp      G_M41257_IG06
+						;; size=14 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 241, prolog size 34, PerfScore 41.79, instruction count 63, allocated bytes for code 241 (MethodHash=61645ed6) for method Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper+CheckConstraintsArgs:.ctor(Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.ConversionsBase,ubyte,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
+; Total bytes of code 288, prolog size 38, PerfScore 48.46, instruction count 76, allocated bytes for code 288 (MethodHash=61645ed6) for method Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper+CheckConstraintsArgs:.ctor(Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.ConversionsBase,ubyte,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -144,15 +166,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x10
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r12 (12)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-23</span> (<span style="color:green">-82.14%</span>) : 187449.dasm - System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,30 +9,24 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (32) [rsp+0x08]  do-not-enreg[SF] ld-addr-op <System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op <System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    "V01.[000..008)"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M14348_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M14348_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M14348_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x40]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
-						;; size=11 bbWeight=1 PerfScore 6.00
-G_M14348_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp+0x08]
+       mov      rax, gword ptr [rcx+0x40]
        ; gcrRegs +[rax]
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M14348_IG04:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M14348_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 28, prolog size 4, PerfScore 9.50, instruction count 7, allocated bytes for code 28 (MethodHash=779bc7f3) for method System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=779bc7f3) for method System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -40,9 +34,8 @@ Unwind Info:
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
<summary><span style="color:green">-23</span> (<span style="color:green">-82.14%</span>) : 188221.dasm - System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,30 +9,24 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (32) [rsp+0x08]  do-not-enreg[SF] ld-addr-op <System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op <System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    "V01.[000..008)"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M46171_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M46171_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M46171_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x30]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
-						;; size=11 bbWeight=1 PerfScore 6.00
-G_M46171_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp+0x08]
+       mov      rax, gword ptr [rcx+0x30]
        ; gcrRegs +[rax]
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M46171_IG04:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M46171_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 28, prolog size 4, PerfScore 9.50, instruction count 7, allocated bytes for code 28 (MethodHash=32d04ba4) for method System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=32d04ba4) for method System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -40,9 +34,8 @@ Unwind Info:
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
<summary><span style="color:green">-31</span> (<span style="color:green">-68.89%</span>) : 22483.dasm - NuGet.Packaging.Signing.SignatureTrustAndValidityVerificationProvider:IsSignatureExpired(NuGet.Packaging.Signing.SignatureVerificationSummary):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,40 +9,34 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  4,  3.50)     ref  ->  rcx         class-hnd single-def <NuGet.Packaging.Signing.SignatureVerificationSummary>
-;  V01 loc0         [V01,T01] (  2,  1   )  struct (24) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <System.Nullable`1[System.DateTimeOffset]>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <System.Nullable`1[System.DateTimeOffset]>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "V01.[000..001)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M13677_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M13677_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        cmp      dword ptr [rcx+0x18], 2
        je       SHORT G_M13677_IG05
 						;; size=6 bbWeight=1 PerfScore 4.00
 G_M13677_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       vmovdqu  xmm0, xmmword ptr [rcx+0x28]
-       vmovdqu  xmmword ptr [rsp], xmm0
-       mov      rax, qword ptr [rcx+0x38]
-       mov      qword ptr [rsp+0x10], rax
-       movzx    rax, byte  ptr [rsp]
-						;; size=23 bbWeight=0.50 PerfScore 4.50
+       movzx    rax, byte  ptr [rcx+0x28]
+						;; size=4 bbWeight=0.50 PerfScore 1.00
 G_M13677_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
+						;; size=1 bbWeight=0.50 PerfScore 0.50
 G_M13677_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rcx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M13677_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 24
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
+						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 45, prolog size 4, PerfScore 10.12, instruction count 13, allocated bytes for code 45 (MethodHash=1b17ca92) for method NuGet.Packaging.Signing.SignatureTrustAndValidityVerificationProvider:IsSignatureExpired(NuGet.Packaging.Signing.SignatureVerificationSummary):ubyte (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 6.12, instruction count 6, allocated bytes for code 14 (MethodHash=1b17ca92) for method NuGet.Packaging.Signing.SignatureTrustAndValidityVerificationProvider:IsSignatureExpired(NuGet.Packaging.Signing.SignatureVerificationSummary):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -50,9 +44,8 @@ Unwind Info:
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
<summary><span style="color:red">+27</span> (<span style="color:red">+18.75%</span>) : 272986.dasm - System.Text.Json.Tests.JsonReaderStateAndOptionsTests+<>c__DisplayClass3_0:<TestCommentHandlingInvalid>b__1():System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,52 +8,63 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Text.Json.Tests.JsonReaderStateAndOptionsTests+<>c__DisplayClass3_0>
+;  V00 this         [V00,T02] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Text.Json.Tests.JsonReaderStateAndOptionsTests+<>c__DisplayClass3_0>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Text.Json.JsonReaderOptions>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  3,  6   )  struct (56) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Text.Json.JsonReaderState>
-;  V04 tmp2         [V04,T00] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Text.Json.JsonReaderState>
-;  V05 tmp3         [V05,T02] (  3,  6   )   ubyte  ->  rcx         "Inlining Arg"
+;  V03 tmp1         [V03,T03] (  2,  4   )  struct (56) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Text.Json.JsonReaderState>
+;  V04 tmp2         [V04,T00] ( 10, 20   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Text.Json.JsonReaderState>
+;  V05 tmp3         [V05,T01] (  3,  6   )   ubyte  ->  rbx         "Inlining Arg"
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Text.Json.JsonReaderOptions>
-;* V07 tmp5         [V07,T05] (  0,  0   )     int  ->  zero-ref    single-def "field V01._maxDepth (fldOffset=0x0)" P-INDEP
-;  V08 tmp6         [V08,T04] (  2,  2   )   ubyte  ->  rcx         single-def "field V01._commentHandling (fldOffset=0x4)" P-INDEP
-;* V09 tmp7         [V09,T06] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V01.<AllowTrailingCommas>k__BackingField (fldOffset=0x5)" P-INDEP
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    single-def "field V01._maxDepth (fldOffset=0x0)" P-INDEP
+;* V08 tmp6         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V01._commentHandling (fldOffset=0x4)" P-INDEP
+;* V09 tmp7         [V09    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V01.<AllowTrailingCommas>k__BackingField (fldOffset=0x5)" P-INDEP
 ;* V10 tmp8         [V10    ] (  0,  0   )     int  ->  zero-ref    single-def "field V06._maxDepth (fldOffset=0x0)" P-INDEP
 ;* V11 tmp9         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V06._commentHandling (fldOffset=0x4)" P-INDEP
 ;* V12 tmp10        [V12    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V06.<AllowTrailingCommas>k__BackingField (fldOffset=0x5)" P-INDEP
+;* V13 tmp11        [V13    ] (  0,  0   )    long  ->  zero-ref    single-def "V03.[000..008)"
+;* V14 tmp12        [V14    ] (  0,  0   )    long  ->  zero-ref    single-def "V03.[008..016)"
+;* V15 tmp13        [V15    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[016..017)"
+;* V16 tmp14        [V16    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[017..018)"
+;* V17 tmp15        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[018..019)"
+;* V18 tmp16        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[019..020)"
+;* V19 tmp17        [V19    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[020..021)"
+;* V20 tmp18        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[021..022)"
+;* V21 tmp19        [V21    ] (  0,  0   )     int  ->  zero-ref    single-def "V03.[024..028)"
+;* V22 tmp20        [V22    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[028..029)"
+;* V23 tmp21        [V23    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "V03.[029..030)"
 ;
-; Lcl frame size = 96
+; Lcl frame size = 88
 
 G_M22752_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 96
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 88
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       vmovdqa  xmmword ptr [rsp+0x50], xmm4
-						;; size=30 bbWeight=1 PerfScore 8.83
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqa  xmmword ptr [rsp+0x40], xmm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x50], rax
+						;; size=31 bbWeight=1 PerfScore 9.83
 G_M22752_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       movzx    rcx, byte  ptr [rcx+0x08]
-       ; gcrRegs -[rcx]
-       cmp      ecx, 2
-       jg       SHORT G_M22752_IG04
-       mov      byte  ptr [rsp+0x44], cl
+       movzx    rbx, byte  ptr [rcx+0x08]
+       cmp      ebx, 2
+       jg       SHORT G_M22752_IG07
        vxorps   xmm0, xmm0, xmm0
+       vmovdqu  xmmword ptr [rsp+0x40], xmm0
        vmovdqu  xmmword ptr [rsp+0x48], xmm0
-       vmovdqu  xmmword ptr [rsp+0x50], xmm0
        mov      rcx, 0xD1FFAB1E      ; System.Text.Json.JsonReaderState
+       ; gcrRegs -[rcx]
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-       lea      rdi, bword ptr [rbx+0x08]
+       mov      rbp, rax
+       ; gcrRegs +[rbp]
+       lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x28]
+       lea      rsi, bword ptr [rsp+0x20]
        ; byrRegs +[rsi]
        mov      ecx, 4
        rep movsq 
@@ -61,19 +72,34 @@ G_M22752_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs -[rax]
        movsq    
        movsq    
-       mov      rax, rbx
+       xor      eax, eax
+       mov      qword ptr [rbp+0x08], rax
+						;; size=75 bbWeight=1 PerfScore 37.58
+G_M22752_IG03:        ; bbWeight=1, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
+       ; byrRegs -[rsi rdi]
+       mov      qword ptr [rbp+0x10], rax
+						;; size=4 bbWeight=1 PerfScore 1.00
+G_M22752_IG04:        ; bbWeight=1, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
+       mov      dword ptr [rbp+0x18], eax
+       mov      word  ptr [rbp+0x1C], 0
+						;; size=9 bbWeight=1 PerfScore 2.00
+G_M22752_IG05:        ; bbWeight=1, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
+       mov      dword ptr [rbp+0x20], eax
+       mov      byte  ptr [rbp+0x24], bl
+       mov      byte  ptr [rbp+0x25], 0
+       mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=76 bbWeight=1 PerfScore 37.58
-G_M22752_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 96
+						;; size=13 bbWeight=1 PerfScore 3.25
+G_M22752_IG06:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 88
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
-G_M22752_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax rbx]
-       ; byrRegs -[rsi rdi]
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M22752_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs -[rax rbp]
        mov      ecx, 0x326C
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -87,7 +113,7 @@ G_M22752_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 144, prolog size 30, PerfScore 49.17, instruction count 38, allocated bytes for code 144 (MethodHash=d9f4a71f) for method System.Text.Json.Tests.JsonReaderStateAndOptionsTests+<>c__DisplayClass3_0:<TestCommentHandlingInvalid>b__1():System.Object:this (FullOpts)
+; Total bytes of code 171, prolog size 31, PerfScore 56.92, instruction count 47, allocated bytes for code 171 (MethodHash=d9f4a71f) for method System.Text.Json.Tests.JsonReaderStateAndOptionsTests+<>c__DisplayClass3_0:<TestCommentHandlingInvalid>b__1():System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -95,12 +121,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 11 * 8 + 8 = 96 = 0x60
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 10 * 8 + 8 = 88 = 0x58
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+23.47%</span>) : 101545.dasm - System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,57 +10,77 @@
 ;
 ;  V00 this         [V00,T03] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.ActivityTagsCollection>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V02 tmp1         [V02    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Diagnostics.ActivityTagsCollection+Enumerator>
-;  V03 tmp2         [V03,T01] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.ActivityTagsCollection+Enumerator>
-;  V04 tmp3         [V04,T02] (  3,  6   )     ref  ->  rcx         class-hnd single-def "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
-;  V05 tmp4         [V05,T00] (  4,  8   )  struct (32) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;  V02 tmp1         [V02,T02] (  3,  6   )  struct (32) [rsp+0x48]  do-not-enreg[S] ld-addr-op "NewObj constructor temp" <System.Diagnostics.ActivityTagsCollection+Enumerator>
+;  V03 tmp2         [V03,T00] (  5, 10   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Diagnostics.ActivityTagsCollection+Enumerator>
+;  V04 tmp3         [V04,T01] (  3,  6   )     ref  ->  rsi         class-hnd single-def "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;  V05 tmp4         [V05,T05] (  1,  2   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]>
+;* V06 tmp5         [V06    ] (  0,  0   )     ref  ->  zero-ref    single-def "V05.[000..008)"
+;* V07 tmp6         [V07    ] (  0,  0   )     int  ->  zero-ref    "V05.[008..012)"
+;  V08 tmp7         [V08,T04] (  2,  2   )     int  ->  rbx         "V05.[012..016)"
+;* V09 tmp8         [V09    ] (  0,  0   )     ref  ->  zero-ref    single-def "V02.[000..008)"
+;* V10 tmp9         [V10    ] (  0,  0   )     int  ->  zero-ref    "V02.[008..012)"
+;* V11 tmp10        [V11    ] (  0,  0   )     int  ->  zero-ref    "V02.[012..016)"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 104
 
 G_M49529_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 104
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
-						;; size=17 bbWeight=1 PerfScore 5.58
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
+						;; size=30 bbWeight=1 PerfScore 8.83
 G_M49529_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       mov      rcx, gword ptr [rcx+0x08]
-       mov      gword ptr [rsp+0x20], rcx
-       mov      ecx, dword ptr [rcx+0x14]
-       ; gcrRegs -[rcx]
-       mov      dword ptr [rsp+0x2C], ecx
-       vxorps   xmm0, xmm0, xmm0
-       vmovdqu  xmmword ptr [rsp+0x30], xmm0
+       mov      rsi, gword ptr [rcx+0x08]
+       ; gcrRegs +[rsi]
+       mov      ebx, dword ptr [rsi+0x14]
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M49529_IG03:        ; bbWeight=1, nogc, extend
+       vmovdqu  ymm0, ymmword ptr [rsp+0x28]
+       vmovdqu  ymmword ptr [rsp+0x48], ymm0
+						;; size=12 bbWeight=1 PerfScore 5.00
+G_M49529_IG04:        ; bbWeight=1, extend
        mov      rcx, 0xD1FFAB1E      ; System.Diagnostics.ActivityTagsCollection+Enumerator
+       ; gcrRegs -[rcx]
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-       lea      rdi, bword ptr [rbx+0x08]
+       mov      rbp, rax
+       ; gcrRegs +[rbp]
+       mov      gword ptr [rsp+0x48], rsi
+       lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x20]
+       lea      rsi, bword ptr [rsp+0x48]
+       ; gcrRegs -[rsi]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
        ; gcrRegs -[rax]
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
-       mov      rax, rbx
+       xor      eax, eax
+       mov      dword ptr [rbp+0x10], eax
+       mov      dword ptr [rbp+0x14], ebx
+       mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=73 bbWeight=1 PerfScore 14.08
-G_M49529_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+						;; size=60 bbWeight=1 PerfScore 10.00
+G_M49529_IG05:        ; bbWeight=1, epilog, nogc, extend
+       vzeroupper 
+       add      rsp, 104
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=12 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 98, prolog size 17, PerfScore 22.42, instruction count 27, allocated bytes for code 98 (MethodHash=aa073e86) for method System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
+; Total bytes of code 121, prolog size 30, PerfScore 32.08, instruction count 35, allocated bytes for code 121 (MethodHash=aa073e86) for method System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -68,12 +88,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+45</span> (<span style="color:red">+67.16%</span>) : 102723.dasm - System.Diagnostics.CounterSample:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,31 +9,55 @@
 ; Final local variable assignments
 ;
 ;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 tmp1         [V01,T00] (  3,  6   )  struct (64) [rsp+0x08]  do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Diagnostics.CounterSample>
+;* V01 tmp1         [V01    ] (  0,  0   )  struct (64) zero-ref    do-not-enreg[SF] ld-addr-op "NewObj constructor temp" <System.Diagnostics.CounterSample>
+;* V02 tmp2         [V02    ] (  0,  0   )    long  ->  zero-ref    "V01.[000..008)"
+;* V03 tmp3         [V03    ] (  0,  0   )    long  ->  zero-ref    "V01.[008..016)"
+;* V04 tmp4         [V04    ] (  0,  0   )    long  ->  zero-ref    "V01.[016..024)"
+;* V05 tmp5         [V05    ] (  0,  0   )    long  ->  zero-ref    "V01.[024..032)"
+;* V06 tmp6         [V06    ] (  0,  0   )     int  ->  zero-ref    "V01.[032..036)"
+;* V07 tmp7         [V07    ] (  0,  0   )    long  ->  zero-ref    "V01.[040..048)"
+;* V08 tmp8         [V08    ] (  0,  0   )    long  ->  zero-ref    "V01.[048..056)"
+;* V09 tmp9         [V09    ] (  0,  0   )    long  ->  zero-ref    "V01.[056..064)"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 0
 
 G_M6629_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M6629_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vxorps   ymm0, ymm0, ymm0
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
-       vmovdqu  ymmword ptr [rsp+0x28], ymm0
-       mov      dword ptr [rsp+0x28], 0x10000
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       vmovdqu  ymm0, ymmword ptr [rsp+0x08]
-       vmovdqu  ymmword ptr [rax], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x28]
-       vmovdqu  ymmword ptr [rax+0x20], ymm0
-						;; size=55 bbWeight=1 PerfScore 15.58
-G_M6629_IG03:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 72
+       xor      eax, eax
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      qword ptr [rcx], rax
+						;; size=15 bbWeight=1 PerfScore 1.50
+G_M6629_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+       mov      rax, 0xD1FFAB1E
+       mov      dword ptr [rax], 0x10000
+       xor      eax, eax
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=44 bbWeight=1 PerfScore 4.00
+G_M6629_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      qword ptr [rcx], rax
+						;; size=13 bbWeight=1 PerfScore 1.25
+G_M6629_IG08:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 67, prolog size 4, PerfScore 18.08, instruction count 13, allocated bytes for code 67 (MethodHash=8448e61a) for method System.Diagnostics.CounterSample:.cctor() (FullOpts)
+; Total bytes of code 112, prolog size 0, PerfScore 11.50, instruction count 19, allocated bytes for code 112 (MethodHash=8448e61a) for method System.Diagnostics.CounterSample:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -41,9 +65,8 @@ Unwind Info:
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


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-27</span> (<span style="color:green">-84.38%</span>) : 11509.dasm - FSharp.Compiler.ParseAndCheckInputs+qnameOrder@745:Invoke(FSharp.Compiler.Syntax.QualifiedNameOfFile):System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,30 +11,23 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <FSharp.Compiler.ParseAndCheckInputs+qnameOrder@745>
 ;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <FSharp.Compiler.Syntax.QualifiedNameOfFile>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  2,  2   )  struct (24) [rsp+0x00]  do-not-enreg[SF] ld-addr-op "Inline stloc first use temp" <FSharp.Compiler.Syntax.Ident>
+;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op "Inline stloc first use temp" <FSharp.Compiler.Syntax.Ident>
+;* V04 tmp2         [V04    ] (  0,  0   )     ref  ->  zero-ref    "V03.[000..008)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M12240_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M12240_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M12240_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       vmovdqu  xmm0, xmmword ptr [rdx+0x08]
-       vmovdqu  xmmword ptr [rsp], xmm0
-       mov      rax, qword ptr [rdx+0x18]
-       mov      qword ptr [rsp+0x10], rax
-						;; size=19 bbWeight=1 PerfScore 8.00
-G_M12240_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp]
+       mov      rax, gword ptr [rdx+0x08]
        ; gcrRegs +[rax]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M12240_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M12240_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 32, prolog size 4, PerfScore 10.50, instruction count 8, allocated bytes for code 32 (MethodHash=c7ccd02f) for method FSharp.Compiler.ParseAndCheckInputs+qnameOrder@745:Invoke(FSharp.Compiler.Syntax.QualifiedNameOfFile):System.String:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=c7ccd02f) for method FSharp.Compiler.ParseAndCheckInputs+qnameOrder@745:Invoke(FSharp.Compiler.Syntax.QualifiedNameOfFile):System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +35,8 @@ Unwind Info:
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
<summary><span style="color:green">-27</span> (<span style="color:green">-84.38%</span>) : 10907.dasm - FSharp.Compiler.MethodOverrides+DispatchSlotChecking+availPriorOverridesKeyed@304:Invoke(FSharp.Compiler.MethodOverrides+OverrideInfo):System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,31 +10,24 @@
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <FSharp.Compiler.MethodOverrides+DispatchSlotChecking+availPriorOverridesKeyed@304>
 ;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <FSharp.Compiler.MethodOverrides+OverrideInfo>
-;  V02 loc0         [V02,T01] (  2,  2   )  struct (24) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <FSharp.Compiler.Syntax.Ident>
+;* V02 loc0         [V02    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <FSharp.Compiler.Syntax.Ident>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    "V02.[000..008)"
 ;
-; Lcl frame size = 24
+; Lcl frame size = 0
 
 G_M13033_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 24
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M13033_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M13033_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       vmovdqu  xmm0, xmmword ptr [rdx+0x38]
-       vmovdqu  xmmword ptr [rsp], xmm0
-       mov      rax, qword ptr [rdx+0x48]
-       mov      qword ptr [rsp+0x10], rax
-						;; size=19 bbWeight=1 PerfScore 8.00
-G_M13033_IG03:        ; bbWeight=1, extend
-       mov      rax, gword ptr [rsp]
+       mov      rax, gword ptr [rdx+0x38]
        ; gcrRegs +[rax]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M13033_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 24
+						;; size=4 bbWeight=1 PerfScore 2.00
+G_M13033_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 32, prolog size 4, PerfScore 10.50, instruction count 8, allocated bytes for code 32 (MethodHash=e423cd16) for method FSharp.Compiler.MethodOverrides+DispatchSlotChecking+availPriorOverridesKeyed@304:Invoke(FSharp.Compiler.MethodOverrides+OverrideInfo):System.String:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=e423cd16) for method FSharp.Compiler.MethodOverrides+DispatchSlotChecking+availPriorOverridesKeyed@304:Invoke(FSharp.Compiler.MethodOverrides+OverrideInfo):System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +35,8 @@ Unwind Info:
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
<summary><span style="color:green">-33</span> (<span style="color:green">-67.35%</span>) : 22323.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,37 +10,29 @@
 ;
 ;  V00 this         [V00,T00] (  3,  3   )   byref  ->  rcx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
-;  V02 loc0         [V02,T01] (  2,  2   )  struct (56) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
+;* V02 loc0         [V02    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T02] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V04 tmp1         [V04,T01] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
 ;* V05 tmp2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V06 tmp3         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "V02.[004..005)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M48037_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M48037_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M48037_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       vmovdqu  ymm0, ymmword ptr [rcx+0x18]
-       vmovdqu  ymmword ptr [rsp], ymm0
-       vmovdqu  ymm0, ymmword ptr [rcx+0x30]
-       vmovdqu  ymmword ptr [rsp+0x18], ymm0
-						;; size=21 bbWeight=1 PerfScore 12.00
-G_M48037_IG03:        ; bbWeight=1, extend
-       movzx    rax, byte  ptr [rsp+0x04]
+       movzx    rax, byte  ptr [rcx+0x1C]
        dec      eax
        cmp      eax, 1
        setbe    al
        movzx    rax, al
-						;; size=16 bbWeight=1 PerfScore 2.75
-G_M48037_IG04:        ; bbWeight=1, epilog, nogc, extend
-       vzeroupper 
-       add      rsp, 56
+						;; size=15 bbWeight=1 PerfScore 3.75
+G_M48037_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 49, prolog size 4, PerfScore 17.25, instruction count 13, allocated bytes for code 49 (MethodHash=e95c445a) for method Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
+; Total bytes of code 16, prolog size 0, PerfScore 4.75, instruction count 6, allocated bytes for code 16 (MethodHash=e95c445a) for method Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -48,9 +40,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:red">+23</span> (<span style="color:red">+13.45%</span>) : 15166.dasm - System.SpanHelpers:Fill[SixLabors.ImageSharp.PixelFormats.Rgba32](byref,ulong,SixLabors.ImageSharp.PixelFormats.Rgba32) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,13 +10,13 @@
 ;
 ;  V00 arg0         [V00,T02] ( 10,  6   )   byref  ->  rcx         single-def
 ;  V01 arg1         [V01,T04] (  8,  5.50)    long  ->  rdx         single-def
-;  V02 arg2         [V02,T03] ( 10,  6   )  struct ( 8)  r8         single-def <SixLabors.ImageSharp.PixelFormats.Rgba32>
+;  V02 arg2         [V02,T03] ( 10,  6   )  struct ( 8) [rsp+0x18]  do-not-enreg[SF] single-def <SixLabors.ImageSharp.PixelFormats.Rgba32>
 ;  V03 loc0         [V03,T06] (  8,  4   )    long  ->  rax        
-;  V04 loc1         [V04,T10] (  2,  1   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <SixLabors.ImageSharp.PixelFormats.Rgba32>
-;  V05 loc2         [V05,T11] (  5,  9.50)  simd32  ->  mm0         ld-addr-op <System.Numerics.Vector`1[ubyte]>
+;* V04 loc1         [V04    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op <SixLabors.ImageSharp.PixelFormats.Rgba32>
+;  V05 loc2         [V05,T10] (  5,  9.50)  simd32  ->  mm0         ld-addr-op <System.Numerics.Vector`1[ubyte]>
 ;  V06 loc3         [V06,T01] (  5,  9.50)   byref  ->  rcx         single-def
-;  V07 loc4         [V07,T08] (  4,  2   )    long  ->   r8        
-;  V08 loc5         [V08,T05] (  2,  4.50)    long  ->  rax        
+;  V07 loc4         [V07,T08] (  4,  2   )    long  ->  rax        
+;  V08 loc5         [V08,T05] (  2,  4.50)    long  ->   r8        
 ;  V09 loc6         [V09,T00] (  7, 21   )    long  ->  r10        
 ;* V10 loc7         [V10    ] (  0,  0   )  simd16  ->  zero-ref    <System.Runtime.Intrinsics.Vector128`1[ubyte]>
 ;* V11 loc8         [V11    ] (  0,  0   )    long  ->  zero-ref   
@@ -25,81 +25,86 @@
 ;* V14 tmp2         [V14    ] (  0,  0   )  simd32  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector`1[uint]>
 ;* V15 tmp3         [V15    ] (  0,  0   )  simd32  ->  zero-ref   
 ;* V16 tmp4         [V16    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V17 cse0         [V17,T07] (  5,  2.50)    long  ->  r10         "CSE - aggressive"
-;  V18 cse1         [V18,T09] (  3,  1.50)    long  ->  r10         "CSE - moderate"
+;* V17 tmp5         [V17    ] (  0,  0   )     int  ->  zero-ref    "V04.[000..004)"
+;  V18 cse0         [V18,T07] (  5,  2.50)    long  ->   r8         "CSE - aggressive"
+;  V19 cse1         [V19,T09] (  3,  1.50)    long  ->   r8         "CSE - moderate"
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M41935_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
+       mov      qword ptr [rsp+0x18], r8
+						;; size=5 bbWeight=1 PerfScore 1.00
 G_M41935_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        ; byrRegs +[rcx]
        cmp      rdx, 8
        jb       SHORT G_M41935_IG08
 						;; size=6 bbWeight=1 PerfScore 1.25
 G_M41935_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       mov      dword ptr [rsp], r8d
-       vpbroadcastd ymm0, dword ptr [rsp]
-       lea      r8, [4*rdx]
-       mov      rax, r8
-       and      rax, -64
+       vpbroadcastd ymm0, dword ptr [rsp+0x18]
+       lea      rax, [4*rdx]
+       mov      r8, rax
+       and      r8, -64
        xor      r10d, r10d
        cmp      rdx, 16
        jb       SHORT G_M41935_IG05
-						;; size=34 bbWeight=0.50 PerfScore 3.75
+						;; size=31 bbWeight=0.50 PerfScore 3.25
 G_M41935_IG04:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        vmovups  ymmword ptr [rcx+r10], ymm0
        vmovups  ymmword ptr [rcx+r10+0x20], ymm0
        add      r10, 64
-       cmp      r10, rax
+       cmp      r10, r8
        jb       SHORT G_M41935_IG04
 						;; size=22 bbWeight=4 PerfScore 22.00
 G_M41935_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
-       test     r8b, 32
+       test     al, 32
        je       SHORT G_M41935_IG06
        vmovups  ymmword ptr [rcx+r10], ymm0
-						;; size=12 bbWeight=0.50 PerfScore 1.62
+						;; size=10 bbWeight=0.50 PerfScore 1.62
 G_M41935_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
-       vmovups  ymmword ptr [rcx+r8-0x20], ymm0
-						;; size=7 bbWeight=0.50 PerfScore 1.00
+       vmovups  ymmword ptr [rcx+rax-0x20], ymm0
+						;; size=6 bbWeight=0.50 PerfScore 1.00
 G_M41935_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 8
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.12
+						;; size=4 bbWeight=0.50 PerfScore 1.00
 G_M41935_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, gcvars, byref, isz
        xor      eax, eax
        test     dl, 4
        je       SHORT G_M41935_IG09
-       lea      r10, [4*rax]
-       mov      dword ptr [rcx+r10], r8d
-       mov      dword ptr [rcx+r10+0x04], r8d
-       mov      dword ptr [rcx+r10+0x08], r8d
-       mov      dword ptr [rcx+r10+0x0C], r8d
+       lea      r8, [4*rax]
+       mov      r10d, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+r8], r10d
+       mov      r10d, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+r8+0x04], r10d
+       mov      r10d, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+r8+0x08], r10d
+       mov      r10d, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+r8+0x0C], r10d
        add      rax, 4
-						;; size=38 bbWeight=0.50 PerfScore 3.12
+						;; size=58 bbWeight=0.50 PerfScore 5.12
 G_M41935_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        test     dl, 2
        je       SHORT G_M41935_IG10
-       lea      r10, [4*rax]
-       mov      dword ptr [rcx+r10], r8d
-       mov      dword ptr [rcx+r10+0x04], r8d
+       lea      r8, [4*rax]
+       mov      r10d, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+r8], r10d
+       mov      r10d, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+r8+0x04], r10d
        add      rax, 2
-						;; size=26 bbWeight=0.50 PerfScore 2.00
+						;; size=36 bbWeight=0.50 PerfScore 3.00
 G_M41935_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        test     dl, 1
        je       SHORT G_M41935_IG11
-       mov      dword ptr [rcx+4*rax], r8d
-						;; size=9 bbWeight=0.50 PerfScore 1.12
+       mov      edx, dword ptr [rsp+0x18]
+       mov      dword ptr [rcx+4*rax], edx
+						;; size=12 bbWeight=0.50 PerfScore 1.62
 G_M41935_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; byrRegs -[rcx]
        vzeroupper 
-       add      rsp, 8
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.12
+						;; size=4 bbWeight=0.50 PerfScore 1.00
 
-; Total bytes of code 171, prolog size 1, PerfScore 39.12, instruction count 44, allocated bytes for code 171 (MethodHash=c26d5c30) for method System.SpanHelpers:Fill[SixLabors.ImageSharp.PixelFormats.Rgba32](byref,ulong,SixLabors.ImageSharp.PixelFormats.Rgba32) (FullOpts)
+; Total bytes of code 194, prolog size 5, PerfScore 41.88, instruction count 48, allocated bytes for code 194 (MethodHash=c26d5c30) for method System.SpanHelpers:Fill[SixLabors.ImageSharp.PixelFormats.Rgba32](byref,ulong,SixLabors.ImageSharp.PixelFormats.Rgba32) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -107,9 +112,8 @@ Unwind Info:
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
<summary><span style="color:red">+25</span> (<span style="color:red">+17.86%</span>) : 30573.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:GetNewCompoundUseSiteInfo():Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,25 +9,31 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T02] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LocalRewriter>
-;  V01 RetBuf       [V01,T03] (  4,  4   )   byref  ->  rbx         single-def
+;  V01 RetBuf       [V01,T01] (  5,  5   )   byref  ->  rbx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 tmp1         [V03,T04] (  3,  5   )     ref  ->  rsi         class-hnd exact single-def "impAppendStmt" <<unknown class>>
-;  V04 tmp2         [V04,T01] (  5,  7   )  struct (32) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
+;  V04 tmp2         [V04,T03] (  3,  6   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V05 tmp3         [V05,T00] (  5,  8   )     ref  ->  rdi         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
 ;  V06 tmp4         [V06,T05] (  2,  3   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
+;  V07 tmp5         [V07,T07] (  3,  2.50)     ref  ->  rcx         "V04.[016..024)"
+;  V08 tmp6         [V08,T06] (  4,  2.50)   ubyte  ->  rbp         "V04.[025..026)"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 72
 
 G_M6343_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 72
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=20 bbWeight=1 PerfScore 5.83
+						;; size=33 bbWeight=1 PerfScore 9.08
 G_M6343_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs +[rcx]
        mov      rsi, gword ptr [rcx+0x48]
@@ -51,49 +57,57 @@ G_M6343_IG03:        ; bbWeight=0.50, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {
 G_M6343_IG04:        ; bbWeight=1, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
        mov      rax, gword ptr [rdi+0xC8]
        ; gcrRegs +[rax]
+       xor      rcx, rcx
+       ; gcrRegs +[rcx]
        vxorps   ymm0, ymm0, ymm0
-       vmovdqu  ymmword ptr [rsp+0x20], ymm0
+       vmovdqu  ymmword ptr [rsp+0x28], ymm0
        test     rsi, rsi
        jne      SHORT G_M6343_IG06
-						;; size=22 bbWeight=1 PerfScore 4.58
-G_M6343_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=24 bbWeight=1 PerfScore 4.83
+G_M6343_IG05:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax rsi rdi]
-       mov      byte  ptr [rsp+0x39], 2
+       mov      ebp, 2
        jmp      SHORT G_M6343_IG08
-						;; size=7 bbWeight=0.50 PerfScore 1.50
-G_M6343_IG06:        ; bbWeight=0.50, gcrefRegs=0041 {rax rsi}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=7 bbWeight=0.50 PerfScore 1.12
+G_M6343_IG06:        ; bbWeight=0.50, gcrefRegs=0043 {rax rcx rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs +[rax rsi]
        cmp      gword ptr [rsi+0x10], 0
        jne      SHORT G_M6343_IG07
-       mov      byte  ptr [rsp+0x39], 1
+       mov      ebp, 1
        jmp      SHORT G_M6343_IG08
-						;; size=14 bbWeight=0.50 PerfScore 3.50
+						;; size=14 bbWeight=0.50 PerfScore 3.12
 G_M6343_IG07:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0008 {rbx}, byref
-       ; gcrRegs -[rsi]
-       mov      gword ptr [rsp+0x30], rax
-						;; size=5 bbWeight=0.50 PerfScore 0.50
-G_M6343_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs -[rcx rsi]
+       xor      ebp, ebp
+       mov      rcx, rax
+       ; gcrRegs +[rcx]
+						;; size=5 bbWeight=0.50 PerfScore 0.25
+G_M6343_IG08:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
+       mov      gword ptr [rsp+0x38], rcx
        mov      rdi, rbx
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x20]
+       lea      rsi, bword ptr [rsp+0x28]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[rcx]
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
        movsq    
+       mov      byte  ptr [rbx+0x19], bpl
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=28 bbWeight=1 PerfScore 5.00
+						;; size=37 bbWeight=1 PerfScore 7.00
 G_M6343_IG09:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+       add      rsp, 72
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=9 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 140, prolog size 17, PerfScore 35.79, instruction count 39, allocated bytes for code 140 (MethodHash=5aeee738) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter:GetNewCompoundUseSiteInfo():Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
+; Total bytes of code 165, prolog size 30, PerfScore 40.79, instruction count 48, allocated bytes for code 165 (MethodHash=5aeee738) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter:GetNewCompoundUseSiteInfo():Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -101,12 +115,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+25</span> (<span style="color:red">+17.99%</span>) : 21454.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,27 +9,33 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T04] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Binder>
-;  V01 RetBuf       [V01,T02] (  4,  4   )   byref  ->  rbx         single-def
+;  V01 RetBuf       [V01,T01] (  5,  5   )   byref  ->  rbx         single-def
 ;  V02 arg1         [V02,T03] (  4,  3.50)     ref  ->  rsi         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T01] (  5,  7   )  struct (32) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
+;  V04 tmp1         [V04,T02] (  3,  6   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]>
 ;  V05 tmp2         [V05,T00] (  5,  8   )     ref  ->  rdi         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
 ;  V06 tmp3         [V06,T05] (  2,  3   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol>
+;  V07 tmp4         [V07,T07] (  3,  2.50)     ref  ->  rcx         "V04.[016..024)"
+;  V08 tmp5         [V08,T06] (  4,  2.50)   ubyte  ->  rbp         "V04.[025..026)"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 72
 
 G_M51640_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 72
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
        mov      rbx, rdx
        ; byrRegs +[rbx]
        mov      rsi, r8
        ; gcrRegs +[rsi]
-						;; size=23 bbWeight=1 PerfScore 6.08
+						;; size=36 bbWeight=1 PerfScore 9.33
 G_M51640_IG02:        ; bbWeight=1, gcrefRegs=0042 {rcx rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs +[rcx]
        mov      rdi, gword ptr [rcx+0x08]
@@ -51,49 +57,57 @@ G_M51640_IG03:        ; bbWeight=0.50, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008
 G_M51640_IG04:        ; bbWeight=1, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
        mov      rax, gword ptr [rdi+0xC8]
        ; gcrRegs +[rax]
+       xor      rcx, rcx
+       ; gcrRegs +[rcx]
        vxorps   ymm0, ymm0, ymm0
-       vmovdqu  ymmword ptr [rsp+0x20], ymm0
+       vmovdqu  ymmword ptr [rsp+0x28], ymm0
        test     rsi, rsi
        jne      SHORT G_M51640_IG06
-						;; size=22 bbWeight=1 PerfScore 4.58
-G_M51640_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=24 bbWeight=1 PerfScore 4.83
+G_M51640_IG05:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax rsi rdi]
-       mov      byte  ptr [rsp+0x39], 2
+       mov      ebp, 2
        jmp      SHORT G_M51640_IG08
-						;; size=7 bbWeight=0.50 PerfScore 1.50
-G_M51640_IG06:        ; bbWeight=0.50, gcrefRegs=0041 {rax rsi}, byrefRegs=0008 {rbx}, byref, isz
+						;; size=7 bbWeight=0.50 PerfScore 1.12
+G_M51640_IG06:        ; bbWeight=0.50, gcrefRegs=0043 {rax rcx rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs +[rax rsi]
        cmp      gword ptr [rsi+0x10], 0
        jne      SHORT G_M51640_IG07
-       mov      byte  ptr [rsp+0x39], 1
+       mov      ebp, 1
        jmp      SHORT G_M51640_IG08
-						;; size=14 bbWeight=0.50 PerfScore 3.50
+						;; size=14 bbWeight=0.50 PerfScore 3.12
 G_M51640_IG07:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0008 {rbx}, byref
-       ; gcrRegs -[rsi]
-       mov      gword ptr [rsp+0x30], rax
-						;; size=5 bbWeight=0.50 PerfScore 0.50
-G_M51640_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; gcrRegs -[rcx rsi]
+       xor      ebp, ebp
+       mov      rcx, rax
+       ; gcrRegs +[rcx]
+						;; size=5 bbWeight=0.50 PerfScore 0.25
+G_M51640_IG08:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
+       mov      gword ptr [rsp+0x38], rcx
        mov      rdi, rbx
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x20]
+       lea      rsi, bword ptr [rsp+0x28]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[rcx]
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
        movsq    
+       mov      byte  ptr [rbx+0x19], bpl
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=28 bbWeight=1 PerfScore 5.00
+						;; size=37 bbWeight=1 PerfScore 7.00
 G_M51640_IG09:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+       add      rsp, 72
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=9 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 139, prolog size 17, PerfScore 34.04, instruction count 39, allocated bytes for code 139 (MethodHash=2afd3647) for method Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
+; Total bytes of code 164, prolog size 30, PerfScore 39.04, instruction count 48, allocated bytes for code 164 (MethodHash=2afd3647) for method Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -101,12 +115,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-44</span> (<span style="color:green">-91.67%</span>) : 9652.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,34 +8,23 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (56) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <Internal.Metadata.NativeFormat.GenericParameter>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] ld-addr-op <Internal.Metadata.NativeFormat.GenericParameter>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "V01.[008..012)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M10573_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M10573_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M10573_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movups   xmm0, xmmword ptr [rcx+0x38]
-       movups   xmmword ptr [rsp], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x48]
-       movups   xmmword ptr [rsp+0x10], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x58]
-       movups   xmmword ptr [rsp+0x20], xmm0
-       mov      rax, qword ptr [rcx+0x68]
-       mov      qword ptr [rsp+0x30], rax
-						;; size=35 bbWeight=1 PerfScore 18.00
-G_M10573_IG03:        ; bbWeight=1, extend
-       mov      eax, dword ptr [rsp+0x08]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M10573_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+       mov      eax, dword ptr [rcx+0x40]
+						;; size=3 bbWeight=1 PerfScore 2.00
+G_M10573_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 48, prolog size 4, PerfScore 20.50, instruction count 12, allocated bytes for code 48 (MethodHash=63dcd6b2) for method System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=63dcd6b2) for method System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -43,9 +32,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:green">-44</span> (<span style="color:green">-91.67%</span>) : 3928.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,34 +9,23 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (56) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <Internal.Metadata.NativeFormat.GenericParameter>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] ld-addr-op <Internal.Metadata.NativeFormat.GenericParameter>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "V01.[008..012)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M10573_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M10573_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M10573_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movups   xmm0, xmmword ptr [rcx+0x38]
-       movups   xmmword ptr [rsp], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x48]
-       movups   xmmword ptr [rsp+0x10], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x58]
-       movups   xmmword ptr [rsp+0x20], xmm0
-       mov      rax, qword ptr [rcx+0x68]
-       mov      qword ptr [rsp+0x30], rax
-						;; size=35 bbWeight=1 PerfScore 18.00
-G_M10573_IG03:        ; bbWeight=1, extend
-       mov      eax, dword ptr [rsp+0x08]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M10573_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+       mov      eax, dword ptr [rcx+0x40]
+						;; size=3 bbWeight=1 PerfScore 2.00
+G_M10573_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 48, prolog size 4, PerfScore 20.50, instruction count 12, allocated bytes for code 48 (MethodHash=63dcd6b2) for method System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=63dcd6b2) for method System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -44,9 +33,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:green">-36</span> (<span style="color:green">-90.00%</span>) : 9926.dasm - System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_Attributes():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,32 +8,23 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd exact single-def <System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo>
-;  V01 loc0         [V01,T01] (  2,  2   )  struct (48) [rsp+0x08]  do-not-enreg[SF] ld-addr-op <Internal.Metadata.NativeFormat.Field>
+;* V01 loc0         [V01    ] (  0,  0   )  struct (48) zero-ref    do-not-enreg[SF] ld-addr-op <Internal.Metadata.NativeFormat.Field>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "V01.[008..012)"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 0
 
 G_M41645_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 56
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M41645_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, nogc
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M41645_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       movups   xmm0, xmmword ptr [rcx+0x48]
-       movups   xmmword ptr [rsp+0x08], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x58]
-       movups   xmmword ptr [rsp+0x18], xmm0
-       movups   xmm0, xmmword ptr [rcx+0x68]
-       movups   xmmword ptr [rsp+0x28], xmm0
-						;; size=27 bbWeight=1 PerfScore 15.00
-G_M41645_IG03:        ; bbWeight=1, extend
-       mov      eax, dword ptr [rsp+0x10]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M41645_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
+       mov      eax, dword ptr [rcx+0x50]
+						;; size=3 bbWeight=1 PerfScore 2.00
+G_M41645_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 40, prolog size 4, PerfScore 17.50, instruction count 10, allocated bytes for code 40 (MethodHash=02d05d52) for method System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_Attributes():int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=02d05d52) for method System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_Attributes():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -41,9 +32,8 @@ Unwind Info:
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
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:red">+11</span> (<span style="color:red">+7.28%</span>) : 21879.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,25 +10,30 @@
 ;  V00 this         [V00,T00] (  8,  6   )     ref  ->  rbx         this class-hnd exact single-def <System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]>
 ;* V01 loc0         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T02] (  3,  3   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
-;  V04 tmp2         [V04,T01] (  5,  5   )  struct (40) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
+;  V03 tmp1         [V03,T01] (  6,  6   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
+;  V04 tmp2         [V04,T02] (  3,  3   )  struct (40) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
+;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    single-def "V04.[000..008)"
+;  V06 tmp4         [V06,T03] (  2,  1   )     int  ->  r14         "V04.[008..012)"
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V04.[012..016)"
+;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V04.[016..020)"
 ;
-; Lcl frame size = 88
+; Lcl frame size = 80
 
 G_M47825_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 88
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 80
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       mov      qword ptr [rsp+0x50], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x40], rax
+       mov      qword ptr [rsp+0x48], rcx
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=33 bbWeight=1 PerfScore 9.08
+						;; size=35 bbWeight=1 PerfScore 10.08
 G_M47825_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      ecx, dword ptr [rbx+0x38]
        sub      ecx, dword ptr [rbx+0x40]
@@ -43,33 +48,36 @@ G_M47825_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        ; gcr arg pop 0
        mov      rbp, rax
        ; gcrRegs +[rbp]
-       mov      gword ptr [rsp+0x28], rbx
-       mov      eax, dword ptr [rbx+0x44]
-       ; gcrRegs -[rax]
-       mov      dword ptr [rsp+0x30], eax
-       mov      dword ptr [rsp+0x38], 2
+       mov      r14d, dword ptr [rbx+0x44]
        vxorps   xmm0, xmm0, xmm0
-       vmovdqu  xmmword ptr [rsp+0x40], xmm0
+       vmovdqu  xmmword ptr [rsp+0x38], xmm0
+       mov      gword ptr [rsp+0x20], rbx
        lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x28]
+       lea      rsi, bword ptr [rsp+0x20]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[rax]
        movsq    
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
+       mov      dword ptr [rbp+0x10], r14d
+       xor      eax, eax
+       mov      dword ptr [rbp+0x14], eax
+       mov      dword ptr [rbp+0x18], 2
        mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=80 bbWeight=0.50 PerfScore 9.92
+						;; size=85 bbWeight=0.50 PerfScore 10.54
 G_M47825_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 88
+       add      rsp, 80
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M47825_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax rbp]
        ; byrRegs -[rsi rdi]
@@ -82,15 +90,16 @@ G_M47825_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; byrRegs -[rax]
 						;; size=12 bbWeight=0.50 PerfScore 2.50
 G_M47825_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 88
+       add      rsp, 80
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 
-; Total bytes of code 151, prolog size 30, PerfScore 30.75, instruction count 48, allocated bytes for code 151 (MethodHash=5de7452e) for method System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
+; Total bytes of code 162, prolog size 32, PerfScore 32.88, instruction count 53, allocated bytes for code 162 (MethodHash=5de7452e) for method System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -98,13 +107,14 @@ Unwind Info:
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
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 10 * 8 + 8 = 88 = 0x58
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 9 * 8 + 8 = 80 = 0x50
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>

<details>
<summary><span style="color:red">+11</span> (<span style="color:red">+7.28%</span>) : 16536.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,25 +10,30 @@
 ;  V00 this         [V00,T00] (  8,  6   )     ref  ->  rbx         this class-hnd exact single-def <System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]>
 ;* V01 loc0         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T02] (  3,  3   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
-;  V04 tmp2         [V04,T01] (  5,  5   )  struct (40) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
+;  V03 tmp1         [V03,T01] (  6,  6   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
+;  V04 tmp2         [V04,T02] (  3,  3   )  struct (40) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.__Canon,System.__Canon]>
+;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    single-def "V04.[000..008)"
+;  V06 tmp4         [V06,T03] (  2,  1   )     int  ->  r14         "V04.[008..012)"
+;* V07 tmp5         [V07    ] (  0,  0   )     int  ->  zero-ref    "V04.[012..016)"
+;* V08 tmp6         [V08    ] (  0,  0   )     int  ->  zero-ref    "V04.[016..020)"
 ;
-; Lcl frame size = 88
+; Lcl frame size = 80
 
 G_M47825_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 88
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 80
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       mov      qword ptr [rsp+0x50], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       xor      eax, eax
+       mov      qword ptr [rsp+0x40], rax
+       mov      qword ptr [rsp+0x48], rcx
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=33 bbWeight=1 PerfScore 9.08
+						;; size=35 bbWeight=1 PerfScore 10.08
 G_M47825_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      ecx, dword ptr [rbx+0x38]
        sub      ecx, dword ptr [rbx+0x40]
@@ -43,33 +48,36 @@ G_M47825_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        ; gcr arg pop 0
        mov      rbp, rax
        ; gcrRegs +[rbp]
-       mov      gword ptr [rsp+0x28], rbx
-       mov      eax, dword ptr [rbx+0x44]
-       ; gcrRegs -[rax]
-       mov      dword ptr [rsp+0x30], eax
-       mov      dword ptr [rsp+0x38], 2
+       mov      r14d, dword ptr [rbx+0x44]
        vxorps   xmm0, xmm0, xmm0
-       vmovdqu  xmmword ptr [rsp+0x40], xmm0
+       vmovdqu  xmmword ptr [rsp+0x38], xmm0
+       mov      gword ptr [rsp+0x20], rbx
        lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x28]
+       lea      rsi, bword ptr [rsp+0x20]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
+       ; gcrRegs -[rax]
        movsq    
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
+       mov      dword ptr [rbp+0x10], r14d
+       xor      eax, eax
+       mov      dword ptr [rbp+0x14], eax
+       mov      dword ptr [rbp+0x18], 2
        mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=80 bbWeight=0.50 PerfScore 9.92
+						;; size=85 bbWeight=0.50 PerfScore 10.54
 G_M47825_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 88
+       add      rsp, 80
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M47825_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax rbp]
        ; byrRegs -[rsi rdi]
@@ -82,15 +90,16 @@ G_M47825_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; byrRegs -[rax]
 						;; size=12 bbWeight=0.50 PerfScore 2.50
 G_M47825_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 88
+       add      rsp, 80
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 
-; Total bytes of code 151, prolog size 30, PerfScore 30.75, instruction count 48, allocated bytes for code 151 (MethodHash=5de7452e) for method System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
+; Total bytes of code 162, prolog size 32, PerfScore 32.88, instruction count 53, allocated bytes for code 162 (MethodHash=5de7452e) for method System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -98,13 +107,14 @@ Unwind Info:
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
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 10 * 8 + 8 = 88 = 0x58
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 9 * 8 + 8 = 80 = 0x50
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>

<details>
<summary><span style="color:red">+8</span> (<span style="color:red">+8.70%</span>) : 11582.dasm - System.Collections.Generic.LowLevelListWithIList`1[System.Reflection.CustomAttributeTypedArgument]:System.Collections.IEnumerable.GetEnumerator():System.Collections.IEnumerator:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,57 +7,65 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Collections.Generic.LowLevelListWithIList`1[System.Reflection.CustomAttributeTypedArgument]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rsi         this class-hnd exact single-def <System.Collections.Generic.LowLevelListWithIList`1[System.Reflection.CustomAttributeTypedArgument]>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  4,  8   )  struct (32) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.LowLevelListWithIList`1+Enumerator[System.Reflection.CustomAttributeTypedArgument]>
-;  V03 tmp2         [V03,T02] (  3,  6   )     ref  ->  rbx         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.LowLevelListWithIList`1+Enumerator[System.Reflection.CustomAttributeTypedArgument]>
+;  V02 tmp1         [V02,T02] (  2,  4   )  struct (32) [rsp+0x28]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.LowLevelListWithIList`1+Enumerator[System.Reflection.CustomAttributeTypedArgument]>
+;  V03 tmp2         [V03,T00] (  5, 10   )     ref  ->  rbp         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.LowLevelListWithIList`1+Enumerator[System.Reflection.CustomAttributeTypedArgument]>
+;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    single-def "V02.[000..008)"
+;* V05 tmp4         [V05    ] (  0,  0   )     int  ->  zero-ref    "V02.[008..012)"
+;  V06 tmp5         [V06,T03] (  2,  2   )     int  ->  rbx         "V02.[012..016)"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 72
 
 G_M10706_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 64
+       sub      rsp, 72
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        xorps    xmm4, xmm4
-       movaps   xmmword ptr [rsp+0x20], xmm4
        movaps   xmmword ptr [rsp+0x30], xmm4
-						;; size=20 bbWeight=1 PerfScore 7.58
-G_M10706_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs +[rcx]
-       mov      gword ptr [rsp+0x20], rcx
-       mov      ecx, dword ptr [rcx+0x14]
-       ; gcrRegs -[rcx]
-       mov      dword ptr [rsp+0x2C], ecx
-       xorps    xmm0, xmm0
-       movups   xmmword ptr [rsp+0x30], xmm0
+       mov      qword ptr [rsp+0x40], rax
+       mov      rsi, rcx
+       ; gcrRegs +[rsi]
+						;; size=31 bbWeight=1 PerfScore 9.08
+G_M10706_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
+       mov      ebx, dword ptr [rsi+0x14]
        lea      rcx, [(reloc)]      ; System.Collections.Generic.LowLevelListWithIList`1+Enumerator[System.Reflection.CustomAttributeTypedArgument]
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-       lea      rdi, bword ptr [rbx+0x08]
+       mov      rbp, rax
+       ; gcrRegs +[rbp]
+       mov      gword ptr [rsp+0x28], rsi
+       lea      rdi, bword ptr [rbp+0x08]
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x20]
+       lea      rsi, bword ptr [rsp+0x28]
+       ; gcrRegs -[rsi]
        ; byrRegs +[rsi]
        call     CORINFO_HELP_ASSIGN_BYREF
        ; gcrRegs -[rax]
        movsq    
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
-       mov      rax, rbx
+       xor      eax, eax
+       mov      dword ptr [rbp+0x10], eax
+       mov      dword ptr [rbp+0x14], ebx
+       mov      rax, rbp
        ; gcrRegs +[rax]
-						;; size=64 bbWeight=1 PerfScore 12.33
+						;; size=60 bbWeight=1 PerfScore 12.25
 G_M10706_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 64
+       add      rsp, 72
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=9 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 92, prolog size 20, PerfScore 22.67, instruction count 27, allocated bytes for code 92 (MethodHash=ba44d62d) for method System.Collections.Generic.LowLevelListWithIList`1[System.Reflection.CustomAttributeTypedArgument]:System.Collections.IEnumerable.GetEnumerator():System.Collections.IEnumerator:this (FullOpts)
+; Total bytes of code 100, prolog size 28, PerfScore 24.58, instruction count 32, allocated bytes for code 100 (MethodHash=ba44d62d) for method System.Collections.Generic.LowLevelListWithIList`1[System.Reflection.CustomAttributeTypedArgument]:System.Collections.IEnumerable.GetEnumerator():System.Collections.IEnumerator:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -65,12 +73,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

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
|benchmarks.run.windows.x64.checked.mch|797|<span style="color:green">552</span>|<span style="color:red">200</span>|<span style="color:blue">45</span>|<span style="color:green">-30,512</span>|<span style="color:red">+6,416</span>|<span style="color:green">-0.1688%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|1,922|<span style="color:green">998</span>|<span style="color:red">918</span>|<span style="color:blue">6</span>|<span style="color:green">-37,389</span>|<span style="color:red">+32,048</span>|<span style="color:green">-0.2084%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|293|<span style="color:green">182</span>|<span style="color:red">97</span>|<span style="color:blue">14</span>|<span style="color:green">-7,716</span>|<span style="color:red">+2,912</span>|<span style="color:green">-0.1885%</span>|
|coreclr_tests.run.windows.x64.checked.mch|3,921|<span style="color:green">3,371</span>|<span style="color:red">484</span>|<span style="color:blue">66</span>|<span style="color:green">-338,035</span>|<span style="color:red">+30,345</span>|<span style="color:green">-0.1295%</span>|
|libraries.crossgen2.windows.x64.checked.mch|2,167|<span style="color:green">1,386</span>|<span style="color:red">665</span>|<span style="color:blue">116</span>|<span style="color:green">-68,364</span>|<span style="color:red">+17,033</span>|<span style="color:green">-0.0848%</span>|
|libraries.pmi.windows.x64.checked.mch|7,172|<span style="color:green">5,389</span>|<span style="color:red">1,445</span>|<span style="color:blue">338</span>|<span style="color:green">-275,579</span>|<span style="color:red">+61,236</span>|<span style="color:green">-0.1985%</span>|
|libraries_tests.run.windows.x64.Release.mch|8,849|<span style="color:green">6,497</span>|<span style="color:red">2,126</span>|<span style="color:blue">226</span>|<span style="color:green">-386,786</span>|<span style="color:red">+120,857</span>|<span style="color:green">-0.2663%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|5,584|<span style="color:green">4,154</span>|<span style="color:red">1,162</span>|<span style="color:blue">268</span>|<span style="color:green">-259,333</span>|<span style="color:red">+63,063</span>|<span style="color:green">-0.1513%</span>|
|realworld.run.windows.x64.checked.mch|1,441|<span style="color:green">1,064</span>|<span style="color:red">266</span>|<span style="color:blue">111</span>|<span style="color:green">-82,095</span>|<span style="color:red">+11,994</span>|<span style="color:green">-0.2392%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|303|<span style="color:green">259</span>|<span style="color:red">37</span>|<span style="color:blue">7</span>|<span style="color:green">-12,330</span>|<span style="color:red">+741</span>|<span style="color:green">-0.3394%</span>|
||32,449|<span style="color:green">23,852</span>|<span style="color:red">7,400</span>|<span style="color:blue">1,197</span>|<span style="color:green">-1,498,139</span>|<span style="color:red">+346,645</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,848|4|35,844|251 (0.70%)|181 (0.50%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,780|49,607|52,173|80 (0.08%)|29 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|54,999|37,307|17,692|43 (0.08%)|32 (0.06%)|
|coreclr_tests.run.windows.x64.checked.mch|581,433|347,882|233,551|2,658 (0.46%)|2,560 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,213|15|275,198|557 (0.20%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|312,657|6|312,651|1,642 (0.52%)|1,187 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|697,080|498,513|198,567|3,093 (0.44%)|2,657 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|320,247|21,946|298,301|648 (0.20%)|0 (0.00%)|
|realworld.run.windows.x64.checked.mch|36,433|3|36,430|470 (1.27%)|213 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,472|11|32,461|106 (0.33%)|41 (0.13%)|
||2,448,162|955,294|1,492,868|9,548 (0.39%)|6,965 (0.28%)|


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

Total bytes of base: 11351603 (overridden on cmd)
Total bytes of diff: 11327507 (overridden on cmd)
Total bytes of delta: -24096 (-0.21 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         546 : 25463.dasm (13.41% of base)
         468 : 8833.dasm (6.15% of base)
         242 : 14050.dasm (24.47% of base)
         234 : 11794.dasm (25.41% of base)
         231 : 15317.dasm (26.04% of base)
         188 : 28177.dasm (22.49% of base)
         165 : 21629.dasm (17.70% of base)
         152 : 6260.dasm (7.24% of base)
         152 : 14551.dasm (7.24% of base)
         128 : 14476.dasm (6.50% of base)
         120 : 6102.dasm (6.01% of base)
         118 : 14100.dasm (5.78% of base)
         107 : 7594.dasm (9.68% of base)
         106 : 29495.dasm (48.62% of base)
          97 : 9594.dasm (5.22% of base)
          84 : 26939.dasm (19.22% of base)
          83 : 24011.dasm (0.98% of base)
          79 : 27480.dasm (5.00% of base)
          78 : 27393.dasm (1.63% of base)
          69 : 14549.dasm (8.58% of base)

Top file improvements (bytes):
        -793 : 15042.dasm (-6.62% of base)
        -787 : 5146.dasm (-6.55% of base)
        -546 : 26918.dasm (-8.43% of base)
        -362 : 35425.dasm (-13.59% of base)
        -353 : 25645.dasm (-2.13% of base)
        -296 : 17160.dasm (-6.10% of base)
        -277 : 8039.dasm (-8.89% of base)
        -277 : 24402.dasm (-9.44% of base)
        -271 : 29032.dasm (-2.14% of base)
        -270 : 1468.dasm (-5.58% of base)
        -259 : 28932.dasm (-7.48% of base)
        -253 : 9115.dasm (-15.86% of base)
        -250 : 25682.dasm (-10.53% of base)
        -249 : 17441.dasm (-6.37% of base)
        -249 : 6834.dasm (-6.37% of base)
        -246 : 26997.dasm (-5.81% of base)
        -236 : 17112.dasm (-10.51% of base)
        -235 : 5027.dasm (-23.64% of base)
        -235 : 29953.dasm (-17.67% of base)
        -226 : 1395.dasm (-10.11% of base)

82 total files with Code Size differences (49 improved, 33 regressed), 20 unchanged.

Top method regressions (bytes):
         546 (13.41% of base) : 25463.dasm - Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder:VisitTypeDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration:this (FullOpts)
         468 ( 6.15% of base) : 8833.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:ConvertToSymbolicRegexNode(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.Text.RegularExpressions.Symbolic.BDD]:this (FullOpts)
         242 (24.47% of base) : 14050.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon]:TryGetValue(System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,byref):ubyte:this (FullOpts)
         234 (25.41% of base) : 11794.dasm - System.Buffers.Binary.Tests.BinaryReadAndWriteTests:ReadStructFieldByFieldBE():System.Buffers.Binary.Tests.BinaryReadAndWriteTests+TestStructExplicit:this (FullOpts)
         231 (26.04% of base) : 15317.dasm - System.Buffers.Binary.Tests.BinaryReadAndWriteTests:ReadStructFieldByFieldLE():System.Buffers.Binary.Tests.BinaryReadAndWriteTests+TestStructExplicit:this (FullOpts)
         188 (22.49% of base) : 28177.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeader(System.Reflection.Metadata.BlobBuilder,System.Reflection.PortableExecutable.PEBuilder+SerializedSection) (FullOpts)
         165 (17.70% of base) : 21629.dasm - System.Buffers.SequenceReader`1[int]:TryReadToInternal(byref,int,ubyte,int):ubyte:this (FullOpts)
         152 ( 7.24% of base) : 6260.dasm - System.Net.Security.SafeDeleteContext:AcceptSecurityContext(byref,byref,int,int,System.Net.Security.InputSecurityBuffers,byref,byref):int (FullOpts)
         152 ( 7.24% of base) : 14551.dasm - System.Net.Security.SafeDeleteContext:AcceptSecurityContext(byref,byref,int,int,System.Net.Security.InputSecurityBuffers,byref,byref):int (FullOpts)
         128 ( 6.50% of base) : 14476.dasm - System.Net.Security.SafeDeleteContext:InitializeSecurityContext(byref,byref,System.String,int,int,System.Net.Security.InputSecurityBuffers,byref,byref):int (FullOpts)
         120 ( 6.01% of base) : 6102.dasm - System.Net.Security.SafeDeleteContext:InitializeSecurityContext(byref,byref,System.String,int,int,System.Net.Security.InputSecurityBuffers,byref,byref):int (FullOpts)
         118 ( 5.78% of base) : 14100.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon]:TryAddInternal(System.Collections.Concurrent.ConcurrentDictionary`2+Tables[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon],System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.Nullable`1[int],System.__Canon,ubyte,ubyte,byref):ubyte:this (FullOpts)
         107 ( 9.68% of base) : 7594.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateEvents(System.RuntimeType+RuntimeTypeCache+Filter,System.RuntimeType,System.Collections.Generic.Dictionary`2[System.String,System.Reflection.RuntimeEventInfo],byref):this (FullOpts)
         106 (48.62% of base) : 29495.dasm - System.Runtime.InteropServices.Marshal:.cctor() (FullOpts)
          97 ( 5.22% of base) : 9594.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:ImmutableSortedDictionaryStringStringSerializeHandler(System.Text.Json.Utf8JsonWriter,System.Collections.Immutable.ImmutableSortedDictionary`2[System.String,System.String]):this (FullOpts)
          84 (19.22% of base) : 26939.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BinaryOperatorEasyOut(int,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult):this (FullOpts)
          83 ( 0.98% of base) : 24011.dasm - System.Diagnostics.Tracing.ManifestBuilder:CreateManifestString():System.String:this (FullOpts)
          79 ( 5.00% of base) : 27480.dasm - Microsoft.CodeAnalysis.CSharp.SourceDocumentationCommentUtils:GetDocumentationCommentTriviaFromSyntaxNode(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,Microsoft.CodeAnalysis.DiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax] (FullOpts)
          78 ( 1.63% of base) : 27393.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:InterceptCallAndAdjustArguments(byref,byref,byref,byref,ubyte,Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax):this (FullOpts)
          69 ( 8.58% of base) : 14549.dasm - System.Net.Security.SslStreamPal:AcceptSecurityContext(byref,byref,System.ReadOnlySpan`1[ubyte],System.Net.Security.SslAuthenticationOptions):System.Net.Security.ProtocolToken (FullOpts)

Top method improvements (bytes):
        -793 (-6.62% of base) : 15042.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
        -787 (-6.55% of base) : 5146.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
        -546 (-8.43% of base) : 26918.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckValueKind(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,ushort,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
        -362 (-13.59% of base) : 35425.dasm - System.Enum:GetName(System.RuntimeType,ulong):System.String (FullOpts)
        -353 (-2.13% of base) : 25645.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
        -296 (-6.10% of base) : 17160.dasm - System.Text.RegularExpressions.RegexCompiler:<EmitTryFindNextPossibleStartingPosition>g__EmitFixedSet_LeftToRight|157_3(byref):this (FullOpts)
        -277 (-8.89% of base) : 8039.dasm - System.Enum:GetValuesAsUnderlyingType(System.RuntimeType):System.Array (FullOpts)
        -277 (-9.44% of base) : 24402.dasm - System.Enum:GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType):System.Array (FullOpts)
        -271 (-2.14% of base) : 29032.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte,ubyte) (FullOpts)
        -270 (-5.58% of base) : 1468.dasm - System.Text.RegularExpressions.RegexCompiler:<EmitTryFindNextPossibleStartingPosition>g__EmitFixedSet_LeftToRight|157_3(byref):this (FullOpts)
        -259 (-7.48% of base) : 28932.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel:CreateMemberModel(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):Microsoft.CodeAnalysis.CSharp.MemberSemanticModel:this (FullOpts)
        -253 (-15.86% of base) : 9115.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext:LargeStructWithPropertiesSerializeHandler(System.Text.Json.Utf8JsonWriter,MicroBenchmarks.Serializers.LargeStructWithProperties):this (FullOpts)
        -250 (-10.53% of base) : 25682.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:BuildReferencedAssembliesAndModulesMaps(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.MetadataReference],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]],int,int,System.Collections.Generic.IReadOnlyDictionary`2[System.__Canon,System.__Canon],ubyte,byref,byref,byref,byref) (FullOpts)
        -249 (-6.37% of base) : 17441.dasm - System.Text.Json.JsonDocument:TryParseValue(byref,byref,ubyte,ubyte):ubyte (FullOpts)
        -249 (-6.37% of base) : 6834.dasm - System.Text.Json.JsonDocument:TryParseValue(byref,byref,ubyte,ubyte):ubyte (FullOpts)
        -246 (-5.81% of base) : 26997.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<CreateConversion>g__checkConstraintLanguageVersionAndRuntimeSupportForConversion|210_2(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Conversion,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (FullOpts)
        -236 (-10.51% of base) : 17112.dasm - System.Text.RegularExpressions.RegexPrefixAnalyzer:FindLiteralFollowingLeadingLoop(System.Text.RegularExpressions.RegexNode):System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]] (FullOpts)
        -235 (-17.67% of base) : 29953.dasm - System.DateTimeParse:ParseTimeZone(byref,byref):ubyte (FullOpts)
        -235 (-23.64% of base) : 5027.dasm - System.Diagnostics.StackTraceSymbols:GetSourceLineInfo(System.Reflection.Assembly,System.String,long,int,ubyte,long,int,int,int,byref,byref,byref):this (FullOpts)
        -226 (-10.11% of base) : 1395.dasm - System.Text.RegularExpressions.RegexPrefixAnalyzer:FindLiteralFollowingLeadingLoop(System.Text.RegularExpressions.RegexNode):System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]] (FullOpts)

Top method regressions (percentages):
         106 (48.62% of base) : 29495.dasm - System.Runtime.InteropServices.Marshal:.cctor() (FullOpts)
         231 (26.04% of base) : 15317.dasm - System.Buffers.Binary.Tests.BinaryReadAndWriteTests:ReadStructFieldByFieldLE():System.Buffers.Binary.Tests.BinaryReadAndWriteTests+TestStructExplicit:this (FullOpts)
         234 (25.41% of base) : 11794.dasm - System.Buffers.Binary.Tests.BinaryReadAndWriteTests:ReadStructFieldByFieldBE():System.Buffers.Binary.Tests.BinaryReadAndWriteTests+TestStructExplicit:this (FullOpts)
         242 (24.47% of base) : 14050.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon]:TryGetValue(System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,byref):ubyte:this (FullOpts)
          23 (23.47% of base) : 9799.dasm - System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
          23 (23.47% of base) : 15476.dasm - System.Diagnostics.ActivityTagsCollection:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]]:this (FullOpts)
          18 (22.78% of base) : 31002.dasm - System.Numerics.Tests.Perf_Matrix3x2:GetDeterminantBenchmark():float:this (FullOpts)
         188 (22.49% of base) : 28177.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeader(System.Reflection.Metadata.BlobBuilder,System.Reflection.PortableExecutable.PEBuilder+SerializedSection) (FullOpts)
          16 (22.22% of base) : 32255.dasm - System.Numerics.Tests.Perf_Matrix3x2:IsIdentityBenchmark():ubyte:this (FullOpts)
          84 (19.22% of base) : 26939.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BinaryOperatorEasyOut(int,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult):this (FullOpts)
          25 (17.99% of base) : 26937.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
         165 (17.70% of base) : 21629.dasm - System.Buffers.SequenceReader`1[int]:TryReadToInternal(byref,int,ubyte,int):ubyte:this (FullOpts)
          16 (17.20% of base) : 35176.dasm - System.Numerics.Tests.Perf_Matrix4x4:IsIdentityBenchmark():ubyte:this (FullOpts)
          18 (15.52% of base) : 6783.dasm - System.Text.Json.Nodes.JsonObject:GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Text.Json.Nodes.JsonNode]]:this (FullOpts)
          50 (15.15% of base) : 29954.dasm - System.__DTString:GetSubString():System.DTSubString:this (FullOpts)
          13 (14.44% of base) : 15900.dasm - System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          13 (14.44% of base) : 2378.dasm - System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          13 (13.83% of base) : 30681.dasm - System.Collections.Generic.PriorityQueue`2+UnorderedItemsCollection[System.__Canon,System.__Canon]:GetEnumerator():System.Collections.Generic.PriorityQueue`2+UnorderedItemsCollection+Enumerator[System.__Canon,System.__Canon]:this (FullOpts)
          38 (13.48% of base) : 31867.dasm - System.Numerics.Tests.Perf_Matrix3x2:MultiplyByMatrixBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          38 (13.48% of base) : 35605.dasm - System.Numerics.Tests.Perf_Matrix3x2:MultiplyByMatrixOperatorBenchmark():System.Numerics.Matrix3x2:this (FullOpts)

Top method improvements (percentages):
         -35 (-60.34% of base) : 32016.dasm - System.Tests.Perf_Guid:EqualsOperator():ubyte:this (FullOpts)
         -35 (-60.34% of base) : 32621.dasm - System.Tests.Perf_Guid:NotEqualsOperator():ubyte:this (FullOpts)
         -64 (-54.70% of base) : 24177.dasm - Struct.SpanWrapper:SumSpanWrapper(Struct.SpanWrapper`1[int]):int:this (FullOpts)
         -26 (-53.06% of base) : 24835.dasm - System.Tests.Perf_Guid:EqualsNotSame():ubyte:this (FullOpts)
         -26 (-53.06% of base) : 9180.dasm - System.Tests.Perf_Guid:EqualsSame():ubyte:this (FullOpts)
         -44 (-51.16% of base) : 24586.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateFromScalars():System.Numerics.Matrix3x2:this (FullOpts)
         -38 (-50.67% of base) : 15590.dasm - System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]]):this (FullOpts)
         -38 (-50.67% of base) : 3091.dasm - System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]]):this (FullOpts)
         -56 (-50.00% of base) : 28174.dasm - System.Reflection.PortableExecutable.PEBuilder:SumRawDataSizes(System.Collections.Immutable.ImmutableArray`1[System.Reflection.PortableExecutable.PEBuilder+SerializedSection],uint):int (FullOpts)
         -82 (-49.10% of base) : 22919.dasm - Struct.FilteredSpanEnumerator:Sum():int:this (FullOpts)
         -42 (-45.16% of base) : 9123.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_10(System.Object):int:this (FullOpts)
         -42 (-45.16% of base) : 9124.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_12(System.Object):int:this (FullOpts)
         -42 (-45.16% of base) : 9125.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_14(System.Object):int:this (FullOpts)
         -42 (-45.16% of base) : 9126.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_16(System.Object):int:this (FullOpts)
         -42 (-45.16% of base) : 9127.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_18(System.Object):int:this (FullOpts)
         -42 (-44.68% of base) : 9118.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_0(System.Object):System.String:this (FullOpts)
         -42 (-44.68% of base) : 9119.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_2(System.Object):System.String:this (FullOpts)
         -42 (-44.68% of base) : 9120.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_4(System.Object):System.String:this (FullOpts)
         -42 (-44.68% of base) : 9121.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_6(System.Object):System.String:this (FullOpts)
         -42 (-44.68% of base) : 9122.dasm - MicroBenchmarks.Serializers.SystemTextJsonSourceGeneratedContext+<>c:<LargeStructWithPropertiesPropInit>b__60_8(System.Object):System.String:this (FullOpts)

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

Total bytes of base: 35236667 (overridden on cmd)
Total bytes of diff: 35231326 (overridden on cmd)
Total bytes of delta: -5341 (-0.02 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         363 : 86950.dasm (18.45% of base)
         351 : 91966.dasm (17.73% of base)
         322 : 86952.dasm (23.69% of base)
         317 : 97873.dasm (15.96% of base)
         306 : 97875.dasm (22.25% of base)
         306 : 97940.dasm (18.01% of base)
         290 : 97916.dasm (13.55% of base)
         284 : 86869.dasm (13.31% of base)
         279 : 97815.dasm (5.19% of base)
         279 : 95224.dasm (5.19% of base)
         271 : 52401.dasm (12.68% of base)
         266 : 27596.dasm (12.41% of base)
         265 : 83676.dasm (11.10% of base)
         258 : 86903.dasm (12.18% of base)
         243 : 13448.dasm (2.58% of base)
         235 : 39344.dasm (4.79% of base)
         231 : 97919.dasm (10.80% of base)
         229 : 52389.dasm (10.73% of base)
         218 : 27602.dasm (10.19% of base)
         211 : 97943.dasm (15.83% of base)

Top file improvements (bytes):
        -608 : 68568.dasm (-13.68% of base)
        -592 : 38354.dasm (-12.24% of base)
        -591 : 39523.dasm (-11.97% of base)
        -449 : 75910.dasm (-33.58% of base)
        -349 : 86789.dasm (-8.14% of base)
        -332 : 54515.dasm (-8.25% of base)
        -270 : 13603.dasm (-5.58% of base)
        -236 : 39529.dasm (-12.20% of base)
        -236 : 38358.dasm (-12.20% of base)
        -226 : 13595.dasm (-10.08% of base)
        -213 : 56118.dasm (-5.73% of base)
        -189 : 98753.dasm (-2.60% of base)
        -175 : 13593.dasm (-15.34% of base)
        -174 : 22456.dasm (-10.69% of base)
        -155 : 71955.dasm (-12.20% of base)
        -150 : 83955.dasm (-20.72% of base)
        -149 : 27305.dasm (-4.49% of base)
        -148 : 80649.dasm (-16.35% of base)
        -148 : 83980.dasm (-16.35% of base)
        -148 : 78029.dasm (-26.91% of base)

88 total files with Code Size differences (42 improved, 46 regressed), 6 unchanged.

Top method regressions (bytes):
         363 (18.45% of base) : 86950.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         351 (17.73% of base) : 91966.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         322 (23.69% of base) : 86952.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:InsertionSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         317 (15.96% of base) : 97873.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         306 (22.25% of base) : 97875.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:InsertionSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         306 (18.01% of base) : 97940.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         290 (13.55% of base) : 97916.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         284 (13.31% of base) : 86869.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         279 ( 5.19% of base) : 97815.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory:.ctor(System.Text.RegularExpressions.RegexTree,int,System.TimeSpan):this (Tier1)
         279 ( 5.19% of base) : 95224.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory:.ctor(System.Text.RegularExpressions.RegexTree,int,System.TimeSpan):this (Tier1)
         271 (12.68% of base) : 52401.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         266 (12.41% of base) : 27596.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         265 (11.10% of base) : 83676.dasm - System.Threading.Tests.Perf_CancellationToken:CreateManyRegisterMultipleDispose():this (Tier1-OSR)
         258 (12.18% of base) : 86903.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         243 ( 2.58% of base) : 13448.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
         235 ( 4.79% of base) : 39344.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:CreateAlternate(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],ubyte,ubyte):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong] (Tier1)
         231 (10.80% of base) : 97919.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         229 (10.73% of base) : 52389.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         218 (10.19% of base) : 27602.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         211 (15.83% of base) : 97943.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)

Top method improvements (bytes):
        -608 (-13.68% of base) : 68568.dasm - Microsoft.CodeAnalysis.CSharp.BinderFactory+BinderFactoryVisitor:VisitTypeDeclarationCore(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.Binder:this (Tier1)
        -592 (-12.24% of base) : 38354.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -591 (-11.97% of base) : 39523.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
        -449 (-33.58% of base) : 75910.dasm - JetStream.Hands:playHands(System.Collections.Generic.List`1[JetStream.Player]) (Tier1-OSR)
        -349 (-8.14% of base) : 86789.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
        -332 (-8.25% of base) : 54515.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
        -270 (-5.58% of base) : 13603.dasm - System.Text.RegularExpressions.RegexCompiler:<EmitTryFindNextPossibleStartingPosition>g__EmitFixedSet_LeftToRight|157_3(byref):this (Tier0-FullOpts)
        -236 (-12.20% of base) : 39529.dasm - System.Collections.Generic.ArraySortHelper`1[int]:PickPivotAndPartition(System.Span`1[int],System.Comparison`1[int]):int (Tier1)
        -236 (-12.20% of base) : 38358.dasm - System.Collections.Generic.ArraySortHelper`1[int]:PickPivotAndPartition(System.Span`1[int],System.Comparison`1[int]):int (Tier1)
        -226 (-10.08% of base) : 13595.dasm - System.Text.RegularExpressions.RegexPrefixAnalyzer:FindLiteralFollowingLeadingLoop(System.Text.RegularExpressions.RegexNode):System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]] (Tier0-FullOpts)
        -213 (-5.73% of base) : 56118.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
        -189 (-2.60% of base) : 98753.dasm - System.Net.Sockets.Tests.SocketSendReceivePerfTest+<SendAsyncThenReceiveAsync_Task>d__9:MoveNext():this (Tier1-OSR)
        -175 (-15.34% of base) : 13593.dasm - System.Text.RegularExpressions.RegexFindOptimizations:FindFixedDistanceString(System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]):System.Nullable`1[System.ValueTuple`2[System.String,int]] (Tier0-FullOpts)
        -174 (-10.69% of base) : 22456.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:<CreateBDDFromSetString>g__Compute|5_0(System.String):System.Text.RegularExpressions.Symbolic.BDD:this (Tier0-FullOpts)
        -155 (-12.20% of base) : 71955.dasm - Microsoft.CodeAnalysis.CSharp.ControlFlowPass:Scan(byref):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2+PendingBranch[Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalState,Microsoft.CodeAnalysis.CSharp.ControlFlowPass+LocalFunctionState]]:this (Tier1)
        -150 (-20.72% of base) : 83955.dasm - LinqBenchmarks:Where01ForX():ubyte:this (Tier1-OSR)
        -149 (-4.49% of base) : 27305.dasm - System.IO.Strategies.BufferedFileStreamStrategy:ReadAsync(System.Memory`1[ubyte],System.Threading.CancellationToken):System.Threading.Tasks.ValueTask`1[int]:this (Tier1)
        -148 (-26.91% of base) : 78029.dasm - LinqBenchmarks:Where00ForX():ubyte:this (Tier1-OSR)
        -148 (-16.35% of base) : 80649.dasm - System.Random:AssertInRange(long,long,long) (Tier1)
        -148 (-16.35% of base) : 83980.dasm - System.Random:AssertInRange(long,long,long) (Tier1)

Top method regressions (percentages):
         322 (23.69% of base) : 86952.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:InsertionSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         306 (22.25% of base) : 97875.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:InsertionSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
          31 (21.38% of base) : 36213.dasm - System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)
         363 (18.45% of base) : 86950.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         168 (18.26% of base) : 95112.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)
         306 (18.01% of base) : 97940.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         351 (17.73% of base) : 91966.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         151 (17.40% of base) : 97714.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)
         147 (16.94% of base) : 97525.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)
         317 (15.96% of base) : 97873.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         211 (15.83% of base) : 97943.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         207 (15.16% of base) : 91968.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:InsertionSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         123 (14.15% of base) : 33068.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)
          23 (14.11% of base) : 68170.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (Tier1)
          37 (13.86% of base) : 33052.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         290 (13.55% of base) : 97916.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         284 (13.31% of base) : 86869.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         182 (13.26% of base) : 52454.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         119 (13.22% of base) : 39336.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)
         117 (13.00% of base) : 52407.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)

Top method improvements (percentages):
         -22 (-41.51% of base) : 35789.dasm - System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:LessThan(byref,byref):ubyte (Tier1)
         -22 (-40.00% of base) : 35787.dasm - System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:GreaterThan(byref,byref):ubyte (Tier1)
        -449 (-33.58% of base) : 75910.dasm - JetStream.Hands:playHands(System.Collections.Generic.List`1[JetStream.Player]) (Tier1-OSR)
         -39 (-31.20% of base) : 67134.dasm - System.Threading.Tasks.RangeManager:RegisterNewWorker():System.Threading.Tasks.RangeWorker:this (Tier1)
        -147 (-27.58% of base) : 12142.dasm - BenchmarksGame.KNucleotide_9+<>c__DisplayClass13_0:<count4>b__4(System.Threading.Tasks.Task`1[System.Collections.Generic.Dictionary`2[long,BenchmarksGame.Wrapper]][]):System.String:this (Tier1-OSR)
         -80 (-26.94% of base) : 74949.dasm - FractalPerf.Mandelbrot:Render():double:this (Tier1-OSR)
        -148 (-26.91% of base) : 78029.dasm - LinqBenchmarks:Where00ForX():ubyte:this (Tier1-OSR)
         -38 (-25.00% of base) : 68925.dasm - Microsoft.Cci.ReferenceIndexer:VisitImports(System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.UsedNamespaceOrType]):this (Tier1)
         -62 (-24.22% of base) : 20651.dasm - LinqBenchmarks:Count00ForX():ubyte:this (Tier1-OSR)
         -25 (-22.94% of base) : 39526.dasm - System.Linq.EnumerableSorter`2[System.Collections.BigStruct,System.Collections.BigStruct]:CompareAnyKeys_DefaultComparer_NoNext_Ascending(int,int):int:this (Tier1)
         -25 (-22.94% of base) : 38356.dasm - System.Linq.EnumerableSorter`2[System.Collections.BigStruct,System.Collections.BigStruct]:CompareAnyKeys_DefaultComparer_NoNext_Ascending(int,int):int:this (Tier1)
        -150 (-20.72% of base) : 83955.dasm - LinqBenchmarks:Where01ForX():ubyte:this (Tier1-OSR)
         -45 (-20.45% of base) : 48140.dasm - PerfLabTests.LowLevelPerf:ForeachOverList100Elements():int:this (Tier1-OSR)
         -59 (-19.22% of base) : 68489.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode:GetLeadingTrivia():Microsoft.CodeAnalysis.SyntaxTriviaList:this (Tier1)
         -36 (-18.18% of base) : 72712.dasm - System.Reflection.Metadata.Ecma335.BlobHeap:GetBlobReader(System.Reflection.Metadata.BlobHandle):System.Reflection.Metadata.BlobReader:this (Tier1)
         -36 (-17.91% of base) : 72711.dasm - System.Reflection.Metadata.MetadataReader:GetBlobReader(System.Reflection.Metadata.BlobHandle):System.Reflection.Metadata.BlobReader:this (Tier1)
         -18 (-17.65% of base) : 68242.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:Clone():Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState:this (Tier1)
         -31 (-17.42% of base) : 69272.dasm - System.Collections.Generic.Dictionary`2+Enumerator[int,System.Collections.Generic.KeyValuePair`2[System.Collections.Immutable.ImmutableArray`1[ubyte],System.Reflection.Metadata.BlobHandle]]:MoveNext():ubyte:this (Tier1)
         -75 (-17.08% of base) : 68406.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_ParameterCount():int:this (Tier1)
        -148 (-16.35% of base) : 80649.dasm - System.Random:AssertInRange(long,long,long) (Tier1)

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

Total bytes of base: 12674703 (overridden on cmd)
Total bytes of diff: 12669899 (overridden on cmd)
Total bytes of delta: -4804 (-0.04 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         468 : 52858.dasm (6.18% of base)
         387 : 30536.dasm (18.08% of base)
         205 : 14268.dasm (10.26% of base)
         168 : 18295.dasm (13.30% of base)
         164 : 48422.dasm (10.02% of base)
         120 : 8697.dasm (6.01% of base)
          83 : 31382.dasm (0.98% of base)
          66 : 52916.dasm (3.97% of base)
          65 : 6625.dasm (13.68% of base)
          63 : 2624.dasm (2.24% of base)
          48 : 8694.dasm (4.85% of base)
          42 : 52845.dasm (2.05% of base)
          41 : 25622.dasm (27.70% of base)
          38 : 23686.dasm (3.57% of base)
          36 : 52886.dasm (3.06% of base)
          33 : 54364.dasm (4.84% of base)
          33 : 4992.dasm (3.16% of base)
          32 : 47754.dasm (8.74% of base)
          32 : 4203.dasm (3.70% of base)
          31 : 25647.dasm (21.38% of base)

Top file improvements (bytes):
        -408 : 45488.dasm (-33.58% of base)
        -270 : 5120.dasm (-5.58% of base)
        -226 : 5026.dasm (-10.11% of base)
        -182 : 5024.dasm (-16.09% of base)
        -178 : 33366.dasm (-11.41% of base)
        -174 : 17774.dasm (-11.01% of base)
        -168 : 40709.dasm (-7.27% of base)
        -160 : 45268.dasm (-1.82% of base)
        -132 : 22931.dasm (-8.88% of base)
        -124 : 46221.dasm (-24.17% of base)
        -123 : 40220.dasm (-7.84% of base)
        -123 : 40145.dasm (-16.69% of base)
        -121 : 25575.dasm (-4.00% of base)
        -115 : 48304.dasm (-16.76% of base)
        -110 : 43536.dasm (-1.90% of base)
        -105 : 40434.dasm (-12.27% of base)
        -101 : 43749.dasm (-13.82% of base)
        -100 : 42174.dasm (-6.61% of base)
         -85 : 44232.dasm (-32.08% of base)
         -80 : 44947.dasm (-26.85% of base)

74 total files with Code Size differences (39 improved, 35 regressed), 14 unchanged.

Top method regressions (bytes):
         468 ( 6.18% of base) : 52858.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:ConvertToSymbolicRegexNode(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.Text.RegularExpressions.Symbolic.BDD]:this (Tier1)
         387 (18.08% of base) : 30536.dasm - System.Text.Json.Tests.Perf_Segment:ReadMultiSegmentSequenceUsingSpan(int):this (Tier1-OSR)
         205 (10.26% of base) : 14268.dasm - System.Numerics.BigIntegerCalculator:Gcd(System.Span`1[uint],System.Span`1[uint]) (Tier1-OSR)
         168 (13.30% of base) : 18295.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
         164 (10.02% of base) : 48422.dasm - System.Threading.Tests.Perf_CancellationToken:CreateManyRegisterMultipleDispose():this (Tier1-OSR)
         120 ( 6.01% of base) : 8697.dasm - System.Net.Security.SafeDeleteContext:InitializeSecurityContext(byref,byref,System.String,int,int,System.Net.Security.InputSecurityBuffers,byref,byref):int (Tier1)
          83 ( 0.98% of base) : 31382.dasm - System.Diagnostics.Tracing.ManifestBuilder:CreateManifestString():System.String:this (Tier0-FullOpts)
          66 ( 3.97% of base) : 52916.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:Reverse(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong]):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
          65 (13.68% of base) : 6625.dasm - System.Collections.Frozen.OrdinalStringFrozenDictionary`1[System.__Canon]:.ctor(System.String[],System.__Canon[],System.Collections.Generic.IEqualityComparer`1[System.String],int,int,int,int):this (Tier1-OSR)
          63 ( 2.24% of base) : 2624.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (Tier1)
          48 ( 4.85% of base) : 8694.dasm - System.Net.Security.SslStreamPal:InitializeSecurityContext(byref,byref,System.String,System.ReadOnlySpan`1[ubyte],System.Net.Security.SslAuthenticationOptions):System.Net.Security.ProtocolToken (Tier1)
          42 ( 2.05% of base) : 52845.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[System.__Canon]:Transform[ulong](System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.__Canon],System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Func`3[System.__Canon,System.__Canon,ulong]):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
          41 (27.70% of base) : 25622.dasm - System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (Tier1-OSR)
          38 ( 3.57% of base) : 23686.dasm - System.Convert:TryFromBase64Chars(System.ReadOnlySpan`1[ushort],System.Span`1[ubyte],byref):ubyte (Tier0-FullOpts)
          36 ( 3.06% of base) : 52886.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong]:.ctor(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],System.Text.RegularExpressions.Symbolic.CharSetSolver):this (Tier1)
          33 ( 4.84% of base) : 54364.dasm - LinqBenchmarks:AggregateBy00LinqMethodX():ubyte:this (Tier1-OSR)
          33 ( 3.16% of base) : 4992.dasm - System.Text.RegularExpressions.RegexPrefixAnalyzer:FindFixedDistanceSets(System.Text.RegularExpressions.RegexNode,ubyte):System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet] (Tier0-FullOpts)
          32 ( 8.74% of base) : 47754.dasm - System.IO.Pipelines.Pipe:GetReadResult(byref):this (Tier1)
          32 ( 3.70% of base) : 4203.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateRtFields(System.RuntimeType+RuntimeTypeCache+Filter,ulong,int,System.RuntimeType,byref):this (Tier1)
          31 (21.38% of base) : 25647.dasm - System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)

Top method improvements (bytes):
        -408 (-33.58% of base) : 45488.dasm - JetStream.Hands:playHands(System.Collections.Generic.List`1[JetStream.Player]) (Tier1-OSR)
        -270 (-5.58% of base) : 5120.dasm - System.Text.RegularExpressions.RegexCompiler:<EmitTryFindNextPossibleStartingPosition>g__EmitFixedSet_LeftToRight|157_3(byref):this (Tier0-FullOpts)
        -226 (-10.11% of base) : 5026.dasm - System.Text.RegularExpressions.RegexPrefixAnalyzer:FindLiteralFollowingLeadingLoop(System.Text.RegularExpressions.RegexNode):System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]] (Tier0-FullOpts)
        -182 (-16.09% of base) : 5024.dasm - System.Text.RegularExpressions.RegexFindOptimizations:FindFixedDistanceString(System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]):System.Nullable`1[System.ValueTuple`2[System.String,int]] (Tier0-FullOpts)
        -178 (-11.41% of base) : 33366.dasm - System.Text.RegularExpressions.RegexFindOptimizations:.ctor(System.Text.RegularExpressions.RegexNode,int):this (Tier1)
        -174 (-11.01% of base) : 17774.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:<CreateBDDFromSetString>g__Compute|5_0(System.String):System.Text.RegularExpressions.Symbolic.BDD:this (Tier0-FullOpts)
        -168 (-7.27% of base) : 40709.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbolExtensions:VisitType[System.__Canon](Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.Func`4[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.__Canon,ubyte,ubyte],System.Func`4[System.__Canon,System.__Canon,ubyte,ubyte],System.__Canon,ubyte,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (Tier1)
        -160 (-1.82% of base) : 45268.dasm - System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1-OSR)
        -132 (-8.88% of base) : 22931.dasm - System.UriHelper:EscapeStringToBuilder(System.ReadOnlySpan`1[ushort],byref,System.Buffers.SearchValues`1[ushort],ubyte) (Tier0-FullOpts)
        -124 (-24.17% of base) : 46221.dasm - LinqBenchmarks:Where00ForX():ubyte:this (Tier1-OSR)
        -123 (-7.84% of base) : 40220.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:GetSignatureForMethod(System.Reflection.Metadata.MethodDefinitionHandle,byref,byref,ubyte):Microsoft.CodeAnalysis.ParamInfo`1[System.__Canon][]:this (Tier1)
        -123 (-16.69% of base) : 40145.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:GetSignatureForProperty(System.Reflection.Metadata.PropertyDefinitionHandle,byref,byref):Microsoft.CodeAnalysis.ParamInfo`1[System.__Canon][]:this (Tier1)
        -121 (-4.00% of base) : 25575.dasm - System.Text.Json.JsonDocument:Parse(System.ReadOnlySpan`1[ubyte],System.Text.Json.JsonReaderOptions,byref,byref) (Tier1-OSR)
        -115 (-16.76% of base) : 48304.dasm - LinqBenchmarks:Where01ForX():ubyte:this (Tier1-OSR)
        -110 (-1.90% of base) : 43536.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindVariableDeclaration(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol,ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration:this (Tier1)
        -105 (-12.27% of base) : 40434.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Arity():int:this (Tier1)
        -101 (-13.82% of base) : 43749.dasm - CscBench:GetSpanBetweenMarkers(Microsoft.CodeAnalysis.SyntaxTree):Microsoft.CodeAnalysis.Text.TextSpan (Tier1)
        -100 (-6.61% of base) : 42174.dasm - System.Buffers.SearchValues:Create(System.ReadOnlySpan`1[ushort]):System.Buffers.SearchValues`1[ushort] (Tier1)
         -85 (-32.08% of base) : 44232.dasm - System.Reflection.PortableExecutable.PEHeaders:TryGetDirectoryOffset(System.Reflection.PortableExecutable.DirectoryEntry,byref,ubyte):ubyte:this (Tier1)
         -80 (-26.85% of base) : 44947.dasm - FractalPerf.Mandelbrot:Render():double:this (Tier1-OSR)

Top method regressions (percentages):
          41 (27.70% of base) : 25622.dasm - System.Linq.Enumerable+SelectArrayIterator`2[double,System.__Canon]:Fill(System.ReadOnlySpan`1[double],System.Span`1[System.__Canon],System.Func`2[double,System.__Canon]) (Tier1-OSR)
          31 (21.38% of base) : 25647.dasm - System.Numerics.BigIntegerCalculator:SubtractDivisor(System.Span`1[uint],System.ReadOnlySpan`1[uint],ulong):uint (Tier1-OSR)
         387 (18.08% of base) : 30536.dasm - System.Text.Json.Tests.Perf_Segment:ReadMultiSegmentSequenceUsingSpan(int):this (Tier1-OSR)
          65 (13.68% of base) : 6625.dasm - System.Collections.Frozen.OrdinalStringFrozenDictionary`1[System.__Canon]:.ctor(System.String[],System.__Canon[],System.Collections.Generic.IEqualityComparer`1[System.String],int,int,int,int):this (Tier1-OSR)
         168 (13.30% of base) : 18295.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
          16 (11.59% of base) : 20847.dasm - System.Linq.Enumerable+SelectRangeIterator`1[System.__Canon]:Fill(System.Span`1[System.__Canon],int,System.Func`2[int,System.__Canon]) (Tier1-OSR)
          14 (10.77% of base) : 49832.dasm - System.Numerics.BigIntegerCalculator:Multiply(System.ReadOnlySpan`1[uint],uint,System.Span`1[uint]) (Tier1-OSR)
         205 (10.26% of base) : 14268.dasm - System.Numerics.BigIntegerCalculator:Gcd(System.Span`1[uint],System.Span`1[uint]) (Tier1-OSR)
         164 (10.02% of base) : 48422.dasm - System.Threading.Tests.Perf_CancellationToken:CreateManyRegisterMultipleDispose():this (Tier1-OSR)
          11 ( 9.65% of base) : 43985.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:GetDisposableResetPoint(ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser+DisposableResetPoint:this (Tier1)
           7 ( 9.33% of base) : 32176.dasm - Struct.SpanWrapper:SumSpanWrapper(Struct.SpanWrapper`1[int]):int:this (Tier1-OSR)
          32 ( 8.74% of base) : 47754.dasm - System.IO.Pipelines.Pipe:GetReadResult(byref):this (Tier1)
          17 ( 8.72% of base) : 6616.dasm - System.Linq.Enumerable+ListPartition`1[System.__Canon]:Fill(System.Collections.Generic.IList`1[System.__Canon],System.Span`1[System.__Canon],int) (Tier1-OSR)
          11 ( 7.69% of base) : 47722.dasm - System.IO.Pipelines.PipeAwaitable:Complete(byref):this (Tier1)
          10 ( 7.41% of base) : 43044.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:GetResetPoint():Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser+ResetPoint:this (Tier1)
          29 ( 6.84% of base) : 52801.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:Create(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],int,System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],int,int,ulong,System.Text.RegularExpressions.Symbolic.SymbolicRegexInfo):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong] (Tier1)
          15 ( 6.82% of base) : 33614.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (Tier1)
           4 ( 6.78% of base) : 31571.dasm - Struct.SpanWrapper:SumSpan(System.ReadOnlySpan`1[int]):int:this (Tier1-OSR)
          16 ( 6.53% of base) : 43692.dasm - Microsoft.CodeAnalysis.SyntaxToken:get_TrailingTrivia():Microsoft.CodeAnalysis.SyntaxTriviaList:this (Tier1)
          11 ( 6.25% of base) : 44312.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:IsLocationContainedWithin(Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.SyntaxTree,Microsoft.CodeAnalysis.Text.TextSpan,byref):ubyte (Tier1)

Top method improvements (percentages):
         -68 (-67.33% of base) : 26346.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache:None(System.Type):Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache (Tier1)
         -43 (-54.43% of base) : 28087.dasm - ProtoBuf.Internal.BasicList:GetEnumerator():ProtoBuf.Internal.BasicList+NodeEnumerator:this (Tier1)
         -38 (-50.67% of base) : 17622.dasm - System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,System.__Canon]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,System.__Canon]]):this (Tier1)
         -64 (-43.24% of base) : 44233.dasm - System.Reflection.PortableExecutable.PEHeaders:GetContainingSectionIndex(int):int:this (Tier1)
         -33 (-42.86% of base) : 44330.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList:GetEnumerator():Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList+Enumerator:this (Tier1)
        -408 (-33.58% of base) : 45488.dasm - JetStream.Hands:playHands(System.Collections.Generic.List`1[JetStream.Player]) (Tier1-OSR)
         -85 (-32.08% of base) : 44232.dasm - System.Reflection.PortableExecutable.PEHeaders:TryGetDirectoryOffset(System.Reflection.PortableExecutable.DirectoryEntry,byref,ubyte):ubyte:this (Tier1)
         -39 (-31.20% of base) : 40555.dasm - System.Threading.Tasks.RangeManager:RegisterNewWorker():System.Threading.Tasks.RangeWorker:this (Tier1)
         -80 (-26.85% of base) : 44947.dasm - FractalPerf.Mandelbrot:Render():double:this (Tier1-OSR)
         -30 (-26.32% of base) : 25410.dasm - System.Linq.EnumerableSorter`2[System.Collections.BigStruct,System.Collections.BigStruct]:CompareAnyKeys_DefaultComparer_NoNext_Ascending(int,int):int:this (Tier1)
         -22 (-26.19% of base) : 43484.dasm - Microsoft.CodeAnalysis.CSharp.Binder+NamespaceOrTypeOrAliasSymbolWithAnnotations:op_Implicit(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations):Microsoft.CodeAnalysis.CSharp.Binder+NamespaceOrTypeOrAliasSymbolWithAnnotations (Tier1)
        -124 (-24.17% of base) : 46221.dasm - LinqBenchmarks:Where00ForX():ubyte:this (Tier1-OSR)
         -52 (-21.58% of base) : 13392.dasm - LinqBenchmarks:Count00ForX():ubyte:this (Tier1-OSR)
         -58 (-21.01% of base) : 40086.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:DecodeSignatureHeaderOrThrow(System.Reflection.Metadata.BlobHandle,byref):System.Reflection.Metadata.BlobReader:this (Tier1)
         -58 (-20.64% of base) : 40087.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:DecodeSignatureHeaderOrThrow(Microsoft.CodeAnalysis.PEModule,System.Reflection.Metadata.BlobHandle,byref):System.Reflection.Metadata.BlobReader (Tier1)
         -43 (-19.82% of base) : 30746.dasm - PerfLabTests.LowLevelPerf:ForeachOverList100Elements():int:this (Tier1-OSR)
         -58 (-18.59% of base) : 28086.dasm - ProtoBuf.Meta.RuntimeTypeModel:FindWithoutAdd(System.Type):ProtoBuf.Meta.MetaType:this (Tier1)
         -44 (-18.49% of base) : 44318.dasm - Microsoft.CodeAnalysis.SyntaxNode:FindTokenInternal(int):Microsoft.CodeAnalysis.SyntaxToken:this (Tier1)
         -31 (-17.61% of base) : 41217.dasm - Microsoft.CodeAnalysis.MetadataTypeName:FromFullName(System.String,ubyte,int):Microsoft.CodeAnalysis.MetadataTypeName (Tier1)
        -115 (-16.76% of base) : 48304.dasm - LinqBenchmarks:Where01ForX():ubyte:this (Tier1-OSR)

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

Total bytes of base: 386868437 (overridden on cmd)
Total bytes of diff: 386560747 (overridden on cmd)
Total bytes of delta: -307690 (-0.08 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        4855 : 291323.dasm (30.82% of base)
         952 : 19699.dasm (22.82% of base)
         909 : 233367.dasm (2.89% of base)
         578 : 19897.dasm (31.31% of base)
         546 : 192574.dasm (13.41% of base)
         445 : 19832.dasm (47.90% of base)
         388 : 189490.dasm (20.37% of base)
         344 : 580221.dasm (13.27% of base)
         342 : 576365.dasm (13.22% of base)
         323 : 576520.dasm (5.62% of base)
         323 : 580361.dasm (5.62% of base)
         309 : 576368.dasm (20.96% of base)
         309 : 476358.dasm (19.43% of base)
         303 : 580224.dasm (20.45% of base)
         302 : 234429.dasm (2.77% of base)
         282 : 19680.dasm (57.32% of base)
         270 : 313842.dasm (3.44% of base)
         270 : 551891.dasm (3.44% of base)
         270 : 463834.dasm (3.46% of base)
         270 : 556693.dasm (3.44% of base)

Top file improvements (bytes):
       -3726 : 233194.dasm (-4.17% of base)
       -2882 : 291322.dasm (-42.63% of base)
       -2882 : 291389.dasm (-42.63% of base)
       -2817 : 291274.dasm (-61.78% of base)
       -2783 : 291374.dasm (-42.32% of base)
       -2783 : 291390.dasm (-42.32% of base)
       -2735 : 291266.dasm (-62.96% of base)
       -2633 : 291375.dasm (-40.01% of base)
       -2629 : 291258.dasm (-81.27% of base)
       -2585 : 291260.dasm (-18.55% of base)
       -2535 : 291363.dasm (-38.77% of base)
       -2459 : 291250.dasm (-80.23% of base)
       -2149 : 233201.dasm (-2.33% of base)
       -2048 : 291093.dasm (-51.29% of base)
       -1993 : 291085.dasm (-52.49% of base)
       -1962 : 291327.dasm (-12.13% of base)
       -1872 : 291044.dasm (-51.18% of base)
       -1848 : 291076.dasm (-49.57% of base)
       -1820 : 291009.dasm (-9.36% of base)
       -1792 : 291034.dasm (-54.65% of base)

85 total files with Code Size differences (48 improved, 37 regressed), 20 unchanged.

Top method regressions (bytes):
        4855 (30.82% of base) : 291323.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         952 (22.82% of base) : 19699.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:.cctor() (FullOpts)
         909 ( 2.89% of base) : 233367.dasm - longMDArrTest:TestEntryPoint():int (FullOpts)
         578 (31.31% of base) : 19897.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrPrivateTraceEventParser:.cctor() (FullOpts)
         546 (13.41% of base) : 192574.dasm - Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder:VisitTypeDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration:this (FullOpts)
         445 (47.90% of base) : 19832.dasm - Microsoft.Diagnostics.Tracing.Parsers.Clr.ClrRundownTraceEventParser:.cctor() (FullOpts)
         388 (20.37% of base) : 189490.dasm - Program:Compare_Struct2_Nullable(System.Nullable`1[Struct2],System.Nullable`1[Struct2]) (FullOpts)
         344 (13.27% of base) : 580221.dasm - ILCompiler.DependencyAnalysis.NodeFactory:MethodEntrypoint(Internal.JitInterface.MethodWithToken,ubyte,ubyte,ubyte):ILCompiler.DependencyAnalysis.IMethodNode:this (Tier1)
         342 (13.22% of base) : 576365.dasm - ILCompiler.DependencyAnalysis.NodeFactory:MethodEntrypoint(Internal.JitInterface.MethodWithToken,ubyte,ubyte,ubyte):ILCompiler.DependencyAnalysis.IMethodNode:this (Tier1)
         323 ( 5.62% of base) : 576520.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.DebugInfoTableNode:CreateVarBlobForMethod(Internal.JitInterface.NativeVarInfo[],Internal.TypeSystem.TargetDetails):ubyte[] (Tier1)
         323 ( 5.62% of base) : 580361.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.DebugInfoTableNode:CreateVarBlobForMethod(Internal.JitInterface.NativeVarInfo[],Internal.TypeSystem.TargetDetails):ubyte[] (Tier1)
         309 (19.43% of base) : 476358.dasm - JitTest_lcs_gcref_port.LCSV:findLCS(JitTest_lcs_gcref_port.LCSV[,,,],JitTest_lcs_gcref_port.LCSV[,,,],ushort[][],JitTest_lcs_gcref_port.LCSV[]) (Tier1-OSR)
         309 (20.96% of base) : 576368.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[ILCompiler.DependencyAnalysis.TypeAndMethod,System.__Canon]:TryGetValueInternal(System.Collections.Concurrent.ConcurrentDictionary`2+Tables[ILCompiler.DependencyAnalysis.TypeAndMethod,System.__Canon],ILCompiler.DependencyAnalysis.TypeAndMethod,int,byref):ubyte (Tier1)
         303 (20.45% of base) : 580224.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[ILCompiler.DependencyAnalysis.TypeAndMethod,System.__Canon]:TryGetValueInternal(System.Collections.Concurrent.ConcurrentDictionary`2+Tables[ILCompiler.DependencyAnalysis.TypeAndMethod,System.__Canon],ILCompiler.DependencyAnalysis.TypeAndMethod,int,byref):ubyte (Tier1)
         302 ( 2.77% of base) : 234429.dasm - structinreg.Program3:Main1():int (FullOpts)
         282 (57.32% of base) : 19680.dasm - Microsoft.Diagnostics.Tracing.Parsers.SymbolTraceEventParser:.cctor() (FullOpts)
         270 ( 3.44% of base) : 313842.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         270 ( 3.44% of base) : 551891.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         270 ( 3.46% of base) : 463834.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         270 ( 3.44% of base) : 556693.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)

Top method improvements (bytes):
       -3726 (-4.17% of base) : 233194.dasm - i4div:TestEntryPoint():int (FullOpts)
       -2882 (-42.63% of base) : 291322.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2882 (-42.63% of base) : 291389.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2817 (-61.78% of base) : 291274.dasm - HFATest.TestMan:Add03_HFA19(float,byte,HFATest.HFA19,double,byte,HFATest.HFA19,long,short,int,HFATest.HFA19,HFATest.HFA19,float,HFATest.HFA19,float,HFATest.HFA19,float,HFATest.HFA19):double (FullOpts)
       -2783 (-42.32% of base) : 291374.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2783 (-42.32% of base) : 291390.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2735 (-62.96% of base) : 291266.dasm - HFATest.TestMan:Add02_HFA19(HFATest.HFA19,HFATest.HFA19,long,short,float,int,double,float,HFATest.HFA19,double,float,HFATest.HFA19,short,HFATest.HFA19,float,HFATest.HFA19,HFATest.HFA19):double (FullOpts)
       -2633 (-40.01% of base) : 291375.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2629 (-81.27% of base) : 291258.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2585 (-18.55% of base) : 291260.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2535 (-38.77% of base) : 291363.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2459 (-80.23% of base) : 291250.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2149 (-2.33% of base) : 233201.dasm - i4rem:TestEntryPoint():int (FullOpts)
       -2048 (-51.29% of base) : 291093.dasm - HFATest.TestMan:Add03_HFA19(float,byte,HFATest.HFA19,double,byte,HFATest.HFA19,long,short,int,HFATest.HFA19,HFATest.HFA19,float,HFATest.HFA19,float,HFATest.HFA19,float,HFATest.HFA19):float (FullOpts)
       -1993 (-52.49% of base) : 291085.dasm - HFATest.TestMan:Add02_HFA19(HFATest.HFA19,HFATest.HFA19,long,short,float,int,double,float,HFATest.HFA19,double,float,HFATest.HFA19,short,HFATest.HFA19,float,HFATest.HFA19,HFATest.HFA19):float (FullOpts)
       -1962 (-12.13% of base) : 291327.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -1872 (-51.18% of base) : 291044.dasm - HFATest.TestMan:Average19_HFA19(HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19):double (FullOpts)
       -1848 (-49.57% of base) : 291076.dasm - HFATest.TestMan:Add01_HFA19(HFATest.HFA19,float,HFATest.HFA19,int,HFATest.HFA19,short,double,HFATest.HFA19,HFATest.HFA19,float,long,float,HFATest.HFA19,float,HFATest.HFA19):float (FullOpts)
       -1820 (-9.36% of base) : 291009.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -1792 (-54.65% of base) : 291034.dasm - HFATest.TestMan:Average11_HFA19(HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19):double (FullOpts)

Top method regressions (percentages):
         206 (85.83% of base) : 234427.dasm - structinreg.Program2:test23(structinreg.Test23):int (FullOpts)
         113 (76.35% of base) : 578981.dasm - System.Linq.OrderedEnumerable`1[Internal.NativeFormat.VertexHashtable+Entry]:Fill(Internal.NativeFormat.VertexHashtable+Entry[],System.Span`1[Internal.NativeFormat.VertexHashtable+Entry]):this (Tier1-OSR)
         113 (76.35% of base) : 581137.dasm - System.Linq.OrderedEnumerable`1[Internal.NativeFormat.VertexHashtable+Entry]:Fill(Internal.NativeFormat.VertexHashtable+Entry[],System.Span`1[Internal.NativeFormat.VertexHashtable+Entry]):this (Tier1-OSR)
         126 (65.28% of base) : 234419.dasm - structinreg.Program1:test4(structinreg.Test4):int (FullOpts)
         282 (57.32% of base) : 19680.dasm - Microsoft.Diagnostics.Tracing.Parsers.SymbolTraceEventParser:.cctor() (FullOpts)
         171 (56.44% of base) : 19898.dasm - Microsoft.Diagnostics.Tracing.Parsers.Clr.ClrStressTraceEventParser:.cctor() (FullOpts)
         108 (50.00% of base) : 19745.dasm - Microsoft.Diagnostics.Tracing.Parsers.GCDynamicTraceEventParser:.cctor() (FullOpts)
         445 (47.90% of base) : 19832.dasm - Microsoft.Diagnostics.Tracing.Parsers.Clr.ClrRundownTraceEventParser:.cctor() (FullOpts)
         211 (41.05% of base) : 222617.dasm - AA:reset() (FullOpts)
          37 (40.66% of base) : 22032.dasm - PhysicalPromotion:.cctor() (FullOpts)
          50 (40.32% of base) : 19900.dasm - Microsoft.Diagnostics.Tracing.EventPipe.SampleProfilerTraceEventParser:.cctor() (FullOpts)
          50 (40.32% of base) : 19899.dasm - Microsoft.Diagnostics.Tracing.Parsers.FrameworkEventSourceTraceEventParser:.cctor() (FullOpts)
          50 (40.32% of base) : 19804.dasm - Microsoft.Diagnostics.Tracing.Parsers.TplEtwProviderTraceEventParser:.cctor() (FullOpts)
         578 (31.31% of base) : 19897.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrPrivateTraceEventParser:.cctor() (FullOpts)
        4855 (30.82% of base) : 291323.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
          21 (29.58% of base) : 22346.dasm - SevenByteStruct:.cctor() (FullOpts)
          15 (27.78% of base) : 22306.dasm - TestAssignFieldsBetweenPromotedNotPromotedStructs:TestStructCasts() (FullOpts)
         109 (27.18% of base) : 234446.dasm - structinreg.Program3+<>c:<Main1>b__83_14(structinreg.Program3+S15):this (FullOpts)
         105 (25.61% of base) : 234443.dasm - structinreg.Program3+<>c:<Main1>b__83_11(structinreg.Program3+S12):this (FullOpts)
         125 (23.95% of base) : 223097.dasm - AA:reset() (FullOpts)

Top method improvements (percentages):
         -46 (-92.00% of base) : 247200.dasm - C:Test64Bit(int):int (FullOpts)
       -2629 (-81.27% of base) : 291258.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
       -2459 (-80.23% of base) : 291250.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         -40 (-71.43% of base) : 247796.dasm - Program:TestEntryPoint():int (FullOpts)
         -27 (-67.50% of base) : 184834.dasm - TailcallVerify.Condition4:Callee2():TailcallVerify.ValueType3Bytes (FullOpts)
         -33 (-67.35% of base) : 240254.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
        -355 (-64.78% of base) : 291025.dasm - HFATest.TestMan:Sum_HFA19(HFATest.HFA19):double (FullOpts)
        -355 (-63.85% of base) : 291026.dasm - HFATest.TestMan:Average_HFA19(HFATest.HFA19):double (FullOpts)
       -2735 (-62.96% of base) : 291266.dasm - HFATest.TestMan:Add02_HFA19(HFATest.HFA19,HFATest.HFA19,long,short,float,int,double,float,HFATest.HFA19,double,float,HFATest.HFA19,short,HFATest.HFA19,float,HFATest.HFA19,HFATest.HFA19):double (FullOpts)
       -2817 (-61.78% of base) : 291274.dasm - HFATest.TestMan:Add03_HFA19(float,byte,HFATest.HFA19,double,byte,HFATest.HFA19,long,short,int,HFATest.HFA19,HFATest.HFA19,float,HFATest.HFA19,float,HFATest.HFA19,float,HFATest.HFA19):double (FullOpts)
         -64 (-61.54% of base) : 243371.dasm - X:F(int,int):int (FullOpts)
         -60 (-61.22% of base) : 247513.dasm - N.Repro1:RunTest():int (FullOpts)
        -351 (-60.62% of base) : 291157.dasm - HFATest.TestMan:Sum3_HFA19(float,long,HFATest.HFA19):double (FullOpts)
       -1566 (-60.21% of base) : 291015.dasm - HFATest.TestMan:Average5_HFA19(HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19,HFATest.HFA19):double (FullOpts)
        -370 (-59.11% of base) : 291164.dasm - HFATest.TestMan:Sum5_HFA19(long,double,int,byte,HFATest.HFA19):double (FullOpts)
        -200 (-59.00% of base) : 245784.dasm - Runtime_88616:TestEntryPoint():int (FullOpts)
         -73 (-58.40% of base) : 21277.dasm - Runtime_87614:M3(S1):int (FullOpts)
        -147 (-58.33% of base) : 291016.dasm - HFATest.TestMan:Sum_HFA11(HFATest.HFA11):double (FullOpts)
        -354 (-57.56% of base) : 291171.dasm - HFATest.TestMan:Sum8_HFA19(float,double,long,byte,double,HFATest.HFA19):double (FullOpts)
       -1464 (-57.50% of base) : 291022.dasm - HFATest.TestMan:Average8_HFA11(HFATest.HFA11,HFATest.HFA11,HFATest.HFA11,HFATest.HFA11,HFATest.HFA11,HFATest.HFA11,HFATest.HFA11,HFATest.HFA11):double (FullOpts)

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

Total bytes of base: 44901308 (overridden on cmd)
Total bytes of diff: 44849977 (overridden on cmd)
Total bytes of delta: -51331 (-0.11 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1671 : 188413.dasm (72.46% of base)
        1058 : 221690.dasm (4.79% of base)
        1058 : 191041.dasm (4.79% of base)
         627 : 89338.dasm (21.82% of base)
         255 : 238907.dasm (11.51% of base)
         229 : 4620.dasm (26.50% of base)
         202 : 91209.dasm (19.57% of base)
         202 : 264307.dasm (9.13% of base)
         188 : 186034.dasm (23.18% of base)
         178 : 89376.dasm (19.10% of base)
         158 : 123453.dasm (3.69% of base)
         140 : 192685.dasm (16.41% of base)
         140 : 223267.dasm (16.41% of base)
         132 : 2487.dasm (46.15% of base)
         132 : 2488.dasm (45.67% of base)
         132 : 2490.dasm (45.67% of base)
         132 : 2489.dasm (46.15% of base)
         113 : 223268.dasm (12.07% of base)
         113 : 54936.dasm (5.74% of base)
         113 : 192686.dasm (12.07% of base)

Top file improvements (bytes):
       -4980 : 151527.dasm (-58.52% of base)
       -1045 : 185884.dasm (-9.50% of base)
        -661 : 87882.dasm (-11.30% of base)
        -578 : 61062.dasm (-20.32% of base)
        -417 : 231043.dasm (-7.30% of base)
        -417 : 200826.dasm (-7.30% of base)
        -407 : 122049.dasm (-67.61% of base)
        -407 : 59372.dasm (-67.61% of base)
        -394 : 220599.dasm (-32.92% of base)
        -394 : 189846.dasm (-32.92% of base)
        -345 : 184803.dasm (-34.29% of base)
        -310 : 220625.dasm (-38.90% of base)
        -310 : 189873.dasm (-38.90% of base)
        -268 : 117647.dasm (-35.08% of base)
        -268 : 54393.dasm (-35.08% of base)
        -266 : 23250.dasm (-43.11% of base)
        -255 : 270362.dasm (-14.88% of base)
        -252 : 124642.dasm (-31.86% of base)
        -252 : 62372.dasm (-31.86% of base)
        -252 : 55850.dasm (-16.99% of base)

80 total files with Code Size differences (46 improved, 34 regressed), 20 unchanged.

Top method regressions (bytes):
        1671 (72.46% of base) : 188413.dasm - System.Speech.Internal.SrgsCompiler.Backend:InitFromBinaryGrammar(System.Speech.Internal.StreamMarshaler):this (FullOpts)
        1058 ( 4.79% of base) : 221690.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
        1058 ( 4.79% of base) : 191041.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
         627 (21.82% of base) : 89338.dasm - System.Security.Cryptography.Pkcs.CmsSigner:Sign(System.ReadOnlyMemory`1[ubyte],System.String,ubyte,byref):System.Security.Cryptography.Pkcs.Asn1.SignerInfoAsn:this (FullOpts)
         255 (11.51% of base) : 238907.dasm - Internal.Microsoft.Extensions.DependencyModel.DependencyContextJsonReader:CreateLibrary(Internal.Microsoft.Extensions.DependencyModel.DependencyContextJsonReader+TargetLibrary,ubyte,System.Collections.Generic.Dictionary`2[System.String,Internal.Microsoft.Extensions.DependencyModel.DependencyContextJsonReader+LibraryStub]):Internal.Microsoft.Extensions.DependencyModel.Library:this (FullOpts)
         229 (26.50% of base) : 4620.dasm - System.Numerics.Matrix4x4:Transform(System.Numerics.Matrix4x4,System.Numerics.Quaternion):System.Numerics.Matrix4x4 (FullOpts)
         202 (19.57% of base) : 91209.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetCollectionRangeVariableSymbolInfoWorker(Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionRangeVariableSyntax,System.Threading.CancellationToken):Microsoft.CodeAnalysis.VisualBasic.CollectionRangeVariableSymbolInfo:this (FullOpts)
         202 ( 9.13% of base) : 264307.dasm - Microsoft.Extensions.DependencyModel.DependencyContextJsonReader:CreateLibrary(Microsoft.Extensions.DependencyModel.DependencyContextJsonReader+TargetLibrary,ubyte,System.Collections.Generic.Dictionary`2[System.String,Microsoft.Extensions.DependencyModel.DependencyContextJsonReader+LibraryStub]):Microsoft.Extensions.DependencyModel.Library:this (FullOpts)
         188 (23.18% of base) : 186034.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeader(System.Reflection.Metadata.BlobBuilder,System.Reflection.PortableExecutable.PEBuilder+SerializedSection) (FullOpts)
         178 (19.10% of base) : 89376.dasm - System.Security.Cryptography.Pkcs.Rfc3161TimestampTokenInfo:Encode(System.Security.Cryptography.Oid,System.Security.Cryptography.Oid,System.ReadOnlyMemory`1[ubyte],System.ReadOnlyMemory`1[ubyte],System.DateTimeOffset,ubyte,System.Nullable`1[long],System.Nullable`1[System.ReadOnlyMemory`1[ubyte]],System.Nullable`1[System.ReadOnlyMemory`1[ubyte]],System.Security.Cryptography.X509Certificates.X509ExtensionCollection):ubyte[] (FullOpts)
         158 ( 3.69% of base) : 123453.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitCollectionExpression(Microsoft.CodeAnalysis.CSharp.BoundCollectionExpression):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
         140 (16.41% of base) : 192685.dasm - Microsoft.CodeAnalysis.SyntaxNavigator:GetNextToken(Microsoft.CodeAnalysis.SyntaxTrivia,Microsoft.CodeAnalysis.SyntaxTriviaList,System.Func`2[Microsoft.CodeAnalysis.SyntaxToken,ubyte],System.Func`2[Microsoft.CodeAnalysis.SyntaxTrivia,ubyte],byref):Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
         140 (16.41% of base) : 223267.dasm - Microsoft.CodeAnalysis.SyntaxNavigator:GetNextToken(Microsoft.CodeAnalysis.SyntaxTrivia,Microsoft.CodeAnalysis.SyntaxTriviaList,System.Func`2[Microsoft.CodeAnalysis.SyntaxToken,ubyte],System.Func`2[Microsoft.CodeAnalysis.SyntaxTrivia,ubyte],byref):Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
         132 (46.15% of base) : 2489.dasm - System.Guid:op_GreaterThan(System.Guid,System.Guid):ubyte (FullOpts)
         132 (45.67% of base) : 2490.dasm - System.Guid:op_GreaterThanOrEqual(System.Guid,System.Guid):ubyte (FullOpts)
         132 (46.15% of base) : 2487.dasm - System.Guid:op_LessThan(System.Guid,System.Guid):ubyte (FullOpts)
         132 (45.67% of base) : 2488.dasm - System.Guid:op_LessThanOrEqual(System.Guid,System.Guid):ubyte (FullOpts)
         113 ( 5.74% of base) : 54936.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindExtensionMethod(Microsoft.CodeAnalysis.SyntaxNode,System.String,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.CSharp.MethodGroupResolution:this (FullOpts)
         113 (12.07% of base) : 223268.dasm - Microsoft.CodeAnalysis.SyntaxNavigator:GetPreviousToken(Microsoft.CodeAnalysis.SyntaxTrivia,Microsoft.CodeAnalysis.SyntaxTriviaList,System.Func`2[Microsoft.CodeAnalysis.SyntaxToken,ubyte],System.Func`2[Microsoft.CodeAnalysis.SyntaxTrivia,ubyte],byref):Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
         113 (12.07% of base) : 192686.dasm - Microsoft.CodeAnalysis.SyntaxNavigator:GetPreviousToken(Microsoft.CodeAnalysis.SyntaxTrivia,Microsoft.CodeAnalysis.SyntaxTriviaList,System.Func`2[Microsoft.CodeAnalysis.SyntaxToken,ubyte],System.Func`2[Microsoft.CodeAnalysis.SyntaxTrivia,ubyte],byref):Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)

Top method improvements (bytes):
       -4980 (-58.52% of base) : 151527.dasm - System.Xml.Xsl.XPathConvert+BigNumber:.cctor() (FullOpts)
       -1045 (-9.50% of base) : 185884.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
        -661 (-11.30% of base) : 87882.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BetterFunctionMember[System.__Canon](Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],ubyte,byref):int:this (FullOpts)
        -578 (-20.32% of base) : 61062.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitCompoundAssignmentOperator(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
        -417 (-7.30% of base) : 231043.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ResolveMetadataReferences(System.__Canon,System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ReferencedAssemblyIdentity[System.__Canon,System.__Canon]]],byref,byref,byref,byref,byref,Microsoft.CodeAnalysis.DiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]]:this (FullOpts)
        -417 (-7.30% of base) : 200826.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ResolveMetadataReferences(System.__Canon,System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ReferencedAssemblyIdentity[System.__Canon,System.__Canon]]],byref,byref,byref,byref,byref,Microsoft.CodeAnalysis.DiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CommonReferenceManager`2+ResolvedReference[System.__Canon,System.__Canon]]:this (FullOpts)
        -407 (-67.61% of base) : 122049.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel:GetSymbolsAndResultKind(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator,byref,byref,byref) (FullOpts)
        -407 (-67.61% of base) : 59372.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel:GetSymbolsAndResultKind(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator,byref,byref,byref) (FullOpts)
        -394 (-32.92% of base) : 220599.dasm - Microsoft.Cci.MetadataWriter:SerializeSequencePoints(System.Reflection.Metadata.StandaloneSignatureHandle,System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.SequencePoint],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,System.Reflection.Metadata.DocumentHandle],byref):System.Reflection.Metadata.BlobHandle:this (FullOpts)
        -394 (-32.92% of base) : 189846.dasm - Microsoft.Cci.MetadataWriter:SerializeSequencePoints(System.Reflection.Metadata.StandaloneSignatureHandle,System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.SequencePoint],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,System.Reflection.Metadata.DocumentHandle],byref):System.Reflection.Metadata.BlobHandle:this (FullOpts)
        -345 (-34.29% of base) : 184803.dasm - System.Reflection.Metadata.ImportDefinitionCollection+Enumerator:MoveNext():ubyte:this (FullOpts)
        -310 (-38.90% of base) : 220625.dasm - Microsoft.Cci.DynamicAnalysisDataWriter:SerializeSpans(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CodeGen.SourceSpan],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,int]):System.Reflection.Metadata.BlobHandle:this (FullOpts)
        -310 (-38.90% of base) : 189873.dasm - Microsoft.Cci.DynamicAnalysisDataWriter:SerializeSpans(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CodeGen.SourceSpan],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,int]):System.Reflection.Metadata.BlobHandle:this (FullOpts)
        -268 (-35.08% of base) : 117647.dasm - Microsoft.CodeAnalysis.Operations.CSharpOperationFactory:CreateBoundCompoundAssignmentOperatorOperation(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator):Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation:this (FullOpts)
        -268 (-35.08% of base) : 54393.dasm - Microsoft.CodeAnalysis.Operations.CSharpOperationFactory:CreateBoundCompoundAssignmentOperatorOperation(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator):Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation:this (FullOpts)
        -266 (-43.11% of base) : 23250.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLengthLessThan4,System.Buffers.StringSearchValuesHelper+CaseSensitive]:GetComparisonResult(byref,ulong,ulong,System.Runtime.Intrinsics.Vector512`1[ushort],System.Runtime.Intrinsics.Vector512`1[ushort],System.Runtime.Intrinsics.Vector512`1[ushort]):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
        -255 (-14.88% of base) : 270362.dasm - System.Security.Principal.WindowsIdentity:AddTokenClaims(System.Collections.Generic.List`1[System.Security.Claims.Claim],int,System.String):this (FullOpts)
        -252 (-16.99% of base) : 55850.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:SplitCases(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DagState,Microsoft.CodeAnalysis.CSharp.BoundDagTest,byref,byref,byref,byref,byref):this (FullOpts)
        -252 (-31.86% of base) : 124642.dasm - Microsoft.CodeAnalysis.CSharp.DiagnosticsPass:CheckCompoundAssignmentOperator(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator):this (FullOpts)
        -252 (-31.86% of base) : 62372.dasm - Microsoft.CodeAnalysis.CSharp.DiagnosticsPass:CheckCompoundAssignmentOperator(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator):this (FullOpts)

Top method regressions (percentages):
        1671 (72.46% of base) : 188413.dasm - System.Speech.Internal.SrgsCompiler.Backend:InitFromBinaryGrammar(System.Speech.Internal.StreamMarshaler):this (FullOpts)
         132 (46.15% of base) : 2489.dasm - System.Guid:op_GreaterThan(System.Guid,System.Guid):ubyte (FullOpts)
         132 (46.15% of base) : 2487.dasm - System.Guid:op_LessThan(System.Guid,System.Guid):ubyte (FullOpts)
         132 (45.67% of base) : 2490.dasm - System.Guid:op_GreaterThanOrEqual(System.Guid,System.Guid):ubyte (FullOpts)
         132 (45.67% of base) : 2488.dasm - System.Guid:op_LessThanOrEqual(System.Guid,System.Guid):ubyte (FullOpts)
         229 (26.50% of base) : 4620.dasm - System.Numerics.Matrix4x4:Transform(System.Numerics.Matrix4x4,System.Numerics.Quaternion):System.Numerics.Matrix4x4 (FullOpts)
          60 (25.64% of base) : 123341.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:SetResult(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,ubyte,System.Nullable`1[ubyte]):this (FullOpts)
          65 (25.59% of base) : 60742.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:CreateLocalFunctionState():Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalFunctionState:this (FullOpts)
          65 (25.59% of base) : 123277.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:CreateLocalFunctionState():Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalFunctionState:this (FullOpts)
          20 (23.26% of base) : 193048.dasm - Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)
          20 (23.26% of base) : 223624.dasm - Microsoft.CodeAnalysis.SyntaxTree:GetMappedLineSpanAndVisibility(Microsoft.CodeAnalysis.Text.TextSpan,byref):Microsoft.CodeAnalysis.FileLinePositionSpan:this (FullOpts)
         188 (23.18% of base) : 186034.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeader(System.Reflection.Metadata.BlobBuilder,System.Reflection.PortableExecutable.PEBuilder+SerializedSection) (FullOpts)
         627 (21.82% of base) : 89338.dasm - System.Security.Cryptography.Pkcs.CmsSigner:Sign(System.ReadOnlyMemory`1[ubyte],System.String,ubyte,byref):System.Security.Cryptography.Pkcs.Asn1.SignerInfoAsn:this (FullOpts)
          48 (21.15% of base) : 132981.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender:ReadNodeOrToken(int,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode:this (FullOpts)
          48 (21.15% of base) : 71428.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender:ReadNodeOrToken(int,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode:this (FullOpts)
          29 (21.01% of base) : 119813.dasm - Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult:BadArgumentConversions(System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.BitVector,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Conversion]):Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult (FullOpts)
          29 (21.01% of base) : 56755.dasm - Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult:BadArgumentConversions(System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.BitVector,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Conversion]):Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult (FullOpts)
         202 (19.57% of base) : 91209.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberSemanticModel:GetCollectionRangeVariableSymbolInfoWorker(Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionRangeVariableSyntax,System.Threading.CancellationToken):Microsoft.CodeAnalysis.VisualBasic.CollectionRangeVariableSymbolInfo:this (FullOpts)
          93 (19.18% of base) : 4664.dasm - System.Numerics.Quaternion:CreateFromRotationMatrix(System.Numerics.Matrix4x4):System.Numerics.Quaternion (FullOpts)
         178 (19.10% of base) : 89376.dasm - System.Security.Cryptography.Pkcs.Rfc3161TimestampTokenInfo:Encode(System.Security.Cryptography.Oid,System.Security.Cryptography.Oid,System.ReadOnlyMemory`1[ubyte],System.ReadOnlyMemory`1[ubyte],System.DateTimeOffset,ubyte,System.Nullable`1[long],System.Nullable`1[System.ReadOnlyMemory`1[ubyte]],System.Nullable`1[System.ReadOnlyMemory`1[ubyte]],System.Security.Cryptography.X509Certificates.X509ExtensionCollection):ubyte[] (FullOpts)

Top method improvements (percentages):
         -47 (-90.38% of base) : 57548.dasm - Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
         -47 (-90.38% of base) : 120506.dasm - Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
         -45 (-90.00% of base) : 268352.dasm - System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)
         -44 (-89.80% of base) : 146224.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_Resolution():ubyte:this (FullOpts)
         -44 (-89.80% of base) : 87404.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_Resolution():ubyte:this (FullOpts)
         -30 (-85.71% of base) : 116748.dasm - Microsoft.CodeAnalysis.VisualBasic.OverloadResolutionResult`1[System.__Canon]:get_Succeeded():ubyte:this (FullOpts)
         -25 (-83.33% of base) : 194334.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (FullOpts)
         -25 (-83.33% of base) : 224862.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (FullOpts)
         -52 (-76.47% of base) : 116744.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberResolutionResult`1[System.__Canon]:get_Resolution():int:this (FullOpts)
         -23 (-71.88% of base) : 161659.dasm - System.Data.SqlTypes.SqlGuid:get_IsNull():ubyte:this (FullOpts)
         -27 (-71.05% of base) : 223199.dasm - Microsoft.CodeAnalysis.LineMapping:get_IsHidden():ubyte:this (FullOpts)
         -27 (-71.05% of base) : 192619.dasm - Microsoft.CodeAnalysis.LineMapping:get_IsHidden():ubyte:this (FullOpts)
         -28 (-70.00% of base) : 266167.dasm - System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
         -28 (-70.00% of base) : 255461.dasm - System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
         -28 (-70.00% of base) : 266183.dasm - System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
         -28 (-70.00% of base) : 255476.dasm - System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
         -30 (-69.77% of base) : 116746.dasm - Microsoft.CodeAnalysis.VisualBasic.MemberResolutionResult`1[System.__Canon]:get_IsExpandedParamArrayForm():ubyte:this (FullOpts)
         -64 (-69.57% of base) : 228116.dasm - Microsoft.CodeAnalysis.SharedInputNodes+<>c:<.cctor>b__7_5(Microsoft.CodeAnalysis.DriverStateTable+Builder):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider]:this (FullOpts)
         -64 (-69.57% of base) : 197866.dasm - Microsoft.CodeAnalysis.SharedInputNodes+<>c:<.cctor>b__7_5(Microsoft.CodeAnalysis.DriverStateTable+Builder):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider]:this (FullOpts)
         -51 (-68.92% of base) : 18568.dasm - System.Runtime.Intrinsics.Vector512`1[double]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.Create(double):System.Runtime.Intrinsics.Vector512`1[double] (FullOpts)

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

Total bytes of base: 61272632 (overridden on cmd)
Total bytes of diff: 61058289 (overridden on cmd)
Total bytes of delta: -214343 (-0.35 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        2279 : 233051.dasm (61.54% of base)
        1802 : 37376.dasm (11.56% of base)
        1768 : 96800.dasm (17.66% of base)
        1497 : 211568.dasm (36.93% of base)
        1118 : 242812.dasm (70.27% of base)
        1072 : 211555.dasm (42.39% of base)
        1034 : 39153.dasm (20.72% of base)
        1015 : 187929.dasm (5.46% of base)
        1015 : 147202.dasm (5.46% of base)
         983 : 71520.dasm (23.72% of base)
         952 : 37969.dasm (22.82% of base)
         949 : 116457.dasm (22.31% of base)
         844 : 39565.dasm (30.36% of base)
         826 : 94660.dasm (22.56% of base)
         674 : 211073.dasm (27.41% of base)
         578 : 37647.dasm (31.31% of base)
         555 : 274258.dasm (50.64% of base)
         551 : 119690.dasm (15.95% of base)
         518 : 34520.dasm (52.70% of base)
         514 : 174895.dasm (28.52% of base)

Top file improvements (bytes):
       -5432 : 135171.dasm (-60.57% of base)
       -1566 : 169184.dasm (-33.45% of base)
       -1555 : 91347.dasm (-59.26% of base)
       -1300 : 289026.dasm (-50.58% of base)
       -1205 : 211567.dasm (-46.36% of base)
        -787 : 169078.dasm (-6.55% of base)
        -626 : 56243.dasm (-9.32% of base)
        -612 : 96358.dasm (-8.10% of base)
        -542 : 56230.dasm (-7.86% of base)
        -538 : 56992.dasm (-12.59% of base)
        -508 : 56993.dasm (-12.14% of base)
        -487 : 118578.dasm (-9.21% of base)
        -478 : 118248.dasm (-10.42% of base)
        -478 : 169473.dasm (-32.65% of base)
        -437 : 120026.dasm (-14.22% of base)
        -428 : 96618.dasm (-14.21% of base)
        -427 : 96426.dasm (-11.04% of base)
        -422 : 145433.dasm (-27.37% of base)
        -422 : 186255.dasm (-27.37% of base)
        -411 : 96566.dasm (-6.40% of base)

93 total files with Code Size differences (56 improved, 37 regressed), 20 unchanged.

Top method regressions (bytes):
        2279 (61.54% of base) : 233051.dasm - System.Speech.Internal.SrgsCompiler.Backend:InitFromBinaryGrammar(System.Speech.Internal.StreamMarshaler):this (FullOpts)
        1802 (11.56% of base) : 37376.dasm - Microsoft.Diagnostics.Tracing.Parsers.ApplicationServerTraceEventParser:.cctor() (FullOpts)
        1768 (17.66% of base) : 96800.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:DecodeModifiers(Microsoft.CodeAnalysis.SyntaxTokenList,int,int,int,Microsoft.CodeAnalysis.DiagnosticBag):Microsoft.CodeAnalysis.VisualBasic.MemberModifiers:this (FullOpts)
        1497 (36.93% of base) : 211568.dasm - System.Data.OleDb.OleDbSchemaGuid:.cctor() (FullOpts)
        1118 (70.27% of base) : 242812.dasm - ILCompiler.Reflection.ReadyToRun.x86.InfoHdrDecoder:DecodeHeader(ubyte[],byref,int):ILCompiler.Reflection.ReadyToRun.x86.InfoHdrSmall (FullOpts)
        1072 (42.39% of base) : 211555.dasm - System.Data.OleDb.OleDbPropertySetGuid:.cctor() (FullOpts)
        1034 (20.72% of base) : 39153.dasm - Microsoft.Diagnostics.Tracing.Parsers.JScriptTraceEventParser:.cctor() (FullOpts)
        1015 ( 5.46% of base) : 187929.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
        1015 ( 5.46% of base) : 147202.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
         983 (23.72% of base) : 71520.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer:RewriteTrivia(Microsoft.CodeAnalysis.SyntaxTriviaList,int,ubyte,ubyte,ubyte,int):Microsoft.CodeAnalysis.SyntaxTriviaList:this (FullOpts)
         952 (22.82% of base) : 37969.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:.cctor() (FullOpts)
         949 (22.31% of base) : 116457.dasm - Microsoft.CodeAnalysis.VisualBasic.Syntax.SyntaxNormalizer:RewriteTrivia(Microsoft.CodeAnalysis.SyntaxTriviaList,int,ubyte,ubyte,ubyte,int,int):Microsoft.CodeAnalysis.SyntaxTriviaList:this (FullOpts)
         844 (30.36% of base) : 39565.dasm - Microsoft.Diagnostics.Tracing.Parsers.KernelTraceEventParser:.cctor() (FullOpts)
         826 (22.56% of base) : 94660.dasm - System.Security.Cryptography.Pkcs.CmsSigner:Sign(System.ReadOnlyMemory`1[ubyte],System.String,ubyte,byref):System.Security.Cryptography.Pkcs.Asn1.SignerInfoAsn:this (FullOpts)
         674 (27.41% of base) : 211073.dasm - System.Data.OleDb.ODB:.cctor() (FullOpts)
         578 (31.31% of base) : 37647.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrPrivateTraceEventParser:.cctor() (FullOpts)
         555 (50.64% of base) : 274258.dasm - System.Diagnostics.SymbolStore.SymLanguageType:.cctor() (FullOpts)
         551 (15.95% of base) : 119690.dasm - Microsoft.CodeAnalysis.VisualBasic.OverloadResolution:CollectOverloadedCandidates(Microsoft.CodeAnalysis.VisualBasic.Binder,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.VisualBasic.OverloadResolution+CandidateAnalysisResult],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.VisualBasic.OverloadResolution+Candidate],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol,Microsoft.CodeAnalysis.VisualBasic.BoundNode,ubyte,ubyte,ubyte,byref,byref) (FullOpts)
         518 (52.70% of base) : 34520.dasm - Microsoft.Diagnostics.Tracing.ETWKernelControl:.cctor() (FullOpts)
         514 (28.52% of base) : 174895.dasm - Microsoft.Build.Construction.SolutionFile:ParseAspNetCompilerProperty(Microsoft.Build.Construction.ProjectInSolution,System.String,System.String) (FullOpts)

Top method improvements (bytes):
       -5432 (-60.57% of base) : 135171.dasm - System.Xml.Xsl.XPathConvert+BigNumber:.cctor() (FullOpts)
       -1566 (-33.45% of base) : 169184.dasm - System.Reflection.Metadata.MetadataReader:InitializeProjectedTypes() (FullOpts)
       -1555 (-59.26% of base) : 91347.dasm - Microsoft.CodeAnalysis.CSharp.ValueSetFactory+DecimalTC:Next(System.Decimal):System.Decimal:this (FullOpts)
       -1300 (-50.58% of base) : 289026.dasm - System.Net.Mail.MailHeaderInfo:.cctor() (FullOpts)
       -1205 (-46.36% of base) : 211567.dasm - System.Data.OleDb.OleDbSchemaGuid:GetTextFromValue(System.Guid):System.String (FullOpts)
        -787 (-6.55% of base) : 169078.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
        -626 (-9.32% of base) : 56243.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckPropertyValueKind(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,ushort,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
        -612 (-8.10% of base) : 96358.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:ReportNoConversionError(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol,Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag,System.String):this (FullOpts)
        -542 (-7.86% of base) : 56230.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckValueKind(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,ushort,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
        -538 (-12.59% of base) : 56992.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GenerateImplicitConversionError(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.ConstantValue) (FullOpts)
        -508 (-12.14% of base) : 56993.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GenerateImplicitConversionError(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Conversion,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):this (FullOpts)
        -487 (-9.21% of base) : 118578.dasm - Microsoft.CodeAnalysis.VisualBasic.IteratorRewriter:EnsureAllSymbolsAndSignature():ubyte:this (FullOpts)
        -478 (-10.42% of base) : 118248.dasm - Microsoft.CodeAnalysis.VisualBasic.AsyncRewriter:EnsureAllSymbolsAndSignature():ubyte:this (FullOpts)
        -478 (-32.65% of base) : 169473.dasm - System.Reflection.Metadata.ImportDefinitionCollection+Enumerator:MoveNext():ubyte:this (FullOpts)
        -437 (-14.22% of base) : 120026.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode:DoGetSyntaxErrors(Microsoft.CodeAnalysis.SyntaxTree,Microsoft.CodeAnalysis.SyntaxNodeOrToken):System.Collections.ObjectModel.ReadOnlyCollection`1[Microsoft.CodeAnalysis.Diagnostic] (FullOpts)
        -428 (-14.21% of base) : 96618.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:ReportUndefinedOperatorError(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.BoundExpression,Microsoft.CodeAnalysis.VisualBasic.BoundExpression,ushort,int,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):this (FullOpts)
        -427 (-11.04% of base) : 96426.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:ReportArrayLiteralInferredTypeDiagnostics(Microsoft.CodeAnalysis.VisualBasic.BoundArrayLiteral,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):this (FullOpts)
        -422 (-27.37% of base) : 145433.dasm - Microsoft.Cci.MetadataWriter:SerializeSequencePoints(System.Reflection.Metadata.StandaloneSignatureHandle,System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.SequencePoint],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,System.Reflection.Metadata.DocumentHandle],byref):System.Reflection.Metadata.BlobHandle:this (FullOpts)
        -422 (-27.37% of base) : 186255.dasm - Microsoft.Cci.MetadataWriter:SerializeSequencePoints(System.Reflection.Metadata.StandaloneSignatureHandle,System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.SequencePoint],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,System.Reflection.Metadata.DocumentHandle],byref):System.Reflection.Metadata.BlobHandle:this (FullOpts)
        -411 (-6.40% of base) : 96566.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:BuildBoundLambdaParameters(Microsoft.CodeAnalysis.VisualBasic.UnboundLambda,Microsoft.CodeAnalysis.VisualBasic.UnboundLambda+TargetSignature,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.BoundLambdaParameterSymbol]:this (FullOpts)

Top method regressions (percentages):
          18 (81.82% of base) : 28374.dasm - System.Diagnostics.Tracing.PropertyValue:.ctor(System.DateTimeOffset):this (FullOpts)
          17 (77.27% of base) : 28376.dasm - System.Diagnostics.Tracing.PropertyValue:.ctor(System.Decimal):this (FullOpts)
        1118 (70.27% of base) : 242812.dasm - ILCompiler.Reflection.ReadyToRun.x86.InfoHdrDecoder:DecodeHeader(ubyte[],byref,int):ILCompiler.Reflection.ReadyToRun.x86.InfoHdrSmall (FullOpts)
          45 (67.16% of base) : 273388.dasm - System.Diagnostics.CounterSample:.cctor() (FullOpts)
          60 (65.93% of base) : 274257.dasm - System.Diagnostics.SymbolStore.SymDocumentType:.cctor() (FullOpts)
          60 (65.93% of base) : 215955.dasm - System.Linq.Expressions.SymbolDocumentInfo:.cctor() (FullOpts)
        2279 (61.54% of base) : 233051.dasm - System.Speech.Internal.SrgsCompiler.Backend:InitFromBinaryGrammar(System.Speech.Internal.StreamMarshaler):this (FullOpts)
         398 (58.88% of base) : 39170.dasm - Microsoft.Diagnostics.Tracing.Parsers.JSDumpHeapTraceEventParser:.cctor() (FullOpts)
         282 (57.32% of base) : 40673.dasm - Microsoft.Diagnostics.Tracing.Parsers.SymbolTraceEventParser:.cctor() (FullOpts)
          55 (57.29% of base) : 274259.dasm - System.Diagnostics.SymbolStore.SymLanguageVendor:.cctor() (FullOpts)
         171 (56.44% of base) : 50254.dasm - Microsoft.Diagnostics.Tracing.Parsers.Clr.ClrStressTraceEventParser:.cctor() (FullOpts)
         108 (55.96% of base) : 151359.dasm - Microsoft.CodeAnalysis.Text.SourceHashAlgorithms:.cctor() (FullOpts)
         108 (55.96% of base) : 192023.dasm - Microsoft.CodeAnalysis.Text.SourceHashAlgorithms:.cctor() (FullOpts)
         166 (53.90% of base) : 45796.dasm - Microsoft.Diagnostics.Tracing.Parsers.Kernel.HeapTraceProviderTraceEventParser:.cctor() (FullOpts)
         518 (52.70% of base) : 34520.dasm - Microsoft.Diagnostics.Tracing.ETWKernelControl:.cctor() (FullOpts)
         555 (50.64% of base) : 274258.dasm - System.Diagnostics.SymbolStore.SymLanguageType:.cctor() (FullOpts)
         108 (50.00% of base) : 50767.dasm - Microsoft.Diagnostics.Tracing.Parsers.AspNet.AspNetTraceEventParser:.cctor() (FullOpts)
         108 (50.00% of base) : 45880.dasm - Microsoft.Diagnostics.Tracing.Parsers.Kernel.CritSecTraceProviderTraceEventParser:.cctor() (FullOpts)
         108 (50.00% of base) : 45724.dasm - Microsoft.Diagnostics.Tracing.Parsers.Kernel.ThreadPoolTraceEventParser:.cctor() (FullOpts)
         108 (50.00% of base) : 39595.dasm - Microsoft.Diagnostics.Tracing.Parsers.LinuxKernelEventParser:.cctor() (FullOpts)

Top method improvements (percentages):
         -34 (-87.18% of base) : 273393.dasm - System.Diagnostics.InstanceData:get_RawValue():long:this (FullOpts)
         -33 (-86.84% of base) : 59265.dasm - Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
         -25 (-86.21% of base) : 201924.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[int,System.Nullable`1[int]]:get_Current():int:this (FullOpts)
         -25 (-86.21% of base) : 174052.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[int,System.Nullable`1[int]]:get_Current():int:this (FullOpts)
         -25 (-86.21% of base) : 161509.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[int,System.Nullable`1[int]]:get_Current():int:this (FullOpts)
         -28 (-84.85% of base) : 180777.dasm - Microsoft.Build.Evaluation.ProfilerResultPrettyPrinter+<>c:<GetContent>b__2_1(System.Collections.Generic.KeyValuePair`2[Microsoft.Build.Framework.Profiler.EvaluationLocation,Microsoft.Build.Framework.Profiler.ProfiledLocation]):ubyte:this (FullOpts)
         -28 (-84.85% of base) : 180720.dasm - Microsoft.Build.Logging.ProfilerLogger+<>c:<GetAggregatedResult>b__18_2(System.Collections.Generic.KeyValuePair`2[Microsoft.Build.Framework.Profiler.EvaluationLocation,Microsoft.Build.Framework.Profiler.ProfiledLocation]):long:this (FullOpts)
         -27 (-84.38% of base) : 192240.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (FullOpts)
         -27 (-84.38% of base) : 151573.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (FullOpts)
         -25 (-83.33% of base) : 174045.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[ubyte,System.Nullable`1[int]]:get_Current():ubyte:this (FullOpts)
         -25 (-83.33% of base) : 201917.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[ubyte,System.Nullable`1[int]]:get_Current():ubyte:this (FullOpts)
         -25 (-83.33% of base) : 161502.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[ubyte,System.Nullable`1[int]]:get_Current():ubyte:this (FullOpts)
         -25 (-80.65% of base) : 161508.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[short,System.Nullable`1[int]]:get_Current():short:this (FullOpts)
         -25 (-80.65% of base) : 201923.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[short,System.Nullable`1[int]]:get_Current():short:this (FullOpts)
         -25 (-80.65% of base) : 174051.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[short,System.Nullable`1[int]]:get_Current():short:this (FullOpts)
         -20 (-80.00% of base) : 200389.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Enumerator[System.__Canon,System.Nullable`1[int]]:System.Collections.IDictionaryEnumerator.get_Key():System.Object:this (FullOpts)
         -20 (-80.00% of base) : 159971.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Enumerator[System.__Canon,System.Nullable`1[int]]:System.Collections.IDictionaryEnumerator.get_Key():System.Object:this (FullOpts)
         -20 (-80.00% of base) : 173285.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Enumerator[System.__Canon,System.Nullable`1[int]]:System.Collections.IDictionaryEnumerator.get_Key():System.Object:this (FullOpts)
         -20 (-80.00% of base) : 174055.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[long,System.Nullable`1[int]]:get_Current():long:this (FullOpts)
         -20 (-80.00% of base) : 201927.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+KeyCollection+Enumerator[long,System.Nullable`1[int]]:get_Current():long:this (FullOpts)

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

Total bytes of base: 284463335 (overridden on cmd)
Total bytes of diff: 284197406 (overridden on cmd)
Total bytes of delta: -265929 (-0.09 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        3183 : 226121.dasm (74.68% of base)
        2290 : 122731.dasm (42.23% of base)
        2166 : 655419.dasm (59.95% of base)
        1924 : 95233.dasm (14.57% of base)
        1896 : 59291.dasm (15.29% of base)
        1146 : 394540.dasm (28.72% of base)
        1134 : 655886.dasm (11.35% of base)
        1125 : 67249.dasm (26.38% of base)
        1083 : 185575.dasm (7.77% of base)
        1014 : 34180.dasm (9.92% of base)
         950 : 95077.dasm (22.55% of base)
         943 : 59290.dasm (7.33% of base)
         937 : 95319.dasm (11.51% of base)
         903 : 67322.dasm (8.21% of base)
         837 : 648272.dasm (14.32% of base)
         812 : 642155.dasm (10.39% of base)
         773 : 62850.dasm (25.27% of base)
         752 : 58216.dasm (17.10% of base)
         699 : 226189.dasm (43.39% of base)
         686 : 239185.dasm (46.76% of base)

Top file improvements (bytes):
       -2759 : 54954.dasm (-30.68% of base)
       -2643 : 635626.dasm (-30.51% of base)
       -2405 : 92607.dasm (-30.92% of base)
       -1689 : 89025.dasm (-9.58% of base)
       -1661 : 633319.dasm (-9.36% of base)
       -1655 : 111629.dasm (-9.33% of base)
       -1655 : 184112.dasm (-9.33% of base)
       -1646 : 658251.dasm (-15.79% of base)
       -1569 : 50975.dasm (-8.96% of base)
       -1080 : 535650.dasm (-8.54% of base)
       -1041 : 384525.dasm (-6.22% of base)
        -979 : 405962.dasm (-7.79% of base)
        -923 : 85486.dasm (-3.78% of base)
        -885 : 340438.dasm (-5.24% of base)
        -870 : 94431.dasm (-36.66% of base)
        -827 : 655271.dasm (-21.36% of base)
        -806 : 61777.dasm (-16.45% of base)
        -757 : 539532.dasm (-6.33% of base)
        -734 : 635686.dasm (-6.13% of base)
        -731 : 58824.dasm (-3.20% of base)

88 total files with Code Size differences (53 improved, 35 regressed), 20 unchanged.

Top method regressions (bytes):
        3183 (74.68% of base) : 226121.dasm - System.Collections.Immutable.ImmutableHashSet`1[ulong]:Union(System.Collections.Generic.IEnumerable`1[ulong],System.Collections.Immutable.ImmutableHashSet`1+MutationInput[ulong]):System.Collections.Immutable.ImmutableHashSet`1+MutationResult[ulong] (Tier1-OSR)
        2290 (42.23% of base) : 122731.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory:TryCreateEnumerable(Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite:this (Tier1)
        2166 (59.95% of base) : 655419.dasm - Microsoft.Cci.MetadataWriter:SerializeSequencePoints(System.Reflection.Metadata.StandaloneSignatureHandle,System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.SequencePoint],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,System.Reflection.Metadata.DocumentHandle],byref):System.Reflection.Metadata.BlobHandle:this (Tier1-OSR)
        1924 (14.57% of base) : 95233.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:CheckValidNullableMethodOverride[System.__Canon](Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType`1[System.__Canon],System.__Canon,ubyte):ubyte (Tier1)
        1896 (15.29% of base) : 59291.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:CheckValidNullableMethodOverride[System.ValueTuple`2[System.__Canon,ubyte]](Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType`1[System.ValueTuple`2[System.__Canon,ubyte]],Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType`1[System.ValueTuple`2[System.__Canon,ubyte]],System.ValueTuple`2[System.__Canon,ubyte],ubyte):ubyte (Tier1)
        1146 (28.72% of base) : 394540.dasm - System.Net.NetworkInformation.StringParsingHelpers:ParseInterfaceStatisticsTableFromFile(System.String,System.String):System.Net.NetworkInformation.IPInterfaceStatisticsTable (Tier0-FullOpts)
        1134 (11.35% of base) : 655886.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:BindAttributes(Roslyn.Utilities.OneOrMany`1[Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax]],Microsoft.CodeAnalysis.CSharp.Binder):System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.CSharp.BoundAttribute]]:this (Tier1)
        1125 (26.38% of base) : 67249.dasm - Microsoft.Interop.SyntaxExtensions:AddStatementWithoutEmptyStatements(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax):Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax (Tier1)
        1083 ( 7.77% of base) : 185575.dasm - Microsoft.CodeAnalysis.CSharp.Binder:TryPerformConstructorOverloadResolution(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.String,Microsoft.CodeAnalysis.Location,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref,byref,ubyte,ubyte):ubyte:this (Tier1)
        1014 ( 9.92% of base) : 34180.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Instrumented Tier1)
         950 (22.55% of base) : 95077.dasm - Microsoft.Interop.SyntaxExtensions:AddStatementWithoutEmptyStatements(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax):Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax (Tier1)
         943 ( 7.33% of base) : 59290.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:<CheckModifierMismatchOnImplementingMember>g__checkMethodOverride|100_0(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,ubyte,ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (Tier1)
         937 (11.51% of base) : 95319.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:BindAttributes(Roslyn.Utilities.OneOrMany`1[Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax]],Microsoft.CodeAnalysis.CSharp.Binder):System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.CSharp.BoundAttribute]]:this (Tier1)
         903 ( 8.21% of base) : 67322.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolBase:EarlyDecodeWellKnownAttribute(byref):System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.CSharp.BoundAttribute]:this (Tier1)
         837 (14.32% of base) : 648272.dasm - Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer:MergeOrRemoveCandidates(System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Collections.Generic.HashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Predicate`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.ConversionsBase,short,byref) (Tier1)
         812 (10.39% of base) : 642155.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindSimpleBinaryOperator(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
         773 (25.27% of base) : 62850.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte,ubyte) (Tier1)
         752 (17.10% of base) : 58216.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol:CheckMembers(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol,System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol]],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (Tier1)
         699 (43.39% of base) : 226189.dasm - System.Collections.Immutable.ImmutableHashSet`1[int]:Union(System.Collections.Generic.IEnumerable`1[int],System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]):System.Collections.Immutable.ImmutableHashSet`1+MutationResult[int] (Tier1-OSR)
         686 (46.76% of base) : 239185.dasm - System.Collections.Generic.SortedSet`1[int]:IsSupersetOf(System.Collections.Generic.IEnumerable`1[int]):ubyte:this (Tier1)

Top method improvements (bytes):
       -2759 (-30.68% of base) : 54954.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:ValidateAttributeUsageAndDecodeWellKnownAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,short):Microsoft.CodeAnalysis.WellKnownAttributeData:this (Tier1)
       -2643 (-30.51% of base) : 635626.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:ValidateAttributeUsageAndDecodeWellKnownAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,short):Microsoft.CodeAnalysis.WellKnownAttributeData:this (Tier1)
       -2405 (-30.92% of base) : 92607.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:ValidateAttributeUsageAndDecodeWellKnownAttributes(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Binder],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,short):Microsoft.CodeAnalysis.WellKnownAttributeData:this (Tier1)
       -1689 (-9.58% of base) : 89025.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
       -1661 (-9.36% of base) : 633319.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
       -1655 (-9.33% of base) : 111629.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
       -1655 (-9.33% of base) : 184112.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
       -1646 (-15.79% of base) : 658251.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:VisitSwitchStatement(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
       -1569 (-8.96% of base) : 50975.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
       -1080 (-8.54% of base) : 535650.dasm - System.Formats.Asn1.WellKnownOids:GetContents(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ubyte] (Tier1)
       -1041 (-6.22% of base) : 384525.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        -979 (-7.79% of base) : 405962.dasm - System.Formats.Asn1.WellKnownOids:GetContents(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ubyte] (Tier1)
        -923 (-3.78% of base) : 85486.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:AddNonTypeMembers(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+DeclaredMembersAndInitializersBuilder,Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
        -885 (-5.24% of base) : 340438.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        -870 (-36.66% of base) : 94431.dasm - Microsoft.Interop.SyntaxExtensions:AddToModifiers(Microsoft.CodeAnalysis.SyntaxTokenList,ushort):Microsoft.CodeAnalysis.SyntaxTokenList (Tier1)
        -827 (-21.36% of base) : 655271.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:ForEachNfaState[System.ValueTuple`2[System.__Canon,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+Registers[ulong]]](System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],uint,System.ValueTuple`2[System.__Canon,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+Registers[ulong]],System.Action`2[int,System.ValueTuple`2[System.__Canon,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+Registers[ulong]]]):this (Tier1)
        -806 (-16.45% of base) : 61777.dasm - Microsoft.Interop.VtableIndexStubGenerator:GetDiagnosticIfInvalidMethodForGeneration(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax,Microsoft.CodeAnalysis.IMethodSymbol):Microsoft.CodeAnalysis.Diagnostic (Tier1)
        -757 (-6.33% of base) : 539532.dasm - System.Formats.Asn1.WellKnownOids:GetContents(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ubyte] (Tier1)
        -734 (-6.13% of base) : 635686.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<VisitArguments>g__visitArguments|232_0(Microsoft.CodeAnalysis.CSharp.BoundNode,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Conversion],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitResult],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.BitVector,ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,ubyte):System.ValueTuple`4[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitResult],ubyte,Microsoft.CodeAnalysis.CSharp.NullableWalker+ArgumentsCompletionDelegate]:this (Tier1)
        -731 (-3.20% of base) : 58824.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:AddNonTypeMembers(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+DeclaredMembersAndInitializersBuilder,Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)

Top method regressions (percentages):
        3183 (74.68% of base) : 226121.dasm - System.Collections.Immutable.ImmutableHashSet`1[ulong]:Union(System.Collections.Generic.IEnumerable`1[ulong],System.Collections.Immutable.ImmutableHashSet`1+MutationInput[ulong]):System.Collections.Immutable.ImmutableHashSet`1+MutationResult[ulong] (Tier1-OSR)
          61 (64.21% of base) : 357457.dasm - System.Linq.OrderedEnumerable`1[int]:Fill(int[],System.Span`1[int]):this (Tier1-OSR)
          61 (64.21% of base) : 358764.dasm - System.Linq.OrderedEnumerable`1[int]:Fill(int[],System.Span`1[int]):this (Tier1-OSR)
         559 (62.11% of base) : 239231.dasm - System.Collections.Generic.SortedSet`1[int]:SymmetricExceptWithSameComparer(System.Collections.Generic.SortedSet`1[int]):this (Tier1)
        2166 (59.95% of base) : 655419.dasm - Microsoft.Cci.MetadataWriter:SerializeSequencePoints(System.Reflection.Metadata.StandaloneSignatureHandle,System.Collections.Immutable.ImmutableArray`1[Microsoft.Cci.SequencePoint],System.Collections.Generic.Dictionary`2[Microsoft.Cci.DebugSourceDocument,System.Reflection.Metadata.DocumentHandle],byref):System.Reflection.Metadata.BlobHandle:this (Tier1-OSR)
         686 (46.76% of base) : 239185.dasm - System.Collections.Generic.SortedSet`1[int]:IsSupersetOf(System.Collections.Generic.IEnumerable`1[int]):ubyte:this (Tier1)
         699 (43.39% of base) : 226189.dasm - System.Collections.Immutable.ImmutableHashSet`1[int]:Union(System.Collections.Generic.IEnumerable`1[int],System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]):System.Collections.Immutable.ImmutableHashSet`1+MutationResult[int] (Tier1-OSR)
        2290 (42.23% of base) : 122731.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory:TryCreateEnumerable(Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite:this (Tier1)
         367 (38.55% of base) : 239668.dasm - System.Collections.Generic.SortedSet`1+TreeSubSet[int]:InternalIndexOf(int):int:this (Tier1)
         391 (30.43% of base) : 92641.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:GetModifiers(Microsoft.CodeAnalysis.SyntaxTokenList,byref,byref,byref,byref):ubyte (Tier1)
         170 (29.82% of base) : 186056.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:UseRvalueOnly(Microsoft.CodeAnalysis.CSharp.BoundExpression):this (Tier1)
         287 (29.38% of base) : 469940.dasm - System.Reflection.Metadata.Ecma335.MetadataBuilder:SerializeLocalScopeTable(System.Reflection.Metadata.BlobBuilder,System.Reflection.Metadata.Ecma335.MetadataSizes):this (Tier1-OSR)
         536 (28.72% of base) : 366477.dasm - System.SpanTests.SpanTests:DefaultFilledIndexOfMany_Byte() (Tier1-OSR)
        1146 (28.72% of base) : 394540.dasm - System.Net.NetworkInformation.StringParsingHelpers:ParseInterfaceStatisticsTableFromFile(System.String,System.String):System.Net.NetworkInformation.IPInterfaceStatisticsTable (Tier0-FullOpts)
        1125 (26.38% of base) : 67249.dasm - Microsoft.Interop.SyntaxExtensions:AddStatementWithoutEmptyStatements(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax):Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax (Tier1)
         773 (25.27% of base) : 62850.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte,ubyte) (Tier1)
         245 (23.93% of base) : 660242.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeaders(System.Reflection.Metadata.BlobBuilder,System.Collections.Immutable.ImmutableArray`1[System.Reflection.PortableExecutable.PEBuilder+SerializedSection]) (Tier1)
         172 (23.21% of base) : 654973.dasm - System.Collections.Generic.ArraySortHelper`1[Microsoft.Cci.LocalScope]:InsertionSort(System.Span`1[Microsoft.Cci.LocalScope],System.Comparison`1[Microsoft.Cci.LocalScope]) (Tier1)
         279 (22.89% of base) : 65668.dasm - System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.SyntaxTrivia,System.__Canon]:TryGetValue(Microsoft.CodeAnalysis.SyntaxTrivia,byref):ubyte:this (Tier1)
         950 (22.55% of base) : 95077.dasm - Microsoft.Interop.SyntaxExtensions:AddStatementWithoutEmptyStatements(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax):Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax (Tier1)

Top method improvements (percentages):
         -33 (-86.84% of base) : 54878.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_Resolution():ubyte:this (Tier1)
         -27 (-84.38% of base) : 65520.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:get_IsSingleFileAnalysis():ubyte:this (Tier1)
         -33 (-67.35% of base) : 54150.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (Tier1)
         -68 (-67.33% of base) : 122442.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache:None(System.Type):Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache (Tier1)
         -40 (-65.57% of base) : 373237.dasm - System.MemoryExtensions:EnumerateRunes(System.ReadOnlySpan`1[ushort]):System.Text.SpanRuneEnumerator (Instrumented Tier1)
         -35 (-64.81% of base) : 100461.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,ulong):System.Nullable`1[System.Decimal] (FullOpts)
         -84 (-62.22% of base) : 599103.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_64(System.Object):System.Decimal[]:this (Tier1)
         -84 (-62.22% of base) : 599104.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_66(System.Object):ubyte[]:this (Tier1)
         -84 (-62.22% of base) : 599105.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_68(System.Object):ubyte[]:this (Tier1)
         -35 (-61.40% of base) : 100435.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,uint):System.Nullable`1[System.Decimal] (FullOpts)
         -81 (-61.36% of base) : 599080.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_18(System.Object):System.String:this (Tier1)
         -81 (-61.36% of base) : 599092.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_42(System.Object):System.Text.Json.Serialization.Tests.SimpleTestClass:this (Tier1)
         -81 (-61.36% of base) : 599093.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_44(System.Object):short[]:this (Tier1)
         -81 (-61.36% of base) : 599094.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_46(System.Object):int[]:this (Tier1)
         -81 (-61.36% of base) : 599095.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_48(System.Object):long[]:this (Tier1)
         -81 (-61.36% of base) : 599096.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_50(System.Object):ushort[]:this (Tier1)
         -81 (-61.36% of base) : 599097.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_52(System.Object):uint[]:this (Tier1)
         -81 (-61.36% of base) : 599098.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_54(System.Object):ulong[]:this (Tier1)
         -81 (-61.36% of base) : 599099.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_56(System.Object):ubyte[]:this (Tier1)
         -81 (-61.36% of base) : 599100.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata+<>c:<SimpleTestStructPropInit>b__959_58(System.Object):byte[]:this (Tier1)

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

Total bytes of base: 135664861 (overridden on cmd)
Total bytes of diff: 135468591 (overridden on cmd)
Total bytes of delta: -196270 (-0.14 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        3557 : 51522.dasm (35.23% of base)
        3557 : 45699.dasm (35.23% of base)
        1497 : 100622.dasm (36.93% of base)
        1146 : 162046.dasm (28.87% of base)
        1072 : 100587.dasm (42.39% of base)
        1015 : 20703.dasm (5.46% of base)
         952 : 105073.dasm (22.82% of base)
         893 : 9510.dasm (22.37% of base)
         844 : 104885.dasm (30.36% of base)
         810 : 230206.dasm (22.59% of base)
         719 : 23365.dasm (7.74% of base)
         676 : 152701.dasm (30.19% of base)
         674 : 100382.dasm (27.41% of base)
         628 : 153230.dasm (21.80% of base)
         562 : 153232.dasm (16.73% of base)
         555 : 104039.dasm (50.64% of base)
         546 : 4608.dasm (13.40% of base)
         518 : 104815.dasm (52.70% of base)
         494 : 169229.dasm (4.38% of base)
         468 : 281603.dasm (6.15% of base)

Top file improvements (bytes):
       -4125 : 213683.dasm (-41.86% of base)
       -2593 : 318819.dasm (-23.29% of base)
       -2566 : 318690.dasm (-30.92% of base)
       -2195 : 318702.dasm (-24.97% of base)
       -2136 : 93953.dasm (-7.46% of base)
       -2065 : 213804.dasm (-37.40% of base)
       -1747 : 318520.dasm (-29.75% of base)
       -1663 : 93948.dasm (-5.64% of base)
       -1641 : 166761.dasm (-40.97% of base)
       -1641 : 158726.dasm (-40.97% of base)
       -1419 : 197309.dasm (-32.17% of base)
       -1370 : 148740.dasm (-36.04% of base)
       -1338 : 149001.dasm (-35.73% of base)
       -1300 : 160629.dasm (-50.58% of base)
       -1164 : 207972.dasm (-13.89% of base)
       -1097 : 197326.dasm (-8.12% of base)
        -889 : 161412.dasm (-41.18% of base)
        -797 : 14789.dasm (-12.05% of base)
        -787 : 4818.dasm (-6.55% of base)
        -748 : 308626.dasm (-13.14% of base)

94 total files with Code Size differences (53 improved, 41 regressed), 20 unchanged.

Top method regressions (bytes):
        3557 (35.23% of base) : 51522.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte) (FullOpts)
        3557 (35.23% of base) : 45699.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:CheckParameterModifiers(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte) (FullOpts)
        1497 (36.93% of base) : 100622.dasm - System.Data.OleDb.OleDbSchemaGuid:.cctor() (FullOpts)
        1146 (28.87% of base) : 162046.dasm - System.Net.NetworkInformation.StringParsingHelpers:ParseInterfaceStatisticsTableFromFile(System.String,System.String):System.Net.NetworkInformation.IPInterfaceStatisticsTable (FullOpts)
        1072 (42.39% of base) : 100587.dasm - System.Data.OleDb.OleDbPropertySetGuid:.cctor() (FullOpts)
        1015 ( 5.46% of base) : 20703.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
         952 (22.82% of base) : 105073.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:.cctor() (FullOpts)
         893 (22.37% of base) : 9510.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer:RewriteTrivia(Microsoft.CodeAnalysis.SyntaxTriviaList,int,ubyte,ubyte,ubyte,int):Microsoft.CodeAnalysis.SyntaxTriviaList:this (FullOpts)
         844 (30.36% of base) : 104885.dasm - Microsoft.Diagnostics.Tracing.Parsers.KernelTraceEventParser:.cctor() (FullOpts)
         810 (22.59% of base) : 230206.dasm - System.Security.Cryptography.Pkcs.CmsSigner:Sign(System.ReadOnlyMemory`1[ubyte],System.String,ubyte,byref):System.Security.Cryptography.Pkcs.Asn1.SignerInfoAsn:this (FullOpts)
         719 ( 7.74% of base) : 23365.dasm - Microsoft.CodeAnalysis.FindSymbols.DependentTypeFinder+ProjectIndex+<CreateIndexAsync>d__8:MoveNext():this (FullOpts)
         676 (30.19% of base) : 152701.dasm - System.Buffers.Binary.Tests.BinaryReaderUnitTests:ReadingStructFieldByFieldOrReadAndReverseEndianness():this (FullOpts)
         674 (27.41% of base) : 100382.dasm - System.Data.OleDb.ODB:.cctor() (FullOpts)
         628 (21.80% of base) : 153230.dasm - System.Memory.Tests.SequenceReader.Rewind:Rewind_Full():this (FullOpts)
         562 (16.73% of base) : 153232.dasm - System.Memory.Tests.SequenceReader.Rewind:Rewind_ByOne():this (FullOpts)
         555 (50.64% of base) : 104039.dasm - System.Diagnostics.SymbolStore.SymLanguageType:.cctor() (FullOpts)
         546 (13.40% of base) : 4608.dasm - Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder:VisitTypeDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration:this (FullOpts)
         518 (52.70% of base) : 104815.dasm - Microsoft.Diagnostics.Tracing.ETWKernelControl:.cctor() (FullOpts)
         494 ( 4.38% of base) : 169229.dasm - System.Numerics.Tests.Matrix4x4Tests:Matrix4x4EqualsNaNTest():this (FullOpts)
         468 ( 6.15% of base) : 281603.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:ConvertToSymbolicRegexNode(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.Text.RegularExpressions.Symbolic.BDD]:this (FullOpts)

Top method improvements (bytes):
       -4125 (-41.86% of base) : 213683.dasm - System.Tests.GuidTests+<CompareTo_TestData>d__23:MoveNext():ubyte:this (FullOpts)
       -2593 (-23.29% of base) : 318819.dasm - System.Tests.ValueTupleTests:EightTuples() (FullOpts)
       -2566 (-30.92% of base) : 318690.dasm - System.Tests.ValueTupleTests:SixTuples() (FullOpts)
       -2195 (-24.97% of base) : 318702.dasm - System.Tests.ValueTupleTests:SevenTuples() (FullOpts)
       -2136 (-7.46% of base) : 93953.dasm - System.Tests.GNOMETerminalData+<get_RecordedScenarios>d__9:MoveNext():ubyte:this (FullOpts)
       -2065 (-37.40% of base) : 213804.dasm - System.Tests.GuidTests+<Equals_TestData>d__26:MoveNext():ubyte:this (FullOpts)
       -1747 (-29.75% of base) : 318520.dasm - System.Tests.ValueTupleTests:FiveTuples() (FullOpts)
       -1663 (-5.64% of base) : 93948.dasm - System.Tests.XTermData+<get_RecordedScenarios>d__9:MoveNext():ubyte:this (FullOpts)
       -1641 (-40.97% of base) : 166761.dasm - System.Net.Test.Common.Http2LoopbackConnection:.cctor() (FullOpts)
       -1641 (-40.97% of base) : 158726.dasm - System.Net.Test.Common.Http2LoopbackConnection:.cctor() (FullOpts)
       -1419 (-32.17% of base) : 197309.dasm - System.Runtime.InteropServices.Tests.GetObjectForNativeVariantTests+<GetObjectForNativeVariant_CantMap_ThrowsArgumentException_Data>d__68:MoveNext():ubyte:this (FullOpts)
       -1370 (-36.04% of base) : 148740.dasm - System.Linq.Tests.MaxTests+<Max_NullableDecimal_TestData>d__43:MoveNext():ubyte:this (FullOpts)
       -1338 (-35.73% of base) : 149001.dasm - System.Linq.Tests.MinTests+<Min_NullableDecimal_TestData>d__37:MoveNext():ubyte:this (FullOpts)
       -1300 (-50.58% of base) : 160629.dasm - System.Net.Mail.MailHeaderInfo:.cctor() (FullOpts)
       -1164 (-13.89% of base) : 207972.dasm - System.Runtime.Serialization.Schema.Tests.ImporterTests+<Import_NegativeCases_MemberData>d__10:MoveNext():ubyte:this (FullOpts)
       -1097 (-8.12% of base) : 197326.dasm - System.Runtime.InteropServices.Tests.GetObjectForNativeVariantTests+<GetObjectForNativeVariant_PrimitivesByRef_TestData>d__81:MoveNext():ubyte:this (FullOpts)
        -889 (-41.18% of base) : 161412.dasm - System.Net.Mail.MailHeaderInfo:.cctor() (FullOpts)
        -797 (-12.05% of base) : 14789.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:ReportDiagnostics[System.__Canon](Microsoft.CodeAnalysis.CSharp.Binder,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,System.String,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.Collections.Immutable.ImmutableArray`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,ubyte,System.Nullable`1[ubyte],Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):this (FullOpts)
        -787 (-6.55% of base) : 4818.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
        -748 (-13.14% of base) : 308626.dasm - System.Text.RegularExpressions.RegexNode:ValidateFinalTreeInvariants():this (FullOpts)

Top method regressions (percentages):
          84 (164.71% of base) : 4463.dasm - Microsoft.CodeAnalysis.Host.WorkspaceConfigurationOptions:.cctor() (FullOpts)
         102 (77.86% of base) : 194407.dasm - System.Drawing.DrawingCom:.cctor() (FullOpts)
          45 (67.16% of base) : 102723.dasm - System.Diagnostics.CounterSample:.cctor() (FullOpts)
          60 (65.93% of base) : 104045.dasm - System.Diagnostics.SymbolStore.SymDocumentType:.cctor() (FullOpts)
          60 (65.93% of base) : 205194.dasm - System.Drawing.DrawingCom+IPicture:.cctor() (FullOpts)
         282 (57.32% of base) : 104899.dasm - Microsoft.Diagnostics.Tracing.Parsers.SymbolTraceEventParser:.cctor() (FullOpts)
          55 (57.29% of base) : 103990.dasm - System.Diagnostics.SymbolStore.SymLanguageVendor:.cctor() (FullOpts)
         108 (55.96% of base) : 281883.dasm - Microsoft.CodeAnalysis.Text.SourceHashAlgorithms:.cctor() (FullOpts)
         518 (52.70% of base) : 104815.dasm - Microsoft.Diagnostics.Tracing.ETWKernelControl:.cctor() (FullOpts)
         555 (50.64% of base) : 104039.dasm - System.Diagnostics.SymbolStore.SymLanguageType:.cctor() (FullOpts)
         203 (50.50% of base) : 19463.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[Microsoft.Interop.TargetFrameworkSettings]:Matches(Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[Microsoft.Interop.TargetFrameworkSettings],System.Collections.Generic.IEqualityComparer`1[Microsoft.Interop.TargetFrameworkSettings]):ubyte:this (FullOpts)
          59 (49.58% of base) : 95113.dasm - System.Data.SqlTypes.SqlDecimal:.cctor() (FullOpts)
         439 (43.34% of base) : 170839.dasm - System.Numerics.Tests.Matrix3x2Tests:Matrix3x2CreateSkewYTest():this (FullOpts)
        1072 (42.39% of base) : 100587.dasm - System.Data.OleDb.OleDbPropertySetGuid:.cctor() (FullOpts)
         432 (42.02% of base) : 170788.dasm - System.Numerics.Tests.Matrix3x2Tests:Matrix3x2CreateSkewXTest():this (FullOpts)
         455 (40.62% of base) : 170922.dasm - System.Numerics.Tests.Matrix3x2Tests:Matrix3x2CreateScaleCenterTest2():this (FullOpts)
          63 (40.13% of base) : 100606.dasm - System.Data.OleDb.OleDbComWrappers:.cctor() (FullOpts)
         209 (38.35% of base) : 170799.dasm - System.Numerics.Tests.Matrix3x2Tests:Matrix3x2InvertIdentityTest():this (FullOpts)
         447 (37.25% of base) : 170734.dasm - System.Numerics.Tests.Matrix3x2Tests:Matrix3x2CreateSkewCenterTest():this (FullOpts)
         426 (37.08% of base) : 170812.dasm - System.Numerics.Tests.Matrix3x2Tests:Matrix3x2CreateScaleCenterTest1():this (FullOpts)

Top method improvements (percentages):
         -23 (-82.14% of base) : 188221.dasm - System.Reflection.TypeLoading.RoDefinitionConstructor`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
         -23 (-82.14% of base) : 187449.dasm - System.Reflection.TypeLoading.RoDefinitionMethod`1[System.Reflection.TypeLoading.Ecma.EcmaMethodDecoder]:GetRoModule():System.Reflection.TypeLoading.RoModule:this (FullOpts)
        -174 (-77.68% of base) : 279085.dasm - System.Text.Json.Nodes.Tests.OperatorTests:ExplicitOperators_FromNullValues() (FullOpts)
         -31 (-68.89% of base) : 22483.dasm - NuGet.Packaging.Signing.SignatureTrustAndValidityVerificationProvider:IsSignatureExpired(NuGet.Packaging.Signing.SignatureVerificationSummary):ubyte (FullOpts)
         -33 (-67.35% of base) : 6629.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
         -31 (-65.96% of base) : 51078.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
         -31 (-65.96% of base) : 45139.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
         -35 (-64.81% of base) : 28270.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,ulong):System.Nullable`1[System.Decimal] (FullOpts)
         -23 (-63.89% of base) : 101964.dasm - System.Diagnostics.Tests.ActivitySourceTests+<>c__DisplayClass13_0:<TestActivityContextIsRemote>b__2(byref):int:this (FullOpts)
         -84 (-62.22% of base) : 249703.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_64(System.Object):System.Decimal[]:this (FullOpts)
         -84 (-62.22% of base) : 249704.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_66(System.Object):ubyte[]:this (FullOpts)
         -84 (-62.22% of base) : 249705.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_68(System.Object):ubyte[]:this (FullOpts)
         -49 (-62.03% of base) : 9200.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisScope:ShouldAnalyze(Microsoft.CodeAnalysis.SyntaxTree):ubyte:this (FullOpts)
         -35 (-61.40% of base) : 28243.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,uint):System.Nullable`1[System.Decimal] (FullOpts)
         -81 (-61.36% of base) : 249697.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_52(System.Object):uint[]:this (FullOpts)
         -81 (-61.36% of base) : 249698.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_54(System.Object):ulong[]:this (FullOpts)
         -81 (-61.36% of base) : 249699.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_56(System.Object):ubyte[]:this (FullOpts)
         -81 (-61.36% of base) : 249700.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_58(System.Object):byte[]:this (FullOpts)
         -81 (-61.36% of base) : 249701.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_60(System.Object):ushort[]:this (FullOpts)
         -81 (-61.36% of base) : 249702.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default+<>c:<SimpleTestStructPropInit>b__379_62(System.Object):System.String[]:this (FullOpts)

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

Total bytes of base: 13687708 (overridden on cmd)
Total bytes of diff: 13617607 (overridden on cmd)
Total bytes of delta: -70101 (-0.51 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1185 : 1078.dasm (7.42% of base)
        1166 : 1076.dasm (9.70% of base)
         465 : 19240.dasm (16.61% of base)
         459 : 1058.dasm (3.08% of base)
         422 : 26784.dasm (11.34% of base)
         372 : 20843.dasm (9.58% of base)
         297 : 1016.dasm (7.75% of base)
         220 : 17736.dasm (21.87% of base)
         218 : 26360.dasm (5.76% of base)
         212 : 26982.dasm (12.80% of base)
         189 : 1148.dasm (4.82% of base)
         188 : 32569.dasm (22.49% of base)
         170 : 26775.dasm (17.51% of base)
         168 : 1380.dasm (3.94% of base)
         161 : 25770.dasm (6.40% of base)
         148 : 28540.dasm (9.65% of base)
         132 : 22526.dasm (3.60% of base)
         128 : 17951.dasm (6.50% of base)
         122 : 28913.dasm (10.02% of base)
         113 : 17780.dasm (5.52% of base)

Top file improvements (bytes):
       -3799 : 15691.dasm (-40.12% of base)
       -3263 : 15693.dasm (-66.74% of base)
       -2450 : 15692.dasm (-25.99% of base)
       -2248 : 14905.dasm (-26.35% of base)
       -1426 : 6801.dasm (-21.99% of base)
       -1320 : 15689.dasm (-29.07% of base)
       -1194 : 1298.dasm (-8.72% of base)
       -1165 : 6804.dasm (-32.24% of base)
       -1064 : 14910.dasm (-8.40% of base)
        -787 : 14757.dasm (-6.55% of base)
        -760 : 1176.dasm (-15.73% of base)
        -742 : 1106.dasm (-8.54% of base)
        -647 : 4512.dasm (-9.24% of base)
        -644 : 25234.dasm (-9.74% of base)
        -623 : 26317.dasm (-9.92% of base)
        -585 : 1222.dasm (-22.07% of base)
        -546 : 22101.dasm (-8.39% of base)
        -531 : 25448.dasm (-13.48% of base)
        -508 : 1007.dasm (-5.62% of base)
        -488 : 25447.dasm (-12.39% of base)

81 total files with Code Size differences (46 improved, 35 regressed), 20 unchanged.

Top method regressions (bytes):
        1185 ( 7.42% of base) : 1078.dasm - BepuPhysics.CollisionDetection.CollisionTasks.TrianglePairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
        1166 ( 9.70% of base) : 1076.dasm - BepuPhysics.CollisionDetection.CollisionTasks.CylinderPairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
         465 (16.61% of base) : 19240.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser:AddNewToken():this (FullOpts)
         459 ( 3.08% of base) : 1058.dasm - BepuPhysics.CollisionDetection.CollisionTasks.BoxCylinderTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
         422 (11.34% of base) : 26784.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:MakeDecisionDag(byref,System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DagState,Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DagState]):Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DecisionDag:this (FullOpts)
         372 ( 9.58% of base) : 20843.dasm - Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder:VisitTypeDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration:this (FullOpts)
         297 ( 7.75% of base) : 1016.dasm - BepuPhysics.CollisionDetection.SweepTasks.GJKDistanceTester`6[BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder]:Test(byref,byref,byref,byref,byref,byref,byref,byref,byref,byref):this (FullOpts)
         220 (21.87% of base) : 17736.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon]:TryGetValue(System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,byref):ubyte:this (FullOpts)
         218 ( 5.76% of base) : 26360.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindExtensionMethod(Microsoft.CodeAnalysis.SyntaxNode,System.String,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.CSharp.MethodGroupResolution:this (FullOpts)
         212 (12.80% of base) : 26982.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:CreateDecisionDagForSwitchStatement(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundSwitchSection]):Microsoft.CodeAnalysis.CSharp.BoundDecisionDag:this (FullOpts)
         189 ( 4.82% of base) : 1148.dasm - BepuPhysics.Constraints.PointOnLineServoFunctions:Solve(byref,byref,byref,byref,byref,byref,float,float,byref,byref,byref,byref):this (FullOpts)
         188 (22.49% of base) : 32569.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeader(System.Reflection.Metadata.BlobBuilder,System.Reflection.PortableExecutable.PEBuilder+SerializedSection) (FullOpts)
         170 (17.51% of base) : 26775.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:CreateDecisionDagForIsPattern(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundPattern,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol):Microsoft.CodeAnalysis.CSharp.BoundDecisionDag:this (FullOpts)
         168 ( 3.94% of base) : 1380.dasm - BepuPhysics.Trees.Tree:FindPartitionBinned(byref,int,int,byref,byref,byref,byref,byref):this (FullOpts)
         161 ( 6.40% of base) : 25770.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AddMemberToCandidateSet[System.__Canon](System.__Canon,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,ubyte,ubyte,ubyte,System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon],ubyte,byref,ubyte,ubyte):this (FullOpts)
         148 ( 9.65% of base) : 28540.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:CreateDecisionDagForSwitchExpression(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm]):Microsoft.CodeAnalysis.CSharp.BoundDecisionDag:this (FullOpts)
         132 ( 3.60% of base) : 22526.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitArgumentOutboundAssignmentsAndPostConditions(Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,int,Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitArgumentResult,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.NullableWalker+CompareExchangeInfo):this (FullOpts)
         128 ( 6.50% of base) : 17951.dasm - System.Net.Security.SafeDeleteContext:InitializeSecurityContext(byref,byref,System.String,int,int,System.Net.Security.InputSecurityBuffers,byref,byref):int (FullOpts)
         122 (10.02% of base) : 28913.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:CandidateOperators(ubyte,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature],Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult],byref):ubyte:this (FullOpts)
         113 ( 5.52% of base) : 17780.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon]:TryAddInternal(System.Collections.Concurrent.ConcurrentDictionary`2+Tables[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon],System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.Nullable`1[int],System.__Canon,ubyte,ubyte,byref):ubyte:this (FullOpts)

Top method improvements (bytes):
       -3799 (-40.12% of base) : 15691.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Bottom(byref,int,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
       -3263 (-66.74% of base) : 15693.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Variance(byref):double:this (FullOpts)
       -2450 (-25.99% of base) : 15692.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Top(byref,int,int,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
       -2248 (-26.35% of base) : 14905.dasm - SixLabors.ImageSharp.Color:.cctor() (FullOpts)
       -1426 (-21.99% of base) : 6801.dasm - FSharp.Compiler.LexFilter:scanAhead@1017(FSharp.Compiler.LexFilter+LexFilterImpl,ubyte,Internal.Utilities.Text.Lexing.Position,Microsoft.FSharp.Core.FSharpRef`1[Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[FSharp.Compiler.LexFilter+TokenTup,ubyte]]],int):ubyte (FullOpts)
       -1320 (-29.07% of base) : 15689.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Volume(byref,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
       -1194 (-8.72% of base) : 1298.dasm - DemoBenchmarks.RagdollTubeBenchmark:AddRagdoll(System.Numerics.Vector3,System.Numerics.Quaternion,int,BepuPhysics.CollidableProperty`1[DemoBenchmarks.RagdollTubeBenchmark+SubgroupCollisionFilter],BepuPhysics.Simulation):DemoBenchmarks.RagdollTubeBenchmark+RagdollHandles (FullOpts)
       -1165 (-32.24% of base) : 6804.dasm - FSharp.Compiler.LexFilter:action@1-16(FSharp.Compiler.LexFilter+LexFilterImpl,ubyte,FSharp.Compiler.LexFilter+TokenTup,ubyte) (FullOpts)
       -1064 (-8.40% of base) : 14910.dasm - SixLabors.ImageSharp.Color:CreateWernerPalette():SixLabors.ImageSharp.Color[] (FullOpts)
        -787 (-6.55% of base) : 14757.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
        -760 (-15.73% of base) : 1176.dasm - BepuPhysics.Constraints.Contact.ContactNonconvexTwoBodyFunctions`2[BepuPhysics.Constraints.Contact.Contact4NonconvexPrestepData,BepuPhysics.Constraints.Contact.Contact4NonconvexAccumulatedImpulses]:Solve(byref,byref,byref,byref,byref,byref,float,float,byref,byref,byref,byref):this (FullOpts)
        -742 (-8.54% of base) : 1106.dasm - BepuPhysics.CollisionDetection.MeshReduction:ReduceManifolds(byref,byref,int,int,ubyte,byref,byref,byref,ulong,BepuUtilities.Memory.BufferPool) (FullOpts)
        -647 (-9.24% of base) : 4512.dasm - FSharp.Compiler.LexFilter+LexFilterImpl:rulesForBothSoftWhiteAndHardWhite(FSharp.Compiler.LexFilter+TokenTup):ubyte:this (FullOpts)
        -644 (-9.74% of base) : 25234.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BetterFunctionMember[System.__Canon](Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],ubyte,byref):int:this (FullOpts)
        -623 (-9.92% of base) : 26317.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckPropertyValueKind(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,ushort,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
        -585 (-22.07% of base) : 1222.dasm - BepuPhysics.Simulation:Create[DemoBenchmarks.RagdollTubeBenchmark+SubgroupFilteredCallbacks,DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks](BepuUtilities.Memory.BufferPool,DemoBenchmarks.RagdollTubeBenchmark+SubgroupFilteredCallbacks,DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks,BepuPhysics.SolveDescription,BepuPhysics.ITimestepper,System.Nullable`1[BepuPhysics.SimulationAllocationSizes]):BepuPhysics.Simulation (FullOpts)
        -546 (-8.39% of base) : 22101.dasm - Microsoft.CodeAnalysis.CSharp.Binder:CheckValueKind(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,ushort,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
        -531 (-13.48% of base) : 25448.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GenerateImplicitConversionError(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.ConstantValue) (FullOpts)
        -508 (-5.62% of base) : 1007.dasm - BepuPhysics.CollisionDetection.SweepTasks.ConvexPairSweepTask`5[BepuPhysics.Collidables.Sphere,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.CollisionDetection.SweepTasks.SphereBoxDistanceTester]:Sweep[BepuPhysics.CollisionDetection.SweepTasks.ConvexPairSweepTask`5+OffsetSweep[BepuPhysics.Collidables.Sphere,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.CollisionDetection.SweepTasks.SphereBoxDistanceTester]](ulong,byref,byref,ulong,byref,byref,byref,float,float,float,int,byref,byref,byref,byref,byref):ubyte (FullOpts)
        -488 (-12.39% of base) : 25447.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GenerateImplicitConversionError(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Conversion,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):this (FullOpts)

Top method regressions (percentages):
         106 (48.62% of base) : 34812.dasm - System.Runtime.InteropServices.Marshal:.cctor() (FullOpts)
         188 (22.49% of base) : 32569.dasm - System.Reflection.PortableExecutable.PEBuilder:WriteSectionHeader(System.Reflection.Metadata.BlobBuilder,System.Reflection.PortableExecutable.PEBuilder+SerializedSection) (FullOpts)
         220 (21.87% of base) : 17736.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,System.__Canon]:TryGetValue(System.Net.Http.HttpConnectionPoolManager+HttpConnectionKey,byref):ubyte:this (FullOpts)
          84 (19.22% of base) : 24341.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BinaryOperatorEasyOut(int,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult):this (FullOpts)
          25 (17.99% of base) : 21454.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetNewCompoundUseSiteInfo(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
          25 (17.86% of base) : 30573.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:GetNewCompoundUseSiteInfo():Microsoft.CodeAnalysis.CompoundUseSiteInfo`1[Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol]:this (FullOpts)
         170 (17.51% of base) : 26775.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:CreateDecisionDagForIsPattern(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundPattern,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol):Microsoft.CodeAnalysis.CSharp.BoundDecisionDag:this (FullOpts)
         465 (16.61% of base) : 19240.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser:AddNewToken():this (FullOpts)
          23 (13.45% of base) : 15166.dasm - System.SpanHelpers:Fill[SixLabors.ImageSharp.PixelFormats.Rgba32](byref,ulong,SixLabors.ImageSharp.PixelFormats.Rgba32) (FullOpts)
          46 (12.81% of base) : 24188.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:UnaryOperatorEasyOut(int,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult):this (FullOpts)
         212 (12.80% of base) : 26982.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:CreateDecisionDagForSwitchStatement(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundSwitchSection]):Microsoft.CodeAnalysis.CSharp.BoundDecisionDag:this (FullOpts)
          24 (12.57% of base) : 23267.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]:System.Collections.Generic.IEnumerable<TKey>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.ReadOnlyMemory`1[ushort]]:this (FullOpts)
          85 (12.32% of base) : 25719.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:<GetUserDefinedBinaryOperatorsFromType>g__getDeclaredOperators|19_0(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,int,System.String,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature]) (FullOpts)
         103 (12.05% of base) : 1136.dasm - DemoBenchmarks.TwoBodyConstraintBenchmarks:Hinge():System.ValueTuple`2[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
         103 (12.05% of base) : 1121.dasm - DemoBenchmarks.TwoBodyConstraintBenchmarks:SwivelHinge():System.ValueTuple`2[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
         422 (11.34% of base) : 26784.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder:MakeDecisionDag(byref,System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DagState,Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DagState]):Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DecisionDag:this (FullOpts)
          89 (10.95% of base) : 22266.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AddConstructorToCandidateSet(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol]],Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,ubyte,byref):this (FullOpts)
          31 (10.84% of base) : 24196.dasm - Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult:get_Best():Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult:this (FullOpts)
          86 (10.62% of base) : 24508.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:CreateTuple(Microsoft.CodeAnalysis.Location,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.Location],System.Collections.Immutable.ImmutableArray`1[System.String],Microsoft.CodeAnalysis.CSharp.CSharpCompilation,ubyte,ubyte,System.Collections.Immutable.ImmutableArray`1[ubyte],Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol (FullOpts)
          51 (10.52% of base) : 29887.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RealizeSequencePoints():this (FullOpts)

Top method improvements (percentages):
         -27 (-84.38% of base) : 10907.dasm - FSharp.Compiler.MethodOverrides+DispatchSlotChecking+availPriorOverridesKeyed@304:Invoke(FSharp.Compiler.MethodOverrides+OverrideInfo):System.String:this (FullOpts)
         -27 (-84.38% of base) : 11509.dasm - FSharp.Compiler.ParseAndCheckInputs+qnameOrder@745:Invoke(FSharp.Compiler.Syntax.QualifiedNameOfFile):System.String:this (FullOpts)
         -33 (-67.35% of base) : 22323.dasm - Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this (FullOpts)
       -3263 (-66.74% of base) : 15693.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Variance(byref):double:this (FullOpts)
         -43 (-54.43% of base) : 25978.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker+SnapshotManager+Builder+<>c:<ToManagerAndFree>b__5_0(System.Collections.Generic.KeyValuePair`2[int,Microsoft.CodeAnalysis.CSharp.NullableWalker+Snapshot]):System.ValueTuple`2[int,Microsoft.CodeAnalysis.CSharp.NullableWalker+Snapshot]:this (FullOpts)
         -35 (-53.85% of base) : 30778.dasm - Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo:.ctor(ubyte):this (FullOpts)
         -73 (-50.69% of base) : 4513.dasm - FSharp.Compiler.LexFilter+LexFilterImpl:startPosOfTokenTup(FSharp.Compiler.LexFilter+TokenTup):Internal.Utilities.Text.Lexing.Position:this (FullOpts)
         -38 (-50.67% of base) : 18951.dasm - System.Collections.Immutable.ImmutableDictionary`2+<>c[System.__Canon,int]:<.cctor>b__107_0(System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableDictionary`2+HashBucket[System.__Canon,int]]):this (FullOpts)
         -44 (-50.57% of base) : 6550.dasm - Internal.Utilities.Text.Lexing.Position:get_NextLine():Internal.Utilities.Text.Lexing.Position:this (FullOpts)
         -56 (-50.00% of base) : 32566.dasm - System.Reflection.PortableExecutable.PEBuilder:SumRawDataSizes(System.Collections.Immutable.ImmutableArray`1[System.Reflection.PortableExecutable.PEBuilder+SerializedSection],uint):int (FullOpts)
         -38 (-48.72% of base) : 12531.dasm - FSharp.Compiler.CheckExpressions+optAttrs@921-2:Invoke(System.String):FSharp.Compiler.Syntax.Ident:this (FullOpts)
         -38 (-48.72% of base) : 9655.dasm - FSharp.Compiler.CheckExpressions+TcConstExpr@7547-2:Invoke(System.String):FSharp.Compiler.Syntax.Ident:this (FullOpts)
         -38 (-48.72% of base) : 4578.dasm - FSharp.Compiler.ParseAndCheckInputs+ComputeAnonModuleName@103-1:Invoke(System.String):FSharp.Compiler.Syntax.Ident:this (FullOpts)
         -38 (-48.72% of base) : 10603.dasm - FSharp.Compiler.SyntaxTreeOps+lid@47:Invoke(System.String):FSharp.Compiler.Syntax.Ident:this (FullOpts)
         -78 (-47.85% of base) : 22021.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+<>c:<IsGeneratedCode>b__48_1(Microsoft.CodeAnalysis.SyntaxTrivia):ubyte:this (FullOpts)
         -87 (-46.52% of base) : 24419.dasm - Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult:SingleValid():ubyte:this (FullOpts)
         -48 (-44.44% of base) : 26795.dasm - Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder+DagState:ComputeSelectedTest():Microsoft.CodeAnalysis.CSharp.BoundDagTest:this (FullOpts)
         -64 (-43.24% of base) : 14677.dasm - System.Reflection.PortableExecutable.PEHeaders:GetContainingSectionIndex(int):int:this (FullOpts)
         -67 (-42.41% of base) : 16878.dasm - Microsoft.ML.Data.EvaluatorBase`1[System.__Canon]:CheckColumnTypes(Microsoft.ML.Data.RoleMappedSchema):this (FullOpts)
         -55 (-41.98% of base) : 24855.dasm - Microsoft.CodeAnalysis.CSharp.Binder:GetValueExpressionIfTypeOrValueReceiver(Microsoft.CodeAnalysis.CSharp.BoundExpression):Microsoft.CodeAnalysis.CSharp.BoundExpression (FullOpts)

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

Total bytes of base: 5099419 (overridden on cmd)
Total bytes of diff: 5087830 (overridden on cmd)
Total bytes of delta: -11589 (-0.23 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          63 : 11327.dasm (2.67% of base)
          63 : 23037.dasm (2.67% of base)
          63 : 17687.dasm (2.67% of base)
          63 : 8160.dasm (2.67% of base)
          63 : 20316.dasm (2.67% of base)
          48 : 14432.dasm (4.83% of base)
          48 : 8778.dasm (4.83% of base)
          39 : 14089.dasm (4.28% of base)
          39 : 8386.dasm (4.28% of base)
          30 : 4920.dasm (2.58% of base)
          13 : 11892.dasm (4.83% of base)
          13 : 6734.dasm (4.83% of base)
          12 : 15172.dasm (0.47% of base)
          12 : 11459.dasm (0.47% of base)
          12 : 25941.dasm (2.40% of base)
          11 : 4833.dasm (7.24% of base)
          11 : 25940.dasm (2.79% of base)
          11 : 16536.dasm (7.28% of base)
          11 : 21879.dasm (7.28% of base)
          11 : 19203.dasm (7.28% of base)

Top file improvements (bytes):
        -724 : 27384.dasm (-36.98% of base)
        -395 : 18.dasm (-43.55% of base)
        -370 : 25104.dasm (-21.03% of base)
        -155 : 6786.dasm (-13.00% of base)
        -155 : 12237.dasm (-13.05% of base)
        -138 : 6155.dasm (-26.29% of base)
        -138 : 11454.dasm (-26.29% of base)
        -114 : 6265.dasm (-13.82% of base)
        -112 : 12163.dasm (-40.43% of base)
        -111 : 10272.dasm (-15.59% of base)
        -111 : 10586.dasm (-11.03% of base)
         -91 : 4795.dasm (-30.64% of base)
         -91 : 9956.dasm (-31.38% of base)
         -90 : 31800.dasm (-43.48% of base)
         -90 : 31480.dasm (-43.48% of base)
         -89 : 14790.dasm (-30.17% of base)
         -83 : 11701.dasm (-6.01% of base)
         -83 : 6381.dasm (-6.01% of base)
         -81 : 11202.dasm (-13.26% of base)
         -81 : 6028.dasm (-13.26% of base)

70 total files with Code Size differences (43 improved, 27 regressed), 7 unchanged.

Top method regressions (bytes):
          63 ( 2.67% of base) : 11327.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)
          63 ( 2.67% of base) : 23037.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)
          63 ( 2.67% of base) : 17687.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)
          63 ( 2.67% of base) : 8160.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)
          63 ( 2.67% of base) : 20316.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)
          48 ( 4.83% of base) : 14432.dasm - System.Threading.AsyncLocalValueMap+ManyElementAsyncLocalValueMap:Set(System.Threading.IAsyncLocal,System.Object,ubyte):System.Threading.IAsyncLocalValueMap:this (FullOpts)
          48 ( 4.83% of base) : 8778.dasm - System.Threading.AsyncLocalValueMap+ManyElementAsyncLocalValueMap:Set(System.Threading.IAsyncLocal,System.Object,ubyte):System.Threading.IAsyncLocalValueMap:this (FullOpts)
          39 ( 4.28% of base) : 14089.dasm - System.TimeZoneInfo:TransitionTimeToDateTime(int,System.TimeZoneInfo+TransitionTime):System.DateTime (FullOpts)
          39 ( 4.28% of base) : 8386.dasm - System.TimeZoneInfo:TransitionTimeToDateTime(int,System.TimeZoneInfo+TransitionTime):System.DateTime (FullOpts)
          30 ( 2.58% of base) : 4920.dasm - System.Diagnostics.Process:StartWithShellExecuteEx(System.Diagnostics.ProcessStartInfo):ubyte:this (FullOpts)
          13 ( 4.83% of base) : 11892.dasm - System.Collections.ObjectModel.ReadOnlyCollection`1[System.Reflection.CustomAttributeNamedArgument]:GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Reflection.CustomAttributeNamedArgument]:this (FullOpts)
          13 ( 4.83% of base) : 6734.dasm - System.Collections.ObjectModel.ReadOnlyCollection`1[System.Reflection.CustomAttributeNamedArgument]:GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Reflection.CustomAttributeNamedArgument]:this (FullOpts)
          12 ( 0.47% of base) : 15172.dasm - Internal.Reflection.Extensions.NonPortable.CustomAttributeInstantiator:Instantiate(System.Reflection.CustomAttributeData):System.Attribute (FullOpts)
          12 ( 0.47% of base) : 11459.dasm - Internal.Reflection.Extensions.NonPortable.CustomAttributeInstantiator:Instantiate(System.Reflection.CustomAttributeData):System.Attribute (FullOpts)
          12 ( 2.40% of base) : 25941.dasm - System.Guid:CompareTo(System.Object):int:this (FullOpts)
          11 ( 7.24% of base) : 4833.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.28% of base) : 16536.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.28% of base) : 21879.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.28% of base) : 19203.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.24% of base) : 1317.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)

Top method improvements (bytes):
        -724 (-36.98% of base) : 27384.dasm - System.Text.Ascii:NarrowUtf16ToAscii_Intrinsified_512(ulong,ulong,ulong):ulong (FullOpts)
        -395 (-43.55% of base) : 18.dasm - System.Runtime.InteropServices.ComWrappers:.cctor() (FullOpts)
        -370 (-21.03% of base) : 25104.dasm - System.Buffers.ProbabilisticMap:ContainsMask64CharsAvx512(System.Runtime.Intrinsics.Vector512`1[ubyte],byref,byref):System.Runtime.Intrinsics.Vector512`1[ubyte] (FullOpts)
        -155 (-13.00% of base) : 6786.dasm - System.Reflection.Runtime.CustomAttributes.NativeFormat.NativeFormatCustomAttributeData:GetConstructorArguments(ubyte):System.Collections.Generic.IList`1[System.Reflection.CustomAttributeTypedArgument]:this (FullOpts)
        -155 (-13.05% of base) : 12237.dasm - System.Reflection.Runtime.CustomAttributes.NativeFormat.NativeFormatCustomAttributeData:GetConstructorArguments(ubyte):System.Collections.Generic.IList`1[System.Reflection.CustomAttributeTypedArgument]:this (FullOpts)
        -138 (-26.29% of base) : 6155.dasm - Internal.Reflection.Execution.ExecutionEnvironmentImplementation:TryGetVirtualResolveData(Internal.Runtime.TypeLoader.NativeFormatModuleInfo,System.RuntimeTypeHandle,System.Reflection.Runtime.General.QMethodDefinition,System.RuntimeTypeHandle[],byref):long (FullOpts)
        -138 (-26.29% of base) : 11454.dasm - Internal.Reflection.Execution.ExecutionEnvironmentImplementation:TryGetVirtualResolveData(Internal.Runtime.TypeLoader.NativeFormatModuleInfo,System.RuntimeTypeHandle,System.Reflection.Runtime.General.QMethodDefinition,System.RuntimeTypeHandle[],byref):long (FullOpts)
        -114 (-13.82% of base) : 6265.dasm - System.Reflection.Runtime.FieldInfos.RuntimeFieldInfo+<get_CustomAttributes>d__2:MoveNext():ubyte:this (FullOpts)
        -112 (-40.43% of base) : 12163.dasm - System.DefaultBinder:FindMostSpecificField(System.Reflection.FieldInfo,System.Reflection.FieldInfo):int (FullOpts)
        -111 (-15.59% of base) : 10272.dasm - System.Reflection.Runtime.FieldInfos.RuntimeFieldInfo+<get_CustomAttributes>d__2:MoveNext():ubyte:this (FullOpts)
        -111 (-11.03% of base) : 10586.dasm - System.Reflection.Runtime.MethodInfos.RuntimeMethodInfo:CreateDelegateNoThrowOnBindFailure(System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo,System.Object,ubyte):System.Delegate:this (FullOpts)
         -91 (-30.64% of base) : 4795.dasm - System.Reflection.Runtime.MethodInfos.RuntimePlainConstructorInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_UncachedMethodInvoker():Internal.Reflection.Core.Execution.MethodBaseInvoker:this (FullOpts)
         -91 (-31.38% of base) : 9956.dasm - System.Reflection.Runtime.MethodInfos.RuntimePlainConstructorInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_UncachedMethodInvoker():Internal.Reflection.Core.Execution.MethodBaseInvoker:this (FullOpts)
         -90 (-43.48% of base) : 31800.dasm - ReflectionTest+TestByRefReturnInvoke:TestRefReturnNullable() (FullOpts)
         -90 (-43.48% of base) : 31480.dasm - ReflectionTest+TestByRefReturnInvoke:TestRefReturnNullable() (FullOpts)
         -89 (-30.17% of base) : 14790.dasm - System.Reflection.Runtime.MethodInfos.RuntimePlainConstructorInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_UncachedMethodInvoker():Internal.Reflection.Core.Execution.MethodBaseInvoker:this (FullOpts)
         -83 (-6.01% of base) : 11701.dasm - Internal.Runtime.TypeLoader.TypeLoaderEnvironment:TryGetVirtualResolveData(Internal.Runtime.TypeLoader.NativeFormatModuleInfo,System.RuntimeTypeHandle,System.RuntimeTypeHandle[],byref,byref):ubyte (FullOpts)
         -83 (-6.01% of base) : 6381.dasm - Internal.Runtime.TypeLoader.TypeLoaderEnvironment:TryGetVirtualResolveData(Internal.Runtime.TypeLoader.NativeFormatModuleInfo,System.RuntimeTypeHandle,System.RuntimeTypeHandle[],byref,byref):ubyte (FullOpts)
         -81 (-13.26% of base) : 11202.dasm - Internal.Runtime.TypeLoader.MethodSignatureComparer:IsMatchingNativeLayoutMethodSignature(Internal.Runtime.CompilerServices.RuntimeSignature):ubyte:this (FullOpts)
         -81 (-13.26% of base) : 6028.dasm - Internal.Runtime.TypeLoader.MethodSignatureComparer:IsMatchingNativeLayoutMethodSignature(Internal.Runtime.CompilerServices.RuntimeSignature):ubyte:this (FullOpts)

Top method regressions (percentages):
           8 ( 8.70% of base) : 11582.dasm - System.Collections.Generic.LowLevelListWithIList`1[System.Reflection.CustomAttributeTypedArgument]:System.Collections.IEnumerable.GetEnumerator():System.Collections.IEnumerator:this (FullOpts)
          11 ( 7.28% of base) : 16536.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.28% of base) : 21879.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.28% of base) : 19203.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.24% of base) : 4833.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
          11 ( 7.24% of base) : 1317.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:this (FullOpts)
           9 ( 5.06% of base) : 10240.dasm - System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:get_RuntimeMethodCommonOfUninstantiatedMethod():System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:this (FullOpts)
           9 ( 5.06% of base) : 6004.dasm - System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:get_RuntimeMethodCommonOfUninstantiatedMethod():System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:this (FullOpts)
          48 ( 4.83% of base) : 14432.dasm - System.Threading.AsyncLocalValueMap+ManyElementAsyncLocalValueMap:Set(System.Threading.IAsyncLocal,System.Object,ubyte):System.Threading.IAsyncLocalValueMap:this (FullOpts)
          48 ( 4.83% of base) : 8778.dasm - System.Threading.AsyncLocalValueMap+ManyElementAsyncLocalValueMap:Set(System.Threading.IAsyncLocal,System.Object,ubyte):System.Threading.IAsyncLocalValueMap:this (FullOpts)
          13 ( 4.83% of base) : 11892.dasm - System.Collections.ObjectModel.ReadOnlyCollection`1[System.Reflection.CustomAttributeNamedArgument]:GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Reflection.CustomAttributeNamedArgument]:this (FullOpts)
          13 ( 4.83% of base) : 6734.dasm - System.Collections.ObjectModel.ReadOnlyCollection`1[System.Reflection.CustomAttributeNamedArgument]:GetEnumerator():System.Collections.Generic.IEnumerator`1[System.Reflection.CustomAttributeNamedArgument]:this (FullOpts)
          39 ( 4.28% of base) : 14089.dasm - System.TimeZoneInfo:TransitionTimeToDateTime(int,System.TimeZoneInfo+TransitionTime):System.DateTime (FullOpts)
          39 ( 4.28% of base) : 8386.dasm - System.TimeZoneInfo:TransitionTimeToDateTime(int,System.TimeZoneInfo+TransitionTime):System.DateTime (FullOpts)
           3 ( 3.06% of base) : 23535.dasm - Internal.CompilerGenerated.<Module>:ManagedToNative__NestedClass(byref,byref) (FullOpts)
          11 ( 2.79% of base) : 25940.dasm - System.Guid:CompareTo(System.Guid):int:this (FullOpts)
           5 ( 2.70% of base) : 14091.dasm - System.TimeZoneInfo:GetPreviousAdjustmentRule(System.TimeZoneInfo+AdjustmentRule,System.Nullable`1[int]):System.TimeZoneInfo+AdjustmentRule:this (FullOpts)
           5 ( 2.70% of base) : 8388.dasm - System.TimeZoneInfo:GetPreviousAdjustmentRule(System.TimeZoneInfo+AdjustmentRule,System.Nullable`1[int]):System.TimeZoneInfo+AdjustmentRule:this (FullOpts)
          63 ( 2.67% of base) : 11327.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)
          63 ( 2.67% of base) : 23037.dasm - System.Number:Dragon4(ulong,int,uint,ubyte,int,ubyte,System.Span`1[ubyte],byref):uint (FullOpts)

Top method improvements (percentages):
         -44 (-91.67% of base) : 9652.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)
         -44 (-91.67% of base) : 3928.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeGenericParameterTypeInfo:get_GenericParameterAttributes():int:this (FullOpts)
         -36 (-90.00% of base) : 5097.dasm - System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_Attributes():int:this (FullOpts)
         -36 (-90.00% of base) : 9926.dasm - System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_Attributes():int:this (FullOpts)
         -36 (-90.00% of base) : 5088.dasm - System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_ExplicitLayoutFieldOffsetData():int:this (FullOpts)
         -36 (-90.00% of base) : 9914.dasm - System.Reflection.Runtime.FieldInfos.NativeFormat.NativeFormatRuntimeFieldInfo:get_ExplicitLayoutFieldOffsetData():int:this (FullOpts)
         -35 (-89.74% of base) : 3990.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_Attributes():int:this (FullOpts)
         -35 (-89.74% of base) : 9672.dasm - System.Reflection.Runtime.TypeInfos.NativeFormat.NativeFormatRuntimeNamedTypeInfo:get_Attributes():int:this (FullOpts)
         -30 (-88.24% of base) : 27494.dasm - System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:get_Attributes():int:this (FullOpts)
         -30 (-88.24% of base) : 24556.dasm - System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon:get_MethodImplementationFlags():int:this (FullOpts)
         -30 (-88.24% of base) : 6109.dasm - System.Reflection.Runtime.MethodInfos.RuntimeNamedMethodInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_Attributes():int:this (FullOpts)
         -30 (-88.24% of base) : 11428.dasm - System.Reflection.Runtime.MethodInfos.RuntimeNamedMethodInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_Attributes():int:this (FullOpts)
         -30 (-88.24% of base) : 9961.dasm - System.Reflection.Runtime.MethodInfos.RuntimePlainConstructorInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_Attributes():int:this (FullOpts)
         -30 (-88.24% of base) : 4799.dasm - System.Reflection.Runtime.MethodInfos.RuntimePlainConstructorInfo`1[System.Reflection.Runtime.MethodInfos.NativeFormat.NativeFormatMethodCommon]:get_Attributes():int:this (FullOpts)
         -39 (-84.78% of base) : 12020.dasm - System.Reflection.Runtime.ParameterInfos.NativeFormat.NativeFormatMethodParameterInfo:get_Attributes():int:this (FullOpts)
         -39 (-84.78% of base) : 7197.dasm - System.Reflection.Runtime.ParameterInfos.NativeFormat.NativeFormatMethodParameterInfo:get_Attributes():int:this (FullOpts)
         -36 (-78.26% of base) : 30975.dasm - System.Reflection.FieldInfo:get_IsInitOnly():ubyte:this (FullOpts)
         -36 (-78.26% of base) : 25490.dasm - System.Reflection.FieldInfo:get_IsLiteral():ubyte:this (FullOpts)
         -36 (-78.26% of base) : 31216.dasm - System.Reflection.FieldInfo:get_IsStatic():ubyte:this (FullOpts)
         -51 (-64.56% of base) : 30018.dasm - System.Runtime.Intrinsics.Vector512`1[int]:System.Runtime.Intrinsics.ISimdVector<System.Runtime.Intrinsics.Vector512<T>,T>.Create(int):System.Runtime.Intrinsics.Vector512`1[int] (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
