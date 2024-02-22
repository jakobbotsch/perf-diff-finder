Diffs are based on <span style="color:#1460aa">2,446,624</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,491,330</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">10,932 (0.44%)</span>, diff: <span style="color:#d35400">6,965 (0.28%)</span>

Base JIT options: JitDoRedundantBranchOpts=0


<details>
<summary>Overall (<span style="color:green">-6,087,551</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,536,071|<span style="color:green">-142,383</span>|<span style="color:green">-3.43%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|36,055,124|<span style="color:green">-648,448</span>|<span style="color:green">-3.40%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,742,496|<span style="color:green">-42,580</span>|<span style="color:green">-3.04%</span>|
|coreclr_tests.run.windows.x64.checked.mch|388,277,212|<span style="color:green">-1,546,265</span>|<span style="color:green">-11.78%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,196,363|<span style="color:green">-105,298</span>|<span style="color:green">-2.09%</span>|
|libraries.pmi.windows.x64.checked.mch|61,765,198|<span style="color:green">-511,254</span>|<span style="color:green">-3.82%</span>|
|libraries_tests.run.windows.x64.Release.mch|286,116,316|<span style="color:green">-1,722,102</span>|<span style="color:green">-4.09%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|136,905,963|<span style="color:green">-1,241,807</span>|<span style="color:green">-2.93%</span>|
|realworld.run.windows.x64.checked.mch|14,026,480|<span style="color:green">-76,320</span>|<span style="color:green">-2.83%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,161,080|<span style="color:green">-51,094</span>|<span style="color:green">-5.05%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-6,087,551</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,535,711|<span style="color:green">-142,383</span>|<span style="color:green">-3.43%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|22,152,500|<span style="color:green">-648,448</span>|<span style="color:green">-3.40%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,509,713|<span style="color:green">-42,580</span>|<span style="color:green">-3.04%</span>|
|coreclr_tests.run.windows.x64.checked.mch|107,834,132|<span style="color:green">-1,546,265</span>|<span style="color:green">-11.78%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,195,176|<span style="color:green">-105,298</span>|<span style="color:green">-2.09%</span>|
|libraries.pmi.windows.x64.checked.mch|61,651,704|<span style="color:green">-511,254</span>|<span style="color:green">-3.82%</span>|
|libraries_tests.run.windows.x64.Release.mch|106,469,297|<span style="color:green">-1,722,102</span>|<span style="color:green">-4.09%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|126,613,084|<span style="color:green">-1,241,807</span>|<span style="color:green">-2.93%</span>|
|realworld.run.windows.x64.checked.mch|13,640,312|<span style="color:green">-76,320</span>|<span style="color:green">-2.83%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,160,133|<span style="color:green">-51,094</span>|<span style="color:green">-5.05%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-59.49%</span>) : 12418.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M8984_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M8984_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M8984_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M8984_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M8984_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 48
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M8984_IG06
-						;; size=18 bbWeight=0.50 PerfScore 2.88
-G_M8984_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M8984_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=16 bbWeight=0.50 PerfScore 1.88
+G_M8984_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M8984_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M8984_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 79, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 79 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
+; Total bytes of code 32, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 32 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-59.49%</span>) : 61.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M8984_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M8984_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M8984_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M8984_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M8984_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 48
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M8984_IG06
-						;; size=18 bbWeight=0.50 PerfScore 2.88
-G_M8984_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M8984_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=16 bbWeight=0.50 PerfScore 1.88
+G_M8984_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M8984_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M8984_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 79, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 79 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
+; Total bytes of code 32, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 32 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-58.02%</span>) : 12674.dasm - System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M65221_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M65221_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M65221_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M65221_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M65221_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M65221_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M65221_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M65221_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M65221_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M65221_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M65221_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 0x1000
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M65221_IG06
-						;; size=20 bbWeight=0.50 PerfScore 2.88
-G_M65221_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M65221_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=18 bbWeight=0.50 PerfScore 1.88
+G_M65221_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M65221_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M65221_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 81, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 81 (MethodHash=1945013a) for method System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 34 (MethodHash=1945013a) for method System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+6.18%</span>) : 6061.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,7 +12,7 @@
 ;  V01 loc0         [V01,T26] (  4,  4   )     int  ->  rax        
 ;* V02 loc1         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Interop+Sec_Application_Protocols>
 ;* V03 loc2         [V03    ] (  0,  0   )     int  ->  zero-ref   
-;  V04 loc3         [V04,T11] (  7, 16   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
+;  V04 loc3         [V04,T14] (  6, 12   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
 ;  V05 loc4         [V05,T01] (  8, 29   )     int  ->  registers  
 ;  V06 loc5         [V06,T02] (  7, 25   )     int  ->  rdi        
 ;* V07 loc6         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ubyte]>
@@ -25,7 +25,7 @@
 ;* V14 tmp4         [V14    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;* V15 tmp5         [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V16 tmp6         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[ubyte]>
-;  V17 tmp7         [V17,T29] (  2,  4   )     int  ->  r14         "Inlining Arg"
+;  V17 tmp7         [V17,T29] (  2,  4   )     int  ->  rcx         "Inlining Arg"
 ;  V18 tmp8         [V18,T27] (  2,  4   )   byref  ->  rdx         single-def "Inlining Arg"
 ;* V19 tmp9         [V19    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V20 tmp10        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -34,12 +34,12 @@
 ;* V23 tmp13        [V23    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ubyte[]>
 ;* V24 tmp14        [V24    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlyMemory`1[ubyte]>
 ;* V25 tmp15        [V25    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
-;  V26 tmp16        [V26,T12] (  6, 16   )   byref  ->  r14         "Inline stloc first use temp"
-;  V27 tmp17        [V27,T07] (  7, 20   )     int  ->  r12         "Inline stloc first use temp"
+;  V26 tmp16        [V26,T10] (  6, 16   )   byref  ->  r15         "Inline stloc first use temp"
+;  V27 tmp17        [V27,T07] (  7, 20   )     int  ->  [rsp+0x44]  "Inline stloc first use temp"
 ;* V28 tmp18        [V28    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Object>
 ;* V29 tmp19        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V30 tmp20        [V30    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <<unknown class>>
-;  V31 tmp21        [V31    ] (  3,  6   )  struct (16) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
+;  V31 tmp21        [V31    ] (  3,  6   )  struct (16) [rsp+0x30]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
 ;* V32 tmp22        [V32    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V33 tmp23        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V34 tmp24        [V34    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <ubyte[]>
@@ -53,20 +53,20 @@
 ;* V42 tmp32        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;* V43 tmp33        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V44 tmp34        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[ubyte]>
-;  V45 tmp35        [V45,T06] (  3, 24   )     int  ->  r13         "Inlining Arg"
-;  V46 tmp36        [V46,T13] (  2, 16   )   byref  ->  rsi         "Inlining Arg"
+;  V45 tmp35        [V45,T06] (  3, 24   )     int  ->  [rsp+0x2C]  spill-single-def "Inlining Arg"
+;  V46 tmp36        [V46,T11] (  2, 16   )   byref  ->  rsi         "Inlining Arg"
 ;* V47 tmp37        [V47    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V48 tmp38        [V48    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V49 tmp39        [V49    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[ubyte]>
 ;* V50 tmp40        [V50    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V51 tmp41        [V51    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V52 tmp42        [V52,T14] (  2, 16   )    long  ->   r8         "Inlining Arg"
+;  V52 tmp42        [V52,T12] (  2, 16   )    long  ->   r8         "Inlining Arg"
 ;  V53 tmp43        [V53,T31] (  2,  2   )     int  ->  rsi         "field V02.ProtocolListsSize (fldOffset=0x0)" P-INDEP
 ;* V54 tmp44        [V54,T35] (  0,  0   )     int  ->  zero-ref    "field V02.ProtocolExtensionType (fldOffset=0x4)" P-INDEP
 ;  V55 tmp45        [V55,T32] (  2,  2   )   short  ->  rdi         "field V02.ProtocolListSize (fldOffset=0x8)" P-INDEP
-;  V56 tmp46        [V56,T18] (  2,  8   )   byref  ->  r14         "field V07._reference (fldOffset=0x0)" P-INDEP
-;  V57 tmp47        [V57,T08] (  5, 20   )     int  ->  r12         "field V07._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp48        [V58,T15] (  3, 10   )     ref  ->  r14         "field V08._readOnlyProtocol (fldOffset=0x0)" P-INDEP
+;  V56 tmp46        [V56,T18] (  2,  8   )   byref  ->  r15         "field V07._reference (fldOffset=0x0)" P-INDEP
+;  V57 tmp47        [V57,T08] (  5, 20   )     int  ->  r13         "field V07._length (fldOffset=0x8)" P-INDEP
+;  V58 tmp48        [V58,T15] (  3, 10   )     ref  ->  r15         "field V08._readOnlyProtocol (fldOffset=0x0)" P-INDEP
 ;* V59 tmp49        [V59    ] (  0,  0   )     ref  ->  zero-ref    "field V09._object (fldOffset=0x0)" P-INDEP
 ;* V60 tmp50        [V60    ] (  0,  0   )     int  ->  zero-ref    "field V09._index (fldOffset=0x8)" P-INDEP
 ;* V61 tmp51        [V61    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0xc)" P-INDEP
@@ -75,39 +75,39 @@
 ;* V64 tmp54        [V64    ] (  0,  0   )   byref  ->  zero-ref    "field V13._reference (fldOffset=0x0)" P-INDEP
 ;* V65 tmp55        [V65    ] (  0,  0   )     int  ->  zero-ref    "field V13._length (fldOffset=0x8)" P-INDEP
 ;  V66 tmp56        [V66,T25] (  4,  4   )   byref  ->  rdx         "field V14._reference (fldOffset=0x0)" P-INDEP
-;  V67 tmp57        [V67,T33] (  2,  2   )     int  ->  r14         "field V14._length (fldOffset=0x8)" P-INDEP
+;  V67 tmp57        [V67,T33] (  2,  2   )     int  ->  rcx         "field V14._length (fldOffset=0x8)" P-INDEP
 ;  V68 tmp58        [V68,T30] (  2,  2   )   byref  ->  rdx         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V69 tmp59        [V69,T34] (  2,  2   )     int  ->  r14         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V69 tmp59        [V69,T34] (  2,  2   )     int  ->  rcx         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V70 tmp60        [V70    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V16._reference (fldOffset=0x0)" P-INDEP
 ;* V71 tmp61        [V71    ] (  0,  0   )     int  ->  zero-ref    "field V16._length (fldOffset=0x8)" P-INDEP
 ;* V72 tmp62        [V72    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V21._reference (fldOffset=0x0)" P-INDEP
 ;* V73 tmp63        [V73    ] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V74 tmp64        [V74    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V22._reference (fldOffset=0x0)" P-INDEP
 ;* V75 tmp65        [V75    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
-;  V76 tmp66        [V76,T04] ( 11, 24   )     ref  ->  r15         "field V24._object (fldOffset=0x0)" P-INDEP
+;  V76 tmp66        [V76,T04] ( 11, 24   )     ref  ->  r13         "field V24._object (fldOffset=0x0)" P-INDEP
 ;* V77 tmp67        [V77    ] (  0,  0   )     int  ->  zero-ref    "field V24._index (fldOffset=0x8)" P-INDEP
-;  V78 tmp68        [V78,T16] (  4,  8   )     int  ->  r13         "field V24._length (fldOffset=0xc)" P-INDEP
+;  V78 tmp68        [V78,T16] (  4,  8   )     int  ->  r12         "field V24._length (fldOffset=0xc)" P-INDEP
 ;* V79 tmp69        [V79    ] (  0,  0   )   byref  ->  zero-ref    "field V25._reference (fldOffset=0x0)" P-INDEP
 ;* V80 tmp70        [V80    ] (  0,  0   )     int  ->  zero-ref    "field V25._length (fldOffset=0x8)" P-INDEP
-;  V81 tmp71        [V81,T19] (  2,  8   )   byref  ->  r14         "field V29._reference (fldOffset=0x0)" P-INDEP
-;  V82 tmp72        [V82,T22] (  2,  8   )     int  ->  r12         "field V29._length (fldOffset=0x8)" P-INDEP
-;  V83 tmp73        [V83    ] (  2,  4   )   byref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V31._reference (fldOffset=0x0)" P-DEP
-;  V84 tmp74        [V84    ] (  2,  4   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V31._length (fldOffset=0x8)" P-DEP
-;  V85 tmp75        [V85,T28] (  2,  4   )   byref  ->  r14         "field V39._reference (fldOffset=0x0)" P-INDEP
+;  V81 tmp71        [V81,T19] (  2,  8   )   byref  ->  r15         "field V29._reference (fldOffset=0x0)" P-INDEP
+;  V82 tmp72        [V82,T22] (  2,  8   )     int  ->  r13         "field V29._length (fldOffset=0x8)" P-INDEP
+;  V83 tmp73        [V83    ] (  2,  4   )   byref  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V31._reference (fldOffset=0x0)" P-DEP
+;  V84 tmp74        [V84    ] (  2,  4   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V31._length (fldOffset=0x8)" P-DEP
+;  V85 tmp75        [V85,T28] (  2,  4   )   byref  ->  r15         "field V39._reference (fldOffset=0x0)" P-INDEP
 ;* V86 tmp76        [V86    ] (  0,  0   )     int  ->  zero-ref    "field V39._length (fldOffset=0x8)" P-INDEP
 ;  V87 tmp77        [V87,T20] (  2,  8   )   byref  ->  rcx         "field V42._reference (fldOffset=0x0)" P-INDEP
-;  V88 tmp78        [V88,T23] (  2,  8   )     int  ->  r13         "field V42._length (fldOffset=0x8)" P-INDEP
+;  V88 tmp78        [V88,T23] (  2,  8   )     int  ->  rax         "field V42._length (fldOffset=0x8)" P-INDEP
 ;  V89 tmp79        [V89,T21] (  2,  8   )   byref  ->  rcx         "field V43._reference (fldOffset=0x0)" P-INDEP
-;  V90 tmp80        [V90,T24] (  2,  8   )     int  ->  r13         "field V43._length (fldOffset=0x8)" P-INDEP
+;  V90 tmp80        [V90,T24] (  2,  8   )     int  ->  rax         "field V43._length (fldOffset=0x8)" P-INDEP
 ;* V91 tmp81        [V91    ] (  0,  0   )   byref  ->  zero-ref    "field V44._reference (fldOffset=0x0)" P-INDEP
 ;* V92 tmp82        [V92    ] (  0,  0   )     int  ->  zero-ref    "field V44._length (fldOffset=0x8)" P-INDEP
 ;* V93 tmp83        [V93    ] (  0,  0   )   byref  ->  zero-ref    "field V49._reference (fldOffset=0x0)" P-INDEP
 ;* V94 tmp84        [V94    ] (  0,  0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
 ;  V95 tmp85        [V95,T05] (  3, 24   )     ref  ->  rdx         "arr expr"
-;  V96 cse0         [V96,T10] (  6, 18   )     int  ->  registers   multi-def "CSE - aggressive"
+;  V96 cse0         [V96,T13] (  5, 14   )     int  ->  r14         "CSE - moderate"
 ;  V97 cse1         [V97,T03] ( 12, 24   )     ref  ->  rdx         multi-def "CSE - aggressive"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 72
 
 G_M9944_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -118,9 +118,9 @@ G_M9944_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 56
+       sub      rsp, 72
        xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       mov      qword ptr [rsp+0x30], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
 						;; size=26 bbWeight=1 PerfScore 9.75
@@ -140,10 +140,11 @@ G_M9944_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        ; gcr arg pop 0
        mov      rbp, rax
        ; gcrRegs +[rbp]
-       mov      r14d, dword ptr [rbp+0x08]
        lea      rdx, bword ptr [rbp+0x10]
        ; byrRegs +[rdx]
-       cmp      r14d, 10
+       mov      r14d, dword ptr [rbp+0x08]
+       mov      ecx, r14d
+       cmp      ecx, 10
        jb       G_M9944_IG20
        mov      dword ptr [rdx], esi
        mov      dword ptr [rdx+0x04], 2
@@ -152,7 +153,7 @@ G_M9944_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        xor      edi, edi
        cmp      dword ptr [rbx+0x10], 0
        jle      G_M9944_IG17
-						;; size=88 bbWeight=1 PerfScore 17.25
+						;; size=90 bbWeight=1 PerfScore 17.50
 G_M9944_IG03:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        ; byrRegs -[rdx]
@@ -163,38 +164,38 @@ G_M9944_IG03:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {},
        cmp      edi, dword ptr [rdx+0x08]
        jae      G_M9944_IG19
        mov      ecx, edi
-       mov      r14, gword ptr [rdx+8*rcx+0x10]
-       ; gcrRegs +[r14]
-       test     r14, r14
+       mov      r15, gword ptr [rdx+8*rcx+0x10]
+       ; gcrRegs +[r15]
+       test     r15, r15
        jne      SHORT G_M9944_IG05
 						;; size=34 bbWeight=4 PerfScore 54.00
 G_M9944_IG04:        ; bbWeight=2, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rdx r14]
-       xor      r15, r15
-       ; gcrRegs +[r15]
-       xor      r13d, r13d
+       ; gcrRegs -[rdx r15]
+       xor      r13, r13
+       ; gcrRegs +[r13]
+       xor      r12d, r12d
        jmp      SHORT G_M9944_IG06
 						;; size=8 bbWeight=2 PerfScore 5.00
-G_M9944_IG05:        ; bbWeight=2, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r15] +[r14]
-       mov      r15, r14
-       ; gcrRegs +[r15]
-       mov      r13d, dword ptr [r15+0x08]
+G_M9944_IG05:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r13] +[r15]
+       mov      r13, r15
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [r13+0x08]
 						;; size=7 bbWeight=2 PerfScore 4.50
-G_M9944_IG06:        ; bbWeight=4, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r14]
-       xor      r14, r14
-       ; byrRegs +[r14]
-       xor      r12d, r12d
-       test     r15, r15
+G_M9944_IG06:        ; bbWeight=4, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r15]
+       xor      r15, r15
+       ; byrRegs +[r15]
+       xor      eax, eax
+       test     r13, r13
        je       G_M9944_IG12
-						;; size=15 bbWeight=4 PerfScore 7.00
-G_M9944_IG07:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[r14]
-       mov      rdx, qword ptr [r15]
+						;; size=14 bbWeight=4 PerfScore 7.00
+G_M9944_IG07:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[r15]
+       mov      rdx, qword ptr [r13]
        test     dword ptr [rdx], 0xD1FFAB1E
        je       SHORT G_M9944_IG09
-       mov      rdx, r15
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; ubyte[]
        call     CORINFO_HELP_ISINSTANCEOFARRAY
@@ -209,16 +210,19 @@ G_M9944_IG07:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-						;; size=53 bbWeight=2 PerfScore 24.50
-G_M9944_IG08:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       lea      r14, bword ptr [r15+0x10]
-       ; byrRegs +[r14]
-       mov      r12d, dword ptr [r15+0x08]
+						;; size=54 bbWeight=2 PerfScore 24.50
+G_M9944_IG08:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       lea      r15, bword ptr [r13+0x10]
+       ; byrRegs +[r15]
+       mov      eax, dword ptr [r13+0x08]
+       mov      r13d, eax
+       ; gcrRegs -[r13]
        jmp      SHORT G_M9944_IG11
-						;; size=10 bbWeight=2 PerfScore 9.00
-G_M9944_IG09:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[r14]
-       mov      rdx, r15
+						;; size=13 bbWeight=2 PerfScore 9.50
+G_M9944_IG09:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[r13]
+       ; byrRegs -[r15]
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFCLASS
@@ -234,29 +238,31 @@ G_M9944_IG09:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
 						;; size=42 bbWeight=2 PerfScore 12.50
-G_M9944_IG10:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
-       lea      rdx, [rsp+0x28]
-       mov      rcx, r15
+G_M9944_IG10:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref
+       lea      rdx, [rsp+0x30]
+       mov      rcx, r13
...

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+6.18%</span>) : 14384.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,7 +12,7 @@
 ;  V01 loc0         [V01,T26] (  4,  4   )     int  ->  rax        
 ;* V02 loc1         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Interop+Sec_Application_Protocols>
 ;* V03 loc2         [V03    ] (  0,  0   )     int  ->  zero-ref   
-;  V04 loc3         [V04,T11] (  7, 16   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
+;  V04 loc3         [V04,T14] (  6, 12   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
 ;  V05 loc4         [V05,T01] (  8, 29   )     int  ->  registers  
 ;  V06 loc5         [V06,T02] (  7, 25   )     int  ->  rdi        
 ;* V07 loc6         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ubyte]>
@@ -25,7 +25,7 @@
 ;* V14 tmp4         [V14    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;* V15 tmp5         [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V16 tmp6         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[ubyte]>
-;  V17 tmp7         [V17,T29] (  2,  4   )     int  ->  r14         "Inlining Arg"
+;  V17 tmp7         [V17,T29] (  2,  4   )     int  ->  rcx         "Inlining Arg"
 ;  V18 tmp8         [V18,T27] (  2,  4   )   byref  ->  rdx         single-def "Inlining Arg"
 ;* V19 tmp9         [V19    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V20 tmp10        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -34,12 +34,12 @@
 ;* V23 tmp13        [V23    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ubyte[]>
 ;* V24 tmp14        [V24    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlyMemory`1[ubyte]>
 ;* V25 tmp15        [V25    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
-;  V26 tmp16        [V26,T12] (  6, 16   )   byref  ->  r14         "Inline stloc first use temp"
-;  V27 tmp17        [V27,T07] (  7, 20   )     int  ->  r12         "Inline stloc first use temp"
+;  V26 tmp16        [V26,T10] (  6, 16   )   byref  ->  r15         "Inline stloc first use temp"
+;  V27 tmp17        [V27,T07] (  7, 20   )     int  ->  [rsp+0x44]  "Inline stloc first use temp"
 ;* V28 tmp18        [V28    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Object>
 ;* V29 tmp19        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V30 tmp20        [V30    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <<unknown class>>
-;  V31 tmp21        [V31    ] (  3,  6   )  struct (16) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
+;  V31 tmp21        [V31    ] (  3,  6   )  struct (16) [rsp+0x30]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
 ;* V32 tmp22        [V32    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V33 tmp23        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V34 tmp24        [V34    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <ubyte[]>
@@ -53,20 +53,20 @@
 ;* V42 tmp32        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;* V43 tmp33        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V44 tmp34        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[ubyte]>
-;  V45 tmp35        [V45,T06] (  3, 24   )     int  ->  r13         "Inlining Arg"
-;  V46 tmp36        [V46,T13] (  2, 16   )   byref  ->  rsi         "Inlining Arg"
+;  V45 tmp35        [V45,T06] (  3, 24   )     int  ->  [rsp+0x2C]  spill-single-def "Inlining Arg"
+;  V46 tmp36        [V46,T11] (  2, 16   )   byref  ->  rsi         "Inlining Arg"
 ;* V47 tmp37        [V47    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V48 tmp38        [V48    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V49 tmp39        [V49    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[ubyte]>
 ;* V50 tmp40        [V50    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V51 tmp41        [V51    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V52 tmp42        [V52,T14] (  2, 16   )    long  ->   r8         "Inlining Arg"
+;  V52 tmp42        [V52,T12] (  2, 16   )    long  ->   r8         "Inlining Arg"
 ;  V53 tmp43        [V53,T31] (  2,  2   )     int  ->  rsi         "field V02.ProtocolListsSize (fldOffset=0x0)" P-INDEP
 ;* V54 tmp44        [V54,T35] (  0,  0   )     int  ->  zero-ref    "field V02.ProtocolExtensionType (fldOffset=0x4)" P-INDEP
 ;  V55 tmp45        [V55,T32] (  2,  2   )   short  ->  rdi         "field V02.ProtocolListSize (fldOffset=0x8)" P-INDEP
-;  V56 tmp46        [V56,T18] (  2,  8   )   byref  ->  r14         "field V07._reference (fldOffset=0x0)" P-INDEP
-;  V57 tmp47        [V57,T08] (  5, 20   )     int  ->  r12         "field V07._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp48        [V58,T15] (  3, 10   )     ref  ->  r14         "field V08._readOnlyProtocol (fldOffset=0x0)" P-INDEP
+;  V56 tmp46        [V56,T18] (  2,  8   )   byref  ->  r15         "field V07._reference (fldOffset=0x0)" P-INDEP
+;  V57 tmp47        [V57,T08] (  5, 20   )     int  ->  r13         "field V07._length (fldOffset=0x8)" P-INDEP
+;  V58 tmp48        [V58,T15] (  3, 10   )     ref  ->  r15         "field V08._readOnlyProtocol (fldOffset=0x0)" P-INDEP
 ;* V59 tmp49        [V59    ] (  0,  0   )     ref  ->  zero-ref    "field V09._object (fldOffset=0x0)" P-INDEP
 ;* V60 tmp50        [V60    ] (  0,  0   )     int  ->  zero-ref    "field V09._index (fldOffset=0x8)" P-INDEP
 ;* V61 tmp51        [V61    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0xc)" P-INDEP
@@ -75,39 +75,39 @@
 ;* V64 tmp54        [V64    ] (  0,  0   )   byref  ->  zero-ref    "field V13._reference (fldOffset=0x0)" P-INDEP
 ;* V65 tmp55        [V65    ] (  0,  0   )     int  ->  zero-ref    "field V13._length (fldOffset=0x8)" P-INDEP
 ;  V66 tmp56        [V66,T25] (  4,  4   )   byref  ->  rdx         "field V14._reference (fldOffset=0x0)" P-INDEP
-;  V67 tmp57        [V67,T33] (  2,  2   )     int  ->  r14         "field V14._length (fldOffset=0x8)" P-INDEP
+;  V67 tmp57        [V67,T33] (  2,  2   )     int  ->  rcx         "field V14._length (fldOffset=0x8)" P-INDEP
 ;  V68 tmp58        [V68,T30] (  2,  2   )   byref  ->  rdx         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V69 tmp59        [V69,T34] (  2,  2   )     int  ->  r14         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V69 tmp59        [V69,T34] (  2,  2   )     int  ->  rcx         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V70 tmp60        [V70    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V16._reference (fldOffset=0x0)" P-INDEP
 ;* V71 tmp61        [V71    ] (  0,  0   )     int  ->  zero-ref    "field V16._length (fldOffset=0x8)" P-INDEP
 ;* V72 tmp62        [V72    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V21._reference (fldOffset=0x0)" P-INDEP
 ;* V73 tmp63        [V73    ] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V74 tmp64        [V74    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V22._reference (fldOffset=0x0)" P-INDEP
 ;* V75 tmp65        [V75    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
-;  V76 tmp66        [V76,T04] ( 11, 24   )     ref  ->  r15         "field V24._object (fldOffset=0x0)" P-INDEP
+;  V76 tmp66        [V76,T04] ( 11, 24   )     ref  ->  r13         "field V24._object (fldOffset=0x0)" P-INDEP
 ;* V77 tmp67        [V77    ] (  0,  0   )     int  ->  zero-ref    "field V24._index (fldOffset=0x8)" P-INDEP
-;  V78 tmp68        [V78,T16] (  4,  8   )     int  ->  r13         "field V24._length (fldOffset=0xc)" P-INDEP
+;  V78 tmp68        [V78,T16] (  4,  8   )     int  ->  r12         "field V24._length (fldOffset=0xc)" P-INDEP
 ;* V79 tmp69        [V79    ] (  0,  0   )   byref  ->  zero-ref    "field V25._reference (fldOffset=0x0)" P-INDEP
 ;* V80 tmp70        [V80    ] (  0,  0   )     int  ->  zero-ref    "field V25._length (fldOffset=0x8)" P-INDEP
-;  V81 tmp71        [V81,T19] (  2,  8   )   byref  ->  r14         "field V29._reference (fldOffset=0x0)" P-INDEP
-;  V82 tmp72        [V82,T22] (  2,  8   )     int  ->  r12         "field V29._length (fldOffset=0x8)" P-INDEP
-;  V83 tmp73        [V83    ] (  2,  4   )   byref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V31._reference (fldOffset=0x0)" P-DEP
-;  V84 tmp74        [V84    ] (  2,  4   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V31._length (fldOffset=0x8)" P-DEP
-;  V85 tmp75        [V85,T28] (  2,  4   )   byref  ->  r14         "field V39._reference (fldOffset=0x0)" P-INDEP
+;  V81 tmp71        [V81,T19] (  2,  8   )   byref  ->  r15         "field V29._reference (fldOffset=0x0)" P-INDEP
+;  V82 tmp72        [V82,T22] (  2,  8   )     int  ->  r13         "field V29._length (fldOffset=0x8)" P-INDEP
+;  V83 tmp73        [V83    ] (  2,  4   )   byref  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V31._reference (fldOffset=0x0)" P-DEP
+;  V84 tmp74        [V84    ] (  2,  4   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V31._length (fldOffset=0x8)" P-DEP
+;  V85 tmp75        [V85,T28] (  2,  4   )   byref  ->  r15         "field V39._reference (fldOffset=0x0)" P-INDEP
 ;* V86 tmp76        [V86    ] (  0,  0   )     int  ->  zero-ref    "field V39._length (fldOffset=0x8)" P-INDEP
 ;  V87 tmp77        [V87,T20] (  2,  8   )   byref  ->  rcx         "field V42._reference (fldOffset=0x0)" P-INDEP
-;  V88 tmp78        [V88,T23] (  2,  8   )     int  ->  r13         "field V42._length (fldOffset=0x8)" P-INDEP
+;  V88 tmp78        [V88,T23] (  2,  8   )     int  ->  rax         "field V42._length (fldOffset=0x8)" P-INDEP
 ;  V89 tmp79        [V89,T21] (  2,  8   )   byref  ->  rcx         "field V43._reference (fldOffset=0x0)" P-INDEP
-;  V90 tmp80        [V90,T24] (  2,  8   )     int  ->  r13         "field V43._length (fldOffset=0x8)" P-INDEP
+;  V90 tmp80        [V90,T24] (  2,  8   )     int  ->  rax         "field V43._length (fldOffset=0x8)" P-INDEP
 ;* V91 tmp81        [V91    ] (  0,  0   )   byref  ->  zero-ref    "field V44._reference (fldOffset=0x0)" P-INDEP
 ;* V92 tmp82        [V92    ] (  0,  0   )     int  ->  zero-ref    "field V44._length (fldOffset=0x8)" P-INDEP
 ;* V93 tmp83        [V93    ] (  0,  0   )   byref  ->  zero-ref    "field V49._reference (fldOffset=0x0)" P-INDEP
 ;* V94 tmp84        [V94    ] (  0,  0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
 ;  V95 tmp85        [V95,T05] (  3, 24   )     ref  ->  rdx         "arr expr"
-;  V96 cse0         [V96,T10] (  6, 18   )     int  ->  registers   multi-def "CSE - aggressive"
+;  V96 cse0         [V96,T13] (  5, 14   )     int  ->  r14         "CSE - moderate"
 ;  V97 cse1         [V97,T03] ( 12, 24   )     ref  ->  rdx         multi-def "CSE - aggressive"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 72
 
 G_M9944_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -118,9 +118,9 @@ G_M9944_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 56
+       sub      rsp, 72
        xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       mov      qword ptr [rsp+0x30], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
 						;; size=26 bbWeight=1 PerfScore 9.75
@@ -140,10 +140,11 @@ G_M9944_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        ; gcr arg pop 0
        mov      rbp, rax
        ; gcrRegs +[rbp]
-       mov      r14d, dword ptr [rbp+0x08]
        lea      rdx, bword ptr [rbp+0x10]
        ; byrRegs +[rdx]
-       cmp      r14d, 10
+       mov      r14d, dword ptr [rbp+0x08]
+       mov      ecx, r14d
+       cmp      ecx, 10
        jb       G_M9944_IG20
        mov      dword ptr [rdx], esi
        mov      dword ptr [rdx+0x04], 2
@@ -152,7 +153,7 @@ G_M9944_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        xor      edi, edi
        cmp      dword ptr [rbx+0x10], 0
        jle      G_M9944_IG17
-						;; size=88 bbWeight=1 PerfScore 17.25
+						;; size=90 bbWeight=1 PerfScore 17.50
 G_M9944_IG03:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        ; byrRegs -[rdx]
@@ -163,38 +164,38 @@ G_M9944_IG03:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {},
        cmp      edi, dword ptr [rdx+0x08]
        jae      G_M9944_IG19
        mov      ecx, edi
-       mov      r14, gword ptr [rdx+8*rcx+0x10]
-       ; gcrRegs +[r14]
-       test     r14, r14
+       mov      r15, gword ptr [rdx+8*rcx+0x10]
+       ; gcrRegs +[r15]
+       test     r15, r15
        jne      SHORT G_M9944_IG05
 						;; size=34 bbWeight=4 PerfScore 54.00
 G_M9944_IG04:        ; bbWeight=2, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rdx r14]
-       xor      r15, r15
-       ; gcrRegs +[r15]
-       xor      r13d, r13d
+       ; gcrRegs -[rdx r15]
+       xor      r13, r13
+       ; gcrRegs +[r13]
+       xor      r12d, r12d
        jmp      SHORT G_M9944_IG06
 						;; size=8 bbWeight=2 PerfScore 5.00
-G_M9944_IG05:        ; bbWeight=2, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r15] +[r14]
-       mov      r15, r14
-       ; gcrRegs +[r15]
-       mov      r13d, dword ptr [r15+0x08]
+G_M9944_IG05:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r13] +[r15]
+       mov      r13, r15
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [r13+0x08]
 						;; size=7 bbWeight=2 PerfScore 4.50
-G_M9944_IG06:        ; bbWeight=4, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r14]
-       xor      r14, r14
-       ; byrRegs +[r14]
-       xor      r12d, r12d
-       test     r15, r15
+G_M9944_IG06:        ; bbWeight=4, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r15]
+       xor      r15, r15
+       ; byrRegs +[r15]
+       xor      eax, eax
+       test     r13, r13
        je       G_M9944_IG12
-						;; size=15 bbWeight=4 PerfScore 7.00
-G_M9944_IG07:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[r14]
-       mov      rdx, qword ptr [r15]
+						;; size=14 bbWeight=4 PerfScore 7.00
+G_M9944_IG07:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[r15]
+       mov      rdx, qword ptr [r13]
        test     dword ptr [rdx], 0xD1FFAB1E
        je       SHORT G_M9944_IG09
-       mov      rdx, r15
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; ubyte[]
        call     CORINFO_HELP_ISINSTANCEOFARRAY
@@ -209,16 +210,19 @@ G_M9944_IG07:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-						;; size=53 bbWeight=2 PerfScore 24.50
-G_M9944_IG08:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       lea      r14, bword ptr [r15+0x10]
-       ; byrRegs +[r14]
-       mov      r12d, dword ptr [r15+0x08]
+						;; size=54 bbWeight=2 PerfScore 24.50
+G_M9944_IG08:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       lea      r15, bword ptr [r13+0x10]
+       ; byrRegs +[r15]
+       mov      eax, dword ptr [r13+0x08]
+       mov      r13d, eax
+       ; gcrRegs -[r13]
        jmp      SHORT G_M9944_IG11
-						;; size=10 bbWeight=2 PerfScore 9.00
-G_M9944_IG09:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[r14]
-       mov      rdx, r15
+						;; size=13 bbWeight=2 PerfScore 9.50
+G_M9944_IG09:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[r13]
+       ; byrRegs -[r15]
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFCLASS
@@ -234,29 +238,31 @@ G_M9944_IG09:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
 						;; size=42 bbWeight=2 PerfScore 12.50
-G_M9944_IG10:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
-       lea      rdx, [rsp+0x28]
-       mov      rcx, r15
+G_M9944_IG10:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref
+       lea      rdx, [rsp+0x30]
+       mov      rcx, r13
...

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+13.79%</span>) : 26272.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,14 +7,14 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  6,  6   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  6,  6   )     int  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  5,  4   )     int  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  5,  4   )     int  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  registers  
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V07 tmp4         [V07,T02] (  3,  2   )     int  ->  rcx        
+;  V07 tmp4         [V07,T02] (  4,  2   )     int  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,30 +22,41 @@ G_M19887_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M19887_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ecx, edx
-       mov      eax, ecx
-       cmovg    eax, edx
-       cmovle   ecx, edx
-       cmp      eax, 3
-       jne      SHORT G_M19887_IG04
-						;; size=15 bbWeight=1 PerfScore 2.25
+       jg       SHORT G_M19887_IG04
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19887_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, 4
-       je       SHORT G_M19887_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jmp      SHORT G_M19887_IG05
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M19887_IG06
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, edx
+       jmp      SHORT G_M19887_IG07
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M19887_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, ecx
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       mov      ecx, edx
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M19887_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      ecx, 3
+       jne      SHORT G_M19887_IG09
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M19887_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      eax, 4
+       je       SHORT G_M19887_IG10
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M19887_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M19887_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M19887_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 5
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M19887_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 29, prolog size 0, PerfScore 4.12, instruction count 12, allocated bytes for code 29 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
+; Total bytes of code 33, prolog size 0, PerfScore 7.62, instruction count 15, allocated bytes for code 33 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-47.96%</span>) : 56099.dasm - System.Char:GetUnicodeCategory(ushort):int (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -30,56 +30,37 @@
 ;* V18 tmp17        [V18    ] (  0,  0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
 ;* V19 tmp18        [V19    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V08._reference (fldOffset=0x0)" P-INDEP
 ;* V20 tmp19        [V20    ] (  0,  0   )     int  ->  zero-ref    "field V08._length (fldOffset=0x8)" P-INDEP
-;  V21 cse0         [V21,T01] (  5,  4   )     int  ->  rbx         "CSE - aggressive"
+;  V21 cse0         [V21,T01] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
-G_M14053_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+G_M14053_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M14053_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rbx, cx
-       cmp      ebx, 256
-       jae      SHORT G_M14053_IG05
-       cmp      ebx, 256
-       jae      SHORT G_M14053_IG07
-						;; size=19 bbWeight=1 PerfScore 2.75
-G_M14053_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, ebx
+       movzx    rcx, cx
+       cmp      ecx, 256
+       jae      SHORT G_M14053_IG04
+       mov      eax, ecx
        mov      rcx, 0xD1FFAB1E      ; static handle
        movzx    rax, byte  ptr [rax+rcx]
        and      eax, 31
-						;; size=19 bbWeight=1 PerfScore 2.75
-G_M14053_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+						;; size=30 bbWeight=1 PerfScore 4.25
+G_M14053_IG03:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-G_M14053_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      ecx, ebx
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M14053_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     [System.Globalization.CharUnicodeInfo:GetUnicodeCategory(int):int]
        ; gcr arg pop 0
        nop      
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M14053_IG06:        ; bbWeight=0, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M14053_IG05:        ; bbWeight=0, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M14053_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-       jmp      SHORT G_M14053_IG03
-						;; size=34 bbWeight=0 PerfScore 0.00
+						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 98, prolog size 5, PerfScore 8.50, instruction count 25, allocated bytes for code 98 (MethodHash=c0eec91a) for method System.Char:GetUnicodeCategory(ushort):int (Tier1)
+; Total bytes of code 51, prolog size 4, PerfScore 5.75, instruction count 14, allocated bytes for code 51 (MethodHash=c0eec91a) for method System.Char:GetUnicodeCategory(ushort):int (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -87,10 +68,9 @@ Unwind Info:
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
<summary><span style="color:green">-47</span> (<span style="color:green">-47.96%</span>) : 82987.dasm - System.Char:GetUnicodeCategory(ushort):int (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -30,56 +30,37 @@
 ;* V18 tmp17        [V18    ] (  0,  0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
 ;* V19 tmp18        [V19    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V08._reference (fldOffset=0x0)" P-INDEP
 ;* V20 tmp19        [V20    ] (  0,  0   )     int  ->  zero-ref    "field V08._length (fldOffset=0x8)" P-INDEP
-;  V21 cse0         [V21,T01] (  5,  4   )     int  ->  rbx         "CSE - aggressive"
+;  V21 cse0         [V21,T01] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
-G_M14053_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+G_M14053_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M14053_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rbx, cx
-       cmp      ebx, 256
-       jae      SHORT G_M14053_IG05
-       cmp      ebx, 256
-       jae      SHORT G_M14053_IG07
-						;; size=19 bbWeight=1 PerfScore 2.75
-G_M14053_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, ebx
+       movzx    rcx, cx
+       cmp      ecx, 256
+       jae      SHORT G_M14053_IG04
+       mov      eax, ecx
        mov      rcx, 0xD1FFAB1E      ; static handle
        movzx    rax, byte  ptr [rax+rcx]
        and      eax, 31
-						;; size=19 bbWeight=1 PerfScore 2.75
-G_M14053_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+						;; size=30 bbWeight=1 PerfScore 4.25
+G_M14053_IG03:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-G_M14053_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      ecx, ebx
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M14053_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     [System.Globalization.CharUnicodeInfo:GetUnicodeCategory(int):int]
        ; gcr arg pop 0
        nop      
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M14053_IG06:        ; bbWeight=0, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M14053_IG05:        ; bbWeight=0, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M14053_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-       jmp      SHORT G_M14053_IG03
-						;; size=34 bbWeight=0 PerfScore 0.00
+						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 98, prolog size 5, PerfScore 8.50, instruction count 25, allocated bytes for code 98 (MethodHash=c0eec91a) for method System.Char:GetUnicodeCategory(ushort):int (Tier1)
+; Total bytes of code 51, prolog size 4, PerfScore 5.75, instruction count 14, allocated bytes for code 51 (MethodHash=c0eec91a) for method System.Char:GetUnicodeCategory(ushort):int (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -87,10 +68,9 @@ Unwind Info:
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
<summary><span style="color:green">-47</span> (<span style="color:green">-47.96%</span>) : 91822.dasm - System.Char:GetUnicodeCategory(ushort):int (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -30,56 +30,37 @@
 ;* V18 tmp17        [V18    ] (  0,  0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
 ;* V19 tmp18        [V19    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V08._reference (fldOffset=0x0)" P-INDEP
 ;* V20 tmp19        [V20    ] (  0,  0   )     int  ->  zero-ref    "field V08._length (fldOffset=0x8)" P-INDEP
-;  V21 cse0         [V21,T01] (  5,  4   )     int  ->  rbx         "CSE - aggressive"
+;  V21 cse0         [V21,T01] (  4,  3   )     int  ->  rcx         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
-G_M14053_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+G_M14053_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M14053_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       movzx    rbx, cx
-       cmp      ebx, 256
-       jae      SHORT G_M14053_IG05
-       cmp      ebx, 256
-       jae      SHORT G_M14053_IG07
-						;; size=19 bbWeight=1 PerfScore 2.75
-G_M14053_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, ebx
+       movzx    rcx, cx
+       cmp      ecx, 256
+       jae      SHORT G_M14053_IG04
+       mov      eax, ecx
        mov      rcx, 0xD1FFAB1E      ; static handle
        movzx    rax, byte  ptr [rax+rcx]
        and      eax, 31
-						;; size=19 bbWeight=1 PerfScore 2.75
-G_M14053_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+						;; size=30 bbWeight=1 PerfScore 4.25
+G_M14053_IG03:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-G_M14053_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      ecx, ebx
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M14053_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     [System.Globalization.CharUnicodeInfo:GetUnicodeCategory(int):int]
        ; gcr arg pop 0
        nop      
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M14053_IG06:        ; bbWeight=0, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M14053_IG05:        ; bbWeight=0, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M14053_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-       jmp      SHORT G_M14053_IG03
-						;; size=34 bbWeight=0 PerfScore 0.00
+						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 98, prolog size 5, PerfScore 8.50, instruction count 25, allocated bytes for code 98 (MethodHash=c0eec91a) for method System.Char:GetUnicodeCategory(ushort):int (Tier1)
+; Total bytes of code 51, prolog size 4, PerfScore 5.75, instruction count 14, allocated bytes for code 51 (MethodHash=c0eec91a) for method System.Char:GetUnicodeCategory(ushort):int (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -87,10 +68,9 @@ Unwind Info:
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
<summary><span style="color:red">+12</span> (<span style="color:red">+5.06%</span>) : 99341.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -64,20 +64,21 @@ G_M44435_IG06:        ; bbWeight=0.50, gcrefRegs=0140 {rsi r8}, byrefRegs=0008 {
        test     r8, r8
        setne    cl
        test     cl, cl
-       je       SHORT G_M44435_IG16
-						;; size=12 bbWeight=0.50 PerfScore 1.38
+       jne      SHORT G_M44435_IG08
+       jmp      SHORT G_M44435_IG16
+						;; size=14 bbWeight=0.50 PerfScore 2.38
 G_M44435_IG07:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[r8]
        test     rsi, rsi
        je       SHORT G_M44435_IG12
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M44435_IG08:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+G_M44435_IG08:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        mov      rax, rsi
        ; gcrRegs +[rax]
        mov      rcx, 0xD1FFAB1E      ; System.Threading.Channels.VoidAsyncOperationWithData`1[ubyte[]]
        cmp      qword ptr [rax], rcx
-       jne      SHORT G_M44435_IG17
-						;; size=18 bbWeight=0.50 PerfScore 2.25
+       jne      G_M44435_IG17
+						;; size=22 bbWeight=0.50 PerfScore 2.25
 G_M44435_IG09:        ; bbWeight=0.25, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        xor      rax, rax
@@ -111,7 +112,7 @@ G_M44435_IG13:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {},
        pop      rsi
        ret      
 						;; size=7 bbWeight=0.50 PerfScore 1.12
-G_M44435_IG14:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+G_M44435_IG14:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, gcvars, byref
        ; gcrRegs -[rax] +[rsi]
        ; byrRegs +[rbx]
        mov      rdx, rsi
@@ -120,9 +121,9 @@ G_M44435_IG14:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0040 {
        call     CORINFO_HELP_ISINSTANCEOFCLASS
        ; gcrRegs -[rdx] +[rax]
        ; gcr arg pop 0
-       jmp      SHORT G_M44435_IG05
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M44435_IG15:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+       jmp      G_M44435_IG05
+						;; size=23 bbWeight=0 PerfScore 0.00
+G_M44435_IG15:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        mov      rdx, rsi
        ; gcrRegs +[rdx]
@@ -132,8 +133,8 @@ G_M44435_IG15:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        ; gcr arg pop 0
        mov      r8, rax
        ; gcrRegs +[r8]
-       jmp      SHORT G_M44435_IG06
-						;; size=23 bbWeight=0 PerfScore 0.00
+       jmp      G_M44435_IG06
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M44435_IG16:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax r8]
        mov      rcx, 0xD1FFAB1E
@@ -143,7 +144,7 @@ G_M44435_IG16:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-       jmp      G_M44435_IG07
+       jmp      G_M44435_IG08
 						;; size=31 bbWeight=0 PerfScore 0.00
 G_M44435_IG17:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        mov      rdx, rsi
@@ -155,7 +156,7 @@ G_M44435_IG17:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        jmp      G_M44435_IG10
 						;; size=23 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 237, prolog size 9, PerfScore 20.63, instruction count 61, allocated bytes for code 237 (MethodHash=ff38526c) for method System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
+; Total bytes of code 249, prolog size 9, PerfScore 21.63, instruction count 62, allocated bytes for code 249 (MethodHash=ff38526c) for method System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+5.06%</span>) : 29685.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -64,20 +64,21 @@ G_M44435_IG06:        ; bbWeight=0.50, gcrefRegs=0140 {rsi r8}, byrefRegs=0008 {
        test     r8, r8
        setne    cl
        test     cl, cl
-       je       SHORT G_M44435_IG16
-						;; size=12 bbWeight=0.50 PerfScore 1.37
+       jne      SHORT G_M44435_IG08
+       jmp      SHORT G_M44435_IG16
+						;; size=14 bbWeight=0.50 PerfScore 2.37
 G_M44435_IG07:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[r8]
        test     rsi, rsi
        je       SHORT G_M44435_IG12
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M44435_IG08:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+G_M44435_IG08:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        mov      rax, rsi
        ; gcrRegs +[rax]
        mov      rcx, 0xD1FFAB1E      ; System.Threading.Channels.VoidAsyncOperationWithData`1[System.Object[]]
        cmp      qword ptr [rax], rcx
-       jne      SHORT G_M44435_IG17
-						;; size=18 bbWeight=0.50 PerfScore 2.25
+       jne      G_M44435_IG17
+						;; size=22 bbWeight=0.50 PerfScore 2.25
 G_M44435_IG09:        ; bbWeight=0.25, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        xor      rax, rax
@@ -111,7 +112,7 @@ G_M44435_IG13:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {},
        pop      rsi
        ret      
 						;; size=7 bbWeight=0.50 PerfScore 1.13
-G_M44435_IG14:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+G_M44435_IG14:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, gcvars, byref
        ; gcrRegs -[rax] +[rsi]
        ; byrRegs +[rbx]
        mov      rdx, rsi
@@ -120,9 +121,9 @@ G_M44435_IG14:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0040 {
        call     CORINFO_HELP_ISINSTANCEOFCLASS
        ; gcrRegs -[rdx] +[rax]
        ; gcr arg pop 0
-       jmp      SHORT G_M44435_IG05
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M44435_IG15:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+       jmp      G_M44435_IG05
+						;; size=23 bbWeight=0 PerfScore 0.00
+G_M44435_IG15:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        mov      rdx, rsi
        ; gcrRegs +[rdx]
@@ -132,8 +133,8 @@ G_M44435_IG15:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        ; gcr arg pop 0
        mov      r8, rax
        ; gcrRegs +[r8]
-       jmp      SHORT G_M44435_IG06
-						;; size=23 bbWeight=0 PerfScore 0.00
+       jmp      G_M44435_IG06
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M44435_IG16:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax r8]
        mov      rcx, 0xD1FFAB1E
@@ -143,7 +144,7 @@ G_M44435_IG16:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-       jmp      G_M44435_IG07
+       jmp      G_M44435_IG08
 						;; size=31 bbWeight=0 PerfScore 0.00
 G_M44435_IG17:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        mov      rdx, rsi
@@ -155,7 +156,7 @@ G_M44435_IG17:        ; bbWeight=0, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        jmp      G_M44435_IG10
 						;; size=23 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 237, prolog size 9, PerfScore 20.61, instruction count 61, allocated bytes for code 237 (MethodHash=ff38526c) for method System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
+; Total bytes of code 249, prolog size 9, PerfScore 21.61, instruction count 62, allocated bytes for code 249 (MethodHash=ff38526c) for method System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+3</span> (<span style="color:red">+5.56%</span>) : 69287.dasm - System.Reflection.PortableExecutable.ManagedTextSection:get_SizeOfImportTable():int:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,13 +9,13 @@
 ; 4 inlinees with PGO data; 7 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.PortableExecutable.ManagedTextSection>
+;  V00 this         [V00,T00] (  4,  3   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.PortableExecutable.ManagedTextSection>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ubyte]>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref   
 ;* V04 tmp2         [V04    ] (  0,  0   )     int  ->  zero-ref   
-;  V05 tmp3         [V05,T03] (  2,  2   )     int  ->  rax        
-;  V06 tmp4         [V06,T02] (  3,  2   )   ubyte  ->  rcx         "Inline return value spill temp"
+;  V05 tmp3         [V05,T02] (  3,  2   )     int  ->  rax        
+;  V06 tmp4         [V06,T03] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
 ;* V07 tmp5         [V07    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V08 tmp6         [V08    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V09 tmp7         [V09    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
@@ -40,27 +40,29 @@ G_M5324_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        je       SHORT G_M5324_IG05
        cmp      eax, 512
        je       SHORT G_M5324_IG05
-       xor      ecx, ecx
-       ; gcrRegs -[rcx]
        cmp      eax, 0xAA64
-       sete     cl
-						;; size=28 bbWeight=1 PerfScore 6.00
-G_M5324_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       sete     al
+       movzx    rax, al
+       test     eax, eax
+       jne      SHORT G_M5324_IG05
        mov      eax, 12
-       mov      edx, 16
-       test     ecx, ecx
-       cmovne   eax, edx
+						;; size=38 bbWeight=1 PerfScore 7.50
+G_M5324_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rcx]
        add      eax, 54
-						;; size=18 bbWeight=1 PerfScore 1.25
+						;; size=3 bbWeight=1 PerfScore 0.25
 G_M5324_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M5324_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      ecx, 1
+G_M5324_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx]
+       mov      eax, 16
+       test     word  ptr [rcx+0x20], 0x2000
+       jne      SHORT G_M5324_IG03
        jmp      SHORT G_M5324_IG03
-						;; size=7 bbWeight=0 PerfScore 0.00
+						;; size=15 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 54, prolog size 0, PerfScore 8.25, instruction count 16, allocated bytes for code 54 (MethodHash=ee85eb33) for method System.Reflection.PortableExecutable.ManagedTextSection:get_SizeOfImportTable():int:this (Tier1)
+; Total bytes of code 57, prolog size 0, PerfScore 8.75, instruction count 17, allocated bytes for code 57 (MethodHash=ee85eb33) for method System.Reflection.PortableExecutable.ManagedTextSection:get_SizeOfImportTable():int:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-59.49%</span>) : 2262.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M8984_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M8984_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M8984_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M8984_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M8984_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 48
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M8984_IG06
-						;; size=18 bbWeight=0.50 PerfScore 2.88
-G_M8984_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M8984_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=16 bbWeight=0.50 PerfScore 1.88
+G_M8984_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M8984_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M8984_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 79, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 79 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
+; Total bytes of code 32, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 32 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-58.02%</span>) : 4071.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M23673_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M23673_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M23673_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M23673_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M23673_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M23673_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M23673_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M23673_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M23673_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M23673_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M23673_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 0xD1FFAB1E
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M23673_IG06
-						;; size=20 bbWeight=0.50 PerfScore 2.88
-G_M23673_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M23673_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=18 bbWeight=0.50 PerfScore 1.88
+G_M23673_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M23673_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M23673_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 81, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 81 (MethodHash=471da386) for method System.RuntimeType:get_IsActualValueType():ubyte:this (Tier1)
+; Total bytes of code 34, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 34 (MethodHash=471da386) for method System.RuntimeType:get_IsActualValueType():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-58.02%</span>) : 2664.dasm - System.RuntimeType:get_IsInterface():ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M50337_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M50337_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M50337_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M50337_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M50337_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M50337_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M50337_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M50337_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M50337_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M50337_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M50337_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 0xD1FFAB1E
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M50337_IG06
-						;; size=20 bbWeight=0.50 PerfScore 2.88
-G_M50337_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M50337_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=18 bbWeight=0.50 PerfScore 1.88
+G_M50337_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M50337_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M50337_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 81, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 81 (MethodHash=6f1a3b5e) for method System.RuntimeType:get_IsInterface():ubyte:this (Tier1)
+; Total bytes of code 34, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 34 (MethodHash=6f1a3b5e) for method System.RuntimeType:get_IsInterface():ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+49</span> (<span style="color:red">+3.84%</span>) : 47532.dasm - System.IO.FileSystem:RemoveDirectoryRecursive(System.String,byref,ubyte) (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -9,23 +9,23 @@
 ; 0 inlinees with PGO data; 75 single block inlinees; 51 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] ( 14, 43   )     ref  ->  [rbp+0x160]  class-hnd EH-live single-def tier0-frame <System.String>
-;  V01 arg1         [V01,T00] ( 12, 50   )   byref  ->  [rbp+0x168]  EH-live single-def tier0-frame
-;  V02 arg2         [V02,T62] (  3,  3   )   ubyte  ->  [rbp+0x170]  EH-live single-def tier0-frame
-;  V03 loc0         [V03,T05] ( 14, 43   )     int  ->  rax        
+;  V00 arg0         [V00,T05] ( 11, 31   )     ref  ->  [rbp+0x160]  class-hnd EH-live single-def tier0-frame <System.String>
+;  V01 arg1         [V01,T00] ( 11, 46   )   byref  ->  [rbp+0x168]  EH-live single-def tier0-frame
+;  V02 arg2         [V02,T61] (  3,  3   )   ubyte  ->  [rbp+0x170]  EH-live single-def tier0-frame
+;  V03 loc0         [V03,T03] ( 14, 43   )     int  ->  rax        
 ;  V04 loc1         [V04,T07] ( 10, 25   )     ref  ->  [rbp+0x108]  do-not-enreg[Z] class-hnd EH-live tier0-frame <<unknown class>>
-;  V05 loc2         [V05,T35] (  5, 10   )     ref  ->  [rbp+0x100]  do-not-enreg[H] class-hnd exact EH-live tier0-frame <Microsoft.Win32.SafeHandles.SafeFindHandle>
+;  V05 loc2         [V05,T34] (  5, 10   )     ref  ->  [rbp+0x100]  do-not-enreg[H] class-hnd exact EH-live tier0-frame <Microsoft.Win32.SafeHandles.SafeFindHandle>
 ;* V06 loc3         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.String>
-;  V07 loc4         [V07,T01] ( 12, 48   )     ref  ->  rsi         class-hnd exact <System.String>
+;  V07 loc4         [V07,T04] ( 10, 40   )     ref  ->  rsi         class-hnd exact <System.String>
 ;* V08 loc5         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;* V09 loc6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.String>
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V12 tmp2         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V13 tmp3         [V13    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V14 tmp4         [V14,T72] (  2,  0   )     ref  ->  rdx         class-hnd "impSpillSpecialSideEff" <<unknown class>>
+;  V14 tmp4         [V14,T74] (  2,  0   )     ref  ->  rdx         class-hnd "impSpillSpecialSideEff" <<unknown class>>
 ;* V15 tmp5         [V15    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;* V16 tmp6         [V16,T71] (  0,  0   )     int  ->  zero-ref    "OSR entry state var"
+;* V16 tmp6         [V16,T73] (  0,  0   )     int  ->  zero-ref    "OSR entry state var"
 ;* V17 tmp7         [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.String>
 ;* V18 tmp8         [V18    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V19 tmp9         [V19    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
@@ -45,86 +45,86 @@
 ;* V33 tmp23        [V33    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.String>
 ;* V34 tmp24        [V34    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V35 tmp25        [V35    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V36 tmp26        [V36,T21] (  3, 12   )     ref  ->  rsi         class-hnd exact "Inline return value spill temp" <System.String>
-;  V37 tmp27        [V37    ] (  2,  8   )   byref  ->  [rbp-0x20]  must-init pinned "Inline stloc first use temp"
+;  V36 tmp26        [V36,T23] (  3, 12   )     ref  ->  rsi         class-hnd exact "Inline return value spill temp" <System.String>
+;  V37 tmp27        [V37    ] (  2,  8   )   byref  ->  [rbp-0x30]  must-init pinned "Inline stloc first use temp"
 ;* V38 tmp28        [V38    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V39 tmp29        [V39    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V40 tmp30        [V40,T27] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
+;  V40 tmp30        [V40,T29] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
 ;* V41 tmp31        [V41    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V42 tmp32        [V42    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V43 tmp33        [V43    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V44 tmp34        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;* V45 tmp35        [V45,T58] (  0,  0   )  ushort  ->  zero-ref    ld-addr-op "Inlining Arg"
+;* V45 tmp35        [V45,T57] (  0,  0   )  ushort  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V46 tmp36        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V47 tmp37        [V47    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;* V48 tmp38        [V48,T59] (  0,  0   )   short  ->  zero-ref    "Inlining Arg"
+;* V48 tmp38        [V48,T58] (  0,  0   )   short  ->  zero-ref    "Inlining Arg"
 ;* V49 tmp39        [V49    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V50 tmp40        [V50,T28] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
+;  V50 tmp40        [V50,T30] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
 ;* V51 tmp41        [V51    ] (  0,  0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V52 tmp42        [V52    ] (  0,  0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V53 tmp43        [V53    ] (  0,  0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V54 tmp44        [V54    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V55 tmp45        [V55,T02] (  6, 48   )     ref  ->  rdi         class-hnd "Inlining Arg" <System.String>
-;  V56 tmp46        [V56,T22] (  3, 12   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
+;  V55 tmp45        [V55,T01] (  6, 48   )     ref  ->  rdi         class-hnd "Inlining Arg" <System.String>
+;  V56 tmp46        [V56,T24] (  3, 12   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
 ;* V57 tmp47        [V57    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V58 tmp48        [V58    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V59 tmp49        [V59    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V60 tmp50        [V60    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V61 tmp51        [V61    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V62 tmp52        [V62    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V63 tmp53        [V63,T23] (  3, 12   )     ref  ->  rax         class-hnd exact "Inline return value spill temp" <System.String>
-;  V64 tmp54        [V64    ] (  2,  8   )   byref  ->  [rbp-0x28]  must-init pinned "Inline stloc first use temp"
+;  V63 tmp53        [V63,T25] (  3, 12   )     ref  ->  rax         class-hnd exact "Inline return value spill temp" <System.String>
+;  V64 tmp54        [V64    ] (  2,  8   )   byref  ->  [rbp-0x38]  must-init pinned "Inline stloc first use temp"
 ;* V65 tmp55        [V65    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V66 tmp56        [V66    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V67 tmp57        [V67,T29] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
+;  V67 tmp57        [V67,T31] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
 ;* V68 tmp58        [V68    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V69 tmp59        [V69    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V70 tmp60        [V70    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V71 tmp61        [V71    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;* V72 tmp62        [V72,T60] (  0,  0   )  ushort  ->  zero-ref    ld-addr-op "Inlining Arg"
+;* V72 tmp62        [V72,T59] (  0,  0   )  ushort  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V73 tmp63        [V73    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V74 tmp64        [V74    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;* V75 tmp65        [V75,T61] (  0,  0   )   short  ->  zero-ref    "Inlining Arg"
+;* V75 tmp65        [V75,T60] (  0,  0   )   short  ->  zero-ref    "Inlining Arg"
 ;* V76 tmp66        [V76    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V77 tmp67        [V77,T30] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
+;  V77 tmp67        [V77,T32] (  3, 12   )     int  ->   r8         "Inline return value spill temp"
 ;* V78 tmp68        [V78    ] (  0,  0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V79 tmp69        [V79    ] (  0,  0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V80 tmp70        [V80    ] (  0,  0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V81 tmp71        [V81    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V82 tmp72        [V82,T31] (  2,  8   )   ubyte  ->  rcx         "Inline return value spill temp"
-;  V83 tmp73        [V83,T06] (  8, 32   )     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
+;* V82 tmp72        [V82,T63] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V83 tmp73        [V83,T06] (  8, 32   )     ref  ->  r15         class-hnd "Inline return value spill temp" <System.String>
 ;* V84 tmp74        [V84    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V85 tmp75        [V85    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V86 tmp76        [V86    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V87 tmp77        [V87,T32] (  2,  8   )   ubyte  ->  rcx         "Inline return value spill temp"
-;  V88 tmp78        [V88,T24] (  3, 12   )     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
+;* V87 tmp77        [V87,T64] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V88 tmp78        [V88,T26] (  3, 12   )     ref  ->  r15         class-hnd "Inline return value spill temp" <System.String>
 ;* V89 tmp79        [V89    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V90 tmp80        [V90    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V91 tmp81        [V91    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "dup spill" <System.String>
-;* V92 tmp82        [V92,T63] (  0,  0   )     ref  ->  zero-ref   
-;  V93 tmp83        [V93,T33] (  2,  8   )   ubyte  ->  rcx         "Inline return value spill temp"
+;* V92 tmp82        [V92,T62] (  0,  0   )     ref  ->  zero-ref   
+;* V93 tmp83        [V93,T65] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V94 tmp84        [V94    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V95 tmp85        [V95    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V96 tmp86        [V96    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V97 tmp87        [V97,T15] (  2, 16   )     int  ->  rax         "Inlining Arg"
-;  V98 tmp88        [V98,T10] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
+;  V97 tmp87        [V97,T17] (  2, 16   )     int  ->  r14         "Inlining Arg"
+;  V98 tmp88        [V98,T12] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
 ;* V99 tmp89        [V99    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V100 tmp90       [V100    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V101 tmp91       [V101    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V102 tmp92       [V102    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V103 tmp93       [V103    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V104 tmp94       [V104,T34] (  2,  8   )   ubyte  ->  rcx         "Inline return value spill temp"
-;  V105 tmp95       [V105,T36] (  2,  8   )     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
+;* V104 tmp94       [V104,T66] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V105 tmp95       [V105,T35] (  2,  8   )     ref  ->  r15         class-hnd "Inline return value spill temp" <System.String>
 ;* V106 tmp96       [V106    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V107 tmp97       [V107    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V108 tmp98       [V108    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "dup spill" <System.String>
 ;* V109 tmp99       [V109    ] (  0,  0   )     ref  ->  zero-ref   
-;* V110 tmp100      [V110,T64] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V110 tmp100      [V110    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V111 tmp101      [V111    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V112 tmp102      [V112    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V113 tmp103      [V113    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V114 tmp104      [V114,T16] (  2, 16   )     int  ->  rax         "Inlining Arg"
-;  V115 tmp105      [V115,T11] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
+;  V114 tmp104      [V114,T18] (  2, 16   )     int  ->  rdi         "Inlining Arg"
+;  V115 tmp105      [V115,T13] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
 ;* V116 tmp106      [V116    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V117 tmp107      [V117    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V118 tmp108      [V118    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
@@ -133,23 +133,23 @@
 ;* V121 tmp111      [V121    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V122 tmp112      [V122    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V123 tmp113      [V123    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V124 tmp114      [V124,T17] (  2, 16   )     int  ->   r8         "Inlining Arg"
-;  V125 tmp115      [V125,T12] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
+;  V124 tmp114      [V124,T19] (  2, 16   )     int  ->   r8         "Inlining Arg"
+;  V125 tmp115      [V125,T14] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
 ;* V126 tmp116      [V126    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V127 tmp117      [V127    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V128 tmp118      [V128    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V129 tmp119      [V129    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V130 tmp120      [V130,T18] (  2, 16   )     int  ->  r10         "Inlining Arg"
-;  V131 tmp121      [V131,T13] (  2, 16   )   byref  ->  rax         "Inlining Arg"
+;  V130 tmp120      [V130,T20] (  2, 16   )     int  ->  r10         "Inlining Arg"
+;  V131 tmp121      [V131,T15] (  2, 16   )   byref  ->  rax         "Inlining Arg"
 ;* V132 tmp122      [V132    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V133 tmp123      [V133    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V134 tmp124      [V134    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V135 tmp125      [V135    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V136 tmp126      [V136    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V137 tmp127      [V137    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.String>
-;  V138 tmp128      [V138,T25] (  3, 12   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
-;  V139 tmp129      [V139,T03] (  6, 48   )     ref  ->  rdi         class-hnd "Inlining Arg" <System.String>
-;  V140 tmp130      [V140,T26] (  3, 12   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
+;  V138 tmp128      [V138,T27] (  3, 12   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
+;  V139 tmp129      [V139,T02] (  6, 48   )     ref  ->  rdi         class-hnd "Inlining Arg" <System.String>
+;  V140 tmp130      [V140,T28] (  3, 12   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
 ;* V141 tmp131      [V141    ] (  0,  0   )   byref  ->  zero-ref    "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V142 tmp132      [V142    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V143 tmp133      [V143    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
@@ -170,7 +170,7 @@
 ;* V158 tmp148      [V158    ] (  0,  0   )     int  ->  zero-ref    "field V30._length (fldOffset=0x8)" P-INDEP
 ;* V159 tmp149      [V159    ] (  0,  0   )   byref  ->  zero-ref    "field V31._reference (fldOffset=0x0)" P-INDEP
 ;* V160 tmp150      [V160    ] (  0,  0   )     int  ->  zero-ref    "field V31._length (fldOffset=0x8)" P-INDEP
-;  V161 tmp151      [V161,T08] (  4, 16   )   byref  ->  rcx         "field V35._reference (fldOffset=0x0)" P-INDEP
+;  V161 tmp151      [V161,T09] (  4, 16   )   byref  ->  rcx         "field V35._reference (fldOffset=0x0)" P-INDEP
 ;* V162 tmp152      [V162    ] (  0,  0   )     int  ->  zero-ref    "field V35._length (fldOffset=0x8)" P-INDEP
 ;* V163 tmp153      [V163    ] (  0,  0   )   byref  ->  zero-ref    "field V39._reference (fldOffset=0x0)" P-INDEP
 ;* V164 tmp154      [V164    ] (  0,  0   )     int  ->  zero-ref    "field V39._length (fldOffset=0x8)" P-INDEP
@@ -182,11 +182,11 @@
 ;* V170 tmp160      [V170    ] (  0,  0   )     int  ->  zero-ref    "field V46._length (fldOffset=0x8)" P-INDEP
 ;* V171 tmp161      [V171    ] (  0,  0   )   byref  ->  zero-ref    "field V54._reference (fldOffset=0x0)" P-INDEP
 ;* V172 tmp162      [V172    ] (  0,  0   )     int  ->  zero-ref    "field V54._length (fldOffset=0x8)" P-INDEP
-;  V173 tmp163      [V173,T37] (  2,  8   )   byref  ->  rcx         "field V58._reference (fldOffset=0x0)" P-INDEP
-;* V174 tmp164      [V174,T65] (  0,  0   )     int  ->  zero-ref    "field V58._length (fldOffset=0x8)" P-INDEP
-;  V175 tmp165      [V175,T38] (  2,  8   )   byref  ->  rcx         "field V60._reference (fldOffset=0x0)" P-INDEP
-;* V176 tmp166      [V176,T66] (  0,  0   )     int  ->  zero-ref    "field V60._length (fldOffset=0x8)" P-INDEP
-;  V177 tmp167      [V177,T09] (  4, 16   )   byref  ->  rcx         "field V62._reference (fldOffset=0x0)" P-INDEP
+;  V173 tmp163      [V173,T36] (  2,  8   )   byref  ->  rcx         "field V58._reference (fldOffset=0x0)" P-INDEP
+;* V174 tmp164      [V174,T67] (  0,  0   )     int  ->  zero-ref    "field V58._length (fldOffset=0x8)" P-INDEP
+;  V175 tmp165      [V175,T37] (  2,  8   )   byref  ->  rcx         "field V60._reference (fldOffset=0x0)" P-INDEP
+;* V176 tmp166      [V176,T68] (  0,  0   )     int  ->  zero-ref    "field V60._length (fldOffset=0x8)" P-INDEP
+;  V177 tmp167      [V177,T10] (  4, 16   )   byref  ->  rcx         "field V62._reference (fldOffset=0x0)" P-INDEP
 ;* V178 tmp168      [V178    ] (  0,  0   )     int  ->  zero-ref    "field V62._length (fldOffset=0x8)" P-INDEP
 ;* V179 tmp169      [V179    ] (  0,  0   )   byref  ->  zero-ref    "field V66._reference (fldOffset=0x0)" P-INDEP
 ;* V180 tmp170      [V180    ] (  0,  0   )     int  ->  zero-ref    "field V66._length (fldOffset=0x8)" P-INDEP
@@ -198,79 +198,83 @@
 ;* V186 tmp176      [V186    ] (  0,  0   )     int  ->  zero-ref    "field V73._length (fldOffset=0x8)" P-INDEP
 ;* V187 tmp177      [V187    ] (  0,  0   )   byref  ->  zero-ref    "field V81._reference (fldOffset=0x0)" P-INDEP
 ;* V188 tmp178      [V188    ] (  0,  0   )     int  ->  zero-ref    "field V81._length (fldOffset=0x8)" P-INDEP
-;  V189 tmp179      [V189,T39] (  2,  8   )   byref  ->  rcx         "field V84._reference (fldOffset=0x0)" P-INDEP
-;  V190 tmp180      [V190,T50] (  2,  8   )     int  ->   r8         "field V84._length (fldOffset=0x8)" P-INDEP
-;  V191 tmp181      [V191,T40] (  2,  8   )   byref  ->  rax         "field V85._reference (fldOffset=0x0)" P-INDEP
-;  V192 tmp182      [V192,T51] (  2,  8   )     int  ->  r10         "field V85._length (fldOffset=0x8)" P-INDEP
+;  V189 tmp179      [V189,T38] (  2,  8   )   byref  ->  rcx         "field V84._reference (fldOffset=0x0)" P-INDEP
+;  V190 tmp180      [V190,T49] (  2,  8   )     int  ->   r8         "field V84._length (fldOffset=0x8)" P-INDEP
+;  V191 tmp181      [V191,T39] (  2,  8   )   byref  ->  rax         "field V85._reference (fldOffset=0x0)" P-INDEP
+;  V192 tmp182      [V192,T50] (  2,  8   )     int  ->  r10         "field V85._length (fldOffset=0x8)" P-INDEP
 ;* V193 tmp183      [V193    ] (  0,  0   )   byref  ->  zero-ref    "field V86._reference (fldOffset=0x0)" P-INDEP
 ;* V194 tmp184      [V194    ] (  0,  0   )     int  ->  zero-ref    "field V86._length (fldOffset=0x8)" P-INDEP
-;  V195 tmp185      [V195,T41] (  2,  8   )   byref  ->  rcx         "field V89._reference (fldOffset=0x0)" P-INDEP
-;  V196 tmp186      [V196,T52] (  2,  8   )     int  ->  rax         "field V89._length (fldOffset=0x8)" P-INDEP
+;  V195 tmp185      [V195,T40] (  2,  8   )   byref  ->  rcx         "field V89._reference (fldOffset=0x0)" P-INDEP
+;  V196 tmp186      [V196,T51] (  2,  8   )     int  ->  r14         "field V89._length (fldOffset=0x8)" P-INDEP
 ;* V197 tmp187      [V197    ] (  0,  0   )   byref  ->  zero-ref    "field V90._reference (fldOffset=0x0)" P-INDEP
 ;* V198 tmp188      [V198    ] (  0,  0   )     int  ->  zero-ref    "field V90._length (fldOffset=0x8)" P-INDEP
-;  V199 tmp189      [V199,T42] (  2,  8   )   byref  ->  rcx         "field V95._reference (fldOffset=0x0)" P-INDEP
-;  V200 tmp190      [V200,T53] (  2,  8   )     int  ->  rax         "field V95._length (fldOffset=0x8)" P-INDEP
+;  V199 tmp189      [V199,T41] (  2,  8   )   byref  ->  rcx         "field V95._reference (fldOffset=0x0)" P-INDEP
+;  V200 tmp190      [V200,T52] (  2,  8   )     int  ->  r14         "field V95._length (fldOffset=0x8)" P-INDEP
 ;* V201 tmp191      [V201    ] (  0,  0   )   byref  ->  zero-ref    "field V96._reference (fldOffset=0x0)" P-INDEP
 ;* V202 tmp192      [V202    ] (  0,  0   )     int  ->  zero-ref    "field V96._length (fldOffset=0x8)" P-INDEP
 ;* V203 tmp193      [V203    ] (  0,  0   )   byref  ->  zero-ref    "field V101._reference (fldOffset=0x0)" P-INDEP
 ;* V204 tmp194      [V204    ] (  0,  0   )     int  ->  zero-ref    "field V101._length (fldOffset=0x8)" P-INDEP
-;  V205 tmp195      [V205,T43] (  2,  8   )   byref  ->   r8         "field V102._reference (fldOffset=0x0)" P-INDEP
-;* V206 tmp196      [V206,T67] (  0,  0   )     int  ->  zero-ref    "field V102._length (fldOffset=0x8)" P-INDEP
-;  V207 tmp197      [V207,T44] (  2,  8   )   byref  ->  rcx         "field V106._reference (fldOffset=0x0)" P-INDEP
-;  V208 tmp198      [V208,T54] (  2,  8   )     int  ->  rax         "field V106._length (fldOffset=0x8)" P-INDEP
+;  V205 tmp195      [V205,T42] (  2,  8   )   byref  ->  rax         "field V102._reference (fldOffset=0x0)" P-INDEP
+;* V206 tmp196      [V206,T69] (  0,  0   )     int  ->  zero-ref    "field V102._length (fldOffset=0x8)" P-INDEP
+;  V207 tmp197      [V207,T43] (  2,  8   )   byref  ->  rcx         "field V106._reference (fldOffset=0x0)" P-INDEP
+;  V208 tmp198      [V208,T53] (  2,  8   )     int  ->  rdi         "field V106._length (fldOffset=0x8)" P-INDEP
 ;* V209 tmp199      [V209    ] (  0,  0   )   byref  ->  zero-ref    "field V107._reference (fldOffset=0x0)" P-INDEP
 ;* V210 tmp200      [V210    ] (  0,  0   )     int  ->  zero-ref    "field V107._length (fldOffset=0x8)" P-INDEP
-;  V211 tmp201      [V211,T45] (  2,  8   )   byref  ->  rcx         "field V112._reference (fldOffset=0x0)" P-INDEP
-;  V212 tmp202      [V212,T55] (  2,  8   )     int  ->  rax         "field V112._length (fldOffset=0x8)" P-INDEP
+;  V211 tmp201      [V211,T44] (  2,  8   )   byref  ->  rcx         "field V112._reference (fldOffset=0x0)" P-INDEP
+;  V212 tmp202      [V212,T54] (  2,  8   )     int  ->  rdi         "field V112._length (fldOffset=0x8)" P-INDEP
 ;* V213 tmp203      [V213    ] (  0,  0   )   byref  ->  zero-ref    "field V113._reference (fldOffset=0x0)" P-INDEP
 ;* V214 tmp204      [V214    ] (  0,  0   )     int  ->  zero-ref    "field V113._length (fldOffset=0x8)" P-INDEP
 ;* V215 tmp205      [V215    ] (  0,  0   )   byref  ->  zero-ref    "field V118._reference (fldOffset=0x0)" P-INDEP
 ;* V216 tmp206      [V216    ] (  0,  0   )     int  ->  zero-ref    "field V118._length (fldOffset=0x8)" P-INDEP
-;  V217 tmp207      [V217,T46] (  2,  8   )   byref  ->   r8         "field V119._reference (fldOffset=0x0)" P-INDEP
...

```


</div></details>

<details>
<summary><span style="color:red">+16</span> (<span style="color:red">+4.61%</span>) : 8795.dasm - System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -16,11 +16,11 @@
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ubyte]>
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;  V07 tmp4         [V07,T05] (  6,  4   )   byref  ->  rdi         "Inline stloc first use temp"
-;  V08 tmp5         [V08,T01] (  9,  7   )     int  ->  rbp         "Inline stloc first use temp"
+;  V08 tmp5         [V08,T01] (  8,  6   )     int  ->  rbp         "Inline stloc first use temp"
 ;  V09 tmp6         [V09,T03] (  9,  5.50)     ref  ->  r14         class-hnd single-def "Inline stloc first use temp" <System.Object>
 ;* V10 tmp7         [V10    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V11 tmp8         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <<unknown class>>
-;  V12 tmp9         [V12    ] (  3,  1.50)  struct (16) [rsp+0x50]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
+;  V12 tmp9         [V12    ] (  3,  1.50)  struct (16) [rsp+0x48]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
 ;  V13 tmp10        [V13,T09] (  3,  1.50)    long  ->  rcx         "Inline stloc first use temp"
 ;  V14 tmp11        [V14,T10] (  3,  1.50)     int  ->  rdx         "Inline stloc first use temp"
 ;* V15 tmp12        [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "updating class info" <<unknown class>>
@@ -50,8 +50,8 @@
 ;* V39 tmp36        [V39    ] (  0,  0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
 ;* V40 tmp37        [V40    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V10._reference (fldOffset=0x0)" P-INDEP
 ;* V41 tmp38        [V41    ] (  0,  0   )     int  ->  zero-ref    "field V10._length (fldOffset=0x8)" P-INDEP
-;  V42 tmp39        [V42    ] (  2,  1   )   byref  ->  [rsp+0x50]  do-not-enreg[X] addr-exposed "field V12._reference (fldOffset=0x0)" P-DEP
-;  V43 tmp40        [V43    ] (  2,  1   )     int  ->  [rsp+0x58]  do-not-enreg[X] addr-exposed "field V12._length (fldOffset=0x8)" P-DEP
+;  V42 tmp39        [V42    ] (  2,  1   )   byref  ->  [rsp+0x48]  do-not-enreg[X] addr-exposed "field V12._reference (fldOffset=0x0)" P-DEP
+;  V43 tmp40        [V43    ] (  2,  1   )     int  ->  [rsp+0x50]  do-not-enreg[X] addr-exposed "field V12._length (fldOffset=0x8)" P-DEP
 ;  V44 tmp41        [V44,T11] (  2,  1   )   byref  ->  rdi         single-def "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V45 tmp42        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V46 tmp43        [V46    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V23._reference (fldOffset=0x0)" P-INDEP
@@ -61,25 +61,29 @@
 ;* V50 tmp47        [V50    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V29._reference (fldOffset=0x0)" P-INDEP
 ;* V51 tmp48        [V51    ] (  0,  0   )     int  ->  zero-ref    "field V29._length (fldOffset=0x8)" P-INDEP
 ;* V52 tmp49        [V52    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Memory`1[ubyte]>
-;  V53 tmp50        [V53    ] (  3,  6   )  struct (16) [rsp+0x40]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
-;  V54 cse0         [V54,T02] ( 12,  6   )     ref  ->  rdx         multi-def "CSE - aggressive"
+;  V53 tmp50        [V53    ] (  3,  6   )  struct (16) [rsp+0x38]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
+;  V54 cse0         [V54,T02] ( 11,  5.50)     ref  ->  r15         multi-def "CSE - aggressive"
 ;
-; Lcl frame size = 96
+; Lcl frame size = 88
 
 G_M59486_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 96
+       sub      rsp, 88
+       xor      eax, eax
+       mov      qword ptr [rsp+0x38], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x40], ymm4
+       vmovdqa  xmmword ptr [rsp+0x40], xmm4
+       mov      qword ptr [rsp+0x50], rax
        mov      rsi, rcx
        ; gcrRegs +[rsi]
        mov      rbx, rdx
        ; byrRegs +[rbx]
-						;; size=26 bbWeight=1 PerfScore 8.08
+						;; size=40 bbWeight=1 PerfScore 11.33
 G_M59486_IG02:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
        xor      rdi, rdi
        ; byrRegs +[rdi]
@@ -102,14 +106,16 @@ G_M59486_IG03:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0008
        ; gcr arg pop 0
        test     rax, rax
        jne      SHORT G_M59486_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      r15, 0xD1FFAB1E
+       ; gcrRegs +[r15]
+       mov      rcx, r15
        ; gcrRegs +[rcx]
+       mov      rdx, r15
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rax rcx rdx]
+       ; gcrRegs -[rax rcx rdx r15]
        ; gcr arg pop 0
-						;; size=53 bbWeight=0.50 PerfScore 6.12
+						;; size=56 bbWeight=0.50 PerfScore 6.25
 G_M59486_IG04:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0008 {rbx}, byref, isz
        lea      rdi, bword ptr [r14+0x10]
        ; byrRegs +[rdi]
@@ -126,16 +132,18 @@ G_M59486_IG05:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0008
        ; gcr arg pop 0
        test     rax, rax
        jne      SHORT G_M59486_IG06
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      r15, 0xD1FFAB1E
+       ; gcrRegs +[r15]
+       mov      rcx, r15
        ; gcrRegs +[rcx]
+       mov      rdx, r15
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rax rcx rdx]
+       ; gcrRegs -[rax rcx rdx r15]
        ; gcr arg pop 0
-						;; size=42 bbWeight=0.50 PerfScore 3.12
+						;; size=45 bbWeight=0.50 PerfScore 3.25
 G_M59486_IG06:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0008 {rbx}, byref
-       lea      rdx, [rsp+0x50]
+       lea      rdx, [rsp+0x48]
        mov      rcx, r14
        ; gcrRegs +[rcx]
        mov      rax, qword ptr [r14]
@@ -143,9 +151,9 @@ G_M59486_IG06:        ; bbWeight=0.50, gcrefRegs=4040 {rsi r14}, byrefRegs=0008
        call     [rax+0x28]<unknown method>
        ; gcrRegs -[rcx r14]
        ; gcr arg pop 0
-       mov      rdi, bword ptr [rsp+0x50]
+       mov      rdi, bword ptr [rsp+0x48]
        ; byrRegs +[rdi]
-       mov      ebp, dword ptr [rsp+0x58]
+       mov      ebp, dword ptr [rsp+0x50]
 						;; size=27 bbWeight=0.50 PerfScore 4.88
 G_M59486_IG07:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0088 {rbx rdi}, byref
        mov      ecx, dword ptr [rbx+0x08]
@@ -155,7 +163,7 @@ G_M59486_IG07:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0088 {rbx
        add      rax, rcx
        mov      r8d, ebp
        cmp      rax, r8
-       ja       G_M59486_IG19
+       ja       G_M59486_IG17
        add      rdi, rcx
        mov      ebp, edx
 						;; size=34 bbWeight=0.50 PerfScore 3.38
@@ -165,44 +173,40 @@ G_M59486_IG08:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi},
        jge      SHORT G_M59486_IG10
 						;; size=4 bbWeight=1 PerfScore 1.25
 G_M59486_IG09:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      r15, 0xD1FFAB1E
+       ; gcrRegs +[r15]
+       mov      rcx, r15
        ; gcrRegs +[rcx]
+       mov      rdx, r15
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-						;; size=19 bbWeight=0.50 PerfScore 1.75
-G_M59486_IG10:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref, isz
-       test     ebp, ebp
-       jge      SHORT G_M59486_IG12
-						;; size=4 bbWeight=1 PerfScore 1.25
-G_M59486_IG11:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      rcx, r15
        ; gcrRegs +[rcx]
+       mov      rdx, r15
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rcx rdx r15]
        ; gcr arg pop 0
-						;; size=19 bbWeight=0.50 PerfScore 1.75
-G_M59486_IG12:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref
+						;; size=34 bbWeight=0.50 PerfScore 3.62
+G_M59486_IG10:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0080 {rdi}, byref
        mov      rdx, rdi
        ; byrRegs +[rdx]
        mov      ecx, ebp
-       mov      bword ptr [rsp+0x40], rdx
-       mov      dword ptr [rsp+0x48], ecx
+       mov      bword ptr [rsp+0x38], rdx
+       mov      dword ptr [rsp+0x40], ecx
        xor      edx, edx
        ; byrRegs -[rdx]
        mov      qword ptr [rsp+0x20], rdx
 						;; size=21 bbWeight=1 PerfScore 3.75
-G_M59486_IG13:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
+G_M59486_IG11:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
        ; byrRegs -[rdi]
        mov      qword ptr [rsp+0x28], rdx
 						;; size=5 bbWeight=1 PerfScore 1.00
-G_M59486_IG14:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref, isz
+G_M59486_IG12:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref, isz
        mov      qword ptr [rsp+0x30], rdx
-       lea      rdx, [rsp+0x40]
+       lea      rdx, [rsp+0x38]
        mov      rcx, rsi
        ; gcrRegs +[rcx]
        mov      r8d, ebp
@@ -211,41 +215,43 @@ G_M59486_IG14:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byr
        ; gcrRegs -[rcx rsi]
        ; gcr arg pop 0
        cmp      eax, -1
-       je       SHORT G_M59486_IG17
+       je       SHORT G_M59486_IG15
 						;; size=30 bbWeight=1 PerfScore 6.50
-G_M59486_IG15:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M59486_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M59486_IG16:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 96
+G_M59486_IG14:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 88
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M59486_IG17:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=13 bbWeight=0.50 PerfScore 2.12
+G_M59486_IG15:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     <unknown method>
        ; gcr arg pop 0
        nop      
 						;; size=6 bbWeight=0.50 PerfScore 0.62
-G_M59486_IG18:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 96
+G_M59486_IG16:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 88
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M59486_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=13 bbWeight=0.50 PerfScore 2.12
+G_M59486_IG17:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        ; gcr arg pop 0
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 347, prolog size 20, PerfScore 53.33, instruction count 98, allocated bytes for code 347 (MethodHash=e53d17a1) for method System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (Tier1)
+; Total bytes of code 363, prolog size 34, PerfScore 56.21, instruction count 105, allocated bytes for code 363 (MethodHash=e53d17a1) for method System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -253,14 +259,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
...

```


</div></details>

<details>
<summary><span style="color:red">+19</span> (<span style="color:red">+5.26%</span>) : 49971.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]:TryMatch(byref,int,byref,uint,byref):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,14 +8,14 @@
 ; 0 inlinees with PGO data; 21 single block inlinees; 11 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T08] (  4, 18   )     ref  ->  rsi         this class-hnd single-def <System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]>
+;  V00 this         [V00,T07] (  4, 18   )     ref  ->  rbx         this class-hnd single-def <System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]>
 ;  V01 arg1         [V01,T13] (  4, 10.50)   byref  ->  rbp         single-def
-;  V02 arg2         [V02,T04] (  5, 26   )     int  ->  rbx         single-def
+;  V02 arg2         [V02,T08] (  4, 18   )     int  ->  rsi         single-def
 ;  V03 arg3         [V03,T14] (  3, 10   )   byref  ->  r14         single-def
 ;  V04 arg4         [V04,T09] (  4, 20   )     int  ->  rdi        
 ;  V05 arg5         [V05,T15] (  2,  1   )   byref  ->  [rsp+0x98]  single-def
-;  V06 loc0         [V06,T06] (  3, 24   )     int  ->  r15        
-;  V07 loc1         [V07,T05] (  4, 24.50)   byref  ->  r15        
+;  V06 loc0         [V06,T05] (  3, 24   )     int  ->  r15        
+;  V07 loc1         [V07,T04] (  4, 24.50)   byref  ->  r15        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V10 tmp2         [V10    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -61,8 +61,8 @@
 ;* V50 tmp42        [V50    ] (  0,  0   )     int  ->  zero-ref    "field V18._length (fldOffset=0x8)" P-INDEP
 ;* V51 tmp43        [V51    ] (  0,  0   )   byref  ->  zero-ref    "field V25._reference (fldOffset=0x0)" P-INDEP
 ;* V52 tmp44        [V52    ] (  0,  0   )     int  ->  zero-ref    "field V25._length (fldOffset=0x8)" P-INDEP
-;  V53 cse0         [V53,T01] ( 21, 42   )     ref  ->  rdx         multi-def "CSE - aggressive"
-;  V54 cse1         [V54,T07] (  3, 24   )     int  ->  r12         "CSE - aggressive"
+;  V53 cse0         [V53,T01] ( 20, 40   )     ref  ->  registers   multi-def "CSE - aggressive"
+;  V54 cse1         [V54,T06] (  3, 24   )     int  ->  r12         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -76,128 +76,139 @@ G_M38843_IG01:        ; bbWeight=8, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        push     rbp
        push     rbx
        sub      rsp, 40
-       mov      rsi, rcx
-       ; gcrRegs +[rsi]
+       mov      rbx, rcx
+       ; gcrRegs +[rbx]
        mov      rbp, rdx
        ; byrRegs +[rbp]
-       mov      ebx, r8d
+       mov      esi, r8d
        mov      r14, r9
        ; byrRegs +[r14]
        mov      edi, dword ptr [rsp+0x90]
 						;; size=35 bbWeight=8 PerfScore 82.00
-G_M38843_IG02:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=4020 {rbp r14}, byref, isz
+G_M38843_IG02:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=4020 {rbp r14}, byref, isz
        xor      r15d, r15d
        tzcnt    r15d, edi
        test     r15b, 1
        je       SHORT G_M38843_IG04
 						;; size=14 bbWeight=8 PerfScore 28.00
-G_M38843_IG03:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=4020 {rbp r14}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+G_M38843_IG03:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=4020 {rbp r14}, byref
+       mov      r13, 0xD1FFAB1E
+       ; gcrRegs +[r13]
+       mov      rcx, r13
        ; gcrRegs +[rcx]
+       mov      rdx, r13
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rcx rdx r13]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG04:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=4020 {rbp r14}, byref, isz
+						;; size=22 bbWeight=2 PerfScore 7.50
+G_M38843_IG04:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=4020 {rbp r14}, byref, isz
        movsxd   r15, r15d
        add      r15, r14
        ; byrRegs +[r15]
-       mov      rcx, gword ptr [rsi+0x10]
+       mov      rcx, gword ptr [rbx+0x10]
        ; gcrRegs +[rcx]
        mov      r13d, dword ptr [rcx+0x08]
-       test     ebx, ebx
+       test     esi, esi
        jge      SHORT G_M38843_IG06
 						;; size=18 bbWeight=8 PerfScore 46.00
-G_M38843_IG05:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref
+G_M38843_IG05:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref
        ; gcrRegs -[rcx]
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
+       mov      r12, rcx
+       ; gcrRegs +[r12]
+       mov      rcx, r12
+       mov      rdx, r12
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG06:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref, isz
-       test     ebx, ebx
-       jge      SHORT G_M38843_IG08
-						;; size=4 bbWeight=8 PerfScore 10.00
-G_M38843_IG07:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      rcx, r12
        ; gcrRegs +[rcx]
+       mov      rdx, r12
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rcx rdx r12]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG08:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref, isz
+						;; size=37 bbWeight=2 PerfScore 15.00
+G_M38843_IG06:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref, isz
        mov      r12, r15
        ; byrRegs +[r12]
        sub      r12, rbp
        ; byrRegs -[r12]
-       jns      SHORT G_M38843_IG10
+       jns      SHORT G_M38843_IG08
 						;; size=8 bbWeight=8 PerfScore 12.00
-G_M38843_IG09:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+G_M38843_IG07:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref
+       mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
+       mov      rax, rcx
+       ; gcrRegs +[rax]
+       mov      rcx, rax
+       mov      rdx, rax
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG10:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref, isz
+						;; size=25 bbWeight=2 PerfScore 8.00
+G_M38843_IG08:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref, isz
        test     r12b, 1
-       je       SHORT G_M38843_IG12
+       je       SHORT G_M38843_IG10
 						;; size=6 bbWeight=8 PerfScore 10.00
-G_M38843_IG11:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+G_M38843_IG09:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref
+       mov      rax, 0xD1FFAB1E
+       ; gcrRegs +[rax]
+       mov      rcx, rax
        ; gcrRegs +[rcx]
+       mov      rdx, rax
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG12:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref, isz
+						;; size=22 bbWeight=2 PerfScore 7.50
+G_M38843_IG10:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref, isz
        mov      rcx, r12
        shr      rcx, 63
        add      rcx, r12
        sar      rcx, 1
-       mov      edx, ebx
+       mov      edx, esi
        sub      edx, ecx
        cmp      edx, r13d
-       jge      SHORT G_M38843_IG14
+       jge      SHORT G_M38843_IG12
 						;; size=22 bbWeight=8 PerfScore 26.00
-G_M38843_IG13:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+G_M38843_IG11:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref
+       mov      rax, 0xD1FFAB1E
+       ; gcrRegs +[rax]
+       mov      r13, rax
+       ; gcrRegs +[r13]
+       mov      rcx, r13
        ; gcrRegs +[rcx]
+       mov      rdx, r13
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rax rcx rdx r13]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG14:        ; bbWeight=8, gcrefRegs=0040 {rsi}, byrefRegs=C020 {rbp r14 r15}, byref, isz
-       mov      r13, gword ptr [rsi+0x10]
+						;; size=25 bbWeight=2 PerfScore 8.00
+G_M38843_IG12:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=C020 {rbp r14 r15}, byref, isz
+       mov      r13, gword ptr [rbx+0x10]
        ; gcrRegs +[r13]
        mov      r12d, dword ptr [r13+0x08]
        cmp      r12d, 1
-       jg       SHORT G_M38843_IG16
+       jg       SHORT G_M38843_IG14
 						;; size=14 bbWeight=8 PerfScore 42.00
-G_M38843_IG15:        ; bbWeight=2, gcrefRegs=2040 {rsi r13}, byrefRegs=C020 {rbp r14 r15}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+G_M38843_IG13:        ; bbWeight=2, gcrefRegs=2008 {rbx r13}, byrefRegs=C020 {rbp r14 r15}, byref
+       mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
+       mov      rax, rcx
+       ; gcrRegs +[rax]
+       mov      rcx, rax
+       mov      rdx, rax
+       ; gcrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rcx rdx]
+       ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-						;; size=19 bbWeight=2 PerfScore 7.00
-G_M38843_IG16:        ; bbWeight=8, gcrefRegs=2040 {rsi r13}, byrefRegs=C020 {rbp r14 r15}, byref, isz
+						;; size=25 bbWeight=2 PerfScore 8.00
+G_M38843_IG14:        ; bbWeight=8, gcrefRegs=2008 {rbx r13}, byrefRegs=C020 {rbp r14 r15}, byref, isz
        lea      rdx, bword ptr [r13+0x0C]
        ; byrRegs +[rdx]
        mov      r8d, r12d
@@ -209,23 +220,23 @@ G_M38843_IG16:        ; bbWeight=8, gcrefRegs=2040 {rsi r13}, byrefRegs=C020 {rb
        ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        test     eax, eax
-       jne      SHORT G_M38843_IG20
+       jne      SHORT G_M38843_IG18
 						;; size=23 bbWeight=8 PerfScore 44.00
-G_M38843_IG17:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=4020 {rbp r14}, byref
+G_M38843_IG15:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=4020 {rbp r14}, byref
        ; byrRegs -[r15]
        blsr     eax, edi
        blsr     edi, eax
        jne      G_M38843_IG02
 						;; size=16 bbWeight=4 PerfScore 8.00
-G_M38843_IG18:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rsi]
+G_M38843_IG16:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
...

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-46</span> (<span style="color:green">-70.77%</span>) : 232006.dasm - Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,44 +9,25 @@
 ; Final local variable assignments
 ;
 ;* V00 loc0         [V00    ] (  0,  0   )   float  ->  zero-ref   
-;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )   float  ->  zero-ref    "Inlining Arg"
-;  V03 cse0         [V03,T00] (  4,  4   )    long  ->  rbx         "CSE - aggressive"
+;  V03 cse0         [V03,T00] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 0
 
 G_M15223_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M15223_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rbx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M15223_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        xor      ecx, ecx
-       mov      dword ptr [rbx], ecx
-       vmovss   xmm0, dword ptr [rbx]
-       vucomiss xmm0, dword ptr [reloc @RWD00]
-       jbe      SHORT G_M15223_IG04
-						;; size=28 bbWeight=1 PerfScore 10.50
-G_M15223_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
-						;; size=22 bbWeight=0.50 PerfScore 1.75
-G_M15223_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vmovss   xmm0, dword ptr [rbx]
-						;; size=4 bbWeight=1 PerfScore 4.00
-G_M15223_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       mov      dword ptr [rax], ecx
+       vmovss   xmm0, dword ptr [rax]
+						;; size=18 bbWeight=1 PerfScore 5.50
+G_M15223_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-RWD00  	dd	41200000h		;        10
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-
-; Total bytes of code 65, prolog size 5, PerfScore 19.25, instruction count 15, allocated bytes for code 65 (MethodHash=aa85c488) for method Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)
+; Total bytes of code 19, prolog size 0, PerfScore 6.50, instruction count 5, allocated bytes for code 19 (MethodHash=aa85c488) for method Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -54,10 +35,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-46</span> (<span style="color:green">-70.77%</span>) : 238443.dasm - Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,44 +8,25 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;# V00 OutArgs      [V00    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V01 tmp1         [V01    ] (  0,  0   )   float  ->  zero-ref    "Inlining Arg"
-;  V02 cse0         [V02,T00] (  4,  4   )    long  ->  rbx         "CSE - aggressive"
+;  V02 cse0         [V02,T00] (  3,  3   )    long  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 0
 
 G_M15223_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M15223_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rbx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M15223_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        xor      ecx, ecx
-       mov      dword ptr [rbx], ecx
-       vmovss   xmm0, dword ptr [rbx]
-       vucomiss xmm0, dword ptr [reloc @RWD00]
-       jbe      SHORT G_M15223_IG04
-						;; size=28 bbWeight=1 PerfScore 10.50
-G_M15223_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
-						;; size=22 bbWeight=0.50 PerfScore 1.75
-G_M15223_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       vmovss   xmm0, dword ptr [rbx]
-						;; size=4 bbWeight=1 PerfScore 4.00
-G_M15223_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       mov      dword ptr [rax], ecx
+       vmovss   xmm0, dword ptr [rax]
+						;; size=18 bbWeight=1 PerfScore 5.50
+G_M15223_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-RWD00  	dd	41200000h		;        10
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-
-; Total bytes of code 65, prolog size 5, PerfScore 19.25, instruction count 15, allocated bytes for code 65 (MethodHash=aa85c488) for method Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)
+; Total bytes of code 19, prolog size 0, PerfScore 6.50, instruction count 5, allocated bytes for code 19 (MethodHash=aa85c488) for method Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -53,10 +34,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-41</span> (<span style="color:green">-67.21%</span>) : 168643.dasm - and_._and:main():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,42 +8,23 @@
 ; Final local variable assignments
 ;
 ;  V00 OutArgs      [V00    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V01 cse0         [V01,T00] (  3,  3   )     int  ->  rax         "CSE - aggressive"
-;  V02 cse1         [V02,T01] (  3,  1.50)    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M20653_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M20653_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M20653_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M20653_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     [and_._and:initialize()]
        ; gcr arg pop 0
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      eax, dword ptr [rax]
-       cmp      eax, eax
-       jne      SHORT G_M20653_IG05
-						;; size=22 bbWeight=1 PerfScore 6.50
-G_M20653_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rax, qword ptr [rax]
-       cmp      rax, rax
-       jne      SHORT G_M20653_IG05
        mov      eax, 100
-						;; size=23 bbWeight=0.50 PerfScore 1.88
-G_M20653_IG04:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=11 bbWeight=1 PerfScore 3.25
+G_M20653_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M20653_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M20653_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
-       ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 61, prolog size 4, PerfScore 10.00, instruction count 16, allocated bytes for code 61 (MethodHash=2fe0af52) for method and_._and:main():int (FullOpts)
+; Total bytes of code 20, prolog size 4, PerfScore 4.75, instruction count 5, allocated bytes for code 20 (MethodHash=2fe0af52) for method and_._and:main():int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+19.33%</span>) : 185009.dasm - FastTailCallCandidates:CalleeHFAStackSpace(double,double,double,double,double,double,double,double,double,double):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -25,7 +25,7 @@
 ;
 ; Lcl frame size = 96
 
-G_M11607_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M11607_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
        sub      rsp, 96
        vmovaps  xmmword ptr [rsp+0x50], xmm6
@@ -39,7 +39,7 @@ G_M11607_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vxorps   xmm7, xmm7, xmm7
        vxorps   xmm1, xmm1, xmm1
        vucomisd xmm6, xmm1
-       jbe      SHORT G_M11607_IG07
+       jbe      SHORT G_M11607_IG10
 						;; size=16 bbWeight=1 PerfScore 3.92
 G_M11607_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        vmovsd   xmm8, qword ptr [reloc @RWD00]
@@ -63,13 +63,14 @@ G_M11607_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vucomisd xmm6, xmm7
        ja       SHORT G_M11607_IG04
 						;; size=11 bbWeight=4 PerfScore 24.00
-G_M11607_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, 108
-       mov      ecx, 100
+G_M11607_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ebx, 1
-       cmove    eax, ecx
-						;; size=16 bbWeight=1 PerfScore 1.00
-G_M11607_IG08:        ; bbWeight=1, epilog, nogc, extend
+       jne      SHORT G_M11607_IG10
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M11607_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, 100
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M11607_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        vmovaps  xmm6, xmmword ptr [rsp+0x50]
        vmovaps  xmm7, xmmword ptr [rsp+0x40]
        vmovaps  xmm8, xmmword ptr [rsp+0x30]
@@ -77,12 +78,24 @@ G_M11607_IG08:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 96
        pop      rbx
        ret      
-						;; size=30 bbWeight=1 PerfScore 17.75
+						;; size=30 bbWeight=0.50 PerfScore 8.88
+G_M11607_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, 108
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M11607_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       vmovaps  xmm7, xmmword ptr [rsp+0x40]
+       vmovaps  xmm8, xmmword ptr [rsp+0x30]
+       vmovaps  xmm9, xmmword ptr [rsp+0x20]
+       add      rsp, 96
+       pop      rbx
+       ret      
+						;; size=30 bbWeight=0.50 PerfScore 8.88
 RWD00  	dq	4000000000000000h	;            2
 RWD08  	dq	3FF0000000000000h	;            1
 
 
-; Total bytes of code 150, prolog size 33, PerfScore 83.00, instruction count 36, allocated bytes for code 150 (MethodHash=91a7d2a8) for method FastTailCallCandidates:CalleeHFAStackSpace(double,double,double,double,double,double,double,double,double,double):int (FullOpts)
+; Total bytes of code 179, prolog size 33, PerfScore 83.50, instruction count 43, allocated bytes for code 179 (MethodHash=91a7d2a8) for method FastTailCallCandidates:CalleeHFAStackSpace(double,double,double,double,double,double,double,double,double,double):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+19.33%</span>) : 185010.dasm - FastTailCallCandidates:CalleeWithHFA(double,double,double,double,FastTailCallCandidates+HFASize32):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -20,7 +20,7 @@
 ;
 ; Lcl frame size = 96
 
-G_M007_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M007_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
        sub      rsp, 96
        vmovaps  xmmword ptr [rsp+0x50], xmm6
@@ -34,7 +34,7 @@ G_M007_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, i
        vxorps   xmm7, xmm7, xmm7
        vxorps   xmm1, xmm1, xmm1
        vucomisd xmm6, xmm1
-       jbe      SHORT G_M007_IG07
+       jbe      SHORT G_M007_IG10
 						;; size=16 bbWeight=1 PerfScore 3.92
 G_M007_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        vmovsd   xmm8, qword ptr [reloc @RWD00]
@@ -58,13 +58,14 @@ G_M007_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, i
        vucomisd xmm6, xmm7
        ja       SHORT G_M007_IG04
 						;; size=11 bbWeight=4 PerfScore 24.00
-G_M007_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, 109
-       mov      ecx, 100
+G_M007_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ebx, 1
-       cmove    eax, ecx
-						;; size=16 bbWeight=1 PerfScore 1.00
-G_M007_IG08:        ; bbWeight=1, epilog, nogc, extend
+       jne      SHORT G_M007_IG10
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M007_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, 100
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M007_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        vmovaps  xmm6, xmmword ptr [rsp+0x50]
        vmovaps  xmm7, xmmword ptr [rsp+0x40]
        vmovaps  xmm8, xmmword ptr [rsp+0x30]
@@ -72,12 +73,24 @@ G_M007_IG08:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 96
        pop      rbx
        ret      
-						;; size=30 bbWeight=1 PerfScore 17.75
+						;; size=30 bbWeight=0.50 PerfScore 8.88
+G_M007_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, 109
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M007_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       vmovaps  xmm7, xmmword ptr [rsp+0x40]
+       vmovaps  xmm8, xmmword ptr [rsp+0x30]
+       vmovaps  xmm9, xmmword ptr [rsp+0x20]
+       add      rsp, 96
+       pop      rbx
+       ret      
+						;; size=30 bbWeight=0.50 PerfScore 8.88
 RWD00  	dq	4000000000000000h	;            2
 RWD08  	dq	3FF0000000000000h	;            1
 
 
-; Total bytes of code 150, prolog size 33, PerfScore 83.00, instruction count 36, allocated bytes for code 150 (MethodHash=9c97fff8) for method FastTailCallCandidates:CalleeWithHFA(double,double,double,double,FastTailCallCandidates+HFASize32):int (FullOpts)
+; Total bytes of code 179, prolog size 33, PerfScore 83.50, instruction count 43, allocated bytes for code 179 (MethodHash=9c97fff8) for method FastTailCallCandidates:CalleeWithHFA(double,double,double,double,FastTailCallCandidates+HFASize32):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+29</span> (<span style="color:red">+19.33%</span>) : 185011.dasm - FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -27,7 +27,7 @@
 ;
 ; Lcl frame size = 96
 
-G_M26767_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M26767_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
        sub      rsp, 96
        vmovaps  xmmword ptr [rsp+0x50], xmm6
@@ -41,7 +41,7 @@ G_M26767_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vxorps   xmm7, xmm7, xmm7
        vxorps   xmm1, xmm1, xmm1
        vucomisd xmm6, xmm1
-       jbe      SHORT G_M26767_IG07
+       jbe      SHORT G_M26767_IG10
 						;; size=16 bbWeight=1 PerfScore 3.92
 G_M26767_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        vmovsd   xmm8, qword ptr [reloc @RWD00]
@@ -65,13 +65,14 @@ G_M26767_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vucomisd xmm6, xmm7
        ja       SHORT G_M26767_IG04
 						;; size=11 bbWeight=4 PerfScore 24.00
-G_M26767_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, 110
-       mov      ecx, 100
+G_M26767_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ebx, 1
-       cmove    eax, ecx
-						;; size=16 bbWeight=1 PerfScore 1.00
-G_M26767_IG08:        ; bbWeight=1, epilog, nogc, extend
+       jne      SHORT G_M26767_IG10
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M26767_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, 100
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M26767_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        vmovaps  xmm6, xmmword ptr [rsp+0x50]
        vmovaps  xmm7, xmmword ptr [rsp+0x40]
        vmovaps  xmm8, xmmword ptr [rsp+0x30]
@@ -79,12 +80,24 @@ G_M26767_IG08:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 96
        pop      rbx
        ret      
-						;; size=30 bbWeight=1 PerfScore 17.75
+						;; size=30 bbWeight=0.50 PerfScore 8.88
+G_M26767_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       mov      eax, 110
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M26767_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+       vmovaps  xmm6, xmmword ptr [rsp+0x50]
+       vmovaps  xmm7, xmmword ptr [rsp+0x40]
+       vmovaps  xmm8, xmmword ptr [rsp+0x30]
+       vmovaps  xmm9, xmmword ptr [rsp+0x20]
+       add      rsp, 96
+       pop      rbx
+       ret      
+						;; size=30 bbWeight=0.50 PerfScore 8.88
 RWD00  	dq	4000000000000000h	;            2
 RWD08  	dq	3FF0000000000000h	;            1
 
 
-; Total bytes of code 150, prolog size 33, PerfScore 83.00, instruction count 36, allocated bytes for code 150 (MethodHash=b3049770) for method FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)
+; Total bytes of code 179, prolog size 33, PerfScore 83.50, instruction count 43, allocated bytes for code 179 (MethodHash=b3049770) for method FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-53.85%</span>) : 716.dasm - System.RuntimeType:get_IsConstructedGenericType():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,66 +11,46 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;  V02 loc1         [V02,T03] (  2,  2   )   ubyte  ->  rax        
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp5         [V08    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V09 tmp6         [V09,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 cse0         [V10,T05] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V11 cse1         [V11,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V09 tmp6         [V09,T01] (  3,  2.50)    long  ->  rcx         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M19161_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
+						;; size=8 bbWeight=1 PerfScore 1.50
 G_M19161_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M19161_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M19161_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
+       mov      rcx, qword ptr [rbx+0x18]
+       test     cl, 2
        je       SHORT G_M19161_IG04
-       mov      rcx, (reloc)
-       mov      rcx, qword ptr [rcx]
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
-       ; gcrRegs +[rcx]
-       mov      rax, (reloc)
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=35 bbWeight=0.50 PerfScore 4.50
-G_M19161_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, rsi
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M19161_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M19161_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M19161_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        call     [System.Runtime.CompilerServices.MethodTable:get_IsConstructedGenericType():ubyte:this]
        ; gcr arg pop 0
-       jmp      SHORT G_M19161_IG06
-						;; size=11 bbWeight=0.50 PerfScore 2.62
-G_M19161_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M19161_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=6 bbWeight=0.50 PerfScore 1.50
+G_M19161_IG05:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M19161_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+G_M19161_IG06:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
-       pop      rsi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 78, prolog size 6, PerfScore 15.75, instruction count 25, allocated bytes for code 78 (MethodHash=bbf5b526) for method System.RuntimeType:get_IsConstructedGenericType():ubyte:this (FullOpts)
+; Total bytes of code 36, prolog size 5, PerfScore 9.38, instruction count 13, allocated bytes for code 36 (MethodHash=bbf5b526) for method System.RuntimeType:get_IsConstructedGenericType():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +58,10 @@ Unwind Info:
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
<summary><span style="color:green">-42</span> (<span style="color:green">-53.85%</span>) : 717.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,66 +11,46 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;  V02 loc1         [V02,T03] (  2,  2   )   ubyte  ->  rax        
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp5         [V08    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V09 tmp6         [V09,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 cse0         [V10,T05] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V11 cse1         [V11,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V09 tmp6         [V09,T01] (  3,  2.50)    long  ->  rcx         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M12781_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
+						;; size=8 bbWeight=1 PerfScore 1.50
 G_M12781_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M12781_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M12781_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
+       mov      rcx, qword ptr [rbx+0x18]
+       test     cl, 2
        je       SHORT G_M12781_IG04
-       mov      rcx, (reloc)
-       mov      rcx, qword ptr [rcx]
-       mov      rdx, gword ptr [rcx]
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
-       ; gcrRegs +[rcx]
-       mov      rax, (reloc)
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=35 bbWeight=0.50 PerfScore 4.50
-G_M12781_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, rsi
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M12781_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M12781_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M12781_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        call     [System.Runtime.CompilerServices.MethodTable:get_HasInstantiation():ubyte:this]
        ; gcr arg pop 0
-       jmp      SHORT G_M12781_IG06
-						;; size=11 bbWeight=0.50 PerfScore 2.62
-G_M12781_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M12781_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=6 bbWeight=0.50 PerfScore 1.50
+G_M12781_IG05:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M12781_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+G_M12781_IG06:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
-       pop      rsi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 78, prolog size 6, PerfScore 15.75, instruction count 25, allocated bytes for code 78 (MethodHash=d501ce12) for method System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)
+; Total bytes of code 36, prolog size 5, PerfScore 9.38, instruction count 13, allocated bytes for code 36 (MethodHash=d501ce12) for method System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +58,10 @@ Unwind Info:
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
<summary><span style="color:green">-33</span> (<span style="color:green">-47.14%</span>) : 168569.dasm - System.Runtime.Serialization.ExtensionDataReader:get_Item(int):System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,58 +9,42 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  6,  4.50)     ref  ->  rcx         this class-hnd single-def <System.Runtime.Serialization.ExtensionDataReader>
-;  V01 arg1         [V01,T01] (  4,  3   )     int  ->  rdx         single-def
+;  V00 this         [V00,T00] (  5,  4   )     ref  ->  rcx         this class-hnd single-def <System.Runtime.Serialization.ExtensionDataReader>
+;  V01 arg1         [V01,T01] (  3,  2.50)     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "Inline return value spill temp" <System.String>
-;  V04 cse0         [V04,T03] (  3,  2.50)     int  ->  r11         "CSE - aggressive"
-;  V05 cse1         [V05,T02] (  4,  3   )    long  ->  rbx         "CSE - aggressive"
+;  V04 cse0         [V04,T03] (  2,  1   )     ref  ->  rcx         "CSE - moderate"
+;  V05 cse1         [V05,T02] (  3,  2.50)    long  ->  r11         "CSE - aggressive"
 ;
 ; Lcl frame size = 0
 
 G_M59427_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
-       push     rbx
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M59427_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rbx, qword ptr [(reloc)]      ; const ptr
-       mov      r11d, dword ptr [rcx+rbx+0x5C]
-       cmp      r11d, 4
-       je       SHORT G_M59427_IG07
-						;; size=18 bbWeight=1 PerfScore 5.25
-G_M59427_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       mov      r11, qword ptr [(reloc)]      ; const ptr
+       cmp      dword ptr [rcx+r11+0x5C], 4
+       je       SHORT G_M59427_IG05
+						;; size=15 bbWeight=1 PerfScore 6.00
+G_M59427_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        cmp      byte  ptr [rcx], cl
-       cmp      r11d, 4
-       jne      SHORT G_M59427_IG05
-       mov      rcx, gword ptr [rcx+rbx+0x40]
-       mov      r11, (reloc)
-       cmp      dword ptr [rcx], ecx
-						;; size=25 bbWeight=0.50 PerfScore 4.75
-G_M59427_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       pop      rbx
-       tail.jmp [r11]<unknown method>
-						;; size=4 bbWeight=0.50 PerfScore 1.25
-G_M59427_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
        xor      rax, rax
        ; gcrRegs +[rax]
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M59427_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       pop      rbx
+						;; size=4 bbWeight=0.50 PerfScore 1.62
+G_M59427_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
-						;; size=2 bbWeight=0.50 PerfScore 0.75
-G_M59427_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rax] +[rcx]
-       mov      rcx, gword ptr [rcx+rbx+0x40]
+						;; size=1 bbWeight=0.50 PerfScore 0.50
+G_M59427_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs -[rax]
+       mov      rcx, gword ptr [rcx+r11+0x40]
        lea      r11, [(reloc)]      ; function address
        cmp      dword ptr [rcx], ecx
 						;; size=14 bbWeight=0.50 PerfScore 2.75
-G_M59427_IG08:        ; bbWeight=0.50, epilog, nogc, extend
-       pop      rbx
+G_M59427_IG06:        ; bbWeight=0.50, epilog, nogc, extend
        tail.jmp [r11]<unknown method>
-						;; size=4 bbWeight=0.50 PerfScore 1.25
+						;; size=3 bbWeight=0.50 PerfScore 1.00
 
-; Total bytes of code 70, prolog size 1, PerfScore 17.12, instruction count 21, allocated bytes for code 70 (MethodHash=023a17dc) for method System.Runtime.Serialization.ExtensionDataReader:get_Item(int):System.String:this (FullOpts)
+; Total bytes of code 37, prolog size 0, PerfScore 11.88, instruction count 10, allocated bytes for code 37 (MethodHash=023a17dc) for method System.Runtime.Serialization.ExtensionDataReader:get_Item(int):System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -68,9 +52,8 @@ Unwind Info:
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
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+8.70%</span>) : 6387.dasm - System.Threading.ReaderWriterLockSlim:get_IsReadLockHeld():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,23 +12,21 @@
 ;  V00 this         [V00,T01] (  3,  6   )     ref  ->  rbx         this class-hnd single-def <System.Threading.ReaderWriterLockSlim>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V02 tmp1         [V02    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V03 tmp2         [V03,T03] (  3,  2.50)     int  ->  rsi         "Inline stloc first use temp"
+;  V03 tmp2         [V03,T03] (  2,  2   )     int  ->  rax         "Inline stloc first use temp"
 ;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inline stloc first use temp" <System.Threading.ReaderWriterCount>
-;  V05 tmp4         [V05,T02] (  4,  2.50)     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Threading.ReaderWriterCount>
+;  V05 tmp4         [V05,T02] (  4,  3   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Threading.ReaderWriterCount>
 ;  V06 tmp5         [V06,T00] (  7, 18.50)     ref  ->  rax         class-hnd "Inline stloc first use temp" <System.Threading.ReaderWriterCount>
 ;* V07 tmp6         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Threading.ReaderWriterCount>
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
-G_M7654_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
+G_M7654_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
+						;; size=8 bbWeight=1 PerfScore 1.50
 G_M7654_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       xor      esi, esi
        call     [CORINFO_HELP_READYTORUN_THREADSTATIC_BASE]
        ; byrRegs +[rax]
        ; gcr arg pop 0
@@ -37,7 +35,7 @@ G_M7654_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        ; byrRegs -[rax]
        test     rax, rax
        je       SHORT G_M7654_IG04
-						;; size=17 bbWeight=1 PerfScore 6.50
+						;; size=15 bbWeight=1 PerfScore 6.25
 G_M7654_IG03:        ; bbWeight=4, gcrefRegs=0009 {rax rbx}, byrefRegs=0000 {}, byref, isz
        mov      rcx, qword ptr [rax+0x10]
        cmp      rcx, qword ptr [rbx+0x28]
@@ -53,25 +51,30 @@ G_M7654_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byre
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M7654_IG05:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
        test     rax, rax
-       je       SHORT G_M7654_IG07
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M7654_IG06:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
-       mov      esi, dword ptr [rax+0x18]
-						;; size=3 bbWeight=0.50 PerfScore 1.00
-G_M7654_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       je       SHORT G_M7654_IG08
+       mov      eax, dword ptr [rax+0x18]
        ; gcrRegs -[rax]
-       xor      eax, eax
-       test     esi, esi
-       setg     al
-						;; size=7 bbWeight=1 PerfScore 1.50
-G_M7654_IG08:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       test     eax, eax
+       jle      SHORT G_M7654_IG08
+						;; size=12 bbWeight=1 PerfScore 4.50
+G_M7654_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, 1
+						;; size=5 bbWeight=0.50 PerfScore 0.12
+G_M7654_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
-       pop      rsi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=0.50 PerfScore 0.88
+G_M7654_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       xor      eax, eax
+						;; size=2 bbWeight=0.50 PerfScore 0.12
+G_M7654_IG09:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 32
+       pop      rbx
+       ret      
+						;; size=6 bbWeight=0.50 PerfScore 0.88
 
-; Total bytes of code 69, prolog size 9, PerfScore 52.12, instruction count 27, allocated bytes for code 69 (MethodHash=6fa1e219) for method System.Threading.ReaderWriterLockSlim:get_IsReadLockHeld():ubyte:this (FullOpts)
+; Total bytes of code 75, prolog size 8, PerfScore 51.38, instruction count 28, allocated bytes for code 75 (MethodHash=6fa1e219) for method System.Threading.ReaderWriterLockSlim:get_IsReadLockHeld():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -79,11 +82,10 @@ Unwind Info:
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
<summary><span style="color:red">+44</span> (<span style="color:red">+8.98%</span>) : 269452.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,48 +9,51 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 RetBuf       [V00,T04] (  4,  4   )   byref  ->  rsi         single-def
-;  V01 arg0         [V01,T07] (  3,  3   )     ref  ->  r14         class-hnd single-def <System.Net.Security.SafeDeleteSslContext>
-;  V02 arg1         [V02,T02] (  4,  8   )   byref  ->  rbx         ld-addr-op single-def
-;  V03 arg2         [V03,T06] (  4,  3.50)   byref  ->  rdi         single-def
-;  V04 arg3         [V04,T15] (  2,  1.50)   byref  ->  r15         single-def
+;  V00 RetBuf       [V00,T03] (  4,  4   )   byref  ->  rsi         single-def
+;  V01 arg0         [V01,T06] (  3,  3   )     ref  ->  r14         class-hnd single-def <System.Net.Security.SafeDeleteSslContext>
+;  V02 arg1         [V02,T01] (  4,  8   )   byref  ->  rbx         ld-addr-op single-def
+;  V03 arg2         [V03,T05] (  4,  3.50)   byref  ->  rdi         single-def
+;  V04 arg3         [V04,T18] (  2,  1.50)   byref  ->  r15         single-def
 ;* V05 loc0         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[Interop+SspiCli+SecBuffer]>
 ;* V06 loc1         [V06    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[Interop+SspiCli+SecBuffer]>
-;* V07 loc2         [V07,T16] (  0,  0   )     int  ->  zero-ref   
+;* V07 loc2         [V07,T19] (  0,  0   )     int  ->  zero-ref   
 ;  V08 loc3         [V08,T00] ( 12, 12   )   byref  ->  rcx        
-;  V09 loc4         [V09,T12] (  3,  2.50)    long  ->  [rbp+0x50]  spill-single-def
-;  V10 loc5         [V10    ] (  2,  2   )   byref  ->  [rbp+0x48]  must-init pinned single-def
+;  V09 loc4         [V09,T15] (  3,  2.50)    long  ->  [rbp+0x60]  spill-single-def
+;  V10 loc5         [V10    ] (  2,  2   )   byref  ->  [rbp+0x58]  must-init pinned single-def
 ;* V11 loc6         [V11    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V12 loc7         [V12    ] (  4,  4   )  struct (16) [rbp+0x38]  do-not-enreg[XS] addr-exposed ld-addr-op <Interop+SspiCli+SecBufferDesc>
-;  V13 loc8         [V13,T03] ( 10,  6.50)     int  ->  rax        
+;  V12 loc7         [V12    ] (  4,  4   )  struct (16) [rbp+0x48]  do-not-enreg[XS] addr-exposed ld-addr-op <Interop+SspiCli+SecBufferDesc>
+;  V13 loc8         [V13,T07] (  6,  4.50)     int  ->  rax        
 ;* V14 loc9         [V14    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Interop+SspiCli+SecBufferDesc>
-;  V15 loc10        [V15    ] (  1,  1   )     int  ->  [rbp+0x30]  do-not-enreg[X] addr-exposed ld-addr-op
+;  V15 loc10        [V15    ] (  1,  1   )     int  ->  [rbp+0x40]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V16 loc11        [V16,T11] (  6,  3.50)     int  ->  rcx        
 ;  V17 OutArgs      [V17    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V18 tmp1         [V18    ] (  4,  8   )  struct (16) [rbp+0x20]  do-not-enreg[XS] addr-exposed ld-addr-op "NewObj constructor temp" <System.Span`1[Interop+SspiCli+SecBuffer]>
+;  V18 tmp1         [V18    ] (  4,  8   )  struct (16) [rbp+0x30]  do-not-enreg[XS] addr-exposed ld-addr-op "NewObj constructor temp" <System.Span`1[Interop+SspiCli+SecBuffer]>
 ;* V19 tmp2         [V19    ] (  0,  0   )   byref  ->  zero-ref    do-not-enreg[] "field V02._reference (fldOffset=0x0)" P-DEP
 ;* V20 tmp3         [V20    ] (  0,  0   )     int  ->  zero-ref    do-not-enreg[] "field V02._length (fldOffset=0x8)" P-DEP
-;  V21 tmp4         [V21,T01] ( 18, 11   )   byref  ->  r13         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V22 tmp5         [V22,T05] (  6,  5.50)     int  ->  r12         "field V05._length (fldOffset=0x8)" P-INDEP
+;  V21 tmp4         [V21,T02] ( 12,  9.50)   byref  ->  r13         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V22 tmp5         [V22,T04] (  6,  5.50)     int  ->  r12         "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V23 tmp6         [V23    ] (  0,  0   )   byref  ->  zero-ref    "field V06._reference (fldOffset=0x0)" P-INDEP
 ;* V24 tmp7         [V24    ] (  0,  0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
-;  V25 tmp8         [V25    ] (  2,  2   )     int  ->  [rbp+0x38]  do-not-enreg[X] addr-exposed "field V12.ulVersion (fldOffset=0x0)" P-DEP
-;  V26 tmp9         [V26    ] (  2,  2   )     int  ->  [rbp+0x3C]  do-not-enreg[X] addr-exposed "field V12.cBuffers (fldOffset=0x4)" P-DEP
-;  V27 tmp10        [V27    ] (  2,  2   )    long  ->  [rbp+0x40]  do-not-enreg[X] addr-exposed "field V12.pBuffers (fldOffset=0x8)" P-DEP
-;* V28 tmp11        [V28,T17] (  0,  0   )     int  ->  zero-ref    "field V14.ulVersion (fldOffset=0x0)" P-INDEP
-;* V29 tmp12        [V29,T18] (  0,  0   )     int  ->  zero-ref    "field V14.cBuffers (fldOffset=0x4)" P-INDEP
-;  V30 tmp13        [V30,T13] (  2,  2   )    long  ->  rax         "field V14.pBuffers (fldOffset=0x8)" P-INDEP
-;  V31 tmp14        [V31    ] (  3,  5   )   byref  ->  [rbp+0x20]  do-not-enreg[X] addr-exposed "field V18._reference (fldOffset=0x0)" P-DEP
-;  V32 tmp15        [V32    ] (  3,  5   )     int  ->  [rbp+0x28]  do-not-enreg[X] addr-exposed "field V18._length (fldOffset=0x8)" P-DEP
+;  V25 tmp8         [V25    ] (  2,  2   )     int  ->  [rbp+0x48]  do-not-enreg[X] addr-exposed "field V12.ulVersion (fldOffset=0x0)" P-DEP
+;  V26 tmp9         [V26    ] (  2,  2   )     int  ->  [rbp+0x4C]  do-not-enreg[X] addr-exposed "field V12.cBuffers (fldOffset=0x4)" P-DEP
+;  V27 tmp10        [V27    ] (  2,  2   )    long  ->  [rbp+0x50]  do-not-enreg[X] addr-exposed "field V12.pBuffers (fldOffset=0x8)" P-DEP
+;* V28 tmp11        [V28,T20] (  0,  0   )     int  ->  zero-ref    "field V14.ulVersion (fldOffset=0x0)" P-INDEP
+;* V29 tmp12        [V29,T21] (  0,  0   )     int  ->  zero-ref    "field V14.cBuffers (fldOffset=0x4)" P-INDEP
+;  V30 tmp13        [V30,T16] (  2,  2   )    long  ->  rax         "field V14.pBuffers (fldOffset=0x8)" P-INDEP
+;  V31 tmp14        [V31    ] (  3,  5   )   byref  ->  [rbp+0x30]  do-not-enreg[X] addr-exposed "field V18._reference (fldOffset=0x0)" P-DEP
+;  V32 tmp15        [V32    ] (  3,  5   )     int  ->  [rbp+0x38]  do-not-enreg[X] addr-exposed "field V18._length (fldOffset=0x8)" P-DEP
 ;* V33 tmp16        [V33    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[S] "Promoted implicit byref" <System.Span`1[ubyte]>
 ;  V34 tmp17        [V34,T09] (  2,  4   )    long  ->  rax         "Cast away GC"
 ;  V35 tmp18        [V35,T10] (  2,  4   )    long  ->  rax         "Cast away GC"
-;  V36 tmp19        [V36    ] (  3,  6   )  struct (16) [rbp+0x10]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[Interop+SspiCli+SecBuffer]>
+;  V36 tmp19        [V36    ] (  3,  6   )  struct (16) [rbp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[Interop+SspiCli+SecBuffer]>
 ;  V37 tmp20        [V37,T08] (  2,  4   )     ref  ->  rcx         single-def "argument with side effect"
-;  V38 GsCookie     [V38    ] (  1,  1   )    long  ->  [rbp+0x08]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
-;  V39 cse0         [V39,T14] (  3,  1.50)    long  ->  rcx         "CSE - moderate"
+;  V38 GsCookie     [V38    ] (  1,  1   )    long  ->  [rbp+0x00]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
+;  V39 cse0         [V39,T12] (  4,  2.50)   byref  ->  [rbp+0x18]  spill-single-def "CSE - moderate"
+;  V40 cse1         [V40,T13] (  4,  2.50)   byref  ->  [rbp+0x10]  spill-single-def "CSE - moderate"
+;  V41 cse2         [V41,T14] (  4,  2.50)   byref  ->  [rbp+0x08]  spill-single-def "CSE - moderate"
+;  V42 cse3         [V42,T17] (  3,  1.50)    long  ->  rcx         "CSE - moderate"
 ;
-; Lcl frame size = 120
+; Lcl frame size = 136
 
 G_M25581_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbp
@@ -61,15 +64,15 @@ G_M25581_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 120
+       sub      rsp, 136
        lea      rbp, [rsp+0x20]
        xorps    xmm4, xmm4
-       movaps   xmmword ptr [rbp+0x10], xmm4
        movaps   xmmword ptr [rbp+0x20], xmm4
        movaps   xmmword ptr [rbp+0x30], xmm4
        movaps   xmmword ptr [rbp+0x40], xmm4
+       movaps   xmmword ptr [rbp+0x50], xmm4
        mov      rax, qword ptr [(reloc)]
-       mov      qword ptr [rbp+0x08], rax
+       mov      qword ptr [rbp], rax
        mov      rsi, rcx
        ; byrRegs +[rsi]
        mov      r14, rdx
@@ -78,81 +81,94 @@ G_M25581_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs +[rbx]
        mov      rdi, r9
        ; byrRegs +[rdi]
-       mov      r15, bword ptr [rbp+0xC0]
+       mov      r15, bword ptr [rbp+0xD0]
        ; byrRegs +[r15]
-						;; size=70 bbWeight=1 PerfScore 22.08
+						;; size=73 bbWeight=1 PerfScore 22.08
 G_M25581_IG02:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=80C8 {rbx rsi rdi r15}, byref
        xorps    xmm0, xmm0
-       movups   xmmword ptr [rbp+0x20], xmm0
-       lea      rcx, [rbp+0x20]
+       movups   xmmword ptr [rbp+0x30], xmm0
+       lea      rcx, [rbp+0x30]
        test     dword ptr [rsp], esp
        sub      rsp, 64
        lea      rdx, [rsp+0x20]
        mov      r8d, 4
        call     [<unknown method>]
-       mov      r13, bword ptr [rbp+0x20]
+       mov      r13, bword ptr [rbp+0x30]
        ; byrRegs +[r13]
-       mov      r12d, dword ptr [rbp+0x28]
+       mov      r12d, dword ptr [rbp+0x38]
        cmp      r12d, 1
-       jbe      G_M25581_IG32
-       lea      rcx, bword ptr [r13+0x10]
+       jbe      G_M25581_IG26
+       lea      rax, bword ptr [r13+0x10]
+       ; byrRegs +[rax]
+       mov      bword ptr [rbp+0x18], rax
+       ; GC ptr vars +{V39}
+       mov      rcx, rax
        ; byrRegs +[rcx]
-       xor      eax, eax
-       mov      dword ptr [rcx+0x04], eax
-						;; size=62 bbWeight=1 PerfScore 13.83
-G_M25581_IG03:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      qword ptr [rcx+0x08], rax
+       xor      edx, edx
+       mov      dword ptr [rcx+0x04], edx
+						;; size=69 bbWeight=1 PerfScore 15.08
+G_M25581_IG03:        ; bbWeight=1, gcVars=0000000000001000 {V39}, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, gcvars, byref
+       ; byrRegs -[rax]
+       mov      qword ptr [rcx+0x08], rdx
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M25581_IG04:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      dword ptr [rcx], eax
+       mov      dword ptr [rcx], edx
        cmp      r12d, 2
-       jbe      G_M25581_IG32
-       lea      rcx, bword ptr [r13+0x20]
-						;; size=16 bbWeight=1 PerfScore 2.75
-G_M25581_IG05:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      dword ptr [rcx+0x04], eax
-						;; size=3 bbWeight=1 PerfScore 1.00
+       jbe      G_M25581_IG26
+       lea      rdx, bword ptr [r13+0x20]
+       ; byrRegs +[rdx]
+       mov      bword ptr [rbp+0x10], rdx
+       ; GC ptr vars +{V40}
+       mov      rcx, rdx
+       xor      r8d, r8d
+       mov      dword ptr [rcx+0x04], r8d
+						;; size=30 bbWeight=1 PerfScore 5.25
+G_M25581_IG05:        ; bbWeight=1, gcVars=0000000000003000 {V39 V40}, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, gcvars, byref
+       ; byrRegs -[rdx]
+       mov      qword ptr [rcx+0x08], r8
+						;; size=4 bbWeight=1 PerfScore 1.00
 G_M25581_IG06:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      qword ptr [rcx+0x08], rax
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M25581_IG07:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      dword ptr [rcx], eax
+       mov      dword ptr [rcx], r8d
        cmp      r12d, 3
-       jbe      G_M25581_IG32
-       lea      rcx, bword ptr [r13+0x30]
-						;; size=16 bbWeight=1 PerfScore 2.75
-G_M25581_IG08:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      dword ptr [rcx+0x04], eax
-						;; size=3 bbWeight=1 PerfScore 1.00
-G_M25581_IG09:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      qword ptr [rcx+0x08], rax
+       jbe      G_M25581_IG26
+       lea      r8, bword ptr [r13+0x30]
+       ; byrRegs +[r8]
+       mov      bword ptr [rbp+0x08], r8
+       ; GC ptr vars +{V41}
+       mov      rcx, r8
+       xor      r10d, r10d
+       mov      dword ptr [rcx+0x04], r10d
+						;; size=31 bbWeight=1 PerfScore 5.25
+G_M25581_IG07:        ; bbWeight=1, gcVars=0000000000007000 {V39 V40 V41}, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, gcvars, byref
+       ; byrRegs -[r8]
+       mov      qword ptr [rcx+0x08], r10
 						;; size=4 bbWeight=1 PerfScore 1.00
-G_M25581_IG10:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
-       mov      dword ptr [rcx], eax
+G_M25581_IG08:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rbx rsi rdi r13 r15}, byref
+       mov      dword ptr [rcx], r10d
        mov      rcx, rbx
        call     [<unknown method>]
        ; byrRegs -[rcx] +[rax]
-       mov      bword ptr [rbp+0x48], rax
-       mov      rax, bword ptr [rbp+0x48]
-       mov      qword ptr [rbp+0x50], rax
+       mov      bword ptr [rbp+0x58], rax
+       mov      rax, bword ptr [rbp+0x58]
+       mov      qword ptr [rbp+0x60], rax
        mov      dword ptr [r13+0x04], 1
        mov      qword ptr [r13+0x08], rax
        mov      ecx, dword ptr [rbx+0x08]
        mov      dword ptr [r13], ecx
-       mov      bword ptr [rbp+0x10], r13
-       mov      dword ptr [rbp+0x18], r12d
-       lea      rcx, [rbp+0x10]
+       mov      bword ptr [rbp+0x20], r13
+       mov      dword ptr [rbp+0x28], r12d
+       lea      rcx, [rbp+0x20]
        call     [<unknown method>]
        ; byrRegs -[rbx]
        xor      ecx, ecx
-       mov      dword ptr [rbp+0x38], ecx
-       mov      dword ptr [rbp+0x3C], 4
-       mov      qword ptr [rbp+0x40], rax
+       mov      dword ptr [rbp+0x48], ecx
+       mov      dword ptr [rbp+0x4C], 4
+       mov      qword ptr [rbp+0x50], rax
        call     [CORINFO_HELP_READYTORUN_GCSTATIC_BASE]
        mov      rcx, gword ptr [rax+0x40]
        ; gcrRegs +[rcx]
-       lea      r9, [rbp+0x30]
-       lea      r8, [rbp+0x38]
+       lea      r9, [rbp+0x40]
+       lea      r8, [rbp+0x48]
        mov      rdx, r14
        ; gcrRegs +[rdx]
        cmp      dword ptr [rcx], ecx
@@ -161,89 +177,98 @@ G_M25581_IG10:        ; bbWeight=1, gcrefRegs=4000 {r14}, byrefRegs=A0CA {rcx rb
        ; byrRegs -[rax]
        xor      ecx, ecx
        mov      dword ptr [r15], ecx
-						;; size=110 bbWeight=1 PerfScore 34.50
-G_M25581_IG11:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=A0C0 {rsi rdi r13 r15}, byref
+						;; size=111 bbWeight=1 PerfScore 34.50
+G_M25581_IG09:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=A0C0 {rsi rdi r13 r15}, byref
        mov      dword ptr [rdi], ecx
 						;; size=2 bbWeight=1 PerfScore 1.00
-G_M25581_IG12:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=A0C0 {rsi rdi r13 r15}, byref, isz
+G_M25581_IG10:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=A0C0 {rsi rdi r13 r15}, byref, isz
        test     eax, eax
...

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+13.79%</span>) : 79164.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,14 +8,14 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  6,  6   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  6,  6   )     int  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  5,  4   )     int  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  5,  4   )     int  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  registers  
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V07 tmp4         [V07,T02] (  3,  2   )     int  ->  rcx        
+;  V07 tmp4         [V07,T02] (  4,  2   )     int  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -23,30 +23,41 @@ G_M19887_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M19887_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ecx, edx
-       mov      eax, ecx
-       cmovg    eax, edx
-       cmovle   ecx, edx
-       cmp      eax, 3
-       jne      SHORT G_M19887_IG04
-						;; size=15 bbWeight=1 PerfScore 2.25
+       jg       SHORT G_M19887_IG04
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19887_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, 4
-       je       SHORT G_M19887_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jmp      SHORT G_M19887_IG05
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M19887_IG06
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, edx
+       jmp      SHORT G_M19887_IG07
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M19887_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, ecx
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       mov      ecx, edx
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M19887_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      ecx, 3
+       jne      SHORT G_M19887_IG09
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M19887_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      eax, 4
+       je       SHORT G_M19887_IG10
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M19887_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M19887_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M19887_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 5
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M19887_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 29, prolog size 0, PerfScore 4.12, instruction count 12, allocated bytes for code 29 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
+; Total bytes of code 33, prolog size 0, PerfScore 7.62, instruction count 15, allocated bytes for code 33 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-26</span> (<span style="color:green">-65.00%</span>) : 278025.dasm - System.IO.Compression.DeflateManagedStream:PurgeBuffers(ubyte):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,17 +8,15 @@
 ; 1 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  2.50)     ref  ->  rcx         this class-hnd single-def <System.IO.Compression.DeflateManagedStream>
+;  V00 this         [V00,T01] (  3,  2.50)     ref  ->  rcx         this class-hnd single-def <System.IO.Compression.DeflateManagedStream>
 ;  V01 arg1         [V01,T00] (  3,  3   )   ubyte  ->  rdx         single-def
-;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V04 cse0         [V04,T02] (  3,  1.50)     ref  ->  rax         "CSE - moderate"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M40773_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M40773_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        test     dl, dl
@@ -26,28 +24,16 @@ G_M40773_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
 						;; size=4 bbWeight=1 PerfScore 1.25
 G_M40773_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rcx]
-       add      rsp, 40
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 G_M40773_IG04:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x10]
-       ; gcrRegs +[rax]
-       test     rax, rax
+       cmp      gword ptr [rcx+0x10], 0
        je       SHORT G_M40773_IG03
-       test     rax, rax
-       jne      SHORT G_M40773_IG03
-						;; size=14 bbWeight=0.50 PerfScore 2.25
-G_M40773_IG05:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowObjectDisposedException(System.Object)
-       call     [rax]System.ThrowHelper:ThrowObjectDisposedException(System.Object)
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+       jmp      SHORT G_M40773_IG03
+						;; size=9 bbWeight=0.50 PerfScore 3.00
 
-; Total bytes of code 40, prolog size 4, PerfScore 5.00, instruction count 13, allocated bytes for code 40 (MethodHash=8a3760ba) for method System.IO.Compression.DeflateManagedStream:PurgeBuffers(ubyte):this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 6, allocated bytes for code 14 (MethodHash=8a3760ba) for method System.IO.Compression.DeflateManagedStream:PurgeBuffers(ubyte):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -55,9 +41,8 @@ Unwind Info:
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
<summary><span style="color:green">-29</span> (<span style="color:green">-59.18%</span>) : 4131.dasm - Microsoft.FSharp.Linq.NullableOperators:op_EqualsQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,49 +11,35 @@
 ;  V00 arg0         [V00,T01] (  3,  2.50)    long  ->  rcx         single-def
 ;  V01 arg1         [V01,T00] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
 ;* V02 loc0         [V02    ] (  0,  0   )    long  ->  zero-ref   
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )   ubyte  ->  rax         single-def "field V01.hasValue (fldOffset=0x0)" P-INDEP
-;  V05 tmp2         [V05,T04] (  2,  1.50)    long  ->  rdx         single-def "field V01.value (fldOffset=0x8)" P-INDEP
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  2,  2   )   ubyte  ->  rax         single-def "field V01.hasValue (fldOffset=0x0)" P-INDEP
+;  V05 tmp2         [V05,T03] (  2,  1.50)    long  ->  rdx         single-def "field V01.value (fldOffset=0x8)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Nullable`1[long]>
-;  V07 cse0         [V07,T02] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
-G_M13006_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+G_M13006_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M13006_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byref, isz
        ; byrRegs +[rdx]
        movzx    rax, byte  ptr [rdx]
        mov      rdx, qword ptr [rdx+0x08]
        ; byrRegs -[rdx]
-       test     eax, eax
-       je       SHORT G_M13006_IG05
+       test     al, al
+       je       SHORT G_M13006_IG04
 						;; size=11 bbWeight=1 PerfScore 5.25
-G_M13006_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       test     eax, eax
-       je       SHORT G_M13006_IG07
-						;; size=4 bbWeight=0.50 PerfScore 0.62
-G_M13006_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M13006_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        tail.jmp [<unknown method>]
        ; gcr arg pop 0
-						;; size=10 bbWeight=0.50 PerfScore 1.12
-G_M13006_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=6 bbWeight=0.50 PerfScore 1.00
+G_M13006_IG04:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M13006_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M13006_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M13006_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()
-       call     [rax]System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 49, prolog size 4, PerfScore 8.00, instruction count 15, allocated bytes for code 49 (MethodHash=200ccd31) for method Microsoft.FSharp.Linq.NullableOperators:op_EqualsQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
+; Total bytes of code 20, prolog size 0, PerfScore 6.88, instruction count 7, allocated bytes for code 20 (MethodHash=200ccd31) for method Microsoft.FSharp.Linq.NullableOperators:op_EqualsQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -61,9 +47,8 @@ Unwind Info:
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
<summary><span style="color:green">-29</span> (<span style="color:green">-59.18%</span>) : 4071.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreaterEquals[long](System.Nullable`1[long],long):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,49 +11,35 @@
 ;  V00 arg0         [V00,T00] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T01] (  3,  2.50)    long  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )    long  ->  zero-ref   
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )   ubyte  ->  rax         single-def "field V00.hasValue (fldOffset=0x0)" P-INDEP
-;  V05 tmp2         [V05,T04] (  2,  1.50)    long  ->  rcx         single-def "field V00.value (fldOffset=0x8)" P-INDEP
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  2,  2   )   ubyte  ->  rax         single-def "field V00.hasValue (fldOffset=0x0)" P-INDEP
+;  V05 tmp2         [V05,T03] (  2,  1.50)    long  ->  rcx         single-def "field V00.value (fldOffset=0x8)" P-INDEP
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Nullable`1[long]>
-;  V07 cse0         [V07,T02] (  3,  2.50)     int  ->  rax         "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
-G_M56380_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+G_M56380_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M56380_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref, isz
        ; byrRegs +[rcx]
        movzx    rax, byte  ptr [rcx]
        mov      rcx, qword ptr [rcx+0x08]
        ; byrRegs -[rcx]
-       test     eax, eax
-       je       SHORT G_M56380_IG05
+       test     al, al
+       je       SHORT G_M56380_IG04
 						;; size=11 bbWeight=1 PerfScore 5.25
-G_M56380_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       test     eax, eax
-       je       SHORT G_M56380_IG07
-						;; size=4 bbWeight=0.50 PerfScore 0.62
-G_M56380_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M56380_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        tail.jmp [<unknown method>]
        ; gcr arg pop 0
-						;; size=10 bbWeight=0.50 PerfScore 1.12
-G_M56380_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=6 bbWeight=0.50 PerfScore 1.00
+G_M56380_IG04:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M56380_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M56380_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M56380_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()
-       call     [rax]System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 49, prolog size 4, PerfScore 8.00, instruction count 15, allocated bytes for code 49 (MethodHash=a8da23c3) for method Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreaterEquals[long](System.Nullable`1[long],long):ubyte (FullOpts)
+; Total bytes of code 20, prolog size 0, PerfScore 6.88, instruction count 7, allocated bytes for code 20 (MethodHash=a8da23c3) for method Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreaterEquals[long](System.Nullable`1[long],long):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -61,9 +47,8 @@ Unwind Info:
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
<summary><span style="color:red">+43</span> (<span style="color:red">+9.49%</span>) : 312811.dasm - Xunit.Sdk.AssertEqualityComparer`1[System.Numerics.Vector`1[float]]:Equals(System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],byref):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -21,7 +21,7 @@
 ;* V10 loc6         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <<unknown class>>
 ;* V11 loc7         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Reflection.TypeInfo>
 ;* V12 loc8         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Reflection.MethodInfo>
-;* V13 loc9         [V13,T34] (  0,  0   )   ubyte  ->  zero-ref    single-def
+;* V13 loc9         [V13,T33] (  0,  0   )   ubyte  ->  zero-ref    single-def
 ;* V14 loc10        [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Reflection.TypeInfo>
 ;* V15 loc11        [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Reflection.MethodInfo>
 ;* V16 loc12        [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Object>
@@ -36,24 +36,24 @@
 ;  V25 tmp1         [V25,T08] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
 ;* V26 tmp2         [V26,T25] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
 ;* V27 tmp3         [V27,T26] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
-;* V28 tmp4         [V28,T36] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
+;* V28 tmp4         [V28,T35] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
 ;* V29 tmp5         [V29    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V30 tmp6         [V30    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
-;* V31 tmp7         [V31,T37] (  0,  0   )     ref  ->  zero-ref   
-;* V32 tmp8         [V32,T38] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
+;* V31 tmp7         [V31,T36] (  0,  0   )     ref  ->  zero-ref   
+;* V32 tmp8         [V32,T37] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
 ;* V33 tmp9         [V33    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V34 tmp10        [V34    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
-;* V35 tmp11        [V35,T39] (  0,  0   )     ref  ->  zero-ref   
+;* V35 tmp11        [V35,T38] (  0,  0   )     ref  ->  zero-ref   
 ;* V36 tmp12        [V36    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V37 tmp13        [V37    ] (  0,  0   )     ref  ->  zero-ref   
-;* V38 tmp14        [V38,T40] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
+;* V38 tmp14        [V38,T39] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
 ;* V39 tmp15        [V39    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V40 tmp16        [V40    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
-;* V41 tmp17        [V41,T41] (  0,  0   )     ref  ->  zero-ref   
-;* V42 tmp18        [V42,T42] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
+;* V41 tmp17        [V41,T40] (  0,  0   )     ref  ->  zero-ref   
+;* V42 tmp18        [V42,T41] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Reflection.PropertyInfo>
 ;* V43 tmp19        [V43    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V44 tmp20        [V44    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <System.Numerics.Vector`1[float]>
-;* V45 tmp21        [V45,T43] (  0,  0   )     ref  ->  zero-ref   
+;* V45 tmp21        [V45,T42] (  0,  0   )     ref  ->  zero-ref   
 ;* V46 tmp22        [V46    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V47 tmp23        [V47    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V48 tmp24        [V48    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Single-def Box Helper" <System.Numerics.Vector`1[float]>
@@ -153,14 +153,14 @@
 ;* V142 tmp118      [V142,T31] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.Numerics.Vector`1[float]>
 ;* V143 tmp119      [V143,T32] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.Numerics.Vector`1[float]>
 ;* V144 tmp120      [V144    ] (  0,  0   )   ubyte  ->  zero-ref    single-def "Inline return value spill temp"
-;* V145 tmp121      [V145,T23] (  0,  0   )  simd32  ->  zero-ref    "Inline stloc first use temp" <System.Numerics.Vector`1[float]>
-;* V146 tmp122      [V146,T33] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
+;* V145 tmp121      [V145,T24] (  0,  0   )  simd32  ->  zero-ref    "Inline stloc first use temp" <System.Numerics.Vector`1[float]>
+;* V146 tmp122      [V146,T23] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V147 tmp123      [V147    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V148 tmp124      [V148,T44] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
+;* V148 tmp124      [V148,T43] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
 ;* V149 tmp125      [V149    ] (  0,  0   )  simd32  ->  zero-ref    "spilled call-like call argument"
 ;* V150 tmp126      [V150    ] (  0,  0   )  simd32  ->  zero-ref    "Inline stloc first use temp" <System.Numerics.Vector`1[float]>
 ;* V151 tmp127      [V151    ] (  0,  0   )  simd32  ->  zero-ref    do-not-enreg[XS] addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <System.Numerics.Vector`1[ulong]>
-;* V152 tmp128      [V152,T35] (  0,  0   )  simd32  ->  zero-ref    "Inlining Arg" <System.Numerics.Vector`1[float]>
+;* V152 tmp128      [V152,T34] (  0,  0   )  simd32  ->  zero-ref    "Inlining Arg" <System.Numerics.Vector`1[float]>
 ;* V153 tmp129      [V153    ] (  0,  0   )  simd32  ->  zero-ref    do-not-enreg[XS] addr-exposed ld-addr-op "Inline stloc first use temp" <System.Numerics.Vector`1[ulong]>
 ;* V154 tmp130      [V154,T09] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V155 tmp131      [V155,T13] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
@@ -182,30 +182,27 @@
 ;* V171 tmp147      [V171    ] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
 ;* V172 tmp148      [V172    ] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
 ;* V173 tmp149      [V173    ] (  0,  0   )     ref  ->  zero-ref    single-def "argument with side effect"
-;  V174 PSPSym      [V174,T18] (  1,  1   )    long  ->  [rbp-0x98]  do-not-enreg[V] "PSPSym"
-;* V175 cse0        [V175    ] (  0,  0   )    long  ->  zero-ref    "CSE - conservative"
-;* V176 cse1        [V176,T45] (  0,  0   )    long  ->  zero-ref    multi-def "CSE - moderate"
-;* V177 cse2        [V177,T24] (  0,  0   )  simd32  ->  zero-ref    "CSE - conservative"
-;  V178 cse3        [V178,T01] (  6, 24   )     ref  ->  rdx         multi-def "CSE - aggressive"
-;  V179 cse4        [V179,T14] (  2,  2   )    long  ->  rcx         multi-def "CSE - aggressive"
-;  V180 cse5        [V180,T20] (  4,  4   )  simd32  ->  mm1         "CSE - conservative"
-;  V181 cse6        [V181,T02] (  3, 24   )    long  ->  rsi         "CSE - aggressive"
+;  V174 PSPSym      [V174,T18] (  1,  1   )    long  ->  [rbp-0xA8]  do-not-enreg[V] "PSPSym"
+;  V175 cse0        [V175,T01] (  6, 24   )     ref  ->  [rbp-0xA0]  do-not-enreg[H] EH-live multi-def "CSE - aggressive"
+;  V176 cse1        [V176,T14] (  2,  2   )    long  ->  [rbp-0x98]  do-not-enreg[H] EH-live "CSE - moderate"
+;  V177 cse2        [V177,T20] (  4,  4   )  simd32  ->  mm1         "CSE - conservative"
+;  V178 cse3        [V178,T02] (  3, 24   )    long  ->  rsi         "CSE - aggressive"
 ;
-; Lcl frame size = 184
+; Lcl frame size = 200
 
 G_M47108_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbp
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 184
-       vmovaps  xmmword ptr [rsp+0xA0], xmm6
-       vmovaps  xmmword ptr [rsp+0x90], xmm7
-       lea      rbp, [rsp+0xD0]
+       sub      rsp, 200
+       vmovaps  xmmword ptr [rsp+0xB0], xmm6
+       vmovaps  xmmword ptr [rsp+0xA0], xmm7
+       lea      rbp, [rsp+0xE0]
        vxorps   xmm4, xmm4, xmm4
        vmovdqu  ymmword ptr [rbp-0x90], ymm4
        vmovdqu  ymmword ptr [rbp-0x70], ymm4
-       mov      qword ptr [rbp-0x98], rsp
+       mov      qword ptr [rbp-0xA8], rsp
        mov      bword ptr [rbp+0x18], rdx
        ; GC ptr vars +{V01}
        mov      bword ptr [rbp+0x20], r8
@@ -216,6 +213,7 @@ G_M47108_IG02:        ; bbWeight=1, gcVars=00000000000000C0 {V01 V02}, gcrefRegs
        xor      ecx, ecx
        mov      qword ptr [r9], rcx
        mov      rcx, 0xD1FFAB1E      ; System.Numerics.Vector`1[float]
+       mov      qword ptr [rbp-0x98], rcx
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; byrRegs -[r9]
@@ -237,7 +235,7 @@ G_M47108_IG02:        ; bbWeight=1, gcVars=00000000000000C0 {V01 V02}, gcrefRegs
        vorps    ymm0, ymm0, ymm1
        vmovups  ymmword ptr [rbp-0x90], ymm0
        xor      ebx, ebx
-						;; size=79 bbWeight=1 PerfScore 32.33
+						;; size=86 bbWeight=1 PerfScore 33.33
 G_M47108_IG03:        ; bbWeight=8, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        ; byrRegs -[rax rdx r8]
        ; GC ptr vars -{V01 V02}
@@ -252,16 +250,20 @@ G_M47108_IG04:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        jne      SHORT G_M47108_IG06
 						;; size=12 bbWeight=4 PerfScore 11.00
 G_M47108_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
+       mov      gword ptr [rbp-0xA0], rcx
+       ; GC ptr vars +{V175}
+       mov      rcx, gword ptr [rbp-0xA0]
+       mov      rdx, gword ptr [rbp-0xA0]
+       ; gcrRegs +[rdx]
        vextractf128 xmm7, ymm6, 1
+       ; GC ptr vars -{V175}
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
        vinsertf128 ymm6, ymm6, xmm7, 1
-						;; size=31 bbWeight=4 PerfScore 30.00
+						;; size=49 bbWeight=4 PerfScore 41.00
 G_M47108_IG06:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        lea      rcx, bword ptr [rbp-0x90]
        ; byrRegs +[rcx]
@@ -281,16 +283,20 @@ G_M47108_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        jne      SHORT G_M47108_IG09
 						;; size=12 bbWeight=4 PerfScore 11.00
 G_M47108_IG08:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+       mov      rcx, 0xD1FFAB1E
        ; gcrRegs +[rcx]
+       mov      gword ptr [rbp-0xA0], rcx
+       ; GC ptr vars +{V175}
+       mov      rcx, gword ptr [rbp-0xA0]
+       mov      rdx, gword ptr [rbp-0xA0]
+       ; gcrRegs +[rdx]
        vextractf128 xmm7, ymm6, 1
+       ; GC ptr vars -{V175}
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
        vinsertf128 ymm6, ymm6, xmm7, 1
-						;; size=31 bbWeight=4 PerfScore 30.00
+						;; size=49 bbWeight=4 PerfScore 41.00
 G_M47108_IG09:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        lea      rax, bword ptr [rbp-0x70]
        ; byrRegs +[rax]
@@ -310,9 +316,9 @@ G_M47108_IG10:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
 						;; size=25 bbWeight=1 PerfScore 5.25
 G_M47108_IG11:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       vmovaps  xmm6, xmmword ptr [rsp+0xA0]
-       vmovaps  xmm7, xmmword ptr [rsp+0x90]
-       add      rsp, 184
+       vmovaps  xmm6, xmmword ptr [rsp+0xB0]
+       vmovaps  xmm7, xmmword ptr [rsp+0xA0]
+       add      rsp, 200
        pop      rbx
        pop      rsi
        pop      rdi
@@ -338,7 +344,7 @@ G_M47108_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vmovaps  xmmword ptr [rsp+0x40], xmm7
        mov      rbp, qword ptr [rcx+0x38]
        mov      qword ptr [rsp+0x38], rbp
-       lea      rbp, [rbp+0xD0]
+       lea      rbp, [rbp+0xE0]
 						;; size=36 bbWeight=0 PerfScore 0.00
 G_M47108_IG16:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        int3     
@@ -353,7 +359,7 @@ G_M47108_IG17:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vmovaps  xmmword ptr [rsp+0x40], xmm7
        mov      rbp, qword ptr [rcx+0x38]
        mov      qword ptr [rsp+0x38], rbp
-       lea      rbp, [rbp+0xD0]
+       lea      rbp, [rbp+0xE0]
 						;; size=36 bbWeight=0 PerfScore 0.00
 G_M47108_IG18:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        int3     
@@ -368,13 +374,13 @@ G_M47108_IG19:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        vmovaps  xmmword ptr [rsp+0x40], xmm7
        mov      rbp, qword ptr [rcx+0x38]
        mov      qword ptr [rsp+0x38], rbp
-       lea      rbp, [rbp+0xD0]
+       lea      rbp, [rbp+0xE0]
 						;; size=36 bbWeight=0 PerfScore 0.00
 G_M47108_IG20:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        int3     
 						;; size=1 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 453, prolog size 69, PerfScore 217.92, instruction count 116, allocated bytes for code 455 (MethodHash=869547fb) for method Xunit.Sdk.AssertEqualityComparer`1[System.Numerics.Vector`1[float]]:Equals(System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],byref):ubyte:this (FullOpts)
+; Total bytes of code 496, prolog size 69, PerfScore 240.92, instruction count 121, allocated bytes for code 498 (MethodHash=869547fb) for method Xunit.Sdk.AssertEqualityComparer`1[System.Numerics.Vector`1[float]]:Equals(System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],byref):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -388,11 +394,11 @@ Unwind Info:
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
     CodeOffset: 0x1D UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
-      Scaled Small Offset: 9 * 16 = 144 = 0x00090
-    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
       Scaled Small Offset: 10 * 16 = 160 = 0x000A0
+    CodeOffset: 0x14 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 11 * 16 = 176 = 0x000B0
     CodeOffset: 0x0B UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
-      Size: 23 * 8 = 184 = 0x000B8
+      Size: 25 * 8 = 200 = 0x000C8
     CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+13.79%</span>) : 84926.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,14 +7,14 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  6,  6   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  6,  6   )     int  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  5,  4   )     int  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  5,  4   )     int  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  registers  
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V07 tmp4         [V07,T02] (  3,  2   )     int  ->  rcx        
+;  V07 tmp4         [V07,T02] (  4,  2   )     int  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,30 +22,41 @@ G_M19887_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M19887_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ecx, edx
-       mov      eax, ecx
-       cmovg    eax, edx
-       cmovle   ecx, edx
-       cmp      eax, 3
-       jne      SHORT G_M19887_IG04
-						;; size=15 bbWeight=1 PerfScore 2.25
+       jg       SHORT G_M19887_IG04
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19887_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, 4
-       je       SHORT G_M19887_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jmp      SHORT G_M19887_IG05
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M19887_IG06
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, edx
+       jmp      SHORT G_M19887_IG07
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M19887_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, ecx
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       mov      ecx, edx
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M19887_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      ecx, 3
+       jne      SHORT G_M19887_IG09
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M19887_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      eax, 4
+       je       SHORT G_M19887_IG10
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M19887_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M19887_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M19887_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 5
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M19887_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 29, prolog size 0, PerfScore 4.12, instruction count 12, allocated bytes for code 29 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
+; Total bytes of code 33, prolog size 0, PerfScore 7.62, instruction count 15, allocated bytes for code 33 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+41</span> (<span style="color:red">+14.24%</span>) : 205330.dasm - System.Data.ColumnTypeConverter:ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object):System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,17 +8,17 @@
 ; 2 inlinees with PGO data; 5 single block inlinees; 3 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T07] (  3,  2.50)     ref  ->  rcx         this class-hnd single-def <System.Data.ColumnTypeConverter>
-;  V01 arg1         [V01,T08] (  3,  2.50)     ref  ->  rdx         class-hnd single-def <System.ComponentModel.ITypeDescriptorContext>
-;  V02 arg2         [V02,T09] (  3,  2.50)     ref  ->   r8         class-hnd single-def <System.Globalization.CultureInfo>
-;  V03 arg3         [V03,T01] (  9, 24.01)     ref  ->  rbx         class-hnd single-def <System.Object>
+;  V00 this         [V00,T09] (  3,  2.50)     ref  ->  rcx         this class-hnd single-def <System.Data.ColumnTypeConverter>
+;  V01 arg1         [V01,T10] (  3,  2.50)     ref  ->  rdx         class-hnd single-def <System.ComponentModel.ITypeDescriptorContext>
+;  V02 arg2         [V02,T11] (  3,  2.50)     ref  ->   r8         class-hnd single-def <System.Globalization.CultureInfo>
+;  V03 arg3         [V03,T01] (  8, 25.00)     ref  ->  rbx         class-hnd single-def <System.Object>
 ;  V04 loc0         [V04,T04] (  8, 21.50)     int  ->  rsi        
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T11] (  3,  2.51)   ubyte  ->  rax         "Inline return value spill temp"
-;  V07 tmp2         [V07,T00] (  7, 57.04)     ref  ->  rbp         class-hnd exact "Inlining Arg" <System.String>
+;  V06 tmp1         [V06,T12] (  2,  4   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V07 tmp2         [V07,T00] (  6, 62.00)     ref  ->  rax         class-hnd exact "Inlining Arg" <System.String>
 ;* V08 tmp3         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling QMark2" <System.String>
 ;* V09 tmp4         [V09,T05] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.String>
-;  V10 tmp5         [V10,T12] (  2,  2.03)   byref  ->  rcx         "impAppendStmt"
+;  V10 tmp5         [V10,T07] (  2,  8   )   byref  ->  rcx         "impAppendStmt"
 ;* V11 tmp6         [V11    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V12 tmp7         [V12    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V13 tmp8         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -26,22 +26,20 @@
 ;* V15 tmp10        [V15    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;  V16 tmp11        [V16,T02] (  3, 24   )     ref  ->  rcx         "arr expr"
 ;  V17 tmp12        [V17,T03] (  3, 24   )     ref  ->  rcx         "argument with side effect"
-;  V18 tmp13        [V18,T10] (  3,  3   )     ref  ->  rax         single-def "arr expr"
-;* V19 cse0         [V19,T14] (  0,  0   )    long  ->  zero-ref    "CSE - aggressive"
-;  V20 cse1         [V20,T06] (  5,  9.50)    long  ->  rdi         "CSE - aggressive"
-;  V21 cse2         [V21,T13] (  3,  1.52)     ref  ->  rdx         multi-def "CSE - moderate"
+;  V18 tmp13        [V18,T13] (  3,  3   )     ref  ->  rax         single-def "arr expr"
+;* V19 cse0         [V19,T08] (  0,  0   )    long  ->  zero-ref    multi-def "CSE - aggressive"
+;  V20 cse1         [V20,T06] (  7, 14   )    long  ->  rdi         multi-def "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M21223_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rdi
        push     rsi
-       push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        mov      rbx, r9
        ; gcrRegs +[rbx]
-						;; size=11 bbWeight=1 PerfScore 4.50
+						;; size=10 bbWeight=1 PerfScore 3.50
 G_M21223_IG02:        ; bbWeight=1, gcrefRegs=010E {rcx rdx rbx r8}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx rdx r8]
        test     rbx, rbx
@@ -61,7 +59,7 @@ G_M21223_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        mov      rcx, gword ptr [rdi]
        ; gcrRegs +[rcx]
        cmp      dword ptr [rcx+0x08], 0
-       jle      SHORT G_M21223_IG11
+       jle      SHORT G_M21223_IG10
 						;; size=19 bbWeight=0.50 PerfScore 3.12
 G_M21223_IG05:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rcx]
@@ -76,98 +74,87 @@ G_M21223_IG05:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        call     [rax+0x08]<unknown method>
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       mov      rbp, rax
-       ; gcrRegs +[rbp]
-       cmp      byte  ptr [rbp], bpl
-       cmp      rbp, rbx
-       je       SHORT G_M21223_IG13
-						;; size=41 bbWeight=4 PerfScore 79.00
-G_M21223_IG06:        ; bbWeight=15.00, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      ecx, dword ptr [rbp+0x08]
-       cmp      ecx, dword ptr [rbx+0x08]
-       jne      G_M21223_IG19
-						;; size=12 bbWeight=15.00 PerfScore 90.00
-G_M21223_IG07:        ; bbWeight=0.51, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
-       mov      ecx, dword ptr [rbp+0x08]
-       cmp      ecx, dword ptr [rbx+0x08]
-       je       SHORT G_M21223_IG08
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
-       ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=33 bbWeight=0.51 PerfScore 4.94
-G_M21223_IG08:        ; bbWeight=0.51, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref
-       lea      rcx, bword ptr [rbp+0x0C]
+       cmp      byte  ptr [rax], al
+       cmp      rax, rbx
+       je       SHORT G_M21223_IG12
+						;; size=36 bbWeight=4 PerfScore 78.00
+G_M21223_IG06:        ; bbWeight=15.00, gcrefRegs=0009 {rax rbx}, byrefRegs=0000 {}, byref, isz
+       mov      r8d, dword ptr [rax+0x08]
+       cmp      r8d, dword ptr [rbx+0x08]
+       jne      SHORT G_M21223_IG08
+						;; size=10 bbWeight=15.00 PerfScore 90.00
+G_M21223_IG07:        ; bbWeight=2, gcrefRegs=0009 {rax rbx}, byrefRegs=0000 {}, byref, isz
+       lea      rcx, bword ptr [rax+0x0C]
        ; byrRegs +[rcx]
-       mov      r8d, dword ptr [rbp+0x08]
+       mov      r8d, dword ptr [rax+0x08]
        add      r8d, r8d
        lea      rdx, bword ptr [rbx+0x0C]
        ; byrRegs +[rdx]
        call     [<unknown method>]
-       ; gcrRegs -[rbp]
+       ; gcrRegs -[rax]
        ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
-						;; size=21 bbWeight=0.51 PerfScore 3.17
-G_M21223_IG09:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        test     eax, eax
-       jne      SHORT G_M21223_IG13
-						;; size=4 bbWeight=2 PerfScore 2.50
-G_M21223_IG10:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       jne      SHORT G_M21223_IG12
+						;; size=25 bbWeight=2 PerfScore 15.00
+G_M21223_IG08:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        inc      esi
+       test     byte  ptr [(reloc)], 1      ; global ptr
+       je       G_M21223_IG19
+						;; size=15 bbWeight=4 PerfScore 17.00
+G_M21223_IG09:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rdi, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rax, gword ptr [rdi]
        ; gcrRegs +[rax]
        cmp      dword ptr [rax+0x08], esi
        jg       SHORT G_M21223_IG05
-						;; size=10 bbWeight=4 PerfScore 25.00
-G_M21223_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=18 bbWeight=4 PerfScore 25.00
+G_M21223_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rbx]
        mov      rax, 0xD1FFAB1E
        ; gcrRegs +[rax]
 						;; size=10 bbWeight=0.50 PerfScore 0.12
-G_M21223_IG12:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+G_M21223_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 32
        pop      rbx
-       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
-G_M21223_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+						;; size=8 bbWeight=0.50 PerfScore 1.38
+G_M21223_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs -[rax]
+       test     byte  ptr [(reloc)], 1      ; global ptr
+       je       SHORT G_M21223_IG20
+						;; size=9 bbWeight=0.50 PerfScore 2.00
+G_M21223_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      rdi, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rax, gword ptr [rdi]
        ; gcrRegs +[rax]
        cmp      esi, dword ptr [rax+0x08]
        jae      SHORT G_M21223_IG17
        mov      ecx, esi
        mov      rax, gword ptr [rax+8*rcx+0x10]
-						;; size=15 bbWeight=0.50 PerfScore 4.12
+						;; size=25 bbWeight=0.50 PerfScore 4.25
 G_M21223_IG14:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
-       pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 G_M21223_IG15:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=010E {rcx rdx rbx r8}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rax] +[rcx rdx rbx r8]
        mov      r9, rbx
        ; gcrRegs +[r9]
 						;; size=3 bbWeight=0.50 PerfScore 0.12
 G_M21223_IG16:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 32
        pop      rbx
-       pop      rbp
        pop      rsi
        pop      rdi
        tail.jmp [System.ComponentModel.TypeConverter:ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object):System.Object:this]
        ; gcr arg pop 0
-						;; size=14 bbWeight=0.50 PerfScore 2.12
+						;; size=13 bbWeight=0.50 PerfScore 1.88
 G_M21223_IG17:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rcx rdx rbx r8-r9]
        call     CORINFO_HELP_RNGCHKFAIL
@@ -181,12 +168,23 @@ G_M21223_IG18:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        ; gcr arg pop 0
        jmp      G_M21223_IG04
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M21223_IG19:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       xor      eax, eax
-       jmp      SHORT G_M21223_IG09
-						;; size=4 bbWeight=0 PerfScore 0.00
+G_M21223_IG19:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       mov      rcx, 0xD1FFAB1E
+       mov      edx, 54
+       call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       ; gcr arg pop 0
+       jmp      G_M21223_IG09
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M21223_IG20:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rbx]
+       mov      rcx, 0xD1FFAB1E
+       mov      edx, 54
+       call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       ; gcr arg pop 0
+       jmp      SHORT G_M21223_IG13
+						;; size=22 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 288, prolog size 11, PerfScore 227.49, instruction count 83, allocated bytes for code 288 (MethodHash=3d9fad18) for method System.Data.ColumnTypeConverter:ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object):System.Object:this (FullOpts)
+; Total bytes of code 329, prolog size 10, PerfScore 248.25, instruction count 83, allocated bytes for code 329 (MethodHash=3d9fad18) for method System.Data.ColumnTypeConverter:ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object):System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -194,13 +192,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x08
-  CountOfUnwindCodes: 5
+  SizeOfProlog      : 0x07
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
     CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-32</span> (<span style="color:green">-64.00%</span>) : 122407.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,45 +10,31 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  5,  4   )     ref  ->  rcx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceDescriptor>
-;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  3,  2.98)     ref  ->  rax         "CSE - aggressive"
+;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
-G_M22035_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+G_M22035_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22035_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       test     rax, rax
+       cmp      gword ptr [rcx+0x08], 0
        jne      SHORT G_M22035_IG05
-						;; size=9 bbWeight=1 PerfScore 3.25
-G_M22035_IG03:        ; bbWeight=0.98, gcrefRegs=0003 {rax rcx}, byrefRegs=0000 {}, byref, isz
-       test     rax, rax
-       jne      SHORT G_M22035_IG06
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M22035_IG03:        ; bbWeight=0.98, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        mov      rax, gword ptr [rcx+0x20]
-						;; size=9 bbWeight=0.98 PerfScore 3.17
+       ; gcrRegs +[rax]
+						;; size=4 bbWeight=0.98 PerfScore 1.95
 G_M22035_IG04:        ; bbWeight=0.98, epilog, nogc, extend
-       add      rsp, 40
        ret      
-						;; size=5 bbWeight=0.98 PerfScore 1.22
+						;; size=1 bbWeight=0.98 PerfScore 0.98
 G_M22035_IG05:        ; bbWeight=0.02, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rax]
-       add      rsp, 40
        tail.jmp [Microsoft.Extensions.DependencyInjection.ServiceDescriptor:get_KeyedImplementationInstance():System.Object:this]
        ; gcr arg pop 0
-						;; size=10 bbWeight=0.02 PerfScore 0.06
-G_M22035_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for Microsoft.Extensions.DependencyInjection.ServiceDescriptor:ThrowKeyedDescriptor()
-       call     [rax]Microsoft.Extensions.DependencyInjection.ServiceDescriptor:ThrowKeyedDescriptor()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=6 bbWeight=0.02 PerfScore 0.05
 
-; Total bytes of code 50, prolog size 4, PerfScore 7.94, instruction count 14, allocated bytes for code 50 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (Tier1)
+; Total bytes of code 18, prolog size 0, PerfScore 6.98, instruction count 5, allocated bytes for code 18 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -56,9 +42,8 @@ Unwind Info:
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
<summary><span style="color:green">-32</span> (<span style="color:green">-64.00%</span>) : 122389.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,45 +10,31 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  5,  4   )     ref  ->  rcx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceDescriptor>
-;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  3,  2.99)     ref  ->  rax         "CSE - aggressive"
+;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
-G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+G_M17231_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       test     rax, rax
+       cmp      gword ptr [rcx+0x08], 0
        jne      SHORT G_M17231_IG05
-						;; size=9 bbWeight=1 PerfScore 3.25
-G_M17231_IG03:        ; bbWeight=0.99, gcrefRegs=0003 {rax rcx}, byrefRegs=0000 {}, byref, isz
-       test     rax, rax
-       jne      SHORT G_M17231_IG06
+						;; size=7 bbWeight=1 PerfScore 4.00
+G_M17231_IG03:        ; bbWeight=0.99, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        mov      rax, gword ptr [rcx+0x18]
-						;; size=9 bbWeight=0.99 PerfScore 3.22
+       ; gcrRegs +[rax]
+						;; size=4 bbWeight=0.99 PerfScore 1.98
 G_M17231_IG04:        ; bbWeight=0.99, epilog, nogc, extend
-       add      rsp, 40
        ret      
-						;; size=5 bbWeight=0.99 PerfScore 1.24
+						;; size=1 bbWeight=0.99 PerfScore 0.99
 G_M17231_IG05:        ; bbWeight=0.01, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rax]
-       add      rsp, 40
        tail.jmp [Microsoft.Extensions.DependencyInjection.ServiceDescriptor:get_KeyedImplementationType():System.Type:this]
        ; gcr arg pop 0
-						;; size=10 bbWeight=0.01 PerfScore 0.02
-G_M17231_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for Microsoft.Extensions.DependencyInjection.ServiceDescriptor:ThrowKeyedDescriptor()
-       call     [rax]Microsoft.Extensions.DependencyInjection.ServiceDescriptor:ThrowKeyedDescriptor()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=6 bbWeight=0.01 PerfScore 0.02
 
-; Total bytes of code 50, prolog size 4, PerfScore 7.98, instruction count 14, allocated bytes for code 50 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
+; Total bytes of code 18, prolog size 0, PerfScore 6.99, instruction count 5, allocated bytes for code 18 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -56,9 +42,8 @@ Unwind Info:
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
<summary><span style="color:green">-32</span> (<span style="color:green">-64.00%</span>) : 130872.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,43 +10,29 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  5,  4   )     ref  ->  rcx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceDescriptor>
-;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 cse0         [V02,T01] (  3,  3   )     ref  ->  rax         "CSE - aggressive"
+;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
-G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       sub      rsp, 40
-						;; size=4 bbWeight=1 PerfScore 0.25
+G_M17231_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       test     rax, rax
+       cmp      gword ptr [rcx+0x08], 0
        jne      SHORT G_M17231_IG04
-       test     rax, rax
-       jne      SHORT G_M17231_IG05
        mov      rax, gword ptr [rcx+0x18]
-						;; size=18 bbWeight=1 PerfScore 6.50
+       ; gcrRegs +[rax]
+						;; size=11 bbWeight=1 PerfScore 6.00
 G_M17231_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
        ret      
-						;; size=5 bbWeight=1 PerfScore 1.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 G_M17231_IG04:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rax]
-       add      rsp, 40
        tail.jmp [Microsoft.Extensions.DependencyInjection.ServiceDescriptor:get_KeyedImplementationType():System.Type:this]
        ; gcr arg pop 0
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M17231_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for Microsoft.Extensions.DependencyInjection.ServiceDescriptor:ThrowKeyedDescriptor()
-       call     [rax]Microsoft.Extensions.DependencyInjection.ServiceDescriptor:ThrowKeyedDescriptor()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 50, prolog size 4, PerfScore 8.00, instruction count 14, allocated bytes for code 50 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
+; Total bytes of code 18, prolog size 0, PerfScore 7.00, instruction count 5, allocated bytes for code 18 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -54,9 +40,8 @@ Unwind Info:
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
<summary><span style="color:red">+33</span> (<span style="color:red">+10.41%</span>) : 266548.dasm - System.Data.Common.Int32Storage:Aggregate(int[],int):System.Object:this (Tier1-OSR)</summary>
<div style="margin-left:1em">

```diff
@@ -10,36 +10,36 @@
 ; 2 inlinees with PGO data; 6 single block inlinees; 6 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T16] (  4,  3.14)     ref  ->  rcx         this class-hnd single-def <System.Data.Common.Int32Storage>
-;  V01 arg1         [V01,T44] (  5,102   )     ref  ->  rdx         class-hnd single-def <int[]>
+;  V00 this         [V00,T14] (  4,  3.14)     ref  ->  rcx         this class-hnd single-def <System.Data.Common.Int32Storage>
+;  V01 arg1         [V01,T43] (  5,102   )     ref  ->  rdx         class-hnd single-def <int[]>
 ;* V02 arg2         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
-;* V03 loc0         [V03,T17] (  0,  0   )   ubyte  ->  zero-ref   
-;* V04 loc1         [V04,T33] (  0,  0   )    long  ->  zero-ref   
-;* V05 loc2         [V05,T34] (  0,  0   )    long  ->  zero-ref   
-;* V06 loc3         [V06,T35] (  0,  0   )     int  ->  zero-ref   
-;  V07 loc4         [V07,T43] (  5,198.74)     int  ->  [rbp+0x108]  tier0-frame
+;* V03 loc0         [V03,T15] (  0,  0   )   ubyte  ->  zero-ref   
+;* V04 loc1         [V04,T31] (  0,  0   )    long  ->  zero-ref   
+;* V05 loc2         [V05,T32] (  0,  0   )    long  ->  zero-ref   
+;* V06 loc3         [V06,T33] (  0,  0   )     int  ->  zero-ref   
+;  V07 loc4         [V07,T42] (  5,198.74)     int  ->  [rbp+0x108]  tier0-frame
 ;* V08 loc5         [V08    ] (  0,  0   )  double  ->  zero-ref   
 ;* V09 loc6         [V09    ] (  0,  0   )  double  ->  zero-ref   
-;* V10 loc7         [V10,T60] (  0,  0   )  double  ->  zero-ref   
-;* V11 loc8         [V11,T61] (  0,  0   )  double  ->  zero-ref   
-;* V12 loc9         [V12,T25] (  0,  0   )     int  ->  zero-ref   
-;* V13 loc10        [V13,T26] (  0,  0   )     int  ->  zero-ref   
-;* V14 loc11        [V14,T37] (  0,  0   )     ref  ->  zero-ref    class-hnd <int[]>
-;* V15 loc12        [V15,T24] (  0,  0   )     int  ->  zero-ref   
-;* V16 loc13        [V16,T09] (  0,  0   )     int  ->  zero-ref   
-;  V17 loc14        [V17,T50] (  2,  0.89)     ref  ->  rax         class-hnd <System.Object>
-;* V18 loc15        [V18,T36] (  0,  0   )     ref  ->  zero-ref    class-hnd <int[]>
-;* V19 loc16        [V19,T23] (  0,  0   )     int  ->  zero-ref   
-;* V20 loc17        [V20,T08] (  0,  0   )     int  ->  zero-ref   
+;* V10 loc7         [V10,T58] (  0,  0   )  double  ->  zero-ref   
+;* V11 loc8         [V11,T59] (  0,  0   )  double  ->  zero-ref   
+;* V12 loc9         [V12,T23] (  0,  0   )     int  ->  zero-ref   
+;* V13 loc10        [V13,T24] (  0,  0   )     int  ->  zero-ref   
+;* V14 loc11        [V14,T35] (  0,  0   )     ref  ->  zero-ref    class-hnd <int[]>
+;* V15 loc12        [V15,T22] (  0,  0   )     int  ->  zero-ref   
+;* V16 loc13        [V16,T05] (  0,  0   )     int  ->  zero-ref   
+;  V17 loc14        [V17,T48] (  2,  0.89)     ref  ->  rax         class-hnd <System.Object>
+;* V18 loc15        [V18,T34] (  0,  0   )     ref  ->  zero-ref    class-hnd <int[]>
+;* V19 loc16        [V19,T21] (  0,  0   )     int  ->  zero-ref   
+;* V20 loc17        [V20,T04] (  0,  0   )     int  ->  zero-ref   
 ;* V21 loc18        [V21    ] (  0,  0   )     int  ->  zero-ref   
-;* V22 loc19        [V22,T59] (  0,  0   )     ref  ->  zero-ref    class-hnd <int[]>
-;* V23 loc20        [V23,T55] (  0,  0   )     int  ->  zero-ref   
-;* V24 loc21        [V24,T47] (  0,  0   )     int  ->  zero-ref   
-;* V25 loc22        [V25,T21] (  0,  0   )     int  ->  zero-ref   
-;* V26 loc23        [V26,T06] (  0,  0   )     int  ->  zero-ref   
-;* V27 loc24        [V27,T22] (  0,  0   )     int  ->  zero-ref   
-;* V28 loc25        [V28,T07] (  0,  0   )     int  ->  zero-ref   
-;  V29 loc26        [V29,T41] ( 11,400.72)     int  ->  [rbp+0x8C]  tier0-frame
+;* V22 loc19        [V22,T57] (  0,  0   )     ref  ->  zero-ref    class-hnd <int[]>
+;* V23 loc20        [V23,T54] (  0,  0   )     int  ->  zero-ref   
+;* V24 loc21        [V24,T45] (  0,  0   )     int  ->  zero-ref   
+;* V25 loc22        [V25,T19] (  0,  0   )     int  ->  zero-ref   
+;* V26 loc23        [V26,T02] (  0,  0   )     int  ->  zero-ref   
+;* V27 loc24        [V27,T20] (  0,  0   )     int  ->  zero-ref   
+;* V28 loc25        [V28,T03] (  0,  0   )     int  ->  zero-ref   
+;  V29 loc26        [V29,T39] ( 11,400.72)     int  ->  [rbp+0x8C]  tier0-frame
 ;  V30 OutArgs      [V30    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V31 tmp1         [V31    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <<unknown class>>
 ;* V32 tmp2         [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <<unknown class>>
@@ -49,61 +49,60 @@
 ;* V36 tmp6         [V36    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <<unknown class>>
 ;* V37 tmp7         [V37    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "Single-def Box Helper" <<unknown class>>
 ;* V38 tmp8         [V38    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impSpillSpecialSideEff" <<unknown class>>
-;  V39 tmp9         [V39,T54] (  3,  0.78)     ref  ->  rax         class-hnd exact single-def "Single-def Box Helper" <<unknown class>>
-;* V40 tmp10        [V40,T48] (  0,  0   )     int  ->  zero-ref    "OSR entry state var"
-;* V41 tmp11        [V41,T03] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
-;* V42 tmp12        [V42,T02] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
-;* V43 tmp13        [V43,T46] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
-;* V44 tmp14        [V44,T00] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
-;* V45 tmp15        [V45,T28] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;* V46 tmp16        [V46,T05] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V47 tmp17        [V47,T01] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
-;* V48 tmp18        [V48,T30] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;* V49 tmp19        [V49,T04] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V50 tmp20        [V50,T38] ( 10,800.88)     int  ->  registers   "Inlining Arg"
-;  V51 tmp21        [V51,T39] (  6,599.16)     ref  ->   r9         class-hnd exact "Inlining Arg" <System.Collections.BitArray>
-;* V52 tmp22        [V52,T51] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V53 tmp23        [V53,T53] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V54 tmp24        [V54,T57] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V55 tmp25        [V55,T58] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;  V56 tmp26        [V56,T40] (  6,599.16)     ref  ->  r11         "arr expr"
+;  V39 tmp9         [V39,T53] (  3,  0.78)     ref  ->  rax         class-hnd exact single-def "Single-def Box Helper" <<unknown class>>
+;* V40 tmp10        [V40,T46] (  0,  0   )     int  ->  zero-ref    "OSR entry state var"
+;* V41 tmp11        [V41,T30] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
+;* V42 tmp12        [V42,T29] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
+;* V43 tmp13        [V43,T55] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
+;* V44 tmp14        [V44,T25] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
+;* V45 tmp15        [V45,T26] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V46 tmp16        [V46,T01] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;* V47 tmp17        [V47,T27] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.BitArray>
+;* V48 tmp18        [V48,T28] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V49 tmp19        [V49,T00] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
+;  V50 tmp20        [V50,T36] ( 10,800.88)     int  ->  registers   "Inlining Arg"
+;  V51 tmp21        [V51,T37] (  6,599.16)     ref  ->   r9         class-hnd exact "Inlining Arg" <System.Collections.BitArray>
+;* V52 tmp22        [V52,T49] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V53 tmp23        [V53,T50] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V54 tmp24        [V54,T51] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V55 tmp25        [V55,T52] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;  V56 tmp26        [V56,T38] (  6,599.16)     ref  ->  rbx         "arr expr"
 ;* V57 tmp27        [V57    ] (  0,  0   )     ref  ->  zero-ref    single-def "arr expr"
 ;* V58 tmp28        [V58    ] (  0,  0   )     int  ->  zero-ref    "index expr"
-;* V59 tmp29        [V59,T13] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V60 tmp30        [V60,T14] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V61 tmp31        [V61,T10] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V62 tmp32        [V62,T11] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V63 tmp33        [V63,T15] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V64 tmp34        [V64,T20] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V65 tmp35        [V65,T18] (  0,  0   )     ref  ->  zero-ref    "arr expr"
-;* V66 tmp36        [V66,T19] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V59 tmp29        [V59,T11] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V60 tmp30        [V60,T12] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V61 tmp31        [V61,T06] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V62 tmp32        [V62,T07] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V63 tmp33        [V63,T13] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V64 tmp34        [V64,T18] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V65 tmp35        [V65,T16] (  0,  0   )     ref  ->  zero-ref    "arr expr"
+;* V66 tmp36        [V66,T17] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V67 tmp37        [V67    ] (  0,  0   )     int  ->  zero-ref    "fgMakeTemp is creating a new local variable"
-;  V68 PSPSym       [V68,T49] (  1,  1   )    long  ->  [rbp-0x10]  do-not-enreg[V] "PSPSym"
-;* V69 cse0         [V69,T52] (  0,  0   )     int  ->  zero-ref    "CSE - conservative"
-;* V70 cse1         [V70    ] (  0,  0   )  double  ->  zero-ref    "CSE - conservative"
-;* V71 cse2         [V71,T56] (  0,  0   )     int  ->  zero-ref    "CSE - conservative"
-;  V72 cse3         [V72,T12] (  4,101.00)     ref  ->  registers   hoist multi-def "CSE - moderate"
-;  V73 cse4         [V73,T45] (  5,101.14)     int  ->  rax         multi-def "CSE - moderate"
-;* V74 cse5         [V74,T27] (  0,  0   )     int  ->  zero-ref    "CSE - moderate"
-;* V75 cse6         [V75,T29] (  0,  0   )     int  ->  zero-ref    "CSE - moderate"
-;* V76 cse7         [V76,T31] (  0,  0   )     int  ->  zero-ref    "CSE - moderate"
-;* V77 cse8         [V77,T32] (  0,  0   )     int  ->  zero-ref    "CSE - moderate"
-;  V78 cse9         [V78,T42] (  3,296.59)     int  ->   r9         "CSE - moderate"
+;  V68 PSPSym       [V68,T47] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
+;  V69 cse0         [V69,T10] (  4,101.00)     ref  ->  registers   hoist multi-def "CSE - moderate"
+;  V70 cse1         [V70,T09] (  4,199.72)     int  ->  r11         multi-def "CSE - moderate"
+;  V71 cse2         [V71,T08] (  4,199.72)     ref  ->  rbx         multi-def "CSE - moderate"
+;  V72 cse3         [V72,T44] (  5,101.14)     int  ->  rax         "CSE - moderate"
+;  V73 cse4         [V73,T41] (  4,199.72)     int  ->  rsi         multi-def "CSE - moderate"
+;  V74 cse5         [V74,T40] (  3,296.59)     int  ->   r9         "CSE - moderate"
+;  V75 cse6         [V75,T56] (  2,  0.26)    long  ->  rcx         "CSE - conservative"
 ;
 ; Lcl frame size = 40
 
 G_M911_IG01:        ; bbWeight=0.77, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        mov      rax, qword ptr [rbp]
        push     rax
-       sub      rsp, 48
+       sub      rsp, 64
+       mov      qword ptr [rsp+0x198], rdi
+       mov      qword ptr [rsp+0x190], rsi
        mov      qword ptr [rsp+0x188], rbx
-       lea      rbp, [rsp+0x30]
-       mov      qword ptr [rbp-0x10], rsp
+       lea      rbp, [rsp+0x40]
+       mov      qword ptr [rbp-0x20], rsp
        mov      rcx, gword ptr [rbp+0x170]
        ; gcrRegs +[rcx]
        mov      rdx, gword ptr [rbp+0x178]
        ; gcrRegs +[rdx]
-						;; size=40 bbWeight=0.77 PerfScore 7.47
+						;; size=56 bbWeight=0.77 PerfScore 9.01
 G_M911_IG02:        ; bbWeight=0.77, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
        jmp      SHORT G_M911_IG05
 						;; size=2 bbWeight=0.77 PerfScore 1.53
@@ -136,24 +135,27 @@ G_M911_IG07:        ; bbWeight=98.86, gcrefRegs=0404 {rdx r10}, byrefRegs=0000 {
        mov      ecx, dword ptr [rdx+4*rcx+0x10]
        mov      r9, r10
        ; gcrRegs +[r9]
-       cmp      ecx, dword ptr [r9+0x10]
+       mov      r11d, dword ptr [r9+0x10]
+       cmp      ecx, r11d
        jae      SHORT G_M911_IG04
-       mov      r11, gword ptr [r9+0x08]
-       ; gcrRegs +[r11]
+       mov      rbx, gword ptr [r9+0x08]
+       ; gcrRegs +[rbx]
        mov      r9d, ecx
        ; gcrRegs -[r9]
        sar      r9d, 5
-       cmp      r9d, dword ptr [r11+0x08]
+       mov      esi, dword ptr [rbx+0x08]
+       cmp      r9d, esi
        jae      SHORT G_M911_IG03
-       mov      r11d, dword ptr [r11+4*r9+0x10]
-       ; gcrRegs -[r11]
-       bt       r11d, ecx
+       mov      r11d, r9d
+       mov      r9d, dword ptr [rbx+4*r11+0x10]
+       bt       r9d, ecx
        jb       SHORT G_M911_IG09
-						;; size=44 bbWeight=98.86 PerfScore 1655.94
+						;; size=52 bbWeight=98.86 PerfScore 1532.36
 G_M911_IG08:        ; bbWeight=98.31, gcrefRegs=0404 {rdx r10}, byrefRegs=0000 {}, byref
-       mov      ebx, dword ptr [rbp+0x108]
-       inc      ebx
-       mov      dword ptr [rbp+0x108], ebx
+       ; gcrRegs -[rbx]
+       mov      edi, dword ptr [rbp+0x108]
+       inc      edi
+       mov      dword ptr [rbp+0x108], edi
 						;; size=14 bbWeight=98.31 PerfScore 221.20
 G_M911_IG09:        ; bbWeight=98.86, gcrefRegs=0404 {rdx r10}, byrefRegs=0000 {}, byref, isz
        inc      r8d
@@ -176,26 +178,28 @@ G_M911_IG12:        ; bbWeight=1.00, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}
        mov      r10d, dword ptr [rdx+4*r10+0x10]
        mov      r9, gword ptr [rcx+0x20]
        ; gcrRegs +[r9]
-       cmp      r10d, dword ptr [r9+0x10]
+       mov      r11d, dword ptr [r9+0x10]
+       cmp      r10d, r11d
        jae      SHORT G_M911_IG11
-       mov      r11, gword ptr [r9+0x08]
-       ; gcrRegs +[r11]
+       mov      rbx, gword ptr [r9+0x08]
+       ; gcrRegs +[rbx]
        mov      r9d, r10d
        ; gcrRegs -[r9]
        sar      r9d, 5
-       cmp      r9d, dword ptr [r11+0x08]
+       mov      esi, dword ptr [rbx+0x08]
+       cmp      r9d, esi
        jae      G_M911_IG03
        mov      r9d, r10d
        sar      r9d, 5
-       mov      r9d, dword ptr [r11+4*r9+0x10]
+       mov      r9d, dword ptr [rbx+4*r9+0x10]
        bt       r9d, r10d
        jb       SHORT G_M911_IG14
-						;; size=62 bbWeight=1.00 PerfScore 20.47
+						;; size=67 bbWeight=1.00 PerfScore 18.97
 G_M911_IG13:        ; bbWeight=0.99, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r11]
-       mov      ebx, dword ptr [rbp+0x108]
-       inc      ebx
-       mov      dword ptr [rbp+0x108], ebx
+       ; gcrRegs -[rbx]
+       mov      edi, dword ptr [rbp+0x108]
+       inc      edi
+       mov      dword ptr [rbp+0x108], edi
 						;; size=14 bbWeight=0.99 PerfScore 2.23
 G_M911_IG14:        ; bbWeight=1.00, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
        inc      r8d
@@ -208,24 +212,28 @@ G_M911_IG15:        ; bbWeight=0.13, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_NEWSFAST
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      ebx, dword ptr [rbp+0x108]
-       mov      dword ptr [rax+0x08], ebx
+       mov      edi, dword ptr [rbp+0x108]
...

```


</div></details>

<details>
<summary><span style="color:red">+22</span> (<span style="color:red">+10.48%</span>) : 619563.dasm - Newtonsoft.Json.Linq.JToken:SetLineInfo(Newtonsoft.Json.IJsonLineInfo,Newtonsoft.Json.Linq.JsonLoadSettings):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -17,11 +17,11 @@
 ;  V05 tmp2         [V05,T05] (  2,  2   )     int  ->  rax         "guarded devirt return temp"
 ;* V06 tmp3         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <Newtonsoft.Json.JsonTextReader>
 ;* V07 tmp4         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <Newtonsoft.Json.JsonTextReader>
-;  V08 tmp5         [V08,T08] (  3,  2   )     int  ->  rbp         "guarded devirt return temp"
+;  V08 tmp5         [V08,T06] (  3,  2   )     int  ->  rbp         "guarded devirt return temp"
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <Newtonsoft.Json.JsonTextReader>
 ;  V10 tmp7         [V10,T01] (  4,  8   )     ref  ->  rax         class-hnd exact single-def "NewObj constructor temp" <Newtonsoft.Json.Linq.JToken+LineInfoAnnotation>
-;  V11 cse0         [V11,T06] (  3,  3   )    long  ->  rdi         "CSE - aggressive"
-;  V12 cse1         [V12,T07] (  3,  3   )    long  ->  rbp         "CSE - aggressive"
+;  V11 cse0         [V11,T07] (  2,  2   )    long  ->  rcx         "CSE - aggressive"
+;  V12 cse1         [V12,T08] (  2,  2   )    long  ->  r11         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
@@ -36,42 +36,30 @@ G_M14583_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        mov      rbx, rdx
        ; gcrRegs +[rbx]
 						;; size=14 bbWeight=1 PerfScore 4.75
-G_M14583_IG02:        ; bbWeight=1, gcrefRegs=0148 {rbx rsi r8}, byrefRegs=0000 {}, byref, isz
+G_M14583_IG02:        ; bbWeight=1, gcrefRegs=0148 {rbx rsi r8}, byrefRegs=0000 {}, byref
        ; gcrRegs +[r8]
        test     r8, r8
-       jne      SHORT G_M14583_IG09
-						;; size=5 bbWeight=1 PerfScore 1.25
+       jne      G_M14583_IG10
+						;; size=9 bbWeight=1 PerfScore 1.25
 G_M14583_IG03:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[r8]
        test     rbx, rbx
-       je       SHORT G_M14583_IG10
-       mov      rdi, qword ptr [rbx]
-       mov      rbp, 0xD1FFAB1E      ; Newtonsoft.Json.JsonTextReader
-       cmp      rdi, rbp
-       je       SHORT G_M14583_IG04
-       mov      rcx, rbx
-       ; gcrRegs +[rcx]
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       ; gcrRegs -[rcx]
-       ; gcr arg pop 0
-       test     eax, eax
-       je       SHORT G_M14583_IG10
-						;; size=43 bbWeight=1 PerfScore 9.50
-G_M14583_IG04:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      rdi, rbp
-       jne      SHORT G_M14583_IG12
+       je       G_M14583_IG11
+       mov      rcx, qword ptr [rbx]
+       mov      r11, 0xD1FFAB1E      ; Newtonsoft.Json.JsonTextReader
+       cmp      rcx, r11
+       jne      SHORT G_M14583_IG08
        cmp      dword ptr [rbx+0x2C], 0
-       je       SHORT G_M14583_IG11
-						;; size=11 bbWeight=1 PerfScore 5.25
-G_M14583_IG05:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+       je       G_M14583_IG12
+						;; size=37 bbWeight=1 PerfScore 8.75
+G_M14583_IG04:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        mov      edi, dword ptr [rbx+0x94]
 						;; size=6 bbWeight=1 PerfScore 2.00
-G_M14583_IG06:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M14583_IG05:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        mov      ebp, dword ptr [rbx+0x8C]
        sub      ebp, dword ptr [rbx+0x90]
 						;; size=12 bbWeight=1 PerfScore 5.00
-G_M14583_IG07:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
+G_M14583_IG06:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx]
        mov      rcx, 0xD1FFAB1E      ; Newtonsoft.Json.Linq.JToken+LineInfoAnnotation
        call     CORINFO_HELP_NEWSFAST
@@ -84,7 +72,7 @@ G_M14583_IG07:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byr
        mov      rdx, rax
        ; gcrRegs +[rdx]
 						;; size=27 bbWeight=1 PerfScore 3.75
-G_M14583_IG08:        ; bbWeight=1, epilog, nogc, extend
+G_M14583_IG07:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rbp
@@ -93,31 +81,18 @@ G_M14583_IG08:        ; bbWeight=1, epilog, nogc, extend
        tail.jmp [<unknown method>]
        ; gcr arg pop 0
 						;; size=14 bbWeight=1 PerfScore 4.25
-G_M14583_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0148 {rbx rsi r8}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs -[rax rcx rdx] +[rbx r8]
-       cmp      dword ptr [r8+0x0C], 1
-       je       SHORT G_M14583_IG03
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M14583_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; gcrRegs -[rbx rsi r8]
-       add      rsp, 40
-       pop      rbx
-       pop      rbp
-       pop      rsi
-       pop      rdi
-       ret      
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M14583_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       mov      ecx, dword ptr [rbx+0x8C]
-       sub      ecx, dword ptr [rbx+0x90]
-       jne      SHORT G_M14583_IG05
-       cmp      dword ptr [rbx+0x28], 5
-       je       SHORT G_M14583_IG05
-       xor      edi, edi
-       jmp      SHORT G_M14583_IG06
-						;; size=24 bbWeight=0 PerfScore 0.00
-G_M14583_IG12:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+G_M14583_IG08:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs -[rax rcx rdx] +[rbx]
+       mov      rcx, rbx
+       ; gcrRegs +[rcx]
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       ; gcrRegs -[rcx]
+       ; gcr arg pop 0
+       test     eax, eax
+       je       SHORT G_M14583_IG11
+						;; size=20 bbWeight=1 PerfScore 4.75
+G_M14583_IG09:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
@@ -132,10 +107,34 @@ G_M14583_IG12:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rcx rbx]
        ; gcr arg pop 0
        mov      ebp, eax
-       jmp      SHORT G_M14583_IG07
+       jmp      SHORT G_M14583_IG06
 						;; size=38 bbWeight=0 PerfScore 0.00
+G_M14583_IG10:        ; bbWeight=0, gcrefRegs=0148 {rbx rsi r8}, byrefRegs=0000 {}, byref
+       ; gcrRegs +[rbx r8]
+       cmp      dword ptr [r8+0x0C], 1
+       je       G_M14583_IG03
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M14583_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rbx rsi r8]
+       add      rsp, 40
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       ret      
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M14583_IG12:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs +[rbx rsi]
+       mov      ecx, dword ptr [rbx+0x8C]
+       sub      ecx, dword ptr [rbx+0x90]
+       jne      G_M14583_IG04
+       cmp      dword ptr [rbx+0x28], 5
+       je       G_M14583_IG04
+       xor      edi, edi
+       jmp      G_M14583_IG05
+						;; size=35 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 210, prolog size 14, PerfScore 35.75, instruction count 63, allocated bytes for code 210 (MethodHash=0f52c708) for method Newtonsoft.Json.Linq.JToken:SetLineInfo(Newtonsoft.Json.IJsonLineInfo,Newtonsoft.Json.Linq.JsonLoadSettings):this (Tier1)
+; Total bytes of code 232, prolog size 14, PerfScore 34.50, instruction count 61, allocated bytes for code 232 (MethodHash=0f52c708) for method Newtonsoft.Json.Linq.JToken:SetLineInfo(Newtonsoft.Json.IJsonLineInfo,Newtonsoft.Json.Linq.JsonLoadSettings):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+14</span> (<span style="color:red">+15.73%</span>) : 187585.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+<>c:<IsGeneratedCode>b__48_1(Microsoft.CodeAnalysis.SyntaxTrivia):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -12,21 +12,21 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+<>c>
 ;  V01 arg1         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T04] (  2,  2   )  ushort  ->  rdx         "Inline return value spill temp"
+;  V03 tmp1         [V03,T04] (  2,  2   )  ushort  ->  rax         "Inline return value spill temp"
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (40) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxTrivia>
 ;* V05 tmp3         [V05    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V06 tmp4         [V06,T02] (  4,  3   )     int  ->  rdx         "Inline return value spill temp"
+;  V06 tmp4         [V06,T02] (  5,  3   )     int  ->  rdx         "Inline return value spill temp"
 ;* V07 tmp5         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.GreenNode>
 ;* V08 tmp6         [V08    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V09 tmp7         [V09,T05] (  2,  2   )  ushort  ->  rcx         "Inline return value spill temp"
+;  V09 tmp7         [V09,T05] (  2,  2   )  ushort  ->  rdx         "Inline return value spill temp"
 ;* V10 tmp8         [V10    ] (  0,  0   )  struct (40) zero-ref    do-not-enreg[SF] ld-addr-op "Inlining Arg" <Microsoft.CodeAnalysis.SyntaxTrivia>
 ;* V11 tmp9         [V11    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V12 tmp10        [V12,T03] (  4,  3   )     int  ->  rdx         "Inline return value spill temp"
+;  V12 tmp10        [V12,T03] (  4,  3   )     int  ->   r8         "Inline return value spill temp"
 ;* V13 tmp11        [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.GreenNode>
 ;* V14 tmp12        [V14    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V15 tmp13        [V15    ] (  0,  0   )     ref  ->  zero-ref    "V04.[000..008)"
 ;* V16 tmp14        [V16    ] (  0,  0   )     ref  ->  zero-ref    "V10.[000..008)"
-;  V17 tmp15        [V17,T01] (  5,  5   )     ref  ->  rcx         single-def "V01.[000..008)"
+;  V17 tmp15        [V17,T01] (  6,  5   )     ref  ->  rcx         single-def "V01.[000..008)"
 ;
 ; Lcl frame size = 0
 
@@ -37,54 +37,61 @@ G_M50897_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        mov      rcx, gword ptr [rdx]
        ; gcrRegs +[rcx]
        test     rcx, rcx
-       je       SHORT G_M50897_IG08
-       movzx    rdx, word  ptr [rcx+0x0C]
-       ; byrRegs -[rdx]
-						;; size=12 bbWeight=1 PerfScore 5.25
-G_M50897_IG03:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
-       lea      eax, [rdx-0x02]
-       movzx    rdx, dx
-       xor      r8d, r8d
-       cmp      eax, 0x1FFE
-       cmovbe   edx, r8d
-       cmp      edx, 0x215D
-       je       SHORT G_M50897_IG06
-       test     rcx, rcx
        je       SHORT G_M50897_IG09
        movzx    rdx, word  ptr [rcx+0x0C]
-						;; size=35 bbWeight=1 PerfScore 6.00
-G_M50897_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
+       ; byrRegs -[rdx]
        lea      eax, [rdx-0x02]
-       movzx    rcx, dx
-       xor      edx, edx
        cmp      eax, 0x1FFE
-       cmovbe   ecx, edx
+       jbe      SHORT G_M50897_IG10
+						;; size=22 bbWeight=1 PerfScore 7.00
+G_M50897_IG03:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       movzx    rax, dx
+       cmp      eax, 0x215D
+       je       SHORT G_M50897_IG07
+       test     rcx, rcx
+       je       SHORT G_M50897_IG11
+						;; size=15 bbWeight=1 PerfScore 2.75
+G_M50897_IG04:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       movzx    r8, word  ptr [rcx+0x0C]
+						;; size=5 bbWeight=1 PerfScore 2.00
+G_M50897_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rcx]
+       lea      eax, [r8-0x02]
+       movzx    rdx, r8w
+       xor      ecx, ecx
+       cmp      eax, 0x1FFE
+       cmovbe   edx, ecx
        xor      eax, eax
-       cmp      ecx, 0x215E
+       cmp      edx, 0x215E
        sete     al
-						;; size=27 bbWeight=1 PerfScore 3.00
-G_M50897_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=29 bbWeight=1 PerfScore 3.00
+G_M50897_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M50897_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M50897_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M50897_IG07:        ; bbWeight=0, epilog, nogc, extend
+G_M50897_IG08:        ; bbWeight=0, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M50897_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M50897_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx]
        xor      edx, edx
-       jmp      SHORT G_M50897_IG03
-						;; size=4 bbWeight=0 PerfScore 0.00
-G_M50897_IG09:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       lea      r8d, [rdx-0x02]
+       cmp      r8d, 0x1FFE
+       ja       SHORT G_M50897_IG03
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M50897_IG10:        ; bbWeight=0, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       test     rcx, rcx
+       jne      SHORT G_M50897_IG04
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M50897_IG11:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rcx]
-       xor      edx, edx
-       jmp      SHORT G_M50897_IG04
-						;; size=4 bbWeight=0 PerfScore 0.00
+       xor      r8d, r8d
+       jmp      SHORT G_M50897_IG05
+						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 89, prolog size 0, PerfScore 15.25, instruction count 29, allocated bytes for code 89 (MethodHash=61ed392e) for method Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+<>c:<IsGeneratedCode>b__48_1(Microsoft.CodeAnalysis.SyntaxTrivia):ubyte:this (Tier1)
+; Total bytes of code 103, prolog size 0, PerfScore 15.75, instruction count 32, allocated bytes for code 103 (MethodHash=61ed392e) for method Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+<>c:<IsGeneratedCode>b__48_1(Microsoft.CodeAnalysis.SyntaxTrivia):ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-46</span> (<span style="color:green">-50.00%</span>) : 222381.dasm - System.Runtime.Tests.DependentHandleTests+<>c:<SetTarget_NotNullObject_ThrowsInvalidOperationException>b__14_0():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,60 +14,39 @@
 ;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "NewObj constructor temp" <System.Object>
 ;* V04 tmp2         [V04    ] (  0,  0   )    long  ->  zero-ref    single-def "Inline stloc first use temp"
 ;* V05 tmp3         [V05    ] (  0,  0   )    long  ->  zero-ref    single-def "Inline stloc first use temp"
-;  V06 tmp4         [V06,T01] (  2,  0   )    long  ->  [rbp-0x08]  EH-live single-def "field V01._handle (fldOffset=0x0)" P-INDEP
+;* V06 tmp4         [V06,T01] (  0,  0   )    long  ->  zero-ref    EH-live single-def "field V01._handle (fldOffset=0x0)" P-INDEP
 ;  V07 PSPSym       [V07,T00] (  1,  1   )    long  ->  [rbp-0x10]  do-not-enreg[V] "PSPSym"
 ;
 ; Lcl frame size = 48
 
-G_M46431_IG01:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+G_M46431_IG01:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbp
        sub      rsp, 48
        lea      rbp, [rsp+0x30]
        mov      qword ptr [rbp-0x10], rsp
 						;; size=14 bbWeight=0 PerfScore 0.00
 G_M46431_IG02:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-       mov      qword ptr [rbp-0x08], rax
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M46431_IG03:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     [System.ThrowHelper:ThrowInvalidOperationException()]
        ; gcr arg pop 0
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M46431_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M46431_IG03:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        int3     
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M46431_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet prolog, nogc
+G_M46431_IG04:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet prolog, nogc
        push     rbp
        sub      rsp, 48
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x30]
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M46431_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       cmp      qword ptr [rbp-0x08], 0
-       je       SHORT G_M46431_IG07
-       xor      ecx, ecx
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcr arg pop 0
-       test     eax, eax
-       jne      SHORT G_M46431_IG07
-       xor      ecx, ecx
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcr arg pop 0
-						;; size=39 bbWeight=0 PerfScore 0.00
-G_M46431_IG07:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       nop      
-						;; size=1 bbWeight=0 PerfScore 0.00
-G_M46431_IG08:        ; bbWeight=0, funclet epilog, nogc, extend
+G_M46431_IG05:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, funclet epilog, nogc
        add      rsp, 48
        pop      rbp
        ret      
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 92, prolog size 14, PerfScore 0.00, instruction count 28, allocated bytes for code 92 (MethodHash=d45c4aa0) for method System.Runtime.Tests.DependentHandleTests+<>c:<SetTarget_NotNullObject_ThrowsInvalidOperationException>b__14_0():this (FullOpts)
+; Total bytes of code 46, prolog size 14, PerfScore 0.00, instruction count 15, allocated bytes for code 46 (MethodHash=d45c4aa0) for method System.Runtime.Tests.DependentHandleTests+<>c:<SetTarget_NotNullObject_ThrowsInvalidOperationException>b__14_0():this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -96,4 +75,4 @@ Unwind Info:
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
 *************** EH table for System.Runtime.Tests.DependentHandleTests+<>c:<SetTarget_NotNullObject_ThrowsInvalidOperationException>b__14_0():this
 1 EH table entries, 0 duplicate clauses, 0 cloned finallys, 1 total EH entries reported to VM
-EH#0: try [G_M46431_IG03..G_M46431_IG04) handled by [G_M46431_IG05..END) (fault)
+EH#0: try [G_M46431_IG02..G_M46431_IG03) handled by [G_M46431_IG04..END) (fault)

```


</div></details>

<details>
<summary><span style="color:green">-34</span> (<span style="color:green">-49.28%</span>) : 248203.dasm - System.Text.Json.Serialization.Converters.NullableConverter`1[ulong]:WriteNumberWithCustomHandling(System.Text.Json.Utf8JsonWriter,System.Nullable`1[ulong],int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,26 +12,22 @@
 ;  V01 arg1         [V01,T01] (  4,  3   )     ref  ->  rdx         class-hnd single-def <System.Text.Json.Utf8JsonWriter>
 ;  V02 arg2         [V02,T00] (  4,  7   )   byref  ->   r8         ld-addr-op single-def
 ;  V03 arg3         [V03,T03] (  3,  2.50)     int  ->   r9         single-def
-;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T04] (  3,  3   )     ref  ->  rcx         class-hnd single-def "impAppendStmt" <<unknown class>>
 ;* V06 tmp2         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "field V02.hasValue (fldOffset=0x0)" P-INDEP
 ;* V07 tmp3         [V07    ] (  0,  0   )    long  ->  zero-ref    "field V02.value (fldOffset=0x8)" P-INDEP
 ;* V08 tmp4         [V08    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Nullable`1[ulong]>
-;  V09 cse0         [V09,T05] (  3,  2.50)     int  ->  rbx         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 0
 
-G_M29328_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+G_M29328_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+						;; size=0 bbWeight=1 PerfScore 0.00
 G_M29328_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0100 {r8}, byref, isz
        ; gcrRegs +[rcx rdx]
        ; byrRegs +[r8]
-       movzx    rbx, byte  ptr [r8]
-       test     ebx, ebx
+       cmp      byte  ptr [r8], 0
        jne      SHORT G_M29328_IG05
-						;; size=8 bbWeight=1 PerfScore 3.25
+						;; size=6 bbWeight=1 PerfScore 4.00
 G_M29328_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rcx]
        ; byrRegs -[r8]
@@ -40,35 +36,22 @@ G_M29328_IG03:        ; bbWeight=0.50, gcrefRegs=0004 {rdx}, byrefRegs=0000 {},
        cmp      dword ptr [rcx], ecx
 						;; size=5 bbWeight=0.50 PerfScore 1.62
 G_M29328_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
        tail.jmp [System.Text.Json.Utf8JsonWriter:WriteNullValue():this]
        ; gcr arg pop 0
-						;; size=11 bbWeight=0.50 PerfScore 1.38
-G_M29328_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0100 {r8}, gcvars, byref, isz
+						;; size=6 bbWeight=0.50 PerfScore 1.00
+G_M29328_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0100 {r8}, gcvars, byref
        ; byrRegs +[r8]
        mov      rcx, gword ptr [rcx+0x30]
-       test     ebx, ebx
-       je       SHORT G_M29328_IG07
        mov      r8, qword ptr [r8+0x08]
        ; byrRegs -[r8]
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x70]
-						;; size=19 bbWeight=0.50 PerfScore 4.62
+						;; size=15 bbWeight=0.50 PerfScore 4.00
 G_M29328_IG06:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
        tail.jmp [rax]<unknown method>
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M29328_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rcx rdx]
-       mov      rax, 0xD1FFAB1E      ; code for System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()
-       call     [rax]System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_NoValue()
-       ; gcr arg pop 0
-       int3     
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=3 bbWeight=0.50 PerfScore 1.00
 
-; Total bytes of code 69, prolog size 5, PerfScore 13.50, instruction count 22, allocated bytes for code 69 (MethodHash=038b8d6f) for method System.Text.Json.Serialization.Converters.NullableConverter`1[ulong]:WriteNumberWithCustomHandling(System.Text.Json.Utf8JsonWriter,System.Nullable`1[ulong],int):this (FullOpts)
+; Total bytes of code 35, prolog size 0, PerfScore 11.62, instruction count 10, allocated bytes for code 35 (MethodHash=038b8d6f) for method System.Text.Json.Serialization.Converters.NullableConverter`1[ulong]:WriteNumberWithCustomHandling(System.Text.Json.Utf8JsonWriter,System.Nullable`1[ulong],int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -76,10 +59,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-26</span> (<span style="color:green">-49.06%</span>) : 109786.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.classes.abstract003.abstract003.Test:MainMethod(System.String[]):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -14,38 +14,24 @@
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.classes.abstract003.abstract003.Derived>
 ;* V05 tmp2         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Single-def Box Helper" <<unknown class>>
-;  V06 cse0         [V06,T00] (  5,  4   )    long  ->  rcx         "CSE - aggressive"
+;  V06 cse0         [V06,T00] (  2,  2   )    long  ->  rax         "CSE - aggressive"
 ;
 ; Lcl frame size = 40
 
-G_M35937_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+G_M35937_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M35937_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      dword ptr [rcx], 1
-       cmp      dword ptr [rcx], 1
-       je       SHORT G_M35937_IG05
-						;; size=21 bbWeight=1 PerfScore 5.25
-G_M35937_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, 1
-						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M35937_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 40
-       ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M35937_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      dword ptr [rcx], 2
-       cmp      dword ptr [rcx], 2
-       jne      SHORT G_M35937_IG03
+G_M35937_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+       mov      dword ptr [rax], 2
        xor      eax, eax
-						;; size=13 bbWeight=0.50 PerfScore 2.62
-G_M35937_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+						;; size=18 bbWeight=1 PerfScore 1.50
+G_M35937_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
-						;; size=5 bbWeight=0.50 PerfScore 0.62
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 53, prolog size 4, PerfScore 9.50, instruction count 14, allocated bytes for code 53 (MethodHash=e66b739e) for method ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.classes.abstract003.abstract003.Test:MainMethod(System.String[]):int (FullOpts)
+; Total bytes of code 27, prolog size 4, PerfScore 3.00, instruction count 6, allocated bytes for code 27 (MethodHash=e66b739e) for method ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.classes.abstract003.abstract003.Test:MainMethod(System.String[]):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+34</span> (<span style="color:red">+6.14%</span>) : 231805.dasm - System.Security.Cryptography.Pkcs.Tests.TimestampTokenTests:ParseDocument_ExcessData(System.String) (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 arg0         [V00,T08] (  3,  3   )     ref  ->  rcx         class-hnd single-def <System.String>
 ;  V01 loc0         [V01,T07] (  5,  5   )     ref  ->  rbx         class-hnd exact single-def <System.Security.Cryptography.Pkcs.Tests.TimestampTokenTestData>
-;  V02 loc1         [V02,T04] (  6,  6   )     int  ->  rdi         single-def
-;  V03 loc2         [V03,T00] ( 12,  9.50)     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
+;  V02 loc1         [V02,T03] (  6,  6   )     int  ->  rdi         single-def
+;  V03 loc2         [V03,T00] ( 10,  8   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
 ;* V04 loc3         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlyMemory`1[ubyte]>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Memory`1[ubyte]>
@@ -22,8 +22,8 @@
 ;* V11 tmp6         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Memory`1[ubyte]>
 ;* V12 tmp7         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[ubyte]>
 ;* V13 tmp8         [V13    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
-;  V14 tmp9         [V14,T13] (  7,  3.75)   byref  ->  r12         "Inline stloc first use temp"
-;  V15 tmp10        [V15,T03] (  8,  6   )     int  ->  [rsp+0x64]  "Inline stloc first use temp"
+;  V14 tmp9         [V14,T13] (  7,  3.75)   byref  ->  [rsp+0x20]  "Inline stloc first use temp"
+;  V15 tmp10        [V15,T02] (  8,  6   )     int  ->  [rsp+0x64]  "Inline stloc first use temp"
 ;* V16 tmp11        [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.Object>
 ;* V17 tmp12        [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V18 tmp13        [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <<unknown class>>
@@ -60,7 +60,7 @@
 ;* V49 tmp44        [V49    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;  V50 tmp45        [V50,T09] (  3,  5   )    long  ->   r8         "Inlining Arg"
 ;* V51 tmp46        [V51    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlyMemory`1[ubyte]>
-;  V52 tmp47        [V52,T06] (  9,  5.50)     ref  ->  r14         single-def "field V04._object (fldOffset=0x0)" P-INDEP
+;  V52 tmp47        [V52,T05] (  9,  5.50)     ref  ->  r14         single-def "field V04._object (fldOffset=0x0)" P-INDEP
 ;  V53 tmp48        [V53,T24] (  2,  1.50)     int  ->  r15         single-def "field V04._index (fldOffset=0x8)" P-INDEP
 ;  V54 tmp49        [V54,T14] (  4,  3   )     int  ->  rsi         "field V04._length (fldOffset=0xc)" P-INDEP
 ;* V55 tmp50        [V55    ] (  0,  0   )     ref  ->  zero-ref    "field V06._object (fldOffset=0x0)" P-INDEP
@@ -73,7 +73,7 @@
 ;* V62 tmp57        [V62    ] (  0,  0   )     int  ->  zero-ref    single-def "field V08._length (fldOffset=0xc)" P-INDEP
 ;  V63 tmp58        [V63,T18] (  2,  2   )     ref  ->  rdx         "field V09._object (fldOffset=0x0)" P-INDEP
 ;* V64 tmp59        [V64    ] (  0,  0   )     int  ->  zero-ref    "field V09._index (fldOffset=0x8)" P-INDEP
-;  V65 tmp60        [V65,T16] (  3,  2.50)     int  ->  r13         "field V09._length (fldOffset=0xc)" P-INDEP
+;  V65 tmp60        [V65,T16] (  3,  2.50)     int  ->  r12         "field V09._length (fldOffset=0xc)" P-INDEP
 ;* V66 tmp61        [V66    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V10._reference (fldOffset=0x0)" P-INDEP
 ;* V67 tmp62        [V67    ] (  0,  0   )     int  ->  zero-ref    single-def "field V10._length (fldOffset=0x8)" P-INDEP
 ;* V68 tmp63        [V68    ] (  0,  0   )     ref  ->  zero-ref    single-def "field V11._object (fldOffset=0x0)" P-INDEP
@@ -87,7 +87,7 @@
 ;* V76 tmp71        [V76    ] (  0,  0   )     int  ->  zero-ref    single-def "field V17._length (fldOffset=0x8)" P-INDEP
 ;  V77 tmp72        [V77    ] (  2,  1   )   byref  ->  [rsp+0x50]  do-not-enreg[X] addr-exposed "field V19._reference (fldOffset=0x0)" P-DEP
 ;  V78 tmp73        [V78    ] (  2,  1   )     int  ->  [rsp+0x58]  do-not-enreg[X] addr-exposed "field V19._length (fldOffset=0x8)" P-DEP
-;  V79 tmp74        [V79,T25] (  2,  1   )   byref  ->  r12         single-def "field V27._reference (fldOffset=0x0)" P-INDEP
+;  V79 tmp74        [V79,T25] (  2,  1   )   byref  ->  rax         single-def "field V27._reference (fldOffset=0x0)" P-INDEP
 ;* V80 tmp75        [V80    ] (  0,  0   )     int  ->  zero-ref    "field V27._length (fldOffset=0x8)" P-INDEP
 ;* V81 tmp76        [V81    ] (  0,  0   )   byref  ->  zero-ref    "field V30._reference (fldOffset=0x0)" P-INDEP
 ;* V82 tmp77        [V82    ] (  0,  0   )     int  ->  zero-ref    "field V30._length (fldOffset=0x8)" P-INDEP
@@ -101,12 +101,12 @@
 ;* V90 tmp85        [V90    ] (  0,  0   )     int  ->  zero-ref    single-def "field V47._length (fldOffset=0x8)" P-INDEP
 ;  V91 tmp86        [V91,T19] (  2,  2   )     ref  ->  rbp         single-def "field V51._object (fldOffset=0x0)" P-INDEP
 ;* V92 tmp87        [V92,T28] (  0,  0   )     int  ->  zero-ref    single-def "field V51._index (fldOffset=0x8)" P-INDEP
-;  V93 tmp88        [V93,T21] (  2,  2   )     int  ->  rcx         single-def "field V51._length (fldOffset=0xc)" P-INDEP
+;  V93 tmp88        [V93,T21] (  2,  2   )     int  ->  r13         single-def "field V51._length (fldOffset=0xc)" P-INDEP
 ;  V94 tmp89        [V94    ] (  4,  8   )  struct (16) [rsp+0x30]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlyMemory`1[ubyte]>
-;  V95 tmp90        [V95,T05] (  3,  6   )  struct ( 8) [rsp+0x28]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[int]>
+;  V95 tmp90        [V95,T04] (  3,  6   )  struct ( 8) [rsp+0x28]  do-not-enreg[SF] "by-value struct argument" <System.Nullable`1[int]>
 ;  V96 cse0         [V96,T22] (  2,  2   )     int  ->  rsi         "CSE - moderate"
-;  V97 cse1         [V97,T02] ( 12,  6   )     ref  ->  rdx         multi-def "CSE - aggressive"
-;  V98 cse2         [V98,T01] (  8,  7   )     int  ->  registers   multi-def "CSE - aggressive"
+;  V97 cse1         [V97,T06] (  6,  5.50)     int  ->  r13         "CSE - aggressive"
+;  V98 cse2         [V98,T01] ( 12,  6   )     ref  ->  rdx         multi-def "CSE - aggressive"
 ;  V99 cse3         [V99,T15] (  3,  3   )     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 104
@@ -147,16 +147,17 @@ G_M52004_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        mov      rdx, rbp
        ; gcrRegs +[rdx]
        mov      r13d, dword ptr [rdx+0x08]
-       xor      r12, r12
-       ; byrRegs +[r12]
-       xor      eax, eax
+       mov      r12d, r13d
+       xor      rax, rax
        ; gcrRegs -[rax]
+       ; byrRegs +[rax]
+       xor      r8d, r8d
        test     r14, r14
        je       G_M52004_IG08
-						;; size=67 bbWeight=1 PerfScore 15.75
+						;; size=70 bbWeight=1 PerfScore 16.00
 G_M52004_IG03:        ; bbWeight=0.50, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rdx]
-       ; byrRegs -[r12]
+       ; byrRegs -[rax]
        mov      rdx, qword ptr [r14]
        test     dword ptr [rdx], 0xD1FFAB1E
        je       SHORT G_M52004_IG05
@@ -177,16 +178,16 @@ G_M52004_IG03:        ; bbWeight=0.50, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0
        ; gcr arg pop 0
 						;; size=53 bbWeight=0.50 PerfScore 6.12
 G_M52004_IG04:        ; bbWeight=0.50, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref, isz
-       lea      r12, bword ptr [r14+0x10]
-       ; byrRegs +[r12]
-       mov      eax, dword ptr [r14+0x08]
-       mov      r14d, eax
+       lea      rax, bword ptr [r14+0x10]
+       ; byrRegs +[rax]
+       mov      r8d, dword ptr [r14+0x08]
+       mov      r14d, r8d
        ; gcrRegs -[r14]
        jmp      SHORT G_M52004_IG07
 						;; size=13 bbWeight=0.50 PerfScore 2.38
 G_M52004_IG05:        ; bbWeight=0.50, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[r14]
-       ; byrRegs -[r12]
+       ; byrRegs -[rax]
        mov      rdx, r14
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
@@ -212,62 +213,86 @@ G_M52004_IG06:        ; bbWeight=0.50, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0
        call     [rax+0x28]<unknown method>
        ; gcrRegs -[rcx r14]
        ; gcr arg pop 0
-       mov      r12, bword ptr [rsp+0x50]
-       ; byrRegs +[r12]
-       mov      r14d, dword ptr [rsp+0x58]
-						;; size=28 bbWeight=0.50 PerfScore 4.88
-G_M52004_IG07:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref
+       mov      rax, bword ptr [rsp+0x50]
+       ; byrRegs +[rax]
+       mov      r14, rax
+       ; byrRegs +[r14]
+       mov      ecx, dword ptr [rsp+0x58]
+       mov      eax, ecx
+       ; byrRegs -[rax]
+       mov      ecx, eax
+       mov      rax, r14
+       ; byrRegs +[rax]
+       mov      r14d, ecx
+       ; byrRegs -[r14]
+						;; size=40 bbWeight=0.50 PerfScore 5.50
+G_M52004_IG07:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=0001 {rax}, byref
        and      r15d, 0xD1FFAB1E
        mov      ecx, r15d
        mov      edx, esi
        add      rdx, rcx
-       mov      eax, r14d
-       cmp      rdx, rax
+       mov      r8d, r14d
+       cmp      rdx, r8
        ja       G_M52004_IG22
-       add      r12, rcx
+       add      rax, rcx
+       mov      bword ptr [rsp+0x20], rax
+       ; GC ptr vars +{V14}
        mov      r14d, esi
-       mov      eax, r14d
-						;; size=36 bbWeight=0.50 PerfScore 1.62
-G_M52004_IG08:        ; bbWeight=1, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref, isz
-       mov      dword ptr [rsp+0x64], eax
-       test     eax, eax
+       mov      r8d, r14d
+       mov      rax, bword ptr [rsp+0x20]
+						;; size=46 bbWeight=0.50 PerfScore 2.62
+G_M52004_IG08:        ; bbWeight=1, gcrefRegs=0028 {rbx rbp}, byrefRegs=0001 {rax}, byref, isz
+       ; GC ptr vars -{V14}
+       mov      dword ptr [rsp+0x64], r8d
+       test     r8d, r8d
        jge      SHORT G_M52004_IG10
-						;; size=8 bbWeight=1 PerfScore 2.25
-G_M52004_IG09:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref
+						;; size=10 bbWeight=1 PerfScore 2.25
+G_M52004_IG09:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=0001 {rax}, byref
+       mov      bword ptr [rsp+0x20], rax
+       ; GC ptr vars +{V14}
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        mov      rcx, rdx
        ; gcrRegs +[rcx]
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
+       ; byrRegs -[rax]
        ; gcr arg pop 0
-						;; size=19 bbWeight=0.50 PerfScore 1.75
-G_M52004_IG10:        ; bbWeight=1, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref, isz
+       mov      rax, bword ptr [rsp+0x20]
+       ; byrRegs +[rax]
+						;; size=29 bbWeight=0.50 PerfScore 2.75
+G_M52004_IG10:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0028 {rbx rbp}, byrefRegs=0001 {rax}, gcvars, byref, isz
+       ; GC ptr vars -{V14}
        mov      rdx, qword ptr [rbp]
        test     dword ptr [rdx], 0xD1FFAB1E
        jne      SHORT G_M52004_IG12
 						;; size=12 bbWeight=1 PerfScore 6.00
-G_M52004_IG11:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref, isz
+G_M52004_IG11:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=0001 {rax}, byref, isz
+       mov      bword ptr [rsp+0x20], rax
+       ; GC ptr vars +{V14}
        mov      rdx, rbp
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFCLASS
        ; gcrRegs -[rdx] +[rax]
+       ; byrRegs -[rax]
        ; gcr arg pop 0
        test     rax, rax
        jne      SHORT G_M52004_IG14
        jmp      SHORT G_M52004_IG13
-						;; size=25 bbWeight=0.50 PerfScore 2.38
-G_M52004_IG12:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref, isz
+						;; size=30 bbWeight=0.50 PerfScore 2.88
+G_M52004_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0028 {rbx rbp}, byrefRegs=0001 {rax}, gcvars, byref, isz
        ; gcrRegs -[rax]
+       ; byrRegs +[rax]
+       ; GC ptr vars -{V14}
        lea      rcx, bword ptr [rbp+0x10]
        ; byrRegs +[rcx]
-       mov      edx, dword ptr [rbp+0x08]
-       mov      esi, edx
+       mov      esi, r13d
        jmp      SHORT G_M52004_IG15
-						;; size=11 bbWeight=0.50 PerfScore 2.38
-G_M52004_IG13:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref
-       ; byrRegs -[rcx]
+						;; size=9 bbWeight=0.50 PerfScore 1.38
+G_M52004_IG13:        ; bbWeight=0.50, gcVars=0000000000002000 {V14}, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, gcvars, byref
+       ; byrRegs -[rax rcx]
+       ; GC ptr vars +{V14}
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        mov      rcx, rdx
@@ -276,7 +301,7 @@ G_M52004_IG13:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
 						;; size=19 bbWeight=0.50 PerfScore 1.75
-G_M52004_IG14:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000 {r12}, byref
+G_M52004_IG14:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref
        lea      rdx, [rsp+0x40]
        mov      rcx, rbp
        ; gcrRegs +[rcx]
@@ -288,42 +313,42 @@ G_M52004_IG14:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1000
        mov      rcx, bword ptr [rsp+0x40]
        ; byrRegs +[rcx]
        mov      esi, dword ptr [rsp+0x48]
-						;; size=28 bbWeight=0.50 PerfScore 4.88
-G_M52004_IG15:        ; bbWeight=0.50, gcrefRegs=0028 {rbx rbp}, byrefRegs=1002 {rcx r12}, byref
-       cmp      r13d, esi
+       mov      rax, bword ptr [rsp+0x20]
+       ; byrRegs +[rax]
+						;; size=33 bbWeight=0.50 PerfScore 5.38
+G_M52004_IG15:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0028 {rbx rbp}, byrefRegs=0003 {rax rcx}, gcvars, byref
+       ; GC ptr vars -{V14}
+       cmp      r12d, esi
        ja       G_M52004_IG22
 						;; size=9 bbWeight=0.50 PerfScore 0.62
-G_M52004_IG16:        ; bbWeight=1, gcrefRegs=0028 {rbx rbp}, byrefRegs=1002 {rcx r12}, byref, isz
-       mov      esi, r13d
-       mov      eax, dword ptr [rsp+0x64]
...

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+8.57%</span>) : 25305.dasm - Microsoft.CSharp.RuntimeBinder.RuntimeBinderExtensions:IsEquivalentTo(System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,13 +7,13 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  7,  5   )     ref  ->  rbx         class-hnd single-def <System.Reflection.ParameterInfo>
-;  V01 arg1         [V01,T01] (  7,  4.50)     ref  ->  rsi         class-hnd single-def <System.Reflection.ParameterInfo>
+;  V00 arg0         [V00,T01] (  6,  4.50)     ref  ->  rsi         class-hnd single-def <System.Reflection.ParameterInfo>
+;  V01 arg1         [V01,T00] (  7,  4.50)     ref  ->  rbx         class-hnd single-def <System.Reflection.ParameterInfo>
 ;  V02 arg2         [V02,T02] (  3,  2.50)     ref  ->  rdi         class-hnd single-def <System.Reflection.MethodBase>
 ;  V03 arg3         [V03,T03] (  3,  2.50)     ref  ->  rbp         class-hnd single-def <System.Reflection.MethodBase>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "non-inline candidate call" <<unknown class>>
-;  V06 tmp2         [V06,T04] (  2,  2   )     ref  ->  rbx         single-def "argument with side effect"
+;  V06 tmp2         [V06,T04] (  2,  2   )     ref  ->  rsi         single-def "argument with side effect"
 ;  V07 tmp3         [V07,T05] (  2,  2   )     ref  ->  rdx         single-def "argument with side effect"
 ;  V08 cse0         [V08,T06] (  3,  1.50)    long  ->  r14         "CSE - moderate"
 ;
@@ -26,31 +26,25 @@ G_M51566_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        push     rbp
        push     rbx
        sub      rsp, 32
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-       mov      rsi, rdx
+       mov      rsi, rcx
        ; gcrRegs +[rsi]
+       mov      rbx, rdx
+       ; gcrRegs +[rbx]
        mov      rdi, r8
        ; gcrRegs +[rdi]
        mov      rbp, r9
        ; gcrRegs +[rbp]
 						;; size=22 bbWeight=1 PerfScore 6.25
 G_M51566_IG02:        ; bbWeight=1, gcrefRegs=00E8 {rbx rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       test     rbx, rbx
-       je       SHORT G_M51566_IG04
+       test     rsi, rsi
+       je       SHORT G_M51566_IG05
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M51566_IG03:        ; bbWeight=0.50, gcrefRegs=00E8 {rbx rbp rsi rdi}, byrefRegs=0000 {}, byref, isz
-       test     rsi, rsi
-       jne      SHORT G_M51566_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M51566_IG04:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbp rdi]
-       or       rbx, rsi
-       ; gcrRegs -[rbx]
-       sete     al
-       movzx    rax, al
-						;; size=9 bbWeight=0.50 PerfScore 0.75
-G_M51566_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       test     rbx, rbx
+       jne      SHORT G_M51566_IG07
+       xor      eax, eax
+						;; size=7 bbWeight=0.50 PerfScore 0.75
+G_M51566_IG04:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rbp
@@ -59,22 +53,37 @@ G_M51566_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        pop      r14
        ret      
 						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M51566_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=00E8 {rbx rbp rsi rdi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rbp rdi]
-       mov      rcx, rbx
+G_M51566_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs -[rbp rsi rdi]
+       xor      eax, eax
+       test     rbx, rbx
+       sete     al
+						;; size=8 bbWeight=0.50 PerfScore 0.75
+G_M51566_IG06:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 32
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       pop      r14
+       ret      
+						;; size=11 bbWeight=0.50 PerfScore 1.88
+G_M51566_IG07:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=00E8 {rbx rbp rsi rdi}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rbp rsi rdi]
+       mov      rcx, rsi
        ; gcrRegs +[rcx]
-       mov      rdx, rsi
+       mov      rdx, rbx
        ; gcrRegs +[rdx]
-       mov      rax, qword ptr [rbx]
+       mov      rax, qword ptr [rsi]
        mov      r14, qword ptr [rax+0x48]
        call     [r14+0x10]<unknown method>
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
        test     eax, eax
-       je       SHORT G_M51566_IG08
+       je       SHORT G_M51566_IG09
        mov      eax, 1
 						;; size=26 bbWeight=0.50 PerfScore 4.50
-G_M51566_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M51566_IG08:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rbp
@@ -83,32 +92,32 @@ G_M51566_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        pop      r14
        ret      
 						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M51566_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=00E8 {rbx rbp rsi rdi}, byrefRegs=0000 {}, gcvars, byref
-       mov      rcx, rbx
-       ; gcrRegs +[rcx]
-       call     [r14+0x38]<unknown method>
-       ; gcrRegs -[rcx rbx] +[rax]
-       ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
+G_M51566_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=00E8 {rbx rbp rsi rdi}, byrefRegs=0000 {}, gcvars, byref
        mov      rcx, rsi
        ; gcrRegs +[rcx]
-       mov      rax, qword ptr [rsi]
+       call     [r14+0x38]<unknown method>
+       ; gcrRegs -[rcx rsi] +[rax]
+       ; gcr arg pop 0
+       mov      rsi, rax
+       ; gcrRegs +[rsi]
+       mov      rcx, rbx
+       ; gcrRegs +[rcx]
+       mov      rax, qword ptr [rbx]
        ; gcrRegs -[rax]
        mov      rax, qword ptr [rax+0x48]
        call     [rax+0x38]<unknown method>
-       ; gcrRegs -[rcx rsi] +[rax]
+       ; gcrRegs -[rcx rbx] +[rax]
        ; gcr arg pop 0
        mov      rdx, rax
        ; gcrRegs +[rdx]
-       mov      rcx, rbx
+       mov      rcx, rsi
        ; gcrRegs +[rcx]
        mov      r8, rdi
        ; gcrRegs +[r8]
        mov      r9, rbp
        ; gcrRegs +[r9]
 						;; size=35 bbWeight=0.50 PerfScore 5.88
-G_M51566_IG09:        ; bbWeight=0.50, epilog, nogc, extend
+G_M51566_IG10:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rbp
@@ -119,7 +128,7 @@ G_M51566_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        ; gcr arg pop 0
 						;; size=16 bbWeight=0.50 PerfScore 2.38
 
-; Total bytes of code 140, prolog size 10, PerfScore 25.38, instruction count 57, allocated bytes for code 140 (MethodHash=2a693691) for method Microsoft.CSharp.RuntimeBinder.RuntimeBinderExtensions:IsEquivalentTo(System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)
+; Total bytes of code 152, prolog size 10, PerfScore 27.38, instruction count 65, allocated bytes for code 152 (MethodHash=2a693691) for method Microsoft.CSharp.RuntimeBinder.RuntimeBinderExtensions:IsEquivalentTo(System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+13.79%</span>) : 5997.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,14 +7,14 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  6,  6   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  6,  6   )     int  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  5,  4   )     int  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  5,  4   )     int  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  registers  
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V07 tmp4         [V07,T02] (  3,  2   )     int  ->  rcx        
+;  V07 tmp4         [V07,T02] (  4,  2   )     int  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,30 +22,41 @@ G_M19887_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M19887_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ecx, edx
-       mov      eax, ecx
-       cmovg    eax, edx
-       cmovle   ecx, edx
-       cmp      eax, 3
-       jne      SHORT G_M19887_IG04
-						;; size=15 bbWeight=1 PerfScore 2.25
+       jg       SHORT G_M19887_IG04
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19887_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, 4
-       je       SHORT G_M19887_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jmp      SHORT G_M19887_IG05
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M19887_IG06
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, edx
+       jmp      SHORT G_M19887_IG07
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M19887_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, ecx
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       mov      ecx, edx
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M19887_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      ecx, 3
+       jne      SHORT G_M19887_IG09
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M19887_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      eax, 4
+       je       SHORT G_M19887_IG10
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M19887_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M19887_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M19887_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 5
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M19887_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 29, prolog size 0, PerfScore 4.12, instruction count 12, allocated bytes for code 29 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
+; Total bytes of code 33, prolog size 0, PerfScore 7.62, instruction count 15, allocated bytes for code 33 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-59.49%</span>) : 61.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M8984_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M8984_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M8984_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M8984_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M8984_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M8984_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M8984_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M8984_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 48
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M8984_IG06
-						;; size=18 bbWeight=0.50 PerfScore 2.88
-G_M8984_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M8984_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=16 bbWeight=0.50 PerfScore 1.88
+G_M8984_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M8984_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M8984_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 79, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 79 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
+; Total bytes of code 32, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 32 (MethodHash=47acdce7) for method System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-58.02%</span>) : 296.dasm - System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M50337_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M50337_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M50337_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M50337_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M50337_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M50337_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M50337_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M50337_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M50337_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M50337_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M50337_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 0xD1FFAB1E
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M50337_IG06
-						;; size=20 bbWeight=0.50 PerfScore 2.88
-G_M50337_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M50337_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=18 bbWeight=0.50 PerfScore 1.88
+G_M50337_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M50337_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M50337_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 81, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 81 (MethodHash=6f1a3b5e) for method System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 34 (MethodHash=6f1a3b5e) for method System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:green">-47</span> (<span style="color:green">-58.02%</span>) : 297.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,69 +8,47 @@
 ; 0 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.RuntimeType>
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.RuntimeType>
 ;* V01 loc0         [V01    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Runtime.CompilerServices.TypeHandle>
-;  V02 loc1         [V02,T05] (  2,  2   )   ubyte  ->  rax        
-;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  rax        
+;  V02 loc1         [V02,T04] (  2,  2   )   ubyte  ->  rax        
+;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V04 tmp1         [V04,T02] (  3,  2   )     int  ->  rax        
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Runtime.CompilerServices.TypeHandle>
 ;* V06 tmp3         [V06    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp5         [V08,T04] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
+;  V08 tmp5         [V08,T03] (  2,  2   )   byref  ->  rax         single-def "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )    long  ->  zero-ref    "field V01.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rsi         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
-;  V11 cse0         [V11,T06] (  3,  1.50)     ref  ->  rdx         "CSE - moderate"
-;  V12 cse1         [V12,T02] (  3,  2.50)     int  ->  rcx         "CSE - aggressive"
+;  V10 tmp7         [V10,T01] (  3,  2.50)    long  ->  rax         "field V05.m_asTAddr (fldOffset=0x0)" P-INDEP
 ;
-; Lcl frame size = 40
+; Lcl frame size = 0
 
 G_M23673_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rsi
-       push     rbx
-       sub      rsp, 40
-       mov      rbx, rcx
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=1 PerfScore 2.50
-G_M23673_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      rsi, qword ptr [rbx+0x18]
-       mov      ecx, esi
-       and      ecx, 2
-       jne      SHORT G_M23673_IG05
-						;; size=11 bbWeight=1 PerfScore 3.50
-G_M23673_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       test     ecx, ecx
-       je       SHORT G_M23673_IG04
-       mov      rdx, 0xD1FFAB1E
-       ; gcrRegs +[rdx]
-       mov      rcx, rdx
+						;; size=0 bbWeight=1 PerfScore 0.00
+G_M23673_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; code for <unknown method>
-       call     [rax]<unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=29 bbWeight=0.50 PerfScore 2.50
-G_M23673_IG04:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       mov      eax, dword ptr [rsi]
+       mov      rax, qword ptr [rcx+0x18]
+       test     al, 2
+       je       SHORT G_M23673_IG04
+						;; size=8 bbWeight=1 PerfScore 3.25
+G_M23673_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
+       xor      eax, eax
+       jmp      SHORT G_M23673_IG05
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M23673_IG04:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       mov      eax, dword ptr [rax]
        and      eax, 0xD1FFAB1E
        cmp      eax, 0xD1FFAB1E
        sete     al
        movzx    rax, al
-       jmp      SHORT G_M23673_IG06
-						;; size=20 bbWeight=0.50 PerfScore 2.88
-G_M23673_IG05:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       xor      eax, eax
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M23673_IG06:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=18 bbWeight=0.50 PerfScore 1.88
+G_M23673_IG05:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        movzx    rax, al
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M23673_IG07:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
-       pop      rbx
-       pop      rsi
+G_M23673_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
+						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 81, prolog size 6, PerfScore 14.00, instruction count 26, allocated bytes for code 81 (MethodHash=471da386) for method System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)
+; Total bytes of code 34, prolog size 0, PerfScore 7.50, instruction count 12, allocated bytes for code 34 (MethodHash=471da386) for method System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -78,11 +56,8 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x06
-  CountOfUnwindCodes: 3
+  SizeOfProlog      : 0x00
+  CountOfUnwindCodes: 0
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)

```


</div></details>

<details>
<summary><span style="color:red">+9</span> (<span style="color:red">+5.59%</span>) : 14960.dasm - SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,11 +12,12 @@
 ;  V01 arg1         [V01,T00] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
-;  V04 tmp2         [V04,T01] ( 18,  9.50)   byref  ->  rax         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
-;  V05 tmp3         [V05,T03] (  2,  2   )     int  ->  rcx         single-def "field V01._length (fldOffset=0x8)" P-INDEP
+;  V04 tmp2         [V04,T01] ( 17,  9   )   byref  ->  rax         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
+;  V05 tmp3         [V05,T04] (  2,  2   )     int  ->  rcx         single-def "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V06 tmp4         [V06    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ubyte]>
-;  V07 cse0         [V07,T02] (  6,  3   )     int  ->  rdx         multi-def "CSE - aggressive"
-;  V08 cse1         [V08,T04] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
+;  V07 cse0         [V07,T03] (  5,  2.50)     int  ->  rdx         multi-def "CSE - aggressive"
+;  V08 cse1         [V08,T02] (  7,  3.50)     int  ->   r8         multi-def "CSE - aggressive"
+;  V09 cse2         [V09,T05] (  3,  1.50)     int  ->  rcx         "CSE - moderate"
 ;
 ; Lcl frame size = 40
 
@@ -29,7 +30,7 @@ G_M18546_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0004 {rdx}, byr
        ; byrRegs +[rax]
        mov      ecx, dword ptr [rdx+0x08]
        cmp      ecx, 8
-       jl       G_M18546_IG09
+       jl       G_M18546_IG08
 						;; size=15 bbWeight=1 PerfScore 5.25
 G_M18546_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
        ; byrRegs -[rdx]
@@ -41,66 +42,65 @@ G_M18546_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax},
        movzx    rdx, byte  ptr [rax+0x02]
        cmp      edx, 42
        jne      SHORT G_M18546_IG04
-       cmp      byte  ptr [rax+0x03], 0
-       je       SHORT G_M18546_IG07
-						;; size=29 bbWeight=0.50 PerfScore 7.25
+       movzx    r8, byte  ptr [rax+0x03]
+       test     r8d, r8d
+       je       SHORT G_M18546_IG06
+						;; size=33 bbWeight=0.50 PerfScore 6.88
 G_M18546_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
        cmp      edx, 43
-       jne      SHORT G_M18546_IG09
-       cmp      byte  ptr [rax+0x03], 0
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
+       movzx    r8, byte  ptr [rax+0x03]
+       test     r8d, r8d
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x04], 8
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x05], 0
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x06], 0
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x07], 0
-       jne      SHORT G_M18546_IG09
-       jmp      SHORT G_M18546_IG07
-						;; size=37 bbWeight=0.50 PerfScore 11.62
+       jne      SHORT G_M18546_IG08
+       jmp      SHORT G_M18546_IG06
+						;; size=41 bbWeight=0.50 PerfScore 11.25
 G_M18546_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
        cmp      ecx, 77
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x01], 77
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        movzx    rdx, byte  ptr [rax+0x02]
        test     edx, edx
-       jne      SHORT G_M18546_IG06
-       cmp      byte  ptr [rax+0x03], 42
-       je       SHORT G_M18546_IG07
-						;; size=25 bbWeight=0.50 PerfScore 6.25
-G_M18546_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0001 {rax}, byref, isz
-       test     edx, edx
-       jne      SHORT G_M18546_IG09
-       cmp      byte  ptr [rax+0x03], 43
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
+       movzx    r8, byte  ptr [rax+0x03]
+       cmp      r8d, 42
+       je       SHORT G_M18546_IG06
+       cmp      r8d, 43
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x04], 0
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x05], 8
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x06], 0
-       jne      SHORT G_M18546_IG09
+       jne      SHORT G_M18546_IG08
        cmp      byte  ptr [rax+0x07], 0
-       jne      SHORT G_M18546_IG09
-						;; size=34 bbWeight=0.50 PerfScore 10.62
-G_M18546_IG07:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jne      SHORT G_M18546_IG08
+						;; size=60 bbWeight=0.50 PerfScore 14.50
+G_M18546_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rax]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M18546_IG08:        ; bbWeight=0.50, epilog, nogc, extend
+G_M18546_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M18546_IG09:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M18546_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M18546_IG10:        ; bbWeight=0.50, epilog, nogc, extend
+G_M18546_IG09:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 161, prolog size 4, PerfScore 42.75, instruction count 55, allocated bytes for code 161 (MethodHash=54bcb78d) for method SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
+; Total bytes of code 170, prolog size 4, PerfScore 39.62, instruction count 56, allocated bytes for code 170 (MethodHash=54bcb78d) for method SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+31</span> (<span style="color:red">+6.18%</span>) : 17914.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -12,7 +12,7 @@
 ;  V01 loc0         [V01,T26] (  4,  4   )     int  ->  rax        
 ;* V02 loc1         [V02    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <Interop+Sec_Application_Protocols>
 ;* V03 loc2         [V03    ] (  0,  0   )     int  ->  zero-ref   
-;  V04 loc3         [V04,T11] (  7, 16   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
+;  V04 loc3         [V04,T14] (  6, 12   )     ref  ->  rbp         class-hnd exact single-def <ubyte[]>
 ;  V05 loc4         [V05,T01] (  8, 29   )     int  ->  registers  
 ;  V06 loc5         [V06,T02] (  7, 25   )     int  ->  rdi        
 ;* V07 loc6         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ubyte]>
@@ -25,7 +25,7 @@
 ;* V14 tmp4         [V14    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;* V15 tmp5         [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V16 tmp6         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[ubyte]>
-;  V17 tmp7         [V17,T29] (  2,  4   )     int  ->  r14         "Inlining Arg"
+;  V17 tmp7         [V17,T29] (  2,  4   )     int  ->  rcx         "Inlining Arg"
 ;  V18 tmp8         [V18,T27] (  2,  4   )   byref  ->  rdx         single-def "Inlining Arg"
 ;* V19 tmp9         [V19    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V20 tmp10        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
@@ -34,12 +34,12 @@
 ;* V23 tmp13        [V23    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ubyte[]>
 ;* V24 tmp14        [V24    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlyMemory`1[ubyte]>
 ;* V25 tmp15        [V25    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
-;  V26 tmp16        [V26,T12] (  6, 16   )   byref  ->  r14         "Inline stloc first use temp"
-;  V27 tmp17        [V27,T07] (  7, 20   )     int  ->  r12         "Inline stloc first use temp"
+;  V26 tmp16        [V26,T10] (  6, 16   )   byref  ->  r15         "Inline stloc first use temp"
+;  V27 tmp17        [V27,T07] (  7, 20   )     int  ->  [rsp+0x44]  "Inline stloc first use temp"
 ;* V28 tmp18        [V28    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Object>
 ;* V29 tmp19        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V30 tmp20        [V30    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <<unknown class>>
-;  V31 tmp21        [V31    ] (  3,  6   )  struct (16) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
+;  V31 tmp21        [V31    ] (  3,  6   )  struct (16) [rsp+0x30]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Span`1[ubyte]>
 ;* V32 tmp22        [V32    ] (  0,  0   )    long  ->  zero-ref    "Inline stloc first use temp"
 ;* V33 tmp23        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V34 tmp24        [V34    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <ubyte[]>
@@ -53,20 +53,20 @@
 ;* V42 tmp32        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[ubyte]>
 ;* V43 tmp33        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;* V44 tmp34        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[ubyte]>
-;  V45 tmp35        [V45,T06] (  3, 24   )     int  ->  r13         "Inlining Arg"
-;  V46 tmp36        [V46,T13] (  2, 16   )   byref  ->  rsi         "Inlining Arg"
+;  V45 tmp35        [V45,T06] (  3, 24   )     int  ->  [rsp+0x2C]  spill-single-def "Inlining Arg"
+;  V46 tmp36        [V46,T11] (  2, 16   )   byref  ->  rsi         "Inlining Arg"
 ;* V47 tmp37        [V47    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V48 tmp38        [V48    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V49 tmp39        [V49    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[ubyte]>
 ;* V50 tmp40        [V50    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V51 tmp41        [V51    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V52 tmp42        [V52,T14] (  2, 16   )    long  ->   r8         "Inlining Arg"
+;  V52 tmp42        [V52,T12] (  2, 16   )    long  ->   r8         "Inlining Arg"
 ;  V53 tmp43        [V53,T31] (  2,  2   )     int  ->  rsi         "field V02.ProtocolListsSize (fldOffset=0x0)" P-INDEP
 ;* V54 tmp44        [V54,T35] (  0,  0   )     int  ->  zero-ref    "field V02.ProtocolExtensionType (fldOffset=0x4)" P-INDEP
 ;  V55 tmp45        [V55,T32] (  2,  2   )   short  ->  rdi         "field V02.ProtocolListSize (fldOffset=0x8)" P-INDEP
-;  V56 tmp46        [V56,T18] (  2,  8   )   byref  ->  r14         "field V07._reference (fldOffset=0x0)" P-INDEP
-;  V57 tmp47        [V57,T08] (  5, 20   )     int  ->  r12         "field V07._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp48        [V58,T15] (  3, 10   )     ref  ->  r14         "field V08._readOnlyProtocol (fldOffset=0x0)" P-INDEP
+;  V56 tmp46        [V56,T18] (  2,  8   )   byref  ->  r15         "field V07._reference (fldOffset=0x0)" P-INDEP
+;  V57 tmp47        [V57,T08] (  5, 20   )     int  ->  r13         "field V07._length (fldOffset=0x8)" P-INDEP
+;  V58 tmp48        [V58,T15] (  3, 10   )     ref  ->  r15         "field V08._readOnlyProtocol (fldOffset=0x0)" P-INDEP
 ;* V59 tmp49        [V59    ] (  0,  0   )     ref  ->  zero-ref    "field V09._object (fldOffset=0x0)" P-INDEP
 ;* V60 tmp50        [V60    ] (  0,  0   )     int  ->  zero-ref    "field V09._index (fldOffset=0x8)" P-INDEP
 ;* V61 tmp51        [V61    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0xc)" P-INDEP
@@ -75,39 +75,39 @@
 ;* V64 tmp54        [V64    ] (  0,  0   )   byref  ->  zero-ref    "field V13._reference (fldOffset=0x0)" P-INDEP
 ;* V65 tmp55        [V65    ] (  0,  0   )     int  ->  zero-ref    "field V13._length (fldOffset=0x8)" P-INDEP
 ;  V66 tmp56        [V66,T25] (  4,  4   )   byref  ->  rdx         "field V14._reference (fldOffset=0x0)" P-INDEP
-;  V67 tmp57        [V67,T33] (  2,  2   )     int  ->  r14         "field V14._length (fldOffset=0x8)" P-INDEP
+;  V67 tmp57        [V67,T33] (  2,  2   )     int  ->  rcx         "field V14._length (fldOffset=0x8)" P-INDEP
 ;  V68 tmp58        [V68,T30] (  2,  2   )   byref  ->  rdx         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V69 tmp59        [V69,T34] (  2,  2   )     int  ->  r14         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V69 tmp59        [V69,T34] (  2,  2   )     int  ->  rcx         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V70 tmp60        [V70    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V16._reference (fldOffset=0x0)" P-INDEP
 ;* V71 tmp61        [V71    ] (  0,  0   )     int  ->  zero-ref    "field V16._length (fldOffset=0x8)" P-INDEP
 ;* V72 tmp62        [V72    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V21._reference (fldOffset=0x0)" P-INDEP
 ;* V73 tmp63        [V73    ] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V74 tmp64        [V74    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V22._reference (fldOffset=0x0)" P-INDEP
 ;* V75 tmp65        [V75    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
-;  V76 tmp66        [V76,T04] ( 11, 24   )     ref  ->  r15         "field V24._object (fldOffset=0x0)" P-INDEP
+;  V76 tmp66        [V76,T04] ( 11, 24   )     ref  ->  r13         "field V24._object (fldOffset=0x0)" P-INDEP
 ;* V77 tmp67        [V77    ] (  0,  0   )     int  ->  zero-ref    "field V24._index (fldOffset=0x8)" P-INDEP
-;  V78 tmp68        [V78,T16] (  4,  8   )     int  ->  r13         "field V24._length (fldOffset=0xc)" P-INDEP
+;  V78 tmp68        [V78,T16] (  4,  8   )     int  ->  r12         "field V24._length (fldOffset=0xc)" P-INDEP
 ;* V79 tmp69        [V79    ] (  0,  0   )   byref  ->  zero-ref    "field V25._reference (fldOffset=0x0)" P-INDEP
 ;* V80 tmp70        [V80    ] (  0,  0   )     int  ->  zero-ref    "field V25._length (fldOffset=0x8)" P-INDEP
-;  V81 tmp71        [V81,T19] (  2,  8   )   byref  ->  r14         "field V29._reference (fldOffset=0x0)" P-INDEP
-;  V82 tmp72        [V82,T22] (  2,  8   )     int  ->  r12         "field V29._length (fldOffset=0x8)" P-INDEP
-;  V83 tmp73        [V83    ] (  2,  4   )   byref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V31._reference (fldOffset=0x0)" P-DEP
-;  V84 tmp74        [V84    ] (  2,  4   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V31._length (fldOffset=0x8)" P-DEP
-;  V85 tmp75        [V85,T28] (  2,  4   )   byref  ->  r14         "field V39._reference (fldOffset=0x0)" P-INDEP
+;  V81 tmp71        [V81,T19] (  2,  8   )   byref  ->  r15         "field V29._reference (fldOffset=0x0)" P-INDEP
+;  V82 tmp72        [V82,T22] (  2,  8   )     int  ->  r13         "field V29._length (fldOffset=0x8)" P-INDEP
+;  V83 tmp73        [V83    ] (  2,  4   )   byref  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V31._reference (fldOffset=0x0)" P-DEP
+;  V84 tmp74        [V84    ] (  2,  4   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V31._length (fldOffset=0x8)" P-DEP
+;  V85 tmp75        [V85,T28] (  2,  4   )   byref  ->  r15         "field V39._reference (fldOffset=0x0)" P-INDEP
 ;* V86 tmp76        [V86    ] (  0,  0   )     int  ->  zero-ref    "field V39._length (fldOffset=0x8)" P-INDEP
 ;  V87 tmp77        [V87,T20] (  2,  8   )   byref  ->  rcx         "field V42._reference (fldOffset=0x0)" P-INDEP
-;  V88 tmp78        [V88,T23] (  2,  8   )     int  ->  r13         "field V42._length (fldOffset=0x8)" P-INDEP
+;  V88 tmp78        [V88,T23] (  2,  8   )     int  ->  rax         "field V42._length (fldOffset=0x8)" P-INDEP
 ;  V89 tmp79        [V89,T21] (  2,  8   )   byref  ->  rcx         "field V43._reference (fldOffset=0x0)" P-INDEP
-;  V90 tmp80        [V90,T24] (  2,  8   )     int  ->  r13         "field V43._length (fldOffset=0x8)" P-INDEP
+;  V90 tmp80        [V90,T24] (  2,  8   )     int  ->  rax         "field V43._length (fldOffset=0x8)" P-INDEP
 ;* V91 tmp81        [V91    ] (  0,  0   )   byref  ->  zero-ref    "field V44._reference (fldOffset=0x0)" P-INDEP
 ;* V92 tmp82        [V92    ] (  0,  0   )     int  ->  zero-ref    "field V44._length (fldOffset=0x8)" P-INDEP
 ;* V93 tmp83        [V93    ] (  0,  0   )   byref  ->  zero-ref    "field V49._reference (fldOffset=0x0)" P-INDEP
 ;* V94 tmp84        [V94    ] (  0,  0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
 ;  V95 tmp85        [V95,T05] (  3, 24   )     ref  ->  rdx         "arr expr"
-;  V96 cse0         [V96,T10] (  6, 18   )     int  ->  registers   multi-def "CSE - aggressive"
+;  V96 cse0         [V96,T13] (  5, 14   )     int  ->  r14         "CSE - moderate"
 ;  V97 cse1         [V97,T03] ( 12, 24   )     ref  ->  rdx         multi-def "CSE - aggressive"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 72
 
 G_M9944_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     r15
@@ -118,9 +118,9 @@ G_M9944_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 56
+       sub      rsp, 72
        xor      eax, eax
-       mov      qword ptr [rsp+0x28], rax
+       mov      qword ptr [rsp+0x30], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
 						;; size=26 bbWeight=1 PerfScore 9.75
@@ -140,10 +140,11 @@ G_M9944_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        ; gcr arg pop 0
        mov      rbp, rax
        ; gcrRegs +[rbp]
-       mov      r14d, dword ptr [rbp+0x08]
        lea      rdx, bword ptr [rbp+0x10]
        ; byrRegs +[rdx]
-       cmp      r14d, 10
+       mov      r14d, dword ptr [rbp+0x08]
+       mov      ecx, r14d
+       cmp      ecx, 10
        jb       G_M9944_IG20
        mov      dword ptr [rdx], esi
        mov      dword ptr [rdx+0x04], 2
@@ -152,7 +153,7 @@ G_M9944_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byre
        xor      edi, edi
        cmp      dword ptr [rbx+0x10], 0
        jle      G_M9944_IG17
-						;; size=88 bbWeight=1 PerfScore 17.25
+						;; size=90 bbWeight=1 PerfScore 17.50
 G_M9944_IG03:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax]
        ; byrRegs -[rdx]
@@ -163,38 +164,38 @@ G_M9944_IG03:        ; bbWeight=4, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {},
        cmp      edi, dword ptr [rdx+0x08]
        jae      G_M9944_IG19
        mov      ecx, edi
-       mov      r14, gword ptr [rdx+8*rcx+0x10]
-       ; gcrRegs +[r14]
-       test     r14, r14
+       mov      r15, gword ptr [rdx+8*rcx+0x10]
+       ; gcrRegs +[r15]
+       test     r15, r15
        jne      SHORT G_M9944_IG05
 						;; size=34 bbWeight=4 PerfScore 54.00
 G_M9944_IG04:        ; bbWeight=2, gcrefRegs=0028 {rbx rbp}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rdx r14]
-       xor      r15, r15
-       ; gcrRegs +[r15]
-       xor      r13d, r13d
+       ; gcrRegs -[rdx r15]
+       xor      r13, r13
+       ; gcrRegs +[r13]
+       xor      r12d, r12d
        jmp      SHORT G_M9944_IG06
 						;; size=8 bbWeight=2 PerfScore 5.00
-G_M9944_IG05:        ; bbWeight=2, gcrefRegs=4028 {rbx rbp r14}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r15] +[r14]
-       mov      r15, r14
-       ; gcrRegs +[r15]
-       mov      r13d, dword ptr [r15+0x08]
+G_M9944_IG05:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r13] +[r15]
+       mov      r13, r15
+       ; gcrRegs +[r13]
+       mov      r12d, dword ptr [r13+0x08]
 						;; size=7 bbWeight=2 PerfScore 4.50
-G_M9944_IG06:        ; bbWeight=4, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[r14]
-       xor      r14, r14
-       ; byrRegs +[r14]
-       xor      r12d, r12d
-       test     r15, r15
+G_M9944_IG06:        ; bbWeight=4, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[r15]
+       xor      r15, r15
+       ; byrRegs +[r15]
+       xor      eax, eax
+       test     r13, r13
        je       G_M9944_IG12
-						;; size=15 bbWeight=4 PerfScore 7.00
-G_M9944_IG07:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[r14]
-       mov      rdx, qword ptr [r15]
+						;; size=14 bbWeight=4 PerfScore 7.00
+G_M9944_IG07:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[r15]
+       mov      rdx, qword ptr [r13]
        test     dword ptr [rdx], 0xD1FFAB1E
        je       SHORT G_M9944_IG09
-       mov      rdx, r15
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; ubyte[]
        call     CORINFO_HELP_ISINSTANCEOFARRAY
@@ -209,16 +210,19 @@ G_M9944_IG07:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
-						;; size=53 bbWeight=2 PerfScore 24.50
-G_M9944_IG08:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       lea      r14, bword ptr [r15+0x10]
-       ; byrRegs +[r14]
-       mov      r12d, dword ptr [r15+0x08]
+						;; size=54 bbWeight=2 PerfScore 24.50
+G_M9944_IG08:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       lea      r15, bword ptr [r13+0x10]
+       ; byrRegs +[r15]
+       mov      eax, dword ptr [r13+0x08]
+       mov      r13d, eax
+       ; gcrRegs -[r13]
        jmp      SHORT G_M9944_IG11
-						;; size=10 bbWeight=2 PerfScore 9.00
-G_M9944_IG09:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[r14]
-       mov      rdx, r15
+						;; size=13 bbWeight=2 PerfScore 9.50
+G_M9944_IG09:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[r13]
+       ; byrRegs -[r15]
+       mov      rdx, r13
        ; gcrRegs +[rdx]
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFCLASS
@@ -234,29 +238,31 @@ G_M9944_IG09:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000
        ; gcrRegs -[rax rcx rdx]
        ; gcr arg pop 0
 						;; size=42 bbWeight=2 PerfScore 12.50
-G_M9944_IG10:        ; bbWeight=2, gcrefRegs=8028 {rbx rbp r15}, byrefRegs=0000 {}, byref
-       lea      rdx, [rsp+0x28]
-       mov      rcx, r15
+G_M9944_IG10:        ; bbWeight=2, gcrefRegs=2028 {rbx rbp r13}, byrefRegs=0000 {}, byref
+       lea      rdx, [rsp+0x30]
+       mov      rcx, r13
...

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+13.79%</span>) : 22185.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,14 +7,14 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  6,  6   )     int  ->  rcx         single-def
-;  V01 arg1         [V01,T01] (  6,  6   )     int  ->  rdx         single-def
+;  V00 arg0         [V00,T00] (  5,  4   )     int  ->  rcx         single-def
+;  V01 arg1         [V01,T01] (  5,  4   )     int  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T03] (  2,  2   )     int  ->  rax        
+;  V04 tmp1         [V04,T03] (  3,  2   )     int  ->  registers  
 ;* V05 tmp2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V07 tmp4         [V07,T02] (  3,  2   )     int  ->  rcx        
+;  V07 tmp4         [V07,T02] (  4,  2   )     int  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,30 +22,41 @@ G_M19887_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M19887_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        cmp      ecx, edx
-       mov      eax, ecx
-       cmovg    eax, edx
-       cmovle   ecx, edx
-       cmp      eax, 3
-       jne      SHORT G_M19887_IG04
-						;; size=15 bbWeight=1 PerfScore 2.25
+       jg       SHORT G_M19887_IG04
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M19887_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      ecx, 4
-       je       SHORT G_M19887_IG06
-						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       jmp      SHORT G_M19887_IG05
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M19887_IG06
+						;; size=2 bbWeight=0.50 PerfScore 1.00
+G_M19887_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, edx
+       jmp      SHORT G_M19887_IG07
+						;; size=4 bbWeight=0.50 PerfScore 1.12
+G_M19887_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, ecx
-						;; size=2 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG05:        ; bbWeight=0.50, epilog, nogc, extend
+       mov      ecx, edx
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M19887_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      ecx, 3
+       jne      SHORT G_M19887_IG09
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M19887_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       cmp      eax, 4
+       je       SHORT G_M19887_IG10
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M19887_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M19887_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M19887_IG10:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        mov      eax, 5
 						;; size=5 bbWeight=0.50 PerfScore 0.12
-G_M19887_IG07:        ; bbWeight=0.50, epilog, nogc, extend
+G_M19887_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 29, prolog size 0, PerfScore 4.12, instruction count 12, allocated bytes for code 29 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
+; Total bytes of code 33, prolog size 0, PerfScore 7.62, instruction count 15, allocated bytes for code 33 (MethodHash=25a6b250) for method Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-43.24%</span>) : 15378.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,97 +7,71 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rsi         this class-hnd exact single-def <System.String>
-;  V01 arg1         [V01,T00] (  7,  5   )     ref  ->  rbx         class-hnd exact single-def <System.String>
+;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.String>
+;  V01 arg1         [V01,T00] (  6,  4.50)     ref  ->  rdx         class-hnd exact single-def <System.String>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T03] (  2,  2   )   byref  ->  rcx         single-def "impAppendStmt"
+;  V03 tmp1         [V03,T02] (  2,  2   )   byref  ->  rcx         single-def "impAppendStmt"
 ;* V04 tmp2         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp4         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp5         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp6         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V09 cse0         [V09,T02] (  4,  2   )     int  ->  rdi         "CSE - aggressive"
+;  V09 cse0         [V09,T03] (  3,  1.50)     int  ->   r8         "CSE - moderate"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
-G_M26791_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rdi
-       push     rsi
-       push     rbx
-       sub      rsp, 32
-       mov      rsi, rcx
-       ; gcrRegs +[rsi]
-       mov      rbx, rdx
-       ; gcrRegs +[rbx]
-						;; size=13 bbWeight=1 PerfScore 3.75
-G_M26791_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      rsi, rbx
+G_M26791_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
+G_M26791_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rcx rdx]
+       cmp      rcx, rdx
        jne      SHORT G_M26791_IG05
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M26791_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rsi]
+       ; gcrRegs -[rcx rdx]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M26791_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       test     rbx, rbx
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M26791_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx rdx]
+       test     rdx, rdx
        jne      SHORT G_M26791_IG08
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M26791_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rsi]
+       ; gcrRegs -[rcx rdx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M26791_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       mov      edi, dword ptr [rsi+0x08]
-       cmp      edi, dword ptr [rbx+0x08]
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M26791_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx rdx]
+       mov      r8d, dword ptr [rcx+0x08]
+       cmp      r8d, dword ptr [rdx+0x08]
        jne      SHORT G_M26791_IG06
-       cmp      dword ptr [rbx+0x08], edi
-       je       SHORT G_M26791_IG09
-       mov      rcx, (reloc)
-       ; gcrRegs +[rcx]
-       mov      rdx, (reloc)
-       ; gcrRegs +[rdx]
-       call     <unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=38 bbWeight=0.50 PerfScore 5.75
-G_M26791_IG09:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       lea      rcx, bword ptr [rsi+0x0C]
+       add      rcx, 12
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       add      edi, edi
-       mov      r8d, edi
-       lea      rdx, bword ptr [rbx+0x0C]
+       add      r8d, r8d
+       add      rdx, 12
+       ; gcrRegs -[rdx]
        ; byrRegs +[rdx]
        call     <unknown method>
-       ; gcrRegs -[rbx rsi]
        ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        nop      
-						;; size=19 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG10:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+						;; size=27 bbWeight=0.50 PerfScore 4.00
+G_M26791_IG09:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 111, prolog size 7, PerfScore 17.12, instruction count 41, allocated bytes for code 111 (MethodHash=687e9758) for method System.String:Equals(System.String):ubyte:this (FullOpts)
+; Total bytes of code 63, prolog size 4, PerfScore 8.25, instruction count 21, allocated bytes for code 63 (MethodHash=687e9758) for method System.String:Equals(System.String):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -105,12 +79,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-43.24%</span>) : 18035.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,97 +7,71 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rsi         this class-hnd exact single-def <System.String>
-;  V01 arg1         [V01,T00] (  7,  5   )     ref  ->  rbx         class-hnd exact single-def <System.String>
+;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.String>
+;  V01 arg1         [V01,T00] (  6,  4.50)     ref  ->  rdx         class-hnd exact single-def <System.String>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T03] (  2,  2   )   byref  ->  rcx         single-def "impAppendStmt"
+;  V03 tmp1         [V03,T02] (  2,  2   )   byref  ->  rcx         single-def "impAppendStmt"
 ;* V04 tmp2         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp4         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp5         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp6         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V09 cse0         [V09,T02] (  4,  2   )     int  ->  rdi         "CSE - aggressive"
+;  V09 cse0         [V09,T03] (  3,  1.50)     int  ->   r8         "CSE - moderate"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
-G_M26791_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rdi
-       push     rsi
-       push     rbx
-       sub      rsp, 32
-       mov      rsi, rcx
-       ; gcrRegs +[rsi]
-       mov      rbx, rdx
-       ; gcrRegs +[rbx]
-						;; size=13 bbWeight=1 PerfScore 3.75
-G_M26791_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      rsi, rbx
+G_M26791_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
+G_M26791_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rcx rdx]
+       cmp      rcx, rdx
        jne      SHORT G_M26791_IG05
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M26791_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rsi]
+       ; gcrRegs -[rcx rdx]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M26791_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       test     rbx, rbx
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M26791_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx rdx]
+       test     rdx, rdx
        jne      SHORT G_M26791_IG08
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M26791_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rsi]
+       ; gcrRegs -[rcx rdx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M26791_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       mov      edi, dword ptr [rsi+0x08]
-       cmp      edi, dword ptr [rbx+0x08]
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M26791_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx rdx]
+       mov      r8d, dword ptr [rcx+0x08]
+       cmp      r8d, dword ptr [rdx+0x08]
        jne      SHORT G_M26791_IG06
-       cmp      dword ptr [rbx+0x08], edi
-       je       SHORT G_M26791_IG09
-       mov      rcx, (reloc)
-       ; gcrRegs +[rcx]
-       mov      rdx, (reloc)
-       ; gcrRegs +[rdx]
-       call     <unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=38 bbWeight=0.50 PerfScore 5.75
-G_M26791_IG09:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       lea      rcx, bword ptr [rsi+0x0C]
+       add      rcx, 12
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       add      edi, edi
-       mov      r8d, edi
-       lea      rdx, bword ptr [rbx+0x0C]
+       add      r8d, r8d
+       add      rdx, 12
+       ; gcrRegs -[rdx]
        ; byrRegs +[rdx]
        call     <unknown method>
-       ; gcrRegs -[rbx rsi]
        ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        nop      
-						;; size=19 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG10:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+						;; size=27 bbWeight=0.50 PerfScore 4.00
+G_M26791_IG09:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 111, prolog size 7, PerfScore 17.12, instruction count 41, allocated bytes for code 111 (MethodHash=687e9758) for method System.String:Equals(System.String):ubyte:this (FullOpts)
+; Total bytes of code 63, prolog size 4, PerfScore 8.25, instruction count 21, allocated bytes for code 63 (MethodHash=687e9758) for method System.String:Equals(System.String):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -105,12 +79,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:green">-48</span> (<span style="color:green">-43.24%</span>) : 182.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,97 +7,71 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rsi         this class-hnd exact single-def <System.String>
-;  V01 arg1         [V01,T00] (  7,  5   )     ref  ->  rbx         class-hnd exact single-def <System.String>
+;  V00 this         [V00,T01] (  5,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.String>
+;  V01 arg1         [V01,T00] (  6,  4.50)     ref  ->  rdx         class-hnd exact single-def <System.String>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T03] (  2,  2   )   byref  ->  rcx         single-def "impAppendStmt"
+;  V03 tmp1         [V03,T02] (  2,  2   )   byref  ->  rcx         single-def "impAppendStmt"
 ;* V04 tmp2         [V04    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp4         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp5         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp6         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V09 cse0         [V09,T02] (  4,  2   )     int  ->  rdi         "CSE - aggressive"
+;  V09 cse0         [V09,T03] (  3,  1.50)     int  ->   r8         "CSE - moderate"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
-G_M26791_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rdi
-       push     rsi
-       push     rbx
-       sub      rsp, 32
-       mov      rsi, rcx
-       ; gcrRegs +[rsi]
-       mov      rbx, rdx
-       ; gcrRegs +[rbx]
-						;; size=13 bbWeight=1 PerfScore 3.75
-G_M26791_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      rsi, rbx
+G_M26791_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
+G_M26791_IG02:        ; bbWeight=1, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs +[rcx rdx]
+       cmp      rcx, rdx
        jne      SHORT G_M26791_IG05
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M26791_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rsi]
+       ; gcrRegs -[rcx rdx]
        mov      eax, 1
 						;; size=5 bbWeight=0.50 PerfScore 0.12
 G_M26791_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       test     rbx, rbx
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M26791_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx rdx]
+       test     rdx, rdx
        jne      SHORT G_M26791_IG08
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 G_M26791_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx rsi]
+       ; gcrRegs -[rcx rdx]
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M26791_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs +[rbx rsi]
-       mov      edi, dword ptr [rsi+0x08]
-       cmp      edi, dword ptr [rbx+0x08]
+						;; size=5 bbWeight=0.50 PerfScore 0.62
+G_M26791_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0006 {rcx rdx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs +[rcx rdx]
+       mov      r8d, dword ptr [rcx+0x08]
+       cmp      r8d, dword ptr [rdx+0x08]
        jne      SHORT G_M26791_IG06
-       cmp      dword ptr [rbx+0x08], edi
-       je       SHORT G_M26791_IG09
-       mov      rcx, (reloc)
-       ; gcrRegs +[rcx]
-       mov      rdx, (reloc)
-       ; gcrRegs +[rdx]
-       call     <unknown method>
-       ; gcrRegs -[rcx rdx]
-       ; gcr arg pop 0
-						;; size=38 bbWeight=0.50 PerfScore 5.75
-G_M26791_IG09:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       lea      rcx, bword ptr [rsi+0x0C]
+       add      rcx, 12
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       add      edi, edi
-       mov      r8d, edi
-       lea      rdx, bword ptr [rbx+0x0C]
+       add      r8d, r8d
+       add      rdx, 12
+       ; gcrRegs -[rdx]
        ; byrRegs +[rdx]
        call     <unknown method>
-       ; gcrRegs -[rbx rsi]
        ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        nop      
-						;; size=19 bbWeight=0.50 PerfScore 1.38
-G_M26791_IG10:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
-       pop      rsi
-       pop      rdi
+						;; size=27 bbWeight=0.50 PerfScore 4.00
+G_M26791_IG09:        ; bbWeight=0.50, epilog, nogc, extend
+       add      rsp, 40
        ret      
-						;; size=8 bbWeight=0.50 PerfScore 1.38
+						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 111, prolog size 7, PerfScore 17.12, instruction count 41, allocated bytes for code 111 (MethodHash=687e9758) for method System.String:Equals(System.String):ubyte:this (FullOpts)
+; Total bytes of code 63, prolog size 4, PerfScore 8.25, instruction count 21, allocated bytes for code 63 (MethodHash=687e9758) for method System.String:Equals(System.String):ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -105,12 +79,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x07
-  CountOfUnwindCodes: 4
+  SizeOfProlog      : 0x04
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x04 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+3.45%</span>) : 20511.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,8 +7,8 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] (  8,  5.50)     ref  ->  rbx         class-hnd exact single-def <System.String>
-;  V01 loc0         [V01,T05] (  3,  1.50)     int  ->  rax        
+;  V00 arg0         [V00,T00] (  6,  4.50)     ref  ->  rbx         class-hnd exact single-def <System.String>
+;  V01 loc0         [V01,T06] (  3,  1.50)     int  ->  rax        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
@@ -22,46 +22,53 @@
 ;* V12 tmp10        [V12    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V13 tmp11        [V13    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V14 tmp12        [V14    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V15 tmp13        [V15,T04] (  2,  2   )     int  ->  rax         "Inlining Arg"
-;  V16 tmp14        [V16,T02] (  2,  2   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V15 tmp13        [V15,T04] (  2,  2   )     int  ->  rdi         "Inlining Arg"
+;  V16 tmp14        [V16,T02] (  2,  2   )   byref  ->  rsi         single-def "Inlining Arg"
 ;* V17 tmp15        [V17    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V18 tmp16        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V19 tmp17        [V19    ] (  0,  0   )   byref  ->  zero-ref    "field V03._reference (fldOffset=0x0)" P-INDEP
 ;* V20 tmp18        [V20    ] (  0,  0   )     int  ->  zero-ref    "field V03._length (fldOffset=0x8)" P-INDEP
 ;* V21 tmp19        [V21    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
 ;* V22 tmp20        [V22    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
-;  V23 tmp21        [V23,T06] (  2,  1   )   byref  ->  rcx         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V24 tmp22        [V24,T10] (  2,  1   )     int  ->  rax         "field V05._length (fldOffset=0x8)" P-INDEP
-;  V25 tmp23        [V25,T07] (  2,  1   )   byref  ->  rcx         single-def "field V06._reference (fldOffset=0x0)" P-INDEP
-;  V26 tmp24        [V26,T11] (  2,  1   )     int  ->  rax         "field V06._length (fldOffset=0x8)" P-INDEP
+;  V23 tmp21        [V23,T08] (  2,  1   )   byref  ->  rcx         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V24 tmp22        [V24,T12] (  2,  1   )     int  ->  rax         "field V05._length (fldOffset=0x8)" P-INDEP
+;  V25 tmp23        [V25,T09] (  2,  1   )   byref  ->  rcx         single-def "field V06._reference (fldOffset=0x0)" P-INDEP
+;  V26 tmp24        [V26,T13] (  2,  1   )     int  ->  rax         "field V06._length (fldOffset=0x8)" P-INDEP
 ;* V27 tmp25        [V27    ] (  0,  0   )   byref  ->  zero-ref    "field V07._reference (fldOffset=0x0)" P-INDEP
 ;* V28 tmp26        [V28    ] (  0,  0   )     int  ->  zero-ref    "field V07._length (fldOffset=0x8)" P-INDEP
-;  V29 tmp27        [V29,T08] (  2,  1   )   byref  ->  rcx         "field V12._reference (fldOffset=0x0)" P-INDEP
-;  V30 tmp28        [V30,T12] (  2,  1   )     int  ->  rax         "field V12._length (fldOffset=0x8)" P-INDEP
-;  V31 tmp29        [V31,T09] (  2,  1   )   byref  ->  rcx         single-def "field V13._reference (fldOffset=0x0)" P-INDEP
-;  V32 tmp30        [V32,T13] (  2,  1   )     int  ->  rax         "field V13._length (fldOffset=0x8)" P-INDEP
+;  V29 tmp27        [V29,T10] (  2,  1   )   byref  ->  rsi         "field V12._reference (fldOffset=0x0)" P-INDEP
+;  V30 tmp28        [V30,T14] (  2,  1   )     int  ->  rdi         "field V12._length (fldOffset=0x8)" P-INDEP
+;  V31 tmp29        [V31,T11] (  2,  1   )   byref  ->  rsi         single-def "field V13._reference (fldOffset=0x0)" P-INDEP
+;  V32 tmp30        [V32,T15] (  2,  1   )     int  ->  rdi         "field V13._length (fldOffset=0x8)" P-INDEP
 ;* V33 tmp31        [V33    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V14._reference (fldOffset=0x0)" P-INDEP
 ;* V34 tmp32        [V34    ] (  0,  0   )     int  ->  zero-ref    "field V14._length (fldOffset=0x8)" P-INDEP
 ;  V35 tmp33        [V35    ] (  6,  6   )  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V36 cse0         [V36,T05] (  3,  1.50)   byref  ->  rsi         "CSE - moderate"
+;  V37 cse1         [V37,T07] (  3,  1.50)     int  ->  rdi         "CSE - moderate"
 ;
 ; Lcl frame size = 48
 
 G_M25805_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     rdi
+       push     rsi
        push     rbx
        sub      rsp, 48
        xor      eax, eax
        mov      qword ptr [rsp+0x20], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=15 bbWeight=1 PerfScore 2.75
+						;; size=17 bbWeight=1 PerfScore 4.75
 G_M25805_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        test     rbx, rbx
        je       SHORT G_M25805_IG04
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M25805_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       lea      rcx, bword ptr [rbx+0x0C]
+       lea      rsi, bword ptr [rbx+0x0C]
+       ; byrRegs +[rsi]
+       mov      rcx, rsi
        ; byrRegs +[rcx]
-       mov      eax, dword ptr [rbx+0x08]
+       mov      edi, dword ptr [rbx+0x08]
+       mov      eax, edi
        mov      bword ptr [rsp+0x20], rcx
        mov      dword ptr [rsp+0x28], eax
        lea      rcx, [rsp+0x20]
@@ -70,27 +77,28 @@ G_M25805_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        ; gcr arg pop 0
        test     eax, eax
        je       SHORT G_M25805_IG06
-						;; size=30 bbWeight=0.50 PerfScore 3.62
+						;; size=35 bbWeight=0.50 PerfScore 3.88
 G_M25805_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx]
+       ; byrRegs -[rsi]
        xor      rax, rax
        ; gcrRegs +[rax]
 						;; size=2 bbWeight=0.50 PerfScore 0.12
 G_M25805_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 48
        pop      rbx
+       pop      rsi
+       pop      rdi
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
-G_M25805_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+						;; size=8 bbWeight=0.50 PerfScore 1.38
+G_M25805_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, gcvars, byref, isz
        ; gcrRegs -[rax] +[rbx]
-       lea      rcx, bword ptr [rbx+0x0C]
-       ; byrRegs +[rcx]
-       mov      eax, dword ptr [rbx+0x08]
-       mov      bword ptr [rsp+0x20], rcx
-       mov      dword ptr [rsp+0x28], eax
+       ; byrRegs +[rsi]
+       mov      bword ptr [rsp+0x20], rsi
+       mov      dword ptr [rsp+0x28], edi
        lea      rcx, [rsp+0x20]
-       ; byrRegs -[rcx]
        call     System.IO.Path:GetDirectoryNameOffset(System.ReadOnlySpan`1[ushort]):int
+       ; byrRegs -[rsi]
        ; gcr arg pop 0
        test     eax, eax
        jl       SHORT G_M25805_IG04
@@ -107,14 +115,16 @@ G_M25805_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
        nop      
-						;; size=52 bbWeight=0.50 PerfScore 5.25
+						;; size=45 bbWeight=0.50 PerfScore 4.00
 G_M25805_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 48
        pop      rbx
+       pop      rsi
+       pop      rdi
        ret      
-						;; size=6 bbWeight=0.50 PerfScore 0.88
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 
-; Total bytes of code 116, prolog size 12, PerfScore 14.75, instruction count 37, allocated bytes for code 116 (MethodHash=11489b32) for method System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
+; Total bytes of code 120, prolog size 14, PerfScore 16.75, instruction count 43, allocated bytes for code 120 (MethodHash=11489b32) for method System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -122,10 +132,12 @@ Unwind Info:
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
<summary><span style="color:red">+10</span> (<span style="color:red">+4.42%</span>) : 6678.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,53 +8,56 @@
 ; control-flow guard enabled
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 15,  9   )     ref  ->  rbx         this class-hnd exact single-def <System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24>
+;  V00 this         [V00,T00] ( 14,  8.50)     ref  ->  rbx         this class-hnd exact single-def <System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24>
 ;  V01 loc0         [V01,T04] (  3,  2.50)     int  ->  rax        
 ;* V02 loc1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    <Internal.Metadata.NativeFormat.NamespaceDefinitionHandle>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 tmp1         [V04,T02] (  3,  3   )   byref  ->   r8         single-def "Inlining Arg"
-;  V05 tmp2         [V05    ] (  8,  8   )  struct (24) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Internal.Metadata.NativeFormat.NamespaceDefinitionHandleCollection+Enumerator>
+;  V05 tmp2         [V05    ] (  8,  8   )  struct (24) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Internal.Metadata.NativeFormat.NamespaceDefinitionHandleCollection+Enumerator>
 ;  V06 tmp3         [V06,T03] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Internal.NativeFormat.NativeReader>
 ;  V07 tmp4         [V07,T05] (  2,  2   )     int  ->  rdx         "Inlining Arg"
 ;* V08 tmp5         [V08    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;* V09 tmp6         [V09,T07] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V10 tmp7         [V10,T01] (  7,  7   )   byref  ->  rsi         "Inlining Arg"
+;* V09 tmp6         [V09,T08] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V10 tmp7         [V10,T01] (  7,  7   )   byref  ->  rdi         "Inlining Arg"
 ;* V11 tmp8         [V11    ] (  0,  0   )     int  ->  zero-ref    "field V02._value (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12    ] (  2,  1   )     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V05._reader (fldOffset=0x0)" P-DEP
-;  V13 tmp10        [V13    ] (  2,  1   )     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V05._offset (fldOffset=0x8)" P-DEP
-;  V14 tmp11        [V14    ] (  2,  1   )     int  ->  [rsp+0x2C]  do-not-enreg[X] addr-exposed "field V05._remaining (fldOffset=0xc)" P-DEP
-;  V15 tmp12        [V15    ] (  2,  1   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V05._current (fldOffset=0x10)" P-DEP
-;  V16 cse0         [V16,T06] (  3,  1.50)     int  ->   r8         "CSE - moderate"
+;  V12 tmp9         [V12    ] (  2,  1   )     ref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V05._reader (fldOffset=0x0)" P-DEP
+;  V13 tmp10        [V13    ] (  2,  1   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V05._offset (fldOffset=0x8)" P-DEP
+;  V14 tmp11        [V14    ] (  2,  1   )     int  ->  [rsp+0x34]  do-not-enreg[X] addr-exposed "field V05._remaining (fldOffset=0xc)" P-DEP
+;  V15 tmp12        [V15    ] (  2,  1   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V05._current (fldOffset=0x10)" P-DEP
+;  V16 cse0         [V16,T07] (  3,  1.50)     int  ->   r8         "CSE - moderate"
+;  V17 cse1         [V17,T06] (  3,  1.50)   byref  ->  rsi         "CSE - moderate"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 64
 
 G_M58257_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 56
+       sub      rsp, 64
        xorps    xmm4, xmm4
-       movaps   xmmword ptr [rsp+0x20], xmm4
+       movups   xmmword ptr [rsp+0x28], xmm4
        xor      eax, eax
-       mov      qword ptr [rsp+0x30], rax
+       mov      qword ptr [rsp+0x38], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=24 bbWeight=1 PerfScore 6.08
+						;; size=25 bbWeight=1 PerfScore 7.08
 G_M58257_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      eax, dword ptr [rbx+0x08]
        test     eax, eax
        je       SHORT G_M58257_IG05
 						;; size=7 bbWeight=1 PerfScore 3.25
-G_M58257_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+G_M58257_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        cmp      eax, 1
-       je       SHORT G_M58257_IG08
+       je       G_M58257_IG08
        xor      eax, eax
-						;; size=7 bbWeight=0.50 PerfScore 0.75
+						;; size=11 bbWeight=0.50 PerfScore 0.75
 G_M58257_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 64
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 G_M58257_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        mov      dword ptr [rbx+0x08], -1
        lea      r8, bword ptr [rbx+0x18]
@@ -62,28 +65,28 @@ G_M58257_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rcx, gword ptr [r8]
        ; gcrRegs +[rcx]
        mov      edx, dword ptr [r8+0x08]
-       mov      gword ptr [rsp+0x20], rcx
-       lea      r8, [rsp+0x2C]
+       mov      gword ptr [rsp+0x28], rcx
+       lea      r8, [rsp+0x34]
        ; byrRegs -[r8]
        cmp      dword ptr [rcx], ecx
        call     Internal.NativeFormat.NativeReader:DecodeUnsigned(uint,byref):uint:this
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      dword ptr [rsp+0x28], eax
+       mov      dword ptr [rsp+0x30], eax
        xor      ecx, ecx
-       mov      dword ptr [rsp+0x30], ecx
+       mov      dword ptr [rsp+0x38], ecx
        lea      rcx, bword ptr [rbx+0x38]
        ; byrRegs +[rcx]
-       mov      rdx, gword ptr [rsp+0x20]
+       mov      rdx, gword ptr [rsp+0x28]
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       mov      r8d, dword ptr [rsp+0x28]
-       mov      dword ptr [rbx+0x40], r8d
-       mov      r8d, dword ptr [rsp+0x2C]
-       mov      dword ptr [rbx+0x44], r8d
        mov      r8d, dword ptr [rsp+0x30]
+       mov      dword ptr [rbx+0x40], r8d
+       mov      r8d, dword ptr [rsp+0x34]
+       mov      dword ptr [rbx+0x44], r8d
+       mov      r8d, dword ptr [rsp+0x38]
        mov      dword ptr [rbx+0x48], r8d
        jmp      SHORT G_M58257_IG09
 						;; size=88 bbWeight=0.50 PerfScore 11.88
@@ -94,50 +97,55 @@ G_M58257_IG06:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        mov      eax, 1
 						;; size=18 bbWeight=0.50 PerfScore 2.12
 G_M58257_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 64
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 G_M58257_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        mov      dword ptr [rbx+0x08], -1
 						;; size=7 bbWeight=0.50 PerfScore 0.50
 G_M58257_IG09:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        lea      rsi, bword ptr [rbx+0x38]
        ; byrRegs +[rsi]
-       mov      r8d, dword ptr [rsi+0x0C]
+       mov      rdi, rsi
+       ; byrRegs +[rdi]
+       mov      r8d, dword ptr [rdi+0x0C]
        test     r8d, r8d
        je       SHORT G_M58257_IG10
        dec      r8d
-       mov      dword ptr [rsi+0x0C], r8d
-       lea      r8, bword ptr [rsi+0x10]
+       mov      dword ptr [rdi+0x0C], r8d
+       lea      r8, bword ptr [rdi+0x10]
        ; byrRegs +[r8]
-       mov      edx, dword ptr [rsi+0x08]
-       mov      rcx, gword ptr [rsi]
+       mov      edx, dword ptr [rdi+0x08]
+       mov      rcx, gword ptr [rdi]
        ; gcrRegs +[rcx]
        call     Internal.Metadata.NativeFormat.MdBinaryReader:Read(Internal.NativeFormat.NativeReader,uint,byref):uint
        ; gcrRegs -[rcx]
-       ; byrRegs -[r8]
+       ; byrRegs -[rsi r8]
        ; gcr arg pop 0
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rdi+0x08], eax
        jmp      SHORT G_M58257_IG06
-						;; size=40 bbWeight=0.50 PerfScore 6.75
-G_M58257_IG10:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rsi]
-       xor      eax, eax
-       mov      qword ptr [rbx+0x38], rax
-       mov      qword ptr [rbx+0x40], rax
-       mov      qword ptr [rbx+0x48], rax
-						;; size=14 bbWeight=0.50 PerfScore 1.62
-G_M58257_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+						;; size=43 bbWeight=0.50 PerfScore 6.88
+G_M58257_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, byref
        ; gcrRegs -[rbx]
-       add      rsp, 56
+       ; byrRegs -[rdi] +[rsi]
+       xor      eax, eax
+       mov      qword ptr [rsi], rax
+       mov      qword ptr [rsi+0x08], rax
+       mov      qword ptr [rsi+0x10], rax
+						;; size=13 bbWeight=0.50 PerfScore 1.62
+G_M58257_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rsi]
+       add      rsp, 64
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 
-; Total bytes of code 226, prolog size 21, PerfScore 36.33, instruction count 68, allocated bytes for code 226 (MethodHash=dfc81c6e) for method System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
+; Total bytes of code 236, prolog size 22, PerfScore 38.21, instruction count 73, allocated bytes for code 236 (MethodHash=dfc81c6e) for method System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -145,11 +153,12 @@ Unwind Info:
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
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+4.42%</span>) : 12187.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,53 +7,56 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 15,  9   )     ref  ->  rbx         this class-hnd exact single-def <System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24>
+;  V00 this         [V00,T00] ( 14,  8.50)     ref  ->  rbx         this class-hnd exact single-def <System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24>
 ;  V01 loc0         [V01,T04] (  3,  2.50)     int  ->  rax        
 ;* V02 loc1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    <Internal.Metadata.NativeFormat.NamespaceDefinitionHandle>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 tmp1         [V04,T02] (  3,  3   )   byref  ->   r8         single-def "Inlining Arg"
-;  V05 tmp2         [V05    ] (  8,  8   )  struct (24) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Internal.Metadata.NativeFormat.NamespaceDefinitionHandleCollection+Enumerator>
+;  V05 tmp2         [V05    ] (  8,  8   )  struct (24) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <Internal.Metadata.NativeFormat.NamespaceDefinitionHandleCollection+Enumerator>
 ;  V06 tmp3         [V06,T03] (  3,  3   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <Internal.NativeFormat.NativeReader>
 ;  V07 tmp4         [V07,T05] (  2,  2   )     int  ->  rdx         "Inlining Arg"
 ;* V08 tmp5         [V08    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;* V09 tmp6         [V09,T07] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V10 tmp7         [V10,T01] (  7,  7   )   byref  ->  rsi         "Inlining Arg"
+;* V09 tmp6         [V09,T08] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V10 tmp7         [V10,T01] (  7,  7   )   byref  ->  rdi         "Inlining Arg"
 ;* V11 tmp8         [V11    ] (  0,  0   )     int  ->  zero-ref    "field V02._value (fldOffset=0x0)" P-INDEP
-;  V12 tmp9         [V12    ] (  2,  1   )     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V05._reader (fldOffset=0x0)" P-DEP
-;  V13 tmp10        [V13    ] (  2,  1   )     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V05._offset (fldOffset=0x8)" P-DEP
-;  V14 tmp11        [V14    ] (  2,  1   )     int  ->  [rsp+0x2C]  do-not-enreg[X] addr-exposed "field V05._remaining (fldOffset=0xc)" P-DEP
-;  V15 tmp12        [V15    ] (  2,  1   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V05._current (fldOffset=0x10)" P-DEP
-;  V16 cse0         [V16,T06] (  3,  1.50)     int  ->   r8         "CSE - moderate"
+;  V12 tmp9         [V12    ] (  2,  1   )     ref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V05._reader (fldOffset=0x0)" P-DEP
+;  V13 tmp10        [V13    ] (  2,  1   )     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V05._offset (fldOffset=0x8)" P-DEP
+;  V14 tmp11        [V14    ] (  2,  1   )     int  ->  [rsp+0x34]  do-not-enreg[X] addr-exposed "field V05._remaining (fldOffset=0xc)" P-DEP
+;  V15 tmp12        [V15    ] (  2,  1   )     int  ->  [rsp+0x38]  do-not-enreg[X] addr-exposed "field V05._current (fldOffset=0x10)" P-DEP
+;  V16 cse0         [V16,T07] (  3,  1.50)     int  ->   r8         "CSE - moderate"
+;  V17 cse1         [V17,T06] (  3,  1.50)   byref  ->  rsi         "CSE - moderate"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 64
 
 G_M58257_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 56
+       sub      rsp, 64
        xorps    xmm4, xmm4
-       movaps   xmmword ptr [rsp+0x20], xmm4
+       movups   xmmword ptr [rsp+0x28], xmm4
        xor      eax, eax
-       mov      qword ptr [rsp+0x30], rax
+       mov      qword ptr [rsp+0x38], rax
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=24 bbWeight=1 PerfScore 6.08
+						;; size=25 bbWeight=1 PerfScore 7.08
 G_M58257_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        mov      eax, dword ptr [rbx+0x08]
        test     eax, eax
        je       SHORT G_M58257_IG05
 						;; size=7 bbWeight=1 PerfScore 3.25
-G_M58257_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+G_M58257_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        cmp      eax, 1
-       je       SHORT G_M58257_IG08
+       je       G_M58257_IG08
        xor      eax, eax
-						;; size=7 bbWeight=0.50 PerfScore 0.75
+						;; size=11 bbWeight=0.50 PerfScore 0.75
 G_M58257_IG04:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 64
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 G_M58257_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        mov      dword ptr [rbx+0x08], -1
        lea      r8, bword ptr [rbx+0x18]
@@ -61,28 +64,28 @@ G_M58257_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        mov      rcx, gword ptr [r8]
        ; gcrRegs +[rcx]
        mov      edx, dword ptr [r8+0x08]
-       mov      gword ptr [rsp+0x20], rcx
-       lea      r8, [rsp+0x2C]
+       mov      gword ptr [rsp+0x28], rcx
+       lea      r8, [rsp+0x34]
        ; byrRegs -[r8]
        cmp      dword ptr [rcx], ecx
        call     Internal.NativeFormat.NativeReader:DecodeUnsigned(uint,byref):uint:this
        ; gcrRegs -[rcx]
        ; gcr arg pop 0
-       mov      dword ptr [rsp+0x28], eax
+       mov      dword ptr [rsp+0x30], eax
        xor      ecx, ecx
-       mov      dword ptr [rsp+0x30], ecx
+       mov      dword ptr [rsp+0x38], ecx
        lea      rcx, bword ptr [rbx+0x38]
        ; byrRegs +[rcx]
-       mov      rdx, gword ptr [rsp+0x20]
+       mov      rdx, gword ptr [rsp+0x28]
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       mov      r8d, dword ptr [rsp+0x28]
-       mov      dword ptr [rbx+0x40], r8d
-       mov      r8d, dword ptr [rsp+0x2C]
-       mov      dword ptr [rbx+0x44], r8d
        mov      r8d, dword ptr [rsp+0x30]
+       mov      dword ptr [rbx+0x40], r8d
+       mov      r8d, dword ptr [rsp+0x34]
+       mov      dword ptr [rbx+0x44], r8d
+       mov      r8d, dword ptr [rsp+0x38]
        mov      dword ptr [rbx+0x48], r8d
        jmp      SHORT G_M58257_IG09
 						;; size=88 bbWeight=0.50 PerfScore 11.88
@@ -93,50 +96,55 @@ G_M58257_IG06:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {},
        mov      eax, 1
 						;; size=18 bbWeight=0.50 PerfScore 2.12
 G_M58257_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 56
+       add      rsp, 64
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 G_M58257_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref
        mov      dword ptr [rbx+0x08], -1
 						;; size=7 bbWeight=0.50 PerfScore 0.50
 G_M58257_IG09:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        lea      rsi, bword ptr [rbx+0x38]
        ; byrRegs +[rsi]
-       mov      r8d, dword ptr [rsi+0x0C]
+       mov      rdi, rsi
+       ; byrRegs +[rdi]
+       mov      r8d, dword ptr [rdi+0x0C]
        test     r8d, r8d
        je       SHORT G_M58257_IG10
        dec      r8d
-       mov      dword ptr [rsi+0x0C], r8d
-       lea      r8, bword ptr [rsi+0x10]
+       mov      dword ptr [rdi+0x0C], r8d
+       lea      r8, bword ptr [rdi+0x10]
        ; byrRegs +[r8]
-       mov      edx, dword ptr [rsi+0x08]
-       mov      rcx, gword ptr [rsi]
+       mov      edx, dword ptr [rdi+0x08]
+       mov      rcx, gword ptr [rdi]
        ; gcrRegs +[rcx]
        call     Internal.Metadata.NativeFormat.MdBinaryReader:Read(Internal.NativeFormat.NativeReader,uint,byref):uint
        ; gcrRegs -[rcx]
-       ; byrRegs -[r8]
+       ; byrRegs -[rsi r8]
        ; gcr arg pop 0
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rdi+0x08], eax
        jmp      SHORT G_M58257_IG06
-						;; size=40 bbWeight=0.50 PerfScore 6.75
-G_M58257_IG10:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rsi]
-       xor      eax, eax
-       mov      qword ptr [rbx+0x38], rax
-       mov      qword ptr [rbx+0x40], rax
-       mov      qword ptr [rbx+0x48], rax
-						;; size=14 bbWeight=0.50 PerfScore 1.62
-G_M58257_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+						;; size=43 bbWeight=0.50 PerfScore 6.88
+G_M58257_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0040 {rsi}, byref
        ; gcrRegs -[rbx]
-       add      rsp, 56
+       ; byrRegs -[rdi] +[rsi]
+       xor      eax, eax
+       mov      qword ptr [rsi], rax
+       mov      qword ptr [rsi+0x08], rax
+       mov      qword ptr [rsi+0x10], rax
+						;; size=13 bbWeight=0.50 PerfScore 1.62
+G_M58257_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rsi]
+       add      rsp, 64
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=0.50 PerfScore 1.38
 
-; Total bytes of code 226, prolog size 21, PerfScore 36.33, instruction count 68, allocated bytes for code 226 (MethodHash=dfc81c6e) for method System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
+; Total bytes of code 236, prolog size 22, PerfScore 38.21, instruction count 73, allocated bytes for code 236 (MethodHash=dfc81c6e) for method System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -144,11 +152,12 @@ Unwind Info:
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
-    CodeOffset: 0x06 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 6 * 8 + 8 = 56 = 0x38
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 7 * 8 + 8 = 64 = 0x40
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

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
|benchmarks.run.windows.x64.checked.mch|4,494|<span style="color:green">4,324</span>|<span style="color:red">125</span>|<span style="color:blue">45</span>|<span style="color:green">-145,133</span>|<span style="color:red">+2,750</span>|<span style="color:green">-0.4365%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|11,319|<span style="color:green">10,428</span>|<span style="color:red">782</span>|<span style="color:blue">109</span>|<span style="color:green">-657,763</span>|<span style="color:red">+9,315</span>|<span style="color:green">-0.7476%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|1,776|<span style="color:green">1,696</span>|<span style="color:red">71</span>|<span style="color:blue">9</span>|<span style="color:green">-44,788</span>|<span style="color:red">+2,208</span>|<span style="color:green">-0.3089%</span>|
|coreclr_tests.run.windows.x64.checked.mch|36,008|<span style="color:green">34,629</span>|<span style="color:red">1,084</span>|<span style="color:blue">295</span>|<span style="color:green">-1,560,151</span>|<span style="color:red">+13,886</span>|<span style="color:green">-1.9144%</span>|
|libraries.crossgen2.windows.x64.checked.mch|7,445|<span style="color:green">7,003</span>|<span style="color:red">273</span>|<span style="color:blue">169</span>|<span style="color:green">-107,376</span>|<span style="color:red">+2,078</span>|<span style="color:green">-0.0570%</span>|
|libraries.pmi.windows.x64.checked.mch|23,574|<span style="color:green">22,859</span>|<span style="color:red">522</span>|<span style="color:blue">193</span>|<span style="color:green">-517,864</span>|<span style="color:red">+6,610</span>|<span style="color:green">-0.2931%</span>|
|libraries_tests.run.windows.x64.Release.mch|46,493|<span style="color:green">43,858</span>|<span style="color:red">2,226</span>|<span style="color:blue">409</span>|<span style="color:green">-1,772,130</span>|<span style="color:red">+50,028</span>|<span style="color:green">-0.9774%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|42,624|<span style="color:green">39,778</span>|<span style="color:red">2,520</span>|<span style="color:blue">326</span>|<span style="color:green">-1,284,210</span>|<span style="color:red">+42,403</span>|<span style="color:green">-0.4262%</span>|
|realworld.run.windows.x64.checked.mch|3,685|<span style="color:green">3,555</span>|<span style="color:red">95</span>|<span style="color:blue">35</span>|<span style="color:green">-77,544</span>|<span style="color:red">+1,224</span>|<span style="color:green">-0.2886%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|2,333|<span style="color:green">2,214</span>|<span style="color:red">63</span>|<span style="color:blue">56</span>|<span style="color:green">-51,379</span>|<span style="color:red">+285</span>|<span style="color:green">-0.3720%</span>|
||179,751|<span style="color:green">170,344</span>|<span style="color:red">7,761</span>|<span style="color:blue">1,646</span>|<span style="color:green">-6,218,338</span>|<span style="color:red">+130,787</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,890|4|35,886|200 (0.55%)|181 (0.50%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,806|49,607|52,199|54 (0.05%)|29 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|55,002|37,307|17,695|39 (0.07%)|32 (0.06%)|
|coreclr_tests.run.windows.x64.checked.mch|581,441|347,882|233,559|2,630 (0.45%)|2,560 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,662|15|275,647|108 (0.04%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|312,767|6|312,761|1,442 (0.46%)|1,187 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|696,299|498,513|197,786|3,844 (0.55%)|2,657 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|318,620|21,946|296,674|2,275 (0.71%)|0 (0.00%)|
|realworld.run.windows.x64.checked.mch|36,655|3|36,652|246 (0.67%)|213 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,482|11|32,471|94 (0.29%)|41 (0.13%)|
||2,446,624|955,294|1,491,330|10,932 (0.44%)|6,965 (0.28%)|


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

Total bytes of base: 11536071 (overridden on cmd)
Total bytes of diff: 11393688 (overridden on cmd)
Total bytes of delta: -142383 (-1.23 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         630 : 35459.dasm (42.23% of base)
         205 : 23383.dasm (6.33% of base)
         163 : 7014.dasm (4.28% of base)
         140 : 22491.dasm (10.60% of base)
         103 : 16021.dasm (2.88% of base)
          74 : 2096.dasm (2.02% of base)
          74 : 20539.dasm (2.07% of base)
          67 : 2943.dasm (4.74% of base)
          67 : 19663.dasm (4.74% of base)
          59 : 9745.dasm (1.37% of base)
          59 : 15417.dasm (1.37% of base)
          52 : 31006.dasm (3.06% of base)
          36 : 21360.dasm (5.29% of base)
          33 : 16814.dasm (5.95% of base)
          33 : 7249.dasm (5.95% of base)
          31 : 6061.dasm (6.18% of base)
          31 : 14384.dasm (6.18% of base)
          29 : 20741.dasm (2.02% of base)
          29 : 35092.dasm (6.11% of base)
          28 : 21701.dasm (1.76% of base)

Top file improvements (bytes):
       -2769 : 18840.dasm (-36.52% of base)
       -2769 : 10529.dasm (-36.52% of base)
       -1317 : 22322.dasm (-12.65% of base)
       -1137 : 5951.dasm (-11.60% of base)
       -1083 : 5952.dasm (-10.87% of base)
       -1038 : 7449.dasm (-9.10% of base)
       -1006 : 28439.dasm (-8.96% of base)
        -918 : 5958.dasm (-8.85% of base)
        -913 : 5938.dasm (-7.95% of base)
        -854 : 5948.dasm (-7.22% of base)
        -840 : 5932.dasm (-13.07% of base)
        -801 : 20821.dasm (-11.96% of base)
        -763 : 9693.dasm (-6.51% of base)
        -756 : 20813.dasm (-12.27% of base)
        -756 : 20822.dasm (-12.53% of base)
        -718 : 9696.dasm (-11.55% of base)
        -695 : 30909.dasm (-16.05% of base)
        -695 : 29503.dasm (-16.10% of base)
        -636 : 23242.dasm (-14.80% of base)
        -588 : 22095.dasm (-13.59% of base)

86 total files with Code Size differences (58 improved, 28 regressed), 20 unchanged.

Top method regressions (bytes):
         630 (42.23% of base) : 35459.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
         205 ( 6.33% of base) : 23383.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (FullOpts)
         163 ( 4.28% of base) : 7014.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (FullOpts)
         140 (10.60% of base) : 22491.dasm - AssignRect:first_assignments(int[,],short[,]):int (FullOpts)
         103 ( 2.88% of base) : 16021.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (FullOpts)
          74 ( 2.02% of base) : 2096.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[MicroBenchmarks.Serializers.LargeStructWithProperties]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (FullOpts)
          74 ( 2.07% of base) : 20539.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[MicroBenchmarks.Serializers.SimpleStructWithProperties]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (FullOpts)
          67 ( 4.74% of base) : 2943.dasm - System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[ubyte],ubyte,ubyte):this (FullOpts)
          67 ( 4.74% of base) : 19663.dasm - System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[ubyte],ubyte,ubyte):this (FullOpts)
          59 ( 1.37% of base) : 9745.dasm - System.Diagnostics.Perf_Activity:.cctor() (FullOpts)
          59 ( 1.37% of base) : 15417.dasm - System.Diagnostics.Perf_Activity:.cctor() (FullOpts)
          52 ( 3.06% of base) : 31006.dasm - Benchstone.BenchF.Romber:Test():ubyte:this (FullOpts)
          36 ( 5.29% of base) : 21360.dasm - System.Numerics.BigIntegerCalculator:PowCore(System.Span`1[uint],int,uint,System.ReadOnlySpan`1[uint],System.Span`1[uint],int,System.Span`1[uint]):System.Span`1[uint] (FullOpts)
          33 ( 5.95% of base) : 16814.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
          33 ( 5.95% of base) : 7249.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
          31 ( 6.18% of base) : 6061.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
          31 ( 6.18% of base) : 14384.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
          29 ( 6.11% of base) : 35092.dasm - Benchstone.MDBenchI.MDMidpoint:Test():ubyte:this (FullOpts)
          29 ( 2.02% of base) : 20741.dasm - System.Collections.Tests.Perf_PriorityQueue`2[System.Guid,System.Guid]:K_Max_Elements():this (FullOpts)
          28 ( 1.76% of base) : 21701.dasm - AssignJagged:second_assignments(int[][],short[][]) (FullOpts)

Top method improvements (bytes):
       -2769 (-36.52% of base) : 18840.dasm - System.Reflection.Emit.CustomAttributeBuilder:.ctor(System.Reflection.ConstructorInfo,System.Object[],System.Reflection.PropertyInfo[],System.Object[],System.Reflection.FieldInfo[],System.Object[]):this (FullOpts)
       -2769 (-36.52% of base) : 10529.dasm - System.Reflection.Emit.CustomAttributeBuilder:.ctor(System.Reflection.ConstructorInfo,System.Object[],System.Reflection.PropertyInfo[],System.Object[],System.Reflection.FieldInfo[],System.Object[]):this (FullOpts)
       -1317 (-12.65% of base) : 22322.dasm - MessagePack.Formatters.MicroBenchmarks_Serializers_MyEventsListerItemFormatter2:Serialize(byref,int,MicroBenchmarks.Serializers.MyEventsListerItem,MessagePack.IFormatterResolver):int:this (FullOpts)
       -1137 (-11.60% of base) : 5951.dasm - Utf8Json.Internal.NumberConverter:WriteInt64(byref,int,long):int (FullOpts)
       -1083 (-10.87% of base) : 5952.dasm - Utf8Json.JsonWriter:WriteInt64(long):this (FullOpts)
       -1038 (-9.10% of base) : 7449.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_MyEventsListerItemFormatter2:Serialize(byref,MicroBenchmarks.Serializers.MyEventsListerItem,Utf8Json.IJsonFormatterResolver):this (FullOpts)
       -1006 (-8.96% of base) : 28439.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_LocationFormatter1:Serialize(byref,MicroBenchmarks.Serializers.Location,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -918 (-8.85% of base) : 5958.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_CampaignSummaryViewModelFormatter3:Serialize(byref,MicroBenchmarks.Serializers.CampaignSummaryViewModel,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -913 (-7.95% of base) : 5938.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_ActiveOrUpcomingEventFormatter2:Serialize(byref,MicroBenchmarks.Serializers.ActiveOrUpcomingEvent,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -854 (-7.22% of base) : 5948.dasm - Utf8Json.Formatters.ISO8601DateTimeOffsetFormatter:Serialize(byref,System.DateTimeOffset,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -840 (-13.07% of base) : 5932.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_IndexViewModelFormatter1:Serialize(byref,MicroBenchmarks.Serializers.IndexViewModel,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -801 (-11.96% of base) : 20821.dasm - MessagePack.Formatters.DateTimeOffsetFormatter:Serialize(byref,int,System.DateTimeOffset,MessagePack.IFormatterResolver):int:this (FullOpts)
        -763 (-6.51% of base) : 9693.dasm - Utf8Json.Formatters.ISO8601DateTimeFormatter:Serialize(byref,System.DateTime,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -756 (-12.27% of base) : 20813.dasm - MessagePack.Formatters.MicroBenchmarks_Serializers_ActiveOrUpcomingEventFormatter2:Serialize(byref,int,MicroBenchmarks.Serializers.ActiveOrUpcomingEvent,MessagePack.IFormatterResolver):int:this (FullOpts)
        -756 (-12.53% of base) : 20822.dasm - MessagePack.Formatters.MicroBenchmarks_Serializers_CampaignSummaryViewModelFormatter3:Serialize(byref,int,MicroBenchmarks.Serializers.CampaignSummaryViewModel,MessagePack.IFormatterResolver):int:this (FullOpts)
        -718 (-11.55% of base) : 9696.dasm - Utf8Json.Formatters.DictionaryFormatterBase`5[int,System.__Canon,System.__Canon,System.Collections.Generic.Dictionary`2+Enumerator[int,System.__Canon],System.__Canon]:Serialize(byref,System.__Canon,Utf8Json.IJsonFormatterResolver):this (FullOpts)
        -695 (-16.10% of base) : 29503.dasm - System.Memory.Slice`1[ubyte]:MemoryStartLengthSpan():System.Memory`1[ubyte]:this (FullOpts)
        -695 (-16.05% of base) : 30909.dasm - System.Memory.Slice`1[ubyte]:ReadOnlyMemoryStartLengthSpan():System.ReadOnlyMemory`1[ubyte]:this (FullOpts)
        -636 (-14.80% of base) : 23242.dasm - MessagePack.Formatters.Int32Formatter:Serialize(byref,int,int,MessagePack.IFormatterResolver):int:this (FullOpts)
        -588 (-13.59% of base) : 22095.dasm - Utf8Json.Formatters.MicroBenchmarks_Serializers_LoginViewModelFormatter1:Serialize(byref,MicroBenchmarks.Serializers.LoginViewModel,Utf8Json.IJsonFormatterResolver):this (FullOpts)

Top method regressions (percentages):
         630 (42.23% of base) : 35459.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
           4 (13.79% of base) : 26272.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
         140 (10.60% of base) : 22491.dasm - AssignRect:first_assignments(int[,],short[,]):int (FullOpts)
         205 ( 6.33% of base) : 23383.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (FullOpts)
          31 ( 6.18% of base) : 6061.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
          31 ( 6.18% of base) : 14384.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
          29 ( 6.11% of base) : 35092.dasm - Benchstone.MDBenchI.MDMidpoint:Test():ubyte:this (FullOpts)
          33 ( 5.95% of base) : 16814.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
          33 ( 5.95% of base) : 7249.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
          36 ( 5.29% of base) : 21360.dasm - System.Numerics.BigIntegerCalculator:PowCore(System.Span`1[uint],int,uint,System.ReadOnlySpan`1[uint],System.Span`1[uint],int,System.Span`1[uint]):System.Span`1[uint] (FullOpts)
          67 ( 4.74% of base) : 2943.dasm - System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[ubyte],ubyte,ubyte):this (FullOpts)
          67 ( 4.74% of base) : 19663.dasm - System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[ubyte],ubyte,ubyte):this (FullOpts)
          16 ( 4.61% of base) : 6022.dasm - System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (FullOpts)
         163 ( 4.28% of base) : 7014.dasm - System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (FullOpts)
          17 ( 3.78% of base) : 7803.dasm - System.Environment:get_CurrentDirectoryCore():System.String (FullOpts)
          15 ( 3.70% of base) : 19903.dasm - System.Net.Sockets.SocketAddressExtensions:Equals(System.Net.SocketAddress,System.Net.EndPoint):ubyte (FullOpts)
          13 ( 3.46% of base) : 14731.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (FullOpts)
          13 ( 3.46% of base) : 6380.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (FullOpts)
          10 ( 3.36% of base) : 13064.dasm - System.Text.Ascii:ChangeCase[ushort,ushort,System.Text.Ascii+ToUpperConversion](System.ReadOnlySpan`1[ushort],System.Span`1[ushort],byref):int (FullOpts)
          10 ( 3.36% of base) : 707.dasm - System.Text.Ascii:ChangeCase[ushort,ushort,System.Text.Ascii+ToUpperConversion](System.ReadOnlySpan`1[ushort],System.Span`1[ushort],byref):int (FullOpts)

Top method improvements (percentages):
         -50 (-86.21% of base) : 4199.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
         -50 (-86.21% of base) : 19698.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
         -50 (-86.21% of base) : 4201.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
         -50 (-86.21% of base) : 19700.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
        -211 (-76.17% of base) : 27295.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
         -47 (-59.49% of base) : 12418.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
         -47 (-59.49% of base) : 61.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 298.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 12655.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 317.dasm - System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 12674.dasm - System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 12654.dasm - System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 297.dasm - System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 320.dasm - System.RuntimeType:get_IsNullableOfT():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 12677.dasm - System.RuntimeType:get_IsNullableOfT():ubyte:this (FullOpts)
         -47 (-55.95% of base) : 12429.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)
         -47 (-55.95% of base) : 72.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)
         -46 (-54.76% of base) : 10208.dasm - System.Buffers.AsciiCharSearchValues`1[System.Buffers.IndexOfAnyAsciiSearcher+Default]:ContainsCore(ushort):ubyte:this (FullOpts)
         -47 (-54.65% of base) : 13157.dasm - System.RuntimeType:get_IsActualEnum():ubyte:this (FullOpts)
         -47 (-54.65% of base) : 775.dasm - System.RuntimeType:IsDelegate():ubyte:this (FullOpts)

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

Total bytes of base: 36055124 (overridden on cmd)
Total bytes of diff: 35406676 (overridden on cmd)
Total bytes of delta: -648448 (-1.80 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         654 : 96567.dasm (43.66% of base)
         335 : 94061.dasm (21.71% of base)
         310 : 95629.dasm (19.81% of base)
         138 : 68264.dasm (7.67% of base)
          97 : 45100.dasm (4.64% of base)
          70 : 97940.dasm (3.62% of base)
          66 : 41935.dasm (3.57% of base)
          48 : 91981.dasm (4.11% of base)
          48 : 36006.dasm (1.52% of base)
          36 : 83212.dasm (2.43% of base)
          36 : 84236.dasm (2.43% of base)
          36 : 88443.dasm (2.43% of base)
          36 : 91418.dasm (2.43% of base)
          36 : 95112.dasm (3.42% of base)
          36 : 80791.dasm (2.43% of base)
          36 : 95202.dasm (3.17% of base)
          36 : 96834.dasm (2.43% of base)
          34 : 60606.dasm (3.43% of base)
          31 : 26203.dasm (0.97% of base)
          31 : 8434.dasm (0.98% of base)

Top file improvements (bytes):
       -2753 : 29500.dasm (-38.69% of base)
       -2726 : 99697.dasm (-38.50% of base)
       -2557 : 87477.dasm (-24.48% of base)
       -2391 : 80133.dasm (-42.16% of base)
       -2365 : 76832.dasm (-41.90% of base)
       -2095 : 38354.dasm (-33.05% of base)
       -2046 : 41668.dasm (-32.98% of base)
       -2046 : 84116.dasm (-32.96% of base)
       -2040 : 44420.dasm (-32.91% of base)
       -1962 : 39523.dasm (-31.10% of base)
       -1942 : 83231.dasm (-31.40% of base)
       -1814 : 29219.dasm (-35.09% of base)
       -1791 : 37397.dasm (-34.76% of base)
       -1543 : 75811.dasm (-24.36% of base)
       -1542 : 55697.dasm (-24.34% of base)
       -1542 : 73708.dasm (-24.34% of base)
       -1447 : 48682.dasm (-23.47% of base)
       -1447 : 26246.dasm (-23.47% of base)
       -1447 : 51769.dasm (-23.47% of base)
       -1447 : 85466.dasm (-23.47% of base)

99 total files with Code Size differences (62 improved, 37 regressed), 20 unchanged.

Top method regressions (bytes):
         654 (43.66% of base) : 96567.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         335 (21.71% of base) : 94061.dasm - System.Text.Unicode.Utf8Utility:GetPointerToFirstInvalidByte(ulong,int,byref,byref):ulong (Tier1-OSR)
         310 (19.81% of base) : 95629.dasm - System.Text.Unicode.Utf8Utility:GetPointerToFirstInvalidByte(ulong,int,byref,byref):ulong (Tier1-OSR)
         138 ( 7.67% of base) : 68264.dasm - Microsoft.CodeAnalysis.CSharp.BoundConversion:Update(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Conversion,ubyte,ubyte,ubyte,Microsoft.CodeAnalysis.ConstantValue,Microsoft.CodeAnalysis.CSharp.ConversionGroup,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):Microsoft.CodeAnalysis.CSharp.BoundConversion:this (Tier1)
          97 ( 4.64% of base) : 45100.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
          70 ( 3.62% of base) : 97940.dasm - System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
          66 ( 3.57% of base) : 41935.dasm - AssignJagged:second_assignments(int[][],short[][]) (Tier1-OSR)
          48 ( 4.11% of base) : 91981.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:SwapIfGreater(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,int) (Tier1)
          48 ( 1.52% of base) : 36006.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
          36 ( 3.42% of base) : 95112.dasm - System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],System.__Canon]:TryGetValue(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1+NodeCacheKey[ulong],byref):ubyte:this (Tier1)
          36 ( 2.43% of base) : 83212.dasm - System.Diagnostics.Tracing.EventSource:InitializeProviderMetadata():this (Tier1)
          36 ( 2.43% of base) : 84236.dasm - System.Diagnostics.Tracing.EventSource:InitializeProviderMetadata():this (Tier1)
          36 ( 2.43% of base) : 88443.dasm - System.Diagnostics.Tracing.EventSource:InitializeProviderMetadata():this (Tier1)
          36 ( 2.43% of base) : 91418.dasm - System.Diagnostics.Tracing.EventSource:InitializeProviderMetadata():this (Tier1)
          36 ( 2.43% of base) : 80791.dasm - System.Diagnostics.Tracing.EventSource:InitializeProviderMetadata():this (Tier1)
          36 ( 2.43% of base) : 96834.dasm - System.Diagnostics.Tracing.EventSource:InitializeProviderMetadata():this (Tier1)
          36 ( 3.17% of base) : 95202.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong]:CreateSingleton(ulong):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
          34 ( 3.43% of base) : 60606.dasm - System.Diagnostics.Tracing.EventListener:AddEventSource(System.Diagnostics.Tracing.EventSource) (Tier1)
          31 ( 0.97% of base) : 26203.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
          31 ( 0.98% of base) : 8434.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)

Top method improvements (bytes):
       -2753 (-38.69% of base) : 29500.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.BigStruct]:IntroSort(System.Span`1[System.Collections.BigStruct],int,System.Comparison`1[System.Collections.BigStruct]) (Tier1)
       -2726 (-38.50% of base) : 99697.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.BigStruct]:IntroSort(System.Span`1[System.Collections.BigStruct],int,System.Comparison`1[System.Collections.BigStruct]) (Tier1)
       -2557 (-24.48% of base) : 87477.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -2391 (-42.16% of base) : 80133.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int,System.Comparison`1[System.Collections.IntStruct]) (Tier1)
       -2365 (-41.90% of base) : 76832.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int,System.Comparison`1[System.Collections.IntStruct]) (Tier1)
       -2095 (-33.05% of base) : 38354.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -2046 (-32.98% of base) : 41668.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -2046 (-32.96% of base) : 84116.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -2040 (-32.91% of base) : 44420.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -1962 (-31.10% of base) : 39523.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -1942 (-31.40% of base) : 83231.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -1814 (-35.09% of base) : 29219.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -1791 (-34.76% of base) : 37397.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
       -1543 (-24.36% of base) : 75811.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -1542 (-24.34% of base) : 55697.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -1542 (-24.34% of base) : 73708.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -1447 (-23.47% of base) : 48682.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -1447 (-23.47% of base) : 26246.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -1447 (-23.47% of base) : 51769.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)
       -1447 (-23.47% of base) : 85466.dasm - System.Collections.Generic.ArraySortHelper`1[System.__Canon]:IntroSort(System.Span`1[System.__Canon],int,System.Comparison`1[System.__Canon]) (Tier1)

Top method regressions (percentages):
         654 (43.66% of base) : 96567.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         335 (21.71% of base) : 94061.dasm - System.Text.Unicode.Utf8Utility:GetPointerToFirstInvalidByte(ulong,int,byref,byref):ulong (Tier1-OSR)
         310 (19.81% of base) : 95629.dasm - System.Text.Unicode.Utf8Utility:GetPointerToFirstInvalidByte(ulong,int,byref,byref):ulong (Tier1-OSR)
         138 ( 7.67% of base) : 68264.dasm - Microsoft.CodeAnalysis.CSharp.BoundConversion:Update(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Conversion,ubyte,ubyte,ubyte,Microsoft.CodeAnalysis.ConstantValue,Microsoft.CodeAnalysis.CSharp.ConversionGroup,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol):Microsoft.CodeAnalysis.CSharp.BoundConversion:this (Tier1)
           3 ( 5.56% of base) : 69287.dasm - System.Reflection.PortableExecutable.ManagedTextSection:get_SizeOfImportTable():int:this (Tier1)
          12 ( 5.06% of base) : 101575.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
          12 ( 5.06% of base) : 86573.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
          12 ( 5.06% of base) : 99341.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
          12 ( 5.06% of base) : 88486.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
          12 ( 5.06% of base) : 29685.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
          12 ( 5.06% of base) : 94342.dasm - System.Threading.Tasks.ValueTask:AsTask():System.Threading.Tasks.Task:this (Tier1)
          30 ( 5.03% of base) : 76344.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          30 ( 5.03% of base) : 47578.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          30 ( 5.03% of base) : 74333.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          30 ( 5.03% of base) : 77894.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          30 ( 5.03% of base) : 84168.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          30 ( 5.03% of base) : 98833.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          30 ( 5.03% of base) : 45139.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          29 ( 4.85% of base) : 54296.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)
          29 ( 4.85% of base) : 77912.dasm - System.Collections.Generic.ObjectEqualityComparer`1[System.__Canon]:IndexOf(System.__Canon[],System.__Canon,int,int):int:this (Tier1-OSR)

Top method improvements (percentages):
         -73 (-66.97% of base) : 44624.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 37640.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 44001.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 72911.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 19921.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 50564.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 73001.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 100532.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 86748.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 91674.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 97613.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 40185.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 94956.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 44225.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 86317.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 25690.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 45493.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 74401.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 81002.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -73 (-66.97% of base) : 87836.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)

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

Total bytes of base: 12742496 (overridden on cmd)
Total bytes of diff: 12699916 (overridden on cmd)
Total bytes of delta: -42580 (-0.33 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         630 : 53708.dasm (42.23% of base)
         316 : 53707.dasm (22.36% of base)
         268 : 30388.dasm (9.26% of base)
         205 : 30389.dasm (6.33% of base)
         140 : 29386.dasm (10.60% of base)
          76 : 10795.dasm (6.66% of base)
          73 : 29384.dasm (3.67% of base)
          69 : 29381.dasm (5.05% of base)
          49 : 47532.dasm (3.84% of base)
          28 : 27935.dasm (1.76% of base)
          24 : 14268.dasm (1.10% of base)
          22 : 49921.dasm (1.21% of base)
          21 : 44497.dasm (1.54% of base)
          20 : 30536.dasm (0.80% of base)
          19 : 49971.dasm (5.26% of base)
          17 : 6768.dasm (3.78% of base)
          17 : 13542.dasm (1.20% of base)
          16 : 8795.dasm (4.61% of base)
          16 : 26538.dasm (0.93% of base)
          13 : 8205.dasm (3.46% of base)

Top file improvements (bytes):
        -500 : 25169.dasm (-11.32% of base)
        -484 : 47887.dasm (-10.63% of base)
        -479 : 54988.dasm (-6.67% of base)
        -467 : 50051.dasm (-16.80% of base)
        -448 : 31661.dasm (-10.16% of base)
        -447 : 28785.dasm (-10.58% of base)
        -411 : 42524.dasm (-17.31% of base)
        -337 : 42519.dasm (-14.49% of base)
        -334 : 28804.dasm (-10.97% of base)
        -277 : 5169.dasm (-3.30% of base)
        -270 : 18079.dasm (-0.88% of base)
        -239 : 34454.dasm (-6.08% of base)
        -232 : 8600.dasm (-5.30% of base)
        -225 : 18648.dasm (-17.32% of base)
        -221 : 15887.dasm (-8.72% of base)
        -221 : 32806.dasm (-9.53% of base)
        -221 : 32827.dasm (-11.12% of base)
        -220 : 53232.dasm (-45.55% of base)
        -212 : 49211.dasm (-3.72% of base)
        -205 : 35579.dasm (-16.49% of base)

81 total files with Code Size differences (55 improved, 26 regressed), 9 unchanged.

Top method regressions (bytes):
         630 (42.23% of base) : 53708.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         316 (22.36% of base) : 53707.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
         268 ( 9.26% of base) : 30388.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1-OSR)
         205 ( 6.33% of base) : 30389.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1)
         140 (10.60% of base) : 29386.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1)
          76 ( 6.66% of base) : 10795.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1-OSR)
          73 ( 3.67% of base) : 29384.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
          69 ( 5.05% of base) : 29381.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1-OSR)
          49 ( 3.84% of base) : 47532.dasm - System.IO.FileSystem:RemoveDirectoryRecursive(System.String,byref,ubyte) (Tier1-OSR)
          28 ( 1.76% of base) : 27935.dasm - AssignJagged:second_assignments(int[][],short[][]) (Tier1)
          24 ( 1.10% of base) : 14268.dasm - System.Numerics.BigIntegerCalculator:Gcd(System.Span`1[uint],System.Span`1[uint]) (Tier1-OSR)
          22 ( 1.21% of base) : 49921.dasm - System.Text.RegularExpressions.RegexLWCGCompiler:FactoryInstanceFromCode(System.String,System.Text.RegularExpressions.RegexTree,int,ubyte):System.Text.RegularExpressions.RegexRunnerFactory:this (Tier1)
          21 ( 1.54% of base) : 44497.dasm - System.Globalization.Normalization:NlsNormalize(System.String,int):System.String (Tier0-FullOpts)
          20 ( 0.80% of base) : 30536.dasm - System.Text.Json.Tests.Perf_Segment:ReadMultiSegmentSequenceUsingSpan(int):this (Tier1-OSR)
          19 ( 5.26% of base) : 49971.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]:TryMatch(byref,int,byref,uint,byref):ubyte:this (Tier1)
          17 ( 1.20% of base) : 13542.dasm - Microsoft.Extensions.Logging.LogValuesFormatter:.ctor(System.String):this (Tier0-FullOpts)
          17 ( 3.78% of base) : 6768.dasm - System.Environment:get_CurrentDirectoryCore():System.String (Tier0-FullOpts)
          16 ( 0.93% of base) : 26538.dasm - System.Formats.Tar.TarHeader:GenerateExtendedAttributesDataStream(System.Collections.Generic.Dictionary`2[System.String,System.String]):System.IO.MemoryStream (Tier0-FullOpts)
          16 ( 4.61% of base) : 8795.dasm - System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (Tier1)
          13 ( 3.46% of base) : 8205.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (Tier0-FullOpts)

Top method improvements (bytes):
        -500 (-11.32% of base) : 25169.dasm - (dynamicClass):ReadLocationFromXml(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.XmlObjectSerializerReadContext,System.Xml.XmlDictionaryString[],System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -484 (-10.63% of base) : 47887.dasm - (dynamicClass):ReadLocationFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -479 (-6.67% of base) : 54988.dasm - (dynamicClass):ReadMyEventsListerItemFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -467 (-16.80% of base) : 50051.dasm - MicroBenchmarks.Serializers.MyEventsListerItem:proto_8(byref,MicroBenchmarks.Serializers.MyEventsListerItem):MicroBenchmarks.Serializers.MyEventsListerItem (FullOpts)
        -448 (-10.16% of base) : 31661.dasm - (dynamicClass):ReadMyEventsListerItemFromXml(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.XmlObjectSerializerReadContext,System.Xml.XmlDictionaryString[],System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -447 (-10.58% of base) : 28785.dasm - (dynamicClass):ReadActiveOrUpcomingEventFromXml(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.XmlObjectSerializerReadContext,System.Xml.XmlDictionaryString[],System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -411 (-17.31% of base) : 42524.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1)
        -337 (-14.49% of base) : 42519.dasm - Benchstone.BenchI.Puzzle:DoIt():ubyte:this (Tier1-OSR)
        -334 (-10.97% of base) : 28804.dasm - (dynamicClass):ReadCampaignSummaryViewModelFromXml(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.XmlObjectSerializerReadContext,System.Xml.XmlDictionaryString[],System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -277 (-3.30% of base) : 5169.dasm - System.Text.RegularExpressions.RegexCompiler:EmitMatchCharacterClass(System.String):this (Tier0-FullOpts)
        -270 (-0.88% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
        -239 (-6.08% of base) : 34454.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:ScanSyntaxToken(byref):this (Tier1)
        -232 (-5.30% of base) : 8600.dasm - System.Net.Security.SslStream+<ForceAuthenticationAsync>d__158`1[System.Net.Security.AsyncReadWriteAdapter]:MoveNext():this (Tier1)
        -225 (-17.32% of base) : 18648.dasm - System.Reflection.TypeNameParser:GetTypeHelper(ulong,System.Reflection.RuntimeAssembly,ubyte,ubyte):System.RuntimeType (Tier1)
        -221 (-9.53% of base) : 32806.dasm - MicroBenchmarks.Serializers.ActiveOrUpcomingEvent:proto_8(byref,MicroBenchmarks.Serializers.ActiveOrUpcomingEvent):MicroBenchmarks.Serializers.ActiveOrUpcomingEvent (FullOpts)
        -221 (-11.12% of base) : 32827.dasm - MicroBenchmarks.Serializers.CampaignSummaryViewModel:proto_10(byref,MicroBenchmarks.Serializers.CampaignSummaryViewModel):MicroBenchmarks.Serializers.CampaignSummaryViewModel (FullOpts)
        -221 (-8.72% of base) : 15887.dasm - MicroBenchmarks.Serializers.Location:proto_2(byref,MicroBenchmarks.Serializers.Location):MicroBenchmarks.Serializers.Location (FullOpts)
        -220 (-45.55% of base) : 53232.dasm - ProtoBuf.ProtoReader+State:ReadInt32():int:this (FullOpts)
        -212 (-3.72% of base) : 49211.dasm - (dynamicClass):ReadActiveOrUpcomingEventFromJson(System.Runtime.Serialization.XmlReaderDelegator,System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson,System.Xml.XmlDictionaryString,System.Xml.XmlDictionaryString[]):System.Object (FullOpts)
        -205 (-16.49% of base) : 35579.dasm - System.Reflection.TypeNameParser:GetType(System.String,System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly],System.Func`4[System.Reflection.Assembly,System.String,ubyte,System.Type],System.Reflection.Assembly,ubyte,ubyte,ubyte):System.Type (Tier1)

Top method regressions (percentages):
         630 (42.23% of base) : 53708.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1)
         316 (22.36% of base) : 53707.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (Tier1-OSR)
         140 (10.60% of base) : 29386.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1)
         268 ( 9.26% of base) : 30388.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1-OSR)
          76 ( 6.66% of base) : 10795.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]:IndexOf(byref,int):int:this (Tier1-OSR)
         205 ( 6.33% of base) : 30389.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (Tier1)
          19 ( 5.26% of base) : 49971.dasm - System.Buffers.SingleStringSearchValuesThreeChars`2[System.Buffers.StringSearchValuesHelper+ValueLength8OrLongerOrUnknown,System.Buffers.StringSearchValuesHelper+CaseSensitive]:TryMatch(byref,int,byref,uint,byref):ubyte:this (Tier1)
          69 ( 5.05% of base) : 29381.dasm - AssignRect:first_assignments(int[,],short[,]):int (Tier1-OSR)
          16 ( 4.61% of base) : 8795.dasm - System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (Tier1)
          49 ( 3.84% of base) : 47532.dasm - System.IO.FileSystem:RemoveDirectoryRecursive(System.String,byref,ubyte) (Tier1-OSR)
          17 ( 3.78% of base) : 6768.dasm - System.Environment:get_CurrentDirectoryCore():System.String (Tier0-FullOpts)
          73 ( 3.67% of base) : 29384.dasm - AssignRect:second_assignments(int[,],short[,]) (Tier1-OSR)
          13 ( 3.46% of base) : 8205.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (Tier0-FullOpts)
          10 ( 3.36% of base) : 47205.dasm - System.Text.Ascii:ChangeCase[ushort,ushort,System.Text.Ascii+ToUpperConversion](System.ReadOnlySpan`1[ushort],System.Span`1[ushort],byref):int (Tier1)
          10 ( 3.01% of base) : 44225.dasm - System.IO.BinaryReader:ReadBytes(int):ubyte[]:this (Tier1)
          28 ( 1.76% of base) : 27935.dasm - AssignJagged:second_assignments(int[][],short[][]) (Tier1)
           5 ( 1.63% of base) : 8818.dasm - System.Net.Sockets.SocketAddressExtensions:GetPort(System.Net.SocketAddress):int (Tier1)
          21 ( 1.54% of base) : 44497.dasm - System.Globalization.Normalization:NlsNormalize(System.String,int):System.String (Tier0-FullOpts)
          12 ( 1.44% of base) : 29195.dasm - System.Numerics.BigIntegerCalculator:PowCore(System.Span`1[uint],int,System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint],int,System.Span`1[uint]):System.Span`1[uint] (Tier1-OSR)
           4 ( 1.39% of base) : 2612.dasm - System.Number:FormatDouble(double,System.String,System.Globalization.NumberFormatInfo):System.String (Tier1)

Top method improvements (percentages):
         -50 (-86.21% of base) : 26329.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
         -47 (-59.49% of base) : 2262.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-58.02% of base) : 4071.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (Tier1)
         -47 (-58.02% of base) : 4140.dasm - System.RuntimeType:get_IsByRefLike():ubyte:this (Tier1)
         -47 (-58.02% of base) : 2664.dasm - System.RuntimeType:get_IsInterface():ubyte:this (Tier1)
         -47 (-58.02% of base) : 4183.dasm - System.RuntimeType:get_IsNullableOfT():ubyte:this (Tier1)
         -47 (-55.95% of base) : 2273.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (Tier1)
         -47 (-54.65% of base) : 18644.dasm - System.RuntimeType:get_IsActualEnum():ubyte:this (Tier1)
         -47 (-54.65% of base) : 2708.dasm - System.RuntimeType:IsDelegate():ubyte:this (Tier1)
         -47 (-51.65% of base) : 25490.dasm - System.RuntimeType:get_IsConstructedGenericType():ubyte:this (Tier1)
         -45 (-46.88% of base) : 30523.dasm - System.Char:GetUnicodeCategory(ushort):int (Tier1)
        -220 (-45.55% of base) : 53232.dasm - ProtoBuf.ProtoReader+State:ReadInt32():int:this (FullOpts)
         -50 (-44.25% of base) : 40002.dasm - Roslyn.Utilities.StringTable:TextEqualsASCII(System.String,System.ReadOnlySpan`1[ubyte]):ubyte (Tier1)
        -169 (-43.90% of base) : 53959.dasm - System.Dynamic.Utils.TypeExtensions:MatchesArgumentTypes(System.Reflection.MethodInfo,System.Type[]):ubyte (Tier1)
         -48 (-42.86% of base) : 23210.dasm - System.String:Equals(System.String):ubyte:this (Tier1)
         -43 (-41.35% of base) : 5589.dasm - System.RuntimeType:IsValueTypeImpl():ubyte:this (Tier1)
         -38 (-41.30% of base) : 2308.dasm - System.Char:IsWhiteSpace(ushort):ubyte (Tier1)
        -115 (-41.22% of base) : 5593.dasm - System.MemoryExtensions:Trim(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ushort] (Tier1)
         -48 (-41.03% of base) : 620.dasm - System.String:Equals(System.String,System.String):ubyte (Tier1)
         -42 (-40.00% of base) : 40197.dasm - Roslyn.Utilities.StringOrdinalComparer:Equals(System.String,System.String):ubyte (Tier1)

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

Total bytes of base: 388277212 (overridden on cmd)
Total bytes of diff: 386730947 (overridden on cmd)
Total bytes of delta: -1546265 (-0.40 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         630 : 197503.dasm (42.23% of base)
         451 : 576726.dasm (8.12% of base)
         247 : 580426.dasm (4.73% of base)
         205 : 197536.dasm (6.33% of base)
         183 : 311479.dasm (1.23% of base)
         164 : 233456.dasm (0.87% of base)
         156 : 308811.dasm (7.85% of base)
         140 : 196037.dasm (10.60% of base)
         136 : 576723.dasm (1.92% of base)
         126 : 219470.dasm (3.02% of base)
         110 : 311492.dasm (0.85% of base)
         109 : 233461.dasm (0.61% of base)
          97 : 574195.dasm (5.79% of base)
          88 : 189772.dasm (3.03% of base)
          80 : 580424.dasm (1.13% of base)
          80 : 233648.dasm (5.26% of base)
          78 : 311277.dasm (2.72% of base)
          77 : 189778.dasm (2.67% of base)
          74 : 174831.dasm (1.78% of base)
          74 : 174595.dasm (1.79% of base)

Top file improvements (bytes):
       -3022 : 5026.dasm (-76.92% of base)
       -3022 : 5035.dasm (-76.92% of base)
       -2677 : 233544.dasm (-2.62% of base)
       -2357 : 233201.dasm (-2.55% of base)
       -2035 : 233480.dasm (-1.98% of base)
       -1976 : 232908.dasm (-80.85% of base)
       -1976 : 232905.dasm (-80.85% of base)
       -1927 : 233862.dasm (-2.03% of base)
       -1812 : 5036.dasm (-62.89% of base)
       -1812 : 5027.dasm (-62.89% of base)
       -1773 : 233512.dasm (-1.89% of base)
       -1502 : 235720.dasm (-44.73% of base)
       -1502 : 235718.dasm (-44.73% of base)
       -1493 : 233208.dasm (-1.65% of base)
       -1474 : 580810.dasm (-12.22% of base)
       -1440 : 19701.dasm (-9.22% of base)
       -1436 : 233215.dasm (-1.53% of base)
       -1326 : 233448.dasm (-1.40% of base)
       -1284 : 174141.dasm (-29.72% of base)
       -1136 : 233194.dasm (-1.31% of base)

93 total files with Code Size differences (55 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
         630 (42.23% of base) : 197503.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
         451 ( 8.12% of base) : 576726.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.DevirtualizationManager:ResolveVirtualMethod(Internal.TypeSystem.MethodDesc,Internal.TypeSystem.DefType,byref):Internal.TypeSystem.MethodDesc:this (Tier1)
         247 ( 4.73% of base) : 580426.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.DevirtualizationManager:ResolveVirtualMethod(Internal.TypeSystem.MethodDesc,Internal.TypeSystem.DefType,byref):Internal.TypeSystem.MethodDesc:this (Tier1)
         205 ( 6.33% of base) : 197536.dasm - Benchstone.BenchI.MulMatrix:Inner(int[][],int[][],int[][]) (FullOpts)
         183 ( 1.23% of base) : 311479.dasm - Tracing.Tests.ProcessInfoValidation.ProcessInfoValidation:TestEntryPoint() (FullOpts)
         164 ( 0.87% of base) : 233456.dasm - r4NaNadd:TestEntryPoint():int (FullOpts)
         156 ( 7.85% of base) : 308811.dasm - Microsoft.Build.Shared.LoadedType:.ctor(System.Type,Microsoft.Build.Shared.AssemblyLoadInfo,System.Reflection.Assembly,System.Type,ubyte):this (FullOpts)
         140 (10.60% of base) : 196037.dasm - AssignRect:first_assignments(int[,],short[,]):int (FullOpts)
         136 ( 1.92% of base) : 576723.dasm - Internal.JitInterface.CorInfoImpl:resolveVirtualMethod(ulong):ubyte:this (Tier1)
         126 ( 3.02% of base) : 219470.dasm - GetInterfaceMapWithStaticVirtualsAndConstraints.Program:TestEntryPoint() (FullOpts)
         110 ( 0.85% of base) : 311492.dasm - Tracing.Tests.ProcessInfoValidation.ProcessInfoValidation:TestEntryPoint() (FullOpts)
         109 ( 0.61% of base) : 233461.dasm - r4NaNdiv:TestEntryPoint():int (FullOpts)
          97 ( 5.79% of base) : 574195.dasm - Internal.TypeSystem.Ecma.EcmaSignatureParser:ParseMethodSignatureImpl(ubyte):Internal.TypeSystem.MethodSignature:this (Tier1)
          88 ( 3.03% of base) : 189772.dasm - ImplicitByrefTailCalls:TestEntryPoint():int (FullOpts)
          80 ( 1.13% of base) : 580424.dasm - Internal.JitInterface.CorInfoImpl:resolveVirtualMethod(ulong):ubyte:this (Tier1)
          80 ( 5.26% of base) : 233648.dasm - string1:ProcessJagged3DArray(System.String[][]) (FullOpts)
          78 ( 2.72% of base) : 311277.dasm - BasicEventSourceTests.TestEventCounter+SimpleEventListener:OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs):this (FullOpts)
          77 ( 2.67% of base) : 189778.dasm - ImplicitByrefTailCalls:TestEntryPoint():int (FullOpts)
          74 ( 1.78% of base) : 174831.dasm - NetClient.StringTests:Marshal_LPWString():this (FullOpts)
          74 ( 1.79% of base) : 174595.dasm - NetClient.StringTests:Marshal_LPWString():this (FullOpts)

Top method improvements (bytes):
       -3022 (-76.92% of base) : 5026.dasm - testout1:Sub_Funclet_1():int (FullOpts)
       -3022 (-76.92% of base) : 5035.dasm - testout1:Sub_Funclet_1():int (FullOpts)
       -2677 (-2.62% of base) : 233544.dasm - r8rem:TestEntryPoint():int (FullOpts)
       -2357 (-2.55% of base) : 233201.dasm - i4rem:TestEntryPoint():int (FullOpts)
       -2035 (-1.98% of base) : 233480.dasm - r4rem:TestEntryPoint():int (FullOpts)
       -1976 (-80.85% of base) : 232905.dasm - Test_arithm32.JitTest.Test:RunTests(float,float,float) (FullOpts)
       -1976 (-80.85% of base) : 232908.dasm - Test_arithm64.JitTest.Test:RunTests(double,double,double) (FullOpts)
       -1927 (-2.03% of base) : 233862.dasm - u8rem:TestEntryPoint():int (FullOpts)
       -1812 (-62.89% of base) : 5036.dasm - testout1:Sub_Funclet_2():int (FullOpts)
       -1812 (-62.89% of base) : 5027.dasm - testout1:Sub_Funclet_2():int (FullOpts)
       -1773 (-1.89% of base) : 233512.dasm - r8div:TestEntryPoint():int (FullOpts)
       -1502 (-44.73% of base) : 235718.dasm - JitTest_cond32_NaN_il.Test:RunTests(float,float,float,float) (FullOpts)
       -1502 (-44.73% of base) : 235720.dasm - JitTest_cond64_NaN_il.Test:RunTests(double,double,double,double) (FullOpts)
       -1493 (-1.65% of base) : 233208.dasm - i8div:TestEntryPoint():int (FullOpts)
       -1474 (-12.22% of base) : 580810.dasm - Internal.TypeSystem.RuntimeDeterminedTypeUtilities:ConvertInstantiationToSharedRuntimeForm(Internal.TypeSystem.Instantiation,Internal.TypeSystem.Instantiation,byref):Internal.TypeSystem.Instantiation (Tier1)
       -1440 (-9.22% of base) : 19701.dasm - Microsoft.Diagnostics.Tracing.Parsers.ClrTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
       -1436 (-1.53% of base) : 233215.dasm - i8rem:TestEntryPoint():int (FullOpts)
       -1326 (-1.40% of base) : 233448.dasm - r4div:TestEntryPoint():int (FullOpts)
       -1284 (-29.72% of base) : 174141.dasm - Microsoft.CSharp.RuntimeBinder.Errors.ErrorHandling:Error(int,Microsoft.CSharp.RuntimeBinder.Errors.ErrArg[]):Microsoft.CSharp.RuntimeBinder.RuntimeBinderException (FullOpts)
       -1136 (-1.31% of base) : 233194.dasm - i4div:TestEntryPoint():int (FullOpts)

Top method regressions (percentages):
         630 (42.23% of base) : 197503.dasm - Benchstone.MDBenchI.MDMulMatrix:Inner(int[,],int[,],int[,]) (FullOpts)
          29 (19.33% of base) : 185009.dasm - FastTailCallCandidates:CalleeHFAStackSpace(double,double,double,double,double,double,double,double,double,double):int (FullOpts)
          29 (19.33% of base) : 185008.dasm - FastTailCallCandidates:CalleeSimpleHFACase(double,double,double,double,double,double,double,double):int (FullOpts)
          29 (19.33% of base) : 185010.dasm - FastTailCallCandidates:CalleeWithHFA(double,double,double,double,FastTailCallCandidates+HFASize32):int (FullOpts)
          29 (19.33% of base) : 185011.dasm - FastTailCallCandidates:CalleeWithStackHFA(double,double,double,double,double,double,double,double,FastTailCallCandidates+HFASize16):int (FullOpts)
           4 (13.79% of base) : 193536.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
           4 (11.76% of base) : 580830.dasm - ILCompiler.RuntimeDeterminedTypeHelper:Equals(Internal.JitInterface.FieldWithToken,Internal.JitInterface.FieldWithToken):ubyte (Tier1)
           4 (11.76% of base) : 577997.dasm - ILCompiler.RuntimeDeterminedTypeHelper:Equals(Internal.JitInterface.FieldWithToken,Internal.JitInterface.FieldWithToken):ubyte (Tier1)
         140 (10.60% of base) : 196037.dasm - AssignRect:first_assignments(int[,],short[,]):int (FullOpts)
          30 (10.17% of base) : 14499.dasm - testout1:Sub_Funclet_144():float (FullOpts)
          30 (10.17% of base) : 14890.dasm - testout1:Sub_Funclet_144():float (FullOpts)
          30 (10.17% of base) : 12010.dasm - testout1:Sub_Funclet_240():float (FullOpts)
          30 (10.17% of base) : 12426.dasm - testout1:Sub_Funclet_240():float (FullOpts)
          30 (10.17% of base) : 12613.dasm - testout1:Sub_Funclet_432():float (FullOpts)
          30 (10.17% of base) : 12197.dasm - testout1:Sub_Funclet_432():float (FullOpts)
          15 (10.00% of base) : 18456.dasm - testout1:Sub_Funclet_238():int (FullOpts)
          15 (10.00% of base) : 18847.dasm - testout1:Sub_Funclet_238():int (FullOpts)
          30 ( 9.93% of base) : 11081.dasm - testout1:Sub_Funclet_144():double (FullOpts)
          30 ( 9.93% of base) : 8617.dasm - testout1:Sub_Funclet_240():double (FullOpts)
          30 ( 9.93% of base) : 8201.dasm - testout1:Sub_Funclet_240():double (FullOpts)

Top method improvements (percentages):
         -77 (-82.80% of base) : 236833.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
         -77 (-82.80% of base) : 232752.dasm - Test_10w250d.testout1:Func_0_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1_1():float (FullOpts)
       -1976 (-80.85% of base) : 232905.dasm - Test_arithm32.JitTest.Test:RunTests(float,float,float) (FullOpts)
       -1976 (-80.85% of base) : 232908.dasm - Test_arithm64.JitTest.Test:RunTests(double,double,double) (FullOpts)
        -372 (-80.00% of base) : 243782.dasm - Runtime_57752_1:M51(ubyte[],ushort[],ubyte[],ulong,int[],byref) (FullOpts)
        -372 (-80.00% of base) : 495032.dasm - Runtime_57752_1:M51(ubyte[],ushort[],ubyte[],ulong,int[],byref) (Tier0-FullOpts)
       -3022 (-76.92% of base) : 5026.dasm - testout1:Sub_Funclet_1():int (FullOpts)
       -3022 (-76.92% of base) : 5035.dasm - testout1:Sub_Funclet_1():int (FullOpts)
        -211 (-76.17% of base) : 194575.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
        -449 (-71.16% of base) : 6221.dasm - testout1:Sub_Funclet_402():int (FullOpts)
        -449 (-71.16% of base) : 5811.dasm - testout1:Sub_Funclet_402():int (FullOpts)
         -46 (-70.77% of base) : 238443.dasm - Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)
         -46 (-70.77% of base) : 232006.dasm - Test_10w5d.testout1:Func_0_3_5_6_4():float (FullOpts)
        -424 (-69.97% of base) : 6054.dasm - testout1:Sub_Funclet_226():int (FullOpts)
        -424 (-69.97% of base) : 5640.dasm - testout1:Sub_Funclet_226():int (FullOpts)
        -121 (-69.94% of base) : 232121.dasm - Test_10w5d.testout1:Func_0_3_2_1_2():double (FullOpts)
        -121 (-69.94% of base) : 238558.dasm - Test_10w5d.testout1:Func_0_3_2_1_2():double (FullOpts)
        -418 (-69.67% of base) : 6007.dasm - testout1:Sub_Funclet_178():int (FullOpts)
        -418 (-69.67% of base) : 5702.dasm - testout1:Sub_Funclet_290():int (FullOpts)
        -418 (-69.67% of base) : 6115.dasm - testout1:Sub_Funclet_290():int (FullOpts)

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

Total bytes of base: 45196363 (overridden on cmd)
Total bytes of diff: 45091065 (overridden on cmd)
Total bytes of delta: -105298 (-0.23 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          93 : 61058.dasm (0.88% of base)
          93 : 123568.dasm (0.88% of base)
          46 : 213073.dasm (1.10% of base)
          44 : 269452.dasm (8.98% of base)
          44 : 215226.dasm (1.07% of base)
          38 : 170322.dasm (3.51% of base)
          37 : 20679.dasm (1.69% of base)
          36 : 166785.dasm (1.85% of base)
          36 : 6917.dasm (1.94% of base)
          33 : 90631.dasm (1.61% of base)
          30 : 20913.dasm (4.88% of base)
          27 : 20695.dasm (2.03% of base)
          27 : 275549.dasm (1.68% of base)
          25 : 180969.dasm (0.99% of base)
          24 : 165052.dasm (0.53% of base)
          24 : 61241.dasm (0.51% of base)
          24 : 221306.dasm (1.84% of base)
          24 : 190612.dasm (1.84% of base)
          23 : 94210.dasm (2.51% of base)
          21 : 6681.dasm (2.84% of base)

Top file improvements (bytes):
       -2934 : 10140.dasm (-39.00% of base)
        -786 : 59859.dasm (-32.74% of base)
        -566 : 265408.dasm (-26.07% of base)
        -566 : 254611.dasm (-26.18% of base)
        -495 : 160256.dasm (-33.93% of base)
        -441 : 186252.dasm (-40.65% of base)
        -412 : 186253.dasm (-35.43% of base)
        -350 : 180261.dasm (-1.34% of base)
        -316 : 250944.dasm (-34.27% of base)
        -308 : 164418.dasm (-11.94% of base)
        -279 : 157906.dasm (-36.33% of base)
        -271 : 250949.dasm (-38.88% of base)
        -260 : 197256.dasm (-45.94% of base)
        -260 : 227530.dasm (-45.77% of base)
        -260 : 197259.dasm (-45.77% of base)
        -260 : 227527.dasm (-45.94% of base)
        -259 : 260342.dasm (-21.40% of base)
        -259 : 173404.dasm (-44.89% of base)
        -243 : 198585.dasm (-44.67% of base)
        -243 : 228849.dasm (-44.67% of base)

89 total files with Code Size differences (51 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
          93 ( 0.88% of base) : 61058.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitTupleDeconstructionArguments(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+DeconstructionVariable],System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):this (FullOpts)
          93 ( 0.88% of base) : 123568.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitTupleDeconstructionArguments(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+DeconstructionVariable],System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):this (FullOpts)
          46 ( 1.10% of base) : 213073.dasm - System.Configuration.BaseConfigurationRecord:ScanFactoriesRecursive(System.Configuration.XmlUtil,System.String,System.Collections.Hashtable):this (FullOpts)
          44 ( 1.07% of base) : 215226.dasm - System.Configuration.BaseConfigurationRecord:ScanFactoriesRecursive(System.Configuration.XmlUtil,System.String,System.Collections.Hashtable):this (FullOpts)
          44 ( 8.98% of base) : 269452.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (FullOpts)
          38 ( 3.51% of base) : 170322.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
          37 ( 1.69% of base) : 20679.dasm - System.Globalization.IdnMapping:PunycodeEncode(System.String):System.String (FullOpts)
          36 ( 1.85% of base) : 166785.dasm - System.Text.Json.JsonSerializer:TryHandleReferenceFromJsonElement(byref,byref,System.Text.Json.JsonElement,byref):ubyte (FullOpts)
          36 ( 1.94% of base) : 6917.dasm - System.Text.StringBuilder:Replace(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort],int,int):System.Text.StringBuilder:this (FullOpts)
          33 ( 1.61% of base) : 90631.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:ComputeVariableType(Microsoft.CodeAnalysis.VisualBasic.Symbols.LocalSymbol,Microsoft.CodeAnalysis.VisualBasic.Syntax.ModifiedIdentifierSyntax,Microsoft.CodeAnalysis.VisualBasic.Syntax.AsClauseSyntax,Microsoft.CodeAnalysis.VisualBasic.Syntax.EqualsValueSyntax,byref,byref,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag):Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol:this (FullOpts)
          30 ( 4.88% of base) : 20913.dasm - System.Text.EncodingTable:InternalGetCodePageFromName(System.String):int (FullOpts)
          27 ( 2.03% of base) : 20695.dasm - System.Globalization.Normalization:NlsNormalize(System.String,int):System.String (FullOpts)
          27 ( 1.68% of base) : 275549.dasm - System.Net.TimerThread:ThreadProc() (FullOpts)
          25 ( 0.99% of base) : 180969.dasm - Microsoft.VisualBasic.CompilerServices.VB6File:PutArrayData(System.Array,System.Type,int,int,int):this (FullOpts)
          24 ( 1.84% of base) : 221306.dasm - Microsoft.CodeAnalysis.Compilation:Emit(System.IO.Stream,System.IO.Stream,System.IO.Stream,System.IO.Stream,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.ResourceDescription],Microsoft.CodeAnalysis.Emit.EmitOptions,Microsoft.CodeAnalysis.IMethodSymbol,System.IO.Stream,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.EmbeddedText],System.IO.Stream,Microsoft.CodeAnalysis.RebuildData,System.Threading.CancellationToken):Microsoft.CodeAnalysis.Emit.EmitResult:this (FullOpts)
          24 ( 1.84% of base) : 190612.dasm - Microsoft.CodeAnalysis.Compilation:Emit(System.IO.Stream,System.IO.Stream,System.IO.Stream,System.IO.Stream,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.ResourceDescription],Microsoft.CodeAnalysis.Emit.EmitOptions,Microsoft.CodeAnalysis.IMethodSymbol,System.IO.Stream,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.EmbeddedText],System.IO.Stream,Microsoft.CodeAnalysis.RebuildData,System.Threading.CancellationToken):Microsoft.CodeAnalysis.Emit.EmitResult:this (FullOpts)
          24 ( 0.51% of base) : 61241.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<VisitArguments>g__visitArguments|232_0(Microsoft.CodeAnalysis.CSharp.BoundNode,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Conversion],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitArgumentResult],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.BitVector,ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,ubyte):System.ValueTuple`4[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitArgumentResult],ubyte,Microsoft.CodeAnalysis.CSharp.NullableWalker+ArgumentsCompletionDelegate]:this (FullOpts)
          24 ( 0.53% of base) : 165052.dasm - System.Data.RBTree`1[System.__Canon]:RBDeleteX(int,int,int):int:this (FullOpts)
          23 ( 2.51% of base) : 94210.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceMethodSymbol:EarlyDecodeWellKnownAttribute(byref):Microsoft.CodeAnalysis.VisualBasic.Symbols.VisualBasicAttributeData:this (FullOpts)
          21 ( 2.84% of base) : 6681.dasm - System.Threading.Tasks.Task:WhenAll(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task]):System.Threading.Tasks.Task (FullOpts)

Top method improvements (bytes):
       -2934 (-39.00% of base) : 10140.dasm - System.Reflection.Emit.CustomAttributeBuilder:.ctor(System.Reflection.ConstructorInfo,System.Object[],System.Reflection.PropertyInfo[],System.Object[],System.Reflection.FieldInfo[],System.Object[]):this (FullOpts)
        -786 (-32.74% of base) : 59859.dasm - Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker:TryGetCollisionErrorCode(Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.Symbol,byref):ubyte (FullOpts)
        -566 (-26.07% of base) : 265408.dasm - System.DefaultBinder:SelectMethod(int,System.Reflection.MethodBase[],System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.MethodBase:this (FullOpts)
        -566 (-26.18% of base) : 254611.dasm - System.DefaultBinder:SelectMethod(int,System.Reflection.MethodBase[],System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.MethodBase:this (FullOpts)
        -495 (-33.93% of base) : 160256.dasm - Internal.IL.UnsafeAccessors:DoesMethodMatchUnsafeAccessorDeclaration(byref,Internal.TypeSystem.MethodDesc,ubyte):ubyte (FullOpts)
        -441 (-40.65% of base) : 186252.dasm - System.Management.ManagementObjectSearcher:Get():System.Management.ManagementObjectCollection:this (FullOpts)
        -412 (-35.43% of base) : 186253.dasm - System.Management.ManagementObjectSearcher:Get(System.Management.ManagementOperationObserver):this (FullOpts)
        -350 (-1.34% of base) : 180261.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
        -316 (-34.27% of base) : 250944.dasm - System.Reflection.Emit.TypeBuilderImpl:ValidateImplementedMethod(System.Reflection.MethodInfo,System.Reflection.MethodInfo):this (FullOpts)
        -308 (-11.94% of base) : 164418.dasm - System.Data.Merger:MergeSchema(System.Data.DataTable):System.Data.DataTable:this (FullOpts)
        -279 (-36.33% of base) : 157906.dasm - System.Xml.Serialization.XmlSerializationILGen:GeneratePublicMethods(System.String,System.String,System.String[],System.Xml.Serialization.XmlMapping[],System.Reflection.Emit.TypeBuilder):System.Reflection.Emit.FieldBuilder:this (FullOpts)
        -271 (-38.88% of base) : 250949.dasm - System.Reflection.Emit.TypeBuilderImpl:MatchesTheFilter(System.Reflection.Emit.MethodBuilderImpl,int,int,int,System.Type[]):ubyte (FullOpts)
        -260 (-45.94% of base) : 197256.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:Equals(System.String,System.String):ubyte:this (FullOpts)
        -260 (-45.94% of base) : 227527.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:Equals(System.String,System.String):ubyte:this (FullOpts)
        -260 (-45.77% of base) : 227530.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:StartsWith(System.String,System.String):ubyte (FullOpts)
        -260 (-45.77% of base) : 197259.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:StartsWith(System.String,System.String):ubyte (FullOpts)
        -259 (-44.89% of base) : 173404.dasm - System.Linq.Expressions.Expression:IsCompatible(System.Reflection.MethodBase,System.Linq.Expressions.Expression[]):ubyte (FullOpts)
        -259 (-21.40% of base) : 260342.dasm - System.Uri:CheckSchemeSyntax(System.ReadOnlySpan`1[ushort],byref):System.UriParser (FullOpts)
        -243 (-44.67% of base) : 198585.dasm - Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState+TargetSymbolResolver:AllParametersMatch(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.IParameterSymbol],Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState+TargetSymbolResolver+ParameterInfo[]):ubyte:this (FullOpts)
        -243 (-44.67% of base) : 228849.dasm - Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState+TargetSymbolResolver:AllParametersMatch(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.IParameterSymbol],Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState+TargetSymbolResolver+ParameterInfo[]):ubyte:this (FullOpts)

Top method regressions (percentages):
           4 (13.79% of base) : 79164.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
          44 ( 8.98% of base) : 269452.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (FullOpts)
           6 ( 8.70% of base) : 6387.dasm - System.Threading.ReaderWriterLockSlim:get_IsReadLockHeld():ubyte:this (FullOpts)
          10 ( 7.09% of base) : 175156.dasm - Microsoft.CSharp.RuntimeBinder.RuntimeBinderExtensions:IsEquivalentTo(System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)
           6 ( 5.94% of base) : 143484.dasm - Microsoft.CodeAnalysis.CSharp.BoundSpillSequence+<>c:<MakeStatements>b__1_0(Microsoft.CodeAnalysis.CSharp.BoundExpression):Microsoft.CodeAnalysis.CSharp.BoundStatement:this (FullOpts)
           6 ( 5.94% of base) : 83982.dasm - Microsoft.CodeAnalysis.CSharp.BoundSpillSequence+<>c:<MakeStatements>b__1_0(Microsoft.CodeAnalysis.CSharp.BoundExpression):Microsoft.CodeAnalysis.CSharp.BoundStatement:this (FullOpts)
           6 ( 5.77% of base) : 27060.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt32@5895:System.Collections.IEnumerator.MoveNext():ubyte:this (FullOpts)
           6 ( 5.61% of base) : 27046.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt64@5894:System.Collections.IEnumerator.MoveNext():ubyte:this (FullOpts)
           6 ( 5.61% of base) : 27081.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUIntPtr@5897:System.Collections.IEnumerator.MoveNext():ubyte:this (FullOpts)
          20 ( 5.06% of base) : 241855.dasm - Internal.Pgo.PgoProcessor:Merge[System.__Canon,System.__Canon](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
           5 ( 5.05% of base) : 96011.dasm - Microsoft.CodeAnalysis.VisualBasic.BoundExpressionExtensions:ToStatement(Microsoft.CodeAnalysis.VisualBasic.BoundExpression):Microsoft.CodeAnalysis.VisualBasic.BoundExpressionStatement (FullOpts)
          30 ( 4.88% of base) : 20913.dasm - System.Text.EncodingTable:InternalGetCodePageFromName(System.String):int (FullOpts)
           4 ( 4.55% of base) : 17377.dasm - System.Reflection.Emit.ScopeTree:GetCurrentActiveScopeIndex():int:this (FullOpts)
          19 ( 4.00% of base) : 148165.dasm - System.Xml.Ucs4Decoder:Convert(ubyte[],int,int,ushort[],int,int,ubyte,byref,byref,byref):this (FullOpts)
          38 ( 3.51% of base) : 170322.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
           8 ( 3.48% of base) : 220170.dasm - Roslyn.Utilities.ObjectWriter:WriteEncodedInt32(int):this (FullOpts)
           5 ( 3.47% of base) : 8988.dasm - System.Runtime.InteropServices.Marshalling.AnsiStringMarshaller:ConvertToUnmanaged(System.String):ulong (FullOpts)
           4 ( 3.45% of base) : 93331.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol,Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol):int (FullOpts)
           4 ( 3.45% of base) : 27130.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeByte@5901:System.Collections.IEnumerator.MoveNext():ubyte:this (FullOpts)
          13 ( 3.36% of base) : 266727.dasm - System.DirectoryServices.Protocols.LdapConnection:ConstructAttribute(long,long):System.DirectoryServices.Protocols.DirectoryAttribute:this (FullOpts)

Top method improvements (percentages):
         -53 (-62.35% of base) : 718.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
         -53 (-60.92% of base) : 20295.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)
         -53 (-60.92% of base) : 715.dasm - System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)
         -53 (-60.92% of base) : 15656.dasm - System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)
         -53 (-60.92% of base) : 20296.dasm - System.RuntimeType:get_IsNullableOfT():ubyte:this (FullOpts)
         -52 (-57.78% of base) : 19186.dasm - System.Buffers.AsciiCharSearchValues`1[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle]:ContainsCore(ushort):ubyte:this (FullOpts)
         -52 (-57.78% of base) : 5833.dasm - System.Buffers.Latin1CharSearchValues:ContainsCore(ushort):ubyte:this (FullOpts)
         -42 (-53.85% of base) : 716.dasm - System.RuntimeType:get_IsConstructedGenericType():ubyte:this (FullOpts)
         -42 (-53.85% of base) : 717.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)
         -33 (-47.14% of base) : 168569.dasm - System.Runtime.Serialization.ExtensionDataReader:get_Item(int):System.String:this (FullOpts)
         -33 (-47.14% of base) : 168570.dasm - System.Runtime.Serialization.ExtensionDataReader:get_Item(System.String):System.String:this (FullOpts)
        -189 (-47.01% of base) : 157796.dasm - System.Xml.Serialization.AccessorMapping:ElementsMatch(System.Xml.Serialization.ElementAccessor[],System.Xml.Serialization.ElementAccessor[]):ubyte (FullOpts)
         -37 (-46.25% of base) : 22310.dasm - System.Globalization.CalendarData:SystemSupportsTaiwaneseCalendar():ubyte (FullOpts)
        -260 (-45.94% of base) : 197256.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:Equals(System.String,System.String):ubyte:this (FullOpts)
        -260 (-45.94% of base) : 227527.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:Equals(System.String,System.String):ubyte:this (FullOpts)
        -260 (-45.77% of base) : 227530.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:StartsWith(System.String,System.String):ubyte (FullOpts)
        -260 (-45.77% of base) : 197259.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:StartsWith(System.String,System.String):ubyte (FullOpts)
         -54 (-45.76% of base) : 801.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
        -259 (-44.89% of base) : 173404.dasm - System.Linq.Expressions.Expression:IsCompatible(System.Reflection.MethodBase,System.Linq.Expressions.Expression[]):ubyte (FullOpts)
         -51 (-44.74% of base) : 220071.dasm - Roslyn.Utilities.StringTable:TextEqualsASCII(System.String,System.ReadOnlySpan`1[ubyte]):ubyte (FullOpts)

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

Total bytes of base: 61765198 (overridden on cmd)
Total bytes of diff: 61253944 (overridden on cmd)
Total bytes of delta: -511254 (-0.83 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         143 : 292636.dasm (17.83% of base)
         138 : 249240.dasm (2.24% of base)
         125 : 148526.dasm (3.49% of base)
         125 : 189223.dasm (3.49% of base)
         122 : 62730.dasm (3.00% of base)
         106 : 148519.dasm (2.88% of base)
         106 : 189216.dasm (2.88% of base)
         106 : 257024.dasm (3.86% of base)
         106 : 299319.dasm (3.86% of base)
         105 : 94047.dasm (5.08% of base)
          87 : 30754.dasm (19.64% of base)
          87 : 242341.dasm (19.64% of base)
          86 : 140728.dasm (1.28% of base)
          82 : 88911.dasm (4.85% of base)
          77 : 300809.dasm (5.01% of base)
          70 : 210843.dasm (3.49% of base)
          68 : 56658.dasm (2.36% of base)
          66 : 213263.dasm (3.19% of base)
          62 : 212571.dasm (3.84% of base)
          62 : 212570.dasm (3.87% of base)

Top file improvements (bytes):
       -1291 : 143479.dasm (-29.74% of base)
        -950 : 36445.dasm (-9.70% of base)
        -930 : 238315.dasm (-39.31% of base)
        -904 : 245807.dasm (-27.64% of base)
        -892 : 205125.dasm (-6.60% of base)
        -767 : 298232.dasm (-39.09% of base)
        -721 : 162618.dasm (-2.46% of base)
        -669 : 50766.dasm (-6.64% of base)
        -652 : 298255.dasm (-45.82% of base)
        -644 : 271496.dasm (-19.76% of base)
        -644 : 209604.dasm (-19.76% of base)
        -632 : 211708.dasm (-19.32% of base)
        -611 : 256022.dasm (-26.81% of base)
        -611 : 298275.dasm (-27.02% of base)
        -579 : 182862.dasm (-5.94% of base)
        -579 : 202715.dasm (-5.94% of base)
        -500 : 134770.dasm (-9.62% of base)
        -497 : 176335.dasm (-18.60% of base)
        -485 : 245805.dasm (-11.43% of base)
        -462 : 205097.dasm (-5.07% of base)

95 total files with Code Size differences (57 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
         143 (17.83% of base) : 292636.dasm - System.Net.Security.SslConnectionInfo:GetNegotiatedApplicationProtocol(System.Net.Security.SafeDeleteContext):ubyte[] (FullOpts)
         138 ( 2.24% of base) : 249240.dasm - R2RDump.R2RDiff:ShowMethodDiff(System.Collections.Generic.Dictionary`2[System.String,int],System.Collections.Generic.Dictionary`2[System.String,int],System.String):this (FullOpts)
         125 ( 3.49% of base) : 148526.dasm - Microsoft.CodeAnalysis.SourceOutputNode`1[ubyte]:UpdateStateTable(Microsoft.CodeAnalysis.DriverStateTable+Builder,Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]],System.Threading.CancellationToken):Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]]:this (FullOpts)
         125 ( 3.49% of base) : 189223.dasm - Microsoft.CodeAnalysis.SourceOutputNode`1[ubyte]:UpdateStateTable(Microsoft.CodeAnalysis.DriverStateTable+Builder,Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]],System.Threading.CancellationToken):Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]]:this (FullOpts)
         122 ( 3.00% of base) : 62730.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitObjectCreationInitializer(int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase,ubyte):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]:this (FullOpts)
         106 ( 2.88% of base) : 148519.dasm - Microsoft.CodeAnalysis.SourceOutputNode`1[System.__Canon]:UpdateStateTable(Microsoft.CodeAnalysis.DriverStateTable+Builder,Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]],System.Threading.CancellationToken):Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]]:this (FullOpts)
         106 ( 2.88% of base) : 189216.dasm - Microsoft.CodeAnalysis.SourceOutputNode`1[System.__Canon]:UpdateStateTable(Microsoft.CodeAnalysis.DriverStateTable+Builder,Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]],System.Threading.CancellationToken):Microsoft.CodeAnalysis.NodeStateTable`1[System.ValueTuple`2[System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.GeneratedSourceText],System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]]]:this (FullOpts)
         106 ( 3.86% of base) : 257024.dasm - System.Reflection.TypeLoading.Ecma.EcmaModule:GetTypeCoreNoCache(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],byref):System.Reflection.TypeLoading.RoDefinitionType:this (FullOpts)
         106 ( 3.86% of base) : 299319.dasm - System.Reflection.TypeLoading.Ecma.EcmaModule:GetTypeCoreNoCache(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],byref):System.Reflection.TypeLoading.RoDefinitionType:this (FullOpts)
         105 ( 5.08% of base) : 94047.dasm - Internal.Cryptography.Pal.AnyOS.ManagedPkcsPal:MakeKtri(ubyte[],System.Security.Cryptography.Pkcs.CmsRecipient,byref):System.Security.Cryptography.Pkcs.Asn1.KeyTransRecipientInfoAsn:this (FullOpts)
          87 (19.64% of base) : 30754.dasm - Internal.Pgo.PgoProcessor:Merge[System.__Canon,System.Nullable`1[int]](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
          87 (19.64% of base) : 242341.dasm - Internal.Pgo.PgoProcessor:Merge[System.__Canon,System.Nullable`1[int]](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
          86 ( 1.28% of base) : 140728.dasm - System.Xml.Serialization.XmlSerializationWriterCodeGen:WriteStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)
          82 ( 4.85% of base) : 88911.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder:SubstituteNoPiaLocalType(byref,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,System.String,System.String,System.String,Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol (FullOpts)
          77 ( 5.01% of base) : 300809.dasm - System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[ubyte],ubyte,ubyte):this (FullOpts)
          70 ( 3.49% of base) : 210843.dasm - System.Data.OleDb.ColumnBinding:Value(System.Object):this (FullOpts)
          68 ( 2.36% of base) : 56658.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ReportBadDynamicArguments(Microsoft.CodeAnalysis.SyntaxNode,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[ubyte],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):ubyte (FullOpts)
          66 ( 3.19% of base) : 213263.dasm - System.DirectoryServices.ActiveDirectory.Forest:GetApplicationPartitions():System.Collections.ArrayList:this (FullOpts)
          62 ( 3.84% of base) : 212571.dasm - System.DirectoryServices.ActiveDirectory.ActiveDirectorySchema:GetAllClasses(System.DirectoryServices.ActiveDirectory.DirectoryContext,System.DirectoryServices.DirectoryEntry,System.String):System.DirectoryServices.ActiveDirectory.ReadOnlyActiveDirectorySchemaClassCollection (FullOpts)
          62 ( 3.87% of base) : 212570.dasm - System.DirectoryServices.ActiveDirectory.ActiveDirectorySchema:GetAllProperties(System.DirectoryServices.ActiveDirectory.DirectoryContext,System.DirectoryServices.DirectoryEntry,System.String):System.DirectoryServices.ActiveDirectory.ReadOnlyActiveDirectorySchemaPropertyCollection (FullOpts)

Top method improvements (bytes):
       -1291 (-29.74% of base) : 143479.dasm - Microsoft.CSharp.RuntimeBinder.Errors.ErrorHandling:Error(int,Microsoft.CSharp.RuntimeBinder.Errors.ErrArg[]):Microsoft.CSharp.RuntimeBinder.RuntimeBinderException (FullOpts)
        -950 (-9.70% of base) : 36445.dasm - Microsoft.Diagnostics.Tracing.Parsers.MicrosoftAntimalwareEngineTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
        -930 (-39.31% of base) : 238315.dasm - Internal.IL.UnsafeAccessors:DoesMethodMatchUnsafeAccessorDeclaration(byref,Internal.TypeSystem.MethodDesc,ubyte):ubyte (FullOpts)
        -904 (-27.64% of base) : 245807.dasm - Microsoft.Extensions.DependencyModel.DependencyContextWriter:WriteAssetList(System.String,System.Collections.Generic.IEnumerable`1[Microsoft.Extensions.DependencyModel.RuntimeFile],System.Text.Json.Utf8JsonWriter) (FullOpts)
        -892 (-6.60% of base) : 205125.dasm - System.Data.XmlTreeGen:HandleTable(System.Data.DataTable,System.Xml.XmlDocument,System.Xml.XmlElement,ubyte):System.Xml.XmlElement:this (FullOpts)
        -767 (-39.09% of base) : 298232.dasm - System.Reflection.Emit.TypeBuilderImpl:ValidateImplementedMethod(System.Reflection.MethodInfo,System.Reflection.MethodInfo):this (FullOpts)
        -721 (-2.46% of base) : 162618.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
        -669 (-6.64% of base) : 50766.dasm - Microsoft.Diagnostics.Tracing.Parsers.AspNet.AspNetTraceEventParser:EnumerateTemplates(System.Func`3[System.String,System.String,int],System.Action`1[Microsoft.Diagnostics.Tracing.TraceEvent]):this (FullOpts)
        -652 (-45.82% of base) : 298255.dasm - System.Reflection.Emit.TypeBuilderImpl:MatchesTheFilter(System.Reflection.Emit.MethodBuilderImpl,int,int,int,System.Type[]):ubyte (FullOpts)
        -644 (-19.76% of base) : 271496.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -644 (-19.76% of base) : 209604.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -632 (-19.32% of base) : 211708.dasm - System.Data.Common.DbConnectionOptions:GetKeyValuePair(System.String,int,System.Text.StringBuilder,ubyte,byref,byref):int (FullOpts)
        -611 (-26.81% of base) : 256022.dasm - System.DefaultBinder:SelectMethod(int,System.Reflection.MethodBase[],System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.MethodBase:this (FullOpts)
        -611 (-27.02% of base) : 298275.dasm - System.DefaultBinder:SelectMethod(int,System.Reflection.MethodBase[],System.Type[],System.Reflection.ParameterModifier[]):System.Reflection.MethodBase:this (FullOpts)
        -579 (-5.94% of base) : 182862.dasm - System.Configuration.ConfigurationElement:DeserializeElement(System.Xml.XmlReader,ubyte):this (FullOpts)
        -579 (-5.94% of base) : 202715.dasm - System.Configuration.ConfigurationElement:DeserializeElement(System.Xml.XmlReader,ubyte):this (FullOpts)
        -500 (-9.62% of base) : 134770.dasm - System.Xml.Schema.XmlSchemaInference:FindMatchingElement(ubyte,System.Xml.XmlReader,System.Xml.Schema.XmlSchemaComplexType,byref,System.Xml.Schema.XmlSchema,ubyte):System.Xml.Schema.XmlSchemaElement:this (FullOpts)
        -497 (-18.60% of base) : 176335.dasm - Microsoft.Build.Evaluation.ExpressionShredder:GetReferencedItemNamesAndMetadata(System.String,int,int,byref,int) (FullOpts)
        -485 (-11.43% of base) : 245805.dasm - Microsoft.Extensions.DependencyModel.DependencyContextWriter:AddRuntimeSpecificAssets(System.Collections.Generic.IEnumerable`1[Microsoft.Extensions.DependencyModel.RuntimeFile],System.String,System.String,System.Text.Json.Utf8JsonWriter) (FullOpts)
        -462 (-5.07% of base) : 205097.dasm - System.Data.XmlTreeGen:SchemaTree(System.Xml.XmlDocument,System.Xml.XmlWriter,System.Data.DataSet,System.Data.DataTable,ubyte):this (FullOpts)

Top method regressions (percentages):
          87 (19.64% of base) : 30754.dasm - Internal.Pgo.PgoProcessor:Merge[System.__Canon,System.Nullable`1[int]](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
          87 (19.64% of base) : 242341.dasm - Internal.Pgo.PgoProcessor:Merge[System.__Canon,System.Nullable`1[int]](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
         143 (17.83% of base) : 292636.dasm - System.Net.Security.SslConnectionInfo:GetNegotiatedApplicationProtocol(System.Net.Security.SafeDeleteContext):ubyte[] (FullOpts)
          41 (14.24% of base) : 205330.dasm - System.Data.ColumnTypeConverter:ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object):System.Object:this (FullOpts)
           4 (13.79% of base) : 84926.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
          60 (10.26% of base) : 245762.dasm - Microsoft.Extensions.DependencyModel.DependencyContextJsonReader:ReadRuntimeFiles(byref):System.Collections.Generic.List`1[Microsoft.Extensions.DependencyModel.RuntimeFile] (FullOpts)
          43 ( 9.49% of base) : 312811.dasm - Xunit.Sdk.AssertEqualityComparer`1[System.Numerics.Vector`1[float]]:Equals(System.Numerics.Vector`1[float],System.Numerics.Vector`1[float],byref):ubyte:this (FullOpts)
          12 ( 8.76% of base) : 122341.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicControlFlowAnalysis+_Closure$__:_Lambda$__17-0(Microsoft.CodeAnalysis.SyntaxNode):ubyte:this (FullOpts)
          12 ( 8.57% of base) : 141985.dasm - Microsoft.CSharp.RuntimeBinder.RuntimeBinderExtensions:IsEquivalentTo(System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)
          31 ( 7.85% of base) : 242342.dasm - Internal.Pgo.PgoProcessor:Merge[ubyte,System.Nullable`1[int]](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
          31 ( 7.85% of base) : 30755.dasm - Internal.Pgo.PgoProcessor:Merge[ubyte,System.Nullable`1[int]](System.ReadOnlySpan`1[Internal.Pgo.PgoSchemaElem[]]):Internal.Pgo.PgoSchemaElem[] (FullOpts)
          28 ( 7.18% of base) : 210683.dasm - System.Data.ProviderBase.DbConnectionFactory:GetCompletedTask():System.Threading.Tasks.Task`1[System.Data.ProviderBase.DbConnectionInternal] (FullOpts)
          37 ( 6.43% of base) : 268266.dasm - System.ComponentModel.TypeDescriptor:AddDefaultProvider(System.Type) (FullOpts)
          41 ( 6.07% of base) : 274391.dasm - System.Diagnostics.Switch:_pruneCachedSwitches() (FullOpts)
          41 ( 6.07% of base) : 274562.dasm - System.Diagnostics.TraceSource:_pruneCachedTraceSources() (FullOpts)
          31 ( 5.96% of base) : 291969.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
          33 ( 5.95% of base) : 223795.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
           2 ( 5.88% of base) : 31479.dasm - ILCompiler.RuntimeDeterminedTypeHelper:Equals(Internal.JitInterface.FieldWithToken,Internal.JitInterface.FieldWithToken):ubyte (FullOpts)
           6 ( 5.77% of base) : 14011.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUInt32@5895:System.Collections.IEnumerator.MoveNext():ubyte:this (FullOpts)
           6 ( 5.61% of base) : 14032.dasm - Microsoft.FSharp.Core.Operators+OperatorIntrinsics+RangeUIntPtr@5897:System.Collections.IEnumerator.MoveNext():ubyte:this (FullOpts)

Top method improvements (percentages):
         -50 (-86.21% of base) : 245543.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
         -50 (-86.21% of base) : 245545.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
        -211 (-76.17% of base) : 197583.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
        -211 (-76.17% of base) : 157155.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
         -26 (-65.00% of base) : 278025.dasm - System.IO.Compression.DeflateManagedStream:PurgeBuffers(ubyte):this (FullOpts)
         -55 (-62.50% of base) : 21324.dasm - System.Buffers.BitVector256:Contains256(ushort):ubyte:this (FullOpts)
        -438 (-59.59% of base) : 139243.dasm - System.Xml.Serialization.AccessorMapping:ElementsMatch(System.Xml.Serialization.ElementAccessor[],System.Xml.Serialization.ElementAccessor[]):ubyte (FullOpts)
         -29 (-59.18% of base) : 4131.dasm - Microsoft.FSharp.Linq.NullableOperators:op_EqualsQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
         -29 (-59.18% of base) : 4107.dasm - Microsoft.FSharp.Linq.NullableOperators:op_GreaterEqualsQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
         -29 (-59.18% of base) : 4113.dasm - Microsoft.FSharp.Linq.NullableOperators:op_GreaterQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
         -29 (-59.18% of base) : 4119.dasm - Microsoft.FSharp.Linq.NullableOperators:op_LessEqualsQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
         -29 (-59.18% of base) : 4125.dasm - Microsoft.FSharp.Linq.NullableOperators:op_LessQmark[long](long,System.Nullable`1[long]):ubyte (FullOpts)
         -29 (-59.18% of base) : 4095.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkEquals[long](System.Nullable`1[long],long):ubyte (FullOpts)
         -29 (-59.18% of base) : 4077.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreater[long](System.Nullable`1[long],long):ubyte (FullOpts)
         -29 (-59.18% of base) : 4071.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkGreaterEquals[long](System.Nullable`1[long],long):ubyte (FullOpts)
         -29 (-59.18% of base) : 4089.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkLess[long](System.Nullable`1[long],long):ubyte (FullOpts)
         -29 (-59.18% of base) : 4083.dasm - Microsoft.FSharp.Linq.NullableOperators:op_QmarkLessEquals[long](System.Nullable`1[long],long):ubyte (FullOpts)
         -72 (-58.54% of base) : 187377.dasm - Microsoft.CodeAnalysis.ReportAnalyzerUtil:GetFormattedAnalyzerExecutionPercentage(int,System.Globalization.CultureInfo):System.String (FullOpts)
         -72 (-58.54% of base) : 146596.dasm - Microsoft.CodeAnalysis.ReportAnalyzerUtil:GetFormattedAnalyzerExecutionPercentage(int,System.Globalization.CultureInfo):System.String (FullOpts)
         -29 (-58.00% of base) : 4129.dasm - Microsoft.FSharp.Linq.NullableOperators:op_EqualsQmark[double](double,System.Nullable`1[double]):ubyte (FullOpts)

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

Total bytes of base: 286116316 (overridden on cmd)
Total bytes of diff: 284394214 (overridden on cmd)
Total bytes of delta: -1722102 (-0.60 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        5525 : 37696.dasm (54.37% of base)
        1118 : 54827.dasm (6.47% of base)
        1061 : 63771.dasm (9.58% of base)
         666 : 185575.dasm (4.64% of base)
         660 : 63357.dasm (8.09% of base)
         598 : 191051.dasm (3.80% of base)
         458 : 447327.dasm (6.68% of base)
         451 : 316470.dasm (3.53% of base)
         419 : 59291.dasm (3.02% of base)
         367 : 322818.dasm (20.30% of base)
         357 : 324038.dasm (2.49% of base)
         342 : 656244.dasm (5.88% of base)
         339 : 54747.dasm (23.20% of base)
         338 : 633503.dasm (23.04% of base)
         335 : 441645.dasm (4.16% of base)
         308 : 57344.dasm (2.71% of base)
         284 : 597548.dasm (5.30% of base)
         252 : 184365.dasm (17.02% of base)
         242 : 83845.dasm (4.44% of base)
         232 : 433559.dasm (3.78% of base)

Top file improvements (bytes):
       -7449 : 238930.dasm (-26.46% of base)
       -3986 : 653980.dasm (-31.55% of base)
       -3676 : 192904.dasm (-29.90% of base)
       -3596 : 606917.dasm (-20.16% of base)
       -2868 : 434179.dasm (-27.16% of base)
       -2795 : 559596.dasm (-26.23% of base)
       -2656 : 551155.dasm (-10.67% of base)
       -2621 : 314375.dasm (-18.06% of base)
       -2602 : 392483.dasm (-17.98% of base)
       -2562 : 688790.dasm (-17.06% of base)
       -2349 : 61191.dasm (-31.95% of base)
       -2339 : 89640.dasm (-31.81% of base)
       -2330 : 462509.dasm (-12.69% of base)
       -2274 : 191593.dasm (-14.57% of base)
       -2268 : 462512.dasm (-12.39% of base)
       -2255 : 462510.dasm (-12.33% of base)
       -2152 : 239904.dasm (-29.69% of base)
       -2115 : 462511.dasm (-11.60% of base)
       -2040 : 668169.dasm (-9.89% of base)
       -1934 : 95324.dasm (-34.77% of base)

93 total files with Code Size differences (57 improved, 36 regressed), 20 unchanged.

Top method regressions (bytes):
        5525 (54.37% of base) : 37696.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
        1118 ( 6.47% of base) : 54827.dasm - Microsoft.CodeAnalysis.CSharp.Binder:TryPerformConstructorOverloadResolution(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.String,Microsoft.CodeAnalysis.Location,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref,byref,ubyte,ubyte):ubyte:this (Tier1)
        1061 ( 9.58% of base) : 63771.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes:<DecodeUnmanagedCallersOnlyAttribute>g__DecodeUnmanagedCallersOnlyAttributeData|72_1(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes,Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData (Tier1)
         666 ( 4.64% of base) : 185575.dasm - Microsoft.CodeAnalysis.CSharp.Binder:TryPerformConstructorOverloadResolution(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.String,Microsoft.CodeAnalysis.Location,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,byref,byref,ubyte,ubyte):ubyte:this (Tier1)
         660 ( 8.09% of base) : 63357.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:ComputeImplementationForInterfaceMember(Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,byref):Microsoft.CodeAnalysis.CSharp.Symbol (Tier1)
         598 ( 3.80% of base) : 191051.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindClassCreationExpression(Microsoft.CodeAnalysis.SyntaxNode,System.String,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
         458 ( 6.68% of base) : 447327.dasm - System.Xml.XslCompiledTransformApiTests.CArgAddParam:AddParam16(System.Object,int,int,int,int):this (Tier1)
         451 ( 3.53% of base) : 316470.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         419 ( 3.02% of base) : 59291.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:CheckValidNullableMethodOverride[System.ValueTuple`2[System.__Canon,ubyte]](Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType`1[System.ValueTuple`2[System.__Canon,ubyte]],Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType`1[System.ValueTuple`2[System.__Canon,ubyte]],System.ValueTuple`2[System.__Canon,ubyte],ubyte):ubyte (Tier1)
         367 (20.30% of base) : 322818.dasm - System.Security.AccessControl.FileSystemSecurity:Persist(System.String):this (Tier1)
         357 ( 2.49% of base) : 324038.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         342 ( 5.88% of base) : 656244.dasm - Microsoft.CodeAnalysis.CSharp.ClosureConversion:RemapLocalFunction(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,byref,byref,byref,byref):this (Tier1)
         339 (23.20% of base) : 54747.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         338 (23.04% of base) : 633503.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         335 ( 4.16% of base) : 441645.dasm - System.Xml.Xsl.Xslt.KeywordsTable:.ctor(System.Xml.XmlNameTable):this (Tier1)
         308 ( 2.71% of base) : 57344.dasm - Microsoft.Interop.BoundGenerators:Create(System.Collections.Immutable.ImmutableArray`1[Microsoft.Interop.TypePositionInfo],Microsoft.Interop.IMarshallingGeneratorResolver,Microsoft.Interop.StubCodeContext,Microsoft.Interop.IMarshallingGenerator,byref):Microsoft.Interop.BoundGenerators (Tier1)
         284 ( 5.30% of base) : 597548.dasm - System.Text.Json.Serialization.JsonDictionaryConverter`3[System.__Canon,System.__Canon,int]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (Tier1)
         252 (17.02% of base) : 184365.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         242 ( 4.44% of base) : 83845.dasm - System.Linq.EnumerableExtensions:SequenceEqual[System.Collections.Generic.KeyValuePair`2[System.__Canon,int]](System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,int]],System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,int]],System.Func`3[System.Collections.Generic.KeyValuePair`2[System.__Canon,int],System.Collections.Generic.KeyValuePair`2[System.__Canon,int],ubyte]):ubyte (Tier1)
         232 ( 3.78% of base) : 433559.dasm - System.Xml.XmlTextReaderImpl:ParseXmlDeclaration(ubyte):ubyte:this (Tier1)

Top method improvements (bytes):
       -7449 (-26.46% of base) : 238930.dasm - System.Runtime.Serialization.Formatters.Binary.ObjectWriter:WriteArray(System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo,System.Runtime.Serialization.Formatters.Binary.NameInfo,System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo):this (Tier1)
       -3986 (-31.55% of base) : 653980.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]]:IntroSort(System.Span`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]],int,System.Comparison`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]]) (Tier1)
       -3676 (-29.90% of base) : 192904.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]]:IntroSort(System.Span`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]],int,System.Comparison`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]]) (Tier1)
       -3596 (-20.16% of base) : 606917.dasm - Xunit.Sdk.XunitTheoryTestCaseRunner+<AfterTestCaseStartingAsync>d__9:MoveNext():this (Tier1)
       -2868 (-27.16% of base) : 434179.dasm - System.Reflection.Emit.CustomAttributeBuilder:.ctor(System.Reflection.ConstructorInfo,System.Object[],System.Reflection.PropertyInfo[],System.Object[],System.Reflection.FieldInfo[],System.Object[]):this (Tier1)
       -2795 (-26.23% of base) : 559596.dasm - System.Reflection.Emit.CustomAttributeBuilder:.ctor(System.Reflection.ConstructorInfo,System.Object[],System.Reflection.PropertyInfo[],System.Object[],System.Reflection.FieldInfo[],System.Object[]):this (Tier1)
       -2656 (-10.67% of base) : 551155.dasm - System.Xml.XmlLoader:LoadNode(ubyte):System.Xml.XmlNode:this (Tier1-OSR)
       -2621 (-18.06% of base) : 314375.dasm - Xunit.Sdk.XunitTheoryTestCaseRunner+<AfterTestCaseStartingAsync>d__9:MoveNext():this (Tier1)
       -2602 (-17.98% of base) : 392483.dasm - Xunit.Sdk.XunitTheoryTestCaseRunner+<AfterTestCaseStartingAsync>d__9:MoveNext():this (Tier1)
       -2562 (-17.06% of base) : 688790.dasm - Xunit.Sdk.XunitTheoryTestCaseRunner+<AfterTestCaseStartingAsync>d__9:MoveNext():this (Tier1)
       -2349 (-31.95% of base) : 61191.dasm - System.Collections.Generic.ArraySortHelper`1[System.ValueTuple`2[int,System.__Canon]]:IntroSort(System.Span`1[System.ValueTuple`2[int,System.__Canon]],int,System.Comparison`1[System.ValueTuple`2[int,System.__Canon]]) (Tier1)
       -2339 (-31.81% of base) : 89640.dasm - System.Collections.Generic.ArraySortHelper`1[System.ValueTuple`2[int,System.__Canon]]:IntroSort(System.Span`1[System.ValueTuple`2[int,System.__Canon]],int,System.Comparison`1[System.ValueTuple`2[int,System.__Canon]]) (Tier1)
       -2330 (-12.69% of base) : 462509.dasm - System.Xml.Tests.TCAttributeAccess:TestAttributeAccess1():int:this (Tier1)
       -2274 (-14.57% of base) : 191593.dasm - Microsoft.CodeAnalysis.CSharp.BestTypeInferrer:GetBestType(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],Microsoft.CodeAnalysis.CSharp.ConversionsBase,byref):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol (Tier1)
       -2268 (-12.39% of base) : 462512.dasm - System.Xml.Tests.TCAttributeAccess:TestAttributeAccess4():int:this (Tier1)
       -2255 (-12.33% of base) : 462510.dasm - System.Xml.Tests.TCAttributeAccess:TestAttributeAccess2():int:this (Tier1)
       -2152 (-29.69% of base) : 239904.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:IntroSort(System.Span`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]],int,System.Comparison`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]) (Tier1)
       -2115 (-11.60% of base) : 462511.dasm - System.Xml.Tests.TCAttributeAccess:TestAttributeAccess3():int:this (Tier1)
       -2040 (-9.89% of base) : 668169.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex33235_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
       -1934 (-34.77% of base) : 95324.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:VisitAttributes(System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.CSharp.BoundAttribute]]):this (Tier1)

Top method regressions (percentages):
        5525 (54.37% of base) : 37696.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:ReuseAssemblySymbols(Microsoft.CodeAnalysis.CommonReferenceManager`2+BoundInputAssembly[System.__Canon,System.__Canon][],System.__Canon[],System.Collections.Immutable.ImmutableArray`1[System.__Canon],int):this (Tier1-OSR)
         339 (23.20% of base) : 54747.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         338 (23.04% of base) : 633503.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         367 (20.30% of base) : 322818.dasm - System.Security.AccessControl.FileSystemSecurity:Persist(System.String):this (Tier1)
          77 (17.30% of base) : 265823.dasm - System.Data.Common.Int32Storage:Aggregate(int[],int):System.Object:this (Tier1-OSR)
         252 (17.02% of base) : 184365.dasm - Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,System.__Canon]:TryInsert(System.__Canon,System.__Canon,ubyte):ubyte:this (Tier1)
         151 (16.45% of base) : 322819.dasm - System.Security.AccessControl.FileSystemSecurity:GetAccessControlSectionsFromChanges():int:this (Tier1)
          14 (15.73% of base) : 187585.dasm - Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+<>c:<IsGeneratedCode>b__48_1(Microsoft.CodeAnalysis.SyntaxTrivia):ubyte:this (Tier1)
          70 (15.73% of base) : 265727.dasm - System.Data.Common.Int32Storage:Aggregate(int[],int):System.Object:this (Tier1-OSR)
          92 (11.23% of base) : 93840.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer:LineBreaksAfterCloseBrace(Microsoft.CodeAnalysis.SyntaxToken,Microsoft.CodeAnalysis.SyntaxToken):int (Tier1)
          22 (10.48% of base) : 619563.dasm - Newtonsoft.Json.Linq.JToken:SetLineInfo(Newtonsoft.Json.IJsonLineInfo,Newtonsoft.Json.Linq.JsonLoadSettings):this (Tier1)
          33 (10.41% of base) : 266548.dasm - System.Data.Common.Int32Storage:Aggregate(int[],int):System.Object:this (Tier1-OSR)
          53 ( 9.72% of base) : 265358.dasm - System.Data.Common.Int32Storage:Aggregate(int[],int):System.Object:this (Tier1-OSR)
          26 ( 9.67% of base) : 635688.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:IsTargetTypedExpression(Microsoft.CodeAnalysis.CSharp.BoundExpression):ubyte (Tier1)
        1061 ( 9.58% of base) : 63771.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes:<DecodeUnmanagedCallersOnlyAttribute>g__DecodeUnmanagedCallersOnlyAttributeData|72_1(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes,Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData (Tier1)
          29 ( 9.32% of base) : 384917.dasm - System.Net.Sockets.Socket:SetToConnected():this (Tier1)
          41 ( 9.01% of base) : 220825.dasm - System.Collections.Frozen.FrozenSetInternalBase`2[System.__Canon,System.Collections.Frozen.DefaultFrozenSet`1+GSW[System.__Canon]]:IsSubsetOfSetWithCompatibleComparer(System.Collections.Generic.IReadOnlySet`1[System.__Canon]):ubyte:this (Tier1-OSR)
          22 ( 8.98% of base) : 394144.dasm - System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon]:System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]):ubyte:this (Tier1)
          19 ( 8.64% of base) : 544252.dasm - System.Security.Cryptography.RSABCrypt:Encrypt(ubyte[],System.Security.Cryptography.RSAEncryptionPadding):ubyte[]:this (Tier1)
          57 ( 8.56% of base) : 445871.dasm - System.Xml.DocumentXPathNavigator:MoveToChild(System.String,System.String):ubyte:this (Tier1)

Top method improvements (percentages):
         -32 (-64.00% of base) : 130905.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (Tier1)
         -32 (-64.00% of base) : 122407.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (Tier1)
         -32 (-64.00% of base) : 122389.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
         -32 (-64.00% of base) : 130872.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
         -55 (-62.50% of base) : 401897.dasm - System.Buffers.BitVector256:Contains128(ushort):ubyte:this (Tier1)
         -47 (-60.26% of base) : 402210.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 692194.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 374209.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 314721.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 531297.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 195778.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 68961.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 555970.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 229473.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 695490.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 243265.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 282209.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 283137.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 71459.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)
         -47 (-60.26% of base) : 695649.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (Tier1)

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

Total bytes of base: 136905963 (overridden on cmd)
Total bytes of diff: 135664156 (overridden on cmd)
Total bytes of delta: -1241807 (-0.91 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         772 : 97990.dasm (6.12% of base)
         578 : 204070.dasm (14.65% of base)
         520 : 216605.dasm (10.34% of base)
         465 : 223797.dasm (6.61% of base)
         410 : 101323.dasm (18.55% of base)
         380 : 95755.dasm (4.25% of base)
         379 : 215564.dasm (8.20% of base)
         290 : 42378.dasm (5.47% of base)
         290 : 220905.dasm (6.18% of base)
         290 : 215735.dasm (6.18% of base)
         265 : 92773.dasm (7.53% of base)
         213 : 316766.dasm (9.73% of base)
         209 : 150985.dasm (20.88% of base)
         205 : 30482.dasm (2.04% of base)
         203 : 216393.dasm (7.87% of base)
         189 : 215140.dasm (3.48% of base)
         188 : 225250.dasm (9.77% of base)
         178 : 316199.dasm (9.29% of base)
         175 : 316749.dasm (9.61% of base)
         165 : 270890.dasm (1.71% of base)

Top file improvements (bytes):
       -2040 : 298630.dasm (-10.69% of base)
       -1415 : 25589.dasm (-33.43% of base)
       -1271 : 272109.dasm (-23.14% of base)
        -993 : 268443.dasm (-13.34% of base)
        -993 : 268873.dasm (-13.34% of base)
        -963 : 2909.dasm (-17.10% of base)
        -921 : 272228.dasm (-16.74% of base)
        -918 : 217031.dasm (-16.85% of base)
        -901 : 94861.dasm (-6.89% of base)
        -836 : 38503.dasm (-28.81% of base)
        -815 : 208585.dasm (-25.34% of base)
        -815 : 173478.dasm (-25.34% of base)
        -815 : 209952.dasm (-25.34% of base)
        -815 : 320385.dasm (-25.34% of base)
        -815 : 63308.dasm (-25.34% of base)
        -767 : 187999.dasm (-39.09% of base)
        -721 : 60381.dasm (-2.47% of base)
        -680 : 153406.dasm (-9.72% of base)
        -652 : 187666.dasm (-45.82% of base)
        -650 : 217500.dasm (-11.81% of base)

100 total files with Code Size differences (61 improved, 39 regressed), 20 unchanged.

Top method regressions (bytes):
         772 ( 6.12% of base) : 97990.dasm - System.Data.Tests.Common.DbConnectionStringBuilderTest:EmbeddedCharTest6():this (FullOpts)
         578 (14.65% of base) : 204070.dasm - System.Numerics.Tests.ComplexTests:ToStringTest(double,double) (FullOpts)
         520 (10.34% of base) : 216605.dasm - System.Runtime.Tests.JitInfoTests:JitInfoIsPopulated():this (FullOpts)
         465 ( 6.61% of base) : 223797.dasm - System.Tests.NumberFormatTestHelper:TryFormatNumberTest[long](long,System.String,System.IFormatProvider,System.String,ubyte) (FullOpts)
         410 (18.55% of base) : 101323.dasm - System.Diagnostics.Tests.TagListTests:TestRemove():this (FullOpts)
         380 ( 4.25% of base) : 95755.dasm - System.Data.Tests.DataColumnCollectionTest:Add():this (FullOpts)
         379 ( 8.20% of base) : 215564.dasm - System.Tests.NumberFormatTestHelper:TryFormatNumberTest[ulong](ulong,System.String,System.IFormatProvider,System.String,ubyte) (FullOpts)
         290 ( 5.47% of base) : 42378.dasm - Microsoft.Extensions.Logging.Test.EventSourceLoggerTest:VerifySingleEvent(System.String,System.String,System.String,System.Nullable`1[int],System.String,System.Nullable`1[int],System.String[]) (FullOpts)
         290 ( 6.18% of base) : 215735.dasm - System.Tests.NumberFormatTestHelper:TryFormatNumberTest[double](double,System.String,System.IFormatProvider,System.String,ubyte) (FullOpts)
         290 ( 6.18% of base) : 220905.dasm - System.Tests.NumberFormatTestHelper:TryFormatNumberTest[float](float,System.String,System.IFormatProvider,System.String,ubyte) (FullOpts)
         265 ( 7.53% of base) : 92773.dasm - System.Configuration.ConfigurationElement:Unmerge(System.Configuration.ConfigurationElement,System.Configuration.ConfigurationElement,int):this (FullOpts)
         213 ( 9.73% of base) : 316766.dasm - System.Threading.Tests.SemaphoreTests:MultiWaitWithAllIndexesSignaledTest():this (FullOpts)
         209 (20.88% of base) : 150985.dasm - System.MemoryTests.MemoryMarshalTests:TryGetMemoryManager_IndexLength() (FullOpts)
         205 ( 2.04% of base) : 30482.dasm - Microsoft.Extensions.SourceGeneration.Configuration.Binder.Tests.ConfigurationBinderCollectionTests:TestOptionsWithDifferentCollectionInterfaces():this (FullOpts)
         203 ( 7.87% of base) : 216393.dasm - System.Text.Tests.CompositeFormatTests:MemoryExtensionsTryWrite_Valid(System.IFormatProvider,System.String,System.Object[],System.String) (FullOpts)
         189 ( 3.48% of base) : 215140.dasm - System.Tests.NumberFormatTestHelper:TryFormatNumberTest[System.Decimal](System.Decimal,System.String,System.IFormatProvider,System.String,ubyte) (FullOpts)
         188 ( 9.77% of base) : 225250.dasm - System.Tests.NullableTests:MutatingMethods_MutationsAffectOriginal() (FullOpts)
         178 ( 9.29% of base) : 316199.dasm - System.Threading.Tests.AutoResetEventTests:MultiWaitWithAllIndexesSetTest():this (FullOpts)
         175 ( 9.61% of base) : 316749.dasm - System.Threading.Tests.SemaphoreTests:MultiWaitWithInnerIndexesSignaled():this (FullOpts)
         165 ( 1.71% of base) : 270890.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:WriteHelloWorldEscaped(System.Text.Json.JsonWriterOptions):this (FullOpts)

Top method improvements (bytes):
       -2040 (-10.69% of base) : 298630.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5069_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
       -1415 (-33.43% of base) : 25589.dasm - Microsoft.CSharp.RuntimeBinder.Errors.ErrorHandling:Error(int,Microsoft.CSharp.RuntimeBinder.Errors.ErrArg[]):Microsoft.CSharp.RuntimeBinder.RuntimeBinderException (FullOpts)
       -1271 (-23.14% of base) : 272109.dasm - System.Text.Json.Serialization.Tests.ObjectWithObjectProperties:.ctor():this (FullOpts)
        -993 (-13.34% of base) : 268443.dasm - System.Text.Json.Serialization.Tests.SimpleTestClass:Initialize():this (FullOpts)
        -993 (-13.34% of base) : 268873.dasm - System.Text.Json.Serialization.Tests.SimpleTestClassWithFields:Initialize():this (FullOpts)
        -963 (-17.10% of base) : 2909.dasm - Microsoft.VisualStudio.Composition.AttributedPartDiscovery:TryCreateImportDefinition(System.Type,System.Reflection.ICustomAttributeProvider,System.Collections.Immutable.ImmutableHashSet`1[Microsoft.VisualStudio.Composition.IImportSatisfiabilityConstraint],byref):ubyte:this (FullOpts)
        -921 (-16.74% of base) : 272228.dasm - System.Text.Json.Serialization.Tests.SimpleTestClassWithObject:Initialize():this (FullOpts)
        -918 (-16.85% of base) : 217031.dasm - System.Tests.DateTimeTests:ParseExact_String_String_FormatProvider_DateTimeStyles_R(System.DateTime,System.String) (FullOpts)
        -901 (-6.89% of base) : 94861.dasm - System.Data.XmlTreeGen:HandleTable(System.Data.DataTable,System.Xml.XmlDocument,System.Xml.XmlElement,ubyte):System.Xml.XmlElement:this (FullOpts)
        -836 (-28.81% of base) : 38503.dasm - Microsoft.Extensions.DependencyModel.DependencyContextWriter:WriteAssetList(System.String,System.Collections.Generic.IEnumerable`1[Microsoft.Extensions.DependencyModel.RuntimeFile],System.Text.Json.Utf8JsonWriter) (FullOpts)
        -815 (-25.34% of base) : 208585.dasm - System.Runtime.Serialization.Tests.Utils:CompareXElements(System.Xml.Linq.XElement,System.Xml.Linq.XElement):ubyte (FullOpts)
        -815 (-25.34% of base) : 173478.dasm - System.Runtime.Serialization.Tests.Utils:CompareXElements(System.Xml.Linq.XElement,System.Xml.Linq.XElement):ubyte (FullOpts)
        -815 (-25.34% of base) : 209952.dasm - System.Runtime.Serialization.Tests.Utils:CompareXElements(System.Xml.Linq.XElement,System.Xml.Linq.XElement):ubyte (FullOpts)
        -815 (-25.34% of base) : 320385.dasm - System.Runtime.Serialization.Tests.Utils:CompareXElements(System.Xml.Linq.XElement,System.Xml.Linq.XElement):ubyte (FullOpts)
        -815 (-25.34% of base) : 63308.dasm - System.Runtime.Serialization.Tests.Utils:CompareXElements(System.Xml.Linq.XElement,System.Xml.Linq.XElement):ubyte (FullOpts)
        -767 (-39.09% of base) : 187999.dasm - System.Reflection.Emit.TypeBuilderImpl:ValidateImplementedMethod(System.Reflection.MethodInfo,System.Reflection.MethodInfo):this (FullOpts)
        -721 (-2.47% of base) : 60381.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
        -680 (-9.72% of base) : 153406.dasm - System.Memory.Tests.SequenceReader.ReadTo:TryReadTo_Span(ubyte,ubyte):this (FullOpts)
        -652 (-45.82% of base) : 187666.dasm - System.Reflection.Emit.TypeBuilderImpl:MatchesTheFilter(System.Reflection.Emit.MethodBuilderImpl,int,int,int,System.Type[]):ubyte (FullOpts)
        -650 (-11.81% of base) : 217500.dasm - System.Tests.DateTimeTests:ParseExact_String_String_FormatProvider_DateTimeStyles_O(System.DateTime,System.String) (FullOpts)

Top method regressions (percentages):
         209 (20.88% of base) : 150985.dasm - System.MemoryTests.MemoryMarshalTests:TryGetMemoryManager_IndexLength() (FullOpts)
         410 (18.55% of base) : 101323.dasm - System.Diagnostics.Tests.TagListTests:TestRemove():this (FullOpts)
         140 (18.45% of base) : 20884.dasm - System.Net.Security.SslConnectionInfo:GetNegotiatedApplicationProtocol(System.Net.Security.SafeDeleteContext):ubyte[] (FullOpts)
         578 (14.65% of base) : 204070.dasm - System.Numerics.Tests.ComplexTests:ToStringTest(double,double) (FullOpts)
           4 (13.79% of base) : 5997.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
          78 (11.35% of base) : 152940.dasm - System.MemoryTests.MemoryTests:SliceWithStartAndLengthPastEnd() (FullOpts)
         113 (11.08% of base) : 153770.dasm - System.SpanTests.ReadOnlySpanTests:StartsWithNoMatch() (FullOpts)
         113 (11.08% of base) : 151592.dasm - System.SpanTests.SpanTests:StartsWithNoMatch() (FullOpts)
          76 (11.03% of base) : 153000.dasm - System.MemoryTests.MemoryTests:SliceWithStartAndLength() (FullOpts)
          76 (11.03% of base) : 153057.dasm - System.MemoryTests.MemoryTests:SliceWithStartAndLengthUpToEnd() (FullOpts)
          78 (10.99% of base) : 152692.dasm - System.MemoryTests.ReadOnlyMemoryTests:SliceWithStartAndLengthPastEnd() (FullOpts)
          78 (10.89% of base) : 153180.dasm - System.MemoryTests.MemoryTests:SliceWithStart() (FullOpts)
          76 (10.84% of base) : 152758.dasm - System.MemoryTests.ReadOnlyMemoryTests:SliceWithStartAndLength() (FullOpts)
          76 (10.84% of base) : 152715.dasm - System.MemoryTests.ReadOnlyMemoryTests:SliceWithStartAndLengthUpToEnd() (FullOpts)
          78 (10.73% of base) : 152769.dasm - System.MemoryTests.ReadOnlyMemoryTests:SliceWithStart() (FullOpts)
          78 (10.68% of base) : 153021.dasm - System.MemoryTests.MemoryTests:SliceWithStartPastEnd() (FullOpts)
          78 (10.68% of base) : 152757.dasm - System.MemoryTests.ReadOnlyMemoryTests:SliceWithStartPastEnd() (FullOpts)
         520 (10.34% of base) : 216605.dasm - System.Runtime.Tests.JitInfoTests:JitInfoIsPopulated():this (FullOpts)
          60 (10.26% of base) : 38556.dasm - Microsoft.Extensions.DependencyModel.DependencyContextJsonReader:ReadRuntimeFiles(byref):System.Collections.Generic.List`1[Microsoft.Extensions.DependencyModel.RuntimeFile] (FullOpts)
         142 ( 9.80% of base) : 152022.dasm - System.SpanTests.SpanTests:MakeSureNoChecksGoOutOfRangeIndexOfAny_TwoInteger() (FullOpts)

Top method improvements (percentages):
         -50 (-86.21% of base) : 29750.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
         -50 (-86.21% of base) : 29752.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
        -211 (-76.17% of base) : 47221.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
        -211 (-76.17% of base) : 55755.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
        -211 (-76.17% of base) : 53564.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
         -54 (-75.00% of base) : 80388.dasm - System.Collections.Tests.BitArray_GetSetTests+<>c__DisplayClass5_0:<Set_InvalidIndex_ThrowsArgumentOutOfRangeException>b__1():this (FullOpts)
        -470 (-72.98% of base) : 309304.dasm - System.Threading.Channels.Tests.ChannelTests:ChannelOptimizations_Properties_Roundtrip():this (FullOpts)
        -335 (-67.40% of base) : 234072.dasm - System.Security.Cryptography.Tests.RSATests:RSASignaturePadding_Equality():this (FullOpts)
        -481 (-67.27% of base) : 140376.dasm - System.Linq.Parallel.Tests.GroupByTests+<>c:<GroupBy_ArgumentNullException>b__33_15():System.Object:this (FullOpts)
        -256 (-66.84% of base) : 224258.dasm - System.Tests.ObjectTests:ReferenceEqualsTest() (FullOpts)
        -450 (-65.79% of base) : 140373.dasm - System.Linq.Parallel.Tests.GroupByTests+<>c:<GroupBy_ArgumentNullException>b__33_12():System.Object:this (FullOpts)
        -551 (-62.97% of base) : 140386.dasm - System.Linq.Parallel.Tests.GroupByTests+<>c:<GroupBy_ArgumentNullException>b__33_23():System.Object:this (FullOpts)
        -507 (-61.01% of base) : 140382.dasm - System.Linq.Parallel.Tests.GroupByTests+<>c:<GroupBy_ArgumentNullException>b__33_19():System.Object:this (FullOpts)
        -438 (-59.59% of base) : 63216.dasm - System.Xml.Serialization.AccessorMapping:ElementsMatch(System.Xml.Serialization.ElementAccessor[],System.Xml.Serialization.ElementAccessor[]):ubyte (FullOpts)
        -257 (-56.98% of base) : 190887.dasm - System.Reflection.Metadata.Ecma335.StringHeap:StartsWith(System.Reflection.Metadata.StringHandle,System.String,System.Reflection.Metadata.MetadataStringDecoder,ubyte):ubyte:this (FullOpts)
        -145 (-55.77% of base) : 224423.dasm - SafeHandleZeroOrMinusOneIsInvalidTests:SafeHandleMinusOneIsInvalidTest() (FullOpts)
        -289 (-54.94% of base) : 54877.dasm - Microsoft.Extensions.Options.ConfigurationExtensions.Tests.ConfigurationExtensionsTests+<>c__DisplayClass3_0:<TestNullHandling_OptionsBuilderExt_Bind>b__3():System.Object:this (FullOpts)
        -206 (-54.07% of base) : 166320.dasm - System.Net.Tests.WebProxyTest:WebProxy_UseDefaultCredentials_Roundtrip() (FullOpts)
        -117 (-53.42% of base) : 58274.dasm - Microsoft.Extensions.Options.Tests.OptionsValidationBuilderTests:EqualResults(Microsoft.Extensions.Options.ValidateOptionsResult,Microsoft.Extensions.Options.ValidateOptionsResult):ubyte (FullOpts)
         -91 (-53.22% of base) : 103188.dasm - System.Diagnostics.Tests.ProcessStartInfoTests:TestUseShellExecuteProperty_SetAndGet():this (FullOpts)

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

Total bytes of base: 14026480 (overridden on cmd)
Total bytes of diff: 13950160 (overridden on cmd)
Total bytes of delta: -76320 (-0.54 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         122 : 28090.dasm (3.07% of base)
         101 : 28018.dasm (0.88% of base)
          72 : 8148.dasm (1.98% of base)
          66 : 15577.dasm (2.00% of base)
          62 : 25424.dasm (3.54% of base)
          36 : 19499.dasm (3.47% of base)
          31 : 26828.dasm (1.51% of base)
          31 : 17914.dasm (6.18% of base)
          30 : 21580.dasm (1.69% of base)
          26 : 29482.dasm (1.73% of base)
          23 : 15113.dasm (0.52% of base)
          22 : 7890.dasm (0.81% of base)
          22 : 29499.dasm (2.23% of base)
          22 : 19378.dasm (1.49% of base)
          20 : 5976.dasm (2.48% of base)
          20 : 15403.dasm (0.91% of base)
          18 : 20242.dasm (1.66% of base)
          18 : 25905.dasm (1.45% of base)
          17 : 14626.dasm (3.78% of base)
          16 : 25619.dasm (2.81% of base)

Top file improvements (bytes):
        -519 : 8090.dasm (-35.26% of base)
        -488 : 15413.dasm (-9.02% of base)
        -364 : 10498.dasm (-16.26% of base)
        -334 : 33300.dasm (-7.48% of base)
        -330 : 10868.dasm (-2.67% of base)
        -312 : 26262.dasm (-7.39% of base)
        -302 : 32461.dasm (-22.06% of base)
        -284 : 21743.dasm (-3.79% of base)
        -283 : 22427.dasm (-12.10% of base)
        -283 : 18186.dasm (-2.52% of base)
        -277 : 29325.dasm (-3.30% of base)
        -266 : 22601.dasm (-38.83% of base)
        -264 : 28083.dasm (-42.44% of base)
        -246 : 17405.dasm (-16.07% of base)
        -243 : 29394.dasm (-45.94% of base)
        -239 : 11613.dasm (-13.44% of base)
        -238 : 26717.dasm (-16.02% of base)
        -237 : 9129.dasm (-1.19% of base)
        -233 : 15307.dasm (-16.91% of base)
        -232 : 17903.dasm (-5.19% of base)

90 total files with Code Size differences (57 improved, 33 regressed), 20 unchanged.

Top method regressions (bytes):
         122 ( 3.07% of base) : 28090.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitObjectCreationInitializer(int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase,ubyte):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]:this (FullOpts)
         101 ( 0.88% of base) : 28018.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitTupleDeconstructionArguments(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+DeconstructionVariable],System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):this (FullOpts)
          72 ( 1.98% of base) : 8148.dasm - FSharp.Compiler.CheckExpressions:TcApplicationThen(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.ConstraintSolver+OverallTy,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.Text.Range,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.Syntax.SynExpr],FSharp.Compiler.CheckExpressions+ApplicableExpr,FSharp.Compiler.TypedTree+TType,FSharp.Compiler.Syntax.SynExpr,int,ubyte,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CheckExpressions+DelayedItem]):System.Tuple`2[FSharp.Compiler.TypedTree+Expr,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
          66 ( 2.00% of base) : 15577.dasm - SixLabors.ImageSharp.Processing.Processors.Dithering.OrderedDither:ApplyQuantizationDither[SixLabors.ImageSharp.Processing.Processors.Quantization.PaletteQuantizer`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.PixelFormats.Rgba32](byref,SixLabors.ImageSharp.ImageFrame`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.IndexedImageFrame`1[SixLabors.ImageSharp.PixelFormats.Rgba32],SixLabors.ImageSharp.Rectangle):this (FullOpts)
          62 ( 3.54% of base) : 25424.dasm - Microsoft.CodeAnalysis.MarshalAsAttributeDecoder`4[System.__Canon,System.__Canon,System.__Canon,short]:DecodeMarshalAsArray(byref,Microsoft.CodeAnalysis.CommonMessageProvider,ubyte) (FullOpts)
          36 ( 3.47% of base) : 19499.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseCommaSeparatedSyntaxList[System.__Canon](byref,ushort,System.Func`2[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser,ubyte],System.Func`2[System.__Canon,System.__Canon],Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser+SkipBadTokens`1[System.__Canon],ubyte,ubyte,ubyte):Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList`1[System.__Canon]:this (FullOpts)
          31 ( 6.18% of base) : 17914.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
          31 ( 1.51% of base) : 26828.dasm - Microsoft.CodeAnalysis.CSharp.BoundDecisionDag:AddSuccessors(byref,Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode) (FullOpts)
          30 ( 1.69% of base) : 21580.dasm - System.Text.RegularExpressions.RegexLWCGCompiler:FactoryInstanceFromCode(System.String,System.Text.RegularExpressions.RegexTree,int,ubyte):System.Text.RegularExpressions.RegexRunnerFactory:this (FullOpts)
          26 ( 1.73% of base) : 29482.dasm - Microsoft.CodeAnalysis.Compilation:Emit(System.IO.Stream,System.IO.Stream,System.IO.Stream,System.IO.Stream,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.ResourceDescription],Microsoft.CodeAnalysis.Emit.EmitOptions,Microsoft.CodeAnalysis.IMethodSymbol,System.IO.Stream,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.EmbeddedText],System.IO.Stream,Microsoft.CodeAnalysis.RebuildData,System.Threading.CancellationToken):Microsoft.CodeAnalysis.Emit.EmitResult:this (FullOpts)
          23 ( 0.52% of base) : 15113.dasm - SixLabors.ImageSharp.Compression.Zlib.DeflaterEngine:SetLevel(int):this (FullOpts)
          22 ( 0.81% of base) : 7890.dasm - FSharp.Compiler.CheckExpressions:MakeAndPublishVal(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.TypedTree+ParentRef,ubyte,FSharp.Compiler.CheckExpressions+DeclKind,FSharp.Compiler.TypedTree+ValRecursiveScopeInfo,FSharp.Compiler.CheckExpressions+ValScheme,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.TypedTree+Attrib],FSharp.Compiler.Xml.XmlDoc,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+Const],ubyte):FSharp.Compiler.TypedTree+Val (FullOpts)
          22 ( 2.23% of base) : 29499.dasm - Microsoft.CodeAnalysis.Compilation:ConstructModuleSerializationProperties(Microsoft.CodeAnalysis.Emit.EmitOptions,System.String,System.Guid):Microsoft.Cci.ModulePropertiesForSerialization:this (FullOpts)
          22 ( 1.49% of base) : 19378.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentXmlTokens:.cctor() (FullOpts)
          20 ( 2.48% of base) : 5976.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader:seekReadParams(FSharp.Compiler.AbstractIL.ILBinaryReader+ILMetadataReader,FSharp.Compiler.IO.ReadOnlyByteMemory,FSharp.Compiler.AbstractIL.IL+ILType,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.AbstractIL.IL+ILType],int,int):System.Tuple`2[FSharp.Compiler.AbstractIL.IL+ILReturn,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.AbstractIL.IL+ILParameter]] (FullOpts)
          20 ( 0.91% of base) : 15403.dasm - SixLabors.ImageSharp.Formats.Jpeg.JpegDecoderCore:ProcessDefineHuffmanTablesMarker(SixLabors.ImageSharp.IO.BufferedReadStream,int):this (FullOpts)
          18 ( 1.45% of base) : 25905.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitParameter(Microsoft.CodeAnalysis.CSharp.BoundParameter):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
          18 ( 1.66% of base) : 20242.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseInterpolation(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions,System.String,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer+Interpolation,int):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationSyntax (FullOpts)
          17 ( 3.78% of base) : 14626.dasm - System.Environment:get_CurrentDirectoryCore():System.String (FullOpts)
          16 ( 2.81% of base) : 25619.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:CheckDuplicateInterceptions(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)

Top method improvements (bytes):
        -519 (-35.26% of base) : 8090.dasm - FSharp.Compiler.CheckExpressions:TcLongIdentThen(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.ConstraintSolver+OverallTy,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.Syntax.LongIdentWithDots,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CheckExpressions+DelayedItem]):System.Tuple`2[FSharp.Compiler.TypedTree+Expr,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
        -488 (-9.02% of base) : 15413.dasm - SixLabors.ImageSharp.Formats.Jpeg.Components.Decoder.SpectralConverter`1[SixLabors.ImageSharp.PixelFormats.Rgb24]:ConvertStride(int):this (FullOpts)
        -364 (-16.26% of base) : 10498.dasm - FSharp.Compiler.NicePrint+PrintTypes:layoutTypeAppWithInfoAndPrec(FSharp.Compiler.TypedTreeOps+DisplayEnv,FSharp.Compiler.TypedTreeOps+SimplifyTypes+TypeSimplificationInfo,FSharp.Compiler.Text.Layout,int,ubyte,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.TypedTree+TType]):FSharp.Compiler.Text.Layout (FullOpts)
        -334 (-7.48% of base) : 33300.dasm - Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager:ProcessBuiltin(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors,Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase,Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory,System.Collections.Generic.List`1[Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry],byref):ubyte (FullOpts)
        -330 (-2.67% of base) : 10868.dasm - FSharp.Compiler.AugmentWithHashCompare:CheckAugmentationAttribs(ubyte,FSharp.Compiler.TcGlobals+TcGlobals,FSharp.Compiler.Import+ImportMap,FSharp.Compiler.TypedTree+Entity) (FullOpts)
        -312 (-7.39% of base) : 26262.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitReturnStatement(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement):Microsoft.CodeAnalysis.CSharp.BoundNode:this (FullOpts)
        -302 (-22.06% of base) : 32461.dasm - System.Reflection.Metadata.Ecma335.MetadataBuilder:GetRowCounts():System.Collections.Immutable.ImmutableArray`1[int]:this (FullOpts)
        -284 (-3.79% of base) : 21743.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<ResultSymbol>g__resultSymbol|1055_0(Microsoft.CodeAnalysis.CSharp.LookupResult,System.String,int,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,byref,Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol,int):Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
        -283 (-12.10% of base) : 22427.dasm - Microsoft.CodeAnalysis.VersionHelper:TryParse(System.String,ubyte,ushort,ubyte,byref):ubyte (FullOpts)
        -283 (-2.52% of base) : 18186.dasm - System.Net.Http.HttpConnection+<SendAsync>d__57:MoveNext():this (FullOpts)
        -277 (-3.30% of base) : 29325.dasm - System.Text.RegularExpressions.RegexCompiler:EmitMatchCharacterClass(System.String):this (FullOpts)
        -266 (-38.83% of base) : 22601.dasm - System.Linq.ImmutableArrayExtensions:SequenceEqual[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant],System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]](System.Collections.Immutable.ImmutableArray`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]],System.Collections.Immutable.ImmutableArray`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]],System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,Microsoft.CodeAnalysis.TypedConstant]]):ubyte (FullOpts)
        -264 (-42.44% of base) : 28083.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:IdenticalParameters(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]):ubyte (FullOpts)
        -246 (-16.07% of base) : 17405.dasm - System.Enum:TryParseByName[uint](System.RuntimeType,System.ReadOnlySpan`1[ushort],ubyte,ubyte,byref):ubyte (FullOpts)
        -243 (-45.94% of base) : 29394.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:Equals(System.String,System.String):ubyte:this (FullOpts)
        -239 (-13.44% of base) : 11613.dasm - FSharp.Compiler.LexFilter:|TyparsCloseOp|_|$cont@519(Microsoft.FSharp.Collections.FSharpList`1[ushort],Microsoft.FSharp.Collections.FSharpList`1[ushort],Microsoft.FSharp.Core.Unit):Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Core.FSharpFunc`2[ubyte,FSharp.Compiler.Parser+token][],Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.Parser+token]]] (FullOpts)
        -238 (-16.02% of base) : 26717.dasm - Microsoft.CodeAnalysis.CSharp.LocalBinderFactory:VisitTryStatement(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax):this (FullOpts)
        -237 (-1.19% of base) : 9129.dasm - FSharp.Compiler.ConstraintSolver+SolveMemberConstraint@1402-8:Invoke(Microsoft.FSharp.Core.Unit):FSharp.Compiler.ErrorLogger+OperationResult`1[FSharp.Compiler.ConstraintSolver+TraitConstraintSolution]:this (FullOpts)
        -233 (-16.91% of base) : 15307.dasm - SixLabors.ImageSharp.Formats.Png.PngScanlineProcessor:ProcessRgbScanline[SixLabors.ImageSharp.PixelFormats.Rgba32](SixLabors.ImageSharp.Configuration,byref,System.ReadOnlySpan`1[ubyte],System.Span`1[SixLabors.ImageSharp.PixelFormats.Rgba32],int,int,ubyte,SixLabors.ImageSharp.PixelFormats.Rgb48,SixLabors.ImageSharp.PixelFormats.Rgb24) (FullOpts)
        -232 (-5.19% of base) : 17903.dasm - System.Net.Security.SslStream+<ForceAuthenticationAsync>d__158`1[System.Net.Security.AsyncReadWriteAdapter]:MoveNext():this (FullOpts)

Top method regressions (percentages):
           4 (13.79% of base) : 22185.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.PEPropertyOrEventHelpers:GetDeclaredAccessibilityFromAccessors(int,int):int (FullOpts)
          31 ( 6.18% of base) : 17914.dasm - Interop+Sec_Application_Protocols:ToByteArray(System.Collections.Generic.List`1[System.Net.Security.SslApplicationProtocol]):ubyte[] (FullOpts)
           9 ( 5.59% of base) : 14960.dasm - SixLabors.ImageSharp.Formats.Tiff.TiffImageFormatDetector:IsSupportedFileFormat(System.ReadOnlySpan`1[ubyte]):ubyte:this (FullOpts)
           6 ( 5.56% of base) : 30943.dasm - Microsoft.CodeAnalysis.CSharp.BoundSpillSequence+<>c:<MakeStatements>b__1_0(Microsoft.CodeAnalysis.CSharp.BoundExpression):Microsoft.CodeAnalysis.CSharp.BoundStatement:this (FullOpts)
          16 ( 4.61% of base) : 17868.dasm - System.Net.Sockets.SocketPal:Connect(System.Net.Sockets.SafeSocketHandle,System.Memory`1[ubyte]):int (FullOpts)
          17 ( 3.78% of base) : 14626.dasm - System.Environment:get_CurrentDirectoryCore():System.String (FullOpts)
          62 ( 3.54% of base) : 25424.dasm - Microsoft.CodeAnalysis.MarshalAsAttributeDecoder`4[System.__Canon,System.__Canon,System.__Canon,short]:DecodeMarshalAsArray(byref,Microsoft.CodeAnalysis.CommonMessageProvider,ubyte) (FullOpts)
          36 ( 3.47% of base) : 19499.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseCommaSeparatedSyntaxList[System.__Canon](byref,ushort,System.Func`2[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser,ubyte],System.Func`2[System.__Canon,System.__Canon],Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser+SkipBadTokens`1[System.__Canon],ubyte,ubyte,ubyte):Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList`1[System.__Canon]:this (FullOpts)
          13 ( 3.46% of base) : 18233.dasm - System.Net.Security.SslStreamPal:DecryptMessage(System.Net.Security.SafeDeleteSslContext,System.Span`1[ubyte],byref,byref):System.Net.SecurityStatusPal (FullOpts)
          10 ( 3.36% of base) : 707.dasm - System.Text.Ascii:ChangeCase[ushort,ushort,System.Text.Ascii+ToUpperConversion](System.ReadOnlySpan`1[ushort],System.Span`1[ushort],byref):int (FullOpts)
         122 ( 3.07% of base) : 28090.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitObjectCreationInitializer(int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase,ubyte):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol]:this (FullOpts)
          13 ( 3.04% of base) : 27008.dasm - Microsoft.CodeAnalysis.CSharp.BoundDagTest:Equals(Microsoft.CodeAnalysis.CSharp.BoundDagTest):ubyte:this (FullOpts)
          16 ( 2.81% of base) : 25619.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:CheckDuplicateInterceptions(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (FullOpts)
           5 ( 2.81% of base) : 32861.dasm - System.Diagnostics.NtProcessInfoHelper:GetProcessShortName(System.ReadOnlySpan`1[ushort]):System.ReadOnlySpan`1[ushort] (FullOpts)
          15 ( 2.64% of base) : 35298.dasm - System.Management.Automation.AmsiUtils:WinReportContent(System.String,System.String):ubyte (FullOpts)
           3 ( 2.50% of base) : 36465.dasm - System.Management.Automation.Runspaces.LocalPipeline:ClearStreams():this (FullOpts)
          20 ( 2.48% of base) : 5976.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader:seekReadParams(FSharp.Compiler.AbstractIL.ILBinaryReader+ILMetadataReader,FSharp.Compiler.IO.ReadOnlyByteMemory,FSharp.Compiler.AbstractIL.IL+ILType,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.AbstractIL.IL+ILType],int,int):System.Tuple`2[FSharp.Compiler.AbstractIL.IL+ILReturn,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.AbstractIL.IL+ILParameter]] (FullOpts)
           7 ( 2.45% of base) : 17608.dasm - System.Net.Http.Headers.KnownHeader:.ctor(System.String,ubyte,System.Net.Http.Headers.HttpHeaderParser,System.String[],System.Nullable`1[int],System.Nullable`1[int]):this (FullOpts)
           3 ( 2.34% of base) : 25482.dasm - Microsoft.CodeAnalysis.CSharp.Binder:WithCheckedOrUncheckedRegion(ubyte):Microsoft.CodeAnalysis.CSharp.Binder:this (FullOpts)
          22 ( 2.23% of base) : 29499.dasm - Microsoft.CodeAnalysis.Compilation:ConstructModuleSerializationProperties(Microsoft.CodeAnalysis.Emit.EmitOptions,System.String,System.Guid):Microsoft.Cci.ModulePropertiesForSerialization:this (FullOpts)

Top method improvements (percentages):
        -211 (-76.17% of base) : 29871.dasm - Microsoft.CodeAnalysis.CodeGen.ILBuilder:RewriteSpecialBlocks():this (FullOpts)
         -47 (-59.49% of base) : 61.dasm - System.RuntimeType:get_IsGenericTypeDefinition():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 297.dasm - System.RuntimeType:get_IsActualValueType():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 316.dasm - System.RuntimeType:get_IsByRefLike():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 296.dasm - System.RuntimeType:get_IsInterface():ubyte:this (FullOpts)
         -47 (-58.02% of base) : 319.dasm - System.RuntimeType:get_IsNullableOfT():ubyte:this (FullOpts)
         -47 (-55.95% of base) : 72.dasm - System.RuntimeType:get_IsGenericType():ubyte:this (FullOpts)
         -46 (-55.42% of base) : 34449.dasm - System.Management.Automation.Language.Parser:NextLBracket():System.Management.Automation.Language.Token:this (FullOpts)
         -47 (-54.65% of base) : 801.dasm - System.RuntimeType:get_IsActualEnum():ubyte:this (FullOpts)
         -47 (-54.65% of base) : 775.dasm - System.RuntimeType:IsDelegate():ubyte:this (FullOpts)
         -39 (-52.70% of base) : 15501.dasm - SixLabors.ImageSharp.Metadata.Profiles.Exif.BaseExifReader:ConvertToShort(System.ReadOnlySpan`1[ubyte]):ushort:this (FullOpts)
         -43 (-48.31% of base) : 14965.dasm - SixLabors.ImageSharp.Formats.Bmp.BmpImageFormatDetector:DetectFormat(System.ReadOnlySpan`1[ubyte]):SixLabors.ImageSharp.Formats.IImageFormat:this (FullOpts)
         -43 (-47.25% of base) : 14971.dasm - SixLabors.ImageSharp.Formats.Png.PngImageFormatDetector:DetectFormat(System.ReadOnlySpan`1[ubyte]):SixLabors.ImageSharp.Formats.IImageFormat:this (FullOpts)
        -243 (-45.94% of base) : 29394.dasm - Microsoft.CodeAnalysis.CaseInsensitiveComparison+OneToOneUnicodeComparer:Equals(System.String,System.String):ubyte:this (FullOpts)
         -50 (-44.25% of base) : 21114.dasm - Roslyn.Utilities.StringTable:TextEqualsASCII(System.String,System.ReadOnlySpan`1[ubyte]):ubyte (FullOpts)
        -169 (-43.90% of base) : 36625.dasm - System.Dynamic.Utils.TypeExtensions:MatchesArgumentTypes(System.Reflection.MethodInfo,System.Type[]):ubyte (FullOpts)
         -48 (-42.86% of base) : 17433.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
        -264 (-42.44% of base) : 28083.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:IdenticalParameters(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]):ubyte (FullOpts)
         -43 (-41.35% of base) : 592.dasm - System.RuntimeType:IsValueTypeImpl():ubyte:this (FullOpts)
        -214 (-41.00% of base) : 35004.dasm - System.Management.Automation.DotNetAdapter:SameSignature(System.Reflection.MethodBase,System.Reflection.MethodBase):ubyte (FullOpts)

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

Total bytes of base: 5161080 (overridden on cmd)
Total bytes of diff: 5109986 (overridden on cmd)
Total bytes of delta: -51094 (-0.99 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          17 : 20464.dasm (1.97% of base)
          17 : 8453.dasm (1.97% of base)
          17 : 2630.dasm (1.97% of base)
          17 : 23123.dasm (1.97% of base)
          17 : 17756.dasm (1.97% of base)
          16 : 14416.dasm (1.38% of base)
          16 : 8695.dasm (1.38% of base)
          10 : 12187.dasm (4.42% of base)
          10 : 6678.dasm (4.42% of base)
           9 : 11816.dasm (0.91% of base)
           8 : 11921.dasm (0.74% of base)
           8 : 8313.dasm (0.72% of base)
           5 : 19723.dasm (0.97% of base)
           5 : 6001.dasm (0.97% of base)
           5 : 1900.dasm (0.97% of base)
           5 : 22412.dasm (0.97% of base)
           5 : 17081.dasm (0.97% of base)
           4 : 23194.dasm (3.45% of base)
           4 : 20511.dasm (3.45% of base)
           4 : 2618.dasm (3.45% of base)

Top file improvements (bytes):
        -263 : 19331.dasm (-6.46% of base)
        -263 : 1514.dasm (-6.47% of base)
        -263 : 22005.dasm (-6.46% of base)
        -263 : 4968.dasm (-6.47% of base)
        -263 : 14766.dasm (-6.45% of base)
        -263 : 16709.dasm (-6.46% of base)
        -251 : 32365.dasm (-35.45% of base)
        -209 : 6201.dasm (-34.21% of base)
        -196 : 19210.dasm (-27.18% of base)
        -196 : 12089.dasm (-23.22% of base)
        -196 : 16525.dasm (-27.18% of base)
        -192 : 6510.dasm (-16.47% of base)
        -188 : 14877.dasm (-32.87% of base)
        -188 : 11460.dasm (-33.22% of base)
        -164 : 4170.dasm (-32.54% of base)
        -164 : 975.dasm (-32.54% of base)
        -164 : 18957.dasm (-21.72% of base)
        -164 : 16201.dasm (-26.54% of base)
        -163 : 18917.dasm (-8.90% of base)
        -160 : 21541.dasm (-35.01% of base)

82 total files with Code Size differences (60 improved, 22 regressed), 20 unchanged.

Top method regressions (bytes):
          17 ( 1.97% of base) : 20464.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 8453.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 2630.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 23123.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 17756.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          16 ( 1.38% of base) : 14416.dasm - System.Reflection.AssemblyNameParser:GetNextToken(byref):int:this (FullOpts)
          16 ( 1.38% of base) : 8695.dasm - System.Reflection.AssemblyNameParser:GetNextToken(byref):int:this (FullOpts)
          10 ( 4.42% of base) : 12187.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
          10 ( 4.42% of base) : 6678.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
           9 ( 0.91% of base) : 11816.dasm - Internal.TypeSystem.TypeDesc:RetrieveRuntimeTypeHandleIfPossible():ubyte:this (FullOpts)
           8 ( 0.74% of base) : 11921.dasm - System.Type:GetEnumData(byref,byref):this (FullOpts)
           8 ( 0.72% of base) : 8313.dasm - System.Type:GetEnumData(byref,byref):this (FullOpts)
           5 ( 0.97% of base) : 19723.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 6001.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 1900.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 22412.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 17081.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           4 ( 3.45% of base) : 23194.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
           4 ( 3.45% of base) : 20511.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
           4 ( 3.45% of base) : 2618.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)

Top method improvements (bytes):
        -263 (-6.46% of base) : 19331.dasm - System.Threading.Lock:TryEnterSlow(int,System.Threading.Lock+ThreadId):System.Threading.Lock+ThreadId:this (FullOpts)
        -263 (-6.47% of base) : 1514.dasm - System.Threading.Lock:TryEnterSlow(int,System.Threading.Lock+ThreadId):System.Threading.Lock+ThreadId:this (FullOpts)
        -263 (-6.46% of base) : 22005.dasm - System.Threading.Lock:TryEnterSlow(int,System.Threading.Lock+ThreadId):System.Threading.Lock+ThreadId:this (FullOpts)
        -263 (-6.47% of base) : 4968.dasm - System.Threading.Lock:TryEnterSlow(int,System.Threading.Lock+ThreadId):System.Threading.Lock+ThreadId:this (FullOpts)
        -263 (-6.45% of base) : 14766.dasm - System.Threading.Lock:TryEnterSlow(int,System.Threading.Lock+ThreadId):System.Threading.Lock+ThreadId:this (FullOpts)
        -263 (-6.46% of base) : 16709.dasm - System.Threading.Lock:TryEnterSlow(int,System.Threading.Lock+ThreadId):System.Threading.Lock+ThreadId:this (FullOpts)
        -251 (-35.45% of base) : 32365.dasm - SimpleReadWriteThreadStaticTest:GenericReadWriteThreadStaticsTest(int,System.String) (FullOpts)
        -209 (-34.21% of base) : 6201.dasm - Internal.Reflection.Execution.ConstraintValidator:EnsureSatisfiesClassConstraints(System.Type[],System.Type[],System.Object,Internal.Reflection.Execution.ConstraintValidator+SigTypeContext) (FullOpts)
        -196 (-27.18% of base) : 19210.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[int,System.Buffers.IndexOfAnyAsciiSearcher+Negate,System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle,System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[short]](byref,int,byref):int (FullOpts)
        -196 (-27.18% of base) : 16525.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[int,System.Buffers.IndexOfAnyAsciiSearcher+Negate,System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle,System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[short]](byref,int,byref):int (FullOpts)
        -196 (-23.22% of base) : 12089.dasm - System.SpanHelpers:SequenceEqual[System.__Canon](byref,byref,int):ubyte (FullOpts)
        -192 (-16.47% of base) : 6510.dasm - System.SpanHelpers:SequenceEqual[System.__Canon](byref,byref,int):ubyte (FullOpts)
        -188 (-32.87% of base) : 14877.dasm - Internal.Reflection.Execution.ConstraintValidator:EnsureSatisfiesClassConstraints(System.Type[],System.Type[],System.Object,Internal.Reflection.Execution.ConstraintValidator+SigTypeContext) (FullOpts)
        -188 (-33.22% of base) : 11460.dasm - Internal.Reflection.Execution.ConstraintValidator:EnsureSatisfiesClassConstraints(System.Type[],System.Type[],System.Object,Internal.Reflection.Execution.ConstraintValidator+SigTypeContext) (FullOpts)
        -164 (-32.54% of base) : 4170.dasm - System.SpanHelpers:NonPackedIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
        -164 (-32.54% of base) : 975.dasm - System.SpanHelpers:NonPackedIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
        -164 (-21.72% of base) : 18957.dasm - System.SpanHelpers:NonPackedIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
        -164 (-26.54% of base) : 16201.dasm - System.SpanHelpers:NonPackedIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
        -163 (-8.90% of base) : 18917.dasm - System.Text.Ascii:NarrowUtf16ToAscii(ulong,ulong,ulong):ulong (FullOpts)
        -160 (-35.01% of base) : 21541.dasm - System.SpanHelpers:NonPackedIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)

Top method regressions (percentages):
          10 ( 4.42% of base) : 12187.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
          10 ( 4.42% of base) : 6678.dasm - System.Reflection.Runtime.General.NativeFormatMetadataReaderExtensions+<AsEnumerable>d__24:MoveNext():ubyte:this (FullOpts)
           4 ( 3.45% of base) : 23194.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
           4 ( 3.45% of base) : 20511.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
           4 ( 3.45% of base) : 2618.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
           4 ( 3.45% of base) : 17853.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
           4 ( 3.45% of base) : 8510.dasm - System.IO.Path:GetDirectoryName(System.String):System.String (FullOpts)
          17 ( 1.97% of base) : 20464.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 8453.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 2630.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 23123.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          17 ( 1.97% of base) : 17756.dasm - System.Globalization.CalendarData:FixDefaultShortDatePattern(System.Collections.Generic.List`1[System.String]) (FullOpts)
          16 ( 1.38% of base) : 14416.dasm - System.Reflection.AssemblyNameParser:GetNextToken(byref):int:this (FullOpts)
          16 ( 1.38% of base) : 8695.dasm - System.Reflection.AssemblyNameParser:GetNextToken(byref):int:this (FullOpts)
           5 ( 0.97% of base) : 19723.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 6001.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 1900.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 22412.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           5 ( 0.97% of base) : 17081.dasm - System.Reflection.Runtime.General.ReflectionCoreCallbacksImplementation+EnumUnderlyingTypeComparer:Compare(System.Object,System.Object):int:this (FullOpts)
           9 ( 0.91% of base) : 11816.dasm - Internal.TypeSystem.TypeDesc:RetrieveRuntimeTypeHandleIfPossible():ubyte:this (FullOpts)

Top method improvements (percentages):
         -55 (-62.50% of base) : 24892.dasm - System.Buffers.BitVector256:Contains128(ushort):ubyte:this (FullOpts)
         -55 (-62.50% of base) : 24231.dasm - System.Buffers.BitVector256:Contains256(ushort):ubyte:this (FullOpts)
         -84 (-52.50% of base) : 1344.dasm - System.Buffers.Latin1CharSearchValues:IndexOfAny[System.Buffers.IndexOfAnyAsciiSearcher+Negate](byref,int):int:this (FullOpts)
         -84 (-52.50% of base) : 4887.dasm - System.Buffers.Latin1CharSearchValues:IndexOfAny[System.Buffers.IndexOfAnyAsciiSearcher+Negate](byref,int):int:this (FullOpts)
        -146 (-43.84% of base) : 2414.dasm - System.SpanHelpers:LastIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
        -146 (-43.84% of base) : 6270.dasm - System.SpanHelpers:LastIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
        -146 (-43.84% of base) : 22897.dasm - System.SpanHelpers:LastIndexOfValueType[short,System.SpanHelpers+DontNegate`1[short]](byref,short,int):int (FullOpts)
         -48 (-43.24% of base) : 182.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
         -48 (-43.24% of base) : 15378.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
         -48 (-43.24% of base) : 18035.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
         -48 (-43.24% of base) : 3097.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
         -48 (-43.24% of base) : 20694.dasm - System.String:Equals(System.String):ubyte:this (FullOpts)
        -135 (-41.41% of base) : 11878.dasm - Internal.Runtime.CompilerServices.RuntimeSignature:Equals(Internal.Runtime.CompilerServices.RuntimeSignature):ubyte:this (FullOpts)
        -135 (-41.41% of base) : 6668.dasm - Internal.Runtime.CompilerServices.RuntimeSignature:Equals(Internal.Runtime.CompilerServices.RuntimeSignature):ubyte:this (FullOpts)
         -48 (-41.38% of base) : 18873.dasm - System.String:Equals(System.String,System.String):ubyte (FullOpts)
         -48 (-41.38% of base) : 1056.dasm - System.String:Equals(System.String,System.String):ubyte (FullOpts)
         -48 (-41.38% of base) : 3304.dasm - System.String:Equals(System.String,System.String):ubyte (FullOpts)
         -48 (-41.38% of base) : 21596.dasm - System.String:Equals(System.String,System.String):ubyte (FullOpts)
         -48 (-41.38% of base) : 16244.dasm - System.String:Equals(System.String,System.String):ubyte (FullOpts)
        -112 (-40.88% of base) : 27999.dasm - System.SpanHelpers:LastIndexOfValueType[long,System.SpanHelpers+DontNegate`1[long]](byref,long,int):int (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
