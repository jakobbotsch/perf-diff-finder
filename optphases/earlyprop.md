Diffs are based on <span style="color:#1460aa">2,450,559</span> contexts (<span style="color:#1460aa">955,294</span> MinOpts, <span style="color:#1460aa">1,495,265</span> FullOpts).

<span style="color:#d35400">MISSED</span> contexts: base: <span style="color:#d35400">7,151 (0.29%)</span>, diff: <span style="color:#d35400">7,147 (0.29%)</span>

Base JIT options: JitDoEarlyProp=0


<details>
<summary>Overall (<span style="color:green">-448,088</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,433,103|<span style="color:green">-16,171</span>|<span style="color:green">-5.00%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|35,473,761|<span style="color:green">-16,748</span>|<span style="color:green">-4.35%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|12,719,360|<span style="color:green">-8,117</span>|<span style="color:green">-7.13%</span>|
|coreclr_tests.run.windows.x64.checked.mch|386,876,814|<span style="color:green">-64,715</span>|<span style="color:green">-1.00%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,112,454|<span style="color:green">-13,361</span>|<span style="color:green">-7.83%</span>|
|libraries.pmi.windows.x64.checked.mch|61,521,797|<span style="color:green">-83,413</span>|<span style="color:green">-9.92%</span>|
|libraries_tests.run.windows.x64.Release.mch|285,135,939|<span style="color:green">-111,335</span>|<span style="color:green">-4.20%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|136,497,015|<span style="color:green">-113,653</span>|<span style="color:green">-4.68%</span>|
|realworld.run.windows.x64.checked.mch|13,996,974|<span style="color:green">-17,626</span>|<span style="color:green">-5.48%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,120,325|<span style="color:green">-2,949</span>|<span style="color:green">-8.48%</span>|


</div></details>

<details>
<summary>FullOpts (<span style="color:green">-448,088</span> bytes)</summary>
<div style="margin-left:1em">

|Collection|Base size (bytes)|Diff size (bytes)|PerfScore in Diffs
|---|--:|--:|--:|
|benchmarks.run.windows.x64.checked.mch|11,432,743|<span style="color:green">-16,171</span>|<span style="color:green">-5.00%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|21,571,137|<span style="color:green">-16,748</span>|<span style="color:green">-4.35%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|3,486,577|<span style="color:green">-8,117</span>|<span style="color:green">-7.13%</span>|
|coreclr_tests.run.windows.x64.checked.mch|106,433,665|<span style="color:green">-64,715</span>|<span style="color:green">-1.00%</span>|
|libraries.crossgen2.windows.x64.checked.mch|45,111,267|<span style="color:green">-13,361</span>|<span style="color:green">-7.83%</span>|
|libraries.pmi.windows.x64.checked.mch|61,408,303|<span style="color:green">-83,413</span>|<span style="color:green">-9.92%</span>|
|libraries_tests.run.windows.x64.Release.mch|105,488,920|<span style="color:green">-111,335</span>|<span style="color:green">-4.20%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|126,204,136|<span style="color:green">-113,653</span>|<span style="color:green">-4.68%</span>|
|realworld.run.windows.x64.checked.mch|13,610,806|<span style="color:green">-17,626</span>|<span style="color:green">-5.48%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|5,119,378|<span style="color:green">-2,949</span>|<span style="color:green">-8.48%</span>|


</div></details>

<details>
<summary>Example diffs</summary>
<div style="margin-left:1em">


<details>
<summary>benchmarks.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 5460.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
 ;* V02 arg2         [V02    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    "field V02.<Scope>k__BackingField (fldOffset=0x0)" P-INDEP
@@ -22,15 +22,14 @@ G_M22722_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22722_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x08]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M22722_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 19734.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
 ;* V02 arg2         [V02    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    "field V02.<Scope>k__BackingField (fldOffset=0x0)" P-INDEP
@@ -22,15 +22,14 @@ G_M22722_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22722_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x08]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M22722_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-20.00%</span>) : 3107.dasm - System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:get_Count():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,9 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T00] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <<unknown class>>
 ;
 ; Lcl frame size = 0
 
@@ -20,15 +20,14 @@ G_M21594_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        ; gcrRegs +[rcx]
        mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
        mov      eax, dword ptr [rax+0x20]
        ; gcrRegs -[rax]
-						;; size=9 bbWeight=1 PerfScore 7.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M21594_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 8.00, instruction count 4, allocated bytes for code 10 (MethodHash=7e22aba5) for method System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:get_Count():int:this (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=7e22aba5) for method System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:get_Count():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 4201.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M17231_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 19698.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M22035_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22035_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M22035_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 19700.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M17231_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_pgo.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-20.00%</span>) : 18930.dasm - System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
 ;  V01 arg1         [V01,T02] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V03 tmp1         [V03,T00] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
 ;
 ; Lcl frame size = 0
 
@@ -19,15 +19,14 @@ G_M4202_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M4202_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        add      rcx, 16
        add      dword ptr [rcx+0x0C], edx
-						;; size=9 bbWeight=1 PerfScore 6.25
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M4202_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 7.25, instruction count 4, allocated bytes for code 10 (MethodHash=c7fcef95) for method System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
+; Total bytes of code 8, prolog size 0, PerfScore 4.25, instruction count 3, allocated bytes for code 8 (MethodHash=c7fcef95) for method System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-4</span> (<span style="color:green">-16.00%</span>) : 47013.dasm - System.Collections.Generic.SortedSet`1+Node[int]:Split4Node():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.SortedSet`1+Node[int]>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V03 tmp2         [V03,T02] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V03 tmp2         [V03,T02] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;
 ; Lcl frame size = 0
 
@@ -22,17 +22,15 @@ G_M13810_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        mov      byte  ptr [rcx+0x1C], 1
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
        mov      byte  ptr [rax+0x1C], 0
        mov      rax, gword ptr [rcx+0x10]
-       cmp      byte  ptr [rax], al
        mov      byte  ptr [rax+0x1C], 0
-						;; size=24 bbWeight=1 PerfScore 13.00
+						;; size=20 bbWeight=1 PerfScore 7.00
 G_M13810_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 25, prolog size 0, PerfScore 14.00, instruction count 8, allocated bytes for code 25 (MethodHash=e93cca0d) for method System.Collections.Generic.SortedSet`1+Node[int]:Split4Node():this (Tier1)
+; Total bytes of code 21, prolog size 0, PerfScore 8.00, instruction count 6, allocated bytes for code 21 (MethodHash=e93cca0d) for method System.Collections.Generic.SortedSet`1+Node[int]:Split4Node():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-15.38%</span>) : 18949.dasm - System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,9 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V02 tmp1         [V02,T00] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
 ;
 ; Lcl frame size = 0
 
@@ -18,16 +18,15 @@ G_M28984_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M28984_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        add      rcx, 16
        mov      eax, dword ptr [rcx+0x0C]
        sub      eax, dword ptr [rcx+0x08]
-						;; size=12 bbWeight=1 PerfScore 8.25
+						;; size=10 bbWeight=1 PerfScore 5.25
 G_M28984_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 13, prolog size 0, PerfScore 9.25, instruction count 5, allocated bytes for code 13 (MethodHash=d2488ec7) for method System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)
+; Total bytes of code 11, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 11 (MethodHash=d2488ec7) for method System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+4</span> (<span style="color:red">+4.00%</span>) : 86893.dasm - System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -11,7 +11,7 @@
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c>
 ;  V01 arg1         [V01,T01] (  3,  3   )     ref  ->  rdx         class-hnd single-def <System.Text.RegularExpressions.Match>
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T00] (  8,  7   )     ref  ->  rbx         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.CaptureCollection>
+;  V03 tmp1         [V03,T00] (  7,  5   )     ref  ->  rbx         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.CaptureCollection>
 ;  V04 tmp2         [V04,T02] (  3,  1.50)     ref  ->  rcx         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Capture>
 ;  V05 tmp3         [V05,T03] (  3,  0   )     ref  ->  rax         single-def "arr expr"
 ;
@@ -31,11 +31,12 @@ G_M61053_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byr
        ; gcr arg pop 0
        mov      rbx, rax
        ; gcrRegs +[rbx]
-       cmp      byte  ptr [rbx], bl
        mov      ecx, dword ptr [rbx+0x18]
        dec      ecx
+       movsxd   rcx, ecx
+       test     rcx, rcx
        jne      SHORT G_M61053_IG07
-						;; size=23 bbWeight=1 PerfScore 12.75
+						;; size=27 bbWeight=1 PerfScore 10.25
 G_M61053_IG03:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax]
        mov      rcx, gword ptr [rbx+0x08]
@@ -86,7 +87,7 @@ G_M61053_IG09:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        jmp      SHORT G_M61053_IG04
 						;; size=16 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 100, prolog size 5, PerfScore 20.75, instruction count 30, allocated bytes for code 100 (MethodHash=ddd81182) for method System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (Tier1)
+; Total bytes of code 104, prolog size 5, PerfScore 18.25, instruction count 31, allocated bytes for code 104 (MethodHash=ddd81182) for method System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+9</span> (<span style="color:red">+6.47%</span>) : 97842.dasm - System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,19 +9,19 @@
 ; 1 inlinees with PGO data; 10 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
+;  V00 this         [V00,T00] (  5,  4   )     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;  V01 arg1         [V01,T04] (  3,  2   )     ref  ->  rcx         class-hnd single-def <System.Text.RegularExpressions.Symbolic.ISolver`1[ulong]>
-;  V02 arg2         [V02,T03] (  3,  3   )   ubyte  ->   r8         single-def
-;  V03 loc0         [V03,T02] ( 13,  5.33)   ubyte  ->  rsi        
+;  V02 arg2         [V02,T02] (  3,  3   )   ubyte  ->   r8         single-def
+;  V03 loc0         [V03,T01] ( 14,  5.33)   ubyte  ->  rsi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T07] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
 ;  V06 tmp2         [V06,T05] (  3,  4   )     ref  ->  rdx         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V07 tmp3         [V07,T01] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V07 tmp3         [V07,T03] (  4,  4   )     ref  ->   r8         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
 ;* V08 tmp4         [V08    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V09 tmp5         [V09,T08] (  3,  0   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V09 tmp5         [V09,T08] (  2,  0   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
 ;* V10 tmp6         [V10    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V11 tmp7         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V12 cse0         [V12,T06] (  4,  3   )     ref  ->  rdi         "CSE - aggressive"
+;  V12 cse0         [V12,T06] (  6,  3   )     ref  ->  rdi         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -43,40 +43,36 @@ G_M42217_IG02:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        mov      rdx, gword ptr [rbx+0x08]
        ; gcrRegs +[rdx]
        cmp      dword ptr [rdx+0x28], 1
-       je       SHORT G_M42217_IG08
-						;; size=23 bbWeight=1 PerfScore 7.00
-G_M42217_IG03:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rcx rdx]
+       je       SHORT G_M42217_IG07
        mov      rdi, gword ptr [rbx+0x08]
        ; gcrRegs +[rdi]
-       mov      rax, rdi
-       ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
-       test     byte  ptr [rax+0x34], 8
-       jne      SHORT G_M42217_IG09
-						;; size=15 bbWeight=1 PerfScore 9.25
-G_M42217_IG04:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax rbx]
+       mov      r8, rdi
+       ; gcrRegs +[r8]
+       test     byte  ptr [r8+0x34], 8
+       jne      SHORT G_M42217_IG08
+						;; size=37 bbWeight=1 PerfScore 13.25
+G_M42217_IG03:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx rdx rbx r8]
        cmp      dword ptr [rdi+0x28], 17
-       je       SHORT G_M42217_IG06
+       je       SHORT G_M42217_IG05
 						;; size=6 bbWeight=1 PerfScore 4.00
-G_M42217_IG05:        ; bbWeight=0.67, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M42217_IG04:        ; bbWeight=0.67, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        mov      eax, esi
        or       eax, 16
        movzx    rsi, al
 						;; size=9 bbWeight=0.67 PerfScore 0.50
-G_M42217_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M42217_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, esi
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M42217_IG07:        ; bbWeight=1, epilog, nogc, extend
+G_M42217_IG06:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rsi
        pop      rdi
        ret      
 						;; size=8 bbWeight=1 PerfScore 2.75
-G_M42217_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=000E {rcx rdx rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M42217_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=000E {rcx rdx rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx rdx rbx]
        mov      rdx, qword ptr [rdx+0x20]
        ; gcrRegs -[rdx]
@@ -89,26 +85,29 @@ G_M42217_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=000E {
        movzx    rcx, cl
        test     eax, eax
        cmovne   esi, ecx
-       jmp      SHORT G_M42217_IG03
-						;; size=32 bbWeight=0 PerfScore 0.00
-G_M42217_IG09:        ; bbWeight=0, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rbx] +[rdi]
+       mov      rdi, gword ptr [rbx+0x08]
+       ; gcrRegs +[rdi]
+       mov      r8, rdi
+       ; gcrRegs +[r8]
+       test     byte  ptr [r8+0x34], 8
+       je       SHORT G_M42217_IG03
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M42217_IG08:        ; bbWeight=0, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rbx r8]
        mov      eax, esi
        or       eax, 8
        movzx    rsi, al
        mov      rax, rdi
        ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
+       mov      ecx, esi
+       or       ecx, 4
+       movzx    rcx, cl
        test     byte  ptr [rax+0x34], 1
-       je       SHORT G_M42217_IG04
-       mov      eax, esi
-       ; gcrRegs -[rax]
-       or       eax, 4
-       movzx    rsi, al
-       jmp      SHORT G_M42217_IG04
-						;; size=31 bbWeight=0 PerfScore 0.00
+       cmovne   esi, ecx
+       jmp      SHORT G_M42217_IG03
+						;; size=29 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 139, prolog size 7, PerfScore 27.50, instruction count 49, allocated bytes for code 139 (MethodHash=f7db5b16) for method System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
+; Total bytes of code 148, prolog size 7, PerfScore 24.50, instruction count 50, allocated bytes for code 148 (MethodHash=f7db5b16) for method System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+9</span> (<span style="color:red">+6.47%</span>) : 95293.dasm - System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,19 +9,19 @@
 ; 1 inlinees with PGO data; 10 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
+;  V00 this         [V00,T00] (  5,  4   )     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;  V01 arg1         [V01,T04] (  3,  2   )     ref  ->  rcx         class-hnd single-def <System.Text.RegularExpressions.Symbolic.ISolver`1[ulong]>
-;  V02 arg2         [V02,T03] (  3,  3   )   ubyte  ->   r8         single-def
-;  V03 loc0         [V03,T02] ( 13,  5.33)   ubyte  ->  rsi        
+;  V02 arg2         [V02,T02] (  3,  3   )   ubyte  ->   r8         single-def
+;  V03 loc0         [V03,T01] ( 14,  5.33)   ubyte  ->  rsi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T07] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
 ;  V06 tmp2         [V06,T05] (  3,  4   )     ref  ->  rdx         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V07 tmp3         [V07,T01] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V07 tmp3         [V07,T03] (  4,  4   )     ref  ->   r8         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
 ;* V08 tmp4         [V08    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V09 tmp5         [V09,T08] (  3,  0   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V09 tmp5         [V09,T08] (  2,  0   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
 ;* V10 tmp6         [V10    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V11 tmp7         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V12 cse0         [V12,T06] (  4,  3   )     ref  ->  rdi         "CSE - aggressive"
+;  V12 cse0         [V12,T06] (  6,  3   )     ref  ->  rdi         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -43,40 +43,36 @@ G_M42217_IG02:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {},
        mov      rdx, gword ptr [rbx+0x08]
        ; gcrRegs +[rdx]
        cmp      dword ptr [rdx+0x28], 1
-       je       SHORT G_M42217_IG08
-						;; size=23 bbWeight=1 PerfScore 7.00
-G_M42217_IG03:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rcx rdx]
+       je       SHORT G_M42217_IG07
        mov      rdi, gword ptr [rbx+0x08]
        ; gcrRegs +[rdi]
-       mov      rax, rdi
-       ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
-       test     byte  ptr [rax+0x34], 8
-       jne      SHORT G_M42217_IG09
-						;; size=15 bbWeight=1 PerfScore 9.25
-G_M42217_IG04:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rax rbx]
+       mov      r8, rdi
+       ; gcrRegs +[r8]
+       test     byte  ptr [r8+0x34], 8
+       jne      SHORT G_M42217_IG08
+						;; size=37 bbWeight=1 PerfScore 13.25
+G_M42217_IG03:        ; bbWeight=1, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rcx rdx rbx r8]
        cmp      dword ptr [rdi+0x28], 17
-       je       SHORT G_M42217_IG06
+       je       SHORT G_M42217_IG05
 						;; size=6 bbWeight=1 PerfScore 4.00
-G_M42217_IG05:        ; bbWeight=0.67, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M42217_IG04:        ; bbWeight=0.67, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rdi]
        mov      eax, esi
        or       eax, 16
        movzx    rsi, al
 						;; size=9 bbWeight=0.67 PerfScore 0.50
-G_M42217_IG06:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M42217_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, esi
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M42217_IG07:        ; bbWeight=1, epilog, nogc, extend
+G_M42217_IG06:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        pop      rsi
        pop      rdi
        ret      
 						;; size=8 bbWeight=1 PerfScore 2.75
-G_M42217_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=000E {rcx rdx rbx}, byrefRegs=0000 {}, gcvars, byref, isz
+G_M42217_IG07:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=000E {rcx rdx rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        ; gcrRegs +[rcx rdx rbx]
        mov      rdx, qword ptr [rdx+0x20]
        ; gcrRegs -[rdx]
@@ -89,26 +85,29 @@ G_M42217_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=000E {
        movzx    rcx, cl
        test     eax, eax
        cmovne   esi, ecx
-       jmp      SHORT G_M42217_IG03
-						;; size=32 bbWeight=0 PerfScore 0.00
-G_M42217_IG09:        ; bbWeight=0, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
-       ; gcrRegs -[rbx] +[rdi]
+       mov      rdi, gword ptr [rbx+0x08]
+       ; gcrRegs +[rdi]
+       mov      r8, rdi
+       ; gcrRegs +[r8]
+       test     byte  ptr [r8+0x34], 8
+       je       SHORT G_M42217_IG03
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M42217_IG08:        ; bbWeight=0, gcrefRegs=0080 {rdi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rbx r8]
        mov      eax, esi
        or       eax, 8
        movzx    rsi, al
        mov      rax, rdi
        ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
+       mov      ecx, esi
+       or       ecx, 4
+       movzx    rcx, cl
        test     byte  ptr [rax+0x34], 1
-       je       SHORT G_M42217_IG04
-       mov      eax, esi
-       ; gcrRegs -[rax]
-       or       eax, 4
-       movzx    rsi, al
-       jmp      SHORT G_M42217_IG04
-						;; size=31 bbWeight=0 PerfScore 0.00
+       cmovne   esi, ecx
+       jmp      SHORT G_M42217_IG03
+						;; size=29 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 139, prolog size 7, PerfScore 27.50, instruction count 49, allocated bytes for code 139 (MethodHash=f7db5b16) for method System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
+; Total bytes of code 148, prolog size 7, PerfScore 24.50, instruction count 50, allocated bytes for code 148 (MethodHash=f7db5b16) for method System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>benchmarks.run_tiered.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-20.00%</span>) : 8937.dasm - System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,10 +8,10 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
 ;  V01 arg1         [V01,T02] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V03 tmp1         [V03,T01] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V03 tmp1         [V03,T00] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
 ;
 ; Lcl frame size = 0
 
@@ -19,15 +19,14 @@ G_M4202_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M4202_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        add      rcx, 16
        add      dword ptr [rcx+0x0C], edx
-						;; size=9 bbWeight=1 PerfScore 6.25
+						;; size=7 bbWeight=1 PerfScore 3.25
 G_M4202_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 7.25, instruction count 4, allocated bytes for code 10 (MethodHash=c7fcef95) for method System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
+; Total bytes of code 8, prolog size 0, PerfScore 4.25, instruction count 3, allocated bytes for code 8 (MethodHash=c7fcef95) for method System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-4</span> (<span style="color:green">-16.00%</span>) : 19669.dasm - System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:Split4Node():this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -10,8 +10,8 @@
 ;
 ;  V00 this         [V00,T00] (  5,  5   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
-;  V03 tmp2         [V03,T02] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
+;  V02 tmp1         [V02,T01] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
+;  V03 tmp2         [V03,T02] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]>
 ;
 ; Lcl frame size = 0
 
@@ -22,17 +22,15 @@ G_M20368_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        mov      byte  ptr [rcx+0x18], 1
        mov      rax, gword ptr [rcx+0x08]
        ; gcrRegs +[rax]
-       cmp      byte  ptr [rax], al
        mov      byte  ptr [rax+0x18], 0
        mov      rax, gword ptr [rcx+0x10]
-       cmp      byte  ptr [rax], al
        mov      byte  ptr [rax+0x18], 0
-						;; size=24 bbWeight=1 PerfScore 13.00
+						;; size=20 bbWeight=1 PerfScore 7.00
 G_M20368_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 25, prolog size 0, PerfScore 14.00, instruction count 8, allocated bytes for code 25 (MethodHash=fd11b06f) for method System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:Split4Node():this (Tier1)
+; Total bytes of code 21, prolog size 0, PerfScore 8.00, instruction count 6, allocated bytes for code 21 (MethodHash=fd11b06f) for method System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:Split4Node():this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-15.38%</span>) : 8951.dasm - System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,9 +8,9 @@
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T01] (  3,  3   )   byref  ->  rcx         this single-def
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T01] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V02 tmp1         [V02,T00] (  3,  6   )   byref  ->  rcx         single-def "Inlining Arg"
 ;
 ; Lcl frame size = 0
 
@@ -18,16 +18,15 @@ G_M28984_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M28984_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0002 {rcx}, byref
        ; byrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        add      rcx, 16
        mov      eax, dword ptr [rcx+0x0C]
        sub      eax, dword ptr [rcx+0x08]
-						;; size=12 bbWeight=1 PerfScore 8.25
+						;; size=10 bbWeight=1 PerfScore 5.25
 G_M28984_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 13, prolog size 0, PerfScore 9.25, instruction count 5, allocated bytes for code 13 (MethodHash=d2488ec7) for method System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)
+; Total bytes of code 11, prolog size 0, PerfScore 6.25, instruction count 4, allocated bytes for code 11 (MethodHash=d2488ec7) for method System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+13</span> (<span style="color:red">+2.56%</span>) : 30866.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -8,62 +8,63 @@
 ; 0 inlinees with PGO data; 10 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 18, 24   )   byref  ->  rbx         this single-def
+;  V00 this         [V00,T00] ( 18, 20.25)   byref  ->  rbx         this single-def
 ;  V01 arg1         [V01,T05] ( 11,  6.50)     int  ->  rdi         single-def
 ;  V02 arg2         [V02,T04] ( 14,  8.50)     int  ->  rsi         single-def
-;  V03 arg3         [V03,T08] (  4,  3   )   ubyte  ->   r9         single-def
+;  V03 arg3         [V03,T09] (  4,  3   )   ubyte  ->   r9         single-def
 ;* V04 loc0         [V04    ] (  0,  0   )     int  ->  zero-ref   
 ;* V05 loc1         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V06 loc2         [V06,T01] (  5, 16.50)     int  ->  rsi        
 ;  V07 loc3         [V07,T06] (  2,  8   )  ushort  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T15] (  2,  2   )     ref  ->  rbp         class-hnd exact single-def "impAppendStmt" <System.Text.RegularExpressions.RegexNode>
-;  V10 tmp2         [V10,T20] (  2,  2   )     int  ->  r14         "impAppendStmt"
-;  V11 tmp3         [V11,T07] (  5,  5   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <System.Text.RegularExpressions.RegexNode>
+;  V09 tmp1         [V09,T16] (  2,  2   )     ref  ->  rbp         class-hnd exact single-def "impAppendStmt" <System.Text.RegularExpressions.RegexNode>
+;  V10 tmp2         [V10,T21] (  2,  2   )     int  ->  r14         "impAppendStmt"
+;  V11 tmp3         [V11,T08] (  5,  5   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <System.Text.RegularExpressions.RegexNode>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V13 tmp5         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.RegexNode>
-;  V14 tmp6         [V14,T26] (  2,  1   )     ref  ->  rsi         single-def
-;  V15 tmp7         [V15,T29] (  2,  1   )     int  ->  rcx        
+;  V14 tmp6         [V14,T27] (  2,  1   )     ref  ->  rsi         single-def
+;  V15 tmp7         [V15,T30] (  2,  1   )     int  ->  rcx        
 ;* V16 tmp8         [V16    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref   
-;  V18 tmp10        [V18,T23] (  3,  1.50)     int  ->  rdx        
+;  V18 tmp10        [V18,T24] (  3,  1.50)     int  ->  rdx        
 ;* V19 tmp11        [V19    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
-;  V20 tmp12        [V20,T11] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V20 tmp12        [V20,T12] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V21 tmp13        [V21    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V22 tmp14        [V22    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V23 tmp15        [V23,T16] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
+;  V23 tmp15        [V23,T17] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
 ;* V24 tmp16        [V24    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V25 tmp17        [V25    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V26 tmp18        [V26,T17] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V26 tmp18        [V26,T18] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V27 tmp19        [V27    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
-;  V28 tmp20        [V28,T12] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V28 tmp20        [V28,T13] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V29 tmp21        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V30 tmp22        [V30    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V31 tmp23        [V31,T18] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
+;  V31 tmp23        [V31,T19] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V32 tmp24        [V32    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V33 tmp25        [V33    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V34 tmp26        [V34,T10] (  2,  4.50)   byref  ->  rdi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V35 tmp27        [V35,T09] (  3,  5   )     int  ->  rbp         "field V05._length (fldOffset=0x8)" P-INDEP
+;  V34 tmp26        [V34,T11] (  2,  4.50)   byref  ->  rdi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V35 tmp27        [V35,T10] (  3,  5   )     int  ->  rbp         "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V36 tmp28        [V36    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V37 tmp29        [V37    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
-;  V38 tmp30        [V38,T21] (  3,  1.50)   byref  ->  rbp         "field V19._reference (fldOffset=0x0)" P-INDEP
-;  V39 tmp31        [V39,T24] (  3,  1.50)     int  ->  r14         "field V19._length (fldOffset=0x8)" P-INDEP
-;  V40 tmp32        [V40,T27] (  2,  1   )   byref  ->  rbp         single-def "field V21._reference (fldOffset=0x0)" P-INDEP
-;* V41 tmp33        [V41,T31] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
+;  V38 tmp30        [V38,T22] (  3,  1.50)   byref  ->  rbp         "field V19._reference (fldOffset=0x0)" P-INDEP
+;  V39 tmp31        [V39,T25] (  3,  1.50)     int  ->  r14         "field V19._length (fldOffset=0x8)" P-INDEP
+;  V40 tmp32        [V40,T28] (  2,  1   )   byref  ->  rbp         single-def "field V21._reference (fldOffset=0x0)" P-INDEP
+;* V41 tmp33        [V41,T32] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V42 tmp34        [V42    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V22._reference (fldOffset=0x0)" P-INDEP
 ;* V43 tmp35        [V43    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
-;  V44 tmp36        [V44,T22] (  3,  1.50)   byref  ->  rdi         "field V27._reference (fldOffset=0x0)" P-INDEP
-;  V45 tmp37        [V45,T25] (  3,  1.50)     int  ->  rbp         "field V27._length (fldOffset=0x8)" P-INDEP
-;  V46 tmp38        [V46,T28] (  2,  1   )   byref  ->  rdi         single-def "field V29._reference (fldOffset=0x0)" P-INDEP
-;  V47 tmp39        [V47,T30] (  2,  1   )     int  ->  rbp         "field V29._length (fldOffset=0x8)" P-INDEP
+;  V44 tmp36        [V44,T23] (  3,  1.50)   byref  ->  rdi         "field V27._reference (fldOffset=0x0)" P-INDEP
+;  V45 tmp37        [V45,T26] (  3,  1.50)     int  ->  rbp         "field V27._length (fldOffset=0x8)" P-INDEP
+;  V46 tmp38        [V46,T29] (  2,  1   )   byref  ->  rdi         single-def "field V29._reference (fldOffset=0x0)" P-INDEP
+;  V47 tmp39        [V47,T31] (  2,  1   )     int  ->  rbp         "field V29._length (fldOffset=0x8)" P-INDEP
 ;* V48 tmp40        [V48    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V30._reference (fldOffset=0x0)" P-INDEP
 ;* V49 tmp41        [V49    ] (  0,  0   )     int  ->  zero-ref    "field V30._length (fldOffset=0x8)" P-INDEP
 ;  V50 tmp42        [V50    ] (  3,  3   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;  V51 tmp43        [V51,T02] (  2, 16   )     ref  ->  rdx         "argument with side effect"
-;  V52 tmp44        [V52,T03] (  2, 16   )     ref  ->  r14         "argument with side effect"
-;  V53 tmp45        [V53,T14] (  3,  3   )     ref  ->   r8         single-def "arr expr"
-;  V54 tmp46        [V54,T19] (  2,  2   )     ref  ->  rdx         single-def "argument with side effect"
-;  V55 cse0         [V55,T13] (  6,  3   )     ref  ->  rdx         multi-def "CSE - moderate"
+;  V52 tmp44        [V52,T03] (  2, 16   )     ref  ->  r15         "argument with side effect"
+;  V53 tmp45        [V53,T15] (  3,  3   )     ref  ->   r8         single-def "arr expr"
+;  V54 tmp46        [V54,T20] (  2,  2   )     ref  ->  rdx         single-def "argument with side effect"
+;  V55 cse0         [V55,T07] (  4,  5.25)   byref  ->  registers   hoist multi-def "CSE - aggressive"
+;  V56 cse1         [V56,T14] (  6,  3   )     ref  ->  rdx         multi-def "CSE - moderate"
 ;
 ; Lcl frame size = 56
 
@@ -96,7 +97,7 @@ G_M048_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, by
        mov      r8, gword ptr [rbx+0x28]
        ; gcrRegs +[r8]
        cmp      edi, dword ptr [r8+0x08]
-       jae      G_M048_IG20
+       jae      G_M048_IG21
        mov      ecx, edi
        movzx    rcx, word  ptr [r8+2*rcx+0x0C]
        test     r9b, r9b
@@ -123,14 +124,16 @@ G_M048_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0040
        and      edx, -2
 						;; size=6 bbWeight=0.50 PerfScore 1.12
 G_M048_IG06:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
-       lea      r9, bword ptr [rbx+0x5C]
+       lea      rbp, bword ptr [rbx+0x5C]
+       ; byrRegs +[rbp]
+       mov      r9, rbp
        ; byrRegs +[r9]
        mov      r8, gword ptr [rbx+0x30]
        ; gcrRegs +[r8]
        movzx    rcx, cx
        call     [System.Text.RegularExpressions.RegexNode:CreateOneWithCaseConversion(ushort,int,System.Globalization.CultureInfo,byref):System.Text.RegularExpressions.RegexNode]
        ; gcrRegs -[r8] +[rax]
-       ; byrRegs -[rbx r9]
+       ; byrRegs -[rbx rbp r9]
        ; gcr arg pop 0
        mov      rdx, rax
        ; gcrRegs +[rdx]
@@ -141,7 +144,7 @@ G_M048_IG06:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        ; gcrRegs -[rax rcx rdx rsi]
        ; gcr arg pop 0
        nop      
-						;; size=32 bbWeight=0.50 PerfScore 6.25
+						;; size=35 bbWeight=0.50 PerfScore 6.38
 G_M048_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 56
        pop      rbx
@@ -167,7 +170,7 @@ G_M048_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000
        mov      ecx, edi
        ; gcrRegs -[rcx]
        or       ecx, esi
-       jne      G_M048_IG21
+       jne      G_M048_IG22
        xor      rbp, rbp
        ; byrRegs +[rbp]
        xor      r14d, r14d
@@ -181,7 +184,7 @@ G_M048_IG09:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        add      rdx, rax
        mov      eax, dword ptr [rcx+0x08]
        cmp      rdx, rax
-       ja       G_M048_IG21
+       ja       G_M048_IG22
        mov      edx, edi
        lea      rbp, bword ptr [rcx+2*rdx+0x0C]
        ; byrRegs +[rbp]
@@ -263,12 +266,12 @@ G_M048_IG14:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000
        test     rcx, rcx
        jne      SHORT G_M048_IG15
        or       edi, esi
-       jne      SHORT G_M048_IG21
+       jne      G_M048_IG22
        xor      rdi, rdi
        ; byrRegs +[rdi]
        xor      ebp, ebp
        jmp      SHORT G_M048_IG17
-						;; size=19 bbWeight=0.50 PerfScore 3.50
+						;; size=23 bbWeight=0.50 PerfScore 3.50
 G_M048_IG15:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx}, byref, isz
        ; byrRegs -[rdi]
        mov      edx, edi
@@ -276,7 +279,7 @@ G_M048_IG15:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        add      rdx, rax
        mov      eax, dword ptr [rcx+0x08]
        cmp      rdx, rax
-       ja       SHORT G_M048_IG21
+       ja       SHORT G_M048_IG22
        mov      edx, edi
        lea      rdi, bword ptr [rcx+2*rdx+0x0C]
        ; byrRegs +[rdi]
@@ -297,12 +300,19 @@ G_M048_IG17:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}
        test     ebp, ebp
        jle      G_M048_IG04
 						;; size=10 bbWeight=0.50 PerfScore 0.75
-G_M048_IG18:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref, isz
+G_M048_IG18:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref
+       lea      r9, bword ptr [rbx+0x5C]
+       ; byrRegs +[r9]
+       mov      r14, r9
+       ; byrRegs +[r14]
+						;; size=7 bbWeight=0.25 PerfScore 0.19
+G_M048_IG19:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=4088 {rbx rdi r14}, byref, isz
+       ; byrRegs -[r9]
        mov      r9d, esi
        movzx    rcx, word  ptr [rdi+2*r9]
-       mov      r14, gword ptr [rbx+0x18]
-       ; gcrRegs +[r14]
-       lea      r9, bword ptr [rbx+0x5C]
+       mov      r15, gword ptr [rbx+0x18]
+       ; gcrRegs +[r15]
+       mov      r9, r14
        ; byrRegs +[r9]
        mov      edx, dword ptr [rbx+0x70]
        mov      r8, gword ptr [rbx+0x30]
@@ -313,32 +323,32 @@ G_M048_IG18:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, b
        ; gcr arg pop 0
        mov      rdx, rax
        ; gcrRegs +[rdx]
-       mov      rcx, r14
+       mov      rcx, r15
        ; gcrRegs +[rcx]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.RegexNode:AddChild(System.Text.RegularExpressions.RegexNode):this]
-       ; gcrRegs -[rax rcx rdx r14]
+       ; gcrRegs -[rax rcx rdx r15]
        ; gcr arg pop 0
        inc      esi
        cmp      esi, ebp
-       jl       SHORT G_M048_IG18
-						;; size=49 bbWeight=4 PerfScore 79.00
-G_M048_IG19:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rbx rdi]
+       jl       SHORT G_M048_IG19
+						;; size=48 bbWeight=4 PerfScore 78.00
+G_M048_IG20:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; byrRegs -[rbx rdi r14]
        jmp      G_M048_IG04
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M048_IG20:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M048_IG21:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M048_IG21:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M048_IG22:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      ecx, 33
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
        ; gcr arg pop 0
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 507, prolog size 19, PerfScore 148.12, instruction count 163, allocated bytes for code 507 (MethodHash=2c5cffcf) for method System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (Tier1)
+; Total bytes of code 520, prolog size 19, PerfScore 147.44, instruction count 166, allocated bytes for code 520 (MethodHash=2c5cffcf) for method System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+5.56%</span>) : 24728.dasm - EMFloat:normalize(byref) (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -7,66 +7,73 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T02] (  6, 15   )   byref  ->  rbx         single-def
-;  V01 loc0         [V01    ] (  2,  8   )  ushort  ->  [rsp+0x20]  do-not-enreg[X] must-init addr-exposed ld-addr-op
+;  V00 arg0         [V00,T02] (  6, 11.50)   byref  ->  rbx         single-def
+;  V01 loc0         [V01    ] (  2,  8   )  ushort  ->  [rsp+0x28]  do-not-enreg[X] must-init addr-exposed ld-addr-op
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 tmp1         [V03,T01] (  3, 24   )   byref  ->  rax         "dup spill"
 ;  V04 tmp2         [V04,T00] (  6, 30   )     ref  ->  rsi         "arr expr"
+;  V05 cse0         [V05,T03] (  2,  4.50)   byref  ->  rdi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
 G_M35062_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 48
        xor      eax, eax
-       mov      qword ptr [rsp+0x20], rax
+       mov      qword ptr [rsp+0x28], rax
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=16 bbWeight=1 PerfScore 3.75
+						;; size=17 bbWeight=1 PerfScore 4.75
 G_M35062_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        mov      rsi, gword ptr [rbx]
        ; gcrRegs +[rsi]
        cmp      dword ptr [rsi+0x08], 0
-       jbe      SHORT G_M35062_IG05
+       jbe      SHORT G_M35062_IG06
        test     word  ptr [rsi+0x10], 0x8000
-       jne      SHORT G_M35062_IG04
+       jne      SHORT G_M35062_IG05
 						;; size=17 bbWeight=1 PerfScore 10.00
-G_M35062_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M35062_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        ; gcrRegs -[rsi]
+       lea      rdi, bword ptr [rbx+0x08]
+       ; byrRegs +[rdi]
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M35062_IG04:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref, isz
        xor      edx, edx
-       mov      dword ptr [rsp+0x20], edx
+       mov      dword ptr [rsp+0x28], edx
        mov      rdx, gword ptr [rbx]
        ; gcrRegs +[rdx]
-       lea      rcx, [rsp+0x20]
+       lea      rcx, [rsp+0x28]
        call     [EMFloat:ShiftMantLeft1(byref,ushort[])]
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
-       lea      rax, bword ptr [rbx+0x08]
+       mov      rax, rdi
        ; byrRegs +[rax]
        dec      word  ptr [rax]
        mov      rsi, gword ptr [rbx]
        ; gcrRegs +[rsi]
        cmp      dword ptr [rsi+0x08], 0
-       jbe      SHORT G_M35062_IG05
+       jbe      SHORT G_M35062_IG06
        test     word  ptr [rsi+0x10], 0x8000
-       je       SHORT G_M35062_IG03
-						;; size=44 bbWeight=4 PerfScore 81.00
-G_M35062_IG04:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       je       SHORT G_M35062_IG04
+						;; size=43 bbWeight=4 PerfScore 80.00
+G_M35062_IG05:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; gcrRegs -[rsi]
-       ; byrRegs -[rax rbx]
-       add      rsp, 40
+       ; byrRegs -[rax rbx rdi]
+       add      rsp, 48
        pop      rbx
        pop      rsi
+       pop      rdi
        ret      
-						;; size=7 bbWeight=1 PerfScore 2.25
-G_M35062_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=8 bbWeight=1 PerfScore 2.75
+G_M35062_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 90, prolog size 13, PerfScore 97.00, instruction count 29, allocated bytes for code 90 (MethodHash=e0577709) for method EMFloat:normalize(byref) (Tier1)
+; Total bytes of code 95, prolog size 14, PerfScore 97.75, instruction count 32, allocated bytes for code 95 (MethodHash=e0577709) for method EMFloat:normalize(byref) (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -74,11 +81,12 @@ Unwind Info:
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
+    CodeOffset: 0x07 UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 5 * 8 + 8 = 48 = 0x30
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x01 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 26329.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M17231_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>coreclr_tests.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-12</span> (<span style="color:green">-35.29%</span>) : 190955.dasm - P:TestByPtr(ulong):int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T00] ( 10, 10   )    long  ->  rcx         single-def
+;  V00 arg0         [V00,T00] (  4,  4   )    long  ->  rcx         single-def
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V02 tmp1         [V02,T01] (  2,  4   )     int  ->  rax         "impAppendStmt"
 ;
@@ -19,23 +19,17 @@ G_M17980_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 G_M17980_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      eax, dword ptr [rcx]
        cmp      byte  ptr [rcx], cl
-       cmp      byte  ptr [rcx], cl
-       cmp      byte  ptr [rcx], cl
-       cmp      byte  ptr [rcx], cl
-       cmp      byte  ptr [rcx], cl
-       cmp      byte  ptr [rcx], cl
-       cmp      byte  ptr [rcx], cl
        mov      ecx, eax
        call     [<unknown method>]
        ; gcr arg pop 0
        nop      
-						;; size=25 bbWeight=1 PerfScore 26.50
+						;; size=13 bbWeight=1 PerfScore 8.50
 G_M17980_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 34, prolog size 4, PerfScore 28.00, instruction count 14, allocated bytes for code 34 (MethodHash=2f88b9c3) for method P:TestByPtr(ulong):int (FullOpts)
+; Total bytes of code 22, prolog size 4, PerfScore 10.00, instruction count 8, allocated bytes for code 22 (MethodHash=2f88b9c3) for method P:TestByPtr(ulong):int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-44</span> (<span style="color:green">-22.56%</span>) : 15836.dasm - testout1:Sub_Funclet_195():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,35 +8,35 @@
 ; 0 inlinees with PGO data; 5 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 loc0         [V00,T00] (  6,  6   )     int  ->   r8        
+;  V00 loc0         [V00,T01] (  2,  2   )     int  ->  rcx        
 ;* V01 loc1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;* V02 loc2         [V02    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;* V03 loc3         [V03    ] (  0,  0   )   ubyte  ->  zero-ref   
 ;* V04 loc4         [V04    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V05 loc5         [V05,T02] (  4,  4   )     ref  ->  rbx         class-hnd exact single-def <testout1>
+;  V05 loc5         [V05,T02] (  3,  3   )     ref  ->  rbx         class-hnd exact single-def <testout1>
 ;* V06 loc6         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <<unknown class>>
-;  V07 loc7         [V07,T06] (  3,  3   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
-;  V08 loc8         [V08,T01] (  5,  5   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
+;  V07 loc7         [V07,T05] (  3,  3   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
+;  V08 loc8         [V08,T00] (  5,  5   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
 ;  V09 OutArgs      [V09    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V10 tmp1         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <testout1>
 ;* V11 tmp2         [V11    ] (  0,  0   )     int  ->  zero-ref   
 ;* V12 tmp3         [V12    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V13 tmp4         [V13,T08] (  2,  2   )     int  ->   r8        
+;* V13 tmp4         [V13,T08] (  0,  0   )     int  ->  zero-ref   
 ;* V14 tmp5         [V14    ] (  0,  0   )     int  ->  zero-ref   
 ;* V15 tmp6         [V15    ] (  0,  0   )     int  ->  zero-ref    single-def
-;* V16 tmp7         [V16,T13] (  0,  0   )     int  ->  zero-ref   
+;* V16 tmp7         [V16,T12] (  0,  0   )     int  ->  zero-ref   
 ;* V17 tmp8         [V17    ] (  0,  0   )     int  ->  zero-ref   
-;  V18 tmp9         [V18,T09] (  2,  2   )     int  ->   r8         single-def
-;  V19 tmp10        [V19,T10] (  2,  2   )     int  ->   r9        
+;* V18 tmp9         [V18,T09] (  0,  0   )     int  ->  zero-ref    single-def
+;* V19 tmp10        [V19,T10] (  0,  0   )     int  ->  zero-ref   
 ;* V20 tmp11        [V20    ] (  0,  0   )     int  ->  zero-ref   
 ;* V21 tmp12        [V21    ] (  0,  0   )     int  ->  zero-ref   
 ;* V22 tmp13        [V22    ] (  0,  0   )     int  ->  zero-ref   
-;  V23 cse0         [V23,T11] (  2,  2   )     int  ->   r8         "CSE - aggressive"
-;  V24 cse1         [V24,T03] (  4,  4   )     int  ->  rax         "CSE - aggressive"
-;  V25 cse2         [V25,T04] (  4,  4   )     int  ->  r10         "CSE - aggressive"
-;  V26 cse3         [V26,T12] (  2,  2   )     int  ->  rcx         "CSE - aggressive"
-;  V27 cse4         [V27,T05] (  4,  4   )     int  ->  rdx         "CSE - aggressive"
-;  V28 cse5         [V28,T07] (  3,  3   )    long  ->  rcx         "CSE - aggressive"
+;* V23 cse0         [V23,T11] (  0,  0   )     int  ->  zero-ref    "CSE - aggressive"
+;* V24 cse1         [V24,T13] (  0,  0   )     int  ->  zero-ref    "CSE - aggressive"
+;  V25 cse2         [V25,T03] (  2,  2   )     int  ->  rax         "CSE - aggressive"
+;  V26 cse3         [V26,T04] (  2,  2   )     int  ->  rcx         "CSE - aggressive"
+;* V27 cse4         [V27,T06] (  0,  0   )     int  ->  zero-ref    "CSE - aggressive"
+;  V28 cse5         [V28,T07] (  2,  2   )    long  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -70,31 +70,18 @@ G_M10907_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      byte  ptr [(reloc)], 1      ; data for <unknown class>:<unknown field>
        mov      dword ptr [rbx+0x08], -13
        mov      word  ptr [rbx+0x0C], 256
-       mov      edx, dword ptr [rbx+0x08]
-       mov      r8d, edx
-       add      r8d, 17
-       mov      r10d, dword ptr [rax+0x14]
-       mov      r9d, r10d
-       add      r8d, r9d
+       mov      ecx, dword ptr [rax+0x14]
        mov      eax, dword ptr [rax+0x10]
        ; gcrRegs -[rax]
-       add      r8d, eax
-       mov      ecx, dword ptr [rcx]
-       add      r8d, edx
-       add      r8d, r10d
-       lea      r8d, [r8+rax+0x11]
-       add      ecx, r8d
-       add      ecx, edx
-       lea      r8d, [rcx+r10+0x0A]
-       add      eax, r8d
-						;; size=184 bbWeight=1 PerfScore 26.50
+       add      eax, ecx
+						;; size=140 bbWeight=1 PerfScore 18.25
 G_M10907_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 195, prolog size 5, PerfScore 29.50, instruction count 41, allocated bytes for code 195 (MethodHash=46f2d564) for method testout1:Sub_Funclet_195():int (FullOpts)
+; Total bytes of code 151, prolog size 5, PerfScore 21.25, instruction count 28, allocated bytes for code 151 (MethodHash=46f2d564) for method testout1:Sub_Funclet_195():int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-42</span> (<span style="color:green">-21.11%</span>) : 16253.dasm - testout1:Sub_Funclet_195():int (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -11,30 +11,31 @@
 ;* V00 loc0         [V00    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;* V01 loc1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 loc2         [V02,T02] (  4,  4   )     ref  ->  rbx         class-hnd exact single-def <testout1>
-;  V03 loc3         [V03,T01] (  5,  5   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
+;  V03 loc3         [V03,T01] (  4,  4   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <testout1>
 ;  V06 tmp2         [V06,T00] (  3,  6   )     ref  ->  rax         class-hnd exact single-def "dup spill" <<unknown class>>
 ;* V07 tmp3         [V07    ] (  0,  0   )     int  ->  zero-ref   
 ;* V08 tmp4         [V08    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V09 tmp5         [V09,T11] (  2,  2   )     int  ->   r8        
+;  V09 tmp5         [V09,T08] (  2,  2   )     int  ->  rcx        
 ;* V10 tmp6         [V10    ] (  0,  0   )     int  ->  zero-ref   
 ;* V11 tmp7         [V11    ] (  0,  0   )     int  ->  zero-ref    single-def
-;* V12 tmp8         [V12,T14] (  0,  0   )     int  ->  zero-ref   
+;* V12 tmp8         [V12,T15] (  0,  0   )     int  ->  zero-ref   
 ;* V13 tmp9         [V13    ] (  0,  0   )     int  ->  zero-ref   
-;  V14 tmp10        [V14,T12] (  2,  2   )     int  ->   r8         single-def
-;  V15 tmp11        [V15,T13] (  2,  2   )     int  ->   r9        
+;  V14 tmp10        [V14,T09] (  2,  2   )     int  ->  rcx         single-def
+;  V15 tmp11        [V15,T10] (  2,  2   )     int  ->  rax        
 ;* V16 tmp12        [V16    ] (  0,  0   )     int  ->  zero-ref   
 ;* V17 tmp13        [V17    ] (  0,  0   )     int  ->  zero-ref   
 ;* V18 tmp14        [V18    ] (  0,  0   )     int  ->  zero-ref   
-;  V19 tmp15        [V19,T06] (  2,  4   )     int  ->   r8         "impAppendStmt"
-;  V20 tmp16        [V20,T07] (  2,  4   )     int  ->  rcx         "impAppendStmt"
-;  V21 cse0         [V21,T03] (  4,  4   )     int  ->  rax         "CSE - aggressive"
-;  V22 cse1         [V22,T04] (  4,  4   )     int  ->  r10         "CSE - aggressive"
-;  V23 cse2         [V23,T08] (  3,  3   )     int  ->  rcx         "CSE - aggressive"
-;  V24 cse3         [V24,T05] (  4,  4   )     int  ->  rdx         "CSE - aggressive"
-;  V25 cse4         [V25,T09] (  3,  3   )    long  ->  rcx         "CSE - aggressive"
-;  V26 cse5         [V26,T10] (  2,  2   )    long  ->  rcx         "CSE - aggressive"
+;* V19 tmp15        [V19,T13] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
+;* V20 tmp16        [V20,T14] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
+;  V21 cse0         [V21,T03] (  2,  2   )     int  ->  rax         "CSE - aggressive"
+;* V22 cse1         [V22,T11] (  0,  0   )     int  ->  zero-ref    "CSE - aggressive"
+;* V23 cse2         [V23,T12] (  0,  0   )     int  ->  zero-ref    "CSE - aggressive"
+;  V24 cse3         [V24,T04] (  2,  2   )     int  ->  rax         "CSE - aggressive"
+;  V25 cse4         [V25,T05] (  2,  2   )     int  ->  rcx         "CSE - aggressive"
+;  V26 cse5         [V26,T06] (  2,  2   )    long  ->  rcx         "CSE - aggressive"
+;  V27 cse6         [V27,T07] (  2,  2   )    long  ->  rcx         "CSE - aggressive"
 ;
 ; Lcl frame size = 32
 
@@ -68,32 +69,20 @@ G_M10907_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      byte  ptr [(reloc)], 1      ; data for <unknown class>:<unknown field>
        mov      dword ptr [rbx+0x08], -13
        mov      word  ptr [rbx+0x0C], 256
-       mov      edx, dword ptr [rbx+0x08]
-       mov      r8d, edx
-       add      r8d, 17
-       mov      r10d, dword ptr [rax+0x14]
-       mov      r9d, r10d
-       add      r8d, r9d
-       mov      eax, dword ptr [rax+0x10]
+       mov      ecx, dword ptr [rbx+0x08]
+       add      ecx, 17
+       mov      eax, dword ptr [rax+0x14]
        ; gcrRegs -[rax]
-       add      r8d, eax
-       mov      ecx, dword ptr [rcx]
-       add      r8d, ecx
-       lea      r8d, [r8+rdx-0x07]
-       add      r8d, r10d
-       add      r8d, eax
-       add      ecx, r8d
-       lea      ecx, [rcx+rdx+0x0A]
-       add      ecx, r10d
-       lea      eax, [rcx+rax+0x11]
-						;; size=188 bbWeight=1 PerfScore 27.50
+       add      eax, ecx
+       add      eax, 17
+						;; size=146 bbWeight=1 PerfScore 18.75
 G_M10907_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
        ret      
 						;; size=6 bbWeight=1 PerfScore 1.75
 
-; Total bytes of code 199, prolog size 5, PerfScore 30.50, instruction count 42, allocated bytes for code 199 (MethodHash=46f2d564) for method testout1:Sub_Funclet_195():int (FullOpts)
+; Total bytes of code 157, prolog size 5, PerfScore 21.75, instruction count 30, allocated bytes for code 157 (MethodHash=46f2d564) for method testout1:Sub_Funclet_195():int (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+16</span> (<span style="color:red">+145.45%</span>) : 236381.dasm - JitTest_ldobj_V_ldobj_il.Test:method_4_0(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -19,15 +19,23 @@
 G_M47178_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M47178_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M47178_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, 2
+       cmp      eax, 1
+       jbe      SHORT G_M47178_IG04
        xor      eax, eax
-						;; size=2 bbWeight=1 PerfScore 0.25
+						;; size=12 bbWeight=1 PerfScore 1.75
 G_M47178_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
+G_M47178_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       call     CORINFO_HELP_RNGCHKFAIL
+       ; gcr arg pop 0
+       int3     
+						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 11, prolog size 4, PerfScore 1.75, instruction count 4, allocated bytes for code 11 (MethodHash=503b47b5) for method JitTest_ldobj_V_ldobj_il.Test:method_4_0(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)
+; Total bytes of code 27, prolog size 4, PerfScore 3.25, instruction count 9, allocated bytes for code 27 (MethodHash=503b47b5) for method JitTest_ldobj_V_ldobj_il.Test:method_4_0(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+16</span> (<span style="color:red">+145.45%</span>) : 236384.dasm - JitTest_ldobj_V_ldobj_il.Test:method_4_3(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -20,15 +20,23 @@
 G_M58793_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M58793_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M58793_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, 2
+       cmp      eax, 1
+       jbe      SHORT G_M58793_IG04
        xor      eax, eax
-						;; size=2 bbWeight=1 PerfScore 0.25
+						;; size=12 bbWeight=1 PerfScore 1.75
 G_M58793_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
+G_M58793_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       call     CORINFO_HELP_RNGCHKFAIL
+       ; gcr arg pop 0
+       int3     
+						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 11, prolog size 4, PerfScore 1.75, instruction count 4, allocated bytes for code 11 (MethodHash=37f81a56) for method JitTest_ldobj_V_ldobj_il.Test:method_4_3(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)
+; Total bytes of code 27, prolog size 4, PerfScore 3.25, instruction count 9, allocated bytes for code 27 (MethodHash=37f81a56) for method JitTest_ldobj_V_ldobj_il.Test:method_4_3(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+15</span> (<span style="color:red">+166.67%</span>) : 250088.dasm - Test.BB:TestEntryPoint() (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -18,12 +18,22 @@
 G_M52695_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
        sub      rsp, 40
 						;; size=4 bbWeight=1 PerfScore 0.25
-G_M52695_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+G_M52695_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
+       mov      eax, 1
+       test     eax, eax
+       je       SHORT G_M52695_IG04
+						;; size=9 bbWeight=1 PerfScore 1.50
+G_M52695_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
+G_M52695_IG04:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+       call     CORINFO_HELP_RNGCHKFAIL
+       ; gcr arg pop 0
+       int3     
+						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 9, prolog size 4, PerfScore 1.50, instruction count 3, allocated bytes for code 9 (MethodHash=459c3228) for method Test.BB:TestEntryPoint() (FullOpts)
+; Total bytes of code 24, prolog size 4, PerfScore 3.00, instruction count 8, allocated bytes for code 24 (MethodHash=459c3228) for method Test.BB:TestEntryPoint() (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries.crossgen2.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 255824.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
 ;* V02 arg2         [V02    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    "field V02.<Scope>k__BackingField (fldOffset=0x0)" P-INDEP
@@ -23,15 +23,14 @@ G_M22722_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22722_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x08]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M22722_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 143159.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Binder+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -19,15 +19,14 @@ G_M60118_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M60118_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M60118_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=a7181529) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=a7181529) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 83648.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__272_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,7 +10,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Binder+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -19,15 +19,14 @@ G_M35536_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M35536_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M35536_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=4501752f) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__272_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=4501752f) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__272_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+4.98%</span>) : 167253.dasm - System.Text.Json.Utf8JsonReader:GetNextSpan():ubyte:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,48 +8,54 @@
 ; No matching PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] ( 14, 16.50)   byref  ->  rbx         this single-def
-;  V01 loc0         [V01    ] (  3, 12.50)  struct (16) [rsp+0x40]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.ReadOnlyMemory`1[ubyte]>
-;  V02 loc1         [V02    ] (  3, 12.50)  struct (16) [rsp+0x30]  do-not-enreg[SB] <System.SequencePosition>
+;  V00 this         [V00,T04] ( 13,  9   )   byref  ->  rbx         this single-def
+;  V01 loc0         [V01    ] (  3, 12.50)  struct (16) [rsp+0x48]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.ReadOnlyMemory`1[ubyte]>
+;  V02 loc1         [V02    ] (  3, 12.50)  struct (16) [rsp+0x38]  do-not-enreg[SB] <System.SequencePosition>
 ;* V03 loc2         [V03    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V04 loc3         [V04    ] (  1,  0.50)  struct (16) [rsp+0x20]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.ReadOnlyMemory`1[ubyte]>
+;  V04 loc3         [V04    ] (  1,  0.50)  struct (16) [rsp+0x28]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.ReadOnlyMemory`1[ubyte]>
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06    ] (  3, 12.50)     ref  ->  [rsp+0x40]  do-not-enreg[X] addr-exposed "field V01._object (fldOffset=0x0)" P-DEP
-;  V07 tmp2         [V07    ] (  3, 12.50)     int  ->  [rsp+0x48]  do-not-enreg[X] addr-exposed "field V01._index (fldOffset=0x8)" P-DEP
-;  V08 tmp3         [V08    ] (  3, 12.50)     int  ->  [rsp+0x4C]  do-not-enreg[X] addr-exposed "field V01._length (fldOffset=0xc)" P-DEP
-;  V09 tmp4         [V09,T03] (  3, 12.50)     ref  ->  [rsp+0x30]  do-not-enreg[] "field V02._object (fldOffset=0x0)" P-DEP
-;  V10 tmp5         [V10,T04] (  3, 12.50)     int  ->  [rsp+0x38]  do-not-enreg[] "field V02._integer (fldOffset=0x8)" P-DEP
-;  V11 tmp6         [V11    ] (  1,  0.50)     ref  ->  [rsp+0x20]  do-not-enreg[X] addr-exposed "field V04._object (fldOffset=0x0)" P-DEP
-;  V12 tmp7         [V12    ] (  1,  0.50)     int  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V04._index (fldOffset=0x8)" P-DEP
-;  V13 tmp8         [V13    ] (  1,  0.50)     int  ->  [rsp+0x2C]  do-not-enreg[X] addr-exposed "field V04._length (fldOffset=0xc)" P-DEP
+;  V06 tmp1         [V06    ] (  3, 12.50)     ref  ->  [rsp+0x48]  do-not-enreg[X] addr-exposed "field V01._object (fldOffset=0x0)" P-DEP
+;  V07 tmp2         [V07    ] (  3, 12.50)     int  ->  [rsp+0x50]  do-not-enreg[X] addr-exposed "field V01._index (fldOffset=0x8)" P-DEP
+;  V08 tmp3         [V08    ] (  3, 12.50)     int  ->  [rsp+0x54]  do-not-enreg[X] addr-exposed "field V01._length (fldOffset=0xc)" P-DEP
+;  V09 tmp4         [V09,T02] (  3, 12.50)     ref  ->  [rsp+0x38]  do-not-enreg[] "field V02._object (fldOffset=0x0)" P-DEP
+;  V10 tmp5         [V10,T03] (  3, 12.50)     int  ->  [rsp+0x40]  do-not-enreg[] "field V02._integer (fldOffset=0x8)" P-DEP
+;  V11 tmp6         [V11    ] (  1,  0.50)     ref  ->  [rsp+0x28]  do-not-enreg[X] addr-exposed "field V04._object (fldOffset=0x0)" P-DEP
+;  V12 tmp7         [V12    ] (  1,  0.50)     int  ->  [rsp+0x30]  do-not-enreg[X] addr-exposed "field V04._index (fldOffset=0x8)" P-DEP
+;  V13 tmp8         [V13    ] (  1,  0.50)     int  ->  [rsp+0x34]  do-not-enreg[X] addr-exposed "field V04._length (fldOffset=0xc)" P-DEP
 ;  V14 cse0         [V14,T00] (  5, 21.50)   byref  ->  rbp         hoist "CSE - aggressive"
-;  V15 cse1         [V15,T02] (  4, 17.50)   byref  ->  r14         hoist "CSE - aggressive"
+;  V15 cse1         [V15,T01] (  4, 17.50)   byref  ->  r14         hoist "CSE - aggressive"
+;  V16 cse2         [V16,T05] (  3,  9.50)   byref  ->  r15         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 80
+; Lcl frame size = 88
 
 G_M26249_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 80
+       sub      rsp, 88
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        xorps    xmm4, xmm4
-       movaps   xmmword ptr [rsp+0x20], xmm4
        movaps   xmmword ptr [rsp+0x30], xmm4
        movaps   xmmword ptr [rsp+0x40], xmm4
+       mov      qword ptr [rsp+0x50], rax
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=31 bbWeight=1 PerfScore 11.83
+						;; size=40 bbWeight=1 PerfScore 13.08
 G_M26249_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        lea      rbp, bword ptr [rbx+0x70]
        ; byrRegs +[rbp]
        lea      r14, bword ptr [rbx+0x60]
        ; byrRegs +[r14]
-						;; size=8 bbWeight=1 PerfScore 1.00
-G_M26249_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=4028 {rbx rbp r14}, byref, nogc
+       lea      r15, bword ptr [rbx+0x80]
+       ; byrRegs +[r15]
+						;; size=15 bbWeight=1 PerfScore 1.50
+G_M26249_IG03:        ; bbWeight=8, gcrefRegs=0000 {}, byrefRegs=C028 {rbx rbp r14 r15}, byref, nogc
        movups   xmm0, xmmword ptr [rbp]
-       movups   xmmword ptr [rsp+0x30], xmm0
+       movups   xmmword ptr [rsp+0x38], xmm0
 						;; size=9 bbWeight=8 PerfScore 40.00
 G_M26249_IG04:        ; bbWeight=8, isz, extend
        mov      rdi, rbp
@@ -58,37 +64,37 @@ G_M26249_IG04:        ; bbWeight=8, isz, extend
        ; byrRegs +[rsi]
        call     [CORINFO_HELP_ASSIGN_BYREF]
        movsq    
-       lea      rcx, bword ptr [rbx+0x80]
+       mov      rcx, r15
        ; byrRegs +[rcx]
        mov      rdx, r14
        ; byrRegs +[rdx]
-       lea      r8, [rsp+0x40]
+       lea      r8, [rsp+0x48]
        mov      r9d, 1
        call     [<unknown method>]
        ; byrRegs -[rcx rdx rsi rdi]
        ; gcr arg pop 0
        test     eax, eax
        je       SHORT G_M26249_IG06
-						;; size=45 bbWeight=8 PerfScore 82.00
-G_M26249_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=4028 {rbx rbp r14}, byref, isz
-       lea      rcx, [rsp+0x40]
+						;; size=41 bbWeight=8 PerfScore 80.00
+G_M26249_IG05:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=C028 {rbx rbp r14 r15}, byref, isz
+       lea      rcx, [rsp+0x48]
        call     [<unknown method>]
        ; gcr arg pop 0
        test     eax, eax
        jne      SHORT G_M26249_IG08
        mov      rdi, rbp
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x30]
+       lea      rsi, bword ptr [rsp+0x38]
        ; byrRegs +[rsi]
        call     [CORINFO_HELP_ASSIGN_BYREF]
        movsq    
        jmp      SHORT G_M26249_IG03
 						;; size=33 bbWeight=4 PerfScore 46.00
 G_M26249_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0028 {rbx rbp}, byref
-       ; byrRegs -[rsi rdi r14]
+       ; byrRegs -[rsi rdi r14-r15]
        mov      rdi, rbp
        ; byrRegs +[rdi]
-       lea      rsi, bword ptr [rsp+0x30]
+       lea      rsi, bword ptr [rsp+0x38]
        ; byrRegs +[rsi]
        call     [CORINFO_HELP_ASSIGN_BYREF]
        ; byrRegs -[rbp]
@@ -97,35 +103,36 @@ G_M26249_IG06:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0028 {rbx rb
        xor      eax, eax
 						;; size=22 bbWeight=0.50 PerfScore 3.00
 G_M26249_IG07:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 80
+       add      rsp, 88
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M26249_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=4008 {rbx r14}, gcvars, byref, isz
-       ; byrRegs -[rsi rdi] +[r14]
+						;; size=13 bbWeight=0.50 PerfScore 2.12
+G_M26249_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=C008 {rbx r14 r15}, gcvars, byref, isz
+       ; byrRegs -[rsi rdi] +[r14-r15]
        cmp      byte  ptr [rbx+0x24], 0
        je       SHORT G_M26249_IG09
-       lea      rcx, bword ptr [rbx+0x80]
+       mov      rcx, r15
        ; byrRegs +[rcx]
        mov      rdx, r14
        ; byrRegs +[rdx]
-       lea      r8, [rsp+0x20]
+       lea      r8, [rsp+0x28]
        xor      r9d, r9d
        call     [<unknown method>]
-       ; byrRegs -[rcx rdx r14]
+       ; byrRegs -[rcx rdx r14-r15]
        ; gcr arg pop 0
        test     eax, eax
        sete     dl
        mov      byte  ptr [rbx+0x2A], dl
-						;; size=38 bbWeight=0.50 PerfScore 5.38
+						;; size=34 bbWeight=0.50 PerfScore 5.25
 G_M26249_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
        lea      rdx, bword ptr [rbx+0x30]
        ; byrRegs +[rdx]
-       lea      rcx, [rsp+0x40]
+       lea      rcx, [rsp+0x48]
        call     [<unknown method>]
        ; byrRegs -[rdx]
        ; gcr arg pop 0
@@ -136,16 +143,17 @@ G_M26249_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx},
        mov      eax, 1
 						;; size=33 bbWeight=0.50 PerfScore 6.25
 G_M26249_IG10:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 80
+       add      rsp, 88
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.88
+						;; size=13 bbWeight=0.50 PerfScore 2.12
 
-; Total bytes of code 241, prolog size 28, PerfScore 199.21, instruction count 73, allocated bytes for code 241 (MethodHash=b36f9976) for method System.Text.Json.Utf8JsonReader:GetNextSpan():ubyte:this (FullOpts)
+; Total bytes of code 253, prolog size 37, PerfScore 199.33, instruction count 79, allocated bytes for code 253 (MethodHash=b36f9976) for method System.Text.Json.Utf8JsonReader:GetNextSpan():ubyte:this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -153,14 +161,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 9 * 8 + 8 = 80 = 0x50
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 10 * 8 + 8 = 88 = 0x58
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+5.49%</span>) : 22193.dasm - System.__DTString:SkipWhiteSpaces():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; 0 inlinees with PGO data; 4 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 10, 28   )   byref  ->  rbx         this single-def
+;  V00 this         [V00,T00] ( 10, 24.50)   byref  ->  rbx         this single-def
 ;  V01 loc0         [V01,T03] (  4, 12   )  ushort  ->  rcx        
 ;  V02 OutArgs      [V02    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
@@ -23,65 +23,72 @@
 ;* V11 tmp9         [V11    ] (  0,  0   )     int  ->  zero-ref    "field V07._length (fldOffset=0x8)" P-INDEP
 ;* V12 tmp10        [V12    ] (  0,  0   )   byref  ->  zero-ref    "field V08._reference (fldOffset=0x0)" P-INDEP
 ;* V13 tmp11        [V13    ] (  0,  0   )     int  ->  zero-ref    "field V08._length (fldOffset=0x8)" P-INDEP
+;  V14 cse0         [V14,T05] (  2,  4.50)   byref  ->  rsi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M9890_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     rsi
        push     rbx
-       sub      rsp, 32
+       sub      rsp, 40
        mov      rbx, rcx
        ; byrRegs +[rbx]
-						;; size=8 bbWeight=1 PerfScore 1.50
+						;; size=9 bbWeight=1 PerfScore 2.50
 G_M9890_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        mov      ecx, dword ptr [rbx+0x08]
        inc      ecx
        cmp      ecx, dword ptr [rbx+0x18]
-       jge      SHORT G_M9890_IG07
+       jge      SHORT G_M9890_IG08
 						;; size=10 bbWeight=1 PerfScore 6.25
-G_M9890_IG03:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M9890_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       lea      rsi, bword ptr [rbx+0x10]
+       ; byrRegs +[rsi]
+						;; size=4 bbWeight=0.50 PerfScore 0.25
+G_M9890_IG04:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
        mov      ecx, dword ptr [rbx+0x08]
        inc      ecx
-       lea      rax, bword ptr [rbx+0x10]
+       mov      rax, rsi
        ; byrRegs +[rax]
        cmp      ecx, dword ptr [rax+0x08]
-       jae      SHORT G_M9890_IG08
+       jae      SHORT G_M9890_IG09
        mov      rax, bword ptr [rax]
        movzx    rcx, word  ptr [rax+2*rcx]
        cmp      ecx, 256
-       jae      SHORT G_M9890_IG05
-						;; size=29 bbWeight=4 PerfScore 48.00
-G_M9890_IG04:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+       jae      SHORT G_M9890_IG06
+						;; size=28 bbWeight=4 PerfScore 47.00
+G_M9890_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
        ; byrRegs -[rax]
        call     [System.Char:IsWhiteSpaceLatin1(ushort):ubyte]
        ; gcr arg pop 0
-       jmp      SHORT G_M9890_IG06
+       jmp      SHORT G_M9890_IG07
 						;; size=8 bbWeight=2 PerfScore 10.00
-G_M9890_IG05:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M9890_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref
        call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
        ; gcr arg pop 0
 						;; size=6 bbWeight=2 PerfScore 6.00
-G_M9890_IG06:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M9890_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
        test     eax, eax
-       je       SHORT G_M9890_IG07
+       je       SHORT G_M9890_IG08
        inc      dword ptr [rbx+0x08]
        mov      eax, dword ptr [rbx+0x08]
        inc      eax
        cmp      eax, dword ptr [rbx+0x18]
-       jl       SHORT G_M9890_IG03
+       jl       SHORT G_M9890_IG04
 						;; size=17 bbWeight=4 PerfScore 42.00
-G_M9890_IG07:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
-       ; byrRegs -[rbx]
-       add      rsp, 32
+G_M9890_IG08:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
+       ; byrRegs -[rbx rsi]
+       add      rsp, 40
        pop      rbx
+       pop      rsi
        ret      
-						;; size=6 bbWeight=1 PerfScore 1.75
-G_M9890_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
+						;; size=7 bbWeight=1 PerfScore 2.25
+G_M9890_IG09:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
        call     [CORINFO_HELP_RNGCHKFAIL]
        ; gcr arg pop 0
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 91, prolog size 5, PerfScore 115.50, instruction count 31, allocated bytes for code 91 (MethodHash=4fd7d95d) for method System.__DTString:SkipWhiteSpaces():this (FullOpts)
+; Total bytes of code 96, prolog size 6, PerfScore 116.25, instruction count 34, allocated bytes for code 96 (MethodHash=4fd7d95d) for method System.__DTString:SkipWhiteSpaces():this (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -89,10 +96,11 @@ Unwind Info:
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
<summary><span style="color:red">+9</span> (<span style="color:red">+6.62%</span>) : 154267.dasm - System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -10,40 +10,44 @@
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T05] (  3,  4   )     ref  ->  rsi         class-hnd single-def <System.Xml.XmlAttribute>
-;  V01 arg1         [V01,T02] (  5,  9   )     ref  ->  rbx         class-hnd single-def <System.Xml.XmlAttributeCollection>
+;  V01 arg1         [V01,T04] (  5,  5.50)     ref  ->  rbx         class-hnd single-def <System.Xml.XmlAttributeCollection>
 ;  V02 arg2         [V02,T07] (  4,  3   )   byref  ->  rdi         single-def
 ;  V03 loc0         [V03,T01] (  6, 11   )     int  ->  rbp        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T03] (  4, 10   )     int  ->  r14         "Inline return value spill temp"
+;  V05 tmp1         [V05,T02] (  4, 10   )     int  ->  r15         "Inline return value spill temp"
 ;  V06 tmp2         [V06,T00] (  2, 16   )   byref  ->  rcx         "Inlining Arg"
 ;  V07 tmp3         [V07,T06] (  3,  6   )     ref  ->  rax         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V08 cse0         [V08,T04] (  3, 10   )     ref  ->  rcx         "CSE - aggressive"
+;  V08 cse0         [V08,T08] (  2,  4.50)   byref  ->  r14         hoist "CSE - aggressive"
+;  V09 cse1         [V09,T03] (  3, 10   )     ref  ->  rcx         "CSE - aggressive"
 ;
-; Lcl frame size = 32
+; Lcl frame size = 40
 
 G_M25105_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
+       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 32
+       sub      rsp, 40
        mov      rsi, rcx
        ; gcrRegs +[rsi]
        mov      rbx, rdx
        ; gcrRegs +[rbx]
        mov      rdi, r8
        ; byrRegs +[rdi]
-						;; size=19 bbWeight=1 PerfScore 6.00
+						;; size=21 bbWeight=1 PerfScore 7.00
 G_M25105_IG02:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
        test     rbx, rbx
        je       SHORT G_M25105_IG10
 						;; size=5 bbWeight=1 PerfScore 1.25
 G_M25105_IG03:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
        xor      ebp, ebp
+       lea      r14, bword ptr [rbx+0x10]
+       ; byrRegs +[r14]
        jmp      SHORT G_M25105_IG05
-						;; size=4 bbWeight=0.50 PerfScore 1.12
-G_M25105_IG04:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
+						;; size=8 bbWeight=0.50 PerfScore 1.38
+G_M25105_IG04:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=4080 {rdi r14}, byref, isz
        mov      rcx, rbx
        ; gcrRegs +[rcx]
        mov      edx, ebp
@@ -54,22 +58,22 @@ G_M25105_IG04:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rd
        je       SHORT G_M25105_IG12
        inc      ebp
 						;; size=18 bbWeight=2 PerfScore 10.00
-G_M25105_IG05:        ; bbWeight=4, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
+G_M25105_IG05:        ; bbWeight=4, gcrefRegs=0048 {rbx rsi}, byrefRegs=4080 {rdi r14}, byref, isz
        ; gcrRegs -[rax]
-       lea      rcx, bword ptr [rbx+0x10]
+       mov      rcx, r14
        ; byrRegs +[rcx]
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
        test     rcx, rcx
        jne      SHORT G_M25105_IG07
-						;; size=12 bbWeight=4 PerfScore 15.00
-G_M25105_IG06:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
+						;; size=11 bbWeight=4 PerfScore 14.00
+G_M25105_IG06:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=4080 {rdi r14}, byref, isz
        ; gcrRegs -[rcx]
-       xor      r14d, r14d
+       xor      r15d, r15d
        jmp      SHORT G_M25105_IG09
 						;; size=5 bbWeight=2 PerfScore 4.50
-G_M25105_IG07:        ; bbWeight=2, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
+G_M25105_IG07:        ; bbWeight=2, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=4080 {rdi r14}, byref, isz
        ; gcrRegs +[rcx]
        call     [CORINFO_HELP_READYTORUN_ISINSTANCEOF]
        ; gcrRegs -[rcx] +[rax]
@@ -82,47 +86,50 @@ G_M25105_IG07:        ; bbWeight=2, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0080
        call     [r11]<unknown method>
        ; gcrRegs -[rax rcx]
        ; gcr arg pop 0
-       mov      r14d, eax
+       mov      r15d, eax
        jmp      SHORT G_M25105_IG09
 						;; size=29 bbWeight=2 PerfScore 20.50
-G_M25105_IG08:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref
-       mov      r14d, 1
+G_M25105_IG08:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=4080 {rdi r14}, byref
+       mov      r15d, 1
 						;; size=6 bbWeight=2 PerfScore 0.50
-G_M25105_IG09:        ; bbWeight=4, gcrefRegs=0048 {rbx rsi}, byrefRegs=0080 {rdi}, byref, isz
-       cmp      ebp, r14d
+G_M25105_IG09:        ; bbWeight=4, gcrefRegs=0048 {rbx rsi}, byrefRegs=4080 {rdi r14}, byref, isz
+       cmp      ebp, r15d
        jl       SHORT G_M25105_IG04
 						;; size=5 bbWeight=4 PerfScore 5.00
 G_M25105_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0080 {rdi}, byref
        ; gcrRegs -[rbx rsi]
+       ; byrRegs -[r14]
        xor      eax, eax
        mov      dword ptr [rdi], eax
 						;; size=4 bbWeight=0.50 PerfScore 0.62
 G_M25105_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, epilog, nogc
        ; byrRegs -[rdi]
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.88
+						;; size=13 bbWeight=0.50 PerfScore 2.12
 G_M25105_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0080 {rdi}, gcvars, byref
        ; byrRegs +[rdi]
        mov      dword ptr [rdi], ebp
        mov      eax, 1
 						;; size=7 bbWeight=0.50 PerfScore 0.62
 G_M25105_IG13:        ; bbWeight=0.50, epilog, nogc, extend
-       add      rsp, 32
+       add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0.50 PerfScore 1.88
+						;; size=13 bbWeight=0.50 PerfScore 2.12
 
-; Total bytes of code 136, prolog size 10, PerfScore 68.88, instruction count 54, allocated bytes for code 136 (MethodHash=8a1b9dee) for method System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
+; Total bytes of code 145, prolog size 12, PerfScore 69.62, instruction count 58, allocated bytes for code 145 (MethodHash=8a1b9dee) for method System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
 ; ============================================================
 
 Unwind Info:
@@ -130,14 +137,15 @@ Unwind Info:
   >>   End offset   : 0xd1ffab1e (not in unwind data)
   Version           : 1
   Flags             : 0x00
-  SizeOfProlog      : 0x0A
-  CountOfUnwindCodes: 6
+  SizeOfProlog      : 0x0C
+  CountOfUnwindCodes: 7
   FrameRegister     : none (0)
   FrameOffset       : N/A (no FrameRegister) (Value=0)
   UnwindCodes       :
-    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 3 * 8 + 8 = 32 = 0x20
-    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
-    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
-    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
-    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
-    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x0C UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 4 * 8 + 8 = 40 = 0x28
+    CodeOffset: 0x08 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x07 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r15 (15)

```


</div></details>


</div></details>

<details>
<summary>libraries.pmi.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-33.33%</span>) : 5665.dasm - <StartupCode$FSharp-Core>.$Async+Return@1406[ubyte]:.ctor(ubyte):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <<StartupCode$FSharp-Core>.$Async+Return@1406[ubyte]>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <<StartupCode$FSharp-Core>.$Async+Return@1406[ubyte]>
 ;  V01 arg1         [V01,T01] (  3,  3   )   ubyte  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
@@ -18,14 +18,13 @@ G_M40599_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M40599_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        mov      byte  ptr [rcx+0x08], dl
-						;; size=5 bbWeight=1 PerfScore 4.00
+						;; size=3 bbWeight=1 PerfScore 1.00
 G_M40599_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 6, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 6 (MethodHash=4ef06168) for method <StartupCode$FSharp-Core>.$Async+Return@1406[ubyte]:.ctor(ubyte):this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 2.00, instruction count 2, allocated bytes for code 4 (MethodHash=4ef06168) for method <StartupCode$FSharp-Core>.$Async+Return@1406[ubyte]:.ctor(ubyte):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-33.33%</span>) : 5953.dasm - <StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1957-2[int]:.ctor(int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <<StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1957-2[int]>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <<StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1957-2[int]>
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
@@ -18,14 +18,13 @@ G_M28808_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M28808_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        mov      dword ptr [rcx+0x08], edx
-						;; size=5 bbWeight=1 PerfScore 4.00
+						;; size=3 bbWeight=1 PerfScore 1.00
 G_M28808_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 6, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 6 (MethodHash=f71c8f77) for method <StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1957-2[int]:.ctor(int):this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 2.00, instruction count 2, allocated bytes for code 4 (MethodHash=f71c8f77) for method <StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1957-2[int]:.ctor(int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-33.33%</span>) : 6817.dasm - Microsoft.FSharp.Quotations.PatternsModule+u_dtype@1904:.ctor(int):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <Microsoft.FSharp.Quotations.PatternsModule+u_dtype@1904>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.FSharp.Quotations.PatternsModule+u_dtype@1904>
 ;  V01 arg1         [V01,T01] (  3,  3   )     int  ->  rdx         single-def
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
@@ -18,14 +18,13 @@ G_M23439_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M23439_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        mov      dword ptr [rcx+0x08], edx
-						;; size=5 bbWeight=1 PerfScore 4.00
+						;; size=3 bbWeight=1 PerfScore 1.00
 G_M23439_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 6, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 6 (MethodHash=b526a470) for method Microsoft.FSharp.Quotations.PatternsModule+u_dtype@1904:.ctor(int):this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 2.00, instruction count 2, allocated bytes for code 4 (MethodHash=b526a470) for method Microsoft.FSharp.Quotations.PatternsModule+u_dtype@1904:.ctor(int):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+12</span> (<span style="color:red">+8.51%</span>) : 210646.dasm - System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -48,17 +48,20 @@ G_M35432_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byr
        call     [<unknown method>]
        ; gcrRegs -[rax rcx rbx r8]
        ; gcr arg pop 0
-       movzx    rax, word  ptr [rdi+0x10]
+       movsx    rax, word  ptr [rdi+0x10]
+       movzx    rax, ax
        imul     rax, rax, 0xE10
-       movzx    rcx, word  ptr [rdi+0x12]
+       movsx    rcx, word  ptr [rdi+0x12]
+       movzx    rcx, cx
        imul     rcx, rcx, 60
        add      rax, rcx
-       movzx    rcx, word  ptr [rdi+0x14]
+       movsx    rcx, word  ptr [rdi+0x14]
+       movzx    rcx, cx
        add      rax, rcx
        mov      rcx, 0xD1FFAB1E
        cmp      rax, rcx
        jg       SHORT G_M35432_IG06
-						;; size=92 bbWeight=1 PerfScore 18.75
+						;; size=104 bbWeight=1 PerfScore 25.50
 G_M35432_IG03:        ; bbWeight=0.99, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rdi]
        mov      rcx, 0xD1FFAB1E
@@ -81,7 +84,7 @@ G_M35432_IG06:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 141, prolog size 7, PerfScore 28.74, instruction count 37, allocated bytes for code 141 (MethodHash=d1537597) for method System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)
+; Total bytes of code 153, prolog size 7, PerfScore 35.49, instruction count 40, allocated bytes for code 153 (MethodHash=d1537597) for method System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 245543.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M22035_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22035_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M22035_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 245545.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M17231_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>libraries_tests.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 122726.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
 ;* V02 arg2         [V02    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    "field V02.<Scope>k__BackingField (fldOffset=0x0)" P-INDEP
@@ -22,15 +22,14 @@ G_M22722_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22722_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x08]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M22722_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (Tier1)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 62791.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Binder+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -18,15 +18,14 @@ G_M60118_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M60118_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M60118_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=a7181529) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (Tier1)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=a7181529) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 65199.dasm - Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Interop.ComInterfaceGenerator+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Interop.ComMethodContext>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Interop.ComMethodContext>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;
@@ -19,15 +19,14 @@ G_M46963_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M46963_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x40]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M46963_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=4925488c) for method Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (Tier1)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=4925488c) for method Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (Tier1)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+35</span> (<span style="color:red">+8.56%</span>) : 340011.dasm - System.Threading.CancellationTokenSource+Registrations:Unregister(long,System.Threading.CancellationTokenSource+CallbackNode):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,36 +9,33 @@
 ; 1 inlinees with PGO data; 4 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] ( 14,  9.61)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Threading.CancellationTokenSource+Registrations>
-;  V01 arg1         [V01,T02] (  4,  4   )    long  ->  rdi         single-def
+;  V00 this         [V00,T01] ( 13,  8.61)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Threading.CancellationTokenSource+Registrations>
+;  V01 arg1         [V01,T02] (  4,  4   )    long  ->  rsi         single-def
 ;  V02 arg2         [V02,T00] ( 22, 11.26)     ref  ->  rbx         class-hnd single-def <System.Threading.CancellationTokenSource+CallbackNode>
-;  V03 loc0         [V03,T04] (  3,  2   )   ubyte  ->  rdi        
+;  V03 loc0         [V03,T04] (  3,  2   )   ubyte  ->  rsi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp2         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp3         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp4         [V08,T03] (  3,  2   )   byref  ->  rcx         single-def "Inline stloc first use temp"
+;  V08 tmp4         [V08,T03] (  3,  2   )   byref  ->  rax         single-def "Inline stloc first use temp"
 ;  V09 PSPSym       [V09,T05] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
 G_M9383_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbp
-       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 48
        lea      rbp, [rsp+0x40]
        mov      qword ptr [rbp-0x20], rsp
        mov      gword ptr [rbp+0x10], rcx
        ; GC ptr vars +{V00}
-       mov      rsi, rcx
-       ; gcrRegs +[rsi]
-       mov      rdi, rdx
+       mov      rsi, rdx
        mov      rbx, r8
        ; gcrRegs +[rbx]
-						;; size=30 bbWeight=1 PerfScore 7.50
-G_M9383_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V00}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+						;; size=26 bbWeight=1 PerfScore 6.25
+G_M9383_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V00}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        test     rbx, rbx
        jne      SHORT G_M9383_IG03
        mov      rcx, 0xD1FFAB1E
@@ -49,57 +46,63 @@ G_M9383_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V00}, gcrefRegs=0048
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
 						;; size=31 bbWeight=1 PerfScore 4.75
-G_M9383_IG03:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      gword ptr [rbx+0x08], rsi
+G_M9383_IG03:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       cmp      gword ptr [rbx+0x08], rcx
        je       SHORT G_M9383_IG04
        mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-						;; size=32 bbWeight=1 PerfScore 7.50
-G_M9383_IG04:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       test     rdi, rdi
+						;; size=36 bbWeight=1 PerfScore 8.50
+G_M9383_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       test     rsi, rsi
        je       G_M9383_IG19
-       cmp      byte  ptr [rsi], sil
-       lea      rcx, bword ptr [rsi+0x34]
-       ; byrRegs +[rcx]
-       mov      eax, 1
-       xchg     dword ptr [rcx], eax
-       test     eax, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       lea      rax, bword ptr [rcx+0x34]
+       ; byrRegs +[rax]
+       mov      edx, 1
+       xchg     dword ptr [rax], edx
+       test     edx, edx
        jne      G_M9383_IG21
-						;; size=31 bbWeight=1 PerfScore 26.25
-G_M9383_IG05:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[rcx]
-       cmp      qword ptr [rbx+0x40], rdi
+						;; size=32 bbWeight=1 PerfScore 24.25
+G_M9383_IG05:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[rax]
+       cmp      qword ptr [rbx+0x40], rsi
        jne      SHORT G_M9383_IG07
 						;; size=6 bbWeight=1 PerfScore 4.00
-G_M9383_IG06:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      gword ptr [rsi+0x10], rbx
+G_M9383_IG06:        ; bbWeight=0.52, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
+       cmp      gword ptr [rcx+0x10], rbx
        jne      SHORT G_M9383_IG08
        xor      ecx, ecx
+       ; gcrRegs -[rcx]
        cmp      gword ptr [rbx+0x10], 0
        sete     cl
        call     [<unknown method>]
        ; gcr arg pop 0
        mov      rdx, gword ptr [rbx+0x18]
        ; gcrRegs +[rdx]
-       lea      rcx, bword ptr [rsi+0x10]
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       lea      rcx, bword ptr [rcx+0x10]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        jmp      SHORT G_M9383_IG09
-						;; size=37 bbWeight=0.52 PerfScore 8.74
-G_M9383_IG07:        ; bbWeight=0.48, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
-       ; gcrRegs -[rbx]
-       xor      edi, edi
+						;; size=41 bbWeight=0.52 PerfScore 9.26
+G_M9383_IG07:        ; bbWeight=0.48, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rbx] +[rcx]
+       xor      esi, esi
        jmp      G_M9383_IG17
 						;; size=7 bbWeight=0.48 PerfScore 1.08
-G_M9383_IG08:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       ; gcrRegs +[rbx]
+G_M9383_IG08:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       ; gcrRegs -[rcx] +[rbx]
        xor      ecx, ecx
        cmp      gword ptr [rbx+0x10], 0
        setne    cl
@@ -116,11 +119,11 @@ G_M9383_IG08:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M9383_IG09:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+G_M9383_IG09:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        cmp      gword ptr [rbx+0x18], 0
        je       SHORT G_M9383_IG11
 						;; size=7 bbWeight=0.52 PerfScore 2.09
-G_M9383_IG10:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG10:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rcx, gword ptr [rbx+0x18]
        ; gcrRegs +[rcx]
        lea      rcx, bword ptr [rcx+0x10]
@@ -132,118 +135,134 @@ G_M9383_IG10:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M9383_IG11:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       xor      ecx, ecx
-       cmp      dword ptr [rsi+0x34], 1
+G_M9383_IG11:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       cmp      dword ptr [rcx+0x34], 1
        sete     cl
+       ; gcrRegs -[rcx]
+       movzx    rcx, cl
        call     [<unknown method>]
        ; gcr arg pop 0
        xor      ecx, ecx
        mov      qword ptr [rbx+0x40], rcx
-						;; size=21 bbWeight=0.52 PerfScore 4.43
-G_M9383_IG12:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+						;; size=26 bbWeight=0.52 PerfScore 4.96
+G_M9383_IG12:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x20], rcx
 						;; size=4 bbWeight=0.52 PerfScore 0.52
-G_M9383_IG13:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG13:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x28], rcx
 						;; size=4 bbWeight=0.52 PerfScore 0.52
-G_M9383_IG14:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG14:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x30], rcx
 						;; size=4 bbWeight=0.52 PerfScore 0.52
-G_M9383_IG15:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG15:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x38], rcx
 						;; size=4 bbWeight=0.52 PerfScore 0.52
-G_M9383_IG16:        ; bbWeight=0.52, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG16:        ; bbWeight=0.52, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x10], rcx
-       mov      rdx, gword ptr [rsi+0x18]
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       mov      rdx, gword ptr [rcx+0x18]
        ; gcrRegs +[rdx]
        lea      rcx, bword ptr [rbx+0x18]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       lea      rcx, bword ptr [rsi+0x18]
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       lea      rcx, bword ptr [rcx+0x18]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        mov      rdx, rbx
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx rbx]
        ; byrRegs -[rcx]
-       mov      edi, 1
-						;; size=34 bbWeight=0.52 PerfScore 3.39
-G_M9383_IG17:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
-       xor      ecx, ecx
-       cmp      dword ptr [rsi+0x34], 1
+       mov      esi, 1
+						;; size=42 bbWeight=0.52 PerfScore 4.43
+G_M9383_IG17:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       cmp      dword ptr [rcx+0x34], 1
        sete     cl
+       ; gcrRegs -[rcx]
+       movzx    rcx, cl
        call     [<unknown method>]
        ; gcr arg pop 0
        xor      eax, eax
-       mov      dword ptr [rsi+0x34], eax
-       mov      eax, edi
-						;; size=22 bbWeight=1 PerfScore 8.75
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       mov      dword ptr [rcx+0x34], eax
+       mov      eax, esi
+						;; size=31 bbWeight=1 PerfScore 10.75
 G_M9383_IG18:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 48
        pop      rbx
        pop      rsi
-       pop      rdi
        pop      rbp
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
+						;; size=8 bbWeight=1 PerfScore 2.75
 G_M9383_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rsi]
+       ; gcrRegs -[rcx]
        ; GC ptr vars -{V00}
        xor      eax, eax
...

```


</div></details>

<details>
<summary><span style="color:red">+35</span> (<span style="color:red">+8.56%</span>) : 129169.dasm - System.Threading.CancellationTokenSource+Registrations:Unregister(long,System.Threading.CancellationTokenSource+CallbackNode):ubyte:this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -9,36 +9,33 @@
 ; 1 inlinees with PGO data; 4 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T01] ( 14,  9.50)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Threading.CancellationTokenSource+Registrations>
-;  V01 arg1         [V01,T02] (  4,  4   )    long  ->  rdi         single-def
+;  V00 this         [V00,T01] ( 13,  8.50)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Threading.CancellationTokenSource+Registrations>
+;  V01 arg1         [V01,T02] (  4,  4   )    long  ->  rsi         single-def
 ;  V02 arg2         [V02,T00] ( 22, 11   )     ref  ->  rbx         class-hnd single-def <System.Threading.CancellationTokenSource+CallbackNode>
-;  V03 loc0         [V03,T04] (  3,  2   )   ubyte  ->  rdi        
+;  V03 loc0         [V03,T04] (  3,  2   )   ubyte  ->  rsi        
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V06 tmp2         [V06    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V07 tmp3         [V07    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V08 tmp4         [V08,T03] (  3,  2   )   byref  ->  rcx         single-def "Inline stloc first use temp"
+;  V08 tmp4         [V08,T03] (  3,  2   )   byref  ->  rax         single-def "Inline stloc first use temp"
 ;  V09 PSPSym       [V09,T05] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 48
 
 G_M9383_IG01:        ; bbWeight=1, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref, nogc <-- Prolog IG
        push     rbp
-       push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 48
        lea      rbp, [rsp+0x40]
        mov      qword ptr [rbp-0x20], rsp
        mov      gword ptr [rbp+0x10], rcx
        ; GC ptr vars +{V00}
-       mov      rsi, rcx
-       ; gcrRegs +[rsi]
-       mov      rdi, rdx
+       mov      rsi, rdx
        mov      rbx, r8
        ; gcrRegs +[rbx]
-						;; size=30 bbWeight=1 PerfScore 7.50
-G_M9383_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V00}, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, gcvars, byref, isz
+						;; size=26 bbWeight=1 PerfScore 6.25
+G_M9383_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V00}, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, gcvars, byref, isz
        test     rbx, rbx
        jne      SHORT G_M9383_IG03
        mov      rcx, 0xD1FFAB1E
@@ -49,57 +46,63 @@ G_M9383_IG02:        ; bbWeight=1, gcVars=0000000000000002 {V00}, gcrefRegs=0048
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
 						;; size=31 bbWeight=1 PerfScore 4.75
-G_M9383_IG03:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       cmp      gword ptr [rbx+0x08], rsi
+G_M9383_IG03:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       cmp      gword ptr [rbx+0x08], rcx
        je       SHORT G_M9383_IG04
        mov      rcx, 0xD1FFAB1E
-       ; gcrRegs +[rcx]
        mov      rdx, 0xD1FFAB1E
        ; gcrRegs +[rdx]
        call     [<unknown method>]
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
-						;; size=32 bbWeight=1 PerfScore 7.50
-G_M9383_IG04:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       test     rdi, rdi
+						;; size=36 bbWeight=1 PerfScore 8.50
+G_M9383_IG04:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       test     rsi, rsi
        je       G_M9383_IG19
-       cmp      byte  ptr [rsi], sil
-       lea      rcx, bword ptr [rsi+0x34]
-       ; byrRegs +[rcx]
-       mov      eax, 1
-       xchg     dword ptr [rcx], eax
-       test     eax, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       lea      rax, bword ptr [rcx+0x34]
+       ; byrRegs +[rax]
+       mov      edx, 1
+       xchg     dword ptr [rax], edx
+       test     edx, edx
        jne      G_M9383_IG21
-						;; size=31 bbWeight=1 PerfScore 26.25
-G_M9383_IG05:        ; bbWeight=1, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
-       ; byrRegs -[rcx]
-       cmp      qword ptr [rbx+0x40], rdi
+						;; size=32 bbWeight=1 PerfScore 24.25
+G_M9383_IG05:        ; bbWeight=1, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
+       ; byrRegs -[rax]
+       cmp      qword ptr [rbx+0x40], rsi
        je       SHORT G_M9383_IG07
 						;; size=6 bbWeight=1 PerfScore 4.00
-G_M9383_IG06:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG06:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx]
-       xor      edi, edi
+       xor      esi, esi
        jmp      G_M9383_IG17
 						;; size=7 bbWeight=0.50 PerfScore 1.12
-G_M9383_IG07:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+G_M9383_IG07:        ; bbWeight=0.50, gcrefRegs=000A {rcx rbx}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rbx]
-       cmp      gword ptr [rsi+0x10], rbx
+       cmp      gword ptr [rcx+0x10], rbx
        jne      SHORT G_M9383_IG08
        xor      ecx, ecx
+       ; gcrRegs -[rcx]
        cmp      gword ptr [rbx+0x10], 0
        sete     cl
        call     [<unknown method>]
        ; gcr arg pop 0
        mov      rdx, gword ptr [rbx+0x18]
        ; gcrRegs +[rdx]
-       lea      rcx, bword ptr [rsi+0x10]
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       lea      rcx, bword ptr [rcx+0x10]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
        jmp      SHORT G_M9383_IG09
-						;; size=37 bbWeight=0.50 PerfScore 8.38
-G_M9383_IG08:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+						;; size=41 bbWeight=0.50 PerfScore 8.88
+G_M9383_IG08:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        xor      ecx, ecx
        cmp      gword ptr [rbx+0x10], 0
        setne    cl
@@ -116,11 +119,11 @@ G_M9383_IG08:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M9383_IG09:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref, isz
+G_M9383_IG09:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref, isz
        cmp      gword ptr [rbx+0x18], 0
        je       SHORT G_M9383_IG11
 						;; size=7 bbWeight=0.50 PerfScore 2.00
-G_M9383_IG10:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG10:        ; bbWeight=0, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      rcx, gword ptr [rbx+0x18]
        ; gcrRegs +[rcx]
        lea      rcx, bword ptr [rcx+0x10]
@@ -132,118 +135,134 @@ G_M9383_IG10:        ; bbWeight=0, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {},
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M9383_IG11:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
-       xor      ecx, ecx
-       cmp      dword ptr [rsi+0x34], 1
+G_M9383_IG11:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       cmp      dword ptr [rcx+0x34], 1
        sete     cl
+       ; gcrRegs -[rcx]
+       movzx    rcx, cl
        call     [<unknown method>]
        ; gcr arg pop 0
        xor      ecx, ecx
        mov      qword ptr [rbx+0x40], rcx
-						;; size=21 bbWeight=0.50 PerfScore 4.25
-G_M9383_IG12:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+						;; size=26 bbWeight=0.50 PerfScore 4.75
+G_M9383_IG12:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x20], rcx
 						;; size=4 bbWeight=0.50 PerfScore 0.50
-G_M9383_IG13:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG13:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x28], rcx
 						;; size=4 bbWeight=0.50 PerfScore 0.50
-G_M9383_IG14:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG14:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x30], rcx
 						;; size=4 bbWeight=0.50 PerfScore 0.50
-G_M9383_IG15:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG15:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x38], rcx
 						;; size=4 bbWeight=0.50 PerfScore 0.50
-G_M9383_IG16:        ; bbWeight=0.50, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+G_M9383_IG16:        ; bbWeight=0.50, gcrefRegs=0008 {rbx}, byrefRegs=0000 {}, byref
        mov      gword ptr [rbx+0x10], rcx
-       mov      rdx, gword ptr [rsi+0x18]
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       mov      rdx, gword ptr [rcx+0x18]
        ; gcrRegs +[rdx]
        lea      rcx, bword ptr [rbx+0x18]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx]
        ; byrRegs -[rcx]
-       lea      rcx, bword ptr [rsi+0x18]
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       lea      rcx, bword ptr [rcx+0x18]
+       ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        mov      rdx, rbx
        ; gcrRegs +[rdx]
        call     CORINFO_HELP_ASSIGN_REF
        ; gcrRegs -[rdx rbx]
        ; byrRegs -[rcx]
-       mov      edi, 1
-						;; size=34 bbWeight=0.50 PerfScore 3.25
-G_M9383_IG17:        ; bbWeight=1, gcrefRegs=0040 {rsi}, byrefRegs=0000 {}, byref
-       xor      ecx, ecx
-       cmp      dword ptr [rsi+0x34], 1
+       mov      esi, 1
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+						;; size=46 bbWeight=0.50 PerfScore 4.75
+G_M9383_IG17:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
+       cmp      dword ptr [rcx+0x34], 1
        sete     cl
+       ; gcrRegs -[rcx]
+       movzx    rcx, cl
        call     [<unknown method>]
        ; gcr arg pop 0
        xor      eax, eax
-       mov      dword ptr [rsi+0x34], eax
-       mov      eax, edi
-						;; size=22 bbWeight=1 PerfScore 8.75
+       mov      rcx, gword ptr [rbp+0x10]
+       ; gcrRegs +[rcx]
+       mov      dword ptr [rcx+0x34], eax
+       mov      eax, esi
+						;; size=27 bbWeight=1 PerfScore 9.75
 G_M9383_IG18:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 40
+       add      rsp, 48
        pop      rbx
        pop      rsi
-       pop      rdi
        pop      rbp
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
+						;; size=8 bbWeight=1 PerfScore 2.75
 G_M9383_IG19:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; gcrRegs -[rsi]
+       ; gcrRegs -[rcx]
        ; GC ptr vars -{V00}
        xor      eax, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
 G_M9383_IG20:        ; bbWeight=0, epilog, nogc, extend
...

```


</div></details>

<details>
<summary><span style="color:red">+25</span> (<span style="color:red">+13.02%</span>) : 622297.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (Tier1)</summary>
<div style="margin-left:1em">

```diff
@@ -14,63 +14,70 @@
 ;* V02 loc0         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;* V03 loc1         [V03    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;* V04 loc2         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V05 loc3         [V05    ] (  2,  2   )     int  ->  [rsp+0x50]  do-not-enreg[X] addr-exposed ld-addr-op
+;  V05 loc3         [V05    ] (  2,  2   )     int  ->  [rsp+0x58]  do-not-enreg[X] addr-exposed ld-addr-op
 ;* V06 loc4         [V06    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Guid>
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08    ] (  2,  4   )  struct (16) [rsp+0x40]  do-not-enreg[XS] addr-exposed ld-addr-op class-hnd exact "Single-def Box Helper" <System.Guid>
+;  V08 tmp1         [V08    ] (  2,  4   )  struct (16) [rsp+0x48]  do-not-enreg[XS] addr-exposed ld-addr-op class-hnd exact "Single-def Box Helper" <System.Guid>
 ;* V09 tmp2         [V09    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.Span`1[ushort]>
 ;  V10 tmp3         [V10,T02] (  4,  8   )     int  ->  rax         "Inlining Arg"
 ;  V11 tmp4         [V11,T03] (  3,  6   )   byref  ->  rcx         "Inlining Arg"
 ;* V12 tmp5         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V13 tmp6         [V13,T04] (  3,  6   )     int  ->  rdi         "Inlining Arg"
-;  V14 tmp7         [V14,T05] (  2,  4   )   byref  ->  rbp         "Inlining Arg"
+;  V13 tmp6         [V13,T04] (  3,  6   )     int  ->  rbp         "Inlining Arg"
+;  V14 tmp7         [V14,T05] (  2,  4   )   byref  ->  r14         "Inlining Arg"
 ;* V15 tmp8         [V15    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V16 tmp9         [V16    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
 ;* V17 tmp10        [V17    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
 ;* V18 tmp11        [V18    ] (  0,  0   )   byref  ->  zero-ref    "field V09._reference (fldOffset=0x0)" P-INDEP
 ;* V19 tmp12        [V19    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0x8)" P-INDEP
-;  V20 tmp13        [V20,T07] (  2,  2   )   byref  ->  rbp         "field V12._reference (fldOffset=0x0)" P-INDEP
-;  V21 tmp14        [V21,T09] (  2,  2   )     int  ->  rdi         "field V12._length (fldOffset=0x8)" P-INDEP
+;  V20 tmp13        [V20,T07] (  2,  2   )   byref  ->  r14         "field V12._reference (fldOffset=0x0)" P-INDEP
+;  V21 tmp14        [V21,T10] (  2,  2   )     int  ->  rbp         "field V12._length (fldOffset=0x8)" P-INDEP
 ;  V22 tmp15        [V22,T08] (  2,  2   )   byref  ->  rdx         "field V15._reference (fldOffset=0x0)" P-INDEP
-;* V23 tmp16        [V23,T10] (  0,  0   )     int  ->  zero-ref    "field V15._length (fldOffset=0x8)" P-INDEP
-;  V24 tmp17        [V24    ] (  3,  6   )  struct (16) [rsp+0x30]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
-;  V25 tmp18        [V25    ] (  3,  6   )  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V26 cse0         [V26,T06] (  3,  3   )     int  ->  rdi         "CSE - aggressive"
+;* V23 tmp16        [V23,T11] (  0,  0   )     int  ->  zero-ref    "field V15._length (fldOffset=0x8)" P-INDEP
+;  V24 tmp17        [V24    ] (  3,  6   )  struct (16) [rsp+0x38]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
+;  V25 tmp18        [V25    ] (  3,  6   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V26 cse0         [V26,T06] (  3,  3   )     int  ->  rbp         "CSE - aggressive"
+;  V27 cse1         [V27,T09] (  2,  2   )   byref  ->  rdi         hoist "CSE - aggressive"
 ;
-; Lcl frame size = 88
+; Lcl frame size = 96
 
 G_M9916_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref, nogc <-- Prolog IG
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 88
+       sub      rsp, 96
+       xor      eax, eax
+       mov      qword ptr [rsp+0x28], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rsp+0x20], ymm4
+       vmovdqa  xmmword ptr [rsp+0x30], xmm4
+       mov      qword ptr [rsp+0x40], rax
        mov      rbx, rcx
        ; byrRegs +[rbx]
        mov      rsi, rdx
        ; byrRegs +[rsi]
-						;; size=24 bbWeight=1 PerfScore 7.08
-G_M9916_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
+						;; size=38 bbWeight=1 PerfScore 10.33
+G_M9916_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref
        cmp      byte  ptr [rbx+0x14], 0
-       jne      SHORT G_M9916_IG06
-						;; size=6 bbWeight=1 PerfScore 4.00
-G_M9916_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, byref, isz
+       jne      G_M9916_IG06
+       lea      rdi, bword ptr [rbx+0x18]
+       ; byrRegs +[rdi]
+						;; size=14 bbWeight=1 PerfScore 4.50
+G_M9916_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, byref, isz
        vmovups  xmm0, xmmword ptr [rsi]
-       vmovups  xmmword ptr [rsp+0x40], xmm0
-       lea      rcx, bword ptr [rbx+0x18]
+       vmovups  xmmword ptr [rsp+0x48], xmm0
+       mov      rcx, rdi
        ; byrRegs +[rcx]
        mov      eax, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      eax, edi
+       mov      ebp, dword ptr [rcx+0x08]
+       cmp      eax, ebp
        ja       SHORT G_M9916_IG05
        mov      rcx, bword ptr [rcx]
        mov      edx, eax
-       lea      rbp, bword ptr [rcx+2*rdx]
-       ; byrRegs +[rbp]
-       sub      edi, eax
-       mov      ecx, edi
+       lea      r14, bword ptr [rcx+2*rdx]
+       ; byrRegs +[r14]
+       sub      ebp, eax
+       mov      ecx, ebp
        ; byrRegs -[rcx]
        not      ecx
        shr      ecx, 31
@@ -78,34 +85,35 @@ G_M9916_IG03:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi},
        ; gcr arg pop 0
        xor      rdx, rdx
        ; byrRegs +[rdx]
-       mov      bword ptr [rsp+0x30], rbp
-       mov      dword ptr [rsp+0x38], edi
-       mov      bword ptr [rsp+0x20], rdx
+       mov      bword ptr [rsp+0x38], r14
+       mov      dword ptr [rsp+0x40], ebp
+       mov      bword ptr [rsp+0x28], rdx
        xor      edx, edx
        ; byrRegs -[rdx]
-       mov      dword ptr [rsp+0x28], edx
-       lea      rdx, [rsp+0x30]
-       lea      r9, [rsp+0x20]
-       lea      r8, [rsp+0x50]
-       lea      rcx, [rsp+0x40]
+       mov      dword ptr [rsp+0x30], edx
+       lea      rdx, [rsp+0x38]
+       lea      r9, [rsp+0x28]
+       lea      r8, [rsp+0x58]
+       lea      rcx, [rsp+0x48]
        call     [<unknown method>]
-       ; byrRegs -[rbp]
+       ; byrRegs -[r14]
        ; gcr arg pop 0
        test     eax, eax
        je       SHORT G_M9916_IG08
-       mov      ecx, dword ptr [rsp+0x50]
+       mov      ecx, dword ptr [rsp+0x58]
        add      dword ptr [rbx+0x10], ecx
-						;; size=107 bbWeight=1 PerfScore 32.50
+						;; size=106 bbWeight=1 PerfScore 32.25
 G_M9916_IG04:        ; bbWeight=1, epilog, nogc, extend
-       add      rsp, 88
+       add      rsp, 96
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
+						;; size=11 bbWeight=1 PerfScore 3.75
 G_M9916_IG05:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0000 {}, gcvars, byref
-       ; byrRegs -[rbx rsi]
+       ; byrRegs -[rbx rsi rdi]
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        ; gcr arg pop 0
        int3     
@@ -125,15 +133,16 @@ G_M9916_IG06:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi},
        nop      
 						;; size=16 bbWeight=0 PerfScore 0.00
 G_M9916_IG07:        ; bbWeight=0, epilog, nogc, extend
-       add      rsp, 88
+       add      rsp, 96
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M9916_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0048 {rbx rsi}, gcvars, byref
-       ; byrRegs +[rbx rsi]
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M9916_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=00C8 {rbx rsi rdi}, gcvars, byref
+       ; byrRegs +[rbx rsi rdi]
        mov      rcx, rbx
        ; byrRegs +[rcx]
        call     [<unknown method>]
@@ -142,7 +151,7 @@ G_M9916_IG08:        ; bbWeight=0, gcVars=0000000000000000 {}, gcrefRegs=0000 {}
        jmp      G_M9916_IG03
 						;; size=14 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 192, prolog size 18, PerfScore 46.83, instruction count 63, allocated bytes for code 192 (MethodHash=b837d943) for method System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (Tier1)
+; Total bytes of code 217, prolog size 32, PerfScore 50.83, instruction count 70, allocated bytes for code 217 (MethodHash=b837d943) for method System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (Tier1)
 ; ============================================================
 
 Unwind Info:
@@ -150,13 +159,14 @@ Unwind Info:
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
+    CodeOffset: 0x0A UnwindOp: UWOP_ALLOC_SMALL (2)     OpInfo: 11 * 8 + 8 = 96 = 0x60
+    CodeOffset: 0x06 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbx (3)
+    CodeOffset: 0x05 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rbp (5)
+    CodeOffset: 0x04 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rsi (6)
+    CodeOffset: 0x03 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: rdi (7)
+    CodeOffset: 0x02 UnwindOp: UWOP_PUSH_NONVOL (0)     OpInfo: r14 (14)

```


</div></details>


</div></details>

<details>
<summary>libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 10539.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.CodeAnalysis.CSharp.Binder+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -18,15 +18,14 @@ G_M60118_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M60118_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M60118_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=a7181529) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=a7181529) for method Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 11669.dasm - Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Interop.ComInterfaceGenerator+<>c>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Interop.ComMethodContext>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Interop.ComMethodContext>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V03 tmp1         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;
@@ -19,15 +19,14 @@ G_M46963_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M46963_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x40]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M46963_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=4925488c) for method Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=4925488c) for method Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 35706.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite>
 ;* V02 arg2         [V02    ] (  0,  0   )   byref  ->  zero-ref    single-def
 ;# V03 OutArgs      [V03    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V04 tmp1         [V04    ] (  0,  0   )     ref  ->  zero-ref    "field V02.<Scope>k__BackingField (fldOffset=0x0)" P-INDEP
@@ -22,15 +22,14 @@ G_M22722_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22722_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x08]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M22722_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=40fca73d) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+6</span> (<span style="color:red">+9.23%</span>) : 203275.dasm - System.Numerics.Tests.BigIntegerConstructorTest+<>c:<RunCtorSingleTests>b__10_3():this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -32,19 +32,21 @@ G_M61092_IG02:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rax]
        ; gcr arg pop 0
        mov      dword ptr [rax+0x10], 0xD1FFAB1E
-       vcvtss2sd xmm1, xmm1, dword ptr [rax+0x10]
+       mov      ecx, dword ptr [rax+0x10]
+       vmovd    xmm1, ecx
+       vcvtss2sd xmm1, xmm1, xmm1
        lea      rcx, [rsp+0x28]
        call     [<unknown method>]
        ; gcrRegs -[rax]
        ; gcr arg pop 0
        nop      
-						;; size=44 bbWeight=1 PerfScore 13.25
+						;; size=50 bbWeight=1 PerfScore 14.25
 G_M61092_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 56
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 65, prolog size 16, PerfScore 17.00, instruction count 14, allocated bytes for code 65 (MethodHash=6de0115b) for method System.Numerics.Tests.BigIntegerConstructorTest+<>c:<RunCtorSingleTests>b__10_3():this (FullOpts)
+; Total bytes of code 71, prolog size 16, PerfScore 18.00, instruction count 16, allocated bytes for code 71 (MethodHash=6de0115b) for method System.Numerics.Tests.BigIntegerConstructorTest+<>c:<RunCtorSingleTests>b__10_3():this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 29750.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M22035_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M22035_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x20]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M22035_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=afa6a9ec) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+1</span> (<span style="color:red">+14.29%</span>) : 29752.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -17,15 +17,15 @@ G_M17231_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M17231_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
+       mov      eax, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rcx+0x18]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 4.00
 G_M17231_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 5.00, instruction count 3, allocated bytes for code 8 (MethodHash=c14cbcb0) for method Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>realworld.run.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-33.33%</span>) : 9734.dasm - FSharp.Compiler.InfoReader+-ctor@681-50:System.Collections.Generic.IEqualityComparer<FSharp.Compiler.Infos.AllowMultiIntfInstantiations>.GetHashCode(FSharp.Compiler.Infos+AllowMultiIntfInstantiations):int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <FSharp.Compiler.InfoReader+-ctor@681-50>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <FSharp.Compiler.Infos+AllowMultiIntfInstantiations>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <FSharp.Compiler.Infos+AllowMultiIntfInstantiations>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V03 tmp1         [V03,T01] (  2,  2   )     int  ->  rax         "Inline return value spill temp"
 ;
@@ -19,14 +19,13 @@ G_M34834_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M34834_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      eax, dword ptr [rdx+0x08]
-						;; size=5 bbWeight=1 PerfScore 5.00
+						;; size=3 bbWeight=1 PerfScore 2.00
 G_M34834_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 6, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 6 (MethodHash=fb1a77ed) for method FSharp.Compiler.InfoReader+-ctor@681-50:System.Collections.Generic.IEqualityComparer<FSharp.Compiler.Infos.AllowMultiIntfInstantiations>.GetHashCode(FSharp.Compiler.Infos+AllowMultiIntfInstantiations):int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=fb1a77ed) for method FSharp.Compiler.InfoReader+-ctor@681-50:System.Collections.Generic.IEqualityComparer<FSharp.Compiler.Infos.AllowMultiIntfInstantiations>.GetHashCode(FSharp.Compiler.Infos+AllowMultiIntfInstantiations):int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-33.33%</span>) : 5852.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+res@1620-2:Invoke(System.Tuple`3[ushort,int,int]):int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <FSharp.Compiler.AbstractIL.ILBinaryReader+res@1620-2>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <System.Tuple`3[ushort,int,int]>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <System.Tuple`3[ushort,int,int]>
 ;* V02 loc0         [V02    ] (  0,  0   )  ushort  ->  zero-ref   
 ;* V03 loc1         [V03    ] (  0,  0   )     int  ->  zero-ref   
 ;* V04 loc2         [V04    ] (  0,  0   )     int  ->  zero-ref   
@@ -21,14 +21,13 @@ G_M49833_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M49833_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      eax, dword ptr [rdx+0x0C]
-						;; size=5 bbWeight=1 PerfScore 5.00
+						;; size=3 bbWeight=1 PerfScore 2.00
 G_M49833_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 6, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 6 (MethodHash=85ca3d56) for method FSharp.Compiler.AbstractIL.ILBinaryReader+res@1620-2:Invoke(System.Tuple`3[ushort,int,int]):int:this (FullOpts)
+; Total bytes of code 4, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 4 (MethodHash=85ca3d56) for method FSharp.Compiler.AbstractIL.ILBinaryReader+res@1620-2:Invoke(System.Tuple`3[ushort,int,int]):int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-28.57%</span>) : 8775.dasm - FSharp.Compiler.MethodCalls+-ctor@660-63[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -9,7 +9,7 @@
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <FSharp.Compiler.MethodCalls+-ctor@660-63[System.__Canon]>
-;  V01 arg1         [V01,T00] (  4,  4   )     ref  ->  rdx         class-hnd single-def <System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]>
+;  V01 arg1         [V01,T00] (  3,  3   )     ref  ->  rdx         class-hnd single-def <System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]>
 ;* V02 loc0         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;  V03 loc1         [V03,T01] (  2,  2   )     ref  ->  rax         class-hnd single-def <Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]>
 ;* V04 loc2         [V04    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]>
@@ -24,15 +24,14 @@ G_M11731_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M11731_IG02:        ; bbWeight=1, gcrefRegs=0004 {rdx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdx]
-       cmp      byte  ptr [rdx], dl
        mov      rax, gword ptr [rdx+0x10]
        ; gcrRegs +[rax]
-						;; size=6 bbWeight=1 PerfScore 5.00
+						;; size=4 bbWeight=1 PerfScore 2.00
 G_M11731_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 7, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 7 (MethodHash=166dd22c) for method FSharp.Compiler.MethodCalls+-ctor@660-63[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]:this (FullOpts)
+; Total bytes of code 5, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 5 (MethodHash=166dd22c) for method FSharp.Compiler.MethodCalls+-ctor@660-63[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+11</span> (<span style="color:red">+1.74%</span>) : 19629.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,7 +8,7 @@
 ; 0 inlinees with PGO data; 30 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T30] (  3,  3   )   byref  ->  rcx         this single-def
+;  V00 this         [V00,T26] (  3,  3   )   byref  ->  rcx         this single-def
 ;  V01 arg1         [V01,T03] ( 10, 18   )     ref  ->  rbx         class-hnd single-def <System.String>
 ;  V02 loc0         [V02,T00] ( 11, 99   )     ref  ->  rsi         class-hnd <Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive]>
 ;* V03 loc1         [V03    ] (  0,  0   )  ushort  ->  zero-ref   
@@ -16,39 +16,39 @@
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <<unknown class>>
 ;  V07 tmp2         [V07,T04] (  7, 14   )     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
-;  V08 tmp3         [V08,T28] (  3,  6   )  ushort  ->  rbp         "Inline stloc first use temp"
+;  V08 tmp3         [V08,T24] (  3,  6   )  ushort  ->  rbp         "Inline stloc first use temp"
 ;* V09 tmp4         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <<unknown class>>
 ;* V10 tmp5         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DefineDirectiveTriviaSyntax>
 ;* V11 tmp6         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UndefDirectiveTriviaSyntax>
 ;  V12 tmp7         [V12,T17] (  2,  4   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V13 tmp8         [V13,T26] (  2,  8   )   byref  ->  rcx         "impAppendStmt"
+;  V13 tmp8         [V13,T22] (  2,  8   )   byref  ->  rcx         "impAppendStmt"
 ;  V14 tmp9         [V14,T05] (  7, 14   )     ref  ->  rdi         class-hnd "Inline return value spill temp" <System.String>
-;  V15 tmp10        [V15,T29] (  3,  6   )  ushort  ->  rcx         "Inline stloc first use temp"
+;  V15 tmp10        [V15,T25] (  3,  6   )  ushort  ->  rcx         "Inline stloc first use temp"
 ;* V16 tmp11        [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <<unknown class>>
 ;* V17 tmp12        [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DefineDirectiveTriviaSyntax>
 ;* V18 tmp13        [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UndefDirectiveTriviaSyntax>
 ;  V19 tmp14        [V19,T18] (  2,  4   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V20 tmp15        [V20,T27] (  2,  8   )   byref  ->  rcx         "impAppendStmt"
+;  V20 tmp15        [V20,T23] (  2,  8   )   byref  ->  rcx         "impAppendStmt"
 ;* V21 tmp16        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <<unknown class>>
-;  V22 tmp17        [V22,T01] ( 18, 70   )     ref  ->  registers   "field V04._node (fldOffset=0x0)" P-INDEP
-;  V23 tmp18        [V23,T07] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V24 tmp19        [V24,T08] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V25 tmp20        [V25,T09] (  3, 12   )     ref  ->  rcx         "argument with side effect"
-;  V26 tmp21        [V26,T10] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V22 tmp17        [V22,T01] ( 14, 48   )     ref  ->  registers   "field V04._node (fldOffset=0x0)" P-INDEP
+;  V23 tmp18        [V23,T11] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V24 tmp19        [V24,T12] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V25 tmp20        [V25,T13] (  3, 12   )     ref  ->  rcx         "argument with side effect"
+;  V26 tmp21        [V26,T14] (  3, 12   )     ref  ->  rcx         "argument with side effect"
 ;  V27 cse0         [V27,T02] (  3, 24   )     ref  ->  rdi         "CSE - aggressive"
 ;  V28 cse1         [V28,T19] (  4,  8   )     int  ->  rbp         "CSE - moderate"
 ;  V29 cse2         [V29,T16] (  4,  8   )     ref  ->  rdx         "CSE - moderate"
 ;  V30 cse3         [V30,T20] (  4,  8   )     int  ->  rbp         "CSE - moderate"
 ;  V31 cse4         [V31,T21] (  4,  8   )     int  ->  rbp         "CSE - moderate"
-;  V32 cse5         [V32,T06] (  6, 12   )     int  ->  r14         multi-def "CSE - aggressive"
-;  V33 rat0         [V33,T11] (  3, 12   )     ref  ->  rcx         "replacement local"
-;  V34 rat1         [V34,T22] (  3,  8   )    long  ->  rax         "CSE for expectedClsNode"
-;  V35 rat2         [V35,T12] (  3, 12   )     ref  ->  rcx         "replacement local"
-;  V36 rat3         [V36,T23] (  3,  8   )    long  ->  rax         "CSE for expectedClsNode"
-;  V37 rat4         [V37,T13] (  3, 12   )     ref  ->  rcx         "replacement local"
-;  V38 rat5         [V38,T24] (  3,  8   )    long  ->  rax         "CSE for expectedClsNode"
-;  V39 rat6         [V39,T14] (  3, 12   )     ref  ->  rcx         "replacement local"
-;  V40 rat7         [V40,T25] (  3,  8   )    long  ->  rax         "CSE for expectedClsNode"
+;  V32 cse5         [V32,T10] (  6, 12   )     int  ->  r14         multi-def "CSE - aggressive"
+;  V33 rat0         [V33,T06] (  4, 14   )     ref  ->  rcx         "replacement local"
+;  V34 rat1         [V34,T27] (  3,  4   )    long  ->  rax         "CSE for expectedClsNode"
+;  V35 rat2         [V35,T07] (  4, 14   )     ref  ->  rcx         "replacement local"
+;  V36 rat3         [V36,T28] (  3,  4   )    long  ->  rax         "CSE for expectedClsNode"
+;  V37 rat4         [V37,T08] (  4, 14   )     ref  ->  rcx         "replacement local"
+;  V38 rat5         [V38,T29] (  3,  4   )    long  ->  rax         "CSE for expectedClsNode"
+;  V39 rat6         [V39,T09] (  4, 14   )     ref  ->  rcx         "replacement local"
+;  V40 rat7         [V40,T30] (  3,  4   )    long  ->  rax         "CSE for expectedClsNode"
 ;  V41 rat8         [V41,T15] (  3, 12   )     int  ->   r8         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 32
@@ -67,7 +67,7 @@ G_M49105_IG02:        ; bbWeight=1, gcrefRegs=0008 {rbx}, byrefRegs=0002 {rcx},
        ; byrRegs +[rcx]
        mov      rsi, gword ptr [rcx]
        ; gcrRegs +[rsi]
-       jmp      G_M49105_IG18
+       jmp      G_M49105_IG26
 						;; size=8 bbWeight=1 PerfScore 4.00
 G_M49105_IG03:        ; bbWeight=2, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rdi]
@@ -76,77 +76,89 @@ G_M49105_IG03:        ; bbWeight=2, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000
        ; gcrRegs +[rdx]
        mov      r8, rdx
        ; gcrRegs +[r8]
-       cmp      byte  ptr [r8], r8b
        movzx    rbp, word  ptr [r8+0x0C]
        lea      r8d, [rbp-0x2165]
        ; gcrRegs -[r8]
        cmp      r8d, 6
-       ja       G_M49105_IG17
+       ja       G_M49105_IG25
        mov      ecx, r8d
        lea      rax, [reloc @RWD00]
        mov      eax, dword ptr [rax+4*rcx]
        lea      r8, G_M49105_IG02
        add      rax, r8
        jmp      rax
-						;; size=57 bbWeight=2 PerfScore 30.00
+						;; size=54 bbWeight=2 PerfScore 24.00
 G_M49105_IG04:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rdi]
-       cmp      byte  ptr [rdx], dl
        cmp      ebp, 0x216A
        je       SHORT G_M49105_IG05
        cmp      ebp, 0x216B
-       je       SHORT G_M49105_IG06
-       jmp      SHORT G_M49105_IG07
-						;; size=20 bbWeight=2 PerfScore 15.00
+       je       SHORT G_M49105_IG08
+       jmp      SHORT G_M49105_IG11
+						;; size=18 bbWeight=2 PerfScore 9.00
 G_M49105_IG05:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, rdx
        ; gcrRegs +[rcx]
+       test     rcx, rcx
+       je       SHORT G_M49105_IG07
+						;; size=8 bbWeight=2 PerfScore 3.00
+G_M49105_IG06:        ; bbWeight=1, gcrefRegs=004E {rcx rdx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DefineDirectiveTriviaSyntax
        cmp      qword ptr [rcx], rax
-       jne      G_M49105_IG27
+       jne      G_M49105_IG35
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M49105_IG07:        ; bbWeight=2, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rdx]
        mov      rcx, gword ptr [rcx+0x20]
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x78]
        call     [rax+0x08]<unknown method>
-       ; gcrRegs -[rcx rdx] +[rax]
+       ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        mov      rdi, rax
        ; gcrRegs +[rdi]
-       jmp      SHORT G_M49105_IG08
-						;; size=41 bbWeight=2 PerfScore 31.50
-G_M49105_IG06:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M49105_IG12
+						;; size=19 bbWeight=2 PerfScore 22.50
+G_M49105_IG08:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax rdi] +[rdx]
        mov      rcx, rdx
        ; gcrRegs +[rcx]
+       test     rcx, rcx
+       je       SHORT G_M49105_IG10
+						;; size=8 bbWeight=2 PerfScore 3.00
+G_M49105_IG09:        ; bbWeight=1, gcrefRegs=004E {rcx rdx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UndefDirectiveTriviaSyntax
        cmp      qword ptr [rcx], rax
-       jne      G_M49105_IG28
+       jne      G_M49105_IG36
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M49105_IG10:        ; bbWeight=2, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rdx]
        mov      rcx, gword ptr [rcx+0x20]
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x78]
        call     [rax+0x08]<unknown method>
-       ; gcrRegs -[rcx rdx] +[rax]
+       ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        mov      rdi, rax
        ; gcrRegs +[rdi]
-       jmp      SHORT G_M49105_IG08
-						;; size=41 bbWeight=2 PerfScore 31.50
-G_M49105_IG07:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
+       jmp      SHORT G_M49105_IG12
+						;; size=19 bbWeight=2 PerfScore 22.50
+G_M49105_IG11:        ; bbWeight=2, gcrefRegs=0048 {rbx rsi}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rax rdi]
        xor      rdi, rdi
        ; gcrRegs +[rdi]
 						;; size=2 bbWeight=2 PerfScore 0.50
-G_M49105_IG08:        ; bbWeight=2, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
+G_M49105_IG12:        ; bbWeight=2, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000 {}, byref
        cmp      rdi, rbx
-       je       G_M49105_IG21
+       je       G_M49105_IG29
        test     rdi, rdi
-       je       G_M49105_IG17
+       je       G_M49105_IG25
        test     rbx, rbx
-       je       G_M49105_IG17
+       je       G_M49105_IG25
        mov      ebp, dword ptr [rdi+0x08]
        mov      r14d, dword ptr [rbx+0x08]
        cmp      ebp, r14d
-       jne      G_M49105_IG17
+       jne      G_M49105_IG25
        mov      ecx, 1
        call     [<unknown method>]
        ; gcr arg pop 0
@@ -169,71 +181,84 @@ G_M49105_IG08:        ; bbWeight=2, gcrefRegs=00C8 {rbx rsi rdi}, byrefRegs=0000
        ; byrRegs -[rcx rdx]
        ; gcr arg pop 0
        test     eax, eax
-       je       G_M49105_IG17
+       je       G_M49105_IG25
 						;; size=106 bbWeight=2 PerfScore 51.50
-G_M49105_IG09:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M49105_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        ; gcrRegs -[rbx rsi]
-       jmp      G_M49105_IG21
+       jmp      G_M49105_IG29
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M49105_IG10:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
+G_M49105_IG14:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs +[rdx rbx rsi]
-       cmp      byte  ptr [rdx], dl
        mov      ecx, ebp
        cmp      ecx, 0x216A
-       je       SHORT G_M49105_IG11
+       je       SHORT G_M49105_IG15
        cmp      ecx, 0x216B
-       je       SHORT G_M49105_IG12
-       jmp      SHORT G_M49105_IG13
-						;; size=22 bbWeight=2 PerfScore 15.50
-G_M49105_IG11:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       je       SHORT G_M49105_IG18
+       jmp      SHORT G_M49105_IG21
+						;; size=20 bbWeight=2 PerfScore 9.50
+G_M49105_IG15:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        mov      rcx, rdx
        ; gcrRegs +[rcx]
+       test     rcx, rcx
+       je       SHORT G_M49105_IG17
+						;; size=8 bbWeight=2 PerfScore 3.00
+G_M49105_IG16:        ; bbWeight=1, gcrefRegs=004E {rcx rdx rbx rsi}, byrefRegs=0000 {}, byref
        mov      rax, 0xD1FFAB1E      ; Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DefineDirectiveTriviaSyntax
        cmp      qword ptr [rcx], rax
-       jne      G_M49105_IG29
+       jne      G_M49105_IG37
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M49105_IG17:        ; bbWeight=2, gcrefRegs=004A {rcx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       ; gcrRegs -[rdx]
        mov      rcx, gword ptr [rcx+0x20]
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x78]
        call     [rax+0x08]<unknown method>
-       ; gcrRegs -[rcx rdx] +[rax]
+       ; gcrRegs -[rcx] +[rax]
        ; gcr arg pop 0
        mov      rdi, rax
        ; gcrRegs +[rdi]
-       jmp      SHORT G_M49105_IG14
-						;; size=41 bbWeight=2 PerfScore 31.50
-G_M49105_IG12:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
+       jmp      SHORT G_M49105_IG22
+						;; size=19 bbWeight=2 PerfScore 22.50
+G_M49105_IG18:        ; bbWeight=2, gcrefRegs=004C {rdx rbx rsi}, byrefRegs=0000 {}, byref, isz
        ; gcrRegs -[rax rdi] +[rdx]
        mov      rcx, rdx
        ; gcrRegs +[rcx]
+       test     rcx, rcx
...

```


</div></details>

<details>
<summary><span style="color:red">+9</span> (<span style="color:red">+1.85%</span>) : 21522.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -8,57 +8,58 @@
 ; 0 inlinees with PGO data; 8 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 18, 24   )   byref  ->  rbx         this single-def
+;  V00 this         [V00,T00] ( 18, 20.25)   byref  ->  rbx         this single-def
 ;  V01 arg1         [V01,T05] ( 11,  6.50)     int  ->  rdi         single-def
 ;  V02 arg2         [V02,T04] ( 14,  8.50)     int  ->  rsi         single-def
-;  V03 arg3         [V03,T08] (  4,  3   )   ubyte  ->   r9         single-def
+;  V03 arg3         [V03,T09] (  4,  3   )   ubyte  ->   r9         single-def
 ;* V04 loc0         [V04    ] (  0,  0   )     int  ->  zero-ref   
 ;* V05 loc1         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V06 loc2         [V06,T01] (  5, 16.50)     int  ->  rsi        
 ;  V07 loc3         [V07,T06] (  2,  8   )  ushort  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T14] (  2,  2   )     ref  ->  rbp         class-hnd exact single-def "impAppendStmt" <System.Text.RegularExpressions.RegexNode>
-;  V10 tmp2         [V10,T19] (  2,  2   )     int  ->  r14         "impAppendStmt"
-;  V11 tmp3         [V11,T07] (  5,  5   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <System.Text.RegularExpressions.RegexNode>
+;  V09 tmp1         [V09,T15] (  2,  2   )     ref  ->  rbp         class-hnd exact single-def "impAppendStmt" <System.Text.RegularExpressions.RegexNode>
+;  V10 tmp2         [V10,T20] (  2,  2   )     int  ->  r14         "impAppendStmt"
+;  V11 tmp3         [V11,T08] (  5,  5   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <System.Text.RegularExpressions.RegexNode>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V13 tmp5         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.RegexNode>
-;  V14 tmp6         [V14,T25] (  2,  1   )     ref  ->  rsi         single-def
-;  V15 tmp7         [V15,T28] (  2,  1   )     int  ->  rcx        
+;  V14 tmp6         [V14,T26] (  2,  1   )     ref  ->  rsi         single-def
+;  V15 tmp7         [V15,T29] (  2,  1   )     int  ->  rcx        
 ;* V16 tmp8         [V16    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref   
-;  V18 tmp10        [V18,T22] (  3,  1.50)     int  ->  rdx        
+;  V18 tmp10        [V18,T23] (  3,  1.50)     int  ->  rdx        
 ;* V19 tmp11        [V19    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
-;  V20 tmp12        [V20,T11] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V20 tmp12        [V20,T12] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V21 tmp13        [V21    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V22 tmp14        [V22    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V23 tmp15        [V23,T15] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
-;  V24 tmp16        [V24,T16] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V23 tmp15        [V23,T16] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
+;  V24 tmp16        [V24,T17] (  2,  2   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V25 tmp17        [V25    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
-;  V26 tmp18        [V26,T12] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V26 tmp18        [V26,T13] (  4,  4   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V27 tmp19        [V27    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V28 tmp20        [V28    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V29 tmp21        [V29,T17] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
-;  V30 tmp22        [V30,T10] (  2,  4.50)   byref  ->  rdi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V31 tmp23        [V31,T09] (  3,  5   )     int  ->  rbp         "field V05._length (fldOffset=0x8)" P-INDEP
+;  V29 tmp21        [V29,T18] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
+;  V30 tmp22        [V30,T11] (  2,  4.50)   byref  ->  rdi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V31 tmp23        [V31,T10] (  3,  5   )     int  ->  rbp         "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V32 tmp24        [V32    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V33 tmp25        [V33    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
-;  V34 tmp26        [V34,T20] (  3,  1.50)   byref  ->  rbp         "field V19._reference (fldOffset=0x0)" P-INDEP
-;  V35 tmp27        [V35,T23] (  3,  1.50)     int  ->  r14         "field V19._length (fldOffset=0x8)" P-INDEP
-;  V36 tmp28        [V36,T26] (  2,  1   )   byref  ->  rbp         single-def "field V21._reference (fldOffset=0x0)" P-INDEP
-;* V37 tmp29        [V37,T30] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
+;  V34 tmp26        [V34,T21] (  3,  1.50)   byref  ->  rbp         "field V19._reference (fldOffset=0x0)" P-INDEP
+;  V35 tmp27        [V35,T24] (  3,  1.50)     int  ->  r14         "field V19._length (fldOffset=0x8)" P-INDEP
+;  V36 tmp28        [V36,T27] (  2,  1   )   byref  ->  rbp         single-def "field V21._reference (fldOffset=0x0)" P-INDEP
+;* V37 tmp29        [V37,T31] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V38 tmp30        [V38    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V22._reference (fldOffset=0x0)" P-INDEP
 ;* V39 tmp31        [V39    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
-;  V40 tmp32        [V40,T21] (  3,  1.50)   byref  ->  rdi         "field V25._reference (fldOffset=0x0)" P-INDEP
-;  V41 tmp33        [V41,T24] (  3,  1.50)     int  ->  rbp         "field V25._length (fldOffset=0x8)" P-INDEP
-;  V42 tmp34        [V42,T27] (  2,  1   )   byref  ->  rdi         single-def "field V27._reference (fldOffset=0x0)" P-INDEP
-;  V43 tmp35        [V43,T29] (  2,  1   )     int  ->  rbp         "field V27._length (fldOffset=0x8)" P-INDEP
+;  V40 tmp32        [V40,T22] (  3,  1.50)   byref  ->  rdi         "field V25._reference (fldOffset=0x0)" P-INDEP
+;  V41 tmp33        [V41,T25] (  3,  1.50)     int  ->  rbp         "field V25._length (fldOffset=0x8)" P-INDEP
+;  V42 tmp34        [V42,T28] (  2,  1   )   byref  ->  rdi         single-def "field V27._reference (fldOffset=0x0)" P-INDEP
+;  V43 tmp35        [V43,T30] (  2,  1   )     int  ->  rbp         "field V27._length (fldOffset=0x8)" P-INDEP
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V28._reference (fldOffset=0x0)" P-INDEP
 ;* V45 tmp37        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V28._length (fldOffset=0x8)" P-INDEP
 ;  V46 tmp38        [V46    ] (  3,  3   )  struct (16) [rsp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;  V47 tmp39        [V47,T02] (  2, 16   )     ref  ->  rdx         "argument with side effect"
-;  V48 tmp40        [V48,T03] (  2, 16   )     ref  ->  r14         "argument with side effect"
-;  V49 tmp41        [V49,T13] (  3,  3   )     ref  ->   r8         single-def "arr expr"
-;  V50 tmp42        [V50,T18] (  2,  2   )     ref  ->  rdx         single-def "argument with side effect"
+;  V48 tmp40        [V48,T03] (  2, 16   )     ref  ->  r15         "argument with side effect"
+;  V49 tmp41        [V49,T14] (  3,  3   )     ref  ->   r8         single-def "arr expr"
+;  V50 tmp42        [V50,T19] (  2,  2   )     ref  ->  rdx         single-def "argument with side effect"
+;  V51 cse0         [V51,T07] (  4,  5.25)   byref  ->  registers   hoist multi-def "CSE - aggressive"
 ;
 ; Lcl frame size = 56
 
@@ -91,7 +92,7 @@ G_M048_IG03:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, by
        mov      r8, gword ptr [rbx+0x28]
        ; gcrRegs +[r8]
        cmp      edi, dword ptr [r8+0x08]
-       jae      G_M048_IG18
+       jae      G_M048_IG19
        mov      ecx, edi
        movzx    rcx, word  ptr [r8+2*rcx+0x0C]
        test     r9b, r9b
@@ -118,14 +119,16 @@ G_M048_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0040
        and      edx, -2
 						;; size=6 bbWeight=0.50 PerfScore 1.12
 G_M048_IG06:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref
-       lea      r9, bword ptr [rbx+0x5C]
+       lea      rbp, bword ptr [rbx+0x5C]
+       ; byrRegs +[rbp]
+       mov      r9, rbp
        ; byrRegs +[r9]
        mov      r8, gword ptr [rbx+0x30]
        ; gcrRegs +[r8]
        movzx    rcx, cx
        call     [System.Text.RegularExpressions.RegexNode:CreateOneWithCaseConversion(ushort,int,System.Globalization.CultureInfo,byref):System.Text.RegularExpressions.RegexNode]
        ; gcrRegs -[r8] +[rax]
-       ; byrRegs -[rbx r9]
+       ; byrRegs -[rbx rbp r9]
        ; gcr arg pop 0
        mov      rdx, rax
        ; gcrRegs +[rdx]
@@ -136,7 +139,7 @@ G_M048_IG06:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx},
        ; gcrRegs -[rax rcx rdx rsi]
        ; gcr arg pop 0
        nop      
-						;; size=32 bbWeight=0.50 PerfScore 6.25
+						;; size=35 bbWeight=0.50 PerfScore 6.38
 G_M048_IG07:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 56
        pop      rbx
@@ -162,7 +165,7 @@ G_M048_IG08:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000
        mov      ecx, edi
        ; gcrRegs -[rcx]
        or       ecx, esi
-       jne      G_M048_IG19
+       jne      G_M048_IG20
        xor      rbp, rbp
        ; byrRegs +[rbp]
        xor      r14d, r14d
@@ -176,7 +179,7 @@ G_M048_IG09:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        add      rax, rdx
        mov      edx, dword ptr [rcx+0x08]
        cmp      rax, rdx
-       ja       G_M048_IG19
+       ja       G_M048_IG20
        mov      eax, edi
        lea      rbp, bword ptr [rcx+2*rax+0x0C]
        ; byrRegs +[rbp]
@@ -254,7 +257,7 @@ G_M048_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000
        test     rcx, rcx
        jne      SHORT G_M048_IG14
        or       edi, esi
-       jne      SHORT G_M048_IG19
+       jne      SHORT G_M048_IG20
        xor      rdi, rdi
        ; byrRegs +[rdi]
        xor      ebp, ebp
@@ -267,7 +270,7 @@ G_M048_IG14:        ; bbWeight=0.50, gcrefRegs=0002 {rcx}, byrefRegs=0008 {rbx},
        add      rax, rdx
        mov      edx, dword ptr [rcx+0x08]
        cmp      rax, rdx
-       ja       SHORT G_M048_IG19
+       ja       SHORT G_M048_IG20
        mov      eax, edi
        lea      rdi, bword ptr [rcx+2*rax+0x0C]
        ; byrRegs +[rdi]
@@ -284,12 +287,19 @@ G_M048_IG15:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}
        test     ebp, ebp
        jle      G_M048_IG04
 						;; size=10 bbWeight=0.50 PerfScore 0.75
-G_M048_IG16:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref, isz
+G_M048_IG16:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref
+       lea      r9, bword ptr [rbx+0x5C]
+       ; byrRegs +[r9]
+       mov      r14, r9
+       ; byrRegs +[r14]
+						;; size=7 bbWeight=0.25 PerfScore 0.19
+G_M048_IG17:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=4088 {rbx rdi r14}, byref, isz
+       ; byrRegs -[r9]
        mov      r9d, esi
        movzx    rcx, word  ptr [rdi+2*r9]
-       mov      r14, gword ptr [rbx+0x18]
-       ; gcrRegs +[r14]
-       lea      r9, bword ptr [rbx+0x5C]
+       mov      r15, gword ptr [rbx+0x18]
+       ; gcrRegs +[r15]
+       mov      r9, r14
        ; byrRegs +[r9]
        mov      edx, dword ptr [rbx+0x70]
        mov      r8, gword ptr [rbx+0x30]
@@ -300,32 +310,32 @@ G_M048_IG16:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, b
        ; gcr arg pop 0
        mov      rdx, rax
        ; gcrRegs +[rdx]
-       mov      rcx, r14
+       mov      rcx, r15
        ; gcrRegs +[rcx]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.RegexNode:AddChild(System.Text.RegularExpressions.RegexNode):this]
-       ; gcrRegs -[rax rcx rdx r14]
+       ; gcrRegs -[rax rcx rdx r15]
        ; gcr arg pop 0
        inc      esi
        cmp      esi, ebp
-       jl       SHORT G_M048_IG16
-						;; size=49 bbWeight=4 PerfScore 79.00
-G_M048_IG17:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
-       ; byrRegs -[rbx rdi]
+       jl       SHORT G_M048_IG17
+						;; size=48 bbWeight=4 PerfScore 78.00
+G_M048_IG18:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+       ; byrRegs -[rbx rdi r14]
        jmp      G_M048_IG04
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M048_IG18:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M048_IG19:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        call     CORINFO_HELP_RNGCHKFAIL
        ; gcr arg pop 0
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M048_IG19:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
+G_M048_IG20:        ; bbWeight=0, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref
        mov      ecx, 33
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
        ; gcr arg pop 0
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 487, prolog size 19, PerfScore 147.38, instruction count 161, allocated bytes for code 487 (MethodHash=2c5cffcf) for method System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
+; Total bytes of code 496, prolog size 19, PerfScore 146.69, instruction count 164, allocated bytes for code 496 (MethodHash=2c5cffcf) for method System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+2</span> (<span style="color:red">+2.47%</span>) : 12684.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader:sigptrGetSingle(ubyte[],int):System.Tuple`2[float,int] (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -44,10 +44,11 @@ G_M35659_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byr
        mov      rcx, 0xD1FFAB1E      ; System.Tuple`2[float,int]
        call     CORINFO_HELP_NEWSFAST
        ; gcr arg pop 0
-       vmovss   xmm0, dword ptr [rdi+0x10]
+       mov      ecx, dword ptr [rdi+0x10]
+       vmovd    xmm0, ecx
        vmovss   dword ptr [rax+0x08], xmm0
        mov      dword ptr [rax+0x0C], esi
-						;; size=66 bbWeight=1 PerfScore 18.00
+						;; size=68 bbWeight=1 PerfScore 18.00
 G_M35659_IG03:        ; bbWeight=1, epilog, nogc, extend
        add      rsp, 32
        pop      rbx
@@ -56,7 +57,7 @@ G_M35659_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=8 bbWeight=1 PerfScore 2.75
 
-; Total bytes of code 81, prolog size 7, PerfScore 24.00, instruction count 22, allocated bytes for code 81 (MethodHash=784774b4) for method FSharp.Compiler.AbstractIL.ILBinaryReader:sigptrGetSingle(ubyte[],int):System.Tuple`2[float,int] (FullOpts)
+; Total bytes of code 83, prolog size 7, PerfScore 24.00, instruction count 23, allocated bytes for code 83 (MethodHash=784774b4) for method FSharp.Compiler.AbstractIL.ILBinaryReader:sigptrGetSingle(ubyte[],int):System.Tuple`2[float,int] (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>


</div></details>

<details>
<summary>smoke_tests.nativeaot.windows.x64.checked.mch</summary>
<div style="margin-left:1em">


<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-22.22%</span>) : 31837.dasm - System.Globalization.CultureData:get_FirstDayOfWeek():int:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Globalization.CultureData>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd exact single-def <System.Globalization.CultureData>
 ;# V01 OutArgs      [V01    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
 ; Lcl frame size = 0
@@ -16,14 +16,13 @@ G_M10162_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M10162_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        mov      eax, dword ptr [rcx+0x198]
-						;; size=8 bbWeight=1 PerfScore 5.00
+						;; size=6 bbWeight=1 PerfScore 2.00
 G_M10162_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 9, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 9 (MethodHash=9f8dd84d) for method System.Globalization.CultureData:get_FirstDayOfWeek():int:this (FullOpts)
+; Total bytes of code 7, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 7 (MethodHash=9f8dd84d) for method System.Globalization.CultureData:get_FirstDayOfWeek():int:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-20.00%</span>) : 31842.dasm - System.Globalization.CultureData:get_TimeSeparator():System.String:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Globalization.CultureData>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd exact single-def <System.Globalization.CultureData>
 ;* V01 loc0         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact <System.String>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
@@ -17,15 +17,14 @@ G_M62564_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M62564_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        mov      rax, gword ptr [rcx+0x140]
        ; gcrRegs +[rax]
-						;; size=9 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 2.00
 G_M62564_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 10 (MethodHash=2a860b9b) for method System.Globalization.CultureData:get_TimeSeparator():System.String:this (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 8 (MethodHash=2a860b9b) for method System.Globalization.CultureData:get_TimeSeparator():System.String:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:green">-2</span> (<span style="color:green">-20.00%</span>) : 31839.dasm - System.Globalization.CultureData:get_ShortTimes():System.String[]:this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,7 +7,7 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (  4,  4   )     ref  ->  rcx         this class-hnd exact single-def <System.Globalization.CultureData>
+;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd exact single-def <System.Globalization.CultureData>
 ;* V01 loc0         [V01    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.String[]>
 ;# V02 OutArgs      [V02    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;
@@ -17,15 +17,14 @@ G_M47102_IG01:        ; bbWeight=1, gcrefRegs=0000 {}, byrefRegs=0000 {}, byref,
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M47102_IG02:        ; bbWeight=1, gcrefRegs=0002 {rcx}, byrefRegs=0000 {}, byref
        ; gcrRegs +[rcx]
-       cmp      byte  ptr [rcx], cl
        mov      rax, gword ptr [rcx+0x150]
        ; gcrRegs +[rax]
-						;; size=9 bbWeight=1 PerfScore 5.00
+						;; size=7 bbWeight=1 PerfScore 2.00
 G_M47102_IG03:        ; bbWeight=1, epilog, nogc, extend
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 10, prolog size 0, PerfScore 6.00, instruction count 3, allocated bytes for code 10 (MethodHash=e7fa4801) for method System.Globalization.CultureData:get_ShortTimes():System.String[]:this (FullOpts)
+; Total bytes of code 8, prolog size 0, PerfScore 3.00, instruction count 2, allocated bytes for code 8 (MethodHash=e7fa4801) for method System.Globalization.CultureData:get_ShortTimes():System.String[]:this (FullOpts)
 ; ============================================================
 
 Unwind Info:

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+0.97%</span>) : 16435.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,59 +7,60 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] ( 16, 21.50)   byref  ->  rbx         this single-def
+;  V00 this         [V00,T03] ( 16, 17.75)   byref  ->  rbx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;  V02 arg1         [V02    ] (  8,  8.50)     ref  ->  [rsp+0xA0]  do-not-enreg[X] addr-exposed ld-addr-op class-hnd single-def <System.__Canon>
-;  V03 loc0         [V03,T12] (  6,  3   )     ref  ->  rsi         class-hnd exact <System.String>
+;  V03 loc0         [V03,T13] (  6,  3   )     ref  ->  rsi         class-hnd exact <System.String>
 ;* V04 loc1         [V04    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;* V05 loc2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V06 loc3         [V06    ] (  2,  4.50)     int  ->  [rsp+0x58]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V07 loc4         [V07    ] (  5,  2.50)     ref  ->  [rsp+0x50]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T16] (  4,  2   )   byref  ->  rcx        
-;  V10 tmp2         [V10,T22] (  3,  1.50)     ref  ->  rsi        
+;  V09 tmp1         [V09,T17] (  4,  2   )   byref  ->  rcx        
+;  V10 tmp2         [V10,T23] (  3,  1.50)     ref  ->  rsi        
 ;  V11 tmp3         [V11,T04] (  2, 16   )     ref  ->  rsi         class-hnd "impAppendStmt" <System.__Canon>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.Span`1[ushort]>
 ;  V13 tmp5         [V13,T00] (  4, 32   )     int  ->  rdx         "Inlining Arg"
 ;  V14 tmp6         [V14,T01] (  3, 24   )   byref  ->  rcx         "Inlining Arg"
 ;* V15 tmp7         [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V16 tmp8         [V16,T02] (  3, 24   )     int  ->  rdi         "Inlining Arg"
-;  V17 tmp9         [V17,T05] (  2, 16   )   byref  ->  rbp         "Inlining Arg"
+;  V16 tmp8         [V16,T02] (  3, 24   )     int  ->  rbp         "Inlining Arg"
+;  V17 tmp9         [V17,T05] (  2, 16   )   byref  ->  r14         "Inlining Arg"
 ;* V18 tmp10        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V19 tmp11        [V19    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V20 tmp12        [V20    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[ushort]>
-;  V21 tmp13        [V21,T10] (  4,  4   )     int  ->  rdx         "Inlining Arg"
-;  V22 tmp14        [V22,T13] (  3,  3   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V21 tmp13        [V21,T11] (  4,  4   )     int  ->  rcx         "Inlining Arg"
+;  V22 tmp14        [V22,T14] (  3,  3   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V23 tmp15        [V23    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V24 tmp16        [V24,T15] (  3,  3   )     int  ->  rdi         "Inlining Arg"
-;  V25 tmp17        [V25,T18] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
+;  V24 tmp16        [V24,T16] (  3,  3   )     int  ->  rbp         "Inlining Arg"
+;  V25 tmp17        [V25,T19] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V26 tmp18        [V26    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp19        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;* V28 tmp20        [V28,T24] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V28 tmp20        [V28,T25] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V29 tmp21        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[ushort]>
 ;* V30 tmp22        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
-;  V31 tmp23        [V31,T19] (  2,  2   )   byref  ->  rdx         single-def "Inlining Arg"
-;  V32 tmp24        [V32,T21] (  2,  2   )    long  ->   r8         "Inlining Arg"
+;  V31 tmp23        [V31,T20] (  2,  2   )   byref  ->  rdx         single-def "Inlining Arg"
+;  V32 tmp24        [V32,T22] (  2,  2   )    long  ->   r8         "Inlining Arg"
 ;* V33 tmp25        [V33    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;  V34 tmp26        [V34,T07] (  2,  8   )   byref  ->  rdx         "field V05._reference (fldOffset=0x0)" P-INDEP
-;* V35 tmp27        [V35,T11] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;* V35 tmp27        [V35,T12] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V36 tmp28        [V36    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V37 tmp29        [V37    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
-;  V38 tmp30        [V38,T08] (  2,  8   )   byref  ->  rbp         "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V39 tmp31        [V39,T09] (  2,  8   )     int  ->  rdi         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V38 tmp30        [V38,T08] (  2,  8   )   byref  ->  r14         "field V15._reference (fldOffset=0x0)" P-INDEP
+;  V39 tmp31        [V39,T09] (  2,  8   )     int  ->  rbp         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V40 tmp32        [V40    ] (  0,  0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V42 tmp34        [V42    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V23._reference (fldOffset=0x0)" P-INDEP
 ;* V43 tmp35        [V43    ] (  0,  0   )     int  ->  zero-ref    "field V23._length (fldOffset=0x8)" P-INDEP
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V29._reference (fldOffset=0x0)" P-INDEP
 ;* V45 tmp37        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V29._length (fldOffset=0x8)" P-INDEP
-;  V46 tmp38        [V46,T14] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
+;  V46 tmp38        [V46,T15] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
 ;  V47 tmp39        [V47    ] (  3, 24   )  struct (16) [rsp+0x40]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
 ;  V48 tmp40        [V48    ] (  3, 24   )  struct (16) [rsp+0x30]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V49 tmp41        [V49,T20] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V50 cse0         [V50,T06] (  3, 12   )     int  ->  rdi         "CSE - aggressive"
-;  V51 cse1         [V51,T23] (  3,  1.50)     int  ->  rdi         "CSE - moderate"
-;  V52 cse2         [V52,T17] (  4,  2   )     int  ->  r14         "CSE - moderate"
+;  V49 tmp41        [V49,T21] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V50 cse0         [V50,T06] (  3, 12   )     int  ->  rbp         "CSE - aggressive"
+;  V51 cse1         [V51,T24] (  3,  1.50)     int  ->  rbp         "CSE - moderate"
+;  V52 cse2         [V52,T10] (  4,  5.25)   byref  ->  rdi         hoist multi-def "CSE - aggressive"
+;  V53 cse3         [V53,T18] (  4,  2   )     int  ->  r14         "CSE - moderate"
 ;
 ; Lcl frame size = 96
 
@@ -114,7 +115,7 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rdx] +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       G_M12060_IG12
+       je       G_M12060_IG13
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -122,7 +123,7 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
        test     rax, rax
-       jne      SHORT G_M12060_IG07
+       jne      SHORT G_M12060_IG06
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -141,17 +142,22 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcr arg pop 0
        mov      rsi, rax
        ; gcrRegs +[rsi]
-       jmp      G_M12060_IG14
+       jmp      G_M12060_IG15
 						;; size=100 bbWeight=0.50 PerfScore 9.12
-G_M12060_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M12060_IG06:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax rsi]
+       lea      rdi, bword ptr [rbx+0x18]
+       ; byrRegs +[rdi]
+       jmp      SHORT G_M12060_IG08
+						;; size=6 bbWeight=0.25 PerfScore 0.62
+G_M12060_IG07:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref
        mov      rcx, rbx
        ; byrRegs +[rcx]
        call     <unknown method>
        ; byrRegs -[rcx]
        ; gcr arg pop 0
 						;; size=8 bbWeight=2 PerfScore 2.50
-G_M12060_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M12060_IG08:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref, isz
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -160,21 +166,21 @@ G_M12060_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; gcr arg pop 0
        mov      rsi, rax
        ; gcrRegs +[rsi]
-       lea      rcx, bword ptr [rbx+0x18]
+       mov      rcx, rdi
        ; byrRegs +[rcx]
        mov      edx, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      edx, edi
-       ja       G_M12060_IG19
+       mov      ebp, dword ptr [rcx+0x08]
+       cmp      edx, ebp
+       ja       G_M12060_IG20
        mov      rcx, bword ptr [rcx]
        mov      eax, edx
        ; gcrRegs -[rax]
-       lea      rbp, bword ptr [rcx+2*rax]
-       ; byrRegs +[rbp]
-       sub      edi, edx
-       jns      SHORT G_M12060_IG09
-						;; size=54 bbWeight=4 PerfScore 50.00
-G_M12060_IG08:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rbp}, byref
+       lea      r14, bword ptr [rcx+2*rax]
+       ; byrRegs +[r14]
+       sub      ebp, edx
+       jns      SHORT G_M12060_IG10
+						;; size=53 bbWeight=4 PerfScore 49.00
+G_M12060_IG09:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=4088 {rbx rdi r14}, byref
        ; byrRegs -[rcx]
        lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
@@ -184,11 +190,11 @@ G_M12060_IG08:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rb
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
 						;; size=19 bbWeight=2 PerfScore 4.00
-G_M12060_IG09:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rbp}, byref
+G_M12060_IG10:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=4088 {rbx rdi r14}, byref
        xor      rdx, rdx
        ; byrRegs +[rdx]
-       mov      bword ptr [rsp+0x40], rbp
-       mov      dword ptr [rsp+0x48], edi
+       mov      bword ptr [rsp+0x40], r14
+       mov      dword ptr [rsp+0x48], ebp
        mov      bword ptr [rsp+0x30], rdx
        xor      edx, edx
        ; byrRegs -[rdx]
@@ -206,16 +212,17 @@ G_M12060_IG09:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rb
        lea      r10, [(reloc)]      ; function address
        call     [r10]<unknown method>
        ; gcrRegs -[rcx rsi]
-       ; byrRegs -[rbp]
+       ; byrRegs -[r14]
        ; gcr arg pop 0
        test     eax, eax
-       je       G_M12060_IG06
+       je       G_M12060_IG07
 						;; size=66 bbWeight=4 PerfScore 56.00
-G_M12060_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M12060_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; byrRegs -[rdi]
        mov      ecx, dword ptr [rsp+0x58]
        add      dword ptr [rbx+0x10], ecx
 						;; size=7 bbWeight=0.50 PerfScore 2.00
-G_M12060_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+G_M12060_IG12:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 96
        pop      rbx
        pop      rbp
@@ -224,7 +231,7 @@ G_M12060_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        pop      r14
        ret      
 						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+G_M12060_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
        xor      rcx, rcx
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x50], rcx
@@ -232,7 +239,7 @@ G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        cmp      gword ptr [rsp+0x50], 0
-       jne      SHORT G_M12060_IG13
+       jne      SHORT G_M12060_IG14
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
@@ -241,12 +248,12 @@ G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        cmp      gword ptr [rsp+0x50], 0
-       jne      SHORT G_M12060_IG13
+       jne      SHORT G_M12060_IG14
        xor      rsi, rsi
        ; gcrRegs +[rsi]
-       jmp      SHORT G_M12060_IG14
+       jmp      SHORT G_M12060_IG15
 						;; size=48 bbWeight=0.50 PerfScore 6.75
-G_M12060_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
+G_M12060_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
        ; gcrRegs -[rsi]
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
@@ -258,49 +265,49 @@ G_M12060_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rb
        mov      rsi, rax
        ; gcrRegs +[rsi]
 						;; size=12 bbWeight=0.50 PerfScore 3.62
-G_M12060_IG14:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+G_M12060_IG15:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax]
        test     rsi, rsi
-       je       SHORT G_M12060_IG17
-       lea      rcx, bword ptr [rbx+0x18]
-       ; byrRegs +[rcx]
-       mov      edx, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      edx, edi
-       ja       SHORT G_M12060_IG19
-       mov      rcx, bword ptr [rcx]
-       mov      eax, edx
-       lea      rbp, bword ptr [rcx+2*rax]
-       ; byrRegs +[rbp]
-       sub      edi, edx
-       jns      SHORT G_M12060_IG15
...

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+0.97%</span>) : 19102.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,59 +7,60 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] ( 16, 21.50)   byref  ->  rbx         this single-def
+;  V00 this         [V00,T03] ( 16, 17.75)   byref  ->  rbx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;  V02 arg1         [V02    ] (  8,  8.50)     ref  ->  [rsp+0xA0]  do-not-enreg[X] addr-exposed ld-addr-op class-hnd single-def <System.__Canon>
-;  V03 loc0         [V03,T12] (  6,  3   )     ref  ->  rsi         class-hnd exact <System.String>
+;  V03 loc0         [V03,T13] (  6,  3   )     ref  ->  rsi         class-hnd exact <System.String>
 ;* V04 loc1         [V04    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;* V05 loc2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V06 loc3         [V06    ] (  2,  4.50)     int  ->  [rsp+0x58]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V07 loc4         [V07    ] (  5,  2.50)     ref  ->  [rsp+0x50]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T16] (  4,  2   )   byref  ->  rcx        
-;  V10 tmp2         [V10,T22] (  3,  1.50)     ref  ->  rsi        
+;  V09 tmp1         [V09,T17] (  4,  2   )   byref  ->  rcx        
+;  V10 tmp2         [V10,T23] (  3,  1.50)     ref  ->  rsi        
 ;  V11 tmp3         [V11,T04] (  2, 16   )     ref  ->  rsi         class-hnd "impAppendStmt" <System.__Canon>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.Span`1[ushort]>
 ;  V13 tmp5         [V13,T00] (  4, 32   )     int  ->  rdx         "Inlining Arg"
 ;  V14 tmp6         [V14,T01] (  3, 24   )   byref  ->  rcx         "Inlining Arg"
 ;* V15 tmp7         [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V16 tmp8         [V16,T02] (  3, 24   )     int  ->  rdi         "Inlining Arg"
-;  V17 tmp9         [V17,T05] (  2, 16   )   byref  ->  rbp         "Inlining Arg"
+;  V16 tmp8         [V16,T02] (  3, 24   )     int  ->  rbp         "Inlining Arg"
+;  V17 tmp9         [V17,T05] (  2, 16   )   byref  ->  r14         "Inlining Arg"
 ;* V18 tmp10        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V19 tmp11        [V19    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V20 tmp12        [V20    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[ushort]>
-;  V21 tmp13        [V21,T10] (  4,  4   )     int  ->  rdx         "Inlining Arg"
-;  V22 tmp14        [V22,T13] (  3,  3   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V21 tmp13        [V21,T11] (  4,  4   )     int  ->  rcx         "Inlining Arg"
+;  V22 tmp14        [V22,T14] (  3,  3   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V23 tmp15        [V23    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V24 tmp16        [V24,T15] (  3,  3   )     int  ->  rdi         "Inlining Arg"
-;  V25 tmp17        [V25,T18] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
+;  V24 tmp16        [V24,T16] (  3,  3   )     int  ->  rbp         "Inlining Arg"
+;  V25 tmp17        [V25,T19] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V26 tmp18        [V26    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp19        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;* V28 tmp20        [V28,T24] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V28 tmp20        [V28,T25] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V29 tmp21        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[ushort]>
 ;* V30 tmp22        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
-;  V31 tmp23        [V31,T19] (  2,  2   )   byref  ->  rdx         single-def "Inlining Arg"
-;  V32 tmp24        [V32,T21] (  2,  2   )    long  ->   r8         "Inlining Arg"
+;  V31 tmp23        [V31,T20] (  2,  2   )   byref  ->  rdx         single-def "Inlining Arg"
+;  V32 tmp24        [V32,T22] (  2,  2   )    long  ->   r8         "Inlining Arg"
 ;* V33 tmp25        [V33    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;  V34 tmp26        [V34,T07] (  2,  8   )   byref  ->  rdx         "field V05._reference (fldOffset=0x0)" P-INDEP
-;* V35 tmp27        [V35,T11] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;* V35 tmp27        [V35,T12] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V36 tmp28        [V36    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V37 tmp29        [V37    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
-;  V38 tmp30        [V38,T08] (  2,  8   )   byref  ->  rbp         "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V39 tmp31        [V39,T09] (  2,  8   )     int  ->  rdi         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V38 tmp30        [V38,T08] (  2,  8   )   byref  ->  r14         "field V15._reference (fldOffset=0x0)" P-INDEP
+;  V39 tmp31        [V39,T09] (  2,  8   )     int  ->  rbp         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V40 tmp32        [V40    ] (  0,  0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V42 tmp34        [V42    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V23._reference (fldOffset=0x0)" P-INDEP
 ;* V43 tmp35        [V43    ] (  0,  0   )     int  ->  zero-ref    "field V23._length (fldOffset=0x8)" P-INDEP
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V29._reference (fldOffset=0x0)" P-INDEP
 ;* V45 tmp37        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V29._length (fldOffset=0x8)" P-INDEP
-;  V46 tmp38        [V46,T14] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
+;  V46 tmp38        [V46,T15] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
 ;  V47 tmp39        [V47    ] (  3, 24   )  struct (16) [rsp+0x40]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
 ;  V48 tmp40        [V48    ] (  3, 24   )  struct (16) [rsp+0x30]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V49 tmp41        [V49,T20] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V50 cse0         [V50,T06] (  3, 12   )     int  ->  rdi         "CSE - aggressive"
-;  V51 cse1         [V51,T23] (  3,  1.50)     int  ->  rdi         "CSE - moderate"
-;  V52 cse2         [V52,T17] (  4,  2   )     int  ->  r14         "CSE - moderate"
+;  V49 tmp41        [V49,T21] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V50 cse0         [V50,T06] (  3, 12   )     int  ->  rbp         "CSE - aggressive"
+;  V51 cse1         [V51,T24] (  3,  1.50)     int  ->  rbp         "CSE - moderate"
+;  V52 cse2         [V52,T10] (  4,  5.25)   byref  ->  rdi         hoist multi-def "CSE - aggressive"
+;  V53 cse3         [V53,T18] (  4,  2   )     int  ->  r14         "CSE - moderate"
 ;
 ; Lcl frame size = 96
 
@@ -114,7 +115,7 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rdx] +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       G_M12060_IG12
+       je       G_M12060_IG13
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -122,7 +123,7 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
        test     rax, rax
-       jne      SHORT G_M12060_IG07
+       jne      SHORT G_M12060_IG06
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -141,17 +142,22 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcr arg pop 0
        mov      rsi, rax
        ; gcrRegs +[rsi]
-       jmp      G_M12060_IG14
+       jmp      G_M12060_IG15
 						;; size=100 bbWeight=0.50 PerfScore 9.12
-G_M12060_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M12060_IG06:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax rsi]
+       lea      rdi, bword ptr [rbx+0x18]
+       ; byrRegs +[rdi]
+       jmp      SHORT G_M12060_IG08
+						;; size=6 bbWeight=0.25 PerfScore 0.62
+G_M12060_IG07:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref
        mov      rcx, rbx
        ; byrRegs +[rcx]
        call     <unknown method>
        ; byrRegs -[rcx]
        ; gcr arg pop 0
 						;; size=8 bbWeight=2 PerfScore 2.50
-G_M12060_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M12060_IG08:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref, isz
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -160,21 +166,21 @@ G_M12060_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; gcr arg pop 0
        mov      rsi, rax
        ; gcrRegs +[rsi]
-       lea      rcx, bword ptr [rbx+0x18]
+       mov      rcx, rdi
        ; byrRegs +[rcx]
        mov      edx, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      edx, edi
-       ja       G_M12060_IG19
+       mov      ebp, dword ptr [rcx+0x08]
+       cmp      edx, ebp
+       ja       G_M12060_IG20
        mov      rcx, bword ptr [rcx]
        mov      eax, edx
        ; gcrRegs -[rax]
-       lea      rbp, bword ptr [rcx+2*rax]
-       ; byrRegs +[rbp]
-       sub      edi, edx
-       jns      SHORT G_M12060_IG09
-						;; size=54 bbWeight=4 PerfScore 50.00
-G_M12060_IG08:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rbp}, byref
+       lea      r14, bword ptr [rcx+2*rax]
+       ; byrRegs +[r14]
+       sub      ebp, edx
+       jns      SHORT G_M12060_IG10
+						;; size=53 bbWeight=4 PerfScore 49.00
+G_M12060_IG09:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=4088 {rbx rdi r14}, byref
        ; byrRegs -[rcx]
        lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
@@ -184,11 +190,11 @@ G_M12060_IG08:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rb
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
 						;; size=19 bbWeight=2 PerfScore 4.00
-G_M12060_IG09:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rbp}, byref
+G_M12060_IG10:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=4088 {rbx rdi r14}, byref
        xor      rdx, rdx
        ; byrRegs +[rdx]
-       mov      bword ptr [rsp+0x40], rbp
-       mov      dword ptr [rsp+0x48], edi
+       mov      bword ptr [rsp+0x40], r14
+       mov      dword ptr [rsp+0x48], ebp
        mov      bword ptr [rsp+0x30], rdx
        xor      edx, edx
        ; byrRegs -[rdx]
@@ -206,16 +212,17 @@ G_M12060_IG09:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rb
        lea      r10, [(reloc)]      ; function address
        call     [r10]<unknown method>
        ; gcrRegs -[rcx rsi]
-       ; byrRegs -[rbp]
+       ; byrRegs -[r14]
        ; gcr arg pop 0
        test     eax, eax
-       je       G_M12060_IG06
+       je       G_M12060_IG07
 						;; size=66 bbWeight=4 PerfScore 56.00
-G_M12060_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M12060_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; byrRegs -[rdi]
        mov      ecx, dword ptr [rsp+0x58]
        add      dword ptr [rbx+0x10], ecx
 						;; size=7 bbWeight=0.50 PerfScore 2.00
-G_M12060_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+G_M12060_IG12:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 96
        pop      rbx
        pop      rbp
@@ -224,7 +231,7 @@ G_M12060_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        pop      r14
        ret      
 						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+G_M12060_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
        xor      rcx, rcx
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x50], rcx
@@ -232,7 +239,7 @@ G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        cmp      gword ptr [rsp+0x50], 0
-       jne      SHORT G_M12060_IG13
+       jne      SHORT G_M12060_IG14
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
@@ -241,12 +248,12 @@ G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        cmp      gword ptr [rsp+0x50], 0
-       jne      SHORT G_M12060_IG13
+       jne      SHORT G_M12060_IG14
        xor      rsi, rsi
        ; gcrRegs +[rsi]
-       jmp      SHORT G_M12060_IG14
+       jmp      SHORT G_M12060_IG15
 						;; size=48 bbWeight=0.50 PerfScore 6.75
-G_M12060_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
+G_M12060_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
        ; gcrRegs -[rsi]
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
@@ -258,49 +265,49 @@ G_M12060_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rb
        mov      rsi, rax
        ; gcrRegs +[rsi]
 						;; size=12 bbWeight=0.50 PerfScore 3.62
-G_M12060_IG14:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+G_M12060_IG15:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax]
        test     rsi, rsi
-       je       SHORT G_M12060_IG17
-       lea      rcx, bword ptr [rbx+0x18]
-       ; byrRegs +[rcx]
-       mov      edx, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      edx, edi
-       ja       SHORT G_M12060_IG19
-       mov      rcx, bword ptr [rcx]
-       mov      eax, edx
-       lea      rbp, bword ptr [rcx+2*rax]
-       ; byrRegs +[rbp]
-       sub      edi, edx
-       jns      SHORT G_M12060_IG15
...

```


</div></details>

<details>
<summary><span style="color:red">+5</span> (<span style="color:red">+0.97%</span>) : 21792.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)</summary>
<div style="margin-left:1em">

```diff
@@ -7,59 +7,60 @@
 ; partially interruptible
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] ( 16, 21.50)   byref  ->  rbx         this single-def
+;  V00 this         [V00,T03] ( 16, 17.75)   byref  ->  rbx         this single-def
 ;* V01 TypeCtx      [V01    ] (  0,  0   )    long  ->  zero-ref    single-def
 ;  V02 arg1         [V02    ] (  8,  8.50)     ref  ->  [rsp+0xA0]  do-not-enreg[X] addr-exposed ld-addr-op class-hnd single-def <System.__Canon>
-;  V03 loc0         [V03,T12] (  6,  3   )     ref  ->  rsi         class-hnd exact <System.String>
+;  V03 loc0         [V03,T13] (  6,  3   )     ref  ->  rsi         class-hnd exact <System.String>
 ;* V04 loc1         [V04    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;* V05 loc2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;  V06 loc3         [V06    ] (  2,  4.50)     int  ->  [rsp+0x58]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V07 loc4         [V07    ] (  5,  2.50)     ref  ->  [rsp+0x50]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T16] (  4,  2   )   byref  ->  rcx        
-;  V10 tmp2         [V10,T22] (  3,  1.50)     ref  ->  rsi        
+;  V09 tmp1         [V09,T17] (  4,  2   )   byref  ->  rcx        
+;  V10 tmp2         [V10,T23] (  3,  1.50)     ref  ->  rsi        
 ;  V11 tmp3         [V11,T04] (  2, 16   )     ref  ->  rsi         class-hnd "impAppendStmt" <System.__Canon>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.Span`1[ushort]>
 ;  V13 tmp5         [V13,T00] (  4, 32   )     int  ->  rdx         "Inlining Arg"
 ;  V14 tmp6         [V14,T01] (  3, 24   )   byref  ->  rcx         "Inlining Arg"
 ;* V15 tmp7         [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V16 tmp8         [V16,T02] (  3, 24   )     int  ->  rdi         "Inlining Arg"
-;  V17 tmp9         [V17,T05] (  2, 16   )   byref  ->  rbp         "Inlining Arg"
+;  V16 tmp8         [V16,T02] (  3, 24   )     int  ->  rbp         "Inlining Arg"
+;  V17 tmp9         [V17,T05] (  2, 16   )   byref  ->  r14         "Inlining Arg"
 ;* V18 tmp10        [V18    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V19 tmp11        [V19    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V20 tmp12        [V20    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[ushort]>
-;  V21 tmp13        [V21,T10] (  4,  4   )     int  ->  rdx         "Inlining Arg"
-;  V22 tmp14        [V22,T13] (  3,  3   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V21 tmp13        [V21,T11] (  4,  4   )     int  ->  rcx         "Inlining Arg"
+;  V22 tmp14        [V22,T14] (  3,  3   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V23 tmp15        [V23    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ushort]>
-;  V24 tmp16        [V24,T15] (  3,  3   )     int  ->  rdi         "Inlining Arg"
-;  V25 tmp17        [V25,T18] (  2,  2   )   byref  ->  rbp         single-def "Inlining Arg"
+;  V24 tmp16        [V24,T16] (  3,  3   )     int  ->  rbp         "Inlining Arg"
+;  V25 tmp17        [V25,T19] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
 ;* V26 tmp18        [V26    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp19        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;* V28 tmp20        [V28,T24] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;* V28 tmp20        [V28,T25] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
 ;* V29 tmp21        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[ushort]>
 ;* V30 tmp22        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
-;  V31 tmp23        [V31,T19] (  2,  2   )   byref  ->  rdx         single-def "Inlining Arg"
-;  V32 tmp24        [V32,T21] (  2,  2   )    long  ->   r8         "Inlining Arg"
+;  V31 tmp23        [V31,T20] (  2,  2   )   byref  ->  rdx         single-def "Inlining Arg"
+;  V32 tmp24        [V32,T22] (  2,  2   )    long  ->   r8         "Inlining Arg"
 ;* V33 tmp25        [V33    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;  V34 tmp26        [V34,T07] (  2,  8   )   byref  ->  rdx         "field V05._reference (fldOffset=0x0)" P-INDEP
-;* V35 tmp27        [V35,T11] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;* V35 tmp27        [V35,T12] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V36 tmp28        [V36    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V37 tmp29        [V37    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
-;  V38 tmp30        [V38,T08] (  2,  8   )   byref  ->  rbp         "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V39 tmp31        [V39,T09] (  2,  8   )     int  ->  rdi         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V38 tmp30        [V38,T08] (  2,  8   )   byref  ->  r14         "field V15._reference (fldOffset=0x0)" P-INDEP
+;  V39 tmp31        [V39,T09] (  2,  8   )     int  ->  rbp         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V40 tmp32        [V40    ] (  0,  0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V42 tmp34        [V42    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V23._reference (fldOffset=0x0)" P-INDEP
 ;* V43 tmp35        [V43    ] (  0,  0   )     int  ->  zero-ref    "field V23._length (fldOffset=0x8)" P-INDEP
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V29._reference (fldOffset=0x0)" P-INDEP
 ;* V45 tmp37        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V29._length (fldOffset=0x8)" P-INDEP
-;  V46 tmp38        [V46,T14] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
+;  V46 tmp38        [V46,T15] (  3,  3   )     ref  ->  rcx         single-def "argument with side effect"
 ;  V47 tmp39        [V47    ] (  3, 24   )  struct (16) [rsp+0x40]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
 ;  V48 tmp40        [V48    ] (  3, 24   )  struct (16) [rsp+0x30]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V49 tmp41        [V49,T20] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V50 cse0         [V50,T06] (  3, 12   )     int  ->  rdi         "CSE - aggressive"
-;  V51 cse1         [V51,T23] (  3,  1.50)     int  ->  rdi         "CSE - moderate"
-;  V52 cse2         [V52,T17] (  4,  2   )     int  ->  r14         "CSE - moderate"
+;  V49 tmp41        [V49,T21] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V50 cse0         [V50,T06] (  3, 12   )     int  ->  rbp         "CSE - aggressive"
+;  V51 cse1         [V51,T24] (  3,  1.50)     int  ->  rbp         "CSE - moderate"
+;  V52 cse2         [V52,T10] (  4,  5.25)   byref  ->  rdi         hoist multi-def "CSE - aggressive"
+;  V53 cse3         [V53,T18] (  4,  2   )     int  ->  r14         "CSE - moderate"
 ;
 ; Lcl frame size = 96
 
@@ -114,7 +115,7 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rdx] +[rax]
        ; gcr arg pop 0
        test     rax, rax
-       je       G_M12060_IG12
+       je       G_M12060_IG13
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -122,7 +123,7 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rdx]
        ; gcr arg pop 0
        test     rax, rax
-       jne      SHORT G_M12060_IG07
+       jne      SHORT G_M12060_IG06
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -141,17 +142,22 @@ G_M12060_IG05:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcr arg pop 0
        mov      rsi, rax
        ; gcrRegs +[rsi]
-       jmp      G_M12060_IG14
+       jmp      G_M12060_IG15
 						;; size=100 bbWeight=0.50 PerfScore 9.12
-G_M12060_IG06:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M12060_IG06:        ; bbWeight=0.25, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax rsi]
+       lea      rdi, bword ptr [rbx+0x18]
+       ; byrRegs +[rdi]
+       jmp      SHORT G_M12060_IG08
+						;; size=6 bbWeight=0.25 PerfScore 0.62
+G_M12060_IG07:        ; bbWeight=2, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref
        mov      rcx, rbx
        ; byrRegs +[rcx]
        call     <unknown method>
        ; byrRegs -[rcx]
        ; gcr arg pop 0
 						;; size=8 bbWeight=2 PerfScore 2.50
-G_M12060_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref, isz
+G_M12060_IG08:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0088 {rbx rdi}, byref, isz
        mov      rdx, gword ptr [rsp+0xA0]
        ; gcrRegs +[rdx]
        lea      rcx, [(reloc)]      ; <unknown class>
@@ -160,21 +166,21 @@ G_M12060_IG07:        ; bbWeight=4, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byr
        ; gcr arg pop 0
        mov      rsi, rax
        ; gcrRegs +[rsi]
-       lea      rcx, bword ptr [rbx+0x18]
+       mov      rcx, rdi
        ; byrRegs +[rcx]
        mov      edx, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      edx, edi
-       ja       G_M12060_IG19
+       mov      ebp, dword ptr [rcx+0x08]
+       cmp      edx, ebp
+       ja       G_M12060_IG20
        mov      rcx, bword ptr [rcx]
        mov      eax, edx
        ; gcrRegs -[rax]
-       lea      rbp, bword ptr [rcx+2*rax]
-       ; byrRegs +[rbp]
-       sub      edi, edx
-       jns      SHORT G_M12060_IG09
-						;; size=54 bbWeight=4 PerfScore 50.00
-G_M12060_IG08:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rbp}, byref
+       lea      r14, bword ptr [rcx+2*rax]
+       ; byrRegs +[r14]
+       sub      ebp, edx
+       jns      SHORT G_M12060_IG10
+						;; size=53 bbWeight=4 PerfScore 49.00
+G_M12060_IG09:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=4088 {rbx rdi r14}, byref
        ; byrRegs -[rcx]
        lea      rcx, gword ptr [(reloc)]
        ; gcrRegs +[rcx]
@@ -184,11 +190,11 @@ G_M12060_IG08:        ; bbWeight=2, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rb
        ; gcrRegs -[rcx rdx]
        ; gcr arg pop 0
 						;; size=19 bbWeight=2 PerfScore 4.00
-G_M12060_IG09:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rbp}, byref
+G_M12060_IG10:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=4088 {rbx rdi r14}, byref
        xor      rdx, rdx
        ; byrRegs +[rdx]
-       mov      bword ptr [rsp+0x40], rbp
-       mov      dword ptr [rsp+0x48], edi
+       mov      bword ptr [rsp+0x40], r14
+       mov      dword ptr [rsp+0x48], ebp
        mov      bword ptr [rsp+0x30], rdx
        xor      edx, edx
        ; byrRegs -[rdx]
@@ -206,16 +212,17 @@ G_M12060_IG09:        ; bbWeight=4, gcrefRegs=0040 {rsi}, byrefRegs=0028 {rbx rb
        lea      r10, [(reloc)]      ; function address
        call     [r10]<unknown method>
        ; gcrRegs -[rcx rsi]
-       ; byrRegs -[rbp]
+       ; byrRegs -[r14]
        ; gcr arg pop 0
        test     eax, eax
-       je       G_M12060_IG06
+       je       G_M12060_IG07
 						;; size=66 bbWeight=4 PerfScore 56.00
-G_M12060_IG10:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+G_M12060_IG11:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, byref
+       ; byrRegs -[rdi]
        mov      ecx, dword ptr [rsp+0x58]
        add      dword ptr [rbx+0x10], ecx
 						;; size=7 bbWeight=0.50 PerfScore 2.00
-G_M12060_IG11:        ; bbWeight=0.50, epilog, nogc, extend
+G_M12060_IG12:        ; bbWeight=0.50, epilog, nogc, extend
        add      rsp, 96
        pop      rbx
        pop      rbp
@@ -224,7 +231,7 @@ G_M12060_IG11:        ; bbWeight=0.50, epilog, nogc, extend
        pop      r14
        ret      
 						;; size=11 bbWeight=0.50 PerfScore 1.88
-G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
+G_M12060_IG13:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=0000 {}, byrefRegs=0008 {rbx}, gcvars, byref, isz
        xor      rcx, rcx
        ; gcrRegs +[rcx]
        mov      gword ptr [rsp+0x50], rcx
@@ -232,7 +239,7 @@ G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        cmp      gword ptr [rsp+0x50], 0
-       jne      SHORT G_M12060_IG13
+       jne      SHORT G_M12060_IG14
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
        ; byrRegs -[rcx]
@@ -241,12 +248,12 @@ G_M12060_IG12:        ; bbWeight=0.50, gcVars=0000000000000000 {}, gcrefRegs=000
        ; gcrRegs -[rcx]
        ; byrRegs +[rcx]
        cmp      gword ptr [rsp+0x50], 0
-       jne      SHORT G_M12060_IG13
+       jne      SHORT G_M12060_IG14
        xor      rsi, rsi
        ; gcrRegs +[rsi]
-       jmp      SHORT G_M12060_IG14
+       jmp      SHORT G_M12060_IG15
 						;; size=48 bbWeight=0.50 PerfScore 6.75
-G_M12060_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
+G_M12060_IG14:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rbx}, byref
        ; gcrRegs -[rsi]
        mov      rcx, gword ptr [rcx]
        ; gcrRegs +[rcx]
@@ -258,49 +265,49 @@ G_M12060_IG13:        ; bbWeight=0.50, gcrefRegs=0000 {}, byrefRegs=000A {rcx rb
        mov      rsi, rax
        ; gcrRegs +[rsi]
 						;; size=12 bbWeight=0.50 PerfScore 3.62
-G_M12060_IG14:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
+G_M12060_IG15:        ; bbWeight=0.50, gcrefRegs=0040 {rsi}, byrefRegs=0008 {rbx}, byref, isz
        ; gcrRegs -[rax]
        test     rsi, rsi
-       je       SHORT G_M12060_IG17
-       lea      rcx, bword ptr [rbx+0x18]
-       ; byrRegs +[rcx]
-       mov      edx, dword ptr [rbx+0x10]
-       mov      edi, dword ptr [rcx+0x08]
-       cmp      edx, edi
-       ja       SHORT G_M12060_IG19
-       mov      rcx, bword ptr [rcx]
-       mov      eax, edx
-       lea      rbp, bword ptr [rcx+2*rax]
-       ; byrRegs +[rbp]
-       sub      edi, edx
-       jns      SHORT G_M12060_IG15
...

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
|benchmarks.run.windows.x64.checked.mch|2,197|<span style="color:green">2,138</span>|<span style="color:red">48</span>|<span style="color:blue">11</span>|<span style="color:green">-16,358</span>|<span style="color:red">+187</span>|<span style="color:green">-0.3135%</span>|
|benchmarks.run_pgo.windows.x64.checked.mch|3,944|<span style="color:green">3,802</span>|<span style="color:red">135</span>|<span style="color:blue">7</span>|<span style="color:green">-17,782</span>|<span style="color:red">+1,034</span>|<span style="color:green">-0.3357%</span>|
|benchmarks.run_tiered.windows.x64.checked.mch|625|<span style="color:green">613</span>|<span style="color:red">8</span>|<span style="color:blue">4</span>|<span style="color:green">-8,148</span>|<span style="color:red">+31</span>|<span style="color:green">-0.2608%</span>|
|coreclr_tests.run.windows.x64.checked.mch|32,138|<span style="color:green">7,720</span>|<span style="color:red">23,809</span>|<span style="color:blue">609</span>|<span style="color:green">-97,829</span>|<span style="color:red">+33,114</span>|<span style="color:green">-0.1376%</span>|
|libraries.crossgen2.windows.x64.checked.mch|3,963|<span style="color:green">3,913</span>|<span style="color:red">23</span>|<span style="color:blue">27</span>|<span style="color:green">-13,467</span>|<span style="color:red">+106</span>|<span style="color:green">-0.1172%</span>|
|libraries.pmi.windows.x64.checked.mch|19,622|<span style="color:green">19,460</span>|<span style="color:red">126</span>|<span style="color:blue">36</span>|<span style="color:green">-83,815</span>|<span style="color:red">+402</span>|<span style="color:green">-0.6524%</span>|
|libraries_tests.run.windows.x64.Release.mch|18,593|<span style="color:green">17,929</span>|<span style="color:red">575</span>|<span style="color:blue">89</span>|<span style="color:green">-113,944</span>|<span style="color:red">+2,609</span>|<span style="color:green">-0.3999%</span>|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|22,927|<span style="color:green">22,703</span>|<span style="color:red">166</span>|<span style="color:blue">58</span>|<span style="color:green">-114,329</span>|<span style="color:red">+676</span>|<span style="color:green">-0.3673%</span>|
|realworld.run.windows.x64.checked.mch|3,373|<span style="color:green">3,328</span>|<span style="color:red">24</span>|<span style="color:blue">21</span>|<span style="color:green">-17,739</span>|<span style="color:red">+113</span>|<span style="color:green">-0.5164%</span>|
|smoke_tests.nativeaot.windows.x64.checked.mch|803|<span style="color:green">791</span>|<span style="color:red">8</span>|<span style="color:blue">4</span>|<span style="color:green">-2,979</span>|<span style="color:red">+30</span>|<span style="color:green">-0.2187%</span>|
||108,185|<span style="color:green">82,397</span>|<span style="color:red">24,922</span>|<span style="color:blue">866</span>|<span style="color:green">-486,390</span>|<span style="color:red">+38,302</span>||

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
|libraries_tests.run.windows.x64.Release.mch|697,491|498,513|198,978|2,682 (0.38%)|2,679 (0.38%)|
|libraries_tests_no_tiered_compilation.run.windows.x64.Release.mch|320,777|21,946|298,831|118 (0.04%)|118 (0.04%)|
|realworld.run.windows.x64.checked.mch|36,688|3|36,685|215 (0.58%)|214 (0.58%)|
|smoke_tests.nativeaot.windows.x64.checked.mch|32,537|11|32,526|41 (0.13%)|41 (0.13%)|
||2,450,559|955,294|1,495,265|7,151 (0.29%)|7,147 (0.29%)|


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

Total bytes of base: 11433103 (overridden on cmd)
Total bytes of diff: 11416932 (overridden on cmd)
Total bytes of delta: -16171 (-0.14 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          23 : 11087.dasm (11.79% of base)
          23 : 20520.dasm (11.79% of base)
          18 : 8971.dasm (0.81% of base)
          13 : 17046.dasm (2.56% of base)
          13 : 1364.dasm (2.56% of base)
          11 : 6872.dasm (2.21% of base)
           7 : 12347.dasm (0.72% of base)
           5 : 412.dasm (0.85% of base)
           5 : 12345.dasm (5.56% of base)
           5 : 12769.dasm (0.85% of base)
           4 : 25573.dasm (0.43% of base)
           3 : 16025.dasm (0.69% of base)
           3 : 2729.dasm (0.25% of base)
           3 : 17075.dasm (0.25% of base)
           3 : 24079.dasm (0.52% of base)
           3 : 22628.dasm (0.65% of base)
           3 : 18931.dasm (0.55% of base)
           3 : 21856.dasm (0.97% of base)
           3 : 10567.dasm (0.55% of base)
           2 : 24610.dasm (2.00% of base)

Top file improvements (bytes):
       -3209 : 8780.dasm (-9.53% of base)
       -1594 : 3668.dasm (-4.55% of base)
        -637 : 32222.dasm (-5.06% of base)
        -637 : 18421.dasm (-5.07% of base)
         -72 : 31454.dasm (-0.69% of base)
         -72 : 28219.dasm (-0.86% of base)
         -70 : 20976.dasm (-4.74% of base)
         -67 : 13786.dasm (-6.50% of base)
         -67 : 2228.dasm (-6.50% of base)
         -63 : 8344.dasm (-4.73% of base)
         -53 : 25279.dasm (-1.13% of base)
         -46 : 7945.dasm (-0.76% of base)
         -35 : 27752.dasm (-2.89% of base)
         -35 : 25181.dasm (-0.83% of base)
         -34 : 19109.dasm (-0.43% of base)
         -34 : 10611.dasm (-0.63% of base)
         -34 : 25192.dasm (-1.17% of base)
         -34 : 25656.dasm (-1.93% of base)
         -34 : 18978.dasm (-0.63% of base)
         -34 : 10700.dasm (-0.43% of base)

85 total files with Code Size differences (55 improved, 30 regressed), 11 unchanged.

Top method regressions (bytes):
          23 (11.79% of base) : 11087.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (FullOpts)
          23 (11.79% of base) : 20520.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (FullOpts)
          18 ( 0.81% of base) : 8971.dasm - BilinearTest:BilinearInterpol_Vector(double[],double[],double,double,double[],double,double,double):double[]:this (FullOpts)
          13 ( 2.56% of base) : 17046.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
          13 ( 2.56% of base) : 1364.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
          11 ( 2.21% of base) : 6872.dasm - System.__DTString:GetRegularToken(byref,byref,System.Globalization.DateTimeFormatInfo):this (FullOpts)
           7 ( 0.72% of base) : 12347.dasm - EMFloat:DivideInternalFPF(byref,byref,byref) (FullOpts)
           5 ( 5.56% of base) : 12345.dasm - EMFloat:normalize(byref) (FullOpts)
           5 ( 0.85% of base) : 412.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.85% of base) : 12769.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           4 ( 0.43% of base) : 25573.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:GetMetadata(Microsoft.CodeAnalysis.PortableExecutableReference,Microsoft.CodeAnalysis.CommonMessageProvider,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.DiagnosticBag):Microsoft.CodeAnalysis.Metadata:this (FullOpts)
           3 ( 0.69% of base) : 16025.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[int,System.Buffers.IndexOfAnyAsciiSearcher+DontNegate,System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[ubyte]](byref,int,byref):int (FullOpts)
           3 ( 0.52% of base) : 24079.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[int,System.Buffers.IndexOfAnyAsciiSearcher+DontNegate,System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[ubyte]](byref,int,byref):int (FullOpts)
           3 ( 0.65% of base) : 22628.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[ubyte,System.Buffers.IndexOfAnyAsciiSearcher+DontNegate,System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[ubyte]](byref,int,byref):ubyte (FullOpts)
           3 ( 0.97% of base) : 21856.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[ubyte,System.Buffers.IndexOfAnyAsciiSearcher+DontNegate,System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[ubyte]](byref,int,byref):ubyte (FullOpts)
           3 ( 0.25% of base) : 2729.dasm - System.Text.RegularExpressions.RegexNode:<ReduceAlternation>g__ExtractCommonPrefixOneNotoneSet|41_1(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.RegexNode (FullOpts)
           3 ( 0.25% of base) : 17075.dasm - System.Text.RegularExpressions.RegexNode:<ReduceAlternation>g__ExtractCommonPrefixOneNotoneSet|41_1(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.RegexNode (FullOpts)
           3 ( 0.55% of base) : 18931.dasm - System.Xml.Serialization.CodeIdentifier:GetCSharpName(System.Type):System.String (FullOpts)
           3 ( 0.55% of base) : 10567.dasm - System.Xml.Serialization.CodeIdentifier:GetCSharpName(System.Type):System.String (FullOpts)
           2 ( 2.13% of base) : 6961.dasm - LinqBenchmarks:Count00ForX():ubyte:this (FullOpts)

Top method improvements (bytes):
       -3209 (-9.53% of base) : 8780.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
       -1594 (-4.55% of base) : 3668.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -637 (-5.06% of base) : 32222.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
        -637 (-5.07% of base) : 18421.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
         -72 (-0.86% of base) : 28219.dasm - Benchstone.BenchF.LLoops:Main1(int):this (FullOpts)
         -72 (-0.69% of base) : 31454.dasm - Benchstone.MDBenchF.MDLLoops:Main1(int):this (FullOpts)
         -70 (-4.74% of base) : 20976.dasm - System.Text.Json.JsonDocument:TryGetNamedPropertyValue(int,int,System.ReadOnlySpan`1[ubyte],byref):ubyte:this (FullOpts)
         -67 (-6.50% of base) : 13786.dasm - System.Uri:PrivateParseMinimal():int:this (FullOpts)
         -67 (-6.50% of base) : 2228.dasm - System.Uri:PrivateParseMinimal():int:this (FullOpts)
         -63 (-4.73% of base) : 8344.dasm - Benchstone.BenchF.Whetsto:Test():double:this (FullOpts)
         -53 (-1.13% of base) : 25279.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseExpressionContinued(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax,uint):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax:this (FullOpts)
         -46 (-0.76% of base) : 7945.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (FullOpts)
         -35 (-2.89% of base) : 27752.dasm - Microsoft.Cci.MetadataWriter:SerializePrimitiveType(System.Reflection.Metadata.Ecma335.SignatureTypeEncoder,int) (FullOpts)
         -35 (-0.83% of base) : 25181.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseMemberDeclarationOrStatementCore(ushort):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax:this (FullOpts)
         -34 (-1.17% of base) : 25192.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:TryParseConversionOperatorDeclaration(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax],Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConversionOperatorDeclarationSyntax:this (FullOpts)
         -34 (-1.93% of base) : 25656.dasm - Microsoft.CodeAnalysis.PEModule:GetAttributeNamespaceAndName(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.EntityHandle,byref,byref):ubyte (FullOpts)
         -34 (-0.43% of base) : 19109.dasm - System.Xml.Serialization.XmlSerializationReaderILGen:WriteLiteralStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)
         -34 (-0.43% of base) : 10700.dasm - System.Xml.Serialization.XmlSerializationReaderILGen:WriteLiteralStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)
         -34 (-0.63% of base) : 10611.dasm - System.Xml.Serialization.XmlSerializationWriterILGen:WriteStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)
         -34 (-0.63% of base) : 18978.dasm - System.Xml.Serialization.XmlSerializationWriterILGen:WriteStructMethod(System.Xml.Serialization.StructMapping):this (FullOpts)

Top method regressions (percentages):
           1 (14.29% of base) : 4199.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
           1 (14.29% of base) : 19698.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
           1 (14.29% of base) : 19700.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
           1 (14.29% of base) : 4201.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
          23 (11.79% of base) : 11087.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (FullOpts)
          23 (11.79% of base) : 20520.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (FullOpts)
           5 ( 5.56% of base) : 12345.dasm - EMFloat:normalize(byref) (FullOpts)
          13 ( 2.56% of base) : 17046.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
          13 ( 2.56% of base) : 1364.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
           2 ( 2.22% of base) : 23529.dasm - PerfLabTests.LowLevelPerf:ForeachOverList100Elements():int:this (FullOpts)
          11 ( 2.21% of base) : 6872.dasm - System.__DTString:GetRegularToken(byref,byref,System.Globalization.DateTimeFormatInfo):this (FullOpts)
           2 ( 2.13% of base) : 6961.dasm - LinqBenchmarks:Count00ForX():ubyte:this (FullOpts)
           2 ( 2.00% of base) : 24610.dasm - System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (FullOpts)
           1 ( 1.82% of base) : 11723.dasm - System.Collections.IterateForEach`1[int]:List():int:this (FullOpts)
           1 ( 1.08% of base) : 1754.dasm - System.Text.Encodings.Web.TextEncoderSettings:AllowRange(System.Text.Unicode.UnicodeRange):this (FullOpts)
           1 ( 1.08% of base) : 15789.dasm - System.Text.Encodings.Web.TextEncoderSettings:AllowRange(System.Text.Unicode.UnicodeRange):this (FullOpts)
           3 ( 0.97% of base) : 21856.dasm - System.Buffers.IndexOfAnyAsciiSearcher:IndexOfAnyCore[ubyte,System.Buffers.IndexOfAnyAsciiSearcher+DontNegate,System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[ubyte]](byref,int,byref):ubyte (FullOpts)
           5 ( 0.85% of base) : 412.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.85% of base) : 12769.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
          18 ( 0.81% of base) : 8971.dasm - BilinearTest:BilinearInterpol_Vector(double[],double[],double,double,double[],double,double,double):double[]:this (FullOpts)

Top method improvements (percentages):
          -2 (-28.57% of base) : 5460.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
          -2 (-28.57% of base) : 19734.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
          -2 (-20.00% of base) : 15245.dasm - System.Collections.Generic.SortedDictionary`2[int,int]:get_Count():int:this (FullOpts)
          -2 (-20.00% of base) : 7847.dasm - System.Collections.Generic.SortedDictionary`2[int,int]:get_Count():int:this (FullOpts)
          -2 (-20.00% of base) : 3107.dasm - System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:get_Count():int:this (FullOpts)
          -2 (-20.00% of base) : 30283.dasm - System.Xml.XmlTextReaderImpl:get_LineNumber():int:this (FullOpts)
          -2 (-20.00% of base) : 30284.dasm - System.Xml.XmlTextReaderImpl:get_LinePosition():int:this (FullOpts)
          -2 (-18.18% of base) : 5824.dasm - System.Reflection.Emit.RuntimeFieldBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 19089.dasm - System.Reflection.Emit.RuntimeFieldBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 5800.dasm - System.Reflection.Emit.RuntimeMethodBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 18913.dasm - System.Reflection.Emit.RuntimeMethodBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -4 (-16.00% of base) : 30167.dasm - System.Collections.Generic.SortedSet`1+Node[int]:Merge2Nodes():this (FullOpts)
          -4 (-16.00% of base) : 32166.dasm - System.Collections.Generic.SortedSet`1+Node[System.__Canon]:Merge2Nodes():this (FullOpts)
          -4 (-16.00% of base) : 15192.dasm - System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[int,int]]:Split4Node():this (FullOpts)
          -4 (-16.00% of base) : 7838.dasm - System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[int,int]]:Split4Node():this (FullOpts)
          -4 (-16.00% of base) : 3046.dasm - System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:Split4Node():this (FullOpts)
          -2 (-12.50% of base) : 15248.dasm - System.Collections.Generic.SortedDictionary`2[int,int]:CopyTo(System.Collections.Generic.KeyValuePair`2[int,int][],int):this (FullOpts)
          -2 (-12.50% of base) : 7850.dasm - System.Collections.Generic.SortedDictionary`2[int,int]:CopyTo(System.Collections.Generic.KeyValuePair`2[int,int][],int):this (FullOpts)
          -2 (-12.50% of base) : 3110.dasm - System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:CopyTo(System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon][],int):this (FullOpts)
          -3 (-12.00% of base) : 15409.dasm - System.Collections.Sort`1[int]:SetupArrayIteration():this (FullOpts)

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

Total bytes of base: 35473761 (overridden on cmd)
Total bytes of diff: 35457013 (overridden on cmd)
Total bytes of delta: -16748 (-0.05 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         115 : 12388.dasm (7.09% of base)
          75 : 44866.dasm (7.07% of base)
          70 : 19513.dasm (6.21% of base)
          67 : 97042.dasm (6.09% of base)
          65 : 52206.dasm (6.23% of base)
          63 : 19009.dasm (5.64% of base)
          59 : 26124.dasm (5.47% of base)
          55 : 22733.dasm (5.26% of base)
          39 : 33925.dasm (3.50% of base)
          39 : 37556.dasm (3.69% of base)
          39 : 87260.dasm (3.65% of base)
          35 : 79875.dasm (3.24% of base)
          31 : 27057.dasm (2.98% of base)
          30 : 95545.dasm (1.86% of base)
          30 : 34479.dasm (1.86% of base)
          28 : 17229.dasm (1.75% of base)
          26 : 95297.dasm (0.34% of base)
          23 : 75465.dasm (2.24% of base)
           9 : 97842.dasm (6.47% of base)
           9 : 95293.dasm (6.47% of base)

Top file improvements (bytes):
       -3209 : 26827.dasm (-9.53% of base)
       -1594 : 14942.dasm (-4.55% of base)
        -637 : 38016.dasm (-5.06% of base)
         -92 : 55932.dasm (-1.08% of base)
         -92 : 82572.dasm (-0.88% of base)
         -76 : 68693.dasm (-2.76% of base)
         -55 : 68690.dasm (-0.79% of base)
         -52 : 100471.dasm (-1.94% of base)
         -52 : 99809.dasm (-1.94% of base)
         -52 : 53978.dasm (-1.94% of base)
         -52 : 85927.dasm (-1.94% of base)
         -46 : 72195.dasm (-0.85% of base)
         -43 : 86918.dasm (-1.72% of base)
         -34 : 50264.dasm (-0.40% of base)
         -32 : 71873.dasm (-1.12% of base)
         -30 : 69128.dasm (-0.96% of base)
         -30 : 23954.dasm (-1.05% of base)
         -29 : 68113.dasm (-0.32% of base)
         -27 : 72201.dasm (-0.54% of base)
         -25 : 38723.dasm (-0.72% of base)

69 total files with Code Size differences (47 improved, 22 regressed), 7 unchanged.

Top method regressions (bytes):
         115 ( 7.09% of base) : 12388.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
          75 ( 7.07% of base) : 44866.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          70 ( 6.21% of base) : 19513.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          67 ( 6.09% of base) : 97042.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          65 ( 6.23% of base) : 52206.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          63 ( 5.64% of base) : 19009.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          59 ( 5.47% of base) : 26124.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          55 ( 5.26% of base) : 22733.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          39 ( 3.50% of base) : 33925.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          39 ( 3.69% of base) : 37556.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          39 ( 3.65% of base) : 87260.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          35 ( 3.24% of base) : 79875.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          31 ( 2.98% of base) : 27057.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          30 ( 1.86% of base) : 95545.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
          30 ( 1.86% of base) : 34479.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
          28 ( 1.75% of base) : 17229.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
          26 ( 0.34% of base) : 95297.dasm - System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:.ctor(System.Text.RegularExpressions.Symbolic.SymbolicRegexBuilder`1[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong],int,System.Text.RegularExpressions.RegexFindOptimizations,System.TimeSpan):this (Tier1)
          23 ( 2.24% of base) : 75465.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
           9 ( 6.47% of base) : 97842.dasm - System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
           9 ( 6.47% of base) : 95293.dasm - System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)

Top method improvements (bytes):
       -3209 (-9.53% of base) : 26827.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
       -1594 (-4.55% of base) : 14942.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -637 (-5.06% of base) : 38016.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
         -92 (-1.08% of base) : 55932.dasm - Benchstone.BenchF.LLoops:Main1(int):this (Tier1)
         -92 (-0.88% of base) : 82572.dasm - Benchstone.MDBenchF.MDLLoops:Main1(int):this (Tier1)
         -76 (-2.76% of base) : 68693.dasm - Microsoft.Cci.MemberRefComparer:GetHashCode(Microsoft.Cci.ITypeMemberReference):int:this (Tier1)
         -55 (-0.79% of base) : 68690.dasm - Microsoft.Cci.ReferenceIndexerBase:Visit(Microsoft.Cci.IMethodReference):this (Tier1)
         -52 (-1.94% of base) : 100471.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -52 (-1.94% of base) : 99809.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -52 (-1.94% of base) : 53978.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -52 (-1.94% of base) : 85927.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -46 (-0.85% of base) : 72195.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseLocalDeclarationStatement(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax]):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax:this (Tier1)
         -43 (-1.72% of base) : 86918.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -34 (-0.40% of base) : 50264.dasm - System.Diagnostics.Tracing.ManifestBuilder:CreateManifestString():System.String:this (Tier0-FullOpts)
         -32 (-1.12% of base) : 71873.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:Free():this (Tier1)
         -30 (-0.96% of base) : 69128.dasm - Microsoft.Cci.MetadataWriter:AddCustomAttributeToTable(System.Reflection.Metadata.EntityHandle,Microsoft.Cci.ICustomAttribute):this (Tier1)
         -30 (-1.05% of base) : 23954.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -29 (-0.32% of base) : 68113.dasm - Microsoft.CodeAnalysis.CSharp.MethodCompiler:CompileMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,int,byref,Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.CSharp.TypeCompilationState):this (Tier1)
         -27 (-0.54% of base) : 72201.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseVariableDeclarator(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax,int,ubyte,ubyte,Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax],Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken],byref,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclaratorSyntax:this (Tier1)
         -25 (-0.72% of base) : 38723.dasm - System.IO.Strategies.BufferedFileStreamStrategy:WriteAsync(System.ReadOnlyMemory`1[ubyte],System.Threading.CancellationToken):System.Threading.Tasks.ValueTask:this (Tier1)

Top method regressions (percentages):
         115 ( 7.09% of base) : 12388.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
          75 ( 7.07% of base) : 44866.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
           9 ( 6.47% of base) : 97842.dasm - System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
           9 ( 6.47% of base) : 95293.dasm - System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]:BuildStateFlags(System.Text.RegularExpressions.Symbolic.ISolver`1[ulong],ubyte):ubyte:this (Tier1)
          65 ( 6.23% of base) : 52206.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          70 ( 6.21% of base) : 19513.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          67 ( 6.09% of base) : 97042.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          63 ( 5.64% of base) : 19009.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          59 ( 5.47% of base) : 26124.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          55 ( 5.26% of base) : 22733.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
           4 ( 4.00% of base) : 86893.dasm - System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (Tier1)
          39 ( 3.69% of base) : 37556.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          39 ( 3.65% of base) : 87260.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          39 ( 3.50% of base) : 33925.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          35 ( 3.24% of base) : 79875.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          31 ( 2.98% of base) : 27057.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          23 ( 2.24% of base) : 75465.dasm - System.Threading.LowLevelLifoSemaphore:Wait(int,ubyte):ubyte:this (Tier1)
          30 ( 1.86% of base) : 95545.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
          30 ( 1.86% of base) : 34479.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
          28 ( 1.75% of base) : 17229.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)

Top method improvements (percentages):
          -2 (-20.00% of base) : 18930.dasm - System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
          -4 (-16.00% of base) : 47013.dasm - System.Collections.Generic.SortedSet`1+Node[int]:Split4Node():this (Tier1)
          -2 (-15.38% of base) : 18949.dasm - System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)
          -2 (-14.29% of base) : 19283.dasm - System.Runtime.InteropServices.MemoryMarshal:GetArrayDataReference(System.Array):byref (Tier1)
          -2 (-13.33% of base) : 27026.dasm - System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder`1+StateMachineBox[int]:SetResult(int):this (Tier1)
          -2 (-13.33% of base) : 38778.dasm - System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder`1+StateMachineBox[System.Threading.Tasks.VoidTaskResult]:SetResult(System.Threading.Tasks.VoidTaskResult):this (Tier1)
          -6 (-12.24% of base) : 71158.dasm - Microsoft.CodeAnalysis.SyntaxList`1[System.__Canon]:get_Count():int:this (Tier1)
          -6 (-12.24% of base) : 63661.dasm - Microsoft.CodeAnalysis.SyntaxList`1[System.__Canon]:get_Count():int:this (Tier1)
          -2 (-11.76% of base) : 72137.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser+DisposableResetPoint:Reset():this (Tier1)
          -2 (-11.76% of base) : 20131.dasm - System.IO.Compression.Inflater:NeedsInput():ubyte:this (Tier1)
          -2 (-11.11% of base) : 69050.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodOrUserDefinedOperatorSymbol:get_IsExplicitInterfaceImplementation():ubyte:this (Tier1)
          -2 (-11.11% of base) : 63597.dasm - Microsoft.CodeAnalysis.SyntaxNode:get_IsList():ubyte:this (Tier1)
          -2 (-10.53% of base) : 19053.dasm - System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs:OnCompleted(System.Net.Sockets.SocketAsyncEventArgs):this (Tier1)
          -2 (-10.53% of base) : 10868.dasm - System.Random+Net5CompatSeedImpl:.ctor(int):this (Tier1)
          -2 (-10.00% of base) : 18815.dasm - System.Net.Security.SslStream+SslBuffer:get_EncryptedLength():int:this (Tier1)
       -3209 (-9.53% of base) : 26827.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
          -2 (-9.52% of base) : 76484.dasm - System.Collections.IntStruct:CompareTo(System.Collections.IntStruct):int:this (Tier1)
          -3 (-8.82% of base) : 68448.dasm - Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.Cci.LocalScope]:Sort(System.Collections.Generic.IComparer`1[Microsoft.Cci.LocalScope]):this (Tier1)
          -2 (-8.33% of base) : 36593.dasm - System.Threading.CancellationTokenSource+Registrations:EnterLock():this (Tier1)
          -2 (-8.33% of base) : 83701.dasm - System.Threading.CancellationTokenSource+Registrations:EnterLock():this (Tier1)

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

Total bytes of base: 12719360 (overridden on cmd)
Total bytes of diff: 12711243 (overridden on cmd)
Total bytes of delta: -8117 (-0.06 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          13 : 30866.dasm (2.56% of base)
           7 : 24729.dasm (0.72% of base)
           5 : 24728.dasm (5.56% of base)
           2 : 33404.dasm (2.00% of base)
           1 : 4204.dasm (0.08% of base)
           1 : 2677.dasm (0.05% of base)
           1 : 26329.dasm (14.29% of base)
           1 : 2998.dasm (1.14% of base)

Top file improvements (bytes):
       -3209 : 18079.dasm (-9.53% of base)
       -1594 : 16786.dasm (-4.55% of base)
        -637 : 25881.dasm (-5.06% of base)
         -72 : 41403.dasm (-0.86% of base)
         -72 : 48253.dasm (-0.69% of base)
         -67 : 44095.dasm (-1.28% of base)
         -46 : 33413.dasm (-0.76% of base)
         -34 : 43977.dasm (-1.18% of base)
         -34 : 40114.dasm (-1.93% of base)
         -33 : 31382.dasm (-0.39% of base)
         -27 : 40125.dasm (-1.74% of base)
         -25 : 44280.dasm (-2.84% of base)
         -24 : 44042.dasm (-1.63% of base)
         -23 : 44372.dasm (-3.32% of base)
         -22 : 34435.dasm (-1.20% of base)
         -20 : 43055.dasm (-1.97% of base)
         -19 : 40220.dasm (-1.30% of base)
         -19 : 44052.dasm (-0.55% of base)
         -19 : 41178.dasm (-0.34% of base)
         -19 : 43513.dasm (-0.66% of base)

73 total files with Code Size differences (65 improved, 8 regressed), 4 unchanged.

Top method regressions (bytes):
          13 ( 2.56% of base) : 30866.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (Tier1)
           7 ( 0.72% of base) : 24729.dasm - EMFloat:DivideInternalFPF(byref,byref,byref) (Tier1)
           5 ( 5.56% of base) : 24728.dasm - EMFloat:normalize(byref) (Tier1)
           2 ( 2.00% of base) : 33404.dasm - System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (Tier1)
           1 (14.29% of base) : 26329.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
           1 ( 0.08% of base) : 4204.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateLiteralFields(System.RuntimeType+RuntimeTypeCache+Filter,System.RuntimeType,byref):this (Tier1)
           1 ( 0.05% of base) : 2677.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateProperties(System.RuntimeType+RuntimeTypeCache+Filter,System.RuntimeType,System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[System.Reflection.RuntimePropertyInfo]],System.Span`1[ubyte],ubyte,byref):this (Tier1)
           1 ( 1.14% of base) : 2998.dasm - System.Text.Encodings.Web.TextEncoderSettings:AllowRange(System.Text.Unicode.UnicodeRange):this (Tier1-OSR)

Top method improvements (bytes):
       -3209 (-9.53% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
       -1594 (-4.55% of base) : 16786.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.IndexViewModel,int) (FullOpts)
        -637 (-5.06% of base) : 25881.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.CollectionsOfPrimitives,int) (FullOpts)
         -72 (-0.86% of base) : 41403.dasm - Benchstone.BenchF.LLoops:Main1(int):this (Tier1)
         -72 (-0.69% of base) : 48253.dasm - Benchstone.MDBenchF.MDLLoops:Main1(int):this (Tier1)
         -67 (-1.28% of base) : 44095.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseExpressionContinued(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax,uint):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax:this (Tier1)
         -46 (-0.76% of base) : 33413.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (Tier1)
         -34 (-1.18% of base) : 43977.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:TryParseConversionOperatorDeclaration(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax],Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConversionOperatorDeclarationSyntax:this (Tier1)
         -34 (-1.93% of base) : 40114.dasm - Microsoft.CodeAnalysis.PEModule:GetAttributeNamespaceAndName(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.EntityHandle,byref,byref):ubyte (Tier1)
         -33 (-0.39% of base) : 31382.dasm - System.Diagnostics.Tracing.ManifestBuilder:CreateManifestString():System.String:this (Tier0-FullOpts)
         -27 (-1.74% of base) : 40125.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:GetTypeOfTypeDef(System.Reflection.Metadata.TypeDefinitionHandle,byref,ubyte):System.__Canon:this (Tier1)
         -25 (-2.84% of base) : 44280.dasm - Microsoft.CodeAnalysis.MetadataReaderExtensions:IsTheObjectClass(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.TypeDefinition):ubyte (Tier1)
         -24 (-1.63% of base) : 44042.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseStatementCore(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax],ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax:this (Tier1)
         -23 (-3.32% of base) : 44372.dasm - Microsoft.CodeAnalysis.PEModule+<GetTypeDefsOrThrow>d__84:MoveNext():ubyte:this (Tier1)
         -22 (-1.20% of base) : 34435.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer:LexSyntaxTrivia(ubyte,ubyte,byref):this (Tier1)
         -20 (-1.97% of base) : 43055.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParsePossibleScopedKeyword(ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken:this (Tier1)
         -19 (-0.34% of base) : 41178.dasm - Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator:EmitExpressionCore(Microsoft.CodeAnalysis.CSharp.BoundExpression,ubyte):this (Tier1)
         -19 (-0.55% of base) : 44052.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseVariableDeclarator(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax,int,ubyte,ubyte,Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax],Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken],byref,ubyte):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclaratorSyntax:this (Tier1)
         -19 (-0.66% of base) : 43513.dasm - Microsoft.CodeAnalysis.CSharp.SyntaxExtensions:VisitRankSpecifiers[System.ValueTuple`3[System.__Canon,System.__Canon,System.__Canon]](Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax,System.Action`2[System.__Canon,System.ValueTuple`3[System.__Canon,System.__Canon,System.__Canon]],byref) (Tier1)
         -19 (-1.30% of base) : 40220.dasm - Microsoft.CodeAnalysis.MetadataDecoder`5[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]:GetSignatureForMethod(System.Reflection.Metadata.MethodDefinitionHandle,byref,byref,ubyte):Microsoft.CodeAnalysis.ParamInfo`1[System.__Canon][]:this (Tier1)

Top method regressions (percentages):
           1 (14.29% of base) : 26329.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (Tier1)
           5 ( 5.56% of base) : 24728.dasm - EMFloat:normalize(byref) (Tier1)
          13 ( 2.56% of base) : 30866.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (Tier1)
           2 ( 2.00% of base) : 33404.dasm - System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice+<>c:<Setup>b__7_0(System.Text.RegularExpressions.Match):System.String:this (Tier1)
           1 ( 1.14% of base) : 2998.dasm - System.Text.Encodings.Web.TextEncoderSettings:AllowRange(System.Text.Unicode.UnicodeRange):this (Tier1-OSR)
           7 ( 0.72% of base) : 24729.dasm - EMFloat:DivideInternalFPF(byref,byref,byref) (Tier1)
           1 ( 0.08% of base) : 4204.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateLiteralFields(System.RuntimeType+RuntimeTypeCache+Filter,System.RuntimeType,byref):this (Tier1)
           1 ( 0.05% of base) : 2677.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateProperties(System.RuntimeType+RuntimeTypeCache+Filter,System.RuntimeType,System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[System.Reflection.RuntimePropertyInfo]],System.Span`1[ubyte],ubyte,byref):this (Tier1)

Top method improvements (percentages):
          -2 (-20.00% of base) : 8937.dasm - System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
          -4 (-16.00% of base) : 19669.dasm - System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]]:Split4Node():this (Tier1)
          -2 (-15.38% of base) : 8951.dasm - System.Net.Security.SslStream+SslBuffer:get_ActiveLength():int:this (Tier1)
         -12 (-14.63% of base) : 35248.dasm - Microsoft.CodeAnalysis.SyntaxList`1[System.__Canon]:get_Count():int:this (Tier1)
          -2 (-14.29% of base) : 5581.dasm - System.Runtime.InteropServices.MemoryMarshal:GetArrayDataReference(System.Array):byref (Tier1)
          -2 (-13.33% of base) : 8662.dasm - System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder`1+StateMachineBox[int]:SetResult(int):this (Tier1)
          -2 (-13.33% of base) : 26841.dasm - System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder`1+StateMachineBox[System.Threading.Tasks.VoidTaskResult]:SetResult(System.Threading.Tasks.VoidTaskResult):this (Tier1)
          -3 (-12.50% of base) : 18621.dasm - System.String:LastIndexOf(ushort):int:this (Tier1)
          -2 (-11.76% of base) : 43990.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser+DisposableResetPoint:Reset():this (Tier1)
          -2 (-11.76% of base) : 24433.dasm - System.IO.Compression.Inflater:NeedsInput():ubyte:this (Tier1)
          -2 (-11.11% of base) : 35252.dasm - Microsoft.CodeAnalysis.SyntaxNode:get_IsList():ubyte:this (Tier1)
          -2 (-11.11% of base) : 30930.dasm - System.Reflection.Emit.RuntimeModuleBuilder:get_SyncRoot():System.Object:this (Tier1)
          -2 (-10.53% of base) : 9078.dasm - System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs:OnCompleted(System.Net.Sockets.SocketAsyncEventArgs):this (Tier1)
          -2 (-10.53% of base) : 12464.dasm - System.Random+Net5CompatSeedImpl:.ctor(int):this (Tier1)
         -12 (-10.26% of base) : 35251.dasm - Microsoft.CodeAnalysis.SyntaxList`1+Enumerator[System.__Canon]:MoveNext():ubyte:this (Tier1)
          -2 (-10.00% of base) : 8431.dasm - System.Net.Security.SslStream+SslBuffer:get_EncryptedLength():int:this (Tier1)
       -3209 (-9.53% of base) : 18079.dasm - (dynamicClass):_DynamicMethod0(System.IO.TextWriter,MicroBenchmarks.Serializers.MyEventsListerItem,int) (FullOpts)
          -7 (-9.09% of base) : 43411.dasm - Microsoft.CodeAnalysis.SyntaxNodeOrTokenList:get_Count():int:this (Tier1)
          -2 (-8.33% of base) : 43682.dasm - Microsoft.CodeAnalysis.SyntaxTriviaList:GetGreenNodeAt(Microsoft.CodeAnalysis.GreenNode,int):Microsoft.CodeAnalysis.GreenNode (Tier1)
          -2 (-8.33% of base) : 47387.dasm - System.Collections.IntStruct:CompareTo(System.Collections.IntStruct):int:this (Tier1)

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

Total bytes of base: 386876814 (overridden on cmd)
Total bytes of diff: 386812099 (overridden on cmd)
Total bytes of delta: -64715 (-0.02 % of base)
    diff is an improvement.
    relative diff is a regression.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         542 : 304403.dasm (3.60% of base)
         142 : 337343.dasm (11.62% of base)
         127 : 463151.dasm (10.47% of base)
         127 : 515835.dasm (10.47% of base)
         127 : 523993.dasm (10.41% of base)
         127 : 545263.dasm (10.47% of base)
         127 : 582994.dasm (10.47% of base)
         127 : 317891.dasm (10.47% of base)
         127 : 435183.dasm (10.47% of base)
         127 : 584080.dasm (10.47% of base)
         127 : 314276.dasm (10.47% of base)
         127 : 445537.dasm (10.47% of base)
         127 : 510611.dasm (10.47% of base)
         127 : 433877.dasm (10.43% of base)
         127 : 468719.dasm (10.47% of base)
         127 : 539146.dasm (10.43% of base)
         127 : 541960.dasm (10.47% of base)
         121 : 565333.dasm (9.81% of base)
         110 : 497408.dasm (8.90% of base)
         110 : 502618.dasm (8.90% of base)

Top file improvements (bytes):
       -6917 : 233201.dasm (-7.13% of base)
       -5997 : 233194.dasm (-6.54% of base)
       -5839 : 233862.dasm (-5.92% of base)
       -5785 : 233215.dasm (-5.87% of base)
       -5069 : 233852.dasm (-5.13% of base)
       -4000 : 233847.dasm (-4.28% of base)
       -3945 : 233208.dasm (-4.24% of base)
       -3824 : 233857.dasm (-4.17% of base)
        -916 : 313109.dasm (-8.32% of base)
        -506 : 211377.dasm (-4.45% of base)
        -271 : 233318.dasm (-15.27% of base)
        -250 : 236162.dasm (-17.25% of base)
        -221 : 233311.dasm (-14.00% of base)
        -201 : 232622.dasm (-13.25% of base)
        -176 : 235134.dasm (-15.64% of base)
        -172 : 233328.dasm (-16.33% of base)
        -161 : 233343.dasm (-12.20% of base)
        -146 : 576862.dasm (-10.43% of base)
        -144 : 233323.dasm (-13.07% of base)
        -128 : 287930.dasm (-0.91% of base)

90 total files with Code Size differences (46 improved, 44 regressed), 20 unchanged.

Top method regressions (bytes):
         542 ( 3.60% of base) : 304403.dasm - CseTest.Test_Main:TestEntryPoint():int (FullOpts)
         142 (11.62% of base) : 337343.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 463151.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 515835.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.41% of base) : 523993.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 545263.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 582994.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 317891.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 435183.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 584080.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 314276.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 445537.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 510611.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.43% of base) : 433877.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 468719.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.43% of base) : 539146.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         127 (10.47% of base) : 541960.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         121 ( 9.81% of base) : 565333.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         110 ( 8.90% of base) : 497408.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)
         110 ( 8.90% of base) : 502618.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (Tier1)

Top method improvements (bytes):
       -6917 (-7.13% of base) : 233201.dasm - i4rem:TestEntryPoint():int (FullOpts)
       -5997 (-6.54% of base) : 233194.dasm - i4div:TestEntryPoint():int (FullOpts)
       -5839 (-5.92% of base) : 233862.dasm - u8rem:TestEntryPoint():int (FullOpts)
       -5785 (-5.87% of base) : 233215.dasm - i8rem:TestEntryPoint():int (FullOpts)
       -5069 (-5.13% of base) : 233852.dasm - u4rem:TestEntryPoint():int (FullOpts)
       -4000 (-4.28% of base) : 233847.dasm - u4div:TestEntryPoint():int (FullOpts)
       -3945 (-4.24% of base) : 233208.dasm - i8div:TestEntryPoint():int (FullOpts)
       -3824 (-4.17% of base) : 233857.dasm - u8div:TestEntryPoint():int (FullOpts)
        -916 (-8.32% of base) : 313109.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (Instrumented Tier1)
        -506 (-4.45% of base) : 211377.dasm - MemoryMarshalGetArrayDataReferenceTest.Program:TestEntryPoint():int (FullOpts)
        -271 (-15.27% of base) : 233318.dasm - JitTest_lcsmixed_lcs_cs.LCS:TestEntryPoint():int (FullOpts)
        -250 (-17.25% of base) : 236162.dasm - JitTest_lcs_refany_il.LCS:findLCS(System.TypedReference,System.TypedReference,System.TypedReference,System.TypedReference) (FullOpts)
        -221 (-14.00% of base) : 233311.dasm - JitTest_lcsbox_lcs_cs.LCS:findLCS(int[,,,],int[,,,],ushort[][],int[]) (FullOpts)
        -201 (-13.25% of base) : 232622.dasm - JitTest_lcs_gcref_port.LCSV:findLCS(JitTest_lcs_gcref_port.LCSV[,,,],JitTest_lcs_gcref_port.LCSV[,,,],ushort[][],JitTest_lcs_gcref_port.LCSV[]) (FullOpts)
        -176 (-15.64% of base) : 235134.dasm - JitTest_lcs_ldlen_lcs_il.LCS:findLCS(int[,,,],int[,,,],ushort[][]) (FullOpts)
        -172 (-16.33% of base) : 233328.dasm - JitTest_lcs_lcs_cs.LCS:findLCS(int[,,,],int[,,,],ushort[][],int[]) (FullOpts)
        -161 (-12.20% of base) : 233343.dasm - JitTest_lcs_ulong_arrays_cs.LCS:findLCS(ulong[,,,],ulong[,,,],ushort[][],ulong[]) (FullOpts)
        -146 (-10.43% of base) : 576862.dasm - Internal.JitInterface.InstructionSetFlags:Set64BitInstructionSetVariants(int):this (Tier1)
        -144 (-13.07% of base) : 233323.dasm - JitTest_lcsval_lcs_cs.LCS:findLCS(JitTest_lcsval_lcs_cs.Data[,,,],ushort[][],int[]) (FullOpts)
        -128 (-0.91% of base) : 287930.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.TypeValidationChecker+<ValidateTypeWorker>d__10:MoveNext():this (FullOpts)

Top method regressions (percentages):
          15 (166.67% of base) : 250088.dasm - Test.BB:TestEntryPoint() (FullOpts)
          16 (145.45% of base) : 236244.dasm - JitTest_ldobj_I_ldobj_il.Test:method_4_0(long):long (FullOpts)
          16 (145.45% of base) : 236247.dasm - JitTest_ldobj_I_ldobj_il.Test:method_4_3(long):long (FullOpts)
          16 (145.45% of base) : 236215.dasm - JitTest_ldobj_I8_ldobj_il.Test:method_4_0(long):long (FullOpts)
          16 (145.45% of base) : 236218.dasm - JitTest_ldobj_I8_ldobj_il.Test:method_4_3(long):long (FullOpts)
          16 (145.45% of base) : 236343.dasm - JitTest_ldobj_U2_ldobj_il.Test:method_4_0(ushort):ushort (FullOpts)
          16 (145.45% of base) : 236346.dasm - JitTest_ldobj_U2_ldobj_il.Test:method_4_3(ushort):ushort (FullOpts)
          16 (145.45% of base) : 236381.dasm - JitTest_ldobj_V_ldobj_il.Test:method_4_0(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)
          16 (145.45% of base) : 236384.dasm - JitTest_ldobj_V_ldobj_il.Test:method_4_3(JitTest_ldobj_V_ldobj_il.ValueClass):JitTest_ldobj_V_ldobj_il.ValueClass (FullOpts)
          16 (123.08% of base) : 236275.dasm - JitTest_ldobj_R4_ldobj_il.Test:method_4_0(float):float (FullOpts)
          16 (123.08% of base) : 236278.dasm - JitTest_ldobj_R4_ldobj_il.Test:method_4_3(float):float (FullOpts)
          16 (123.08% of base) : 236315.dasm - JitTest_ldobj_R8_ldobj_il.Test:method_4_0(double):double (FullOpts)
          16 (123.08% of base) : 236318.dasm - JitTest_ldobj_R8_ldobj_il.Test:method_4_3(double):double (FullOpts)
          15 (46.88% of base) : 241927.dasm - Test.BB:Method2(uint,Test.BB):uint[] (FullOpts)
          16 (39.02% of base) : 250005.dasm - Test.AA:Main1() (FullOpts)
          22 (14.57% of base) : 18443.dasm - testout1:Sub_Funclet_223():int (FullOpts)
          15 (14.15% of base) : 249508.dasm - Test.BB:TestEntryPoint() (FullOpts)
          20 (13.79% of base) : 16189.dasm - testout1:Sub_Funclet_127():int (FullOpts)
          20 (13.79% of base) : 18400.dasm - testout1:Sub_Funclet_175():int (FullOpts)
          20 (13.79% of base) : 18848.dasm - testout1:Sub_Funclet_239():int (FullOpts)

Top method improvements (percentages):
         -12 (-35.29% of base) : 190955.dasm - P:TestByPtr(ulong):int (FullOpts)
         -50 (-24.88% of base) : 16293.dasm - testout1:Sub_Funclet_235():int (FullOpts)
         -50 (-24.88% of base) : 16442.dasm - testout1:Sub_Funclet_389():int (FullOpts)
         -50 (-24.88% of base) : 16480.dasm - testout1:Sub_Funclet_427():int (FullOpts)
         -44 (-22.56% of base) : 15836.dasm - testout1:Sub_Funclet_195():int (FullOpts)
         -42 (-21.11% of base) : 16253.dasm - testout1:Sub_Funclet_195():int (FullOpts)
         -39 (-20.21% of base) : 16103.dasm - testout1:Sub_Funclet_3():int (FullOpts)
         -39 (-20.21% of base) : 16602.dasm - testout1:Sub_Funclet_3():int (FullOpts)
          -2 (-20.00% of base) : 578278.dasm - System.Collections.Generic.SortedDictionary`2[ushort,System.__Canon]:get_Count():int:this (Tier1)
          -2 (-20.00% of base) : 246317.dasm - System.Xml.XmlTextReaderImpl:get_LineNumber():int:this (FullOpts)
          -2 (-20.00% of base) : 246318.dasm - System.Xml.XmlTextReaderImpl:get_LinePosition():int:this (FullOpts)
         -28 (-19.72% of base) : 173411.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MethodTypeInferrer:SetUnknownsToNotDependent():this (FullOpts)
         -32 (-17.49% of base) : 16368.dasm - testout1:Sub_Funclet_311():int (FullOpts)
         -32 (-17.49% of base) : 16406.dasm - testout1:Sub_Funclet_349():int (FullOpts)
        -250 (-17.25% of base) : 236162.dasm - JitTest_lcs_refany_il.LCS:findLCS(System.TypedReference,System.TypedReference,System.TypedReference,System.TypedReference) (FullOpts)
         -32 (-16.84% of base) : 16219.dasm - testout1:Sub_Funclet_157():int (FullOpts)
         -32 (-16.84% of base) : 16255.dasm - testout1:Sub_Funclet_197():int (FullOpts)
         -32 (-16.84% of base) : 16604.dasm - testout1:Sub_Funclet_5():int (FullOpts)
         -32 (-16.84% of base) : 16105.dasm - testout1:Sub_Funclet_5():int (FullOpts)
        -172 (-16.33% of base) : 233328.dasm - JitTest_lcs_lcs_cs.LCS:findLCS(int[,,,],int[,,,],ushort[][],int[]) (FullOpts)

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

Total bytes of base: 45112454 (overridden on cmd)
Total bytes of diff: 45099093 (overridden on cmd)
Total bytes of delta: -13361 (-0.03 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          16 : 216078.dasm (1.68% of base)
          16 : 213939.dasm (1.68% of base)
          12 : 167253.dasm (4.98% of base)
          11 : 22933.dasm (2.40% of base)
           9 : 154267.dasm (6.62% of base)
           6 : 53828.dasm (1.42% of base)
           5 : 185600.dasm (1.93% of base)
           5 : 15232.dasm (0.96% of base)
           5 : 22833.dasm (0.98% of base)
           5 : 22193.dasm (5.49% of base)
           2 : 151871.dasm (1.42% of base)
           2 : 151874.dasm (0.38% of base)
           2 : 89703.dasm (0.86% of base)
           1 : 215226.dasm (0.02% of base)
           1 : 123487.dasm (0.16% of base)
           1 : 263354.dasm (1.12% of base)
           1 : 213073.dasm (0.02% of base)
           1 : 23142.dasm (1.01% of base)
           1 : 9696.dasm (0.18% of base)
           1 : 54924.dasm (0.07% of base)

Top file improvements (bytes):
         -74 : 158563.dasm (-4.38% of base)
         -52 : 184861.dasm (-8.51% of base)
         -44 : 260306.dasm (-4.04% of base)
         -42 : 53842.dasm (-0.91% of base)
         -37 : 183762.dasm (-7.36% of base)
         -35 : 184220.dasm (-4.95% of base)
         -35 : 175021.dasm (-1.28% of base)
         -34 : 175053.dasm (-1.74% of base)
         -33 : 185067.dasm (-4.15% of base)
         -32 : 174923.dasm (-0.34% of base)
         -30 : 199513.dasm (-2.29% of base)
         -30 : 229734.dasm (-2.17% of base)
         -28 : 33282.dasm (-0.70% of base)
         -28 : 175238.dasm (-19.58% of base)
         -28 : 175250.dasm (-19.86% of base)
         -27 : 22185.dasm (-0.68% of base)
         -27 : 157353.dasm (-0.75% of base)
         -27 : 175035.dasm (-3.11% of base)
         -26 : 196241.dasm (-3.11% of base)
         -26 : 183651.dasm (-1.45% of base)

79 total files with Code Size differences (57 improved, 22 regressed), 20 unchanged.

Top method regressions (bytes):
          16 ( 1.68% of base) : 216078.dasm - System.Configuration.MgmtConfigurationRecord:RemoveConfigurationSection(System.String,System.String):this (FullOpts)
          16 ( 1.68% of base) : 213939.dasm - System.Configuration.MgmtConfigurationRecord:RemoveConfigurationSection(System.String,System.String):this (FullOpts)
          12 ( 4.98% of base) : 167253.dasm - System.Text.Json.Utf8JsonReader:GetNextSpan():ubyte:this (FullOpts)
          11 ( 2.40% of base) : 22933.dasm - System.__DTString:GetRegularToken(byref,byref,System.Globalization.DateTimeFormatInfo):this (FullOpts)
           9 ( 6.62% of base) : 154267.dasm - System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
           6 ( 1.42% of base) : 53828.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
           5 ( 5.49% of base) : 22193.dasm - System.__DTString:SkipWhiteSpaces():this (FullOpts)
           5 ( 1.93% of base) : 185600.dasm - System.Reflection.Metadata.Ecma335.MetadataAggregator:CalculateDeltaRowCountsForGeneration(System.Reflection.Metadata.Ecma335.MetadataAggregator+RowCounts[][],int,byref) (FullOpts)
           5 ( 0.96% of base) : 15232.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.98% of base) : 22833.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[ubyte](ubyte):this (FullOpts)
           2 ( 0.86% of base) : 89703.dasm - Internal.Cryptography.Pal.Windows.PkcsPalWindows+EncodeHelpers:EncodeRecipientId(System.Security.Cryptography.Pkcs.CmsRecipient,Microsoft.Win32.SafeHandles.SafeCertContextHandle,ulong,ulong,Internal.Cryptography.Pal.Windows.HeapBlockRetainer):Interop+Crypt32+CERT_ID (FullOpts)
           2 ( 1.42% of base) : 151871.dasm - System.Xml.Xsl.Runtime.XPathPrecedingDocOrderIterator:MoveNext():ubyte:this (FullOpts)
           2 ( 0.38% of base) : 151874.dasm - System.Xml.Xsl.Runtime.XPathPrecedingMergeIterator:MoveNext(System.Xml.XPath.XPathNavigator):int:this (FullOpts)
           1 ( 0.07% of base) : 54924.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInstanceMemberAccess(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.String,int,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
           1 ( 0.16% of base) : 123487.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitPossibleConditionalAccess(Microsoft.CodeAnalysis.CSharp.BoundExpression,byref):ubyte:this (FullOpts)
           1 ( 0.05% of base) : 213052.dasm - System.Configuration.BaseConfigurationRecord:InitConfigFromFile():this (FullOpts)
           1 ( 0.02% of base) : 215226.dasm - System.Configuration.BaseConfigurationRecord:ScanFactoriesRecursive(System.Configuration.XmlUtil,System.String,System.Collections.Hashtable):this (FullOpts)
           1 ( 0.02% of base) : 213073.dasm - System.Configuration.BaseConfigurationRecord:ScanFactoriesRecursive(System.Configuration.XmlUtil,System.String,System.Collections.Hashtable):this (FullOpts)
           1 ( 1.01% of base) : 23142.dasm - System.Diagnostics.Tracing.ManifestBuilder:TranslateIndexToManifestConvention(int,System.String):int:this (FullOpts)
           1 ( 0.18% of base) : 9696.dasm - System.Reflection.RuntimeMethodInfo:MakeGenericMethod(System.Type[]):System.Reflection.MethodInfo:this (FullOpts)

Top method improvements (bytes):
         -74 (-4.38% of base) : 158563.dasm - System.Xml.Xsl.Xslt.XsltLoader:LoadRealStylesheet():this (FullOpts)
         -52 (-8.51% of base) : 184861.dasm - System.Reflection.Metadata.PropertyDefinition:GetAccessors():System.Reflection.Metadata.PropertyAccessors:this (FullOpts)
         -44 (-4.04% of base) : 260306.dasm - System.Uri:PrivateParseMinimal():int:this (FullOpts)
         -42 (-0.91% of base) : 53842.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (FullOpts)
         -37 (-7.36% of base) : 183762.dasm - System.Reflection.Metadata.AssemblyDefinition:GetAssemblyName():System.Reflection.AssemblyName:this (FullOpts)
         -35 (-1.28% of base) : 175021.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:AdjustCallArgumentsForParams(Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.MethodOrPropertySymbol,Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray,Microsoft.CSharp.RuntimeBinder.Semantics.Expr,byref):this (FullOpts)
         -35 (-4.95% of base) : 184220.dasm - System.Reflection.Metadata.EventDefinition:GetAccessors():System.Reflection.Metadata.EventAccessors:this (FullOpts)
         -34 (-1.74% of base) : 175053.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MemberLookup:SearchSingleType(Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType,byref):ubyte:this (FullOpts)
         -33 (-4.15% of base) : 185067.dasm - System.Reflection.Metadata.Ecma335.ExceptionRegionEncoder:AddUnchecked(ushort,int,int,int,int,int):this (FullOpts)
         -32 (-0.34% of base) : 174923.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:bindUserDefinedConversion(Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.CType,ubyte,byref,ubyte):ubyte:this (FullOpts)
         -30 (-2.29% of base) : 199513.dasm - Microsoft.CodeAnalysis.SeparatedSyntaxList`1[System.__Canon]:InsertRange(int,System.Collections.Generic.IEnumerable`1[System.__Canon]):Microsoft.CodeAnalysis.SeparatedSyntaxList`1[System.__Canon]:this (FullOpts)
         -30 (-2.17% of base) : 229734.dasm - Microsoft.CodeAnalysis.SeparatedSyntaxList`1[System.__Canon]:InsertRange(int,System.Collections.Generic.IEnumerable`1[System.__Canon]):Microsoft.CodeAnalysis.SeparatedSyntaxList`1[System.__Canon]:this (FullOpts)
         -28 (-19.86% of base) : 175250.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MethodTypeInferrer:SetIndirectsToUnknown():this (FullOpts)
         -28 (-19.58% of base) : 175238.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MethodTypeInferrer:SetUnknownsToNotDependent():this (FullOpts)
         -28 (-0.70% of base) : 33282.dasm - Microsoft.Diagnostics.Tracing.ThreadTimeStackComputer:GenerateThreadTimeStacks(Microsoft.Diagnostics.Tracing.Stacks.MutableTraceEventStackSource,Microsoft.Diagnostics.Tracing.Etlx.TraceEvents):this (FullOpts)
         -27 (-3.11% of base) : 175035.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:BindLiftedUDBinop(int,Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray,Microsoft.CSharp.RuntimeBinder.Semantics.MethPropWithInst):Microsoft.CSharp.RuntimeBinder.Semantics.ExprCall:this (FullOpts)
         -27 (-0.68% of base) : 22185.dasm - System.DateTimeParse:ParseByFormat(byref,byref,byref,System.Globalization.DateTimeFormatInfo,byref):ubyte (FullOpts)
         -27 (-0.75% of base) : 157353.dasm - System.Xml.Serialization.XmlSerializationReaderILGen:WritePrimitive(System.Xml.Serialization.TypeMapping,System.String):this (FullOpts)
         -26 (-3.11% of base) : 196241.dasm - Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter:GetDeltaTableSizes(System.Collections.Immutable.ImmutableArray`1[int]):System.Collections.Immutable.ImmutableArray`1[int]:this (FullOpts)
         -26 (-1.45% of base) : 183651.dasm - System.Reflection.Metadata.BlobWriterImpl:WriteConstant(System.Reflection.Metadata.BlobBuilder,System.Object) (FullOpts)

Top method regressions (percentages):
           9 ( 6.62% of base) : 154267.dasm - System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
           5 ( 5.49% of base) : 22193.dasm - System.__DTString:SkipWhiteSpaces():this (FullOpts)
          12 ( 4.98% of base) : 167253.dasm - System.Text.Json.Utf8JsonReader:GetNextSpan():ubyte:this (FullOpts)
          11 ( 2.40% of base) : 22933.dasm - System.__DTString:GetRegularToken(byref,byref,System.Globalization.DateTimeFormatInfo):this (FullOpts)
           5 ( 1.93% of base) : 185600.dasm - System.Reflection.Metadata.Ecma335.MetadataAggregator:CalculateDeltaRowCountsForGeneration(System.Reflection.Metadata.Ecma335.MetadataAggregator+RowCounts[][],int,byref) (FullOpts)
          16 ( 1.68% of base) : 216078.dasm - System.Configuration.MgmtConfigurationRecord:RemoveConfigurationSection(System.String,System.String):this (FullOpts)
          16 ( 1.68% of base) : 213939.dasm - System.Configuration.MgmtConfigurationRecord:RemoveConfigurationSection(System.String,System.String):this (FullOpts)
           2 ( 1.42% of base) : 151871.dasm - System.Xml.Xsl.Runtime.XPathPrecedingDocOrderIterator:MoveNext():ubyte:this (FullOpts)
           6 ( 1.42% of base) : 53828.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
           1 ( 1.12% of base) : 263354.dasm - System.Text.Encodings.Web.TextEncoderSettings:AllowRange(System.Text.Unicode.UnicodeRange):this (FullOpts)
           1 ( 1.06% of base) : 263359.dasm - System.Text.Encodings.Web.TextEncoderSettings:ForbidRange(System.Text.Unicode.UnicodeRange):this (FullOpts)
           1 ( 1.01% of base) : 23142.dasm - System.Diagnostics.Tracing.ManifestBuilder:TranslateIndexToManifestConvention(int,System.String):int:this (FullOpts)
           5 ( 0.98% of base) : 22833.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[ubyte](ubyte):this (FullOpts)
           5 ( 0.96% of base) : 15232.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           2 ( 0.86% of base) : 89703.dasm - Internal.Cryptography.Pal.Windows.PkcsPalWindows+EncodeHelpers:EncodeRecipientId(System.Security.Cryptography.Pkcs.CmsRecipient,Microsoft.Win32.SafeHandles.SafeCertContextHandle,ulong,ulong,Internal.Cryptography.Pal.Windows.HeapBlockRetainer):Interop+Crypt32+CERT_ID (FullOpts)
           2 ( 0.38% of base) : 151874.dasm - System.Xml.Xsl.Runtime.XPathPrecedingMergeIterator:MoveNext(System.Xml.XPath.XPathNavigator):int:this (FullOpts)
           1 ( 0.18% of base) : 9696.dasm - System.Reflection.RuntimeMethodInfo:MakeGenericMethod(System.Type[]):System.Reflection.MethodInfo:this (FullOpts)
           1 ( 0.16% of base) : 123487.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:VisitPossibleConditionalAccess(Microsoft.CodeAnalysis.CSharp.BoundExpression,byref):ubyte:this (FullOpts)
           1 ( 0.07% of base) : 54924.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInstanceMemberAccess(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BoundExpression,System.String,int,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],ubyte,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
           1 ( 0.05% of base) : 213052.dasm - System.Configuration.BaseConfigurationRecord:InitConfigFromFile():this (FullOpts)

Top method improvements (percentages):
          -2 (-28.57% of base) : 83648.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__272_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
          -2 (-28.57% of base) : 143159.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
          -2 (-28.57% of base) : 255824.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
          -2 (-22.22% of base) : 111211.dasm - Microsoft.CodeAnalysis.VisualBasic.SyntaxTreeDiagnosticEnumerator:Pop():this (FullOpts)
          -2 (-20.00% of base) : 149032.dasm - System.Xml.XmlTextReaderImpl:get_LineNumber():int:this (FullOpts)
          -2 (-20.00% of base) : 149033.dasm - System.Xml.XmlTextReaderImpl:get_LinePosition():int:this (FullOpts)
         -28 (-19.86% of base) : 175250.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MethodTypeInferrer:SetIndirectsToUnknown():this (FullOpts)
         -28 (-19.58% of base) : 175238.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MethodTypeInferrer:SetUnknownsToNotDependent():this (FullOpts)
          -2 (-18.18% of base) : 146696.dasm - Microsoft.CodeAnalysis.CSharp.BoundNodeExtensions:MakeCompilerGenerated[System.__Canon](System.__Canon):System.__Canon (FullOpts)
          -2 (-18.18% of base) : 199695.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder`1[System.__Canon]:Clear():this (FullOpts)
          -2 (-18.18% of base) : 229933.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder`1[System.__Canon]:Clear():this (FullOpts)
          -2 (-18.18% of base) : 199714.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder`1[System.__Canon]:Clear():this (FullOpts)
          -2 (-18.18% of base) : 199650.dasm - Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder`1[System.__Canon]:Clear():this (FullOpts)
          -2 (-18.18% of base) : 229869.dasm - Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder`1[System.__Canon]:Clear():this (FullOpts)
          -2 (-18.18% of base) : 199665.dasm - Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder`1[System.__Canon]:Clear():this (FullOpts)
          -2 (-18.18% of base) : 10265.dasm - System.Reflection.Emit.RuntimeEnumBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 10306.dasm - System.Reflection.Emit.RuntimeFieldBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 10319.dasm - System.Reflection.Emit.RuntimeGenericTypeParameterBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 10377.dasm - System.Reflection.Emit.RuntimeMethodBuilder:get_Module():System.Reflection.Module:this (FullOpts)
          -2 (-18.18% of base) : 10450.dasm - System.Reflection.Emit.RuntimePropertyBuilder:get_Module():System.Reflection.Module:this (FullOpts)

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

Total bytes of base: 61521797 (overridden on cmd)
Total bytes of diff: 61438384 (overridden on cmd)
Total bytes of delta: -83413 (-0.14 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          24 : 210648.dasm (5.53% of base)
          24 : 271171.dasm (5.53% of base)
          17 : 57092.dasm (0.60% of base)
          14 : 56925.dasm (1.19% of base)
          13 : 232809.dasm (2.00% of base)
          12 : 210646.dasm (8.51% of base)
          12 : 271167.dasm (4.48% of base)
          12 : 210644.dasm (4.48% of base)
          12 : 271169.dasm (8.51% of base)
          11 : 97442.dasm (0.13% of base)
          11 : 75083.dasm (1.99% of base)
          10 : 137062.dasm (1.96% of base)
          10 : 137058.dasm (7.63% of base)
           9 : 104.dasm (1.75% of base)
           9 : 131399.dasm (6.77% of base)
           6 : 204875.dasm (4.29% of base)
           6 : 90676.dasm (1.52% of base)
           6 : 156724.dasm (0.62% of base)
           6 : 172681.dasm (0.62% of base)
           6 : 197157.dasm (0.62% of base)

Top file improvements (bytes):
        -156 : 82336.dasm (-3.11% of base)
        -148 : 242700.dasm (-2.16% of base)
        -127 : 33311.dasm (-0.90% of base)
        -123 : 310297.dasm (-1.48% of base)
         -95 : 58260.dasm (-5.64% of base)
         -93 : 33045.dasm (-2.84% of base)
         -93 : 33049.dasm (-2.36% of base)
         -78 : 61679.dasm (-1.58% of base)
         -77 : 36056.dasm (-20.42% of base)
         -76 : 110486.dasm (-1.92% of base)
         -76 : 255278.dasm (-2.18% of base)
         -76 : 249222.dasm (-1.97% of base)
         -74 : 135816.dasm (-4.50% of base)
         -72 : 56648.dasm (-1.19% of base)
         -67 : 295997.dasm (-6.50% of base)
         -65 : 67024.dasm (-0.75% of base)
         -64 : 179828.dasm (-1.21% of base)
         -63 : 142594.dasm (-4.66% of base)
         -62 : 30449.dasm (-6.81% of base)
         -60 : 299319.dasm (-2.06% of base)

88 total files with Code Size differences (60 improved, 28 regressed), 20 unchanged.

Top method regressions (bytes):
          24 ( 5.53% of base) : 210648.dasm - System.Data.ProviderBase.DbBuffer:ReadDateTime(int):System.DateTime:this (FullOpts)
          24 ( 5.53% of base) : 271171.dasm - System.Data.ProviderBase.DbBuffer:ReadDateTime(int):System.DateTime:this (FullOpts)
          17 ( 0.60% of base) : 57092.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ConstructBoundMemberGroupAndReportOmittedTypeArguments(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.String,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol],Microsoft.CodeAnalysis.CSharp.LookupResult,int,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundMethodOrPropertyGroup:this (FullOpts)
          14 ( 1.19% of base) : 56925.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ReportQueryInferenceFailed(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode,System.String,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.AnalyzedArguments,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbol],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag) (FullOpts)
          13 ( 2.00% of base) : 232809.dasm - System.Speech.Internal.Synthesis.TextWriterEngine:ProcessSpeak(System.String,System.String,System.Globalization.CultureInfo,System.Collections.Generic.List`1[System.Speech.Internal.Synthesis.SsmlXmlAttribute]):System.Object:this (FullOpts)
          12 ( 4.48% of base) : 271167.dasm - System.Data.ProviderBase.DbBuffer:ReadDate(int):System.DateTime:this (FullOpts)
          12 ( 4.48% of base) : 210644.dasm - System.Data.ProviderBase.DbBuffer:ReadDate(int):System.DateTime:this (FullOpts)
          12 ( 8.51% of base) : 210646.dasm - System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)
          12 ( 8.51% of base) : 271169.dasm - System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)
          11 ( 1.99% of base) : 75083.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
          11 ( 0.13% of base) : 97442.dasm - Microsoft.CodeAnalysis.VisualBasic.Symbols.SynthesizedPropertyAccessorHelper:GetBoundMethodBody(Microsoft.CodeAnalysis.VisualBasic.Symbols.MethodSymbol,Microsoft.CodeAnalysis.VisualBasic.Symbols.FieldSymbol,byref):Microsoft.CodeAnalysis.VisualBasic.BoundBlock (FullOpts)
          10 ( 7.63% of base) : 137058.dasm - System.Xml.Xsl.Runtime.XPathPrecedingDocOrderIterator:MoveNext():ubyte:this (FullOpts)
          10 ( 1.96% of base) : 137062.dasm - System.Xml.Xsl.Runtime.XPathPrecedingMergeIterator:MoveNext(System.Xml.XPath.XPathNavigator):int:this (FullOpts)
           9 ( 1.75% of base) : 104.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
           9 ( 6.77% of base) : 131399.dasm - System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
           6 ( 0.62% of base) : 156724.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:InsertRange(int,System.Collections.Generic.IEnumerable`1[ubyte]):this (FullOpts)
           6 ( 0.62% of base) : 172681.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:InsertRange(int,System.Collections.Generic.IEnumerable`1[ubyte]):this (FullOpts)
           6 ( 0.62% of base) : 197157.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[ubyte]:InsertRange(int,System.Collections.Generic.IEnumerable`1[ubyte]):this (FullOpts)
           6 ( 1.52% of base) : 90676.dasm - Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor+PartVisitor:VisitArrayType(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol,System.Text.StringBuilder):System.Object:this (FullOpts)
           6 ( 4.29% of base) : 204875.dasm - System.Xml.XPathNodePointer:get_Node():System.Xml.XmlNode:this (FullOpts)

Top method improvements (bytes):
        -156 (-3.11% of base) : 82336.dasm - Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder:GetSynthesizedTypesFromMetadata(System.Reflection.Metadata.MetadataReader,Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder):Microsoft.CodeAnalysis.Emit.SynthesizedTypeMaps (FullOpts)
        -148 (-2.16% of base) : 242700.dasm - ILCompiler.Reflection.ReadyToRun.SignatureDecoder:ParseHelper(System.Text.StringBuilder):this (FullOpts)
        -127 (-0.90% of base) : 33311.dasm - ILCompiler.DependencyAnalysis.ReadyToRun.TypeValidationChecker+<ValidateTypeWorker>d__10:MoveNext():this (FullOpts)
        -123 (-1.48% of base) : 310297.dasm - ILCompiler.Program:RunSingleCompilation(System.Collections.Generic.Dictionary`2[System.String,System.String],ILCompiler.InstructionSetSupport,System.String,System.Collections.Generic.Dictionary`2[System.String,System.String],System.Collections.Generic.HashSet`1[Internal.TypeSystem.ModuleDesc],ILCompiler.ReadyToRunCompilerContext,ILCompiler.Logger):this (FullOpts)
         -95 (-5.64% of base) : 58260.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BinaryOperatorOverloadResolution(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult,byref):this (FullOpts)
         -93 (-2.36% of base) : 33049.dasm - ILCompiler.ReadyToRunMetadataFieldLayoutAlgorithm+ModuleFieldLayoutMap:CalculateTypeLayout(Internal.TypeSystem.DefType,Internal.TypeSystem.Ecma.EcmaModule,byref):Internal.TypeSystem.FieldAndOffset[]:this (FullOpts)
         -93 (-2.84% of base) : 33045.dasm - ILCompiler.ReadyToRunMetadataFieldLayoutAlgorithm+ModuleFieldLayoutMap:CreateValueFromKey(Internal.TypeSystem.Ecma.EcmaModule):ILCompiler.ReadyToRunMetadataFieldLayoutAlgorithm+ModuleFieldLayout:this (FullOpts)
         -78 (-1.58% of base) : 61679.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:ConstructFieldLikeEventAccessorBody_Regular(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundBlock (FullOpts)
         -77 (-20.42% of base) : 36056.dasm - Microsoft.Diagnostics.Tracing.Stacks.TraceEventStackSource:GetCallerIndex(int):int:this (FullOpts)
         -76 (-1.92% of base) : 110486.dasm - Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.Parser:ParseTerm(ubyte,ubyte):Microsoft.CodeAnalysis.VisualBasic.Syntax.InternalSyntax.ExpressionSyntax:this (FullOpts)
         -76 (-1.97% of base) : 249222.dasm - R2RDump.Program:Run():int:this (FullOpts)
         -76 (-2.18% of base) : 255278.dasm - R2RTest.BuildOptions:.ctor(R2RTest.R2RTestRootCommand,System.CommandLine.ParseResult):this (FullOpts)
         -74 (-4.50% of base) : 135816.dasm - System.Xml.Xsl.Xslt.XsltLoader:LoadRealStylesheet():this (FullOpts)
         -72 (-1.19% of base) : 56648.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInterpolatedStringHandlerInMemberCall(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BoundExpression],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],byref,int,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (FullOpts)
         -67 (-6.50% of base) : 295997.dasm - System.Uri:PrivateParseMinimal():int:this (FullOpts)
         -65 (-0.75% of base) : 67024.dasm - Microsoft.CodeAnalysis.CSharp.CSharpDeclarationComputer:ComputeDeclarations(Microsoft.CodeAnalysis.SemanticModel,Microsoft.CodeAnalysis.ISymbol,Microsoft.CodeAnalysis.SyntaxNode,System.Func`3[Microsoft.CodeAnalysis.SyntaxNode,System.Nullable`1[int],ubyte],ubyte,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.DeclarationInfo],System.Nullable`1[int],System.Threading.CancellationToken) (FullOpts)
         -64 (-1.21% of base) : 179828.dasm - Microsoft.Build.Shared.LogMessagePacketBase:GetBuildEventArgFromId():Microsoft.Build.Framework.BuildEventArgs:this (FullOpts)
         -63 (-4.66% of base) : 142594.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder:BindLiftedUDBinop(int,Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.Expr,Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray,Microsoft.CSharp.RuntimeBinder.Semantics.MethPropWithInst):Microsoft.CSharp.RuntimeBinder.Semantics.ExprCall:this (FullOpts)
         -62 (-6.81% of base) : 30449.dasm - Internal.JitInterface.InstructionSetFlags:Set64BitInstructionSetVariants(int):this (FullOpts)
         -60 (-2.06% of base) : 299319.dasm - System.Reflection.TypeLoading.Ecma.EcmaModule:GetTypeCoreNoCache(System.ReadOnlySpan`1[ubyte],System.ReadOnlySpan`1[ubyte],byref):System.Reflection.TypeLoading.RoDefinitionType:this (FullOpts)

Top method regressions (percentages):
           1 (14.29% of base) : 245543.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
           1 (14.29% of base) : 245545.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
          12 ( 8.51% of base) : 210646.dasm - System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)
          12 ( 8.51% of base) : 271169.dasm - System.Data.ProviderBase.DbBuffer:ReadTime(int):System.TimeSpan:this (FullOpts)
          10 ( 7.63% of base) : 137058.dasm - System.Xml.Xsl.Runtime.XPathPrecedingDocOrderIterator:MoveNext():ubyte:this (FullOpts)
           9 ( 6.77% of base) : 131399.dasm - System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
          24 ( 5.53% of base) : 210648.dasm - System.Data.ProviderBase.DbBuffer:ReadDateTime(int):System.DateTime:this (FullOpts)
          24 ( 5.53% of base) : 271171.dasm - System.Data.ProviderBase.DbBuffer:ReadDateTime(int):System.DateTime:this (FullOpts)
           4 ( 5.26% of base) : 242470.dasm - ILCompiler.Reflection.ReadyToRun.NativeReader:ReadUInt16(ubyte[],byref):ushort (FullOpts)
          12 ( 4.48% of base) : 271167.dasm - System.Data.ProviderBase.DbBuffer:ReadDate(int):System.DateTime:this (FullOpts)
          12 ( 4.48% of base) : 210644.dasm - System.Data.ProviderBase.DbBuffer:ReadDate(int):System.DateTime:this (FullOpts)
           6 ( 4.29% of base) : 204875.dasm - System.Xml.XPathNodePointer:get_Node():System.Xml.XmlNode:this (FullOpts)
           4 ( 2.00% of base) : 302532.dasm - System.Security.Cryptography.Cose.CoseMultiSignMessage:.ctor(System.Security.Cryptography.Cose.CoseHeaderMap,System.Security.Cryptography.Cose.CoseHeaderMap,ubyte[],System.Collections.Generic.List`1[System.Security.Cryptography.Cose.CoseSignature],ubyte[],ubyte):this (FullOpts)
          13 ( 2.00% of base) : 232809.dasm - System.Speech.Internal.Synthesis.TextWriterEngine:ProcessSpeak(System.String,System.String,System.Globalization.CultureInfo,System.Collections.Generic.List`1[System.Speech.Internal.Synthesis.SsmlXmlAttribute]):System.Object:this (FullOpts)
          11 ( 1.99% of base) : 75083.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
          10 ( 1.96% of base) : 137062.dasm - System.Xml.Xsl.Runtime.XPathPrecedingMergeIterator:MoveNext(System.Xml.XPath.XPathNavigator):int:this (FullOpts)
           5 ( 1.90% of base) : 170576.dasm - System.Reflection.Metadata.Ecma335.MetadataAggregator:CalculateDeltaRowCountsForGeneration(System.Reflection.Metadata.Ecma335.MetadataAggregator+RowCounts[][],int,byref) (FullOpts)
           4 ( 1.89% of base) : 104320.dasm - Microsoft.CodeAnalysis.VisualBasic.VBSemanticModel:LookupInstanceConstructors(Microsoft.CodeAnalysis.VisualBasic.Binder,Microsoft.CodeAnalysis.VisualBasic.Symbols.NamespaceOrTypeSymbol,int,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.VisualBasic.Symbol]):this (FullOpts)
           2 ( 1.80% of base) : 61846.dasm - Microsoft.CodeAnalysis.CSharp.CSharpExtensions:GetDirectives(Microsoft.CodeAnalysis.SyntaxNode,System.Func`2[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax,ubyte]):System.Collections.Generic.IList`1[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax] (FullOpts)
           2 ( 1.80% of base) : 120237.dasm - Microsoft.CodeAnalysis.VisualBasic.VisualBasicExtensions:GetDirectives(Microsoft.CodeAnalysis.SyntaxNode,System.Func`2[Microsoft.CodeAnalysis.VisualBasic.Syntax.DirectiveTriviaSyntax,ubyte]):System.Collections.Generic.IList`1[Microsoft.CodeAnalysis.VisualBasic.Syntax.DirectiveTriviaSyntax] (FullOpts)

Top method improvements (percentages):
          -2 (-33.33% of base) : 5953.dasm - <StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1957-2[int]:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 5964.dasm - <StartupCode$FSharp-Core>.$Async+AwaitAndBindChildResult@1964-5[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 5667.dasm - <StartupCode$FSharp-Core>.$Async+Return@1406[int]:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 5665.dasm - <StartupCode$FSharp-Core>.$Async+Return@1406[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 4517.dasm - <StartupCode$FSharp-Core>.$Mailbox+PostAndAsyncReply@480-2[int]:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 4515.dasm - <StartupCode$FSharp-Core>.$Mailbox+PostAndAsyncReply@480-2[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 4397.dasm - <StartupCode$FSharp-Core>.$Mailbox+processFirstArrival@322-11[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 4322.dasm - <StartupCode$FSharp-Core>.$Mailbox+Scan@267-6[int]:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 4331.dasm - <StartupCode$FSharp-Core>.$Mailbox+Scan@268-7[int]:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 4329.dasm - <StartupCode$FSharp-Core>.$Mailbox+Scan@268-7[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 7142.dasm - <StartupCode$FSharp-Core>.$Quotations+expr@293:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 10317.dasm - Microsoft.FSharp.Collections.ListModule+equalityCheck@457[int]:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 10313.dasm - Microsoft.FSharp.Collections.ListModule+equalityCheck@457[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 12619.dasm - Microsoft.FSharp.Control.LazyExtensions+CreateFromValue@7036[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 15818.dasm - Microsoft.FSharp.Core.LanguagePrimitives+HashCompare+GenericComparer:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 2381.dasm - Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject`1[ubyte]:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 6918.dasm - Microsoft.FSharp.Quotations.PatternsModule+u_constSpec@2143-14:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 6920.dasm - Microsoft.FSharp.Quotations.PatternsModule+u_constSpec@2145-15:.ctor(ubyte):this (FullOpts)
          -2 (-33.33% of base) : 6817.dasm - Microsoft.FSharp.Quotations.PatternsModule+u_dtype@1904:.ctor(int):this (FullOpts)
          -2 (-33.33% of base) : 8137.dasm - Microsoft.FSharp.Reflection.Impl+tagField@425:.ctor(int):this (FullOpts)

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

Total bytes of base: 285135939 (overridden on cmd)
Total bytes of diff: 285024604 (overridden on cmd)
Total bytes of delta: -111335 (-0.04 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
         212 : 660340.dasm (2.64% of base)
         105 : 619441.dasm (3.75% of base)
          99 : 319698.dasm (0.66% of base)
          97 : 334450.dasm (0.65% of base)
          87 : 330683.dasm (0.58% of base)
          79 : 59012.dasm (3.07% of base)
          58 : 691943.dasm (3.88% of base)
          38 : 644854.dasm (0.42% of base)
          35 : 129169.dasm (8.56% of base)
          35 : 340011.dasm (8.56% of base)
          34 : 52931.dasm (2.21% of base)
          29 : 91750.dasm (0.52% of base)
          27 : 305313.dasm (1.79% of base)
          27 : 343754.dasm (1.81% of base)
          26 : 386392.dasm (7.98% of base)
          25 : 622297.dasm (13.02% of base)
          20 : 190895.dasm (0.20% of base)
          15 : 448510.dasm (2.68% of base)
          14 : 252635.dasm (4.19% of base)
          14 : 445833.dasm (2.39% of base)

Top file improvements (bytes):
        -240 : 619433.dasm (-3.85% of base)
        -203 : 660638.dasm (-3.49% of base)
        -174 : 192287.dasm (-3.46% of base)
        -168 : 111410.dasm (-1.23% of base)
        -160 : 92579.dasm (-0.81% of base)
        -158 : 659992.dasm (-0.88% of base)
        -139 : 89402.dasm (-1.27% of base)
        -119 : 659158.dasm (-0.88% of base)
        -112 : 458859.dasm (-1.00% of base)
        -109 : 66365.dasm (-0.84% of base)
        -108 : 659986.dasm (-0.61% of base)
        -101 : 659164.dasm (-0.89% of base)
        -101 : 659921.dasm (-1.23% of base)
         -98 : 94668.dasm (-0.92% of base)
         -97 : 635318.dasm (-0.62% of base)
         -96 : 193242.dasm (-0.89% of base)
         -96 : 94013.dasm (-0.90% of base)
         -95 : 95319.dasm (-1.04% of base)
         -95 : 192290.dasm (-2.18% of base)
         -92 : 654996.dasm (-1.19% of base)

89 total files with Code Size differences (60 improved, 29 regressed), 20 unchanged.

Top method regressions (bytes):
         212 ( 2.64% of base) : 660340.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInlineArrayElementRefMethod:GenerateMethodBody(Microsoft.CodeAnalysis.CSharp.TypeCompilationState,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
         105 ( 3.75% of base) : 619441.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:WriteStringInvalidCharacter(ushort,System.Text.Encodings.Web.JavaScriptEncoder):this (Tier1-OSR)
          99 ( 0.66% of base) : 319698.dasm - System.IO.Tests.StreamConformanceTests+<ValidateMisuseExceptionsAsync>d__50:MoveNext():this (Tier1)
          97 ( 0.65% of base) : 334450.dasm - System.IO.Tests.StreamConformanceTests+<ValidateMisuseExceptionsAsync>d__50:MoveNext():this (Tier1)
          87 ( 0.58% of base) : 330683.dasm - System.IO.Tests.StreamConformanceTests+<ValidateMisuseExceptionsAsync>d__50:MoveNext():this (Tier1)
          79 ( 3.07% of base) : 59012.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol:CheckEffectiveAccessibility(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
          58 ( 3.88% of base) : 691943.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
          38 ( 0.42% of base) : 644854.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:<CheckOverrideMember>g__checkValidMethodOverride|232_1(Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,ubyte) (Tier1)
          35 ( 8.56% of base) : 129169.dasm - System.Threading.CancellationTokenSource+Registrations:Unregister(long,System.Threading.CancellationTokenSource+CallbackNode):ubyte:this (Tier1)
          35 ( 8.56% of base) : 340011.dasm - System.Threading.CancellationTokenSource+Registrations:Unregister(long,System.Threading.CancellationTokenSource+CallbackNode):ubyte:this (Tier1)
          34 ( 2.21% of base) : 52931.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol:CreateMethods(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol]):Microsoft.CodeAnalysis.PooledObjects.PooledDictionary`2[System.Reflection.Metadata.MethodDefinitionHandle,Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol]:this (Tier1)
          29 ( 0.52% of base) : 91750.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindAttributeArguments(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.Binder+AnalyzedAttributeArguments:this (Tier1)
          27 ( 1.79% of base) : 305313.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateInterfaces(System.RuntimeType+RuntimeTypeCache+Filter):System.RuntimeType[]:this (Tier1)
          27 ( 1.81% of base) : 343754.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateInterfaces(System.RuntimeType+RuntimeTypeCache+Filter):System.RuntimeType[]:this (Tier1)
          26 ( 7.98% of base) : 386392.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[double](double):this (Instrumented Tier1)
          25 (13.02% of base) : 622297.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (Tier1)
          20 ( 0.20% of base) : 190895.dasm - Microsoft.CodeAnalysis.CSharp.MethodCompiler:CompileMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,int,byref,Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields,Microsoft.CodeAnalysis.CSharp.TypeCompilationState):this (Tier1)
          15 ( 2.68% of base) : 448510.dasm - System.Xml.Xsl.IlGen.XmlILOptimizerVisitor:VisitRtfCtor(System.Xml.Xsl.Qil.QilBinary):System.Xml.Xsl.Qil.QilNode:this (Tier1)
          14 ( 4.19% of base) : 252635.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[float](float):this (Instrumented Tier1)
          14 ( 2.39% of base) : 445833.dasm - System.Xml.Xsl.IlGen.XmlILOptimizerVisitor:VisitLet(System.Xml.Xsl.Qil.QilIterator):System.Xml.Xsl.Qil.QilNode:this (Tier1)

Top method improvements (bytes):
        -240 (-3.85% of base) : 619433.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:EscapingTestWhileWritingSurrogate(System.Text.Encodings.Web.JavaScriptEncoder):this (Tier1-OSR)
        -203 (-3.49% of base) : 660638.dasm - Microsoft.Cci.MemberRefComparer:Equals(Microsoft.Cci.ITypeMemberReference,Microsoft.Cci.ITypeMemberReference):ubyte:this (Tier1)
        -174 (-3.46% of base) : 192287.dasm - Microsoft.Cci.ReferenceIndexerBase:Visit(Microsoft.Cci.IMethodReference):this (Tier1)
        -168 (-1.23% of base) : 111410.dasm - Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder:VisitTypeDeclaration(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax,ubyte):Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration:this (Tier1)
        -160 (-0.81% of base) : 92579.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol:MakeTypeParameters(Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol]:this (Tier1)
        -158 (-0.88% of base) : 659992.dasm - Microsoft.Cci.MetadataWriter:PopulateTypeRefTableRows():this (Tier1)
        -139 (-1.27% of base) : 89402.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseMemberDeclarationCore(ushort):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax:this (Tier1)
        -119 (-0.88% of base) : 659158.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindArrayCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
        -112 (-1.00% of base) : 458859.dasm - System.Xml.RwFactoryWriterTests.CWriterFactory:SetupSettings():this (Tier1)
        -109 (-0.84% of base) : 66365.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindArrayCreationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
        -108 (-0.61% of base) : 659986.dasm - Microsoft.Cci.MetadataWriter:PopulateTypeDefTableRows():this (Tier1)
        -101 (-1.23% of base) : 659921.dasm - Microsoft.Cci.MetadataWriter:PopulateMemberRefTableRows():this (Tier1)
        -101 (-0.89% of base) : 659164.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindArrayType(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations:this (Tier1)
         -98 (-0.92% of base) : 94668.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindInvocationExpression(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundExpression:this (Tier1)
         -97 (-0.62% of base) : 635318.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol:AddNonTypeMembers(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol+DeclaredMembersAndInitializersBuilder,Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
         -96 (-0.89% of base) : 193242.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindArrayType(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations:this (Tier1)
         -96 (-0.90% of base) : 94013.dasm - Microsoft.CodeAnalysis.CSharp.Binder:BindArrayType(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,Roslyn.Utilities.ConsList`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol],ubyte):Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations:this (Tier1)
         -95 (-2.18% of base) : 192290.dasm - Microsoft.Cci.MemberRefComparer:GetHashCode(Microsoft.Cci.ITypeMemberReference):int:this (Tier1)
         -95 (-1.04% of base) : 95319.dasm - Microsoft.CodeAnalysis.CSharp.Symbol:BindAttributes(Roslyn.Utilities.OneOrMany`1[Microsoft.CodeAnalysis.SyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax]],Microsoft.CodeAnalysis.CSharp.Binder):System.Collections.Immutable.ImmutableArray`1[System.ValueTuple`2[Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData,Microsoft.CodeAnalysis.CSharp.BoundAttribute]]:this (Tier1)
         -92 (-1.19% of base) : 654996.dasm - Microsoft.CodeAnalysis.CSharp.LocalBinderFactory:VisitForStatement(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax):this (Tier1)

Top method regressions (percentages):
          25 (13.02% of base) : 622297.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.Guid](System.Guid):this (Tier1)
          35 ( 8.56% of base) : 129169.dasm - System.Threading.CancellationTokenSource+Registrations:Unregister(long,System.Threading.CancellationTokenSource+CallbackNode):ubyte:this (Tier1)
          35 ( 8.56% of base) : 340011.dasm - System.Threading.CancellationTokenSource+Registrations:Unregister(long,System.Threading.CancellationTokenSource+CallbackNode):ubyte:this (Tier1)
          26 ( 7.98% of base) : 386392.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[double](double):this (Instrumented Tier1)
          14 ( 4.19% of base) : 252635.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[float](float):this (Instrumented Tier1)
           5 ( 4.07% of base) : 524033.dasm - System.__DTString:SkipWhiteSpaces():this (Tier1)
           5 ( 4.00% of base) : 456496.dasm - System.__DTString:SkipWhiteSpaces():this (Tier1)
          58 ( 3.88% of base) : 691943.dasm - System.Threading.PortableThreadPool:AdjustMaxWorkersActive():this (Tier1)
         105 ( 3.75% of base) : 619441.dasm - System.Text.Json.Tests.Utf8JsonWriterTests:WriteStringInvalidCharacter(ushort,System.Text.Encodings.Web.JavaScriptEncoder):this (Tier1-OSR)
           6 ( 3.24% of base) : 107871.dasm - System.__DTString:SkipWhiteSpaces():this (Instrumented Tier1)
          79 ( 3.07% of base) : 59012.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol:CheckEffectiveAccessibility(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol],Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
           9 ( 2.84% of base) : 685591.dasm - System.Threading.Tasks.Task:System.IAsyncResult.get_AsyncWaitHandle():System.Threading.WaitHandle:this (Tier1)
          15 ( 2.68% of base) : 448510.dasm - System.Xml.Xsl.IlGen.XmlILOptimizerVisitor:VisitRtfCtor(System.Xml.Xsl.Qil.QilBinary):System.Xml.Xsl.Qil.QilNode:this (Tier1)
         212 ( 2.64% of base) : 660340.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInlineArrayElementRefMethod:GenerateMethodBody(Microsoft.CodeAnalysis.CSharp.TypeCompilationState,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (Tier1)
          14 ( 2.39% of base) : 445833.dasm - System.Xml.Xsl.IlGen.XmlILOptimizerVisitor:VisitLet(System.Xml.Xsl.Qil.QilIterator):System.Xml.Xsl.Qil.QilNode:this (Tier1)
           9 ( 2.31% of base) : 126265.dasm - Xunit.Sdk.MessageBus:QueueMessage(Xunit.Abstractions.IMessageSinkMessage):ubyte:this (Tier1)
           9 ( 2.31% of base) : 535504.dasm - Xunit.Sdk.MessageBus:QueueMessage(Xunit.Abstractions.IMessageSinkMessage):ubyte:this (Tier1)
           9 ( 2.31% of base) : 407824.dasm - Xunit.Sdk.MessageBus:QueueMessage(Xunit.Abstractions.IMessageSinkMessage):ubyte:this (Tier1)
           9 ( 2.31% of base) : 560916.dasm - Xunit.Sdk.MessageBus:QueueMessage(Xunit.Abstractions.IMessageSinkMessage):ubyte:this (Tier1)
           9 ( 2.31% of base) : 271530.dasm - Xunit.Sdk.MessageBus:QueueMessage(Xunit.Abstractions.IMessageSinkMessage):ubyte:this (Tier1)

Top method improvements (percentages):
          -2 (-28.57% of base) : 62791.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (Tier1)
          -2 (-28.57% of base) : 122726.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (Tier1)
          -2 (-28.57% of base) : 65199.dasm - Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (Tier1)
          -2 (-20.00% of base) : 64544.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive:get_Kind():ushort:this (Tier1)
          -2 (-20.00% of base) : 191799.dasm - System.Collections.Generic.SortedDictionary`2[int,Microsoft.CodeAnalysis.CSharp.NullableWalker+Snapshot]:get_Count():int:this (Tier1)
          -2 (-20.00% of base) : 48930.dasm - System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:get_Count():int:this (Tier1)
          -2 (-20.00% of base) : 385506.dasm - System.Net.Security.SslStream+SslBuffer:Commit(int):this (Tier1)
          -2 (-20.00% of base) : 258847.dasm - System.Xml.XmlTextReaderImpl:get_LineNumber():int:this (Tier1)
          -2 (-20.00% of base) : 258900.dasm - System.Xml.XmlTextReaderImpl:get_LinePosition():int:this (Tier1)
          -4 (-19.05% of base) : 61108.dasm - Microsoft.CodeAnalysis.Project:get_Id():Microsoft.CodeAnalysis.ProjectId:this (Tier1)
          -4 (-19.05% of base) : 64568.dasm - Microsoft.CodeAnalysis.Project:get_Name():System.String:this (Tier1)
          -2 (-18.18% of base) : 62802.dasm - Microsoft.CodeAnalysis.CSharp.BoundNodeExtensions:MakeCompilerGenerated[System.__Canon](System.__Canon):System.__Canon (Tier1)
          -2 (-18.18% of base) : 50344.dasm - Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder`1[System.__Canon]:Clear():this (Tier1)
          -2 (-18.18% of base) : 187109.dasm - Microsoft.CodeAnalysis.TextDocumentStates`1+<>c[System.__Canon]:<.ctor>b__5_0(Microsoft.CodeAnalysis.DocumentInfo):Microsoft.CodeAnalysis.DocumentId:this (Tier1)
          -2 (-18.18% of base) : 60845.dasm - Microsoft.CodeAnalysis.TextDocumentStates`1+<>c[System.__Canon]:<AddRange>b__23_0(System.__Canon):Microsoft.CodeAnalysis.DocumentId:this (Tier1)
         -63 (-17.21% of base) : 634344.dasm - Microsoft.CodeAnalysis.SolutionCompilationState+CompilationTracker:CreateEmptyCompilation():Microsoft.CodeAnalysis.Compilation:this (Tier1)
         -63 (-17.21% of base) : 187165.dasm - Microsoft.CodeAnalysis.SolutionCompilationState+CompilationTracker:CreateEmptyCompilation():Microsoft.CodeAnalysis.Compilation:this (Tier1)
          -2 (-16.67% of base) : 327629.dasm - System.IO.Tests.BaseGetSetTimes`1+<>c[System.__Canon]:<SettingUpdatesPropertiesAfterAnother>b__25_0(System.IO.Tests.BaseGetSetTimes`1+TimeFunction[System.__Canon]):ubyte:this (Tier1)
          -4 (-16.00% of base) : 238754.dasm - System.Collections.Generic.SortedSet`1+Node[int]:Merge2Nodes():this (Tier1)
          -4 (-16.00% of base) : 239526.dasm - System.Collections.Generic.SortedSet`1+Node[System.__Canon]:Merge2Nodes():this (Tier1)

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

Total bytes of base: 136497015 (overridden on cmd)
Total bytes of diff: 136383362 (overridden on cmd)
Total bytes of delta: -113653 (-0.08 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          43 : 200876.dasm (3.48% of base)
          43 : 221922.dasm (3.48% of base)
          27 : 138010.dasm (1.13% of base)
          24 : 100303.dasm (5.53% of base)
          20 : 191498.dasm (0.65% of base)
          18 : 113020.dasm (0.90% of base)
          15 : 14704.dasm (1.46% of base)
          14 : 10430.dasm (0.52% of base)
          14 : 17379.dasm (0.11% of base)
          13 : 242506.dasm (2.00% of base)
          12 : 100299.dasm (4.48% of base)
          11 : 54236.dasm (2.08% of base)
          11 : 22741.dasm (2.08% of base)
          11 : 90108.dasm (6.40% of base)
          11 : 48444.dasm (2.08% of base)
          11 : 8393.dasm (6.29% of base)
          11 : 90102.dasm (6.40% of base)
          10 : 195169.dasm (8.13% of base)
          10 : 77106.dasm (1.37% of base)
           9 : 175675.dasm (6.77% of base)

Top file improvements (bytes):
        -262 : 152904.dasm (-5.97% of base)
        -151 : 191221.dasm (-2.82% of base)
        -147 : 97722.dasm (-1.34% of base)
        -130 : 191124.dasm (-4.04% of base)
        -130 : 191012.dasm (-4.05% of base)
        -109 : 14640.dasm (-3.17% of base)
        -104 : 191394.dasm (-2.40% of base)
        -104 : 249920.dasm (-0.87% of base)
        -104 : 261946.dasm (-0.87% of base)
         -95 : 12270.dasm (-5.64% of base)
         -92 : 174040.dasm (-2.84% of base)
         -91 : 309613.dasm (-5.46% of base)
         -88 : 171857.dasm (-4.65% of base)
         -88 : 243320.dasm (-2.57% of base)
         -85 : 191048.dasm (-1.95% of base)
         -85 : 191118.dasm (-2.19% of base)
         -83 : 243318.dasm (-2.04% of base)
         -77 : 202661.dasm (-2.48% of base)
         -77 : 219349.dasm (-2.48% of base)
         -75 : 49141.dasm (-6.49% of base)

91 total files with Code Size differences (60 improved, 31 regressed), 20 unchanged.

Top method regressions (bytes):
          43 ( 3.48% of base) : 200876.dasm - System.Tests.StringTests:TestMatchLastIndexOf_Char() (FullOpts)
          43 ( 3.48% of base) : 221922.dasm - System.Tests.StringTests:TestMatchLastIndexOf_Char() (FullOpts)
          27 ( 1.13% of base) : 138010.dasm - System.IO.Tests.StreamReaderTests:TestPeekReadOneByteAtATime():this (FullOpts)
          24 ( 5.53% of base) : 100303.dasm - System.Data.ProviderBase.DbBuffer:ReadDateTime(int):System.DateTime:this (FullOpts)
          20 ( 0.65% of base) : 191498.dasm - System.Reflection.Metadata.Tests.AssemblyReferenceTests:ValidateAssemblyNameForMultipleAssemblyReferences():this (FullOpts)
          18 ( 0.90% of base) : 113020.dasm - ManagedTests.DynamicCSharp.Conformance.dynamic.dynamicType.basic.lambda008.lambda008.Test:MainMethod():int (FullOpts)
          15 ( 1.46% of base) : 14704.dasm - Microsoft.CodeAnalysis.Collections.SegmentedList`1[Microsoft.CodeAnalysis.SyntaxToken]:InsertRange(int,System.Collections.Generic.IEnumerable`1[Microsoft.CodeAnalysis.SyntaxToken]):this (FullOpts)
          14 ( 0.52% of base) : 10430.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ConstructBoundMemberGroupAndReportOmittedTypeArguments(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.String,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol],Microsoft.CodeAnalysis.CSharp.LookupResult,int,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundMethodOrPropertyGroup:this (FullOpts)
          14 ( 0.11% of base) : 17379.dasm - System.IO.Tests.StreamConformanceTests+<ValidateMisuseExceptionsAsync>d__50:MoveNext():this (FullOpts)
          13 ( 2.00% of base) : 242506.dasm - System.Speech.Internal.Synthesis.TextWriterEngine:ProcessSpeak(System.String,System.String,System.Globalization.CultureInfo,System.Collections.Generic.List`1[System.Speech.Internal.Synthesis.SsmlXmlAttribute]):System.Object:this (FullOpts)
          12 ( 4.48% of base) : 100299.dasm - System.Data.ProviderBase.DbBuffer:ReadDate(int):System.DateTime:this (FullOpts)
          11 ( 2.08% of base) : 54236.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
          11 ( 2.08% of base) : 22741.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
          11 ( 2.08% of base) : 48444.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
          11 ( 6.29% of base) : 8393.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[int](int):this (FullOpts)
          11 ( 6.40% of base) : 90108.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[long](long):this (FullOpts)
          11 ( 6.40% of base) : 90102.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[ulong](ulong):this (FullOpts)
          10 ( 1.37% of base) : 77106.dasm - System.Collections.Specialized.Tests.NameObjectCollectionBaseGetEnumeratorTests:GetEnumerator(int):this (FullOpts)
          10 ( 8.13% of base) : 195169.dasm - System.Runtime.CompilerServices.UnsafeTests:RefIsAddressGreaterThan() (FullOpts)
           9 ( 7.20% of base) : 195114.dasm - System.Runtime.CompilerServices.UnsafeTests:RefIsAddressLessThan() (FullOpts)

Top method improvements (bytes):
        -262 (-5.97% of base) : 152904.dasm - System.MemoryTests.MemoryTests:SlicingUsingIndexAndRangeTest() (FullOpts)
        -151 (-2.82% of base) : 191221.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:OtherAccessors():this (FullOpts)
        -147 (-1.34% of base) : 97722.dasm - System.Data.Tests.DataTableTest2:GetChanges_ByDataRowState():this (FullOpts)
        -130 (-4.05% of base) : 191012.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:GetString_WinRTPrefixed_NotProjected():this (FullOpts)
        -130 (-4.04% of base) : 191124.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:GetString_WinRTPrefixed_Projected():this (FullOpts)
        -109 (-3.17% of base) : 14640.dasm - Microsoft.CodeAnalysis.CSharp.Formatting.IndentBlockFormattingRule:AddSwitchIndentationOperation(System.Collections.Generic.List`1[Microsoft.CodeAnalysis.Formatting.Rules.IndentBlockOperation],Microsoft.CodeAnalysis.SyntaxNode):this (FullOpts)
        -104 (-2.40% of base) : 191394.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateCustomAttribute():this (FullOpts)
        -104 (-0.87% of base) : 261946.dasm - System.Text.Json.SourceGeneration.Tests.ConstructorTests_Default+ConstructorTestsContext_Default:SimpleTestClassSerializeHandler(System.Text.Json.Utf8JsonWriter,System.Text.Json.Serialization.Tests.SimpleTestClass):this (FullOpts)
        -104 (-0.87% of base) : 249920.dasm - System.Text.Json.SourceGeneration.Tests.PropertyNameTests_Default+PropertyNameTestsContext_Default:SimpleTestClassSerializeHandler(System.Text.Json.Utf8JsonWriter,System.Text.Json.Serialization.Tests.SimpleTestClass):this (FullOpts)
         -95 (-5.64% of base) : 12270.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BinaryOperatorOverloadResolution(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult,byref):this (FullOpts)
         -92 (-2.84% of base) : 174040.dasm - Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationReader1:Read3_wrapper():System.Object[]:this (FullOpts)
         -91 (-5.46% of base) : 309613.dasm - ThreadPoolBoundHandleTests:MultipleOperationsOverSingleHandle():this (FullOpts)
         -88 (-4.65% of base) : 171857.dasm - System.Collections.ObjectModel.Tests.PublicMethodsTest:RemoveAtTest() (FullOpts)
         -88 (-2.57% of base) : 243320.dasm - System.Text.Tests.CaseConversionTests:SingleCharConversion() (FullOpts)
         -85 (-2.19% of base) : 191118.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateTypeDefTable():this (FullOpts)
         -85 (-1.95% of base) : 191048.dasm - System.Reflection.Metadata.Tests.MetadataReaderTests:ValidateTypeDefTableMod():this (FullOpts)
         -83 (-2.04% of base) : 243318.dasm - System.Text.Tests.CaseConversionTests:SingleByteConversion() (FullOpts)
         -77 (-2.48% of base) : 202661.dasm - System.Tests.ArrayTests:Clear_Struct_WithReferenceAndValueTypeFields_Array() (FullOpts)
         -77 (-2.48% of base) : 219349.dasm - System.Tests.ArrayTests:Clear_Struct_WithReferenceAndValueTypeFields_Array() (FullOpts)
         -75 (-6.49% of base) : 49141.dasm - Microsoft.CodeAnalysis.Workspace:CreateProjectInfo(Microsoft.CodeAnalysis.Project):Microsoft.CodeAnalysis.ProjectInfo (FullOpts)

Top method regressions (percentages):
           1 (14.29% of base) : 29750.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationInstance(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Object (FullOpts)
           1 (14.29% of base) : 29752.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceDescriptorExtensions:GetImplementationType(Microsoft.Extensions.DependencyInjection.ServiceDescriptor):System.Type (FullOpts)
           6 ( 9.23% of base) : 203275.dasm - System.Numerics.Tests.BigIntegerConstructorTest+<>c:<RunCtorSingleTests>b__10_3():this (FullOpts)
          10 ( 8.13% of base) : 195169.dasm - System.Runtime.CompilerServices.UnsafeTests:RefIsAddressGreaterThan() (FullOpts)
           9 ( 7.20% of base) : 195114.dasm - System.Runtime.CompilerServices.UnsafeTests:RefIsAddressLessThan() (FullOpts)
           9 ( 6.77% of base) : 175675.dasm - System.Xml.DocumentXPathNavigator:ResetAttributePosition(System.Xml.XmlAttribute,System.Xml.XmlAttributeCollection,byref):ubyte (FullOpts)
          11 ( 6.40% of base) : 90108.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[long](long):this (FullOpts)
          11 ( 6.40% of base) : 90102.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[ulong](ulong):this (FullOpts)
          11 ( 6.29% of base) : 8393.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[int](int):this (FullOpts)
           4 ( 5.56% of base) : 203305.dasm - System.Numerics.Tests.BigIntegerConstructorTest+<>c:<RunCtorDoubleTests>b__12_3():this (FullOpts)
          24 ( 5.53% of base) : 100303.dasm - System.Data.ProviderBase.DbBuffer:ReadDateTime(int):System.DateTime:this (FullOpts)
           1 ( 5.26% of base) : 298863.dasm - System.Text.RegularExpressions.Tests.RegexEnumerateMatchesTests+<>c:<EnumerateMatches_Ctor_Invalid>b__1_0():this (FullOpts)
           4 ( 4.88% of base) : 203613.dasm - System.Numerics.Tests.cast_toTest+<>c:<RunDoubleExplicitCastToBigIntegerTests>b__12_3():this (FullOpts)
          12 ( 4.48% of base) : 100299.dasm - System.Data.ProviderBase.DbBuffer:ReadDate(int):System.DateTime:this (FullOpts)
           1 ( 3.70% of base) : 298866.dasm - System.Text.RegularExpressions.Tests.RegexEnumerateMatchesTests+<>c:<EnumerateMatches_Ctor_Invalid>b__1_2():this (FullOpts)
          43 ( 3.48% of base) : 200876.dasm - System.Tests.StringTests:TestMatchLastIndexOf_Char() (FullOpts)
          43 ( 3.48% of base) : 221922.dasm - System.Tests.StringTests:TestMatchLastIndexOf_Char() (FullOpts)
           5 ( 3.12% of base) : 16696.dasm - System.IO.RowConfigReaderTests:Newlines(int):System.String (FullOpts)
           1 ( 3.12% of base) : 298871.dasm - System.Text.RegularExpressions.Tests.RegexEnumerateMatchesTests+<>c:<EnumerateMatches_Ctor_Invalid>b__1_7():this (FullOpts)
           1 ( 2.94% of base) : 298913.dasm - System.Text.RegularExpressions.Tests.RegexReplaceTests+<>c:<Replace_Invalid>b__9_18():System.Object:this (FullOpts)

Top method improvements (percentages):
         -50 (-28.74% of base) : 49239.dasm - Microsoft.CodeAnalysis.SolutionState+CompilationTracker:CreateEmptyCompilation():Microsoft.CodeAnalysis.Compilation:this (FullOpts)
         -50 (-28.74% of base) : 43472.dasm - Microsoft.CodeAnalysis.SolutionState+CompilationTracker:CreateEmptyCompilation():Microsoft.CodeAnalysis.Compilation:this (FullOpts)
          -2 (-28.57% of base) : 10539.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__274_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
          -2 (-28.57% of base) : 35706.dasm - Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver:VisitConstant(Microsoft.Extensions.DependencyInjection.ServiceLookup.ConstantCallSite,Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext):System.Object:this (FullOpts)
          -2 (-28.57% of base) : 11669.dasm - Microsoft.Interop.ComInterfaceGenerator+<>c:<GenerateImplementationVTable>b__13_1(Microsoft.Interop.ComMethodContext):Microsoft.Interop.IncrementalMethodStubGenerationContext:this (FullOpts)
         -50 (-28.09% of base) : 5132.dasm - Microsoft.CodeAnalysis.SolutionCompilationState+CompilationTracker:CreateEmptyCompilation():Microsoft.CodeAnalysis.Compilation:this (FullOpts)
          -4 (-23.53% of base) : 307955.dasm - Microsoft.CodeAnalysis.CodeFixes.BatchFixAllProvider+<>c:<MergeTextChangesAsync>b__9_0(Microsoft.CodeAnalysis.Document):Microsoft.CodeAnalysis.DocumentId:this (FullOpts)
         -13 (-22.81% of base) : 306158.dasm - Microsoft.CodeAnalysis.CodeFixes.BatchFixAllProvider+<>c__DisplayClass6_0:<DetermineDiagnosticsAsync>b__0(System.Collections.Generic.KeyValuePair`2[Microsoft.CodeAnalysis.Document,System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.Diagnostic]]):ubyte:this (FullOpts)
          -2 (-22.22% of base) : 90886.dasm - System.Composition.Convention.Tests.ImportBuilderTests+<>c:<AsMany_ChangesGeneratedAttributeToImportMany>b__6_1(System.Composition.Convention.ImportConventionBuilder):this (FullOpts)
          -2 (-22.22% of base) : 281501.dasm - System.Text.RegularExpressions.Tests.RegexCompileToAssemblyTests+<>c:<get_IsDebug>b__1_0(System.Diagnostics.DebuggableAttribute):ubyte:this (FullOpts)
          -5 (-21.74% of base) : 80391.dasm - System.Collections.Tests.BitArray_GetSetTests+<>c__DisplayClass5_0:<Set_InvalidIndex_ThrowsArgumentOutOfRangeException>b__3():System.Object:this (FullOpts)
          -2 (-20.00% of base) : 55650.dasm - System.Collections.Generic.SortedDictionary`2[int,Microsoft.CodeAnalysis.CSharp.NullableWalker+Snapshot]:get_Count():int:this (FullOpts)
          -2 (-20.00% of base) : 4494.dasm - System.Collections.Generic.SortedDictionary`2[System.__Canon,System.__Canon]:get_Count():int:this (FullOpts)
          -2 (-20.00% of base) : 33870.dasm - System.Xml.XmlTextReaderImpl:get_LineNumber():int:this (FullOpts)
          -2 (-20.00% of base) : 33871.dasm - System.Xml.XmlTextReaderImpl:get_LinePosition():int:this (FullOpts)
         -28 (-19.72% of base) : 25532.dasm - Microsoft.CSharp.RuntimeBinder.Semantics.MethodTypeInferrer:SetUnknownsToNotDependent():this (FullOpts)
          -4 (-19.05% of base) : 23335.dasm - Microsoft.CodeAnalysis.FindSymbols.DependentTypeFinder+<>c:<GetProjectsToExamineWorker>b__14_1(Microsoft.CodeAnalysis.Project):Microsoft.CodeAnalysis.ProjectId:this (FullOpts)
          -4 (-19.05% of base) : 5060.dasm - Microsoft.CodeAnalysis.Project:get_Id():Microsoft.CodeAnalysis.ProjectId:this (FullOpts)
          -4 (-19.05% of base) : 5081.dasm - Microsoft.CodeAnalysis.Project:get_Name():System.String:this (FullOpts)
          -2 (-18.18% of base) : 30693.dasm - Microsoft.CodeAnalysis.TextDocumentStates`1+<>c[System.__Canon]:<.ctor>b__5_0(Microsoft.CodeAnalysis.DocumentInfo):Microsoft.CodeAnalysis.DocumentId:this (FullOpts)

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

Total bytes of base: 13996974 (overridden on cmd)
Total bytes of diff: 13979348 (overridden on cmd)
Total bytes of delta: -17626 (-0.13 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
          23 : 1176.dasm (0.57% of base)
          14 : 24854.dasm (0.52% of base)
          13 : 1175.dasm (0.71% of base)
          11 : 19629.dasm (1.74% of base)
           9 : 21522.dasm (1.85% of base)
           5 : 23893.dasm (1.09% of base)
           5 : 411.dasm (0.85% of base)
           4 : 1047.dasm (0.09% of base)
           4 : 21098.dasm (0.46% of base)
           3 : 31603.dasm (0.54% of base)
           3 : 27793.dasm (1.18% of base)
           3 : 29141.dasm (0.77% of base)
           3 : 29318.dasm (0.24% of base)
           2 : 12684.dasm (2.47% of base)
           2 : 29264.dasm (0.27% of base)
           1 : 2167.dasm (0.09% of base)
           1 : 33580.dasm (0.09% of base)
           1 : 2753.dasm (0.09% of base)
           1 : 16254.dasm (0.26% of base)
           1 : 35271.dasm (0.48% of base)

Top file improvements (bytes):
         -95 : 24418.dasm (-5.64% of base)
         -95 : 15810.dasm (-2.51% of base)
         -83 : 31233.dasm (-1.75% of base)
         -79 : 15138.dasm (-1.02% of base)
         -77 : 1337.dasm (-1.32% of base)
         -67 : 19551.dasm (-1.28% of base)
         -67 : 1694.dasm (-6.50% of base)
         -64 : 5353.dasm (-1.65% of base)
         -53 : 21743.dasm (-0.73% of base)
         -51 : 1406.dasm (-1.18% of base)
         -48 : 23673.dasm (-0.73% of base)
         -46 : 32717.dasm (-0.76% of base)
         -44 : 24420.dasm (-5.75% of base)
         -42 : 28914.dasm (-3.07% of base)
         -41 : 15188.dasm (-0.54% of base)
         -41 : 23519.dasm (-1.22% of base)
         -40 : 31033.dasm (-5.14% of base)
         -40 : 19793.dasm (-2.29% of base)
         -37 : 19698.dasm (-3.34% of base)
         -37 : 20550.dasm (-0.94% of base)

78 total files with Code Size differences (56 improved, 22 regressed), 20 unchanged.

Top method regressions (bytes):
          23 ( 0.57% of base) : 1176.dasm - BepuPhysics.Constraints.Contact.ContactNonconvexTwoBodyFunctions`2[BepuPhysics.Constraints.Contact.Contact4NonconvexPrestepData,BepuPhysics.Constraints.Contact.Contact4NonconvexAccumulatedImpulses]:Solve(byref,byref,byref,byref,byref,byref,float,float,byref,byref,byref,byref):this (FullOpts)
          14 ( 0.52% of base) : 24854.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ConstructBoundMemberGroupAndReportOmittedTypeArguments(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.String,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol],Microsoft.CodeAnalysis.CSharp.LookupResult,int,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundMethodOrPropertyGroup:this (FullOpts)
          13 ( 0.71% of base) : 1175.dasm - BepuPhysics.Constraints.Contact.ContactNonconvexTwoBodyFunctions`2[BepuPhysics.Constraints.Contact.Contact4NonconvexPrestepData,BepuPhysics.Constraints.Contact.Contact4NonconvexAccumulatedImpulses]:WarmStart(byref,byref,byref,byref,byref,byref,byref,byref,byref,byref):this (FullOpts)
          11 ( 1.74% of base) : 19629.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
           9 ( 1.85% of base) : 21522.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
           5 ( 1.09% of base) : 23893.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations+LazyNullableTypeParameter:ReportDiagnosticsIfObsolete(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Binder,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (FullOpts)
           5 ( 0.85% of base) : 411.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           4 ( 0.09% of base) : 1047.dasm - BepuPhysics.CollisionDetection.DepthRefiner`6[BepuPhysics.Collidables.Cylinder,BepuPhysics.Collidables.CylinderWide,BepuPhysics.Collidables.CylinderSupportFinder,BepuPhysics.Collidables.Triangle,BepuPhysics.Collidables.TriangleWide,BepuPhysics.CollisionDetection.CollisionTasks.PretransformedTriangleSupportFinder]:GetNextNormal[BepuPhysics.CollisionDetection.DepthRefiner`6+HasNoNewSupport[BepuPhysics.Collidables.Cylinder,BepuPhysics.Collidables.CylinderWide,BepuPhysics.Collidables.CylinderSupportFinder,BepuPhysics.Collidables.Triangle,BepuPhysics.Collidables.TriangleWide,BepuPhysics.CollisionDetection.CollisionTasks.PretransformedTriangleSupportFinder]](byref,byref,byref,byref,byref,byref,byref,byref) (FullOpts)
           4 ( 0.46% of base) : 21098.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:GetMetadata(Microsoft.CodeAnalysis.PortableExecutableReference,Microsoft.CodeAnalysis.CommonMessageProvider,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.DiagnosticBag):Microsoft.CodeAnalysis.Metadata:this (FullOpts)
           3 ( 0.54% of base) : 31603.dasm - Microsoft.Cci.FullMetadataWriter:CreateIndicesFor(Microsoft.Cci.IMethodDefinition):this (FullOpts)
           3 ( 1.18% of base) : 27793.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetCapturedBitmask():Microsoft.CodeAnalysis.BitVector:this (FullOpts)
           3 ( 0.77% of base) : 29141.dasm - Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor+PartVisitor:VisitArrayType(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol,System.Text.StringBuilder):System.Object:this (FullOpts)
           3 ( 0.24% of base) : 29318.dasm - System.Text.RegularExpressions.RegexNode:<ReduceAlternation>g__ExtractCommonPrefixOneNotoneSet|41_1(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.RegexNode (FullOpts)
           2 ( 2.47% of base) : 12684.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader:sigptrGetSingle(ubyte[],int):System.Tuple`2[float,int] (FullOpts)
           2 ( 0.27% of base) : 29264.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap:GetAllPragmaWarningDirectives(Microsoft.CodeAnalysis.SyntaxTree,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax]) (FullOpts)
           1 ( 0.09% of base) : 2753.dasm - FSharp.Compiler.CompilerOptions:processArg@245(Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CompilerOptions+CompilerOptionBlock],Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CompilerOptions+CompilerOption],Microsoft.FSharp.Collections.FSharpList`1[System.String]) (FullOpts)
           1 ( 0.17% of base) : 28570.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<Scan>g__makeMemberMaybeNull|61_10(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,System.String):this (FullOpts)
           1 ( 0.26% of base) : 16254.dasm - Microsoft.ML.Data.DataViewUtils+Splitter+OutPipe:Create(Microsoft.ML.Data.DataViewType,System.Object):Microsoft.ML.Data.DataViewUtils+Splitter+OutPipe (FullOpts)
           1 ( 0.48% of base) : 35271.dasm - System.Linq.Expressions.CachedReflectionInfo:get_MethodBase_GetMethodFromHandle_RuntimeMethodHandle():System.Reflection.MethodInfo (FullOpts)
           1 ( 0.09% of base) : 33580.dasm - System.Management.Automation.LanguagePrimitives:FigureParseConversion(System.Type,System.Type):System.Management.Automation.LanguagePrimitives+PSConverter`1[System.Object] (FullOpts)

Top method improvements (bytes):
         -95 (-5.64% of base) : 24418.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:BinaryOperatorOverloadResolution(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult,byref):this (FullOpts)
         -95 (-2.51% of base) : 15810.dasm - SixLabors.ImageSharp.Formats.Gif.GifDecoderCore:ReadFrameColors[SixLabors.ImageSharp.PixelFormats.Rgba32](byref,byref,SixLabors.ImageSharp.Memory.Buffer2D`1[ubyte],System.ReadOnlySpan`1[SixLabors.ImageSharp.PixelFormats.Rgb24],byref):this (FullOpts)
         -83 (-1.75% of base) : 31233.dasm - Microsoft.CodeAnalysis.CSharp.MethodBodySynthesizer:ConstructFieldLikeEventAccessorBody_Regular(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol,ubyte,Microsoft.CodeAnalysis.CSharp.CSharpCompilation,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundBlock (FullOpts)
         -79 (-1.02% of base) : 15138.dasm - SixLabors.ImageSharp.Compression.Zlib.DeflaterHuffman:FlushBlock(System.ReadOnlySpan`1[ubyte],int,int,ubyte):this (FullOpts)
         -77 (-1.32% of base) : 1337.dasm - BepuPhysics.IslandAwakener:PrepareJobs(byref,ubyte,int):System.ValueTuple`2[int,int]:this (FullOpts)
         -67 (-1.28% of base) : 19551.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseExpressionContinued(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax,uint):Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax:this (FullOpts)
         -67 (-6.50% of base) : 1694.dasm - System.Uri:PrivateParseMinimal():int:this (FullOpts)
         -64 (-1.65% of base) : 5353.dasm - FSharp.Compiler.AbstractIL.IL+ILInstr:GetHashCode(System.Collections.IEqualityComparer):int:this (FullOpts)
         -53 (-0.73% of base) : 21743.dasm - Microsoft.CodeAnalysis.CSharp.Binder:<ResultSymbol>g__resultSymbol|1055_0(Microsoft.CodeAnalysis.CSharp.LookupResult,System.String,int,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag,ubyte,byref,Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol,int):Microsoft.CodeAnalysis.CSharp.Symbol:this (FullOpts)
         -51 (-1.18% of base) : 1406.dasm - BepuPhysics.Trees.Tree:GetOverlaps[BepuPhysics.CollisionDetection.CollidableOverlapFinder`1+IntertreeOverlapHandler[DemoBenchmarks.RagdollTubeBenchmark+SubgroupFilteredCallbacks]](byref,byref):this (FullOpts)
         -48 (-0.73% of base) : 23673.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers:OrderGraph(System.Collections.Generic.Dictionary`2[Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference,Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers+Node`1[Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference]],Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers+FieldInfo]) (FullOpts)
         -46 (-0.76% of base) : 32717.dasm - System.Text.RegularExpressions.RegexWriter:EmitFragment(ubyte,System.Text.RegularExpressions.RegexNode,int):this (FullOpts)
         -44 (-5.75% of base) : 24420.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:GetTheBestCandidateIndex(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult],byref):int:this (FullOpts)
         -42 (-3.07% of base) : 28914.dasm - Microsoft.CodeAnalysis.CSharp.OverloadResolution:UnaryOperatorOverloadResolution(Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult,byref):this (FullOpts)
         -41 (-1.22% of base) : 23519.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:ComputeAbstractMembers():System.Collections.Immutable.ImmutableHashSet`1[Microsoft.CodeAnalysis.CSharp.Symbol]:this (FullOpts)
         -41 (-0.54% of base) : 15188.dasm - SixLabors.ImageSharp.Advanced.ParallelRowIterator:IterateRows[SixLabors.ImageSharp.Processing.Processors.Convolution.Convolution2PassProcessor`1+HorizontalConvolutionRowOperation[SixLabors.ImageSharp.PixelFormats.Rgba32],System.Numerics.Vector4](SixLabors.ImageSharp.Rectangle,byref,byref) (FullOpts)
         -40 (-5.14% of base) : 31033.dasm - Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator:Generate(byref,byref,byref,byref):this (FullOpts)
         -40 (-2.29% of base) : 19793.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:IsPossibleLambdaExpression(uint):ubyte:this (FullOpts)
         -37 (-0.94% of base) : 20550.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseSwitchExpressionArms():Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax]:this (FullOpts)
         -37 (-3.34% of base) : 19698.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser:ParseTypeArgumentList(byref,Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder`1[Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax],byref):this (FullOpts)

Top method regressions (percentages):
           2 ( 2.47% of base) : 12684.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader:sigptrGetSingle(ubyte[],int):System.Tuple`2[float,int] (FullOpts)
           9 ( 1.85% of base) : 21522.dasm - System.Text.RegularExpressions.RegexParser:AddToConcatenate(int,int,ubyte):this (FullOpts)
          11 ( 1.74% of base) : 19629.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack:IsDefined(System.String):int:this (FullOpts)
           3 ( 1.18% of base) : 27793.dasm - Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass:GetCapturedBitmask():Microsoft.CodeAnalysis.BitVector:this (FullOpts)
           5 ( 1.09% of base) : 23893.dasm - Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations+LazyNullableTypeParameter:ReportDiagnosticsIfObsolete(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations,Microsoft.CodeAnalysis.CSharp.Binder,Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):this (FullOpts)
           5 ( 0.85% of base) : 411.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           3 ( 0.77% of base) : 29141.dasm - Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor+PartVisitor:VisitArrayType(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol,System.Text.StringBuilder):System.Object:this (FullOpts)
          13 ( 0.71% of base) : 1175.dasm - BepuPhysics.Constraints.Contact.ContactNonconvexTwoBodyFunctions`2[BepuPhysics.Constraints.Contact.Contact4NonconvexPrestepData,BepuPhysics.Constraints.Contact.Contact4NonconvexAccumulatedImpulses]:WarmStart(byref,byref,byref,byref,byref,byref,byref,byref,byref,byref):this (FullOpts)
          23 ( 0.57% of base) : 1176.dasm - BepuPhysics.Constraints.Contact.ContactNonconvexTwoBodyFunctions`2[BepuPhysics.Constraints.Contact.Contact4NonconvexPrestepData,BepuPhysics.Constraints.Contact.Contact4NonconvexAccumulatedImpulses]:Solve(byref,byref,byref,byref,byref,byref,float,float,byref,byref,byref,byref):this (FullOpts)
           3 ( 0.54% of base) : 31603.dasm - Microsoft.Cci.FullMetadataWriter:CreateIndicesFor(Microsoft.Cci.IMethodDefinition):this (FullOpts)
          14 ( 0.52% of base) : 24854.dasm - Microsoft.CodeAnalysis.CSharp.Binder:ConstructBoundMemberGroupAndReportOmittedTypeArguments(Microsoft.CodeAnalysis.SyntaxNode,Microsoft.CodeAnalysis.SeparatedSyntaxList`1[Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax],System.Collections.Immutable.ImmutableArray`1[Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations],Microsoft.CodeAnalysis.CSharp.BoundExpression,System.String,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Symbol],Microsoft.CodeAnalysis.CSharp.LookupResult,int,ubyte,Microsoft.CodeAnalysis.CSharp.BindingDiagnosticBag):Microsoft.CodeAnalysis.CSharp.BoundMethodOrPropertyGroup:this (FullOpts)
           1 ( 0.48% of base) : 35271.dasm - System.Linq.Expressions.CachedReflectionInfo:get_MethodBase_GetMethodFromHandle_RuntimeMethodHandle():System.Reflection.MethodInfo (FullOpts)
           4 ( 0.46% of base) : 21098.dasm - Microsoft.CodeAnalysis.CommonReferenceManager`2[System.__Canon,System.__Canon]:GetMetadata(Microsoft.CodeAnalysis.PortableExecutableReference,Microsoft.CodeAnalysis.CommonMessageProvider,Microsoft.CodeAnalysis.Location,Microsoft.CodeAnalysis.DiagnosticBag):Microsoft.CodeAnalysis.Metadata:this (FullOpts)
           2 ( 0.27% of base) : 29264.dasm - Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap:GetAllPragmaWarningDirectives(Microsoft.CodeAnalysis.SyntaxTree,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1[Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax]) (FullOpts)
           1 ( 0.26% of base) : 16254.dasm - Microsoft.ML.Data.DataViewUtils+Splitter+OutPipe:Create(Microsoft.ML.Data.DataViewType,System.Object):Microsoft.ML.Data.DataViewUtils+Splitter+OutPipe (FullOpts)
           3 ( 0.24% of base) : 29318.dasm - System.Text.RegularExpressions.RegexNode:<ReduceAlternation>g__ExtractCommonPrefixOneNotoneSet|41_1(System.Text.RegularExpressions.RegexNode):System.Text.RegularExpressions.RegexNode (FullOpts)
           1 ( 0.17% of base) : 28570.dasm - Microsoft.CodeAnalysis.CSharp.NullableWalker:<Scan>g__makeMemberMaybeNull|61_10(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol,System.String):this (FullOpts)
           1 ( 0.09% of base) : 33580.dasm - System.Management.Automation.LanguagePrimitives:FigureParseConversion(System.Type,System.Type):System.Management.Automation.LanguagePrimitives+PSConverter`1[System.Object] (FullOpts)
           1 ( 0.09% of base) : 2753.dasm - FSharp.Compiler.CompilerOptions:processArg@245(Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CompilerOptions+CompilerOptionBlock],Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.CompilerOptions+CompilerOption],Microsoft.FSharp.Collections.FSharpList`1[System.String]) (FullOpts)
           1 ( 0.09% of base) : 2167.dasm - System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[System.__Canon]:PopulateEvents(System.RuntimeType+RuntimeTypeCache+Filter,System.RuntimeType,System.Collections.Generic.Dictionary`2[System.String,System.Reflection.RuntimeEventInfo],byref):this (FullOpts)

Top method improvements (percentages):
          -2 (-33.33% of base) : 5852.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+res@1620-2:Invoke(System.Tuple`3[ushort,int,int]):int:this (FullOpts)
          -2 (-33.33% of base) : 9734.dasm - FSharp.Compiler.InfoReader+-ctor@681-50:System.Collections.Generic.IEqualityComparer<FSharp.Compiler.Infos.AllowMultiIntfInstantiations>.GetHashCode(FSharp.Compiler.Infos+AllowMultiIntfInstantiations):int:this (FullOpts)
          -2 (-28.57% of base) : 9711.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadMultipleMethodSemantics@2366-3:Invoke(System.Tuple`3[int,int,FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]]):FSharp.Compiler.AbstractIL.ILBinaryReader+TaggedIndex`1[FSharp.Compiler.AbstractIL.BinaryConstants+HasSemanticsTag]:this (FullOpts)
          -2 (-28.57% of base) : 9640.dasm - FSharp.Compiler.CheckDeclarations+modrefs@648-3:Invoke(System.Tuple`3[int,FSharp.Compiler.TypedTree+EntityRef,FSharp.Compiler.TypedTree+ModuleOrNamespaceType]):FSharp.Compiler.TypedTree+EntityRef:this (FullOpts)
          -2 (-28.57% of base) : 5751.dasm - FSharp.Compiler.CompilerImports+PrepareToImportReferencedFSharpAssembly@1625-2:Invoke(System.Tuple`3[FSharp.Compiler.TypedTreePickle+PickledDataWithReferences`1[FSharp.Compiler.TypedTree+PickledCcuInfo],FSharp.Compiler.CompilerImports+ImportedAssembly,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit]]):FSharp.Compiler.CompilerImports+ImportedAssembly:this (FullOpts)
          -2 (-28.57% of base) : 6527.dasm - FSharp.Compiler.Lexhelp+Keywords+keywordNames@362:Invoke(System.Tuple`3[FSharp.Compiler.Lexhelp+Keywords+compatibilityMode,System.String,FSharp.Compiler.Parser+token]):System.String:this (FullOpts)
          -2 (-28.57% of base) : 8775.dasm - FSharp.Compiler.MethodCalls+-ctor@660-63[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]:this (FullOpts)
          -2 (-28.57% of base) : 8777.dasm - FSharp.Compiler.MethodCalls+-ctor@661-64[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]:this (FullOpts)
          -2 (-28.57% of base) : 8779.dasm - FSharp.Compiler.MethodCalls+-ctor@662-65[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[System.__Canon]:this (FullOpts)
          -2 (-28.57% of base) : 8781.dasm - FSharp.Compiler.MethodCalls+-ctor@663-66[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.MethodCalls+CalledArg]:this (FullOpts)
          -2 (-28.57% of base) : 8783.dasm - FSharp.Compiler.MethodCalls+-ctor@664-67[System.__Canon]:Invoke(System.Tuple`6[System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon,System.__Canon]):Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.MethodCalls+CalledArg]:this (FullOpts)
          -2 (-28.57% of base) : 28245.dasm - Microsoft.CodeAnalysis.CSharp.Binder+<>c:<MakeDeconstructionConversion>b__272_0(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder):Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol:this (FullOpts)
          -2 (-20.00% of base) : 9353.dasm - FSharp.Compiler.AbstractIL.ILBinaryReader+seekReadProperties@2448-2:Invoke(System.Tuple`2[int,System.Tuple`2[int,int]]):int:this (FullOpts)
          -2 (-20.00% of base) : 25971.dasm - System.Collections.Generic.SortedDictionary`2[int,Microsoft.CodeAnalysis.CSharp.NullableWalker+Snapshot]:get_Count():int:this (FullOpts)
          -2 (-20.00% of base) : 7461.dasm - System.Xml.XmlTextReaderImpl:get_LineNumber():int:this (FullOpts)
          -2 (-20.00% of base) : 7462.dasm - System.Xml.XmlTextReaderImpl:get_LinePosition():int:this (FullOpts)
          -3 (-17.65% of base) : 11799.dasm - FSharp.Compiler.Parser+mWhole@1854-4:Invoke(System.Tuple`7[ubyte,Microsoft.FSharp.Collections.FSharpList`1[FSharp.Compiler.Syntax.SynAttributeList],System.Tuple`2[FSharp.Compiler.Syntax.SynPat,FSharp.Compiler.Text.Range],Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.Syntax.SynReturnInfo],Microsoft.FSharp.Core.FSharpOption`1[FSharp.Compiler.Text.Range],FSharp.Compiler.Syntax.SynExpr,FSharp.Compiler.Text.Range]):FSharp.Compiler.Text.Range:this (FullOpts)
          -2 (-16.67% of base) : 11352.dasm - FSharp.Compiler.PostTypeCheckSemanticChecks+duplicates@1935-4:Invoke(System.Tuple`2[System.Tuple`3[FSharp.Compiler.TypedTree+EntityRef,ubyte,FSharp.Compiler.Text.Range],int]):ubyte:this (FullOpts)
          -4 (-16.00% of base) : 25903.dasm - System.Collections.Generic.SortedSet`1+Node[System.Collections.Generic.KeyValuePair`2[int,Microsoft.CodeAnalysis.CSharp.NullableWalker+Snapshot]]:Split4Node():this (FullOpts)
          -2 (-15.38% of base) : 5999.dasm - FSharp.Compiler.TcGlobals+-ctor@1636-37:.ctor(FSharp.Compiler.TcGlobals+TcGlobals):this (FullOpts)

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

Total bytes of base: 5120325 (overridden on cmd)
Total bytes of diff: 5117376 (overridden on cmd)
Total bytes of delta: -2949 (-0.06 % of base)
    diff is an improvement.
    relative diff is an improvement.
```
<details>

<summary>Detail diffs</summary>

```


Top file regressions (bytes):
           5 : 16435.dasm (0.97% of base)
           5 : 19102.dasm (0.97% of base)
           5 : 21792.dasm (0.97% of base)
           5 : 4605.dasm (0.87% of base)
           5 : 1216.dasm (0.97% of base)
           2 : 14006.dasm (0.57% of base)
           2 : 8302.dasm (0.56% of base)
           1 : 12435.dasm (0.39% of base)

Top file improvements (bytes):
         -78 : 21715.dasm (-1.03% of base)
         -78 : 4550.dasm (-1.03% of base)
         -78 : 1128.dasm (-1.03% of base)
         -78 : 16432.dasm (-1.03% of base)
         -78 : 19034.dasm (-1.03% of base)
         -19 : 21723.dasm (-1.68% of base)
         -19 : 16440.dasm (-1.68% of base)
         -19 : 19073.dasm (-1.68% of base)
         -19 : 1141.dasm (-1.68% of base)
         -19 : 4548.dasm (-1.68% of base)
         -16 : 1853.dasm (-1.72% of base)
         -16 : 22277.dasm (-1.71% of base)
         -16 : 16953.dasm (-1.71% of base)
         -16 : 5706.dasm (-1.72% of base)
         -16 : 19638.dasm (-1.71% of base)
         -15 : 11655.dasm (-1.56% of base)
         -14 : 11510.dasm (-0.46% of base)
         -12 : 10226.dasm (-1.97% of base)
         -12 : 4810.dasm (-1.97% of base)
         -10 : 13765.dasm (-2.44% of base)

79 total files with Code Size differences (71 improved, 8 regressed), 4 unchanged.

Top method regressions (bytes):
           5 ( 0.97% of base) : 16435.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.97% of base) : 19102.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.97% of base) : 21792.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.87% of base) : 4605.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.97% of base) : 1216.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           2 ( 0.57% of base) : 14006.dasm - Internal.Runtime.TypeLoader.TypeBuilderState:ComputeNumVTableSlots():ushort:this (FullOpts)
           2 ( 0.56% of base) : 8302.dasm - Internal.Runtime.TypeLoader.TypeBuilderState:ComputeNumVTableSlots():ushort:this (FullOpts)
           1 ( 0.39% of base) : 12435.dasm - System.Dynamic.Utils.TypeUtils:GetBooleanOperator(System.Type,System.String):System.Reflection.MethodInfo (FullOpts)

Top method improvements (bytes):
         -78 (-1.03% of base) : 21715.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         -78 (-1.03% of base) : 4550.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         -78 (-1.03% of base) : 1128.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         -78 (-1.03% of base) : 16432.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         -78 (-1.03% of base) : 19034.dasm - System.Number:NumberToStringFormat[ushort](byref,byref,System.ReadOnlySpan`1[ushort],System.Globalization.NumberFormatInfo) (FullOpts)
         -19 (-1.68% of base) : 21723.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (FullOpts)
         -19 (-1.68% of base) : 16440.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (FullOpts)
         -19 (-1.68% of base) : 19073.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (FullOpts)
         -19 (-1.68% of base) : 1141.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (FullOpts)
         -19 (-1.68% of base) : 4548.dasm - System.Number:NumberToString[ushort](byref,byref,ushort,int,System.Globalization.NumberFormatInfo) (FullOpts)
         -16 (-1.72% of base) : 1853.dasm - System.Runtime.TypeCast:TypeParametersAreCompatible(int,Internal.Runtime.MethodTableList,Internal.Runtime.MethodTableList,ulong,ubyte,ulong):ubyte (FullOpts)
         -16 (-1.71% of base) : 22277.dasm - System.Runtime.TypeCast:TypeParametersAreCompatible(int,Internal.Runtime.MethodTableList,Internal.Runtime.MethodTableList,ulong,ubyte,ulong):ubyte (FullOpts)
         -16 (-1.71% of base) : 16953.dasm - System.Runtime.TypeCast:TypeParametersAreCompatible(int,Internal.Runtime.MethodTableList,Internal.Runtime.MethodTableList,ulong,ubyte,ulong):ubyte (FullOpts)
         -16 (-1.72% of base) : 5706.dasm - System.Runtime.TypeCast:TypeParametersAreCompatible(int,Internal.Runtime.MethodTableList,Internal.Runtime.MethodTableList,ulong,ubyte,ulong):ubyte (FullOpts)
         -16 (-1.71% of base) : 19638.dasm - System.Runtime.TypeCast:TypeParametersAreCompatible(int,Internal.Runtime.MethodTableList,Internal.Runtime.MethodTableList,ulong,ubyte,ulong):ubyte (FullOpts)
         -15 (-1.56% of base) : 11655.dasm - System.Linq.Expressions.Interpreter.LightCompiler:CompileMemberInit(System.Collections.ObjectModel.ReadOnlyCollection`1[System.Linq.Expressions.MemberBinding]):this (FullOpts)
         -14 (-0.46% of base) : 11510.dasm - System.Linq.Expressions.Interpreter.LightCompiler:CompileTryExpression(System.Linq.Expressions.Expression):this (FullOpts)
         -12 (-1.97% of base) : 10226.dasm - Internal.Runtime.TypeLoader.TypeLoaderEnvironment:TryGetDynamicRuntimeMethodHandleComponents(System.RuntimeMethodHandle,byref,byref,byref):ubyte:this (FullOpts)
         -12 (-1.97% of base) : 4810.dasm - Internal.Runtime.TypeLoader.TypeLoaderEnvironment:TryGetDynamicRuntimeMethodHandleComponents(System.RuntimeMethodHandle,byref,byref,byref):ubyte:this (FullOpts)
         -10 (-2.44% of base) : 13765.dasm - System.Linq.Expressions.Expression:GetUserDefinedUnaryOperator(int,System.String,System.Linq.Expressions.Expression):System.Linq.Expressions.UnaryExpression (FullOpts)

Top method regressions (percentages):
           5 ( 0.97% of base) : 16435.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.97% of base) : 19102.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.97% of base) : 21792.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.97% of base) : 1216.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           5 ( 0.87% of base) : 4605.dasm - System.Runtime.CompilerServices.DefaultInterpolatedStringHandler:AppendFormatted[System.__Canon](System.__Canon):this (FullOpts)
           2 ( 0.57% of base) : 14006.dasm - Internal.Runtime.TypeLoader.TypeBuilderState:ComputeNumVTableSlots():ushort:this (FullOpts)
           2 ( 0.56% of base) : 8302.dasm - Internal.Runtime.TypeLoader.TypeBuilderState:ComputeNumVTableSlots():ushort:this (FullOpts)
           1 ( 0.39% of base) : 12435.dasm - System.Dynamic.Utils.TypeUtils:GetBooleanOperator(System.Type,System.String):System.Reflection.MethodInfo (FullOpts)

Top method improvements (percentages):
          -2 (-22.22% of base) : 31837.dasm - System.Globalization.CultureData:get_FirstDayOfWeek():int:this (FullOpts)
          -2 (-20.00% of base) : 31840.dasm - System.Globalization.CultureData:get_LongTimes():System.String[]:this (FullOpts)
          -2 (-20.00% of base) : 31839.dasm - System.Globalization.CultureData:get_ShortTimes():System.String[]:this (FullOpts)
          -2 (-20.00% of base) : 31842.dasm - System.Globalization.CultureData:get_TimeSeparator():System.String:this (FullOpts)
          -3 (-16.67% of base) : 4832.dasm - Boxed_Enumerator[System.__Canon,System.__Canon]:get_Current_Unbox():System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]:this (FullOpts)
          -3 (-16.67% of base) : 16534.dasm - Boxed_Enumerator[System.__Canon,System.__Canon]:get_Current_Unbox():System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]:this (FullOpts)
          -3 (-16.67% of base) : 1316.dasm - Boxed_Enumerator[System.__Canon,System.__Canon]:get_Current_Unbox():System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]:this (FullOpts)
          -3 (-16.67% of base) : 19201.dasm - Boxed_Enumerator[System.__Canon,System.__Canon]:get_Current_Unbox():System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]:this (FullOpts)
          -3 (-16.67% of base) : 21877.dasm - Boxed_Enumerator[System.__Canon,System.__Canon]:get_Current_Unbox():System.Collections.Generic.KeyValuePair`2[System.__Canon,System.__Canon]:this (FullOpts)
          -2 (-16.67% of base) : 29136.dasm - Internal.Runtime.RelativePointer:get_Value():long:this (FullOpts)
          -2 (-16.67% of base) : 25892.dasm - Internal.Runtime.RelativePointer:get_Value():long:this (FullOpts)
          -2 (-16.67% of base) : 23653.dasm - Internal.Runtime.RelativePointer`1[ubyte]:get_Value():ulong:this (FullOpts)
          -2 (-16.67% of base) : 23672.dasm - Internal.Runtime.RelativePointer`1[ubyte]:get_Value():ulong:this (FullOpts)
          -2 (-14.29% of base) : 25943.dasm - System.Guid:GetHashCode():int:this (FullOpts)
          -2 (-14.29% of base) : 13877.dasm - System.TimeSpan:GetHashCode():int:this (FullOpts)
          -2 (-14.29% of base) : 8702.dasm - System.TimeSpan:GetHashCode():int:this (FullOpts)
          -3 (-13.04% of base) : 10398.dasm - Boxed_Foo`1[System.__Canon]:Set_Unbox(int):this (FullOpts)
          -3 (-13.04% of base) : 10437.dasm - Boxed_GenericDevirt`1[System.__Canon]:GetAndSet_Unbox(int):int:this (FullOpts)
          -3 (-13.04% of base) : 29758.dasm - System.Reflection.Runtime.General.Boxed_ListBuilder`1[System.__Canon]:get_Item_Unbox(int):System.__Canon:this (FullOpts)
          -3 (-12.50% of base) : 2849.dasm - System.Boxed_ValueTuple`2[System.__Canon,System.__Canon]:Equals_Unbox(System.Object):ubyte:this (FullOpts)

```

</details>

--------------------------------------------------------------------------------



</div></details>


</div></details>
