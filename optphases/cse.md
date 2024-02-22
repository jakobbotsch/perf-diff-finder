Diffs are based on <span style="color:#1460aa">2,450,424</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,495,130</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">6,611 (0.27%)</span>, diff: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitNoCSE=1


<details>
<summary>Overall (<span style="color:green">-14,806,738</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,770,463|<span style="color:green">-353,531</span>|<span style="color:green">-6.66%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,516,880|<span style="color:green">-59,867</span>|<span style="color:green">-7.91%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,778,740|<span style="color:green">-67,497</span>|<span style="color:green">-4.19%</span>|
|coreclr_tests.run.windows.x64.checked.mch|394,219,384|<span style="color:green">-7,519,604</span>|<span style="color:green">-5.33%</span>|
|libraries.crossgen2.windows.x64.checked.mch|46,071,735|<span style="color:green">-977,542</span>|<span style="color:green">-8.91%</span>|
|libraries.pmi.windows.x64.checked.mch|63,379,915|<span style="color:green">-1,956,816</span>|<span style="color:green">-7.57%</span>|
|libraries_tests.run.windows.x64.Release.mch|285,382,240|<span style="color:green">-386,196</span>|<span style="color:green">-5.89%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|139,565,419|<span style="color:green">-3,198,169</span>|<span style="color:green">-3.36%</span>|
|realworld.run.windows.x64.checked.mch|14,186,268|<span style="color:green">-208,611</span>|<span style="color:green">-6.23%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,191,733|<span style="color:green">-78,905</span>|<span style="color:green">-10.32%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-14,806,738</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,770,103|<span style="color:green">-353,531</span>|<span style="color:green">-6.66%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,614,256|<span style="color:green">-59,867</span>|<span style="color:green">-7.91%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,545,957|<span style="color:green">-67,497</span>|<span style="color:green">-4.19%</span>|
|coreclr_tests.run.windows.x64.checked.mch|113,776,235|<span style="color:green">-7,519,604</span>|<span style="color:green">-5.33%</span>|
|libraries.crossgen2.windows.x64.checked.mch|46,070,548|<span style="color:green">-977,542</span>|<span style="color:green">-8.91%</span>|
|libraries.pmi.windows.x64.checked.mch|63,266,421|<span style="color:green">-1,956,816</span>|<span style="color:green">-7.57%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,735,221|<span style="color:green">-386,196</span>|<span style="color:green">-5.89%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|129,272,540|<span style="color:green">-3,198,169</span>|<span style="color:green">-3.36%</span>|
|realworld.run.windows.x64.checked.mch|13,800,100|<span style="color:green">-208,611</span>|<span style="color:green">-6.23%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,190,786|<span style="color:green">-78,905</span>|<span style="color:green">-10.32%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-14</span> (<span style="color:green">-43.75%</span>) : 1477.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,11 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  4   )  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  5,  4   )  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  4,  3   )     int  ->  rax         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,30 +20,25 @@ G_M1277_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M1277_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
+       movzx    rcx, dx
+       cmp      eax, ecx
        je       SHORT G_M1277_IG04
-						;; size=12 bbWeight=1 PerfScore 1.75
+						;; size=10 bbWeight=1 PerfScore 1.75
 G_M1277_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
+       cmp      eax, ecx
        jl       SHORT G_M1277_IG06
-						;; size=12 bbWeight=0.50 PerfScore 0.88
+						;; size=4 bbWeight=0.50 PerfScore 0.62
 G_M1277_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       movzx    rax, dx
-						;; size=3 bbWeight=0.50 PerfScore 0.12
+       mov      eax, ecx
+						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M1277_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M1277_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       movzx    rax, cx
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M1277_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M1277_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 32, prolog size 0, PerfScore 3.88, instruction count 12, allocated bytes for code 32 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 3.50, instruction count 9, allocated bytes for code 18 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-14</span> (<span style="color:green">-43.75%</span>) : 13938.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,11 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  4   )  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  5,  4   )  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  4,  3   )     int  ->  rax         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,30 +20,25 @@ G_M1277_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M1277_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
+       movzx    rcx, dx
+       cmp      eax, ecx
        je       SHORT G_M1277_IG04
-						;; size=12 bbWeight=1 PerfScore 1.75
+						;; size=10 bbWeight=1 PerfScore 1.75
 G_M1277_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
+       cmp      eax, ecx
        jl       SHORT G_M1277_IG06
-						;; size=12 bbWeight=0.50 PerfScore 0.88
+						;; size=4 bbWeight=0.50 PerfScore 0.62
 G_M1277_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       movzx    rax, dx
-						;; size=3 bbWeight=0.50 PerfScore 0.12
+       mov      eax, ecx
+						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M1277_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M1277_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       movzx    rax, cx
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M1277_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M1277_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 32, prolog size 0, PerfScore 3.88, instruction count 12, allocated bytes for code 32 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 3.50, instruction count 9, allocated bytes for code 18 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-43</span> (<span style="color:green">-42.16%</span>) : 21827.dasm - PerfLabTests.Class:GenericMethod[int]():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,51 +8,39 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 tmp1         [V01,T00] (  3,  6   )     int  ->  rbx         "dup spill"
+;  V01 tmp1         [V01,T00] (  3,  6   )     int  ->  rcx         "dup spill"
+;* V02 cse0         [V02,T02] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
+;  V03 cse1         [V03,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M31000_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M31000_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     byte  ptr [(reloc)], 1      ; global ptr
-       je       SHORT G_M31000_IG06
+       je       SHORT G_M31000_IG05
 						;; size=9 bbWeight=1 PerfScore 4.00
-G_M31000_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M31000_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      ebx, dword ptr [rax]
-       test     byte  ptr [(reloc)], 1      ; global ptr
-       je       SHORT G_M31000_IG07
-						;; size=21 bbWeight=1 PerfScore 6.25
-G_M31000_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       lea      eax, [rbx+0x01]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      dword ptr [rcx], eax
-       mov      eax, ebx
-						;; size=17 bbWeight=1 PerfScore 2.00
-G_M31000_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       mov      ecx, dword ptr [rax]
+       lea      edx, [rcx+0x01]
+       mov      dword ptr [rax], edx
+       mov      eax, ecx
+						;; size=19 bbWeight=1 PerfScore 4.00
+G_M31000_IG04:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-G_M31000_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M31000_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        mov      rcx, 0xD1FFAB1E
        mov      edx, 148
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        ; gcr arg pop 0
        jmp      SHORT G_M31000_IG03
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M31000_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E
-       mov      edx, 148
-       call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       ; gcr arg pop 0
-       jmp      SHORT G_M31000_IG04
-						;; size=22 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 102, prolog size 5, PerfScore 15.25, instruction count 23, allocated bytes for code 102 (MethodHash=cb0c86e7) for method PerfLabTests.Class:GenericMethod[int]():int (FullOpts)
+; Total bytes of code 59, prolog size 4, PerfScore 9.50, instruction count 14, allocated bytes for code 59 (MethodHash=cb0c86e7) for method PerfLabTests.Class:GenericMethod[int]():int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -60,10 +48,9 @@ Unwind Info:
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
<summary><span style="color:red">+28</span> (<span style="color:red">+46.67%</span>) : 35433.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,47 +8,57 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4, 11   )     ref  ->  rbx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
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
 
 G_M31728_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
-G_M31728_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       cmp      byte  ptr [rbx], bl
-						;; size=2 bbWeight=1 PerfScore 3.00
-G_M31728_IG03:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
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
+       vucomiss xmm7, xmm0
        jbe      SHORT G_M31728_IG03
-						;; size=44 bbWeight=8 PerfScore 198.67
+						;; size=31 bbWeight=8 PerfScore 156.67
 G_M31728_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       add      rsp, 32
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
 
 
-; Total bytes of code 60, prolog size 5, PerfScore 204.92, instruction count 16, allocated bytes for code 60 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
+; Total bytes of code 88, prolog size 17, PerfScore 181.17, instruction count 21, allocated bytes for code 88 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -56,10 +66,14 @@ Unwind Info:
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

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+47.62%</span>) : 29379.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYWithCenterBenchmark():System.Numerics.Matrix3x2:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,12 +12,12 @@
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Numerics.Matrix3x2+Impl>
-;* V04 tmp2         [V04,T04] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
-;* V05 tmp3         [V05,T05] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V04 tmp2         [V04,T05] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V05 tmp3         [V05,T06] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
 ;* V06 tmp4         [V06    ] (  0,  0   )   simd8  ->  zero-ref    "location for address-of(RValue)"
-;* V07 tmp5         [V07,T06] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V07 tmp5         [V07,T07] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
 ;* V08 tmp6         [V08    ] (  0,  0   )   simd8  ->  zero-ref    "location for address-of(RValue)"
-;* V09 tmp7         [V09,T07] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
+;* V09 tmp7         [V09,T08] (  0,  0   )   float  ->  zero-ref    "Inline stloc first use temp"
 ;* V10 tmp8         [V10    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Matrix3x2+Impl>
 ;* V11 tmp9         [V11    ] (  0,  0   )   simd8  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector2>
 ;* V12 tmp10        [V12    ] (  0,  0   )   simd8  ->  zero-ref    ld-addr-op "NewObj constructor temp" <System.Numerics.Vector2>
@@ -25,9 +25,10 @@
 ;* V14 tmp12        [V14    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.X (fldOffset=0x0)" P-INDEP
 ;* V15 tmp13        [V15    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.Y (fldOffset=0x8)" P-INDEP
 ;* V16 tmp14        [V16    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.Z (fldOffset=0x10)" P-INDEP
-;  V17 tmp15        [V17,T01] (  2,  2   )   simd8  ->  mm0         "field V10.X (fldOffset=0x0)" P-INDEP
-;  V18 tmp16        [V18,T02] (  2,  2   )   simd8  ->  mm1         "field V10.Y (fldOffset=0x8)" P-INDEP
-;  V19 tmp17        [V19,T03] (  2,  2   )   simd8  ->  mm2         "field V10.Z (fldOffset=0x10)" P-INDEP
+;  V17 tmp15        [V17,T02] (  2,  2   )   simd8  ->  mm1         "field V10.X (fldOffset=0x0)" P-INDEP
+;  V18 tmp16        [V18,T03] (  2,  2   )   simd8  ->  mm0         "field V10.Y (fldOffset=0x8)" P-INDEP
+;  V19 tmp17        [V19,T04] (  2,  2   )   simd8  ->  mm2         "field V10.Z (fldOffset=0x10)" P-INDEP
+;  V20 cse0         [V20,T01] (  3,  3   )   float  ->  mm0         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -35,24 +36,29 @@ G_M10363_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M10363_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovsd   xmm0, qword ptr [reloc @RWD00]
-       vmovsd   xmm1, qword ptr [reloc @RWD08]
-       vmovsd   xmm2, qword ptr [reloc @RWD16]
-       vmovsd   qword ptr [rdx], xmm0
-       vmovsd   qword ptr [rdx+0x08], xmm1
+       vmovss   xmm0, dword ptr [reloc @RWD00]
+       vmovaps  xmm1, xmm0
+       vinsertps xmm1, xmm1, dword ptr [reloc @RWD16], 28
+       vmovups  xmm2, xmmword ptr [reloc @RWD32]
+       vinsertps xmm0, xmm2, xmm0, 28
+       vmovsd   xmm2, qword ptr [reloc @RWD48]
+       vmovsd   qword ptr [rdx], xmm1
+       vmovsd   qword ptr [rdx+0x08], xmm0
        vmovsd   qword ptr [rdx+0x10], xmm2
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=41 bbWeight=1 PerfScore 15.25
+						;; size=61 bbWeight=1 PerfScore 18.50
 G_M10363_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-RWD00  	dq	C00BD7B13F800000h
-RWD08  	dq	3F8000003FC75923h
-RWD16  	dq	0000000080000000h
+RWD00  	dd	3F800000h		;         1
+RWD04  	dd	00000000h, 00000000h, 00000000h
+RWD16  	dq	C00BD7B1C00BD7B1h, C00BD7B1C00BD7B1h
+RWD32  	dq	3FC759233FC75923h, 3FC759233FC75923h
+RWD48  	dq	0000000080000000h
 
 
-; Total bytes of code 42, prolog size 0, PerfScore 16.25, instruction count 8, allocated bytes for code 42 (MethodHash=4706d784) for method System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYWithCenterBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
+; Total bytes of code 62, prolog size 0, PerfScore 19.50, instruction count 11, allocated bytes for code 62 (MethodHash=4706d784) for method System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYWithCenterBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+20</span> (<span style="color:red">+52.63%</span>) : 29288.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYBenchmark():System.Numerics.Matrix3x2:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -18,9 +18,10 @@
 ;* V07 tmp5         [V07    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.X (fldOffset=0x0)" P-INDEP
 ;* V08 tmp6         [V08    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.Y (fldOffset=0x8)" P-INDEP
 ;* V09 tmp7         [V09    ] (  0,  0   )   simd8  ->  zero-ref    "field V03.Z (fldOffset=0x10)" P-INDEP
-;  V10 tmp8         [V10,T01] (  2,  2   )   simd8  ->  mm0         "field V04.X (fldOffset=0x0)" P-INDEP
-;  V11 tmp9         [V11,T02] (  2,  2   )   simd8  ->  mm1         "field V04.Y (fldOffset=0x8)" P-INDEP
-;* V12 tmp10        [V12,T03] (  0,  0   )   simd8  ->  zero-ref    "field V04.Z (fldOffset=0x10)" P-INDEP
+;  V10 tmp8         [V10,T02] (  2,  2   )   simd8  ->  mm1         "field V04.X (fldOffset=0x0)" P-INDEP
+;  V11 tmp9         [V11,T03] (  2,  2   )   simd8  ->  mm0         "field V04.Y (fldOffset=0x8)" P-INDEP
+;* V12 tmp10        [V12,T04] (  0,  0   )   simd8  ->  zero-ref    "field V04.Z (fldOffset=0x10)" P-INDEP
+;  V13 cse0         [V13,T01] (  3,  3   )   float  ->  mm0         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -28,23 +29,28 @@ G_M2130_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M2130_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref
        ; byrRegs +[rdx]
-       vmovsd   xmm0, qword ptr [reloc @RWD00]
-       vmovsd   xmm1, qword ptr [reloc @RWD08]
-       vmovsd   qword ptr [rdx], xmm0
-       vmovsd   qword ptr [rdx+0x08], xmm1
+       vmovss   xmm0, dword ptr [reloc @RWD00]
+       vmovaps  xmm1, xmm0
+       vinsertps xmm1, xmm1, dword ptr [reloc @RWD16], 28
+       vmovups  xmm2, xmmword ptr [reloc @RWD32]
+       vinsertps xmm0, xmm2, xmm0, 28
+       vmovsd   qword ptr [rdx], xmm1
+       vmovsd   qword ptr [rdx+0x08], xmm0
        vxorps   xmm0, xmm0, xmm0
        vmovsd   qword ptr [rdx+0x10], xmm0
        mov      rax, rdx
        ; byrRegs +[rax]
-						;; size=37 bbWeight=1 PerfScore 12.58
+						;; size=57 bbWeight=1 PerfScore 15.83
 G_M2130_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-RWD00  	dq	C00BD7B13F800000h
-RWD08  	dq	3F8000003FC75923h
+RWD00  	dd	3F800000h		;         1
+RWD04  	dd	00000000h, 00000000h, 00000000h
+RWD16  	dq	C00BD7B1C00BD7B1h, C00BD7B1C00BD7B1h
+RWD32  	dq	3FC759233FC75923h, 3FC759233FC75923h
 
 
-; Total bytes of code 38, prolog size 0, PerfScore 13.58, instruction count 8, allocated bytes for code 38 (MethodHash=0440f7ad) for method System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
+; Total bytes of code 58, prolog size 0, PerfScore 16.83, instruction count 11, allocated bytes for code 58 (MethodHash=0440f7ad) for method System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-44.00%</span>) : 22731.dasm - System.Math:Max(short,short):short (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,11 @@
 ; with Dynamic PGO: edge weights are valid, and fgCalledCount is 2
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )   short  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )   short  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )   short  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )   short  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,18 +20,15 @@ G_M25962_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M25962_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsx    rax, cx
-       movsx    r8, dx
-       movsx    rcx, cx
-       movsx    rdx, dx
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovge   eax, ecx
-						;; size=24 bbWeight=1 PerfScore 1.75
+       movsx    rcx, dx
+       cmp      eax, ecx
+       cmovl    eax, ecx
+						;; size=13 bbWeight=1 PerfScore 1.00
 G_M25962_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 25, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 25 (MethodHash=439a9a95) for method System.Math:Max(short,short):short (Tier1)
+; Total bytes of code 14, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 14 (MethodHash=439a9a95) for method System.Math:Max(short,short):short (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-44.00%</span>) : 50169.dasm - System.Math:Min(short,short):short (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,11 @@
 ; with Dynamic PGO: edge weights are valid, and fgCalledCount is 2
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )   short  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )   short  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )   short  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )   short  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,18 +20,15 @@ G_M25012_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M25012_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsx    rax, cx
-       movsx    r8, dx
-       movsx    rcx, cx
-       movsx    rdx, dx
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovle   eax, ecx
-						;; size=24 bbWeight=1 PerfScore 1.75
+       movsx    rcx, dx
+       cmp      eax, ecx
+       cmovg    eax, ecx
+						;; size=13 bbWeight=1 PerfScore 1.00
 G_M25012_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 25, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 25 (MethodHash=00c99e4b) for method System.Math:Min(short,short):short (Tier1)
+; Total bytes of code 14, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 14 (MethodHash=00c99e4b) for method System.Math:Min(short,short):short (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-11</span> (<span style="color:green">-44.00%</span>) : 26204.dasm - System.Math:Min(short,short):short (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,11 @@
 ; with Dynamic PGO: edge weights are valid, and fgCalledCount is 6
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )   short  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )   short  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )   short  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )   short  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,18 +20,15 @@ G_M25012_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M25012_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsx    rax, cx
-       movsx    r8, dx
-       movsx    rcx, cx
-       movsx    rdx, dx
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovle   eax, ecx
-						;; size=24 bbWeight=1 PerfScore 1.75
+       movsx    rcx, dx
+       cmp      eax, ecx
+       cmovg    eax, ecx
+						;; size=13 bbWeight=1 PerfScore 1.00
 G_M25012_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 25, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 25 (MethodHash=00c99e4b) for method System.Math:Min(short,short):short (Tier1)
+; Total bytes of code 14, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 14 (MethodHash=00c99e4b) for method System.Math:Min(short,short):short (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+49.21%</span>) : 91604.dasm - PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -12,37 +12,51 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <PerfLabTests.CastingPerf>
 ;  V01 loc0         [V01,T00] (  4,299.98)     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,100.01)     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,100.00)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,100.00)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M23200_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x44]
-						;; size=10 bbWeight=0.01 PerfScore 0.04
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=0.01 PerfScore 0.05
 G_M23200_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ebx, dword ptr [(reloc)]
-       jge      SHORT G_M23200_IG04
-						;; size=8 bbWeight=0.01 PerfScore 0.04
-G_M23200_IG03:        ; bbWeight=99.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+       mov      esi, dword ptr [(reloc)]
+       cmp      ebx, esi
+       jge      SHORT G_M23200_IG05
+						;; size=10 bbWeight=0.01 PerfScore 0.03
+G_M23200_IG03:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       mov      rdi, gword ptr [rcx]
+       ; gcrRegs +[rdi]
+       mov      rbp, 0xD1FFAB1E      ; static handle
+						;; size=23 bbWeight=0.01 PerfScore 0.03
+G_M23200_IG04:        ; bbWeight=99.99, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, rbp
+       mov      rdx, rdi
        ; gcrRegs +[rdx]
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        inc      ebx
-       cmp      ebx, dword ptr [(reloc)]      ; static handle
-       jl       SHORT G_M23200_IG03
-						;; size=38 bbWeight=99.99 PerfScore 774.92
-G_M23200_IG04:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       cmp      ebx, esi
+       jl       SHORT G_M23200_IG04
+						;; size=17 bbWeight=99.99 PerfScore 299.97
+G_M23200_IG05:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=0.01 PerfScore 0.02
+						;; size=12 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 63, prolog size 10, PerfScore 775.03, instruction count 16, allocated bytes for code 63 (MethodHash=dc5aa55f) for method PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 300.11, instruction count 23, allocated bytes for code 94 (MethodHash=dc5aa55f) for method PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -50,13 +64,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 16 * 8 = 128 = 0x00080
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
<summary><span style="color:red">+31</span> (<span style="color:red">+49.21%</span>) : 36153.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -13,37 +13,51 @@
 ;  V01 loc0         [V01,T00] (  4,299.98)     int  ->  rbx        
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 cse0         [V04,T01] (  3,100.01)     int  ->  rsi         "CSE - aggressive"
+;  V05 cse1         [V05,T02] (  2,100.00)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T03] (  2,100.00)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M22144_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x44]
-						;; size=10 bbWeight=0.01 PerfScore 0.04
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=0.01 PerfScore 0.05
 G_M22144_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ebx, dword ptr [(reloc)]
-       jge      SHORT G_M22144_IG04
-						;; size=8 bbWeight=0.01 PerfScore 0.04
-G_M22144_IG03:        ; bbWeight=99.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+       mov      esi, dword ptr [(reloc)]
+       cmp      ebx, esi
+       jge      SHORT G_M22144_IG05
+						;; size=10 bbWeight=0.01 PerfScore 0.03
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
-       cmp      ebx, dword ptr [(reloc)]      ; static handle
-       jl       SHORT G_M22144_IG03
-						;; size=38 bbWeight=99.99 PerfScore 774.92
-G_M22144_IG04:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       cmp      ebx, esi
+       jl       SHORT G_M22144_IG04
+						;; size=17 bbWeight=99.99 PerfScore 299.97
+G_M22144_IG05:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=0.01 PerfScore 0.02
+						;; size=12 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 63, prolog size 10, PerfScore 775.02, instruction count 16, allocated bytes for code 63 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 300.11, instruction count 23, allocated bytes for code 94 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -51,13 +65,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 16 * 8 = 128 = 0x00080
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
<summary><span style="color:red">+31</span> (<span style="color:red">+49.21%</span>) : 29951.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -12,37 +12,51 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <PerfLabTests.CastingPerf>
 ;  V01 loc0         [V01,T00] (  4,299.98)     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,100.01)     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,100.00)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,100.00)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M51548_IG01:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x44]
-						;; size=10 bbWeight=0.01 PerfScore 0.04
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=0.01 PerfScore 0.05
 G_M51548_IG02:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ebx, dword ptr [(reloc)]
-       jge      SHORT G_M51548_IG04
-						;; size=8 bbWeight=0.01 PerfScore 0.04
-G_M51548_IG03:        ; bbWeight=99.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+       mov      esi, dword ptr [(reloc)]
+       cmp      ebx, esi
+       jge      SHORT G_M51548_IG05
+						;; size=10 bbWeight=0.01 PerfScore 0.03
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
-       cmp      ebx, dword ptr [(reloc)]      ; static handle
-       jl       SHORT G_M51548_IG03
-						;; size=38 bbWeight=99.99 PerfScore 774.92
-G_M51548_IG04:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       cmp      ebx, esi
+       jl       SHORT G_M51548_IG04
+						;; size=17 bbWeight=99.99 PerfScore 299.97
+G_M51548_IG05:        ; bbWeight=0.01, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=0.01 PerfScore 0.02
+						;; size=12 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 63, prolog size 10, PerfScore 775.02, instruction count 16, allocated bytes for code 63 (MethodHash=fbb236a3) for method PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 300.11, instruction count 23, allocated bytes for code 94 (MethodHash=fbb236a3) for method PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -50,13 +64,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 16 * 8 = 128 = 0x00080
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
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-45.45%</span>) : 22886.dasm - System.Math:Min(ushort,ushort):ushort (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,18 +19,15 @@ G_M37345_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M37345_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, cx
-       movzx    r8, dx
-       movzx    rcx, cx
-       movzx    rdx, dx
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovle   eax, ecx
-						;; size=21 bbWeight=1 PerfScore 1.75
+       movzx    rcx, dx
+       cmp      eax, ecx
+       cmovg    eax, ecx
+						;; size=11 bbWeight=1 PerfScore 1.00
 G_M37345_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 22 (MethodHash=737b6e1e) for method System.Math:Min(ushort,ushort):ushort (Tier1)
+; Total bytes of code 12, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 12 (MethodHash=737b6e1e) for method System.Math:Min(ushort,ushort):ushort (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-45.45%</span>) : 17587.dasm - System.Math:Max(ubyte,ubyte):ubyte (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )   ubyte  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )   ubyte  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )   ubyte  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,18 +19,15 @@ G_M34407_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M34407_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, cl
-       movzx    r8, dl
-       movzx    rcx, cl
-       movzx    rdx, dl
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovge   eax, ecx
-						;; size=21 bbWeight=1 PerfScore 1.75
+       movzx    rcx, dl
+       cmp      eax, ecx
+       cmovl    eax, ecx
+						;; size=11 bbWeight=1 PerfScore 1.00
 G_M34407_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 22 (MethodHash=b0577998) for method System.Math:Max(ubyte,ubyte):ubyte (Tier1)
+; Total bytes of code 12, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 12 (MethodHash=b0577998) for method System.Math:Max(ubyte,ubyte):ubyte (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-45.45%</span>) : 48855.dasm - System.Math:Max(ushort,ushort):ushort (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,18 +19,15 @@ G_M8447_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M8447_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, cx
-       movzx    r8, dx
-       movzx    rcx, cx
-       movzx    rdx, dx
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovge   eax, ecx
-						;; size=21 bbWeight=1 PerfScore 1.75
+       movzx    rcx, dx
+       cmp      eax, ecx
+       cmovl    eax, ecx
+						;; size=11 bbWeight=1 PerfScore 1.00
 G_M8447_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 22 (MethodHash=d470df00) for method System.Math:Max(ushort,ushort):ushort (Tier1)
+; Total bytes of code 12, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 12 (MethodHash=d470df00) for method System.Math:Max(ushort,ushort):ushort (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+49.21%</span>) : 29494.dasm - PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -11,37 +11,51 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <PerfLabTests.CastingPerf>
 ;  V01 loc0         [V01,T00] (  4, 13   )     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M38760_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x44]
-						;; size=10 bbWeight=1 PerfScore 4.00
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=1 PerfScore 5.25
 G_M38760_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ebx, dword ptr [(reloc)]
-       jge      SHORT G_M38760_IG04
-						;; size=8 bbWeight=1 PerfScore 4.00
-G_M38760_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+       mov      esi, dword ptr [(reloc)]
+       cmp      ebx, esi
+       jge      SHORT G_M38760_IG05
+						;; size=10 bbWeight=1 PerfScore 3.25
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
-       cmp      ebx, dword ptr [(reloc)]      ; static handle
-       jl       SHORT G_M38760_IG03
-						;; size=38 bbWeight=4 PerfScore 31.00
-G_M38760_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       cmp      ebx, esi
+       jl       SHORT G_M38760_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M38760_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=12 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 63, prolog size 10, PerfScore 41.25, instruction count 16, allocated bytes for code 63 (MethodHash=352a6897) for method PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 25.00, instruction count 23, allocated bytes for code 94 (MethodHash=352a6897) for method PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -49,13 +63,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 16 * 8 = 128 = 0x00080
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
<summary><span style="color:red">+31</span> (<span style="color:red">+49.21%</span>) : 31574.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -11,37 +11,51 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <PerfLabTests.CastingPerf>
 ;  V01 loc0         [V01,T00] (  4, 13   )     int  ->  rbx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V04 cse1         [V04,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V05 cse2         [V05,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M51398_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x44]
-						;; size=10 bbWeight=1 PerfScore 4.00
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=1 PerfScore 5.25
 G_M51398_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ebx, dword ptr [(reloc)]
-       jge      SHORT G_M51398_IG04
-						;; size=8 bbWeight=1 PerfScore 4.00
-G_M51398_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+       mov      esi, dword ptr [(reloc)]
+       cmp      ebx, esi
+       jge      SHORT G_M51398_IG05
+						;; size=10 bbWeight=1 PerfScore 3.25
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
-       cmp      ebx, dword ptr [(reloc)]      ; static handle
-       jl       SHORT G_M51398_IG03
-						;; size=38 bbWeight=4 PerfScore 31.00
-G_M51398_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       cmp      ebx, esi
+       jl       SHORT G_M51398_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M51398_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=12 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 63, prolog size 10, PerfScore 41.25, instruction count 16, allocated bytes for code 63 (MethodHash=4b353739) for method PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 25.00, instruction count 23, allocated bytes for code 94 (MethodHash=4b353739) for method PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -49,13 +63,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 16 * 8 = 128 = 0x00080
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
<summary><span style="color:red">+31</span> (<span style="color:red">+49.21%</span>) : 25372.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -12,37 +12,51 @@
 ;  V01 loc0         [V01,T00] (  4, 13   )     int  ->  rbx        
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 cse0         [V04,T01] (  3,  6   )     int  ->  rsi         "CSE - aggressive"
+;  V05 cse1         [V05,T02] (  2,  4.50)     ref  ->  rdi         hoist "CSE - aggressive"
+;  V06 cse2         [V06,T03] (  2,  4.50)    long  ->  rbp         hoist "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M22144_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-       mov      qword ptr [rsp+0x78], rbx
-       mov      ebx, dword ptr [rsp+0x44]
-						;; size=10 bbWeight=1 PerfScore 4.00
+       sub      rsp, 32
+       mov      qword ptr [rsp+0x90], rdi
+       mov      qword ptr [rsp+0x88], rsi
+       mov      qword ptr [rsp+0x80], rbx
+       mov      ebx, dword ptr [rsp+0x5C]
+						;; size=32 bbWeight=1 PerfScore 5.25
 G_M22144_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ebx, dword ptr [(reloc)]
-       jge      SHORT G_M22144_IG04
-						;; size=8 bbWeight=1 PerfScore 4.00
-G_M22144_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rcx]
+       mov      esi, dword ptr [(reloc)]
+       cmp      ebx, esi
+       jge      SHORT G_M22144_IG05
+						;; size=10 bbWeight=1 PerfScore 3.25
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
-       cmp      ebx, dword ptr [(reloc)]      ; static handle
-       jl       SHORT G_M22144_IG03
-						;; size=38 bbWeight=4 PerfScore 31.00
-G_M22144_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 120
+       cmp      ebx, esi
+       jl       SHORT G_M22144_IG04
+						;; size=17 bbWeight=4 PerfScore 12.00
+G_M22144_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rdi]
+       add      rsp, 128
        pop      rbx
+       pop      rsi
+       pop      rdi
        pop      rbp
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=12 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 63, prolog size 10, PerfScore 41.25, instruction count 16, allocated bytes for code 63 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
+; Total bytes of code 94, prolog size 32, PerfScore 25.00, instruction count 23, allocated bytes for code 94 (MethodHash=a08fa97f) for method PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
 ; ============================================================
 
 Unwind Info:
@@ -50,13 +64,17 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x1C
+  CountOfUnwindCodes: 9
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
-      Scaled Small Offset: 15 * 8 = 120 = 0x00078
-    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08
+    CodeOffset: 0x1C UnwindOp: UWOP_SAVE_NONVOL (4)     OpInfo: rbx (3)
+      Scaled Small Offset: 16 * 8 = 128 = 0x00080
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
<summary><span style="color:green">-15</span> (<span style="color:green">-78.95%</span>) : 234556.dasm - InlineBool.Program:Id31(ubyte):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,8 +7,9 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  6,  6   )   ubyte  ->  rcx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )   ubyte  ->  rcx         single-def
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V02 cse0         [V02,T01] (  2,  2   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -16,18 +17,12 @@ G_M51369_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M51369_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, cl
-       movzx    rdx, cl
-       and      eax, edx
-       movzx    rdx, cl
-       or       eax, edx
-       or       eax, ecx
-       movzx    rax, al
-						;; size=18 bbWeight=1 PerfScore 1.75
+						;; size=3 bbWeight=1 PerfScore 0.25
 G_M51369_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 19, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 19 (MethodHash=e47f3756) for method InlineBool.Program:Id31(ubyte):ubyte (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 4 (MethodHash=e47f3756) for method InlineBool.Program:Id31(ubyte):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-30</span> (<span style="color:green">-68.18%</span>) : 242464.dasm - Runtime_71831:Problem(int):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,34 +7,26 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )     int  ->  rcx         ld-addr-op single-def
-;  V01 loc0         [V01,T01] (  3,  3   )  struct ( 8) [rsp+0x00]  do-not-enreg[SF] ld-addr-op <Runtime_71831+StructWithFloats>
+;  V00 arg0         [V00,T00] (  3,  3   )     int  ->  rcx         ld-addr-op single-def
+;* V01 loc0         [V01,T01] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] ld-addr-op <Runtime_71831+StructWithFloats>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )   float  ->  mm0         "CSE - aggressive"
 ;
-; Lcl frame size = 8
+; Lcl frame size = 0
 
 G_M57123_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rax
-						;; size=1 bbWeight=1 PerfScore 1.00
-G_M57123_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       xor      eax, eax
-       mov      qword ptr [rsp], rax
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M57123_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        vmovd    xmm0, ecx
-       vmovss   dword ptr [rsp], xmm0
-       vmovss   xmm0, dword ptr [rsp]
-       vmovd    xmm1, ecx
        xor      eax, eax
-       vucomiss xmm0, xmm1
+       vucomiss xmm0, xmm0
        setp     al
-       jp       SHORT G_M57123_IG03
-       setne    al
-						;; size=38 bbWeight=1 PerfScore 14.50
-G_M57123_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 8
+						;; size=13 bbWeight=1 PerfScore 5.25
+G_M57123_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 44, prolog size 1, PerfScore 16.75, instruction count 14, allocated bytes for code 44 (MethodHash=192a20dc) for method Runtime_71831:Problem(int):ubyte (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 6.25, instruction count 5, allocated bytes for code 14 (MethodHash=192a20dc) for method Runtime_71831:Problem(int):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -42,9 +34,8 @@ Unwind Info:
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
<summary><span style="color:green">-39</span> (<span style="color:green">-52.00%</span>) : 231404.dasm - Test_10w5d.testout1:Func_0_6_2_5_5():double (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,6 +12,8 @@
 ;* V01 loc1         [V01    ] (  0,  0   )  double  ->  zero-ref   
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  double  ->  zero-ref    "Inlining Arg"
+;  V04 cse0         [V04,T01] (  3,  3   )  double  ->  mm0         "CSE - aggressive"
+;  V05 cse1         [V05,T00] (  3,  3   )     ref  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -22,28 +24,17 @@ G_M40786_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, gword ptr [rax]
        ; gcrRegs +[rax]
        vmovsd   xmm0, qword ptr [rax+0x08]
-       vdivsd   xmm0, xmm0, qword ptr [reloc @RWD00]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       ; gcrRegs -[rax]
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       vmovsd   xmm1, qword ptr [rax+0x08]
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       ; gcrRegs -[rax]
-       mov      rax, gword ptr [rax]
-       ; gcrRegs +[rax]
-       vaddsd   xmm1, xmm1, qword ptr [rax+0x10]
+       vaddsd   xmm1, xmm0, qword ptr [rax+0x10]
        vaddsd   xmm0, xmm0, xmm1
-       vaddsd   xmm0, xmm0, qword ptr [reloc @RWD08]
-						;; size=74 bbWeight=1 PerfScore 42.75
+       vaddsd   xmm0, xmm0, qword ptr [reloc @RWD00]
+						;; size=35 bbWeight=1 PerfScore 20.25
 G_M40786_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-RWD00  	dq	3FF0000000000000h	;            1
-RWD08  	dq	BEDD015E4E88256Bh	; -6.9154132e-06
+RWD00  	dq	BEDD015E4E88256Bh	; -6.9154132e-06
 
 
-; Total bytes of code 75, prolog size 0, PerfScore 43.75, instruction count 13, allocated bytes for code 75 (MethodHash=b39260ad) for method Test_10w5d.testout1:Func_0_6_2_5_5():double (FullOpts)
+; Total bytes of code 36, prolog size 0, PerfScore 21.25, instruction count 7, allocated bytes for code 36 (MethodHash=b39260ad) for method Test_10w5d.testout1:Func_0_6_2_5_5():double (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+111.11%</span>) : 190146.dasm - Repro.Tst:f01():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,8 +8,9 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  6   )     ref  ->  rcx         this class-hnd single-def <Repro.Tst>
+;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Repro.Tst>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V02 cse0         [V02,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,14 +18,17 @@ G_M35453_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M35453_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       inc      qword ptr [rcx+0x08]
-       inc      qword ptr [rcx+0x08]
-						;; size=8 bbWeight=1 PerfScore 6.00
+       mov      rax, qword ptr [rcx+0x08]
+       inc      rax
+       mov      qword ptr [rcx+0x08], rax
+       inc      rax
+       mov      qword ptr [rcx+0x08], rax
+						;; size=18 bbWeight=1 PerfScore 4.50
 G_M35453_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 7.00, instruction count 3, allocated bytes for code 9 (MethodHash=2c417582) for method Repro.Tst:f01():this (FullOpts)
+; Total bytes of code 19, prolog size 0, PerfScore 5.50, instruction count 6, allocated bytes for code 19 (MethodHash=2c417582) for method Repro.Tst:f01():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+111.11%</span>) : 447309.dasm - Repro.Tst:f01():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,8 +8,9 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  6   )     ref  ->  rcx         this class-hnd single-def <Repro.Tst>
+;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Repro.Tst>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V02 cse0         [V02,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,14 +18,17 @@ G_M35453_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M35453_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       inc      qword ptr [rcx+0x08]
-       inc      qword ptr [rcx+0x08]
-						;; size=8 bbWeight=1 PerfScore 6.00
+       mov      rax, qword ptr [rcx+0x08]
+       inc      rax
+       mov      qword ptr [rcx+0x08], rax
+       inc      rax
+       mov      qword ptr [rcx+0x08], rax
+						;; size=18 bbWeight=1 PerfScore 4.50
 G_M35453_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 7.00, instruction count 3, allocated bytes for code 9 (MethodHash=2c417582) for method Repro.Tst:f01():this (Tier1)
+; Total bytes of code 19, prolog size 0, PerfScore 5.50, instruction count 6, allocated bytes for code 19 (MethodHash=2c417582) for method Repro.Tst:f01():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+8</span> (<span style="color:red">+133.33%</span>) : 240771.dasm - ILGEN_939264028:main():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,9 +10,9 @@
 ;* V00 loc0         [V00    ] (  0,  0   )     int  ->  zero-ref   
 ;* V01 loc1         [V01    ] (  0,  0   )    long  ->  zero-ref   
 ;* V02 loc2         [V02    ] (  0,  0   )   float  ->  zero-ref   
-;* V03 loc3         [V03    ] (  0,  0   )  double  ->  zero-ref   
+;* V03 loc3         [V03,T02] (  0,  0   )  double  ->  zero-ref   
 ;* V04 loc4         [V04    ] (  0,  0   )     int  ->  zero-ref   
-;# V05 OutArgs      [V05    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )    long  ->  zero-ref    "impSpillLclRefs"
 ;* V07 tmp2         [V07    ] (  0,  0   )    long  ->  zero-ref    "impSpillLclRefs"
 ;* V08 tmp3         [V08    ] (  0,  0   )     int  ->  zero-ref    "impSpillLclRefs"
@@ -36,19 +36,22 @@
 ;* V26 tmp21        [V26    ] (  0,  0   )   float  ->  zero-ref    "impSpillLclRefs"
 ;* V27 tmp22        [V27    ] (  0,  0   )   float  ->  zero-ref    "impSpillStackEnsure"
 ;* V28 tmp23        [V28    ] (  0,  0   )     int  ->  zero-ref    "impSpillStackEnsure"
+;* V29 cse0         [V29,T01] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 40
 
 G_M40236_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M40236_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, 100
 						;; size=5 bbWeight=1 PerfScore 0.25
 G_M40236_IG03:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 6, prolog size 0, PerfScore 1.25, instruction count 2, allocated bytes for code 6 (MethodHash=17ad62d3) for method ILGEN_939264028:main():int (FullOpts)
+; Total bytes of code 14, prolog size 4, PerfScore 1.75, instruction count 4, allocated bytes for code 14 (MethodHash=17ad62d3) for method ILGEN_939264028:main():int (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -56,8 +59,9 @@ Unwind Info:
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
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-17</span> (<span style="color:green">-62.96%</span>) : 27101.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,11 +9,12 @@
 ; 0 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+VariableStepIntegralRangeState`1[ushort]>
 ;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+VariableStepIntegralRangeState`1[ushort]>
 ;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+VariableStepIntegralRangeState`1[ushort]>
+;  V05 cse0         [V05,T01] (  2,  2   )     ref  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -23,17 +24,15 @@ G_M40080_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       mov      byte  ptr [rax+0x0A], 0
-       mov      rax, gword ptr [rcx+0x08]
-       mov      byte  ptr [rax+0x0B], 0
-       mov      rax, gword ptr [rcx+0x08]
-       mov      word  ptr [rax+0x08], 0
-						;; size=26 bbWeight=1 PerfScore 9.00
+       xor      ecx, ecx
+       ; gcrRegs -[rcx]
+       mov      dword ptr [rax+0x08], ecx
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M40080_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 27, prolog size 0, PerfScore 10.00, instruction count 7, allocated bytes for code 27 (MethodHash=49f2636f) for method Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
+; Total bytes of code 10, prolog size 0, PerfScore 4.25, instruction count 4, allocated bytes for code 10 (MethodHash=49f2636f) for method Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-61.54%</span>) : 41526.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSortedAddressPairsArgs:get_SortOption():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 0 inlinees with PGO data; 24 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  7,  7   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSortedAddressPairsArgs>
+;  V00 this         [V00,T01] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSortedAddressPairsArgs>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V03 tmp2         [V03    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
@@ -18,8 +18,10 @@
 ;* V06 tmp5         [V06    ] (  0,  0   )    long  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V07 tmp6         [V07    ] (  0,  0   )    long  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V08 tmp7         [V08    ] (  0,  0   )    long  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V09 tmp8         [V09,T01] (  2,  4   )     int  ->  rax         "Inlining Arg"
+;  V09 tmp8         [V09,T02] (  2,  4   )     int  ->  rcx         "Inlining Arg"
 ;* V10 tmp9         [V10    ] (  0,  0   )    long  ->  zero-ref    ld-addr-op "Inlining Arg"
+;  V11 cse0         [V11,T00] (  5,  5   )     int  ->  rcx         "CSE - aggressive"
+;  V12 cse1         [V12,T03] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -29,28 +31,19 @@ G_M21221_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, qword ptr [(reloc)]      ; const ptr
        mov      rax, qword ptr [rcx+rax+0x50]
-       mov      eax, dword ptr [rax]
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rdx, qword ptr [rcx+rdx+0x50]
-       add      eax, dword ptr [rdx]
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rdx, qword ptr [rcx+rdx+0x50]
-       add      eax, dword ptr [rdx]
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rdx, qword ptr [rcx+rdx+0x50]
-       mov      edx, dword ptr [rdx]
-       lea      eax, [rax+rdx+0x04]
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rcx, qword ptr [rcx+rdx+0x50]
+       mov      ecx, dword ptr [rax]
        ; gcrRegs -[rcx]
-       cdqe     
-       mov      eax, dword ptr [rcx+rax]
-						;; size=77 bbWeight=1 PerfScore 33.25
+       lea      edx, [rcx+rcx]
+       add      edx, ecx
+       lea      ecx, [rdx+rcx+0x04]
+       movsxd   rcx, ecx
+       mov      eax, dword ptr [rax+rcx]
+						;; size=29 bbWeight=1 PerfScore 10.00
 G_M21221_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 78, prolog size 0, PerfScore 34.25, instruction count 18, allocated bytes for code 78 (MethodHash=d7e1ad1a) for method Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSortedAddressPairsArgs:get_SortOption():int:this (FullOpts)
+; Total bytes of code 30, prolog size 0, PerfScore 11.00, instruction count 9, allocated bytes for code 30 (MethodHash=d7e1ad1a) for method Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSortedAddressPairsArgs:get_SortOption():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-57.83%</span>) : 33518.dasm - Microsoft.Diagnostics.Tracing.TraceEvent:get_ProcessorTime():ulong:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,8 +8,9 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  7,  5   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Diagnostics.Tracing.TraceEvent>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Diagnostics.Tracing.TraceEvent>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V02 cse0         [V02,T01] (  6,  4   )    long  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,38 +19,28 @@ G_M62549_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 G_M62549_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rax, qword ptr [(reloc)]      ; const ptr
-       mov      rax, qword ptr [rcx+rax+0x48]
-       test     byte  ptr [rax+0x04], 16
+       mov      rcx, qword ptr [rcx+rax+0x48]
+       ; gcrRegs -[rcx]
+       test     byte  ptr [rcx+0x04], 16
        je       SHORT G_M62549_IG05
 						;; size=18 bbWeight=1 PerfScore 8.00
-G_M62549_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       mov      rax, qword ptr [(reloc)]      ; const ptr
-       mov      rax, qword ptr [rcx+rax+0x48]
-       mov      eax, dword ptr [rax+0x38]
+G_M62549_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rcx+0x38]
        shl      eax, 4
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rcx, qword ptr [rcx+rdx+0x48]
-       ; gcrRegs -[rcx]
        add      eax, dword ptr [rcx+0x3C]
-						;; size=33 bbWeight=0.50 PerfScore 6.75
+						;; size=9 bbWeight=0.50 PerfScore 2.75
 G_M62549_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M62549_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs +[rcx]
-       mov      rax, qword ptr [(reloc)]      ; const ptr
-       mov      rax, qword ptr [rcx+rax+0x48]
-       mov      eax, dword ptr [rax+0x38]
-       mov      rdx, qword ptr [(reloc)]      ; const ptr
-       mov      rcx, qword ptr [rcx+rdx+0x48]
-       ; gcrRegs -[rcx]
+G_M62549_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, dword ptr [rcx+0x38]
        add      eax, dword ptr [rcx+0x3C]
-						;; size=30 bbWeight=0.50 PerfScore 6.50
+						;; size=6 bbWeight=0.50 PerfScore 2.50
 G_M62549_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 83, prolog size 0, PerfScore 22.25, instruction count 19, allocated bytes for code 83 (MethodHash=88fb0baa) for method Microsoft.Diagnostics.Tracing.TraceEvent:get_ProcessorTime():ulong:this (FullOpts)
+; Total bytes of code 35, prolog size 0, PerfScore 14.25, instruction count 11, allocated bytes for code 35 (MethodHash=88fb0baa) for method Microsoft.Diagnostics.Tracing.TraceEvent:get_ProcessorTime():ulong:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+42.86%</span>) : 72023.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  6   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer>
+;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer>
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,15 +19,18 @@ G_M26768_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M26768_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       and      dword ptr [rcx+0x60], 0xD1FFAB1E
+       mov      eax, dword ptr [rcx+0x60]
+       and      eax, 0xD1FFAB1E
+       mov      dword ptr [rcx+0x60], eax
        shl      edx, 16
-       or       dword ptr [rcx+0x60], edx
-						;; size=13 bbWeight=1 PerfScore 6.50
+       or       eax, edx
+       mov      dword ptr [rcx+0x60], eax
+						;; size=19 bbWeight=1 PerfScore 5.00
 G_M26768_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 0, PerfScore 7.50, instruction count 4, allocated bytes for code 14 (MethodHash=da9d976f) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
+; Total bytes of code 20, prolog size 0, PerfScore 6.00, instruction count 7, allocated bytes for code 20 (MethodHash=da9d976f) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+42.86%</span>) : 133566.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  6   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer>
+;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer>
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,15 +19,18 @@ G_M26768_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M26768_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       and      dword ptr [rcx+0x68], 0xD1FFAB1E
+       mov      eax, dword ptr [rcx+0x68]
+       and      eax, 0xD1FFAB1E
+       mov      dword ptr [rcx+0x68], eax
        shl      edx, 16
-       or       dword ptr [rcx+0x68], edx
-						;; size=13 bbWeight=1 PerfScore 6.50
+       or       eax, edx
+       mov      dword ptr [rcx+0x68], eax
+						;; size=19 bbWeight=1 PerfScore 5.00
 G_M26768_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 0, PerfScore 7.50, instruction count 4, allocated bytes for code 14 (MethodHash=da9d976f) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
+; Total bytes of code 20, prolog size 0, PerfScore 6.00, instruction count 7, allocated bytes for code 20 (MethodHash=da9d976f) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+50.00%</span>) : 244949.dasm - System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,12 +9,13 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  9,  5.50)     ref  ->  rcx         this class-hnd single-def <System.CodeDom.CodeTypeDeclaration>
+;  V00 this         [V00,T00] (  8,  5   )     ref  ->  rcx         this class-hnd single-def <System.CodeDom.CodeTypeDeclaration>
 ;  V01 arg1         [V01,T01] (  3,  3   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V04 tmp2         [V04    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;  V06 cse0         [V06,T02] (  5,  2.50)     int  ->  rax         multi-def "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -26,21 +27,26 @@ G_M19259_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        je       SHORT G_M19259_IG05
 						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19259_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       and      dword ptr [rcx+0x70], -33
-       or       dword ptr [rcx+0x70], 32
+       mov      eax, dword ptr [rcx+0x70]
+       and      eax, -33
+       mov      dword ptr [rcx+0x70], eax
+       or       eax, 32
+       mov      dword ptr [rcx+0x70], eax
        mov      word  ptr [rcx+0x74], 0
-						;; size=14 bbWeight=0.50 PerfScore 3.50
+						;; size=21 bbWeight=0.50 PerfScore 2.75
 G_M19259_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 G_M19259_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       and      dword ptr [rcx+0x70], -33
-						;; size=4 bbWeight=0.50 PerfScore 1.50
+       mov      eax, dword ptr [rcx+0x70]
+       and      eax, -33
+       mov      dword ptr [rcx+0x70], eax
+						;; size=9 bbWeight=0.50 PerfScore 1.62
 G_M19259_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 24, prolog size 0, PerfScore 7.25, instruction count 8, allocated bytes for code 24 (MethodHash=39b3b4c4) for method System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
+; Total bytes of code 36, prolog size 0, PerfScore 6.62, instruction count 13, allocated bytes for code 36 (MethodHash=39b3b4c4) for method System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-17</span> (<span style="color:green">-62.96%</span>) : 14052.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,11 +8,12 @@
 ; 0 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+VariableStepIntegralRangeState`1[ushort]>
 ;* V03 tmp2         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+VariableStepIntegralRangeState`1[ushort]>
 ;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.FSharp.Core.Operators+OperatorIntrinsics+VariableStepIntegralRangeState`1[ushort]>
+;  V05 cse0         [V05,T01] (  2,  2   )     ref  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -22,17 +23,15 @@ G_M40080_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       mov      byte  ptr [rax+0x0A], 0
-       mov      rax, gword ptr [rcx+0x08]
-       mov      byte  ptr [rax+0x0B], 0
-       mov      rax, gword ptr [rcx+0x08]
-       mov      word  ptr [rax+0x08], 0
-						;; size=26 bbWeight=1 PerfScore 9.00
+       xor      ecx, ecx
+       ; gcrRegs -[rcx]
+       mov      dword ptr [rax+0x08], ecx
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M40080_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 27, prolog size 0, PerfScore 10.00, instruction count 7, allocated bytes for code 27 (MethodHash=49f2636f) for method Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
+; Total bytes of code 10, prolog size 0, PerfScore 4.25, instruction count 4, allocated bytes for code 10 (MethodHash=49f2636f) for method Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-40</span> (<span style="color:green">-48.19%</span>) : 296024.dasm - System.Uri:IsReservedCharacter(ushort):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,56 +8,45 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Uri>
-;  V01 arg1         [V01,T00] ( 11,  7   )  ushort  ->  rdx         single-def
+;  V01 arg1         [V01,T00] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 rat0         [V04,T02] (  3,  3   )     int  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 0
 
 G_M34333_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M34333_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rax, dx
-       cmp      eax, 59
-       je       SHORT G_M34333_IG05
+       movzx    rcx, dx
+       cmp      ecx, 59
+       je       SHORT G_M34333_IG06
 						;; size=8 bbWeight=1 PerfScore 1.50
 G_M34333_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rax, dx
-       cmp      eax, 47
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 58
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 64
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 38
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 61
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 43
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 36
-       je       SHORT G_M34333_IG05
-       movzx    rax, dx
-       cmp      eax, 44
+       mov      edx, ecx
+       sub      edx, 36
+       cmp      edx, 28
+       ja       SHORT G_M34333_IG04
+       mov      eax, 0xD1FFAB1E
+       bt       eax, edx
+       jb       SHORT G_M34333_IG06
+						;; size=20 bbWeight=0.50 PerfScore 1.75
+G_M34333_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       xor      eax, eax
+       cmp      ecx, 44
        sete     al
-       movzx    rax, al
-						;; size=68 bbWeight=0.50 PerfScore 6.12
-G_M34333_IG04:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=8 bbWeight=0.50 PerfScore 0.75
+G_M34333_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M34333_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M34333_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M34333_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+G_M34333_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 83, prolog size 0, PerfScore 8.75, instruction count 31, allocated bytes for code 83 (MethodHash=44b679e2) for method System.Uri:IsReservedCharacter(ushort):ubyte:this (FullOpts)
+; Total bytes of code 43, prolog size 0, PerfScore 5.12, instruction count 16, allocated bytes for code 43 (MethodHash=44b679e2) for method System.Uri:IsReservedCharacter(ushort):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-45.45%</span>) : 65633.dasm - Microsoft.CodeAnalysis.CSharp.NullableFlowStateExtensions:Join(ubyte,ubyte):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  4,  4   )   ubyte  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  4,  4   )   ubyte  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )   ubyte  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,18 +19,15 @@ G_M19978_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M19978_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movzx    rax, cl
-       movzx    r8, dl
-       movzx    rcx, cl
-       movzx    rdx, dl
-       cmp      eax, r8d
-       mov      eax, edx
-       cmovg    eax, ecx
-						;; size=21 bbWeight=1 PerfScore 1.75
+       movzx    rcx, dl
+       cmp      eax, ecx
+       cmovle   eax, ecx
+						;; size=11 bbWeight=1 PerfScore 1.00
 G_M19978_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 2.75, instruction count 8, allocated bytes for code 22 (MethodHash=dd98b1f5) for method Microsoft.CodeAnalysis.CSharp.NullableFlowStateExtensions:Join(ubyte,ubyte):ubyte (FullOpts)
+; Total bytes of code 12, prolog size 0, PerfScore 2.00, instruction count 5, allocated bytes for code 12 (MethodHash=dd98b1f5) for method Microsoft.CodeAnalysis.CSharp.NullableFlowStateExtensions:Join(ubyte,ubyte):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+43.43%</span>) : 95874.dasm - Microsoft.VisualBasic.CompilerServices.Conversions:ToChar(System.Object):ushort (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,18 +8,21 @@
 ; 1 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  7,  5   )     ref  ->  rcx         class-hnd single-def <System.Object>
-;  V01 loc0         [V01,T01] (  4,  2.50)  ushort  ->  rax        
+;  V00 arg0         [V00,T00] (  7,  4.50)     ref  ->  rcx         class-hnd single-def <System.Object>
+;  V01 loc0         [V01,T02] (  4,  2.50)  ushort  ->  rax        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T02] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <<unknown class>>
-;* V04 tmp2         [V04,T03] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.String>
-;  V05 tmp3         [V05,T04] (  3,  0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;* V03 tmp1         [V03,T05] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <<unknown class>>
+;* V04 tmp2         [V04,T06] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.String>
+;  V05 tmp3         [V05,T07] (  3,  0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V06 cse0         [V06,T04] (  3,  1.50)    long  ->  rdx         "CSE - moderate"
+;  V07 rat0         [V07,T01] (  3,  3   )     ref  ->  rax         "replacement local"
+;  V08 rat1         [V08,T03] (  3,  2   )    long  ->  [rsp+0x28]  spill-single-def "CSE for expectedClsNode"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 48
 
 G_M47251_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
+       sub      rsp, 48
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M47251_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
@@ -33,29 +36,49 @@ G_M47251_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 						;; size=4 bbWeight=0.50 PerfScore 1.12
 G_M47251_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
+       mov      rdx, qword ptr [rcx]
        mov      rax, 0xD1FFAB1E      ; <unknown class>
-       cmp      qword ptr [rcx], rax
+       cmp      rdx, rax
        jne      SHORT G_M47251_IG05
        movzx    rax, word  ptr [rcx+0x08]
        jmp      SHORT G_M47251_IG06
-						;; size=21 bbWeight=0.50 PerfScore 4.12
+						;; size=24 bbWeight=0.50 PerfScore 3.75
 G_M47251_IG05:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        mov      rax, 0xD1FFAB1E      ; System.String
-       cmp      qword ptr [rcx], rax
+       cmp      rdx, rax
+       jne      SHORT G_M47251_IG09
+       mov      rax, rcx
+       ; gcrRegs +[rax]
+       mov      rdx, 0xD1FFAB1E      ; System.String
+       mov      qword ptr [rsp+0x28], rdx
+       cmp      qword ptr [rax], rdx
        jne      SHORT G_M47251_IG08
+       mov      rcx, rax
        call     [Microsoft.VisualBasic.CompilerServices.Conversions:ToChar(System.String):ushort]
-       ; gcrRegs -[rcx]
+       ; gcrRegs -[rax rcx]
        ; gcr arg pop 0
-						;; size=21 bbWeight=0.50 PerfScore 3.62
+						;; size=47 bbWeight=0.50 PerfScore 5.12
 G_M47251_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        nop      
 						;; size=1 bbWeight=1 PerfScore 0.25
 G_M47251_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 48
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
-G_M47251_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M47251_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[rcx]
+       mov      rdx, rcx
+       ; gcrRegs +[rdx]
+       mov      rcx, qword ptr [rsp+0x28]
+       ; gcrRegs -[rcx]
+       call     CORINFO_HELP_CHKCASTCLASS
+       ; gcrRegs -[rdx] +[rax]
+       ; gcr arg pop 0
+       int3     
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M47251_IG09:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
@@ -75,7 +98,7 @@ G_M47251_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=36 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 99, prolog size 5, PerfScore 13.38, instruction count 27, allocated bytes for code 99 (MethodHash=40a2476c) for method Microsoft.VisualBasic.CompilerServices.Conversions:ToChar(System.Object):ushort (FullOpts)
+; Total bytes of code 142, prolog size 5, PerfScore 14.50, instruction count 38, allocated bytes for code 142 (MethodHash=40a2476c) for method Microsoft.VisualBasic.CompilerServices.Conversions:ToChar(System.Object):ushort (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -88,5 +111,5 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+43</span> (<span style="color:red">+43.43%</span>) : 95872.dasm - Microsoft.VisualBasic.CompilerServices.Conversions:ToDate(System.Object):System.DateTime (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,21 +7,24 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  7,  5   )     ref  ->  rcx         class-hnd single-def <System.Object>
+;  V00 arg0         [V00,T00] (  7,  4.50)     ref  ->  rcx         class-hnd single-def <System.Object>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.DateTime>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T02] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.DateTime>
-;* V04 tmp2         [V04,T03] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.String>
-;  V05 tmp3         [V05,T05] (  3,  0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;* V03 tmp1         [V03,T05] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.DateTime>
+;* V04 tmp2         [V04,T06] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.String>
+;  V05 tmp3         [V05,T08] (  3,  0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct ( 8) zero-ref    "folding static readonly field struct" <System.DateTime>
-;  V07 tmp5         [V07,T01] (  4,  2.50)    long  ->  rax         "field V01._dateData (fldOffset=0x0)" P-INDEP
-;* V08 tmp6         [V08,T04] (  0,  0   )    long  ->  zero-ref    single-def "field V06._dateData (fldOffset=0x0)" P-INDEP
+;  V07 tmp5         [V07,T02] (  4,  2.50)    long  ->  rax         "field V01._dateData (fldOffset=0x0)" P-INDEP
+;* V08 tmp6         [V08,T07] (  0,  0   )    long  ->  zero-ref    single-def "field V06._dateData (fldOffset=0x0)" P-INDEP
+;  V09 cse0         [V09,T04] (  3,  1.50)    long  ->  rdx         "CSE - moderate"
+;  V10 rat0         [V10,T01] (  3,  3   )     ref  ->  rax         "replacement local"
+;  V11 rat1         [V11,T03] (  3,  2   )    long  ->  [rsp+0x28]  spill-single-def "CSE for expectedClsNode"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 48
 
 G_M46514_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
+       sub      rsp, 48
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M46514_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
@@ -35,29 +38,49 @@ G_M46514_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 						;; size=4 bbWeight=0.50 PerfScore 1.12
 G_M46514_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
+       mov      rdx, qword ptr [rcx]
        mov      rax, 0xD1FFAB1E      ; System.DateTime
-       cmp      qword ptr [rcx], rax
+       cmp      rdx, rax
        jne      SHORT G_M46514_IG05
        mov      rax, qword ptr [rcx+0x08]
        jmp      SHORT G_M46514_IG06
-						;; size=21 bbWeight=0.50 PerfScore 4.12
+						;; size=24 bbWeight=0.50 PerfScore 3.75
 G_M46514_IG05:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        mov      rax, 0xD1FFAB1E      ; System.String
-       cmp      qword ptr [rcx], rax
+       cmp      rdx, rax
+       jne      SHORT G_M46514_IG09
+       mov      rax, rcx
+       ; gcrRegs +[rax]
+       mov      rdx, 0xD1FFAB1E      ; System.String
+       mov      qword ptr [rsp+0x28], rdx
+       cmp      qword ptr [rax], rdx
        jne      SHORT G_M46514_IG08
+       mov      rcx, rax
        call     [Microsoft.VisualBasic.CompilerServices.Conversions:ToDate(System.String):System.DateTime]
-       ; gcrRegs -[rcx]
+       ; gcrRegs -[rax rcx]
        ; gcr arg pop 0
-						;; size=21 bbWeight=0.50 PerfScore 3.62
+						;; size=47 bbWeight=0.50 PerfScore 5.12
 G_M46514_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        nop      
 						;; size=1 bbWeight=1 PerfScore 0.25
 G_M46514_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 48
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
-G_M46514_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M46514_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[rcx]
+       mov      rdx, rcx
+       ; gcrRegs +[rdx]
+       mov      rcx, qword ptr [rsp+0x28]
+       ; gcrRegs -[rcx]
+       call     CORINFO_HELP_CHKCASTCLASS
+       ; gcrRegs -[rdx] +[rax]
+       ; gcr arg pop 0
+       int3     
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M46514_IG09:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rax]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
@@ -77,7 +100,7 @@ G_M46514_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=36 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 99, prolog size 5, PerfScore 13.38, instruction count 27, allocated bytes for code 99 (MethodHash=a9014a4d) for method Microsoft.VisualBasic.CompilerServices.Conversions:ToDate(System.Object):System.DateTime (FullOpts)
+; Total bytes of code 142, prolog size 5, PerfScore 14.50, instruction count 38, allocated bytes for code 142 (MethodHash=a9014a4d) for method Microsoft.VisualBasic.CompilerServices.Conversions:ToDate(System.Object):System.DateTime (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -90,5 +113,5 @@ Unwind Info:
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+50.00%</span>) : 258094.dasm - System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,12 +8,13 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  9,  5.50)     ref  ->  rcx         this class-hnd single-def <System.CodeDom.CodeTypeDeclaration>
+;  V00 this         [V00,T00] (  8,  5   )     ref  ->  rcx         this class-hnd single-def <System.CodeDom.CodeTypeDeclaration>
 ;  V01 arg1         [V01,T01] (  3,  3   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V04 tmp2         [V04    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;  V06 cse0         [V06,T02] (  5,  2.50)     int  ->  rax         multi-def "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -25,21 +26,26 @@ G_M19259_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        je       SHORT G_M19259_IG05
 						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19259_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       and      dword ptr [rcx+0x70], -33
-       or       dword ptr [rcx+0x70], 32
+       mov      eax, dword ptr [rcx+0x70]
+       and      eax, -33
+       mov      dword ptr [rcx+0x70], eax
+       or       eax, 32
+       mov      dword ptr [rcx+0x70], eax
        mov      word  ptr [rcx+0x74], 0
-						;; size=14 bbWeight=0.50 PerfScore 3.50
+						;; size=21 bbWeight=0.50 PerfScore 2.75
 G_M19259_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 G_M19259_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       and      dword ptr [rcx+0x70], -33
-						;; size=4 bbWeight=0.50 PerfScore 1.50
+       mov      eax, dword ptr [rcx+0x70]
+       and      eax, -33
+       mov      dword ptr [rcx+0x70], eax
+						;; size=9 bbWeight=0.50 PerfScore 1.62
 G_M19259_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 24, prolog size 0, PerfScore 7.25, instruction count 8, allocated bytes for code 24 (MethodHash=39b3b4c4) for method System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
+; Total bytes of code 36, prolog size 0, PerfScore 6.62, instruction count 13, allocated bytes for code 36 (MethodHash=39b3b4c4) for method System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-50.00%</span>) : 399491.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,9 +9,11 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  4.94)  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  5,  4.06)  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  4,  3.94)     int  ->  rax         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  4,  3.06)     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -19,28 +21,22 @@ G_M1277_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M1277_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
-       je       SHORT G_M1277_IG05
-       movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
-       jge      SHORT G_M1277_IG05
-						;; size=24 bbWeight=1 PerfScore 3.50
-G_M1277_IG03:        ; bbWeight=0.94, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       movzx    rax, cx
-						;; size=3 bbWeight=0.94 PerfScore 0.23
-G_M1277_IG04:        ; bbWeight=0.94, epilog, nogc, extend
+       movzx    rcx, dx
+       cmp      eax, ecx
+       je       SHORT G_M1277_IG04
+       jge      SHORT G_M1277_IG04
+						;; size=12 bbWeight=1 PerfScore 2.75
+G_M1277_IG03:        ; bbWeight=0.94, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.94 PerfScore 0.94
-G_M1277_IG05:        ; bbWeight=0.06, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       movzx    rax, dx
-						;; size=3 bbWeight=0.06 PerfScore 0.02
-G_M1277_IG06:        ; bbWeight=0.06, epilog, nogc, extend
+G_M1277_IG04:        ; bbWeight=0.06, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, ecx
+						;; size=2 bbWeight=0.06 PerfScore 0.02
+G_M1277_IG05:        ; bbWeight=0.06, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.06 PerfScore 0.06
 
-; Total bytes of code 32, prolog size 0, PerfScore 4.75, instruction count 12, allocated bytes for code 32 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
+; Total bytes of code 16, prolog size 0, PerfScore 3.77, instruction count 8, allocated bytes for code 16 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-50.00%</span>) : 440016.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,9 +9,11 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  4.97)  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  5,  4.03)  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  4,  3.97)     int  ->  rax         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  4,  3.03)     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -19,28 +21,22 @@ G_M1277_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M1277_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
-       je       SHORT G_M1277_IG05
-       movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
-       jge      SHORT G_M1277_IG05
-						;; size=24 bbWeight=1 PerfScore 3.50
-G_M1277_IG03:        ; bbWeight=0.97, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       movzx    rax, cx
-						;; size=3 bbWeight=0.97 PerfScore 0.24
-G_M1277_IG04:        ; bbWeight=0.97, epilog, nogc, extend
+       movzx    rcx, dx
+       cmp      eax, ecx
+       je       SHORT G_M1277_IG04
+       jge      SHORT G_M1277_IG04
+						;; size=12 bbWeight=1 PerfScore 2.75
+G_M1277_IG03:        ; bbWeight=0.97, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.97 PerfScore 0.97
-G_M1277_IG05:        ; bbWeight=0.03, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       movzx    rax, dx
-						;; size=3 bbWeight=0.03 PerfScore 0.01
-G_M1277_IG06:        ; bbWeight=0.03, epilog, nogc, extend
+G_M1277_IG04:        ; bbWeight=0.03, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, ecx
+						;; size=2 bbWeight=0.03 PerfScore 0.01
+G_M1277_IG05:        ; bbWeight=0.03, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.03 PerfScore 0.03
 
-; Total bytes of code 32, prolog size 0, PerfScore 4.75, instruction count 12, allocated bytes for code 32 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
+; Total bytes of code 16, prolog size 0, PerfScore 3.76, instruction count 8, allocated bytes for code 16 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-16</span> (<span style="color:green">-50.00%</span>) : 382841.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,9 +9,11 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  4.96)  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  5,  4.04)  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  4,  3.96)     int  ->  rax         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  4,  3.04)     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -19,28 +21,22 @@ G_M1277_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M1277_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
-       je       SHORT G_M1277_IG05
-       movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
-       jge      SHORT G_M1277_IG05
-						;; size=24 bbWeight=1 PerfScore 3.50
-G_M1277_IG03:        ; bbWeight=0.96, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       movzx    rax, cx
-						;; size=3 bbWeight=0.96 PerfScore 0.24
-G_M1277_IG04:        ; bbWeight=0.96, epilog, nogc, extend
+       movzx    rcx, dx
+       cmp      eax, ecx
+       je       SHORT G_M1277_IG04
+       jge      SHORT G_M1277_IG04
+						;; size=12 bbWeight=1 PerfScore 2.75
+G_M1277_IG03:        ; bbWeight=0.96, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.96 PerfScore 0.96
-G_M1277_IG05:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       movzx    rax, dx
-						;; size=3 bbWeight=0.04 PerfScore 0.01
-G_M1277_IG06:        ; bbWeight=0.04, epilog, nogc, extend
+G_M1277_IG04:        ; bbWeight=0.04, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, ecx
+						;; size=2 bbWeight=0.04 PerfScore 0.01
+G_M1277_IG05:        ; bbWeight=0.04, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.04 PerfScore 0.04
 
-; Total bytes of code 32, prolog size 0, PerfScore 4.75, instruction count 12, allocated bytes for code 32 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
+; Total bytes of code 16, prolog size 0, PerfScore 3.76, instruction count 8, allocated bytes for code 16 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
 ; ============================================================
 
 Unwind Info:

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

<details>
<summary><span style="color:red">+8</span> (<span style="color:red">+42.11%</span>) : 655984.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,33 +10,31 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
-G_M31554_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M31554_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
-G_M31554_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
+G_M31554_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx+0x12], 130
-       je       SHORT G_M31554_IG04
-       xor      eax, eax
-       cmp      byte  ptr [rdx+0x12], 131
-       setne    al
-						;; size=15 bbWeight=1 PerfScore 8.25
+       movzx    rax, byte  ptr [rdx+0x12]
+       xor      ecx, ecx
+       xor      edx, edx
+       ; gcrRegs -[rdx]
+       cmp      eax, 131
+       setne    dl
+       cmp      eax, 130
+       mov      eax, edx
+       cmove    eax, ecx
+						;; size=26 bbWeight=1 PerfScore 4.50
 G_M31554_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M31554_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rdx]
-       xor      eax, eax
-						;; size=2 bbWeight=0 PerfScore 0.00
-G_M31554_IG05:        ; bbWeight=0, epilog, nogc, extend
-       ret      
-						;; size=1 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 19, prolog size 0, PerfScore 9.25, instruction count 8, allocated bytes for code 19 (MethodHash=276f84bd) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (Tier1)
+; Total bytes of code 27, prolog size 0, PerfScore 5.50, instruction count 9, allocated bytes for code 27 (MethodHash=276f84bd) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+42.86%</span>) : 190405.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  6   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer>
+;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer>
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  3,  3   )     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -17,15 +18,18 @@ G_M26768_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M26768_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       and      dword ptr [rcx+0x68], 0xD1FFAB1E
+       mov      eax, dword ptr [rcx+0x68]
+       and      eax, 0xD1FFAB1E
+       mov      dword ptr [rcx+0x68], eax
        shl      edx, 16
-       or       dword ptr [rcx+0x68], edx
-						;; size=13 bbWeight=1 PerfScore 6.50
+       or       eax, edx
+       mov      dword ptr [rcx+0x68], eax
+						;; size=19 bbWeight=1 PerfScore 5.00
 G_M26768_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 14, prolog size 0, PerfScore 7.50, instruction count 4, allocated bytes for code 14 (MethodHash=da9d976f) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (Tier1)
+; Total bytes of code 20, prolog size 0, PerfScore 6.00, instruction count 7, allocated bytes for code 20 (MethodHash=da9d976f) for method Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-36</span> (<span style="color:green">-67.92%</span>) : 23180.dasm - Microsoft.CodeAnalysis.FindSymbols.FindReferencesSearchOptions:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,10 +10,11 @@
 ;
 ;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V01 tmp1         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.FindSymbols.FindReferencesSearchOptions>
-;* V02 tmp2         [V02,T00] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<AssociatePropertyReferencesWithSpecificAccessor>k__BackingField (fldOffset=0x0)" P-INDEP
-;* V03 tmp3         [V03,T01] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<Cascade>k__BackingField (fldOffset=0x1)" P-INDEP
-;* V04 tmp4         [V04,T02] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<Explicit>k__BackingField (fldOffset=0x2)" P-INDEP
-;* V05 tmp5         [V05,T03] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<UnidirectionalHierarchyCascade>k__BackingField (fldOffset=0x3)" P-INDEP
+;* V02 tmp2         [V02,T01] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<AssociatePropertyReferencesWithSpecificAccessor>k__BackingField (fldOffset=0x0)" P-INDEP
+;* V03 tmp3         [V03,T02] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<Cascade>k__BackingField (fldOffset=0x1)" P-INDEP
+;* V04 tmp4         [V04,T03] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<Explicit>k__BackingField (fldOffset=0x2)" P-INDEP
+;* V05 tmp5         [V05,T04] (  0,  0   )   ubyte  ->  zero-ref    "field V01.<UnidirectionalHierarchyCascade>k__BackingField (fldOffset=0x3)" P-INDEP
+;  V06 cse0         [V06,T00] (  2,  2   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -21,19 +22,13 @@ G_M33392_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M33392_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      byte  ptr [rax], 0
-       mov      rax, 0xD1FFAB1E
-       mov      byte  ptr [rax], 1
-       mov      rax, 0xD1FFAB1E
-       mov      byte  ptr [rax], 1
-       mov      rax, 0xD1FFAB1E
-       mov      byte  ptr [rax], 0
-						;; size=52 bbWeight=1 PerfScore 5.00
+       mov      dword ptr [rax], 0x10100
+						;; size=16 bbWeight=1 PerfScore 1.25
 G_M33392_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 53, prolog size 0, PerfScore 6.00, instruction count 9, allocated bytes for code 53 (MethodHash=4a377d8f) for method Microsoft.CodeAnalysis.FindSymbols.FindReferencesSearchOptions:.cctor() (FullOpts)
+; Total bytes of code 17, prolog size 0, PerfScore 2.25, instruction count 3, allocated bytes for code 17 (MethodHash=4a377d8f) for method Microsoft.CodeAnalysis.FindSymbols.FindReferencesSearchOptions:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-64.71%</span>) : 152123.dasm - System.SpanTests.SpanTests+<>c__DisplayClass99_0:<CtorArrayWrongArrayType>b__1():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,52 +8,33 @@
 ; 1 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.SpanTests.SpanTests+<>c__DisplayClass99_0>
-;  V01 loc0         [V01,T01] (  2,  2   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
+;  V00 this         [V00,T00] (  3,  2   )     ref  ->  rcx         this class-hnd single-def <System.SpanTests.SpanTests+<>c__DisplayClass99_0>
+;* V01 loc0         [V01,T02] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Object]>
-;  V04 tmp2         [V04,T02] (  2,  2   )     int  ->  rcx         "Inlining Arg"
+;* V04 tmp2         [V04,T03] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )   byref  ->  zero-ref    "field V03._reference (fldOffset=0x0)" P-INDEP
 ;* V06 tmp4         [V06    ] (  0,  0   )     int  ->  zero-ref    "field V03._length (fldOffset=0x8)" P-INDEP
+;  V07 cse0         [V07,T01] (  2,  0   )     ref  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M59561_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M59561_IG01:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
-G_M59561_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+						;; size=4 bbWeight=0 PerfScore 0.00
+G_M59561_IG02:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       mov      rcx, gword ptr [rcx+0x08]
-       mov      ecx, dword ptr [rcx+0x08]
-       ; gcrRegs -[rcx]
-       test     rax, rax
-       je       SHORT G_M59561_IG06
-						;; size=16 bbWeight=1 PerfScore 7.25
-G_M59561_IG03:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax+0x08]
        ; gcrRegs -[rax]
        call     [System.ThrowHelper:ThrowArrayTypeMismatchException()]
+       ; gcrRegs -[rcx]
        ; gcr arg pop 0
        int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M59561_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowArgumentOutOfRangeException()
-       call     [rax]System.ThrowHelper:ThrowArgumentOutOfRangeException()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M59561_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       add      rsp, 40
-       ret      
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M59561_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       test     ecx, ecx
-       jne      SHORT G_M59561_IG04
-       jmp      SHORT G_M59561_IG05
-						;; size=6 bbWeight=0 PerfScore 0.00
+						;; size=14 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 51, prolog size 4, PerfScore 7.50, instruction count 16, allocated bytes for code 51 (MethodHash=334a1756) for method System.SpanTests.SpanTests+<>c__DisplayClass99_0:<CtorArrayWrongArrayType>b__1():this (FullOpts)
+; Total bytes of code 18, prolog size 4, PerfScore 0.00, instruction count 5, allocated bytes for code 18 (MethodHash=334a1756) for method System.SpanTests.SpanTests+<>c__DisplayClass99_0:<CtorArrayWrongArrayType>b__1():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-20</span> (<span style="color:green">-48.78%</span>) : 274573.dasm - System.Text.Json.Tests.JsonDomWriteTests:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,28 +10,26 @@
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Text.Json.JsonDocumentOptions>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V02 tmp1         [V02,T00] (  0,  0   )     int  ->  zero-ref    single-def "field V00._maxDepth (fldOffset=0x0)" P-INDEP
-;* V03 tmp2         [V03,T01] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V00._commentHandling (fldOffset=0x4)" P-INDEP
-;* V04 tmp3         [V04,T02] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V00.<AllowTrailingCommas>k__BackingField (fldOffset=0x5)" P-INDEP
+;* V02 tmp1         [V02,T01] (  0,  0   )     int  ->  zero-ref    single-def "field V00._maxDepth (fldOffset=0x0)" P-INDEP
+;* V03 tmp2         [V03,T02] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V00._commentHandling (fldOffset=0x4)" P-INDEP
+;* V04 tmp3         [V04,T03] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V00.<AllowTrailingCommas>k__BackingField (fldOffset=0x5)" P-INDEP
+;  V05 cse0         [V05,T00] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M25093_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M25093_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      dword ptr [rcx], eax
-       mov      rax, 0xD1FFAB1E
-       mov      byte  ptr [rax], 1
-       mov      rax, 0xD1FFAB1E
-       mov      byte  ptr [rax], 0
-						;; size=40 bbWeight=1 PerfScore 4.00
+       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+       xor      ecx, ecx
+       mov      dword ptr [rax], ecx
+       mov      word  ptr [rax+0x04], 1
+						;; size=20 bbWeight=1 PerfScore 2.50
 G_M25093_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 41, prolog size 0, PerfScore 5.00, instruction count 8, allocated bytes for code 41 (MethodHash=48879dfa) for method System.Text.Json.Tests.JsonDomWriteTests:.cctor() (FullOpts)
+; Total bytes of code 21, prolog size 0, PerfScore 3.50, instruction count 5, allocated bytes for code 21 (MethodHash=48879dfa) for method System.Text.Json.Tests.JsonDomWriteTests:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+36.84%</span>) : 57576.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,8 +9,9 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c>
-;  V01 arg1         [V01,T00] (  4,  3.50)     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,26 +19,27 @@ G_M31554_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M31554_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx+0x12], 130
+       movzx    rax, byte  ptr [rdx+0x12]
+       cmp      eax, 130
        je       SHORT G_M31554_IG05
-						;; size=6 bbWeight=1 PerfScore 4.00
-G_M31554_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       cmp      byte  ptr [rdx+0x12], 131
+						;; size=11 bbWeight=1 PerfScore 3.25
+G_M31554_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rdx]
+       cmp      eax, 131
        setne    al
-						;; size=9 bbWeight=0.50 PerfScore 2.12
+       movzx    rax, al
+						;; size=11 bbWeight=0.50 PerfScore 0.75
 G_M31554_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 G_M31554_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rdx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M31554_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 19, prolog size 0, PerfScore 7.25, instruction count 8, allocated bytes for code 19 (MethodHash=276f84bd) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
+; Total bytes of code 26, prolog size 0, PerfScore 5.12, instruction count 9, allocated bytes for code 26 (MethodHash=276f84bd) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+50.00%</span>) : 66217.dasm - System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,12 +8,13 @@
 ; 0 inlinees with PGO data; 6 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  9,  5.50)     ref  ->  rcx         this class-hnd single-def <System.CodeDom.CodeTypeDeclaration>
+;  V00 this         [V00,T00] (  8,  5   )     ref  ->  rcx         this class-hnd single-def <System.CodeDom.CodeTypeDeclaration>
 ;  V01 arg1         [V01,T01] (  3,  3   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V04 tmp2         [V04    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;  V06 cse0         [V06,T02] (  5,  2.50)     int  ->  rax         multi-def "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -25,21 +26,26 @@ G_M19259_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        je       SHORT G_M19259_IG05
 						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19259_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       and      dword ptr [rcx+0x70], -33
-       or       dword ptr [rcx+0x70], 32
+       mov      eax, dword ptr [rcx+0x70]
+       and      eax, -33
+       mov      dword ptr [rcx+0x70], eax
+       or       eax, 32
+       mov      dword ptr [rcx+0x70], eax
        mov      word  ptr [rcx+0x74], 0
-						;; size=14 bbWeight=0.50 PerfScore 3.50
+						;; size=21 bbWeight=0.50 PerfScore 2.75
 G_M19259_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 G_M19259_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       and      dword ptr [rcx+0x70], -33
-						;; size=4 bbWeight=0.50 PerfScore 1.50
+       mov      eax, dword ptr [rcx+0x70]
+       and      eax, -33
+       mov      dword ptr [rcx+0x70], eax
+						;; size=9 bbWeight=0.50 PerfScore 1.62
 G_M19259_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 24, prolog size 0, PerfScore 7.25, instruction count 8, allocated bytes for code 24 (MethodHash=39b3b4c4) for method System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
+; Total bytes of code 36, prolog size 0, PerfScore 6.62, instruction count 13, allocated bytes for code 36 (MethodHash=39b3b4c4) for method System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+8</span> (<span style="color:red">+800.00%</span>) : 214592.dasm - System.Tests.Types.FunctionPointerTests:CompileTimeIdentity_Managed() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <<unknown class>>
 ;* V01 loc1         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <<unknown class>>
-;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -23,16 +23,16 @@
 ;* V12 tmp10        [V12    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Nullable`1[ubyte]>
 ;* V13 tmp11        [V13    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Nullable`1[ubyte]>
 ;* V14 tmp12        [V14    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Nullable`1[ubyte]>
-;* V15 tmp13        [V15,T00] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V04.hasValue (fldOffset=0x0)" P-INDEP
-;* V16 tmp14        [V16,T01] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V04.value (fldOffset=0x1)" P-INDEP
+;* V15 tmp13        [V15,T01] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V04.hasValue (fldOffset=0x0)" P-INDEP
+;* V16 tmp14        [V16,T02] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V04.value (fldOffset=0x1)" P-INDEP
 ;* V17 tmp15        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V06.hasValue (fldOffset=0x0)" P-INDEP
 ;* V18 tmp16        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V06.value (fldOffset=0x1)" P-INDEP
 ;* V19 tmp17        [V19    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V07.hasValue (fldOffset=0x0)" P-INDEP
 ;* V20 tmp18        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V07.value (fldOffset=0x1)" P-INDEP
 ;* V21 tmp19        [V21    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V08.hasValue (fldOffset=0x0)" P-INDEP
 ;* V22 tmp20        [V22    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V08.value (fldOffset=0x1)" P-INDEP
-;* V23 tmp21        [V23,T02] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V10.hasValue (fldOffset=0x0)" P-INDEP
-;* V24 tmp22        [V24,T03] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V10.value (fldOffset=0x1)" P-INDEP
+;* V23 tmp21        [V23,T03] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V10.hasValue (fldOffset=0x0)" P-INDEP
+;* V24 tmp22        [V24,T04] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V10.value (fldOffset=0x1)" P-INDEP
 ;* V25 tmp23        [V25    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V12.hasValue (fldOffset=0x0)" P-INDEP
 ;* V26 tmp24        [V26    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V12.value (fldOffset=0x1)" P-INDEP
 ;* V27 tmp25        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V13.hasValue (fldOffset=0x0)" P-INDEP
@@ -40,16 +40,19 @@
 ;* V29 tmp27        [V29    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V14.hasValue (fldOffset=0x0)" P-INDEP
 ;* V30 tmp28        [V30    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "field V14.value (fldOffset=0x1)" P-INDEP
 ;* V31 tmp29        [V31    ] (  0,  0   )  struct ( 8) zero-ref    do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[ubyte]>
+;* V32 cse0         [V32,T00] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 40
 
 G_M3856_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M3856_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       add      rsp, 40
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 1, prolog size 0, PerfScore 1.00, instruction count 1, allocated bytes for code 1 (MethodHash=c927f0ef) for method System.Tests.Types.FunctionPointerTests:CompileTimeIdentity_Managed() (FullOpts)
+; Total bytes of code 9, prolog size 4, PerfScore 1.50, instruction count 3, allocated bytes for code 9 (MethodHash=c927f0ef) for method System.Tests.Types.FunctionPointerTests:CompileTimeIdentity_Managed() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -57,8 +60,9 @@ Unwind Info:
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
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-14</span> (<span style="color:green">-43.75%</span>) : 2142.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,11 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  4   )  ushort  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  5,  4   )  ushort  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  3,  3   )  ushort  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  3,  3   )  ushort  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T02] (  4,  3   )     int  ->  rax         "CSE - aggressive"
+;  V04 cse1         [V04,T03] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,30 +20,25 @@ G_M1277_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M1277_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
+       movzx    rcx, dx
+       cmp      eax, ecx
        je       SHORT G_M1277_IG04
-						;; size=12 bbWeight=1 PerfScore 1.75
+						;; size=10 bbWeight=1 PerfScore 1.75
 G_M1277_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rax, cx
-       movzx    r8, dx
-       cmp      eax, r8d
+       cmp      eax, ecx
        jl       SHORT G_M1277_IG06
-						;; size=12 bbWeight=0.50 PerfScore 0.88
+						;; size=4 bbWeight=0.50 PerfScore 0.62
 G_M1277_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       movzx    rax, dx
-						;; size=3 bbWeight=0.50 PerfScore 0.12
+       mov      eax, ecx
+						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M1277_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M1277_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       movzx    rax, cx
-						;; size=3 bbWeight=0.50 PerfScore 0.12
-G_M1277_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M1277_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 32, prolog size 0, PerfScore 3.88, instruction count 12, allocated bytes for code 32 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
+; Total bytes of code 18, prolog size 0, PerfScore 3.50, instruction count 9, allocated bytes for code 18 (MethodHash=6509fb02) for method System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-31</span> (<span style="color:green">-39.24%</span>) : 2817.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,6 +8,7 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V01 cse0         [V01,T00] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -18,13 +19,11 @@ G_M9759_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        test     byte  ptr [(reloc)], 1      ; global ptr
        je       SHORT G_M9759_IG05
 						;; size=9 bbWeight=1 PerfScore 4.00
-G_M9759_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M9759_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      ecx, ecx
        mov      dword ptr [(reloc)], ecx
-       test     byte  ptr [(reloc)], 1      ; global ptr
-       je       SHORT G_M9759_IG06
-						;; size=17 bbWeight=1 PerfScore 5.25
-G_M9759_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+						;; size=8 bbWeight=1 PerfScore 1.25
+G_M9759_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
@@ -35,15 +34,8 @@ G_M9759_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        ; gcr arg pop 0
        jmp      SHORT G_M9759_IG03
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M9759_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E
-       mov      edx, 0x3760
-       call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       ; gcr arg pop 0
-       jmp      SHORT G_M9759_IG04
-						;; size=22 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 79, prolog size 4, PerfScore 10.75, instruction count 17, allocated bytes for code 79 (MethodHash=49bdd9e0) for method FSharp.Compiler.AbstractIL.ILBinaryReader:.cctor() (FullOpts)
+; Total bytes of code 48, prolog size 4, PerfScore 6.75, instruction count 11, allocated bytes for code 48 (MethodHash=49bdd9e0) for method FSharp.Compiler.AbstractIL.ILBinaryReader:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-31</span> (<span style="color:green">-39.24%</span>) : 2466.dasm - FSComp.SR:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,6 +8,7 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;* V01 cse0         [V01,T00] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -18,13 +19,11 @@ G_M13645_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        test     byte  ptr [(reloc)], 1      ; global ptr
        je       SHORT G_M13645_IG05
 						;; size=9 bbWeight=1 PerfScore 4.00
-G_M13645_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M13645_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      ecx, ecx
        mov      dword ptr [(reloc)], ecx
-       test     byte  ptr [(reloc)], 1      ; global ptr
-       je       SHORT G_M13645_IG06
-						;; size=17 bbWeight=1 PerfScore 5.25
-G_M13645_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+						;; size=8 bbWeight=1 PerfScore 1.25
+G_M13645_IG04:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
@@ -35,15 +34,8 @@ G_M13645_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        ; gcr arg pop 0
        jmp      SHORT G_M13645_IG03
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M13645_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E
-       mov      edx, 0x3D73
-       call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       ; gcr arg pop 0
-       jmp      SHORT G_M13645_IG04
-						;; size=22 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 79, prolog size 4, PerfScore 10.75, instruction count 17, allocated bytes for code 79 (MethodHash=5d28cab2) for method FSComp.SR:.cctor() (FullOpts)
+; Total bytes of code 48, prolog size 4, PerfScore 6.75, instruction count 11, allocated bytes for code 48 (MethodHash=5d28cab2) for method FSComp.SR:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+27.27%</span>) : 509.dasm - System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  4   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.AssemblyName>
+;  V00 this         [V00,T00] (  5,  3.50)     ref  ->  rcx         this class-hnd single-def <System.Reflection.AssemblyName>
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
 ;  V02 loc0         [V02,T02] (  3,  2.50)     int  ->  rdx        
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 cse0         [V04,T03] (  3,  1.50)     int  ->  rax         "CSE - moderate"
 ;
 ; Lcl frame size = 0
 
@@ -23,16 +24,19 @@ G_M62443_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        jg       SHORT G_M62443_IG04
 						;; size=8 bbWeight=1 PerfScore 1.50
 G_M62443_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       and      dword ptr [rcx+0x40], -241
+       mov      eax, dword ptr [rcx+0x40]
+       and      eax, -241
+       mov      dword ptr [rcx+0x40], eax
        shl      edx, 4
-       or       dword ptr [rcx+0x40], edx
-						;; size=13 bbWeight=0.50 PerfScore 3.25
+       or       eax, edx
+       mov      dword ptr [rcx+0x40], eax
+						;; size=19 bbWeight=0.50 PerfScore 2.50
 G_M62443_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 22 (MethodHash=c3a20c14) for method System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (FullOpts)
+; Total bytes of code 28, prolog size 0, PerfScore 5.00, instruction count 10, allocated bytes for code 28 (MethodHash=c3a20c14) for method System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+36.84%</span>) : 30224.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,8 +9,9 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c>
-;  V01 arg1         [V01,T00] (  4,  3.50)     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,26 +19,27 @@ G_M31554_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M31554_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx+0x12], 130
+       movzx    rax, byte  ptr [rdx+0x12]
+       cmp      eax, 130
        je       SHORT G_M31554_IG05
-						;; size=6 bbWeight=1 PerfScore 4.00
-G_M31554_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       cmp      byte  ptr [rdx+0x12], 131
+						;; size=11 bbWeight=1 PerfScore 3.25
+G_M31554_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rdx]
+       cmp      eax, 131
        setne    al
-						;; size=9 bbWeight=0.50 PerfScore 2.12
+       movzx    rax, al
+						;; size=11 bbWeight=0.50 PerfScore 0.75
 G_M31554_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 G_M31554_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rdx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M31554_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 19, prolog size 0, PerfScore 7.25, instruction count 8, allocated bytes for code 19 (MethodHash=276f84bd) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
+; Total bytes of code 26, prolog size 0, PerfScore 5.12, instruction count 9, allocated bytes for code 26 (MethodHash=276f84bd) for method Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+28</span> (<span style="color:red">+46.67%</span>) : 957.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,47 +8,57 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4, 11   )     ref  ->  rbx         this class-hnd single-def <System.Random+Net5CompatSeedImpl>
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
 
 G_M31728_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 32
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
-G_M31728_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       cmp      byte  ptr [rbx], bl
-						;; size=2 bbWeight=1 PerfScore 3.00
-G_M31728_IG03:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
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
+       vucomiss xmm7, xmm0
        jbe      SHORT G_M31728_IG03
-						;; size=44 bbWeight=8 PerfScore 198.67
+						;; size=31 bbWeight=8 PerfScore 156.67
 G_M31728_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx]
-       add      rsp, 32
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
 
 
-; Total bytes of code 60, prolog size 5, PerfScore 204.92, instruction count 16, allocated bytes for code 60 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
+; Total bytes of code 88, prolog size 17, PerfScore 181.17, instruction count 21, allocated bytes for code 88 (MethodHash=e718840f) for method System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -56,10 +66,14 @@ Unwind Info:
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
<summary><span style="color:green">-38</span> (<span style="color:green">-48.72%</span>) : 23868.dasm - TestInitBlock+Overrun:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,52 +9,37 @@
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V01 tmp1         [V01    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V02 rat0         [V02,T01] (  4,  6   )    long  ->  rbx         "fgMakeTemp is creating a new local variable"
-;  V03 rat1         [V03,T00] (  5,  6   )    long  ->  rsi         "fgMakeTemp is creating a new local variable"
+;  V02 cse0         [V02,T01] (  3,  3   )   byref  ->  rbx         "CSE - aggressive"
+;  V03 rat0         [V03,T00] (  3,  6   )    long  ->  rbx         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M31439_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
        push     rbx
-       sub      rsp, 40
-						;; size=6 bbWeight=1 PerfScore 2.25
+       sub      rsp, 32
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M31439_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        lea      rbx, [(reloc)]
        cmp      qword ptr [rbx-0x08], 0
        jne      SHORT G_M31439_IG05
-       mov      byte  ptr [rbx], 123
-       lea      rsi, [(reloc)]
-       cmp      qword ptr [rsi-0x08], 0
-       jne      SHORT G_M31439_IG06
-						;; size=31 bbWeight=1 PerfScore 10.00
+						;; size=14 bbWeight=1 PerfScore 4.50
 G_M31439_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      word  ptr [rsi], 0x2A2A
-						;; size=5 bbWeight=1 PerfScore 1.00
-G_M31439_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
-       ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
-G_M31439_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       call     CORINFO_HELP_READYTORUN_NONGCSTATIC_BASE
-       ; byrRegs +[rax]
-       ; gcr arg pop 0
        mov      byte  ptr [rbx], 123
-       lea      rsi, [(reloc)]
-       cmp      qword ptr [rsi-0x08], 0
-       je       SHORT G_M31439_IG03
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M31439_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[rax]
+       mov      word  ptr [rbx], 0x2A2A
+						;; size=8 bbWeight=1 PerfScore 2.00
+G_M31439_IG04:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 32
+       pop      rbx
+       ret      
+						;; size=6 bbWeight=1 PerfScore 1.75
+G_M31439_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        call     CORINFO_HELP_READYTORUN_NONGCSTATIC_BASE
        ; byrRegs +[rax]
        ; gcr arg pop 0
        jmp      SHORT G_M31439_IG03
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 78, prolog size 6, PerfScore 15.50, instruction count 22, allocated bytes for code 78 (MethodHash=348c8530) for method TestInitBlock+Overrun:.cctor() (FullOpts)
+; Total bytes of code 40, prolog size 5, PerfScore 9.50, instruction count 12, allocated bytes for code 40 (MethodHash=348c8530) for method TestInitBlock+Overrun:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -62,11 +47,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-47.19%</span>) : 18663.dasm - System.Buffers.SharedArrayPoolStatics:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,58 +8,43 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 rat0         [V01,T01] (  4,  6   )    long  ->  rbx         "fgMakeTemp is creating a new local variable"
-;  V02 rat1         [V02,T00] (  5,  6   )    long  ->  rsi         "fgMakeTemp is creating a new local variable"
+;  V01 cse0         [V01,T01] (  3,  3   )   byref  ->  rbx         "CSE - aggressive"
+;  V02 rat0         [V02,T00] (  3,  6   )    long  ->  rbx         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M8951_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
        push     rbx
-       sub      rsp, 40
-						;; size=6 bbWeight=1 PerfScore 2.25
+       sub      rsp, 32
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M8951_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        lea      rbx, [(reloc)]
        cmp      qword ptr [rbx-0x08], 0
        jne      SHORT G_M8951_IG05
+						;; size=14 bbWeight=1 PerfScore 4.50
+G_M8951_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     System.Buffers.SharedArrayPoolStatics:GetPartitionCount():int
+       ; byrRegs +[rbx]
        ; gcr arg pop 0
        mov      dword ptr [rbx], eax
-       lea      rsi, [(reloc)]
-       cmp      qword ptr [rsi-0x08], 0
-       jne      SHORT G_M8951_IG06
-						;; size=35 bbWeight=1 PerfScore 11.00
-G_M8951_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     System.Buffers.SharedArrayPoolStatics:GetMaxArraysPerPartition():int
        ; gcr arg pop 0
-       mov      dword ptr [rsi+0x04], eax
-						;; size=8 bbWeight=1 PerfScore 2.00
+       mov      dword ptr [rbx+0x04], eax
+						;; size=15 bbWeight=1 PerfScore 4.00
 G_M8951_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
-       pop      rsi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 G_M8951_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       call     CORINFO_HELP_READYTORUN_NONGCSTATIC_BASE
-       ; byrRegs +[rax]
-       ; gcr arg pop 0
-       call     System.Buffers.SharedArrayPoolStatics:GetPartitionCount():int
-       ; byrRegs -[rax]
-       ; gcr arg pop 0
-       mov      dword ptr [rbx], eax
-       lea      rsi, [(reloc)]
-       cmp      qword ptr [rsi-0x08], 0
-       je       SHORT G_M8951_IG03
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M8951_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[rbx]
        call     CORINFO_HELP_READYTORUN_NONGCSTATIC_BASE
        ; byrRegs +[rax]
        ; gcr arg pop 0
        jmp      SHORT G_M8951_IG03
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 89, prolog size 6, PerfScore 17.50, instruction count 25, allocated bytes for code 89 (MethodHash=82dddd08) for method System.Buffers.SharedArrayPoolStatics:.cctor() (FullOpts)
+; Total bytes of code 47, prolog size 5, PerfScore 11.50, instruction count 14, allocated bytes for code 47 (MethodHash=82dddd08) for method System.Buffers.SharedArrayPoolStatics:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -67,11 +52,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-47.19%</span>) : 747.dasm - System.Buffers.SharedArrayPoolStatics:.cctor() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,58 +8,43 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 rat0         [V01,T01] (  4,  6   )    long  ->  rbx         "fgMakeTemp is creating a new local variable"
-;  V02 rat1         [V02,T00] (  5,  6   )    long  ->  rsi         "fgMakeTemp is creating a new local variable"
+;  V01 cse0         [V01,T01] (  3,  3   )   byref  ->  rbx         "CSE - aggressive"
+;  V02 rat0         [V02,T00] (  3,  6   )    long  ->  rbx         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M8951_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
        push     rbx
-       sub      rsp, 40
-						;; size=6 bbWeight=1 PerfScore 2.25
+       sub      rsp, 32
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M8951_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        lea      rbx, [(reloc)]
        cmp      qword ptr [rbx-0x08], 0
        jne      SHORT G_M8951_IG05
+						;; size=14 bbWeight=1 PerfScore 4.50
+G_M8951_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     System.Buffers.SharedArrayPoolStatics:GetPartitionCount():int
+       ; byrRegs +[rbx]
        ; gcr arg pop 0
        mov      dword ptr [rbx], eax
-       lea      rsi, [(reloc)]
-       cmp      qword ptr [rsi-0x08], 0
-       jne      SHORT G_M8951_IG06
-						;; size=35 bbWeight=1 PerfScore 11.00
-G_M8951_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     System.Buffers.SharedArrayPoolStatics:GetMaxArraysPerPartition():int
        ; gcr arg pop 0
-       mov      dword ptr [rsi+0x04], eax
-						;; size=8 bbWeight=1 PerfScore 2.00
+       mov      dword ptr [rbx+0x04], eax
+						;; size=15 bbWeight=1 PerfScore 4.00
 G_M8951_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
-       pop      rsi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 G_M8951_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       call     CORINFO_HELP_READYTORUN_NONGCSTATIC_BASE
-       ; byrRegs +[rax]
-       ; gcr arg pop 0
-       call     System.Buffers.SharedArrayPoolStatics:GetPartitionCount():int
-       ; byrRegs -[rax]
-       ; gcr arg pop 0
-       mov      dword ptr [rbx], eax
-       lea      rsi, [(reloc)]
-       cmp      qword ptr [rsi-0x08], 0
-       je       SHORT G_M8951_IG03
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M8951_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[rbx]
        call     CORINFO_HELP_READYTORUN_NONGCSTATIC_BASE
        ; byrRegs +[rax]
        ; gcr arg pop 0
        jmp      SHORT G_M8951_IG03
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 89, prolog size 6, PerfScore 17.50, instruction count 25, allocated bytes for code 89 (MethodHash=82dddd08) for method System.Buffers.SharedArrayPoolStatics:.cctor() (FullOpts)
+; Total bytes of code 47, prolog size 5, PerfScore 11.50, instruction count 14, allocated bytes for code 47 (MethodHash=82dddd08) for method System.Buffers.SharedArrayPoolStatics:.cctor() (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -67,11 +52,10 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x05
+  CountOfUnwindCodes: 2
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+50.00%</span>) : 26480.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,10 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  5   )   byref  ->  rcx         single-def
-;  V01 loc0         [V01,T01] (  2,  2   )     int  ->  rax         single-def
+;  V00 arg0         [V00,T00] (  4,  4   )   byref  ->  rcx         single-def
+;  V01 loc0         [V01,T02] (  2,  2   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,14 +19,16 @@ G_M44569_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M44569_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
        mov      rax, qword ptr [rcx]
-       mov      eax, dword ptr [rax]
-       add      qword ptr [rcx], 4
-						;; size=9 bbWeight=1 PerfScore 7.00
+       mov      edx, dword ptr [rax]
+       add      rax, 4
+       mov      qword ptr [rcx], rax
+       mov      eax, edx
+						;; size=14 bbWeight=1 PerfScore 5.50
 G_M44569_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 8.00, instruction count 4, allocated bytes for code 10 (MethodHash=86ad51e6) for method Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)
+; Total bytes of code 15, prolog size 0, PerfScore 6.50, instruction count 6, allocated bytes for code 15 (MethodHash=86ad51e6) for method Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+50.00%</span>) : 26270.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt8(byref):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,10 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  5   )   byref  ->  rcx         single-def
-;  V01 loc0         [V01,T01] (  2,  2   )   ubyte  ->  rax         single-def
+;  V00 arg0         [V00,T00] (  4,  4   )   byref  ->  rcx         single-def
+;  V01 loc0         [V01,T02] (  2,  2   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,14 +19,16 @@ G_M64121_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M64121_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
        mov      rax, qword ptr [rcx]
-       movzx    rax, byte  ptr [rax]
-       inc      qword ptr [rcx]
-						;; size=9 bbWeight=1 PerfScore 7.00
+       movzx    rdx, byte  ptr [rax]
+       inc      rax
+       mov      qword ptr [rcx], rax
+       mov      eax, edx
+						;; size=14 bbWeight=1 PerfScore 5.50
 G_M64121_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 8.00, instruction count 4, allocated bytes for code 10 (MethodHash=f60a0586) for method Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt8(byref):ubyte (FullOpts)
+; Total bytes of code 15, prolog size 0, PerfScore 6.50, instruction count 6, allocated bytes for code 15 (MethodHash=f60a0586) for method Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt8(byref):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+54.55%</span>) : 25527.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt64(byref):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,9 +7,10 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  5,  5   )   byref  ->  rcx         single-def
-;  V01 loc0         [V01,T01] (  2,  2   )    long  ->  rax        
+;  V00 arg0         [V00,T00] (  4,  4   )   byref  ->  rcx         single-def
+;  V01 loc0         [V01,T02] (  2,  2   )    long  ->  rdx        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V03 cse0         [V03,T01] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
@@ -18,14 +19,16 @@ G_M59587_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M59587_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
        mov      rax, qword ptr [rcx]
-       mov      rax, qword ptr [rax]
-       add      qword ptr [rcx], 8
-						;; size=10 bbWeight=1 PerfScore 7.00
+       mov      rdx, qword ptr [rax]
+       add      rax, 8
+       mov      qword ptr [rcx], rax
+       mov      rax, rdx
+						;; size=16 bbWeight=1 PerfScore 5.50
 G_M59587_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 11, prolog size 0, PerfScore 8.00, instruction count 4, allocated bytes for code 11 (MethodHash=d8d9173c) for method Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt64(byref):ulong (FullOpts)
+; Total bytes of code 17, prolog size 0, PerfScore 6.50, instruction count 6, allocated bytes for code 17 (MethodHash=d8d9173c) for method Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt64(byref):ulong (FullOpts)
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
|benchmarks.run.windows.x64.checked.mch|15,560|<span style="color:green">11,219</span>|<span style="color:red">3,866</span>|<span style="color:blue">475</span>|<span style="color:green">-407,354</span>|<span style="color:red">+53,823</span>|<span style="color:green">-2.9413%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|16,840|<span style="color:green">8,839</span>|<span style="color:red">6,837</span>|<span style="color:blue">1,164</span>|<span style="color:green">-161,557</span>|<span style="color:red">+101,690</span>|<span style="color:green">-2.6220%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|5,603|<span style="color:green">4,258</span>|<span style="color:red">1,210</span>|<span style="color:blue">135</span>|<span style="color:green">-85,813</span>|<span style="color:red">+18,316</span>|<span style="color:green">-1.3456%</span>|
|coreclr_tests.run.windows.x64.checked.mch|139,688|<span style="color:green">118,037</span>|<span style="color:red">19,027</span>|<span style="color:blue">2,624</span>|<span style="color:green">-7,702,600</span>|<span style="color:red">+182,996</span>|<span style="color:green">-3.2196%</span>|
|libraries.crossgen2.windows.x64.checked.mch|71,192|<span style="color:green">53,130</span>|<span style="color:red">16,384</span>|<span style="color:blue">1,678</span>|<span style="color:green">-1,145,359</span>|<span style="color:red">+167,817</span>|<span style="color:green">-2.3811%</span>|
|libraries.pmi.windows.x64.checked.mch|76,592|<span style="color:green">56,380</span>|<span style="color:red">17,829</span>|<span style="color:blue">2,383</span>|<span style="color:green">-2,133,080</span>|<span style="color:red">+176,264</span>|<span style="color:green">-1.9069%</span>|
|libraries_tests.run.windows.x64.Release.mch|91,749|<span style="color:green">51,697</span>|<span style="color:red">35,398</span>|<span style="color:blue">4,654</span>|<span style="color:green">-1,108,742</span>|<span style="color:red">+722,546</span>|<span style="color:green">-2.7593%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|115,628|<span style="color:green">90,191</span>|<span style="color:red">22,688</span>|<span style="color:blue">2,749</span>|<span style="color:green">-3,721,530</span>|<span style="color:red">+523,361</span>|<span style="color:green">-1.3135%</span>|
|realworld.run.windows.x64.checked.mch|12,386|<span style="color:green">8,309</span>|<span style="color:red">3,622</span>|<span style="color:blue">455</span>|<span style="color:green">-282,558</span>|<span style="color:red">+73,947</span>|<span style="color:green">-2.1482%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|7,351|<span style="color:green">4,465</span>|<span style="color:red">2,506</span>|<span style="color:blue">380</span>|<span style="color:green">-104,623</span>|<span style="color:red">+25,718</span>|<span style="color:green">-2.4308%</span>|
||552,589|<span style="color:green">406,525</span>|<span style="color:red">129,367</span>|<span style="color:blue">16,697</span>|<span style="color:green">-16,853,216</span>|<span style="color:red">+2,046,478</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,911|4|35,907|133 (0.37%)|188 (0.52%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,827|49,607|52,220|28 (0.03%)|33 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|55,006|37,307|17,699|26 (0.05%)|36 (0.07%)|
|coreclr_tests.run.windows.x64.checked.mch|581,517|347,882|233,635|2,461 (0.42%)|2,567 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,663|15|275,648|106 (0.04%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|313,061|6|313,055|924 (0.29%)|1,206 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|697,473|498,513|198,960|2,534 (0.36%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|320,747|21,946|298,801|148 (0.05%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,684|3|36,681|208 (0.56%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,535|11|32,524|43 (0.13%)|41 (0.13%)|
||2,450,424|955,294|1,495,130|6,611 (0.27%)|7,147 (0.29%)|


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

Total bytes of base: 11770463 (overridden on cmd)
Total bytes of diff: 11416932 (overridden on cmd)
Total bytes of delta: -353531 (-3.00 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         739 : 35459.dasm (53.43% of base)
         732 : 5146.dasm (6.97% of base)
         726 : 15042.dasm (6.94% of base)
         632 : 3856.dasm (3.78% of base)
         420 : 8554.dasm (12.20% of base)
         325 : 3919.dasm (16.23% of base)
         325 : 19339.dasm (16.23% of base)
         324 : 25179.dasm (9.77% of base)
         319 : 23673.dasm (7.56% of base)
         316 : 23775.dasm (7.25% of base)
         278 : 22491.dasm (23.50% of base)
         245 : 26366.dasm (1.83% of base)
         237 : 26344.dasm (10.42% of base)
         235 : 7449.dasm (2.32% of base)
         222 : 7014.dasm (5.92% of base)
         217 : 5948.dasm (2.02% of base)
         211 : 7026.dasm (14.07% of base)
         211 : 20589.dasm (14.07% of base)
         206 : 5938.dasm (1.99% of base)
         200 : 32032.dasm (3.35% of base)

Top file improvements (bytes):
       -9847 : 34822.dasm (-76.52% of base)
       -3667 : 3668.dasm (-9.88% of base)
       -3133 : 8780.dasm (-9.32% of base)
       -2887 : 4585.dasm (-18.07% of base)
       -2887 : 13944.dasm (-18.07% of base)
       -2348 : 28695.dasm (-74.66% of base)
       -2228 : 17951.dasm (-9.82% of base)
       -2228 : 3163.dasm (-9.82% of base)
       -2024 : 18258.dasm (-32.77% of base)
       -2024 : 3508.dasm (-32.77% of base)
       -2000 : 1408.dasm (-15.81% of base)
       -2000 : 17124.dasm (-15.81% of base)
       -1909 : 24106.dasm (-18.27% of base)
       -1730 : 34863.dasm (-61.17% of base)
       -1730 : 35628.dasm (-58.53% of base)
       -1694 : 15276.dasm (-57.56% of base)
       -1694 : 11508.dasm (-60.18% of base)
       -1675 : 20700.dasm (-59.36% of base)
       -1675 : 21690.dasm (-56.78% of base)
       -1647 : 24028.dasm (-34.01% of base)

93 total files with Code Size differences (53 improved, 40 regressed), 20 unchanged.

Top method regressions (bytes):
         739 (53.43% of base) : 35459.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
         732 ( 6.97% of base) : 5146.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
         726 ( 6.94% of base) : 15042.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
         632 ( 3.78% of base) : 3856.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         420 (12.20% of base) : 8554.dasm - MessagePack.Internal.DynamicObjectTypeBuilder:BuildDeserialize(System.Type,MessagePack.Internal.ObjectSerializationInfo,System.Reflection.Emit.ILGenerator,System.Func`3[int,MessagePack.Internal.ObjectSerializationInfo+EmittableMember,System.Action],int) (FullOpts)
         325 (16.23% of base) : 3919.dasm - Microsoft.Extensions.DependencyInjection.ActivatorUtilities:BuildFactoryExpression(System.Reflection.ConstructorInfo,System.Nullable`1[int][],System.Linq.Expressions.Expression,System.Linq.Expressions.Expression):System.Linq.Expressions.BlockExpression (FullOpts)
         325 (16.23% of base) : 19339.dasm - Microsoft.Extensions.DependencyInjection.ActivatorUtilities:BuildFactoryExpression(System.Reflection.ConstructorInfo,System.Nullable`1[int][],System.Linq.Expressions.Expression,System.Linq.Expressions.Expression):System.Linq.Expressions.BlockExpression (FullOpts)
         324 ( 9.77% of base) : 25179.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseNamespaceBody(byref,byref,byref,ushort):this (FullOpts)
         319 ( 7.56% of base) : 23673.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         316 ( 7.25% of base) : 23775.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         278 (23.50% of base) : 22491.dasm - AssignRect:first_assignments(int[,],short[,]):int (FullOpts)
         245 ( 1.83% of base) : 26366.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:AddNonTypeMembers(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+DeclaredMembersAndInitializersBuilder,Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (FullOpts)
         237 (10.42% of base) : 26344.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MakeAcyclicInterfaces(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol]:this (FullOpts)
         235 ( 2.32% of base) : 7449.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_MyEventsListerItemFormatter2:Serialize(byref,MicroBenchmarks.Serializers.MyEventsListerItem,Utf8Json.IJsonFormatterResolver):this (FullOpts)
         222 ( 5.92% of base) : 7014.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (FullOpts)
         217 ( 2.02% of base) : 5948.dasm - Utf8Json.Formatters.ISO8601DateTimeOffsetFormatter:Serialize(byref,System.DateTimeOffset,Utf8Json.IJsonFormatterResolver):this (FullOpts)
         211 (14.07% of base) : 7026.dasm - System.Text.Json.Serialization.Converters.ObjectWithParameterizedConstructorConverter`1[System.__Canon]:TryLookupConstructorParameter(System.ReadOnlySpan`1[ubyte],byref,byref,System.Text.Json.JsonSerializerOptions,byref):ubyte:this (FullOpts)
         211 (14.07% of base) : 20589.dasm - System.Text.Json.Serialization.Converters.ObjectWithParameterizedConstructorConverter`1[System.__Canon]:TryLookupConstructorParameter(System.ReadOnlySpan`1[ubyte],byref,byref,System.Text.Json.JsonSerializerOptions,byref):ubyte:this (FullOpts)
         206 ( 1.99% of base) : 5938.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_ActiveOrUpcomingEventFormatter2:Serialize(byref,MicroBenchmarks.Serializers.ActiveOrUpcomingEvent,Utf8Json.IJsonFormatterResolver):this (FullOpts)
         200 ( 3.35% of base) : 32032.dasm - (dynamicClass):_DynamicMethod5(byref):int (FullOpts)

Top method improvements (bytes):
       -9847 (-76.52% of base) : 34822.dasm - HardwareIntrinsics.RayTracer.Packet256Tracer:GetNaturalColor(System.Runtime.Intrinsics.Vector256`1[int],HardwareIntrinsics.RayTracer.VectorPacket256,HardwareIntrinsics.RayTracer.VectorPacket256,HardwareIntrinsics.RayTracer.VectorPacket256,HardwareIntrinsics.RayTracer.Scene):HardwareIntrinsics.RayTracer.VectorPacket256:this (FullOpts)
       -3667 (-9.88% of base) : 3668.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
       -3133 (-9.32% of base) : 8780.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
       -2887 (-18.07% of base) : 4585.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -2887 (-18.07% of base) : 13944.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -2348 (-74.66% of base) : 28695.dasm - Benchstone.BenchF.Lorenz:Test():ubyte:this (FullOpts)
       -2228 (-9.82% of base) : 17951.dasm - Jil.Options:.cctor() (FullOpts)
       -2228 (-9.82% of base) : 3163.dasm - Jil.Options:.cctor() (FullOpts)
       -2024 (-32.77% of base) : 18258.dasm - Sigil.Emit`1[System.__Canon]:ValidateTryCatchFinallyBranches():this (FullOpts)
       -2024 (-32.77% of base) : 3508.dasm - Sigil.Emit`1[System.__Canon]:ValidateTryCatchFinallyBranches():this (FullOpts)
       -2000 (-15.81% of base) : 1408.dasm - System.Text.RegularExpressions.RegexCompiler:.cctor() (FullOpts)
       -2000 (-15.81% of base) : 17124.dasm - System.Text.RegularExpressions.RegexCompiler:.cctor() (FullOpts)
       -1909 (-18.27% of base) : 24106.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.Location,int) (FullOpts)
       -1730 (-58.53% of base) : 35628.dasm - System.Memory.Slice`1[System.__Canon]:MemoryStartLengthSpan():System.Memory`1[System.__Canon]:this (FullOpts)
       -1730 (-61.17% of base) : 34863.dasm - System.Memory.Slice`1[System.__Canon]:MemoryStartSpan():System.Memory`1[System.__Canon]:this (FullOpts)
       -1694 (-57.56% of base) : 15276.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlyMemoryStartLengthSpan():System.ReadOnlyMemory`1[System.__Canon]:this (FullOpts)
       -1694 (-60.18% of base) : 11508.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlyMemoryStartSpan():System.ReadOnlyMemory`1[System.__Canon]:this (FullOpts)
       -1675 (-59.36% of base) : 20700.dasm - System.Memory.Slice`1[System.__Canon]:MemorySpanStart():System.Memory`1[System.__Canon]:this (FullOpts)
       -1675 (-56.78% of base) : 21690.dasm - System.Memory.Slice`1[System.__Canon]:MemorySpanStartLength():System.Memory`1[System.__Canon]:this (FullOpts)
       -1647 (-34.01% of base) : 24028.dasm - System.Diagnostics.Tracing.PropertyValue:GetFactory(System.Type):System.Func`2[System.Object,System.Diagnostics.Tracing.PropertyValue] (FullOpts)

Top method regressions (percentages):
         739 (53.43% of base) : 35459.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
          20 (52.63% of base) : 29288.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          20 (47.62% of base) : 29379.dasm - System.Numerics.Tests.Perf_Matrix3x2:CreateSkewFromScalarXYWithCenterBenchmark():System.Numerics.Matrix3x2:this (FullOpts)
          28 (46.67% of base) : 35433.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
         142 (34.98% of base) : 16301.dasm - Benchstone.BenchF.Adams:Bench() (FullOpts)
         125 (32.81% of base) : 23009.dasm - Benchstone.BenchF.DMath:Bench(int):ubyte (FullOpts)
          68 (32.23% of base) : 31477.dasm - Benchstone.BenchF.Simpsn:Test():ubyte:this (FullOpts)
           6 (27.27% of base) : 12867.dasm - System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (FullOpts)
           6 (27.27% of base) : 510.dasm - System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (FullOpts)
          12 (24.00% of base) : 35848.dasm - System.Reflection.Invoke:Ctor0_ActivatorCreateInstance_NoParams():this (FullOpts)
         278 (23.50% of base) : 22491.dasm - AssignRect:first_assignments(int[,],short[,]):int (FullOpts)
          36 (21.30% of base) : 5765.dasm - System.Reflection.Emit.TypeNameBuilder:EscapeName(System.String):this (FullOpts)
          36 (21.30% of base) : 18879.dasm - System.Reflection.Emit.TypeNameBuilder:EscapeName(System.String):this (FullOpts)
           6 (20.69% of base) : 1797.dasm - System.Text.Json.Serialization.JsonConverter:set_ConverterStrategy(ubyte):this (FullOpts)
           6 (20.69% of base) : 15837.dasm - System.Text.Json.Serialization.JsonConverter:set_ConverterStrategy(ubyte):this (FullOpts)
          19 (20.21% of base) : 6524.dasm - GuardedDevirtualization.ThreeClassInterface+TestInput:<.ctor>b__4_0(double):GuardedDevirtualization.ThreeClassInterface+B:this (FullOpts)
          19 (20.21% of base) : 15741.dasm - GuardedDevirtualization.ThreeClassVirtual+TestInput:<.ctor>b__4_0(double):GuardedDevirtualization.ThreeClassVirtual+B:this (FullOpts)
          19 (20.21% of base) : 11577.dasm - GuardedDevirtualization.ThreeClassVirtual+TestInput:<.ctor>b__4_0(double):GuardedDevirtualization.ThreeClassVirtual+B:this (FullOpts)
          56 (18.86% of base) : 7982.dasm - BilinearTest:Setup():this (FullOpts)
          65 (18.41% of base) : 32246.dasm - Benchstone.MDBenchI.MDGeneralArray:Bench(int,int[,,],int[,,]):ubyte (FullOpts)

Top method improvements (percentages):
       -9847 (-76.52% of base) : 34822.dasm - HardwareIntrinsics.RayTracer.Packet256Tracer:GetNaturalColor(System.Runtime.Intrinsics.Vector256`1[int],HardwareIntrinsics.RayTracer.VectorPacket256,HardwareIntrinsics.RayTracer.VectorPacket256,HardwareIntrinsics.RayTracer.VectorPacket256,HardwareIntrinsics.RayTracer.Scene):HardwareIntrinsics.RayTracer.VectorPacket256:this (FullOpts)
       -2348 (-74.66% of base) : 28695.dasm - Benchstone.BenchF.Lorenz:Test():ubyte:this (FullOpts)
       -1010 (-74.48% of base) : 6618.dasm - V8.Crypto.BigInteger:setupEngine(V8.Crypto.BigInteger+AMSig,int) (FullOpts)
       -1037 (-66.95% of base) : 23500.dasm - NeuralJagged:Init() (FullOpts)
       -1730 (-61.17% of base) : 34863.dasm - System.Memory.Slice`1[System.__Canon]:MemoryStartSpan():System.Memory`1[System.__Canon]:this (FullOpts)
       -1694 (-60.18% of base) : 11508.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlyMemoryStartSpan():System.ReadOnlyMemory`1[System.__Canon]:this (FullOpts)
       -1154 (-59.79% of base) : 9616.dasm - System.Memory.Slice`1[System.__Canon]:SpanStart():System.Span`1[System.__Canon]:this (FullOpts)
       -1154 (-59.42% of base) : 34858.dasm - System.Memory.Slice`1[System.__Canon]:MemoryStart():System.Memory`1[System.__Canon]:this (FullOpts)
       -1675 (-59.36% of base) : 20700.dasm - System.Memory.Slice`1[System.__Canon]:MemorySpanStart():System.Memory`1[System.__Canon]:this (FullOpts)
       -1730 (-58.53% of base) : 35628.dasm - System.Memory.Slice`1[System.__Canon]:MemoryStartLengthSpan():System.Memory`1[System.__Canon]:this (FullOpts)
       -1118 (-58.38% of base) : 32117.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlySpanStart():System.ReadOnlySpan`1[System.__Canon]:this (FullOpts)
       -1639 (-58.35% of base) : 22420.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlyMemorySpanStart():System.ReadOnlyMemory`1[System.__Canon]:this (FullOpts)
       -1118 (-57.96% of base) : 35985.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlyMemoryStart():System.ReadOnlyMemory`1[System.__Canon]:this (FullOpts)
        -208 (-57.78% of base) : 8767.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.MyEventsListerItem(System.Object):ulong[] (FullOpts)
       -1694 (-57.56% of base) : 15276.dasm - System.Memory.Slice`1[System.__Canon]:ReadOnlyMemoryStartLengthSpan():System.ReadOnlyMemory`1[System.__Canon]:this (FullOpts)
        -137 (-57.08% of base) : 30361.dasm - PerfLabTests.CastingPerf2.CastingPerf:FooObjIsNull():this (FullOpts)
        -137 (-57.08% of base) : 30973.dasm - PerfLabTests.CastingPerf2.CastingPerf:IFooFooIsIFoo():this (FullOpts)
        -137 (-57.08% of base) : 29560.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjFooIsObj():this (FullOpts)
       -1675 (-56.78% of base) : 21690.dasm - System.Memory.Slice`1[System.__Canon]:MemorySpanStartLength():System.Memory`1[System.__Canon]:this (FullOpts)
         -82 (-56.55% of base) : 21402.dasm - System.Xml.Serialization.XmlCustomFormatter:get_Mode():int (FullOpts)

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

Total bytes of base: 35516880 (overridden on cmd)
Total bytes of diff: 35457013 (overridden on cmd)
Total bytes of delta: -59867 (-0.17 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         769 : 96567.dasm (55.60% of base)
         632 : 15282.dasm (3.78% of base)
         491 : 95297.dasm (6.82% of base)
         435 : 91834.dasm (4.95% of base)
         435 : 50403.dasm (9.27% of base)
         433 : 54513.dasm (13.05% of base)
         430 : 97848.dasm (6.01% of base)
         413 : 92229.dasm (12.11% of base)
         412 : 88053.dasm (4.69% of base)
         375 : 73708.dasm (8.49% of base)
         375 : 55697.dasm (8.49% of base)
         375 : 75811.dasm (8.49% of base)
         367 : 51769.dasm (8.43% of base)
         367 : 85466.dasm (8.43% of base)
         367 : 48682.dasm (8.43% of base)
         367 : 26246.dasm (8.43% of base)
         356 : 87014.dasm (10.05% of base)
         353 : 49678.dasm (8.10% of base)
         346 : 88245.dasm (10.14% of base)
         342 : 51040.dasm (7.63% of base)

Top file improvements (bytes):
       -3667 : 14942.dasm (-9.88% of base)
       -3133 : 26827.dasm (-9.32% of base)
       -1909 : 50832.dasm (-18.27% of base)
       -1029 : 38016.dasm (-7.93% of base)
        -802 : 51863.dasm (-33.40% of base)
        -568 : 73162.dasm (-16.52% of base)
        -565 : 39024.dasm (-22.17% of base)
        -535 : 77490.dasm (-8.38% of base)
        -510 : 96163.dasm (-14.08% of base)
        -510 : 15299.dasm (-14.19% of base)
        -507 : 37302.dasm (-13.31% of base)
        -499 : 96162.dasm (-4.75% of base)
        -497 : 38032.dasm (-6.70% of base)
        -493 : 96160.dasm (-10.29% of base)
        -482 : 49098.dasm (-10.46% of base)
        -480 : 73161.dasm (-19.41% of base)
        -480 : 73148.dasm (-19.41% of base)
        -408 : 86553.dasm (-23.62% of base)
        -401 : 98304.dasm (-19.68% of base)
        -359 : 98303.dasm (-14.31% of base)

99 total files with Code Size differences (48 improved, 51 regressed), 20 unchanged.

Top method regressions (bytes):
         769 (55.60% of base) : 96567.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         632 ( 3.78% of base) : 15282.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         491 ( 6.82% of base) : 95297.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:.ctor(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],int,System.Text.RegularExpressions.RegexFindOptimizations,System.TimeSpan):this (Tier1)
         435 ( 9.27% of base) : 50403.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         435 ( 4.95% of base) : 91834.dasm - System.Text.RegularExpressions.RegexLWCGCompiler:FactoryInstanceFromCode(System.String,System.Text.RegularExpressions.RegexTree,int,ubyte):System.Text.RegularExpressions.RegexRunnerFactory:this (Tier1)
         433 (13.05% of base) : 54513.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
         430 ( 6.01% of base) : 97848.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:.ctor(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],int,System.Text.RegularExpressions.RegexFindOptimizations,System.TimeSpan):this (Tier1)
         413 (12.11% of base) : 92229.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength4To7,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1)
         412 ( 4.69% of base) : 88053.dasm - System.Text.RegularExpressions.RegexLWCGCompiler:FactoryInstanceFromCode(System.String,System.Text.RegularExpressions.RegexTree,int,ubyte):System.Text.RegularExpressions.RegexRunnerFactory:this (Tier1)
         375 ( 8.49% of base) : 73708.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         375 ( 8.49% of base) : 55697.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         375 ( 8.49% of base) : 75811.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         367 ( 8.43% of base) : 51769.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         367 ( 8.43% of base) : 85466.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         367 ( 8.43% of base) : 48682.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         367 ( 8.43% of base) : 26246.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
         356 (10.05% of base) : 87014.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
         353 ( 8.10% of base) : 49678.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         346 (10.14% of base) : 88245.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength4To7,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1)
         342 ( 7.63% of base) : 51040.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method improvements (bytes):
       -3667 (-9.88% of base) : 14942.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
       -3133 (-9.32% of base) : 26827.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
       -1909 (-18.27% of base) : 50832.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.Location,int) (FullOpts)
       -1029 (-7.93% of base) : 38016.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
        -802 (-33.40% of base) : 51863.dasm - LUDecomp:build_problem(double[][],int,double[]) (Tier1)
        -568 (-16.52% of base) : 73162.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1)
        -565 (-22.17% of base) : 39024.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.LoginViewModel,int) (FullOpts)
        -535 (-8.38% of base) : 77490.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.Location (FullOpts)
        -510 (-14.08% of base) : 96163.dasm - (dynamicClass):_DynamicMethod4(System.IO.TextReader):int (FullOpts)
        -510 (-14.19% of base) : 15299.dasm - (dynamicClass):_DynamicMethod4(System.IO.TextReader):int (FullOpts)
        -507 (-13.31% of base) : 37302.dasm - EMFloatClass:SetupCPUEmFloatArrays(EMFloatClass+InternalFPF[],EMFloatClass+InternalFPF[],EMFloatClass+InternalFPF[],int) (Tier1-OSR)
        -499 (-4.75% of base) : 96162.dasm - (dynamicClass):_DynamicMethod3(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerItem (FullOpts)
        -497 (-6.70% of base) : 38032.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.CollectionsOfPrimitives (FullOpts)
        -493 (-10.29% of base) : 96160.dasm - (dynamicClass):_DynamicMethod9(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerViewModel (FullOpts)
        -482 (-10.46% of base) : 49098.dasm - NeuralJagged:read_data_file():this (Tier1)
        -480 (-19.41% of base) : 73161.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -480 (-19.41% of base) : 73148.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -408 (-23.62% of base) : 86553.dasm - System.Threading.LowLevelLock:WaitAndAcquire():this (Tier1)
        -401 (-19.68% of base) : 98304.dasm - NumericSortJagged:DoNumSortIteration(int[][],int,int):int (Tier1)
        -359 (-14.31% of base) : 98303.dasm - NumericSortJagged:Run():double:this (Tier1)

Top method regressions (percentages):
         769 (55.60% of base) : 96567.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
          31 (49.21% of base) : 29951.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          31 (49.21% of base) : 36153.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          31 (49.21% of base) : 91604.dasm - PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
          31 (49.21% of base) : 96133.dasm - PerfLabTests.CastingPerf:ObjFooIsObj2():this (Tier1-OSR)
          31 (49.21% of base) : 47138.dasm - PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
          31 (49.21% of base) : 55268.dasm - PerfLabTests.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
          31 (49.21% of base) : 50344.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
          31 (49.21% of base) : 78064.dasm - PerfLabTests.CastingPerf2.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          31 (49.21% of base) : 80418.dasm - PerfLabTests.CastingPerf2.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          31 (49.21% of base) : 73588.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
           9 (39.13% of base) : 36908.dasm - ProtoBuf.Serializers.SerializerFeaturesExtensions:InheritFrom(byref,int) (FullOpts)
          10 (31.25% of base) : 19519.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 29788.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 26142.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 101536.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 83644.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 33916.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 8510.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 75679.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)

Top method improvements (percentages):
        -216 (-58.54% of base) : 26809.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.MyEventsListerItem(System.Object):ulong[] (FullOpts)
        -189 (-56.59% of base) : 14874.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.ActiveOrUpcomingEvent(System.Object):ulong[] (FullOpts)
        -135 (-51.14% of base) : 14917.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.CampaignSummaryViewModel(System.Object):ulong[] (FullOpts)
         -11 (-44.00% of base) : 22731.dasm - System.Math:Max(short,short):short (Tier1)
         -11 (-44.00% of base) : 95549.dasm - System.Math:Min(short,short):short (Tier1)
         -11 (-44.00% of base) : 25309.dasm - System.Math:Min(short,short):short (Tier1)
         -11 (-44.00% of base) : 26204.dasm - System.Math:Min(short,short):short (Tier1)
         -11 (-44.00% of base) : 50169.dasm - System.Math:Min(short,short):short (Tier1)
         -81 (-41.75% of base) : 37992.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.CollectionsOfPrimitives(System.Object):ulong[] (FullOpts)
        -153 (-39.95% of base) : 8394.dasm - System.Threading.ExecutionContext:CheckThreadPoolAndContextsAreDefault() (Tier1)
        -269 (-38.93% of base) : 51012.dasm - Neural:DoNNET(NNetStruct):double:this (Tier1)
        -269 (-38.93% of base) : 49096.dasm - NeuralJagged:DoNNET(NNetStruct):double:this (Tier1)
          -9 (-37.50% of base) : 67505.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:Peek[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]):System.__Canon (Tier1)
        -196 (-36.98% of base) : 45115.dasm - AssignRect:LoadAssign(int[,]) (Tier1)
          -4 (-36.36% of base) : 18808.dasm - System.Net.Sockets.Socket:get_SafeHandle():System.Net.Sockets.SafeSocketHandle:this (Tier1)
         -69 (-34.67% of base) : 51859.dasm - ByteMark:abs_randwc(int):int (Tier1)
         -69 (-34.67% of base) : 49059.dasm - ByteMark:abs_randwc(int):int (Tier1)
         -69 (-34.67% of base) : 101453.dasm - ByteMark:abs_randwc(int):int (Tier1)
         -69 (-34.67% of base) : 51010.dasm - ByteMark:abs_randwc(int):int (Tier1)
         -69 (-34.67% of base) : 41958.dasm - ByteMark:abs_randwc(int):int (Tier1)

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

Total bytes of base: 12778740 (overridden on cmd)
Total bytes of diff: 12711243 (overridden on cmd)
Total bytes of delta: -67497 (-0.53 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         739 : 53708.dasm (53.43% of base)
         632 : 17028.dasm (3.78% of base)
         498 : 53707.dasm (40.45% of base)
         327 : 54034.dasm (16.98% of base)
         319 : 31791.dasm (7.56% of base)
         316 : 31896.dasm (7.25% of base)
         278 : 29386.dasm (23.50% of base)
         212 : 30388.dasm (7.19% of base)
         200 : 49194.dasm (3.35% of base)
         200 : 48120.dasm (4.14% of base)
         200 : 45286.dasm (4.02% of base)
         200 : 48113.dasm (3.37% of base)
         200 : 48109.dasm (4.23% of base)
         190 : 29381.dasm (15.27% of base)
         176 : 45268.dasm (2.08% of base)
         169 : 24479.dasm (2.00% of base)
         164 : 53846.dasm (4.23% of base)
         144 : 49192.dasm (4.25% of base)
         136 : 32239.dasm (2.94% of base)
         134 : 40709.dasm (6.67% of base)

Top file improvements (bytes):
       -3667 : 16786.dasm (-9.88% of base)
       -3133 : 18079.dasm (-9.32% of base)
       -1909 : 31610.dasm (-18.27% of base)
       -1029 : 25881.dasm (-7.93% of base)
        -779 : 43603.dasm (-28.03% of base)
        -629 : 34454.dasm (-14.56% of base)
        -595 : 30627.dasm (-24.84% of base)
        -587 : 42524.dasm (-23.01% of base)
        -565 : 26779.dasm (-22.17% of base)
        -535 : 46227.dasm (-8.38% of base)
        -510 : 17038.dasm (-14.19% of base)
        -510 : 52750.dasm (-14.08% of base)
        -499 : 42519.dasm (-20.06% of base)
        -499 : 52749.dasm (-4.75% of base)
        -497 : 25889.dasm (-6.70% of base)
        -493 : 52747.dasm (-10.29% of base)
        -484 : 22902.dasm (-30.25% of base)
        -386 : 31369.dasm (-14.35% of base)
        -356 : 17035.dasm (-14.98% of base)
        -356 : 46228.dasm (-13.56% of base)

93 total files with Code Size differences (50 improved, 43 regressed), 20 unchanged.

Top method regressions (bytes):
         739 (53.43% of base) : 53708.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         632 ( 3.78% of base) : 17028.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         498 (40.45% of base) : 53707.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
         327 (16.98% of base) : 54034.dasm - Microsoft.Extensions.DependencyInjection.ActivatorUtilities:BuildFactoryExpression(System.Reflection.ConstructorInfo,System.Nullable`1[int][],System.Linq.Expressions.Expression,System.Linq.Expressions.Expression):System.Linq.Expressions.BlockExpression (Tier1)
         319 ( 7.56% of base) : 31791.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         316 ( 7.25% of base) : 31896.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         278 (23.50% of base) : 29386.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1)
         212 ( 7.19% of base) : 30388.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1-OSR)
         200 ( 4.02% of base) : 45286.dasm - (dynamicClass):_DynamicMethod3(byref):int (FullOpts)
         200 ( 4.23% of base) : 48109.dasm - (dynamicClass):_DynamicMethod3(byref):int (FullOpts)
         200 ( 3.35% of base) : 49194.dasm - (dynamicClass):_DynamicMethod5(byref):int (FullOpts)
         200 ( 3.37% of base) : 48113.dasm - (dynamicClass):_DynamicMethod5(byref):int (FullOpts)
         200 ( 4.14% of base) : 48120.dasm - (dynamicClass):_DynamicMethod7(byref):int (FullOpts)
         190 (15.27% of base) : 29381.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1-OSR)
         176 ( 2.08% of base) : 45268.dasm - System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1-OSR)
         169 ( 2.00% of base) : 24479.dasm - System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1)
         164 ( 4.23% of base) : 53846.dasm - (dynamicClass):_DynamicMethod3(byref):int (FullOpts)
         144 ( 4.25% of base) : 49192.dasm - (dynamicClass):_DynamicMethod11(byref):int (FullOpts)
         136 ( 2.94% of base) : 32239.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         134 ( 6.67% of base) : 40709.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbolExtensions:VisitType[System.__Canon](Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.Func`4[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.__Canon,ubyte,ubyte],System.Func`4[System.__Canon,System.__Canon,ubyte,ubyte],System.__Canon,ubyte,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (Tier1)

Top method improvements (bytes):
       -3667 (-9.88% of base) : 16786.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
       -3133 (-9.32% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
       -1909 (-18.27% of base) : 31610.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.Location,int) (FullOpts)
       -1029 (-7.93% of base) : 25881.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
        -779 (-28.03% of base) : 43603.dasm - System.Threading.ReaderWriterLockSlim:TryEnterReadLockCore(System.Threading.ReaderWriterLockSlim+TimeoutTracker):ubyte:this (Tier1)
        -629 (-14.56% of base) : 34454.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:ScanSyntaxToken(byref):this (Tier1)
        -595 (-24.84% of base) : 30627.dasm - NeuralJagged:read_data_file():this (Tier1)
        -587 (-23.01% of base) : 42524.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1)
        -565 (-22.17% of base) : 26779.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.LoginViewModel,int) (FullOpts)
        -535 (-8.38% of base) : 46227.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.Location (FullOpts)
        -510 (-14.19% of base) : 17038.dasm - (dynamicClass):_DynamicMethod4(System.IO.TextReader):int (FullOpts)
        -510 (-14.08% of base) : 52750.dasm - (dynamicClass):_DynamicMethod4(System.IO.TextReader):int (FullOpts)
        -499 (-4.75% of base) : 52749.dasm - (dynamicClass):_DynamicMethod3(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerItem (FullOpts)
        -499 (-20.06% of base) : 42519.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -497 (-6.70% of base) : 25889.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.CollectionsOfPrimitives (FullOpts)
        -493 (-10.29% of base) : 52747.dasm - (dynamicClass):_DynamicMethod9(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerViewModel (FullOpts)
        -484 (-30.25% of base) : 22902.dasm - System.Threading.LowLevelLock:WaitAndAcquire():this (Tier1)
        -386 (-14.35% of base) : 31369.dasm - Neural:read_data_file():this (Tier1)
        -356 (-14.98% of base) : 17035.dasm - (dynamicClass):_DynamicMethod2(System.IO.TextReader):int (FullOpts)
        -356 (-13.56% of base) : 46228.dasm - (dynamicClass):_DynamicMethod2(System.IO.TextReader):int (FullOpts)

Top method regressions (percentages):
         739 (53.43% of base) : 53708.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
          31 (49.21% of base) : 20331.dasm - PerfLabTests.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          31 (49.21% of base) : 25372.dasm - PerfLabTests.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          31 (49.21% of base) : 50122.dasm - PerfLabTests.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
          31 (49.21% of base) : 52565.dasm - PerfLabTests.CastingPerf:ObjFooIsObj2():this (Tier1-OSR)
          31 (49.21% of base) : 29494.dasm - PerfLabTests.CastingPerf:ObjInt():this (Tier1-OSR)
          31 (49.21% of base) : 41387.dasm - PerfLabTests.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
          31 (49.21% of base) : 31574.dasm - PerfLabTests.CastingPerf:ObjScalarValueType():this (Tier1-OSR)
          31 (49.21% of base) : 45958.dasm - PerfLabTests.CastingPerf2.CastingPerf:FooObjIsNull():this (Tier1-OSR)
          31 (49.21% of base) : 46928.dasm - PerfLabTests.CastingPerf2.CastingPerf:IFooFooIsIFoo():this (Tier1-OSR)
          31 (49.21% of base) : 44936.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjFooIsObj():this (Tier1-OSR)
         498 (40.45% of base) : 53707.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
           9 (39.13% of base) : 25329.dasm - ProtoBuf.Serializers.SerializerFeaturesExtensions:InheritFrom(byref,int) (FullOpts)
           5 (35.71% of base) : 47719.dasm - System.IO.Pipelines.PipeAwaitable:ObserveCancellation():ubyte:this (Tier1)
          10 (31.25% of base) : 9032.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
           4 (30.77% of base) : 22881.dasm - System.Threading.Tasks.Task+SetOnInvokeMres:.ctor():this (Tier1)
          42 (29.17% of base) : 49411.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjObjrefValueType():this (Tier1-OSR)
           6 (27.27% of base) : 41661.dasm - System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (Tier1)
          28 (26.92% of base) : 17406.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjInt():this (Tier1-OSR)
          28 (26.42% of base) : 33556.dasm - PerfLabTests.CastingPerf2.CastingPerf:ObjScalarValueType():this (Tier1-OSR)

Top method improvements (percentages):
        -208 (-57.78% of base) : 18062.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.MyEventsListerItem(System.Object):ulong[] (FullOpts)
        -182 (-55.83% of base) : 16724.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.ActiveOrUpcomingEvent(System.Object):ulong[] (FullOpts)
        -130 (-50.39% of base) : 16766.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.CampaignSummaryViewModel(System.Object):ulong[] (FullOpts)
         -10 (-45.45% of base) : 17587.dasm - System.Math:Max(ubyte,ubyte):ubyte (Tier1)
         -10 (-45.45% of base) : 48855.dasm - System.Math:Max(ushort,ushort):ushort (Tier1)
         -10 (-45.45% of base) : 22886.dasm - System.Math:Min(ushort,ushort):ushort (Tier1)
         -11 (-44.00% of base) : 8580.dasm - System.Math:Max(short,short):short (Tier1)
         -11 (-44.00% of base) : 9093.dasm - System.Math:Min(short,short):short (Tier1)
         -14 (-43.75% of base) : 42185.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -81 (-41.75% of base) : 25862.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.CollectionsOfPrimitives(System.Object):ulong[] (FullOpts)
         -14 (-38.89% of base) : 42186.dasm - System.Numerics.INumber`1[ushort]:Max(ushort,ushort):ushort (Tier1)
          -9 (-37.50% of base) : 40907.dasm - Microsoft.CodeAnalysis.ArrayBuilderExtensions:Peek[System.__Canon](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.__Canon]):System.__Canon (Tier1)
          -4 (-36.36% of base) : 8424.dasm - System.Net.Sockets.Socket:get_SafeHandle():System.Net.Sockets.SafeSocketHandle:this (Tier1)
         -52 (-33.33% of base) : 16597.dasm - (dynamicClass):_GetOffsetsInMemoryMicroBenchmarks.Serializers.IndexViewModel(System.Object):ulong[] (FullOpts)
        -117 (-33.05% of base) : 12646.dasm - System.Threading.ExecutionContext:CheckThreadPoolAndContextsAreDefault() (Tier1)
        -226 (-32.90% of base) : 46587.dasm - Jil.Common.ExtensionMethods:GetCustomAttribute[System.__Canon](System.Type):System.__Canon (Tier1)
         -64 (-32.82% of base) : 9133.dasm - System.Threading.PortableThreadPool:CreateThreadLocalCompletionCountObject():System.Object:this (Tier1)
         -69 (-31.80% of base) : 9124.dasm - System.Threading.ThreadPoolWorkQueue:CreateThreadLocals():System.Threading.ThreadPoolWorkQueueThreadLocals:this (Tier1)
         -39 (-31.71% of base) : 44233.dasm - System.Reflection.PortableExecutable.PEHeaders:GetContainingSectionIndex(int):int:this (Tier1)
         -99 (-30.75% of base) : 8726.dasm - Microsoft.Win32.SafeHandles.SafeCrypt32Handle`1[System.__Canon]:get_InvalidHandle():System.__Canon (Tier1)

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

Total bytes of base: 394219384 (overridden on cmd)
Total bytes of diff: 386699780 (overridden on cmd)
Total bytes of delta: -7519604 (-1.91 % of base)
    diff is an improvement.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         977 : 555651.dasm (6.47% of base)
         739 : 197503.dasm (53.43% of base)
         732 : 192711.dasm (6.97% of base)
         629 : 579858.dasm (17.84% of base)
         523 : 580495.dasm (11.50% of base)
         465 : 576835.dasm (10.20% of base)
         452 : 575312.dasm (12.61% of base)
         439 : 576726.dasm (7.89% of base)
         414 : 579823.dasm (11.72% of base)
         399 : 233647.dasm (19.49% of base)
         369 : 288458.dasm (3.62% of base)
         360 : 291216.dasm (2.00% of base)
         349 : 462307.dasm (11.00% of base)
         334 : 311277.dasm (12.80% of base)
         328 : 476358.dasm (20.88% of base)
         324 : 192241.dasm (9.77% of base)
         317 : 247974.dasm (37.12% of base)
         309 : 578561.dasm (5.26% of base)
         291 : 575856.dasm (14.47% of base)
         290 : 174141.dasm (10.56% of base)

Top file improvements (bytes):
      -21686 : 3183.dasm (-49.70% of base)
      -21453 : 3194.dasm (-48.93% of base)
      -21285 : 3205.dasm (-49.29% of base)
      -21202 : 3227.dasm (-49.00% of base)
      -21041 : 233201.dasm (-18.93% of base)
      -20414 : 233194.dasm (-19.24% of base)
      -19085 : 233862.dasm (-17.06% of base)
      -19084 : 233852.dasm (-16.91% of base)
      -19031 : 233215.dasm (-17.03% of base)
      -18497 : 3216.dasm (-41.77% of base)
      -18341 : 233847.dasm (-17.02% of base)
      -18263 : 233208.dasm (-17.02% of base)
      -17284 : 239227.dasm (-15.75% of base)
      -17284 : 239229.dasm (-15.75% of base)
      -17284 : 233422.dasm (-15.75% of base)
      -17284 : 233408.dasm (-15.75% of base)
      -17099 : 233857.dasm (-16.30% of base)
      -14630 : 189231.dasm (-53.60% of base)
      -12347 : 233012.dasm (-7.04% of base)
      -12347 : 233007.dasm (-7.04% of base)

101 total files with Code Size differences (61 improved, 40 regressed), 20 unchanged.

Top method regressions (bytes):
         977 ( 6.47% of base) : 555651.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
         739 (53.43% of base) : 197503.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
         732 ( 6.97% of base) : 192711.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
         629 (17.84% of base) : 579858.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:TryAddOrGetExisting(System.__Canon,byref):System.__Canon:this (Tier1)
         523 (11.50% of base) : 580495.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Comparison`1[System.__Canon]):int (Tier1)
         465 (10.20% of base) : 576835.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Comparison`1[System.__Canon]):int (Tier1)
         452 (12.61% of base) : 575312.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:TryGetValue(Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,byref):ubyte:this (Tier1)
         439 ( 7.89% of base) : 576726.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.DevirtualizationManager:ResolveVirtualMethod(Internal.TypeSystem.MethodDesc,Internal.TypeSystem.DefType,byref):Internal.TypeSystem.MethodDesc:this (Tier1)
         414 (11.72% of base) : 579823.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:TryGetValue(Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,byref):ubyte:this (Tier1)
         399 (19.49% of base) : 233647.dasm - string1:Process3DArray(System.String[,,]) (FullOpts)
         369 ( 3.62% of base) : 288458.dasm - ILCompiler.Win32Resources.ResourceData:WriteResources(ILCompiler.DependencyAnalysis.ISymbolNode,byref,byref):this (FullOpts)
         360 ( 2.00% of base) : 291216.dasm - HFATest.TestCase:TestEntryPoint():int (FullOpts)
         349 (11.00% of base) : 462307.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]],int,ubyte):this (Tier1)
         334 (12.80% of base) : 311277.dasm - BasicEventSourceTests.TestEventCounter+SimpleEventListener:OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs):this (FullOpts)
         328 (20.88% of base) : 476358.dasm - JitTest_lcs_gcref_port.LCSV:findLCS(JitTest_lcs_gcref_port.LCSV[,,,],JitTest_lcs_gcref_port.LCSV[,,,],ushort[][],JitTest_lcs_gcref_port.LCSV[]) (Tier1-OSR)
         324 ( 9.77% of base) : 192241.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseNamespaceBody(byref,byref,byref,ushort):this (FullOpts)
         317 (37.12% of base) : 247974.dasm - Test+Matrix4x4:TestEntryPoint():int (FullOpts)
         309 ( 5.26% of base) : 578561.dasm - ILCompiler.DependencyAnalysis.ReadyToRunObjectWriter:EmitObjectData(ILCompiler.PEWriter.R2RPEBuilder,ILCompiler.DependencyAnalysis.ObjectNode+ObjectData,int,System.String,ILCompiler.DependencyAnalysis.ObjectNodeSection):this (Tier1-OSR)
         291 (14.47% of base) : 575856.dasm - Internal.TypeSystem.InstantiatedType:ConvertToCanonFormImpl(int):Internal.TypeSystem.TypeDesc:this (Tier1)
         290 (10.56% of base) : 174141.dasm - Microsoft.CSharp.RuntimeBinder.Errors.ErrorHandling:Error(int,Microsoft.CSharp.RuntimeBinder.Errors.ErrArg[]):Microsoft.CSharp.RuntimeBinder.RuntimeBinderException (FullOpts)

Top method improvements (bytes):
      -21686 (-49.70% of base) : 3183.dasm - lclfldadd:TestEntryPoint():int (FullOpts)
      -21453 (-48.93% of base) : 3194.dasm - lclflddiv:TestEntryPoint():int (FullOpts)
      -21285 (-49.29% of base) : 3205.dasm - lclfldmul:TestEntryPoint():int (FullOpts)
      -21202 (-49.00% of base) : 3227.dasm - lclfldsub:TestEntryPoint():int (FullOpts)
      -21041 (-18.93% of base) : 233201.dasm - i4rem:TestEntryPoint():int (FullOpts)
      -20414 (-19.24% of base) : 233194.dasm - i4div:TestEntryPoint():int (FullOpts)
      -19085 (-17.06% of base) : 233862.dasm - u8rem:TestEntryPoint():int (FullOpts)
      -19084 (-16.91% of base) : 233852.dasm - u4rem:TestEntryPoint():int (FullOpts)
      -19031 (-17.03% of base) : 233215.dasm - i8rem:TestEntryPoint():int (FullOpts)
      -18497 (-41.77% of base) : 3216.dasm - lclfldrem:TestEntryPoint():int (FullOpts)
      -18341 (-17.02% of base) : 233847.dasm - u4div:TestEntryPoint():int (FullOpts)
      -18263 (-17.02% of base) : 233208.dasm - i8div:TestEntryPoint():int (FullOpts)
      -17284 (-15.75% of base) : 239227.dasm - overlddiv:TestEntryPoint():int (FullOpts)
      -17284 (-15.75% of base) : 233408.dasm - overlddiv:TestEntryPoint():int (FullOpts)
      -17284 (-15.75% of base) : 239229.dasm - overldrem:TestEntryPoint():int (FullOpts)
      -17284 (-15.75% of base) : 233422.dasm - overldrem:TestEntryPoint():int (FullOpts)
      -17099 (-16.30% of base) : 233857.dasm - u8div:TestEntryPoint():int (FullOpts)
      -14630 (-53.60% of base) : 189231.dasm - BufferMemmoveUnrolling:TestEntryPoint() (FullOpts)
      -12347 (-7.04% of base) : 233007.dasm - decimaldiv:TestEntryPoint():int (FullOpts)
      -12347 (-7.04% of base) : 233012.dasm - decimalrem:TestEntryPoint():int (FullOpts)

Top method regressions (percentages):
          69 (431.25% of base) : 232757.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          69 (431.25% of base) : 232038.dasm - Test_10w5d.testout1:Func_0_3_5_1():float (FullOpts)
          69 (431.25% of base) : 238475.dasm - Test_10w5d.testout1:Func_0_3_5_1():float (FullOpts)
          59 (368.75% of base) : 232808.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          59 (368.75% of base) : 236873.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          59 (368.75% of base) : 232807.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          59 (368.75% of base) : 236872.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          54 (337.50% of base) : 232820.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
          53 (331.25% of base) : 231448.dasm - Test_10w5d.testout1:Func_0_6_1_4():float (FullOpts)
          53 (331.25% of base) : 237886.dasm - Test_10w5d.testout1:Func_0_6_1_4():float (FullOpts)
           8 (133.33% of base) : 240771.dasm - ILGEN_939264028:main():int (FullOpts)
          10 (111.11% of base) : 190146.dasm - Repro.Tst:f01():this (FullOpts)
          10 (111.11% of base) : 447309.dasm - Repro.Tst:f01():this (Tier1)
          15 (107.14% of base) : 190442.dasm - Z:TestEntryPoint():int (FullOpts)
          16 (94.12% of base) : 190144.dasm - Repro.Tst:f02():this (FullOpts)
          16 (94.12% of base) : 447310.dasm - Repro.Tst:f02():this (Tier1)
          28 (84.85% of base) : 190162.dasm - Repro.Tst:f03():this (FullOpts)
          28 (84.85% of base) : 447311.dasm - Repro.Tst:f03():this (Tier1)
          52 (80.00% of base) : 190166.dasm - Repro.Tst:f04():this (FullOpts)
          52 (80.00% of base) : 447312.dasm - Repro.Tst:f04():this (Tier1)

Top method improvements (percentages):
         -15 (-78.95% of base) : 234556.dasm - InlineBool.Program:Id31(ubyte):ubyte (FullOpts)
        -486 (-77.64% of base) : 190536.dasm - Program:TestEntryPoint():int (FullOpts)
       -1147 (-77.34% of base) : 240928.dasm - foo:TestEntryPoint():int (FullOpts)
       -9847 (-76.52% of base) : 197585.dasm - Packet256Tracer:GetNaturalColor(System.Runtime.Intrinsics.Vector256`1[int],VectorPacket256,VectorPacket256,VectorPacket256,Scene):VectorPacket256:this (FullOpts)
        -630 (-74.73% of base) : 2745.dasm - NullableTest1:Run() (FullOpts)
       -2348 (-74.66% of base) : 197441.dasm - Benchstone.BenchF.Lorenz:Bench():ubyte (FullOpts)
        -473 (-74.49% of base) : 245858.dasm - TestClass:Method31():System.Runtime.Intrinsics.Vector256`1[int]:this (FullOpts)
       -1010 (-74.48% of base) : 196189.dasm - V8.Crypto.BigInteger:setupEngine(V8.Crypto.BigInteger+AMSig,int) (FullOpts)
        -251 (-74.26% of base) : 239528.dasm - Bug426480:foo() (FullOpts)
       -1586 (-73.56% of base) : 7560.dasm - CCSE:TestEntryPoint():int (FullOpts)
       -3101 (-73.29% of base) : 310892.dasm - Value4:CheckValues():ubyte:this (FullOpts)
        -168 (-73.04% of base) : 249094.dasm - AA:Static2():ubyte (FullOpts)
       -2886 (-72.90% of base) : 310893.dasm - Value4:.cctor() (FullOpts)
       -9745 (-71.35% of base) : 246130.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
       -2653 (-71.32% of base) : 310884.dasm - Value0:CheckValues():ubyte:this (FullOpts)
       -2452 (-70.83% of base) : 310885.dasm - Value0:.cctor() (FullOpts)
        -838 (-70.42% of base) : 3609.dasm - stfldstatic1:Main():int (FullOpts)
        -838 (-70.42% of base) : 3613.dasm - stfldstatic2:Main():int (FullOpts)
       -2653 (-70.39% of base) : 310886.dasm - Value1:CheckValues():ubyte:this (FullOpts)
       -2653 (-70.39% of base) : 310888.dasm - Value2:CheckValues():ubyte:this (FullOpts)

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

Total bytes of base: 46071735 (overridden on cmd)
Total bytes of diff: 45094193 (overridden on cmd)
Total bytes of delta: -977542 (-2.12 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1515 : 180261.dasm (6.26% of base)
        1348 : 186730.dasm (14.22% of base)
         924 : 186797.dasm (11.98% of base)
         776 : 157093.dasm (11.98% of base)
         688 : 140535.dasm (11.43% of base)
         566 : 207284.dasm (6.30% of base)
         561 : 185884.dasm (5.97% of base)
         557 : 211094.dasm (4.89% of base)
         555 : 164353.dasm (13.21% of base)
         543 : 157343.dasm (29.72% of base)
         520 : 163853.dasm (3.36% of base)
         484 : 186750.dasm (11.52% of base)
         461 : 274582.dasm (24.61% of base)
         428 : 156680.dasm (48.42% of base)
         378 : 190484.dasm (26.73% of base)
         378 : 221182.dasm (26.73% of base)
         365 : 40491.dasm (4.67% of base)
         363 : 186755.dasm (2.91% of base)
         338 : 154007.dasm (9.43% of base)
         335 : 2226.dasm (3.51% of base)

Top file improvements (bytes):
       -8646 : 36131.dasm (-9.45% of base)
       -6654 : 221690.dasm (-22.31% of base)
       -6654 : 191041.dasm (-22.31% of base)
       -3907 : 49512.dasm (-20.63% of base)
       -3874 : 35201.dasm (-20.11% of base)
       -3873 : 192275.dasm (-14.36% of base)
       -3873 : 222868.dasm (-14.36% of base)
       -3291 : 25299.dasm (-24.55% of base)
       -2609 : 24737.dasm (-20.42% of base)
       -2576 : 152248.dasm (-13.48% of base)
       -1824 : 169653.dasm (-29.32% of base)
       -1786 : 20616.dasm (-10.71% of base)
       -1767 : 36722.dasm (-8.07% of base)
       -1749 : 36400.dasm (-7.43% of base)
       -1610 : 38317.dasm (-4.67% of base)
       -1576 : 164576.dasm (-21.25% of base)
       -1556 : 164826.dasm (-20.96% of base)
       -1542 : 165044.dasm (-64.41% of base)
       -1542 : 165045.dasm (-64.41% of base)
       -1458 : 71544.dasm (-39.17% of base)

96 total files with Code Size differences (50 improved, 46 regressed), 20 unchanged.

Top method regressions (bytes):
        1515 ( 6.26% of base) : 180261.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
        1348 (14.22% of base) : 186730.dasm - System.Management.ManagementClassGenerator:GenerateProperties():this (FullOpts)
         924 (11.98% of base) : 186797.dasm - System.Management.ManagementClassGenerator:AddToDMTFDateTimeFunction():this (FullOpts)
         776 (11.98% of base) : 157093.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
         688 (11.43% of base) : 140535.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedReadOnlyListTypeSymbol:.ctor(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol,System.String,int,ubyte):this (FullOpts)
         566 ( 6.30% of base) : 207284.dasm - System.DirectoryServices.AccountManagement.ADAMStoreCtx:.cctor() (FullOpts)
         561 ( 5.97% of base) : 185884.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
         557 ( 4.89% of base) : 211094.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
         555 (13.21% of base) : 164353.dasm - System.Data.DataTable:DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo,ubyte):this (FullOpts)
         543 (29.72% of base) : 157343.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteDerivedSerializable(System.Xml.Serialization.SerializableMapping,System.Xml.Serialization.SerializableMapping,System.String,ubyte):this (FullOpts)
         520 ( 3.36% of base) : 163853.dasm - System.Data.BinaryNode:EvalBinaryOp(int,System.Data.ExpressionNode,System.Data.ExpressionNode,System.Data.DataRow,int,int[]):System.Object:this (FullOpts)
         484 (11.52% of base) : 186750.dasm - System.Management.ManagementClassGenerator:GenerateGetInstancesWithScope():this (FullOpts)
         461 (24.61% of base) : 274582.dasm - System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo:GetExportDefinitions():System.Collections.Generic.List`1[System.ComponentModel.Composition.Primitives.ExportDefinition]:this (FullOpts)
         428 (48.42% of base) : 156680.dasm - System.Xml.Serialization.XmlSerializationWriterCodeGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping):this (FullOpts)
         378 (26.73% of base) : 190484.dasm - Microsoft.CodeAnalysis.SarifV1ErrorLogger:WriteRules():this (FullOpts)
         378 (26.73% of base) : 221182.dasm - Microsoft.CodeAnalysis.SarifV1ErrorLogger:WriteRules():this (FullOpts)
         365 ( 4.67% of base) : 40491.dasm - Microsoft.Diagnostics.Tracing.Parsers.RegisteredTraceEventParser:GetManifestForRegisteredProvider(System.Guid):System.String (FullOpts)
         363 ( 2.91% of base) : 186755.dasm - System.Management.ManagementClassGenerator:GenerateTypeConverterClass():System.CodeDom.CodeTypeDeclaration:this (FullOpts)
         338 ( 9.43% of base) : 154007.dasm - System.Xml.XmlTextReaderImpl:ParseXmlDeclaration(ubyte):ubyte:this (FullOpts)
         335 ( 3.51% of base) : 2226.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)

Top method improvements (bytes):
       -8646 (-9.45% of base) : 36131.dasm - Microsoft.Diagnostics.Tracing.Parsers.ApplicationServerTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -6654 (-22.31% of base) : 221690.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -6654 (-22.31% of base) : 191041.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -3907 (-20.63% of base) : 49512.dasm - Microsoft.Diagnostics.Tracing.Parsers.AspNet.AspNetTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -3874 (-20.11% of base) : 35201.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftAntimalwareEngineTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -3873 (-14.36% of base) : 192275.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -3873 (-14.36% of base) : 222868.dasm - Microsoft.CodeAnalysis.AttributeDescription:.cctor() (FullOpts)
       -3291 (-24.55% of base) : 25299.dasm - <StartupCode$FSharp-Core>.$Linq:.cctor() (FullOpts)
       -2609 (-20.42% of base) : 24737.dasm - <StartupCode$FSharp-Core>.$Query:.cctor() (FullOpts)
       -2576 (-13.48% of base) : 152248.dasm - System.Xml.Xsl.IlGen.XmlILMethods:.cctor() (FullOpts)
       -1824 (-29.32% of base) : 169653.dasm - System.Xml.XmlBinaryReader:ReadNode():ubyte:this (FullOpts)
       -1786 (-10.71% of base) : 20616.dasm - System.Globalization.CultureData:get_RegionNames():System.Collections.Generic.Dictionary`2[System.String,System.String] (FullOpts)
       -1767 (-8.07% of base) : 36722.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1749 (-7.43% of base) : 36400.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrPrivateTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1610 (-4.67% of base) : 38317.dasm - Microsoft.Diagnostics.Tracing.Parsers.KernelTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1576 (-21.25% of base) : 164576.dasm - System.Data.RBTree`1[System.__Canon]:RBInsert(int,int,int,int,ubyte):int:this (FullOpts)
       -1556 (-20.96% of base) : 164826.dasm - System.Data.RBTree`1[int]:RBInsert(int,int,int,int,ubyte):int:this (FullOpts)
       -1542 (-64.41% of base) : 165044.dasm - System.Data.RBTree`1[int]:LeftRotate(int,int,int):int:this (FullOpts)
       -1542 (-64.41% of base) : 165045.dasm - System.Data.RBTree`1[int]:RightRotate(int,int,int):int:this (FullOpts)
       -1458 (-39.17% of base) : 71544.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentXmlTokens:.cctor() (FullOpts)

Top method regressions (percentages):
          12 (50.00% of base) : 244949.dasm - System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
         428 (48.42% of base) : 156680.dasm - System.Xml.Serialization.XmlSerializationWriterCodeGen:WriteDerivedTypes(System.Xml.Serialization.StructMapping):this (FullOpts)
           6 (42.86% of base) : 133566.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
           6 (42.86% of base) : 72023.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
          24 (41.38% of base) : 3384.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
           8 (40.00% of base) : 62835.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:IsTupleExpression(ubyte):ubyte (FullOpts)
          80 (37.04% of base) : 22178.dasm - System.DateTimeParse:ProcessDateTimeSuffix(byref,byref,byref):ubyte (FullOpts)
           7 (36.84% of base) : 87234.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
           7 (36.84% of base) : 146067.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
           5 (35.71% of base) : 257644.dasm - System.IO.Pipelines.PipeAwaitable:ObserveCancellation():ubyte:this (FullOpts)
           6 (35.29% of base) : 9394.dasm - System.Reflection.AssemblyName:set_Flags(int):this (FullOpts)
           4 (33.33% of base) : 2698.dasm - System.Index:GetOffset(int):int:this (FullOpts)
          10 (32.26% of base) : 22317.dasm - System.Globalization.CalendricalCalculationsHelper:InitLongitude(double):double (FullOpts)
         102 (30.36% of base) : 188089.dasm - System.Speech.Internal.Synthesis.PcmConverter:Blackman(int,ubyte):float[] (FullOpts)
          56 (30.11% of base) : 241124.dasm - ILCompiler.Reflection.ReadyToRun.NativeReader:ReadCompressedData(ubyte[],byref):uint (FullOpts)
           9 (30.00% of base) : 241118.dasm - ILCompiler.Reflection.ReadyToRun.NativeReader:ReadByte(ubyte[],byref):ubyte (FullOpts)
         543 (29.72% of base) : 157343.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteDerivedSerializable(System.Xml.Serialization.SerializableMapping,System.Xml.Serialization.SerializableMapping,System.String,ubyte):this (FullOpts)
           8 (29.63% of base) : 53163.dasm - System.Text.RegularExpressions.CaptureCollection+Enumerator:MoveNext():ubyte:this (FullOpts)
           3 (27.27% of base) : 26377.dasm - Microsoft.FSharp.Text.StructuredPrintfImpl.Display+ObjectGraphFormatter:countNodes(int):this (FullOpts)
           6 (27.27% of base) : 9386.dasm - System.Reflection.AssemblyName:set_ContentType(int):this (FullOpts)

Top method improvements (percentages):
       -1542 (-64.41% of base) : 165044.dasm - System.Data.RBTree`1[int]:LeftRotate(int,int,int):int:this (FullOpts)
       -1542 (-64.41% of base) : 165045.dasm - System.Data.RBTree`1[int]:RightRotate(int,int,int):int:this (FullOpts)
        -184 (-64.11% of base) : 164959.dasm - System.Data.FunctionNode:get_IsAggregate():ubyte:this (FullOpts)
         -17 (-62.96% of base) : 27101.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
         -48 (-61.54% of base) : 41526.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSortedAddressPairsArgs:get_SortOption():int:this (FullOpts)
       -1370 (-60.59% of base) : 164828.dasm - System.Data.RBTree`1[System.__Canon]:LeftRotate(int,int,int):int:this (FullOpts)
       -1370 (-60.59% of base) : 164829.dasm - System.Data.RBTree`1[System.__Canon]:RightRotate(int,int,int):int:this (FullOpts)
         -77 (-58.78% of base) : 260172.dasm - System.Uri:IsBadFileSystemCharacter(ushort):ubyte:this (FullOpts)
         -48 (-57.83% of base) : 33518.dasm - Microsoft.Diagnostics.Tracing.TraceEvent:get_ProcessorTime():ulong:this (FullOpts)
         -38 (-57.58% of base) : 41542.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSourceAddressSelectionArgs:get_Rule():int:this (FullOpts)
         -38 (-57.58% of base) : 41543.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP.IpSourceAddressSelectionArgs:get_RuleExtension():int:this (FullOpts)
         -83 (-54.97% of base) : 230828.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper+FallbackSegmentHelper`1[System.__Canon]:.cctor() (FullOpts)
         -83 (-54.97% of base) : 200608.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper+FallbackSegmentHelper`1[System.__Canon]:.cctor() (FullOpts)
         -83 (-54.97% of base) : 182729.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper+ValueTypeSegmentHelper`1[System.__Canon]:.cctor() (FullOpts)
        -219 (-53.81% of base) : 254575.dasm - System.Runtime.Caching.ExpiresBucket:RemoveFromList(int,byref):this (FullOpts)
         -41 (-52.56% of base) : 207921.dasm - System.Data.OleDb.OleDbParameter:ResetDbType():this (FullOpts)
         -41 (-52.56% of base) : 207924.dasm - System.Data.OleDb.OleDbParameter:ResetOleDbType():this (FullOpts)
        -126 (-52.28% of base) : 186285.dasm - System.Management.EnumerationOptions:.ctor():this (FullOpts)
         -12 (-52.17% of base) : 122544.dasm - Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler:Indent():this (FullOpts)
         -12 (-52.17% of base) : 122545.dasm - Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler:Unindent():this (FullOpts)

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

Total bytes of base: 63379915 (overridden on cmd)
Total bytes of diff: 61423099 (overridden on cmd)
Total bytes of delta: -1956816 (-3.09 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1815 : 218918.dasm (20.01% of base)
        1793 : 218915.dasm (16.08% of base)
        1560 : 218917.dasm (19.29% of base)
        1490 : 218880.dasm (11.34% of base)
        1071 : 162618.dasm (3.90% of base)
         870 : 249206.dasm (15.03% of base)
         820 : 218920.dasm (11.40% of base)
         732 : 169078.dasm (6.97% of base)
         595 : 303034.dasm (12.65% of base)
         576 : 249202.dasm (10.52% of base)
         374 : 205075.dasm (13.94% of base)
         366 : 31719.dasm (3.57% of base)
         337 : 154671.dasm (11.20% of base)
         329 : 162625.dasm (12.29% of base)
         329 : 85930.dasm (5.36% of base)
         325 : 245037.dasm (16.27% of base)
         324 : 75167.dasm (9.77% of base)
         291 : 98175.dasm (8.49% of base)
         291 : 202743.dasm (7.21% of base)
         291 : 182893.dasm (7.21% of base)

Top file improvements (bytes):
      -56337 : 37375.dasm (-38.25% of base)
      -22402 : 39560.dasm (-39.48% of base)
      -16637 : 37644.dasm (-42.27% of base)
      -14829 : 37965.dasm (-41.35% of base)
       -9745 : 135892.dasm (-71.35% of base)
       -9075 : 50766.dasm (-49.12% of base)
       -6864 : 36445.dasm (-43.71% of base)
       -6476 : 147202.dasm (-24.84% of base)
       -6476 : 187929.dasm (-24.84% of base)
       -4446 : 217402.dasm (-35.05% of base)
       -3988 : 75156.dasm (-70.12% of base)
       -3857 : 268214.dasm (-41.90% of base)
       -3503 : 139007.dasm (-73.02% of base)
       -3425 : 226904.dasm (-34.54% of base)
       -3328 : 221829.dasm (-47.02% of base)
       -3182 : 242206.dasm (-44.80% of base)
       -3166 : 50246.dasm (-48.86% of base)
       -3043 : 54453.dasm (-42.60% of base)
       -2972 : 181922.dasm (-55.78% of base)
       -2965 : 138123.dasm (-11.30% of base)

99 total files with Code Size differences (54 improved, 45 regressed), 20 unchanged.

Top method regressions (bytes):
        1815 (20.01% of base) : 218918.dasm - System.Management.ManagementClassGenerator:AddToDMTFDateTimeFunction():this (FullOpts)
        1793 (16.08% of base) : 218915.dasm - System.Management.ManagementClassGenerator:AddToDateTimeFunction():this (FullOpts)
        1560 (19.29% of base) : 218917.dasm - System.Management.ManagementClassGenerator:AddToDMTFTimeIntervalFunction():this (FullOpts)
        1490 (11.34% of base) : 218880.dasm - System.Management.ManagementClassGenerator:GenerateTypeConverterClass():System.CodeDom.CodeTypeDeclaration:this (FullOpts)
        1071 ( 3.90% of base) : 162618.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
         870 (15.03% of base) : 249206.dasm - R2RDump.Extensions:WriteTo(ILCompiler.Reflection.ReadyToRun.RuntimeFunction,System.IO.TextWriter,R2RDump.DumpModel) (FullOpts)
         820 (11.40% of base) : 218920.dasm - System.Management.ManagementClassGenerator:AddToTimeSpanFunction():this (FullOpts)
         732 ( 6.97% of base) : 169078.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
         595 (12.65% of base) : 303034.dasm - System.Security.Cryptography.Xml.KeyInfoX509Data:GetXml(System.Xml.XmlDocument):System.Xml.XmlElement:this (FullOpts)
         576 (10.52% of base) : 249202.dasm - R2RDump.Extensions:WriteTo(ILCompiler.Reflection.ReadyToRun.DebugInfo,System.IO.TextWriter,R2RDump.DumpModel) (FullOpts)
         374 (13.94% of base) : 205075.dasm - System.Data.XMLDiffLoader:ReadOldRowData(System.Data.DataSet,byref,byref,System.Xml.XmlReader):int:this (FullOpts)
         366 ( 3.57% of base) : 31719.dasm - ILCompiler.Win32Resources.ResourceData:WriteResources(ILCompiler.DependencyAnalysis.ISymbolNode,byref,byref):this (FullOpts)
         337 (11.20% of base) : 154671.dasm - Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter:PopulateEncLogTableRows(System.Collections.Immutable.ImmutableArray`1[int],byref,byref):this (FullOpts)
         329 ( 5.36% of base) : 85930.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator:GetTypeAndRefKind(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator+TypeAndRefKind:this (FullOpts)
         329 (12.29% of base) : 162625.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:SelectProperty(int,System.Reflection.PropertyInfo[],System.Type,System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.PropertyInfo:this (FullOpts)
         325 (16.27% of base) : 245037.dasm - Microsoft.Extensions.DependencyInjection.ActivatorUtilities:BuildFactoryExpression(System.Reflection.ConstructorInfo,System.Nullable`1[int][],System.Linq.Expressions.Expression,System.Linq.Expressions.Expression):System.Linq.Expressions.BlockExpression (FullOpts)
         324 ( 9.77% of base) : 75167.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseNamespaceBody(byref,byref,byref,ushort):this (FullOpts)
         291 ( 8.49% of base) : 98175.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.NamespaceSymbol:LookupMetadataType(byref):Microsoft.CodeAnalysis.VisualBasic.Symbols.NamedTypeSymbol:this (FullOpts)
         291 ( 7.21% of base) : 202743.dasm - System.Configuration.ConfigurationElementCollection:Unmerge(System.Configuration.ConfigurationElement,System.Configuration.ConfigurationElement,int):this (FullOpts)
         291 ( 7.21% of base) : 182893.dasm - System.Configuration.ConfigurationElementCollection:Unmerge(System.Configuration.ConfigurationElement,System.Configuration.ConfigurationElement,int):this (FullOpts)

Top method improvements (bytes):
      -56337 (-38.25% of base) : 37375.dasm - Microsoft.Diagnostics.Tracing.Parsers.ApplicationServerTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
      -22402 (-39.48% of base) : 39560.dasm - Microsoft.Diagnostics.Tracing.Parsers.KernelTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
      -16637 (-42.27% of base) : 37644.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrPrivateTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
      -14829 (-41.35% of base) : 37965.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -9745 (-71.35% of base) : 135892.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
       -9075 (-49.12% of base) : 50766.dasm - Microsoft.Diagnostics.Tracing.Parsers.AspNet.AspNetTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -6864 (-43.71% of base) : 36445.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftAntimalwareEngineTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -6476 (-24.84% of base) : 147202.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -6476 (-24.84% of base) : 187929.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -4446 (-35.05% of base) : 217402.dasm - System.Linq.Expressions.Compiler.LambdaCompiler:EmitLift(int,System.Type,System.Linq.Expressions.MethodCallExpression,System.Linq.Expressions.ParameterExpression[],System.Linq.Expressions.Expression[]):this (FullOpts)
       -3988 (-70.12% of base) : 75156.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentXmlTokens:.cctor() (FullOpts)
       -3857 (-41.90% of base) : 268214.dasm - System.ComponentModel.ReflectTypeDescriptionProvider+<>c:<get_IntrinsicTypeConverters>b__24_0():System.Collections.Generic.Dictionary`2[System.Object,System.ComponentModel.ReflectTypeDescriptionProvider+IntrinsicTypeConverterData]:this (FullOpts)
       -3503 (-73.02% of base) : 139007.dasm - System.Xml.Serialization.CodeGenerator:.cctor() (FullOpts)
       -3425 (-34.54% of base) : 226904.dasm - System.Runtime.Serialization.DataContracts.DataContract+DataContractCriticalHelper:TryCreateBuiltInDataContract(System.String,System.String,byref):ubyte (FullOpts)
       -3328 (-47.02% of base) : 221829.dasm - System.Net.Http.Headers.QPackStaticTable:.cctor() (FullOpts)
       -3182 (-44.80% of base) : 242206.dasm - CommandLine.Core.SpecificationPropertyRules+<>c:<EnforceRequired>b__5_0(System.Collections.Generic.IEnumerable`1[CommandLine.Core.SpecificationProperty]):System.Collections.Generic.IEnumerable`1[CommandLine.Error]:this (FullOpts)
       -3166 (-48.86% of base) : 50246.dasm - Microsoft.Diagnostics.Tracing.Parsers.Clr.ClrRundownTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -3043 (-42.60% of base) : 54453.dasm - System.Net.HeaderInfoTable:CreateHeaderHashtable():System.Collections.Hashtable (FullOpts)
       -2972 (-55.78% of base) : 181922.dasm - Microsoft.Build.Shared.FrameworkLocationHelper+<>c:<.cctor>b__115_0():Microsoft.Build.Shared.FrameworkLocationHelper+VisualStudioSpec[]:this (FullOpts)
       -2965 (-11.30% of base) : 138123.dasm - System.Xml.Xsl.IlGen.XmlILMethods:.cctor() (FullOpts)

Top method regressions (percentages):
          12 (50.00% of base) : 258094.dasm - System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
          43 (43.43% of base) : 95874.dasm - Microsoft.VisualBasic.CompilerServices.Conversions:ToChar(System.Object):ushort (FullOpts)
          43 (43.43% of base) : 95872.dasm - Microsoft.VisualBasic.CompilerServices.Conversions:ToDate(System.Object):System.DateTime (FullOpts)
           6 (42.86% of base) : 75635.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (FullOpts)
           3 (42.86% of base) : 295250.dasm - System.Numerics.Tensors.TensorPrimitives+SquaredOperator`1[ubyte]:Invoke(ubyte):ubyte (FullOpts)
           8 (40.00% of base) : 64665.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter:IsTupleExpression(ubyte):ubyte (FullOpts)
           7 (36.84% of base) : 93745.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
           4 (36.36% of base) : 294951.dasm - System.Numerics.Tensors.TensorPrimitives+AddOperator`1[double]:Invoke(System.Runtime.Intrinsics.Vector128`1[double]):double (FullOpts)
           5 (35.71% of base) : 279764.dasm - System.IO.Pipelines.PipeAwaitable:ObserveCancellation():ubyte:this (FullOpts)
           9 (33.33% of base) : 308320.dasm - System.Threading.Tasks.Parallel:<ForAsync>g__CompareExchange|49_1[ubyte](byref,ubyte,ubyte):ubyte (FullOpts)
           9 (32.14% of base) : 308321.dasm - System.Threading.Tasks.Parallel:<ForAsync>g__CompareExchange|49_1[short](byref,short,short):ubyte (FullOpts)
           9 (31.03% of base) : 242471.dasm - ILCompiler.Reflection.ReadyToRun.NativeReader:ReadByte(ubyte[],byref):ubyte (FullOpts)
          35 (30.70% of base) : 30764.dasm - Internal.Pgo.TypeSystemEntityOrUnknown:Equals(Internal.Pgo.TypeSystemEntityOrUnknown):ubyte:this (FullOpts)
          81 (30.45% of base) : 224542.dasm - System.Runtime.Serialization.SchemaExporter:ExportDataContract(System.Runtime.Serialization.DataContracts.DataContract):this (FullOpts)
          56 (30.27% of base) : 242477.dasm - ILCompiler.Reflection.ReadyToRun.NativeReader:ReadCompressedData(ubyte[],byref):uint (FullOpts)
           3 (30.00% of base) : 21245.dasm - System.Globalization.TimeSpanParse+TimeSpanTokenizer:BackOne():this (FullOpts)
           3 (30.00% of base) : 127580.dasm - System.Xml.XmlSqlBinaryReader+AttrInfo:AdjustPosition(int):this (FullOpts)
           8 (29.63% of base) : 54651.dasm - System.Text.RegularExpressions.CaptureCollection+Enumerator:MoveNext():ubyte:this (FullOpts)
         163 (27.86% of base) : 142706.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ConstVal:IsDefault(System.Object):ubyte (FullOpts)
          15 (27.78% of base) : 177454.dasm - Microsoft.Build.BackEnd.BufferedReadStream:ReadByte():int:this (FullOpts)

Top method improvements (percentages):
        -423 (-76.22% of base) : 207868.dasm - System.Data.FunctionNode:get_IsAggregate():ubyte:this (FullOpts)
       -2435 (-73.37% of base) : 297740.dasm - System.Reflection.DispatchProxyGenerator+ProxyBuilder:.cctor() (FullOpts)
       -3503 (-73.02% of base) : 139007.dasm - System.Xml.Serialization.CodeGenerator:.cctor() (FullOpts)
       -2136 (-71.51% of base) : 119784.dasm - Microsoft.CodeAnalysis.VisualBasic.CustomSymbolDisplayFormatter:.cctor() (FullOpts)
        -379 (-71.51% of base) : 232728.dasm - System.Speech.Internal.Synthesis.PcmConverter:FindResampleFactors(int,int):this (FullOpts)
       -9745 (-71.35% of base) : 135892.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
       -3988 (-70.12% of base) : 75156.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentXmlTokens:.cctor() (FullOpts)
        -348 (-65.29% of base) : 238965.dasm - Internal.TypeSystem.UniversalCanonLayoutAlgorithm:ComputeStaticFieldLayout(Internal.TypeSystem.DefType,int):Internal.TypeSystem.ComputedStaticFieldLayout:this (FullOpts)
        -319 (-64.71% of base) : 308894.dasm - System.Transactions.ContextData:set_TLSCurrentData(System.Transactions.ContextData) (FullOpts)
       -1542 (-64.41% of base) : 207333.dasm - System.Data.RBTree`1[ubyte]:LeftRotate(int,int,int):int:this (FullOpts)
       -1542 (-64.41% of base) : 207334.dasm - System.Data.RBTree`1[ubyte]:RightRotate(int,int,int):int:this (FullOpts)
         -17 (-62.96% of base) : 14052.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt16@5899:System.Collections.IEnumerator.Reset():this (FullOpts)
       -1378 (-61.90% of base) : 171054.dasm - Microsoft.Build.Framework.ChangeWaves:ApplyChangeWave() (FullOpts)
       -1370 (-60.65% of base) : 207272.dasm - System.Data.RBTree`1[System.__Canon]:LeftRotate(int,int,int):int:this (FullOpts)
       -1370 (-60.65% of base) : 207273.dasm - System.Data.RBTree`1[System.__Canon]:RightRotate(int,int,int):int:this (FullOpts)
        -105 (-60.34% of base) : 291148.dasm - System.Net.Quic.QuicReceiveWindowSizes:.ctor():this (FullOpts)
         -77 (-58.78% of base) : 296026.dasm - System.Uri:IsBadFileSystemCharacter(ushort):ubyte:this (FullOpts)
       -1368 (-58.59% of base) : 172861.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArraySortHelper`1[ubyte]:PickPivotAndPartition(Microsoft.CodeAnalysis.Collections.Internal.SegmentedArraySegment`1[ubyte],System.Comparison`1[ubyte]):int (FullOpts)
        -254 (-58.26% of base) : 172894.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[long]:BinarySearch(Microsoft.CodeAnalysis.Collections.SegmentedArray`1[long],int,int,long):int (FullOpts)
       -1016 (-58.02% of base) : 172881.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedGenericArraySortHelper`1[ubyte]:PickPivotAndPartition(Microsoft.CodeAnalysis.Collections.Internal.SegmentedArraySegment`1[ubyte]):int (FullOpts)

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

Total bytes of base: 285382240 (overridden on cmd)
Total bytes of diff: 284996044 (overridden on cmd)
Total bytes of delta: -386196 (-0.14 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        8677 : 90130.dasm (82.92% of base)
        8392 : 59877.dasm (77.52% of base)
        6163 : 645928.dasm (56.06% of base)
        5947 : 79866.dasm (52.26% of base)
        5348 : 37696.dasm (51.73% of base)
        2823 : 437735.dasm (15.12% of base)
        1312 : 185580.dasm (6.38% of base)
        1263 : 326562.dasm (19.26% of base)
        1124 : 111629.dasm (7.51% of base)
        1124 : 184112.dasm (7.51% of base)
        1075 : 50975.dasm (7.24% of base)
        1070 : 326458.dasm (17.64% of base)
        1027 : 501620.dasm (7.29% of base)
         977 : 633319.dasm (6.47% of base)
         949 : 89025.dasm (6.33% of base)
         947 : 230059.dasm (18.86% of base)
         876 : 318068.dasm (17.75% of base)
         839 : 503307.dasm (6.62% of base)
         837 : 66434.dasm (5.23% of base)
         805 : 519744.dasm (11.71% of base)

Top file improvements (bytes):
      -15961 : 607553.dasm (-18.06% of base)
       -5007 : 462176.dasm (-16.76% of base)
       -4151 : 220439.dasm (-39.32% of base)
       -2870 : 440903.dasm (-17.61% of base)
       -2752 : 462197.dasm (-15.71% of base)
       -2618 : 462256.dasm (-15.90% of base)
       -2507 : 460838.dasm (-16.56% of base)
       -2399 : 462266.dasm (-15.90% of base)
       -2382 : 462261.dasm (-15.09% of base)
       -2084 : 462268.dasm (-16.55% of base)
       -1942 : 462272.dasm (-16.01% of base)
       -1919 : 444218.dasm (-32.55% of base)
       -1534 : 370638.dasm (-52.09% of base)
       -1511 : 370164.dasm (-38.51% of base)
       -1496 : 462263.dasm (-15.75% of base)
       -1336 : 369113.dasm (-44.79% of base)
       -1328 : 367383.dasm (-33.20% of base)
       -1310 : 462267.dasm (-16.78% of base)
       -1242 : 634058.dasm (-11.15% of base)
       -1068 : 602015.dasm (-19.85% of base)

93 total files with Code Size differences (45 improved, 48 regressed), 20 unchanged.

Top method regressions (bytes):
        8677 (82.92% of base) : 90130.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        8392 (77.52% of base) : 59877.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        6163 (56.06% of base) : 645928.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        5947 (52.26% of base) : 79866.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
        5348 (51.73% of base) : 37696.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
        2823 (15.12% of base) : 437735.dasm - XPathTests.Common.Utils:XPathNodesetTest(int,System.String,System.String,XPathTests.Common.XPathResult,System.Xml.XmlNamespaceManager,System.String) (Tier1)
        1312 ( 6.38% of base) : 185580.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:AddNonTypeMembers(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+DeclaredMembersAndInitializersBuilder,Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
        1263 (19.26% of base) : 326562.dasm - System.IO.Tests.Directory_GetFileSystemEntries_str_str:SearchPatternWithTrailingStar():this (Tier1)
        1124 ( 7.51% of base) : 111629.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        1124 ( 7.51% of base) : 184112.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        1075 ( 7.24% of base) : 50975.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        1070 (17.64% of base) : 326458.dasm - System.IO.Tests.Directory_GetFileSystemEntries_str_str:SearchPatternWithLeadingStar():this (Tier1)
        1027 ( 7.29% of base) : 501620.dasm - (dynamicClass):WritePrimitiveContainerToXml(System.Runtime.Serialization.XmlWriterDelegator,System.Object,System.Runtime.Serialization.XmlObjectSerializerWriteContext,System.Runtime.Serialization.DataContracts.ClassDataContract) (FullOpts)
         977 ( 6.47% of base) : 633319.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
         949 ( 6.33% of base) : 89025.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
         947 (18.86% of base) : 230059.dasm - Xunit.Sdk.ReflectionMethodInfo:GetParent(System.Reflection.MethodInfo):System.Reflection.MethodInfo (Tier1)
         876 (17.75% of base) : 318068.dasm - Xunit.Sdk.ReflectionMethodInfo:GetParent(System.Reflection.MethodInfo):System.Reflection.MethodInfo (Tier1)
         839 ( 6.62% of base) : 503307.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         837 ( 5.23% of base) : 66434.dasm - Microsoft.CodeAnalysis.CSharp.BuiltInOperators:GetSimpleBuiltInOperators(int,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature],ubyte):this (Tier1)
         805 (11.71% of base) : 519744.dasm - System.Tests.Types.TypePropertyTestBase:Attributes_Get_ReturnsExpected():this (Tier1)

Top method improvements (bytes):
      -15961 (-18.06% of base) : 607553.dasm - (dynamicClass):.ctor(System.Object[]):System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters (FullOpts)
       -5007 (-16.76% of base) : 462176.dasm - System.Xml.Tests.TCErrorCondition:AddChildren():this (Tier1)
       -4151 (-39.32% of base) : 220439.dasm - System.Collections.Frozen.Tests.FrozenSet_Generic_Tests`1[System.__Canon]:ComparingWithOtherSets(int):this (Tier1-OSR)
       -2870 (-17.61% of base) : 440903.dasm - System.Xml.Schema.SchemaNames:.ctor(System.Xml.XmlNameTable):this (Tier1)
       -2752 (-15.71% of base) : 462197.dasm - System.Xml.Tests.TCInvalidXML:AddChildren():this (Tier1)
       -2618 (-15.90% of base) : 462256.dasm - System.Xml.Tests.TCRead2:AddChildren():this (Tier1)
       -2507 (-16.56% of base) : 460838.dasm - System.Xml.Tests.TCXMLIntegrityBase:AddChildren():this (Tier1)
       -2399 (-15.90% of base) : 462266.dasm - System.Xml.Tests.TCReadValue:AddChildren():this (Tier1)
       -2382 (-15.09% of base) : 462261.dasm - System.Xml.Tests.TCReadSubtree:AddChildren():this (Tier1)
       -2084 (-16.55% of base) : 462268.dasm - System.Xml.Tests.TCReadElementContentAsBase64:AddChildren():this (Tier1)
       -1942 (-16.01% of base) : 462272.dasm - System.Xml.Tests.TCReadElementContentAsBinHex:AddChildren():this (Tier1)
       -1919 (-32.55% of base) : 444218.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (Tier1)
       -1534 (-52.09% of base) : 370638.dasm - System.SpanHelpers:LastIndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (Tier1)
       -1511 (-38.51% of base) : 370164.dasm - System.SpanHelpers:LastIndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (Instrumented Tier1)
       -1496 (-15.75% of base) : 462263.dasm - System.Xml.Tests.TCReadToDescendant:AddChildren():this (Tier1)
       -1336 (-44.79% of base) : 369113.dasm - System.SpanHelpers:IndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (Tier1)
       -1328 (-33.20% of base) : 367383.dasm - System.SpanHelpers:IndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (Instrumented Tier1)
       -1310 (-16.78% of base) : 462267.dasm - System.Xml.Tests.TCReadContentAsBase64:AddChildren():this (Tier1)
       -1242 (-11.15% of base) : 634058.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:GetRuntimeMember(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol],byref,Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer`5[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):Microsoft.CodeAnalysis.CSharp.Symbol (Tier1)
       -1068 (-19.85% of base) : 602015.dasm - (dynamicClass):.ctor(System.Object[]):System.Text.Json.Serialization.Tests.Struct_With_Ctor_With_65_Params (FullOpts)

Top method regressions (percentages):
        8677 (82.92% of base) : 90130.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        8392 (77.52% of base) : 59877.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        6163 (56.06% of base) : 645928.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1)
        5947 (52.26% of base) : 79866.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
        5348 (51.73% of base) : 37696.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
           6 (42.86% of base) : 190405.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:MutateLocation(int):this (Tier1)
           8 (42.11% of base) : 655984.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (Tier1)
          32 (41.56% of base) : 420232.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+RadiansToDegreesOperator`1[System.Half]](byref,byref,ulong) (Tier1)
          94 (38.84% of base) : 297031.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,System.Type,System.Object,System.Object,System.Object):ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.formalParameter.cnstrctor004.cnstrctor004.MyType (FullOpts)
          12 (38.71% of base) : 313751.dasm - System.Globalization.CalendricalCalculationsHelper:InitLongitude(double):double (Instrumented Tier1)
          32 (37.21% of base) : 420077.dasm - System.Numerics.Tensors.TensorPrimitives:<InvokeSpanIntoSpan>g__SoftwareFallback|227_0[System.Half,System.Half,System.Numerics.Tensors.TensorPrimitives+Exp2M1Operator`1[System.Half]](byref,byref,ulong) (Tier1)
           4 (36.36% of base) : 416134.dasm - System.Numerics.Tensors.TensorPrimitives+AddOperator`1[double]:Invoke(System.Runtime.Intrinsics.Vector128`1[double]):double (Tier1)
           6 (35.29% of base) : 182470.dasm - System.Reflection.AssemblyName:set_Flags(int):this (Instrumented Tier1)
          10 (32.26% of base) : 60587.dasm - NuGet.Protocol.Core.Types.ResourceProvider:.ctor(System.Type,System.String):this (Tier1)
          10 (31.25% of base) : 692121.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 695857.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
          10 (31.25% of base) : 691954.dasm - System.Threading.LowLevelLifoSemaphoreBase+Counts:AddUpToMaxCountOfWaitersSignaledToWake(uint):this (Tier1)
           7 (28.00% of base) : 671032.dasm - Microsoft.CodeAnalysis.NullableFlowStateExtensions:ToAnnotation(ubyte):ubyte (Tier1)
           7 (28.00% of base) : 92915.dasm - Microsoft.CodeAnalysis.NullableFlowStateExtensions:ToAnnotation(ubyte):ubyte (Tier1)
          66 (27.97% of base) : 294752.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.overload.overload15a.overload15a.Parent,System.Object,System.Object):System.Object (FullOpts)

Top method improvements (percentages):
       -1534 (-52.09% of base) : 370638.dasm - System.SpanHelpers:LastIndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (Tier1)
         -16 (-50.00% of base) : 382841.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -16 (-50.00% of base) : 379898.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -16 (-50.00% of base) : 631929.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -16 (-50.00% of base) : 399491.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -16 (-50.00% of base) : 440016.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
       -1005 (-47.14% of base) : 370465.dasm - System.SpanHelpers:IndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,int):int (Tier1)
        -954 (-46.86% of base) : 370449.dasm - System.SpanHelpers:LastIndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,int):int (Tier1)
         -10 (-45.45% of base) : 417609.dasm - System.Byte:Min(ubyte,ubyte):ubyte (Instrumented Tier1)
         -10 (-45.45% of base) : 417613.dasm - System.Byte:System.Numerics.INumberBase<System.Byte>.MinMagnitude(ubyte,ubyte):ubyte (Instrumented Tier1)
       -1336 (-44.79% of base) : 369113.dasm - System.SpanHelpers:IndexOfAny[System.__Canon](byref,System.__Canon,System.__Canon,System.__Canon,int):int (Tier1)
         -14 (-43.75% of base) : 522931.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -14 (-43.75% of base) : 367741.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (Tier1)
         -20 (-43.48% of base) : 275459.dasm - System.Diagnostics.Activity:get_DefaultIdFormat():int (Tier1)
         -20 (-43.48% of base) : 435826.dasm - System.Xml.Serialization.XmlCustomFormatter:get_Mode():int (Tier1)
        -546 (-43.16% of base) : 326582.dasm - System.IO.Tests.FSAssert:EqualWhenOrdered[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon],System.Collections.Generic.IEnumerable`1[System.__Canon]) (Tier1)
        -794 (-43.08% of base) : 462260.dasm - System.Xml.Tests.TCReadSubtree:.ctor():this (Tier1)
        -129 (-42.57% of base) : 60461.dasm - Xunit.Sdk.MaxConcurrencySyncContext:RunOnSyncContext(System.Threading.SendOrPostCallback,System.Object):this (Tier1)
        -108 (-41.38% of base) : 634733.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet:CreateRange[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon]):Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1[System.__Canon] (Tier1)
        -108 (-41.38% of base) : 50738.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet:CreateRange[System.__Canon](System.Collections.Generic.IEnumerable`1[System.__Canon]):Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1[System.__Canon] (Tier1)

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

Total bytes of base: 139565419 (overridden on cmd)
Total bytes of diff: 136367250 (overridden on cmd)
Total bytes of delta: -3198169 (-2.29 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        2137 : 192467.dasm (21.45% of base)
        1815 : 149673.dasm (20.01% of base)
        1793 : 149671.dasm (16.08% of base)
        1726 : 188079.dasm (13.12% of base)
        1712 : 149717.dasm (13.34% of base)
        1632 : 240534.dasm (14.04% of base)
        1571 : 95577.dasm (19.24% of base)
        1551 : 98961.dasm (23.81% of base)
        1427 : 183320.dasm (10.63% of base)
        1374 : 95593.dasm (17.33% of base)
        1371 : 95525.dasm (13.59% of base)
        1272 : 99599.dasm (18.30% of base)
        1255 : 97722.dasm (13.08% of base)
        1229 : 97316.dasm (16.11% of base)
        1184 : 60381.dasm (4.34% of base)
        1165 : 99602.dasm (16.96% of base)
        1120 : 90525.dasm (14.45% of base)
        1120 : 90653.dasm (14.42% of base)
        1120 : 90657.dasm (14.42% of base)
        1120 : 90543.dasm (14.45% of base)

Top file improvements (bytes):
      -15961 : 274798.dasm (-18.06% of base)
      -15961 : 258299.dasm (-18.06% of base)
      -11705 : 127812.dasm (-48.90% of base)
      -11705 : 127114.dasm (-48.90% of base)
      -11534 : 196720.dasm (-60.07% of base)
      -10053 : 126220.dasm (-48.98% of base)
      -10053 : 128624.dasm (-48.98% of base)
       -9745 : 178010.dasm (-71.35% of base)
       -7750 : 178003.dasm (-17.55% of base)
       -6476 : 20703.dasm (-24.84% of base)
       -5752 : 30115.dasm (-35.12% of base)
       -5156 : 106910.dasm (-18.65% of base)
       -5029 : 105050.dasm (-33.03% of base)
       -5007 : 184273.dasm (-16.76% of base)
       -4866 : 196355.dasm (-22.01% of base)
       -4504 : 192843.dasm (-30.34% of base)
       -4428 : 298891.dasm (-46.08% of base)
       -4282 : 128555.dasm (-45.03% of base)
       -4282 : 126422.dasm (-45.03% of base)
       -4097 : 129800.dasm (-11.19% of base)

99 total files with Code Size differences (58 improved, 41 regressed), 20 unchanged.

Top method regressions (bytes):
        2137 (21.45% of base) : 192467.dasm - System.Reflection.Tests.PropertyTests:TestProperties_GetterSetter() (FullOpts)
        1815 (20.01% of base) : 149673.dasm - System.Management.ManagementClassGenerator:AddToDMTFDateTimeFunction():this (FullOpts)
        1793 (16.08% of base) : 149671.dasm - System.Management.ManagementClassGenerator:AddToDateTimeFunction():this (FullOpts)
        1726 (13.12% of base) : 188079.dasm - System.Reflection.Emit.Tests.AssemblySaveAssemblyBuilder:CheckAssembly(System.Reflection.Assembly):this (FullOpts)
        1712 (13.34% of base) : 149717.dasm - System.Management.ManagementClassGenerator:GenerateTypeConverterClass():System.CodeDom.CodeTypeDeclaration:this (FullOpts)
        1632 (14.04% of base) : 240534.dasm - System.ServiceModel.Syndication.Tests.AtomPub10ServiceDocumentFormatterTests+<>c:<ReadFrom_FullDocument_ReturnsExpected>b__18_0(System.ServiceModel.Syndication.ServiceDocument):this (FullOpts)
        1571 (19.24% of base) : 95577.dasm - System.Data.Tests.DataTableTest4:VerifyTableSchema(System.Data.DataTable,System.String,System.Data.DataSet):this (FullOpts)
        1551 (23.81% of base) : 98961.dasm - System.Data.Tests.DataColumnCollectionTest2:Add():this (FullOpts)
        1427 (10.63% of base) : 183320.dasm - System.Xml.XmlConvertTests.ToTypeTests:TestValid(System.Object[],System.Object[],System.String,System.String[]):int:this (FullOpts)
        1374 (17.33% of base) : 95593.dasm - System.Data.Tests.DataTableTest4:VerifyTable_WithChildren(System.Data.DataTable,System.String,System.Data.DataSet):this (FullOpts)
        1371 (13.59% of base) : 95525.dasm - System.Data.Tests.DataTableTest4:XmlTest10():this (FullOpts)
        1272 (18.30% of base) : 99599.dasm - System.Data.Tests.DataTableTest3:VerifyTableSchema(System.Data.DataTable,System.String,System.Data.DataSet):this (FullOpts)
        1255 (13.08% of base) : 97722.dasm - System.Data.Tests.DataTableTest2:GetChanges_ByDataRowState():this (FullOpts)
        1229 (16.11% of base) : 97316.dasm - System.Data.Tests.DataTableTest5:VerifyTableSchema(System.Data.DataTable,System.String,System.Data.DataSet):this (FullOpts)
        1184 ( 4.34% of base) : 60381.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
        1165 (16.96% of base) : 99602.dasm - System.Data.Tests.DataTableTest3:XmlSchemaTest5():this (FullOpts)
        1120 (14.42% of base) : 90657.dasm - System.ComponentModel.Tests.TypeDescriptorTests:RemoveProvider_InvokeObject_RemovesProvider():this (FullOpts)
        1120 (14.45% of base) : 90525.dasm - System.ComponentModel.Tests.TypeDescriptorTests:RemoveProvider_InvokeType_RemovesProvider():this (FullOpts)
        1120 (14.42% of base) : 90653.dasm - System.ComponentModel.Tests.TypeDescriptorTests:RemoveProviderTransparent_InvokeObject_RemovesProvider():this (FullOpts)
        1120 (14.45% of base) : 90543.dasm - System.ComponentModel.Tests.TypeDescriptorTests:RemoveProviderTransparent_InvokeType_RemovesProvider():this (FullOpts)

Top method improvements (bytes):
      -15961 (-18.06% of base) : 274798.dasm - (dynamicClass):.ctor(System.Object[]):System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters (FullOpts)
      -15961 (-18.06% of base) : 258299.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Default+ConstructorTestsContext_Default+<>c:<Create_ClassWithManyConstructorParameters>b__395_0(System.Object[]):System.Text.Json.Serialization.Tests.ClassWithManyConstructorParameters:this (FullOpts)
      -11705 (-48.90% of base) : 127812.dasm - System.Globalization.Tests.CompareInfoLastIndexOfTests:LastIndexOf_Invalid():this (FullOpts)
      -11705 (-48.90% of base) : 127114.dasm - System.Globalization.Tests.CompareInfoLastIndexOfTests:LastIndexOf_Invalid():this (FullOpts)
      -11534 (-60.07% of base) : 196720.dasm - System.IO.Tests.PathTests_Join:.cctor() (FullOpts)
      -10053 (-48.98% of base) : 126220.dasm - System.Globalization.Tests.CompareInfoIndexOfTests:IndexOf_Invalid():this (FullOpts)
      -10053 (-48.98% of base) : 128624.dasm - System.Globalization.Tests.CompareInfoIndexOfTests:IndexOf_Invalid():this (FullOpts)
       -9745 (-71.35% of base) : 178010.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
       -7750 (-17.55% of base) : 178003.dasm - XmlCoreTest.Common.UnicodeCharHelper:InitializeFourthEditionCharTypeTable() (FullOpts)
       -6476 (-24.84% of base) : 20703.dasm - Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer:.cctor() (FullOpts)
       -5752 (-35.12% of base) : 30115.dasm - Microsoft.Extensions.Configuration.Binder.SourceGeneration.<BindingExtensions_g>F06CBF607B39F5F589B67E292D600729E0514C7A495E0099C73A76F3B9B09B78C__BindingExtensions:.cctor() (FullOpts)
       -5156 (-18.65% of base) : 106910.dasm - System.Drawing.Primitives.Tests.ColorTests:.cctor() (FullOpts)
       -5029 (-33.03% of base) : 105050.dasm - BasicEventSourceTests.TestsWriteEventToListener:Test_WriteEvent_ArgsBasicTypes():this (FullOpts)
       -5007 (-16.76% of base) : 184273.dasm - System.Xml.Tests.TCErrorCondition:AddChildren():this (FullOpts)
       -4866 (-22.01% of base) : 196355.dasm - System.Tests.ConvertToBase64StringTests+<ConvertToBase64StringTests_TestData>d__5:MoveNext():ubyte:this (FullOpts)
       -4504 (-30.34% of base) : 192843.dasm - System.Reflection.Tests.FieldTests:TestLiteralFields1() (FullOpts)
       -4428 (-46.08% of base) : 298891.dasm - System.Text.RegularExpressions.Tests.RegexReplaceTests:Replace_Invalid():this (FullOpts)
       -4282 (-45.03% of base) : 128555.dasm - System.Globalization.Tests.CompareInfoCompareTests:Compare_Invalid():this (FullOpts)
       -4282 (-45.03% of base) : 126422.dasm - System.Globalization.Tests.CompareInfoCompareTests:Compare_Invalid():this (FullOpts)
       -4097 (-11.19% of base) : 129800.dasm - FileData:.cctor() (FullOpts)

Top method regressions (percentages):
           8 (800.00% of base) : 214592.dasm - System.Tests.Types.FunctionPointerTests:CompileTimeIdentity_Managed() (FullOpts)
          12 (50.00% of base) : 66217.dasm - System.CodeDom.CodeTypeDeclaration:set_IsInterface(ubyte):this (FullOpts)
          94 (38.84% of base) : 115875.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,System.Type,System.Object,System.Object,System.Object):ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.formalParameter.cnstrctor004.cnstrctor004.MyType (FullOpts)
           7 (36.84% of base) : 57576.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
          14 (33.33% of base) : 183301.dasm - OLEDB.Test.ModuleCore.CTestCase+<>c__DisplayClass7_1:<TestCases>b__0():int:this (FullOpts)
         712 (32.10% of base) : 173179.dasm - System.PrivateUri.Tests.UriEscapingTest:<UriEscapeDataString>g__ValidateEscape|11_0(System.String,System.String) (FullOpts)
         659 (30.98% of base) : 173200.dasm - System.PrivateUri.Tests.UriEscapingTest:<UriUnescapeDataString>g__ValidateUnescape|12_0(System.String,System.String) (FullOpts)
           4 (30.77% of base) : 85160.dasm - System.ComponentModel.Composition.Hosting.AggregateCatalogTest+<>c__DisplayClass12_0:<MutableCatalogNotifications>b__0(System.Object,System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs):this (FullOpts)
           4 (30.77% of base) : 85162.dasm - System.ComponentModel.Composition.Hosting.AggregateCatalogTest+<>c__DisplayClass12_0:<MutableCatalogNotifications>b__1(System.Object,System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs):this (FullOpts)
          81 (30.45% of base) : 207620.dasm - System.Runtime.Serialization.SchemaExporter:ExportDataContract(System.Runtime.Serialization.DataContracts.DataContract):this (FullOpts)
           8 (29.63% of base) : 298440.dasm - System.Text.RegularExpressions.CaptureCollection+Enumerator:MoveNext():ubyte:this (FullOpts)
         159 (29.23% of base) : 25367.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ConstVal:IsDefault(System.Object):ubyte (FullOpts)
         716 (29.21% of base) : 214577.dasm - System.Tests.TimeSpanTests:TryFormat_Valid(System.TimeSpan,System.String,System.Globalization.CultureInfo,System.String) (FullOpts)
          66 (27.97% of base) : 110964.dasm - (dynamicClass):CallSite.Target(System.Runtime.CompilerServices.Closure,System.Runtime.CompilerServices.CallSite,ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.overload.overload15a.overload15a.Parent,System.Object,System.Object):System.Object (FullOpts)
         754 (27.83% of base) : 93681.dasm - ReadAndWrite:ValidateConsoleEncoding(System.Text.Encoding) (FullOpts)
           4 (26.67% of base) : 109304.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.executeOrder.nested02a.nested02a.Test:Bar1(int):int (FullOpts)
           4 (26.67% of base) : 119031.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.executeOrder.nested02b.nested02b.Test:Bar1(System.Object):int (FullOpts)
           4 (26.67% of base) : 110362.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.executeOrder.nested05a.nested05a.Test:Bar1(System.Object):int (FullOpts)
           4 (26.67% of base) : 110782.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.executeOrder.order03a.order03a.Test:Bar1():int (FullOpts)
           4 (26.67% of base) : 115420.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.namedandoptional.usage.executeOrder.order05.order05.Test:Bar1():int (FullOpts)

Top method improvements (percentages):
         -63 (-77.78% of base) : 150698.dasm - System.SpanTests.MemoryMarshalTests+<>c__DisplayClass38_0:<CreateFromPinnedArrayWrongArrayType>b__0():System.Object:this (FullOpts)
        -858 (-73.27% of base) : 158795.dasm - System.Net.Http.WinHttpHandlerUnitTests.APICallHistory:Reset() (FullOpts)
        -858 (-73.27% of base) : 156895.dasm - System.Net.Http.WinHttpHandlerUnitTests.APICallHistory:Reset() (FullOpts)
        -379 (-71.51% of base) : 242946.dasm - System.Speech.Internal.Synthesis.PcmConverter:FindResampleFactors(int,int):this (FullOpts)
       -9745 (-71.35% of base) : 178010.dasm - System.Xml.Xsl.Xslt.XsltLoader:.ctor():this (FullOpts)
         -36 (-67.92% of base) : 23180.dasm - Microsoft.CodeAnalysis.FindSymbols.FindReferencesSearchOptions:.cctor() (FullOpts)
        -184 (-65.48% of base) : 94311.dasm - System.Data.FunctionNode:get_IsAggregate():ubyte:this (FullOpts)
        -323 (-64.73% of base) : 317628.dasm - System.Transactions.ContextData:set_TLSCurrentData(System.Transactions.ContextData) (FullOpts)
         -33 (-64.71% of base) : 152123.dasm - System.SpanTests.SpanTests+<>c__DisplayClass99_0:<CtorArrayWrongArrayType>b__1():this (FullOpts)
       -1542 (-64.44% of base) : 94269.dasm - System.Data.RBTree`1[int]:LeftRotate(int,int,int):int:this (FullOpts)
       -1542 (-64.44% of base) : 95510.dasm - System.Data.RBTree`1[int]:RightRotate(int,int,int):int:this (FullOpts)
       -1370 (-60.65% of base) : 94229.dasm - System.Data.RBTree`1[System.__Canon]:LeftRotate(int,int,int):int:this (FullOpts)
      -11534 (-60.07% of base) : 196720.dasm - System.IO.Tests.PathTests_Join:.cctor() (FullOpts)
       -1249 (-58.61% of base) : 73194.dasm - System.Collections.Frozen.Tests.FrozenDictionary_Generic_Tests`2[System.__Canon,System.__Canon]:NullSource_ThrowsException():this (FullOpts)
        -824 (-58.27% of base) : 185352.dasm - WebData.BaseLib.StringGen:GetIllegalXmlStringWithSeed(int,ubyte,int):System.String (FullOpts)
       -3224 (-58.16% of base) : 230094.dasm - System.Security.Cryptography.Pkcs.Tests.Certificates:.cctor() (FullOpts)
        -746 (-57.87% of base) : 222426.dasm - System.Tests.ArraySegment_Tests`1[System.__Canon]:CopyTo_Default_ThrowsInvalidOperationException():this (FullOpts)
        -906 (-57.12% of base) : 222412.dasm - System.Tests.ArraySegment_Tests`1[System.__Canon]:Ctor_Invalid():this (FullOpts)
         -82 (-56.55% of base) : 64591.dasm - System.Xml.Serialization.XmlCustomFormatter:get_Mode():int (FullOpts)
       -3532 (-55.08% of base) : 204278.dasm - System.Numerics.Tests.op_rightshiftTest:RunRightShiftTests() (FullOpts)

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

Total bytes of base: 14186268 (overridden on cmd)
Total bytes of diff: 13977657 (overridden on cmd)
Total bytes of delta: -208611 (-1.47 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
       12106 : 33489.dasm (10.05% of base)
        1640 : 15692.dasm (30.73% of base)
         732 : 14757.dasm (6.97% of base)
         709 : 15689.dasm (28.22% of base)
         675 : 1078.dasm (4.09% of base)
         542 : 33300.dasm (15.10% of base)
         517 : 15691.dasm (10.03% of base)
         510 : 1406.dasm (13.60% of base)
         485 : 23536.dasm (7.81% of base)
         480 : 29432.dasm (21.43% of base)
         455 : 1015.dasm (9.82% of base)
         446 : 1076.dasm (3.50% of base)
         376 : 1141.dasm (5.21% of base)
         370 : 1148.dasm (9.89% of base)
         346 : 23621.dasm (7.27% of base)
         314 : 1087.dasm (9.31% of base)
         277 : 11269.dasm (3.59% of base)
         275 : 19372.dasm (8.72% of base)
         274 : 22032.dasm (2.75% of base)
         250 : 7465.dasm (8.82% of base)

Top file improvements (bytes):
       -9165 : 6521.dasm (-40.61% of base)
       -6508 : 5328.dasm (-30.11% of base)
       -5605 : 2818.dasm (-36.36% of base)
       -5483 : 4478.dasm (-11.02% of base)
       -4521 : 5805.dasm (-4.91% of base)
       -4432 : 2550.dasm (-21.83% of base)
       -3792 : 2400.dasm (-28.86% of base)
       -3402 : 10478.dasm (-36.00% of base)
       -3255 : 32698.dasm (-16.32% of base)
       -3043 : 18417.dasm (-42.60% of base)
       -2887 : 17607.dasm (-18.07% of base)
       -2416 : 36059.dasm (-29.20% of base)
       -2408 : 2105.dasm (-52.45% of base)
       -2380 : 10477.dasm (-38.37% of base)
       -2000 : 21589.dasm (-15.81% of base)
       -1964 : 36372.dasm (-17.99% of base)
       -1847 : 5991.dasm (-38.06% of base)
       -1490 : 1663.dasm (-45.37% of base)
       -1464 : 2758.dasm (-10.03% of base)
       -1381 : 15465.dasm (-14.68% of base)

96 total files with Code Size differences (58 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
       12106 (10.05% of base) : 33489.dasm - System.Management.Automation.Runspaces.TypeTable:Process_Types_Ps1Xml(System.String,System.Collections.Concurrent.ConcurrentBag`1[System.String]):this (FullOpts)
        1640 (30.73% of base) : 15692.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Top(byref,int,int,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
         732 ( 6.97% of base) : 14757.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (FullOpts)
         709 (28.22% of base) : 15689.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Volume(byref,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
         675 ( 4.09% of base) : 1078.dasm - BepuPhysics.CollisionDetection.CollisionTasks.TrianglePairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
         542 (15.10% of base) : 33300.dasm - Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager:ProcessBuiltin(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors,Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase,Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory,System.Collections.Generic.List`1[Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry],byref):ubyte (FullOpts)
         517 (10.03% of base) : 15691.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Bottom(byref,int,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
         510 (13.60% of base) : 1406.dasm - BepuPhysics.Trees.Tree:GetOverlaps[BepuPhysics.CollisionDetection.CollidableOverlapFinder`1+IntertreeOverlapHandler[DemoBenchmarks.RagdollTubeBenchmark+SubgroupFilteredCallbacks]](byref,byref):this (FullOpts)
         485 ( 7.81% of base) : 23536.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator:GetTypeAndRefKind(Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator+TypeAndRefKind:this (FullOpts)
         480 (21.43% of base) : 29432.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex6_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         455 ( 9.82% of base) : 1015.dasm - BepuPhysics.CollisionDetection.SweepTasks.CapsuleBoxDistanceTester:Test(byref,byref,byref,byref,byref,byref,byref,byref,byref,byref):this (FullOpts)
         446 ( 3.50% of base) : 1076.dasm - BepuPhysics.CollisionDetection.CollisionTasks.CylinderPairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
         376 ( 5.21% of base) : 1141.dasm - BepuPhysics.Constraints.HingeFunctions:Solve(byref,byref,byref,byref,byref,byref,float,float,byref,byref,byref,byref):this (FullOpts)
         370 ( 9.89% of base) : 1148.dasm - BepuPhysics.Constraints.PointOnLineServoFunctions:Solve(byref,byref,byref,byref,byref,byref,float,float,byref,byref,byref,byref):this (FullOpts)
         346 ( 7.27% of base) : 23621.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase:AfterAddingTypeMembersChecks(Microsoft.CodeAnalysis.CSharp.ConversionsBase,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (FullOpts)
         314 ( 9.31% of base) : 1087.dasm - BepuPhysics.CollisionDetection.CollisionTasks.ConvexCompoundOverlapFinder`3[BepuPhysics.Collidables.Triangle,BepuPhysics.Collidables.TriangleWide,BepuPhysics.Collidables.Compound]:FindLocalOverlaps(byref,int,BepuUtilities.Memory.BufferPool,BepuPhysics.Collidables.Shapes,float,byref):this (FullOpts)
         277 ( 3.59% of base) : 11269.dasm - FSharp.Compiler.PostTypeCheckSemanticChecks:TryCheckResumableCodeConstructs(FSharp.Compiler.PostTypeCheckSemanticChecks+cenv,FSharp.Compiler.PostTypeCheckSemanticChecks+env,FSharp.Compiler.TypedTree+Expr):ubyte (FullOpts)
         275 ( 8.72% of base) : 19372.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseNamespaceBody(byref,byref,byref,ushort):this (FullOpts)
         274 ( 2.75% of base) : 22032.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol+AliasesAndUsings:<GetUsingsAndDiagnostics>g__buildUsings|16_0(Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax],Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,System.Nullable`1[ubyte],Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]):Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol+AliasesAndUsings+UsingsAndDiagnostics:this (FullOpts)
         250 ( 8.82% of base) : 7465.dasm - System.Xml.Linq.XContainer+ContentReader:ReadContentFromContainer(System.Xml.Linq.XContainer,System.Xml.XmlReader):ubyte:this (FullOpts)

Top method improvements (bytes):
       -9165 (-40.61% of base) : 6521.dasm - <StartupCode$FSharp-Compiler-Service>.$FSharp.Compiler.Lexhelp:.cctor() (FullOpts)
       -6508 (-30.11% of base) : 5328.dasm - <StartupCode$FSharp-Compiler-Service>.$FSharp.Compiler.TypedTreePickle:.cctor() (FullOpts)
       -5605 (-36.36% of base) : 2818.dasm - <StartupCode$FSharp-Compiler-Service>.$FSharp.Compiler.AbstractIL.ILBinaryReader:.cctor() (FullOpts)
       -5483 (-11.02% of base) : 4478.dasm - <StartupCode$FSharp-Compiler-Service>.$FSharp.Compiler.Lexer:.cctor() (FullOpts)
       -4521 (-4.91% of base) : 5805.dasm - FSharp.Compiler.TcGlobals+TcGlobals:.ctor(ubyte,FSharp.Compiler.AbstractIL.IL+ILGlobals,FSharp.Compiler.TypedTree+CcuThunk,System.String,ubyte,ubyte,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpList`1[System.String],Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+CcuThunk]]],ubyte,ubyte,Internal.Utilities.PathMap,FSharp.Compiler.Features+LanguageVersion):this (FullOpts)
       -4432 (-21.83% of base) : 2550.dasm - <StartupCode$FSharp-Compiler-Service>.$FSharp.Compiler.Syntax.PrettyNaming:.cctor() (FullOpts)
       -3792 (-28.86% of base) : 2400.dasm - <StartupCode$FSharp-Compiler-Service>.$FSharp.Compiler.Features:.cctor() (FullOpts)
       -3402 (-36.00% of base) : 10478.dasm - <StartupCode$FSharp-Compiler-Service>.$Sformat:.cctor() (FullOpts)
       -3255 (-16.32% of base) : 32698.dasm - System.Management.Automation.Runspaces.InitialSessionState:get_BuiltInAliases():System.Management.Automation.Runspaces.SessionStateAliasEntry[] (FullOpts)
       -3043 (-42.60% of base) : 18417.dasm - System.Net.HeaderInfoTable:CreateHeaderHashtable():System.Collections.Hashtable (FullOpts)
       -2887 (-18.07% of base) : 17607.dasm - System.Net.Http.Headers.KnownHeaders:.cctor() (FullOpts)
       -2416 (-29.20% of base) : 36059.dasm - System.Management.Automation.ReflectionParameterBinder:.cctor() (FullOpts)
       -2408 (-52.45% of base) : 2105.dasm - <StartupCode$FSharp-Core>.$Reflect:.cctor() (FullOpts)
       -2380 (-38.37% of base) : 10477.dasm - <StartupCode$FSharp-Compiler-Service>.$TextLayoutRender:.cctor() (FullOpts)
       -2000 (-15.81% of base) : 21589.dasm - System.Text.RegularExpressions.RegexCompiler:.cctor() (FullOpts)
       -1964 (-17.99% of base) : 36372.dasm - System.Management.Automation.Verbs:.cctor() (FullOpts)
       -1847 (-38.06% of base) : 5991.dasm - FSharp.Compiler.AbstractIL.BinaryConstants+ILNativeTypeMap@890:Invoke(Microsoft.FSharp.Core.Unit):Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[ubyte,FSharp.Compiler.AbstractIL.IL+ILNativeType]]:this (FullOpts)
       -1490 (-45.37% of base) : 1663.dasm - System.Xml.XmlDocument:.ctor(System.Xml.XmlImplementation):this (FullOpts)
       -1464 (-10.03% of base) : 2758.dasm - FSharp.Compiler.FxResolver:.ctor(ubyte,System.String,ubyte,ubyte,FSharp.Compiler.Text.Range,Microsoft.FSharp.Core.FSharpOption`1[System.String]):this (FullOpts)
       -1381 (-14.68% of base) : 15465.dasm - SixLabors.ImageSharp.Metadata.Profiles.Exif.ExifTag:.cctor() (FullOpts)

Top method regressions (percentages):
          28 (46.67% of base) : 957.dasm - System.Random+Net5CompatSeedImpl:NextSingle():float:this (FullOpts)
           7 (36.84% of base) : 30224.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+DecisionDagRewriter+<>c:<LowerDecisionDagCore>b__10_0(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode):ubyte:this (FullOpts)
        1640 (30.73% of base) : 15692.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Top(byref,int,int,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
         709 (28.22% of base) : 15689.dasm - SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:Volume(byref,System.ReadOnlySpan`1[SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32]]):SixLabors.ImageSharp.Processing.Processors.Quantization.WuQuantizer`1+Moment[SixLabors.ImageSharp.PixelFormats.Rgba32] (FullOpts)
           6 (27.27% of base) : 509.dasm - System.Reflection.AssemblyName:set_ProcessorArchitecture(int):this (FullOpts)
          44 (25.14% of base) : 24610.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol:GrowPool(int) (FullOpts)
          12 (24.00% of base) : 15841.dasm - SixLabors.ImageSharp.Processing.Processors.Transforms.RotateProcessor`1[SixLabors.ImageSharp.PixelFormats.Rgba32]:WrapDegrees(float):float (FullOpts)
          39 (23.21% of base) : 15832.dasm - System.Numerics.Matrix3x2:op_Multiply(System.Numerics.Matrix3x2,System.Numerics.Matrix3x2):System.Numerics.Matrix3x2 (FullOpts)
          36 (23.08% of base) : 12454.dasm - Microsoft.FSharp.Core.LanguagePrimitives+HashCompare:GenericEqualityObjArray(ubyte,System.Collections.IEqualityComparer,System.Object[],System.Object[]):ubyte (FullOpts)
          33 (21.57% of base) : 25797.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult`1[System.__Canon]:get_HasAnyApplicableMember():ubyte:this (FullOpts)
         480 (21.43% of base) : 29432.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex6_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          25 (20.66% of base) : 15125.dasm - SixLabors.ImageSharp.Formats.Png.Filters.PaethFilter:PaethPredictor(System.Runtime.Intrinsics.Vector256`1[ubyte],System.Runtime.Intrinsics.Vector256`1[ubyte],System.Runtime.Intrinsics.Vector256`1[ubyte]):System.Runtime.Intrinsics.Vector256`1[ubyte] (FullOpts)
          44 (18.72% of base) : 29407.dasm - Microsoft.CodeAnalysis.AnalyzerConfig+SectionNameLexer:Lex():int:this (FullOpts)
          32 (18.18% of base) : 27032.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:ResolveBranches(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol,Microsoft.CodeAnalysis.CSharp.BoundStatement):ubyte:this (FullOpts)
          54 (17.76% of base) : 25990.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:DoVisitList[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon]:this (FullOpts)
          18 (17.31% of base) : 4804.dasm - System.Diagnostics.TraceListener:WriteIndent():this (FullOpts)
           5 (17.24% of base) : 13227.dasm - System.Xml.Linq.XElement:Attribute(System.Xml.Linq.XName):System.Xml.Linq.XAttribute:this (FullOpts)
          26 (17.11% of base) : 26533.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:JoinPendingBranches(byref,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol):this (FullOpts)
           9 (16.98% of base) : 1770.dasm - System.Text.StringBuilder:Append(ushort):System.Text.StringBuilder:this (FullOpts)
           5 (16.67% of base) : 26103.dasm - Microsoft.CodeAnalysis.CSharp.ControlFlowPass:Join(byref,byref):ubyte:this (FullOpts)

Top method improvements (percentages):
        -497 (-61.06% of base) : 2372.dasm - FSharp.Compiler.Text.RangeModule:rangeN(System.String,int):FSharp.Compiler.Text.Range (FullOpts)
        -352 (-60.48% of base) : 4788.dasm - System.Diagnostics.TraceInternal:InitializeSettings() (FullOpts)
        -331 (-57.77% of base) : 18566.dasm - Microsoft.ML.Transforms.Text.TextNormalizingTransformer+Mapper:get_CombinedDiacriticsMap():System.Collections.Generic.Dictionary`2[ushort,ushort] (FullOpts)
        -112 (-55.72% of base) : 857.dasm - System.Threading.PortableThreadPool:get_HasForcedMaxThreads():ubyte (FullOpts)
        -112 (-55.72% of base) : 856.dasm - System.Threading.PortableThreadPool:get_HasForcedMinThreads():ubyte (FullOpts)
       -2408 (-52.45% of base) : 2105.dasm - <StartupCode$FSharp-Core>.$Reflect:.cctor() (FullOpts)
         -93 (-52.25% of base) : 3236.dasm - Microsoft.Build.Shared.NativeMethodsShared:get_IsOSX():ubyte (FullOpts)
         -93 (-52.25% of base) : 3234.dasm - Microsoft.Build.Shared.NativeMethodsShared:get_IsWindows():ubyte (FullOpts)
        -219 (-52.02% of base) : 2467.dasm - <StartupCode$FSharp-Compiler-Service>.$FSComp:.cctor() (FullOpts)
        -219 (-52.02% of base) : 2076.dasm - <StartupCode$FSharp-Compiler-Service>.$UtilsStrings:.cctor() (FullOpts)
        -186 (-48.31% of base) : 34747.dasm - System.Management.Automation.Interpreter.InstructionList:Parameter(int):System.Management.Automation.Interpreter.Instruction (FullOpts)
        -377 (-48.15% of base) : 32595.dasm - System.Management.Automation.Security.SystemPolicy:GetSystemLockdownPolicy():int (FullOpts)
        -498 (-46.46% of base) : 34558.dasm - System.Management.Automation.Language.TypeResolver:CallResolveTypeNameWorkerHelper(System.Management.Automation.Language.TypeName,System.Management.Automation.ExecutionContext,System.Collections.Generic.IEnumerable`1[System.Reflection.Assembly],ubyte,System.Management.Automation.Language.TypeResolutionState,byref):System.Type (FullOpts)
        -458 (-46.40% of base) : 15336.dasm - SixLabors.ImageSharp.Formats.Jpeg.JpegDecoderCore:DeduceJpegColorType():ubyte:this (FullOpts)
       -1490 (-45.37% of base) : 1663.dasm - System.Xml.XmlDocument:.ctor(System.Xml.XmlImplementation):this (FullOpts)
         -14 (-43.75% of base) : 2142.dasm - System.Numerics.INumber`1[ushort]:Min(ushort,ushort):ushort (FullOpts)
        -140 (-43.34% of base) : 18843.dasm - Roslyn.Utilities.PathUtilities:IsAbsolute(System.String):ubyte (FullOpts)
         -94 (-43.32% of base) : 36465.dasm - System.Management.Automation.Runspaces.LocalPipeline:ClearStreams():this (FullOpts)
        -152 (-43.30% of base) : 20665.dasm - System.Decimal:.cctor() (FullOpts)
       -1151 (-43.21% of base) : 2342.dasm - FSharp.Compiler.Text.RangeModule:mkFirstLineOfFile(System.String):FSharp.Compiler.Text.Range (FullOpts)

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

Total bytes of base: 5191733 (overridden on cmd)
Total bytes of diff: 5112828 (overridden on cmd)
Total bytes of delta: -78905 (-1.52 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         257 : 11561.dasm (3.06% of base)
         159 : 6204.dasm (7.97% of base)
         157 : 14917.dasm (8.78% of base)
         157 : 11555.dasm (8.79% of base)
         133 : 22717.dasm (28.60% of base)
         132 : 2212.dasm (24.31% of base)
         132 : 6901.dasm (24.31% of base)
         129 : 2377.dasm (14.81% of base)
         123 : 4762.dasm (5.31% of base)
         121 : 20163.dasm (13.86% of base)
         121 : 22861.dasm (13.86% of base)
         121 : 17498.dasm (13.86% of base)
         111 : 16716.dasm (4.92% of base)
         111 : 1499.dasm (4.92% of base)
         111 : 19482.dasm (4.92% of base)
         111 : 22067.dasm (4.92% of base)
         106 : 18404.dasm (9.37% of base)
         105 : 523.dasm (9.17% of base)
         105 : 3746.dasm (9.17% of base)
         103 : 21240.dasm (9.15% of base)

Top file improvements (bytes):
       -1906 : 10142.dasm (-65.07% of base)
       -1278 : 10433.dasm (-27.67% of base)
       -1278 : 32325.dasm (-27.67% of base)
        -810 : 4960.dasm (-46.02% of base)
        -810 : 10505.dasm (-46.02% of base)
        -521 : 23599.dasm (-51.13% of base)
        -514 : 12847.dasm (-22.13% of base)
        -514 : 7477.dasm (-22.13% of base)
        -443 : 8138.dasm (-63.20% of base)
        -411 : 23238.dasm (-10.33% of base)
        -411 : 23343.dasm (-10.33% of base)
        -411 : 15305.dasm (-10.21% of base)
        -411 : 17995.dasm (-10.03% of base)
        -411 : 20654.dasm (-10.24% of base)
        -402 : 18.dasm (-43.98% of base)
        -386 : 11128.dasm (-41.96% of base)
        -386 : 5772.dasm (-41.96% of base)
        -319 : 23588.dasm (-80.15% of base)
        -311 : 12144.dasm (-54.18% of base)
        -311 : 6378.dasm (-54.18% of base)

98 total files with Code Size differences (51 improved, 47 regressed), 20 unchanged.

Top method regressions (bytes):
         257 ( 3.06% of base) : 11561.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
         159 ( 7.97% of base) : 6204.dasm - System.DefaultBinder:SelectProperty(int,System.Reflection.PropertyInfo[],System.Type,System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.PropertyInfo:this (FullOpts)
         157 ( 8.78% of base) : 14917.dasm - System.DefaultBinder:SelectProperty(int,System.Reflection.PropertyInfo[],System.Type,System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.PropertyInfo:this (FullOpts)
         157 ( 8.79% of base) : 11555.dasm - System.DefaultBinder:SelectProperty(int,System.Reflection.PropertyInfo[],System.Type,System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.PropertyInfo:this (FullOpts)
         133 (28.60% of base) : 22717.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
         132 (24.31% of base) : 2212.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
         132 (24.31% of base) : 6901.dasm - System.Buffers.ProbabilisticMap:IndexOfAnyVectorized(byref,byref,int,System.ReadOnlySpan`1[ushort]):int (FullOpts)
         129 (14.81% of base) : 2377.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         123 ( 5.31% of base) : 4762.dasm - System.Text.ValueStringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):this (FullOpts)
         121 (13.86% of base) : 20163.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         121 (13.86% of base) : 22861.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         121 (13.86% of base) : 17498.dasm - System.Collections.Generic.ArraySortHelper`2[System.__Canon,System.__Canon]:PickPivotAndPartition(System.Span`1[System.__Canon],System.Span`1[System.__Canon],System.Collections.Generic.IComparer`1[System.__Canon]):int (FullOpts)
         111 ( 4.92% of base) : 16716.dasm - System.Text.ValueStringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):this (FullOpts)
         111 ( 4.92% of base) : 1499.dasm - System.Text.ValueStringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):this (FullOpts)
         111 ( 4.92% of base) : 19482.dasm - System.Text.ValueStringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):this (FullOpts)
         111 ( 4.92% of base) : 22067.dasm - System.Text.ValueStringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):this (FullOpts)
         106 ( 9.37% of base) : 18404.dasm - System.Enum:FormatFlagNames[uint](System.Reflection.EnumInfo`1[uint],uint):System.String (FullOpts)
         105 ( 9.17% of base) : 523.dasm - System.Enum:FormatFlagNames[uint](System.Reflection.EnumInfo`1[uint],uint):System.String (FullOpts)
         105 ( 9.17% of base) : 3746.dasm - System.Enum:FormatFlagNames[uint](System.Reflection.EnumInfo`1[uint],uint):System.String (FullOpts)
         103 ( 9.15% of base) : 21240.dasm - System.Enum:FormatFlagNames[uint](System.Reflection.EnumInfo`1[uint],uint):System.String (FullOpts)

Top method improvements (bytes):
       -1906 (-65.07% of base) : 10142.dasm - System.Linq.Expressions.Utils:.cctor() (FullOpts)
       -1278 (-27.67% of base) : 10433.dasm - Generics+TestFieldAccess:TestStaticFields() (FullOpts)
       -1278 (-27.67% of base) : 32325.dasm - Generics+TestFieldAccess:TestStaticFields() (FullOpts)
        -810 (-46.02% of base) : 4960.dasm - System.Threading.LowLevelLock:WaitAndAcquire():this (FullOpts)
        -810 (-46.02% of base) : 10505.dasm - System.Threading.LowLevelLock:WaitAndAcquire():this (FullOpts)
        -521 (-51.13% of base) : 23599.dasm - System.Runtime.ThunkBlocks:GetNewThunksBlock():long (FullOpts)
        -514 (-22.13% of base) : 12847.dasm - Internal.Runtime.TypeLoader.TypeBuilder:FinishTypeAndMethodBuilding():this (FullOpts)
        -514 (-22.13% of base) : 7477.dasm - Internal.Runtime.TypeLoader.TypeBuilder:FinishTypeAndMethodBuilding():this (FullOpts)
        -443 (-63.20% of base) : 8138.dasm - Microsoft.Win32.Registry:.cctor() (FullOpts)
        -411 (-10.33% of base) : 23238.dasm - Program:Main():int (FullOpts)
        -411 (-10.33% of base) : 23343.dasm - Program:Main():int (FullOpts)
        -411 (-10.21% of base) : 15305.dasm - Program:Main():int (FullOpts)
        -411 (-10.03% of base) : 17995.dasm - Program:Main():int (FullOpts)
        -411 (-10.24% of base) : 20654.dasm - Program:Main():int (FullOpts)
        -402 (-43.98% of base) : 18.dasm - System.Runtime.InteropServices.ComWrappers:.cctor() (FullOpts)
        -386 (-41.96% of base) : 11128.dasm - System.Threading.LowLevelLock:SignalWaiter():this (FullOpts)
        -386 (-41.96% of base) : 5772.dasm - System.Threading.LowLevelLock:SignalWaiter():this (FullOpts)
        -319 (-80.15% of base) : 23588.dasm - System.Runtime.Constants:.cctor() (FullOpts)
        -311 (-54.18% of base) : 12144.dasm - System.DateTimeFormat:.cctor() (FullOpts)
        -311 (-54.18% of base) : 6378.dasm - System.DateTimeFormat:.cctor() (FullOpts)

Top method regressions (percentages):
           6 (54.55% of base) : 25527.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt64(byref):ulong (FullOpts)
           5 (50.00% of base) : 29099.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)
           5 (50.00% of base) : 27433.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)
           5 (50.00% of base) : 26480.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)
           5 (50.00% of base) : 26790.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt32(byref):uint (FullOpts)
           5 (50.00% of base) : 26270.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt8(byref):ubyte (FullOpts)
           5 (50.00% of base) : 29160.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt8(byref):ubyte (FullOpts)
           5 (45.45% of base) : 26269.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt16(byref):ushort (FullOpts)
           5 (45.45% of base) : 27434.dasm - Internal.NativeFormat.NativePrimitiveDecoder:ReadUInt16(byref):ushort (FullOpts)
           6 (35.29% of base) : 5726.dasm - System.Reflection.AssemblyName:set_Flags(int):this (FullOpts)
           6 (35.29% of base) : 16886.dasm - System.Reflection.AssemblyName:set_Flags(int):this (FullOpts)
           6 (35.29% of base) : 22290.dasm - System.Reflection.AssemblyName:set_Flags(int):this (FullOpts)
           6 (35.29% of base) : 19570.dasm - System.Reflection.AssemblyName:set_Flags(int):this (FullOpts)
           6 (35.29% of base) : 1710.dasm - System.Reflection.AssemblyName:set_Flags(int):this (FullOpts)
          10 (33.33% of base) : 14137.dasm - System.Globalization.CalendricalCalculationsHelper:InitLongitude(double):double (FullOpts)
          10 (33.33% of base) : 8499.dasm - System.Globalization.CalendricalCalculationsHelper:InitLongitude(double):double (FullOpts)
           4 (33.33% of base) : 26192.dasm - System.Index:GetOffset(int):int:this (FullOpts)
          24 (30.77% of base) : 7520.dasm - Internal.NativeFormat.NativePrimitiveDecoder:SkipInteger(byref) (FullOpts)
          24 (30.77% of base) : 19967.dasm - Internal.NativeFormat.NativePrimitiveDecoder:SkipInteger(byref) (FullOpts)
          24 (30.77% of base) : 2585.dasm - Internal.NativeFormat.NativePrimitiveDecoder:SkipInteger(byref) (FullOpts)

Top method improvements (percentages):
        -319 (-80.15% of base) : 23588.dasm - System.Runtime.Constants:.cctor() (FullOpts)
       -1906 (-65.07% of base) : 10142.dasm - System.Linq.Expressions.Utils:.cctor() (FullOpts)
        -125 (-64.43% of base) : 1137.dasm - System.Diagnostics.Stopwatch:.cctor() (FullOpts)
        -125 (-64.43% of base) : 4429.dasm - System.Diagnostics.Stopwatch:.cctor() (FullOpts)
        -272 (-64.15% of base) : 1362.dasm - System.Threading.Thread:UninitializeCom() (FullOpts)
        -272 (-64.15% of base) : 4860.dasm - System.Threading.Thread:UninitializeCom() (FullOpts)
        -125 (-64.10% of base) : 16325.dasm - System.Diagnostics.Stopwatch:.cctor() (FullOpts)
        -125 (-64.10% of base) : 21700.dasm - System.Diagnostics.Stopwatch:.cctor() (FullOpts)
        -125 (-64.10% of base) : 18989.dasm - System.Diagnostics.Stopwatch:.cctor() (FullOpts)
        -272 (-63.70% of base) : 19294.dasm - System.Threading.Thread:UninitializeCom() (FullOpts)
        -272 (-63.70% of base) : 21922.dasm - System.Threading.Thread:UninitializeCom() (FullOpts)
        -272 (-63.70% of base) : 16600.dasm - System.Threading.Thread:UninitializeCom() (FullOpts)
        -443 (-63.20% of base) : 8138.dasm - Microsoft.Win32.Registry:.cctor() (FullOpts)
        -307 (-62.78% of base) : 2790.dasm - System.TimeZoneInfo:.cctor() (FullOpts)
        -307 (-62.78% of base) : 8913.dasm - System.TimeZoneInfo:.cctor() (FullOpts)
         -87 (-62.14% of base) : 1577.dasm - System.Runtime.InteropServices.TrackerObjectManager:.cctor() (FullOpts)
        -141 (-61.04% of base) : 28161.dasm - System.HashCode:Initialize(byref,byref,byref,byref) (FullOpts)
        -104 (-57.78% of base) : 4398.dasm - System.Threading.PortableThreadPool:get_HasForcedMaxThreads():ubyte (FullOpts)
        -104 (-57.78% of base) : 9827.dasm - System.Threading.PortableThreadPool:get_HasForcedMaxThreads():ubyte (FullOpts)
        -104 (-57.78% of base) : 9828.dasm - System.Threading.PortableThreadPool:get_HasForcedMinThreads():ubyte (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
