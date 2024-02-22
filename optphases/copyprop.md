Diffs are based on <span style="color:#1460aa">2,450,475</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,495,181</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">7,201 (0.29%)</span>, diff: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitDoCopyProp=0


<details>
<summary>Overall (<span style="color:green">-1,517,038</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,449,947|<span style="color:green">-36,594</span>|<span style="color:green">-1.12%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,521,636|<span style="color:green">-77,888</span>|<span style="color:green">-0.98%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,726,982|<span style="color:green">-15,739</span>|<span style="color:green">-1.79%</span>|
|coreclr_tests.run.windows.x64.checked.mch|386,972,045|<span style="color:green">-161,169</span>|<span style="color:green">-0.69%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,185,375|<span style="color:green">-86,282</span>|<span style="color:green">-1.19%</span>|
|libraries.pmi.windows.x64.checked.mch|61,599,594|<span style="color:green">-165,131</span>|<span style="color:green">-1.07%</span>|
|libraries_tests.run.windows.x64.Release.mch|285,356,563|<span style="color:green">-445,448</span>|<span style="color:green">-0.72%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|136,812,053|<span style="color:green">-469,026</span>|<span style="color:green">-1.16%</span>|
|realworld.run.windows.x64.checked.mch|14,015,797|<span style="color:green">-35,861</span>|<span style="color:green">-0.64%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,141,276|<span style="color:green">-23,900</span>|<span style="color:green">-2.53%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-1,517,038</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,449,587|<span style="color:green">-36,594</span>|<span style="color:green">-1.12%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,619,012|<span style="color:green">-77,888</span>|<span style="color:green">-0.98%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,494,199|<span style="color:green">-15,739</span>|<span style="color:green">-1.79%</span>|
|coreclr_tests.run.windows.x64.checked.mch|106,528,896|<span style="color:green">-161,169</span>|<span style="color:green">-0.69%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,184,188|<span style="color:green">-86,282</span>|<span style="color:green">-1.19%</span>|
|libraries.pmi.windows.x64.checked.mch|61,486,100|<span style="color:green">-165,131</span>|<span style="color:green">-1.07%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,709,544|<span style="color:green">-445,448</span>|<span style="color:green">-0.72%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|126,519,174|<span style="color:green">-469,026</span>|<span style="color:green">-1.16%</span>|
|realworld.run.windows.x64.checked.mch|13,629,629|<span style="color:green">-35,861</span>|<span style="color:green">-0.64%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,140,329|<span style="color:green">-23,900</span>|<span style="color:green">-2.53%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 29161.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -20,26 +20,20 @@ G_M59916_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x10]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M59916_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M59916_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59916_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-8</span> (<span style="color:green">-22.22%</span>) : 3587.dasm - System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,45 +8,39 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimeMethodInfo>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <System.Reflection.RuntimeMethodInfo>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Signature>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rbx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Signature>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M33299_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M33299_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x30]
        ; gcrRegs +[rax]
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
        test     rax, rax
        jne      SHORT G_M33299_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M33299_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rbx]
+       ; gcrRegs -[rax]
        call     [<unknown method>]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=0.50 PerfScore 1.62
-G_M33299_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+						;; size=6 bbWeight=0.50 PerfScore 1.50
+G_M33299_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       movzx    rax, byte  ptr [rax+0x30]
        ; gcrRegs -[rax]
-       movzx    rax, byte  ptr [rbx+0x30]
 						;; size=4 bbWeight=1 PerfScore 2.00
 G_M33299_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 36, prolog size 5, PerfScore 10.12, instruction count 12, allocated bytes for code 36 (MethodHash=71857dec) for method System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (FullOpts)
+; Total bytes of code 28, prolog size 4, PerfScore 8.25, instruction count 8, allocated bytes for code 28 (MethodHash=71857dec) for method System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -54,10 +48,9 @@ Unwind Info:
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
<summary><span style="color:green">-8</span> (<span style="color:green">-22.22%</span>) : 26179.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,46 +8,38 @@
 ; 0 inlinees with PGO data; 0 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol+SignatureData>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rbx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol+SignatureData>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M65327_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M65327_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x30]
        ; gcrRegs +[rax]
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
        test     rax, rax
        jne      SHORT G_M65327_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M65327_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rbx]
+       ; gcrRegs -[rax]
        call     [<unknown method>]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=0.50 PerfScore 1.62
-G_M65327_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rax, gword ptr [rbx+0x18]
-       ; gcrRegs +[rax]
+						;; size=6 bbWeight=0.50 PerfScore 1.50
+G_M65327_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       mov      rax, gword ptr [rax+0x18]
 						;; size=4 bbWeight=1 PerfScore 2.00
 G_M65327_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 36, prolog size 5, PerfScore 10.12, instruction count 12, allocated bytes for code 36 (MethodHash=433900d0) for method Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
+; Total bytes of code 28, prolog size 4, PerfScore 8.25, instruction count 8, allocated bytes for code 28 (MethodHash=433900d0) for method Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -55,10 +47,9 @@ Unwind Info:
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
<summary><span style="color:red">+38</span> (<span style="color:red">+20.11%</span>) : 813.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,25 +9,25 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T11] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T10] (  5, 11   )     int  ->  registers  
-;  V02 loc0         [V02,T00] ( 17,162.50)     int  ->  rax        
-;  V03 loc1         [V03,T05] (  2, 36   )  ushort  ->   r9        
-;  V04 loc2         [V04,T03] (  6, 41.50)    long  ->   r8        
+;  V01 arg1         [V01,T07] (  6, 15   )     int  ->  rdx        
+;  V02 loc0         [V02,T00] ( 16,158.50)     int  ->  registers  
+;  V03 loc1         [V03,T03] (  7, 56   )  ushort  ->  registers  
+;  V04 loc2         [V04,T04] (  6, 41.50)    long  ->   r8        
 ;  V05 loc3         [V05    ] (  1,  0.50)   byref  ->  [rsp+0x00]  must-init pinned single-def
-;  V06 loc4         [V06,T06] (  7, 28   )  ushort  ->  r10        
+;  V06 loc4         [V06,T10] (  3, 12   )  ushort  ->   r9        
 ;# V07 OutArgs      [V07    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T09] (  2, 16   )     int  ->  r10         "impSpillLclRefs"
-;  V09 tmp2         [V09,T07] (  3, 24   )     int  ->  r10         "dup spill"
-;* V10 tmp3         [V10,T02] (  0,  0   )     int  ->  zero-ref    "impSpillLclRefs"
-;  V11 tmp4         [V11,T08] (  3, 24   )     int  ->  rdx         "dup spill"
+;  V08 tmp1         [V08,T06] (  3, 24   )     int  ->  rax         "impSpillLclRefs"
+;  V09 tmp2         [V09,T08] (  2, 16   )     int  ->  rax         "dup spill"
+;  V10 tmp3         [V10,T01] (  2,128   )     int  ->  rax         "impSpillLclRefs"
+;  V11 tmp4         [V11,T09] (  2, 16   )     int  ->  rdx         "dup spill"
 ;* V12 tmp5         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V13 tmp6         [V13,T12] (  3,  2   )   byref  ->   r8         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V14 tmp7         [V14,T04] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V14 tmp7         [V14,T05] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V15 tmp8         [V15    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V16 tmp9         [V16    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V17 tmp10        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V18 tmp11        [V18,T13] (  2,  2   )    long  ->   r8         "Cast away GC"
-;  V19 cse0         [V19,T01] (  3, 96   )     int  ->  r10         "CSE - aggressive"
+;  V19 cse0         [V19,T02] (  3, 96   )     int  ->   r9         "CSE - aggressive"
 ;
 ; Lcl frame size = 8
 
@@ -62,59 +62,73 @@ G_M3490_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs -[r8]
        cmp      eax, ecx
        jge      SHORT G_M3490_IG03
-       mov      r10d, eax
-       inc      eax
-       movsxd   r10, r10d
-       movzx    r10, word  ptr [r8+2*r10]
-       mov      r9d, r10d
-       cmp      r10d, 34
+       lea      r10d, [rax+0x01]
+       cdqe     
+       movzx    rax, word  ptr [r8+2*rax]
+       mov      r9d, eax
+       cmp      eax, 34
        ja       SHORT G_M3490_IG07
-       test     r10d, r10d
+       test     eax, eax
        je       SHORT G_M3490_IG03
-       cmp      r10d, 34
+       cmp      eax, 34
        je       SHORT G_M3490_IG08
+       mov      eax, r10d
        jmp      SHORT G_M3490_IG06
-						;; size=39 bbWeight=4 PerfScore 40.00
+						;; size=37 bbWeight=4 PerfScore 41.00
 G_M3490_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      r10d, 39
+       cmp      eax, 39
        je       SHORT G_M3490_IG08
-       cmp      r10d, 59
-       je       SHORT G_M3490_IG11
-       cmp      r10d, 92
+       cmp      r9d, 59
+       je       SHORT G_M3490_IG13
+       cmp      r9d, 92
+       mov      eax, r10d
        jne      SHORT G_M3490_IG06
        cmp      eax, ecx
        jge      SHORT G_M3490_IG06
-       jmp      SHORT G_M3490_IG10
-						;; size=24 bbWeight=4 PerfScore 28.00
+       jmp      SHORT G_M3490_IG12
+						;; size=26 bbWeight=4 PerfScore 29.00
 G_M3490_IG08:        ; bbWeight=32, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      eax, ecx
-       jge      SHORT G_M3490_IG06
-       movsxd   r10, eax
-       movzx    r10, word  ptr [r8+2*r10]
-       test     r10d, r10d
+       cmp      r10d, ecx
+       jge      SHORT G_M3490_IG11
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       movsxd   r9, eax
+       movzx    r9, word  ptr [r8+2*r9]
+       test     r9d, r9d
        je       SHORT G_M3490_IG06
        inc      eax
-       cmp      r10d, r9d
-       jne      SHORT G_M3490_IG08
-						;; size=24 bbWeight=32 PerfScore 200.00
+       cmp      r9d, r10d
+       jne      SHORT G_M3490_IG10
+						;; size=34 bbWeight=32 PerfScore 224.00
 G_M3490_IG09:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r10d, eax
+       mov      eax, r10d
        jmp      SHORT G_M3490_IG06
-						;; size=2 bbWeight=4 PerfScore 8.00
-G_M3490_IG10:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=8 bbWeight=4 PerfScore 10.00
+G_M3490_IG10:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       jmp      SHORT G_M3490_IG08
+						;; size=11 bbWeight=16 PerfScore 44.00
+G_M3490_IG11:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, r10d
+       jmp      SHORT G_M3490_IG06
+						;; size=5 bbWeight=16 PerfScore 36.00
+G_M3490_IG12:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsxd   r10, eax
        cmp      word  ptr [r8+2*r10], 0
-       je       SHORT G_M3490_IG06
+       je       G_M3490_IG06
        inc      eax
-       jmp      SHORT G_M3490_IG06
-						;; size=15 bbWeight=4 PerfScore 26.00
-G_M3490_IG11:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      G_M3490_IG06
+						;; size=22 bbWeight=4 PerfScore 26.00
+G_M3490_IG13:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        dec      edx
-       mov      r10d, edx
-       test     edx, edx
-       mov      edx, r10d
-       jne      SHORT G_M3490_IG06
-						;; size=12 bbWeight=4 PerfScore 8.00
-G_M3490_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, r10d
+       jne      G_M3490_IG06
+						;; size=11 bbWeight=4 PerfScore 6.00
+G_M3490_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        cmp      eax, ecx
        jge      G_M3490_IG03
        movsxd   rcx, eax
@@ -124,12 +138,12 @@ G_M3490_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byre
        cmp      word  ptr [r8+2*rcx], 59
        je       G_M3490_IG03
 						;; size=38 bbWeight=0.50 PerfScore 4.88
-G_M3490_IG13:        ; bbWeight=0.50, epilog, nogc, extend
+G_M3490_IG15:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 8
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 189, prolog size 7, PerfScore 324.38, instruction count 65, allocated bytes for code 189 (MethodHash=ce6bf25d) for method System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
+; Total bytes of code 227, prolog size 7, PerfScore 430.38, instruction count 75, allocated bytes for code 227 (MethodHash=ce6bf25d) for method System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+20.11%</span>) : 13171.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,25 +9,25 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T11] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T10] (  5, 11   )     int  ->  registers  
-;  V02 loc0         [V02,T00] ( 17,162.50)     int  ->  rax        
-;  V03 loc1         [V03,T05] (  2, 36   )  ushort  ->   r9        
-;  V04 loc2         [V04,T03] (  6, 41.50)    long  ->   r8        
+;  V01 arg1         [V01,T07] (  6, 15   )     int  ->  rdx        
+;  V02 loc0         [V02,T00] ( 16,158.50)     int  ->  registers  
+;  V03 loc1         [V03,T03] (  7, 56   )  ushort  ->  registers  
+;  V04 loc2         [V04,T04] (  6, 41.50)    long  ->   r8        
 ;  V05 loc3         [V05    ] (  1,  0.50)   byref  ->  [rsp+0x00]  must-init pinned single-def
-;  V06 loc4         [V06,T06] (  7, 28   )  ushort  ->  r10        
+;  V06 loc4         [V06,T10] (  3, 12   )  ushort  ->   r9        
 ;# V07 OutArgs      [V07    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T09] (  2, 16   )     int  ->  r10         "impSpillLclRefs"
-;  V09 tmp2         [V09,T07] (  3, 24   )     int  ->  r10         "dup spill"
-;* V10 tmp3         [V10,T02] (  0,  0   )     int  ->  zero-ref    "impSpillLclRefs"
-;  V11 tmp4         [V11,T08] (  3, 24   )     int  ->  rdx         "dup spill"
+;  V08 tmp1         [V08,T06] (  3, 24   )     int  ->  rax         "impSpillLclRefs"
+;  V09 tmp2         [V09,T08] (  2, 16   )     int  ->  rax         "dup spill"
+;  V10 tmp3         [V10,T01] (  2,128   )     int  ->  rax         "impSpillLclRefs"
+;  V11 tmp4         [V11,T09] (  2, 16   )     int  ->  rdx         "dup spill"
 ;* V12 tmp5         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V13 tmp6         [V13,T12] (  3,  2   )   byref  ->   r8         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V14 tmp7         [V14,T04] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V14 tmp7         [V14,T05] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V15 tmp8         [V15    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V16 tmp9         [V16    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V17 tmp10        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V18 tmp11        [V18,T13] (  2,  2   )    long  ->   r8         "Cast away GC"
-;  V19 cse0         [V19,T01] (  3, 96   )     int  ->  r10         "CSE - aggressive"
+;  V19 cse0         [V19,T02] (  3, 96   )     int  ->   r9         "CSE - aggressive"
 ;
 ; Lcl frame size = 8
 
@@ -62,59 +62,73 @@ G_M3490_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs -[r8]
        cmp      eax, ecx
        jge      SHORT G_M3490_IG03
-       mov      r10d, eax
-       inc      eax
-       movsxd   r10, r10d
-       movzx    r10, word  ptr [r8+2*r10]
-       mov      r9d, r10d
-       cmp      r10d, 34
+       lea      r10d, [rax+0x01]
+       cdqe     
+       movzx    rax, word  ptr [r8+2*rax]
+       mov      r9d, eax
+       cmp      eax, 34
        ja       SHORT G_M3490_IG07
-       test     r10d, r10d
+       test     eax, eax
        je       SHORT G_M3490_IG03
-       cmp      r10d, 34
+       cmp      eax, 34
        je       SHORT G_M3490_IG08
+       mov      eax, r10d
        jmp      SHORT G_M3490_IG06
-						;; size=39 bbWeight=4 PerfScore 40.00
+						;; size=37 bbWeight=4 PerfScore 41.00
 G_M3490_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      r10d, 39
+       cmp      eax, 39
        je       SHORT G_M3490_IG08
-       cmp      r10d, 59
-       je       SHORT G_M3490_IG11
-       cmp      r10d, 92
+       cmp      r9d, 59
+       je       SHORT G_M3490_IG13
+       cmp      r9d, 92
+       mov      eax, r10d
        jne      SHORT G_M3490_IG06
        cmp      eax, ecx
        jge      SHORT G_M3490_IG06
-       jmp      SHORT G_M3490_IG10
-						;; size=24 bbWeight=4 PerfScore 28.00
+       jmp      SHORT G_M3490_IG12
+						;; size=26 bbWeight=4 PerfScore 29.00
 G_M3490_IG08:        ; bbWeight=32, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      eax, ecx
-       jge      SHORT G_M3490_IG06
-       movsxd   r10, eax
-       movzx    r10, word  ptr [r8+2*r10]
-       test     r10d, r10d
+       cmp      r10d, ecx
+       jge      SHORT G_M3490_IG11
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       movsxd   r9, eax
+       movzx    r9, word  ptr [r8+2*r9]
+       test     r9d, r9d
        je       SHORT G_M3490_IG06
        inc      eax
-       cmp      r10d, r9d
-       jne      SHORT G_M3490_IG08
-						;; size=24 bbWeight=32 PerfScore 200.00
+       cmp      r9d, r10d
+       jne      SHORT G_M3490_IG10
+						;; size=34 bbWeight=32 PerfScore 224.00
 G_M3490_IG09:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r10d, eax
+       mov      eax, r10d
        jmp      SHORT G_M3490_IG06
-						;; size=2 bbWeight=4 PerfScore 8.00
-G_M3490_IG10:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=8 bbWeight=4 PerfScore 10.00
+G_M3490_IG10:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       jmp      SHORT G_M3490_IG08
+						;; size=11 bbWeight=16 PerfScore 44.00
+G_M3490_IG11:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, r10d
+       jmp      SHORT G_M3490_IG06
+						;; size=5 bbWeight=16 PerfScore 36.00
+G_M3490_IG12:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsxd   r10, eax
        cmp      word  ptr [r8+2*r10], 0
-       je       SHORT G_M3490_IG06
+       je       G_M3490_IG06
        inc      eax
-       jmp      SHORT G_M3490_IG06
-						;; size=15 bbWeight=4 PerfScore 26.00
-G_M3490_IG11:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      G_M3490_IG06
+						;; size=22 bbWeight=4 PerfScore 26.00
+G_M3490_IG13:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        dec      edx
-       mov      r10d, edx
-       test     edx, edx
-       mov      edx, r10d
-       jne      SHORT G_M3490_IG06
-						;; size=12 bbWeight=4 PerfScore 8.00
-G_M3490_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, r10d
+       jne      G_M3490_IG06
+						;; size=11 bbWeight=4 PerfScore 6.00
+G_M3490_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        cmp      eax, ecx
        jge      G_M3490_IG03
        movsxd   rcx, eax
@@ -124,12 +138,12 @@ G_M3490_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byre
        cmp      word  ptr [r8+2*rcx], 59
        je       G_M3490_IG03
 						;; size=38 bbWeight=0.50 PerfScore 4.88
-G_M3490_IG13:        ; bbWeight=0.50, epilog, nogc, extend
+G_M3490_IG15:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 8
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 189, prolog size 7, PerfScore 324.38, instruction count 65, allocated bytes for code 189 (MethodHash=ce6bf25d) for method System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
+; Total bytes of code 227, prolog size 7, PerfScore 430.38, instruction count 75, allocated bytes for code 227 (MethodHash=ce6bf25d) for method System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+26</span> (<span style="color:red">+24.07%</span>) : 7821.dasm - System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,12 +10,12 @@
 ;  V00 arg0         [V00,T05] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T06] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
 ;  V02 arg2         [V02,T07] (  4,  8   )   byref  ->   r8         ld-addr-op single-def
-;  V03 loc0         [V03,T00] ( 10, 34   )     int  ->  r11        
-;  V04 loc1         [V04,T01] (  5, 17   )     int  ->  rbx        
-;  V05 loc2         [V05,T02] (  5, 16.50)     int  ->  rcx        
+;  V03 loc0         [V03,T00] (  8, 26   )     int  ->  registers  
+;  V04 loc1         [V04,T03] (  5, 17   )     int  ->  rbx        
+;  V05 loc2         [V05,T04] (  5, 16.50)     int  ->  rcx        
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T03] (  2, 16   )     int  ->  rsi         "impSpillLclRefs"
-;  V08 tmp2         [V08,T04] (  2, 16   )     int  ->   r9         "impSpillLclRefs"
+;  V07 tmp1         [V07,T01] (  3, 24   )     int  ->  r11         "impSpillLclRefs"
+;  V08 tmp2         [V08,T02] (  3, 24   )     int  ->   r9         "impSpillLclRefs"
 ;  V09 tmp3         [V09,T12] (  2,  5   )   byref  ->   r9         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
 ;  V10 tmp4         [V10,T10] (  3,  6   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;  V11 tmp5         [V11,T13] (  2,  5   )   byref  ->  r10         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
@@ -51,51 +51,72 @@ G_M18424_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0106 {rcx rdx r
        xor      r11d, r11d
        xor      ebx, ebx
        test     ecx, ecx
-       jle      SHORT G_M18424_IG04
+       jle      SHORT G_M18424_IG12
 						;; size=28 bbWeight=1 PerfScore 13.75
 G_M18424_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref, isz
        cmp      r11d, r8d
-       jae      SHORT G_M18424_IG06
-       mov      esi, r11d
-       inc      r11d
+       jae      SHORT G_M18424_IG07
+       lea      esi, [r11+0x01]
+       mov      r11d, r11d
        mov      edi, ebx
        movzx    rdi, byte  ptr [r9+rdi]
-       mov      byte  ptr [rax+rsi], dil
+       mov      byte  ptr [rax+r11], dil
        inc      ebx
        cmp      ebx, ecx
-       jl       SHORT G_M18424_IG03
-						;; size=28 bbWeight=4 PerfScore 26.00
+       jl       SHORT G_M18424_IG11
+						;; size=29 bbWeight=4 PerfScore 27.00
 G_M18424_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
        ; byrRegs -[r9]
        xor      ecx, ecx
        test     edx, edx
-       jle      SHORT G_M18424_IG06
+       jle      SHORT G_M18424_IG10
 						;; size=6 bbWeight=0.50 PerfScore 0.75
 G_M18424_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
-       cmp      r11d, r8d
-       jae      SHORT G_M18424_IG06
-       mov      r9d, r11d
-       inc      r11d
-       mov      ebx, ecx
-       movzx    rbx, byte  ptr [r10+rbx]
-       mov      byte  ptr [rax+r9], bl
+       cmp      esi, r8d
+       jae      SHORT G_M18424_IG09
+       mov      r9d, esi
+       lea      esi, [r9+0x01]
+       mov      r11d, ecx
+       movzx    r11, byte  ptr [r10+r11]
+       mov      byte  ptr [rax+r9], r11b
        inc      ecx
        cmp      ecx, edx
        jl       SHORT G_M18424_IG05
-						;; size=28 bbWeight=4 PerfScore 26.00
-G_M18424_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=30 bbWeight=4 PerfScore 27.00
+G_M18424_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rax r10]
+       mov      r11d, esi
+						;; size=3 bbWeight=2 PerfScore 0.50
+G_M18424_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, r11d
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M18424_IG07:        ; bbWeight=1, epilog, nogc, extend
+G_M18424_IG08:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rsi
        pop      rdi
        ret      
 						;; size=8 bbWeight=1 PerfScore 2.75
+G_M18424_IG09:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       mov      r11d, esi
+       jmp      SHORT G_M18424_IG07
+						;; size=5 bbWeight=2 PerfScore 4.50
+G_M18424_IG10:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r11d, esi
+       jmp      SHORT G_M18424_IG07
+						;; size=5 bbWeight=0.25 PerfScore 0.56
+G_M18424_IG11:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref, isz
+       ; byrRegs +[rax r9-r10]
+       mov      r11d, esi
+       jmp      SHORT G_M18424_IG03
+						;; size=5 bbWeight=2 PerfScore 4.50
+G_M18424_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
+       ; byrRegs -[r9]
+       mov      esi, r11d
+       jmp      SHORT G_M18424_IG04
+						;; size=5 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 108, prolog size 7, PerfScore 72.75, instruction count 43, allocated bytes for code 108 (MethodHash=8d9eb807) for method System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
+; Total bytes of code 134, prolog size 7, PerfScore 85.94, instruction count 52, allocated bytes for code 134 (MethodHash=8d9eb807) for method System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-27.27%</span>) : 71799.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; with Dynamic PGO: edge weights are valid, and fgCalledCount is 9726
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
+;  V00 this         [V00,T00] (  4,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  3,  2   )     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V03 tmp2         [V03,T02] (  4,  3   )     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -21,27 +21,21 @@ G_M59916_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x10]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
-       je       SHORT G_M59916_IG05
-						;; size=12 bbWeight=1 PerfScore 3.50
-G_M59916_IG03:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rcx]
-       mov      rax, rdx
-       ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59916_IG04:        ; bbWeight=1, epilog, nogc, extend
+       je       SHORT G_M59916_IG04
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M59916_IG03:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M59916_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs -[rax rdx] +[rcx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
+G_M59916_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs -[rax] +[rcx]
+       mov      rax, gword ptr [rcx+0x18]
+       ; gcrRegs +[rax]
        jmp      SHORT G_M59916_IG03
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 22, prolog size 0, PerfScore 4.75, instruction count 8, allocated bytes for code 22 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
+; Total bytes of code 16, prolog size 0, PerfScore 4.25, instruction count 6, allocated bytes for code 16 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-15</span> (<span style="color:green">-25.86%</span>) : 67089.dasm - System.Threading.Tasks.ParallelOptions:get_EffectiveTaskScheduler():System.Threading.Tasks.TaskScheduler:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,12 +9,12 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Threading.Tasks.ParallelOptions>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Threading.Tasks.ParallelOptions>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Threading.Tasks.TaskScheduler>
-;  V03 tmp2         [V03,T02] (  3,  2   )     ref  ->  registers  
-;  V04 tmp3         [V04,T04] (  3,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Threading.Tasks.TaskScheduler>
-;  V05 tmp4         [V05,T03] (  4,  0   )     ref  ->  rcx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Threading.Tasks.TaskScheduler>
+;  V03 tmp2         [V03,T02] (  4,  3   )     ref  ->  rax        
+;  V04 tmp3         [V04,T04] (  2,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Threading.Tasks.TaskScheduler>
+;  V05 tmp4         [V05,T03] (  5,  0   )     ref  ->  rax        
 ;
 ; Lcl frame size = 40
 
@@ -25,35 +25,26 @@ G_M49208_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       mov      rcx, rax
        test     rax, rax
-       je       SHORT G_M49208_IG05
-						;; size=12 bbWeight=1 PerfScore 3.50
-G_M49208_IG03:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rax, rcx
-       ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M49208_IG04:        ; bbWeight=1, epilog, nogc, extend
+       je       SHORT G_M49208_IG04
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M49208_IG03:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
-G_M49208_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       ; gcrRegs -[rax rcx]
+G_M49208_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       ; gcrRegs -[rax]
        call     [System.Threading.Tasks.TaskScheduler:get_InternalCurrent():System.Threading.Tasks.TaskScheduler]
        ; gcrRegs +[rax]
        ; gcr arg pop 0
-       mov      rcx, rax
-       ; gcrRegs +[rcx]
-       mov      rdx, 0xD1FFAB1E      ; const ptr
+       mov      rcx, 0xD1FFAB1E      ; const ptr
        test     rax, rax
-       cmove    rcx, gword ptr [rdx]
-       mov      rax, rcx
-       mov      rcx, rax
+       cmove    rax, gword ptr [rcx]
        jmp      SHORT G_M49208_IG03
-						;; size=34 bbWeight=0 PerfScore 0.00
+						;; size=25 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 58, prolog size 4, PerfScore 5.25, instruction count 16, allocated bytes for code 58 (MethodHash=e2e83fc7) for method System.Threading.Tasks.ParallelOptions:get_EffectiveTaskScheduler():System.Threading.Tasks.TaskScheduler:this (Tier1)
+; Total bytes of code 43, prolog size 4, PerfScore 4.75, instruction count 11, allocated bytes for code 43 (MethodHash=e2e83fc7) for method System.Threading.Tasks.ParallelOptions:get_EffectiveTaskScheduler():System.Threading.Tasks.TaskScheduler:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-21.43%</span>) : 67844.dasm - Microsoft.CodeAnalysis.DiagnosticBag:AsEnumerableWithoutResolution():System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,10 +9,10 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.DiagnosticBag>
-;  V01 loc0         [V01,T02] (  3,  3   )     ref  ->  rax         class-hnd single-def <<unknown class>>
+;  V00 this         [V00,T01] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.DiagnosticBag>
+;  V01 loc0         [V01,T02] (  2,  2   )     ref  ->  rax         class-hnd single-def <<unknown class>>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  4,  4   )     ref  ->  rcx        
+;  V03 tmp1         [V03,T00] (  5,  5   )     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,17 +22,16 @@ G_M49234_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       mov      rcx, rax
-       mov      rdx, 0xD1FFAB1E      ; const ptr
+       mov      rcx, 0xD1FFAB1E      ; const ptr
+       ; gcrRegs -[rcx]
        test     rax, rax
-       cmove    rcx, gword ptr [rdx]
-       mov      rax, rcx
-						;; size=27 bbWeight=1 PerfScore 6.00
+       cmove    rax, gword ptr [rcx]
+						;; size=21 bbWeight=1 PerfScore 5.50
 G_M49234_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 28, prolog size 0, PerfScore 7.00, instruction count 7, allocated bytes for code 28 (MethodHash=36343fad) for method Microsoft.CodeAnalysis.DiagnosticBag:AsEnumerableWithoutResolution():System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]:this (Tier1)
+; Total bytes of code 22, prolog size 0, PerfScore 6.50, instruction count 5, allocated bytes for code 22 (MethodHash=36343fad) for method Microsoft.CodeAnalysis.DiagnosticBag:AsEnumerableWithoutResolution():System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+16.67%</span>) : 63087.dasm - System.Reflection.Metadata.MetadataReader:GetCustomAttribute(System.Reflection.Metadata.CustomAttributeHandle):System.Reflection.Metadata.CustomAttribute:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,17 +8,17 @@
 ; 1 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.Metadata.MetadataReader>
-;  V01 RetBuf       [V01,T00] (  5,  5   )   byref  ->  rbx         single-def
+;  V00 this         [V00,T00] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Reflection.Metadata.MetadataReader>
+;  V01 RetBuf       [V01,T01] (  5,  5   )   byref  ->  rbx         single-def
 ;* V02 arg1         [V02    ] (  0,  0   )  struct ( 8) zero-ref    single-def <System.Reflection.Metadata.CustomAttributeHandle>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.CustomAttribute>
-;  V05 tmp2         [V05,T04] (  2,  2   )     int  ->  rsi         "Inline return value spill temp"
+;  V05 tmp2         [V05,T03] (  2,  2   )     int  ->  rsi         "Inline return value spill temp"
 ;* V06 tmp3         [V06    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Reflection.Metadata.CustomAttributeHandle>
 ;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V08 tmp5         [V08,T02] (  3,  3   )     int  ->   r8         single-def "field V02._rowId (fldOffset=0x0)" P-INDEP
-;  V09 tmp6         [V09,T03] (  2,  2   )     ref  ->  rdx         single-def "field V04._reader (fldOffset=0x0)" P-INDEP
-;  V10 tmp7         [V10,T05] (  2,  2   )     int  ->  rsi         "field V04._treatmentAndRowId (fldOffset=0x8)" P-INDEP
+;* V09 tmp6         [V09,T05] (  0,  0   )     ref  ->  zero-ref    single-def "field V04._reader (fldOffset=0x0)" P-INDEP
+;  V10 tmp7         [V10,T04] (  2,  2   )     int  ->  rsi         "field V04._treatmentAndRowId (fldOffset=0x8)" P-INDEP
 ;* V11 tmp8         [V11    ] (  0,  0   )     int  ->  zero-ref    "field V06._rowId (fldOffset=0x0)" P-INDEP
 ;
 ; Lcl frame size = 0
@@ -33,27 +33,30 @@ G_M349_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, by
        ; gcrRegs +[rcx]
        mov      esi, r8d
        or       esi, 0xD1FFAB1E
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        cmp      dword ptr [rcx+0x50], 0
        cmove    esi, r8d
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rsp+0x18]
        ; gcrRegs +[rdx]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        mov      dword ptr [rbx+0x08], esi
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=34 bbWeight=1 PerfScore 6.50
+						;; size=41 bbWeight=1 PerfScore 8.25
 G_M349_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 42, prolog size 2, PerfScore 10.75, instruction count 15, allocated bytes for code 42 (MethodHash=8416fea2) for method System.Reflection.Metadata.MetadataReader:GetCustomAttribute(System.Reflection.Metadata.CustomAttributeHandle):System.Reflection.Metadata.CustomAttribute:this (Tier1)
+; Total bytes of code 49, prolog size 2, PerfScore 12.50, instruction count 16, allocated bytes for code 49 (MethodHash=8416fea2) for method System.Reflection.Metadata.MetadataReader:GetCustomAttribute(System.Reflection.Metadata.CustomAttributeHandle):System.Reflection.Metadata.CustomAttribute:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+18.92%</span>) : 29769.dasm - System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,13 +8,13 @@
 ; 1 inlinees with PGO data; 0 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[ubyte]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[ubyte]>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Threading.Tasks.ValueTask`1[ubyte]>
 ;  V04 tmp2         [V04,T02] (  2,  4   )   short  ->  rsi         "Inlining Arg"
-;  V05 tmp3         [V05,T03] (  2,  2   )     ref  ->  rdx         single-def "field V03._obj (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T04] (  2,  2   )   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
+;* V05 tmp3         [V05,T04] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._obj (fldOffset=0x0)" P-INDEP
+;  V06 tmp4         [V06,T03] (  2,  2   )   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
 ;* V07 tmp5         [V07,T05] (  0,  0   )   ubyte  ->  zero-ref    "field V03._result (fldOffset=0xa)" P-INDEP
 ;* V08 tmp6         [V08,T06] (  0,  0   )   ubyte  ->  zero-ref    "field V03._continueOnCapturedContext (fldOffset=0xb)" P-INDEP
 ;
@@ -28,12 +28,15 @@ G_M32430_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M32430_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        movsx    rsi, word  ptr [rcx+0x3C]
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rsp+0x18]
        ; gcrRegs +[rdx]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -41,14 +44,14 @@ G_M32430_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      word  ptr [rbx+0x0A], 256
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=29 bbWeight=1 PerfScore 7.75
+						;; size=36 bbWeight=1 PerfScore 9.50
 G_M32430_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 37, prolog size 2, PerfScore 12.00, instruction count 13, allocated bytes for code 37 (MethodHash=c9ba8151) for method System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)
+; Total bytes of code 44, prolog size 2, PerfScore 13.75, instruction count 14, allocated bytes for code 44 (MethodHash=c9ba8151) for method System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+20.00%</span>) : 29745.dasm - System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,13 +8,13 @@
 ; 1 inlinees with PGO data; 0 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4.00)     ref  ->  rcx         this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[System.VoidResult]>
+;  V00 this         [V00,T01] (  4,  4.00)     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[System.VoidResult]>
 ;  V01 RetBuf       [V01,T00] (  6,  6.00)   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Threading.Tasks.ValueTask>
 ;  V04 tmp2         [V04,T02] (  2,  4.00)   short  ->  rsi         "Inlining Arg"
-;  V05 tmp3         [V05,T03] (  2,  2.00)     ref  ->  rdx         single-def "field V03._obj (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T04] (  2,  2.00)   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
+;* V05 tmp3         [V05,T04] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._obj (fldOffset=0x0)" P-INDEP
+;  V06 tmp4         [V06,T03] (  2,  2.00)   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
 ;* V07 tmp5         [V07,T05] (  0,  0   )   ubyte  ->  zero-ref    "field V03._continueOnCapturedContext (fldOffset=0xa)" P-INDEP
 ;
 ; Lcl frame size = 0
@@ -27,12 +27,15 @@ G_M45522_IG01:        ; bbWeight=1.00, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 						;; size=5 bbWeight=1.00 PerfScore 2.25
 G_M45522_IG02:        ; bbWeight=1.00, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        movsx    rsi, word  ptr [rcx+0x3C]
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rsp+0x18]
        ; gcrRegs +[rdx]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -40,14 +43,14 @@ G_M45522_IG02:        ; bbWeight=1.00, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx
        mov      byte  ptr [rbx+0x0A], 1
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=27 bbWeight=1.00 PerfScore 7.75
+						;; size=34 bbWeight=1.00 PerfScore 9.50
 G_M45522_IG03:        ; bbWeight=1.00, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1.00 PerfScore 2.00
 
-; Total bytes of code 35, prolog size 2, PerfScore 12.00, instruction count 13, allocated bytes for code 35 (MethodHash=c1624e2d) for method System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)
+; Total bytes of code 42, prolog size 2, PerfScore 13.75, instruction count 14, allocated bytes for code 42 (MethodHash=c1624e2d) for method System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-38</span> (<span style="color:green">-30.89%</span>) : 42270.dasm - System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,27 +8,25 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 11   )    long  ->  registers  
-;  V01 arg1         [V01,T01] (  6, 22   )     int  ->  rbx        
+;  V00 arg0         [V00,T03] (  6, 15   )    long  ->  rdi        
+;  V01 arg1         [V01,T00] (  6, 22   )     int  ->  rbx        
 ;  V02 arg2         [V02,T08] (  3,  4   )     int  ->  rbp         single-def
-;  V03 arg3         [V03,T03] (  6, 12   )     int  ->  registers  
-;  V04 loc0         [V04,T05] (  3, 12   )   ubyte  ->  rax        
+;  V03 arg3         [V03,T02] (  8, 17   )     int  ->  rsi        
+;  V04 loc0         [V04,T07] (  2,  8   )   ubyte  ->  rax        
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )     int  ->  zero-ref   
-;  V07 tmp2         [V07,T00] (  6, 30   )     int  ->  rsi         "dup spill"
-;  V08 tmp3         [V08,T02] (  3, 24   )    long  ->  rdi         "dup spill"
+;  V07 tmp2         [V07,T01] (  4, 20   )     int  ->  rsi         "dup spill"
+;  V08 tmp3         [V08,T04] (  2, 16   )    long  ->  rdi         "dup spill"
 ;* V09 tmp4         [V09    ] (  0,  0   )    long  ->  zero-ref   
-;  V10 tmp5         [V10,T07] (  2,  8   )     int  ->  rcx        
+;  V10 tmp5         [V10,T05] (  3, 12   )     int  ->  rax        
 ;* V11 tmp6         [V11    ] (  0,  0   )    long  ->  zero-ref   
 ;* V12 tmp7         [V12    ] (  0,  0   )     int  ->  zero-ref   
-;  V13 tmp8         [V13,T06] (  3,  8   )     int  ->  rax        
+;  V13 tmp8         [V13,T06] (  3,  8   )     int  ->  rcx        
 ;* V14 tmp9         [V14    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 40
 
 G_M31567_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbp
@@ -38,69 +36,52 @@ G_M31567_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        mov      ebx, edx
        mov      ebp, r8d
        mov      esi, r9d
-						;; size=23 bbWeight=1 PerfScore 7.25
+						;; size=19 bbWeight=1 PerfScore 5.25
 G_M31567_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
        dec      esi
-       mov      r14d, esi
-       test     esi, esi
-       jl       SHORT G_M31567_IG05
-						;; size=20 bbWeight=1 PerfScore 5.00
+       js       SHORT G_M31567_IG07
+						;; size=15 bbWeight=1 PerfScore 4.50
 G_M31567_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      eax, ebx
        and      eax, 15
        add      rdi, -2
-       mov      r15, rdi
-       mov      ecx, eax
        cmp      eax, 10
-       jl       SHORT G_M31567_IG06
-						;; size=19 bbWeight=4 PerfScore 10.00
+       jl       SHORT G_M31567_IG05
+						;; size=14 bbWeight=4 PerfScore 8.00
 G_M31567_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      eax, ebp
-       jmp      SHORT G_M31567_IG07
+       mov      ecx, ebp
+       jmp      SHORT G_M31567_IG06
 						;; size=4 bbWeight=2 PerfScore 4.50
-G_M31567_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r15, rdi
-       jmp      SHORT G_M31567_IG08
-						;; size=5 bbWeight=0.50 PerfScore 1.12
-G_M31567_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      eax, 48
+G_M31567_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      ecx, 48
 						;; size=5 bbWeight=2 PerfScore 0.50
-G_M31567_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+G_M31567_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        add      eax, ecx
        mov      word  ptr [rdi], ax
        shr      ebx, 4
-       lea      esi, [r14-0x01]
-       mov      r14d, esi
-       test     esi, esi
-       jge      SHORT G_M31567_IG11
-						;; size=19 bbWeight=4 PerfScore 15.00
-G_M31567_IG08:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       dec      esi
+       jns      SHORT G_M31567_IG03
+						;; size=12 bbWeight=4 PerfScore 12.00
+G_M31567_IG07:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     ebx, ebx
-       mov      rdi, r15
        jne      SHORT G_M31567_IG03
-						;; size=7 bbWeight=8 PerfScore 12.00
-G_M31567_IG09:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=4 bbWeight=8 PerfScore 10.00
+G_M31567_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rdi
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M31567_IG10:        ; bbWeight=1, epilog, nogc, extend
+G_M31567_IG09:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M31567_IG11:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rdi, r15
-       jmp      SHORT G_M31567_IG03
-						;; size=5 bbWeight=2 PerfScore 4.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 
-; Total bytes of code 123, prolog size 23, PerfScore 64.38, instruction count 50, allocated bytes for code 123 (MethodHash=f9cb84b0) for method System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (Tier1)
+; Total bytes of code 85, prolog size 19, PerfScore 48.25, instruction count 35, allocated bytes for code 85 (MethodHash=f9cb84b0) for method System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -108,15 +89,13 @@ Unwind Info:
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
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 53921.dasm - System.Linq.Expressions.Compiler.CompilerScope:get_NearestHoistedLocals():System.Linq.Expressions.Compiler.HoistedLocals:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <System.Linq.Expressions.Compiler.CompilerScope>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <System.Linq.Expressions.Compiler.CompilerScope>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Linq.Expressions.Compiler.HoistedLocals>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Linq.Expressions.Compiler.HoistedLocals>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -20,26 +20,20 @@ G_M12381_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x30]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M12381_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M12381_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x38]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M12381_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x38]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M12381_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M12381_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=ea67cfa2) for method System.Linq.Expressions.Compiler.CompilerScope:get_NearestHoistedLocals():System.Linq.Expressions.Compiler.HoistedLocals:this (Tier1)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=ea67cfa2) for method System.Linq.Expressions.Compiler.CompilerScope:get_NearestHoistedLocals():System.Linq.Expressions.Compiler.HoistedLocals:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 43793.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -20,26 +20,20 @@ G_M59916_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x10]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M59916_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M59916_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59916_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+18.92%</span>) : 22699.dasm - System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,13 +8,13 @@
 ; 0 inlinees with PGO data; 0 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[ubyte]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[ubyte]>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Threading.Tasks.ValueTask`1[ubyte]>
 ;  V04 tmp2         [V04,T02] (  2,  4   )   short  ->  rsi         "Inlining Arg"
-;  V05 tmp3         [V05,T03] (  2,  2   )     ref  ->  rdx         single-def "field V03._obj (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T04] (  2,  2   )   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
+;* V05 tmp3         [V05,T04] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._obj (fldOffset=0x0)" P-INDEP
+;  V06 tmp4         [V06,T03] (  2,  2   )   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
 ;* V07 tmp5         [V07,T05] (  0,  0   )   ubyte  ->  zero-ref    "field V03._result (fldOffset=0xa)" P-INDEP
 ;* V08 tmp6         [V08,T06] (  0,  0   )   ubyte  ->  zero-ref    "field V03._continueOnCapturedContext (fldOffset=0xb)" P-INDEP
 ;
@@ -28,12 +28,15 @@ G_M32430_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M32430_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        movsx    rsi, word  ptr [rcx+0x3C]
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rsp+0x18]
        ; gcrRegs +[rdx]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -41,14 +44,14 @@ G_M32430_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      word  ptr [rbx+0x0A], 256
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=29 bbWeight=1 PerfScore 7.75
+						;; size=36 bbWeight=1 PerfScore 9.50
 G_M32430_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 37, prolog size 2, PerfScore 12.00, instruction count 13, allocated bytes for code 37 (MethodHash=c9ba8151) for method System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)
+; Total bytes of code 44, prolog size 2, PerfScore 13.75, instruction count 14, allocated bytes for code 44 (MethodHash=c9ba8151) for method System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+20.00%</span>) : 22675.dasm - System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,13 +8,13 @@
 ; 0 inlinees with PGO data; 0 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[System.VoidResult]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Threading.Channels.AsyncOperation`1[System.VoidResult]>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Threading.Tasks.ValueTask>
 ;  V04 tmp2         [V04,T02] (  2,  4   )   short  ->  rsi         "Inlining Arg"
-;  V05 tmp3         [V05,T03] (  2,  2   )     ref  ->  rdx         single-def "field V03._obj (fldOffset=0x0)" P-INDEP
-;  V06 tmp4         [V06,T04] (  2,  2   )   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
+;* V05 tmp3         [V05,T04] (  0,  0   )     ref  ->  zero-ref    single-def "field V03._obj (fldOffset=0x0)" P-INDEP
+;  V06 tmp4         [V06,T03] (  2,  2   )   short  ->  rsi         "field V03._token (fldOffset=0x8)" P-INDEP
 ;* V07 tmp5         [V07,T05] (  0,  0   )   ubyte  ->  zero-ref    "field V03._continueOnCapturedContext (fldOffset=0xa)" P-INDEP
 ;
 ; Lcl frame size = 0
@@ -27,12 +27,15 @@ G_M45522_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M45522_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        movsx    rsi, word  ptr [rcx+0x3C]
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rsp+0x18]
        ; gcrRegs +[rdx]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -40,14 +43,14 @@ G_M45522_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      byte  ptr [rbx+0x0A], 1
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=27 bbWeight=1 PerfScore 7.75
+						;; size=34 bbWeight=1 PerfScore 9.50
 G_M45522_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 35, prolog size 2, PerfScore 12.00, instruction count 13, allocated bytes for code 35 (MethodHash=c1624e2d) for method System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)
+; Total bytes of code 42, prolog size 2, PerfScore 13.75, instruction count 14, allocated bytes for code 42 (MethodHash=c1624e2d) for method System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.78%</span>) : 44289.dasm - System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.List`1[int]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Collections.Generic.List`1[int]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[int]>
@@ -27,19 +27,23 @@ G_M47738_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M47738_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x14]
+       mov      esi, dword ptr [rdx+0x14]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        xor      eax, eax
        mov      dword ptr [rbx+0x08], eax
        mov      dword ptr [rbx+0x0C], esi
-						;; size=22 bbWeight=1 PerfScore 5.75
+						;; size=32 bbWeight=1 PerfScore 7.75
 G_M47738_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        mov      dword ptr [rbx+0x10], eax
        mov      rax, rbx
@@ -51,7 +55,7 @@ G_M47738_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 36, prolog size 2, PerfScore 11.25, instruction count 15, allocated bytes for code 36 (MethodHash=a6344585) for method System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (Tier1)
+; Total bytes of code 46, prolog size 2, PerfScore 13.25, instruction count 17, allocated bytes for code 46 (MethodHash=a6344585) for method System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 195885.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -20,26 +20,20 @@ G_M59916_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x10]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M59916_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M59916_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59916_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 240150.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -21,26 +21,20 @@ G_M54628_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M54628_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M54628_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M54628_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M54628_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M54628_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-8</span> (<span style="color:green">-22.22%</span>) : 193441.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,46 +8,38 @@
 ; 0 inlinees with PGO data; 0 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol+SignatureData>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rbx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol+SignatureData>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M65327_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     rbx
-       sub      rsp, 32
-						;; size=5 bbWeight=1 PerfScore 1.25
+       sub      rsp, 40
+						;; size=4 bbWeight=1 PerfScore 0.25
 G_M65327_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x30]
        ; gcrRegs +[rax]
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
        test     rax, rax
        jne      SHORT G_M65327_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M65327_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rbx]
+       ; gcrRegs -[rax]
        call     [<unknown method>]
        ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
-       mov      rbx, rax
-       ; gcrRegs +[rbx]
-						;; size=9 bbWeight=0.50 PerfScore 1.62
-G_M65327_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax]
-       mov      rax, gword ptr [rbx+0x18]
-       ; gcrRegs +[rax]
+						;; size=6 bbWeight=0.50 PerfScore 1.50
+G_M65327_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref
+       mov      rax, gword ptr [rax+0x18]
 						;; size=4 bbWeight=1 PerfScore 2.00
 G_M65327_IG05:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 32
-       pop      rbx
+       add      rsp, 40
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 36, prolog size 5, PerfScore 10.12, instruction count 12, allocated bytes for code 36 (MethodHash=433900d0) for method Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
+; Total bytes of code 28, prolog size 4, PerfScore 8.25, instruction count 8, allocated bytes for code 28 (MethodHash=433900d0) for method Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -55,10 +47,9 @@ Unwind Info:
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
<summary><span style="color:red">+10</span> (<span style="color:red">+25.00%</span>) : 576995.dasm - System.Collections.Generic.Stack`1[int]:GetEnumerator():System.Collections.Generic.Stack`1+Enumerator[int]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.Stack`1[int]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Collections.Generic.Stack`1[int]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Stack`1+Enumerator[int]>
@@ -27,12 +27,16 @@ G_M55802_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M55802_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x14]
+       mov      esi, dword ptr [rdx+0x14]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -42,14 +46,14 @@ G_M55802_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      dword ptr [rbx+0x10], eax
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=32 bbWeight=1 PerfScore 7.00
+						;; size=42 bbWeight=1 PerfScore 9.00
 G_M55802_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 40, prolog size 2, PerfScore 11.25, instruction count 15, allocated bytes for code 40 (MethodHash=318a2605) for method System.Collections.Generic.Stack`1[int]:GetEnumerator():System.Collections.Generic.Stack`1+Enumerator[int]:this (Tier1)
+; Total bytes of code 50, prolog size 2, PerfScore 13.25, instruction count 17, allocated bytes for code 50 (MethodHash=318a2605) for method System.Collections.Generic.Stack`1[int]:GetEnumerator():System.Collections.Generic.Stack`1+Enumerator[int]:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+26.32%</span>) : 307679.dasm - System.Reflection.Metadata.MetadataReader:get_MethodDefinitions():System.Reflection.Metadata.MethodDefinitionHandleCollection:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Reflection.Metadata.MetadataReader>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Reflection.Metadata.MetadataReader>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Reflection.Metadata.MethodDefinitionHandleCollection>
@@ -26,12 +26,16 @@ G_M61961_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M61961_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x1B8]
+       mov      esi, dword ptr [rdx+0x1B8]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -39,14 +43,14 @@ G_M61961_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      dword ptr [rbx+0x0C], esi
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=30 bbWeight=1 PerfScore 5.75
+						;; size=40 bbWeight=1 PerfScore 7.75
 G_M61961_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 38, prolog size 2, PerfScore 10.00, instruction count 13, allocated bytes for code 38 (MethodHash=455f0df6) for method System.Reflection.Metadata.MetadataReader:get_MethodDefinitions():System.Reflection.Metadata.MethodDefinitionHandleCollection:this (FullOpts)
+; Total bytes of code 48, prolog size 2, PerfScore 12.00, instruction count 15, allocated bytes for code 48 (MethodHash=455f0df6) for method System.Reflection.Metadata.MetadataReader:get_MethodDefinitions():System.Reflection.Metadata.MethodDefinitionHandleCollection:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.03%</span>) : 577450.dasm - System.Collections.Generic.List`1[long]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[long]:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.List`1[long]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Collections.Generic.List`1[long]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[long]>
@@ -27,18 +27,22 @@ G_M2362_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M2362_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x14]
+       mov      esi, dword ptr [rdx+0x14]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        xor      eax, eax
        mov      qword ptr [rbx+0x08], rax
-						;; size=20 bbWeight=1 PerfScore 4.75
+						;; size=30 bbWeight=1 PerfScore 6.75
 G_M2362_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        mov      dword ptr [rbx+0x10], eax
        mov      dword ptr [rbx+0x14], esi
@@ -51,7 +55,7 @@ G_M2362_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 37, prolog size 2, PerfScore 11.25, instruction count 15, allocated bytes for code 37 (MethodHash=2ce6f6c5) for method System.Collections.Generic.List`1[long]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[long]:this (Tier1)
+; Total bytes of code 47, prolog size 2, PerfScore 13.25, instruction count 17, allocated bytes for code 47 (MethodHash=2ce6f6c5) for method System.Collections.Generic.List`1[long]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[long]:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-43.48%</span>) : 182250.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T01] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T01] (  8, 17   )     int  ->  rcx        
 ;  V01 loc0         [V01,T02] (  4, 10   )     int  ->  rax        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  6, 30   )     int  ->  rcx         "dup spill"
+;  V03 tmp1         [V03,T00] (  4, 20   )     int  ->  rcx         "dup spill"
 ;
 ; Lcl frame size = 0
 
@@ -20,23 +20,18 @@ G_M4648_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M4648_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        xor      eax, eax
        sar      ecx, 1
-       mov      edx, ecx
-       test     ecx, ecx
        je       SHORT G_M4648_IG04
-						;; size=10 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 G_M4648_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        inc      eax
-       mov      ecx, edx
        sar      ecx, 1
-       mov      edx, ecx
-       test     ecx, ecx
        jne      SHORT G_M4648_IG03
-						;; size=12 bbWeight=4 PerfScore 10.00
+						;; size=6 bbWeight=4 PerfScore 7.00
 G_M4648_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 23, prolog size 0, PerfScore 13.25, instruction count 12, allocated bytes for code 23 (MethodHash=7eb6edd7) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
+; Total bytes of code 13, prolog size 0, PerfScore 9.75, instruction count 7, allocated bytes for code 13 (MethodHash=7eb6edd7) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-31.58%</span>) : 230730.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,11 +8,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)   byref  ->  rcx         this single-def
+;  V00 this         [V00,T00] (  4,  3.50)   byref  ->  rcx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]>
-;  V04 tmp2         [V04,T02] (  3,  2.50)     ref  ->  rdx        
+;  V03 tmp1         [V03,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]>
+;  V04 tmp2         [V04,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,26 +22,20 @@ G_M14377_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; byrRegs +[rcx]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M14377_IG04
-						;; size=11 bbWeight=1 PerfScore 3.50
+						;; size=8 bbWeight=1 PerfScore 3.25
 G_M14377_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x08]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M14377_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M14377_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M14377_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 19, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 19 (MethodHash=eb02c7d6) for method Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
+; Total bytes of code 13, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 13 (MethodHash=eb02c7d6) for method Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-31.58%</span>) : 182636.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,11 +8,11 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)   byref  ->  rcx         this single-def
+;  V00 this         [V00,T00] (  4,  3.50)   byref  ->  rcx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]>
-;  V04 tmp2         [V04,T02] (  3,  2.50)     ref  ->  rdx        
+;  V03 tmp1         [V03,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]>
+;  V04 tmp2         [V04,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,26 +22,20 @@ G_M14377_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byr
        ; byrRegs +[rcx]
        mov      rax, gword ptr [rcx]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M14377_IG04
-						;; size=11 bbWeight=1 PerfScore 3.50
+						;; size=8 bbWeight=1 PerfScore 3.25
 G_M14377_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x08]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M14377_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M14377_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M14377_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 19, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 19 (MethodHash=eb02c7d6) for method Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
+; Total bytes of code 13, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 13 (MethodHash=eb02c7d6) for method Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+26.32%</span>) : 21427.dasm - System.Collections.Generic.List`1[ubyte]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[ubyte]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.List`1[ubyte]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.Collections.Generic.List`1[ubyte]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[ubyte]>
@@ -28,12 +28,16 @@ G_M55162_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M55162_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x14]
+       mov      esi, dword ptr [rdx+0x14]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     [CORINFO_HELP_CHECKED_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -43,14 +47,14 @@ G_M55162_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      byte  ptr [rbx+0x10], 0
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=30 bbWeight=1 PerfScore 9.00
+						;; size=40 bbWeight=1 PerfScore 11.00
 G_M55162_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 38, prolog size 2, PerfScore 13.25, instruction count 15, allocated bytes for code 38 (MethodHash=79c92885) for method System.Collections.Generic.List`1[ubyte]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[ubyte]:this (FullOpts)
+; Total bytes of code 48, prolog size 2, PerfScore 15.25, instruction count 17, allocated bytes for code 48 (MethodHash=79c92885) for method System.Collections.Generic.List`1[ubyte]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[ubyte]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+26.32%</span>) : 230263.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]>
@@ -28,19 +28,23 @@ G_M45882_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M45882_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x0C]
+       mov      esi, dword ptr [rdx+0x0C]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     [CORINFO_HELP_CHECKED_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        xor      rax, rax
        ; gcrRegs +[rax]
        mov      gword ptr [rbx+0x08], rax
-						;; size=21 bbWeight=1 PerfScore 6.75
+						;; size=31 bbWeight=1 PerfScore 8.75
 G_M45882_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        mov      dword ptr [rbx+0x10], eax
@@ -54,7 +58,7 @@ G_M45882_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 38, prolog size 2, PerfScore 13.25, instruction count 15, allocated bytes for code 38 (MethodHash=d0344cc5) for method Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]:this (FullOpts)
+; Total bytes of code 48, prolog size 2, PerfScore 15.25, instruction count 17, allocated bytes for code 48 (MethodHash=d0344cc5) for method Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.03%</span>) : 157967.dasm - System.Xml.Xsl.Xslt.CompilerScopeManager`1[System.__Canon]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Xml.Xsl.Xslt.CompilerScopeManager`1[System.__Canon]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x20]  this class-hnd single-def <System.Xml.Xsl.Xslt.CompilerScopeManager`1[System.__Canon]>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[System.__Canon]>
@@ -28,13 +28,17 @@ G_M56089_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=6 bbWeight=1 PerfScore 3.25
 G_M56089_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x20], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x10]
+       mov      esi, dword ptr [rdx+0x10]
        lea      edi, [rsi+0x01]
+       mov      rdx, gword ptr [rsp+0x20]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     [CORINFO_HELP_CHECKED_ASSIGN_REF]
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -42,7 +46,7 @@ G_M56089_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      dword ptr [rbx+0x0C], edi
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=27 bbWeight=1 PerfScore 8.25
+						;; size=37 bbWeight=1 PerfScore 10.25
 G_M56089_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
@@ -50,7 +54,7 @@ G_M56089_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.50
 
-; Total bytes of code 37, prolog size 3, PerfScore 14.00, instruction count 16, allocated bytes for code 37 (MethodHash=d34724e6) for method System.Xml.Xsl.Xslt.CompilerScopeManager`1[System.__Canon]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[System.__Canon]:this (FullOpts)
+; Total bytes of code 47, prolog size 3, PerfScore 16.00, instruction count 18, allocated bytes for code 47 (MethodHash=d34724e6) for method System.Xml.Xsl.Xslt.CompilerScopeManager`1[System.__Canon]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-50.00%</span>) : 18828.dasm - System.Number:UInt32ToBinaryChars[ubyte](ulong,uint,int):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,13 +8,13 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 11   )    long  ->  registers  
-;  V01 arg1         [V01,T01] (  6, 22   )     int  ->  rdx        
-;  V02 arg2         [V02,T03] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T03] (  6, 15   )    long  ->  rcx        
+;  V01 arg1         [V01,T00] (  6, 22   )     int  ->  rdx        
+;  V02 arg2         [V02,T02] (  8, 17   )     int  ->   r8        
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     int  ->  zero-ref   
-;  V05 tmp2         [V05,T00] (  6, 30   )     int  ->   r8         "dup spill"
-;  V06 tmp3         [V06,T02] (  3, 24   )    long  ->  rcx         "dup spill"
+;  V05 tmp2         [V05,T01] (  4, 20   )     int  ->   r8         "dup spill"
+;  V06 tmp3         [V06,T04] (  2, 16   )    long  ->  rcx         "dup spill"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp5         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
@@ -25,44 +25,30 @@ G_M4807_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M4807_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      r8d
-       mov      eax, r8d
-       test     r8d, r8d
-       jl       SHORT G_M4807_IG08
-						;; size=11 bbWeight=1 PerfScore 1.75
+       js       SHORT G_M4807_IG04
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M4807_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      rcx
-       mov      r10, rcx
-       mov      r8d, edx
-       and      r8d, 1
-       add      r8d, 48
-       mov      byte  ptr [rcx], r8b
+       mov      eax, edx
+       and      eax, 1
+       add      eax, 48
+       mov      byte  ptr [rcx], al
        shr      edx, 1
-       lea      r8d, [rax-0x01]
-       mov      eax, r8d
-       test     r8d, r8d
-       jge      SHORT G_M4807_IG07
-						;; size=34 bbWeight=4 PerfScore 19.00
+       dec      r8d
+       jns      SHORT G_M4807_IG03
+						;; size=20 bbWeight=4 PerfScore 15.00
 G_M4807_IG04:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     edx, edx
-       mov      rcx, r10
        jne      SHORT G_M4807_IG03
-						;; size=7 bbWeight=8 PerfScore 12.00
+						;; size=4 bbWeight=8 PerfScore 10.00
 G_M4807_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rcx
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M4807_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M4807_IG07:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, r10
-       jmp      SHORT G_M4807_IG03
-						;; size=5 bbWeight=2 PerfScore 4.50
-G_M4807_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r10, rcx
-       jmp      SHORT G_M4807_IG04
-						;; size=5 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 66, prolog size 0, PerfScore 39.62, instruction count 24, allocated bytes for code 66 (MethodHash=098fed38) for method System.Number:UInt32ToBinaryChars[ubyte](ulong,uint,int):ulong (FullOpts)
+; Total bytes of code 33, prolog size 0, PerfScore 27.50, instruction count 14, allocated bytes for code 33 (MethodHash=098fed38) for method System.Number:UInt32ToBinaryChars[ubyte](ulong,uint,int):ulong (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-48.53%</span>) : 18835.dasm - System.Number:UInt64ToBinaryChars[ubyte](ulong,ulong,int):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,13 +8,13 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 11   )    long  ->  registers  
-;  V01 arg1         [V01,T01] (  6, 22   )    long  ->  rdx        
-;  V02 arg2         [V02,T03] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T03] (  6, 15   )    long  ->  rcx        
+;  V01 arg1         [V01,T00] (  6, 22   )    long  ->  rdx        
+;  V02 arg2         [V02,T02] (  8, 17   )     int  ->   r8        
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     int  ->  zero-ref   
-;  V05 tmp2         [V05,T00] (  6, 30   )     int  ->   r8         "dup spill"
-;  V06 tmp3         [V06,T02] (  3, 24   )    long  ->  rcx         "dup spill"
+;  V05 tmp2         [V05,T01] (  4, 20   )     int  ->   r8         "dup spill"
+;  V06 tmp3         [V06,T04] (  2, 16   )    long  ->  rcx         "dup spill"
 ;* V07 tmp4         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V08 tmp5         [V08    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
@@ -25,44 +25,30 @@ G_M861_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, n
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M861_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      r8d
-       mov      eax, r8d
-       test     r8d, r8d
-       jl       SHORT G_M861_IG08
-						;; size=11 bbWeight=1 PerfScore 1.75
+       js       SHORT G_M861_IG04
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M861_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      rcx
-       mov      r10, rcx
-       mov      r8d, edx
-       and      r8d, 1
-       add      r8d, 48
-       mov      byte  ptr [rcx], r8b
+       mov      eax, edx
+       and      eax, 1
+       add      eax, 48
+       mov      byte  ptr [rcx], al
        shr      rdx, 1
-       lea      r8d, [rax-0x01]
-       mov      eax, r8d
-       test     r8d, r8d
-       jge      SHORT G_M861_IG07
-						;; size=35 bbWeight=4 PerfScore 19.00
+       dec      r8d
+       jns      SHORT G_M861_IG03
+						;; size=21 bbWeight=4 PerfScore 15.00
 G_M861_IG04:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     rdx, rdx
-       mov      rcx, r10
        jne      SHORT G_M861_IG03
-						;; size=8 bbWeight=8 PerfScore 12.00
+						;; size=5 bbWeight=8 PerfScore 10.00
 G_M861_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rcx
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M861_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M861_IG07:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, r10
-       jmp      SHORT G_M861_IG03
-						;; size=5 bbWeight=2 PerfScore 4.50
-G_M861_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r10, rcx
-       jmp      SHORT G_M861_IG04
-						;; size=5 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 68, prolog size 0, PerfScore 39.62, instruction count 24, allocated bytes for code 68 (MethodHash=5206fca2) for method System.Number:UInt64ToBinaryChars[ubyte](ulong,ulong,int):ulong (FullOpts)
+; Total bytes of code 35, prolog size 0, PerfScore 27.50, instruction count 14, allocated bytes for code 35 (MethodHash=5206fca2) for method System.Number:UInt64ToBinaryChars[ubyte](ulong,ulong,int):ulong (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-43.48%</span>) : 156973.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T01] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T01] (  8, 17   )     int  ->  rcx        
 ;  V01 loc0         [V01,T02] (  4, 10   )     int  ->  rax        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  6, 30   )     int  ->  rcx         "dup spill"
+;  V03 tmp1         [V03,T00] (  4, 20   )     int  ->  rcx         "dup spill"
 ;
 ; Lcl frame size = 0
 
@@ -19,23 +19,18 @@ G_M4648_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M4648_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        xor      eax, eax
        sar      ecx, 1
-       mov      edx, ecx
-       test     ecx, ecx
        je       SHORT G_M4648_IG04
-						;; size=10 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 G_M4648_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        inc      eax
-       mov      ecx, edx
        sar      ecx, 1
-       mov      edx, ecx
-       test     ecx, ecx
        jne      SHORT G_M4648_IG03
-						;; size=12 bbWeight=4 PerfScore 10.00
+						;; size=6 bbWeight=4 PerfScore 7.00
 G_M4648_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 23, prolog size 0, PerfScore 13.25, instruction count 12, allocated bytes for code 23 (MethodHash=7eb6edd7) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
+; Total bytes of code 13, prolog size 0, PerfScore 9.75, instruction count 7, allocated bytes for code 13 (MethodHash=7eb6edd7) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.78%</span>) : 135310.dasm - System.Xml.Xsl.Xslt.CompilerScopeManager`1[ubyte]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[ubyte]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Xml.Xsl.Xslt.CompilerScopeManager`1[ubyte]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x20]  this class-hnd single-def <System.Xml.Xsl.Xslt.CompilerScopeManager`1[ubyte]>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[ubyte]>
@@ -27,13 +27,17 @@ G_M59161_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=6 bbWeight=1 PerfScore 3.25
 G_M59161_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x20], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x10]
+       mov      esi, dword ptr [rdx+0x10]
        lea      edi, [rsi+0x01]
+       mov      rdx, gword ptr [rsp+0x20]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -41,7 +45,7 @@ G_M59161_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      dword ptr [rbx+0x0C], edi
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=26 bbWeight=1 PerfScore 6.25
+						;; size=36 bbWeight=1 PerfScore 8.25
 G_M59161_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
@@ -49,7 +53,7 @@ G_M59161_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.50
 
-; Total bytes of code 36, prolog size 3, PerfScore 12.00, instruction count 16, allocated bytes for code 36 (MethodHash=ca4c18e6) for method System.Xml.Xsl.Xslt.CompilerScopeManager`1[ubyte]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[ubyte]:this (FullOpts)
+; Total bytes of code 46, prolog size 3, PerfScore 14.00, instruction count 18, allocated bytes for code 46 (MethodHash=ca4c18e6) for method System.Xml.Xsl.Xslt.CompilerScopeManager`1[ubyte]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[ubyte]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+43.18%</span>) : 295428.dasm - System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[double]:Invoke(System.Runtime.Intrinsics.Vector256`1[double]):System.Runtime.Intrinsics.Vector256`1[double] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,7 +11,7 @@
 ;  V00 RetBuf       [V00,T01] (  4,  4   )   byref  ->  rbx         single-def
 ;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T03] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
+;  V03 tmp1         [V03,T02] (  3,  6   )  simd32  ->  mm6         "impAppendStmt"
 ;* V04 tmp2         [V04,T04] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
 ;* V05 tmp3         [V05    ] (  0,  0   )  simd32  ->  zero-ref    "spilled call-like call argument"
 ;* V06 tmp4         [V06    ] (  0,  0   )  simd32  ->  zero-ref    "Inline return value spill temp" <System.Runtime.Intrinsics.Vector256`1[double]>
@@ -19,47 +19,50 @@
 ;* V08 tmp6         [V08    ] (  0,  0   )  simd32  ->  zero-ref    "spilled call-like call argument"
 ;  V09 tmp7         [V09    ] (  2,  2   )  simd32  ->  [rsp+0x40]  do-not-enreg[XS] addr-exposed "Inline return value spill temp" <System.Runtime.Intrinsics.Vector256`1[double]>
 ;  V10 tmp8         [V10    ] (  2,  4   )  simd32  ->  [rsp+0x20]  do-not-enreg[XS] addr-exposed "by-value struct argument" <System.Runtime.Intrinsics.Vector256`1[double]>
-;* V11 cse0         [V11,T02] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
+;  V11 cse0         [V11,T03] (  2,  2   )  simd32  ->  mm6         "CSE - aggressive"
 ;
-; Lcl frame size = 112
+; Lcl frame size = 144
 
 G_M49890_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 112
+       sub      rsp, 144
+       vmovaps  xmmword ptr [rsp+0x80], xmm6
+       vmovaps  xmmword ptr [rsp+0x70], xmm7
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
+						;; size=26 bbWeight=1 PerfScore 5.50
 G_M49890_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000C {rdx rbx}, byref
        ; byrRegs +[rdx]
+       vmovups  ymm6, ymmword ptr [reloc @RWD00]
        vmovups  ymm0, ymmword ptr [rdx]
-       vxorpd   ymm0, ymm0, qword ptr [reloc @RWD00] {1to4}
+       vxorpd   ymm0, ymm0, qword ptr [reloc @RWD32] {1to4}
        vmovups  ymmword ptr [rsp+0x20], ymm0
        lea      rdx, [rsp+0x20]
        ; byrRegs -[rdx]
        lea      rcx, [rsp+0x40]
+       vextractf128 xmm7, ymm6, 1
        call     [<unknown method>]
        ; gcr arg pop 0
-       vmovups  ymm0, ymmword ptr [rsp+0x40]
-       vaddpd   ymm0, ymm0, qword ptr [reloc @RWD08] {1to4}
-       vmovups  ymm1, ymmword ptr [reloc @RWD32]
-       vdivpd   ymm0, ymm1, ymm0
+       vinsertf128 ymm6, ymm6, xmm7, 1
+       vaddpd   ymm0, ymm6, ymmword ptr [rsp+0x40]
+       vdivpd   ymm0, ymm6, ymm0
        vmovups  ymmword ptr [rbx], ymm0
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=71 bbWeight=1 PerfScore 39.25
+						;; size=73 bbWeight=1 PerfScore 39.25
 G_M49890_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 112
+       vmovaps  xmm6, xmmword ptr [rsp+0x80]
+       vmovaps  xmm7, xmmword ptr [rsp+0x70]
+       add      rsp, 144
        pop      rbx
        ret      
-						;; size=9 bbWeight=1 PerfScore 2.75
-RWD00  	dq	8000000000000000h	;           -0
-RWD08  	dq	3FF0000000000000h	;            1
-RWD16  	dd	00000000h, 00000000h, 00000000h, 00000000h
-RWD32  	dq	3FF0000000000000h, 3FF0000000000000h, 3FF0000000000000h, 3FF0000000000000h
+						;; size=27 bbWeight=1 PerfScore 10.75
+RWD00  	dq	3FF0000000000000h, 3FF0000000000000h, 3FF0000000000000h, 3FF0000000000000h
+RWD32  	dq	8000000000000000h	;           -0
 
 
-; Total bytes of code 88, prolog size 5, PerfScore 43.50, instruction count 19, allocated bytes for code 88 (MethodHash=e7bf3d1d) for method System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[double]:Invoke(System.Runtime.Intrinsics.Vector256`1[double]):System.Runtime.Intrinsics.Vector256`1[double] (FullOpts)
+; Total bytes of code 126, prolog size 23, PerfScore 55.50, instruction count 24, allocated bytes for code 126 (MethodHash=e7bf3d1d) for method System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[double]:Invoke(System.Runtime.Intrinsics.Vector256`1[double]):System.Runtime.Intrinsics.Vector256`1[double] (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -67,10 +70,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x17
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 13 * 8 + 8 = 112 = 0x70
+    CodeOffset: 0x17 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 7 * 16 = 112 = 0x00070
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 8 * 16 = 128 = 0x00080
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 18 * 8 = 144 = 0x00090
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+50.00%</span>) : 211753.dasm - System.Data.Common.SafeNativeMethods:InterlockedExchangePointer(long,long):long (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,32 +10,35 @@
 ;
 ;  V00 arg0         [V00,T02] (  4, 11   )    long  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T03] (  3, 10   )    long  ->  rdx         single-def
-;  V02 loc0         [V02,T01] (  3, 17   )    long  ->   r8        
-;  V03 loc1         [V03,T00] (  5, 33   )    long  ->  rax        
+;  V02 loc0         [V02,T00] (  4, 25   )    long  ->  [rsp+0x00] 
+;  V03 loc1         [V03,T01] (  4, 25   )    long  ->  rax        
 ;# V04 OutArgs      [V04    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
-; Lcl frame size = 0
+; Lcl frame size = 8
 
 G_M34809_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
+       push     rax
+						;; size=1 bbWeight=1 PerfScore 1.00
 G_M34809_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, qword ptr [rcx]
 						;; size=3 bbWeight=1 PerfScore 2.00
 G_M34809_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r8, rax
+       mov      qword ptr [rsp], rax
        lock     
        cmpxchg  qword ptr [rcx], rdx
+       mov      r8, qword ptr [rsp]
        cmp      rax, r8
        jne      SHORT G_M34809_IG03
-						;; size=13 bbWeight=8 PerfScore 156.00
+						;; size=18 bbWeight=8 PerfScore 170.00
 G_M34809_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, r8
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M34809_IG05:        ; bbWeight=1, epilog, nogc, extend
+       add      rsp, 8
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 20, prolog size 0, PerfScore 159.25, instruction count 8, allocated bytes for code 20 (MethodHash=3dc17806) for method System.Data.Common.SafeNativeMethods:InterlockedExchangePointer(long,long):long (FullOpts)
+; Total bytes of code 30, prolog size 1, PerfScore 174.50, instruction count 11, allocated bytes for code 30 (MethodHash=3dc17806) for method System.Data.Common.SafeNativeMethods:InterlockedExchangePointer(long,long):long (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -43,8 +46,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x01
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-31</span> (<span style="color:green">-31.00%</span>) : 521060.dasm - System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,77 +9,59 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 69.06)    long  ->  registers  
+;  V00 arg0         [V00,T04] (  6,102.09)    long  ->  rdi        
 ;  V01 arg1         [V01,T02] (  6,115.73)    long  ->  rbx        
-;  V02 arg2         [V02,T03] (  6, 70.06)     int  ->  registers  
+;  V02 arg2         [V02,T03] (  8,104.09)     int  ->  rsi        
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     int  ->  zero-ref   
-;  V05 tmp2         [V05,T00] (  6,204.18)     int  ->  rsi         "dup spill"
-;  V06 tmp3         [V06,T01] (  3,198.18)    long  ->  rdi         "dup spill"
+;  V05 tmp2         [V05,T00] (  4,136.12)     int  ->  rsi         "dup spill"
+;  V06 tmp3         [V06,T01] (  2,132.12)    long  ->  rdi         "dup spill"
 ;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 32
 
 G_M17765_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r14
        push     rdi
        push     rsi
-       push     rbp
        push     rbx
        sub      rsp, 32
        mov      rdi, rcx
        mov      rbx, rdx
        mov      esi, r8d
-						;; size=19 bbWeight=1 PerfScore 6.00
+						;; size=16 bbWeight=1 PerfScore 4.00
 G_M17765_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
        dec      esi
-       mov      ebp, esi
-       test     esi, esi
-       jl       SHORT G_M17765_IG08
-						;; size=19 bbWeight=1 PerfScore 5.00
+       js       SHORT G_M17765_IG04
+						;; size=15 bbWeight=1 PerfScore 4.50
 G_M17765_IG03:        ; bbWeight=33.03, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        add      rdi, -2
-       mov      r14, rdi
        mov      eax, ebx
        and      eax, 1
        add      eax, 48
        mov      word  ptr [rdi], ax
        shr      rbx, 1
-       lea      esi, [rbp-0x01]
-       mov      ebp, esi
-       test     esi, esi
-       jge      SHORT G_M17765_IG07
-						;; size=30 bbWeight=33.03 PerfScore 156.89
+       dec      esi
+       jns      SHORT G_M17765_IG03
+						;; size=22 bbWeight=33.03 PerfScore 123.86
 G_M17765_IG04:        ; bbWeight=14.64, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     rbx, rbx
-       mov      rdi, r14
        jne      SHORT G_M17765_IG03
-						;; size=8 bbWeight=14.64 PerfScore 21.95
+						;; size=5 bbWeight=14.64 PerfScore 18.30
 G_M17765_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rdi
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M17765_IG06:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
-       pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
        ret      
-						;; size=11 bbWeight=1 PerfScore 3.75
-G_M17765_IG07:        ; bbWeight=16.52, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rdi, r14
-       jmp      SHORT G_M17765_IG03
-						;; size=5 bbWeight=16.52 PerfScore 37.16
-G_M17765_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r14, rdi
-       jmp      SHORT G_M17765_IG04
-						;; size=5 bbWeight=0.50 PerfScore 1.12
+						;; size=8 bbWeight=1 PerfScore 2.75
 
-; Total bytes of code 100, prolog size 19, PerfScore 232.13, instruction count 41, allocated bytes for code 100 (MethodHash=3dc0ba9a) for method System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (Tier1)
+; Total bytes of code 69, prolog size 16, PerfScore 153.66, instruction count 27, allocated bytes for code 69 (MethodHash=3dc0ba9a) for method System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -87,14 +69,12 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x07
+  CountOfUnwindCodes: 4
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:green">-38</span> (<span style="color:green">-30.16%</span>) : 521055.dasm - System.Number:Int64ToHexChars[ushort](ulong,ulong,int,int):ulong (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,70 +9,61 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T05] (  5, 33.43)    long  ->  registers  
-;  V01 arg1         [V01,T02] (  6, 49.96)    long  ->  rbx        
+;  V00 arg0         [V00,T04] (  6, 48.65)    long  ->  rdi        
+;  V01 arg1         [V01,T03] (  6, 49.96)    long  ->  rsi        
 ;  V02 arg2         [V02,T08] (  3,  2   )     int  ->  rbp         single-def
-;  V03 arg3         [V03,T04] (  6, 34.43)     int  ->  registers  
-;  V04 loc0         [V04,T03] (  3, 45.65)   ubyte  ->  rax        
+;  V03 arg3         [V03,T02] (  8, 50.65)     int  ->  rbx        
+;  V04 loc0         [V04,T07] (  2, 30.43)   ubyte  ->  rax        
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )     int  ->  zero-ref   
-;  V07 tmp2         [V07,T00] (  6, 97.30)     int  ->  rsi         "dup spill"
-;  V08 tmp3         [V08,T01] (  3, 91.30)    long  ->  rdi         "dup spill"
+;  V07 tmp2         [V07,T00] (  4, 64.87)     int  ->  rbx         "dup spill"
+;  V08 tmp3         [V08,T01] (  2, 60.87)    long  ->  rdi         "dup spill"
 ;* V09 tmp4         [V09    ] (  0,  0   )    long  ->  zero-ref   
-;  V10 tmp5         [V10,T07] (  2, 30.43)     int  ->  rcx        
+;  V10 tmp5         [V10,T05] (  3, 45.65)     int  ->  rax        
 ;* V11 tmp6         [V11    ] (  0,  0   )    long  ->  zero-ref   
 ;* V12 tmp7         [V12    ] (  0,  0   )     int  ->  zero-ref   
-;  V13 tmp8         [V13,T06] (  3, 30.43)     int  ->  rax        
+;  V13 tmp8         [V13,T06] (  3, 30.43)     int  ->  rcx        
 ;* V14 tmp9         [V14    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 40
 
 G_M58869_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
        sub      rsp, 40
        mov      rdi, rcx
-       mov      rbx, rdx
+       mov      rsi, rdx
        mov      ebp, r8d
-       mov      esi, r9d
-						;; size=24 bbWeight=1 PerfScore 7.25
+       mov      ebx, r9d
+						;; size=20 bbWeight=1 PerfScore 5.25
 G_M58869_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
-       dec      esi
-       mov      r14d, esi
-       test     esi, esi
-       jl       SHORT G_M58869_IG09
-						;; size=20 bbWeight=1 PerfScore 5.00
+       dec      ebx
+       js       SHORT G_M58869_IG05
+						;; size=15 bbWeight=1 PerfScore 4.50
 G_M58869_IG03:        ; bbWeight=15.22, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      eax, ebx
+       mov      eax, esi
        and      eax, 15
        add      rdi, -2
-       mov      r15, rdi
-       mov      ecx, eax
        cmp      eax, 10
-       jge      SHORT G_M58869_IG10
-       mov      eax, 48
-						;; size=24 bbWeight=15.22 PerfScore 41.85
+       jge      SHORT G_M58869_IG08
+       mov      ecx, 48
+						;; size=19 bbWeight=15.22 PerfScore 34.24
 G_M58869_IG04:        ; bbWeight=15.22, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        add      eax, ecx
        mov      word  ptr [rdi], ax
-       shr      rbx, 4
-       lea      esi, [r14-0x01]
-       mov      r14d, esi
-       test     esi, esi
-       jge      SHORT G_M58869_IG08
-						;; size=20 bbWeight=15.22 PerfScore 57.07
+       shr      rsi, 4
+       dec      ebx
+       jns      SHORT G_M58869_IG03
+						;; size=13 bbWeight=15.22 PerfScore 45.65
 G_M58869_IG05:        ; bbWeight=2.30, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       test     rbx, rbx
-       mov      rdi, r15
+       test     rsi, rsi
        jne      SHORT G_M58869_IG03
-						;; size=8 bbWeight=2.30 PerfScore 3.46
+						;; size=5 bbWeight=2.30 PerfScore 2.88
 G_M58869_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rdi
 						;; size=3 bbWeight=1 PerfScore 0.25
@@ -82,24 +73,14 @@ G_M58869_IG07:        ; bbWeight=1, epilog, nogc, extend
        pop      rbp
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M58869_IG08:        ; bbWeight=7.61, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rdi, r15
-       jmp      SHORT G_M58869_IG03
-						;; size=5 bbWeight=7.61 PerfScore 17.12
-G_M58869_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r15, rdi
-       jmp      SHORT G_M58869_IG05
-						;; size=5 bbWeight=0.50 PerfScore 1.12
-G_M58869_IG10:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      eax, ebp
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M58869_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       mov      ecx, ebp
        jmp      SHORT G_M58869_IG04
 						;; size=4 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 126, prolog size 24, PerfScore 137.36, instruction count 50, allocated bytes for code 126 (MethodHash=e0b01a0a) for method System.Number:Int64ToHexChars[ushort](ulong,ulong,int,int):ulong (Tier1)
+; Total bytes of code 88, prolog size 20, PerfScore 96.02, instruction count 35, allocated bytes for code 88 (MethodHash=e0b01a0a) for method System.Number:Int64ToHexChars[ushort](ulong,ulong,int,int):ulong (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -107,15 +88,13 @@ Unwind Info:
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
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 91361.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,8 +11,8 @@
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
-;  V03 tmp2         [V03,T02] (  3,  3   )     ref  ->  rdx        
+;  V02 tmp1         [V02,T02] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
+;  V03 tmp2         [V03,T01] (  4,  4   )     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -22,22 +22,16 @@ G_M54628_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M54628_IG03
-       mov      rdx, gword ptr [rcx+0x18]
-						;; size=16 bbWeight=1 PerfScore 5.50
-G_M54628_IG03:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rcx]
-       mov      rax, rdx
-       ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M54628_IG04:        ; bbWeight=1, epilog, nogc, extend
+       mov      rax, gword ptr [rcx+0x18]
+						;; size=13 bbWeight=1 PerfScore 5.25
+G_M54628_IG03:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 6.75, instruction count 7, allocated bytes for code 20 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
+; Total bytes of code 14, prolog size 0, PerfScore 6.25, instruction count 5, allocated bytes for code 14 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+27</span> (<span style="color:red">+30.00%</span>) : 321144.dasm - System.IO.Compression.ZipArchiveEntry:get_Comment():System.String:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,67 +11,76 @@
 ;
 ;  V00 this         [V00,T02] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.IO.Compression.ZipArchiveEntry>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T03] (  3,  6   )     ref  ->  rdx         class-hnd single-def "dup spill" <System.Text.Encoding>
-;  V03 tmp2         [V03,T01] (  8,  6   )     ref  ->  rax        
+;  V02 tmp1         [V02,T03] (  2,  4   )     ref  ->  rdx         class-hnd single-def "dup spill" <System.Text.Encoding>
+;  V03 tmp2         [V03,T01] (  9,  7   )     ref  ->  [rsp+0x00] 
 ;* V04 tmp3         [V04    ] (  0,  0   )     ref  ->  zero-ref    "guarded devirt return temp"
-;  V05 tmp4         [V05,T00] (  6,  8.50)     ref  ->  rdx         single-def "guarded devirt arg temp"
+;  V05 tmp4         [V05,T00] (  6,  8.50)     ref  ->  rax         single-def "guarded devirt arg temp"
 ;* V06 tmp5         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Text.UTF8Encoding+UTF8EncodingSealed>
 ;* V07 tmp6         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.IO.Compression.ZipArchive>
 ;
-; Lcl frame size = 0
+; Lcl frame size = 8
 
 G_M16629_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
-						;; size=0 bbWeight=1 PerfScore 0.00
+       push     rax
+						;; size=1 bbWeight=1 PerfScore 1.00
 G_M16629_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
        mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
        mov      rdx, gword ptr [rdx+0x48]
-       mov      rax, rdx
-       ; gcrRegs +[rax]
-       mov      r8, 0xD1FFAB1E      ; const ptr
+       mov      rax, 0xD1FFAB1E      ; const ptr
        test     rdx, rdx
-       cmove    rax, gword ptr [r8]
-       mov      rdx, gword ptr [rcx+0x48]
+       cmove    rdx, gword ptr [rax]
+       mov      rax, gword ptr [rcx+0x48]
+       ; gcrRegs +[rax]
        mov      rcx, 0xD1FFAB1E      ; System.Text.UTF8Encoding+UTF8EncodingSealed
        ; gcrRegs -[rcx]
-       cmp      qword ptr [rax], rcx
+       cmp      qword ptr [rdx], rcx
        jne      SHORT G_M16629_IG07
-						;; size=47 bbWeight=1 PerfScore 14.00
+						;; size=44 bbWeight=1 PerfScore 13.75
 G_M16629_IG03:        ; bbWeight=0.75, gcrefRegs=0005 {rax rdx}, byrefRegs=0000 {}, byref, isz
-       test     rdx, rdx
+       test     rax, rax
        je       SHORT G_M16629_IG05
-       cmp      dword ptr [rdx+0x08], 32
+       cmp      dword ptr [rax+0x08], 32
        jg       SHORT G_M16629_IG05
-       mov      rcx, rax
+       mov      rcx, rdx
        ; gcrRegs +[rcx]
-						;; size=14 bbWeight=0.75 PerfScore 4.12
+       mov      rdx, rax
+						;; size=17 bbWeight=0.75 PerfScore 4.31
 G_M16629_IG04:        ; bbWeight=0.75, epilog, nogc, extend
+       add      rsp, 8
        tail.jmp [System.Text.UTF8Encoding+UTF8EncodingSealed:GetStringForSmallInput(ubyte[]):System.String:this]
        ; gcr arg pop 0
-						;; size=6 bbWeight=0.75 PerfScore 1.50
+						;; size=10 bbWeight=0.75 PerfScore 1.69
 G_M16629_IG05:        ; bbWeight=0.75, gcVars=0000000000000000 {}, gcrefRegs=0005 {rax rdx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rcx]
-       mov      rcx, rax
+       mov      rcx, rdx
        ; gcrRegs +[rcx]
-						;; size=3 bbWeight=0.75 PerfScore 0.19
+       mov      rdx, rax
+						;; size=6 bbWeight=0.75 PerfScore 0.38
 G_M16629_IG06:        ; bbWeight=0.75, epilog, nogc, extend
+       add      rsp, 8
        tail.jmp [System.Text.Encoding:GetString(ubyte[]):System.String:this]
        ; gcr arg pop 0
-						;; size=6 bbWeight=0.75 PerfScore 1.50
+						;; size=10 bbWeight=0.75 PerfScore 1.69
 G_M16629_IG07:        ; bbWeight=0.25, gcVars=0000000000000000 {}, gcrefRegs=0005 {rax rdx}, byrefRegs=0000 {}, gcvars, byref
        ; gcrRegs -[rcx]
-       mov      rcx, rax
+       mov      gword ptr [rsp], rdx
+       ; GC ptr vars +{V03}
+       mov      rcx, rdx
        ; gcrRegs +[rcx]
+       mov      rdx, rax
+       mov      rax, gword ptr [rsp]
        mov      rax, qword ptr [rax]
        ; gcrRegs -[rax]
        mov      rax, qword ptr [rax+0x70]
-						;; size=10 bbWeight=0.25 PerfScore 1.06
+						;; size=21 bbWeight=0.25 PerfScore 1.62
 G_M16629_IG08:        ; bbWeight=0.25, epilog, nogc, extend
+       add      rsp, 8
        tail.jmp [rax+0x38]System.Text.Encoding:GetString(ubyte[]):System.String:this
-						;; size=4 bbWeight=0.25 PerfScore 0.50
+						;; size=8 bbWeight=0.25 PerfScore 0.56
 
-; Total bytes of code 90, prolog size 0, PerfScore 22.88, instruction count 22, allocated bytes for code 90 (MethodHash=33b7bf0a) for method System.IO.Compression.ZipArchiveEntry:get_Comment():System.String:this (Tier1)
+; Total bytes of code 117, prolog size 1, PerfScore 25.00, instruction count 30, allocated bytes for code 117 (MethodHash=33b7bf0a) for method System.IO.Compression.ZipArchiveEntry:get_Comment():System.String:this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -79,8 +88,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x00
-  CountOfUnwindCodes: 0
+  SizeOfProlog      : 0x01
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
+    CodeOffset: 0x01 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 0 * 8 + 8 = 8 = 0x08

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+43.18%</span>) : 421647.dasm - System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,7 +11,7 @@
 ;  V00 RetBuf       [V00,T01] (  4,  4   )   byref  ->  rbx         single-def
 ;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T03] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
+;  V03 tmp1         [V03,T02] (  3,  6   )  simd32  ->  mm6         "impAppendStmt"
 ;* V04 tmp2         [V04,T04] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
 ;* V05 tmp3         [V05    ] (  0,  0   )  simd32  ->  zero-ref    "spilled call-like call argument"
 ;* V06 tmp4         [V06    ] (  0,  0   )  simd32  ->  zero-ref    "Inline return value spill temp" <System.Runtime.Intrinsics.Vector256`1[float]>
@@ -19,47 +19,50 @@
 ;* V08 tmp6         [V08    ] (  0,  0   )  simd32  ->  zero-ref    "spilled call-like call argument"
 ;  V09 tmp7         [V09    ] (  2,  2   )  simd32  ->  [rsp+0x40]  do-not-enreg[XS] addr-exposed "Inline return value spill temp" <System.Runtime.Intrinsics.Vector256`1[float]>
 ;  V10 tmp8         [V10    ] (  2,  4   )  simd32  ->  [rsp+0x20]  do-not-enreg[XS] addr-exposed "by-value struct argument" <System.Runtime.Intrinsics.Vector256`1[float]>
-;* V11 cse0         [V11,T02] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
+;  V11 cse0         [V11,T03] (  2,  2   )  simd32  ->  mm6         "CSE - aggressive"
 ;
-; Lcl frame size = 112
+; Lcl frame size = 144
 
 G_M8871_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 112
+       sub      rsp, 144
+       vmovaps  xmmword ptr [rsp+0x80], xmm6
+       vmovaps  xmmword ptr [rsp+0x70], xmm7
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
+						;; size=26 bbWeight=1 PerfScore 5.50
 G_M8871_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000C {rdx rbx}, byref
        ; byrRegs +[rdx]
+       vmovups  ymm6, ymmword ptr [reloc @RWD00]
        vmovups  ymm0, ymmword ptr [rdx]
-       vxorps   ymm0, ymm0, dword ptr [reloc @RWD00] {1to8}
+       vxorps   ymm0, ymm0, dword ptr [reloc @RWD32] {1to8}
        vmovups  ymmword ptr [rsp+0x20], ymm0
        lea      rdx, [rsp+0x20]
        ; byrRegs -[rdx]
        lea      rcx, [rsp+0x40]
+       vextractf128 xmm7, ymm6, 1
        call     [<unknown method>]
        ; gcr arg pop 0
-       vmovups  ymm0, ymmword ptr [rsp+0x40]
-       vaddps   ymm0, ymm0, dword ptr [reloc @RWD04] {1to8}
-       vmovups  ymm1, ymmword ptr [reloc @RWD32]
-       vdivps   ymm0, ymm1, ymm0
+       vinsertf128 ymm6, ymm6, xmm7, 1
+       vaddps   ymm0, ymm6, ymmword ptr [rsp+0x40]
+       vdivps   ymm0, ymm6, ymm0
        vmovups  ymmword ptr [rbx], ymm0
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=71 bbWeight=1 PerfScore 37.25
+						;; size=73 bbWeight=1 PerfScore 37.25
 G_M8871_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 112
+       vmovaps  xmm6, xmmword ptr [rsp+0x80]
+       vmovaps  xmm7, xmmword ptr [rsp+0x70]
+       add      rsp, 144
        pop      rbx
        ret      
-						;; size=9 bbWeight=1 PerfScore 2.75
-RWD00  	dd	80000000h		;        -0
-RWD04  	dd	3F800000h		;         1
-RWD08  	dd	00000000h, 00000000h, 00000000h, 00000000h, 00000000h, 00000000h
-RWD32  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+						;; size=27 bbWeight=1 PerfScore 10.75
+RWD00  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+RWD32  	dd	80000000h		;        -0
 
 
-; Total bytes of code 88, prolog size 5, PerfScore 41.50, instruction count 19, allocated bytes for code 88 (MethodHash=f661dd58) for method System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)
+; Total bytes of code 126, prolog size 23, PerfScore 53.50, instruction count 24, allocated bytes for code 126 (MethodHash=f661dd58) for method System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -67,10 +70,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x17
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 13 * 8 + 8 = 112 = 0x70
+    CodeOffset: 0x17 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 7 * 16 = 112 = 0x00070
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 8 * 16 = 128 = 0x00080
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 18 * 8 = 144 = 0x00090
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+43.18%</span>) : 415230.dasm - System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,54 +11,57 @@
 ;  V00 RetBuf       [V00,T01] (  4,  4   )   byref  ->  rbx         single-def
 ;  V01 arg0         [V01,T00] (  3,  6   )   byref  ->  rdx         single-def
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V03 tmp1         [V03,T04] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
+;  V03 tmp1         [V03,T02] (  3,  6   )  simd32  ->  mm6         "impAppendStmt"
 ;* V04 tmp2         [V04,T05] (  0,  0   )  simd32  ->  zero-ref    "impAppendStmt"
 ;* V05 tmp3         [V05    ] (  0,  0   )  simd32  ->  zero-ref    "spilled call-like call argument"
 ;* V06 tmp4         [V06    ] (  0,  0   )  simd32  ->  zero-ref    "Inline return value spill temp" <System.Runtime.Intrinsics.Vector256`1[float]>
 ;* V07 tmp5         [V07    ] (  0,  0   )  simd32  ->  zero-ref    "Inlining Arg" <System.Runtime.Intrinsics.Vector256`1[float]>
-;  V08 tmp6         [V08,T02] (  2,  4   )  simd32  ->  [rsp+0x40]  do-not-enreg[HS] hidden-struct-arg "spilled call-like call argument"
+;  V08 tmp6         [V08,T03] (  2,  4   )  simd32  ->  [rsp+0x40]  do-not-enreg[HS] hidden-struct-arg "spilled call-like call argument"
 ;  V09 tmp7         [V09    ] (  2,  4   )  simd32  ->  [rsp+0x20]  do-not-enreg[XS] addr-exposed "by-value struct argument" <System.Runtime.Intrinsics.Vector256`1[float]>
-;* V10 cse0         [V10,T03] (  0,  0   )  simd32  ->  zero-ref    "CSE - aggressive"
+;  V10 cse0         [V10,T04] (  2,  2   )  simd32  ->  mm6         "CSE - aggressive"
 ;
-; Lcl frame size = 112
+; Lcl frame size = 144
 
 G_M8871_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 112
+       sub      rsp, 144
+       vmovaps  xmmword ptr [rsp+0x80], xmm6
+       vmovaps  xmmword ptr [rsp+0x70], xmm7
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
+						;; size=26 bbWeight=1 PerfScore 5.50
 G_M8871_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=000C {rdx rbx}, byref
        ; byrRegs +[rdx]
+       vmovups  ymm6, ymmword ptr [reloc @RWD00]
        vmovups  ymm0, ymmword ptr [rdx]
-       vxorps   ymm0, ymm0, dword ptr [reloc @RWD00] {1to8}
+       vxorps   ymm0, ymm0, dword ptr [reloc @RWD32] {1to8}
        vmovups  ymmword ptr [rsp+0x20], ymm0
        lea      rdx, [rsp+0x20]
        ; byrRegs -[rdx]
        lea      rcx, [rsp+0x40]
+       vextractf128 xmm7, ymm6, 1
        call     [<unknown method>]
        ; gcr arg pop 0
-       vmovups  ymm0, ymmword ptr [rsp+0x40]
-       vaddps   ymm0, ymm0, dword ptr [reloc @RWD04] {1to8}
-       vmovups  ymm1, ymmword ptr [reloc @RWD32]
-       vdivps   ymm0, ymm1, ymm0
+       vinsertf128 ymm6, ymm6, xmm7, 1
+       vaddps   ymm0, ymm6, ymmword ptr [rsp+0x40]
+       vdivps   ymm0, ymm6, ymm0
        vmovups  ymmword ptr [rbx], ymm0
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=71 bbWeight=1 PerfScore 37.25
+						;; size=73 bbWeight=1 PerfScore 37.25
 G_M8871_IG03:        ; bbWeight=1, epilog, nogc, extend
        vzeroupper 
-       add      rsp, 112
+       vmovaps  xmm6, xmmword ptr [rsp+0x80]
+       vmovaps  xmm7, xmmword ptr [rsp+0x70]
+       add      rsp, 144
        pop      rbx
        ret      
-						;; size=9 bbWeight=1 PerfScore 2.75
-RWD00  	dd	80000000h		;        -0
-RWD04  	dd	3F800000h		;         1
-RWD08  	dd	00000000h, 00000000h, 00000000h, 00000000h, 00000000h, 00000000h
-RWD32  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+						;; size=27 bbWeight=1 PerfScore 10.75
+RWD00  	dq	3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h, 3F8000003F800000h
+RWD32  	dd	80000000h		;        -0
 
 
-; Total bytes of code 88, prolog size 5, PerfScore 41.50, instruction count 19, allocated bytes for code 88 (MethodHash=f661dd58) for method System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)
+; Total bytes of code 126, prolog size 23, PerfScore 53.50, instruction count 24, allocated bytes for code 126 (MethodHash=f661dd58) for method System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -66,10 +69,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x17
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 13 * 8 + 8 = 112 = 0x70
+    CodeOffset: 0x17 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM7 (7)
+      Scaled Small Offset: 7 * 16 = 112 = 0x00070
+    CodeOffset: 0x11 UnwindOp: UWOP_SAVE_XMM128 (8)     OpInfo: XMM6 (6)
+      Scaled Small Offset: 8 * 16 = 128 = 0x00080
+    CodeOffset: 0x08 UnwindOp: UWOP_ALLOC_LARGE (1)     OpInfo: 0 - Scaled small  
+      Size: 18 * 8 = 144 = 0x00090
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-10</span> (<span style="color:green">-43.48%</span>) : 14693.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T01] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T01] (  8, 17   )     int  ->  rcx        
 ;  V01 loc0         [V01,T02] (  4, 10   )     int  ->  rax        
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  6, 30   )     int  ->  rcx         "dup spill"
+;  V03 tmp1         [V03,T00] (  4, 20   )     int  ->  rcx         "dup spill"
 ;
 ; Lcl frame size = 0
 
@@ -19,23 +19,18 @@ G_M4648_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M4648_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        xor      eax, eax
        sar      ecx, 1
-       mov      edx, ecx
-       test     ecx, ecx
        je       SHORT G_M4648_IG04
-						;; size=10 bbWeight=1 PerfScore 2.25
+						;; size=6 bbWeight=1 PerfScore 1.75
 G_M4648_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        inc      eax
-       mov      ecx, edx
        sar      ecx, 1
-       mov      edx, ecx
-       test     ecx, ecx
        jne      SHORT G_M4648_IG03
-						;; size=12 bbWeight=4 PerfScore 10.00
+						;; size=6 bbWeight=4 PerfScore 7.00
 G_M4648_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 23, prolog size 0, PerfScore 13.25, instruction count 12, allocated bytes for code 23 (MethodHash=7eb6edd7) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
+; Total bytes of code 13, prolog size 0, PerfScore 9.75, instruction count 7, allocated bytes for code 13 (MethodHash=7eb6edd7) for method Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-21</span> (<span style="color:green">-34.43%</span>) : 160144.dasm - System.Collections.Specialized.NameObjectCollectionBase:.ctor(System.Collections.IEqualityComparer):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,47 +9,38 @@
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.Collections.Specialized.NameObjectCollectionBase>
-;  V01 arg1         [V01,T01] (  4,  4   )     ref  ->  rdx         class-hnd single-def <System.Collections.IEqualityComparer>
+;  V01 arg1         [V01,T02] (  3,  3   )     ref  ->  rdx         class-hnd single-def <System.Collections.IEqualityComparer>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V04 tmp2         [V04,T02] (  4,  4   )     ref  ->  [rsp+0x08] 
+;  V04 tmp2         [V04,T01] (  5,  5   )     ref  ->  rdx        
 ;
-; Lcl frame size = 16
+; Lcl frame size = 0
 
 G_M34593_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        push     rbx
-       sub      rsp, 16
        mov      rbx, rcx
        ; gcrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
+						;; size=4 bbWeight=1 PerfScore 1.25
 G_M34593_IG02:        ; bbWeight=1, gcrefRegs=000C {rdx rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       mov      rcx, rdx
-       ; gcrRegs +[rcx]
-       mov      rax, 0xD1FFAB1E      ; const ptr
+       mov      rcx, 0xD1FFAB1E      ; const ptr
        test     rdx, rdx
-       cmove    rcx, gword ptr [rax]
-       mov      gword ptr [rsp+0x08], rcx
-       ; GC ptr vars +{V04}
+       cmove    rdx, gword ptr [rcx]
        lea      rcx, bword ptr [rbx+0x10]
-       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
-       mov      rdx, gword ptr [rsp+0x08]
-       ; GC ptr vars -{V04}
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        mov      rcx, rbx
        ; gcrRegs +[rcx]
-						;; size=42 bbWeight=1 PerfScore 7.50
+						;; size=29 bbWeight=1 PerfScore 5.25
 G_M34593_IG03:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 16
        pop      rbx
        tail.jmp [System.Collections.Specialized.NameObjectCollectionBase:Reset():this]
        ; gcr arg pop 0
-						;; size=11 bbWeight=1 PerfScore 2.75
+						;; size=7 bbWeight=1 PerfScore 2.50
 
-; Total bytes of code 61, prolog size 8, PerfScore 11.75, instruction count 15, allocated bytes for code 61 (MethodHash=d45278de) for method System.Collections.Specialized.NameObjectCollectionBase:.ctor(System.Collections.IEqualityComparer):this (FullOpts)
+; Total bytes of code 40, prolog size 4, PerfScore 9.00, instruction count 10, allocated bytes for code 40 (MethodHash=d45278de) for method System.Collections.Specialized.NameObjectCollectionBase:.ctor(System.Collections.IEqualityComparer):this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -57,10 +48,9 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x05
-  CountOfUnwindCodes: 2
+  SizeOfProlog      : 0x01
+  CountOfUnwindCodes: 1
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x05 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 1 * 8 + 8 = 16 = 0x10
     CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 50978.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -21,26 +21,20 @@ G_M54628_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M54628_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M54628_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M54628_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M54628_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M54628_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+7</span> (<span style="color:red">+18.92%</span>) : 135255.dasm - System.IO.Pipelines.Tests.DisposeTrackingBufferPool+DisposeTrackingMemoryManager:get_Memory():System.Memory`1[ubyte]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,16 +8,16 @@
 ; 1 inlinees with PGO data; 2 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.IO.Pipelines.Tests.DisposeTrackingBufferPool+DisposeTrackingMemoryManager>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd single-def <System.IO.Pipelines.Tests.DisposeTrackingBufferPool+DisposeTrackingMemoryManager>
 ;  V01 RetBuf       [V01,T00] (  6,  6   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 tmp1         [V03,T02] (  2,  4   )     int  ->  rsi         "Inlining Arg"
 ;* V04 tmp2         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Memory`1[ubyte]>
 ;* V05 tmp3         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp4         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V07 tmp5         [V07,T03] (  2,  2   )     ref  ->  rdx         single-def "field V04._object (fldOffset=0x0)" P-INDEP
+;* V07 tmp5         [V07,T04] (  0,  0   )     ref  ->  zero-ref    single-def "field V04._object (fldOffset=0x0)" P-INDEP
 ;* V08 tmp6         [V08,T05] (  0,  0   )     int  ->  zero-ref    "field V04._index (fldOffset=0x8)" P-INDEP
-;  V09 tmp7         [V09,T04] (  2,  2   )     int  ->  rsi         "field V04._length (fldOffset=0xc)" P-INDEP
+;  V09 tmp7         [V09,T03] (  2,  2   )     int  ->  rsi         "field V04._length (fldOffset=0xc)" P-INDEP
 ;
 ; Lcl frame size = 0
 
@@ -29,13 +29,16 @@ G_M64191_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M64191_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, gword ptr [rcx+0x08]
        ; gcrRegs +[rdx]
        mov      esi, dword ptr [rdx+0x08]
-       mov      rdx, rcx
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -44,14 +47,14 @@ G_M64191_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        mov      dword ptr [rbx+0x0C], esi
        mov      rax, rbx
        ; byrRegs +[rax]
-						;; size=29 bbWeight=1 PerfScore 8.00
+						;; size=36 bbWeight=1 PerfScore 9.75
 G_M64191_IG03:        ; bbWeight=1, epilog, nogc, extend
        pop      rbx
        pop      rsi
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 37, prolog size 2, PerfScore 12.25, instruction count 15, allocated bytes for code 37 (MethodHash=d5be0540) for method System.IO.Pipelines.Tests.DisposeTrackingBufferPool+DisposeTrackingMemoryManager:get_Memory():System.Memory`1[ubyte]:this (FullOpts)
+; Total bytes of code 44, prolog size 2, PerfScore 14.00, instruction count 16, allocated bytes for code 44 (MethodHash=d5be0540) for method System.IO.Pipelines.Tests.DisposeTrackingBufferPool+DisposeTrackingMemoryManager:get_Memory():System.Memory`1[ubyte]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+20.00%</span>) : 54604.dasm - System.Diagnostics.Activity:get_TraceStateString():System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,9 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.Activity>
-;  V01 loc0         [V01,T00] (  6, 18   )     ref  ->  rcx         class-hnd <System.Diagnostics.Activity>
-;  V02 loc1         [V02,T01] (  3,  8.50)     ref  ->  rax         class-hnd exact <System.String>
+;  V00 this         [V00,T02] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Diagnostics.Activity>
+;  V01 loc0         [V01,T00] (  5, 17   )     ref  ->  rax         class-hnd <System.Diagnostics.Activity>
+;  V02 loc1         [V02,T01] (  3,  8.50)     ref  ->  rcx         class-hnd exact <System.String>
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -19,16 +19,19 @@ G_M30479_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M30479_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rcx]
+       mov      rax, rcx
+       ; gcrRegs +[rax]
        test     rcx, rcx
        je       SHORT G_M30479_IG04
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M30479_IG03:        ; bbWeight=4, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref, isz
-       mov      rax, gword ptr [rcx+0x08]
-       ; gcrRegs +[rax]
-       test     rax, rax
-       jne      SHORT G_M30479_IG06
-       mov      rcx, gword ptr [rcx+0x90]
+						;; size=8 bbWeight=1 PerfScore 1.50
+G_M30479_IG03:        ; bbWeight=4, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx]
+       mov      rcx, gword ptr [rax+0x08]
+       ; gcrRegs +[rcx]
        test     rcx, rcx
+       jne      SHORT G_M30479_IG06
+       mov      rax, gword ptr [rax+0x90]
+       test     rax, rax
        jne      SHORT G_M30479_IG03
 						;; size=21 bbWeight=4 PerfScore 26.00
 G_M30479_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
@@ -39,11 +42,16 @@ G_M30479_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
 G_M30479_IG05:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
-G_M30479_IG06:        ; bbWeight=0.50, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+G_M30479_IG06:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, gcvars, byref
+       ; gcrRegs -[rax] +[rcx]
+       mov      rax, rcx
+       ; gcrRegs +[rax]
+						;; size=3 bbWeight=0.50 PerfScore 0.12
+G_M30479_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=0.50 PerfScore 0.50
 
-; Total bytes of code 30, prolog size 0, PerfScore 28.38, instruction count 11, allocated bytes for code 30 (MethodHash=adb888f0) for method System.Diagnostics.Activity:get_TraceStateString():System.String:this (FullOpts)
+; Total bytes of code 36, prolog size 0, PerfScore 28.75, instruction count 13, allocated bytes for code 36 (MethodHash=adb888f0) for method System.Diagnostics.Activity:get_TraceStateString():System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+20.11%</span>) : 204039.dasm - System.Globalization.FormatProvider+Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,25 +9,25 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T11] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T10] (  5, 11   )     int  ->  registers  
-;  V02 loc0         [V02,T03] (  6, 41.50)    long  ->   r8        
+;  V01 arg1         [V01,T07] (  6, 15   )     int  ->  rdx        
+;  V02 loc0         [V02,T04] (  6, 41.50)    long  ->   r8        
 ;  V03 loc1         [V03    ] (  1,  0.50)   byref  ->  [rsp+0x00]  must-init pinned single-def
-;  V04 loc2         [V04,T00] ( 17,162.50)     int  ->  rax        
-;  V05 loc3         [V05,T05] (  2, 36   )  ushort  ->   r9        
-;  V06 loc4         [V06,T06] (  7, 28   )  ushort  ->  r10        
+;  V04 loc2         [V04,T00] ( 16,158.50)     int  ->  registers  
+;  V05 loc3         [V05,T03] (  7, 56   )  ushort  ->  registers  
+;  V06 loc4         [V06,T10] (  3, 12   )  ushort  ->   r9        
 ;# V07 OutArgs      [V07    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T09] (  2, 16   )     int  ->  r10         "impSpillLclRefs"
-;  V09 tmp2         [V09,T07] (  3, 24   )     int  ->  r10         "dup spill"
-;* V10 tmp3         [V10,T02] (  0,  0   )     int  ->  zero-ref    "impSpillLclRefs"
-;  V11 tmp4         [V11,T08] (  3, 24   )     int  ->  rdx         "dup spill"
+;  V08 tmp1         [V08,T06] (  3, 24   )     int  ->  rax         "impSpillLclRefs"
+;  V09 tmp2         [V09,T08] (  2, 16   )     int  ->  rax         "dup spill"
+;  V10 tmp3         [V10,T01] (  2,128   )     int  ->  rax         "impSpillLclRefs"
+;  V11 tmp4         [V11,T09] (  2, 16   )     int  ->  rdx         "dup spill"
 ;* V12 tmp5         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V13 tmp6         [V13,T12] (  3,  2   )   byref  ->   r8         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V14 tmp7         [V14,T04] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V14 tmp7         [V14,T05] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V15 tmp8         [V15    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V16 tmp9         [V16    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V17 tmp10        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V18 tmp11        [V18,T13] (  2,  2   )    long  ->   r8         "Cast away GC"
-;  V19 cse0         [V19,T01] (  3, 96   )     int  ->  r10         "CSE - aggressive"
+;  V19 cse0         [V19,T02] (  3, 96   )     int  ->   r9         "CSE - aggressive"
 ;
 ; Lcl frame size = 8
 
@@ -62,59 +62,73 @@ G_M50432_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs -[r8]
        cmp      eax, ecx
        jge      SHORT G_M50432_IG03
-       mov      r10d, eax
-       inc      eax
-       movsxd   r10, r10d
-       movzx    r10, word  ptr [r8+2*r10]
-       mov      r9d, r10d
-       cmp      r10d, 34
+       lea      r10d, [rax+0x01]
+       cdqe     
+       movzx    rax, word  ptr [r8+2*rax]
+       mov      r9d, eax
+       cmp      eax, 34
        ja       SHORT G_M50432_IG07
-       test     r10d, r10d
+       test     eax, eax
        je       SHORT G_M50432_IG03
-       cmp      r10d, 34
+       cmp      eax, 34
        je       SHORT G_M50432_IG08
+       mov      eax, r10d
        jmp      SHORT G_M50432_IG06
-						;; size=39 bbWeight=4 PerfScore 40.00
+						;; size=37 bbWeight=4 PerfScore 41.00
 G_M50432_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      r10d, 39
+       cmp      eax, 39
        je       SHORT G_M50432_IG08
-       cmp      r10d, 59
-       je       SHORT G_M50432_IG11
-       cmp      r10d, 92
+       cmp      r9d, 59
+       je       SHORT G_M50432_IG13
+       cmp      r9d, 92
+       mov      eax, r10d
        jne      SHORT G_M50432_IG06
        cmp      eax, ecx
        jge      SHORT G_M50432_IG06
-       jmp      SHORT G_M50432_IG10
-						;; size=24 bbWeight=4 PerfScore 28.00
+       jmp      SHORT G_M50432_IG12
+						;; size=26 bbWeight=4 PerfScore 29.00
 G_M50432_IG08:        ; bbWeight=32, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      eax, ecx
-       jge      SHORT G_M50432_IG06
-       movsxd   r10, eax
-       movzx    r10, word  ptr [r8+2*r10]
-       test     r10d, r10d
+       cmp      r10d, ecx
+       jge      SHORT G_M50432_IG11
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       movsxd   r9, eax
+       movzx    r9, word  ptr [r8+2*r9]
+       test     r9d, r9d
        je       SHORT G_M50432_IG06
        inc      eax
-       cmp      r10d, r9d
-       jne      SHORT G_M50432_IG08
-						;; size=24 bbWeight=32 PerfScore 200.00
+       cmp      r9d, r10d
+       jne      SHORT G_M50432_IG10
+						;; size=34 bbWeight=32 PerfScore 224.00
 G_M50432_IG09:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r10d, eax
+       mov      eax, r10d
        jmp      SHORT G_M50432_IG06
-						;; size=2 bbWeight=4 PerfScore 8.00
-G_M50432_IG10:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=8 bbWeight=4 PerfScore 10.00
+G_M50432_IG10:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       jmp      SHORT G_M50432_IG08
+						;; size=11 bbWeight=16 PerfScore 44.00
+G_M50432_IG11:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, r10d
+       jmp      SHORT G_M50432_IG06
+						;; size=5 bbWeight=16 PerfScore 36.00
+G_M50432_IG12:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsxd   r10, eax
        cmp      word  ptr [r8+2*r10], 0
-       je       SHORT G_M50432_IG06
+       je       G_M50432_IG06
        inc      eax
-       jmp      SHORT G_M50432_IG06
-						;; size=15 bbWeight=4 PerfScore 26.00
-G_M50432_IG11:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      G_M50432_IG06
+						;; size=22 bbWeight=4 PerfScore 26.00
+G_M50432_IG13:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        dec      edx
-       mov      r10d, edx
-       test     edx, edx
-       mov      edx, r10d
-       jne      SHORT G_M50432_IG06
-						;; size=12 bbWeight=4 PerfScore 8.00
-G_M50432_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, r10d
+       jne      G_M50432_IG06
+						;; size=11 bbWeight=4 PerfScore 6.00
+G_M50432_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        cmp      eax, ecx
        jge      G_M50432_IG03
        movsxd   rcx, eax
@@ -124,12 +138,12 @@ G_M50432_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byr
        cmp      word  ptr [r8+2*rcx], 59
        je       G_M50432_IG03
 						;; size=38 bbWeight=0.50 PerfScore 4.88
-G_M50432_IG13:        ; bbWeight=0.50, epilog, nogc, extend
+G_M50432_IG15:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 8
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 189, prolog size 7, PerfScore 324.38, instruction count 65, allocated bytes for code 189 (MethodHash=acb53aff) for method System.Globalization.FormatProvider+Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
+; Total bytes of code 227, prolog size 7, PerfScore 430.38, instruction count 75, allocated bytes for code 227 (MethodHash=acb53aff) for method System.Globalization.FormatProvider+Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 25541.dasm - Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -21,26 +21,20 @@ G_M9983_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byre
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x28]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M9983_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M9983_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x20]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M9983_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M9983_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M9983_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=7388d900) for method Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=7388d900) for method Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 24326.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -21,26 +21,20 @@ G_M54628_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M54628_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M54628_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M54628_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M54628_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M54628_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=7ad32a9b) for method Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-6</span> (<span style="color:green">-30.00%</span>) : 25752.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,10 +7,10 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
+;  V00 this         [V00,T00] (  4,  3.50)     ref  ->  rcx         this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V03 tmp2         [V03,T02] (  3,  2.50)     ref  ->  rdx        
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V03 tmp2         [V03,T02] (  4,  3.50)     ref  ->  rax        
 ;
 ; Lcl frame size = 0
 
@@ -20,26 +20,20 @@ G_M59916_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x10]
        ; gcrRegs +[rax]
-       mov      rdx, rax
-       ; gcrRegs +[rdx]
        test     rax, rax
        jne      SHORT G_M59916_IG04
-						;; size=12 bbWeight=1 PerfScore 3.50
+						;; size=9 bbWeight=1 PerfScore 3.25
 G_M59916_IG03:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rax rdx]
-       mov      rdx, gword ptr [rcx+0x18]
-       ; gcrRegs +[rdx]
-						;; size=4 bbWeight=0.50 PerfScore 1.00
-G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rcx]
-       mov      rax, rdx
+       ; gcrRegs -[rax]
+       mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59916_IG05:        ; bbWeight=1, epilog, nogc, extend
+						;; size=4 bbWeight=0.50 PerfScore 1.00
+G_M59916_IG04:        ; bbWeight=1, gcrefRegs=0001 {rax}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; gcrRegs -[rcx]
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 20, prolog size 0, PerfScore 5.75, instruction count 7, allocated bytes for code 20 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
+; Total bytes of code 14, prolog size 0, PerfScore 5.25, instruction count 5, allocated bytes for code 14 (MethodHash=162a15f3) for method Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+22</span> (<span style="color:red">+14.86%</span>) : 21571.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,12 +10,12 @@
 ;  V00 arg0         [V00,T07] (  7, 12   )     ref  ->  rbx         class-hnd single-def <System.String>
 ;  V01 arg1         [V01,T09] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
 ;  V02 loc0         [V02,T12] (  2,  1   )     int  ->  rcx        
-;  V03 loc1         [V03,T01] (  6, 65   )     int  ->  rdx        
+;  V03 loc1         [V03,T02] (  5, 49   )     int  ->  registers  
 ;  V04 loc2         [V04,T03] (  7, 24.50)     int  ->   r8        
 ;  V05 loc3         [V05,T04] (  3, 24   )     int  ->  r10        
-;  V06 loc4         [V06,T00] (  6, 72   )     int  ->   r9        
+;  V06 loc4         [V06,T01] (  6, 72   )     int  ->   r9        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T02] (  2, 64   )     int  ->  r11         "impSpillLclRefs"
+;  V08 tmp1         [V08,T00] (  3, 96   )     int  ->  rdx         "impSpillLclRefs"
 ;  V09 tmp2         [V09,T05] (  2, 17   )   byref  ->  rsi         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
 ;  V10 tmp3         [V10,T06] (  2, 17   )     int  ->  rdi         "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V11 tmp4         [V11    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[ushort]>
@@ -64,46 +64,46 @@ G_M48356_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; byrRegs +[rsi]
        mov      eax, dword ptr [rbx+0x08]
        cmp      eax, 1
-       jbe      SHORT G_M48356_IG11
+       jbe      SHORT G_M48356_IG15
        movzx    rcx, word  ptr [rbx+0x0E]
        xor      edx, edx
        mov      r8d, 3
        add      ecx, 3
        cmp      ecx, 3
-       jle      SHORT G_M48356_IG09
+       jle      SHORT G_M48356_IG14
 						;; size=28 bbWeight=0.50 PerfScore 3.62
 G_M48356_IG06:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref, isz
        lea      r10d, [r8+0x01]
        cmp      r10d, eax
-       jae      SHORT G_M48356_IG11
+       jae      SHORT G_M48356_IG15
        movzx    r10, word  ptr [rbx+2*r10+0x0C]
        cmp      r8d, eax
-       jae      SHORT G_M48356_IG11
+       jae      SHORT G_M48356_IG15
        mov      r9d, r8d
        movzx    r9, word  ptr [rbx+2*r9+0x0C]
        cmp      r9d, r10d
-       jge      SHORT G_M48356_IG08
+       jge      SHORT G_M48356_IG13
 						;; size=34 bbWeight=4 PerfScore 34.00
 G_M48356_IG07:        ; bbWeight=16, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref, isz
        cmp      edx, edi
        jge      SHORT G_M48356_IG03
-       mov      r11d, edx
-       inc      edx
-       mov      word  ptr [rsi+2*r11], r9w
+       lea      r11d, [rdx+0x01]
+       mov      edx, edx
+       mov      word  ptr [rsi+2*rdx], r9w
        inc      r9d
        cmp      r9d, r10d
-       jl       SHORT G_M48356_IG07
-						;; size=22 bbWeight=16 PerfScore 68.00
+       jl       SHORT G_M48356_IG12
+						;; size=23 bbWeight=16 PerfScore 72.00
 G_M48356_IG08:        ; bbWeight=4, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref, isz
        add      r8d, 2
        cmp      r8d, ecx
-       jl       SHORT G_M48356_IG06
+       jl       SHORT G_M48356_IG11
 						;; size=9 bbWeight=4 PerfScore 6.00
 G_M48356_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx]
        ; byrRegs -[rsi]
-       mov      eax, edx
-						;; size=2 bbWeight=0.50 PerfScore 0.12
+       mov      eax, r11d
+						;; size=3 bbWeight=0.50 PerfScore 0.12
 G_M48356_IG10:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
@@ -111,13 +111,33 @@ G_M48356_IG10:        ; bbWeight=0.50, epilog, nogc, extend
        pop      rdi
        ret      
 						;; size=8 bbWeight=0.50 PerfScore 1.38
-G_M48356_IG11:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+G_M48356_IG11:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, gcvars, byref, isz
+       ; gcrRegs +[rbx]
+       ; byrRegs +[rsi]
+       mov      edx, r11d
+       jmp      SHORT G_M48356_IG06
+						;; size=5 bbWeight=2 PerfScore 4.50
+G_M48356_IG12:        ; bbWeight=8, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref, isz
+       mov      edx, r11d
+       jmp      SHORT G_M48356_IG07
+						;; size=5 bbWeight=8 PerfScore 18.00
+G_M48356_IG13:        ; bbWeight=2, gcrefRegs=0008 {rbx}, byrefRegs=0040 {rsi}, byref, isz
+       mov      r11d, edx
+       jmp      SHORT G_M48356_IG08
+						;; size=5 bbWeight=2 PerfScore 4.50
+G_M48356_IG14:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rbx]
+       ; byrRegs -[rsi]
+       mov      r11d, edx
+       jmp      SHORT G_M48356_IG09
+						;; size=5 bbWeight=0.25 PerfScore 0.56
+G_M48356_IG15:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 148, prolog size 10, PerfScore 126.62, instruction count 55, allocated bytes for code 148 (MethodHash=a0de431b) for method System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
+; Total bytes of code 170, prolog size 10, PerfScore 158.19, instruction count 63, allocated bytes for code 170 (MethodHash=a0de431b) for method System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+38</span> (<span style="color:red">+20.11%</span>) : 814.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,25 +9,25 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T11] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T10] (  5, 11   )     int  ->  registers  
-;  V02 loc0         [V02,T00] ( 17,162.50)     int  ->  rax        
-;  V03 loc1         [V03,T05] (  2, 36   )  ushort  ->   r9        
-;  V04 loc2         [V04,T03] (  6, 41.50)    long  ->   r8        
+;  V01 arg1         [V01,T07] (  6, 15   )     int  ->  rdx        
+;  V02 loc0         [V02,T00] ( 16,158.50)     int  ->  registers  
+;  V03 loc1         [V03,T03] (  7, 56   )  ushort  ->  registers  
+;  V04 loc2         [V04,T04] (  6, 41.50)    long  ->   r8        
 ;  V05 loc3         [V05    ] (  1,  0.50)   byref  ->  [rsp+0x00]  must-init pinned single-def
-;  V06 loc4         [V06,T06] (  7, 28   )  ushort  ->  r10        
+;  V06 loc4         [V06,T10] (  3, 12   )  ushort  ->   r9        
 ;# V07 OutArgs      [V07    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T09] (  2, 16   )     int  ->  r10         "impSpillLclRefs"
-;  V09 tmp2         [V09,T07] (  3, 24   )     int  ->  r10         "dup spill"
-;* V10 tmp3         [V10,T02] (  0,  0   )     int  ->  zero-ref    "impSpillLclRefs"
-;  V11 tmp4         [V11,T08] (  3, 24   )     int  ->  rdx         "dup spill"
+;  V08 tmp1         [V08,T06] (  3, 24   )     int  ->  rax         "impSpillLclRefs"
+;  V09 tmp2         [V09,T08] (  2, 16   )     int  ->  rax         "dup spill"
+;  V10 tmp3         [V10,T01] (  2,128   )     int  ->  rax         "impSpillLclRefs"
+;  V11 tmp4         [V11,T09] (  2, 16   )     int  ->  rdx         "dup spill"
 ;* V12 tmp5         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V13 tmp6         [V13,T12] (  3,  2   )   byref  ->   r8         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V14 tmp7         [V14,T04] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V14 tmp7         [V14,T05] (  5, 41.50)     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V15 tmp8         [V15    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V16 tmp9         [V16    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V17 tmp10        [V17    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V18 tmp11        [V18,T13] (  2,  2   )    long  ->   r8         "Cast away GC"
-;  V19 cse0         [V19,T01] (  3, 96   )     int  ->  r10         "CSE - aggressive"
+;  V19 cse0         [V19,T02] (  3, 96   )     int  ->   r9         "CSE - aggressive"
 ;
 ; Lcl frame size = 8
 
@@ -62,59 +62,73 @@ G_M3490_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
        ; byrRegs -[r8]
        cmp      eax, ecx
        jge      SHORT G_M3490_IG03
-       mov      r10d, eax
-       inc      eax
-       movsxd   r10, r10d
-       movzx    r10, word  ptr [r8+2*r10]
-       mov      r9d, r10d
-       cmp      r10d, 34
+       lea      r10d, [rax+0x01]
+       cdqe     
+       movzx    rax, word  ptr [r8+2*rax]
+       mov      r9d, eax
+       cmp      eax, 34
        ja       SHORT G_M3490_IG07
-       test     r10d, r10d
+       test     eax, eax
        je       SHORT G_M3490_IG03
-       cmp      r10d, 34
+       cmp      eax, 34
        je       SHORT G_M3490_IG08
+       mov      eax, r10d
        jmp      SHORT G_M3490_IG06
-						;; size=39 bbWeight=4 PerfScore 40.00
+						;; size=37 bbWeight=4 PerfScore 41.00
 G_M3490_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      r10d, 39
+       cmp      eax, 39
        je       SHORT G_M3490_IG08
-       cmp      r10d, 59
-       je       SHORT G_M3490_IG11
-       cmp      r10d, 92
+       cmp      r9d, 59
+       je       SHORT G_M3490_IG13
+       cmp      r9d, 92
+       mov      eax, r10d
        jne      SHORT G_M3490_IG06
        cmp      eax, ecx
        jge      SHORT G_M3490_IG06
-       jmp      SHORT G_M3490_IG10
-						;; size=24 bbWeight=4 PerfScore 28.00
+       jmp      SHORT G_M3490_IG12
+						;; size=26 bbWeight=4 PerfScore 29.00
 G_M3490_IG08:        ; bbWeight=32, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       cmp      eax, ecx
-       jge      SHORT G_M3490_IG06
-       movsxd   r10, eax
-       movzx    r10, word  ptr [r8+2*r10]
-       test     r10d, r10d
+       cmp      r10d, ecx
+       jge      SHORT G_M3490_IG11
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       movsxd   r9, eax
+       movzx    r9, word  ptr [r8+2*r9]
+       test     r9d, r9d
        je       SHORT G_M3490_IG06
        inc      eax
-       cmp      r10d, r9d
-       jne      SHORT G_M3490_IG08
-						;; size=24 bbWeight=32 PerfScore 200.00
+       cmp      r9d, r10d
+       jne      SHORT G_M3490_IG10
+						;; size=34 bbWeight=32 PerfScore 224.00
 G_M3490_IG09:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r10d, eax
+       mov      eax, r10d
        jmp      SHORT G_M3490_IG06
-						;; size=2 bbWeight=4 PerfScore 8.00
-G_M3490_IG10:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+						;; size=8 bbWeight=4 PerfScore 10.00
+G_M3490_IG10:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r9d, eax
+       mov      eax, r10d
+       mov      r10d, r9d
+       jmp      SHORT G_M3490_IG08
+						;; size=11 bbWeight=16 PerfScore 44.00
+G_M3490_IG11:        ; bbWeight=16, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, r10d
+       jmp      SHORT G_M3490_IG06
+						;; size=5 bbWeight=16 PerfScore 36.00
+G_M3490_IG12:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        movsxd   r10, eax
        cmp      word  ptr [r8+2*r10], 0
-       je       SHORT G_M3490_IG06
+       je       G_M3490_IG06
        inc      eax
-       jmp      SHORT G_M3490_IG06
-						;; size=15 bbWeight=4 PerfScore 26.00
-G_M3490_IG11:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       jmp      G_M3490_IG06
+						;; size=22 bbWeight=4 PerfScore 26.00
+G_M3490_IG13:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        dec      edx
-       mov      r10d, edx
-       test     edx, edx
-       mov      edx, r10d
-       jne      SHORT G_M3490_IG06
-						;; size=12 bbWeight=4 PerfScore 8.00
-G_M3490_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      eax, r10d
+       jne      G_M3490_IG06
+						;; size=11 bbWeight=4 PerfScore 6.00
+G_M3490_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        cmp      eax, ecx
        jge      G_M3490_IG03
        movsxd   rcx, eax
@@ -124,12 +138,12 @@ G_M3490_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byre
        cmp      word  ptr [r8+2*rcx], 59
        je       G_M3490_IG03
 						;; size=38 bbWeight=0.50 PerfScore 4.88
-G_M3490_IG13:        ; bbWeight=0.50, epilog, nogc, extend
+G_M3490_IG15:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 8
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
 
-; Total bytes of code 189, prolog size 7, PerfScore 324.38, instruction count 65, allocated bytes for code 189 (MethodHash=ce6bf25d) for method System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
+; Total bytes of code 227, prolog size 7, PerfScore 430.38, instruction count 75, allocated bytes for code 227 (MethodHash=ce6bf25d) for method System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+26</span> (<span style="color:red">+24.07%</span>) : 18498.dasm - System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,12 +10,12 @@
 ;  V00 arg0         [V00,T05] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T06] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
 ;  V02 arg2         [V02,T07] (  4,  8   )   byref  ->   r8         ld-addr-op single-def
-;  V03 loc0         [V03,T00] ( 10, 34   )     int  ->  r11        
-;  V04 loc1         [V04,T01] (  5, 17   )     int  ->  rbx        
-;  V05 loc2         [V05,T02] (  5, 16.50)     int  ->  rcx        
+;  V03 loc0         [V03,T00] (  8, 26   )     int  ->  registers  
+;  V04 loc1         [V04,T03] (  5, 17   )     int  ->  rbx        
+;  V05 loc2         [V05,T04] (  5, 16.50)     int  ->  rcx        
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T03] (  2, 16   )     int  ->  rsi         "impSpillLclRefs"
-;  V08 tmp2         [V08,T04] (  2, 16   )     int  ->   r9         "impSpillLclRefs"
+;  V07 tmp1         [V07,T01] (  3, 24   )     int  ->  r11         "impSpillLclRefs"
+;  V08 tmp2         [V08,T02] (  3, 24   )     int  ->   r9         "impSpillLclRefs"
 ;  V09 tmp3         [V09,T12] (  2,  5   )   byref  ->   r9         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
 ;  V10 tmp4         [V10,T10] (  3,  6   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
 ;  V11 tmp5         [V11,T13] (  2,  5   )   byref  ->  r10         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
@@ -51,51 +51,72 @@ G_M18424_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0106 {rcx rdx r
        xor      r11d, r11d
        xor      ebx, ebx
        test     ecx, ecx
-       jle      SHORT G_M18424_IG04
+       jle      SHORT G_M18424_IG12
 						;; size=28 bbWeight=1 PerfScore 13.75
 G_M18424_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref, isz
        cmp      r11d, r8d
-       jae      SHORT G_M18424_IG06
-       mov      esi, r11d
-       inc      r11d
+       jae      SHORT G_M18424_IG07
+       lea      esi, [r11+0x01]
+       mov      r11d, r11d
        mov      edi, ebx
        movzx    rdi, byte  ptr [r9+rdi]
-       mov      byte  ptr [rax+rsi], dil
+       mov      byte  ptr [rax+r11], dil
        inc      ebx
        cmp      ebx, ecx
-       jl       SHORT G_M18424_IG03
-						;; size=28 bbWeight=4 PerfScore 26.00
+       jl       SHORT G_M18424_IG11
+						;; size=29 bbWeight=4 PerfScore 27.00
 G_M18424_IG04:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
        ; byrRegs -[r9]
        xor      ecx, ecx
        test     edx, edx
-       jle      SHORT G_M18424_IG06
+       jle      SHORT G_M18424_IG10
 						;; size=6 bbWeight=0.50 PerfScore 0.75
 G_M18424_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
-       cmp      r11d, r8d
-       jae      SHORT G_M18424_IG06
-       mov      r9d, r11d
-       inc      r11d
-       mov      ebx, ecx
-       movzx    rbx, byte  ptr [r10+rbx]
-       mov      byte  ptr [rax+r9], bl
+       cmp      esi, r8d
+       jae      SHORT G_M18424_IG09
+       mov      r9d, esi
+       lea      esi, [r9+0x01]
+       mov      r11d, ecx
+       movzx    r11, byte  ptr [r10+r11]
+       mov      byte  ptr [rax+r9], r11b
        inc      ecx
        cmp      ecx, edx
        jl       SHORT G_M18424_IG05
-						;; size=28 bbWeight=4 PerfScore 26.00
-G_M18424_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=30 bbWeight=4 PerfScore 27.00
+G_M18424_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; byrRegs -[rax r10]
+       mov      r11d, esi
+						;; size=3 bbWeight=2 PerfScore 0.50
+G_M18424_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, r11d
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M18424_IG07:        ; bbWeight=1, epilog, nogc, extend
+G_M18424_IG08:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rsi
        pop      rdi
        ret      
 						;; size=8 bbWeight=1 PerfScore 2.75
+G_M18424_IG09:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
+       mov      r11d, esi
+       jmp      SHORT G_M18424_IG07
+						;; size=5 bbWeight=2 PerfScore 4.50
+G_M18424_IG10:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      r11d, esi
+       jmp      SHORT G_M18424_IG07
+						;; size=5 bbWeight=0.25 PerfScore 0.56
+G_M18424_IG11:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0601 {rax r9 r10}, byref, isz
+       ; byrRegs +[rax r9-r10]
+       mov      r11d, esi
+       jmp      SHORT G_M18424_IG03
+						;; size=5 bbWeight=2 PerfScore 4.50
+G_M18424_IG12:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0401 {rax r10}, byref, isz
+       ; byrRegs -[r9]
+       mov      esi, r11d
+       jmp      SHORT G_M18424_IG04
+						;; size=5 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 108, prolog size 7, PerfScore 72.75, instruction count 43, allocated bytes for code 108 (MethodHash=8d9eb807) for method System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
+; Total bytes of code 134, prolog size 7, PerfScore 85.94, instruction count 52, allocated bytes for code 134 (MethodHash=8d9eb807) for method System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-48.53%</span>) : 29413.dasm - System.Number:UInt32ToBinaryChars[ushort](ulong,uint,int):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,12 +7,12 @@
 ; fully interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 11   )    long  ->  registers  
-;  V01 arg1         [V01,T01] (  6, 22   )     int  ->  rdx        
-;  V02 arg2         [V02,T03] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T03] (  6, 15   )    long  ->  rcx        
+;  V01 arg1         [V01,T00] (  6, 22   )     int  ->  rdx        
+;  V02 arg2         [V02,T02] (  8, 17   )     int  ->   r8        
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T00] (  6, 30   )     int  ->   r8         "dup spill"
-;  V05 tmp2         [V05,T02] (  3, 24   )    long  ->  rcx         "dup spill"
+;  V04 tmp1         [V04,T01] (  4, 20   )     int  ->   r8         "dup spill"
+;  V05 tmp2         [V05,T04] (  2, 16   )    long  ->  rcx         "dup spill"
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 0
@@ -21,44 +21,30 @@ G_M48799_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M48799_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      r8d
-       mov      eax, r8d
-       test     r8d, r8d
-       jl       SHORT G_M48799_IG08
-						;; size=11 bbWeight=1 PerfScore 1.75
+       js       SHORT G_M48799_IG04
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M48799_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        add      rcx, -2
-       mov      r10, rcx
-       mov      r8d, edx
-       and      r8d, 1
-       add      r8d, 48
-       mov      word  ptr [rcx], r8w
+       mov      eax, edx
+       and      eax, 1
+       add      eax, 48
+       mov      word  ptr [rcx], ax
        shr      edx, 1
-       lea      r8d, [rax-0x01]
-       mov      eax, r8d
-       test     r8d, r8d
-       jge      SHORT G_M48799_IG07
-						;; size=36 bbWeight=4 PerfScore 19.00
+       dec      r8d
+       jns      SHORT G_M48799_IG03
+						;; size=22 bbWeight=4 PerfScore 15.00
 G_M48799_IG04:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     edx, edx
-       mov      rcx, r10
        jne      SHORT G_M48799_IG03
-						;; size=7 bbWeight=8 PerfScore 12.00
+						;; size=4 bbWeight=8 PerfScore 10.00
 G_M48799_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rcx
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M48799_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M48799_IG07:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, r10
-       jmp      SHORT G_M48799_IG03
-						;; size=5 bbWeight=2 PerfScore 4.50
-G_M48799_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r10, rcx
-       jmp      SHORT G_M48799_IG04
-						;; size=5 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 68, prolog size 0, PerfScore 39.62, instruction count 24, allocated bytes for code 68 (MethodHash=63694160) for method System.Number:UInt32ToBinaryChars[ushort](ulong,uint,int):ulong (FullOpts)
+; Total bytes of code 35, prolog size 0, PerfScore 27.50, instruction count 14, allocated bytes for code 35 (MethodHash=63694160) for method System.Number:UInt32ToBinaryChars[ushort](ulong,uint,int):ulong (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-33</span> (<span style="color:green">-47.14%</span>) : 29397.dasm - System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,12 +7,12 @@
 ; fully interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 11   )    long  ->  registers  
-;  V01 arg1         [V01,T01] (  6, 22   )    long  ->  rdx        
-;  V02 arg2         [V02,T03] (  6, 12   )     int  ->  registers  
+;  V00 arg0         [V00,T03] (  6, 15   )    long  ->  rcx        
+;  V01 arg1         [V01,T00] (  6, 22   )    long  ->  rdx        
+;  V02 arg2         [V02,T02] (  8, 17   )     int  ->   r8        
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T00] (  6, 30   )     int  ->   r8         "dup spill"
-;  V05 tmp2         [V05,T02] (  3, 24   )    long  ->  rcx         "dup spill"
+;  V04 tmp1         [V04,T01] (  4, 20   )     int  ->   r8         "dup spill"
+;  V05 tmp2         [V05,T04] (  2, 16   )    long  ->  rcx         "dup spill"
 ;* V06 tmp3         [V06    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 0
@@ -21,44 +21,30 @@ G_M17765_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17765_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      r8d
-       mov      eax, r8d
-       test     r8d, r8d
-       jl       SHORT G_M17765_IG08
-						;; size=11 bbWeight=1 PerfScore 1.75
+       js       SHORT G_M17765_IG04
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M17765_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        add      rcx, -2
-       mov      r10, rcx
-       mov      r8d, edx
-       and      r8d, 1
-       add      r8d, 48
-       mov      word  ptr [rcx], r8w
+       mov      eax, edx
+       and      eax, 1
+       add      eax, 48
+       mov      word  ptr [rcx], ax
        shr      rdx, 1
-       lea      r8d, [rax-0x01]
-       mov      eax, r8d
-       test     r8d, r8d
-       jge      SHORT G_M17765_IG07
-						;; size=37 bbWeight=4 PerfScore 19.00
+       dec      r8d
+       jns      SHORT G_M17765_IG03
+						;; size=23 bbWeight=4 PerfScore 15.00
 G_M17765_IG04:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     rdx, rdx
-       mov      rcx, r10
        jne      SHORT G_M17765_IG03
-						;; size=8 bbWeight=8 PerfScore 12.00
+						;; size=5 bbWeight=8 PerfScore 10.00
 G_M17765_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rcx
 						;; size=3 bbWeight=1 PerfScore 0.25
 G_M17765_IG06:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M17765_IG07:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, r10
-       jmp      SHORT G_M17765_IG03
-						;; size=5 bbWeight=2 PerfScore 4.50
-G_M17765_IG08:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r10, rcx
-       jmp      SHORT G_M17765_IG04
-						;; size=5 bbWeight=0.50 PerfScore 1.12
 
-; Total bytes of code 70, prolog size 0, PerfScore 39.62, instruction count 24, allocated bytes for code 70 (MethodHash=3dc0ba9a) for method System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (FullOpts)
+; Total bytes of code 37, prolog size 0, PerfScore 27.50, instruction count 14, allocated bytes for code 37 (MethodHash=3dc0ba9a) for method System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-36</span> (<span style="color:green">-40.91%</span>) : 29414.dasm - System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,19 +7,19 @@
 ; fully interruptible
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T04] (  5, 11   )    long  ->  registers  
-;  V01 arg1         [V01,T01] (  6, 22   )     int  ->  rdx        
+;  V00 arg0         [V00,T03] (  6, 15   )    long  ->  rcx        
+;  V01 arg1         [V01,T00] (  6, 22   )     int  ->  rdx        
 ;  V02 arg2         [V02,T08] (  3,  4   )     int  ->   r8         single-def
-;  V03 arg3         [V03,T03] (  6, 12   )     int  ->  registers  
-;  V04 loc0         [V04,T05] (  3, 12   )   ubyte  ->   r9        
+;  V03 arg3         [V03,T02] (  8, 17   )     int  ->   r9        
+;  V04 loc0         [V04,T07] (  2,  8   )   ubyte  ->  rax        
 ;# V05 OutArgs      [V05    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T00] (  6, 30   )     int  ->   r9         "dup spill"
-;  V07 tmp2         [V07,T02] (  3, 24   )    long  ->  rcx         "dup spill"
+;  V06 tmp1         [V06,T01] (  4, 20   )     int  ->   r9         "dup spill"
+;  V07 tmp2         [V07,T04] (  2, 16   )    long  ->  rcx         "dup spill"
 ;* V08 tmp3         [V08    ] (  0,  0   )    long  ->  zero-ref   
-;  V09 tmp4         [V09,T07] (  2,  8   )     int  ->  r11        
+;  V09 tmp4         [V09,T05] (  3, 12   )     int  ->  rax        
 ;* V10 tmp5         [V10    ] (  0,  0   )    long  ->  zero-ref   
 ;* V11 tmp6         [V11    ] (  0,  0   )     int  ->  zero-ref   
-;  V12 tmp7         [V12,T06] (  3,  8   )     int  ->   r9        
+;  V12 tmp7         [V12,T06] (  3,  8   )     int  ->  r10        
 ;* V13 tmp8         [V13    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;
 ; Lcl frame size = 0
@@ -28,56 +28,41 @@ G_M31567_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M31567_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        dec      r9d
-       mov      eax, r9d
-       test     r9d, r9d
-       jl       SHORT G_M31567_IG05
-						;; size=11 bbWeight=1 PerfScore 1.75
+       js       SHORT G_M31567_IG07
+						;; size=5 bbWeight=1 PerfScore 1.25
 G_M31567_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r9d, edx
-       and      r9d, 15
+       mov      eax, edx
+       and      eax, 15
        add      rcx, -2
-       mov      r10, rcx
-       mov      r11d, r9d
-       cmp      r9d, 10
-       jl       SHORT G_M31567_IG06
-						;; size=23 bbWeight=4 PerfScore 10.00
+       cmp      eax, 10
+       jl       SHORT G_M31567_IG05
+						;; size=14 bbWeight=4 PerfScore 8.00
 G_M31567_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r9d, r8d
-       jmp      SHORT G_M31567_IG07
+       mov      r10d, r8d
+       jmp      SHORT G_M31567_IG06
 						;; size=5 bbWeight=2 PerfScore 4.50
-G_M31567_IG05:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       mov      r10, rcx
-       jmp      SHORT G_M31567_IG08
-						;; size=5 bbWeight=0.50 PerfScore 1.12
-G_M31567_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       mov      r9d, 48
+G_M31567_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      r10d, 48
 						;; size=6 bbWeight=2 PerfScore 0.50
-G_M31567_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
-       add      r9d, r11d
-       mov      word  ptr [rcx], r9w
+G_M31567_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       add      eax, r10d
+       mov      word  ptr [rcx], ax
        shr      edx, 4
-       lea      r9d, [rax-0x01]
-       mov      eax, r9d
-       test     r9d, r9d
-       jge      SHORT G_M31567_IG11
-						;; size=22 bbWeight=4 PerfScore 15.00
-G_M31567_IG08:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       dec      r9d
+       jns      SHORT G_M31567_IG03
+						;; size=14 bbWeight=4 PerfScore 12.00
+G_M31567_IG07:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        test     edx, edx
-       mov      rcx, r10
        jne      SHORT G_M31567_IG03
-						;; size=7 bbWeight=8 PerfScore 12.00
-G_M31567_IG09:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+						;; size=4 bbWeight=8 PerfScore 10.00
+G_M31567_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      rax, rcx
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M31567_IG10:        ; bbWeight=1, epilog, nogc, extend
+G_M31567_IG09:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
-G_M31567_IG11:        ; bbWeight=2, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, isz
-       mov      rcx, r10
-       jmp      SHORT G_M31567_IG03
-						;; size=5 bbWeight=2 PerfScore 4.50
 
-; Total bytes of code 88, prolog size 0, PerfScore 50.62, instruction count 30, allocated bytes for code 88 (MethodHash=f9cb84b0) for method System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (FullOpts)
+; Total bytes of code 52, prolog size 0, PerfScore 37.50, instruction count 19, allocated bytes for code 52 (MethodHash=f9cb84b0) for method System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.03%</span>) : 14390.dasm - System.Collections.Generic.List`1[System.__Canon]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Collections.Generic.List`1[System.__Canon]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd exact single-def <System.Collections.Generic.List`1[System.__Canon]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[System.__Canon]>
@@ -26,19 +26,23 @@ G_M22330_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M22330_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x14]
+       mov      esi, dword ptr [rdx+0x14]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        xor      rax, rax
        ; gcrRegs +[rax]
        mov      gword ptr [rbx+0x08], rax
-						;; size=20 bbWeight=1 PerfScore 4.75
+						;; size=30 bbWeight=1 PerfScore 6.75
 G_M22330_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        mov      dword ptr [rbx+0x10], eax
@@ -52,7 +56,7 @@ G_M22330_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 37, prolog size 2, PerfScore 11.25, instruction count 15, allocated bytes for code 37 (MethodHash=3d27a8c5) for method System.Collections.Generic.List`1[System.__Canon]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.__Canon]:this (FullOpts)
+; Total bytes of code 47, prolog size 2, PerfScore 13.25, instruction count 17, allocated bytes for code 47 (MethodHash=3d27a8c5) for method System.Collections.Generic.List`1[System.__Canon]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.03%</span>) : 31030.dasm - System.Collections.Generic.HashSet`1[System.__Canon]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Collections.Generic.HashSet`1[System.__Canon]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd exact single-def <System.Collections.Generic.HashSet`1[System.__Canon]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.HashSet`1+Enumerator[System.__Canon]>
@@ -26,12 +26,16 @@ G_M44762_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M44762_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x34]
+       mov      esi, dword ptr [rdx+0x34]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
@@ -39,7 +43,7 @@ G_M44762_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        ; gcrRegs +[rax]
        mov      gword ptr [rbx+0x08], rax
        mov      dword ptr [rbx+0x10], esi
-						;; size=23 bbWeight=1 PerfScore 5.75
+						;; size=33 bbWeight=1 PerfScore 7.75
 G_M44762_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rax]
        mov      dword ptr [rbx+0x14], eax
@@ -52,7 +56,7 @@ G_M44762_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 37, prolog size 2, PerfScore 11.25, instruction count 15, allocated bytes for code 37 (MethodHash=b4b85125) for method System.Collections.Generic.HashSet`1[System.__Canon]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[System.__Canon]:this (FullOpts)
+; Total bytes of code 47, prolog size 2, PerfScore 13.25, instruction count 17, allocated bytes for code 47 (MethodHash=b4b85125) for method System.Collections.Generic.HashSet`1[System.__Canon]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+10</span> (<span style="color:red">+27.78%</span>) : 30006.dasm - System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Collections.Generic.List`1[int]>
+;  V00 this         [V00,T01] (  4,  4   )     ref  ->  [rsp+0x18]  this class-hnd exact single-def <System.Collections.Generic.List`1[int]>
 ;  V01 RetBuf       [V01,T00] (  7,  7   )   byref  ->  rbx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.List`1+Enumerator[int]>
@@ -26,19 +26,23 @@ G_M47738_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=5 bbWeight=1 PerfScore 2.25
 G_M47738_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs +[rcx]
+       mov      gword ptr [rsp+0x18], rcx
+       ; GC ptr vars +{V00}
        mov      rdx, rcx
        ; gcrRegs +[rdx]
-       mov      esi, dword ptr [rcx+0x14]
+       mov      esi, dword ptr [rdx+0x14]
+       mov      rdx, gword ptr [rsp+0x18]
        mov      rcx, rbx
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
+       ; GC ptr vars -{V00}
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        xor      eax, eax
        mov      dword ptr [rbx+0x08], eax
        mov      dword ptr [rbx+0x0C], esi
-						;; size=22 bbWeight=1 PerfScore 5.75
+						;; size=32 bbWeight=1 PerfScore 7.75
 G_M47738_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        mov      dword ptr [rbx+0x10], eax
        mov      rax, rbx
@@ -50,7 +54,7 @@ G_M47738_IG04:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=3 bbWeight=1 PerfScore 2.00
 
-; Total bytes of code 36, prolog size 2, PerfScore 11.25, instruction count 15, allocated bytes for code 36 (MethodHash=a6344585) for method System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (FullOpts)
+; Total bytes of code 46, prolog size 2, PerfScore 13.25, instruction count 17, allocated bytes for code 46 (MethodHash=a6344585) for method System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (FullOpts)
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
|benchmarks.run.windows.x64.checked.mch|6,263|<span style="color:green">4,605</span>|<span style="color:red">761</span>|<span style="color:blue">897</span>|<span style="color:green">-46,622</span>|<span style="color:red">+10,028</span>|<span style="color:green">-0.1958%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|11,123|<span style="color:green">8,221</span>|<span style="color:red">1,650</span>|<span style="color:blue">1,252</span>|<span style="color:green">-98,611</span>|<span style="color:red">+20,723</span>|<span style="color:green">-0.2088%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|2,184|<span style="color:green">1,709</span>|<span style="color:red">220</span>|<span style="color:blue">255</span>|<span style="color:green">-19,635</span>|<span style="color:red">+3,896</span>|<span style="color:green">-0.2221%</span>|
|coreclr_tests.run.windows.x64.checked.mch|15,116|<span style="color:green">10,384</span>|<span style="color:red">1,913</span>|<span style="color:blue">2,819</span>|<span style="color:green">-180,221</span>|<span style="color:red">+19,052</span>|<span style="color:green">-0.0448%</span>|
|libraries.crossgen2.windows.x64.checked.mch|18,449|<span style="color:green">13,885</span>|<span style="color:red">1,518</span>|<span style="color:blue">3,046</span>|<span style="color:green">-101,255</span>|<span style="color:red">+14,973</span>|<span style="color:green">-0.0802%</span>|
|libraries.pmi.windows.x64.checked.mch|33,506|<span style="color:green">23,988</span>|<span style="color:red">3,509</span>|<span style="color:blue">6,009</span>|<span style="color:green">-195,343</span>|<span style="color:red">+30,212</span>|<span style="color:green">-0.1152%</span>|
|libraries_tests.run.windows.x64.Release.mch|56,808|<span style="color:green">37,806</span>|<span style="color:red">8,745</span>|<span style="color:blue">10,257</span>|<span style="color:green">-573,424</span>|<span style="color:red">+127,976</span>|<span style="color:green">-0.2062%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|65,378|<span style="color:green">52,139</span>|<span style="color:red">4,362</span>|<span style="color:blue">8,877</span>|<span style="color:green">-523,634</span>|<span style="color:red">+54,608</span>|<span style="color:green">-0.2560%</span>|
|realworld.run.windows.x64.checked.mch|5,468|<span style="color:green">3,586</span>|<span style="color:red">762</span>|<span style="color:blue">1,120</span>|<span style="color:green">-44,520</span>|<span style="color:red">+8,659</span>|<span style="color:green">-0.0952%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|4,120|<span style="color:green">2,894</span>|<span style="color:red">435</span>|<span style="color:blue">791</span>|<span style="color:green">-28,019</span>|<span style="color:red">+4,119</span>|<span style="color:green">-0.3241%</span>|
||218,415|<span style="color:green">159,217</span>|<span style="color:red">23,875</span>|<span style="color:blue">35,323</span>|<span style="color:green">-1,811,284</span>|<span style="color:red">+294,246</span>||

---

#### Context information

|Collection|Diffed contexts|MinOpts|FullOpts|Missed, base|Missed, diff|
|---|--:|--:|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|35,909|4|35,905|189 (0.52%)|188 (0.52%)|
|benchmarks.run_pgo.windows.x64.checked.mch|101,823|49,607|52,216|37 (0.04%)|33 (0.03%)|
|benchmarks.run_tiered.windows.x64.checked.mch|55,006|37,307|17,699|36 (0.07%)|36 (0.07%)|
|coreclr_tests.run.windows.x64.checked.mch|581,523|347,882|233,641|2,560 (0.44%)|2,567 (0.44%)|
|libraries.crossgen2.windows.x64.checked.mch|275,705|15|275,690|65 (0.02%)|65 (0.02%)|
|libraries.pmi.windows.x64.checked.mch|313,091|6|313,085|1,197 (0.38%)|1,206 (0.38%)|
|libraries_tests.run.windows.x64.Release.mch|697,457|498,513|198,944|2,703 (0.39%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|320,735|21,946|298,789|160 (0.05%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,689|3|36,686|213 (0.58%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,537|11|32,526|41 (0.13%)|41 (0.13%)|
||2,450,475|955,294|1,495,181|7,201 (0.29%)|7,147 (0.29%)|


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

Total bytes of base: 11449947 (overridden on cmd)
Total bytes of diff: 11413353 (overridden on cmd)
Total bytes of delta: -36594 (-0.32 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1138 : 3856.dasm (7.03% of base)
         256 : 23775.dasm (5.79% of base)
         248 : 23673.dasm (5.78% of base)
         213 : 9713.dasm (5.01% of base)
         200 : 5948.dasm (1.86% of base)
         197 : 24441.dasm (4.31% of base)
         178 : 20297.dasm (12.16% of base)
         154 : 9693.dasm (1.43% of base)
         139 : 16035.dasm (4.72% of base)
         136 : 11437.dasm (6.41% of base)
         110 : 4325.dasm (4.66% of base)
         109 : 5976.dasm (2.75% of base)
         103 : 16026.dasm (4.98% of base)
         100 : 2101.dasm (4.81% of base)
          94 : 2861.dasm (8.87% of base)
          94 : 10641.dasm (4.82% of base)
          94 : 19011.dasm (4.82% of base)
          94 : 15716.dasm (8.87% of base)
          88 : 32065.dasm (5.65% of base)
          81 : 8739.dasm (4.34% of base)

Top file improvements (bytes):
        -308 : 1281.dasm (-5.20% of base)
        -307 : 29804.dasm (-8.35% of base)
        -275 : 20162.dasm (-4.26% of base)
        -216 : 29408.dasm (-3.60% of base)
        -182 : 8833.dasm (-2.20% of base)
        -173 : 21181.dasm (-6.74% of base)
        -162 : 10351.dasm (-5.71% of base)
        -162 : 18649.dasm (-5.71% of base)
        -153 : 10444.dasm (-1.16% of base)
        -153 : 18749.dasm (-1.16% of base)
        -134 : 35516.dasm (-1.25% of base)
        -121 : 26401.dasm (-4.85% of base)
        -120 : 23243.dasm (-5.06% of base)
        -120 : 34754.dasm (-3.04% of base)
        -115 : 11167.dasm (-5.56% of base)
        -115 : 20634.dasm (-5.56% of base)
        -114 : 4207.dasm (-6.17% of base)
        -113 : 9166.dasm (-21.94% of base)
        -111 : 19704.dasm (-6.03% of base)
        -110 : 9313.dasm (-2.16% of base)

87 total files with Code Size differences (47 improved, 40 regressed), 20 unchanged.

Top method regressions (bytes):
        1138 ( 7.03% of base) : 3856.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         256 ( 5.79% of base) : 23775.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         248 ( 5.78% of base) : 23673.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         213 ( 5.01% of base) : 9713.dasm - Utf8Json.Formatters.ISO8601DateTimeFormatter:Deserialize(byref,Utf8Json.IJsonFormatterResolver):System.DateTime:this (FullOpts)
         200 ( 1.86% of base) : 5948.dasm - Utf8Json.Formatters.ISO8601DateTimeOffsetFormatter:Serialize(byref,System.DateTimeOffset,Utf8Json.IJsonFormatterResolver):this (FullOpts)
         197 ( 4.31% of base) : 24441.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         178 (12.16% of base) : 20297.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         154 ( 1.43% of base) : 9693.dasm - Utf8Json.Formatters.ISO8601DateTimeFormatter:Serialize(byref,System.DateTime,Utf8Json.IJsonFormatterResolver):this (FullOpts)
         139 ( 4.72% of base) : 16035.dasm - System.Buffers.Text.Base64:DecodeFromUtf8(System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte],byref,byref,ubyte,ubyte):int (FullOpts)
         136 ( 6.41% of base) : 11437.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         110 ( 4.66% of base) : 4325.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         109 ( 2.75% of base) : 5976.dasm - Utf8Json.Formatters.ISO8601DateTimeOffsetFormatter:Deserialize(byref,Utf8Json.IJsonFormatterResolver):System.DateTimeOffset:this (FullOpts)
         103 ( 4.98% of base) : 16026.dasm - System.Text.Json.JsonSerializer:LookupProperty(System.Object,System.ReadOnlySpan`1[ubyte],byref,System.Text.Json.JsonSerializerOptions,byref,ubyte):System.Text.Json.Serialization.Metadata.JsonPropertyInfo (FullOpts)
         100 ( 4.81% of base) : 2101.dasm - System.Text.Json.JsonSerializer:LookupProperty(System.Object,System.ReadOnlySpan`1[ubyte],byref,System.Text.Json.JsonSerializerOptions,byref,ubyte):System.Text.Json.Serialization.Metadata.JsonPropertyInfo (FullOpts)
          94 ( 8.87% of base) : 2861.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
          94 ( 8.87% of base) : 15716.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
          94 ( 4.82% of base) : 10641.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>FAB93D28E879A1C012F40790EA668F818AB3858873713FA53950E20F52E058952__Regex1_3+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
          94 ( 4.82% of base) : 19011.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>FAB93D28E879A1C012F40790EA668F818AB3858873713FA53950E20F52E058952__Regex1_3+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
          88 ( 5.65% of base) : 32065.dasm - MessagePack.Formatters.MicroBenchmarks_Serializers_CampaignSummaryViewModelFormatter3:Deserialize(ubyte[],int,MessagePack.IFormatterResolver,byref):MicroBenchmarks.Serializers.CampaignSummaryViewModel:this (FullOpts)
          81 ( 4.34% of base) : 8739.dasm - MessagePack.Formatters.MicroBenchmarks_Serializers_LocationFormatter1:Deserialize(ubyte[],int,MessagePack.IFormatterResolver,byref):MicroBenchmarks.Serializers.Location:this (FullOpts)

Top method improvements (bytes):
        -308 (-5.20% of base) : 1281.dasm - System.DateTimeFormat:FormatCustomized[ushort](System.DateTime,System.ReadOnlySpan`1[ushort],System.Globalization.DateTimeFormatInfo,System.TimeSpan,byref) (FullOpts)
        -307 (-8.35% of base) : 29804.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -275 (-4.26% of base) : 20162.dasm - System.DateTimeFormat:FormatCustomized[ushort](System.DateTime,System.ReadOnlySpan`1[ushort],System.Globalization.DateTimeFormatInfo,System.TimeSpan,byref) (FullOpts)
        -216 (-3.60% of base) : 29408.dasm - System.Reflection.FieldAccessor:SetValue(System.Object,System.Object,int,System.Reflection.Binder,System.Globalization.CultureInfo):this (FullOpts)
        -182 (-2.20% of base) : 8833.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:ConvertToSymbolicRegexNode(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.Text.RegularExpressions.Symbolic.BDD]:this (FullOpts)
        -173 (-6.74% of base) : 21181.dasm - System.Text.Json.Tests.Perf_Segment:ReadMultiSegmentSequenceUsingSpan(int):this (FullOpts)
        -162 (-5.71% of base) : 10351.dasm - System.Xml.Serialization.TypeScope:AddSoapEncodedTypes(System.String) (FullOpts)
        -162 (-5.71% of base) : 18649.dasm - System.Xml.Serialization.TypeScope:AddSoapEncodedTypes(System.String) (FullOpts)
        -153 (-1.16% of base) : 10444.dasm - System.Xml.Serialization.XmlReflectionImporter:ImportAccessorMapping(System.Xml.Serialization.MemberMapping,System.Xml.Serialization.FieldModel,System.Xml.Serialization.XmlAttributes,System.String,System.Type,ubyte,ubyte,System.Xml.Serialization.RecursionLimiter):this (FullOpts)
        -153 (-1.16% of base) : 18749.dasm - System.Xml.Serialization.XmlReflectionImporter:ImportAccessorMapping(System.Xml.Serialization.MemberMapping,System.Xml.Serialization.FieldModel,System.Xml.Serialization.XmlAttributes,System.String,System.Type,ubyte,ubyte,System.Xml.Serialization.RecursionLimiter):this (FullOpts)
        -134 (-1.25% of base) : 35516.dasm - Jil.Deserialize.Methods:_ReadISO8601DateThunkReader(byref,ushort[]):System.DateTime (FullOpts)
        -121 (-4.85% of base) : 26401.dasm - Microsoft.CodeAnalysis.CSharp.BinderFactory+BinderFactoryVisitor:VisitCompilationUnit(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Binder:this (FullOpts)
        -120 (-5.06% of base) : 23243.dasm - MessagePack.Formatters.ListFormatter`1[int]:Serialize(byref,int,System.Collections.Generic.List`1[int],MessagePack.IFormatterResolver):int:this (FullOpts)
        -120 (-3.04% of base) : 34754.dasm - System.Numerics.BigIntegerCalculator:MultiplyFarLength(System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (FullOpts)
        -115 (-5.56% of base) : 11167.dasm - System.Enum:TryFormatFlagNames[uint](System.Enum+EnumInfo`1[uint],uint,System.Span`1[ushort],byref,byref):ubyte (FullOpts)
        -115 (-5.56% of base) : 20634.dasm - System.Enum:TryFormatFlagNames[uint](System.Enum+EnumInfo`1[uint],uint,System.Span`1[ushort],byref,byref):ubyte (FullOpts)
        -114 (-6.17% of base) : 4207.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory:CreateArgumentCallSites(Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,System.Type,Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain,System.Reflection.ParameterInfo[],ubyte):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite[]:this (FullOpts)
        -113 (-21.94% of base) : 9166.dasm - System.MemoryExtensions:ToLowerInvariant(System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):int (FullOpts)
        -111 (-6.03% of base) : 19704.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory:CreateArgumentCallSites(Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,System.Type,Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain,System.Reflection.ParameterInfo[],ubyte):Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite[]:this (FullOpts)
        -110 (-2.16% of base) : 9313.dasm - System.ComponentModel.ReflectTypeDescriptionProvider+<>c:<get_IntrinsicTypeConverters>b__24_0():System.Collections.Generic.Dictionary`2[System.Object,System.ComponentModel.ReflectTypeDescriptionProvider+IntrinsicTypeConverterData]:this (FullOpts)

Top method regressions (percentages):
          26 (24.07% of base) : 7821.dasm - System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
          38 (20.11% of base) : 813.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 13171.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          16 (15.69% of base) : 8149.dasm - Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark:ForEach_Array():int:this (FullOpts)
          16 (15.69% of base) : 7999.dasm - Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark:ForEach_String():int:this (FullOpts)
          41 (14.96% of base) : 31226.dasm - BenchmarksGame.Fasta_1:MakeRepeatFastaBuffer(ubyte[],int,System.IO.Stream) (FullOpts)
          22 (14.86% of base) : 1386.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
          22 (14.86% of base) : 17104.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
          10 (13.89% of base) : 28179.dasm - System.Reflection.Metadata.BlobBuilder:GetBlobs():System.Reflection.Metadata.BlobBuilder+Blobs:this (FullOpts)
          10 (13.89% of base) : 27307.dasm - System.Reflection.Metadata.BlobBuilder:GetChunks():System.Reflection.Metadata.BlobBuilder+Chunks:this (FullOpts)
         178 (12.16% of base) : 20297.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          16 (11.19% of base) : 29377.dasm - System.Numerics.Tests.Perf_Matrix4x4:SubtractBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
          16 (11.19% of base) : 21219.dasm - System.Numerics.Tests.Perf_Matrix4x4:SubtractOperatorBenchmark():System.Numerics.Matrix4x4:this (FullOpts)
           6 ( 9.09% of base) : 31075.dasm - Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark:Indexer_FirstElement_Array():System.String:this (FullOpts)
           6 ( 9.09% of base) : 30755.dasm - Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark:Indexer_FirstElement_String():System.String:this (FullOpts)
          94 ( 8.87% of base) : 2861.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
          94 ( 8.87% of base) : 15716.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
          12 ( 8.39% of base) : 8371.dasm - System.Xml.XmlBinaryNodeWriter:WriteMultiByteInt32(int):this (FullOpts)
           3 ( 7.69% of base) : 8883.dasm - System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this (FullOpts)
          10 ( 7.58% of base) : 20211.dasm - System.Text.Json.JsonWriterHelper:WriteIndentation(System.Span`1[ubyte],int,ubyte) (FullOpts)

Top method improvements (percentages):
          -6 (-30.00% of base) : 29161.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -8 (-22.22% of base) : 27735.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 26179.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
          -8 (-22.22% of base) : 5802.dasm - System.Reflection.RuntimeConstructorInfo:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 18841.dasm - System.Reflection.RuntimeConstructorInfo:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 3587.dasm - System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 17776.dasm - System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 13119.dasm - System.Reflection.RuntimeMethodInfo:get_ReturnType():System.Type:this (FullOpts)
          -8 (-22.22% of base) : 762.dasm - System.Reflection.RuntimeMethodInfo:get_ReturnType():System.Type:this (FullOpts)
        -113 (-21.94% of base) : 9166.dasm - System.MemoryExtensions:ToLowerInvariant(System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):int (FullOpts)
          -6 (-21.43% of base) : 5537.dasm - System.Collections.Generic.Dictionary`2[System.Collections.NotKnownComparable,System.Collections.NotKnownComparable]:get_Comparer():System.Collections.Generic.IEqualityComparer`1[System.Collections.NotKnownComparable]:this (FullOpts)
          -6 (-21.43% of base) : 16110.dasm - System.Collections.Generic.HashSet`1[short]:get_Comparer():System.Collections.Generic.IEqualityComparer`1[short]:this (FullOpts)
          -6 (-21.43% of base) : 5550.dasm - System.Collections.Generic.HashSet`1[System.Collections.NotKnownComparable]:get_Comparer():System.Collections.Generic.IEqualityComparer`1[System.Collections.NotKnownComparable]:this (FullOpts)
          -6 (-21.43% of base) : 30412.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (FullOpts)
          -6 (-21.43% of base) : 22138.dasm - System.Runtime.Serialization.Json.DataContractJsonSerializer:get_RootName():System.Xml.XmlDictionaryString:this (FullOpts)
          -6 (-21.43% of base) : 10486.dasm - System.Xml.Serialization.Accessor:get_Name():System.String:this (FullOpts)
          -6 (-21.43% of base) : 18791.dasm - System.Xml.Serialization.Accessor:get_Name():System.String:this (FullOpts)
          -6 (-21.43% of base) : 10625.dasm - System.Xml.Serialization.MemberMapping:get_Name():System.String:this (FullOpts)
          -6 (-21.43% of base) : 18995.dasm - System.Xml.Serialization.MemberMapping:get_Name():System.String:this (FullOpts)
          -6 (-21.43% of base) : 10500.dasm - System.Xml.Serialization.XmlArrayItemAttribute:get_ElementName():System.String:this (FullOpts)

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

Total bytes of base: 35521636 (overridden on cmd)
Total bytes of diff: 35443748 (overridden on cmd)
Total bytes of delta: -77888 (-0.22 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1138 : 15282.dasm (7.03% of base)
         238 : 51903.dasm (5.04% of base)
         213 : 49678.dasm (4.73% of base)
         208 : 51040.dasm (4.51% of base)
         174 : 90480.dasm (3.92% of base)
         170 : 30003.dasm (7.28% of base)
         162 : 36149.dasm (10.44% of base)
         119 : 16569.dasm (2.66% of base)
          97 : 71659.dasm (2.10% of base)
          92 : 45229.dasm (2.83% of base)
          89 : 69205.dasm (14.22% of base)
          81 : 47293.dasm (6.12% of base)
          80 : 73725.dasm (2.31% of base)
          79 : 58980.dasm (1.78% of base)
          73 : 69201.dasm (6.72% of base)
          69 : 90924.dasm (2.27% of base)
          69 : 94534.dasm (2.27% of base)
          69 : 69906.dasm (2.27% of base)
          69 : 73511.dasm (2.27% of base)
          65 : 71649.dasm (4.16% of base)

Top file improvements (bytes):
        -527 : 71621.dasm (-8.43% of base)
        -381 : 86789.dasm (-8.82% of base)
        -370 : 54515.dasm (-9.11% of base)
        -365 : 97873.dasm (-13.68% of base)
        -364 : 86950.dasm (-13.51% of base)
        -352 : 75903.dasm (-9.59% of base)
        -347 : 67749.dasm (-11.08% of base)
        -304 : 68690.dasm (-4.20% of base)
        -203 : 95389.dasm (-10.50% of base)
        -203 : 56118.dasm (-5.48% of base)
        -203 : 97957.dasm (-10.47% of base)
        -189 : 91966.dasm (-7.50% of base)
        -182 : 97576.dasm (-9.63% of base)
        -169 : 68687.dasm (-4.07% of base)
        -166 : 36821.dasm (-4.76% of base)
        -165 : 43200.dasm (-6.30% of base)
        -164 : 71626.dasm (-3.45% of base)
        -164 : 33075.dasm (-3.61% of base)
        -161 : 88965.dasm (-14.78% of base)
        -157 : 76832.dasm (-4.57% of base)

88 total files with Code Size differences (46 improved, 42 regressed), 20 unchanged.

Top method regressions (bytes):
        1138 ( 7.03% of base) : 15282.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         238 ( 5.04% of base) : 51903.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         213 ( 4.73% of base) : 49678.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         208 ( 4.51% of base) : 51040.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         174 ( 3.92% of base) : 90480.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
         170 ( 7.28% of base) : 30003.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         162 (10.44% of base) : 36149.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         119 ( 2.66% of base) : 16569.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          97 ( 2.10% of base) : 71659.dasm - Microsoft.CodeAnalysis.SyntaxNode+<DescendantTriviaOnly>d__176:MoveNext():ubyte:this (Tier1)
          92 ( 2.83% of base) : 45229.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          89 (14.22% of base) : 69205.dasm - System.Reflection.Metadata.BlobBuilder:WriteUTF8(System.String,ubyte):this (Tier1)
          81 ( 6.12% of base) : 47293.dasm - System.Number:FormatBigIntegerToHex(ubyte,System.Numerics.BigInteger,ushort,int,System.Globalization.NumberFormatInfo,System.Span`1[ushort],byref,byref):System.String (Tier0-FullOpts)
          80 ( 2.31% of base) : 73725.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          79 ( 1.78% of base) : 58980.dasm - System.Reflection.CustomAttribute:AddCustomAttributes(byref,System.Reflection.RuntimeModule,int,System.RuntimeType,ubyte,System.RuntimeType+ListBuilder`1[System.Object]) (Tier1)
          73 ( 6.72% of base) : 69201.dasm - System.Reflection.Metadata.BlobBuilder:WriteUTF8(System.String,int,int,ubyte,ubyte):this (Tier1)
          69 ( 2.27% of base) : 90924.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
          69 ( 2.27% of base) : 94534.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
          69 ( 2.27% of base) : 69906.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
          69 ( 2.27% of base) : 73511.dasm - System.Collections.Generic.ArraySortHelper`1[int]:IntroSort(System.Span`1[int],int,System.Comparison`1[int]) (Tier1)
          65 ( 4.16% of base) : 71649.dasm - Microsoft.CodeAnalysis.SyntaxNode+ChildSyntaxListEnumeratorStack:TryGetNextInSpan(byref,byref):ubyte:this (Tier1)

Top method improvements (bytes):
        -527 (-8.43% of base) : 71621.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:Analyze(byref,Microsoft.CodeAnalysis.DiagnosticBag):this (Tier1)
        -381 (-8.82% of base) : 86789.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
        -370 (-9.11% of base) : 54515.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
        -365 (-13.68% of base) : 97873.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
        -364 (-13.51% of base) : 86950.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
        -352 (-9.59% of base) : 75903.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -347 (-11.08% of base) : 67749.dasm - Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter:DoVisitList[System.__Canon](System.Collections.Immutable.ImmutableArray`1[System.__Canon]):System.Collections.Immutable.ImmutableArray`1[System.__Canon]:this (Tier1)
        -304 (-4.20% of base) : 68690.dasm - Microsoft.Cci.ReferenceIndexerBase:Visit(Microsoft.Cci.IMethodReference):this (Tier1)
        -203 (-5.48% of base) : 56118.dasm - System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
        -203 (-10.50% of base) : 95389.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:CreateDerivative(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],ulong,uint):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
        -203 (-10.47% of base) : 97957.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:CreateDerivative(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],ulong,uint):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
        -189 (-7.50% of base) : 91966.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
        -182 (-9.63% of base) : 97576.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:CreateDerivative(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],ulong,uint):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
        -169 (-4.07% of base) : 68687.dasm - Microsoft.Cci.MetadataVisitor:Visit(Microsoft.Cci.ICustomAttribute):this (Tier1)
        -166 (-4.76% of base) : 36821.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (Tier0-FullOpts)
        -165 (-6.30% of base) : 43200.dasm - System.Numerics.BigIntegerCalculator:PowCore(System.Span`1[uint],int,System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint],int,System.Span`1[uint]):System.Span`1[uint] (Tier1-OSR)
        -164 (-3.45% of base) : 71626.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:Scan(byref):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2+PendingBranch[Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState,Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalFunctionState]]:this (Tier1)
        -164 (-3.61% of base) : 33075.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:CreateAlternate(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],ubyte,ubyte):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong] (Tier1)
        -161 (-14.78% of base) : 88965.dasm - System.Numerics.BigIntegerCalculator:Divide(System.Span`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (Tier1)
        -157 (-4.57% of base) : 76832.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int,System.Comparison`1[System.Collections.IntStruct]) (Tier1)

Top method regressions (percentages):
           7 (20.00% of base) : 29745.dasm - System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)
           7 (18.92% of base) : 29769.dasm - System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)
           7 (16.67% of base) : 63087.dasm - System.Reflection.Metadata.MetadataReader:GetCustomAttribute(System.Reflection.Metadata.CustomAttributeHandle):System.Reflection.Metadata.CustomAttribute:this (Tier1)
          89 (14.22% of base) : 69205.dasm - System.Reflection.Metadata.BlobBuilder:WriteUTF8(System.String,ubyte):this (Tier1)
          10 (13.89% of base) : 67913.dasm - System.Reflection.Metadata.BlobBuilder:GetChunks():System.Reflection.Metadata.BlobBuilder+Chunks:this (Tier1)
          24 (10.62% of base) : 83853.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 3145.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 98959.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 38304.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 74817.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 83796.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 54893.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 46867.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 80717.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 49509.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 54287.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 55794.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 29274.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.62% of base) : 40605.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          24 (10.53% of base) : 75988.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)

Top method improvements (percentages):
          -6 (-27.27% of base) : 71799.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
         -15 (-25.86% of base) : 67089.dasm - System.Threading.Tasks.ParallelOptions:get_EffectiveTaskScheduler():System.Threading.Tasks.TaskScheduler:this (Tier1)
          -6 (-21.43% of base) : 67844.dasm - Microsoft.CodeAnalysis.DiagnosticBag:AsEnumerableWithoutResolution():System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.Diagnostic]:this (Tier1)
          -8 (-21.05% of base) : 45284.dasm - System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (Tier1)
          -8 (-21.05% of base) : 16557.dasm - System.Reflection.RuntimeMethodInfo:get_ReturnType():System.Type:this (Tier1)
        -123 (-18.87% of base) : 91921.dasm - System.Globalization.Ordinal:ToUpperOrdinal(System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):int (Tier1)
          -9 (-15.79% of base) : 67903.dasm - Microsoft.CodeAnalysis.Emit.EmitContext:get_SyntaxNode():Microsoft.CodeAnalysis.SyntaxNode:this (Tier1)
         -12 (-15.79% of base) : 86932.dasm - System.Globalization.CultureInfo:get_Name():System.String:this (Tier1)
         -12 (-15.79% of base) : 97847.dasm - System.Globalization.CultureInfo:get_Name():System.String:this (Tier1)
         -12 (-15.79% of base) : 91940.dasm - System.Globalization.CultureInfo:get_Name():System.String:this (Tier1)
         -51 (-15.32% of base) : 54837.dasm - System.Text.Encodings.Web.OptimizedInboxTextEncoder:GetIndexOfFirstCharToEncodeSsse3(ulong,ulong):ulong:this (Tier1)
         -51 (-15.32% of base) : 91389.dasm - System.Text.Encodings.Web.OptimizedInboxTextEncoder:GetIndexOfFirstCharToEncodeSsse3(ulong,ulong):ulong:this (Tier1)
        -161 (-14.78% of base) : 88965.dasm - System.Numerics.BigIntegerCalculator:Divide(System.Span`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (Tier1)
         -14 (-14.29% of base) : 97825.dasm - System.Text.RegularExpressions.Symbolic.CharSetSolver:get_NonAscii():System.Text.RegularExpressions.Symbolic.BDD:this (Tier1)
         -14 (-14.29% of base) : 95260.dasm - System.Text.RegularExpressions.Symbolic.CharSetSolver:get_NonAscii():System.Text.RegularExpressions.Symbolic.BDD:this (Tier1)
          -9 (-14.29% of base) : 97528.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong]:get_Epsilon():System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:this (Tier1)
        -365 (-13.68% of base) : 97873.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)
         -15 (-13.64% of base) : 88958.dasm - System.Numerics.BigIntegerCalculator:Compare(System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint]):int (Tier1)
         -10 (-13.51% of base) : 71851.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:ReportUnusedVariables(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol]):this (Tier1)
        -364 (-13.51% of base) : 86950.dasm - System.Collections.Generic.ArraySortHelper`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]:IntroSort(System.Span`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet],int,System.Comparison`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]) (Tier1)

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

Total bytes of base: 12726982 (overridden on cmd)
Total bytes of diff: 12711243 (overridden on cmd)
Total bytes of delta: -15739 (-0.12 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1138 : 17028.dasm (7.03% of base)
         256 : 31896.dasm (5.79% of base)
         248 : 31791.dasm (5.78% of base)
         197 : 32239.dasm (4.31% of base)
         178 : 25973.dasm (12.16% of base)
         136 : 23635.dasm (6.41% of base)
         110 : 14321.dasm (4.66% of base)
          94 : 20487.dasm (8.87% of base)
          54 : 29564.dasm (4.13% of base)
          49 : 2040.dasm (0.67% of base)
          49 : 25243.dasm (1.48% of base)
          44 : 26538.dasm (2.61% of base)
          40 : 52749.dasm (0.40% of base)
          31 : 49193.dasm (0.30% of base)
          30 : 54369.dasm (1.95% of base)
          28 : 42174.dasm (2.02% of base)
          27 : 47804.dasm (8.39% of base)
          26 : 42272.dasm (2.27% of base)
          26 : 46569.dasm (2.10% of base)
          26 : 41690.dasm (1.64% of base)

Top file improvements (bytes):
        -307 : 45482.dasm (-8.35% of base)
        -182 : 52858.dasm (-2.21% of base)
        -120 : 26352.dasm (-7.69% of base)
        -120 : 52421.dasm (-3.04% of base)
        -107 : 50166.dasm (-21.36% of base)
        -106 : 31606.dasm (-2.88% of base)
        -104 : 45480.dasm (-6.45% of base)
        -103 : 43536.dasm (-1.78% of base)
         -99 : 9089.dasm (-3.52% of base)
         -96 : 44305.dasm (-4.70% of base)
         -95 : 27370.dasm (-6.37% of base)
         -94 : 49195.dasm (-2.77% of base)
         -66 : 47152.dasm (-5.31% of base)
         -62 : 52747.dasm (-1.42% of base)
         -59 : 48105.dasm (-0.36% of base)
         -59 : 44094.dasm (-1.56% of base)
         -59 : 30623.dasm (-4.07% of base)
         -59 : 25852.dasm (-15.95% of base)
         -58 : 15997.dasm (-7.54% of base)
         -58 : 31716.dasm (-5.96% of base)

86 total files with Code Size differences (48 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
        1138 ( 7.03% of base) : 17028.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         256 ( 5.79% of base) : 31896.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         248 ( 5.78% of base) : 31791.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         197 ( 4.31% of base) : 32239.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         178 (12.16% of base) : 25973.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         136 ( 6.41% of base) : 23635.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         110 ( 4.66% of base) : 14321.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          94 ( 8.87% of base) : 20487.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (Tier1)
          54 ( 4.13% of base) : 29564.dasm - System.Number:FormatBigIntegerToHex(ubyte,System.Numerics.BigInteger,ushort,int,System.Globalization.NumberFormatInfo,System.Span`1[ushort],byref,byref):System.String (Tier0-FullOpts)
          49 ( 0.67% of base) : 2040.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier0-FullOpts)
          49 ( 1.48% of base) : 25243.dasm - System.Reflection.MethodBaseInvoker:InvokeWithManyArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (Tier0-FullOpts)
          44 ( 2.61% of base) : 26538.dasm - System.Formats.Tar.TarHeader:GenerateExtendedAttributesDataStream(System.Collections.Generic.Dictionary`2[System.String,System.String]):System.IO.MemoryStream (Tier0-FullOpts)
          40 ( 0.40% of base) : 52749.dasm - (dynamicClass):_DynamicMethod3(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerItem (FullOpts)
          31 ( 0.30% of base) : 49193.dasm - (dynamicClass):_DynamicMethod3(byref,int):MicroBenchmarks.Serializers.MyEventsListerItem (FullOpts)
          30 ( 1.95% of base) : 54369.dasm - System.Decimal+DecCalc:DecAddSub(byref,byref,ubyte) (Tier1)
          28 ( 2.02% of base) : 42174.dasm - System.Buffers.SearchValues:Create(System.ReadOnlySpan`1[ushort]):System.Buffers.SearchValues`1[ushort] (Tier1)
          27 ( 8.39% of base) : 47804.dasm - BenchmarksGame.Fasta_1:MakeRepeatFastaBuffer(ubyte[],int,System.IO.Stream) (Tier1-OSR)
          26 ( 1.64% of base) : 41690.dasm - System.Buffers.StringSearchValues:Create(System.ReadOnlySpan`1[System.String],ubyte):System.Buffers.SearchValues`1[System.String] (Tier1)
          26 ( 2.27% of base) : 42272.dasm - System.Number:<TryFormatInt32>g__TryFormatInt32Slow|42_0[ushort](int,int,System.ReadOnlySpan`1[ushort],System.IFormatProvider,System.Span`1[ushort],byref):ubyte (Tier1)
          26 ( 2.10% of base) : 46569.dasm - System.Reflection.RuntimeCustomAttributeData:.ctor(System.Reflection.RuntimeModule,System.Reflection.MetadataToken,byref):this (Tier1)

Top method improvements (bytes):
        -307 (-8.35% of base) : 45482.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -182 (-2.21% of base) : 52858.dasm - System.Text.RegularExpressions.Symbolic.RegexNodeConverter:ConvertToSymbolicRegexNode(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[System.Text.RegularExpressions.Symbolic.BDD]:this (Tier1)
        -120 (-3.04% of base) : 52421.dasm - System.Numerics.BigIntegerCalculator:MultiplyFarLength(System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (Tier0-FullOpts)
        -120 (-7.69% of base) : 26352.dasm - System.Reflection.MethodBaseInvoker:InvokeWithFewArgs(System.Object,int,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo):System.Object:this (Tier1)
        -107 (-21.36% of base) : 50166.dasm - System.Globalization.Ordinal:ToUpperOrdinal(System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):int (Tier1)
        -106 (-2.88% of base) : 31606.dasm - (dynamicClass):_DynamicMethod3(byref):int (FullOpts)
        -104 (-6.45% of base) : 45480.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -103 (-1.78% of base) : 43536.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindVariableDeclaration(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol,ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode):Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration:this (Tier1)
         -99 (-3.52% of base) : 9089.dasm - System.Threading.PortableThreadPool+HillClimbing:Update(int,double,int):System.ValueTuple`2[int,int]:this (Tier1)
         -96 (-4.70% of base) : 44305.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ModifierUtils:CheckModifiers(ubyte,ubyte,uint,uint,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,System.Nullable`1[Microsoft.CodeAnalysis.SyntaxTokenList],byref):uint (Tier1)
         -95 (-6.37% of base) : 27370.dasm - System.Numerics.BigIntegerCalculator:Square(System.ReadOnlySpan`1[uint],System.Span`1[uint]) (Tier0-FullOpts)
         -94 (-2.77% of base) : 49195.dasm - (dynamicClass):_DynamicMethod7(byref):int (FullOpts)
         -66 (-5.31% of base) : 47152.dasm - BenchmarksGame.FannkuchRedux_9:Run(int,int) (Tier0-FullOpts)
         -62 (-1.42% of base) : 52747.dasm - (dynamicClass):_DynamicMethod9(System.IO.TextReader,int):MicroBenchmarks.Serializers.MyEventsListerViewModel (FullOpts)
         -59 (-0.36% of base) : 48105.dasm - (dynamicClass):_DynamicMethod1(byref,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
         -59 (-1.56% of base) : 44094.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParsePostFixExpression(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax:this (Tier1)
         -59 (-15.95% of base) : 25852.dasm - System.Globalization.TextInfo:ChangeCaseCommon[System.Globalization.TextInfo+ToUpperConversion](System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):this (Tier1)
         -59 (-4.07% of base) : 30623.dasm - Utility:sscanf(System.String,System.String,System.Object[]):int (Tier1)
         -58 (-7.54% of base) : 15997.dasm - System.Array+SorterObjectArray:PickPivotAndPartition(int,int):int:this (Tier1)
         -58 (-5.96% of base) : 31716.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method regressions (percentages):
          10 (27.78% of base) : 44289.dasm - System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (Tier1)
           7 (20.00% of base) : 22675.dasm - System.Threading.Channels.AsyncOperation`1[System.VoidResult]:get_ValueTask():System.Threading.Tasks.ValueTask:this (Tier1)
           7 (18.92% of base) : 22699.dasm - System.Threading.Channels.AsyncOperation`1[ubyte]:get_ValueTaskOfT():System.Threading.Tasks.ValueTask`1[ubyte]:this (Tier1)
           7 (16.67% of base) : 35330.dasm - System.Reflection.Metadata.MetadataReader:GetCustomAttribute(System.Reflection.Metadata.CustomAttributeHandle):System.Reflection.Metadata.CustomAttribute:this (Tier1)
          22 (14.86% of base) : 30800.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (Tier1)
         178 (12.16% of base) : 25973.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          24 (11.21% of base) : 6620.dasm - System.Collections.Generic.Dictionary`2+ValueCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          20 ( 9.48% of base) : 6619.dasm - System.Collections.Generic.Dictionary`2+KeyCollection[System.__Canon,System.__Canon]:CopyTo(System.__Canon[],int):this (Tier1-OSR)
          94 ( 8.87% of base) : 20487.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (Tier1)
          27 ( 8.39% of base) : 47804.dasm - BenchmarksGame.Fasta_1:MakeRepeatFastaBuffer(ubyte[],int,System.IO.Stream) (Tier1-OSR)
          15 ( 8.33% of base) : 22757.dasm - System.Collections.Generic.HashSet`1[System.__Canon]:CopyTo(System.__Canon[],int,int):this (Tier1-OSR)
          10 ( 8.06% of base) : 29487.dasm - Struct.FilteredSpanEnumerator:Sum():int:this (Tier1-OSR)
           3 ( 7.69% of base) : 52835.dasm - System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this (Tier1)
           7 ( 7.37% of base) : 40852.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax:get_Token():Microsoft.CodeAnalysis.SyntaxToken:this (Tier1)
           7 ( 7.37% of base) : 43454.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax:get_Keyword():Microsoft.CodeAnalysis.SyntaxToken:this (Tier1)
           7 ( 7.37% of base) : 43532.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax:get_Identifier():Microsoft.CodeAnalysis.SyntaxToken:this (Tier1)
        1138 ( 7.03% of base) : 17028.dasm - (dynamicClass):_DynamicMethod1(System.IO.TextReader,int):MicroBenchmarks.Serializers.IndexViewModel (FullOpts)
           3 ( 6.82% of base) : 43597.dasm - Roslyn.Utilities.ReaderWriterLockSlimExtensions:DisposableRead(System.Threading.ReaderWriterLockSlim):Roslyn.Utilities.ReaderWriterLockSlimExtensions+ReadLockExiter (Tier1)
         136 ( 6.41% of base) : 23635.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
           3 ( 6.00% of base) : 40913.dasm - Microsoft.CodeAnalysis.SyntaxNode:ChildNodesAndTokens():Microsoft.CodeAnalysis.ChildSyntaxList:this (Tier1)

Top method improvements (percentages):
         -38 (-30.89% of base) : 42270.dasm - System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (Tier1)
          -6 (-30.00% of base) : 44184.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1+Builder[System.__Canon]:get_ReadOnlySet():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:this (Tier1)
          -6 (-30.00% of base) : 43793.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
          -6 (-30.00% of base) : 53921.dasm - System.Linq.Expressions.Compiler.CompilerScope:get_NearestHoistedLocals():System.Linq.Expressions.Compiler.HoistedLocals:this (Tier1)
          -6 (-24.00% of base) : 53920.dasm - System.Linq.Expressions.Compiler.CompilerScope:ResolveVariable(System.Linq.Expressions.ParameterExpression):System.Linq.Expressions.Compiler.CompilerScope+Storage:this (Tier1)
          -8 (-22.22% of base) : 40460.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (Tier1)
          -8 (-22.22% of base) : 28221.dasm - System.Reflection.RuntimeConstructorInfo:get_ArgumentTypes():System.RuntimeType[]:this (Tier1)
          -8 (-22.22% of base) : 28075.dasm - System.Reflection.RuntimeMethodInfo:get_ArgumentTypes():System.RuntimeType[]:this (Tier1)
          -8 (-22.22% of base) : 4158.dasm - System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (Tier1)
          -8 (-22.22% of base) : 4139.dasm - System.Reflection.RuntimeMethodInfo:get_ReturnType():System.Type:this (Tier1)
          -6 (-21.43% of base) : 47872.dasm - System.Collections.Generic.Dictionary`2[System.Collections.NotKnownComparable,System.Collections.NotKnownComparable]:get_Comparer():System.Collections.Generic.IEqualityComparer`1[System.Collections.NotKnownComparable]:this (Tier1)
          -6 (-21.43% of base) : 8382.dasm - System.Globalization.CultureData:get_Name():System.String:this (Tier1)
          -6 (-21.43% of base) : 41677.dasm - System.Xml.Serialization.Accessor:get_Name():System.String:this (Tier1)
        -107 (-21.36% of base) : 50166.dasm - System.Globalization.Ordinal:ToUpperOrdinal(System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):int (Tier1)
         -21 (-19.81% of base) : 8539.dasm - System.Net.Security.SslSessionsCache+SslCredKey:.ctor(ubyte[],int,ubyte,int,ubyte,ubyte,ubyte):this (Tier1)
          -9 (-18.00% of base) : 40538.dasm - System.Threading.Tasks.ParallelOptions:get_EffectiveTaskScheduler():System.Threading.Tasks.TaskScheduler:this (Tier1)
         -45 (-16.92% of base) : 42273.dasm - System.Number:TryInt32ToHexStr[ushort](int,ushort,int,System.Span`1[ushort],byref):ubyte (Tier1)
          -8 (-16.67% of base) : 41126.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_RefKind():ubyte:this (Tier1)
          -8 (-16.33% of base) : 41068.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_RefCustomModifiers():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CustomModifier]:this (Tier1)
         -59 (-15.95% of base) : 25852.dasm - System.Globalization.TextInfo:ChangeCaseCommon[System.Globalization.TextInfo+ToUpperConversion](System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):this (Tier1)

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

Total bytes of base: 386972045 (overridden on cmd)
Total bytes of diff: 386810876 (overridden on cmd)
Total bytes of delta: -161169 (-0.04 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         314 : 414985.dasm (4.09% of base)
         314 : 473985.dasm (4.09% of base)
         314 : 493041.dasm (4.09% of base)
         314 : 504533.dasm (4.09% of base)
         212 : 236777.dasm (0.41% of base)
         212 : 232672.dasm (0.41% of base)
         208 : 460980.dasm (2.65% of base)
         167 : 5032.dasm (6.90% of base)
         127 : 580221.dasm (4.52% of base)
         116 : 576365.dasm (4.12% of base)
         113 : 580821.dasm (4.55% of base)
         102 : 577986.dasm (5.89% of base)
         101 : 577108.dasm (1.91% of base)
          86 : 580820.dasm (2.85% of base)
          85 : 306244.dasm (4.23% of base)
          84 : 572123.dasm (1.31% of base)
          84 : 579459.dasm (1.31% of base)
          79 : 577404.dasm (2.21% of base)
          79 : 580675.dasm (2.20% of base)
          76 : 197567.dasm (5.90% of base)

Top file improvements (bytes):
       -2401 : 284969.dasm (-12.26% of base)
       -2365 : 285625.dasm (-12.49% of base)
       -2325 : 284626.dasm (-11.89% of base)
       -2261 : 284459.dasm (-11.81% of base)
       -2197 : 284494.dasm (-11.48% of base)
       -2191 : 285687.dasm (-11.54% of base)
       -2148 : 285731.dasm (-11.34% of base)
       -2138 : 284592.dasm (-11.35% of base)
       -2127 : 285923.dasm (-10.92% of base)
       -2121 : 285656.dasm (-11.44% of base)
       -2121 : 286477.dasm (-10.95% of base)
       -2038 : 286114.dasm (-10.28% of base)
       -2024 : 285536.dasm (-10.00% of base)
       -2015 : 284559.dasm (-10.64% of base)
       -2004 : 286282.dasm (-10.50% of base)
       -2000 : 286388.dasm (-10.04% of base)
       -1969 : 286445.dasm (-10.08% of base)
       -1967 : 285255.dasm (-10.55% of base)
       -1956 : 286354.dasm (-10.02% of base)
       -1934 : 284424.dasm (-10.08% of base)

94 total files with Code Size differences (48 improved, 46 regressed), 20 unchanged.

Top method regressions (bytes):
         314 ( 4.09% of base) : 414985.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         314 ( 4.09% of base) : 473985.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         314 ( 4.09% of base) : 493041.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         314 ( 4.09% of base) : 504533.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         212 ( 0.41% of base) : 236777.dasm - Test_1000w1d.testout1:Func_0():int (FullOpts)
         212 ( 0.41% of base) : 232672.dasm - Test_1000w1d.testout1:Func_0():int (FullOpts)
         208 ( 2.65% of base) : 460980.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier1)
         167 ( 6.90% of base) : 5032.dasm - testout1:Sub_Funclet_0():int (FullOpts)
         127 ( 4.52% of base) : 580221.dasm - ILCompiler.DependencyAnalysis.NodeFactory:MethodEntrypoint(Internal.JitInterface.MethodWithToken,ubyte,ubyte,ubyte):ILCompiler.DependencyAnalysis.IMethodNode:this (Tier1)
         116 ( 4.12% of base) : 576365.dasm - ILCompiler.DependencyAnalysis.NodeFactory:MethodEntrypoint(Internal.JitInterface.MethodWithToken,ubyte,ubyte,ubyte):ILCompiler.DependencyAnalysis.IMethodNode:this (Tier1)
         113 ( 4.55% of base) : 580821.dasm - ILCompiler.DependencyAnalysis.ReadyToRunSymbolNodeFactory:GenericLookupTypeHelper(int,int,System.Object,Internal.JitInterface.GenericContext):ILCompiler.DependencyAnalysis.ISymbolNode:this (Tier1)
         102 ( 5.89% of base) : 577986.dasm - ILCompiler.DependencyAnalysis.ReadyToRunSymbolNodeFactory:GenericLookupTypeHelper(int,int,System.Object,Internal.JitInterface.GenericContext):ILCompiler.DependencyAnalysis.ISymbolNode:this (Tier1)
         101 ( 1.91% of base) : 577108.dasm - Internal.IL.Stubs.PInvokeILEmitter:EmitIL():Internal.IL.MethodIL:this (Tier1)
          86 ( 2.85% of base) : 580820.dasm - ILCompiler.DependencyAnalysis.ReadyToRunSymbolNodeFactory:GenericLookupHelper(int,int,System.Object,Internal.JitInterface.GenericContext):ILCompiler.DependencyAnalysis.ISymbolNode:this (Tier1)
          85 ( 4.23% of base) : 306244.dasm - System.Text.Unicode.Utf8Utility:TranscodeToUtf8(ulong,int,ulong,int,byref,byref):int (FullOpts)
          84 ( 1.31% of base) : 572123.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:Expand(System.__Canon[]):this (Tier1-OSR)
          84 ( 1.31% of base) : 579459.dasm - Internal.TypeSystem.LockFreeReaderHashtable`2[Internal.TypeSystem.TypeSystemContext+InstantiatedTypeKey,System.__Canon]:Expand(System.__Canon[]):this (Tier1-OSR)
          79 ( 2.21% of base) : 577404.dasm - System.Text.StringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):System.Text.StringBuilder:this (Tier1)
          79 ( 2.20% of base) : 580675.dasm - System.Text.StringBuilder:AppendFormatHelper(System.IFormatProvider,System.String,System.ReadOnlySpan`1[System.Object]):System.Text.StringBuilder:this (Tier1)
          76 ( 5.90% of base) : 197567.dasm - Packet256Tracer:CreateDefaultScene():Scene (FullOpts)

Top method improvements (bytes):
       -2401 (-12.26% of base) : 284969.dasm - Generated918:CalliTest() (FullOpts)
       -2365 (-12.49% of base) : 285625.dasm - Generated937:CalliTest() (FullOpts)
       -2325 (-11.89% of base) : 284626.dasm - Generated908:CalliTest() (FullOpts)
       -2261 (-11.81% of base) : 284459.dasm - Generated903:CalliTest() (FullOpts)
       -2197 (-11.48% of base) : 284494.dasm - Generated904:CalliTest() (FullOpts)
       -2191 (-11.54% of base) : 285687.dasm - Generated939:CalliTest() (FullOpts)
       -2148 (-11.34% of base) : 285731.dasm - Generated940:CalliTest() (FullOpts)
       -2138 (-11.35% of base) : 284592.dasm - Generated907:CalliTest() (FullOpts)
       -2127 (-10.92% of base) : 285923.dasm - Generated946:CalliTest() (FullOpts)
       -2121 (-11.44% of base) : 285656.dasm - Generated938:CalliTest() (FullOpts)
       -2121 (-10.95% of base) : 286477.dasm - Generated963:CalliTest() (FullOpts)
       -2038 (-10.28% of base) : 286114.dasm - Generated952:CalliTest() (FullOpts)
       -2024 (-10.00% of base) : 285536.dasm - Generated934:CalliTest() (FullOpts)
       -2015 (-10.64% of base) : 284559.dasm - Generated906:CalliTest() (FullOpts)
       -2004 (-10.50% of base) : 286282.dasm - Generated957:CalliTest() (FullOpts)
       -2000 (-10.04% of base) : 286388.dasm - Generated960:CalliTest() (FullOpts)
       -1969 (-10.08% of base) : 286445.dasm - Generated962:CalliTest() (FullOpts)
       -1967 (-10.55% of base) : 285255.dasm - Generated926:CalliTest() (FullOpts)
       -1956 (-10.02% of base) : 286354.dasm - Generated959:CalliTest() (FullOpts)
       -1934 (-10.08% of base) : 284424.dasm - Generated902:CalliTest() (FullOpts)

Top method regressions (percentages):
          10 (27.03% of base) : 577450.dasm - System.Collections.Generic.List`1[long]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[long]:this (Tier1)
          10 (26.32% of base) : 307679.dasm - System.Reflection.Metadata.MetadataReader:get_MethodDefinitions():System.Reflection.Metadata.MethodDefinitionHandleCollection:this (FullOpts)
          10 (25.00% of base) : 576995.dasm - System.Collections.Generic.Stack`1[int]:GetEnumerator():System.Collections.Generic.Stack`1+Enumerator[int]:this (Tier1)
          48 (22.97% of base) : 473989.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          48 (22.97% of base) : 504534.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          48 (22.97% of base) : 414986.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 315891.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 463835.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 484948.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 582969.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 493046.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 334580.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 433813.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 435158.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 541689.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 510334.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 462975.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 488348.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 436382.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 475763.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)

Top method improvements (percentages):
        -251 (-49.31% of base) : 248524.dasm - S:.ctor(System.String):this (FullOpts)
          -6 (-30.00% of base) : 240150.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 195885.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -8 (-22.22% of base) : 195019.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 193441.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
          -6 (-21.43% of base) : 465465.dasm - System.Diagnostics.AsyncStreamReader:get_EOF():System.Threading.Tasks.Task:this (Tier1)
          -6 (-21.43% of base) : 313880.dasm - System.Diagnostics.ProcessStartInfo:get_Arguments():System.String:this (Tier1)
          -6 (-21.43% of base) : 434135.dasm - System.Diagnostics.ProcessStartInfo:get_Arguments():System.String:this (Tier1)
          -6 (-21.43% of base) : 463043.dasm - System.Diagnostics.ProcessStartInfo:get_Arguments():System.String:this (Tier1)
          -6 (-21.43% of base) : 552668.dasm - System.Diagnostics.ProcessStartInfo:get_Arguments():System.String:this (Tier1)
          -6 (-21.43% of base) : 583794.dasm - System.Diagnostics.ProcessStartInfo:get_Arguments():System.String:this (Tier1)
          -6 (-21.43% of base) : 538.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (FullOpts)
          -6 (-21.43% of base) : 434132.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (Tier1)
          -6 (-21.43% of base) : 463041.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (Tier1)
          -6 (-21.43% of base) : 583792.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (Tier1)
          -6 (-21.43% of base) : 313878.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (Tier1)
          -6 (-21.43% of base) : 463247.dasm - System.Diagnostics.ProcessStartInfo:get_UserName():System.String:this (Tier1)
          -6 (-21.43% of base) : 584007.dasm - System.Diagnostics.ProcessStartInfo:get_UserName():System.String:this (Tier1)
          -6 (-21.43% of base) : 584006.dasm - System.Diagnostics.ProcessStartInfo:get_WorkingDirectory():System.String:this (Tier1)
          -6 (-21.43% of base) : 463246.dasm - System.Diagnostics.ProcessStartInfo:get_WorkingDirectory():System.String:this (Tier1)

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

Total bytes of base: 45185375 (overridden on cmd)
Total bytes of diff: 45099093 (overridden on cmd)
Total bytes of delta: -86282 (-0.19 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         262 : 216106.dasm (10.00% of base)
         262 : 213967.dasm (10.00% of base)
         198 : 94684.dasm (7.41% of base)
         195 : 180261.dasm (0.76% of base)
         186 : 163758.dasm (4.15% of base)
         164 : 59903.dasm (4.31% of base)
         157 : 208343.dasm (5.10% of base)
         138 : 104202.dasm (2.33% of base)
         133 : 230455.dasm (7.45% of base)
         133 : 258912.dasm (2.91% of base)
         133 : 200235.dasm (7.45% of base)
         128 : 7341.dasm (9.47% of base)
         122 : 23350.dasm (10.90% of base)
         121 : 219723.dasm (1.08% of base)
         103 : 158614.dasm (3.13% of base)
          97 : 61241.dasm (2.10% of base)
          84 : 268625.dasm (8.24% of base)
          84 : 179897.dasm (6.46% of base)
          82 : 170322.dasm (7.90% of base)
          80 : 198891.dasm (2.74% of base)

Top file improvements (bytes):
        -494 : 97114.dasm (-1.58% of base)
        -403 : 121617.dasm (-1.49% of base)
        -403 : 58902.dasm (-1.49% of base)
        -390 : 152248.dasm (-2.30% of base)
        -348 : 17312.dasm (-6.82% of base)
        -244 : 198886.dasm (-7.06% of base)
        -176 : 93128.dasm (-5.20% of base)
        -175 : 189094.dasm (-13.52% of base)
        -175 : 234042.dasm (-13.52% of base)
        -173 : 110269.dasm (-3.89% of base)
        -168 : 59907.dasm (-3.95% of base)
        -159 : 143276.dasm (-7.64% of base)
        -159 : 83771.dasm (-7.64% of base)
        -154 : 17654.dasm (-6.31% of base)
        -151 : 155494.dasm (-2.11% of base)
        -142 : 22376.dasm (-17.64% of base)
        -142 : 155490.dasm (-3.60% of base)
        -136 : 23548.dasm (-17.19% of base)
        -133 : 193753.dasm (-6.06% of base)
        -133 : 224298.dasm (-6.06% of base)

97 total files with Code Size differences (56 improved, 41 regressed), 20 unchanged.

Top method regressions (bytes):
         262 (10.00% of base) : 216106.dasm - System.Configuration.MgmtConfigurationRecord:CopyConfigDefinitionsRecursive(System.Configuration.ConfigDefinitionUpdates,System.Configuration.XmlUtil,System.Configuration.XmlUtilWriter,ubyte,System.Configuration.LocationUpdates,System.Configuration.SectionUpdates,ubyte,System.String,int,int):ubyte:this (FullOpts)
         262 (10.00% of base) : 213967.dasm - System.Configuration.MgmtConfigurationRecord:CopyConfigDefinitionsRecursive(System.Configuration.ConfigDefinitionUpdates,System.Configuration.XmlUtil,System.Configuration.XmlUtilWriter,ubyte,System.Configuration.LocationUpdates,System.Configuration.SectionUpdates,ubyte,System.String,int,int):ubyte:this (FullOpts)
         198 ( 7.41% of base) : 94684.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedSubmissionConstructorSymbol:MakeSubmissionInitialization(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol,Microsoft.CodeAnalysis.VisualBasic.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundStatement] (FullOpts)
         195 ( 0.76% of base) : 180261.dasm - Microsoft.VisualBasic.CompilerServices.VBBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (FullOpts)
         186 ( 4.15% of base) : 163758.dasm - System.Data.DataTableReader:GetSchemaTableFromDataTable(System.Data.DataTable):System.Data.DataTable (FullOpts)
         164 ( 4.31% of base) : 59903.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:MakeSubmissionInitialization(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundStatement],Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.CSharp.CSharpCompilation) (FullOpts)
         157 ( 5.10% of base) : 208343.dasm - System.Data.OleDb.OleDbDataReader:BuildSchemaTable(System.Data.OleDb.MetaData[]):System.Data.DataTable:this (FullOpts)
         138 ( 2.33% of base) : 104202.dasm - Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.Scanner:ScanNumericLiteral(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.VisualBasicSyntaxNode]):Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.SyntaxToken:this (FullOpts)
         133 ( 7.45% of base) : 230455.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+Builder[System.__Canon]:TryModifyEntries(System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon],System.TimeSpan,System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.IncrementalGeneratorRunStep,int]],int):ubyte:this (FullOpts)
         133 ( 7.45% of base) : 200235.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+Builder[System.__Canon]:TryModifyEntries(System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon],System.TimeSpan,System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.IncrementalGeneratorRunStep,int]],int):ubyte:this (FullOpts)
         133 ( 2.91% of base) : 258912.dasm - System.Globalization.FormatProvider+Number:NumberToStringFormat(byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         128 ( 9.47% of base) : 7341.dasm - System.Text.UTF32Encoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)
         122 (10.90% of base) : 23350.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
         121 ( 1.08% of base) : 219723.dasm - System.DirectoryServices.ActiveDirectory.Utils:GetReplicaList(System.DirectoryServices.ActiveDirectory.DirectoryContext,System.String,System.String,ubyte,ubyte,ubyte):System.Collections.ArrayList (FullOpts)
         103 ( 3.13% of base) : 158614.dasm - System.Xml.Xsl.Xslt.XsltLoader:LoadOutput():this (FullOpts)
          97 ( 2.10% of base) : 61241.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<VisitArguments>g__visitArguments|232_0(Microsoft.CodeAnalysis.CSharp.BoundNode,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Conversion],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitArgumentResult],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[int],Microsoft.CodeAnalysis.BitVector,ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,ubyte):System.ValueTuple`4[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+VisitArgumentResult],ubyte,Microsoft.CodeAnalysis.CSharp.NullableWalker+ArgumentsCompletionDelegate]:this (FullOpts)
          84 ( 8.24% of base) : 268625.dasm - System.Diagnostics.SharedPerformanceCounter:CreateInstance(ulong,int,System.String,int):int:this (FullOpts)
          84 ( 6.46% of base) : 179897.dasm - System.Text.ISO2022Encoding:GetCharsCP5022xJP(ulong,int,ulong,int,System.Text.ISO2022Encoding+ISO2022Decoder):int:this (FullOpts)
          82 ( 7.90% of base) : 170322.dasm - System.Xml.XmlUTF8TextReader:ReadQualifiedName(System.Xml.PrefixHandle,System.Xml.StringHandle):this (FullOpts)
          80 ( 2.74% of base) : 198891.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetPropertyMatcherRegex_1+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)

Top method improvements (bytes):
        -494 (-1.58% of base) : 97114.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.VisualBasic.VisualBasicCommandLineArguments:this (FullOpts)
        -403 (-1.49% of base) : 121617.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments:this (FullOpts)
        -403 (-1.49% of base) : 58902.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments:this (FullOpts)
        -390 (-2.30% of base) : 152248.dasm - System.Xml.Xsl.IlGen.XmlILMethods:.cctor() (FullOpts)
        -348 (-6.82% of base) : 17312.dasm - System.Reflection.FieldAccessor:SetValue(System.Object,System.Object,int,System.Reflection.Binder,System.Globalization.CultureInfo):this (FullOpts)
        -244 (-7.06% of base) : 198886.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetSectionMatcherRegex_0+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
        -176 (-5.20% of base) : 93128.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.ConstraintsHelper:ReportIndirectConstraintConflicts(Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceTypeParameterSymbol,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeParameterDiagnosticInfo],byref) (FullOpts)
        -175 (-13.52% of base) : 189094.dasm - System.IO.Hashing.XxHashShared:Append(byref,System.ReadOnlySpan`1[ubyte]) (FullOpts)
        -175 (-13.52% of base) : 234042.dasm - System.IO.Hashing.XxHashShared:Append(byref,System.ReadOnlySpan`1[ubyte]) (FullOpts)
        -173 (-3.89% of base) : 110269.dasm - Microsoft.CodeAnalysis.VisualBasic.LocalRewriter:EnforceStaticLocalInitializationSemantics(System.Collections.Generic.KeyValuePair`2[Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField,Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField],Microsoft.CodeAnalysis.VisualBasic.BoundStatement):Microsoft.CodeAnalysis.VisualBasic.BoundStatement:this (FullOpts)
        -168 (-3.95% of base) : 59907.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:ConstructFieldLikeEventAccessorBody_Regular(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundBlock (FullOpts)
        -159 (-7.64% of base) : 143276.dasm - Microsoft.CodeAnalysis.CSharp.BinderFactory+BinderFactoryVisitor:VisitCompilationUnit(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Binder:this (FullOpts)
        -159 (-7.64% of base) : 83771.dasm - Microsoft.CodeAnalysis.CSharp.BinderFactory+BinderFactoryVisitor:VisitCompilationUnit(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax,ubyte,ubyte):Microsoft.CodeAnalysis.CSharp.Binder:this (FullOpts)
        -154 (-6.31% of base) : 17654.dasm - System.IO.Enumeration.FileSystemName:MatchPattern(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort],ubyte,ubyte):ubyte (FullOpts)
        -151 (-2.11% of base) : 155494.dasm - System.Xml.Serialization.XmlSerializationReaderILGen:WriteLiteralStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)
        -142 (-17.64% of base) : 22376.dasm - System.Globalization.Ordinal:ToUpperOrdinal(System.ReadOnlySpan`1[ushort],System.Span`1[ushort]):int (FullOpts)
        -142 (-3.60% of base) : 155490.dasm - System.Xml.Serialization.XmlSerializationReaderCodeGen:WriteLiteralStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)
        -136 (-17.19% of base) : 23548.dasm - System.Text.Unicode.Utf8:ToUtf16PreservingReplacement(System.ReadOnlySpan`1[ubyte],System.Span`1[ushort],byref,byref,ubyte,ubyte):int (FullOpts)
        -133 (-6.06% of base) : 193753.dasm - Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder:PackBlocks(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder+BasicBlockBuilder],Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder+BasicBlockBuilder,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder+RegionBuilder]):ubyte (FullOpts)
        -133 (-6.06% of base) : 224298.dasm - Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder:PackBlocks(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder+BasicBlockBuilder],Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder+BasicBlockBuilder,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder+RegionBuilder]):ubyte (FullOpts)

Top method regressions (percentages):
          10 (27.03% of base) : 157967.dasm - System.Xml.Xsl.Xslt.CompilerScopeManager`1[System.__Canon]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 199977.dasm - Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 230191.dasm - Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 230263.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 182499.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 200049.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 13858.dasm - System.Collections.Generic.HashSet`1[System.__Canon]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 13927.dasm - System.Collections.Generic.List`1[System.__Canon]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (26.32% of base) : 21427.dasm - System.Collections.Generic.List`1[ubyte]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[ubyte]:this (FullOpts)
          10 (25.64% of base) : 184505.dasm - System.Reflection.Metadata.MetadataReader:get_CustomDebugInformation():System.Reflection.Metadata.CustomDebugInformationHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184499.dasm - System.Reflection.Metadata.MetadataReader:get_Documents():System.Reflection.Metadata.DocumentHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184497.dasm - System.Reflection.Metadata.MetadataReader:get_EventDefinitions():System.Reflection.Metadata.EventDefinitionHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184496.dasm - System.Reflection.Metadata.MetadataReader:get_FieldDefinitions():System.Reflection.Metadata.FieldDefinitionHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184504.dasm - System.Reflection.Metadata.MetadataReader:get_ImportScopes():System.Reflection.Metadata.ImportScopeCollection:this (FullOpts)
          10 (25.64% of base) : 184503.dasm - System.Reflection.Metadata.MetadataReader:get_LocalConstants():System.Reflection.Metadata.LocalConstantHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184501.dasm - System.Reflection.Metadata.MetadataReader:get_LocalScopes():System.Reflection.Metadata.LocalScopeHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184502.dasm - System.Reflection.Metadata.MetadataReader:get_LocalVariables():System.Reflection.Metadata.LocalVariableHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184500.dasm - System.Reflection.Metadata.MetadataReader:get_MethodDebugInformation():System.Reflection.Metadata.MethodDebugInformationHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184495.dasm - System.Reflection.Metadata.MetadataReader:get_MethodDefinitions():System.Reflection.Metadata.MethodDefinitionHandleCollection:this (FullOpts)
          10 (25.64% of base) : 184498.dasm - System.Reflection.Metadata.MetadataReader:get_PropertyDefinitions():System.Reflection.Metadata.PropertyDefinitionHandleCollection:this (FullOpts)

Top method improvements (percentages):
         -10 (-43.48% of base) : 182250.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
          -6 (-31.58% of base) : 200510.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
          -6 (-31.58% of base) : 230730.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
          -6 (-31.58% of base) : 182636.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
        -124 (-30.92% of base) : 27383.dasm - Microsoft.FSharp.Core.LanguagePrimitives+HashCompare:check0@1028(Microsoft.FSharp.Core.LanguagePrimitives+HashCompare+GenericComparer,System.Array,System.Array,long,long,long,long,long,long,long):int (FullOpts)
          -6 (-30.00% of base) : 232847.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Builder[Microsoft.CodeAnalysis.Emit.AnonymousTypeKey,Microsoft.CodeAnalysis.Emit.AnonymousTypeValue]:get_ReadOnlyDictionary():Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[Microsoft.CodeAnalysis.Emit.AnonymousTypeKey,Microsoft.CodeAnalysis.Emit.AnonymousTypeValue]:this (FullOpts)
          -6 (-30.00% of base) : 230625.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1+Builder[System.__Canon]:get_ReadOnlySet():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:this (FullOpts)
          -6 (-30.00% of base) : 57423.dasm - Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 120419.dasm - Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 57409.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 59539.dasm - Microsoft.CodeAnalysis.CSharp.MemberSemanticModel:GetQueryClauseValue(Microsoft.CodeAnalysis.CSharp.BoundQueryClause):Microsoft.CodeAnalysis.CSharp.BoundExpression (FullOpts)
          -6 (-30.00% of base) : 80673.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 231811.dasm - Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager`21+CommonEmbeddedEvent[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:get_AnAccessor():System.__Canon:this (FullOpts)
          -6 (-30.00% of base) : 231918.dasm - Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager`21+CommonEmbeddedProperty[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:get_AnAccessor():System.__Canon:this (FullOpts)
          -6 (-30.00% of base) : 201707.dasm - Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager`21+CommonEmbeddedProperty[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:get_AnAccessor():System.__Canon:this (FullOpts)
          -6 (-30.00% of base) : 96134.dasm - Microsoft.CodeAnalysis.VisualBasic.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.VisualBasic.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 96681.dasm - Microsoft.CodeAnalysis.VisualBasic.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.VisualBasic.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 94403.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SourceNamespaceSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.VisualBasic.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 179468.dasm - Newtonsoft.Json.Utilities.CollectionWrapper`1[System.__Canon]:get_UnderlyingCollection():System.Object:this (FullOpts)
          -6 (-30.00% of base) : 260144.dasm - System.Uri:get_OriginalString():System.String:this (FullOpts)

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

Total bytes of base: 61599594 (overridden on cmd)
Total bytes of diff: 61434463 (overridden on cmd)
Total bytes of delta: -165131 (-0.27 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         688 : 207933.dasm (4.14% of base)
         515 : 300506.dasm (10.00% of base)
         357 : 201426.dasm (8.07% of base)
         342 : 183531.dasm (10.11% of base)
         342 : 203369.dasm (10.11% of base)
         319 : 101354.dasm (9.42% of base)
         318 : 96547.dasm (4.02% of base)
         284 : 61675.dasm (6.64% of base)
         277 : 201421.dasm (6.25% of base)
         259 : 96507.dasm (3.01% of base)
         223 : 62863.dasm (1.91% of base)
         195 : 211384.dasm (5.95% of base)
         180 : 62742.dasm (4.78% of base)
         179 : 230598.dasm (3.98% of base)
         147 : 111024.dasm (1.66% of base)
         141 : 248849.dasm (3.56% of base)
         137 : 199037.dasm (6.83% of base)
         137 : 158616.dasm (6.83% of base)
         136 : 63016.dasm (5.57% of base)
         131 : 162516.dasm (6.18% of base)

Top file improvements (bytes):
        -562 : 103857.dasm (-1.60% of base)
        -458 : 118907.dasm (-5.87% of base)
        -397 : 60654.dasm (-1.28% of base)
        -375 : 118893.dasm (-4.49% of base)
        -360 : 67024.dasm (-4.02% of base)
        -330 : 221114.dasm (-16.44% of base)
        -314 : 300719.dasm (-16.84% of base)
        -301 : 300718.dasm (-16.16% of base)
        -245 : 221049.dasm (-7.77% of base)
        -242 : 118651.dasm (-4.61% of base)
        -234 : 226985.dasm (-15.89% of base)
        -223 : 149393.dasm (-7.31% of base)
        -223 : 190056.dasm (-7.31% of base)
        -214 : 300562.dasm (-5.20% of base)
        -211 : 119012.dasm (-5.61% of base)
        -206 : 97444.dasm (-3.02% of base)
        -202 : 61679.dasm (-3.98% of base)
        -198 : 57853.dasm (-8.27% of base)
        -194 : 94999.dasm (-6.38% of base)
        -192 : 179828.dasm (-3.55% of base)

96 total files with Code Size differences (54 improved, 42 regressed), 20 unchanged.

Top method regressions (bytes):
         688 ( 4.14% of base) : 207933.dasm - System.Data.BinaryNode:EvalBinaryOp(int,System.Data.ExpressionNode,System.Data.ExpressionNode,System.Data.DataRow,int,int[]):System.Object:this (FullOpts)
         515 (10.00% of base) : 300506.dasm - System.Globalization.FormatProvider+Number:NumberToStringFormat(byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         357 ( 8.07% of base) : 201426.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetPropertyMatcherRegex_1+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
         342 (10.11% of base) : 183531.dasm - System.Configuration.MgmtConfigurationRecord:CopyConfigDefinitionsRecursive(System.Configuration.ConfigDefinitionUpdates,System.Configuration.XmlUtil,System.Configuration.XmlUtilWriter,ubyte,System.Configuration.LocationUpdates,System.Configuration.SectionUpdates,ubyte,System.String,int,int):ubyte:this (FullOpts)
         342 (10.11% of base) : 203369.dasm - System.Configuration.MgmtConfigurationRecord:CopyConfigDefinitionsRecursive(System.Configuration.ConfigDefinitionUpdates,System.Configuration.XmlUtil,System.Configuration.XmlUtilWriter,ubyte,System.Configuration.LocationUpdates,System.Configuration.SectionUpdates,ubyte,System.String,int,int):ubyte:this (FullOpts)
         319 ( 9.42% of base) : 101354.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedSubmissionConstructorSymbol:MakeSubmissionInitialization(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol,Microsoft.CodeAnalysis.VisualBasic.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundStatement] (FullOpts)
         318 ( 4.02% of base) : 96547.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:ReportOverloadResolutionFailureAndProduceBoundNode(Microsoft.CodeAnalysis.SyntaxNode,int,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.VisualBasic.OverloadResolution+CandidateAnalysisResult],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.Symbol],Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.VisualBasic.BoundMethodOrPropertyGroup,Microsoft.CodeAnalysis.VisualBasic.Symbol,ubyte,Microsoft.CodeAnalysis.VisualBasic.BoundTypeExpression,Microsoft.CodeAnalysis.VisualBasic.Symbol,Microsoft.CodeAnalysis.Location):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
         284 ( 6.64% of base) : 61675.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:MakeSubmissionInitialization(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundStatement],Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.CSharp.CSharpCompilation) (FullOpts)
         277 ( 6.25% of base) : 201421.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetSectionMatcherRegex_0+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
         259 ( 3.01% of base) : 96507.dasm - Microsoft.CodeAnalysis.VisualBasic.Binder:BindAwait(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode,Microsoft.CodeAnalysis.VisualBasic.BoundExpression,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag,ubyte):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
         223 ( 1.91% of base) : 62863.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitTupleDeconstructionArguments(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+DeconstructionVariable],System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):this (FullOpts)
         195 ( 5.95% of base) : 211384.dasm - System.Data.OleDb.OleDbDataReader:BuildSchemaTable(System.Data.OleDb.MetaData[]):System.Data.DataTable:this (FullOpts)
         180 ( 4.78% of base) : 62742.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:BestTypeForLambdaReturns(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[System.ValueTuple`3[Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,ubyte]],Microsoft.CodeAnalysis.CSharp.Binder,Microsoft.CodeAnalysis.CSharp.BoundNode,Microsoft.CodeAnalysis.CSharp.Conversions,byref):Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations (FullOpts)
         179 ( 3.98% of base) : 230598.dasm - System.Security.Cryptography.X509Certificates.CertificateRequest:LoadSigningRequest(System.ReadOnlySpan`1[ubyte],ubyte,System.Security.Cryptography.HashAlgorithmName,byref,int,System.Security.Cryptography.RSASignaturePadding):System.Security.Cryptography.X509Certificates.CertificateRequest (FullOpts)
         147 ( 1.66% of base) : 111024.dasm - Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.Scanner:ScanNumericLiteral(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.VisualBasicSyntaxNode]):Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.SyntaxToken:this (FullOpts)
         141 ( 3.56% of base) : 248849.dasm - ILCompiler.Diagnostics.PdbWriter:WriteCompilerVersion():this (FullOpts)
         137 ( 6.83% of base) : 199037.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+Builder[System.__Canon]:TryModifyEntries(System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon],System.TimeSpan,System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.IncrementalGeneratorRunStep,int]],int):ubyte:this (FullOpts)
         137 ( 6.83% of base) : 158616.dasm - Microsoft.CodeAnalysis.NodeStateTable`1+Builder[System.__Canon]:TryModifyEntries(System.Collections.Immutable.ImmutableArray`1[System.__Canon],System.Collections.Generic.IEqualityComparer`1[System.__Canon],System.TimeSpan,System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.IncrementalGeneratorRunStep,int]],int):ubyte:this (FullOpts)
         136 ( 5.57% of base) : 63016.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<VisitObjectElementInitializer>g__visitMemberAssignment|170_8(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator,int,Microsoft.CodeAnalysis.CSharp.Symbol,ubyte,System.Func`2[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbol]:this (FullOpts)
         131 ( 6.18% of base) : 162516.dasm - Microsoft.VisualBasic.CompilerServices.VB6File:GetArrayData(System.Array,System.Type,int,int,int):this (FullOpts)

Top method improvements (bytes):
        -562 (-1.60% of base) : 103857.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.VisualBasic.VisualBasicCommandLineArguments:this (FullOpts)
        -458 (-5.87% of base) : 118907.dasm - Microsoft.CodeAnalysis.VisualBasic.LocalRewriter:EnforceStaticLocalInitializationSemantics(System.Collections.Generic.KeyValuePair`2[Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField,Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStaticLocalBackingField],Microsoft.CodeAnalysis.VisualBasic.BoundStatement):Microsoft.CodeAnalysis.VisualBasic.BoundStatement:this (FullOpts)
        -397 (-1.28% of base) : 60654.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser:Parse(System.Collections.Generic.IEnumerable`1[System.String],System.String,System.String,System.String):Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments:this (FullOpts)
        -375 (-4.49% of base) : 118893.dasm - Microsoft.CodeAnalysis.VisualBasic.LocalRewriter:LateCallOrGet(Microsoft.CodeAnalysis.VisualBasic.BoundLateMemberAccess,Microsoft.CodeAnalysis.VisualBasic.BoundExpression,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.VisualBasic.BoundExpression],System.Collections.Immutable.ImmutableArray`1[System.String],ubyte):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
        -360 (-4.02% of base) : 67024.dasm - Microsoft.CodeAnalysis.CSharp.CSharpDeclarationComputer:ComputeDeclarations(Microsoft.CodeAnalysis.SemanticModel,Microsoft.CodeAnalysis.ISymbol,Microsoft.CodeAnalysis.SyntaxNode,System.Func`3[Microsoft.CodeAnalysis.SyntaxNode,System.Nullable`1[int],ubyte],ubyte,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.DeclarationInfo],System.Nullable`1[int],System.Threading.CancellationToken) (FullOpts)
        -330 (-16.44% of base) : 221114.dasm - System.Net.Http.HPack.HPackDecoder:DecodeInternal(System.ReadOnlySpan`1[ubyte],System.Net.Http.IHttpStreamHeadersHandler):this (FullOpts)
        -314 (-16.84% of base) : 300719.dasm - System.Numerics.BigInteger:RotateRight(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
        -301 (-16.16% of base) : 300718.dasm - System.Numerics.BigInteger:RotateLeft(System.Numerics.BigInteger,int):System.Numerics.BigInteger (FullOpts)
        -245 (-7.77% of base) : 221049.dasm - System.Net.Http.QPack.QPackDecoder:DecodeInternal(System.ReadOnlySpan`1[ubyte],System.Net.Http.IHttpStreamHeadersHandler):this (FullOpts)
        -242 (-4.61% of base) : 118651.dasm - Microsoft.CodeAnalysis.VisualBasic.LambdaRewriter:RewriteLambda(Microsoft.CodeAnalysis.VisualBasic.BoundLambda,Microsoft.CodeAnalysis.VisualBasic.Symbols.TypeSymbol,ubyte):Microsoft.CodeAnalysis.VisualBasic.BoundExpression:this (FullOpts)
        -234 (-15.89% of base) : 226985.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F0290A71FBDFD01D0AF9B5DA535748D8577BE4569B59F83B3CA0D120532932A6F__FullSRSInternalsVisibleRegex_0+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
        -223 (-7.31% of base) : 149393.dasm - Microsoft.CodeAnalysis.SyntaxNavigator:GetPreviousToken(Microsoft.CodeAnalysis.SyntaxTrivia,System.Func`2[Microsoft.CodeAnalysis.SyntaxToken,ubyte],System.Func`2[Microsoft.CodeAnalysis.SyntaxTrivia,ubyte]):Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
        -223 (-7.31% of base) : 190056.dasm - Microsoft.CodeAnalysis.SyntaxNavigator:GetPreviousToken(Microsoft.CodeAnalysis.SyntaxTrivia,System.Func`2[Microsoft.CodeAnalysis.SyntaxToken,ubyte],System.Func`2[Microsoft.CodeAnalysis.SyntaxTrivia,ubyte]):Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
        -214 (-5.20% of base) : 300562.dasm - System.Numerics.BigIntegerCalculator:MultiplyFarLength(System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (FullOpts)
        -211 (-5.61% of base) : 119012.dasm - Microsoft.CodeAnalysis.VisualBasic.LocalRewriter:VisitOnErrorStatement(Microsoft.CodeAnalysis.VisualBasic.BoundOnErrorStatement):Microsoft.CodeAnalysis.VisualBasic.BoundNode:this (FullOpts)
        -206 (-3.02% of base) : 97444.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedStringSwitchHashMethod:GetBoundMethodBody(Microsoft.CodeAnalysis.VisualBasic.TypeCompilationState,Microsoft.CodeAnalysis.VisualBasic.BindingDiagnosticBag,byref):Microsoft.CodeAnalysis.VisualBasic.BoundBlock:this (FullOpts)
        -202 (-3.98% of base) : 61679.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:ConstructFieldLikeEventAccessorBody_Regular(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundBlock (FullOpts)
        -198 (-8.27% of base) : 57853.dasm - Microsoft.CodeAnalysis.CSharp.PatternExplainer:ShortestPathToNode(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode],Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode,ubyte,byref):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode] (FullOpts)
        -194 (-6.38% of base) : 94999.dasm - System.Security.Cryptography.Pkcs.Asn1.CertificateChoiceAsn:DecodeCore(byref,System.ReadOnlyMemory`1[ubyte],byref) (FullOpts)
        -192 (-3.55% of base) : 179828.dasm - Microsoft.Build.Shared.LogMessagePacketBase:GetBuildEventArgFromId():Microsoft.Build.Framework.BuildEventArgs:this (FullOpts)

Top method regressions (percentages):
          10 (50.00% of base) : 211753.dasm - System.Data.Common.SafeNativeMethods:InterlockedExchangePointer(long,long):long (FullOpts)
          38 (43.18% of base) : 295428.dasm - System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[double]:Invoke(System.Runtime.Intrinsics.Vector256`1[double]):System.Runtime.Intrinsics.Vector256`1[double] (FullOpts)
          10 (27.78% of base) : 135310.dasm - System.Xml.Xsl.Xslt.CompilerScopeManager`1[ubyte]:GetEnumerator():System.Xml.Xsl.Xslt.CompilerScopeManager`1+NamespaceEnumerator[ubyte]:this (FullOpts)
          10 (27.03% of base) : 196967.dasm - Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[ubyte]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1+Enumerator[ubyte]:this (FullOpts)
          10 (27.03% of base) : 156534.dasm - Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[ubyte]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1+Enumerator[ubyte]:this (FullOpts)
          10 (27.03% of base) : 156714.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[ubyte]:this (FullOpts)
          10 (27.03% of base) : 197147.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[ubyte]:this (FullOpts)
          10 (27.03% of base) : 172671.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:GetEnumerator():Microsoft.CodeAnalysis.Collections.SegmentedList`1+Enumerator[ubyte]:this (FullOpts)
          10 (27.03% of base) : 29340.dasm - System.Collections.Generic.HashSet`1[ubyte]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[ubyte]:this (FullOpts)
          10 (26.32% of base) : 169119.dasm - System.Reflection.Metadata.MetadataReader:get_CustomDebugInformation():System.Reflection.Metadata.CustomDebugInformationHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169113.dasm - System.Reflection.Metadata.MetadataReader:get_Documents():System.Reflection.Metadata.DocumentHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169111.dasm - System.Reflection.Metadata.MetadataReader:get_EventDefinitions():System.Reflection.Metadata.EventDefinitionHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169110.dasm - System.Reflection.Metadata.MetadataReader:get_FieldDefinitions():System.Reflection.Metadata.FieldDefinitionHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169118.dasm - System.Reflection.Metadata.MetadataReader:get_ImportScopes():System.Reflection.Metadata.ImportScopeCollection:this (FullOpts)
          10 (26.32% of base) : 169117.dasm - System.Reflection.Metadata.MetadataReader:get_LocalConstants():System.Reflection.Metadata.LocalConstantHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169115.dasm - System.Reflection.Metadata.MetadataReader:get_LocalScopes():System.Reflection.Metadata.LocalScopeHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169116.dasm - System.Reflection.Metadata.MetadataReader:get_LocalVariables():System.Reflection.Metadata.LocalVariableHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169114.dasm - System.Reflection.Metadata.MetadataReader:get_MethodDebugInformation():System.Reflection.Metadata.MethodDebugInformationHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169109.dasm - System.Reflection.Metadata.MetadataReader:get_MethodDefinitions():System.Reflection.Metadata.MethodDefinitionHandleCollection:this (FullOpts)
          10 (26.32% of base) : 169112.dasm - System.Reflection.Metadata.MetadataReader:get_PropertyDefinitions():System.Reflection.Metadata.PropertyDefinitionHandleCollection:this (FullOpts)

Top method improvements (percentages):
         -33 (-50.00% of base) : 18828.dasm - System.Number:UInt32ToBinaryChars[ubyte](ulong,uint,int):ulong (FullOpts)
         -33 (-48.53% of base) : 18835.dasm - System.Number:UInt64ToBinaryChars[ubyte](ulong,ulong,int):ulong (FullOpts)
         -10 (-43.48% of base) : 156973.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
         -36 (-41.86% of base) : 18827.dasm - System.Number:Int32ToHexChars[ubyte](ulong,uint,int,int):ulong (FullOpts)
         -36 (-40.91% of base) : 18834.dasm - System.Number:Int64ToHexChars[ubyte](ulong,ulong,int,int):ulong (FullOpts)
         -22 (-37.93% of base) : 203774.dasm - System.Configuration.StringUtil:EqualsOrBothNullOrEmpty(System.String,System.String):ubyte (FullOpts)
         -22 (-37.93% of base) : 183947.dasm - System.Configuration.StringUtil:EqualsOrBothNullOrEmpty(System.String,System.String):ubyte (FullOpts)
         -82 (-37.44% of base) : 18848.dasm - System.Number:UInt128ToBinaryChars[ubyte](ulong,System.UInt128,int):ulong (FullOpts)
         -21 (-36.84% of base) : 290455.dasm - System.Net.Cookie:set_Path(System.String):this (FullOpts)
         -21 (-36.84% of base) : 296071.dasm - System.UriBuilder:set_Password(System.String):this (FullOpts)
         -21 (-36.84% of base) : 296070.dasm - System.UriBuilder:set_UserName(System.String):this (FullOpts)
         -21 (-36.21% of base) : 268933.dasm - System.ComponentModel.ToolboxItemFilterAttribute:.ctor(System.String):this (FullOpts)
         -21 (-33.33% of base) : 179960.dasm - Microsoft.Build.Shared.BuildEventFileInfo:.ctor(System.String):this (FullOpts)
        -128 (-32.24% of base) : 15688.dasm - Microsoft.FSharp.Core.LanguagePrimitives+HashCompare:check0@1028(Microsoft.FSharp.Core.LanguagePrimitives+HashCompare+GenericComparer,System.Array,System.Array,long,long,long,long,long,long,long):int (FullOpts)
          -6 (-31.58% of base) : 173590.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
          -6 (-31.58% of base) : 160402.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
          -6 (-31.58% of base) : 200820.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[System.__Canon]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[System.__Canon]:this (FullOpts)
          -6 (-31.58% of base) : 173662.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[ubyte]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:this (FullOpts)
          -6 (-31.58% of base) : 200892.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[ubyte]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:this (FullOpts)
          -6 (-31.58% of base) : 160474.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedList`1+ValueBuilder[ubyte]:get_ReadOnlyList():Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:this (FullOpts)

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

Total bytes of base: 285356563 (overridden on cmd)
Total bytes of diff: 284911115 (overridden on cmd)
Total bytes of delta: -445448 (-0.16 % of base)
    diff is a regression.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1843 : 63771.dasm (17.91% of base)
        1576 : 437735.dasm (7.91% of base)
        1297 : 185580.dasm (6.30% of base)
        1065 : 659421.dasm (13.00% of base)
        1043 : 630065.dasm (36.49% of base)
         963 : 650910.dasm (20.55% of base)
         895 : 660014.dasm (10.81% of base)
         844 : 84840.dasm (11.52% of base)
         798 : 641899.dasm (2.41% of base)
         697 : 649536.dasm (9.68% of base)
         636 : 66634.dasm (7.66% of base)
         617 : 237402.dasm (3.96% of base)
         598 : 53329.dasm (7.52% of base)
         590 : 643013.dasm (7.84% of base)
         569 : 503307.dasm (4.39% of base)
         516 : 490505.dasm (10.25% of base)
         502 : 660854.dasm (14.70% of base)
         479 : 94778.dasm (7.03% of base)
         436 : 94343.dasm (3.64% of base)
         408 : 130913.dasm (4.76% of base)

Top file improvements (bytes):
       -1400 : 652055.dasm (-6.27% of base)
       -1231 : 633319.dasm (-7.11% of base)
       -1063 : 634058.dasm (-9.69% of base)
       -1038 : 90624.dasm (-13.24% of base)
        -951 : 89025.dasm (-5.63% of base)
        -850 : 184112.dasm (-5.02% of base)
        -850 : 111629.dasm (-5.02% of base)
        -828 : 50975.dasm (-4.94% of base)
        -802 : 53281.dasm (-10.24% of base)
        -773 : 54818.dasm (-3.73% of base)
        -744 : 111410.dasm (-5.24% of base)
        -683 : 643227.dasm (-5.25% of base)
        -660 : 658251.dasm (-6.99% of base)
        -625 : 192904.dasm (-6.76% of base)
        -618 : 549348.dasm (-7.52% of base)
        -593 : 648272.dasm (-8.15% of base)
        -591 : 597758.dasm (-9.17% of base)
        -584 : 638745.dasm (-6.81% of base)
        -574 : 667807.dasm (-3.54% of base)
        -540 : 438345.dasm (-5.90% of base)

84 total files with Code Size differences (43 improved, 41 regressed), 20 unchanged.

Top method regressions (bytes):
        1843 (17.91% of base) : 63771.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes:<DecodeUnmanagedCallersOnlyAttribute>g__DecodeUnmanagedCallersOnlyAttributeData|72_1(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes,Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData (Tier1)
        1576 ( 7.91% of base) : 437735.dasm - XPathTests.Common.Utils:XPathNodesetTest(int,System.String,System.String,XPathTests.Common.XPathResult,System.Xml.XmlNamespaceManager,System.String) (Tier1)
        1297 ( 6.30% of base) : 185580.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:AddNonTypeMembers(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+DeclaredMembersAndInitializersBuilder,Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
        1065 (13.00% of base) : 659421.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4272_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        1043 (36.49% of base) : 630065.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex941_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         963 (20.55% of base) : 650910.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex3270_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         895 (10.81% of base) : 660014.dasm - Microsoft.Cci.MetadataWriter:AddAssemblyAttributesToTable(System.Collections.Generic.IEnumerable`1[Microsoft.Cci.ICustomAttribute],ubyte,ubyte):this (Tier1)
         844 (11.52% of base) : 84840.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol:GetTopLevelTypeByMetadataName(byref,Microsoft.CodeAnalysis.AssemblyIdentity,ubyte,ubyte,byref,Microsoft.CodeAnalysis.DiagnosticBag,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:this (Tier1)
         798 ( 2.41% of base) : 641899.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1636_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         697 ( 9.68% of base) : 649536.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:CompileMethods(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder,ubyte,Microsoft.CodeAnalysis.DiagnosticBag,System.Predicate`1[Microsoft.CodeAnalysis.Symbols.ISymbolInternal],System.Threading.CancellationToken):ubyte:this (Tier1)
         636 ( 7.66% of base) : 66634.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindCatchBlock(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundCatchBlock],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundCatchBlock:this (Tier1)
         617 ( 3.96% of base) : 237402.dasm - System.Runtime.Serialization.Formatters.Binary.ObjectWriter:Write(System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo,System.Runtime.Serialization.Formatters.Binary.NameInfo,System.Runtime.Serialization.Formatters.Binary.NameInfo):this (Tier1)
         598 ( 7.52% of base) : 53329.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol:GetTopLevelTypeByMetadataName(byref,Microsoft.CodeAnalysis.AssemblyIdentity,ubyte,ubyte,byref,Microsoft.CodeAnalysis.DiagnosticBag,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol:this (Tier1)
         590 ( 7.84% of base) : 643013.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2704_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         569 ( 4.39% of base) : 503307.dasm - System.DefaultBinder:BindToMethod(int,System.Reflection.MethodBase[],byref,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],byref):System.Reflection.MethodBase:this (Tier1)
         516 (10.25% of base) : 490505.dasm - System.Globalization.FormatProvider+Number:NumberToStringFormat(byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Tier0-FullOpts)
         502 (14.70% of base) : 660854.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex32456_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         479 ( 7.03% of base) : 94778.dasm - Microsoft.CodeAnalysis.CSharp.RefSafetyAnalysis:CheckInvocationArgMixingWithUpdatedRules(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[ubyte],System.Collections.Immutable.ImmutableArray`1[int],uint,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):ubyte:this (Tier1)
         436 ( 3.64% of base) : 94343.dasm - Microsoft.Interop.BoundGenerators:Create(System.Collections.Immutable.ImmutableArray`1[Microsoft.Interop.TypePositionInfo],Microsoft.Interop.IMarshallingGeneratorResolver,Microsoft.Interop.StubCodeContext,Microsoft.Interop.IMarshallingGenerator,byref):Microsoft.Interop.BoundGenerators (Tier1)
         408 ( 4.76% of base) : 130913.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory:CreateConstructorCallSite(Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache,Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,System.Type,Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain):Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstructorCallSite:this (Tier1)

Top method improvements (bytes):
       -1400 (-6.27% of base) : 652055.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:VisitBinaryLogicalOperatorChildren(Microsoft.CodeAnalysis.CSharp.BoundExpression):this (Tier1)
       -1231 (-7.11% of base) : 633319.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
       -1063 (-9.69% of base) : 634058.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:GetRuntimeMember(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol],byref,Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer`5[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):Microsoft.CodeAnalysis.CSharp.Symbol (Tier1)
       -1038 (-13.24% of base) : 90624.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:GetRuntimeMember(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol],byref,Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer`5[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):Microsoft.CodeAnalysis.CSharp.Symbol (Tier1)
        -951 (-5.63% of base) : 89025.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        -850 (-5.02% of base) : 184112.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        -850 (-5.02% of base) : 111629.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        -828 (-4.94% of base) : 50975.dasm - System.Reflection.Metadata.MetadataReader:InitializeTableReaders(System.Reflection.Internal.MemoryBlock,ubyte,int[],int[]):this (Tier1)
        -802 (-10.24% of base) : 53281.dasm - Microsoft.CodeAnalysis.CSharp.CSharpCompilation:GetRuntimeMember(System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol],byref,Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer`5[Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol):Microsoft.CodeAnalysis.CSharp.Symbol (Tier1)
        -773 (-3.73% of base) : 54818.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindAttributeCore(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.Symbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundAttribute:this (Tier1)
        -744 (-5.24% of base) : 111410.dasm - Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder:VisitTypeDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration:this (Tier1)
        -683 (-5.25% of base) : 643227.dasm - System.Text.RegularExpressions.Generator.RegexGenerator:EmitRegexDerivedImplementation(System.CodeDom.Compiler.IndentedTextWriter,System.Text.RegularExpressions.Generator.RegexGenerator+RegexMethod,System.String,ubyte) (Tier1)
        -660 (-6.99% of base) : 658251.dasm - Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2[Microsoft.CodeAnalysis.CSharp.NullableWalker+LocalState,System.__Canon]:VisitSwitchStatement(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement):Microsoft.CodeAnalysis.CSharp.BoundNode:this (Tier1)
        -625 (-6.76% of base) : 192904.dasm - System.Collections.Generic.ArraySortHelper`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]]:IntroSort(System.Span`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]],int,System.Comparison`1[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.Reflection.Metadata.StringHandle]]) (Tier1)
        -618 (-7.52% of base) : 549348.dasm - System.Security.Cryptography.X509Certificates.Asn1.TbsCertificateAsn:DecodeCore(byref,System.Formats.Asn1.Asn1Tag,System.ReadOnlyMemory`1[ubyte],byref) (Tier1)
        -593 (-8.15% of base) : 648272.dasm - Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer:MergeOrRemoveCandidates(System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Collections.Generic.HashSet`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],System.Predicate`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.ConversionsBase,short,byref) (Tier1)
        -591 (-9.17% of base) : 597758.dasm - System.Text.Json.Serialization.Tests.ConstructorTests+<<MultipleThreads>g__RunTestAsync|15_5>d:MoveNext():this (Tier1)
        -584 (-6.81% of base) : 638745.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:Scan(byref):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.AbstractFlowPass`2+PendingBranch[Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalState,Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass+LocalFunctionState]]:this (Tier1)
        -574 (-3.54% of base) : 667807.dasm - System.Text.RegularExpressions.Generator.RegexGenerator+<>c__DisplayClass25_0:<EmitTryMatchAtCurrentPosition>g__EmitExpressionConditional|13(System.Text.RegularExpressions.RegexNode):this (Tier1)
        -540 (-5.90% of base) : 438345.dasm - System.Xml.XPath.XPathNavigator:CompareSiblings(System.Xml.XPath.XPathNavigator,System.Xml.XPath.XPathNavigator):int (Tier1)

Top method regressions (percentages):
          38 (43.18% of base) : 415230.dasm - System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)
          38 (43.18% of base) : 421647.dasm - System.Numerics.Tensors.TensorPrimitives+SigmoidOperator`1[float]:Invoke(System.Runtime.Intrinsics.Vector256`1[float]):System.Runtime.Intrinsics.Vector256`1[float] (Tier1)
        1043 (36.49% of base) : 630065.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex941_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          27 (30.00% of base) : 321144.dasm - System.IO.Compression.ZipArchiveEntry:get_Comment():System.String:this (Tier1)
          10 (27.78% of base) : 215900.dasm - System.Collections.Generic.HashSet`1[int]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[int]:this (Instrumented Tier1)
          10 (27.78% of base) : 31145.dasm - System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (Instrumented Tier1)
          10 (27.78% of base) : 51495.dasm - System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (Tier1)
          10 (26.32% of base) : 51132.dasm - System.Reflection.Metadata.MetadataReader:get_CustomAttributes():System.Reflection.Metadata.CustomAttributeHandleCollection:this (Tier1)
          10 (25.00% of base) : 238833.dasm - System.Collections.Generic.Queue`1[int]:GetEnumerator():System.Collections.Generic.Queue`1+Enumerator[int]:this (Tier1)
          10 (25.00% of base) : 217650.dasm - System.Collections.Generic.Stack`1[int]:GetEnumerator():System.Collections.Generic.Stack`1+Enumerator[int]:this (Tier1)
          48 (22.97% of base) : 518727.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          40 (21.74% of base) : 490825.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 661631.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 284345.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 238423.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 558428.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 478686.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 217308.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 258519.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)
          43 (21.72% of base) : 597726.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (Tier1)

Top method improvements (percentages):
         -31 (-31.00% of base) : 521060.dasm - System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (Tier1)
         -38 (-30.16% of base) : 521055.dasm - System.Number:Int64ToHexChars[ushort](ulong,ulong,int,int):ulong (Tier1)
          -6 (-30.00% of base) : 672036.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Builder[System.__Canon,int]:get_ReadOnlyDictionary():Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,int]:this (Tier1)
          -6 (-30.00% of base) : 66127.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Builder[System.__Canon,int]:get_ReadOnlyDictionary():Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,int]:this (Tier1)
          -6 (-30.00% of base) : 92534.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedDictionary`2+Builder[System.__Canon,int]:get_ReadOnlyDictionary():Microsoft.CodeAnalysis.Collections.SegmentedDictionary`2[System.__Canon,int]:this (Tier1)
          -6 (-30.00% of base) : 89541.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1+Builder[System.__Canon]:get_ReadOnlySet():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:this (Tier1)
          -6 (-30.00% of base) : 50618.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1+Builder[System.__Canon]:get_ReadOnlySet():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:this (Tier1)
          -6 (-30.00% of base) : 633579.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1+Builder[System.__Canon]:get_ReadOnlySet():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:this (Tier1)
          -6 (-30.00% of base) : 111378.dasm - Microsoft.CodeAnalysis.Collections.ImmutableSegmentedHashSet`1+Builder[System.__Canon]:get_ReadOnlySet():Microsoft.CodeAnalysis.Collections.SegmentedHashSet`1[System.__Canon]:this (Tier1)
          -6 (-30.00% of base) : 91361.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
          -6 (-30.00% of base) : 66444.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
          -6 (-30.00% of base) : 638228.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (Tier1)
          -6 (-30.00% of base) : 122678.dasm - System.Linq.Expressions.Compiler.CompilerScope:get_NearestHoistedLocals():System.Linq.Expressions.Compiler.HoistedLocals:this (Tier1)
          -6 (-30.00% of base) : 435780.dasm - System.Linq.Expressions.Compiler.CompilerScope:get_NearestHoistedLocals():System.Linq.Expressions.Compiler.HoistedLocals:this (Tier1)
          -6 (-30.00% of base) : 598629.dasm - System.Uri:get_OriginalString():System.String:this (Tier1)
          -6 (-30.00% of base) : 542082.dasm - System.Uri:get_OriginalString():System.String:this (Tier1)
          -6 (-30.00% of base) : 398923.dasm - System.Uri:get_OriginalString():System.String:this (Tier1)
          -6 (-30.00% of base) : 406121.dasm - System.Uri:get_OriginalString():System.String:this (Tier1)
          -6 (-30.00% of base) : 439990.dasm - System.Uri:get_OriginalString():System.String:this (Tier1)
          -6 (-30.00% of base) : 614886.dasm - System.Uri:get_OriginalString():System.String:this (Tier1)

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

Total bytes of base: 136812053 (overridden on cmd)
Total bytes of diff: 136343027 (overridden on cmd)
Total bytes of delta: -469026 (-0.34 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
        1082 : 298977.dasm (39.68% of base)
        1059 : 293717.dasm (3.62% of base)
        1054 : 303599.dasm (28.82% of base)
         984 : 310959.dasm (9.39% of base)
         828 : 297797.dasm (11.84% of base)
         701 : 116993.dasm (1.07% of base)
         671 : 111076.dasm (1.00% of base)
         637 : 66836.dasm (2.70% of base)
         637 : 67258.dasm (2.67% of base)
         547 : 306257.dasm (8.75% of base)
         541 : 300548.dasm (17.46% of base)
         515 : 204038.dasm (10.00% of base)
         465 : 306249.dasm (11.78% of base)
         449 : 297787.dasm (7.51% of base)
         420 : 7849.dasm (10.27% of base)
         342 : 92814.dasm (10.31% of base)
         330 : 308557.dasm (6.19% of base)
         329 : 7859.dasm (8.13% of base)
         259 : 297763.dasm (5.26% of base)
         256 : 289020.dasm (5.08% of base)

Top file improvements (bytes):
       -1047 : 252220.dasm (-2.96% of base)
       -1047 : 250990.dasm (-2.96% of base)
       -1047 : 264939.dasm (-2.96% of base)
       -1047 : 259504.dasm (-2.96% of base)
       -1047 : 264475.dasm (-2.96% of base)
       -1047 : 265793.dasm (-2.96% of base)
       -1047 : 265179.dasm (-2.98% of base)
       -1047 : 260071.dasm (-2.96% of base)
       -1047 : 255260.dasm (-2.96% of base)
       -1047 : 259284.dasm (-2.96% of base)
       -1047 : 265937.dasm (-2.98% of base)
       -1047 : 265815.dasm (-2.96% of base)
       -1047 : 249439.dasm (-2.96% of base)
        -727 : 270890.dasm (-6.89% of base)
        -521 : 298657.dasm (-2.45% of base)
        -464 : 114429.dasm (-4.58% of base)
        -436 : 112178.dasm (-4.21% of base)
        -432 : 299052.dasm (-4.20% of base)
        -422 : 201739.dasm (-6.08% of base)
        -422 : 221690.dasm (-6.08% of base)

94 total files with Code Size differences (56 improved, 38 regressed), 20 unchanged.

Top method regressions (bytes):
        1082 (39.68% of base) : 298977.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5194_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        1059 ( 3.62% of base) : 293717.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4798_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        1054 (28.82% of base) : 303599.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex31758_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         984 ( 9.39% of base) : 310959.dasm - System.Threading.Tasks.Dataflow.Tests.DebugAttributeTests:TestDebuggerDisplaysAndTypeProxies():this (FullOpts)
         828 (11.84% of base) : 297797.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4860_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         701 ( 1.07% of base) : 116993.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.statements.freach.freach001.freach001.Test:MainMethod():int (FullOpts)
         671 ( 1.00% of base) : 111076.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.statements.freach.freach007.freach007.Test:MainMethod():int (FullOpts)
         637 ( 2.67% of base) : 67258.dasm - System.CodeDom.Compiler.Tests.CSharpCodeGenerationTests:ProviderSupports():this (FullOpts)
         637 ( 2.70% of base) : 66836.dasm - System.CodeDom.Compiler.Tests.VBCodeGenerationTests:ProviderSupports():this (FullOpts)
         547 ( 8.75% of base) : 306257.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex32900_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         541 (17.46% of base) : 300548.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex31651_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         515 (10.00% of base) : 204038.dasm - System.Globalization.FormatProvider+Number:NumberToStringFormat(byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         465 (11.78% of base) : 306249.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex32894_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         449 ( 7.51% of base) : 297787.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4858_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         420 (10.27% of base) : 7849.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetSectionMatcherRegex_0+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
         342 (10.31% of base) : 92814.dasm - System.Configuration.MgmtConfigurationRecord:CopyConfigDefinitionsRecursive(System.Configuration.ConfigDefinitionUpdates,System.Configuration.XmlUtil,System.Configuration.XmlUtilWriter,ubyte,System.Configuration.LocationUpdates,System.Configuration.SectionUpdates,ubyte,System.String,int,int):ubyte:this (FullOpts)
         330 ( 6.19% of base) : 308557.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>FE11ED309466AF57DE9D7AB55C09A60EE21567522F71D3843DB41A5B03BB97697__Match_InstanceMethods_DefaultTimeout_SourceGenerated_ThrowsImpl_0+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
         329 ( 8.13% of base) : 7859.dasm - System.Text.RegularExpressions.Generated.<RegexGenerator_g>F447D24802EE9EBA703B0F892936D2E7874E330AA8392ACC18BB3A9BCD48147D3__GetPropertyMatcherRegex_1+RunnerFactory+Runner:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (FullOpts)
         259 ( 5.26% of base) : 297763.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4857_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         256 ( 5.08% of base) : 289020.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex626_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method improvements (bytes):
       -1047 (-2.96% of base) : 265815.dasm - System.Text.Json.SourceGeneration.Tests.CollectionTests_Default+CollectionTestsContext_Default:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 255260.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Default+ConstructorTestsContext_Default:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 259284.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Metadata+ConstructorTestsContext_Metadata:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 259504.dasm - System.Text.Json.SourceGeneration.Tests.ExtensionDataTests_Default+ExtensionDataTestsContext_Default:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 250990.dasm - System.Text.Json.SourceGeneration.Tests.ExtensionDataTests_Metadata+ExtensionDataTestsContext_Metadata:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 249439.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 252220.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Metadata+PropertyNameTestsContext_Metadata:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 264475.dasm - System.Text.Json.SourceGeneration.Tests.PropertyVisibilityTests_Default+PropertyVisibilityTestsContext_Default:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 260071.dasm - System.Text.Json.SourceGeneration.Tests.PropertyVisibilityTests_Metadata+PropertyVisibilityTestsContext_Metadata:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 265793.dasm - System.Text.Json.SourceGeneration.Tests.ReferenceHandlerTests_Default+ReferenceHandlerTestsContext_Default:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.98% of base) : 265937.dasm - System.Text.Json.SourceGeneration.Tests.ReferenceHandlerTests_Default+ReferenceHandlerTestsContext_Default:SimpleTestClassWithFieldsPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.96% of base) : 264939.dasm - System.Text.Json.SourceGeneration.Tests.ReferenceHandlerTests_Metadata+ReferenceHandlerTestsContext_Metadata:SimpleTestClassPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
       -1047 (-2.98% of base) : 265179.dasm - System.Text.Json.SourceGeneration.Tests.ReferenceHandlerTests_Metadata+ReferenceHandlerTestsContext_Metadata:SimpleTestClassWithFieldsPropInit(System.Text.Json.JsonSerializerOptions):System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] (FullOpts)
        -727 (-6.89% of base) : 270890.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:WriteHelloWorldEscaped(System.Text.Json.JsonWriterOptions):this (FullOpts)
        -521 (-2.45% of base) : 298657.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5070_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -464 (-4.58% of base) : 114429.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.context.operate.compound.basic.indexer01.indexer01.Test:MainMethod(System.String[]):int (FullOpts)
        -436 (-4.21% of base) : 112178.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.context.operate.compound.basic.indexer02.indexer02.Test:MainMethod(System.String[]):int (FullOpts)
        -432 (-4.20% of base) : 299052.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5256_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -422 (-6.08% of base) : 201739.dasm - System.Tests.StringTests:TrimWhiteSpaceMultipleTimes_Memory() (FullOpts)
        -422 (-6.08% of base) : 221690.dasm - System.Tests.StringTests:TrimWhiteSpaceMultipleTimes_Memory() (FullOpts)

Top method regressions (percentages):
        1082 (39.68% of base) : 298977.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5194_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        1054 (28.82% of base) : 303599.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex31758_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          38 (20.11% of base) : 204039.dasm - System.Globalization.FormatProvider+Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
           6 (20.00% of base) : 54604.dasm - System.Diagnostics.Activity:get_TraceStateString():System.String:this (FullOpts)
           7 (18.92% of base) : 135255.dasm - System.IO.Pipelines.Tests.DisposeTrackingBufferPool+DisposeTrackingMemoryManager:get_Memory():System.Memory`1[ubyte]:this (FullOpts)
         541 (17.46% of base) : 300548.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex31651_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          10 (16.13% of base) : 38749.dasm - FluentAssertions.Primitives.StringAssertions`1[System.__Canon]:Contains(System.String,System.String,int):ubyte (FullOpts)
          22 (14.86% of base) : 308640.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
          22 (14.86% of base) : 254.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
          22 (14.86% of base) : 282192.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
           3 (14.29% of base) : 37485.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteValidator:VisitRootCache(Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteValidator+CallSiteValidatorState):System.Type:this (FullOpts)
          10 (13.89% of base) : 48184.dasm - System.Reflection.Metadata.BlobBuilder:GetBlobs():System.Reflection.Metadata.BlobBuilder+Blobs:this (FullOpts)
          10 (13.89% of base) : 47231.dasm - System.Reflection.Metadata.BlobBuilder:GetChunks():System.Reflection.Metadata.BlobBuilder+Chunks:this (FullOpts)
           7 (13.46% of base) : 16940.dasm - System.IO.Tests.StreamConformanceTests+NativeMemoryManager:get_Memory():System.Memory`1[ubyte]:this (FullOpts)
           7 (12.73% of base) : 314513.dasm - System.Runtime.CompilerServices.Tests.ConfiguredAsyncDisposableTests+TrackingAsyncDisposable:DisposeAsync():System.Threading.Tasks.ValueTask:this (FullOpts)
           7 (12.73% of base) : 24563.dasm - System.Runtime.CompilerServices.Tests.ConfiguredAsyncDisposableTests+TrackingAsyncDisposable:DisposeAsync():System.Threading.Tasks.ValueTask:this (FullOpts)
          12 (12.37% of base) : 92152.dasm - System.Configuration.XmlUtilWriter:AppendWhiteSpace(int,int,int,int):int:this (FullOpts)
           8 (12.31% of base) : 58366.dasm - Microsoft.Extensions.Primitives.StringValuesTests+<>c__DisplayClass16_0:<DefaultNullOrEmpty_ExpectedValues>b__1():System.Object:this (FullOpts)
           7 (12.28% of base) : 314745.dasm - System.Runtime.CompilerServices.Tests.ConfiguredCancelableAsyncEnumerableTests+TrackFlagsAsyncEnumerable+Enumerator:MoveNextAsync():System.Threading.Tasks.ValueTask`1[ubyte]:this (FullOpts)
           7 (12.28% of base) : 24558.dasm - System.Runtime.CompilerServices.Tests.ConfiguredCancelableAsyncEnumerableTests+TrackFlagsAsyncEnumerable+Enumerator:MoveNextAsync():System.Threading.Tasks.ValueTask`1[ubyte]:this (FullOpts)

Top method improvements (percentages):
         -10 (-43.48% of base) : 14693.dasm - Microsoft.CodeAnalysis.Collections.Internal.SegmentedArrayHelper:CalculateSegmentShift(int):int (FullOpts)
         -21 (-34.43% of base) : 160144.dasm - System.Collections.Specialized.NameObjectCollectionBase:.ctor(System.Collections.IEqualityComparer):this (FullOpts)
          -6 (-30.00% of base) : 282526.dasm - Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement:Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction.get_Body():Microsoft.CodeAnalysis.CSharp.BoundBlock:this (FullOpts)
          -6 (-30.00% of base) : 14106.dasm - Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 50978.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 6896.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 45162.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 10413.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 83126.dasm - System.ComponentModel.Composition.ReflectionModel.ReflectionProperty:get_UnderlyingMember():System.Reflection.MemberInfo:this (FullOpts)
          -6 (-30.00% of base) : 82032.dasm - System.ComponentModel.DataAnnotations.ValidationAttribute:get_ErrorMessage():System.String:this (FullOpts)
          -6 (-30.00% of base) : 172793.dasm - System.Uri:get_OriginalString():System.String:this (FullOpts)
          -6 (-26.09% of base) : 101685.dasm - System.Diagnostics.Activity:get_DisplayName():System.String:this (FullOpts)
         -99 (-25.92% of base) : 222644.dasm - System.Number:TryUInt128ToBinaryStr[ushort](System.Int128,int,System.Span`1[ushort],byref):ubyte (FullOpts)
         -16 (-24.24% of base) : 83545.dasm - System.ComponentModel.Composition.ExportMetadataAttribute:.ctor(System.String,System.Object):this (FullOpts)
         -16 (-24.24% of base) : 83929.dasm - System.ComponentModel.Composition.PartMetadataAttribute:.ctor(System.String,System.Object):this (FullOpts)
         -16 (-24.24% of base) : 91482.dasm - System.Composition.ExportMetadataAttribute:.ctor(System.String,System.Object):this (FullOpts)
          -8 (-22.86% of base) : 54378.dasm - Microsoft.Extensions.Logging.EventId:ToString():System.String:this (FullOpts)
         -84 (-22.58% of base) : 222601.dasm - System.Number:UInt128ToBinaryStr(System.Int128,int):System.String (FullOpts)
          -8 (-22.22% of base) : 45987.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_CallingConvention():int:this (FullOpts)
          -6 (-22.22% of base) : 84514.dasm - System.ComponentModel.Composition.CompositionResult:get_Errors():System.Collections.Generic.IEnumerable`1[System.ComponentModel.Composition.CompositionError]:this (FullOpts)

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

Total bytes of base: 14015797 (overridden on cmd)
Total bytes of diff: 13979936 (overridden on cmd)
Total bytes of delta: -35861 (-0.26 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         562 : 29385.dasm (15.04% of base)
         440 : 29383.dasm (11.47% of base)
         400 : 10650.dasm (4.50% of base)
         223 : 8836.dasm (1.86% of base)
         191 : 28018.dasm (1.67% of base)
         165 : 15188.dasm (2.24% of base)
         132 : 28156.dasm (5.52% of base)
         126 : 1324.dasm (1.06% of base)
         126 : 15135.dasm (7.04% of base)
         122 : 1015.dasm (2.46% of base)
         121 : 17284.dasm (3.58% of base)
         107 : 31198.dasm (2.11% of base)
         104 : 10802.dasm (2.23% of base)
          92 : 23986.dasm (3.00% of base)
          83 : 26723.dasm (1.67% of base)
          80 : 13257.dasm (2.02% of base)
          78 : 1076.dasm (0.60% of base)
          75 : 29429.dasm (3.97% of base)
          75 : 25637.dasm (2.64% of base)
          72 : 29431.dasm (2.19% of base)

Top file improvements (bytes):
        -464 : 1058.dasm (-2.93% of base)
        -402 : 29441.dasm (-12.83% of base)
        -353 : 15817.dasm (-6.90% of base)
        -333 : 33583.dasm (-5.24% of base)
        -254 : 15413.dasm (-4.91% of base)
        -240 : 29432.dasm (-8.11% of base)
        -235 : 15771.dasm (-3.35% of base)
        -216 : 34936.dasm (-3.62% of base)
        -210 : 1174.dasm (-16.68% of base)
        -187 : 1017.dasm (-1.88% of base)
        -178 : 7944.dasm (-1.84% of base)
        -173 : 31233.dasm (-3.59% of base)
        -166 : 7659.dasm (-1.15% of base)
        -166 : 5353.dasm (-4.17% of base)
        -164 : 1193.dasm (-12.22% of base)
        -162 : 1149.dasm (-14.61% of base)
        -158 : 10589.dasm (-8.97% of base)
        -147 : 27941.dasm (-2.53% of base)
        -143 : 1222.dasm (-6.47% of base)
        -140 : 12449.dasm (-5.21% of base)

90 total files with Code Size differences (50 improved, 40 regressed), 20 unchanged.

Top method regressions (bytes):
         562 (15.04% of base) : 29385.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         440 (11.47% of base) : 29383.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
         400 ( 4.50% of base) : 10650.dasm - FSharp.Compiler.CheckExpressions:TcForEachExpr(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.ConstraintSolver+OverallTy,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.Syntax.SynPat,FSharp.Compiler.Syntax.SynExpr,FSharp.Compiler.Syntax.SynExpr,FSharp.Compiler.Text.Range,FSharp.Compiler.Syntax.DebugPointAtFor,FSharp.Compiler.Syntax.DebugPointAtInOrTo):System.Tuple`2[FSharp.Compiler.TypedTree+Expr,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
         223 ( 1.86% of base) : 8836.dasm - FSharp.Compiler.ConstraintSolver:SolveTypeSubsumesType(FSharp.Compiler.ConstraintSolver+ConstraintSolverEnv,int,FSharp.Compiler.Text.Range,FSharp.Compiler.ConstraintSolver+OptionalTrace,Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[FSharp.Compiler.TypedTree+TraitConstraintInfo,FSharp.Compiler.TypedTree+TraitConstraintSln]],FSharp.Compiler.TypedTree+TType,FSharp.Compiler.TypedTree+TType):FSharp.Compiler.ErrorLogger+OperationResult`1[Microsoft.FSharp.Core.Unit] (FullOpts)
         191 ( 1.67% of base) : 28018.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitTupleDeconstructionArguments(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.NullableWalker+DeconstructionVariable],System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholder,Microsoft.CodeAnalysis.CSharp.BoundExpression]],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.Nullable`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):this (FullOpts)
         165 ( 2.24% of base) : 15188.dasm - SixLabors.ImageSharp.Advanced.ParallelRowIterator:IterateRows[SixLabors.ImageSharp.Processing.Processors.Convolution.Convolution2PassProcessor`1+HorizontalConvolutionRowOperation[SixLabors.ImageSharp.PixelFormats.Rgba32],System.Numerics.Vector4](SixLabors.ImageSharp.Rectangle,byref,byref) (FullOpts)
         132 ( 5.52% of base) : 28156.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<VisitObjectElementInitializer>g__visitMemberAssignment|170_8(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator,int,Microsoft.CodeAnalysis.CSharp.Symbol,ubyte,System.Func`2[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState]):System.Action`2[int,Microsoft.CodeAnalysis.CSharp.Symbol]:this (FullOpts)
         126 ( 1.06% of base) : 1324.dasm - DemoBenchmarks.RagdollTubeBenchmark:AddArm(float,System.Numerics.Vector3,BepuPhysics.RigidPose,BepuPhysics.BodyHandle,byref,int,int,BepuPhysics.RigidPose,BepuPhysics.CollidableProperty`1[DemoBenchmarks.RagdollTubeBenchmark+SubgroupCollisionFilter],BepuPhysics.Constraints.SpringSettings,BepuPhysics.Simulation):DemoBenchmarks.RagdollTubeBenchmark+RagdollArmHandles (FullOpts)
         126 ( 7.04% of base) : 15135.dasm - SixLabors.ImageSharp.Compression.Zlib.DeflaterEngine:FindLongestMatch(int):ubyte:this (FullOpts)
         122 ( 2.46% of base) : 1015.dasm - BepuPhysics.CollisionDetection.SweepTasks.CapsuleBoxDistanceTester:Test(byref,byref,byref,byref,byref,byref,byref,byref,byref,byref):this (FullOpts)
         121 ( 3.58% of base) : 17284.dasm - Microsoft.ML.Internal.Utilities.VBufferUtils:ApplyInto[float,float,float](byref,byref,byref,System.Func`4[int,float,float,float]) (FullOpts)
         107 ( 2.11% of base) : 31198.dasm - Microsoft.CodeAnalysis.CSharp.LocalRewriter+SwitchExpressionLocalRewriter:LowerSwitchExpression(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
         104 ( 2.23% of base) : 10802.dasm - FSharp.Compiler.CheckDeclarations:k@828-10(FSharp.Compiler.TypedTree+CcuThunk,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+ModuleOrNamespaceType],ubyte,FSharp.Compiler.TcGlobals+TcGlobals,FSharp.Compiler.CheckExpressions+TcEnv,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,ubyte],Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.Syntax.ScopedPragma],FSharp.Compiler.Syntax.QualifiedNameOfFile,ubyte,System.Tuple`2[ubyte,ubyte],FSharp.Compiler.InfoReader+InfoReader,FSharp.Compiler.CheckExpressions+TcFileState,Microsoft.FSharp.Core.FSharpRef`1[FSharp.Compiler.TypedTree+ModuleOrNamespaceType],FSharp.Compiler.TypedTree+ModuleOrNamespaceExpr,Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[int,FSharp.Compiler.TypedTree+Attrib]],FSharp.Compiler.CheckExpressions+TcEnv):System.Tuple`5[FSharp.Compiler.CheckDeclarations+TopAttribs,FSharp.Compiler.TypedTree+TypedImplFile,FSharp.Compiler.TypedTree+ModuleOrNamespaceType,FSharp.Compiler.CheckExpressions+TcEnv,ubyte] (FullOpts)
          92 ( 3.00% of base) : 23986.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindArrayType(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations:this (FullOpts)
          83 ( 1.67% of base) : 26723.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindCatchBlock(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundCatchBlock],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundCatchBlock:this (FullOpts)
          80 ( 2.02% of base) : 13257.dasm - FSharp.Compiler.CheckExpressions:TcImplicitOpItemThen(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.ConstraintSolver+OverallTy,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.Syntax.Ident,Microsoft.FSharp.Core.FSharpRef`1[Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+TraitConstraintSln]],FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.Text.Range,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CheckExpressions+DelayedItem]):System.Tuple`2[FSharp.Compiler.TypedTree+Expr,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
          78 ( 0.60% of base) : 1076.dasm - BepuPhysics.CollisionDetection.CollisionTasks.CylinderPairTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
          75 ( 2.64% of base) : 25637.dasm - Microsoft.CodeAnalysis.CSharp.MethodCompiler:CompileNamedType(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol):this (FullOpts)
          75 ( 3.97% of base) : 29429.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex4_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          72 ( 2.19% of base) : 29431.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex5_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)

Top method improvements (bytes):
        -464 (-2.93% of base) : 1058.dasm - BepuPhysics.CollisionDetection.CollisionTasks.BoxCylinderTester:Test(byref,byref,byref,byref,byref,byref,int,byref):this (FullOpts)
        -402 (-12.83% of base) : 29441.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex13_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -353 (-6.90% of base) : 15817.dasm - SixLabors.ImageSharp.Formats.Jpeg.Components.Decoder.HuffmanScanDecoder:ParseProgressiveDataNonInterleaved():this (FullOpts)
        -333 (-5.24% of base) : 33583.dasm - System.DateTimeFormat:FormatCustomized[ushort](System.DateTime,System.ReadOnlySpan`1[ushort],System.Globalization.DateTimeFormatInfo,System.TimeSpan,byref) (FullOpts)
        -254 (-4.91% of base) : 15413.dasm - SixLabors.ImageSharp.Formats.Jpeg.Components.Decoder.SpectralConverter`1[SixLabors.ImageSharp.PixelFormats.Rgb24]:ConvertStride(int):this (FullOpts)
        -240 (-8.11% of base) : 29432.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex6_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
        -235 (-3.35% of base) : 15771.dasm - SixLabors.ImageSharp.Processing.Processors.Convolution.ConvolutionProcessor`1+RowOperation[SixLabors.ImageSharp.PixelFormats.Rgba32]:Invoke(int,System.Span`1[System.Numerics.Vector4]):this (FullOpts)
        -216 (-3.62% of base) : 34936.dasm - System.Reflection.FieldAccessor:SetValue(System.Object,System.Object,int,System.Reflection.Binder,System.Globalization.CultureInfo):this (FullOpts)
        -210 (-16.68% of base) : 1174.dasm - DemoBenchmarks.TwoBodyConstraintBenchmarks:Contact4Nonconvex():System.ValueTuple`2[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
        -187 (-1.88% of base) : 1017.dasm - BepuPhysics.CollisionDetection.SweepTasks.GJKDistanceTester`6[BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder,BepuPhysics.Collidables.Box,BepuPhysics.Collidables.BoxWide,BepuPhysics.Collidables.BoxSupportFinder]:FindClosestPoint(byref,byref,byref,byref,byref) (FullOpts)
        -178 (-1.84% of base) : 7944.dasm - FSharp.Compiler.CheckExpressions:TcNormalizedBinding(FSharp.Compiler.CheckExpressions+DeclKind,FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,FSharp.Compiler.TypedTree+TType,Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+Val],FSharp.Compiler.CheckExpressions+SafeInitData,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.TypedTree+Typar],FSharp.Compiler.CheckExpressions+ExplicitTyparInfo,FSharp.Compiler.CheckExpressions+NormalizedBinding):System.Tuple`2[FSharp.Compiler.CheckExpressions+CheckedBindingInfo,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv] (FullOpts)
        -173 (-3.59% of base) : 31233.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:ConstructFieldLikeEventAccessorBody_Regular(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundBlock (FullOpts)
        -166 (-4.17% of base) : 5353.dasm - FSharp.Compiler.AbstractIL.IL+ILInstr:GetHashCode(System.Collections.IEqualityComparer):int:this (FullOpts)
        -166 (-1.15% of base) : 7659.dasm - FSharp.Compiler.CheckDeclarations+EstablishTypeDefinitionCores:TcTyconDefnCore_Phase1G_EstablishRepresentation(FSharp.Compiler.CheckExpressions+TcFileState,FSharp.Compiler.CheckExpressions+TcEnv,FSharp.Compiler.CheckExpressions+UnscopedTyparEnv,ubyte,FSharp.Compiler.CheckDeclarations+MutRecDefnsPhase1DataForTycon,FSharp.Compiler.TypedTree+Entity,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.TypedTree+Attrib]):System.Tuple`2[Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.TypedTree+Val],FSharp.Compiler.CheckExpressions+SafeInitData] (FullOpts)
        -164 (-12.22% of base) : 1193.dasm - DemoBenchmarks.FourBodyConstraintBenchmarks:VolumeConstraint():System.ValueTuple`4[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
        -162 (-14.61% of base) : 1149.dasm - DemoBenchmarks.ThreeBodyConstraintBenchmarks:AreaConstraint():System.ValueTuple`3[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
        -158 (-8.97% of base) : 10589.dasm - FSharp.Compiler.CheckExpressions+ExpandIndexArgs@6558-1:Invoke(int,FSharp.Compiler.Syntax.SynExpr):Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.Syntax.SynExpr]:this (FullOpts)
        -147 (-2.53% of base) : 27941.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitArrayInitialization(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol,Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization,ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
        -143 (-6.47% of base) : 1222.dasm - BepuPhysics.Simulation:Create[DemoBenchmarks.RagdollTubeBenchmark+SubgroupFilteredCallbacks,DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks](BepuUtilities.Memory.BufferPool,DemoBenchmarks.RagdollTubeBenchmark+SubgroupFilteredCallbacks,DemoBenchmarks.RagdollTubeBenchmark+DemoPoseIntegratorCallbacks,BepuPhysics.SolveDescription,BepuPhysics.ITimestepper,System.Nullable`1[BepuPhysics.SimulationAllocationSizes]):BepuPhysics.Simulation (FullOpts)
        -140 (-5.21% of base) : 12449.dasm - System.Text.UnicodeEncoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)

Top method regressions (percentages):
          26 (24.07% of base) : 18498.dasm - System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
          38 (20.11% of base) : 814.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
         562 (15.04% of base) : 29385.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex2_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
          22 (14.86% of base) : 21571.dasm - System.Text.RegularExpressions.RegexCharClass:GetSetChars(System.String,System.Span`1[ushort]):int (FullOpts)
          10 (13.89% of base) : 32571.dasm - System.Reflection.Metadata.BlobBuilder:GetBlobs():System.Reflection.Metadata.BlobBuilder+Blobs:this (FullOpts)
          10 (13.89% of base) : 29883.dasm - System.Reflection.Metadata.BlobBuilder:GetChunks():System.Reflection.Metadata.BlobBuilder+Chunks:this (FullOpts)
           7 (12.07% of base) : 15557.dasm - SixLabors.ImageSharp.Memory.Internals.UnmanagedBuffer`1[short]:Pin(int):System.Buffers.MemoryHandle:this (FullOpts)
         440 (11.47% of base) : 29383.dasm - System.Text.RegularExpressions.CompiledRegexRunner:Regex1_TryMatchAtCurrentPosition(System.Text.RegularExpressions.RegexRunner,System.ReadOnlySpan`1[ushort]):ubyte (FullOpts)
           5 (11.11% of base) : 35878.dasm - Microsoft.ApplicationInsights.Metrics.Extensibility.MetricValuesBuffer_Double:ResetValues(double[]):this (FullOpts)
          10 ( 9.09% of base) : 17276.dasm - Microsoft.ML.Internal.Utilities.MathUtils:SoftMax(float,float):float (FullOpts)
          47 ( 7.70% of base) : 15404.dasm - SixLabors.ImageSharp.Formats.Jpeg.Components.Decoder.HuffmanTable:.ctor(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[uint]):this (FullOpts)
          26 ( 7.41% of base) : 16133.dasm - System.Collections.Generic.Dictionary`2+ValueCollection[System.__Canon,Microsoft.ML.SchemaShape+Column]:CopyTo(Microsoft.ML.SchemaShape+Column[],int):this (FullOpts)
           7 ( 7.37% of base) : 21344.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax:get_Identifier():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 27327.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax:get_Token():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 28831.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax:get_Keyword():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 20960.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax:get_Identifier():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 28189.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax:get_NewKeyword():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 27389.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax:get_OpenBraceToken():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 28798.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax:get_OperatorToken():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)
           7 ( 7.37% of base) : 27932.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.UnaryPatternSyntax:get_OperatorToken():Microsoft.CodeAnalysis.SyntaxToken:this (FullOpts)

Top method improvements (percentages):
          -6 (-30.00% of base) : 27776.dasm - Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement:Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction.get_Body():Microsoft.CodeAnalysis.CSharp.BoundBlock:this (FullOpts)
          -6 (-30.00% of base) : 25541.dasm - Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 24326.dasm - Microsoft.CodeAnalysis.CSharp.BoundTypeExpression:get_ExpressionSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -6 (-30.00% of base) : 25752.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol:get_ContainingSymbol():Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
          -8 (-22.22% of base) : 24021.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 22272.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_Parameters():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol]:this (FullOpts)
          -8 (-22.22% of base) : 35249.dasm - System.Reflection.RuntimeMethodInfo:get_CallingConvention():int:this (FullOpts)
          -8 (-22.22% of base) : 762.dasm - System.Reflection.RuntimeMethodInfo:get_ReturnType():System.Type:this (FullOpts)
          -6 (-21.43% of base) : 14615.dasm - System.Diagnostics.ProcessStartInfo:get_FileName():System.String:this (FullOpts)
          -6 (-18.75% of base) : 1897.dasm - System.Xml.XmlTextReaderImpl:get_NamespaceURI():System.String:this (FullOpts)
          -6 (-17.65% of base) : 36298.dasm - System.Management.Automation.PSModuleInfo:set_Description(System.String):this (FullOpts)
         -12 (-16.90% of base) : 17513.dasm - System.Threading.LazyInitializer:EnsureLockInitialized(byref):System.Object (FullOpts)
        -210 (-16.68% of base) : 1174.dasm - DemoBenchmarks.TwoBodyConstraintBenchmarks:Contact4Nonconvex():System.ValueTuple`2[BepuPhysics.BodyVelocityWide,BepuPhysics.BodyVelocityWide]:this (FullOpts)
          -8 (-16.67% of base) : 22507.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_RefKind():ubyte:this (FullOpts)
         -38 (-16.45% of base) : 17718.dasm - System.Number:TryInt64ToHexStr[ushort](long,ushort,int,System.Span`1[ushort],byref):ubyte (FullOpts)
          -8 (-16.33% of base) : 22271.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_RefCustomModifiers():System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CustomModifier]:this (FullOpts)
          -8 (-16.33% of base) : 25932.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_ReturnNotNullIfParameterNotNull():System.Collections.Immutable.ImmutableHashSet`1[System.String]:this (FullOpts)
          -8 (-16.33% of base) : 24095.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol:get_ReturnTypeFlowAnalysisAnnotations():int:this (FullOpts)
         -18 (-15.52% of base) : 1215.dasm - DemoBenchmarks.ConvexCollisionTesterBenchmarks:get_Triangle():BepuPhysics.Collidables.TriangleWide:this (FullOpts)
          -6 (-15.00% of base) : 26942.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker+<>c:<VisitTupleExpression>b__264_2(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol,Microsoft.CodeAnalysis.Location):Microsoft.CodeAnalysis.Location:this (FullOpts)

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

Total bytes of base: 5141276 (overridden on cmd)
Total bytes of diff: 5117376 (overridden on cmd)
Total bytes of delta: -23900 (-0.46 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         122 : 8422.dasm (10.94% of base)
         122 : 11995.dasm (10.94% of base)
          67 : 2330.dasm (13.43% of base)
          67 : 20157.dasm (13.43% of base)
          67 : 7162.dasm (13.43% of base)
          67 : 22820.dasm (13.43% of base)
          67 : 17473.dasm (13.43% of base)
          51 : 11799.dasm (5.54% of base)
          51 : 18540.dasm (3.74% of base)
          51 : 511.dasm (3.74% of base)
          51 : 21150.dasm (3.74% of base)
          51 : 15806.dasm (3.74% of base)
          50 : 3507.dasm (3.62% of base)
          49 : 12994.dasm (6.30% of base)
          49 : 7459.dasm (6.19% of base)
          46 : 11564.dasm (6.51% of base)
          38 : 19427.dasm (20.11% of base)
          38 : 1428.dasm (20.11% of base)
          38 : 16662.dasm (20.11% of base)
          38 : 22023.dasm (20.11% of base)

Top file improvements (bytes):
        -161 : 12107.dasm (-2.89% of base)
        -161 : 14999.dasm (-2.89% of base)
        -161 : 6342.dasm (-2.86% of base)
        -153 : 1751.dasm (-3.92% of base)
        -153 : 6766.dasm (-3.92% of base)
        -109 : 5191.dasm (-9.16% of base)
        -109 : 21693.dasm (-11.43% of base)
        -109 : 16312.dasm (-11.43% of base)
        -109 : 10712.dasm (-9.16% of base)
        -109 : 18980.dasm (-11.43% of base)
        -106 : 19034.dasm (-1.39% of base)
        -104 : 1129.dasm (-10.92% of base)
        -104 : 21715.dasm (-1.37% of base)
        -104 : 16432.dasm (-1.37% of base)
        -103 : 1128.dasm (-1.35% of base)
        -103 : 4550.dasm (-1.35% of base)
         -90 : 4368.dasm (-8.73% of base)
         -87 : 485.dasm (-4.12% of base)
         -87 : 15778.dasm (-4.12% of base)
         -87 : 21122.dasm (-4.12% of base)

90 total files with Code Size differences (59 improved, 31 regressed), 20 unchanged.

Top method regressions (bytes):
         122 (10.94% of base) : 8422.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
         122 (10.94% of base) : 11995.dasm - System.Number+Grisu3:TryDigitGenShortest(byref,byref,byref,System.Span`1[ubyte],byref,byref):ubyte (FullOpts)
          67 (13.43% of base) : 2330.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 20157.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 7162.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 22820.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 17473.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          51 ( 5.54% of base) : 11799.dasm - System.Linq.Expressions.Interpreter.LightCompiler:CompileIntSwitchExpression[System.__Canon](System.Linq.Expressions.SwitchExpression):this (FullOpts)
          51 ( 3.74% of base) : 18540.dasm - System.Text.UTF32Encoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)
          51 ( 3.74% of base) : 511.dasm - System.Text.UTF32Encoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)
          51 ( 3.74% of base) : 21150.dasm - System.Text.UTF32Encoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)
          51 ( 3.74% of base) : 15806.dasm - System.Text.UTF32Encoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)
          50 ( 3.62% of base) : 3507.dasm - System.Text.UTF32Encoding:GetChars(ulong,int,ulong,int,System.Text.DecoderNLS):int:this (FullOpts)
          49 ( 6.30% of base) : 12994.dasm - Internal.Runtime.TypeLoader.NativeLayoutInterfacesAlgorithm:ComputeRuntimeInterfaces(Internal.TypeSystem.TypeDesc):Internal.TypeSystem.DefType[]:this (FullOpts)
          49 ( 6.19% of base) : 7459.dasm - Internal.Runtime.TypeLoader.NativeLayoutInterfacesAlgorithm:ComputeRuntimeInterfaces(Internal.TypeSystem.TypeDesc):Internal.TypeSystem.DefType[]:this (FullOpts)
          46 ( 6.51% of base) : 11564.dasm - System.DefaultBinder:BindToField(int,System.Reflection.FieldInfo[],System.Object,System.Globalization.CultureInfo):System.Reflection.FieldInfo:this (FullOpts)
          38 (20.11% of base) : 19427.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 1428.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 16662.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 22023.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)

Top method improvements (bytes):
        -161 (-2.89% of base) : 12107.dasm - System.DateTimeFormat:FormatCustomized[ushort](System.DateTime,System.ReadOnlySpan`1[ushort],System.Globalization.DateTimeFormatInfo,System.TimeSpan,byref) (FullOpts)
        -161 (-2.89% of base) : 14999.dasm - System.DateTimeFormat:FormatCustomized[ushort](System.DateTime,System.ReadOnlySpan`1[ushort],System.Globalization.DateTimeFormatInfo,System.TimeSpan,byref) (FullOpts)
        -161 (-2.86% of base) : 6342.dasm - System.DateTimeFormat:FormatCustomized[ushort](System.DateTime,System.ReadOnlySpan`1[ushort],System.Globalization.DateTimeFormatInfo,System.TimeSpan,byref) (FullOpts)
        -153 (-3.92% of base) : 1751.dasm - System.Runtime.InteropServices.Marshal:GetExceptionForHRInternal(int,long):System.Exception (FullOpts)
        -153 (-3.92% of base) : 6766.dasm - System.Runtime.InteropServices.Marshal:GetExceptionForHRInternal(int,long):System.Exception (FullOpts)
        -109 (-9.16% of base) : 5191.dasm - System.Globalization.TextInfo:ChangeCaseCommon[System.Globalization.TextInfo+ToLowerConversion](System.String):System.String:this (FullOpts)
        -109 (-9.16% of base) : 10712.dasm - System.Globalization.TextInfo:ChangeCaseCommon[System.Globalization.TextInfo+ToLowerConversion](System.String):System.String:this (FullOpts)
        -109 (-11.43% of base) : 21693.dasm - System.Text.Encoding:GetCharsWithFallback(ulong,int,ulong,int,int,int,System.Text.DecoderNLS):int:this (FullOpts)
        -109 (-11.43% of base) : 16312.dasm - System.Text.Encoding:GetCharsWithFallback(ulong,int,ulong,int,int,int,System.Text.DecoderNLS):int:this (FullOpts)
        -109 (-11.43% of base) : 18980.dasm - System.Text.Encoding:GetCharsWithFallback(ulong,int,ulong,int,int,int,System.Text.DecoderNLS):int:this (FullOpts)
        -106 (-1.39% of base) : 19034.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
        -104 (-1.37% of base) : 21715.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
        -104 (-1.37% of base) : 16432.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
        -104 (-10.92% of base) : 1129.dasm - System.Text.Encoding:GetCharsWithFallback(ulong,int,ulong,int,int,int,System.Text.DecoderNLS):int:this (FullOpts)
        -103 (-1.35% of base) : 1128.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
        -103 (-1.35% of base) : 4550.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         -90 (-8.73% of base) : 4368.dasm - System.Text.Encoding:GetCharsWithFallback(ulong,int,ulong,int,int,int,System.Text.DecoderNLS):int:this (FullOpts)
         -87 (-4.12% of base) : 485.dasm - System.Text.UnicodeEncoding:GetByteCount(ulong,int,System.Text.EncoderNLS):int:this (FullOpts)
         -87 (-4.12% of base) : 15778.dasm - System.Text.UnicodeEncoding:GetByteCount(ulong,int,System.Text.EncoderNLS):int:this (FullOpts)
         -87 (-4.12% of base) : 21122.dasm - System.Text.UnicodeEncoding:GetByteCount(ulong,int,System.Text.EncoderNLS):int:this (FullOpts)

Top method regressions (percentages):
          10 (27.78% of base) : 30006.dasm - System.Collections.Generic.List`1[int]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[int]:this (FullOpts)
          10 (27.03% of base) : 31030.dasm - System.Collections.Generic.HashSet`1[System.__Canon]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (27.03% of base) : 14390.dasm - System.Collections.Generic.List`1[System.__Canon]:GetEnumerator():System.Collections.Generic.List`1+Enumerator[System.__Canon]:this (FullOpts)
          10 (24.39% of base) : 31174.dasm - System.Collections.Generic.Stack`1[System.__Canon]:GetEnumerator():System.Collections.Generic.Stack`1+Enumerator[System.__Canon]:this (FullOpts)
          26 (24.07% of base) : 5762.dasm - System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
          26 (24.07% of base) : 25610.dasm - System.Text.DecoderNLS:ConcatInto(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],System.Span`1[ubyte]):int (FullOpts)
          38 (20.11% of base) : 19427.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 1428.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 16662.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 22023.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          38 (20.11% of base) : 4902.dasm - System.Number:FindSection(System.ReadOnlySpan`1[ushort],int):int (FullOpts)
          67 (13.43% of base) : 2330.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 20157.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 7162.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 22820.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          67 (13.43% of base) : 17473.dasm - System.Globalization.CultureData:ConvertIcuTimeFormatString(System.ReadOnlySpan`1[ushort]):System.String (FullOpts)
          21 (11.35% of base) : 22121.dasm - System.Collections.Generic.LowLevelDictionary`2+LowLevelDictEnumerator[System.__Canon,System.__Canon]:.ctor(System.Collections.Generic.LowLevelDictionary`2[System.__Canon,System.__Canon]):this (FullOpts)
          21 (11.35% of base) : 19396.dasm - System.Collections.Generic.LowLevelDictionary`2+LowLevelDictEnumerator[System.__Canon,System.__Canon]:.ctor(System.Collections.Generic.LowLevelDictionary`2[System.__Canon,System.__Canon]):this (FullOpts)
          21 (11.35% of base) : 1617.dasm - System.Collections.Generic.LowLevelDictionary`2+LowLevelDictEnumerator[System.__Canon,System.__Canon]:.ctor(System.Collections.Generic.LowLevelDictionary`2[System.__Canon,System.__Canon]):this (FullOpts)
          21 (11.35% of base) : 5332.dasm - System.Collections.Generic.LowLevelDictionary`2+LowLevelDictEnumerator[System.__Canon,System.__Canon]:.ctor(System.Collections.Generic.LowLevelDictionary`2[System.__Canon,System.__Canon]):this (FullOpts)

Top method improvements (percentages):
         -33 (-48.53% of base) : 29413.dasm - System.Number:UInt32ToBinaryChars[ushort](ulong,uint,int):ulong (FullOpts)
         -33 (-47.14% of base) : 29397.dasm - System.Number:UInt64ToBinaryChars[ushort](ulong,ulong,int):ulong (FullOpts)
         -36 (-40.91% of base) : 29414.dasm - System.Number:Int32ToHexChars[ushort](ulong,uint,int,int):ulong (FullOpts)
         -36 (-40.00% of base) : 29398.dasm - System.Number:Int64ToHexChars[ushort](ulong,ulong,int,int):ulong (FullOpts)
         -21 (-32.81% of base) : 23141.dasm - System.DllNotFoundException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 14658.dasm - System.FormatException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 4481.dasm - System.FormatException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 3234.dasm - System.InvalidCastException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 21730.dasm - System.InvalidCastException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 21732.dasm - System.InvalidOperationException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 4578.dasm - System.InvalidProgramException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 14661.dasm - System.InvalidProgramException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 28579.dasm - System.IO.PathTooLongException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 10244.dasm - System.MemberAccessException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 14915.dasm - System.MemberAccessException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 3236.dasm - System.NotSupportedException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 30501.dasm - System.OperationCanceledException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 14818.dasm - System.Security.SecurityException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 1282.dasm - System.Threading.ThreadStateException:.ctor(System.String):this (FullOpts)
         -21 (-32.81% of base) : 19172.dasm - System.Threading.WaitHandleCannotBeOpenedException:.ctor(System.String):this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
