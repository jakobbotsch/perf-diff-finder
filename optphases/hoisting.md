Diffs are based on <span style="color:#1460aa">2,450,561</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,495,267</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">7,064 (0.29%)</span>, diff: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitDoLoopHoisting=0


<details>
<summary>Overall (<span style="color:red">+331,609</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,402,760|<span style="color:red">+14,172</span>|<span style="color:green">-8.65%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,444,635|<span style="color:red">+12,378</span>|<span style="color:green">-5.03%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,702,756|<span style="color:red">+8,487</span>|<span style="color:green">-8.67%</span>|
|coreclr_tests.run.windows.x64.checked.mch|386,802,490|<span style="color:red">+8,761</span>|<span style="color:green">-1.61%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,036,867|<span style="color:red">+62,226</span>|<span style="color:green">-6.64%</span>|
|libraries.pmi.windows.x64.checked.mch|61,408,934|<span style="color:red">+28,602</span>|<span style="color:green">-8.96%</span>|
|libraries_tests.run.windows.x64.Release.mch|284,944,324|<span style="color:red">+81,043</span>|<span style="color:green">-0.53%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|136,277,954|<span style="color:red">+105,408</span>|<span style="color:green">-2.33%</span>|
|realworld.run.windows.x64.checked.mch|13,972,463|<span style="color:red">+7,473</span>|<span style="color:green">-6.88%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,114,317|<span style="color:red">+3,059</span>|<span style="color:green">-7.08%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:red">+331,609</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,402,400|<span style="color:red">+14,172</span>|<span style="color:green">-8.65%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,542,011|<span style="color:red">+12,378</span>|<span style="color:green">-5.03%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,469,973|<span style="color:red">+8,487</span>|<span style="color:green">-8.67%</span>|
|coreclr_tests.run.windows.x64.checked.mch|106,359,341|<span style="color:red">+8,761</span>|<span style="color:green">-1.61%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,035,680|<span style="color:red">+62,226</span>|<span style="color:green">-6.64%</span>|
|libraries.pmi.windows.x64.checked.mch|61,295,440|<span style="color:red">+28,602</span>|<span style="color:green">-8.96%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,297,305|<span style="color:red">+81,043</span>|<span style="color:green">-0.53%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|125,985,075|<span style="color:red">+105,408</span>|<span style="color:green">-2.33%</span>|
|realworld.run.windows.x64.checked.mch|13,586,295|<span style="color:red">+7,473</span>|<span style="color:green">-6.88%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,113,370|<span style="color:red">+3,059</span>|<span style="color:green">-7.08%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-41</span> (<span style="color:green">-11.55%</span>) : 6813.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,31 +8,32 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  8,386   )     ref  ->  rcx         class-hnd single-def <double[,]>
-;  V01 arg1         [V01,T09] (  9,210   )     ref  ->  rdx         class-hnd single-def <double[,]>
-;  V02 arg2         [V02,T22] (  6, 87   )     int  ->  [rsp+0x80]  single-def
-;  V03 loc0         [V03,T21] (  6, 93   )     int  ->  rax        
+;  V01 arg1         [V01,T12] (  9,186   )     ref  ->  rdx         class-hnd single-def <double[,]>
+;  V02 arg2         [V02,T21] (  6, 87   )     int  ->   r8         single-def
+;  V03 loc0         [V03,T22] (  6, 81   )     int  ->  [rsp+0x34] 
 ;  V04 loc1         [V04,T18] (  6,132   )     int  ->  r10        
-;  V05 loc2         [V05,T05] (  6,336   )     int  ->  rsi        
+;  V05 loc2         [V05,T05] (  6,336   )     int  ->  rdi        
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T07] (  3, 96   )     int  ->  r11         "MD array shared temp"
-;  V08 tmp2         [V08,T08] (  3, 96   )     int  ->  rbp         "MD array shared temp"
+;  V07 tmp1         [V07,T07] (  3, 96   )     int  ->  rbx         "MD array shared temp"
+;  V08 tmp2         [V08,T08] (  3, 96   )     int  ->  r14         "MD array shared temp"
 ;* V09 tmp3         [V09,T19] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
 ;* V10 tmp4         [V10,T20] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
-;  V11 tmp5         [V11,T01] (  3,384   )     int  ->  r13         "MD array shared temp"
-;  V12 tmp6         [V12,T02] (  3,384   )     int  ->   r8         "MD array shared temp"
-;  V13 tmp7         [V13,T03] (  3,384   )     int  ->   r8         "MD array shared temp"
-;  V14 tmp8         [V14,T04] (  3,384   )     int  ->  r15         "MD array shared temp"
-;  V15 cse0         [V15,T14] (  4,160   )     int  ->  r11         "CSE - moderate"
-;  V16 cse1         [V16,T15] (  4,160   )     int  ->  rbp         "CSE - moderate"
-;  V17 cse2         [V17,T16] (  2, 32   )     int  ->  [rsp+0x24]  spill-single-def "CSE - moderate"
-;  V18 cse3         [V18,T17] (  2, 32   )     int  ->  [rsp+0x20]  spill-single-def "CSE - moderate"
-;  V19 cse4         [V19,T13] (  5,176   )     int  ->  rbx         "CSE - moderate"
-;  V20 cse5         [V20,T06] (  5,320   )     int  ->  rdi         "CSE - aggressive"
-;  V21 cse6         [V21,T10] (  3,192   )     int  ->  r15         "CSE - moderate"
-;  V22 cse7         [V22,T11] (  3,192   )     int  ->  r12         "CSE - moderate"
-;  V23 cse8         [V23,T12] (  3,192   )     int  ->   r9         "CSE - moderate"
+;  V11 tmp5         [V11,T01] (  3,384   )     int  ->  r12         "MD array shared temp"
+;  V12 tmp6         [V12,T02] (  3,384   )     int  ->  rax         "MD array shared temp"
+;  V13 tmp7         [V13,T03] (  3,384   )     int  ->  rax         "MD array shared temp"
+;  V14 tmp8         [V14,T04] (  3,384   )     int  ->   r9         "MD array shared temp"
+;  V15 cse0         [V15,T14] (  4,160   )     int  ->  rbx         "CSE - moderate"
+;  V16 cse1         [V16,T15] (  4,160   )     int  ->  r14         "CSE - moderate"
+;  V17 cse2         [V17,T17] (  2, 20   )     int  ->  [rsp+0x30]  spill-single-def hoist "CSE - moderate"
+;  V18 cse3         [V18,T16] (  2, 32   )     int  ->  [rsp+0x2C]  spill-single-def "CSE - moderate"
+;  V19 cse4         [V19,T13] (  5,176   )     int  ->  rsi         "CSE - moderate"
+;  V20 cse5         [V20,T06] (  5,320   )     int  ->  r11         "CSE - aggressive"
+;  V21 cse6         [V21,T23] (  2, 20   )     int  ->  [rsp+0x28]  spill-single-def hoist "CSE - moderate"
+;  V22 cse7         [V22,T09] (  3,192   )     int  ->  r13         "CSE - moderate"
+;  V23 cse8         [V23,T10] (  3,192   )     int  ->   r9         "CSE - moderate"
+;  V24 cse9         [V24,T11] (  3,192   )     int  ->  rbp         "CSE - moderate"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M7242_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -43,98 +44,97 @@ G_M7242_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
 						;; size=16 bbWeight=1 PerfScore 8.25
 G_M7242_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx rdx]
        mov      eax, 1
-       mov      dword ptr [rsp+0x80], r8d
        test     r8d, r8d
        jle      G_M7242_IG08
-						;; size=22 bbWeight=1 PerfScore 2.50
+						;; size=14 bbWeight=1 PerfScore 1.50
 G_M7242_IG03:        ; bbWeight=4, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        mov      r10d, 1
-						;; size=6 bbWeight=4 PerfScore 1.00
-G_M7242_IG04:        ; bbWeight=16, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        mov      r9d, eax
        sub      r9d, dword ptr [rdx+0x18]
-       mov      dword ptr [rsp+0x24], r9d
-       mov      r11d, r9d
-       cmp      r11d, dword ptr [rdx+0x10]
+       mov      dword ptr [rsp+0x30], r9d
+       mov      r11d, dword ptr [rdx+0x10]
+       mov      dword ptr [rsp+0x28], r11d
+						;; size=27 bbWeight=4 PerfScore 30.00
+G_M7242_IG04:        ; bbWeight=16, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
+       mov      ebx, r9d
+       cmp      ebx, r11d
        jae      G_M7242_IG09
-       mov      ebx, dword ptr [rdx+0x14]
-       mov      esi, r11d
-       imul     esi, ebx
-       mov      edi, r10d
-       sub      edi, dword ptr [rdx+0x1C]
-       mov      dword ptr [rsp+0x20], edi
-       mov      ebp, edi
-       cmp      ebp, ebx
+       mov      esi, dword ptr [rdx+0x14]
+       mov      edi, ebx
+       imul     edi, esi
+       mov      ebp, r10d
+       sub      ebp, dword ptr [rdx+0x1C]
+       mov      dword ptr [rsp+0x2C], ebp
+       mov      r14d, ebp
+       cmp      r14d, esi
        jae      G_M7242_IG09
-       add      esi, ebp
-       xor      r14d, r14d
-       mov      qword ptr [rdx+8*rsi+0x20], r14
-       mov      esi, 1
-						;; size=69 bbWeight=16 PerfScore 324.00
+       add      edi, r14d
+       xor      r15d, r15d
+       mov      qword ptr [rdx+8*rdi+0x20], r15
+       mov      edi, 1
+						;; size=58 bbWeight=16 PerfScore 212.00
 G_M7242_IG05:        ; bbWeight=64, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
-       mov      r14d, r11d
-       imul     r14d, ebx
-       add      r14d, ebp
-       mov      r15d, r11d
-       imul     r15d, ebx
-       add      r15d, ebp
-       vmovsd   xmm0, qword ptr [rdx+8*r15+0x20]
-       mov      r15d, dword ptr [rcx+0x18]
-       mov      r13d, eax
-       sub      r13d, r15d
-       mov      r12d, dword ptr [rcx+0x10]
-       cmp      r13d, r12d
+       mov      r15d, ebx
+       imul     r15d, esi
+       add      r15d, r14d
+       mov      r13d, ebx
+       imul     r13d, esi
+       add      r13d, r14d
+       vmovsd   xmm0, qword ptr [rdx+8*r13+0x20]
+       mov      r13d, dword ptr [rcx+0x18]
+       mov      dword ptr [rsp+0x34], eax
+       mov      r12d, eax
+       sub      r12d, r13d
+       mov      r9d, dword ptr [rcx+0x10]
+       cmp      r12d, r9d
        jae      G_M7242_IG09
-       mov      edi, dword ptr [rcx+0x14]
-       imul     r13d, edi
-       mov      r9d, dword ptr [rcx+0x1C]
-       mov      r8d, esi
-       sub      r8d, r9d
-       cmp      r8d, edi
-       jae      G_M7242_IG09
-       add      r8d, r13d
-       vmovsd   xmm1, qword ptr [rcx+8*r8+0x20]
-       mov      r8d, esi
-       sub      r8d, r15d
-       cmp      r8d, r12d
-       jae      G_M7242_IG09
-       imul     r8d, edi
-       mov      r15d, r10d
-       sub      r15d, r9d
-       cmp      r15d, edi
+       mov      r11d, dword ptr [rcx+0x14]
+       imul     r12d, r11d
+       mov      ebp, dword ptr [rcx+0x1C]
+       mov      eax, edi
+       sub      eax, ebp
+       cmp      eax, r11d
        jae      SHORT G_M7242_IG09
-       add      r8d, r15d
-       vmulsd   xmm1, xmm1, qword ptr [rcx+8*r8+0x20]
+       add      eax, r12d
+       vmovsd   xmm1, qword ptr [rcx+8*rax+0x20]
+       mov      eax, edi
+       sub      eax, r13d
+       cmp      eax, r9d
+       jae      SHORT G_M7242_IG09
+       imul     eax, r11d
+       mov      r9d, r10d
+       sub      r9d, ebp
+       cmp      r9d, r11d
+       jae      SHORT G_M7242_IG09
+       add      eax, r9d
+       vmulsd   xmm1, xmm1, qword ptr [rcx+8*rax+0x20]
        vaddsd   xmm0, xmm0, xmm1
-       vmovsd   qword ptr [rdx+8*r14+0x20], xmm0
-       inc      esi
-       mov      r8d, dword ptr [rsp+0x80]
-       cmp      esi, r8d
-       mov      dword ptr [rsp+0x80], r8d
+       vmovsd   qword ptr [rdx+8*r15+0x20], xmm0
+       inc      edi
+       cmp      edi, r8d
+       mov      eax, dword ptr [rsp+0x34]
        jle      G_M7242_IG05
-						;; size=164 bbWeight=64 PerfScore 3008.00
+						;; size=143 bbWeight=64 PerfScore 3008.00
 G_M7242_IG06:        ; bbWeight=16, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        inc      r10d
-       mov      r8d, dword ptr [rsp+0x80]
        cmp      r10d, r8d
-       mov      dword ptr [rsp+0x80], r8d
+       mov      r9d, dword ptr [rsp+0x30]
+       mov      r11d, dword ptr [rsp+0x28]
        jle      G_M7242_IG04
-						;; size=28 bbWeight=16 PerfScore 56.00
+						;; size=22 bbWeight=16 PerfScore 56.00
 G_M7242_IG07:        ; bbWeight=4, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        inc      eax
-       mov      r8d, dword ptr [rsp+0x80]
        cmp      eax, r8d
-       mov      dword ptr [rsp+0x80], r8d
        jle      G_M7242_IG03
-						;; size=27 bbWeight=4 PerfScore 14.00
+						;; size=11 bbWeight=4 PerfScore 6.00
 G_M7242_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx rdx]
-       add      rsp, 40
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
@@ -151,7 +151,7 @@ G_M7242_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 355, prolog size 16, PerfScore 3419.00, instruction count 95, allocated bytes for code 355 (MethodHash=2f4fe3b5) for method Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (FullOpts)
+; Total bytes of code 314, prolog size 16, PerfScore 3327.00, instruction count 94, allocated bytes for code 314 (MethodHash=2f4fe3b5) for method Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -164,7 +164,7 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-28</span> (<span style="color:green">-8.78%</span>) : 19661.dasm - System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,48 +8,48 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T09] (  5,  5   )   byref  ->  rdi         single-def
-;  V01 arg0         [V01,T04] (  4, 10   )     ref  ->  rsi         class-hnd single-def <System.Random>
-;  V02 arg1         [V02,T01] (  6, 15   )     int  ->  rbx         single-def
-;  V03 loc0         [V03,T02] (  5, 17   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
-;  V04 loc1         [V04    ] (  6, 12   )  struct (16) [rsp+0x38]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Numerics.BigInteger>
+;  V00 RetBuf       [V00,T08] (  5,  5   )   byref  ->  rsi         single-def
+;  V01 arg0         [V01,T04] (  5,  7   )     ref  ->  rbx         class-hnd single-def <System.Random>
+;  V02 arg1         [V02,T09] (  6,  4.50)     int  ->  rdi         single-def
+;  V03 loc0         [V03,T01] (  5, 17   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
+;  V04 loc1         [V04    ] (  6, 12   )  struct (16) [rsp+0x30]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Numerics.BigInteger>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V06 tmp1         [V06,T00] (  3, 24   )   byref  ->  rcx         "dup spill"
-;  V07 tmp2         [V07,T06] (  2,  8   )   byref  ->  rcx        
+;  V07 tmp2         [V07,T05] (  2,  8   )   byref  ->  rcx        
 ;* V08 tmp3         [V08    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V09 tmp4         [V09    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V10 tmp5         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V11 tmp6         [V11    ] (  3,  6   )     ref  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V04._bits (fldOffset=0x0)" P-DEP
-;  V12 tmp7         [V12    ] (  5, 11   )     int  ->  [rsp+0x40]  do-not-enreg[X] addr-exposed "field V04._sign (fldOffset=0x8)" P-DEP
-;  V13 tmp8         [V13,T07] (  2,  8   )   byref  ->   r8         "field V09._reference (fldOffset=0x0)" P-INDEP
-;  V14 tmp9         [V14,T08] (  2,  8   )     int  ->  rdx         "field V09._length (fldOffset=0x8)" P-INDEP
-;  V15 tmp10        [V15    ] (  3, 24   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
+;  V11 tmp6         [V11    ] (  3,  6   )     ref  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V04._bits (fldOffset=0x0)" P-DEP
+;  V12 tmp7         [V12    ] (  5, 11   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V04._sign (fldOffset=0x8)" P-DEP
+;  V13 tmp8         [V13,T06] (  2,  8   )   byref  ->   r8         "field V09._reference (fldOffset=0x0)" P-INDEP
+;  V14 tmp9         [V14,T07] (  2,  8   )     int  ->  rdx         "field V09._length (fldOffset=0x8)" P-INDEP
+;  V15 tmp10        [V15    ] (  3, 24   )  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
 ;* V16 tmp11        [V16    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
-;  V17 cse0         [V17,T05] (  3, 12   )     int  ->  rcx         "CSE - aggressive"
-;  V18 cse1         [V18,T03] (  4, 16   )     int  ->  rdx         "CSE - aggressive"
-;  V19 rat0         [V19,T10] (  3,  6   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V17 cse0         [V17,T11] (  2,  4.50)     int  ->  rdi         hoist "CSE - aggressive"
+;  V18 cse1         [V18,T12] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
+;  V19 cse2         [V19,T03] (  3, 12   )     int  ->  rcx         "CSE - aggressive"
+;  V20 cse3         [V20,T02] (  4, 16   )     int  ->  rdx         "CSE - aggressive"
+;  V21 rat0         [V21,T10] (  3,  6   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 64
 
 G_M22410_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 72
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 64
        vxorps   xmm4, xmm4, xmm4
-       vmovdqa  xmmword ptr [rsp+0x30], xmm4
-       mov      qword ptr [rsp+0x40], rax
-       mov      rdi, rcx
-       ; byrRegs +[rdi]
-       mov      rsi, rdx
-       ; gcrRegs +[rsi]
-       mov      ebx, r8d
-						;; size=39 bbWeight=1 PerfScore 9.58
-G_M22410_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref
-       lea      edx, [rbx+0x08]
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       mov      rsi, rcx
+       ; byrRegs +[rsi]
+       mov      rbx, rdx
+       ; gcrRegs +[rbx]
+       mov      edi, r8d
+						;; size=29 bbWeight=1 PerfScore 8.33
+G_M22410_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref
+       lea      edx, [rdi+0x08]
        mov      ecx, edx
        sar      ecx, 31
        and      ecx, 7
@@ -63,9 +63,9 @@ G_M22410_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi},
        mov      rbp, rax
        ; gcrRegs +[rbp]
        test     byte  ptr [(reloc)], 1      ; global ptr
-       je       G_M22410_IG10
+       je       G_M22410_IG11
 						;; size=50 bbWeight=1 PerfScore 8.00
-G_M22410_IG03:        ; bbWeight=1, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rdi}, byref
+G_M22410_IG03:        ; bbWeight=1, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref
        ; gcrRegs -[rax]
        mov      rcx, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
        mov      rcx, gword ptr [rcx]
@@ -73,88 +73,92 @@ G_M22410_IG03:        ; bbWeight=1, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rd
 						;; size=13 bbWeight=1 PerfScore 2.25
 G_M22410_IG04:        ; bbWeight=1, nogc, extend
        vmovdqu  xmm0, xmmword ptr [rcx+0x08]
-       vmovdqu  xmmword ptr [rsp+0x38], xmm0
+       vmovdqu  xmmword ptr [rsp+0x30], xmm0
 						;; size=11 bbWeight=1 PerfScore 5.00
-G_M22410_IG05:        ; bbWeight=1, extend
-       cmp      dword ptr [rsp+0x40], 0
-       jne      G_M22410_IG07
-						;; size=11 bbWeight=1 PerfScore 3.00
-G_M22410_IG06:        ; bbWeight=4, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rdi}, byref
+G_M22410_IG05:        ; bbWeight=1, isz, extend
+       cmp      dword ptr [rsp+0x38], 0
+       jne      SHORT G_M22410_IG08
+						;; size=7 bbWeight=1 PerfScore 3.00
+G_M22410_IG06:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref
        ; gcrRegs -[rcx]
-       mov      rcx, rsi
+       cmp      dword ptr [rbx], ebx
+       mov      rcx, qword ptr [rbx]
+       mov      r14, qword ptr [rcx+0x50]
+       mov      ecx, edi
+       sar      ecx, 31
+       and      ecx, 7
+       add      ecx, edi
+       and      ecx, -8
+       mov      edx, edi
+       sub      edx, ecx
+       mov      ecx, edx
+       neg      ecx
+       add      ecx, 8
+       mov      edx, 255
+       sarx     ecx, edx, ecx
+       movzx    rdi, cl
+						;; size=47 bbWeight=0.50 PerfScore 5.38
+G_M22410_IG07:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref, isz
+       mov      rcx, rbx
        ; gcrRegs +[rcx]
        mov      rdx, rbp
        ; gcrRegs +[rdx]
-       mov      rax, qword ptr [rsi]
-       mov      rax, qword ptr [rax+0x50]
-       call     [rax+0x20]<unknown method>
+       call     [r14+0x20]<unknown method>
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
        mov      edx, dword ptr [rbp+0x08]
        lea      ecx, [rdx-0x01]
        cmp      ecx, edx
-       jae      G_M22410_IG09
+       jae      SHORT G_M22410_IG10
        lea      rcx, bword ptr [rbp+rcx+0x10]
        ; byrRegs +[rcx]
-       mov      r8d, ebx
-       sar      r8d, 31
-       and      r8d, 7
-       add      r8d, ebx
-       and      r8d, -8
-       mov      r9d, ebx
-       sub      r9d, r8d
-       mov      r8d, r9d
-       neg      r8d
-       add      r8d, 8
-       mov      r9d, 255
-       sarx     r8d, r9d, r8d
-       movzx    r8, r8b
-       and      byte  ptr [rcx], r8b
-       lea      rcx, bword ptr [rsp+0x38]
+       and      byte  ptr [rcx], dil
+       lea      rcx, bword ptr [rsp+0x30]
        lea      r8, bword ptr [rbp+0x10]
        ; byrRegs +[r8]
-       mov      bword ptr [rsp+0x28], r8
-       mov      dword ptr [rsp+0x30], edx
-       lea      rdx, [rsp+0x28]
+       mov      bword ptr [rsp+0x20], r8
+       mov      dword ptr [rsp+0x28], edx
+       lea      rdx, [rsp+0x20]
        xor      r8d, r8d
        ; byrRegs -[r8]
        xor      r9d, r9d
        call     [<unknown method>]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
-       cmp      dword ptr [rsp+0x40], 0
-       je       G_M22410_IG06
-						;; size=133 bbWeight=4 PerfScore 120.00
-G_M22410_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0080 {rdi}, byref
-       ; gcrRegs -[rbp rsi]
-       mov      rdx, gword ptr [rsp+0x38]
+       cmp      dword ptr [rsp+0x38], 0
+       je       SHORT G_M22410_IG07
+						;; size=70 bbWeight=4 PerfScore 89.00
+G_M22410_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, byref
+       ; gcrRegs -[rbx rbp]
+       mov      rdx, gword ptr [rsp+0x30]
        ; gcrRegs +[rdx]
-       mov      rcx, rdi
+       mov      rcx, rsi
        ; byrRegs +[rcx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       mov      eax, dword ptr [rsp+0x40]
-       mov      dword ptr [rdi+0x08], eax
-       mov      rax, rdi
+       mov      eax, dword ptr [rsp+0x38]
+       mov      dword ptr [rsi+0x08], eax
+       mov      rax, rsi
        ; byrRegs +[rax]
 						;; size=23 bbWeight=1 PerfScore 4.50
-G_M22410_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 72
+G_M22410_IG09:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 64
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
-G_M22410_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rax rdi]
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M22410_IG10:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       ; byrRegs -[rax rsi]
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M22410_IG10:        ; bbWeight=0, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rdi}, byref
-       ; gcrRegs +[rbp rsi]
-       ; byrRegs +[rdi]
+G_M22410_IG11:        ; bbWeight=0, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref
+       ; gcrRegs +[rbx rbp]
+       ; byrRegs +[rsi]
        mov      rcx, 0xD1FFAB1E
        mov      edx, 24
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
@@ -162,7 +166,7 @@ G_M22410_IG10:        ; bbWeight=0, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rd
        jmp      G_M22410_IG03
 						;; size=25 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 319, prolog size 30, PerfScore 155.58, instruction count 82, allocated bytes for code 319 (MethodHash=208fa875) for method System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
+; Total bytes of code 291, prolog size 20, PerfScore 129.21, instruction count 82, allocated bytes for code 291 (MethodHash=208fa875) for method System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -170,13 +174,14 @@ Unwind Info:
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
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
...

```


</div></details>

<details>
<summary><span style="color:green">-28</span> (<span style="color:green">-8.78%</span>) : 2940.dasm - System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,48 +8,48 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T09] (  5,  5   )   byref  ->  rdi         single-def
-;  V01 arg0         [V01,T04] (  4, 10   )     ref  ->  rsi         class-hnd single-def <System.Random>
-;  V02 arg1         [V02,T01] (  6, 15   )     int  ->  rbx         single-def
-;  V03 loc0         [V03,T02] (  5, 17   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
-;  V04 loc1         [V04    ] (  6, 12   )  struct (16) [rsp+0x38]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Numerics.BigInteger>
+;  V00 RetBuf       [V00,T08] (  5,  5   )   byref  ->  rsi         single-def
+;  V01 arg0         [V01,T04] (  5,  7   )     ref  ->  rbx         class-hnd single-def <System.Random>
+;  V02 arg1         [V02,T09] (  6,  4.50)     int  ->  rdi         single-def
+;  V03 loc0         [V03,T01] (  5, 17   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
+;  V04 loc1         [V04    ] (  6, 12   )  struct (16) [rsp+0x30]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Numerics.BigInteger>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V06 tmp1         [V06,T00] (  3, 24   )   byref  ->  rcx         "dup spill"
-;  V07 tmp2         [V07,T06] (  2,  8   )   byref  ->  rcx        
+;  V07 tmp2         [V07,T05] (  2,  8   )   byref  ->  rcx        
 ;* V08 tmp3         [V08    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V09 tmp4         [V09    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V10 tmp5         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V11 tmp6         [V11    ] (  3,  6   )     ref  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V04._bits (fldOffset=0x0)" P-DEP
-;  V12 tmp7         [V12    ] (  5, 11   )     int  ->  [rsp+0x40]  do-not-enreg[X] addr-exposed "field V04._sign (fldOffset=0x8)" P-DEP
-;  V13 tmp8         [V13,T07] (  2,  8   )   byref  ->   r8         "field V09._reference (fldOffset=0x0)" P-INDEP
-;  V14 tmp9         [V14,T08] (  2,  8   )     int  ->  rdx         "field V09._length (fldOffset=0x8)" P-INDEP
-;  V15 tmp10        [V15    ] (  3, 24   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
+;  V11 tmp6         [V11    ] (  3,  6   )     ref  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V04._bits (fldOffset=0x0)" P-DEP
+;  V12 tmp7         [V12    ] (  5, 11   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V04._sign (fldOffset=0x8)" P-DEP
+;  V13 tmp8         [V13,T06] (  2,  8   )   byref  ->   r8         "field V09._reference (fldOffset=0x0)" P-INDEP
+;  V14 tmp9         [V14,T07] (  2,  8   )     int  ->  rdx         "field V09._length (fldOffset=0x8)" P-INDEP
+;  V15 tmp10        [V15    ] (  3, 24   )  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
 ;* V16 tmp11        [V16    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
-;  V17 cse0         [V17,T05] (  3, 12   )     int  ->  rcx         "CSE - aggressive"
-;  V18 cse1         [V18,T03] (  4, 16   )     int  ->  rdx         "CSE - aggressive"
-;  V19 rat0         [V19,T10] (  3,  6   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V17 cse0         [V17,T11] (  2,  4.50)     int  ->  rdi         hoist "CSE - aggressive"
+;  V18 cse1         [V18,T12] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
+;  V19 cse2         [V19,T03] (  3, 12   )     int  ->  rcx         "CSE - aggressive"
+;  V20 cse3         [V20,T02] (  4, 16   )     int  ->  rdx         "CSE - aggressive"
+;  V21 rat0         [V21,T10] (  3,  6   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 64
 
 G_M22410_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 72
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 64
        vxorps   xmm4, xmm4, xmm4
-       vmovdqa  xmmword ptr [rsp+0x30], xmm4
-       mov      qword ptr [rsp+0x40], rax
-       mov      rdi, rcx
-       ; byrRegs +[rdi]
-       mov      rsi, rdx
-       ; gcrRegs +[rsi]
-       mov      ebx, r8d
-						;; size=39 bbWeight=1 PerfScore 9.58
-G_M22410_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref
-       lea      edx, [rbx+0x08]
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       mov      rsi, rcx
+       ; byrRegs +[rsi]
+       mov      rbx, rdx
+       ; gcrRegs +[rbx]
+       mov      edi, r8d
+						;; size=29 bbWeight=1 PerfScore 8.33
+G_M22410_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref
+       lea      edx, [rdi+0x08]
        mov      ecx, edx
        sar      ecx, 31
        and      ecx, 7
@@ -63,9 +63,9 @@ G_M22410_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi},
        mov      rbp, rax
        ; gcrRegs +[rbp]
        test     byte  ptr [(reloc)], 1      ; global ptr
-       je       G_M22410_IG10
+       je       G_M22410_IG11
 						;; size=50 bbWeight=1 PerfScore 8.00
-G_M22410_IG03:        ; bbWeight=1, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rdi}, byref
+G_M22410_IG03:        ; bbWeight=1, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref
        ; gcrRegs -[rax]
        mov      rcx, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
        mov      rcx, gword ptr [rcx]
@@ -73,88 +73,92 @@ G_M22410_IG03:        ; bbWeight=1, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rd
 						;; size=13 bbWeight=1 PerfScore 2.25
 G_M22410_IG04:        ; bbWeight=1, nogc, extend
        vmovdqu  xmm0, xmmword ptr [rcx+0x08]
-       vmovdqu  xmmword ptr [rsp+0x38], xmm0
+       vmovdqu  xmmword ptr [rsp+0x30], xmm0
 						;; size=11 bbWeight=1 PerfScore 5.00
-G_M22410_IG05:        ; bbWeight=1, extend
-       cmp      dword ptr [rsp+0x40], 0
-       jne      G_M22410_IG07
-						;; size=11 bbWeight=1 PerfScore 3.00
-G_M22410_IG06:        ; bbWeight=4, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rdi}, byref
+G_M22410_IG05:        ; bbWeight=1, isz, extend
+       cmp      dword ptr [rsp+0x38], 0
+       jne      SHORT G_M22410_IG08
+						;; size=7 bbWeight=1 PerfScore 3.00
+G_M22410_IG06:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref
        ; gcrRegs -[rcx]
-       mov      rcx, rsi
+       cmp      dword ptr [rbx], ebx
+       mov      rcx, qword ptr [rbx]
+       mov      r14, qword ptr [rcx+0x50]
+       mov      ecx, edi
+       sar      ecx, 31
+       and      ecx, 7
+       add      ecx, edi
+       and      ecx, -8
+       mov      edx, edi
+       sub      edx, ecx
+       mov      ecx, edx
+       neg      ecx
+       add      ecx, 8
+       mov      edx, 255
+       sarx     ecx, edx, ecx
+       movzx    rdi, cl
+						;; size=47 bbWeight=0.50 PerfScore 5.38
+G_M22410_IG07:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref, isz
+       mov      rcx, rbx
        ; gcrRegs +[rcx]
        mov      rdx, rbp
        ; gcrRegs +[rdx]
-       mov      rax, qword ptr [rsi]
-       mov      rax, qword ptr [rax+0x50]
-       call     [rax+0x20]<unknown method>
+       call     [r14+0x20]<unknown method>
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
        mov      edx, dword ptr [rbp+0x08]
        lea      ecx, [rdx-0x01]
        cmp      ecx, edx
-       jae      G_M22410_IG09
+       jae      SHORT G_M22410_IG10
        lea      rcx, bword ptr [rbp+rcx+0x10]
        ; byrRegs +[rcx]
-       mov      r8d, ebx
-       sar      r8d, 31
-       and      r8d, 7
-       add      r8d, ebx
-       and      r8d, -8
-       mov      r9d, ebx
-       sub      r9d, r8d
-       mov      r8d, r9d
-       neg      r8d
-       add      r8d, 8
-       mov      r9d, 255
-       sarx     r8d, r9d, r8d
-       movzx    r8, r8b
-       and      byte  ptr [rcx], r8b
-       lea      rcx, bword ptr [rsp+0x38]
+       and      byte  ptr [rcx], dil
+       lea      rcx, bword ptr [rsp+0x30]
        lea      r8, bword ptr [rbp+0x10]
        ; byrRegs +[r8]
-       mov      bword ptr [rsp+0x28], r8
-       mov      dword ptr [rsp+0x30], edx
-       lea      rdx, [rsp+0x28]
+       mov      bword ptr [rsp+0x20], r8
+       mov      dword ptr [rsp+0x28], edx
+       lea      rdx, [rsp+0x20]
        xor      r8d, r8d
        ; byrRegs -[r8]
        xor      r9d, r9d
        call     [<unknown method>]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
-       cmp      dword ptr [rsp+0x40], 0
-       je       G_M22410_IG06
-						;; size=133 bbWeight=4 PerfScore 120.00
-G_M22410_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0080 {rdi}, byref
-       ; gcrRegs -[rbp rsi]
-       mov      rdx, gword ptr [rsp+0x38]
+       cmp      dword ptr [rsp+0x38], 0
+       je       SHORT G_M22410_IG07
+						;; size=70 bbWeight=4 PerfScore 89.00
+G_M22410_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, byref
+       ; gcrRegs -[rbx rbp]
+       mov      rdx, gword ptr [rsp+0x30]
        ; gcrRegs +[rdx]
-       mov      rcx, rdi
+       mov      rcx, rsi
        ; byrRegs +[rcx]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       mov      eax, dword ptr [rsp+0x40]
-       mov      dword ptr [rdi+0x08], eax
-       mov      rax, rdi
+       mov      eax, dword ptr [rsp+0x38]
+       mov      dword ptr [rsi+0x08], eax
+       mov      rax, rsi
        ; byrRegs +[rax]
 						;; size=23 bbWeight=1 PerfScore 4.50
-G_M22410_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 72
+G_M22410_IG09:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 64
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
-G_M22410_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rax rdi]
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M22410_IG10:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       ; byrRegs -[rax rsi]
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M22410_IG10:        ; bbWeight=0, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rdi}, byref
-       ; gcrRegs +[rbp rsi]
-       ; byrRegs +[rdi]
+G_M22410_IG11:        ; bbWeight=0, gcrefRegs=0028 {rbx rbp}, byrefRegs=0040 {rsi}, byref
+       ; gcrRegs +[rbx rbp]
+       ; byrRegs +[rsi]
        mov      rcx, 0xD1FFAB1E
        mov      edx, 24
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
@@ -162,7 +166,7 @@ G_M22410_IG10:        ; bbWeight=0, gcrefRegs=0060 {rbp rsi}, byrefRegs=0080 {rd
        jmp      G_M22410_IG03
 						;; size=25 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 319, prolog size 30, PerfScore 155.58, instruction count 82, allocated bytes for code 319 (MethodHash=208fa875) for method System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
+; Total bytes of code 291, prolog size 20, PerfScore 129.21, instruction count 82, allocated bytes for code 291 (MethodHash=208fa875) for method System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -170,13 +174,14 @@ Unwind Info:
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
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
...

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+19.61%</span>) : 34944.dasm - PerfLabTests.CastingPerf:ObjFooIsObj2():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,37 +12,49 @@
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 cse0         [V04,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V05 cse1         [V05,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M3986_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
+       push     rbp
        push     rbx
-						;; size=2 bbWeight=1 PerfScore 2.00
+						;; size=4 bbWeight=1 PerfScore 4.00
 G_M3986_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        xor      ebx, ebx
        mov      esi, dword ptr [(reloc)]
        test     esi, esi
-       jle      SHORT G_M3986_IG04
+       jle      SHORT G_M3986_IG05
 						;; size=12 bbWeight=1 PerfScore 3.50
-G_M3986_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+G_M3986_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.50 PerfScore 1.25
+G_M3986_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
        cmp      ebx, esi
-       jl       SHORT G_M3986_IG03
-						;; size=34 bbWeight=4 PerfScore 20.00
-G_M3986_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       jl       SHORT G_M3986_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M3986_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
        pop      rbx
+       pop      rbp
        pop      rsi
+       pop      rdi
        ret      
-						;; size=3 bbWeight=1 PerfScore 2.00
+						;; size=5 bbWeight=1 PerfScore 3.00
 
-; Total bytes of code 51, prolog size 2, PerfScore 27.50, instruction count 16, allocated bytes for code 51 (MethodHash=9b93f06d) for method PerfLabTests.CastingPerf:ObjFooIsObj2():this (FullOpts)
+; Total bytes of code 61, prolog size 4, PerfScore 23.75, instruction count 22, allocated bytes for code 61 (MethodHash=9b93f06d) for method PerfLabTests.CastingPerf:ObjFooIsObj2():this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -50,10 +62,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x02
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+24.00%</span>) : 35848.dasm - System.Reflection.Invoke:Ctor0_ActivatorCreateInstance_NoParams():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,21 +14,25 @@
 ;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Object>
 ;* V04 tmp2         [V04    ] (  0,  0   )     ref  ->  zero-ref    "CASTCLASS eval op1"
 ;* V05 tmp3         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.RuntimeType>
-;* V06 tmp4         [V06,T01] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.RuntimeType>
+;* V06 tmp4         [V06,T02] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.RuntimeType>
 ;* V07 tmp5         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
 ;* V09 tmp7         [V09    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
+;  V10 cse0         [V10,T01] (  1,  1   )     ref  ->  rsi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M30020_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rsi
        push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+						;; size=6 bbWeight=1 PerfScore 2.25
 G_M30020_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      ebx, ebx
-						;; size=2 bbWeight=1 PerfScore 0.25
-G_M30020_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rsi, 0xD1FFAB1E
+       ; gcrRegs +[rsi]
+						;; size=12 bbWeight=1 PerfScore 0.50
+G_M30020_IG03:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
        mov      edx, 1
@@ -41,13 +45,14 @@ G_M30020_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        jl       SHORT G_M30020_IG03
 						;; size=37 bbWeight=4 PerfScore 21.00
 G_M30020_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rax]
-       add      rsp, 32
+       ; gcrRegs -[rax rsi]
+       add      rsp, 40
        pop      rbx
+       pop      rsi
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=7 bbWeight=1 PerfScore 2.25
 
-; Total bytes of code 50, prolog size 5, PerfScore 24.25, instruction count 13, allocated bytes for code 50 (MethodHash=10de8abb) for method System.Reflection.Invoke:Ctor0_ActivatorCreateInstance_NoParams():this (FullOpts)
+; Total bytes of code 62, prolog size 6, PerfScore 26.00, instruction count 16, allocated bytes for code 62 (MethodHash=10de8abb) for method System.Reflection.Invoke:Ctor0_ActivatorCreateInstance_NoParams():this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -55,10 +60,11 @@ Unwind Info:
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
<summary><span style="color:red">+28</span> (<span style="color:red">+46.67%</span>) : 35433.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,45 +8,57 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4, 18   )     ref  ->  rbx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
-;  V01 loc0         [V01,T01] (  3, 17   )   float  ->  mm0        
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
+;  V01 loc0         [V01,T02] (  3, 17   )   float  ->  mm0        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;  V04 cse0         [V04,T00] (  2,  9   )   byref  ->  rbx         hoist "CSE - aggressive"
+;  V05 cse1         [V05,T03] (  2,  9   )  double  ->  mm6         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T04] (  2,  9   )   float  ->  mm7         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 64
 
-G_M31728_IG01:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M31728_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=8 bbWeight=8 PerfScore 12.00
-G_M31728_IG02:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       cmp      byte  ptr [rbx], bl
-       lea      rcx, bword ptr [rbx+0x08]
+       sub      rsp, 64
+       vmovaps  xmmword ptr [rsp+0x30], xmm6
+       vmovaps  xmmword ptr [rsp+0x20], xmm7
+						;; size=17 bbWeight=1 PerfScore 5.25
+G_M31728_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rcx]
+       cmp      byte  ptr [rcx], cl
+       lea      rbx, bword ptr [rcx+0x08]
+       ; byrRegs +[rbx]
+       vmovsd   xmm6, qword ptr [reloc @RWD00]
+       vmovss   xmm7, dword ptr [reloc @RWD08]
+						;; size=22 bbWeight=1 PerfScore 9.50
+G_M31728_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, rbx
        ; byrRegs +[rcx]
        call     [System.Random+CompatPrng:InternalSample():int:this]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        vxorps   xmm0, xmm0, xmm0
        vcvtsi2sd xmm0, xmm0, eax
-       vmulsd   xmm0, xmm0, qword ptr [reloc @RWD00]
+       vmulsd   xmm0, xmm0, xmm6
        vcvtsd2ss xmm0, xmm0, xmm0
-       vmovss   xmm1, dword ptr [reloc @RWD08]
-       vucomiss xmm1, xmm0
-       jbe      SHORT G_M31728_IG02
-						;; size=46 bbWeight=8 PerfScore 222.67
-G_M31728_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       add      rsp, 32
+       vucomiss xmm7, xmm0
+       jbe      SHORT G_M31728_IG03
+						;; size=31 bbWeight=8 PerfScore 156.67
+G_M31728_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rbx]
+       vmovaps  xmm6, xmmword ptr [rsp+0x30]
+       vmovaps  xmm7, xmmword ptr [rsp+0x20]
+       add      rsp, 64
        pop      rbx
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=18 bbWeight=1 PerfScore 9.75
 RWD00  	dq	3E00000000200000h	; 4.65661288e-10
 RWD08  	dd	3F800000h		;         1
 
 
-; Total bytes of code 60, prolog size 5, PerfScore 236.42, instruction count 16, allocated bytes for code 60 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
+; Total bytes of code 88, prolog size 17, PerfScore 181.17, instruction count 21, allocated bytes for code 88 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -54,10 +66,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x11
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 2 * 16 = 32 = 0x00020
+    CodeOffset: 0x0B UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 3 * 16 = 48 = 0x00030
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-41</span> (<span style="color:green">-11.55%</span>) : 15455.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,31 +9,32 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  8,189522500.92)     ref  ->  rcx         class-hnd single-def <double[,]>
-;  V01 arg1         [V01,T12] (  9, 67135597.42)     ref  ->  rdx         class-hnd single-def <double[,]>
-;  V02 arg2         [V02,T22] (  6, 32380370.98)     int  ->  [rsp+0x80]  single-def
-;  V03 loc0         [V03,T21] (  6, 32382366.98)     int  ->  rax        
+;  V01 arg1         [V01,T12] (  9, 65553023.78)     ref  ->  rdx         class-hnd single-def <double[,]>
+;  V02 arg2         [V02,T21] (  6, 32380370.98)     int  ->   r8         single-def
+;  V03 loc0         [V03,T22] (  6, 31591080.15)     int  ->  [rsp+0x34] 
 ;  V04 loc1         [V04,T20] (  6, 34757225.45)     int  ->  r10        
-;  V05 loc2         [V05,T05] (  6,158727701.59)     int  ->  rsi        
+;  V05 loc2         [V05,T05] (  6,158727701.59)     int  ->  rdi        
 ;  V06 OutArgs      [V06    ] (  1,        1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T10] (  3,  4753714.94)     int  ->  r11         "MD array shared temp"
-;  V08 tmp2         [V08,T11] (  3,  4753714.94)     int  ->  rbp         "MD array shared temp"
+;  V07 tmp1         [V07,T10] (  3,  4753714.94)     int  ->  rbx         "MD array shared temp"
+;  V08 tmp2         [V08,T11] (  3,  4753714.94)     int  ->  r14         "MD array shared temp"
 ;* V09 tmp3         [V09,T18] (  0,        0   )     int  ->  zero-ref    "MD array shared temp"
 ;* V10 tmp4         [V10,T19] (  0,        0   )     int  ->  zero-ref    "MD array shared temp"
-;  V11 tmp5         [V11,T01] (  3,189522498.92)     int  ->  r13         "MD array shared temp"
-;  V12 tmp6         [V12,T02] (  3,189522498.92)     int  ->   r8         "MD array shared temp"
-;  V13 tmp7         [V13,T03] (  3,189522498.92)     int  ->   r8         "MD array shared temp"
-;  V14 tmp8         [V14,T04] (  3,189522498.92)     int  ->  r15         "MD array shared temp"
-;  V15 cse0         [V15,T14] (  4, 64758737.95)     int  ->  r11         "CSE - moderate"
-;  V16 cse1         [V16,T15] (  4, 64758737.95)     int  ->  rbp         "CSE - moderate"
-;  V17 cse2         [V17,T16] (  2,  1584571.65)     int  ->  [rsp+0x24]  spill-single-def "CSE - moderate"
-;  V18 cse3         [V18,T17] (  2,  1584571.65)     int  ->  [rsp+0x20]  spill-single-def "CSE - moderate"
-;  V19 cse4         [V19,T13] (  5, 65551023.78)     int  ->  rbx         "CSE - moderate"
-;  V20 cse5         [V20,T06] (  5,157935415.77)     int  ->  rdi         "CSE - aggressive"
-;  V21 cse6         [V21,T07] (  3, 94761249.46)     int  ->  r15         "CSE - moderate"
-;  V22 cse7         [V22,T08] (  3, 94761249.46)     int  ->  r12         "CSE - moderate"
-;  V23 cse8         [V23,T09] (  3, 94761249.46)     int  ->   r9         "CSE - moderate"
+;  V11 tmp5         [V11,T01] (  3,189522498.92)     int  ->  r12         "MD array shared temp"
+;  V12 tmp6         [V12,T02] (  3,189522498.92)     int  ->  rax         "MD array shared temp"
+;  V13 tmp7         [V13,T03] (  3,189522498.92)     int  ->  rax         "MD array shared temp"
+;  V14 tmp8         [V14,T04] (  3,189522498.92)     int  ->   r9         "MD array shared temp"
+;  V15 cse0         [V15,T14] (  4, 64758737.95)     int  ->  rbx         "CSE - moderate"
+;  V16 cse1         [V16,T15] (  4, 64758737.95)     int  ->  r14         "CSE - moderate"
+;  V17 cse2         [V17,T17] (  2,   793284.82)     int  ->  [rsp+0x30]  spill-single-def hoist "CSE - moderate"
+;  V18 cse3         [V18,T16] (  2,  1584571.65)     int  ->  [rsp+0x2C]  spill-single-def "CSE - moderate"
+;  V19 cse4         [V19,T13] (  5, 65551023.78)     int  ->  rsi         "CSE - moderate"
+;  V20 cse5         [V20,T06] (  5,157935415.77)     int  ->  r11         "CSE - aggressive"
+;  V21 cse6         [V21,T23] (  2,   793284.82)     int  ->  [rsp+0x28]  spill-single-def hoist "CSE - moderate"
+;  V22 cse7         [V22,T07] (  3, 94761249.46)     int  ->  r13         "CSE - moderate"
+;  V23 cse8         [V23,T08] (  3, 94761249.46)     int  ->   r9         "CSE - moderate"
+;  V24 cse9         [V24,T09] (  3, 94761249.46)     int  ->  rbp         "CSE - moderate"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M7242_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -44,98 +45,97 @@ G_M7242_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
 						;; size=16 bbWeight=1 PerfScore 8.25
 G_M7242_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx rdx]
        mov      eax, 1
-       mov      dword ptr [rsp+0x80], r8d
        test     r8d, r8d
        jle      G_M7242_IG08
-						;; size=22 bbWeight=1 PerfScore 2.50
+						;; size=14 bbWeight=1 PerfScore 1.50
 G_M7242_IG03:        ; bbWeight=999.00, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        mov      r10d, 1
-						;; size=6 bbWeight=999.00 PerfScore 249.75
-G_M7242_IG04:        ; bbWeight=792285.82, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        mov      r9d, eax
        sub      r9d, dword ptr [rdx+0x18]
-       mov      dword ptr [rsp+0x24], r9d
-       mov      r11d, r9d
-       cmp      r11d, dword ptr [rdx+0x10]
+       mov      dword ptr [rsp+0x30], r9d
+       mov      r11d, dword ptr [rdx+0x10]
+       mov      dword ptr [rsp+0x28], r11d
+						;; size=27 bbWeight=999.00 PerfScore 7492.50
+G_M7242_IG04:        ; bbWeight=792285.82, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
+       mov      ebx, r9d
+       cmp      ebx, r11d
        jae      G_M7242_IG09
-       mov      ebx, dword ptr [rdx+0x14]
-       mov      esi, r11d
-       imul     esi, ebx
-       mov      edi, r10d
-       sub      edi, dword ptr [rdx+0x1C]
-       mov      dword ptr [rsp+0x20], edi
-       mov      ebp, edi
-       cmp      ebp, ebx
+       mov      esi, dword ptr [rdx+0x14]
+       mov      edi, ebx
+       imul     edi, esi
+       mov      ebp, r10d
+       sub      ebp, dword ptr [rdx+0x1C]
+       mov      dword ptr [rsp+0x2C], ebp
+       mov      r14d, ebp
+       cmp      r14d, esi
        jae      G_M7242_IG09
-       add      esi, ebp
-       xor      r14d, r14d
-       mov      qword ptr [rdx+8*rsi+0x20], r14
-       mov      esi, 1
-						;; size=69 bbWeight=792285.82 PerfScore 16043787.91
+       add      edi, r14d
+       xor      r15d, r15d
+       mov      qword ptr [rdx+8*rdi+0x20], r15
+       mov      edi, 1
+						;; size=58 bbWeight=792285.82 PerfScore 10497787.15
 G_M7242_IG05:        ; bbWeight=31587083.15, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
-       mov      r14d, r11d
-       imul     r14d, ebx
-       add      r14d, ebp
-       mov      r15d, r11d
-       imul     r15d, ebx
-       add      r15d, ebp
-       vmovsd   xmm0, qword ptr [rdx+8*r15+0x20]
-       mov      r15d, dword ptr [rcx+0x18]
-       mov      r13d, eax
-       sub      r13d, r15d
-       mov      r12d, dword ptr [rcx+0x10]
-       cmp      r13d, r12d
+       mov      r15d, ebx
+       imul     r15d, esi
+       add      r15d, r14d
+       mov      r13d, ebx
+       imul     r13d, esi
+       add      r13d, r14d
+       vmovsd   xmm0, qword ptr [rdx+8*r13+0x20]
+       mov      r13d, dword ptr [rcx+0x18]
+       mov      dword ptr [rsp+0x34], eax
+       mov      r12d, eax
+       sub      r12d, r13d
+       mov      r9d, dword ptr [rcx+0x10]
+       cmp      r12d, r9d
        jae      G_M7242_IG09
-       mov      edi, dword ptr [rcx+0x14]
-       imul     r13d, edi
-       mov      r9d, dword ptr [rcx+0x1C]
-       mov      r8d, esi
-       sub      r8d, r9d
-       cmp      r8d, edi
-       jae      G_M7242_IG09
-       add      r8d, r13d
-       vmovsd   xmm1, qword ptr [rcx+8*r8+0x20]
-       mov      r8d, esi
-       sub      r8d, r15d
-       cmp      r8d, r12d
-       jae      G_M7242_IG09
-       imul     r8d, edi
-       mov      r15d, r10d
-       sub      r15d, r9d
-       cmp      r15d, edi
+       mov      r11d, dword ptr [rcx+0x14]
+       imul     r12d, r11d
+       mov      ebp, dword ptr [rcx+0x1C]
+       mov      eax, edi
+       sub      eax, ebp
+       cmp      eax, r11d
        jae      SHORT G_M7242_IG09
-       add      r8d, r15d
-       vmulsd   xmm1, xmm1, qword ptr [rcx+8*r8+0x20]
+       add      eax, r12d
+       vmovsd   xmm1, qword ptr [rcx+8*rax+0x20]
+       mov      eax, edi
+       sub      eax, r13d
+       cmp      eax, r9d
+       jae      SHORT G_M7242_IG09
+       imul     eax, r11d
+       mov      r9d, r10d
+       sub      r9d, ebp
+       cmp      r9d, r11d
+       jae      SHORT G_M7242_IG09
+       add      eax, r9d
+       vmulsd   xmm1, xmm1, qword ptr [rcx+8*rax+0x20]
        vaddsd   xmm0, xmm0, xmm1
-       vmovsd   qword ptr [rdx+8*r14+0x20], xmm0
-       inc      esi
-       mov      r8d, dword ptr [rsp+0x80]
-       cmp      esi, r8d
-       mov      dword ptr [rsp+0x80], r8d
+       vmovsd   qword ptr [rdx+8*r15+0x20], xmm0
+       inc      edi
+       cmp      edi, r8d
+       mov      eax, dword ptr [rsp+0x34]
        jle      G_M7242_IG05
-						;; size=164 bbWeight=31587083.15 PerfScore 1484592908.23
+						;; size=143 bbWeight=31587083.15 PerfScore 1484592908.23
 G_M7242_IG06:        ; bbWeight=792285.82, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        inc      r10d
-       mov      r8d, dword ptr [rsp+0x80]
        cmp      r10d, r8d
-       mov      dword ptr [rsp+0x80], r8d
+       mov      r9d, dword ptr [rsp+0x30]
+       mov      r11d, dword ptr [rsp+0x28]
        jle      G_M7242_IG04
-						;; size=28 bbWeight=792285.82 PerfScore 2773000.38
+						;; size=22 bbWeight=792285.82 PerfScore 2773000.38
 G_M7242_IG07:        ; bbWeight=999.00, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        inc      eax
-       mov      r8d, dword ptr [rsp+0x80]
        cmp      eax, r8d
-       mov      dword ptr [rsp+0x80], r8d
        jle      G_M7242_IG03
-						;; size=27 bbWeight=999.00 PerfScore 3496.50
+						;; size=11 bbWeight=999.00 PerfScore 1498.50
 G_M7242_IG08:        ; bbWeight=1.00, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx rdx]
-       add      rsp, 40
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
@@ -152,7 +152,7 @@ G_M7242_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 355, prolog size 16, PerfScore 1503413458.77, instruction count 95, allocated bytes for code 355 (MethodHash=2f4fe3b5) for method Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
+; Total bytes of code 314, prolog size 16, PerfScore 1497872701.76, instruction count 94, allocated bytes for code 314 (MethodHash=2f4fe3b5) for method Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -165,7 +165,7 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-45</span> (<span style="color:green">-9.02%</span>) : 83141.dasm - BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -13,30 +13,31 @@
 ;* V00 arg0         [V00    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.String>
 ;* V01 arg1         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.String>
 ;  V02 arg2         [V02,T06] (  4,198.71)     ref  ->  rbx         class-hnd single-def <ubyte[]>
-;  V03 arg3         [V03,T10] (  7,  8.58)     int  ->  rsi        
-;  V04 arg4         [V04,T14] (  5,  0.10)     ref  ->  [rsp+0x190]  class-hnd single-def tier0-frame <System.IO.Stream>
-;  V05 loc0         [V05,T07] (  4,103.29)     int  ->  rbp        
+;  V03 arg3         [V03,T11] (  7,  8.58)     int  ->  rsi        
+;  V04 arg4         [V04,T15] (  5,  0.10)     ref  ->  [rsp+0x190]  class-hnd single-def tier0-frame <System.IO.Stream>
+;  V05 loc0         [V05,T08] (  4,103.29)     int  ->  rbp        
 ;  V06 loc1         [V06,T02] (  6,492.11)     int  ->  rdi        
-;  V07 loc2         [V07,T08] (  1, 98.36)     int  ->  r14        
+;  V07 loc2         [V07,T09] (  1, 98.36)     int  ->  r14        
 ;* V08 loc3         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <ubyte[]>
-;  V09 loc4         [V09,T05] (  5,298.36)     int  ->   r9        
+;  V09 loc4         [V09,T04] (  5,298.36)     int  ->   r9        
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "dup spill" <System.String[]>
 ;* V12 tmp2         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.Text.ASCIIEncoding+ASCIIEncodingSealed>
 ;* V13 tmp3         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "spilling ret_expr" <System.String>
-;  V14 tmp4         [V14,T13] (  3,  3.29)     int  ->  rbp        
-;  V15 tmp5         [V15,T00] (  4,786.84)     int  ->  rdx         "dup spill"
-;  V16 tmp6         [V16,T01] (  3,590.13)     ref  ->  rcx         class-hnd "impAppendStmt" <ubyte[]>
-;  V17 tmp7         [V17,T03] (  2,393.42)     int  ->   r8         "Strict ordering of exceptions for Array store"
-;  V18 tmp8         [V18,T09] (  4, 13.16)     int  ->   r9         "dup spill"
-;  V19 tmp9         [V19,T11] (  3,  9.87)     ref  ->  rdx         class-hnd "impAppendStmt" <ubyte[]>
+;  V14 tmp4         [V14,T14] (  3,  3.29)     int  ->  rbp        
+;  V15 tmp5         [V15,T00] (  4,786.84)     int  ->  rcx         "dup spill"
+;  V16 tmp6         [V16,T01] (  3,590.13)     ref  ->   r8         class-hnd "impAppendStmt" <ubyte[]>
+;  V17 tmp7         [V17,T03] (  2,393.42)     int  ->  rax         "Strict ordering of exceptions for Array store"
+;  V18 tmp8         [V18,T10] (  4, 13.16)     int  ->   r9         "dup spill"
+;  V19 tmp9         [V19,T12] (  3,  9.87)     ref  ->  rcx         class-hnd "impAppendStmt" <ubyte[]>
 ;* V20 tmp10        [V20    ] (  0,  0   )     ref  ->  zero-ref    "guarded devirt return temp"
 ;* V21 tmp11        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Text.ASCIIEncoding+ASCIIEncodingSealed>
 ;* V22 tmp12        [V22    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt arg temp"
 ;* V23 tmp13        [V23    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.IO.Stream+NullStream>
 ;* V24 tmp14        [V24    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.IO.Stream+NullStream>
-;  V25 cse0         [V25,T12] (  6,  4.93)     int  ->  rax         "CSE - aggressive"
-;  V26 cse1         [V26,T04] (  7,300.10)    long  ->  r15         multi-def "CSE - aggressive"
+;  V25 cse0         [V25,T07] (  7,104.91)     ref  ->  rdx         hoist multi-def "CSE - aggressive"
+;  V26 cse1         [V26,T13] (  6,  4.93)     int  ->  rax         "CSE - aggressive"
+;  V27 cse2         [V27,T05] (  7,203.36)    long  ->  r15         hoist multi-def "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -59,22 +60,20 @@ G_M58408_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M58408_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M58408_IG07
 						;; size=2 bbWeight=1 PerfScore 2.00
-G_M58408_IG03:        ; bbWeight=1.64, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M58408_IG03:        ; bbWeight=1.64, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rdx]
        cmp      esi, 60
-       jl       G_M58408_IG18
+       jl       G_M58408_IG19
        mov      ebp, 60
 						;; size=14 bbWeight=1.64 PerfScore 2.47
-G_M58408_IG04:        ; bbWeight=1.64, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       mov      r9, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      r9, gword ptr [r9]
-       ; gcrRegs +[r9]
-       mov      r9d, dword ptr [r9+0x08]
-       ; gcrRegs -[r9]
+G_M58408_IG04:        ; bbWeight=1.64, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref
+       mov      r9d, dword ptr [rdx+0x08]
        sub      r9d, eax
        cmp      r9d, ebp
-       jl       G_M58408_IG12
-						;; size=29 bbWeight=1.64 PerfScore 9.46
+       jl       G_M58408_IG13
+						;; size=16 bbWeight=1.64 PerfScore 5.76
 G_M58408_IG05:        ; bbWeight=0.82, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rdx]
        mov      r13, gword ptr [rsp+0x190]
        ; gcrRegs +[r13]
 						;; size=8 bbWeight=0.82 PerfScore 0.82
@@ -85,83 +84,87 @@ G_M58408_IG06:        ; bbWeight=1.64, gcrefRegs=2008 {rbx r13}, byrefRegs=0000
 G_M58408_IG07:        ; bbWeight=1.64, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[r13]
        cmp      r9d, ebp
-       jge      SHORT G_M58408_IG10
+       jge      SHORT G_M58408_IG11
 						;; size=5 bbWeight=1.64 PerfScore 2.06
-G_M58408_IG08:        ; bbWeight=98.36, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+G_M58408_IG08:        ; bbWeight=1.62, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       mov      r15, 0xD1FFAB1E      ; static handle
+       mov      rdx, 0xD1FFAB1E      ; static handle
+       mov      rdx, gword ptr [rdx]
+       ; gcrRegs +[rdx]
+						;; size=23 bbWeight=1.62 PerfScore 4.04
+G_M58408_IG09:        ; bbWeight=98.36, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref, isz
        cmp      edi, r14d
-       je       G_M58408_IG11
-						;; size=9 bbWeight=98.36 PerfScore 122.94
-G_M58408_IG09:        ; bbWeight=98.36, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      r15, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      edx, dword ptr [r15]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rcx, gword ptr [rcx]
-       ; gcrRegs +[rcx]
-       lea      r8d, [rdx+0x01]
-       mov      dword ptr [r15], r8d
+       je       SHORT G_M58408_IG12
+						;; size=5 bbWeight=98.36 PerfScore 122.94
+G_M58408_IG10:        ; bbWeight=98.36, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, dword ptr [r15]
+       mov      r8, rdx
+       ; gcrRegs +[r8]
+       lea      eax, [rcx+0x01]
+       mov      dword ptr [r15], eax
        cmp      edi, dword ptr [rbx+0x08]
-       jae      G_M58408_IG17
-       mov      r8d, edi
-       movzx    r8, byte  ptr [rbx+r8+0x10]
-       cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M58408_IG17
-       mov      byte  ptr [rcx+rdx+0x10], r8b
+       jae      G_M58408_IG18
+       mov      eax, edi
+       movzx    rax, byte  ptr [rbx+rax+0x10]
+       cmp      ecx, dword ptr [r8+0x08]
+       jae      G_M58408_IG18
+       mov      byte  ptr [r8+rcx+0x10], al
        inc      edi
        inc      r9d
        cmp      r9d, ebp
-       jl       SHORT G_M58408_IG08
-						;; size=75 bbWeight=98.36 PerfScore 1868.75
-G_M58408_IG10:        ; bbWeight=1.64, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rcx]
+       jl       SHORT G_M58408_IG09
+						;; size=53 bbWeight=98.36 PerfScore 1647.45
+G_M58408_IG11:        ; bbWeight=1.64, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rdx r8]
        mov      r15, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      r9d, dword ptr [r15]
        mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rdx, gword ptr [rdx]
        ; gcrRegs +[rdx]
+       mov      rcx, rdx
+       ; gcrRegs +[rcx]
        lea      eax, [r9+0x01]
        mov      dword ptr [r15], eax
-       cmp      r9d, dword ptr [rdx+0x08]
-       jae      G_M58408_IG17
-       mov      byte  ptr [rdx+r9+0x10], 10
+       cmp      r9d, dword ptr [rcx+0x08]
+       jae      G_M58408_IG18
+       mov      byte  ptr [rcx+r9+0x10], 10
        add      esi, -60
        test     esi, esi
-       jle      SHORT G_M58408_IG14
+       jle      SHORT G_M58408_IG15
        jmp      G_M58408_IG03
-						;; size=61 bbWeight=1.64 PerfScore 23.85
-G_M58408_IG11:        ; bbWeight=0.34, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rdx]
+						;; size=64 bbWeight=1.64 PerfScore 24.26
+G_M58408_IG12:        ; bbWeight=0.34, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx]
        xor      edi, edi
-       jmp      G_M58408_IG09
-						;; size=7 bbWeight=0.34 PerfScore 0.75
-G_M58408_IG12:        ; bbWeight=0.10, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M58408_IG10
+						;; size=4 bbWeight=0.34 PerfScore 0.75
+G_M58408_IG13:        ; bbWeight=0.10, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref, isz
        mov      r9, 0xD1FFAB1E      ; System.IO.Stream+NullStream
        mov      r13, gword ptr [rsp+0x190]
        ; gcrRegs +[r13]
        cmp      qword ptr [r13], r9
-       jne      SHORT G_M58408_IG19
+       jne      SHORT G_M58408_IG20
 						;; size=24 bbWeight=0.10 PerfScore 0.53
-G_M58408_IG13:        ; bbWeight=0.10, gcrefRegs=2008 {rbx r13}, byrefRegs=0000 {}, byref
+G_M58408_IG14:        ; bbWeight=0.10, gcrefRegs=2008 {rbx r13}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rdx]
        xor      eax, eax
        mov      dword ptr [r15], eax
        jmp      G_M58408_IG06
 						;; size=10 bbWeight=0.10 PerfScore 0.33
-G_M58408_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rbx r13]
+G_M58408_IG15:        ; bbWeight=0, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rbx r13] +[rdx]
        mov      r13, gword ptr [rsp+0x190]
        ; gcrRegs +[r13]
        test     eax, eax
-       je       SHORT G_M58408_IG16
+       je       SHORT G_M58408_IG17
        mov      r9d, eax
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rdx]
-       ; gcrRegs +[rdx]
        mov      rcx, r13
        ; gcrRegs +[rcx]
        xor      r8d, r8d
        mov      rax, qword ptr [r13]
        mov      rax, qword ptr [rax+0x68]
-						;; size=42 bbWeight=0 PerfScore 0.00
-G_M58408_IG15:        ; bbWeight=0, epilog, nogc, extend
+						;; size=29 bbWeight=0 PerfScore 0.00
+G_M58408_IG16:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 304
        pop      rbx
        pop      rsi
@@ -172,7 +175,7 @@ G_M58408_IG15:        ; bbWeight=0, epilog, nogc, extend
        pop      rbp
        tail.jmp [rax+0x30]<unknown method>
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M58408_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+G_M58408_IG17:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx rdx r13]
        add      rsp, 304
        pop      rbx
@@ -184,23 +187,20 @@ G_M58408_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        pop      rbp
        ret      
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M58408_IG17:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M58408_IG18:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M58408_IG18:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; gcrRegs +[rbx]
+G_M58408_IG19:        ; bbWeight=0, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rdx rbx]
        mov      r13, gword ptr [rsp+0x190]
        ; gcrRegs +[r13]
        mov      ebp, esi
        mov      gword ptr [rsp+0x190], r13
        jmp      G_M58408_IG04
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M58408_IG19:        ; bbWeight=0, gcrefRegs=2008 {rbx r13}, byrefRegs=0000 {}, byref
+G_M58408_IG20:        ; bbWeight=0, gcrefRegs=200C {rdx rbx r13}, byrefRegs=0000 {}, byref, isz
        mov      r9d, eax
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rdx]
-       ; gcrRegs +[rdx]
        mov      rcx, r13
        ; gcrRegs +[rcx]
        xor      r8d, r8d
@@ -209,10 +209,10 @@ G_M58408_IG19:        ; bbWeight=0, gcrefRegs=2008 {rbx r13}, byrefRegs=0000 {},
        call     [rax+0x30]<unknown method>
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-       jmp      G_M58408_IG13
-						;; size=38 bbWeight=0 PerfScore 0.00
+       jmp      SHORT G_M58408_IG14
...

```


</div></details>

<details>
<summary><span style="color:green">-5</span> (<span style="color:green">-7.94%</span>) : 44706.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -12,7 +12,8 @@
 ;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <int[]>
 ;  V02 loc0         [V02,T01] (  5,  5   )     int  ->   r8        
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 cse0         [V04,T03] (  3,  3   )     int  ->  r10         "CSE - aggressive"
+;  V04 cse0         [V04,T04] (  2,  2   )     int  ->  rcx         hoist "CSE - aggressive"
+;  V05 cse1         [V05,T03] (  3,  3   )     int  ->  r10         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -24,16 +25,15 @@ G_M26314_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byr
        xor      r8d, r8d
        mov      r10d, dword ptr [rdx+0x08]
        test     r10d, r10d
-       jle      SHORT G_M26314_IG07
-						;; size=12 bbWeight=1 PerfScore 3.50
+       jle      SHORT G_M26314_IG06
+       and      ecx, 0xD1FFAB1E
+						;; size=18 bbWeight=1 PerfScore 3.75
 G_M26314_IG03:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
        mov      eax, r8d
-       mov      r9d, ecx
-       and      r9d, 0xD1FFAB1E
-       cmp      dword ptr [rdx+4*rax+0x10], r9d
+       cmp      dword ptr [rdx+4*rax+0x10], ecx
        jne      SHORT G_M26314_IG05
        mov      eax, 1
-						;; size=25 bbWeight=1 PerfScore 5.00
+						;; size=14 bbWeight=1 PerfScore 4.50
 G_M26314_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
@@ -41,21 +41,19 @@ G_M26314_IG04:        ; bbWeight=1, epilog, nogc, extend
 G_M26314_IG05:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, gcvars, byref, isz
        inc      r8d
        cmp      r10d, r8d
-       jle      SHORT G_M26314_IG07
-						;; size=8 bbWeight=1 PerfScore 1.50
-G_M26314_IG06:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
+       jle      SHORT G_M26314_IG06
        jmp      SHORT G_M26314_IG03
-						;; size=2 bbWeight=0.50 PerfScore 1.00
-G_M26314_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=10 bbWeight=1 PerfScore 3.50
+G_M26314_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdx]
        xor      eax, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M26314_IG08:        ; bbWeight=0, epilog, nogc, extend
+G_M26314_IG07:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 63, prolog size 4, PerfScore 12.50, instruction count 20, allocated bytes for code 63 (MethodHash=e1fd9935) for method System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
+; Total bytes of code 58, prolog size 4, PerfScore 13.25, instruction count 19, allocated bytes for code 58 (MethodHash=e1fd9935) for method System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+28.77%</span>) : 36153.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -14,40 +14,50 @@
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 cse0         [V04,T01] (  3,100.01)     int  ->  rsi         "CSE - aggressive"
+;  V05 cse1         [V05,T02] (  2,100.00)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T03] (  2,100.00)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M22144_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 16
-       mov      qword ptr [rsp+0x80], rsi
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x4C]
-						;; size=21 bbWeight=0.01 PerfScore 0.04
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=0.01 PerfScore 0.05
 G_M22144_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      esi, dword ptr [(reloc)]
        cmp      ebx, esi
-       jge      SHORT G_M22144_IG04
+       jge      SHORT G_M22144_IG05
 						;; size=10 bbWeight=0.01 PerfScore 0.03
-G_M22144_IG03:        ; bbWeight=99.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+G_M22144_IG03:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.01 PerfScore 0.02
+G_M22144_IG04:        ; bbWeight=99.99, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
        cmp      ebx, esi
-       jl       SHORT G_M22144_IG03
-						;; size=34 bbWeight=99.99 PerfScore 499.95
-G_M22144_IG04:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       jl       SHORT G_M22144_IG04
+						;; size=17 bbWeight=99.99 PerfScore 299.97
+G_M22144_IG05:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
        pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=8 bbWeight=0.01 PerfScore 0.03
+						;; size=12 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 73, prolog size 21, PerfScore 500.05, instruction count 19, allocated bytes for code 73 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 300.11, instruction count 23, allocated bytes for code 94 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -55,15 +65,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 16 * 8 = 128 = 0x00080
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 18 * 8 = 144 = 0x00090
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+28.77%</span>) : 29951.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -13,40 +13,50 @@
 ;  V01 loc0         [V01,T00] (  4,299.98)     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 cse0         [V03,T01] (  3,100.01)     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,100.00)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,100.00)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M51548_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 16
-       mov      qword ptr [rsp+0x80], rsi
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x4C]
-						;; size=21 bbWeight=0.01 PerfScore 0.04
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=0.01 PerfScore 0.05
 G_M51548_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      esi, dword ptr [(reloc)]
        cmp      ebx, esi
-       jge      SHORT G_M51548_IG04
+       jge      SHORT G_M51548_IG05
 						;; size=10 bbWeight=0.01 PerfScore 0.03
-G_M51548_IG03:        ; bbWeight=99.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+G_M51548_IG03:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.01 PerfScore 0.02
+G_M51548_IG04:        ; bbWeight=99.99, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
        cmp      ebx, esi
-       jl       SHORT G_M51548_IG03
-						;; size=34 bbWeight=99.99 PerfScore 499.95
-G_M51548_IG04:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       jl       SHORT G_M51548_IG04
+						;; size=17 bbWeight=99.99 PerfScore 299.97
+G_M51548_IG05:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
        pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=8 bbWeight=0.01 PerfScore 0.03
+						;; size=12 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 73, prolog size 21, PerfScore 500.05, instruction count 19, allocated bytes for code 73 (MethodHash=fbb236a3) for method PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 300.11, instruction count 23, allocated bytes for code 94 (MethodHash=fbb236a3) for method PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -54,15 +64,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 16 * 8 = 128 = 0x00080
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 18 * 8 = 144 = 0x00090
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+39</span> (<span style="color:red">+33.91%</span>) : 90302.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjrefValueTypeObj():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -13,63 +13,79 @@
 ;  V01 loc0         [V01,T01] (  4,299.98)     int  ->  rbx        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 tmp1         [V03,T00] (  4,699.93)     ref  ->  rsi         "inline UNBOX clone1"
-;  V04 cse0         [V04,T03] (  3,100.01)     int  ->  rbp         "CSE - aggressive"
-;  V05 cse1         [V05,T02] (  3,249.98)    long  ->  rcx         "CSE - aggressive"
+;  V04 cse0         [V04,T04] (  2,100.00)   byref  ->  r13         hoist "CSE - aggressive"
+;  V05 cse1         [V05,T03] (  3,100.01)     int  ->  rbp         "CSE - aggressive"
+;  V06 cse2         [V06,T05] (  2,100.00)     ref  ->  r14         hoist "CSE - aggressive"
+;  V07 cse3         [V07,T02] (  3,150.00)    long  ->  r15         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M64166_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 72
-       mov      qword ptr [rsp+0xA8], rbx
-       mov      ebx, dword ptr [rsp+0x84]
-						;; size=19 bbWeight=0.01 PerfScore 0.03
+       sub      rsp, 88
+       mov      qword ptr [rsp+0xB8], r15
+       mov      qword ptr [rsp+0xB0], r14
+       mov      qword ptr [rsp+0xA8], r13
+       mov      qword ptr [rsp+0xA0], rbx
+       mov      ebx, dword ptr [rsp+0x94]
+						;; size=43 bbWeight=0.01 PerfScore 0.06
 G_M64166_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      ebp, dword ptr [(reloc)]
        cmp      ebx, ebp
-       jge      SHORT G_M64166_IG06
+       jge      SHORT G_M64166_IG07
 						;; size=10 bbWeight=0.01 PerfScore 0.03
-G_M64166_IG03:        ; bbWeight=99.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rsi, gword ptr [rdx]
+G_M64166_IG03:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rdx, 0xD1FFAB1E      ; static handle
+       mov      r14, gword ptr [rdx]
+       ; gcrRegs +[r14]
+       mov      r15, 0xD1FFAB1E      ; PerfLabTests.CastingPerf2.FooORVT
+       mov      rdx, 0xD1FFAB1E
+       mov      r13, gword ptr [rdx]
+       ; gcrRegs +[r13]
+       add      r13, 8
+       ; gcrRegs -[r13]
+       ; byrRegs +[r13]
+						;; size=40 bbWeight=0.01 PerfScore 0.05
+G_M64166_IG04:        ; bbWeight=99.99, gcrefRegs=4000 {r14}, byrefRegs=2000 {r13}, byref, isz
+       mov      rsi, r14
        ; gcrRegs +[rsi]
-       mov      rcx, 0xD1FFAB1E      ; PerfLabTests.CastingPerf2.FooORVT
-       cmp      qword ptr [rsi], rcx
-       je       SHORT G_M64166_IG05
-						;; size=28 bbWeight=99.99 PerfScore 649.94
-G_M64166_IG04:        ; bbWeight=50.00, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
+       cmp      qword ptr [rsi], r15
+       je       SHORT G_M64166_IG06
+						;; size=8 bbWeight=99.99 PerfScore 424.96
+G_M64166_IG05:        ; bbWeight=50.00, gcrefRegs=4040 {rsi r14}, byrefRegs=2000 {r13}, byref
        mov      rdx, rsi
        ; gcrRegs +[rdx]
+       mov      rcx, r15
        call     [CORINFO_HELP_UNBOX]
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
-						;; size=9 bbWeight=50.00 PerfScore 162.48
-G_M64166_IG05:        ; bbWeight=99.99, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref, isz
+						;; size=12 bbWeight=50.00 PerfScore 174.98
+G_M64166_IG06:        ; bbWeight=99.99, gcrefRegs=4040 {rsi r14}, byrefRegs=2000 {r13}, byref, isz
        add      rsi, 8
        ; gcrRegs -[rsi]
        ; byrRegs +[rsi]
-       mov      rax, 0xD1FFAB1E      ; box for <unknown class>:<unknown field>
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
-       add      rdi, 8
-       ; gcrRegs -[rdi]
+       mov      rdi, r13
        ; byrRegs +[rdi]
        call     CORINFO_HELP_ASSIGN_BYREF
        call     CORINFO_HELP_ASSIGN_BYREF
        inc      ebx
        cmp      ebx, ebp
-       jl       SHORT G_M64166_IG03
-						;; size=37 bbWeight=99.99 PerfScore 624.94
-G_M64166_IG06:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; byrRegs -[rsi rdi]
-       add      rsp, 168
+       jl       SHORT G_M64166_IG04
+						;; size=23 bbWeight=99.99 PerfScore 399.96
+G_M64166_IG07:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[r14]
+       ; byrRegs -[rsi rdi r13]
+       add      rsp, 160
        pop      rbx
+       pop      r13
+       pop      r14
+       pop      r15
        pop      rsi
        pop      rdi
        pop      rbp
        ret      
-						;; size=12 bbWeight=0.01 PerfScore 0.03
+						;; size=18 bbWeight=0.01 PerfScore 0.05
 
-; Total bytes of code 115, prolog size 19, PerfScore 1437.45, instruction count 28, allocated bytes for code 115 (MethodHash=1c150559) for method PerfLabTests.CastingPerf2.CastingPerf:ObjrefValueTypeObj():this (Tier1-OSR)
+; Total bytes of code 154, prolog size 43, PerfScore 1000.09, instruction count 37, allocated bytes for code 154 (MethodHash=1c150559) for method PerfLabTests.CastingPerf2.CastingPerf:ObjrefValueTypeObj():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -77,14 +93,20 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x24
+  CountOfUnwindCodes: 13
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+    CodeOffset: 0x24 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 20 * 8 = 160 = 0x000A0
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: r13 (13)
       Scaled Small Offset: 21 * 8 = 168 = 0x000A8
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: r14 (14)
+      Scaled Small Offset: 22 * 8 = 176 = 0x000B0
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: r15 (15)
+      Scaled Small Offset: 23 * 8 = 184 = 0x000B8
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 10 * 8 + 8 = 88 = 0x58
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 12 * 8 + 8 = 104 = 0x68
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-41</span> (<span style="color:green">-11.55%</span>) : 12780.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,31 +8,32 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  8,386   )     ref  ->  rcx         class-hnd single-def <double[,]>
-;  V01 arg1         [V01,T09] (  9,210   )     ref  ->  rdx         class-hnd single-def <double[,]>
-;  V02 arg2         [V02,T22] (  6, 87   )     int  ->  [rsp+0x80]  single-def
-;  V03 loc0         [V03,T21] (  6, 93   )     int  ->  rax        
+;  V01 arg1         [V01,T12] (  9,186   )     ref  ->  rdx         class-hnd single-def <double[,]>
+;  V02 arg2         [V02,T21] (  6, 87   )     int  ->   r8         single-def
+;  V03 loc0         [V03,T22] (  6, 81   )     int  ->  [rsp+0x34] 
 ;  V04 loc1         [V04,T18] (  6,132   )     int  ->  r10        
-;  V05 loc2         [V05,T05] (  6,336   )     int  ->  rsi        
+;  V05 loc2         [V05,T05] (  6,336   )     int  ->  rdi        
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T07] (  3, 96   )     int  ->  r11         "MD array shared temp"
-;  V08 tmp2         [V08,T08] (  3, 96   )     int  ->  rbp         "MD array shared temp"
+;  V07 tmp1         [V07,T07] (  3, 96   )     int  ->  rbx         "MD array shared temp"
+;  V08 tmp2         [V08,T08] (  3, 96   )     int  ->  r14         "MD array shared temp"
 ;* V09 tmp3         [V09,T19] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
 ;* V10 tmp4         [V10,T20] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
-;  V11 tmp5         [V11,T01] (  3,384   )     int  ->  r13         "MD array shared temp"
-;  V12 tmp6         [V12,T02] (  3,384   )     int  ->   r8         "MD array shared temp"
-;  V13 tmp7         [V13,T03] (  3,384   )     int  ->   r8         "MD array shared temp"
-;  V14 tmp8         [V14,T04] (  3,384   )     int  ->  r15         "MD array shared temp"
-;  V15 cse0         [V15,T14] (  4,160   )     int  ->  r11         "CSE - moderate"
-;  V16 cse1         [V16,T15] (  4,160   )     int  ->  rbp         "CSE - moderate"
-;  V17 cse2         [V17,T16] (  2, 32   )     int  ->  [rsp+0x24]  spill-single-def "CSE - moderate"
-;  V18 cse3         [V18,T17] (  2, 32   )     int  ->  [rsp+0x20]  spill-single-def "CSE - moderate"
-;  V19 cse4         [V19,T13] (  5,176   )     int  ->  rbx         "CSE - moderate"
-;  V20 cse5         [V20,T06] (  5,320   )     int  ->  rdi         "CSE - aggressive"
-;  V21 cse6         [V21,T10] (  3,192   )     int  ->  r15         "CSE - moderate"
-;  V22 cse7         [V22,T11] (  3,192   )     int  ->  r12         "CSE - moderate"
-;  V23 cse8         [V23,T12] (  3,192   )     int  ->   r9         "CSE - moderate"
+;  V11 tmp5         [V11,T01] (  3,384   )     int  ->  r12         "MD array shared temp"
+;  V12 tmp6         [V12,T02] (  3,384   )     int  ->  rax         "MD array shared temp"
+;  V13 tmp7         [V13,T03] (  3,384   )     int  ->  rax         "MD array shared temp"
+;  V14 tmp8         [V14,T04] (  3,384   )     int  ->   r9         "MD array shared temp"
+;  V15 cse0         [V15,T14] (  4,160   )     int  ->  rbx         "CSE - moderate"
+;  V16 cse1         [V16,T15] (  4,160   )     int  ->  r14         "CSE - moderate"
+;  V17 cse2         [V17,T17] (  2, 20   )     int  ->  [rsp+0x30]  spill-single-def hoist "CSE - moderate"
+;  V18 cse3         [V18,T16] (  2, 32   )     int  ->  [rsp+0x2C]  spill-single-def "CSE - moderate"
+;  V19 cse4         [V19,T13] (  5,176   )     int  ->  rsi         "CSE - moderate"
+;  V20 cse5         [V20,T06] (  5,320   )     int  ->  r11         "CSE - aggressive"
+;  V21 cse6         [V21,T23] (  2, 20   )     int  ->  [rsp+0x28]  spill-single-def hoist "CSE - moderate"
+;  V22 cse7         [V22,T09] (  3,192   )     int  ->  r13         "CSE - moderate"
+;  V23 cse8         [V23,T10] (  3,192   )     int  ->   r9         "CSE - moderate"
+;  V24 cse9         [V24,T11] (  3,192   )     int  ->  rbp         "CSE - moderate"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M7242_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -43,98 +44,97 @@ G_M7242_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
 						;; size=16 bbWeight=1 PerfScore 8.25
 G_M7242_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx rdx]
        mov      eax, 1
-       mov      dword ptr [rsp+0x80], r8d
        test     r8d, r8d
        jle      G_M7242_IG08
-						;; size=22 bbWeight=1 PerfScore 2.50
+						;; size=14 bbWeight=1 PerfScore 1.50
 G_M7242_IG03:        ; bbWeight=4, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        mov      r10d, 1
-						;; size=6 bbWeight=4 PerfScore 1.00
-G_M7242_IG04:        ; bbWeight=16, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        mov      r9d, eax
        sub      r9d, dword ptr [rdx+0x18]
-       mov      dword ptr [rsp+0x24], r9d
-       mov      r11d, r9d
-       cmp      r11d, dword ptr [rdx+0x10]
+       mov      dword ptr [rsp+0x30], r9d
+       mov      r11d, dword ptr [rdx+0x10]
+       mov      dword ptr [rsp+0x28], r11d
+						;; size=27 bbWeight=4 PerfScore 30.00
+G_M7242_IG04:        ; bbWeight=16, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
+       mov      ebx, r9d
+       cmp      ebx, r11d
        jae      G_M7242_IG09
-       mov      ebx, dword ptr [rdx+0x14]
-       mov      esi, r11d
-       imul     esi, ebx
-       mov      edi, r10d
-       sub      edi, dword ptr [rdx+0x1C]
-       mov      dword ptr [rsp+0x20], edi
-       mov      ebp, edi
-       cmp      ebp, ebx
+       mov      esi, dword ptr [rdx+0x14]
+       mov      edi, ebx
+       imul     edi, esi
+       mov      ebp, r10d
+       sub      ebp, dword ptr [rdx+0x1C]
+       mov      dword ptr [rsp+0x2C], ebp
+       mov      r14d, ebp
+       cmp      r14d, esi
        jae      G_M7242_IG09
-       add      esi, ebp
-       xor      r14d, r14d
-       mov      qword ptr [rdx+8*rsi+0x20], r14
-       mov      esi, 1
-						;; size=69 bbWeight=16 PerfScore 324.00
+       add      edi, r14d
+       xor      r15d, r15d
+       mov      qword ptr [rdx+8*rdi+0x20], r15
+       mov      edi, 1
+						;; size=58 bbWeight=16 PerfScore 212.00
 G_M7242_IG05:        ; bbWeight=64, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
-       mov      r14d, r11d
-       imul     r14d, ebx
-       add      r14d, ebp
-       mov      r15d, r11d
-       imul     r15d, ebx
-       add      r15d, ebp
-       vmovsd   xmm0, qword ptr [rdx+8*r15+0x20]
-       mov      r15d, dword ptr [rcx+0x18]
-       mov      r13d, eax
-       sub      r13d, r15d
-       mov      r12d, dword ptr [rcx+0x10]
-       cmp      r13d, r12d
+       mov      r15d, ebx
+       imul     r15d, esi
+       add      r15d, r14d
+       mov      r13d, ebx
+       imul     r13d, esi
+       add      r13d, r14d
+       vmovsd   xmm0, qword ptr [rdx+8*r13+0x20]
+       mov      r13d, dword ptr [rcx+0x18]
+       mov      dword ptr [rsp+0x34], eax
+       mov      r12d, eax
+       sub      r12d, r13d
+       mov      r9d, dword ptr [rcx+0x10]
+       cmp      r12d, r9d
        jae      G_M7242_IG09
-       mov      edi, dword ptr [rcx+0x14]
-       imul     r13d, edi
-       mov      r9d, dword ptr [rcx+0x1C]
-       mov      r8d, esi
-       sub      r8d, r9d
-       cmp      r8d, edi
-       jae      G_M7242_IG09
-       add      r8d, r13d
-       vmovsd   xmm1, qword ptr [rcx+8*r8+0x20]
-       mov      r8d, esi
-       sub      r8d, r15d
-       cmp      r8d, r12d
-       jae      G_M7242_IG09
-       imul     r8d, edi
-       mov      r15d, r10d
-       sub      r15d, r9d
-       cmp      r15d, edi
+       mov      r11d, dword ptr [rcx+0x14]
+       imul     r12d, r11d
+       mov      ebp, dword ptr [rcx+0x1C]
+       mov      eax, edi
+       sub      eax, ebp
+       cmp      eax, r11d
        jae      SHORT G_M7242_IG09
-       add      r8d, r15d
-       vmulsd   xmm1, xmm1, qword ptr [rcx+8*r8+0x20]
+       add      eax, r12d
+       vmovsd   xmm1, qword ptr [rcx+8*rax+0x20]
+       mov      eax, edi
+       sub      eax, r13d
+       cmp      eax, r9d
+       jae      SHORT G_M7242_IG09
+       imul     eax, r11d
+       mov      r9d, r10d
+       sub      r9d, ebp
+       cmp      r9d, r11d
+       jae      SHORT G_M7242_IG09
+       add      eax, r9d
+       vmulsd   xmm1, xmm1, qword ptr [rcx+8*rax+0x20]
        vaddsd   xmm0, xmm0, xmm1
-       vmovsd   qword ptr [rdx+8*r14+0x20], xmm0
-       inc      esi
-       mov      r8d, dword ptr [rsp+0x80]
-       cmp      esi, r8d
-       mov      dword ptr [rsp+0x80], r8d
+       vmovsd   qword ptr [rdx+8*r15+0x20], xmm0
+       inc      edi
+       cmp      edi, r8d
+       mov      eax, dword ptr [rsp+0x34]
        jle      G_M7242_IG05
-						;; size=164 bbWeight=64 PerfScore 3008.00
+						;; size=143 bbWeight=64 PerfScore 3008.00
 G_M7242_IG06:        ; bbWeight=16, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        inc      r10d
-       mov      r8d, dword ptr [rsp+0x80]
        cmp      r10d, r8d
-       mov      dword ptr [rsp+0x80], r8d
+       mov      r9d, dword ptr [rsp+0x30]
+       mov      r11d, dword ptr [rsp+0x28]
        jle      G_M7242_IG04
-						;; size=28 bbWeight=16 PerfScore 56.00
+						;; size=22 bbWeight=16 PerfScore 56.00
 G_M7242_IG07:        ; bbWeight=4, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
        inc      eax
-       mov      r8d, dword ptr [rsp+0x80]
        cmp      eax, r8d
-       mov      dword ptr [rsp+0x80], r8d
        jle      G_M7242_IG03
-						;; size=27 bbWeight=4 PerfScore 14.00
+						;; size=11 bbWeight=4 PerfScore 6.00
 G_M7242_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx rdx]
-       add      rsp, 40
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
@@ -151,7 +151,7 @@ G_M7242_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 355, prolog size 16, PerfScore 3419.00, instruction count 95, allocated bytes for code 355 (MethodHash=2f4fe3b5) for method Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
+; Total bytes of code 314, prolog size 16, PerfScore 3327.00, instruction count 94, allocated bytes for code 314 (MethodHash=2f4fe3b5) for method Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -164,7 +164,7 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-35</span> (<span style="color:green">-8.41%</span>) : 48219.dasm - BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -11,26 +11,27 @@
 ;
 ;* V00 arg0         [V00    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.String>
 ;* V01 arg1         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.String>
-;  V02 arg2         [V02,T08] (  4, 34   )     ref  ->  rbx         class-hnd single-def <ubyte[]>
-;  V03 arg3         [V03,T09] (  7, 30   )     int  ->  rsi        
-;  V04 arg4         [V04,T14] (  4,  5   )     ref  ->  rdi         class-hnd single-def <System.IO.Stream>
-;  V05 loc0         [V05,T10] (  4, 28   )     int  ->  r14        
+;  V02 arg2         [V02,T09] (  4, 34   )     ref  ->  rbx         class-hnd single-def <ubyte[]>
+;  V03 arg3         [V03,T10] (  7, 30   )     int  ->  rsi        
+;  V04 arg4         [V04,T15] (  4,  5   )     ref  ->  rdi         class-hnd single-def <System.IO.Stream>
+;  V05 loc0         [V05,T11] (  4, 28   )     int  ->  r14        
 ;  V06 loc1         [V06,T02] (  6, 88   )     int  ->  rbp        
-;  V07 loc2         [V07,T12] (  1, 16   )     int  ->  r15        
+;  V07 loc2         [V07,T13] (  1, 16   )     int  ->  r15        
 ;* V08 loc3         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <ubyte[]>
 ;  V09 loc4         [V09,T06] (  5, 58   )     int  ->   r9        
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "dup spill" <<unknown class>>
 ;* V12 tmp2         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <<unknown class>>
-;  V13 tmp3         [V13,T13] (  3,  6   )     int  ->  r14        
-;  V14 tmp4         [V14,T00] (  4,128   )     int  ->  rdx         "dup spill"
-;  V15 tmp5         [V15,T01] (  3, 96   )     ref  ->  rcx         class-hnd "impAppendStmt" <ubyte[]>
-;  V16 tmp6         [V16,T05] (  2, 64   )     int  ->   r8         "Strict ordering of exceptions for Array store"
-;  V17 tmp7         [V17,T04] (  4, 64   )     int  ->   r9         "dup spill"
-;  V18 tmp8         [V18,T07] (  3, 48   )     ref  ->  rdx         class-hnd "impAppendStmt" <ubyte[]>
+;  V13 tmp3         [V13,T14] (  3,  6   )     int  ->  r14        
+;  V14 tmp4         [V14,T00] (  4,128   )     int  ->  rcx         "dup spill"
+;  V15 tmp5         [V15,T01] (  3, 96   )     ref  ->   r8         class-hnd "impAppendStmt" <ubyte[]>
+;  V16 tmp6         [V16,T04] (  2, 64   )     int  ->  rax         "Strict ordering of exceptions for Array store"
+;  V17 tmp7         [V17,T03] (  4, 64   )     int  ->   r9         "dup spill"
+;  V18 tmp8         [V18,T07] (  3, 48   )     ref  ->  rcx         class-hnd "impAppendStmt" <ubyte[]>
 ;* V19 tmp9         [V19    ] (  0,  0   )     ref  ->  zero-ref    "argument with side effect"
-;  V20 cse0         [V20,T11] (  6, 21.50)     int  ->  rax         "CSE - aggressive"
-;  V21 cse1         [V21,T03] (  7, 74   )    long  ->  r13         multi-def "CSE - aggressive"
+;  V20 cse0         [V20,T08] (  7, 38.50)     ref  ->  rdx         hoist multi-def "CSE - aggressive"
+;  V21 cse1         [V21,T12] (  6, 21.50)     int  ->  rax         "CSE - aggressive"
+;  V22 cse2         [V22,T05] (  7, 60   )    long  ->  r13         hoist multi-def "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -55,28 +56,22 @@ G_M58408_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 G_M58408_IG02:        ; bbWeight=0.01, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M58408_IG07
 						;; size=2 bbWeight=0.01 PerfScore 0.02
-G_M58408_IG03:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M58408_IG03:        ; bbWeight=2, gcrefRegs=008C {rdx rbx rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rdx]
        cmp      esi, 60
        jl       SHORT G_M58408_IG04
        mov      r14d, 60
        jmp      SHORT G_M58408_IG05
 						;; size=13 bbWeight=2 PerfScore 7.00
-G_M58408_IG04:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
+G_M58408_IG04:        ; bbWeight=2, gcrefRegs=008C {rdx rbx rdi}, byrefRegs=0000 {}, byref
        mov      r14d, esi
 						;; size=3 bbWeight=2 PerfScore 0.50
-G_M58408_IG05:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      r9, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      r9, gword ptr [r9]
-       ; gcrRegs +[r9]
-       mov      r9d, dword ptr [r9+0x08]
-       ; gcrRegs -[r9]
+G_M58408_IG05:        ; bbWeight=2, gcrefRegs=008C {rdx rbx rdi}, byrefRegs=0000 {}, byref, isz
+       mov      r9d, dword ptr [rdx+0x08]
        sub      r9d, eax
        cmp      r9d, r14d
        jge      SHORT G_M58408_IG06
        mov      r9d, eax
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rdx]
-       ; gcrRegs +[rdx]
        mov      rcx, rdi
        ; gcrRegs +[rcx]
        xor      r8d, r8d
@@ -87,74 +82,77 @@ G_M58408_IG05:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {},
        ; gcr arg pop 0
        xor      r9d, r9d
        mov      dword ptr [r13], r9d
-						;; size=64 bbWeight=2 PerfScore 34.00
+						;; size=38 bbWeight=2 PerfScore 25.00
 G_M58408_IG06:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
        xor      r9d, r9d
 						;; size=3 bbWeight=2 PerfScore 0.50
 G_M58408_IG07:        ; bbWeight=8, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        cmp      r9d, r14d
-       jge      SHORT G_M58408_IG11
+       jge      SHORT G_M58408_IG12
 						;; size=5 bbWeight=8 PerfScore 10.00
-G_M58408_IG08:        ; bbWeight=16, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M58408_IG08:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
+       mov      r13, 0xD1FFAB1E      ; static handle
+       mov      rdx, 0xD1FFAB1E      ; static handle
+       mov      rdx, gword ptr [rdx]
+       ; gcrRegs +[rdx]
+						;; size=23 bbWeight=2 PerfScore 5.00
+G_M58408_IG09:        ; bbWeight=16, gcrefRegs=008C {rdx rbx rdi}, byrefRegs=0000 {}, byref, isz
        cmp      ebp, r15d
-       jne      SHORT G_M58408_IG10
+       jne      SHORT G_M58408_IG11
 						;; size=5 bbWeight=16 PerfScore 20.00
-G_M58408_IG09:        ; bbWeight=8, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
+G_M58408_IG10:        ; bbWeight=8, gcrefRegs=008C {rdx rbx rdi}, byrefRegs=0000 {}, byref
        xor      ebp, ebp
 						;; size=2 bbWeight=8 PerfScore 2.00
-G_M58408_IG10:        ; bbWeight=16, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      r13, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      edx, dword ptr [r13]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rcx, gword ptr [rcx]
-       ; gcrRegs +[rcx]
-       lea      r8d, [rdx+0x01]
-       mov      dword ptr [r13], r8d
+G_M58408_IG11:        ; bbWeight=16, gcrefRegs=008C {rdx rbx rdi}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, dword ptr [r13]
+       mov      r8, rdx
+       ; gcrRegs +[r8]
+       lea      eax, [rcx+0x01]
+       mov      dword ptr [r13], eax
        cmp      ebp, dword ptr [rbx+0x08]
-       jae      G_M58408_IG16
-       mov      r8d, ebp
-       movzx    r8, byte  ptr [rbx+r8+0x10]
-       cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M58408_IG16
-       mov      byte  ptr [rcx+rdx+0x10], r8b
+       jae      G_M58408_IG17
+       mov      eax, ebp
+       movzx    rax, byte  ptr [rbx+rax+0x10]
+       cmp      ecx, dword ptr [r8+0x08]
+       jae      G_M58408_IG17
+       mov      byte  ptr [r8+rcx+0x10], al
        inc      ebp
        inc      r9d
        cmp      r9d, r14d
-       jl       SHORT G_M58408_IG08
-						;; size=77 bbWeight=16 PerfScore 304.00
-G_M58408_IG11:        ; bbWeight=8, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rcx]
+       jl       SHORT G_M58408_IG09
+						;; size=55 bbWeight=16 PerfScore 268.00
+G_M58408_IG12:        ; bbWeight=8, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rdx r8]
        mov      r13, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      r9d, dword ptr [r13]
        mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rdx, gword ptr [rdx]
        ; gcrRegs +[rdx]
+       mov      rcx, rdx
+       ; gcrRegs +[rcx]
        lea      eax, [r9+0x01]
        mov      dword ptr [r13], eax
-       cmp      r9d, dword ptr [rdx+0x08]
-       jae      SHORT G_M58408_IG16
-       mov      byte  ptr [rdx+r9+0x10], 10
+       cmp      r9d, dword ptr [rcx+0x08]
+       jae      SHORT G_M58408_IG17
+       mov      byte  ptr [rcx+r9+0x10], 10
        add      esi, -60
        test     esi, esi
        jg       G_M58408_IG03
-						;; size=58 bbWeight=8 PerfScore 100.00
-G_M58408_IG12:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rdx rbx]
+						;; size=61 bbWeight=8 PerfScore 102.00
+G_M58408_IG13:        ; bbWeight=1, gcrefRegs=0084 {rdx rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx rbx]
        test     eax, eax
-       je       SHORT G_M58408_IG15
+       je       SHORT G_M58408_IG16
 						;; size=4 bbWeight=1 PerfScore 1.25
-G_M58408_IG13:        ; bbWeight=0.50, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
+G_M58408_IG14:        ; bbWeight=0.50, gcrefRegs=0084 {rdx rdi}, byrefRegs=0000 {}, byref
        mov      r9d, eax
-       mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rdx]
-       ; gcrRegs +[rdx]
        mov      rcx, rdi
        ; gcrRegs +[rcx]
        xor      r8d, r8d
        mov      rax, qword ptr [rdi]
        mov      rax, qword ptr [rax+0x68]
-						;; size=29 bbWeight=0.50 PerfScore 3.50
-G_M58408_IG14:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=16 bbWeight=0.50 PerfScore 2.38
+G_M58408_IG15:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 240
        pop      rbx
        pop      rsi
@@ -165,7 +163,7 @@ G_M58408_IG14:        ; bbWeight=0.50, epilog, nogc, extend
        pop      rbp
        tail.jmp [rax+0x30]<unknown method>
 						;; size=21 bbWeight=0.50 PerfScore 2.88
-G_M58408_IG15:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+G_M58408_IG16:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx rdx rdi]
        add      rsp, 240
        pop      rbx
@@ -177,13 +175,13 @@ G_M58408_IG15:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        pop      rbp
        ret      
 						;; size=18 bbWeight=0.50 PerfScore 2.38
-G_M58408_IG16:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M58408_IG17:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 416, prolog size 106, PerfScore 488.22, instruction count 100, allocated bytes for code 416 (MethodHash=85cf1bd7) for method BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)
+; Total bytes of code 381, prolog size 106, PerfScore 449.10, instruction count 96, allocated bytes for code 381 (MethodHash=85cf1bd7) for method BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-37</span> (<span style="color:green">-8.26%</span>) : 47627.dasm - Benchstone.MDBenchF.MDInvMt:Inner(double[,],byref,byref) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,15 +7,15 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T03] ( 13,254   )     ref  ->  rcx         class-hnd single-def <double[,]>
-;  V01 arg1         [V01,T26] (  5, 11   )   byref  ->  [rsp+0x88]  single-def
+;  V00 arg0         [V00,T05] ( 13,247   )     ref  ->  rcx         class-hnd single-def <double[,]>
+;  V01 arg1         [V01,T24] (  5, 11   )   byref  ->  [rsp+0x78]  single-def
 ;  V02 arg2         [V02,T13] ( 10,119   )   byref  ->   r8         single-def
 ;  V03 loc0         [V03,T27] (  2, 72   )  double  ->  mm0        
 ;  V04 loc1         [V04,T28] (  3, 24   )  double  ->  mm0        
 ;  V05 loc2         [V05,T21] (  7, 37   )     int  ->  rax        
-;  V06 loc3         [V06,T18] (  5, 68   )     int  ->  rdi        
-;  V07 loc4         [V07,T17] (  6, 76   )     int  ->   r9        
-;  V08 loc5         [V08,T02] (  5,264   )     int  ->  r12        
+;  V06 loc3         [V06,T18] (  5, 68   )     int  ->  rsi        
+;  V07 loc4         [V07,T17] (  6, 76   )     int  ->  rsi        
+;  V08 loc5         [V08,T02] (  5,264   )     int  ->  r15        
 ;  V09 OutArgs      [V09    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V10 tmp1         [V10,T06] (  6, 72   )     int  ->  registers   "MD array shared temp"
 ;  V11 tmp2         [V11,T00] (  9,504   )     int  ->  registers   "MD array shared temp"
@@ -23,22 +23,22 @@
 ;* V13 tmp4         [V13,T08] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
 ;* V14 tmp5         [V14,T11] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
 ;* V15 tmp6         [V15,T12] (  0,  0   )     int  ->  zero-ref    "MD array shared temp"
-;  V16 cse0         [V16,T09] (  4,144   )     int  ->  r13         "CSE - aggressive"
-;  V17 cse1         [V17,T04] (  4,256   )     int  ->  rdx         "CSE - aggressive"
+;  V16 cse0         [V16,T09] (  4,144   )     int  ->  r14         "CSE - aggressive"
+;  V17 cse1         [V17,T03] (  4,256   )     int  ->  r12         "CSE - aggressive"
 ;  V18 cse2         [V18,T14] (  5,104   )     int  ->  r11         "CSE - aggressive"
-;  V19 cse3         [V19,T19] (  3, 48   )     int  ->  r12         "CSE - aggressive"
-;  V20 cse4         [V20,T22] (  3, 16   )     int  ->  r15         "CSE - aggressive"
-;  V21 cse5         [V21,T10] (  2, 16   )     int  ->  rdi         "CSE - aggressive"
-;  V22 cse6         [V22,T05] (  2,128   )     int  ->  rdx         "CSE - aggressive"
-;  V23 cse7         [V23,T15] (  2,  8   )     int  ->  [rsp+0x34]  spill-single-def "CSE - aggressive"
-;  V24 cse8         [V24,T20] (  2, 32   )     int  ->  r12         "CSE - aggressive"
-;  V25 cse9         [V25,T23] (  2,  8   )     int  ->  [rsp+0x30]  spill-single-def "CSE - aggressive"
-;  V26 cse10        [V26,T01] ( 11,324   )     int  ->  rsi         "CSE - aggressive"
-;  V27 cse11        [V27,T24] (  3, 16   )     int  ->  r10         "CSE - aggressive"
-;  V28 cse12        [V28,T25] (  3, 16   )     int  ->  [rsp+0x2C]  spill-single-def "CSE - aggressive"
-;  V29 cse13        [V29,T16] (  4, 88   )     int  ->  rbp         "CSE - aggressive"
+;  V19 cse3         [V19,T19] (  3, 48   )     int  ->  r15         "CSE - aggressive"
+;  V20 cse4         [V20,T22] (  3, 16   )     int  ->  rbp         "CSE - aggressive"
+;  V21 cse5         [V21,T10] (  2, 16   )     int  ->  r14         "CSE - aggressive"
+;  V22 cse6         [V22,T04] (  2,128   )     int  ->  r12         "CSE - aggressive"
+;  V23 cse7         [V23,T15] (  2,  8   )     int  ->  r11         "CSE - aggressive"
+;  V24 cse8         [V24,T20] (  2, 32   )     int  ->  r15         "CSE - aggressive"
+;  V25 cse9         [V25,T23] (  2,  8   )     int  ->  rbp         "CSE - aggressive"
+;  V26 cse10        [V26,T01] ( 11,324   )     int  ->  rbx         "CSE - aggressive"
+;  V27 cse11        [V27,T25] (  3, 12.50)     int  ->  r10         hoist "CSE - aggressive"
+;  V28 cse12        [V28,T26] (  3, 12.50)     int  ->   r9         hoist "CSE - aggressive"
+;  V29 cse13        [V29,T16] (  4, 88   )     int  ->  rdi         "CSE - aggressive"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 40
 
 G_M49005_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -49,7 +49,7 @@ G_M49005_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 56
+       sub      rsp, 40
 						;; size=16 bbWeight=1 PerfScore 8.25
 G_M49005_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0104 {rdx r8}, byref
        ; gcrRegs +[rcx]
@@ -58,128 +58,123 @@ G_M49005_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0104 {rdx r8
        mov      qword ptr [rdx], rax
        mov      eax, 1
        cmp      dword ptr [r8], 0
-       jle      G_M49005_IG11
+       jle      G_M49005_IG12
 						;; size=28 bbWeight=1 PerfScore 5.50
-G_M49005_IG03:        ; bbWeight=4, gcrefRegs=0002 {rcx}, byrefRegs=0104 {rdx r8}, byref, isz
+G_M49005_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0104 {rdx r8}, byref
        mov      r10d, dword ptr [rcx+0x18]
-       mov      r9d, eax
-       sub      r9d, r10d
-       mov      dword ptr [rsp+0x34], r9d
-       mov      r11d, r9d
-       mov      ebx, dword ptr [rcx+0x10]
-       mov      dword ptr [rsp+0x2C], ebx
-       cmp      r11d, ebx
+       mov      r9d, dword ptr [rcx+0x10]
+						;; size=8 bbWeight=0.50 PerfScore 2.00
+G_M49005_IG04:        ; bbWeight=4, gcrefRegs=0002 {rcx}, byrefRegs=0104 {rdx r8}, byref, isz
+       mov      r11d, eax
+       sub      r11d, r10d
+       cmp      r11d, r9d
        jae      G_M49005_IG13
-       mov      esi, dword ptr [rcx+0x14]
-       mov      edi, r11d
-       imul     edi, esi
-       mov      ebp, dword ptr [rcx+0x1C]
-       mov      r14d, eax
-       sub      r14d, ebp
-       mov      dword ptr [rsp+0x30], r14d
-       mov      r15d, r14d
-       cmp      r15d, esi
+       mov      ebx, dword ptr [rcx+0x14]
+       mov      esi, r11d
+       imul     esi, ebx
+       mov      edi, dword ptr [rcx+0x1C]
+       mov      ebp, eax
+       sub      ebp, edi
+       cmp      ebp, ebx
        jae      G_M49005_IG13
-       add      edi, r15d
-       vmovsd   xmm0, qword ptr [rcx+8*rdi+0x20]
+       add      esi, ebp
+       vmovsd   xmm0, qword ptr [rcx+8*rsi+0x20]
        vmulsd   xmm1, xmm0, qword ptr [rdx]
-       mov      bword ptr [rsp+0x88], rdx
+       mov      bword ptr [rsp+0x78], rdx
        ; GC ptr vars +{V01}
        vmovsd   qword ptr [rdx], xmm1
-       mov      edi, 1
-       mov      r13d, dword ptr [r8]
-       lea      r13d, [2*r13+0x01]
-       test     r13d, r13d
-       jle      SHORT G_M49005_IG05
-						;; size=115 bbWeight=4 PerfScore 138.00
-G_M49005_IG04:        ; bbWeight=16, gcVars=0000000004000000 {V01}, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, gcvars, byref, isz
-       ; byrRegs -[rdx]
-       mov      r13d, r11d
-       imul     r13d, esi
-       mov      r12d, edi
-       sub      r12d, ebp
-       cmp      r12d, esi
-       jae      G_M49005_IG13
-       add      r13d, r12d
-       mov      r9d, r11d
-       imul     r9d, esi
-       add      r9d, r12d
-       vmovsd   xmm1, qword ptr [rcx+8*r9+0x20]
-       vdivsd   xmm1, xmm1, xmm0
-       vmovsd   qword ptr [rcx+8*r13+0x20], xmm1
-       inc      edi
-       mov      r9d, dword ptr [r8]
-       lea      r9d, [2*r9+0x01]
-       cmp      edi, r9d
-       jle      SHORT G_M49005_IG04
-						;; size=71 bbWeight=16 PerfScore 460.00
-G_M49005_IG05:        ; bbWeight=4, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref
-       mov      r9d, 1
-       cmp      dword ptr [r8], 0
-       jle      G_M49005_IG10
-						;; size=16 bbWeight=4 PerfScore 17.00
-G_M49005_IG06:        ; bbWeight=16, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref
-       cmp      r9d, eax
-       je       G_M49005_IG12
-						;; size=9 bbWeight=16 PerfScore 20.00
-G_M49005_IG07:        ; bbWeight=8, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref, isz
-       mov      edi, r9d
-       sub      edi, r10d
-       mov      r13d, edi
-       cmp      r13d, ebx
-       jae      G_M49005_IG13
-       mov      r12d, r13d
-       imul     r12d, esi
-       add      r12d, r15d
-       vmovsd   xmm0, qword ptr [rcx+8*r12+0x20]
-       mov      r12d, 1
+       mov      esi, 1
        mov      r14d, dword ptr [r8]
        lea      r14d, [2*r14+0x01]
        test     r14d, r14d
-       jle      SHORT G_M49005_IG09
-						;; size=57 bbWeight=8 PerfScore 100.00
-G_M49005_IG08:        ; bbWeight=64, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref, isz
-       mov      r14d, r13d
-       imul     r14d, esi
-       mov      edx, r12d
-       sub      edx, ebp
-       cmp      edx, esi
+       jle      SHORT G_M49005_IG06
+						;; size=81 bbWeight=4 PerfScore 108.00
+G_M49005_IG05:        ; bbWeight=16, gcVars=0000000001000000 {V01}, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, gcvars, byref, isz
+       ; byrRegs -[rdx]
+       mov      r14d, r11d
+       imul     r14d, ebx
+       mov      r15d, esi
+       sub      r15d, edi
+       cmp      r15d, ebx
+       jae      G_M49005_IG13
+       add      r14d, r15d
+       mov      r13d, r11d
+       imul     r13d, ebx
+       add      r15d, r13d
+       vmovsd   xmm1, qword ptr [rcx+8*r15+0x20]
+       vdivsd   xmm1, xmm1, xmm0
+       vmovsd   qword ptr [rcx+8*r14+0x20], xmm1
+       inc      esi
+       mov      r14d, dword ptr [r8]
+       lea      r14d, [2*r14+0x01]
+       cmp      esi, r14d
+       jle      SHORT G_M49005_IG05
+						;; size=71 bbWeight=16 PerfScore 460.00
+G_M49005_IG06:        ; bbWeight=4, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref
+       mov      esi, 1
+       cmp      dword ptr [r8], 0
+       jle      G_M49005_IG11
+						;; size=15 bbWeight=4 PerfScore 17.00
+G_M49005_IG07:        ; bbWeight=16, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref
+       cmp      esi, eax
+       je       G_M49005_IG10
+						;; size=8 bbWeight=16 PerfScore 20.00
+G_M49005_IG08:        ; bbWeight=8, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref, isz
+       mov      r14d, esi
+       sub      r14d, r10d
+       cmp      r14d, r9d
+       jae      G_M49005_IG13
+       mov      r15d, r14d
+       imul     r15d, ebx
+       add      r15d, ebp
+       vmovsd   xmm0, qword ptr [rcx+8*r15+0x20]
+       mov      r15d, 1
+       mov      r13d, dword ptr [r8]
+       lea      r13d, [2*r13+0x01]
+       test     r13d, r13d
+       jle      SHORT G_M49005_IG10
+						;; size=54 bbWeight=8 PerfScore 98.00
+G_M49005_IG09:        ; bbWeight=64, gcrefRegs=0002 {rcx}, byrefRegs=0100 {r8}, byref, isz
+       mov      r13d, r14d
+       imul     r13d, ebx
+       mov      r12d, r15d
+       sub      r12d, edi
+       cmp      r12d, ebx
        jae      SHORT G_M49005_IG13
-       add      r14d, edx
-       mov      ebx, r13d
-       imul     ebx, esi
-       add      ebx, edx
-       vmovsd   xmm1, qword ptr [rcx+8*rbx+0x20]
-       mov      ebx, r11d
-       imul     ebx, esi
-       add      edx, ebx
+       add      r13d, r12d
+       mov      edx, r14d
+       imul     edx, ebx
+       add      edx, r12d
+       vmovsd   xmm1, qword ptr [rcx+8*rdx+0x20]
+       mov      edx, r11d
+       imul     edx, ebx
+       add      edx, r12d
        vmulsd   xmm2, xmm0, qword ptr [rcx+8*rdx+0x20]
        vsubsd   xmm1, xmm1, xmm2
-       vmovsd   qword ptr [rcx+8*r14+0x20], xmm1
-       inc      r12d
...

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+28.77%</span>) : 29494.dasm - PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -12,40 +12,50 @@
 ;  V01 loc0         [V01,T00] (  4, 13   )     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 cse0         [V03,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M38760_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 16
-       mov      qword ptr [rsp+0x80], rsi
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x4C]
-						;; size=21 bbWeight=1 PerfScore 4.25
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=1 PerfScore 5.25
 G_M38760_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      esi, dword ptr [(reloc)]
        cmp      ebx, esi
-       jge      SHORT G_M38760_IG04
+       jge      SHORT G_M38760_IG05
 						;; size=10 bbWeight=1 PerfScore 3.25
-G_M38760_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+G_M38760_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.50 PerfScore 1.25
+G_M38760_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
        cmp      ebx, esi
-       jl       SHORT G_M38760_IG03
-						;; size=34 bbWeight=4 PerfScore 20.00
-G_M38760_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       jl       SHORT G_M38760_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M38760_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
        pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=12 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 73, prolog size 21, PerfScore 30.25, instruction count 19, allocated bytes for code 73 (MethodHash=352a6897) for method PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 25.00, instruction count 23, allocated bytes for code 94 (MethodHash=352a6897) for method PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -53,15 +63,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 16 * 8 = 128 = 0x00080
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 18 * 8 = 144 = 0x00090
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+28.77%</span>) : 31574.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -12,40 +12,50 @@
 ;  V01 loc0         [V01,T00] (  4, 13   )     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 cse0         [V03,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M51398_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 16
-       mov      qword ptr [rsp+0x80], rsi
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x4C]
-						;; size=21 bbWeight=1 PerfScore 4.25
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=1 PerfScore 5.25
 G_M51398_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      esi, dword ptr [(reloc)]
        cmp      ebx, esi
-       jge      SHORT G_M51398_IG04
+       jge      SHORT G_M51398_IG05
 						;; size=10 bbWeight=1 PerfScore 3.25
-G_M51398_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+G_M51398_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.50 PerfScore 1.25
+G_M51398_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
        cmp      ebx, esi
-       jl       SHORT G_M51398_IG03
-						;; size=34 bbWeight=4 PerfScore 20.00
-G_M51398_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       jl       SHORT G_M51398_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M51398_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
        pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=12 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 73, prolog size 21, PerfScore 30.25, instruction count 19, allocated bytes for code 73 (MethodHash=4b353739) for method PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 25.00, instruction count 23, allocated bytes for code 94 (MethodHash=4b353739) for method PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -53,15 +63,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 16 * 8 = 128 = 0x00080
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 18 * 8 = 144 = 0x00090
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>

<details>
<summary><span style="color:red">+21</span> (<span style="color:red">+28.77%</span>) : 25372.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -13,40 +13,50 @@
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 cse0         [V04,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V05 cse1         [V05,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M22144_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 16
-       mov      qword ptr [rsp+0x80], rsi
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x4C]
-						;; size=21 bbWeight=1 PerfScore 4.25
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=1 PerfScore 5.25
 G_M22144_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      esi, dword ptr [(reloc)]
        cmp      ebx, esi
-       jge      SHORT G_M22144_IG04
+       jge      SHORT G_M22144_IG05
 						;; size=10 bbWeight=1 PerfScore 3.25
-G_M22144_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+G_M22144_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.50 PerfScore 1.25
+G_M22144_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
        cmp      ebx, esi
-       jl       SHORT G_M22144_IG03
-						;; size=34 bbWeight=4 PerfScore 20.00
-G_M22144_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       jl       SHORT G_M22144_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M22144_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
        pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=8 bbWeight=1 PerfScore 2.75
+						;; size=12 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 73, prolog size 21, PerfScore 30.25, instruction count 19, allocated bytes for code 73 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 25.00, instruction count 23, allocated bytes for code 94 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -54,15 +64,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
       Scaled Small Offset: 16 * 8 = 128 = 0x00080
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rsi (6)
+      Scaled Small Offset: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rdi (7)
+      Scaled Small Offset: 18 * 8 = 144 = 0x00090
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-22.73%</span>) : 242283.dasm - Test_b99969:DoSpoof() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,32 +8,35 @@
 ; Final local variable assignments
 ;
 ;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 cse0         [V01,T00] (  3,  3   )     ref  ->  rax         "CSE - aggressive"
+;  V01 cse0         [V01,T00] (  2,  9   )     ref  ->  rcx         hoist "CSE - aggressive"
+;  V02 cse1         [V02,T01] (  3,  3   )     ref  ->  rax         "CSE - aggressive"
+;  V03 cse2         [V03,T02] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
-G_M19890_IG01:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=8 PerfScore 0.00
-G_M19890_IG02:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       cmp      byte  ptr [rax+0x0D], 0
-       je       SHORT G_M19890_IG02
-						;; size=19 bbWeight=8 PerfScore 50.00
-G_M19890_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+G_M19890_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M19890_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rax, 0xD1FFAB1E      ; static handle
+       mov      rcx, gword ptr [rax]
+       ; gcrRegs +[rcx]
+						;; size=13 bbWeight=1 PerfScore 2.25
+G_M19890_IG03:        ; bbWeight=8, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       cmp      byte  ptr [rcx+0x0D], 0
+       je       SHORT G_M19890_IG03
+						;; size=6 bbWeight=8 PerfScore 32.00
+G_M19890_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rcx]
        mov      rax, gword ptr [rax]
        ; gcrRegs +[rax]
        mov      dword ptr [rax+0x08], 0xD1FFAB1E
        mov      byte  ptr [rax+0x0C], 1
-						;; size=24 bbWeight=1 PerfScore 4.25
-G_M19890_IG04:        ; bbWeight=1, epilog, nogc, extend
+						;; size=14 bbWeight=1 PerfScore 4.00
+G_M19890_IG05:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 44, prolog size 0, PerfScore 55.25, instruction count 9, allocated bytes for code 44 (MethodHash=bd6db24d) for method Test_b99969:DoSpoof() (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 39.25, instruction count 8, allocated bytes for code 34 (MethodHash=bd6db24d) for method Test_b99969:DoSpoof() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-28</span> (<span style="color:green">-12.73%</span>) : 122145.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -13,76 +13,77 @@
 ;  V02 loc1         [V02,T02] (  6, 21   )     int  ->  rsi        
 ;  V03 loc2         [V03,T03] (  6, 21   )     int  ->  rsi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T00] (  3, 24   )     ref  ->  rdi         class-hnd "impAppendStmt" <<unknown class>>
+;  V05 tmp1         [V05,T00] (  3, 24   )     ref  ->  rbp         class-hnd "impAppendStmt" <<unknown class>>
 ;  V06 tmp2         [V06,T04] (  2, 16   )     int  ->  rax         "Strict ordering of exceptions for Array store"
-;  V07 tmp3         [V07,T01] (  3, 24   )     ref  ->  rdi         class-hnd "impAppendStmt" <<unknown class>>
+;  V07 tmp3         [V07,T01] (  3, 24   )     ref  ->  rbp         class-hnd "impAppendStmt" <<unknown class>>
 ;  V08 tmp4         [V08,T05] (  2, 16   )     int  ->  rax         "Strict ordering of exceptions for Array store"
 ;* V09 tmp5         [V09    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V10 tmp6         [V10    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V11 tmp7         [V11,T09] (  2,  2   )  simd64  ->  [rsp+0x20]  "field V01._fld1 (fldOffset=0x0)" P-INDEP
-;  V12 tmp8         [V12,T10] (  2,  2   )  simd32  ->  mm0         "field V01._fld2 (fldOffset=0x40)" P-INDEP
+;  V11 tmp7         [V11,T11] (  2,  2   )  simd64  ->  [rsp+0x20]  "field V01._fld1 (fldOffset=0x0)" P-INDEP
+;  V12 tmp8         [V12,T12] (  2,  2   )  simd32  ->  mm0         "field V01._fld2 (fldOffset=0x40)" P-INDEP
 ;  V13 tmp9         [V13,T07] (  3,  6   )     ref  ->  rax         single-def "arr expr"
 ;  V14 tmp10        [V14,T08] (  3,  6   )     ref  ->  rax         single-def "arr expr"
+;  V15 cse0         [V15,T09] (  3,  6   )    long  ->  rdi         hoist "CSE - aggressive"
+;  V16 cse1         [V16,T10] (  3,  6   )    long  ->  rdi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 128
+; Lcl frame size = 120
 
 G_M5823_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 128
-       vmovaps  xmmword ptr [rsp+0x70], xmm6
+       sub      rsp, 120
+       vmovaps  xmmword ptr [rsp+0x60], xmm6
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=19 bbWeight=1 PerfScore 5.50
+						;; size=17 bbWeight=1 PerfScore 6.50
 G_M5823_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        xor      esi, esi
-						;; size=2 bbWeight=1 PerfScore 0.25
+       mov      rdi, 0xD1FFAB1E      ; static handle
+						;; size=12 bbWeight=1 PerfScore 0.50
 G_M5823_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
+       mov      rbp, gword ptr [rdi]
+       ; gcrRegs +[rbp]
        call     [TestLibrary.Generator:GetByte():ubyte]
        ; gcr arg pop 0
-       cmp      esi, dword ptr [rdi+0x08]
+       cmp      esi, dword ptr [rbp+0x08]
        jae      G_M5823_IG08
        mov      ecx, esi
-       mov      byte  ptr [rdi+rcx+0x10], al
+       mov      byte  ptr [rbp+rcx+0x10], al
        inc      esi
        cmp      esi, 64
        jl       SHORT G_M5823_IG03
-						;; size=41 bbWeight=4 PerfScore 48.00
-G_M5823_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
-       ; gcrRegs -[rdi]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
+						;; size=31 bbWeight=4 PerfScore 47.00
+G_M5823_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rbp]
+       mov      rax, gword ptr [rdi]
        ; gcrRegs +[rax]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M5823_IG08
+       jbe      SHORT G_M5823_IG08
        vmovups  zmm6, zmmword ptr [rax+0x10]
        xor      esi, esi
-						;; size=35 bbWeight=1 PerfScore 10.50
+       mov      rdi, 0xD1FFAB1E      ; static handle
+						;; size=31 bbWeight=1 PerfScore 10.50
 G_M5823_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
+       mov      rbp, gword ptr [rdi]
+       ; gcrRegs +[rbp]
        vmovups  zmmword ptr [rsp+0x20], zmm6
        call     [TestLibrary.Generator:GetByte():ubyte]
        ; gcr arg pop 0
-       cmp      esi, dword ptr [rdi+0x08]
+       cmp      esi, dword ptr [rbp+0x08]
        jae      SHORT G_M5823_IG08
        mov      ecx, esi
-       mov      byte  ptr [rdi+rcx+0x10], al
+       mov      byte  ptr [rbp+rcx+0x10], al
        inc      esi
        cmp      esi, 32
        vmovups  zmm6, zmmword ptr [rsp+0x20]
        jl       SHORT G_M5823_IG05
-						;; size=59 bbWeight=4 PerfScore 64.00
+						;; size=49 bbWeight=4 PerfScore 63.00
 G_M5823_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       ; gcrRegs -[rdi]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
+       ; gcrRegs -[rbp]
+       mov      rax, gword ptr [rdi]
        ; gcrRegs +[rax]
        cmp      dword ptr [rax+0x08], 0
        jbe      SHORT G_M5823_IG08
@@ -92,16 +93,17 @@ G_M5823_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byre
        mov      rax, rbx
        ; gcrRegs -[rax]
        ; byrRegs +[rax]
-						;; size=38 bbWeight=1 PerfScore 15.50
+						;; size=28 bbWeight=1 PerfScore 15.25
 G_M5823_IG07:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       vmovaps  xmm6, xmmword ptr [rsp+0x70]
-       add      rsp, 128
+       vmovaps  xmm6, xmmword ptr [rsp+0x60]
+       add      rsp, 120
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=20 bbWeight=1 PerfScore 7.75
+						;; size=18 bbWeight=1 PerfScore 8.25
 G_M5823_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rax rbx]
        call     CORINFO_HELP_RNGCHKFAIL
@@ -109,7 +111,7 @@ G_M5823_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 220, prolog size 16, PerfScore 151.50, instruction count 52, allocated bytes for code 220 (MethodHash=6354e940) for method JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct (FullOpts)
+; Total bytes of code 192, prolog size 14, PerfScore 151.00, instruction count 52, allocated bytes for code 192 (MethodHash=6354e940) for method JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -117,14 +119,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x10
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x0E
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
-      Scaled Small Offset: 7 * 16 = 112 = 0x00070
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 15 * 8 + 8 = 128 = 0x80
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0E UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 6 * 16 = 96 = 0x00060
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:green">-28</span> (<span style="color:green">-12.73%</span>) : 117259.dasm - JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -13,76 +13,77 @@
 ;  V02 loc1         [V02,T02] (  6, 21   )     int  ->  rsi        
 ;  V03 loc2         [V03,T03] (  6, 21   )     int  ->  rsi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T00] (  3, 24   )     ref  ->  rdi         class-hnd "impAppendStmt" <<unknown class>>
+;  V05 tmp1         [V05,T00] (  3, 24   )     ref  ->  rbp         class-hnd "impAppendStmt" <<unknown class>>
 ;  V06 tmp2         [V06,T04] (  2, 16   )     int  ->  rax         "Strict ordering of exceptions for Array store"
-;  V07 tmp3         [V07,T01] (  3, 24   )     ref  ->  rdi         class-hnd "impAppendStmt" <<unknown class>>
+;  V07 tmp3         [V07,T01] (  3, 24   )     ref  ->  rbp         class-hnd "impAppendStmt" <<unknown class>>
 ;  V08 tmp4         [V08,T05] (  2, 16   )     int  ->  rax         "Strict ordering of exceptions for Array store"
 ;* V09 tmp5         [V09    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V10 tmp6         [V10    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V11 tmp7         [V11,T09] (  2,  2   )  simd64  ->  [rsp+0x20]  "field V01._fld1 (fldOffset=0x0)" P-INDEP
-;  V12 tmp8         [V12,T10] (  2,  2   )  simd32  ->  mm0         "field V01._fld2 (fldOffset=0x40)" P-INDEP
+;  V11 tmp7         [V11,T11] (  2,  2   )  simd64  ->  [rsp+0x20]  "field V01._fld1 (fldOffset=0x0)" P-INDEP
+;  V12 tmp8         [V12,T12] (  2,  2   )  simd32  ->  mm0         "field V01._fld2 (fldOffset=0x40)" P-INDEP
 ;  V13 tmp9         [V13,T07] (  3,  6   )     ref  ->  rax         single-def "arr expr"
 ;  V14 tmp10        [V14,T08] (  3,  6   )     ref  ->  rax         single-def "arr expr"
+;  V15 cse0         [V15,T09] (  3,  6   )    long  ->  rdi         hoist "CSE - aggressive"
+;  V16 cse1         [V16,T10] (  3,  6   )    long  ->  rdi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 128
+; Lcl frame size = 120
 
 G_M39647_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 128
-       vmovaps  xmmword ptr [rsp+0x70], xmm6
+       sub      rsp, 120
+       vmovaps  xmmword ptr [rsp+0x60], xmm6
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=19 bbWeight=1 PerfScore 5.50
+						;; size=17 bbWeight=1 PerfScore 6.50
 G_M39647_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        xor      esi, esi
-						;; size=2 bbWeight=1 PerfScore 0.25
+       mov      rdi, 0xD1FFAB1E      ; static handle
+						;; size=12 bbWeight=1 PerfScore 0.50
 G_M39647_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
+       mov      rbp, gword ptr [rdi]
+       ; gcrRegs +[rbp]
        call     [TestLibrary.Generator:GetUInt32():uint]
        ; gcr arg pop 0
-       cmp      esi, dword ptr [rdi+0x08]
+       cmp      esi, dword ptr [rbp+0x08]
        jae      G_M39647_IG08
        mov      ecx, esi
-       mov      dword ptr [rdi+4*rcx+0x10], eax
+       mov      dword ptr [rbp+4*rcx+0x10], eax
        inc      esi
        cmp      esi, 16
        jl       SHORT G_M39647_IG03
-						;; size=41 bbWeight=4 PerfScore 48.00
-G_M39647_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
-       ; gcrRegs -[rdi]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
+						;; size=31 bbWeight=4 PerfScore 47.00
+G_M39647_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rbp]
+       mov      rax, gword ptr [rdi]
        ; gcrRegs +[rax]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M39647_IG08
+       jbe      SHORT G_M39647_IG08
        vmovups  zmm6, zmmword ptr [rax+0x10]
        xor      esi, esi
-						;; size=35 bbWeight=1 PerfScore 10.50
+       mov      rdi, 0xD1FFAB1E      ; static handle
+						;; size=31 bbWeight=1 PerfScore 10.50
 G_M39647_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
+       mov      rbp, gword ptr [rdi]
+       ; gcrRegs +[rbp]
        vmovups  zmmword ptr [rsp+0x20], zmm6
        call     [TestLibrary.Generator:GetUInt32():uint]
        ; gcr arg pop 0
-       cmp      esi, dword ptr [rdi+0x08]
+       cmp      esi, dword ptr [rbp+0x08]
        jae      SHORT G_M39647_IG08
        mov      ecx, esi
-       mov      dword ptr [rdi+4*rcx+0x10], eax
+       mov      dword ptr [rbp+4*rcx+0x10], eax
        inc      esi
        cmp      esi, 8
        vmovups  zmm6, zmmword ptr [rsp+0x20]
        jl       SHORT G_M39647_IG05
-						;; size=59 bbWeight=4 PerfScore 64.00
+						;; size=49 bbWeight=4 PerfScore 63.00
 G_M39647_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       ; gcrRegs -[rdi]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rax, gword ptr [rax]
+       ; gcrRegs -[rbp]
+       mov      rax, gword ptr [rdi]
        ; gcrRegs +[rax]
        cmp      dword ptr [rax+0x08], 0
        jbe      SHORT G_M39647_IG08
@@ -92,16 +93,17 @@ G_M39647_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        mov      rax, rbx
        ; gcrRegs -[rax]
        ; byrRegs +[rax]
-						;; size=38 bbWeight=1 PerfScore 15.50
+						;; size=28 bbWeight=1 PerfScore 15.25
 G_M39647_IG07:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       vmovaps  xmm6, xmmword ptr [rsp+0x70]
-       add      rsp, 128
+       vmovaps  xmm6, xmmword ptr [rsp+0x60]
+       add      rsp, 120
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=20 bbWeight=1 PerfScore 7.75
+						;; size=18 bbWeight=1 PerfScore 8.25
 G_M39647_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rax rbx]
        call     CORINFO_HELP_RNGCHKFAIL
@@ -109,7 +111,7 @@ G_M39647_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 220, prolog size 16, PerfScore 151.50, instruction count 52, allocated bytes for code 220 (MethodHash=ae5f6520) for method JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct (FullOpts)
+; Total bytes of code 192, prolog size 14, PerfScore 151.00, instruction count 52, allocated bytes for code 192 (MethodHash=ae5f6520) for method JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -117,14 +119,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x10
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x0E
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
-      Scaled Small Offset: 7 * 16 = 112 = 0x00070
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 15 * 8 + 8 = 128 = 0x80
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0E UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 6 * 16 = 96 = 0x00060
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+46</span> (<span style="color:red">+34.59%</span>) : 185011.dasm - FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -22,70 +22,82 @@
 ;* V12 tmp1         [V12    ] (  0,  0   )  double  ->  zero-ref    "field V08.a (fldOffset=0x0)" P-INDEP
 ;* V13 tmp2         [V13    ] (  0,  0   )  double  ->  zero-ref    "field V08.b (fldOffset=0x8)" P-INDEP
 ;* V14 tmp3         [V14    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <FastTailCallCandidates+HFASize16>
+;  V15 cse0         [V15,T03] (  2,  4.50)  double  ->  mm8         hoist "CSE - aggressive"
+;  V16 cse1         [V16,T04] (  2,  4.50)  double  ->  mm9         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 96
 
 G_M26767_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 64
-       vmovaps  xmmword ptr [rsp+0x30], xmm6
-       vmovaps  xmmword ptr [rsp+0x20], xmm7
+       sub      rsp, 96
+       vmovaps  xmmword ptr [rsp+0x50], xmm6
+       vmovaps  xmmword ptr [rsp+0x40], xmm7
+       vmovaps  xmmword ptr [rsp+0x30], xmm8
+       vmovaps  xmmword ptr [rsp+0x20], xmm9
        vmovaps  xmm6, xmm0
-						;; size=21 bbWeight=1 PerfScore 5.50
+						;; size=33 bbWeight=1 PerfScore 9.50
 G_M26767_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        xor      ebx, ebx
        vxorps   xmm7, xmm7, xmm7
        vxorps   xmm1, xmm1, xmm1
        vucomisd xmm6, xmm1
-       jbe      SHORT G_M26767_IG09
+       jbe      SHORT G_M26767_IG10
 						;; size=16 bbWeight=1 PerfScore 3.92
-G_M26767_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       vmovsd   xmm1, qword ptr [reloc @RWD00]
+G_M26767_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       vmovsd   xmm8, qword ptr [reloc @RWD00]
+       vmovsd   xmm9, qword ptr [reloc @RWD08]
+						;; size=16 bbWeight=0.50 PerfScore 3.00
+G_M26767_IG04:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       vmovaps  xmm1, xmm8
        vmovaps  xmm0, xmm7
        call     CORINFO_HELP_DBLREM
        ; gcr arg pop 0
        vxorps   xmm1, xmm1, xmm1
        vucomisd xmm0, xmm1
-       jp       SHORT G_M26767_IG05
-       jne      SHORT G_M26767_IG05
-						;; size=29 bbWeight=4 PerfScore 34.33
-G_M26767_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jp       SHORT G_M26767_IG06
+       jne      SHORT G_M26767_IG06
+						;; size=26 bbWeight=4 PerfScore 23.33
+G_M26767_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        inc      ebx
 						;; size=2 bbWeight=2 PerfScore 0.50
-G_M26767_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       vaddsd   xmm7, xmm7, qword ptr [reloc @RWD08]
+G_M26767_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       vaddsd   xmm7, xmm7, xmm9
        vucomisd xmm6, xmm7
-       ja       SHORT G_M26767_IG03
-						;; size=14 bbWeight=4 PerfScore 32.00
-G_M26767_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ja       SHORT G_M26767_IG04
+						;; size=11 bbWeight=4 PerfScore 24.00
+G_M26767_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ebx, 1
-       jne      SHORT G_M26767_IG09
+       jne      SHORT G_M26767_IG10
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M26767_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M26767_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, 100
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M26767_IG08:        ; bbWeight=0.50, epilog, nogc, extend
-       vmovaps  xmm6, xmmword ptr [rsp+0x30]
-       vmovaps  xmm7, xmmword ptr [rsp+0x20]
-       add      rsp, 64
+G_M26767_IG09:        ; bbWeight=0.50, epilog, nogc, extend
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       vmovaps  xmm7, xmmword ptr [rsp+0x40]
+       vmovaps  xmm8, xmmword ptr [rsp+0x30]
+       vmovaps  xmm9, xmmword ptr [rsp+0x20]
+       add      rsp, 96
        pop      rbx
        ret      
-						;; size=18 bbWeight=0.50 PerfScore 4.88
-G_M26767_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=30 bbWeight=0.50 PerfScore 8.88
+G_M26767_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 110
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M26767_IG10:        ; bbWeight=0.50, epilog, nogc, extend
-       vmovaps  xmm6, xmmword ptr [rsp+0x30]
-       vmovaps  xmm7, xmmword ptr [rsp+0x20]
-       add      rsp, 64
+G_M26767_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       vmovaps  xmm7, xmmword ptr [rsp+0x40]
+       vmovaps  xmm8, xmmword ptr [rsp+0x30]
+       vmovaps  xmm9, xmmword ptr [rsp+0x20]
+       add      rsp, 96
        pop      rbx
        ret      
-						;; size=18 bbWeight=0.50 PerfScore 4.88
+						;; size=30 bbWeight=0.50 PerfScore 8.88
 RWD00  	dq	4000000000000000h	;            2
 RWD08  	dq	3FF0000000000000h	;            1
 
 
-; Total bytes of code 133, prolog size 21, PerfScore 87.50, instruction count 35, allocated bytes for code 133 (MethodHash=b3049770) for method FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)
+; Total bytes of code 179, prolog size 33, PerfScore 83.50, instruction count 43, allocated bytes for code 179 (MethodHash=b3049770) for method FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -93,14 +105,18 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x1D
+  CountOfUnwindCodes: 10
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+    CodeOffset: 0x1D UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM9 (9)
       Scaled Small Offset: 2 * 16 = 32 = 0x00020
-    CodeOffset: 0x0B UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+    CodeOffset: 0x17 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM8 (8)
       Scaled Small Offset: 3 * 16 = 48 = 0x00030
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 4 * 16 = 64 = 0x00040
+    CodeOffset: 0x0B UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 5 * 16 = 80 = 0x00050
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 11 * 8 + 8 = 96 = 0x60
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+35.71%</span>) : 305795.dasm - OVFTest:Test_ulong(ulong):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,24 +10,29 @@
 ;  V00 arg0         [V00,T01] (  4, 18   )    long  ->  rcx        
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V02 tmp1         [V02,T00] (  2, 32   )    long  ->  rcx         "arg temp"
+;  V03 cse0         [V03,T02] (  2,  9   )  double  ->  mm6         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M40740_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M40740_IG02:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       sub      rsp, 56
+       vmovaps  xmmword ptr [rsp+0x20], xmm6
+						;; size=10 bbWeight=1 PerfScore 2.25
+G_M40740_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       vmovsd   xmm6, qword ptr [reloc @RWD00]
+						;; size=8 bbWeight=1 PerfScore 3.00
+G_M40740_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        vcvtusi2sd xmm0, rcx
-       vmulsd   xmm0, xmm0, qword ptr [reloc @RWD00]
+       vmulsd   xmm0, xmm0, xmm6
        call     CORINFO_HELP_DBL2ULNG_OVF
        ; gcr arg pop 0
        mov      rcx, rax
-       jmp      SHORT G_M40740_IG02
-						;; size=24 bbWeight=8 PerfScore 98.00
+       jmp      SHORT G_M40740_IG03
+						;; size=20 bbWeight=8 PerfScore 82.00
 RWD00  	dq	4000000000000000h	;            2
 
 
-; Total bytes of code 28, prolog size 4, PerfScore 98.25, instruction count 6, allocated bytes for code 28 (MethodHash=390d60db) for method OVFTest:Test_ulong(ulong):ulong (FullOpts)
+; Total bytes of code 38, prolog size 10, PerfScore 87.25, instruction count 8, allocated bytes for code 38 (MethodHash=390d60db) for method OVFTest:Test_ulong(ulong):ulong (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -35,9 +40,11 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 3
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x0A UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 2 * 16 = 32 = 0x00020
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38

```


</div></details>

<details>
<summary><span style="color:red">+11</span> (<span style="color:red">+42.31%</span>) : 490235.dasm - FinalizeTimeout:ThreadMain() (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -10,22 +10,27 @@
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <<unknown class>>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V02 cse0         [V02,T00] (  2,  9   )    long  ->  rbx         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
-G_M23685_IG01:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M23685_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
-						;; size=4 bbWeight=8 PerfScore 2.00
-G_M23685_IG02:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       mov      qword ptr [rsp+0x98], rbx
+						;; size=12 bbWeight=1 PerfScore 1.25
+G_M23685_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rbx, 0xD1FFAB1E      ; <unknown class>
+						;; size=10 bbWeight=1 PerfScore 0.25
+G_M23685_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbx
        mov      edx, 0x400
        call     CORINFO_HELP_NEWARR_1_VC
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       jmp      SHORT G_M23685_IG02
-						;; size=22 bbWeight=8 PerfScore 28.00
+       jmp      SHORT G_M23685_IG03
+						;; size=15 bbWeight=8 PerfScore 28.00
 
-; Total bytes of code 26, prolog size 4, PerfScore 30.00, instruction count 5, allocated bytes for code 26 (MethodHash=5335a37a) for method FinalizeTimeout:ThreadMain() (Tier1-OSR)
+; Total bytes of code 37, prolog size 12, PerfScore 29.50, instruction count 7, allocated bytes for code 37 (MethodHash=5335a37a) for method FinalizeTimeout:ThreadMain() (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -33,11 +38,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x0C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 19 * 8 = 152 = 0x00098
     CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
     CodeOffset: 0x00 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 14 * 8 + 8 = 120 = 0x78
     CodeOffset: 0x00 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-11.59%</span>) : 20082.dasm - System.SpanHelpers:LastIndexOfAnyInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,111 +8,108 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T05] (  4,  7   )    long  ->  rbx         single-def
-;  V01 arg0         [V01,T06] (  3,  6   )   byref  ->  rsi         single-def
-;  V02 arg1         [V02,T07] (  3,  6   )     ref  ->  rdi         ld-addr-op class-hnd single-def <System.__Canon>
-;  V03 arg2         [V03,T08] (  3,  4   )     ref  ->  rbp         ld-addr-op class-hnd single-def <System.__Canon>
-;  V04 arg3         [V04,T09] (  1,  1   )     int  ->  [rsp+0x90]  single-def
-;  V05 loc0         [V05,T01] (  7, 18.50)     int  ->  r14        
+;  V00 TypeCtx      [V00,T08] (  4,  3.50)    long  ->  rcx         single-def
+;  V01 arg0         [V01,T04] (  3,  6   )   byref  ->  rbx         single-def
+;  V02 arg1         [V02,T05] (  3,  6   )     ref  ->  rsi         ld-addr-op class-hnd single-def <System.__Canon>
+;  V03 arg2         [V03,T07] (  3,  4   )     ref  ->  rdi         ld-addr-op class-hnd single-def <System.__Canon>
+;  V04 arg3         [V04,T09] (  1,  1   )     int  ->  [rsp+0x80]  single-def
+;  V05 loc0         [V05,T01] (  7, 18.50)     int  ->  rbp        
 ;  V06 loc1         [V06,T03] (  3, 10   )   byref  ->  r15        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08,T00] (  3, 24   )    long  ->  r11         "VirtualCall with runtime lookup"
 ;  V09 tmp2         [V09,T02] (  3, 12   )    long  ->  r11         "VirtualCall with runtime lookup"
-;  V10 cse0         [V10,T04] (  3, 10   )    long  ->  r13         "CSE - aggressive"
+;  V10 cse0         [V10,T06] (  3,  6.50)    long  ->  r14         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 48
+; Lcl frame size = 40
 
 G_M3996_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 48
-       mov      qword ptr [rsp+0x28], rcx
-       mov      rbx, rcx
-       mov      rsi, rdx
-       ; byrRegs +[rsi]
-       mov      rdi, r8
+       sub      rsp, 40
+       mov      qword ptr [rsp+0x20], rcx
+       mov      rbx, rdx
+       ; byrRegs +[rbx]
+       mov      rsi, r8
+       ; gcrRegs +[rsi]
+       mov      rdi, r9
        ; gcrRegs +[rdi]
-       mov      rbp, r9
-       ; gcrRegs +[rbp]
-						;; size=31 bbWeight=1 PerfScore 9.25
-G_M3996_IG02:        ; bbWeight=1, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0040 {rsi}, byref, isz
-       mov      r14d, dword ptr [rsp+0x90]
-       dec      r14d
-       js       SHORT G_M3996_IG06
-						;; size=13 bbWeight=1 PerfScore 2.25
-G_M3996_IG03:        ; bbWeight=4, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0040 {rsi}, byref, isz
-       movsxd   rcx, r14d
-       lea      r15, bword ptr [rsi+8*rcx]
-       ; byrRegs +[r15]
-       mov      rcx, rbx
+						;; size=26 bbWeight=1 PerfScore 8.00
+G_M3996_IG02:        ; bbWeight=1, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
+       mov      ebp, dword ptr [rsp+0x80]
+       dec      ebp
+       js       SHORT G_M3996_IG07
+						;; size=11 bbWeight=1 PerfScore 2.25
+G_M3996_IG03:        ; bbWeight=0.50, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref
        call     [CORINFO_HELP_READYTORUN_GENERIC_HANDLE]
        ; gcr arg pop 0
-       mov      r13, rax
-       mov      r11, r13
+       mov      r14, rax
+						;; size=9 bbWeight=0.50 PerfScore 1.62
+G_M3996_IG04:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
+       movsxd   rdx, ebp
+       lea      r15, bword ptr [rbx+8*rdx]
+       ; byrRegs +[r15]
+       mov      r11, r14
+       mov      rdx, gword ptr [r15]
+       ; gcrRegs +[rdx]
+       mov      rcx, rsi
+       ; gcrRegs +[rcx]
+       call     [r11]
+       ; gcrRegs -[rcx rdx]
+       ; gcr arg pop 0
+       test     eax, eax
+       jg       SHORT G_M3996_IG06
+						;; size=23 bbWeight=4 PerfScore 30.00
+G_M3996_IG05:        ; bbWeight=2, gcrefRegs=00C0 {rsi rdi}, byrefRegs=8008 {rbx r15}, byref, isz
+       mov      r11, r14
        mov      rdx, gword ptr [r15]
        ; gcrRegs +[rdx]
        mov      rcx, rdi
        ; gcrRegs +[rcx]
        call     [r11]
        ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-       test     eax, eax
-       jg       SHORT G_M3996_IG05
-						;; size=35 bbWeight=4 PerfScore 44.00
-G_M3996_IG04:        ; bbWeight=2, gcrefRegs=00A0 {rbp rdi}, byrefRegs=8040 {rsi r15}, byref, isz
-       mov      r11, r13
-       mov      rdx, gword ptr [r15]
-       ; gcrRegs +[rdx]
-       mov      rcx, rbp
-       ; gcrRegs +[rcx]
-       call     [r11]
-       ; gcrRegs -[rcx rdx]
        ; byrRegs -[r15]
        ; gcr arg pop 0
        test     eax, eax
-       jge      SHORT G_M3996_IG08
+       jge      SHORT G_M3996_IG09
 						;; size=16 bbWeight=2 PerfScore 13.50
-G_M3996_IG05:        ; bbWeight=4, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0040 {rsi}, byref, isz
-       dec      r14d
-       jns      SHORT G_M3996_IG03
-						;; size=5 bbWeight=4 PerfScore 5.00
-G_M3996_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbp rdi]
-       ; byrRegs -[rsi]
+G_M3996_IG06:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
+       dec      ebp
+       jns      SHORT G_M3996_IG04
+						;; size=4 bbWeight=4 PerfScore 5.00
+G_M3996_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rsi rdi]
+       ; byrRegs -[rbx]
        mov      eax, -1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M3996_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 48
+G_M3996_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=15 bbWeight=0.50 PerfScore 2.38
-G_M3996_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      eax, r14d
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M3996_IG09:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 48
+						;; size=13 bbWeight=0.50 PerfScore 2.12
+G_M3996_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, ebp
+						;; size=2 bbWeight=0.50 PerfScore 0.12
+G_M3996_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=15 bbWeight=0.50 PerfScore 2.38
+						;; size=13 bbWeight=0.50 PerfScore 2.12
 
-; Total bytes of code 138, prolog size 19, PerfScore 79.00, instruction count 55, allocated bytes for code 138 (MethodHash=ca77f063) for method System.SpanHelpers:LastIndexOfAnyInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
+; Total bytes of code 122, prolog size 17, PerfScore 64.88, instruction count 50, allocated bytes for code 122 (MethodHash=ca77f063) for method System.SpanHelpers:LastIndexOfAnyInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -120,16 +117,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0E
-  CountOfUnwindCodes: 8
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0E UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-11.59%</span>) : 20083.dasm - System.SpanHelpers:LastIndexOfAnyExceptInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,107 +8,104 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T05] (  4,  7   )    long  ->  rbx         single-def
-;  V01 arg0         [V01,T06] (  3,  6   )   byref  ->  rsi         single-def
-;  V02 arg1         [V02,T07] (  3,  6   )     ref  ->  rdi         ld-addr-op class-hnd single-def <System.__Canon>
-;  V03 arg2         [V03,T08] (  3,  6   )     ref  ->  rbp         ld-addr-op class-hnd single-def <System.__Canon>
-;  V04 arg3         [V04,T09] (  1,  1   )     int  ->  [rsp+0x90]  single-def
-;  V05 loc0         [V05,T02] (  7, 18.50)     int  ->  r14        
+;  V00 TypeCtx      [V00,T08] (  4,  3.50)    long  ->  rcx         single-def
+;  V01 arg0         [V01,T05] (  3,  6   )   byref  ->  rbx         single-def
+;  V02 arg1         [V02,T06] (  3,  6   )     ref  ->  rsi         ld-addr-op class-hnd single-def <System.__Canon>
+;  V03 arg2         [V03,T07] (  3,  6   )     ref  ->  rdi         ld-addr-op class-hnd single-def <System.__Canon>
+;  V04 arg3         [V04,T09] (  1,  1   )     int  ->  [rsp+0x80]  single-def
+;  V05 loc0         [V05,T02] (  7, 18.50)     int  ->  rbp        
 ;  V06 loc1         [V06,T03] (  3, 12   )   byref  ->  r15        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08,T00] (  3, 24   )    long  ->  r11         "VirtualCall with runtime lookup"
 ;  V09 tmp2         [V09,T01] (  3, 24   )    long  ->  r11         "VirtualCall with runtime lookup"
-;  V10 cse0         [V10,T04] (  3, 12   )    long  ->  r13         "CSE - aggressive"
+;  V10 cse0         [V10,T04] (  3,  8.50)    long  ->  r14         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 48
+; Lcl frame size = 40
 
 G_M8739_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 48
-       mov      qword ptr [rsp+0x28], rcx
-       mov      rbx, rcx
-       mov      rsi, rdx
-       ; byrRegs +[rsi]
-       mov      rdi, r8
+       sub      rsp, 40
+       mov      qword ptr [rsp+0x20], rcx
+       mov      rbx, rdx
+       ; byrRegs +[rbx]
+       mov      rsi, r8
+       ; gcrRegs +[rsi]
+       mov      rdi, r9
        ; gcrRegs +[rdi]
-       mov      rbp, r9
-       ; gcrRegs +[rbp]
-						;; size=31 bbWeight=1 PerfScore 9.25
-G_M8739_IG02:        ; bbWeight=1, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0040 {rsi}, byref, isz
-       mov      r14d, dword ptr [rsp+0x90]
-       dec      r14d
-       js       SHORT G_M8739_IG04
-						;; size=13 bbWeight=1 PerfScore 2.25
-G_M8739_IG03:        ; bbWeight=4, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0040 {rsi}, byref, isz
-       movsxd   rcx, r14d
-       lea      r15, bword ptr [rsi+8*rcx]
-       ; byrRegs +[r15]
-       mov      rcx, rbx
+						;; size=26 bbWeight=1 PerfScore 8.00
+G_M8739_IG02:        ; bbWeight=1, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
+       mov      ebp, dword ptr [rsp+0x80]
+       dec      ebp
+       js       SHORT G_M8739_IG05
+						;; size=11 bbWeight=1 PerfScore 2.25
+G_M8739_IG03:        ; bbWeight=0.50, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref
        call     [CORINFO_HELP_READYTORUN_GENERIC_HANDLE]
        ; gcr arg pop 0
-       mov      r13, rax
-       mov      r11, r13
+       mov      r14, rax
+						;; size=9 bbWeight=0.50 PerfScore 1.62
+G_M8739_IG04:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0008 {rbx}, byref, isz
+       movsxd   rdx, ebp
+       lea      r15, bword ptr [rbx+8*rdx]
+       ; byrRegs +[r15]
+       mov      r11, r14
+       mov      rdx, gword ptr [r15]
+       ; gcrRegs +[rdx]
+       mov      rcx, rsi
+       ; gcrRegs +[rcx]
+       call     [r11]
+       ; gcrRegs -[rcx rdx]
+       ; gcr arg pop 0
+       test     eax, eax
+       jg       SHORT G_M8739_IG07
+       mov      r11, r14
        mov      rdx, gword ptr [r15]
        ; gcrRegs +[rdx]
        mov      rcx, rdi
        ; gcrRegs +[rcx]
        call     [r11]
        ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-       test     eax, eax
-       jg       SHORT G_M8739_IG06
-       mov      r11, r13
-       mov      rdx, gword ptr [r15]
-       ; gcrRegs +[rdx]
-       mov      rcx, rbp
-       ; gcrRegs +[rcx]
-       call     [r11]
-       ; gcrRegs -[rcx rdx]
        ; byrRegs -[r15]
        ; gcr arg pop 0
        test     eax, eax
-       jl       SHORT G_M8739_IG06
-       dec      r14d
-       jns      SHORT G_M8739_IG03
-						;; size=56 bbWeight=4 PerfScore 76.00
-G_M8739_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbp rdi]
-       ; byrRegs -[rsi]
+       jl       SHORT G_M8739_IG07
+       dec      ebp
+       jns      SHORT G_M8739_IG04
+						;; size=43 bbWeight=4 PerfScore 62.00
+G_M8739_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rsi rdi]
+       ; byrRegs -[rbx]
        mov      eax, -1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M8739_IG05:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 48
+G_M8739_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=15 bbWeight=0.50 PerfScore 2.38
-G_M8739_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      eax, r14d
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M8739_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 48
+						;; size=13 bbWeight=0.50 PerfScore 2.12
+G_M8739_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, ebp
+						;; size=2 bbWeight=0.50 PerfScore 0.12
+G_M8739_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=15 bbWeight=0.50 PerfScore 2.38
+						;; size=13 bbWeight=0.50 PerfScore 2.12
 
-; Total bytes of code 138, prolog size 19, PerfScore 92.50, instruction count 55, allocated bytes for code 138 (MethodHash=16cfdddc) for method System.SpanHelpers:LastIndexOfAnyExceptInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
+; Total bytes of code 122, prolog size 17, PerfScore 78.38, instruction count 50, allocated bytes for code 122 (MethodHash=16cfdddc) for method System.SpanHelpers:LastIndexOfAnyExceptInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -116,16 +113,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0E
-  CountOfUnwindCodes: 8
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0E UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:green">-13</span> (<span style="color:green">-9.77%</span>) : 232157.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:IsSorted[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,101 +9,98 @@
 ; 0 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T06] (  4,  7   )    long  ->  rsi         single-def
+;  V00 TypeCtx      [V00,T07] (  4,  3.50)    long  ->  rcx         single-def
 ;* V01 arg0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
-;  V02 arg1         [V02,T07] (  3,  6   )     ref  ->  rdi         class-hnd single-def <System.Collections.Generic.IComparer`1[System.__Canon]>
-;  V03 loc0         [V03,T01] (  6, 21   )     int  ->  rbp        
+;  V02 arg1         [V02,T06] (  3,  6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IComparer`1[System.__Canon]>
+;  V03 loc0         [V03,T01] (  6, 21   )     int  ->  rdi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T02] (  2, 16   )     ref  ->  r15         class-hnd "impAppendStmt" <System.__Canon>
-;  V06 tmp2         [V06,T00] (  3, 24   )    long  ->  rax         "VirtualCall with runtime lookup"
+;  V05 tmp1         [V05,T02] (  2, 16   )     ref  ->  rdx         class-hnd "impAppendStmt" <System.__Canon>
+;  V06 tmp2         [V06,T00] (  3, 24   )    long  ->  r11         "VirtualCall with runtime lookup"
 ;* V07 tmp3         [V07    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V08 tmp4         [V08,T03] (  4, 10   )     ref  ->  rbx         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V09 cse0         [V09,T05] (  4, 10   )     int  ->  r14         "CSE - aggressive"
-;  V10 cse1         [V10,T04] (  3, 12   )     int  ->  rcx         "CSE - aggressive"
+;  V09 cse0         [V09,T08] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
+;  V10 cse1         [V10,T05] (  4, 10   )     int  ->  rbp         "CSE - aggressive"
+;  V11 cse2         [V11,T04] (  3, 12   )     int  ->   r8         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
 G_M14055_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
-       mov      qword ptr [rsp+0x20], rcx
-       mov      rsi, rcx
+       sub      rsp, 48
+       mov      qword ptr [rsp+0x28], rcx
        mov      rbx, rdx
        ; gcrRegs +[rbx]
-       mov      rdi, r8
-       ; gcrRegs +[rdi]
-						;; size=26 bbWeight=1 PerfScore 8.00
-G_M14055_IG02:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      ebp, 1
-       mov      r14d, dword ptr [rbx+0x08]
-       cmp      r14d, 1
-       jle      SHORT G_M14055_IG04
-						;; size=15 bbWeight=1 PerfScore 3.50
-G_M14055_IG03:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       lea      ecx, [rbp-0x01]
-       cmp      ecx, r14d
-       jae      SHORT G_M14055_IG08
-       mov      r15, gword ptr [rbx+8*rcx+0x10]
-       ; gcrRegs +[r15]
-       mov      rcx, rsi
+       mov      rsi, r8
+       ; gcrRegs +[rsi]
+						;; size=21 bbWeight=1 PerfScore 6.75
+G_M14055_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+       mov      edi, 1
+       mov      ebp, dword ptr [rbx+0x08]
+       cmp      ebp, 1
+       jle      SHORT G_M14055_IG05
+						;; size=13 bbWeight=1 PerfScore 3.50
+G_M14055_IG03:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        call     [CORINFO_HELP_READYTORUN_GENERIC_HANDLE]
        ; gcr arg pop 0
-       mov      r8d, ebp
+       mov      r14, rax
+						;; size=9 bbWeight=0.50 PerfScore 1.62
+G_M14055_IG04:        ; bbWeight=4, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+       lea      r8d, [rdi-0x01]
+       cmp      r8d, ebp
+       jae      SHORT G_M14055_IG09
+       mov      rdx, gword ptr [rbx+8*r8+0x10]
+       ; gcrRegs +[rdx]
+       mov      r11, r14
+       mov      r8d, edi
        mov      r8, gword ptr [rbx+8*r8+0x10]
        ; gcrRegs +[r8]
-       mov      rcx, rdi
+       mov      rcx, rsi
        ; gcrRegs +[rcx]
-       mov      r11, rax
-       mov      rdx, r15
-       ; gcrRegs +[rdx]
-       call     [rax]
-       ; gcrRegs -[rcx rdx r8 r15]
+       call     [r11]
+       ; gcrRegs -[rcx rdx r8]
        ; gcr arg pop 0
        test     eax, eax
-       jg       SHORT G_M14055_IG06
-       inc      ebp
-       cmp      r14d, ebp
-       jg       SHORT G_M14055_IG03
-						;; size=52 bbWeight=4 PerfScore 63.00
-G_M14055_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rdi]
+       jg       SHORT G_M14055_IG07
+       inc      edi
+       cmp      ebp, edi
+       jg       SHORT G_M14055_IG04
+						;; size=41 bbWeight=4 PerfScore 49.00
+G_M14055_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rbx rsi]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M14055_IG05:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M14055_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=0.50 PerfScore 2.12
-G_M14055_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=11 bbWeight=0.50 PerfScore 1.88
+G_M14055_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M14055_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M14055_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=0.50 PerfScore 2.12
-G_M14055_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=11 bbWeight=0.50 PerfScore 1.88
+G_M14055_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     [CORINFO_HELP_RNGCHKFAIL]
        ; gcr arg pop 0
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 133, prolog size 17, PerfScore 79.00, instruction count 52, allocated bytes for code 133 (MethodHash=e617c918) for method Microsoft.CodeAnalysis.ImmutableArrayExtensions:IsSorted[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):ubyte (FullOpts)
+; Total bytes of code 120, prolog size 15, PerfScore 64.88, instruction count 47, allocated bytes for code 120 (MethodHash=e617c918) for method Microsoft.CodeAnalysis.ImmutableArrayExtensions:IsSorted[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -111,15 +108,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+16.13%</span>) : 176595.dasm - Newtonsoft.Json.JsonTextReader:MatchValue(ubyte,System.String):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,68 +8,80 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] ( 11, 12   )     ref  ->  rcx         this class-hnd single-def <Newtonsoft.Json.JsonTextReader>
-;  V01 arg1         [V01,T06] (  3,  3   )   ubyte  ->  rdx         single-def
-;  V02 arg2         [V02,T04] (  4,  7   )     ref  ->   r8         class-hnd single-def <System.String>
+;  V00 this         [V00,T04] ( 10,  4.50)     ref  ->  rcx         this class-hnd single-def <Newtonsoft.Json.JsonTextReader>
+;  V01 arg1         [V01,T07] (  3,  3   )   ubyte  ->  rdx         single-def
+;  V02 arg2         [V02,T03] (  4,  7   )     ref  ->   r8         class-hnd single-def <System.String>
 ;  V03 loc0         [V03,T02] (  7, 21.50)     int  ->  rdx        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T00] (  3, 24   )     ref  ->  r10         "arr expr"
-;  V06 tmp2         [V06,T01] (  3, 24   )     int  ->   r9         "index expr"
-;  V07 cse0         [V07,T05] (  4,  6.50)     int  ->  rax         "CSE - aggressive"
+;  V05 tmp1         [V05,T00] (  3, 24   )     ref  ->  r11         "arr expr"
+;  V06 tmp2         [V06,T01] (  3, 24   )     int  ->  rbx         "index expr"
+;  V07 cse0         [V07,T06] (  5,  6   )     int  ->   r9         hoist multi-def "CSE - aggressive"
+;  V08 cse1         [V08,T08] (  2,  4.50)     ref  ->  r10         hoist "CSE - aggressive"
+;  V09 cse2         [V09,T05] (  4,  6.50)     int  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M64114_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+       push     rbx
+       sub      rsp, 32
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M64114_IG02:        ; bbWeight=1, gcrefRegs=0102 {rcx r8}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx r8]
        test     dl, dl
-       je       SHORT G_M64114_IG09
+       je       SHORT G_M64114_IG10
        xor      edx, edx
        mov      eax, dword ptr [r8+0x08]
        test     eax, eax
-       jle      SHORT G_M64114_IG04
+       jle      SHORT G_M64114_IG05
 						;; size=14 bbWeight=1 PerfScore 4.75
-G_M64114_IG03:        ; bbWeight=4, gcrefRegs=0102 {rcx r8}, byrefRegs=0000 {}, byref, isz
+G_M64114_IG03:        ; bbWeight=0.50, gcrefRegs=0102 {rcx r8}, byrefRegs=0000 {}, byref
        mov      r10, gword ptr [rcx+0x70]
        ; gcrRegs +[r10]
-       mov      r9d, edx
-       add      r9d, dword ptr [rcx+0x8C]
-       cmp      r9d, dword ptr [r10+0x08]
-       jae      SHORT G_M64114_IG08
-       movzx    r10, word  ptr [r10+2*r9+0x10]
-       ; gcrRegs -[r10]
-       mov      r9d, edx
-       cmp      r10w, word  ptr [r8+2*r9+0x0C]
-       jne      SHORT G_M64114_IG06
+       mov      r9d, dword ptr [rcx+0x8C]
+						;; size=11 bbWeight=0.50 PerfScore 2.00
+G_M64114_IG04:        ; bbWeight=4, gcrefRegs=0502 {rcx r8 r10}, byrefRegs=0000 {}, byref, isz
+       mov      r11, r10
+       ; gcrRegs +[r11]
+       lea      ebx, [r9+rdx]
+       cmp      ebx, dword ptr [r11+0x08]
+       jae      SHORT G_M64114_IG09
+       movzx    r11, word  ptr [r11+2*rbx+0x10]
+       ; gcrRegs -[r11]
+       mov      ebx, edx
+       cmp      r11w, word  ptr [r8+2*rbx+0x0C]
+       jne      SHORT G_M64114_IG07
        inc      edx
        cmp      eax, edx
-       jg       SHORT G_M64114_IG03
-						;; size=43 bbWeight=4 PerfScore 68.00
-G_M64114_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r8]
-       add      dword ptr [rcx+0x8C], eax
+       jg       SHORT G_M64114_IG04
+						;; size=35 bbWeight=4 PerfScore 50.00
+G_M64114_IG05:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r8 r10]
+       mov      r9d, dword ptr [rcx+0x8C]
+       add      eax, r9d
+       mov      dword ptr [rcx+0x8C], eax
        mov      eax, 1
-						;; size=11 bbWeight=0.50 PerfScore 1.62
-G_M64114_IG05:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+						;; size=21 bbWeight=0.50 PerfScore 1.75
+G_M64114_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 32
+       pop      rbx
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M64114_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       add      dword ptr [rcx+0x8C], edx
+						;; size=6 bbWeight=0.50 PerfScore 0.88
+G_M64114_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
+       lea      eax, [r9+rdx]
+       mov      dword ptr [rcx+0x8C], eax
        xor      eax, eax
-						;; size=8 bbWeight=0.50 PerfScore 1.62
-G_M64114_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+						;; size=12 bbWeight=0.50 PerfScore 0.88
+G_M64114_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 32
+       pop      rbx
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M64114_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=6 bbWeight=0.50 PerfScore 0.88
+G_M64114_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rcx]
        call     [CORINFO_HELP_RNGCHKFAIL]
        ; gcr arg pop 0
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M64114_IG09:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+G_M64114_IG10:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
        mov      eax, dword ptr [rcx+0x88]
        mov      dword ptr [rcx+0x8C], eax
@@ -84,7 +96,7 @@ G_M64114_IG09:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        int3     
 						;; size=28 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 124, prolog size 4, PerfScore 77.50, instruction count 34, allocated bytes for code 124 (MethodHash=1c3a058d) for method Newtonsoft.Json.JsonTextReader:MatchValue(ubyte,System.String):ubyte:this (FullOpts)
+; Total bytes of code 144, prolog size 5, PerfScore 62.38, instruction count 41, allocated bytes for code 144 (MethodHash=1c3a058d) for method Newtonsoft.Json.JsonTextReader:MatchValue(ubyte,System.String):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -92,9 +104,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x04
-  CountOfUnwindCodes: 1
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+35</span> (<span style="color:red">+17.86%</span>) : 25703.dasm - Microsoft.FSharp.Quotations.PatternsModule:mkNewArray(System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]):Microsoft.FSharp.Quotations.FSharpExpr (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -18,85 +18,102 @@
 ;* V06 tmp1         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <System.Type>
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "non-inline candidate call" <System.Resources.ResourceManager>
 ;  V08 tmp3         [V08,T07] (  4,  8   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <Microsoft.FSharp.Quotations.ExprConstInfo+NewArrayOp>
-;  V09 tmp4         [V09,T00] (  2, 16   )     ref  ->  r14         "argument with side effect"
+;  V09 tmp4         [V09,T00] (  2, 16   )     ref  ->  [rsp+0x30]  spill-single-def "argument with side effect"
 ;  V10 tmp5         [V10,T01] (  2, 16   )     ref  ->   r8         "argument with side effect"
-;  V11 tmp6         [V11,T02] (  2, 16   )     ref  ->  rbp         "argument with side effect"
+;  V11 tmp6         [V11,T02] (  2, 16   )     ref  ->  r12         "argument with side effect"
 ;  V12 tmp7         [V12,T03] (  2, 16   )     ref  ->  rax         "argument with side effect"
+;  V13 cse0         [V13,T09] (  2,  4.50)     ref  ->  r14         hoist "CSE - aggressive"
+;  V14 cse1         [V14,T10] (  2,  4.50)     ref  ->  r15         hoist "CSE - aggressive"
+;  V15 cse2         [V15,T11] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V16 cse3         [V16,T12] (  2,  4.50)    long  ->  r13         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 48
+; Lcl frame size = 56
 
 G_M50297_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 48
+       sub      rsp, 56
        mov      rbx, rcx
        ; gcrRegs +[rbx]
        mov      rsi, rdx
        ; gcrRegs +[rsi]
-						;; size=16 bbWeight=1 PerfScore 5.75
-G_M50297_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+						;; size=22 bbWeight=1 PerfScore 8.75
+G_M50297_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        mov      rax, rsi
        ; gcrRegs +[rax]
        mov      rdi, gword ptr [rsi+0x10]
        ; gcrRegs +[rdi]
        test     rdi, rdi
-       je       SHORT G_M50297_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
-G_M50297_IG03:        ; bbWeight=4, gcrefRegs=00C9 {rax rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       je       G_M50297_IG05
+						;; size=16 bbWeight=1 PerfScore 3.50
+G_M50297_IG03:        ; bbWeight=0.50, gcrefRegs=00C9 {rax rbx rsi rdi}, byrefRegs=0000 {}, byref
+       mov      rbp, qword ptr [(reloc)]
+       mov      rdx, qword ptr [(reloc)]
+       mov      r14, gword ptr [rdx]
+       ; gcrRegs +[r14]
+       mov      rdx, qword ptr [(reloc)]
+       mov      r15, gword ptr [rdx]
+       ; gcrRegs +[r15]
+       mov      r13, qword ptr [(reloc)]
+						;; size=34 bbWeight=0.50 PerfScore 6.00
+G_M50297_IG04:        ; bbWeight=4, gcrefRegs=C0C9 {rax rbx rsi rdi r14 r15}, byrefRegs=0000 {}, byref, isz
        mov      rdx, gword ptr [rax+0x08]
        ; gcrRegs +[rdx]
-       mov      rcx, qword ptr [(reloc)]      ; <unknown method>
+       mov      rcx, rbp
        call     [<unknown method>]
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
+       mov      r12, rax
+       ; gcrRegs +[r12]
        call     [CORINFO_HELP_READYTORUN_GCSTATIC_BASE]
        ; gcrRegs -[rax]
        ; byrRegs +[rax]
        ; gcr arg pop 0
-       mov      r14, gword ptr [rax+0x1EF0]
-       ; gcrRegs +[r14]
-       call     [<unknown method>]
+       mov      rax, gword ptr [rax+0x1EF0]
        ; gcrRegs +[rax]
        ; byrRegs -[rax]
+       mov      gword ptr [rsp+0x30], rax
+       ; GC ptr vars +{V09}
+       call     [<unknown method>]
        ; gcr arg pop 0
        mov      r8, rax
        ; gcrRegs +[r8]
-       mov      rcx, r14
+       mov      rcx, gword ptr [rsp+0x30]
        ; gcrRegs +[rcx]
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rdx, gword ptr [rdx]
+       mov      rdx, r14
        ; gcrRegs +[rdx]
        lea      r11, [(reloc)]      ; function address
        cmp      dword ptr [rcx], ecx
+       ; GC ptr vars -{V09}
        call     [r11]<unknown method>
-       ; gcrRegs -[rcx rdx r8 r14]
+       ; gcrRegs -[rcx rdx r8]
        ; gcr arg pop 0
-       mov      r8, rbp
+       mov      r8, r12
        ; gcrRegs +[r8]
        mov      gword ptr [rsp+0x20], rax
        ; gcr arg write
-       mov      r9, qword ptr [(reloc)]      ; const ptr
-       mov      r9, gword ptr [r9]
+       mov      r9, r15
        ; gcrRegs +[r9]
-       mov      rcx, qword ptr [(reloc)]      ; <unknown method>
+       mov      rcx, r13
        mov      rdx, rbx
        ; gcrRegs +[rdx]
        call     [Microsoft.FSharp.Quotations.PatternsModule:checkTypesSR[System.__Canon](System.Type,System.Type,System.__Canon,System.String)]
-       ; gcrRegs -[rax rdx rbp r8-r9]
+       ; gcrRegs -[rax rdx r8-r9 r12]
        ; gcr arg pop 0
        mov      rax, rdi
        ; gcrRegs +[rax]
        mov      rdi, gword ptr [rax+0x10]
        test     rdi, rdi
-       jne      SHORT G_M50297_IG03
-						;; size=113 bbWeight=4 PerfScore 161.00
-G_M50297_IG04:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdi]
+       jne      SHORT G_M50297_IG04
+						;; size=98 bbWeight=4 PerfScore 124.00
+G_M50297_IG05:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax rdi r14-r15]
        call     [CORINFO_HELP_READYTORUN_NEW]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
@@ -116,17 +133,20 @@ G_M50297_IG04:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs +[rcx]
        lea      rax, [(reloc)]      ; function address
 						;; size=42 bbWeight=1 PerfScore 9.00
-G_M50297_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 48
+G_M50297_IG06:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r12
+       pop      r13
        pop      r14
+       pop      r15
        tail.jmp [rax]Microsoft.FSharp.Quotations.PatternsModule:mkFEN(Microsoft.FSharp.Quotations.ExprConstInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]):Microsoft.FSharp.Quotations.FSharpExpr
-						;; size=13 bbWeight=1 PerfScore 4.75
+						;; size=19 bbWeight=1 PerfScore 6.25
 
-; Total bytes of code 196, prolog size 16, PerfScore 184.00, instruction count 53, allocated bytes for code 196 (MethodHash=e3a13b86) for method Microsoft.FSharp.Quotations.PatternsModule:mkNewArray(System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]):Microsoft.FSharp.Quotations.FSharpExpr (FullOpts)
+; Total bytes of code 231, prolog size 22, PerfScore 157.50, instruction count 64, allocated bytes for code 231 (MethodHash=e3a13b86) for method Microsoft.FSharp.Quotations.PatternsModule:mkNewArray(System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]):Microsoft.FSharp.Quotations.FSharpExpr (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -134,14 +154,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x10
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
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
<summary><span style="color:red">+24</span> (<span style="color:red">+41.38%</span>) : 3384.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,45 +9,57 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4, 18   )     ref  ->  rbx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
-;  V01 loc0         [V01,T01] (  3, 17   )   float  ->  mm0        
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
+;  V01 loc0         [V01,T02] (  3, 17   )   float  ->  mm0        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;  V04 cse0         [V04,T00] (  2,  9   )   byref  ->  rbx         hoist "CSE - aggressive"
+;  V05 cse1         [V05,T03] (  2,  9   )  double  ->  mm6         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T04] (  2,  9   )   float  ->  mm7         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 64
 
-G_M31728_IG01:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M31728_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=8 bbWeight=8 PerfScore 12.00
-G_M31728_IG02:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       cmp      byte  ptr [rbx], bl
-       lea      rcx, bword ptr [rbx+0x08]
+       sub      rsp, 64
+       movaps   xmmword ptr [rsp+0x30], xmm6
+       movaps   xmmword ptr [rsp+0x20], xmm7
+						;; size=15 bbWeight=1 PerfScore 5.25
+G_M31728_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rcx]
+       cmp      byte  ptr [rcx], cl
+       lea      rbx, bword ptr [rcx+0x08]
+       ; byrRegs +[rbx]
+       movsd    xmm6, qword ptr [reloc @RWD00]
+       movss    xmm7, dword ptr [reloc @RWD08]
+						;; size=22 bbWeight=1 PerfScore 9.50
+G_M31728_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, rbx
        ; byrRegs +[rcx]
        call     [<unknown method>]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        xorps    xmm0, xmm0
        cvtsi2sd  xmm0, eax
-       mulsd    xmm0, qword ptr [reloc @RWD00]
+       mulsd    xmm0, xmm6
        cvtsd2ss xmm0, xmm0
-       movss    xmm1, dword ptr [reloc @RWD08]
-       ucomiss  xmm1, xmm0
-       jbe      SHORT G_M31728_IG02
-						;; size=44 bbWeight=8 PerfScore 222.67
-G_M31728_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       add      rsp, 32
+       ucomiss  xmm7, xmm0
+       jbe      SHORT G_M31728_IG03
+						;; size=29 bbWeight=8 PerfScore 156.67
+G_M31728_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rbx]
+       movaps   xmm6, xmmword ptr [rsp+0x30]
+       movaps   xmm7, xmmword ptr [rsp+0x20]
+       add      rsp, 64
        pop      rbx
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=16 bbWeight=1 PerfScore 9.75
 RWD00  	dq	3E00000000200000h	; 4.65661288e-10
 RWD08  	dd	3F800000h		;         1
 
 
-; Total bytes of code 58, prolog size 5, PerfScore 236.42, instruction count 16, allocated bytes for code 58 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
+; Total bytes of code 82, prolog size 15, PerfScore 181.17, instruction count 21, allocated bytes for code 82 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -55,10 +67,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x0F
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x0F UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 2 * 16 = 32 = 0x00020
+    CodeOffset: 0x0A UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 3 * 16 = 48 = 0x00030
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-29</span> (<span style="color:green">-16.20%</span>) : 8841.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,System.Nullable`1[int]](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,System.Nullable`1[int]] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,122 +8,108 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T06] (  5,  7.80)    long  ->  rbx         single-def
-;  V01 arg0         [V01,T09] (  3,  6   )     ref  ->  rdi         class-hnd single-def <System.Collections.Generic.IComparer`1[System.__Canon]>
-;  V02 arg1         [V02,T07] (  4,  7   )     ref  ->  rsi         class-hnd single-def <System.__Canon[]>
-;  V03 loc0         [V03,T08] (  3,  9   )     ref  ->  rbp         must-init class-hnd <Microsoft.FSharp.Collections.MapTree`2[System.__Canon,System.Nullable`1[int]]>
-;  V04 loc1         [V04,T02] (  5, 17   )     int  ->  r14        
-;  V05 loc2         [V05,T03] (  4, 16   )     ref  ->  rcx         class-hnd <System.Tuple`2[System.__Canon,System.Nullable`1[int]]>
+;  V00 TypeCtx      [V00,T11] (  5,  3.60)    long  ->  rcx         single-def
+;  V01 arg0         [V01,T06] (  3,  6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IComparer`1[System.__Canon]>
+;  V02 arg1         [V02,T04] (  4,  7   )     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
+;  V03 loc0         [V03,T05] (  3,  9   )     ref  ->  rdi         must-init class-hnd <Microsoft.FSharp.Collections.MapTree`2[System.__Canon,System.Nullable`1[int]]>
+;  V04 loc1         [V04,T01] (  5, 17   )     int  ->  rbp        
+;  V05 loc2         [V05,T02] (  4, 16   )     ref  ->  rcx         class-hnd <System.Tuple`2[System.__Canon,System.Nullable`1[int]]>
 ;* V06 loc3         [V06    ] (  0,  0   )  struct ( 8) zero-ref    <System.Nullable`1[int]>
-;  V07 loc4         [V07,T10] (  2,  8   )     ref  ->  [rsp+0x30]  class-hnd spill-single-def <System.__Canon>
+;  V07 loc4         [V07,T07] (  2,  8   )     ref  ->  rdx         class-hnd <System.__Canon>
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V10 tmp2         [V10,T11] (  2,  8   )   ubyte  ->  r13         "field V06.hasValue (fldOffset=0x0)" P-INDEP
-;  V11 tmp3         [V11,T12] (  2,  8   )     int  ->  r12         "field V06.value (fldOffset=0x4)" P-INDEP
-;  V12 tmp4         [V12,T00] (  3, 24   )  struct ( 8) [rsp+0x38]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[int]>
-;  V13 tmp5         [V13,T05] (  2, 16   )    long  ->  rcx         "argument with side effect"
-;  V14 cse0         [V14,T13] (  3,  6   )     int  ->  r15         "CSE - aggressive"
-;  V15 rat0         [V15,T04] (  3, 16   )    long  ->  rcx         "runtime lookup"
-;  V16 rat1         [V16,T01] (  3, 22.40)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V10 tmp2         [V10,T08] (  2,  8   )   ubyte  ->   r9         "field V06.hasValue (fldOffset=0x0)" P-INDEP
+;  V11 tmp3         [V11,T09] (  2,  8   )     int  ->   r8         "field V06.value (fldOffset=0x4)" P-INDEP
+;  V12 tmp4         [V12,T00] (  3, 24   )  struct ( 8) [rsp+0x28]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[int]>
+;  V13 tmp5         [V13,T03] (  2, 16   )    long  ->  rcx         "argument with side effect"
+;  V14 cse0         [V14,T12] (  2,  4.50)    long  ->  r15         hoist "CSE - aggressive"
+;  V15 cse1         [V15,T10] (  3,  6   )     int  ->  r14         "CSE - aggressive"
+;  V16 rat0         [V16,T14] (  3,  2   )    long  ->  r15         "runtime lookup"
+;  V17 rat1         [V17,T13] (  3,  2.80)    long  ->  r15         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 56
 
 G_M27549_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
-       push     r13
-       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 72
-       mov      qword ptr [rsp+0x40], rcx
-       mov      rbx, rcx
-       mov      rdi, rdx
-       ; gcrRegs +[rdi]
-       mov      rsi, r8
+       sub      rsp, 56
+       mov      qword ptr [rsp+0x30], rcx
+       mov      rsi, rdx
        ; gcrRegs +[rsi]
+       mov      rbx, r8
+       ; gcrRegs +[rbx]
+       xor      edi, edi
+						;; size=25 bbWeight=1 PerfScore 8.00
+G_M27549_IG02:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rdi]
        xor      ebp, ebp
-						;; size=32 bbWeight=1 PerfScore 10.25
-G_M27549_IG02:        ; bbWeight=1, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rbp]
-       xor      r14d, r14d
-       mov      r15d, dword ptr [rsi+0x08]
-       test     r15d, r15d
+       mov      r14d, dword ptr [rbx+0x08]
+       test     r14d, r14d
        jle      SHORT G_M27549_IG07
-						;; size=12 bbWeight=1 PerfScore 3.50
-G_M27549_IG03:        ; bbWeight=4, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      ecx, r14d
-       mov      rcx, gword ptr [rsi+8*rcx+0x10]
-       ; gcrRegs +[rcx]
-       movzx    r13, byte  ptr [rcx+0x10]
-       mov      r12d, dword ptr [rcx+0x14]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       mov      gword ptr [rsp+0x30], rax
-       ; GC ptr vars +{V07}
-       mov      rcx, qword ptr [rbx+0x38]
-       ; gcrRegs -[rcx]
-       mov      rcx, qword ptr [rcx+0x18]
-       test     rcx, rcx
+						;; size=11 bbWeight=1 PerfScore 3.50
+G_M27549_IG03:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rdx, qword ptr [rcx+0x38]
+       mov      r15, qword ptr [rdx+0x18]
+       test     r15, r15
        je       SHORT G_M27549_IG05
-						;; size=39 bbWeight=4 PerfScore 58.00
-G_M27549_IG04:        ; bbWeight=3.20, gcVars=0000000000000400 {V07}, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs -[rax]
-       mov      rax, gword ptr [rsp+0x30]
-       ; gcrRegs +[rax]
+						;; size=13 bbWeight=0.50 PerfScore 2.62
+G_M27549_IG04:        ; bbWeight=0.40, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M27549_IG06
-						;; size=7 bbWeight=3.20 PerfScore 9.60
-G_M27549_IG05:        ; bbWeight=0.80, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rcx, rbx
+						;; size=2 bbWeight=0.40 PerfScore 0.80
+G_M27549_IG05:        ; bbWeight=0.10, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rcx, rax
-       mov      rax, gword ptr [rsp+0x30]
-       ; gcrRegs +[rax]
-						;; size=26 bbWeight=0.80 PerfScore 2.20
-G_M27549_IG06:        ; bbWeight=4, gcrefRegs=00E1 {rax rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      byte  ptr [rsp+0x38], r13b
-       mov      dword ptr [rsp+0x3C], r12d
-       mov      gword ptr [rsp+0x20], rbp
-       ; gcr arg write
-       mov      r9, qword ptr [rsp+0x38]
-       mov      r8, rax
-       ; gcrRegs +[r8]
-       mov      rdx, rdi
+       mov      r15, rax
+						;; size=18 bbWeight=0.10 PerfScore 0.15
+G_M27549_IG06:        ; bbWeight=4, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, ebp
+       mov      rcx, gword ptr [rbx+8*rcx+0x10]
+       ; gcrRegs +[rcx]
+       movzx    r9, byte  ptr [rcx+0x10]
+       mov      r8d, dword ptr [rcx+0x14]
+       mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
-       ; GC ptr vars -{V07}
+       mov      rcx, r15
+       ; gcrRegs -[rcx]
+       mov      byte  ptr [rsp+0x28], r9b
+       mov      dword ptr [rsp+0x2C], r8d
+       mov      gword ptr [rsp+0x20], rdi
+       ; gcr arg write
+       mov      r9, qword ptr [rsp+0x28]
+       mov      r8, rdx
+       ; gcrRegs +[r8]
+       mov      rdx, rsi
        call     [<unknown method>]
-       ; gcrRegs -[rdx rbp r8]
+       ; gcrRegs -[rdx rdi r8] +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       inc      r14d
-       cmp      r15d, r14d
-       jg       SHORT G_M27549_IG03
-						;; size=43 bbWeight=4 PerfScore 37.00
-G_M27549_IG07:        ; bbWeight=1, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rsi rdi]
-       mov      rax, rbp
+       mov      rdi, rax
+       ; gcrRegs +[rdi]
+       inc      ebp
+       cmp      r14d, ebp
+       jg       SHORT G_M27549_IG06
+						;; size=65 bbWeight=4 PerfScore 71.00
+G_M27549_IG07:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax rbx rsi]
+       mov      rax, rdi
        ; gcrRegs +[rax]
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M27549_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 72
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r12
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=17 bbWeight=1 PerfScore 5.25
+						;; size=13 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 179, prolog size 21, PerfScore 126.05, instruction count 57, allocated bytes for code 179 (MethodHash=e88a9462) for method Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,System.Nullable`1[int]](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,System.Nullable`1[int]] (FullOpts)
+; Total bytes of code 150, prolog size 17, PerfScore 90.58, instruction count 49, allocated bytes for code 150 (MethodHash=e88a9462) for method Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,System.Nullable`1[int]](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,System.Nullable`1[int]] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -131,17 +117,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x10
-  CountOfUnwindCodes: 9
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
-    CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r12 (12)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:green">-24</span> (<span style="color:green">-13.87%</span>) : 172877.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte],int,int,ubyte):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,14 +8,14 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  3, 12   )   byref  ->  rbx         ld-addr-op single-def
-;  V01 arg1         [V01,T19] (  3,  3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T20] (  3,  3   )     int  ->   r8         single-def
-;  V03 arg3         [V03,T13] (  3,  6   )   ubyte  ->  rsi         single-def
-;  V04 loc0         [V04,T05] (  8, 17.50)     int  ->  rdi        
-;  V05 loc1         [V05,T08] (  5, 12   )     int  ->  rbp        
-;  V06 loc2         [V06,T06] (  6, 16.50)     int  ->  r14        
-;  V07 loc3         [V07,T10] (  3, 12   )     int  ->  rax        
+;  V00 arg0         [V00,T19] (  3,  5   )   byref  ->  rcx         ld-addr-op single-def
+;  V01 arg1         [V01,T20] (  3,  3   )     int  ->  rdx         single-def
+;  V02 arg2         [V02,T21] (  3,  3   )     int  ->   r8         single-def
+;  V03 arg3         [V03,T13] (  3,  6   )   ubyte  ->  rbx         single-def
+;  V04 loc0         [V04,T04] (  8, 17.50)     int  ->  rsi        
+;  V05 loc1         [V05,T07] (  5, 12   )     int  ->  rdi        
+;  V06 loc2         [V06,T05] (  6, 16.50)     int  ->  rax        
+;  V07 loc3         [V07,T09] (  3, 12   )     int  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )     int  ->  zero-ref    "spilling side-effects"
 ;* V10 tmp2         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <<unknown class>>
@@ -26,123 +26,117 @@
 ;* V15 tmp7         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <<unknown class>>
 ;* V16 tmp8         [V16    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V18 tmp10        [V18,T07] (  2, 16   )   byref  ->  rax         "Inlining Arg"
+;  V18 tmp10        [V18,T06] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
 ;* V19 tmp11        [V19    ] (  0,  0   )     ref  ->  zero-ref    "field V00._items (fldOffset=0x0)" P-INDEP
 ;* V20 tmp12        [V20    ] (  0,  0   )     int  ->  zero-ref    "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V21 tmp13        [V21    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte]>
-;  V22 tmp14        [V22,T00] (  3, 24   )     ref  ->  rax         "arr expr"
-;  V23 tmp15        [V23,T02] (  3, 24   )     int  ->  rcx         "index expr"
-;  V24 tmp16        [V24,T01] (  3, 24   )     ref  ->  r15         "arr expr"
-;  V25 tmp17        [V25,T03] (  3, 24   )     int  ->  rax         "index expr"
+;  V22 tmp14        [V22,T00] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V23 tmp15        [V23,T02] (  3, 24   )     int  ->  rdx         "index expr"
+;  V24 tmp16        [V24,T01] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V25 tmp17        [V25,T03] (  3, 24   )     int  ->  rdx         "index expr"
 ;* V26 tmp18        [V26,T15] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V27 tmp19        [V27,T17] (  0,  0   )     int  ->  zero-ref    "index expr"
 ;* V28 tmp20        [V28,T16] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V29 tmp21        [V29,T18] (  0,  0   )     int  ->  zero-ref    "index expr"
-;  V30 cse0         [V30,T11] (  2,  8   )     int  ->  rax         "CSE - moderate"
-;  V31 cse1         [V31,T12] (  2,  8   )     int  ->  rcx         "CSE - moderate"
-;* V32 cse2         [V32,T21] (  0,  0   )    long  ->  zero-ref    "CSE - moderate"
-;  V33 cse3         [V33,T09] (  2,  8   )     ref  ->  rax         "CSE - moderate"
-;  V34 cse4         [V34,T14] (  2,  8   )   byref  ->  rax         "CSE - moderate"
+;  V30 cse0         [V30,T10] (  2,  8   )     int  ->  rdx         "CSE - moderate"
+;  V31 cse1         [V31,T11] (  2,  8   )     int  ->  rdx         "CSE - moderate"
+;* V32 cse2         [V32,T22] (  0,  0   )    long  ->  zero-ref    hoist "CSE - moderate"
+;  V33 cse3         [V33,T08] (  2,  8   )     ref  ->  rcx         "CSE - moderate"
+;  V34 cse4         [V34,T14] (  2,  8   )   byref  ->  rcx         "CSE - moderate"
+;  V35 cse5         [V35,T12] (  2,  4.50)     ref  ->  rbp         hoist "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
 G_M34942_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
        sub      rsp, 40
-       mov      rbx, rcx
-       ; byrRegs +[rbx]
-       mov      esi, r9d
-						;; size=18 bbWeight=1 PerfScore 6.75
-G_M34942_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       mov      edi, edx
-       lea      ebp, [rdi+r8-0x01]
-       cmp      edi, ebp
-       jg       SHORT G_M34942_IG07
+       mov      ebx, r9d
+						;; size=11 bbWeight=1 PerfScore 4.50
+G_M34942_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
+       ; byrRegs +[rcx]
+       mov      esi, edx
+       lea      edi, [rsi+r8-0x01]
+       cmp      esi, edi
+       jg       SHORT G_M34942_IG08
 						;; size=11 bbWeight=1 PerfScore 2.50
-G_M34942_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       mov      r14d, ebp
-       sub      r14d, edi
-       sar      r14d, 1
-       add      r14d, edi
-       mov      r15, gword ptr [rbx]
-       ; gcrRegs +[r15]
+G_M34942_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       mov      rbp, gword ptr [rcx]
+       ; gcrRegs +[rbp]
        mov      rcx, 0xD1FFAB1E
+       ; byrRegs -[rcx]
        mov      edx, 94
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        ; gcr arg pop 0
-       mov      eax, dword ptr [(reloc)]      ; static handle
-       sarx     eax, r14d, eax
-       cmp      eax, dword ptr [r15+0x08]
-       jae      SHORT G_M34942_IG11
-       mov      rax, gword ptr [r15+8*rax+0x10]
-       ; gcrRegs +[rax]
-       mov      ecx, r14d
-       and      ecx, dword ptr [(reloc)]      ; static handle
-       cmp      ecx, dword ptr [rax+0x08]
-       jae      SHORT G_M34942_IG11
-       lea      rax, bword ptr [rax+rcx+0x10]
-       ; gcrRegs -[rax]
-       ; byrRegs +[rax]
-       movzx    rax, byte  ptr [rax]
-       ; byrRegs -[rax]
-       movzx    rcx, sil
-       sub      eax, ecx
-       je       SHORT G_M34942_IG09
-       test     eax, eax
-       jge      SHORT G_M34942_IG05
-						;; size=91 bbWeight=4 PerfScore 105.00
-G_M34942_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       ; gcrRegs -[r15]
-       lea      edi, [r14+0x01]
-       jmp      SHORT G_M34942_IG06
-						;; size=6 bbWeight=2 PerfScore 5.00
-G_M34942_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
-       lea      ebp, [r14-0x01]
-						;; size=4 bbWeight=2 PerfScore 1.00
-G_M34942_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       cmp      edi, ebp
-       jle      SHORT G_M34942_IG03
-						;; size=4 bbWeight=4 PerfScore 5.00
-G_M34942_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rbx]
+						;; size=23 bbWeight=0.50 PerfScore 1.75
+G_M34942_IG04:        ; bbWeight=4, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref, isz
        mov      eax, edi
+       sub      eax, esi
+       sar      eax, 1
+       add      eax, esi
+       mov      rcx, rbp
+       ; gcrRegs +[rcx]
+       mov      edx, dword ptr [(reloc)]      ; static handle
+       sarx     edx, eax, edx
+       cmp      edx, dword ptr [rcx+0x08]
+       jae      SHORT G_M34942_IG11
+       mov      rcx, gword ptr [rcx+8*rdx+0x10]
+       mov      edx, eax
+       and      edx, dword ptr [(reloc)]      ; static handle
+       cmp      edx, dword ptr [rcx+0x08]
+       jae      SHORT G_M34942_IG11
+       lea      rcx, bword ptr [rcx+rdx+0x10]
+       ; gcrRegs -[rcx]
+       ; byrRegs +[rcx]
+       movzx    rcx, byte  ptr [rcx]
+       ; byrRegs -[rcx]
+       movzx    rdx, bl
+       sub      ecx, edx
+       je       SHORT G_M34942_IG10
+       test     ecx, ecx
+       jge      SHORT G_M34942_IG06
+						;; size=64 bbWeight=4 PerfScore 92.00
+G_M34942_IG05:        ; bbWeight=2, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref, isz
+       lea      esi, [rax+0x01]
+       jmp      SHORT G_M34942_IG07
+						;; size=5 bbWeight=2 PerfScore 5.00
+G_M34942_IG06:        ; bbWeight=2, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
+       lea      edi, [rax-0x01]
+						;; size=3 bbWeight=2 PerfScore 1.00
+G_M34942_IG07:        ; bbWeight=4, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref, isz
+       cmp      esi, edi
+       jle      SHORT G_M34942_IG04
+						;; size=4 bbWeight=4 PerfScore 5.00
+G_M34942_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rbp]
+       mov      eax, esi
        not      eax
 						;; size=4 bbWeight=0.50 PerfScore 0.25
-G_M34942_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+G_M34942_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=0.50 PerfScore 2.12
-G_M34942_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      eax, r14d
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M34942_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=9 bbWeight=0.50 PerfScore 1.62
+G_M34942_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=0.50 PerfScore 2.12
+						;; size=9 bbWeight=0.50 PerfScore 1.62
 G_M34942_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 173, prolog size 18, PerfScore 129.88, instruction count 63, allocated bytes for code 173 (MethodHash=756b7781) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte],int,int,ubyte):int (FullOpts)
+; Total bytes of code 149, prolog size 11, PerfScore 115.25, instruction count 56, allocated bytes for code 149 (MethodHash=756b7781) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte],int,int,ubyte):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -150,15 +144,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:green">-23</span> (<span style="color:green">-13.22%</span>) : 172888.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[short]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short],int,int,short):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,14 +8,14 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  3, 12   )   byref  ->  rbx         ld-addr-op single-def
-;  V01 arg1         [V01,T19] (  3,  3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T20] (  3,  3   )     int  ->   r8         single-def
-;  V03 arg3         [V03,T13] (  3,  6   )   short  ->  rsi         single-def
-;  V04 loc0         [V04,T05] (  8, 17.50)     int  ->  rdi        
-;  V05 loc1         [V05,T08] (  5, 12   )     int  ->  rbp        
-;  V06 loc2         [V06,T06] (  6, 16.50)     int  ->  r14        
-;  V07 loc3         [V07,T10] (  3, 12   )     int  ->  rax        
+;  V00 arg0         [V00,T19] (  3,  5   )   byref  ->  rcx         ld-addr-op single-def
+;  V01 arg1         [V01,T20] (  3,  3   )     int  ->  rdx         single-def
+;  V02 arg2         [V02,T21] (  3,  3   )     int  ->   r8         single-def
+;  V03 arg3         [V03,T13] (  3,  6   )   short  ->  rbx         single-def
+;  V04 loc0         [V04,T04] (  8, 17.50)     int  ->  rsi        
+;  V05 loc1         [V05,T07] (  5, 12   )     int  ->  rdi        
+;  V06 loc2         [V06,T05] (  6, 16.50)     int  ->  rax        
+;  V07 loc3         [V07,T09] (  3, 12   )     int  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )     int  ->  zero-ref    "spilling side-effects"
 ;* V10 tmp2         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <<unknown class>>
@@ -26,123 +26,117 @@
 ;* V15 tmp7         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <<unknown class>>
 ;* V16 tmp8         [V16    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V18 tmp10        [V18,T07] (  2, 16   )   byref  ->  rax         "Inlining Arg"
+;  V18 tmp10        [V18,T06] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
 ;* V19 tmp11        [V19    ] (  0,  0   )     ref  ->  zero-ref    "field V00._items (fldOffset=0x0)" P-INDEP
 ;* V20 tmp12        [V20    ] (  0,  0   )     int  ->  zero-ref    "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V21 tmp13        [V21    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short]>
-;  V22 tmp14        [V22,T00] (  3, 24   )     ref  ->  rax         "arr expr"
-;  V23 tmp15        [V23,T02] (  3, 24   )     int  ->  rcx         "index expr"
-;  V24 tmp16        [V24,T01] (  3, 24   )     ref  ->  r15         "arr expr"
-;  V25 tmp17        [V25,T03] (  3, 24   )     int  ->  rax         "index expr"
+;  V22 tmp14        [V22,T00] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V23 tmp15        [V23,T02] (  3, 24   )     int  ->  rdx         "index expr"
+;  V24 tmp16        [V24,T01] (  3, 24   )     ref  ->  rcx         "arr expr"
+;  V25 tmp17        [V25,T03] (  3, 24   )     int  ->  rdx         "index expr"
 ;* V26 tmp18        [V26,T15] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V27 tmp19        [V27,T17] (  0,  0   )     int  ->  zero-ref    "index expr"
 ;* V28 tmp20        [V28,T16] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V29 tmp21        [V29,T18] (  0,  0   )     int  ->  zero-ref    "index expr"
-;  V30 cse0         [V30,T11] (  2,  8   )     int  ->  rax         "CSE - moderate"
-;  V31 cse1         [V31,T12] (  2,  8   )     int  ->  rcx         "CSE - moderate"
-;* V32 cse2         [V32,T21] (  0,  0   )    long  ->  zero-ref    "CSE - moderate"
-;  V33 cse3         [V33,T09] (  2,  8   )     ref  ->  rax         "CSE - moderate"
-;  V34 cse4         [V34,T14] (  2,  8   )   byref  ->  rax         "CSE - moderate"
+;  V30 cse0         [V30,T10] (  2,  8   )     int  ->  rdx         "CSE - moderate"
+;  V31 cse1         [V31,T11] (  2,  8   )     int  ->  rdx         "CSE - moderate"
+;* V32 cse2         [V32,T22] (  0,  0   )    long  ->  zero-ref    hoist "CSE - moderate"
+;  V33 cse3         [V33,T08] (  2,  8   )     ref  ->  rcx         "CSE - moderate"
+;  V34 cse4         [V34,T14] (  2,  8   )   byref  ->  rcx         "CSE - moderate"
+;  V35 cse5         [V35,T12] (  2,  4.50)     ref  ->  rbp         hoist "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
 G_M22803_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
        sub      rsp, 40
-       mov      rbx, rcx
-       ; byrRegs +[rbx]
-       mov      esi, r9d
-						;; size=18 bbWeight=1 PerfScore 6.75
-G_M22803_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       mov      edi, edx
-       lea      ebp, [rdi+r8-0x01]
-       cmp      edi, ebp
-       jg       SHORT G_M22803_IG07
+       mov      ebx, r9d
+						;; size=11 bbWeight=1 PerfScore 4.50
+G_M22803_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
+       ; byrRegs +[rcx]
+       mov      esi, edx
+       lea      edi, [rsi+r8-0x01]
+       cmp      esi, edi
+       jg       SHORT G_M22803_IG08
 						;; size=11 bbWeight=1 PerfScore 2.50
-G_M22803_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       mov      r14d, ebp
-       sub      r14d, edi
-       sar      r14d, 1
-       add      r14d, edi
-       mov      r15, gword ptr [rbx]
-       ; gcrRegs +[r15]
+G_M22803_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       mov      rbp, gword ptr [rcx]
+       ; gcrRegs +[rbp]
        mov      rcx, 0xD1FFAB1E
+       ; byrRegs -[rcx]
        mov      edx, 95
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        ; gcr arg pop 0
-       mov      eax, dword ptr [(reloc)]      ; static handle
-       sarx     eax, r14d, eax
-       cmp      eax, dword ptr [r15+0x08]
-       jae      SHORT G_M22803_IG11
-       mov      rax, gword ptr [r15+8*rax+0x10]
-       ; gcrRegs +[rax]
-       mov      ecx, r14d
-       and      ecx, dword ptr [(reloc)]      ; static handle
-       cmp      ecx, dword ptr [rax+0x08]
-       jae      SHORT G_M22803_IG11
-       lea      rax, bword ptr [rax+2*rcx+0x10]
-       ; gcrRegs -[rax]
-       ; byrRegs +[rax]
-       movsx    rax, word  ptr [rax]
-       ; byrRegs -[rax]
-       movsx    rcx, si
-       sub      eax, ecx
-       je       SHORT G_M22803_IG09
-       test     eax, eax
-       jge      SHORT G_M22803_IG05
-						;; size=92 bbWeight=4 PerfScore 113.00
-G_M22803_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       ; gcrRegs -[r15]
-       lea      edi, [r14+0x01]
-       jmp      SHORT G_M22803_IG06
-						;; size=6 bbWeight=2 PerfScore 5.00
-G_M22803_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
-       lea      ebp, [r14-0x01]
-						;; size=4 bbWeight=2 PerfScore 1.00
-G_M22803_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
-       cmp      edi, ebp
-       jle      SHORT G_M22803_IG03
-						;; size=4 bbWeight=4 PerfScore 5.00
-G_M22803_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rbx]
+						;; size=23 bbWeight=0.50 PerfScore 1.75
+G_M22803_IG04:        ; bbWeight=4, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref, isz
        mov      eax, edi
+       sub      eax, esi
+       sar      eax, 1
+       add      eax, esi
+       mov      rcx, rbp
+       ; gcrRegs +[rcx]
+       mov      edx, dword ptr [(reloc)]      ; static handle
+       sarx     edx, eax, edx
+       cmp      edx, dword ptr [rcx+0x08]
+       jae      SHORT G_M22803_IG11
+       mov      rcx, gword ptr [rcx+8*rdx+0x10]
+       mov      edx, eax
+       and      edx, dword ptr [(reloc)]      ; static handle
+       cmp      edx, dword ptr [rcx+0x08]
+       jae      SHORT G_M22803_IG11
+       lea      rcx, bword ptr [rcx+2*rdx+0x10]
+       ; gcrRegs -[rcx]
+       ; byrRegs +[rcx]
+       movsx    rcx, word  ptr [rcx]
+       ; byrRegs -[rcx]
+       movsx    rdx, bx
+       sub      ecx, edx
+       je       SHORT G_M22803_IG10
+       test     ecx, ecx
+       jge      SHORT G_M22803_IG06
+						;; size=66 bbWeight=4 PerfScore 100.00
+G_M22803_IG05:        ; bbWeight=2, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref, isz
+       lea      esi, [rax+0x01]
+       jmp      SHORT G_M22803_IG07
+						;; size=5 bbWeight=2 PerfScore 5.00
+G_M22803_IG06:        ; bbWeight=2, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
+       lea      edi, [rax-0x01]
+						;; size=3 bbWeight=2 PerfScore 1.00
+G_M22803_IG07:        ; bbWeight=4, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref, isz
+       cmp      esi, edi
+       jle      SHORT G_M22803_IG04
+						;; size=4 bbWeight=4 PerfScore 5.00
+G_M22803_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rbp]
+       mov      eax, esi
        not      eax
 						;; size=4 bbWeight=0.50 PerfScore 0.25
-G_M22803_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+G_M22803_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=0.50 PerfScore 2.12
-G_M22803_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      eax, r14d
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M22803_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=9 bbWeight=0.50 PerfScore 1.62
+G_M22803_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=0.50 PerfScore 2.12
+						;; size=9 bbWeight=0.50 PerfScore 1.62
 G_M22803_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 174, prolog size 18, PerfScore 137.88, instruction count 63, allocated bytes for code 174 (MethodHash=0626a6ec) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[short]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short],int,int,short):int (FullOpts)
+; Total bytes of code 151, prolog size 11, PerfScore 123.25, instruction count 56, allocated bytes for code 151 (MethodHash=0626a6ec) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[short]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short],int,int,short):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -150,15 +144,13 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 5
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+17.27%</span>) : 9057.dasm - Microsoft.FSharp.Collections.Array3DModule:Create[long](int,int,int,long):long[,,] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,128 +7,154 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T14] (  4,  4   )     int  ->  rbp         single-def
-;  V01 arg1         [V01,T13] (  4,  7   )     int  ->  rdi         single-def
-;  V02 arg2         [V02,T12] (  4, 19   )     int  ->  rsi         single-def
-;  V03 arg3         [V03,T10] (  3, 66   )    long  ->  rbx         single-def
-;  V04 loc0         [V04,T00] (  9,450   )     ref  ->  rax         class-hnd single-def <long[,,]>
-;  V05 loc1         [V05,T15] (  3,  6   )     int  ->  rbp         single-def
-;  V06 loc2         [V06,T09] (  5, 77   )     int  ->  rcx        
-;  V07 loc3         [V07,T11] (  3, 24   )     int  ->   r8        
+;  V00 arg0         [V00,T17] (  4,  4   )     int  ->  rsi         single-def
+;  V01 arg1         [V01,T19] (  4,  3.50)     int  ->  rbp         single-def
+;  V02 arg2         [V02,T18] (  4,  4   )     int  ->  [rsp+0x80]  single-def
+;  V03 arg3         [V03,T08] (  3, 66   )    long  ->  rbx         single-def
+;  V04 loc0         [V04,T03] (  9,330   )     ref  ->  rax         class-hnd single-def <long[,,]>
+;  V05 loc1         [V05,T22] (  3,  2.50)     int  ->  rsi         single-def
+;  V06 loc2         [V06,T13] (  5, 17   )     int  ->  rcx        
+;  V07 loc3         [V07,T16] (  3,  9   )     int  ->   r8        
 ;  V08 loc4         [V08,T07] (  5,116   )     int  ->  rdx        
-;  V09 loc5         [V09,T08] (  3, 96   )     int  ->   r9        
-;  V10 loc6         [V10,T04] (  5,272   )     int  ->  r10        
+;  V09 loc5         [V09,T12] (  3, 36   )     int  ->  r11        
+;  V10 loc6         [V10,T04] (  5,272   )     int  ->   r9        
 ;  V11 OutArgs      [V11    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V12 tmp1         [V12,T01] (  3,384   )     int  ->  r11         "MD array shared temp"
-;  V13 tmp2         [V13,T02] (  3,384   )     int  ->  r15         "MD array shared temp"
-;  V14 tmp3         [V14,T03] (  3,384   )     int  ->  r15         "MD array shared temp"
-;  V15 cse0         [V15,T05] (  3,192   )     int  ->  r14         "CSE - aggressive"
-;  V16 cse1         [V16,T06] (  3,192   )     int  ->  r14         "CSE - aggressive"
+;  V12 tmp1         [V12,T00] (  3,384   )     int  ->  r13         "MD array shared temp"
+;  V13 tmp2         [V13,T01] (  3,384   )     int  ->  rdi         "MD array shared temp"
+;  V14 tmp3         [V14,T02] (  3,384   )     int  ->  r12         "MD array shared temp"
+;  V15 cse0         [V15,T14] (  2, 17   )     int  ->  r10         hoist "CSE - aggressive"
+;  V16 cse1         [V16,T20] (  2,  4.50)     int  ->  rbp         hoist "CSE - aggressive"
+;  V17 cse2         [V17,T09] (  2, 68   )     int  ->  r14         hoist "CSE - aggressive"
+;  V18 cse3         [V18,T10] (  2, 68   )     int  ->  r15         hoist "CSE - aggressive"
+;  V19 cse4         [V19,T11] (  2, 68   )     int  ->  r11         hoist "CSE - aggressive"
+;  V20 cse5         [V20,T05] (  3,192   )     int  ->  r12         "CSE - aggressive"
+;  V21 cse6         [V21,T06] (  3,192   )     int  ->  r13         "CSE - aggressive"
+;  V22 cse7         [V22,T15] (  2, 17   )     int  ->   r8         hoist "CSE - aggressive"
+;  V23 cse8         [V23,T21] (  2,  4.50)     int  ->  rsi         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
 G_M7423_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
        sub      rsp, 40
-       mov      ebp, ecx
-       mov      edi, edx
-       mov      esi, r8d
+       mov      esi, ecx
+       mov      ebp, edx
+       mov      edi, r8d
        mov      rbx, r9
-						;; size=22 bbWeight=1 PerfScore 7.25
+						;; size=26 bbWeight=1 PerfScore 9.25
 G_M7423_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      ecx, ebp
-       mov      edx, edi
-       mov      r8d, esi
+       mov      ecx, esi
+       mov      edx, ebp
+       mov      r8d, edi
        call     [<unknown method>]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
        xor      ecx, ecx
-       sub      ebp, 1
-       jo       G_M7423_IG10
-       test     ebp, ebp
-       jl       G_M7423_IG08
+       sub      esi, 1
+       jo       G_M7423_IG14
+       test     esi, esi
+       jl       G_M7423_IG11
 						;; size=32 bbWeight=1 PerfScore 6.50
-G_M7423_IG03:        ; bbWeight=4, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
+G_M7423_IG03:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       sub      ebp, 1
+       jo       G_M7423_IG14
+       inc      esi
+						;; size=11 bbWeight=0.50 PerfScore 0.75
+G_M7423_IG04:        ; bbWeight=4, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
        xor      edx, edx
-       mov      r8d, edi
-       sub      r8d, 1
-       jo       G_M7423_IG10
+       mov      r8d, ebp
        test     r8d, r8d
-       jl       SHORT G_M7423_IG07
-						;; size=20 bbWeight=4 PerfScore 12.00
-G_M7423_IG04:        ; bbWeight=16, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
-       xor      r10d, r10d
-       mov      r9d, esi
-       sub      r9d, 1
-       jo       G_M7423_IG10
-       test     r9d, r9d
-       jl       SHORT G_M7423_IG06
-						;; size=21 bbWeight=16 PerfScore 48.00
-G_M7423_IG05:        ; bbWeight=64, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
-       mov      r11d, ecx
-       sub      r11d, dword ptr [rax+0x1C]
-       cmp      r11d, dword ptr [rax+0x10]
-       jae      SHORT G_M7423_IG09
-       mov      r14d, dword ptr [rax+0x14]
-       imul     r11d, r14d
-       mov      r15d, edx
-       sub      r15d, dword ptr [rax+0x20]
-       cmp      r15d, r14d
-       jae      SHORT G_M7423_IG09
-       add      r11d, r15d
-       mov      r14d, dword ptr [rax+0x18]
-       imul     r11d, r14d
-       mov      r15d, r10d
-       sub      r15d, dword ptr [rax+0x24]
-       cmp      r15d, r14d
-       jae      SHORT G_M7423_IG09
-       add      r11d, r15d
-       mov      qword ptr [rax+8*r11+0x28], rbx
-       inc      r10d
-       lea      r11d, [r9+0x01]
-       cmp      r10d, r11d
-       jne      SHORT G_M7423_IG05
-						;; size=76 bbWeight=64 PerfScore 1776.00
+       jl       G_M7423_IG12
+						;; size=14 bbWeight=4 PerfScore 7.00
+G_M7423_IG05:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       mov      dword ptr [rsp+0x80], edi
+       mov      r10d, edi
+       sub      r10d, 1
+       jo       G_M7423_IG14
+       inc      r8d
+						;; size=23 bbWeight=1 PerfScore 2.75
 G_M7423_IG06:        ; bbWeight=16, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
-       inc      edx
-       lea      r10d, [r8+0x01]
-       cmp      edx, r10d
-       jne      SHORT G_M7423_IG04
-						;; size=11 bbWeight=16 PerfScore 32.00
+       xor      r9d, r9d
+       mov      r11d, r10d
+       test     r11d, r11d
+       jl       SHORT G_M7423_IG09
+						;; size=11 bbWeight=16 PerfScore 28.00
 G_M7423_IG07:        ; bbWeight=4, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       mov      r14d, ecx
+       sub      r14d, dword ptr [rax+0x1C]
+       mov      r15d, dword ptr [rax+0x10]
+       inc      r11d
+						;; size=14 bbWeight=4 PerfScore 22.00
+G_M7423_IG08:        ; bbWeight=64, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
+       mov      r13d, r14d
+       cmp      r13d, r15d
+       jae      SHORT G_M7423_IG13
+       mov      r12d, dword ptr [rax+0x14]
+       imul     r13d, r12d
+       mov      edi, edx
+       sub      edi, dword ptr [rax+0x20]
+       cmp      edi, r12d
+       jae      SHORT G_M7423_IG13
+       add      edi, r13d
+       mov      r13d, dword ptr [rax+0x18]
+       imul     edi, r13d
+       mov      r12d, r9d
+       sub      r12d, dword ptr [rax+0x24]
+       cmp      r12d, r13d
+       jae      SHORT G_M7423_IG13
+       add      edi, r12d
+       mov      qword ptr [rax+8*rdi+0x28], rbx
+       inc      r9d
+       cmp      r9d, r11d
+       jne      SHORT G_M7423_IG08
+						;; size=65 bbWeight=64 PerfScore 1376.00
+G_M7423_IG09:        ; bbWeight=16, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
+       inc      edx
+       cmp      edx, r8d
+       jne      SHORT G_M7423_IG06
+						;; size=7 bbWeight=16 PerfScore 24.00
+G_M7423_IG10:        ; bbWeight=4, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
        inc      ecx
-       lea      edx, [rbp+0x01]
-       cmp      ecx, edx
-       jne      G_M7423_IG03
-						;; size=13 bbWeight=4 PerfScore 8.00
-G_M7423_IG08:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       cmp      ecx, esi
+       mov      edi, dword ptr [rsp+0x80]
+       jne      G_M7423_IG04
+						;; size=17 bbWeight=4 PerfScore 10.00
+G_M7423_IG11:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
        add      rsp, 40
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
-G_M7423_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=17 bbWeight=1 PerfScore 5.25
+G_M7423_IG12:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, gcvars, byref, isz
+       mov      dword ptr [rsp+0x80], edi
+       jmp      SHORT G_M7423_IG10
+						;; size=9 bbWeight=2 PerfScore 6.00
+G_M7423_IG13:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M7423_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M7423_IG14:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_OVERFLOW
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 220, prolog size 22, PerfScore 1894.00, instruction count 75, allocated bytes for code 220 (MethodHash=f758e300) for method Microsoft.FSharp.Collections.Array3DModule:Create[long](int,int,int,long):long[,,] (FullOpts)
+; Total bytes of code 258, prolog size 26, PerfScore 1497.50, instruction count 86, allocated bytes for code 258 (MethodHash=f758e300) for method Microsoft.FSharp.Collections.Array3DModule:Create[long](int,int,int,long):long[,,] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -136,15 +162,17 @@ Unwind Info:
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
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
...

```


</div></details>

<details>
<summary><span style="color:red">+33</span> (<span style="color:red">+18.13%</span>) : 259264.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[ubyte,System.Nullable`1[int]]:CopyToEntries(System.Collections.DictionaryEntry[],int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,25 +8,27 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T12] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentDictionary`2[ubyte,System.Nullable`1[int]]>
+;  V00 this         [V00,T14] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentDictionary`2[ubyte,System.Nullable`1[int]]>
 ;  V01 arg1         [V01,T05] (  4, 34   )     ref  ->  rsi         class-hnd single-def <System.Collections.DictionaryEntry[]>
 ;  V02 arg2         [V02,T03] (  6, 66   )     int  ->  rbx        
-;  V03 loc0         [V03,T10] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
+;  V03 loc0         [V03,T12] (  3,  6   )     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
 ;  V04 loc1         [V04,T08] (  5, 17   )     int  ->  rbp        
 ;* V05 loc2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    <System.Collections.Concurrent.ConcurrentDictionary`2+VolatileNode[ubyte,System.Nullable`1[int]]>
-;  V06 loc3         [V06,T02] (  7, 88   )     ref  ->  r15         class-hnd <<unknown class>>
+;  V06 loc3         [V06,T02] (  7, 88   )     ref  ->  r12         class-hnd <<unknown class>>
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T00] (  3, 96   )     ref  ->  r13         class-hnd exact "Single-def Box Helper" <System.Byte>
+;  V08 tmp1         [V08,T00] (  3, 96   )     ref  ->  [rsp+0x30]  class-hnd exact spill-single-def "Single-def Box Helper" <System.Byte>
 ;* V09 tmp2         [V09    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.DictionaryEntry>
 ;* V10 tmp3         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Byte>
-;  V11 tmp4         [V11,T04] (  2, 64   )     ref  ->  r12         class-hnd exact "Inlining Arg" <<unknown class>>
-;  V12 tmp5         [V12,T09] (  2,  8   )     ref  ->  r15         "field V05._node (fldOffset=0x0)" P-INDEP
+;  V11 tmp4         [V11,T04] (  2, 64   )     ref  ->  rax         class-hnd exact "Inlining Arg" <<unknown class>>
+;  V12 tmp5         [V12,T11] (  2,  8   )     ref  ->  r12         "field V05._node (fldOffset=0x0)" P-INDEP
 ;  V13 tmp6         [V13,T06] (  2, 32   )     ref  ->  rdx         "field V09._key (fldOffset=0x0)" P-INDEP
-;  V14 tmp7         [V14,T07] (  2, 32   )     ref  ->  r12         "field V09._value (fldOffset=0x8)" P-INDEP
-;  V15 tmp8         [V15,T01] (  3, 96   )   byref  ->  r13         "BlockOp address local"
-;  V16 cse0         [V16,T11] (  3,  6   )     int  ->  r14         "CSE - aggressive"
+;  V14 tmp7         [V14,T07] (  2, 32   )     ref  ->  [rsp+0x28]  spill-single-def "field V09._value (fldOffset=0x8)" P-INDEP
+;  V15 tmp8         [V15,T01] (  3, 96   )   byref  ->  [rsp+0x20]  spill-single-def "BlockOp address local"
+;  V16 cse0         [V16,T09] (  2, 16.50)    long  ->  r15         hoist "CSE - aggressive"
+;  V17 cse1         [V17,T10] (  2, 16.50)    long  ->  r13         hoist "CSE - aggressive"
+;  V18 cse2         [V18,T13] (  3,  6   )     int  ->  r14         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M49611_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -37,12 +39,12 @@ G_M49611_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
        mov      rsi, rdx
        ; gcrRegs +[rsi]
        mov      ebx, r8d
 						;; size=22 bbWeight=1 PerfScore 8.75
-G_M49611_IG02:        ; bbWeight=1, gcrefRegs=0042 {rcx rsi}, byrefRegs=0000 {}, byref, isz
+G_M49611_IG02:        ; bbWeight=1, gcrefRegs=0042 {rcx rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
        mov      rcx, gword ptr [rcx+0x08]
        mov      rdi, gword ptr [rcx+0x10]
@@ -50,68 +52,79 @@ G_M49611_IG02:        ; bbWeight=1, gcrefRegs=0042 {rcx rsi}, byrefRegs=0000 {},
        xor      ebp, ebp
        mov      r14d, dword ptr [rdi+0x08]
        test     r14d, r14d
-       jle      SHORT G_M49611_IG06
-						;; size=19 bbWeight=1 PerfScore 7.50
-G_M49611_IG03:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref, isz
+       jle      G_M49611_IG07
+						;; size=23 bbWeight=1 PerfScore 7.50
+G_M49611_IG03:        ; bbWeight=0.50, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
+       mov      r15, 0xD1FFAB1E      ; System.Byte
+       mov      r13, 0xD1FFAB1E      ; System.Nullable`1[int]
+						;; size=20 bbWeight=0.50 PerfScore 0.25
+G_M49611_IG04:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref, isz
        mov      ecx, ebp
-       mov      r15, gword ptr [rdi+8*rcx+0x10]
-       ; gcrRegs +[r15]
-       test     r15, r15
-       je       SHORT G_M49611_IG05
+       mov      r12, gword ptr [rdi+8*rcx+0x10]
+       ; gcrRegs +[r12]
+       test     r12, r12
+       je       SHORT G_M49611_IG06
 						;; size=12 bbWeight=4 PerfScore 14.00
-G_M49611_IG04:        ; bbWeight=16, gcrefRegs=80C0 {rsi rdi r15}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; System.Byte
+G_M49611_IG05:        ; bbWeight=16, gcrefRegs=10C0 {rsi rdi r12}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, r15
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      r13, rax
-       ; gcrRegs +[r13]
-       movzx    rdx, byte  ptr [r15+0x14]
-       mov      byte  ptr [r13+0x08], dl
-       lea      rdx, bword ptr [r15+0x18]
+       mov      rdx, rax
+       ; gcrRegs +[rdx]
+       mov      gword ptr [rsp+0x30], rdx
+       ; GC ptr vars +{V08}
+       movzx    rcx, byte  ptr [r12+0x14]
+       mov      byte  ptr [rdx+0x08], cl
+       lea      rdx, bword ptr [r12+0x18]
+       ; gcrRegs -[rdx]
        ; byrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; System.Nullable`1[int]
+       mov      rcx, r13
        call     CORINFO_HELP_BOX_NULLABLE
        ; byrRegs -[rdx]
        ; gcr arg pop 0
-       mov      r12, rax
-       ; gcrRegs +[r12]
-       mov      rdx, r13
+       mov      rdx, gword ptr [rsp+0x30]
        ; gcrRegs +[rdx]
+       mov      gword ptr [rsp+0x28], rax
+       ; GC ptr vars +{V14}
        cmp      ebx, dword ptr [rsi+0x08]
-       jae      SHORT G_M49611_IG07
+       jae      SHORT G_M49611_IG08
        mov      ecx, ebx
        shl      rcx, 4
-       lea      r13, bword ptr [rsi+rcx+0x10]
-       ; gcrRegs -[r13]
-       ; byrRegs +[r13]
-       mov      rcx, r13
+       lea      r8, bword ptr [rsi+rcx+0x10]
+       ; byrRegs +[r8]
+       mov      rcx, r8
        ; byrRegs +[rcx]
+       mov      bword ptr [rsp+0x20], rcx
+       ; GC ptr vars +{V15}
+       ; GC ptr vars -{V08}
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rax rdx]
-       ; byrRegs -[rcx]
-       lea      rcx, bword ptr [r13+0x08]
+       ; byrRegs -[rcx r8]
+       mov      rcx, bword ptr [rsp+0x20]
        ; byrRegs +[rcx]
-       mov      rdx, r12
+       lea      rcx, bword ptr [rcx+0x08]
+       mov      rdx, gword ptr [rsp+0x28]
        ; gcrRegs +[rdx]
+       ; GC ptr vars -{V14 V15}
        call     CORINFO_HELP_ASSIGN_REF
-       ; gcrRegs -[rdx r12]
-       ; byrRegs -[rcx r13]
+       ; gcrRegs -[rdx]
+       ; byrRegs -[rcx]
        inc      ebx
-       mov      r15, gword ptr [r15+0x08]
-       test     r15, r15
-       jne      SHORT G_M49611_IG04
-						;; size=99 bbWeight=16 PerfScore 304.00
-G_M49611_IG05:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[r15]
+       mov      r12, gword ptr [r12+0x08]
+       test     r12, r12
+       jne      SHORT G_M49611_IG05
+						;; size=108 bbWeight=16 PerfScore 388.00
+G_M49611_IG06:        ; bbWeight=4, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[r12]
        inc      ebp
        cmp      r14d, ebp
-       jg       SHORT G_M49611_IG03
+       jg       SHORT G_M49611_IG04
 						;; size=7 bbWeight=4 PerfScore 6.00
-G_M49611_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+G_M49611_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rsi rdi]
-       add      rsp, 40
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
@@ -122,13 +135,13 @@ G_M49611_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        pop      r15
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M49611_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M49611_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 182, prolog size 22, PerfScore 345.50, instruction count 60, allocated bytes for code 182 (MethodHash=5e713e34) for method System.Collections.Concurrent.ConcurrentDictionary`2[ubyte,System.Nullable`1[int]]:CopyToEntries(System.Collections.DictionaryEntry[],int):this (FullOpts)
+; Total bytes of code 215, prolog size 22, PerfScore 429.75, instruction count 65, allocated bytes for code 215 (MethodHash=5e713e34) for method System.Collections.Concurrent.ConcurrentDictionary`2[ubyte,System.Nullable`1[int]]:CopyToEntries(System.Collections.DictionaryEntry[],int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -141,7 +154,7 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
     CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+19</span> (<span style="color:red">+18.45%</span>) : 138688.dasm - System.Xml.XPath.XPathNavigator:get_XmlLang():System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,18 +7,24 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Xml.XPath.XPathNavigator>
-;  V01 loc0         [V01,T00] (  5, 21.50)     ref  ->  rbx         class-hnd single-def <System.Xml.XPath.XPathNavigator>
+;  V00 this         [V00,T05] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Xml.XPath.XPathNavigator>
+;  V01 loc0         [V01,T00] (  5, 14.50)     ref  ->  rbx         class-hnd single-def <System.Xml.XPath.XPathNavigator>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 cse0         [V03,T01] (  4, 20.50)    long  ->  rsi         "CSE - aggressive"
+;  V03 cse0         [V03,T03] (  2,  9   )    long  ->  r14         hoist "CSE - aggressive"
+;  V04 cse1         [V04,T04] (  4,  6.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T01] (  2,  9   )     ref  ->  rsi         hoist "CSE - aggressive"
+;  V06 cse3         [V06,T02] (  2,  9   )     ref  ->  rdi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M13184_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     r14
+       push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 40
-						;; size=6 bbWeight=1 PerfScore 2.25
+       sub      rsp, 32
+						;; size=10 bbWeight=1 PerfScore 5.25
 G_M13184_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
        mov      rax, qword ptr [rcx]
@@ -28,27 +34,31 @@ G_M13184_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcr arg pop 0
        mov      rbx, rax
        ; gcrRegs +[rbx]
-						;; size=12 bbWeight=1 PerfScore 7.25
-G_M13184_IG03:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rsi, 0xD1FFAB1E
+       ; gcrRegs +[rsi]
+       mov      rdi, 0xD1FFAB1E
+       ; gcrRegs +[rdi]
+       mov      rbp, qword ptr [rbx]
+       mov      r14, qword ptr [rbp+0x68]
+						;; size=39 bbWeight=1 PerfScore 11.75
+G_M13184_IG03:        ; bbWeight=8, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
-       mov      rdx, 0xD1FFAB1E
+       mov      rdx, rsi
        ; gcrRegs +[rdx]
-       mov      r8, 0xD1FFAB1E
+       mov      r8, rdi
        ; gcrRegs +[r8]
-       mov      rsi, qword ptr [rbx]
-       mov      rax, qword ptr [rsi+0x68]
-       call     [rax+0x30]<unknown method>
+       call     [r14+0x30]<unknown method>
        ; gcrRegs -[rcx rdx r8]
        ; gcr arg pop 0
        test     eax, eax
        jne      SHORT G_M13184_IG07
-						;; size=37 bbWeight=8 PerfScore 72.00
-G_M13184_IG04:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+						;; size=17 bbWeight=8 PerfScore 40.00
+G_M13184_IG04:        ; bbWeight=4, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, rbx
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rsi+0x78]
+       mov      rax, qword ptr [rbp+0x78]
        call     [rax+0x08]<unknown method>
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
@@ -56,30 +66,36 @@ G_M13184_IG04:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        jne      SHORT G_M13184_IG03
 						;; size=14 bbWeight=4 PerfScore 26.00
 G_M13184_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx]
+       ; gcrRegs -[rbx rsi rdi]
        mov      rax, 0xD1FFAB1E
        ; gcrRegs +[rax]
 						;; size=10 bbWeight=0.50 PerfScore 0.12
 G_M13184_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
+       pop      rbp
        pop      rsi
+       pop      rdi
+       pop      r14
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M13184_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax] +[rbx]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rsi+0x48]
+       mov      rax, qword ptr [rbp+0x48]
 						;; size=7 bbWeight=0.50 PerfScore 1.12
 G_M13184_IG08:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
+       pop      rbp
        pop      rsi
+       pop      rdi
+       pop      r14
        tail.jmp [rax+0x30]<unknown method>
-						;; size=10 bbWeight=0.50 PerfScore 1.62
+						;; size=14 bbWeight=0.50 PerfScore 2.38
 
-; Total bytes of code 103, prolog size 6, PerfScore 111.50, instruction count 31, allocated bytes for code 103 (MethodHash=4386cc7f) for method System.Xml.XPath.XPathNavigator:get_XmlLang():System.String:this (FullOpts)
+; Total bytes of code 122, prolog size 10, PerfScore 88.50, instruction count 42, allocated bytes for code 122 (MethodHash=4386cc7f) for method System.Xml.XPath.XPathNavigator:get_XmlLang():System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -87,11 +103,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-38</span> (<span style="color:green">-21.11%</span>) : 83966.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T02] (  3,  3   )   byref  ->  rcx         this single-def
-;  V01 TypeCtx      [V01,T00] (  7,  4.44)    long  ->  rbx         single-def
-;  V02 arg1         [V02,T05] (  3,  2.10)     int  ->  rsi         single-def
+;  V01 TypeCtx      [V01,T00] (  5,  4.20)    long  ->  rdx         single-def
+;  V02 arg1         [V02,T04] (  3,  2.10)     int  ->  rbx         single-def
 ;  V03 loc0         [V03    ] (  4,  3.20)  struct (16) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1+Enumerator[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
@@ -22,19 +22,18 @@
 ;* V10 tmp6         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon>
 ;  V11 tmp7         [V11    ] (  3,  2.20)     int  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V03._index (fldOffset=0x0)" P-DEP
 ;  V12 tmp8         [V12    ] (  3,  2.20)     ref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V03._list (fldOffset=0x8)" P-DEP
-;* V13 tmp9         [V13,T07] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x0)" P-INDEP
-;  V14 tmp10        [V14,T06] (  2,  2   )     ref  ->  rcx         single-def "field V07._list (fldOffset=0x8)" P-INDEP
+;* V13 tmp9         [V13,T08] (  0,  0   )     int  ->  zero-ref    single-def "field V07._index (fldOffset=0x0)" P-INDEP
+;  V14 tmp10        [V14,T07] (  2,  2   )     ref  ->  rcx         single-def "field V07._list (fldOffset=0x8)" P-INDEP
 ;* V15 tmp11        [V15    ] (  0,  0   )     ref  ->  zero-ref    "field V09._node (fldOffset=0x0)" P-INDEP
-;  V16 tmp12        [V16,T04] (  2,  4.40)    long  ->  rdx         "argument with side effect"
-;  V17 tmp13        [V17,T10] (  2,  0.40)    long  ->  rdx         "argument with side effect"
-;  V18 rat0         [V18,T09] (  3,  0.40)    long  ->  rdx         "runtime lookup"
-;  V19 rat1         [V19,T08] (  3,  0.57)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
-;  V20 rat2         [V20,T03] (  3,  4.40)    long  ->  rdx         "runtime lookup"
-;  V21 rat3         [V21,T01] (  3,  6.17)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V16 tmp12        [V16,T03] (  2,  4.40)    long  ->  rdx         "argument with side effect"
+;  V17 tmp13        [V17,T09] (  2,  0.40)    long  ->  rdx         "argument with side effect"
+;  V18 cse0         [V18,T06] (  3,  2.20)    long  ->  rsi         hoist "CSE - aggressive"
+;  V19 rat0         [V19,T05] (  3,  4   )    long  ->  rsi         "runtime lookup"
+;  V20 rat1         [V20,T01] (  3,  5.60)    long  ->  rsi         "fgMakeTemp is creating a new local variable"
 ;
 ; Lcl frame size = 56
 
-G_M65451_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M65451_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rsi
        push     rbx
        sub      rsp, 56
@@ -42,90 +41,71 @@ G_M65451_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        mov      qword ptr [rsp+0x20], rax
        mov      qword ptr [rsp+0x28], rax
        mov      qword ptr [rsp+0x30], rdx
-       mov      rbx, rdx
-       mov      esi, r8d
-						;; size=29 bbWeight=1 PerfScore 6.00
-G_M65451_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
+       mov      ebx, r8d
+						;; size=26 bbWeight=1 PerfScore 5.75
+G_M65451_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        ; byrRegs +[rcx]
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
        mov      dword ptr [rsp+0x20], -1
        mov      gword ptr [rsp+0x28], rcx
-						;; size=16 bbWeight=1 PerfScore 4.00
-G_M65451_IG03:        ; bbWeight=1.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, qword ptr [rdx+0x38]
        ; gcrRegs -[rcx]
-       mov      rcx, qword ptr [rbx+0x38]
        mov      rcx, qword ptr [rcx]
-       mov      rdx, qword ptr [rcx+0x10]
-       test     rdx, rdx
-       je       SHORT G_M65451_IG09
-						;; size=16 bbWeight=1.10 PerfScore 7.98
-G_M65451_IG04:        ; bbWeight=0.88, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       jmp      SHORT G_M65451_IG10
-						;; size=2 bbWeight=0.88 PerfScore 1.76
-G_M65451_IG05:        ; bbWeight=0.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, qword ptr [rbx+0x38]
-       mov      rcx, qword ptr [rcx]
-       mov      rdx, qword ptr [rcx+0x10]
-       test     rdx, rdx
-       je       SHORT G_M65451_IG07
-						;; size=16 bbWeight=0.10 PerfScore 0.73
-G_M65451_IG06:        ; bbWeight=0.08, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       jmp      SHORT G_M65451_IG08
-						;; size=2 bbWeight=0.08 PerfScore 0.16
-G_M65451_IG07:        ; bbWeight=0.02, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rcx, rbx
+       mov      rsi, qword ptr [rcx+0x10]
+       test     rsi, rsi
+       je       SHORT G_M65451_IG04
+						;; size=32 bbWeight=1 PerfScore 11.25
+G_M65451_IG03:        ; bbWeight=0.80, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M65451_IG05
+						;; size=2 bbWeight=0.80 PerfScore 1.60
+G_M65451_IG04:        ; bbWeight=0.20, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, rdx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        ; gcr arg pop 0
-       mov      rdx, rax
-						;; size=21 bbWeight=0.02 PerfScore 0.04
-G_M65451_IG08:        ; bbWeight=0.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rsi, rax
+						;; size=21 bbWeight=0.20 PerfScore 0.35
+G_M65451_IG05:        ; bbWeight=1.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rdx, rsi
+       lea      rcx, [rsp+0x20]
+       call     [Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1+Enumerator[System.__Canon]:MoveNext():ubyte:this]
+       ; gcr arg pop 0
+       test     eax, eax
+       jne      SHORT G_M65451_IG08
+						;; size=18 bbWeight=1.10 PerfScore 5.51
+G_M65451_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       xor      eax, eax
+						;; size=2 bbWeight=1 PerfScore 0.25
+G_M65451_IG07:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 56
+       pop      rbx
+       pop      rsi
+       ret      
+						;; size=7 bbWeight=1 PerfScore 2.25
+G_M65451_IG08:        ; bbWeight=0.10, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       mov      rdx, rsi
        lea      rcx, [rsp+0x20]
        call     [Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1+Enumerator[System.__Canon]:get_Current():System.__Canon:this]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
        movzx    rax, word  ptr [rax+0x0C]
        ; gcrRegs -[rax]
-       cmp      eax, esi
-       je       SHORT G_M65451_IG13
-       jmp      SHORT G_M65451_IG03
-						;; size=21 bbWeight=0.10 PerfScore 0.88
-G_M65451_IG09:        ; bbWeight=0.22, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rcx, rbx
-       mov      rdx, 0xD1FFAB1E      ; global ptr
-       call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       ; gcr arg pop 0
-       mov      rdx, rax
-						;; size=21 bbWeight=0.22 PerfScore 0.39
-G_M65451_IG10:        ; bbWeight=1.10, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       lea      rcx, [rsp+0x20]
-       call     [Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1+Enumerator[System.__Canon]:MoveNext():ubyte:this]
-       ; gcr arg pop 0
-       test     eax, eax
+       cmp      eax, ebx
        jne      SHORT G_M65451_IG05
-						;; size=15 bbWeight=1.10 PerfScore 5.23
-G_M65451_IG11:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=1 PerfScore 0.25
-G_M65451_IG12:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 56
-       pop      rbx
-       pop      rsi
-       ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
-G_M65451_IG13:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=22 bbWeight=0.10 PerfScore 0.71
+G_M65451_IG09:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, 1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M65451_IG14:        ; bbWeight=0, epilog, nogc, extend
+G_M65451_IG10:        ; bbWeight=0, epilog, nogc, extend
        add      rsp, 56
        pop      rbx
        pop      rsi
        ret      
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 180, prolog size 23, PerfScore 29.67, instruction count 52, allocated bytes for code 180 (MethodHash=b0890054) for method Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (Tier1)
+; Total bytes of code 142, prolog size 23, PerfScore 27.66, instruction count 42, allocated bytes for code 142 (MethodHash=b0890054) for method Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-20.90%</span>) : 191521.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]>
-;  V01 loc0         [V01    ] (  6,  6   )  struct (16) [rsp+0x78]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V02 loc1         [V02    ] (  2,  2   )  struct (80) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
+;  V01 loc0         [V01    ] (  6,  6   )  struct (16) [rsp+0x70]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V02 loc1         [V02    ] (  2,  2   )  struct (80) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
 ;* V03 loc2         [V03    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
@@ -24,105 +24,91 @@
 ;  V12 tmp8         [V12,T07] (  2,  4   )     int  ->  rcx         "impAppendStmt"
 ;  V13 tmp9         [V13,T05] (  2,  4   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;* V14 tmp10        [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V15 tmp11        [V15    ] (  2,  2   )     ref  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V01._builder (fldOffset=0x0)" P-DEP
-;  V16 tmp12        [V16    ] (  5,  5   )     int  ->  [rsp+0x80]  do-not-enreg[X] addr-exposed "field V01._index (fldOffset=0x8)" P-DEP
+;  V15 tmp11        [V15    ] (  2,  2   )     ref  ->  [rsp+0x70]  do-not-enreg[X] addr-exposed "field V01._builder (fldOffset=0x0)" P-DEP
+;  V16 tmp12        [V16    ] (  5,  5   )     int  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V01._index (fldOffset=0x8)" P-DEP
 ;* V17 tmp13        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    "V03.[004..005)"
-;* V18 cse0         [V18,T14] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
+;* V18 cse0         [V18,T14] (  0,  0   )    long  ->  zero-ref    hoist "CSE - aggressive"
 ;  V19 cse1         [V19,T09] (  3,  3   )     ref  ->  rdx         "CSE - aggressive"
-;  V20 cse2         [V20,T08] (  2,  2   )    long  ->  rcx         "CSE - aggressive"
-;* V21 rat0         [V21,T11] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
-;* V22 rat1         [V22,T01] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
-;  V23 rat2         [V23,T03] (  2,  4   )    long  ->  rcx         "Spilling to split statement for tree"
-;* V24 rat3         [V24,T04] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
-;  V25 rat4         [V25,T02] (  2,  4   )    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V20 cse2         [V20,T08] (  1,  1   )    long  ->  rsi         "CSE - aggressive"
+;* V21 rat0         [V21,T03] (  0,  0   )    long  ->  zero-ref    "Spilling to split statement for tree"
+;* V22 rat1         [V22,T04] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;* V23 rat2         [V23,T01] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
+;* V24 rat3         [V24,T11] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;* V25 rat4         [V25,T02] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 144
+; Lcl frame size = 136
 
 G_M864_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rsi
        push     rbx
-       sub      rsp, 144
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 136
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       vmovdqu  ymmword ptr [rsp+0x50], ymm4
-       vmovdqa  xmmword ptr [rsp+0x70], xmm4
-       mov      qword ptr [rsp+0x80], rax
-       mov      qword ptr [rsp+0x88], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqu  ymmword ptr [rsp+0x40], ymm4
+       vmovdqu  ymmword ptr [rsp+0x60], ymm4
+       mov      qword ptr [rsp+0x80], rcx
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=56 bbWeight=1 PerfScore 11.08
+						;; size=42 bbWeight=1 PerfScore 9.83
 G_M864_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rcx, gword ptr [rbx+0x08]
        ; gcrRegs +[rcx]
-       lea      rdx, [rsp+0x78]
+       lea      rdx, [rsp+0x70]
        cmp      dword ptr [rcx], ecx
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:GetEnumerator():Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-						;; size=17 bbWeight=1 PerfScore 8.50
+       mov      rsi, qword ptr [rbx]
+						;; size=20 bbWeight=1 PerfScore 10.50
 G_M864_IG03:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, qword ptr [rbx]
-       mov      rcx, qword ptr [rcx+0x38]
-       mov      rcx, qword ptr [rcx]
-       mov      rcx, qword ptr [rcx+0x40]
-       test     rcx, rcx
-       je       SHORT G_M864_IG08
-						;; size=19 bbWeight=1 PerfScore 9.25
-G_M864_IG04:        ; bbWeight=3.12, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       jmp      SHORT G_M864_IG08
-						;; size=2 bbWeight=3.12 PerfScore 6.25
-G_M864_IG05:        ; bbWeight=1, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, dword ptr [rsp+0x78]
+       inc      ecx
+       mov      dword ptr [rsp+0x78], ecx
+       mov      ecx, dword ptr [rsp+0x78]
+       mov      rdx, gword ptr [rsp+0x70]
        ; gcrRegs +[rdx]
-       mov      r8d, dword ptr [rsp+0x80]
+       mov      rdx, gword ptr [rdx+0x08]
+       cmp      ecx, dword ptr [rdx+0x10]
+       jge      SHORT G_M864_IG07
+       mov      r8d, dword ptr [rsp+0x78]
        mov      rcx, rdx
        ; gcrRegs +[rcx]
-       lea      rdx, [rsp+0x28]
+       lea      rdx, [rsp+0x20]
        ; gcrRegs -[rdx]
        call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       movzx    rcx, byte  ptr [rsp+0x44]
+       movzx    rcx, byte  ptr [rsp+0x3C]
        lea      eax, [rcx-0x01]
        cmp      eax, 1
-       ja       SHORT G_M864_IG11
-						;; size=35 bbWeight=1 PerfScore 7.50
-G_M864_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       ja       SHORT G_M864_IG06
+						;; size=60 bbWeight=1 PerfScore 17.75
+G_M864_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      eax, 1
 						;; size=5 bbWeight=1 PerfScore 0.25
-G_M864_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 144
+G_M864_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 136
        pop      rbx
+       pop      rsi
        ret      
-						;; size=9 bbWeight=1 PerfScore 1.75
-G_M864_IG08:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      ecx, dword ptr [rsp+0x80]
-       inc      ecx
-       mov      dword ptr [rsp+0x80], ecx
-       mov      ecx, dword ptr [rsp+0x80]
-       mov      rdx, gword ptr [rsp+0x78]
-       ; gcrRegs +[rdx]
-       mov      rdx, gword ptr [rdx+0x08]
-       cmp      ecx, dword ptr [rdx+0x10]
-       jl       SHORT G_M864_IG05
-						;; size=37 bbWeight=1 PerfScore 10.25
-G_M864_IG09:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rdx]
-       xor      eax, eax
-						;; size=2 bbWeight=0 PerfScore 0.00
-G_M864_IG10:        ; bbWeight=0, epilog, nogc, extend
-       add      rsp, 144
-       pop      rbx
-       ret      
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M864_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+						;; size=10 bbWeight=1 PerfScore 2.25
+G_M864_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        add      ecx, -22
        cmp      ecx, 1
-       jbe      SHORT G_M864_IG06
+       jbe      SHORT G_M864_IG04
        jmp      SHORT G_M864_IG03
 						;; size=10 bbWeight=0 PerfScore 0.00
+G_M864_IG07:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       xor      eax, eax
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M864_IG08:        ; bbWeight=0, epilog, nogc, extend
+       add      rsp, 136
+       pop      rbx
+       pop      rsi
+       ret      
+						;; size=10 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 201, prolog size 53, PerfScore 54.83, instruction count 50, allocated bytes for code 201 (MethodHash=caadfc9f) for method Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)
+; Total bytes of code 159, prolog size 39, PerfScore 40.58, instruction count 44, allocated bytes for code 159 (MethodHash=caadfc9f) for method Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -130,11 +116,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x09
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 18 * 8 = 144 = 0x00090
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x09 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-34</span> (<span style="color:green">-12.45%</span>) : 62733.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,8 +11,8 @@
 ;
 ;  V00 TypeCtx      [V00,T02] (  5,  4.36)    long  ->  rbx         single-def
 ;  V01 arg0         [V01,T04] (  3,  3   )     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V02 loc0         [V02    ] ( 11, 11   )  struct (16) [rsp+0x78]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V03 loc1         [V03    ] (  2,  2   )  struct (80) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
+;  V02 loc0         [V02    ] ( 11, 11   )  struct (16) [rsp+0x70]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V03 loc1         [V03    ] (  2,  2   )  struct (80) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V06 tmp2         [V06    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
@@ -22,119 +22,120 @@
 ;  V10 tmp6         [V10,T01] (  4,  8   )     int  ->  rsi         "impAppendStmt"
 ;  V11 tmp7         [V11,T00] (  4,  8   )     ref  ->  rdi         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;* V12 tmp8         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V13 tmp9         [V13    ] (  4,  4   )     ref  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V02._builder (fldOffset=0x0)" P-DEP
-;  V14 tmp10        [V14    ] (  8,  8   )     int  ->  [rsp+0x80]  do-not-enreg[X] addr-exposed "field V02._index (fldOffset=0x8)" P-DEP
+;  V13 tmp9         [V13    ] (  4,  4   )     ref  ->  [rsp+0x70]  do-not-enreg[X] addr-exposed "field V02._builder (fldOffset=0x0)" P-DEP
+;  V14 tmp10        [V14    ] (  8,  8   )     int  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V02._index (fldOffset=0x8)" P-DEP
 ;  V15 tmp11        [V15,T09] (  2,  4   )    long  ->  rdx         "argument with side effect"
-;  V16 rat0         [V16,T06] (  3,  4   )    long  ->  rdx         "runtime lookup"
-;  V17 rat1         [V17,T03] (  3,  5.60)    long  ->  rcx         "spilling expr"
-;  V18 rat2         [V18,T05] (  3,  4.48)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V16 cse0         [V16,T10] (  2,  2   )    long  ->  rbp         hoist "CSE - aggressive"
+;  V17 rat0         [V17,T06] (  3,  4   )    long  ->  rbp         "runtime lookup"
+;  V18 rat1         [V18,T03] (  3,  5.60)    long  ->  rcx         "spilling expr"
+;  V19 rat2         [V19,T05] (  3,  4.48)    long  ->  rbp         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 144
+; Lcl frame size = 136
 
 G_M49884_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 144
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 136
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       vmovdqu  ymmword ptr [rsp+0x50], ymm4
-       vmovdqa  xmmword ptr [rsp+0x70], xmm4
-       mov      qword ptr [rsp+0x80], rax
-       mov      qword ptr [rsp+0x88], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqu  ymmword ptr [rsp+0x40], ymm4
+       vmovdqu  ymmword ptr [rsp+0x60], ymm4
+       mov      qword ptr [rsp+0x80], rcx
        mov      rbx, rcx
        mov      rcx, rdx
        ; gcrRegs +[rcx]
-						;; size=61 bbWeight=1 PerfScore 13.33
-G_M49884_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       lea      rdx, [rsp+0x78]
+						;; size=47 bbWeight=1 PerfScore 12.08
+G_M49884_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       lea      rdx, [rsp+0x70]
        cmp      dword ptr [rcx], ecx
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:GetEnumerator():Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      ecx, dword ptr [rsp+0x80]
+       mov      ecx, dword ptr [rsp+0x78]
        inc      ecx
-       mov      dword ptr [rsp+0x80], ecx
-       mov      esi, dword ptr [rsp+0x80]
-       mov      rdi, gword ptr [rsp+0x78]
+       mov      dword ptr [rsp+0x78], ecx
+       mov      esi, dword ptr [rsp+0x78]
+       mov      rdi, gword ptr [rsp+0x70]
        ; gcrRegs +[rdi]
        mov      rcx, gword ptr [rdi+0x08]
        ; gcrRegs +[rcx]
        cmp      esi, dword ptr [rcx+0x10]
-       jge      G_M49884_IG10
-						;; size=54 bbWeight=1 PerfScore 16.75
-G_M49884_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rcx rdi]
-       mov      rcx, gword ptr [rsp+0x78]
-       ; gcrRegs +[rcx]
-       mov      r8d, dword ptr [rsp+0x80]
-       mov      rcx, gword ptr [rcx+0x08]
-       lea      rdx, [rsp+0x28]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
+       jge      G_M49884_IG09
        mov      rcx, qword ptr [rbx+0x38]
+       ; gcrRegs -[rcx]
        cmp      qword ptr [rcx+0x08], 24
-       jle      SHORT G_M49884_IG06
-						;; size=41 bbWeight=1 PerfScore 16.50
-G_M49884_IG04:        ; bbWeight=0.80, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rdx, qword ptr [rcx+0x18]
-       test     rdx, rdx
-       je       SHORT G_M49884_IG06
+       jle      SHORT G_M49884_IG05
+						;; size=56 bbWeight=1 PerfScore 22.75
+G_M49884_IG03:        ; bbWeight=0.80, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rdi]
+       mov      rbp, qword ptr [rcx+0x18]
+       test     rbp, rbp
+       je       SHORT G_M49884_IG05
 						;; size=9 bbWeight=0.80 PerfScore 2.60
-G_M49884_IG05:        ; bbWeight=0.64, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       jmp      SHORT G_M49884_IG07
+G_M49884_IG04:        ; bbWeight=0.64, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M49884_IG06
 						;; size=2 bbWeight=0.64 PerfScore 1.28
-G_M49884_IG06:        ; bbWeight=0.36, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M49884_IG05:        ; bbWeight=0.36, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rcx, rbx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rdx, rax
+       mov      rbp, rax
 						;; size=21 bbWeight=0.36 PerfScore 0.63
-G_M49884_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       lea      rcx, [rsp+0x28]
+G_M49884_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, gword ptr [rsp+0x70]
+       ; gcrRegs +[rcx]
+       mov      r8d, dword ptr [rsp+0x78]
+       mov      rcx, gword ptr [rcx+0x08]
+       lea      rdx, [rsp+0x20]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
+       ; gcrRegs -[rcx]
+       ; gcr arg pop 0
+       mov      rdx, rbp
+       lea      rcx, [rsp+0x20]
        call     [Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this]
        ; gcr arg pop 0
        test     eax, eax
-       je       SHORT G_M49884_IG09
+       je       SHORT G_M49884_IG08
        mov      eax, 1
-						;; size=20 bbWeight=1 PerfScore 5.00
-G_M49884_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 144
+						;; size=50 bbWeight=1 PerfScore 15.75
+G_M49884_IG07:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 136
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=1 PerfScore 2.75
-G_M49884_IG09:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      eax, dword ptr [rsp+0x80]
+						;; size=12 bbWeight=1 PerfScore 3.25
+G_M49884_IG08:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       mov      eax, dword ptr [rsp+0x78]
        inc      eax
-       mov      dword ptr [rsp+0x80], eax
-       mov      esi, dword ptr [rsp+0x80]
-       mov      rdi, gword ptr [rsp+0x78]
+       mov      dword ptr [rsp+0x78], eax
+       mov      esi, dword ptr [rsp+0x78]
+       mov      rdi, gword ptr [rsp+0x70]
        ; gcrRegs +[rdi]
        mov      rax, gword ptr [rdi+0x08]
        ; gcrRegs +[rax]
        cmp      esi, dword ptr [rax+0x10]
-       jl       G_M49884_IG03
-						;; size=41 bbWeight=1 PerfScore 10.25
-G_M49884_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jl       SHORT G_M49884_IG06
+						;; size=28 bbWeight=1 PerfScore 10.25
+G_M49884_IG09:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rdi]
        xor      eax, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M49884_IG11:        ; bbWeight=0, epilog, nogc, extend
-       add      rsp, 144
+G_M49884_IG10:        ; bbWeight=0, epilog, nogc, extend
+       add      rsp, 136
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=0 PerfScore 0.00
+						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 273, prolog size 55, PerfScore 69.09, instruction count 66, allocated bytes for code 273 (MethodHash=d42f3d23) for method Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
+; Total bytes of code 239, prolog size 41, PerfScore 68.59, instruction count 67, allocated bytes for code 239 (MethodHash=d42f3d23) for method Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -142,13 +143,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x0B
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 18 * 8 = 144 = 0x00090
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0B UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+30</span> (<span style="color:red">+27.78%</span>) : 411738.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (Instrumented Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,59 +8,71 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4, 18   )     ref  ->  rbx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
-;  V01 loc0         [V01,T01] (  3, 17   )   float  ->  mm6        
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
+;  V01 loc0         [V01,T02] (  3, 17   )   float  ->  mm8        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;  V04 cse0         [V04,T00] (  2,  9   )   byref  ->  rbx         hoist "CSE - aggressive"
+;  V05 cse1         [V05,T03] (  2,  9   )  double  ->  mm6         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T04] (  2,  9   )   float  ->  mm7         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 48
+; Lcl frame size = 80
 
-G_M31728_IG01:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M31728_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 48
-       vmovaps  xmmword ptr [rsp+0x20], xmm6
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=14 bbWeight=8 PerfScore 28.00
-G_M31728_IG02:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       cmp      byte  ptr [rbx], bl
-       lea      rcx, bword ptr [rbx+0x08]
+       sub      rsp, 80
+       vmovaps  xmmword ptr [rsp+0x40], xmm6
+       vmovaps  xmmword ptr [rsp+0x30], xmm7
+       vmovaps  xmmword ptr [rsp+0x20], xmm8
+						;; size=23 bbWeight=1 PerfScore 7.25
+G_M31728_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rcx]
+       cmp      byte  ptr [rcx], cl
+       lea      rbx, bword ptr [rcx+0x08]
+       ; byrRegs +[rbx]
+       vmovsd   xmm6, qword ptr [reloc @RWD00]
+       vmovss   xmm7, dword ptr [reloc @RWD08]
+						;; size=22 bbWeight=1 PerfScore 9.50
+G_M31728_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, rbx
        ; byrRegs +[rcx]
        call     [System.Random+CompatPrng:InternalSample():int:this]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        vxorps   xmm0, xmm0, xmm0
        vcvtsi2sd xmm0, xmm0, eax
-       vmulsd   xmm0, xmm0, qword ptr [reloc @RWD00]
-       vcvtsd2ss xmm6, xmm6, xmm0
-       vmovss   xmm0, dword ptr [reloc @RWD08]
-       vucomiss xmm0, xmm6
-       ja       SHORT G_M31728_IG04
-						;; size=46 bbWeight=8 PerfScore 222.67
-G_M31728_IG03:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       vmulsd   xmm0, xmm0, xmm6
+       vcvtsd2ss xmm8, xmm8, xmm0
+       vucomiss xmm7, xmm8
+       ja       SHORT G_M31728_IG05
+						;; size=32 bbWeight=8 PerfScore 156.67
+G_M31728_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        ; gcr arg pop 0
-       jmp      SHORT G_M31728_IG02
+       jmp      SHORT G_M31728_IG03
 						;; size=17 bbWeight=2 PerfScore 6.50
-G_M31728_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx]
+G_M31728_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; byrRegs -[rbx]
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        ; gcr arg pop 0
-       vmovaps  xmm0, xmm6
-						;; size=19 bbWeight=1 PerfScore 1.50
-G_M31728_IG05:        ; bbWeight=1, epilog, nogc, extend
-       vmovaps  xmm6, xmmword ptr [rsp+0x20]
-       add      rsp, 48
+       vmovaps  xmm0, xmm8
+						;; size=20 bbWeight=1 PerfScore 1.50
+G_M31728_IG06:        ; bbWeight=1, epilog, nogc, extend
+       vmovaps  xmm6, xmmword ptr [rsp+0x40]
+       vmovaps  xmm7, xmmword ptr [rsp+0x30]
+       vmovaps  xmm8, xmmword ptr [rsp+0x20]
+       add      rsp, 80
        pop      rbx
        ret      
-						;; size=12 bbWeight=1 PerfScore 5.75
+						;; size=24 bbWeight=1 PerfScore 13.75
 RWD00  	dq	3E00000000200000h	; 4.65661288e-10
 RWD08  	dd	3F800000h		;         1
 
 
-; Total bytes of code 108, prolog size 11, PerfScore 264.42, instruction count 24, allocated bytes for code 108 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (Instrumented Tier1)
+; Total bytes of code 138, prolog size 23, PerfScore 195.17, instruction count 29, allocated bytes for code 138 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (Instrumented Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -68,12 +80,16 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0B
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x17
+  CountOfUnwindCodes: 8
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0B UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+    CodeOffset: 0x17 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM8 (8)
       Scaled Small Offset: 2 * 16 = 32 = 0x00020
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 3 * 16 = 48 = 0x00030
+    CodeOffset: 0x0B UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 4 * 16 = 64 = 0x00040
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 9 * 8 + 8 = 80 = 0x50
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+32</span> (<span style="color:red">+37.21%</span>) : 420077.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+Exp2M1Operator`1[System.Half]](byref,byref,ulong) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -17,57 +17,67 @@
 ;* V05 tmp1         [V05    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Half>
 ;* V06 tmp2         [V06    ] (  0,  0   )   float  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp3         [V07    ] (  0,  0   )  ushort  ->  zero-ref    "field V05._value (fldOffset=0x0)" P-INDEP
-;  V08 rat0         [V08,T04] (  2,514.16)   float  ->  mm0         "argument with side effect"
+;  V08 cse0         [V08,T05] (  2,129.53)   float  ->  mm6         hoist "CSE - aggressive"
+;  V09 cse1         [V09,T06] (  2,129.53)   float  ->  mm7         hoist "CSE - aggressive"
+;  V10 rat0         [V10,T04] (  2,514.16)   float  ->  mm0         "argument with side effect"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 72
 
 G_M62145_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 72
+       vmovaps  xmmword ptr [rsp+0x30], xmm6
+       vmovaps  xmmword ptr [rsp+0x20], xmm7
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      rdi, rdx
        ; byrRegs +[rdi]
        mov      rbx, r8
-						;; size=17 bbWeight=1 PerfScore 5.00
+						;; size=29 bbWeight=1 PerfScore 9.00
 G_M62145_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref, isz
        xor      ebp, ebp
        test     rbx, rbx
-       je       SHORT G_M62145_IG04
+       je       SHORT G_M62145_IG05
 						;; size=7 bbWeight=1 PerfScore 1.50
-G_M62145_IG03:        ; bbWeight=128.54, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref, isz
+G_M62145_IG03:        ; bbWeight=0.99, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref
+       vmovss   xmm6, dword ptr [reloc @RWD00]
+       vmovss   xmm7, dword ptr [reloc @RWD04]
+						;; size=16 bbWeight=0.99 PerfScore 5.95
+G_M62145_IG04:        ; bbWeight=128.54, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref, isz
        movzx    rcx, word  ptr [rsi+2*rbp]
        call     [<unknown method>]
        ; gcr arg pop 0
        vmovaps  xmm1, xmm0
-       vmovss   xmm0, dword ptr [reloc @RWD00]
+       vmovaps  xmm0, xmm6
        call     <unknown method>
        ; gcr arg pop 0
-       vsubss   xmm0, xmm0, dword ptr [reloc @RWD04]
+       vsubss   xmm0, xmm0, xmm7
        call     [<unknown method>]
        ; gcr arg pop 0
        mov      word  ptr [rdi+2*rbp], ax
        inc      rbp
        cmp      rbp, rbx
-       jb       SHORT G_M62145_IG03
-						;; size=53 bbWeight=128.54 PerfScore 2538.66
-G_M62145_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       jb       SHORT G_M62145_IG04
+						;; size=45 bbWeight=128.54 PerfScore 1928.10
+G_M62145_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; byrRegs -[rsi rdi]
-       add      rsp, 40
+       vmovaps  xmm6, xmmword ptr [rsp+0x30]
+       vmovaps  xmm7, xmmword ptr [rsp+0x20]
+       add      rsp, 72
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
+						;; size=21 bbWeight=1 PerfScore 11.25
 RWD00  	dd	40000000h		;         2
 RWD04  	dd	3F800000h		;         1
 
 
-; Total bytes of code 86, prolog size 8, PerfScore 2548.41, instruction count 28, allocated bytes for code 86 (MethodHash=ef420d3e) for method System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+Exp2M1Operator`1[System.Half]](byref,byref,ulong) (Tier1)
+; Total bytes of code 118, prolog size 20, PerfScore 1955.80, instruction count 34, allocated bytes for code 118 (MethodHash=ef420d3e) for method System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+Exp2M1Operator`1[System.Half]](byref,byref,ulong) (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -75,12 +85,16 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x14
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 2 * 16 = 32 = 0x00020
+    CodeOffset: 0x0E UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 3 * 16 = 48 = 0x00030
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+32</span> (<span style="color:red">+41.56%</span>) : 420232.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+RadiansToDegreesOperator`1[System.Half]](byref,byref,ulong) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -17,53 +17,63 @@
 ;* V05 tmp1         [V05    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Half>
 ;* V06 tmp2         [V06    ] (  0,  0   )   float  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp3         [V07    ] (  0,  0   )  ushort  ->  zero-ref    "field V05._value (fldOffset=0x0)" P-INDEP
+;  V08 cse0         [V08,T04] (  2,130.37)   float  ->  mm6         hoist "CSE - aggressive"
+;  V09 cse1         [V09,T05] (  2,130.37)   float  ->  mm7         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 72
 
 G_M15676_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 72
+       vmovaps  xmmword ptr [rsp+0x30], xmm6
+       vmovaps  xmmword ptr [rsp+0x20], xmm7
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      rdi, rdx
        ; byrRegs +[rdi]
        mov      rbx, r8
-						;; size=17 bbWeight=1 PerfScore 5.00
+						;; size=29 bbWeight=1 PerfScore 9.00
 G_M15676_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref, isz
        xor      ebp, ebp
        test     rbx, rbx
-       je       SHORT G_M15676_IG04
+       je       SHORT G_M15676_IG05
 						;; size=7 bbWeight=1 PerfScore 1.50
-G_M15676_IG03:        ; bbWeight=129.38, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref, isz
+G_M15676_IG03:        ; bbWeight=0.99, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref
+       vmovss   xmm6, dword ptr [reloc @RWD00]
+       vmovss   xmm7, dword ptr [reloc @RWD04]
+						;; size=16 bbWeight=0.99 PerfScore 5.95
+G_M15676_IG04:        ; bbWeight=129.38, gcrefRegs=0000 {}, byrefRegs=00C0 {rsi rdi}, byref, isz
        movzx    rcx, word  ptr [rsi+2*rbp]
        call     [<unknown method>]
        ; gcr arg pop 0
-       vmulss   xmm0, xmm0, dword ptr [reloc @RWD00]
-       vdivss   xmm0, xmm0, dword ptr [reloc @RWD04]
+       vmulss   xmm0, xmm0, xmm6
+       vdivss   xmm0, xmm0, xmm7
        call     [<unknown method>]
        ; gcr arg pop 0
        mov      word  ptr [rdi+2*rbp], ax
        inc      rbp
        cmp      rbp, rbx
-       jb       SHORT G_M15676_IG03
-						;; size=44 bbWeight=129.38 PerfScore 3557.94
-G_M15676_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       jb       SHORT G_M15676_IG04
+						;; size=36 bbWeight=129.38 PerfScore 3040.42
+G_M15676_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; byrRegs -[rsi rdi]
-       add      rsp, 40
+       vmovaps  xmm6, xmmword ptr [rsp+0x30]
+       vmovaps  xmm7, xmmword ptr [rsp+0x20]
+       add      rsp, 72
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
+						;; size=21 bbWeight=1 PerfScore 11.25
 RWD00  	dd	43340000h		;       180
 RWD04  	dd	40490FDBh		;   3.14159
 
 
-; Total bytes of code 77, prolog size 8, PerfScore 3567.69, instruction count 26, allocated bytes for code 77 (MethodHash=a006c2c3) for method System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+RadiansToDegreesOperator`1[System.Half]](byref,byref,ulong) (Tier1)
+; Total bytes of code 109, prolog size 20, PerfScore 3068.13, instruction count 32, allocated bytes for code 109 (MethodHash=a006c2c3) for method System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+RadiansToDegreesOperator`1[System.Half]](byref,byref,ulong) (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -71,12 +81,16 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x14
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 2 * 16 = 32 = 0x00020
+    CodeOffset: 0x0E UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 3 * 16 = 48 = 0x00030
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-20</span> (<span style="color:green">-13.61%</span>) : 123332.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[int,System.__Canon](System.Collections.Generic.IComparer`1[int],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[int,System.__Canon] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,91 +8,86 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T05] (  5,  7.80)    long  ->  rbx         single-def
-;  V01 arg0         [V01,T08] (  3,  6   )     ref  ->  rdi         class-hnd single-def <System.Collections.Generic.IComparer`1[int]>
-;  V02 arg1         [V02,T06] (  4,  7   )     ref  ->  rsi         class-hnd single-def <System.__Canon[]>
-;  V03 loc0         [V03,T07] (  3,  9   )     ref  ->  rbp         must-init class-hnd <Microsoft.FSharp.Collections.MapTree`2[int,System.__Canon]>
-;  V04 loc1         [V04,T01] (  5, 17   )     int  ->  r14        
-;  V05 loc2         [V05,T04] (  3, 12   )     ref  ->  rcx         class-hnd <System.Tuple`2[int,System.__Canon]>
-;  V06 loc3         [V06,T09] (  2,  8   )     ref  ->  r13         class-hnd <System.__Canon>
-;  V07 loc4         [V07,T10] (  2,  8   )     int  ->  r12        
+;  V00 TypeCtx      [V00,T09] (  5,  3.60)    long  ->  rcx         single-def
+;  V01 arg0         [V01,T05] (  3,  6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IComparer`1[int]>
+;  V02 arg1         [V02,T03] (  4,  7   )     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
+;  V03 loc0         [V03,T04] (  3,  9   )     ref  ->  rdi         must-init class-hnd <Microsoft.FSharp.Collections.MapTree`2[int,System.__Canon]>
+;  V04 loc1         [V04,T00] (  5, 17   )     int  ->  rbp        
+;  V05 loc2         [V05,T02] (  3, 12   )     ref  ->  rcx         class-hnd <System.Tuple`2[int,System.__Canon]>
+;  V06 loc3         [V06,T06] (  2,  8   )     ref  ->   r9         class-hnd <System.__Canon>
+;  V07 loc4         [V07,T07] (  2,  8   )     int  ->   r8        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V10 tmp2         [V10,T03] (  2, 16   )    long  ->  rcx         "argument with side effect"
-;  V11 cse0         [V11,T11] (  3,  6   )     int  ->  r15         "CSE - aggressive"
-;  V12 rat0         [V12,T02] (  3, 16   )    long  ->  rcx         "runtime lookup"
-;  V13 rat1         [V13,T00] (  3, 22.40)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V10 tmp2         [V10,T01] (  2, 16   )    long  ->  rcx         "argument with side effect"
+;  V11 cse0         [V11,T10] (  2,  4.50)    long  ->  r15         hoist "CSE - aggressive"
+;  V12 cse1         [V12,T08] (  3,  6   )     int  ->  r14         "CSE - aggressive"
+;  V13 rat0         [V13,T12] (  3,  2   )    long  ->  r15         "runtime lookup"
+;  V14 rat1         [V14,T11] (  3,  2.80)    long  ->  r15         "fgMakeTemp is creating a new local variable"
 ;
 ; Lcl frame size = 56
 
 G_M33640_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
-       push     r13
-       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
        sub      rsp, 56
        mov      qword ptr [rsp+0x30], rcx
-       mov      rbx, rcx
-       mov      rdi, rdx
-       ; gcrRegs +[rdi]
-       mov      rsi, r8
+       mov      rsi, rdx
        ; gcrRegs +[rsi]
+       mov      rbx, r8
+       ; gcrRegs +[rbx]
+       xor      edi, edi
+						;; size=25 bbWeight=1 PerfScore 8.00
+G_M33640_IG02:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rdi]
        xor      ebp, ebp
-						;; size=32 bbWeight=1 PerfScore 10.25
-G_M33640_IG02:        ; bbWeight=1, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rbp]
-       xor      r14d, r14d
-       mov      r15d, dword ptr [rsi+0x08]
-       test     r15d, r15d
+       mov      r14d, dword ptr [rbx+0x08]
+       test     r14d, r14d
        jle      SHORT G_M33640_IG07
-						;; size=12 bbWeight=1 PerfScore 3.50
-G_M33640_IG03:        ; bbWeight=4, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      ecx, r14d
-       mov      rcx, gword ptr [rsi+8*rcx+0x10]
-       ; gcrRegs +[rcx]
-       mov      r13, gword ptr [rcx+0x08]
-       ; gcrRegs +[r13]
-       mov      r12d, dword ptr [rcx+0x10]
-       mov      rcx, qword ptr [rbx+0x38]
-       ; gcrRegs -[rcx]
-       mov      rcx, qword ptr [rcx+0x18]
-       test     rcx, rcx
+						;; size=11 bbWeight=1 PerfScore 3.50
+G_M33640_IG03:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rdx, qword ptr [rcx+0x38]
+       mov      r15, qword ptr [rdx+0x18]
+       test     r15, r15
        je       SHORT G_M33640_IG05
-						;; size=29 bbWeight=4 PerfScore 46.00
-G_M33640_IG04:        ; bbWeight=3.20, gcrefRegs=20E0 {rbp rsi rdi r13}, byrefRegs=0000 {}, byref, isz
+						;; size=13 bbWeight=0.50 PerfScore 2.62
+G_M33640_IG04:        ; bbWeight=0.40, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M33640_IG06
-						;; size=2 bbWeight=3.20 PerfScore 6.40
-G_M33640_IG05:        ; bbWeight=0.80, gcrefRegs=20E0 {rbp rsi rdi r13}, byrefRegs=0000 {}, byref
-       mov      rcx, rbx
+						;; size=2 bbWeight=0.40 PerfScore 0.80
+G_M33640_IG05:        ; bbWeight=0.10, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rcx, rax
-						;; size=21 bbWeight=0.80 PerfScore 1.40
-G_M33640_IG06:        ; bbWeight=4, gcrefRegs=20E0 {rbp rsi rdi r13}, byrefRegs=0000 {}, byref, isz
-       mov      gword ptr [rsp+0x20], rbp
-       ; gcr arg write
-       mov      rdx, rdi
-       ; gcrRegs +[rdx]
-       mov      r8d, r12d
-       mov      r9, r13
+       mov      r15, rax
+						;; size=18 bbWeight=0.10 PerfScore 0.15
+G_M33640_IG06:        ; bbWeight=4, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, ebp
+       mov      rcx, gword ptr [rbx+8*rcx+0x10]
+       ; gcrRegs +[rcx]
+       mov      r9, gword ptr [rcx+0x08]
        ; gcrRegs +[r9]
+       mov      r8d, dword ptr [rcx+0x10]
+       mov      rcx, r15
+       ; gcrRegs -[rcx]
+       mov      gword ptr [rsp+0x20], rdi
+       ; gcr arg write
+       mov      rdx, rsi
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rdx rbp r9 r13] +[rax]
+       ; gcrRegs -[rdx rdi r9] +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       inc      r14d
-       cmp      r15d, r14d
-       jg       SHORT G_M33640_IG03
-						;; size=31 bbWeight=4 PerfScore 26.00
-G_M33640_IG07:        ; bbWeight=1, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rsi rdi]
-       mov      rax, rbp
+       mov      rdi, rax
+       ; gcrRegs +[rdi]
+       inc      ebp
+       cmp      r14d, ebp
+       jg       SHORT G_M33640_IG06
+						;; size=42 bbWeight=4 PerfScore 50.00
+G_M33640_IG07:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax rbx rsi]
+       mov      rax, rdi
        ; gcrRegs +[rax]
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M33640_IG08:        ; bbWeight=1, epilog, nogc, extend
@@ -101,14 +96,12 @@ G_M33640_IG08:        ; bbWeight=1, epilog, nogc, extend
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r12
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=17 bbWeight=1 PerfScore 5.25
+						;; size=13 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 147, prolog size 21, PerfScore 99.05, instruction count 51, allocated bytes for code 147 (MethodHash=fb1e7c97) for method Microsoft.FSharp.Collections.MapTreeModule:ofArray[int,System.__Canon](System.Collections.Generic.IComparer`1[int],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[int,System.__Canon] (FullOpts)
+; Total bytes of code 127, prolog size 17, PerfScore 69.58, instruction count 44, allocated bytes for code 127 (MethodHash=fb1e7c97) for method Microsoft.FSharp.Collections.MapTreeModule:ofArray[int,System.__Canon](System.Collections.Generic.IComparer`1[int],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[int,System.__Canon] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -116,17 +109,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x10
-  CountOfUnwindCodes: 9
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
-    CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r12 (12)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:green">-34</span> (<span style="color:green">-12.64%</span>) : 10502.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,132 +8,134 @@
 ; 0 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T08] (  5,  8.44)    long  ->  rbx         single-def
-;  V01 arg0         [V01,T09] (  3,  3   )     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V02 loc0         [V02    ] ( 11, 29   )  struct (16) [rsp+0x78]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V03 loc1         [V03    ] (  2,  8   )  struct (80) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
+;  V00 TypeCtx      [V00,T05] (  5,  3.68)    long  ->  rbx         single-def
+;  V01 arg0         [V01,T06] (  3,  3   )     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V02 loc0         [V02    ] ( 11, 29   )  struct (16) [rsp+0x70]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V03 loc1         [V03    ] (  2,  8   )  struct (80) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V06 tmp2         [V06    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V07 tmp3         [V07    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V08 tmp4         [V08,T05] (  2, 16   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V09 tmp5         [V09,T06] (  2, 16   )     int  ->   r8         "Inlining Arg"
-;  V10 tmp6         [V10,T02] (  4, 20   )     int  ->  rsi         "impAppendStmt"
-;  V11 tmp7         [V11,T01] (  4, 20   )     ref  ->  rdi         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V08 tmp4         [V08,T02] (  2, 16   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V09 tmp5         [V09,T03] (  2, 16   )     int  ->   r8         "Inlining Arg"
+;  V10 tmp6         [V10,T01] (  4, 20   )     int  ->  rsi         "impAppendStmt"
+;  V11 tmp7         [V11,T00] (  4, 20   )     ref  ->  rdi         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;* V12 tmp8         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V13 tmp9         [V13    ] (  4, 10   )     ref  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V02._builder (fldOffset=0x0)" P-DEP
-;  V14 tmp10        [V14    ] (  8, 20   )     int  ->  [rsp+0x80]  do-not-enreg[X] addr-exposed "field V02._index (fldOffset=0x8)" P-DEP
-;  V15 tmp11        [V15,T07] (  2, 16   )    long  ->  rdx         "argument with side effect"
-;  V16 rat0         [V16,T04] (  3, 16   )    long  ->  rdx         "runtime lookup"
-;  V17 rat1         [V17,T00] (  3, 22.40)    long  ->  rcx         "spilling expr"
-;  V18 rat2         [V18,T03] (  3, 17.92)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V13 tmp9         [V13    ] (  4, 10   )     ref  ->  [rsp+0x70]  do-not-enreg[X] addr-exposed "field V02._builder (fldOffset=0x0)" P-DEP
+;  V14 tmp10        [V14    ] (  8, 20   )     int  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V02._index (fldOffset=0x8)" P-DEP
+;  V15 tmp11        [V15,T04] (  2, 16   )    long  ->  rdx         "argument with side effect"
+;  V16 cse0         [V16,T07] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V17 rat0         [V17,T10] (  3,  2   )    long  ->  rbp         "runtime lookup"
+;  V18 rat1         [V18,T08] (  3,  2.80)    long  ->  rcx         "spilling expr"
+;  V19 rat2         [V19,T09] (  3,  2.24)    long  ->  rbp         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 144
+; Lcl frame size = 136
 
 G_M49884_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 144
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 136
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       vmovdqu  ymmword ptr [rsp+0x50], ymm4
-       vmovdqa  xmmword ptr [rsp+0x70], xmm4
-       mov      qword ptr [rsp+0x80], rax
-       mov      qword ptr [rsp+0x88], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqu  ymmword ptr [rsp+0x40], ymm4
+       vmovdqu  ymmword ptr [rsp+0x60], ymm4
+       mov      qword ptr [rsp+0x80], rcx
        mov      rbx, rcx
        mov      rcx, rdx
        ; gcrRegs +[rcx]
-						;; size=61 bbWeight=1 PerfScore 13.33
-G_M49884_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       lea      rdx, [rsp+0x78]
+						;; size=47 bbWeight=1 PerfScore 12.08
+G_M49884_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       lea      rdx, [rsp+0x70]
        cmp      dword ptr [rcx], ecx
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:GetEnumerator():Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      ecx, dword ptr [rsp+0x80]
+       mov      ecx, dword ptr [rsp+0x78]
        inc      ecx
-       mov      dword ptr [rsp+0x80], ecx
-       mov      esi, dword ptr [rsp+0x80]
-       mov      rdi, gword ptr [rsp+0x78]
+       mov      dword ptr [rsp+0x78], ecx
+       mov      esi, dword ptr [rsp+0x78]
+       mov      rdi, gword ptr [rsp+0x70]
        ; gcrRegs +[rdi]
        mov      rcx, gword ptr [rdi+0x08]
        ; gcrRegs +[rcx]
        cmp      esi, dword ptr [rcx+0x10]
-       jge      G_M49884_IG08
-						;; size=54 bbWeight=1 PerfScore 16.75
-G_M49884_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jge      SHORT G_M49884_IG08
+						;; size=41 bbWeight=1 PerfScore 16.75
+G_M49884_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rcx rdi]
-       mov      rcx, gword ptr [rsp+0x78]
-       ; gcrRegs +[rcx]
-       mov      r8d, dword ptr [rsp+0x80]
-       mov      rcx, gword ptr [rcx+0x08]
-       lea      rdx, [rsp+0x28]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
        mov      rcx, qword ptr [rbx+0x38]
        cmp      qword ptr [rcx+0x08], 24
        jle      SHORT G_M49884_IG06
-						;; size=41 bbWeight=4 PerfScore 66.00
-G_M49884_IG04:        ; bbWeight=3.20, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rdx, qword ptr [rcx+0x18]
-       test     rdx, rdx
+						;; size=11 bbWeight=0.50 PerfScore 3.00
+G_M49884_IG04:        ; bbWeight=0.40, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rbp, qword ptr [rcx+0x18]
+       test     rbp, rbp
        je       SHORT G_M49884_IG06
-						;; size=9 bbWeight=3.20 PerfScore 10.40
-G_M49884_IG05:        ; bbWeight=2.56, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=9 bbWeight=0.40 PerfScore 1.30
+G_M49884_IG05:        ; bbWeight=0.32, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M49884_IG07
-						;; size=2 bbWeight=2.56 PerfScore 5.12
-G_M49884_IG06:        ; bbWeight=1.44, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=2 bbWeight=0.32 PerfScore 0.64
+G_M49884_IG06:        ; bbWeight=0.18, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rcx, rbx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rdx, rax
-						;; size=21 bbWeight=1.44 PerfScore 2.52
+       mov      rbp, rax
+						;; size=21 bbWeight=0.18 PerfScore 0.32
 G_M49884_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       lea      rcx, [rsp+0x28]
+       mov      rcx, gword ptr [rsp+0x70]
+       ; gcrRegs +[rcx]
+       mov      r8d, dword ptr [rsp+0x78]
+       mov      rcx, gword ptr [rcx+0x08]
+       lea      rdx, [rsp+0x20]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
+       ; gcrRegs -[rcx]
+       ; gcr arg pop 0
+       mov      rdx, rbp
+       lea      rcx, [rsp+0x20]
        call     [Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this]
        ; gcr arg pop 0
        test     eax, eax
        jne      SHORT G_M49884_IG10
-       mov      eax, dword ptr [rsp+0x80]
+       mov      eax, dword ptr [rsp+0x78]
        inc      eax
-       mov      dword ptr [rsp+0x80], eax
-       mov      esi, dword ptr [rsp+0x80]
-       mov      rdi, gword ptr [rsp+0x78]
+       mov      dword ptr [rsp+0x78], eax
+       mov      esi, dword ptr [rsp+0x78]
+       mov      rdi, gword ptr [rsp+0x70]
        ; gcrRegs +[rdi]
        mov      rax, gword ptr [rdi+0x08]
        ; gcrRegs +[rax]
        cmp      esi, dword ptr [rax+0x10]
-       jl       SHORT G_M49884_IG03
-						;; size=52 bbWeight=4 PerfScore 60.00
+       jl       SHORT G_M49884_IG07
+						;; size=73 bbWeight=4 PerfScore 103.00
 G_M49884_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rdi]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M49884_IG09:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 144
+       add      rsp, 136
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.38
+						;; size=12 bbWeight=0.50 PerfScore 1.62
 G_M49884_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M49884_IG11:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 144
+       add      rsp, 136
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.38
+						;; size=12 bbWeight=0.50 PerfScore 1.62
 
-; Total bytes of code 269, prolog size 55, PerfScore 177.12, instruction count 66, allocated bytes for code 269 (MethodHash=d42f3d23) for method Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
+; Total bytes of code 235, prolog size 41, PerfScore 140.59, instruction count 67, allocated bytes for code 235 (MethodHash=d42f3d23) for method Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -141,13 +143,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x0B
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 18 * 8 = 144 = 0x00090
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0B UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:green">-19</span> (<span style="color:green">-12.58%</span>) : 3122.dasm - Microsoft.VisualStudio.Composition.Utilities:EqualsByValue[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,11 +8,11 @@
 ; 0 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T04] (  5,  8.39)    long  ->  rbx         single-def
+;  V00 TypeCtx      [V00,T07] (  5,  3.34)    long  ->  rcx         single-def
 ;* V01 arg0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
 ;* V02 arg1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op single-def <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
-;  V03 loc0         [V03,T02] (  6, 20.30)     int  ->  r14        
-;  V04 loc1         [V04,T06] (  2,  7.92)     ref  ->  r15         ld-addr-op class-hnd <System.__Canon>
+;  V03 loc0         [V03,T01] (  5, 16.34)     int  ->  rbp        
+;  V04 loc1         [V04,T04] (  2,  7.92)     ref  ->  rcx         ld-addr-op class-hnd <System.__Canon>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V07 tmp2         [V07    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
@@ -21,111 +21,108 @@
 ;* V10 tmp5         [V10    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V11 tmp6         [V11    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V12 tmp7         [V12    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V13 tmp8         [V13,T00] (  4, 23.76)    long  ->  r11         "VirtualCall with runtime lookup"
-;  V14 tmp9         [V14,T07] (  3,  5.96)     ref  ->  rdi         single-def "field V01.array (fldOffset=0x0)" P-INDEP
-;  V15 tmp10        [V15,T05] (  3,  5.96)     ref  ->  rsi         single-def "field V02.array (fldOffset=0x0)" P-INDEP
-;  V16 cse0         [V16,T08] (  4,  6.46)     int  ->  rbp         "CSE - aggressive"
-;  V17 rat0         [V17,T01] (  3, 22.18)    long  ->  rcx         "spilling expr"
-;  V18 rat1         [V18,T03] (  3, 17.74)    long  ->  r11         "fgMakeTemp is creating a new local variable"
-;* V19 rat2         [V19,T09] (  0,  0   )    long  ->  zero-ref    "spilling expr"
-;* V20 rat3         [V20,T10] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
+;  V13 tmp8         [V13,T00] (  3, 23.76)    long  ->  r11         "VirtualCall with runtime lookup"
+;  V14 tmp9         [V14,T05] (  3,  5.96)     ref  ->  rsi         single-def "field V01.array (fldOffset=0x0)" P-INDEP
+;  V15 tmp10        [V15,T03] (  3,  5.96)     ref  ->  rbx         single-def "field V02.array (fldOffset=0x0)" P-INDEP
+;  V16 cse0         [V16,T08] (  2,  4.21)    long  ->  r14         hoist multi-def "CSE - aggressive"
+;  V17 cse1         [V17,T06] (  4,  6.46)     int  ->  rdi         "CSE - aggressive"
+;  V18 cse2         [V18,T02] (  3, 11.88)    long  ->  rdx         "CSE - aggressive"
+;  V19 rat0         [V19,T11] (  3,  1   )    long  ->  r14         "runtime lookup"
+;  V20 rat1         [V20,T09] (  3,  1.40)    long  ->  rdx         "spilling expr"
+;  V21 rat2         [V21,T10] (  3,  1.12)    long  ->  r14         "fgMakeTemp is creating a new local variable"
+;* V22 rat3         [V22,T14] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;* V23 rat4         [V23,T12] (  0,  0   )    long  ->  zero-ref    "spilling expr"
+;* V24 rat5         [V24,T13] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
 G_M43719_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
-       mov      qword ptr [rsp+0x20], rcx
-       mov      rbx, rcx
-       mov      rdi, rdx
-       ; gcrRegs +[rdi]
-       mov      rsi, r8
+       sub      rsp, 48
+       mov      qword ptr [rsp+0x28], rcx
+       mov      rsi, rdx
        ; gcrRegs +[rsi]
-						;; size=26 bbWeight=1 PerfScore 8.00
-G_M43719_IG02:        ; bbWeight=1, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      ebp, dword ptr [rdi+0x08]
-       cmp      ebp, dword ptr [rsi+0x08]
+       mov      rbx, r8
+       ; gcrRegs +[rbx]
+						;; size=21 bbWeight=1 PerfScore 6.75
+G_M43719_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+       mov      edi, dword ptr [rsi+0x08]
+       cmp      edi, dword ptr [rbx+0x08]
        je       SHORT G_M43719_IG05
 						;; size=8 bbWeight=1 PerfScore 6.00
 G_M43719_IG03:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rsi rdi]
+       ; gcrRegs -[rbx rsi]
        xor      eax, eax
 						;; size=2 bbWeight=1.98 PerfScore 0.49
 G_M43719_IG04:        ; bbWeight=1.98, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=1.98 PerfScore 8.42
-G_M43719_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rsi rdi]
-       xor      r14d, r14d
-       test     ebp, ebp
+						;; size=11 bbWeight=1.98 PerfScore 7.43
+G_M43719_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rbx rsi]
+       xor      ebp, ebp
+       test     edi, edi
        jle      SHORT G_M43719_IG11
-						;; size=7 bbWeight=0.50 PerfScore 0.75
-G_M43719_IG06:        ; bbWeight=3.96, gcrefRegs=00C0 {rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      ecx, r14d
-       mov      r15, gword ptr [rdi+8*rcx+0x10]
-       ; gcrRegs +[r15]
-       mov      rcx, qword ptr [rbx+0x38]
-       cmp      qword ptr [rcx+0x08], 24
+						;; size=6 bbWeight=0.50 PerfScore 0.75
+G_M43719_IG06:        ; bbWeight=0.25, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+       mov      rdx, qword ptr [rcx+0x38]
+       cmp      qword ptr [rdx+0x08], 24
        jle      SHORT G_M43719_IG09
-						;; size=19 bbWeight=3.96 PerfScore 32.67
-G_M43719_IG07:        ; bbWeight=3.17, gcrefRegs=80C0 {rsi rdi r15}, byrefRegs=0000 {}, byref, isz
-       mov      r11, qword ptr [rcx+0x18]
-       test     r11, r11
+						;; size=11 bbWeight=0.25 PerfScore 1.50
+G_M43719_IG07:        ; bbWeight=0.20, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+       mov      r14, qword ptr [rdx+0x18]
+       test     r14, r14
        je       SHORT G_M43719_IG09
-						;; size=9 bbWeight=3.17 PerfScore 10.30
-G_M43719_IG08:        ; bbWeight=2.53, gcrefRegs=80C0 {rsi rdi r15}, byrefRegs=0000 {}, byref, isz
+						;; size=9 bbWeight=0.20 PerfScore 0.65
+G_M43719_IG08:        ; bbWeight=0.16, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M43719_IG10
-						;; size=2 bbWeight=2.53 PerfScore 5.07
-G_M43719_IG09:        ; bbWeight=1.43, gcrefRegs=80C0 {rsi rdi r15}, byrefRegs=0000 {}, byref
-       mov      rcx, rbx
+						;; size=2 bbWeight=0.16 PerfScore 0.32
+G_M43719_IG09:        ; bbWeight=0.09, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      r11, rax
-						;; size=21 bbWeight=1.43 PerfScore 2.49
-G_M43719_IG10:        ; bbWeight=3.96, gcrefRegs=80C0 {rsi rdi r15}, byrefRegs=0000 {}, byref, isz
-       mov      edx, r14d
-       mov      rdx, gword ptr [rsi+8*rdx+0x10]
-       ; gcrRegs +[rdx]
-       mov      rcx, r15
+       mov      r14, rax
+						;; size=18 bbWeight=0.09 PerfScore 0.13
+G_M43719_IG10:        ; bbWeight=3.96, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+       mov      edx, ebp
+       mov      rcx, gword ptr [rsi+8*rdx+0x10]
        ; gcrRegs +[rcx]
+       mov      r11, r14
+       mov      rdx, gword ptr [rbx+8*rdx+0x10]
+       ; gcrRegs +[rdx]
        call     [r11]
-       ; gcrRegs -[rcx rdx r15]
+       ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
        test     eax, eax
        je       SHORT G_M43719_IG03
-       inc      r14d
-       cmp      ebp, r14d
-       jg       SHORT G_M43719_IG06
-						;; size=26 bbWeight=3.96 PerfScore 32.67
+       inc      ebp
+       cmp      edi, ebp
+       jg       SHORT G_M43719_IG10
+						;; size=28 bbWeight=3.96 PerfScore 40.59
 G_M43719_IG11:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rsi rdi]
+       ; gcrRegs -[rbx rsi]
        mov      eax, 1
 						;; size=5 bbWeight=1.98 PerfScore 0.49
 G_M43719_IG12:        ; bbWeight=1.98, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=1.98 PerfScore 8.42
+						;; size=11 bbWeight=1.98 PerfScore 7.43
 
-; Total bytes of code 151, prolog size 17, PerfScore 115.77, instruction count 57, allocated bytes for code 151 (MethodHash=d94c5538) for method Microsoft.VisualStudio.Composition.Utilities:EqualsByValue[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):ubyte (FullOpts)
+; Total bytes of code 132, prolog size 15, PerfScore 72.53, instruction count 51, allocated bytes for code 132 (MethodHash=d94c5538) for method Microsoft.VisualStudio.Composition.Utilities:EqualsByValue[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -133,15 +130,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0C
-  CountOfUnwindCodes: 7
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>

<details>
<summary><span style="color:red">+49</span> (<span style="color:red">+23.33%</span>) : 120709.dasm - System.Collections.Generic.GenericEqualityComparer`1[System.Formats.Asn1.AsnWriter+StackFrame]:LastIndexOf(System.Formats.Asn1.AsnWriter+StackFrame[],System.Formats.Asn1.AsnWriter+StackFrame,int,int):int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,56 +9,63 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Collections.Generic.GenericEqualityComparer`1[System.Formats.Asn1.AsnWriter+StackFrame]>
-;  V01 arg1         [V01,T03] (  7,  7.04)     ref  ->  rdx         class-hnd single-def <System.Formats.Asn1.AsnWriter+StackFrame[]>
-;  V02 arg2         [V02,T00] ( 10, 36   )   byref  ->   r8         single-def
+;  V01 arg1         [V01,T02] (  7,  7.04)     ref  ->  rdx         class-hnd single-def <System.Formats.Asn1.AsnWriter+StackFrame[]>
+;  V02 arg2         [V02,T04] ( 10,  8.32)   byref  ->   r8         single-def
 ;  V03 arg3         [V03,T08] (  4,  4   )     int  ->   r9         single-def
-;  V04 arg4         [V04,T15] (  1,  1   )     int  ->  [rsp+0x70]  single-def
+;  V04 arg4         [V04,T19] (  1,  1   )     int  ->  [rsp+0x80]  single-def
 ;  V05 loc0         [V05,T07] (  5,  6.50)     int  ->  rax        
 ;* V06 loc1         [V06    ] (  0,  0   )     int  ->  zero-ref   
-;  V07 loc2         [V07,T02] ( 14, 19.54)     int  ->   r9        
+;  V07 loc2         [V07,T01] ( 14, 19.54)     int  ->   r9        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )  struct (16) zero-ref    "spilling side-effects" <System.Formats.Asn1.AsnWriter+StackFrame>
-;* V10 tmp2         [V10,T13] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V11 tmp3         [V11,T01] ( 10, 32   )   byref  ->  rcx         "Inlining Arg"
+;* V10 tmp2         [V10,T17] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V11 tmp3         [V11,T00] ( 10, 32   )   byref  ->  registers   "Inlining Arg"
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Formats.Asn1.Asn1Tag>
 ;* V13 tmp5         [V13    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <System.Formats.Asn1.AsnWriter+StackFrame>
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Formats.Asn1.Asn1Tag>
 ;* V15 tmp7         [V15    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V16 tmp8         [V16    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
-;* V17 tmp9         [V17,T14] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V17 tmp9         [V17,T18] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V18 tmp10        [V18    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Formats.Asn1.Asn1Tag>
 ;* V19 tmp11        [V19    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
-;  V20 tmp12        [V20,T05] (  4,  8   )   ubyte  ->  rdi         "field V12._controlFlags (fldOffset=0x0)" P-INDEP
-;  V21 tmp13        [V21,T09] (  4,  6   )     int  ->  rbp         "field V12.<TagValue>k__BackingField (fldOffset=0x4)" P-INDEP
+;  V20 tmp12        [V20,T05] (  4,  8   )   ubyte  ->  r15         "field V12._controlFlags (fldOffset=0x0)" P-INDEP
+;  V21 tmp13        [V21,T09] (  4,  6   )     int  ->  r13         "field V12.<TagValue>k__BackingField (fldOffset=0x4)" P-INDEP
 ;* V22 tmp14        [V22    ] (  0,  0   )   ubyte  ->  zero-ref    "field V14._controlFlags (fldOffset=0x0)" P-INDEP
 ;* V23 tmp15        [V23    ] (  0,  0   )     int  ->  zero-ref    "field V14.<TagValue>k__BackingField (fldOffset=0x4)" P-INDEP
 ;* V24 tmp16        [V24    ] (  0,  0   )   ubyte  ->  zero-ref    "field V18._controlFlags (fldOffset=0x0)" P-INDEP
 ;* V25 tmp17        [V25    ] (  0,  0   )     int  ->  zero-ref    "field V18.<TagValue>k__BackingField (fldOffset=0x4)" P-INDEP
-;  V26 tmp18        [V26,T06] (  4,  8   )   ubyte  ->  r10         "V13.[000..001)"
-;  V27 tmp19        [V27,T10] (  4,  6   )     int  ->  r11         "V13.[004..008)"
-;  V28 tmp20        [V28,T11] (  4,  6   )     int  ->  rbx         "V13.[008..012)"
-;  V29 tmp21        [V29,T12] (  4,  6   )     int  ->  rsi         "V13.[012..016)"
-;  V30 cse0         [V30,T16] (  2,  0.08)   byref  ->  rcx         "CSE - conservative"
-;  V31 cse1         [V31,T04] (  2,  7.92)    long  ->  rcx         "CSE - aggressive"
+;  V26 tmp18        [V26,T06] (  4,  8   )   ubyte  ->  rsi         "V13.[000..001)"
+;  V27 tmp19        [V27,T10] (  4,  6   )     int  ->  rdi         "V13.[004..008)"
+;  V28 tmp20        [V28,T11] (  4,  6   )     int  ->  rbp         "V13.[008..012)"
+;  V29 tmp21        [V29,T12] (  4,  6   )     int  ->  r14         "V13.[012..016)"
+;  V30 cse0         [V30,T20] (  2,  0.08)   byref  ->  r10         "CSE - conservative"
+;  V31 cse1         [V31,T13] (  4,  4.54)     int  ->  rcx         hoist multi-def "CSE - moderate"
+;  V32 cse2         [V32,T14] (  4,  4.54)     int  ->  registers   hoist multi-def "CSE - moderate"
+;  V33 cse3         [V33,T15] (  4,  4.54)     int  ->  r11         hoist multi-def "CSE - moderate"
+;  V34 cse4         [V34,T16] (  4,  4.54)     int  ->  rbx         hoist multi-def "CSE - moderate"
+;  V35 cse5         [V35,T03] (  2,  7.92)    long  ->   r8         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M5306_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r15
+       push     r14
+       push     r13
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
-						;; size=8 bbWeight=1 PerfScore 4.25
+       sub      rsp, 32
+						;; size=14 bbWeight=1 PerfScore 7.25
 G_M5306_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref
        ; gcrRegs +[rdx]
        ; byrRegs +[r8]
        mov      eax, r9d
-       sub      eax, dword ptr [rsp+0x70]
+       sub      eax, dword ptr [rsp+0x80]
        inc      eax
        cmp      r9d, eax
        jl       G_M5306_IG11
-						;; size=18 bbWeight=1 PerfScore 3.75
+						;; size=21 bbWeight=1 PerfScore 3.75
 G_M5306_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref, isz
        test     rdx, rdx
        je       SHORT G_M5306_IG08
@@ -67,38 +74,42 @@ G_M5306_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8},
        jl       SHORT G_M5306_IG08
        cmp      dword ptr [rdx+0x08], r9d
        jle      SHORT G_M5306_IG08
-						;; size=18 bbWeight=0.50 PerfScore 3.38
-G_M5306_IG04:        ; bbWeight=3.96, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref, isz
-       mov      ecx, r9d
-       shl      rcx, 4
-       lea      rcx, bword ptr [rdx+rcx+0x10]
-       ; byrRegs +[rcx]
-       movzx    r10, byte  ptr [r8]
-       mov      r11d, dword ptr [r8+0x04]
-       mov      ebx, dword ptr [r8+0x08]
-       mov      esi, dword ptr [r8+0x0C]
-       movzx    rdi, byte  ptr [rcx]
-       mov      ebp, dword ptr [rcx+0x04]
-       cmp      dil, r10b
+       movzx    rcx, byte  ptr [r8]
+       mov      r10d, dword ptr [r8+0x04]
+       mov      r11d, dword ptr [r8+0x08]
+       mov      ebx, dword ptr [r8+0x0C]
+						;; size=34 bbWeight=0.50 PerfScore 7.38
+G_M5306_IG04:        ; bbWeight=3.96, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[r8]
+       mov      r8d, r9d
+       shl      r8, 4
+       lea      r8, bword ptr [rdx+r8+0x10]
+       ; byrRegs +[r8]
+       mov      esi, ecx
+       mov      edi, r10d
+       mov      ebp, r11d
+       mov      r14d, ebx
+       movzx    r15, byte  ptr [r8]
+       mov      r13d, dword ptr [r8+0x04]
+       cmp      r15b, sil
        jne      SHORT G_M5306_IG06
-						;; size=40 bbWeight=3.96 PerfScore 59.40
-G_M5306_IG05:        ; bbWeight=1.98, gcrefRegs=0004 {rdx}, byrefRegs=0102 {rcx r8}, byref, isz
-       cmp      ebp, r11d
+						;; size=36 bbWeight=3.96 PerfScore 31.68
+G_M5306_IG05:        ; bbWeight=1.98, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref, isz
+       cmp      r13d, edi
        jne      SHORT G_M5306_IG06
-       cmp      dword ptr [rcx+0x08], ebx
+       cmp      dword ptr [r8+0x08], ebp
        jne      SHORT G_M5306_IG06
-       cmp      dword ptr [rcx+0x0C], esi
+       cmp      dword ptr [r8+0x0C], r14d
        je       SHORT G_M5306_IG13
-						;; size=15 bbWeight=1.98 PerfScore 18.32
-G_M5306_IG06:        ; bbWeight=3.96, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref, isz
-       ; byrRegs -[rcx]
+						;; size=17 bbWeight=1.98 PerfScore 18.32
+G_M5306_IG06:        ; bbWeight=3.96, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[r8]
        dec      r9d
        cmp      r9d, eax
        jge      SHORT G_M5306_IG04
 						;; size=8 bbWeight=3.96 PerfScore 5.94
 G_M5306_IG07:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rdx]
-       ; byrRegs -[r8]
        jmp      SHORT G_M5306_IG11
 						;; size=2 bbWeight=1.98 PerfScore 3.96
 G_M5306_IG08:        ; bbWeight=0.04, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref, isz
@@ -108,27 +119,31 @@ G_M5306_IG08:        ; bbWeight=0.04, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8},
        jae      SHORT G_M5306_IG15
        mov      ecx, r9d
        shl      rcx, 4
-       lea      rcx, bword ptr [rdx+rcx+0x10]
-       ; byrRegs +[rcx]
-       movzx    r10, byte  ptr [r8]
+       lea      r10, bword ptr [rdx+rcx+0x10]
+       ; byrRegs +[r10]
+       movzx    rcx, byte  ptr [r8]
+       mov      esi, ecx
        mov      r11d, dword ptr [r8+0x04]
-       mov      ebx, dword ptr [r8+0x08]
-       mov      esi, dword ptr [r8+0x0C]
-       movzx    rdi, byte  ptr [rcx]
-       mov      ebp, dword ptr [rcx+0x04]
-       cmp      dil, r10b
+       mov      edi, r11d
+       mov      r11d, dword ptr [r8+0x08]
+       mov      ebp, r11d
+       mov      ebx, dword ptr [r8+0x0C]
+       mov      r14d, ebx
+       movzx    r15, byte  ptr [r10]
+       mov      r13d, dword ptr [r10+0x04]
+       cmp      r15b, sil
        jne      SHORT G_M5306_IG10
-						;; size=46 bbWeight=0.04 PerfScore 0.76
-G_M5306_IG09:        ; bbWeight=0.02, gcrefRegs=0004 {rdx}, byrefRegs=0102 {rcx r8}, byref, isz
-       cmp      ebp, r11d
+						;; size=58 bbWeight=0.04 PerfScore 0.80
+G_M5306_IG09:        ; bbWeight=0.02, gcrefRegs=0004 {rdx}, byrefRegs=0500 {r8 r10}, byref, isz
+       cmp      r13d, edi
        jne      SHORT G_M5306_IG10
-       cmp      dword ptr [rcx+0x08], ebx
+       cmp      dword ptr [r10+0x08], ebp
        jne      SHORT G_M5306_IG10
-       cmp      dword ptr [rcx+0x0C], esi
+       cmp      dword ptr [r10+0x0C], r14d
        je       SHORT G_M5306_IG13
-						;; size=15 bbWeight=0.02 PerfScore 0.19
+						;; size=17 bbWeight=0.02 PerfScore 0.19
 G_M5306_IG10:        ; bbWeight=0.04, gcrefRegs=0004 {rdx}, byrefRegs=0100 {r8}, byref, isz
-       ; byrRegs -[rcx]
+       ; byrRegs -[r10]
        dec      r9d
        cmp      r9d, eax
        jge      SHORT G_M5306_IG08
@@ -139,31 +154,37 @@ G_M5306_IG11:        ; bbWeight=1.98, gcrefRegs=0000 {}, byrefRegs=0000 {}, byre
        mov      eax, -1
 						;; size=5 bbWeight=1.98 PerfScore 0.49
 G_M5306_IG12:        ; bbWeight=1.98, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r13
+       pop      r14
+       pop      r15
        ret      
-						;; size=9 bbWeight=1.98 PerfScore 6.44
+						;; size=15 bbWeight=1.98 PerfScore 9.41
 G_M5306_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, r9d
 						;; size=3 bbWeight=0.50 PerfScore 0.12
 G_M5306_IG14:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r13
+       pop      r14
+       pop      r15
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=15 bbWeight=0.50 PerfScore 2.38
 G_M5306_IG15:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 210, prolog size 8, PerfScore 108.67, instruction count 76, allocated bytes for code 210 (MethodHash=1ea6eb45) for method System.Collections.Generic.GenericEqualityComparer`1[System.Formats.Asn1.AsnWriter+StackFrame]:LastIndexOf(System.Formats.Asn1.AsnWriter+StackFrame[],System.Formats.Asn1.AsnWriter+StackFrame,int,int):int:this (FullOpts)
+; Total bytes of code 259, prolog size 14, PerfScore 91.71, instruction count 93, allocated bytes for code 259 (MethodHash=1ea6eb45) for method System.Collections.Generic.GenericEqualityComparer`1[System.Formats.Asn1.AsnWriter+StackFrame]:LastIndexOf(System.Formats.Asn1.AsnWriter+StackFrame[],System.Formats.Asn1.AsnWriter+StackFrame,int,int):int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -171,13 +192,16 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x0E
+  CountOfUnwindCodes: 8
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
...

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+24.43%</span>) : 51900.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,105 +8,127 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T05] (  5, 14.92)     int  ->  rbx         single-def
+;  V00 arg0         [V00,T06] (  5, 11.42)     int  ->  rbx         single-def
 ;  V01 loc0         [V01,T03] (  7, 33.76)     ref  ->  rdi         class-hnd <<unknown class>>
-;  V02 loc1         [V02,T02] (  5, 35.76)     ref  ->  rbp         class-hnd exact <<unknown class>>
-;  V03 loc2         [V03,T01] (  7, 87.20)     int  ->  r14        
+;  V02 loc1         [V02,T02] (  5, 35.76)     ref  ->  r13         class-hnd exact <<unknown class>>
+;  V03 loc2         [V03,T01] (  7, 87.20)     int  ->  r12        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T00] (  3, 95.04)     ref  ->  rax         class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol>
-;  V06 cse0         [V06,T04] (  3, 23.84)     int  ->  r15         "CSE - aggressive"
-;  V07 cse1         [V07,T07] (  3,  9.92)    long  ->  rsi         "CSE - aggressive"
-;  V08 cse2         [V08,T06] (  3, 12   )     int  ->  r14         "CSE - aggressive"
+;  V06 cse0         [V06,T10] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V07 cse1         [V07,T04] (  3, 23.84)     int  ->  [rsp+0x34]  spill-single-def "CSE - aggressive"
+;  V08 cse2         [V08,T05] (  2, 16.84)    long  ->  [rsp+0x28]  spill-single-def hoist "CSE - aggressive"
+;  V09 cse3         [V09,T11] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
+;  V10 cse4         [V10,T09] (  2,  8.42)   byref  ->  r15         hoist "CSE - aggressive"
+;  V11 cse5         [V11,T08] (  3,  9.92)    long  ->  rsi         "CSE - aggressive"
+;  V12 cse6         [V12,T07] (  3, 12   )     int  ->  r12         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M65390_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
        mov      ebx, ecx
-						;; size=14 bbWeight=1 PerfScore 6.50
+						;; size=18 bbWeight=1 PerfScore 8.50
 G_M65390_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rsi, 0xD1FFAB1E      ; static handle
        mov      rdi, gword ptr [rsi]
        ; gcrRegs +[rdi]
        cmp      dword ptr [rdi+0x08], ebx
-       jge      G_M65390_IG06
+       jge      G_M65390_IG08
 						;; size=22 bbWeight=1 PerfScore 6.25
-G_M65390_IG03:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+G_M65390_IG03:        ; bbWeight=0.50, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
        lea      edx, [rbx+0x0F]
        and      edx, -16
-       movsxd   rdx, edx
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       movsxd   rbp, edx
+       mov      r14, 0xD1FFAB1E      ; <unknown class>
+       mov      r15, 0xD1FFAB1E      ; static handle
+       ; byrRegs +[r15]
+						;; size=29 bbWeight=0.50 PerfScore 0.75
+G_M65390_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=8000 {r15}, byref, isz
+       mov      rdx, rbp
+       mov      rcx, r14
        call     CORINFO_HELP_NEWARR_1_OBJ
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       mov      r14d, dword ptr [rdi+0x08]
-       mov      r8d, r14d
+       mov      r13, rax
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [rdi+0x08]
+       mov      r8d, r12d
        mov      rcx, rdi
        ; gcrRegs +[rcx]
-       mov      rdx, rbp
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-       mov      r15d, dword ptr [rbp+0x08]
-       cmp      r15d, r14d
-       jle      SHORT G_M65390_IG05
-						;; size=55 bbWeight=4 PerfScore 46.00
-G_M65390_IG04:        ; bbWeight=15.84, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
+       mov      eax, dword ptr [r13+0x08]
+       mov      dword ptr [rsp+0x34], eax
+       cmp      eax, r12d
+       jle      SHORT G_M65390_IG07
+						;; size=46 bbWeight=4 PerfScore 47.00
+G_M65390_IG05:        ; bbWeight=1, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref
+       mov      rdx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
+       mov      qword ptr [rsp+0x28], rdx
+						;; size=15 bbWeight=1 PerfScore 1.25
+G_M65390_IG06:        ; bbWeight=15.84, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref, isz
+       mov      rcx, rdx
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      dword ptr [rax+0x20], r14d
-       mov      ecx, r14d
-       lea      rcx, bword ptr [rbp+8*rcx+0x10]
+       mov      dword ptr [rax+0x20], r12d
+       mov      ecx, r12d
+       lea      rcx, bword ptr [r13+8*rcx+0x10]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
-       inc      r14d
-       cmp      r15d, r14d
-       jg       SHORT G_M65390_IG04
-						;; size=43 bbWeight=15.84 PerfScore 114.84
-G_M65390_IG05:        ; bbWeight=7.92, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0000 {}, byref, isz
+       inc      r12d
+       mov      r8d, dword ptr [rsp+0x34]
+       cmp      r8d, r12d
+       mov      rdx, qword ptr [rsp+0x28]
+       jg       SHORT G_M65390_IG06
+						;; size=46 bbWeight=15.84 PerfScore 146.52
+G_M65390_IG07:        ; bbWeight=7.92, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref
        mov      r8, rdi
        ; gcrRegs +[r8]
-       mov      rdx, rbp
+       mov      rdx, r13
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rcx, r15
        ; byrRegs +[rcx]
        call     <unknown method>
-       ; gcrRegs -[rdx rbp rdi r8] +[rax]
+       ; gcrRegs -[rdx rdi r8 r13] +[rax]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        mov      rdi, gword ptr [rsi]
        ; gcrRegs +[rdi]
        cmp      dword ptr [rdi+0x08], ebx
-       jl       SHORT G_M65390_IG03
-						;; size=29 bbWeight=7.92 PerfScore 61.38
-G_M65390_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       jl       G_M65390_IG04
+						;; size=26 bbWeight=7.92 PerfScore 61.38
+G_M65390_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rax rdi]
-       add      rsp, 40
+       ; byrRegs -[r15]
+       add      rsp, 56
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
 
-; Total bytes of code 176, prolog size 14, PerfScore 239.22, instruction count 51, allocated bytes for code 176 (MethodHash=ce860091) for method Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
+; Total bytes of code 219, prolog size 18, PerfScore 276.90, instruction count 63, allocated bytes for code 219 (MethodHash=ce860091) for method Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -114,15 +136,17 @@ Unwind Info:
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
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
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
<summary><span style="color:red">+43</span> (<span style="color:red">+24.43%</span>) : 7261.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,105 +8,127 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T05] (  5, 14.92)     int  ->  rbx         single-def
+;  V00 arg0         [V00,T06] (  5, 11.42)     int  ->  rbx         single-def
 ;  V01 loc0         [V01,T03] (  7, 33.76)     ref  ->  rdi         class-hnd <<unknown class>>
-;  V02 loc1         [V02,T02] (  5, 35.76)     ref  ->  rbp         class-hnd exact <<unknown class>>
-;  V03 loc2         [V03,T01] (  7, 87.20)     int  ->  r14        
+;  V02 loc1         [V02,T02] (  5, 35.76)     ref  ->  r13         class-hnd exact <<unknown class>>
+;  V03 loc2         [V03,T01] (  7, 87.20)     int  ->  r12        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T00] (  3, 95.04)     ref  ->  rax         class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol>
-;  V06 cse0         [V06,T04] (  3, 23.84)     int  ->  r15         "CSE - aggressive"
-;  V07 cse1         [V07,T07] (  3,  9.92)    long  ->  rsi         "CSE - aggressive"
-;  V08 cse2         [V08,T06] (  3, 12   )     int  ->  r14         "CSE - aggressive"
+;  V06 cse0         [V06,T10] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V07 cse1         [V07,T04] (  3, 23.84)     int  ->  [rsp+0x34]  spill-single-def "CSE - aggressive"
+;  V08 cse2         [V08,T05] (  2, 16.84)    long  ->  [rsp+0x28]  spill-single-def hoist "CSE - aggressive"
+;  V09 cse3         [V09,T11] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
+;  V10 cse4         [V10,T09] (  2,  8.42)   byref  ->  r15         hoist "CSE - aggressive"
+;  V11 cse5         [V11,T08] (  3,  9.92)    long  ->  rsi         "CSE - aggressive"
+;  V12 cse6         [V12,T07] (  3, 12   )     int  ->  r12         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M65390_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
        mov      ebx, ecx
-						;; size=14 bbWeight=1 PerfScore 6.50
+						;; size=18 bbWeight=1 PerfScore 8.50
 G_M65390_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rsi, 0xD1FFAB1E      ; static handle
        mov      rdi, gword ptr [rsi]
        ; gcrRegs +[rdi]
        cmp      dword ptr [rdi+0x08], ebx
-       jge      G_M65390_IG06
+       jge      G_M65390_IG08
 						;; size=22 bbWeight=1 PerfScore 6.25
-G_M65390_IG03:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+G_M65390_IG03:        ; bbWeight=0.50, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
        lea      edx, [rbx+0x0F]
        and      edx, -16
-       movsxd   rdx, edx
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       movsxd   rbp, edx
+       mov      r14, 0xD1FFAB1E      ; <unknown class>
+       mov      r15, 0xD1FFAB1E      ; static handle
+       ; byrRegs +[r15]
+						;; size=29 bbWeight=0.50 PerfScore 0.75
+G_M65390_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=8000 {r15}, byref, isz
+       mov      rdx, rbp
+       mov      rcx, r14
        call     CORINFO_HELP_NEWARR_1_OBJ
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       mov      r14d, dword ptr [rdi+0x08]
-       mov      r8d, r14d
+       mov      r13, rax
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [rdi+0x08]
+       mov      r8d, r12d
        mov      rcx, rdi
        ; gcrRegs +[rcx]
-       mov      rdx, rbp
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-       mov      r15d, dword ptr [rbp+0x08]
-       cmp      r15d, r14d
-       jle      SHORT G_M65390_IG05
-						;; size=55 bbWeight=4 PerfScore 46.00
-G_M65390_IG04:        ; bbWeight=15.84, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
+       mov      eax, dword ptr [r13+0x08]
+       mov      dword ptr [rsp+0x34], eax
+       cmp      eax, r12d
+       jle      SHORT G_M65390_IG07
+						;; size=46 bbWeight=4 PerfScore 47.00
+G_M65390_IG05:        ; bbWeight=1, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref
+       mov      rdx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
+       mov      qword ptr [rsp+0x28], rdx
+						;; size=15 bbWeight=1 PerfScore 1.25
+G_M65390_IG06:        ; bbWeight=15.84, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref, isz
+       mov      rcx, rdx
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      dword ptr [rax+0x20], r14d
-       mov      ecx, r14d
-       lea      rcx, bword ptr [rbp+8*rcx+0x10]
+       mov      dword ptr [rax+0x20], r12d
+       mov      ecx, r12d
+       lea      rcx, bword ptr [r13+8*rcx+0x10]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
-       inc      r14d
-       cmp      r15d, r14d
-       jg       SHORT G_M65390_IG04
-						;; size=43 bbWeight=15.84 PerfScore 114.84
-G_M65390_IG05:        ; bbWeight=7.92, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0000 {}, byref, isz
+       inc      r12d
+       mov      r8d, dword ptr [rsp+0x34]
+       cmp      r8d, r12d
+       mov      rdx, qword ptr [rsp+0x28]
+       jg       SHORT G_M65390_IG06
+						;; size=46 bbWeight=15.84 PerfScore 146.52
+G_M65390_IG07:        ; bbWeight=7.92, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref
        mov      r8, rdi
        ; gcrRegs +[r8]
-       mov      rdx, rbp
+       mov      rdx, r13
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rcx, r15
        ; byrRegs +[rcx]
        call     <unknown method>
-       ; gcrRegs -[rdx rbp rdi r8] +[rax]
+       ; gcrRegs -[rdx rdi r8 r13] +[rax]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        mov      rdi, gword ptr [rsi]
        ; gcrRegs +[rdi]
        cmp      dword ptr [rdi+0x08], ebx
-       jl       SHORT G_M65390_IG03
-						;; size=29 bbWeight=7.92 PerfScore 61.38
-G_M65390_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       jl       G_M65390_IG04
+						;; size=26 bbWeight=7.92 PerfScore 61.38
+G_M65390_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rax rdi]
-       add      rsp, 40
+       ; byrRegs -[r15]
+       add      rsp, 56
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
 
-; Total bytes of code 176, prolog size 14, PerfScore 239.22, instruction count 51, allocated bytes for code 176 (MethodHash=ce860091) for method Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
+; Total bytes of code 219, prolog size 18, PerfScore 276.90, instruction count 63, allocated bytes for code 219 (MethodHash=ce860091) for method Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -114,15 +136,17 @@ Unwind Info:
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
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
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
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-29</span> (<span style="color:green">-16.29%</span>) : 11477.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,FSharp.Compiler.Text.Range](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,106 +8,94 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T05] (  5,  7.80)    long  ->  rbx         single-def
-;  V01 arg0         [V01,T08] (  3,  6   )     ref  ->  rdi         class-hnd single-def <System.Collections.Generic.IComparer`1[System.__Canon]>
-;  V02 arg1         [V02,T06] (  4,  7   )     ref  ->  rsi         class-hnd single-def <System.__Canon[]>
-;  V03 loc0         [V03,T07] (  3,  9   )     ref  ->  rbp         must-init class-hnd <Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range]>
-;  V04 loc1         [V04,T01] (  5, 17   )     int  ->  r14        
-;  V05 loc2         [V05,T02] (  4, 16   )     ref  ->  rcx         class-hnd <System.Tuple`2[System.__Canon,FSharp.Compiler.Text.Range]>
+;  V00 TypeCtx      [V00,T10] (  5,  3.60)    long  ->  rcx         single-def
+;  V01 arg0         [V01,T05] (  3,  6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IComparer`1[System.__Canon]>
+;  V02 arg1         [V02,T03] (  4,  7   )     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
+;  V03 loc0         [V03,T04] (  3,  9   )     ref  ->  rdi         must-init class-hnd <Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range]>
+;  V04 loc1         [V04,T00] (  5, 17   )     int  ->  rbp        
+;  V05 loc2         [V05,T01] (  4, 16   )     ref  ->  rcx         class-hnd <System.Tuple`2[System.__Canon,FSharp.Compiler.Text.Range]>
 ;* V06 loc3         [V06    ] (  0,  0   )  struct (16) zero-ref    <FSharp.Compiler.Text.Range>
-;  V07 loc4         [V07,T09] (  2,  8   )     ref  ->  [rsp+0x28]  class-hnd spill-single-def <System.__Canon>
+;  V07 loc4         [V07,T06] (  2,  8   )     ref  ->  rdx         class-hnd <System.__Canon>
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V10 tmp2         [V10,T10] (  2,  8   )    long  ->  r13         "field V06.code1 (fldOffset=0x0)" P-INDEP
-;  V11 tmp3         [V11,T11] (  2,  8   )    long  ->  r12         "field V06.code2 (fldOffset=0x8)" P-INDEP
+;  V10 tmp2         [V10,T07] (  2,  8   )    long  ->   r9         "field V06.code1 (fldOffset=0x0)" P-INDEP
+;  V11 tmp3         [V11,T08] (  2,  8   )    long  ->   r8         "field V06.code2 (fldOffset=0x8)" P-INDEP
 ;  V12 tmp4         [V12    ] (  3, 24   )  struct (16) [rsp+0x30]  do-not-enreg[XSF] addr-exposed "by-value struct argument" <FSharp.Compiler.Text.Range>
-;  V13 tmp5         [V13,T04] (  2, 16   )    long  ->  rcx         "argument with side effect"
-;  V14 cse0         [V14,T12] (  3,  6   )     int  ->  r15         "CSE - aggressive"
-;  V15 rat0         [V15,T03] (  3, 16   )    long  ->  rcx         "runtime lookup"
-;  V16 rat1         [V16,T00] (  3, 22.40)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V13 tmp5         [V13,T02] (  2, 16   )    long  ->  rcx         "argument with side effect"
+;  V14 cse0         [V14,T11] (  2,  4.50)    long  ->  r15         hoist "CSE - aggressive"
+;  V15 cse1         [V15,T09] (  3,  6   )     int  ->  r14         "CSE - aggressive"
+;  V16 rat0         [V16,T13] (  3,  2   )    long  ->  r15         "runtime lookup"
+;  V17 rat1         [V17,T12] (  3,  2.80)    long  ->  r15         "fgMakeTemp is creating a new local variable"
 ;
 ; Lcl frame size = 72
 
 G_M19261_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
-       push     r13
-       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
        sub      rsp, 72
        mov      qword ptr [rsp+0x40], rcx
-       mov      rbx, rcx
-       mov      rdi, rdx
-       ; gcrRegs +[rdi]
-       mov      rsi, r8
+       mov      rsi, rdx
        ; gcrRegs +[rsi]
+       mov      rbx, r8
+       ; gcrRegs +[rbx]
+       xor      edi, edi
+						;; size=25 bbWeight=1 PerfScore 8.00
+G_M19261_IG02:        ; bbWeight=1, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rdi]
        xor      ebp, ebp
-						;; size=32 bbWeight=1 PerfScore 10.25
-G_M19261_IG02:        ; bbWeight=1, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs +[rbp]
-       xor      r14d, r14d
-       mov      r15d, dword ptr [rsi+0x08]
-       test     r15d, r15d
+       mov      r14d, dword ptr [rbx+0x08]
+       test     r14d, r14d
        jle      SHORT G_M19261_IG07
-						;; size=12 bbWeight=1 PerfScore 3.50
-G_M19261_IG03:        ; bbWeight=4, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      ecx, r14d
-       mov      rcx, gword ptr [rsi+8*rcx+0x10]
-       ; gcrRegs +[rcx]
-       mov      r13, qword ptr [rcx+0x10]
-       mov      r12, qword ptr [rcx+0x18]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       mov      gword ptr [rsp+0x28], rax
-       ; GC ptr vars +{V07}
-       mov      rcx, qword ptr [rbx+0x38]
-       ; gcrRegs -[rcx]
-       mov      rcx, qword ptr [rcx+0x18]
-       test     rcx, rcx
+						;; size=11 bbWeight=1 PerfScore 3.50
+G_M19261_IG03:        ; bbWeight=0.50, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rdx, qword ptr [rcx+0x38]
+       mov      r15, qword ptr [rdx+0x18]
+       test     r15, r15
        je       SHORT G_M19261_IG05
-						;; size=38 bbWeight=4 PerfScore 58.00
-G_M19261_IG04:        ; bbWeight=3.20, gcVars=0000000000000200 {V07}, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs -[rax]
-       mov      rax, gword ptr [rsp+0x28]
-       ; gcrRegs +[rax]
+						;; size=13 bbWeight=0.50 PerfScore 2.62
+G_M19261_IG04:        ; bbWeight=0.40, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M19261_IG06
-						;; size=7 bbWeight=3.20 PerfScore 9.60
-G_M19261_IG05:        ; bbWeight=0.80, gcrefRegs=00E0 {rbp rsi rdi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rcx, rbx
+						;; size=2 bbWeight=0.40 PerfScore 0.80
+G_M19261_IG05:        ; bbWeight=0.10, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rcx, rax
-       mov      rax, gword ptr [rsp+0x28]
-       ; gcrRegs +[rax]
-						;; size=26 bbWeight=0.80 PerfScore 2.20
-G_M19261_IG06:        ; bbWeight=4, gcrefRegs=00E1 {rax rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       mov      qword ptr [rsp+0x30], r13
-       mov      qword ptr [rsp+0x38], r12
-       mov      gword ptr [rsp+0x20], rbp
+       mov      r15, rax
+						;; size=18 bbWeight=0.10 PerfScore 0.15
+G_M19261_IG06:        ; bbWeight=4, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref, isz
+       mov      ecx, ebp
+       mov      rcx, gword ptr [rbx+8*rcx+0x10]
+       ; gcrRegs +[rcx]
+       mov      r9, qword ptr [rcx+0x10]
+       mov      r8, qword ptr [rcx+0x18]
+       mov      rdx, gword ptr [rcx+0x08]
+       ; gcrRegs +[rdx]
+       mov      rcx, r15
+       ; gcrRegs -[rcx]
+       mov      qword ptr [rsp+0x30], r9
+       mov      qword ptr [rsp+0x38], r8
+       mov      gword ptr [rsp+0x20], rdi
        ; gcr arg write
        lea      r9, [rsp+0x30]
-       mov      r8, rax
+       mov      r8, rdx
        ; gcrRegs +[r8]
-       mov      rdx, rdi
-       ; gcrRegs +[rdx]
-       ; GC ptr vars -{V07}
+       mov      rdx, rsi
        call     [<unknown method>]
-       ; gcrRegs -[rdx rbp r8]
+       ; gcrRegs -[rdx rdi r8] +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       inc      r14d
-       cmp      r15d, r14d
-       jg       SHORT G_M19261_IG03
-						;; size=43 bbWeight=4 PerfScore 35.00
-G_M19261_IG07:        ; bbWeight=1, gcrefRegs=0020 {rbp}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rsi rdi]
-       mov      rax, rbp
+       mov      rdi, rax
+       ; gcrRegs +[rdi]
+       inc      ebp
+       cmp      r14d, ebp
+       jg       SHORT G_M19261_IG06
+						;; size=64 bbWeight=4 PerfScore 69.00
+G_M19261_IG07:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax rbx rsi]
+       mov      rax, rdi
        ; gcrRegs +[rax]
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M19261_IG08:        ; bbWeight=1, epilog, nogc, extend
@@ -116,14 +104,12 @@ G_M19261_IG08:        ; bbWeight=1, epilog, nogc, extend
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r12
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=17 bbWeight=1 PerfScore 5.25
+						;; size=13 bbWeight=1 PerfScore 4.25
 
-; Total bytes of code 178, prolog size 21, PerfScore 124.05, instruction count 57, allocated bytes for code 178 (MethodHash=2495b4c2) for method Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,FSharp.Compiler.Text.Range](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range] (FullOpts)
+; Total bytes of code 149, prolog size 17, PerfScore 88.58, instruction count 49, allocated bytes for code 149 (MethodHash=2495b4c2) for method Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,FSharp.Compiler.Text.Range](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -131,17 +117,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x10
-  CountOfUnwindCodes: 9
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
-    CodeOffset: 0x0C UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x0B UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r12 (12)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 8 * 8 + 8 = 72 = 0x48
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:green">-34</span> (<span style="color:green">-12.64%</span>) : 25795.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,132 +8,134 @@
 ; 0 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T08] (  5,  8.44)    long  ->  rbx         single-def
-;  V01 arg0         [V01,T09] (  3,  3   )     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V02 loc0         [V02    ] ( 11, 29   )  struct (16) [rsp+0x78]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V03 loc1         [V03    ] (  2,  8   )  struct (80) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
+;  V00 TypeCtx      [V00,T05] (  5,  3.68)    long  ->  rbx         single-def
+;  V01 arg0         [V01,T06] (  3,  3   )     ref  ->  rcx         class-hnd single-def <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V02 loc0         [V02    ] ( 11, 29   )  struct (16) [rsp+0x70]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V03 loc1         [V03    ] (  2,  8   )  struct (80) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V06 tmp2         [V06    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V07 tmp3         [V07    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V08 tmp4         [V08,T05] (  2, 16   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V09 tmp5         [V09,T06] (  2, 16   )     int  ->   r8         "Inlining Arg"
-;  V10 tmp6         [V10,T02] (  4, 20   )     int  ->  rsi         "impAppendStmt"
-;  V11 tmp7         [V11,T01] (  4, 20   )     ref  ->  rdi         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V08 tmp4         [V08,T02] (  2, 16   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V09 tmp5         [V09,T03] (  2, 16   )     int  ->   r8         "Inlining Arg"
+;  V10 tmp6         [V10,T01] (  4, 20   )     int  ->  rsi         "impAppendStmt"
+;  V11 tmp7         [V11,T00] (  4, 20   )     ref  ->  rdi         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;* V12 tmp8         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V13 tmp9         [V13    ] (  4, 10   )     ref  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V02._builder (fldOffset=0x0)" P-DEP
-;  V14 tmp10        [V14    ] (  8, 20   )     int  ->  [rsp+0x80]  do-not-enreg[X] addr-exposed "field V02._index (fldOffset=0x8)" P-DEP
-;  V15 tmp11        [V15,T07] (  2, 16   )    long  ->  rdx         "argument with side effect"
-;  V16 rat0         [V16,T04] (  3, 16   )    long  ->  rdx         "runtime lookup"
-;  V17 rat1         [V17,T00] (  3, 22.40)    long  ->  rcx         "spilling expr"
-;  V18 rat2         [V18,T03] (  3, 17.92)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V13 tmp9         [V13    ] (  4, 10   )     ref  ->  [rsp+0x70]  do-not-enreg[X] addr-exposed "field V02._builder (fldOffset=0x0)" P-DEP
+;  V14 tmp10        [V14    ] (  8, 20   )     int  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V02._index (fldOffset=0x8)" P-DEP
+;  V15 tmp11        [V15,T04] (  2, 16   )    long  ->  rdx         "argument with side effect"
+;  V16 cse0         [V16,T07] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V17 rat0         [V17,T10] (  3,  2   )    long  ->  rbp         "runtime lookup"
+;  V18 rat1         [V18,T08] (  3,  2.80)    long  ->  rcx         "spilling expr"
+;  V19 rat2         [V19,T09] (  3,  2.24)    long  ->  rbp         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 144
+; Lcl frame size = 136
 
 G_M49884_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
-       sub      rsp, 144
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 136
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       vmovdqu  ymmword ptr [rsp+0x50], ymm4
-       vmovdqa  xmmword ptr [rsp+0x70], xmm4
-       mov      qword ptr [rsp+0x80], rax
-       mov      qword ptr [rsp+0x88], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqu  ymmword ptr [rsp+0x40], ymm4
+       vmovdqu  ymmword ptr [rsp+0x60], ymm4
+       mov      qword ptr [rsp+0x80], rcx
        mov      rbx, rcx
        mov      rcx, rdx
        ; gcrRegs +[rcx]
-						;; size=61 bbWeight=1 PerfScore 13.33
-G_M49884_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       lea      rdx, [rsp+0x78]
+						;; size=47 bbWeight=1 PerfScore 12.08
+G_M49884_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       lea      rdx, [rsp+0x70]
        cmp      dword ptr [rcx], ecx
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:GetEnumerator():Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      ecx, dword ptr [rsp+0x80]
+       mov      ecx, dword ptr [rsp+0x78]
        inc      ecx
-       mov      dword ptr [rsp+0x80], ecx
-       mov      esi, dword ptr [rsp+0x80]
-       mov      rdi, gword ptr [rsp+0x78]
+       mov      dword ptr [rsp+0x78], ecx
+       mov      esi, dword ptr [rsp+0x78]
+       mov      rdi, gword ptr [rsp+0x70]
        ; gcrRegs +[rdi]
        mov      rcx, gword ptr [rdi+0x08]
        ; gcrRegs +[rcx]
        cmp      esi, dword ptr [rcx+0x10]
-       jge      G_M49884_IG08
-						;; size=54 bbWeight=1 PerfScore 16.75
-G_M49884_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jge      SHORT G_M49884_IG08
+						;; size=41 bbWeight=1 PerfScore 16.75
+G_M49884_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rcx rdi]
-       mov      rcx, gword ptr [rsp+0x78]
-       ; gcrRegs +[rcx]
-       mov      r8d, dword ptr [rsp+0x80]
-       mov      rcx, gword ptr [rcx+0x08]
-       lea      rdx, [rsp+0x28]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
        mov      rcx, qword ptr [rbx+0x38]
        cmp      qword ptr [rcx+0x08], 24
        jle      SHORT G_M49884_IG06
-						;; size=41 bbWeight=4 PerfScore 66.00
-G_M49884_IG04:        ; bbWeight=3.20, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rdx, qword ptr [rcx+0x18]
-       test     rdx, rdx
+						;; size=11 bbWeight=0.50 PerfScore 3.00
+G_M49884_IG04:        ; bbWeight=0.40, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rbp, qword ptr [rcx+0x18]
+       test     rbp, rbp
        je       SHORT G_M49884_IG06
-						;; size=9 bbWeight=3.20 PerfScore 10.40
-G_M49884_IG05:        ; bbWeight=2.56, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=9 bbWeight=0.40 PerfScore 1.30
+G_M49884_IG05:        ; bbWeight=0.32, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M49884_IG07
-						;; size=2 bbWeight=2.56 PerfScore 5.12
-G_M49884_IG06:        ; bbWeight=1.44, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=2 bbWeight=0.32 PerfScore 0.64
+G_M49884_IG06:        ; bbWeight=0.18, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rcx, rbx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rdx, rax
-						;; size=21 bbWeight=1.44 PerfScore 2.52
+       mov      rbp, rax
+						;; size=21 bbWeight=0.18 PerfScore 0.32
 G_M49884_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       lea      rcx, [rsp+0x28]
+       mov      rcx, gword ptr [rsp+0x70]
+       ; gcrRegs +[rcx]
+       mov      r8d, dword ptr [rsp+0x78]
+       mov      rcx, gword ptr [rcx+0x08]
+       lea      rdx, [rsp+0x20]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:get_Item(int):Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:this]
+       ; gcrRegs -[rcx]
+       ; gcr arg pop 0
+       mov      rdx, rbp
+       lea      rcx, [rsp+0x20]
        call     [Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]:get_IsValid():ubyte:this]
        ; gcr arg pop 0
        test     eax, eax
        jne      SHORT G_M49884_IG10
-       mov      eax, dword ptr [rsp+0x80]
+       mov      eax, dword ptr [rsp+0x78]
        inc      eax
-       mov      dword ptr [rsp+0x80], eax
-       mov      esi, dword ptr [rsp+0x80]
-       mov      rdi, gword ptr [rsp+0x78]
+       mov      dword ptr [rsp+0x78], eax
+       mov      esi, dword ptr [rsp+0x78]
+       mov      rdi, gword ptr [rsp+0x70]
        ; gcrRegs +[rdi]
        mov      rax, gword ptr [rdi+0x08]
        ; gcrRegs +[rax]
        cmp      esi, dword ptr [rax+0x10]
-       jl       SHORT G_M49884_IG03
-						;; size=52 bbWeight=4 PerfScore 60.00
+       jl       SHORT G_M49884_IG07
+						;; size=73 bbWeight=4 PerfScore 103.00
 G_M49884_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rdi]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M49884_IG09:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 144
+       add      rsp, 136
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.38
+						;; size=12 bbWeight=0.50 PerfScore 1.62
 G_M49884_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M49884_IG11:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 144
+       add      rsp, 136
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.38
+						;; size=12 bbWeight=0.50 PerfScore 1.62
 
-; Total bytes of code 269, prolog size 55, PerfScore 177.12, instruction count 66, allocated bytes for code 269 (MethodHash=d42f3d23) for method Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
+; Total bytes of code 235, prolog size 41, PerfScore 140.59, instruction count 67, allocated bytes for code 235 (MethodHash=d42f3d23) for method Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -141,13 +143,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x0B
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 18 * 8 = 144 = 0x00090
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x0B UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:green">-23</span> (<span style="color:green">-7.37%</span>) : 21419.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 8 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 TypeCtx      [V00,T04] (  5,  7.80)    long  ->  rsi         single-def
-;  V01 arg0         [V01,T13] (  4,  4   )     ref  ->  rdx         class-hnd single-def <System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object]>
-;  V02 arg1         [V02,T03] (  4, 10   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]>
-;  V03 loc0         [V03    ] ( 11, 26   )  struct (48) [rsp+0x68]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Collections.Generic.Dictionary`2+Enumerator[System.ReadOnlyMemory`1[ushort],System.Object]>
+;  V00 TypeCtx      [V00,T12] (  5,  3.60)    long  ->  rsi         single-def
+;  V01 arg0         [V01,T10] (  4,  4   )     ref  ->  rdx         class-hnd single-def <System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object]>
+;  V02 arg1         [V02,T01] (  4, 10   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]>
+;  V03 loc0         [V03    ] ( 11, 26   )  struct (48) [rsp+0x60]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Collections.Generic.Dictionary`2+Enumerator[System.ReadOnlyMemory`1[ushort],System.Object]>
 ;* V04 loc1         [V04    ] (  0,  0   )  struct (16) zero-ref    <System.ReadOnlyMemory`1[ushort]>
 ;* V05 loc2         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Object>
 ;* V06 loc3         [V06    ] (  0,  0   )  struct (24) zero-ref    do-not-enreg[SF] ld-addr-op <System.Collections.Generic.KeyValuePair`2[System.ReadOnlyMemory`1[ushort],System.Object]>
@@ -20,68 +20,65 @@
 ;  V09 OutArgs      [V09    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V10 tmp1         [V10    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V11 tmp2         [V11    ] (  0,  0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.Collections.Immutable.ImmutableArray`1[System.__Canon]>
-;  V12 tmp3         [V12,T16] (  1,  2   )  struct (48) [rsp+0x38]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.ReadOnlyMemory`1[ushort],System.Object]>
+;  V12 tmp3         [V12,T17] (  1,  2   )  struct (48) [rsp+0x30]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.ReadOnlyMemory`1[ushort],System.Object]>
 ;* V13 tmp4         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V14 tmp5         [V14    ] (  0,  0   )     ref  ->  zero-ref    "field V04._object (fldOffset=0x0)" P-INDEP
 ;* V15 tmp6         [V15    ] (  0,  0   )     int  ->  zero-ref    "field V04._index (fldOffset=0x8)" P-INDEP
 ;* V16 tmp7         [V16    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0xc)" P-INDEP
-;  V17 tmp8         [V17,T05] (  2,  8   )     ref  ->  r14         "field V07._object (fldOffset=0x0)" P-INDEP
-;  V18 tmp9         [V18,T09] (  2,  8   )     int  ->  r15         "field V07._index (fldOffset=0x8)" P-INDEP
-;  V19 tmp10        [V19,T10] (  2,  8   )     int  ->  r13         "field V07._length (fldOffset=0xc)" P-INDEP
-;  V20 tmp11        [V20,T06] (  2,  8   )     ref  ->   r8         "field V11.array (fldOffset=0x0)" P-INDEP
-;  V21 tmp12        [V21,T07] (  2,  8   )     ref  ->  rbp         "V06.[000..008)"
-;  V22 tmp13        [V22,T08] (  2,  8   )     ref  ->  r14         "V06.[008..016)"
-;  V23 tmp14        [V23,T11] (  2,  8   )     int  ->  r15         "V06.[016..020)"
-;  V24 tmp15        [V24,T12] (  2,  8   )     int  ->  r13         "V06.[020..024)"
+;  V17 tmp8         [V17,T02] (  2,  8   )     ref  ->  rsi         "field V07._object (fldOffset=0x0)" P-INDEP
+;  V18 tmp9         [V18,T06] (  2,  8   )     int  ->  r14         "field V07._index (fldOffset=0x8)" P-INDEP
+;  V19 tmp10        [V19,T07] (  2,  8   )     int  ->  r15         "field V07._length (fldOffset=0xc)" P-INDEP
+;  V20 tmp11        [V20,T03] (  2,  8   )     ref  ->   r8         "field V11.array (fldOffset=0x0)" P-INDEP
+;  V21 tmp12        [V21,T04] (  2,  8   )     ref  ->  rdx         "V06.[000..008)"
+;  V22 tmp13        [V22,T05] (  2,  8   )     ref  ->  rsi         "V06.[008..016)"
+;  V23 tmp14        [V23,T08] (  2,  8   )     int  ->  r14         "V06.[016..020)"
+;  V24 tmp15        [V24,T09] (  2,  8   )     int  ->  r15         "V06.[020..024)"
 ;* V25 tmp16        [V25    ] (  0,  0   )     ref  ->  zero-ref    single-def "V12.[000..008)"
-;  V26 tmp17        [V26,T15] (  2,  2   )     int  ->  rcx         single-def "V12.[008..012)"
+;  V26 tmp17        [V26,T16] (  2,  2   )     int  ->  rcx         single-def "V12.[008..012)"
 ;* V27 tmp18        [V27    ] (  0,  0   )     int  ->  zero-ref    single-def "V12.[012..016)"
 ;* V28 tmp19        [V28    ] (  0,  0   )     int  ->  zero-ref    single-def "V12.[016..020)"
-;  V29 tmp20        [V29,T02] (  2, 16   )    long  ->  rcx         "argument with side effect"
-;  V30 tmp21        [V30    ] (  4, 32   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlyMemory`1[ushort]>
-;  V31 cse0         [V31,T14] (  3,  6   )    long  ->  rdi         "CSE - aggressive"
-;  V32 rat0         [V32,T01] (  3, 16   )    long  ->  rcx         "runtime lookup"
-;  V33 rat1         [V33,T00] (  3, 22.40)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V29 tmp20        [V29,T00] (  2, 16   )    long  ->  rcx         "argument with side effect"
+;  V30 tmp21        [V30    ] (  4, 32   )  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlyMemory`1[ushort]>
+;  V31 cse0         [V31,T13] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V32 cse1         [V32,T11] (  3,  6   )    long  ->  rdi         "CSE - aggressive"
+;  V33 rat0         [V33,T15] (  3,  2   )    long  ->  rbp         "runtime lookup"
+;  V34 rat1         [V34,T14] (  3,  2.80)    long  ->  rbp         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 160
+; Lcl frame size = 152
 
 G_M20920_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 160
-       xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       sub      rsp, 152
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x30], ymm4
-       vmovdqa  xmmword ptr [rsp+0x50], xmm4
-       mov      qword ptr [rsp+0x60], rax
-       mov      qword ptr [rsp+0x98], rcx
+       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqu  ymmword ptr [rsp+0x40], ymm4
+       mov      qword ptr [rsp+0x90], rcx
        mov      rsi, rcx
        mov      rbx, r8
        ; gcrRegs +[rbx]
-						;; size=59 bbWeight=1 PerfScore 15.33
+						;; size=45 bbWeight=1 PerfScore 12.08
 G_M20920_IG02:        ; bbWeight=1, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
        mov      ecx, dword ptr [rdx+0x44]
 						;; size=3 bbWeight=1 PerfScore 2.00
 G_M20920_IG03:        ; bbWeight=1, nogc, extend
-       vmovdqu  ymm0, ymmword ptr [rsp+0x38]
-       vmovdqu  ymmword ptr [rsp+0x68], ymm0
-       vmovdqu  xmm0, xmmword ptr [rsp+0x58]
-       vmovdqu  xmmword ptr [rsp+0x88], xmm0
+       vmovdqu  ymm0, ymmword ptr [rsp+0x30]
+       vmovdqu  ymmword ptr [rsp+0x60], ymm0
+       vmovdqu  xmm0, xmmword ptr [rsp+0x50]
+       vmovdqu  xmmword ptr [rsp+0x80], xmm0
 						;; size=27 bbWeight=1 PerfScore 9.00
 G_M20920_IG04:        ; bbWeight=1, extend
-       mov      gword ptr [rsp+0x68], rdx
-       mov      dword ptr [rsp+0x70], ecx
+       mov      gword ptr [rsp+0x60], rdx
+       mov      dword ptr [rsp+0x68], ecx
        xor      ecx, ecx
-       mov      dword ptr [rsp+0x74], ecx
-       mov      dword ptr [rsp+0x78], 2
-       lea      rcx, [rsp+0x68]
+       mov      dword ptr [rsp+0x6C], ecx
+       mov      dword ptr [rsp+0x70], 2
+       lea      rcx, [rsp+0x60]
        mov      rdi, 0xD1FFAB1E      ; System.Collections.Generic.Dictionary`2+Enumerator[System.ReadOnlyMemory`1[ushort],System.Object]
        mov      rdx, rdi
        ; gcrRegs -[rdx]
@@ -90,72 +87,70 @@ G_M20920_IG04:        ; bbWeight=1, extend
        test     eax, eax
        je       G_M20920_IG09
 						;; size=55 bbWeight=1 PerfScore 9.50
-G_M20920_IG05:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rbp, gword ptr [rsp+0x80]
-       ; gcrRegs +[rbp]
-       mov      r14, gword ptr [rsp+0x88]
-       ; gcrRegs +[r14]
-       mov      r15d, dword ptr [rsp+0x90]
-       mov      r13d, dword ptr [rsp+0x94]
+G_M20920_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, qword ptr [rsi+0x38]
-       mov      rcx, qword ptr [rcx+0x28]
-       test     rcx, rcx
+       mov      rbp, qword ptr [rcx+0x28]
+       test     rbp, rbp
        je       SHORT G_M20920_IG07
-						;; size=45 bbWeight=4 PerfScore 37.00
-G_M20920_IG06:        ; bbWeight=3.20, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref, isz
+						;; size=13 bbWeight=0.50 PerfScore 2.62
+G_M20920_IG06:        ; bbWeight=0.40, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M20920_IG08
-						;; size=2 bbWeight=3.20 PerfScore 6.40
-G_M20920_IG07:        ; bbWeight=0.80, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref
+						;; size=2 bbWeight=0.40 PerfScore 0.80
+G_M20920_IG07:        ; bbWeight=0.10, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rcx, rsi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_METHOD
        ; gcr arg pop 0
-       mov      rcx, rax
-						;; size=21 bbWeight=0.80 PerfScore 1.40
-G_M20920_IG08:        ; bbWeight=4, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref
-       mov      rdx, rbp
+       mov      rbp, rax
+						;; size=21 bbWeight=0.10 PerfScore 0.18
+G_M20920_IG08:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rdx, gword ptr [rsp+0x78]
        ; gcrRegs +[rdx]
+       mov      rsi, gword ptr [rsp+0x80]
+       ; gcrRegs +[rsi]
+       mov      r14d, dword ptr [rsp+0x88]
+       mov      r15d, dword ptr [rsp+0x8C]
+       mov      rcx, rbp
        call     [Microsoft.CodeAnalysis.ImmutableArrayExtensions:<CreateNameToMembersMap>g__createMembers|47_0[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Object):System.Collections.Immutable.ImmutableArray`1[System.__Canon]]
-       ; gcrRegs -[rdx rbp] +[rax]
+       ; gcrRegs -[rdx] +[rax]
        ; gcr arg pop 0
        mov      r8, rax
        ; gcrRegs +[r8]
        cmp      byte  ptr [rbx], bl
-       mov      gword ptr [rsp+0x28], r14
-       mov      dword ptr [rsp+0x30], r15d
-       mov      dword ptr [rsp+0x34], r13d
-       lea      rdx, [rsp+0x28]
+       mov      gword ptr [rsp+0x20], rsi
+       mov      dword ptr [rsp+0x28], r14d
+       mov      dword ptr [rsp+0x2C], r15d
+       lea      rdx, [rsp+0x20]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        mov      r9d, 2
        call     [<unknown method>]
-       ; gcrRegs -[rax rcx r8 r14]
+       ; gcrRegs -[rax rcx rsi r8]
        ; gcr arg pop 0
        mov      ecx, eax
        call     [<unknown method>]
        ; gcr arg pop 0
-       lea      rcx, [rsp+0x68]
+       lea      rcx, [rsp+0x60]
        mov      rdx, rdi
        call     [<unknown method>]
        ; gcr arg pop 0
        test     eax, eax
-       jne      G_M20920_IG05
-						;; size=79 bbWeight=4 PerfScore 87.00
+       jne      SHORT G_M20920_IG08
+						;; size=104 bbWeight=4 PerfScore 103.00
 G_M20920_IG09:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rbx]
        vzeroupper 
-       add      rsp, 160
+       add      rsp, 152
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        ret      
-						;; size=21 bbWeight=1 PerfScore 5.75
+						;; size=19 bbWeight=1 PerfScore 5.25
 
-; Total bytes of code 312, prolog size 53, PerfScore 173.38, instruction count 74, allocated bytes for code 312 (MethodHash=eaa0ae47) for method Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
+; Total bytes of code 289, prolog size 39, PerfScore 144.43, instruction count 69, allocated bytes for code 289 (MethodHash=eaa0ae47) for method Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -163,17 +158,16 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x11
-  CountOfUnwindCodes: 9
+  SizeOfProlog      : 0x0F
+  CountOfUnwindCodes: 8
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x11 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 20 * 8 = 160 = 0x000A0
-    CodeOffset: 0x0A UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x09 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r13 (13)
+    CodeOffset: 0x0F UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 19 * 8 = 152 = 0x00098
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:red">+33</span> (<span style="color:red">+21.57%</span>) : 25797.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T05] (  3,  3   )     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]>
+;  V00 this         [V00,T05] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]>
 ;  V01 loc0         [V01    ] (  7, 37   )  struct (16) [rsp+0x70]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;  V02 loc1         [V02    ] (  2,  4   )  struct (80) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]>
 ;* V03 loc2         [V03    ] (  0,  0   )  struct (56) zero-ref    do-not-enreg[SF] ld-addr-op <Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult>
@@ -16,36 +16,38 @@
 ;* V05 tmp1         [V05    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V06 tmp2         [V06    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V07 tmp3         [V07    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V08 tmp4         [V08,T08] (  2,  8   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
-;  V09 tmp5         [V09,T09] (  2,  8   )     int  ->   r8         "Inlining Arg"
-;* V10 tmp6         [V10,T12] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V11 tmp7         [V11,T11] (  3,  6   )   ubyte  ->  rax         "Inline stloc first use temp"
-;  V12 tmp8         [V12,T04] (  2, 32   )     int  ->  rcx         "impAppendStmt"
-;  V13 tmp9         [V13,T03] (  2, 32   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V08 tmp4         [V08,T03] (  2,  8   )     ref  ->  rcx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
+;  V09 tmp5         [V09,T04] (  2,  8   )     int  ->   r8         "Inlining Arg"
+;* V10 tmp6         [V10,T11] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V11 tmp7         [V11,T06] (  3,  6   )   ubyte  ->  rax         "Inline stloc first use temp"
+;  V12 tmp8         [V12,T01] (  2, 32   )     int  ->  rcx         "impAppendStmt"
+;  V13 tmp9         [V13,T00] (  2, 32   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;* V14 tmp10        [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableArray`1+Builder[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]>
 ;  V15 tmp11        [V15    ] (  3, 11   )     ref  ->  [rsp+0x70]  do-not-enreg[X] addr-exposed "field V01._builder (fldOffset=0x0)" P-DEP
 ;  V16 tmp12        [V16    ] (  5, 27   )     int  ->  [rsp+0x78]  do-not-enreg[X] addr-exposed "field V01._index (fldOffset=0x8)" P-DEP
 ;* V17 tmp13        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    "V03.[004..005)"
-;* V18 cse0         [V18,T10] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
-;* V19 rat0         [V19,T07] (  0,  0   )    long  ->  zero-ref    "Spilling to split statement for tree"
-;* V20 rat1         [V20,T13] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
-;* V21 rat2         [V21,T06] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
-;* V22 rat3         [V22,T01] (  0,  0   )    long  ->  zero-ref    "Spilling to split statement for tree"
-;* V23 rat4         [V23,T02] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
-;* V24 rat5         [V24,T00] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
+;* V18 cse0         [V18,T13] (  0,  0   )    long  ->  zero-ref    hoist "CSE - aggressive"
+;  V19 cse1         [V19,T08] (  2,  2   )    long  ->  rsi         "CSE - aggressive"
+;  V20 rat0         [V20,T09] (  2,  4   )    long  ->  rcx         "Spilling to split statement for tree"
+;* V21 rat1         [V21,T10] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;  V22 rat2         [V22,T07] (  2,  4   )    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;* V23 rat3         [V23,T12] (  0,  0   )    long  ->  zero-ref    "runtime lookup"
+;* V24 rat4         [V24,T02] (  0,  0   )    long  ->  zero-ref    "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 128
+; Lcl frame size = 136
 
 G_M864_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     rsi
        push     rbx
-       sub      rsp, 128
+       sub      rsp, 136
        vxorps   xmm4, xmm4, xmm4
        vmovdqu  ymmword ptr [rsp+0x20], ymm4
        vmovdqu  ymmword ptr [rsp+0x40], ymm4
        vmovdqu  ymmword ptr [rsp+0x60], ymm4
+       mov      qword ptr [rsp+0x80], rcx
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=33 bbWeight=1 PerfScore 7.83
+						;; size=42 bbWeight=1 PerfScore 9.83
 G_M864_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rbx+0x08]
        ; gcrRegs +[rcx]
@@ -54,8 +56,15 @@ G_M864_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        call     [Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:GetEnumerator():Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1+Enumerator[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]:this]
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
+       mov      rsi, qword ptr [rbx]
+       mov      rcx, rsi
+       mov      rcx, qword ptr [rcx+0x38]
+       mov      rcx, qword ptr [rcx]
+       mov      rcx, qword ptr [rcx+0x30]
+       test     rcx, rcx
+       jne      SHORT G_M864_IG04
        jmp      SHORT G_M864_IG04
-						;; size=19 bbWeight=1 PerfScore 10.50
+						;; size=41 bbWeight=1 PerfScore 20.00
 G_M864_IG03:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rsp+0x70]
        ; gcrRegs +[rcx]
@@ -90,20 +99,22 @@ G_M864_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, by
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M864_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 128
+       add      rsp, 136
        pop      rbx
+       pop      rsi
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 0.88
+						;; size=10 bbWeight=0.50 PerfScore 1.12
 G_M864_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M864_IG08:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 128
+       add      rsp, 136
        pop      rbx
+       pop      rsi
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 0.88
+						;; size=10 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 153, prolog size 30, PerfScore 131.83, instruction count 41, allocated bytes for code 153 (MethodHash=caadfc9f) for method Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)
+; Total bytes of code 186, prolog size 39, PerfScore 143.83, instruction count 52, allocated bytes for code 186 (MethodHash=caadfc9f) for method Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -111,10 +122,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x09
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 15 * 8 + 8 = 128 = 0x80
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x09 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 17 * 8 = 136 = 0x00088
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+24.43%</span>) : 24610.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,105 +8,127 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T05] (  5, 14.92)     int  ->  rbx         single-def
+;  V00 arg0         [V00,T06] (  5, 11.42)     int  ->  rbx         single-def
 ;  V01 loc0         [V01,T03] (  7, 33.76)     ref  ->  rdi         class-hnd <<unknown class>>
-;  V02 loc1         [V02,T02] (  5, 35.76)     ref  ->  rbp         class-hnd exact <<unknown class>>
-;  V03 loc2         [V03,T01] (  7, 87.20)     int  ->  r14        
+;  V02 loc1         [V02,T02] (  5, 35.76)     ref  ->  r13         class-hnd exact <<unknown class>>
+;  V03 loc2         [V03,T01] (  7, 87.20)     int  ->  r12        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T00] (  3, 95.04)     ref  ->  rax         class-hnd exact "NewObj constructor temp" <Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol>
-;  V06 cse0         [V06,T04] (  3, 23.84)     int  ->  r15         "CSE - aggressive"
-;  V07 cse1         [V07,T07] (  3,  9.92)    long  ->  rsi         "CSE - aggressive"
-;  V08 cse2         [V08,T06] (  3, 12   )     int  ->  r14         "CSE - aggressive"
+;  V06 cse0         [V06,T10] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
+;  V07 cse1         [V07,T04] (  3, 23.84)     int  ->  [rsp+0x34]  spill-single-def "CSE - aggressive"
+;  V08 cse2         [V08,T05] (  2, 16.84)    long  ->  [rsp+0x28]  spill-single-def hoist "CSE - aggressive"
+;  V09 cse3         [V09,T11] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
+;  V10 cse4         [V10,T09] (  2,  8.42)   byref  ->  r15         hoist "CSE - aggressive"
+;  V11 cse5         [V11,T08] (  3,  9.92)    long  ->  rsi         "CSE - aggressive"
+;  V12 cse6         [V12,T07] (  3, 12   )     int  ->  r12         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M65390_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
        push     r14
+       push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 56
        mov      ebx, ecx
-						;; size=14 bbWeight=1 PerfScore 6.50
+						;; size=18 bbWeight=1 PerfScore 8.50
 G_M65390_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rsi, 0xD1FFAB1E      ; static handle
        mov      rdi, gword ptr [rsi]
        ; gcrRegs +[rdi]
        cmp      dword ptr [rdi+0x08], ebx
-       jge      G_M65390_IG06
+       jge      G_M65390_IG08
 						;; size=22 bbWeight=1 PerfScore 6.25
-G_M65390_IG03:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+G_M65390_IG03:        ; bbWeight=0.50, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
        lea      edx, [rbx+0x0F]
        and      edx, -16
-       movsxd   rdx, edx
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       movsxd   rbp, edx
+       mov      r14, 0xD1FFAB1E      ; <unknown class>
+       mov      r15, 0xD1FFAB1E      ; static handle
+       ; byrRegs +[r15]
+						;; size=29 bbWeight=0.50 PerfScore 0.75
+G_M65390_IG04:        ; bbWeight=4, gcrefRegs=0080 {rdi}, byrefRegs=8000 {r15}, byref, isz
+       mov      rdx, rbp
+       mov      rcx, r14
        call     CORINFO_HELP_NEWARR_1_OBJ
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       mov      r14d, dword ptr [rdi+0x08]
-       mov      r8d, r14d
+       mov      r13, rax
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [rdi+0x08]
+       mov      r8d, r12d
        mov      rcx, rdi
        ; gcrRegs +[rcx]
-       mov      rdx, rbp
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-       mov      r15d, dword ptr [rbp+0x08]
-       cmp      r15d, r14d
-       jle      SHORT G_M65390_IG05
-						;; size=55 bbWeight=4 PerfScore 46.00
-G_M65390_IG04:        ; bbWeight=15.84, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
+       mov      eax, dword ptr [r13+0x08]
+       mov      dword ptr [rsp+0x34], eax
+       cmp      eax, r12d
+       jle      SHORT G_M65390_IG07
+						;; size=46 bbWeight=4 PerfScore 47.00
+G_M65390_IG05:        ; bbWeight=1, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref
+       mov      rdx, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
+       mov      qword ptr [rsp+0x28], rdx
+						;; size=15 bbWeight=1 PerfScore 1.25
+G_M65390_IG06:        ; bbWeight=15.84, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref, isz
+       mov      rcx, rdx
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      dword ptr [rax+0x20], r14d
-       mov      ecx, r14d
-       lea      rcx, bword ptr [rbp+8*rcx+0x10]
+       mov      dword ptr [rax+0x20], r12d
+       mov      ecx, r12d
+       lea      rcx, bword ptr [r13+8*rcx+0x10]
        ; byrRegs +[rcx]
        mov      rdx, rax
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rax rdx]
        ; byrRegs -[rcx]
-       inc      r14d
-       cmp      r15d, r14d
-       jg       SHORT G_M65390_IG04
-						;; size=43 bbWeight=15.84 PerfScore 114.84
-G_M65390_IG05:        ; bbWeight=7.92, gcrefRegs=00A0 {rbp rdi}, byrefRegs=0000 {}, byref, isz
+       inc      r12d
+       mov      r8d, dword ptr [rsp+0x34]
+       cmp      r8d, r12d
+       mov      rdx, qword ptr [rsp+0x28]
+       jg       SHORT G_M65390_IG06
+						;; size=46 bbWeight=15.84 PerfScore 146.52
+G_M65390_IG07:        ; bbWeight=7.92, gcrefRegs=2080 {rdi r13}, byrefRegs=8000 {r15}, byref
        mov      r8, rdi
        ; gcrRegs +[r8]
-       mov      rdx, rbp
+       mov      rdx, r13
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rcx, r15
        ; byrRegs +[rcx]
        call     <unknown method>
-       ; gcrRegs -[rdx rbp rdi r8] +[rax]
+       ; gcrRegs -[rdx rdi r8 r13] +[rax]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        mov      rdi, gword ptr [rsi]
        ; gcrRegs +[rdi]
        cmp      dword ptr [rdi+0x08], ebx
-       jl       SHORT G_M65390_IG03
-						;; size=29 bbWeight=7.92 PerfScore 61.38
-G_M65390_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       jl       G_M65390_IG04
+						;; size=26 bbWeight=7.92 PerfScore 61.38
+G_M65390_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rax rdi]
-       add      rsp, 40
+       ; byrRegs -[r15]
+       add      rsp, 56
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
 
-; Total bytes of code 176, prolog size 14, PerfScore 239.22, instruction count 51, allocated bytes for code 176 (MethodHash=ce860091) for method Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
+; Total bytes of code 219, prolog size 18, PerfScore 276.90, instruction count 63, allocated bytes for code 219 (MethodHash=ce860091) for method Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -114,15 +136,17 @@ Unwind Info:
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
-    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x10 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
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
<summary><span style="color:red">+28</span> (<span style="color:red">+46.67%</span>) : 957.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,45 +8,57 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4, 18   )     ref  ->  rbx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
-;  V01 loc0         [V01,T01] (  3, 17   )   float  ->  mm0        
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
+;  V01 loc0         [V01,T02] (  3, 17   )   float  ->  mm0        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
+;  V04 cse0         [V04,T00] (  2,  9   )   byref  ->  rbx         hoist "CSE - aggressive"
+;  V05 cse1         [V05,T03] (  2,  9   )  double  ->  mm6         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T04] (  2,  9   )   float  ->  mm7         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 64
 
-G_M31728_IG01:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M31728_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=8 bbWeight=8 PerfScore 12.00
-G_M31728_IG02:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       cmp      byte  ptr [rbx], bl
-       lea      rcx, bword ptr [rbx+0x08]
+       sub      rsp, 64
+       vmovaps  xmmword ptr [rsp+0x30], xmm6
+       vmovaps  xmmword ptr [rsp+0x20], xmm7
+						;; size=17 bbWeight=1 PerfScore 5.25
+G_M31728_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rcx]
+       cmp      byte  ptr [rcx], cl
+       lea      rbx, bword ptr [rcx+0x08]
+       ; byrRegs +[rbx]
+       vmovsd   xmm6, qword ptr [reloc @RWD00]
+       vmovss   xmm7, dword ptr [reloc @RWD08]
+						;; size=22 bbWeight=1 PerfScore 9.50
+G_M31728_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, rbx
        ; byrRegs +[rcx]
        call     [System.Random+CompatPrng:InternalSample():int:this]
        ; byrRegs -[rcx]
        ; gcr arg pop 0
        vxorps   xmm0, xmm0, xmm0
        vcvtsi2sd xmm0, xmm0, eax
-       vmulsd   xmm0, xmm0, qword ptr [reloc @RWD00]
+       vmulsd   xmm0, xmm0, xmm6
        vcvtsd2ss xmm0, xmm0, xmm0
-       vmovss   xmm1, dword ptr [reloc @RWD08]
-       vucomiss xmm1, xmm0
-       jbe      SHORT G_M31728_IG02
-						;; size=46 bbWeight=8 PerfScore 222.67
-G_M31728_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       add      rsp, 32
+       vucomiss xmm7, xmm0
+       jbe      SHORT G_M31728_IG03
+						;; size=31 bbWeight=8 PerfScore 156.67
+G_M31728_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rbx]
+       vmovaps  xmm6, xmmword ptr [rsp+0x30]
+       vmovaps  xmm7, xmmword ptr [rsp+0x20]
+       add      rsp, 64
        pop      rbx
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=18 bbWeight=1 PerfScore 9.75
 RWD00  	dq	3E00000000200000h	; 4.65661288e-10
 RWD08  	dd	3F800000h		;         1
 
 
-; Total bytes of code 60, prolog size 5, PerfScore 236.42, instruction count 16, allocated bytes for code 60 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
+; Total bytes of code 88, prolog size 17, PerfScore 181.17, instruction count 21, allocated bytes for code 88 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -54,10 +66,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x11
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 2 * 16 = 32 = 0x00020
+    CodeOffset: 0x0B UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 3 * 16 = 48 = 0x00030
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-29</span> (<span style="color:green">-6.11%</span>) : 8101.dasm - System.IO.PathHelper:GetFullPathName(System.ReadOnlySpan`1[ushort],byref) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,14 +8,14 @@
 ; control-flow guard enabled
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T06] (  6, 23   )   byref  ->  [rbp+0x10]  ld-addr-op single-def
-;  V01 arg1         [V01,T05] (  7, 29   )   byref  ->  [rbp+0x18]  single-def
+;  V00 arg0         [V00,T04] (  6, 23   )   byref  ->  [rbp+0x10]  ld-addr-op single-def
+;  V01 arg1         [V01,T03] (  7, 29   )   byref  ->  [rbp+0x18]  single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;  V03 loc1         [V03,T13] (  5,  0   )     int  ->  rbx        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T11] (  2,  1   )     int  ->  rcx        
+;  V05 tmp1         [V05,T12] (  2,  1   )     int  ->  rcx        
 ;* V06 tmp2         [V06    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
-;  V07 tmp3         [V07,T02] (  2, 32   )     int  ->  r14         "impAppendStmt"
+;  V07 tmp3         [V07,T00] (  2, 32   )     int  ->  r15         "impAppendStmt"
 ;* V08 tmp4         [V08    ] (  0,  0   )     int  ->  zero-ref    "dup spill"
 ;* V09 tmp5         [V09    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V10 tmp6         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -27,30 +27,29 @@
 ;* V16 tmp12        [V16    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;  V17 tmp13        [V17    ] (  2, 16   )   byref  ->  [rbp-0x48]  must-init pinned "Inline stloc first use temp"
 ;* V18 tmp14        [V18    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V19 tmp15        [V19,T09] (  5, 20   )     int  ->  rbx         "Inline stloc first use temp"
-;  V20 tmp16        [V20,T10] (  2, 16   )     int  ->  rsi         "Inline stloc first use temp"
-;  V21 PInvokeFrame [V21    ] (  3, 17   )  struct (40) [rbp-0xA0]  do-not-enreg[XS] addr-exposed "Pinvoke FrameVar"
+;  V19 tmp15        [V19,T07] (  5, 20   )     int  ->  rbx         "Inline stloc first use temp"
+;  V20 tmp16        [V20,T08] (  2, 16   )     int  ->  rax         "Inline stloc first use temp"
+;  V21 PInvokeFrame [V21    ] (  3, 17   )  struct (40) [rbp-0xA8]  do-not-enreg[XS] addr-exposed "Pinvoke FrameVar"
 ;* V22 tmp18        [V22    ] (  0,  0   )   byref  ->  zero-ref    do-not-enreg[] "field V00._reference (fldOffset=0x0)" P-DEP
 ;* V23 tmp19        [V23    ] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V00._length (fldOffset=0x8)" P-DEP
-;  V24 tmp20        [V24,T07] (  3, 24   )   byref  ->  rdi         "field V11._reference (fldOffset=0x0)" P-INDEP
+;  V24 tmp20        [V24,T05] (  3, 24   )   byref  ->  rdi         "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V25 tmp21        [V25    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
-;  V26 tmp22        [V26,T08] (  3, 24   )   byref  ->  r15         "field V12._reference (fldOffset=0x0)" P-INDEP
+;  V26 tmp22        [V26,T06] (  3, 24   )   byref  ->  r13         "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V27 tmp23        [V27    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V28 tmp24        [V28    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[S] "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V29 tmp25        [V29    ] (  4,  6   )  struct (16) [rbp-0x58]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V30 tmp26        [V30,T03] (  2, 32   )    long  ->  r15         "Cast away GC"
-;  V31 tmp27        [V31,T04] (  2, 32   )    long  ->  rdi         "Cast away GC"
-;  V32 tmp28        [V32,T15] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
-;  V33 rat0         [V33,T00] (  6, 80   )     ref  ->  rdi         "Final offset"
-;  V34 rat1         [V34,T01] (  3, 32   )    long  ->  rax         "TlsRootAddr access"
-;  V35 rat2         [V35,T12] (  6,  0   )     ref  ->  rbx         "Final offset"
-;  V36 rat3         [V36,T14] (  3,  0   )    long  ->  rdx         "TlsRootAddr access"
-;  TEMP_01                                     int  ->  [rbp-0x5C]
-;  TEMP_04                                    long  ->  [rbp-0x64]
-;  TEMP_03                                    long  ->  [rbp-0x6C]
-;  TEMP_02                                    long  ->  [rbp-0x74]
+;  V30 tmp26        [V30,T01] (  2, 32   )    long  ->  r13         "Cast away GC"
+;  V31 tmp27        [V31,T02] (  2, 32   )    long  ->  rdi         "Cast away GC"
+;  V32 tmp28        [V32,T14] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
+;  V33 cse0         [V33,T10] (  3,  9   )   byref  ->  [rbp-0x60]  spill-single-def hoist "CSE - aggressive"
+;  V34 rat0         [V34,T09] (  6, 10   )     ref  ->  rdi         "Final offset"
+;  V35 rat1         [V35,T11] (  3,  4   )    long  ->  rdx         "TlsRootAddr access"
+;  TEMP_01                                     int  ->  [rbp-0x64]
+;  TEMP_04                                    long  ->  [rbp-0x6C]
+;  TEMP_03                                    long  ->  [rbp-0x74]
+;  TEMP_02                                    long  ->  [rbp-0x7C]
 ;
-; Lcl frame size = 136
+; Lcl frame size = 152
 
 G_M7633_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbp
@@ -61,8 +60,8 @@ G_M7633_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 136
-       lea      rbp, [rsp+0xC0]
+       sub      rsp, 152
+       lea      rbp, [rsp+0xD0]
        xor      eax, eax
        mov      qword ptr [rbp-0x58], rax
        xorps    xmm4, xmm4
@@ -81,7 +80,7 @@ G_M7633_IG03:        ; bbWeight=1, isz, extend
        lea      rcx, [rbp-0x58]
        call     <unknown method>
        test     eax, eax
-       jne      SHORT G_M7633_IG08
+       jne      SHORT G_M7633_IG06
 						;; size=13 bbWeight=1 PerfScore 2.75
 G_M7633_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, nogc
        movups   xmm0, xmmword ptr [rsi]
@@ -94,115 +93,117 @@ G_M7633_IG05:        ; bbWeight=0.50, isz, extend
        test     eax, eax
        sete     cl
        test     cl, cl
-       jne      SHORT G_M7633_IG08
-						;; size=20 bbWeight=0.50 PerfScore 2.12
-G_M7633_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
+       jne      SHORT G_M7633_IG06
        lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
        lea      rdx, gword ptr [(reloc)]
        ; gcrRegs +[rdx]
        call     <unknown method>
        ; gcrRegs -[rcx rdx]
-       jmp      SHORT G_M7633_IG08
-						;; size=21 bbWeight=1 PerfScore 4.00
-G_M7633_IG07:        ; bbWeight=2, gcVars=0000000000000040 {V00}, gcrefRegs=0000 {}, byrefRegs=4000 {r14}, gcvars, byref
-       ; byrRegs -[rbx rsi] +[r14]
+						;; size=39 bbWeight=0.50 PerfScore 3.12
+G_M7633_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref
+       mov      rcx, qword ptr GS:[0x0058]
+       mov      eax, dword ptr [(reloc)]
+       mov      edx, (reloc)
+       add      rdx, qword ptr [rcx+8*rax]
+       mov      rdi, gword ptr [rdx]
+       ; gcrRegs +[rdi]
+       test     rdi, rdi
+       je       G_M7633_IG18
+						;; size=36 bbWeight=1 PerfScore 9.50
+G_M7633_IG07:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0048 {rbx rsi}, byref, isz
+       mov      bword ptr [rbp-0x60], rdi
+       ; GC ptr vars +{V33}
+       jmp      SHORT G_M7633_IG09
+						;; size=6 bbWeight=1 PerfScore 3.00
+G_M7633_IG08:        ; bbWeight=2, gcVars=0000000000000410 {V00 V33}, gcrefRegs=0000 {}, byrefRegs=4040 {rsi r14}, gcvars, byref
+       ; gcrRegs -[rdi]
+       ; byrRegs -[rbx] +[r14]
        ; GC ptr vars +{V00}
        test     ebx, ebx
        jl       G_M7633_IG17
        mov      edx, ebx
-       mov      rcx, r14
+       mov      rcx, rsi
        ; byrRegs +[rcx]
        call     System.Text.ValueStringBuilder:EnsureCapacity(int):this
        ; byrRegs -[rcx]
-       mov      rbx, r14
+       mov      rbx, rsi
        ; byrRegs +[rbx]
        mov      rsi, bword ptr [rbp+0x10]
-       ; byrRegs +[rsi]
 						;; size=25 bbWeight=2 PerfScore 8.00
-G_M7633_IG08:        ; bbWeight=8, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, gcvars, byref
+G_M7633_IG09:        ; bbWeight=8, gcVars=0000000000000400 {V33}, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, gcvars, byref
        ; byrRegs -[r14]
        ; GC ptr vars -{V00}
        mov      bword ptr [rbp+0x10], rsi
        ; GC ptr vars +{V00}
        mov      rdi, bword ptr [rsi]
        ; byrRegs +[rdi]
-       mov      r14d, dword ptr [rbx+0x18]
+       mov      r15d, dword ptr [rbx+0x18]
        mov      bword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
-       mov      r15, bword ptr [rbx+0x10]
-       ; byrRegs +[r15]
-       mov      bword ptr [rbp-0x40], r15
+       mov      r13, bword ptr [rbx+0x10]
+       ; byrRegs +[r13]
+       mov      bword ptr [rbp-0x40], r13
        mov      bword ptr [rbp-0x48], rdi
        xor      ecx, ecx
 						;; size=29 bbWeight=8 PerfScore 82.00
-G_M7633_IG09:        ; bbWeight=8, gcVars=0000000000000060 {V00 V01}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rbx rsi rdi r15]
+G_M7633_IG10:        ; bbWeight=8, gcVars=0000000000000418 {V00 V01 V33}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       ; byrRegs -[rbx rsi rdi r13]
        call     <unknown method>
        mov      rcx, rdi
-       mov      qword ptr [rbp-0x64], rcx
-       mov      edx, r14d
-       mov      dword ptr [rbp-0x5C], edx
-       mov      r8, r15
-       mov      qword ptr [rbp-0x6C], r8
+       mov      qword ptr [rbp-0x6C], rcx
+       mov      edx, r15d
+       mov      dword ptr [rbp-0x64], edx
+       mov      r8, r13
+       mov      qword ptr [rbp-0x74], r8
        xor      r9d, r9d
-       mov      qword ptr [rbp-0x74], r9
-       lea      rcx, [rbp-0xA0]
+       mov      qword ptr [rbp-0x7C], r9
+       lea      rcx, [rbp-0xA8]
 						;; size=39 bbWeight=8 PerfScore 52.00
-G_M7633_IG10:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       call     CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov      rcx, qword ptr [rbp-0x64]
-       mov      edx, dword ptr [rbp-0x5C]
-       mov      r8, qword ptr [rbp-0x6C]
-       mov      r9, qword ptr [rbp-0x74]
-						;; size=20 bbWeight=8 PerfScore 40.00
 G_M7633_IG11:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       call     <unknown method>
-       mov      ebx, eax
-       lea      rcx, [rbp-0xA0]
-       call     CORINFO_HELP_JIT_PINVOKE_END
-						;; size=19 bbWeight=8 PerfScore 22.00
+       call     CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov      rcx, qword ptr [rbp-0x6C]
+       mov      edx, dword ptr [rbp-0x64]
+       mov      r8, qword ptr [rbp-0x74]
+       mov      r9, qword ptr [rbp-0x7C]
+						;; size=20 bbWeight=8 PerfScore 40.00
 G_M7633_IG12:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     <unknown method>
-       mov      esi, eax
+       mov      ebx, eax
+       lea      rcx, [rbp-0xA8]
+       call     CORINFO_HELP_JIT_PINVOKE_END
+						;; size=19 bbWeight=8 PerfScore 22.00
+G_M7633_IG13:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       call     <unknown method>
        xor      edx, edx
        mov      bword ptr [rbp-0x48], rdx
-						;; size=13 bbWeight=8 PerfScore 20.00
-G_M7633_IG13:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=11 bbWeight=8 PerfScore 18.00
+G_M7633_IG14:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      bword ptr [rbp-0x40], rdx
-       mov      rdx, qword ptr GS:[0x0058]
-       mov      ecx, dword ptr [(reloc)]
-       mov      eax, (reloc)
-       add      rax, qword ptr [rdx+8*rcx]
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
-       test     rdi, rdi
-       je       SHORT G_M7633_IG18
-						;; size=36 bbWeight=8 PerfScore 84.00
-G_M7633_IG14:        ; bbWeight=8, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
-       mov      dword ptr [rdi+0x98], esi
-       mov      edx, ebx
-       mov      r14, bword ptr [rbp+0x18]
+       mov      r14, bword ptr [rbp-0x60]
        ; byrRegs +[r14]
-       movsxd   rcx, dword ptr [r14+0x18]
+       mov      dword ptr [r14+0x98], eax
+       mov      edx, ebx
+       mov      rsi, bword ptr [rbp+0x18]
+       ; byrRegs +[rsi]
+       movsxd   rcx, dword ptr [rsi+0x18]
        cmp      rdx, rcx
-       jg       G_M7633_IG07
-						;; size=25 bbWeight=8 PerfScore 60.00
-G_M7633_IG15:        ; bbWeight=1, gcVars=0000000000000040 {V00}, gcrefRegs=0000 {}, byrefRegs=4000 {r14}, gcvars, byref, isz
-       ; gcrRegs -[rdi]
+       jg       G_M7633_IG08
+						;; size=34 bbWeight=8 PerfScore 76.00
+G_M7633_IG15:        ; bbWeight=1, gcVars=0000000000000410 {V00 V33}, gcrefRegs=0000 {}, byrefRegs=4040 {rsi r14}, gcvars, byref, isz
        ; GC ptr vars -{V01}
        test     ebx, ebx
        je       SHORT G_M7633_IG19
-       mov      rcx, r14
+       mov      rcx, rsi
...

```


</div></details>

<details>
<summary><span style="color:green">-29</span> (<span style="color:green">-6.11%</span>) : 13387.dasm - System.IO.PathHelper:GetFullPathName(System.ReadOnlySpan`1[ushort],byref) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,14 +7,14 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T06] (  6, 23   )   byref  ->  [rbp+0x10]  ld-addr-op single-def
-;  V01 arg1         [V01,T05] (  7, 29   )   byref  ->  [rbp+0x18]  single-def
+;  V00 arg0         [V00,T04] (  6, 23   )   byref  ->  [rbp+0x10]  ld-addr-op single-def
+;  V01 arg1         [V01,T03] (  7, 29   )   byref  ->  [rbp+0x18]  single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref   
 ;  V03 loc1         [V03,T13] (  5,  0   )     int  ->  rbx        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T11] (  2,  1   )     int  ->  rcx        
+;  V05 tmp1         [V05,T12] (  2,  1   )     int  ->  rcx        
 ;* V06 tmp2         [V06    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
-;  V07 tmp3         [V07,T02] (  2, 32   )     int  ->  r14         "impAppendStmt"
+;  V07 tmp3         [V07,T00] (  2, 32   )     int  ->  r15         "impAppendStmt"
 ;* V08 tmp4         [V08    ] (  0,  0   )     int  ->  zero-ref    "dup spill"
 ;* V09 tmp5         [V09    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V10 tmp6         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -26,30 +26,29 @@
 ;* V16 tmp12        [V16    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;  V17 tmp13        [V17    ] (  2, 16   )   byref  ->  [rbp-0x48]  must-init pinned "Inline stloc first use temp"
 ;* V18 tmp14        [V18    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
-;  V19 tmp15        [V19,T09] (  5, 20   )     int  ->  rbx         "Inline stloc first use temp"
-;  V20 tmp16        [V20,T10] (  2, 16   )     int  ->  rsi         "Inline stloc first use temp"
-;  V21 PInvokeFrame [V21    ] (  3, 17   )  struct (40) [rbp-0xA0]  do-not-enreg[XS] addr-exposed "Pinvoke FrameVar"
+;  V19 tmp15        [V19,T07] (  5, 20   )     int  ->  rbx         "Inline stloc first use temp"
+;  V20 tmp16        [V20,T08] (  2, 16   )     int  ->  rax         "Inline stloc first use temp"
+;  V21 PInvokeFrame [V21    ] (  3, 17   )  struct (40) [rbp-0xA8]  do-not-enreg[XS] addr-exposed "Pinvoke FrameVar"
 ;* V22 tmp18        [V22    ] (  0,  0   )   byref  ->  zero-ref    do-not-enreg[] "field V00._reference (fldOffset=0x0)" P-DEP
 ;* V23 tmp19        [V23    ] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V00._length (fldOffset=0x8)" P-DEP
-;  V24 tmp20        [V24,T07] (  3, 24   )   byref  ->  rdi         "field V11._reference (fldOffset=0x0)" P-INDEP
+;  V24 tmp20        [V24,T05] (  3, 24   )   byref  ->  rdi         "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V25 tmp21        [V25    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
-;  V26 tmp22        [V26,T08] (  3, 24   )   byref  ->  r15         "field V12._reference (fldOffset=0x0)" P-INDEP
+;  V26 tmp22        [V26,T06] (  3, 24   )   byref  ->  r13         "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V27 tmp23        [V27    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V28 tmp24        [V28    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[S] "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V29 tmp25        [V29    ] (  4,  6   )  struct (16) [rbp-0x58]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V30 tmp26        [V30,T03] (  2, 32   )    long  ->  r15         "Cast away GC"
-;  V31 tmp27        [V31,T04] (  2, 32   )    long  ->  rdi         "Cast away GC"
-;  V32 tmp28        [V32,T15] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
-;  V33 rat0         [V33,T00] (  6, 80   )     ref  ->  rdi         "Final offset"
-;  V34 rat1         [V34,T01] (  3, 32   )    long  ->  rax         "TlsRootAddr access"
-;  V35 rat2         [V35,T12] (  6,  0   )     ref  ->  rbx         "Final offset"
-;  V36 rat3         [V36,T14] (  3,  0   )    long  ->  rdx         "TlsRootAddr access"
-;  TEMP_01                                     int  ->  [rbp-0x5C]
-;  TEMP_04                                    long  ->  [rbp-0x64]
-;  TEMP_03                                    long  ->  [rbp-0x6C]
-;  TEMP_02                                    long  ->  [rbp-0x74]
+;  V30 tmp26        [V30,T01] (  2, 32   )    long  ->  r13         "Cast away GC"
+;  V31 tmp27        [V31,T02] (  2, 32   )    long  ->  rdi         "Cast away GC"
+;  V32 tmp28        [V32,T14] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
+;  V33 cse0         [V33,T10] (  3,  9   )   byref  ->  [rbp-0x60]  spill-single-def hoist "CSE - aggressive"
+;  V34 rat0         [V34,T09] (  6, 10   )     ref  ->  rdi         "Final offset"
+;  V35 rat1         [V35,T11] (  3,  4   )    long  ->  rdx         "TlsRootAddr access"
+;  TEMP_01                                     int  ->  [rbp-0x64]
+;  TEMP_04                                    long  ->  [rbp-0x6C]
+;  TEMP_03                                    long  ->  [rbp-0x74]
+;  TEMP_02                                    long  ->  [rbp-0x7C]
 ;
-; Lcl frame size = 136
+; Lcl frame size = 152
 
 G_M7633_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbp
@@ -60,8 +59,8 @@ G_M7633_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 136
-       lea      rbp, [rsp+0xC0]
+       sub      rsp, 152
+       lea      rbp, [rsp+0xD0]
        xor      eax, eax
        mov      qword ptr [rbp-0x58], rax
        xorps    xmm4, xmm4
@@ -80,7 +79,7 @@ G_M7633_IG03:        ; bbWeight=1, isz, extend
        lea      rcx, [rbp-0x58]
        call     <unknown method>
        test     eax, eax
-       jne      SHORT G_M7633_IG08
+       jne      SHORT G_M7633_IG06
 						;; size=13 bbWeight=1 PerfScore 2.75
 G_M7633_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, nogc
        movups   xmm0, xmmword ptr [rsi]
@@ -93,115 +92,117 @@ G_M7633_IG05:        ; bbWeight=0.50, isz, extend
        test     eax, eax
        sete     cl
        test     cl, cl
-       jne      SHORT G_M7633_IG08
-						;; size=20 bbWeight=0.50 PerfScore 2.12
-G_M7633_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
+       jne      SHORT G_M7633_IG06
        lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
        lea      rdx, gword ptr [(reloc)]
        ; gcrRegs +[rdx]
        call     <unknown method>
        ; gcrRegs -[rcx rdx]
-       jmp      SHORT G_M7633_IG08
-						;; size=21 bbWeight=1 PerfScore 4.00
-G_M7633_IG07:        ; bbWeight=2, gcVars=0000000000000040 {V00}, gcrefRegs=0000 {}, byrefRegs=4000 {r14}, gcvars, byref
-       ; byrRegs -[rbx rsi] +[r14]
+						;; size=39 bbWeight=0.50 PerfScore 3.12
+G_M7633_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref
+       mov      rcx, qword ptr GS:[0x0058]
+       mov      eax, dword ptr [(reloc)]
+       mov      edx, (reloc)
+       add      rdx, qword ptr [rcx+8*rax]
+       mov      rdi, gword ptr [rdx]
+       ; gcrRegs +[rdi]
+       test     rdi, rdi
+       je       G_M7633_IG18
+						;; size=36 bbWeight=1 PerfScore 9.50
+G_M7633_IG07:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0048 {rbx rsi}, byref, isz
+       mov      bword ptr [rbp-0x60], rdi
+       ; GC ptr vars +{V33}
+       jmp      SHORT G_M7633_IG09
+						;; size=6 bbWeight=1 PerfScore 3.00
+G_M7633_IG08:        ; bbWeight=2, gcVars=0000000000000410 {V00 V33}, gcrefRegs=0000 {}, byrefRegs=4040 {rsi r14}, gcvars, byref
+       ; gcrRegs -[rdi]
+       ; byrRegs -[rbx] +[r14]
        ; GC ptr vars +{V00}
        test     ebx, ebx
        jl       G_M7633_IG17
        mov      edx, ebx
-       mov      rcx, r14
+       mov      rcx, rsi
        ; byrRegs +[rcx]
        call     System.Text.ValueStringBuilder:EnsureCapacity(int):this
        ; byrRegs -[rcx]
-       mov      rbx, r14
+       mov      rbx, rsi
        ; byrRegs +[rbx]
        mov      rsi, bword ptr [rbp+0x10]
-       ; byrRegs +[rsi]
 						;; size=25 bbWeight=2 PerfScore 8.00
-G_M7633_IG08:        ; bbWeight=8, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, gcvars, byref
+G_M7633_IG09:        ; bbWeight=8, gcVars=0000000000000400 {V33}, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, gcvars, byref
        ; byrRegs -[r14]
        ; GC ptr vars -{V00}
        mov      bword ptr [rbp+0x10], rsi
        ; GC ptr vars +{V00}
        mov      rdi, bword ptr [rsi]
        ; byrRegs +[rdi]
-       mov      r14d, dword ptr [rbx+0x18]
+       mov      r15d, dword ptr [rbx+0x18]
        mov      bword ptr [rbp+0x18], rbx
        ; GC ptr vars +{V01}
-       mov      r15, bword ptr [rbx+0x10]
-       ; byrRegs +[r15]
-       mov      bword ptr [rbp-0x40], r15
+       mov      r13, bword ptr [rbx+0x10]
+       ; byrRegs +[r13]
+       mov      bword ptr [rbp-0x40], r13
        mov      bword ptr [rbp-0x48], rdi
        xor      ecx, ecx
 						;; size=29 bbWeight=8 PerfScore 82.00
-G_M7633_IG09:        ; bbWeight=8, gcVars=0000000000000060 {V00 V01}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rbx rsi rdi r15]
+G_M7633_IG10:        ; bbWeight=8, gcVars=0000000000000418 {V00 V01 V33}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       ; byrRegs -[rbx rsi rdi r13]
        call     <unknown method>
        mov      rcx, rdi
-       mov      qword ptr [rbp-0x64], rcx
-       mov      edx, r14d
-       mov      dword ptr [rbp-0x5C], edx
-       mov      r8, r15
-       mov      qword ptr [rbp-0x6C], r8
+       mov      qword ptr [rbp-0x6C], rcx
+       mov      edx, r15d
+       mov      dword ptr [rbp-0x64], edx
+       mov      r8, r13
+       mov      qword ptr [rbp-0x74], r8
        xor      r9d, r9d
-       mov      qword ptr [rbp-0x74], r9
-       lea      rcx, [rbp-0xA0]
+       mov      qword ptr [rbp-0x7C], r9
+       lea      rcx, [rbp-0xA8]
 						;; size=39 bbWeight=8 PerfScore 52.00
-G_M7633_IG10:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       call     CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov      rcx, qword ptr [rbp-0x64]
-       mov      edx, dword ptr [rbp-0x5C]
-       mov      r8, qword ptr [rbp-0x6C]
-       mov      r9, qword ptr [rbp-0x74]
-						;; size=20 bbWeight=8 PerfScore 40.00
 G_M7633_IG11:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       call     <unknown method>
-       mov      ebx, eax
-       lea      rcx, [rbp-0xA0]
-       call     CORINFO_HELP_JIT_PINVOKE_END
-						;; size=19 bbWeight=8 PerfScore 22.00
+       call     CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov      rcx, qword ptr [rbp-0x6C]
+       mov      edx, dword ptr [rbp-0x64]
+       mov      r8, qword ptr [rbp-0x74]
+       mov      r9, qword ptr [rbp-0x7C]
+						;; size=20 bbWeight=8 PerfScore 40.00
 G_M7633_IG12:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     <unknown method>
-       mov      esi, eax
+       mov      ebx, eax
+       lea      rcx, [rbp-0xA8]
+       call     CORINFO_HELP_JIT_PINVOKE_END
+						;; size=19 bbWeight=8 PerfScore 22.00
+G_M7633_IG13:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       call     <unknown method>
        xor      edx, edx
        mov      bword ptr [rbp-0x48], rdx
-						;; size=13 bbWeight=8 PerfScore 20.00
-G_M7633_IG13:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=11 bbWeight=8 PerfScore 18.00
+G_M7633_IG14:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      bword ptr [rbp-0x40], rdx
-       mov      rdx, qword ptr GS:[0x0058]
-       mov      ecx, dword ptr [(reloc)]
-       mov      eax, (reloc)
-       add      rax, qword ptr [rdx+8*rcx]
-       mov      rdi, gword ptr [rax]
-       ; gcrRegs +[rdi]
-       test     rdi, rdi
-       je       SHORT G_M7633_IG18
-						;; size=36 bbWeight=8 PerfScore 84.00
-G_M7633_IG14:        ; bbWeight=8, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref
-       mov      dword ptr [rdi+0xA0], esi
-       mov      edx, ebx
-       mov      r14, bword ptr [rbp+0x18]
+       mov      r14, bword ptr [rbp-0x60]
        ; byrRegs +[r14]
-       movsxd   rcx, dword ptr [r14+0x18]
+       mov      dword ptr [r14+0xA0], eax
+       mov      edx, ebx
+       mov      rsi, bword ptr [rbp+0x18]
+       ; byrRegs +[rsi]
+       movsxd   rcx, dword ptr [rsi+0x18]
        cmp      rdx, rcx
-       jg       G_M7633_IG07
-						;; size=25 bbWeight=8 PerfScore 60.00
-G_M7633_IG15:        ; bbWeight=1, gcVars=0000000000000040 {V00}, gcrefRegs=0000 {}, byrefRegs=4000 {r14}, gcvars, byref, isz
-       ; gcrRegs -[rdi]
+       jg       G_M7633_IG08
+						;; size=34 bbWeight=8 PerfScore 76.00
+G_M7633_IG15:        ; bbWeight=1, gcVars=0000000000000410 {V00 V33}, gcrefRegs=0000 {}, byrefRegs=4040 {rsi r14}, gcvars, byref, isz
        ; GC ptr vars -{V01}
        test     ebx, ebx
        je       SHORT G_M7633_IG19
-       mov      rcx, r14
+       mov      rcx, rsi
...

```


</div></details>

<details>
<summary><span style="color:green">-22</span> (<span style="color:green">-4.32%</span>) : 13162.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:Expand(long[]):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,30 +7,29 @@
 ; fully interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] ( 17, 25   )     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]>
-;  V01 arg1         [V01,T11] (  5,  5.50)     ref  ->  rbx         class-hnd single-def <long[]>
-;* V02 loc0         [V02,T17] (  0,  0   )     ref  ->  zero-ref    class-hnd EH-live single-def <Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]>
-;  V03 loc1         [V03,T16] (  3,  2   )   ubyte  ->  [rbp-0x44]  do-not-enreg[M] ld-addr-op EH-live
-;  V04 loc2         [V04,T14] (  6,  3   )     int  ->  rsi        
+;  V00 this         [V00,T01] ( 17, 23.25)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]>
+;  V01 arg1         [V01,T09] (  5,  5.50)     ref  ->  rbx         class-hnd single-def <long[]>
+;* V02 loc0         [V02,T16] (  0,  0   )     ref  ->  zero-ref    class-hnd EH-live single-def <Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]>
+;  V03 loc1         [V03,T15] (  3,  2   )   ubyte  ->  [rbp-0x44]  do-not-enreg[M] ld-addr-op EH-live
+;  V04 loc2         [V04,T13] (  6,  3   )     int  ->  rsi        
 ;  V05 loc3         [V05,T04] (  7, 22   )     ref  ->  rdi         class-hnd exact single-def <long[]>
 ;  V06 loc4         [V06,T06] (  3, 18.50)     int  ->  r15         single-def
 ;  V07 loc5         [V07,T03] (  7, 22.50)     int  ->  r13        
-;  V08 loc6         [V08,T07] (  6, 18   )    long  ->  r12        
+;  V08 loc6         [V08,T07] (  6, 18   )    long  ->  [rbp-0x50] 
 ;* V09 loc7         [V09    ] (  0,  0   )  struct ( 8) zero-ref    <System.Runtime.InteropServices.GCHandle>
-;  V10 loc8         [V10,T12] (  3,  6   )     int  ->  [rbp-0x48]  spill-single-def
-;  V11 loc9         [V11,T00] (  9, 74   )     int  ->  [rbp-0x4C] 
+;  V10 loc8         [V10,T11] (  3,  6   )     int  ->  [rbp-0x54]  spill-single-def
+;  V11 loc9         [V11,T00] (  9, 74   )     int  ->  [rbp-0x58] 
 ;  V12 loc10        [V12,T08] (  2, 18   )     int  ->  rax        
 ;  V13 OutArgs      [V13    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V14 tmp1         [V14    ] (  0,  0   )    long  ->  zero-ref    ld-addr-op "NewObj constructor temp"
 ;* V15 tmp2         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V16 tmp3         [V16    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V17 tmp4         [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <long[]>
-;  V18 tmp5         [V18,T13] (  2,  4   )    long  ->  rdx         "field V09._handle (fldOffset=0x0)" P-INDEP
+;  V18 tmp5         [V18,T12] (  2,  4   )    long  ->  rdx         "field V09._handle (fldOffset=0x0)" P-INDEP
 ;  V19 tmp6         [V19,T02] (  3, 24   )     ref  ->  rdx         "arr expr"
-;  V20 cse0         [V20,T09] (  5, 10   )    long  ->  [rbp-0x58]  multi-def "CSE - aggressive"
+;  V20 cse0         [V20,T10] (  4,  6.25)    long  ->  r12         hoist "CSE - aggressive"
 ;  V21 cse1         [V21,T05] (  5, 21   )     int  ->  r14         "CSE - aggressive"
-;  V22 cse2         [V22,T10] (  5, 10   )    long  ->  [rbp-0x60]  multi-def "CSE - aggressive"
-;  V23 rat0         [V23,T15] (  3,  3   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V22 rat0         [V22,T14] (  3,  3   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 72
 
@@ -64,12 +63,12 @@ G_M35784_IG03:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        mov      rcx, gword ptr [rbp+0x10]
        ; gcrRegs +[rcx]
        cmp      rbx, gword ptr [rcx+0x08]
-       jne      G_M35784_IG17
+       jne      G_M35784_IG18
 						;; size=26 bbWeight=1 PerfScore 7.00
 G_M35784_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        imul     esi, dword ptr [rbx+0x08], 2
-       jo       G_M35784_IG15
+       jo       G_M35784_IG16
        mov      edx, 16
        cmp      esi, 16
        cmovl    esi, edx
@@ -99,45 +98,45 @@ G_M35784_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
        cmp      dword ptr [rdx+0x08], 0
-       jle      G_M35784_IG12
+       jle      G_M35784_IG13
 						;; size=84 bbWeight=0.50 PerfScore 10.50
-G_M35784_IG05:        ; bbWeight=4, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M35784_IG05:        ; bbWeight=0.25, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rdx]
+       mov      rdx, qword ptr [rcx]
+       mov      rdx, qword ptr [rdx+0x30]
+       mov      r12, qword ptr [rdx]
+						;; size=10 bbWeight=0.25 PerfScore 1.50
+G_M35784_IG06:        ; bbWeight=4, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref, isz
        mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
        cmp      r13d, dword ptr [rdx+0x08]
-       jae      G_M35784_IG16
+       jae      G_M35784_IG17
        mov      r8d, r13d
-       mov      r12, qword ptr [rdx+8*r8+0x10]
-       cmp      r12, 1
-       jne      SHORT G_M35784_IG07
+       mov      rax, qword ptr [rdx+8*r8+0x10]
+       cmp      rax, 1
+       jne      SHORT G_M35784_IG08
 						;; size=28 bbWeight=4 PerfScore 38.00
-G_M35784_IG06:        ; bbWeight=2, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rdx]
-       mov      r12, qword ptr [rcx]
-       mov      rdx, qword ptr [r12+0x30]
-       mov      r12, qword ptr [rdx]
+G_M35784_IG07:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rcx rdx]
        mov      rcx, r12
-       ; gcrRegs -[rcx]
        mov      rdx, rbx
        ; gcrRegs +[rdx]
        mov      r8d, r13d
        call     Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:WaitForSentinelInHashtableToDisappear(long[],int):long
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
-       mov      r12, rax
+						;; size=14 bbWeight=2 PerfScore 3.50
+G_M35784_IG08:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+       test     rax, rax
+       je       SHORT G_M35784_IG12
+						;; size=5 bbWeight=4 PerfScore 5.00
+G_M35784_IG09:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, gword ptr [rbp+0x10]
        ; gcrRegs +[rcx]
-						;; size=32 bbWeight=2 PerfScore 18.00
-G_M35784_IG07:        ; bbWeight=4, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref
-       test     r12, r12
-       je       G_M35784_IG11
-						;; size=9 bbWeight=4 PerfScore 5.00
-G_M35784_IG08:        ; bbWeight=2, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      rdx, r12
-       mov      rax, qword ptr [rcx]
-       mov      qword ptr [rbp-0x60], rax
-       call     [rax+0x68]<unknown method>
+       mov      qword ptr [rbp-0x50], rax
+       mov      rdx, rax
+       mov      r8, qword ptr [rcx]
+       call     [r8+0x68]<unknown method>
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        mov      rdx, rax
@@ -147,57 +146,53 @@ G_M35784_IG08:        ; bbWeight=2, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000
        call     [rax+0x40]<unknown method>
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      dword ptr [rbp-0x48], eax
-       mov      rcx, qword ptr [rbp-0x60]
-       mov      rcx, qword ptr [rcx+0x30]
-       mov      rcx, qword ptr [rcx]
-       mov      r8, rcx
-       mov      qword ptr [rbp-0x58], r8
-       mov      rcx, r8
+       mov      dword ptr [rbp-0x54], eax
+       mov      rcx, r12
        mov      edx, eax
        call     <unknown method>
        ; gcr arg pop 0
        and      eax, r15d
        cmp      eax, r14d
-       jae      G_M35784_IG16
-       mov      dword ptr [rbp-0x4C], eax
+       jae      G_M35784_IG17
+       mov      dword ptr [rbp-0x58], eax
        mov      ecx, eax
        cmp      qword ptr [rdi+8*rcx+0x10], 0
-       je       SHORT G_M35784_IG14
-       mov      rcx, qword ptr [rbp-0x58]
-       mov      edx, dword ptr [rbp-0x48]
+       je       SHORT G_M35784_IG15
+       mov      rcx, r12
+       mov      edx, dword ptr [rbp-0x54]
        call     Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:HashInt2(int):int
        ; gcr arg pop 0
-						;; size=94 bbWeight=2 PerfScore 62.00
-G_M35784_IG09:        ; bbWeight=16, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      edx, dword ptr [rbp-0x4C]
+						;; size=80 bbWeight=2 PerfScore 50.00
+G_M35784_IG10:        ; bbWeight=16, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+       mov      edx, dword ptr [rbp-0x58]
        add      edx, eax
        and      edx, r15d
        cmp      edx, r14d
-       jae      SHORT G_M35784_IG16
+       jae      SHORT G_M35784_IG17
        mov      ecx, edx
        cmp      qword ptr [rdi+8*rcx+0x10], 0
-       jne      SHORT G_M35784_IG13
+       jne      SHORT G_M35784_IG14
 						;; size=23 bbWeight=16 PerfScore 112.00
-G_M35784_IG10:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M35784_IG11:        ; bbWeight=2, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        cmp      edx, r14d
-       jae      SHORT G_M35784_IG16
+       jae      SHORT G_M35784_IG17
        mov      eax, edx
-       mov      qword ptr [rdi+8*rax+0x10], r12
+       mov      rdx, qword ptr [rbp-0x50]
+       mov      qword ptr [rdi+8*rax+0x10], rdx
+						;; size=16 bbWeight=2 PerfScore 7.00
+G_M35784_IG12:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref
+       inc      r13d
        mov      rcx, gword ptr [rbp+0x10]
        ; gcrRegs +[rcx]
-						;; size=16 bbWeight=2 PerfScore 7.00
-G_M35784_IG11:        ; bbWeight=4, gcrefRegs=008A {rcx rbx rdi}, byrefRegs=0000 {}, byref
-       inc      r13d
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
        cmp      dword ptr [rax+0x08], r13d
-       jg       G_M35784_IG05
-						;; size=17 bbWeight=4 PerfScore 25.00
-G_M35784_IG12:        ; bbWeight=0.50, gcrefRegs=0082 {rcx rdi}, byrefRegs=0000 {}, byref, isz
+       jg       G_M35784_IG06
+						;; size=21 bbWeight=4 PerfScore 29.00
+G_M35784_IG13:        ; bbWeight=0.50, gcrefRegs=0082 {rcx rdi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax rbx]
        imul     edx, esi, 60
-       jo       SHORT G_M35784_IG15
+       jo       SHORT G_M35784_IG16
        mov      r8d, 0xD1FFAB1E
        mov      eax, r8d
        imul     edx:eax, edx
@@ -214,28 +209,28 @@ G_M35784_IG12:        ; bbWeight=0.50, gcrefRegs=0082 {rcx rdi}, byrefRegs=0000
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx rdi]
        ; byrRegs -[rcx]
-       jmp      SHORT G_M35784_IG17
+       jmp      SHORT G_M35784_IG18
 						;; size=43 bbWeight=0.50 PerfScore 6.38
-G_M35784_IG13:        ; bbWeight=8, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+G_M35784_IG14:        ; bbWeight=8, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rbx rdi]
-       mov      dword ptr [rbp-0x4C], edx
-       jmp      SHORT G_M35784_IG09
-						;; size=5 bbWeight=8 PerfScore 24.00
-G_M35784_IG14:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       mov      edx, dword ptr [rbp-0x4C]
+       mov      dword ptr [rbp-0x58], edx
        jmp      SHORT G_M35784_IG10
+						;; size=5 bbWeight=8 PerfScore 24.00
+G_M35784_IG15:        ; bbWeight=1, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
+       mov      edx, dword ptr [rbp-0x58]
+       jmp      SHORT G_M35784_IG11
 						;; size=5 bbWeight=1 PerfScore 3.00
-G_M35784_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M35784_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx rdi]
        call     CORINFO_HELP_OVERFLOW
        ; gcr arg pop 0
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M35784_IG16:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M35784_IG17:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M35784_IG17:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M35784_IG18:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rcx, gword ptr [rbp+0x10]
        ; gcrRegs +[rcx]
        call     <unknown method>
@@ -243,7 +238,7 @@ G_M35784_IG17:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcr arg pop 0
        nop      
 						;; size=10 bbWeight=1 PerfScore 2.25
...

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+13.95%</span>) : 17528.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,26 +8,30 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T04] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]>
-;  V01 arg1         [V01,T00] (  4, 10   )     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
-;  V02 arg2         [V02,T01] (  4, 10   )     int  ->  rsi         single-def
+;  V01 arg1         [V01,T00] (  4,  6.50)     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
+;  V02 arg2         [V02,T01] (  4,  6.50)     int  ->  rsi         single-def
 ;  V03 loc0         [V03,T03] (  3,  6   )     ref  ->  rdi         class-hnd single-def <System.__Canon>
 ;  V04 loc1         [V04    ] (  2,  4.50)  struct ( 8) [rsp+0x28]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Threading.SpinWait>
 ;* V05 loc2         [V05    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd <System.__Canon>
 ;  V06 loc3         [V06,T02] (  3,  8.50)     ref  ->  rax         class-hnd <System.__Canon>
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08    ] (  2,  4.50)     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V04._count (fldOffset=0x0)" P-DEP
+;  V09 cse0         [V09,T05] (  2,  4.50)     int  ->  rbp         hoist "CSE - aggressive"
+;  V10 cse1         [V10,T06] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 48
 
 G_M27789_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
        sub      rsp, 48
        mov      rbx, rdx
        ; gcrRegs +[rbx]
        mov      esi, r8d
-						;; size=13 bbWeight=1 PerfScore 3.75
+						;; size=16 bbWeight=1 PerfScore 5.75
 G_M27789_IG02:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rdi, gword ptr [rcx+0x08]
@@ -43,20 +47,23 @@ G_M27789_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 G_M27789_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 48
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M27789_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax] +[rbx rdi]
        xor      ecx, ecx
        mov      dword ptr [rsp+0x28], ecx
-						;; size=6 bbWeight=0.50 PerfScore 0.62
+       mov      ebp, dword ptr [rbx+0x08]
+       mov      r14d, esi
+						;; size=12 bbWeight=0.50 PerfScore 1.75
 G_M27789_IG06:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       cmp      esi, dword ptr [rbx+0x08]
+       cmp      esi, ebp
        jae      SHORT G_M27789_IG08
-       mov      ecx, esi
-       mov      rax, gword ptr [rbx+8*rcx+0x10]
+       mov      rax, gword ptr [rbx+8*r14+0x10]
        ; gcrRegs +[rax]
        cmp      rax, rdi
        jne      SHORT G_M27789_IG07
@@ -66,15 +73,17 @@ G_M27789_IG06:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {},
        ; gcrRegs -[rax]
        ; gcr arg pop 0
        jmp      SHORT G_M27789_IG06
-						;; size=34 bbWeight=4 PerfScore 45.00
+						;; size=31 bbWeight=4 PerfScore 33.00
 G_M27789_IG07:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rbx rdi] +[rax]
        add      rsp, 48
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M27789_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        call     CORINFO_HELP_RNGCHKFAIL
@@ -82,7 +91,7 @@ G_M27789_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 86, prolog size 7, PerfScore 55.50, instruction count 34, allocated bytes for code 86 (MethodHash=c9799372) for method Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
+; Total bytes of code 98, prolog size 10, PerfScore 47.62, instruction count 41, allocated bytes for code 98 (MethodHash=c9799372) for method Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -90,12 +99,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
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
<summary><span style="color:red">+12</span> (<span style="color:red">+13.95%</span>) : 22875.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,26 +8,30 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T04] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]>
-;  V01 arg1         [V01,T00] (  4, 10   )     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
-;  V02 arg2         [V02,T01] (  4, 10   )     int  ->  rsi         single-def
+;  V01 arg1         [V01,T00] (  4,  6.50)     ref  ->  rbx         class-hnd single-def <System.__Canon[]>
+;  V02 arg2         [V02,T01] (  4,  6.50)     int  ->  rsi         single-def
 ;  V03 loc0         [V03,T03] (  3,  6   )     ref  ->  rdi         class-hnd single-def <System.__Canon>
 ;  V04 loc1         [V04    ] (  2,  4.50)  struct ( 8) [rsp+0x28]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Threading.SpinWait>
 ;* V05 loc2         [V05    ] (  0,  0   )     ref  ->  zero-ref    ld-addr-op class-hnd <System.__Canon>
 ;  V06 loc3         [V06,T02] (  3,  8.50)     ref  ->  rax         class-hnd <System.__Canon>
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08    ] (  2,  4.50)     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V04._count (fldOffset=0x0)" P-DEP
+;  V09 cse0         [V09,T05] (  2,  4.50)     int  ->  rbp         hoist "CSE - aggressive"
+;  V10 cse1         [V10,T06] (  2,  4.50)    long  ->  r14         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 48
 
 G_M27789_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
+       push     rbp
        push     rbx
        sub      rsp, 48
        mov      rbx, rdx
        ; gcrRegs +[rbx]
        mov      esi, r8d
-						;; size=13 bbWeight=1 PerfScore 3.75
+						;; size=16 bbWeight=1 PerfScore 5.75
 G_M27789_IG02:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rdi, gword ptr [rcx+0x08]
@@ -43,20 +47,23 @@ G_M27789_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 G_M27789_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 48
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M27789_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax] +[rbx rdi]
        xor      ecx, ecx
        mov      dword ptr [rsp+0x28], ecx
-						;; size=6 bbWeight=0.50 PerfScore 0.62
+       mov      ebp, dword ptr [rbx+0x08]
+       mov      r14d, esi
+						;; size=12 bbWeight=0.50 PerfScore 1.75
 G_M27789_IG06:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {}, byref, isz
-       cmp      esi, dword ptr [rbx+0x08]
+       cmp      esi, ebp
        jae      SHORT G_M27789_IG08
-       mov      ecx, esi
-       mov      rax, gword ptr [rbx+8*rcx+0x10]
+       mov      rax, gword ptr [rbx+8*r14+0x10]
        ; gcrRegs +[rax]
        cmp      rax, rdi
        jne      SHORT G_M27789_IG07
@@ -66,15 +73,17 @@ G_M27789_IG06:        ; bbWeight=4, gcrefRegs=0088 {rbx rdi}, byrefRegs=0000 {},
        ; gcrRegs -[rax]
        ; gcr arg pop 0
        jmp      SHORT G_M27789_IG06
-						;; size=34 bbWeight=4 PerfScore 45.00
+						;; size=31 bbWeight=4 PerfScore 33.00
 G_M27789_IG07:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rbx rdi] +[rax]
        add      rsp, 48
        pop      rbx
+       pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=11 bbWeight=0.50 PerfScore 1.88
 G_M27789_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax]
        call     CORINFO_HELP_RNGCHKFAIL
@@ -82,7 +91,7 @@ G_M27789_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 86, prolog size 7, PerfScore 55.50, instruction count 34, allocated bytes for code 86 (MethodHash=c9799372) for method Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
+; Total bytes of code 98, prolog size 10, PerfScore 47.62, instruction count 41, allocated bytes for code 98 (MethodHash=c9799372) for method Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -90,12 +99,14 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x0A
+  CountOfUnwindCodes: 6
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
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
<summary><span style="color:red">+36</span> (<span style="color:red">+14.06%</span>) : 26718.dasm - System.SpanHelpers:NonPackedIndexOfAnyInRangeUnsignedNumber[ulong,System.SpanHelpers+DontNegate`1[ulong]](byref,ulong,ulong,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -15,7 +15,7 @@
 ;  V05 loc1         [V05,T01] (  6, 17   )     int  ->  rax        
 ;* V06 loc2         [V06    ] (  0,  0   )   byref  ->  zero-ref   
 ;  V07 loc3         [V07,T17] (  3,  5   )  simd16  ->  mm0         <System.Runtime.Intrinsics.Vector128`1[ulong]>
-;  V08 loc4         [V08,T16] (  5,  9.50)  simd16  ->  mm1         <System.Runtime.Intrinsics.Vector128`1[ulong]>
+;  V08 loc4         [V08,T15] (  4,  5.50)  simd16  ->  mm1         <System.Runtime.Intrinsics.Vector128`1[ulong]>
 ;* V09 loc5         [V09    ] (  0,  0   )  simd16  ->  zero-ref    <System.Runtime.Intrinsics.Vector128`1[ulong]>
 ;  V10 loc6         [V10,T00] (  7, 17.50)   byref  ->  rax        
 ;  V11 loc7         [V11,T06] (  3,  5   )   byref  ->   r8         single-def
@@ -30,16 +30,16 @@
 ;* V20 loc16        [V20    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V21 loc17        [V21    ] (  0,  0   )   byref  ->  zero-ref   
 ;# V22 OutArgs      [V22    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V23 tmp1         [V23,T14] (  3, 24   )  simd16  ->  mm2         "fgMakeTemp is creating a new local variable"
-;  V24 tmp2         [V24,T19] (  3,  3   )  simd16  ->  mm2         "fgMakeTemp is creating a new local variable"
+;  V23 tmp1         [V23,T14] (  3, 24   )  simd16  ->  mm4         "fgMakeTemp is creating a new local variable"
+;  V24 tmp2         [V24,T20] (  3,  3   )  simd16  ->  mm4         "fgMakeTemp is creating a new local variable"
 ;* V25 tmp3         [V25    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V26 tmp4         [V26    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp5         [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V28 tmp6         [V28,T13] (  4, 25   )  simd16  ->  mm2         "Inlining Arg" <System.Runtime.Intrinsics.Vector128`1[ulong]>
+;  V28 tmp6         [V28,T13] (  4, 25   )  simd16  ->  mm4         "Inlining Arg" <System.Runtime.Intrinsics.Vector128`1[ulong]>
 ;  V29 tmp7         [V29,T08] (  3,  1.50)     int  ->  rdx         "Inline stloc first use temp"
 ;* V30 tmp8         [V30    ] (  0,  0   )     int  ->  zero-ref    "Grabbing temp for TrailingZeroCount Qmark"
 ;  V31 tmp9         [V31,T11] (  2,  1   )     int  ->   r8         "Inline stloc first use temp"
-;  V32 tmp10        [V32,T18] (  4,  4   )  simd16  ->  mm1         "Inlining Arg" <System.Runtime.Intrinsics.Vector128`1[ulong]>
+;  V32 tmp10        [V32,T19] (  4,  4   )  simd16  ->  mm1         "Inlining Arg" <System.Runtime.Intrinsics.Vector128`1[ulong]>
 ;  V33 tmp11        [V33,T09] (  3,  1.50)     int  ->  rax         "Inline stloc first use temp"
 ;* V34 tmp12        [V34    ] (  0,  0   )     int  ->  zero-ref    "Grabbing temp for TrailingZeroCount Qmark"
 ;  V35 tmp13        [V35,T12] (  2,  1   )     int  ->  rax         "Inline stloc first use temp"
@@ -50,14 +50,17 @@
 ;* V40 tmp18        [V40    ] (  0,  0   )  simd16  ->  zero-ref    "field V14._lower (fldOffset=0x0)" P-INDEP
 ;* V41 tmp19        [V41    ] (  0,  0   )  simd16  ->  zero-ref    "field V14._upper (fldOffset=0x10)" P-INDEP
 ;  V42 cse0         [V42,T10] (  3,  1.50)    long  ->  rdx         "CSE - moderate"
-;  V43 cse1         [V43,T15] (  5, 13   )  simd16  ->  mm3         "CSE - moderate"
-;  V44 rat0         [V44,T20] (  3,  3   )  simd16  ->  mm0         "ReplaceWithLclVar is creating a new local variable"
-;  V45 rat1         [V45,T21] (  3,  3   )  simd16  ->  mm1         "ReplaceWithLclVar is creating a new local variable"
+;  V43 cse1         [V43,T18] (  3,  5   )  simd16  ->  mm3         hoist "CSE - moderate"
+;  V44 cse2         [V44,T16] (  4,  5.50)  simd16  ->  mm2         hoist "CSE - moderate"
+;  V45 rat0         [V45,T21] (  3,  3   )  simd16  ->  mm0         "ReplaceWithLclVar is creating a new local variable"
+;  V46 rat1         [V46,T22] (  3,  3   )  simd16  ->  mm1         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 24
 
 G_M15618_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
+       sub      rsp, 24
+       movaps   xmmword ptr [rsp], xmm6
+						;; size=8 bbWeight=1 PerfScore 2.25
 G_M15618_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        ; byrRegs +[rcx]
        cmp      r9d, 2
@@ -84,8 +87,10 @@ G_M15618_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        jmp      G_M15618_IG13
 						;; size=5 bbWeight=0.50 PerfScore 1.00
 G_M15618_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       movaps   xmm6, xmmword ptr [rsp]
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
+						;; size=9 bbWeight=0.50 PerfScore 2.62
 G_M15618_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, gcvars, byref
        ; byrRegs +[rcx]
        movd     xmm0, rdx
@@ -101,35 +106,34 @@ G_M15618_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        shl      rdx, 3
        lea      r8, bword ptr [rax+rdx]
        ; byrRegs +[r8]
-						;; size=42 bbWeight=0.50 PerfScore 4.12
+       movups   xmm2, xmmword ptr [reloc @RWD00]
+       movaps   xmm3, xmm1
+       psubq    xmm3, xmm2
+						;; size=56 bbWeight=0.50 PerfScore 5.92
 G_M15618_IG08:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0103 {rax rcx r8}, byref, isz
-       movups   xmm2, xmmword ptr [rax]
-       psubq    xmm2, xmm0
-       movups   xmm3, xmmword ptr [reloc @RWD00]
-       movaps   xmm4, xmm2
-       psubq    xmm4, xmm3
-       movaps   xmm5, xmm1
-       psubq    xmm5, xmm3
-       pcmpgtq  xmm5, xmm4
-       pcmpeqq  xmm2, xmm1
-       por      xmm2, xmm5
-       ptest    xmm2, xmm2
+       movups   xmm4, xmmword ptr [rax]
+       psubq    xmm4, xmm0
+       movaps   xmm5, xmm4
+       psubq    xmm5, xmm2
+       movaps   xmm6, xmm3
+       pcmpgtq  xmm6, xmm5
+       pcmpeqq  xmm4, xmm1
+       por      xmm4, xmm6
+       ptest    xmm4, xmm4
        jne      SHORT G_M15618_IG11
        add      rax, 16
        cmp      rax, r8
        jb       SHORT G_M15618_IG08
-						;; size=58 bbWeight=4 PerfScore 67.33
+						;; size=47 bbWeight=4 PerfScore 54.00
 G_M15618_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0100 {r8}, byref, isz
        ; byrRegs -[rax rcx]
-       movups   xmm2, xmmword ptr [r8]
-       psubq    xmm2, xmm0
-       movaps   xmm0, xmm2
-       psubq    xmm0, xmm3
-       movaps   xmm4, xmm1
-       psubq    xmm4, xmm3
-       pcmpgtq  xmm4, xmm0
-       pcmpeqq  xmm1, xmm2
-       por      xmm1, xmm4
+       movups   xmm4, xmmword ptr [r8]
+       psubq    xmm4, xmm0
+       movaps   xmm0, xmm4
+       psubq    xmm0, xmm2
+       pcmpgtq  xmm3, xmm0
+       pcmpeqq  xmm1, xmm4
+       por      xmm1, xmm3
        ptest    xmm1, xmm1
        je       SHORT G_M15618_IG13
        movmskpd rax, xmm1
@@ -141,13 +145,15 @@ G_M15618_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0100 {r8}, b
        mov      eax, ecx
        shr      rdx, 3
        add      eax, edx
-						;; size=70 bbWeight=0.50 PerfScore 9.04
+						;; size=63 bbWeight=0.50 PerfScore 8.75
 G_M15618_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+       movaps   xmm6, xmmword ptr [rsp]
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
+						;; size=9 bbWeight=0.50 PerfScore 2.62
 G_M15618_IG11:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0003 {rax rcx}, gcvars, byref
        ; byrRegs +[rax rcx]
-       movmskpd rdx, xmm2
+       movmskpd rdx, xmm4
        bsf      r8d, edx
        mov      r10d, 32
        test     edx, edx
@@ -158,19 +164,23 @@ G_M15618_IG11:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        add      eax, r8d
 						;; size=30 bbWeight=0.50 PerfScore 2.88
 G_M15618_IG12:        ; bbWeight=0.50, epilog, nogc, extend
+       movaps   xmm6, xmmword ptr [rsp]
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
+						;; size=9 bbWeight=0.50 PerfScore 2.62
 G_M15618_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; byrRegs -[rcx]
        mov      eax, -1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M15618_IG14:        ; bbWeight=0.50, epilog, nogc, extend
+       movaps   xmm6, xmmword ptr [rsp]
+       add      rsp, 24
        ret      
-						;; size=1 bbWeight=0.50 PerfScore 0.50
+						;; size=9 bbWeight=0.50 PerfScore 2.62
 RWD00  	dq	8000000000000000h, 8000000000000000h
 
 
-; Total bytes of code 256, prolog size 0, PerfScore 109.63, instruction count 73, allocated bytes for code 256 (MethodHash=a17ac2fd) for method System.SpanHelpers:NonPackedIndexOfAnyInRangeUnsignedNumber[ulong,System.SpanHelpers+DontNegate`1[ulong]](byref,ulong,ulong,int):int (FullOpts)
+; Total bytes of code 292, prolog size 8, PerfScore 108.54, instruction count 82, allocated bytes for code 292 (MethodHash=a17ac2fd) for method System.SpanHelpers:NonPackedIndexOfAnyInRangeUnsignedNumber[ulong,System.SpanHelpers+DontNegate`1[ulong]](byref,ulong,ulong,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -178,8 +188,11 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x08
+  CountOfUnwindCodes: 3
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x08 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 0 * 16 = 0 = 0x00000
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
|benchmarks.run.windows.x64.checked.mch|1,456|<span style="color:green">140</span>|<span style="color:red">1,081</span>|<span style="color:blue">235</span>|<span style="color:green">-1,693</span>|<span style="color:red">+15,865</span>|<span style="color:green">-0.3664%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|1,880|<span style="color:green">400</span>|<span style="color:red">1,060</span>|<span style="color:blue">420</span>|<span style="color:green">-7,080</span>|<span style="color:red">+19,458</span>|<span style="color:green">-0.1857%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|607|<span style="color:green">62</span>|<span style="color:red">494</span>|<span style="color:blue">51</span>|<span style="color:green">-735</span>|<span style="color:red">+9,222</span>|<span style="color:green">-0.3107%</span>|
|coreclr_tests.run.windows.x64.checked.mch|9,187|<span style="color:green">2,555</span>|<span style="color:red">6,120</span>|<span style="color:blue">512</span>|<span style="color:green">-38,514</span>|<span style="color:red">+47,275</span>|<span style="color:green">-0.0638%</span>|
|libraries.crossgen2.windows.x64.checked.mch|7,223|<span style="color:green">541</span>|<span style="color:red">6,058</span>|<span style="color:blue">624</span>|<span style="color:green">-3,833</span>|<span style="color:red">+66,059</span>|<span style="color:green">-0.1799%</span>|
|libraries.pmi.windows.x64.checked.mch|4,088|<span style="color:green">540</span>|<span style="color:red">2,993</span>|<span style="color:blue">555</span>|<span style="color:green">-3,919</span>|<span style="color:red">+32,521</span>|<span style="color:green">-0.1225%</span>|
|libraries_tests.run.windows.x64.Release.mch|10,314|<span style="color:green">1,372</span>|<span style="color:red">7,816</span>|<span style="color:blue">1,126</span>|<span style="color:green">-15,931</span>|<span style="color:red">+96,974</span>|<span style="color:green">-0.0276%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|6,904|<span style="color:green">550</span>|<span style="color:red">5,777</span>|<span style="color:blue">577</span>|<span style="color:green">-5,525</span>|<span style="color:red">+110,933</span>|<span style="color:green">-0.0544%</span>|
|realworld.run.windows.x64.checked.mch|732|<span style="color:green">96</span>|<span style="color:red">540</span>|<span style="color:blue">96</span>|<span style="color:green">-1,294</span>|<span style="color:red">+8,767</span>|<span style="color:green">-0.1422%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|612|<span style="color:green">83</span>|<span style="color:red">419</span>|<span style="color:blue">110</span>|<span style="color:green">-738</span>|<span style="color:red">+3,797</span>|<span style="color:green">-0.1381%</span>|
||43,003|<span style="color:green">6,339</span>|<span style="color:red">32,358</span>|<span style="color:blue">4,306</span>|<span style="color:green">-79,262</span>|<span style="color:red">+410,871</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,911|4|35,907|183 (0.51%)|188 (0.52%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,827|49,607|52,220|33 (0.03%)|33 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|55,006|37,307|17,699|36 (0.07%)|36 (0.07%)|
|coreclr_tests.run.windows.x64.checked.mch|581,523|347,882|233,641|2,564 (0.44%)|2,567 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,705|15|275,690|65 (0.02%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|313,092|6|313,086|1,199 (0.38%)|1,206 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|697,494|498,513|198,981|2,613 (0.37%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|320,777|21,946|298,831|118 (0.04%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,689|3|36,686|212 (0.57%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,537|11|32,526|41 (0.13%)|41 (0.13%)|
||2,450,561|955,294|1,495,267|7,064 (0.29%)|7,147 (0.29%)|


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

Total bytes of base: 11402760 (overridden on cmd)
Total bytes of diff: 11416932 (overridden on cmd)
Total bytes of delta: 14172 (0.12 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         250 : 35459.dasm (13.35% of base)
         191 : 30363.dasm (5.92% of base)
         156 : 16301.dasm (39.80% of base)
         124 : 24302.dasm (4.17% of base)
         118 : 23009.dasm (30.41% of base)
         116 : 29698.dasm (4.75% of base)
         109 : 35366.dasm (17.25% of base)
         103 : 32246.dasm (32.70% of base)
         100 : 26742.dasm (8.09% of base)
          94 : 26535.dasm (2.59% of base)
          91 : 21693.dasm (18.61% of base)
          86 : 3508.dasm (2.12% of base)
          86 : 18258.dasm (2.12% of base)
          84 : 25611.dasm (3.83% of base)
          80 : 23298.dasm (6.81% of base)
          76 : 13701.dasm (3.63% of base)
          76 : 1128.dasm (3.73% of base)
          73 : 31753.dasm (1.50% of base)
          72 : 17967.dasm (5.89% of base)
          72 : 30712.dasm (18.90% of base)

Top file improvements (bytes):
        -190 : 25721.dasm (-6.65% of base)
        -163 : 31928.dasm (-21.79% of base)
        -122 : 32483.dasm (-18.21% of base)
         -44 : 3034.dasm (-4.01% of base)
         -42 : 17042.dasm (-3.26% of base)
         -42 : 1344.dasm (-3.26% of base)
         -41 : 6813.dasm (-11.55% of base)
         -40 : 6663.dasm (-6.86% of base)
         -37 : 31184.dasm (-8.26% of base)
         -35 : 21145.dasm (-3.44% of base)
         -35 : 25960.dasm (-2.84% of base)
         -32 : 5785.dasm (-3.07% of base)
         -28 : 19661.dasm (-8.78% of base)
         -28 : 2940.dasm (-8.78% of base)
         -24 : 8840.dasm (-2.49% of base)
         -23 : 25901.dasm (-7.03% of base)
         -22 : 23622.dasm (-5.96% of base)
         -21 : 31726.dasm (-2.91% of base)
         -19 : 2406.dasm (-5.01% of base)
         -18 : 8582.dasm (-0.15% of base)

76 total files with Code Size differences (31 improved, 45 regressed), 20 unchanged.

Top method regressions (bytes):
         250 (13.35% of base) : 35459.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
         191 ( 5.92% of base) : 30363.dasm - PerfLabTests.GetMember:GetMethod20():this (FullOpts)
         156 (39.80% of base) : 16301.dasm - Benchstone.BenchF.Adams:Bench() (FullOpts)
         124 ( 4.17% of base) : 24302.dasm - LUDecomp:ludcmp(double[][],int,int[],byref):int (FullOpts)
         118 (30.41% of base) : 23009.dasm - Benchstone.BenchF.DMath:Bench(int):ubyte (FullOpts)
         116 ( 4.75% of base) : 29698.dasm - PerfLabTests.GetMember:GetMethod15():this (FullOpts)
         109 (17.25% of base) : 35366.dasm - SciMark2.FFT:transform_internal(double[],int) (FullOpts)
         103 (32.70% of base) : 32246.dasm - Benchstone.MDBenchI.MDGeneralArray:Bench(int,int[,,],int[,,]):ubyte (FullOpts)
         100 ( 8.09% of base) : 26742.dasm - Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker:VisitAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):this (FullOpts)
          94 ( 2.59% of base) : 26535.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:MakeParameters[System.__Canon,System.__Canon,System.__Canon](Microsoft.CodeAnalysis.CSharp.Binder,System.__Canon,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[System.__Canon],byref,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte,ubyte,ubyte,int,System.Func`12[System.__Canon,System.__Canon,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.__Canon,ubyte,int,Microsoft.CodeAnalysis.SyntaxToken,Microsoft.CodeAnalysis.SyntaxToken,ubyte,ubyte,System.__Canon,System.__Canon],ubyte):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (FullOpts)
          91 (18.61% of base) : 21693.dasm - AssignJagged:Run():double:this (FullOpts)
          86 ( 2.12% of base) : 3508.dasm - Sigil.Emit`1[System.__Canon]:ValidateTryCatchFinallyBranches():this (FullOpts)
          86 ( 2.12% of base) : 18258.dasm - Sigil.Emit`1[System.__Canon]:ValidateTryCatchFinallyBranches():this (FullOpts)
          84 ( 3.83% of base) : 25611.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:TryAddAssembly(Microsoft.CodeAnalysis.AssemblyIdentity,Microsoft.CodeAnalysis.MetadataReference,int,Microsoft.CodeAnalysis.DiagnosticBag,Microsoft.CodeAnalysis.Location,System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon],ubyte):Microsoft.CodeAnalysis.MetadataReference:this (FullOpts)
          80 ( 6.81% of base) : 23298.dasm - System.Xml.XmlLoader:LoadNode(ubyte):System.Xml.XmlNode:this (FullOpts)
          76 ( 3.63% of base) : 13701.dasm - System.Threading.PortableThreadPool+GateThread:GateThreadStart() (FullOpts)
          76 ( 3.73% of base) : 1128.dasm - System.Threading.PortableThreadPool+GateThread:GateThreadStart() (FullOpts)
          73 ( 1.50% of base) : 31753.dasm - System.Xml.Schema.XsdDuration:TryFormat(System.Span`1[ushort],byref,int):ubyte:this (FullOpts)
          72 (18.90% of base) : 30712.dasm - Benchstone.BenchF.Regula:Test():ubyte:this (FullOpts)
          72 ( 5.89% of base) : 17967.dasm - System.Reflection.RuntimeCustomAttributeData:.ctor(System.Reflection.RuntimeModule,System.Reflection.MetadataToken,byref):this (FullOpts)

Top method improvements (bytes):
        -190 (-6.65% of base) : 25721.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -163 (-21.79% of base) : 31928.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (FullOpts)
        -122 (-18.21% of base) : 32483.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (FullOpts)
         -44 (-4.01% of base) : 3034.dasm - System.Collections.Generic.GenericArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon]):int (FullOpts)
         -42 (-3.26% of base) : 17042.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (FullOpts)
         -42 (-3.26% of base) : 1344.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (FullOpts)
         -41 (-11.55% of base) : 6813.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (FullOpts)
         -40 (-6.86% of base) : 6663.dasm - V8.Crypto.RSAKey:doPrivate(V8.Crypto.BigInteger):V8.Crypto.BigInteger:this (FullOpts)
         -37 (-8.26% of base) : 31184.dasm - Benchstone.MDBenchF.MDInvMt:Inner(double[,],byref,byref) (FullOpts)
         -35 (-3.44% of base) : 21145.dasm - Fourier:DoFPUTransIteration(double[],double[],int):long (FullOpts)
         -35 (-2.84% of base) : 25960.dasm - Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]:ToDictionary[System.ReadOnlyMemory`1[ushort]](System.Func`2[System.__Canon,System.ReadOnlyMemory`1[ushort]],System.Collections.Generic.IEqualityComparer`1[System.ReadOnlyMemory`1[ushort]]):System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]:this (FullOpts)
         -32 (-3.07% of base) : 5785.dasm - Utf8Json.Resolvers.Internal.DynamicObjectTypeBuilder:BuildConstructor(System.Reflection.Emit.TypeBuilder,Utf8Json.Internal.Emit.MetaType,System.Reflection.ConstructorInfo,System.Reflection.Emit.FieldBuilder,System.Reflection.Emit.ILGenerator,ubyte,ubyte):System.Collections.Generic.Dictionary`2[Utf8Json.Internal.Emit.MetaMember,System.Reflection.FieldInfo] (FullOpts)
         -28 (-8.78% of base) : 19661.dasm - System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
         -28 (-8.78% of base) : 2940.dasm - System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
         -24 (-2.49% of base) : 8840.dasm - System.Text.RegularExpressions.Symbolic.BDD:Deserialize(System.ReadOnlySpan`1[ubyte]):System.Text.RegularExpressions.Symbolic.BDD (FullOpts)
         -23 (-7.03% of base) : 25901.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
         -22 (-5.96% of base) : 23622.dasm - Neural:zero_changes() (FullOpts)
         -21 (-2.91% of base) : 31726.dasm - Benchstone.BenchF.SqMtx:Inner(double[][],double[][],int) (FullOpts)
         -19 (-5.01% of base) : 2406.dasm - System.SpanHelpers:LastIndexOfValueType[ubyte,System.SpanHelpers+DontNegate`1[ubyte]](byref,ubyte,int):int (FullOpts)
         -18 (-0.15% of base) : 8582.dasm - MessagePack.MessagePackBinary:.cctor() (FullOpts)

Top method regressions (percentages):
          28 (46.67% of base) : 35433.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
         156 (39.80% of base) : 16301.dasm - Benchstone.BenchF.Adams:Bench() (FullOpts)
          68 (38.42% of base) : 32247.dasm - Benchstone.MDBenchI.MDGeneralArray:Initialize(int[,,]) (FullOpts)
         103 (32.70% of base) : 32246.dasm - Benchstone.MDBenchI.MDGeneralArray:Bench(int,int[,,],int[,,]):ubyte (FullOpts)
         118 (30.41% of base) : 23009.dasm - Benchstone.BenchF.DMath:Bench(int):ubyte (FullOpts)
          12 (24.00% of base) : 35848.dasm - System.Reflection.Invoke:Ctor0_ActivatorCreateInstance_NoParams():this (FullOpts)
          63 (22.83% of base) : 32248.dasm - Benchstone.MDBenchI.MDGeneralArray:VerifyCopy(int[,,],int[,,]):ubyte (FullOpts)
          10 (19.61% of base) : 10317.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (FullOpts)
          10 (19.61% of base) : 16082.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (FullOpts)
          10 (19.61% of base) : 32746.dasm - PerfLabTests.CastingPerf:ObjFooIsObj():this (FullOpts)
          10 (19.61% of base) : 34944.dasm - PerfLabTests.CastingPerf:ObjFooIsObj2():this (FullOpts)
          10 (19.61% of base) : 23006.dasm - PerfLabTests.CastingPerf:ObjInt():this (FullOpts)
          10 (19.61% of base) : 28412.dasm - PerfLabTests.CastingPerf:ObjObjrefValueType():this (FullOpts)
          10 (19.61% of base) : 23830.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (FullOpts)
          57 (19.26% of base) : 7982.dasm - BilinearTest:Setup():this (FullOpts)
          17 (19.10% of base) : 21697.dasm - AssignJagged:CopyToAssign(int[][],int[][]) (FullOpts)
          72 (18.90% of base) : 30712.dasm - Benchstone.BenchF.Regula:Test():ubyte:this (FullOpts)
          91 (18.61% of base) : 21693.dasm - AssignJagged:Run():double:this (FullOpts)
           9 (17.65% of base) : 24369.dasm - PerfLabTests.LowLevelPerf:TypeReflectionArrayGetType():System.Type:this (FullOpts)
           9 (17.65% of base) : 23878.dasm - PerfLabTests.LowLevelPerf:TypeReflectionObjectGetType():System.Type:this (FullOpts)

Top method improvements (percentages):
        -163 (-21.79% of base) : 31928.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (FullOpts)
        -122 (-18.21% of base) : 32483.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (FullOpts)
         -41 (-11.55% of base) : 6813.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (FullOpts)
         -28 (-8.78% of base) : 19661.dasm - System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
         -28 (-8.78% of base) : 2940.dasm - System.Numerics.Tests.Perf_BigInteger+BigIntegers:CreateRandomInteger(System.Random,int):System.Numerics.BigInteger (FullOpts)
         -37 (-8.26% of base) : 31184.dasm - Benchstone.MDBenchF.MDInvMt:Inner(double[,],byref,byref) (FullOpts)
         -23 (-7.03% of base) : 25901.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
         -40 (-6.86% of base) : 6663.dasm - V8.Crypto.RSAKey:doPrivate(V8.Crypto.BigInteger):V8.Crypto.BigInteger:this (FullOpts)
          -4 (-6.78% of base) : 13114.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (FullOpts)
          -4 (-6.78% of base) : 757.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (FullOpts)
        -190 (-6.65% of base) : 25721.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
         -13 (-6.13% of base) : 24686.dasm - Benchstone.MDBenchI.MDArray2:VerifyCopy(int[,,],int[,,]):ubyte (FullOpts)
         -22 (-5.96% of base) : 23622.dasm - Neural:zero_changes() (FullOpts)
          -8 (-5.48% of base) : 26640.dasm - Microsoft.CodeAnalysis.CSharp.MostCommonNullableValueBuilder:GetCommonValue(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte]):System.Nullable`1[ubyte] (FullOpts)
         -19 (-5.01% of base) : 2406.dasm - System.SpanHelpers:LastIndexOfValueType[ubyte,System.SpanHelpers+DontNegate`1[ubyte]](byref,ubyte,int):int (FullOpts)
         -44 (-4.01% of base) : 3034.dasm - System.Collections.Generic.GenericArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon]):int (FullOpts)
          -6 (-4.00% of base) : 25479.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (FullOpts)
          -8 (-3.88% of base) : 29533.dasm - Benchstone.BenchI.QuickSort:Test():ubyte:this (FullOpts)
         -13 (-3.88% of base) : 29650.dasm - System.Collections.IterateForEach`1[System.__Canon]:ImmutableHashSet():System.__Canon:this (FullOpts)
          -8 (-3.85% of base) : 32702.dasm - Benchstone.BenchI.Array1:Test():ubyte:this (FullOpts)

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

Total bytes of base: 35444635 (overridden on cmd)
Total bytes of diff: 35457013 (overridden on cmd)
Total bytes of delta: 12378 (0.03 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         229 : 82573.dasm (2.04% of base)
         189 : 45100.dasm (9.45% of base)
         183 : 45076.dasm (8.90% of base)
         181 : 82561.dasm (1.61% of base)
         179 : 51862.dasm (3.00% of base)
         172 : 96563.dasm (12.21% of base)
         172 : 96568.dasm (12.21% of base)
         166 : 96567.dasm (8.36% of base)
         129 : 99542.dasm (9.38% of base)
         121 : 51857.dasm (3.97% of base)
         119 : 101460.dasm (3.48% of base)
         115 : 55933.dasm (1.23% of base)
         113 : 89621.dasm (14.85% of base)
         113 : 96099.dasm (14.85% of base)
         113 : 87128.dasm (14.85% of base)
         113 : 91565.dasm (14.85% of base)
         112 : 97360.dasm (17.47% of base)
         103 : 51864.dasm (4.50% of base)
         103 : 55919.dasm (1.11% of base)
          98 : 38218.dasm (6.05% of base)

Top file improvements (bytes):
        -138 : 50510.dasm (-4.00% of base)
        -138 : 26203.dasm (-4.12% of base)
        -138 : 36006.dasm (-4.12% of base)
        -122 : 8434.dasm (-3.69% of base)
        -117 : 40373.dasm (-3.47% of base)
        -114 : 83637.dasm (-3.54% of base)
        -112 : 78564.dasm (-3.50% of base)
        -111 : 19607.dasm (-3.41% of base)
        -107 : 97146.dasm (-3.17% of base)
        -104 : 49168.dasm (-3.19% of base)
        -104 : 101616.dasm (-3.23% of base)
        -104 : 47531.dasm (-3.19% of base)
        -104 : 87289.dasm (-3.10% of base)
        -104 : 44388.dasm (-3.19% of base)
        -104 : 99169.dasm (-3.22% of base)
        -104 : 84282.dasm (-3.22% of base)
        -104 : 75596.dasm (-3.26% of base)
        -104 : 90093.dasm (-3.23% of base)
        -104 : 53529.dasm (-3.26% of base)
        -104 : 17231.dasm (-3.26% of base)

84 total files with Code Size differences (44 improved, 40 regressed), 20 unchanged.

Top method regressions (bytes):
         229 ( 2.04% of base) : 82573.dasm - Benchstone.MDBenchF.MDLLoops:Main1(int):this (Tier1-OSR)
         189 ( 9.45% of base) : 45100.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
         183 ( 8.90% of base) : 45076.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
         181 ( 1.61% of base) : 82561.dasm - Benchstone.MDBenchF.MDLLoops:Main1(int):this (Tier1-OSR)
         179 ( 3.00% of base) : 51862.dasm - LUDecomp:Run():double:this (Tier1)
         172 (12.21% of base) : 96563.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
         172 (12.21% of base) : 96568.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
         166 ( 8.36% of base) : 96567.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         129 ( 9.38% of base) : 99542.dasm - System.Linq.Enumerable:<AggregateByIterator>g__PopulateDictionary|74_0[System.__Canon,System.__Canon,System.Decimal](System.Collections.Generic.IEnumerator`1[System.__Canon],System.Func`2[System.__Canon,System.__Canon],System.Decimal,System.Func`3[System.Decimal,System.__Canon,System.Decimal],System.Collections.Generic.IEqualityComparer`1[System.__Canon]):System.Collections.Generic.Dictionary`2[System.__Canon,System.Decimal] (Tier1)
         121 ( 3.97% of base) : 51857.dasm - LUDecomp:ludcmp(double[][],int,int[],byref):int (Tier1)
         119 ( 3.48% of base) : 101460.dasm - StringSort:Run():double:this (Tier1)
         115 ( 1.23% of base) : 55933.dasm - Benchstone.BenchF.LLoops:Main1(int):this (Tier1-OSR)
         113 (14.85% of base) : 89621.dasm - Burgers:GetAnalytical(double[],double,double):double[] (Tier1-OSR)
         113 (14.85% of base) : 96099.dasm - Burgers:GetAnalytical(double[],double,double):double[] (Tier1-OSR)
         113 (14.85% of base) : 87128.dasm - Burgers:GetAnalytical(double[],double,double):double[] (Tier1-OSR)
         113 (14.85% of base) : 91565.dasm - Burgers:GetAnalytical(double[],double,double):double[] (Tier1-OSR)
         112 (17.47% of base) : 97360.dasm - SciMark2.FFT:transform_internal(double[],int) (Tier1)
         103 ( 1.11% of base) : 55919.dasm - Benchstone.BenchF.LLoops:Main1(int):this (Tier1-OSR)
         103 ( 4.50% of base) : 51864.dasm - LUDecomp:DoLUIteration(double[][],double[],double[][][],double[][],int):long (Tier1)
          98 ( 6.05% of base) : 38218.dasm - System.MathBenchmarks.Double:CosPiDoubleTest() (Tier1-OSR)

Top method improvements (bytes):
        -138 (-4.00% of base) : 50510.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -138 (-4.12% of base) : 26203.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -138 (-4.12% of base) : 36006.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -122 (-3.69% of base) : 8434.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -117 (-3.47% of base) : 40373.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -114 (-3.54% of base) : 83637.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -112 (-3.50% of base) : 78564.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -111 (-3.41% of base) : 19607.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -107 (-3.17% of base) : 97146.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.19% of base) : 49168.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.23% of base) : 101616.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.19% of base) : 47531.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.10% of base) : 87289.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.19% of base) : 44388.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.22% of base) : 99169.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.22% of base) : 84282.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.26% of base) : 75596.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.23% of base) : 90093.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.26% of base) : 53529.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
        -104 (-3.26% of base) : 17231.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)

Top method regressions (percentages):
          39 (33.91% of base) : 90302.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjrefValueTypeObj():this (Tier1-OSR)
          21 (28.77% of base) : 29951.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          21 (28.77% of base) : 36153.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          21 (28.77% of base) : 91604.dasm - PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
          21 (28.77% of base) : 96133.dasm - PerfLabTests.CastingPerf:ObjFooIsObj2():this (Tier1-OSR)
          21 (28.77% of base) : 47138.dasm - PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
          21 (28.77% of base) : 55268.dasm - PerfLabTests.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
          21 (28.77% of base) : 50344.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
          21 (28.77% of base) : 78064.dasm - PerfLabTests.CastingPerf2.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          21 (28.77% of base) : 80418.dasm - PerfLabTests.CastingPerf2.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          21 (28.77% of base) : 73588.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
          31 (27.68% of base) : 25415.dasm - PerfLabTests.CastingPerf2.CastingPerf:IntObj():this (Tier1-OSR)
          29 (27.62% of base) : 54232.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
          40 (27.40% of base) : 88625.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
          33 (26.19% of base) : 41943.dasm - AssignJagged:CopyToAssign(int[][],int[][]) (Tier1-OSR)
          33 (26.19% of base) : 41899.dasm - AssignJagged:CopyToAssign(int[][],int[][]) (Tier1-OSR)
          29 (25.44% of base) : 85604.dasm - PerfLabTests.CastingPerf2.CastingPerf:ScalarValueTypeObj():this (Tier1-OSR)
          26 (24.53% of base) : 8890.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjInt():this (Tier1-OSR)
          54 (19.35% of base) : 39569.dasm - Benchstone.BenchF.BenchMk2:Test():ubyte:this (Tier1-OSR)
          17 (19.10% of base) : 41959.dasm - AssignJagged:CopyToAssign(int[][],int[][]) (Tier1)

Top method improvements (percentages):
         -41 (-11.55% of base) : 15455.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
         -73 (-10.30% of base) : 89624.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -73 (-9.91% of base) : 87132.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -45 (-9.02% of base) : 83141.dasm - BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)
          -5 (-7.94% of base) : 91987.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 37702.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 50630.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 71028.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 45509.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 58571.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 95921.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 8582.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 19111.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 44239.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 44706.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 82680.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 88180.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 44068.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 74439.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 55477.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)

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

Total bytes of base: 12702756 (overridden on cmd)
Total bytes of diff: 12711243 (overridden on cmd)
Total bytes of delta: 8487 (0.07 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         250 : 53708.dasm (13.35% of base)
         167 : 29384.dasm (8.81% of base)
         144 : 32526.dasm (5.20% of base)
         118 : 48251.dasm (3.43% of base)
         109 : 48194.dasm (15.71% of base)
         109 : 53644.dasm (17.25% of base)
          97 : 29381.dasm (7.26% of base)
          91 : 27940.dasm (18.61% of base)
          87 : 53707.dasm (5.30% of base)
          84 : 41401.dasm (2.66% of base)
          84 : 49384.dasm (26.33% of base)
          73 : 48538.dasm (4.48% of base)
          73 : 48580.dasm (1.50% of base)
          72 : 46569.dasm (6.03% of base)
          65 : 29386.dasm (4.66% of base)
          64 : 30388.dasm (2.07% of base)
          63 : 46594.dasm (11.07% of base)
          54 : 26677.dasm (19.35% of base)
          54 : 30172.dasm (9.25% of base)
          54 : 29173.dasm (9.25% of base)

Top file improvements (bytes):
        -109 : 49158.dasm (-15.29% of base)
        -106 : 49425.dasm (-15.47% of base)
         -42 : 33356.dasm (-3.27% of base)
         -41 : 12780.dasm (-11.55% of base)
         -37 : 47627.dasm (-8.26% of base)
         -35 : 26934.dasm (-3.44% of base)
         -35 : 48219.dasm (-8.41% of base)
         -22 : 31372.dasm (-5.96% of base)
         -15 : 9089.dasm (-0.55% of base)
         -14 : 25889.dasm (-0.20% of base)
         -14 : 53269.dasm (-2.12% of base)
         -14 : 52747.dasm (-0.32% of base)
         -13 : 40328.dasm (-1.19% of base)
         -12 : 49432.dasm (-3.52% of base)
         -12 : 49832.dasm (-7.69% of base)
         -12 : 2325.dasm (-2.55% of base)
         -11 : 46227.dasm (-0.19% of base)
         -11 : 31462.dasm (-0.36% of base)
         -11 : 13392.dasm (-5.50% of base)
         -11 : 30746.dasm (-5.95% of base)

78 total files with Code Size differences (31 improved, 47 regressed), 20 unchanged.

Top method regressions (bytes):
         250 (13.35% of base) : 53708.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         167 ( 8.81% of base) : 29384.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
         144 ( 5.20% of base) : 32526.dasm - LUDecomp:ludcmp(double[][],int,int[],byref):int (Tier1-OSR)
         118 ( 3.43% of base) : 48251.dasm - Benchstone.MDBenchF.MDLLoops:Main1(int):this (Tier1-OSR)
         109 (15.71% of base) : 48194.dasm - Benchstone.BenchF.Simpsn:Test():ubyte:this (Tier1-OSR)
         109 (17.25% of base) : 53644.dasm - SciMark2.FFT:transform_internal(double[],int) (Tier1)
          97 ( 7.26% of base) : 29381.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1-OSR)
          91 (18.61% of base) : 27940.dasm - AssignJagged:Run():double:this (Tier1)
          87 ( 5.30% of base) : 53707.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
          84 ( 2.66% of base) : 41401.dasm - Benchstone.BenchF.LLoops:Main1(int):this (Tier1-OSR)
          84 (26.33% of base) : 49384.dasm - Benchstone.MDBenchI.MDGeneralArray:Bench(int,int[,,],int[,,]):ubyte (Tier1-OSR)
          73 ( 4.48% of base) : 48538.dasm - Benchstone.MDBenchF.MDRomber:Test():ubyte:this (Tier1-OSR)
          73 ( 1.50% of base) : 48580.dasm - System.Xml.Schema.XsdDuration:TryFormat(System.Span`1[ushort],byref,int):ubyte:this (Tier0-FullOpts)
          72 ( 6.03% of base) : 46569.dasm - System.Reflection.RuntimeCustomAttributeData:.ctor(System.Reflection.RuntimeModule,System.Reflection.MetadataToken,byref):this (Tier1)
          65 ( 4.66% of base) : 29386.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1)
          64 ( 2.07% of base) : 30388.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1-OSR)
          63 (11.07% of base) : 46594.dasm - Benchstone.BenchF.Regula:Test():ubyte:this (Tier1-OSR)
          54 (19.35% of base) : 26677.dasm - Benchstone.BenchF.BenchMk2:Test():ubyte:this (Tier1-OSR)
          54 ( 9.25% of base) : 29173.dasm - System.MathBenchmarks.Double:Exp10M1Test() (Tier1-OSR)
          54 ( 9.25% of base) : 30172.dasm - System.MathBenchmarks.Double:Exp2M1Test() (Tier1-OSR)

Top method improvements (bytes):
        -109 (-15.29% of base) : 49158.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (Tier1-OSR)
        -106 (-15.47% of base) : 49425.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -42 (-3.27% of base) : 33356.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (Tier1)
         -41 (-11.55% of base) : 12780.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
         -37 (-8.26% of base) : 47627.dasm - Benchstone.MDBenchF.MDInvMt:Inner(double[,],byref,byref) (Tier1)
         -35 (-8.41% of base) : 48219.dasm - BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)
         -35 (-3.44% of base) : 26934.dasm - Fourier:DoFPUTransIteration(double[],double[],int):long (Tier1)
         -22 (-5.96% of base) : 31372.dasm - Neural:zero_changes() (Tier1)
         -15 (-0.55% of base) : 9089.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -14 (-0.20% of base) : 25889.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.CollectionsOfPrimitives (FullOpts)
         -14 (-0.32% of base) : 52747.dasm - (dynamicClass):_DynamicMethod9(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerViewModel (FullOpts)
         -14 (-2.12% of base) : 53269.dasm - Burgers:GetCalculated3(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -13 (-1.19% of base) : 40328.dasm - Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]:ToDictionary[System.__Canon](System.Func`2[System.__Canon,System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon]):System.Collections.Generic.Dictionary`2[System.__Canon,System.Collections.Immutable.ImmutableArray`1[System.__Canon]]:this (Tier1)
         -12 (-3.52% of base) : 49432.dasm - Benchstone.BenchI.AddArray2:BenchInner1(int[][],byref) (Tier1-OSR)
         -12 (-7.69% of base) : 49832.dasm - System.Numerics.BigIntegerCalculator:Multiply(System.ReadOnlySpan`1[uint],uint,System.Span`1[uint]) (Tier1-OSR)
         -12 (-2.55% of base) : 2325.dasm - System.PackedSpanHelpers:IndexOf[System.SpanHelpers+DontNegate`1[short],System.PackedSpanHelpers+NopTransform](byref,short,int):int (Tier1)
         -11 (-0.19% of base) : 46227.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.Location (FullOpts)
         -11 (-0.36% of base) : 31462.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.LoginViewModel (FullOpts)
         -11 (-5.50% of base) : 13392.dasm - LinqBenchmarks:Count00ForX():ubyte:this (Tier1-OSR)
         -11 (-5.95% of base) : 30746.dasm - PerfLabTests.LowLevelPerf:ForeachOverList100Elements():int:this (Tier1-OSR)

Top method regressions (percentages):
          21 (28.77% of base) : 20331.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          21 (28.77% of base) : 25372.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          21 (28.77% of base) : 50122.dasm - PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
          21 (28.77% of base) : 52565.dasm - PerfLabTests.CastingPerf:ObjFooIsObj2():this (Tier1-OSR)
          21 (28.77% of base) : 29494.dasm - PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
          21 (28.77% of base) : 41387.dasm - PerfLabTests.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
          21 (28.77% of base) : 31574.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
          21 (28.77% of base) : 45958.dasm - PerfLabTests.CastingPerf2.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          21 (28.77% of base) : 46928.dasm - PerfLabTests.CastingPerf2.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          21 (28.77% of base) : 44936.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
          29 (27.62% of base) : 33556.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
          40 (27.40% of base) : 49411.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
          33 (26.61% of base) : 27926.dasm - AssignJagged:CopyToAssign(int[][],int[][]) (Tier1-OSR)
          84 (26.33% of base) : 49384.dasm - Benchstone.MDBenchI.MDGeneralArray:Bench(int,int[,,],int[,,]):ubyte (Tier1-OSR)
          26 (24.53% of base) : 17406.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjInt():this (Tier1-OSR)
          29 (23.20% of base) : 52100.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjrefValueTypeObj():this (Tier1-OSR)
          46 (19.74% of base) : 10922.dasm - System.Text.Json.Tests.Perf_Doubles:Setup():this (Tier1-OSR)
          54 (19.35% of base) : 26677.dasm - Benchstone.BenchF.BenchMk2:Test():ubyte:this (Tier1-OSR)
          17 (19.10% of base) : 27939.dasm - AssignJagged:CopyToAssign(int[][],int[][]) (Tier1)
          40 (18.87% of base) : 23721.dasm - Benchstone.MDBenchI.MDXposMatrix:Inner(int[,],int) (Tier1-OSR)

Top method improvements (percentages):
        -106 (-15.47% of base) : 49425.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (Tier1-OSR)
        -109 (-15.29% of base) : 49158.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -41 (-11.55% of base) : 12780.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (Tier1)
         -35 (-8.41% of base) : 48219.dasm - BenchmarksGame.Fasta_2:MakeRepeatFasta(System.String,System.String,ubyte[],int,System.IO.Stream) (Tier1-OSR)
         -37 (-8.26% of base) : 47627.dasm - Benchstone.MDBenchF.MDInvMt:Inner(double[,],byref,byref) (Tier1)
         -12 (-7.69% of base) : 49832.dasm - System.Numerics.BigIntegerCalculator:Multiply(System.ReadOnlySpan`1[uint],uint,System.Span`1[uint]) (Tier1-OSR)
          -4 (-6.78% of base) : 2667.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
         -22 (-5.96% of base) : 31372.dasm - Neural:zero_changes() (Tier1)
         -11 (-5.95% of base) : 30746.dasm - PerfLabTests.LowLevelPerf:ForeachOverList100Elements():int:this (Tier1-OSR)
         -11 (-5.50% of base) : 13392.dasm - LinqBenchmarks:Count00ForX():ubyte:this (Tier1-OSR)
          -6 (-4.00% of base) : 44033.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (Tier1)
          -4 (-3.70% of base) : 52814.dasm - System.Text.RegularExpressions.Symbolic.CharSetSolver:<CreateBDDFromChar>g__CreateBdd|6_0(ushort):System.Text.RegularExpressions.Symbolic.BDD:this (Tier1)
          -8 (-3.59% of base) : 30606.dasm - NeuralJagged:do_mid_error() (Tier1)
         -12 (-3.52% of base) : 49432.dasm - Benchstone.BenchI.AddArray2:BenchInner1(int[][],byref) (Tier1-OSR)
         -35 (-3.44% of base) : 26934.dasm - Fourier:DoFPUTransIteration(double[],double[],int):long (Tier1)
         -42 (-3.27% of base) : 33356.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (Tier1)
          -2 (-3.12% of base) : 9048.dasm - System.Threading.PortableThreadPool+WorkerThread:TakeActiveRequest(System.Threading.PortableThreadPool):ubyte (Tier1)
          -8 (-2.94% of base) : 25088.dasm - BenchmarksGame.Approximate:MultiplyAtv(double[],double[]):this (Tier1-OSR)
          -8 (-2.94% of base) : 25086.dasm - BenchmarksGame.Approximate:MultiplyAv(double[],double[]):this (Tier1-OSR)
          -9 (-2.86% of base) : 40112.dasm - System.Reflection.Metadata.Ecma335.TypeDefTableReader:FindTypeContainingMethod(int,int):System.Reflection.Metadata.TypeDefinitionHandle:this (Tier1)

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

Total bytes of base: 386802490 (overridden on cmd)
Total bytes of diff: 386811251 (overridden on cmd)
Total bytes of delta: 8761 (0.00 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         282 : 233671.dasm (9.63% of base)
         282 : 233435.dasm (9.63% of base)
         250 : 197503.dasm (13.35% of base)
         234 : 578561.dasm (3.93% of base)
         233 : 139001.dasm (1.18% of base)
         233 : 139019.dasm (1.35% of base)
         227 : 139010.dasm (0.90% of base)
         227 : 138989.dasm (0.76% of base)
         224 : 457094.dasm (3.77% of base)
         213 : 456857.dasm (10.90% of base)
         186 : 309308.dasm (8.98% of base)
         183 : 456851.dasm (8.90% of base)
         156 : 196123.dasm (39.80% of base)
         124 : 196098.dasm (4.17% of base)
         121 : 457084.dasm (3.97% of base)
         119 : 581002.dasm (1.40% of base)
         118 : 197137.dasm (30.41% of base)
         115 : 239157.dasm (4.20% of base)
         115 : 233236.dasm (4.20% of base)
         113 : 457197.dasm (14.85% of base)

Top file improvements (bytes):
        -207 : 192870.dasm (-7.02% of base)
        -163 : 196177.dasm (-21.79% of base)
        -122 : 196178.dasm (-18.21% of base)
         -82 : 577558.dasm (-5.62% of base)
         -82 : 580719.dasm (-5.62% of base)
         -82 : 580547.dasm (-5.62% of base)
         -82 : 576992.dasm (-5.62% of base)
         -78 : 304555.dasm (-4.72% of base)
         -73 : 457201.dasm (-10.30% of base)
         -73 : 457199.dasm (-9.91% of base)
         -66 : 580790.dasm (-2.37% of base)
         -53 : 582962.dasm (-2.16% of base)
         -47 : 338556.dasm (-2.86% of base)
         -41 : 197527.dasm (-11.55% of base)
         -40 : 196233.dasm (-6.86% of base)
         -38 : 585.dasm (-2.95% of base)
         -37 : 197487.dasm (-8.26% of base)
         -37 : 578600.dasm (-0.32% of base)
         -35 : 196019.dasm (-3.44% of base)
         -34 : 233031.dasm (-3.82% of base)

96 total files with Code Size differences (47 improved, 49 regressed), 20 unchanged.

Top method regressions (bytes):
         282 ( 9.63% of base) : 233435.dasm - plainarr:gaussj(double[,],int,double[,],int) (FullOpts)
         282 ( 9.63% of base) : 233671.dasm - structarr:gaussj(MatrixStruct,int,MatrixStruct,int) (FullOpts)
         250 (13.35% of base) : 197503.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
         234 ( 3.93% of base) : 578561.dasm - ILCompiler.DependencyAnalysis.ReadyToRunObjectWriter:EmitObjectData(ILCompiler.PEWriter.R2RPEBuilder,ILCompiler.DependencyAnalysis.ObjectNode+ObjectData,int,System.String,ILCompiler.DependencyAnalysis.ObjectNodeSection):this (Tier1-OSR)
         233 ( 1.18% of base) : 139001.dasm - IntelHardwareIntrinsicTest._Avx2.Program+GatherMaskVector256:Test() (FullOpts)
         233 ( 1.35% of base) : 139019.dasm - IntelHardwareIntrinsicTest._Avx2.Program+GatherVector256:Test() (FullOpts)
         227 ( 0.76% of base) : 138989.dasm - IntelHardwareIntrinsicTest._Avx2.Program+GatherMaskVector128:Test() (FullOpts)
         227 ( 0.90% of base) : 139010.dasm - IntelHardwareIntrinsicTest._Avx2.Program+GatherVector128:Test() (FullOpts)
         224 ( 3.77% of base) : 457094.dasm - LUDecomp:Run():double:this (Tier1)
         213 (10.90% of base) : 456857.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
         186 ( 8.98% of base) : 309308.dasm - Microsoft.Build.Execution.BuildManager:HandleNodeShutdown(int,Microsoft.Build.BackEnd.NodeShutdown):this (FullOpts)
         183 ( 8.90% of base) : 456851.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
         156 (39.80% of base) : 196123.dasm - Benchstone.BenchF.Adams:Bench() (FullOpts)
         124 ( 4.17% of base) : 196098.dasm - LUDecomp:ludcmp(double[][],int,int[],byref):int (FullOpts)
         121 ( 3.97% of base) : 457084.dasm - LUDecomp:ludcmp(double[][],int,int[],byref):int (Tier1)
         119 ( 1.40% of base) : 581002.dasm - ILCompiler.DependencyAnalysis.ReadyToRunObjectWriter:EmitObjectData(ILCompiler.PEWriter.R2RPEBuilder,ILCompiler.DependencyAnalysis.ObjectNode+ObjectData,int,System.String,ILCompiler.DependencyAnalysis.ObjectNodeSection):this (Tier1-OSR)
         118 (30.41% of base) : 197137.dasm - Benchstone.BenchF.DMath:Bench(int):ubyte (FullOpts)
         115 ( 4.20% of base) : 239157.dasm - Test_intarr_InnerProd.intmm:TestEntryPoint():int (FullOpts)
         115 ( 4.20% of base) : 233236.dasm - Test_intarr_InnerProd.intmm:TestEntryPoint():int (FullOpts)
         113 (14.85% of base) : 457197.dasm - Burgers:GetAnalytical(double[],double,double):double[] (Tier1-OSR)

Top method improvements (bytes):
        -207 (-7.02% of base) : 192870.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -163 (-21.79% of base) : 196177.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (FullOpts)
        -122 (-18.21% of base) : 196178.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (FullOpts)
         -82 (-5.62% of base) : 580547.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedMethodKey,System.__Canon]:Expand(System.__Canon[]):this (Tier1)
         -82 (-5.62% of base) : 576992.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedMethodKey,System.__Canon]:Expand(System.__Canon[]):this (Tier1)
         -82 (-5.62% of base) : 577558.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+MethodForInstantiatedTypeKey,System.__Canon]:Expand(System.__Canon[]):this (Tier1)
         -82 (-5.62% of base) : 580719.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+MethodForInstantiatedTypeKey,System.__Canon]:Expand(System.__Canon[]):this (Tier1)
         -78 (-4.72% of base) : 304555.dasm - CseTest.Test_Main:TestEntryPoint():int (FullOpts)
         -73 (-9.91% of base) : 457199.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -73 (-10.30% of base) : 457201.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (Tier1-OSR)
         -66 (-2.37% of base) : 580790.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -53 (-2.16% of base) : 582962.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -47 (-2.86% of base) : 338556.dasm - System.RuntimeType:MakeGenericType(System.Type[]):System.Type:this (Tier1)
         -41 (-11.55% of base) : 197527.dasm - Benchstone.MDBenchF.MDSqMtx:Inner(double[,],double[,],int) (FullOpts)
         -40 (-6.86% of base) : 196233.dasm - V8.Crypto.RSAKey:doPrivate(V8.Crypto.BigInteger):V8.Crypto.BigInteger:this (FullOpts)
         -38 (-2.95% of base) : 585.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (FullOpts)
         -37 (-8.26% of base) : 197487.dasm - Benchstone.MDBenchF.MDInvMt:Inner(double[,],byref,byref) (FullOpts)
         -37 (-0.32% of base) : 578600.dasm - ILCompiler.DependencyAnalysis.ReadyToRunObjectWriter:EmitObjectData(ILCompiler.PEWriter.R2RPEBuilder,ILCompiler.DependencyAnalysis.ObjectNode+ObjectData,int,System.String,ILCompiler.DependencyAnalysis.ObjectNodeSection):this (Tier1)
         -35 (-3.44% of base) : 196019.dasm - Fourier:DoFPUTransIteration(double[],double[],int):long (FullOpts)
         -34 (-12.64% of base) : 240253.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)

Top method regressions (percentages):
          11 (42.31% of base) : 490235.dasm - FinalizeTimeout:ThreadMain() (Tier1-OSR)
         156 (39.80% of base) : 196123.dasm - Benchstone.BenchF.Adams:Bench() (FullOpts)
          68 (38.42% of base) : 197477.dasm - Benchstone.MDBenchI.MDGeneralArray:Initialize(int[,,]) (FullOpts)
          60 (36.36% of base) : 233719.dasm - Test_test1_cs.Derived:Clone(int):Test_test1_cs.Base[]:this (FullOpts)
          10 (35.71% of base) : 305795.dasm - OVFTest:Test_ulong(ulong):ulong (FullOpts)
          46 (34.59% of base) : 185009.dasm - FastTailCallCandidates:CalleeHFAStackSpace(double,double,double,double,double,double,double,double,double,double):int (FullOpts)
          46 (34.59% of base) : 185008.dasm - FastTailCallCandidates:CalleeSimpleHFACase(double,double,double,double,double,double,double,double):int (FullOpts)
          46 (34.59% of base) : 185010.dasm - FastTailCallCandidates:CalleeWithHFA(double,double,double,double,FastTailCallCandidates+HFASize32):int (FullOpts)
          46 (34.59% of base) : 185011.dasm - FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)
          10 (34.48% of base) : 305792.dasm - OVFTest:Test_int(int):int (FullOpts)
         103 (32.70% of base) : 197476.dasm - Benchstone.MDBenchI.MDGeneralArray:Bench(int,int[,,],int[,,]):ubyte (FullOpts)
          10 (32.26% of base) : 305794.dasm - OVFTest:Test_long(long):long (FullOpts)
          10 (31.25% of base) : 305793.dasm - OVFTest:Test_uint(uint):uint (FullOpts)
          34 (30.91% of base) : 249521.dasm - Test.AA:Method1(byref,int,byref,double[]):float (FullOpts)
         118 (30.41% of base) : 197137.dasm - Benchstone.BenchF.DMath:Bench(int):ubyte (FullOpts)
          24 (30.00% of base) : 465996.dasm - Validate:MakeGarbage() (Tier1-OSR)
          63 (22.83% of base) : 197478.dasm - Benchstone.MDBenchI.MDGeneralArray:VerifyCopy(int[,,],int[,,]):ubyte (FullOpts)
          10 (22.22% of base) : 305788.dasm - OVFTest:Test_byte(ubyte):ubyte (FullOpts)
          10 (22.22% of base) : 305791.dasm - OVFTest:Test_ushort(ushort):ushort (FullOpts)
          33 (21.57% of base) : 240261.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)

Top method improvements (percentages):
         -10 (-22.73% of base) : 242283.dasm - Test_b99969:DoSpoof() (FullOpts)
        -163 (-21.79% of base) : 196177.dasm - Burgers:GetCalculated0(int,int,double,double,double,double[]):double[] (FullOpts)
        -122 (-18.21% of base) : 196178.dasm - Burgers:GetCalculated1(int,int,double,double,double,double[]):double[] (FullOpts)
         -28 (-12.73% of base) : 117244.dasm - JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256Int321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256Int321+TestStruct (FullOpts)
         -28 (-12.73% of base) : 117259.dasm - JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256UInt321+TestStruct (FullOpts)
         -28 (-12.73% of base) : 121995.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128Byte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128Byte1+TestStruct (FullOpts)
         -28 (-12.73% of base) : 122010.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128SByte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128SByte1+TestStruct (FullOpts)
         -28 (-12.73% of base) : 122145.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Byte1+TestStruct (FullOpts)
         -28 (-12.73% of base) : 122205.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Int321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Int321+TestStruct (FullOpts)
         -28 (-12.73% of base) : 122160.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256SByte1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256SByte1+TestStruct (FullOpts)
         -28 (-12.73% of base) : 122220.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256UInt321+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256UInt321+TestStruct (FullOpts)
         -34 (-12.64% of base) : 240253.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
         -28 (-12.61% of base) : 122025.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128Int161+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128Int161+TestStruct (FullOpts)
         -28 (-12.61% of base) : 122040.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128UInt161+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector128UInt161+TestStruct (FullOpts)
         -28 (-12.61% of base) : 122175.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Int161+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Int161+TestStruct (FullOpts)
         -28 (-12.61% of base) : 122190.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256UInt161+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256UInt161+TestStruct (FullOpts)
         -28 (-12.50% of base) : 117274.dasm - JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256Single1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512DQ.ImmBinaryOpTest__InsertVector256Single1+TestStruct (FullOpts)
         -28 (-12.50% of base) : 122265.dasm - JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Single1+TestStruct:Create():JIT.HardwareIntrinsics.X86._Avx512F.ImmBinaryOpTest__InsertVector256Single1+TestStruct (FullOpts)
         -22 (-12.36% of base) : 69217.dasm - JIT.HardwareIntrinsics.General._Vector128_1.VectorBinaryOpTest__op_SubtractionByte+TestStruct:Create():JIT.HardwareIntrinsics.General._Vector128_1.VectorBinaryOpTest__op_SubtractionByte+TestStruct (FullOpts)
         -22 (-12.36% of base) : 73857.dasm - JIT.HardwareIntrinsics.General._Vector128.VectorBinaryOpTest__LessThanOrEqualByte+TestStruct:Create():JIT.HardwareIntrinsics.General._Vector128.VectorBinaryOpTest__LessThanOrEqualByte+TestStruct (FullOpts)

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

Total bytes of base: 45036867 (overridden on cmd)
Total bytes of diff: 45099093 (overridden on cmd)
Total bytes of delta: 62226 (0.14 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1330 : 186730.dasm (14.01% of base)
         577 : 157343.dasm (32.18% of base)
         557 : 164352.dasm (24.59% of base)
         508 : 164353.dasm (11.96% of base)
         429 : 156680.dasm (48.58% of base)
         423 : 190484.dasm (30.90% of base)
         423 : 221182.dasm (30.90% of base)
         261 : 43953.dasm (15.32% of base)
         261 : 274582.dasm (12.59% of base)
         243 : 156688.dasm (26.62% of base)
         215 : 34859.dasm (13.17% of base)
         212 : 40491.dasm (2.66% of base)
         179 : 186637.dasm (5.33% of base)
         175 : 221193.dasm (15.30% of base)
         175 : 190495.dasm (15.30% of base)
         174 : 110911.dasm (4.14% of base)
         152 : 156634.dasm (26.76% of base)
         150 : 2226.dasm (1.54% of base)
         142 : 221164.dasm (7.04% of base)
         142 : 190465.dasm (7.04% of base)

Top file improvements (bytes):
         -78 : 270362.dasm (-5.07% of base)
         -67 : 88524.dasm (-3.08% of base)
         -66 : 271516.dasm (-12.79% of base)
         -51 : 231275.dasm (-3.54% of base)
         -51 : 201058.dasm (-3.54% of base)
         -51 : 20064.dasm (-3.29% of base)
         -51 : 182855.dasm (-3.54% of base)
         -49 : 258736.dasm (-3.18% of base)
         -46 : 258735.dasm (-2.96% of base)
         -41 : 22449.dasm (-1.51% of base)
         -38 : 265403.dasm (-2.13% of base)
         -32 : 182457.dasm (-8.18% of base)
         -30 : 164642.dasm (-0.25% of base)
         -28 : 182458.dasm (-8.28% of base)
         -27 : 41320.dasm (-2.85% of base)
         -26 : 22830.dasm (-2.46% of base)
         -26 : 90481.dasm (-1.06% of base)
         -26 : 14566.dasm (-5.50% of base)
         -25 : 63751.dasm (-1.52% of base)
         -25 : 54242.dasm (-2.60% of base)

80 total files with Code Size differences (41 improved, 39 regressed), 20 unchanged.

Top method regressions (bytes):
        1330 (14.01% of base) : 186730.dasm - System.Management.ManagementClassGenerator:GenerateProperties():this (FullOpts)
         577 (32.18% of base) : 157343.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteDerivedSerializable(System.Xml.Serialization.SerializableMapping,System.Xml.Serialization.SerializableMapping,System.String,ubyte):this (FullOpts)
         557 (24.59% of base) : 164352.dasm - System.Data.DataTable:SerializeTableSchema(System.Runtime.Serialization.SerializationInfo,ubyte):this (FullOpts)
         508 (11.96% of base) : 164353.dasm - System.Data.DataTable:DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo,ubyte):this (FullOpts)
         429 (48.58% of base) : 156680.dasm - System.Xml.Serialization.XmlSerializationWriterCodeGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping):this (FullOpts)
         423 (30.90% of base) : 190484.dasm - Microsoft.CodeAnalysis.SarifV1ErrorLogger:WriteRules():this (FullOpts)
         423 (30.90% of base) : 221182.dasm - Microsoft.CodeAnalysis.SarifV1ErrorLogger:WriteRules():this (FullOpts)
         261 (15.32% of base) : 43953.dasm - Microsoft.Diagnostics.Tracing.Parsers.Kernel.MemoryProcessMemInfoTraceData:ToXml(System.Text.StringBuilder):System.Text.StringBuilder:this (FullOpts)
         261 (12.59% of base) : 274582.dasm - System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo:GetExportDefinitions():System.Collections.Generic.List`1[System.ComponentModel.Composition.Primitives.ExportDefinition]:this (FullOpts)
         243 (26.62% of base) : 156688.dasm - System.Xml.Serialization.XmlSerializationWriterILGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping):this (FullOpts)
         215 (13.17% of base) : 34859.dasm - Microsoft.Diagnostics.Tracing.Stacks.Formats.SpeedScopeStackSourceWriter:WriteToFile(System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.Collections.Generic.IReadOnlyList`1[Microsoft.Diagnostics.Tracing.Stacks.StackSourceWriterHelper+ProfileEvent]],System.Collections.Generic.IReadOnlyList`1[System.String],System.IO.TextWriter,System.String) (FullOpts)
         212 ( 2.66% of base) : 40491.dasm - Microsoft.Diagnostics.Tracing.Parsers.RegisteredTraceEventParser:GetManifestForRegisteredProvider(System.Guid):System.String (FullOpts)
         179 ( 5.33% of base) : 186637.dasm - System.Management.PropertyData:MapValueToWmiValue(System.Object,int,ubyte):System.Object (FullOpts)
         175 (15.30% of base) : 221193.dasm - Microsoft.CodeAnalysis.SarifV2ErrorLogger:WriteInvocations(System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`3[System.String,int,System.Collections.Immutable.ImmutableHashSet`1[int]]]):this (FullOpts)
         175 (15.30% of base) : 190495.dasm - Microsoft.CodeAnalysis.SarifV2ErrorLogger:WriteInvocations(System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`3[System.String,int,System.Collections.Immutable.ImmutableHashSet`1[int]]]):this (FullOpts)
         174 ( 4.14% of base) : 110911.dasm - Microsoft.CodeAnalysis.VisualBasic.OverloadResolution:MatchArguments(Microsoft.CodeAnalysis.VisualBasic.BoundMethodOrPropertyGroup,byref,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],Microsoft.CodeAnalysis.VisualBasic.Binder,byref,Microsoft.CodeAnalysis.SyntaxNode,ubyte,byref) (FullOpts)
         152 (26.76% of base) : 156634.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping,ubyte,System.String):this (FullOpts)
         150 ( 1.54% of base) : 2226.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
         142 ( 7.04% of base) : 221164.dasm - Microsoft.CodeAnalysis.ReportAnalyzerUtil:ReportAnalyzerExecutionTime(System.IO.TextWriter,Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver,System.Globalization.CultureInfo) (FullOpts)
         142 ( 7.04% of base) : 190465.dasm - Microsoft.CodeAnalysis.ReportAnalyzerUtil:ReportAnalyzerExecutionTime(System.IO.TextWriter,Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver,System.Globalization.CultureInfo) (FullOpts)

Top method improvements (bytes):
         -78 (-5.07% of base) : 270362.dasm - System.Security.Principal.WindowsIdentity:AddTokenClaims(System.Collections.Generic.List`1[System.Security.Claims.Claim],int,System.String):this (FullOpts)
         -67 (-3.08% of base) : 88524.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbolExtensions:VisitType[System.__Canon](Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.Func`4[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.__Canon,ubyte,ubyte],System.Func`4[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.__Canon,ubyte,ubyte],System.__Canon,ubyte,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (FullOpts)
         -66 (-12.79% of base) : 271516.dasm - System.Net.Mail.QuotedStringFormatReader:TryReadReverseUnQuoted(System.String,int,ubyte,ubyte,byref,ubyte):ubyte (FullOpts)
         -51 (-3.54% of base) : 231275.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(Microsoft.CodeAnalysis.Collections.Internal.SegmentedArraySegment`1[System.__Canon],System.Span`1[System.__Canon]):int (FullOpts)
         -51 (-3.54% of base) : 201058.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(Microsoft.CodeAnalysis.Collections.Internal.SegmentedArraySegment`1[System.__Canon],System.Span`1[System.__Canon]):int (FullOpts)
         -51 (-3.54% of base) : 182855.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(Microsoft.CodeAnalysis.Collections.Internal.SegmentedArraySegment`1[System.__Canon],System.Span`1[System.__Canon]):int (FullOpts)
         -51 (-3.29% of base) : 20064.dasm - System.SpanHelpers:IndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (FullOpts)
         -49 (-3.18% of base) : 258736.dasm - System.Numerics.BigInteger:RotateRight(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
         -46 (-2.96% of base) : 258735.dasm - System.Numerics.BigInteger:RotateLeft(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
         -41 (-1.51% of base) : 22449.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (FullOpts)
         -38 (-2.13% of base) : 265403.dasm - System.ServiceModel.Syndication.Atom10FeedFormatter:ReadLink(System.Xml.XmlReader,System.ServiceModel.Syndication.SyndicationLink,System.Uri):this (FullOpts)
         -32 (-8.18% of base) : 182457.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon]:System.Collections.IStructuralComparable.CompareTo(System.Object,System.Collections.IComparer):int:this (FullOpts)
         -30 (-0.25% of base) : 164642.dasm - System.Data.XmlTreeGen:HandleTable(System.Data.DataTable,System.Xml.XmlDocument,System.Xml.XmlElement,ubyte):System.Xml.XmlElement:this (FullOpts)
         -28 (-8.28% of base) : 182458.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon]:System.Collections.IStructuralEquatable.Equals(System.Object,System.Collections.IEqualityComparer):ubyte:this (FullOpts)
         -27 (-2.85% of base) : 41320.dasm - Microsoft.Diagnostics.Tracing.Parsers.Symbol.FileVersionTraceData:PayloadValue(int):System.Object:this (FullOpts)
         -26 (-1.06% of base) : 90481.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:BindLambdaExpression(Microsoft.CodeAnalysis.VisualBasic.Syntax.LambdaExpressionSyntax,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
         -26 (-2.46% of base) : 22830.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         -26 (-5.50% of base) : 14566.dasm - System.MemoryExtensions:LastIndexOfAnyExcept[System.__Canon](System.ReadOnlySpan`1[System.__Canon],System.ReadOnlySpan`1[System.__Canon]):int (FullOpts)
         -25 (-1.52% of base) : 63751.dasm - Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor:<VisitMethod>g__visitFunctionPointerSignature|37_0(Microsoft.CodeAnalysis.IMethodSymbol):this (FullOpts)
         -25 (-2.60% of base) : 54242.dasm - System.Text.RegularExpressions.Symbolic.BDD:Deserialize(System.ReadOnlySpan`1[ubyte]):System.Text.RegularExpressions.Symbolic.BDD (FullOpts)

Top method regressions (percentages):
         429 (48.58% of base) : 156680.dasm - System.Xml.Serialization.XmlSerializationWriterCodeGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping):this (FullOpts)
          24 (41.38% of base) : 3384.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
         577 (32.18% of base) : 157343.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteDerivedSerializable(System.Xml.Serialization.SerializableMapping,System.Xml.Serialization.SerializableMapping,System.String,ubyte):this (FullOpts)
         423 (30.90% of base) : 190484.dasm - Microsoft.CodeAnalysis.SarifV1ErrorLogger:WriteRules():this (FullOpts)
         423 (30.90% of base) : 221182.dasm - Microsoft.CodeAnalysis.SarifV1ErrorLogger:WriteRules():this (FullOpts)
         152 (26.76% of base) : 156634.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping,ubyte,System.String):this (FullOpts)
         243 (26.62% of base) : 156688.dasm - System.Xml.Serialization.XmlSerializationWriterILGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping):this (FullOpts)
         557 (24.59% of base) : 164352.dasm - System.Data.DataTable:SerializeTableSchema(System.Runtime.Serialization.SerializationInfo,ubyte):this (FullOpts)
          82 (23.03% of base) : 188089.dasm - System.Speech.Internal.Synthesis.PcmConverter:Blackman(int,ubyte):float[] (FullOpts)
          35 (17.86% of base) : 25703.dasm - Microsoft.FSharp.Quotations.PatternsModule:mkNewArray(System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]):Microsoft.FSharp.Quotations.FSharpExpr (FullOpts)
          60 (17.24% of base) : 174884.dasm - Microsoft.CSharp.RuntimeBinder.RuntimeBinder:PopulateLocalScope(Microsoft.CSharp.RuntimeBinder.ICSharpBinder,Microsoft.CSharp.RuntimeBinder.Semantics.Scope,Microsoft.CSharp.RuntimeBinder.ArgumentObject[],System.Linq.Expressions.Expression[]):Microsoft.CSharp.RuntimeBinder.Semantics.LocalVariableSymbol[] (FullOpts)
          20 (16.13% of base) : 176595.dasm - Newtonsoft.Json.JsonTextReader:MatchValue(ubyte,System.String):ubyte:this (FullOpts)
          14 (15.91% of base) : 28427.dasm - <StartupCode$FSharp-Core>.$Event+get_Publish@40[System.__Canon]:Microsoft.FSharp.Control.IDelegateEvent<'Delegate>.AddHandler(System.__Canon):this (FullOpts)
          14 (15.91% of base) : 28428.dasm - <StartupCode$FSharp-Core>.$Event+get_Publish@40[System.__Canon]:Microsoft.FSharp.Control.IDelegateEvent<'Delegate>.RemoveHandler(System.__Canon):this (FullOpts)
         261 (15.32% of base) : 43953.dasm - Microsoft.Diagnostics.Tracing.Parsers.Kernel.MemoryProcessMemInfoTraceData:ToXml(System.Text.StringBuilder):System.Text.StringBuilder:this (FullOpts)
         175 (15.30% of base) : 221193.dasm - Microsoft.CodeAnalysis.SarifV2ErrorLogger:WriteInvocations(System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`3[System.String,int,System.Collections.Immutable.ImmutableHashSet`1[int]]]):this (FullOpts)
         175 (15.30% of base) : 190495.dasm - Microsoft.CodeAnalysis.SarifV2ErrorLogger:WriteInvocations(System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`3[System.String,int,System.Collections.Immutable.ImmutableHashSet`1[int]]]):this (FullOpts)
           5 (15.15% of base) : 239166.dasm - System.Collections.Immutable.SecureObjectPool:NewId():int (FullOpts)
           5 (15.15% of base) : 271587.dasm - System.Collections.Immutable.SecureObjectPool:NewId():int (FullOpts)
          10 (15.15% of base) : 3394.dasm - System.Random+Net5CompatDerivedImpl:NextSingle():float:this (FullOpts)

Top method improvements (percentages):
         -66 (-12.79% of base) : 271516.dasm - System.Net.Mail.QuotedStringFormatReader:TryReadReverseUnQuoted(System.String,int,ubyte,ubyte,byref,ubyte):ubyte (FullOpts)
         -16 (-11.59% of base) : 20083.dasm - System.SpanHelpers:LastIndexOfAnyExceptInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
         -16 (-11.59% of base) : 20082.dasm - System.SpanHelpers:LastIndexOfAnyInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
         -13 (-9.77% of base) : 232157.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:IsSorted[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):ubyte (FullOpts)
         -14 (-9.21% of base) : 20081.dasm - System.SpanHelpers:IndexOfAnyExceptInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
         -14 (-9.21% of base) : 20080.dasm - System.SpanHelpers:IndexOfAnyInRange[System.__Canon](byref,System.__Canon,System.__Canon,int):int (FullOpts)
          -9 (-9.18% of base) : 235983.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|229_0[System.__Canon,System.Numerics.Tensors.TensorPrimitives+ShiftLeftOperator`1[System.__Canon]](byref,byref,ulong,System.Numerics.Tensors.TensorPrimitives+ShiftLeftOperator`1[System.__Canon]) (FullOpts)
          -5 (-8.47% of base) : 185280.dasm - System.Reflection.Metadata.Ecma335.MetadataSizes:CalculateTableStreamHeaderSize():int:this (FullOpts)
         -11 (-8.46% of base) : 22871.dasm - System.SpanHelpers:BinarySearch[System.__Canon,System.SpanHelpers+ComparerComparable`2[System.__Canon,System.__Canon]](byref,int,System.SpanHelpers+ComparerComparable`2[System.__Canon,System.__Canon]):int (FullOpts)
         -28 (-8.28% of base) : 182458.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon]:System.Collections.IStructuralEquatable.Equals(System.Object,System.Collections.IEqualityComparer):ubyte:this (FullOpts)
         -32 (-8.18% of base) : 182457.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon]:System.Collections.IStructuralComparable.CompareTo(System.Object,System.Collections.IComparer):int:this (FullOpts)
         -11 (-8.03% of base) : 182446.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon]:System.Collections.Generic.ICollection<T>.CopyTo(System.__Canon[],int):this (FullOpts)
         -15 (-7.81% of base) : 175905.dasm - System.Data.Odbc.OdbcParameterCollection:ClearBindings():this (FullOpts)
         -17 (-7.49% of base) : 182459.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon]:System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer):int:this (FullOpts)
         -16 (-6.93% of base) : 271263.dasm - System.Net.Mime.EightBitStream:EncodeLines(ubyte[],int,int):this (FullOpts)
          -4 (-6.78% of base) : 23093.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (FullOpts)
         -14 (-6.73% of base) : 14756.dasm - System.Numerics.Vector:Dot[System.__Canon](System.Numerics.Vector`1[System.__Canon],System.Numerics.Vector`1[System.__Canon]):System.__Canon (FullOpts)
         -19 (-6.69% of base) : 152528.dasm - System.Xml.XPath.XPathNavigator:get_UniqueId():System.String:this (FullOpts)
          -7 (-6.67% of base) : 20050.dasm - System.MemoryExtensions:ClampStart[System.__Canon](System.ReadOnlySpan`1[System.__Canon],System.ReadOnlySpan`1[System.__Canon]):int (FullOpts)
         -19 (-6.48% of base) : 17683.dasm - System.Diagnostics.Tracing.EventCounter:Enqueue(double):this (FullOpts)

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

Total bytes of base: 61408934 (overridden on cmd)
Total bytes of diff: 61437536 (overridden on cmd)
Total bytes of delta: 28602 (0.05 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         622 : 249202.dasm (11.46% of base)
         202 : 177822.dasm (4.72% of base)
         170 : 176776.dasm (8.05% of base)
         136 : 123798.dasm (2.76% of base)
         120 : 301630.dasm (3.02% of base)
         102 : 196593.dasm (11.74% of base)
         102 : 172248.dasm (11.74% of base)
         102 : 156159.dasm (11.74% of base)
         101 : 175438.dasm (13.95% of base)
          80 : 131824.dasm (6.81% of base)
          80 : 206712.dasm (1.64% of base)
          76 : 192225.dasm (5.04% of base)
          76 : 151559.dasm (5.04% of base)
          74 : 146280.dasm (6.53% of base)
          74 : 187103.dasm (6.53% of base)
          73 : 134714.dasm (1.48% of base)
          70 : 20514.dasm (14.37% of base)
          69 : 18855.dasm (4.36% of base)
          69 : 290754.dasm (4.72% of base)
          68 : 232730.dasm (19.83% of base)

Top file improvements (bytes):
        -207 : 90514.dasm (-7.02% of base)
         -87 : 123796.dasm (-1.71% of base)
         -79 : 303936.dasm (-3.37% of base)
         -75 : 28881.dasm (-7.78% of base)
         -70 : 60584.dasm (-6.86% of base)
         -66 : 289207.dasm (-11.72% of base)
         -60 : 60585.dasm (-3.91% of base)
         -45 : 300718.dasm (-2.80% of base)
         -45 : 300719.dasm (-2.82% of base)
         -44 : 161920.dasm (-2.09% of base)
         -42 : 262871.dasm (-4.96% of base)
         -42 : 199037.dasm (-1.92% of base)
         -42 : 206379.dasm (-0.91% of base)
         -42 : 158616.dasm (-1.92% of base)
         -42 : 253877.dasm (-4.96% of base)
         -41 : 303876.dasm (-1.66% of base)
         -36 : 218780.dasm (-1.24% of base)
         -36 : 85823.dasm (-1.31% of base)
         -35 : 50.dasm (-2.58% of base)
         -30 : 162218.dasm (-3.45% of base)

92 total files with Code Size differences (40 improved, 52 regressed), 20 unchanged.

Top method regressions (bytes):
         622 (11.46% of base) : 249202.dasm - R2RDump.Extensions:WriteTo(ILCompiler.Reflection.ReadyToRun.DebugInfo,System.IO.TextWriter,R2RDump.DumpModel) (FullOpts)
         202 ( 4.72% of base) : 177822.dasm - Microsoft.Build.BackEnd.Scheduler:WriteNodeUtilizationGraph(Microsoft.Build.BackEnd.Logging.ILoggingService,Microsoft.Build.Framework.BuildEventContext,ubyte):this (FullOpts)
         170 ( 8.05% of base) : 176776.dasm - Microsoft.Build.Execution.BuildManager:HandleNodeShutdown(int,Microsoft.Build.BackEnd.NodeShutdown):this (FullOpts)
         136 ( 2.76% of base) : 123798.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation,Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
         120 ( 3.02% of base) : 301630.dasm - System.Runtime.Serialization.CodeExporter:ExportClassDataContract(System.Runtime.Serialization.DataContracts.DataContract,System.Runtime.Serialization.ContractCodeDomInfo):this (FullOpts)
         102 (11.74% of base) : 196593.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray:IndexOf[System.__Canon](Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon],System.__Canon,int,int,System.Collections.Generic.IEqualityComparer`1[System.__Canon]):int (FullOpts)
         102 (11.74% of base) : 172248.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray:IndexOf[System.__Canon](Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon],System.__Canon,int,int,System.Collections.Generic.IEqualityComparer`1[System.__Canon]):int (FullOpts)
         102 (11.74% of base) : 156159.dasm - Microsoft.CodeAnalysis.Collections.SegmentedArray:IndexOf[System.__Canon](Microsoft.CodeAnalysis.Collections.SegmentedArray`1[System.__Canon],System.__Canon,int,int,System.Collections.Generic.IEqualityComparer`1[System.__Canon]):int (FullOpts)
         101 (13.95% of base) : 175438.dasm - Microsoft.Build.Logging.BuildEventArgsWriter:Write(Microsoft.Build.Framework.Profiler.EvaluationLocation):this (FullOpts)
          80 ( 1.64% of base) : 206712.dasm - System.Data.DataTable:ReadXml(System.Xml.XmlReader,int,ubyte):int:this (FullOpts)
          80 ( 6.81% of base) : 131824.dasm - System.Xml.XmlLoader:LoadNode(ubyte):System.Xml.XmlNode:this (FullOpts)
          76 ( 5.04% of base) : 192225.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder:GetImmutable[System.__Canon](System.Collections.Immutable.ImmutableHashSet`1[Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer],System.Func`2[Microsoft.CodeAnalysis.Diagnostic,ubyte],System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]):System.Collections.Immutable.ImmutableDictionary`2[System.__Canon,System.__Canon] (FullOpts)
          76 ( 5.04% of base) : 151559.dasm - Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder:GetImmutable[System.__Canon](System.Collections.Immutable.ImmutableHashSet`1[Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer],System.Func`2[Microsoft.CodeAnalysis.Diagnostic,ubyte],System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]):System.Collections.Immutable.ImmutableDictionary`2[System.__Canon,System.__Canon] (FullOpts)
          74 ( 6.53% of base) : 146280.dasm - Microsoft.CodeAnalysis.TopologicalSort:PredecessorCounts[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon],Microsoft.CodeAnalysis.TopologicalSortAddSuccessors`1[System.__Canon],byref):Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[System.__Canon,int] (FullOpts)
          74 ( 6.53% of base) : 187103.dasm - Microsoft.CodeAnalysis.TopologicalSort:PredecessorCounts[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon],Microsoft.CodeAnalysis.TopologicalSortAddSuccessors`1[System.__Canon],byref):Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[System.__Canon,int] (FullOpts)
          73 ( 1.48% of base) : 134714.dasm - System.Xml.Schema.XsdDuration:TryFormat(System.Span`1[ushort],byref,int):ubyte:this (FullOpts)
          70 (14.37% of base) : 20514.dasm - System.HexConverter:TryDecodeFromUtf16_Vector128(System.ReadOnlySpan`1[ushort],System.Span`1[ubyte],byref):ubyte (FullOpts)
          69 ( 4.72% of base) : 290754.dasm - System.Net.SocketAddress:ToString():System.String:this (FullOpts)
          69 ( 4.36% of base) : 18855.dasm - System.Number:TryUInt128ToDecStr[ubyte](System.UInt128,int,System.Span`1[ubyte],byref):ubyte (FullOpts)
          68 (19.83% of base) : 232730.dasm - System.Speech.Internal.Synthesis.PcmConverter:Blackman(int,ubyte):float[] (FullOpts)

Top method improvements (bytes):
        -207 (-7.02% of base) : 90514.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
         -87 (-1.71% of base) : 123796.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation+ReferenceManager:SetupReferencesForRetargetingAssembly(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation,Microsoft.CodeAnalysis.VisualBasic.Symbols.AssemblySymbol][],int,byref,Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceAssemblySymbol) (FullOpts)
         -79 (-3.37% of base) : 303936.dasm - System.ServiceModel.Syndication.AtomPub10ServiceDocumentFormatter:ReadDocument(System.Xml.XmlReader):this (FullOpts)
         -75 (-7.78% of base) : 28881.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.Nullable`1[int]]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.Nullable`1[int]],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         -70 (-6.86% of base) : 60584.dasm - Microsoft.CodeAnalysis.CSharp.UnboundLambdaState:CollectParameterProperties():System.ValueTuple`4[System.Collections.Immutable.ImmutableArray`1[ubyte],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte]:this (FullOpts)
         -66 (-11.72% of base) : 289207.dasm - System.Net.Mail.QuotedStringFormatReader:TryReadReverseUnQuoted(System.String,int,ubyte,ubyte,byref,ubyte):ubyte (FullOpts)
         -60 (-3.91% of base) : 60585.dasm - Microsoft.CodeAnalysis.CSharp.UnboundLambdaState:InferDelegateType():Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:this (FullOpts)
         -45 (-2.80% of base) : 300718.dasm - System.Numerics.BigInteger:RotateLeft(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
         -45 (-2.82% of base) : 300719.dasm - System.Numerics.BigInteger:RotateRight(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
         -44 (-2.09% of base) : 161920.dasm - Microsoft.VisualBasic.CompilerServices.LikeOperator:MatchAsterisk(System.String,int,int,Microsoft.VisualBasic.CompilerServices.LikeOperator+LigatureInfo[],System.String,Microsoft.VisualBasic.CompilerServices.LikeOperator+LigatureInfo[],Microsoft.VisualBasic.CompilerServices.LikeOperator+PatternGroup[],int,byref,byref,System.Globalization.CompareInfo,int) (FullOpts)
         -42 (-1.92% of base) : 199037.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+Builder[System.__Canon]:TryModifyEntries(System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon],System.TimeSpan,System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.IncrementalGeneratorRunStep,int]],int):ubyte:this (FullOpts)
         -42 (-1.92% of base) : 158616.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+Builder[System.__Canon]:TryModifyEntries(System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon],System.TimeSpan,System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.IncrementalGeneratorRunStep,int]],int):ubyte:this (FullOpts)
         -42 (-4.96% of base) : 262871.dasm - System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[System.__Canon,System.Nullable`1[int]]:.ctor(System.Collections.Generic.Dictionary`2[System.__Canon,System.Nullable`1[int]],ubyte):this (FullOpts)
         -42 (-4.96% of base) : 253877.dasm - System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[System.__Canon,System.Nullable`1[int]]:.ctor(System.Collections.Generic.Dictionary`2[System.__Canon,System.Nullable`1[int]],ubyte):this (FullOpts)
         -42 (-0.91% of base) : 206379.dasm - System.Data.DataSet:ReadXml(System.Xml.XmlReader,ubyte):int:this (FullOpts)
         -41 (-1.66% of base) : 303876.dasm - System.ServiceModel.Syndication.Atom10FeedFormatter:ReadFeedFrom(System.Xml.XmlReader,System.ServiceModel.Syndication.SyndicationFeed,ubyte):System.ServiceModel.Syndication.SyndicationFeed:this (FullOpts)
         -36 (-1.31% of base) : 85823.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:CheckValidNullableMethodOverride[System.__Canon](Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType`1[System.__Canon],System.__Canon,ubyte):ubyte (FullOpts)
         -36 (-1.24% of base) : 218780.dasm - System.Management.PropertyData:MapWmiValueToValue(System.Object,int,ubyte):System.Object (FullOpts)
         -35 (-2.58% of base) : 50.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (FullOpts)
         -30 (-3.45% of base) : 162218.dasm - Microsoft.VisualBasic.CompilerServices.OverloadResolution:IsExactSignatureMatch(System.Reflection.ParameterInfo[],int,System.Reflection.ParameterInfo[],int):ubyte (FullOpts)

Top method regressions (percentages):
          68 (19.83% of base) : 232730.dasm - System.Speech.Internal.Synthesis.PcmConverter:Blackman(int,ubyte):float[] (FullOpts)
          19 (18.45% of base) : 138688.dasm - System.Xml.XPath.XPathNavigator:get_XmlLang():System.String:this (FullOpts)
          33 (18.13% of base) : 259264.dasm - System.Collections.Concurrent.ConcurrentDictionary`2[ubyte,System.Nullable`1[int]]:CopyToEntries(System.Collections.DictionaryEntry[],int):this (FullOpts)
          38 (17.27% of base) : 9057.dasm - Microsoft.FSharp.Collections.Array3DModule:Create[long](int,int,int,long):long[,,] (FullOpts)
          37 (16.82% of base) : 9054.dasm - Microsoft.FSharp.Collections.Array3DModule:Create[int](int,int,int,int):int[,,] (FullOpts)
          37 (16.82% of base) : 9052.dasm - Microsoft.FSharp.Collections.Array3DModule:Create[ubyte](int,int,int,ubyte):ubyte[,,] (FullOpts)
          37 (16.74% of base) : 9053.dasm - Microsoft.FSharp.Collections.Array3DModule:Create[short](int,int,int,short):short[,,] (FullOpts)
          54 (16.56% of base) : 9011.dasm - Microsoft.FSharp.Collections.Array4DModule:Create[System.Numerics.Vector`1[float]](int,int,int,int,System.Numerics.Vector`1[float]):System.Numerics.Vector`1[float][,,,] (FullOpts)
          20 (16.39% of base) : 164031.dasm - Newtonsoft.Json.JsonTextReader:MatchValue(ubyte,System.String):ubyte:this (FullOpts)
          44 (15.66% of base) : 99696.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
          31 (15.27% of base) : 85210.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
          16 (15.09% of base) : 274523.dasm - System.Diagnostics.TraceListener:WriteIndent():this (FullOpts)
          36 (14.69% of base) : 53326.dasm - Microsoft.Diagnostics.Tracing.Analysis.GC.TraceGC:GetUserAllocated(System.Collections.Generic.List`1[Microsoft.Diagnostics.Tracing.Analysis.GC.TraceGC],Microsoft.Diagnostics.Tracing.Analysis.GC.TraceGC,int):double (FullOpts)
          70 (14.37% of base) : 20514.dasm - System.HexConverter:TryDecodeFromUtf16_Vector128(System.ReadOnlySpan`1[ushort],System.Span`1[ubyte],byref):ubyte (FullOpts)
          26 (14.13% of base) : 156639.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:FindIndex(int,int,System.Predicate`1[System.__Canon]):int:this (FullOpts)
          26 (14.13% of base) : 172596.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:FindIndex(int,int,System.Predicate`1[System.__Canon]):int:this (FullOpts)
          26 (14.13% of base) : 197072.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:FindIndex(int,int,System.Predicate`1[System.__Canon]):int:this (FullOpts)
         101 (13.95% of base) : 175438.dasm - Microsoft.Build.Logging.BuildEventArgsWriter:Write(Microsoft.Build.Framework.Profiler.EvaluationLocation):this (FullOpts)
          43 (13.65% of base) : 9007.dasm - Microsoft.FSharp.Collections.Array4DModule:Create[ubyte](int,int,int,int,ubyte):ubyte[,,,] (FullOpts)
          20 (13.61% of base) : 281246.dasm - System.Linq.Parallel.JaggedArray`1[ubyte]:Allocate(int,int):ubyte[][] (FullOpts)

Top method improvements (percentages):
         -29 (-16.20% of base) : 8841.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,System.Nullable`1[int]](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,System.Nullable`1[int]] (FullOpts)
         -24 (-13.87% of base) : 172877.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte],int,int,ubyte):int (FullOpts)
         -23 (-13.22% of base) : 172888.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[short]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short],int,int,short):int (FullOpts)
         -27 (-12.92% of base) : 172894.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[long]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[long],int,int,long):int (FullOpts)
         -23 (-12.11% of base) : 172890.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[int]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[int],int,int,int):int (FullOpts)
         -66 (-11.72% of base) : 289207.dasm - System.Net.Mail.QuotedStringFormatReader:TryReadReverseUnQuoted(System.String,int,ubyte,ubyte,byref,ubyte):ubyte (FullOpts)
         -21 (-11.60% of base) : 156887.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte],int,int,ubyte):int (FullOpts)
         -21 (-11.60% of base) : 197320.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[ubyte],int,int,ubyte):int (FullOpts)
         -20 (-10.99% of base) : 197331.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[short]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short],int,int,short):int (FullOpts)
         -20 (-10.99% of base) : 156898.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[short]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[short],int,int,short):int (FullOpts)
         -14 (-9.72% of base) : 278843.dasm - System.IO.IsolatedStorage.IsolatedStorageFile:GetFullPath(System.String):System.String:this (FullOpts)
         -19 (-8.88% of base) : 136487.dasm - System.Xml.Xsl.XsltOld.Key:GetKeys(System.Xml.XPath.XPathNavigator):System.Collections.Hashtable:this (FullOpts)
         -14 (-8.54% of base) : 146142.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:IsSorted[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):ubyte (FullOpts)
         -75 (-7.78% of base) : 28881.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.Nullable`1[int]]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.Nullable`1[int]],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
          -6 (-7.50% of base) : 204937.dasm - System.Xml.DataPointer:ColumnCount(System.Data.DataRow,ubyte,ubyte):int:this (FullOpts)
        -207 (-7.02% of base) : 90514.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
         -70 (-6.86% of base) : 60584.dasm - Microsoft.CodeAnalysis.CSharp.UnboundLambdaState:CollectParameterProperties():System.ValueTuple`4[System.Collections.Immutable.ImmutableArray`1[ubyte],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte]:this (FullOpts)
         -21 (-6.40% of base) : 199084.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.__Canon]:Matches(Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon]):ubyte:this (FullOpts)
         -21 (-6.40% of base) : 158663.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.__Canon]:Matches(Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon]):ubyte:this (FullOpts)
         -17 (-6.18% of base) : 62546.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetCapturedBitmask():Microsoft.CodeAnalysis.BitVector:this (FullOpts)

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

Total bytes of base: 284944324 (overridden on cmd)
Total bytes of diff: 285025367 (overridden on cmd)
Total bytes of delta: 81043 (0.03 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         542 : 316470.dasm (4.27% of base)
         446 : 436031.dasm (7.74% of base)
         300 : 371407.dasm (10.85% of base)
         286 : 239724.dasm (4.64% of base)
         279 : 633503.dasm (18.28% of base)
         268 : 54747.dasm (17.49% of base)
         265 : 368557.dasm (3.59% of base)
         258 : 61082.dasm (6.58% of base)
         250 : 88879.dasm (6.36% of base)
         224 : 399712.dasm (6.55% of base)
         213 : 53927.dasm (5.47% of base)
         189 : 369377.dasm (3.48% of base)
         180 : 184365.dasm (11.59% of base)
         177 : 368300.dasm (1.93% of base)
         175 : 333336.dasm (1.46% of base)
         169 : 447327.dasm (2.36% of base)
         168 : 48304.dasm (7.09% of base)
         168 : 423170.dasm (5.53% of base)
         166 : 439367.dasm (4.27% of base)
         165 : 369673.dasm (10.77% of base)

Top file improvements (bytes):
        -389 : 187647.dasm (-8.63% of base)
        -225 : 461454.dasm (-2.85% of base)
        -207 : 184176.dasm (-7.30% of base)
        -163 : 90167.dasm (-6.36% of base)
        -153 : 645928.dasm (-0.88% of base)
        -147 : 62906.dasm (-3.31% of base)
        -105 : 239141.dasm (-3.48% of base)
        -100 : 691748.dasm (-3.18% of base)
         -99 : 461346.dasm (-2.54% of base)
         -90 : 463066.dasm (-1.51% of base)
         -87 : 107779.dasm (-6.81% of base)
         -84 : 651483.dasm (-1.93% of base)
         -78 : 627576.dasm (-2.60% of base)
         -77 : 391605.dasm (-2.87% of base)
         -77 : 463041.dasm (-1.30% of base)
         -77 : 122989.dasm (-2.86% of base)
         -75 : 642547.dasm (-2.56% of base)
         -75 : 463110.dasm (-1.17% of base)
         -75 : 463048.dasm (-1.22% of base)
         -72 : 648572.dasm (-3.04% of base)

83 total files with Code Size differences (43 improved, 40 regressed), 20 unchanged.

Top method regressions (bytes):
         542 ( 4.27% of base) : 316470.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         446 ( 7.74% of base) : 436031.dasm - System.Xml.XmlLoader:LoadNode(ubyte):System.Xml.XmlNode:this (Tier1)
         300 (10.85% of base) : 371407.dasm - System.SpanTests.SpanTests:TestMatchLastIndexOfAny_String_ManyByte() (Tier1-OSR)
         286 ( 4.64% of base) : 239724.dasm - System.Collections.Tests.IDictionary_Generic_Tests`2[System.__Canon,System.__Canon]:AddToCollection(System.Collections.Generic.ICollection`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]],int):this (Tier1)
         279 (18.28% of base) : 633503.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         268 (17.49% of base) : 54747.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         265 ( 3.59% of base) : 368557.dasm - System.SpanTests.SpanTests:TestMatchTwo_Byte() (Tier1-OSR)
         258 ( 6.58% of base) : 61082.dasm - System.Collections.Immutable.ImmutableDictionary`2[System.__Canon,int]:AddRange(System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,int]],System.Collections.Immutable.ImmutableDictionary`2+MutationInput[System.__Canon,int],int):System.Collections.Immutable.ImmutableDictionary`2+MutationResult[System.__Canon,int] (Tier1)
         250 ( 6.36% of base) : 88879.dasm - System.Collections.Immutable.ImmutableDictionary`2[System.__Canon,int]:AddRange(System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,int]],System.Collections.Immutable.ImmutableDictionary`2+MutationInput[System.__Canon,int],int):System.Collections.Immutable.ImmutableDictionary`2+MutationResult[System.__Canon,int] (Tier1)
         224 ( 6.55% of base) : 399712.dasm - System.UriBuilder:ToString():System.String:this (Tier1)
         213 ( 5.47% of base) : 53927.dasm - Microsoft.CodeAnalysis.CSharp.Binder:LookupMembersInClass(Microsoft.CodeAnalysis.CSharp.LookupResult,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.String,int,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],int,Microsoft.CodeAnalysis.CSharp.Binder,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte,byref):this (Tier1)
         189 ( 3.48% of base) : 369377.dasm - System.SpanTests.SpanTests:TestMatchMany_Byte() (Tier1-OSR)
         180 (11.59% of base) : 184365.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         177 ( 1.93% of base) : 368300.dasm - System.SpanTests.SpanTests:TestMatchIndexOfAny_ThreeString() (Tier1-OSR)
         175 ( 1.46% of base) : 333336.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         169 ( 2.36% of base) : 447327.dasm - System.Xml.XslCompiledTransformApiTests.CArgAddParam:AddParam16(System.Object,int,int,int,int):this (Tier1)
         168 ( 7.09% of base) : 48304.dasm - System.Collections.Immutable.ImmutableDictionary`2[System.__Canon,System.__Canon]:AddRange(System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]],System.Collections.Immutable.ImmutableDictionary`2+MutationInput[System.__Canon,System.__Canon],int):System.Collections.Immutable.ImmutableDictionary`2+MutationResult[System.__Canon,System.__Canon] (Tier1)
         168 ( 5.53% of base) : 423170.dasm - System.Numerics.Tests.Matrix4x4Tests:Matrix4x4CreateFromYawPitchRollTest2():this (Tier1-OSR)
         166 ( 4.27% of base) : 439367.dasm - MS.Internal.Xml.XPath.LogicalExpr:cmpQueryQueryE(int,System.Object,System.Object):ubyte (Tier1)
         165 (10.77% of base) : 369673.dasm - System.SpanTests.SpanTests:TestMatchLastIndexOfAny_ManyByte() (Tier1-OSR)

Top method improvements (bytes):
        -389 (-8.63% of base) : 187647.dasm - Microsoft.Extensions.Options.Generators.Parser:GetModelTypes(Microsoft.CodeAnalysis.ITypeSymbol):System.Collections.Generic.List`1[Microsoft.CodeAnalysis.ITypeSymbol]:this (Tier1)
        -225 (-2.85% of base) : 461454.dasm - System.Xml.Tests.TCReadToNextSibling:v():int:this (Tier1)
        -207 (-7.30% of base) : 184176.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ResolveReferencedAssembly(Microsoft.CodeAnalysis.AssemblyIdentity,Roslyn.Utilities.MultiDictionary`2[System.__Canon,System.ValueTuple`2[System.__Canon,int]],ubyte,Microsoft.CodeAnalysis.AssemblyIdentityComparer):Microsoft.CodeAnalysis.CommonReferenceManager`2+AssemblyReferenceBinding[System.__Canon,System.__Canon] (Tier1)
        -163 (-6.36% of base) : 90167.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (Tier1)
        -153 (-0.88% of base) : 645928.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        -147 (-3.31% of base) : 62906.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState,System.__Canon]:VisitCall(Microsoft.CodeAnalysis.CSharp.BoundCall):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
        -105 (-3.48% of base) : 239141.dasm - System.Collections.Tests.IEnumerable_Generic_Tests`1[System.__Canon]:IEnumerable_Generic_Enumerator_Current_ReturnsSameObjectsOnDifferentEnumerators(int):this (Tier1)
        -100 (-3.18% of base) : 691748.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -99 (-2.54% of base) : 461346.dasm - System.Xml.Tests.TCXMLIntegrityBase:InitReaderPointer():int:this (Tier1)
         -90 (-1.51% of base) : 463066.dasm - System.Xml.Tests.TCReadToDescendant:v11():int:this (Tier1)
         -87 (-6.81% of base) : 107779.dasm - System.Collections.Generic.EnumerableHelpers:ToArray[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon],byref):System.__Canon[] (Instrumented Tier1)
         -84 (-1.93% of base) : 651483.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3379_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         -78 (-2.60% of base) : 627576.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPositionDeltas[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,byref,byref,byref,byref,byref,byref):ubyte:this (Tier1-OSR)
         -77 (-2.87% of base) : 391605.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -77 (-2.86% of base) : 122989.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -77 (-1.30% of base) : 463041.dasm - System.Xml.Tests.TCReadToDescendant:v9():int:this (Tier1)
         -75 (-2.56% of base) : 642547.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState,System.__Canon]:VisitBinaryOperatorChildren(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator]):this (Tier1)
         -75 (-1.22% of base) : 463048.dasm - System.Xml.Tests.TCReadToDescendant:v10():int:this (Tier1)
         -75 (-1.17% of base) : 463110.dasm - System.Xml.Tests.TCReadToNextSibling:v6():int:this (Tier1)
         -72 (-3.04% of base) : 648572.dasm - Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler:FormatComment(System.String):System.String:this (Tier1)

Top method regressions (percentages):
          32 (41.56% of base) : 420232.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+RadiansToDegreesOperator`1[System.Half]](byref,byref,ulong) (Tier1)
          32 (37.21% of base) : 420077.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+Exp2M1Operator`1[System.Half]](byref,byref,ulong) (Tier1)
          30 (27.78% of base) : 411738.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (Instrumented Tier1)
          16 (24.62% of base) : 416299.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[double,double,System.Numerics.Tensors.TensorPrimitives+AcosPiOperator`1[double]](byref,byref,ulong) (Tier1)
          16 (24.62% of base) : 416343.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[double,double,System.Numerics.Tensors.TensorPrimitives+AsinPiOperator`1[double]](byref,byref,ulong) (Tier1)
          16 (24.62% of base) : 416398.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[double,double,System.Numerics.Tensors.TensorPrimitives+AtanPiOperator`1[double]](byref,byref,ulong) (Tier1)
          16 (24.62% of base) : 421839.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[float,float,System.Numerics.Tensors.TensorPrimitives+AcosPiOperator`1[float]](byref,byref,ulong) (Tier1)
          16 (24.62% of base) : 421854.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[float,float,System.Numerics.Tensors.TensorPrimitives+AsinPiOperator`1[float]](byref,byref,ulong) (Tier1)
          16 (24.62% of base) : 421867.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[float,float,System.Numerics.Tensors.TensorPrimitives+AtanPiOperator`1[float]](byref,byref,ulong) (Tier1)
          33 (22.15% of base) : 62741.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)
          33 (22.15% of base) : 94717.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)
          16 (21.62% of base) : 420229.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+Log2P1Operator`1[System.Half]](byref,byref,ulong) (Tier1)
          79 (21.35% of base) : 65379.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:Sum[Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.__Canon,System.__Canon],System.__Canon],System.__Canon],System.__Canon],System.__Canon],System.__Canon]]](System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.__Canon,System.__Canon],System.__Canon],System.__Canon],System.__Canon],System.__Canon],System.__Canon]]],System.Func`2[Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.ValueTuple`2[System.__Canon,System.__Canon],System.__Canon],System.__Canon],System.__Canon],System.__Canon],System.__Canon]],int]):int (Tier1)
          69 (20.91% of base) : 555681.dasm - System.Speech.Internal.Synthesis.PcmConverter:Blackman(int,ubyte):float[] (Tier1-OSR)
          63 (20.52% of base) : 483766.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:Vector256DoubleStoreTest():this (Tier0-FullOpts)
          63 (20.52% of base) : 483617.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:Vector256DoubleStoreUnsafeTest():this (Tier0-FullOpts)
          63 (20.52% of base) : 483760.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:Vector256SingleStoreTest():this (Tier0-FullOpts)
          63 (20.52% of base) : 483537.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:Vector256SingleStoreUnsafeTest():this (Tier0-FullOpts)
          33 (20.50% of base) : 642133.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)
          49 (20.42% of base) : 91788.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)

Top method improvements (percentages):
         -38 (-21.11% of base) : 83966.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (Tier1)
         -42 (-20.90% of base) : 191521.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (Tier1)
         -34 (-12.45% of base) : 62733.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
         -34 (-12.45% of base) : 94713.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
         -34 (-11.68% of base) : 642129.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (Tier1)
         -68 (-10.15% of base) : 219216.dasm - System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[System.__Canon,System.__Canon]:.ctor(System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon],ubyte):this (Tier1-OSR)
         -21 (-8.75% of base) : 93937.dasm - System.Collections.Generic.GenericArraySortHelper`1[Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[System.__Canon]]:BinarySearch(Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[System.__Canon][],int,int,Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[System.__Canon]):int (Tier1)
        -389 (-8.63% of base) : 187647.dasm - Microsoft.Extensions.Options.Generators.Parser:GetModelTypes(Microsoft.CodeAnalysis.ITypeSymbol):System.Collections.Generic.List`1[Microsoft.CodeAnalysis.ITypeSymbol]:this (Tier1)
          -5 (-7.94% of base) : 599815.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 121127.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 198217.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 203716.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 680705.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 214851.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 560777.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 489443.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 398023.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 333417.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 338691.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)
          -5 (-7.94% of base) : 477288.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (Tier1)

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

Total bytes of base: 136277954 (overridden on cmd)
Total bytes of diff: 136383362 (overridden on cmd)
Total bytes of delta: 105408 (0.08 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         298 : 73085.dasm (7.54% of base)
         217 : 150953.dasm (11.48% of base)
         217 : 150949.dasm (11.48% of base)
         190 : 125154.dasm (9.25% of base)
         189 : 194543.dasm (16.51% of base)
         187 : 76089.dasm (18.24% of base)
         176 : 316957.dasm (8.68% of base)
         171 : 213526.dasm (12.12% of base)
         171 : 223695.dasm (12.12% of base)
         166 : 137527.dasm (5.79% of base)
         162 : 76447.dasm (11.78% of base)
         161 : 170435.dasm (14.35% of base)
         161 : 170199.dasm (14.35% of base)
         159 : 170599.dasm (14.00% of base)
         159 : 77134.dasm (8.31% of base)
         158 : 93917.dasm (14.48% of base)
         158 : 75912.dasm (12.21% of base)
         157 : 170735.dasm (13.82% of base)
         154 : 97460.dasm (16.83% of base)
         154 : 97457.dasm (16.72% of base)

Top file improvements (bytes):
        -207 : 49961.dasm (-7.02% of base)
        -207 : 5153.dasm (-7.02% of base)
        -207 : 44138.dasm (-7.02% of base)
        -203 : 137652.dasm (-4.20% of base)
        -128 : 78387.dasm (-5.77% of base)
         -79 : 78303.dasm (-3.17% of base)
         -76 : 240396.dasm (-3.45% of base)
         -65 : 149513.dasm (-1.23% of base)
         -55 : 203487.dasm (-5.00% of base)
         -55 : 78124.dasm (-2.26% of base)
         -50 : 170150.dasm (-3.07% of base)
         -47 : 169270.dasm (-3.65% of base)
         -47 : 170074.dasm (-3.73% of base)
         -47 : 169673.dasm (-3.32% of base)
         -47 : 169499.dasm (-3.45% of base)
         -47 : 169497.dasm (-2.91% of base)
         -45 : 203645.dasm (-2.98% of base)
         -45 : 137950.dasm (-2.28% of base)
         -45 : 203646.dasm (-2.96% of base)
         -43 : 29963.dasm (-2.57% of base)

93 total files with Code Size differences (38 improved, 55 regressed), 20 unchanged.

Top method regressions (bytes):
         298 ( 7.54% of base) : 73085.dasm - System.Collections.Frozen.Tests.FrozenDictionary_Generic_Tests`2[System.__Canon,System.__Canon]:EmptySource_ProducedFrozenDictionaryEmpty():this (FullOpts)
         217 (11.48% of base) : 150949.dasm - System.SpanTests.IndexOfAnyInRangeTests`1[System.__Canon]:MatrixOfLengthsAndOffsets_Any_FindsValueAtExpectedIndex():this (FullOpts)
         217 (11.48% of base) : 150953.dasm - System.SpanTests.IndexOfAnyInRangeTests`1[System.__Canon]:MatrixOfLengthsAndOffsets_AnyExcept_FindsValueAtExpectedIndex():this (FullOpts)
         190 ( 9.25% of base) : 125154.dasm - System.IO.Tests.StandaloneStreamConformanceTests+<Read_PartiallySatisfied_RemainderOfBufferUntouched>d__21:MoveNext():this (FullOpts)
         189 (16.51% of base) : 194543.dasm - System.Resources.Extensions.Tests.PreserializedResourceWriterTests:CanReadViaResourceManager() (FullOpts)
         187 (18.24% of base) : 76089.dasm - System.Collections.Tests.ArrayListTests+<>c__DisplayClass130_0:<Sort_IComparer>b__0(System.Collections.ArrayList):this (FullOpts)
         176 ( 8.68% of base) : 316957.dasm - System.Threading.Tests.ThreadLocalTests:RunThreadLocalTest6_SlowPath() (FullOpts)
         171 (12.12% of base) : 213526.dasm - System.Collections.ObjectModel.Tests.CollectionTests:CopyTo() (FullOpts)
         171 (12.12% of base) : 223695.dasm - System.Collections.ObjectModel.Tests.ReadOnlyCollectionTests:CopyTo() (FullOpts)
         166 ( 5.79% of base) : 137527.dasm - System.IO.Tests.Stream_ReadAtLeast+<HandleEndOfStream>d__6:MoveNext():this (FullOpts)
         162 (11.78% of base) : 76447.dasm - System.Collections.Tests.ArrayListTests+<>c__DisplayClass71_0:<GetRange_ChangeUnderlyingCollection>b__0(System.Collections.ArrayList):this (FullOpts)
         161 (14.35% of base) : 170199.dasm - System.Numerics.Tests.GenericVectorTests:NarrowInt64():this (FullOpts)
         161 (14.35% of base) : 170435.dasm - System.Numerics.Tests.GenericVectorTests:NarrowUInt64():this (FullOpts)
         159 ( 8.31% of base) : 77134.dasm - System.Collections.Specialized.Tests.StringDictionaryCopyToTests:CopyTo(int,int):this (FullOpts)
         159 (14.00% of base) : 170599.dasm - System.Numerics.Tests.GenericVectorTests:NarrowInt32():this (FullOpts)
         158 (12.21% of base) : 75912.dasm - System.Collections.Tests.SortedListTests+<>c:<IndexOfValue>b__61_0(System.Collections.SortedList):this (FullOpts)
         158 (14.48% of base) : 93917.dasm - System.Tests.KeyParserTests:ExtendedStringCodePath():this (FullOpts)
         157 (13.82% of base) : 170735.dasm - System.Numerics.Tests.GenericVectorTests:NarrowUInt16():this (FullOpts)
         154 (16.72% of base) : 97457.dasm - System.Data.Tests.DataSetTest:CreateDataReader2():this (FullOpts)
         154 (16.83% of base) : 97460.dasm - System.Data.Tests.DataSetTest:CreateDataReader3():this (FullOpts)

Top method improvements (bytes):
        -207 (-7.02% of base) : 49961.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -207 (-7.02% of base) : 5153.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -207 (-7.02% of base) : 44138.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -203 (-4.20% of base) : 137652.dasm - System.IO.Tests.BinaryWriterTests:BinaryWriter_SeekTests():this (FullOpts)
        -128 (-5.77% of base) : 78387.dasm - System.Collections.Tests.LinkedList_Generic_Tests`1[System.__Canon]:Find_T():this (FullOpts)
         -79 (-3.17% of base) : 78303.dasm - System.Collections.Tests.LinkedList_T_Tests`1[System.__Canon]:VerifyState(System.Collections.Generic.LinkedList`1[System.__Canon],System.__Canon[]) (FullOpts)
         -76 (-3.45% of base) : 240396.dasm - System.ServiceModel.Syndication.AtomPub10ServiceDocumentFormatter:ReadDocument(System.Xml.XmlReader):this (FullOpts)
         -65 (-1.23% of base) : 149513.dasm - System.Management.PropertyData:MapValueToWmiValue(System.Object,int,ubyte):System.Object (FullOpts)
         -55 (-2.26% of base) : 78124.dasm - System.Collections.Tests.LinkedList_Generic_Tests`1[System.__Canon]:VerifyState(System.Collections.Generic.LinkedList`1[System.__Canon],System.__Canon[]) (FullOpts)
         -55 (-5.00% of base) : 203487.dasm - System.Numerics.Tests.powTest:RunPowAxiomXPow0() (FullOpts)
         -50 (-3.07% of base) : 170150.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorGreaterThanOrEqualAll[float]():this (FullOpts)
         -47 (-3.65% of base) : 169270.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorGreaterThanAll[short]():this (FullOpts)
         -47 (-3.73% of base) : 170074.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorGreaterThanAny[long]():this (FullOpts)
         -47 (-2.91% of base) : 169497.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorGreaterThanOrEqualAny[ulong]():this (FullOpts)
         -47 (-3.45% of base) : 169499.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorLessThanOrEqualAll[ushort]():this (FullOpts)
         -47 (-3.32% of base) : 169673.dasm - System.Numerics.Tests.GenericVectorTests:TestVectorLessThanOrEqualAny[int]():this (FullOpts)
         -45 (-2.28% of base) : 137950.dasm - System.IO.Tests.StreamReaderTests:Read_LongStreamIntoShortBuffer_PerformsFinalFlushCorrectly():this (FullOpts)
         -45 (-2.96% of base) : 203646.dasm - System.Numerics.BigInteger:RotateLeft(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
         -45 (-2.98% of base) : 203645.dasm - System.Numerics.BigInteger:RotateRight(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
         -43 (-2.57% of base) : 29963.dasm - Microsoft.Extensions.Caching.Memory.MemoryCacheHasStatisticsTests:GetCurrentStatistics_GetCache_UpdatesStatistics(ubyte):this (FullOpts)

Top method regressions (percentages):
         137 (41.64% of base) : 78113.dasm - System.Collections.Tests.ICollection_Generic_Tests`1[System.__Canon]:AddToCollection(System.Collections.Generic.ICollection`1[System.__Canon],int):this (FullOpts)
          43 (24.43% of base) : 51900.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
          43 (24.43% of base) : 7261.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
          49 (23.33% of base) : 120709.dasm - System.Collections.Generic.GenericEqualityComparer`1[System.Formats.Asn1.AsnWriter+StackFrame]:LastIndexOf(System.Formats.Asn1.AsnWriter+StackFrame[],System.Formats.Asn1.AsnWriter+StackFrame,int,int):int:this (FullOpts)
          59 (22.87% of base) : 125604.dasm - System.Globalization.ISOWeekTests:GetWeeksInYear() (FullOpts)
          56 (22.76% of base) : 221654.dasm - System.Tests.StringTests+<>c:<Create_ClearsMemory>b__317_0(System.Span`1[ushort],System.Object):this (FullOpts)
          56 (22.76% of base) : 201810.dasm - System.Tests.StringTests+<>c:<Create_ClearsMemory>b__8_0(System.Span`1[ushort],System.Object):this (FullOpts)
          32 (22.07% of base) : 168894.dasm - System.Numerics.Tensors.Tests.ConvertToHalfTests:CreateAndFillSingleTensor(int):System.Buffers.BoundedMemory`1[float]:this (FullOpts)
          64 (21.77% of base) : 169685.dasm - System.Numerics.Tests.GenericVectorTests:CreateSequenceUInt16Test(ushort,ushort):this (FullOpts)
          64 (21.77% of base) : 199112.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:CreateSequenceUInt16Test(ushort,ushort):this (FullOpts)
          33 (21.57% of base) : 10507.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)
          64 (21.55% of base) : 170606.dasm - System.Numerics.Tests.GenericVectorTests:CreateSequenceInt16Test(short,short):this (FullOpts)
          64 (21.55% of base) : 199572.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:CreateSequenceInt16Test(short,short):this (FullOpts)
          61 (21.11% of base) : 169665.dasm - System.Numerics.Tests.GenericVectorTests:CreateSequenceInt32Test(int,int):this (FullOpts)
          61 (21.11% of base) : 170809.dasm - System.Numerics.Tests.GenericVectorTests:CreateSequenceUInt32Test(uint,uint):this (FullOpts)
          61 (21.11% of base) : 199699.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:CreateSequenceInt32Test(int,int):this (FullOpts)
          61 (21.11% of base) : 199702.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:CreateSequenceUInt32Test(uint,uint):this (FullOpts)
          49 (20.59% of base) : 199775.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector512Tests:Vector512Int32ShuffleOneInputWithAllBitsSetIndicesTest():this (FullOpts)
          49 (20.59% of base) : 200064.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector512Tests:Vector512UInt32ShuffleOneInputWithAllBitsSetIndicesTest():this (FullOpts)
          59 (20.56% of base) : 199233.dasm - System.Runtime.Intrinsics.Tests.Vectors.Vector256Tests:Vector256DoubleShuffleOneInputWithZeroIndicesTest():this (FullOpts)

Top method improvements (percentages):
         -20 (-13.61% of base) : 123332.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[int,System.__Canon](System.Collections.Generic.IComparer`1[int],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[int,System.__Canon] (FullOpts)
         -34 (-12.64% of base) : 10502.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
         -19 (-12.58% of base) : 3122.dasm - Microsoft.VisualStudio.Composition.Utilities:EqualsByValue[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Immutable.ImmutableArray`1[System.__Canon]):ubyte (FullOpts)
         -25 (-10.20% of base) : 13166.dasm - System.Collections.Generic.GenericArraySortHelper`1[Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[System.__Canon]]:BinarySearch(Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[System.__Canon][],int,int,Microsoft.CodeAnalysis.LineDirectiveMap`1+LineMappingEntry[System.__Canon]):int (FullOpts)
         -19 (-8.96% of base) : 177965.dasm - System.Xml.Xsl.XsltOld.Key:GetKeys(System.Xml.XPath.XPathNavigator):System.Collections.Hashtable:this (FullOpts)
         -24 (-7.34% of base) : 171489.dasm - System.Collections.ObjectModel.Tests.IReadOnlyDictionary_T_Test`2[int,System.__Canon]:VerifyCollection(System.Collections.Generic.IReadOnlyDictionary`2[int,System.__Canon],System.Collections.Generic.KeyValuePair`2[int,System.__Canon][]):this (FullOpts)
         -23 (-7.03% of base) : 5550.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
        -207 (-7.02% of base) : 49961.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -207 (-7.02% of base) : 5153.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -207 (-7.02% of base) : 44138.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
         -19 (-7.01% of base) : 73078.dasm - System.Collections.Frozen.FrozenDictionary`2[System.__Canon,System.__Canon]:CopyTo(System.Span`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]):this (FullOpts)
         -27 (-6.51% of base) : 12926.dasm - Microsoft.Interop.ValueEqualityImmutableDictionary`2[System.__Canon,System.__Canon]:GetHashCode():int:this (FullOpts)
         -21 (-6.40% of base) : 19442.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.__Canon]:Matches(Microsoft.CodeAnalysis.NodeStateTable`1+TableEntry[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon]):ubyte:this (FullOpts)
         -17 (-6.18% of base) : 17957.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetCapturedBitmask():Microsoft.CodeAnalysis.BitVector:this (FullOpts)
         -37 (-6.13% of base) : 77589.dasm - System.Collections.Tests.IEnumerable_Generic_Tests`1[System.ValueTuple`2[System.__Canon,System.__Canon]]:IEnumerable_Generic_Enumerator_Current_ReturnsSameValueOnRepeatedCalls(int):this (FullOpts)
         -37 (-6.03% of base) : 69141.dasm - System.Collections.Tests.IEnumerable_Generic_Tests`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:IEnumerable_Generic_Enumerator_Current_ReturnsSameValueOnRepeatedCalls(int):this (FullOpts)
         -28 (-5.85% of base) : 140014.dasm - System.Linq.Parallel.InlinedAggregationOperator`3[System.__Canon,int,int]:WrapPartitionedStream[int](System.Linq.Parallel.PartitionedStream`2[System.__Canon,int],System.Linq.Parallel.IPartitionedStreamRecipient`1[int],ubyte,System.Linq.Parallel.QuerySettings):this (FullOpts)
          -9 (-5.81% of base) : 51401.dasm - Microsoft.CodeAnalysis.SyntaxNode:FirstAncestorOrSelf[System.__Canon](System.Func`2[System.__Canon,ubyte],ubyte):System.__Canon:this (FullOpts)
          -9 (-5.81% of base) : 8818.dasm - Microsoft.CodeAnalysis.SyntaxNode:FirstAncestorOrSelf[System.__Canon](System.Func`2[System.__Canon,ubyte],ubyte):System.__Canon:this (FullOpts)
          -9 (-5.81% of base) : 44221.dasm - Microsoft.CodeAnalysis.SyntaxNode:FirstAncestorOrSelf[System.__Canon](System.Func`2[System.__Canon,ubyte],ubyte):System.__Canon:this (FullOpts)

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

Total bytes of base: 13972463 (overridden on cmd)
Total bytes of diff: 13979936 (overridden on cmd)
Total bytes of delta: 7473 (0.05 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         341 : 1087.dasm (10.19% of base)
         104 : 29303.dasm (4.64% of base)
         102 : 1114.dasm (2.78% of base)
         100 : 25570.dasm (8.09% of base)
          95 : 940.dasm (4.58% of base)
          94 : 23344.dasm (2.59% of base)
          89 : 17141.dasm (5.89% of base)
          88 : 23611.dasm (6.44% of base)
          87 : 1185.dasm (12.85% of base)
          86 : 36141.dasm (9.82% of base)
          84 : 21134.dasm (3.88% of base)
          84 : 7853.dasm (0.97% of base)
          80 : 1864.dasm (6.81% of base)
          80 : 1107.dasm (8.72% of base)
          79 : 1061.dasm (0.89% of base)
          77 : 15697.dasm (5.58% of base)
          74 : 26810.dasm (6.68% of base)
          74 : 1175.dasm (4.17% of base)
          74 : 1455.dasm (3.86% of base)
          71 : 18689.dasm (2.11% of base)

Top file improvements (bytes):
        -161 : 15663.dasm (-3.11% of base)
        -138 : 21281.dasm (-5.05% of base)
        -137 : 15664.dasm (-2.67% of base)
         -90 : 4949.dasm (-9.45% of base)
         -44 : 24088.dasm (-1.59% of base)
         -42 : 21519.dasm (-3.26% of base)
         -42 : 15577.dasm (-1.23% of base)
         -41 : 15665.dasm (-1.32% of base)
         -40 : 23418.dasm (-1.45% of base)
         -34 : 25795.dasm (-12.64% of base)
         -29 : 11477.dasm (-16.29% of base)
         -23 : 21419.dasm (-7.37% of base)
         -23 : 34746.dasm (-4.03% of base)
         -23 : 33527.dasm (-1.19% of base)
         -21 : 25784.dasm (-2.30% of base)
         -17 : 27793.dasm (-6.18% of base)
         -15 : 4678.dasm (-0.55% of base)
         -15 : 30930.dasm (-3.37% of base)
         -13 : 21746.dasm (-3.19% of base)
         -12 : 133.dasm (-2.55% of base)

82 total files with Code Size differences (31 improved, 51 regressed), 20 unchanged.

Top method regressions (bytes):
         341 (10.19% of base) : 1087.dasm - BepuPhysics.CollisionDetection.CollisionTasks.ConvexCompoundOverlapFinder`3[BepuPhysics.Collidables.Triangle,BepuPhysics.Collidables.TriangleWide,BepuPhysics.Collidables.Compound]:FindLocalOverlaps(byref,int,BepuUtilities.Memory.BufferPool,BepuPhysics.Collidables.Shapes,float,byref):this (FullOpts)
         104 ( 4.64% of base) : 29303.dasm - Microsoft.CodeAnalysis.AnalyzerConfig:Parse(Microsoft.CodeAnalysis.Text.SourceText,System.String):Microsoft.CodeAnalysis.AnalyzerConfig (FullOpts)
         102 ( 2.78% of base) : 1114.dasm - BepuPhysics.CollisionDetection.CollisionTasks.MeshPairOverlapFinder`2[BepuPhysics.Collidables.Mesh,BepuPhysics.Collidables.Mesh]:FindLocalOverlaps(byref,int,BepuUtilities.Memory.BufferPool,BepuPhysics.Collidables.Shapes,float,byref):this (FullOpts)
         100 ( 8.09% of base) : 25570.dasm - Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker:VisitAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):this (FullOpts)
          95 ( 4.58% of base) : 940.dasm - DemoBenchmarks.Sweeper:.ctor():this (FullOpts)
          94 ( 2.59% of base) : 23344.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ParameterHelpers:MakeParameters[System.__Canon,System.__Canon,System.__Canon](Microsoft.CodeAnalysis.CSharp.Binder,System.__Canon,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[System.__Canon],byref,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte,ubyte,ubyte,int,System.Func`12[System.__Canon,System.__Canon,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.__Canon,ubyte,int,Microsoft.CodeAnalysis.SyntaxToken,Microsoft.CodeAnalysis.SyntaxToken,ubyte,ubyte,System.__Canon,System.__Canon],ubyte):System.Collections.Immutable.ImmutableArray`1[System.__Canon] (FullOpts)
          89 ( 5.89% of base) : 17141.dasm - Microsoft.ML.Trainers.KMeansUtils:ParallelMapReduce[System.__Canon,System.__Canon](int,Microsoft.ML.Runtime.IHost,Microsoft.ML.Trainers.FeatureFloatVectorCursor+Factory,Microsoft.ML.Trainers.KMeansUtils+RowIndexGetter,Microsoft.ML.Trainers.KMeansUtils+InitAction`1[System.__Canon],Microsoft.ML.Trainers.KMeansUtils+MapAction`1[System.__Canon],Microsoft.ML.Trainers.KMeansUtils+ReduceAction`2[System.__Canon,System.__Canon],byref,byref):Microsoft.ML.Trainers.KMeansUtils+RowStats (FullOpts)
          88 ( 6.44% of base) : 23611.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:GetDeclaringSyntaxReferenceHelper[System.__Canon](System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.Location]):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.SyntaxReference] (FullOpts)
          87 (12.85% of base) : 1185.dasm - BepuPhysics.CollisionDetection.SweepTasks.CompoundPairSweepOverlapFinder`2[BepuPhysics.Collidables.BigCompound,BepuPhysics.Collidables.BigCompound]:FindOverlaps(byref,byref,byref,byref,byref,byref,byref,float,BepuPhysics.Collidables.Shapes,BepuUtilities.Memory.BufferPool,byref):this (FullOpts)
          86 ( 9.82% of base) : 36141.dasm - System.Management.Automation.CmdletParameterBinderController:HandleUnboundMandatoryParameters(int,ubyte,ubyte,ubyte,byref):ubyte:this (FullOpts)
          84 ( 0.97% of base) : 7853.dasm - FSharp.Compiler.CheckExpressions:TcTypeOrMeasure(Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+TyparKind],FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.CheckExpressions+ImplicitlyBoundTyparsAllowed,FSharp.Compiler.CheckExpressions+CheckConstraints,FSharp.Compiler.NameResolution+ItemOccurence,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.Syntax.SynType):System.Tuple`2[FSharp.Compiler.TypedTree+TType,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
          84 ( 3.88% of base) : 21134.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:TryAddAssembly(Microsoft.CodeAnalysis.AssemblyIdentity,Microsoft.CodeAnalysis.MetadataReference,int,Microsoft.CodeAnalysis.DiagnosticBag,Microsoft.CodeAnalysis.Location,System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon],ubyte):Microsoft.CodeAnalysis.MetadataReference:this (FullOpts)
          80 ( 8.72% of base) : 1107.dasm - BepuPhysics.Collidables.ConvexHullWide:GetBounds(byref,int,byref,byref,byref,byref):this (FullOpts)
          80 ( 6.81% of base) : 1864.dasm - System.Xml.XmlLoader:LoadNode(ubyte):System.Xml.XmlNode:this (FullOpts)
          79 ( 0.89% of base) : 1061.dasm - BepuPhysics.CollisionDetection.CollisionTasks.CylinderConvexHullTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
          77 ( 5.58% of base) : 15697.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:GetQuantizedColor(SixLabors.ImageSharp.PixelFormats.Rgba32,byref):ubyte:this (FullOpts)
          74 ( 4.17% of base) : 1175.dasm - BepuPhysics.Constraints.Contact.ContactNonconvexTwoBodyFunctions`2[BepuPhysics.Constraints.Contact.Contact4NonconvexPrestepData,BepuPhysics.Constraints.Contact.Contact4NonconvexAccumulatedImpulses]:WarmStart(byref,byref,byref,byref,byref,byref,byref,byref,byref,byref):this (FullOpts)
          74 ( 3.86% of base) : 1455.dasm - BepuPhysics.PoseIntegrator`1[DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks]:IntegrateBundlesAfterSubstepping(byref,int,int,float,float,int,int):this (FullOpts)
          74 ( 6.68% of base) : 26810.dasm - Microsoft.CodeAnalysis.TopologicalSort:PredecessorCounts[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon],Microsoft.CodeAnalysis.TopologicalSortAddSuccessors`1[System.__Canon],byref):Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[System.__Canon,int] (FullOpts)
          71 ( 2.11% of base) : 18689.dasm - Microsoft.ML.Trainers.SdcaTrainerBase`3[System.__Canon,System.__Canon,System.__Canon]:TrainWithoutLock(Microsoft.ML.Runtime.IProgressChannelProvider,Microsoft.ML.Trainers.FloatLabelCursor+Factory,System.Random,Microsoft.ML.Trainers.SdcaTrainerBase`3+IdToIdxLookup[System.__Canon,System.__Canon,System.__Canon],int,Microsoft.ML.Trainers.SdcaTrainerBase`3+DualsTableBase[System.__Canon,System.__Canon,System.__Canon],float[],float[],float,Microsoft.ML.Data.VBuffer`1[float][],float[],Microsoft.ML.Data.VBuffer`1[float][],float[],float[]):this (FullOpts)

Top method improvements (bytes):
        -161 (-3.11% of base) : 15663.dasm - SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:ProcessBorderColumn(SixLabors.ImageSharp.Memory.Buffer2D`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1+CdfTileData[SixLabors.ImageSharp.PixelFormats.Rgba32],int,int,int,int,int,int,int) (FullOpts)
        -138 (-5.05% of base) : 21281.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
        -137 (-2.67% of base) : 15664.dasm - SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:ProcessBorderRow(SixLabors.ImageSharp.Memory.Buffer2D`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1+CdfTileData[SixLabors.ImageSharp.PixelFormats.Rgba32],int,int,int,int,int,int,int) (FullOpts)
         -90 (-9.45% of base) : 4949.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,int]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[int],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         -44 (-1.59% of base) : 24088.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:CheckValidNullableMethodOverride[System.ValueTuple`2[System.__Canon,ubyte]](Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType`1[System.ValueTuple`2[System.__Canon,ubyte]],Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType`1[System.ValueTuple`2[System.__Canon,ubyte]],System.ValueTuple`2[System.__Canon,ubyte],ubyte):ubyte (FullOpts)
         -42 (-1.23% of base) : 15577.dasm - SixLabors.ImageSharp.Processing.Processors.Dithering.OrderedDither:ApplyQuantizationDither[SixLabors.ImageSharp.Processing.Processors.Quantization.PaletteQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.PixelFormats.Rgba32](byref,SixLabors.ImageSharp.ImageFrame`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.IndexedImageFrame`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.Rectangle):this (FullOpts)
         -42 (-3.26% of base) : 21519.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (FullOpts)
         -41 (-1.32% of base) : 15665.dasm - SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:ProcessCornerTile(SixLabors.ImageSharp.Memory.Buffer2D`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1+CdfTileData[SixLabors.ImageSharp.PixelFormats.Rgba32],int,int,int,int,int,int,int) (FullOpts)
         -40 (-1.45% of base) : 23418.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:CheckValidNullableMethodOverride[System.__Canon](Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType`1[System.__Canon],Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType`1[System.__Canon],System.__Canon,ubyte):ubyte (FullOpts)
         -34 (-12.64% of base) : 25795.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
         -29 (-16.29% of base) : 11477.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,FSharp.Compiler.Text.Range](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range] (FullOpts)
         -23 (-7.37% of base) : 21419.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
         -23 (-4.03% of base) : 34746.dasm - System.Management.Automation.Interpreter.HybridReferenceDictionary`2[System.__Canon,System.__Canon]:set_Item(System.__Canon,System.__Canon):this (FullOpts)
         -23 (-1.19% of base) : 33527.dasm - System.Management.Automation.Runspaces.TypeTable:ProcessStandardMembers(System.Collections.Concurrent.ConcurrentBag`1[System.String],System.String,System.Management.Automation.PSMemberInfoInternalCollection`1[System.Management.Automation.PSMemberInfo],System.Management.Automation.PSMemberInfoInternalCollection`1[System.Management.Automation.PSMemberInfo],ubyte) (FullOpts)
         -21 (-2.30% of base) : 25784.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:IsLessDerivedThanAny[System.__Canon](int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]],byref):ubyte (FullOpts)
         -17 (-6.18% of base) : 27793.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetCapturedBitmask():Microsoft.CodeAnalysis.BitVector:this (FullOpts)
         -15 (-3.37% of base) : 30930.dasm - System.Number:NegativeInt32ToDecStr(int,int,System.String):System.String (FullOpts)
         -15 (-0.55% of base) : 4678.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (FullOpts)
         -13 (-3.19% of base) : 21746.dasm - Microsoft.CodeAnalysis.BindingDiagnosticBag`1[System.__Canon]:AddDependencies(System.Collections.Immutable.ImmutableHashSet`1[System.__Canon]):this (FullOpts)
         -12 (-2.55% of base) : 133.dasm - System.PackedSpanHelpers:IndexOf[System.SpanHelpers+DontNegate`1[short],System.PackedSpanHelpers+NopTransform](byref,short,int):int (FullOpts)

Top method regressions (percentages):
          28 (46.67% of base) : 957.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
          43 (24.43% of base) : 24610.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
          33 (21.57% of base) : 25797.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)
          49 (20.42% of base) : 22322.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:SingleValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
          32 (18.18% of base) : 27032.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:ResolveBranches(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol,Microsoft.CodeAnalysis.CSharp.BoundStatement):ubyte:this (FullOpts)
          26 (17.11% of base) : 26533.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:JoinPendingBranches(byref,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol):this (FullOpts)
          16 (15.09% of base) : 4804.dasm - System.Diagnostics.TraceListener:WriteIndent():this (FullOpts)
          43 (13.65% of base) : 25990.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:DoVisitList[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon]:this (FullOpts)
          27 (13.43% of base) : 4543.dasm - System.Buffers.SharedArrayPoolPartitions:.ctor(int):this (FullOpts)
          24 (13.26% of base) : 1580.dasm - DemoBenchmarks.ShapeRayBenchmarksDeep:Test[BepuPhysics.Collidables.Compound]():System.Numerics.Vector3:this (FullOpts)
          87 (12.85% of base) : 1185.dasm - BepuPhysics.CollisionDetection.SweepTasks.CompoundPairSweepOverlapFinder`2[BepuPhysics.Collidables.BigCompound,BepuPhysics.Collidables.BigCompound]:FindOverlaps(byref,byref,byref,byref,byref,byref,byref,float,BepuPhysics.Collidables.Shapes,BepuUtilities.Memory.BufferPool,byref):this (FullOpts)
          37 (11.97% of base) : 1211.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:TestOrientationless1Contact[BepuPhysics.CollisionDetection.CollisionTasks.SpherePairTester,BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.SphereWide](BepuPhysics.Collidables.SphereWide,BepuPhysics.Collidables.SphereWide):System.Numerics.Vector`1[float]:this (FullOpts)
          21 (11.93% of base) : 36897.dasm - System.Linq.Enumerable+WhereListIterator`1[System.__Canon]:MoveNext():ubyte:this (FullOpts)
          22 (11.89% of base) : 25598.dasm - Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker:TryGetClsComplianceAttributeLocation(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData],Microsoft.CodeAnalysis.CSharp.Symbol,byref):ubyte:this (FullOpts)
           7 (11.48% of base) : 20928.dasm - Microsoft.CodeAnalysis.GreenNode:GetSlotOffset(int):int:this (FullOpts)
          70 (11.16% of base) : 35643.dasm - System.Management.Automation.Language.Tokenizer:GetStringSimilarity(System.String,System.String,int[,]):int (FullOpts)
           7 (11.11% of base) : 25181.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeWalker:VisitList[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):this (FullOpts)
          33 (11.07% of base) : 15871.dasm - SixLabors.ImageSharp.Processing.Processors.Convolution.Parameters.BokehBlurKernelDataProvider:CreateComplex1DKernel(int,int,float,float,float):SixLabors.ImageSharp.Complex64[] (FullOpts)
         341 (10.19% of base) : 1087.dasm - BepuPhysics.CollisionDetection.CollisionTasks.ConvexCompoundOverlapFinder`3[BepuPhysics.Collidables.Triangle,BepuPhysics.Collidables.TriangleWide,BepuPhysics.Collidables.Compound]:FindLocalOverlaps(byref,int,BepuUtilities.Memory.BufferPool,BepuPhysics.Collidables.Shapes,float,byref):this (FullOpts)
          18 ( 9.84% of base) : 17112.dasm - Microsoft.ML.Transforms.MinMaxSngAggregator:.ctor(int):this (FullOpts)

Top method improvements (percentages):
         -29 (-16.29% of base) : 11477.dasm - Microsoft.FSharp.Collections.MapTreeModule:ofArray[System.__Canon,FSharp.Compiler.Text.Range](System.Collections.Generic.IComparer`1[System.__Canon],System.__Canon[]):Microsoft.FSharp.Collections.MapTree`2[System.__Canon,FSharp.Compiler.Text.Range] (FullOpts)
         -34 (-12.64% of base) : 25795.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:AnyValidResult[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.MemberResolutionResult`1[System.__Canon]]):ubyte (FullOpts)
         -90 (-9.45% of base) : 4949.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,int]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[int],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         -23 (-7.37% of base) : 21419.dasm - Microsoft.CodeAnalysis.ImmutableArrayExtensions:CreateNameToMembersMap[System.ReadOnlyMemory`1[ushort],System.__Canon,System.__Canon,System.__Canon](System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Object],System.Collections.Generic.Dictionary`2[System.ReadOnlyMemory`1[ushort],System.Collections.Immutable.ImmutableArray`1[System.__Canon]]) (FullOpts)
          -4 (-6.78% of base) : 757.dasm - System.Reflection.MetadataToken:IsTokenOfType(int,int[]):ubyte (FullOpts)
         -17 (-6.18% of base) : 27793.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetCapturedBitmask():Microsoft.CodeAnalysis.BitVector:this (FullOpts)
          -8 (-5.48% of base) : 23588.dasm - Microsoft.CodeAnalysis.CSharp.MostCommonNullableValueBuilder:GetCommonValue(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[ubyte]):System.Nullable`1[ubyte] (FullOpts)
        -138 (-5.05% of base) : 21281.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation+ReferenceManager:SetupReferencesForSourceAssembly(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.PEModule],int,Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol][],byref,byref) (FullOpts)
          -6 (-4.69% of base) : 30667.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetNonMemberSymbol(int):Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -5 (-4.24% of base) : 13640.dasm - FSharp.Compiler.TypedTreePickle:p_array_core[System.__Canon,System.__Canon](Microsoft.FSharp.Core.FSharpFunc`2[System.__Canon,System.__Canon],System.__Canon[],System.__Canon) (FullOpts)
         -23 (-4.03% of base) : 34746.dasm - System.Management.Automation.Interpreter.HybridReferenceDictionary`2[System.__Canon,System.__Canon]:set_Item(System.__Canon,System.__Canon):this (FullOpts)
          -6 (-4.00% of base) : 19460.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[System.__Canon]:Any(int):ubyte:this (FullOpts)
          -4 (-3.54% of base) : 23391.dasm - System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]:GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon],int):System.__Canon (FullOpts)
          -7 (-3.40% of base) : 33551.dasm - System.Collections.Specialized.OrderedDictionary:IndexOfKey(System.Object):int:this (FullOpts)
         -15 (-3.37% of base) : 30930.dasm - System.Number:NegativeInt32ToDecStr(int,int,System.String):System.String (FullOpts)
         -42 (-3.26% of base) : 21519.dasm - System.Text.RegularExpressions.RegexParser:AssignNameSlots():this (FullOpts)
         -13 (-3.19% of base) : 21746.dasm - Microsoft.CodeAnalysis.BindingDiagnosticBag`1[System.__Canon]:AddDependencies(System.Collections.Immutable.ImmutableHashSet`1[System.__Canon]):this (FullOpts)
          -3 (-3.16% of base) : 20524.dasm - System.Numerics.BigIntegerCalculator:Divide(System.ReadOnlySpan`1[uint],uint,System.Span`1[uint],byref) (FullOpts)
          -2 (-3.12% of base) : 2255.dasm - System.Threading.PortableThreadPool+WorkerThread:TakeActiveRequest(System.Threading.PortableThreadPool):ubyte (FullOpts)
        -161 (-3.11% of base) : 15663.dasm - SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:ProcessBorderColumn(SixLabors.ImageSharp.Memory.Buffer2D`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.Processing.Processors.Normalization.AdaptiveHistogramEqualizationProcessor`1+CdfTileData[SixLabors.ImageSharp.PixelFormats.Rgba32],int,int,int,int,int,int,int) (FullOpts)

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

Total bytes of base: 5114317 (overridden on cmd)
Total bytes of diff: 5117376 (overridden on cmd)
Total bytes of delta: 3059 (0.06 % of base)
    diff is a regression.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         246 : 11561.dasm (2.93% of base)
          64 : 10181.dasm (4.57% of base)
          64 : 4729.dasm (4.57% of base)
          62 : 20058.dasm (6.19% of base)
          56 : 22717.dasm (10.33% of base)
          53 : 29549.dasm (5.60% of base)
          49 : 29564.dasm (6.31% of base)
          49 : 29543.dasm (6.52% of base)
          48 : 4334.dasm (6.11% of base)
          40 : 9863.dasm (6.10% of base)
          36 : 26718.dasm (14.06% of base)
          34 : 2212.dasm (5.30% of base)
          34 : 6901.dasm (5.30% of base)
          31 : 9709.dasm (2.52% of base)
          31 : 4067.dasm (2.38% of base)
          28 : 11326.dasm (6.47% of base)
          26 : 14393.dasm (7.47% of base)
          26 : 9041.dasm (7.47% of base)
          25 : 10713.dasm (2.42% of base)
          25 : 5240.dasm (2.40% of base)

Top file improvements (bytes):
        -127 : 20051.dasm (-8.96% of base)
         -32 : 17371.dasm (-3.04% of base)
         -31 : 7523.dasm (-2.75% of base)
         -29 : 13387.dasm (-6.11% of base)
         -29 : 8101.dasm (-6.11% of base)
         -22 : 13162.dasm (-4.32% of base)
         -19 : 7676.dasm (-3.61% of base)
         -17 : 20152.dasm (-3.19% of base)
         -17 : 2356.dasm (-3.19% of base)
         -17 : 17522.dasm (-3.19% of base)
         -17 : 22836.dasm (-3.19% of base)
         -15 : 7777.dasm (-3.66% of base)
         -13 : 11015.dasm (-3.05% of base)
         -12 : 16202.dasm (-2.47% of base)
         -12 : 18958.dasm (-1.87% of base)
         -12 : 13256.dasm (-2.93% of base)
         -12 : 22704.dasm (-4.15% of base)
         -12 : 2201.dasm (-4.11% of base)
         -12 : 17358.dasm (-3.37% of base)
         -12 : 21542.dasm (-3.23% of base)

84 total files with Code Size differences (33 improved, 51 regressed), 20 unchanged.

Top method regressions (bytes):
         246 ( 2.93% of base) : 11561.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
          64 ( 4.57% of base) : 10181.dasm - Internal.Runtime.TypeLoader.TypeLoaderEnvironment:TryGetFieldAccessMetadataFromFieldAccessMap(System.RuntimeTypeHandle,Internal.Metadata.NativeFormat.FieldHandle,int,byref):ubyte (FullOpts)
          64 ( 4.57% of base) : 4729.dasm - Internal.Runtime.TypeLoader.TypeLoaderEnvironment:TryGetFieldAccessMetadataFromFieldAccessMap(System.RuntimeTypeHandle,Internal.Metadata.NativeFormat.FieldHandle,int,byref):ubyte (FullOpts)
          62 ( 6.19% of base) : 20058.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
          56 (10.33% of base) : 22717.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
          53 ( 5.60% of base) : 29549.dasm - System.SpanHelpers:NonPackedIndexOfAnyValueType[ubyte,System.SpanHelpers+DontNegate`1[ubyte]](byref,ubyte,ubyte,ubyte,int):int (FullOpts)
          49 ( 6.52% of base) : 29543.dasm - System.SpanHelpers:LastIndexOfAnyValueType[ubyte,System.SpanHelpers+DontNegate`1[ubyte]](byref,ubyte,ubyte,int):int (FullOpts)
          49 ( 6.31% of base) : 29564.dasm - System.SpanHelpers:NonPackedIndexOfAnyValueType[ubyte,System.SpanHelpers+DontNegate`1[ubyte]](byref,ubyte,ubyte,int):int (FullOpts)
          48 ( 6.11% of base) : 4334.dasm - System.Reflection.Runtime.BindingFlagSupport.QueriedMemberList`1[System.__Canon]:Create(System.Reflection.Runtime.BindingFlagSupport.MemberPolicies`1[System.__Canon],System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo,System.String,ubyte):System.Reflection.Runtime.BindingFlagSupport.QueriedMemberList`1[System.__Canon] (FullOpts)
          40 ( 6.10% of base) : 9863.dasm - System.Reflection.Runtime.BindingFlagSupport.QueriedMemberList`1[System.__Canon]:Create(System.Reflection.Runtime.BindingFlagSupport.MemberPolicies`1[System.__Canon],System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo,System.String,ubyte):System.Reflection.Runtime.BindingFlagSupport.QueriedMemberList`1[System.__Canon] (FullOpts)
          36 (14.06% of base) : 26718.dasm - System.SpanHelpers:NonPackedIndexOfAnyInRangeUnsignedNumber[ulong,System.SpanHelpers+DontNegate`1[ulong]](byref,ulong,ulong,int):int (FullOpts)
          34 ( 5.30% of base) : 2212.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
          34 ( 5.30% of base) : 6901.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
          31 ( 2.52% of base) : 9709.dasm - System.Reflection.Runtime.Assemblies.NativeFormat.NativeFormatRuntimeAssembly:UncachedGetTypeCoreCaseSensitive(System.String):System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo:this (FullOpts)
          31 ( 2.38% of base) : 4067.dasm - System.Reflection.Runtime.Assemblies.NativeFormat.NativeFormatRuntimeAssembly:UncachedGetTypeCoreCaseSensitive(System.String):System.Reflection.Runtime.TypeInfos.RuntimeTypeInfo:this (FullOpts)
          28 ( 6.47% of base) : 11326.dasm - System.Reflection.Runtime.BindingFlagSupport.Shared:GetImplicitlyOverriddenBaseClassMember[System.__Canon](System.__Canon,System.Reflection.Runtime.BindingFlagSupport.MemberPolicies`1[System.__Canon]):System.__Canon (FullOpts)
          26 ( 7.47% of base) : 9041.dasm - System.Linq.Enumerable+SelectEnumerableIterator`2[System.__Canon,System.__Canon]:ToArray():System.__Canon[]:this (FullOpts)
          26 ( 7.47% of base) : 14393.dasm - System.Linq.Enumerable+SelectIPartitionIterator`2[System.__Canon,System.__Canon]:LazyToArray():System.__Canon[]:this (FullOpts)
          25 ( 2.42% of base) : 10713.dasm - System.Reflection.Runtime.TypeInfos.RuntimeArrayTypeInfo+<get_SyntheticMethods>d__20:MoveNext():ubyte:this (FullOpts)
          25 ( 2.40% of base) : 5240.dasm - System.Reflection.Runtime.TypeInfos.RuntimeArrayTypeInfo+<get_SyntheticMethods>d__20:MoveNext():ubyte:this (FullOpts)

Top method improvements (bytes):
        -127 (-8.96% of base) : 20051.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorizedAvx512(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
         -32 (-3.04% of base) : 17371.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
         -31 (-2.75% of base) : 7523.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         -29 (-6.11% of base) : 13387.dasm - System.IO.PathHelper:GetFullPathName(System.ReadOnlySpan`1[ushort],byref) (FullOpts)
         -29 (-6.11% of base) : 8101.dasm - System.IO.PathHelper:GetFullPathName(System.ReadOnlySpan`1[ushort],byref) (FullOpts)
         -22 (-4.32% of base) : 13162.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:Expand(long[]):this (FullOpts)
         -19 (-3.61% of base) : 7676.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:Expand(long[]):this (FullOpts)
         -17 (-3.19% of base) : 20152.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:Expand(System.__Canon[]):this (FullOpts)
         -17 (-3.19% of base) : 2356.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:Expand(System.__Canon[]):this (FullOpts)
         -17 (-3.19% of base) : 17522.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:Expand(System.__Canon[]):this (FullOpts)
         -17 (-3.19% of base) : 22836.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:Expand(System.__Canon[]):this (FullOpts)
         -15 (-3.66% of base) : 7777.dasm - System.Collections.Generic.Dictionary`2[int,System.__Canon]:FindValue(int):byref:this (FullOpts)
         -13 (-3.05% of base) : 11015.dasm - System.Collections.Generic.Dictionary`2[long,System.__Canon]:FindValue(long):byref:this (FullOpts)
         -12 (-2.93% of base) : 13256.dasm - System.Collections.Generic.Dictionary`2[int,int]:FindValue(int):byref:this (FullOpts)
         -12 (-4.15% of base) : 22704.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
         -12 (-4.11% of base) : 2201.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
         -12 (-3.37% of base) : 17358.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
         -12 (-4.11% of base) : 7068.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
         -12 (-2.47% of base) : 16202.dasm - System.PackedSpanHelpers:IndexOf[System.SpanHelpers+DontNegate`1[short],System.PackedSpanHelpers+NopTransform](byref,short,int):int (FullOpts)
         -12 (-1.87% of base) : 18958.dasm - System.PackedSpanHelpers:IndexOf[System.SpanHelpers+DontNegate`1[short],System.PackedSpanHelpers+NopTransform](byref,short,int):int (FullOpts)

Top method regressions (percentages):
          36 (14.06% of base) : 26718.dasm - System.SpanHelpers:NonPackedIndexOfAnyInRangeUnsignedNumber[ulong,System.SpanHelpers+DontNegate`1[ulong]](byref,ulong,ulong,int):int (FullOpts)
          12 (13.95% of base) : 7753.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
          12 (13.95% of base) : 2392.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
          12 (13.95% of base) : 22875.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
          12 (13.95% of base) : 20197.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
          12 (13.95% of base) : 17528.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[long,System.__Canon]:WaitForSentinelInHashtableToDisappear(System.__Canon[],int):System.__Canon:this (FullOpts)
          56 (10.33% of base) : 22717.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
          10 (10.20% of base) : 14317.dasm - System.Linq.Enumerable+SelectIListIterator`2[System.__Canon,System.__Canon]:GetCount(ubyte):int:this (FullOpts)
           6 ( 9.09% of base) : 13123.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[Internal.TypeSystem.TypeSystemContext+FunctionPointerTypeKey,System.RuntimeTypeHandle]:WaitForSentinelInHashtableToDisappear(long[],int):long (FullOpts)
           6 ( 9.09% of base) : 7566.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[Internal.TypeSystem.TypeSystemContext+FunctionPointerTypeKey,System.RuntimeTypeHandle]:WaitForSentinelInHashtableToDisappear(long[],int):long (FullOpts)
          20 ( 9.05% of base) : 7751.dasm - System.Collections.Generic.ArraySortHelper`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]:InternalBinarySearch(Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData[],int,int,Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData,System.Collections.Generic.IComparer`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]):int (FullOpts)
          20 ( 9.05% of base) : 2386.dasm - System.Collections.Generic.ArraySortHelper`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]:InternalBinarySearch(Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData[],int,int,Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData,System.Collections.Generic.IComparer`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]):int (FullOpts)
          20 ( 9.05% of base) : 20195.dasm - System.Collections.Generic.ArraySortHelper`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]:InternalBinarySearch(Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData[],int,int,Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData,System.Collections.Generic.IComparer`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]):int (FullOpts)
          20 ( 9.05% of base) : 22873.dasm - System.Collections.Generic.ArraySortHelper`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]:InternalBinarySearch(Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData[],int,int,Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData,System.Collections.Generic.IComparer`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]):int (FullOpts)
          20 ( 9.05% of base) : 17526.dasm - System.Collections.Generic.ArraySortHelper`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]:InternalBinarySearch(Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData[],int,int,Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData,System.Collections.Generic.IComparer`1[Internal.StackTraceMetadata.StackTraceMetadata+PerModuleMethodNameResolver+StackTraceData]):int (FullOpts)
           6 ( 8.96% of base) : 13993.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:WaitForSentinelInHashtableToDisappear(long[],int):long (FullOpts)
           6 ( 8.96% of base) : 8247.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:WaitForSentinelInHashtableToDisappear(long[],int):long (FullOpts)
          10 ( 8.85% of base) : 56.dasm - System.Delegate:GetHashCode():int:this (FullOpts)
          10 ( 8.85% of base) : 20614.dasm - System.Delegate:GetHashCode():int:this (FullOpts)
          10 ( 8.85% of base) : 17943.dasm - System.Delegate:GetHashCode():int:this (FullOpts)

Top method improvements (percentages):
        -127 (-8.96% of base) : 20051.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorizedAvx512(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
         -29 (-6.11% of base) : 13387.dasm - System.IO.PathHelper:GetFullPathName(System.ReadOnlySpan`1[ushort],byref) (FullOpts)
         -29 (-6.11% of base) : 8101.dasm - System.IO.PathHelper:GetFullPathName(System.ReadOnlySpan`1[ushort],byref) (FullOpts)
         -22 (-4.32% of base) : 13162.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:Expand(long[]):this (FullOpts)
         -12 (-4.15% of base) : 22704.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
         -12 (-4.11% of base) : 2201.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
         -12 (-4.11% of base) : 7068.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)
          -7 (-4.02% of base) : 1954.dasm - System.Runtime.CompilerServices.ClassConstructorRunner+BlockingRecord:GetCctorThatThreadIsBlockedOn(int):System.Runtime.CompilerServices.ClassConstructorRunner+CctorHandle (FullOpts)
          -7 (-4.02% of base) : 22462.dasm - System.Runtime.CompilerServices.ClassConstructorRunner+BlockingRecord:GetCctorThatThreadIsBlockedOn(int):System.Runtime.CompilerServices.ClassConstructorRunner+CctorHandle (FullOpts)
          -7 (-4.02% of base) : 6244.dasm - System.Runtime.CompilerServices.ClassConstructorRunner+BlockingRecord:GetCctorThatThreadIsBlockedOn(int):System.Runtime.CompilerServices.ClassConstructorRunner+CctorHandle (FullOpts)
          -7 (-4.02% of base) : 17131.dasm - System.Runtime.CompilerServices.ClassConstructorRunner+BlockingRecord:GetCctorThatThreadIsBlockedOn(int):System.Runtime.CompilerServices.ClassConstructorRunner+CctorHandle (FullOpts)
          -7 (-4.02% of base) : 19773.dasm - System.Runtime.CompilerServices.ClassConstructorRunner+BlockingRecord:GetCctorThatThreadIsBlockedOn(int):System.Runtime.CompilerServices.ClassConstructorRunner+CctorHandle (FullOpts)
         -15 (-3.66% of base) : 7777.dasm - System.Collections.Generic.Dictionary`2[int,System.__Canon]:FindValue(int):byref:this (FullOpts)
         -19 (-3.61% of base) : 7676.dasm - Internal.TypeSystem.LockFreeReaderHashtableOfPointers`2[System.__Canon,System.Runtime.InteropServices.GCHandle]:Expand(long[]):this (FullOpts)
         -10 (-3.45% of base) : 21972.dasm - System.Text.EncoderLatin1BestFitFallbackBuffer:TryBestFit(ushort):ushort (FullOpts)
         -10 (-3.45% of base) : 19265.dasm - System.Text.EncoderLatin1BestFitFallbackBuffer:TryBestFit(ushort):ushort (FullOpts)
         -10 (-3.45% of base) : 4995.dasm - System.Text.EncoderLatin1BestFitFallbackBuffer:TryBestFit(ushort):ushort (FullOpts)
         -10 (-3.45% of base) : 1422.dasm - System.Text.EncoderLatin1BestFitFallbackBuffer:TryBestFit(ushort):ushort (FullOpts)
         -10 (-3.45% of base) : 16635.dasm - System.Text.EncoderLatin1BestFitFallbackBuffer:TryBestFit(ushort):ushort (FullOpts)
         -12 (-3.37% of base) : 17358.dasm - System.PackedSpanHelpers:Contains(byref,short,int):ubyte (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
