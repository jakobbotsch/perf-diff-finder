# ``System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes|Watson|Irene|Adler|John|Baker", Options: NonBacktracking)``

Hot functions:

- (91.87%) ``RegexFindOptimizations.TryFindNextStartingPositionLeftToRight`` (Tier-1)
  - **Has diffs**
- (3.99%) ``System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1.FindEndPositionDeltas`` (Tier-1)
  - **Has diffs**
- (2.14%) ``Regex.RunAllMatchesWithCallback`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]RegexFindOptimizations.TryFindNextStartingPositionLeftToRight(value class System.ReadOnlySpan`1<wchar>,int32&,int32)``

```diff
 ;* V08 loc4         [V08    ] (  0,   0   )     int  ->  zero-ref   
 ;* V09 loc5         [V09    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[XS] addr-exposed <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V10 loc6         [V10    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <ushort[]>
-;  V11 loc7         [V11,T61] (  1,   1   )  struct (16) [rsp+0x5C8]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V11 loc7         [V11,T62] (  1,   1   )  struct (16) [rsp+0x5C8]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V12 loc8         [V12    ] (  0,   0   )     int  ->  zero-ref   
 ;* V13 loc9         [V13    ] (  0,   0   )   byref  ->  zero-ref   
 ;* V14 loc10        [V14    ] (  0,   0   )     int  ->  zero-ref   
@@ -1429,13 +1429,13 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;  V28 loc24        [V28,T11] (  4,1299.95)   byref  ->  rdi        
 ;  V29 loc25        [V29,T26] (  7, 402.70)     int  ->  [rsp+0x51C]  tier0-frame
 ;  V30 loc26        [V30,T01] ( 21,4050.23)  ushort  ->  [rsp+0x518]  tier0-frame
-;  V31 loc27        [V31,T51] (  8,  17.77)     int  ->  [rsp+0x514]  tier0-frame
+;* V31 loc27        [V31,T61] (  0,   0   )     int  ->  zero-ref   
 ;* V32 loc28        [V32    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V33 loc29        [V33    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.RegexNode>
 ;* V34 loc30        [V34    ] (  0,   0   )  struct (24) zero-ref    <System.ValueTuple`4[ushort,System.String,int,ushort[]]>
 ;* V35 loc31        [V35    ] (  0,   0   )     int  ->  zero-ref   
-;  V36 loc32        [V36,T62] (  1,   1   )  struct (40) [rsp+0x4A0]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
-;  V37 loc33        [V37,T63] (  1,   1   )  struct (16) [rsp+0x490]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V36 loc32        [V36,T63] (  1,   1   )  struct (40) [rsp+0x4A0]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
+;  V37 loc33        [V37,T64] (  1,   1   )  struct (16) [rsp+0x490]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V38 loc34        [V38    ] (  0,   0   )     int  ->  zero-ref   
 ;* V39 loc35        [V39    ] (  0,   0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,   1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -1737,7 +1737,7 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;  V336 tmp296      [V336,T10] (  2,1599.94)     ref  ->  rdx         class-hnd exact "Inlining Arg" <<unknown class>>
 ;* V337 tmp297      [V337    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
 ;  V338 tmp298      [V338,T50] (  3,  71.81)   ubyte  ->  rax         "Inline return value spill temp"
-;  V339 tmp299      [V339,T31] (  5, 217.61)   byref  ->  [rsp+0x38]  spill-single-def "Inlining Arg"
+;  V339 tmp299      [V339,T31] (  5, 217.61)   byref  ->  [rsp+0x30]  spill-single-def "Inlining Arg"
 ;  V340 tmp300      [V340,T49] (  4,  73.99)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V341 tmp301      [V341    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;  V342 tmp302      [V342,T36] (  3, 104.45)     int  ->  rdx         "Inline stloc first use temp"
@@ -2037,7 +2037,7 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;  V636 tmp596      [V636,T45] (  4, 103.17)     int  ->  r15         "V01.[008..012)"
 ;  V637 tmp597      [V637,T00] ( 13,4800.83)     ref  ->  r13         single-def "V18.[000..008)"
 ;  V638 tmp598      [V638,T47] (  2, 101.00)     int  ->  r12         "V18.[016..020)"
-;  V639 tmp599      [V639,T25] ( 13, 420.00)     ref  ->  [rsp+0x30]  spill-single-def "V32.[000..008)"
+;  V639 tmp599      [V639,T25] ( 13, 420.00)     ref  ->  [rsp+0x28]  spill-single-def "V32.[000..008)"
 ;  V640 tmp600      [V640,T58] (  2,   4.35)     int  ->  rcx         "V32.[016..020)"
 ;* V641 tmp601      [V641    ] (  0,   0   )     ref  ->  zero-ref    "V43.[000..008)"
 ;* V642 tmp602      [V642    ] (  0,   0   )     ref  ->  zero-ref    "V43.[008..016)"
@@ -2056,6 +2056,7 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;  V655 cse1        [V655,T23] (  2, 799.97)     int  ->   r9         "CSE #01: moderate"
 ;  V656 cse2        [V656,T07] (  5,1999.93)     int  ->  rdx         multi-def "CSE #14: aggressive"
 ;  V657 cse3        [V657,T28] (  8, 278.55)     int  ->  [rsp+0x40]  multi-def "CSE #18: moderate"
+;  V658 rat0        [V658,T51] (  8,  17.77)    long  ->  [rsp+0x38]  "Widened IV V31"
 ;
 ; Lcl frame size = 104
 
@@ -2081,24 +2082,24 @@ G_M53443_IG02:
        mov      r12d, dword ptr [rsp+0x590]
        mov      eax, dword ptr [rsp+0x51C]
        cmp      eax, dword ptr [rsp+0x57C]
-       jg       G_M53443_IG39
+       jg       G_M53443_IG41
 						;; size=43 bbWeight=1 PerfScore 10.00
 G_M53443_IG03:
        mov      dword ptr [rsp+0x51C], eax
        lea      ecx, [rax+r12]
        cmp      ecx, r15d
-       jae      G_M53443_IG37
+       jae      G_M53443_IG39
        movzx    r11, word  ptr [r14+2*rcx]
        mov      rcx, gword ptr [rdi]
        test     rcx, rcx
-       je       SHORT G_M53443_IG05
+       je       SHORT G_M53443_IG06
 						;; size=33 bbWeight=100.00 PerfScore 799.97
 G_M53443_IG04:
        mov      edx, r11d
        sar      edx, 4
        mov      r9d, dword ptr [rcx+0x08]
        cmp      r9d, edx
-       jbe      SHORT G_M53443_IG05
+       jbe      SHORT G_M53443_IG06
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r11d
        and      edx, 15
@@ -2106,22 +2107,24 @@ G_M53443_IG04:
        mov      r9d, 1
        shlx     edx, r9d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG05
+       je       SHORT G_M53443_IG06
        add      edx, edx
        test     ecx, edx
-       je       G_M53443_IG16
-       jmp      G_M53443_IG18
-						;; size=57 bbWeight=399.99 PerfScore 4899.83
+       je       G_M53443_IG17
+						;; size=52 bbWeight=399.99 PerfScore 4099.85
 G_M53443_IG05:
+       jmp      G_M53443_IG19
+						;; size=5 bbWeight=1.73 PerfScore 3.45
+G_M53443_IG06:
        cmp      r11d, 128
-       jl       G_M53443_IG09
+       jl       G_M53443_IG10
        mov      r8d, dword ptr [r13+0x08]
        cmp      r8d, 1
-       jbe      G_M53443_IG37
+       jbe      G_M53443_IG39
        movzx    r9, word  ptr [r13+0x0E]
        mov      dword ptr [rsp+0x44], r8d
        cmp      r8d, 2
-       jbe      G_M53443_IG37
+       jbe      G_M53443_IG39
        movzx    rcx, word  ptr [r13+0x10]
        lea      edx, [r9+rcx+0x03]
        mov      dword ptr [rsp+0x64], edx
@@ -2132,40 +2135,41 @@ G_M53443_IG05:
        xor      r8d, r8d
        call     [<unknown method>]
        cmp      word  ptr [r13+0x0C], 1
-       jne      SHORT G_M53443_IG06
+       jne      SHORT G_M53443_IG07
        test     eax, eax
        sete     al
        movzx    rax, al
        test     eax, eax
-       je       SHORT G_M53443_IG08
-       jmp      SHORT G_M53443_IG07
+       je       SHORT G_M53443_IG09
+       jmp      SHORT G_M53443_IG08
 						;; size=110 bbWeight=399.99 PerfScore 10899.61
-G_M53443_IG06:
-       test     eax, eax
-       je       SHORT G_M53443_IG08
-						;; size=4 bbWeight=399.99 PerfScore 499.98
 G_M53443_IG07:
-       mov      r8d, dword ptr [rsp+0x64]
-       cmp      dword ptr [rsp+0x44], r8d
-       jle      SHORT G_M53443_IG08
+       test     eax, eax
+       je       SHORT G_M53443_IG09
+						;; size=4 bbWeight=399.99 PerfScore 499.98
+G_M53443_IG08:
+       mov      r10d, dword ptr [rsp+0x64]
+       cmp      dword ptr [rsp+0x44], r10d
+       jle      SHORT G_M53443_IG09
        mov      ecx, dword ptr [rsp+0x518]
        mov      rdx, r13
+       mov      r8d, r10d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        test     eax, eax
        sete     al
        movzx    rax, al
-						;; size=36 bbWeight=399.99 PerfScore 3899.86
-G_M53443_IG08:
-       jmp      G_M53443_IG15
-						;; size=5 bbWeight=399.99 PerfScore 799.97
+						;; size=39 bbWeight=399.99 PerfScore 3999.86
 G_M53443_IG09:
+       jmp      G_M53443_IG16
+						;; size=5 bbWeight=399.99 PerfScore 799.97
+G_M53443_IG10:
        mov      r8d, dword ptr [r13+0x08]
        cmp      r8d, 1
-       jbe      G_M53443_IG37
+       jbe      G_M53443_IG39
        movzx    r9, word  ptr [r13+0x0E]
        mov      dword ptr [rsp+0x44], r8d
        cmp      r8d, 2
-       jbe      G_M53443_IG37
+       jbe      G_M53443_IG39
        movzx    rcx, word  ptr [r13+0x10]
        lea      edx, [r9+rcx+0x03]
        mov      dword ptr [rsp+0x5C], edx
@@ -2176,30 +2180,31 @@ G_M53443_IG09:
        xor      r8d, r8d
        call     [<unknown method>]
        cmp      word  ptr [r13+0x0C], 1
-       jne      SHORT G_M53443_IG10
+       jne      SHORT G_M53443_IG11
        test     eax, eax
        sete     al
        movzx    rax, al
        test     eax, eax
-       je       SHORT G_M53443_IG12
-       jmp      SHORT G_M53443_IG11
+       je       SHORT G_M53443_IG13
+       jmp      SHORT G_M53443_IG12
 						;; size=97 bbWeight=399.99 PerfScore 10399.63
-G_M53443_IG10:
-       test     eax, eax
-       je       SHORT G_M53443_IG12
-						;; size=4 bbWeight=399.99 PerfScore 499.98
 G_M53443_IG11:
-       mov      r8d, dword ptr [rsp+0x5C]
-       cmp      dword ptr [rsp+0x44], r8d
-       jle      SHORT G_M53443_IG12
+       test     eax, eax
+       je       SHORT G_M53443_IG13
+						;; size=4 bbWeight=399.99 PerfScore 499.98
+G_M53443_IG12:
+       mov      r10d, dword ptr [rsp+0x5C]
+       cmp      dword ptr [rsp+0x44], r10d
+       jle      SHORT G_M53443_IG13
        mov      ecx, dword ptr [rsp+0x518]
        mov      rdx, r13
+       mov      r8d, r10d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        test     eax, eax
        sete     al
        movzx    rax, al
-						;; size=36 bbWeight=399.99 PerfScore 3899.86
-G_M53443_IG12:
+						;; size=39 bbWeight=399.99 PerfScore 3999.86
+G_M53443_IG13:
        mov      edx, dword ptr [rsp+0x518]
        mov      ecx, edx
        and      ecx, 15
@@ -2208,16 +2213,16 @@ G_M53443_IG12:
        shlx     ecx, r8d, ecx
        mov      dword ptr [rsp+0x58], eax
        test     eax, eax
-       je       SHORT G_M53443_IG13
+       je       SHORT G_M53443_IG14
        lea      r8d, [rcx+rcx]
        or       ecx, r8d
        mov      dword ptr [rsp+0x60], ecx
        mov      ecx, dword ptr [rsp+0x60]
 						;; size=48 bbWeight=399.99 PerfScore 2999.89
-G_M53443_IG13:
+G_M53443_IG14:
        mov      r8, gword ptr [rdi]
        test     r8, r8
-       jne      SHORT G_M53443_IG14
+       jne      SHORT G_M53443_IG15
        mov      dword ptr [rsp+0x60], ecx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        mov      edx, 8
@@ -2228,76 +2233,76 @@ G_M53443_IG13:
        call     <unknown method>
        mov      r8, rax
        test     r8, r8
-       jne      SHORT G_M53443_IG17
+       jne      SHORT G_M53443_IG18
        mov      r8, gword ptr [rdi]
        mov      ecx, dword ptr [rsp+0x60]
 						;; size=61 bbWeight=399.99 PerfScore 4799.83
-G_M53443_IG14:
+G_M53443_IG15:
        mov      edx, dword ptr [rsp+0x518]
        sar      edx, 4
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M53443_IG37
+       jae      G_M53443_IG39
        lea      rdx, bword ptr [r8+4*rdx+0x10]
        lock     
        or       dword ptr [rdx], ecx
        mov      eax, dword ptr [rsp+0x58]
 						;; size=32 bbWeight=399.99 PerfScore 9399.67
-G_M53443_IG15:
-       test     eax, eax
-       jne      SHORT G_M53443_IG18
-						;; size=4 bbWeight=100.00 PerfScore 125.00
 G_M53443_IG16:
+       test     eax, eax
+       jne      SHORT G_M53443_IG19
+						;; size=4 bbWeight=100.00 PerfScore 125.00
+G_M53443_IG17:
        mov      eax, dword ptr [rsp+0x51C]
        inc      eax
        mov      r10d, dword ptr [rsp+0x57C]
        cmp      eax, r10d
-       jg       G_M53443_IG39
+       jg       G_M53443_IG41
        mov      dword ptr [rsp+0x57C], r10d
        jmp      G_M53443_IG03
 						;; size=39 bbWeight=100.00 PerfScore 649.98
-G_M53443_IG17:
-       mov      ecx, dword ptr [rsp+0x60]
-       jmp      SHORT G_M53443_IG14
-						;; size=6 bbWeight=199.99 PerfScore 599.98
 G_M53443_IG18:
-       mov      r9d, 1
-       cmp      dword ptr [rbp+0x10], 1
-       jle      G_M53443_IG34
-						;; size=16 bbWeight=1.73 PerfScore 7.34
+       mov      ecx, dword ptr [rsp+0x60]
+       jmp      SHORT G_M53443_IG15
+						;; size=6 bbWeight=199.99 PerfScore 599.98
 G_M53443_IG19:
-       cmp      r9d, dword ptr [rbp+0x10]
-       jae      G_M53443_IG38
+       mov      eax, 1
+       cmp      dword ptr [rbp+0x10], 1
+       jle      G_M53443_IG36
+						;; size=15 bbWeight=1.73 PerfScore 7.34
+G_M53443_IG20:
+       cmp      eax, dword ptr [rbp+0x10]
+       jae      G_M53443_IG40
        mov      rcx, gword ptr [rbp+0x08]
-       cmp      r9d, dword ptr [rcx+0x08]
-       jae      G_M53443_IG37
-       mov      edx, r9d
+       cmp      eax, dword ptr [rcx+0x08]
+       jae      G_M53443_IG39
+       mov      rdx, rax
        shl      rdx, 5
        lea      rcx, bword ptr [rcx+rdx+0x10]
-       mov      r11, gword ptr [rcx]
-       mov      gword ptr [rsp+0x30], r11
+       mov      r10, gword ptr [rcx]
+       mov      gword ptr [rsp+0x28], r10
        mov      ecx, dword ptr [rcx+0x10]
-       mov      eax, dword ptr [rsp+0x51C]
-       add      ecx, eax
+       mov      r9d, dword ptr [rsp+0x51C]
+       add      ecx, r9d
        cmp      ecx, r15d
-       jae      G_M53443_IG37
+       jae      G_M53443_IG39
        movzx    rdx, word  ptr [r14+2*rcx]
        mov      dword ptr [rsp+0x518], edx
        mov      rcx, gword ptr [rbx+0x08]
-       mov      dword ptr [rsp+0x514], r9d
-       movsxd   rdx, r9d
+       mov      qword ptr [rsp+0x38], rax
+       movsxd   rdx, eax
        mov      r8, 0xD1FFAB1E      ; <unknown class>
        call     [CORINFO_HELP_LDELEMA_REF]
-       mov      bword ptr [rsp+0x38], rax
+       mov      bword ptr [rsp+0x30], rax
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M53443_IG21
-						;; size=121 bbWeight=2.18 PerfScore 71.81
-G_M53443_IG20:
+       je       SHORT G_M53443_IG23
+						;; size=118 bbWeight=2.18 PerfScore 71.81
+G_M53443_IG21:
        mov      r10d, dword ptr [rsp+0x518]
        mov      edx, r10d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M53443_IG22
+       jbe      SHORT G_M53443_IG24
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r10d
        and      edx, 15
@@ -2305,73 +2310,76 @@ G_M53443_IG20:
        mov      r9d, 1
        shlx     edx, r9d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG22
+       je       SHORT G_M53443_IG24
        add      edx, edx
        test     ecx, edx
-       je       G_M53443_IG16
-       jmp      G_M53443_IG33
-						;; size=61 bbWeight=34.82 PerfScore 487.46
-G_M53443_IG21:
+       je       G_M53443_IG17
+						;; size=56 bbWeight=34.82 PerfScore 417.82
+G_M53443_IG22:
+       mov      rcx, qword ptr [rsp+0x38]
+       jmp      G_M53443_IG35
+						;; size=10 bbWeight=2.45 PerfScore 7.34
+G_M53443_IG23:
        mov      r10d, dword ptr [rsp+0x518]
 						;; size=8 bbWeight=1.09 PerfScore 1.09
-G_M53443_IG22:
+G_M53443_IG24:
        cmp      r10d, 128
-       jl       G_M53443_IG26
-       mov      rax, gword ptr [rsp+0x30]
-       mov      r11d, dword ptr [rax+0x08]
-       cmp      r11d, 1
-       jbe      G_M53443_IG37
-       movzx    r9, word  ptr [rax+0x0E]
-       mov      dword ptr [rsp+0x40], r11d
-       cmp      r11d, 2
-       jbe      G_M53443_IG37
-       movzx    rcx, word  ptr [rax+0x10]
-       lea      r8d, [r9+rcx+0x03]
-       mov      dword ptr [rsp+0x54], r8d
+       jl       G_M53443_IG28
+       mov      r11, gword ptr [rsp+0x28]
+       mov      r8d, dword ptr [r11+0x08]
+       cmp      r8d, 1
+       jbe      G_M53443_IG39
+       movzx    r9, word  ptr [r11+0x0E]
+       mov      dword ptr [rsp+0x40], r8d
+       cmp      r8d, 2
+       jbe      G_M53443_IG39
+       movzx    rcx, word  ptr [r11+0x10]
+       lea      edx, [r9+rcx+0x03]
+       mov      dword ptr [rsp+0x54], edx
        mov      dword ptr [rsp+0x20], ecx
        mov      dword ptr [rsp+0x518], r10d
        mov      ecx, r10d
-       mov      rdx, rax
+       mov      rdx, r11
        xor      r8d, r8d
        call     [<unknown method>]
-       mov      r10, gword ptr [rsp+0x30]
+       mov      r10, gword ptr [rsp+0x28]
        cmp      word  ptr [r10+0x0C], 1
-       jne      SHORT G_M53443_IG23
+       jne      SHORT G_M53443_IG25
        test     eax, eax
        sete     al
        movzx    rax, al
        test     eax, eax
-       je       SHORT G_M53443_IG25
-       jmp      SHORT G_M53443_IG24
+       je       SHORT G_M53443_IG27
+       jmp      SHORT G_M53443_IG26
 						;; size=120 bbWeight=34.82 PerfScore 1018.44
-G_M53443_IG23:
+G_M53443_IG25:
        test     eax, eax
-       je       SHORT G_M53443_IG25
+       je       SHORT G_M53443_IG27
 						;; size=4 bbWeight=34.82 PerfScore 43.52
-G_M53443_IG24:
-       mov      r8d, dword ptr [rsp+0x54]
-       cmp      dword ptr [rsp+0x40], r8d
-       jle      SHORT G_M53443_IG25
+G_M53443_IG26:
+       mov      r9d, dword ptr [rsp+0x54]
+       cmp      dword ptr [rsp+0x40], r9d
+       jle      SHORT G_M53443_IG27
        mov      ecx, dword ptr [rsp+0x518]
        mov      rdx, r10
+       mov      r8d, r9d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        test     eax, eax
        sete     al
        movzx    rax, al
-						;; size=36 bbWeight=34.82 PerfScore 339.48
-G_M53443_IG25:
-       jmp      G_M53443_IG32
+						;; size=39 bbWeight=34.82 PerfScore 348.18
+G_M53443_IG27:
+       jmp      G_M53443_IG34
 						;; size=5 bbWeight=34.82 PerfScore 69.64
-G_M53443_IG26:
-       mov      r11, gword ptr [rsp+0x30]
-       mov      ecx, dword ptr [r11+0x08]
-       mov      r8d, ecx
+G_M53443_IG28:
+       mov      r11, gword ptr [rsp+0x28]
+       mov      r8d, dword ptr [r11+0x08]
        cmp      r8d, 1
-       jbe      G_M53443_IG37
+       jbe      G_M53443_IG39
        movzx    r9, word  ptr [r11+0x0E]
        mov      dword ptr [rsp+0x40], r8d
        cmp      r8d, 2
-       jbe      G_M53443_IG37
+       jbe      G_M53443_IG39
        movzx    rcx, word  ptr [r11+0x10]
        lea      edx, [r9+rcx+0x03]
        mov      dword ptr [rsp+0x4C], edx
@@ -2381,31 +2389,33 @@ G_M53443_IG26:
        mov      rdx, r11
        xor      r8d, r8d
        call     [<unknown method>]
-       mov      rdx, gword ptr [rsp+0x30]
-       cmp      word  ptr [rdx+0x0C], 1
-       jne      SHORT G_M53443_IG27
+       mov      r10, gword ptr [rsp+0x28]
+       cmp      word  ptr [r10+0x0C], 1
+       jne      SHORT G_M53443_IG29
        test     eax, eax
        sete     al
        movzx    rax, al
        test     eax, eax
-       je       SHORT G_M53443_IG29
-       jmp      SHORT G_M53443_IG28
-						;; size=109 bbWeight=34.82 PerfScore 983.62
-G_M53443_IG27:
+       je       SHORT G_M53443_IG31
+       jmp      SHORT G_M53443_IG30
+						;; size=107 bbWeight=34.82 PerfScore 974.91
+G_M53443_IG29:
        test     eax, eax
-       je       SHORT G_M53443_IG29
+       je       SHORT G_M53443_IG31
 						;; size=4 bbWeight=34.82 PerfScore 43.52
-G_M53443_IG28:
-       mov      r8d, dword ptr [rsp+0x4C]
-       cmp      dword ptr [rsp+0x40], r8d
-       jle      SHORT G_M53443_IG29
+G_M53443_IG30:
+       mov      r9d, dword ptr [rsp+0x4C]
+       cmp      dword ptr [rsp+0x40], r9d
+       jle      SHORT G_M53443_IG31
        mov      ecx, dword ptr [rsp+0x518]
+       mov      rdx, r10
+       mov      r8d, r9d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        test     eax, eax
        sete     al
        movzx    rax, al
-						;; size=33 bbWeight=34.82 PerfScore 330.77
-G_M53443_IG29:
+						;; size=39 bbWeight=34.82 PerfScore 348.18
+G_M53443_IG31:
        mov      r8d, dword ptr [rsp+0x518]
        mov      ecx, r8d
        and      ecx, 15
@@ -2414,61 +2424,61 @@ G_M53443_IG29:
        shlx     ecx, edx, ecx
        mov      dword ptr [rsp+0x48], eax
        test     eax, eax
-       je       SHORT G_M53443_IG30
+       je       SHORT G_M53443_IG32
        lea      edx, [rcx+rcx]
        or       ecx, edx
        mov      dword ptr [rsp+0x50], ecx
        mov      ecx, dword ptr [rsp+0x50]
 						;; size=47 bbWeight=34.82 PerfScore 261.14
-G_M53443_IG30:
-       mov      r10, bword ptr [rsp+0x38]
+G_M53443_IG32:
+       mov      r10, bword ptr [rsp+0x30]
        mov      r9, gword ptr [r10]
        test     r9, r9
-       jne      SHORT G_M53443_IG31
+       jne      SHORT G_M53443_IG33
        mov      dword ptr [rsp+0x50], ecx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        mov      edx, 8
        call     CORINFO_HELP_NEWARR_1_VC
        mov      rdx, rax
-       mov      rcx, bword ptr [rsp+0x38]
+       mov      rcx, bword ptr [rsp+0x30]
        xor      r8, r8
        call     <unknown method>
        mov      r9, rax
        test     r9, r9
-       jne      SHORT G_M53443_IG36
-       mov      r9, bword ptr [rsp+0x38]
-       mov      r9, gword ptr [r9]
+       jne      SHORT G_M53443_IG38
+       mov      rax, bword ptr [rsp+0x30]
+       mov      r9, gword ptr [rax]
        mov      ecx, dword ptr [rsp+0x50]
 						;; size=73 bbWeight=34.82 PerfScore 513.57
-G_M53443_IG31:
+G_M53443_IG33:
        mov      r8d, dword ptr [rsp+0x518]
        mov      edx, r8d
        sar      edx, 4
        cmp      edx, dword ptr [r9+0x08]
-       jae      SHORT G_M53443_IG37
+       jae      SHORT G_M53443_IG39
+       sar      r8d, 4
        mov      edx, r8d
-       sar      edx, 4
        lea      rdx, bword ptr [r9+4*rdx+0x10]
        lock     
        or       dword ptr [rdx], ecx
        mov      eax, dword ptr [rsp+0x48]
-						;; size=38 bbWeight=34.82 PerfScore 853.05
-G_M53443_IG32:
-       test     eax, eax
-       je       G_M53443_IG16
-						;; size=8 bbWeight=2.18 PerfScore 2.72
-G_M53443_IG33:
-       mov      r9d, dword ptr [rsp+0x514]
-       inc      r9d
-       cmp      r9d, dword ptr [rbp+0x10]
-       jl       G_M53443_IG19
-						;; size=21 bbWeight=2.45 PerfScore 12.84
+						;; size=39 bbWeight=34.82 PerfScore 853.05
 G_M53443_IG34:
-       mov      eax, dword ptr [rsp+0x51C]
-       mov      dword ptr [rsi], eax
+       test     eax, eax
+       je       G_M53443_IG17
+						;; size=8 bbWeight=2.18 PerfScore 2.72
+G_M53443_IG35:
+       mov      rax, qword ptr [rsp+0x38]
+       inc      eax
+       cmp      eax, dword ptr [rbp+0x10]
+       jl       G_M53443_IG20
+						;; size=16 bbWeight=2.45 PerfScore 12.84
+G_M53443_IG36:
+       mov      ebx, dword ptr [rsp+0x51C]
+       mov      dword ptr [rsi], ebx
        mov      eax, 1
 						;; size=14 bbWeight=0.27 PerfScore 0.61
-G_M53443_IG35:
+G_M53443_IG37:
        add      rsp, 0x618
        pop      rbx
        pop      rsi
@@ -2480,22 +2490,22 @@ G_M53443_IG35:
        pop      rbp
        ret      
 						;; size=20 bbWeight=0.27 PerfScore 1.41
-G_M53443_IG36:
+G_M53443_IG38:
        mov      ecx, dword ptr [rsp+0x50]
-       jmp      SHORT G_M53443_IG31
+       jmp      SHORT G_M53443_IG33
 						;; size=6 bbWeight=17.41 PerfScore 52.23
-G_M53443_IG37:
+G_M53443_IG39:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG38:
+G_M53443_IG40:
        call     [System.ThrowHelper:ThrowArgumentOutOfRange_IndexMustBeLessException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG39:
+G_M53443_IG41:
        mov      dword ptr [rsi], r15d
        xor      eax, eax
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG40:
+G_M53443_IG42:
        add      rsp, 0x618
        pop      rbx
        pop      rsi
@@ -2508,7 +2518,7 @@ G_M53443_IG40:
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1499, prolog size 103, PerfScore 60294.54, instruction count 368, allocated bytes for code 1499 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
+; Total bytes of code 1509, prolog size 103, PerfScore 59653.12, instruction count 373, allocated bytes for code 1509 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
@@ -2868,18 +2878,18 @@ G_M53443_IG40:
 ;  V342 tmp302      [V342,T41] (  3,  1074.03)     int  ->  rdx         "Inline stloc first use temp"
 ;  V343 tmp303      [V343,T42] (  3,  1074.03)     int  ->  rcx         "Inline stloc first use temp"
 ;  V344 tmp304      [V344,T43] (  3,  1074.03)     int  ->  rdx         "Inline stloc first use temp"
-;  V345 tmp305      [V345,T44] (  3,  1074.03)     int  ->  [rsp+0x54]  spill-single-def "Inline stloc first use temp"
+;  V345 tmp305      [V345,T44] (  3,  1074.03)     int  ->  rax         "Inline stloc first use temp"
 ;  V346 tmp306      [V346,T45] (  3,  1074.03)     int  ->  rcx         "Inline stloc first use temp"
 ;  V347 tmp307      [V347,T46] (  3,  1074.03)     int  ->  rsi         "Inline stloc first use temp"
 ;  V348 tmp308      [V348,T35] (  7,  2506.08)   ubyte  ->  rax         "Inline stloc first use temp"
 ;* V349 tmp309      [V349    ] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V350 tmp310      [V350    ] (  0,     0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V351 tmp311      [V351,T37] (  5,  1790.06)     int  ->  [rsp+0x50]  "Inline stloc first use temp"
+;  V351 tmp311      [V351,T37] (  5,  1790.06)     int  ->  [rsp+0x54]  "Inline stloc first use temp"
 ;  V352 tmp312      [V352,T38] (  2,  1432.05)     ref  ->   r8         class-hnd "dup spill" <System.Object>
 ;  V353 tmp313      [V353,T34] (  7,  2506.08)     ref  ->   r8        
 ;* V354 tmp314      [V354    ] (  0,     0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <<unknown class>>
 ;  V355 tmp315      [V355,T39] (  2,  1432.05)     ref  ->   r8         class-hnd "dup spill" <<unknown class>>
-;  V356 tmp316      [V356,T47] (  3,  1074.03)     int  ->  [rsp+0x4C]  spill-single-def "Inline stloc first use temp"
+;  V356 tmp316      [V356,T47] (  3,  1074.03)     int  ->  [rsp+0x50]  spill-single-def "Inline stloc first use temp"
 ;  V357 tmp317      [V357,T48] (  3,  1074.03)     int  ->  rsi         "Inline stloc first use temp"
 ;  V358 tmp318      [V358,T49] (  3,  1074.03)     int  ->  rbx         "Inline stloc first use temp"
 ;  V359 tmp319      [V359,T32] (  8,  2864.09)   ubyte  ->  rsi         "Inline stloc first use temp"
@@ -3178,7 +3188,7 @@ G_M53443_IG40:
 ;* V652 tmp612      [V652    ] (  0,     0   )     ref  ->  zero-ref    "arr expr"
 ;* V653 tmp613      [V653    ] (  0,     0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Span`1[ushort]>
 ;  V654 tmp614      [V654,T54] (  3,   537.02)     ref  ->  rcx         "arr expr"
-;  V655 cse0        [V655,T03] (  8,163397.83)     int  ->  [rsp+0x48]  multi-def "CSE #02: aggressive"
+;  V655 cse0        [V655,T03] (  8,163397.83)     int  ->  [rsp+0x4C]  multi-def "CSE #02: aggressive"
 ;  V656 cse1        [V656,T25] (  4, 20961.75)    long  ->  [rsp+0x40]  spill-single-def "CSE #16: moderate"
 ;  V657 cse2        [V657,T23] (  2, 40849.46)     int  ->   r8         "CSE #01: moderate"
 ;  V658 cse3        [V658,T07] (  5,102123.64)     int  ->  rdx         multi-def "CSE #14: aggressive"
@@ -3211,7 +3221,7 @@ G_M53443_IG03:
        mov      r9d, dword ptr [rsp+0x51C]
        lea      ecx, [r9+r12]
        cmp      ecx, r15d
-       jae      G_M53443_IG39
+       jae      G_M53443_IG40
        movzx    rcx, word  ptr [r14+2*rcx]
        mov      eax, ecx
        mov      rcx, gword ptr [rdi]
@@ -3244,11 +3254,11 @@ G_M53443_IG06:
        jl       G_M53443_IG10
        mov      r10d, dword ptr [r13+0x08]
        cmp      r10d, 1
-       jbe      G_M53443_IG39
+       jbe      G_M53443_IG40
        movzx    r8, word  ptr [r13+0x0E]
-       mov      dword ptr [rsp+0x48], r10d
+       mov      dword ptr [rsp+0x4C], r10d
        cmp      r10d, 2
-       jbe      G_M53443_IG39
+       jbe      G_M53443_IG40
        movzx    rcx, word  ptr [r13+0x10]
        lea      edx, [r8+rcx+0x03]
        mov      dword ptr [rsp+0x64], edx
@@ -3273,27 +3283,28 @@ G_M53443_IG07:
        je       SHORT G_M53443_IG09
 						;; size=4 bbWeight=20424.73 PerfScore 25530.91
 G_M53443_IG08:
-       mov      r8d, dword ptr [rsp+0x64]
-       cmp      dword ptr [rsp+0x48], r8d
+       mov      r10d, dword ptr [rsp+0x64]
+       cmp      dword ptr [rsp+0x4C], r10d
        jle      SHORT G_M53443_IG09
        mov      ecx, dword ptr [rsp+0x518]
        mov      rdx, r13
+       mov      r8d, r10d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        test     eax, eax
        sete     al
        movzx    rax, al
-						;; size=36 bbWeight=20424.73 PerfScore 199141.10
+						;; size=39 bbWeight=20424.73 PerfScore 204247.29
 G_M53443_IG09:
        jmp      G_M53443_IG16
 						;; size=5 bbWeight=20424.73 PerfScore 40849.46
 G_M53443_IG10:
        mov      r10d, dword ptr [r13+0x08]
        cmp      r10d, 1
-       jbe      G_M53443_IG39
+       jbe      G_M53443_IG40
        movzx    r8, word  ptr [r13+0x0E]
-       mov      dword ptr [rsp+0x48], r10d
+       mov      dword ptr [rsp+0x4C], r10d
        cmp      r10d, 2
-       jbe      G_M53443_IG39
+       jbe      G_M53443_IG40
        movzx    rcx, word  ptr [r13+0x10]
        lea      edx, [r8+rcx+0x03]
        mov      dword ptr [rsp+0x5C], edx
@@ -3318,16 +3329,17 @@ G_M53443_IG11:
        je       SHORT G_M53443_IG13
 						;; size=4 bbWeight=20424.73 PerfScore 25530.91
 G_M53443_IG12:
-       mov      r8d, dword ptr [rsp+0x5C]
-       cmp      dword ptr [rsp+0x48], r8d
+       mov      r10d, dword ptr [rsp+0x5C]
+       cmp      dword ptr [rsp+0x4C], r10d
        jle      SHORT G_M53443_IG13
        mov      ecx, dword ptr [rsp+0x518]
        mov      rdx, r13
+       mov      r8d, r10d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        test     eax, eax
        sete     al
        movzx    rax, al
-						;; size=36 bbWeight=20424.73 PerfScore 199141.10
+						;; size=39 bbWeight=20424.73 PerfScore 204247.29
 G_M53443_IG13:
        mov      r8d, dword ptr [rsp+0x518]
        mov      ecx, r8d
@@ -3366,12 +3378,13 @@ G_M53443_IG15:
        mov      edx, r8d
        sar      edx, 4
        cmp      edx, dword ptr [r10+0x08]
-       jae      G_M53443_IG39
-       lea      rdx, bword ptr [r10+4*rdx+0x10]
+       jae      G_M53443_IG40
+       mov      r8d, edx
+       lea      rdx, bword ptr [r10+4*r8+0x10]
        lock     
        or       dword ptr [rdx], ecx
        mov      eax, dword ptr [rsp+0x58]
-						;; size=36 bbWeight=20424.73 PerfScore 485087.30
+						;; size=39 bbWeight=20424.73 PerfScore 490193.49
 G_M53443_IG16:
        test     eax, eax
        jne      SHORT G_M53443_IG19
@@ -3381,7 +3394,7 @@ G_M53443_IG17:
        inc      r9d
        mov      dword ptr [rsp+0x51C], r9d
        cmp      r9d, dword ptr [rsp+0x57C]
-       jg       G_M53443_IG41
+       jg       G_M53443_IG42
        jmp      G_M53443_IG03
 						;; size=38 bbWeight=5106.18 PerfScore 37019.82
 G_M53443_IG18:
@@ -3396,14 +3409,14 @@ G_M53443_IG19:
 G_M53443_IG20:
        mov      eax, dword ptr [rsp+0x514]
        cmp      eax, dword ptr [rbp+0x10]
-       jge      G_M53443_IG36
+       jge      G_M53443_IG37
 						;; size=16 bbWeight=72.49 PerfScore 362.43
 G_M53443_IG21:
        cmp      eax, dword ptr [rbp+0x10]
-       jae      G_M53443_IG40
+       jae      G_M53443_IG41
        mov      rcx, gword ptr [rbp+0x08]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M53443_IG39
+       jae      G_M53443_IG40
        mov      edx, eax
        shl      rdx, 5
        lea      rcx, bword ptr [rcx+rdx+0x10]
@@ -3413,7 +3426,7 @@ G_M53443_IG21:
        mov      r9d, dword ptr [rsp+0x51C]
        add      ecx, r9d
        cmp      ecx, r15d
-       jae      G_M53443_IG39
+       jae      G_M53443_IG40
        movzx    r11, word  ptr [r14+2*rcx]
        mov      dword ptr [rsp+0x518], r11d
        mov      gword ptr [rsp+0x660], rbx
@@ -3426,14 +3439,14 @@ G_M53443_IG21:
        mov      bword ptr [rsp+0x30], rax
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M53443_IG23
+       je       SHORT G_M53443_IG24
 						;; size=133 bbWeight=89.50 PerfScore 3132.60
 G_M53443_IG22:
        mov      r10d, dword ptr [rsp+0x518]
        mov      edx, r10d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M53443_IG24
+       jbe      SHORT G_M53443_IG25
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r10d
        and      edx, 15
@@ -3441,53 +3454,54 @@ G_M53443_IG22:
        mov      r9d, 1
        shlx     edx, r9d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG24
+       je       SHORT G_M53443_IG25
        add      edx, edx
        test     ecx, edx
        je       G_M53443_IG17
-       jmp      G_M53443_IG35
-						;; size=61 bbWeight=358.01 PerfScore 5012.16
+						;; size=56 bbWeight=358.01 PerfScore 4296.14
 G_M53443_IG23:
+       jmp      G_M53443_IG36
+						;; size=5 bbWeight=100 PerfScore 200.00
+G_M53443_IG24:
        mov      r10d, dword ptr [rsp+0x518]
 						;; size=8 bbWeight=44.75 PerfScore 44.75
-G_M53443_IG24:
+G_M53443_IG25:
        cmp      r10d, 128
-       jl       G_M53443_IG28
-       mov      rax, gword ptr [rsp+0x28]
-       mov      r8d, dword ptr [rax+0x08]
-       cmp      r8d, 1
-       jbe      G_M53443_IG39
-       movzx    rdx, word  ptr [rax+0x0E]
-       mov      dword ptr [rsp+0x54], edx
-       mov      dword ptr [rsp+0x3C], r8d
-       cmp      r8d, 2
-       jbe      G_M53443_IG39
-       movzx    rcx, word  ptr [rax+0x10]
-       lea      esi, [rdx+rcx+0x03]
+       jl       G_M53443_IG29
+       mov      r8, gword ptr [rsp+0x28]
+       mov      edx, dword ptr [r8+0x08]
+       cmp      edx, 1
+       jbe      G_M53443_IG40
+       movzx    rax, word  ptr [r8+0x0E]
+       mov      dword ptr [rsp+0x3C], edx
+       cmp      edx, 2
+       jbe      G_M53443_IG40
+       movzx    rcx, word  ptr [r8+0x10]
+       lea      esi, [rax+rcx+0x03]
        mov      dword ptr [rsp+0x20], ecx
        mov      dword ptr [rsp+0x518], r10d
        mov      ecx, r10d
-       mov      rdx, rax
-       mov      r9d, dword ptr [rsp+0x54]
+       mov      rdx, r8
+       mov      r9d, eax
        xor      r8d, r8d
        call     [<unknown method>]
        mov      r10, gword ptr [rsp+0x28]
        cmp      word  ptr [r10+0x0C], 1
-       jne      SHORT G_M53443_IG25
+       jne      SHORT G_M53443_IG26
        test     eax, eax
        sete     al
        movzx    rax, al
        test     eax, eax
-       je       SHORT G_M53443_IG27
-       jmp      SHORT G_M53443_IG26
-						;; size=122 bbWeight=358.01 PerfScore 10829.85
-G_M53443_IG25:
-       test     eax, eax
-       je       SHORT G_M53443_IG27
-						;; size=4 bbWeight=358.01 PerfScore 447.51
+       je       SHORT G_M53443_IG28
+       jmp      SHORT G_M53443_IG27
+						;; size=115 bbWeight=358.01 PerfScore 10203.33
 G_M53443_IG26:
+       test     eax, eax
+       je       SHORT G_M53443_IG28
+						;; size=4 bbWeight=358.01 PerfScore 447.51
+G_M53443_IG27:
        cmp      dword ptr [rsp+0x3C], esi
-       jle      SHORT G_M53443_IG27
+       jle      SHORT G_M53443_IG28
        mov      ecx, dword ptr [rsp+0x518]
        mov      rdx, r10
        mov      r8d, esi
@@ -3496,55 +3510,55 @@ G_M53443_IG26:
        sete     al
        movzx    rax, al
 						;; size=33 bbWeight=358.01 PerfScore 3222.10
-G_M53443_IG27:
-       jmp      G_M53443_IG34
-						;; size=5 bbWeight=358.01 PerfScore 716.02
 G_M53443_IG28:
+       jmp      G_M53443_IG35
+						;; size=5 bbWeight=358.01 PerfScore 716.02
+G_M53443_IG29:
        mov      r8, gword ptr [rsp+0x28]
-       mov      ecx, dword ptr [r8+0x08]
-       mov      edx, ecx
+       mov      edx, dword ptr [r8+0x08]
        cmp      edx, 1
-       jbe      G_M53443_IG39
+       jbe      G_M53443_IG40
        movzx    rcx, word  ptr [r8+0x0E]
-       mov      dword ptr [rsp+0x4C], ecx
+       mov      dword ptr [rsp+0x50], ecx
        mov      dword ptr [rsp+0x3C], edx
        cmp      edx, 2
-       jbe      G_M53443_IG39
+       jbe      G_M53443_IG40
        movzx    rsi, word  ptr [r8+0x10]
        lea      ebx, [rcx+rsi+0x03]
        mov      dword ptr [rsp+0x20], esi
        mov      dword ptr [rsp+0x518], r10d
        mov      ecx, r10d
        mov      rdx, r8
-       mov      r9d, dword ptr [rsp+0x4C]
+       mov      r9d, dword ptr [rsp+0x50]
        xor      r8d, r8d
        call     [<unknown method>]
        mov      esi, eax
-       mov      rdx, gword ptr [rsp+0x28]
-       cmp      word  ptr [rdx+0x0C], 1
-       jne      SHORT G_M53443_IG29
+       mov      rax, gword ptr [rsp+0x28]
+       cmp      word  ptr [rax+0x0C], 1
+       jne      SHORT G_M53443_IG30
        test     esi, esi
        sete     sil
        movzx    rsi, sil
        test     esi, esi
-       je       SHORT G_M53443_IG31
-       jmp      SHORT G_M53443_IG30
-						;; size=113 bbWeight=358.01 PerfScore 10561.34
-G_M53443_IG29:
-       test     esi, esi
-       je       SHORT G_M53443_IG31
-						;; size=4 bbWeight=358.01 PerfScore 447.51
+       je       SHORT G_M53443_IG32
+       jmp      SHORT G_M53443_IG31
+						;; size=111 bbWeight=358.01 PerfScore 10471.83
 G_M53443_IG30:
+       test     esi, esi
+       je       SHORT G_M53443_IG32
+						;; size=4 bbWeight=358.01 PerfScore 447.51
+G_M53443_IG31:
        cmp      dword ptr [rsp+0x3C], ebx
-       jle      SHORT G_M53443_IG31
+       jle      SHORT G_M53443_IG32
        mov      ecx, dword ptr [rsp+0x518]
+       mov      rdx, rax
        mov      r8d, ebx
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        xor      esi, esi
        test     eax, eax
        sete     sil
-						;; size=30 bbWeight=358.01 PerfScore 3132.60
-G_M53443_IG31:
+						;; size=33 bbWeight=358.01 PerfScore 3222.10
+G_M53443_IG32:
        mov      ebx, dword ptr [rsp+0x518]
        mov      ecx, ebx
        and      ecx, 15
@@ -3552,18 +3566,18 @@ G_M53443_IG31:
        mov      edx, 1
        shlx     ecx, edx, ecx
        test     esi, esi
-       je       SHORT G_M53443_IG32
+       je       SHORT G_M53443_IG33
        lea      edx, [rcx+rcx]
        or       ecx, edx
-       mov      dword ptr [rsp+0x50], ecx
-       mov      ecx, dword ptr [rsp+0x50]
+       mov      dword ptr [rsp+0x54], ecx
+       mov      ecx, dword ptr [rsp+0x54]
 						;; size=41 bbWeight=358.01 PerfScore 2327.07
-G_M53443_IG32:
+G_M53443_IG33:
        mov      rax, bword ptr [rsp+0x30]
        mov      r8, gword ptr [rax]
        test     r8, r8
-       jne      SHORT G_M53443_IG33
-       mov      dword ptr [rsp+0x50], ecx
+       jne      SHORT G_M53443_IG34
+       mov      dword ptr [rsp+0x54], ecx
        mov      rcx, qword ptr [rsp+0x40]
        mov      edx, 8
        call     CORINFO_HELP_NEWARR_1_VC
@@ -3573,16 +3587,16 @@ G_M53443_IG32:
        call     <unknown method>
        mov      r8, rax
        test     r8, r8
-       jne      SHORT G_M53443_IG38
-       mov      r8, bword ptr [rsp+0x30]
-       mov      r8, gword ptr [r8]
-       mov      ecx, dword ptr [rsp+0x50]
+       jne      SHORT G_M53443_IG39
+       mov      rax, bword ptr [rsp+0x30]
+       mov      r8, gword ptr [rax]
+       mov      ecx, dword ptr [rsp+0x54]
 						;; size=68 bbWeight=358.01 PerfScore 5549.18
-G_M53443_IG33:
+G_M53443_IG34:
        mov      eax, ebx
        sar      eax, 4
        cmp      eax, dword ptr [r8+0x08]
-       jae      SHORT G_M53443_IG39
+       jae      SHORT G_M53443_IG40
        sar      ebx, 4
        mov      eax, ebx
        lea      rax, bword ptr [r8+4*rax+0x10]
@@ -3590,24 +3604,24 @@ G_M53443_IG33:
        or       dword ptr [rax], ecx
        mov      eax, esi
 						;; size=26 bbWeight=358.01 PerfScore 8144.76
-G_M53443_IG34:
+G_M53443_IG35:
        test     eax, eax
        je       G_M53443_IG17
 						;; size=8 bbWeight=89.50 PerfScore 111.88
-G_M53443_IG35:
+G_M53443_IG36:
        mov      eax, dword ptr [rsp+0x514]
        inc      eax
        cmp      eax, dword ptr [rbp+0x10]
        mov      rbx, gword ptr [rsp+0x660]
        jl       G_M53443_IG21
 						;; size=26 bbWeight=100 PerfScore 625.00
-G_M53443_IG36:
-       mov      rsi, bword ptr [rsp+0x670]
-       mov      r9d, dword ptr [rsp+0x51C]
-       mov      dword ptr [rsi], r9d
-       mov      eax, 1
-						;; size=24 bbWeight=10.50 PerfScore 34.11
 G_M53443_IG37:
+       mov      rsi, bword ptr [rsp+0x670]
+       mov      ebx, dword ptr [rsp+0x51C]
+       mov      dword ptr [rsi], ebx
+       mov      eax, 1
+						;; size=22 bbWeight=10.50 PerfScore 34.11
+G_M53443_IG38:
        add      rsp, 0x618
        pop      rbx
        pop      rsi
@@ -3619,23 +3633,23 @@ G_M53443_IG37:
        pop      rbp
        ret      
 						;; size=20 bbWeight=10.50 PerfScore 55.10
-G_M53443_IG38:
-       mov      ecx, dword ptr [rsp+0x50]
-       jmp      SHORT G_M53443_IG33
-						;; size=6 bbWeight=179.01 PerfScore 537.02
 G_M53443_IG39:
+       mov      ecx, dword ptr [rsp+0x54]
+       jmp      SHORT G_M53443_IG34
+						;; size=6 bbWeight=179.01 PerfScore 537.02
+G_M53443_IG40:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG40:
+G_M53443_IG41:
        call     [System.ThrowHelper:ThrowArgumentOutOfRange_IndexMustBeLessException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG41:
+G_M53443_IG42:
        mov      rsi, bword ptr [rsp+0x670]
        mov      dword ptr [rsi], r15d
        xor      eax, eax
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M53443_IG42:
+G_M53443_IG43:
        add      rsp, 0x618
        pop      rbx
        pop      rsi
@@ -3648,7 +3662,7 @@ G_M53443_IG42:
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1506, prolog size 95, PerfScore 2867854.14, instruction count 377, allocated bytes for code 1506 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
+; Total bytes of code 1507, prolog size 95, PerfScore 2882030.14, instruction count 379, allocated bytes for code 1507 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Instrumented Tier0)
@@ -5047,13 +5061,13 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 177186.6
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 175260.4
 ; 42 inlinees with PGO data; 144 single block inlinees; 7 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T22] (  3,  3.78)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
-;  V01 arg1         [V01,T15] (  5,  9   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 arg2         [V02,T26] (  4,  2.20)   byref  ->  rsi         single-def
+;  V00 this         [V00,T21] (  3,  3.78)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
+;  V01 arg1         [V01,T14] (  5,  9   )   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg2         [V02,T25] (  4,  2.21)   byref  ->  rsi         single-def
 ;* V03 arg3         [V03    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;* V04 loc0         [V04    ] (  0,  0   )     int  ->  zero-ref   
 ;* V05 loc1         [V05    ] (  0,  0   )     int  ->  zero-ref   
@@ -5062,15 +5076,15 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
 ;* V09 loc5         [V09    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[XS] addr-exposed <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V10 loc6         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <ushort[]>
-;  V11 loc7         [V11,T33] (  1,  1   )  struct (16) [rsp+0x588]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V11 loc7         [V11,T32] (  1,  1   )  struct (16) [rsp+0x598]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V12 loc8         [V12    ] (  0,  0   )     int  ->  zero-ref   
 ;* V13 loc9         [V13    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V14 loc10        [V14    ] (  0,  0   )     int  ->  zero-ref   
 ;* V15 loc11        [V15    ] (  0,  0   )     int  ->  zero-ref   
 ;* V16 loc12        [V16    ] (  0,  0   )     int  ->  zero-ref   
-;  V17 loc13        [V17,T21] (  4,  6.97)     ref  ->  rbp         class-hnd <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
-;  V18 loc14        [V18,T29] (  2,  2   )  struct (32) [rsp+0x540]  do-not-enreg[SF] tier0-frame <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
-;  V19 loc15        [V19,T11] (  2,100.20)     int  ->  [rsp+0x53C]  tier0-frame
+;  V17 loc13        [V17,T20] (  4,  6.99)     ref  ->  rbp         class-hnd <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
+;  V18 loc14        [V18,T28] (  2,  2   )  struct (32) [rsp+0x550]  do-not-enreg[SF] tier0-frame <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
+;  V19 loc15        [V19,T11] (  2,100.21)     int  ->  [rsp+0x54C]  tier0-frame
 ;* V20 loc16        [V20    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <ushort[]>
 ;* V21 loc17        [V21    ] (  0,  0   )     int  ->  zero-ref   
 ;* V22 loc18        [V22    ] (  0,  0   )     int  ->  zero-ref   
@@ -5079,16 +5093,16 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;* V25 loc21        [V25    ] (  0,  0   )     int  ->  zero-ref   
 ;* V26 loc22        [V26    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V27 loc23        [V27    ] (  0,  0   )  ushort  ->  zero-ref   
-;  V28 loc24        [V28,T13] (  2,100.00)   byref  ->  rdi        
-;  V29 loc25        [V29,T01] (  7,402.19)     int  ->  [rsp+0x4DC]  tier0-frame
-;  V30 loc26        [V30,T03] ( 12,305.33)  ushort  ->  [rsp+0x4D8]  tier0-frame
-;  V31 loc27        [V31,T14] (  8, 14.49)     int  ->  [rsp+0x4D4]  tier0-frame
+;  V28 loc24        [V28,T12] (  2,100.00)   byref  ->  rdi        
+;  V29 loc25        [V29,T01] (  7,402.19)     int  ->  [rsp+0x4EC]  tier0-frame
+;  V30 loc26        [V30,T03] ( 12,305.35)  ushort  ->  [rsp+0x4E8]  tier0-frame
+;* V31 loc27        [V31,T30] (  0,  0   )     int  ->  zero-ref   
 ;* V32 loc28        [V32    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V33 loc29        [V33    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.RegexNode>
 ;* V34 loc30        [V34    ] (  0,  0   )  struct (24) zero-ref    <System.ValueTuple`4[ushort,System.String,int,ushort[]]>
 ;* V35 loc31        [V35    ] (  0,  0   )     int  ->  zero-ref   
-;  V36 loc32        [V36,T34] (  1,  1   )  struct (40) [rsp+0x460]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
-;  V37 loc33        [V37,T35] (  1,  1   )  struct (16) [rsp+0x450]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V36 loc32        [V36,T33] (  1,  1   )  struct (40) [rsp+0x470]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
+;  V37 loc33        [V37,T34] (  1,  1   )  struct (16) [rsp+0x460]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V38 loc34        [V38    ] (  0,  0   )     int  ->  zero-ref   
 ;* V39 loc35        [V39    ] (  0,  0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -5136,7 +5150,7 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;* V82 tmp42        [V82    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V83 tmp43        [V83    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;  V84 tmp44        [V84,T00] (  3,600.00)     int  ->  rcx         "Span.get_Item index"
-;  V85 tmp45        [V85,T18] (  3, 10.66)     int  ->  rcx         "Span.get_Item index"
+;  V85 tmp45        [V85,T17] (  3, 10.69)     int  ->  rcx         "Span.get_Item index"
 ;* V86 tmp46        [V86    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V87 tmp47        [V87    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V88 tmp48        [V88    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -5366,19 +5380,19 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;* V312 tmp272      [V312    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V313 tmp273      [V313    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V314 tmp274      [V314    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V315 tmp275      [V315,T12] (  3,100.00)   ubyte  ->  rax         "Inline return value spill temp"
+;  V315 tmp275      [V315,T35] (  3,  0.01)   ubyte  ->  rax         "Inline return value spill temp"
 ;  V316 tmp276      [V316,T02] (  4,400.00)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V317 tmp277      [V317    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;  V318 tmp278      [V318,T04] (  3,300.00)     int  ->  rdx         "Inline stloc first use temp"
 ;  V319 tmp279      [V319,T05] (  3,299.99)     int  ->  rcx         "Inline stloc first use temp"
 ;  V320 tmp280      [V320,T06] (  3,299.99)     int  ->  rdx         "Inline stloc first use temp"
-;  V321 tmp281      [V321,T31] (  3,  1.78)   ubyte  ->  rax         "Inline return value spill temp"
-;  V322 tmp282      [V322,T20] (  3,  7.11)   byref  ->  rax         "Inlining Arg"
-;  V323 tmp283      [V323,T19] (  4,  7.11)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V321 tmp281      [V321,T36] (  3,  0.00)   ubyte  ->  rax         "Inline return value spill temp"
+;  V322 tmp282      [V322,T19] (  3,  7.12)   byref  ->  rax         "Inlining Arg"
+;  V323 tmp283      [V323,T18] (  4,  7.12)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V324 tmp284      [V324    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V325 tmp285      [V325,T23] (  3,  5.33)     int  ->  rdx         "Inline stloc first use temp"
-;  V326 tmp286      [V326,T24] (  3,  5.33)     int  ->  rcx         "Inline stloc first use temp"
-;  V327 tmp287      [V327,T25] (  3,  5.33)     int  ->  rdx         "Inline stloc first use temp"
+;  V325 tmp285      [V325,T22] (  3,  5.34)     int  ->  rdx         "Inline stloc first use temp"
+;  V326 tmp286      [V326,T23] (  3,  5.34)     int  ->  rcx         "Inline stloc first use temp"
+;  V327 tmp287      [V327,T24] (  3,  5.34)     int  ->  rdx         "Inline stloc first use temp"
 ;* V328 tmp288      [V328    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V329 tmp289      [V329    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V330 tmp290      [V330    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
@@ -5654,66 +5668,67 @@ RWD00  	dd	G_M53443_IG12 - G_M53443_IG02
 ;* V600 tmp560      [V600    ] (  0,  0   )     int  ->  zero-ref    "field V406._length (fldOffset=0x8)" P-INDEP
 ;  V601 tmp561      [V601,T09] (  3,102.78)   byref  ->  r14         single-def "V01.[000..008)"
 ;  V602 tmp562      [V602,T08] (  4,102.78)     int  ->  r15         "V01.[008..012)"
-;  V603 tmp563      [V603,T32] (  3,  1.00)     ref  ->  r13         single-def "V18.[000..008)"
+;  V603 tmp563      [V603,T31] (  3,  1.00)     ref  ->  r13         single-def "V18.[000..008)"
 ;  V604 tmp564      [V604,T10] (  2,101.00)     int  ->  r12         "V18.[016..020)"
-;  V605 tmp565      [V605,T30] (  3,  1.78)     ref  ->  [rsp+0x20]  spill-single-def "V32.[000..008)"
-;  V606 tmp566      [V606,T27] (  2,  3.55)     int  ->  rcx         "V32.[016..020)"
+;  V605 tmp565      [V605,T29] (  3,  1.78)     ref  ->  [rsp+0x28]  spill-single-def "V32.[000..008)"
+;  V606 tmp566      [V606,T26] (  2,  3.56)     int  ->  rcx         "V32.[016..020)"
 ;* V607 tmp567      [V607    ] (  0,  0   )     ref  ->  zero-ref    "V43.[000..008)"
 ;* V608 tmp568      [V608    ] (  0,  0   )     ref  ->  zero-ref    "V43.[008..016)"
 ;* V609 tmp569      [V609    ] (  0,  0   )     ref  ->  zero-ref    "V43.[016..024)"
 ;* V610 tmp570      [V610    ] (  0,  0   )     int  ->  zero-ref    "V43.[024..028)"
 ;* V611 tmp571      [V611    ] (  0,  0   )  ushort  ->  zero-ref    "V43.[028..030)"
 ;* V612 tmp572      [V612    ] (  0,  0   )   byref  ->  zero-ref    "Spilling address for field-by-field copy"
-;  V613 tmp573      [V613,T16] (  3, 10.66)   byref  ->  rcx         "Spilling address for field-by-field copy"
+;  V613 tmp573      [V613,T15] (  3, 10.69)   byref  ->  rcx         "Spilling address for field-by-field copy"
 ;* V614 tmp574      [V614    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V615 tmp575      [V615    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;* V616 tmp576      [V616    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;* V617 tmp577      [V617    ] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;* V618 tmp578      [V618    ] (  0,  0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Span`1[ushort]>
-;  V619 tmp579      [V619,T17] (  3, 10.66)     ref  ->  rcx         "arr expr"
+;  V619 tmp579      [V619,T16] (  3, 10.69)     ref  ->  rcx         "arr expr"
 ;  V620 cse0        [V620,T07] (  2,200.00)     int  ->   r8         "CSE #01: aggressive"
-;  V621 cse1        [V621,T28] (  2,  3.55)     int  ->   r8         "CSE #02: moderate"
+;  V621 cse1        [V621,T27] (  2,  3.56)     int  ->   r8         "CSE #02: moderate"
+;  V622 rat0        [V622,T13] (  8, 14.53)    long  ->  [rsp+0x30]  "Widened IV V31"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 56
 
 G_M53443_IG01:
-       sub      rsp, 104
-       mov      qword ptr [rsp+0x608], r15
-       mov      qword ptr [rsp+0x600], r14
-       mov      qword ptr [rsp+0x5F8], r13
-       mov      qword ptr [rsp+0x5F0], r12
-       mov      qword ptr [rsp+0x5E8], rdi
-       mov      qword ptr [rsp+0x5E0], rsi
-       mov      qword ptr [rsp+0x5D8], rbx
-       mov      rbx, gword ptr [rsp+0x620]
-       mov      rdx, bword ptr [rsp+0x628]
-       mov      rsi, bword ptr [rsp+0x630]
-       mov      rbp, gword ptr [rsp+0x560]
-       mov      rdi, bword ptr [rsp+0x4E0]
+       sub      rsp, 120
+       mov      qword ptr [rsp+0x618], r15
+       mov      qword ptr [rsp+0x610], r14
+       mov      qword ptr [rsp+0x608], r13
+       mov      qword ptr [rsp+0x600], r12
+       mov      qword ptr [rsp+0x5F8], rdi
+       mov      qword ptr [rsp+0x5F0], rsi
+       mov      qword ptr [rsp+0x5E8], rbx
+       mov      rbx, gword ptr [rsp+0x630]
+       mov      rdx, bword ptr [rsp+0x638]
+       mov      rsi, bword ptr [rsp+0x640]
+       mov      rbp, gword ptr [rsp+0x570]
+       mov      rdi, bword ptr [rsp+0x4F0]
 						;; size=100 bbWeight=1 PerfScore 17.25
 G_M53443_IG02:
        mov      r14, bword ptr [rdx]
        mov      r15d, dword ptr [rdx+0x08]
-       mov      r13, gword ptr [rsp+0x540]
-       mov      r12d, dword ptr [rsp+0x550]
-       mov      eax, dword ptr [rsp+0x4DC]
-       cmp      eax, dword ptr [rsp+0x53C]
-       jg       G_M53443_IG21
+       mov      r13, gword ptr [rsp+0x550]
+       mov      r12d, dword ptr [rsp+0x560]
+       mov      eax, dword ptr [rsp+0x4EC]
+       cmp      eax, dword ptr [rsp+0x54C]
+       jg       G_M53443_IG23
 						;; size=43 bbWeight=1 PerfScore 10.00
 G_M53443_IG03:
-       mov      dword ptr [rsp+0x4DC], eax
+       mov      dword ptr [rsp+0x4EC], eax
        lea      ecx, [rax+r12]
        cmp      ecx, r15d
-       jae      G_M53443_IG17
+       jae      G_M53443_IG19
        movzx    r9, word  ptr [r14+2*rcx]
        mov      rcx, gword ptr [rdi]
        test     rcx, rcx
-       je       SHORT G_M53443_IG05
+       je       SHORT G_M53443_IG06
        mov      edx, r9d
        sar      edx, 4
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, edx
-       jbe      SHORT G_M53443_IG05
+       jbe      SHORT G_M53443_IG06
 						;; size=48 bbWeight=100.00 PerfScore 1200.00
 G_M53443_IG04:
        mov      edx, edx
@@ -5724,70 +5739,64 @@ G_M53443_IG04:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG05
+       je       SHORT G_M53443_IG06
        add      edx, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG07
-       jmp      SHORT G_M53443_IG08
-						;; size=37 bbWeight=100.00 PerfScore 849.98
+       je       G_M53443_IG16
+						;; size=39 bbWeight=100.00 PerfScore 649.98
 G_M53443_IG05:
+       jmp      SHORT G_M53443_IG08
+						;; size=2 bbWeight=1.44 PerfScore 2.89
+G_M53443_IG06:
        cmp      r9d, 128
-       jl       G_M53443_IG18
+       jl       G_M53443_IG20
        mov      ecx, r9d
        mov      rdx, r13
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
 						;; size=28 bbWeight=0.00 PerfScore 0.01
-G_M53443_IG06:
-       test     eax, eax
-       jne      SHORT G_M53443_IG08
-						;; size=4 bbWeight=100.00 PerfScore 125.00
 G_M53443_IG07:
-       mov      r9d, dword ptr [rsp+0x4DC]
-       inc      r9d
-       cmp      r9d, dword ptr [rsp+0x53C]
-       jg       G_M53443_IG21
-       mov      eax, r9d
-       jmp      G_M53443_IG03
-						;; size=33 bbWeight=100.00 PerfScore 650.00
+       test     eax, eax
+       je       G_M53443_IG16
+						;; size=8 bbWeight=0.00 PerfScore 0.00
 G_M53443_IG08:
        mov      eax, 1
        cmp      dword ptr [rbp+0x10], 1
-       jle      G_M53443_IG15
-						;; size=15 bbWeight=1.44 PerfScore 6.12
+       jle      G_M53443_IG17
+						;; size=15 bbWeight=1.44 PerfScore 6.13
 G_M53443_IG09:
        cmp      eax, dword ptr [rbp+0x10]
-       jae      G_M53443_IG19
+       jae      G_M53443_IG22
        mov      rcx, gword ptr [rbp+0x08]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M53443_IG17
-       mov      edx, eax
+       jae      G_M53443_IG19
+       mov      rdx, rax
        shl      rdx, 5
        lea      rcx, bword ptr [rcx+rdx+0x10]
        mov      r10, gword ptr [rcx]
-       mov      gword ptr [rsp+0x20], r10
+       mov      gword ptr [rsp+0x28], r10
        mov      ecx, dword ptr [rcx+0x10]
-       mov      r9d, dword ptr [rsp+0x4DC]
+       mov      r9d, dword ptr [rsp+0x4EC]
        add      ecx, r9d
        cmp      ecx, r15d
-       jae      G_M53443_IG17
+       jae      G_M53443_IG19
        movzx    rcx, word  ptr [r14+2*rcx]
-       mov      dword ptr [rsp+0x4D8], ecx
+       mov      dword ptr [rsp+0x4E8], ecx
        mov      rcx, gword ptr [rbx+0x08]
-       mov      dword ptr [rsp+0x4D4], eax
+       mov      qword ptr [rsp+0x30], rax
        movsxd   rdx, eax
        mov      r8, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_LDELEMA_REF
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
        je       SHORT G_M53443_IG12
-       mov      r10d, dword ptr [rsp+0x4D8]
+       mov      r10d, dword ptr [rsp+0x4E8]
        mov      edx, r10d
        sar      edx, 4
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, edx
        jbe      SHORT G_M53443_IG11
-						;; size=136 bbWeight=1.78 PerfScore 62.20
+						;; size=135 bbWeight=1.78 PerfScore 62.33
 G_M53443_IG10:
        mov      edx, edx
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
@@ -5797,42 +5806,57 @@ G_M53443_IG10:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       mov      dword ptr [rsp+0x4D8], r10d
+       mov      dword ptr [rsp+0x4E8], r10d
        je       SHORT G_M53443_IG12
        add      edx, edx
        test     ecx, edx
-       je       G_M53443_IG07
+       je       SHORT G_M53443_IG16
+       mov      r9, qword ptr [rsp+0x30]
        jmp      SHORT G_M53443_IG14
-						;; size=49 bbWeight=1.78 PerfScore 16.88
+						;; size=50 bbWeight=1.78 PerfScore 18.70
 G_M53443_IG11:
-       mov      dword ptr [rsp+0x4D8], r10d
+       mov      dword ptr [rsp+0x4E8], r10d
 						;; size=8 bbWeight=0.89 PerfScore 0.89
 G_M53443_IG12:
-       mov      r10d, dword ptr [rsp+0x4D8]
+       mov      r10d, dword ptr [rsp+0x4E8]
        cmp      r10d, 128
-       jl       SHORT G_M53443_IG20
+       jl       G_M53443_IG21
        mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x20]
+       mov      rdx, gword ptr [rsp+0x28]
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
-						;; size=34 bbWeight=0.00 PerfScore 0.00
+						;; size=38 bbWeight=0.00 PerfScore 0.00
 G_M53443_IG13:
        test     eax, eax
-       je       G_M53443_IG07
-						;; size=8 bbWeight=1.78 PerfScore 2.22
+       je       SHORT G_M53443_IG16
+						;; size=4 bbWeight=0.00 PerfScore 0.00
 G_M53443_IG14:
-       mov      eax, dword ptr [rsp+0x4D4]
+       mov      rax, qword ptr [rsp+0x30]
        inc      eax
-       cmp      eax, dword ptr [rbp+0x10]
+       mov      r10, rax
+       cmp      r10d, dword ptr [rbp+0x10]
+       mov      rax, r10
        jl       G_M53443_IG09
-						;; size=18 bbWeight=1.98 PerfScore 10.40
+						;; size=23 bbWeight=1.99 PerfScore 11.42
 G_M53443_IG15:
-       mov      r9d, dword ptr [rsp+0x4DC]
-       mov      dword ptr [rsi], r9d
-       mov      eax, 1
-						;; size=16 bbWeight=0.20 PerfScore 0.46
+       jmp      SHORT G_M53443_IG17
+						;; size=2 bbWeight=0.21 PerfScore 0.41
 G_M53443_IG16:
-       add      rsp, 0x5D8
+       mov      eax, dword ptr [rsp+0x4EC]
+       inc      eax
+       mov      r10d, dword ptr [rsp+0x54C]
+       cmp      eax, r10d
+       jg       SHORT G_M53443_IG23
+       mov      dword ptr [rsp+0x54C], r10d
+       jmp      G_M53443_IG03
+						;; size=35 bbWeight=100.00 PerfScore 650.00
+G_M53443_IG17:
+       mov      eax, dword ptr [rsp+0x4EC]
+       mov      dword ptr [rsi], eax
+       mov      eax, 1
+						;; size=14 bbWeight=0.21 PerfScore 0.46
+G_M53443_IG18:
+       add      rsp, 0x5E8
        pop      rbx
        pop      rsi
        pop      rdi
@@ -5842,34 +5866,34 @@ G_M53443_IG16:
        pop      r15
        pop      rbp
        ret      
-						;; size=20 bbWeight=0.20 PerfScore 1.07
-G_M53443_IG17:
+						;; size=20 bbWeight=0.21 PerfScore 1.08
+G_M53443_IG19:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG18:
+G_M53443_IG20:
        mov      ecx, r9d
        mov      rdx, r13
        mov      r8, rdi
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
-       jmp      G_M53443_IG06
+       jmp      G_M53443_IG07
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M53443_IG19:
+G_M53443_IG21:
+       mov      ecx, r10d
+       mov      rdx, gword ptr [rsp+0x28]
+       mov      r8, rax
+       call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
+       jmp      G_M53443_IG13
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M53443_IG22:
        call     [System.ThrowHelper:ThrowArgumentOutOfRange_IndexMustBeLessException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG20:
-       mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x20]
-       mov      r8, rax
-       call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
-       jmp      SHORT G_M53443_IG13
-						;; size=19 bbWeight=0 PerfScore 0.00
-G_M53443_IG21:
+G_M53443_IG23:
        mov      dword ptr [rsi], r15d
        xor      eax, eax
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG22:
-       add      rsp, 0x5D8
+G_M53443_IG24:
+       add      rsp, 0x5E8
        pop      rbx
        pop      rsi
        pop      rdi
@@ -5881,7 +5905,7 @@ G_M53443_IG22:
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 673, prolog size 100, PerfScore 2952.49, instruction count 160, allocated bytes for code 673 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
+; Total bytes of code 691, prolog size 100, PerfScore 2631.57, instruction count 165, allocated bytes for code 691 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1)
@@ -5891,81 +5915,81 @@ G_M53443_IG22:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 37872
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 37512
 ; 42 inlinees with PGO data; 144 single block inlinees; 7 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T25] ( 26,  17.07)     ref  ->  [rsp+0x150]  this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
-;  V01 arg1         [V01,T29] (  4,   8   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 arg2         [V02,T34] ( 43,   5   )   byref  ->  rsi         single-def
-;  V03 arg3         [V03,T36] (  3,   2   )     int  ->  rdi         single-def
-;  V04 loc0         [V04,T130] (  3,   0   )     int  ->  rdx        
+;  V00 this         [V00,T24] ( 26,  16.98)     ref  ->  [rsp+0x150]  this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
+;  V01 arg1         [V01,T28] (  4,   8   )   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg2         [V02,T32] ( 43,   5   )   byref  ->  rsi         single-def
+;  V03 arg3         [V03,T35] (  3,   2   )     int  ->  rdi         single-def
+;  V04 loc0         [V04,T131] (  3,   0   )     int  ->  rdx        
 ;* V05 loc1         [V05    ] (  0,   0   )     int  ->  zero-ref   
 ;* V06 loc2         [V06    ] (  0,   0   )     int  ->  zero-ref   
-;  V07 loc3         [V07,T131] (  3,   0   )     int  ->  rax        
-;  V08 loc4         [V08,T132] (  3,   0   )     int  ->  rax        
+;  V07 loc3         [V07,T132] (  3,   0   )     int  ->  rax        
+;  V08 loc4         [V08,T133] (  3,   0   )     int  ->  rax        
 ;  V09 loc5         [V09    ] (  4,   0   )  struct (32) [rsp+0xE8]  do-not-enreg[XS] must-init addr-exposed <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
-;  V10 loc6         [V10,T55] (  7,   0   )     ref  ->  r12         class-hnd single-def <ushort[]>
+;  V10 loc6         [V10,T56] (  7,   0   )     ref  ->  r12         class-hnd single-def <ushort[]>
 ;* V11 loc7         [V11    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
 ;* V12 loc8         [V12    ] (  0,   0   )     int  ->  zero-ref   
-;  V13 loc9         [V13,T116] (  3,   0   )   byref  ->  rbx         single-def
-;  V14 loc10        [V14,T56] (  7,   0   )     int  ->  rdi        
+;  V13 loc9         [V13,T117] (  3,   0   )   byref  ->  rbx         single-def
+;  V14 loc10        [V14,T57] (  7,   0   )     int  ->  rdi        
 ;* V15 loc11        [V15    ] (  0,   0   )     int  ->  zero-ref   
-;  V16 loc12        [V16,T133] (  3,   0   )     int  ->  rax        
-;  V17 loc13        [V17,T18] ( 10,  37.61)     ref  ->  r13         class-hnd single-def <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
+;  V16 loc12        [V16,T134] (  3,   0   )     int  ->  rax        
+;  V17 loc13        [V17,T17] ( 10,  37.34)     ref  ->  r13         class-hnd single-def <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
 ;* V18 loc14        [V18    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
-;  V19 loc15        [V19,T10] (  5, 489.03)     int  ->  [rsp+0xE4]  spill-single-def
+;  V19 loc15        [V19,T10] (  5, 486.91)     int  ->  [rsp+0xE4]  spill-single-def
 ;* V20 loc16        [V20    ] (  0,   0   )     ref  ->  zero-ref    class-hnd single-def <ushort[]>
-;  V21 loc17        [V21,T50] (  9,   0   )     int  ->  rdi        
-;  V22 loc18        [V22,T70] (  5,   0   )     int  ->  rdi        
+;  V21 loc17        [V21,T51] (  9,   0   )     int  ->  rdi        
+;  V22 loc18        [V22,T71] (  5,   0   )     int  ->  rdi        
 ;* V23 loc19        [V23    ] (  0,   0   )  struct (16) zero-ref    <System.ReadOnlySpan`1[ushort]>
 ;* V24 loc20        [V24    ] (  0,   0   )     int  ->  zero-ref   
-;  V25 loc21        [V25,T51] (  8,   0   )     int  ->  [rsp+0xE0] 
+;* V25 loc21        [V25,T224] (  0,   0   )     int  ->  zero-ref   
 ;* V26 loc22        [V26    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
-;  V27 loc23        [V27,T59] (  6,   0   )  ushort  ->  [rsp+0xDC]  spill-single-def
-;  V28 loc24        [V28,T12] (  3, 487.83)   byref  ->  [rsp+0x60]  spill-single-def
-;  V29 loc25        [V29,T01] (  8,1958.97)     int  ->  [rsp+0xD8] 
-;  V30 loc26        [V30,T04] ( 12,1486.47)  ushort  ->  [rsp+0xD4] 
-;  V31 loc27        [V31,T14] (  8,  70.65)     int  ->  [rsp+0xD0] 
+;  V27 loc23        [V27,T60] (  6,   0   )  ushort  ->  [rsp+0xE0]  spill-single-def
+;  V28 loc24        [V28,T12] (  3, 485.72)   byref  ->  [rsp+0x58]  spill-single-def
+;  V29 loc25        [V29,T01] (  8,1950.47)     int  ->  [rsp+0xDC] 
+;  V30 loc26        [V30,T04] ( 12,1479.96)  ushort  ->  [rsp+0xD8] 
+;* V31 loc27        [V31,T33] (  0,   0   )     int  ->  zero-ref   
 ;* V32 loc28        [V32    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
-;  V33 loc29        [V33,T117] (  3,   0   )     ref  ->  rdi         class-hnd single-def <System.Text.RegularExpressions.RegexNode>
+;  V33 loc29        [V33,T118] (  3,   0   )     ref  ->  rdi         class-hnd single-def <System.Text.RegularExpressions.RegexNode>
 ;* V34 loc30        [V34    ] (  0,   0   )  struct (24) zero-ref    <System.ValueTuple`4[ushort,System.String,int,ushort[]]>
-;  V35 loc31        [V35,T57] (  7,   0   )     int  ->  [rsp+0xCC] 
+;  V35 loc31        [V35,T58] (  7,   0   )     int  ->  [rsp+0xD4] 
 ;* V36 loc32        [V36    ] (  0,   0   )  struct (40) zero-ref    do-not-enreg[S] ld-addr-op <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
 ;* V37 loc33        [V37    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V38 loc34        [V38,T71] (  5,   0   )     int  ->  [rsp+0xC8] 
-;  V39 loc35        [V39,T60] (  6,   0   )     int  ->  [rsp+0xC4] 
+;  V38 loc34        [V38,T72] (  5,   0   )     int  ->  [rsp+0xD0] 
+;  V39 loc35        [V39,T61] (  6,   0   )     int  ->  [rsp+0xCC] 
 ;  V40 OutArgs      [V40    ] (  1,   1   )  struct (56) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V41 tmp1         [V41    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V42 tmp2         [V42    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V43 tmp3         [V43    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[SF] "dup spill" <System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]>
 ;* V44 tmp4         [V44    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V45 tmp5         [V45    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V46 tmp6         [V46,T80] (  4,   0   )     int  ->  rax        
-;  V47 tmp7         [V47,T81] (  4,   0   )     int  ->  [rsp+0xC0]  spill-single-def "dup spill"
+;  V46 tmp6         [V46,T81] (  4,   0   )     int  ->  rax        
+;  V47 tmp7         [V47,T82] (  4,   0   )     int  ->  [rsp+0xC8]  spill-single-def "dup spill"
 ;* V48 tmp8         [V48    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V49 tmp9         [V49    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V50 tmp10        [V50    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[ushort]>
-;  V51 tmp11        [V51    ] ( 20,   0   )  struct (16) [rsp+0xB0]  do-not-enreg[HS] must-init hidden-struct-arg "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
+;  V51 tmp11        [V51    ] ( 20,   0   )  struct (16) [rsp+0xB8]  do-not-enreg[HS] must-init hidden-struct-arg "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V52 tmp12        [V52    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V53 tmp13        [V53,T00] (  3,2920.96)     int  ->  rcx         "Span.get_Item index"
-;  V54 tmp14        [V54,T17] (  3,  51.97)     int  ->  rcx         "Span.get_Item index"
+;  V53 tmp13        [V53,T00] (  3,2908.32)     int  ->  rcx         "Span.get_Item index"
+;  V54 tmp14        [V54,T16] (  3,  51.58)     int  ->  rcx         "Span.get_Item index"
 ;* V55 tmp15        [V55    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V56 tmp16        [V56,T82] (  4,   0   )     int  ->  rax        
-;  V57 tmp17        [V57,T134] (  3,   0   )     int  ->  rcx         "Span.get_Item index"
+;  V56 tmp16        [V56,T83] (  4,   0   )     int  ->  rax        
+;  V57 tmp17        [V57,T135] (  3,   0   )     int  ->  rcx         "Span.get_Item index"
 ;* V58 tmp18        [V58    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V59 tmp19        [V59,T189] (  2,   0   )     int  ->  rcx         "impAppendStmt"
+;  V59 tmp19        [V59,T190] (  2,   0   )     int  ->  rcx         "impAppendStmt"
 ;* V60 tmp20        [V60    ] (  0,   0   )  struct (16) zero-ref    "location for address-of(RValue)" <System.ValueTuple`3[ushort,System.String,int]>
 ;* V61 tmp21        [V61    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V62 tmp22        [V62    ] (  0,   0   )  struct (16) zero-ref    "location for address-of(RValue)" <System.ValueTuple`3[ushort,System.String,int]>
 ;* V63 tmp23        [V63    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V64 tmp24        [V64,T190] (  2,   0   )     int  ->  rdx         "impAppendStmt"
+;  V64 tmp24        [V64,T191] (  2,   0   )     int  ->  rdx         "impAppendStmt"
 ;* V65 tmp25        [V65    ] (  0,   0   )  struct (16) zero-ref    "location for address-of(RValue)" <System.ValueTuple`3[ushort,System.String,int]>
 ;* V66 tmp26        [V66    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V67 tmp27        [V67    ] (  0,   0   )  struct (16) zero-ref    "location for address-of(RValue)" <System.ValueTuple`3[ushort,System.String,int]>
 ;* V68 tmp28        [V68    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V69 tmp29        [V69    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
-;  V70 tmp30        [V70,T83] (  4,   0   )     int  ->  rax        
+;  V70 tmp30        [V70,T84] (  4,   0   )     int  ->  rax        
 ;* V71 tmp31        [V71    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
 ;* V72 tmp32        [V72    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V73 tmp33        [V73    ] (  0,   0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ushort]>
@@ -5981,32 +6005,32 @@ G_M53443_IG22:
 ;* V83 tmp43        [V83    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V84 tmp44        [V84    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V85 tmp45        [V85    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V86 tmp46        [V86,T84] (  4,   0   )     int  ->  rdx         "Inlining Arg"
+;  V86 tmp46        [V86,T85] (  4,   0   )     int  ->  rdx         "Inlining Arg"
 ;* V87 tmp47        [V87    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V88 tmp48        [V88,T165] (  2,   0   )   byref  ->  rcx         single-def "Inlining Arg"
-;  V89 tmp49        [V89,T191] (  2,   0   )     int  ->   r8         "Inlining Arg"
+;  V88 tmp48        [V88,T166] (  2,   0   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V89 tmp49        [V89,T192] (  2,   0   )     int  ->   r8         "Inlining Arg"
 ;* V90 tmp50        [V90    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V91 tmp51        [V91    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;* V92 tmp52        [V92,T223] (  0,   0   )  ushort  ->  zero-ref    ld-addr-op "Inlining Arg"
+;* V92 tmp52        [V92,T225] (  0,   0   )  ushort  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V93 tmp53        [V93    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V94 tmp54        [V94    ] (  0,   0   )   byref  ->  zero-ref    single-def "Inlining Arg"
-;* V95 tmp55        [V95,T224] (  0,   0   )   short  ->  zero-ref    "Inlining Arg"
+;* V95 tmp55        [V95,T226] (  0,   0   )   short  ->  zero-ref    "Inlining Arg"
 ;* V96 tmp56        [V96    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V97 tmp57        [V97,T135] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V97 tmp57        [V97,T136] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V98 tmp58        [V98    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V99 tmp59        [V99    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V100 tmp60       [V100    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V101 tmp61       [V101    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V102 tmp62       [V102,T85] (  4,   0   )     int  ->  rcx         "Inlining Arg"
+;  V102 tmp62       [V102,T86] (  4,   0   )     int  ->  rcx         "Inlining Arg"
 ;* V103 tmp63       [V103    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V104 tmp64       [V104,T166] (  2,   0   )   byref  ->  rdx         single-def "Inlining Arg"
-;  V105 tmp65       [V105,T192] (  2,   0   )     int  ->   r8         "Inlining Arg"
+;  V104 tmp64       [V104,T167] (  2,   0   )   byref  ->  rdx         single-def "Inlining Arg"
+;  V105 tmp65       [V105,T193] (  2,   0   )     int  ->   r8         "Inlining Arg"
 ;* V106 tmp66       [V106    ] (  0,   0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
-;  V107 tmp67       [V107,T72] (  4,   0   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V107 tmp67       [V107,T73] (  4,   0   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V108 tmp68       [V108    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V109 tmp69       [V109    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V110 tmp70       [V110,T167] (  2,   0   )   byref  ->   r9         single-def "Inlining Arg"
-;  V111 tmp71       [V111,T193] (  2,   0   )     int  ->  rax         "Inlining Arg"
+;  V110 tmp70       [V110,T168] (  2,   0   )   byref  ->   r9         single-def "Inlining Arg"
+;  V111 tmp71       [V111,T194] (  2,   0   )     int  ->  rax         "Inlining Arg"
 ;* V112 tmp72       [V112    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V113 tmp73       [V113    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V114 tmp74       [V114    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
@@ -6018,20 +6042,20 @@ G_M53443_IG22:
 ;* V120 tmp80       [V120    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V121 tmp81       [V121    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V122 tmp82       [V122    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V123 tmp83       [V123,T86] (  4,   0   )     int  ->  rcx         "Inlining Arg"
+;  V123 tmp83       [V123,T87] (  4,   0   )     int  ->  rcx         "Inlining Arg"
 ;* V124 tmp84       [V124    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V125 tmp85       [V125,T168] (  2,   0   )   byref  ->  rdx         single-def "Inlining Arg"
-;  V126 tmp86       [V126,T194] (  2,   0   )     int  ->   r8         "Inlining Arg"
+;  V125 tmp85       [V125,T169] (  2,   0   )   byref  ->  rdx         single-def "Inlining Arg"
+;  V126 tmp86       [V126,T195] (  2,   0   )     int  ->   r8         "Inlining Arg"
 ;* V127 tmp87       [V127    ] (  0,   0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
-;  V128 tmp88       [V128,T73] (  4,   0   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V128 tmp88       [V128,T74] (  4,   0   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V129 tmp89       [V129    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V130 tmp90       [V130    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V131 tmp91       [V131,T169] (  2,   0   )   byref  ->  rax         single-def "Inlining Arg"
-;  V132 tmp92       [V132,T195] (  2,   0   )     int  ->  r10         "Inlining Arg"
-;  V133 tmp93       [V133,T87] (  4,   0   )     int  ->  rcx         "Inlining Arg"
+;  V131 tmp91       [V131,T170] (  2,   0   )   byref  ->  rax         single-def "Inlining Arg"
+;  V132 tmp92       [V132,T196] (  2,   0   )     int  ->  r10         "Inlining Arg"
+;  V133 tmp93       [V133,T88] (  4,   0   )     int  ->  rcx         "Inlining Arg"
 ;* V134 tmp94       [V134    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V135 tmp95       [V135,T170] (  2,   0   )   byref  ->  rax         single-def "Inlining Arg"
-;  V136 tmp96       [V136,T196] (  2,   0   )     int  ->   r9         "Inlining Arg"
+;  V135 tmp95       [V135,T171] (  2,   0   )   byref  ->  rax         single-def "Inlining Arg"
+;  V136 tmp96       [V136,T197] (  2,   0   )     int  ->   r9         "Inlining Arg"
 ;* V137 tmp97       [V137    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;  V138 tmp98       [V138,T52] (  8,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V139 tmp99       [V139    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
@@ -6043,31 +6067,31 @@ G_M53443_IG22:
 ;* V145 tmp105      [V145    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V146 tmp106      [V146    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V147 tmp107      [V147    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V148 tmp108      [V148,T88] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V148 tmp108      [V148,T89] (  4,   0   )   short  ->  rdx         "Inlining Arg"
 ;* V149 tmp109      [V149    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V150 tmp110      [V150,T136] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V150 tmp110      [V150,T137] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V151 tmp111      [V151    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V152 tmp112      [V152    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V153 tmp113      [V153    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
-;  V154 tmp114      [V154,T61] (  6,   0   )   short  ->  rdx         "Inlining Arg"
-;  V155 tmp115      [V155,T62] (  6,   0   )   short  ->   r8         "Inlining Arg"
+;  V154 tmp114      [V154,T62] (  6,   0   )   short  ->  rdx         "Inlining Arg"
+;  V155 tmp115      [V155,T63] (  6,   0   )   short  ->   r8         "Inlining Arg"
 ;* V156 tmp116      [V156    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V157 tmp117      [V157,T89] (  4,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V157 tmp117      [V157,T90] (  4,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V158 tmp118      [V158    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V159 tmp119      [V159    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V160 tmp120      [V160    ] (  0,   0   )  ushort  ->  zero-ref    "Inline stloc first use temp"
 ;* V161 tmp121      [V161    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V162 tmp122      [V162    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V163 tmp123      [V163,T197] (  2,   0   )  ushort  ->  rdx         "Inline return value spill temp"
-;  V164 tmp124      [V164,T137] (  3,   0   )  ushort  ->  rdx         "Inlining Arg"
-;  V165 tmp125      [V165,T138] (  3,   0   )  ushort  ->   r8         "Inlining Arg"
+;  V163 tmp123      [V163,T198] (  2,   0   )  ushort  ->  rdx         "Inline return value spill temp"
+;  V164 tmp124      [V164,T138] (  3,   0   )  ushort  ->  rdx         "Inlining Arg"
+;  V165 tmp125      [V165,T139] (  3,   0   )  ushort  ->   r8         "Inlining Arg"
 ;* V166 tmp126      [V166    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V167 tmp127      [V167    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
-;  V168 tmp128      [V168,T90] (  4,   0   )   short  ->  rdx         "Inlining Arg"
-;  V169 tmp129      [V169,T91] (  4,   0   )   short  ->   r8         "Inlining Arg"
-;  V170 tmp130      [V170,T92] (  4,   0   )   short  ->  rax         "Inlining Arg"
+;  V168 tmp128      [V168,T91] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V169 tmp129      [V169,T92] (  4,   0   )   short  ->   r8         "Inlining Arg"
+;  V170 tmp130      [V170,T93] (  4,   0   )   short  ->  rax         "Inlining Arg"
 ;* V171 tmp131      [V171    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V172 tmp132      [V172,T139] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V172 tmp132      [V172,T140] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V173 tmp133      [V173    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V174 tmp134      [V174    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V175 tmp135      [V175    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
@@ -6091,39 +6115,39 @@ G_M53443_IG22:
 ;* V193 tmp153      [V193    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V194 tmp154      [V194    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V195 tmp155      [V195    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V196 tmp156      [V196,T93] (  4,   0   )   ubyte  ->  r15         "Inline return value spill temp"
-;  V197 tmp157      [V197,T74] (  4,   0   )     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V198 tmp158      [V198,T63] (  6,   0   )  ushort  ->  rcx         "Inlining Arg"
-;  V199 tmp159      [V199,T118] (  3,   0   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
-;  V200 tmp160      [V200,T140] (  3,   0   )     int  ->  rax         "Inline stloc first use temp"
-;  V201 tmp161      [V201,T141] (  3,   0   )     int  ->   r8         "Inline stloc first use temp"
-;  V202 tmp162      [V202,T142] (  3,   0   )     int  ->  rax         "Inline stloc first use temp"
-;  V203 tmp163      [V203,T94] (  4,   0   )     int  ->  rdx         "Inlining Arg"
+;  V196 tmp156      [V196,T94] (  4,   0   )   ubyte  ->  r15         "Inline return value spill temp"
+;  V197 tmp157      [V197,T75] (  4,   0   )     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V198 tmp158      [V198,T64] (  6,   0   )  ushort  ->  rcx         "Inlining Arg"
+;  V199 tmp159      [V199,T119] (  3,   0   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
+;  V200 tmp160      [V200,T141] (  3,   0   )     int  ->  rax         "Inline stloc first use temp"
+;  V201 tmp161      [V201,T142] (  3,   0   )     int  ->   r8         "Inline stloc first use temp"
+;  V202 tmp162      [V202,T143] (  3,   0   )     int  ->  rax         "Inline stloc first use temp"
+;  V203 tmp163      [V203,T95] (  4,   0   )     int  ->  rdx         "Inlining Arg"
 ;* V204 tmp164      [V204    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V205 tmp165      [V205,T119] (  3,   0   )   byref  ->  rcx         single-def "Inlining Arg"
-;  V206 tmp166      [V206,T143] (  3,   0   )     int  ->   r8         "Inlining Arg"
+;  V205 tmp165      [V205,T120] (  3,   0   )   byref  ->  rcx         single-def "Inlining Arg"
+;  V206 tmp166      [V206,T144] (  3,   0   )     int  ->   r8         "Inlining Arg"
 ;* V207 tmp167      [V207    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V208 tmp168      [V208    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V209 tmp169      [V209,T198] (  2,   0   )  ushort  ->  rdx         ld-addr-op "Inlining Arg"
+;  V209 tmp169      [V209,T199] (  2,   0   )  ushort  ->  rdx         ld-addr-op "Inlining Arg"
 ;* V210 tmp170      [V210    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V211 tmp171      [V211    ] (  0,   0   )   byref  ->  zero-ref    single-def "Inlining Arg"
-;  V212 tmp172      [V212,T95] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V212 tmp172      [V212,T96] (  4,   0   )   short  ->  rdx         "Inlining Arg"
 ;* V213 tmp173      [V213    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V214 tmp174      [V214,T96] (  4,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V214 tmp174      [V214,T97] (  4,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V215 tmp175      [V215    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V216 tmp176      [V216    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V217 tmp177      [V217    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V218 tmp178      [V218    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V219 tmp179      [V219,T97] (  4,   0   )     int  ->  rcx         "Inlining Arg"
+;  V219 tmp179      [V219,T98] (  4,   0   )     int  ->  rcx         "Inlining Arg"
 ;* V220 tmp180      [V220    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V221 tmp181      [V221,T171] (  2,   0   )   byref  ->  rdx         single-def "Inlining Arg"
-;  V222 tmp182      [V222,T199] (  2,   0   )     int  ->   r8         "Inlining Arg"
+;  V221 tmp181      [V221,T172] (  2,   0   )   byref  ->  rdx         single-def "Inlining Arg"
+;  V222 tmp182      [V222,T200] (  2,   0   )     int  ->   r8         "Inlining Arg"
 ;* V223 tmp183      [V223    ] (  0,   0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V224 tmp184      [V224    ] (  0,   0   )     ref  ->  zero-ref    class-hnd single-def "Inlining Arg" <System.__Canon>
 ;* V225 tmp185      [V225    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V226 tmp186      [V226    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V227 tmp187      [V227,T172] (  2,   0   )   byref  ->   r9         single-def "Inlining Arg"
-;  V228 tmp188      [V228,T200] (  2,   0   )     int  ->  rax         "Inlining Arg"
+;  V227 tmp187      [V227,T173] (  2,   0   )   byref  ->   r9         single-def "Inlining Arg"
+;  V228 tmp188      [V228,T201] (  2,   0   )     int  ->  rax         "Inlining Arg"
 ;* V229 tmp189      [V229    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V230 tmp190      [V230    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V231 tmp191      [V231    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
@@ -6135,11 +6159,11 @@ G_M53443_IG22:
 ;* V237 tmp197      [V237    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V238 tmp198      [V238    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V239 tmp199      [V239    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V240 tmp200      [V240,T38] (  3,   2.41)     int  ->  r10         "Inline return value spill temp"
-;  V241 tmp201      [V241,T33] (  3,   7.22)     int  ->  r10         "Inlining Arg"
+;  V240 tmp200      [V240,T37] (  3,   2.39)     int  ->  r10         "Inline return value spill temp"
+;  V241 tmp201      [V241,T31] (  3,   7.16)     int  ->  r10         "Inlining Arg"
 ;* V242 tmp202      [V242    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V243 tmp203      [V243,T46] ( 12,   0   )   byref  ->  rcx         "Inlining Arg"
-;  V244 tmp204      [V244,T47] ( 12,   0   )     int  ->  r10         "Inlining Arg"
+;  V243 tmp203      [V243,T47] ( 12,   0   )   byref  ->  rcx         "Inlining Arg"
+;  V244 tmp204      [V244,T48] ( 12,   0   )     int  ->  r10         "Inlining Arg"
 ;* V245 tmp205      [V245    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ushort[]>
 ;* V246 tmp206      [V246    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V247 tmp207      [V247    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ushort[]>
@@ -6153,31 +6177,31 @@ G_M53443_IG22:
 ;* V255 tmp215      [V255    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V256 tmp216      [V256    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V257 tmp217      [V257    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V258 tmp218      [V258,T98] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V258 tmp218      [V258,T99] (  4,   0   )   short  ->  rdx         "Inlining Arg"
 ;* V259 tmp219      [V259    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V260 tmp220      [V260,T144] (  3,   0   )     int  ->   r8         "Inline return value spill temp"
+;  V260 tmp220      [V260,T145] (  3,   0   )     int  ->   r8         "Inline return value spill temp"
 ;* V261 tmp221      [V261    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V262 tmp222      [V262    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V263 tmp223      [V263    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
-;  V264 tmp224      [V264,T64] (  6,   0   )   short  ->  rdx         "Inlining Arg"
-;  V265 tmp225      [V265,T65] (  6,   0   )   short  ->   r8         "Inlining Arg"
+;  V264 tmp224      [V264,T65] (  6,   0   )   short  ->  rdx         "Inlining Arg"
+;  V265 tmp225      [V265,T66] (  6,   0   )   short  ->   r8         "Inlining Arg"
 ;* V266 tmp226      [V266    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V267 tmp227      [V267,T99] (  4,   0   )     int  ->   r8         "Inline return value spill temp"
+;  V267 tmp227      [V267,T100] (  4,   0   )     int  ->   r8         "Inline return value spill temp"
 ;* V268 tmp228      [V268    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V269 tmp229      [V269    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V270 tmp230      [V270    ] (  0,   0   )  ushort  ->  zero-ref    "Inline stloc first use temp"
 ;* V271 tmp231      [V271    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V272 tmp232      [V272    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V273 tmp233      [V273,T145] (  3,   0   )  ushort  ->   r8         "Inline return value spill temp"
-;  V274 tmp234      [V274,T146] (  3,   0   )  ushort  ->  rdx         "Inlining Arg"
-;  V275 tmp235      [V275,T147] (  3,   0   )  ushort  ->   r8         "Inlining Arg"
+;  V273 tmp233      [V273,T146] (  3,   0   )  ushort  ->   r8         "Inline return value spill temp"
+;  V274 tmp234      [V274,T147] (  3,   0   )  ushort  ->  rdx         "Inlining Arg"
+;  V275 tmp235      [V275,T148] (  3,   0   )  ushort  ->   r8         "Inlining Arg"
 ;* V276 tmp236      [V276    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V277 tmp237      [V277    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
-;  V278 tmp238      [V278,T100] (  4,   0   )   short  ->  rdx         "Inlining Arg"
-;  V279 tmp239      [V279,T101] (  4,   0   )   short  ->   r8         "Inlining Arg"
-;  V280 tmp240      [V280,T102] (  4,   0   )   short  ->  r11         "Inlining Arg"
+;  V278 tmp238      [V278,T101] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V279 tmp239      [V279,T102] (  4,   0   )   short  ->   r8         "Inlining Arg"
+;  V280 tmp240      [V280,T103] (  4,   0   )   short  ->  r11         "Inlining Arg"
 ;* V281 tmp241      [V281    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V282 tmp242      [V282,T148] (  3,   0   )     int  ->   r8         "Inline return value spill temp"
+;  V282 tmp242      [V282,T149] (  3,   0   )     int  ->   r8         "Inline return value spill temp"
 ;* V283 tmp243      [V283    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V284 tmp244      [V284    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V285 tmp245      [V285    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
@@ -6203,37 +6227,37 @@ G_M53443_IG22:
 ;* V305 tmp265      [V305    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ushort[]>
 ;* V306 tmp266      [V306    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V307 tmp267      [V307    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ushort[]>
-;  V308 tmp268      [V308,T103] (  4,   0   )   ubyte  ->   r9         "Inline return value spill temp"
-;  V309 tmp269      [V309,T120] (  3,   0   )   byref  ->  rax         "Inlining Arg"
-;  V310 tmp270      [V310,T75] (  4,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V308 tmp268      [V308,T104] (  4,   0   )   ubyte  ->   r9         "Inline return value spill temp"
+;  V309 tmp269      [V309,T121] (  3,   0   )   byref  ->  rax         "Inlining Arg"
+;  V310 tmp270      [V310,T76] (  4,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V311 tmp271      [V311    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V312 tmp272      [V312,T149] (  3,   0   )     int  ->  rdx         "Inline stloc first use temp"
-;  V313 tmp273      [V313,T150] (  3,   0   )     int  ->  rcx         "Inline stloc first use temp"
-;  V314 tmp274      [V314,T151] (  3,   0   )     int  ->  rdx         "Inline stloc first use temp"
-;  V315 tmp275      [V315,T13] (  3, 486.84)   ubyte  ->  rax         "Inline return value spill temp"
-;  V316 tmp276      [V316,T02] (  4,1947.30)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V312 tmp272      [V312,T150] (  3,   0   )     int  ->  rdx         "Inline stloc first use temp"
+;  V313 tmp273      [V313,T151] (  3,   0   )     int  ->  rcx         "Inline stloc first use temp"
+;  V314 tmp274      [V314,T152] (  3,   0   )     int  ->  rdx         "Inline stloc first use temp"
+;  V315 tmp275      [V315,T40] (  3,   0.02)   ubyte  ->  rax         "Inline return value spill temp"
+;  V316 tmp276      [V316,T02] (  4,1938.87)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V317 tmp277      [V317    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V318 tmp278      [V318,T03] (  4,1947.29)     int  ->  rdx         "Inline stloc first use temp"
-;  V319 tmp279      [V319,T06] (  3,1460.45)     int  ->  rcx         "Inline stloc first use temp"
-;  V320 tmp280      [V320,T07] (  3,1460.45)     int  ->  rdx         "Inline stloc first use temp"
-;  V321 tmp281      [V321,T31] (  3,   8.66)   ubyte  ->  rax         "Inline return value spill temp"
-;  V322 tmp282      [V322,T19] (  3,  34.64)   byref  ->  rax         "Inlining Arg"
-;  V323 tmp283      [V323,T20] (  4,  34.64)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V318 tmp278      [V318,T03] (  4,1938.85)     int  ->  rdx         "Inline stloc first use temp"
+;  V319 tmp279      [V319,T06] (  3,1454.12)     int  ->  rcx         "Inline stloc first use temp"
+;  V320 tmp280      [V320,T07] (  3,1454.12)     int  ->  rdx         "Inline stloc first use temp"
+;  V321 tmp281      [V321,T41] (  3,   0.00)   ubyte  ->  rax         "Inline return value spill temp"
+;  V322 tmp282      [V322,T18] (  3,  34.39)   byref  ->  rax         "Inlining Arg"
+;  V323 tmp283      [V323,T19] (  4,  34.38)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V324 tmp284      [V324    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V325 tmp285      [V325,T21] (  4,  34.64)     int  ->  rdx         "Inline stloc first use temp"
-;  V326 tmp286      [V326,T23] (  3,  25.98)     int  ->  rcx         "Inline stloc first use temp"
-;  V327 tmp287      [V327,T24] (  3,  25.98)     int  ->  rdx         "Inline stloc first use temp"
+;  V325 tmp285      [V325,T20] (  4,  34.38)     int  ->  rdx         "Inline stloc first use temp"
+;  V326 tmp286      [V326,T22] (  3,  25.79)     int  ->  rcx         "Inline stloc first use temp"
+;  V327 tmp287      [V327,T23] (  3,  25.79)     int  ->  rdx         "Inline stloc first use temp"
 ;* V328 tmp288      [V328    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
-;  V329 tmp289      [V329,T121] (  2,   0   )   byref  ->   r9         "Inlining Arg"
-;  V330 tmp290      [V330,T152] (  2,   0   )     int  ->  r11         "Inlining Arg"
+;  V329 tmp289      [V329,T122] (  2,   0   )   byref  ->   r9         "Inlining Arg"
+;  V330 tmp290      [V330,T153] (  2,   0   )     int  ->  r11         "Inlining Arg"
 ;* V331 tmp291      [V331    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V332 tmp292      [V332    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V333 tmp293      [V333,T201] (  2,   0   )  ushort  ->  rdx         ld-addr-op "Inlining Arg"
+;  V333 tmp293      [V333,T202] (  2,   0   )  ushort  ->  rdx         ld-addr-op "Inlining Arg"
 ;* V334 tmp294      [V334    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V335 tmp295      [V335    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V336 tmp296      [V336,T104] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V336 tmp296      [V336,T105] (  4,   0   )   short  ->  rdx         "Inlining Arg"
 ;* V337 tmp297      [V337    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V338 tmp298      [V338,T153] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V338 tmp298      [V338,T154] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V339 tmp299      [V339    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V340 tmp300      [V340    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V341 tmp301      [V341    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
@@ -6251,31 +6275,31 @@ G_M53443_IG22:
 ;* V353 tmp313      [V353    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V354 tmp314      [V354    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V355 tmp315      [V355    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V356 tmp316      [V356,T105] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V356 tmp316      [V356,T106] (  4,   0   )   short  ->  rdx         "Inlining Arg"
 ;* V357 tmp317      [V357    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V358 tmp318      [V358,T154] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V358 tmp318      [V358,T155] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V359 tmp319      [V359    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V360 tmp320      [V360    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V361 tmp321      [V361    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
-;  V362 tmp322      [V362,T66] (  6,   0   )   short  ->  rdx         "Inlining Arg"
-;  V363 tmp323      [V363,T67] (  6,   0   )   short  ->   r8         "Inlining Arg"
+;  V362 tmp322      [V362,T67] (  6,   0   )   short  ->  rdx         "Inlining Arg"
+;  V363 tmp323      [V363,T68] (  6,   0   )   short  ->   r8         "Inlining Arg"
 ;* V364 tmp324      [V364    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V365 tmp325      [V365,T106] (  4,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V365 tmp325      [V365,T107] (  4,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V366 tmp326      [V366    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V367 tmp327      [V367    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V368 tmp328      [V368    ] (  0,   0   )  ushort  ->  zero-ref    "Inline stloc first use temp"
 ;* V369 tmp329      [V369    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V370 tmp330      [V370    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V371 tmp331      [V371,T155] (  3,   0   )  ushort  ->  rcx         "Inline return value spill temp"
-;  V372 tmp332      [V372,T156] (  3,   0   )  ushort  ->  rdx         "Inlining Arg"
-;  V373 tmp333      [V373,T157] (  3,   0   )  ushort  ->  rcx         "Inlining Arg"
+;  V371 tmp331      [V371,T156] (  3,   0   )  ushort  ->  rcx         "Inline return value spill temp"
+;  V372 tmp332      [V372,T157] (  3,   0   )  ushort  ->  rdx         "Inlining Arg"
+;  V373 tmp333      [V373,T158] (  3,   0   )  ushort  ->  rcx         "Inlining Arg"
 ;* V374 tmp334      [V374    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V375 tmp335      [V375    ] (  0,   0   )  ushort  ->  zero-ref    "Inlining Arg"
-;  V376 tmp336      [V376,T107] (  4,   0   )   short  ->  rdx         "Inlining Arg"
-;  V377 tmp337      [V377,T108] (  4,   0   )   short  ->   r8         "Inlining Arg"
-;  V378 tmp338      [V378,T109] (  4,   0   )   short  ->   r9         "Inlining Arg"
+;  V376 tmp336      [V376,T108] (  4,   0   )   short  ->  rdx         "Inlining Arg"
+;  V377 tmp337      [V377,T109] (  4,   0   )   short  ->   r8         "Inlining Arg"
+;  V378 tmp338      [V378,T110] (  4,   0   )   short  ->   r9         "Inlining Arg"
 ;* V379 tmp339      [V379    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V380 tmp340      [V380,T158] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V380 tmp340      [V380,T159] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
 ;* V381 tmp341      [V381    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V382 tmp342      [V382    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V383 tmp343      [V383    ] (  0,   0   )   short  ->  zero-ref    ld-addr-op "Inlining Arg"
@@ -6302,28 +6326,28 @@ G_M53443_IG22:
 ;* V404 tmp364      [V404    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.__Canon>
 ;* V405 tmp365      [V405    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V406 tmp366      [V406    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
-;  V407 tmp367      [V407,T173] (  2,   0   )   byref  ->  rcx         "Inlining Arg"
-;  V408 tmp368      [V408,T202] (  2,   0   )     int  ->  rdx         "Inlining Arg"
-;  V409 tmp369      [V409,T110] (  4,   0   )   ubyte  ->   r9         "Inline return value spill temp"
-;  V410 tmp370      [V410,T122] (  3,   0   )   byref  ->  rax         "Inlining Arg"
-;  V411 tmp371      [V411,T69] (  5,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V412 tmp372      [V412,T68] (  6,   0   )  ushort  ->  [rsp+0xAC]  spill-single-def "Inlining Arg"
-;  V413 tmp373      [V413,T123] (  3,   0   )     ref  ->  [rsp+0x58]  class-hnd exact spill-single-def "Inlining Arg" <System.String>
-;  V414 tmp374      [V414,T111] (  4,   0   )     int  ->  rdx         "Inline stloc first use temp"
-;  V415 tmp375      [V415,T159] (  3,   0   )     int  ->  rcx         "Inline stloc first use temp"
-;  V416 tmp376      [V416,T160] (  3,   0   )     int  ->  rdx         "Inline stloc first use temp"
-;  V417 tmp377      [V417,T09] ( 13, 496.49)   byref  ->  rbp         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
-;  V418 tmp378      [V418,T08] ( 34, 498.69)     int  ->  r14         "field V01._length (fldOffset=0x8)" P-INDEP
-;  V419 tmp379      [V419,T174] (  2,   0   )   byref  ->  rbp         single-def "field V11._reference (fldOffset=0x0)" P-INDEP
-;  V420 tmp380      [V420,T161] (  3,   0   )     int  ->  r13         "field V11._length (fldOffset=0x8)" P-INDEP
+;  V407 tmp367      [V407,T174] (  2,   0   )   byref  ->  rcx         "Inlining Arg"
+;  V408 tmp368      [V408,T203] (  2,   0   )     int  ->  rdx         "Inlining Arg"
+;  V409 tmp369      [V409,T111] (  4,   0   )   ubyte  ->   r9         "Inline return value spill temp"
+;  V410 tmp370      [V410,T123] (  3,   0   )   byref  ->  rax         "Inlining Arg"
+;  V411 tmp371      [V411,T70] (  5,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V412 tmp372      [V412,T69] (  6,   0   )  ushort  ->  [rsp+0xB4]  spill-single-def "Inlining Arg"
+;  V413 tmp373      [V413,T124] (  3,   0   )     ref  ->  [rsp+0x50]  class-hnd exact spill-single-def "Inlining Arg" <System.String>
+;  V414 tmp374      [V414,T112] (  4,   0   )     int  ->  rdx         "Inline stloc first use temp"
+;  V415 tmp375      [V415,T160] (  3,   0   )     int  ->  rcx         "Inline stloc first use temp"
+;  V416 tmp376      [V416,T161] (  3,   0   )     int  ->  rdx         "Inline stloc first use temp"
+;  V417 tmp377      [V417,T09] ( 13, 494.32)   byref  ->  rbp         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
+;  V418 tmp378      [V418,T08] ( 34, 496.51)     int  ->  r14         "field V01._length (fldOffset=0x8)" P-INDEP
+;  V419 tmp379      [V419,T175] (  2,   0   )   byref  ->  rbp         single-def "field V11._reference (fldOffset=0x0)" P-INDEP
+;  V420 tmp380      [V420,T162] (  3,   0   )     int  ->  r13         "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V421 tmp381      [V421    ] (  0,   0   )   byref  ->  zero-ref    "field V23._reference (fldOffset=0x0)" P-INDEP
 ;* V422 tmp382      [V422    ] (  0,   0   )     int  ->  zero-ref    "field V23._length (fldOffset=0x8)" P-INDEP
-;  V423 tmp383      [V423,T76] (  4,   0   )     ref  ->  r15         single-def "field V34.Item2 (fldOffset=0x0)" P-INDEP
-;  V424 tmp384      [V424,T77] (  4,   0   )     ref  ->  r13         single-def "field V34.Item4 (fldOffset=0x8)" P-INDEP
-;  V425 tmp385      [V425,T203] (  2,   0   )     int  ->  r12         "field V34.Item3 (fldOffset=0x10)" P-INDEP
-;  V426 tmp386      [V426,T204] (  2,   0   )  ushort  ->  [rsp+0xA8]  "field V34.Item1 (fldOffset=0x14)" P-INDEP
-;  V427 tmp387      [V427,T45] ( 15,   0   )   byref  ->  [rsp+0x50]  "field V37._reference (fldOffset=0x0)" P-INDEP
-;  V428 tmp388      [V428,T44] ( 16,   0   )     int  ->  [rsp+0xA4]  "field V37._length (fldOffset=0x8)" P-INDEP
+;  V423 tmp383      [V423,T77] (  4,   0   )     ref  ->  r15         single-def "field V34.Item2 (fldOffset=0x0)" P-INDEP
+;  V424 tmp384      [V424,T78] (  4,   0   )     ref  ->  r13         single-def "field V34.Item4 (fldOffset=0x8)" P-INDEP
+;  V425 tmp385      [V425,T204] (  2,   0   )     int  ->  r12         "field V34.Item3 (fldOffset=0x10)" P-INDEP
+;  V426 tmp386      [V426,T205] (  2,   0   )  ushort  ->  [rsp+0xB0]  "field V34.Item1 (fldOffset=0x14)" P-INDEP
+;  V427 tmp387      [V427,T46] ( 15,   0   )   byref  ->  [rsp+0x48]  "field V37._reference (fldOffset=0x0)" P-INDEP
+;  V428 tmp388      [V428,T45] ( 16,   0   )     int  ->  [rsp+0xAC]  "field V37._length (fldOffset=0x8)" P-INDEP
 ;* V429 tmp389      [V429    ] (  0,   0   )   byref  ->  zero-ref    "field V44._reference (fldOffset=0x0)" P-INDEP
 ;* V430 tmp390      [V430    ] (  0,   0   )     int  ->  zero-ref    "field V44._length (fldOffset=0x8)" P-INDEP
 ;* V431 tmp391      [V431    ] (  0,   0   )   byref  ->  zero-ref    "field V45._reference (fldOffset=0x0)" P-INDEP
@@ -6332,36 +6356,36 @@ G_M53443_IG22:
 ;* V434 tmp394      [V434    ] (  0,   0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
 ;* V435 tmp395      [V435    ] (  0,   0   )   byref  ->  zero-ref    "field V50._reference (fldOffset=0x0)" P-INDEP
 ;* V436 tmp396      [V436    ] (  0,   0   )     int  ->  zero-ref    "field V50._length (fldOffset=0x8)" P-INDEP
-;  V437 tmp397      [V437,T41] ( 17,   0   )   byref  ->  [rsp+0xB0]  do-not-enreg[H] hidden-struct-arg "field V51._reference (fldOffset=0x0)" P-DEP
-;  V438 tmp398      [V438,T112] (  4,   0   )     int  ->  [rsp+0xB8]  do-not-enreg[H] hidden-struct-arg "field V51._length (fldOffset=0x8)" P-DEP
+;  V437 tmp397      [V437,T42] ( 17,   0   )   byref  ->  [rsp+0xB8]  do-not-enreg[H] hidden-struct-arg "field V51._reference (fldOffset=0x0)" P-DEP
+;  V438 tmp398      [V438,T113] (  4,   0   )     int  ->  [rsp+0xC0]  do-not-enreg[H] hidden-struct-arg "field V51._length (fldOffset=0x8)" P-DEP
 ;* V439 tmp399      [V439    ] (  0,   0   )   byref  ->  zero-ref    "field V55._reference (fldOffset=0x0)" P-INDEP
 ;* V440 tmp400      [V440    ] (  0,   0   )     int  ->  zero-ref    "field V55._length (fldOffset=0x8)" P-INDEP
 ;* V441 tmp401      [V441    ] (  0,   0   )   byref  ->  zero-ref    "field V58._reference (fldOffset=0x0)" P-INDEP
 ;* V442 tmp402      [V442    ] (  0,   0   )     int  ->  zero-ref    "field V58._length (fldOffset=0x8)" P-INDEP
 ;* V443 tmp403      [V443    ] (  0,   0   )     ref  ->  zero-ref    "field V60.Item2 (fldOffset=0x0)" P-INDEP
-;  V444 tmp404      [V444,T205] (  2,   0   )     int  ->  rdx         "field V60.Item3 (fldOffset=0x8)" P-INDEP
+;  V444 tmp404      [V444,T206] (  2,   0   )     int  ->  rdx         "field V60.Item3 (fldOffset=0x8)" P-INDEP
 ;* V445 tmp405      [V445    ] (  0,   0   )  ushort  ->  zero-ref    "field V60.Item1 (fldOffset=0xc)" P-INDEP
 ;* V446 tmp406      [V446    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V61._reference (fldOffset=0x0)" P-INDEP
 ;* V447 tmp407      [V447    ] (  0,   0   )     int  ->  zero-ref    "field V61._length (fldOffset=0x8)" P-INDEP
-;  V448 tmp408      [V448,T78] (  4,   0   )     ref  ->  rcx         single-def "field V62.Item2 (fldOffset=0x0)" P-INDEP
+;  V448 tmp408      [V448,T79] (  4,   0   )     ref  ->  rcx         single-def "field V62.Item2 (fldOffset=0x0)" P-INDEP
 ;* V449 tmp409      [V449    ] (  0,   0   )     int  ->  zero-ref    "field V62.Item3 (fldOffset=0x8)" P-INDEP
 ;* V450 tmp410      [V450    ] (  0,   0   )  ushort  ->  zero-ref    "field V62.Item1 (fldOffset=0xc)" P-INDEP
 ;* V451 tmp411      [V451    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V63._reference (fldOffset=0x0)" P-INDEP
 ;* V452 tmp412      [V452    ] (  0,   0   )     int  ->  zero-ref    "field V63._length (fldOffset=0x8)" P-INDEP
 ;* V453 tmp413      [V453    ] (  0,   0   )     ref  ->  zero-ref    "field V65.Item2 (fldOffset=0x0)" P-INDEP
-;  V454 tmp414      [V454,T206] (  2,   0   )     int  ->  rcx         "field V65.Item3 (fldOffset=0x8)" P-INDEP
+;  V454 tmp414      [V454,T207] (  2,   0   )     int  ->  rcx         "field V65.Item3 (fldOffset=0x8)" P-INDEP
 ;* V455 tmp415      [V455    ] (  0,   0   )  ushort  ->  zero-ref    "field V65.Item1 (fldOffset=0xc)" P-INDEP
 ;* V456 tmp416      [V456    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V66._reference (fldOffset=0x0)" P-INDEP
 ;* V457 tmp417      [V457    ] (  0,   0   )     int  ->  zero-ref    "field V66._length (fldOffset=0x8)" P-INDEP
 ;* V458 tmp418      [V458    ] (  0,   0   )     ref  ->  zero-ref    "field V67.Item2 (fldOffset=0x0)" P-INDEP
 ;* V459 tmp419      [V459    ] (  0,   0   )     int  ->  zero-ref    "field V67.Item3 (fldOffset=0x8)" P-INDEP
-;  V460 tmp420      [V460,T207] (  2,   0   )  ushort  ->  rdx         "field V67.Item1 (fldOffset=0xc)" P-INDEP
-;  V461 tmp421      [V461,T175] (  2,   0   )   byref  ->  rcx         single-def "field V68._reference (fldOffset=0x0)" P-INDEP
-;  V462 tmp422      [V462,T208] (  2,   0   )     int  ->  rdx         "field V68._length (fldOffset=0x8)" P-INDEP
+;  V460 tmp420      [V460,T208] (  2,   0   )  ushort  ->  rdx         "field V67.Item1 (fldOffset=0xc)" P-INDEP
+;  V461 tmp421      [V461,T176] (  2,   0   )   byref  ->  rcx         single-def "field V68._reference (fldOffset=0x0)" P-INDEP
+;  V462 tmp422      [V462,T209] (  2,   0   )     int  ->  rdx         "field V68._length (fldOffset=0x8)" P-INDEP
 ;* V463 tmp423      [V463    ] (  0,   0   )   byref  ->  zero-ref    "field V69._reference (fldOffset=0x0)" P-INDEP
 ;* V464 tmp424      [V464    ] (  0,   0   )     int  ->  zero-ref    "field V69._length (fldOffset=0x8)" P-INDEP
-;  V465 tmp425      [V465,T48] ( 11,   0   )   byref  ->  rcx         single-def "field V71._reference (fldOffset=0x0)" P-INDEP
-;  V466 tmp426      [V466,T49] ( 11,   0   )     int  ->   r9         "field V71._length (fldOffset=0x8)" P-INDEP
+;  V465 tmp425      [V465,T49] ( 11,   0   )   byref  ->  rcx         single-def "field V71._reference (fldOffset=0x0)" P-INDEP
+;  V466 tmp426      [V466,T50] ( 11,   0   )     int  ->   r9         "field V71._length (fldOffset=0x8)" P-INDEP
 ;* V467 tmp427      [V467    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V72._reference (fldOffset=0x0)" P-INDEP
 ;* V468 tmp428      [V468    ] (  0,   0   )     int  ->  zero-ref    "field V72._length (fldOffset=0x8)" P-INDEP
 ;* V469 tmp429      [V469    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V73._reference (fldOffset=0x0)" P-INDEP
@@ -6384,10 +6408,10 @@ G_M53443_IG22:
 ;* V486 tmp446      [V486    ] (  0,   0   )     int  ->  zero-ref    "field V101._length (fldOffset=0x8)" P-INDEP
 ;* V487 tmp447      [V487    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V103._reference (fldOffset=0x0)" P-INDEP
 ;* V488 tmp448      [V488    ] (  0,   0   )     int  ->  zero-ref    "field V103._length (fldOffset=0x8)" P-INDEP
-;  V489 tmp449      [V489,T124] (  3,   0   )   byref  ->   r9         "field V106._reference (fldOffset=0x0)" P-INDEP
-;  V490 tmp450      [V490,T162] (  3,   0   )     int  ->  rax         "field V106._length (fldOffset=0x8)" P-INDEP
-;  V491 tmp451      [V491,T176] (  2,   0   )   byref  ->   r9         single-def "field V108._reference (fldOffset=0x0)" P-INDEP
-;  V492 tmp452      [V492,T209] (  2,   0   )     int  ->  rax         "field V108._length (fldOffset=0x8)" P-INDEP
+;  V489 tmp449      [V489,T125] (  3,   0   )   byref  ->   r9         "field V106._reference (fldOffset=0x0)" P-INDEP
+;  V490 tmp450      [V490,T163] (  3,   0   )     int  ->  rax         "field V106._length (fldOffset=0x8)" P-INDEP
+;  V491 tmp451      [V491,T177] (  2,   0   )   byref  ->   r9         single-def "field V108._reference (fldOffset=0x0)" P-INDEP
+;  V492 tmp452      [V492,T210] (  2,   0   )     int  ->  rax         "field V108._length (fldOffset=0x8)" P-INDEP
 ;* V493 tmp453      [V493    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V109._reference (fldOffset=0x0)" P-INDEP
 ;* V494 tmp454      [V494    ] (  0,   0   )     int  ->  zero-ref    "field V109._length (fldOffset=0x8)" P-INDEP
 ;* V495 tmp455      [V495    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V113._reference (fldOffset=0x0)" P-INDEP
@@ -6402,18 +6426,18 @@ G_M53443_IG22:
 ;* V504 tmp464      [V504    ] (  0,   0   )     int  ->  zero-ref    "field V121._length (fldOffset=0x8)" P-INDEP
 ;* V505 tmp465      [V505    ] (  0,   0   )   byref  ->  zero-ref    "field V122._reference (fldOffset=0x0)" P-INDEP
 ;* V506 tmp466      [V506    ] (  0,   0   )     int  ->  zero-ref    "field V122._length (fldOffset=0x8)" P-INDEP
-;  V507 tmp467      [V507,T177] (  2,   0   )   byref  ->  rdx         single-def "field V124._reference (fldOffset=0x0)" P-INDEP
-;  V508 tmp468      [V508,T210] (  2,   0   )     int  ->   r8         "field V124._length (fldOffset=0x8)" P-INDEP
-;  V509 tmp469      [V509,T125] (  3,   0   )   byref  ->  rax         "field V127._reference (fldOffset=0x0)" P-INDEP
-;  V510 tmp470      [V510,T163] (  3,   0   )     int  ->  r10         "field V127._length (fldOffset=0x8)" P-INDEP
-;  V511 tmp471      [V511,T178] (  2,   0   )   byref  ->  rax         single-def "field V129._reference (fldOffset=0x0)" P-INDEP
-;  V512 tmp472      [V512,T211] (  2,   0   )     int  ->  r10         "field V129._length (fldOffset=0x8)" P-INDEP
+;  V507 tmp467      [V507,T178] (  2,   0   )   byref  ->  rdx         single-def "field V124._reference (fldOffset=0x0)" P-INDEP
+;  V508 tmp468      [V508,T211] (  2,   0   )     int  ->   r8         "field V124._length (fldOffset=0x8)" P-INDEP
+;  V509 tmp469      [V509,T126] (  3,   0   )   byref  ->  rax         "field V127._reference (fldOffset=0x0)" P-INDEP
+;  V510 tmp470      [V510,T164] (  3,   0   )     int  ->  r10         "field V127._length (fldOffset=0x8)" P-INDEP
+;  V511 tmp471      [V511,T179] (  2,   0   )   byref  ->  rax         single-def "field V129._reference (fldOffset=0x0)" P-INDEP
+;  V512 tmp472      [V512,T212] (  2,   0   )     int  ->  r10         "field V129._length (fldOffset=0x8)" P-INDEP
 ;* V513 tmp473      [V513    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V130._reference (fldOffset=0x0)" P-INDEP
 ;* V514 tmp474      [V514    ] (  0,   0   )     int  ->  zero-ref    "field V130._length (fldOffset=0x8)" P-INDEP
-;  V515 tmp475      [V515,T79] (  4,   0   )   byref  ->  rcx         single-def "field V134._reference (fldOffset=0x0)" P-INDEP
-;  V516 tmp476      [V516,T113] (  4,   0   )     int  ->   r9         "field V134._length (fldOffset=0x8)" P-INDEP
-;  V517 tmp477      [V517,T42] ( 17,   0   )   byref  ->  rdi         single-def "field V137._reference (fldOffset=0x0)" P-INDEP
-;  V518 tmp478      [V518,T114] (  4,   0   )     int  ->  rax         "field V137._length (fldOffset=0x8)" P-INDEP
+;  V515 tmp475      [V515,T80] (  4,   0   )   byref  ->  rcx         single-def "field V134._reference (fldOffset=0x0)" P-INDEP
+;  V516 tmp476      [V516,T114] (  4,   0   )     int  ->   r9         "field V134._length (fldOffset=0x8)" P-INDEP
+;  V517 tmp477      [V517,T43] ( 17,   0   )   byref  ->  rdi         single-def "field V137._reference (fldOffset=0x0)" P-INDEP
+;  V518 tmp478      [V518,T115] (  4,   0   )     int  ->  rax         "field V137._length (fldOffset=0x8)" P-INDEP
 ;* V519 tmp479      [V519    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V139._reference (fldOffset=0x0)" P-INDEP
 ;* V520 tmp480      [V520    ] (  0,   0   )     int  ->  zero-ref    "field V139._length (fldOffset=0x8)" P-INDEP
 ;* V521 tmp481      [V521    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V140._reference (fldOffset=0x0)" P-INDEP
@@ -6426,8 +6450,8 @@ G_M53443_IG22:
 ;* V528 tmp488      [V528    ] (  0,   0   )     int  ->  zero-ref    "field V193._length (fldOffset=0x8)" P-INDEP
 ;* V529 tmp489      [V529    ] (  0,   0   )   byref  ->  zero-ref    "field V194._reference (fldOffset=0x0)" P-INDEP
 ;* V530 tmp490      [V530    ] (  0,   0   )     int  ->  zero-ref    "field V194._length (fldOffset=0x8)" P-INDEP
-;  V531 tmp491      [V531,T179] (  2,   0   )   byref  ->  rax         single-def "field V195._reference (fldOffset=0x0)" P-INDEP
-;  V532 tmp492      [V532,T212] (  2,   0   )     int  ->   r8         "field V195._length (fldOffset=0x8)" P-INDEP
+;  V531 tmp491      [V531,T180] (  2,   0   )   byref  ->  rax         single-def "field V195._reference (fldOffset=0x0)" P-INDEP
+;  V532 tmp492      [V532,T213] (  2,   0   )     int  ->   r8         "field V195._length (fldOffset=0x8)" P-INDEP
 ;* V533 tmp493      [V533    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V204._reference (fldOffset=0x0)" P-INDEP
 ;* V534 tmp494      [V534    ] (  0,   0   )     int  ->  zero-ref    "field V204._length (fldOffset=0x8)" P-INDEP
 ;* V535 tmp495      [V535    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V208._reference (fldOffset=0x0)" P-INDEP
@@ -6438,10 +6462,10 @@ G_M53443_IG22:
 ;* V540 tmp500      [V540    ] (  0,   0   )     int  ->  zero-ref    "field V218._length (fldOffset=0x8)" P-INDEP
 ;* V541 tmp501      [V541    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V220._reference (fldOffset=0x0)" P-INDEP
 ;* V542 tmp502      [V542    ] (  0,   0   )     int  ->  zero-ref    "field V220._length (fldOffset=0x8)" P-INDEP
-;  V543 tmp503      [V543,T126] (  3,   0   )   byref  ->   r9         "field V223._reference (fldOffset=0x0)" P-INDEP
-;  V544 tmp504      [V544,T164] (  3,   0   )     int  ->  rax         "field V223._length (fldOffset=0x8)" P-INDEP
-;  V545 tmp505      [V545,T180] (  2,   0   )   byref  ->   r9         single-def "field V225._reference (fldOffset=0x0)" P-INDEP
-;  V546 tmp506      [V546,T213] (  2,   0   )     int  ->  rax         "field V225._length (fldOffset=0x8)" P-INDEP
+;  V543 tmp503      [V543,T127] (  3,   0   )   byref  ->   r9         "field V223._reference (fldOffset=0x0)" P-INDEP
+;  V544 tmp504      [V544,T165] (  3,   0   )     int  ->  rax         "field V223._length (fldOffset=0x8)" P-INDEP
+;  V545 tmp505      [V545,T181] (  2,   0   )   byref  ->   r9         single-def "field V225._reference (fldOffset=0x0)" P-INDEP
+;  V546 tmp506      [V546,T214] (  2,   0   )     int  ->  rax         "field V225._length (fldOffset=0x8)" P-INDEP
 ;* V547 tmp507      [V547    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V226._reference (fldOffset=0x0)" P-INDEP
 ;* V548 tmp508      [V548    ] (  0,   0   )     int  ->  zero-ref    "field V226._length (fldOffset=0x8)" P-INDEP
 ;* V549 tmp509      [V549    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V230._reference (fldOffset=0x0)" P-INDEP
@@ -6456,10 +6480,10 @@ G_M53443_IG22:
 ;* V558 tmp518      [V558    ] (  0,   0   )     int  ->  zero-ref    "field V238._length (fldOffset=0x8)" P-INDEP
 ;* V559 tmp519      [V559    ] (  0,   0   )   byref  ->  zero-ref    "field V239._reference (fldOffset=0x0)" P-INDEP
 ;* V560 tmp520      [V560    ] (  0,   0   )     int  ->  zero-ref    "field V239._length (fldOffset=0x8)" P-INDEP
-;  V561 tmp521      [V561,T181] (  2,   0   )   byref  ->  r11         "field V242._reference (fldOffset=0x0)" P-INDEP
-;  V562 tmp522      [V562,T214] (  2,   0   )     int  ->   r8         "field V242._length (fldOffset=0x8)" P-INDEP
-;  V563 tmp523      [V563,T43] ( 17,   0   )   byref  ->  r11         "field V246._reference (fldOffset=0x0)" P-INDEP
-;  V564 tmp524      [V564,T115] (  4,   0   )     int  ->  [rsp+0xA0]  spill-single-def "field V246._length (fldOffset=0x8)" P-INDEP
+;  V561 tmp521      [V561,T182] (  2,   0   )   byref  ->  r11         "field V242._reference (fldOffset=0x0)" P-INDEP
+;  V562 tmp522      [V562,T215] (  2,   0   )     int  ->   r8         "field V242._length (fldOffset=0x8)" P-INDEP
+;  V563 tmp523      [V563,T44] ( 17,   0   )   byref  ->  r11         "field V246._reference (fldOffset=0x0)" P-INDEP
+;  V564 tmp524      [V564,T116] (  4,   0   )     int  ->  [rsp+0xA8]  spill-single-def "field V246._length (fldOffset=0x8)" P-INDEP
 ;* V565 tmp525      [V565    ] (  0,   0   )   byref  ->  zero-ref    "field V249._reference (fldOffset=0x0)" P-INDEP
 ;* V566 tmp526      [V566    ] (  0,   0   )     int  ->  zero-ref    "field V249._length (fldOffset=0x8)" P-INDEP
 ;* V567 tmp527      [V567    ] (  0,   0   )   byref  ->  zero-ref    "field V250._reference (fldOffset=0x0)" P-INDEP
@@ -6472,18 +6496,18 @@ G_M53443_IG22:
 ;* V574 tmp534      [V574    ] (  0,   0   )     int  ->  zero-ref    "field V303._length (fldOffset=0x8)" P-INDEP
 ;* V575 tmp535      [V575    ] (  0,   0   )   byref  ->  zero-ref    "field V304._reference (fldOffset=0x0)" P-INDEP
 ;* V576 tmp536      [V576    ] (  0,   0   )     int  ->  zero-ref    "field V304._length (fldOffset=0x8)" P-INDEP
-;  V577 tmp537      [V577,T182] (  2,   0   )   byref  ->  rcx         "field V306._reference (fldOffset=0x0)" P-INDEP
-;  V578 tmp538      [V578,T215] (  2,   0   )     int  ->  rdx         "field V306._length (fldOffset=0x8)" P-INDEP
-;* V579 tmp539      [V579,T222] (  0,   0   )   byref  ->  zero-ref    "field V328._reference (fldOffset=0x0)" P-INDEP
-;* V580 tmp540      [V580,T225] (  0,   0   )     int  ->  zero-ref    "field V328._length (fldOffset=0x8)" P-INDEP
+;  V577 tmp537      [V577,T183] (  2,   0   )   byref  ->  rcx         "field V306._reference (fldOffset=0x0)" P-INDEP
+;  V578 tmp538      [V578,T216] (  2,   0   )     int  ->  rdx         "field V306._length (fldOffset=0x8)" P-INDEP
+;* V579 tmp539      [V579,T223] (  0,   0   )   byref  ->  zero-ref    "field V328._reference (fldOffset=0x0)" P-INDEP
+;* V580 tmp540      [V580,T227] (  0,   0   )     int  ->  zero-ref    "field V328._length (fldOffset=0x8)" P-INDEP
 ;* V581 tmp541      [V581    ] (  0,   0   )   byref  ->  zero-ref    "field V332._reference (fldOffset=0x0)" P-INDEP
 ;* V582 tmp542      [V582    ] (  0,   0   )     int  ->  zero-ref    "field V332._length (fldOffset=0x8)" P-INDEP
 ;* V583 tmp543      [V583    ] (  0,   0   )   byref  ->  zero-ref    "field V334._reference (fldOffset=0x0)" P-INDEP
 ;* V584 tmp544      [V584    ] (  0,   0   )     int  ->  zero-ref    "field V334._length (fldOffset=0x8)" P-INDEP
 ;* V585 tmp545      [V585    ] (  0,   0   )   byref  ->  zero-ref    "field V342._reference (fldOffset=0x0)" P-INDEP
 ;* V586 tmp546      [V586    ] (  0,   0   )     int  ->  zero-ref    "field V342._length (fldOffset=0x8)" P-INDEP
-;  V587 tmp547      [V587,T183] (  2,   0   )   byref  ->  rdx         "field V344._reference (fldOffset=0x0)" P-INDEP
-;  V588 tmp548      [V588,T216] (  2,   0   )     int  ->  rcx         "field V344._length (fldOffset=0x8)" P-INDEP
+;  V587 tmp547      [V587,T184] (  2,   0   )   byref  ->  rdx         "field V344._reference (fldOffset=0x0)" P-INDEP
+;  V588 tmp548      [V588,T217] (  2,   0   )     int  ->  rcx         "field V344._length (fldOffset=0x8)" P-INDEP
 ;* V589 tmp549      [V589    ] (  0,   0   )   byref  ->  zero-ref    "field V347._reference (fldOffset=0x0)" P-INDEP
 ;* V590 tmp550      [V590    ] (  0,   0   )     int  ->  zero-ref    "field V347._length (fldOffset=0x8)" P-INDEP
 ;* V591 tmp551      [V591    ] (  0,   0   )   byref  ->  zero-ref    "field V348._reference (fldOffset=0x0)" P-INDEP
@@ -6496,45 +6520,47 @@ G_M53443_IG22:
 ;* V598 tmp558      [V598    ] (  0,   0   )     int  ->  zero-ref    "field V401._length (fldOffset=0x8)" P-INDEP
 ;* V599 tmp559      [V599    ] (  0,   0   )   byref  ->  zero-ref    "field V402._reference (fldOffset=0x0)" P-INDEP
 ;* V600 tmp560      [V600    ] (  0,   0   )     int  ->  zero-ref    "field V402._length (fldOffset=0x8)" P-INDEP
-;  V601 tmp561      [V601,T184] (  2,   0   )   byref  ->  rcx         "field V403._reference (fldOffset=0x0)" P-INDEP
-;  V602 tmp562      [V602,T217] (  2,   0   )     int  ->  rdx         "field V403._length (fldOffset=0x8)" P-INDEP
-;  V603 tmp563      [V603,T185] (  2,   0   )   byref  ->  rcx         "field V405._reference (fldOffset=0x0)" P-INDEP
-;  V604 tmp564      [V604,T218] (  2,   0   )     int  ->  rdx         "field V405._length (fldOffset=0x8)" P-INDEP
+;  V601 tmp561      [V601,T185] (  2,   0   )   byref  ->  rcx         "field V403._reference (fldOffset=0x0)" P-INDEP
+;  V602 tmp562      [V602,T218] (  2,   0   )     int  ->  rdx         "field V403._length (fldOffset=0x8)" P-INDEP
+;  V603 tmp563      [V603,T186] (  2,   0   )   byref  ->  rcx         "field V405._reference (fldOffset=0x0)" P-INDEP
+;  V604 tmp564      [V604,T219] (  2,   0   )     int  ->  rdx         "field V405._length (fldOffset=0x8)" P-INDEP
 ;* V605 tmp565      [V605    ] (  0,   0   )   byref  ->  zero-ref    "field V406._reference (fldOffset=0x0)" P-INDEP
 ;* V606 tmp566      [V606    ] (  0,   0   )     int  ->  zero-ref    "field V406._length (fldOffset=0x8)" P-INDEP
-;  V607 tmp567      [V607,T39] (  3,   1.21)     ref  ->  rdi         single-def "V18.[000..008)"
-;  V608 tmp568      [V608,T37] (  7,   3.61)     ref  ->  r12         single-def "V18.[008..016)"
-;  V609 tmp569      [V609,T11] (  4, 488.03)     int  ->  r15         "V18.[016..020)"
-;  V610 tmp570      [V610,T40] (  2,   1.20)   ubyte  ->  [rsp+0x9C]  spill-single-def "V18.[020..021)"
-;  V611 tmp571      [V611,T127] (  3,   0   )     ref  ->  [rsp+0x48]  spill-single-def "V26.[000..008)"
-;  V612 tmp572      [V612,T219] (  2,   0   )     int  ->  rcx         "V26.[016..020)"
-;  V613 tmp573      [V613,T30] (  3,   8.66)     ref  ->  [rsp+0x40]  spill-single-def "V32.[000..008)"
-;  V614 tmp574      [V614,T26] (  2,  17.32)     int  ->  rcx         "V32.[016..020)"
+;  V607 tmp567      [V607,T38] (  3,   1.20)     ref  ->  rdi         single-def "V18.[000..008)"
+;  V608 tmp568      [V608,T36] (  7,   3.58)     ref  ->  r12         single-def "V18.[008..016)"
+;  V609 tmp569      [V609,T11] (  4, 485.91)     int  ->  r15         "V18.[016..020)"
+;  V610 tmp570      [V610,T39] (  2,   1.19)   ubyte  ->  [rsp+0xA4]  spill-single-def "V18.[020..021)"
+;  V611 tmp571      [V611,T128] (  3,   0   )     ref  ->  [rsp+0x40]  spill-single-def "V26.[000..008)"
+;  V612 tmp572      [V612,T220] (  2,   0   )     int  ->  rcx         "V26.[016..020)"
+;  V613 tmp573      [V613,T29] (  3,   8.60)     ref  ->  [rsp+0x38]  spill-single-def "V32.[000..008)"
+;  V614 tmp574      [V614,T25] (  2,  17.19)     int  ->  rcx         "V32.[016..020)"
 ;* V615 tmp575      [V615    ] (  0,   0   )     ref  ->  zero-ref    single-def "V43.[000..008)"
 ;* V616 tmp576      [V616    ] (  0,   0   )     ref  ->  zero-ref    single-def "V43.[008..016)"
 ;* V617 tmp577      [V617    ] (  0,   0   )     ref  ->  zero-ref    single-def "V43.[016..024)"
 ;* V618 tmp578      [V618    ] (  0,   0   )     int  ->  zero-ref    "V43.[024..028)"
 ;* V619 tmp579      [V619    ] (  0,   0   )  ushort  ->  zero-ref    "V43.[028..030)"
-;  V620 tmp580      [V620,T186] (  2,   0   )     ref  ->  rdi         single-def "V36.[008..016)"
-;  V621 tmp581      [V621,T187] (  2,   0   )     ref  ->  r15         single-def "V36.[016..024)"
-;  V622 tmp582      [V622,T188] (  2,   0   )     ref  ->  r13         single-def "V36.[024..032)"
-;  V623 tmp583      [V623,T220] (  2,   0   )     int  ->  r12         "V36.[032..036)"
-;  V624 tmp584      [V624,T221] (  2,   0   )  ushort  ->  rax         "V36.[036..038)"
-;  V625 tmp585      [V625,T27] (  5,  12.03)   byref  ->  rcx         single-def "Spilling address for field-by-field copy"
-;  V626 tmp586      [V626,T128] (  3,   0   )   byref  ->  rcx         "Spilling address for field-by-field copy"
-;  V627 tmp587      [V627,T15] (  3,  51.97)   byref  ->  rcx         "Spilling address for field-by-field copy"
-;  V628 tmp588      [V628,T58] (  6,   0   )   byref  ->  rdx         single-def "Spilling address for field-by-field copy"
+;  V620 tmp580      [V620,T187] (  2,   0   )     ref  ->  rdi         single-def "V36.[008..016)"
+;  V621 tmp581      [V621,T188] (  2,   0   )     ref  ->  r15         single-def "V36.[016..024)"
+;  V622 tmp582      [V622,T189] (  2,   0   )     ref  ->  r13         single-def "V36.[024..032)"
+;  V623 tmp583      [V623,T221] (  2,   0   )     int  ->  r12         "V36.[032..036)"
+;  V624 tmp584      [V624,T222] (  2,   0   )  ushort  ->  rax         "V36.[036..038)"
+;  V625 tmp585      [V625,T26] (  5,  11.93)   byref  ->  rcx         single-def "Spilling address for field-by-field copy"
+;  V626 tmp586      [V626,T129] (  3,   0   )   byref  ->  rcx         "Spilling address for field-by-field copy"
+;  V627 tmp587      [V627,T14] (  3,  51.58)   byref  ->  rcx         "Spilling address for field-by-field copy"
+;  V628 tmp588      [V628,T59] (  6,   0   )   byref  ->  rdx         single-def "Spilling address for field-by-field copy"
 ;* V629 tmp589      [V629    ] (  0,   0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V630 tmp590      [V630,T32] (  3,   7.22)     ref  ->  rcx         single-def "arr expr"
-;  V631 tmp591      [V631    ] ( 12,   0   )  struct (16) [rsp+0x88]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V632 tmp592      [V632    ] ( 12,   0   )  struct (16) [rsp+0x78]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V633 tmp593      [V633,T129] (  3,   0   )     ref  ->  rcx         "arr expr"
-;  V634 tmp594      [V634,T16] (  3,  51.97)     ref  ->  rcx         "arr expr"
-;  V635 tmp595      [V635    ] (  3,   0   )  struct (16) [rsp+0x68]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
-;  V636 tmp596      [V636,T35] (  6,   4   )     int  ->  r15         "fgMakeTemp is creating a new local variable"
-;  V637 cse0        [V637,T05] (  3,1460.47)     int  ->   r8         "CSE #43: aggressive"
-;  V638 cse1        [V638,T28] (  9,  10.66)    long  ->  registers   multi-def "CSE #40: moderate"
-;  V639 cse2        [V639,T22] (  3,  25.98)     int  ->   r8         "CSE #44: moderate"
+;  V630 tmp590      [V630,T30] (  3,   7.16)     ref  ->  rcx         single-def "arr expr"
+;  V631 tmp591      [V631    ] ( 12,   0   )  struct (16) [rsp+0x90]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V632 tmp592      [V632    ] ( 12,   0   )  struct (16) [rsp+0x80]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V633 tmp593      [V633,T130] (  3,   0   )     ref  ->  rcx         "arr expr"
+;  V634 tmp594      [V634,T15] (  3,  51.58)     ref  ->  rcx         "arr expr"
+;  V635 tmp595      [V635    ] (  3,   0   )  struct (16) [rsp+0x70]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[ushort]>
+;  V636 tmp596      [V636,T34] (  6,   4   )     int  ->  r15         "fgMakeTemp is creating a new local variable"
+;  V637 cse0        [V637,T05] (  3,1454.15)     int  ->   r8         "CSE #43: aggressive"
+;  V638 cse1        [V638,T27] (  9,  10.60)    long  ->  registers   multi-def "CSE #40: moderate"
+;  V639 cse2        [V639,T21] (  3,  25.79)     int  ->   r8         "CSE #44: moderate"
+;  V640 rat0        [V640,T13] (  8,  70.14)    long  ->  [rsp+0x68]  "Widened IV V31"
+;  V641 rat1        [V641,T55] (  8,   0   )    long  ->  [rsp+0x60]  "Widened IV V25"
 ;
 ; Lcl frame size = 264
 
@@ -6548,19 +6574,18 @@ G_M53443_IG01:
        push     rbp
        push     rbx
        sub      rsp, 264
-       xor      eax, eax
-       mov      qword ptr [rsp+0x68], rax
        vxorps   xmm4, xmm4, xmm4
        vmovdqu  ymmword ptr [rsp+0x70], ymm4
        vmovdqu  ymmword ptr [rsp+0x90], ymm4
        vmovdqu  ymmword ptr [rsp+0xB0], ymm4
        vmovdqu  ymmword ptr [rsp+0xD0], ymm4
        vmovdqa  xmmword ptr [rsp+0xF0], xmm4
+       xor      eax, eax
        mov      qword ptr [rsp+0x100], rax
        mov      rbx, rcx
        mov      rsi, r8
        mov      edi, r9d
-						;; size=89 bbWeight=1 PerfScore 21.58
+						;; size=84 bbWeight=1 PerfScore 20.58
 G_M53443_IG02:
        mov      rbp, bword ptr [rdx]
        mov      r14d, dword ptr [rdx+0x08]
@@ -6568,72 +6593,72 @@ G_M53443_IG02:
        mov      edx, r14d
        sub      edx, dword ptr [rbx+0x2C]
        cmp      ecx, edx
-       jg       G_M53443_IG133
+       jg       G_M53443_IG135
        cmp      byte  ptr [rbx+0x31], 14
-       je       G_M53443_IG24
+       je       G_M53443_IG26
 						;; size=33 bbWeight=1 PerfScore 14.50
 G_M53443_IG03:
        mov      r15d, dword ptr [rbx+0x28]
        cmp      r15d, 20
-       jne      G_M53443_IG25
+       jne      G_M53443_IG27
 						;; size=14 bbWeight=1 PerfScore 3.25
 G_M53443_IG04:
        mov      r13, gword ptr [rbx+0x20]
        cmp      dword ptr [r13+0x10], 0
-       je       G_M53443_IG100
+       je       G_M53443_IG103
        mov      rcx, gword ptr [r13+0x08]
        cmp      dword ptr [rcx+0x08], 0
-       jbe      G_M53443_IG23
+       jbe      G_M53443_IG25
        add      rcx, 16
        mov      rdi, gword ptr [rcx]
        mov      r12, gword ptr [rcx+0x08]
        mov      r15d, dword ptr [rcx+0x10]
        movzx    rax, byte  ptr [rcx+0x14]
-       mov      dword ptr [rsp+0x9C], eax
+       mov      dword ptr [rsp+0xA4], eax
        mov      r10d, dword ptr [rbx+0x2C]
        cmp      r10d, 1
-       jle      G_M53443_IG69
-						;; size=69 bbWeight=1.20 PerfScore 29.48
+       jle      G_M53443_IG71
+						;; size=69 bbWeight=1.19 PerfScore 29.22
 G_M53443_IG05:
        mov      r9d, r14d
        sub      r9d, r10d
        mov      dword ptr [rsp+0xE4], r9d
        test     r12, r12
        je       SHORT G_M53443_IG07
-						;; size=19 bbWeight=1.20 PerfScore 3.31
+						;; size=19 bbWeight=1.19 PerfScore 3.28
 G_M53443_IG06:
        cmp      dword ptr [r12+0x08], 5
-       jle      G_M53443_IG70
-						;; size=12 bbWeight=1.20 PerfScore 4.81
+       jle      G_M53443_IG72
+						;; size=12 bbWeight=1.19 PerfScore 4.77
 G_M53443_IG07:
        mov      rcx, gword ptr [rbx+0x08]
        xor      edx, edx
        mov      r12, 0xD1FFAB1E      ; <unknown class>
        mov      r8, r12
        call     CORINFO_HELP_LDELEMA_REF
-       mov      bword ptr [rsp+0x60], rax
+       mov      bword ptr [rsp+0x58], rax
        mov      r10d, dword ptr [rsi]
        cmp      r10d, dword ptr [rsp+0xE4]
-       jg       G_M53443_IG133
+       jg       G_M53443_IG135
 						;; size=46 bbWeight=1 PerfScore 9.75
 G_M53443_IG08:
-       mov      dword ptr [rsp+0xD8], r10d
+       mov      dword ptr [rsp+0xDC], r10d
        lea      ecx, [r10+r15]
        cmp      ecx, r14d
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        movzx    r11, word  ptr [rbp+2*rcx]
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M53443_IG10
+       je       SHORT G_M53443_IG11
        mov      edx, r11d
        sar      edx, 4
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, edx
-       jbe      SHORT G_M53443_IG10
-						;; size=50 bbWeight=486.83 PerfScore 5841.92
+       jbe      SHORT G_M53443_IG11
+						;; size=50 bbWeight=484.72 PerfScore 5816.63
 G_M53443_IG09:
        cmp      edx, r8d
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        mov      edx, edx
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r11d
@@ -6642,75 +6667,67 @@ G_M53443_IG09:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG10
+       je       SHORT G_M53443_IG11
        add      edx, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG12
-       jmp      SHORT G_M53443_IG13
-						;; size=46 bbWeight=486.82 PerfScore 4746.46
+       je       G_M53443_IG21
+						;; size=48 bbWeight=484.71 PerfScore 3756.48
 G_M53443_IG10:
+       jmp      SHORT G_M53443_IG13
+						;; size=2 bbWeight=6.97 PerfScore 13.94
+G_M53443_IG11:
        cmp      r11d, 128
-       jl       G_M53443_IG99
+       jl       G_M53443_IG101
        mov      ecx, r11d
        mov      rdx, rdi
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
-						;; size=28 bbWeight=0.01 PerfScore 0.05
-G_M53443_IG11:
-       test     eax, eax
-       jne      SHORT G_M53443_IG13
-						;; size=4 bbWeight=486.83 PerfScore 608.53
+						;; size=28 bbWeight=0.01 PerfScore 0.06
 G_M53443_IG12:
-       mov      r9d, dword ptr [rsp+0xD8]
-       inc      r9d
-       mov      r10d, dword ptr [rsp+0xE4]
-       cmp      r9d, r10d
-       jg       G_M53443_IG133
-       mov      r10d, r9d
-       mov      rax, bword ptr [rsp+0x60]
-       jmp      G_M53443_IG08
-						;; size=41 bbWeight=486.83 PerfScore 3286.08
+       test     eax, eax
+       je       G_M53443_IG21
+						;; size=8 bbWeight=0.01 PerfScore 0.02
 G_M53443_IG13:
        mov      eax, 1
        cmp      dword ptr [r13+0x10], 1
-       jle      G_M53443_IG20
-						;; size=16 bbWeight=7.02 PerfScore 29.82
+       jle      G_M53443_IG22
+						;; size=16 bbWeight=6.97 PerfScore 29.62
 G_M53443_IG14:
        cmp      eax, dword ptr [r13+0x10]
-       jae      G_M53443_IG100
+       jae      G_M53443_IG103
        mov      rcx, gword ptr [r13+0x08]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M53443_IG23
-       mov      edx, eax
+       jae      G_M53443_IG25
+       mov      rdx, rax
        shl      rdx, 5
        lea      rcx, bword ptr [rcx+rdx+0x10]
        mov      r10, gword ptr [rcx]
-       mov      gword ptr [rsp+0x40], r10
+       mov      gword ptr [rsp+0x38], r10
        mov      ecx, dword ptr [rcx+0x10]
-       mov      r9d, dword ptr [rsp+0xD8]
+       mov      r9d, dword ptr [rsp+0xDC]
        add      ecx, r9d
        cmp      ecx, r14d
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        movzx    r11, word  ptr [rbp+2*rcx]
-       mov      dword ptr [rsp+0xD4], r11d
+       mov      dword ptr [rsp+0xD8], r11d
        mov      rcx, gword ptr [rbx+0x08]
-       mov      dword ptr [rsp+0xD0], eax
+       mov      qword ptr [rsp+0x68], rax
        movsxd   rdx, eax
        mov      r8, r12
        call     CORINFO_HELP_LDELEMA_REF
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
        je       SHORT G_M53443_IG17
-       mov      r10d, dword ptr [rsp+0xD4]
+       mov      r10d, dword ptr [rsp+0xD8]
        mov      edx, r10d
        sar      edx, 4
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, edx
        jbe      SHORT G_M53443_IG16
-						;; size=132 bbWeight=8.66 PerfScore 303.14
+						;; size=131 bbWeight=8.60 PerfScore 300.87
 G_M53443_IG15:
        cmp      edx, r8d
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        mov      edx, edx
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r10d
@@ -6719,43 +6736,58 @@ G_M53443_IG15:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       mov      dword ptr [rsp+0xD4], r10d
+       mov      dword ptr [rsp+0xD8], r10d
        je       SHORT G_M53443_IG17
        add      edx, edx
        test     ecx, edx
-       je       G_M53443_IG12
+       je       SHORT G_M53443_IG21
+       mov      r11, qword ptr [rsp+0x68]
        jmp      SHORT G_M53443_IG19
-						;; size=58 bbWeight=8.66 PerfScore 93.11
+						;; size=59 bbWeight=8.60 PerfScore 101.00
 G_M53443_IG16:
-       mov      dword ptr [rsp+0xD4], r10d
-						;; size=8 bbWeight=4.33 PerfScore 4.33
+       mov      dword ptr [rsp+0xD8], r10d
+						;; size=8 bbWeight=4.30 PerfScore 4.30
 G_M53443_IG17:
-       mov      r10d, dword ptr [rsp+0xD4]
+       mov      r10d, dword ptr [rsp+0xD8]
        cmp      r10d, 128
-       jl       G_M53443_IG101
+       jl       G_M53443_IG102
        mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x40]
+       mov      rdx, gword ptr [rsp+0x38]
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
 						;; size=38 bbWeight=0.00 PerfScore 0.00
 G_M53443_IG18:
        test     eax, eax
-       je       G_M53443_IG12
-						;; size=8 bbWeight=8.66 PerfScore 10.83
+       je       SHORT G_M53443_IG21
+						;; size=4 bbWeight=0.00 PerfScore 0.00
 G_M53443_IG19:
-       mov      eax, dword ptr [rsp+0xD0]
+       mov      rax, qword ptr [rsp+0x68]
        inc      eax
-       cmp      eax, dword ptr [r13+0x10]
+       mov      r10, rax
+       cmp      r10d, dword ptr [r13+0x10]
+       mov      rax, r10
        jl       G_M53443_IG14
-						;; size=19 bbWeight=9.66 PerfScore 50.72
+						;; size=23 bbWeight=9.60 PerfScore 55.18
 G_M53443_IG20:
-       mov      r9d, dword ptr [rsp+0xD8]
-       mov      dword ptr [rsi], r9d
-						;; size=11 bbWeight=1 PerfScore 2.00
+       jmp      SHORT G_M53443_IG22
+						;; size=2 bbWeight=1 PerfScore 2.00
 G_M53443_IG21:
+       mov      r10d, dword ptr [rsp+0xDC]
+       inc      r10d
+       mov      r9d, dword ptr [rsp+0xE4]
+       cmp      r10d, r9d
+       jg       G_M53443_IG135
+       mov      rax, bword ptr [rsp+0x58]
+       jmp      G_M53443_IG08
+						;; size=38 bbWeight=484.72 PerfScore 3150.68
+G_M53443_IG22:
+       mov      r10d, dword ptr [rsp+0xDC]
+       mov      dword ptr [rsi], r10d
+						;; size=11 bbWeight=1 PerfScore 2.00
+G_M53443_IG23:
        mov      eax, 1
 						;; size=5 bbWeight=1 PerfScore 0.25
-G_M53443_IG22:
+G_M53443_IG24:
        add      rsp, 264
        pop      rbx
        pop      rbp
@@ -6767,10 +6799,10 @@ G_M53443_IG22:
        pop      r15
        ret      
 						;; size=20 bbWeight=1 PerfScore 5.25
-G_M53443_IG23:
+G_M53443_IG25:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG24:
+G_M53443_IG26:
        mov      edx, dword ptr [rsi]
        dec      edx
        cmp      edx, r14d
@@ -6779,7 +6811,7 @@ G_M53443_IG24:
        je       G_M53443_IG03
        mov      edx, dword ptr [rsi]
        cmp      edx, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      ecx, edx
        lea      rcx, bword ptr [rbp+2*rcx]
        mov      r8d, r14d
@@ -6791,7 +6823,7 @@ G_M53443_IG24:
        movsxd   rcx, ecx
        mov      edx, eax
        cmp      rcx, rdx
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      eax, dword ptr [rsi]
        inc      eax
        mov      dword ptr [rsi], eax
@@ -6799,14 +6831,14 @@ G_M53443_IG24:
        mov      edx, r14d
        sub      edx, dword ptr [rbx+0x2C]
        cmp      ecx, edx
-       jg       G_M53443_IG133
+       jg       G_M53443_IG135
        mov      r15d, dword ptr [rbx+0x28]
        cmp      r15d, 20
        je       G_M53443_IG04
 						;; size=116 bbWeight=0 PerfScore 0.00
-G_M53443_IG25:
+G_M53443_IG27:
        cmp      r15d, 21
-       ja       G_M53443_IG21
+       ja       G_M53443_IG23
        mov      ecx, r15d
        lea      rdx, [reloc @RWD00]
        mov      edx, dword ptr [rdx+4*rcx]
@@ -6814,118 +6846,118 @@ G_M53443_IG25:
        add      rdx, r8
        jmp      rdx
 						;; size=35 bbWeight=0 PerfScore 0.00
-G_M53443_IG26:
-       cmp      dword ptr [rsi], 0
-       jne      G_M53443_IG133
-       jmp      G_M53443_IG21
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M53443_IG27:
-       cmp      dword ptr [rsi], edi
-       jne      G_M53443_IG133
-       jmp      G_M53443_IG21
-						;; size=13 bbWeight=0 PerfScore 0.00
 G_M53443_IG28:
+       cmp      dword ptr [rsi], 0
+       jne      G_M53443_IG135
+       jmp      G_M53443_IG23
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M53443_IG29:
+       cmp      dword ptr [rsi], edi
+       jne      G_M53443_IG135
+       jmp      G_M53443_IG23
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M53443_IG30:
        lea      ecx, [r14-0x01]
        cmp      dword ptr [rsi], ecx
-       jge      G_M53443_IG21
+       jge      G_M53443_IG23
        dec      r14d
        mov      dword ptr [rsi], r14d
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M53443_IG29:
+G_M53443_IG31:
        cmp      dword ptr [rsi], r14d
-       jge      G_M53443_IG21
+       jge      G_M53443_IG23
        mov      dword ptr [rsi], r14d
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M53443_IG30:
+G_M53443_IG32:
        mov      ecx, dword ptr [rsi]
        mov      edx, r14d
        sub      edx, dword ptr [rbx+0x2C]
        dec      edx
        cmp      ecx, edx
-       jge      G_M53443_IG21
+       jge      G_M53443_IG23
        mov      ecx, r14d
        sub      ecx, dword ptr [rbx+0x2C]
        dec      ecx
        mov      dword ptr [rsi], ecx
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M53443_IG31:
+G_M53443_IG33:
        mov      ecx, dword ptr [rsi]
        mov      edx, r14d
        sub      edx, dword ptr [rbx+0x2C]
        cmp      ecx, edx
-       jge      G_M53443_IG21
+       jge      G_M53443_IG23
        mov      ecx, r14d
        sub      ecx, dword ptr [rbx+0x2C]
        mov      dword ptr [rsi], ecx
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M53443_IG32:
+G_M53443_IG34:
        mov      ecx, dword ptr [rsi]
        cmp      ecx, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      edx, ecx
        lea      rdx, bword ptr [rbp+2*rdx]
        mov      r8d, r14d
        sub      r8d, ecx
        mov      rcx, gword ptr [rbx+0x10]
        test     rcx, rcx
-       jne      SHORT G_M53443_IG33
+       jne      SHORT G_M53443_IG35
        xor      r9, r9
        xor      eax, eax
-       jmp      SHORT G_M53443_IG34
+       jmp      SHORT G_M53443_IG36
 						;; size=40 bbWeight=0 PerfScore 0.00
-G_M53443_IG33:
+G_M53443_IG35:
        lea      r9, bword ptr [rcx+0x0C]
        mov      eax, dword ptr [rcx+0x08]
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG34:
+G_M53443_IG36:
        mov      rcx, rdx
        mov      edx, r8d
        mov      r8, r9
        mov      r9d, eax
        call     [<unknown method>]
        test     eax, eax
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      dword ptr [rsi], eax
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M53443_IG35:
+G_M53443_IG37:
        mov      ecx, dword ptr [rsi]
        cmp      ecx, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      edx, ecx
        lea      rdx, bword ptr [rbp+2*rdx]
        mov      r8d, r14d
        sub      r8d, ecx
        mov      rcx, gword ptr [rbx+0x10]
        test     rcx, rcx
-       jne      SHORT G_M53443_IG36
+       jne      SHORT G_M53443_IG38
        xor      rax, rax
        xor      r10d, r10d
-       jmp      SHORT G_M53443_IG37
+       jmp      SHORT G_M53443_IG39
 						;; size=40 bbWeight=0 PerfScore 0.00
-G_M53443_IG36:
+G_M53443_IG38:
        lea      rax, bword ptr [rcx+0x0C]
        mov      r10d, dword ptr [rcx+0x08]
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M53443_IG37:
-       mov      bword ptr [rsp+0x88], rdx
-       mov      dword ptr [rsp+0x90], r8d
-       mov      bword ptr [rsp+0x78], rax
-       mov      dword ptr [rsp+0x80], r10d
-       lea      rcx, [rsp+0x88]
-       lea      rdx, [rsp+0x78]
+G_M53443_IG39:
+       mov      bword ptr [rsp+0x90], rdx
+       mov      dword ptr [rsp+0x98], r8d
+       mov      bword ptr [rsp+0x80], rax
+       mov      dword ptr [rsp+0x88], r10d
+       lea      rcx, [rsp+0x90]
+       lea      rdx, [rsp+0x80]
        mov      r8d, 5
        call     [System.MemoryExtensions:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort],int):int]
        test     eax, eax
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      dword ptr [rsi], eax
-       jmp      G_M53443_IG21
-						;; size=69 bbWeight=0 PerfScore 0.00
-G_M53443_IG38:
+       jmp      G_M53443_IG23
+						;; size=75 bbWeight=0 PerfScore 0.00
+G_M53443_IG40:
        mov      rcx, gword ptr [rbx+0x20]
        lea      rdx, [rsp+0xE8]
        xor      r8d, r8d
@@ -6934,7 +6966,7 @@ G_M53443_IG38:
        mov      r12, gword ptr [rsp+0xF0]
        mov      ecx, dword ptr [rsi]
        cmp      ecx, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      edx, ecx
        lea      rax, bword ptr [rbp+2*rdx]
        mov      r9d, r14d
@@ -6943,15 +6975,15 @@ G_M53443_IG38:
        mov      rbp, rcx
        mov      r13d, r9d
        test     r12, r12
-       je       G_M53443_IG56
+       je       G_M53443_IG58
        cmp      dword ptr [r12+0x08], 5
-       jg       G_M53443_IG56
+       jg       G_M53443_IG58
        cmp      byte  ptr [rsp+0xFC], 0
-       jne      G_M53443_IG54
+       jne      G_M53443_IG56
        lea      rdi, bword ptr [r12+0x10]
        mov      eax, dword ptr [r12+0x08]
        cmp      eax, 5
-       ja       G_M53443_IG52
+       ja       G_M53443_IG54
        mov      edx, eax
        lea      r8, [reloc @RWD88]
        mov      r8d, dword ptr [r8+4*rdx]
@@ -6959,43 +6991,43 @@ G_M53443_IG38:
        add      r8, rax
        jmp      r8
 						;; size=144 bbWeight=0 PerfScore 0.00
-G_M53443_IG39:
+G_M53443_IG41:
        mov      eax, -1
-       jmp      G_M53443_IG53
+       jmp      G_M53443_IG55
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M53443_IG40:
+G_M53443_IG42:
        movsx    rdx, word  ptr [rdi]
        movzx    r8, dx
        dec      r8d
        cmp      r8d, 254
-       jae      SHORT G_M53443_IG41
+       jae      SHORT G_M53443_IG43
        mov      r8d, r9d
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG42
+       jmp      SHORT G_M53443_IG44
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M53443_IG41:
+G_M53443_IG43:
        mov      r8d, r9d
        call     [<unknown method>]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M53443_IG42:
-       jmp      G_M53443_IG53
+G_M53443_IG44:
+       jmp      G_M53443_IG55
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG43:
+G_M53443_IG45:
        movsx    rdx, word  ptr [rdi]
        movsx    r8, word  ptr [rdi+0x02]
        movzx    rax, dx
        dec      eax
        cmp      eax, 254
-       jae      SHORT G_M53443_IG45
+       jae      SHORT G_M53443_IG47
        movzx    rax, r8w
        dec      eax
        cmp      eax, 254
-       jae      SHORT G_M53443_IG45
+       jae      SHORT G_M53443_IG47
        movzx    rax, dx
        movzx    r10, r8w
        xor      eax, r10d
        cmp      eax, 32
-       jne      SHORT G_M53443_IG44
+       jne      SHORT G_M53443_IG46
        movzx    rdx, dx
        movzx    r8, r8w
        cmp      edx, r8d
@@ -7003,50 +7035,50 @@ G_M53443_IG43:
        movsx    rdx, dx
        mov      r8d, r9d
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG46
+       jmp      SHORT G_M53443_IG48
 						;; size=78 bbWeight=0 PerfScore 0.00
-G_M53443_IG44:
+G_M53443_IG46:
        movsx    r8, r8w
        movsx    rdx, dx
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG46
+       jmp      SHORT G_M53443_IG48
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M53443_IG45:
+G_M53443_IG47:
        call     [<unknown method>]
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M53443_IG46:
-       jmp      G_M53443_IG53
+G_M53443_IG48:
+       jmp      G_M53443_IG55
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG47:
+G_M53443_IG49:
        movsx    rdx, word  ptr [rdi]
        movsx    r8, word  ptr [rdi+0x02]
        movsx    rax, word  ptr [rdi+0x04]
        movzx    r10, dx
        dec      r10d
        cmp      r10d, 254
-       jae      SHORT G_M53443_IG48
+       jae      SHORT G_M53443_IG50
        movzx    r10, r8w
        dec      r10d
        cmp      r10d, 254
-       jae      SHORT G_M53443_IG48
+       jae      SHORT G_M53443_IG50
        movzx    r10, ax
        dec      r10d
        cmp      r10d, 254
-       jae      SHORT G_M53443_IG48
+       jae      SHORT G_M53443_IG50
        mov      dword ptr [rsp+0x20], r9d
        movsx    r9, ax
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG49
+       jmp      SHORT G_M53443_IG51
 						;; size=79 bbWeight=0 PerfScore 0.00
-G_M53443_IG48:
+G_M53443_IG50:
        mov      dword ptr [rsp+0x20], r9d
        mov      r9d, eax
        call     [<unknown method>]
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M53443_IG49:
-       jmp      SHORT G_M53443_IG53
+G_M53443_IG51:
+       jmp      SHORT G_M53443_IG55
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M53443_IG50:
+G_M53443_IG52:
        movsx    rdx, word  ptr [rdi+0x06]
        mov      dword ptr [rsp+0x20], edx
        mov      dword ptr [rsp+0x28], r9d
@@ -7054,9 +7086,9 @@ G_M53443_IG50:
        movsx    r8, word  ptr [rdi+0x02]
        movsx    r9, word  ptr [rdi+0x04]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG53
+       jmp      SHORT G_M53443_IG55
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M53443_IG51:
+G_M53443_IG53:
        movsx    rdx, word  ptr [rdi+0x06]
        mov      dword ptr [rsp+0x20], edx
        movsx    rdx, word  ptr [rdi+0x08]
@@ -7066,36 +7098,36 @@ G_M53443_IG51:
        movsx    r8, word  ptr [rdi+0x02]
        movsx    r9, word  ptr [rdi+0x04]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG53
+       jmp      SHORT G_M53443_IG55
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M53443_IG52:
+G_M53443_IG54:
        mov      edx, r9d
        mov      r8, rdi
        mov      r9d, eax
        call     [System.Buffers.ProbabilisticMap:IndexOfAny(byref,int,byref,int):int]
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M53443_IG53:
-       jmp      SHORT G_M53443_IG55
+G_M53443_IG55:
+       jmp      SHORT G_M53443_IG57
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M53443_IG54:
+G_M53443_IG56:
        mov      edx, r9d
        lea      rax, bword ptr [r12+0x10]
        mov      r8d, dword ptr [r12+0x08]
-       mov      bword ptr [rsp+0x88], rcx
-       mov      dword ptr [rsp+0x90], edx
-       mov      bword ptr [rsp+0x78], rax
-       mov      dword ptr [rsp+0x80], r8d
-       lea      rcx, [rsp+0x88]
-       lea      rdx, [rsp+0x78]
+       mov      bword ptr [rsp+0x90], rcx
+       mov      dword ptr [rsp+0x98], edx
+       mov      bword ptr [rsp+0x80], rax
+       mov      dword ptr [rsp+0x88], r8d
+       lea      rcx, [rsp+0x90]
+       lea      rdx, [rsp+0x80]
        call     [System.MemoryExtensions:IndexOfAnyExcept[ushort](System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int]
-						;; size=60 bbWeight=0 PerfScore 0.00
-G_M53443_IG55:
+						;; size=66 bbWeight=0 PerfScore 0.00
+G_M53443_IG57:
        test     eax, eax
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      dword ptr [rsi], eax
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M53443_IG56:
+G_M53443_IG58:
        mov      rcx, gword ptr [rbx+0x08]
        xor      edx, edx
        mov      r12, 0xD1FFAB1E      ; <unknown class>
@@ -7103,21 +7135,21 @@ G_M53443_IG56:
        call     CORINFO_HELP_LDELEMA_REF
        mov      rbx, rax
        xor      edi, edi
-       jmp      G_M53443_IG61
+       jmp      G_M53443_IG63
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M53443_IG57:
+G_M53443_IG59:
        cmp      edi, r13d
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        mov      ecx, edi
        movzx    rcx, word  ptr [rbp+2*rcx]
        mov      rdx, gword ptr [rsp+0xE8]
        mov      r8, gword ptr [rbx]
        test     r8, r8
-       je       SHORT G_M53443_IG58
+       je       SHORT G_M53443_IG60
        mov      eax, ecx
        sar      eax, 4
        cmp      dword ptr [r8+0x08], eax
-       jbe      SHORT G_M53443_IG58
+       jbe      SHORT G_M53443_IG60
        mov      r8d, dword ptr [r8+4*rax+0x10]
        mov      eax, ecx
        and      eax, 15
@@ -7125,46 +7157,46 @@ G_M53443_IG57:
        mov      r10d, 1
        shlx     eax, r10d, eax
        test     r8d, eax
-       je       SHORT G_M53443_IG58
+       je       SHORT G_M53443_IG60
        add      eax, eax
        xor      r15d, r15d
        test     r8d, eax
        setne    r15b
-       jmp      SHORT G_M53443_IG60
+       jmp      SHORT G_M53443_IG62
 						;; size=85 bbWeight=0 PerfScore 0.00
-G_M53443_IG58:
+G_M53443_IG60:
        cmp      ecx, 128
-       jl       SHORT G_M53443_IG59
+       jl       SHORT G_M53443_IG61
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r15d, eax
-       jmp      SHORT G_M53443_IG60
+       jmp      SHORT G_M53443_IG62
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M53443_IG59:
+G_M53443_IG61:
        mov      r8, rbx
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
        mov      r15d, eax
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M53443_IG60:
+G_M53443_IG62:
        test     r15d, r15d
-       jne      SHORT G_M53443_IG62
+       jne      SHORT G_M53443_IG64
        inc      edi
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG61:
-       cmp      edi, r13d
-       jl       G_M53443_IG57
-       jmp      G_M53443_IG133
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M53443_IG62:
-       add      dword ptr [rsi], edi
-       jmp      G_M53443_IG21
-						;; size=7 bbWeight=0 PerfScore 0.00
 G_M53443_IG63:
+       cmp      edi, r13d
+       jl       G_M53443_IG59
+       jmp      G_M53443_IG135
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M53443_IG64:
+       add      dword ptr [rsi], edi
+       jmp      G_M53443_IG23
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M53443_IG65:
        mov      edx, dword ptr [rsi]
        mov      ecx, dword ptr [rbx+0x48]
        add      edx, ecx
        cmp      edx, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      ecx, edx
        lea      rcx, bword ptr [rbp+2*rcx]
        mov      r8d, r14d
@@ -7174,63 +7206,63 @@ G_M53443_IG63:
        movzx    rax, dx
        dec      eax
        cmp      eax, 254
-       jae      SHORT G_M53443_IG64
+       jae      SHORT G_M53443_IG66
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG65
+       jmp      SHORT G_M53443_IG67
 						;; size=57 bbWeight=0 PerfScore 0.00
-G_M53443_IG64:
+G_M53443_IG66:
        call     [<unknown method>]
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M53443_IG65:
+G_M53443_IG67:
        test     eax, eax
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      dword ptr [rsi], eax
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M53443_IG66:
+G_M53443_IG68:
        mov      ecx, dword ptr [rsi]
        mov      edx, dword ptr [rbx+0x48]
        add      ecx, edx
        cmp      ecx, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      edx, ecx
        lea      rdx, bword ptr [rbp+2*rdx]
        mov      r8d, r14d
        sub      r8d, ecx
        mov      rcx, gword ptr [rbx+0x40]
        test     rcx, rcx
-       jne      SHORT G_M53443_IG67
+       jne      SHORT G_M53443_IG69
        xor      r9, r9
        xor      eax, eax
-       jmp      SHORT G_M53443_IG68
+       jmp      SHORT G_M53443_IG70
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M53443_IG67:
+G_M53443_IG69:
        lea      r9, bword ptr [rcx+0x0C]
        mov      eax, dword ptr [rcx+0x08]
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG68:
+G_M53443_IG70:
        mov      rcx, rdx
        mov      edx, r8d
        mov      r8, r9
        mov      r9d, eax
        call     [<unknown method>]
        test     eax, eax
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      dword ptr [rsi], eax
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M53443_IG69:
+G_M53443_IG71:
        mov      r10d, 1
        jmp      G_M53443_IG05
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M53443_IG70:
+G_M53443_IG72:
        mov      edi, dword ptr [rsi]
-       jmp      G_M53443_IG97
+       jmp      G_M53443_IG99
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG71:
+G_M53443_IG73:
        add      edi, r15d
        cmp      edi, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      ecx, edi
        lea      rcx, bword ptr [rbp+2*rcx]
        mov      r10d, r14d
@@ -7238,131 +7270,131 @@ G_M53443_IG71:
        mov      r11, rcx
        mov      r8d, r10d
        test     eax, eax
-       jne      G_M53443_IG89
+       jne      G_M53443_IG91
        lea      r11, bword ptr [r12+0x10]
        mov      edx, dword ptr [r12+0x08]
-       mov      dword ptr [rsp+0xA0], edx
+       mov      dword ptr [rsp+0xA8], edx
        cmp      edx, 5
-       ja       G_M53443_IG87
+       ja       G_M53443_IG89
        mov      gword ptr [rsp+0x150], rbx
-       mov      edx, dword ptr [rsp+0xA0]
+       mov      edx, dword ptr [rsp+0xA8]
        lea      r8, [reloc @RWD112]
        mov      r8d, dword ptr [r8+4*rdx]
        lea      rbx, G_M53443_IG02
        add      r8, rbx
        jmp      r8
 						;; size=104 bbWeight=0 PerfScore 0.00
-G_M53443_IG72:
+G_M53443_IG74:
        mov      r8d, -1
        mov      eax, r8d
        mov      rbx, gword ptr [rsp+0x150]
-       jmp      G_M53443_IG88
+       jmp      G_M53443_IG90
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M53443_IG73:
+G_M53443_IG75:
        movsx    rdx, word  ptr [r11]
        movzx    r8, dx
        dec      r8d
        cmp      r8d, 254
-       jae      SHORT G_M53443_IG74
+       jae      SHORT G_M53443_IG76
        mov      r8d, r10d
        call     [<unknown method>]
        mov      r8d, eax
-       jmp      SHORT G_M53443_IG75
+       jmp      SHORT G_M53443_IG77
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M53443_IG74:
+G_M53443_IG76:
        mov      r8d, r10d
        call     [<unknown method>]
        mov      r8d, eax
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M53443_IG75:
+G_M53443_IG77:
        mov      eax, r8d
        mov      rbx, gword ptr [rsp+0x150]
-       jmp      G_M53443_IG88
+       jmp      G_M53443_IG90
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M53443_IG76:
+G_M53443_IG78:
        movsx    rdx, word  ptr [r11]
        movsx    r8, word  ptr [r11+0x02]
        movzx    r11, dx
        dec      r11d
        cmp      r11d, 254
-       jae      SHORT G_M53443_IG80
+       jae      SHORT G_M53443_IG82
        movzx    r11, r8w
        dec      r11d
        cmp      r11d, 254
-       jae      SHORT G_M53443_IG80
+       jae      SHORT G_M53443_IG82
        movzx    r11, dx
        movzx    rbx, r8w
        xor      r11d, ebx
        cmp      r11d, 32
-       jne      SHORT G_M53443_IG79
+       jne      SHORT G_M53443_IG81
        movzx    rdx, dx
        movzx    r8, r8w
        cmp      edx, r8d
-       jge      SHORT G_M53443_IG77
-       jmp      SHORT G_M53443_IG78
+       jge      SHORT G_M53443_IG79
+       jmp      SHORT G_M53443_IG80
 						;; size=72 bbWeight=0 PerfScore 0.00
-G_M53443_IG77:
+G_M53443_IG79:
        mov      r8d, edx
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M53443_IG78:
+G_M53443_IG80:
        movsx    rdx, r8w
        mov      r8d, r10d
        call     [<unknown method>]
        mov      r8d, eax
-       jmp      SHORT G_M53443_IG81
+       jmp      SHORT G_M53443_IG83
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M53443_IG79:
+G_M53443_IG81:
        movsx    r8, r8w
        movsx    rdx, dx
        mov      r9d, r10d
        call     [<unknown method>]
        mov      r8d, eax
-       jmp      SHORT G_M53443_IG81
+       jmp      SHORT G_M53443_IG83
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M53443_IG80:
+G_M53443_IG82:
        mov      r9d, r10d
        call     [<unknown method>]
        mov      r8d, eax
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M53443_IG81:
+G_M53443_IG83:
        mov      eax, r8d
        mov      rbx, gword ptr [rsp+0x150]
-       jmp      G_M53443_IG88
+       jmp      G_M53443_IG90
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M53443_IG82:
+G_M53443_IG84:
        movsx    rdx, word  ptr [r11]
        movsx    r8, word  ptr [r11+0x02]
        movsx    r11, word  ptr [r11+0x04]
        movzx    rbx, dx
        dec      ebx
        cmp      ebx, 254
-       jae      SHORT G_M53443_IG83
+       jae      SHORT G_M53443_IG85
        movzx    rbx, r8w
        dec      ebx
        cmp      ebx, 254
-       jae      SHORT G_M53443_IG83
+       jae      SHORT G_M53443_IG85
        movzx    rbx, r11w
        dec      ebx
        cmp      ebx, 254
-       jae      SHORT G_M53443_IG83
+       jae      SHORT G_M53443_IG85
        mov      dword ptr [rsp+0x20], r10d
        movsx    r9, r11w
        call     [<unknown method>]
        mov      r8d, eax
-       jmp      SHORT G_M53443_IG84
+       jmp      SHORT G_M53443_IG86
 						;; size=75 bbWeight=0 PerfScore 0.00
-G_M53443_IG83:
+G_M53443_IG85:
        mov      dword ptr [rsp+0x20], r10d
        mov      r9d, r11d
        call     [<unknown method>]
        mov      r8d, eax
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M53443_IG84:
+G_M53443_IG86:
        mov      eax, r8d
        mov      rbx, gword ptr [rsp+0x150]
-       jmp      SHORT G_M53443_IG88
+       jmp      SHORT G_M53443_IG90
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M53443_IG85:
+G_M53443_IG87:
        movsx    rdx, word  ptr [r11+0x06]
        mov      dword ptr [rsp+0x20], edx
        mov      dword ptr [rsp+0x28], r10d
@@ -7371,9 +7403,9 @@ G_M53443_IG85:
        movsx    r9, word  ptr [r11+0x04]
        call     [<unknown method>]
        mov      rbx, gword ptr [rsp+0x150]
-       jmp      SHORT G_M53443_IG88
+       jmp      SHORT G_M53443_IG90
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M53443_IG86:
+G_M53443_IG88:
        movsx    rdx, word  ptr [r11+0x06]
        mov      dword ptr [rsp+0x20], edx
        movsx    rdx, word  ptr [r11+0x08]
@@ -7384,69 +7416,69 @@ G_M53443_IG86:
        movsx    r9, word  ptr [r11+0x04]
        call     [<unknown method>]
        mov      rbx, gword ptr [rsp+0x150]
-       jmp      SHORT G_M53443_IG88
+       jmp      SHORT G_M53443_IG90
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M53443_IG87:
+G_M53443_IG89:
        mov      edx, r10d
        mov      r8, r11
-       mov      r9d, dword ptr [rsp+0xA0]
+       mov      r9d, dword ptr [rsp+0xA8]
        call     [System.Buffers.ProbabilisticMap:IndexOfAny(byref,int,byref,int):int]
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M53443_IG88:
-       jmp      SHORT G_M53443_IG90
+G_M53443_IG90:
+       jmp      SHORT G_M53443_IG92
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M53443_IG89:
+G_M53443_IG91:
        lea      rcx, bword ptr [r12+0x10]
        mov      edx, dword ptr [r12+0x08]
-       mov      bword ptr [rsp+0x88], r11
-       mov      dword ptr [rsp+0x90], r8d
-       mov      bword ptr [rsp+0x78], rcx
-       mov      dword ptr [rsp+0x80], edx
-       lea      rcx, [rsp+0x88]
-       lea      rdx, [rsp+0x78]
+       mov      bword ptr [rsp+0x90], r11
+       mov      dword ptr [rsp+0x98], r8d
+       mov      bword ptr [rsp+0x80], rcx
+       mov      dword ptr [rsp+0x88], edx
+       lea      rcx, [rsp+0x90]
+       lea      rdx, [rsp+0x80]
        call     [System.MemoryExtensions:IndexOfAnyExcept[ushort](System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort]):int]
-						;; size=57 bbWeight=0 PerfScore 0.00
-G_M53443_IG90:
+						;; size=63 bbWeight=0 PerfScore 0.00
+G_M53443_IG92:
        test     eax, eax
-       jl       G_M53443_IG133
+       jl       G_M53443_IG135
        add      edi, eax
        sub      edi, r15d
        mov      eax, dword ptr [rsp+0xE4]
        cmp      edi, eax
-       jg       G_M53443_IG133
+       jg       G_M53443_IG135
        mov      r10d, 1
-       jmp      G_M53443_IG95
+       jmp      G_M53443_IG97
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M53443_IG91:
+G_M53443_IG93:
        cmp      r10d, dword ptr [r13+0x10]
-       jae      G_M53443_IG100
+       jae      G_M53443_IG103
        mov      rcx, gword ptr [r13+0x08]
        cmp      r10d, dword ptr [rcx+0x08]
-       jae      G_M53443_IG23
-       mov      edx, r10d
+       jae      G_M53443_IG25
+       mov      rdx, r10
        shl      rdx, 5
        lea      rcx, bword ptr [rcx+rdx+0x10]
        mov      r9, gword ptr [rcx]
-       mov      gword ptr [rsp+0x48], r9
+       mov      gword ptr [rsp+0x40], r9
        mov      ecx, dword ptr [rcx+0x10]
        add      ecx, edi
        cmp      ecx, r14d
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        movzx    r11, word  ptr [rbp+2*rcx]
-       mov      dword ptr [rsp+0xDC], r11d
+       mov      dword ptr [rsp+0xE0], r11d
        mov      rcx, gword ptr [rbx+0x08]
-       mov      dword ptr [rsp+0xE0], r10d
+       mov      qword ptr [rsp+0x60], r10
        movsxd   rdx, r10d
        mov      r8, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_LDELEMA_REF
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M53443_IG92
-       mov      r10d, dword ptr [rsp+0xDC]
+       je       SHORT G_M53443_IG94
+       mov      r10d, dword ptr [rsp+0xE0]
        mov      edx, r10d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M53443_IG92
+       jbe      SHORT G_M53443_IG94
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r10d
        and      edx, 15
@@ -7454,76 +7486,77 @@ G_M53443_IG91:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG92
+       je       SHORT G_M53443_IG94
        add      edx, edx
        xor      r9d, r9d
        test     ecx, edx
        setne    r9b
-       jmp      SHORT G_M53443_IG94
-						;; size=169 bbWeight=0 PerfScore 0.00
-G_M53443_IG92:
-       mov      r10d, dword ptr [rsp+0xDC]
+       jmp      SHORT G_M53443_IG96
+						;; size=166 bbWeight=0 PerfScore 0.00
+G_M53443_IG94:
+       mov      r10d, dword ptr [rsp+0xE0]
        cmp      r10d, 128
-       jl       SHORT G_M53443_IG93
+       jl       SHORT G_M53443_IG95
        mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x48]
+       mov      rdx, gword ptr [rsp+0x40]
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r9d, eax
-       jmp      SHORT G_M53443_IG94
+       jmp      SHORT G_M53443_IG96
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M53443_IG93:
-       mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x48]
-       mov      r8, rax
-       call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
-       mov      r9d, eax
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M53443_IG94:
-       test     r9d, r9d
-       je       SHORT G_M53443_IG96
-       mov      r10d, dword ptr [rsp+0xE0]
-       inc      r10d
-						;; size=16 bbWeight=0 PerfScore 0.00
 G_M53443_IG95:
-       cmp      r10d, dword ptr [r13+0x10]
-       jl       G_M53443_IG91
-       jmp      SHORT G_M53443_IG98
-						;; size=12 bbWeight=0 PerfScore 0.00
-G_M53443_IG96:
-       inc      edi
-       mov      eax, dword ptr [rsp+0x9C]
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M53443_IG97:
-       mov      r9d, dword ptr [rsp+0xE4]
-       cmp      edi, r9d
-       jle      G_M53443_IG71
-       jmp      G_M53443_IG133
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M53443_IG98:
-       mov      dword ptr [rsi], edi
-       jmp      G_M53443_IG21
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG99:
-       mov      rax, bword ptr [rsp+0x60]
-       mov      ecx, r11d
-       mov      rdx, rdi
-       mov      r8, rax
-       call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
-       jmp      G_M53443_IG11
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M53443_IG100:
-       call     [System.ThrowHelper:ThrowArgumentOutOfRange_IndexMustBeLessException()]
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG101:
        mov      ecx, r10d
        mov      rdx, gword ptr [rsp+0x40]
        mov      r8, rax
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
+       mov      r9d, eax
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M53443_IG96:
+       test     r9d, r9d
+       je       SHORT G_M53443_IG98
+       mov      rcx, qword ptr [rsp+0x60]
+       inc      ecx
+       mov      r10, rcx
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M53443_IG97:
+       cmp      r10d, dword ptr [r13+0x10]
+       jl       G_M53443_IG93
+       jmp      SHORT G_M53443_IG100
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M53443_IG98:
+       inc      edi
+       mov      eax, dword ptr [rsp+0xA4]
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M53443_IG99:
+       mov      r9d, dword ptr [rsp+0xE4]
+       cmp      edi, r9d
+       jle      G_M53443_IG73
+       jmp      G_M53443_IG135
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M53443_IG100:
+       mov      dword ptr [rsi], edi
+       jmp      G_M53443_IG23
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M53443_IG101:
+       mov      rax, bword ptr [rsp+0x58]
+       mov      ecx, r11d
+       mov      rdx, rdi
+       mov      r8, rax
+       call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
+       jmp      G_M53443_IG12
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M53443_IG102:
+       mov      ecx, r10d
+       mov      rdx, gword ptr [rsp+0x38]
+       mov      r8, rax
+       call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
        jmp      G_M53443_IG18
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M53443_IG102:
+G_M53443_IG103:
+       call     [System.ThrowHelper:ThrowArgumentOutOfRange_IndexMustBeLessException()]
+       int3     
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M53443_IG104:
        lea      rdx, bword ptr [rbx+0x50]
        mov      rdi, gword ptr [rdx+0x08]
        mov      r15, gword ptr [rdx+0x10]
@@ -7532,254 +7565,254 @@ G_M53443_IG102:
        movzx    rax, word  ptr [rdx+0x24]
        mov      r10d, dword ptr [rsi]
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M53443_IG103:
+G_M53443_IG105:
        cmp      r10d, r14d
-       ja       G_M53443_IG131
+       ja       G_M53443_IG133
        mov      edx, r10d
        lea      r9, bword ptr [rbp+2*rdx]
-       mov      dword ptr [rsp+0xCC], r10d
+       mov      dword ptr [rsp+0xD4], r10d
        mov      r11d, r14d
        sub      r11d, r10d
        test     r15, r15
-       jne      G_M53443_IG124
+       jne      G_M53443_IG126
        test     r13, r13
-       jne      SHORT G_M53443_IG106
-       mov      dword ptr [rsp+0xA8], eax
+       jne      SHORT G_M53443_IG108
+       mov      dword ptr [rsp+0xB0], eax
        movzx    rdx, ax
        movsx    rdx, dx
        movzx    rcx, dx
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG104
-       mov      bword ptr [rsp+0x50], r9
+       jae      SHORT G_M53443_IG106
+       mov      bword ptr [rsp+0x48], r9
        mov      rcx, r9
-       mov      dword ptr [rsp+0xA4], r11d
+       mov      dword ptr [rsp+0xAC], r11d
        mov      r8d, r11d
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG105
+       jmp      SHORT G_M53443_IG107
 						;; size=99 bbWeight=0 PerfScore 0.00
-G_M53443_IG104:
-       mov      bword ptr [rsp+0x50], r9
+G_M53443_IG106:
+       mov      bword ptr [rsp+0x48], r9
        mov      rcx, r9
-       mov      dword ptr [rsp+0xA4], r11d
+       mov      dword ptr [rsp+0xAC], r11d
        mov      r8d, r11d
        call     [<unknown method>]
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M53443_IG105:
-       jmp      G_M53443_IG125
+G_M53443_IG107:
+       jmp      G_M53443_IG127
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG106:
-       mov      dword ptr [rsp+0xA4], r11d
-       mov      bword ptr [rsp+0x50], r9
-       mov      dword ptr [rsp+0xA8], eax
+G_M53443_IG108:
+       mov      dword ptr [rsp+0xAC], r11d
+       mov      bword ptr [rsp+0x48], r9
+       mov      dword ptr [rsp+0xB0], eax
        lea      rdx, bword ptr [r13+0x10]
        mov      ecx, dword ptr [r13+0x08]
-       mov      bword ptr [rsp+0x68], rdx
-       mov      dword ptr [rsp+0x70], ecx
-       lea      rdx, [rsp+0x68]
-       lea      rcx, [rsp+0xB0]
+       mov      bword ptr [rsp+0x70], rdx
+       mov      dword ptr [rsp+0x78], ecx
+       lea      rdx, [rsp+0x70]
+       lea      rcx, [rsp+0xB8]
        call     [System.Span`1[ushort]:op_Implicit(System.Span`1[ushort]):System.ReadOnlySpan`1[ushort]]
-       cmp      dword ptr [rsp+0xB8], 5
-       ja       G_M53443_IG122
-       mov      edx, dword ptr [rsp+0xB8]
+       cmp      dword ptr [rsp+0xC0], 5
+       ja       G_M53443_IG124
+       mov      edx, dword ptr [rsp+0xC0]
        lea      rcx, [reloc @RWD136]
        mov      ecx, dword ptr [rcx+4*rdx]
        lea      r8, G_M53443_IG02
        add      rcx, r8
        jmp      rcx
 						;; size=99 bbWeight=0 PerfScore 0.00
-G_M53443_IG107:
+G_M53443_IG109:
        mov      eax, -1
-       jmp      G_M53443_IG123
+       jmp      G_M53443_IG125
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M53443_IG108:
-       mov      rdx, bword ptr [rsp+0xB0]
+G_M53443_IG110:
+       mov      rdx, bword ptr [rsp+0xB8]
        movsx    rdx, word  ptr [rdx]
        movzx    rcx, dx
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG109
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      r8d, dword ptr [rsp+0xA4]
+       jae      SHORT G_M53443_IG111
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      r8d, dword ptr [rsp+0xAC]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG110
+       jmp      SHORT G_M53443_IG112
 						;; size=46 bbWeight=0 PerfScore 0.00
-G_M53443_IG109:
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      r8d, dword ptr [rsp+0xA4]
+G_M53443_IG111:
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      r8d, dword ptr [rsp+0xAC]
        call     [<unknown method>]
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M53443_IG110:
-       jmp      G_M53443_IG123
+G_M53443_IG112:
+       jmp      G_M53443_IG125
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG111:
-       mov      rdx, bword ptr [rsp+0xB0]
+G_M53443_IG113:
+       mov      rdx, bword ptr [rsp+0xB8]
        movsx    rdx, word  ptr [rdx]
-       mov      rcx, bword ptr [rsp+0xB0]
+       mov      rcx, bword ptr [rsp+0xB8]
        movsx    r8, word  ptr [rcx+0x02]
        movzx    rcx, dx
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG115
+       jae      SHORT G_M53443_IG117
        movzx    rcx, r8w
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG115
+       jae      SHORT G_M53443_IG117
        movzx    rcx, dx
        movzx    rax, r8w
        xor      ecx, eax
        cmp      ecx, 32
-       jne      SHORT G_M53443_IG114
+       jne      SHORT G_M53443_IG116
        movzx    rdx, dx
        movzx    rcx, r8w
        cmp      edx, ecx
-       jge      SHORT G_M53443_IG112
-       jmp      SHORT G_M53443_IG113
+       jge      SHORT G_M53443_IG114
+       jmp      SHORT G_M53443_IG115
 						;; size=79 bbWeight=0 PerfScore 0.00
-G_M53443_IG112:
+G_M53443_IG114:
        mov      ecx, edx
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M53443_IG113:
+G_M53443_IG115:
        movsx    rdx, cx
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      r8d, dword ptr [rsp+0xA4]
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      r8d, dword ptr [rsp+0xAC]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG116
+       jmp      SHORT G_M53443_IG118
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M53443_IG114:
+G_M53443_IG116:
        movsx    r8, r8w
        movsx    rdx, dx
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      r9d, dword ptr [rsp+0xA4]
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      r9d, dword ptr [rsp+0xAC]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG116
+       jmp      SHORT G_M53443_IG118
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M53443_IG115:
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      r9d, dword ptr [rsp+0xA4]
+G_M53443_IG117:
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      r9d, dword ptr [rsp+0xAC]
        call     [<unknown method>]
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M53443_IG116:
-       jmp      G_M53443_IG123
+G_M53443_IG118:
+       jmp      G_M53443_IG125
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG117:
-       mov      r9, bword ptr [rsp+0xB0]
+G_M53443_IG119:
+       mov      r9, bword ptr [rsp+0xB8]
        movsx    rdx, word  ptr [r9]
-       mov      r9, bword ptr [rsp+0xB0]
+       mov      r9, bword ptr [rsp+0xB8]
        movsx    r8, word  ptr [r9+0x02]
-       mov      r9, bword ptr [rsp+0xB0]
+       mov      r9, bword ptr [rsp+0xB8]
        movsx    r9, word  ptr [r9+0x04]
        movzx    rcx, dx
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG118
+       jae      SHORT G_M53443_IG120
        movzx    rcx, r8w
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG118
+       jae      SHORT G_M53443_IG120
        movzx    rcx, r9w
        dec      ecx
        cmp      ecx, 254
-       jae      SHORT G_M53443_IG118
-       mov      r10d, dword ptr [rsp+0xA4]
+       jae      SHORT G_M53443_IG120
+       mov      r10d, dword ptr [rsp+0xAC]
        mov      dword ptr [rsp+0x20], r10d
-       mov      rcx, bword ptr [rsp+0x50]
+       mov      rcx, bword ptr [rsp+0x48]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG119
+       jmp      SHORT G_M53443_IG121
 						;; size=105 bbWeight=0 PerfScore 0.00
-G_M53443_IG118:
-       mov      r10d, dword ptr [rsp+0xA4]
+G_M53443_IG120:
+       mov      r10d, dword ptr [rsp+0xAC]
        mov      dword ptr [rsp+0x20], r10d
-       mov      rcx, bword ptr [rsp+0x50]
+       mov      rcx, bword ptr [rsp+0x48]
        call     [<unknown method>]
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M53443_IG119:
-       jmp      G_M53443_IG123
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG120:
-       mov      rdx, bword ptr [rsp+0xB0]
-       movsx    rdx, word  ptr [rdx+0x06]
-       mov      dword ptr [rsp+0x20], edx
-       mov      r10d, dword ptr [rsp+0xA4]
-       mov      dword ptr [rsp+0x28], r10d
-       mov      rdx, bword ptr [rsp+0xB0]
-       movsx    rdx, word  ptr [rdx]
-       mov      r8, bword ptr [rsp+0xB0]
-       movsx    r8, word  ptr [r8+0x02]
-       mov      r9, bword ptr [rsp+0xB0]
-       movsx    r9, word  ptr [r9+0x04]
-       mov      rcx, bword ptr [rsp+0x50]
-       call     [<unknown method>]
-       jmp      G_M53443_IG123
-						;; size=84 bbWeight=0 PerfScore 0.00
 G_M53443_IG121:
-       mov      rdx, bword ptr [rsp+0xB0]
+       jmp      G_M53443_IG125
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M53443_IG122:
+       mov      rdx, bword ptr [rsp+0xB8]
        movsx    rdx, word  ptr [rdx+0x06]
        mov      dword ptr [rsp+0x20], edx
-       mov      rdx, bword ptr [rsp+0xB0]
+       mov      r10d, dword ptr [rsp+0xAC]
+       mov      dword ptr [rsp+0x28], r10d
+       mov      rdx, bword ptr [rsp+0xB8]
+       movsx    rdx, word  ptr [rdx]
+       mov      r8, bword ptr [rsp+0xB8]
+       movsx    r8, word  ptr [r8+0x02]
+       mov      r9, bword ptr [rsp+0xB8]
+       movsx    r9, word  ptr [r9+0x04]
+       mov      rcx, bword ptr [rsp+0x48]
+       call     [<unknown method>]
+       jmp      G_M53443_IG125
+						;; size=84 bbWeight=0 PerfScore 0.00
+G_M53443_IG123:
+       mov      rdx, bword ptr [rsp+0xB8]
+       movsx    rdx, word  ptr [rdx+0x06]
+       mov      dword ptr [rsp+0x20], edx
+       mov      rdx, bword ptr [rsp+0xB8]
        movsx    rdx, word  ptr [rdx+0x08]
        mov      dword ptr [rsp+0x28], edx
-       mov      r10d, dword ptr [rsp+0xA4]
+       mov      r10d, dword ptr [rsp+0xAC]
        mov      dword ptr [rsp+0x30], r10d
-       mov      rdx, bword ptr [rsp+0xB0]
+       mov      rdx, bword ptr [rsp+0xB8]
        movsx    rdx, word  ptr [rdx]
-       mov      r8, bword ptr [rsp+0xB0]
+       mov      r8, bword ptr [rsp+0xB8]
        movsx    r8, word  ptr [r8+0x02]
-       mov      r9, bword ptr [rsp+0xB0]
+       mov      r9, bword ptr [rsp+0xB8]
        movsx    r9, word  ptr [r9+0x04]
-       mov      rcx, bword ptr [rsp+0x50]
+       mov      rcx, bword ptr [rsp+0x48]
        call     [<unknown method>]
-       jmp      SHORT G_M53443_IG123
+       jmp      SHORT G_M53443_IG125
 						;; size=98 bbWeight=0 PerfScore 0.00
-G_M53443_IG122:
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      edx, dword ptr [rsp+0xA4]
-       mov      r8, bword ptr [rsp+0xB0]
-       mov      r9d, dword ptr [rsp+0xB8]
+G_M53443_IG124:
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      edx, dword ptr [rsp+0xAC]
+       mov      r8, bword ptr [rsp+0xB8]
+       mov      r9d, dword ptr [rsp+0xC0]
        call     [System.Buffers.ProbabilisticMap:IndexOfAny(byref,int,byref,int):int]
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M53443_IG123:
-       jmp      SHORT G_M53443_IG125
+G_M53443_IG125:
+       jmp      SHORT G_M53443_IG127
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M53443_IG124:
-       mov      dword ptr [rsp+0xA8], eax
+G_M53443_IG126:
+       mov      dword ptr [rsp+0xB0], eax
        lea      rcx, bword ptr [r15+0x0C]
        mov      edx, dword ptr [r15+0x08]
-       mov      bword ptr [rsp+0x50], r9
-       mov      bword ptr [rsp+0x88], r9
-       mov      dword ptr [rsp+0xA4], r11d
-       mov      dword ptr [rsp+0x90], r11d
-       mov      bword ptr [rsp+0x78], rcx
-       mov      dword ptr [rsp+0x80], edx
-       lea      rcx, [rsp+0x88]
-       lea      rdx, [rsp+0x78]
+       mov      bword ptr [rsp+0x48], r9
+       mov      bword ptr [rsp+0x90], r9
+       mov      dword ptr [rsp+0xAC], r11d
+       mov      dword ptr [rsp+0x98], r11d
+       mov      bword ptr [rsp+0x80], rcx
+       mov      dword ptr [rsp+0x88], edx
+       lea      rcx, [rsp+0x90]
+       lea      rdx, [rsp+0x80]
        mov      r8d, r12d
        call     [System.MemoryExtensions:IndexOf(System.ReadOnlySpan`1[ushort],System.ReadOnlySpan`1[ushort],int):int]
-						;; size=78 bbWeight=0 PerfScore 0.00
-G_M53443_IG125:
+						;; size=84 bbWeight=0 PerfScore 0.00
+G_M53443_IG127:
        test     eax, eax
-       jl       G_M53443_IG133
-       mov      r9, bword ptr [rsp+0x50]
-       mov      r10d, dword ptr [rsp+0xA4]
-       mov      dword ptr [rsp+0xC8], eax
+       jl       G_M53443_IG135
+       mov      r9, bword ptr [rsp+0x48]
+       mov      r10d, dword ptr [rsp+0xAC]
+       mov      dword ptr [rsp+0xD0], eax
        mov      edx, eax
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M53443_IG126:
+G_M53443_IG128:
        lea      ecx, [rdx-0x01]
-       mov      dword ptr [rsp+0xC0], ecx
+       mov      dword ptr [rsp+0xC8], ecx
        mov      edx, ecx
        cmp      edx, r10d
-       jae      G_M53443_IG130
-       mov      dword ptr [rsp+0xA4], r10d
-       cmp      edx, r10d
-       jae      G_M53443_IG23
-       mov      dword ptr [rsp+0xC4], edx
-       mov      r10d, edx
-       mov      bword ptr [rsp+0x50], r9
-       movzx    r10, word  ptr [r9+2*r10]
+       jae      G_M53443_IG132
        mov      dword ptr [rsp+0xAC], r10d
+       cmp      edx, r10d
+       jae      G_M53443_IG25
+       mov      dword ptr [rsp+0xCC], edx
+       mov      r10d, edx
+       mov      bword ptr [rsp+0x48], r9
+       movzx    r10, word  ptr [r9+2*r10]
+       mov      dword ptr [rsp+0xB4], r10d
        mov      r9, gword ptr [rdi+0x10]
-       mov      gword ptr [rsp+0x58], r9
+       mov      gword ptr [rsp+0x50], r9
        mov      rcx, gword ptr [rbx+0x08]
        xor      edx, edx
        mov      r11, 0xD1FFAB1E      ; <unknown class>
@@ -7787,14 +7820,14 @@ G_M53443_IG126:
        call     CORINFO_HELP_LDELEMA_REF
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M53443_IG127
-       mov      r10d, dword ptr [rsp+0xAC]
+       je       SHORT G_M53443_IG129
+       mov      r10d, dword ptr [rsp+0xB4]
        mov      edx, r10d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M53443_IG127
+       jbe      SHORT G_M53443_IG129
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M53443_IG23
+       jae      G_M53443_IG25
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r10d
        and      edx, 15
@@ -7802,68 +7835,68 @@ G_M53443_IG126:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M53443_IG127
+       je       SHORT G_M53443_IG129
        add      edx, edx
        xor      r9d, r9d
        test     ecx, edx
        setne    r9b
-       jmp      SHORT G_M53443_IG129
+       jmp      SHORT G_M53443_IG131
 						;; size=175 bbWeight=0 PerfScore 0.00
-G_M53443_IG127:
-       mov      r10d, dword ptr [rsp+0xAC]
+G_M53443_IG129:
+       mov      r10d, dword ptr [rsp+0xB4]
        cmp      r10d, 128
-       jl       SHORT G_M53443_IG128
+       jl       SHORT G_M53443_IG130
        mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x58]
+       mov      rdx, gword ptr [rsp+0x50]
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r9d, eax
-       jmp      SHORT G_M53443_IG129
+       jmp      SHORT G_M53443_IG131
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M53443_IG128:
+G_M53443_IG130:
        mov      ecx, r10d
-       mov      rdx, gword ptr [rsp+0x58]
+       mov      rdx, gword ptr [rsp+0x50]
        mov      r8, rax
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|128_0(ushort,System.String,byref):ubyte]
        mov      r9d, eax
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M53443_IG129:
+G_M53443_IG131:
        test     r9d, r9d
-       mov      edx, dword ptr [rsp+0xC4]
-       mov      r9, bword ptr [rsp+0x50]
-       mov      r10d, dword ptr [rsp+0xA4]
-       jne      G_M53443_IG126
+       mov      edx, dword ptr [rsp+0xCC]
+       mov      r9, bword ptr [rsp+0x48]
+       mov      r10d, dword ptr [rsp+0xAC]
+       jne      G_M53443_IG128
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M53443_IG130:
-       mov      eax, dword ptr [rsp+0xC8]
-       mov      ecx, dword ptr [rsp+0xC0]
+G_M53443_IG132:
+       mov      eax, dword ptr [rsp+0xD0]
+       mov      ecx, dword ptr [rsp+0xC8]
        mov      edx, eax
        sub      edx, ecx
        dec      edx
        cmp      edx, dword ptr [rdi+0x20]
-       jge      SHORT G_M53443_IG132
-       mov      r11d, dword ptr [rsp+0xCC]
+       jge      SHORT G_M53443_IG134
+       mov      r11d, dword ptr [rsp+0xD4]
        lea      r11d, [r11+rax+0x01]
        mov      r10d, r11d
-       movzx    rax, word  ptr [rsp+0xA8]
-       jmp      G_M53443_IG103
+       movzx    rax, word  ptr [rsp+0xB0]
+       jmp      G_M53443_IG105
 						;; size=54 bbWeight=0 PerfScore 0.00
-G_M53443_IG131:
+G_M53443_IG133:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M53443_IG132:
-       mov      r11d, dword ptr [rsp+0xCC]
+G_M53443_IG134:
+       mov      r11d, dword ptr [rsp+0xD4]
        add      ecx, r11d
        inc      ecx
        mov      dword ptr [rsi], ecx
-       jmp      G_M53443_IG21
+       jmp      G_M53443_IG23
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M53443_IG133:
+G_M53443_IG135:
        mov      dword ptr [rsi], r14d
        xor      eax, eax
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M53443_IG134:
+G_M53443_IG136:
        add      rsp, 264
        pop      rbx
        pop      rbp
@@ -7875,49 +7908,49 @@ G_M53443_IG134:
        pop      r15
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-RWD00  	dd	G_M53443_IG26 - G_M53443_IG02
-       	dd	G_M53443_IG27 - G_M53443_IG02
-       	dd	G_M53443_IG28 - G_M53443_IG02
+RWD00  	dd	G_M53443_IG28 - G_M53443_IG02
        	dd	G_M53443_IG29 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG31 - G_M53443_IG02
        	dd	G_M53443_IG30 - G_M53443_IG02
+       	dd	G_M53443_IG31 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG33 - G_M53443_IG02
        	dd	G_M53443_IG32 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG35 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG38 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG21 - G_M53443_IG02
-       	dd	G_M53443_IG63 - G_M53443_IG02
-       	dd	G_M53443_IG66 - G_M53443_IG02
-       	dd	G_M53443_IG04 - G_M53443_IG02
-       	dd	G_M53443_IG102 - G_M53443_IG02
-RWD88  	dd	G_M53443_IG39 - G_M53443_IG02
+       	dd	G_M53443_IG34 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG37 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
        	dd	G_M53443_IG40 - G_M53443_IG02
-       	dd	G_M53443_IG43 - G_M53443_IG02
-       	dd	G_M53443_IG47 - G_M53443_IG02
-       	dd	G_M53443_IG50 - G_M53443_IG02
-       	dd	G_M53443_IG51 - G_M53443_IG02
-RWD112 	dd	G_M53443_IG72 - G_M53443_IG02
-       	dd	G_M53443_IG73 - G_M53443_IG02
-       	dd	G_M53443_IG76 - G_M53443_IG02
-       	dd	G_M53443_IG82 - G_M53443_IG02
-       	dd	G_M53443_IG85 - G_M53443_IG02
-       	dd	G_M53443_IG86 - G_M53443_IG02
-RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
-       	dd	G_M53443_IG108 - G_M53443_IG02
-       	dd	G_M53443_IG111 - G_M53443_IG02
-       	dd	G_M53443_IG117 - G_M53443_IG02
-       	dd	G_M53443_IG120 - G_M53443_IG02
-       	dd	G_M53443_IG121 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG23 - G_M53443_IG02
+       	dd	G_M53443_IG65 - G_M53443_IG02
+       	dd	G_M53443_IG68 - G_M53443_IG02
+       	dd	G_M53443_IG04 - G_M53443_IG02
+       	dd	G_M53443_IG104 - G_M53443_IG02
+RWD88  	dd	G_M53443_IG41 - G_M53443_IG02
+       	dd	G_M53443_IG42 - G_M53443_IG02
+       	dd	G_M53443_IG45 - G_M53443_IG02
+       	dd	G_M53443_IG49 - G_M53443_IG02
+       	dd	G_M53443_IG52 - G_M53443_IG02
+       	dd	G_M53443_IG53 - G_M53443_IG02
+RWD112 	dd	G_M53443_IG74 - G_M53443_IG02
+       	dd	G_M53443_IG75 - G_M53443_IG02
+       	dd	G_M53443_IG78 - G_M53443_IG02
+       	dd	G_M53443_IG84 - G_M53443_IG02
+       	dd	G_M53443_IG87 - G_M53443_IG02
+       	dd	G_M53443_IG88 - G_M53443_IG02
+RWD136 	dd	G_M53443_IG109 - G_M53443_IG02
+       	dd	G_M53443_IG110 - G_M53443_IG02
+       	dd	G_M53443_IG113 - G_M53443_IG02
+       	dd	G_M53443_IG119 - G_M53443_IG02
+       	dd	G_M53443_IG122 - G_M53443_IG02
+       	dd	G_M53443_IG123 - G_M53443_IG02
 
 
-; Total bytes of code 4504, prolog size 89, PerfScore 15069.18, instruction count 1069, allocated bytes for code 4504 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1)
+; Total bytes of code 4526, prolog size 84, PerfScore 13323.63, instruction count 1072, allocated bytes for code 4526 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
@@ -7928,13 +7961,13 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 4354.09
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 4268.49
 ; 42 inlinees with PGO data; 144 single block inlinees; 7 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T26] (  3,   91.63)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
-;  V01 arg1         [V01,T30] (  5,    9   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 arg2         [V02,T29] (  4,   12.37)   byref  ->  rsi         single-def
+;  V00 this         [V00,T25] (  3,   91.59)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexFindOptimizations>
+;  V01 arg1         [V01,T28] (  5,    9   )   byref  ->  rdx         ld-addr-op single-def
+;  V02 arg2         [V02,T27] (  4,   12.41)   byref  ->  rsi         single-def
 ;* V03 arg3         [V03    ] (  0,    0   )     int  ->  zero-ref    single-def
 ;* V04 loc0         [V04    ] (  0,    0   )     int  ->  zero-ref   
 ;* V05 loc1         [V05    ] (  0,    0   )     int  ->  zero-ref   
@@ -7943,15 +7976,15 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ;* V08 loc4         [V08    ] (  0,    0   )     int  ->  zero-ref   
 ;* V09 loc5         [V09    ] (  0,    0   )  struct (32) zero-ref    do-not-enreg[XS] addr-exposed <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V10 loc6         [V10    ] (  0,    0   )     ref  ->  zero-ref    class-hnd <ushort[]>
-;  V11 loc7         [V11,T33] (  1,    1   )  struct (16) [rsp+0x588]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V11 loc7         [V11,T31] (  1,    1   )  struct (16) [rsp+0x588]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V12 loc8         [V12    ] (  0,    0   )     int  ->  zero-ref   
 ;* V13 loc9         [V13    ] (  0,    0   )   byref  ->  zero-ref   
 ;* V14 loc10        [V14    ] (  0,    0   )     int  ->  zero-ref   
 ;* V15 loc11        [V15    ] (  0,    0   )     int  ->  zero-ref   
 ;* V16 loc12        [V16    ] (  0,    0   )     int  ->  zero-ref   
-;  V17 loc13        [V17,T20] (  4,  352.06)     ref  ->  rbp         class-hnd <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
-;  V18 loc14        [V18,T31] (  2,    2   )  struct (32) [rsp+0x540]  do-not-enreg[SF] tier0-frame <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
-;  V19 loc15        [V19,T13] (  1, 5033.84)     int  ->  [rsp+0x53C]  tier0-frame
+;  V17 loc13        [V17,T19] (  4,  351.91)     ref  ->  rbp         class-hnd <System.Collections.Generic.List`1[System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet]>
+;  V18 loc14        [V18,T29] (  2,    2   )  struct (32) [rsp+0x540]  do-not-enreg[SF] tier0-frame <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
+;  V19 loc15        [V19,T12] (  1, 5054.01)     int  ->  [rsp+0x53C]  tier0-frame
 ;* V20 loc16        [V20    ] (  0,    0   )     ref  ->  zero-ref    class-hnd <ushort[]>
 ;* V21 loc17        [V21    ] (  0,    0   )     int  ->  zero-ref   
 ;* V22 loc18        [V22    ] (  0,    0   )     int  ->  zero-ref   
@@ -7960,16 +7993,16 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ;* V25 loc21        [V25    ] (  0,    0   )     int  ->  zero-ref   
 ;* V26 loc22        [V26    ] (  0,    0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V27 loc23        [V27    ] (  0,    0   )  ushort  ->  zero-ref   
-;  V28 loc24        [V28,T12] (  2, 5033.84)   byref  ->  rdi        
-;  V29 loc25        [V29,T01] (  6,20235.35)     int  ->  [rsp+0x4DC]  tier0-frame
-;  V30 loc26        [V30,T03] ( 12,15370.52)  ushort  ->  [rsp+0x4D8]  tier0-frame
-;  V31 loc27        [V31,T14] (  9,  804.12)     int  ->  [rsp+0x4D4]  tier0-frame
+;  V28 loc24        [V28,T11] (  2, 5054.01)   byref  ->  rdi        
+;  V29 loc25        [V29,T01] (  6,20316.04)     int  ->  [rsp+0x4DC]  tier0-frame
+;  V30 loc26        [V30,T03] ( 12,15430.94)  ushort  ->  [rsp+0x4D8]  tier0-frame
+;  V31 loc27        [V31,T13] (  9,  803.82)     int  ->  [rsp+0x4D4]  tier0-frame
 ;* V32 loc28        [V32    ] (  0,    0   )  struct (32) zero-ref    do-not-enreg[SF] <System.Text.RegularExpressions.RegexFindOptimizations+FixedDistanceSet>
 ;* V33 loc29        [V33    ] (  0,    0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.RegexNode>
 ;* V34 loc30        [V34    ] (  0,    0   )  struct (24) zero-ref    <System.ValueTuple`4[ushort,System.String,int,ushort[]]>
 ;* V35 loc31        [V35    ] (  0,    0   )     int  ->  zero-ref   
-;  V36 loc32        [V36,T34] (  1,    1   )  struct (40) [rsp+0x460]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
-;  V37 loc33        [V37,T35] (  1,    1   )  struct (16) [rsp+0x450]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
+;  V36 loc32        [V36,T32] (  1,    1   )  struct (40) [rsp+0x460]  do-not-enreg[S] ld-addr-op tier0-frame <System.Nullable`1[System.ValueTuple`2[System.Text.RegularExpressions.RegexNode,System.ValueTuple`4[ushort,System.String,int,ushort[]]]]>
+;  V37 loc33        [V37,T33] (  1,    1   )  struct (16) [rsp+0x450]  do-not-enreg[SF] ld-addr-op tier0-frame <System.ReadOnlySpan`1[ushort]>
 ;* V38 loc34        [V38    ] (  0,    0   )     int  ->  zero-ref   
 ;* V39 loc35        [V39    ] (  0,    0   )     int  ->  zero-ref   
 ;  V40 OutArgs      [V40    ] (  1,    1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -7985,7 +8018,7 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ;* V50 tmp10        [V50    ] (  0,    0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[ushort]>
 ;* V51 tmp11        [V51    ] (  0,    0   )  struct (16) zero-ref    do-not-enreg[HS] hidden-struct-arg "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V52 tmp12        [V52    ] (  0,    0   )     int  ->  zero-ref    "impAppendStmt"
-;  V53 tmp13        [V53,T00] (  3,30203.02)     int  ->  rcx         "Span.get_Item index"
+;  V53 tmp13        [V53,T00] (  3,30324.06)     int  ->  rcx         "Span.get_Item index"
 ;* V54 tmp14        [V54    ] (  0,    0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V55 tmp15        [V55    ] (  0,    0   )     int  ->  zero-ref   
 ;* V56 tmp16        [V56    ] (  0,    0   )     int  ->  zero-ref    "Span.get_Item index"
@@ -8017,7 +8050,7 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ;* V82 tmp42        [V82    ] (  0,    0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;* V83 tmp43        [V83    ] (  0,    0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V84 tmp44        [V84    ] (  0,    0   )     int  ->  zero-ref    "impAppendStmt"
-;  V85 tmp45        [V85,T17] (  3,  537.80)     int  ->  rcx         "Span.get_Item index"
+;  V85 tmp45        [V85,T16] (  3,  537.57)     int  ->  rcx         "Span.get_Item index"
 ;* V86 tmp46        [V86    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V87 tmp47        [V87    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V88 tmp48        [V88    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -8247,19 +8280,19 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ;* V312 tmp272      [V312    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V313 tmp273      [V313    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V314 tmp274      [V314    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V315 tmp275      [V315,T11] (  3, 5033.94)   ubyte  ->  rax         "Inline return value spill temp"
-;  V316 tmp276      [V316,T02] (  4,20135.24)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V315 tmp275      [V315,T34] (  3,    0.25)   ubyte  ->  rax         "Inline return value spill temp"
+;  V316 tmp276      [V316,T02] (  4,20215.91)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V317 tmp277      [V317    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V318 tmp278      [V318,T04] (  3,15101.40)     int  ->  rdx         "Inline stloc first use temp"
-;  V319 tmp279      [V319,T05] (  3,15101.19)     int  ->  rcx         "Inline stloc first use temp"
-;  V320 tmp280      [V320,T06] (  3,15101.19)     int  ->  rdx         "Inline stloc first use temp"
-;  V321 tmp281      [V321,T28] (  3,   89.64)   ubyte  ->  rax         "Inline return value spill temp"
-;  V322 tmp282      [V322,T18] (  3,  358.53)   byref  ->  rax         "Inlining Arg"
-;  V323 tmp283      [V323,T19] (  4,  358.53)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V318 tmp278      [V318,T04] (  3,15161.90)     int  ->  rdx         "Inline stloc first use temp"
+;  V319 tmp279      [V319,T05] (  3,15161.65)     int  ->  rcx         "Inline stloc first use temp"
+;  V320 tmp280      [V320,T06] (  3,15161.65)     int  ->  rdx         "Inline stloc first use temp"
+;  V321 tmp281      [V321,T35] (  3,    0.00)   ubyte  ->  rax         "Inline return value spill temp"
+;  V322 tmp282      [V322,T17] (  3,  358.38)   byref  ->  rax         "Inlining Arg"
+;  V323 tmp283      [V323,T18] (  4,  358.37)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V324 tmp284      [V324    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V325 tmp285      [V325,T21] (  3,  268.90)     int  ->  rdx         "Inline stloc first use temp"
-;  V326 tmp286      [V326,T22] (  3,  268.89)     int  ->  rcx         "Inline stloc first use temp"
-;  V327 tmp287      [V327,T23] (  3,  268.89)     int  ->  rdx         "Inline stloc first use temp"
+;  V325 tmp285      [V325,T20] (  3,  268.78)     int  ->  rdx         "Inline stloc first use temp"
+;  V326 tmp286      [V326,T21] (  3,  268.78)     int  ->  rcx         "Inline stloc first use temp"
+;  V327 tmp287      [V327,T22] (  3,  268.78)     int  ->  rdx         "Inline stloc first use temp"
 ;* V328 tmp288      [V328    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V329 tmp289      [V329    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V330 tmp290      [V330    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
@@ -8533,28 +8566,28 @@ RWD136 	dd	G_M53443_IG107 - G_M53443_IG02
 ;* V598 tmp558      [V598    ] (  0,    0   )     int  ->  zero-ref    "field V405._length (fldOffset=0x8)" P-INDEP
 ;* V599 tmp559      [V599    ] (  0,    0   )   byref  ->  zero-ref    "field V406._reference (fldOffset=0x0)" P-INDEP
 ;* V600 tmp560      [V600    ] (  0,    0   )     int  ->  zero-ref    "field V406._length (fldOffset=0x8)" P-INDEP
-;  V601 tmp561      [V601,T09] (  3, 5124.47)   byref  ->  r14         single-def "V01.[000..008)"
-;  V602 tmp562      [V602,T08] (  4, 5124.47)     int  ->  r15         "V01.[008..012)"
-;  V603 tmp563      [V603,T32] (  3,    1.11)     ref  ->  r13         single-def "V18.[000..008)"
+;  V601 tmp561      [V601,T09] (  3, 5144.60)   byref  ->  r14         single-def "V01.[000..008)"
+;  V602 tmp562      [V602,T08] (  4, 5144.60)     int  ->  r15         "V01.[008..012)"
+;  V603 tmp563      [V603,T30] (  3,    1.13)     ref  ->  r13         single-def "V18.[000..008)"
 ;* V604 tmp564      [V604    ] (  0,    0   )     ref  ->  zero-ref    "V18.[008..016)"
-;  V605 tmp565      [V605,T10] (  2, 5034.84)     int  ->  r12         "V18.[016..020)"
-;  V606 tmp566      [V606,T27] (  3,   89.64)     ref  ->  [rsp+0x20]  spill-single-def "V32.[000..008)"
-;  V607 tmp567      [V607,T24] (  2,  179.27)     int  ->  rcx         "V32.[016..020)"
+;  V605 tmp565      [V605,T10] (  2, 5055.01)     int  ->  r12         "V18.[016..020)"
+;  V606 tmp566      [V606,T26] (  3,   89.60)     ref  ->  [rsp+0x20]  spill-single-def "V32.[000..008)"
+;  V607 tmp567      [V607,T23] (  2,  179.19)     int  ->  rcx         "V32.[016..020)"
 ;* V608 tmp568      [V608    ] (  0,    0   )     ref  ->  zero-ref    "V43.[000..008)"
 ;* V609 tmp569      [V609    ] (  0,    0   )     ref  ->  zero-ref    "V43.[008..016)"
 ;* V610 tmp570      [V610    ] (  0,    0   )     ref  ->  zero-ref    "V43.[016..024)"
 ;* V611 tmp571      [V611    ] (  0,    0   )     int  ->  zero-ref    "V43.[024..028)"
 ;* V612 tmp572      [V612    ] (  0,    0   )  ushort  ->  zero-ref    "V43.[028..030)"
 ;* V613 tmp573      [V613    ] (  0,    0   )   byref  ->  zero-ref    "Spilling address for field-by-field copy"
-;  V614 tmp574      [V614,T15] (  3,  537.80)   byref  ->  rcx         "Spilling address for field-by-field copy"
+;  V614 tmp574      [V614,T14] (  3,  537.57)   byref  ->  rcx         "Spilling address for field-by-field copy"
 ;* V615 tmp575      [V615    ] (  0,    0   )     ref  ->  zero-ref    "arr expr"
 ;* V616 tmp576      [V616    ] (  0,    0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;* V617 tmp577      [V617    ] (  0,    0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;* V618 tmp578      [V618    ] (  0,    0   )     ref  ->  zero-ref    "arr expr"
 ;* V619 tmp579      [V619    ] (  0,    0   )  struct (16) zero-ref    do-not-enreg[XSF] addr-exposed "by-value struct argument" <System.Span`1[ushort]>
-;  V620 tmp580      [V620,T16] (  3,  537.80)     ref  ->  rcx         "arr expr"
-;  V621 cse0        [V621,T07] (  2,10067.67)     int  ->   r8         "CSE #01: aggressive"
-;  V622 cse1        [V622,T25] (  2,  179.27)     int  ->   r8         "CSE #02: moderate"
+;  V620 tmp580      [V620,T15] (  3,  537.57)     ref  ->  rcx         "arr expr"
+;  V621 cse0        [V621,T07] (  2,10108.02)     int  ->   r8         "CSE #01: aggressive"
+;  V622 cse1        [V622,T24] (  2,  179.19)     int  ->   r8         "CSE #02: moderate"
 ;
 ; Lcl frame size = 40
 
@@ -8595,7 +8628,7 @@ G_M53443_IG03:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, edx
        jbe      SHORT G_M53443_IG06
-						;; size=51 bbWeight=5033.84 PerfScore 61664.50
+						;; size=51 bbWeight=5054.01 PerfScore 61911.63
 G_M53443_IG04:
        mov      edx, edx
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
@@ -8609,10 +8642,10 @@ G_M53443_IG04:
        add      edx, edx
        test     ecx, edx
        je       SHORT G_M53443_IG08
-						;; size=34 bbWeight=5033.73 PerfScore 32719.25
+						;; size=34 bbWeight=5053.88 PerfScore 32850.24
 G_M53443_IG05:
        jmp      SHORT G_M53443_IG09
-						;; size=2 bbWeight=72.79 PerfScore 145.58
+						;; size=2 bbWeight=72.72 PerfScore 145.44
 G_M53443_IG06:
        cmp      eax, 128
        jl       G_M53443_IG20
@@ -8620,11 +8653,11 @@ G_M53443_IG06:
        mov      rdx, r13
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
-						;; size=25 bbWeight=0.11 PerfScore 0.53
+						;; size=25 bbWeight=0.13 PerfScore 0.64
 G_M53443_IG07:
        test     eax, eax
        jne      SHORT G_M53443_IG09
-						;; size=4 bbWeight=5033.84 PerfScore 6292.30
+						;; size=4 bbWeight=0.13 PerfScore 0.16
 G_M53443_IG08:
        mov      r9d, dword ptr [rsp+0x4DC]
        inc      r9d
@@ -8632,16 +8665,16 @@ G_M53443_IG08:
        cmp      r9d, dword ptr [rsp+0x53C]
        jg       G_M53443_IG23
        jmp      G_M53443_IG03
-						;; size=38 bbWeight=5033.84 PerfScore 36495.31
+						;; size=38 bbWeight=5054.01 PerfScore 36641.58
 G_M53443_IG09:
        mov      r10d, 1
        mov      dword ptr [rsp+0x4D4], r10d
-						;; size=14 bbWeight=72.79 PerfScore 90.99
+						;; size=14 bbWeight=72.72 PerfScore 90.90
 G_M53443_IG10:
        mov      eax, dword ptr [rsp+0x4D4]
        cmp      eax, dword ptr [rbp+0x10]
        jge      G_M53443_IG17
-						;; size=16 bbWeight=72.79 PerfScore 363.96
+						;; size=16 bbWeight=72.72 PerfScore 363.60
 G_M53443_IG11:
        cmp      eax, dword ptr [rbp+0x10]
        jae      G_M53443_IG22
@@ -8674,7 +8707,7 @@ G_M53443_IG11:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, edx
        jbe      SHORT G_M53443_IG13
-						;; size=137 bbWeight=89.63 PerfScore 3137.17
+						;; size=137 bbWeight=89.59 PerfScore 3135.80
 G_M53443_IG12:
        mov      edx, edx
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
@@ -8690,10 +8723,10 @@ G_M53443_IG12:
        test     ecx, edx
        je       G_M53443_IG08
        jmp      SHORT G_M53443_IG16
-						;; size=49 bbWeight=89.63 PerfScore 851.50
+						;; size=49 bbWeight=89.59 PerfScore 851.12
 G_M53443_IG13:
        mov      dword ptr [rsp+0x4D8], r10d
-						;; size=8 bbWeight=44.82 PerfScore 44.82
+						;; size=8 bbWeight=44.80 PerfScore 44.80
 G_M53443_IG14:
        mov      r10d, dword ptr [rsp+0x4D8]
        cmp      r10d, 128
@@ -8702,11 +8735,11 @@ G_M53443_IG14:
        mov      rdx, gword ptr [rsp+0x20]
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
-						;; size=34 bbWeight=0.00 PerfScore 0.01
+						;; size=34 bbWeight=0.00 PerfScore 0.02
 G_M53443_IG15:
        test     eax, eax
        je       G_M53443_IG08
-						;; size=8 bbWeight=89.63 PerfScore 112.04
+						;; size=8 bbWeight=0.00 PerfScore 0.00
 G_M53443_IG16:
        mov      eax, dword ptr [rsp+0x4D4]
        inc      eax
@@ -8717,7 +8750,7 @@ G_M53443_IG17:
        mov      ebx, dword ptr [rsp+0x4DC]
        mov      dword ptr [rsi], ebx
        mov      eax, 1
-						;; size=14 bbWeight=10.37 PerfScore 23.32
+						;; size=14 bbWeight=10.41 PerfScore 23.41
 G_M53443_IG18:
        add      rsp, 0x5D8
        pop      rbx
@@ -8729,7 +8762,7 @@ G_M53443_IG18:
        pop      r15
        pop      rbp
        ret      
-						;; size=20 bbWeight=10.37 PerfScore 54.42
+						;; size=20 bbWeight=10.41 PerfScore 54.63
 G_M53443_IG19:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
@@ -8768,6 +8801,6 @@ G_M53443_IG24:
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 675, prolog size 100, PerfScore 142545.96, instruction count 161, allocated bytes for code 675 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
+; Total bytes of code 675, prolog size 100, PerfScore 136664.20, instruction count 161, allocated bytes for code 675 (MethodHash=4ac32f3c) for method System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionLeftToRight(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this (Tier1-OSR)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[System.UInt64].FindEndPositionDeltas(value class System.ReadOnlySpan`1<wchar>,int32,value class System.Text.RegularExpressions.RegexRunnerMode,int32&,value class CurrentState<!0>&,int32&,int32&,int32&,int32&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 59840
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 411648
 ; 5 inlinees with PGO data; 16 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T05] ( 13, 41.61)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]>
-;  V01 arg1         [V01,T06] (  6, 41.18)   byref  ->  rsi         single-def
-;  V02 arg2         [V02,T19] (  3, 10.58)     int  ->  r14         single-def
-;  V03 arg3         [V03,T22] (  3,  3.02)     int  ->  r15         single-def
+;  V00 this         [V00,T05] ( 13, 41.03)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]>
+;  V01 arg1         [V01,T06] (  6, 40.60)   byref  ->  rsi         single-def
+;  V02 arg2         [V02,T19] (  3, 10.43)     int  ->  r14         single-def
+;  V03 arg3         [V03,T22] (  3,  3.00)     int  ->  r15         single-def
 ;  V04 arg4         [V04,T31] (  3,  2   )   byref  ->  [rbp+0x30]  EH-live single-def
-;  V05 arg5         [V05,T09] (  8, 30.62)   byref  ->  rdi         single-def
+;  V05 arg5         [V05,T09] (  8, 30.16)   byref  ->  rdi         single-def
 ;  V06 arg6         [V06,T32] (  3,  2   )   byref  ->  [rbp+0x40]  EH-live single-def
 ;  V07 arg7         [V07,T33] (  3,  2   )   byref  ->  [rbp+0x48]  EH-live single-def
 ;  V08 arg8         [V08,T34] (  3,  2   )   byref  ->  [rbp+0x50]  EH-live single-def
 ;  V09 arg9         [V09,T35] (  3,  2   )   byref  ->  [rbp+0x58]  EH-live single-def
-;  V10 loc0         [V10    ] ( 11, 41.63)     int  ->  [rbp-0x40]  do-not-enreg[X] addr-exposed ld-addr-op
-;  V11 loc1         [V11,T25] (  4,  3.02)     int  ->  [rbp-0x44]  do-not-enreg[Z] EH-live
-;  V12 loc2         [V12,T26] (  4,  3.02)     int  ->  [rbp-0x48]  do-not-enreg[Z] EH-live
-;  V13 loc3         [V13,T27] (  4,  3.02)     int  ->  [rbp-0x4C]  do-not-enreg[Z] EH-live
-;  V14 loc4         [V14,T23] (  5,  4.45)     int  ->  [rbp-0x50]  do-not-enreg[Z] EH-live
-;  V15 loc5         [V15,T07] (  4, 37.33)   ubyte  ->  r13        
+;  V10 loc0         [V10    ] ( 11, 41.03)     int  ->  [rbp-0x40]  do-not-enreg[X] addr-exposed ld-addr-op
+;  V11 loc1         [V11,T25] (  4,  3.00)     int  ->  [rbp-0x44]  do-not-enreg[Z] EH-live
+;  V12 loc2         [V12,T26] (  4,  3.00)     int  ->  [rbp-0x48]  do-not-enreg[Z] EH-live
+;  V13 loc3         [V13,T27] (  4,  3.00)     int  ->  [rbp-0x4C]  do-not-enreg[Z] EH-live
+;  V14 loc4         [V14,T23] (  5,  4.44)     int  ->  [rbp-0x50]  do-not-enreg[Z] EH-live
+;  V15 loc5         [V15,T07] (  4, 36.71)   ubyte  ->  r13        
 ;* V16 loc6         [V16    ] (  0,  0   )     int  ->  zero-ref   
 ;  V17 loc7         [V17,T30] (  5,  2   )   ubyte  ->  registers  
 ;  V18 OutArgs      [V18    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V19 tmp1         [V19,T36] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V20 tmp2         [V20,T20] (  3,  8.54)     ref  ->  r12         class-hnd exact "impAppendStmt" <<unknown class>>
+;  V20 tmp2         [V20,T20] (  3,  8.64)     ref  ->  r12         class-hnd exact "impAppendStmt" <<unknown class>>
 ;* V21 tmp3         [V21    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+CurrentState[ulong]>
-;  V22 tmp4         [V22,T24] (  4,  4.27)     int  ->  r10         "Inline return value spill temp"
-;  V23 tmp5         [V23,T29] (  2,  2.85)     int  ->   r8         "Inlining Arg"
+;  V22 tmp4         [V22,T24] (  4,  4.32)     int  ->  r10         "Inline return value spill temp"
+;  V23 tmp5         [V23,T28] (  2,  2.88)     int  ->   r8         "Inlining Arg"
 ;* V24 tmp6         [V24    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;  V25 tmp7         [V25,T41] (  3,  0   )     int  ->  rax         "Inlining Arg"
 ;* V26 tmp8         [V26    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V27 tmp9         [V27,T13] (  4, 17.17)     int  ->  registers   "Inline return value spill temp"
-;  V28 tmp10        [V28,T04] (  3, 51.50)     int  ->  r12         "Inlining Arg"
+;  V27 tmp9         [V27,T13] (  4, 16.86)     int  ->  registers   "Inline return value spill temp"
+;  V28 tmp10        [V28,T04] (  3, 50.57)     int  ->  r12         "Inlining Arg"
 ;* V29 tmp11        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V30 tmp12        [V30,T14] (  3, 17.17)     int  ->   r8         "Inline return value spill temp"
-;  V31 tmp13        [V31,T08] (  3, 34.34)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MintermClassifier>
-;  V32 tmp14        [V32,T11] (  3, 25.75)     ref  ->  r12         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V33 tmp15        [V33,T02] (  4, 51.50)     int  ->  rdx         "Inlining Arg"
+;  V30 tmp12        [V30,T14] (  3, 16.86)     int  ->   r8         "Inline return value spill temp"
+;  V31 tmp13        [V31,T08] (  3, 33.71)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MintermClassifier>
+;  V32 tmp14        [V32,T11] (  3, 25.28)     ref  ->  r12         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V33 tmp15        [V33,T02] (  4, 50.57)     int  ->  rdx         "Inlining Arg"
 ;* V34 tmp16        [V34    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V35 tmp17        [V35,T15] (  3, 17.17)   ubyte  ->  rdx         "Inline return value spill temp"
-;  V36 tmp18        [V36,T10] (  4, 25.75)     int  ->  [rbp-0x54]  spill-single-def "Inline stloc first use temp"
-;  V37 tmp19        [V37,T12] (  3, 25.75)     int  ->  rdx         "Inline stloc first use temp"
-;  V38 tmp20        [V38    ] (  3,  8.58)     ref  ->  [rbp-0x60]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline ldloca(s) first use temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
+;  V35 tmp17        [V35,T15] (  3, 16.86)   ubyte  ->  rdx         "Inline return value spill temp"
+;  V36 tmp18        [V36,T10] (  4, 25.28)     int  ->  [rbp-0x54]  spill-single-def "Inline stloc first use temp"
+;  V37 tmp19        [V37,T12] (  3, 25.28)     int  ->  rdx         "Inline stloc first use temp"
+;  V38 tmp20        [V38    ] (  3,  8.43)     ref  ->  [rbp-0x60]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline ldloca(s) first use temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;* V39 tmp21        [V39    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V40 tmp22        [V40    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;* V41 tmp23        [V41    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
@@ -600,21 +600,21 @@ G_M36904_IG32:
 ;* V44 tmp26        [V44    ] (  0,  0   )   byref  ->  zero-ref    "field V01._reference (fldOffset=0x0)" P-INDEP
 ;* V45 tmp27        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V46 tmp28        [V46,T37] (  0,  0   )     ref  ->  zero-ref    "field V21.NfaState (fldOffset=0x0)" P-INDEP
-;  V47 tmp29        [V47,T28] (  2,  2.85)     int  ->  rax         "field V21.DfaStateId (fldOffset=0x8)" P-INDEP
-;  V48 tmp30        [V48,T16] (  2, 17.17)   byref  ->  rdx         "field V29._reference (fldOffset=0x0)" P-INDEP
-;  V49 tmp31        [V49,T17] (  2, 17.17)     int  ->  rcx         "field V29._length (fldOffset=0x8)" P-INDEP
+;  V47 tmp29        [V47,T29] (  2,  2.88)     int  ->  rax         "field V21.DfaStateId (fldOffset=0x8)" P-INDEP
+;  V48 tmp30        [V48,T16] (  2, 16.86)   byref  ->  rdx         "field V29._reference (fldOffset=0x0)" P-INDEP
+;  V49 tmp31        [V49,T17] (  2, 16.86)     int  ->  rcx         "field V29._length (fldOffset=0x8)" P-INDEP
 ;* V50 tmp32        [V50    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V51 tmp33        [V51,T00] (  3, 57.50)     ref  ->  rcx         "arr expr"
-;  V52 tmp34        [V52,T01] (  3, 57.50)     int  ->  rdx         "index expr"
-;  V53 tmp35        [V53    ] (  4,  5.70)  struct (16) [rbp-0x70]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V54 tmp36        [V54,T21] (  2,  5.70)     ref  ->  rcx         "argument with side effect"
+;  V51 tmp33        [V51,T00] (  3, 56.57)     ref  ->  rcx         "arr expr"
+;  V52 tmp34        [V52,T01] (  3, 56.57)     int  ->  rdx         "index expr"
+;  V53 tmp35        [V53    ] (  4,  5.77)  struct (16) [rbp-0x70]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V54 tmp36        [V54,T21] (  2,  5.77)     ref  ->  rcx         "argument with side effect"
 ;  V55 tmp37        [V55,T39] (  3,  0   )     ref  ->  rcx         "arr expr"
-;  V56 tmp38        [V56,T03] (  3, 51.50)     ref  ->  rdx         "arr expr"
+;  V56 tmp38        [V56,T03] (  3, 50.57)     ref  ->  rdx         "arr expr"
 ;  V57 tmp39        [V57,T40] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V58 tmp40        [V58,T42] (  3,  0   )     int  ->  r13         "index expr"
 ;  V59 tmp41        [V59,T44] (  2,  0   )     ref  ->  rdx         "argument with side effect"
 ;  V60 PSPSym       [V60,T38] (  1,  1   )    long  ->  [rbp-0x80]  do-not-enreg[V] "PSPSym"
-;  V61 cse0         [V61,T18] (  2, 17.17)     int  ->   r8         "CSE #02: moderate"
+;  V61 cse0         [V61,T18] (  2, 16.86)     int  ->   r8         "CSE #02: moderate"
 ;
 ; Lcl frame size = 120
 
@@ -661,36 +661,39 @@ G_M36904_IG03:
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rdi+0x08]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M36904_IG16
+       jae      G_M36904_IG17
        movzx    r13, byte  ptr [rcx+rdx+0x10]
        test     r13b, 1
-       jne      G_M36904_IG10
-						;; size=32 bbWeight=9.58 PerfScore 107.82
+       jne      G_M36904_IG11
+						;; size=32 bbWeight=9.43 PerfScore 106.06
 G_M36904_IG04:
        test     r13b, 2
-       jne      G_M36904_IG27
-						;; size=10 bbWeight=9.58 PerfScore 11.98
+       jne      G_M36904_IG28
+						;; size=10 bbWeight=9.43 PerfScore 11.78
 G_M36904_IG05:
        mov      rdx, bword ptr [rsi]
        mov      ecx, dword ptr [rsi+0x08]
        mov      r12d, dword ptr [rbp-0x40]
        cmp      r12d, ecx
-       jae      G_M36904_IG21
+       jae      G_M36904_IG22
        mov      rcx, gword ptr [rbx+0x50]
        movzx    rdx, word  ptr [rdx+2*r12]
        mov      r12, gword ptr [rcx+0x08]
        mov      r8d, dword ptr [r12+0x08]
        cmp      r8d, edx
-       jbe      G_M36904_IG18
-       mov      r8d, dword ptr [r12+4*rdx+0x10]
-						;; size=51 bbWeight=8.58 PerfScore 150.22
+       jbe      G_M36904_IG19
+						;; size=46 bbWeight=8.43 PerfScore 130.63
 G_M36904_IG06:
-       test     r13b, 4
-       jne      G_M36904_IG14
-						;; size=10 bbWeight=8.58 PerfScore 10.73
+       mov      edx, edx
+       mov      r8d, dword ptr [r12+4*rdx+0x10]
+						;; size=7 bbWeight=8.43 PerfScore 18.96
 G_M36904_IG07:
+       test     r13b, 4
+       jne      G_M36904_IG15
+						;; size=10 bbWeight=8.43 PerfScore 10.53
+G_M36904_IG08:
        cmp      dword ptr [rbp-0x40], r14d
-       jge      G_M36904_IG24
+       jge      G_M36904_IG25
        mov      edx, dword ptr [rdi+0x08]
        mov      ecx, dword ptr [rbx+0xA4]
        shlx     edx, edx, ecx
@@ -699,46 +702,46 @@ G_M36904_IG07:
        mov      dword ptr [rbp-0x54], ecx
        mov      rdx, gword ptr [rbx+0x20]
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M36904_IG16
+       jae      G_M36904_IG17
        mov      r13d, ecx
        mov      edx, dword ptr [rdx+4*r13+0x10]
        test     edx, edx
-       jle      G_M36904_IG22
+       jle      G_M36904_IG23
        mov      dword ptr [rdi+0x08], edx
-						;; size=64 bbWeight=8.58 PerfScore 167.39
-G_M36904_IG08:
-       mov      edx, 1
-						;; size=5 bbWeight=8.58 PerfScore 2.15
+						;; size=64 bbWeight=8.43 PerfScore 164.34
 G_M36904_IG09:
+       mov      edx, 1
+						;; size=5 bbWeight=8.43 PerfScore 2.11
+G_M36904_IG10:
        xor      r8, r8
        mov      gword ptr [rbp-0x60], r8
        test     edx, edx
-       je       G_M36904_IG24
+       je       G_M36904_IG25
        mov      edx, dword ptr [rbp-0x40]
        inc      edx
        mov      dword ptr [rbp-0x40], edx
        jmp      G_M36904_IG03
-						;; size=28 bbWeight=8.58 PerfScore 57.94
-G_M36904_IG10:
-       mov      rcx, gword ptr [rbx+0x70]
-						;; size=4 bbWeight=1.42 PerfScore 2.85
+						;; size=28 bbWeight=8.43 PerfScore 56.89
 G_M36904_IG11:
+       mov      rcx, gword ptr [rbx+0x70]
+						;; size=4 bbWeight=1.44 PerfScore 2.88
+G_M36904_IG12:
        vmovdqu  xmm0, xmmword ptr [rsi]
        vmovdqu  xmmword ptr [rbp-0x70], xmm0
-						;; size=9 bbWeight=1.42 PerfScore 7.12
-G_M36904_IG12:
+						;; size=9 bbWeight=1.44 PerfScore 7.21
+G_M36904_IG13:
        lea      rdx, [rbp-0x70]
        lea      r8, [rbp-0x40]
        xor      r9d, r9d
        cmp      dword ptr [rcx], ecx
        call     [<unknown method>]
        test     eax, eax
-       jne      G_M36904_IG25
-						;; size=27 bbWeight=1.42 PerfScore 12.11
-G_M36904_IG13:
-       jmp      SHORT G_M36904_IG15
-						;; size=2 bbWeight=0.00 PerfScore 0.00
+       jne      G_M36904_IG26
+						;; size=27 bbWeight=1.44 PerfScore 12.26
 G_M36904_IG14:
+       jmp      SHORT G_M36904_IG16
+						;; size=2 bbWeight=0.00 PerfScore 0.00
+G_M36904_IG15:
        mov      edx, dword ptr [rbp-0x40]
        mov      dword ptr [rbp-0x44], edx
        mov      edx, dword ptr [rdi+0x08]
@@ -746,56 +749,56 @@ G_M36904_IG14:
        mov      edx, dword ptr [rbp-0x50]
        mov      dword ptr [rbp-0x4C], edx
        test     r15d, r15d
-       je       SHORT G_M36904_IG17
-       jmp      G_M36904_IG07
-						;; size=28 bbWeight=1.02 PerfScore 10.48
-G_M36904_IG15:
+       je       SHORT G_M36904_IG18
+       jmp      G_M36904_IG08
+						;; size=28 bbWeight=1.00 PerfScore 10.23
+G_M36904_IG16:
        mov      ecx, 1
        mov      edx, ecx
-       jmp      G_M36904_IG28
+       jmp      G_M36904_IG29
 						;; size=12 bbWeight=0.00 PerfScore 0.00
-G_M36904_IG16:
+G_M36904_IG17:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M36904_IG17:
+G_M36904_IG18:
        mov      ecx, 1
        mov      edx, ecx
-       jmp      G_M36904_IG28
+       jmp      G_M36904_IG29
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M36904_IG18:
+G_M36904_IG19:
        mov      rcx, gword ptr [rcx+0x10]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
        mov      r8d, eax
-       jmp      G_M36904_IG06
+       jmp      G_M36904_IG07
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M36904_IG19:
+G_M36904_IG20:
        vmovdqu  xmm0, xmmword ptr [rsi]
        vmovdqu  xmmword ptr [rbp-0x70], xmm0
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M36904_IG20:
+G_M36904_IG21:
        lea      rdx, [rbp-0x70]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
        mov      rcx, gword ptr [rbx+0x98]
        lea      edx, [rax+0x01]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      SHORT G_M36904_IG16
+       jae      SHORT G_M36904_IG17
        inc      eax
        mov      edx, eax
        mov      r10d, dword ptr [rcx+4*rdx+0x10]
-       jmp      G_M36904_IG26
+       jmp      G_M36904_IG27
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M36904_IG21:
+G_M36904_IG22:
        mov      ecx, -1
        mov      r8d, ecx
-       jmp      G_M36904_IG06
+       jmp      G_M36904_IG07
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M36904_IG22:
+G_M36904_IG23:
        mov      rdx, gword ptr [rbx+0x10]
        mov      r13d, dword ptr [rdi+0x08]
        cmp      r13d, dword ptr [rdx+0x08]
-       jae      SHORT G_M36904_IG16
+       jae      SHORT G_M36904_IG17
        mov      rdx, gword ptr [rdx+8*r13+0x10]
        mov      dword ptr [rsp+0x20], 1
        lea      r13, [rbp-0x60]
@@ -804,33 +807,33 @@ G_M36904_IG22:
        mov      r9d, dword ptr [rbp-0x54]
        call     [<unknown method>]
        test     eax, eax
-       je       SHORT G_M36904_IG23
+       je       SHORT G_M36904_IG24
        mov      rax, gword ptr [rbp-0x60]
        mov      eax, dword ptr [rax+0x14]
        mov      dword ptr [rdi+0x08], eax
-       jmp      G_M36904_IG08
-						;; size=68 bbWeight=0 PerfScore 0.00
-G_M36904_IG23:
-       xor      edx, edx
        jmp      G_M36904_IG09
-						;; size=7 bbWeight=0 PerfScore 0.00
+						;; size=68 bbWeight=0 PerfScore 0.00
 G_M36904_IG24:
+       xor      edx, edx
+       jmp      G_M36904_IG10
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M36904_IG25:
        xor      ecx, ecx
        mov      edx, ecx
-       jmp      SHORT G_M36904_IG28
+       jmp      SHORT G_M36904_IG29
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M36904_IG25:
+G_M36904_IG26:
        mov      r12, gword ptr [rbx+0x80]
        mov      r8d, dword ptr [rbp-0x40]
        dec      r8d
        mov      rax, gword ptr [rbx+0x60]
        test     byte  ptr [rax+0x34], 16
-       jne      G_M36904_IG19
+       jne      G_M36904_IG20
        xor      r10d, r10d
-						;; size=31 bbWeight=1.42 PerfScore 13.52
-G_M36904_IG26:
+						;; size=31 bbWeight=1.44 PerfScore 13.69
+G_M36904_IG27:
        cmp      r10d, dword ptr [r12+0x08]
-       jae      G_M36904_IG16
+       jae      G_M36904_IG17
        mov      eax, r10d
        mov      rax, gword ptr [r12+8*rax+0x10]
        mov      eax, dword ptr [rax+0x14]
@@ -840,11 +843,11 @@ G_M36904_IG26:
        mov      eax, dword ptr [rbp-0x40]
        mov      dword ptr [rbp-0x50], eax
        jmp      G_M36904_IG04
-						;; size=41 bbWeight=1.42 PerfScore 20.65
-G_M36904_IG27:
+						;; size=41 bbWeight=1.44 PerfScore 20.89
+G_M36904_IG28:
        mov      edx, 1
 						;; size=5 bbWeight=1.00 PerfScore 0.25
-G_M36904_IG28:
+G_M36904_IG29:
        mov      ecx, dword ptr [rbp-0x40]
        mov      rax, bword ptr [rbp+0x30]
        mov      dword ptr [rax], ecx
@@ -862,7 +865,7 @@ G_M36904_IG28:
        mov      dword ptr [r8], eax
        mov      eax, edx
 						;; size=51 bbWeight=1 PerfScore 15.25
-G_M36904_IG29:
+G_M36904_IG30:
        add      rsp, 120
        pop      rbx
        pop      rsi
@@ -874,7 +877,7 @@ G_M36904_IG29:
        pop      rbp
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M36904_IG30:
+G_M36904_IG31:
        push     rbp
        push     r15
        push     r14
@@ -888,7 +891,7 @@ G_M36904_IG30:
        mov      qword ptr [rsp+0x30], rbp
        lea      rbp, [rbp+0xB0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M36904_IG31:
+G_M36904_IG32:
        mov      eax, dword ptr [rbp-0x40]
        mov      rcx, bword ptr [rbp+0x30]
        mov      dword ptr [rcx], eax
@@ -905,7 +908,7 @@ G_M36904_IG31:
        mov      r8, bword ptr [rbp+0x58]
        mov      dword ptr [r8], eax
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M36904_IG32:
+G_M36904_IG33:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -918,6 +921,6 @@ G_M36904_IG32:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 815, prolog size 79, PerfScore 631.04, instruction count 235, allocated bytes for code 815 (MethodHash=94f56fd7) for method System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPositionDeltas[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+DfaStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,byref,byref,byref,byref,byref,byref):ubyte:this (Tier1)
+; Total bytes of code 817, prolog size 79, PerfScore 624.56, instruction count 236, allocated bytes for code 817 (MethodHash=94f56fd7) for method System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPositionDeltas[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+DfaStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,byref,byref,byref,byref,byref,byref):ubyte:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Regex.RunAllMatchesWithCallback(class System.String,value class System.ReadOnlySpan`1<wchar>,int32,!!0&,class System.Text.RegularExpressions.MatchCallback`1<!!0>,value class System.Text.RegularExpressions.RegexRunnerMode,bool)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 129
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 617
 ; 21 inlinees with PGO data; 69 single block inlinees; 8 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T81] ( 12,  752.43)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
-;  V01 arg1         [V01,T124] (  5,    3.75)     ref  ->  [rbp+0x18]  class-hnd single-def <System.String>
-;  V02 arg2         [V02,T115] (  4,    8   )   byref  ->   r8         ld-addr-op single-def
-;  V03 arg3         [V03,T28] ( 15, 2986.71)     int  ->  registers  
-;  V04 arg4         [V04,T45] (  6, 2236.28)   byref  ->  rsi         single-def
-;  V05 arg5         [V05,T46] (  6, 2236.28)     ref  ->  rdi         class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
-;  V06 arg6         [V06,T73] (  4, 1492.72)     int  ->  [rbp+0x40]  single-def
-;  V07 arg7         [V07,T74] (  4, 1492.47)   ubyte  ->  [rbp+0x48]  single-def
-;  V08 loc0         [V08,T00] ( 99,18664.74)     ref  ->  [rbp-0x138]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
-;  V09 loc1         [V09,T72] (  7, 1492.85)     int  ->  [rbp-0x3C] 
+;  V00 this         [V00,T78] ( 12,  740.67)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
+;  V01 arg1         [V01,T135] (  5,    3.73)     ref  ->  [rbp+0x18]  class-hnd single-def <System.String>
+;  V02 arg2         [V02,T131] (  4,    8   )   byref  ->   r8         ld-addr-op single-def
+;  V03 arg3         [V03,T27] ( 15, 2939.66)     int  ->  registers  
+;  V04 arg4         [V04,T65] (  5, 1467.33)   byref  ->  [rbp+0x30]  single-def
+;  V05 arg5         [V05,T132] (  6,    9.34)     ref  ->  [rbp+0x38]  class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
+;  V06 arg6         [V06,T60] (  4, 1468.87)     int  ->  rsi         single-def
+;  V07 arg7         [V07,T61] (  4, 1468.60)   ubyte  ->  rdi         single-def
+;  V08 loc0         [V08,T00] (101,18370.27)     ref  ->  [rbp-0x148]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V09 loc1         [V09,T58] (  7, 1469.33)     int  ->  [rbp-0x3C] 
 ;* V10 loc2         [V10    ] (  0,    0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.Match>
-;  V11 loc3         [V11,T165] (  6,    0   )     int  ->  registers  
-;  V12 loc4         [V12,T166] (  6,    0   )     int  ->  rdx        
+;  V11 loc3         [V11,T163] (  6,    0   )     int  ->  registers  
+;  V12 loc4         [V12,T164] (  6,    0   )     int  ->  r10        
 ;  V13 OutArgs      [V13    ] (  1,    1   )  struct (80) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V14 tmp1         [V14,T127] (  2,    4   )     ref  ->   r8         class-hnd single-def "dup spill" <<unknown class>>
-;  V15 tmp2         [V15,T125] (  6,    5.01)     ref  ->  [rbp-0x140] 
-;  V16 tmp3         [V16,T38] (  4, 2981.71)     int  ->  r10         "dup spill"
-;  V17 tmp4         [V17,T47] (  4, 1490.85)     int  ->  rax         "guarded devirt return temp"
+;  V14 tmp1         [V14,T140] (  2,    4   )     ref  ->   r8         class-hnd single-def "dup spill" <<unknown class>>
+;  V15 tmp2         [V15,T138] (  6,    5.00)     ref  ->  [rbp-0x150] 
+;  V16 tmp3         [V16,T37] (  4, 2934.66)     int  ->  registers   "dup spill"
+;  V17 tmp4         [V17,T85] (  2,    0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp5         [V18    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Text.RegularExpressions.Regex+<>c>
 ;* V19 tmp6         [V19    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V20 tmp7         [V20,T05] ( 16, 5971.41)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V21 tmp8         [V21,T181] (  4,    0   )     int  ->  rbx         "dup spill"
-;  V22 tmp9         [V22,T152] ( 13,    0   )     int  ->  rbx         "Inline stloc first use temp"
-;  V23 tmp10        [V23,T153] (  9,    0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V20 tmp7         [V20,T05] ( 16, 5877.33)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V21 tmp8         [V21,T179] (  4,    0   )     int  ->  rbx         "dup spill"
+;  V22 tmp9         [V22,T150] ( 13,    0   )     int  ->  rbx         "Inline stloc first use temp"
+;  V23 tmp10        [V23,T151] (  9,    0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V24 tmp11        [V24    ] (  0,    0   )     ref  ->  zero-ref   
-;  V25 tmp12        [V25,T158] (  6,    0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V25 tmp12        [V25,T156] (  6,    0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V26 tmp13        [V26    ] (  0,    0   )     ref  ->  zero-ref   
-;  V27 tmp14        [V27,T159] (  6,    0   )     ref  ->  rbx        
-;  V28 tmp15        [V28,T154] (  8,    0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V29 tmp16        [V29,T173] (  4,    0   )     ref  ->  rdx         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V27 tmp14        [V27,T157] (  6,    0   )     ref  ->  rbx        
+;  V28 tmp15        [V28,T152] (  8,    0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V29 tmp16        [V29,T171] (  4,    0   )     ref  ->  rdx         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V30 tmp17        [V30    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V31 tmp18        [V31    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V32 tmp19        [V32    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V33 tmp20        [V33,T174] (  4,    0   )     ref  ->  [rbp-0x148]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
-;  V34 tmp21        [V34,T30] (  4, 2985.71)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
+;  V33 tmp20        [V33,T172] (  4,    0   )     ref  ->  [rbp-0x158]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
+;  V34 tmp21        [V34,T30] (  4, 2938.66)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
 ;* V35 tmp22        [V35    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V36 tmp23        [V36,T26] (  8, 3005.49)     ref  ->  r10         class-hnd "Inline stloc first use temp" <int[]>
-;  V37 tmp24        [V37,T21] ( 10, 3771.69)     int  ->  rdx         "Inline stloc first use temp"
-;  V38 tmp25        [V38,T29] (  6, 2985.71)     ref  ->  r11         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V36 tmp23        [V36,T26] (  8, 2955.31)     ref  ->  registers   class-hnd "Inline stloc first use temp" <int[]>
+;  V37 tmp24        [V37,T21] ( 10, 3706.62)     int  ->  registers   "Inline stloc first use temp"
+;  V38 tmp25        [V38,T29] (  6, 2938.66)     ref  ->  r10         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V39 tmp26        [V39    ] (  0,    0   )     ref  ->  zero-ref   
-;  V40 tmp27        [V40,T35] ( 10, 2983.71)     ref  ->  r13         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
+;  V40 tmp27        [V40,T40] (  9, 2203.00)     ref  ->  r13         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V41 tmp28        [V41    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V42 tmp29        [V42,T03] ( 32, 8956.69)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V43 tmp30        [V43,T02] ( 30, 9696.64)     ref  ->  rbx         class-hnd exact "guarded devirt this exact temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]>
+;  V42 tmp29        [V42,T03] ( 32, 8812.55)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V43 tmp30        [V43,T02] ( 30, 9543.85)     ref  ->  rbx         class-hnd exact "guarded devirt this exact temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]>
 ;* V44 tmp31        [V44    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V45 tmp32        [V45    ] (  0,    0   )  struct (24) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicMatch>
 ;* V46 tmp33        [V46    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V47 tmp34        [V47,T44] (  8, 2236.32)     int  ->  [rbp-0x44]  "Inline stloc first use temp"
-;  V48 tmp35        [V48,T150] ( 22,    0   )     int  ->  r13         "Inline stloc first use temp"
+;  V47 tmp34        [V47,T43] (  8, 2201.08)     int  ->  [rbp-0x44]  "Inline stloc first use temp"
+;  V48 tmp35        [V48,T148] ( 22,    0   )     int  ->  [rbp-0x48]  "Inline stloc first use temp"
 ;* V49 tmp36        [V49    ] (  0,    0   )     int  ->  zero-ref    "impAppendStmt"
-;  V50 tmp37        [V50    ] ( 34, 5971.41)  struct (24) [rbp-0x60]  do-not-enreg[XS] must-init addr-exposed "Inline return value spill temp" <System.Text.RegularExpressions.Symbolic.SymbolicMatch>
-;  V51 tmp38        [V51,T79] ( 20,  770.31)    long  ->  [rbp-0x68]  "Inline stloc first use temp"
-;  V52 tmp39        [V52,T01] (103,15252.69)     ref  ->  [rbp-0x150]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]>
-;* V53 tmp40        [V53,T82] (  0,    0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V54 tmp41        [V54,T67] (  6, 1500.34)   ubyte  ->  r14         "Inline stloc first use temp"
-;  V55 tmp42        [V55,T66] ( 10, 1500.34)   ubyte  ->  registers   "Inline stloc first use temp"
+;  V50 tmp37        [V50    ] ( 34, 5877.33)  struct (24) [rbp-0x60]  do-not-enreg[XS] must-init addr-exposed "Inline return value spill temp" <System.Text.RegularExpressions.Symbolic.SymbolicMatch>
+;  V51 tmp38        [V51,T77] ( 20,  825.28)    long  ->  [rbp-0x68]  "Inline stloc first use temp"
+;  V52 tmp39        [V52,T01] (103,15533.97)     ref  ->  [rbp-0x160]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]>
+;* V53 tmp40        [V53,T81] (  0,    0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;  V54 tmp41        [V54,T59] (  6, 1469.33)   ubyte  ->  registers   "Inline stloc first use temp"
+;  V55 tmp42        [V55,T57] ( 10, 1469.33)   ubyte  ->  registers   "Inline stloc first use temp"
 ;* V56 tmp43        [V56    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V57 tmp44        [V57,T27] ( 22, 2993.19)     int  ->  [rbp-0x6C]  "Inlining Arg"
-;  V58 tmp45        [V58,T09] ( 26, 4543.47)     int  ->  [rbp-0x70]  "Inlining Arg"
-;  V59 tmp46        [V59    ] ( 32, 1530.09)     int  ->  [rbp-0x78]  do-not-enreg[X] addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
-;  V60 tmp47        [V60    ] ( 20, 2249.79)     int  ->  [rbp-0x80]  do-not-enreg[X] addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
-;  V61 tmp48        [V61,T57] ( 30, 1516.74)     ref  ->  r13         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]>
-;  V62 tmp49        [V62,T71] ( 28, 1496.60)     int  ->  registers   "Inline stloc first use temp"
-;  V63 tmp50        [V63,T36] ( 24, 2983.62)     int  ->  r14         "Inline stloc first use temp"
-;* V64 tmp51        [V64,T188] (  0,    0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V65 tmp52        [V65,T167] (  6,    0   )   ubyte  ->  r10         "Inline stloc first use temp"
-;  V66 tmp53        [V66,T168] (  6,    0   )     int  ->   r9         "Inline stloc first use temp"
-;  V67 tmp54        [V67,T76] ( 12, 1490.77)     int  ->  [rbp-0x84]  "Inline stloc first use temp"
+;  V57 tmp44        [V57,T28] ( 22, 2938.66)     int  ->  [rbp-0x6C]  "Inlining Arg"
+;  V58 tmp45        [V58,T09] ( 26, 4581.62)     int  ->  [rbp-0x70]  "Inlining Arg"
+;  V59 tmp46        [V59    ] ( 32, 1557.11)     int  ->  [rbp-0x78]  do-not-enreg[X] addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V60 tmp47        [V60    ] ( 20, 2210.55)     int  ->  [rbp-0x80]  do-not-enreg[X] addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
+;  V61 tmp48        [V61,T53] ( 30, 1559.95)     ref  ->  [rbp-0x168]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]>
+;  V62 tmp49        [V62,T56] ( 28, 1469.33)     int  ->  registers   "Inline stloc first use temp"
+;  V63 tmp50        [V63,T34] ( 24, 2936.72)     int  ->  registers   "Inline stloc first use temp"
+;* V64 tmp51        [V64,T186] (  0,    0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
+;  V65 tmp52        [V65,T165] (  6,    0   )   ubyte  ->  r11         "Inline stloc first use temp"
+;  V66 tmp53        [V66,T166] (  6,    0   )     int  ->   r8         "Inline stloc first use temp"
+;  V67 tmp54        [V67,T63] ( 12, 1467.39)     int  ->  [rbp-0x84]  "Inline stloc first use temp"
 ;* V68 tmp55        [V68    ] (  0,    0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Text.RegularExpressions.Symbolic.SymbolicMatch>
 ;  V69 tmp56        [V69    ] (  8,    0   )  struct (16) [rbp-0x98]  do-not-enreg[XS] must-init addr-exposed <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+Registers[ulong]>
 ;* V70 tmp57        [V70    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+Registers[ulong]>
@@ -889,117 +889,117 @@ G_M11802_IG06:
 ;* V72 tmp59        [V72    ] (  0,    0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Text.RegularExpressions.Symbolic.SymbolicMatch>
 ;* V73 tmp60        [V73    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V74 tmp61        [V74    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V75 tmp62        [V75,T140] (  4,    1.49)     int  ->  r15         "Inline return value spill temp"
-;  V76 tmp63        [V76    ] ( 20,  197.06)     int  ->  [rbp-0xA0]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
-;  V77 tmp64        [V77    ] (  6,   24.63)     int  ->  [rbp-0xA8]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
-;  V78 tmp65        [V78    ] ( 16,   89.57)  struct (16) [rbp-0xB8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+CurrentState[ulong]>
+;  V75 tmp62        [V75,T137] (  4,    5.66)     int  ->  registers   "Inline return value spill temp"
+;  V76 tmp63        [V76    ] ( 20,  747.56)     int  ->  [rbp-0xA0]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
+;  V77 tmp64        [V77    ] (  6,   93.44)     int  ->  [rbp-0xA8]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
+;  V78 tmp65        [V78    ] ( 16,  339.80)  struct (16) [rbp-0xB8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+CurrentState[ulong]>
 ;* V79 tmp66        [V79    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V80 tmp67        [V80,T113] (  6,   13.44)     ref  ->  [rbp-0x158]  class-hnd exact "impAppendStmt" <<unknown class>>
-;  V81 tmp68        [V81    ] ( 10,   30.60)     int  ->  [rbp-0xC0]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
-;  V82 tmp69        [V82    ] ( 10,   32.84)     int  ->  [rbp-0xC8]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
-;  V83 tmp70        [V83,T91] ( 10,   71.66)     int  ->  r15        
+;  V80 tmp67        [V80,T110] (  6,   50.97)     ref  ->  [rbp-0x170]  class-hnd exact "impAppendStmt" <<unknown class>>
+;  V81 tmp68        [V81    ] ( 10,  116.10)     int  ->  [rbp-0xC0]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
+;  V82 tmp69        [V82    ] ( 10,  124.59)     int  ->  [rbp-0xC8]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
+;  V83 tmp70        [V83,T90] ( 10,  271.84)     int  ->  registers  
 ;* V84 tmp71        [V84    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V85 tmp72        [V85,T94] (  6,   47.77)     int  ->  rax        
+;  V85 tmp72        [V85,T93] (  6,  181.23)     int  ->  rax        
 ;* V86 tmp73        [V86    ] (  0,    0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V87 tmp74        [V87,T131] (  4,    3.73)   byref  ->  r14        
-;  V88 tmp75        [V88,T116] (  6,    8.96)     ref  ->  [rbp-0x160]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
+;  V87 tmp74        [V87,T126] (  4,   14.16)   byref  ->  registers  
+;  V88 tmp75        [V88,T113] (  6,   33.98)     ref  ->  [rbp-0x178]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;* V89 tmp76        [V89    ] (  0,    0   )   byref  ->  zero-ref   
-;  V90 tmp77        [V90,T120] (  6,    6.72)     int  ->  registers  
-;  V91 tmp78        [V91,T101] (  7,   35.95)     ref  ->  r15         class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]>
-;  V92 tmp79        [V92,T114] (  8,   11.94)     int  ->  r15         "Inline return value spill temp"
+;  V90 tmp77        [V90,T117] (  6,   25.48)     int  ->  rax        
+;  V91 tmp78        [V91,T99] (  7,  136.37)     ref  ->  [rbp-0x180]  class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]>
+;  V92 tmp79        [V92,T111] (  8,   45.31)     int  ->  registers   "Inline return value spill temp"
 ;* V93 tmp80        [V93    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V94 tmp81        [V94,T106] (  9,   19.47)     int  ->  registers   "Inlining Arg"
+;  V94 tmp81        [V94,T103] (  9,   73.85)     int  ->  registers   "Inlining Arg"
 ;* V95 tmp82        [V95    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V96 tmp83        [V96,T111] ( 10,   14.93)     int  ->  r15         "Inline return value spill temp"
+;  V96 tmp83        [V96,T108] ( 10,   56.63)     int  ->  registers   "Inline return value spill temp"
 ;* V97 tmp84        [V97    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V98 tmp85        [V98,T118] ( 11,    7.47)     int  ->  registers   "Inline stloc first use temp"
-;  V99 tmp86        [V99,T129] (  6,    3.73)     int  ->  r15         "Inline return value spill temp"
-;  V100 tmp87       [V100,T133] (  6,    2.99)     ref  ->  r15         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MintermClassifier>
-;  V101 tmp88       [V101,T135] (  7,    2.25)     ref  ->  [rbp-0x168]  class-hnd "Inline stloc first use temp" <int[]>
+;  V98 tmp85        [V98,T115] ( 11,   28.34)     int  ->  [rbp-0xCC]  "Inline stloc first use temp"
+;  V99 tmp86        [V99,T124] (  6,   14.16)     int  ->  registers   "Inline return value spill temp"
+;  V100 tmp87       [V100,T129] (  6,   11.33)     ref  ->  registers   class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MintermClassifier>
+;  V101 tmp88       [V101,T133] (  7,    8.52)     ref  ->  registers   class-hnd "Inline stloc first use temp" <int[]>
 ;* V102 tmp89       [V102    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V103 tmp90       [V103,T102] (  6,   35.83)     ref  ->  r11         class-hnd exact "Inline return value spill temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V104 tmp91       [V104,T93] (  6,   71.66)     int  ->   r8         "Inlining Arg"
+;  V103 tmp90       [V103,T100] (  6,  135.92)     ref  ->  rdx         class-hnd exact "Inline return value spill temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
+;  V104 tmp91       [V104,T92] (  6,  271.84)     int  ->  r10         "Inlining Arg"
 ;* V105 tmp92       [V105    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V106 tmp93       [V106,T95] (  4,   47.77)     ref  ->  [rbp-0x170]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V107 tmp94       [V107,T96] (  4,   47.77)     ref  ->  rax         class-hnd "dup spill" <<unknown class>>
-;  V108 tmp95       [V108,T98] (  4,   47.77)     int  ->  [rbp-0xCC]  "impAppendStmt"
-;  V109 tmp96       [V109,T97] (  4,   47.77)     ref  ->  [rbp-0x178]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.SparseIntMap`1[int]>
+;  V106 tmp93       [V106,T94] (  4,  181.23)     ref  ->  [rbp-0x188]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V107 tmp94       [V107,T95] (  4,  181.23)     ref  ->  rax         class-hnd "dup spill" <<unknown class>>
+;  V108 tmp95       [V108,T97] (  4,  181.23)     int  ->  [rbp-0xD0]  "impAppendStmt"
+;  V109 tmp96       [V109,T96] (  4,  181.23)     ref  ->  [rbp-0x190]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.SparseIntMap`1[int]>
 ;* V110 tmp97       [V110    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V111 tmp98       [V111    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V112 tmp99       [V112    ] (  0,    0   )     int  ->  zero-ref   
 ;* V113 tmp100      [V113    ] (  0,    0   )     ref  ->  zero-ref   
-;  V114 tmp101      [V114,T100] (  8,   36.57)     ref  ->  rax        
-;  V115 tmp102      [V115,T119] ( 10,    7.46)     ref  ->  [rbp-0x180]  class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V114 tmp101      [V114,T98] (  8,  138.75)     ref  ->  rax        
+;  V115 tmp102      [V115,T116] ( 10,   28.32)     ref  ->  [rbp-0x198]  class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V116 tmp103      [V116    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SparseIntMap`1[int]>
-;  V117 tmp104      [V117,T90] (  8,   95.54)     ref  ->  rcx         class-hnd "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[int,int]]>
+;  V117 tmp104      [V117,T89] (  8,  362.45)     ref  ->  registers   class-hnd "Inlining Arg" <System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[int,int]]>
 ;* V118 tmp105      [V118    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V119 tmp106      [V119,T126] (  6,    4.48)     ref  ->  rdx         class-hnd exact "Inlining Arg" <<unknown class>>
-;  V120 tmp107      [V120,T187] (  3,    0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V119 tmp106      [V119,T122] (  6,   16.99)     ref  ->  rdx         class-hnd exact "Inlining Arg" <<unknown class>>
+;  V120 tmp107      [V120,T185] (  3,    0   )     ref  ->  r12         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V121 tmp108      [V121    ] (  0,    0   )  struct ( 8) zero-ref    "spilled call-like call argument" <System.TimeSpan>
-;  V122 tmp109      [V122,T110] (  6,   17.91)     int  ->  rax         "Inlining Arg"
+;  V122 tmp109      [V122,T107] (  6,   67.96)     int  ->  rcx         "Inlining Arg"
 ;* V123 tmp110      [V123    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V124 tmp111      [V124,T121] (  6,    6.72)     int  ->   r8         "Inline return value spill temp"
+;  V124 tmp111      [V124,T118] (  6,   25.48)     int  ->  registers   "Inline return value spill temp"
 ;* V125 tmp112      [V125    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V126 tmp113      [V126,T104] ( 10,   29.86)     int  ->  rdx         "Inlining Arg"
+;  V126 tmp113      [V126,T102] ( 10,  113.27)     int  ->  r10         "Inlining Arg"
 ;* V127 tmp114      [V127    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V128 tmp115      [V128,T112] ( 10,   14.93)     int  ->   r8         "Inline return value spill temp"
+;  V128 tmp115      [V128,T109] ( 10,   56.63)     int  ->  registers   "Inline return value spill temp"
 ;* V129 tmp116      [V129    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V130 tmp117      [V130,T117] ( 12,    8.21)     int  ->   r8         "Inline stloc first use temp"
-;  V131 tmp118      [V131,T130] (  6,    3.73)     int  ->   r8         "Inline return value spill temp"
-;  V132 tmp119      [V132,T134] (  6,    2.99)     ref  ->  r10         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MintermClassifier>
-;  V133 tmp120      [V133,T136] (  7,    2.25)     ref  ->   r9         class-hnd "Inline stloc first use temp" <int[]>
-;  V134 tmp121      [V134,T142] ( 12,    1.24)     int  ->  [rbp-0xD0]  "Inline stloc first use temp"
+;  V130 tmp117      [V130,T114] ( 12,   31.15)     int  ->  [rbp-0xD4]  "Inline stloc first use temp"
+;  V131 tmp118      [V131,T125] (  6,   14.16)     int  ->  registers   "Inline return value spill temp"
+;  V132 tmp119      [V132,T130] (  6,   11.33)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MintermClassifier>
+;  V133 tmp120      [V133,T128] (  8,   11.33)     ref  ->   r9         class-hnd "Inline stloc first use temp" <int[]>
+;  V134 tmp121      [V134,T139] ( 12,    4.72)     int  ->  [rbp-0xD8]  "Inline stloc first use temp"
 ;* V135 tmp122      [V135    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V136 tmp123      [V136,T128] ( 14,    3.73)     int  ->  registers   "Inline return value spill temp"
-;  V137 tmp124      [V137,T123] ( 18,    6.47)     ref  ->  [rbp-0x188]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V138 tmp125      [V138,T137] (  8,    2.24)     int  ->   r8         "Inline stloc first use temp"
-;  V139 tmp126      [V139,T148] (  6,    0.75)     int  ->  rax         "Inline stloc first use temp"
-;  V140 tmp127      [V140,T155] (  8,    0   )     ref  ->  [rbp-0x190]  class-hnd exact "NewObj constructor temp" <System.Func`2[uint,int]>
-;  V141 tmp128      [V141,T182] (  4,    0   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V142 tmp129      [V142,T139] (  8,    1.49)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V136 tmp123      [V136,T123] ( 14,   14.16)     int  ->  rax         "Inline return value spill temp"
+;  V137 tmp124      [V137,T120] ( 18,   24.54)     ref  ->  [rbp-0x1A0]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V138 tmp125      [V138,T134] (  8,    8.49)     int  ->   r8         "Inline stloc first use temp"
+;  V139 tmp126      [V139,T141] (  6,    2.83)     int  ->  rax         "Inline stloc first use temp"
+;  V140 tmp127      [V140,T153] (  8,    0   )     ref  ->  [rbp-0x1A8]  class-hnd exact "NewObj constructor temp" <System.Func`2[uint,int]>
+;  V141 tmp128      [V141,T180] (  4,    0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V142 tmp129      [V142,T136] (  8,    5.66)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
 ;* V143 tmp130      [V143    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V144 tmp131      [V144,T68] (  4, 1498.84)     int  ->  rax         "Inline return value spill temp"
-;  V145 tmp132      [V145    ] ( 20, 7507.46)     int  ->  [rbp-0xD8]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
-;  V146 tmp133      [V146    ] (  6, 1505.46)     int  ->  [rbp-0xE0]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
-;  V147 tmp134      [V147    ] ( 16, 3010.92)  struct (16) [rbp-0xF0]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+CurrentState[ulong]>
+;  V144 tmp131      [V144,T70] (  4, 1463.67)     int  ->  registers   "Inline return value spill temp"
+;  V145 tmp132      [V145    ] ( 20, 7318.34)     int  ->  [rbp-0xE0]  do-not-enreg[X] addr-exposed ld-addr-op "Inlining Arg"
+;  V146 tmp133      [V146    ] (  6, 1463.67)     int  ->  [rbp-0xE8]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
+;  V147 tmp134      [V147    ] ( 18, 2927.34)  struct (16) [rbp-0xF8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline ldloca(s) first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+CurrentState[ulong]>
 ;* V148 tmp135      [V148    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V149 tmp136      [V149,T13] (  6, 4496.53)     ref  ->  [rbp-0x198]  class-hnd exact "impAppendStmt" <<unknown class>>
-;  V150 tmp137      [V150    ] ( 10, 3010.17)     int  ->  [rbp-0xF8]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
-;  V151 tmp138      [V151    ] ( 10, 3016.79)     int  ->  [rbp-0x100]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
-;  V152 tmp139      [V152,T58] ( 10, 1512.08)     int  ->  registers  
+;  V149 tmp136      [V149,T17] (  6, 4391.01)     ref  ->  [rbp-0x1B0]  class-hnd exact "impAppendStmt" <<unknown class>>
+;  V150 tmp137      [V150    ] ( 10, 2925.61)     int  ->  [rbp-0x100]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
+;  V151 tmp138      [V151    ] ( 10, 2925.61)     int  ->  [rbp-0x108]  do-not-enreg[X] addr-exposed ld-addr-op "Inline stloc first use temp"
+;  V152 tmp139      [V152,T66] ( 10, 1463.67)     int  ->  registers  
 ;* V153 tmp140      [V153    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V154 tmp141      [V154,T59] (  6, 1512.08)     int  ->  rax        
+;  V154 tmp141      [V154,T67] (  6, 1463.67)     int  ->  rax        
 ;* V155 tmp142      [V155    ] (  0,    0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V156 tmp143      [V156,T65] (  4, 1505.46)   byref  ->  r14        
-;  V157 tmp144      [V157,T10] (  6, 4531.73)     ref  ->  [rbp-0x1A0]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
+;  V156 tmp143      [V156,T69] (  4, 1463.67)   byref  ->  registers  
+;  V157 tmp144      [V157,T18] (  6, 4380.65)     ref  ->  [rbp-0x1B8]  class-hnd exact "impAppendStmt" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;* V158 tmp145      [V158    ] (  0,    0   )   byref  ->  zero-ref   
-;  V159 tmp146      [V159,T64] (  6, 1505.46)     int  ->  registers  
-;  V160 tmp147      [V160,T160] (  6,    0   )     ref  ->  r14         class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]>
-;  V161 tmp148      [V161,T41] (  8, 2248.27)     int  ->   r9         "Inline return value spill temp"
+;  V159 tmp146      [V159,T68] (  6, 1463.67)     int  ->  rcx        
+;  V160 tmp147      [V160,T158] (  6,    0   )     ref  ->  [rbp-0x1C0]  class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]>
+;  V161 tmp148      [V161,T44] (  8, 2195.50)     int  ->  registers   "Inline return value spill temp"
 ;* V162 tmp149      [V162    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V163 tmp150      [V163,T69] (  4, 1498.84)     int  ->  [rbp-0x104]  "Inlining Arg"
+;  V163 tmp150      [V163,T71] (  4, 1463.67)     int  ->  registers   "Inlining Arg"
 ;* V164 tmp151      [V164    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V165 tmp152      [V165,T169] (  6,    0   )     int  ->  rax         "Inlining Arg"
+;  V165 tmp152      [V165,T167] (  6,    0   )     int  ->  rax         "Inlining Arg"
 ;* V166 tmp153      [V166    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
 ;* V167 tmp154      [V167    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V168 tmp155      [V168,T170] (  6,    0   )     int  ->  r10         "Inlining Arg"
+;  V168 tmp155      [V168,T168] (  6,    0   )     int  ->   r9         "Inlining Arg"
 ;* V169 tmp156      [V169    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V170 tmp157      [V170,T12] (  6, 4531.73)     int  ->  rcx         "Inlining Arg"
+;  V170 tmp157      [V170,T20] (  6, 4380.65)     int  ->  rdx         "Inlining Arg"
 ;* V171 tmp158      [V171    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]>
-;  V172 tmp159      [V172,T62] (  6, 1510.58)     int  ->  rcx         "Inline return value spill temp"
+;  V172 tmp159      [V172,T74] (  6, 1460.22)     int  ->  rcx         "Inline return value spill temp"
 ;* V173 tmp160      [V173    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V174 tmp161      [V174,T63] (  4, 1510.58)     int  ->   r8         "Inlining Arg"
+;  V174 tmp161      [V174,T75] (  4, 1460.22)     int  ->   r9         "Inlining Arg"
 ;* V175 tmp162      [V175    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V176 tmp163      [V176,T171] (  6,    0   )     int  ->  rax         "Inlining Arg"
-;  V177 tmp164      [V177,T78] ( 12, 1258.81)     int  ->  [rbp-0x108]  "Inline stloc first use temp"
+;  V176 tmp163      [V176,T169] (  6,    0   )     int  ->  rax         "Inlining Arg"
+;  V177 tmp164      [V177,T76] ( 12, 1216.85)     int  ->  [rbp-0x10C]  "Inline stloc first use temp"
 ;* V178 tmp165      [V178    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V179 tmp166      [V179,T60] ( 14, 1510.58)     int  ->  registers   "Inline return value spill temp"
-;  V180 tmp167      [V180,T04] ( 18, 6545.83)     ref  ->  [rbp-0x1A8]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
-;  V181 tmp168      [V181,T39] (  8, 2265.87)     int  ->   r8         "Inline stloc first use temp"
-;  V182 tmp169      [V182,T80] (  6,  755.29)     int  ->  rax         "Inline stloc first use temp"
-;  V183 tmp170      [V183,T156] (  8,    0   )     ref  ->  [rbp-0x1B0]  class-hnd exact "NewObj constructor temp" <System.Func`2[uint,int]>
-;  V184 tmp171      [V184,T183] (  4,    0   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V185 tmp172      [V185,T61] (  8, 1510.58)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V179 tmp166      [V179,T72] ( 14, 1460.22)     int  ->  rcx         "Inline return value spill temp"
+;  V180 tmp167      [V180,T04] ( 18, 6327.61)     ref  ->  [rbp-0x1C8]  class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
+;  V181 tmp168      [V181,T45] (  8, 2190.33)     int  ->   r8         "Inline stloc first use temp"
+;  V182 tmp169      [V182,T88] (  6,  730.11)     int  ->  rcx         "Inline stloc first use temp"
+;  V183 tmp170      [V183,T154] (  8,    0   )     ref  ->  [rbp-0x1D0]  class-hnd exact "NewObj constructor temp" <System.Func`2[uint,int]>
+;  V184 tmp171      [V184,T181] (  4,    0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V185 tmp172      [V185,T73] (  8, 1460.22)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]>
 ;* V186 tmp173      [V186    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V187 tmp174      [V187    ] (  0,    0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Text.RegularExpressions.Symbolic.SymbolicMatch>
 ;* V188 tmp175      [V188    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -1008,71 +1008,71 @@ G_M11802_IG06:
 ;* V191 tmp178      [V191    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V192 tmp179      [V192    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V193 tmp180      [V193    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <int[]>
-;  V194 tmp181      [V194,T16] (  8, 4472.64)     int  ->  r14         "Inlining Arg"
-;  V195 tmp182      [V195,T06] ( 10, 5963.52)     int  ->  r15         "Inlining Arg"
+;  V194 tmp181      [V194,T12] (  8, 4402.16)     int  ->  [rbp-0x110]  "Inlining Arg"
+;  V195 tmp182      [V195,T06] ( 10, 5869.55)     int  ->  registers   "Inlining Arg"
 ;* V196 tmp183      [V196    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V197 tmp184      [V197,T37] (  8, 2981.76)     int  ->  rax         "Inline stloc first use temp"
-;  V198 tmp185      [V198,T17] (  6, 4472.64)     ref  ->  rdx         class-hnd "impAppendStmt" <int[]>
-;  V199 tmp186      [V199,T07] (  8, 5963.52)     ref  ->  r13         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Match>
-;  V200 tmp187      [V200,T43] (  8, 2236.32)     ref  ->  [rbp-0x1B8]  class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V197 tmp184      [V197,T36] (  8, 2934.78)     int  ->  r10         "Inline stloc first use temp"
+;  V198 tmp185      [V198,T13] (  6, 4402.16)     ref  ->  registers   class-hnd "impAppendStmt" <int[]>
+;  V199 tmp186      [V199,T07] (  8, 5869.55)     ref  ->  [rbp-0x1D8]  class-hnd "Inlining Arg" <System.Text.RegularExpressions.Match>
+;  V200 tmp187      [V200,T42] (  8, 2201.08)     ref  ->  [rbp-0x1E0]  class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V201 tmp188      [V201    ] (  0,    0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V202 tmp189      [V202,T22] ( 18, 3742.11)     ref  ->  [rbp-0x1C0]  class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V203 tmp190      [V203,T24] ( 10, 3727.20)     ref  ->  r13         class-hnd "Inline stloc first use temp" <int[]>
-;  V204 tmp191      [V204,T40] ( 12, 2258.68)     int  ->  [rbp-0x10C]  "Inline stloc first use temp"
+;  V202 tmp189      [V202,T22] ( 18, 3683.14)     ref  ->  [rbp-0x1E8]  class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V203 tmp190      [V203,T24] ( 10, 3668.47)     ref  ->  [rbp-0x1F0]  class-hnd "Inline stloc first use temp" <int[]>
+;  V204 tmp191      [V204,T38] ( 12, 2223.09)     int  ->  [rbp-0x114]  "Inline stloc first use temp"
 ;* V205 tmp192      [V205    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V206 tmp193      [V206,T161] (  6,    0   )     ref  ->  [rbp-0x1C8]  class-hnd "Inline stloc first use temp" <int[]>
-;  V207 tmp194      [V207,T157] (  8,    0   )     ref  ->  rax         class-hnd exact "Inline stloc first use temp" <int[]>
-;  V208 tmp195      [V208,T151] ( 16,    0   )     int  ->  rcx         "Inline stloc first use temp"
-;  V209 tmp196      [V209,T184] (  4,    0   )     int  ->  r11         "Strict ordering of exceptions for Array store"
+;  V206 tmp193      [V206,T159] (  6,    0   )     ref  ->  [rbp-0x1F8]  class-hnd "Inline stloc first use temp" <int[]>
+;  V207 tmp194      [V207,T155] (  8,    0   )     ref  ->  rax         class-hnd exact "Inline stloc first use temp" <int[]>
+;  V208 tmp195      [V208,T149] ( 16,    0   )     int  ->  rcx         "Inline stloc first use temp"
+;  V209 tmp196      [V209,T182] (  4,    0   )     int  ->  r11         "Strict ordering of exceptions for Array store"
 ;* V210 tmp197      [V210    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <int[]>
-;  V211 tmp198      [V211,T31] (  4, 2985.18)     int  ->  rax         "Inlining Arg"
+;  V211 tmp198      [V211,T31] (  4, 2936.81)     int  ->  rax         "Inlining Arg"
 ;* V212 tmp199      [V212    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V213 tmp200      [V213,T23] ( 10, 3731.48)     ref  ->  r10         class-hnd "Inline stloc first use temp" <int[]>
-;  V214 tmp201      [V214,T32] (  4, 2985.18)     int  ->   r9         "Inlining Arg"
-;  V215 tmp202      [V215,T33] (  4, 2985.18)     int  ->  r11         "Inlining Arg"
-;  V216 tmp203      [V216,T55] ( 28, 1530.34)   byref  ->  r12         single-def "field V02._reference (fldOffset=0x0)" P-INDEP
-;  V217 tmp204      [V217,T08] ( 56, 4579.40)     int  ->  [rbp-0x110]  spill-single-def "field V02._length (fldOffset=0x8)" P-INDEP
+;  V213 tmp200      [V213,T23] ( 10, 3671.01)     ref  ->  r10         class-hnd "Inline stloc first use temp" <int[]>
+;  V214 tmp201      [V214,T32] (  4, 2936.81)     int  ->   r9         "Inlining Arg"
+;  V215 tmp202      [V215,T33] (  4, 2936.81)     int  ->  r11         "Inlining Arg"
+;  V216 tmp203      [V216,T52] ( 28, 1569.44)   byref  ->  r12         single-def "field V02._reference (fldOffset=0x0)" P-INDEP
+;  V217 tmp204      [V217,T08] ( 56, 4709.15)     int  ->  [rbp-0x118]  spill-single-def "field V02._length (fldOffset=0x8)" P-INDEP
 ;* V218 tmp205      [V218    ] (  0,    0   )   byref  ->  zero-ref    "field V19._reference (fldOffset=0x0)" P-INDEP
 ;* V219 tmp206      [V219    ] (  0,    0   )     int  ->  zero-ref    "field V19._length (fldOffset=0x8)" P-INDEP
 ;* V220 tmp207      [V220    ] (  0,    0   )   byref  ->  zero-ref    "field V41._reference (fldOffset=0x0)" P-INDEP
 ;* V221 tmp208      [V221    ] (  0,    0   )     int  ->  zero-ref    "field V41._length (fldOffset=0x8)" P-INDEP
 ;* V222 tmp209      [V222    ] (  0,    0   )   byref  ->  zero-ref    "field V44._reference (fldOffset=0x0)" P-INDEP
-;  V223 tmp210      [V223,T42] ( 20, 1496.68)     int  ->  [rbp-0x114]  "field V44._length (fldOffset=0x8)" P-INDEP
-;  V224 tmp211      [V224,T85] ( 14,  746.43)     ref  ->  r14         "field V45.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V225 tmp212      [V225,T86] (  6,  746.43)     ref  ->  r15         "field V45.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
-;  V226 tmp213      [V226,T34] ( 10, 2983.73)     int  ->  r13         "field V45.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
-;  V227 tmp214      [V227,T75] (  4, 1491.87)     int  ->  r11         "field V45.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
-;  V228 tmp215      [V228,T70] ( 18, 1496.62)   byref  ->  [rbp-0x1D0]  "field V56._reference (fldOffset=0x0)" P-INDEP
-;* V229 tmp216      [V229,T87] (  0,    0   )     int  ->  zero-ref    "field V56._length (fldOffset=0x8)" P-INDEP
-;* V230 tmp217      [V230,T88] (  0,    0   )     ref  ->  zero-ref    "field V68.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
-;* V231 tmp218      [V231,T89] (  0,    0   )     ref  ->  zero-ref    "field V68.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
-;  V232 tmp219      [V232,T48] (  6, 2236.15)     int  ->   r9         "field V68.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
-;  V233 tmp220      [V233,T77] (  4, 1490.77)     int  ->  r14         "field V68.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
+;  V223 tmp210      [V223,T39] ( 20, 1462.33)     int  ->  [rbp-0x11C]  "field V44._length (fldOffset=0x8)" P-INDEP
+;  V224 tmp211      [V224,T79] ( 14,  734.67)     ref  ->  r13         "field V45.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
+;  V225 tmp212      [V225,T80] (  6,  734.67)     ref  ->  [rbp-0x200]  "field V45.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
+;  V226 tmp213      [V226,T35] ( 10, 2936.72)     int  ->  registers   "field V45.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
+;  V227 tmp214      [V227,T62] (  4, 1468.36)     int  ->  r11         "field V45.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
+;  V228 tmp215      [V228,T55] ( 18, 1462.10)   byref  ->  [rbp-0x208]  "field V56._reference (fldOffset=0x0)" P-INDEP
+;* V229 tmp216      [V229,T82] (  0,    0   )     int  ->  zero-ref    "field V56._length (fldOffset=0x8)" P-INDEP
+;* V230 tmp217      [V230,T83] (  0,    0   )     ref  ->  zero-ref    "field V68.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
+;* V231 tmp218      [V231,T84] (  0,    0   )     ref  ->  zero-ref    "field V68.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
+;  V232 tmp219      [V232,T41] (  6, 2201.08)     int  ->   r8         "field V68.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
+;  V233 tmp220      [V233,T64] (  4, 1467.39)     int  ->  r13         "field V68.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
 ;  V234 tmp221      [V234    ] (  6,    0   )     ref  ->  [rbp-0x98]  do-not-enreg[X] addr-exposed "field V69.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-DEP
 ;  V235 tmp222      [V235    ] (  6,    0   )     ref  ->  [rbp-0x90]  do-not-enreg[X] addr-exposed "field V69.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-DEP
-;  V236 tmp223      [V236,T175] (  4,    0   )     ref  ->  rax         "field V70.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V237 tmp224      [V237,T176] (  4,    0   )     ref  ->  r10         "field V70.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
-;  V238 tmp225      [V238,T177] (  4,    0   )     ref  ->  rax         "field V72.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
-;  V239 tmp226      [V239,T178] (  4,    0   )     ref  ->  r10         "field V72.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
-;  V240 tmp227      [V240,T172] (  6,    0   )     int  ->  r11         "field V72.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
-;  V241 tmp228      [V241,T185] (  4,    0   )     int  ->  rcx         "field V72.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
-;  V242 tmp229      [V242    ] ( 10,   62.70)     ref  ->  [rbp-0xB8]  do-not-enreg[X] addr-exposed "field V78.NfaState (fldOffset=0x0)" P-DEP
-;  V243 tmp230      [V243    ] ( 10,   50.76)     int  ->  [rbp-0xB0]  do-not-enreg[X] addr-exposed "field V78.DfaStateId (fldOffset=0x8)" P-DEP
-;  V244 tmp231      [V244,T132] (  2,    3.69)   byref  ->  [rbp-0x1D8]  spill-single-def "field V79._reference (fldOffset=0x0)" P-INDEP
-;  V245 tmp232      [V245,T122] (  3,    6.65)     int  ->  [rbp-0x118]  spill-single-def "field V79._length (fldOffset=0x8)" P-INDEP
+;  V236 tmp223      [V236,T173] (  4,    0   )     ref  ->  rax         "field V70.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
+;  V237 tmp224      [V237,T174] (  4,    0   )     ref  ->  r10         "field V70.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
+;  V238 tmp225      [V238,T175] (  4,    0   )     ref  ->  rax         "field V72.<CaptureStarts>k__BackingField (fldOffset=0x0)" P-INDEP
+;  V239 tmp226      [V239,T176] (  4,    0   )     ref  ->  r10         "field V72.<CaptureEnds>k__BackingField (fldOffset=0x8)" P-INDEP
+;  V240 tmp227      [V240,T170] (  6,    0   )     int  ->  rcx         "field V72.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
+;  V241 tmp228      [V241,T183] (  4,    0   )     int  ->  rdx         "field V72.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
+;  V242 tmp229      [V242    ] ( 10,  237.86)     ref  ->  [rbp-0xB8]  do-not-enreg[X] addr-exposed "field V78.NfaState (fldOffset=0x0)" P-DEP
+;  V243 tmp230      [V243    ] ( 10,  192.55)     int  ->  [rbp-0xB0]  do-not-enreg[X] addr-exposed "field V78.DfaStateId (fldOffset=0x8)" P-DEP
+;  V244 tmp231      [V244,T127] (  2,   14.02)   byref  ->  [rbp-0x210]  spill-single-def "field V79._reference (fldOffset=0x0)" P-INDEP
+;  V245 tmp232      [V245,T119] (  3,   25.23)     int  ->  [rbp-0x120]  spill-single-def "field V79._length (fldOffset=0x8)" P-INDEP
 ;* V246 tmp233      [V246    ] (  0,    0   )   byref  ->  zero-ref    "field V93._reference (fldOffset=0x0)" P-INDEP
 ;* V247 tmp234      [V247    ] (  0,    0   )     int  ->  zero-ref    "field V93._length (fldOffset=0x8)" P-INDEP
 ;* V248 tmp235      [V248    ] (  0,    0   )   byref  ->  zero-ref    "field V97._reference (fldOffset=0x0)" P-INDEP
 ;* V249 tmp236      [V249    ] (  0,    0   )     int  ->  zero-ref    "field V97._length (fldOffset=0x8)" P-INDEP
-;  V250 tmp237      [V250,T189] (  2,    0   )    long  ->   r9         "field V121._ticks (fldOffset=0x0)" P-INDEP
+;  V250 tmp237      [V250,T187] (  2,    0   )    long  ->   r9         "field V121._ticks (fldOffset=0x0)" P-INDEP
 ;* V251 tmp238      [V251    ] (  0,    0   )   byref  ->  zero-ref    "field V125._reference (fldOffset=0x0)" P-INDEP
 ;* V252 tmp239      [V252    ] (  0,    0   )     int  ->  zero-ref    "field V125._length (fldOffset=0x8)" P-INDEP
 ;* V253 tmp240      [V253    ] (  0,    0   )   byref  ->  zero-ref    "field V129._reference (fldOffset=0x0)" P-INDEP
 ;* V254 tmp241      [V254    ] (  0,    0   )     int  ->  zero-ref    "field V129._length (fldOffset=0x8)" P-INDEP
-;  V255 tmp242      [V255    ] ( 10, 2261.50)     ref  ->  [rbp-0xF0]  do-not-enreg[X] addr-exposed "field V147.NfaState (fldOffset=0x0)" P-DEP
-;  V256 tmp243      [V256    ] ( 10, 1505.46)     int  ->  [rbp-0xE8]  do-not-enreg[X] addr-exposed "field V147.DfaStateId (fldOffset=0x8)" P-DEP
-;  V257 tmp244      [V257,T83] (  4,  749.42)   byref  ->  [rbp-0x1E0]  "field V148._reference (fldOffset=0x0)" P-INDEP
-;  V258 tmp245      [V258,T84] (  4,  749.42)     int  ->   r9         "field V148._length (fldOffset=0x8)" P-INDEP
+;  V255 tmp242      [V255    ] ( 12, 2195.50)     ref  ->  [rbp-0xF8]  do-not-enreg[X] addr-exposed "field V147.NfaState (fldOffset=0x0)" P-DEP
+;  V256 tmp243      [V256    ] ( 10, 1463.67)     int  ->  [rbp-0xF0]  do-not-enreg[X] addr-exposed "field V147.DfaStateId (fldOffset=0x8)" P-DEP
+;  V257 tmp244      [V257,T86] (  2,  724.52)   byref  ->  [rbp-0x218]  spill-single-def "field V148._reference (fldOffset=0x0)" P-INDEP
+;  V258 tmp245      [V258,T87] (  2,  724.52)     int  ->  [rbp-0x124]  spill-single-def "field V148._length (fldOffset=0x8)" P-INDEP
 ;* V259 tmp246      [V259    ] (  0,    0   )   byref  ->  zero-ref    "field V162._reference (fldOffset=0x0)" P-INDEP
 ;* V260 tmp247      [V260    ] (  0,    0   )     int  ->  zero-ref    "field V162._length (fldOffset=0x8)" P-INDEP
 ;* V261 tmp248      [V261    ] (  0,    0   )   byref  ->  zero-ref    "field V173._reference (fldOffset=0x0)" P-INDEP
@@ -1082,40 +1082,38 @@ G_M11802_IG06:
 ;* V265 tmp252      [V265,T145] (  0,    0   )     int  ->  zero-ref    "field V187.<Index>k__BackingField (fldOffset=0x10)" P-INDEP
 ;* V266 tmp253      [V266,T146] (  0,    0   )     int  ->  zero-ref    "field V187.<Length>k__BackingField (fldOffset=0x14)" P-INDEP
 ;* V267 tmp254      [V267    ] (  0,    0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V268 tmp255      [V268,T149] (  3,    0.05)     ref  ->  rcx         single-def "argument with side effect"
-;  V269 tmp256      [V269    ] (111, 4679.54)  struct (16) [rbp-0x128]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V270 tmp257      [V270,T162] (  6,    0   )     ref  ->  r10         "arr expr"
-;  V271 tmp258      [V271,T11] (  6, 4531.73)     ref  ->  rdx         "arr expr"
-;  V272 tmp259      [V272,T163] (  6,    0   )     ref  ->  rdx         "arr expr"
-;  V273 tmp260      [V273,T164] (  6,    0   )     ref  ->  r11         "arr expr"
-;  V274 tmp261      [V274,T179] (  4,    0   )     ref  ->   r8         "argument with side effect"
-;  V275 tmp262      [V275,T107] (  6,   17.91)     ref  ->   r9         "arr expr"
-;  V276 tmp263      [V276,T108] (  6,   17.91)     ref  ->  rcx         "arr expr"
-;  V277 tmp264      [V277,T109] (  6,   17.91)     ref  ->  rdx         "arr expr"
-;  V278 tmp265      [V278,T92] (  6,   71.66)     ref  ->   r9         "arr expr"
-;  V279 tmp266      [V279,T180] (  4,    0   )     ref  ->  rax         "argument with side effect"
-;  V280 tmp267      [V280,T18] (  6, 4472.64)     ref  ->  registers   "arr expr"
-;  V281 tmp268      [V281,T19] (  6, 4472.64)     ref  ->  rax         "arr expr"
-;  V282 tmp269      [V282,T20] (  6, 4472.64)     int  ->  r10         "index expr"
-;  V283 tmp270      [V283,T186] (  4,    0   )     int  ->  registers   "argument with side effect"
-;  V284 tmp271      [V284,T14] (  6, 4478.56)     ref  ->  rdx         "arr expr"
-;  V285 tmp272      [V285,T56] (  3,   44.78)     ref  ->  rdx         "arr expr"
-;  V286 tmp273      [V286,T15] (  6, 4477.78)     ref  ->  rbx         "arr expr"
-;  V287 PSPSym      [V287,T147] (  1,    1   )    long  ->  [rbp-0x1F0]  do-not-enreg[V] "PSPSym"
-;  V288 cse0        [V288,T53] (  3, 2216.76)     int  ->  rbx         "CSE #53: conservative"
-;  V289 cse1        [V289,T54] (  3, 2213.96)     ref  ->  rax         "CSE #46: conservative"
-;  V290 cse2        [V290,T49] (  4, 2228.00)     int  ->  r15         "CSE #12: conservative"
-;  V291 cse3        [V291,T50] (  2, 1485.33)     int  ->  [rbp-0x12C]  spill-single-def "CSE #11: conservative"
-;  V292 cse4        [V292,T51] (  3, 2228.00)     int  ->  r15         "CSE #10: conservative"
-;  V293 cse5        [V293,T141] (  2,    1.48)     int  ->  r10         "CSE #13: conservative"
-;  V294 cse6        [V294,T138] (  3,    2.22)     int  ->  rdx         "CSE #21: conservative"
-;  V295 cse7        [V295,T52] (  3, 2216.89)     ref  ->  rdx         "CSE #06: conservative"
-;  V296 cse8        [V296,T99] (  6,   37.51)     ref  ->  [rbp-0x1E8]  spill-single-def "CSE #64: conservative"
-;  V297 cse9        [V297,T103] (  3,   35.47)     ref  ->  rdx         "CSE #15: conservative"
-;  V298 cse10       [V298,T105] (  3,   22.39)     ref  ->  rdx         "CSE #62: conservative"
-;  V299 cse11       [V299,T25] (  6, 3689.93)     int  ->  [rbp-0x130]  spill-single-def "CSE #44: moderate"
+;  V268 tmp255      [V268,T147] (  3,    0.01)     ref  ->  rcx         single-def "argument with side effect"
+;  V269 tmp256      [V269    ] (111, 4934.68)  struct (16) [rbp-0x138]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V270 tmp257      [V270,T160] (  6,    0   )     ref  ->  r10         "arr expr"
+;  V271 tmp258      [V271,T19] (  6, 4380.65)     ref  ->  r10         "arr expr"
+;  V272 tmp259      [V272,T161] (  6,    0   )     ref  ->   r8         "arr expr"
+;  V273 tmp260      [V273,T162] (  6,    0   )     ref  ->  rcx         "arr expr"
+;  V274 tmp261      [V274,T177] (  4,    0   )     ref  ->   r8         "argument with side effect"
+;  V275 tmp262      [V275,T104] (  6,   67.96)     ref  ->  registers   "arr expr"
+;  V276 tmp263      [V276,T105] (  6,   67.96)     ref  ->   r8         "arr expr"
+;  V277 tmp264      [V277,T106] (  6,   67.96)     ref  ->  r11         "arr expr"
+;  V278 tmp265      [V278,T91] (  6,  271.84)     ref  ->  r11         "arr expr"
+;  V279 tmp266      [V279,T178] (  4,    0   )     ref  ->  rax         "argument with side effect"
+;  V280 tmp267      [V280,T14] (  6, 4402.16)     ref  ->  registers   "arr expr"
+;  V281 tmp268      [V281,T15] (  6, 4402.16)     ref  ->  registers   "arr expr"
+;  V282 tmp269      [V282,T16] (  6, 4402.16)     int  ->  r11         "index expr"
+;  V283 tmp270      [V283,T184] (  4,    0   )     int  ->  registers   "argument with side effect"
+;  V284 tmp271      [V284,T10] (  6, 4408.00)     ref  ->  rax         "arr expr"
+;  V285 tmp272      [V285,T54] (  3,   44.05)     ref  ->  rcx         "arr expr"
+;  V286 tmp273      [V286,T11] (  6, 4405.21)     ref  ->  rbx         "arr expr"
+;  V287 PSPSym      [V287,T142] (  1,    1   )    long  ->  [rbp-0x230]  do-not-enreg[V] "PSPSym"
+;  V288 cse0        [V288,T50] (  3, 2181.50)     int  ->  rbx         "CSE #53: conservative"
+;  V289 cse1        [V289,T51] (  3, 2179.07)     ref  ->   r9         "CSE #46: conservative"
+;  V290 cse2        [V290,T47] (  4, 2181.96)     int  ->  r13         "CSE #12: conservative"
+;  V291 cse3        [V291,T48] (  2, 1454.64)     int  ->  [rbp-0x13C]  spill-single-def "CSE #11: conservative"
+;  V292 cse4        [V292,T49] (  3, 2181.96)     int  ->  r13         "CSE #10: conservative"
+;  V293 cse5        [V293,T46] (  5, 2181.96)     ref  ->  r11         "CSE #06: conservative"
+;  V294 cse6        [V294,T101] (  3,  134.56)     ref  ->  rcx         "CSE #15: conservative"
+;  V295 cse7        [V295,T112] (  6,   36.73)     ref  ->  [rbp-0x220]  spill-single-def "CSE #64: conservative"
+;  V296 cse8        [V296,T121] (  5,   22.04)     ref  ->  rbx         "CSE #62: conservative"
+;  V297 cse9        [V297,T25] (  6, 3631.78)     int  ->  [rbp-0x140]  spill-single-def "CSE #44: moderate"
 ;
-; Lcl frame size = 520
+; Lcl frame size = 584
 
 G_M16487_IG01:
        push     rbp
@@ -1126,11 +1124,12 @@ G_M16487_IG01:
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 520
-       lea      rbp, [rsp+0x240]
+       sub      rsp, 584
+       lea      rbp, [rsp+0x280]
        xor      eax, eax
-       mov      qword ptr [rbp-0x128], rax
+       mov      qword ptr [rbp-0x138], rax
        vxorps   xmm4, xmm4, xmm4
+       vmovdqa  xmmword ptr [rbp-0x130], xmm4
        vmovdqa  xmmword ptr [rbp-0x120], xmm4
        mov      rax, -192
        vmovdqa  xmmword ptr [rbp+rax-0x50], xmm4
@@ -1139,1373 +1138,1382 @@ G_M16487_IG01:
        add      rax, 48
        jne      SHORT  -5 instr
        mov      qword ptr [rbp-0x50], rax
-       mov      qword ptr [rbp-0x1F0], rsp
+       mov      qword ptr [rbp-0x230], rsp
        mov      gword ptr [rbp+0x10], rcx
        mov      rax, rcx
        mov      r13, rdx
        mov      ebx, r9d
-       mov      rsi, bword ptr [rbp+0x30]
-       mov      rdi, gword ptr [rbp+0x38]
-       mov      r14d, dword ptr [rbp+0x40]
-						;; size=118 bbWeight=1 PerfScore 26.58
+       mov      r15, gword ptr [rbp+0x38]
+       mov      esi, dword ptr [rbp+0x40]
+       mov      edi, dword ptr [rbp+0x48]
+						;; size=124 bbWeight=1 PerfScore 28.58
 G_M16487_IG02:
        mov      r12, bword ptr [r8]
        mov      edx, dword ptr [r8+0x08]
-       mov      dword ptr [rbp-0x110], edx
+       mov      dword ptr [rbp-0x118], edx
        cmp      byte  ptr [rax], al
        lea      rcx, bword ptr [rax+0x38]
        xor      r8, r8
        xchg     gword ptr [rcx], r8
        test     r8, r8
-       je       G_M16487_IG316
+       je       G_M16487_IG334
 						;; size=34 bbWeight=1 PerfScore 30.00
 G_M16487_IG03:
-       mov      gword ptr [rbp-0x138], r8
+       mov      gword ptr [rbp-0x148], r8
 						;; size=7 bbWeight=1 PerfScore 1.00
 G_M16487_IG04:
-       mov      gword ptr [rbp-0x140], r8
+       mov      gword ptr [rbp-0x150], r8
        lea      rcx, bword ptr [r8+0x08]
        mov      gword ptr [rbp+0x18], r13
        mov      rdx, r13
        call     CORINFO_HELP_ASSIGN_REF
        mov      rax, gword ptr [rbp+0x10]
        mov      rdx, qword ptr [rax+0x48]
-       mov      rcx, gword ptr [rbp-0x140]
+       mov      rcx, gword ptr [rbp-0x150]
        call     [System.Text.RegularExpressions.RegexRunner:InitializeTimeout(System.TimeSpan):this]
        mov      dword ptr [rbp-0x3C], ebx
+       test     r15, r15
+       je       G_M16487_IG150
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        cmp      qword ptr [r8], rcx
-       jne      G_M16487_IG147
-						;; size=73 bbWeight=1 PerfScore 17.00
+       jne      G_M16487_IG150
+       mov      rcx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
+       mov      gword ptr [rbp+0x38], r15
+       cmp      qword ptr [r15+0x18], rcx
+       mov      r15, gword ptr [rbp+0x38]
+       jne      G_M16487_IG150
+						;; size=110 bbWeight=1 PerfScore 24.50
 G_M16487_IG05:
-       mov      dword ptr [rbp+0x40], r14d
-       mov      dword ptr [r8+0x60], r14d
+       mov      dword ptr [r8+0x60], esi
        lea      rcx, bword ptr [r8+0x30]
        mov      rdx, gword ptr [rbp+0x10]
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      dword ptr [r8+0x48], ebx
        xor      ecx, ecx
        mov      dword ptr [r8+0x40], ecx
-       mov      eax, dword ptr [rbp-0x110]
-       mov      dword ptr [r8+0x44], eax
+       mov      r15d, dword ptr [rbp-0x118]
+       mov      dword ptr [r8+0x44], r15d
        mov      dword ptr [r8+0x4C], ebx
        mov      rbx, gword ptr [r8+0x28]
        test     rbx, rbx
-       je       G_M16487_IG225
+       je       G_M16487_IG219
        mov      rdx, gword ptr [r8+0x08]
        lea      rcx, bword ptr [rbx+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        xor      edx, edx
        mov      dword ptr [rbx+0x34], edx
-       mov      eax, dword ptr [rbp-0x110]
-       mov      dword ptr [rbx+0x5C], eax
-       mov      r10, gword ptr [rbx+0x50]
-						;; size=96 bbWeight=738.96 PerfScore 16811.39
+       mov      dword ptr [rbx+0x5C], r15d
+       mov      rax, gword ptr [rbx+0x50]
+						;; size=88 bbWeight=727.32 PerfScore 15091.88
 G_M16487_IG06:
-       cmp      dword ptr [r10+0x08], 0
+       cmp      dword ptr [rax+0x08], 0
        jle      SHORT G_M16487_IG08
-       align    [1 bytes for IG07]
-						;; size=8 bbWeight=738.96 PerfScore 3140.59
+       align    [15 bytes for IG07]
+						;; size=21 bbWeight=727.32 PerfScore 3091.11
 G_M16487_IG07:
        mov      ecx, edx
        xor      r8d, r8d
-       mov      dword ptr [r10+4*rcx+0x10], r8d
+       mov      dword ptr [rax+4*rcx+0x10], r8d
        inc      edx
-       cmp      dword ptr [r10+0x08], edx
+       cmp      dword ptr [rax+0x08], edx
        jg       SHORT G_M16487_IG07
-						;; size=18 bbWeight=748.75 PerfScore 4305.33
+						;; size=17 bbWeight=735.56 PerfScore 4229.47
 G_M16487_IG08:
        mov      byte  ptr [rbx+0x60], 0
-       mov      r11, gword ptr [rbx+0x38]
-       test     r11, r11
-       jne      G_M16487_IG224
-						;; size=17 bbWeight=738.96 PerfScore 3140.59
+       mov      r10, gword ptr [rbx+0x38]
+       test     r10, r10
+       jne      G_M16487_IG218
+						;; size=17 bbWeight=727.32 PerfScore 3091.11
 G_M16487_IG09:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      rdx, gword ptr [r8+0x20]
-       test     rdx, rdx
-       je       G_M16487_IG228
-       mov      rcx, gword ptr [r8+0x10]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x50], ecx
-       mov      rcx, gword ptr [r8+0x18]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x54], ecx
-       mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r8+0x58], edx
-						;; size=49 bbWeight=738.96 PerfScore 12747.10
+       mov      r8, gword ptr [rbp-0x148]
+       mov      r11, gword ptr [r8+0x20]
+       test     r11, r11
+       je       G_M16487_IG47
+						;; size=20 bbWeight=727.32 PerfScore 3091.11
 G_M16487_IG10:
+       mov      rdx, gword ptr [r8+0x10]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x50], edx
+       mov      rdx, gword ptr [r8+0x18]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x54], edx
+       mov      edx, dword ptr [r11+0x08]
+       mov      dword ptr [r8+0x58], edx
+						;; size=30 bbWeight=727.32 PerfScore 9455.15
+G_M16487_IG11:
        mov      ebx, dword ptr [rbp-0x3C]
        mov      dword ptr [r8+0x4C], ebx
        mov      rbx, r8
-       mov      r9d, eax
+       mov      dword ptr [rbp-0x11C], r15d
        mov      rcx, gword ptr [rbx+0x70]
        mov      edx, dword ptr [rbx+0x60]
        mov      dword ptr [rbp-0x70], edx
-       mov      bword ptr [rbp-0x1D0], r12
-       mov      r11d, dword ptr [rbx+0x4C]
-       mov      r13, gword ptr [rbx+0x78]
-       xor      r15d, r15d
-       mov      qword ptr [rbp-0x68], r15
+       mov      bword ptr [rbp-0x208], r12
+       mov      r10d, dword ptr [rbx+0x4C]
+       mov      r11, gword ptr [rbx+0x78]
+       mov      gword ptr [rbp-0x168], r11
+       xor      r13d, r13d
+       mov      qword ptr [rbp-0x68], r13
        cmp      byte  ptr [rcx+0xAC], 0
-       jne      G_M16487_IG221
-						;; size=58 bbWeight=738.96 PerfScore 13116.58
-G_M16487_IG11:
-       mov      r15, gword ptr [rcx+0x60]
-       mov      r15d, dword ptr [r15+0x34]
-       mov      r14d, r15d
-       and      r14d, 256
-       mov      dword ptr [rbp-0x12C], r14d
-       xor      r14d, r14d
-       cmp      gword ptr [rcx+0x70], 0
-       setne    r14b
-       and      r15d, 16
-       setne    r10b
-       movzx    r10, r10b
-       cmp      dword ptr [rbp-0x12C], 0
-       jne      G_M16487_IG99
-						;; size=62 bbWeight=742.67 PerfScore 10583.01
+       jne      G_M16487_IG215
+						;; size=69 bbWeight=727.32 PerfScore 14182.73
 G_M16487_IG12:
-       test     r14d, r14d
-       je       G_M16487_IG51
-       test     r10d, r10d
-       jne      G_M16487_IG232
-       mov      r14, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x1E0], r14
-       mov      dword ptr [rbp-0xD8], r11d
-       mov      r10d, dword ptr [rbp-0xD8]
-       mov      dword ptr [rbp-0x78], r10d
-       mov      r10d, dword ptr [rbp-0xD8]
-       mov      dword ptr [rbp-0xE0], r10d
-       mov      r10, gword ptr [rcx+0x80]
-       mov      r14d, dword ptr [rbp-0xD8]
-       dec      r14d
-       test     r15d, r15d
-       jne      G_M16487_IG233
-       xor      r9d, r9d
-						;; size=93 bbWeight=741.93 PerfScore 10572.48
+       mov      r13, gword ptr [rcx+0x60]
+       mov      r13d, dword ptr [r13+0x34]
+       mov      eax, r13d
+       and      eax, 256
+       mov      dword ptr [rbp-0x13C], eax
+       xor      eax, eax
+       cmp      gword ptr [rcx+0x70], 0
+       setne    al
+       and      r13d, 16
+       setne    r9b
+       movzx    r9, r9b
+       cmp      dword ptr [rbp-0x13C], 0
+       jne      G_M16487_IG107
+						;; size=57 bbWeight=727.32 PerfScore 10364.30
 G_M16487_IG13:
-       cmp      r9d, dword ptr [r10+0x08]
-       jae      G_M16487_IG315
-       mov      r9d, r9d
-       mov      r9, gword ptr [r10+8*r9+0x10]
-       mov      r9d, dword ptr [r9+0x14]
-       mov      dword ptr [rbp-0xE8], r9d
-       xor      r9, r9
-       mov      gword ptr [rbp-0xF0], r9
-       mov      dword ptr [rbp-0xF8], -2
-       mov      dword ptr [rbp-0x100], -1
-						;; size=59 bbWeight=741.93 PerfScore 9274.10
+       test     eax, eax
+       je       G_M16487_IG54
+       test     r9d, r9d
+       jne      G_M16487_IG227
+						;; size=17 bbWeight=724.52 PerfScore 1811.29
 G_M16487_IG14:
-       cmp      byte  ptr [rcx+0xAC], 0
-       jne      G_M16487_IG234
-						;; size=13 bbWeight=748.48 PerfScore 2993.91
+       mov      rax, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x218], rax
+       mov      r9d, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x124], r9d
+       mov      dword ptr [rbp-0xE0], r10d
+       mov      eax, dword ptr [rbp-0xE0]
+       mov      dword ptr [rbp-0x78], eax
+       mov      eax, dword ptr [rbp-0xE0]
+       mov      dword ptr [rbp-0xE8], eax
+       mov      rax, gword ptr [rcx+0x80]
+       mov      r9d, dword ptr [rbp-0xE0]
+       dec      r9d
+       test     r13d, r13d
+       jne      G_M16487_IG228
+       xor      r9d, r9d
+						;; size=85 bbWeight=724.52 PerfScore 9962.10
 G_M16487_IG15:
-       mov      r14d, eax
-						;; size=3 bbWeight=748.48 PerfScore 187.12
+       cmp      r9d, dword ptr [rax+0x08]
+       jae      G_M16487_IG205
+       mov      r9d, r9d
+       mov      r9, gword ptr [rax+8*r9+0x10]
+       mov      r9d, dword ptr [r9+0x14]
+       mov      dword ptr [rbp-0xF0], r9d
+       xor      r9, r9
+       mov      gword ptr [rbp-0xF8], r9
+       mov      dword ptr [rbp-0x100], -2
+       mov      dword ptr [rbp-0x108], -1
+						;; size=59 bbWeight=724.52 PerfScore 9056.45
 G_M16487_IG16:
-       cmp      gword ptr [rbp-0xF0], 0
-       jne      G_M16487_IG235
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      r9, [rbp-0xD8]
+       cmp      byte  ptr [rcx+0xAC], 0
+       jne      G_M16487_IG229
+						;; size=13 bbWeight=724.52 PerfScore 2898.06
+G_M16487_IG17:
+       mov      r13d, r15d
+       cmp      gword ptr [rbp-0xF8], 0
+       mov      dword ptr [rbp-0x6C], r10d
+       jne      G_M16487_IG46
+						;; size=21 bbWeight=724.52 PerfScore 3079.19
+G_M16487_IG18:
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       lea      r9, [rbp-0xE0]
        mov      qword ptr [rsp+0x20], r9
-       lea      r9, [rbp-0xF0]
-       mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0xF8]
-       mov      qword ptr [rsp+0x30], r9
+       mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x100]
+       mov      qword ptr [rsp+0x30], r9
+       lea      r9, [rbp-0x108]
        mov      qword ptr [rsp+0x38], r9
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x40], r9
-       lea      r9, [rbp-0xE0]
+       lea      r9, [rbp-0xE8]
        mov      qword ptr [rsp+0x48], r9
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      r8d, r14d
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      r8d, r13d
        mov      r9d, dword ptr [rbp-0x70]
        call     [<unknown method>]
-						;; size=127 bbWeight=748.48 PerfScore 15530.91
-G_M16487_IG17:
-       test     eax, eax
-       je       G_M16487_IG236
-						;; size=8 bbWeight=748.48 PerfScore 935.60
-G_M16487_IG18:
-       lea      r14, bword ptr [rbp-0x80]
-       cmp      dword ptr [rbp-0x100], 0
-       jle      G_M16487_IG57
-						;; size=17 bbWeight=748.48 PerfScore 2619.67
+						;; size=110 bbWeight=724.52 PerfScore 12135.65
 G_M16487_IG19:
-       mov      ecx, dword ptr [rbp-0x100]
-       mov      r15, gword ptr [rbp-0x150]
-       mov      rdx, gword ptr [r15+0x10]
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       mov      eax, ecx
-       mov      rax, gword ptr [rdx+8*rax+0x10]
-       mov      r8d, dword ptr [rbp-0xF8]
-       mov      rcx, gword ptr [r15+0x60]
-       test     byte  ptr [rcx+0x34], 16
-       jne      G_M16487_IG53
-       xor      ecx, ecx
-						;; size=56 bbWeight=747.74 PerfScore 13085.37
+       test     eax, eax
+       je       G_M16487_IG233
+						;; size=8 bbWeight=724.52 PerfScore 905.65
 G_M16487_IG20:
+       lea      r13, bword ptr [rbp-0x80]
+       cmp      dword ptr [rbp-0x108], 0
+       jle      G_M16487_IG61
+						;; size=17 bbWeight=724.52 PerfScore 2535.81
+G_M16487_IG21:
+       mov      edx, dword ptr [rbp-0x108]
+       mov      r8, gword ptr [rbp-0x160]
+       mov      r10, gword ptr [r8+0x10]
+       cmp      edx, dword ptr [r10+0x08]
+       jae      G_M16487_IG205
+       mov      eax, edx
+       mov      rax, gword ptr [r10+8*rax+0x10]
+       mov      r9d, dword ptr [rbp-0x100]
+       mov      gword ptr [rbp-0x160], r8
+       mov      rcx, gword ptr [r8+0x60]
+       test     byte  ptr [rcx+0x34], 16
+       jne      G_M16487_IG56
+       xor      ecx, ecx
+						;; size=64 bbWeight=722.81 PerfScore 13371.94
+G_M16487_IG22:
        shl      ecx, 3
        or       ecx, dword ptr [rax+0x10]
-       mov      dword ptr [rbp-0x108], ecx
-       mov      r10, gword ptr [rax+0x08]
-       mov      gword ptr [rbp-0x1A8], r10
-       cmp      byte  ptr [r10], r10b
+       mov      dword ptr [rbp-0x10C], ecx
+       mov      r11, gword ptr [rax+0x08]
+       mov      gword ptr [rbp-0x1C8], r11
+       cmp      byte  ptr [r11], r11b
        call     <unknown method>
        test     eax, eax
-       je       G_M16487_IG239
-       mov      rax, gword ptr [rbp-0x1A8]
+       je       G_M16487_IG237
+       mov      rax, gword ptr [rbp-0x1C8]
        mov      r8d, dword ptr [rax+0x28]
        cmp      r8d, 2
-       je       G_M16487_IG102
-						;; size=60 bbWeight=747.74 PerfScore 12711.51
-G_M16487_IG21:
-       cmp      r8d, 4
-       je       G_M16487_IG100
-						;; size=10 bbWeight=498.49 PerfScore 623.11
-G_M16487_IG22:
-       cmp      r8d, 13
-       jne      G_M16487_IG217
-       mov      r10d, dword ptr [rax+0x2C]
-						;; size=14 bbWeight=249.25 PerfScore 810.05
+       je       G_M16487_IG108
+						;; size=60 bbWeight=722.81 PerfScore 12287.73
 G_M16487_IG23:
-       mov      dword ptr [r14], r10d
-       mov      eax, dword ptr [rbp-0xF8]
-						;; size=9 bbWeight=741.93 PerfScore 1483.86
+       cmp      r8d, 4
+       je       G_M16487_IG102
+						;; size=10 bbWeight=481.87 PerfScore 602.34
 G_M16487_IG24:
-       mov      r14d, eax
-       cmp      r14d, -2
-       je       G_M16487_IG55
-						;; size=13 bbWeight=738.96 PerfScore 1108.44
+       cmp      r8d, 13
+       jne      G_M16487_IG214
+       mov      ecx, dword ptr [rax+0x2C]
+						;; size=13 bbWeight=240.94 PerfScore 783.04
 G_M16487_IG25:
-       mov      r8d, dword ptr [rbp-0x70]
-       test     r8d, r8d
-       je       G_M16487_IG242
+       mov      dword ptr [r13], ecx
+       mov      r13d, dword ptr [rbp-0x100]
+						;; size=11 bbWeight=724.52 PerfScore 1449.03
+G_M16487_IG26:
+       cmp      r13d, -2
+       je       G_M16487_IG59
+						;; size=10 bbWeight=727.32 PerfScore 909.15
+G_M16487_IG27:
+       mov      eax, dword ptr [rbp-0x70]
+       test     eax, eax
+       je       G_M16487_IG57
        cmp      dword ptr [rbp-0x80], 0
        jl       G_M16487_IG243
-       mov      r9d, r14d
-       sub      r9d, dword ptr [rbp-0x80]
-						;; size=30 bbWeight=737.93 PerfScore 5534.48
-G_M16487_IG26:
-       cmp      dword ptr [r15+0xA8], 1
+       mov      r8d, r13d
+       sub      r8d, dword ptr [rbp-0x80]
+						;; size=28 bbWeight=726.36 PerfScore 5447.68
+G_M16487_IG28:
+       mov      r10, gword ptr [rbp-0x160]
+       cmp      dword ptr [r10+0xA8], 1
        jg       G_M16487_IG252
-						;; size=14 bbWeight=737.93 PerfScore 2951.72
-G_M16487_IG27:
-       sub      r14d, r9d
+						;; size=21 bbWeight=726.36 PerfScore 3631.79
+G_M16487_IG29:
+       sub      r13d, r8d
        xor      rcx, rcx
        mov      gword ptr [rbp-0x60], rcx
-						;; size=9 bbWeight=737.93 PerfScore 1106.90
-G_M16487_IG28:
-       mov      gword ptr [rbp-0x58], rcx
-       mov      dword ptr [rbp-0x50], r9d
-       mov      dword ptr [rbp-0x4C], r14d
-						;; size=12 bbWeight=737.93 PerfScore 2213.79
-G_M16487_IG29:
-       mov      r14, gword ptr [rbp-0x60]
-       mov      r15, gword ptr [rbp-0x58]
-       mov      r13d, dword ptr [rbp-0x50]
-       mov      r11d, dword ptr [rbp-0x4C]
-       test     r13d, r13d
-       jl       G_M16487_IG95
-						;; size=25 bbWeight=738.96 PerfScore 3879.55
+						;; size=9 bbWeight=726.36 PerfScore 1089.54
 G_M16487_IG30:
-       lea      ecx, [r11+r13]
-       cmp      dword ptr [rbx+0x60], 2
-       je       G_M16487_IG255
-						;; size=14 bbWeight=737.99 PerfScore 3320.94
+       mov      gword ptr [rbp-0x58], rcx
+       mov      dword ptr [rbp-0x50], r8d
+       mov      dword ptr [rbp-0x4C], r13d
+						;; size=12 bbWeight=726.36 PerfScore 2179.07
 G_M16487_IG31:
-       mov      r15d, r13d
-       mov      r14d, ecx
-       cmp      r14d, r15d
-       jl       G_M16487_IG259
-						;; size=15 bbWeight=737.99 PerfScore 1291.48
+       mov      r13, gword ptr [rbp-0x60]
+       mov      r9, gword ptr [rbp-0x58]
+       mov      ecx, dword ptr [rbp-0x50]
+       mov      r11d, dword ptr [rbp-0x4C]
+       test     ecx, ecx
+       jl       G_M16487_IG101
+						;; size=23 bbWeight=727.32 PerfScore 3818.43
 G_M16487_IG32:
-       cmp      dword ptr [rbx+0x58], 0
-       je       G_M16487_IG260
-						;; size=10 bbWeight=737.99 PerfScore 2951.94
+       lea      edx, [rcx+r11]
+       cmp      dword ptr [rbx+0x60], 2
+       je       G_M16487_IG256
+						;; size=14 bbWeight=726.36 PerfScore 3268.61
 G_M16487_IG33:
-       mov      rdx, gword ptr [rbx+0x20]
-       mov      eax, dword ptr [rbx+0x58]
-       dec      eax
-       mov      dword ptr [rbx+0x58], eax
-       cmp      eax, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       xor      r8d, r8d
-       mov      dword ptr [rdx+4*rax+0x10], r8d
-       mov      r13, gword ptr [rbx+0x28]
-       mov      rax, gword ptr [r13+0x48]
-       cmp      dword ptr [rax+0x08], 0
-       jbe      G_M16487_IG315
-       cmp      gword ptr [rax+0x10], 0
-       mov      gword ptr [rbp-0x1B8], rax
-       je       G_M16487_IG261
-						;; size=65 bbWeight=737.99 PerfScore 17342.67
+       mov      r13d, ecx
+       mov      eax, edx
+       cmp      eax, r13d
+       jl       G_M16487_IG261
+						;; size=14 bbWeight=726.36 PerfScore 1271.12
 G_M16487_IG34:
-       mov      r8, gword ptr [r13+0x48]
-       mov      r13, gword ptr [r13+0x50]
-       cmp      dword ptr [r13+0x08], 0
-       jbe      G_M16487_IG315
-       mov      edx, dword ptr [r13+0x10]
-       cmp      dword ptr [r8+0x08], 0
-       jbe      G_M16487_IG315
-       mov      rax, gword ptr [r8+0x10]
-       lea      r10d, [rdx+rdx]
-       mov      dword ptr [rbp-0x130], r10d
-       lea      r9d, [r10+0x02]
-       cmp      dword ptr [rax+0x08], r9d
-       jl       G_M16487_IG262
-						;; size=63 bbWeight=737.99 PerfScore 16235.69
+       cmp      dword ptr [rbx+0x58], 0
+       je       G_M16487_IG262
+						;; size=10 bbWeight=726.36 PerfScore 2905.43
 G_M16487_IG35:
-       cmp      dword ptr [r8+0x08], 0
-       jbe      G_M16487_IG315
-       mov      rax, gword ptr [r8+0x10]
-       mov      r9, rax
-       cmp      r10d, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       mov      r8d, r10d
-       mov      dword ptr [r9+4*r8+0x10], r15d
-       inc      r10d
-       cmp      r10d, dword ptr [rax+0x08]
-       jae      G_M16487_IG315
-       mov      r8d, r10d
-       sub      r14d, r15d
-       mov      dword ptr [rax+4*r8+0x10], r14d
-       cmp      dword ptr [r13+0x08], 0
-       jbe      G_M16487_IG315
-       inc      edx
-       mov      dword ptr [r13+0x10], edx
-						;; size=77 bbWeight=737.99 PerfScore 16604.69
+       mov      r8, gword ptr [rbx+0x20]
+       mov      r10d, dword ptr [rbx+0x58]
+       dec      r10d
+       mov      dword ptr [rbx+0x58], r10d
+       cmp      r10d, dword ptr [r8+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, r10d
+       xor      r10d, r10d
+       mov      dword ptr [r8+4*rcx+0x10], r10d
+       mov      r10, gword ptr [rbx+0x28]
+       mov      rcx, gword ptr [r10+0x48]
+       cmp      dword ptr [rcx+0x08], 0
+       jbe      G_M16487_IG205
+       cmp      gword ptr [rcx+0x10], 0
+       mov      gword ptr [rbp-0x1E0], rcx
+       je       G_M16487_IG263
+						;; size=72 bbWeight=726.36 PerfScore 17250.98
 G_M16487_IG36:
-       mov      dword ptr [rbx+0x4C], ecx
-       mov      r14d, dword ptr [rbp-0x110]
-						;; size=10 bbWeight=737.99 PerfScore 1475.97
+       mov      r8, gword ptr [r10+0x48]
+       mov      r10, gword ptr [r10+0x50]
+       cmp      dword ptr [r10+0x08], 0
+       jbe      G_M16487_IG205
+       mov      ecx, dword ptr [r10+0x10]
+       cmp      dword ptr [r8+0x08], 0
+       jbe      G_M16487_IG205
+       mov      r9, gword ptr [r8+0x10]
+       lea      r11d, [rcx+rcx]
+       mov      dword ptr [rbp-0x140], r11d
+       lea      r14d, [r11+0x02]
+       cmp      dword ptr [r9+0x08], r14d
+       jl       G_M16487_IG264
+						;; size=63 bbWeight=726.36 PerfScore 15979.85
 G_M16487_IG37:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      r13, gword ptr [r8+0x28]
-       mov      rdx, gword ptr [r13+0x50]
-       cmp      dword ptr [rdx+0x08], 0
-       jbe      G_M16487_IG315
-       mov      ebx, dword ptr [rdx+0x10]
-       test     ebx, ebx
-       jle      G_M16487_IG155
-						;; size=36 bbWeight=738.96 PerfScore 9052.29
+       cmp      dword ptr [r8+0x08], 0
+       jbe      G_M16487_IG205
+       mov      r9, gword ptr [r8+0x10]
+       mov      r8, r9
+       cmp      r11d, dword ptr [r8+0x08]
+       jae      G_M16487_IG205
+       mov      r14d, r11d
+       mov      dword ptr [r8+4*r14+0x10], r13d
+       inc      r11d
+       cmp      r11d, dword ptr [r9+0x08]
+       jae      G_M16487_IG205
+       mov      r8d, r11d
+       sub      eax, r13d
+       mov      dword ptr [r9+4*r8+0x10], eax
+       cmp      dword ptr [r10+0x08], 0
+       jbe      G_M16487_IG205
+       inc      ecx
+       mov      dword ptr [r10+0x10], ecx
+						;; size=77 bbWeight=726.36 PerfScore 16343.03
 G_M16487_IG38:
-       movzx    r15, byte  ptr [rbp+0x48]
-       test     r15b, r15b
-       je       G_M16487_IG54
-						;; size=14 bbWeight=739.57 PerfScore 1664.03
+       mov      dword ptr [rbx+0x4C], edx
+						;; size=3 bbWeight=726.36 PerfScore 726.36
 G_M16487_IG39:
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
+       mov      r13, gword ptr [r8+0x28]
+       mov      rax, gword ptr [r13+0x50]
+       cmp      dword ptr [rax+0x08], 0
+       jbe      G_M16487_IG205
+       mov      ebx, dword ptr [rax+0x10]
+       test     ebx, ebx
+       jle      G_M16487_IG173
+						;; size=36 bbWeight=727.32 PerfScore 8909.66
+G_M16487_IG40:
+       test     dil, dil
+       je       G_M16487_IG58
+						;; size=9 bbWeight=727.59 PerfScore 909.48
+G_M16487_IG41:
+       mov      r8, gword ptr [rbp-0x148]
        mov      eax, dword ptr [r8+0x4C]
-       mov      edx, dword ptr [r13+0x50]
+       mov      ecx, dword ptr [r13+0x50]
        mov      dword ptr [r13+0x30], ebx
-       xor      edx, edx
-       mov      dword ptr [r13+0x34], edx
+       xor      ecx, ecx
+       mov      dword ptr [r13+0x34], ecx
        mov      dword ptr [r13+0x58], eax
-       mov      edx, dword ptr [r13+0x5C]
-       mov      dword ptr [r13+0x5C], edx
+       mov      ecx, dword ptr [r13+0x5C]
+       mov      dword ptr [r13+0x5C], ecx
        mov      rbx, gword ptr [r13+0x48]
        cmp      dword ptr [rbx+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      r10, gword ptr [rbx+0x10]
        cmp      dword ptr [r10+0x08], 1
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      r9d, dword ptr [r10+0x14]
        mov      dword ptr [r13+0x14], r9d
        cmp      dword ptr [r10+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      r11d, dword ptr [r10+0x10]
        mov      dword ptr [r13+0x10], r11d
-       mov      ebx, dword ptr [rbp+0x40]
-       cmp      ebx, 2
-       je       G_M16487_IG265
-						;; size=105 bbWeight=738.83 PerfScore 26228.57
-G_M16487_IG40:
-       cmp      dword ptr [r13+0x30], 0
-       je       G_M16487_IG317
-						;; size=11 bbWeight=738.96 PerfScore 2955.85
-G_M16487_IG41:
-       mov      dword ptr [rbp+0x48], r15d
-       test     r15b, r15b
-       je       G_M16487_IG266
-						;; size=13 bbWeight=737.97 PerfScore 1660.44
-G_M16487_IG42:
-       mov      rdx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
-       cmp      qword ptr [rdi+0x18], rdx
-       jne      G_M16487_IG96
-       inc      dword ptr [rsi]
-						;; size=22 bbWeight=737.97 PerfScore 5350.30
-G_M16487_IG43:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      r10d, dword ptr [r8+0x4C]
-       mov      r9d, r10d
-       mov      dword ptr [rbp-0x3C], r9d
-       cmp      dword ptr [r13+0x14], 0
+       cmp      esi, 2
        je       G_M16487_IG267
-						;; size=29 bbWeight=737.97 PerfScore 6088.27
+						;; size=102 bbWeight=726.86 PerfScore 25076.67
+G_M16487_IG42:
+       cmp      dword ptr [r13+0x30], 0
+       je       G_M16487_IG335
+						;; size=11 bbWeight=727.32 PerfScore 2909.28
+G_M16487_IG43:
+       test     dil, dil
+       je       G_M16487_IG213
+						;; size=9 bbWeight=726.33 PerfScore 907.91
 G_M16487_IG44:
-       mov      rcx, gword ptr [r8+0x10]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x50], ecx
-       mov      rcx, gword ptr [r8+0x18]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x54], ecx
-       mov      rcx, gword ptr [r8+0x20]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x58], ecx
-       mov      r14d, ebx
-       mov      ebx, r9d
-       jmp      G_M16487_IG05
-						;; size=44 bbWeight=737.97 PerfScore 12914.51
+       mov      r14, bword ptr [rbp+0x30]
+       inc      dword ptr [r14]
+       mov      ebx, dword ptr [r8+0x4C]
+       mov      dword ptr [rbp-0x3C], ebx
+       cmp      dword ptr [r13+0x14], 0
+       je       G_M16487_IG269
+						;; size=25 bbWeight=726.33 PerfScore 7989.62
 G_M16487_IG45:
+       mov      rdx, gword ptr [r8+0x10]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x50], edx
+       mov      rdx, gword ptr [r8+0x18]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x54], edx
+       mov      rdx, gword ptr [r8+0x20]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x58], edx
+       jmp      G_M16487_IG05
+						;; size=38 bbWeight=726.33 PerfScore 12347.60
+G_M16487_IG46:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG230
+						;; size=9 bbWeight=362.26 PerfScore 1086.77
+G_M16487_IG47:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG222
+						;; size=9 bbWeight=363.66 PerfScore 1090.98
+G_M16487_IG48:
        mov      rcx, gword ptr [rax+0x10]
-       mov      edx, dword ptr [rbp-0xD0]
+       mov      edx, dword ptr [rbp-0xD8]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      G_M16487_IG93
-       align    [1 bytes for IG106]
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG99
+       align    [0 bytes for IG111]
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M16487_IG46:
+G_M16487_IG49:
        test     eax, eax
-       mov      rax, gword ptr [rbp-0x188]
-       je       SHORT G_M16487_IG45
-       jmp      G_M16487_IG92
-						;; size=16 bbWeight=0 PerfScore 0.00
-G_M16487_IG47:
-       mov      gword ptr [rbp-0x188], rax
-       mov      edx, dword ptr [rbp-0xD0]
+       mov      rax, gword ptr [rbp-0x1A0]
+       je       SHORT G_M16487_IG48
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG98
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M16487_IG50:
+       mov      gword ptr [rbp-0x1A0], rax
+       mov      r14, bword ptr [rbp+0x30]
+       mov      edx, dword ptr [rbp-0xD8]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:<IsNullableFor>g__WithCache|26_0(uint):ubyte:this]
-       jmp      SHORT G_M16487_IG46
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16487_IG48:
+       jmp      SHORT G_M16487_IG49
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16487_IG51:
+       mov      r14, bword ptr [rbp+0x30]
        mov      rcx, 0xD1FFAB1E      ; System.Func`2[uint,int]
        call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x190], rax
+       mov      gword ptr [rbp-0x1A8], rax
        lea      rcx, bword ptr [rax+0x08]
-       mov      rdx, gword ptr [rbp-0x188]
+       mov      rdx, gword ptr [rbp-0x1A0]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this
-       mov      rax, gword ptr [rbp-0x190]
+       mov      rax, gword ptr [rbp-0x1A8]
        mov      qword ptr [rax+0x18], rcx
        mov      rcx, rax
-       mov      edx, dword ptr [rbp-0xD0]
+       mov      edx, dword ptr [rbp-0xD8]
        call     [System.Threading.StackHelper:CallOnEmptyStack[uint,int](System.Func`2[uint,int],uint):int]
-       mov      r10d, eax
-       jmp      G_M16487_IG93
-						;; size=82 bbWeight=0 PerfScore 0.00
-G_M16487_IG49:
-       mov      gword ptr [rbp-0x160], rax
-       mov      rcx, gword ptr [r10+0x10]
-       mov      edx, r8d
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG99
+						;; size=87 bbWeight=0 PerfScore 0.00
+G_M16487_IG52:
+       mov      gword ptr [rbp-0x160], rdx
+       mov      gword ptr [rbp-0x178], rax
+       mov      dword ptr [rbp-0xD4], ecx
+       mov      r14, bword ptr [rbp+0x30]
+       mov      rcx, gword ptr [r8+0x10]
+       mov      edx, dword ptr [rbp-0xD4]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
-       mov      r8d, eax
-       mov      rax, gword ptr [rbp-0x160]
-       mov      ecx, dword ptr [rbp-0x110]
-       jmp      G_M16487_IG84
-						;; size=43 bbWeight=0 PerfScore 0.00
-G_M16487_IG50:
-       mov      gword ptr [rbp-0x150], rcx
-       mov      rcx, gword ptr [r15+0x10]
+       mov      edx, eax
+       mov      bword ptr [rbp+0x30], r14
+       mov      ecx, edx
+       mov      rax, gword ptr [rbp-0x178]
+       mov      rdx, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG90
+						;; size=69 bbWeight=0 PerfScore 0.00
+G_M16487_IG53:
+       mov      gword ptr [rbp-0x160], rcx
+       mov      r14, bword ptr [rbp+0x30]
+       mov      rcx, gword ptr [r13+0x10]
        mov      edx, r9d
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
-       mov      r15d, eax
-       mov      eax, dword ptr [rbp-0x110]
-       mov      rcx, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG62
-						;; size=43 bbWeight=0 PerfScore 0.00
-G_M16487_IG51:
-       test     r10d, r10d
-       jne      G_M16487_IG240
-       jmp      G_M16487_IG241
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M16487_IG52:
-       mov      r10, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r10
-       mov      dword ptr [rbp-0x120], r9d
+       mov      ecx, eax
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, ecx
+       mov      rcx, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG67
+						;; size=46 bbWeight=0 PerfScore 0.00
+G_M16487_IG54:
+       mov      r14, bword ptr [rbp+0x30]
+       test     r9d, r9d
+       jne      G_M16487_IG241
+       jmp      G_M16487_IG242
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M16487_IG55:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      rax, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], rax
+       mov      eax, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x130], eax
        mov      edx, dword ptr [rbp-0x70]
        mov      dword ptr [rsp+0x20], edx
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x80]
        mov      qword ptr [rsp+0x30], r9
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x38], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r8d, r10d
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=94 bbWeight=0 PerfScore 0.00
-G_M16487_IG53:
-       mov      gword ptr [rbp-0x1A0], rax
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
+       mov      edx, eax
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, edx
+       jmp      G_M16487_IG26
+						;; size=112 bbWeight=0 PerfScore 0.00
+G_M16487_IG56:
+       mov      gword ptr [rbp-0x1B8], rax
+       mov      r8, gword ptr [rbp-0x160]
+       mov      r14, bword ptr [rbp+0x30]
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r8
+       mov      rcx, r8
+       mov      r8d, r9d
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
-       mov      rdx, gword ptr [r15+0x98]
+       mov      rdx, gword ptr [rbp-0x160]
+       mov      r8, gword ptr [rdx+0x98]
        lea      ecx, [rax+0x01]
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
+       cmp      ecx, dword ptr [r8+0x08]
+       jae      G_M16487_IG205
        inc      eax
        mov      ecx, eax
-       mov      ecx, dword ptr [rdx+4*rcx+0x10]
-       mov      rax, gword ptr [rbp-0x1A0]
-       jmp      G_M16487_IG20
-						;; size=83 bbWeight=0 PerfScore 0.00
-G_M16487_IG54:
+       mov      ecx, dword ptr [r8+4*rcx+0x10]
+       mov      bword ptr [rbp+0x30], r14
+       mov      rax, gword ptr [rbp-0x1B8]
+       jmp      G_M16487_IG22
+						;; size=110 bbWeight=0 PerfScore 0.00
+G_M16487_IG57:
+       mov      r14, bword ptr [rbp+0x30]
+       lea      rcx, [rbp-0x60]
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicMatch:get_MatchExists():System.Text.RegularExpressions.Symbolic.SymbolicMatch]
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG31
+						;; size=23 bbWeight=0 PerfScore 0.00
+G_M16487_IG58:
        lea      rcx, bword ptr [r13+0x08]
        mov      rdx, gword ptr [rbp+0x18]
        call     CORINFO_HELP_ASSIGN_REF
-       xor      rdx, rdx
-       mov      r8, gword ptr [rbp-0x138]
-       mov      gword ptr [r8+0x28], rdx
-       jmp      G_M16487_IG39
-						;; size=31 bbWeight=0.74 PerfScore 4.98
-G_M16487_IG55:
+       xor      rcx, rcx
+       mov      r8, gword ptr [rbp-0x148]
+       mov      gword ptr [r8+0x28], rcx
+       jmp      G_M16487_IG41
+						;; size=31 bbWeight=0.73 PerfScore 4.90
+G_M16487_IG59:
        xor      rcx, rcx
        mov      gword ptr [rbp-0x60], rcx
-						;; size=6 bbWeight=1.03 PerfScore 1.29
-G_M16487_IG56:
+						;; size=6 bbWeight=0.96 PerfScore 1.20
+G_M16487_IG60:
        mov      gword ptr [rbp-0x58], rcx
        mov      dword ptr [rbp-0x50], -1
        mov      dword ptr [rbp-0x4C], -1
-       jmp      G_M16487_IG29
-						;; size=23 bbWeight=1.03 PerfScore 5.16
-G_M16487_IG57:
-       mov      r15d, -1
-       mov      r10d, r15d
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG23
-						;; size=21 bbWeight=0.74 PerfScore 2.60
-G_M16487_IG58:
-       mov      r14, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x1D8], r14
-       mov      dword ptr [rbp-0x118], r9d
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      dword ptr [rbp-0xA0], r11d
-       mov      r14d, dword ptr [rbp-0xA0]
-       mov      dword ptr [rbp-0x78], r14d
-       mov      r14d, dword ptr [rbp-0xA0]
-       mov      dword ptr [rbp-0xA8], r14d
-       mov      r14, gword ptr [rcx+0x80]
-       mov      r10d, dword ptr [rbp-0xA0]
-       dec      r10d
-       test     r15d, r15d
-       je       G_M16487_IG65
-						;; size=83 bbWeight=0.74 PerfScore 9.98
-G_M16487_IG59:
-       cmp      r10d, r9d
-       jb       SHORT G_M16487_IG60
-       mov      r15d, -1
-       jmp      SHORT G_M16487_IG64
-						;; size=13 bbWeight=2.96 PerfScore 10.35
-G_M16487_IG60:
-       mov      r15d, r10d
-       mov      r9, bword ptr [rbp-0x1D8]
-       movzx    r9, word  ptr [r9+2*r15]
-       cmp      r9d, 10
-       jne      SHORT G_M16487_IG61
-       mov      r15d, dword ptr [rbp-0x118]
-       dec      r15d
-       cmp      r10d, r15d
-       je       SHORT G_M16487_IG63
-						;; size=36 bbWeight=2.96 PerfScore 20.69
+       jmp      G_M16487_IG31
+						;; size=23 bbWeight=0.96 PerfScore 4.81
 G_M16487_IG61:
-       mov      r15, gword ptr [rcx+0x50]
-       mov      r10, gword ptr [r15+0x08]
-       mov      gword ptr [rbp-0x168], r10
-       mov      r10d, dword ptr [r10+0x08]
-       cmp      r10d, r9d
-       jbe      G_M16487_IG50
-       mov      r9d, r9d
-       mov      r10, gword ptr [rbp-0x168]
-       mov      r15d, dword ptr [r10+4*r9+0x10]
-						;; size=43 bbWeight=0.74 PerfScore 8.50
+       mov      ecx, -1
+       jmp      G_M16487_IG25
+						;; size=10 bbWeight=1.71 PerfScore 3.84
 G_M16487_IG62:
-       jmp      SHORT G_M16487_IG64
-						;; size=2 bbWeight=2.96 PerfScore 5.91
+       mov      rax, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x210], rax
+       mov      eax, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x120], eax
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      dword ptr [rbp-0xA0], r10d
+       mov      r9d, dword ptr [rbp-0xA0]
+       mov      dword ptr [rbp-0x78], r9d
+       mov      r9d, dword ptr [rbp-0xA0]
+       mov      dword ptr [rbp-0xA8], r9d
+       mov      r9, gword ptr [rcx+0x80]
+       mov      gword ptr [rbp-0x170], r9
+       mov      eax, dword ptr [rbp-0xA0]
+       dec      eax
+       test     r13d, r13d
+       je       G_M16487_IG70
+						;; size=93 bbWeight=2.80 PerfScore 43.45
 G_M16487_IG63:
-       mov      r9, gword ptr [rcx+0x90]
-       mov      r15d, dword ptr [r9+0x08]
-						;; size=11 bbWeight=2.96 PerfScore 11.82
+       mov      r13d, dword ptr [rbp-0x120]
+       cmp      eax, r13d
+       jb       SHORT G_M16487_IG64
+       mov      eax, -1
+       jmp      SHORT G_M16487_IG69
+						;; size=19 bbWeight=11.21 PerfScore 50.46
 G_M16487_IG64:
-       mov      r9, gword ptr [rcx+0x98]
-       lea      r10d, [r15+0x01]
-       cmp      r10d, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       inc      r15d
-       mov      r10d, r15d
-       mov      r15d, dword ptr [r9+4*r10+0x10]
-       jmp      SHORT G_M16487_IG66
-						;; size=34 bbWeight=2.96 PerfScore 32.51
+       mov      r13d, eax
+       mov      r9, bword ptr [rbp-0x210]
+       movzx    r9, word  ptr [r9+2*r13]
+       cmp      r9d, 10
+       jne      SHORT G_M16487_IG65
+       mov      r13d, dword ptr [rbp-0x120]
+       dec      r13d
+       cmp      eax, r13d
+       je       SHORT G_M16487_IG68
+						;; size=36 bbWeight=11.21 PerfScore 78.49
 G_M16487_IG65:
-       xor      r15d, r15d
-						;; size=3 bbWeight=2.96 PerfScore 0.74
+       mov      r13, gword ptr [rcx+0x50]
+       mov      rax, gword ptr [r13+0x08]
+       cmp      dword ptr [rax+0x08], r9d
+       jbe      G_M16487_IG53
+						;; size=18 bbWeight=2.80 PerfScore 22.43
 G_M16487_IG66:
-       cmp      r15d, dword ptr [r14+0x08]
-       jae      G_M16487_IG315
-       mov      r9d, r15d
-       mov      r9, gword ptr [r14+8*r9+0x10]
+       mov      r9d, r9d
+       mov      eax, dword ptr [rax+4*r9+0x10]
+						;; size=8 bbWeight=2.80 PerfScore 6.31
+G_M16487_IG67:
+       jmp      SHORT G_M16487_IG69
+						;; size=2 bbWeight=11.21 PerfScore 22.43
+G_M16487_IG68:
+       mov      rax, gword ptr [rcx+0x90]
+       mov      eax, dword ptr [rax+0x08]
+						;; size=10 bbWeight=11.21 PerfScore 44.85
+G_M16487_IG69:
+       mov      r13, gword ptr [rcx+0x98]
+       lea      r9d, [rax+0x01]
+       cmp      r9d, dword ptr [r13+0x08]
+       jae      G_M16487_IG205
+       inc      eax
+       mov      r9d, eax
+       mov      eax, dword ptr [r13+4*r9+0x10]
+       jmp      SHORT G_M16487_IG71
+						;; size=33 bbWeight=11.21 PerfScore 123.35
+G_M16487_IG70:
+       xor      eax, eax
+						;; size=2 bbWeight=11.21 PerfScore 2.80
+G_M16487_IG71:
+       mov      r9, gword ptr [rbp-0x170]
+       cmp      eax, dword ptr [r9+0x08]
+       jae      G_M16487_IG205
+       mov      eax, eax
+       mov      r9, gword ptr [r9+8*rax+0x10]
        mov      r9d, dword ptr [r9+0x14]
        mov      dword ptr [rbp-0xB0], r9d
        xor      r9, r9
        mov      gword ptr [rbp-0xB8], r9
        mov      dword ptr [rbp-0xC0], -2
        mov      dword ptr [rbp-0xC8], -1
-						;; size=59 bbWeight=2.96 PerfScore 36.95
-G_M16487_IG67:
+						;; size=65 bbWeight=11.21 PerfScore 151.38
+G_M16487_IG72:
        cmp      byte  ptr [rcx+0xAC], 0
-       je       SHORT G_M16487_IG69
-						;; size=9 bbWeight=23.65 PerfScore 94.59
-G_M16487_IG68:
-       mov      r9d, eax
+       je       SHORT G_M16487_IG74
+						;; size=9 bbWeight=89.71 PerfScore 358.83
+G_M16487_IG73:
+       mov      r9d, r15d
        sub      r9d, dword ptr [rbp-0xA0]
        cmp      r9d, 0x3E8
-       jg       SHORT G_M16487_IG70
-						;; size=19 bbWeight=11.82 PerfScore 41.38
-G_M16487_IG69:
-       mov      r15d, eax
-       jmp      SHORT G_M16487_IG71
-						;; size=5 bbWeight=11.82 PerfScore 26.60
-G_M16487_IG70:
-       mov      r15d, dword ptr [rbp-0xA0]
-       add      r15d, 0x3E8
-						;; size=14 bbWeight=11.82 PerfScore 14.78
-G_M16487_IG71:
-       cmp      gword ptr [rbp-0xB8], 0
-       jne      SHORT G_M16487_IG73
-						;; size=10 bbWeight=23.65 PerfScore 70.94
-G_M16487_IG72:
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      r9, [rbp-0xA0]
-       mov      qword ptr [rsp+0x20], r9
-       lea      r9, [rbp-0xB8]
-       mov      qword ptr [rsp+0x28], r9
-       lea      r9, [rbp-0xC0]
-       mov      qword ptr [rsp+0x30], r9
-       lea      r9, [rbp-0xC8]
-       mov      qword ptr [rsp+0x38], r9
-       lea      r9, [rbp-0x78]
-       mov      qword ptr [rsp+0x40], r9
-       lea      r9, [rbp-0xA8]
-       mov      qword ptr [rsp+0x48], r9
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      r8d, r15d
-       mov      r9d, dword ptr [rbp-0x70]
-       call     [<unknown method>]
-       jmp      SHORT G_M16487_IG74
-						;; size=111 bbWeight=11.82 PerfScore 221.69
-G_M16487_IG73:
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      r9, [rbp-0xA0]
-       mov      qword ptr [rsp+0x20], r9
-       lea      r9, [rbp-0xB8]
-       mov      qword ptr [rsp+0x28], r9
-       lea      r9, [rbp-0xC0]
-       mov      qword ptr [rsp+0x30], r9
-       lea      r9, [rbp-0xC8]
-       mov      qword ptr [rsp+0x38], r9
-       lea      r9, [rbp-0x78]
-       mov      qword ptr [rsp+0x40], r9
-       lea      r9, [rbp-0xA8]
-       mov      qword ptr [rsp+0x48], r9
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      r8d, r15d
-       mov      r9d, dword ptr [rbp-0x70]
-       call     [<unknown method>]
-						;; size=109 bbWeight=11.82 PerfScore 198.04
+       jg       SHORT G_M16487_IG75
+						;; size=19 bbWeight=44.85 PerfScore 156.99
 G_M16487_IG74:
-       test     eax, eax
-       jne      G_M16487_IG80
-       mov      r14d, dword ptr [rbp-0x110]
-       cmp      dword ptr [rbp-0xA0], r14d
-       jge      G_M16487_IG80
-       cmp      dword ptr [rbp-0xA0], r15d
-       jge      G_M16487_IG78
-						;; size=41 bbWeight=23.65 PerfScore 195.09
+       mov      r13d, r15d
+       jmp      SHORT G_M16487_IG76
+						;; size=5 bbWeight=44.85 PerfScore 100.92
 G_M16487_IG75:
-       mov      r15, gword ptr [r13+0x08]
-       mov      r8d, dword ptr [rbp-0xB0]
-       mov      r10, gword ptr [rbp-0x150]
-       mov      r9, gword ptr [r10+0x10]
-       cmp      r8d, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       mov      ecx, r8d
-       mov      r11, gword ptr [r9+8*rcx+0x10]
-       mov      rdx, gword ptr [r15+0x08]
-       mov      rcx, gword ptr [rdx+0x08]
-       inc      dword ptr [rcx+0x14]
-       xor      eax, eax
-       mov      dword ptr [rcx+0x10], eax
-       mov      rax, gword ptr [r11+0x08]
-       mov      gword ptr [rbp-0x170], rax
-       mov      r8d, dword ptr [r11+0x10]
-       mov      dword ptr [rbp-0xCC], r8d
-       mov      gword ptr [rbp-0x178], rdx
+       mov      r13d, dword ptr [rbp-0xA0]
+       add      r13d, 0x3E8
+						;; size=14 bbWeight=44.85 PerfScore 56.07
+G_M16487_IG76:
+       cmp      gword ptr [rbp-0xB8], 0
+       jne      SHORT G_M16487_IG78
+						;; size=10 bbWeight=89.71 PerfScore 269.12
+G_M16487_IG77:
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       lea      r9, [rbp-0xA0]
+       mov      qword ptr [rsp+0x20], r9
+       lea      r9, [rbp-0xB8]
+       mov      qword ptr [rsp+0x28], r9
+       lea      r9, [rbp-0xC0]
+       mov      qword ptr [rsp+0x30], r9
+       lea      r9, [rbp-0xC8]
+       mov      qword ptr [rsp+0x38], r9
+       lea      r9, [rbp-0x78]
+       mov      qword ptr [rsp+0x40], r9
+       lea      r9, [rbp-0xA8]
+       mov      qword ptr [rsp+0x48], r9
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      r8d, r13d
+       mov      r9d, dword ptr [rbp-0x70]
+       call     [<unknown method>]
+       jmp      SHORT G_M16487_IG79
+						;; size=112 bbWeight=44.85 PerfScore 841.00
+G_M16487_IG78:
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       lea      r9, [rbp-0xA0]
+       mov      qword ptr [rsp+0x20], r9
+       lea      r9, [rbp-0xB8]
+       mov      qword ptr [rsp+0x28], r9
+       lea      r9, [rbp-0xC0]
+       mov      qword ptr [rsp+0x30], r9
+       lea      r9, [rbp-0xC8]
+       mov      qword ptr [rsp+0x38], r9
+       lea      r9, [rbp-0x78]
+       mov      qword ptr [rsp+0x40], r9
+       lea      r9, [rbp-0xA8]
+       mov      qword ptr [rsp+0x48], r9
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      r8d, r13d
+       mov      r9d, dword ptr [rbp-0x70]
+       call     [<unknown method>]
+						;; size=110 bbWeight=44.85 PerfScore 751.29
+G_M16487_IG79:
+       test     eax, eax
+       jne      G_M16487_IG85
+       cmp      dword ptr [rbp-0xA0], r15d
+       jge      G_M16487_IG85
+       cmp      dword ptr [rbp-0xA0], r13d
+       jge      G_M16487_IG83
+						;; size=34 bbWeight=89.71 PerfScore 650.37
+G_M16487_IG80:
+       mov      r13, gword ptr [rbp-0x168]
+       mov      r8, gword ptr [r13+0x08]
+       mov      r10d, dword ptr [rbp-0xB0]
+       mov      r9, gword ptr [rbp-0x160]
+       mov      r11, gword ptr [r9+0x10]
+       cmp      r10d, dword ptr [r11+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, r10d
+       mov      rdx, gword ptr [r11+8*rcx+0x10]
+       mov      gword ptr [rbp-0x180], r8
+       mov      rcx, gword ptr [r8+0x08]
+       mov      rax, gword ptr [rcx+0x08]
+       inc      dword ptr [rax+0x14]
+       xor      r10d, r10d
+       mov      dword ptr [rax+0x10], r10d
+       mov      r10, gword ptr [rdx+0x08]
+       mov      gword ptr [rbp-0x188], r10
+       mov      eax, dword ptr [rdx+0x10]
+       mov      dword ptr [rbp-0xD0], eax
+       mov      gword ptr [rbp-0x190], rcx
        mov      rcx, 0xD1FFAB1E
        mov      edx, 1
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rax, gword ptr [rcx]
        test     rax, rax
-       jne      G_M16487_IG77
-						;; size=127 bbWeight=11.82 PerfScore 384.26
-G_M16487_IG76:
+       jne      G_M16487_IG82
+						;; size=141 bbWeight=44.85 PerfScore 1547.44
+G_M16487_IG81:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x180], rax
+       mov      gword ptr [rbp-0x198], rax
        mov      rcx, 0xD1FFAB1E
        mov      edx, 1
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rdx, gword ptr [rcx]
        test     rdx, rdx
-       je       G_M16487_IG313
-       mov      rax, gword ptr [rbp-0x180]
+       je       G_M16487_IG333
+       mov      rax, gword ptr [rbp-0x198]
        lea      rcx, bword ptr [rax+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, 0xD1FFAB1E      ; code for <unknown method>
-       mov      rax, gword ptr [rbp-0x180]
+       mov      rax, gword ptr [rbp-0x198]
        mov      qword ptr [rax+0x18], rcx
        mov      rcx, 0xD1FFAB1E
        mov      edx, 1
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdx, gword ptr [rbp-0x180]
+       mov      rdx, gword ptr [rbp-0x198]
        call     CORINFO_HELP_ASSIGN_REF
-       mov      rax, gword ptr [rbp-0x180]
-						;; size=150 bbWeight=0.74 PerfScore 12.38
-G_M16487_IG77:
-       mov      r10, gword ptr [rbp-0x178]
+       mov      rax, gword ptr [rbp-0x198]
+						;; size=150 bbWeight=2.80 PerfScore 46.96
+G_M16487_IG82:
+       mov      r10, gword ptr [rbp-0x190]
        mov      gword ptr [rsp+0x20], r10
        mov      gword ptr [rsp+0x28], rax
-       mov      rcx, gword ptr [rbp-0x150]
-       mov      r8, gword ptr [rbp-0x170]
-       mov      r9d, dword ptr [rbp-0xCC]
+       mov      rcx, gword ptr [rbp-0x160]
+       mov      r8, gword ptr [rbp-0x188]
+       mov      r9d, dword ptr [rbp-0xD0]
        mov      rdx, 0xD1FFAB1E      ; <unknown method>
        call     [<unknown method>]
        mov      dword ptr [rbp-0xB0], -1
-       mov      gword ptr [rbp-0xB8], r15
-						;; size=71 bbWeight=11.82 PerfScore 133.01
-G_M16487_IG78:
-       mov      r15, gword ptr [rbp-0x150]
-       cmp      byte  ptr [r15+0xAC], 0
-       je       SHORT G_M16487_IG79
-       call     <unknown method>
-       mov      r15, qword ptr [rbp-0x68]
-       cmp      rax, r15
-       jge      G_M16487_IG312
-       mov      qword ptr [rbp-0x68], r15
-       mov      eax, dword ptr [rbp-0x110]
-       mov      rcx, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG67
-						;; size=57 bbWeight=23.65 PerfScore 313.32
-G_M16487_IG79:
-       mov      eax, dword ptr [rbp-0x110]
-       mov      rcx, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG67
-						;; size=18 bbWeight=11.82 PerfScore 47.29
-G_M16487_IG80:
-       lea      r14, bword ptr [rbp-0x80]
-       cmp      dword ptr [rbp-0xC8], 0
-       jg       SHORT G_M16487_IG81
-       mov      r15d, -1
-       jmp      G_M16487_IG94
-						;; size=24 bbWeight=2.96 PerfScore 17.00
-G_M16487_IG81:
-       mov      eax, dword ptr [rbp-0xC8]
-       mov      r15, gword ptr [rbp-0x150]
-       mov      rcx, gword ptr [r15+0x10]
-       cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M16487_IG315
-       mov      rax, gword ptr [rcx+8*rax+0x10]
-       mov      edx, dword ptr [rbp-0xC0]
-       mov      rcx, gword ptr [r15+0x60]
-       test     byte  ptr [rcx+0x34], 16
-       je       G_M16487_IG87
-       mov      ecx, dword ptr [rbp-0x110]
-       cmp      edx, ecx
-       jb       SHORT G_M16487_IG82
-       mov      r8d, -1
-       jmp      SHORT G_M16487_IG86
-						;; size=69 bbWeight=2.96 PerfScore 63.55
-G_M16487_IG82:
-       cmp      edx, ecx
-       jae      G_M16487_IG315
-       mov      r8d, edx
-       movzx    r8, word  ptr [r12+2*r8]
-       cmp      r8d, 10
-       jne      SHORT G_M16487_IG83
-       lea      r10d, [rcx-0x01]
-       cmp      edx, r10d
-       mov      ecx, dword ptr [rbp-0x110]
-       je       SHORT G_M16487_IG85
-						;; size=37 bbWeight=2.96 PerfScore 22.17
+       mov      rax, gword ptr [rbp-0x180]
+       mov      gword ptr [rbp-0xB8], rax
+						;; size=78 bbWeight=44.85 PerfScore 549.45
 G_M16487_IG83:
-       mov      r10, gword ptr [r15+0x50]
-       mov      r9, gword ptr [r10+0x08]
-       mov      edx, dword ptr [r9+0x08]
-       cmp      edx, r8d
-       jbe      G_M16487_IG49
-       cmp      r8d, edx
-       jae      G_M16487_IG315
-       mov      edx, r8d
-       mov      r8d, dword ptr [r9+4*rdx+0x10]
-						;; size=38 bbWeight=0.74 PerfScore 7.94
+       mov      rcx, gword ptr [rbp-0x160]
+       cmp      byte  ptr [rcx+0xAC], 0
+       je       SHORT G_M16487_IG84
+       call     <unknown method>
+       mov      r13, qword ptr [rbp-0x68]
+       cmp      rax, r13
+       jge      G_M16487_IG332
+       mov      qword ptr [rbp-0x68], r13
+       mov      rcx, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG72
+						;; size=50 bbWeight=89.71 PerfScore 1098.91
 G_M16487_IG84:
-       jmp      SHORT G_M16487_IG86
-						;; size=2 bbWeight=2.96 PerfScore 5.91
+       mov      rcx, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG72
+						;; size=12 bbWeight=44.85 PerfScore 134.56
 G_M16487_IG85:
-       mov      r8, gword ptr [r15+0x90]
-       mov      r8d, dword ptr [r8+0x08]
-						;; size=11 bbWeight=2.96 PerfScore 11.82
+       lea      r13, bword ptr [rbp-0x80]
+       cmp      dword ptr [rbp-0xC8], 0
+       jg       SHORT G_M16487_IG86
+       mov      eax, -1
+       jmp      G_M16487_IG99
+						;; size=23 bbWeight=11.21 PerfScore 64.48
 G_M16487_IG86:
-       mov      rdx, gword ptr [r15+0x98]
-       lea      r10d, [r8+0x01]
-       cmp      r10d, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       inc      r8d
-       mov      r8d, dword ptr [rdx+4*r8+0x10]
-       jmp      SHORT G_M16487_IG88
-						;; size=31 bbWeight=2.96 PerfScore 31.78
+       mov      ecx, dword ptr [rbp-0xC8]
+       mov      rdx, gword ptr [rbp-0x160]
+       mov      r8, gword ptr [rdx+0x10]
+       cmp      ecx, dword ptr [r8+0x08]
+       jae      G_M16487_IG205
+       mov      eax, ecx
+       mov      rax, gword ptr [r8+8*rax+0x10]
+       mov      r10d, dword ptr [rbp-0xC0]
+       mov      rcx, gword ptr [rdx+0x60]
+       test     byte  ptr [rcx+0x34], 16
+       je       G_M16487_IG93
+       cmp      r10d, r15d
+       jb       SHORT G_M16487_IG87
+       mov      ecx, -1
+       jmp      SHORT G_M16487_IG92
+						;; size=67 bbWeight=11.21 PerfScore 232.68
 G_M16487_IG87:
-       xor      r8d, r8d
-						;; size=3 bbWeight=2.96 PerfScore 0.74
+       cmp      r10d, r15d
+       jae      G_M16487_IG205
+       mov      ecx, r10d
+       movzx    rcx, word  ptr [r12+2*rcx]
+       cmp      ecx, 10
+       jne      SHORT G_M16487_IG88
+       lea      r8d, [r15-0x01]
+       cmp      r10d, r8d
+       je       SHORT G_M16487_IG91
+						;; size=31 bbWeight=11.21 PerfScore 72.89
 G_M16487_IG88:
-       shl      r8d, 3
-       or       r8d, dword ptr [rax+0x10]
-       mov      dword ptr [rbp-0xD0], r8d
-       mov      r10, gword ptr [rax+0x08]
-       mov      gword ptr [rbp-0x188], r10
-       cmp      byte  ptr [r10], r10b
+       mov      r8, gword ptr [rdx+0x50]
+       mov      r9, gword ptr [r8+0x08]
+       cmp      dword ptr [r9+0x08], ecx
+       jbe      G_M16487_IG52
+						;; size=18 bbWeight=2.80 PerfScore 22.43
+G_M16487_IG89:
+       cmp      ecx, dword ptr [r9+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, ecx
+       mov      ecx, dword ptr [r9+4*rcx+0x10]
+						;; size=17 bbWeight=2.80 PerfScore 17.52
+G_M16487_IG90:
+       jmp      SHORT G_M16487_IG92
+						;; size=2 bbWeight=11.21 PerfScore 22.43
+G_M16487_IG91:
+       mov      rcx, gword ptr [rdx+0x90]
+       mov      ecx, dword ptr [rcx+0x08]
+						;; size=10 bbWeight=11.21 PerfScore 44.85
+G_M16487_IG92:
+       mov      gword ptr [rbp-0x160], rdx
+       mov      r11, gword ptr [rdx+0x98]
+       lea      r8d, [rcx+0x01]
+       cmp      r8d, dword ptr [r11+0x08]
+       jae      G_M16487_IG205
+       inc      ecx
+       mov      ecx, dword ptr [r11+4*rcx+0x10]
+       jmp      SHORT G_M16487_IG94
+						;; size=37 bbWeight=11.21 PerfScore 131.76
+G_M16487_IG93:
+       xor      ecx, ecx
+       mov      gword ptr [rbp-0x160], rdx
+						;; size=9 bbWeight=11.21 PerfScore 14.02
+G_M16487_IG94:
+       shl      ecx, 3
+       or       ecx, dword ptr [rax+0x10]
+       mov      dword ptr [rbp-0xD8], ecx
+       mov      r8, gword ptr [rax+0x08]
+       mov      gword ptr [rbp-0x1A0], r8
+       cmp      byte  ptr [r8], r8b
        call     <unknown method>
        test     eax, eax
-       je       G_M16487_IG48
-       mov      rax, gword ptr [rbp-0x188]
+       je       G_M16487_IG51
+       mov      rax, gword ptr [rbp-0x1A0]
        mov      r8d, dword ptr [rax+0x28]
        cmp      r8d, 2
-       je       G_M16487_IG97
-						;; size=63 bbWeight=0.74 PerfScore 12.56
-G_M16487_IG89:
-       cmp      r8d, 4
-       je       SHORT G_M16487_IG91
-						;; size=6 bbWeight=0.49 PerfScore 0.62
-G_M16487_IG90:
-       cmp      r8d, 13
-       jne      G_M16487_IG222
-       mov      r10d, dword ptr [rax+0x2C]
-       jmp      SHORT G_M16487_IG93
-						;; size=16 bbWeight=0.25 PerfScore 1.29
-G_M16487_IG91:
-       mov      rcx, gword ptr [rax+0x08]
-       cmp      gword ptr [rcx+0x18], 0
-       jne      G_M16487_IG47
-       test     byte  ptr [rcx+0x34], 1
-       je       G_M16487_IG45
-						;; size=25 bbWeight=0.25 PerfScore 2.46
-G_M16487_IG92:
-       mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0xD0]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-						;; size=21 bbWeight=0.25 PerfScore 2.28
-G_M16487_IG93:
-       mov      gword ptr [rbp-0x150], r15
-       mov      r15d, r10d
-						;; size=10 bbWeight=2.96 PerfScore 3.69
-G_M16487_IG94:
-       mov      dword ptr [r14], r15d
-       mov      r15d, dword ptr [rbp-0xC0]
-       mov      eax, r15d
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=25 bbWeight=0.74 PerfScore 3.88
+       je       G_M16487_IG105
+						;; size=60 bbWeight=2.80 PerfScore 47.66
 G_M16487_IG95:
-       mov      r14d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbx+0x4C], r14d
-       jmp      G_M16487_IG37
-						;; size=16 bbWeight=738.96 PerfScore 2955.85
+       cmp      r8d, 4
+       je       SHORT G_M16487_IG97
+						;; size=6 bbWeight=1.87 PerfScore 2.34
 G_M16487_IG96:
-       mov      rdx, rsi
-       mov      r8, r13
-       mov      rcx, gword ptr [rdi+0x08]
-       call     [rdi+0x18]<unknown method>
-       test     eax, eax
-       je       G_M16487_IG317
-       movzx    r15, byte  ptr [rbp+0x48]
-       mov      dword ptr [rbp+0x48], r15d
-       jmp      G_M16487_IG43
-						;; size=35 bbWeight=737.97 PerfScore 7933.20
+       cmp      r8d, 13
+       jne      G_M16487_IG216
+       mov      eax, dword ptr [rax+0x2C]
+       jmp      SHORT G_M16487_IG99
+						;; size=15 bbWeight=0.93 PerfScore 4.91
 G_M16487_IG97:
-       mov      gword ptr [rbp-0x188], rax
-       mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0xD0]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       test     eax, eax
-       jl       SHORT G_M16487_IG98
-       mov      r10d, eax
-       jmp      SHORT G_M16487_IG93
-						;; size=34 bbWeight=0.25 PerfScore 3.33
-G_M16487_IG98:
-       mov      rax, gword ptr [rbp-0x188]
-       jmp      G_M16487_IG45
-						;; size=12 bbWeight=0.12 PerfScore 0.37
-G_M16487_IG99:
-       test     r14d, r14d
-       je       G_M16487_IG231
-       test     r10d, r10d
-       jne      G_M16487_IG52
-       jmp      G_M16487_IG58
-						;; size=23 bbWeight=0.74 PerfScore 3.33
-G_M16487_IG100:
        mov      rcx, gword ptr [rax+0x08]
        cmp      gword ptr [rcx+0x18], 0
-       jne      G_M16487_IG220
+       jne      G_M16487_IG50
        test     byte  ptr [rcx+0x34], 1
-       je       G_M16487_IG218
-						;; size=25 bbWeight=249.25 PerfScore 2492.45
-G_M16487_IG101:
+       je       SHORT G_M16487_IG100
+						;; size=21 bbWeight=0.93 PerfScore 9.34
+G_M16487_IG98:
        mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0x108]
+       mov      edx, dword ptr [rbp-0xD8]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      G_M16487_IG23
-						;; size=26 bbWeight=249.25 PerfScore 2804.01
+						;; size=18 bbWeight=0.93 PerfScore 8.41
+G_M16487_IG99:
+       mov      dword ptr [r13], eax
+       mov      r13d, dword ptr [rbp-0xC0]
+       jmp      G_M16487_IG26
+						;; size=16 bbWeight=2.80 PerfScore 11.21
+G_M16487_IG100:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG48
+						;; size=9 bbWeight=0.47 PerfScore 1.40
+G_M16487_IG101:
+       mov      dword ptr [rbx+0x4C], r15d
+       jmp      G_M16487_IG39
+						;; size=9 bbWeight=727.32 PerfScore 2181.96
 G_M16487_IG102:
-       mov      gword ptr [rbp-0x1A8], rax
        mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0x108]
+       cmp      gword ptr [rcx+0x18], 0
+       jne      G_M16487_IG238
+       test     byte  ptr [rcx+0x34], 1
+       je       SHORT G_M16487_IG104
+						;; size=21 bbWeight=240.94 PerfScore 2409.36
+G_M16487_IG103:
+       mov      rcx, gword ptr [rax+0x08]
+       mov      edx, dword ptr [rbp-0x10C]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       mov      ecx, eax
+       jmp      G_M16487_IG25
+						;; size=25 bbWeight=240.94 PerfScore 2710.53
+G_M16487_IG104:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG239
+						;; size=9 bbWeight=120.47 PerfScore 361.40
+G_M16487_IG105:
+       mov      gword ptr [rbp-0x1A0], rax
+       mov      rcx, gword ptr [rax+0x08]
+       mov      edx, dword ptr [rbp-0xD8]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
        test     eax, eax
-       jl       SHORT G_M16487_IG103
-       mov      r10d, eax
-       jmp      G_M16487_IG23
-						;; size=37 bbWeight=249.25 PerfScore 3364.81
-G_M16487_IG103:
-       mov      rax, gword ptr [rbp-0x1A8]
-       jmp      G_M16487_IG218
-						;; size=12 bbWeight=124.62 PerfScore 373.87
-G_M16487_IG104:
+       jl       SHORT G_M16487_IG106
+       jmp      SHORT G_M16487_IG99
+						;; size=31 bbWeight=0.93 PerfScore 12.38
+G_M16487_IG106:
+       mov      rax, gword ptr [rbp-0x1A0]
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG48
+						;; size=16 bbWeight=0.47 PerfScore 1.87
+G_M16487_IG107:
+       test     eax, eax
+       je       G_M16487_IG226
+       test     r9d, r9d
+       jne      G_M16487_IG55
+       jmp      G_M16487_IG62
+						;; size=22 bbWeight=2.80 PerfScore 12.62
+G_M16487_IG108:
+       mov      gword ptr [rbp-0x1C8], rax
+       mov      rcx, gword ptr [rax+0x08]
+       mov      edx, dword ptr [rbp-0x10C]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       mov      ecx, eax
+       test     ecx, ecx
+       mov      rax, gword ptr [rbp-0x1C8]
+       jl       SHORT G_M16487_IG109
+       jmp      G_M16487_IG25
+						;; size=43 bbWeight=240.94 PerfScore 3493.57
+G_M16487_IG109:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG239
+						;; size=9 bbWeight=120.47 PerfScore 361.40
+G_M16487_IG110:
        mov      rdx, gword ptr [r8+0x08]
        lea      rcx, bword ptr [rbx+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        xor      edx, edx
        mov      dword ptr [rbx+0x34], edx
-       mov      eax, dword ptr [rbp-0x110]
+       mov      eax, dword ptr [rbp-0x118]
        mov      dword ptr [rbx+0x5C], eax
-       mov      r10, gword ptr [rbx+0x50]
-						;; size=31 bbWeight=7.46 PerfScore 65.31
-G_M16487_IG105:
-       cmp      dword ptr [r10+0x08], 0
-       jle      SHORT G_M16487_IG107
-						;; size=7 bbWeight=7.46 PerfScore 29.86
-G_M16487_IG106:
-       mov      ecx, edx
-       xor      r8d, r8d
-       mov      dword ptr [r10+4*rcx+0x10], r8d
-       inc      edx
-       cmp      dword ptr [r10+0x08], edx
-       jg       SHORT G_M16487_IG106
-						;; size=18 bbWeight=7.56 PerfScore 43.49
-G_M16487_IG107:
+       mov      rdx, gword ptr [rbx+0x50]
+       xor      ecx, ecx
+       cmp      dword ptr [rdx+0x08], 0
+       jle      SHORT G_M16487_IG112
+						;; size=39 bbWeight=7.35 PerfScore 95.51
+G_M16487_IG111:
+       mov      r8d, ecx
+       xor      r9d, r9d
+       mov      dword ptr [rdx+4*r8+0x10], r9d
+       inc      ecx
+       cmp      dword ptr [rdx+0x08], ecx
+       jg       SHORT G_M16487_IG111
+						;; size=18 bbWeight=7.43 PerfScore 42.72
+G_M16487_IG112:
        mov      byte  ptr [rbx+0x60], 0
-       mov      r11, gword ptr [rbx+0x38]
-       test     r11, r11
-       jne      G_M16487_IG272
-						;; size=17 bbWeight=7.46 PerfScore 31.72
-G_M16487_IG108:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      rdx, gword ptr [r8+0x20]
-       test     rdx, rdx
-       je       G_M16487_IG273
-       mov      rcx, gword ptr [r8+0x10]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x50], ecx
-       mov      rcx, gword ptr [r8+0x18]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x54], ecx
+       mov      r10, gword ptr [rbx+0x38]
+       test     r10, r10
+       jne      G_M16487_IG274
+						;; size=17 bbWeight=7.35 PerfScore 31.22
+G_M16487_IG113:
+       mov      r8, gword ptr [rbp-0x148]
+       mov      rbx, gword ptr [r8+0x20]
+       test     rbx, rbx
+       je       G_M16487_IG153
+						;; size=20 bbWeight=7.35 PerfScore 31.22
+G_M16487_IG114:
+       mov      rdx, gword ptr [r8+0x10]
        mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x50], edx
+       mov      rdx, gword ptr [r8+0x18]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x54], edx
+       mov      edx, dword ptr [rbx+0x08]
        mov      dword ptr [r8+0x58], edx
-						;; size=49 bbWeight=7.46 PerfScore 128.76
-G_M16487_IG109:
+						;; size=29 bbWeight=7.35 PerfScore 95.51
+G_M16487_IG115:
        mov      ebx, dword ptr [rbp-0x3C]
        mov      dword ptr [r8+0x4C], ebx
        mov      rdx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Symbolic.SymbolicRegexRunnerFactory+Runner`1[ulong]
        cmp      qword ptr [r8], rdx
-       jne      G_M16487_IG307
+       jne      G_M16487_IG325
+       mov      gword ptr [rbp+0x38], r15
        mov      rbx, r8
-       mov      r9d, eax
-       mov      rdx, gword ptr [rbx+0x70]
-       mov      r10, rdx
+       mov      r11d, eax
+       mov      r10, gword ptr [rbx+0x70]
        mov      edx, dword ptr [rbx+0x60]
-       mov      dword ptr [rbp-0x70], edx
-       mov      bword ptr [rbp-0x1D0], r12
-       mov      r11d, dword ptr [rbx+0x4C]
+       mov      r9d, edx
+       mov      bword ptr [rbp-0x208], r12
+       mov      edx, dword ptr [rbx+0x4C]
        mov      r13, gword ptr [rbx+0x78]
        xor      r15d, r15d
        mov      qword ptr [rbp-0x68], r15
        cmp      byte  ptr [r10+0xAC], 0
-       jne      G_M16487_IG276
-						;; size=81 bbWeight=7.46 PerfScore 166.08
-G_M16487_IG110:
+       jne      G_M16487_IG279
+						;; size=81 bbWeight=7.35 PerfScore 163.46
+G_M16487_IG116:
        mov      r14, gword ptr [r10+0x60]
-       mov      gword ptr [rbp-0x1E8], r14
+       mov      gword ptr [rbp-0x220], r14
        mov      r14d, dword ptr [r14+0x34]
        xor      r14d, r14d
        cmp      gword ptr [r10+0x70], 0
        setne    r14b
-       mov      r15, gword ptr [rbp-0x1E8]
+       mov      r15, gword ptr [rbp-0x220]
        test     byte  ptr [r15+0x34], 16
        setne    r15b
        movzx    r15, r15b
-       mov      rdx, gword ptr [rbp-0x1E8]
-       test     dword ptr [rdx+0x34], 256
-       jne      G_M16487_IG169
-						;; size=67 bbWeight=7.50 PerfScore 146.28
-G_M16487_IG111:
-       test     r14d, r14d
-       je       G_M16487_IG278
-       test     r15d, r15d
-       jne      G_M16487_IG283
-       mov      r14, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x1E0], r14
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      dword ptr [rbp-0xD8], r11d
-       mov      r15d, dword ptr [rbp-0xD8]
-       mov      dword ptr [rbp-0x78], r15d
-       mov      r15d, dword ptr [rbp-0xD8]
-       mov      dword ptr [rbp-0xE0], r15d
-       mov      r15, gword ptr [r10+0x80]
-       mov      edx, dword ptr [rbp-0xD8]
-       dec      edx
-       mov      r14, gword ptr [rbp-0x1E8]
-       test     byte  ptr [r14+0x34], 16
-       jne      G_M16487_IG215
-       xor      r9d, r9d
-						;; size=104 bbWeight=7.49 PerfScore 142.39
-G_M16487_IG112:
-       cmp      r9d, dword ptr [r15+0x08]
-       jae      G_M16487_IG315
-       mov      edx, r9d
-       mov      rdx, gword ptr [r15+8*rdx+0x10]
-       mov      edx, dword ptr [rdx+0x14]
-       mov      dword ptr [rbp-0xE8], edx
-       xor      rdx, rdx
-       mov      gword ptr [rbp-0xF0], rdx
-       mov      dword ptr [rbp-0xF8], -2
-       mov      dword ptr [rbp-0x100], -1
-						;; size=56 bbWeight=7.49 PerfScore 93.68
-G_M16487_IG113:
-       cmp      byte  ptr [r10+0xAC], 0
-       jne      G_M16487_IG213
-						;; size=14 bbWeight=7.56 PerfScore 30.24
-G_M16487_IG114:
-       mov      r14d, eax
-						;; size=3 bbWeight=7.56 PerfScore 1.89
-G_M16487_IG115:
-       cmp      gword ptr [rbp-0xF0], 0
-       jne      G_M16487_IG212
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      rdx, [rbp-0xD8]
-       mov      qword ptr [rsp+0x20], rdx
-       lea      rdx, [rbp-0xF0]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0xF8]
-       mov      qword ptr [rsp+0x30], rdx
-       lea      rdx, [rbp-0x100]
-       mov      qword ptr [rsp+0x38], rdx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x40], rdx
-       lea      rdx, [rbp-0xE0]
-       mov      qword ptr [rsp+0x48], rdx
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      r8d, r14d
-       mov      r9d, dword ptr [rbp-0x70]
-       call     [<unknown method>]
-						;; size=126 bbWeight=7.56 PerfScore 151.21
-G_M16487_IG116:
-       test     eax, eax
-       je       G_M16487_IG209
-						;; size=8 bbWeight=7.56 PerfScore 9.45
+       mov      rcx, gword ptr [rbp-0x220]
+       test     dword ptr [rcx+0x34], 256
+       jne      G_M16487_IG158
+						;; size=67 bbWeight=7.35 PerfScore 143.26
 G_M16487_IG117:
-       lea      r14, bword ptr [rbp-0x80]
-       cmp      dword ptr [rbp-0x100], 0
-       jle      G_M16487_IG154
-						;; size=17 bbWeight=7.56 PerfScore 26.46
-G_M16487_IG118:
-       mov      ecx, dword ptr [rbp-0x100]
-       mov      r15, gword ptr [rbp-0x150]
-       mov      rdx, gword ptr [r15+0x10]
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       mov      eax, ecx
-       mov      rax, gword ptr [rdx+8*rax+0x10]
-       mov      r8d, dword ptr [rbp-0xF8]
-       mov      rcx, gword ptr [r15+0x60]
+       test     r14d, r14d
+       je       G_M16487_IG281
+       test     r15d, r15d
+       jne      G_M16487_IG285
+       mov      dword ptr [rbp-0x6C], edx
+       mov      dword ptr [rbp-0xE0], edx
+       mov      r15d, dword ptr [rbp-0xE0]
+       mov      dword ptr [rbp-0x78], r15d
+       mov      r14d, dword ptr [rbp-0xE0]
+       mov      dword ptr [rbp-0xE8], r14d
+       mov      r14, gword ptr [r10+0x80]
+       mov      r15d, dword ptr [rbp-0xE0]
+       dec      r15d
        test     byte  ptr [rcx+0x34], 16
-       jne      G_M16487_IG208
+       jne      G_M16487_IG286
        xor      ecx, ecx
-						;; size=56 bbWeight=7.55 PerfScore 132.18
+						;; size=81 bbWeight=7.32 PerfScore 117.09
+G_M16487_IG118:
+       cmp      ecx, dword ptr [r14+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, ecx
+       mov      rcx, gword ptr [r14+8*rcx+0x10]
+       mov      ecx, dword ptr [rcx+0x14]
+       mov      dword ptr [rbp-0xF0], ecx
+       xor      rcx, rcx
+       mov      gword ptr [rbp-0xF8], rcx
+       mov      dword ptr [rbp-0x100], -2
+       mov      dword ptr [rbp-0x108], -1
+						;; size=55 bbWeight=7.32 PerfScore 91.48
 G_M16487_IG119:
+       cmp      byte  ptr [r10+0xAC], 0
+       jne      G_M16487_IG287
+						;; size=14 bbWeight=7.32 PerfScore 29.27
+G_M16487_IG120:
+       mov      r15d, eax
+       cmp      gword ptr [rbp-0xF8], 0
+       jne      G_M16487_IG152
+						;; size=17 bbWeight=7.32 PerfScore 23.78
+G_M16487_IG121:
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], eax
+       lea      rcx, [rbp-0xE0]
+       mov      qword ptr [rsp+0x20], rcx
+       lea      rcx, [rbp-0xF8]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x100]
+       mov      qword ptr [rsp+0x30], rcx
+       lea      rcx, [rbp-0x108]
+       mov      qword ptr [rsp+0x38], rcx
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x40], rcx
+       lea      rcx, [rbp-0xE8]
+       mov      qword ptr [rsp+0x48], rcx
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r15d
+       mov      dword ptr [rbp-0x70], r9d
+       call     [<unknown method>]
+						;; size=112 bbWeight=7.32 PerfScore 124.41
+G_M16487_IG122:
+       test     eax, eax
+       je       G_M16487_IG291
+						;; size=8 bbWeight=7.32 PerfScore 9.15
+G_M16487_IG123:
+       lea      rax, bword ptr [rbp-0x80]
+       mov      r15, rax
+       cmp      dword ptr [rbp-0x108], 0
+       jle      G_M16487_IG157
+						;; size=20 bbWeight=7.32 PerfScore 27.44
+G_M16487_IG124:
+       mov      edx, dword ptr [rbp-0x108]
+       mov      r14, gword ptr [rbp-0x160]
+       mov      r10, gword ptr [r14+0x10]
+       cmp      edx, dword ptr [r10+0x08]
+       jae      G_M16487_IG205
+       mov      eax, edx
+       mov      rax, gword ptr [r10+8*rax+0x10]
+       mov      r9d, dword ptr [rbp-0x100]
+       mov      rcx, gword ptr [r14+0x60]
+       test     byte  ptr [rcx+0x34], 16
+       jne      G_M16487_IG295
+       xor      ecx, ecx
+						;; size=57 bbWeight=7.30 PerfScore 127.77
+G_M16487_IG125:
        lea      edx, [8*rcx]
        or       edx, dword ptr [rax+0x10]
-       mov      dword ptr [rbp-0x108], edx
+       mov      dword ptr [rbp-0x10C], edx
        mov      rax, gword ptr [rax+0x08]
-       mov      gword ptr [rbp-0x1A8], rax
+       mov      gword ptr [rbp-0x1C8], rax
        cmp      byte  ptr [rax], al
        call     <unknown method>
        test     eax, eax
-       je       G_M16487_IG207
-       mov      rax, gword ptr [rbp-0x1A8]
+       je       G_M16487_IG296
+       mov      rax, gword ptr [rbp-0x1C8]
        mov      r8d, dword ptr [rax+0x28]
        cmp      r8d, 2
-       je       SHORT G_M16487_IG124
-						;; size=59 bbWeight=7.55 PerfScore 128.40
-G_M16487_IG120:
-       cmp      r8d, 4
-       je       SHORT G_M16487_IG122
-						;; size=6 bbWeight=5.04 PerfScore 6.29
-G_M16487_IG121:
-       cmp      r8d, 13
-       jne      G_M16487_IG203
-       mov      r10d, dword ptr [rax+0x2C]
-       jmp      SHORT G_M16487_IG125
-						;; size=16 bbWeight=2.52 PerfScore 13.22
-G_M16487_IG122:
-       mov      rcx, gword ptr [rax+0x08]
-       cmp      gword ptr [rcx+0x18], 0
-       jne      G_M16487_IG206
-       test     byte  ptr [rcx+0x34], 1
-       je       G_M16487_IG204
-						;; size=25 bbWeight=2.52 PerfScore 25.18
-G_M16487_IG123:
-       mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0x108]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      SHORT G_M16487_IG125
-						;; size=23 bbWeight=2.52 PerfScore 28.32
-G_M16487_IG124:
-       mov      gword ptr [rbp-0x1A8], rax
-       mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0x108]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       test     eax, eax
-       jl       G_M16487_IG148
-       mov      r10d, eax
-						;; size=36 bbWeight=2.52 PerfScore 28.95
-G_M16487_IG125:
-       mov      dword ptr [r14], r10d
-       mov      eax, dword ptr [rbp-0xF8]
-       mov      r14d, eax
-						;; size=12 bbWeight=7.49 PerfScore 16.86
+       je       G_M16487_IG201
+						;; size=63 bbWeight=7.30 PerfScore 124.12
 G_M16487_IG126:
-       cmp      r14d, -2
-       je       G_M16487_IG150
-						;; size=10 bbWeight=7.46 PerfScore 9.33
+       cmp      r8d, 4
+       je       G_M16487_IG175
+						;; size=10 bbWeight=4.87 PerfScore 6.08
 G_M16487_IG127:
+       cmp      r8d, 13
+       jne      G_M16487_IG299
+       mov      ecx, dword ptr [rax+0x2C]
+						;; size=13 bbWeight=2.43 PerfScore 7.91
+G_M16487_IG128:
+       mov      dword ptr [r15], ecx
+       mov      ecx, dword ptr [rbp-0x100]
+       mov      edx, ecx
+						;; size=11 bbWeight=7.32 PerfScore 16.47
+G_M16487_IG129:
+       mov      r15d, edx
+       cmp      r15d, -2
+       je       G_M16487_IG155
+						;; size=13 bbWeight=7.35 PerfScore 11.02
+G_M16487_IG130:
        mov      eax, dword ptr [rbp-0x70]
        test     eax, eax
-       je       G_M16487_IG284
+       je       G_M16487_IG302
        cmp      dword ptr [rbp-0x80], 0
-       jl       G_M16487_IG285
-       mov      r9d, r14d
-       sub      r9d, dword ptr [rbp-0x80]
-						;; size=28 bbWeight=7.45 PerfScore 55.90
-G_M16487_IG128:
-       cmp      dword ptr [r15+0xA8], 1
-       jg       G_M16487_IG294
-						;; size=14 bbWeight=7.45 PerfScore 29.82
-G_M16487_IG129:
-       sub      r14d, r9d
+       jl       G_M16487_IG303
+       mov      r8d, r15d
+       sub      r8d, dword ptr [rbp-0x80]
+						;; size=28 bbWeight=7.34 PerfScore 55.03
+G_M16487_IG131:
+       cmp      dword ptr [r14+0xA8], 1
+       jg       G_M16487_IG312
+						;; size=14 bbWeight=7.34 PerfScore 29.35
+G_M16487_IG132:
+       mov      r13d, r15d
+       sub      r13d, r8d
        xor      rcx, rcx
        mov      gword ptr [rbp-0x60], rcx
-						;; size=9 bbWeight=7.45 PerfScore 11.18
-G_M16487_IG130:
-       mov      gword ptr [rbp-0x58], rcx
-       mov      dword ptr [rbp-0x50], r9d
-       mov      dword ptr [rbp-0x4C], r14d
-						;; size=12 bbWeight=7.45 PerfScore 22.36
-G_M16487_IG131:
-       mov      r14, gword ptr [rbp-0x60]
-       mov      r15, gword ptr [rbp-0x58]
-       mov      r13d, dword ptr [rbp-0x50]
-       mov      r11d, dword ptr [rbp-0x4C]
-       test     r13d, r13d
-       jl       G_M16487_IG152
-						;; size=25 bbWeight=7.46 PerfScore 39.19
-G_M16487_IG132:
-       lea      ecx, [r11+r13]
-       mov      r8d, ecx
-       cmp      dword ptr [rbx+0x60], 2
-       je       G_M16487_IG297
-						;; size=17 bbWeight=7.45 PerfScore 35.41
+						;; size=12 bbWeight=7.34 PerfScore 12.84
 G_M16487_IG133:
-       mov      r15d, r13d
-       mov      r14d, r8d
-       cmp      r14d, r15d
-       jl       G_M16487_IG301
-						;; size=15 bbWeight=7.45 PerfScore 13.05
+       mov      gword ptr [rbp-0x58], rcx
+       mov      dword ptr [rbp-0x50], r8d
+       mov      dword ptr [rbp-0x4C], r13d
+						;; size=12 bbWeight=7.34 PerfScore 22.01
 G_M16487_IG134:
-       cmp      dword ptr [rbx+0x58], 0
-       je       G_M16487_IG302
-						;; size=10 bbWeight=7.45 PerfScore 29.82
+       mov      r13, gword ptr [rbp-0x60]
+       mov      r9, gword ptr [rbp-0x58]
+       mov      r15, r9
+       mov      ecx, dword ptr [rbp-0x50]
+       mov      r14d, ecx
+       mov      r11d, dword ptr [rbp-0x4C]
+       test     r14d, r14d
+       jl       G_M16487_IG174
+						;; size=30 bbWeight=7.35 PerfScore 42.24
 G_M16487_IG135:
-       mov      rdx, gword ptr [rbx+0x20]
-       mov      eax, dword ptr [rbx+0x58]
-       dec      eax
-       mov      dword ptr [rbx+0x58], eax
-       cmp      eax, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       mov      ecx, eax
-       xor      eax, eax
-       mov      dword ptr [rdx+4*rcx+0x10], eax
-       mov      r13, gword ptr [rbx+0x28]
-       mov      rax, gword ptr [r13+0x48]
-       cmp      dword ptr [rax+0x08], 0
-       jbe      G_M16487_IG315
-       mov      gword ptr [rbp-0x1B8], rax
-       cmp      gword ptr [rax+0x10], 0
-       je       G_M16487_IG303
-						;; size=65 bbWeight=7.45 PerfScore 177.04
+       lea      edx, [r14+r11]
+       mov      r8d, edx
+       cmp      dword ptr [rbx+0x60], 2
+       je       G_M16487_IG315
+						;; size=17 bbWeight=7.34 PerfScore 34.85
 G_M16487_IG136:
-       mov      rcx, gword ptr [r13+0x48]
+       mov      r13d, r14d
+       mov      r15d, r8d
+       cmp      r15d, r13d
+       jl       G_M16487_IG319
+						;; size=15 bbWeight=7.34 PerfScore 12.84
+G_M16487_IG137:
+       cmp      dword ptr [rbx+0x58], 0
+       je       G_M16487_IG320
+						;; size=10 bbWeight=7.34 PerfScore 29.35
+G_M16487_IG138:
+       mov      rcx, gword ptr [rbx+0x20]
+       mov      r10d, dword ptr [rbx+0x58]
+       dec      r10d
+       mov      dword ptr [rbx+0x58], r10d
+       cmp      r10d, dword ptr [rcx+0x08]
+       jae      G_M16487_IG205
+       mov      edx, r10d
+       xor      eax, eax
+       mov      dword ptr [rcx+4*rdx+0x10], eax
+       mov      r10, gword ptr [rbx+0x28]
+       mov      r14, r10
+       mov      rcx, gword ptr [r14+0x48]
+       mov      rax, rcx
+       cmp      dword ptr [rax+0x08], 0
+       jbe      G_M16487_IG205
+       mov      gword ptr [rbp-0x1E0], rax
+       cmp      gword ptr [rax+0x10], 0
+       je       G_M16487_IG321
+						;; size=76 bbWeight=7.34 PerfScore 177.92
+G_M16487_IG139:
+       mov      rcx, gword ptr [r14+0x48]
        mov      r10, rcx
-       mov      r13, gword ptr [r13+0x50]
-       cmp      dword ptr [r13+0x08], 0
-       jbe      G_M16487_IG315
-       mov      edx, dword ptr [r13+0x10]
-       mov      r9d, edx
+       mov      rcx, gword ptr [r14+0x50]
+       mov      r14, rcx
+       cmp      dword ptr [r14+0x08], 0
+       jbe      G_M16487_IG205
+       mov      ecx, dword ptr [r14+0x10]
+       mov      r9d, ecx
        cmp      dword ptr [r10+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      rcx, gword ptr [r10+0x10]
        lea      edx, [2*r9+0x02]
        cmp      dword ptr [rcx+0x08], edx
-       jl       G_M16487_IG304
-						;; size=61 bbWeight=7.45 PerfScore 156.54
-G_M16487_IG137:
+       jl       G_M16487_IG322
+						;; size=64 bbWeight=7.34 PerfScore 155.91
+G_M16487_IG140:
        cmp      dword ptr [r10+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      rcx, gword ptr [r10+0x10]
        lea      edx, [r9+r9]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M16487_IG315
+       jae      G_M16487_IG205
        lea      edx, [r9+r9]
-       mov      dword ptr [rcx+4*rdx+0x10], r15d
+       mov      dword ptr [rcx+4*rdx+0x10], r13d
        cmp      dword ptr [r10+0x08], 0
-       jbe      G_M16487_IG315
-       mov      rax, gword ptr [r10+0x10]
-       lea      r10d, [2*r9+0x01]
-       cmp      r10d, dword ptr [rax+0x08]
-       jae      G_M16487_IG315
-       mov      ecx, r10d
-       mov      edx, r14d
-       sub      edx, r15d
-       mov      dword ptr [rax+4*rcx+0x10], edx
-       cmp      dword ptr [r13+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
+       mov      rcx, gword ptr [r10+0x10]
+       lea      r11d, [2*r9+0x01]
+       cmp      r11d, dword ptr [rcx+0x08]
+       jae      G_M16487_IG205
+       mov      edx, r11d
+       mov      eax, r15d
+       sub      eax, r13d
+       mov      dword ptr [rcx+4*rdx+0x10], eax
+       cmp      dword ptr [r14+0x08], 0
+       jbe      G_M16487_IG205
        lea      ecx, [r9+0x01]
-       mov      dword ptr [r13+0x10], ecx
-						;; size=102 bbWeight=7.45 PerfScore 221.77
-G_M16487_IG138:
-       mov      dword ptr [rbx+0x4C], r8d
-						;; size=4 bbWeight=7.45 PerfScore 7.45
-G_M16487_IG139:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      r13, gword ptr [r8+0x28]
-       mov      rdx, gword ptr [r13+0x50]
-       cmp      dword ptr [rdx+0x08], 0
-       jbe      G_M16487_IG315
-       cmp      dword ptr [rdx+0x10], 0
-       jle      G_M16487_IG193
-						;; size=35 bbWeight=7.46 PerfScore 97.04
-G_M16487_IG140:
-       movzx    r15, byte  ptr [rbp+0x48]
-       test     r15b, r15b
-       je       G_M16487_IG149
-						;; size=14 bbWeight=7.47 PerfScore 16.81
+       mov      dword ptr [r14+0x10], ecx
+						;; size=102 bbWeight=7.34 PerfScore 218.27
 G_M16487_IG141:
-       mov      r8, gword ptr [rbp-0x138]
+       mov      dword ptr [rbx+0x4C], r8d
+       mov      r15d, dword ptr [rbp-0x118]
+						;; size=11 bbWeight=7.34 PerfScore 14.67
+G_M16487_IG142:
+       mov      r8, gword ptr [rbp-0x148]
+       mov      r13, gword ptr [r8+0x28]
+       mov      rax, gword ptr [r13+0x50]
+       cmp      dword ptr [rax+0x08], 0
+       jbe      G_M16487_IG205
+       cmp      dword ptr [rax+0x10], 0
+       jle      G_M16487_IG202
+						;; size=35 bbWeight=7.35 PerfScore 95.51
+G_M16487_IG143:
+       test     dil, dil
+       je       G_M16487_IG154
+						;; size=9 bbWeight=7.35 PerfScore 9.19
+G_M16487_IG144:
+       mov      r8, gword ptr [rbp-0x148]
        mov      eax, dword ptr [r8+0x4C]
-       mov      rdx, gword ptr [r13+0x50]
-       cmp      dword ptr [rdx+0x08], 0
-       jbe      G_M16487_IG315
-       mov      edx, dword ptr [rdx+0x10]
-       mov      dword ptr [r13+0x30], edx
-       xor      edx, edx
-       mov      dword ptr [r13+0x34], edx
+       mov      rcx, gword ptr [r13+0x50]
+       cmp      dword ptr [rcx+0x08], 0
+       jbe      G_M16487_IG205
+       mov      ecx, dword ptr [rcx+0x10]
+       mov      dword ptr [r13+0x30], ecx
+       xor      ecx, ecx
+       mov      dword ptr [r13+0x34], ecx
        mov      dword ptr [r13+0x58], eax
-       mov      edx, dword ptr [r13+0x5C]
-       mov      dword ptr [r13+0x5C], edx
+       mov      ecx, dword ptr [r13+0x5C]
+       mov      dword ptr [r13+0x5C], ecx
        mov      rbx, gword ptr [r13+0x48]
        cmp      dword ptr [rbx+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      r10, gword ptr [rbx+0x10]
        cmp      dword ptr [r10+0x08], 1
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      r9d, dword ptr [r10+0x14]
        mov      dword ptr [r13+0x14], r9d
        cmp      dword ptr [r10+0x08], 0
-       jbe      G_M16487_IG315
+       jbe      G_M16487_IG205
        mov      r11d, dword ptr [r10+0x10]
        mov      dword ptr [r13+0x10], r11d
-       mov      ebx, dword ptr [rbp+0x40]
-       cmp      ebx, 2
-       je       G_M16487_IG308
-						;; size=118 bbWeight=7.46 PerfScore 309.71
-G_M16487_IG142:
-       cmp      dword ptr [r13+0x30], 0
-       je       G_M16487_IG317
-						;; size=11 bbWeight=7.46 PerfScore 29.86
-G_M16487_IG143:
-       mov      r14d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp+0x48], r15d
-       test     r15b, r15b
-       je       G_M16487_IG309
-						;; size=20 bbWeight=7.45 PerfScore 24.23
-G_M16487_IG144:
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rdi+0x18], rdx
-       jne      G_M16487_IG153
-       inc      dword ptr [rsi]
-						;; size=22 bbWeight=7.45 PerfScore 54.04
+       cmp      esi, 2
+       je       G_M16487_IG326
+						;; size=115 bbWeight=7.34 PerfScore 297.35
 G_M16487_IG145:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      r10d, dword ptr [r8+0x4C]
-       mov      eax, r10d
-       mov      edx, eax
-       cmp      dword ptr [r13+0x14], 0
-       je       G_M16487_IG310
-						;; size=27 bbWeight=7.45 PerfScore 55.91
+       cmp      dword ptr [r13+0x30], 0
+       je       G_M16487_IG335
+						;; size=11 bbWeight=7.35 PerfScore 29.39
 G_M16487_IG146:
+       mov      rbx, gword ptr [rbp+0x38]
+       test     dil, dil
+       je       G_M16487_IG327
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rbx+0x18], rcx
+       jne      G_M16487_IG151
+						;; size=33 bbWeight=7.34 PerfScore 47.69
+G_M16487_IG147:
+       mov      r14, bword ptr [rbp+0x30]
+       inc      dword ptr [r14]
+						;; size=7 bbWeight=7.34 PerfScore 29.35
+G_M16487_IG148:
+       mov      ecx, dword ptr [r8+0x4C]
+       mov      eax, ecx
+       mov      r10d, eax
+       cmp      dword ptr [r13+0x14], 0
+       je       G_M16487_IG330
+						;; size=20 bbWeight=7.34 PerfScore 47.69
+G_M16487_IG149:
        mov      rcx, gword ptr [r8+0x10]
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [r8+0x50], ecx
@@ -2515,1885 +2523,2079 @@ G_M16487_IG146:
        mov      rcx, gword ptr [r8+0x20]
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [r8+0x58], ecx
-       mov      dword ptr [rbp-0x3C], edx
-       mov      r14d, ebx
+       mov      dword ptr [rbp-0x3C], r10d
+       mov      bword ptr [rbp+0x30], r14
+       mov      r15, rbx
        mov      ebx, eax
-						;; size=41 bbWeight=7.45 PerfScore 123.00
-G_M16487_IG147:
-       mov      dword ptr [rbp+0x40], r14d
-       mov      dword ptr [r8+0x60], r14d
+						;; size=46 bbWeight=7.34 PerfScore 128.39
+G_M16487_IG150:
+       mov      r8, gword ptr [rbp-0x148]
+       mov      dword ptr [r8+0x60], esi
        lea      rcx, bword ptr [r8+0x30]
        mov      rdx, gword ptr [rbp+0x10]
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      dword ptr [r8+0x48], ebx
        xor      ecx, ecx
        mov      dword ptr [r8+0x40], ecx
-       mov      eax, dword ptr [rbp-0x110]
+       mov      eax, dword ptr [rbp-0x118]
        mov      dword ptr [r8+0x44], eax
        mov      dword ptr [r8+0x4C], ebx
        mov      rbx, gword ptr [r8+0x28]
        test     rbx, rbx
-       je       G_M16487_IG269
-       jmp      G_M16487_IG104
-						;; size=70 bbWeight=7.46 PerfScore 119.43
-G_M16487_IG148:
-       mov      rax, gword ptr [rbp-0x1A8]
-       jmp      G_M16487_IG204
-						;; size=12 bbWeight=1.26 PerfScore 3.78
-G_M16487_IG149:
+       je       G_M16487_IG271
+       jmp      G_M16487_IG110
+						;; size=73 bbWeight=7.35 PerfScore 117.55
+G_M16487_IG151:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG328
+						;; size=9 bbWeight=3.67 PerfScore 11.00
+G_M16487_IG152:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG288
+						;; size=9 bbWeight=3.66 PerfScore 10.98
+G_M16487_IG153:
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG275
+						;; size=9 bbWeight=3.67 PerfScore 11.02
+G_M16487_IG154:
        lea      rcx, bword ptr [r13+0x08]
        mov      rdx, gword ptr [rbp+0x18]
        call     CORINFO_HELP_ASSIGN_REF
-       xor      rdx, rdx
-       mov      r8, gword ptr [rbp-0x138]
-       mov      gword ptr [r8+0x28], rdx
-       jmp      G_M16487_IG141
+       xor      rcx, rcx
+       mov      r8, gword ptr [rbp-0x148]
+       mov      gword ptr [r8+0x28], rcx
+       jmp      G_M16487_IG144
 						;; size=31 bbWeight=0.01 PerfScore 0.05
-G_M16487_IG150:
+G_M16487_IG155:
        xor      rcx, rcx
        mov      gword ptr [rbp-0x60], rcx
 						;; size=6 bbWeight=0.01 PerfScore 0.01
-G_M16487_IG151:
+G_M16487_IG156:
        mov      gword ptr [rbp-0x58], rcx
        mov      dword ptr [rbp-0x50], -1
        mov      dword ptr [rbp-0x4C], -1
-       jmp      G_M16487_IG131
+       jmp      G_M16487_IG134
 						;; size=23 bbWeight=0.01 PerfScore 0.05
-G_M16487_IG152:
-       mov      r14d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbx+0x4C], r14d
-       jmp      G_M16487_IG139
-						;; size=16 bbWeight=7.46 PerfScore 29.86
-G_M16487_IG153:
-       mov      rdx, rsi
-       mov      r8, r13
-       mov      rcx, gword ptr [rdi+0x08]
-       call     [rdi+0x18]<unknown method>
-       test     eax, eax
-       je       G_M16487_IG317
-       movzx    r15, byte  ptr [rbp+0x48]
-       mov      dword ptr [rbp+0x48], r15d
-       jmp      G_M16487_IG145
-						;; size=35 bbWeight=7.45 PerfScore 80.13
-G_M16487_IG154:
-       mov      r10d, -1
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG125
-						;; size=18 bbWeight=0.01 PerfScore 0.02
-G_M16487_IG155:
-       xor      rdx, rdx
-       mov      gword ptr [r13+0x08], rdx
-       mov      rdx, 0xD1FFAB1E      ; const ptr
-       mov      r13, gword ptr [rdx]
-       mov      ebx, dword ptr [rbp+0x40]
-       movzx    r15, byte  ptr [rbp+0x48]
-       jmp      G_M16487_IG40
-						;; size=32 bbWeight=1.03 PerfScore 7.74
-G_M16487_IG156:
-       xor      r15d, r15d
-						;; size=3 bbWeight=0.03 PerfScore 0.01
 G_M16487_IG157:
-       mov      r14, gword ptr [rbp-0x158]
-       cmp      r15d, dword ptr [r14+0x08]
-       jae      G_M16487_IG315
-       mov      edx, r15d
-       mov      rdx, gword ptr [r14+8*rdx+0x10]
-       mov      edx, dword ptr [rdx+0x14]
-       mov      dword ptr [rbp-0xB0], edx
-       xor      rdx, rdx
-       mov      gword ptr [rbp-0xB8], rdx
+       mov      ecx, -1
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG128
+						;; size=17 bbWeight=0.02 PerfScore 0.06
+G_M16487_IG158:
+       test     r14d, r14d
+       je       G_M16487_IG280
+       test     r15d, r15d
+       jne      G_M16487_IG282
+       mov      dword ptr [rbp-0xA0], edx
+       mov      r14d, dword ptr [rbp-0xA0]
+       mov      dword ptr [rbp-0x78], r14d
+       mov      r15d, dword ptr [rbp-0xA0]
+       mov      dword ptr [rbp-0xA8], r15d
+       mov      r14, gword ptr [r10+0x80]
+       mov      gword ptr [rbp-0x170], r14
+       mov      r15d, dword ptr [rbp-0xA0]
+       dec      r15d
+       test     byte  ptr [rcx+0x34], 16
+       je       G_M16487_IG182
+						;; size=83 bbWeight=0.03 PerfScore 0.45
+G_M16487_IG159:
+       cmp      r15d, r11d
+       jb       G_M16487_IG177
+       mov      ecx, -1
+						;; size=14 bbWeight=0.11 PerfScore 0.17
+G_M16487_IG160:
+       mov      r11, gword ptr [r10+0x98]
+       lea      r15d, [rcx+0x01]
+       cmp      r15d, dword ptr [r11+0x08]
+       jae      G_M16487_IG205
+       inc      ecx
+       mov      ecx, dword ptr [r11+4*rcx+0x10]
+						;; size=28 bbWeight=0.11 PerfScore 0.99
+G_M16487_IG161:
+       mov      r14, gword ptr [rbp-0x170]
+       cmp      ecx, dword ptr [r14+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, ecx
+       mov      rcx, gword ptr [r14+8*rcx+0x10]
+       mov      ecx, dword ptr [rcx+0x14]
+       mov      dword ptr [rbp-0xB0], ecx
+       xor      rcx, rcx
+       mov      gword ptr [rbp-0xB8], rcx
        mov      dword ptr [rbp-0xC0], -2
        mov      dword ptr [rbp-0xC8], -1
-						;; size=63 bbWeight=0.03 PerfScore 0.40
-G_M16487_IG158:
-       cmp      byte  ptr [r10+0xAC], 0
-       je       SHORT G_M16487_IG160
-						;; size=10 bbWeight=0.24 PerfScore 0.96
-G_M16487_IG159:
-       mov      edx, eax
-       sub      edx, dword ptr [rbp-0xA0]
-       cmp      edx, 0x3E8
-       jg       G_M16487_IG176
-						;; size=20 bbWeight=0.12 PerfScore 0.42
-G_M16487_IG160:
-       mov      r15d, eax
-						;; size=3 bbWeight=0.12 PerfScore 0.03
-G_M16487_IG161:
-       cmp      gword ptr [rbp-0xB8], 0
-       jne      G_M16487_IG177
-						;; size=14 bbWeight=0.24 PerfScore 0.72
+						;; size=62 bbWeight=0.11 PerfScore 1.53
 G_M16487_IG162:
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      rdx, [rbp-0xA0]
-       mov      qword ptr [rsp+0x20], rdx
-       lea      rdx, [rbp-0xB8]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0xC0]
-       mov      qword ptr [rsp+0x30], rdx
-       lea      rdx, [rbp-0xC8]
-       mov      qword ptr [rsp+0x38], rdx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x40], rdx
-       lea      rdx, [rbp-0xA8]
-       mov      qword ptr [rsp+0x48], rdx
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      r8d, r15d
-       mov      r9d, dword ptr [rbp-0x70]
-       call     [<unknown method>]
-						;; size=116 bbWeight=0.12 PerfScore 2.15
+       cmp      byte  ptr [r10+0xAC], 0
+       je       SHORT G_M16487_IG164
+						;; size=10 bbWeight=0.91 PerfScore 3.62
 G_M16487_IG163:
-       test     eax, eax
-       jne      G_M16487_IG178
-       mov      r14d, dword ptr [rbp-0x110]
-       cmp      dword ptr [rbp-0xA0], r14d
-       jge      G_M16487_IG178
-       cmp      dword ptr [rbp-0xA0], r15d
-       jge      G_M16487_IG167
-						;; size=41 bbWeight=0.24 PerfScore 1.97
+       mov      ecx, eax
+       sub      ecx, dword ptr [rbp-0xA0]
+       cmp      ecx, 0x3E8
+       jg       G_M16487_IG183
+						;; size=20 bbWeight=0.45 PerfScore 1.59
 G_M16487_IG164:
-       mov      r15, gword ptr [r13+0x08]
-       mov      r8d, dword ptr [rbp-0xB0]
-       mov      rax, gword ptr [rbp-0x150]
-       mov      r9, gword ptr [rax+0x10]
-       cmp      r8d, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       mov      ecx, r8d
-       mov      r11, gword ptr [r9+8*rcx+0x10]
-       mov      rcx, gword ptr [r15+0x08]
+       mov      r14d, eax
+						;; size=3 bbWeight=0.45 PerfScore 0.11
+G_M16487_IG165:
+       cmp      gword ptr [rbp-0xB8], 0
+       jne      G_M16487_IG184
+						;; size=14 bbWeight=0.91 PerfScore 2.72
+G_M16487_IG166:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], eax
+       lea      rcx, [rbp-0xA0]
+       mov      qword ptr [rsp+0x20], rcx
+       lea      rcx, [rbp-0xB8]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0xC0]
+       mov      qword ptr [rsp+0x30], rcx
+       lea      rcx, [rbp-0xC8]
+       mov      qword ptr [rsp+0x38], rcx
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x40], rcx
+       lea      rcx, [rbp-0xA8]
+       mov      qword ptr [rsp+0x48], rcx
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r14d
+       mov      dword ptr [rbp-0x70], r9d
+       call     [<unknown method>]
+						;; size=115 bbWeight=0.45 PerfScore 8.16
+G_M16487_IG167:
+       test     eax, eax
+       jne      G_M16487_IG185
+       mov      r15d, dword ptr [rbp-0x118]
+       cmp      dword ptr [rbp-0xA0], r15d
+       jge      G_M16487_IG185
+       cmp      dword ptr [rbp-0xA0], r14d
+       jge      G_M16487_IG171
+						;; size=41 bbWeight=0.91 PerfScore 7.48
+G_M16487_IG168:
+       mov      rax, gword ptr [r13+0x08]
+       mov      r14, rax
+       mov      r10d, dword ptr [rbp-0xB0]
+       mov      rax, gword ptr [rbp-0x160]
+       mov      r11, gword ptr [rax+0x10]
+       cmp      r10d, dword ptr [r11+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, r10d
+       mov      rdx, gword ptr [r11+8*rcx+0x10]
+       mov      rcx, gword ptr [r14+0x08]
        mov      rcx, gword ptr [rcx+0x08]
        inc      dword ptr [rcx+0x14]
-       xor      edx, edx
-       mov      dword ptr [rcx+0x10], edx
-       mov      r8, gword ptr [r11+0x08]
-       mov      gword ptr [rbp-0x170], r8
-       mov      r9d, dword ptr [r11+0x10]
-       mov      dword ptr [rbp-0xCC], r9d
-       mov      rcx, gword ptr [r15+0x08]
-       mov      gword ptr [rbp-0x178], rcx
+       xor      r8d, r8d
+       mov      dword ptr [rcx+0x10], r8d
+       mov      r8, gword ptr [rdx+0x08]
+       mov      gword ptr [rbp-0x188], r8
+       mov      r9d, dword ptr [rdx+0x10]
+       mov      dword ptr [rbp-0xD0], r9d
+       mov      rcx, gword ptr [r14+0x08]
+       mov      gword ptr [rbp-0x190], rcx
        mov      rcx, 0xD1FFAB1E
        mov      edx, 1
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        mov      rcx, 0xD1FFAB1E      ; static handle
        mov      rax, gword ptr [rcx]
        test     rax, rax
-       jne      G_M16487_IG166
-						;; size=131 bbWeight=0.12 PerfScore 4.12
-G_M16487_IG165:
+       jne      G_M16487_IG170
+						;; size=136 bbWeight=0.45 PerfScore 15.74
+G_M16487_IG169:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x180], rax
+       mov      gword ptr [rbp-0x198], rax
        mov      rcx, 0xD1FFAB1E
        mov      edx, 1
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        mov      rcx, 0xD1FFAB1E      ; static handle
        mov      rdx, gword ptr [rcx]
        test     rdx, rdx
-       je       G_M16487_IG313
-       mov      rax, gword ptr [rbp-0x180]
+       je       G_M16487_IG333
+       mov      rax, gword ptr [rbp-0x198]
        lea      rcx, bword ptr [rax+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, 0xD1FFAB1E      ; function address
-       mov      rax, gword ptr [rbp-0x180]
+       mov      rax, gword ptr [rbp-0x198]
        mov      qword ptr [rax+0x18], rcx
        mov      rcx, 0xD1FFAB1E
        mov      edx, 1
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
        mov      rcx, 0xD1FFAB1E      ; static handle
-       mov      rdx, gword ptr [rbp-0x180]
+       mov      rdx, gword ptr [rbp-0x198]
        call     CORINFO_HELP_ASSIGN_REF
-       mov      rax, gword ptr [rbp-0x180]
-						;; size=150 bbWeight=0.01 PerfScore 0.13
-G_M16487_IG166:
-       mov      rcx, gword ptr [rbp-0x178]
+       mov      rax, gword ptr [rbp-0x198]
+						;; size=150 bbWeight=0.03 PerfScore 0.47
+G_M16487_IG170:
+       mov      rcx, gword ptr [rbp-0x190]
        mov      gword ptr [rsp+0x20], rcx
        mov      gword ptr [rsp+0x28], rax
-       mov      rcx, gword ptr [rbp-0x150]
-       mov      r8, gword ptr [rbp-0x170]
-       mov      r9d, dword ptr [rbp-0xCC]
+       mov      rcx, gword ptr [rbp-0x160]
+       mov      r8, gword ptr [rbp-0x188]
+       mov      r9d, dword ptr [rbp-0xD0]
        mov      rdx, 0xD1FFAB1E      ; <unknown method>
        cmp      dword ptr [rcx], ecx
        call     [<unknown method>]
        mov      dword ptr [rbp-0xB0], -1
-       mov      gword ptr [rbp-0xB8], r15
-						;; size=73 bbWeight=0.12 PerfScore 1.70
-G_M16487_IG167:
-       mov      r15, gword ptr [rbp-0x150]
-       cmp      byte  ptr [r15+0xAC], 0
-       je       SHORT G_M16487_IG168
+       mov      gword ptr [rbp-0xB8], r14
+						;; size=73 bbWeight=0.45 PerfScore 6.46
+G_M16487_IG171:
+       mov      r14, gword ptr [rbp-0x160]
+       cmp      byte  ptr [r14+0xAC], 0
+       je       SHORT G_M16487_IG172
        call     <unknown method>
        mov      r15, qword ptr [rbp-0x68]
        cmp      rax, r15
-       jge      G_M16487_IG312
+       jge      G_M16487_IG332
        mov      qword ptr [rbp-0x68], r15
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r10, gword ptr [rbp-0x150]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG158
-						;; size=61 bbWeight=0.24 PerfScore 3.40
-G_M16487_IG168:
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r10, gword ptr [rbp-0x150]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG158
-						;; size=22 bbWeight=0.12 PerfScore 0.60
-G_M16487_IG169:
-       test     r14d, r14d
-       je       G_M16487_IG277
-       test     r15d, r15d
-       jne      G_M16487_IG279
-       mov      dword ptr [rbp-0xA0], r11d
-       mov      r14d, dword ptr [rbp-0xA0]
-       mov      dword ptr [rbp-0x78], r14d
-       mov      r15d, dword ptr [rbp-0xA0]
-       mov      dword ptr [rbp-0xA8], r15d
-       mov      r14, gword ptr [r10+0x80]
-       mov      gword ptr [rbp-0x158], r14
-       mov      r15d, dword ptr [rbp-0xA0]
-       dec      r15d
-       test     byte  ptr [rdx+0x34], 16
-       je       G_M16487_IG156
-						;; size=84 bbWeight=0.01 PerfScore 0.12
-G_M16487_IG170:
-       cmp      r15d, r9d
-       jb       SHORT G_M16487_IG171
-       mov      r15d, -1
-       jmp      SHORT G_M16487_IG175
-						;; size=13 bbWeight=0.03 PerfScore 0.10
-G_M16487_IG171:
-       cmp      r15d, r9d
-       jae      G_M16487_IG315
-       mov      edx, r15d
-       mov      r14, bword ptr [rbp-0x1D0]
-       movzx    rdx, word  ptr [r14+2*rdx]
-       cmp      edx, 10
-       jne      SHORT G_M16487_IG172
-       dec      r9d
-       cmp      r15d, r9d
-       je       SHORT G_M16487_IG174
-						;; size=37 bbWeight=0.03 PerfScore 0.22
-G_M16487_IG172:
-       mov      r15, gword ptr [r10+0x50]
-       mov      r9, gword ptr [r15+0x08]
-       cmp      dword ptr [r9+0x08], edx
-       jbe      G_M16487_IG201
-       cmp      edx, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       mov      edx, edx
-       mov      r15d, dword ptr [r9+4*rdx+0x10]
-						;; size=35 bbWeight=0.01 PerfScore 0.11
-G_M16487_IG173:
-       jmp      SHORT G_M16487_IG175
-						;; size=2 bbWeight=0.03 PerfScore 0.06
-G_M16487_IG174:
-       mov      rdx, gword ptr [r10+0x90]
-       mov      r15d, dword ptr [rdx+0x08]
-						;; size=11 bbWeight=0.03 PerfScore 0.12
-G_M16487_IG175:
-       mov      r9, gword ptr [r10+0x98]
-       lea      edx, [r15+0x01]
-       cmp      edx, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       lea      edx, [r15+0x01]
-       mov      r15d, dword ptr [r9+4*rdx+0x10]
-       jmp      G_M16487_IG157
-						;; size=35 bbWeight=0.03 PerfScore 0.33
-G_M16487_IG176:
-       mov      r15d, dword ptr [rbp-0xA0]
-       add      r15d, 0x3E8
-       jmp      G_M16487_IG161
-						;; size=19 bbWeight=0.12 PerfScore 0.39
-G_M16487_IG177:
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      rdx, [rbp-0xA0]
-       mov      qword ptr [rsp+0x20], rdx
-       lea      rdx, [rbp-0xB8]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0xC0]
-       mov      qword ptr [rsp+0x30], rdx
-       lea      rdx, [rbp-0xC8]
-       mov      qword ptr [rsp+0x38], rdx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x40], rdx
-       lea      rdx, [rbp-0xA8]
-       mov      qword ptr [rsp+0x48], rdx
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      r8d, r15d
+       mov      eax, dword ptr [rbp-0x118]
+       mov      edx, dword ptr [rbp-0x6C]
        mov      r9d, dword ptr [rbp-0x70]
-       call     [<unknown method>]
-       jmp      G_M16487_IG163
-						;; size=121 bbWeight=0.12 PerfScore 2.39
+       mov      r10, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG162
+						;; size=64 bbWeight=0.91 PerfScore 13.82
+G_M16487_IG172:
+       mov      eax, dword ptr [rbp-0x118]
+       mov      edx, dword ptr [rbp-0x6C]
+       mov      r9d, dword ptr [rbp-0x70]
+       mov      r10, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG162
+						;; size=25 bbWeight=0.45 PerfScore 2.72
+G_M16487_IG173:
+       xor      rcx, rcx
+       mov      gword ptr [r13+0x08], rcx
+       mov      rcx, 0xD1FFAB1E      ; const ptr
+       mov      r13, gword ptr [rcx]
+       mov      r8, gword ptr [rbp-0x148]
+       jmp      G_M16487_IG42
+						;; size=31 bbWeight=0.96 PerfScore 6.24
+G_M16487_IG174:
+       mov      r15d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbx+0x4C], r15d
+       jmp      G_M16487_IG142
+						;; size=16 bbWeight=7.35 PerfScore 29.39
+G_M16487_IG175:
+       mov      rcx, gword ptr [rax+0x08]
+       cmp      gword ptr [rcx+0x18], 0
+       jne      G_M16487_IG297
+       test     byte  ptr [rcx+0x34], 1
+       je       G_M16487_IG298
+						;; size=25 bbWeight=2.43 PerfScore 24.34
+G_M16487_IG176:
+       mov      rcx, gword ptr [rax+0x08]
+       mov      edx, dword ptr [rbp-0x10C]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       mov      ecx, eax
+       jmp      G_M16487_IG128
+						;; size=25 bbWeight=2.43 PerfScore 27.38
+G_M16487_IG177:
+       cmp      r15d, r11d
+       jae      G_M16487_IG205
+       mov      ecx, r15d
+       mov      r14, bword ptr [rbp-0x208]
+       movzx    rcx, word  ptr [r14+2*rcx]
+       cmp      ecx, 10
+       jne      SHORT G_M16487_IG178
+       dec      r11d
+       cmp      r15d, r11d
+       je       SHORT G_M16487_IG181
+						;; size=37 bbWeight=0.11 PerfScore 0.82
 G_M16487_IG178:
-       lea      r14, bword ptr [rbp-0x80]
-       cmp      dword ptr [rbp-0xC8], 0
-       jg       SHORT G_M16487_IG179
-       mov      r15d, -1
-       jmp      G_M16487_IG192
-						;; size=24 bbWeight=0.03 PerfScore 0.17
+       mov      r11, gword ptr [r10+0x50]
+       mov      r14, gword ptr [r11+0x08]
+       cmp      dword ptr [r14+0x08], ecx
+       jbe      G_M16487_IG212
+						;; size=18 bbWeight=0.03 PerfScore 0.23
 G_M16487_IG179:
-       mov      eax, dword ptr [rbp-0xC8]
-       mov      r15, gword ptr [rbp-0x150]
-       mov      rcx, gword ptr [r15+0x10]
-       cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M16487_IG315
-       mov      rax, gword ptr [rcx+8*rax+0x10]
-       mov      edx, dword ptr [rbp-0xC0]
+       cmp      ecx, dword ptr [r14+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, ecx
+       mov      ecx, dword ptr [r14+4*rcx+0x10]
+						;; size=17 bbWeight=0.03 PerfScore 0.18
+G_M16487_IG180:
+       jmp      G_M16487_IG160
+						;; size=5 bbWeight=0.11 PerfScore 0.23
+G_M16487_IG181:
+       mov      rcx, gword ptr [r10+0x90]
+       mov      ecx, dword ptr [rcx+0x08]
+       jmp      G_M16487_IG160
+						;; size=15 bbWeight=0.11 PerfScore 0.68
+G_M16487_IG182:
+       xor      ecx, ecx
+       jmp      G_M16487_IG161
+						;; size=7 bbWeight=0.11 PerfScore 0.25
+G_M16487_IG183:
+       mov      r14d, dword ptr [rbp-0xA0]
+       add      r14d, 0x3E8
+       jmp      G_M16487_IG165
+						;; size=19 bbWeight=0.45 PerfScore 1.47
+G_M16487_IG184:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], eax
+       lea      rcx, [rbp-0xA0]
+       mov      qword ptr [rsp+0x20], rcx
+       lea      rcx, [rbp-0xB8]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0xC0]
+       mov      qword ptr [rsp+0x30], rcx
+       lea      rcx, [rbp-0xC8]
+       mov      qword ptr [rsp+0x38], rcx
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x40], rcx
+       lea      rcx, [rbp-0xA8]
+       mov      qword ptr [rsp+0x48], rcx
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r14d
+       mov      dword ptr [rbp-0x70], r9d
+       call     [<unknown method>]
+       jmp      G_M16487_IG167
+						;; size=120 bbWeight=0.45 PerfScore 9.06
+G_M16487_IG185:
+       lea      rax, bword ptr [rbp-0x80]
+       mov      r14, rax
+       cmp      dword ptr [rbp-0xC8], 0
+       jg       SHORT G_M16487_IG186
+       mov      eax, -1
+       jmp      G_M16487_IG200
+						;; size=26 bbWeight=0.11 PerfScore 0.68
+G_M16487_IG186:
+       mov      ecx, dword ptr [rbp-0xC8]
+       mov      r15, gword ptr [rbp-0x160]
+       mov      r8, gword ptr [r15+0x10]
+       cmp      ecx, dword ptr [r8+0x08]
+       jae      G_M16487_IG205
+       mov      eax, ecx
+       mov      rax, gword ptr [r8+8*rax+0x10]
+       mov      r10d, dword ptr [rbp-0xC0]
        mov      rcx, gword ptr [r15+0x60]
        test     byte  ptr [rcx+0x34], 16
-       je       G_M16487_IG185
-       mov      ecx, dword ptr [rbp-0x110]
-       cmp      edx, ecx
-       jb       SHORT G_M16487_IG180
-       mov      r8d, -1
-       jmp      SHORT G_M16487_IG184
-						;; size=69 bbWeight=0.03 PerfScore 0.64
-G_M16487_IG180:
-       cmp      edx, ecx
-       jae      G_M16487_IG315
-       mov      r8d, edx
-       movzx    r8, word  ptr [r12+2*r8]
-       cmp      r8d, 10
-       jne      SHORT G_M16487_IG181
-       lea      r10d, [rcx-0x01]
-       cmp      edx, r10d
-       mov      ecx, dword ptr [rbp-0x110]
-       je       SHORT G_M16487_IG183
-						;; size=37 bbWeight=0.03 PerfScore 0.22
-G_M16487_IG181:
-       mov      r10, gword ptr [r15+0x50]
-       mov      r9, gword ptr [r10+0x08]
-       cmp      dword ptr [r9+0x08], r8d
-       jbe      G_M16487_IG200
-       cmp      r8d, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
-       mov      edx, r8d
-       mov      r8d, dword ptr [r9+4*rdx+0x10]
-						;; size=36 bbWeight=0.01 PerfScore 0.11
-G_M16487_IG182:
-       jmp      SHORT G_M16487_IG184
-						;; size=2 bbWeight=0.03 PerfScore 0.06
-G_M16487_IG183:
-       mov      r8, gword ptr [r15+0x90]
-       mov      r8d, dword ptr [r8+0x08]
-						;; size=11 bbWeight=0.03 PerfScore 0.12
-G_M16487_IG184:
-       mov      rdx, gword ptr [r15+0x98]
-       lea      r10d, [r8+0x01]
-       cmp      r10d, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       inc      r8d
-       mov      r8d, dword ptr [rdx+4*r8+0x10]
-       jmp      SHORT G_M16487_IG186
-						;; size=31 bbWeight=0.03 PerfScore 0.32
-G_M16487_IG185:
-       xor      r8d, r8d
-						;; size=3 bbWeight=0.03 PerfScore 0.01
-G_M16487_IG186:
-       lea      edx, [8*r8]
+       je       G_M16487_IG193
+       mov      ecx, dword ptr [rbp-0x118]
+       cmp      r10d, ecx
+       jb       SHORT G_M16487_IG187
+       mov      edx, -1
+       jmp      SHORT G_M16487_IG192
+						;; size=73 bbWeight=0.11 PerfScore 2.46
+G_M16487_IG187:
+       cmp      r10d, ecx
+       jae      G_M16487_IG205
+       mov      edx, r10d
+       movzx    rdx, word  ptr [r12+2*rdx]
+       cmp      edx, 10
+       jne      SHORT G_M16487_IG188
+       lea      r8d, [rcx-0x01]
+       cmp      r10d, r8d
+       mov      ecx, dword ptr [rbp-0x118]
+       je       SHORT G_M16487_IG191
+						;; size=37 bbWeight=0.11 PerfScore 0.85
+G_M16487_IG188:
+       mov      r8, gword ptr [r15+0x50]
+       mov      r9, gword ptr [r8+0x08]
+       cmp      dword ptr [r9+0x08], edx
+       jbe      G_M16487_IG211
+						;; size=18 bbWeight=0.03 PerfScore 0.23
+G_M16487_IG189:
+       cmp      edx, dword ptr [r9+0x08]
+       jae      G_M16487_IG205
+       mov      edx, edx
+       mov      edx, dword ptr [r9+4*rdx+0x10]
+						;; size=17 bbWeight=0.03 PerfScore 0.18
+G_M16487_IG190:
+       jmp      SHORT G_M16487_IG192
+						;; size=2 bbWeight=0.11 PerfScore 0.23
+G_M16487_IG191:
+       mov      rdx, gword ptr [r15+0x90]
+       mov      edx, dword ptr [rdx+0x08]
+						;; size=10 bbWeight=0.11 PerfScore 0.45
+G_M16487_IG192:
+       mov      r11, gword ptr [r15+0x98]
+       lea      r8d, [rdx+0x01]
+       cmp      r8d, dword ptr [r11+0x08]
+       jae      G_M16487_IG205
+       inc      edx
+       mov      edx, dword ptr [r11+4*rdx+0x10]
+       jmp      SHORT G_M16487_IG194
+						;; size=30 bbWeight=0.11 PerfScore 1.22
+G_M16487_IG193:
+       xor      edx, edx
+						;; size=2 bbWeight=0.11 PerfScore 0.03
+G_M16487_IG194:
+       shl      edx, 3
        or       edx, dword ptr [rax+0x10]
-       mov      dword ptr [rbp-0xD0], edx
+       mov      dword ptr [rbp-0xD8], edx
        mov      rax, gword ptr [rax+0x08]
-       mov      gword ptr [rbp-0x188], rax
+       mov      gword ptr [rbp-0x1A0], rax
        cmp      byte  ptr [rax], al
        call     <unknown method>
        test     eax, eax
-       je       G_M16487_IG199
-       mov      rax, gword ptr [rbp-0x188]
+       je       G_M16487_IG210
+       mov      rax, gword ptr [rbp-0x1A0]
        mov      r8d, dword ptr [rax+0x28]
        cmp      r8d, 2
-       jne      G_M16487_IG194
-						;; size=64 bbWeight=0.01 PerfScore 0.13
-G_M16487_IG187:
-       mov      gword ptr [rbp-0x188], rax
-       mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0xD0]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       test     eax, eax
-       jge      SHORT G_M16487_IG190
-						;; size=29 bbWeight=0.00 PerfScore 0.03
-G_M16487_IG188:
-       mov      rax, gword ptr [rbp-0x188]
-						;; size=7 bbWeight=0.00 PerfScore 0.00
-G_M16487_IG189:
-       mov      rcx, gword ptr [rax+0x10]
-       mov      edx, dword ptr [rbp-0xD0]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      SHORT G_M16487_IG191
-						;; size=23 bbWeight=0 PerfScore 0.00
-G_M16487_IG190:
-       mov      r10d, eax
-						;; size=3 bbWeight=0.00 PerfScore 0.00
-G_M16487_IG191:
-       mov      gword ptr [rbp-0x150], r15
-       mov      r15d, r10d
-						;; size=10 bbWeight=0.03 PerfScore 0.04
-G_M16487_IG192:
-       mov      dword ptr [r14], r15d
-       mov      r15d, dword ptr [rbp-0xC0]
-       mov      r14d, r15d
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=25 bbWeight=0.01 PerfScore 0.04
-G_M16487_IG193:
-       xor      rdx, rdx
-       mov      gword ptr [r13+0x08], rdx
-       mov      rdx, 0xD1FFAB1E      ; const ptr
-       mov      r13, gword ptr [rdx]
-       mov      ebx, dword ptr [rbp+0x40]
-       movzx    r15, byte  ptr [rbp+0x48]
-       jmp      G_M16487_IG142
-						;; size=32 bbWeight=0.01 PerfScore 0.08
-G_M16487_IG194:
-       cmp      r8d, 4
-       jne      SHORT G_M16487_IG197
-						;; size=6 bbWeight=0.00 PerfScore 0.01
+       je       G_M16487_IG203
+						;; size=59 bbWeight=0.03 PerfScore 0.48
 G_M16487_IG195:
+       cmp      r8d, 4
+       je       SHORT G_M16487_IG197
+						;; size=6 bbWeight=0.02 PerfScore 0.02
+G_M16487_IG196:
+       cmp      r8d, 13
+       jne      G_M16487_IG206
+       mov      eax, dword ptr [rax+0x2C]
+       jmp      SHORT G_M16487_IG199
+						;; size=15 bbWeight=0.01 PerfScore 0.05
+G_M16487_IG197:
        mov      rcx, gword ptr [rax+0x08]
        cmp      gword ptr [rcx+0x18], 0
-       jne      G_M16487_IG280
+       jne      G_M16487_IG209
        test     byte  ptr [rcx+0x34], 1
-       je       SHORT G_M16487_IG189
-						;; size=21 bbWeight=0.00 PerfScore 0.02
-G_M16487_IG196:
-       mov      rcx, gword ptr [rax+0x08]
-       mov      edx, dword ptr [rbp-0xD0]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      SHORT G_M16487_IG191
-						;; size=23 bbWeight=0.00 PerfScore 0.03
-G_M16487_IG197:
-       cmp      r8d, 13
-       je       G_M16487_IG314
-						;; size=10 bbWeight=0.00 PerfScore 0.00
+       je       G_M16487_IG207
+						;; size=25 bbWeight=0.01 PerfScore 0.09
 G_M16487_IG198:
-       mov      eax, -1
-       mov      r10d, eax
-       jmp      G_M16487_IG191
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M16487_IG199:
-       mov      rcx, 0xD1FFAB1E      ; System.Func`2[uint,int]
-       call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x190], rax
-       lea      rcx, bword ptr [rax+0x08]
-       mov      rdx, gword ptr [rbp-0x188]
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rcx, 0xD1FFAB1E      ; function address
-       mov      rdx, gword ptr [rbp-0x190]
-       mov      qword ptr [rdx+0x18], rcx
-       mov      rcx, rdx
-       mov      edx, dword ptr [rbp-0xD0]
-       call     [System.Threading.StackHelper:CallOnEmptyStack[uint,int](System.Func`2[uint,int],uint):int]
-       mov      r10d, eax
-       jmp      G_M16487_IG191
-						;; size=82 bbWeight=0 PerfScore 0.00
-G_M16487_IG200:
-       mov      gword ptr [rbp-0x160], rax
-       mov      rcx, gword ptr [r10+0x10]
-       mov      edx, r8d
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
-       mov      r8d, eax
-       mov      rax, gword ptr [rbp-0x160]
-       mov      ecx, dword ptr [rbp-0x110]
-       jmp      G_M16487_IG182
-						;; size=43 bbWeight=0 PerfScore 0.00
-G_M16487_IG201:
-       mov      gword ptr [rbp-0x150], r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      rcx, gword ptr [r15+0x10]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
-       mov      r15d, eax
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r10, gword ptr [rbp-0x150]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG173
-						;; size=48 bbWeight=0 PerfScore 0.00
-G_M16487_IG202:
-       mov      r15, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       mov      ecx, dword ptr [rbp-0x70]
-       mov      dword ptr [rsp+0x20], ecx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0x80]
-       mov      qword ptr [rsp+0x30], rdx
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
-       mov      r9, qword ptr [rbp-0x68]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r14d, eax
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M16487_IG203:
-       mov      r10d, -1
-       jmp      G_M16487_IG125
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG204:
-       mov      rcx, gword ptr [rax+0x10]
-       mov      edx, dword ptr [rbp-0x108]
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      G_M16487_IG125
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M16487_IG205:
-       test     eax, eax
-       mov      rax, gword ptr [rbp-0x1A8]
-       je       SHORT G_M16487_IG204
-       jmp      G_M16487_IG123
-						;; size=16 bbWeight=0 PerfScore 0.00
-G_M16487_IG206:
-       mov      gword ptr [rbp-0x1A8], rax
-       mov      edx, dword ptr [rbp-0x108]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:<IsNullableFor>g__WithCache|26_0(uint):ubyte:this]
-       jmp      SHORT G_M16487_IG205
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16487_IG207:
-       mov      rcx, 0xD1FFAB1E      ; System.Func`2[uint,int]
-       call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x1B0], rax
-       lea      rcx, bword ptr [rax+0x08]
-       mov      rdx, gword ptr [rbp-0x1A8]
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rcx, 0xD1FFAB1E      ; function address
-       mov      rdx, gword ptr [rbp-0x1B0]
-       mov      qword ptr [rdx+0x18], rcx
-       mov      rcx, rdx
-       mov      edx, dword ptr [rbp-0x108]
-       call     [System.Threading.StackHelper:CallOnEmptyStack[uint,int](System.Func`2[uint,int],uint):int]
-       mov      r10d, eax
-       jmp      G_M16487_IG125
-						;; size=82 bbWeight=0 PerfScore 0.00
-G_M16487_IG208:
-       mov      gword ptr [rbp-0x1A0], rax
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
-       mov      rdx, gword ptr [r15+0x98]
-       lea      ecx, [rax+0x01]
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M16487_IG315
-       lea      ecx, [rax+0x01]
-       mov      ecx, dword ptr [rdx+4*rcx+0x10]
-       mov      rax, gword ptr [rbp-0x1A0]
-       jmp      G_M16487_IG119
-						;; size=82 bbWeight=0 PerfScore 0.00
-G_M16487_IG209:
-       mov      r15d, dword ptr [rbp-0x110]
-       cmp      dword ptr [rbp-0xD8], r15d
-       jge      G_M16487_IG117
-       cmp      dword ptr [rbp-0xD8], r14d
-       jge      SHORT G_M16487_IG210
-       mov      r14, gword ptr [r13+0x08]
-       mov      r10d, dword ptr [rbp-0xE8]
-       mov      rax, gword ptr [rbp-0x150]
-       mov      r11, gword ptr [rax+0x10]
-       cmp      r10d, dword ptr [r11+0x08]
-       jae      G_M16487_IG315
-       mov      r8d, r10d
-       mov      r8, gword ptr [r11+8*r8+0x10]
-       mov      gword ptr [rbp-0x150], rax
-       mov      rdx, rax
-       mov      rcx, r14
-       cmp      dword ptr [rcx], ecx
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]:InitializeFrom(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]):this]
-       mov      dword ptr [rbp-0xE8], -1
-       mov      gword ptr [rbp-0xF0], r14
-						;; size=107 bbWeight=0 PerfScore 0.00
-G_M16487_IG210:
-       mov      r14, gword ptr [rbp-0x150]
-       cmp      byte  ptr [r14+0xAC], 0
-       mov      r10, r14
-       je       SHORT G_M16487_IG211
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      rdx, qword ptr [rbp-0x68]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:CheckTimeout(long):this]
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r10, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG113
-						;; size=58 bbWeight=0 PerfScore 0.00
-G_M16487_IG211:
-       mov      eax, dword ptr [rbp-0x110]
-       jmp      G_M16487_IG113
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG212:
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      rdx, [rbp-0xD8]
-       mov      qword ptr [rsp+0x20], rdx
-       lea      rdx, [rbp-0xF0]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0xF8]
-       mov      qword ptr [rsp+0x30], rdx
-       lea      rdx, [rbp-0x100]
-       mov      qword ptr [rsp+0x38], rdx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x40], rdx
-       lea      rdx, [rbp-0xE0]
-       mov      qword ptr [rsp+0x48], rdx
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      r8d, r14d
-       mov      r9d, dword ptr [rbp-0x70]
-       call     [<unknown method>]
-       jmp      G_M16487_IG116
-						;; size=117 bbWeight=0 PerfScore 0.00
-G_M16487_IG213:
-       mov      r8, gword ptr [rbp-0x138]
-       mov      r11d, dword ptr [rbp-0x6C]
-       mov      edx, eax
-       sub      edx, dword ptr [rbp-0xD8]
-       cmp      edx, 0x3E8
-       jle      SHORT G_M16487_IG214
+       mov      rcx, gword ptr [rax+0x08]
+       mov      edx, dword ptr [rbp-0xD8]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+						;; size=18 bbWeight=0.01 PerfScore 0.08
+G_M16487_IG199:
+       mov      gword ptr [rbp-0x160], r15
+						;; size=7 bbWeight=0.11 PerfScore 0.11
+G_M16487_IG200:
+       mov      dword ptr [r14], eax
+       mov      edx, dword ptr [rbp-0xC0]
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=21 bbWeight=0.03 PerfScore 0.14
+G_M16487_IG201:
+       mov      gword ptr [rbp-0x1C8], rax
+       mov      rcx, gword ptr [rax+0x08]
+       mov      edx, dword ptr [rbp-0x10C]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       mov      ecx, eax
+       test     ecx, ecx
+       mov      rax, gword ptr [rbp-0x1C8]
+       jl       G_M16487_IG298
+       jmp      G_M16487_IG128
+						;; size=47 bbWeight=2.43 PerfScore 35.29
+G_M16487_IG202:
+       xor      rcx, rcx
+       mov      gword ptr [r13+0x08], rcx
+       mov      rcx, 0xD1FFAB1E      ; const ptr
+       mov      r13, gword ptr [rcx]
+       mov      r8, gword ptr [rbp-0x148]
+       jmp      G_M16487_IG145
+						;; size=31 bbWeight=0.01 PerfScore 0.06
+G_M16487_IG203:
+       mov      gword ptr [rbp-0x1A0], rax
+       mov      rcx, gword ptr [rax+0x08]
        mov      edx, dword ptr [rbp-0xD8]
-       add      edx, 0x3E8
-       mov      r15d, edx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r14d, r15d
-       jmp      G_M16487_IG115
-						;; size=54 bbWeight=0 PerfScore 0.00
-G_M16487_IG214:
-       mov      dword ptr [rbp-0x6C], r11d
-       jmp      G_M16487_IG114
-						;; size=9 bbWeight=0 PerfScore 0.00
-G_M16487_IG215:
-       mov      gword ptr [rbp-0x198], r15
-       mov      dword ptr [rbp-0x104], edx
-       mov      r15, bword ptr [rbp-0x1E0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      r8d, dword ptr [rbp-0x104]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
-       mov      r15, gword ptr [rbp-0x150]
-       mov      r10, gword ptr [r15+0x98]
-       lea      edx, [rax+0x01]
-       cmp      edx, dword ptr [r10+0x08]
-       jae      G_M16487_IG315
-       lea      edx, [rax+0x01]
-       mov      r9d, dword ptr [r10+4*rdx+0x10]
-       mov      r10, r15
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r15, gword ptr [rbp-0x198]
-       jmp      G_M16487_IG112
-						;; size=120 bbWeight=0 PerfScore 0.00
-G_M16487_IG216:
-       mov      r15, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       mov      ecx, dword ptr [rbp-0x70]
-       mov      dword ptr [rsp+0x20], ecx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0x80]
-       mov      qword ptr [rsp+0x30], rdx
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
-       mov      rcx, r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
-       mov      r9, qword ptr [rbp-0x68]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r14d, eax
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M16487_IG217:
-       mov      r10d, -1
-       jmp      G_M16487_IG23
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG218:
-       mov      rcx, gword ptr [rax+0x10]
-       mov      edx, dword ptr [rbp-0x108]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
-       mov      r10d, eax
-       jmp      G_M16487_IG23
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M16487_IG219:
        test     eax, eax
-       mov      rax, gword ptr [rbp-0x1A8]
-       je       SHORT G_M16487_IG218
-       jmp      G_M16487_IG101
+       jl       SHORT G_M16487_IG204
+       jmp      G_M16487_IG199
+						;; size=34 bbWeight=0.01 PerfScore 0.13
+G_M16487_IG204:
+       mov      rax, gword ptr [rbp-0x1A0]
+       jmp      SHORT G_M16487_IG207
+						;; size=9 bbWeight=0.00 PerfScore 0.01
+G_M16487_IG205:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M16487_IG206:
+       mov      eax, -1
+       jmp      G_M16487_IG199
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M16487_IG207:
+       mov      rcx, gword ptr [rax+0x10]
+       mov      edx, dword ptr [rbp-0xD8]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       jmp      G_M16487_IG199
+						;; size=23 bbWeight=0 PerfScore 0.00
+G_M16487_IG208:
+       test     eax, eax
+       mov      rax, gword ptr [rbp-0x1A0]
+       je       SHORT G_M16487_IG207
+       jmp      G_M16487_IG198
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M16487_IG220:
-       mov      gword ptr [rbp-0x1A8], rax
-       mov      edx, dword ptr [rbp-0x108]
+G_M16487_IG209:
+       mov      gword ptr [rbp-0x1A0], rax
+       mov      edx, dword ptr [rbp-0xD8]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:<IsNullableFor>g__WithCache|26_0(uint):ubyte:this]
-       jmp      SHORT G_M16487_IG219
+       jmp      SHORT G_M16487_IG208
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16487_IG221:
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      dword ptr [rbp-0x114], r9d
+G_M16487_IG210:
+       mov      rcx, 0xD1FFAB1E      ; System.Func`2[uint,int]
+       call     CORINFO_HELP_NEWSFAST
+       mov      gword ptr [rbp-0x1A8], rax
+       lea      rcx, bword ptr [rax+0x08]
+       mov      rdx, gword ptr [rbp-0x1A0]
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, 0xD1FFAB1E      ; function address
+       mov      rdx, gword ptr [rbp-0x1A8]
+       mov      qword ptr [rdx+0x18], rcx
+       mov      rcx, rdx
+       mov      edx, dword ptr [rbp-0xD8]
+       call     [System.Threading.StackHelper:CallOnEmptyStack[uint,int](System.Func`2[uint,int],uint):int]
+       jmp      G_M16487_IG199
+						;; size=79 bbWeight=0 PerfScore 0.00
+G_M16487_IG211:
+       mov      gword ptr [rbp-0x178], rax
+       mov      rcx, gword ptr [r8+0x10]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
+       mov      edx, eax
+       mov      rax, gword ptr [rbp-0x178]
+       mov      ecx, dword ptr [rbp-0x118]
+       jmp      G_M16487_IG190
+						;; size=39 bbWeight=0 PerfScore 0.00
+G_M16487_IG212:
+       mov      gword ptr [rbp-0x160], r10
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rbp-0x6C], edx
+       mov      dword ptr [rbp-0xCC], ecx
+       mov      r14, bword ptr [rbp+0x30]
+       mov      rcx, gword ptr [r11+0x10]
+       mov      edx, dword ptr [rbp-0xCC]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.BDD:Find(int):int:this]
+       mov      ecx, eax
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x118]
+       mov      edx, dword ptr [rbp-0x6C]
+       mov      r9d, dword ptr [rbp-0x70]
+       mov      r10, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG180
+						;; size=73 bbWeight=0 PerfScore 0.00
+G_M16487_IG213:
+       mov      r14, bword ptr [rbp+0x30]
+       xor      rcx, rcx
+       mov      gword ptr [r8+0x28], rcx
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG44
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M16487_IG214:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      ecx, -1
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG25
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M16487_IG215:
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r14, bword ptr [rbp+0x30]
        call     <unknown method>
-       mov      r10, gword ptr [rbp-0x150]
+       mov      r10, gword ptr [rbp-0x160]
        movsxd   rdx, dword ptr [r10+0xA0]
        add      rdx, rax
        mov      rax, rdx
+       mov      bword ptr [rbp+0x30], r14
        mov      qword ptr [rbp-0x68], rax
        mov      rcx, r10
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r9d, dword ptr [rbp-0x114]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG11
-						;; size=72 bbWeight=0 PerfScore 0.00
-G_M16487_IG222:
+       mov      r10d, dword ptr [rbp-0x6C]
+       jmp      G_M16487_IG12
+						;; size=60 bbWeight=0 PerfScore 0.00
+G_M16487_IG216:
+       mov      r14, bword ptr [rbp+0x30]
        mov      eax, -1
-       mov      r10d, eax
-       jmp      G_M16487_IG93
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M16487_IG223:
-       mov      r10, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r10
-       mov      dword ptr [rbp-0x120], r9d
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG99
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M16487_IG217:
+       mov      r9, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r9
+       mov      r9d, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x130], r9d
        mov      edx, dword ptr [rbp-0x70]
        mov      dword ptr [rsp+0x20], edx
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x80]
        mov      qword ptr [rsp+0x30], r9
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
-       mov      r9, qword ptr [rbp-0x68]
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x38], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r8d, r10d
+       mov      r9, rax
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=94 bbWeight=0 PerfScore 0.00
-G_M16487_IG224:
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, eax
+       jmp      G_M16487_IG26
+						;; size=107 bbWeight=0 PerfScore 0.00
+G_M16487_IG218:
+       mov      rax, gword ptr [rbp-0x148]
+       mov      r14, bword ptr [rbp+0x30]
        xor      rcx, rcx
-       mov      gword ptr [r11+0x18], rcx
+       mov      gword ptr [r10+0x18], rcx
+       mov      bword ptr [rbp+0x30], r14
        jmp      G_M16487_IG09
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG225:
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M16487_IG219:
+       mov      r14, bword ptr [rbp+0x30]
        mov      rcx, gword ptr [r8+0x30]
        cmp      gword ptr [rcx+0x18], 0
-       je       SHORT G_M16487_IG226
+       je       SHORT G_M16487_IG220
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      rdx, gword ptr [r8+0x30]
        mov      r9, gword ptr [r8+0x30]
        mov      rax, gword ptr [r9+0x18]
-       mov      gword ptr [rbp-0x148], rax
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rsp+0x20], r10d
+       mov      gword ptr [rbp-0x158], rax
+       mov      dword ptr [rsp+0x20], r15d
        mov      r9, gword ptr [r8+0x30]
        mov      r8d, dword ptr [r9+0x44]
-       mov      r11, gword ptr [rbp-0x138]
-       mov      r9, gword ptr [r11+0x08]
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
-       lea      rcx, bword ptr [rbx+0x68]
-       mov      rdx, gword ptr [rbp-0x148]
-       call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M16487_IG227
-						;; size=113 bbWeight=0 PerfScore 0.00
-G_M16487_IG226:
-       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
-       call     CORINFO_HELP_NEWSFAST
-       mov      rbx, rax
-       mov      eax, dword ptr [rbp-0x110]
-       mov      dword ptr [rsp+0x20], eax
-       mov      r8, gword ptr [rbp-0x138]
-       mov      rdx, gword ptr [r8+0x30]
-       mov      r8d, dword ptr [rdx+0x44]
-       mov      r10, gword ptr [rbp-0x138]
-       mov      rdx, gword ptr [r10+0x30]
+       mov      r10, gword ptr [rbp-0x148]
        mov      r9, gword ptr [r10+0x08]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
-						;; size=67 bbWeight=0 PerfScore 0.00
-G_M16487_IG227:
-       mov      r10, gword ptr [rbp-0x138]
-       lea      rcx, bword ptr [r10+0x28]
+       lea      rcx, bword ptr [rbx+0x68]
+       mov      rdx, gword ptr [rbp-0x158]
+       call     CORINFO_HELP_ASSIGN_REF
+       jmp      SHORT G_M16487_IG221
+						;; size=110 bbWeight=0 PerfScore 0.00
+G_M16487_IG220:
+       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
+       call     CORINFO_HELP_NEWSFAST
+       mov      rbx, rax
+       mov      dword ptr [rsp+0x20], r15d
+       mov      r8, gword ptr [rbp-0x148]
+       mov      rdx, gword ptr [r8+0x30]
+       mov      r8d, dword ptr [rdx+0x44]
+       mov      rax, gword ptr [rbp-0x148]
+       mov      rdx, gword ptr [rax+0x30]
+       mov      r9, gword ptr [rax+0x08]
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
+						;; size=62 bbWeight=0 PerfScore 0.00
+G_M16487_IG221:
+       mov      rax, gword ptr [rbp-0x148]
+       lea      rcx, bword ptr [rax+0x28]
        mov      rdx, rbx
        call     CORINFO_HELP_ASSIGN_REF
-       mov      eax, dword ptr [rbp-0x110]
-       jmp      G_M16487_IG09
-						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG228:
+       mov      rax, gword ptr [rbp-0x148]
+       mov      r11, gword ptr [rax+0x20]
+       test     r11, r11
+       mov      r8, rax
+       jne      G_M16487_IG225
+						;; size=42 bbWeight=0 PerfScore 0.00
+G_M16487_IG222:
        mov      rcx, r8
-       mov      rdx, qword ptr [r8]
-       mov      rdx, qword ptr [rdx+0x40]
-       call     [rdx+0x38]<unknown method>
-       mov      r8, gword ptr [rbp-0x138]
+       mov      rax, qword ptr [r8]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x38]<unknown method>
+       mov      r8, gword ptr [rbp-0x148]
        mov      ebx, dword ptr [r8+0x5C]
        shl      ebx, 3
        mov      eax, ebx
        cmp      eax, 32
-       jge      SHORT G_M16487_IG229
+       jge      SHORT G_M16487_IG223
        mov      eax, 32
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M16487_IG229:
+G_M16487_IG223:
        cmp      ebx, 16
-       jge      SHORT G_M16487_IG230
+       jge      SHORT G_M16487_IG224
        mov      ebx, 16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG230:
+G_M16487_IG224:
        mov      dword ptr [rbp-0x40], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r8+0x10]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      eax, dword ptr [rbp-0x40]
        mov      dword ptr [r8+0x50], eax
        movsxd   rdx, ebx
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r8+0x18]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      dword ptr [r8+0x54], ebx
        mov      rcx, 0xD1FFAB1E      ; int[]
        mov      edx, 32
        call     CORINFO_HELP_NEWARR_1_VC
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r8+0x20]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      dword ptr [r8+0x58], 32
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r8, gword ptr [rbp-0x138]
+       mov      bword ptr [rbp+0x30], r14
+       mov      r8, gword ptr [rbp-0x148]
+       jmp      G_M16487_IG11
+						;; size=172 bbWeight=0 PerfScore 0.00
+G_M16487_IG225:
+       mov      bword ptr [rbp+0x30], r14
        jmp      G_M16487_IG10
-						;; size=174 bbWeight=0 PerfScore 0.00
-G_M16487_IG231:
-       test     r10d, r10d
-       jne      G_M16487_IG223
-       mov      r10, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r10
-       mov      dword ptr [rbp-0x120], r9d
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG226:
+       mov      rax, qword ptr [rbp-0x68]
+       mov      r14, bword ptr [rbp+0x30]
+       test     r9d, r9d
+       jne      G_M16487_IG217
+       mov      r9, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r9
+       mov      r9d, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x130], r9d
        mov      edx, dword ptr [rbp-0x70]
        mov      dword ptr [rsp+0x20], edx
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x80]
        mov      qword ptr [rsp+0x30], r9
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
-       mov      r9, qword ptr [rbp-0x68]
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x38], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r8d, r10d
+       mov      r9, rax
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=103 bbWeight=0 PerfScore 0.00
-G_M16487_IG232:
-       mov      r10, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r10
-       mov      dword ptr [rbp-0x120], r9d
+       mov      edx, eax
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, edx
+       jmp      G_M16487_IG26
+						;; size=126 bbWeight=0 PerfScore 0.00
+G_M16487_IG227:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r9, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r9
+       mov      eax, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x130], eax
        mov      edx, dword ptr [rbp-0x70]
        mov      dword ptr [rsp+0x20], edx
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x80]
        mov      qword ptr [rsp+0x30], r9
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x38], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r8d, r10d
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=94 bbWeight=0 PerfScore 0.00
-G_M16487_IG233:
-       mov      gword ptr [rbp-0x198], r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r15, bword ptr [rbp-0x1E0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      r8d, r14d
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, eax
+       jmp      G_M16487_IG26
+						;; size=110 bbWeight=0 PerfScore 0.00
+G_M16487_IG228:
+       mov      gword ptr [rbp-0x1B0], rax
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r13, bword ptr [rbp-0x218]
+       mov      bword ptr [rbp-0x138], r13
+       mov      r13d, dword ptr [rbp-0x124]
+       mov      dword ptr [rbp-0x130], r13d
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      r8d, r9d
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
-       mov      r15, gword ptr [rbp-0x150]
-       mov      r10, gword ptr [r15+0x98]
+       mov      r13, gword ptr [rbp-0x160]
+       mov      r10, gword ptr [r13+0x98]
        lea      edx, [rax+0x01]
        cmp      edx, dword ptr [r10+0x08]
-       jae      G_M16487_IG315
+       jae      G_M16487_IG205
        inc      eax
        mov      edx, eax
-       mov      r9d, dword ptr [r10+4*rdx+0x10]
-       mov      rcx, r15
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r10, gword ptr [rbp-0x198]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG13
-						;; size=116 bbWeight=0 PerfScore 0.00
-G_M16487_IG234:
-       mov      r9d, eax
-       sub      r9d, dword ptr [rbp-0xD8]
+       mov      ecx, dword ptr [r10+4*rdx+0x10]
+       mov      bword ptr [rbp+0x30], r14
+       mov      r9d, ecx
+       mov      rcx, r13
+       mov      rax, gword ptr [rbp-0x1B0]
+       mov      r10d, dword ptr [rbp-0x6C]
+       jmp      G_M16487_IG15
+						;; size=128 bbWeight=0 PerfScore 0.00
+G_M16487_IG229:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r9d, r15d
+       sub      r9d, dword ptr [rbp-0xE0]
        cmp      r9d, 0x3E8
-       jle      G_M16487_IG15
-       mov      r14d, dword ptr [rbp-0xD8]
-       add      r14d, 0x3E8
-       jmp      G_M16487_IG16
-						;; size=42 bbWeight=0 PerfScore 0.00
-G_M16487_IG235:
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      r9, [rbp-0xD8]
+       jle      G_M16487_IG232
+       mov      r9d, dword ptr [rbp-0xE0]
+       add      r9d, 0x3E8
+       mov      r13d, r9d
+       cmp      gword ptr [rbp-0xF8], 0
+       mov      dword ptr [rbp-0x6C], r10d
+       je       SHORT G_M16487_IG231
+						;; size=58 bbWeight=0 PerfScore 0.00
+G_M16487_IG230:
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       lea      r9, [rbp-0xE0]
        mov      qword ptr [rsp+0x20], r9
-       lea      r9, [rbp-0xF0]
-       mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0xF8]
-       mov      qword ptr [rsp+0x30], r9
+       mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x100]
+       mov      qword ptr [rsp+0x30], r9
+       lea      r9, [rbp-0x108]
        mov      qword ptr [rsp+0x38], r9
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x40], r9
-       lea      r9, [rbp-0xE0]
+       lea      r9, [rbp-0xE8]
        mov      qword ptr [rsp+0x48], r9
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      r8d, r14d
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      r8d, r13d
        mov      r9d, dword ptr [rbp-0x70]
        call     [<unknown method>]
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG19
+						;; size=119 bbWeight=0 PerfScore 0.00
+G_M16487_IG231:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG18
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG232:
+       mov      bword ptr [rbp+0x30], r14
        jmp      G_M16487_IG17
-						;; size=118 bbWeight=0 PerfScore 0.00
-G_M16487_IG236:
-       mov      r15d, dword ptr [rbp-0x110]
-       cmp      dword ptr [rbp-0xD8], r15d
-       jge      G_M16487_IG18
-       cmp      dword ptr [rbp-0xD8], r14d
-       jge      SHORT G_M16487_IG237
-       mov      r14, gword ptr [r13+0x08]
-       mov      r10d, dword ptr [rbp-0xE8]
-       mov      r9, gword ptr [rbp-0x150]
-       mov      r11, gword ptr [r9+0x10]
-       cmp      r10d, dword ptr [r11+0x08]
-       jae      G_M16487_IG315
-       mov      r8d, r10d
-       mov      r8, gword ptr [r11+8*r8+0x10]
-       mov      gword ptr [rbp-0x150], r9
-       mov      rdx, r9
-       mov      rcx, r14
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG233:
+       mov      r14, bword ptr [rbp+0x30]
+       cmp      dword ptr [rbp-0xE0], r15d
+       jge      G_M16487_IG236
+       cmp      dword ptr [rbp-0xE0], r13d
+       jge      SHORT G_M16487_IG234
+       mov      r13, gword ptr [rbp-0x168]
+       mov      r10, gword ptr [r13+0x08]
+       mov      r9d, dword ptr [rbp-0xF0]
+       mov      r11, gword ptr [rbp-0x160]
+       mov      rcx, gword ptr [r11+0x10]
+       cmp      r9d, dword ptr [rcx+0x08]
+       jae      G_M16487_IG205
+       mov      r8d, r9d
+       mov      r8, gword ptr [rcx+8*r8+0x10]
+       mov      gword ptr [rbp-0x160], r11
+       mov      rdx, r11
+       mov      gword ptr [rbp-0x1C0], r10
+       mov      rcx, r10
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]:InitializeFrom(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]):this]
-       mov      dword ptr [rbp-0xE8], -1
-       mov      gword ptr [rbp-0xF0], r14
-						;; size=107 bbWeight=0 PerfScore 0.00
-G_M16487_IG237:
-       mov      r14, gword ptr [rbp-0x150]
-       cmp      byte  ptr [r14+0xAC], 0
-       mov      rcx, r14
-       je       SHORT G_M16487_IG238
-       mov      gword ptr [rbp-0x150], rcx
+       mov      dword ptr [rbp-0xF0], -1
+       mov      rax, gword ptr [rbp-0x1C0]
+       mov      gword ptr [rbp-0xF8], rax
+						;; size=125 bbWeight=0 PerfScore 0.00
+G_M16487_IG234:
+       mov      r8, gword ptr [rbp-0x160]
+       cmp      byte  ptr [r8+0xAC], 0
+       mov      rcx, r8
+       je       SHORT G_M16487_IG235
+       mov      gword ptr [rbp-0x160], rcx
        mov      rdx, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:CheckTimeout(long):this]
-       mov      eax, dword ptr [rbp-0x110]
-       mov      rcx, gword ptr [rbp-0x150]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG14
-						;; size=59 bbWeight=0 PerfScore 0.00
-G_M16487_IG238:
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG14
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M16487_IG239:
+       mov      bword ptr [rbp+0x30], r14
+       mov      rcx, gword ptr [rbp-0x160]
+       mov      r10d, dword ptr [rbp-0x6C]
+       jmp      G_M16487_IG16
+						;; size=57 bbWeight=0 PerfScore 0.00
+G_M16487_IG235:
+       mov      bword ptr [rbp+0x30], r14
+       mov      r10d, dword ptr [rbp-0x6C]
+       jmp      G_M16487_IG16
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M16487_IG236:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG20
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG237:
+       mov      r14, bword ptr [rbp+0x30]
        mov      rcx, 0xD1FFAB1E      ; System.Func`2[uint,int]
        call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x1B0], rax
+       mov      gword ptr [rbp-0x1D0], rax
        lea      rcx, bword ptr [rax+0x08]
-       mov      rdx, gword ptr [rbp-0x1A8]
+       mov      rdx, gword ptr [rbp-0x1C8]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this
-       mov      rax, gword ptr [rbp-0x1B0]
+       mov      rax, gword ptr [rbp-0x1D0]
        mov      qword ptr [rax+0x18], rcx
        mov      rcx, rax
-       mov      edx, dword ptr [rbp-0x108]
+       mov      edx, dword ptr [rbp-0x10C]
        call     [System.Threading.StackHelper:CallOnEmptyStack[uint,int](System.Func`2[uint,int],uint):int]
-       mov      r10d, eax
-       jmp      G_M16487_IG23
-						;; size=82 bbWeight=0 PerfScore 0.00
+       mov      ecx, eax
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG25
+						;; size=89 bbWeight=0 PerfScore 0.00
+G_M16487_IG238:
+       mov      gword ptr [rbp-0x1C8], rax
+       mov      r14, bword ptr [rbp+0x30]
+       mov      edx, dword ptr [rbp-0x10C]
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:<IsNullableFor>g__WithCache|26_0(uint):ubyte:this]
+       test     eax, eax
+       mov      rax, gword ptr [rbp-0x1C8]
+       jne      SHORT G_M16487_IG240
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M16487_IG239:
+       mov      rcx, gword ptr [rax+0x10]
+       mov      edx, dword ptr [rbp-0x10C]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       mov      ecx, eax
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG25
+						;; size=29 bbWeight=0 PerfScore 0.00
 G_M16487_IG240:
-       mov      r10, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r10
-       mov      dword ptr [rbp-0x120], r9d
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG103
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG241:
+       mov      rax, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], rax
+       mov      r9d, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x130], r9d
        mov      edx, dword ptr [rbp-0x70]
        mov      dword ptr [rsp+0x20], edx
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x80]
        mov      qword ptr [rsp+0x30], r9
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x38], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r8d, r10d
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=94 bbWeight=0 PerfScore 0.00
-G_M16487_IG241:
-       mov      r10, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r10
-       mov      dword ptr [rbp-0x120], r9d
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, eax
+       jmp      G_M16487_IG26
+						;; size=108 bbWeight=0 PerfScore 0.00
+G_M16487_IG242:
+       mov      r9, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r9
+       mov      eax, dword ptr [rbp-0x11C]
+       mov      dword ptr [rbp-0x130], eax
        mov      edx, dword ptr [rbp-0x70]
        mov      dword ptr [rsp+0x20], edx
        lea      r9, [rbp-0x78]
        mov      qword ptr [rsp+0x28], r9
        lea      r9, [rbp-0x80]
        mov      qword ptr [rsp+0x30], r9
-       mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], rcx
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x38], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], rcx
+       mov      dword ptr [rbp-0x6C], r10d
+       mov      r8d, r10d
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG24
-						;; size=94 bbWeight=0 PerfScore 0.00
-G_M16487_IG242:
-       lea      rcx, [rbp-0x60]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicMatch:get_MatchExists():System.Text.RegularExpressions.Symbolic.SymbolicMatch]
-       jmp      G_M16487_IG29
-						;; size=15 bbWeight=0 PerfScore 0.00
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, eax
+       jmp      G_M16487_IG26
+						;; size=106 bbWeight=0 PerfScore 0.00
 G_M16487_IG243:
-       mov      r9d, dword ptr [rbp-0x6C]
-       cmp      r14d, r9d
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r8d, dword ptr [rbp-0x6C]
+       cmp      r13d, r8d
        jge      SHORT G_M16487_IG244
        jmp      G_M16487_IG251
-						;; size=14 bbWeight=0 PerfScore 0.00
+						;; size=18 bbWeight=0 PerfScore 0.00
 G_M16487_IG244:
-       mov      rdx, gword ptr [r15+0x60]
+       mov      r10, gword ptr [rbp-0x160]
+       mov      rdx, gword ptr [r10+0x60]
        mov      edx, dword ptr [rdx+0x34]
-       mov      rdx, gword ptr [r15+0x60]
-       xor      r10d, r10d
+       mov      rdx, gword ptr [r10+0x60]
+       xor      r11d, r11d
        test     byte  ptr [rdx+0x34], 16
-       setne    r10b
-       mov      rdx, gword ptr [r15+0x60]
+       setne    r11b
+       mov      rdx, gword ptr [r10+0x60]
        test     dword ptr [rdx+0x34], 256
        je       SHORT G_M16487_IG245
-       test     r10d, r10d
+       test     r11d, r11d
        jne      SHORT G_M16487_IG246
        jmp      SHORT G_M16487_IG247
-						;; size=42 bbWeight=0 PerfScore 0.00
+						;; size=49 bbWeight=0 PerfScore 0.00
 G_M16487_IG245:
-       test     r10d, r10d
-       jne      SHORT G_M16487_IG248
+       test     r11d, r11d
+       jne      G_M16487_IG248
        jmp      G_M16487_IG249
-						;; size=10 bbWeight=0 PerfScore 0.00
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M16487_IG246:
-       mov      dword ptr [rbp-0x70], r8d
-       mov      bword ptr [rbp-0x128], r12
-       mov      r11d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r11d
-       mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       mov      dword ptr [rbp-0x70], eax
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       mov      r9, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x20], r9
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r13d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
        jmp      G_M16487_IG250
-						;; size=58 bbWeight=0 PerfScore 0.00
+						;; size=64 bbWeight=0 PerfScore 0.00
 G_M16487_IG247:
-       mov      dword ptr [rbp-0x70], r8d
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       mov      dword ptr [rbp-0x70], eax
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x20], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r13d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
        jmp      SHORT G_M16487_IG250
-						;; size=55 bbWeight=0 PerfScore 0.00
+						;; size=61 bbWeight=0 PerfScore 0.00
 G_M16487_IG248:
-       mov      dword ptr [rbp-0x70], r8d
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       mov      dword ptr [rbp-0x70], eax
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x20], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r13d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
        jmp      SHORT G_M16487_IG250
-						;; size=55 bbWeight=0 PerfScore 0.00
+						;; size=61 bbWeight=0 PerfScore 0.00
 G_M16487_IG249:
-       mov      dword ptr [rbp-0x70], r8d
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       mov      dword ptr [rbp-0x70], eax
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x20], r11
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r13d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-						;; size=53 bbWeight=0 PerfScore 0.00
-G_M16487_IG250:
-       mov      r9d, eax
-       mov      r8d, dword ptr [rbp-0x70]
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M16487_IG251:
-       mov      r10d, r9d
-       mov      r9d, r10d
-       jmp      G_M16487_IG26
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG252:
-       cmp      r8d, 2
-       jl       G_M16487_IG27
-       mov      r8, gword ptr [r15+0x60]
-       test     dword ptr [r8+0x34], 256
-       jne      SHORT G_M16487_IG253
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       mov      dword ptr [rsp+0x20], r14d
-       mov      gword ptr [rsp+0x28], r13
-       lea      r8, [rbp-0x128]
-       lea      rdx, [rbp-0x98]
-       mov      rcx, r15
-       mov      dword ptr [rbp-0x84], r9d
-       call     [<unknown method>]
-       jmp      SHORT G_M16487_IG254
-						;; size=87 bbWeight=0 PerfScore 0.00
-G_M16487_IG253:
-       mov      bword ptr [rbp-0x128], r12
-       mov      eax, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], eax
-       mov      dword ptr [rsp+0x20], r14d
-       mov      gword ptr [rsp+0x28], r13
-       lea      r8, [rbp-0x128]
-       lea      rdx, [rbp-0x98]
-       mov      rcx, r15
-       mov      dword ptr [rbp-0x84], r9d
-       call     [<unknown method>]
 						;; size=59 bbWeight=0 PerfScore 0.00
+G_M16487_IG250:
+       mov      r8d, eax
+       mov      eax, dword ptr [rbp-0x70]
+						;; size=6 bbWeight=0 PerfScore 0.00
+G_M16487_IG251:
+       mov      dword ptr [rbp-0x84], r8d
+       mov      bword ptr [rbp+0x30], r14
+       mov      r8d, dword ptr [rbp-0x84]
+       jmp      G_M16487_IG28
+						;; size=23 bbWeight=0 PerfScore 0.00
+G_M16487_IG252:
+       mov      r14, bword ptr [rbp+0x30]
+       cmp      eax, 2
+       jl       SHORT G_M16487_IG253
+       mov      rdx, gword ptr [r10+0x60]
+       test     dword ptr [rdx+0x34], 256
+       jne      SHORT G_M16487_IG254
+       mov      dword ptr [rbp-0x84], r8d
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       mov      dword ptr [rsp+0x20], r13d
+       mov      r11, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x28], r11
+       lea      r8, [rbp-0x138]
+       lea      rdx, [rbp-0x98]
+       mov      rcx, r10
+       mov      r9d, dword ptr [rbp-0x84]
+       call     [<unknown method>]
+       jmp      SHORT G_M16487_IG255
+						;; size=92 bbWeight=0 PerfScore 0.00
+G_M16487_IG253:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG29
+						;; size=9 bbWeight=0 PerfScore 0.00
 G_M16487_IG254:
+       mov      dword ptr [rbp-0x84], r8d
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], r15d
+       mov      dword ptr [rsp+0x20], r13d
+       mov      rax, gword ptr [rbp-0x168]
+       mov      gword ptr [rsp+0x28], rax
+       lea      r8, [rbp-0x138]
+       lea      rdx, [rbp-0x98]
+       mov      rcx, r10
+       mov      r9d, dword ptr [rbp-0x84]
+       call     [<unknown method>]
+						;; size=68 bbWeight=0 PerfScore 0.00
+G_M16487_IG255:
        mov      rax, gword ptr [rbp-0x98]
        mov      r10, gword ptr [rbp-0x90]
-       mov      r13d, dword ptr [rbp-0x84]
-       mov      r11d, r13d
-       mov      ecx, r14d
-       sub      ecx, r11d
+       mov      r11d, dword ptr [rbp-0x84]
+       mov      ecx, r11d
+       mov      edx, r13d
+       sub      edx, ecx
        mov      gword ptr [rbp-0x60], rax
        mov      gword ptr [rbp-0x58], r10
-       mov      dword ptr [rbp-0x50], r11d
-       mov      dword ptr [rbp-0x4C], ecx
-       jmp      G_M16487_IG29
-						;; size=50 bbWeight=0 PerfScore 0.00
-G_M16487_IG255:
-       test     r14, r14
-       je       G_M16487_IG31
-       xor      r13d, r13d
-       jmp      SHORT G_M16487_IG258
-						;; size=14 bbWeight=0 PerfScore 0.00
+       mov      dword ptr [rbp-0x50], ecx
+       mov      dword ptr [rbp-0x4C], edx
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG31
+						;; size=52 bbWeight=0 PerfScore 0.00
 G_M16487_IG256:
-       cmp      r13d, dword ptr [r14+0x08]
-       jae      G_M16487_IG315
-       mov      r8d, r13d
-       cmp      dword ptr [r14+4*r8+0x10], 0
-       jl       SHORT G_M16487_IG257
-       mov      dword ptr [rbp-0x44], ecx
-       cmp      r13d, dword ptr [r14+0x08]
-       jae      G_M16487_IG315
-       mov      r8d, r13d
-       mov      r8d, dword ptr [r14+4*r8+0x10]
-       cmp      r13d, dword ptr [r15+0x08]
-       jae      G_M16487_IG315
-       mov      r9d, r13d
-       mov      r9d, dword ptr [r15+4*r9+0x10]
-       mov      edx, r13d
+       mov      r14, bword ptr [rbp+0x30]
+       test     r13, r13
+       je       SHORT G_M16487_IG257
+       xor      eax, eax
+       jmp      SHORT G_M16487_IG260
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M16487_IG257:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG33
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG258:
+       cmp      eax, dword ptr [r13+0x08]
+       jae      G_M16487_IG205
+       mov      r8d, eax
+       cmp      dword ptr [r13+4*r8+0x10], 0
+       jl       SHORT G_M16487_IG259
+       mov      dword ptr [rbp-0x44], edx
+       cmp      eax, dword ptr [r13+0x08]
+       jae      G_M16487_IG205
+       mov      r8d, eax
+       mov      r8d, dword ptr [r13+4*r8+0x10]
+       cmp      eax, dword ptr [r9+0x08]
+       jae      G_M16487_IG205
+       mov      ecx, eax
+       mov      gword ptr [rbp-0x200], r9
+       mov      r9d, dword ptr [r9+4*rcx+0x10]
+       mov      dword ptr [rbp-0x48], eax
+       mov      edx, eax
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Capture(int,int,int):this]
-       mov      ecx, dword ptr [rbp-0x44]
-						;; size=75 bbWeight=0 PerfScore 0.00
-G_M16487_IG257:
-       inc      r13d
-						;; size=3 bbWeight=0 PerfScore 0.00
-G_M16487_IG258:
-       cmp      dword ptr [r14+0x08], r13d
-       jg       SHORT G_M16487_IG256
-       jmp      G_M16487_IG36
-						;; size=11 bbWeight=0 PerfScore 0.00
+       mov      eax, dword ptr [rbp-0x48]
+       mov      edx, dword ptr [rbp-0x44]
+       mov      r9, gword ptr [rbp-0x200]
+						;; size=93 bbWeight=0 PerfScore 0.00
 G_M16487_IG259:
-       mov      r14d, r13d
-       mov      dword ptr [rbp-0x44], ecx
-       mov      r15d, ecx
-       mov      ecx, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG32
-						;; size=17 bbWeight=0 PerfScore 0.00
+       inc      eax
+						;; size=2 bbWeight=0 PerfScore 0.00
 G_M16487_IG260:
-       mov      dword ptr [rbp-0x44], ecx
+       cmp      dword ptr [r13+0x08], eax
+       jg       SHORT G_M16487_IG258
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG38
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M16487_IG261:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      dword ptr [rbp-0x110], ecx
+       mov      dword ptr [rbp-0x44], edx
+       mov      r8d, edx
+       mov      bword ptr [rbp+0x30], r14
+       mov      r13d, r8d
+       mov      eax, dword ptr [rbp-0x110]
+       mov      edx, dword ptr [rbp-0x44]
+       jmp      G_M16487_IG34
+						;; size=37 bbWeight=0 PerfScore 0.00
+G_M16487_IG262:
+       mov      dword ptr [rbp-0x110], eax
+       mov      dword ptr [rbp-0x44], edx
+       mov      r14, bword ptr [rbp+0x30]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleCrawl():this]
-       mov      ecx, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG33
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M16487_IG261:
-       mov      dword ptr [rbp-0x44], ecx
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x110]
+       mov      edx, dword ptr [rbp-0x44]
+       jmp      G_M16487_IG35
+						;; size=40 bbWeight=0 PerfScore 0.00
+G_M16487_IG263:
+       mov      gword ptr [rbp-0x1D8], r10
+       mov      dword ptr [rbp-0x110], eax
+       mov      dword ptr [rbp-0x44], edx
+       mov      r14, bword ptr [rbp+0x30]
        mov      rcx, 0xD1FFAB1E      ; int[]
        mov      edx, 2
        call     CORINFO_HELP_NEWARR_1_VC
        mov      r8, rax
-       mov      rcx, gword ptr [rbp-0x1B8]
+       mov      rcx, gword ptr [rbp-0x1E0]
        xor      edx, edx
        call     [CORINFO_HELP_ARRADDR_ST]
-       mov      ecx, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG34
-						;; size=49 bbWeight=0 PerfScore 0.00
-G_M16487_IG262:
-       mov      dword ptr [rbp-0x44], ecx
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x110]
+       mov      edx, dword ptr [rbp-0x44]
+       mov      r10, gword ptr [rbp-0x1D8]
+       jmp      G_M16487_IG36
+						;; size=83 bbWeight=0 PerfScore 0.00
+G_M16487_IG264:
+       mov      dword ptr [rbp-0x110], eax
+       mov      gword ptr [rbp-0x1F0], r10
+       mov      dword ptr [rbp-0x44], edx
+       mov      r14, bword ptr [rbp+0x30]
        cmp      dword ptr [r8+0x08], 0
-       jbe      G_M16487_IG315
-       mov      gword ptr [rbp-0x1C0], r8
-       mov      rax, gword ptr [r8+0x10]
-       mov      gword ptr [rbp-0x1C8], rax
-       mov      dword ptr [rbp-0x10C], edx
-       lea      r9d, [8*rdx]
+       jbe      G_M16487_IG205
+       mov      gword ptr [rbp-0x1E8], r8
+       mov      r9, gword ptr [r8+0x10]
+       mov      gword ptr [rbp-0x1F8], r9
+       mov      dword ptr [rbp-0x114], ecx
+       lea      r9d, [8*rcx]
        movsxd   rdx, r9d
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
        xor      ecx, ecx
-       jmp      SHORT G_M16487_IG264
-						;; size=68 bbWeight=0 PerfScore 0.00
-G_M16487_IG263:
-       mov      r9, gword ptr [rbp-0x1C8]
+       jmp      SHORT G_M16487_IG266
+						;; size=85 bbWeight=0 PerfScore 0.00
+G_M16487_IG265:
+       mov      r9, gword ptr [rbp-0x1F8]
        cmp      ecx, dword ptr [r9+0x08]
-       jae      G_M16487_IG315
+       jae      G_M16487_IG205
        mov      r8d, ecx
        mov      r11d, dword ptr [r9+4*r8+0x10]
        cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M16487_IG315
+       jae      G_M16487_IG205
        mov      r8d, ecx
        mov      dword ptr [rax+4*r8+0x10], r11d
        inc      ecx
-       mov      gword ptr [rbp-0x1C8], r9
+       mov      gword ptr [rbp-0x1F8], r9
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M16487_IG264:
-       mov      r10d, dword ptr [rbp-0x130]
+G_M16487_IG266:
+       mov      r10d, dword ptr [rbp-0x140]
        cmp      ecx, r10d
-       jl       SHORT G_M16487_IG263
-       mov      rcx, gword ptr [rbp-0x1C0]
+       jl       SHORT G_M16487_IG265
+       mov      rcx, gword ptr [rbp-0x1E8]
        mov      r8, rax
        xor      edx, edx
        call     [CORINFO_HELP_ARRADDR_ST]
-       mov      ecx, dword ptr [rbp-0x44]
-       mov      edx, dword ptr [rbp-0x10C]
-       mov      r8, gword ptr [rbp-0x1C0]
-       mov      r10d, dword ptr [rbp-0x130]
-       jmp      G_M16487_IG35
-						;; size=58 bbWeight=0 PerfScore 0.00
-G_M16487_IG265:
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x110]
+       mov      ecx, dword ptr [rbp-0x114]
+       mov      edx, dword ptr [rbp-0x44]
+       mov      r8, gword ptr [rbp-0x1E8]
+       mov      r10, gword ptr [rbp-0x1F0]
+       mov      r11d, dword ptr [rbp-0x140]
+       jmp      G_M16487_IG37
+						;; size=75 bbWeight=0 PerfScore 0.00
+G_M16487_IG267:
+       mov      r14, bword ptr [rbp+0x30]
        cmp      byte  ptr [r13+0x60], 0
-       je       G_M16487_IG40
+       je       SHORT G_M16487_IG268
        mov      rcx, r13
        call     [System.Text.RegularExpressions.Match:TidyBalancing():this]
-       jmp      G_M16487_IG40
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M16487_IG266:
-       xor      rcx, rcx
-       mov      r8, gword ptr [rbp-0x138]
-       mov      gword ptr [r8+0x28], rcx
+       mov      bword ptr [rbp+0x30], r14
+       mov      r8, gword ptr [rbp-0x148]
        jmp      G_M16487_IG42
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M16487_IG267:
-       mov      eax, r14d
-       mov      edx, 1
-       mov      r10, gword ptr [rbp+0x10]
-       test     byte  ptr [r10+0x40], 64
-       je       SHORT G_M16487_IG268
-       xor      eax, eax
-       mov      edx, -1
-						;; size=26 bbWeight=0 PerfScore 0.00
+						;; size=36 bbWeight=0 PerfScore 0.00
 G_M16487_IG268:
-       cmp      r9d, eax
-       je       G_M16487_IG317
-       mov      r14d, dword ptr [rbp-0x110]
-       movzx    r15, byte  ptr [rbp+0x48]
-       add      edx, r9d
-       mov      r13d, edx
-       mov      dword ptr [rbp-0x3C], r13d
-       mov      dword ptr [rbp+0x48], r15d
-       mov      r8, gword ptr [rbp-0x138]
-       jmp      G_M16487_IG44
-						;; size=47 bbWeight=0 PerfScore 0.00
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG42
+						;; size=9 bbWeight=0 PerfScore 0.00
 G_M16487_IG269:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      eax, r15d
+       mov      r10d, 1
+       mov      rdx, gword ptr [rbp+0x10]
+       test     byte  ptr [rdx+0x40], 64
+       je       SHORT G_M16487_IG270
+       xor      eax, eax
+       mov      r10d, -1
+						;; size=31 bbWeight=0 PerfScore 0.00
+G_M16487_IG270:
+       cmp      ebx, eax
+       je       G_M16487_IG335
+       mov      r15d, dword ptr [rbp-0x118]
+       add      r10d, ebx
+       mov      r13d, r10d
+       mov      dword ptr [rbp-0x3C], r13d
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG45
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M16487_IG271:
+       mov      r14, bword ptr [rbp+0x30]
        mov      rcx, gword ptr [r8+0x30]
        cmp      gword ptr [rcx+0x18], 0
-       je       SHORT G_M16487_IG270
+       je       SHORT G_M16487_IG272
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      rdx, gword ptr [r8+0x30]
        mov      r9, gword ptr [r8+0x30]
        mov      r9, gword ptr [r9+0x18]
-       mov      gword ptr [rbp-0x148], r9
-       mov      r10d, dword ptr [rbp-0x110]
+       mov      gword ptr [rbp-0x158], r9
+       mov      r10d, dword ptr [rbp-0x118]
        mov      dword ptr [rsp+0x20], r10d
        mov      r9, gword ptr [r8+0x30]
        mov      r8d, dword ptr [r9+0x44]
-       mov      r11, gword ptr [rbp-0x138]
+       mov      r11, gword ptr [rbp-0x148]
        mov      r9, gword ptr [r11+0x08]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
        lea      rcx, bword ptr [rbx+0x68]
-       mov      rdx, gword ptr [rbp-0x148]
+       mov      rdx, gword ptr [rbp-0x158]
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M16487_IG271
-						;; size=113 bbWeight=0 PerfScore 0.00
-G_M16487_IG270:
+       jmp      SHORT G_M16487_IG273
+						;; size=117 bbWeight=0 PerfScore 0.00
+G_M16487_IG272:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
-       mov      eax, dword ptr [rbp-0x110]
+       mov      eax, dword ptr [rbp-0x118]
        mov      dword ptr [rsp+0x20], eax
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      rdx, gword ptr [r8+0x30]
        mov      r8d, dword ptr [rdx+0x44]
-       mov      r10, gword ptr [rbp-0x138]
+       mov      r10, gword ptr [rbp-0x148]
        mov      rdx, gword ptr [r10+0x30]
        mov      r9, gword ptr [r10+0x08]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
 						;; size=67 bbWeight=0 PerfScore 0.00
-G_M16487_IG271:
-       mov      r10, gword ptr [rbp-0x138]
+G_M16487_IG273:
+       mov      r10, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r10+0x28]
        mov      rdx, rbx
        call     CORINFO_HELP_ASSIGN_REF
-       mov      eax, dword ptr [rbp-0x110]
-       jmp      G_M16487_IG108
-						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG272:
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x118]
+       jmp      G_M16487_IG113
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M16487_IG274:
+       mov      r14, bword ptr [rbp+0x30]
        xor      rcx, rcx
-       mov      gword ptr [r11+0x18], rcx
-       jmp      G_M16487_IG108
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG273:
+       mov      gword ptr [r10+0x18], rcx
+       mov      r10, gword ptr [rbp-0x148]
+       mov      rbx, gword ptr [r10+0x20]
+       test     rbx, rbx
+       mov      r8, r10
+       jne      G_M16487_IG278
+						;; size=33 bbWeight=0 PerfScore 0.00
+G_M16487_IG275:
        mov      rcx, r8
        mov      rdx, qword ptr [r8]
        mov      rdx, qword ptr [rdx+0x40]
        call     [rdx+0x38]<unknown method>
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      ebx, dword ptr [r8+0x5C]
        shl      ebx, 3
        mov      eax, ebx
        cmp      ebx, 32
-       jge      SHORT G_M16487_IG274
+       jge      SHORT G_M16487_IG276
        mov      eax, 32
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M16487_IG274:
+G_M16487_IG276:
        cmp      ebx, 16
-       jge      SHORT G_M16487_IG275
+       jge      SHORT G_M16487_IG277
        mov      ebx, 16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG275:
+G_M16487_IG277:
        mov      dword ptr [rbp-0x40], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r8+0x10]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      edx, dword ptr [rbp-0x40]
        mov      dword ptr [r8+0x50], edx
        movsxd   rdx, ebx
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r8+0x18]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      dword ptr [r8+0x54], ebx
        mov      rcx, 0xD1FFAB1E      ; int[]
        mov      edx, 32
        call     CORINFO_HELP_NEWARR_1_VC
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        lea      rcx, bword ptr [r8+0x20]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      dword ptr [r8+0x58], 32
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r8, gword ptr [rbp-0x138]
-       jmp      G_M16487_IG109
-						;; size=174 bbWeight=0 PerfScore 0.00
-G_M16487_IG276:
-       mov      gword ptr [rbp-0x150], r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      dword ptr [rbp-0x114], r9d
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x118]
+       mov      r8, gword ptr [rbp-0x148]
+       jmp      G_M16487_IG115
+						;; size=178 bbWeight=0 PerfScore 0.00
+G_M16487_IG278:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG114
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG279:
+       mov      gword ptr [rbp-0x160], r10
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rbp-0x6C], edx
+       mov      dword ptr [rbp-0x11C], r11d
+       mov      r14, bword ptr [rbp+0x30]
        call     <unknown method>
-       mov      r10, gword ptr [rbp-0x150]
+       mov      r10, gword ptr [rbp-0x160]
        movsxd   r9, dword ptr [r10+0xA0]
        add      r9, rax
        mov      rax, r9
+       mov      bword ptr [rbp+0x30], r14
        mov      qword ptr [rbp-0x68], rax
-       mov      eax, dword ptr [rbp-0x110]
-       mov      r9d, dword ptr [rbp-0x114]
-       mov      r11d, dword ptr [rbp-0x6C]
-       jmp      G_M16487_IG110
-						;; size=69 bbWeight=0 PerfScore 0.00
-G_M16487_IG277:
-       mov      r8, gword ptr [rbp-0x138]
+       mov      eax, dword ptr [rbp-0x118]
+       mov      edx, dword ptr [rbp-0x6C]
+       mov      r9d, dword ptr [rbp-0x70]
+       mov      r11d, dword ptr [rbp-0x11C]
+       jmp      G_M16487_IG116
+						;; size=83 bbWeight=0 PerfScore 0.00
+G_M16487_IG280:
+       mov      r8, gword ptr [rbp-0x148]
+       mov      r14, bword ptr [rbp+0x30]
        test     r15d, r15d
-       jne      G_M16487_IG281
-       jmp      G_M16487_IG282
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16487_IG278:
-       mov      r8, gword ptr [rbp-0x138]
+       jne      G_M16487_IG283
+       jmp      G_M16487_IG284
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16487_IG281:
+       mov      r8, gword ptr [rbp-0x148]
+       mov      r14, bword ptr [rbp+0x30]
        test     r15d, r15d
-       jne      G_M16487_IG202
-       jmp      G_M16487_IG216
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16487_IG279:
-       mov      r15, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       mov      ecx, dword ptr [rbp-0x70]
-       mov      dword ptr [rsp+0x20], ecx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0x80]
-       mov      qword ptr [rsp+0x30], rdx
+       jne      G_M16487_IG300
+       jmp      G_M16487_IG301
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16487_IG282:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r15, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r15
+       mov      dword ptr [rbp-0x130], r11d
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rsp+0x20], r9d
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x80]
+       mov      qword ptr [rsp+0x30], rcx
        mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
        mov      rcx, r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r8d, dword ptr [rbp-0x6C]
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r14d, eax
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M16487_IG280:
-       mov      gword ptr [rbp-0x188], rax
-       mov      edx, dword ptr [rbp-0xD0]
-       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:<IsNullableFor>g__WithCache|26_0(uint):ubyte:this]
-       test     eax, eax
-       mov      rax, gword ptr [rbp-0x188]
-       je       G_M16487_IG189
-       jmp      G_M16487_IG196
-						;; size=39 bbWeight=0 PerfScore 0.00
-G_M16487_IG281:
-       mov      r15, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       mov      ecx, dword ptr [rbp-0x70]
-       mov      dword ptr [rsp+0x20], ecx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0x80]
-       mov      qword ptr [rsp+0x30], rdx
+       mov      bword ptr [rbp+0x30], r14
+       mov      edx, eax
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=109 bbWeight=0 PerfScore 0.00
+G_M16487_IG283:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      r15, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r15
+       mov      dword ptr [rbp-0x130], r11d
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rsp+0x20], r9d
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x80]
+       mov      qword ptr [rsp+0x30], rcx
        mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
        mov      rcx, r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r8d, dword ptr [rbp-0x6C]
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r14d, eax
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M16487_IG282:
-       mov      r15, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       mov      ecx, dword ptr [rbp-0x70]
-       mov      dword ptr [rsp+0x20], ecx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0x80]
-       mov      qword ptr [rsp+0x30], rdx
+       mov      bword ptr [rbp+0x30], r14
+       mov      edx, eax
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=105 bbWeight=0 PerfScore 0.00
+G_M16487_IG284:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      r15, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r15
+       mov      dword ptr [rbp-0x130], r11d
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rsp+0x20], r9d
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x80]
+       mov      qword ptr [rsp+0x30], rcx
        mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
        mov      rcx, r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r8d, dword ptr [rbp-0x6C]
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r14d, eax
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M16487_IG283:
-       mov      r15, bword ptr [rbp-0x1D0]
-       mov      bword ptr [rbp-0x128], r15
-       mov      dword ptr [rbp-0x120], r9d
-       mov      ecx, dword ptr [rbp-0x70]
-       mov      dword ptr [rsp+0x20], ecx
-       lea      rdx, [rbp-0x78]
-       mov      qword ptr [rsp+0x28], rdx
-       lea      rdx, [rbp-0x80]
-       mov      qword ptr [rsp+0x30], rdx
+       mov      bword ptr [rbp+0x30], r14
+       mov      edx, eax
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=105 bbWeight=0 PerfScore 0.00
+G_M16487_IG285:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r15, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r15
+       mov      dword ptr [rbp-0x130], r11d
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rsp+0x20], r9d
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x80]
+       mov      qword ptr [rsp+0x30], rcx
        mov      gword ptr [rsp+0x38], r13
-       lea      rdx, [rbp-0x128]
-       mov      gword ptr [rbp-0x150], r10
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
        mov      rcx, r10
-       mov      dword ptr [rbp-0x6C], r11d
-       mov      r8d, r11d
+       mov      r8d, dword ptr [rbp-0x6C]
        mov      r9, qword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+InitialStateFindOptimizationsHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       mov      r14d, eax
-       mov      r15, gword ptr [rbp-0x150]
-       jmp      G_M16487_IG126
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M16487_IG284:
+       mov      bword ptr [rbp+0x30], r14
+       mov      edx, eax
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=109 bbWeight=0 PerfScore 0.00
+G_M16487_IG286:
+       mov      dword ptr [rbp-0x70], r9d
+       mov      rcx, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], rcx
+       mov      dword ptr [rbp-0x130], r11d
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r15d
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
+       mov      r15, gword ptr [rbp-0x160]
+       mov      r10, gword ptr [r15+0x98]
+       lea      edx, [rax+0x01]
+       cmp      edx, dword ptr [r10+0x08]
+       jae      G_M16487_IG205
+       lea      edx, [rax+0x01]
+       mov      ecx, dword ptr [r10+4*rdx+0x10]
+       mov      r10, r15
+       mov      eax, dword ptr [rbp-0x118]
+       mov      r9d, dword ptr [rbp-0x70]
+       jmp      G_M16487_IG118
+						;; size=104 bbWeight=0 PerfScore 0.00
+G_M16487_IG287:
+       mov      r8, gword ptr [rbp-0x148]
+       mov      r14, bword ptr [rbp+0x30]
+       mov      ecx, eax
+       sub      ecx, dword ptr [rbp-0xE0]
+       cmp      ecx, 0x3E8
+       jle      G_M16487_IG290
+       mov      ecx, dword ptr [rbp-0xE0]
+       add      ecx, 0x3E8
+       mov      r15d, ecx
+       cmp      gword ptr [rbp-0xF8], 0
+       je       SHORT G_M16487_IG289
+						;; size=56 bbWeight=0 PerfScore 0.00
+G_M16487_IG288:
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], eax
+       lea      rcx, [rbp-0xE0]
+       mov      qword ptr [rsp+0x20], rcx
+       lea      rcx, [rbp-0xF8]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x100]
+       mov      qword ptr [rsp+0x30], rcx
+       lea      rcx, [rbp-0x108]
+       mov      qword ptr [rsp+0x38], rcx
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x40], rcx
+       lea      rcx, [rbp-0xE8]
+       mov      qword ptr [rsp+0x48], rcx
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, r15d
+       mov      dword ptr [rbp-0x70], r9d
+       call     [<unknown method>]
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG122
+						;; size=121 bbWeight=0 PerfScore 0.00
+G_M16487_IG289:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG121
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG290:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG120
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG291:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      eax, dword ptr [rbp-0x118]
+       cmp      dword ptr [rbp-0xE0], eax
+       jge      G_M16487_IG294
+       cmp      dword ptr [rbp-0xE0], r15d
+       jge      SHORT G_M16487_IG292
+       mov      r8, gword ptr [r13+0x08]
+       mov      r15, r8
+       mov      r9d, dword ptr [rbp-0xF0]
+       mov      r10, gword ptr [rbp-0x160]
+       mov      rcx, gword ptr [r10+0x10]
+       cmp      r9d, dword ptr [rcx+0x08]
+       jae      G_M16487_IG205
+       mov      r8d, r9d
+       mov      r8, gword ptr [rcx+8*r8+0x10]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rdx, r10
+       mov      rcx, r15
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NfaMatchingState[ulong]:InitializeFrom(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.Text.RegularExpressions.Symbolic.MatchingState`1[ulong]):this]
+       mov      dword ptr [rbp-0xF0], -1
+       mov      gword ptr [rbp-0xF8], r15
+						;; size=112 bbWeight=0 PerfScore 0.00
+G_M16487_IG292:
+       mov      r15, gword ptr [rbp-0x160]
+       cmp      byte  ptr [r15+0xAC], 0
+       mov      r10, r15
+       je       SHORT G_M16487_IG293
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      rdx, qword ptr [rbp-0x68]
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:CheckTimeout(long):this]
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x118]
+       mov      r9d, dword ptr [rbp-0x70]
+       mov      r10, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG119
+						;; size=66 bbWeight=0 PerfScore 0.00
+G_M16487_IG293:
+       mov      bword ptr [rbp+0x30], r14
+       mov      eax, dword ptr [rbp-0x118]
+       mov      r9d, dword ptr [rbp-0x70]
+       jmp      G_M16487_IG119
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M16487_IG294:
+       mov      bword ptr [rbp+0x30], r14
+       jmp      G_M16487_IG123
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16487_IG295:
+       mov      gword ptr [rbp-0x1B8], rax
+       mov      bword ptr [rbp-0x138], r12
+       mov      r10d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], r10d
+       lea      rdx, [rbp-0x138]
+       mov      rcx, r14
+       mov      r8d, r9d
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong]:GetPositionId(System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong],System.ReadOnlySpan`1[ushort],int):int]
+       mov      r8, gword ptr [r14+0x98]
+       lea      ecx, [rax+0x01]
+       cmp      ecx, dword ptr [r8+0x08]
+       jae      G_M16487_IG205
+       lea      ecx, [rax+0x01]
+       mov      ecx, dword ptr [r8+4*rcx+0x10]
+       mov      rax, gword ptr [rbp-0x1B8]
+       jmp      G_M16487_IG125
+						;; size=87 bbWeight=0 PerfScore 0.00
+G_M16487_IG296:
+       mov      rcx, 0xD1FFAB1E      ; System.Func`2[uint,int]
+       call     CORINFO_HELP_NEWSFAST
+       mov      gword ptr [rbp-0x1D0], rax
+       lea      rcx, bword ptr [rax+0x08]
+       mov      rdx, gword ptr [rbp-0x1C8]
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, 0xD1FFAB1E      ; function address
+       mov      rdx, gword ptr [rbp-0x1D0]
+       mov      qword ptr [rdx+0x18], rcx
+       mov      rcx, rdx
+       mov      edx, dword ptr [rbp-0x10C]
+       call     [System.Threading.StackHelper:CallOnEmptyStack[uint,int](System.Func`2[uint,int],uint):int]
+       mov      ecx, eax
+       jmp      G_M16487_IG128
+						;; size=81 bbWeight=0 PerfScore 0.00
+G_M16487_IG297:
+       mov      gword ptr [rbp-0x1C8], rax
+       mov      edx, dword ptr [rbp-0x10C]
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:<IsNullableFor>g__WithCache|26_0(uint):ubyte:this]
+       test     eax, eax
+       mov      rax, gword ptr [rbp-0x1C8]
+       jne      G_M16487_IG176
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M16487_IG298:
+       mov      rcx, gword ptr [rax+0x10]
+       mov      edx, dword ptr [rbp-0x10C]
+       cmp      dword ptr [rcx], ecx
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexNode`1[ulong]:ResolveFixedLength(uint):int:this]
+       mov      ecx, eax
+       jmp      G_M16487_IG128
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16487_IG299:
+       mov      ecx, -1
+       jmp      G_M16487_IG128
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M16487_IG300:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      r15, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r15
+       mov      dword ptr [rbp-0x130], r11d
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rsp+0x20], r9d
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x80]
+       mov      qword ptr [rsp+0x30], rcx
+       mov      gword ptr [rsp+0x38], r13
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, dword ptr [rbp-0x6C]
+       mov      r9, qword ptr [rbp-0x68]
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
+       mov      bword ptr [rbp+0x30], r14
+       mov      edx, eax
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=105 bbWeight=0 PerfScore 0.00
+G_M16487_IG301:
+       mov      dword ptr [rbp-0x6C], edx
+       mov      r15, bword ptr [rbp-0x208]
+       mov      bword ptr [rbp-0x138], r15
+       mov      dword ptr [rbp-0x130], r11d
+       mov      dword ptr [rbp-0x70], r9d
+       mov      dword ptr [rsp+0x20], r9d
+       lea      rcx, [rbp-0x78]
+       mov      qword ptr [rsp+0x28], rcx
+       lea      rcx, [rbp-0x80]
+       mov      qword ptr [rsp+0x30], rcx
+       mov      gword ptr [rsp+0x38], r13
+       lea      rdx, [rbp-0x138]
+       mov      gword ptr [rbp-0x160], r10
+       mov      rcx, r10
+       mov      r8d, dword ptr [rbp-0x6C]
+       mov      r9, qword ptr [rbp-0x68]
+       call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindEndPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoOptimizationsInitialStateHandler[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,long,int,byref,byref,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
+       mov      bword ptr [rbp+0x30], r14
+       mov      edx, eax
+       mov      r14, gword ptr [rbp-0x160]
+       jmp      G_M16487_IG129
+						;; size=105 bbWeight=0 PerfScore 0.00
+G_M16487_IG302:
        lea      rcx, [rbp-0x60]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicMatch:get_MatchExists():System.Text.RegularExpressions.Symbolic.SymbolicMatch]
-       jmp      G_M16487_IG131
+       jmp      G_M16487_IG134
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M16487_IG285:
-       mov      r9d, dword ptr [rbp-0x6C]
-       cmp      r14d, r9d
-       jge      SHORT G_M16487_IG286
-       jmp      G_M16487_IG293
+G_M16487_IG303:
+       mov      r8d, dword ptr [rbp-0x6C]
+       cmp      r15d, r8d
+       jge      SHORT G_M16487_IG304
+       jmp      G_M16487_IG311
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M16487_IG286:
-       mov      rdx, gword ptr [r15+0x60]
+G_M16487_IG304:
+       mov      rdx, gword ptr [r14+0x60]
        mov      edx, dword ptr [rdx+0x34]
-       mov      rdx, gword ptr [r15+0x60]
-       xor      r10d, r10d
+       mov      rdx, gword ptr [r14+0x60]
+       xor      r11d, r11d
        test     byte  ptr [rdx+0x34], 16
-       setne    r10b
-       mov      rdx, gword ptr [r15+0x60]
+       setne    r11b
+       mov      rdx, gword ptr [r14+0x60]
        test     dword ptr [rdx+0x34], 256
-       je       SHORT G_M16487_IG287
-       test     r10d, r10d
-       jne      SHORT G_M16487_IG288
-       jmp      SHORT G_M16487_IG289
+       je       SHORT G_M16487_IG305
+       test     r11d, r11d
+       jne      SHORT G_M16487_IG306
+       jmp      SHORT G_M16487_IG307
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M16487_IG287:
-       test     r10d, r10d
-       jne      SHORT G_M16487_IG290
-       jmp      G_M16487_IG291
+G_M16487_IG305:
+       test     r11d, r11d
+       jne      SHORT G_M16487_IG308
+       jmp      G_M16487_IG309
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG288:
+G_M16487_IG306:
        mov      dword ptr [rbp-0x70], eax
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
+       mov      bword ptr [rbp-0x138], r12
+       mov      r10d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], r10d
        mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       lea      rdx, [rbp-0x138]
+       mov      rcx, r14
+       mov      r8d, r15d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       jmp      G_M16487_IG292
+       jmp      G_M16487_IG310
 						;; size=57 bbWeight=0 PerfScore 0.00
-G_M16487_IG289:
+G_M16487_IG307:
        mov      dword ptr [rbp-0x70], eax
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
+       mov      bword ptr [rbp-0x138], r12
+       mov      r10d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], r10d
        mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       lea      rdx, [rbp-0x138]
+       mov      rcx, r14
+       mov      r8d, r15d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       jmp      SHORT G_M16487_IG292
+       jmp      SHORT G_M16487_IG310
 						;; size=54 bbWeight=0 PerfScore 0.00
-G_M16487_IG290:
+G_M16487_IG308:
        mov      dword ptr [rbp-0x70], eax
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
+       mov      bword ptr [rbp-0x138], r12
+       mov      r10d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], r10d
        mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       lea      rdx, [rbp-0x138]
+       mov      rcx, r14
+       mov      r8d, r15d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+FullNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
-       jmp      SHORT G_M16487_IG292
+       jmp      SHORT G_M16487_IG310
 						;; size=54 bbWeight=0 PerfScore 0.00
-G_M16487_IG291:
+G_M16487_IG309:
        mov      dword ptr [rbp-0x70], eax
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
+       mov      bword ptr [rbp-0x138], r12
+       mov      r10d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], r10d
        mov      gword ptr [rsp+0x20], r13
-       lea      rdx, [rbp-0x128]
-       mov      rcx, r15
-       mov      r8d, r14d
+       lea      rdx, [rbp-0x138]
+       mov      rcx, r14
+       mov      r8d, r15d
        mov      r9d, dword ptr [rbp-0x78]
        call     [System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1[ulong]:FindStartPosition[System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoZAnchorInputReader[ulong],System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+NoAnchorsNullabilityHandler[ulong]](System.ReadOnlySpan`1[ushort],int,int,System.Text.RegularExpressions.Symbolic.SymbolicRegexMatcher`1+PerThreadData[ulong]):int:this]
 						;; size=52 bbWeight=0 PerfScore 0.00
-G_M16487_IG292:
-       mov      r9d, eax
+G_M16487_IG310:
+       mov      r8d, eax
        mov      eax, dword ptr [rbp-0x70]
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M16487_IG293:
-       mov      r10d, r9d
-       mov      r9d, r10d
-       jmp      G_M16487_IG128
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG294:
+G_M16487_IG311:
+       mov      dword ptr [rbp-0x84], r8d
+       mov      r8d, dword ptr [rbp-0x84]
+       jmp      G_M16487_IG131
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M16487_IG312:
        cmp      eax, 2
-       jl       G_M16487_IG129
-       mov      r8, gword ptr [r15+0x60]
-       test     dword ptr [r8+0x34], 256
-       jne      SHORT G_M16487_IG295
-       mov      bword ptr [rbp-0x128], r12
-       mov      r10d, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], r10d
-       mov      dword ptr [rsp+0x20], r14d
+       jl       G_M16487_IG132
+       mov      rdx, gword ptr [r14+0x60]
+       test     dword ptr [rdx+0x34], 256
+       jne      SHORT G_M16487_IG313
+       mov      dword ptr [rbp-0x84], r8d
+       mov      bword ptr [rbp-0x138], r12
+       mov      r10d, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], r10d
+       mov      dword ptr [rsp+0x20], r15d
        mov      gword ptr [rsp+0x28], r13
-       lea      r8, [rbp-0x128]
+       lea      r8, [rbp-0x138]
        lea      rdx, [rbp-0x98]
-       mov      rcx, r15
-       mov      dword ptr [rbp-0x84], r9d
+       mov      rcx, r14
+       mov      r9d, dword ptr [rbp-0x84]
        call     [<unknown method>]
-       jmp      SHORT G_M16487_IG296
-						;; size=86 bbWeight=0 PerfScore 0.00
-G_M16487_IG295:
-       mov      bword ptr [rbp-0x128], r12
-       mov      eax, dword ptr [rbp-0x110]
-       mov      dword ptr [rbp-0x120], eax
-       mov      dword ptr [rsp+0x20], r14d
+       jmp      SHORT G_M16487_IG314
+						;; size=92 bbWeight=0 PerfScore 0.00
+G_M16487_IG313:
+       mov      dword ptr [rbp-0x84], r8d
+       mov      bword ptr [rbp-0x138], r12
+       mov      eax, dword ptr [rbp-0x118]
+       mov      dword ptr [rbp-0x130], eax
+       mov      dword ptr [rsp+0x20], r15d
        mov      gword ptr [rsp+0x28], r13
-       lea      r8, [rbp-0x128]
+       lea      r8, [rbp-0x138]
        lea      rdx, [rbp-0x98]
-       mov      rcx, r15
-       mov      dword ptr [rbp-0x84], r9d
+       mov      rcx, r14
+       mov      r9d, dword ptr [rbp-0x84]
        call     [<unknown method>]
-						;; size=59 bbWeight=0 PerfScore 0.00
-G_M16487_IG296:
+						;; size=66 bbWeight=0 PerfScore 0.00
+G_M16487_IG314:
        mov      rax, gword ptr [rbp-0x98]
        mov      r10, gword ptr [rbp-0x90]
-       mov      r13d, dword ptr [rbp-0x84]
-       mov      r11d, r13d
+       mov      r14d, dword ptr [rbp-0x84]
        mov      ecx, r14d
-       sub      ecx, r11d
+       mov      edx, r15d
+       sub      edx, ecx
        mov      gword ptr [rbp-0x60], rax
        mov      gword ptr [rbp-0x58], r10
-       mov      dword ptr [rbp-0x50], r11d
-       mov      dword ptr [rbp-0x4C], ecx
-       jmp      G_M16487_IG131
-						;; size=50 bbWeight=0 PerfScore 0.00
-G_M16487_IG297:
-       test     r14, r14
-       je       G_M16487_IG133
-       xor      r13d, r13d
-       jmp      SHORT G_M16487_IG300
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M16487_IG298:
-       cmp      r13d, dword ptr [r14+0x08]
-       jae      G_M16487_IG315
-       mov      r9d, r13d
-       cmp      dword ptr [r14+4*r9+0x10], 0
-       jl       SHORT G_M16487_IG299
+       mov      dword ptr [rbp-0x50], ecx
+       mov      dword ptr [rbp-0x4C], edx
+       jmp      G_M16487_IG134
+						;; size=48 bbWeight=0 PerfScore 0.00
+G_M16487_IG315:
+       test     r13, r13
+       je       G_M16487_IG136
+       xor      eax, eax
+       xor      r14d, r14d
+       jmp      SHORT G_M16487_IG318
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M16487_IG316:
+       cmp      r14d, dword ptr [r13+0x08]
+       jae      G_M16487_IG205
+       mov      r9d, r14d
+       cmp      dword ptr [r13+4*r9+0x10], 0
+       jl       SHORT G_M16487_IG317
        mov      dword ptr [rbp-0x44], r8d
-       cmp      r13d, dword ptr [r14+0x08]
-       jae      G_M16487_IG315
-       mov      r9d, r13d
-       mov      r9d, dword ptr [r14+4*r9+0x10]
+       cmp      r14d, dword ptr [r13+0x08]
+       jae      G_M16487_IG205
+       mov      r9d, r14d
+       mov      r9d, dword ptr [r13+4*r9+0x10]
        mov      r8d, r9d
-       cmp      r13d, dword ptr [r15+0x08]
-       jae      G_M16487_IG315
-       mov      r9d, r13d
+       cmp      r14d, dword ptr [r15+0x08]
+       jae      G_M16487_IG205
+       mov      r9d, r14d
        mov      r9d, dword ptr [r15+4*r9+0x10]
-       mov      edx, r13d
+       mov      edx, r14d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Capture(int,int,int):this]
        mov      r8d, dword ptr [rbp-0x44]
 						;; size=80 bbWeight=0 PerfScore 0.00
-G_M16487_IG299:
-       inc      r13d
+G_M16487_IG317:
+       inc      r14d
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M16487_IG300:
-       cmp      dword ptr [r14+0x08], r13d
-       jg       SHORT G_M16487_IG298
-       jmp      G_M16487_IG138
+G_M16487_IG318:
+       cmp      dword ptr [r13+0x08], r14d
+       jg       SHORT G_M16487_IG316
+       jmp      G_M16487_IG141
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG301:
-       mov      r14d, r13d
+G_M16487_IG319:
+       mov      r15d, r14d
        mov      dword ptr [rbp-0x44], r8d
-       mov      r15d, r8d
+       mov      r13d, r8d
        mov      r8d, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG134
+       jmp      G_M16487_IG137
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M16487_IG302:
+G_M16487_IG320:
        mov      dword ptr [rbp-0x44], r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleCrawl():this]
        mov      r8d, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG135
+       jmp      G_M16487_IG138
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M16487_IG303:
+G_M16487_IG321:
        mov      dword ptr [rbp-0x44], r8d
        mov      rcx, 0xD1FFAB1E      ; int[]
        mov      edx, 2
        call     CORINFO_HELP_NEWARR_1_VC
        mov      r8, rax
-       mov      rcx, gword ptr [rbp-0x1B8]
+       mov      rcx, gword ptr [rbp-0x1E0]
        xor      edx, edx
        call     [CORINFO_HELP_ARRADDR_ST]
        mov      r8d, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG136
+       jmp      G_M16487_IG139
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M16487_IG304:
+G_M16487_IG322:
        mov      dword ptr [rbp-0x44], r8d
        cmp      dword ptr [r10+0x08], 0
-       jbe      G_M16487_IG315
-       mov      gword ptr [rbp-0x1C0], r10
+       jbe      G_M16487_IG205
+       mov      gword ptr [rbp-0x1E8], r10
        mov      rdx, gword ptr [r10+0x10]
-       mov      gword ptr [rbp-0x1C8], rdx
-       mov      dword ptr [rbp-0x10C], r9d
+       mov      gword ptr [rbp-0x1F8], rdx
+       mov      dword ptr [rbp-0x114], r9d
        lea      edx, [8*r9]
        movsxd   rdx, edx
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
        xor      ecx, ecx
-       jmp      SHORT G_M16487_IG306
+       jmp      SHORT G_M16487_IG324
 						;; size=70 bbWeight=0 PerfScore 0.00
-G_M16487_IG305:
-       mov      r8, gword ptr [rbp-0x1C8]
+G_M16487_IG323:
+       mov      r8, gword ptr [rbp-0x1F8]
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M16487_IG315
+       jae      G_M16487_IG205
        mov      edx, ecx
        mov      r11d, dword ptr [r8+4*rdx+0x10]
        cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M16487_IG315
+       jae      G_M16487_IG205
        mov      edx, ecx
        mov      dword ptr [rax+4*rdx+0x10], r11d
        inc      ecx
-       mov      gword ptr [rbp-0x1C8], r8
+       mov      gword ptr [rbp-0x1F8], r8
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M16487_IG306:
-       mov      r10d, dword ptr [rbp-0x10C]
+G_M16487_IG324:
+       mov      r10d, dword ptr [rbp-0x114]
        lea      r8d, [r10+r10]
        cmp      ecx, r8d
-       jl       SHORT G_M16487_IG305
-       mov      rcx, gword ptr [rbp-0x1C0]
+       jl       SHORT G_M16487_IG323
+       mov      rcx, gword ptr [rbp-0x1E8]
        mov      r8, rax
        xor      edx, edx
        call     [CORINFO_HELP_ARRADDR_ST]
        mov      r8d, dword ptr [rbp-0x44]
-       mov      r9d, dword ptr [rbp-0x10C]
-       mov      r10, gword ptr [rbp-0x1C0]
-       jmp      G_M16487_IG137
+       mov      r9d, dword ptr [rbp-0x114]
+       mov      r10, gword ptr [rbp-0x1E8]
+       jmp      G_M16487_IG140
 						;; size=57 bbWeight=0 PerfScore 0.00
-G_M16487_IG307:
-       mov      bword ptr [rbp-0x128], r12
-       mov      dword ptr [rbp-0x120], eax
-       lea      rdx, [rbp-0x128]
+G_M16487_IG325:
+       mov      r14, bword ptr [rbp+0x30]
+       mov      bword ptr [rbp-0x138], r12
+       mov      dword ptr [rbp-0x130], eax
+       lea      rdx, [rbp-0x138]
        mov      rcx, r8
        mov      r10, qword ptr [r8]
        mov      r10, qword ptr [r10+0x40]
        call     [r10+0x20]<unknown method>
-       jmp      G_M16487_IG139
-						;; size=39 bbWeight=0 PerfScore 0.00
-G_M16487_IG308:
+       mov      bword ptr [rbp+0x30], r14
+       mov      gword ptr [rbp+0x38], r15
+       mov      r15d, dword ptr [rbp-0x118]
+       jmp      G_M16487_IG142
+						;; size=58 bbWeight=0 PerfScore 0.00
+G_M16487_IG326:
        cmp      byte  ptr [r13+0x60], 0
-       je       G_M16487_IG142
+       je       G_M16487_IG145
        mov      rcx, r13
        call     [System.Text.RegularExpressions.Match:TidyBalancing():this]
-       jmp      G_M16487_IG142
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M16487_IG309:
-       xor      rcx, rcx
-       mov      r8, gword ptr [rbp-0x138]
-       mov      gword ptr [r8+0x28], rcx
-       jmp      G_M16487_IG144
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M16487_IG310:
-       mov      ecx, r14d
-       mov      edx, 1
-       mov      r10, gword ptr [rbp+0x10]
-       test     byte  ptr [r10+0x40], 64
-       je       SHORT G_M16487_IG311
-       xor      ecx, ecx
-       mov      edx, -1
+       mov      r8, gword ptr [rbp-0x148]
+       jmp      G_M16487_IG145
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M16487_IG327:
+       mov      r14, bword ptr [rbp+0x30]
+       xor      rdx, rdx
+       mov      gword ptr [r8+0x28], rdx
+       mov      rdx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rbx+0x18], rdx
+       je       SHORT G_M16487_IG329
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M16487_IG311:
+G_M16487_IG328:
+       mov      rdx, r14
+       mov      r8, r13
+       mov      rcx, gword ptr [rbx+0x08]
+       call     [rbx+0x18]<unknown method>
+       test     eax, eax
+       mov      bword ptr [rbp+0x30], r14
+       mov      r8, gword ptr [rbp-0x148]
+       je       G_M16487_IG335
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG148
+						;; size=41 bbWeight=0 PerfScore 0.00
+G_M16487_IG329:
+       mov      bword ptr [rbp+0x30], r14
+       mov      r8, gword ptr [rbp-0x148]
+       jmp      G_M16487_IG147
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M16487_IG330:
+       mov      ecx, r15d
+       mov      r10d, 1
+       mov      rdx, gword ptr [rbp+0x10]
+       test     byte  ptr [rdx+0x40], 64
+       je       SHORT G_M16487_IG331
+       xor      ecx, ecx
+       mov      r10d, -1
+						;; size=27 bbWeight=0 PerfScore 0.00
+G_M16487_IG331:
        cmp      eax, ecx
-       je       G_M16487_IG317
-       movzx    r15, byte  ptr [rbp+0x48]
-       lea      r13d, [rax+rdx]
-       mov      dword ptr [rbp+0x48], r15d
-       mov      edx, r13d
-       mov      r8, gword ptr [rbp-0x138]
-       jmp      G_M16487_IG146
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M16487_IG312:
+       mov      bword ptr [rbp+0x30], r14
+       je       G_M16487_IG335
+       lea      r13d, [rax+r10]
+       mov      r10d, r13d
+       mov      r14, bword ptr [rbp+0x30]
+       jmp      G_M16487_IG149
+						;; size=28 bbWeight=0 PerfScore 0.00
+G_M16487_IG332:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
-       mov      rbx, rax
-       mov      r15, gword ptr [rbp-0x150]
+       mov      r12, rax
+       mov      r14, gword ptr [rbp-0x160]
        vxorps   xmm0, xmm0, xmm0
-       vcvtsi2sd xmm0, xmm0, dword ptr [r15+0xA0]
+       vcvtsi2sd xmm0, xmm0, dword ptr [r14+0xA0]
        call     [<unknown method>]
        mov      r9, rax
-       mov      rcx, rbx
+       mov      rcx, r12
        mov      rdx, 0xD1FFAB1E
        mov      r8, 0xD1FFAB1E
        call     [<unknown method>]
-       mov      rcx, rbx
+       mov      rcx, r12
        call     CORINFO_HELP_THROW
 						;; size=84 bbWeight=0 PerfScore 0.00
-G_M16487_IG313:
+G_M16487_IG333:
        call     [System.MulticastDelegate:ThrowNullThisInDelegateToInstance()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M16487_IG314:
-       mov      r10d, dword ptr [rax+0x2C]
-       jmp      G_M16487_IG191
-						;; size=9 bbWeight=0.00 PerfScore 0.01
-G_M16487_IG315:
-       call     CORINFO_HELP_RNGCHKFAIL
-       int3     
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M16487_IG316:
+G_M16487_IG334:
        mov      rcx, gword ptr [rax+0x10]
        mov      r8, qword ptr [rcx]
        mov      r8, qword ptr [r8+0x40]
@@ -4401,19 +4603,18 @@ G_M16487_IG316:
        mov      r8, rax
        mov      rax, gword ptr [rbp+0x10]
        jmp      G_M16487_IG03
-						;; size=27 bbWeight=0.01 PerfScore 0.09
-G_M16487_IG317:
+						;; size=27 bbWeight=0.00 PerfScore 0.02
+G_M16487_IG335:
        xor      rcx, rcx
-       mov      r8, gword ptr [rbp-0x138]
        mov      gword ptr [r8+0x08], rcx
        mov      rdx, gword ptr [rbp+0x10]
        lea      rcx, bword ptr [rdx+0x38]
        mov      rdx, r8
        call     CORINFO_HELP_ASSIGN_REF
        nop      
-						;; size=30 bbWeight=1 PerfScore 5.25
-G_M16487_IG318:
-       add      rsp, 520
+						;; size=23 bbWeight=1 PerfScore 4.25
+G_M16487_IG336:
+       add      rsp, 584
        pop      rbx
        pop      rsi
        pop      rdi
@@ -4424,7 +4625,7 @@ G_M16487_IG318:
        pop      rbp
        ret      
 						;; size=20 bbWeight=1 PerfScore 5.25
-G_M16487_IG319:
+G_M16487_IG337:
        push     rbp
        push     r15
        push     r14
@@ -4436,19 +4637,19 @@ G_M16487_IG319:
        sub      rsp, 88
        mov      rbp, qword ptr [rcx+0x50]
        mov      qword ptr [rsp+0x50], rbp
-       lea      rbp, [rbp+0x240]
+       lea      rbp, [rbp+0x280]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M16487_IG320:
+G_M16487_IG338:
        xor      rcx, rcx
-       mov      r8, gword ptr [rbp-0x138]
+       mov      r8, gword ptr [rbp-0x148]
        mov      gword ptr [r8+0x08], rcx
-       mov      r10, gword ptr [rbp+0x10]
-       lea      rcx, bword ptr [r10+0x38]
+       mov      rdx, gword ptr [rbp+0x10]
+       lea      rcx, bword ptr [rdx+0x38]
        mov      rdx, r8
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG321:
+G_M16487_IG339:
        add      rsp, 88
        pop      rbx
        pop      rsi
@@ -4461,6 +4662,6 @@ G_M16487_IG321:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 13039, prolog size 118, PerfScore 301942.92, instruction count 2701, allocated bytes for code 13039 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
+; Total bytes of code 13776, prolog size 124, PerfScore 292162.31, instruction count 2868, allocated bytes for code 13776 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
 ; ============================================================
 


```

</details>

# ``Span.IndexerBench.CoveredIndex3(length: 1024)``

Hot functions:

- (98.68%) ``IndexerBench.TestCoveredIndex3`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]IndexerBench.TestCoveredIndex3(value class System.Span`1<unsigned int8>,int32,int32)``

```diff
 ;  V00 arg0         [V00,T07] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 arg2         [V02,T06] (  4,102.69)     int  ->   r8         single-def
-;  V03 loc0         [V03,T03] (  3,201.27)   ubyte  ->  rdx        
-;  V04 loc1         [V04,T04] (  4,201.16)   ubyte  ->  r10        
-;  V05 loc2         [V05,T05] (  4,201.16)   ubyte  ->   r9        
+;  V03 loc0         [V03,T03] (  3,201.27)   ubyte  ->  rax        
+;  V04 loc1         [V04,T04] (  4,201.16)   ubyte  ->  rdx        
+;  V05 loc2         [V05,T05] (  4,201.16)   ubyte  ->  r10        
 ;* V06 loc3         [V06    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V07 loc4         [V07,T00] (  7,603.63)     int  ->  rax        
+;  V07 loc4         [V07,T08] (  2,  0.20)     int  ->   r9        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V09 tmp1         [V09,T01] (  4,302.57)   byref  ->  r11         single-def "V00.[000..008)"
 ;  V10 tmp2         [V10,T02] (  3,202.08)     int  ->  rcx         single-def "V00.[008..012)"
+;  V11 rat0         [V11,T00] (  7,603.63)    long  ->   r9         "Widened IV V07"
 ;
 ; Lcl frame size = 32
 
@@ -155,51 +156,51 @@ G_M31285_IG01:
        mov      qword ptr [rsp+0xA8], rbx
        mov      rcx, bword ptr [rsp+0xC0]
        mov      r8d, dword ptr [rsp+0xD0]
-       mov      edx, dword ptr [rsp+0x74]
-       mov      r10d, dword ptr [rsp+0x70]
-       mov      r9d, dword ptr [rsp+0x6C]
-       mov      eax, dword ptr [rsp+0x64]
+       mov      eax, dword ptr [rsp+0x74]
+       mov      edx, dword ptr [rsp+0x70]
+       mov      r10d, dword ptr [rsp+0x6C]
+       mov      r9d, dword ptr [rsp+0x64]
 						;; size=46 bbWeight=1 PerfScore 13.25
 G_M31285_IG02:
        mov      r11, bword ptr [rcx]
        mov      ecx, dword ptr [rcx+0x08]
-       cmp      eax, r8d
+       cmp      r9d, r8d
        jge      SHORT G_M31285_IG06
-       align    [7 bytes for IG03]
-						;; size=18 bbWeight=1 PerfScore 5.50
+       mov      r9d, r9d
+       align    [4 bytes for IG03]
+						;; size=18 bbWeight=1 PerfScore 5.75
 G_M31285_IG03:
-       cmp      eax, ecx
+       cmp      r9d, ecx
        jae      SHORT G_M31285_IG08
-       mov      ebx, eax
-       movzx    rbx, byte  ptr [r11+rbx]
-       xor      edx, ebx
-       movzx    rdx, dl
-       cmp      eax, 100
+       movzx    rbx, byte  ptr [r11+r9]
+       xor      eax, ebx
+       movzx    rax, al
+       cmp      r9d, 100
        je       SHORT G_M31285_IG05
-						;; size=21 bbWeight=100.59 PerfScore 528.09
+						;; size=21 bbWeight=100.59 PerfScore 502.95
 G_M31285_IG04:
        cmp      ecx, 50
        jbe      SHORT G_M31285_IG08
        movzx    rbx, byte  ptr [r11+0x32]
+       xor      edx, ebx
+       movzx    rdx, dl
+       movzx    rbx, byte  ptr [r11+0x19]
        xor      r10d, ebx
        movzx    r10, r10b
-       movzx    rbx, byte  ptr [r11+0x19]
-       xor      r9d, ebx
-       movzx    r9, r9b
-						;; size=29 bbWeight=100.49 PerfScore 628.06
+						;; size=27 bbWeight=100.49 PerfScore 628.06
 G_M31285_IG05:
-       inc      eax
-       cmp      eax, r8d
+       inc      r9d
+       cmp      r9d, r8d
        jl       SHORT G_M31285_IG03
-						;; size=7 bbWeight=100.59 PerfScore 150.88
+						;; size=8 bbWeight=100.59 PerfScore 150.88
 G_M31285_IG06:
-       mov      eax, r9d
-       xor      eax, r10d
-       xor      eax, edx
-       xor      eax, r10d
-       xor      eax, r9d
-       movzx    rax, al
-						;; size=17 bbWeight=0.09 PerfScore 0.13
+       mov      ecx, r10d
+       xor      ecx, edx
+       xor      ecx, eax
+       xor      ecx, edx
+       xor      ecx, r10d
+       movzx    rax, cl
+						;; size=15 bbWeight=0.09 PerfScore 0.13
 G_M31285_IG07:
        add      rsp, 168
        pop      rbx
@@ -211,7 +212,7 @@ G_M31285_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 154, prolog size 46, PerfScore 1326.12, instruction count 44, allocated bytes for code 154 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 151, prolog size 46, PerfScore 1301.22, instruction count 44, allocated bytes for code 151 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Instrumented Tier0)
@@ -349,20 +350,21 @@ G_M31285_IG09:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 429506.8
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 346767.5
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T07] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 arg2         [V02,T06] (  4,102.00)     int  ->   r8         single-def
-;  V03 loc0         [V03,T02] (  3,200.00)   ubyte  ->  rdx        
-;  V04 loc1         [V04,T04] (  4,197.79)   ubyte  ->  r10        
-;  V05 loc2         [V05,T05] (  4,197.79)   ubyte  ->   r9        
+;  V03 loc0         [V03,T03] (  3,200.00)   ubyte  ->  rax        
+;  V04 loc1         [V04,T04] (  4,199.91)   ubyte  ->  rdx        
+;  V05 loc2         [V05,T05] (  4,199.91)   ubyte  ->  r10        
 ;* V06 loc3         [V06    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V07 loc4         [V07,T00] (  7,600.00)     int  ->  rax        
+;  V07 loc4         [V07,T08] (  2,  0.00)     int  ->   r9        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T01] (  4,298.79)   byref  ->  r11         single-def "V00.[000..008)"
-;  V10 tmp2         [V10,T03] (  3,199.89)     int  ->  rcx         single-def "V00.[008..012)"
+;  V09 tmp1         [V09,T01] (  4,300.91)   byref  ->  r11         single-def "V00.[000..008)"
+;  V10 tmp2         [V10,T02] (  3,200.95)     int  ->  rcx         single-def "V00.[008..012)"
+;  V11 rat0         [V11,T00] (  7,600.00)    long  ->   r9         "Widened IV V07"
 ;
 ; Lcl frame size = 32
 
@@ -371,63 +373,65 @@ G_M31285_IG01:
        mov      qword ptr [rsp+0xA8], rbx
        mov      rcx, bword ptr [rsp+0xC0]
        mov      r8d, dword ptr [rsp+0xD0]
-       mov      edx, dword ptr [rsp+0x74]
-       mov      r10d, dword ptr [rsp+0x70]
-       mov      r9d, dword ptr [rsp+0x6C]
-       mov      eax, dword ptr [rsp+0x64]
+       mov      eax, dword ptr [rsp+0x74]
+       mov      edx, dword ptr [rsp+0x70]
+       mov      r10d, dword ptr [rsp+0x6C]
+       mov      r9d, dword ptr [rsp+0x64]
 						;; size=46 bbWeight=1 PerfScore 13.25
 G_M31285_IG02:
        mov      r11, bword ptr [rcx]
        mov      ecx, dword ptr [rcx+0x08]
-       cmp      eax, r8d
-       jge      SHORT G_M31285_IG06
-       align    [7 bytes for IG03]
-						;; size=18 bbWeight=1 PerfScore 5.50
+       cmp      r9d, r8d
+       jge      SHORT G_M31285_IG07
+						;; size=11 bbWeight=1 PerfScore 5.25
 G_M31285_IG03:
-       cmp      eax, ecx
-       jae      SHORT G_M31285_IG08
-       mov      ebx, eax
-       movzx    rbx, byte  ptr [r11+rbx]
+       mov      r9d, r9d
+       align    [4 bytes for IG04]
+						;; size=7 bbWeight=0.00 PerfScore 0.00
+G_M31285_IG04:
+       cmp      r9d, ecx
+       jae      SHORT G_M31285_IG09
+       movzx    rbx, byte  ptr [r11+r9]
+       xor      eax, ebx
+       movzx    rax, al
+       cmp      r9d, 100
+       je       SHORT G_M31285_IG06
+						;; size=21 bbWeight=100.00 PerfScore 500.00
+G_M31285_IG05:
+       cmp      ecx, 50
+       jbe      SHORT G_M31285_IG09
+       movzx    rbx, byte  ptr [r11+0x32]
        xor      edx, ebx
        movzx    rdx, dl
-       cmp      eax, 100
-       je       SHORT G_M31285_IG05
-						;; size=21 bbWeight=100.00 PerfScore 525.00
-G_M31285_IG04:
-       cmp      ecx, 50
-       jbe      SHORT G_M31285_IG08
-       movzx    rbx, byte  ptr [r11+0x32]
+       movzx    rbx, byte  ptr [r11+0x19]
        xor      r10d, ebx
        movzx    r10, r10b
-       movzx    rbx, byte  ptr [r11+0x19]
-       xor      r9d, ebx
-       movzx    r9, r9b
-						;; size=29 bbWeight=98.89 PerfScore 618.09
-G_M31285_IG05:
-       inc      eax
-       cmp      eax, r8d
-       jl       SHORT G_M31285_IG03
-						;; size=7 bbWeight=100.00 PerfScore 150.00
+						;; size=27 bbWeight=99.95 PerfScore 624.70
 G_M31285_IG06:
-       mov      eax, r9d
-       xor      eax, r10d
-       xor      eax, edx
-       xor      eax, r10d
-       xor      eax, r9d
-       movzx    rax, al
-						;; size=17 bbWeight=0.00 PerfScore 0.00
+       inc      r9d
+       cmp      r9d, r8d
+       jl       SHORT G_M31285_IG04
+						;; size=8 bbWeight=100.00 PerfScore 150.00
 G_M31285_IG07:
+       mov      ecx, r10d
+       xor      ecx, edx
+       xor      ecx, eax
+       xor      ecx, edx
+       xor      ecx, r10d
+       movzx    rax, cl
+						;; size=15 bbWeight=0.00 PerfScore 0.00
+G_M31285_IG08:
        add      rsp, 168
        pop      rbx
        pop      rbp
        ret      
 						;; size=10 bbWeight=0.00 PerfScore 0.00
-G_M31285_IG08:
+G_M31285_IG09:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 154, prolog size 46, PerfScore 1311.84, instruction count 44, allocated bytes for code 154 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 151, prolog size 46, PerfScore 1293.20, instruction count 44, allocated bytes for code 151 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1)
@@ -442,16 +446,17 @@ G_M31285_IG08:
 ;
 ;  V00 arg0         [V00,T07] (  4,       8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T08] (  3,       3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T06] (  4, 2388426.11)     int  ->   r8         single-def
-;  V03 loc0         [V03,T02] (  4, 4776848.22)   ubyte  ->  r10        
-;  V04 loc1         [V04,T04] (  5, 4726787   )   ubyte  ->   r9        
-;  V05 loc2         [V05,T05] (  5, 4726787   )   ubyte  ->  r11        
+;  V02 arg2         [V02,T06] (  4, 1927398.56)     int  ->   r8         single-def
+;  V03 loc0         [V03,T02] (  4, 3854793.11)   ubyte  ->  r10        
+;  V04 loc1         [V04,T04] (  5, 3852973.67)   ubyte  ->   r9        
+;  V05 loc2         [V05,T05] (  5, 3852973.67)   ubyte  ->  r11        
 ;* V06 loc3         [V06    ] (  0,       0   )   ubyte  ->  zero-ref   
-;  V07 loc4         [V07,T00] (  8,14330540.67)     int  ->  rdx        
+;  V07 loc4         [V07,T09] (  2,       2   )     int  ->  rdx        
 ;  V08 OutArgs      [V08    ] (  1,       1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T01] (  4, 7115208.11)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V10 tmp2         [V10,T03] (  3, 4751816.11)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
+;  V09 tmp1         [V09,T01] (  4, 5780367.22)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V10 tmp2         [V10,T03] (  3, 3853881.89)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V11 tmp3         [V11    ] (  0,       0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[ubyte]>
+;  V12 rat0         [V12,T00] (  8,11564375.33)    long  ->  rdx         "Widened IV V07"
 ;
 ; Lcl frame size = 32
 
@@ -465,20 +470,20 @@ G_M31285_IG02:
        xor      r10d, r10d
        xor      r9d, r9d
        xor      r11d, r11d
+       mov      edx, edx
        cmp      edx, r8d
        jge      SHORT G_M31285_IG06
-       align    [7 bytes for IG03]
-						;; size=27 bbWeight=1 PerfScore 6.25
+       align    [5 bytes for IG03]
+						;; size=27 bbWeight=1 PerfScore 6.50
 G_M31285_IG03:
        cmp      edx, ecx
        jae      SHORT G_M31285_IG08
-       mov      ebx, edx
-       movzx    rbx, byte  ptr [rax+rbx]
+       movzx    rbx, byte  ptr [rax+rdx]
        xor      r10d, ebx
        movzx    r10, r10b
        cmp      edx, 100
        je       SHORT G_M31285_IG05
-						;; size=22 bbWeight=2388423.11 PerfScore 12539221.33
+						;; size=20 bbWeight=1927395.56 PerfScore 9636977.78
 G_M31285_IG04:
        cmp      ecx, 50
        jbe      SHORT G_M31285_IG08
@@ -488,12 +493,12 @@ G_M31285_IG04:
        movzx    rbx, byte  ptr [rax+0x19]
        xor      r11d, ebx
        movzx    r11, r11b
-						;; size=27 bbWeight=2363392 PerfScore 14771200.00
+						;; size=27 bbWeight=1926485.33 PerfScore 12040533.33
 G_M31285_IG05:
        inc      edx
        cmp      edx, r8d
        jl       SHORT G_M31285_IG03
-						;; size=7 bbWeight=2388423.11 PerfScore 3582634.67
+						;; size=7 bbWeight=1927395.56 PerfScore 2891093.33
 G_M31285_IG06:
        mov      eax, r11d
        xor      eax, r9d
@@ -512,6 +517,6 @@ G_M31285_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 118, prolog size 5, PerfScore 30893066.75, instruction count 40, allocated bytes for code 118 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1)
+; Total bytes of code 116, prolog size 5, PerfScore 24568615.44, instruction count 40, allocated bytes for code 116 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``Span.IndexerBench.SameIndex1(length: 1024)``

Hot functions:

- (97.64%) ``IndexerBench.TestSameIndex1`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]IndexerBench.TestSameIndex1(value class System.Span`1<unsigned int8>,int32,int32)``

```diff
 ;  V00 arg0         [V00,T07] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 arg2         [V02,T04] (  4,102   )     int  ->   r8         single-def
-;  V03 loc0         [V03,T03] (  3,199.90)   ubyte  ->  r10        
-;  V04 loc1         [V04,T02] (  4,200.00)   ubyte  ->  rdx        
+;  V03 loc0         [V03,T03] (  3,199.90)   ubyte  ->  rdx        
+;  V04 loc1         [V04,T02] (  4,200.00)   ubyte  ->  rax        
 ;* V05 loc2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V06 loc3         [V06,T00] (  6,499.61)     int  ->  rax        
+;  V06 loc3         [V06,T08] (  2,  0.19)     int  ->  r10        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08,T05] (  2,100.90)   byref  ->   r9         single-def "V00.[000..008)"
 ;  V09 tmp2         [V09,T06] (  2,100.90)     int  ->  rcx         single-def "V00.[008..012)"
 ;  V10 cse0         [V10,T01] (  3,299.71)     int  ->  r11         "CSE #03: aggressive"
+;  V11 rat0         [V11,T00] (  6,499.61)    long  ->  r10         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -135,47 +136,49 @@ G_M481_IG01:
        sub      rsp, 40
        mov      rcx, bword ptr [rsp+0xB0]
        mov      r8d, dword ptr [rsp+0xC0]
-       mov      r10d, dword ptr [rsp+0x64]
-       mov      edx, dword ptr [rsp+0x60]
-       mov      eax, dword ptr [rsp+0x58]
+       mov      edx, dword ptr [rsp+0x64]
+       mov      eax, dword ptr [rsp+0x60]
+       mov      r10d, dword ptr [rsp+0x58]
 						;; size=33 bbWeight=1 PerfScore 10.25
 G_M481_IG02:
        mov      r9, bword ptr [rcx]
        mov      ecx, dword ptr [rcx+0x08]
-       cmp      eax, r8d
-       jge      SHORT G_M481_IG04
-       align    [4 bytes for IG03]
-						;; size=15 bbWeight=1 PerfScore 5.50
+       cmp      r10d, r8d
+       jge      SHORT G_M481_IG05
+						;; size=11 bbWeight=1 PerfScore 5.25
 G_M481_IG03:
-       cmp      eax, ecx
-       jae      SHORT G_M481_IG06
-       mov      r11d, eax
-       movzx    r11, byte  ptr [r9+r11]
-       xor      r10d, r11d
-       movzx    r10, r10b
+       mov      r10d, r10d
+       align    [1 bytes for IG04]
+						;; size=4 bbWeight=0.10 PerfScore 0.05
+G_M481_IG04:
+       cmp      r10d, ecx
+       jae      SHORT G_M481_IG07
+       movzx    r11, byte  ptr [r9+r10]
        xor      edx, r11d
        movzx    rdx, dl
-       inc      eax
-       cmp      eax, r8d
-       jl       SHORT G_M481_IG03
-						;; size=32 bbWeight=99.90 PerfScore 599.41
-G_M481_IG04:
-       mov      eax, edx
-       xor      eax, r10d
-       xor      eax, edx
+       xor      eax, r11d
        movzx    rax, al
-						;; size=10 bbWeight=0.10 PerfScore 0.10
+       inc      r10d
+       cmp      r10d, r8d
+       jl       SHORT G_M481_IG04
+						;; size=30 bbWeight=99.90 PerfScore 574.44
 G_M481_IG05:
+       mov      ecx, eax
+       xor      ecx, edx
+       xor      ecx, eax
+       movzx    rax, cl
+						;; size=9 bbWeight=0.10 PerfScore 0.10
+G_M481_IG06:
        add      rsp, 160
        pop      rbp
        ret      
 						;; size=9 bbWeight=0.10 PerfScore 0.17
-G_M481_IG06:
+G_M481_IG07:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 105, prolog size 33, PerfScore 615.43, instruction count 31, allocated bytes for code 105 (MethodHash=4af3fe1e) for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 102, prolog size 33, PerfScore 590.26, instruction count 31, allocated bytes for code 102 (MethodHash=4af3fe1e) for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Instrumented Tier0)
@@ -294,20 +297,21 @@ G_M481_IG08:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 418775.2
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 681738.4
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T07] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 arg2         [V02,T04] (  4,102   )     int  ->   r8         single-def
-;  V03 loc0         [V03,T03] (  3,200.00)   ubyte  ->  r10        
-;  V04 loc1         [V04,T02] (  4,200.00)   ubyte  ->  rdx        
+;  V03 loc0         [V03,T03] (  3,200.00)   ubyte  ->  rdx        
+;  V04 loc1         [V04,T02] (  4,200.00)   ubyte  ->  rax        
 ;* V05 loc2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V06 loc3         [V06,T00] (  6,500.00)     int  ->  rax        
+;  V06 loc3         [V06,T08] (  2,  0.00)     int  ->  r10        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08,T05] (  2,101.00)   byref  ->   r9         single-def "V00.[000..008)"
 ;  V09 tmp2         [V09,T06] (  2,101.00)     int  ->  rcx         single-def "V00.[008..012)"
 ;  V10 cse0         [V10,T01] (  3,300.00)     int  ->  r11         "CSE #03: aggressive"
+;  V11 rat0         [V11,T00] (  6,500.00)    long  ->  r10         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -315,47 +319,49 @@ G_M481_IG01:
        sub      rsp, 40
        mov      rcx, bword ptr [rsp+0xB0]
        mov      r8d, dword ptr [rsp+0xC0]
-       mov      r10d, dword ptr [rsp+0x64]
-       mov      edx, dword ptr [rsp+0x60]
-       mov      eax, dword ptr [rsp+0x58]
+       mov      edx, dword ptr [rsp+0x64]
+       mov      eax, dword ptr [rsp+0x60]
+       mov      r10d, dword ptr [rsp+0x58]
 						;; size=33 bbWeight=1 PerfScore 10.25
 G_M481_IG02:
        mov      r9, bword ptr [rcx]
        mov      ecx, dword ptr [rcx+0x08]
-       cmp      eax, r8d
-       jge      SHORT G_M481_IG04
-       align    [4 bytes for IG03]
-						;; size=15 bbWeight=1 PerfScore 5.50
+       cmp      r10d, r8d
+       jge      SHORT G_M481_IG05
+						;; size=11 bbWeight=1 PerfScore 5.25
 G_M481_IG03:
-       cmp      eax, ecx
-       jae      SHORT G_M481_IG06
-       mov      r11d, eax
-       movzx    r11, byte  ptr [r9+r11]
-       xor      r10d, r11d
-       movzx    r10, r10b
+       mov      r10d, r10d
+       align    [1 bytes for IG04]
+						;; size=4 bbWeight=0.00 PerfScore 0.00
+G_M481_IG04:
+       cmp      r10d, ecx
+       jae      SHORT G_M481_IG07
+       movzx    r11, byte  ptr [r9+r10]
        xor      edx, r11d
        movzx    rdx, dl
-       inc      eax
-       cmp      eax, r8d
-       jl       SHORT G_M481_IG03
-						;; size=32 bbWeight=100.00 PerfScore 600.00
-G_M481_IG04:
-       mov      eax, edx
-       xor      eax, r10d
-       xor      eax, edx
+       xor      eax, r11d
        movzx    rax, al
-						;; size=10 bbWeight=0.00 PerfScore 0.00
+       inc      r10d
+       cmp      r10d, r8d
+       jl       SHORT G_M481_IG04
+						;; size=30 bbWeight=100.00 PerfScore 575.00
 G_M481_IG05:
+       mov      ecx, eax
+       xor      ecx, edx
+       xor      ecx, eax
+       movzx    rax, cl
+						;; size=9 bbWeight=0.00 PerfScore 0.00
+G_M481_IG06:
        add      rsp, 160
        pop      rbp
        ret      
 						;; size=9 bbWeight=0.00 PerfScore 0.00
-G_M481_IG06:
+G_M481_IG07:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 105, prolog size 33, PerfScore 615.75, instruction count 31, allocated bytes for code 105 (MethodHash=4af3fe1e) for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 102, prolog size 33, PerfScore 590.50, instruction count 31, allocated bytes for code 102 (MethodHash=4af3fe1e) for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1)
@@ -370,16 +376,17 @@ G_M481_IG06:
 ;
 ;  V00 arg0         [V00,T07] (  4,       8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T08] (  3,       3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T04] (  4, 2329261.67)     int  ->   r8         single-def
-;  V03 loc0         [V03,T03] (  4, 4658519.33)   ubyte  ->  r10        
-;  V04 loc1         [V04,T02] (  5, 4658520.33)   ubyte  ->   r9        
+;  V02 arg2         [V02,T04] (  4, 3789258.11)     int  ->   r8         single-def
+;  V03 loc0         [V03,T03] (  4, 7578512.22)   ubyte  ->  r10        
+;  V04 loc1         [V04,T02] (  5, 7578513.22)   ubyte  ->   r9        
 ;* V05 loc2         [V05    ] (  0,       0   )   ubyte  ->  zero-ref   
-;  V06 loc3         [V06,T00] (  7,11646295.33)     int  ->  rdx        
+;  V06 loc3         [V06,T09] (  2,       2   )     int  ->  rdx        
 ;  V07 OutArgs      [V07    ] (  1,       1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T05] (  2, 2329259.67)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V09 tmp2         [V09,T06] (  2, 2329259.67)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
+;  V08 tmp1         [V08,T05] (  2, 3789256.11)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V09 tmp2         [V09,T06] (  2, 3789256.11)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V10 tmp3         [V10    ] (  0,       0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[ubyte]>
-;  V11 cse0         [V11,T01] (  3, 6987776   )     int  ->  r11         "CSE #03: aggressive"
+;  V11 cse0         [V11,T01] (  3,11367765.33)     int  ->  r11         "CSE #03: aggressive"
+;  V12 rat0         [V12,T00] (  7,18946277.56)    long  ->  rdx         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -391,15 +398,15 @@ G_M481_IG02:
        mov      ecx, dword ptr [rcx+0x08]
        xor      r10d, r10d
        xor      r9d, r9d
+       mov      edx, edx
        cmp      edx, r8d
        jge      SHORT G_M481_IG04
-       align    [0 bytes for IG03]
-						;; size=17 bbWeight=1 PerfScore 5.75
+       align    [9 bytes for IG03]
+						;; size=28 bbWeight=1 PerfScore 6.25
 G_M481_IG03:
        cmp      edx, ecx
        jae      SHORT G_M481_IG06
-       mov      r11d, edx
-       movzx    r11, byte  ptr [rax+r11]
+       movzx    r11, byte  ptr [rax+rdx]
        xor      r10d, r11d
        movzx    r10, r10b
        xor      r9d, r11d
@@ -407,7 +414,7 @@ G_M481_IG03:
        inc      edx
        cmp      edx, r8d
        jl       SHORT G_M481_IG03
-						;; size=33 bbWeight=2329258.67 PerfScore 13975552.00
+						;; size=30 bbWeight=3789255.11 PerfScore 21788216.89
 G_M481_IG04:
        mov      eax, r9d
        xor      eax, r10d
@@ -423,6 +430,6 @@ G_M481_IG06:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 77, prolog size 4, PerfScore 13975560.25, instruction count 27, allocated bytes for code 77 (MethodHash=4af3fe1e) for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1)
+; Total bytes of code 85, prolog size 4, PerfScore 21788225.64, instruction count 27, allocated bytes for code 85 (MethodHash=4af3fe1e) for method Span.IndexerBench:TestSameIndex1(System.Span`1[ubyte],int,int):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Numerics.Tests.Perf_BitOperations.PopCount_uint``

Hot functions:

- (97.71%) ``Perf_BitOperations.PopCount_uint`` (Tier-1)
  - No diffs
- (1.62%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

# ``System.Numerics.Tests.Perf_BitOperations.PopCount_ulong``

Hot functions:

- (97.45%) ``Perf_BitOperations.PopCount_ulong`` (Tier-1)
  - No diffs

# ``System.Collections.CtorFromCollection<String>.ConcurrentQueue(Size: 512)``

Hot functions:

- (50.04%) ``System.Collections.Concurrent.ConcurrentQueue`1..ctor`` (Tier-1)
  - **Has diffs**
- (9.64%) ``System.Collections.Concurrent.ConcurrentQueueSegment`1..ctor`` (Tier-1)
  - **Has diffs**
- (5.41%) ``System.SZGenericArrayEnumerator`1.get_Current`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]..ctor(class System.Collections.Generic.IEnumerable`1<!0>)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 666
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 740
 ; 4 inlinees with PGO data; 3 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T13] (  9,1029.62)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]>
-;  V01 arg1         [V01,T18] (  5,   5   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[System.__Canon]>
-;  V02 loc0         [V02,T34] (  3,   3.00)     int  ->  rsi        
-;  V03 loc1         [V03,T33] (  3,   3.00)     ref  ->  r14         class-hnd single-def <<unknown class>>
-;  V04 loc2         [V04,T31] (  3,   3.00)     int  ->  rax        
+;  V00 this         [V00,T12] ( 12,1026.89)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]>
+;  V01 arg1         [V01,T23] (  5,   5   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[System.__Canon]>
+;  V02 loc0         [V02,T39] (  3,   3.00)     int  ->  rsi        
+;  V03 loc1         [V03,T38] (  3,   3.00)     ref  ->  r14         class-hnd single-def <<unknown class>>
+;  V04 loc2         [V04,T36] (  3,   3.00)     int  ->  rax        
 ;* V05 loc3         [V05    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
-;  V06 loc4         [V06,T01] ( 12,3587.65)     ref  ->  [rbp-0x48]  class-hnd EH-live single-def <<unknown class>>
-;  V07 loc5         [V07,T14] (  3,1023.62)     ref  ->  rdx         class-hnd <System.__Canon>
+;  V06 loc4         [V06,T04] ( 20,2563.31)     ref  ->  [rbp-0x50]  class-hnd EH-live single-def <<unknown class>>
+;  V07 loc5         [V07,T14] (  6,1020.89)     ref  ->  rdx         class-hnd <System.__Canon>
 ;  V08 OutArgs      [V08    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T29] (  2,   4   )     ref  ->  rax         class-hnd exact single-def "NewObj constructor temp" <System.Object>
+;  V09 tmp1         [V09,T34] (  2,   4   )     ref  ->  rax         class-hnd exact single-def "NewObj constructor temp" <System.Object>
 ;* V10 tmp2         [V10    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
-;  V11 tmp3         [V11,T17] (  4,   8   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
+;  V11 tmp3         [V11,T22] (  4,   8   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
 ;* V12 tmp4         [V12    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V13 tmp5         [V13    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
-;  V14 tmp6         [V14,T20] (  4,   6   )    long  ->  r11         "VirtualCall with runtime lookup"
+;  V14 tmp6         [V14,T25] (  4,   6   )    long  ->  r11         "VirtualCall with runtime lookup"
 ;* V15 tmp7         [V15    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
-;  V16 tmp8         [V16,T03] (  4,3070.85)    long  ->  r11         "VirtualCall with runtime lookup"
+;  V16 tmp8         [V16,T02] (  8,3062.66)    long  ->  r11         "VirtualCall with runtime lookup"
 ;* V17 tmp9         [V17    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
-;  V18 tmp10        [V18,T19] (  4,   6.01)    long  ->  r11         "VirtualCall with runtime lookup"
-;  V19 tmp11        [V19,T06] (  2,1025.62)     int  ->  rax         "guarded devirt return temp"
+;  V18 tmp10        [V18,T24] (  4,   6.01)    long  ->  r11         "VirtualCall with runtime lookup"
+;  V19 tmp11        [V19,T13] (  2,   0   )     int  ->  rax         "guarded devirt return temp"
 ;* V20 tmp12        [V20    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
 ;* V21 tmp13        [V21    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
-;  V22 tmp14        [V22,T32] (  3,   3.00)     int  ->  rsi         "Inline return value spill temp"
+;  V22 tmp14        [V22,T37] (  3,   3.00)     int  ->  rsi         "Inline return value spill temp"
 ;* V23 tmp15        [V23    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V24 tmp16        [V24,T35] (  2,   2.00)     int  ->  rsi         "Inline return value spill temp"
+;  V24 tmp16        [V24,T40] (  2,   2.00)     int  ->  rsi         "Inline return value spill temp"
 ;* V25 tmp17        [V25,T16] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V26 tmp18        [V26,T00] (  5,5118.08)     ref  ->  rdi         class-hnd exact "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
-;  V27 tmp19        [V27,T10] (  3,1535.42)     ref  ->  r14         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V28 tmp20        [V28,T02] (  6,3070.85)     int  ->  [rbp-0x3C]  spill-single-def "Inline stloc first use temp"
-;  V29 tmp21        [V29,T11] (  3,1535.42)     int  ->  r11         "Inline stloc first use temp"
+;  V26 tmp18        [V26,T00] ( 10,5104.43)     ref  ->  rdi         class-hnd exact "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
+;  V27 tmp19        [V27,T08] (  6,1531.33)     ref  ->  r14         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V28 tmp20        [V28,T01] ( 12,3062.66)     int  ->  [rbp-0x44]  "Inline stloc first use temp"
+;  V29 tmp21        [V29,T09] (  6,1531.33)     int  ->  r15         "Inline stloc first use temp"
 ;* V30 tmp22        [V30    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V31 tmp23        [V31,T15] (  3,1023.62)     int  ->   r8         "Inline stloc first use temp"
-;  V32 tmp24        [V32,T09] (  3,1537.42)     int  ->  rcx         "Inline stloc first use temp"
-;  V33 tmp25        [V33,T30] (  2,   4   )    long  ->  rax         "argument with side effect"
-;  V34 PSPSym       [V34,T36] (  1,   1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
-;  V35 cse0         [V35,T07] (  4,2047.23)   byref  ->  r15         "CSE #05: aggressive"
-;  V36 cse1         [V36,T08] (  3,1538.42)     int  ->  rsi         "CSE #07: aggressive"
-;  V37 cse2         [V37,T12] (  3,1535.42)     int  ->  r13         "CSE #06: aggressive"
-;  V38 cse3         [V38,T22] (  8,   5.60)    long  ->  rdi         "CSE #01: moderate"
-;  V39 rat0         [V39,T26] (  3,   4.40)    long  ->  rdx         "Spilling to split statement for tree"
-;  V40 rat1         [V40,T27] (  3,   4   )    long  ->  rax         "runtime lookup"
-;  V41 rat2         [V41,T23] (  3,   5.60)    long  ->  rax         "fgMakeTemp is creating a new local variable"
-;  V42 rat3         [V42,T21] (  3,   5.61)    long  ->  r11         "fgMakeTemp is creating a new local variable"
-;  V43 rat4         [V43,T28] (  3,   4   )    long  ->  rcx         "runtime lookup"
-;  V44 rat5         [V44,T24] (  3,   5.60)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
-;  V45 rat6         [V45,T25] (  3,   5.60)    long  ->  r11         "fgMakeTemp is creating a new local variable"
-;  V46 rat7         [V46,T05] (  3,2251.95)    long  ->  rdx         "Spilling to split statement for tree"
-;  V47 rat8         [V47,T04] (  3,2866.12)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V31 tmp23        [V31,T15] (  6,1020.89)     int  ->   r8         "Inline stloc first use temp"
+;  V32 tmp24        [V32,T07] (  6,1533.31)     int  ->  rax         "Inline stloc first use temp"
+;  V33 tmp25        [V33,T35] (  2,   4   )    long  ->  rax         "argument with side effect"
+;  V34 PSPSym       [V34,T41] (  1,   1   )    long  ->  [rbp-0x60]  do-not-enreg[V] "PSPSym"
+;  V35 cse0         [V35,T06] (  4,2021.36)   byref  ->  r13         "CSE #05: aggressive"
+;  V36 cse1         [V36,T19] (  4,  20.42)   byref  ->  rsi         "CSE #12: moderate"
+;  V37 cse2         [V37,T10] (  3,1518.99)     int  ->  rsi         "CSE #07: aggressive"
+;  V38 cse3         [V38,T20] (  3,  15.34)     int  ->  r13         "CSE #16: moderate"
+;  V39 cse4         [V39,T11] (  3,1516.02)     int  ->  r12         "CSE #06: aggressive"
+;  V40 cse5         [V40,T21] (  3,  15.31)     int  ->  r15         "CSE #13: moderate"
+;  V41 cse6         [V41,T27] (  8,   5.60)    long  ->  rdi         "CSE #01: moderate"
+;  V42 rat0         [V42,T31] (  3,   4.40)    long  ->  rdx         "Spilling to split statement for tree"
+;  V43 rat1         [V43,T32] (  3,   4   )    long  ->  rax         "runtime lookup"
+;  V44 rat2         [V44,T28] (  3,   5.60)    long  ->  rax         "fgMakeTemp is creating a new local variable"
+;  V45 rat3         [V45,T26] (  3,   5.61)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V46 rat4         [V46,T33] (  3,   4   )    long  ->  rcx         "runtime lookup"
+;  V47 rat5         [V47,T29] (  3,   5.60)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V48 rat6         [V48,T30] (  3,   5.60)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V49 rat7         [V49,T05] (  3,2223.49)    long  ->  rdx         "Spilling to split statement for tree"
+;  V50 rat8         [V50,T03] (  3,2829.90)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V51 rat9         [V51,T18] (  3,  22.46)    long  ->  rdx         "Spilling to split statement for tree"
+;  V52 rat10        [V52,T17] (  3,  28.58)    long  ->  r11         "fgMakeTemp is creating a new local variable"
 ;
-; Lcl frame size = 64
+; Lcl frame size = 72
 
 G_M38014_IG01:
        push     rbp
        push     r15
        push     r14
        push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 64
-       lea      rbp, [rsp+0x70]
-       mov      qword ptr [rbp-0x50], rsp
-       mov      qword ptr [rbp-0x38], rcx
+       sub      rsp, 72
+       lea      rbp, [rsp+0x80]
+       mov      qword ptr [rbp-0x60], rsp
+       mov      qword ptr [rbp-0x40], rcx
        mov      gword ptr [rbp+0x10], rcx
        mov      rbx, rdx
-						;; size=34 bbWeight=1 PerfScore 11.00
+						;; size=39 bbWeight=1 PerfScore 12.00
 G_M38014_IG02:
        test     rbx, rbx
-       je       G_M38014_IG26
+       je       G_M38014_IG40
        mov      rcx, 0xD1FFAB1E      ; System.Object
        call     CORINFO_HELP_NEWSFAST
        mov      rcx, gword ptr [rbp+0x10]
@@ -411,7 +417,7 @@ G_M38014_IG02:
        mov      rax, qword ptr [rax]
        mov      rax, qword ptr [rax+0x38]
        test     rax, rax
-       je       G_M38014_IG21
+       je       G_M38014_IG37
 						;; size=75 bbWeight=1 PerfScore 16.00
 G_M38014_IG03:
        mov      rcx, rax
@@ -426,7 +432,7 @@ G_M38014_IG04:
        mov      rcx, qword ptr [rcx]
        mov      r11, qword ptr [rcx+0x58]
        test     r11, r11
-       je       G_M38014_IG22
+       je       G_M38014_IG36
 						;; size=20 bbWeight=1.00 PerfScore 7.26
 G_M38014_IG05:
        mov      rcx, r14
@@ -447,7 +453,7 @@ G_M38014_IG06:
        mov      rcx, qword ptr [rcx]
        mov      rcx, qword ptr [rcx+0x40]
        test     rcx, rcx
-       je       G_M38014_IG23
+       je       G_M38014_IG38
 						;; size=20 bbWeight=1 PerfScore 7.25
 G_M38014_IG07:
        call     CORINFO_HELP_NEWSFAST
@@ -467,189 +473,287 @@ G_M38014_IG07:
        mov      rcx, qword ptr [rcx]
        mov      r11, qword ptr [rcx+0x48]
        test     r11, r11
-       je       G_M38014_IG24
+       je       G_M38014_IG39
 						;; size=71 bbWeight=1 PerfScore 17.50
 G_M38014_IG08:
        mov      rcx, rbx
        call     [r11]
        mov      rbx, rax
-       mov      gword ptr [rbp-0x48], rbx
+       mov      gword ptr [rbp-0x50], rbx
 						;; size=13 bbWeight=1 PerfScore 4.50
 G_M38014_IG09:
-       jmp      G_M38014_IG15
-						;; size=5 bbWeight=1 PerfScore 2.00
+       test     rbx, rbx
+       je       G_M38014_IG26
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbx], rcx
+       jne      G_M38014_IG26
+       jmp      G_M38014_IG18
+       align    [1 bytes for IG12]
+						;; size=34 bbWeight=1 PerfScore 7.50
 G_M38014_IG10:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M38014_IG11:
-       test     r8d, r8d
-       jge      SHORT G_M38014_IG14
-       mov      rcx, gword ptr [rbp+0x10]
-       call     [<unknown method>]
-       jmp      SHORT G_M38014_IG15
-						;; size=17 bbWeight=0 PerfScore 0.00
-G_M38014_IG12:
        mov      rcx, gword ptr [rbp+0x10]
        mov      rdx, qword ptr [rcx]
        mov      rax, qword ptr [rdx+0x30]
        mov      rax, qword ptr [rax]
        mov      r11, qword ptr [rax+0x50]
        test     r11, r11
-       je       G_M38014_IG18
-						;; size=27 bbWeight=511.81 PerfScore 5246.03
-G_M38014_IG13:
+       je       SHORT G_M38014_IG14
+						;; size=23 bbWeight=505.34 PerfScore 5179.72
+G_M38014_IG11:
        mov      rcx, rbx
        call     [r11]
        mov      rdx, rax
        mov      rcx, gword ptr [rbp+0x10]
        mov      rdi, gword ptr [rcx+0x10]
        mov      r14, gword ptr [rdi+0x08]
-						;; size=21 bbWeight=511.81 PerfScore 4350.37
-G_M38014_IG14:
+						;; size=21 bbWeight=505.34 PerfScore 4295.38
+G_M38014_IG12:
        mov      eax, dword ptr [rdi+0xA0]
-       mov      dword ptr [rbp-0x3C], eax
-       mov      r11d, eax
-       and      r11d, dword ptr [rdi+0x18]
-       cmp      r11d, dword ptr [r14+0x08]
-       jae      SHORT G_M38014_IG10
-       shl      r11, 4
-       lea      r15, bword ptr [r14+r11+0x10]
-       mov      r8d, dword ptr [r15+0x08]
+       mov      r15d, eax
+       and      r15d, dword ptr [rdi+0x18]
+       cmp      r15d, dword ptr [r14+0x08]
+       jae      SHORT G_M38014_IG15
+       mov      r8d, r15d
+       shl      r8, 4
+       lea      r13, bword ptr [r14+r8+0x10]
+       mov      r8d, dword ptr [r13+0x08]
        sub      r8d, eax
-       jne      SHORT G_M38014_IG11
-       lea      r11, bword ptr [rdi+0xA0]
-       lea      r13d, [rax+0x01]
+       jne      SHORT G_M38014_IG16
+       lea      r8, bword ptr [rdi+0xA0]
+       lea      r12d, [rax+0x01]
+       mov      dword ptr [rbp-0x44], eax
        lock     
-       cmpxchg  dword ptr [r11], r13d
-       cmp      eax, dword ptr [rbp-0x3C]
-       jne      SHORT G_M38014_IG14
-       mov      rcx, r15
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      dword ptr [r15+0x08], r13d
-						;; size=73 bbWeight=511.81 PerfScore 20088.46
-G_M38014_IG15:
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       cmp      qword ptr [rbx], rcx
-       jne      SHORT G_M38014_IG19
-       mov      ecx, dword ptr [rbx+0x08]
-       inc      ecx
-       mov      esi, dword ptr [rbx+0x0C]
-       cmp      ecx, esi
-       jae      SHORT G_M38014_IG17
-						;; size=27 bbWeight=512.81 PerfScore 4999.88
-G_M38014_IG16:
-       mov      dword ptr [rbx+0x08], ecx
-       jmp      G_M38014_IG12
-						;; size=8 bbWeight=511.81 PerfScore 1535.42
-G_M38014_IG17:
-       mov      dword ptr [rbx+0x08], esi
-       jmp      G_M38014_IG25
-						;; size=8 bbWeight=512.81 PerfScore 1538.42
-G_M38014_IG18:
+       cmpxchg  dword ptr [r8], r12d
+       cmp      eax, dword ptr [rbp-0x44]
+       jne      SHORT G_M38014_IG12
+						;; size=64 bbWeight=505.34 PerfScore 18823.87
+G_M38014_IG13:
+       jmp      SHORT G_M38014_IG17
+						;; size=2 bbWeight=505.34 PerfScore 1010.68
+G_M38014_IG14:
        mov      rcx, rdx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      r11, rax
-       jmp      G_M38014_IG13
-						;; size=26 bbWeight=102.36 PerfScore 383.86
+       jmp      SHORT G_M38014_IG11
+						;; size=23 bbWeight=101.07 PerfScore 379.00
+G_M38014_IG15:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M38014_IG16:
+       test     r8d, r8d
+       jge      SHORT G_M38014_IG12
+       jmp      G_M38014_IG32
+       align    [0 bytes for IG23]
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M38014_IG17:
+       mov      rcx, r13
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      dword ptr [r13+0x08], r12d
+						;; size=12 bbWeight=505.34 PerfScore 1137.01
+G_M38014_IG18:
+       mov      eax, dword ptr [rbx+0x08]
+       inc      eax
+       mov      esi, dword ptr [rbx+0x0C]
+       cmp      eax, esi
+       jae      SHORT G_M38014_IG20
+						;; size=12 bbWeight=506.33 PerfScore 2784.81
 G_M38014_IG19:
-       mov      rcx, rbx
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M38014_IG12
-						;; size=24 bbWeight=512.81 PerfScore 2435.84
+       mov      dword ptr [rbx+0x08], eax
+       jmp      G_M38014_IG10
+						;; size=8 bbWeight=505.32 PerfScore 1515.97
 G_M38014_IG20:
-       jmp      G_M38014_IG27
-						;; size=5 bbWeight=1 PerfScore 2.00
+       mov      dword ptr [rbx+0x08], esi
+       jmp      G_M38014_IG34
+						;; size=8 bbWeight=506.33 PerfScore 1518.99
 G_M38014_IG21:
+       mov      rcx, gword ptr [rbp+0x10]
+       mov      rdx, qword ptr [rcx]
+       mov      rax, qword ptr [rdx+0x30]
+       mov      rax, qword ptr [rax]
+       mov      r11, qword ptr [rax+0x50]
+       test     r11, r11
+       je       SHORT G_M38014_IG25
+						;; size=23 bbWeight=5.10 PerfScore 52.32
+G_M38014_IG22:
+       mov      rcx, rbx
+       call     [r11]
+       mov      rdx, rax
+       mov      rcx, gword ptr [rbp+0x10]
+       mov      rdi, gword ptr [rcx+0x10]
+       mov      r14, gword ptr [rdi+0x08]
+						;; size=21 bbWeight=5.10 PerfScore 43.39
+G_M38014_IG23:
+       mov      eax, dword ptr [rdi+0xA0]
+       mov      r15d, eax
+       and      r15d, dword ptr [rdi+0x18]
+       cmp      r15d, dword ptr [r14+0x08]
+       jae      SHORT G_M38014_IG15
+       mov      r8d, r15d
+       shl      r8, 4
+       lea      rsi, bword ptr [r14+r8+0x10]
+       mov      r8d, dword ptr [rsi+0x08]
+       sub      r8d, eax
+       jne      SHORT G_M38014_IG31
+       lea      r8, bword ptr [rdi+0xA0]
+       lea      r15d, [rax+0x01]
+       mov      dword ptr [rbp-0x44], eax
+       lock     
+       cmpxchg  dword ptr [r8], r15d
+       cmp      eax, dword ptr [rbp-0x44]
+       jne      SHORT G_M38014_IG23
+						;; size=64 bbWeight=5.10 PerfScore 190.14
+G_M38014_IG24:
+       jmp      SHORT G_M38014_IG29
+						;; size=2 bbWeight=5.10 PerfScore 10.21
+G_M38014_IG25:
        mov      rcx, rdx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp      G_M38014_IG03
-						;; size=23 bbWeight=0.20 PerfScore 0.70
-G_M38014_IG22:
+       mov      r11, rax
+       jmp      SHORT G_M38014_IG22
+						;; size=23 bbWeight=1.02 PerfScore 3.83
+G_M38014_IG26:
+       mov      rdx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbx], rdx
+       jne      SHORT G_M38014_IG33
+       mov      eax, dword ptr [rbx+0x08]
+       inc      eax
+       mov      r13d, dword ptr [rbx+0x0C]
+       cmp      eax, r13d
+       jae      SHORT G_M38014_IG28
+						;; size=29 bbWeight=5.11 PerfScore 49.87
+G_M38014_IG27:
+       mov      dword ptr [rbx+0x08], eax
+       jmp      G_M38014_IG21
+						;; size=8 bbWeight=5.10 PerfScore 15.31
+G_M38014_IG28:
+       mov      dword ptr [rbx+0x08], r13d
+       jmp      SHORT G_M38014_IG34
+						;; size=6 bbWeight=5.11 PerfScore 15.34
+G_M38014_IG29:
+       mov      rcx, rsi
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      dword ptr [rsi+0x08], r15d
+       jmp      SHORT G_M38014_IG26
+						;; size=14 bbWeight=5.10 PerfScore 21.69
+G_M38014_IG30:
+       mov      rcx, gword ptr [rbp+0x10]
+       call     [<unknown method>]
+       jmp      SHORT G_M38014_IG26
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M38014_IG31:
+       test     r8d, r8d
+       jge      G_M38014_IG23
+       jmp      SHORT G_M38014_IG30
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M38014_IG32:
+       call     [<unknown method>]
+       jmp      G_M38014_IG18
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M38014_IG33:
+       mov      rcx, rbx
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      G_M38014_IG21
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M38014_IG34:
+       mov      rdx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbx], rdx
+       jne      G_M38014_IG41
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M38014_IG35:
+       add      rsp, 72
+       pop      rbx
+       pop      rsi
+       pop      rdi
+       pop      r12
+       pop      r13
+       pop      r14
+       pop      r15
+       pop      rbp
+       ret      
+						;; size=17 bbWeight=1 PerfScore 5.25
+G_M38014_IG36:
        mov      rcx, rdi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      r11, rax
        jmp      G_M38014_IG05
 						;; size=26 bbWeight=0.20 PerfScore 0.75
-G_M38014_IG23:
+G_M38014_IG37:
+       mov      rcx, rdx
+       mov      rdx, 0xD1FFAB1E      ; global ptr
+       call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp      G_M38014_IG03
+						;; size=23 bbWeight=0.20 PerfScore 0.70
+G_M38014_IG38:
        mov      rcx, rdi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
        jmp      G_M38014_IG07
 						;; size=26 bbWeight=0.20 PerfScore 0.75
-G_M38014_IG24:
+G_M38014_IG39:
        mov      rcx, rdi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      r11, rax
        jmp      G_M38014_IG08
 						;; size=26 bbWeight=0.20 PerfScore 0.75
-G_M38014_IG25:
-       add      rsp, 64
-       pop      rbx
-       pop      rsi
-       pop      rdi
-       pop      r13
-       pop      r14
-       pop      r15
-       pop      rbp
-       ret      
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M38014_IG26:
+G_M38014_IG40:
        mov      ecx, 23
        call     [System.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M38014_IG27:
+G_M38014_IG41:
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M38014_IG25
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M38014_IG28:
+       jmp      G_M38014_IG35
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M38014_IG42:
        push     rbp
        push     r15
        push     r14
        push     r13
+       push     r12
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 48
+       sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x70]
-						;; size=27 bbWeight=0 PerfScore 0.00
-G_M38014_IG29:
-       cmp      gword ptr [rbp-0x48], 0
-       je       SHORT G_M38014_IG30
+       lea      rbp, [rbp+0x80]
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M38014_IG43:
+       cmp      gword ptr [rbp-0x50], 0
+       je       SHORT G_M38014_IG44
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       mov      rbx, gword ptr [rbp-0x48]
+       mov      rbx, gword ptr [rbp-0x50]
        cmp      qword ptr [rbx], rcx
-       je       SHORT G_M38014_IG30
+       je       SHORT G_M38014_IG44
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M38014_IG30:
+G_M38014_IG44:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M38014_IG31:
-       add      rsp, 48
+G_M38014_IG45:
+       add      rsp, 40
        pop      rbx
        pop      rsi
        pop      rdi
+       pop      r12
        pop      r13
        pop      r14
        pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0 PerfScore 0.00
+						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 778, prolog size 34, PerfScore 40666.99, instruction count 208, allocated bytes for code 778 (MethodHash=ba4f6b81) for method System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]:.ctor(System.Collections.Generic.IEnumerable`1[System.__Canon]):this (Tier1)
+; Total bytes of code 1038, prolog size 39, PerfScore 37145.51, instruction count 279, allocated bytes for code 1042 (MethodHash=ba4f6b81) for method System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]:.ctor(System.Collections.Generic.IEnumerable`1[System.__Canon]):this (Tier1)
 ; ============================================================
 


```

### ``[System.Private.CoreLib]System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]..ctor(int32)``

```diff
 ;
 ;  V00 this         [V00,T03] (  7, 38   )     ref  ->  rbx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
 ;  V01 arg1         [V01,T04] (  4,  4   )     int  ->  rsi         single-def
-;  V02 loc0         [V02,T00] (  7,193   )     int  ->  rsi        
+;* V02 loc0         [V02,T08] (  0,  0   )     int  ->  zero-ref   
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 tmp1         [V04,T07] (  3,  4   )    long  ->  rcx         "spilling helperCall"
 ;  V05 tmp2         [V05,T01] (  3,192   )     ref  ->  rax         "arr expr"
 ;  V06 cse0         [V06,T02] (  3, 96   )     ref  ->  rcx         "CSE #01: aggressive"
-;  V07 rat0         [V07,T06] (  3,  4.40)    long  ->  rcx         "Spilling to split statement for tree"
-;  V08 rat1         [V08,T05] (  3,  5.60)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V07 rat0         [V07,T00] (  7,193   )    long  ->  rsi         "Widened IV V02"
+;  V08 rat1         [V08,T06] (  3,  4.40)    long  ->  rcx         "Spilling to split statement for tree"
+;  V09 rat2         [V09,T05] (  3,  5.60)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
 ;
 ; Lcl frame size = 40
 
@@ -66,13 +67,13 @@ G_M62791_IG06:
        mov      rax, rcx
        cmp      esi, dword ptr [rax+0x08]
        jae      SHORT G_M62791_IG09
-       mov      edx, esi
+       mov      rdx, rsi
        shl      rdx, 4
        mov      dword ptr [rax+rdx+0x18], esi
        inc      esi
        cmp      dword ptr [rcx+0x08], esi
        jg       SHORT G_M62791_IG06
-						;; size=44 bbWeight=32 PerfScore 432.00
+						;; size=45 bbWeight=32 PerfScore 432.00
 G_M62791_IG07:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
@@ -89,7 +90,7 @@ G_M62791_IG09:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 168, prolog size 16, PerfScore 461.35, instruction count 49, allocated bytes for code 168 (MethodHash=ae010ab8) for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Instrumented Tier1)
+; Total bytes of code 169, prolog size 16, PerfScore 461.35, instruction count 49, allocated bytes for code 169 (MethodHash=ae010ab8) for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Instrumented Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Tier1)
@@ -99,19 +100,20 @@ G_M62791_IG09:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 936
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1113
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] (  7, 511.30)     ref  ->  rbx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
+;  V00 this         [V00,T03] (  7, 510.06)     ref  ->  rbx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
 ;  V01 arg1         [V01,T04] (  4,   4   )     int  ->  rsi         single-def
-;  V02 loc0         [V02,T00] (  7,3032.79)     int  ->  rax        
+;* V02 loc0         [V02,T08] (  0,   0   )     int  ->  zero-ref   
 ;  V03 OutArgs      [V03    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 tmp1         [V04,T07] (  3,   4   )    long  ->  rcx         "spilling helperCall"
-;  V05 tmp2         [V05,T01] (  3,3031.79)     ref  ->  rdx         "arr expr"
-;  V06 cse0         [V06,T02] (  3,1515.90)     ref  ->  rcx         "CSE #01: aggressive"
-;  V07 rat0         [V07,T06] (  3,   4.40)    long  ->  rcx         "Spilling to split statement for tree"
-;  V08 rat1         [V08,T05] (  3,   5.60)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V05 tmp2         [V05,T01] (  3,3024.39)     ref  ->  rdx         "arr expr"
+;  V06 cse0         [V06,T02] (  3,1512.19)     ref  ->  rcx         "CSE #01: aggressive"
+;  V07 rat0         [V07,T00] (  7,3025.39)    long  ->  rax         "Widened IV V02"
+;  V08 rat1         [V08,T06] (  3,   4.40)    long  ->  rcx         "Spilling to split statement for tree"
+;  V09 rat2         [V09,T05] (  3,   5.60)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
 ;
 ; Lcl frame size = 40
 
@@ -159,13 +161,13 @@ G_M62791_IG06:
        mov      rdx, rcx
        cmp      eax, dword ptr [rdx+0x08]
        jae      SHORT G_M62791_IG08
-       mov      r8d, eax
+       mov      r8, rax
        shl      r8, 4
        mov      dword ptr [rdx+r8+0x18], eax
        inc      eax
        cmp      dword ptr [rcx+0x08], eax
        jg       SHORT G_M62791_IG06
-						;; size=31 bbWeight=505.30 PerfScore 6189.91
+						;; size=31 bbWeight=504.06 PerfScore 6174.79
 G_M62791_IG07:
        add      rsp, 40
        pop      rbx
@@ -177,6 +179,6 @@ G_M62791_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 140, prolog size 16, PerfScore 6217.76, instruction count 45, allocated bytes for code 140 (MethodHash=ae010ab8) for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Tier1)
+; Total bytes of code 140, prolog size 16, PerfScore 6202.64, instruction count 45, allocated bytes for code 140 (MethodHash=ae010ab8) for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Perf_Frozen<Int16>.ToFrozenDictionary(Count: 64)``

Hot functions:

- (41.58%) ``FrozenHashTable.CalcNumBuckets`` (Tier-1)
  - **Has diffs**
- (39.26%) ``System.Collections.Frozen.KeysAndValuesFrozenDictionary`2..ctor`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Collections.Immutable]FrozenHashTable.CalcNumBuckets(value class System.ReadOnlySpan`1<int32>,bool)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 33128
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 34256
 ; 19 inlinees with PGO data; 36 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T30] (  4,   8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T40] (  3,   3   )   ubyte  ->  rdx         single-def
+;  V00 arg0         [V00,T31] (  4,   8   )   byref  ->  rcx         ld-addr-op single-def
+;  V01 arg1         [V01,T43] (  3,   3   )   ubyte  ->  rdx         single-def
 ;* V02 loc0         [V02    ] (  0,   0   )  struct (24) zero-ref    ld-addr-op <System.Collections.Frozen.FrozenHashTable+<>c__DisplayClass10_0>
-;  V03 loc1         [V03,T32] (  8,   7.94)     ref  ->  [rsp+0x98]  class-hnd <System.Collections.Generic.HashSet`1[int]>
-;  V04 loc2         [V04,T31] (  9,   9.03)     int  ->  rbp        
-;  V05 loc3         [V05,T26] (  2,  13.89)     int  ->  rcx        
+;  V03 loc1         [V03,T34] (  8,   7.89)     ref  ->  [rsp+0x98]  class-hnd <System.Collections.Generic.HashSet`1[int]>
+;  V04 loc2         [V04,T33] (  9,   9.04)     int  ->  rbp        
+;  V05 loc3         [V05,T25] (  2,  14.01)     int  ->  rcx        
 ;* V06 loc4         [V06    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[int]>
-;  V07 loc5         [V07,T15] (  8,  53.60)     int  ->  r15        
-;  V08 loc6         [V08,T24] (  6,  17.05)     int  ->  r13        
-;  V09 loc7         [V09,T14] ( 10,  58.07)     int  ->  r12        
-;  V10 loc8         [V10,T37] (  3,   6.02)     int  ->  [rsp+0x114] 
+;  V07 loc5         [V07,T42] (  4,   4.04)     int  ->  r15        
+;  V08 loc6         [V08,T24] (  6,  16.99)     int  ->  r13        
+;  V09 loc7         [V09,T26] (  8,  13.92)     int  ->  r12        
+;  V10 loc8         [V10,T39] (  3,   6.02)     int  ->  [rsp+0x114] 
 ;* V11 loc9         [V11    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[int]>
-;  V12 loc10        [V12,T76] (  5,   0   )     int  ->  rbp        
-;  V13 loc11        [V13,T109] (  2,   0   )     int  ->  rdx        
-;  V14 loc12        [V14,T17] (  7,  36.72)     int  ->  r15        
+;* V12 loc10        [V12,T132] (  0,   0   )     int  ->  zero-ref   
+;  V13 loc11        [V13,T113] (  2,   0   )     int  ->  rdx        
+;  V14 loc12        [V14,T59] (  2,   2.02)     int  ->  r15        
 ;  V15 loc13        [V15    ] (  3,   0   )  struct (24) [rsp+0xF8]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Collections.Generic.HashSet`1+Enumerator[int]>
-;  V16 loc14        [V16,T110] (  2,   0   )     int  ->  rax        
+;  V16 loc14        [V16,T114] (  2,   0   )     int  ->  rax        
 ;* V17 loc15        [V17    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[int]>
-;  V18 loc16        [V18,T01] (  5,1722.86)     int  ->  rcx        
+;* V18 loc16        [V18,T32] (  0,   0   )     int  ->  zero-ref   
 ;* V19 loc17        [V19    ] (  0,   0   )     int  ->  zero-ref   
 ;  V20 OutArgs      [V20    ] (  1,   1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V21 tmp1         [V21    ] (  0,   0   )     int  ->  zero-ref   
 ;* V22 tmp2         [V22    ] (  0,   0   )     int  ->  zero-ref   
-;  V23 tmp3         [V23,T56] (  2,   2.02)     int  ->  r13        
-;  V24 tmp4         [V24,T36] (  3,   6.06)     ref  ->  [rsp+0x90]  class-hnd exact spill-single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V23 tmp3         [V23,T60] (  2,   2.02)     int  ->  r13        
+;  V24 tmp4         [V24,T38] (  3,   6.06)     ref  ->  [rsp+0x90]  class-hnd exact spill-single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
 ;* V25 tmp5         [V25    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <int[]>
-;  V26 tmp6         [V26,T33] (  2,   7.50)     ref  ->  rbx         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
-;  V27 tmp7         [V27,T86] (  3,   0   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.HashSet`1[int]>
-;  V28 tmp8         [V28,T55] (  3,   2.02)     ref  ->  registers   "guarded devirt return temp"
-;  V29 tmp9         [V29,T63] (  6,   1.01)     ref  ->  [rsp+0x88]  class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
-;  V30 tmp10        [V30,T62] (  6,   1.88)     ref  ->  rbx         class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
+;  V26 tmp6         [V26,T35] (  2,   7.50)     ref  ->  rbx         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V27 tmp7         [V27,T90] (  3,   0   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.HashSet`1[int]>
+;  V28 tmp8         [V28,T58] (  3,   2.02)     ref  ->  registers   "guarded devirt return temp"
+;  V29 tmp9         [V29,T67] (  6,   1.01)     ref  ->  [rsp+0x88]  class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
+;  V30 tmp10        [V30,T66] (  6,   1.88)     ref  ->  rbx         class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
 ;* V31 tmp11        [V31    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V32 tmp12        [V32    ] (  1,   0   )     int  ->  [rsp+0xF0]  do-not-enreg[X] addr-exposed ld-addr-op "Inline ldloca(s) first use temp"
 ;* V33 tmp13        [V33    ] (  0,   0   )  struct (16) zero-ref    "ReadOnlySpan<T> for CreateSpan<T>" <System.ReadOnlySpan`1[int]>
-;  V34 tmp14        [V34,T51] (  8,   3.03)     ref  ->  [rsp+0x80]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
-;  V35 tmp15        [V35,T42] (  8,   4.04)     int  ->  [rsp+0xEC]  "Inlining Arg"
-;  V36 tmp16        [V36,T41] (  9,   4.04)     int  ->  [rsp+0xE8]  spill-single-def "Inline stloc first use temp"
-;  V37 tmp17        [V37,T39] (  5,   5.05)     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V38 tmp18        [V38,T87] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V39 tmp19        [V39,T38] ( 14,   5.05)     ref  ->  [rsp+0x78]  class-hnd "Inline stloc first use temp" <int[]>
-;  V40 tmp20        [V40,T95] (  3,   0   )     int  ->  [rsp+0xE4]  spill-single-def "Inline stloc first use temp"
-;  V41 tmp21        [V41,T111] (  2,   0   )     int  ->  [rsp+0xE0]  spill-single-def "impAppendStmt"
-;  V42 tmp22        [V42,T112] (  2,   0   )     int  ->  [rsp+0xDC]  spill-single-def "impAppendStmt"
-;  V43 tmp23        [V43,T113] (  2,   0   )     int  ->   r9         "impAppendStmt"
+;  V34 tmp14        [V34,T54] (  8,   3.03)     ref  ->  [rsp+0x80]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
+;  V35 tmp15        [V35,T45] (  8,   4.04)     int  ->  [rsp+0xEC]  "Inlining Arg"
+;  V36 tmp16        [V36,T44] (  9,   4.04)     int  ->  [rsp+0xE8]  spill-single-def "Inline stloc first use temp"
+;  V37 tmp17        [V37,T41] (  5,   5.05)     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
+;  V38 tmp18        [V38,T91] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V39 tmp19        [V39,T40] ( 14,   5.05)     ref  ->  [rsp+0x78]  class-hnd "Inline stloc first use temp" <int[]>
+;  V40 tmp20        [V40,T99] (  3,   0   )     int  ->  [rsp+0xE4]  spill-single-def "Inline stloc first use temp"
+;  V41 tmp21        [V41,T115] (  2,   0   )     int  ->  [rsp+0xE0]  spill-single-def "impAppendStmt"
+;  V42 tmp22        [V42,T116] (  2,   0   )     int  ->  [rsp+0xDC]  spill-single-def "impAppendStmt"
+;  V43 tmp23        [V43,T117] (  2,   0   )     int  ->   r9         "impAppendStmt"
 ;* V44 tmp24        [V44    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V45 tmp25        [V45    ] (  0,   0   )     int  ->  zero-ref   
 ;* V46 tmp26        [V46    ] (  0,   0   )     int  ->  zero-ref   
@@ -1179,76 +1179,76 @@ RWD00  	dq	3FA999999999999Ah	;         0.05
 ;* V51 tmp31        [V51    ] (  0,   0   )     int  ->  zero-ref   
 ;* V52 tmp32        [V52    ] (  0,   0   )     int  ->  zero-ref   
 ;* V53 tmp33        [V53    ] (  0,   0   )     int  ->  zero-ref   
-;  V54 tmp34        [V54,T114] (  2,   0   )     int  ->  rdx        
-;  V55 tmp35        [V55,T88] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
+;  V54 tmp34        [V54,T118] (  2,   0   )     int  ->  rdx        
+;  V55 tmp35        [V55,T92] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
 ;* V56 tmp36        [V56    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "updating class info" <int[]>
-;  V57 tmp37        [V57,T115] (  2,   0   )     int  ->  [rsp+0xD8]  spill-single-def "impAppendStmt"
-;  V58 tmp38        [V58,T116] (  2,   0   )     int  ->  [rsp+0xD4]  spill-single-def "impAppendStmt"
+;  V57 tmp37        [V57,T119] (  2,   0   )     int  ->  [rsp+0xD8]  spill-single-def "impAppendStmt"
+;  V58 tmp38        [V58,T120] (  2,   0   )     int  ->  [rsp+0xD4]  spill-single-def "impAppendStmt"
 ;* V59 tmp39        [V59    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "updating class info" <int[]>
-;  V60 tmp40        [V60,T43] (  2,   4.04)     int  ->  [rsp+0xD0]  spill-single-def "impAppendStmt"
-;  V61 tmp41        [V61,T44] (  2,   4.04)     int  ->  [rsp+0xCC]  spill-single-def "impAppendStmt"
+;  V60 tmp40        [V60,T46] (  2,   4.04)     int  ->  [rsp+0xD0]  spill-single-def "impAppendStmt"
+;  V61 tmp41        [V61,T47] (  2,   4.04)     int  ->  [rsp+0xCC]  spill-single-def "impAppendStmt"
 ;* V62 tmp42        [V62    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V63 tmp43        [V63    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V64 tmp44        [V64,T89] (  3,   0   )     ref  ->  r10         class-hnd "Inline return value spill temp" <System.Array>
-;  V65 tmp45        [V65,T74] (  5,   0   )     ref  ->  [rsp+0x70]  class-hnd exact spill-single-def "Inline stloc first use temp" <<unknown class>>
-;  V66 tmp46        [V66,T71] (  7,   0   )     int  ->  [rsp+0xC8]  "Inline stloc first use temp"
-;  V67 tmp47        [V67,T82] (  4,   0   )     int  ->  [rsp+0xC4]  "Inline stloc first use temp"
+;  V64 tmp44        [V64,T93] (  3,   0   )     ref  ->  r10         class-hnd "Inline return value spill temp" <System.Array>
+;  V65 tmp45        [V65,T78] (  5,   0   )     ref  ->  [rsp+0x70]  class-hnd exact spill-single-def "Inline stloc first use temp" <<unknown class>>
+;  V66 tmp46        [V66,T75] (  7,   0   )     int  ->  [rsp+0xC8]  "Inline stloc first use temp"
+;  V67 tmp47        [V67,T86] (  4,   0   )     int  ->  [rsp+0xC4]  "Inline stloc first use temp"
 ;* V68 tmp48        [V68    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "dup spill" <System.Array>
 ;* V69 tmp49        [V69    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Array>
-;  V70 tmp50        [V70,T117] (  2,   0   )     int  ->  rax         "dup spill"
-;  V71 tmp51        [V71,T96] (  3,   0   )     int  ->  [rsp+0xC0]  "Inline return value spill temp"
-;  V72 tmp52        [V72,T97] (  3,   0   )     int  ->  rdx         "Inline return value spill temp"
-;  V73 tmp53        [V73,T83] (  4,   0   )     int  ->  [rsp+0xBC]  spill-single-def "dup spill"
+;  V70 tmp50        [V70,T121] (  2,   0   )     int  ->  rax         "dup spill"
+;  V71 tmp51        [V71,T100] (  3,   0   )     int  ->  [rsp+0xC0]  "Inline return value spill temp"
+;  V72 tmp52        [V72,T101] (  3,   0   )     int  ->  rdx         "Inline return value spill temp"
+;  V73 tmp53        [V73,T87] (  4,   0   )     int  ->  [rsp+0xBC]  spill-single-def "dup spill"
 ;* V74 tmp54        [V74    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V75 tmp55        [V75    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Array>
-;  V76 tmp56        [V76,T79] (  4,   0   )     ref  ->  [rsp+0x68]  class-hnd "Inline stloc first use temp" <System.Array>
-;  V77 tmp57        [V77,T70] (  7,   0   )     ref  ->  [rsp+0x60]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
-;  V78 tmp58        [V78,T80] (  4,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V79 tmp59        [V79,T77] (  5,   0   )     int  ->  rax         "Inline stloc first use temp"
+;  V76 tmp56        [V76,T83] (  4,   0   )     ref  ->  [rsp+0x68]  class-hnd "Inline stloc first use temp" <System.Array>
+;  V77 tmp57        [V77,T74] (  7,   0   )     ref  ->  [rsp+0x60]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
+;  V78 tmp58        [V78,T84] (  4,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V79 tmp59        [V79,T80] (  5,   0   )     int  ->  rax         "Inline stloc first use temp"
 ;* V80 tmp60        [V80    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V81 tmp61        [V81,T90] (  3,   0   )     ref  ->   r8         class-hnd "Inline return value spill temp" <int[]>
+;  V81 tmp61        [V81,T94] (  3,   0   )     ref  ->   r8         class-hnd "Inline return value spill temp" <int[]>
 ;* V82 tmp62        [V82    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V83 tmp63        [V83    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "updating class info" <int[]>
-;  V84 tmp64        [V84,T21] (  5,  27.82)     int  ->   r8         "Inline return value spill temp"
+;  V84 tmp64        [V84,T21] (  5,  27.61)     int  ->   r8         "Inline return value spill temp"
 ;* V85 tmp65        [V85    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V86 tmp66        [V86,T16] (  3,  41.63)     int  ->   r8         "Inlining Arg"
-;  V87 tmp67        [V87,T25] (  5,  13.92)   byref  ->  r10         "Inline stloc first use temp"
-;  V88 tmp68        [V88,T22] (  4,  20.93)     int  ->  registers   "Inline stloc first use temp"
-;  V89 tmp69        [V89,T20] (  5,  27.83)    long  ->  r13         "Inline stloc first use temp"
-;  V90 tmp70        [V90,T19] (  4,  27.86)     int  ->  rdi         "Inline stloc first use temp"
-;  V91 tmp71        [V91,T23] (  3,  20.82)    long  ->  rax         "Inline stloc first use temp"
-;  V92 tmp72        [V92,T27] (  3,  13.88)   byref  ->  r10         "Inline stloc first use temp"
-;  V93 tmp73        [V93,T28] (  3,  13.88)    long  ->  rax         "Inline stloc first use temp"
-;  V94 tmp74        [V94,T98] (  3,   0   )     int  ->  [rsp+0xB8]  spill-single-def "Inline stloc first use temp"
-;  V95 tmp75        [V95,T99] (  3,   0   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V96 tmp76        [V96,T73] (  6,   0   )     int  ->  rdx         "Inline stloc first use temp"
-;  V97 tmp77        [V97,T91] (  3,   0   )   byref  ->  rax         "dup spill"
+;  V86 tmp66        [V86,T16] (  3,  41.32)     int  ->   r8         "Inlining Arg"
+;  V87 tmp67        [V87,T27] (  5,  13.81)   byref  ->  r10         "Inline stloc first use temp"
+;  V88 tmp68        [V88,T22] (  4,  20.78)     int  ->  registers   "Inline stloc first use temp"
+;  V89 tmp69        [V89,T20] (  5,  27.63)    long  ->  r13         "Inline stloc first use temp"
+;  V90 tmp70        [V90,T19] (  4,  27.65)     int  ->  rdi         "Inline stloc first use temp"
+;  V91 tmp71        [V91,T23] (  3,  20.66)    long  ->  rax         "Inline stloc first use temp"
+;  V92 tmp72        [V92,T28] (  3,  13.77)   byref  ->  r10         "Inline stloc first use temp"
+;  V93 tmp73        [V93,T29] (  3,  13.77)    long  ->  rax         "Inline stloc first use temp"
+;  V94 tmp74        [V94,T102] (  3,   0   )     int  ->  [rsp+0xB8]  spill-single-def "Inline stloc first use temp"
+;  V95 tmp75        [V95,T103] (  3,   0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V96 tmp76        [V96,T77] (  6,   0   )     int  ->  rdx         "Inline stloc first use temp"
+;  V97 tmp77        [V97,T95] (  3,   0   )   byref  ->  rax         "dup spill"
 ;* V98 tmp78        [V98    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V99 tmp79        [V99,T11] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V100 tmp80       [V100,T02] (  3,1286.94)     int  ->  rdx         "Inline stloc first use temp"
-;  V101 tmp81       [V101,T00] (  3,2258.90)   byref  ->  rax         "dup spill"
+;  V100 tmp80       [V100,T02] (  3,1269.15)     int  ->  rdx         "Inline stloc first use temp"
+;  V101 tmp81       [V101,T00] (  3,2187.55)   byref  ->  rax         "dup spill"
 ;* V102 tmp82       [V102    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V103 tmp83       [V103,T29] (  6,  11.50)     ref  ->  rsi         class-hnd single-def "Inlining Arg" <int[]>
-;  V104 tmp84       [V104,T46] (  8,   4   )     int  ->  rdi         "Inline stloc first use temp"
-;  V105 tmp85       [V105,T49] (  2,   4   )     ref  ->  rcx         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V106 tmp86       [V106,T47] (  5,   4   )     ref  ->  rcx        
+;  V103 tmp83       [V103,T30] (  6,  11.51)     ref  ->  rsi         class-hnd single-def "Inlining Arg" <int[]>
+;  V104 tmp84       [V104,T51] (  8,   4.00)     int  ->  rdi         "Inline stloc first use temp"
+;  V105 tmp85       [V105,T49] (  2,   4.01)     ref  ->  rcx         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
+;  V106 tmp86       [V106,T50] (  5,   4.01)     ref  ->  rcx        
 ;* V107 tmp87       [V107    ] (  0,   0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V108 tmp88       [V108,T59] (  4,   2   )   ubyte  ->  rbp         "Inline stloc first use temp"
-;  V109 tmp89       [V109,T64] (  3,   1   )   ubyte  ->  r14         "Inline stloc first use temp"
-;  V110 tmp90       [V110,T58] (  4,   2   )     ref  ->  r15         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
-;  V111 tmp91       [V111,T118] (  2,   0   )     int  ->  r13         "impAppendStmt"
-;  V112 tmp92       [V112,T119] (  2,   0   )     int  ->  [rsp+0xB4]  spill-single-def "impAppendStmt"
-;  V113 tmp93       [V113,T120] (  2,   0   )     int  ->  rsi         "impAppendStmt"
-;  V114 tmp94       [V114,T121] (  2,   0   )     int  ->  r12         "impAppendStmt"
+;  V108 tmp88       [V108,T62] (  4,   2.00)   ubyte  ->  rbp         "Inline stloc first use temp"
+;  V109 tmp89       [V109,T68] (  3,   1.00)   ubyte  ->  r14         "Inline stloc first use temp"
+;  V110 tmp90       [V110,T64] (  4,   2   )     ref  ->  r15         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
+;  V111 tmp91       [V111,T122] (  2,   0   )     int  ->  r13         "impAppendStmt"
+;  V112 tmp92       [V112,T123] (  2,   0   )     int  ->  [rsp+0xB4]  spill-single-def "impAppendStmt"
+;  V113 tmp93       [V113,T124] (  2,   0   )     int  ->  rsi         "impAppendStmt"
+;  V114 tmp94       [V114,T125] (  2,   0   )     int  ->  r12         "impAppendStmt"
 ;* V115 tmp95       [V115    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V116 tmp96       [V116    ] (  0,   0   )     int  ->  zero-ref   
 ;* V117 tmp97       [V117    ] (  0,   0   )     int  ->  zero-ref   
-;  V118 tmp98       [V118,T122] (  2,   0   )     int  ->   r9        
+;  V118 tmp98       [V118,T126] (  2,   0   )     int  ->   r9        
 ;* V119 tmp99       [V119    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V120 tmp100      [V120    ] (  0,   0   )     int  ->  zero-ref   
 ;* V121 tmp101      [V121    ] (  0,   0   )     int  ->  zero-ref   
 ;* V122 tmp102      [V122    ] (  0,   0   )     int  ->  zero-ref   
-;  V123 tmp103      [V123,T100] (  3,   0   )     int  ->  rcx        
+;  V123 tmp103      [V123,T104] (  3,   0   )     int  ->  rcx        
 ;* V124 tmp104      [V124    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V125 tmp105      [V125    ] (  0,   0   )     int  ->  zero-ref   
 ;* V126 tmp106      [V126    ] (  0,   0   )     int  ->  zero-ref   
@@ -1259,70 +1259,75 @@ RWD00  	dq	3FA999999999999Ah	;         0.05
 ;* V131 tmp111      [V131    ] (  0,   0   )     int  ->  zero-ref   
 ;* V132 tmp112      [V132    ] (  0,   0   )     int  ->  zero-ref   
 ;* V133 tmp113      [V133    ] (  0,   0   )     int  ->  zero-ref   
-;  V134 tmp114      [V134,T101] (  3,   0   )     int  ->  rdx        
+;  V134 tmp114      [V134,T105] (  3,   0   )     int  ->  rdx        
 ;* V135 tmp115      [V135    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V136 tmp116      [V136,T48] (  4,   4   )   byref  ->  r15         single-def "Inline stloc first use temp"
-;  V137 tmp117      [V137,T60] (  3,   2   )     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Array>
+;  V136 tmp116      [V136,T52] (  4,   4.00)   byref  ->  r15         single-def "Inline stloc first use temp"
+;  V137 tmp117      [V137,T63] (  3,   2.00)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Array>
 ;* V138 tmp118      [V138    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Buffers.SharedArrayPoolThreadLocalArray>
-;  V139 tmp119      [V139,T106] (  2,   0   )     ref  ->   r8         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolPartitions>
-;  V140 tmp120      [V140,T81] (  4,   0   )     ref  ->   r8        
+;  V139 tmp119      [V139,T110] (  2,   0   )     ref  ->   r8         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolPartitions>
+;  V140 tmp120      [V140,T85] (  4,   0   )     ref  ->   r8        
 ;* V141 tmp121      [V141    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
-;  V142 tmp122      [V142,T92] (  3,   0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V142 tmp122      [V142,T96] (  3,   0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V143 tmp123      [V143    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V144 tmp124      [V144    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V145 tmp125      [V145    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V146 tmp126      [V146    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V147 tmp127      [V147,T102] (  3,   0   )   ubyte  ->  r14         "Inline return value spill temp"
-;  V148 tmp128      [V148,T75] (  5,   0   )     ref  ->  r14         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V149 tmp129      [V149,T72] (  7,   0   )     int  ->  r15         "Inline stloc first use temp"
-;  V150 tmp130      [V150,T84] (  4,   0   )     int  ->  r12         "Inline stloc first use temp"
-;  V151 tmp131      [V151,T123] (  2,   0   )     int  ->  r15         "dup spill"
-;  V152 tmp132      [V152,T103] (  3,   0   )     int  ->  r15         "Inline return value spill temp"
-;  V153 tmp133      [V153,T104] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
-;  V154 tmp134      [V154,T85] (  4,   0   )     int  ->  r15         "dup spill"
+;  V147 tmp127      [V147,T106] (  3,   0   )   ubyte  ->  r14         "Inline return value spill temp"
+;  V148 tmp128      [V148,T79] (  5,   0   )     ref  ->  r14         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V149 tmp129      [V149,T76] (  7,   0   )     int  ->  r15         "Inline stloc first use temp"
+;  V150 tmp130      [V150,T88] (  4,   0   )     int  ->  r12         "Inline stloc first use temp"
+;  V151 tmp131      [V151,T127] (  2,   0   )     int  ->  r15         "dup spill"
+;  V152 tmp132      [V152,T107] (  3,   0   )     int  ->  r15         "Inline return value spill temp"
+;  V153 tmp133      [V153,T108] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V154 tmp134      [V154,T89] (  4,   0   )     int  ->  r15         "dup spill"
 ;* V155 tmp135      [V155    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V156 tmp136      [V156    ] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V157 tmp137      [V157,T105] (  3,   0   )   ubyte  ->  [rsp+0xB0]  "Inline stloc first use temp"
-;  V158 tmp138      [V158,T69] (  8,   0   )     ref  ->  [rsp+0x58]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
-;  V159 tmp139      [V159,T93] (  3,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V160 tmp140      [V160,T78] (  5,   0   )     int  ->  [rsp+0xAC]  spill-single-def "Inline stloc first use temp"
-;  V161 tmp141      [V161,T124] (  2,   0   )     int  ->  rax         "Inlining Arg"
-;  V162 tmp142      [V162,T10] (  3, 429.98)   byref  ->  [rsp+0x50]  spill-single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V163 tmp143      [V163,T09] (  7, 437.92)     int  ->  rsi         "field V00._length (fldOffset=0x8)" P-INDEP
-;  V164 tmp144      [V164,T06] ( 10, 836.21)     ref  ->  [rsp+0x48]  spill-single-def "field V02.seenBuckets (fldOffset=0x0)" P-INDEP
-;  V165 tmp145      [V165,T07] (  6, 446.86)     int  ->  [rsp+0xA8]  spill-single-def "field V02.numBuckets (fldOffset=0x8)" P-INDEP
-;  V166 tmp146      [V166,T12] ( 11, 187.18)     int  ->  rdi         "field V02.numCollisions (fldOffset=0xc)" P-INDEP
-;  V167 tmp147      [V167,T13] (  5,  72.25)     int  ->  [rsp+0xA4]  "field V02.bestNumCollisions (fldOffset=0x10)" P-INDEP
+;  V157 tmp137      [V157,T109] (  3,   0   )   ubyte  ->  [rsp+0xB0]  "Inline stloc first use temp"
+;  V158 tmp138      [V158,T73] (  8,   0   )     ref  ->  [rsp+0x58]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
+;  V159 tmp139      [V159,T97] (  3,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V160 tmp140      [V160,T81] (  5,   0   )     int  ->  [rsp+0xAC]  spill-single-def "Inline stloc first use temp"
+;  V161 tmp141      [V161,T128] (  2,   0   )     int  ->  rax         "Inlining Arg"
+;  V162 tmp142      [V162,T10] (  3, 424.05)   byref  ->  [rsp+0x50]  spill-single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V163 tmp143      [V163,T09] (  7, 431.94)     int  ->  rsi         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V164 tmp144      [V164,T06] ( 10, 818.18)     ref  ->  [rsp+0x48]  spill-single-def "field V02.seenBuckets (fldOffset=0x0)" P-INDEP
+;  V165 tmp145      [V165,T07] (  6, 440.84)     int  ->  [rsp+0xA8]  spill-single-def "field V02.numBuckets (fldOffset=0x8)" P-INDEP
+;  V166 tmp146      [V166,T12] ( 11, 202.83)     int  ->  rdi         "field V02.numCollisions (fldOffset=0xc)" P-INDEP
+;  V167 tmp147      [V167,T13] (  5,  76.03)     int  ->  [rsp+0xA4]  "field V02.bestNumCollisions (fldOffset=0x10)" P-INDEP
 ;  V168 tmp148      [V168,T18] (  5,  33.85)   byref  ->  r14         single-def "field V06._reference (fldOffset=0x0)" P-INDEP
-;* V169 tmp149      [V169,T66] (  0,   0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
-;* V170 tmp150      [V170,T127] (  0,   0   )   byref  ->  zero-ref    single-def "field V11._reference (fldOffset=0x0)" P-INDEP
-;* V171 tmp151      [V171,T128] (  0,   0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
+;* V169 tmp149      [V169,T71] (  0,   0   )     int  ->  zero-ref    "field V06._length (fldOffset=0x8)" P-INDEP
+;* V170 tmp150      [V170,T131] (  0,   0   )   byref  ->  zero-ref    single-def "field V11._reference (fldOffset=0x0)" P-INDEP
+;* V171 tmp151      [V171,T133] (  0,   0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;  V172 tmp152      [V172    ] (  2,   0   )     ref  ->  [rsp+0xF8]  do-not-enreg[X] addr-exposed "field V15._hashSet (fldOffset=0x0)" P-DEP
 ;  V173 tmp153      [V173    ] (  2,   0   )     int  ->  [rsp+0x100]  do-not-enreg[X] addr-exposed "field V15._version (fldOffset=0x8)" P-DEP
 ;  V174 tmp154      [V174    ] (  2,   0   )     int  ->  [rsp+0x104]  do-not-enreg[X] addr-exposed "field V15._index (fldOffset=0xc)" P-DEP
 ;  V175 tmp155      [V175    ] (  3,   0   )     int  ->  [rsp+0x108]  do-not-enreg[X] addr-exposed "field V15._current (fldOffset=0x10)" P-DEP
-;* V176 tmp156      [V176,T34] (  0,   0   )   byref  ->  zero-ref    "field V17._reference (fldOffset=0x0)" P-INDEP
-;* V177 tmp157      [V177,T35] (  0,   0   )     int  ->  zero-ref    "field V17._length (fldOffset=0x8)" P-INDEP
-;  V178 tmp158      [V178,T61] (  2,   2   )   byref  ->  r14         single-def "field V33._reference (fldOffset=0x0)" P-INDEP
-;* V179 tmp159      [V179,T67] (  0,   0   )     int  ->  zero-ref    "field V33._length (fldOffset=0x8)" P-INDEP
-;* V180 tmp160      [V180,T65] (  0,   0   )     ref  ->  zero-ref    single-def "field V138.Array (fldOffset=0x0)" P-INDEP
-;* V181 tmp161      [V181,T68] (  0,   0   )     int  ->  zero-ref    "field V138.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
+;* V176 tmp156      [V176,T36] (  0,   0   )   byref  ->  zero-ref    "field V17._reference (fldOffset=0x0)" P-INDEP
+;* V177 tmp157      [V177,T37] (  0,   0   )     int  ->  zero-ref    "field V17._length (fldOffset=0x8)" P-INDEP
+;  V178 tmp158      [V178,T65] (  2,   2   )   byref  ->  r14         single-def "field V33._reference (fldOffset=0x0)" P-INDEP
+;* V179 tmp159      [V179,T72] (  0,   0   )     int  ->  zero-ref    "field V33._length (fldOffset=0x8)" P-INDEP
+;* V180 tmp160      [V180,T69] (  0,   0   )     ref  ->  zero-ref    single-def "field V138.Array (fldOffset=0x0)" P-INDEP
+;* V181 tmp161      [V181,T70] (  0,   0   )     int  ->  zero-ref    "field V138.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
 ;* V182 tmp162      [V182    ] (  0,   0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[int]>
-;  V183 tmp163      [V183,T125] (  2,   0   )     int  ->   r9         "argument with side effect"
-;  V184 tmp164      [V184,T126] (  2,   0   )     int  ->   r9         "argument with side effect"
-;  V185 tmp165      [V185,T45] (  2,   4.04)     int  ->   r9         "argument with side effect"
-;  V186 tmp166      [V186,T94] (  3,   0   )     ref  ->  rcx         single-def "arr expr"
-;  V187 tmp167      [V187,T107] (  2,   0   )     ref  ->  rdi         single-def "argument with side effect"
-;  V188 tmp168      [V188,T108] (  2,   0   )     ref  ->   r8         single-def "argument with side effect"
-;  V189 cse0        [V189,T04] (  3,1234.44)    long  ->  rax         "CSE #22: aggressive"
-;  V190 cse1        [V190,T03] (  3,1286.94)     int  ->  rax         "CSE #21: aggressive"
-;  V191 cse2        [V191,T53] (  3,   3.02)   byref  ->  [rsp+0x40]  spill-single-def "CSE #27: conservative"
-;  V192 cse3        [V192,T05] (  3,1234.44)     int  ->  rdx         "CSE #25: aggressive"
-;  V193 cse4        [V193,T50] (  3,   3.89)     ref  ->  [rsp+0x38]  spill-single-def "CSE #26: conservative"
-;  V194 cse5        [V194,T54] (  3,   3.02)     ref  ->  [rsp+0x30]  spill-single-def "CSE #35: conservative"
-;  V195 cse6        [V195,T52] (  3,   3.03)    long  ->  rdx         "CSE #04: conservative"
-;  V196 cse7        [V196,T08] ( 10, 445.86)     int  ->  [rsp+0xA0]  multi-def "CSE #15: aggressive"
-;  V197 cse8        [V197,T57] (  2,   2.02)     int  ->  rdx         "CSE #02: conservative"
+;  V183 tmp163      [V183,T129] (  2,   0   )     int  ->   r9         "argument with side effect"
+;  V184 tmp164      [V184,T130] (  2,   0   )     int  ->   r9         "argument with side effect"
+;  V185 tmp165      [V185,T48] (  2,   4.04)     int  ->   r9         "argument with side effect"
+;  V186 tmp166      [V186,T98] (  3,   0   )     ref  ->  rcx         single-def "arr expr"
+;  V187 tmp167      [V187,T111] (  2,   0   )     ref  ->  rdi         single-def "argument with side effect"
+;  V188 tmp168      [V188,T112] (  2,   0   )     ref  ->   r8         single-def "argument with side effect"
+;  V189 cse0        [V189,T04] (  3,1210.69)    long  ->  rax         "CSE #22: aggressive"
+;  V190 cse1        [V190,T03] (  3,1269.15)     int  ->  rax         "CSE #21: aggressive"
+;  V191 cse2        [V191,T56] (  3,   3.02)   byref  ->  [rsp+0x40]  spill-single-def "CSE #27: conservative"
+;  V192 cse3        [V192,T05] (  3,1210.69)     int  ->  rdx         "CSE #25: aggressive"
+;  V193 cse4        [V193,T53] (  3,   3.90)     ref  ->  [rsp+0x38]  spill-single-def "CSE #26: conservative"
+;  V194 cse5        [V194,T57] (  3,   3.02)     ref  ->  [rsp+0x30]  spill-single-def "CSE #35: conservative"
+;  V195 cse6        [V195,T55] (  3,   3.03)    long  ->  rdx         "CSE #04: conservative"
+;  V196 cse7        [V196,T08] ( 10, 439.83)     int  ->  [rsp+0xA0]  multi-def "CSE #15: aggressive"
+;  V197 cse8        [V197,T61] (  2,   2.02)     int  ->  rdx         "CSE #02: conservative"
+;  V198 rat0        [V198,T82] (  5,   0   )    long  ->  rbp         "Widened IV V12"
+;  V199 rat1        [V199,T14] (  6,  52.05)    long  ->  rdx         "Widened IV V07"
+;  V200 rat2        [V200,T15] (  6,  47.88)    long  ->  rcx         "Widened IV V09"
+;  V201 rat3        [V201,T17] (  7,  36.46)    long  ->  r15         "Widened IV V14"
+;  V202 rat4        [V202,T01] (  5,1699.09)    long  ->  rcx         "Widened IV V18"
 ;
 ; Lcl frame size = 280
 
@@ -1349,62 +1354,63 @@ G_M18874_IG02:
        mov      gword ptr [rsp+0x98], rdi
        mov      ebp, esi
        test     dl, dl
-       je       G_M18874_IG49
+       je       G_M18874_IG50
 						;; size=31 bbWeight=1 PerfScore 7.75
 G_M18874_IG03:
        lea      ecx, [rbp+rbp]
        mov      r14, 0xD1FFAB1E      ; static handle
-       xor      r15d, r15d
+       xor      edx, edx
        jmp      SHORT G_M18874_IG05
-       align    [4 bytes for IG04]
+       align    [5 bytes for IG04]
 						;; size=23 bbWeight=1 PerfScore 4.50
 G_M18874_IG04:
-       inc      r15d
-						;; size=3 bbWeight=11.89 PerfScore 2.97
+       inc      edx
+						;; size=2 bbWeight=12.01 PerfScore 3.00
 G_M18874_IG05:
-       cmp      r15d, 72
+       cmp      edx, 72
        jae      SHORT G_M18874_IG07
-						;; size=6 bbWeight=12.90 PerfScore 16.13
+						;; size=5 bbWeight=13.02 PerfScore 16.27
 G_M18874_IG06:
-       mov      edx, r15d
        cmp      dword ptr [r14+4*rdx], ecx
        jl       SHORT G_M18874_IG04
-						;; size=9 bbWeight=12.89 PerfScore 54.79
+						;; size=6 bbWeight=13.01 PerfScore 52.06
 G_M18874_IG07:
+       mov      r15d, edx
        cmp      r15d, 72
-       jge      G_M18874_IG52
+       jge      G_M18874_IG53
        mov      r13d, 3
        mov      ecx, 16
        cmp      ebp, 0x3E8
        cmovl    r13d, ecx
        imul     r13d, ebp
        mov      r12d, r15d
-       jmp      SHORT G_M18874_IG09
-       align    [6 bytes for IG08]
-						;; size=46 bbWeight=1.01 PerfScore 6.56
-G_M18874_IG08:
-       inc      r12d
-						;; size=3 bbWeight=11.03 PerfScore 2.76
-G_M18874_IG09:
-       cmp      r12d, 72
-       jae      SHORT G_M18874_IG11
-						;; size=6 bbWeight=12.04 PerfScore 15.05
-G_M18874_IG10:
        mov      ecx, r12d
+       jmp      SHORT G_M18874_IG09
+       align    [5 bytes for IG08]
+						;; size=51 bbWeight=1.01 PerfScore 7.07
+G_M18874_IG08:
+       inc      ecx
+						;; size=2 bbWeight=10.96 PerfScore 2.74
+G_M18874_IG09:
+       cmp      ecx, 72
+       jae      SHORT G_M18874_IG11
+						;; size=5 bbWeight=11.97 PerfScore 14.97
+G_M18874_IG10:
        cmp      dword ptr [r14+4*rcx], r13d
        jl       SHORT G_M18874_IG08
-						;; size=9 bbWeight=12.02 PerfScore 51.09
+						;; size=6 bbWeight=11.95 PerfScore 47.82
 G_M18874_IG11:
+       mov      r12d, ecx
        cmp      r12d, 72
        jge      SHORT G_M18874_IG13
-						;; size=6 bbWeight=1.01 PerfScore 1.26
+						;; size=9 bbWeight=1.01 PerfScore 1.52
 G_M18874_IG12:
        lea      ecx, [r12-0x01]
        cmp      ecx, 72
-       jae      G_M18874_IG48
+       jae      G_M18874_IG49
        lea      ecx, [r12-0x01]
        mov      r13d, dword ptr [r14+4*rcx]
-						;; size=23 bbWeight=1.00 PerfScore 4.24
+						;; size=23 bbWeight=0.99 PerfScore 4.21
 G_M18874_IG13:
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rax, gword ptr [rcx]
@@ -1435,7 +1441,7 @@ G_M18874_IG13:
        mov      bword ptr [rsp+0x40], rax
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       G_M18874_IG54
+       je       G_M18874_IG55
        mov      edx, dword ptr [rcx+0x08]
        mov      r8d, dword ptr [rsp+0xE8]
        cmp      edx, r8d
@@ -1444,7 +1450,7 @@ G_M18874_IG13:
        shl      rdx, 4
        mov      r10, gword ptr [rcx+rdx+0x10]
        test     r10, r10
-       je       G_M18874_IG54
+       je       G_M18874_IG55
        xor      r9, r9
        mov      gword ptr [rcx+rdx+0x10], r9
        mov      rdx, gword ptr [rsp+0x80]
@@ -1460,7 +1466,7 @@ G_M18874_IG13:
        mov      rcx, gword ptr [rsp+0x90]
        call     <unknown method>
        mov      r9d, eax
-						;; size=272 bbWeight=1.01 PerfScore 47.18
+						;; size=272 bbWeight=1.01 PerfScore 47.24
 G_M18874_IG14:
        mov      eax, dword ptr [rsp+0xE8]
        mov      dword ptr [rsp+0x20], eax
@@ -1469,7 +1475,7 @@ G_M18874_IG14:
        mov      rcx, gword ptr [rsp+0x80]
        call     [<unknown method>]
        mov      r10, gword ptr [rsp+0x78]
-						;; size=45 bbWeight=1.01 PerfScore 9.08
+						;; size=45 bbWeight=1.01 PerfScore 9.10
 G_M18874_IG15:
        mov      r8, r10
 						;; size=3 bbWeight=1.01 PerfScore 0.25
@@ -1478,42 +1484,42 @@ G_M18874_IG16:
        mov      gword ptr [rsp+0x48], r9
        mov      dword ptr [rsp+0x114], r13d
        mov      dword ptr [rsp+0xA4], ebp
+       mov      r15d, r15d
        cmp      r15d, r12d
        jge      G_M18874_IG27
-						;; size=32 bbWeight=1.01 PerfScore 4.54
+						;; size=35 bbWeight=1.01 PerfScore 4.80
 G_M18874_IG17:
        cmp      r15d, 72
-       jae      G_M18874_IG48
-       mov      ecx, r15d
-       mov      edx, dword ptr [r14+4*rcx]
+       jae      G_M18874_IG49
+       mov      edx, dword ptr [r14+4*r15]
        mov      dword ptr [rsp+0xA8], edx
        mov      ecx, dword ptr [r9+0x08]
        mov      dword ptr [rsp+0xA0], ecx
        mov      r8d, ecx
        cmp      edx, r8d
-       jle      G_M18874_IG71
-						;; size=47 bbWeight=6.94 PerfScore 62.45
+       jle      G_M18874_IG72
+						;; size=44 bbWeight=6.89 PerfScore 60.26
 G_M18874_IG18:
        lea      r10, bword ptr [r9+0x10]
        xor      eax, eax
        mov      r13, qword ptr [r9]
        cmp      dword ptr [r13+0x04], 24
-       ja       G_M18874_IG72
-						;; size=20 bbWeight=6.98 PerfScore 47.10
+       ja       G_M18874_IG73
+						;; size=20 bbWeight=6.93 PerfScore 46.75
 G_M18874_IG19:
        mov      edi, eax
        neg      edi
        test     eax, eax
-       jg       G_M18874_IG76
-						;; size=12 bbWeight=6.98 PerfScore 12.21
+       jg       G_M18874_IG77
+						;; size=12 bbWeight=6.93 PerfScore 12.12
 G_M18874_IG20:
        mov      eax, edi
        or       eax, r8d
-       jl       G_M18874_IG76
+       jl       G_M18874_IG77
        lea      eax, [rdi+r8]
        cmp      eax, dword ptr [r9+0x08]
-       ja       G_M18874_IG76
-						;; size=25 bbWeight=6.97 PerfScore 41.82
+       ja       G_M18874_IG77
+						;; size=25 bbWeight=6.92 PerfScore 41.51
 G_M18874_IG21:
        movzx    rax, word  ptr [r13]
        mov      edi, edi
@@ -1522,24 +1528,23 @@ G_M18874_IG21:
        mov      r8d, r8d
        imul     rax, r8
        test     dword ptr [r13], 0xD1FFAB1E
-       jne      G_M18874_IG73
+       jne      G_M18874_IG74
        mov      rcx, r10
        mov      rdx, rax
        call     [<unknown method>]
        xor      edi, edi
        mov      r13, gword ptr [rsp+0x98]
        test     r13, r13
-       jne      G_M18874_IG74
-						;; size=66 bbWeight=6.94 PerfScore 116.23
+       jne      G_M18874_IG75
+						;; size=66 bbWeight=6.89 PerfScore 115.36
 G_M18874_IG22:
        xor      ecx, ecx
        test     esi, esi
        jle      G_M18874_IG37
        align    [0 bytes for IG23]
-						;; size=10 bbWeight=6.94 PerfScore 10.41
+						;; size=10 bbWeight=6.89 PerfScore 10.33
 G_M18874_IG23:
-       mov      eax, ecx
-       mov      eax, dword ptr [rbx+4*rax]
+       mov      eax, dword ptr [rbx+4*rcx]
        mov      r10d, dword ptr [rsp+0xA8]
        xor      edx, edx
        div      edx:eax, r10d
@@ -1547,46 +1552,46 @@ G_M18874_IG23:
        shr      eax, 5
        mov      r9d, dword ptr [rsp+0xA0]
        cmp      eax, r9d
-       jae      G_M18874_IG48
+       jae      G_M18874_IG49
        mov      r11d, 1
        shlx     edx, r11d, edx
        mov      r11, gword ptr [rsp+0x48]
        test     dword ptr [r11+4*rax+0x10], edx
        jne      SHORT G_M18874_IG29
-						;; size=63 bbWeight=428.98 PerfScore 15979.52
+						;; size=61 bbWeight=423.05 PerfScore 15652.87
 G_M18874_IG24:
        lea      rax, bword ptr [r11+4*rax+0x10]
        or       dword ptr [rax], edx
-						;; size=7 bbWeight=376.48 PerfScore 1505.93
+						;; size=7 bbWeight=364.59 PerfScore 1458.36
 G_M18874_IG25:
        inc      ecx
        cmp      ecx, esi
        mov      dword ptr [rsp+0xA0], r9d
        jl       SHORT G_M18874_IG23
-						;; size=14 bbWeight=428.98 PerfScore 1072.45
+						;; size=14 bbWeight=423.05 PerfScore 1057.63
 G_M18874_IG26:
        jmp      G_M18874_IG37
-						;; size=5 bbWeight=15.74 PerfScore 31.48
+						;; size=5 bbWeight=13.55 PerfScore 27.11
 G_M18874_IG27:
        jmp      G_M18874_IG41
-						;; size=5 bbWeight=0.50 PerfScore 1.01
+						;; size=5 bbWeight=0.51 PerfScore 1.01
 G_M18874_IG28:
-       jmp      G_M18874_IG54
-						;; size=5 bbWeight=0.50 PerfScore 1.01
+       jmp      G_M18874_IG55
+						;; size=5 bbWeight=0.51 PerfScore 1.01
 G_M18874_IG29:
        inc      edi
        mov      r8d, dword ptr [rsp+0xA4]
        cmp      edi, r8d
        jl       SHORT G_M18874_IG31
-						;; size=15 bbWeight=52.50 PerfScore 131.24
+						;; size=15 bbWeight=58.46 PerfScore 146.15
 G_M18874_IG30:
        mov      dword ptr [rsp+0xA4], r8d
        jmp      G_M18874_IG37
-						;; size=13 bbWeight=2.98 PerfScore 8.93
+						;; size=13 bbWeight=2.95 PerfScore 8.86
 G_M18874_IG31:
        mov      dword ptr [rsp+0xA4], r8d
        jmp      SHORT G_M18874_IG25
-						;; size=10 bbWeight=26.25 PerfScore 78.75
+						;; size=10 bbWeight=29.23 PerfScore 87.69
 G_M18874_IG32:
        mov      eax, dword ptr [rsp+0x108]
        mov      ecx, dword ptr [rsp+0xA8]
@@ -1596,7 +1601,7 @@ G_M18874_IG32:
        shr      eax, 5
        mov      r8d, dword ptr [rsp+0xA0]
        cmp      eax, r8d
-       jae      G_M18874_IG48
+       jae      G_M18874_IG49
        mov      eax, edx
        shr      eax, 5
        mov      r9, gword ptr [rsp+0x48]
@@ -1638,7 +1643,7 @@ G_M18874_IG37:
        mov      r8d, dword ptr [rsp+0xA4]
        cmp      edi, r8d
        jge      SHORT G_M18874_IG40
-						;; size=13 bbWeight=15.74 PerfScore 35.42
+						;; size=13 bbWeight=13.55 PerfScore 30.50
 G_M18874_IG38:
        mov      r10d, dword ptr [rsp+0xA8]
        mov      dword ptr [rsp+0x114], r10d
@@ -1650,7 +1655,7 @@ G_M18874_IG38:
        vmovsd   xmm1, qword ptr [reloc @RWD00]
        vucomisd xmm1, xmm0
        jae      SHORT G_M18874_IG41
-						;; size=50 bbWeight=4.01 PerfScore 130.86
+						;; size=50 bbWeight=4.01 PerfScore 131.06
 G_M18874_IG39:
        mov      r8d, edi
 						;; size=3 bbWeight=3.00 PerfScore 0.75
@@ -1659,14 +1664,14 @@ G_M18874_IG40:
        cmp      r15d, r12d
        mov      dword ptr [rsp+0xA4], r8d
        mov      gword ptr [rsp+0x98], r13
-       jl       G_M18874_IG47
-						;; size=28 bbWeight=6.94 PerfScore 24.29
+       jl       G_M18874_IG48
+						;; size=28 bbWeight=6.89 PerfScore 24.11
 G_M18874_IG41:
        mov      rbx, gword ptr [rsp+0x38]
        mov      r11, gword ptr [rsp+0x48]
        mov      rsi, r11
        test     rsi, rsi
-       je       G_M18874_IG75
+       je       G_M18874_IG76
 						;; size=22 bbWeight=1.88 PerfScore 6.57
 G_M18874_IG42:
        mov      r9d, dword ptr [rsi+0x08]
@@ -1679,19 +1684,21 @@ G_M18874_IG42:
        mov      rbp, bword ptr [rsp+0x40]
        mov      rcx, gword ptr [rbp]
        test     rcx, rcx
-       je       G_M18874_IG77
-						;; size=41 bbWeight=1 PerfScore 9.75
+       je       G_M18874_IG78
+						;; size=41 bbWeight=1.00 PerfScore 9.77
 G_M18874_IG43:
        xor      ebp, ebp
        mov      r14d, 1
        cmp      dword ptr [rcx+0x08], edi
-       jbe      SHORT G_M18874_IG44
+       jbe      SHORT G_M18874_IG45
+						;; size=13 bbWeight=1.00 PerfScore 4.51
+G_M18874_IG44:
        mov      ebp, 1
        mov      edx, 16
        shlx     edx, edx, edi
        mov      dword ptr [rsp+0xA0], r9d
        cmp      r9d, edx
-       jne      G_M18874_IG78
+       jne      G_M18874_IG79
        mov      edx, edi
        shl      rdx, 4
        lea      r15, bword ptr [rcx+rdx+0x10]
@@ -1703,17 +1710,17 @@ G_M18874_IG43:
        mov      dword ptr [r15+0x08], eax
        test     r13, r13
        mov      r9d, dword ptr [rsp+0xA0]
-       jne      G_M18874_IG79
-						;; size=93 bbWeight=1 PerfScore 16.50
-G_M18874_IG44:
+       jne      G_M18874_IG80
+						;; size=80 bbWeight=1.00 PerfScore 12.01
+G_M18874_IG45:
        mov      r15, gword ptr [rsp+0x30]
        cmp      byte  ptr [r15+0x9D], 0
-       jne      G_M18874_IG93
+       jne      G_M18874_IG94
 						;; size=19 bbWeight=1 PerfScore 5.00
-G_M18874_IG45:
+G_M18874_IG46:
        mov      eax, dword ptr [rsp+0x114]
 						;; size=7 bbWeight=1 PerfScore 1.00
-G_M18874_IG46:
+G_M18874_IG47:
        add      rsp, 280
        pop      rbx
        pop      rbp
@@ -1725,14 +1732,14 @@ G_M18874_IG46:
        pop      r15
        ret      
 						;; size=20 bbWeight=1 PerfScore 5.25
-G_M18874_IG47:
+G_M18874_IG48:
        mov      r9, gword ptr [rsp+0x48]
        jmp      G_M18874_IG17
-						;; size=10 bbWeight=3.47 PerfScore 10.41
-G_M18874_IG48:
+						;; size=10 bbWeight=3.44 PerfScore 10.33
+G_M18874_IG49:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M18874_IG49:
+G_M18874_IG50:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.HashSet`1[int]
        call     CORINFO_HELP_NEWSFAST
        mov      r13, rax
@@ -1741,30 +1748,29 @@ G_M18874_IG49:
        xor      r8, r8
        call     [System.Collections.Generic.HashSet`1[int]:.ctor(int,System.Collections.Generic.IEqualityComparer`1[int]):this]
        xor      ebp, ebp
-       jmp      SHORT G_M18874_IG51
+       jmp      SHORT G_M18874_IG52
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M18874_IG50:
-       mov      r8d, ebp
-       mov      edx, dword ptr [rbx+4*r8]
+G_M18874_IG51:
+       mov      edx, dword ptr [rbx+4*rbp]
        lea      r8, [rsp+0xF0]
        mov      rcx, r13
        call     [<unknown method>]
        inc      ebp
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M18874_IG51:
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M18874_IG52:
        cmp      ebp, esi
-       jl       SHORT G_M18874_IG50
+       jl       SHORT G_M18874_IG51
        mov      ebp, dword ptr [r13+0x28]
        sub      ebp, dword ptr [r13+0x30]
        mov      gword ptr [rsp+0x98], r13
        jmp      G_M18874_IG03
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M18874_IG52:
+G_M18874_IG53:
        mov      ecx, ebp
        call     [System.Collections.HashHelpers:GetPrime(int):int]
        nop      
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M18874_IG53:
+G_M18874_IG54:
        add      rsp, 280
        pop      rbx
        pop      rbp
@@ -1776,29 +1782,29 @@ G_M18874_IG53:
        pop      r15
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M18874_IG54:
+G_M18874_IG55:
        mov      r8, gword ptr [rsp+0x88]
        mov      rcx, gword ptr [r8+0x10]
        mov      r10d, dword ptr [rsp+0xE8]
        cmp      dword ptr [rcx+0x08], r10d
-       jbe      G_M18874_IG66
+       jbe      G_M18874_IG67
        mov      edx, r10d
        mov      rcx, gword ptr [rcx+8*rdx+0x10]
        test     rcx, rcx
-       je       G_M18874_IG65
+       je       G_M18874_IG66
        mov      r9, gword ptr [rcx+0x08]
        mov      gword ptr [rsp+0x70], r9
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 824
+       mov      edx, 878
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        cmp      byte  ptr [(reloc)], 0      ; data for <unknown class>:<unknown field>
-       je       SHORT G_M18874_IG55
+       je       SHORT G_M18874_IG56
        call     [System.Threading.Thread:GetCurrentProcessorNumber():int]
        mov      edx, eax
        mov      dword ptr [rsp+0xC0], edx
-       jmp      SHORT G_M18874_IG58
+       jmp      SHORT G_M18874_IG59
 						;; size=102 bbWeight=0 PerfScore 0.00
-G_M18874_IG55:
+G_M18874_IG56:
        mov      ecx, 2
        call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
        mov      eax, dword ptr [rax+0x0AAC]
@@ -1810,32 +1816,32 @@ G_M18874_IG55:
        mov      dword ptr [rax+0x0AAC], edx
        movzx    rax, cx
        test     eax, eax
-       jne      SHORT G_M18874_IG56
+       jne      SHORT G_M18874_IG57
        call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
        mov      edx, eax
-       jmp      SHORT G_M18874_IG57
+       jmp      SHORT G_M18874_IG58
 						;; size=66 bbWeight=0 PerfScore 0.00
-G_M18874_IG56:
+G_M18874_IG57:
        mov      edx, ecx
        sar      edx, 16
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M18874_IG57:
+G_M18874_IG58:
        mov      dword ptr [rsp+0xC0], edx
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M18874_IG58:
+G_M18874_IG59:
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 726
+       mov      edx, 780
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov      eax, dword ptr [rsp+0xC0]
        xor      edx, edx
        div      edx:eax, dword ptr [(reloc)]
        mov      eax, edx
        xor      edx, edx
-       jmp      G_M18874_IG62
+       jmp      G_M18874_IG63
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M18874_IG59:
+G_M18874_IG60:
        cmp      eax, dword ptr [r8+0x08]
-       jae      G_M18874_IG48
+       jae      G_M18874_IG49
        mov      dword ptr [rsp+0xC8], eax
        mov      ecx, eax
        mov      r10, gword ptr [r8+8*rcx+0x10]
@@ -1850,7 +1856,7 @@ G_M18874_IG59:
        mov      eax, dword ptr [r10+0x14]
        dec      eax
        cmp      dword ptr [rcx+0x08], eax
-       jbe      SHORT G_M18874_IG60
+       jbe      SHORT G_M18874_IG61
        mov      edx, eax
        mov      r9, gword ptr [rcx+8*rdx+0x10]
        mov      gword ptr [rsp+0x68], r9
@@ -1859,40 +1865,40 @@ G_M18874_IG59:
        mov      gword ptr [rcx+8*r8+0x10], r9
        mov      dword ptr [r10+0x14], eax
 						;; size=95 bbWeight=0 PerfScore 0.00
-G_M18874_IG60:
+G_M18874_IG61:
        mov      rcx, r10
        call     <unknown method>
        mov      rcx, gword ptr [rsp+0x68]
        test     rcx, rcx
-       jne      SHORT G_M18874_IG63
+       jne      SHORT G_M18874_IG64
        mov      eax, dword ptr [rsp+0xC8]
        inc      eax
        mov      ecx, eax
        mov      r8, gword ptr [rsp+0x70]
        cmp      dword ptr [r8+0x08], ecx
-       jne      SHORT G_M18874_IG61
+       jne      SHORT G_M18874_IG62
        xor      ecx, ecx
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M18874_IG61:
+G_M18874_IG62:
        mov      edx, dword ptr [rsp+0xC4]
        inc      edx
        mov      eax, ecx
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M18874_IG62:
+G_M18874_IG63:
        mov      r8, gword ptr [rsp+0x70]
        mov      dword ptr [rsp+0xC4], edx
        cmp      dword ptr [r8+0x08], edx
-       jg       G_M18874_IG59
+       jg       G_M18874_IG60
        xor      r10, r10
-       jmp      SHORT G_M18874_IG64
+       jmp      SHORT G_M18874_IG65
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M18874_IG63:
+G_M18874_IG64:
        mov      r10, rcx
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M18874_IG64:
+G_M18874_IG65:
        mov      r8, r10
        test     r8, r8
-       je       G_M18874_IG65
+       je       G_M18874_IG66
        mov      rax, gword ptr [rsp+0x80]
        cmp      byte  ptr [rax+0x9D], 0
        mov      r10, r8
@@ -1916,16 +1922,16 @@ G_M18874_IG64:
        mov      r10, gword ptr [rsp+0x78]
        jmp      G_M18874_IG15
 						;; size=138 bbWeight=0 PerfScore 0.00
-G_M18874_IG65:
+G_M18874_IG66:
        mov      ecx, 16
        mov      r10d, dword ptr [rsp+0xE8]
        shlx     r9d, ecx, r10d
-       jmp      SHORT G_M18874_IG69
+       jmp      SHORT G_M18874_IG70
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M18874_IG66:
+G_M18874_IG67:
        mov      r9d, dword ptr [rsp+0xEC]
        test     r9d, r9d
-       jne      SHORT G_M18874_IG67
+       jne      SHORT G_M18874_IG68
        mov      rcx, 0xD1FFAB1E
        mov      edx, 41
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -1935,31 +1941,31 @@ G_M18874_IG66:
        mov      r8, rcx
        jmp      G_M18874_IG16
 						;; size=57 bbWeight=0 PerfScore 0.00
-G_M18874_IG67:
+G_M18874_IG68:
        mov      dword ptr [rsp+0xEC], r9d
        mov      ecx, r9d
        mov      rdx, 0xD1FFAB1E
        call     [System.ArgumentOutOfRangeException:ThrowIfNegative[int](int,System.String)]
        mov      r9d, dword ptr [rsp+0xEC]
-       jmp      SHORT G_M18874_IG69
+       jmp      SHORT G_M18874_IG70
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M18874_IG68:
+G_M18874_IG69:
        movsxd   rdx, r9d
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
        mov      r8, rax
-       jmp      SHORT G_M18874_IG70
+       jmp      SHORT G_M18874_IG71
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M18874_IG69:
+G_M18874_IG70:
        cmp      r9d, 512
-       jl       SHORT G_M18874_IG68
+       jl       SHORT G_M18874_IG69
        mov      edx, r9d
        mov      rcx, 0xD1FFAB1E      ; int[]
        mov      r8d, 16
        call     <unknown method>
        mov      r8, rax
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M18874_IG70:
+G_M18874_IG71:
        mov      rax, r8
        mov      rdx, gword ptr [rsp+0x80]
        cmp      byte  ptr [rdx+0x9D], 0
@@ -2003,12 +2009,12 @@ G_M18874_IG70:
        mov      r10, gword ptr [rsp+0x78]
        jmp      G_M18874_IG15
 						;; size=239 bbWeight=0 PerfScore 0.00
-G_M18874_IG71:
+G_M18874_IG72:
        mov      edx, dword ptr [rsp+0xA8]
        mov      r8d, edx
        jmp      G_M18874_IG18
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M18874_IG72:
+G_M18874_IG73:
        mov      ebx, dword ptr [r13+0x04]
        add      ebx, -24
        shr      ebx, 3
@@ -2023,7 +2029,7 @@ G_M18874_IG72:
        mov      rbx, bword ptr [rsp+0x50]
        jmp      G_M18874_IG19
 						;; size=52 bbWeight=0 PerfScore 0.00
-G_M18874_IG73:
+G_M18874_IG74:
        mov      rdx, rax
        shr      rdx, 3
        mov      rcx, r10
@@ -2033,7 +2039,7 @@ G_M18874_IG73:
        test     r13, r13
        je       G_M18874_IG22
 						;; size=35 bbWeight=0 PerfScore 0.00
-G_M18874_IG74:
+G_M18874_IG75:
        cmp      ebp, esi
        je       G_M18874_IG22
        lea      rdx, [rsp+0xF8]
@@ -2041,16 +2047,16 @@ G_M18874_IG74:
        call     [System.Collections.Generic.HashSet`1[int]:GetEnumerator():System.Collections.Generic.HashSet`1+Enumerator[int]:this]
        jmp      G_M18874_IG36
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M18874_IG75:
+G_M18874_IG76:
        mov      ecx, 2
        call     [System.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M18874_IG76:
+G_M18874_IG77:
        call     [System.ThrowHelper:ThrowIndexOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M18874_IG77:
+G_M18874_IG78:
        mov      dword ptr [rsp+0xA0], r9d
        mov      rcx, rbx
        call     [System.Buffers.SharedArrayPool`1[int]:InitializeTlsBucketsAndTrimming():System.Buffers.SharedArrayPoolThreadLocalArray[]:this]
@@ -2058,7 +2064,7 @@ G_M18874_IG77:
        mov      r9d, dword ptr [rsp+0xA0]
        jmp      G_M18874_IG43
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M18874_IG78:
+G_M18874_IG79:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
@@ -2074,32 +2080,32 @@ G_M18874_IG78:
        mov      rcx, rbx
        call     CORINFO_HELP_THROW
 						;; size=70 bbWeight=0 PerfScore 0.00
-G_M18874_IG79:
+G_M18874_IG80:
        mov      rcx, gword ptr [rbx+0x10]
        cmp      edi, dword ptr [rcx+0x08]
-       jae      G_M18874_IG48
+       jae      G_M18874_IG49
        mov      edx, edi
        mov      r8, gword ptr [rcx+8*rdx+0x10]
        test     r8, r8
        mov      dword ptr [rsp+0xA0], r9d
-       jne      SHORT G_M18874_IG80
+       jne      SHORT G_M18874_IG81
        mov      rcx, rbx
        mov      edx, edi
        call     [System.Buffers.SharedArrayPool`1[int]:CreatePerCorePartitions(int):System.Buffers.SharedArrayPoolPartitions:this]
        mov      r8, rax
 						;; size=47 bbWeight=0 PerfScore 0.00
-G_M18874_IG80:
+G_M18874_IG81:
        mov      r14, gword ptr [r8+0x08]
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 824
+       mov      edx, 878
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        cmp      byte  ptr [(reloc)], 0      ; data for <unknown class>:<unknown field>
-       je       SHORT G_M18874_IG81
+       je       SHORT G_M18874_IG82
        call     [System.Threading.Thread:GetCurrentProcessorNumber():int]
        mov      r15d, eax
-       jmp      SHORT G_M18874_IG84
+       jmp      SHORT G_M18874_IG85
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M18874_IG81:
+G_M18874_IG82:
        mov      ecx, 2
        call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
        mov      r15d, dword ptr [rax+0x0AAC]
@@ -2109,31 +2115,31 @@ G_M18874_IG81:
        mov      dword ptr [rax+0x0AAC], ecx
        movzx    rax, r15w
        test     eax, eax
-       jne      SHORT G_M18874_IG82
+       jne      SHORT G_M18874_IG83
        call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
-       jmp      SHORT G_M18874_IG83
+       jmp      SHORT G_M18874_IG84
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M18874_IG82:
+G_M18874_IG83:
        mov      eax, r15d
        sar      eax, 16
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M18874_IG83:
+G_M18874_IG84:
        mov      r15d, eax
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M18874_IG84:
+G_M18874_IG85:
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 726
+       mov      edx, 780
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov      eax, r15d
        xor      edx, edx
        div      edx:eax, dword ptr [(reloc)]
        mov      r15d, edx
        xor      r12d, r12d
-       jmp      G_M18874_IG89
+       jmp      G_M18874_IG90
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M18874_IG85:
+G_M18874_IG86:
        cmp      r15d, dword ptr [r14+0x08]
-       jae      G_M18874_IG48
+       jae      G_M18874_IG49
        mov      ecx, r15d
        mov      rax, gword ptr [r14+8*rcx+0x10]
        mov      gword ptr [rsp+0x58], rax
@@ -2147,13 +2153,13 @@ G_M18874_IG85:
        mov      r8d, dword ptr [rax+0x14]
        mov      dword ptr [rsp+0xAC], r8d
        cmp      dword ptr [rcx+0x08], r8d
-       jbe      SHORT G_M18874_IG87
+       jbe      SHORT G_M18874_IG88
        test     r8d, r8d
-       jne      SHORT G_M18874_IG90
+       jne      SHORT G_M18874_IG91
        xor      edx, edx
        mov      dword ptr [rax+0x18], edx
 						;; size=79 bbWeight=0 PerfScore 0.00
-G_M18874_IG86:
+G_M18874_IG87:
        movsxd   rdx, r8d
        lea      rcx, bword ptr [rcx+8*rdx+0x10]
        mov      rdx, r13
@@ -2164,39 +2170,39 @@ G_M18874_IG86:
        mov      dword ptr [rax+0x14], ecx
        mov      dword ptr [rsp+0xB0], 1
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M18874_IG87:
+G_M18874_IG88:
        mov      rcx, rax
        call     <unknown method>
        cmp      dword ptr [rsp+0xB0], 0
-       jne      SHORT G_M18874_IG91
+       jne      SHORT G_M18874_IG92
        inc      r15d
        cmp      dword ptr [r14+0x08], r15d
-       jne      SHORT G_M18874_IG88
+       jne      SHORT G_M18874_IG89
        xor      r15d, r15d
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M18874_IG88:
+G_M18874_IG89:
        inc      r12d
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M18874_IG89:
-       cmp      dword ptr [r14+0x08], r12d
-       jg       G_M18874_IG85
-       xor      r14d, r14d
-       jmp      SHORT G_M18874_IG92
-						;; size=15 bbWeight=0 PerfScore 0.00
 G_M18874_IG90:
-       jmp      SHORT G_M18874_IG86
-						;; size=2 bbWeight=0 PerfScore 0.00
+       cmp      dword ptr [r14+0x08], r12d
+       jg       G_M18874_IG86
+       xor      r14d, r14d
+       jmp      SHORT G_M18874_IG93
+						;; size=15 bbWeight=0 PerfScore 0.00
 G_M18874_IG91:
+       jmp      SHORT G_M18874_IG87
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M18874_IG92:
        mov      r14d, 1
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M18874_IG92:
-       mov      r9d, dword ptr [rsp+0xA0]
-       jmp      G_M18874_IG44
-						;; size=13 bbWeight=0 PerfScore 0.00
 G_M18874_IG93:
+       mov      r9d, dword ptr [rsp+0xA0]
+       jmp      G_M18874_IG45
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M18874_IG94:
        mov      dword ptr [rsp+0xA0], r9d
        test     r9d, r9d
-       je       G_M18874_IG45
+       je       G_M18874_IG46
        mov      rcx, rsi
        call     <unknown method>
        mov      r13d, eax
@@ -2211,7 +2217,7 @@ G_M18874_IG93:
        mov      edx, 3
        call     [<unknown method>]
        test     ebp, r14d
-       jne      G_M18874_IG45
+       jne      G_M18874_IG46
        mov      rcx, rsi
        call     <unknown method>
        mov      esi, eax
@@ -2220,33 +2226,33 @@ G_M18874_IG93:
        call     <unknown method>
        mov      r9d, eax
        test     ebp, ebp
-       jne      SHORT G_M18874_IG94
+       jne      SHORT G_M18874_IG95
        mov      ecx, -1
-       jmp      SHORT G_M18874_IG95
-						;; size=130 bbWeight=0 PerfScore 0.00
-G_M18874_IG94:
-       mov      ecx, edi
        jmp      SHORT G_M18874_IG96
-						;; size=4 bbWeight=0 PerfScore 0.00
+						;; size=130 bbWeight=0 PerfScore 0.00
 G_M18874_IG95:
-       mov      edx, 1
+       mov      ecx, edi
        jmp      SHORT G_M18874_IG97
-						;; size=7 bbWeight=0 PerfScore 0.00
+						;; size=4 bbWeight=0 PerfScore 0.00
 G_M18874_IG96:
+       mov      edx, 1
+       jmp      SHORT G_M18874_IG98
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M18874_IG97:
        xor      edx, edx
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M18874_IG97:
+G_M18874_IG98:
        mov      dword ptr [rsp+0x20], ecx
        mov      dword ptr [rsp+0x28], edx
        mov      rcx, r15
        mov      edx, esi
        mov      r8d, r12d
        call     [<unknown method>]
-       jmp      G_M18874_IG45
+       jmp      G_M18874_IG46
 						;; size=27 bbWeight=0 PerfScore 0.00
 RWD00  	dq	3FA999999999999Ah	;         0.05
 
 
-; Total bytes of code 3223, prolog size 42, PerfScore 19586.33, instruction count 724, allocated bytes for code 3223 (MethodHash=a5deb645) for method System.Collections.Frozen.FrozenHashTable:CalcNumBuckets(System.ReadOnlySpan`1[int],ubyte):int (Tier1)
+; Total bytes of code 3215, prolog size 42, PerfScore 19202.99, instruction count 723, allocated bytes for code 3215 (MethodHash=a5deb645) for method System.Collections.Frozen.FrozenHashTable:CalcNumBuckets(System.ReadOnlySpan`1[int],ubyte):int (Tier1)
 ; ============================================================
 


```

### ``[System.Collections.Immutable]System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[System.Int16,System.Int16]..ctor(class System.Collections.Generic.Dictionary`2<!0,!1>,bool)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 27119.91
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 27900.04
 ; 27 inlinees with PGO data; 58 single block inlinees; 7 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T33] ( 13, 196.53)     ref  ->  [rsp+0x1B0]  this class-hnd single-def <System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[short,short]>
-;  V01 arg1         [V01,T52] (  9,   8.82)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.Dictionary`2[short,short]>
+;  V00 this         [V00,T33] ( 13, 200.09)     ref  ->  [rsp+0x1B0]  this class-hnd single-def <System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[short,short]>
+;  V01 arg1         [V01,T52] (  9,   8.67)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.Dictionary`2[short,short]>
 ;  V02 arg2         [V02,T58] (  3,   2.99)   ubyte  ->  rdi         single-def
-;  V03 loc0         [V03,T19] ( 11, 254.62)     ref  ->  r14         class-hnd exact single-def <System.Collections.Generic.KeyValuePair`2[short,short][]>
+;  V03 loc0         [V03,T22] ( 11, 258.41)     ref  ->  r14         class-hnd exact single-def <System.Collections.Generic.KeyValuePair`2[short,short][]>
 ;  V04 loc1         [V04,T53] ( 13,   7.94)     ref  ->  [rsp+0xD0]  class-hnd spill-single-def <int[]>
 ;* V05 loc2         [V05    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[int]>
-;  V06 loc3         [V06,T10] (  7, 381.71)     int  ->  [rsp+0x164] 
-;  V07 loc4         [V07,T15] ( 15, 316.28)     int  ->  rcx        
-;  V08 loc5         [V08,T16] ( 10, 312.78)     int  ->  rax        
+;* V06 loc3         [V06,T116] (  0,   0   )     int  ->  zero-ref   
+;  V07 loc4         [V07,T15] ( 15, 321.10)     int  ->  rcx        
+;  V08 loc5         [V08,T16] ( 10, 317.57)     int  ->  rax        
 ;  V09 OutArgs      [V09    ] (  1,   1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V10 tmp1         [V10,T56] (  3,   5.96)     ref  ->  rsi         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
-;  V11 tmp2         [V11,T22] (  2, 253.81)   byref  ->  [rsp+0xC8]  spill-single-def "impAppendStmt"
-;  V12 tmp3         [V12,T20] (  3, 253.81)     ref  ->   r9         class-hnd "impAppendStmt" <System.Collections.Generic.IEqualityComparer`1[short]>
-;  V13 tmp4         [V13,T21] (  3, 253.81)     int  ->  rdx         "spilling ret_expr"
-;  V14 tmp5         [V14,T12] (  6, 375.34)     ref  ->   r8         class-hnd "impAppendStmt" <<unknown class>>
-;  V15 tmp6         [V15,T29] (  4, 250.22)     int  ->  r10         "Strict ordering of exceptions for Array store"
-;  V16 tmp7         [V16,T13] (  6, 375.34)     ref  ->   r9         class-hnd "impAppendStmt" <<unknown class>>
-;  V17 tmp8         [V17,T30] (  4, 250.22)     int  ->  rdx         "Strict ordering of exceptions for Array store"
-;  V18 tmp9         [V18,T74] (  2,   3.97)     ref  ->  rdi         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V10 tmp1         [V10,T56] (  3,   5.95)     ref  ->  rsi         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V11 tmp2         [V11,T19] (  2, 260.40)   byref  ->  [rsp+0xC8]  spill-single-def "impAppendStmt"
+;  V12 tmp3         [V12,T17] (  3, 260.40)     ref  ->   r9         class-hnd "impAppendStmt" <System.Collections.Generic.IEqualityComparer`1[short]>
+;  V13 tmp4         [V13,T18] (  3, 260.40)     int  ->  rdx         "spilling ret_expr"
+;  V14 tmp5         [V14,T11] (  6, 381.08)     ref  ->   r8         class-hnd "impAppendStmt" <<unknown class>>
+;  V15 tmp6         [V15,T25] (  4, 254.05)     int  ->  r10         "Strict ordering of exceptions for Array store"
+;  V16 tmp7         [V16,T12] (  6, 381.08)     ref  ->   r9         class-hnd "impAppendStmt" <<unknown class>>
+;  V17 tmp8         [V17,T26] (  4, 254.05)     int  ->  rdx         "Strict ordering of exceptions for Array store"
+;  V18 tmp9         [V18,T76] (  2,   3.97)     ref  ->  rdi         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
 ;* V19 tmp10        [V19    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Collections.Generic.Dictionary`2[short,short]>
-;  V20 tmp11        [V20,T93] (  3,   1.99)     ref  ->  r12         "guarded devirt return temp"
+;  V20 tmp11        [V20,T95] (  3,   1.98)     ref  ->  r12         "guarded devirt return temp"
 ;  V21 tmp12        [V21,T79] (  2,   3.97)     int  ->  r13         "guarded devirt arg temp"
-;  V22 tmp13        [V22,T106] (  6,   0.99)     ref  ->  r12         class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
-;  V23 tmp14        [V23,T43] (  3, 126.91)     int  ->  rdx         "guarded devirt return temp"
+;  V22 tmp13        [V22,T112] (  6,   0.99)     ref  ->  r12         class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
+;  V23 tmp14        [V23,T40] (  3, 130.20)     int  ->  rdx         "guarded devirt return temp"
 ;* V24 tmp15        [V24    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[short]>
-;  V25 tmp16        [V25,T107] (  6,   0.99)     ref  ->  rdi         class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
+;  V25 tmp16        [V25,T113] (  6,   0.99)     ref  ->  rdi         class-hnd exact single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
 ;* V26 tmp17        [V26    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Collections.Generic.IEqualityComparer`1[short]>
 ;  V27 tmp18        [V27,T67] (  2,   4   )     ref  ->  rdx         class-hnd single-def "dup spill" <System.Collections.Generic.IEqualityComparer`1[short]>
 ;  V28 tmp19        [V28,T57] (  5,   5   )     ref  ->  rdx        
-;  V29 tmp20        [V29,T24] (  5, 253.43)     int  ->  registers   "Inlining Arg"
+;  V29 tmp20        [V29,T24] (  5, 254.48)     int  ->  registers   "Inlining Arg"
 ;* V30 tmp21        [V30    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V31 tmp22        [V31,T47] (  5,  66.92)     int  ->  rcx         "Inline stloc first use temp"
-;  V32 tmp23        [V32,T35] (  9, 191.59)     ref  ->  rax         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V33 tmp24        [V33,T25] ( 10, 252.89)     int  ->   r8         "Inline stloc first use temp"
-;  V34 tmp25        [V34,T03] (  8, 501.21)     int  ->  rdx         "impSpillLclRefs"
+;  V31 tmp22        [V31,T47] (  5,  67.00)     int  ->  rcx         "Inline stloc first use temp"
+;  V32 tmp23        [V32,T36] (  9, 192.27)     ref  ->  rax         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V33 tmp24        [V33,T27] ( 10, 254.03)     int  ->   r8         "Inline stloc first use temp"
+;  V34 tmp25        [V34,T03] (  8, 503.63)     int  ->  rdx         "impSpillLclRefs"
 ;* V35 tmp26        [V35    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[short,short]>
-;  V36 tmp27        [V36,T26] (  4, 250.61)   short  ->  r11         "Inlining Arg"
-;  V37 tmp28        [V37,T27] (  4, 250.61)   short  ->  r10         "Inlining Arg"
+;  V36 tmp27        [V36,T28] (  4, 251.81)   short  ->  r11         "Inlining Arg"
+;  V37 tmp28        [V37,T29] (  4, 251.81)   short  ->  r10         "Inlining Arg"
 ;  V38 tmp29        [V38,T84] (  8,   2.98)     ref  ->  [rsp+0xC0]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
-;  V39 tmp30        [V39,T69] (  8,   3.97)     int  ->  registers   "Inlining Arg"
-;  V40 tmp31        [V40,T68] (  9,   3.97)     int  ->  [rsp+0x160]  spill-single-def "Inline stloc first use temp"
+;  V39 tmp30        [V39,T74] (  8,   3.97)     int  ->  registers   "Inlining Arg"
+;  V40 tmp31        [V40,T73] (  9,   3.97)     int  ->  [rsp+0x164]  spill-single-def "Inline stloc first use temp"
 ;  V41 tmp32        [V41,T65] (  5,   4.96)     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V42 tmp33        [V42,T139] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V43 tmp34        [V43,T59] ( 14,   4.96)     ref  ->  [rsp+0xB8]  class-hnd "Inline stloc first use temp" <int[]>
-;  V44 tmp35        [V44,T149] (  3,   0   )     int  ->  rsi         "Inline stloc first use temp"
-;  V45 tmp36        [V45,T170] (  2,   0   )     int  ->  [rsp+0x15C]  spill-single-def "impAppendStmt"
-;  V46 tmp37        [V46,T171] (  2,   0   )     int  ->  [rsp+0x158]  spill-single-def "impAppendStmt"
-;  V47 tmp38        [V47,T172] (  2,   0   )     int  ->   r9         "impAppendStmt"
+;  V42 tmp33        [V42,T142] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V43 tmp34        [V43,T63] ( 14,   4.96)     ref  ->  [rsp+0xB8]  class-hnd "Inline stloc first use temp" <int[]>
+;  V44 tmp35        [V44,T152] (  3,   0   )     int  ->  rsi         "Inline stloc first use temp"
+;  V45 tmp36        [V45,T173] (  2,   0   )     int  ->  [rsp+0x160]  spill-single-def "impAppendStmt"
+;  V46 tmp37        [V46,T174] (  2,   0   )     int  ->  [rsp+0x15C]  spill-single-def "impAppendStmt"
+;  V47 tmp38        [V47,T175] (  2,   0   )     int  ->   r9         "impAppendStmt"
 ;* V48 tmp39        [V48    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V49 tmp40        [V49    ] (  0,   0   )     int  ->  zero-ref   
 ;* V50 tmp41        [V50    ] (  0,   0   )     int  ->  zero-ref   
@@ -689,68 +689,68 @@ G_M58412_IG15:
 ;* V55 tmp46        [V55    ] (  0,   0   )     int  ->  zero-ref   
 ;* V56 tmp47        [V56    ] (  0,   0   )     int  ->  zero-ref   
 ;* V57 tmp48        [V57    ] (  0,   0   )     int  ->  zero-ref   
-;  V58 tmp49        [V58,T173] (  2,   0   )     int  ->  rdx        
-;  V59 tmp50        [V59,T140] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
+;  V58 tmp49        [V58,T176] (  2,   0   )     int  ->  rdx        
+;  V59 tmp50        [V59,T143] (  3,   0   )     ref  ->  rcx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
 ;* V60 tmp51        [V60    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "updating class info" <int[]>
-;  V61 tmp52        [V61,T174] (  2,   0   )     int  ->  rsi         "impAppendStmt"
-;  V62 tmp53        [V62,T175] (  2,   0   )     int  ->  [rsp+0x154]  spill-single-def "impAppendStmt"
+;  V61 tmp52        [V61,T177] (  2,   0   )     int  ->  rsi         "impAppendStmt"
+;  V62 tmp53        [V62,T178] (  2,   0   )     int  ->  [rsp+0x158]  spill-single-def "impAppendStmt"
 ;* V63 tmp54        [V63    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "updating class info" <int[]>
 ;  V64 tmp55        [V64,T80] (  2,   3.97)     int  ->  r12         "impAppendStmt"
-;  V65 tmp56        [V65,T81] (  2,   3.97)     int  ->  [rsp+0x150]  spill-single-def "impAppendStmt"
+;  V65 tmp56        [V65,T81] (  2,   3.97)     int  ->  [rsp+0x154]  spill-single-def "impAppendStmt"
 ;* V66 tmp57        [V66    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V67 tmp58        [V67    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V68 tmp59        [V68,T141] (  3,   0   )     ref  ->  r10         class-hnd "Inline return value spill temp" <System.Array>
-;  V69 tmp60        [V69,T123] (  5,   0   )     ref  ->  r13         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V70 tmp61        [V70,T120] (  7,   0   )     int  ->  rsi         "Inline stloc first use temp"
-;  V71 tmp62        [V71,T133] (  4,   0   )     int  ->  [rsp+0x14C]  "Inline stloc first use temp"
+;  V68 tmp59        [V68,T144] (  3,   0   )     ref  ->  r10         class-hnd "Inline return value spill temp" <System.Array>
+;  V69 tmp60        [V69,T126] (  5,   0   )     ref  ->  r13         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V70 tmp61        [V70,T123] (  7,   0   )     int  ->  rsi         "Inline stloc first use temp"
+;  V71 tmp62        [V71,T136] (  4,   0   )     int  ->  [rsp+0x150]  "Inline stloc first use temp"
 ;* V72 tmp63        [V72    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "dup spill" <System.Array>
 ;* V73 tmp64        [V73    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Array>
-;  V74 tmp65        [V74,T176] (  2,   0   )     int  ->  rsi         "dup spill"
-;  V75 tmp66        [V75,T150] (  3,   0   )     int  ->  rsi         "Inline return value spill temp"
-;  V76 tmp67        [V76,T151] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
-;  V77 tmp68        [V77,T134] (  4,   0   )     int  ->  rsi         "dup spill"
+;  V74 tmp65        [V74,T179] (  2,   0   )     int  ->  rsi         "dup spill"
+;  V75 tmp66        [V75,T153] (  3,   0   )     int  ->  rsi         "Inline return value spill temp"
+;  V76 tmp67        [V76,T154] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V77 tmp68        [V77,T137] (  4,   0   )     int  ->  rsi         "dup spill"
 ;* V78 tmp69        [V78    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V79 tmp70        [V79    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Array>
-;  V80 tmp71        [V80,T129] (  4,   0   )     ref  ->  [rsp+0xB0]  class-hnd "Inline stloc first use temp" <System.Array>
-;  V81 tmp72        [V81,T119] (  7,   0   )     ref  ->  [rsp+0xA8]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
-;  V82 tmp73        [V82,T130] (  4,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V83 tmp74        [V83,T126] (  5,   0   )     int  ->  rax         "Inline stloc first use temp"
+;  V80 tmp71        [V80,T132] (  4,   0   )     ref  ->  [rsp+0xB0]  class-hnd "Inline stloc first use temp" <System.Array>
+;  V81 tmp72        [V81,T122] (  7,   0   )     ref  ->  [rsp+0xA8]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
+;  V82 tmp73        [V82,T133] (  4,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V83 tmp74        [V83,T129] (  5,   0   )     int  ->  rax         "Inline stloc first use temp"
 ;* V84 tmp75        [V84    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V85 tmp76        [V85,T142] (  3,   0   )     ref  ->  rax         class-hnd "Inline return value spill temp" <int[]>
+;  V85 tmp76        [V85,T145] (  3,   0   )     ref  ->  rax         class-hnd "Inline return value spill temp" <int[]>
 ;* V86 tmp77        [V86    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V87 tmp78        [V87    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "updating class info" <int[]>
-;  V88 tmp79        [V88,T55] (  4,   5.96)     int  ->  r13         "Inlining Arg"
+;  V88 tmp79        [V88,T55] (  4,   5.95)     int  ->  r13         "Inlining Arg"
 ;* V89 tmp80        [V89    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
 ;* V90 tmp81        [V90    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V91 tmp82        [V91,T23] (  2, 253.81)   short  ->  rdx         ld-addr-op "Inlining Arg"
+;  V91 tmp82        [V91,T20] (  2, 260.40)   short  ->  rdx         ld-addr-op "Inlining Arg"
 ;* V92 tmp83        [V92    ] (  0,   0   )  struct (24) zero-ref    "Inline return value spill temp" <System.Collections.Frozen.FrozenHashTable>
 ;* V93 tmp84        [V93    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
 ;* V94 tmp85        [V94    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[int]>
-;  V95 tmp86        [V95,T54] (  9,   6.95)     int  ->  rdi         "Inline stloc first use temp"
-;  V96 tmp87        [V96,T48] (  3,  65.84)    long  ->  [rsp+0x140]  spill-single-def "Inline stloc first use temp"
-;  V97 tmp88        [V97,T75] (  2,   3.97)     ref  ->  rcx         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
-;  V98 tmp89        [V98,T51] ( 19,  12.91)     ref  ->  [rsp+0xA0]  class-hnd spill-single-def "Inline stloc first use temp" <int[]>
+;  V95 tmp86        [V95,T54] (  9,   6.94)     int  ->  rdi         "Inline stloc first use temp"
+;  V96 tmp87        [V96,T48] (  3,  66.35)    long  ->  [rsp+0x148]  spill-single-def "Inline stloc first use temp"
+;  V97 tmp88        [V97,T77] (  2,   3.97)     ref  ->  rcx         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V98 tmp89        [V98,T51] ( 19,  12.90)     ref  ->  [rsp+0xA0]  class-hnd spill-single-def "Inline stloc first use temp" <int[]>
 ;* V99 tmp90        [V99    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Span`1[int]>
 ;* V100 tmp91       [V100    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Span`1[int]>
-;  V101 tmp92       [V101,T02] (  9, 511.79)     int  ->  rdx         "Inline stloc first use temp"
+;* V101 tmp92       [V101,T117] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V102 tmp93       [V102    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V103 tmp94       [V103    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V104 tmp95       [V104,T36] (  3, 191.55)   byref  ->  rcx         "Inline stloc first use temp"
-;  V105 tmp96       [V105,T40] (  4, 130.97)     ref  ->  [rsp+0x98]  class-hnd exact spill-single-def "Inline stloc first use temp" <int[]>
-;  V106 tmp97       [V106,T50] (  4,  63.78)     ref  ->  [rsp+0x90]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Collections.Frozen.FrozenHashTable+Bucket[]>
-;  V107 tmp98       [V107,T09] (  7, 384.25)     int  ->  rcx         "Inline stloc first use temp"
-;  V108 tmp99       [V108,T00] (  7,2230.46)     int  ->  rax         "Inline stloc first use temp"
-;  V109 tmp100      [V109,T01] (  5,1049.86)     int  ->  registers   "Inline stloc first use temp"
-;  V110 tmp101      [V110,T28] (  4, 250.58)     int  ->  r11         "Inline stloc first use temp"
-;  V111 tmp102      [V111,T06] (  7, 447.75)     int  ->  r10         "Inline stloc first use temp"
-;  V112 tmp103      [V112,T34] (  3, 193.47)   byref  ->  [rsp+0x88]  spill-single-def "Inline stloc first use temp"
-;  V113 tmp104      [V113,T17] (  2, 257.97)     int  ->  rbp         "Strict ordering of exceptions for Array store"
+;  V104 tmp95       [V104,T34] (  3, 193.09)   byref  ->  rcx         "Inline stloc first use temp"
+;  V105 tmp96       [V105,T41] (  4, 130.11)     ref  ->  [rsp+0x98]  class-hnd exact spill-single-def "Inline stloc first use temp" <int[]>
+;  V106 tmp97       [V106,T50] (  4,  64.19)     ref  ->  [rsp+0x90]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Collections.Frozen.FrozenHashTable+Bucket[]>
+;  V107 tmp98       [V107,T10] (  7, 382.52)     int  ->  rcx         "Inline stloc first use temp"
+;* V108 tmp99       [V108,T118] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V109 tmp100      [V109,T01] (  5,1054.13)     int  ->  registers   "Inline stloc first use temp"
+;  V110 tmp101      [V110,T31] (  4, 250.56)     int  ->  r12         "Inline stloc first use temp"
+;  V111 tmp102      [V111,T06] (  7, 445.59)     int  ->  r11         "Inline stloc first use temp"
+;  V112 tmp103      [V112,T37] (  3, 192.19)   byref  ->  [rsp+0x88]  spill-single-def "Inline stloc first use temp"
+;  V113 tmp104      [V113,T23] (  2, 256.25)     int  ->  rbp         "Strict ordering of exceptions for Array store"
 ;* V114 tmp105      [V114    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Frozen.FrozenHashTable+Bucket>
-;  V115 tmp106      [V115,T76] (  2,   3.97)     ref  ->  r12         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V115 tmp106      [V115,T78] (  2,   3.97)     ref  ->  rax         class-hnd exact single-def "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
 ;* V116 tmp107      [V116    ] (  0,   0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Frozen.FrozenHashTable>
-;  V117 tmp108      [V117,T100] (  2,   1.99)     ref  ->  rax         single-def "guarded devirt return temp"
+;  V117 tmp108      [V117,T100] (  2,   1.98)     ref  ->  rax         single-def "guarded devirt return temp"
 ;* V118 tmp109      [V118    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
-;  V119 tmp110      [V119,T108] (  6,   0.99)     ref  ->  [rsp+0x80]  class-hnd exact spill-single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
+;  V119 tmp110      [V119,T114] (  6,   0.99)     ref  ->  [rsp+0x80]  class-hnd exact spill-single-def "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
 ;* V120 tmp111      [V120    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
 ;* V121 tmp112      [V121    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[int]>
 ;* V122 tmp113      [V122    ] (  0,   0   )   byref  ->  zero-ref    single-def "Inlining Arg"
@@ -759,27 +759,27 @@ G_M58412_IG15:
 ;* V125 tmp116      [V125    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V126 tmp117      [V126    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
 ;* V127 tmp118      [V127    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V128 tmp119      [V128,T37] (  3, 191.55)     int  ->  rcx         "Inline stloc first use temp"
-;  V129 tmp120      [V129,T60] (  9,   4.96)     int  ->  [rsp+0x13C]  spill-single-def "Inline stloc first use temp"
-;  V130 tmp121      [V130,T77] (  2,   3.97)     ref  ->  r11         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V131 tmp122      [V131,T62] (  6,   4.96)     ref  ->  r11        
+;  V128 tmp119      [V128,T35] (  3, 193.09)     int  ->  rcx         "Inline stloc first use temp"
+;  V129 tmp120      [V129,T61] (  9,   4.97)     int  ->  [rsp+0x144]  spill-single-def "Inline stloc first use temp"
+;  V130 tmp121      [V130,T68] (  2,   3.98)     ref  ->  r10         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
+;  V131 tmp122      [V131,T59] (  6,   4.97)     ref  ->  r10        
 ;* V132 tmp123      [V132    ] (  0,   0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V133 tmp124      [V133,T90] (  4,   1.99)   ubyte  ->  [rsp+0x138]  "Inline stloc first use temp"
-;  V134 tmp125      [V134,T109] (  3,   0.99)   ubyte  ->  [rsp+0x134]  "Inline stloc first use temp"
-;  V135 tmp126      [V135,T87] (  4,   1.99)     ref  ->  [rsp+0x78]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
-;  V136 tmp127      [V136,T177] (  2,   0   )     int  ->  [rsp+0x130]  spill-single-def "impAppendStmt"
-;  V137 tmp128      [V137,T178] (  2,   0   )     int  ->  [rsp+0x12C]  spill-single-def "impAppendStmt"
-;  V138 tmp129      [V138,T179] (  2,   0   )     int  ->  [rsp+0x128]  spill-single-def "impAppendStmt"
-;  V139 tmp130      [V139,T180] (  2,   0   )     int  ->  [rsp+0x124]  spill-single-def "impAppendStmt"
+;  V133 tmp124      [V133,T87] (  4,   1.99)   ubyte  ->  [rsp+0x140]  "Inline stloc first use temp"
+;  V134 tmp125      [V134,T106] (  3,   0.99)   ubyte  ->  [rsp+0x13C]  "Inline stloc first use temp"
+;  V135 tmp126      [V135,T91] (  4,   1.98)     ref  ->  [rsp+0x78]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
+;  V136 tmp127      [V136,T180] (  2,   0   )     int  ->  [rsp+0x138]  spill-single-def "impAppendStmt"
+;  V137 tmp128      [V137,T181] (  2,   0   )     int  ->  [rsp+0x134]  spill-single-def "impAppendStmt"
+;  V138 tmp129      [V138,T182] (  2,   0   )     int  ->  [rsp+0x130]  spill-single-def "impAppendStmt"
+;  V139 tmp130      [V139,T183] (  2,   0   )     int  ->  [rsp+0x12C]  spill-single-def "impAppendStmt"
 ;* V140 tmp131      [V140    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V141 tmp132      [V141    ] (  0,   0   )     int  ->  zero-ref   
 ;* V142 tmp133      [V142    ] (  0,   0   )     int  ->  zero-ref   
-;  V143 tmp134      [V143,T181] (  2,   0   )     int  ->   r9        
+;  V143 tmp134      [V143,T184] (  2,   0   )     int  ->   r9        
 ;* V144 tmp135      [V144    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V145 tmp136      [V145    ] (  0,   0   )     int  ->  zero-ref   
 ;* V146 tmp137      [V146    ] (  0,   0   )     int  ->  zero-ref   
 ;* V147 tmp138      [V147    ] (  0,   0   )     int  ->  zero-ref   
-;  V148 tmp139      [V148,T152] (  3,   0   )     int  ->  rcx        
+;  V148 tmp139      [V148,T155] (  3,   0   )     int  ->  rcx        
 ;* V149 tmp140      [V149    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V150 tmp141      [V150    ] (  0,   0   )     int  ->  zero-ref   
 ;* V151 tmp142      [V151    ] (  0,   0   )     int  ->  zero-ref   
@@ -790,56 +790,56 @@ G_M58412_IG15:
 ;* V156 tmp147      [V156    ] (  0,   0   )     int  ->  zero-ref   
 ;* V157 tmp148      [V157    ] (  0,   0   )     int  ->  zero-ref   
 ;* V158 tmp149      [V158    ] (  0,   0   )     int  ->  zero-ref   
-;  V159 tmp150      [V159,T153] (  3,   0   )     int  ->  rdx        
+;  V159 tmp150      [V159,T156] (  3,   0   )     int  ->  rdx        
 ;* V160 tmp151      [V160    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V161 tmp152      [V161,T70] (  4,   3.97)   byref  ->  r12         single-def "Inline stloc first use temp"
-;  V162 tmp153      [V162,T94] (  3,   1.99)     ref  ->  [rsp+0x70]  class-hnd single-def "Inline stloc first use temp" <System.Array>
+;  V161 tmp152      [V161,T71] (  4,   3.97)   byref  ->  [rsp+0x70]  spill-single-def "Inline stloc first use temp"
+;  V162 tmp153      [V162,T89] (  3,   1.99)     ref  ->  [rsp+0x68]  class-hnd single-def "Inline stloc first use temp" <System.Array>
 ;* V163 tmp154      [V163    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Buffers.SharedArrayPoolThreadLocalArray>
-;  V164 tmp155      [V164,T164] (  2,   0   )     ref  ->  r11         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolPartitions>
-;  V165 tmp156      [V165,T131] (  4,   0   )     ref  ->  r11        
+;  V164 tmp155      [V164,T167] (  2,   0   )     ref  ->  rbx         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolPartitions>
+;  V165 tmp156      [V165,T134] (  4,   0   )     ref  ->  rbx        
 ;* V166 tmp157      [V166    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
-;  V167 tmp158      [V167,T143] (  3,   0   )     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V167 tmp158      [V167,T146] (  3,   0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V168 tmp159      [V168    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V169 tmp160      [V169    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V170 tmp161      [V170    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V171 tmp162      [V171    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V172 tmp163      [V172,T154] (  3,   0   )   ubyte  ->   r9         "Inline return value spill temp"
-;  V173 tmp164      [V173,T124] (  5,   0   )     ref  ->  rbx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V174 tmp165      [V174,T121] (  7,   0   )     int  ->  [rsp+0x120]  "Inline stloc first use temp"
-;  V175 tmp166      [V175,T135] (  4,   0   )     int  ->  [rsp+0x11C]  "Inline stloc first use temp"
-;  V176 tmp167      [V176,T182] (  2,   0   )     int  ->  rax         "dup spill"
-;  V177 tmp168      [V177,T155] (  3,   0   )     int  ->  [rsp+0x118]  "Inline return value spill temp"
-;  V178 tmp169      [V178,T156] (  3,   0   )     int  ->  rdx         "Inline return value spill temp"
-;  V179 tmp170      [V179,T136] (  4,   0   )     int  ->  [rsp+0x114]  spill-single-def "dup spill"
+;  V172 tmp163      [V172,T157] (  3,   0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V173 tmp164      [V173,T127] (  5,   0   )     ref  ->  rbx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V174 tmp165      [V174,T124] (  7,   0   )     int  ->  rbp         "Inline stloc first use temp"
+;  V175 tmp166      [V175,T138] (  4,   0   )     int  ->  [rsp+0x128]  "Inline stloc first use temp"
+;  V176 tmp167      [V176,T185] (  2,   0   )     int  ->  rbp         "dup spill"
+;  V177 tmp168      [V177,T158] (  3,   0   )     int  ->  rbp         "Inline return value spill temp"
+;  V178 tmp169      [V178,T159] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V179 tmp170      [V179,T139] (  4,   0   )     int  ->  rbp         "dup spill"
 ;* V180 tmp171      [V180    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V181 tmp172      [V181    ] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V182 tmp173      [V182,T157] (  3,   0   )   ubyte  ->  [rsp+0x110]  "Inline stloc first use temp"
-;  V183 tmp174      [V183,T117] (  8,   0   )     ref  ->  [rsp+0x68]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
-;  V184 tmp175      [V184,T144] (  3,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V185 tmp176      [V185,T127] (  5,   0   )     int  ->  [rsp+0x10C]  spill-single-def "Inline stloc first use temp"
-;  V186 tmp177      [V186,T183] (  2,   0   )     int  ->  rax         "Inlining Arg"
+;  V182 tmp173      [V182,T160] (  3,   0   )   ubyte  ->  [rsp+0x124]  "Inline stloc first use temp"
+;  V183 tmp174      [V183,T120] (  8,   0   )     ref  ->  [rsp+0x60]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
+;  V184 tmp175      [V184,T147] (  3,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V185 tmp176      [V185,T130] (  5,   0   )     int  ->  [rsp+0x120]  spill-single-def "Inline stloc first use temp"
+;  V186 tmp177      [V186,T186] (  2,   0   )     int  ->  rax         "Inlining Arg"
 ;* V187 tmp178      [V187    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V188 tmp179      [V188    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V189 tmp180      [V189,T61] (  9,   4.96)     int  ->  rbp         "Inline stloc first use temp"
-;  V190 tmp181      [V190,T78] (  2,   3.97)     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V191 tmp182      [V191,T63] (  6,   4.96)     ref  ->  rax        
+;  V189 tmp180      [V189,T62] (  9,   4.97)     int  ->  rbp         "Inline stloc first use temp"
+;  V190 tmp181      [V190,T69] (  2,   3.98)     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
+;  V191 tmp182      [V191,T60] (  6,   4.97)     ref  ->  rax        
 ;* V192 tmp183      [V192    ] (  0,   0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V193 tmp184      [V193,T91] (  4,   1.99)   ubyte  ->  rsi         "Inline stloc first use temp"
-;  V194 tmp185      [V194,T110] (  3,   0.99)   ubyte  ->  r15         "Inline stloc first use temp"
-;  V195 tmp186      [V195,T88] (  4,   1.99)     ref  ->  rbx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
-;  V196 tmp187      [V196,T184] (  2,   0   )     int  ->  r14         "impAppendStmt"
-;  V197 tmp188      [V197,T185] (  2,   0   )     int  ->  r13         "impAppendStmt"
-;  V198 tmp189      [V198,T186] (  2,   0   )     int  ->  r14         "impAppendStmt"
-;  V199 tmp190      [V199,T187] (  2,   0   )     int  ->  r15         "impAppendStmt"
+;  V193 tmp184      [V193,T88] (  4,   1.99)   ubyte  ->  rsi         "Inline stloc first use temp"
+;  V194 tmp185      [V194,T107] (  3,   0.99)   ubyte  ->  r15         "Inline stloc first use temp"
+;  V195 tmp186      [V195,T92] (  4,   1.98)     ref  ->  rbx         class-hnd exact single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
+;  V196 tmp187      [V196,T187] (  2,   0   )     int  ->  r14         "impAppendStmt"
+;  V197 tmp188      [V197,T188] (  2,   0   )     int  ->  r13         "impAppendStmt"
+;  V198 tmp189      [V198,T189] (  2,   0   )     int  ->  r14         "impAppendStmt"
+;  V199 tmp190      [V199,T190] (  2,   0   )     int  ->  r15         "impAppendStmt"
 ;* V200 tmp191      [V200    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V201 tmp192      [V201    ] (  0,   0   )     int  ->  zero-ref   
 ;* V202 tmp193      [V202    ] (  0,   0   )     int  ->  zero-ref   
-;  V203 tmp194      [V203,T188] (  2,   0   )     int  ->   r9        
+;  V203 tmp194      [V203,T191] (  2,   0   )     int  ->   r9        
 ;* V204 tmp195      [V204    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V205 tmp196      [V205    ] (  0,   0   )     int  ->  zero-ref   
 ;* V206 tmp197      [V206    ] (  0,   0   )     int  ->  zero-ref   
 ;* V207 tmp198      [V207    ] (  0,   0   )     int  ->  zero-ref   
-;  V208 tmp199      [V208,T158] (  3,   0   )     int  ->  rcx        
+;  V208 tmp199      [V208,T161] (  3,   0   )     int  ->  rcx        
 ;* V209 tmp200      [V209    ] (  0,   0   )     ref  ->  zero-ref    single-def
 ;* V210 tmp201      [V210    ] (  0,   0   )     int  ->  zero-ref   
 ;* V211 tmp202      [V211    ] (  0,   0   )     int  ->  zero-ref   
@@ -850,92 +850,95 @@ G_M58412_IG15:
 ;* V216 tmp207      [V216    ] (  0,   0   )     int  ->  zero-ref   
 ;* V217 tmp208      [V217    ] (  0,   0   )     int  ->  zero-ref   
 ;* V218 tmp209      [V218    ] (  0,   0   )     int  ->  zero-ref   
-;  V219 tmp210      [V219,T159] (  3,   0   )     int  ->  rdx        
+;  V219 tmp210      [V219,T162] (  3,   0   )     int  ->  rdx        
 ;* V220 tmp211      [V220    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V221 tmp212      [V221,T71] (  4,   3.97)   byref  ->  rbx         single-def "Inline stloc first use temp"
-;  V222 tmp213      [V222,T95] (  3,   1.99)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Array>
+;  V221 tmp212      [V221,T72] (  4,   3.97)   byref  ->  rbx         single-def "Inline stloc first use temp"
+;  V222 tmp213      [V222,T90] (  3,   1.99)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Array>
 ;* V223 tmp214      [V223    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Buffers.SharedArrayPoolThreadLocalArray>
-;  V224 tmp215      [V224,T165] (  2,   0   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolPartitions>
-;  V225 tmp216      [V225,T132] (  4,   0   )     ref  ->  rax        
+;  V224 tmp215      [V224,T168] (  2,   0   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Buffers.SharedArrayPoolPartitions>
+;  V225 tmp216      [V225,T135] (  4,   0   )     ref  ->  rax        
 ;* V226 tmp217      [V226    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Buffers.SharedArrayPoolPartitions>
-;  V227 tmp218      [V227,T145] (  3,   0   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V227 tmp218      [V227,T148] (  3,   0   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V228 tmp219      [V228    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V229 tmp220      [V229    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V230 tmp221      [V230    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V231 tmp222      [V231    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V232 tmp223      [V232,T160] (  3,   0   )   ubyte  ->  r15         "Inline return value spill temp"
-;  V233 tmp224      [V233,T125] (  5,   0   )     ref  ->  rbx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
-;  V234 tmp225      [V234,T122] (  7,   0   )     int  ->  r14         "Inline stloc first use temp"
-;  V235 tmp226      [V235,T137] (  4,   0   )     int  ->  r15         "Inline stloc first use temp"
-;  V236 tmp227      [V236,T189] (  2,   0   )     int  ->  r14         "dup spill"
-;  V237 tmp228      [V237,T161] (  3,   0   )     int  ->  r14         "Inline return value spill temp"
-;  V238 tmp229      [V238,T162] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
-;  V239 tmp230      [V239,T138] (  4,   0   )     int  ->  r14         "dup spill"
+;  V232 tmp223      [V232,T163] (  3,   0   )   ubyte  ->  r15         "Inline return value spill temp"
+;  V233 tmp224      [V233,T128] (  5,   0   )     ref  ->  rbx         class-hnd exact single-def "Inline stloc first use temp" <<unknown class>>
+;  V234 tmp225      [V234,T125] (  7,   0   )     int  ->  r14         "Inline stloc first use temp"
+;  V235 tmp226      [V235,T140] (  4,   0   )     int  ->  r15         "Inline stloc first use temp"
+;  V236 tmp227      [V236,T192] (  2,   0   )     int  ->  r14         "dup spill"
+;  V237 tmp228      [V237,T164] (  3,   0   )     int  ->  r14         "Inline return value spill temp"
+;  V238 tmp229      [V238,T165] (  3,   0   )     int  ->  rax         "Inline return value spill temp"
+;  V239 tmp230      [V239,T141] (  4,   0   )     int  ->  r14         "dup spill"
 ;* V240 tmp231      [V240    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V241 tmp232      [V241    ] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V242 tmp233      [V242,T163] (  3,   0   )   ubyte  ->  [rsp+0x108]  "Inline stloc first use temp"
-;  V243 tmp234      [V243,T118] (  8,   0   )     ref  ->  [rsp+0x60]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
-;  V244 tmp235      [V244,T146] (  3,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V245 tmp236      [V245,T128] (  5,   0   )     int  ->  [rsp+0x104]  spill-single-def "Inline stloc first use temp"
-;  V246 tmp237      [V246,T190] (  2,   0   )     int  ->  rax         "Inlining Arg"
-;  V247 tmp238      [V247,T18] (  7, 256.34)   byref  ->  rsi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;  V248 tmp239      [V248,T08] ( 15, 387.69)     int  ->  r13         "field V05._length (fldOffset=0x8)" P-INDEP
-;  V249 tmp240      [V249,T44] (  4, 125.30)   short  ->  r11         "field V35.key (fldOffset=0x0)" P-INDEP
-;  V250 tmp241      [V250,T45] (  4, 125.30)   short  ->  r10         "field V35.value (fldOffset=0x2)" P-INDEP
-;  V251 tmp242      [V251,T96] (  3,   1.99)   byref  ->  rsi         "field V89._reference (fldOffset=0x0)" P-INDEP
-;  V252 tmp243      [V252,T98] (  3,   1.99)     int  ->  r13         "field V89._length (fldOffset=0x8)" P-INDEP
+;  V242 tmp233      [V242,T166] (  3,   0   )   ubyte  ->  [rsp+0x11C]  "Inline stloc first use temp"
+;  V243 tmp234      [V243,T121] (  8,   0   )     ref  ->  [rsp+0x58]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
+;  V244 tmp235      [V244,T149] (  3,   0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V245 tmp236      [V245,T131] (  5,   0   )     int  ->  [rsp+0x118]  spill-single-def "Inline stloc first use temp"
+;  V246 tmp237      [V246,T193] (  2,   0   )     int  ->  rax         "Inlining Arg"
+;  V247 tmp238      [V247,T21] (  7, 259.03)   byref  ->  rsi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V248 tmp239      [V248,T08] ( 15, 391.85)     int  ->  r13         "field V05._length (fldOffset=0x8)" P-INDEP
+;  V249 tmp240      [V249,T44] (  4, 125.91)   short  ->  r11         "field V35.key (fldOffset=0x0)" P-INDEP
+;  V250 tmp241      [V250,T45] (  4, 125.91)   short  ->  r10         "field V35.value (fldOffset=0x2)" P-INDEP
+;  V251 tmp242      [V251,T96] (  3,   1.98)   byref  ->  rsi         "field V89._reference (fldOffset=0x0)" P-INDEP
+;  V252 tmp243      [V252,T98] (  3,   1.98)     int  ->  r13         "field V89._length (fldOffset=0x8)" P-INDEP
 ;* V253 tmp244      [V253    ] (  0,   0   )     ref  ->  zero-ref    "field V92._buckets (fldOffset=0x0)" P-INDEP
 ;* V254 tmp245      [V254    ] (  0,   0   )     ref  ->  zero-ref    "field V92.<HashCodes>k__BackingField (fldOffset=0x8)" P-INDEP
 ;* V255 tmp246      [V255    ] (  0,   0   )    long  ->  zero-ref    "field V92._fastModMultiplier (fldOffset=0x10)" P-INDEP
 ;* V256 tmp247      [V256,T101] (  0,   0   )   byref  ->  zero-ref    single-def "field V93._reference (fldOffset=0x0)" P-INDEP
-;  V257 tmp248      [V257,T64] (  5,   3.97)     int  ->  [rsp+0x100]  spill-single-def "field V93._length (fldOffset=0x8)" P-INDEP
+;  V257 tmp248      [V257,T64] (  5,   3.97)     int  ->  [rsp+0x114]  spill-single-def "field V93._length (fldOffset=0x8)" P-INDEP
 ;* V258 tmp249      [V258    ] (  0,   0   )   byref  ->  zero-ref    "field V94._reference (fldOffset=0x0)" P-INDEP
 ;* V259 tmp250      [V259    ] (  0,   0   )     int  ->  zero-ref    "field V94._length (fldOffset=0x8)" P-INDEP
-;  V260 tmp251      [V260,T05] (  5, 499.57)   byref  ->  [rsp+0x58]  single-def "field V99._reference (fldOffset=0x0)" P-INDEP
-;  V261 tmp252      [V261,T04] (  6, 500.56)     int  ->  [rsp+0xFC]  "field V99._length (fldOffset=0x8)" P-INDEP
-;  V262 tmp253      [V262,T41] (  3, 129.33)   byref  ->  [rsp+0x50]  spill-single-def "field V100._reference (fldOffset=0x0)" P-INDEP
-;  V263 tmp254      [V263,T42] (  3, 129.33)     int  ->  [rsp+0xF8]  spill-single-def "field V100._length (fldOffset=0x8)" P-INDEP
-;  V264 tmp255      [V264,T38] (  3, 182.40)     int  ->  rdx         "field V114.StartIndex (fldOffset=0x0)" P-INDEP
-;  V265 tmp256      [V265,T46] (  2, 121.60)     int  ->  r10         "field V114.EndIndex (fldOffset=0x4)" P-INDEP
-;  V266 tmp257      [V266,T102] (  2,   1.99)     ref  ->  rdx         single-def "field V116._buckets (fldOffset=0x0)" P-INDEP
-;  V267 tmp258      [V267,T103] (  2,   1.99)     ref  ->  rbp         single-def "field V116.<HashCodes>k__BackingField (fldOffset=0x8)" P-INDEP
-;  V268 tmp259      [V268,T104] (  2,   1.99)    long  ->  r12         "field V116._fastModMultiplier (fldOffset=0x10)" P-INDEP
+;  V260 tmp251      [V260,T05] (  5, 501.59)   byref  ->  [rsp+0x50]  single-def "field V99._reference (fldOffset=0x0)" P-INDEP
+;  V261 tmp252      [V261,T04] (  6, 502.58)     int  ->  [rsp+0x110]  "field V99._length (fldOffset=0x8)" P-INDEP
+;  V262 tmp253      [V262,T42] (  3, 129.42)   byref  ->  [rsp+0x48]  spill-single-def "field V100._reference (fldOffset=0x0)" P-INDEP
+;  V263 tmp254      [V263,T43] (  3, 129.42)     int  ->  [rsp+0x10C]  spill-single-def "field V100._length (fldOffset=0x8)" P-INDEP
+;  V264 tmp255      [V264,T38] (  3, 183.65)     int  ->  rdx         "field V114.StartIndex (fldOffset=0x0)" P-INDEP
+;  V265 tmp256      [V265,T46] (  2, 122.44)     int  ->  r11         "field V114.EndIndex (fldOffset=0x4)" P-INDEP
+;  V266 tmp257      [V266,T102] (  2,   1.98)     ref  ->  rdx         single-def "field V116._buckets (fldOffset=0x0)" P-INDEP
+;  V267 tmp258      [V267,T103] (  2,   1.98)     ref  ->  rbp         single-def "field V116.<HashCodes>k__BackingField (fldOffset=0x8)" P-INDEP
+;  V268 tmp259      [V268,T104] (  2,   1.98)    long  ->  [rsp+0x100]  spill-single-def "field V116._fastModMultiplier (fldOffset=0x10)" P-INDEP
 ;* V269 tmp260      [V269    ] (  0,   0   )   byref  ->  zero-ref    single-def "field V120._reference (fldOffset=0x0)" P-INDEP
 ;* V270 tmp261      [V270    ] (  0,   0   )     int  ->  zero-ref    "field V120._length (fldOffset=0x8)" P-INDEP
-;* V271 tmp262      [V271,T111] (  0,   0   )   byref  ->  zero-ref    single-def "field V121._reference (fldOffset=0x0)" P-INDEP
-;* V272 tmp263      [V272,T114] (  0,   0   )     int  ->  zero-ref    "field V121._length (fldOffset=0x8)" P-INDEP
-;  V273 tmp264      [V273,T89] (  4,   1.99)   byref  ->  registers   "field V124._reference (fldOffset=0x0)" P-INDEP
-;  V274 tmp265      [V274,T92] (  4,   1.99)     int  ->  registers   "field V124._length (fldOffset=0x8)" P-INDEP
-;  V275 tmp266      [V275,T97] (  3,   1.99)   byref  ->  rdi         "field V126._reference (fldOffset=0x0)" P-INDEP
-;  V276 tmp267      [V276,T99] (  3,   1.99)     int  ->  r10         "field V126._length (fldOffset=0x8)" P-INDEP
-;* V277 tmp268      [V277,T112] (  0,   0   )     ref  ->  zero-ref    single-def "field V163.Array (fldOffset=0x0)" P-INDEP
-;* V278 tmp269      [V278,T115] (  0,   0   )     int  ->  zero-ref    "field V163.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
-;* V279 tmp270      [V279,T113] (  0,   0   )     ref  ->  zero-ref    single-def "field V223.Array (fldOffset=0x0)" P-INDEP
-;* V280 tmp271      [V280,T116] (  0,   0   )     int  ->  zero-ref    "field V223.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
-;  V281 tmp272      [V281,T11] (  6, 375.91)   byref  ->  rdx         "BlockOp address local"
-;  V282 tmp273      [V282,T191] (  2,   0   )     int  ->   r9         "argument with side effect"
-;  V283 tmp274      [V283,T192] (  2,   0   )     int  ->   r9         "argument with side effect"
+;* V271 tmp262      [V271,T115] (  0,   0   )   byref  ->  zero-ref    single-def "field V121._reference (fldOffset=0x0)" P-INDEP
+;* V272 tmp263      [V272,T119] (  0,   0   )     int  ->  zero-ref    "field V121._length (fldOffset=0x8)" P-INDEP
+;  V273 tmp264      [V273,T93] (  4,   1.98)   byref  ->  registers   "field V124._reference (fldOffset=0x0)" P-INDEP
+;  V274 tmp265      [V274,T94] (  4,   1.98)     int  ->  registers   "field V124._length (fldOffset=0x8)" P-INDEP
+;  V275 tmp266      [V275,T97] (  3,   1.98)   byref  ->  rdi         "field V126._reference (fldOffset=0x0)" P-INDEP
+;  V276 tmp267      [V276,T99] (  3,   1.98)     int  ->  r10         "field V126._length (fldOffset=0x8)" P-INDEP
+;* V277 tmp268      [V277,T108] (  0,   0   )     ref  ->  zero-ref    single-def "field V163.Array (fldOffset=0x0)" P-INDEP
+;* V278 tmp269      [V278,T110] (  0,   0   )     int  ->  zero-ref    "field V163.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
+;* V279 tmp270      [V279,T109] (  0,   0   )     ref  ->  zero-ref    single-def "field V223.Array (fldOffset=0x0)" P-INDEP
+;* V280 tmp271      [V280,T111] (  0,   0   )     int  ->  zero-ref    "field V223.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
+;  V281 tmp272      [V281,T13] (  6, 377.72)   byref  ->  rdx         "BlockOp address local"
+;  V282 tmp273      [V282,T194] (  2,   0   )     int  ->   r9         "argument with side effect"
+;  V283 tmp274      [V283,T195] (  2,   0   )     int  ->   r9         "argument with side effect"
 ;  V284 tmp275      [V284,T82] (  2,   3.97)     int  ->   r9         "argument with side effect"
-;  V285 tmp276      [V285    ] (  3,   5.96)  struct (16) [rsp+0xE8]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[int]>
-;  V286 tmp277      [V286,T14] (  3, 364.79)   byref  ->  r11         "BlockOp address local"
-;  V287 tmp278      [V287,T147] (  3,   0   )     ref  ->  r11         single-def "arr expr"
-;  V288 tmp279      [V288,T166] (  2,   0   )     ref  ->  rbx         single-def "argument with side effect"
-;  V289 tmp280      [V289,T167] (  2,   0   )     ref  ->   r8         single-def "argument with side effect"
-;  V290 tmp281      [V290,T148] (  3,   0   )     ref  ->  rcx         single-def "arr expr"
-;  V291 tmp282      [V291,T168] (  2,   0   )     ref  ->  rbp         single-def "argument with side effect"
-;  V292 tmp283      [V292,T169] (  2,   0   )     ref  ->   r8         single-def "argument with side effect"
-;  V293 cse0        [V293,T72] (  4,   3.97)   byref  ->  [rsp+0x48]  spill-single-def "CSE #32: conservative"
-;  V294 cse1        [V294,T86] (  4,   2.51)   byref  ->  r10         "CSE #10: conservative"
-;  V295 cse2        [V295,T83] (  3,   3.41)     int  ->  rbp         "CSE #03: conservative"
-;  V296 cse3        [V296,T31] (  4, 248.22)    long  ->  r10         "CSE #05: moderate"
-;  V297 cse4        [V297,T66] (  5,   4.96)     ref  ->  [rsp+0x40]  spill-single-def "CSE #24: conservative"
-;  V298 cse5        [V298,T73] (  4,   3.97)     ref  ->  [rsp+0x38]  spill-single-def "CSE #40: conservative"
-;  V299 cse6        [V299,T49] (  3,  65.84)    long  ->  [rsp+0xE0]  spill-single-def "CSE #27: conservative"
+;  V285 tmp276      [V285    ] (  3,   5.95)  struct (16) [rsp+0xF0]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[int]>
+;  V286 tmp277      [V286,T14] (  3, 367.31)   byref  ->  r12         "BlockOp address local"
+;  V287 tmp278      [V287,T150] (  3,   0   )     ref  ->  rbx         single-def "arr expr"
+;  V288 tmp279      [V288,T169] (  2,   0   )     ref  ->  rsi         single-def "argument with side effect"
+;  V289 tmp280      [V289,T170] (  2,   0   )     ref  ->   r8         single-def "argument with side effect"
+;  V290 tmp281      [V290,T151] (  3,   0   )     ref  ->  rcx         single-def "arr expr"
+;  V291 tmp282      [V291,T171] (  2,   0   )     ref  ->  rbp         single-def "argument with side effect"
+;  V292 tmp283      [V292,T172] (  2,   0   )     ref  ->   r8         single-def "argument with side effect"
+;  V293 cse0        [V293,T70] (  4,   3.97)   byref  ->  [rsp+0x40]  spill-single-def "CSE #32: conservative"
+;  V294 cse1        [V294,T86] (  4,   2.52)   byref  ->  r10         "CSE #10: conservative"
+;  V295 cse2        [V295,T83] (  3,   3.33)     int  ->  rbp         "CSE #03: conservative"
+;  V296 cse3        [V296,T32] (  4, 249.42)    long  ->  r10         "CSE #05: moderate"
+;  V297 cse4        [V297,T66] (  5,   4.96)     ref  ->  [rsp+0x38]  spill-single-def "CSE #24: conservative"
+;  V298 cse5        [V298,T75] (  4,   3.97)     ref  ->  [rsp+0x30]  spill-single-def "CSE #40: conservative"
+;  V299 cse6        [V299,T49] (  3,  66.35)    long  ->  [rsp+0xE8]  spill-single-def "CSE #27: conservative"
 ;  V300 cse7        [V300,T85] (  3,   2.98)    long  ->  rdx         "CSE #15: conservative"
-;  V301 cse8        [V301,T07] (  3, 435.72)     int  ->   r8         "CSE #31: aggressive"
-;  V302 cse9        [V302,T39] ( 14, 137.11)     int  ->  [rsp+0xDC]  multi-def "CSE #06: moderate"
-;  V303 cse10       [V303,T105] (  2,   1.99)     int  ->  rdx         "CSE #13: conservative"
-;  V304 cse11       [V304,T32] (  4, 247.72)    long  ->  rdx         "CSE #41: moderate"
+;  V301 cse8        [V301,T07] (  3, 437.22)     int  ->   r8         "CSE #31: aggressive"
+;  V302 cse9        [V302,T39] ( 14, 138.92)     int  ->  [rsp+0xE4]  multi-def "CSE #06: moderate"
+;  V303 cse10       [V303,T105] (  2,   1.98)     int  ->  rdx         "CSE #13: conservative"
+;  V304 cse11       [V304,T30] (  4, 251.51)    long  ->  rdx         "CSE #41: moderate"
+;  V305 rat0        [V305,T09] (  7, 391.60)    long  ->  [rsp+0xD8]  "Widened IV V06"
+;  V306 rat1        [V306,T02] (  9, 515.90)    long  ->  rdx         "Widened IV V101"
+;  V307 rat2        [V307,T00] (  7,2238.41)    long  ->  rax         "Widened IV V108"
 ;
 ; Lcl frame size = 360
 
@@ -950,7 +953,7 @@ G_M58412_IG01:
        push     rbx
        sub      rsp, 360
        xor      eax, eax
-       mov      qword ptr [rsp+0xE8], rax
+       mov      qword ptr [rsp+0xF0], rax
        mov      rbx, rcx
        mov      rsi, rdx
        mov      edi, r8d
@@ -970,49 +973,49 @@ G_M58412_IG02:
        mov      r14, rax
        mov      rdx, 0xD1FFAB1E      ; System.Collections.Generic.Dictionary`2[short,short]
        cmp      qword ptr [rsi], rdx
-       jne      G_M58412_IG49
+       jne      G_M58412_IG53
 						;; size=76 bbWeight=1 PerfScore 18.00
 G_M58412_IG03:
        xor      edx, edx
        mov      r15d, dword ptr [r14+0x08]
        cmp      r15d, ebp
-       jl       G_M58412_IG48
+       jl       G_M58412_IG52
        mov      ecx, dword ptr [rsi+0x38]
        mov      rax, gword ptr [rsi+0x10]
        xor      r8d, r8d
        test     ecx, ecx
        jle      G_M58412_IG13
-						;; size=33 bbWeight=1.41 PerfScore 12.69
+						;; size=33 bbWeight=1.33 PerfScore 12.01
 G_M58412_IG04:
        test     rax, rax
        je       SHORT G_M58412_IG09
        cmp      dword ptr [rax+0x08], ecx
        jl       SHORT G_M58412_IG09
        align    [0 bytes for IG05]
-						;; size=10 bbWeight=1.39 PerfScore 7.29
+						;; size=10 bbWeight=1.31 PerfScore 6.90
 G_M58412_IG05:
        mov      r10d, r8d
        lea      r10, [r10+2*r10]
        cmp      dword ptr [rax+4*r10+0x14], -1
        jl       SHORT G_M58412_IG07
-						;; size=15 bbWeight=62.09 PerfScore 294.91
+						;; size=15 bbWeight=62.39 PerfScore 296.33
 G_M58412_IG06:
        lea      r9d, [rdx+0x01]
        movsx    r11, word  ptr [rax+4*r10+0x18]
        movsx    r10, word  ptr [rax+4*r10+0x1A]
        cmp      edx, r15d
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      edx, edx
        lea      rdx, bword ptr [r14+4*rdx+0x10]
        mov      word  ptr [rdx], r11w
        mov      word  ptr [rdx+0x02], r10w
        mov      edx, r9d
-						;; size=44 bbWeight=62.02 PerfScore 821.83
+						;; size=44 bbWeight=62.32 PerfScore 825.79
 G_M58412_IG07:
        inc      r8d
        cmp      r8d, ecx
        jl       SHORT G_M58412_IG05
-						;; size=8 bbWeight=62.09 PerfScore 93.13
+						;; size=8 bbWeight=62.39 PerfScore 93.58
 G_M58412_IG08:
        jmp      SHORT G_M58412_IG13
        align    [0 bytes for IG23]
@@ -1022,30 +1025,30 @@ G_M58412_IG09:
 						;; size=4 bbWeight=0.01 PerfScore 0.03
 G_M58412_IG10:
        cmp      r8d, dword ptr [rax+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      r10d, r8d
        lea      r10, [r10+2*r10]
        lea      r10, bword ptr [rax+4*r10+0x10]
        cmp      dword ptr [r10+0x04], -1
        jl       SHORT G_M58412_IG12
-						;; size=29 bbWeight=0.63 PerfScore 6.11
+						;; size=29 bbWeight=0.63 PerfScore 6.14
 G_M58412_IG11:
        lea      r9d, [rdx+0x01]
        movsx    r11, word  ptr [r10+0x08]
        movsx    r10, word  ptr [r10+0x0A]
        cmp      edx, r15d
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      edx, edx
        lea      rdx, bword ptr [r14+4*rdx+0x10]
        mov      word  ptr [rdx], r11w
        mov      word  ptr [rdx+0x02], r10w
        mov      edx, r9d
-						;; size=42 bbWeight=0.63 PerfScore 8.30
+						;; size=42 bbWeight=0.63 PerfScore 8.34
 G_M58412_IG12:
        inc      r8d
        cmp      r8d, ecx
        jl       SHORT G_M58412_IG10
-						;; size=8 bbWeight=0.63 PerfScore 0.94
+						;; size=8 bbWeight=0.63 PerfScore 0.95
 G_M58412_IG13:
        mov      r15d, dword ptr [r14+0x08]
        mov      edx, r15d
@@ -1062,13 +1065,13 @@ G_M58412_IG13:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rbp, gword ptr [rcx]
-       mov      gword ptr [rsp+0x40], rbp
+       mov      gword ptr [rsp+0x38], rbp
        mov      rsi, rbp
        mov      r13d, r15d
        mov      r12, rsi
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rax, gword ptr [rcx]
-       mov      gword ptr [rsp+0x38], rax
+       mov      gword ptr [rsp+0x30], rax
        mov      gword ptr [rsp+0xC0], rax
        lea      ecx, [r13-0x01]
        or       ecx, 15
@@ -1076,23 +1079,23 @@ G_M58412_IG13:
        lzcnt    r10d, ecx
        xor      r10d, 31
        add      r10d, -3
-       mov      dword ptr [rsp+0x160], r10d
+       mov      dword ptr [rsp+0x164], r10d
        mov      rcx, 0xD1FFAB1E
        mov      edx, 33
        call     CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
-       mov      bword ptr [rsp+0x48], rax
+       mov      bword ptr [rsp+0x40], rax
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       G_M58412_IG42
+       je       G_M58412_IG46
        mov      edx, dword ptr [rcx+0x08]
-       mov      r8d, dword ptr [rsp+0x160]
+       mov      r8d, dword ptr [rsp+0x164]
        cmp      edx, r8d
-       jbe      G_M58412_IG50
+       jbe      G_M58412_IG54
        mov      edx, r8d
        shl      rdx, 4
        mov      r10, gword ptr [rcx+rdx+0x10]
        test     r10, r10
-       je       G_M58412_IG41
+       je       G_M58412_IG45
        xor      r9, r9
        mov      gword ptr [rcx+rdx+0x10], r9
        mov      r13, gword ptr [rsp+0xC0]
@@ -1102,22 +1105,22 @@ G_M58412_IG13:
        mov      rcx, r10
        call     <unknown method>
        mov      r12d, eax
-						;; size=271 bbWeight=0.99 PerfScore 43.69
+						;; size=271 bbWeight=0.99 PerfScore 43.65
 G_M58412_IG14:
        mov      rax, gword ptr [rsp+0xB8]
        mov      edx, dword ptr [rax+0x08]
-       mov      dword ptr [rsp+0x150], edx
+       mov      dword ptr [rsp+0x154], edx
        mov      rcx, rsi
        call     <unknown method>
        mov      r9d, eax
-       mov      esi, dword ptr [rsp+0x160]
+       mov      esi, dword ptr [rsp+0x164]
        mov      dword ptr [rsp+0x20], esi
        mov      edx, r12d
-       mov      r8d, dword ptr [rsp+0x150]
+       mov      r8d, dword ptr [rsp+0x154]
        mov      rcx, r13
        call     [<unknown method>]
        mov      r10, gword ptr [rsp+0xB8]
-						;; size=68 bbWeight=0.99 PerfScore 12.91
+						;; size=68 bbWeight=0.99 PerfScore 12.90
 G_M58412_IG15:
        mov      r12, r10
 						;; size=3 bbWeight=0.99 PerfScore 0.25
@@ -1125,41 +1128,41 @@ G_M58412_IG16:
        mov      gword ptr [rsp+0xD0], r12
        mov      r13d, r15d
        test     r12, r12
-       je       G_M58412_IG67
+       je       G_M58412_IG71
        cmp      dword ptr [r12+0x08], r13d
-       jb       G_M58412_IG72
+       jb       G_M58412_IG76
        lea      rsi, bword ptr [r12+0x10]
-						;; size=36 bbWeight=0.99 PerfScore 6.95
+						;; size=36 bbWeight=0.99 PerfScore 6.94
 G_M58412_IG17:
        xor      ecx, ecx
        test     r15d, r15d
-       jle      G_M58412_IG40
+       jle      G_M58412_IG44
 						;; size=11 bbWeight=0.99 PerfScore 1.49
 G_M58412_IG18:
        cmp      ecx, r13d
-       jae      G_M58412_IG47
-       mov      edx, ecx
-       lea      r8, bword ptr [rsi+4*rdx]
+       jae      G_M58412_IG51
+       lea      r8, bword ptr [rsi+4*rcx]
        mov      bword ptr [rsp+0xC8], r8
        mov      r9, gword ptr [rbx+0x08]
-       mov      edx, ecx
-       movsx    rdx, word  ptr [r14+4*rdx+0x10]
+       movsx    rdx, word  ptr [r14+4*rcx+0x10]
        mov      r10, 0xD1FFAB1E      ; System.Collections.Generic.GenericEqualityComparer`1[short]
        cmp      qword ptr [r9], r10
-       jne      G_M58412_IG68
-						;; size=54 bbWeight=63.45 PerfScore 856.61
+       jne      G_M58412_IG72
+						;; size=50 bbWeight=65.10 PerfScore 846.31
 G_M58412_IG19:
        mov      dword ptr [r8], edx
        inc      ecx
-       mov      dword ptr [rsp+0xDC], r15d
-       cmp      r15d, ecx
-       jg       G_M58412_IG39
-						;; size=22 bbWeight=63.45 PerfScore 222.08
+       mov      r10, rcx
+       mov      dword ptr [rsp+0xE4], r15d
+       cmp      r15d, r10d
+       mov      rcx, r10
+       jg       G_M58412_IG43
+						;; size=28 bbWeight=65.10 PerfScore 260.40
 G_M58412_IG20:
-       mov      dword ptr [rsp+0x100], r13d
-       mov      bword ptr [rsp+0xE8], rsi
-       mov      dword ptr [rsp+0xF0], r13d
-       lea      rcx, [rsp+0xE8]
+       mov      dword ptr [rsp+0x114], r13d
+       mov      bword ptr [rsp+0xF0], rsi
+       mov      dword ptr [rsp+0xF8], r13d
+       lea      rcx, [rsp+0xF0]
        movzx    rdx, dil
        call     [<unknown method>]
        mov      edi, eax
@@ -1168,84 +1171,81 @@ G_M58412_IG20:
        xor      edx, edx
        div      rdx:rax, rcx
        inc      rax
-       mov      qword ptr [rsp+0x140], rax
+       mov      qword ptr [rsp+0x148], rax
        mov      rcx, rbp
-       mov      r8d, dword ptr [rsp+0x100]
+       mov      r8d, dword ptr [rsp+0x114]
        lea      edx, [rdi+r8]
        call     [System.Buffers.SharedArrayPool`1[int]:Rent(int):int[]:this]
        mov      gword ptr [rsp+0xA0], rax
        test     rax, rax
-       je       G_M58412_IG69
+       je       G_M58412_IG73
        cmp      dword ptr [rax+0x08], edi
-       jb       G_M58412_IG72
+       jb       G_M58412_IG76
        cmp      byte  ptr [rax], al
        lea      r10, bword ptr [rax+0x10]
        mov      r9d, edi
        mov      r11, r10
        mov      r8d, r9d
        test     rax, rax
-       je       G_M58412_IG71
-						;; size=143 bbWeight=0.99 PerfScore 85.89
+       je       G_M58412_IG75
+						;; size=143 bbWeight=0.99 PerfScore 85.82
 G_M58412_IG21:
        mov      edx, edi
-       mov      r10d, dword ptr [rsp+0x100]
+       mov      r10d, dword ptr [rsp+0x114]
        mov      ecx, r10d
        add      rdx, rcx
        mov      ecx, dword ptr [rax+0x08]
        cmp      rdx, rcx
-       ja       G_M58412_IG72
+       ja       G_M58412_IG76
        cmp      byte  ptr [rax], al
        mov      edx, edi
        lea      rdi, bword ptr [rax+4*rdx+0x10]
 						;; size=37 bbWeight=0.99 PerfScore 9.18
 G_M58412_IG22:
-       mov      bword ptr [rsp+0x50], rdi
-       mov      dword ptr [rsp+0xF8], r10d
-       mov      dword ptr [rsp+0xFC], r8d
+       mov      bword ptr [rsp+0x48], rdi
+       mov      dword ptr [rsp+0x10C], r10d
+       mov      dword ptr [rsp+0x110], r8d
        mov      r9d, r8d
-       mov      qword ptr [rsp+0xE0], r9
+       mov      qword ptr [rsp+0xE8], r9
        mov      rdx, r9
-       mov      bword ptr [rsp+0x58], r11
+       mov      bword ptr [rsp+0x50], r11
        mov      rcx, r11
        mov      r8d, -1
        call     [<unknown method>]
        xor      edx, edx
        test     r13d, r13d
-       jle      G_M58412_IG38
-						;; size=66 bbWeight=0.99 PerfScore 10.43
+       jle      G_M58412_IG42
+						;; size=66 bbWeight=0.99 PerfScore 10.42
 G_M58412_IG23:
        cmp      edx, r13d
-       jae      G_M58412_IG47
-       mov      ecx, edx
-       mov      ecx, dword ptr [rsi+4*rcx]
-       imul     rcx, qword ptr [rsp+0x140]
+       jae      G_M58412_IG51
+       mov      ecx, dword ptr [rsi+4*rdx]
+       imul     rcx, qword ptr [rsp+0x148]
        shr      rcx, 32
        inc      rcx
-       mov      r9, qword ptr [rsp+0xE0]
+       mov      r9, qword ptr [rsp+0xE8]
        imul     rcx, r9
        shr      rcx, 32
-       cmp      ecx, dword ptr [rsp+0xFC]
-       jae      G_M58412_IG47
+       cmp      ecx, dword ptr [rsp+0x110]
+       jae      G_M58412_IG51
        mov      ecx, ecx
-       mov      r10, bword ptr [rsp+0x58]
+       mov      r10, bword ptr [rsp+0x50]
        lea      rcx, bword ptr [r10+4*rcx]
-       cmp      edx, dword ptr [rsp+0xF8]
-       jae      G_M58412_IG47
-       mov      ebp, edx
-       mov      r12d, dword ptr [rcx]
-       mov      dword ptr [rdi+4*rbp], r12d
+       cmp      edx, dword ptr [rsp+0x10C]
+       jae      G_M58412_IG51
+       mov      ebp, dword ptr [rcx]
+       mov      dword ptr [rdi+4*rdx], ebp
        mov      dword ptr [rcx], edx
        inc      edx
        cmp      edx, r13d
-       jl       G_M58412_IG37
-						;; size=105 bbWeight=63.85 PerfScore 1612.20
+       jl       G_M58412_IG41
+						;; size=99 bbWeight=64.36 PerfScore 1593.01
 G_M58412_IG24:
        mov      edx, r13d
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
        mov      gword ptr [rsp+0x98], rax
-       mov      r12d, dword ptr [rsp+0xFC]
-       mov      edx, r12d
+       mov      edx, dword ptr [rsp+0x110]
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Frozen.FrozenHashTable+Bucket[]
        call     CORINFO_HELP_NEWARR_1_VC
        mov      rdx, rax
@@ -1255,125 +1255,135 @@ G_M58412_IG24:
        mov      r8d, dword ptr [rdx+0x08]
        test     r8d, r8d
        jle      SHORT G_M58412_IG27
-						;; size=76 bbWeight=0.99 PerfScore 9.93
+						;; size=72 bbWeight=0.99 PerfScore 9.67
 G_M58412_IG25:
-       cmp      eax, r12d
-       jae      G_M58412_IG47
-       mov      r10d, eax
-       mov      r9, bword ptr [rsp+0x58]
-       mov      r10d, dword ptr [r9+4*r10]
-       test     r10d, r10d
-       jge      G_M58412_IG43
-						;; size=30 bbWeight=433.73 PerfScore 2493.97
+       mov      r10d, dword ptr [rsp+0x110]
+       cmp      eax, r10d
+       jae      G_M58412_IG51
+       mov      r9, bword ptr [rsp+0x50]
+       mov      r11d, dword ptr [r9+4*rax]
+       test     r11d, r11d
+       jge      G_M58412_IG47
+						;; size=35 bbWeight=435.24 PerfScore 2829.06
 G_M58412_IG26:
        inc      eax
        cmp      r8d, eax
-       mov      bword ptr [rsp+0x58], r9
+       mov      dword ptr [rsp+0x110], r10d
+       mov      bword ptr [rsp+0x50], r9
        jg       SHORT G_M58412_IG25
-						;; size=12 bbWeight=433.73 PerfScore 1084.33
+						;; size=20 bbWeight=435.24 PerfScore 1523.34
 G_M58412_IG27:
-       mov      rdi, gword ptr [rsp+0x40]
-       mov      r12, rdi
-       mov      gword ptr [rsp+0x80], r12
-       mov      rax, gword ptr [rsp+0xA0]
-       test     rax, rax
-       je       G_M58412_IG95
-       mov      r12, gword ptr [rsp+0x80]
-       mov      ecx, dword ptr [rax+0x08]
+       mov      rdi, gword ptr [rsp+0x38]
+       mov      rax, rdi
+       mov      gword ptr [rsp+0x80], rax
+       mov      r8, gword ptr [rsp+0xA0]
+       test     r8, r8
+       je       G_M58412_IG99
+						;; size=33 bbWeight=0.99 PerfScore 4.46
+G_M58412_IG28:
+       mov      rax, gword ptr [rsp+0x80]
+       mov      ecx, dword ptr [r8+0x08]
        dec      ecx
        or       ecx, 15
-       xor      r8d, r8d
-       lzcnt    r8d, ecx
-       xor      r8d, 31
-       add      r8d, -3
-       mov      dword ptr [rsp+0x13C], r8d
-       mov      r10, bword ptr [rsp+0x48]
-       mov      r11, gword ptr [r10]
-       test     r11, r11
-       je       G_M58412_IG73
-						;; size=90 bbWeight=0.99 PerfScore 15.89
-G_M58412_IG28:
-       xor      ecx, ecx
-       mov      dword ptr [rsp+0x134], 1
-       cmp      dword ptr [r11+0x08], r8d
-       jbe      G_M58412_IG29
-       mov      dword ptr [rsp+0x138], 1
-       mov      r12d, 16
-       shlx     r12d, r12d, r8d
-       cmp      dword ptr [rax+0x08], r12d
-       jne      G_M58412_IG74
-       cmp      r8d, dword ptr [r11+0x08]
-       jae      G_M58412_IG47
-       mov      r12d, r8d
-       shl      r12, 4
-       lea      r12, bword ptr [r11+r12+0x10]
-       mov      r11, gword ptr [r12]
-       mov      gword ptr [rsp+0x70], r11
-       mov      rcx, r12
-       mov      rdx, rax
+       xor      r11d, r11d
+       lzcnt    r11d, ecx
+       xor      r11d, 31
+       add      r11d, -3
+       mov      dword ptr [rsp+0x144], r11d
+       mov      rcx, bword ptr [rsp+0x40]
+       mov      r10, gword ptr [rcx]
+       test     r10, r10
+       je       G_M58412_IG77
+						;; size=58 bbWeight=0.99 PerfScore 11.43
+G_M58412_IG29:
+       xor      r9d, r9d
+       mov      dword ptr [rsp+0x13C], 1
+       cmp      dword ptr [r10+0x08], r11d
+       jbe      G_M58412_IG31
+						;; size=24 bbWeight=0.99 PerfScore 5.22
+G_M58412_IG30:
+       mov      dword ptr [rsp+0x140], 1
+       mov      eax, 16
+       shlx     eax, eax, r11d
+       cmp      dword ptr [r8+0x08], eax
+       jne      G_M58412_IG78
+       cmp      r11d, dword ptr [r10+0x08]
+       jae      G_M58412_IG51
+       mov      eax, r11d
+       shl      rax, 4
+       lea      rax, bword ptr [r10+rax+0x10]
+       mov      bword ptr [rsp+0x70], rax
+       mov      r10, gword ptr [rax]
+       mov      gword ptr [rsp+0x68], r10
+       mov      rcx, rax
+       mov      rdx, r8
        call     CORINFO_HELP_ASSIGN_REF
        xor      ecx, ecx
-       mov      dword ptr [r12+0x08], ecx
-       mov      r12, gword ptr [rsp+0x70]
-       test     r12, r12
-       mov      gword ptr [rsp+0x70], r12
-       mov      rax, gword ptr [rsp+0xA0]
-       mov      ecx, dword ptr [rsp+0x138]
-       mov      r8d, dword ptr [rsp+0x13C]
-       mov      r12, gword ptr [rsp+0x80]
-       jne      G_M58412_IG75
-						;; size=154 bbWeight=0.99 PerfScore 29.54
-G_M58412_IG29:
-       mov      r11, gword ptr [rsp+0x38]
-       mov      r9, r11
-       mov      gword ptr [rsp+0x78], r9
-       cmp      byte  ptr [r9+0x9D], 0
-       jne      G_M58412_IG90
-						;; size=27 bbWeight=0.99 PerfScore 6.21
-G_M58412_IG30:
+       mov      rdx, bword ptr [rsp+0x70]
+       mov      dword ptr [rdx+0x08], ecx
+       mov      rax, gword ptr [rsp+0x68]
+       test     rax, rax
+       mov      gword ptr [rsp+0x68], rax
+       mov      r8, gword ptr [rsp+0xA0]
+       mov      r9d, dword ptr [rsp+0x140]
+       mov      r11d, dword ptr [rsp+0x144]
+       jne      G_M58412_IG79
+						;; size=130 bbWeight=0.99 PerfScore 25.32
+G_M58412_IG31:
+       mov      r10, gword ptr [rsp+0x30]
+       mov      rax, r10
+       mov      gword ptr [rsp+0x78], rax
+       cmp      byte  ptr [rax+0x9D], 0
+       jne      G_M58412_IG94
+						;; size=26 bbWeight=0.99 PerfScore 6.20
+G_M58412_IG32:
        mov      rbp, gword ptr [rsp+0x98]
        mov      rdx, gword ptr [rsp+0x90]
-       mov      r12, qword ptr [rsp+0x140]
+       mov      rax, qword ptr [rsp+0x148]
+       mov      qword ptr [rsp+0x100], rax
        lea      rcx, bword ptr [rbx+0x20]
        call     CORINFO_HELP_ASSIGN_REF
        lea      rcx, bword ptr [rbx+0x28]
        mov      rdx, rbp
        call     CORINFO_HELP_ASSIGN_REF
-       mov      qword ptr [rbx+0x30], r12
+       mov      rbp, qword ptr [rsp+0x100]
+       mov      qword ptr [rbx+0x30], rbp
        xor      ecx, ecx
        test     r13d, r13d
-       jle      SHORT G_M58412_IG33
-						;; size=56 bbWeight=0.99 PerfScore 8.69
-G_M58412_IG31:
-       mov      r15d, dword ptr [rsp+0xDC]
+       jle      SHORT G_M58412_IG35
+						;; size=72 bbWeight=0.99 PerfScore 10.67
+G_M58412_IG33:
+       mov      r15d, dword ptr [rsp+0xE4]
        cmp      r15d, r13d
-       jl       G_M58412_IG46
-       align    [0 bytes for IG32]
+       jl       G_M58412_IG50
+       align    [0 bytes for IG34]
 						;; size=17 bbWeight=0.98 PerfScore 2.20
-G_M58412_IG32:
+G_M58412_IG34:
        cmp      ecx, r13d
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      edx, ecx
        mov      eax, dword ptr [rsi+4*rdx]
        mov      r8, gword ptr [rbx+0x10]
        movsx    r10, word  ptr [r14+4*rdx+0x10]
        cmp      eax, dword ptr [r8+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      r9d, eax
        mov      word  ptr [r8+2*r9+0x10], r10w
        mov      r9, gword ptr [rbx+0x18]
        movsx    rdx, word  ptr [r14+4*rdx+0x12]
        cmp      eax, dword ptr [r9+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      word  ptr [r9+2*rax+0x10], dx
        inc      ecx
        cmp      ecx, r13d
-       jl       SHORT G_M58412_IG32
-						;; size=76 bbWeight=61.93 PerfScore 1687.60
-G_M58412_IG33:
+       jl       SHORT G_M58412_IG34
+						;; size=76 bbWeight=62.88 PerfScore 1713.44
+G_M58412_IG35:
        mov      r12, gword ptr [rsp+0xD0]
        test     r12, r12
-       je       G_M58412_IG95
+       je       G_M58412_IG99
+						;; size=17 bbWeight=0.99 PerfScore 2.23
+G_M58412_IG36:
        mov      ecx, dword ptr [r12+0x08]
        dec      ecx
        or       ecx, 15
@@ -1381,23 +1391,25 @@ G_M58412_IG33:
        lzcnt    ebp, ecx
        xor      ebp, 31
        add      ebp, -3
-       mov      rbx, bword ptr [rsp+0x48]
+       mov      rbx, bword ptr [rsp+0x40]
        mov      rax, gword ptr [rbx]
        test     rax, rax
-       je       G_M58412_IG96
-						;; size=56 bbWeight=0.99 PerfScore 11.67
-G_M58412_IG34:
+       je       G_M58412_IG100
+						;; size=39 bbWeight=0.99 PerfScore 9.44
+G_M58412_IG37:
        xor      esi, esi
        mov      r15d, 1
        cmp      dword ptr [rax+0x08], ebp
-       jbe      SHORT G_M58412_IG35
+       jbe      SHORT G_M58412_IG39
+						;; size=13 bbWeight=0.99 PerfScore 4.47
+G_M58412_IG38:
        mov      esi, 1
        mov      ecx, 16
        shlx     ecx, ecx, ebp
        cmp      dword ptr [r12+0x08], ecx
-       jne      G_M58412_IG97
+       jne      G_M58412_IG101
        cmp      ebp, dword ptr [rax+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      ecx, ebp
        shl      rcx, 4
        lea      rbx, bword ptr [rax+rcx+0x10]
@@ -1408,14 +1420,14 @@ G_M58412_IG34:
        xor      ecx, ecx
        mov      dword ptr [rbx+0x08], ecx
        test     r13, r13
-       jne      G_M58412_IG98
-						;; size=87 bbWeight=0.99 PerfScore 21.10
-G_M58412_IG35:
-       mov      rbx, gword ptr [rsp+0x38]
+       jne      G_M58412_IG102
+						;; size=74 bbWeight=0.99 PerfScore 16.63
+G_M58412_IG39:
+       mov      rbx, gword ptr [rsp+0x30]
        cmp      byte  ptr [rbx+0x9D], 0
-       jne      G_M58412_IG112
+       jne      G_M58412_IG116
 						;; size=18 bbWeight=0.99 PerfScore 4.96
-G_M58412_IG36:
+G_M58412_IG40:
        add      rsp, 360
        pop      rbx
        pop      rbp
@@ -1427,105 +1439,104 @@ G_M58412_IG36:
        pop      r15
        ret      
 						;; size=20 bbWeight=0.99 PerfScore 5.21
-G_M58412_IG37:
-       mov      rdi, bword ptr [rsp+0x50]
+G_M58412_IG41:
+       mov      rdi, bword ptr [rsp+0x48]
        jmp      G_M58412_IG23
-						;; size=10 bbWeight=31.92 PerfScore 95.77
-G_M58412_IG38:
+						;; size=10 bbWeight=32.18 PerfScore 96.55
+G_M58412_IG42:
        jmp      G_M58412_IG24
-       align    [0 bytes for IG44]
+       align    [0 bytes for IG48]
 						;; size=5 bbWeight=0.50 PerfScore 0.99
-G_M58412_IG39:
-       mov      r15d, dword ptr [rsp+0xDC]
+G_M58412_IG43:
+       mov      r15d, dword ptr [rsp+0xE4]
        jmp      G_M58412_IG18
-						;; size=13 bbWeight=31.73 PerfScore 95.18
-G_M58412_IG40:
-       mov      dword ptr [rsp+0xDC], r15d
+						;; size=13 bbWeight=32.55 PerfScore 97.65
+G_M58412_IG44:
+       mov      dword ptr [rsp+0xE4], r15d
        jmp      G_M58412_IG20
 						;; size=13 bbWeight=0.50 PerfScore 1.49
-G_M58412_IG41:
-       mov      r8d, dword ptr [rsp+0x160]
-       jmp      G_M58412_IG50
+G_M58412_IG45:
+       mov      r8d, dword ptr [rsp+0x164]
+       jmp      G_M58412_IG54
 						;; size=13 bbWeight=0.50 PerfScore 1.49
-G_M58412_IG42:
-       mov      r8d, dword ptr [rsp+0x160]
-       jmp      G_M58412_IG50
+G_M58412_IG46:
+       mov      r8d, dword ptr [rsp+0x164]
+       jmp      G_M58412_IG54
 						;; size=13 bbWeight=0.50 PerfScore 1.49
-G_M58412_IG43:
-       xor      r11d, r11d
+G_M58412_IG47:
+       xor      r12d, r12d
        mov      edx, ecx
-						;; size=5 bbWeight=60.80 PerfScore 30.40
-G_M58412_IG44:
-       cmp      r10d, r13d
-       jae      G_M58412_IG47
-       mov      edi, r10d
+						;; size=5 bbWeight=61.22 PerfScore 30.61
+G_M58412_IG48:
+       cmp      r11d, r13d
+       jae      G_M58412_IG51
+       mov      edi, r11d
        lea      rdi, bword ptr [rsi+4*rdi]
        mov      bword ptr [rsp+0x88], rdi
        mov      ebp, dword ptr [rdi]
        mov      r15, gword ptr [rsp+0x98]
        cmp      ecx, dword ptr [r15+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      r15d, ecx
        mov      rdi, gword ptr [rsp+0x98]
        mov      dword ptr [rdi+4*r15+0x10], ebp
        mov      rbp, bword ptr [rsp+0x88]
        mov      dword ptr [rbp], ecx
        inc      ecx
-       inc      r11d
-       mov      ebp, dword ptr [rsp+0xF8]
-       cmp      r10d, ebp
-       jae      G_M58412_IG47
-       mov      r10d, r10d
-       mov      r15, bword ptr [rsp+0x50]
-       mov      r10d, dword ptr [r15+4*r10]
-       test     r10d, r10d
-       jge      SHORT G_M58412_IG44
-						;; size=109 bbWeight=64.49 PerfScore 1386.57
-G_M58412_IG45:
-       lea      r10d, [rdx+r11-0x01]
-       mov      r11d, eax
-       mov      rdi, gword ptr [rsp+0x90]
-       lea      r11, bword ptr [rdi+8*r11+0x10]
-       mov      dword ptr [r11], edx
-       mov      dword ptr [r11+0x04], r10d
+       inc      r12d
+       mov      ebp, dword ptr [rsp+0x10C]
+       cmp      r11d, ebp
+       jae      G_M58412_IG51
+       mov      r11d, r11d
+       mov      r15, bword ptr [rsp+0x48]
+       mov      r11d, dword ptr [r15+4*r11]
+       test     r11d, r11d
+       jge      SHORT G_M58412_IG48
+						;; size=109 bbWeight=64.06 PerfScore 1377.34
+G_M58412_IG49:
+       lea      r11d, [rdx+r12-0x01]
+       mov      r12, gword ptr [rsp+0x90]
+       lea      r12, bword ptr [r12+8*rax+0x10]
+       mov      dword ptr [r12], edx
+       mov      dword ptr [r12+0x04], r11d
        jmp      G_M58412_IG26
-						;; size=33 bbWeight=60.80 PerfScore 440.79
-G_M58412_IG46:
+						;; size=32 bbWeight=61.22 PerfScore 428.53
+G_M58412_IG50:
        cmp      ecx, r13d
-       jae      SHORT G_M58412_IG47
+       jae      SHORT G_M58412_IG51
        mov      r8d, ecx
        mov      eax, dword ptr [rsi+4*r8]
        mov      r8, gword ptr [rbx+0x10]
        cmp      ecx, r15d
-       jae      SHORT G_M58412_IG47
+       jae      SHORT G_M58412_IG51
        mov      r10d, ecx
        movsx    r10, word  ptr [r14+4*r10+0x10]
        cmp      eax, dword ptr [r8+0x08]
-       jae      SHORT G_M58412_IG47
+       jae      SHORT G_M58412_IG51
        mov      r9d, eax
        mov      word  ptr [r8+2*r9+0x10], r10w
        mov      r9, gword ptr [rbx+0x18]
        cmp      ecx, r15d
-       jae      SHORT G_M58412_IG47
+       jae      SHORT G_M58412_IG51
        mov      edx, ecx
        movsx    rdx, word  ptr [r14+4*rdx+0x12]
        cmp      eax, dword ptr [r9+0x08]
-       jae      SHORT G_M58412_IG47
+       jae      SHORT G_M58412_IG51
        mov      word  ptr [r9+2*rax+0x10], dx
        inc      ecx
        cmp      ecx, r13d
-       jl       SHORT G_M58412_IG46
-       jmp      G_M58412_IG33
-						;; size=86 bbWeight=0.63 PerfScore 20.17
-G_M58412_IG47:
+       jl       SHORT G_M58412_IG50
+       jmp      G_M58412_IG35
+						;; size=86 bbWeight=0.64 PerfScore 20.48
+G_M58412_IG51:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M58412_IG48:
+G_M58412_IG52:
        mov      ecx, 6
        call     [System.ThrowHelper:ThrowArgumentException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M58412_IG49:
+G_M58412_IG53:
        mov      rcx, rsi
        mov      rdx, r14
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
@@ -1533,25 +1544,25 @@ G_M58412_IG49:
        call     [r11]<unknown method>
        jmp      G_M58412_IG13
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M58412_IG50:
+G_M58412_IG54:
        mov      rcx, gword ptr [r12+0x10]
        cmp      dword ptr [rcx+0x08], r8d
-       jbe      G_M58412_IG62
+       jbe      G_M58412_IG66
        mov      edx, r8d
        mov      rcx, gword ptr [rcx+8*rdx+0x10]
        test     rcx, rcx
-       je       G_M58412_IG61
+       je       G_M58412_IG65
        mov      r13, gword ptr [rcx+0x08]
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 824
+       mov      edx, 878
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        cmp      byte  ptr [(reloc)], 0      ; data for <unknown class>:<unknown field>
-       je       SHORT G_M58412_IG51
+       je       SHORT G_M58412_IG55
        call     [System.Threading.Thread:GetCurrentProcessorNumber():int]
        mov      esi, eax
-       jmp      SHORT G_M58412_IG54
+       jmp      SHORT G_M58412_IG58
 						;; size=75 bbWeight=0 PerfScore 0.00
-G_M58412_IG51:
+G_M58412_IG55:
        mov      ecx, 2
        call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
        mov      esi, dword ptr [rax+0x0AAC]
@@ -1561,31 +1572,31 @@ G_M58412_IG51:
        mov      dword ptr [rax+0x0AAC], ecx
        movzx    rax, si
        test     eax, eax
-       jne      SHORT G_M58412_IG52
+       jne      SHORT G_M58412_IG56
        call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
-       jmp      SHORT G_M58412_IG53
+       jmp      SHORT G_M58412_IG57
 						;; size=50 bbWeight=0 PerfScore 0.00
-G_M58412_IG52:
+G_M58412_IG56:
        mov      eax, esi
        sar      eax, 16
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M58412_IG53:
+G_M58412_IG57:
        mov      esi, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M58412_IG54:
+G_M58412_IG58:
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 726
+       mov      edx, 780
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov      eax, esi
        xor      edx, edx
        div      edx:eax, dword ptr [(reloc)]
        mov      esi, edx
        xor      eax, eax
-       jmp      G_M58412_IG58
+       jmp      G_M58412_IG62
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M58412_IG55:
+G_M58412_IG59:
        cmp      esi, dword ptr [r13+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      ecx, esi
        mov      rdx, gword ptr [r13+8*rcx+0x10]
        mov      gword ptr [rsp+0xA8], rdx
@@ -1599,7 +1610,7 @@ G_M58412_IG55:
        mov      eax, dword ptr [rdx+0x14]
        dec      eax
        cmp      dword ptr [rcx+0x08], eax
-       jbe      SHORT G_M58412_IG56
+       jbe      SHORT G_M58412_IG60
        mov      r8d, eax
        mov      r10, gword ptr [rcx+8*r8+0x10]
        mov      gword ptr [rsp+0xB0], r10
@@ -1608,35 +1619,35 @@ G_M58412_IG55:
        mov      gword ptr [rcx+8*r8+0x10], r9
        mov      dword ptr [rdx+0x14], eax
 						;; size=98 bbWeight=0 PerfScore 0.00
-G_M58412_IG56:
+G_M58412_IG60:
        mov      rcx, rdx
        call     <unknown method>
        mov      rcx, gword ptr [rsp+0xB0]
        test     rcx, rcx
-       jne      SHORT G_M58412_IG59
+       jne      SHORT G_M58412_IG63
        inc      esi
        cmp      dword ptr [r13+0x08], esi
-       jne      SHORT G_M58412_IG57
+       jne      SHORT G_M58412_IG61
        xor      esi, esi
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M58412_IG57:
-       mov      eax, dword ptr [rsp+0x14C]
+G_M58412_IG61:
+       mov      eax, dword ptr [rsp+0x150]
        inc      eax
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M58412_IG58:
-       mov      dword ptr [rsp+0x14C], eax
+G_M58412_IG62:
+       mov      dword ptr [rsp+0x150], eax
        cmp      dword ptr [r13+0x08], eax
-       jg       G_M58412_IG55
+       jg       G_M58412_IG59
        xor      r10, r10
-       jmp      SHORT G_M58412_IG60
+       jmp      SHORT G_M58412_IG64
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M58412_IG59:
+G_M58412_IG63:
        mov      r10, rcx
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M58412_IG60:
+G_M58412_IG64:
        mov      rsi, r10
        test     rsi, rsi
-       je       SHORT G_M58412_IG61
+       je       SHORT G_M58412_IG65
        mov      r13, gword ptr [rsp+0xC0]
        cmp      byte  ptr [r13+0x9D], 0
        mov      r10, rsi
@@ -1647,29 +1658,29 @@ G_M58412_IG60:
        mov      esi, eax
        mov      rax, gword ptr [rsp+0xB8]
        mov      edx, dword ptr [rax+0x08]
-       mov      dword ptr [rsp+0x154], edx
+       mov      dword ptr [rsp+0x158], edx
        mov      rcx, r12
        call     <unknown method>
        mov      r9d, eax
-       mov      r12d, dword ptr [rsp+0x160]
+       mov      r12d, dword ptr [rsp+0x164]
        mov      dword ptr [rsp+0x20], r12d
        mov      edx, esi
-       mov      r8d, dword ptr [rsp+0x154]
+       mov      r8d, dword ptr [rsp+0x158]
        mov      rcx, r13
        call     [<unknown method>]
        mov      r10, gword ptr [rsp+0xB8]
        jmp      G_M58412_IG15
 						;; size=125 bbWeight=0 PerfScore 0.00
-G_M58412_IG61:
+G_M58412_IG65:
        mov      ecx, 16
-       mov      r8d, dword ptr [rsp+0x160]
+       mov      r8d, dword ptr [rsp+0x164]
        shlx     ecx, ecx, r8d
        mov      esi, ecx
-       jmp      SHORT G_M58412_IG65
+       jmp      SHORT G_M58412_IG69
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M58412_IG62:
+G_M58412_IG66:
        test     r13d, r13d
-       jne      SHORT G_M58412_IG63
+       jne      SHORT G_M58412_IG67
        mov      rcx, 0xD1FFAB1E
        mov      edx, 41
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -1677,28 +1688,28 @@ G_M58412_IG62:
        mov      r12, gword ptr [rcx]
        jmp      G_M58412_IG16
 						;; size=43 bbWeight=0 PerfScore 0.00
-G_M58412_IG63:
+G_M58412_IG67:
        mov      ecx, r13d
        mov      rdx, 0xD1FFAB1E
        call     [System.ArgumentOutOfRangeException:ThrowIfNegative[int](int,System.String)]
        mov      esi, r13d
-       jmp      SHORT G_M58412_IG65
+       jmp      SHORT G_M58412_IG69
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M58412_IG64:
+G_M58412_IG68:
        movsxd   rdx, esi
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
-       jmp      SHORT G_M58412_IG66
+       jmp      SHORT G_M58412_IG70
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M58412_IG65:
+G_M58412_IG69:
        cmp      esi, 512
-       jl       SHORT G_M58412_IG64
+       jl       SHORT G_M58412_IG68
        mov      edx, esi
        mov      rcx, 0xD1FFAB1E      ; int[]
        mov      r8d, 16
        call     <unknown method>
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M58412_IG66:
+G_M58412_IG70:
        mov      rsi, rax
        mov      r13, gword ptr [rsp+0xC0]
        cmp      byte  ptr [r13+0x9D], 0
@@ -1711,308 +1722,299 @@ G_M58412_IG66:
        mov      esi, eax
        mov      rax, gword ptr [rsp+0xB8]
        mov      edx, dword ptr [rax+0x08]
-       mov      dword ptr [rsp+0x15C], edx
+       mov      dword ptr [rsp+0x160], edx
        mov      rcx, r12
        call     <unknown method>
        mov      r9d, eax
        mov      dword ptr [rsp+0x20], -1
        mov      edx, esi
-       mov      r8d, dword ptr [rsp+0x15C]
+       mov      r8d, dword ptr [rsp+0x160]
        mov      rcx, r13
        call     [<unknown method>]
        mov      rax, gword ptr [rsp+0xB8]
        mov      edx, dword ptr [rax+0x08]
-       mov      dword ptr [rsp+0x158], edx
+       mov      dword ptr [rsp+0x15C], edx
        mov      rcx, r12
        call     <unknown method>
        mov      r9d, eax
        mov      rcx, gword ptr [r12+0x10]
        mov      edx, 1
        mov      r8d, 2
-       mov      r12d, dword ptr [rsp+0x160]
+       mov      r12d, dword ptr [rsp+0x164]
        cmp      dword ptr [rcx+0x08], r12d
        cmovg    edx, r8d
        mov      dword ptr [rsp+0x20], -1
        mov      dword ptr [rsp+0x28], edx
        mov      rcx, r13
        mov      edx, esi
-       mov      r8d, dword ptr [rsp+0x158]
+       mov      r8d, dword ptr [rsp+0x15C]
        call     [<unknown method>]
        mov      r10, gword ptr [rsp+0xB8]
        jmp      G_M58412_IG15
 						;; size=210 bbWeight=0 PerfScore 0.00
-G_M58412_IG67:
+G_M58412_IG71:
        test     r13d, r13d
-       jne      SHORT G_M58412_IG72
+       jne      SHORT G_M58412_IG76
        xor      rsi, rsi
        xor      r13d, r13d
        jmp      G_M58412_IG17
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M58412_IG68:
-       mov      dword ptr [rsp+0x164], ecx
+G_M58412_IG72:
+       mov      qword ptr [rsp+0xD8], rcx
        mov      rcx, r9
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      edx, eax
-       mov      ecx, dword ptr [rsp+0x164]
+       mov      rcx, qword ptr [rsp+0xD8]
        mov      r8, bword ptr [rsp+0xC8]
        jmp      G_M58412_IG19
-						;; size=45 bbWeight=0 PerfScore 0.00
-G_M58412_IG69:
+						;; size=47 bbWeight=0 PerfScore 0.00
+G_M58412_IG73:
        test     edi, edi
-       jne      SHORT G_M58412_IG72
+       jne      SHORT G_M58412_IG76
        xor      r10, r10
        xor      r9, r9
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M58412_IG70:
-       mov      ecx, r10d
+G_M58412_IG74:
        test     rax, rax
-       mov      r8d, ecx
+       mov      r8d, r10d
        mov      r11, r9
        jne      G_M58412_IG21
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M58412_IG71:
-       mov      r10d, dword ptr [rsp+0x100]
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M58412_IG75:
+       mov      r10d, dword ptr [rsp+0x114]
        or       edi, r10d
-       jne      SHORT G_M58412_IG72
+       jne      SHORT G_M58412_IG76
        xor      rdi, rdi
        xor      r10d, r10d
        jmp      G_M58412_IG22
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M58412_IG72:
+G_M58412_IG76:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M58412_IG73:
-       mov      rcx, r12
+G_M58412_IG77:
+       mov      rcx, rax
        call     [System.Buffers.SharedArrayPool`1[int]:InitializeTlsBucketsAndTrimming():System.Buffers.SharedArrayPoolThreadLocalArray[]:this]
-       mov      r11, rax
-       mov      rax, gword ptr [rsp+0xA0]
-       mov      r8d, dword ptr [rsp+0x13C]
-       jmp      G_M58412_IG28
+       mov      r10, rax
+       mov      r8, gword ptr [rsp+0xA0]
+       mov      r11d, dword ptr [rsp+0x144]
+       jmp      G_M58412_IG29
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M58412_IG74:
+G_M58412_IG78:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
-       mov      r12, rax
-       call     [<unknown method>]
        mov      rbx, rax
+       call     [<unknown method>]
+       mov      rsi, rax
        mov      ecx, 607
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
        mov      r8, rax
-       mov      rdx, rbx
-       mov      rcx, r12
+       mov      rdx, rsi
+       mov      rcx, rbx
        call     [<unknown method>]
-       mov      rcx, r12
+       mov      rcx, rbx
        call     CORINFO_HELP_THROW
 						;; size=70 bbWeight=0 PerfScore 0.00
-G_M58412_IG75:
+G_M58412_IG79:
        mov      gword ptr [rsp+0x1B0], rbx
-       mov      r11, gword ptr [r12+0x10]
-       cmp      r8d, dword ptr [r11+0x08]
-       jae      G_M58412_IG47
-       mov      ebx, r8d
-       mov      r11, gword ptr [r11+8*rbx+0x10]
-       test     r11, r11
-       mov      dword ptr [rsp+0x138], ecx
-       jne      SHORT G_M58412_IG77
-       mov      rcx, r12
-       mov      edx, r8d
+       mov      r10, gword ptr [rsp+0x80]
+       mov      rbx, gword ptr [r10+0x10]
+       cmp      r11d, dword ptr [rbx+0x08]
+       jae      G_M58412_IG51
+       mov      ebp, r11d
+       mov      rbx, gword ptr [rbx+8*rbp+0x10]
+       test     rbx, rbx
+       mov      dword ptr [rsp+0x140], r9d
+       jne      SHORT G_M58412_IG81
+       mov      rcx, r10
+       mov      edx, r11d
        call     [System.Buffers.SharedArrayPool`1[int]:CreatePerCorePartitions(int):System.Buffers.SharedArrayPoolPartitions:this]
-       mov      r11, rax
-						;; size=58 bbWeight=0 PerfScore 0.00
-G_M58412_IG76:
-       mov      rbx, gword ptr [r11+0x08]
+       mov      rbx, rax
+						;; size=66 bbWeight=0 PerfScore 0.00
+G_M58412_IG80:
+       mov      rbx, gword ptr [rbx+0x08]
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 824
+       mov      edx, 878
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        cmp      byte  ptr [(reloc)], 0      ; data for <unknown class>:<unknown field>
-       je       SHORT G_M58412_IG78
+       je       SHORT G_M58412_IG82
        call     [System.Threading.Thread:GetCurrentProcessorNumber():int]
-       mov      edx, eax
-       mov      dword ptr [rsp+0x118], edx
-       jmp      SHORT G_M58412_IG81
-						;; size=50 bbWeight=0 PerfScore 0.00
-G_M58412_IG77:
-       jmp      SHORT G_M58412_IG76
-						;; size=2 bbWeight=0 PerfScore 0.00
-G_M58412_IG78:
-       mov      ecx, 2
-       call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
-       mov      eax, dword ptr [rax+0x0AAC]
-       mov      dword ptr [rsp+0x114], eax
-       mov      ecx, 2
-       call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
-       mov      ecx, dword ptr [rsp+0x114]
-       lea      edx, [rcx-0x01]
-       mov      dword ptr [rax+0x0AAC], edx
-       movzx    rax, cx
-       test     eax, eax
-       jne      SHORT G_M58412_IG79
-       call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
-       mov      edx, eax
-       jmp      SHORT G_M58412_IG80
-						;; size=66 bbWeight=0 PerfScore 0.00
-G_M58412_IG79:
-       mov      edx, ecx
-       sar      edx, 16
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M58412_IG80:
-       mov      dword ptr [rsp+0x118], edx
-						;; size=7 bbWeight=0 PerfScore 0.00
+       mov      ebp, eax
+       jmp      SHORT G_M58412_IG85
+						;; size=43 bbWeight=0 PerfScore 0.00
 G_M58412_IG81:
+       jmp      SHORT G_M58412_IG80
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M58412_IG82:
+       mov      ecx, 2
+       call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
+       mov      ebp, dword ptr [rax+0x0AAC]
+       mov      ecx, 2
+       call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
+       lea      ecx, [rbp-0x01]
+       mov      dword ptr [rax+0x0AAC], ecx
+       movzx    rax, bp
+       test     eax, eax
+       jne      SHORT G_M58412_IG83
+       call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
+       jmp      SHORT G_M58412_IG84
+						;; size=50 bbWeight=0 PerfScore 0.00
+G_M58412_IG83:
+       mov      eax, ebp
+       sar      eax, 16
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M58412_IG84:
+       mov      ebp, eax
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M58412_IG85:
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 726
+       mov      edx, 780
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov      eax, dword ptr [rsp+0x118]
+       mov      eax, ebp
        xor      edx, edx
        div      edx:eax, dword ptr [(reloc)]
-       mov      eax, edx
-       xor      edx, edx
-       jmp      G_M58412_IG86
-						;; size=44 bbWeight=0 PerfScore 0.00
-G_M58412_IG82:
-       cmp      eax, dword ptr [rbx+0x08]
-       jae      G_M58412_IG47
-       mov      dword ptr [rsp+0x120], eax
-       mov      ecx, eax
-       mov      r8, gword ptr [rbx+8*rcx+0x10]
-       mov      gword ptr [rsp+0x68], r8
-       cmp      byte  ptr [r8], r8b
-       xor      r10d, r10d
-       mov      dword ptr [rsp+0x110], r10d
-       mov      rcx, r8
+       mov      ebp, edx
+       xor      eax, eax
+       jmp      G_M58412_IG90
+						;; size=39 bbWeight=0 PerfScore 0.00
+G_M58412_IG86:
+       cmp      ebp, dword ptr [rbx+0x08]
+       jae      G_M58412_IG51
+       mov      ecx, ebp
+       mov      rdx, gword ptr [rbx+8*rcx+0x10]
+       mov      gword ptr [rsp+0x60], rdx
+       cmp      byte  ptr [rdx], dl
+       xor      r8d, r8d
+       mov      dword ptr [rsp+0x124], r8d
+       mov      rcx, rdx
        call     <unknown method>
-       mov      rax, gword ptr [rsp+0x68]
+       mov      rax, gword ptr [rsp+0x60]
        mov      rcx, gword ptr [rax+0x08]
        mov      r8d, dword ptr [rax+0x14]
-       mov      dword ptr [rsp+0x10C], r8d
+       mov      dword ptr [rsp+0x120], r8d
        cmp      dword ptr [rcx+0x08], r8d
-       jbe      SHORT G_M58412_IG84
+       jbe      SHORT G_M58412_IG88
        test     r8d, r8d
-       jne      SHORT G_M58412_IG87
+       jne      SHORT G_M58412_IG91
        xor      edx, edx
        mov      dword ptr [rax+0x18], edx
-						;; size=87 bbWeight=0 PerfScore 0.00
-G_M58412_IG83:
+						;; size=79 bbWeight=0 PerfScore 0.00
+G_M58412_IG87:
        movsxd   rdx, r8d
        lea      rcx, bword ptr [rcx+8*rdx+0x10]
-       mov      rdx, gword ptr [rsp+0x70]
+       mov      rdx, gword ptr [rsp+0x68]
        call     CORINFO_HELP_ASSIGN_REF
-       mov      ecx, dword ptr [rsp+0x10C]
+       mov      ecx, dword ptr [rsp+0x120]
        inc      ecx
-       mov      rax, gword ptr [rsp+0x68]
+       mov      rax, gword ptr [rsp+0x60]
        mov      dword ptr [rax+0x14], ecx
-       mov      dword ptr [rsp+0x110], 1
+       mov      dword ptr [rsp+0x124], 1
 						;; size=46 bbWeight=0 PerfScore 0.00
-G_M58412_IG84:
-       mov      rcx, rax
-       call     <unknown method>
-       cmp      dword ptr [rsp+0x110], 0
-       jne      SHORT G_M58412_IG88
-       mov      eax, dword ptr [rsp+0x120]
-       inc      eax
-       mov      ecx, eax
-       cmp      dword ptr [rbx+0x08], ecx
-       jne      SHORT G_M58412_IG85
-       xor      ecx, ecx
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M58412_IG85:
-       mov      edx, dword ptr [rsp+0x11C]
-       inc      edx
-       mov      eax, ecx
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M58412_IG86:
-       mov      dword ptr [rsp+0x11C], edx
-       cmp      dword ptr [rbx+0x08], edx
-       jg       G_M58412_IG82
-       xor      r9d, r9d
-       jmp      SHORT G_M58412_IG89
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M58412_IG87:
-       jmp      SHORT G_M58412_IG83
-						;; size=2 bbWeight=0 PerfScore 0.00
 G_M58412_IG88:
-       mov      r9d, 1
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M58412_IG89:
-       mov      ebx, r9d
-       mov      dword ptr [rsp+0x134], ebx
-       mov      rax, gword ptr [rsp+0xA0]
-       mov      ecx, dword ptr [rsp+0x138]
-       mov      rbx, gword ptr [rsp+0x1B0]
-       mov      r8d, dword ptr [rsp+0x13C]
-       jmp      G_M58412_IG29
-						;; size=46 bbWeight=0 PerfScore 0.00
-G_M58412_IG90:
-       cmp      dword ptr [rax+0x08], 0
-       mov      dword ptr [rsp+0x138], ecx
-       je       G_M58412_IG30
        mov      rcx, rax
        call     <unknown method>
-       mov      dword ptr [rsp+0x130], eax
+       cmp      dword ptr [rsp+0x124], 0
+       jne      SHORT G_M58412_IG92
+       inc      ebp
+       cmp      dword ptr [rbx+0x08], ebp
+       jne      SHORT G_M58412_IG89
+       xor      ebp, ebp
+						;; size=27 bbWeight=0 PerfScore 0.00
+G_M58412_IG89:
+       mov      eax, dword ptr [rsp+0x128]
+       inc      eax
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M58412_IG90:
+       mov      dword ptr [rsp+0x128], eax
+       cmp      dword ptr [rbx+0x08], eax
+       jg       G_M58412_IG86
+       xor      eax, eax
+       jmp      SHORT G_M58412_IG93
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M58412_IG91:
+       jmp      SHORT G_M58412_IG87
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M58412_IG92:
+       mov      eax, 1
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M58412_IG93:
+       mov      ebx, eax
+       mov      dword ptr [rsp+0x13C], ebx
+       mov      rbx, gword ptr [rsp+0x1B0]
+       mov      r8, gword ptr [rsp+0xA0]
+       mov      r9d, dword ptr [rsp+0x140]
+       mov      r11d, dword ptr [rsp+0x144]
+       jmp      G_M58412_IG31
+						;; size=46 bbWeight=0 PerfScore 0.00
+G_M58412_IG94:
+       cmp      dword ptr [r8+0x08], 0
+       mov      dword ptr [rsp+0x140], r9d
+       je       G_M58412_IG32
+       mov      rcx, r8
+       call     <unknown method>
+       mov      dword ptr [rsp+0x138], eax
        mov      rdx, gword ptr [rsp+0xA0]
        mov      r8d, dword ptr [rdx+0x08]
-       mov      dword ptr [rsp+0x12C], r8d
-       mov      rcx, r12
+       mov      dword ptr [rsp+0x134], r8d
+       mov      rcx, gword ptr [rsp+0x80]
        call     <unknown method>
        mov      dword ptr [rsp+0x20], eax
        mov      rcx, gword ptr [rsp+0x78]
-       mov      r8d, dword ptr [rsp+0x130]
-       mov      r9d, dword ptr [rsp+0x12C]
+       mov      r8d, dword ptr [rsp+0x138]
+       mov      r9d, dword ptr [rsp+0x134]
        mov      edx, 3
        call     [<unknown method>]
-       mov      eax, dword ptr [rsp+0x138]
-       test     eax, dword ptr [rsp+0x134]
-       jne      G_M58412_IG30
-       mov      rax, gword ptr [rsp+0xA0]
-       mov      rcx, rax
+       mov      eax, dword ptr [rsp+0x140]
+       test     eax, dword ptr [rsp+0x13C]
+       jne      G_M58412_IG32
+       mov      r8, gword ptr [rsp+0xA0]
+       mov      rcx, r8
        call     <unknown method>
-       mov      dword ptr [rsp+0x128], eax
+       mov      dword ptr [rsp+0x130], eax
        mov      rcx, gword ptr [rsp+0xA0]
        mov      edx, dword ptr [rcx+0x08]
-       mov      dword ptr [rsp+0x124], edx
-       mov      rcx, r12
+       mov      dword ptr [rsp+0x12C], edx
+       mov      rcx, gword ptr [rsp+0x80]
        call     <unknown method>
        mov      r9d, eax
-       cmp      dword ptr [rsp+0x138], 0
-       jne      SHORT G_M58412_IG91
+       cmp      dword ptr [rsp+0x140], 0
+       jne      SHORT G_M58412_IG95
        mov      ecx, -1
-       jmp      SHORT G_M58412_IG92
-						;; size=185 bbWeight=0 PerfScore 0.00
-G_M58412_IG91:
-       mov      r12d, dword ptr [rsp+0x13C]
-       mov      ecx, r12d
-       jmp      SHORT G_M58412_IG93
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M58412_IG92:
+       jmp      SHORT G_M58412_IG96
+						;; size=197 bbWeight=0 PerfScore 0.00
+G_M58412_IG95:
+       mov      ecx, dword ptr [rsp+0x144]
+       jmp      SHORT G_M58412_IG97
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M58412_IG96:
        mov      edx, 1
-       jmp      SHORT G_M58412_IG94
+       jmp      SHORT G_M58412_IG98
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M58412_IG93:
+G_M58412_IG97:
        xor      edx, edx
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M58412_IG94:
+G_M58412_IG98:
        mov      dword ptr [rsp+0x20], ecx
        mov      dword ptr [rsp+0x28], edx
        mov      rcx, gword ptr [rsp+0x78]
-       mov      edx, dword ptr [rsp+0x128]
-       mov      r8d, dword ptr [rsp+0x124]
+       mov      edx, dword ptr [rsp+0x130]
+       mov      r8d, dword ptr [rsp+0x12C]
        call     [<unknown method>]
-       jmp      G_M58412_IG30
+       jmp      G_M58412_IG32
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M58412_IG95:
+G_M58412_IG99:
        mov      ecx, 2
        call     [System.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M58412_IG96:
+G_M58412_IG100:
        mov      rcx, rdi
        call     [System.Buffers.SharedArrayPool`1[int]:InitializeTlsBucketsAndTrimming():System.Buffers.SharedArrayPoolThreadLocalArray[]:this]
-       jmp      G_M58412_IG34
+       jmp      G_M58412_IG37
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M58412_IG97:
+G_M58412_IG101:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rdi, rax
@@ -2028,30 +2030,30 @@ G_M58412_IG97:
        mov      rcx, rdi
        call     CORINFO_HELP_THROW
 						;; size=70 bbWeight=0 PerfScore 0.00
-G_M58412_IG98:
+G_M58412_IG102:
        mov      rcx, gword ptr [rdi+0x10]
        cmp      ebp, dword ptr [rcx+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      edx, ebp
        mov      rax, gword ptr [rcx+8*rdx+0x10]
        test     rax, rax
-       jne      SHORT G_M58412_IG99
+       jne      SHORT G_M58412_IG103
        mov      rcx, rdi
        mov      edx, ebp
        call     [System.Buffers.SharedArrayPool`1[int]:CreatePerCorePartitions(int):System.Buffers.SharedArrayPoolPartitions:this]
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M58412_IG99:
+G_M58412_IG103:
        mov      rbx, gword ptr [rax+0x08]
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 824
+       mov      edx, 878
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        cmp      byte  ptr [(reloc)], 0      ; data for <unknown class>:<unknown field>
-       je       SHORT G_M58412_IG100
+       je       SHORT G_M58412_IG104
        call     [System.Threading.Thread:GetCurrentProcessorNumber():int]
        mov      r14d, eax
-       jmp      SHORT G_M58412_IG103
+       jmp      SHORT G_M58412_IG107
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M58412_IG100:
+G_M58412_IG104:
        mov      ecx, 2
        call     CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
        mov      r14d, dword ptr [rax+0x0AAC]
@@ -2061,92 +2063,92 @@ G_M58412_IG100:
        mov      dword ptr [rax+0x0AAC], ecx
        movzx    rax, r14w
        test     eax, eax
-       jne      SHORT G_M58412_IG101
+       jne      SHORT G_M58412_IG105
        call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
-       jmp      SHORT G_M58412_IG102
+       jmp      SHORT G_M58412_IG106
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M58412_IG101:
+G_M58412_IG105:
        mov      eax, r14d
        sar      eax, 16
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M58412_IG102:
+G_M58412_IG106:
        mov      r14d, eax
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M58412_IG103:
+G_M58412_IG107:
        mov      rcx, 0xD1FFAB1E
-       mov      edx, 726
+       mov      edx, 780
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov      eax, r14d
        xor      edx, edx
        div      edx:eax, dword ptr [(reloc)]
        mov      r14d, edx
        xor      r15d, r15d
-       jmp      G_M58412_IG108
+       jmp      G_M58412_IG112
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M58412_IG104:
+G_M58412_IG108:
        cmp      r14d, dword ptr [rbx+0x08]
-       jae      G_M58412_IG47
+       jae      G_M58412_IG51
        mov      ecx, r14d
        mov      rax, gword ptr [rbx+8*rcx+0x10]
-       mov      gword ptr [rsp+0x60], rax
+       mov      gword ptr [rsp+0x58], rax
        cmp      byte  ptr [rax], al
        xor      edx, edx
-       mov      dword ptr [rsp+0x108], edx
+       mov      dword ptr [rsp+0x11C], edx
        mov      rcx, rax
        call     <unknown method>
-       mov      rax, gword ptr [rsp+0x60]
+       mov      rax, gword ptr [rsp+0x58]
        mov      rcx, gword ptr [rax+0x08]
        mov      r8d, dword ptr [rax+0x14]
-       mov      dword ptr [rsp+0x104], r8d
+       mov      dword ptr [rsp+0x118], r8d
        cmp      dword ptr [rcx+0x08], r8d
-       jbe      SHORT G_M58412_IG106
+       jbe      SHORT G_M58412_IG110
        test     r8d, r8d
-       jne      SHORT G_M58412_IG109
+       jne      SHORT G_M58412_IG113
        xor      edx, edx
        mov      dword ptr [rax+0x18], edx
 						;; size=79 bbWeight=0 PerfScore 0.00
-G_M58412_IG105:
+G_M58412_IG109:
        movsxd   rdx, r8d
        lea      rcx, bword ptr [rcx+8*rdx+0x10]
        mov      rdx, r13
        call     CORINFO_HELP_ASSIGN_REF
-       mov      ecx, dword ptr [rsp+0x104]
+       mov      ecx, dword ptr [rsp+0x118]
        inc      ecx
-       mov      rax, gword ptr [rsp+0x60]
+       mov      rax, gword ptr [rsp+0x58]
        mov      dword ptr [rax+0x14], ecx
-       mov      dword ptr [rsp+0x108], 1
+       mov      dword ptr [rsp+0x11C], 1
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M58412_IG106:
+G_M58412_IG110:
        mov      rcx, rax
        call     <unknown method>
-       cmp      dword ptr [rsp+0x108], 0
-       jne      SHORT G_M58412_IG110
+       cmp      dword ptr [rsp+0x11C], 0
+       jne      SHORT G_M58412_IG114
        inc      r14d
        cmp      dword ptr [rbx+0x08], r14d
-       jne      SHORT G_M58412_IG107
+       jne      SHORT G_M58412_IG111
        xor      r14d, r14d
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M58412_IG107:
+G_M58412_IG111:
        inc      r15d
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M58412_IG108:
+G_M58412_IG112:
        cmp      dword ptr [rbx+0x08], r15d
-       jg       G_M58412_IG104
+       jg       G_M58412_IG108
        xor      r15d, r15d
-       jmp      SHORT G_M58412_IG111
+       jmp      SHORT G_M58412_IG115
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M58412_IG109:
-       jmp      SHORT G_M58412_IG105
+G_M58412_IG113:
+       jmp      SHORT G_M58412_IG109
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M58412_IG110:
+G_M58412_IG114:
        mov      r15d, 1
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M58412_IG111:
-       jmp      G_M58412_IG35
+G_M58412_IG115:
+       jmp      G_M58412_IG39
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M58412_IG112:
+G_M58412_IG116:
        cmp      dword ptr [r12+0x08], 0
-       je       G_M58412_IG36
+       je       G_M58412_IG40
        mov      rcx, r12
        call     <unknown method>
        mov      r14d, eax
@@ -2160,7 +2162,7 @@ G_M58412_IG112:
        mov      edx, 3
        call     [<unknown method>]
        test     esi, r15d
-       jne      G_M58412_IG36
+       jne      G_M58412_IG40
        mov      rcx, r12
        call     <unknown method>
        mov      r14d, eax
@@ -2169,31 +2171,31 @@ G_M58412_IG112:
        call     <unknown method>
        mov      r9d, eax
        test     esi, esi
-       jne      SHORT G_M58412_IG113
+       jne      SHORT G_M58412_IG117
        mov      ecx, -1
-       jmp      SHORT G_M58412_IG114
+       jmp      SHORT G_M58412_IG118
 						;; size=107 bbWeight=0 PerfScore 0.00
-G_M58412_IG113:
+G_M58412_IG117:
        mov      ecx, ebp
-       jmp      SHORT G_M58412_IG115
+       jmp      SHORT G_M58412_IG119
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M58412_IG114:
+G_M58412_IG118:
        mov      edx, 1
-       jmp      SHORT G_M58412_IG116
+       jmp      SHORT G_M58412_IG120
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M58412_IG115:
+G_M58412_IG119:
        xor      edx, edx
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M58412_IG116:
+G_M58412_IG120:
        mov      dword ptr [rsp+0x20], ecx
        mov      dword ptr [rsp+0x28], edx
        mov      rcx, rbx
        mov      edx, r14d
        mov      r8d, r15d
        call     [<unknown method>]
-       jmp      G_M58412_IG36
+       jmp      G_M58412_IG40
 						;; size=28 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 4563, prolog size 38, PerfScore 11592.75, instruction count 1022, allocated bytes for code 4563 (MethodHash=53f11bd3) for method System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[short,short]:.ctor(System.Collections.Generic.Dictionary`2[short,short],ubyte):this (Tier1)
+; Total bytes of code 4544, prolog size 38, PerfScore 12391.20, instruction count 1013, allocated bytes for code 4544 (MethodHash=53f11bd3) for method System.Collections.Frozen.KeysAndValuesFrozenDictionary`2[short,short]:.ctor(System.Collections.Generic.Dictionary`2[short,short],ubyte):this (Tier1)
 ; ============================================================
 


```

</details>

