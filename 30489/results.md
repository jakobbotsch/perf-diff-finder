# ``System.Collections.ContainsFalse<Int32>.ImmutableList(Size: 512)``

Hot functions:

- (97.96%) ``System.Collections.Immutable.ImmutableList`1+Node.Contains`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Collections.Immutable]System.Collections.Immutable.ImmutableList`1+Node[System.Int32].Contains(class Node<!0>,!0,class System.Collections.Generic.IEqualityComparer`1<!0>)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 70944
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 85008
 ; 1 inlinees with PGO data; 4 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T00] (  6,  4.49)     ref  ->  rbx         class-hnd single-def <System.Collections.Immutable.ImmutableList`1+Node[int]>
-;  V01 arg1         [V01,T02] (  9,  4.48)     int  ->  rdi         single-def
-;  V02 arg2         [V02,T01] (  9,  4.48)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEqualityComparer`1[int]>
+;  V01 arg1         [V01,T02] ( 10,  3.73)     int  ->  rdi         single-def
+;  V02 arg2         [V02,T01] ( 10,  3.73)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEqualityComparer`1[int]>
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T07] (  2,  0.99)     int  ->  rax         "guarded devirt return temp"
-;  V05 tmp2         [V05,T04] (  3,  2.98)     int  ->   r8         "guarded devirt arg temp"
+;  V04 tmp1         [V04,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V05 tmp2         [V05,T04] (  3,  1.99)     int  ->   r8         "guarded devirt arg temp"
 ;* V06 tmp3         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[int]>
 ;* V07 tmp4         [V07    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V08 tmp5         [V08,T06] (  2,  0.74)   ubyte  ->  rax         "Inline return value spill temp"
-;  V09 tmp6         [V09,T03] (  5,  3.47)     ref  ->  rbp         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableList`1+Node[int]>
-;  V10 tmp7         [V10,T08] (  2,  0.49)     int  ->  rax         "guarded devirt return temp"
-;  V11 tmp8         [V11,T05] (  3,  1.48)     int  ->   r8         "guarded devirt arg temp"
+;  V08 tmp5         [V08,T06] (  2,  0.49)   ubyte  ->  rax         "Inline return value spill temp"
+;  V09 tmp6         [V09,T03] (  6,  3.47)     ref  ->  rbp         class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableList`1+Node[int]>
+;  V10 tmp7         [V10,T08] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V11 tmp8         [V11,T05] (  3,  0.99)     int  ->   r8         "guarded devirt arg temp"
 ;* V12 tmp9         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[int]>
 ;* V13 tmp10        [V13    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;
@@ -286,94 +286,77 @@ G_M60827_IG01:
 						;; size=16 bbWeight=1 PerfScore 5.00
 G_M60827_IG02:
        cmp      gword ptr [rbx+0x08], 0
-       je       SHORT G_M60827_IG10
-						;; size=7 bbWeight=1 PerfScore 4.00
+       je       G_M60827_IG11
+						;; size=11 bbWeight=1 PerfScore 4.00
 G_M60827_IG03:
        mov      r8d, dword ptr [rbx+0x18]
-       mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.GenericEqualityComparer`1[int]
-       cmp      qword ptr [rsi], rcx
-       jne      SHORT G_M60827_IG04
+       mov      rax, 0xD1FFAB1E      ; System.Collections.Generic.GenericEqualityComparer`1[int]
+       cmp      qword ptr [rsi], rax
+       jne      G_M60827_IG15
        cmp      edi, r8d
-       je       G_M60827_IG14
-       jmp      SHORT G_M60827_IG05
-						;; size=30 bbWeight=0.50 PerfScore 4.72
+       je       SHORT G_M60827_IG13
+						;; size=28 bbWeight=0.50 PerfScore 3.73
 G_M60827_IG04:
-       mov      rcx, rsi
-       mov      edx, edi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M60827_IG14
-						;; size=26 bbWeight=0.50 PerfScore 2.49
-G_M60827_IG05:
        mov      rbp, gword ptr [rbx+0x08]
        cmp      gword ptr [rbp+0x08], 0
-       je       SHORT G_M60827_IG08
+       je       SHORT G_M60827_IG09
 						;; size=11 bbWeight=0.50 PerfScore 2.98
-G_M60827_IG06:
+G_M60827_IG05:
        mov      r8d, dword ptr [rbp+0x18]
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.GenericEqualityComparer`1[int]
        cmp      qword ptr [rsi], rcx
-       jne      SHORT G_M60827_IG12
+       jne      SHORT G_M60827_IG16
+						;; size=19 bbWeight=0.25 PerfScore 1.54
+G_M60827_IG06:
        cmp      edi, r8d
-       je       SHORT G_M60827_IG14
-       jmp      SHORT G_M60827_IG13
-						;; size=26 bbWeight=0.25 PerfScore 2.35
+       je       SHORT G_M60827_IG13
+						;; size=5 bbWeight=0.25 PerfScore 0.31
 G_M60827_IG07:
+       mov      rcx, gword ptr [rbp+0x08]
+       mov      edx, edi
+       mov      r8, rsi
+       call     [System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte]
        test     eax, eax
-       jne      SHORT G_M60827_IG14
-						;; size=4 bbWeight=0.50 PerfScore 0.62
+       jne      SHORT G_M60827_IG13
+						;; size=19 bbWeight=0.25 PerfScore 1.67
 G_M60827_IG08:
+       mov      rcx, gword ptr [rbp+0x10]
+       mov      edx, edi
+       mov      r8, rsi
+       call     [System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte]
+       test     eax, eax
+       jne      SHORT G_M60827_IG13
+						;; size=19 bbWeight=0.25 PerfScore 1.67
+G_M60827_IG09:
        mov      rcx, gword ptr [rbx+0x10]
        mov      edx, edi
        mov      r8, rsi
        call     [System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte]
        nop      
 						;; size=16 bbWeight=0.50 PerfScore 2.86
-G_M60827_IG09:
+G_M60827_IG10:
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.62
-G_M60827_IG10:
+						;; size=9 bbWeight=0.50 PerfScore 1.61
+G_M60827_IG11:
        xor      eax, eax
 						;; size=2 bbWeight=0.50 PerfScore 0.13
-G_M60827_IG11:
+G_M60827_IG12:
        add      rsp, 40
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
        ret      
-						;; size=9 bbWeight=0.50 PerfScore 1.63
-G_M60827_IG12:
-       mov      rcx, rsi
-       mov      edx, edi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      SHORT G_M60827_IG14
-						;; size=22 bbWeight=0.25 PerfScore 1.24
+						;; size=9 bbWeight=0.50 PerfScore 1.64
 G_M60827_IG13:
-       mov      rcx, gword ptr [rbp+0x08]
-       mov      edx, edi
-       mov      r8, rsi
-       call     [System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte]
-       test     eax, eax
-       jne      SHORT G_M60827_IG14
-       mov      rcx, gword ptr [rbp+0x10]
-       mov      edx, edi
-       mov      r8, rsi
-       call     [System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte]
-       jmp      SHORT G_M60827_IG07
-						;; size=36 bbWeight=0.25 PerfScore 3.52
-G_M60827_IG14:
        mov      eax, 1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M60827_IG15:
+G_M60827_IG14:
        add      rsp, 40
        pop      rbx
        pop      rbp
@@ -381,8 +364,32 @@ G_M60827_IG15:
        pop      rdi
        ret      
 						;; size=9 bbWeight=0 PerfScore 0.00
+G_M60827_IG15:
+       mov      rcx, rsi
+       mov      edx, edi
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M60827_IG13
+       jmp      G_M60827_IG04
+						;; size=27 bbWeight=0 PerfScore 0.00
+G_M60827_IG16:
+       mov      rcx, rsi
+       mov      edx, edi
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M60827_IG13
+       mov      rcx, gword ptr [rbp+0x08]
+       mov      edx, edi
+       mov      r8, rsi
+       call     [System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte]
+       test     eax, eax
+       je       G_M60827_IG08
+       jmp      SHORT G_M60827_IG13
+						;; size=47 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 228, prolog size 8, PerfScore 33.16, instruction count 77, allocated bytes for code 228 (MethodHash=be981264) for method System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte (Tier1)
+; Total bytes of code 252, prolog size 8, PerfScore 27.12, instruction count 82, allocated bytes for code 252 (MethodHash=be981264) for method System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(System.Collections.Immutable.ImmutableList`1+Node[int],int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte (Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Collections.Immutable.ImmutableList`1+Node[int]:Contains(int,System.Collections.Generic.IEqualityComparer`1[int]):ubyte:this (Tier1)


```

</details>

# ``System.Collections.ContainsKeyTrue<Int32, Int32>.FrozenDictionary(Size: 512)``

Hot functions:

- (98.34%) ``System.Collections.ContainsKeyTrue`2.FrozenDictionary`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.ContainsKeyTrue`2[System.Int32,System.Int32].FrozenDictionary()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 30252
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 30200
 ; 2 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T17] (  4,   4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsKeyTrue`2[int,int]>
-;  V01 loc0         [V01,T14] (  4, 999.19)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T07] (  6,1496.79)     ref  ->  rsi         class-hnd single-def <System.Collections.Frozen.FrozenDictionary`2[int,int]>
-;  V03 loc2         [V03,T15] (  3, 500.60)     ref  ->  rdi         class-hnd single-def <int[]>
-;  V04 loc3         [V04,T06] (  5,1995.38)     int  ->  rbp        
+;  V01 loc0         [V01,T14] (  4,1000.09)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T07] (  6,1498.14)     ref  ->  rsi         class-hnd single-def <System.Collections.Frozen.FrozenDictionary`2[int,int]>
+;  V03 loc2         [V03,T15] (  3, 501.05)     ref  ->  rdi         class-hnd single-def <int[]>
+;* V04 loc3         [V04,T18] (  0,   0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T01] (  5,3021.26)     int  ->  rdx         "Inlining Arg"
-;  V07 tmp2         [V07,T08] (  4,1495.79)   byref  ->  r15         "guarded devirt return temp"
-;  V08 tmp3         [V08,T09] (  3,1495.79)     ref  ->  rax         class-hnd exact "guarded devirt this exact temp" <System.Collections.Frozen.Int32FrozenDictionary`1[int]>
-;  V09 tmp4         [V09,T00] ( 14,4551.86)     int  ->   r8         ld-addr-op "Inline ldloca(s) first use temp"
-;  V10 tmp5         [V10,T04] (  6,2507.82)     int  ->  rcx         ld-addr-op "Inline ldloca(s) first use temp"
-;  V11 tmp6         [V11,T05] (  7,2019.35)     ref  ->  rax         class-hnd "Inline stloc first use temp" <int[]>
-;  V12 tmp7         [V12,T02] (  3,2991.57)   byref  ->  rcx         "Inlining Arg"
-;  V13 tmp8         [V13,T10] (  3,1495.79)     ref  ->   r8         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V14 tmp9         [V14,T11] (  3,1495.79)   byref  ->  rcx         "Inline stloc first use temp"
+;  V06 tmp1         [V06,T01] (  5,3023.99)     int  ->  rdx         "Inlining Arg"
+;  V07 tmp2         [V07,T08] (  4,1497.14)   byref  ->  r15         "guarded devirt return temp"
+;  V08 tmp3         [V08,T09] (  3,1497.14)     ref  ->  rax         class-hnd exact "guarded devirt this exact temp" <System.Collections.Frozen.Int32FrozenDictionary`1[int]>
+;  V09 tmp4         [V09,T00] ( 14,4555.98)     int  ->   r8         ld-addr-op "Inline ldloca(s) first use temp"
+;  V10 tmp5         [V10,T04] (  6,2510.09)     int  ->  rcx         ld-addr-op "Inline ldloca(s) first use temp"
+;  V11 tmp6         [V11,T05] (  7,2021.17)     ref  ->  rax         class-hnd "Inline stloc first use temp" <int[]>
+;  V12 tmp7         [V12,T02] (  3,2994.28)   byref  ->  rcx         "Inlining Arg"
+;  V13 tmp8         [V13,T10] (  3,1497.14)     ref  ->   r8         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V14 tmp9         [V14,T11] (  3,1497.14)   byref  ->  rcx         "Inline stloc first use temp"
 ;* V15 tmp10        [V15    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V16 tmp11        [V16    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V17 tmp12        [V17,T12] (  3,1495.79)     int  ->  r10         "Inline stloc first use temp"
+;  V17 tmp12        [V17,T12] (  3,1497.14)     int  ->  r10         "Inline stloc first use temp"
 ;* V18 tmp13        [V18    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V19 tmp14        [V19,T03] (  3,2991.57)     ref  ->  rax         "arr expr"
-;  V20 cse0         [V20,T16] (  3, 500.60)     int  ->  r14         "CSE #04: moderate"
-;  V21 cse1         [V21,T13] (  3,1495.79)     int  ->  rcx         "CSE #01: aggressive"
+;  V19 tmp14        [V19,T03] (  3,2994.28)     ref  ->  rax         "arr expr"
+;  V20 cse0         [V20,T16] (  3, 501.05)     int  ->  r14         "CSE #04: moderate"
+;  V21 cse1         [V21,T13] (  3,1497.14)     int  ->  rcx         "CSE #01: aggressive"
+;  V22 rat0         [V22,T06] (  5,1997.19)    long  ->  rbp         "Widened IV V04"
 ;
 ; Lcl frame size = 40
 
@@ -245,8 +246,7 @@ G_M51408_IG02:
        jle      G_M51408_IG12
 						;; size=25 bbWeight=1 PerfScore 7.75
 G_M51408_IG03:
-       mov      eax, ebp
-       mov      edx, dword ptr [rdi+4*rax+0x10]
+       mov      edx, dword ptr [rdi+4*rbp+0x10]
        mov      rax, 0xD1FFAB1E      ; System.Collections.Frozen.Int32FrozenDictionary`1[int]
        cmp      qword ptr [rsi], rax
        jne      G_M51408_IG15
@@ -278,12 +278,12 @@ G_M51408_IG03:
        cmp      dword ptr [rax+0x08], ecx
        jle      SHORT G_M51408_IG08
        align    [0 bytes for IG04]
-						;; size=115 bbWeight=498.60 PerfScore 18198.75
+						;; size=113 bbWeight=499.05 PerfScore 18090.47
 G_M51408_IG04:
        mov      r10d, r8d
        cmp      dword ptr [rax+4*r10+0x10], edx
        jne      SHORT G_M51408_IG06
-						;; size=10 bbWeight=508.30 PerfScore 2160.29
+						;; size=10 bbWeight=508.76 PerfScore 2162.24
 G_M51408_IG05:
        mov      rax, gword ptr [rsi+0x10]
        cmp      r8d, dword ptr [rax+0x08]
@@ -291,19 +291,19 @@ G_M51408_IG05:
        mov      ecx, r8d
        lea      r15, bword ptr [rax+4*rcx+0x10]
        jmp      SHORT G_M51408_IG11
-						;; size=20 bbWeight=498.60 PerfScore 4612.01
+						;; size=20 bbWeight=499.05 PerfScore 4616.19
 G_M51408_IG06:
        inc      r8d
        cmp      r8d, ecx
        jle      SHORT G_M51408_IG04
-						;; size=8 bbWeight=508.30 PerfScore 762.45
+						;; size=8 bbWeight=508.76 PerfScore 763.14
 G_M51408_IG07:
        jmp      SHORT G_M51408_IG10
        align    [0 bytes for IG09]
-						;; size=2 bbWeight=167.77 PerfScore 335.54
+						;; size=2 bbWeight=167.92 PerfScore 335.84
 G_M51408_IG08:
        mov      r10d, dword ptr [rax+0x08]
-						;; size=4 bbWeight=4.99 PerfScore 9.97
+						;; size=4 bbWeight=4.99 PerfScore 9.98
 G_M51408_IG09:
        cmp      r8d, dword ptr [rax+0x08]
        jae      SHORT G_M51408_IG14
@@ -313,10 +313,10 @@ G_M51408_IG09:
        inc      r8d
        cmp      r8d, ecx
        jle      SHORT G_M51408_IG09
-						;; size=24 bbWeight=5.13 PerfScore 50.06
+						;; size=24 bbWeight=5.14 PerfScore 50.11
 G_M51408_IG10:
        xor      r15, r15
-						;; size=3 bbWeight=498.60 PerfScore 124.65
+						;; size=3 bbWeight=499.05 PerfScore 124.76
 G_M51408_IG11:
        xor      eax, eax
        test     r15, r15
@@ -326,7 +326,7 @@ G_M51408_IG11:
        inc      ebp
        cmp      r14d, ebp
        jg       G_M51408_IG03
-						;; size=24 bbWeight=498.60 PerfScore 1745.09
+						;; size=24 bbWeight=499.05 PerfScore 1746.67
 G_M51408_IG12:
        mov      eax, ebx
 						;; size=2 bbWeight=1 PerfScore 0.25
@@ -352,6 +352,6 @@ G_M51408_IG15:
        jmp      SHORT G_M51408_IG11
 						;; size=18 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 285, prolog size 12, PerfScore 28017.31, instruction count 95, allocated bytes for code 285 (MethodHash=8ef5372f) for method System.Collections.ContainsKeyTrue`2[int,int]:FrozenDictionary():ubyte:this (Tier1)
+; Total bytes of code 283, prolog size 12, PerfScore 27917.90, instruction count 94, allocated bytes for code 283 (MethodHash=8ef5372f) for method System.Collections.ContainsKeyTrue`2[int,int]:FrozenDictionary():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Perf_Frozen<NotKnownComparable>.Contains_True(Count: 64)``

Hot functions:

- (98.52%) ``System.Collections.Perf_Frozen`1.Contains_True`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable].Contains_True()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 48104
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 46104
 ; 2 inlinees with PGO data; 8 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T20] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]>
-;  V01 loc0         [V01,T14] (  4,129.23)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T05] (  7,224.39)     ref  ->  rsi         class-hnd single-def <System.Collections.Frozen.FrozenSet`1[System.Collections.NotKnownComparable]>
-;  V03 loc2         [V03,T18] (  3, 65.62)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
-;  V04 loc3         [V04,T04] (  5,255.47)     int  ->  rbp        
+;  V00 this         [V00,T21] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]>
+;  V01 loc0         [V01,T15] (  4,129.98)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T06] (  7,225.70)     ref  ->  rsi         class-hnd single-def <System.Collections.Frozen.FrozenSet`1[System.Collections.NotKnownComparable]>
+;  V03 loc2         [V03,T19] (  3, 65.99)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
+;* V04 loc3         [V04,T22] (  0,  0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.NotKnownComparable>
-;  V07 tmp2         [V07,T08] (  4,190.85)     int  ->  r10         "guarded devirt return temp"
-;  V08 tmp3         [V08,T15] (  2,127.23)     ref  ->  rax         class-hnd exact "guarded devirt this exact temp" <System.Collections.Frozen.ValueTypeDefaultComparerFrozenSet`1[System.Collections.NotKnownComparable]>
-;  V09 tmp4         [V09,T06] (  3,193.86)     int  ->  rcx         "Inline stloc first use temp"
-;  V10 tmp5         [V10,T00] ( 10,651.22)     int  ->   r8         ld-addr-op "Inline ldloca(s) first use temp"
-;  V11 tmp6         [V11,T07] (  3,193.86)     int  ->  rax         ld-addr-op "Inline ldloca(s) first use temp"
+;  V07 tmp2         [V07,T09] (  4,191.97)     int  ->   r8         "guarded devirt return temp"
+;  V08 tmp3         [V08,T16] (  2,127.98)     ref  ->  rax         class-hnd exact "guarded devirt this exact temp" <System.Collections.Frozen.ValueTypeDefaultComparerFrozenSet`1[System.Collections.NotKnownComparable]>
+;  V09 tmp4         [V09,T07] (  3,194.99)     int  ->  rcx         "Inline stloc first use temp"
+;  V10 tmp5         [V10,T05] (  4,255.96)     int  ->   r8         ld-addr-op "Inline ldloca(s) first use temp"
+;  V11 tmp6         [V11,T08] (  3,194.99)     int  ->  rax         ld-addr-op "Inline ldloca(s) first use temp"
 ;* V12 tmp7         [V12    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V13 tmp8         [V13    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.NotKnownComparable>
-;  V14 tmp9         [V14,T02] (  3,381.70)   byref  ->  rax         "Inlining Arg"
-;  V15 tmp10        [V15,T10] (  3,190.85)     ref  ->   r8         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V16 tmp11        [V16,T11] (  3,190.85)   byref  ->  rax         "Inline stloc first use temp"
+;  V14 tmp9         [V14,T02] (  3,383.93)   byref  ->  rax         "Inlining Arg"
+;  V15 tmp10        [V15,T11] (  3,191.97)     ref  ->   r8         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V16 tmp11        [V16,T12] (  3,191.97)   byref  ->  rax         "Inline stloc first use temp"
 ;* V17 tmp12        [V17    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V18 tmp13        [V18    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V19 tmp14        [V19,T12] (  3,190.85)     int  ->  r10         "Inline stloc first use temp"
+;  V19 tmp14        [V19,T13] (  3,191.97)     int  ->  r10         "Inline stloc first use temp"
 ;* V20 tmp15        [V20    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V21 tmp16        [V21    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V22 tmp17        [V22    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.NotKnownComparable>
 ;* V23 tmp18        [V23    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.NotKnownComparable>
-;  V24 tmp19        [V24,T09] (  4,190.85)   short  ->  rdx         "field V06._value (fldOffset=0x0)" P-INDEP
+;  V24 tmp19        [V24,T10] (  4,191.97)   short  ->  rdx         "field V06._value (fldOffset=0x0)" P-INDEP
 ;* V25 tmp20        [V25    ] (  0,  0   )   short  ->  zero-ref    "field V13._value (fldOffset=0x0)" P-INDEP
 ;* V26 tmp21        [V26    ] (  0,  0   )   short  ->  zero-ref    "field V22._value (fldOffset=0x0)" P-INDEP
-;  V27 tmp22        [V27,T16] (  2,127.23)   short  ->   r9         "field V23._value (fldOffset=0x0)" P-INDEP
-;  V28 tmp23        [V28,T01] (  3,399.76)     ref  ->   r9         "arr expr"
-;  V29 tmp24        [V29,T03] (  3,381.70)     ref  ->   r9         "arr expr"
-;  V30 cse0         [V30,T17] (  2, 99.17)     ref  ->  r10         hoist "CSE #02: moderate"
-;  V31 cse1         [V31,T19] (  3, 65.62)     int  ->  r14         "CSE #05: moderate"
-;  V32 cse2         [V32,T13] (  3,190.85)     int  ->  rax         "CSE #01: moderate"
+;  V27 tmp22        [V27,T17] (  2,127.98)   short  ->   r9         "field V23._value (fldOffset=0x0)" P-INDEP
+;  V28 tmp23        [V28,T01] (  3,402.08)     ref  ->   r9         "arr expr"
+;  V29 tmp24        [V29,T03] (  3,383.93)     ref  ->   r9         "arr expr"
+;  V30 cse0         [V30,T18] (  2, 99.75)     ref  ->  r10         hoist "CSE #02: moderate"
+;  V31 cse1         [V31,T20] (  3, 65.99)     int  ->  r14         "CSE #05: moderate"
+;  V32 cse2         [V32,T14] (  3,191.97)     int  ->  rax         "CSE #01: moderate"
+;  V33 rat0         [V33,T04] (  5,256.96)    long  ->  rbp         "Widened IV V04"
+;  V34 rat1         [V34,T00] ( 10,655.01)    long  ->   r8         "Widened IV V10"
 ;
 ; Lcl frame size = 32
 
@@ -252,14 +254,13 @@ G_M7615_IG02:
        xor      ebp, ebp
        mov      r14d, dword ptr [rdi+0x08]
        test     r14d, r14d
-       jle      G_M7615_IG11
+       jle      G_M7615_IG10
 						;; size=25 bbWeight=1 PerfScore 7.75
 G_M7615_IG03:
-       mov      eax, ebp
-       movsx    rdx, word  ptr [rdi+2*rax+0x10]
+       movsx    rdx, word  ptr [rdi+2*rbp+0x10]
        mov      rax, 0xD1FFAB1E      ; System.Collections.Frozen.ValueTypeDefaultComparerFrozenSet`1[System.Collections.NotKnownComparable]
        cmp      qword ptr [rsi], rax
-       jne      G_M7615_IG14
+       jne      G_M7615_IG13
        mov      rax, rsi
        mov      ecx, edx
        add      rax, 32
@@ -273,50 +274,44 @@ G_M7615_IG03:
        imul     r10, r9
        shr      r10, 32
        cmp      r10d, eax
-       jae      G_M7615_IG13
+       jae      SHORT G_M7615_IG12
        mov      eax, r10d
        lea      rax, bword ptr [r8+8*rax+0x10]
        mov      r8d, dword ptr [rax]
        mov      eax, dword ptr [rax+0x04]
        cmp      r8d, eax
        jg       SHORT G_M7615_IG08
-						;; size=97 bbWeight=63.62 PerfScore 1892.60
+						;; size=91 bbWeight=63.99 PerfScore 1887.67
 G_M7615_IG04:
        mov      r10, gword ptr [rsi+0x28]
        align    [0 bytes for IG05]
-						;; size=4 bbWeight=32.54 PerfScore 65.09
+						;; size=4 bbWeight=32.73 PerfScore 65.47
 G_M7615_IG05:
        mov      r9, r10
        cmp      r8d, dword ptr [r9+0x08]
-       jae      SHORT G_M7615_IG13
-       mov      r11d, r8d
-       cmp      dword ptr [r9+4*r11+0x10], ecx
+       jae      SHORT G_M7615_IG12
+       cmp      dword ptr [r9+4*r8+0x10], ecx
        jne      SHORT G_M7615_IG07
-						;; size=19 bbWeight=66.63 PerfScore 566.33
+						;; size=16 bbWeight=67.01 PerfScore 552.85
 G_M7615_IG06:
        mov      r9, gword ptr [rsi+0x18]
        cmp      r8d, dword ptr [r9+0x08]
-       jae      SHORT G_M7615_IG13
-       mov      r11d, r8d
-       movsx    r9, word  ptr [r9+2*r11+0x10]
+       jae      SHORT G_M7615_IG12
+       movsx    r9, word  ptr [r9+2*r8+0x10]
        movsx    r11, dx
        cmp      r11d, r9d
        je       SHORT G_M7615_IG09
-						;; size=28 bbWeight=63.62 PerfScore 747.50
+						;; size=25 bbWeight=63.99 PerfScore 735.87
 G_M7615_IG07:
        inc      r8d
        cmp      r8d, eax
        jle      SHORT G_M7615_IG05
-						;; size=8 bbWeight=66.63 PerfScore 99.94
+						;; size=8 bbWeight=67.01 PerfScore 100.52
 G_M7615_IG08:
-       mov      r10d, -1
-       jmp      SHORT G_M7615_IG10
-						;; size=8 bbWeight=63.62 PerfScore 143.14
+       mov      r8d, -1
+						;; size=6 bbWeight=63.99 PerfScore 16.00
 G_M7615_IG09:
-       mov      r10d, r8d
-						;; size=3 bbWeight=63.62 PerfScore 15.90
-G_M7615_IG10:
-       mov      eax, r10d
+       mov      eax, r8d
        not      eax
        shr      eax, 31
        xor      eax, ebx
@@ -324,11 +319,11 @@ G_M7615_IG10:
        inc      ebp
        cmp      r14d, ebp
        jg       G_M7615_IG03
-						;; size=24 bbWeight=63.62 PerfScore 190.85
-G_M7615_IG11:
+						;; size=24 bbWeight=63.99 PerfScore 191.97
+G_M7615_IG10:
        mov      eax, ebx
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M7615_IG12:
+G_M7615_IG11:
        add      rsp, 32
        pop      rbx
        pop      rbp
@@ -337,18 +332,18 @@ G_M7615_IG12:
        pop      r14
        ret      
 						;; size=11 bbWeight=1 PerfScore 3.75
-G_M7615_IG13:
+G_M7615_IG12:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M7615_IG14:
+G_M7615_IG13:
        mov      rcx, rsi
        mov      rax, qword ptr [rsi]
        mov      rax, qword ptr [rax+0x48]
        call     [rax+0x28]<unknown method>
-       mov      r10d, eax
-       jmp      SHORT G_M7615_IG10
+       mov      r8d, eax
+       jmp      SHORT G_M7615_IG09
 						;; size=18 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 262, prolog size 10, PerfScore 3738.34, instruction count 83, allocated bytes for code 262 (MethodHash=1814e240) for method System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]:Contains_True():ubyte:this (Tier1)
+; Total bytes of code 245, prolog size 10, PerfScore 3567.35, instruction count 79, allocated bytes for code 249 (MethodHash=1814e240) for method System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]:Contains_True():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Perf_Frozen<NotKnownComparable>.Contains_True(Count: 512)``

Hot functions:

- (98.97%) ``System.Collections.Perf_Frozen`1.Contains_True`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable].Contains_True()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 5387
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 8400
 ; 2 inlinees with PGO data; 8 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T20] (  4,   4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]>
-;  V01 loc0         [V01,T14] (  4,1017.07)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T05] (  7,1782.47)     ref  ->  rsi         class-hnd single-def <System.Collections.Frozen.FrozenSet`1[System.Collections.NotKnownComparable]>
-;  V03 loc2         [V03,T18] (  3, 509.53)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
-;  V04 loc3         [V04,T04] (  5,2031.13)     int  ->  rbp        
+;  V00 this         [V00,T21] (  4,   4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]>
+;  V01 loc0         [V01,T15] (  4,1012.59)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T06] (  7,1774.65)     ref  ->  rsi         class-hnd single-def <System.Collections.Frozen.FrozenSet`1[System.Collections.NotKnownComparable]>
+;  V03 loc2         [V03,T19] (  3, 507.30)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
+;* V04 loc3         [V04,T22] (  0,   0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,   0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.NotKnownComparable>
-;  V07 tmp2         [V07,T08] (  4,1522.60)     int  ->  r10         "guarded devirt return temp"
-;  V08 tmp3         [V08,T15] (  2,1015.07)     ref  ->  rax         class-hnd exact "guarded devirt this exact temp" <System.Collections.Frozen.ValueTypeDefaultComparerFrozenSet`1[System.Collections.NotKnownComparable]>
-;  V09 tmp4         [V09,T06] (  3,1543.42)     int  ->  rcx         "Inline stloc first use temp"
-;  V10 tmp5         [V10,T00] ( 10,5179.45)     int  ->   r8         ld-addr-op "Inline ldloca(s) first use temp"
-;  V11 tmp6         [V11,T07] (  3,1543.42)     int  ->  rax         ld-addr-op "Inline ldloca(s) first use temp"
+;  V07 tmp2         [V07,T09] (  4,1515.89)     int  ->   r8         "guarded devirt return temp"
+;  V08 tmp3         [V08,T16] (  2,1010.59)     ref  ->  rax         class-hnd exact "guarded devirt this exact temp" <System.Collections.Frozen.ValueTypeDefaultComparerFrozenSet`1[System.Collections.NotKnownComparable]>
+;  V09 tmp4         [V09,T07] (  3,1536.75)     int  ->  rcx         "Inline stloc first use temp"
+;  V10 tmp5         [V10,T05] (  4,2021.18)     int  ->   r8         ld-addr-op "Inline ldloca(s) first use temp"
+;  V11 tmp6         [V11,T08] (  3,1536.75)     int  ->  rax         ld-addr-op "Inline ldloca(s) first use temp"
 ;* V12 tmp7         [V12    ] (  0,   0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V13 tmp8         [V13    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.NotKnownComparable>
-;  V14 tmp9         [V14,T02] (  3,3045.20)   byref  ->  rax         "Inlining Arg"
-;  V15 tmp10        [V15,T10] (  3,1522.60)     ref  ->   r8         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V16 tmp11        [V16,T11] (  3,1522.60)   byref  ->  rax         "Inline stloc first use temp"
+;  V14 tmp9         [V14,T02] (  3,3031.77)   byref  ->  rax         "Inlining Arg"
+;  V15 tmp10        [V15,T11] (  3,1515.89)     ref  ->   r8         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V16 tmp11        [V16,T12] (  3,1515.89)   byref  ->  rax         "Inline stloc first use temp"
 ;* V17 tmp12        [V17    ] (  0,   0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V18 tmp13        [V18    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V19 tmp14        [V19,T12] (  3,1522.60)     int  ->  r10         "Inline stloc first use temp"
+;  V19 tmp14        [V19,T13] (  3,1515.89)     int  ->  r10         "Inline stloc first use temp"
 ;* V20 tmp15        [V20    ] (  0,   0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V21 tmp16        [V21    ] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V22 tmp17        [V22    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.NotKnownComparable>
 ;* V23 tmp18        [V23    ] (  0,   0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.NotKnownComparable>
-;  V24 tmp19        [V24,T09] (  4,1522.60)   short  ->  rdx         "field V06._value (fldOffset=0x0)" P-INDEP
+;  V24 tmp19        [V24,T10] (  4,1515.89)   short  ->  rdx         "field V06._value (fldOffset=0x0)" P-INDEP
 ;* V25 tmp20        [V25    ] (  0,   0   )   short  ->  zero-ref    "field V13._value (fldOffset=0x0)" P-INDEP
 ;* V26 tmp21        [V26    ] (  0,   0   )   short  ->  zero-ref    "field V22._value (fldOffset=0x0)" P-INDEP
-;  V27 tmp22        [V27,T16] (  2,1015.07)   short  ->   r9         "field V23._value (fldOffset=0x0)" P-INDEP
-;  V28 tmp23        [V28,T01] (  3,3170.14)     ref  ->   r9         "arr expr"
-;  V29 tmp24        [V29,T03] (  3,3045.20)     ref  ->   r9         "arr expr"
-;  V30 cse0         [V30,T17] (  2, 787.22)     ref  ->  r10         hoist "CSE #02: moderate"
-;  V31 cse1         [V31,T19] (  3, 509.53)     int  ->  r14         "CSE #05: moderate"
-;  V32 cse2         [V32,T13] (  3,1522.60)     int  ->  rax         "CSE #01: moderate"
+;  V27 tmp22        [V27,T17] (  2,1010.59)   short  ->   r9         "field V23._value (fldOffset=0x0)" P-INDEP
+;  V28 tmp23        [V28,T01] (  3,3156.99)     ref  ->   r9         "arr expr"
+;  V29 tmp24        [V29,T03] (  3,3031.77)     ref  ->   r9         "arr expr"
+;  V30 cse0         [V30,T18] (  2, 783.92)     ref  ->  r10         hoist "CSE #02: moderate"
+;  V31 cse1         [V31,T20] (  3, 507.30)     int  ->  r14         "CSE #05: moderate"
+;  V32 cse2         [V32,T14] (  3,1515.89)     int  ->  rax         "CSE #01: moderate"
+;  V33 rat0         [V33,T04] (  5,2022.18)    long  ->  rbp         "Widened IV V04"
+;  V34 rat1         [V34,T00] ( 10,5157.30)    long  ->   r8         "Widened IV V10"
 ;
 ; Lcl frame size = 32
 
@@ -252,14 +254,13 @@ G_M7615_IG02:
        xor      ebp, ebp
        mov      r14d, dword ptr [rdi+0x08]
        test     r14d, r14d
-       jle      G_M7615_IG11
+       jle      G_M7615_IG10
 						;; size=25 bbWeight=1 PerfScore 7.75
 G_M7615_IG03:
-       mov      eax, ebp
-       movsx    rdx, word  ptr [rdi+2*rax+0x10]
+       movsx    rdx, word  ptr [rdi+2*rbp+0x10]
        mov      rax, 0xD1FFAB1E      ; System.Collections.Frozen.ValueTypeDefaultComparerFrozenSet`1[System.Collections.NotKnownComparable]
        cmp      qword ptr [rsi], rax
-       jne      G_M7615_IG14
+       jne      G_M7615_IG13
        mov      rax, rsi
        mov      ecx, edx
        add      rax, 32
@@ -273,50 +274,44 @@ G_M7615_IG03:
        imul     r10, r9
        shr      r10, 32
        cmp      r10d, eax
-       jae      G_M7615_IG13
+       jae      SHORT G_M7615_IG12
        mov      eax, r10d
        lea      rax, bword ptr [r8+8*rax+0x10]
        mov      r8d, dword ptr [rax]
        mov      eax, dword ptr [rax+0x04]
        cmp      r8d, eax
        jg       SHORT G_M7615_IG08
-						;; size=97 bbWeight=507.53 PerfScore 15099.11
+						;; size=91 bbWeight=505.30 PerfScore 14906.21
 G_M7615_IG04:
        mov      r10, gword ptr [rsi+0x28]
        align    [0 bytes for IG05]
-						;; size=4 bbWeight=258.87 PerfScore 517.74
+						;; size=4 bbWeight=257.76 PerfScore 515.52
 G_M7615_IG05:
        mov      r9, r10
        cmp      r8d, dword ptr [r9+0x08]
-       jae      SHORT G_M7615_IG13
-       mov      r11d, r8d
-       cmp      dword ptr [r9+4*r11+0x10], ecx
+       jae      SHORT G_M7615_IG12
+       cmp      dword ptr [r9+4*r8+0x10], ecx
        jne      SHORT G_M7615_IG07
-						;; size=19 bbWeight=528.36 PerfScore 4491.03
+						;; size=16 bbWeight=526.16 PerfScore 4340.86
 G_M7615_IG06:
        mov      r9, gword ptr [rsi+0x18]
        cmp      r8d, dword ptr [r9+0x08]
-       jae      SHORT G_M7615_IG13
-       mov      r11d, r8d
-       movsx    r9, word  ptr [r9+2*r11+0x10]
+       jae      SHORT G_M7615_IG12
+       movsx    r9, word  ptr [r9+2*r8+0x10]
        movsx    r11, dx
        cmp      r11d, r9d
        je       SHORT G_M7615_IG09
-						;; size=28 bbWeight=507.53 PerfScore 5963.51
+						;; size=25 bbWeight=505.30 PerfScore 5810.90
 G_M7615_IG07:
        inc      r8d
        cmp      r8d, eax
        jle      SHORT G_M7615_IG05
-						;; size=8 bbWeight=528.36 PerfScore 792.53
+						;; size=8 bbWeight=526.16 PerfScore 789.25
 G_M7615_IG08:
-       mov      r10d, -1
-       jmp      SHORT G_M7615_IG10
-						;; size=8 bbWeight=507.53 PerfScore 1141.95
+       mov      r8d, -1
+						;; size=6 bbWeight=505.30 PerfScore 126.32
 G_M7615_IG09:
-       mov      r10d, r8d
-						;; size=3 bbWeight=507.53 PerfScore 126.88
-G_M7615_IG10:
-       mov      eax, r10d
+       mov      eax, r8d
        not      eax
        shr      eax, 31
        xor      eax, ebx
@@ -324,11 +319,11 @@ G_M7615_IG10:
        inc      ebp
        cmp      r14d, ebp
        jg       G_M7615_IG03
-						;; size=24 bbWeight=507.53 PerfScore 1522.60
-G_M7615_IG11:
+						;; size=24 bbWeight=505.30 PerfScore 1515.89
+G_M7615_IG10:
        mov      eax, ebx
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M7615_IG12:
+G_M7615_IG11:
        add      rsp, 32
        pop      rbx
        pop      rbp
@@ -337,18 +332,18 @@ G_M7615_IG12:
        pop      r14
        ret      
 						;; size=11 bbWeight=1 PerfScore 3.75
-G_M7615_IG13:
+G_M7615_IG12:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M7615_IG14:
+G_M7615_IG13:
        mov      rcx, rsi
        mov      rax, qword ptr [rsi]
        mov      rax, qword ptr [rax+0x48]
        call     [rax+0x28]<unknown method>
-       mov      r10d, eax
-       jmp      SHORT G_M7615_IG10
+       mov      r8d, eax
+       jmp      SHORT G_M7615_IG09
 						;; size=18 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 262, prolog size 10, PerfScore 29672.35, instruction count 83, allocated bytes for code 262 (MethodHash=1814e240) for method System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]:Contains_True():ubyte:this (Tier1)
+; Total bytes of code 245, prolog size 10, PerfScore 28021.94, instruction count 79, allocated bytes for code 249 (MethodHash=1814e240) for method System.Collections.Perf_Frozen`1[System.Collections.NotKnownComparable]:Contains_True():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.All_AllElementsMatch(input: IEnumerable)``

Hot functions:

- (88.92%) ``Enumerable.All`` (Tier-1)
  - **Has diffs**
- (1.58%) ``Perf_Enumerable.All_AllElementsMatch`` (Tier-1)
  - No diffs
- (1.14%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.All(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 56488
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 36032
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T10] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] (  9,300.86)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 loc0         [V02,T00] ( 27,703.05)     ref  ->  [rbp-0x38]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V03 loc1         [V03,T05] (  7,297.86)     int  ->  rdx        
-;  V04 loc2         [V04,T16] (  2,  0   )   ubyte  ->  [rbp-0x2C]  do-not-enreg[Z] EH-live
+;  V00 arg0         [V00,T09] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] (  7,  5.01)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 loc0         [V02,T00] ( 27,713.13)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V03 loc1         [V03,T07] (  6,201.75)     int  ->  rdx        
+;  V04 loc2         [V04,T15] (  2,  0   )   ubyte  ->  [rbp-0x1C]  do-not-enreg[Z] EH-live
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T14] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V06 tmp1         [V06,T13] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V08 tmp3         [V08    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V09 tmp4         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V10 tmp5         [V10,T09] (  4,198.57)     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp5         [V10,T16] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V11 tmp6         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V12 tmp7         [V12,T08] (  2,  2.01)     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp7         [V12,T06] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V13 tmp8         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V14 tmp9         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V15 tmp10        [V15,T04] (  6,299.88)     int  ->  rax         "Inline stloc first use temp"
-;  V16 tmp11        [V16,T01] (  6,595.71)     ref  ->  r15         "arr expr"
-;  V17 tmp12        [V17,T02] (  6,595.71)     int  ->   r8         "index expr"
-;  V18 PSPSym       [V18,T15] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V19 cse0         [V19,T06] (  3,297.85)     int  ->  r14         "CSE #04: aggressive"
-;  V20 cse1         [V20,T07] (  3,294.88)     int  ->   r8         "CSE #03: aggressive"
-;  V21 cse2         [V21,T12] (  3,  3.01)     int  ->  r14         "CSE #07: aggressive"
-;  V22 cse3         [V22,T13] (  3,  2.98)     int  ->   r8         "CSE #05: aggressive"
-;  V23 cse4         [V23,T11] (  7,  4.03)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
+;  V15 tmp10        [V15,T03] (  6,304.61)     int  ->  rdx         "Inline stloc first use temp"
+;  V16 tmp11        [V16,T01] (  6,605.24)     ref  ->  registers   "arr expr"
+;  V17 tmp12        [V17,T02] (  6,605.24)     int  ->   r8         "index expr"
+;  V18 PSPSym       [V18,T14] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V19 cse0         [V19,T04] (  3,302.57)     int  ->  rax         "CSE #04: aggressive"
+;  V20 cse1         [V20,T05] (  3,299.60)     int  ->   r8         "CSE #03: aggressive"
+;  V21 cse2         [V21,T11] (  3,  3.06)     int  ->  rcx         "CSE #07: aggressive"
+;  V22 cse3         [V22,T12] (  3,  3.03)     int  ->   r8         "CSE #05: aggressive"
+;  V23 cse4         [V23,T10] (  7,  4.03)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 56
 
 G_M37232_IG01:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 56
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      rbx, rdx
-						;; size=24 bbWeight=1 PerfScore 8.00
+						;; size=20 bbWeight=1 PerfScore 6.00
 G_M37232_IG02:
        test     rcx, rcx
-       je       G_M37232_IG26
+       je       G_M37232_IG24
        test     rbx, rbx
-       je       G_M37232_IG27
+       je       G_M37232_IG25
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M37232_IG28
+       jne      G_M37232_IG26
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
 						;; size=57 bbWeight=1 PerfScore 12.25
 G_M37232_IG03:
-       mov      gword ptr [rbp-0x38], rsi
+       mov      gword ptr [rbp-0x28], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M37232_IG04:
        test     rsi, rsi
-       je       G_M37232_IG14
+       je       G_M37232_IG13
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
-       jne      G_M37232_IG14
+       jne      G_M37232_IG13
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<All_AllElementsMatch>b__15_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      G_M37232_IG13
        jmp      SHORT G_M37232_IG06
-						;; size=30 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG05]
+						;; size=50 bbWeight=1 PerfScore 11.75
 G_M37232_IG05:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      SHORT G_M37232_IG09
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
+       jae      SHORT G_M37232_IG11
+       mov      rbx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rbx+0x08]
        jae      SHORT G_M37232_IG08
-       mov      edx, r8d
-       mov      edx, dword ptr [r15+4*rdx+0x10]
-       mov      rcx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<All_AllElementsMatch>b__15_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rcx
-       jne      SHORT G_M37232_IG12
+       mov      eax, r8d
+       mov      edx, dword ptr [rbx+4*rax+0x10]
        test     edx, edx
-       jl       SHORT G_M37232_IG11
-						;; size=48 bbWeight=98.29 PerfScore 1941.28
+       jl       SHORT G_M37232_IG12
+						;; size=31 bbWeight=99.87 PerfScore 1547.91
 G_M37232_IG06:
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M37232_IG13
-						;; size=14 bbWeight=99.28 PerfScore 546.06
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rsi+0x0C]
+       cmp      edx, eax
+       jae      SHORT G_M37232_IG14
+						;; size=12 bbWeight=100.86 PerfScore 554.70
 G_M37232_IG07:
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M37232_IG05
-						;; size=5 bbWeight=98.31 PerfScore 294.93
+						;; size=5 bbWeight=99.85 PerfScore 299.56
 G_M37232_IG08:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
 G_M37232_IG09:
-       mov      ecx, dword ptr [rsi+0x08]
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M37232_IG10:
+       mov      rcx, rsi
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       je       G_M37232_IG19
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        mov      edx, eax
-       jmp      SHORT G_M37232_IG18
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M37232_IG11:
-       xor      eax, eax
-       mov      dword ptr [rbp-0x2C], eax
-       jmp      G_M37232_IG30
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M37232_IG12:
+						;; size=42 bbWeight=0 PerfScore 0.00
+G_M37232_IG10:
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
-       je       SHORT G_M37232_IG11
-       jmp      SHORT G_M37232_IG06
-						;; size=13 bbWeight=98.29 PerfScore 810.92
+       je       SHORT G_M37232_IG12
+       jmp      SHORT G_M37232_IG16
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M37232_IG11:
+       mov      ecx, dword ptr [rsi+0x08]
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M37232_IG12:
+       xor      ecx, ecx
+       mov      dword ptr [rbp-0x1C], ecx
+       jmp      G_M37232_IG28
+						;; size=10 bbWeight=0 PerfScore 0.00
 G_M37232_IG13:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M37232_IG21
-						;; size=9 bbWeight=99.28 PerfScore 297.85
-G_M37232_IG14:
        cmp      dword ptr [rsi], esi
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        jmp      SHORT G_M37232_IG16
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M37232_IG14:
+       mov      dword ptr [rsi+0x08], eax
+       jmp      SHORT G_M37232_IG19
+						;; size=5 bbWeight=100.86 PerfScore 302.57
 G_M37232_IG15:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      SHORT G_M37232_IG09
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
+       jae      SHORT G_M37232_IG11
+       mov      rcx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rcx+0x08]
        jae      SHORT G_M37232_IG08
        mov      edx, r8d
-       mov      edx, dword ptr [r15+4*rdx+0x10]
+       mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rcx
-       jne      SHORT G_M37232_IG18
+       jne      SHORT G_M37232_IG10
        test     edx, edx
-       jl       SHORT G_M37232_IG11
-						;; size=48 bbWeight=0.99 PerfScore 19.61
+       jl       SHORT G_M37232_IG12
+						;; size=47 bbWeight=1.01 PerfScore 19.92
 G_M37232_IG16:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M37232_IG20
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M37232_IG19
-						;; size=19 bbWeight=1.00 PerfScore 9.53
+       jne      G_M37232_IG09
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M37232_IG18
+						;; size=21 bbWeight=1.02 PerfScore 9.68
 G_M37232_IG17:
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M37232_IG15
-						;; size=5 bbWeight=0.99 PerfScore 2.98
+						;; size=5 bbWeight=1.01 PerfScore 3.03
 G_M37232_IG18:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       je       G_M37232_IG11
-       jmp      SHORT G_M37232_IG16
-						;; size=17 bbWeight=0.99 PerfScore 8.19
+       mov      dword ptr [rsi+0x08], ecx
+						;; size=3 bbWeight=1.02 PerfScore 1.02
 G_M37232_IG19:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      SHORT G_M37232_IG21
-						;; size=6 bbWeight=1.00 PerfScore 3.01
-G_M37232_IG20:
-       mov      rcx, rsi
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M37232_IG10
-						;; size=24 bbWeight=1.00 PerfScore 4.76
-G_M37232_IG21:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M37232_IG29
-						;; size=5 bbWeight=1 PerfScore 4.00
-G_M37232_IG22:
+       jne      SHORT G_M37232_IG27
+						;; size=5 bbWeight=1.01 PerfScore 4.04
+G_M37232_IG20:
        mov      eax, 1
 						;; size=5 bbWeight=1 PerfScore 0.25
+G_M37232_IG21:
+       add      rsp, 56
+       pop      rbx
+       pop      rsi
+       pop      rdi
+       pop      rbp
+       ret      
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M37232_IG22:
+       mov      eax, dword ptr [rbp-0x1C]
+						;; size=3 bbWeight=0 PerfScore 0.00
 G_M37232_IG23:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
+						;; size=9 bbWeight=0 PerfScore 0.00
 G_M37232_IG24:
-       mov      eax, dword ptr [rbp-0x2C]
-						;; size=3 bbWeight=0 PerfScore 0.00
-G_M37232_IG25:
-       add      rsp, 56
-       pop      rbx
-       pop      rsi
-       pop      rdi
-       pop      r14
-       pop      r15
-       pop      rbp
-       ret      
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M37232_IG26:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M37232_IG27:
+G_M37232_IG25:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M37232_IG28:
+G_M37232_IG26:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M37232_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M37232_IG29:
+G_M37232_IG27:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M37232_IG22
+       jmp      SHORT G_M37232_IG20
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M37232_IG30:
+G_M37232_IG28:
        mov      rcx, rsp
-       call     G_M37232_IG32
+       call     G_M37232_IG30
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M37232_IG31:
-       jmp      SHORT G_M37232_IG24
+G_M37232_IG29:
+       jmp      SHORT G_M37232_IG22
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M37232_IG32:
+G_M37232_IG30:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=25 bbWeight=0.01 PerfScore 0.10
-G_M37232_IG33:
-       cmp      gword ptr [rbp-0x38], 0
-       je       SHORT G_M37232_IG36
-						;; size=7 bbWeight=0.01 PerfScore 0.03
-G_M37232_IG34:
+       lea      rbp, [rbp+0x50]
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M37232_IG31:
+       cmp      gword ptr [rbp-0x28], 0
+       je       SHORT G_M37232_IG32
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rsi, gword ptr [rbp-0x38]
+       mov      rsi, gword ptr [rbp-0x28]
        cmp      qword ptr [rsi], rdi
-       je       SHORT G_M37232_IG36
-						;; size=19 bbWeight=0.01 PerfScore 0.06
-G_M37232_IG35:
+       je       SHORT G_M37232_IG32
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-						;; size=16 bbWeight=0 PerfScore 0.00
-G_M37232_IG36:
+						;; size=42 bbWeight=0 PerfScore 0.00
+G_M37232_IG32:
        nop      
-						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M37232_IG37:
+						;; size=1 bbWeight=0 PerfScore 0.00
+G_M37232_IG33:
        add      rsp, 40
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0.01 PerfScore 0.05
+						;; size=9 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 575, prolog size 24, PerfScore 3976.65, instruction count 169, allocated bytes for code 575 (MethodHash=68ff6e8f) for method System.Linq.Enumerable:All[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte]):ubyte (Tier1)
+; Total bytes of code 531, prolog size 20, PerfScore 2776.92, instruction count 153, allocated bytes for code 531 (MethodHash=68ff6e8f) for method System.Linq.Enumerable:All[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte]):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.SingleWithPredicate_FirstElementMatches(input: Array)``

Hot functions:

- (90.49%) ``Enumerable.TryGetSingle`` (Tier-1)
  - **Has diffs**
- (2.02%) ``Perf_Enumerable.SingleWithPredicate_FirstElementMatches`` (Tier-1)
  - No diffs
- (1.25%) ``SZArrayHelper.GetEnumerator`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetSingle(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 57944
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 56144
 ; 4 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T13] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T04] ( 15,301.83)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T14] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 45,707.36)     ref  ->  [rbp-0x30]  class-hnd EH-live spill-single-def <<unknown class>>
-;  V04 loc1         [V04,T15] (  8,  4   )     int  ->  r15        
+;  V00 arg0         [V00,T11] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] ( 11,  6.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T13] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 45,707.56)     ref  ->  [rbp-0x20]  class-hnd EH-live spill-single-def <<unknown class>>
+;  V04 loc1         [V04,T14] (  7,  3   )     int  ->  rdi        
 ;* V05 loc2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc3         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T01] (  7,591.67)     int  ->  rdx         "spilling ret_expr"
+;  V08 tmp1         [V08,T03] (  6,395.71)     int  ->  rdx         "spilling ret_expr"
 ;* V09 tmp2         [V09    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V10 tmp3         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V11 tmp4         [V11,T22] (  4,  2   )     int  ->  rax         "guarded devirt return temp"
+;  V11 tmp4         [V11,T24] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V12 tmp5         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
 ;* V13 tmp6         [V13    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V14 tmp7         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V15 tmp8         [V15,T09] (  4,197.22)     int  ->  rax         "guarded devirt return temp"
+;  V15 tmp8         [V15,T25] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V16 tmp9         [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V17 tmp10        [V17,T08] (  2,  1.99)     int  ->  rax         "guarded devirt return temp"
+;  V17 tmp10        [V17,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp11        [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V19 tmp12        [V19,T21] (  2,  0.02)     int  ->  rax         "guarded devirt return temp"
+;  V19 tmp12        [V19,T20] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V20 tmp13        [V20    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V21 tmp14        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V22 tmp15        [V22,T05] (  6,297.84)     int  ->  rax         "Inline stloc first use temp"
+;  V22 tmp15        [V22,T04] (  6,298.79)     int  ->  rdx         "Inline stloc first use temp"
 ;  V23 tmp16        [V23,T16] (  6,  2.99)     int  ->  rax         "Inline stloc first use temp"
-;  V24 tmp17        [V24,T11] (  6,  6   )     ref  ->  r14         "arr expr"
-;  V25 tmp18        [V25,T12] (  6,  6   )     int  ->   r8         "index expr"
-;  V26 tmp19        [V26,T02] (  6,591.67)     ref  ->  r14         "arr expr"
-;  V27 tmp20        [V27,T03] (  6,591.67)     int  ->   r8         "index expr"
-;  V28 PSPSym       [V28,T23] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V29 cse0         [V29,T06] (  3,295.84)     int  ->  rdi         "CSE #09: aggressive"
-;  V30 cse1         [V30,T07] (  3,292.90)     int  ->   r8         "CSE #08: aggressive"
-;  V31 cse2         [V31,T17] (  3,  2.99)     int  ->  rdi         "CSE #11: moderate"
-;  V32 cse3         [V32,T18] (  3,  2.97)     int  ->   r8         "CSE #03: moderate"
-;  V33 cse4         [V33,T19] (  3,  2.97)     int  ->  rdi         "CSE #04: moderate"
-;  V34 cse5         [V34,T20] (  3,  2.96)     int  ->   r8         "CSE #10: moderate"
-;  V35 cse6         [V35,T24] (  3,  0.03)     int  ->   r8         "CSE #05: conservative"
-;  V36 cse7         [V36,T25] (  3,  0.03)     int  ->  rdi         "CSE #07: conservative"
-;  V37 cse8         [V37,T10] (  9,  6.06)    long  ->  rsi         multi-def "CSE #02: aggressive"
+;  V24 tmp17        [V24,T09] (  6,  6   )     ref  ->  r10         "arr expr"
+;  V25 tmp18        [V25,T10] (  6,  6   )     int  ->   r8         "index expr"
+;  V26 tmp19        [V26,T01] (  6,593.56)     ref  ->  r10         "arr expr"
+;  V27 tmp20        [V27,T02] (  6,593.56)     int  ->  registers   "index expr"
+;  V28 PSPSym       [V28,T21] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V29 cse0         [V29,T05] (  3,296.78)     int  ->  rax         "CSE #09: aggressive"
+;  V30 cse1         [V30,T06] (  3,293.83)     int  ->   r8         "CSE #08: aggressive"
+;  V31 cse2         [V31,T15] (  3,  3.00)     int  ->  rax         "CSE #11: moderate"
+;  V32 cse3         [V32,T17] (  3,  2.97)     int  ->   r8         "CSE #03: moderate"
+;  V33 cse4         [V33,T18] (  3,  2.97)     int  ->  rdx         "CSE #04: moderate"
+;  V34 cse5         [V34,T19] (  3,  2.97)     int  ->  rax         "CSE #10: moderate"
+;  V35 cse6         [V35,T22] (  3,  0.03)     int  ->   r8         "CSE #05: conservative"
+;  V36 cse7         [V36,T23] (  3,  0.03)     int  ->  rdx         "CSE #07: conservative"
+;  V37 cse8         [V37,T12] (  9,  5.07)    long  ->  rsi         multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 56
 
 G_M59240_IG01:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 56
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      bword ptr [rbp+0x20], r8
        mov      rbx, rdx
-						;; size=28 bbWeight=1 PerfScore 9.00
+						;; size=24 bbWeight=1 PerfScore 7.00
 G_M59240_IG02:
        test     rcx, rcx
-       je       G_M59240_IG39
+       je       G_M59240_IG38
        test     rbx, rbx
-       je       G_M59240_IG40
+       je       G_M59240_IG39
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, rax
-       mov      gword ptr [rbp-0x30], rcx
+       mov      gword ptr [rbp-0x20], rcx
 						;; size=38 bbWeight=1 PerfScore 7.00
 G_M59240_IG03:
        test     rcx, rcx
-       je       G_M59240_IG25
+       je       G_M59240_IG17
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], rsi
-       jne      G_M59240_IG25
+       jne      G_M59240_IG17
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      G_M59240_IG17
        jmp      G_M59240_IG11
-						;; size=33 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG06]
+						;; size=53 bbWeight=1 PerfScore 11.75
 G_M59240_IG04:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M59240_IG32
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M59240_IG09
+       jae      G_M59240_IG26
+       mov      r10, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [r10+0x08]
+       jae      SHORT G_M59240_IG10
        mov      edx, r8d
-       mov      r15d, dword ptr [r14+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG10
-       test     r15d, r15d
+       mov      edi, dword ptr [r10+4*rdx+0x10]
+       test     edi, edi
        jg       SHORT G_M59240_IG11
-						;; size=53 bbWeight=0.99 PerfScore 19.55
+						;; size=36 bbWeight=0.99 PerfScore 15.35
 G_M59240_IG05:
-       mov      rcx, gword ptr [rbp-0x30]
        cmp      qword ptr [rcx], rsi
-       jne      G_M59240_IG17
-						;; size=13 bbWeight=2 PerfScore 10.00
-G_M59240_IG06:
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
-       jae      SHORT G_M59240_IG13
-						;; size=12 bbWeight=98.61 PerfScore 542.38
-G_M59240_IG07:
-       mov      dword ptr [rcx+0x08], eax
-       mov      r8d, dword ptr [rcx+0x08]
-       cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M59240_IG30
-						;; size=17 bbWeight=97.64 PerfScore 683.45
-G_M59240_IG08:
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M59240_IG09
-       mov      edx, r8d
-       mov      edx, dword ptr [r14+4*rdx+0x10]
+       jne      G_M59240_IG19
        mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
        cmp      qword ptr [rbx+0x18], rax
-       jne      SHORT G_M59240_IG15
+       jne      G_M59240_IG19
+						;; size=29 bbWeight=1 PerfScore 8.25
+G_M59240_IG06:
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
+       jae      SHORT G_M59240_IG13
+						;; size=12 bbWeight=98.93 PerfScore 544.10
+G_M59240_IG07:
+       mov      dword ptr [rcx+0x08], edx
+       mov      r8d, dword ptr [rcx+0x08]
+       cmp      r8d, dword ptr [rcx+0x0C]
+       jae      G_M59240_IG31
+						;; size=17 bbWeight=97.94 PerfScore 685.61
+G_M59240_IG08:
+       mov      r10, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [r10+0x08]
+       jae      SHORT G_M59240_IG10
+       mov      eax, r8d
+       mov      edx, dword ptr [r10+4*rax+0x10]
        test     edx, edx
-       jle      G_M59240_IG33
-       mov      rcx, gword ptr [rbp-0x30]
+       jle      G_M59240_IG32
        jmp      SHORT G_M59240_IG06
-						;; size=48 bbWeight=97.62 PerfScore 1635.22
+						;; size=28 bbWeight=97.94 PerfScore 1126.29
 G_M59240_IG09:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M59240_IG10:
-       mov      edx, r15d
+       mov      edx, edi
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
+       mov      rcx, gword ptr [rbp-0x20]
        jne      SHORT G_M59240_IG05
-						;; size=14 bbWeight=0.99 PerfScore 6.43
+       jmp      SHORT G_M59240_IG17
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M59240_IG10:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M59240_IG11:
-       mov      rcx, gword ptr [rbp-0x30]
        mov      eax, dword ptr [rcx+0x08]
        inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
-       jae      G_M59240_IG22
-						;; size=20 bbWeight=0.99 PerfScore 6.43
+       mov      edx, dword ptr [rcx+0x0C]
+       cmp      eax, edx
+       jae      SHORT G_M59240_IG15
+						;; size=12 bbWeight=0.99 PerfScore 5.44
 G_M59240_IG12:
        mov      dword ptr [rcx+0x08], eax
        jmp      G_M59240_IG04
 						;; size=8 bbWeight=0.98 PerfScore 2.94
 G_M59240_IG13:
-       mov      dword ptr [rcx+0x08], edi
-						;; size=3 bbWeight=98.61 PerfScore 98.61
+       mov      dword ptr [rcx+0x08], eax
+						;; size=3 bbWeight=98.93 PerfScore 98.93
 G_M59240_IG14:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 1
-       jmp      G_M59240_IG36
+       jmp      G_M59240_IG35
 						;; size=13 bbWeight=1 PerfScore 4.00
 G_M59240_IG15:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG33
-       mov      rcx, gword ptr [rbp-0x30]
-       jmp      G_M59240_IG06
-						;; size=24 bbWeight=97.62 PerfScore 903.03
+       mov      dword ptr [rcx+0x08], edx
+       jmp      G_M59240_IG33
+						;; size=8 bbWeight=0.99 PerfScore 2.97
 G_M59240_IG16:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M59240_IG30
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M59240_IG09
+       jae      G_M59240_IG26
+       mov      r10, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [r10+0x08]
+       jae      SHORT G_M59240_IG10
        mov      edx, r8d
-       mov      edx, dword ptr [r14+4*rdx+0x10]
+       mov      edi, dword ptr [r10+4*rdx+0x10]
        mov      rax, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rax
-       jne      SHORT G_M59240_IG19
-       test     edx, edx
-       jle      G_M59240_IG33
-						;; size=56 bbWeight=0.99 PerfScore 19.48
+       jne      SHORT G_M59240_IG09
+       test     edi, edi
+       jle      G_M59240_IG05
+						;; size=56 bbWeight=0.01 PerfScore 0.20
 G_M59240_IG17:
-       mov      rcx, gword ptr [rbp-0x30]
+       mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M59240_IG21
+       jne      SHORT G_M59240_IG22
        mov      eax, dword ptr [rcx+0x08]
        inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
-       jae      SHORT G_M59240_IG20
-						;; size=21 bbWeight=1.00 PerfScore 10.46
+       mov      edx, dword ptr [rcx+0x0C]
+       cmp      eax, edx
+       jae      SHORT G_M59240_IG21
+						;; size=27 bbWeight=0.01 PerfScore 0.10
 G_M59240_IG18:
        mov      dword ptr [rcx+0x08], eax
        jmp      SHORT G_M59240_IG16
-						;; size=5 bbWeight=0.99 PerfScore 2.96
+						;; size=5 bbWeight=0.01 PerfScore 0.03
 G_M59240_IG19:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG33
-       jmp      SHORT G_M59240_IG17
-						;; size=17 bbWeight=0.99 PerfScore 8.14
-G_M59240_IG20:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      G_M59240_IG14
-						;; size=8 bbWeight=1.00 PerfScore 2.99
-G_M59240_IG21:
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG31
-       mov      rcx, gword ptr [rbp-0x30]
-       jmp      G_M59240_IG14
-						;; size=30 bbWeight=1.00 PerfScore 7.47
-G_M59240_IG22:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      G_M59240_IG34
-						;; size=8 bbWeight=0.99 PerfScore 2.97
-G_M59240_IG23:
-       mov      r8d, dword ptr [rcx+0x08]
-       cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M59240_IG32
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      G_M59240_IG09
-       mov      edx, r8d
-       mov      r15d, dword ptr [r14+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG24
-       test     r15d, r15d
-       mov      rcx, gword ptr [rbp-0x30]
-       jg       SHORT G_M59240_IG25
-       jmp      G_M59240_IG05
-						;; size=66 bbWeight=0.01 PerfScore 0.23
-G_M59240_IG24:
-       mov      edx, r15d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG05
-						;; size=18 bbWeight=0.01 PerfScore 0.07
-G_M59240_IG25:
-       mov      rcx, gword ptr [rbp-0x30]
-       mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M59240_IG28
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
-       jae      SHORT G_M59240_IG27
-						;; size=31 bbWeight=0.01 PerfScore 0.11
-G_M59240_IG26:
-       mov      dword ptr [rcx+0x08], eax
-       jmp      SHORT G_M59240_IG23
-						;; size=5 bbWeight=0.01 PerfScore 0.03
-G_M59240_IG27:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      SHORT G_M59240_IG34
-						;; size=5 bbWeight=0.01 PerfScore 0.03
-G_M59240_IG28:
+       jne      G_M59240_IG30
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
+       jae      G_M59240_IG29
+						;; size=25 bbWeight=1.00 PerfScore 9.49
+G_M59240_IG20:
+       jmp      G_M59240_IG28
+						;; size=5 bbWeight=0.99 PerfScore 1.98
+G_M59240_IG21:
+       mov      dword ptr [rcx+0x08], edx
+       jmp      G_M59240_IG33
+						;; size=8 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG22:
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M59240_IG34
-						;; size=17 bbWeight=0.01 PerfScore 0.05
-G_M59240_IG29:
-       mov      rcx, gword ptr [rbp-0x30]
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       mov      r15d, eax
-       jmp      SHORT G_M59240_IG24
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M59240_IG30:
-       mov      ecx, dword ptr [rcx+0x08]
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG31:
-       mov      rcx, gword ptr [rbp-0x30]
+       jne      SHORT G_M59240_IG25
+       mov      rcx, gword ptr [rbp-0x20]
+       jmp      G_M59240_IG33
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M59240_IG23:
+       mov      rcx, gword ptr [rbp-0x20]
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        mov      edx, eax
-       jmp      G_M59240_IG19
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M59240_IG24:
+       mov      rcx, gword ptr [rbx+0x08]
+       call     [rbx+0x18]<unknown method>
+       test     eax, eax
+       jne      G_M59240_IG32
+       mov      rcx, gword ptr [rbp-0x20]
+       jmp      SHORT G_M59240_IG19
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M59240_IG25:
+       mov      rcx, gword ptr [rbp-0x20]
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      edi, eax
+       jmp      G_M59240_IG09
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M59240_IG32:
+G_M59240_IG26:
        mov      ecx, dword ptr [rcx+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG33:
+G_M59240_IG27:
+       mov      eax, dword ptr [rcx+0x08]
+       cmp      eax, dword ptr [rcx+0x0C]
+       jae      SHORT G_M59240_IG31
+       mov      r10, gword ptr [rcx+0x10]
+       cmp      eax, dword ptr [r10+0x08]
+       jae      G_M59240_IG10
+       mov      edx, dword ptr [r10+4*rax+0x10]
+       mov      rax, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M59240_IG24
+       test     edx, edx
+       jle      SHORT G_M59240_IG32
+       mov      rcx, gword ptr [rbp-0x20]
+       jmp      G_M59240_IG19
+						;; size=56 bbWeight=0.99 PerfScore 22.26
+G_M59240_IG28:
+       mov      dword ptr [rcx+0x08], edx
+       jmp      SHORT G_M59240_IG27
+						;; size=5 bbWeight=0.99 PerfScore 2.97
+G_M59240_IG29:
+       mov      dword ptr [rcx+0x08], eax
+       jmp      G_M59240_IG14
+						;; size=8 bbWeight=1.00 PerfScore 3.00
+G_M59240_IG30:
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      G_M59240_IG23
+       mov      rcx, gword ptr [rbp-0x20]
+       jmp      G_M59240_IG14
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M59240_IG31:
+       mov      ecx, dword ptr [rcx+0x08]
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M59240_IG32:
        call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M59240_IG34:
-       mov      rcx, gword ptr [rbp-0x30]
+G_M59240_IG33:
        mov      rcx, rsp
-       call     G_M59240_IG44
-						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG35:
-       jmp      SHORT G_M59240_IG42
+       call     G_M59240_IG43
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M59240_IG34:
+       jmp      SHORT G_M59240_IG41
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M59240_IG36:
+G_M59240_IG35:
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M59240_IG41
-						;; size=5 bbWeight=1.01 PerfScore 4.02
+       jne      SHORT G_M59240_IG40
+						;; size=5 bbWeight=1.00 PerfScore 4.00
+G_M59240_IG36:
+       mov      eax, edi
+						;; size=2 bbWeight=1 PerfScore 0.25
 G_M59240_IG37:
-       mov      eax, r15d
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59240_IG38:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M59240_IG39:
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M59240_IG38:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG40:
+G_M59240_IG39:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG41:
+G_M59240_IG40:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M59240_IG37
+       jmp      SHORT G_M59240_IG36
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M59240_IG42:
+G_M59240_IG41:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG43:
+G_M59240_IG42:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M59240_IG44:
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M59240_IG43:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=25 bbWeight=0.02 PerfScore 0.20
+       lea      rbp, [rbp+0x50]
+						;; size=21 bbWeight=0.02 PerfScore 0.19
+G_M59240_IG44:
+       cmp      gword ptr [rbp-0x20], 0
+       je       SHORT G_M59240_IG47
+						;; size=7 bbWeight=0.02 PerfScore 0.07
 G_M59240_IG45:
-       cmp      gword ptr [rbp-0x30], 0
-       je       SHORT G_M59240_IG48
-						;; size=7 bbWeight=0.02 PerfScore 0.06
-G_M59240_IG46:
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rcx, gword ptr [rbp-0x30]
+       mov      rcx, gword ptr [rbp-0x20]
        cmp      qword ptr [rcx], rsi
-       je       SHORT G_M59240_IG48
-						;; size=19 bbWeight=0.02 PerfScore 0.11
-G_M59240_IG47:
+       je       SHORT G_M59240_IG47
+						;; size=19 bbWeight=0.02 PerfScore 0.13
+G_M59240_IG46:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M59240_IG48:
+G_M59240_IG47:
        nop      
 						;; size=1 bbWeight=0.02 PerfScore 0.01
-G_M59240_IG49:
+G_M59240_IG48:
        add      rsp, 40
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0.02 PerfScore 0.09
+						;; size=9 bbWeight=0.02 PerfScore 0.08
 
-; Total bytes of code 864, prolog size 28, PerfScore 3999.51, instruction count 241, allocated bytes for code 864 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 801, prolog size 24, PerfScore 2567.66, instruction count 219, allocated bytes for code 801 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.FirstWithPredicate_LastElementMatches(input: Array)``

Hot functions:

- (90.85%) ``Enumerable.TryGetFirst`` (Tier-1)
  - **Has diffs**
- (1.12%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetFirst(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 59664
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 58024
 ; 2 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T10] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] (  9,303.76)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T11] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 27,706.80)     ref  ->  [rbp-0x30]  class-hnd EH-live spill-single-def <<unknown class>>
-;  V04 loc1         [V04,T04] (  8,301.76)     int  ->  r15        
+;  V00 arg0         [V00,T09] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] (  7,  5.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T10] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 27,707.02)     ref  ->  [rbp-0x20]  class-hnd EH-live spill-single-def <<unknown class>>
+;  V04 loc1         [V04,T06] (  7,201.86)     int  ->  rdi        
 ;* V05 loc2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc3         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V08 tmp1         [V08    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V09 tmp2         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V10 tmp3         [V10,T09] (  4,200.50)     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp3         [V10,T15] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V11 tmp4         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V12 tmp5         [V12,T08] (  2,  2.01)     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp5         [V12,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V13 tmp6         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V14 tmp7         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V15 tmp8         [V15,T05] (  6,300.76)     int  ->  rax         "Inline stloc first use temp"
-;  V16 tmp9         [V16,T01] (  6,601.51)     ref  ->  r14         "arr expr"
-;  V17 tmp10        [V17,T02] (  6,601.51)     int  ->   r8         "index expr"
-;  V18 PSPSym       [V18,T15] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V19 cse0         [V19,T06] (  3,297.75)     int  ->   r8         "CSE #03: aggressive"
-;  V20 cse1         [V20,T07] (  3,297.75)     int  ->  rdi         "CSE #04: aggressive"
-;  V21 cse2         [V21,T13] (  3,  3.01)     int  ->   r8         "CSE #05: aggressive"
-;  V22 cse3         [V22,T14] (  3,  3.01)     int  ->  rdi         "CSE #07: aggressive"
-;  V23 cse4         [V23,T12] (  7,  4.03)    long  ->  rsi         hoist multi-def "CSE #02: aggressive"
+;  V15 tmp8         [V15,T03] (  6,301.28)     int  ->  rdx         "Inline stloc first use temp"
+;  V16 tmp9         [V16,T01] (  6,602.57)     ref  ->  registers   "arr expr"
+;  V17 tmp10        [V17,T02] (  6,602.57)     int  ->   r8         "index expr"
+;  V18 PSPSym       [V18,T14] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V19 cse0         [V19,T04] (  3,298.27)     int  ->   r8         "CSE #03: aggressive"
+;  V20 cse1         [V20,T05] (  3,298.27)     int  ->  rax         "CSE #04: aggressive"
+;  V21 cse2         [V21,T12] (  3,  3.01)     int  ->   r8         "CSE #05: aggressive"
+;  V22 cse3         [V22,T13] (  3,  3.01)     int  ->  rax         "CSE #07: aggressive"
+;  V23 cse4         [V23,T11] (  7,  4.02)    long  ->  rsi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 56
 
 G_M28232_IG01:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 56
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      bword ptr [rbp+0x20], r8
        mov      rbx, rdx
-						;; size=28 bbWeight=1 PerfScore 9.00
+						;; size=24 bbWeight=1 PerfScore 7.00
 G_M28232_IG02:
        test     rcx, rcx
-       je       G_M28232_IG24
+       je       G_M28232_IG21
        test     rbx, rbx
-       je       G_M28232_IG25
+       je       G_M28232_IG22
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, rax
-       mov      gword ptr [rbp-0x30], rcx
+       mov      gword ptr [rbp-0x20], rcx
 						;; size=38 bbWeight=1 PerfScore 7.00
 G_M28232_IG03:
        test     rcx, rcx
        je       G_M28232_IG10
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], rsi
+       jne      SHORT G_M28232_IG10
+		  ;; NOP compensation instructions of 4 bytes.
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<FirstWithPredicate_LastElementMatches>b__10_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
        jne      SHORT G_M28232_IG10
        jmp      SHORT G_M28232_IG08
-						;; size=26 bbWeight=1 PerfScore 7.50
+       align    [4 bytes for IG04]
+						;; size=50 bbWeight=1 PerfScore 11.75
 G_M28232_IG04:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M28232_IG18
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M28232_IG06
-       mov      edx, r8d
-       mov      r15d, dword ptr [r14+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<FirstWithPredicate_LastElementMatches>b__10_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M28232_IG07
-       cmp      r15d, 99
+       jae      G_M28232_IG15
+       mov      rbx, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [rbx+0x08]
+       jae      SHORT G_M28232_IG07
+       mov      eax, r8d
+       mov      edi, dword ptr [rbx+4*rax+0x10]
+       cmp      edi, 99
        jl       SHORT G_M28232_IG08
-						;; size=54 bbWeight=99.25 PerfScore 1960.18
+						;; size=36 bbWeight=99.42 PerfScore 1541.07
 G_M28232_IG05:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 1
-       jmp      G_M28232_IG21
+       jmp      G_M28232_IG18
 						;; size=13 bbWeight=1 PerfScore 4.00
 G_M28232_IG06:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M28232_IG07:
-       mov      edx, r15d
+       mov      edx, edi
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
+       mov      rcx, gword ptr [rbp-0x20]
        jne      SHORT G_M28232_IG05
-						;; size=14 bbWeight=99.25 PerfScore 645.12
+       jmp      SHORT G_M28232_IG12
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M28232_IG07:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M28232_IG08:
-       mov      rcx, gword ptr [rbp-0x30]
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M28232_IG09
-       mov      dword ptr [rcx+0x08], eax
+       mov      dword ptr [rcx+0x08], edx
        jmp      SHORT G_M28232_IG04
-						;; size=21 bbWeight=99.25 PerfScore 942.87
+						;; size=17 bbWeight=99.42 PerfScore 845.10
 G_M28232_IG09:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      G_M28232_IG19
-						;; size=8 bbWeight=99.25 PerfScore 297.75
+       mov      dword ptr [rcx+0x08], eax
+       jmp      G_M28232_IG16
+						;; size=8 bbWeight=99.42 PerfScore 298.27
 G_M28232_IG10:
        cmp      dword ptr [rcx], ecx
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M28232_IG14
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M28232_IG12
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M28232_IG11:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M28232_IG18
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M28232_IG06
+       jae      SHORT G_M28232_IG15
+       mov      rax, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [rax+0x08]
+       jae      SHORT G_M28232_IG07
        mov      edx, r8d
-       mov      r15d, dword ptr [r14+4*rdx+0x10]
+       mov      edi, dword ptr [rax+4*rdx+0x10]
        mov      rdx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M28232_IG13
-       cmp      r15d, 99
-       mov      rcx, gword ptr [rbp-0x30]
-       jl       SHORT G_M28232_IG14
-						;; size=58 bbWeight=1.00 PerfScore 20.80
+       jne      SHORT G_M28232_IG06
+       cmp      edi, 99
+       jge      SHORT G_M28232_IG05
+						;; size=48 bbWeight=1.00 PerfScore 19.83
 G_M28232_IG12:
-       jmp      G_M28232_IG05
-						;; size=5 bbWeight=1 PerfScore 2.00
-G_M28232_IG13:
-       mov      edx, r15d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M28232_IG05
-						;; size=18 bbWeight=1.00 PerfScore 6.52
-G_M28232_IG14:
-       mov      rcx, gword ptr [rbp-0x30]
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M28232_IG16
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
-       jae      SHORT G_M28232_IG15
-       mov      dword ptr [rcx+0x08], eax
+       jne      SHORT G_M28232_IG14
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
+       jae      SHORT G_M28232_IG13
+       mov      dword ptr [rcx+0x08], edx
        jmp      SHORT G_M28232_IG11
-						;; size=26 bbWeight=1.00 PerfScore 13.53
-G_M28232_IG15:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      SHORT G_M28232_IG19
+						;; size=22 bbWeight=1.00 PerfScore 12.55
+G_M28232_IG13:
+       mov      dword ptr [rcx+0x08], eax
+       jmp      SHORT G_M28232_IG16
 						;; size=5 bbWeight=1.00 PerfScore 3.01
-G_M28232_IG16:
+G_M28232_IG14:
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M28232_IG19
-						;; size=17 bbWeight=1.00 PerfScore 4.51
-G_M28232_IG17:
-       mov      rcx, gword ptr [rbp-0x30]
+       je       SHORT G_M28232_IG16
+       mov      rcx, gword ptr [rbp-0x20]
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-       mov      r15d, eax
-       jmp      SHORT G_M28232_IG13
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M28232_IG18:
+       mov      edi, eax
+       jmp      G_M28232_IG06
+						;; size=41 bbWeight=0 PerfScore 0.00
+G_M28232_IG15:
        mov      ecx, dword ptr [rcx+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M28232_IG19:
-       mov      rcx, gword ptr [rbp-0x30]
+G_M28232_IG16:
+       mov      rcx, gword ptr [rbp-0x20]
        mov      rcx, rsp
-       call     G_M28232_IG29
+       call     G_M28232_IG26
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M28232_IG20:
-       jmp      SHORT G_M28232_IG27
+G_M28232_IG17:
+       jmp      SHORT G_M28232_IG24
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M28232_IG21:
-       mov      rcx, gword ptr [rbp-0x30]
+G_M28232_IG18:
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M28232_IG26
-						;; size=9 bbWeight=1 PerfScore 5.00
-G_M28232_IG22:
-       mov      eax, r15d
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M28232_IG23:
+       jne      SHORT G_M28232_IG23
+						;; size=5 bbWeight=1 PerfScore 4.00
+G_M28232_IG19:
+       mov      eax, edi
+						;; size=2 bbWeight=1 PerfScore 0.25
+G_M28232_IG20:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M28232_IG24:
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M28232_IG21:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M28232_IG25:
+G_M28232_IG22:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M28232_IG26:
+G_M28232_IG23:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M28232_IG22
+       jmp      SHORT G_M28232_IG19
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M28232_IG27:
+G_M28232_IG24:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M28232_IG28:
+G_M28232_IG25:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M28232_IG29:
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M28232_IG26:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=25 bbWeight=0.01 PerfScore 0.08
-G_M28232_IG30:
-       cmp      gword ptr [rbp-0x30], 0
-       je       SHORT G_M28232_IG33
-						;; size=7 bbWeight=0.01 PerfScore 0.03
-G_M28232_IG31:
+       lea      rbp, [rbp+0x50]
+						;; size=21 bbWeight=0.01 PerfScore 0.06
+G_M28232_IG27:
+       cmp      gword ptr [rbp-0x20], 0
+       je       SHORT G_M28232_IG30
+						;; size=7 bbWeight=0.01 PerfScore 0.02
+G_M28232_IG28:
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rcx, gword ptr [rbp-0x30]
+       mov      rcx, gword ptr [rbp-0x20]
        cmp      qword ptr [rcx], rsi
-       je       SHORT G_M28232_IG33
-						;; size=19 bbWeight=0.01 PerfScore 0.05
-G_M28232_IG32:
-       mov      rcx, gword ptr [rbp-0x30]
+       je       SHORT G_M28232_IG30
+						;; size=19 bbWeight=0.01 PerfScore 0.04
+G_M28232_IG29:
+       mov      rcx, gword ptr [rbp-0x20]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M28232_IG33:
+G_M28232_IG30:
        nop      
 						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M28232_IG34:
+G_M28232_IG31:
        add      rsp, 40
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0.01 PerfScore 0.04
+						;; size=9 bbWeight=0.01 PerfScore 0.02
 
-; Total bytes of code 565, prolog size 28, PerfScore 3933.55, instruction count 168, allocated bytes for code 565 (MethodHash=5d8091b7) for method System.Linq.Enumerable:TryGetFirst[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 512, prolog size 24, PerfScore 2757.23, instruction count 151, allocated bytes for code 512 (MethodHash=5d8091b7) for method System.Linq.Enumerable:TryGetFirst[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.SingleWithPredicate_LastElementMatches(input: IEnumerable)``

Hot functions:

- (89.21%) ``Enumerable.TryGetSingle`` (Tier-1)
  - **Has diffs**
- (2.55%) ``Perf_Enumerable.SingleWithPredicate_LastElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetSingle(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 54944
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 58264
 ; 4 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T11] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] ( 11,301.27)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T12] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 35,805.38)     ref  ->  [rbp-0x38]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V04 loc1         [V04,T04] (  8,299.27)     int  ->  r13        
+;  V00 arg0         [V00,T08] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T09] ( 11,  5.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T11] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 40,707.31)     ref  ->  [rbp-0x30]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V04 loc1         [V04,T06] (  7,200.79)     int  ->  r15        
 ;* V05 loc2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc3         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T18] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V08 tmp1         [V08,T16] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
 ;* V09 tmp2         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V10 tmp3         [V10    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V11 tmp4         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V12 tmp5         [V12,T09] (  4,198.85)     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp5         [V12,T21] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V13 tmp6         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V14 tmp7         [V14,T13] (  2,  2   )     int  ->  rax         "guarded devirt return temp"
+;  V14 tmp7         [V14,T17] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V15 tmp8         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V16 tmp9         [V16,T08] (  2,  1.99)     int  ->  rax         "guarded devirt return temp"
+;  V16 tmp9         [V16,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V17 tmp10        [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V18 tmp11        [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V19 tmp12        [V19,T15] (  3,  2.99)     int  ->  rcx         "Inline stloc first use temp"
-;  V20 tmp13        [V20,T05] (  6,297.27)     int  ->  rax         "Inline stloc first use temp"
-;  V21 tmp14        [V21,T01] (  6,596.54)     ref  ->  r15         "arr expr"
-;  V22 tmp15        [V22,T02] (  6,596.54)     int  ->   r8         "index expr"
-;  V23 tmp16        [V23,T20] (  2,  0   )     int  ->  rdx         "argument with side effect"
-;  V24 PSPSym       [V24,T19] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V25 cse0         [V25,T06] (  3,295.29)     int  ->   r8         "CSE #03: aggressive"
-;  V26 cse1         [V26,T07] (  3,295.29)     int  ->  r14         "CSE #04: aggressive"
-;  V27 cse2         [V27,T14] (  3,  3   )     int  ->  r11         "CSE #08: moderate"
-;  V28 cse3         [V28,T16] (  3,  2.98)     int  ->   r8         "CSE #05: moderate"
-;  V29 cse4         [V29,T17] (  3,  2.98)     int  ->  r14         "CSE #07: moderate"
-;  V30 cse5         [V30,T10] (  9,104.44)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
+;  V19 tmp12        [V19,T14] (  6,  3.01)     int  ->  rax         "Inline stloc first use temp"
+;  V20 tmp13        [V20,T03] (  6,298.70)     int  ->  rdx         "Inline stloc first use temp"
+;  V21 tmp14        [V21,T01] (  6,599.37)     ref  ->  r14         "arr expr"
+;  V22 tmp15        [V22,T02] (  6,599.37)     int  ->   r8         "index expr"
+;  V23 tmp16        [V23,T20] (  4,  0   )     int  ->  rax         "argument with side effect"
+;  V24 PSPSym       [V24,T18] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
+;  V25 cse0         [V25,T04] (  3,296.69)     int  ->   r8         "CSE #03: aggressive"
+;  V26 cse1         [V26,T05] (  3,296.69)     int  ->  rax         "CSE #04: aggressive"
+;  V27 cse2         [V27,T12] (  3,  3.00)     int  ->   r8         "CSE #05: moderate"
+;  V28 cse3         [V28,T13] (  3,  3.00)     int  ->  rcx         "CSE #07: moderate"
+;  V29 cse4         [V29,T15] (  3,  2.99)     int  ->  rcx         "CSE #08: moderate"
+;  V30 cse5         [V30,T19] (  3,  0.03)     int  ->  rcx         "CSE #09: conservative"
+;  V31 cse6         [V31,T10] (  9,  5.02)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
 ;
-; Lcl frame size = 48
+; Lcl frame size = 56
 
 G_M59240_IG01:
        push     rbp
        push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 48
+       sub      rsp, 56
        lea      rbp, [rsp+0x60]
        mov      qword ptr [rbp-0x40], rsp
        mov      bword ptr [rbp+0x20], r8
        mov      rbx, rdx
-						;; size=30 bbWeight=1 PerfScore 10.00
+						;; size=28 bbWeight=1 PerfScore 9.00
 G_M59240_IG02:
        test     rcx, rcx
-       je       G_M59240_IG31
+       je       G_M59240_IG35
        test     rbx, rbx
-       je       G_M59240_IG32
+       je       G_M59240_IG36
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M59240_IG33
+       jne      G_M59240_IG37
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
 						;; size=57 bbWeight=1 PerfScore 12.25
 G_M59240_IG03:
-       mov      gword ptr [rbp-0x38], rsi
+       mov      gword ptr [rbp-0x30], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M59240_IG04:
        test     rsi, rsi
@@ -966,136 +966,125 @@ G_M59240_IG04:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
        jne      G_M59240_IG14
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_LastElementMatches>b__19_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M59240_IG14
        jmp      SHORT G_M59240_IG11
-						;; size=30 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG05]
+						;; size=46 bbWeight=1 PerfScore 11.75
 G_M59240_IG05:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M59240_IG23
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M59240_IG09
-       mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_LastElementMatches>b__19_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG10
-       cmp      r13d, 99
+       jae      G_M59240_IG21
+       mov      r14, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [r14+0x08]
+       jae      SHORT G_M59240_IG10
+       mov      eax, r8d
+       mov      r15d, dword ptr [r14+4*rax+0x10]
+       cmp      r15d, 99
        jl       SHORT G_M59240_IG11
-						;; size=54 bbWeight=98.43 PerfScore 1943.96
+						;; size=38 bbWeight=98.90 PerfScore 1532.90
 G_M59240_IG06:
        cmp      qword ptr [rsi], rdi
-       jne      G_M59240_IG26
-						;; size=9 bbWeight=100.42 PerfScore 401.69
+       jne      G_M59240_IG24
+						;; size=9 bbWeight=1 PerfScore 4.00
 G_M59240_IG07:
-       mov      ecx, dword ptr [rsi+0x08]
-       inc      ecx
-       mov      r11d, dword ptr [rsi+0x0C]
-       cmp      ecx, r11d
-       jae      G_M59240_IG19
-						;; size=18 bbWeight=1 PerfScore 5.50
+       mov      eax, dword ptr [rsi+0x08]
+       inc      eax
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      eax, ecx
+       jae      G_M59240_IG23
+						;; size=16 bbWeight=1 PerfScore 5.50
 G_M59240_IG08:
-       mov      dword ptr [rsi+0x08], ecx
-       jmp      G_M59240_IG25
-						;; size=8 bbWeight=0.99 PerfScore 2.97
+       mov      dword ptr [rsi+0x08], eax
+       jmp      G_M59240_IG22
+						;; size=8 bbWeight=0.98 PerfScore 2.94
 G_M59240_IG09:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M59240_IG10:
-       mov      edx, r13d
+       mov      edx, r15d
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
        jne      SHORT G_M59240_IG06
-						;; size=14 bbWeight=98.43 PerfScore 639.79
+       jmp      SHORT G_M59240_IG16
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M59240_IG10:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M59240_IG11:
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rsi+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M59240_IG13
-						;; size=14 bbWeight=98.43 PerfScore 541.36
+						;; size=12 bbWeight=98.90 PerfScore 543.93
 G_M59240_IG12:
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M59240_IG05
-						;; size=5 bbWeight=97.44 PerfScore 292.32
+						;; size=5 bbWeight=97.92 PerfScore 293.76
 G_M59240_IG13:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M59240_IG34
-						;; size=9 bbWeight=98.43 PerfScore 295.29
+       mov      dword ptr [rsi+0x08], eax
+       jmp      G_M59240_IG30
+						;; size=8 bbWeight=98.90 PerfScore 296.69
 G_M59240_IG14:
        cmp      dword ptr [rsi], esi
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M59240_IG17
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M59240_IG16
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M59240_IG15:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M59240_IG23
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M59240_IG09
-       mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
+       jae      G_M59240_IG21
+       mov      r14, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [r14+0x08]
+       jae      SHORT G_M59240_IG10
+       mov      ecx, r8d
+       mov      r15d, dword ptr [r14+4*rcx+0x10]
        mov      rdx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG16
-       cmp      r13d, 99
-       jl       SHORT G_M59240_IG17
-       jmp      G_M59240_IG06
-						;; size=59 bbWeight=0.99 PerfScore 21.62
+       jne      SHORT G_M59240_IG09
+       cmp      r15d, 99
+       jge      G_M59240_IG06
+						;; size=58 bbWeight=1.00 PerfScore 19.73
 G_M59240_IG16:
-       mov      edx, r13d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG06
-						;; size=18 bbWeight=0.99 PerfScore 6.46
-G_M59240_IG17:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M59240_IG21
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M59240_IG20
-						;; size=19 bbWeight=0.99 PerfScore 9.45
-G_M59240_IG18:
-       mov      dword ptr [rsi+0x08], eax
+       jne      SHORT G_M59240_IG20
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M59240_IG19
+						;; size=17 bbWeight=1.00 PerfScore 9.49
+G_M59240_IG17:
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M59240_IG15
-						;; size=5 bbWeight=0.98 PerfScore 2.95
+						;; size=5 bbWeight=0.99 PerfScore 2.97
+G_M59240_IG18:
+       mov      r8, bword ptr [rbp+0x20]
+       mov      byte  ptr [r8], 1
+       jmp      G_M59240_IG32
+						;; size=13 bbWeight=1 PerfScore 4.00
 G_M59240_IG19:
-       mov      dword ptr [rsi+0x08], r11d
-       jmp      G_M59240_IG27
-						;; size=9 bbWeight=1 PerfScore 3.00
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      G_M59240_IG30
+						;; size=8 bbWeight=1.00 PerfScore 3.00
 G_M59240_IG20:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M59240_IG34
-						;; size=9 bbWeight=0.99 PerfScore 2.98
-G_M59240_IG21:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       G_M59240_IG34
-						;; size=24 bbWeight=0.99 PerfScore 4.72
-G_M59240_IG22:
+       je       G_M59240_IG30
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-       mov      r13d, eax
-       jmp      SHORT G_M59240_IG16
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M59240_IG23:
+       mov      r15d, eax
+       jmp      G_M59240_IG09
+						;; size=48 bbWeight=0 PerfScore 0.00
+G_M59240_IG21:
        mov      ecx, dword ptr [rsi+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG24:
-       call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M59240_IG25:
+G_M59240_IG22:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
@@ -1103,127 +1092,153 @@ G_M59240_IG25:
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
-       jne      SHORT G_M59240_IG24
+       jne      SHORT G_M59240_IG29
+       jmp      G_M59240_IG07
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M59240_IG23:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      SHORT G_M59240_IG18
+						;; size=5 bbWeight=0.99 PerfScore 2.97
+G_M59240_IG24:
        cmp      qword ptr [rsi], rdi
-       je       G_M59240_IG07
-						;; size=38 bbWeight=0 PerfScore 0.00
+       jne      SHORT G_M59240_IG27
+       mov      eax, dword ptr [rsi+0x08]
+       inc      eax
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      eax, ecx
+       jae      SHORT G_M59240_IG26
+						;; size=17 bbWeight=0.01 PerfScore 0.10
+G_M59240_IG25:
+       mov      dword ptr [rsi+0x08], eax
+       jmp      SHORT G_M59240_IG28
+						;; size=5 bbWeight=0.01 PerfScore 0.03
 G_M59240_IG26:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      G_M59240_IG18
+						;; size=8 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG27:
        mov      rcx, rsi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       jne      SHORT G_M59240_IG25
-						;; size=20 bbWeight=1 PerfScore 4.75
-G_M59240_IG27:
-       mov      r8, bword ptr [rbp+0x20]
-       mov      byte  ptr [r8], 1
-						;; size=8 bbWeight=1 PerfScore 2.00
+       je       G_M59240_IG18
+						;; size=24 bbWeight=0 PerfScore 0.00
 G_M59240_IG28:
-       cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M59240_IG36
-						;; size=5 bbWeight=1 PerfScore 4.00
+       mov      rcx, rsi
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      edx, eax
+       mov      rcx, gword ptr [rbx+0x08]
+       call     [rbx+0x18]<unknown method>
+       test     eax, eax
+       je       SHORT G_M59240_IG24
+						;; size=29 bbWeight=0 PerfScore 0.00
 G_M59240_IG29:
-       mov      eax, r13d
-						;; size=3 bbWeight=1 PerfScore 0.25
+       call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
+       int3     
+						;; size=7 bbWeight=0 PerfScore 0.00
 G_M59240_IG30:
-       add      rsp, 48
+       mov      rcx, rsp
+       call     G_M59240_IG41
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M59240_IG31:
+       jmp      SHORT G_M59240_IG39
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M59240_IG32:
+       cmp      qword ptr [rsi], rdi
+       jne      SHORT G_M59240_IG38
+						;; size=5 bbWeight=1 PerfScore 4.00
+G_M59240_IG33:
+       mov      eax, r15d
+						;; size=3 bbWeight=1 PerfScore 0.25
+G_M59240_IG34:
+       add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M59240_IG31:
+						;; size=13 bbWeight=1 PerfScore 4.25
+G_M59240_IG35:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG32:
+G_M59240_IG36:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG33:
+G_M59240_IG37:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M59240_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M59240_IG34:
-       mov      rcx, rsp
-       call     G_M59240_IG39
-						;; size=8 bbWeight=0 PerfScore 0.00
-G_M59240_IG35:
-       jmp      SHORT G_M59240_IG37
-						;; size=2 bbWeight=0 PerfScore 0.00
-G_M59240_IG36:
+G_M59240_IG38:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M59240_IG29
+       jmp      SHORT G_M59240_IG33
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M59240_IG37:
+G_M59240_IG39:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG38:
-       add      rsp, 48
+G_M59240_IG40:
+       add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M59240_IG39:
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M59240_IG41:
        push     rbp
        push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 48
+       sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x60]
-						;; size=27 bbWeight=0.01 PerfScore 0.07
-G_M59240_IG40:
-       cmp      gword ptr [rbp-0x38], 0
-       je       SHORT G_M59240_IG43
-						;; size=7 bbWeight=0.01 PerfScore 0.02
-G_M59240_IG41:
-       mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rsi, gword ptr [rbp-0x38]
-       cmp      qword ptr [rsi], rdi
-       je       SHORT G_M59240_IG43
-						;; size=19 bbWeight=0.01 PerfScore 0.03
+						;; size=25 bbWeight=0.01 PerfScore 0.06
 G_M59240_IG42:
+       cmp      gword ptr [rbp-0x30], 0
+       je       SHORT G_M59240_IG45
+						;; size=7 bbWeight=0.01 PerfScore 0.02
+G_M59240_IG43:
+       mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
+       mov      rsi, gword ptr [rbp-0x30]
+       cmp      qword ptr [rsi], rdi
+       je       SHORT G_M59240_IG45
+						;; size=19 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG44:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M59240_IG43:
+G_M59240_IG45:
        nop      
 						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M59240_IG44:
-       add      rsp, 48
+G_M59240_IG46:
+       add      rsp, 40
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
        pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0.01 PerfScore 0.03
+						;; size=13 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 724, prolog size 30, PerfScore 4220.76, instruction count 205, allocated bytes for code 724 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 752, prolog size 28, PerfScore 2764.66, instruction count 215, allocated bytes for code 756 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.SingleWithPredicate_FirstElementMatches(input: IEnumerable)``

Hot functions:

- (89.42%) ``Enumerable.TryGetSingle`` (Tier-1)
  - **Has diffs**
- (1.29%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (1.29%) ``Perf_Enumerable.SingleWithPredicate_FirstElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetSingle(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 56832
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 100480
 ; 5 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T10] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T04] ( 15,303.08)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T14] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 45,710.27)     ref  ->  [rbp-0x38]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V04 loc1         [V04,T15] (  8,  4   )     int  ->  r13        
+;  V00 arg0         [V00,T09] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] ( 11,  6.01)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T13] (  4,  3.00)   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 45,712.75)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V04 loc1         [V04,T15] (  7,  3   )     int  ->  r14        
 ;* V05 loc2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc3         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T01] (  7,594.16)     int  ->  rdx         "spilling ret_expr"
-;  V09 tmp2         [V09,T23] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V08 tmp1         [V08,T03] (  6,398.68)     int  ->  rdx         "spilling ret_expr"
+;  V09 tmp2         [V09,T20] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
 ;* V10 tmp3         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V11 tmp4         [V11    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V12 tmp5         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V13 tmp6         [V13,T22] (  4,  2   )     int  ->  rax         "guarded devirt return temp"
+;  V13 tmp6         [V13,T25] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V14 tmp7         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
 ;* V15 tmp8         [V15    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V16 tmp9         [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V17 tmp10        [V17,T09] (  4,198.05)     int  ->  rax         "guarded devirt return temp"
+;  V17 tmp10        [V17,T26] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp11        [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V19 tmp12        [V19,T08] (  2,  2.00)     int  ->  rax         "guarded devirt return temp"
+;  V19 tmp12        [V19,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V20 tmp13        [V20    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V21 tmp14        [V21,T21] (  2,  0.02)     int  ->  rax         "guarded devirt return temp"
+;  V21 tmp14        [V21,T21] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V22 tmp15        [V22    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V23 tmp16        [V23    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V24 tmp17        [V24,T05] (  6,299.09)     int  ->  rax         "Inline stloc first use temp"
-;  V25 tmp18        [V25,T17] (  6,  2.99)     int  ->  rax         "Inline stloc first use temp"
-;  V26 tmp19        [V26,T12] (  6,  6   )     ref  ->  r15         "arr expr"
-;  V27 tmp20        [V27,T13] (  6,  6   )     int  ->   r8         "index expr"
-;  V28 tmp21        [V28,T02] (  6,594.16)     ref  ->  r15         "arr expr"
-;  V29 tmp22        [V29,T03] (  6,594.16)     int  ->   r8         "index expr"
-;  V30 PSPSym       [V30,T24] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V31 cse0         [V31,T06] (  3,297.08)     int  ->  r14         "CSE #09: aggressive"
-;  V32 cse1         [V32,T07] (  3,294.12)     int  ->   r8         "CSE #08: aggressive"
-;  V33 cse2         [V33,T16] (  3,  3.00)     int  ->  r14         "CSE #11: moderate"
-;  V34 cse3         [V34,T18] (  3,  2.97)     int  ->   r8         "CSE #10: moderate"
-;  V35 cse4         [V35,T19] (  3,  2.97)     int  ->   r8         "CSE #03: moderate"
-;  V36 cse5         [V36,T20] (  3,  2.97)     int  ->  r14         "CSE #04: moderate"
-;  V37 cse6         [V37,T25] (  3,  0.03)     int  ->   r8         "CSE #05: conservative"
-;  V38 cse7         [V38,T26] (  3,  0.03)     int  ->  r14         "CSE #07: conservative"
-;  V39 cse8         [V39,T11] (  9,  6.08)    long  ->  rdi         multi-def "CSE #02: aggressive"
+;  V24 tmp17        [V24,T04] (  6,301.01)     int  ->  rax         "Inline stloc first use temp"
+;  V25 tmp18        [V25,T16] (  6,  2.99)     int  ->  rax         "Inline stloc first use temp"
+;  V26 tmp19        [V26,T10] (  6,  6.00)     ref  ->   r8         "arr expr"
+;  V27 tmp20        [V27,T11] (  6,  6.00)     int  ->  rdx         "index expr"
+;  V28 tmp21        [V28,T01] (  6,598.01)     ref  ->   r8         "arr expr"
+;  V29 tmp22        [V29,T02] (  6,598.01)     int  ->  rdx         "index expr"
+;  V30 PSPSym       [V30,T22] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V31 cse0         [V31,T05] (  3,298.99)     int  ->  rcx         "CSE #09: aggressive"
+;  V32 cse1         [V32,T06] (  3,296.03)     int  ->  rdx         "CSE #08: aggressive"
+;  V33 cse2         [V33,T14] (  3,  3.02)     int  ->  rcx         "CSE #11: moderate"
+;  V34 cse3         [V34,T17] (  3,  2.99)     int  ->  rdx         "CSE #10: moderate"
+;  V35 cse4         [V35,T18] (  3,  2.97)     int  ->  rdx         "CSE #03: moderate"
+;  V36 cse5         [V36,T19] (  3,  2.97)     int  ->  rcx         "CSE #04: moderate"
+;  V37 cse6         [V37,T23] (  3,  0.03)     int  ->  rdx         "CSE #05: conservative"
+;  V38 cse7         [V38,T24] (  3,  0.03)     int  ->  rcx         "CSE #07: conservative"
+;  V39 cse8         [V39,T12] (  9,  5.06)    long  ->  rdi         multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 48
 
 G_M59240_IG01:
        push     rbp
-       push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      bword ptr [rbp+0x20], r8
        mov      rbx, rdx
-						;; size=30 bbWeight=1 PerfScore 10.00
+						;; size=26 bbWeight=1 PerfScore 8.00
 G_M59240_IG02:
        test     rcx, rcx
-       je       G_M59240_IG41
+       je       G_M59240_IG38
        test     rbx, rbx
-       je       G_M59240_IG42
+       je       G_M59240_IG39
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M59240_IG43
+       jne      G_M59240_IG40
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
 						;; size=57 bbWeight=1 PerfScore 12.25
 G_M59240_IG03:
-       mov      gword ptr [rbp-0x38], rsi
+       mov      gword ptr [rbp-0x28], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M59240_IG04:
        test     rsi, rsi
-       je       G_M59240_IG27
+       je       G_M59240_IG23
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
-       jne      G_M59240_IG27
+       jne      G_M59240_IG23
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      G_M59240_IG23
        jmp      G_M59240_IG12
-						;; size=33 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG07]
+						;; size=53 bbWeight=1 PerfScore 11.75
 G_M59240_IG05:
-       mov      r8d, dword ptr [rsi+0x08]
-       cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M59240_IG34
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M59240_IG10
-       mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG11
-       test     r13d, r13d
+       mov      edx, dword ptr [rsi+0x08]
+       cmp      edx, dword ptr [rsi+0x0C]
+       jae      G_M59240_IG30
+       mov      r8, gword ptr [rsi+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      SHORT G_M59240_IG11
+       mov      ecx, edx
+       mov      r14d, dword ptr [r8+4*rcx+0x10]
+       test     r14d, r14d
        jg       SHORT G_M59240_IG12
-						;; size=53 bbWeight=0.99 PerfScore 19.55
+						;; size=34 bbWeight=0.99 PerfScore 15.35
 G_M59240_IG06:
        cmp      qword ptr [rsi], rdi
-       jne      G_M59240_IG18
-						;; size=9 bbWeight=2 PerfScore 8.00
+       jne      G_M59240_IG16
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M59240_IG16
+						;; size=25 bbWeight=1 PerfScore 8.25
 G_M59240_IG07:
        mov      eax, dword ptr [rsi+0x08]
        inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      eax, ecx
        jae      SHORT G_M59240_IG14
-						;; size=14 bbWeight=99.03 PerfScore 544.65
+						;; size=12 bbWeight=99.66 PerfScore 548.14
 G_M59240_IG08:
        mov      dword ptr [rsi+0x08], eax
-       mov      r8d, dword ptr [rsi+0x08]
-       cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M59240_IG32
-						;; size=17 bbWeight=98.04 PerfScore 686.28
+       mov      edx, dword ptr [rsi+0x08]
+       cmp      edx, dword ptr [rsi+0x0C]
+       jae      G_M59240_IG28
+						;; size=15 bbWeight=98.68 PerfScore 690.75
 G_M59240_IG09:
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M59240_IG10
-       mov      edx, r8d
-       mov      edx, dword ptr [r15+4*rdx+0x10]
-       mov      rcx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_FirstElementMatches>b__20_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rcx
-       jne      SHORT G_M59240_IG16
+       mov      r8, gword ptr [rsi+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      SHORT G_M59240_IG11
+       mov      ecx, edx
+       mov      edx, dword ptr [r8+4*rcx+0x10]
        test     edx, edx
-       jle      G_M59240_IG35
+       jle      G_M59240_IG29
        jmp      SHORT G_M59240_IG07
-						;; size=44 bbWeight=98.04 PerfScore 1544.08
+						;; size=27 bbWeight=98.67 PerfScore 1134.73
 G_M59240_IG10:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M59240_IG11:
-       mov      edx, r13d
+       mov      edx, r14d
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
        jne      SHORT G_M59240_IG06
-						;; size=14 bbWeight=0.99 PerfScore 6.43
+       jmp      G_M59240_IG23
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M59240_IG11:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M59240_IG12:
        mov      eax, dword ptr [rsi+0x08]
        inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      G_M59240_IG24
-						;; size=18 bbWeight=0.99 PerfScore 5.44
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      eax, ecx
+       jae      SHORT G_M59240_IG20
+						;; size=12 bbWeight=0.99 PerfScore 5.44
 G_M59240_IG13:
        mov      dword ptr [rsi+0x08], eax
        jmp      G_M59240_IG05
 						;; size=8 bbWeight=0.98 PerfScore 2.94
 G_M59240_IG14:
-       mov      dword ptr [rsi+0x08], r14d
-						;; size=4 bbWeight=99.03 PerfScore 99.03
+       mov      dword ptr [rsi+0x08], ecx
+						;; size=3 bbWeight=99.66 PerfScore 99.66
 G_M59240_IG15:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 1
-       jmp      G_M59240_IG38
-						;; size=13 bbWeight=1 PerfScore 4.00
+       jmp      G_M59240_IG35
+						;; size=13 bbWeight=1.00 PerfScore 4.01
 G_M59240_IG16:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG35
-       jmp      G_M59240_IG07
-						;; size=20 bbWeight=98.04 PerfScore 808.80
-G_M59240_IG17:
-       mov      r8d, dword ptr [rsi+0x08]
-       cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M59240_IG32
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M59240_IG10
-       mov      edx, r8d
-       mov      edx, dword ptr [r15+4*rdx+0x10]
-       mov      rcx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rbx+0x18], rcx
-       jne      SHORT G_M59240_IG20
-       test     edx, edx
-       jle      G_M59240_IG35
-						;; size=56 bbWeight=0.99 PerfScore 19.56
-G_M59240_IG18:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M59240_IG22
+       jne      G_M59240_IG27
        mov      eax, dword ptr [rsi+0x08]
        inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M59240_IG21
-						;; size=19 bbWeight=1.00 PerfScore 9.50
-G_M59240_IG19:
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      eax, ecx
+       jae      SHORT G_M59240_IG18
+						;; size=21 bbWeight=1.01 PerfScore 9.56
+G_M59240_IG17:
        mov      dword ptr [rsi+0x08], eax
-       jmp      SHORT G_M59240_IG17
-						;; size=5 bbWeight=0.99 PerfScore 2.97
+       jmp      SHORT G_M59240_IG19
+						;; size=5 bbWeight=1.00 PerfScore 2.99
+G_M59240_IG18:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      SHORT G_M59240_IG15
+						;; size=5 bbWeight=1.01 PerfScore 3.02
+G_M59240_IG19:
+       mov      edx, dword ptr [rsi+0x08]
+       cmp      edx, dword ptr [rsi+0x0C]
+       jae      G_M59240_IG28
+       mov      r8, gword ptr [rsi+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      SHORT G_M59240_IG11
+       mov      ecx, edx
+       mov      edx, dword ptr [r8+4*rcx+0x10]
+       mov      rax, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rbx+0x18], rax
+       jne      G_M59240_IG32
+       test     edx, edx
+       jle      G_M59240_IG29
+       jmp      SHORT G_M59240_IG16
+						;; size=59 bbWeight=1.00 PerfScore 21.68
 G_M59240_IG20:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG35
-       jmp      SHORT G_M59240_IG18
-						;; size=17 bbWeight=0.99 PerfScore 8.17
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      G_M59240_IG33
+						;; size=8 bbWeight=0.99 PerfScore 2.97
 G_M59240_IG21:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M59240_IG15
-						;; size=9 bbWeight=1.00 PerfScore 3.00
+       mov      edx, dword ptr [rsi+0x08]
+       cmp      edx, dword ptr [rsi+0x0C]
+       jae      G_M59240_IG30
+       mov      r8, gword ptr [rsi+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      G_M59240_IG11
+       mov      ecx, edx
+       mov      r14d, dword ptr [r8+4*rcx+0x10]
+       mov      rax, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rbx+0x18], rax
+       jne      G_M59240_IG10
+						;; size=53 bbWeight=0.01 PerfScore 0.19
 G_M59240_IG22:
-       mov      rcx, rsi
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG33
-						;; size=24 bbWeight=1.00 PerfScore 4.75
+       test     r14d, r14d
+       jle      G_M59240_IG06
+						;; size=9 bbWeight=0.01 PerfScore 0.01
 G_M59240_IG23:
-       jmp      G_M59240_IG15
-						;; size=5 bbWeight=1 PerfScore 2.00
-G_M59240_IG24:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M59240_IG36
-						;; size=9 bbWeight=0.99 PerfScore 2.97
-G_M59240_IG25:
-       mov      r8d, dword ptr [rsi+0x08]
-       cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M59240_IG34
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      G_M59240_IG10
-       mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG26
-       test     r13d, r13d
-       jg       SHORT G_M59240_IG27
-       jmp      G_M59240_IG06
-						;; size=62 bbWeight=0.01 PerfScore 0.22
-G_M59240_IG26:
-       mov      edx, r13d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG06
-						;; size=18 bbWeight=0.01 PerfScore 0.07
-G_M59240_IG27:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M59240_IG30
+       jne      SHORT G_M59240_IG26
        mov      eax, dword ptr [rsi+0x08]
        inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M59240_IG29
-						;; size=29 bbWeight=0.01 PerfScore 0.10
-G_M59240_IG28:
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      eax, ecx
+       jae      SHORT G_M59240_IG25
+						;; size=27 bbWeight=0.01 PerfScore 0.10
+G_M59240_IG24:
        mov      dword ptr [rsi+0x08], eax
-       jmp      SHORT G_M59240_IG25
+       jmp      SHORT G_M59240_IG21
 						;; size=5 bbWeight=0.01 PerfScore 0.03
-G_M59240_IG29:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      SHORT G_M59240_IG36
-						;; size=6 bbWeight=0.01 PerfScore 0.03
-G_M59240_IG30:
+G_M59240_IG25:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      G_M59240_IG33
+						;; size=8 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG26:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M59240_IG36
-						;; size=20 bbWeight=0.01 PerfScore 0.05
+       je       SHORT G_M59240_IG33
+       mov      rcx, rsi
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      r14d, eax
+       jmp      G_M59240_IG10
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M59240_IG27:
+       mov      rcx, rsi
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M59240_IG31
+       jmp      G_M59240_IG15
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M59240_IG28:
+       mov      ecx, dword ptr [rsi+0x08]
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M59240_IG29:
+       call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
+       int3     
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M59240_IG30:
+       mov      ecx, dword ptr [rsi+0x08]
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=10 bbWeight=0 PerfScore 0.00
 G_M59240_IG31:
-       mov      rcx, rsi
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       mov      r13d, eax
-       jmp      SHORT G_M59240_IG26
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M59240_IG32:
-       mov      ecx, dword ptr [rsi+0x08]
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG33:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        mov      edx, eax
-       jmp      G_M59240_IG20
-						;; size=23 bbWeight=0 PerfScore 0.00
-G_M59240_IG34:
-       mov      ecx, dword ptr [rsi+0x08]
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG35:
-       call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M59240_IG36:
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M59240_IG32:
+       mov      rcx, gword ptr [rbx+0x08]
+       call     [rbx+0x18]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M59240_IG29
+       jmp      G_M59240_IG16
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M59240_IG33:
        mov      rcx, rsp
-       call     G_M59240_IG47
+       call     G_M59240_IG44
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M59240_IG37:
-       jmp      SHORT G_M59240_IG45
+G_M59240_IG34:
+       jmp      SHORT G_M59240_IG42
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M59240_IG38:
+G_M59240_IG35:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M59240_IG44
-						;; size=5 bbWeight=1.00 PerfScore 4.01
-G_M59240_IG39:
-       mov      eax, r13d
+       jne      SHORT G_M59240_IG41
+						;; size=5 bbWeight=1 PerfScore 4.00
+G_M59240_IG36:
+       mov      eax, r14d
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M59240_IG40:
+G_M59240_IG37:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M59240_IG41:
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M59240_IG38:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG42:
+G_M59240_IG39:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG43:
+G_M59240_IG40:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M59240_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M59240_IG44:
+G_M59240_IG41:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M59240_IG39
+       jmp      SHORT G_M59240_IG36
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M59240_IG45:
+G_M59240_IG42:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG46:
+G_M59240_IG43:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M59240_IG47:
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M59240_IG44:
        push     rbp
-       push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=27 bbWeight=0.03 PerfScore 0.28
-G_M59240_IG48:
-       cmp      gword ptr [rbp-0x38], 0
-       je       SHORT G_M59240_IG51
-						;; size=7 bbWeight=0.03 PerfScore 0.08
-G_M59240_IG49:
+       lea      rbp, [rbp+0x50]
+						;; size=23 bbWeight=0.02 PerfScore 0.17
+G_M59240_IG45:
+       cmp      gword ptr [rbp-0x28], 0
+       je       SHORT G_M59240_IG48
+						;; size=7 bbWeight=0.02 PerfScore 0.06
+G_M59240_IG46:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rsi, gword ptr [rbp-0x38]
+       mov      rsi, gword ptr [rbp-0x28]
        cmp      qword ptr [rsi], rdi
-       je       SHORT G_M59240_IG51
-						;; size=19 bbWeight=0.03 PerfScore 0.13
-G_M59240_IG50:
+       je       SHORT G_M59240_IG48
+						;; size=19 bbWeight=0.02 PerfScore 0.10
+G_M59240_IG47:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M59240_IG51:
+G_M59240_IG48:
        nop      
-						;; size=1 bbWeight=0.03 PerfScore 0.01
-G_M59240_IG52:
+						;; size=1 bbWeight=0.02 PerfScore 0.00
+G_M59240_IG49:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0.03 PerfScore 0.12
+						;; size=11 bbWeight=0.02 PerfScore 0.07
 
-; Total bytes of code 904, prolog size 30, PerfScore 3823.00, instruction count 249, allocated bytes for code 904 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 833, prolog size 26, PerfScore 2591.26, instruction count 230, allocated bytes for code 833 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.WhereFirst_LastElementMatches(input: IEnumerable)``

Hot functions:

- (78.97%) ``System.Linq.Enumerable+WhereEnumerableIterator`1.TryGetFirst`` (Tier-1)
  - **Has diffs**
- (2.46%) ``Perf_Enumerable.WhereFirst_LastElementMatches`` (Tier-1)
  - No diffs
- (2.38%) ``CastHelpers.IsInstanceOfAny`` (Tier-1)
  - No diffs
- (1.64%) ``CastHelpers.IsInstanceOfClass`` (Tier-1)
  - No diffs
- (1.61%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (1.11%) ``Enumerable.TryGetFirst`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]System.Linq.Enumerable+WhereEnumerableIterator`1[System.Int32].TryGetFirst(bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 62768
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 62920
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T10] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Linq.Enumerable+WhereEnumerableIterator`1[int]>
-;  V01 arg1         [V01,T12] (  4,  3   )   byref  ->  [rbp+0x18]  EH-live single-def
-;  V02 loc0         [V02,T04] (  7,301.03)     ref  ->  rbx         class-hnd single-def <<unknown class>>
-;  V03 loc1         [V03,T00] ( 27,705.10)     ref  ->  [rbp-0x38]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V04 loc2         [V04,T03] (  8,301.03)     int  ->  r13        
+;  V00 this         [V00,T08] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Linq.Enumerable+WhereEnumerableIterator`1[int]>
+;  V01 arg1         [V01,T10] (  4,  3   )   byref  ->  [rbp+0x18]  EH-live single-def
+;  V02 loc0         [V02,T12] (  6,  3.99)     ref  ->  rbx         class-hnd single-def <<unknown class>>
+;  V03 loc1         [V03,T00] ( 27,699.32)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V04 loc2         [V04,T06] (  7,199.66)     int  ->  r14        
 ;* V05 loc3         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc4         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T16] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
-;  V09 tmp2         [V09,T11] (  4,  6   )     ref  ->  rcx         single-def "guarded devirt arg temp"
+;  V08 tmp1         [V08,T15] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V09 tmp2         [V09,T09] (  4,  6   )     ref  ->  rcx         single-def "guarded devirt arg temp"
 ;* V10 tmp3         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V11 tmp4         [V11    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V12 tmp5         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V13 tmp6         [V13,T09] (  4,200.02)     int  ->  rax         "guarded devirt return temp"
+;  V13 tmp6         [V13,T17] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V14 tmp7         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V15 tmp8         [V15,T08] (  2,  2.00)     int  ->  rax         "guarded devirt return temp"
+;  V15 tmp8         [V15,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V16 tmp9         [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V17 tmp10        [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V18 tmp11        [V18,T05] (  6,300.03)     int  ->  rax         "Inline stloc first use temp"
-;  V19 tmp12        [V19,T01] (  6,600.06)     ref  ->  r15         "arr expr"
-;  V20 tmp13        [V20,T02] (  6,600.06)     int  ->   r8         "index expr"
-;  V21 PSPSym       [V21,T17] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V22 cse0         [V22,T06] (  3,297.03)     int  ->   r8         "CSE #03: aggressive"
-;  V23 cse1         [V23,T07] (  3,297.03)     int  ->  r14         "CSE #04: aggressive"
-;  V24 cse2         [V24,T14] (  3,  3.00)     int  ->   r8         "CSE #05: moderate"
-;  V25 cse3         [V25,T15] (  3,  3.00)     int  ->  r14         "CSE #07: moderate"
-;  V26 cse4         [V26,T13] (  7,  4.03)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
+;  V18 tmp11        [V18,T03] (  6,297.99)     int  ->  rdx         "Inline stloc first use temp"
+;  V19 tmp12        [V19,T01] (  6,595.99)     ref  ->  registers   "arr expr"
+;  V20 tmp13        [V20,T02] (  6,595.99)     int  ->   r8         "index expr"
+;  V21 PSPSym       [V21,T16] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V22 cse0         [V22,T04] (  3,295.01)     int  ->   r8         "CSE #03: aggressive"
+;  V23 cse1         [V23,T05] (  3,295.01)     int  ->  rax         "CSE #04: aggressive"
+;  V24 cse2         [V24,T13] (  3,  2.98)     int  ->   r8         "CSE #05: moderate"
+;  V25 cse3         [V25,T14] (  3,  2.98)     int  ->  rcx         "CSE #07: moderate"
+;  V26 cse4         [V26,T11] (  7,  4.00)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 48
 
 G_M7090_IG01:
        push     rbp
-       push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      bword ptr [rbp+0x18], rdx
-						;; size=27 bbWeight=1 PerfScore 9.75
+						;; size=23 bbWeight=1 PerfScore 7.75
 G_M7090_IG02:
        mov      rbx, gword ptr [rcx+0x20]
        mov      rcx, gword ptr [rcx+0x18]
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M7090_IG25
+       jne      G_M7090_IG22
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
 						;; size=47 bbWeight=1 PerfScore 13.75
 G_M7090_IG03:
-       mov      gword ptr [rbp-0x38], rsi
+       mov      gword ptr [rbp-0x28], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M7090_IG04:
        test     rsi, rsi
        je       G_M7090_IG11
+       test     rbx, rbx
+       je       G_M7090_IG11
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
        jne      SHORT G_M7090_IG11
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereFirst_LastElementMatches>b__7_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M7090_IG11
        jmp      SHORT G_M7090_IG09
-						;; size=26 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG05]
+						;; size=51 bbWeight=1 PerfScore 13.00
 G_M7090_IG05:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M7090_IG19
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M7090_IG07
-       mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereFirst_LastElementMatches>b__7_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M7090_IG08
-       cmp      r13d, 99
+       jae      G_M7090_IG16
+       mov      rbx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rbx+0x08]
+       jae      SHORT G_M7090_IG08
+       mov      eax, r8d
+       mov      r14d, dword ptr [rbx+4*rax+0x10]
+       cmp      r14d, 99
        jl       SHORT G_M7090_IG09
-						;; size=54 bbWeight=99.01 PerfScore 1955.44
+						;; size=38 bbWeight=98.34 PerfScore 1524.24
 G_M7090_IG06:
        mov      rdx, bword ptr [rbp+0x18]
        mov      byte  ptr [rdx], 1
-       jmp      G_M7090_IG22
+       jmp      G_M7090_IG19
 						;; size=12 bbWeight=1 PerfScore 4.00
 G_M7090_IG07:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M7090_IG08:
-       mov      edx, r13d
+       mov      edx, r14d
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
        jne      SHORT G_M7090_IG06
-						;; size=14 bbWeight=99.01 PerfScore 643.56
+       jmp      SHORT G_M7090_IG13
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M7090_IG08:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M7090_IG09:
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rsi+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M7090_IG10
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M7090_IG05
-						;; size=19 bbWeight=99.01 PerfScore 841.58
+						;; size=17 bbWeight=98.34 PerfScore 835.87
 G_M7090_IG10:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M7090_IG20
-						;; size=9 bbWeight=99.01 PerfScore 297.03
+       mov      dword ptr [rsi+0x08], eax
+       jmp      G_M7090_IG17
+						;; size=8 bbWeight=98.34 PerfScore 295.01
 G_M7090_IG11:
        cmp      dword ptr [rsi], esi
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M7090_IG15
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M7090_IG13
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M7090_IG12:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M7090_IG19
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M7090_IG07
+       jae      SHORT G_M7090_IG16
+       mov      rcx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rcx+0x08]
+       jae      SHORT G_M7090_IG08
        mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
+       mov      r14d, dword ptr [rcx+4*rdx+0x10]
        mov      rdx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M7090_IG14
-       cmp      r13d, 99
-       jl       SHORT G_M7090_IG15
-						;; size=54 bbWeight=1.00 PerfScore 19.75
+       jne      SHORT G_M7090_IG07
+       cmp      r14d, 99
+       jge      SHORT G_M7090_IG06
+						;; size=50 bbWeight=0.99 PerfScore 19.62
 G_M7090_IG13:
-       jmp      G_M7090_IG06
-						;; size=5 bbWeight=1 PerfScore 2.00
-G_M7090_IG14:
-       mov      edx, r13d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M7090_IG06
-						;; size=18 bbWeight=1.00 PerfScore 6.50
-G_M7090_IG15:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M7090_IG17
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M7090_IG16
-       mov      dword ptr [rsi+0x08], eax
+       jne      SHORT G_M7090_IG15
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M7090_IG14
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M7090_IG12
-						;; size=24 bbWeight=1.00 PerfScore 12.50
-G_M7090_IG16:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      SHORT G_M7090_IG20
-						;; size=6 bbWeight=1.00 PerfScore 3.00
-G_M7090_IG17:
+						;; size=22 bbWeight=0.99 PerfScore 12.42
+G_M7090_IG14:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      SHORT G_M7090_IG17
+						;; size=5 bbWeight=0.99 PerfScore 2.98
+G_M7090_IG15:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M7090_IG20
-						;; size=20 bbWeight=1.00 PerfScore 4.75
-G_M7090_IG18:
+       je       SHORT G_M7090_IG17
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-       mov      r13d, eax
-       jmp      SHORT G_M7090_IG14
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M7090_IG19:
+       mov      r14d, eax
+       jmp      G_M7090_IG07
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M7090_IG16:
        mov      ecx, dword ptr [rsi+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M7090_IG20:
+G_M7090_IG17:
        mov      rcx, rsp
-       call     G_M7090_IG29
+       call     G_M7090_IG26
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M7090_IG21:
-       jmp      SHORT G_M7090_IG27
+G_M7090_IG18:
+       jmp      SHORT G_M7090_IG24
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M7090_IG22:
+G_M7090_IG19:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M7090_IG26
+       jne      SHORT G_M7090_IG23
 						;; size=5 bbWeight=1 PerfScore 4.00
-G_M7090_IG23:
-       mov      eax, r13d
+G_M7090_IG20:
+       mov      eax, r14d
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M7090_IG24:
+G_M7090_IG21:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M7090_IG25:
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M7090_IG22:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M7090_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M7090_IG26:
+G_M7090_IG23:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M7090_IG23
+       jmp      SHORT G_M7090_IG20
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M7090_IG27:
+G_M7090_IG24:
        mov      rdx, bword ptr [rbp+0x18]
        mov      byte  ptr [rdx], 0
        xor      eax, eax
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M7090_IG28:
+G_M7090_IG25:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M7090_IG29:
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M7090_IG26:
        push     rbp
-       push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=27 bbWeight=0.01 PerfScore 0.12
-G_M7090_IG30:
-       cmp      gword ptr [rbp-0x38], 0
-       je       SHORT G_M7090_IG33
-						;; size=7 bbWeight=0.01 PerfScore 0.03
-G_M7090_IG31:
+       lea      rbp, [rbp+0x50]
+						;; size=23 bbWeight=0.00 PerfScore 0.03
+G_M7090_IG27:
+       cmp      gword ptr [rbp-0x28], 0
+       je       SHORT G_M7090_IG30
+						;; size=7 bbWeight=0.00 PerfScore 0.01
+G_M7090_IG28:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rsi, gword ptr [rbp-0x38]
+       mov      rsi, gword ptr [rbp-0x28]
        cmp      qword ptr [rsi], rdi
-       je       SHORT G_M7090_IG33
-						;; size=19 bbWeight=0.01 PerfScore 0.06
-G_M7090_IG32:
+       je       SHORT G_M7090_IG30
+						;; size=19 bbWeight=0.00 PerfScore 0.02
+G_M7090_IG29:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M7090_IG33:
+G_M7090_IG30:
        nop      
-						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M7090_IG34:
+						;; size=1 bbWeight=0.00 PerfScore 0.00
+G_M7090_IG31:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0.01 PerfScore 0.05
+						;; size=11 bbWeight=0.00 PerfScore 0.01
 
-; Total bytes of code 570, prolog size 27, PerfScore 3831.45, instruction count 169, allocated bytes for code 570 (MethodHash=ee90e44d) for method System.Linq.Enumerable+WhereEnumerableIterator`1[int]:TryGetFirst(byref):int:this (Tier1)
+; Total bytes of code 531, prolog size 23, PerfScore 2737.72, instruction count 157, allocated bytes for code 535 (MethodHash=ee90e44d) for method System.Linq.Enumerable+WhereEnumerableIterator`1[int]:TryGetFirst(byref):int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.FirstWithPredicate_LastElementMatches(input: IEnumerable)``

Hot functions:

- (88.31%) ``Enumerable.TryGetFirst`` (Tier-1)
  - **Has diffs**
- (1.77%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (1.48%) ``Perf_Enumerable.FirstWithPredicate_LastElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetFirst(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 57040
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 49952
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T10] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] (  9,301.03)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T11] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 27,700.40)     ref  ->  [rbp-0x38]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V04 loc1         [V04,T04] (  8,299.03)     int  ->  r13        
+;  V00 arg0         [V00,T08] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T09] (  7,  5.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T10] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 27,701.25)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V04 loc1         [V04,T06] (  7,200.21)     int  ->  r14        
 ;* V05 loc2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc3         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T15] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V08 tmp1         [V08,T14] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
 ;* V09 tmp2         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V10 tmp3         [V10    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V11 tmp4         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V12 tmp5         [V12,T09] (  4,198.69)     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp5         [V12,T16] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V13 tmp6         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V14 tmp7         [V14,T08] (  2,  1.99)     int  ->  rax         "guarded devirt return temp"
+;  V14 tmp7         [V14,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V15 tmp8         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V16 tmp9         [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V17 tmp10        [V17,T05] (  6,298.03)     int  ->  rax         "Inline stloc first use temp"
-;  V18 tmp11        [V18,T01] (  6,596.06)     ref  ->  r15         "arr expr"
-;  V19 tmp12        [V19,T02] (  6,596.06)     int  ->   r8         "index expr"
-;  V20 PSPSym       [V20,T16] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V21 cse0         [V21,T06] (  3,295.05)     int  ->   r8         "CSE #03: aggressive"
-;  V22 cse1         [V22,T07] (  3,295.05)     int  ->  r14         "CSE #04: aggressive"
-;  V23 cse2         [V23,T13] (  3,  2.98)     int  ->   r8         "CSE #05: moderate"
-;  V24 cse3         [V24,T14] (  3,  2.98)     int  ->  r14         "CSE #07: moderate"
-;  V25 cse4         [V25,T12] (  7,  4.01)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
+;  V17 tmp10        [V17,T03] (  6,298.81)     int  ->  rdx         "Inline stloc first use temp"
+;  V18 tmp11        [V18,T01] (  6,597.62)     ref  ->  registers   "arr expr"
+;  V19 tmp12        [V19,T02] (  6,597.62)     int  ->   r8         "index expr"
+;  V20 PSPSym       [V20,T15] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V21 cse0         [V21,T04] (  3,295.82)     int  ->   r8         "CSE #03: aggressive"
+;  V22 cse1         [V22,T05] (  3,295.82)     int  ->  rax         "CSE #04: aggressive"
+;  V23 cse2         [V23,T12] (  3,  2.99)     int  ->   r8         "CSE #05: moderate"
+;  V24 cse3         [V24,T13] (  3,  2.99)     int  ->  rcx         "CSE #07: moderate"
+;  V25 cse4         [V25,T11] (  7,  4.03)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 48
 
 G_M28232_IG01:
        push     rbp
-       push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      bword ptr [rbp+0x20], r8
        mov      rbx, rdx
-						;; size=30 bbWeight=1 PerfScore 10.00
+						;; size=26 bbWeight=1 PerfScore 8.00
 G_M28232_IG02:
        test     rcx, rcx
-       je       G_M28232_IG24
+       je       G_M28232_IG22
        test     rbx, rbx
-       je       G_M28232_IG25
+       je       G_M28232_IG23
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M28232_IG26
+       jne      G_M28232_IG24
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
 						;; size=57 bbWeight=1 PerfScore 12.25
 G_M28232_IG03:
-       mov      gword ptr [rbp-0x38], rsi
+       mov      gword ptr [rbp-0x28], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M28232_IG04:
        test     rsi, rsi
@@ -1102,219 +1100,203 @@ G_M28232_IG04:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
        jne      SHORT G_M28232_IG11
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<FirstWithPredicate_LastElementMatches>b__10_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M28232_IG11
        jmp      SHORT G_M28232_IG09
-						;; size=26 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG05]
+						;; size=42 bbWeight=1 PerfScore 11.75
 G_M28232_IG05:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M28232_IG18
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M28232_IG07
-       mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<FirstWithPredicate_LastElementMatches>b__10_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M28232_IG08
-       cmp      r13d, 99
+       jae      G_M28232_IG16
+       mov      rbx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rbx+0x08]
+       jae      SHORT G_M28232_IG08
+       mov      eax, r8d
+       mov      r14d, dword ptr [rbx+4*rax+0x10]
+       cmp      r14d, 99
        jl       SHORT G_M28232_IG09
-						;; size=54 bbWeight=98.35 PerfScore 1942.40
+						;; size=38 bbWeight=98.61 PerfScore 1528.42
 G_M28232_IG06:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 1
-       jmp      G_M28232_IG21
+       jmp      G_M28232_IG19
 						;; size=13 bbWeight=1 PerfScore 4.00
 G_M28232_IG07:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M28232_IG08:
-       mov      edx, r13d
+       mov      edx, r14d
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
        jne      SHORT G_M28232_IG06
-						;; size=14 bbWeight=98.35 PerfScore 639.27
+       jmp      SHORT G_M28232_IG13
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M28232_IG08:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M28232_IG09:
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rsi+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M28232_IG10
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M28232_IG05
-						;; size=19 bbWeight=98.35 PerfScore 835.97
+						;; size=17 bbWeight=98.61 PerfScore 838.16
 G_M28232_IG10:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M28232_IG19
-						;; size=9 bbWeight=98.35 PerfScore 295.05
+       mov      dword ptr [rsi+0x08], eax
+       jmp      G_M28232_IG17
+						;; size=8 bbWeight=98.61 PerfScore 295.82
 G_M28232_IG11:
        cmp      dword ptr [rsi], esi
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M28232_IG14
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M28232_IG13
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M28232_IG12:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M28232_IG18
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M28232_IG07
+       jae      SHORT G_M28232_IG16
+       mov      rcx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rcx+0x08]
+       jae      SHORT G_M28232_IG08
        mov      edx, r8d
-       mov      r13d, dword ptr [r15+4*rdx+0x10]
+       mov      r14d, dword ptr [rcx+4*rdx+0x10]
        mov      rdx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M28232_IG13
-       cmp      r13d, 99
-       jl       SHORT G_M28232_IG14
-       jmp      G_M28232_IG06
-						;; size=59 bbWeight=0.99 PerfScore 21.61
+       jne      SHORT G_M28232_IG07
+       cmp      r14d, 99
+       jge      SHORT G_M28232_IG06
+						;; size=50 bbWeight=1.00 PerfScore 19.67
 G_M28232_IG13:
-       mov      edx, r13d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M28232_IG06
-						;; size=18 bbWeight=0.99 PerfScore 6.46
-G_M28232_IG14:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M28232_IG16
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M28232_IG15
-       mov      dword ptr [rsi+0x08], eax
+       jne      SHORT G_M28232_IG15
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M28232_IG14
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M28232_IG12
-						;; size=24 bbWeight=0.99 PerfScore 12.42
+						;; size=22 bbWeight=1.00 PerfScore 12.45
+G_M28232_IG14:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      SHORT G_M28232_IG17
+						;; size=5 bbWeight=1.00 PerfScore 2.99
 G_M28232_IG15:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      SHORT G_M28232_IG19
-						;; size=6 bbWeight=0.99 PerfScore 2.98
-G_M28232_IG16:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M28232_IG19
-						;; size=20 bbWeight=0.99 PerfScore 4.72
-G_M28232_IG17:
+       je       SHORT G_M28232_IG17
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-       mov      r13d, eax
-       jmp      SHORT G_M28232_IG13
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M28232_IG18:
+       mov      r14d, eax
+       jmp      G_M28232_IG07
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M28232_IG16:
        mov      ecx, dword ptr [rsi+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M28232_IG19:
+G_M28232_IG17:
        mov      rcx, rsp
-       call     G_M28232_IG30
+       call     G_M28232_IG28
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M28232_IG20:
-       jmp      SHORT G_M28232_IG28
+G_M28232_IG18:
+       jmp      SHORT G_M28232_IG26
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M28232_IG21:
+G_M28232_IG19:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M28232_IG27
+       jne      SHORT G_M28232_IG25
 						;; size=5 bbWeight=1 PerfScore 4.00
-G_M28232_IG22:
-       mov      eax, r13d
+G_M28232_IG20:
+       mov      eax, r14d
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M28232_IG23:
+G_M28232_IG21:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=1 PerfScore 4.75
-G_M28232_IG24:
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M28232_IG22:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M28232_IG25:
+G_M28232_IG23:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M28232_IG26:
+G_M28232_IG24:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M28232_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M28232_IG27:
+G_M28232_IG25:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M28232_IG22
+       jmp      SHORT G_M28232_IG20
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M28232_IG28:
+G_M28232_IG26:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M28232_IG29:
+G_M28232_IG27:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M28232_IG30:
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M28232_IG28:
        push     rbp
-       push     r15
        push     r14
-       push     r13
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=27 bbWeight=0.00 PerfScore 0.04
-G_M28232_IG31:
-       cmp      gword ptr [rbp-0x38], 0
-       je       SHORT G_M28232_IG34
-						;; size=7 bbWeight=0.00 PerfScore 0.01
-G_M28232_IG32:
+       lea      rbp, [rbp+0x50]
+						;; size=23 bbWeight=0.02 PerfScore 0.13
+G_M28232_IG29:
+       cmp      gword ptr [rbp-0x28], 0
+       je       SHORT G_M28232_IG32
+						;; size=7 bbWeight=0.02 PerfScore 0.05
+G_M28232_IG30:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rsi, gword ptr [rbp-0x38]
+       mov      rsi, gword ptr [rbp-0x28]
        cmp      qword ptr [rsi], rdi
-       je       SHORT G_M28232_IG34
-						;; size=19 bbWeight=0.00 PerfScore 0.02
-G_M28232_IG33:
+       je       SHORT G_M28232_IG32
+						;; size=19 bbWeight=0.02 PerfScore 0.08
+G_M28232_IG31:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M28232_IG34:
+G_M28232_IG32:
        nop      
-						;; size=1 bbWeight=0.00 PerfScore 0.00
-G_M28232_IG35:
+						;; size=1 bbWeight=0.02 PerfScore 0.00
+G_M28232_IG33:
        add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r13
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=15 bbWeight=0.00 PerfScore 0.02
+						;; size=11 bbWeight=0.02 PerfScore 0.06
 
-; Total bytes of code 609, prolog size 30, PerfScore 3804.77, instruction count 178, allocated bytes for code 609 (MethodHash=5d8091b7) for method System.Linq.Enumerable:TryGetFirst[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 561, prolog size 26, PerfScore 2742.83, instruction count 164, allocated bytes for code 565 (MethodHash=5d8091b7) for method System.Linq.Enumerable:TryGetFirst[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.LastWithPredicate_FirstElementMatches(input: IEnumerable)``

Hot functions:

- (87.73%) ``Enumerable.TryGetLast`` (Tier-1)
  - **Has diffs**
- (1.26%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (1.26%) ``SZArrayHelper.GetEnumerator`` (Tier-1)
  - No diffs
- (1.26%) ``Perf_Enumerable.LastWithPredicate_FirstElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetLast(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 62416
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 58264
 ; 5 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T11] ( 10,  7   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T04] ( 18,302.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T17] (  6,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T25] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
-;  V04 loc1         [V04,T24] (  6,  2   )     ref  ->  rdi         class-hnd single-def <<unknown class>>
-;  V05 loc2         [V05,T31] (  6,  0   )     int  ->  rsi        
-;  V06 loc3         [V06,T32] (  3,  0   )     int  ->  r14        
-;  V07 loc4         [V07,T00] ( 45,707.71)     ref  ->  [rbp-0x40]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V08 loc5         [V08,T10] ( 10,102.67)     int  ->  registers  
-;  V09 loc6         [V09,T03] (  9,394.66)     int  ->  r12        
+;  V00 arg0         [V00,T09] ( 10,  7   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T12] ( 14,  5.99)     ref  ->  rsi         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T16] (  6,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T23] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
+;  V04 loc1         [V04,T22] (  6,  2   )     ref  ->  rdi         class-hnd single-def <<unknown class>>
+;  V05 loc2         [V05,T29] (  6,  0   )     int  ->  rbx        
+;  V06 loc3         [V06,T30] (  3,  0   )     int  ->  r13        
+;  V07 loc4         [V07,T00] ( 45,703.14)     ref  ->  [rbp-0x40]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V08 loc5         [V08,T08] (  9,101.30)     int  ->  r13        
+;  V09 loc6         [V09,T05] (  8,294.89)     int  ->  r12        
 ;* V10 loc7         [V10    ] (  0,  0   )     int  ->  zero-ref   
 ;* V11 loc8         [V11    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V13 tmp1         [V13,T27] (  3,  2   )     ref  ->  r14         "guarded devirt return temp"
+;  V13 tmp1         [V13,T24] (  3,  2   )     ref  ->  r14         "guarded devirt return temp"
 ;* V14 tmp2         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V15 tmp3         [V15    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V16 tmp4         [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V17 tmp5         [V17,T26] (  4,  2   )     int  ->  rax         "guarded devirt return temp"
+;  V17 tmp5         [V17,T31] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp6         [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
 ;* V19 tmp7         [V19    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V20 tmp8         [V20    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V21 tmp9         [V21,T09] (  4,197.33)     int  ->  rax         "guarded devirt return temp"
+;  V21 tmp9         [V21,T32] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V22 tmp10        [V22    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V23 tmp11        [V23,T08] (  2,  1.99)     int  ->  rax         "guarded devirt return temp"
+;  V23 tmp11        [V23,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V24 tmp12        [V24    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V25 tmp13        [V25,T23] (  2,  0.02)     int  ->  rax         "guarded devirt return temp"
+;  V25 tmp13        [V25,T25] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V26 tmp14        [V26    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V27 tmp15        [V27    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V28 tmp16        [V28,T05] (  6,298.01)     int  ->  rax         "Inline stloc first use temp"
-;  V29 tmp17        [V29,T18] (  6,  2.99)     int  ->  rax         "Inline stloc first use temp"
-;  V30 tmp18        [V30,T15] (  6,  6   )     ref  ->  rdi         "arr expr"
-;  V31 tmp19        [V31,T16] (  6,  6   )     int  ->   r8         "index expr"
-;  V32 tmp20        [V32,T01] (  6,592.00)     ref  ->  rdi         "arr expr"
-;  V33 tmp21        [V33,T02] (  6,592.00)     int  ->   r8         "index expr"
-;  V34 PSPSym       [V34,T28] (  1,  1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
-;  V35 cse0         [V35,T06] (  3,296.01)     int  ->  rsi         "CSE #09: aggressive"
-;  V36 cse1         [V36,T07] (  3,293.06)     int  ->   r8         "CSE #08: aggressive"
-;  V37 cse2         [V37,T19] (  3,  2.99)     int  ->  rsi         "CSE #11: moderate"
-;  V38 cse3         [V38,T20] (  3,  2.97)     int  ->   r8         "CSE #03: moderate"
-;  V39 cse4         [V39,T21] (  3,  2.97)     int  ->  rsi         "CSE #04: moderate"
-;  V40 cse5         [V40,T22] (  3,  2.96)     int  ->   r8         "CSE #10: moderate"
-;  V41 cse6         [V41,T29] (  3,  0.03)     int  ->   r8         "CSE #05: conservative"
-;  V42 cse7         [V42,T30] (  3,  0.03)     int  ->  rsi         "CSE #07: conservative"
-;  V43 cse8         [V43,T14] (  9,  6.04)    long  ->  r15         multi-def "CSE #02: aggressive"
-;  V44 rat0         [V44,T12] (  6,  8   )     ref  ->  rcx         "replacement local"
-;  V45 rat1         [V45,T13] (  6,  8   )     ref  ->  rdi         "replacement local"
+;  V28 tmp16        [V28,T03] (  6,296.91)     int  ->  rcx         "Inline stloc first use temp"
+;  V29 tmp17        [V29,T17] (  6,  2.99)     int  ->  rax         "Inline stloc first use temp"
+;  V30 tmp18        [V30,T13] (  6,  6   )     ref  ->   r8         "arr expr"
+;  V31 tmp19        [V31,T14] (  6,  6   )     int  ->  rdx         "index expr"
+;  V32 tmp20        [V32,T01] (  6,589.79)     ref  ->  registers   "arr expr"
+;  V33 tmp21        [V33,T02] (  6,589.79)     int  ->  rdx         "index expr"
+;  V34 PSPSym       [V34,T26] (  1,  1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
+;  V35 cse0         [V35,T04] (  3,294.91)     int  ->  rax         "CSE #09: aggressive"
+;  V36 cse1         [V36,T06] (  3,291.97)     int  ->  rdx         "CSE #08: aggressive"
+;  V37 cse2         [V37,T18] (  3,  2.98)     int  ->  rax         "CSE #11: moderate"
+;  V38 cse3         [V38,T19] (  3,  2.97)     int  ->  rdx         "CSE #03: moderate"
+;  V39 cse4         [V39,T20] (  3,  2.97)     int  ->  rcx         "CSE #04: moderate"
+;  V40 cse5         [V40,T21] (  3,  2.95)     int  ->  rdx         "CSE #10: moderate"
+;  V41 cse6         [V41,T27] (  3,  0.03)     int  ->  rdx         "CSE #05: conservative"
+;  V42 cse7         [V42,T28] (  3,  0.03)     int  ->  rcx         "CSE #07: conservative"
+;  V43 cse8         [V43,T15] (  9,  5.03)    long  ->  r15         multi-def "CSE #02: aggressive"
+;  V44 rat0         [V44,T10] (  6,  8   )     ref  ->  rcx         "replacement local"
+;  V45 rat1         [V45,T11] (  6,  8   )     ref  ->  rdi         "replacement local"
 ;
 ; Lcl frame size = 56
 
@@ -919,36 +919,36 @@ G_M12024_IG01:
        lea      rbp, [rsp+0x70]
        mov      qword ptr [rbp-0x50], rsp
        mov      bword ptr [rbp+0x20], r8
-       mov      rsi, rcx
-       mov      rbx, rdx
+       mov      rbx, rcx
+       mov      rsi, rdx
 						;; size=35 bbWeight=1 PerfScore 11.25
 G_M12024_IG02:
+       test     rbx, rbx
+       je       G_M12024_IG42
        test     rsi, rsi
        je       G_M12024_IG43
-       test     rbx, rbx
-       je       G_M12024_IG44
-       mov      rcx, rsi
+       mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M12024_IG45
+       jne      G_M12024_IG44
        xor      rcx, rcx
        test     rcx, rcx
-       jne      G_M12024_IG46
+       jne      G_M12024_IG45
 						;; size=51 bbWeight=1 PerfScore 8.50
 G_M12024_IG03:
-       mov      rdi, rsi
+       mov      rdi, rbx
        mov      rcx, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rdi], rcx
-       jne      G_M12024_IG48
+       jne      G_M12024_IG47
        xor      rdi, rdi
        test     rdi, rdi
-       jne      G_M12024_IG49
+       jne      G_M12024_IG48
 						;; size=33 bbWeight=1 PerfScore 6.00
 G_M12024_IG04:
        mov      rcx, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
-       cmp      qword ptr [rsi], rcx
-       jne      G_M12024_IG53
-       mov      rcx, gword ptr [rsi+0x08]
+       cmp      qword ptr [rbx], rcx
+       jne      G_M12024_IG52
+       mov      rcx, gword ptr [rbx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      r14, rax
@@ -958,241 +958,230 @@ G_M12024_IG05:
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M12024_IG06:
        test     r14, r14
-       je       G_M12024_IG30
+       je       G_M12024_IG21
        mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [r14], r15
-       jne      G_M12024_IG30
+       jne      G_M12024_IG21
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<LastWithPredicate_FirstElementMatches>b__12_0(int):ubyte:this
+       cmp      qword ptr [rsi+0x18], rax
+       jne      G_M12024_IG21
        jmp      G_M12024_IG15
-						;; size=33 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG09]
+						;; size=53 bbWeight=1 PerfScore 11.75
 G_M12024_IG07:
-       mov      r8d, dword ptr [r14+0x08]
-       cmp      r8d, dword ptr [r14+0x0C]
-       jae      G_M12024_IG37
-       mov      rdi, gword ptr [r14+0x10]
-       cmp      r8d, dword ptr [rdi+0x08]
-       jae      SHORT G_M12024_IG13
-       mov      edx, r8d
-       mov      r13d, dword ptr [rdi+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<LastWithPredicate_FirstElementMatches>b__12_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M12024_IG14
+       mov      edx, dword ptr [r14+0x08]
+       cmp      edx, dword ptr [r14+0x0C]
+       jae      G_M12024_IG31
+       mov      r8, gword ptr [r14+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      SHORT G_M12024_IG14
+       mov      ecx, edx
+       mov      r13d, dword ptr [r8+4*rcx+0x10]
        test     r13d, r13d
        jl       SHORT G_M12024_IG15
-						;; size=53 bbWeight=0.99 PerfScore 19.55
+						;; size=36 bbWeight=0.99 PerfScore 15.35
 G_M12024_IG08:
        cmp      qword ptr [r14], r15
-       jne      G_M12024_IG23
-						;; size=9 bbWeight=2 PerfScore 8.00
+       jne      G_M12024_IG24
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<LastWithPredicate_FirstElementMatches>b__12_0(int):ubyte:this
+       cmp      qword ptr [rsi+0x18], rax
+       jne      G_M12024_IG24
+						;; size=29 bbWeight=1 PerfScore 8.25
 G_M12024_IG09:
-       mov      eax, dword ptr [r14+0x08]
-       inc      eax
-       mov      esi, dword ptr [r14+0x0C]
-       cmp      eax, esi
+       mov      ecx, dword ptr [r14+0x08]
+       inc      ecx
+       mov      eax, dword ptr [r14+0x0C]
+       cmp      ecx, eax
        jae      SHORT G_M12024_IG17
-						;; size=14 bbWeight=98.67 PerfScore 542.68
+						;; size=14 bbWeight=98.30 PerfScore 540.68
 G_M12024_IG10:
-       mov      dword ptr [r14+0x08], eax
-       mov      r8d, dword ptr [r14+0x08]
-       cmp      r8d, dword ptr [r14+0x0C]
-       jae      G_M12024_IG35
-						;; size=18 bbWeight=97.69 PerfScore 683.82
+       mov      dword ptr [r14+0x08], ecx
+       mov      edx, dword ptr [r14+0x08]
+       cmp      edx, dword ptr [r14+0x0C]
+       jae      G_M12024_IG36
+						;; size=18 bbWeight=97.33 PerfScore 681.30
 G_M12024_IG11:
-       mov      rdi, gword ptr [r14+0x10]
-       cmp      r8d, dword ptr [rdi+0x08]
-       jae      SHORT G_M12024_IG13
-       mov      edx, r8d
-       mov      r12d, dword ptr [rdi+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<LastWithPredicate_FirstElementMatches>b__12_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M12024_IG19
+       mov      r8, gword ptr [r14+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      SHORT G_M12024_IG14
+       mov      eax, edx
+       mov      r12d, dword ptr [r8+4*rax+0x10]
        test     r12d, r12d
        jl       SHORT G_M12024_IG09
-						;; size=39 bbWeight=97.68 PerfScore 1343.09
+						;; size=22 bbWeight=97.31 PerfScore 924.49
 G_M12024_IG12:
        mov      r13d, r12d
        jmp      SHORT G_M12024_IG09
-						;; size=5 bbWeight=97.68 PerfScore 219.78
+						;; size=5 bbWeight=97.31 PerfScore 218.96
 G_M12024_IG13:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M12024_IG14:
        mov      edx, r13d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
+       mov      rcx, gword ptr [rsi+0x08]
+       call     [rsi+0x18]<unknown method>
        test     eax, eax
        jne      SHORT G_M12024_IG08
-						;; size=14 bbWeight=0.99 PerfScore 6.43
+       jmp      SHORT G_M12024_IG21
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M12024_IG14:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M12024_IG15:
        mov      eax, dword ptr [r14+0x08]
        inc      eax
-       mov      esi, dword ptr [r14+0x0C]
-       cmp      eax, esi
-       jae      G_M12024_IG27
-						;; size=18 bbWeight=0.99 PerfScore 5.44
+       mov      ecx, dword ptr [r14+0x0C]
+       cmp      eax, ecx
+       jae      SHORT G_M12024_IG19
+						;; size=14 bbWeight=0.99 PerfScore 5.44
 G_M12024_IG16:
        mov      dword ptr [r14+0x08], eax
        jmp      G_M12024_IG07
 						;; size=9 bbWeight=0.98 PerfScore 2.94
 G_M12024_IG17:
-       mov      dword ptr [r14+0x08], esi
-						;; size=4 bbWeight=98.67 PerfScore 98.67
+       mov      dword ptr [r14+0x08], eax
+						;; size=4 bbWeight=98.30 PerfScore 98.30
 G_M12024_IG18:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 1
-       jmp      G_M12024_IG40
+       jmp      G_M12024_IG39
 						;; size=13 bbWeight=1 PerfScore 4.00
 G_M12024_IG19:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       je       G_M12024_IG09
-       jmp      SHORT G_M12024_IG12
-						;; size=20 bbWeight=97.68 PerfScore 830.27
-G_M12024_IG20:
-       mov      r8d, dword ptr [r14+0x08]
-       cmp      r8d, dword ptr [r14+0x0C]
-       jae      G_M12024_IG35
-       mov      rdi, gword ptr [r14+0x10]
-       cmp      r8d, dword ptr [rdi+0x08]
-       jae      SHORT G_M12024_IG13
-       mov      edx, r8d
-       mov      r12d, dword ptr [rdi+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M12024_IG21
-       test     r12d, r12d
-       jl       SHORT G_M12024_IG23
-       jmp      SHORT G_M12024_IG22
-						;; size=55 bbWeight=0.99 PerfScore 21.46
-G_M12024_IG21:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       je       SHORT G_M12024_IG23
-						;; size=14 bbWeight=0.99 PerfScore 6.41
-G_M12024_IG22:
-       mov      r13d, r12d
-						;; size=3 bbWeight=0.99 PerfScore 0.25
-G_M12024_IG23:
-       cmp      qword ptr [r14], r15
-       jne      SHORT G_M12024_IG26
-       mov      eax, dword ptr [r14+0x08]
-       inc      eax
-       mov      esi, dword ptr [r14+0x0C]
-       cmp      eax, esi
-       jae      SHORT G_M12024_IG25
-						;; size=19 bbWeight=1.00 PerfScore 9.47
-G_M12024_IG24:
-       mov      dword ptr [r14+0x08], eax
-       jmp      SHORT G_M12024_IG20
-						;; size=6 bbWeight=0.99 PerfScore 2.96
-G_M12024_IG25:
-       mov      dword ptr [r14+0x08], esi
-       jmp      G_M12024_IG18
-						;; size=9 bbWeight=1.00 PerfScore 2.99
-G_M12024_IG26:
-       mov      rcx, r14
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M12024_IG36
-       jmp      G_M12024_IG18
-						;; size=29 bbWeight=1.00 PerfScore 6.73
-G_M12024_IG27:
-       mov      dword ptr [r14+0x08], esi
-       jmp      G_M12024_IG38
+       mov      dword ptr [r14+0x08], ecx
+       jmp      G_M12024_IG37
 						;; size=9 bbWeight=0.99 PerfScore 2.97
-G_M12024_IG28:
-       mov      r8d, dword ptr [r14+0x08]
-       cmp      r8d, dword ptr [r14+0x0C]
-       jae      G_M12024_IG37
-       mov      rdi, gword ptr [r14+0x10]
-       cmp      r8d, dword ptr [rdi+0x08]
-       jae      G_M12024_IG13
-       mov      edx, r8d
-       mov      r13d, dword ptr [rdi+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M12024_IG29
+G_M12024_IG20:
+       mov      edx, dword ptr [r14+0x08]
+       cmp      edx, dword ptr [r14+0x0C]
+       jae      G_M12024_IG31
+       mov      r8, gword ptr [r14+0x10]
+       cmp      edx, dword ptr [r8+0x08]
+       jae      SHORT G_M12024_IG14
+       mov      ecx, edx
+       mov      r13d, dword ptr [r8+4*rcx+0x10]
+       mov      rax, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rsi+0x18], rax
+       jne      SHORT G_M12024_IG13
        test     r13d, r13d
-       jl       SHORT G_M12024_IG30
-       mov      r12d, r13d
-       mov      r13d, r12d
-       jmp      G_M12024_IG08
-						;; size=68 bbWeight=0.01 PerfScore 0.22
-G_M12024_IG29:
-       mov      edx, r13d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M12024_IG08
-						;; size=18 bbWeight=0.01 PerfScore 0.07
-G_M12024_IG30:
+       jge      G_M12024_IG08
+						;; size=56 bbWeight=0.01 PerfScore 0.20
+G_M12024_IG21:
        mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [r14], r15
-       jne      SHORT G_M12024_IG33
+       jne      SHORT G_M12024_IG27
        mov      eax, dword ptr [r14+0x08]
        inc      eax
-       mov      esi, dword ptr [r14+0x0C]
-       cmp      eax, esi
-       jae      SHORT G_M12024_IG32
+       mov      ecx, dword ptr [r14+0x0C]
+       cmp      eax, ecx
+       jae      SHORT G_M12024_IG26
 						;; size=29 bbWeight=0.01 PerfScore 0.10
-G_M12024_IG31:
+G_M12024_IG22:
        mov      dword ptr [r14+0x08], eax
-       jmp      SHORT G_M12024_IG28
+       jmp      SHORT G_M12024_IG20
 						;; size=6 bbWeight=0.01 PerfScore 0.03
-G_M12024_IG32:
-       mov      dword ptr [r14+0x08], esi
-       jmp      SHORT G_M12024_IG38
-						;; size=6 bbWeight=0.01 PerfScore 0.03
-G_M12024_IG33:
+G_M12024_IG23:
+       mov      r13d, r12d
+						;; size=3 bbWeight=0.98 PerfScore 0.25
+G_M12024_IG24:
+       cmp      qword ptr [r14], r15
+       jne      G_M12024_IG35
+       mov      ecx, dword ptr [r14+0x08]
+       inc      ecx
+       mov      eax, dword ptr [r14+0x0C]
+       cmp      ecx, eax
+       jae      G_M12024_IG34
+						;; size=27 bbWeight=0.99 PerfScore 9.43
+G_M12024_IG25:
+       jmp      G_M12024_IG33
+						;; size=5 bbWeight=0.98 PerfScore 1.97
+G_M12024_IG26:
+       mov      dword ptr [r14+0x08], ecx
+       jmp      G_M12024_IG37
+						;; size=9 bbWeight=0.01 PerfScore 0.03
+G_M12024_IG27:
        mov      rcx, r14
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M12024_IG38
-						;; size=20 bbWeight=0.01 PerfScore 0.05
-G_M12024_IG34:
-       mov      rcx, r14
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       mov      r13d, eax
-       jmp      SHORT G_M12024_IG29
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M12024_IG35:
-       mov      ecx, dword ptr [r14+0x08]
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M12024_IG36:
+       jne      SHORT G_M12024_IG30
+       jmp      G_M12024_IG37
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M12024_IG28:
+       mov      edx, r12d
+       mov      rcx, gword ptr [rsi+0x08]
+       call     [rsi+0x18]<unknown method>
+       test     eax, eax
+       je       SHORT G_M12024_IG24
+       jmp      SHORT G_M12024_IG23
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M12024_IG29:
        mov      rcx, r14
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        mov      r12d, eax
-       jmp      G_M12024_IG21
+       jmp      SHORT G_M12024_IG28
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M12024_IG30:
+       mov      rcx, r14
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      r13d, eax
+       jmp      G_M12024_IG13
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M12024_IG37:
+G_M12024_IG31:
        mov      ecx, dword ptr [r14+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M12024_IG38:
+G_M12024_IG32:
+       mov      edx, dword ptr [r14+0x08]
+       cmp      edx, dword ptr [r14+0x0C]
+       jae      SHORT G_M12024_IG36
+       mov      rcx, gword ptr [r14+0x10]
+       cmp      edx, dword ptr [rcx+0x08]
+       jae      G_M12024_IG14
+       mov      eax, edx
+       mov      r12d, dword ptr [rcx+4*rax+0x10]
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [rsi+0x18], rcx
+       jne      SHORT G_M12024_IG28
+       test     r12d, r12d
+       jl       G_M12024_IG24
+       jmp      G_M12024_IG23
+						;; size=60 bbWeight=0.98 PerfScore 21.38
+G_M12024_IG33:
+       mov      dword ptr [r14+0x08], ecx
+       jmp      SHORT G_M12024_IG32
+						;; size=6 bbWeight=0.98 PerfScore 2.95
+G_M12024_IG34:
+       mov      dword ptr [r14+0x08], eax
+       jmp      G_M12024_IG18
+						;; size=9 bbWeight=0.99 PerfScore 2.98
+G_M12024_IG35:
+       mov      rcx, r14
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      G_M12024_IG29
+       jmp      G_M12024_IG18
+						;; size=29 bbWeight=0 PerfScore 0.00
+G_M12024_IG36:
+       mov      ecx, dword ptr [r14+0x08]
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M12024_IG37:
        mov      rcx, rsp
-       call     G_M12024_IG57
+       call     G_M12024_IG56
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M12024_IG39:
-       jmp      G_M12024_IG55
+G_M12024_IG38:
+       jmp      G_M12024_IG54
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M12024_IG40:
+G_M12024_IG39:
        cmp      qword ptr [r14], r15
-       jne      G_M12024_IG54
-						;; size=9 bbWeight=1.02 PerfScore 4.06
-G_M12024_IG41:
+       jne      G_M12024_IG53
+						;; size=9 bbWeight=1.01 PerfScore 4.06
+G_M12024_IG40:
        mov      eax, r13d
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M12024_IG42:
+G_M12024_IG41:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -1204,31 +1193,31 @@ G_M12024_IG42:
        pop      rbp
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M12024_IG43:
+G_M12024_IG42:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M12024_IG44:
+G_M12024_IG43:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M12024_IG45:
-       mov      rdx, rsi
+G_M12024_IG44:
+       mov      rdx, rbx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFCLASS
        mov      rcx, rax
        test     rcx, rcx
        je       G_M12024_IG03
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M12024_IG46:
-       mov      rdx, rbx
+G_M12024_IG45:
+       mov      rdx, rsi
        mov      r8, bword ptr [rbp+0x20]
        call     [<unknown method>]
        nop      
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M12024_IG47:
+G_M12024_IG46:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -1240,43 +1229,43 @@ G_M12024_IG47:
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12024_IG48:
-       mov      rdx, rsi
+G_M12024_IG47:
+       mov      rdx, rbx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov      rdi, rax
        test     rdi, rdi
        je       G_M12024_IG04
 						;; size=30 bbWeight=0 PerfScore 0.00
+G_M12024_IG48:
+       mov      rcx, rdi
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       lea      ebx, [rax-0x01]
+       test     ebx, ebx
+       jl       SHORT G_M12024_IG54
+						;; size=23 bbWeight=0 PerfScore 0.00
 G_M12024_IG49:
        mov      rcx, rdi
+       mov      edx, ebx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       lea      esi, [rax-0x01]
-       test     esi, esi
-       jl       SHORT G_M12024_IG55
-						;; size=23 bbWeight=0 PerfScore 0.00
-G_M12024_IG50:
-       mov      rcx, rdi
-       mov      edx, esi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       mov      r14d, eax
-       mov      edx, r14d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
+       mov      r13d, eax
+       mov      edx, r13d
+       mov      rcx, gword ptr [rsi+0x08]
+       call     [rsi+0x18]<unknown method>
        test     eax, eax
-       jne      SHORT G_M12024_IG51
-       dec      esi
-       jns      SHORT G_M12024_IG50
-       jmp      SHORT G_M12024_IG55
+       jne      SHORT G_M12024_IG50
+       dec      ebx
+       jns      SHORT G_M12024_IG49
+       jmp      SHORT G_M12024_IG54
 						;; size=41 bbWeight=0 PerfScore 0.00
-G_M12024_IG51:
+G_M12024_IG50:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 1
-       mov      eax, r14d
+       mov      eax, r13d
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M12024_IG52:
+G_M12024_IG51:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -1288,25 +1277,25 @@ G_M12024_IG52:
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12024_IG53:
-       mov      rcx, rsi
+G_M12024_IG52:
+       mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      r14, rax
        jmp      G_M12024_IG05
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M12024_IG54:
+G_M12024_IG53:
        mov      rcx, r14
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      G_M12024_IG41
+       jmp      G_M12024_IG40
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M12024_IG55:
+G_M12024_IG54:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M12024_IG56:
+G_M12024_IG55:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -1318,7 +1307,7 @@ G_M12024_IG56:
        pop      rbp
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M12024_IG57:
+G_M12024_IG56:
        push     rbp
        push     r15
        push     r14
@@ -1331,26 +1320,26 @@ G_M12024_IG57:
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x70]
-						;; size=29 bbWeight=0.00 PerfScore 0.03
-G_M12024_IG58:
+						;; size=29 bbWeight=0.00 PerfScore 0.04
+G_M12024_IG57:
        cmp      gword ptr [rbp-0x40], 0
-       je       SHORT G_M12024_IG61
+       je       SHORT G_M12024_IG60
 						;; size=7 bbWeight=0.00 PerfScore 0.01
-G_M12024_IG59:
+G_M12024_IG58:
        mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        mov      r14, gword ptr [rbp-0x40]
        cmp      qword ptr [r14], r15
-       je       SHORT G_M12024_IG61
-						;; size=19 bbWeight=0.00 PerfScore 0.01
-G_M12024_IG60:
+       je       SHORT G_M12024_IG60
+						;; size=19 bbWeight=0.00 PerfScore 0.02
+G_M12024_IG59:
        mov      rcx, r14
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M12024_IG61:
+G_M12024_IG60:
        nop      
 						;; size=1 bbWeight=0.00 PerfScore 0.00
-G_M12024_IG62:
+G_M12024_IG61:
        add      rsp, 40
        pop      rbx
        pop      rsi
@@ -1361,8 +1350,8 @@ G_M12024_IG62:
        pop      r15
        pop      rbp
        ret      
-						;; size=17 bbWeight=0.00 PerfScore 0.01
+						;; size=17 bbWeight=0.00 PerfScore 0.02
 
-; Total bytes of code 1184, prolog size 35, PerfScore 3872.03, instruction count 332, allocated bytes for code 1184 (MethodHash=9b95d107) for method System.Linq.Enumerable:TryGetLast[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 1166, prolog size 35, PerfScore 2599.88, instruction count 323, allocated bytes for code 1166 (MethodHash=9b95d107) for method System.Linq.Enumerable:TryGetLast[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.Zip(input: IEnumerable)``

Hot functions:

- (73.62%) ``System.Linq.Enumerable+<ZipIterator>d__336`3.MoveNext`` (Tier-1)
  - **Has diffs**
- (7.27%) ``ConsumerExtensions.Consume`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]System.Linq.Enumerable+<ZipIterator>d__336`3[System.Int32,System.Int32,System.Int32].MoveNext()``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2301440
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2164736
 ; 6 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T02] ( 23, 11.07)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Linq.Enumerable+<ZipIterator>d__336`3[int,int,int]>
-;  V01 loc0         [V01,T22] (  4,  2.00)   ubyte  ->  rax        
-;  V02 loc1         [V02,T17] (  3,  2.99)     int  ->  r11        
+;  V00 this         [V00,T00] ( 23, 11.14)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Linq.Enumerable+<ZipIterator>d__336`3[int,int,int]>
+;  V01 loc0         [V01,T21] (  4,  2.01)   ubyte  ->  rax        
+;  V02 loc1         [V02,T19] (  3,  2.99)     int  ->  r11        
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T11] (  4,  3.97)     ref  ->  rsi         class-hnd "impAppendStmt" <<unknown class>>
-;  V05 tmp2         [V05,T12] (  4,  3.97)     int  ->  rdi         "impAppendStmt"
-;  V06 tmp3         [V06,T13] (  4,  3.97)     int  ->   r8         "spilling ret_expr"
+;  V04 tmp1         [V04,T10] (  4,  4.01)     ref  ->  rbx         class-hnd "impAppendStmt" <<unknown class>>
+;  V05 tmp2         [V05,T11] (  4,  4.01)     int  ->  rdi         "impAppendStmt"
+;  V06 tmp3         [V06,T12] (  4,  4.01)     int  ->   r8         "spilling ret_expr"
 ;  V07 tmp4         [V07,T28] (  3,  0.02)     ref  ->  rax         "guarded devirt return temp"
 ;  V08 tmp5         [V08,T25] (  4,  0.06)     ref  ->  rdx         single-def "guarded devirt arg temp"
 ;* V09 tmp6         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;  V10 tmp7         [V10,T29] (  3,  0.02)     ref  ->  rax         "guarded devirt return temp"
 ;  V11 tmp8         [V11,T26] (  4,  0.06)     ref  ->  rax         single-def "guarded devirt arg temp"
 ;* V12 tmp9         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
-;  V13 tmp10        [V13,T04] (  6,  9.93)     ref  ->  rax         "guarded devirt arg temp"
+;  V13 tmp10        [V13,T04] (  6, 10.03)     ref  ->  rax         "guarded devirt arg temp"
 ;* V14 tmp11        [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V15 tmp12        [V15    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
-;  V16 tmp13        [V16,T03] (  7,  9.93)     ref  ->  rdx         "guarded devirt arg temp"
+;  V16 tmp13        [V16,T03] (  7, 10.03)     ref  ->  rax         "guarded devirt arg temp"
 ;* V17 tmp14        [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V18 tmp15        [V18,T23] (  3,  1.99)     int  ->   r8         "guarded devirt return temp"
+;  V18 tmp15        [V18,T22] (  3,  2.01)     int  ->   r8         "guarded devirt return temp"
 ;* V19 tmp16        [V19    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V20 tmp17        [V20,T10] (  2,  2.01)     int  ->  rax         "guarded devirt return temp"
-;  V21 tmp18        [V21,T00] (  7, 14.04)     ref  ->  r11         "guarded devirt arg temp"
+;  V20 tmp17        [V20,T20] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V21 tmp18        [V21,T01] (  7, 12.15)     ref  ->  rax         "guarded devirt arg temp"
 ;* V22 tmp19        [V22    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V23 tmp20        [V23,T14] (  2,  1.99)     int  ->  rax         "guarded devirt return temp"
-;  V24 tmp21        [V24,T01] (  7, 13.90)     ref  ->  r11         "guarded devirt arg temp"
+;  V23 tmp20        [V23,T23] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V24 tmp21        [V24,T02] (  7, 12.02)     ref  ->  rdx         "guarded devirt arg temp"
 ;* V25 tmp22        [V25    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V26 tmp23        [V26,T16] (  3,  3.01)     int  ->  rax         "Inline stloc first use temp"
-;  V27 tmp24        [V27,T21] (  3,  2.98)     int  ->  rax         "Inline stloc first use temp"
-;  V28 tmp25        [V28,T05] (  3,  5.96)     ref  ->  rdx         "arr expr"
-;  V29 tmp26        [V29,T07] (  3,  5.96)     int  ->   r8         "index expr"
-;  V30 tmp27        [V30,T06] (  3,  5.96)     ref  ->  r11         "arr expr"
-;  V31 tmp28        [V31,T08] (  3,  5.96)     int  ->   r8         "index expr"
+;  V26 tmp23        [V26,T14] (  3,  3.03)     int  ->  rdx         "Inline stloc first use temp"
+;  V27 tmp24        [V27,T18] (  3,  3.00)     int  ->  rax         "Inline stloc first use temp"
+;  V28 tmp25        [V28,T05] (  3,  6.02)     ref  ->  r11         "arr expr"
+;  V29 tmp26        [V29,T07] (  3,  6.02)     int  ->  rdx         "index expr"
+;  V30 tmp27        [V30,T06] (  3,  6.02)     ref  ->  r11         "arr expr"
+;  V31 tmp28        [V31,T08] (  3,  6.02)     int  ->  rdx         "index expr"
 ;  V32 PSPSym       [V32,T24] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
-;  V33 cse0         [V33,T15] (  3,  3.01)     int  ->  rdx         "CSE #05: moderate"
-;  V34 cse1         [V34,T18] (  4,  2.98)     int  ->   r8         "CSE #02: moderate"
-;  V35 cse2         [V35,T19] (  4,  2.98)     int  ->   r8         "CSE #04: moderate"
-;  V36 cse3         [V36,T20] (  3,  2.98)     int  ->  rdx         "CSE #06: moderate"
-;  V37 cse4         [V37,T09] (  5,  4.99)    long  ->  rbx         "CSE #03: aggressive"
+;  V33 cse0         [V33,T13] (  3,  3.04)     int  ->   r8         "CSE #05: moderate"
+;  V34 cse1         [V34,T15] (  4,  3.01)     int  ->  rdx         "CSE #02: moderate"
+;  V35 cse2         [V35,T16] (  4,  3.01)     int  ->  rdx         "CSE #04: moderate"
+;  V36 cse3         [V36,T17] (  3,  3.01)     int  ->   r8         "CSE #06: moderate"
+;  V37 cse4         [V37,T09] (  5,  5.03)    long  ->  rsi         "CSE #03: aggressive"
 ;  V38 cse5         [V38,T27] (  3,  0.03)    long  ->  rbx         "CSE #01: conservative"
 ;
 ; Lcl frame size = 40
@@ -558,39 +558,55 @@ G_M36067_IG01:
 G_M36067_IG02:
        mov      r11d, dword ptr [rcx+0x48]
        test     r11d, r11d
-       je       SHORT G_M36067_IG06
+       je       SHORT G_M36067_IG09
 						;; size=9 bbWeight=1 PerfScore 3.25
 G_M36067_IG03:
        cmp      r11d, 1
-       jne      G_M36067_IG24
-						;; size=10 bbWeight=0.99 PerfScore 1.24
+       jne      SHORT G_M36067_IG08
+						;; size=6 bbWeight=0.99 PerfScore 1.24
 G_M36067_IG04:
        mov      dword ptr [rcx+0x48], -4
-       mov      r11, gword ptr [rcx+0x38]
-       mov      rbx, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       cmp      qword ptr [r11], rbx
-       jne      G_M36067_IG20
-       mov      eax, dword ptr [r11+0x08]
-       inc      eax
-       mov      edx, dword ptr [r11+0x0C]
-       cmp      eax, edx
-       jae      G_M36067_IG09
-						;; size=48 bbWeight=1.00 PerfScore 12.79
+       mov      rax, gword ptr [rcx+0x38]
+       mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
+       cmp      qword ptr [rax], rsi
+       jne      G_M36067_IG23
+       mov      edx, dword ptr [rax+0x08]
+       inc      edx
+       mov      r8d, dword ptr [rax+0x0C]
+       cmp      edx, r8d
+       jae      G_M36067_IG12
+						;; size=48 bbWeight=1.01 PerfScore 12.92
 G_M36067_IG05:
-       mov      dword ptr [r11+0x08], eax
-       jmp      G_M36067_IG21
-						;; size=9 bbWeight=1.00 PerfScore 3.00
+       mov      dword ptr [rax+0x08], edx
+						;; size=3 bbWeight=1.01 PerfScore 1.01
 G_M36067_IG06:
+       mov      rdx, gword ptr [rcx+0x40]
+       cmp      qword ptr [rdx], rsi
+       jne      G_M36067_IG26
+       mov      eax, dword ptr [rdx+0x08]
+       inc      eax
+       mov      r8d, dword ptr [rdx+0x0C]
+       cmp      eax, r8d
+       jae      G_M36067_IG25
+						;; size=31 bbWeight=1.00 PerfScore 11.53
+G_M36067_IG07:
+       jmp      G_M36067_IG24
+						;; size=5 bbWeight=1.00 PerfScore 2.00
+G_M36067_IG08:
+       xor      eax, eax
+       jmp      G_M36067_IG29
+						;; size=7 bbWeight=0.00 PerfScore 0.00
+G_M36067_IG09:
        mov      dword ptr [rcx+0x48], -1
        mov      rdx, gword ptr [rcx+0x08]
        mov      rbx, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rdx], rbx
-       jne      SHORT G_M36067_IG10
+       jne      G_M36067_IG15
        mov      rcx, gword ptr [rdx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-						;; size=43 bbWeight=0.01 PerfScore 0.12
-G_M36067_IG07:
+						;; size=47 bbWeight=0.01 PerfScore 0.12
+G_M36067_IG10:
        mov      rcx, gword ptr [rbp+0x10]
        lea      rcx, bword ptr [rcx+0x38]
        mov      rdx, rax
@@ -599,12 +615,12 @@ G_M36067_IG07:
        mov      dword ptr [rcx+0x48], -3
        mov      rax, gword ptr [rcx+0x18]
        cmp      qword ptr [rax], rbx
-       jne      SHORT G_M36067_IG11
+       jne      SHORT G_M36067_IG16
        mov      rcx, gword ptr [rax+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=53 bbWeight=0.01 PerfScore 0.16
-G_M36067_IG08:
+G_M36067_IG11:
        mov      rcx, gword ptr [rbp+0x10]
        lea      rcx, bword ptr [rcx+0x40]
        mov      rdx, rax
@@ -612,133 +628,10 @@ G_M36067_IG08:
        mov      rcx, gword ptr [rbp+0x10]
        jmp      G_M36067_IG04
 						;; size=25 bbWeight=0.01 PerfScore 0.06
-G_M36067_IG09:
-       mov      dword ptr [r11+0x08], edx
-       jmp      G_M36067_IG26
-						;; size=9 bbWeight=1.00 PerfScore 3.01
-G_M36067_IG10:
-       mov      rcx, rdx
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       jmp      SHORT G_M36067_IG07
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M36067_IG11:
-       mov      rcx, rax
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       jmp      SHORT G_M36067_IG08
-						;; size=18 bbWeight=0 PerfScore 0.00
 G_M36067_IG12:
-       mov      rcx, gword ptr [rbp+0x10]
-       mov      rsi, gword ptr [rcx+0x28]
-       mov      rax, gword ptr [rcx+0x38]
-       cmp      qword ptr [rax], rbx
-       jne      G_M36067_IG18
-       mov      r8d, dword ptr [rax+0x08]
-       cmp      r8d, dword ptr [rax+0x0C]
-       jae      G_M36067_IG19
-       mov      rdx, gword ptr [rax+0x10]
-       cmp      r8d, dword ptr [rdx+0x08]
-       jae      SHORT G_M36067_IG14
-       mov      r11d, r8d
-       mov      edi, dword ptr [rdx+4*r11+0x10]
-       mov      rdx, gword ptr [rcx+0x40]
-       cmp      qword ptr [rdx], rbx
-       jne      SHORT G_M36067_IG16
-       mov      r8d, dword ptr [rdx+0x08]
-       cmp      r8d, dword ptr [rdx+0x0C]
-       jae      SHORT G_M36067_IG15
-       mov      r11, gword ptr [rdx+0x10]
-       cmp      r8d, dword ptr [r11+0x08]
-       jae      SHORT G_M36067_IG14
-       mov      eax, r8d
-       mov      r8d, dword ptr [r11+4*rax+0x10]
-       mov      r11, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<Zip>b__58_0(int,int):int:this
-       cmp      qword ptr [rsi+0x18], r11
-       jne      SHORT G_M36067_IG17
-       add      r8d, edi
-						;; size=109 bbWeight=0.99 PerfScore 47.68
+       mov      dword ptr [rax+0x08], r8d
+						;; size=4 bbWeight=1.01 PerfScore 1.01
 G_M36067_IG13:
-       mov      dword ptr [rcx+0x4C], r8d
-       mov      dword ptr [rcx+0x48], 1
-       mov      eax, 1
-       jmp      G_M36067_IG27
-						;; size=21 bbWeight=0.99 PerfScore 4.22
-G_M36067_IG14:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M36067_IG15:
-       mov      ecx, r8d
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M36067_IG16:
-       mov      rcx, rdx
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       mov      r8d, eax
-						;; size=19 bbWeight=0 PerfScore 0.00
-G_M36067_IG17:
-       mov      edx, edi
-       mov      rcx, gword ptr [rsi+0x08]
-       call     [rsi+0x18]<unknown method>
-       mov      r8d, eax
-       mov      rcx, gword ptr [rbp+0x10]
-       jmp      SHORT G_M36067_IG13
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M36067_IG18:
-       mov      rcx, rax
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       mov      edi, eax
-       mov      rbx, gword ptr [rbp+0x10]
-       mov      rdx, gword ptr [rbx+0x40]
-       jmp      SHORT G_M36067_IG16
-						;; size=28 bbWeight=0 PerfScore 0.00
-G_M36067_IG19:
-       mov      ecx, r8d
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M36067_IG20:
-       mov      rcx, r11
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       je       SHORT G_M36067_IG26
-						;; size=20 bbWeight=1.00 PerfScore 4.77
-G_M36067_IG21:
-       mov      rcx, gword ptr [rbp+0x10]
-       mov      r11, gword ptr [rcx+0x40]
-       cmp      qword ptr [r11], rbx
-       jne      SHORT G_M36067_IG25
-       mov      eax, dword ptr [r11+0x08]
-       inc      eax
-       mov      edx, dword ptr [r11+0x0C]
-       cmp      eax, edx
-       jae      SHORT G_M36067_IG23
-						;; size=27 bbWeight=0.99 PerfScore 12.42
-G_M36067_IG22:
-       mov      dword ptr [r11+0x08], eax
-       jmp      G_M36067_IG12
-						;; size=9 bbWeight=0.99 PerfScore 2.97
-G_M36067_IG23:
-       mov      dword ptr [r11+0x08], edx
-       jmp      SHORT G_M36067_IG26
-						;; size=6 bbWeight=0.99 PerfScore 2.98
-G_M36067_IG24:
-       xor      eax, eax
-       jmp      SHORT G_M36067_IG27
-						;; size=4 bbWeight=0.00 PerfScore 0.00
-G_M36067_IG25:
-       mov      rcx, r11
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M36067_IG12
-						;; size=24 bbWeight=0.99 PerfScore 4.72
-G_M36067_IG26:
-       mov      rcx, gword ptr [rbp+0x10]
        call     [System.Linq.Enumerable+<ZipIterator>d__336`3[int,int,int]:<>m__Finally2():this]
        xor      rcx, rcx
        mov      rbx, gword ptr [rbp+0x10]
@@ -747,8 +640,120 @@ G_M36067_IG26:
        call     [System.Linq.Enumerable+<ZipIterator>d__336`3[int,int,int]:<>m__Finally1():this]
        xor      rax, rax
        mov      gword ptr [rbx+0x38], rax
-						;; size=35 bbWeight=0.01 PerfScore 0.11
+						;; size=31 bbWeight=0.01 PerfScore 0.10
+G_M36067_IG14:
+       jmp      G_M36067_IG29
+						;; size=5 bbWeight=0.01 PerfScore 0.02
+G_M36067_IG15:
+       mov      rcx, rdx
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       jmp      G_M36067_IG10
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M36067_IG16:
+       mov      rcx, rax
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       jmp      SHORT G_M36067_IG11
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M36067_IG17:
+       mov      rbx, gword ptr [rcx+0x28]
+       mov      rax, gword ptr [rcx+0x38]
+       cmp      qword ptr [rax], rsi
+       jne      G_M36067_IG27
+       mov      edx, dword ptr [rax+0x08]
+       cmp      edx, dword ptr [rax+0x0C]
+       jae      G_M36067_IG28
+       mov      r11, gword ptr [rax+0x10]
+       cmp      edx, dword ptr [r11+0x08]
+       jae      SHORT G_M36067_IG19
+       mov      eax, edx
+       mov      edi, dword ptr [r11+4*rax+0x10]
+       mov      rax, gword ptr [rcx+0x40]
+       cmp      qword ptr [rax], rsi
+       jne      SHORT G_M36067_IG21
+       mov      edx, dword ptr [rax+0x08]
+       cmp      edx, dword ptr [rax+0x0C]
+       jae      SHORT G_M36067_IG20
+       mov      r11, gword ptr [rax+0x10]
+       cmp      edx, dword ptr [r11+0x08]
+       jae      SHORT G_M36067_IG19
+       mov      eax, edx
+       mov      r8d, dword ptr [r11+4*rax+0x10]
+       mov      r11, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<Zip>b__58_0(int,int):int:this
+       cmp      qword ptr [rbx+0x18], r11
+       jne      SHORT G_M36067_IG22
+       add      r8d, edi
+						;; size=99 bbWeight=1.00 PerfScore 47.13
+G_M36067_IG18:
+       mov      dword ptr [rcx+0x4C], r8d
+       mov      dword ptr [rcx+0x48], 1
+       mov      eax, 1
+       jmp      G_M36067_IG29
+						;; size=21 bbWeight=1.00 PerfScore 4.26
+G_M36067_IG19:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M36067_IG20:
+       mov      ecx, edx
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M36067_IG21:
+       mov      rcx, rax
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       mov      r8d, eax
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M36067_IG22:
+       mov      edx, edi
+       mov      rcx, gword ptr [rbx+0x08]
+       call     [rbx+0x18]<unknown method>
+       mov      r8d, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       jmp      SHORT G_M36067_IG18
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M36067_IG23:
+       mov      rcx, rax
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       je       G_M36067_IG13
+       jmp      G_M36067_IG06
+						;; size=33 bbWeight=0 PerfScore 0.00
+G_M36067_IG24:
+       mov      dword ptr [rdx+0x08], eax
+       jmp      G_M36067_IG17
+						;; size=8 bbWeight=1.00 PerfScore 2.99
+G_M36067_IG25:
+       mov      dword ptr [rdx+0x08], r8d
+       jmp      G_M36067_IG13
+						;; size=9 bbWeight=1.00 PerfScore 3.01
+G_M36067_IG26:
+       mov      rcx, rdx
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       jne      G_M36067_IG17
+       jmp      G_M36067_IG13
+						;; size=33 bbWeight=0 PerfScore 0.00
 G_M36067_IG27:
+       mov      rcx, rax
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       mov      edi, eax
+       mov      rsi, gword ptr [rbp+0x10]
+       mov      rax, gword ptr [rsi+0x40]
+       jmp      G_M36067_IG21
+						;; size=31 bbWeight=0 PerfScore 0.00
+G_M36067_IG28:
+       mov      ecx, edx
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M36067_IG29:
        add      rsp, 40
        pop      rbx
        pop      rsi
@@ -756,7 +761,7 @@ G_M36067_IG27:
        pop      rbp
        ret      
 						;; size=9 bbWeight=1 PerfScore 3.25
-G_M36067_IG28:
+G_M36067_IG30:
        push     rbp
        push     rdi
        push     rsi
@@ -766,12 +771,12 @@ G_M36067_IG28:
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x40]
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M36067_IG29:
+G_M36067_IG31:
        mov      rcx, gword ptr [rbp+0x10]
        call     [<unknown method>]
        nop      
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M36067_IG30:
+G_M36067_IG32:
        add      rsp, 40
        pop      rbx
        pop      rsi
@@ -780,6 +785,6 @@ G_M36067_IG30:
        ret      
 						;; size=9 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 658, prolog size 21, PerfScore 113.49, instruction count 174, allocated bytes for code 658 (MethodHash=5ec8731c) for method System.Linq.Enumerable+<ZipIterator>d__336`3[int,int,int]:MoveNext():ubyte:this (Tier1)
+; Total bytes of code 678, prolog size 21, PerfScore 100.81, instruction count 175, allocated bytes for code 678 (MethodHash=5ec8731c) for method System.Linq.Enumerable+<ZipIterator>d__336`3[int,int,int]:MoveNext():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.WhereSelect(input: Array)``

Hot functions:

- (84.61%) ``ConsumerExtensions.Consume`` (Tier-1)
  - **Has diffs**
- (1.72%) ``CastHelpers.IsInstanceOfClass`` (Tier-1)
  - No diffs
- (1.03%) ``Perf_Enumerable.WhereSelect`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[BenchmarkDotNet]ConsumerExtensions.Consume(class System.Collections.Generic.IEnumerable`1<!!0>,class BenchmarkDotNet.Engines.Consumer)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 34888
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 33672
 ; 2 inlinees with PGO data; 5 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T14] (  8,  6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T12] (  4,102.41)     ref  ->  rbx         class-hnd single-def <BenchmarkDotNet.Engines.Consumer>
-;  V02 loc0         [V02,T08] ( 19,208.88)     ref  ->  [rbp-0x40]  class-hnd EH-live spill-single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V00 arg0         [V00,T13] (  8,  6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T11] (  4,101.78)     ref  ->  rbx         class-hnd single-def <BenchmarkDotNet.Engines.Consumer>
+;  V02 loc0         [V02,T08] ( 19,206.56)     ref  ->  [rbp-0x40]  class-hnd EH-live spill-single-def <System.Collections.Generic.IEnumerator`1[int]>
 ;* V03 loc1         [V03    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T18] (  3,  2   )     ref  ->  rcx         "guarded devirt return temp"
+;  V05 tmp1         [V05,T17] (  3,  2   )     ref  ->  rcx         "guarded devirt return temp"
 ;* V06 tmp2         [V06    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]>
-;  V07 tmp3         [V07,T09] (  5,200.82)     int  ->  r15         "guarded devirt return temp"
+;  V07 tmp3         [V07,T09] (  5,199.56)     int  ->  rax         "guarded devirt return temp"
 ;* V08 tmp4         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]>
-;  V09 tmp5         [V09,T13] (  2,  2.03)     int  ->  rax         "guarded devirt return temp"
-;  V10 tmp6         [V10,T00] ( 20,808.26)     ref  ->  r14         class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]>
+;  V09 tmp5         [V09,T12] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp6         [V10,T00] ( 20,803.21)     ref  ->  r14         class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]>
 ;* V11 tmp7         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]>
-;  V12 tmp8         [V12,T17] (  4,  3   )     ref  ->  rsi        
+;  V12 tmp8         [V12,T16] (  4,  3   )     ref  ->  rsi        
 ;* V13 tmp9         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.Linq.Enumerable+Iterator`1[int]>
 ;* V14 tmp10        [V14    ] (  0,  0   )     int  ->  zero-ref    "non-inline candidate call"
-;  V15 tmp11        [V15,T02] ( 12,605.44)     int  ->  rsi         "Inline stloc first use temp"
-;  V16 tmp12        [V16,T06] (  6,303.22)     ref  ->  r15         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V17 tmp13        [V17,T03] ( 10,401.61)     int  ->  r12         "Inline stloc first use temp"
-;  V18 tmp14        [V18,T07] (  6,301.21)     int  ->  rsi         "Inline stloc first use temp"
-;  V19 tmp15        [V19,T11] (  4,200.80)     int  ->  rax         "guarded devirt return temp"
-;  V20 tmp16        [V20,T01] (  8,803.22)     ref  ->  rax         "guarded devirt arg temp"
+;  V15 tmp11        [V15,T01] ( 12,601.65)     int  ->  r15         "Inline stloc first use temp"
+;  V16 tmp12        [V16,T05] (  6,301.33)     ref  ->  r13         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V17 tmp13        [V17,T06] ( 10,299.31)     int  ->  rsi         "Inline stloc first use temp"
+;  V18 tmp14        [V18,T07] (  6,299.31)     int  ->  r15         "Inline stloc first use temp"
+;  V19 tmp15        [V19,T19] (  4,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V20 tmp16        [V20,T02] (  8,399.08)     ref  ->  rax         "guarded devirt arg temp"
 ;* V21 tmp17        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V22 tmp18        [V22,T10] (  6,200.80)     int  ->  r12         "guarded devirt return temp"
-;  V23 tmp19        [V23,T04] (  8,401.61)     ref  ->  rsi         "guarded devirt arg temp"
+;  V22 tmp18        [V22,T10] (  6,199.54)     int  ->  rsi         "guarded devirt return temp"
+;  V23 tmp19        [V23,T03] (  8,399.08)     ref  ->  r12         "guarded devirt arg temp"
 ;* V24 tmp20        [V24    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V25 PSPSym       [V25,T19] (  1,  1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
-;  V26 cse0         [V26,T05] (  4,400.59)     int  ->  r13         "CSE #03: aggressive"
-;  V27 cse1         [V27,T15] (  7,  5.02)    long  ->  rdi         multi-def "CSE #01: aggressive"
-;  V28 cse2         [V28,T16] (  4,  4.05)     int  ->  r13         "CSE #04: moderate"
+;  V25 PSPSym       [V25,T18] (  1,  1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
+;  V26 cse0         [V26,T04] (  4,398.09)     int  ->  r12         "CSE #03: aggressive"
+;  V27 cse1         [V27,T14] (  7,  5.01)    long  ->  rdi         multi-def "CSE #01: moderate"
+;  V28 cse2         [V28,T15] (  4,  4.02)     int  ->  r12         "CSE #04: moderate"
 ;
 ; Lcl frame size = 56
 
@@ -369,13 +369,13 @@ G_M32802_IG01:
 G_M32802_IG02:
        mov      rdi, 0xD1FFAB1E      ; System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]
        cmp      qword ptr [rsi], rdi
-       jne      G_M32802_IG33
-       cmp      dword ptr [rsi+0x0C], 0
        jne      G_M32802_IG32
+       cmp      dword ptr [rsi+0x0C], 0
+       jne      G_M32802_IG31
        mov      r14d, dword ptr [rsi+0x08]
        call     <unknown method>
        cmp      r14d, eax
-       jne      G_M32802_IG32
+       jne      G_M32802_IG31
 						;; size=47 bbWeight=1 PerfScore 12.50
 G_M32802_IG03:
        mov      dword ptr [rsi+0x0C], 1
@@ -386,175 +386,173 @@ G_M32802_IG04:
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M32802_IG05:
        test     rcx, rcx
-       je       G_M32802_IG21
+       je       G_M32802_IG22
        cmp      qword ptr [rcx], rdi
-       jne      G_M32802_IG21
+       jne      G_M32802_IG22
        jmp      SHORT G_M32802_IG07
 						;; size=20 bbWeight=1 PerfScore 7.25
 G_M32802_IG06:
-       mov      rcx, gword ptr [rbp-0x40]
-       mov      r15d, dword ptr [rcx+0x10]
-       mov      dword ptr [rbx+0x38], r15d
-       mov      rcx, gword ptr [rbp-0x40]
-						;; size=16 bbWeight=99.41 PerfScore 497.03
+       mov      eax, dword ptr [rcx+0x10]
+       mov      dword ptr [rbx+0x38], eax
+						;; size=6 bbWeight=98.78 PerfScore 296.34
 G_M32802_IG07:
        mov      r14, rcx
-       mov      esi, dword ptr [r14+0x0C]
-       dec      esi
-       mov      r15, gword ptr [r14+0x18]
-       mov      r13d, dword ptr [r15+0x08]
-       cmp      r13d, esi
-       jbe      G_M32802_IG18
-						;; size=26 bbWeight=100.40 PerfScore 778.07
+       mov      r15d, dword ptr [r14+0x0C]
+       dec      r15d
+       mov      r13, gword ptr [r14+0x18]
+       mov      r12d, dword ptr [r13+0x08]
+       cmp      r12d, r15d
+       jbe      G_M32802_IG19
+						;; size=27 bbWeight=99.77 PerfScore 773.22
 G_M32802_IG08:
-       cmp      esi, r13d
-       jae      SHORT G_M32802_IG12
-       mov      edx, esi
-       mov      r12d, dword ptr [r15+4*rdx+0x10]
-       mov      esi, dword ptr [r14+0x0C]
-       lea      edx, [rsi+0x01]
-       mov      dword ptr [r14+0x0C], edx
+       cmp      r15d, r12d
+       jae      SHORT G_M32802_IG11
+       mov      eax, r15d
+       mov      esi, dword ptr [r13+4*rax+0x10]
+       mov      r15d, dword ptr [r14+0x0C]
+       lea      eax, [r15+0x01]
+       mov      dword ptr [r14+0x0C], eax
        mov      rax, gword ptr [r14+0x20]
        mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereSelect>b__6_0(int):ubyte:this
        cmp      qword ptr [rax+0x18], rdx
-       jne      SHORT G_M32802_IG16
-						;; size=43 bbWeight=99.40 PerfScore 1317.03
+       jne      G_M32802_IG17
+       test     esi, esi
+       jl       G_M32802_IG18
+						;; size=57 bbWeight=98.77 PerfScore 1432.21
 G_M32802_IG09:
-       test     r12d, r12d
-       jl       SHORT G_M32802_IG17
-						;; size=5 bbWeight=99.40 PerfScore 124.25
-G_M32802_IG10:
-       mov      rsi, gword ptr [r14+0x28]
+       mov      r12, gword ptr [r14+0x28]
        mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereSelect>b__6_1(int):int:this
-       cmp      qword ptr [rsi+0x18], rax
-       jne      SHORT G_M32802_IG13
-       inc      r12d
-						;; size=23 bbWeight=99.40 PerfScore 646.09
-G_M32802_IG11:
-       mov      dword ptr [r14+0x10], r12d
+       cmp      qword ptr [r12+0x18], rax
+       jne      SHORT G_M32802_IG12
+       inc      esi
+						;; size=23 bbWeight=98.77 PerfScore 642.03
+G_M32802_IG10:
+       mov      dword ptr [r14+0x10], esi
        jmp      SHORT G_M32802_IG06
-						;; size=6 bbWeight=99.40 PerfScore 298.19
-G_M32802_IG12:
+						;; size=6 bbWeight=98.77 PerfScore 296.32
+G_M32802_IG11:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
+G_M32802_IG12:
+       mov      edx, esi
+       mov      rcx, gword ptr [r12+0x08]
+       call     [r12+0x18]<unknown method>
+       mov      esi, eax
+       mov      rcx, gword ptr [rbp-0x40]
+       jmp      SHORT G_M32802_IG10
+						;; size=20 bbWeight=0 PerfScore 0.00
 G_M32802_IG13:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rsi+0x08]
-       call     [rsi+0x18]<unknown method>
-       mov      r12d, eax
-       jmp      SHORT G_M32802_IG11
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M32802_IG14:
        mov      rcx, gword ptr [rbp-0x40]
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-       mov      r15d, eax
+       jmp      G_M32802_IG21
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M32802_IG14:
+       mov      edx, esi
+       mov      rcx, gword ptr [r12+0x08]
+       call     [r12+0x18]<unknown method>
+       mov      esi, eax
        mov      rcx, gword ptr [rbp-0x40]
-       jmp      SHORT G_M32802_IG20
-						;; size=26 bbWeight=0 PerfScore 0.00
+       jmp      G_M32802_IG25
+						;; size=23 bbWeight=0 PerfScore 0.00
 G_M32802_IG15:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rsi+0x08]
-       call     [rsi+0x18]<unknown method>
-       mov      r12d, eax
-       jmp      G_M32802_IG28
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M32802_IG16:
-       mov      edx, r12d
+       mov      edx, esi
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
        test     eax, eax
-       jne      SHORT G_M32802_IG10
-						;; size=14 bbWeight=99.40 PerfScore 646.09
-G_M32802_IG17:
-       cmp      r13d, esi
-       ja       G_M32802_IG08
-						;; size=9 bbWeight=100.40 PerfScore 125.49
-G_M32802_IG18:
-       xor      edx, edx
-       mov      dword ptr [r14+0x10], edx
-       mov      dword ptr [r14+0x0C], -1
-       jmp      G_M32802_IG30
-						;; size=19 bbWeight=1.00 PerfScore 4.24
-G_M32802_IG19:
        mov      rcx, gword ptr [rbp-0x40]
-       mov      r15d, dword ptr [rcx+0x10]
-						;; size=8 bbWeight=1.00 PerfScore 3.01
-G_M32802_IG20:
-       mov      dword ptr [rbx+0x38], r15d
-						;; size=4 bbWeight=1.00 PerfScore 1.00
-G_M32802_IG21:
-       cmp      qword ptr [rcx], rdi
-       jne      G_M32802_IG29
-       mov      r14, rcx
-       mov      esi, dword ptr [r14+0x0C]
-       dec      esi
-       mov      r15, gword ptr [r14+0x18]
-       mov      r13d, dword ptr [r15+0x08]
-       cmp      r13d, esi
-       jbe      SHORT G_M32802_IG26
-						;; size=31 bbWeight=1.01 PerfScore 11.92
-G_M32802_IG22:
-       cmp      esi, r13d
-       jae      G_M32802_IG12
+       jne      G_M32802_IG24
+       jmp      G_M32802_IG26
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M32802_IG16:
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M32802_IG13
+       mov      rcx, gword ptr [rbp-0x40]
+       jmp      G_M32802_IG28
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M32802_IG17:
        mov      edx, esi
-       mov      r12d, dword ptr [r15+4*rdx+0x10]
-       mov      esi, dword ptr [r14+0x0C]
-       lea      edx, [rsi+0x01]
-       mov      dword ptr [r14+0x0C], edx
+       mov      rcx, gword ptr [rax+0x08]
+       call     [rax+0x18]<unknown method>
+       test     eax, eax
+       mov      rcx, gword ptr [rbp-0x40]
+       jne      G_M32802_IG09
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M32802_IG18:
+       cmp      r12d, r15d
+       ja       G_M32802_IG08
+						;; size=9 bbWeight=99.77 PerfScore 124.71
+G_M32802_IG19:
+       xor      eax, eax
+       mov      dword ptr [r14+0x10], eax
+       mov      dword ptr [r14+0x0C], -1
+       jmp      G_M32802_IG28
+						;; size=19 bbWeight=1.00 PerfScore 4.24
+G_M32802_IG20:
+       mov      eax, dword ptr [rcx+0x10]
+						;; size=3 bbWeight=1.00 PerfScore 2.00
+G_M32802_IG21:
+       mov      dword ptr [rbx+0x38], eax
+       mov      rcx, gword ptr [rbp-0x40]
+						;; size=7 bbWeight=1.00 PerfScore 2.00
+G_M32802_IG22:
+       cmp      qword ptr [rcx], rdi
+       jne      SHORT G_M32802_IG16
+       mov      r14, rcx
+       mov      r15d, dword ptr [r14+0x0C]
+       dec      r15d
+       mov      r13, gword ptr [r14+0x18]
+       mov      r12d, dword ptr [r13+0x08]
+       cmp      r12d, r15d
+       jbe      SHORT G_M32802_IG27
+						;; size=28 bbWeight=1.01 PerfScore 11.84
+G_M32802_IG23:
+       cmp      r15d, r12d
+       jae      G_M32802_IG11
+       mov      eax, r15d
+       mov      esi, dword ptr [r13+4*rax+0x10]
+       mov      r15d, dword ptr [r14+0x0C]
+       lea      eax, [r15+0x01]
+       mov      dword ptr [r14+0x0C], eax
        mov      rax, gword ptr [r14+0x20]
        mov      rdx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rax+0x18], rdx
-       jne      SHORT G_M32802_IG24
-						;; size=47 bbWeight=1.00 PerfScore 13.30
-G_M32802_IG23:
-       test     r12d, r12d
-       jl       SHORT G_M32802_IG25
-       jmp      SHORT G_M32802_IG27
-						;; size=7 bbWeight=1.00 PerfScore 3.26
-G_M32802_IG24:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rax+0x08]
-       call     [rax+0x18]<unknown method>
-       test     eax, eax
-       jne      SHORT G_M32802_IG27
-						;; size=14 bbWeight=1.00 PerfScore 6.53
-G_M32802_IG25:
-       cmp      r13d, esi
-       ja       SHORT G_M32802_IG22
-						;; size=5 bbWeight=1.01 PerfScore 1.27
-G_M32802_IG26:
-       xor      r11d, r11d
-       mov      dword ptr [r14+0x10], r11d
-       mov      dword ptr [r14+0x0C], -1
-       jmp      SHORT G_M32802_IG30
-						;; size=17 bbWeight=0.01 PerfScore 0.04
-G_M32802_IG27:
-       mov      rsi, gword ptr [r14+0x28]
-       mov      r11, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rsi+0x18], r11
        jne      G_M32802_IG15
-       inc      r12d
-						;; size=27 bbWeight=1.00 PerfScore 6.53
-G_M32802_IG28:
-       mov      dword ptr [r14+0x10], r12d
-       jmp      G_M32802_IG19
-						;; size=9 bbWeight=1.00 PerfScore 3.01
-G_M32802_IG29:
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
+       test     esi, esi
+       jl       SHORT G_M32802_IG26
+						;; size=57 bbWeight=1.00 PerfScore 14.47
+G_M32802_IG24:
+       mov      r12, gword ptr [r14+0x28]
+       mov      rax, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r12+0x18], rax
        jne      G_M32802_IG14
-						;; size=21 bbWeight=1.01 PerfScore 4.56
-G_M32802_IG30:
-       mov      rcx, gword ptr [rbp-0x40]
+       inc      esi
+						;; size=27 bbWeight=1.00 PerfScore 6.49
+G_M32802_IG25:
+       mov      dword ptr [r14+0x10], esi
+       jmp      SHORT G_M32802_IG20
+						;; size=6 bbWeight=1.00 PerfScore 2.99
+G_M32802_IG26:
+       cmp      r12d, r15d
+       ja       SHORT G_M32802_IG23
+						;; size=5 bbWeight=1.01 PerfScore 1.26
+G_M32802_IG27:
+       xor      eax, eax
+       mov      dword ptr [r14+0x10], eax
+       mov      dword ptr [r14+0x0C], -1
+						;; size=14 bbWeight=0.01 PerfScore 0.02
+G_M32802_IG28:
        cmp      qword ptr [rcx], rdi
-       jne      SHORT G_M32802_IG34
+       jne      SHORT G_M32802_IG33
+						;; size=5 bbWeight=1 PerfScore 4.00
+G_M32802_IG29:
        xor      eax, eax
        mov      dword ptr [rcx+0x10], eax
        mov      dword ptr [rcx+0x0C], -1
-						;; size=21 bbWeight=1.01 PerfScore 7.32
-G_M32802_IG31:
+						;; size=12 bbWeight=1.00 PerfScore 2.24
+G_M32802_IG30:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -566,25 +564,25 @@ G_M32802_IG31:
        pop      rbp
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M32802_IG32:
+G_M32802_IG31:
        mov      rcx, rsi
        call     [System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]:Clone():System.Linq.Enumerable+Iterator`1[int]:this]
        mov      rsi, rax
        jmp      G_M32802_IG03
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M32802_IG33:
+G_M32802_IG32:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, rax
        jmp      G_M32802_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M32802_IG34:
+G_M32802_IG33:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M32802_IG31
+       jmp      SHORT G_M32802_IG30
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M32802_IG35:
+G_M32802_IG34:
        push     rbp
        push     r15
        push     r14
@@ -598,26 +596,26 @@ G_M32802_IG35:
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x70]
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M32802_IG36:
+G_M32802_IG35:
        cmp      gword ptr [rbp-0x40], 0
-       je       SHORT G_M32802_IG38
+       je       SHORT G_M32802_IG37
        mov      rdi, 0xD1FFAB1E      ; System.Linq.Enumerable+WhereSelectArrayIterator`2[int,int]
        mov      rcx, gword ptr [rbp-0x40]
        cmp      qword ptr [rcx], rdi
-       jne      SHORT G_M32802_IG37
+       jne      SHORT G_M32802_IG36
        xor      r11d, r11d
        mov      dword ptr [rcx+0x10], r11d
        mov      dword ptr [rcx+0x0C], -1
-       jmp      SHORT G_M32802_IG38
+       jmp      SHORT G_M32802_IG37
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M32802_IG37:
+G_M32802_IG36:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M32802_IG38:
+G_M32802_IG37:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M32802_IG39:
+G_M32802_IG38:
        add      rsp, 40
        pop      rbx
        pop      rsi
@@ -630,6 +628,6 @@ G_M32802_IG39:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 723, prolog size 31, PerfScore 4535.73, instruction count 200, allocated bytes for code 723 (MethodHash=95f57fdd) for method BenchmarkDotNet.Engines.ConsumerExtensions:Consume[int](System.Collections.Generic.IEnumerable`1[int],BenchmarkDotNet.Engines.Consumer) (Tier1)
+; Total bytes of code 741, prolog size 31, PerfScore 3653.88, instruction count 200, allocated bytes for code 741 (MethodHash=95f57fdd) for method BenchmarkDotNet.Engines.ConsumerExtensions:Consume[int](System.Collections.Generic.IEnumerable`1[int],BenchmarkDotNet.Engines.Consumer) (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.AnyWithPredicate_LastElementMatches(input: IEnumerable)``

Hot functions:

- (89.18%) ``Enumerable.Any`` (Tier-1)
  - **Has diffs**
- (1.38%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (1.28%) ``Perf_Enumerable.AnyWithPredicate_LastElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.Any(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 59176
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 60128
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T10] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] (  9,304.24)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 loc0         [V02,T00] ( 27,707.93)     ref  ->  [rbp-0x30]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V03 loc1         [V03,T04] (  7,301.24)     int  ->  rdx        
-;* V04 loc2         [V04,T15] (  0,  0   )   ubyte  ->  zero-ref   
+;  V00 arg0         [V00,T09] (  6,  5   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] (  7,  5.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 loc0         [V02,T00] ( 27,706.15)     ref  ->  [rbp-0x20]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V03 loc1         [V03,T06] (  6,200.61)     int  ->  rdx        
+;* V04 loc2         [V04,T14] (  0,  0   )   ubyte  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T14] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V06 tmp1         [V06,T13] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V08 tmp3         [V08    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V09 tmp4         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V10 tmp5         [V10,T09] (  4,200.83)     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp5         [V10,T16] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V11 tmp6         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V12 tmp7         [V12,T08] (  2,  2.01)     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp7         [V12,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V13 tmp8         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V14 tmp9         [V14    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V15 tmp10        [V15,T05] (  6,301.24)     int  ->  rax         "Inline stloc first use temp"
-;  V16 tmp11        [V16,T01] (  6,602.48)     ref  ->  r15         "arr expr"
-;  V17 tmp12        [V17,T02] (  6,602.48)     int  ->   r8         "index expr"
-;  V18 PSPSym       [V18,T16] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V19 cse0         [V19,T06] (  3,298.23)     int  ->   r8         "CSE #03: aggressive"
-;  V20 cse1         [V20,T07] (  3,298.23)     int  ->  r14         "CSE #04: aggressive"
-;  V21 cse2         [V21,T12] (  3,  3.01)     int  ->   r8         "CSE #05: aggressive"
-;  V22 cse3         [V22,T13] (  3,  3.01)     int  ->  r14         "CSE #07: aggressive"
-;  V23 cse4         [V23,T11] (  7,  4.03)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
+;  V15 tmp10        [V15,T03] (  6,300.91)     int  ->  rdx         "Inline stloc first use temp"
+;  V16 tmp11        [V16,T01] (  6,601.82)     ref  ->  registers   "arr expr"
+;  V17 tmp12        [V17,T02] (  6,601.82)     int  ->   r8         "index expr"
+;  V18 PSPSym       [V18,T15] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V19 cse0         [V19,T04] (  3,297.90)     int  ->   r8         "CSE #03: aggressive"
+;  V20 cse1         [V20,T05] (  3,297.90)     int  ->  rax         "CSE #04: aggressive"
+;  V21 cse2         [V21,T11] (  3,  3.01)     int  ->   r8         "CSE #05: aggressive"
+;  V22 cse3         [V22,T12] (  3,  3.01)     int  ->  rcx         "CSE #07: aggressive"
+;  V23 cse4         [V23,T10] (  7,  4.02)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 56
 
 G_M16263_IG01:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 56
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      rbx, rdx
-						;; size=24 bbWeight=1 PerfScore 8.00
+						;; size=20 bbWeight=1 PerfScore 6.00
 G_M16263_IG02:
        test     rcx, rcx
-       je       G_M16263_IG25
+       je       G_M16263_IG23
        test     rbx, rbx
-       je       G_M16263_IG26
+       je       G_M16263_IG24
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M16263_IG27
+       jne      G_M16263_IG25
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
 						;; size=57 bbWeight=1 PerfScore 12.25
 G_M16263_IG03:
-       mov      gword ptr [rbp-0x30], rsi
+       mov      gword ptr [rbp-0x20], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M16263_IG04:
        test     rsi, rsi
@@ -765,211 +763,196 @@ G_M16263_IG04:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rsi], rdi
        jne      SHORT G_M16263_IG11
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<AnyWithPredicate_LastElementMatches>b__14_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M16263_IG11
        jmp      SHORT G_M16263_IG09
-						;; size=22 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG05]
+						;; size=38 bbWeight=1 PerfScore 11.75
 G_M16263_IG05:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      G_M16263_IG19
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M16263_IG07
-       mov      edx, r8d
-       mov      edx, dword ptr [r15+4*rdx+0x10]
-       mov      rcx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<AnyWithPredicate_LastElementMatches>b__14_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rcx
-       jne      SHORT G_M16263_IG08
+       jae      G_M16263_IG17
+       mov      rbx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rbx+0x08]
+       jae      SHORT G_M16263_IG08
+       mov      eax, r8d
+       mov      edx, dword ptr [rbx+4*rax+0x10]
        cmp      edx, 99
        jl       SHORT G_M16263_IG09
-						;; size=53 bbWeight=99.41 PerfScore 1963.33
+						;; size=36 bbWeight=99.30 PerfScore 1539.16
 G_M16263_IG06:
-       jmp      G_M16263_IG22
+       jmp      G_M16263_IG20
 						;; size=5 bbWeight=1 PerfScore 2.00
 G_M16263_IG07:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M16263_IG08:
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
-       jne      G_M16263_IG22
-						;; size=15 bbWeight=99.41 PerfScore 621.31
+       jne      G_M16263_IG20
+       jmp      SHORT G_M16263_IG13
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M16263_IG08:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M16263_IG09:
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rsi+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M16263_IG10
-       mov      dword ptr [rsi+0x08], eax
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M16263_IG05
-						;; size=19 bbWeight=99.41 PerfScore 844.98
+						;; size=17 bbWeight=99.30 PerfScore 844.06
 G_M16263_IG10:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      G_M16263_IG20
-						;; size=9 bbWeight=99.41 PerfScore 298.23
+       mov      dword ptr [rsi+0x08], eax
+       jmp      G_M16263_IG18
+						;; size=8 bbWeight=99.30 PerfScore 297.90
 G_M16263_IG11:
        cmp      dword ptr [rsi], esi
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M16263_IG15
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M16263_IG13
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M16263_IG12:
        mov      r8d, dword ptr [rsi+0x08]
        cmp      r8d, dword ptr [rsi+0x0C]
-       jae      SHORT G_M16263_IG19
-       mov      r15, gword ptr [rsi+0x10]
-       cmp      r8d, dword ptr [r15+0x08]
-       jae      SHORT G_M16263_IG07
+       jae      SHORT G_M16263_IG17
+       mov      rcx, gword ptr [rsi+0x10]
+       cmp      r8d, dword ptr [rcx+0x08]
+       jae      SHORT G_M16263_IG08
        mov      edx, r8d
-       mov      edx, dword ptr [r15+4*rdx+0x10]
+       mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rcx
-       jne      SHORT G_M16263_IG14
+       jne      SHORT G_M16263_IG07
        cmp      edx, 99
-       jl       SHORT G_M16263_IG15
-						;; size=49 bbWeight=1.00 PerfScore 19.83
+       jge      SHORT G_M16263_IG20
+						;; size=48 bbWeight=1.00 PerfScore 19.81
 G_M16263_IG13:
-       jmp      SHORT G_M16263_IG22
-						;; size=2 bbWeight=1 PerfScore 2.00
-G_M16263_IG14:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      SHORT G_M16263_IG22
-						;; size=11 bbWeight=1.00 PerfScore 6.28
-G_M16263_IG15:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M16263_IG17
-       mov      eax, dword ptr [rsi+0x08]
-       inc      eax
-       mov      r14d, dword ptr [rsi+0x0C]
-       cmp      eax, r14d
-       jae      SHORT G_M16263_IG16
-       mov      dword ptr [rsi+0x08], eax
+       jne      SHORT G_M16263_IG16
+						;; size=5 bbWeight=1.00 PerfScore 4.01
+G_M16263_IG14:
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M16263_IG15
+       mov      dword ptr [rsi+0x08], edx
        jmp      SHORT G_M16263_IG12
-						;; size=24 bbWeight=1.00 PerfScore 12.55
+						;; size=17 bbWeight=1.00 PerfScore 8.53
+G_M16263_IG15:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      SHORT G_M16263_IG18
+						;; size=5 bbWeight=1.00 PerfScore 3.01
 G_M16263_IG16:
-       mov      dword ptr [rsi+0x08], r14d
-       jmp      SHORT G_M16263_IG20
-						;; size=6 bbWeight=1.00 PerfScore 3.01
-G_M16263_IG17:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M16263_IG20
-						;; size=20 bbWeight=1.00 PerfScore 4.77
-G_M16263_IG18:
+       je       SHORT G_M16263_IG18
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        mov      edx, eax
-       jmp      SHORT G_M16263_IG14
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M16263_IG19:
+       jmp      G_M16263_IG07
+						;; size=43 bbWeight=0 PerfScore 0.00
+G_M16263_IG17:
        mov      ecx, dword ptr [rsi+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16263_IG20:
+G_M16263_IG18:
        mov      rcx, rsp
-       call     G_M16263_IG31
+       call     G_M16263_IG29
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M16263_IG21:
-       jmp      SHORT G_M16263_IG29
+G_M16263_IG19:
+       jmp      SHORT G_M16263_IG27
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M16263_IG22:
+G_M16263_IG20:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M16263_IG28
+       jne      SHORT G_M16263_IG26
 						;; size=5 bbWeight=1 PerfScore 4.00
-G_M16263_IG23:
+G_M16263_IG21:
        mov      eax, 1
 						;; size=5 bbWeight=1 PerfScore 0.25
-G_M16263_IG24:
+G_M16263_IG22:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M16263_IG25:
+						;; size=9 bbWeight=1 PerfScore 3.25
+G_M16263_IG23:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M16263_IG26:
+G_M16263_IG24:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M16263_IG27:
+G_M16263_IG25:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M16263_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16263_IG28:
+G_M16263_IG26:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M16263_IG23
+       jmp      SHORT G_M16263_IG21
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M16263_IG29:
+G_M16263_IG27:
        xor      eax, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M16263_IG30:
+G_M16263_IG28:
        add      rsp, 56
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M16263_IG31:
+						;; size=9 bbWeight=0 PerfScore 0.00
+G_M16263_IG29:
        push     rbp
-       push     r15
-       push     r14
        push     rdi
        push     rsi
        push     rbx
        sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=25 bbWeight=0.01 PerfScore 0.10
-G_M16263_IG32:
-       cmp      gword ptr [rbp-0x30], 0
-       je       SHORT G_M16263_IG35
+       lea      rbp, [rbp+0x50]
+						;; size=21 bbWeight=0.01 PerfScore 0.07
+G_M16263_IG30:
+       cmp      gword ptr [rbp-0x20], 0
+       je       SHORT G_M16263_IG33
 						;; size=7 bbWeight=0.01 PerfScore 0.03
-G_M16263_IG33:
+G_M16263_IG31:
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rsi, gword ptr [rbp-0x30]
+       mov      rsi, gword ptr [rbp-0x20]
        cmp      qword ptr [rsi], rdi
-       je       SHORT G_M16263_IG35
+       je       SHORT G_M16263_IG33
 						;; size=19 bbWeight=0.01 PerfScore 0.05
-G_M16263_IG34:
+G_M16263_IG32:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M16263_IG35:
+G_M16263_IG33:
        nop      
 						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M16263_IG36:
+G_M16263_IG34:
        add      rsp, 40
        pop      rbx
        pop      rsi
        pop      rdi
-       pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0.01 PerfScore 0.04
+						;; size=9 bbWeight=0.01 PerfScore 0.03
 
-; Total bytes of code 561, prolog size 24, PerfScore 3815.81, instruction count 166, allocated bytes for code 561 (MethodHash=bbfdc078) for method System.Linq.Enumerable:Any[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte]):ubyte (Tier1)
+; Total bytes of code 525, prolog size 20, PerfScore 2757.16, instruction count 153, allocated bytes for code 529 (MethodHash=bbfdc078) for method System.Linq.Enumerable:Any[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte]):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.WhereSelect(input: IEnumerable)``

Hot functions:

- (86.57%) ``ConsumerExtensions.Consume`` (Tier-1)
  - **Has diffs**
- (1.20%) ``CastHelpers.IsInstanceOfAny`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[BenchmarkDotNet]ConsumerExtensions.Consume(class System.Collections.Generic.IEnumerable`1<!!0>,class BenchmarkDotNet.Engines.Consumer)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 25424
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 26216
 ; 7 inlinees with PGO data; 7 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T21] (  8,   6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T19] (  4, 103.05)     ref  ->  rbx         class-hnd single-def <BenchmarkDotNet.Engines.Consumer>
-;  V02 loc0         [V02,T14] ( 25, 212.16)     ref  ->  [rbp-0x40]  class-hnd EH-live spill-single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V00 arg0         [V00,T20] (  8,   6   )     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T18] (  4, 101.00)     ref  ->  rbx         class-hnd single-def <BenchmarkDotNet.Engines.Consumer>
+;  V02 loc0         [V02,T13] ( 25, 206.94)     ref  ->  [rbp-0x40]  class-hnd EH-live spill-single-def <System.Collections.Generic.IEnumerator`1[int]>
 ;* V03 loc1         [V03    ] (  0,   0   )     int  ->  zero-ref    ld-addr-op
 ;  V04 OutArgs      [V04    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 tmp1         [V05,T29] (  3,   2   )     ref  ->  rcx         "guarded devirt return temp"
+;  V05 tmp1         [V05,T27] (  3,   2   )     ref  ->  rcx         "guarded devirt return temp"
 ;* V06 tmp2         [V06    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]>
-;  V07 tmp3         [V07,T16] (  5, 202.11)     int  ->  r13         "guarded devirt return temp"
+;  V07 tmp3         [V07,T16] (  5, 198.00)     int  ->  rsi         "guarded devirt return temp"
 ;* V08 tmp4         [V08    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]>
-;  V09 tmp5         [V09,T15] (  2,   2.04)     int  ->  rax         "guarded devirt return temp"
-;  V10 tmp6         [V10,T02] ( 31,1121.57)     ref  ->  r14         class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]>
+;  V09 tmp5         [V09,T15] (  2,   0   )     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp6         [V10,T02] ( 31,1096.97)     ref  ->  r14         class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]>
 ;* V11 tmp7         [V11    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]>
-;  V12 tmp8         [V12,T26] (  4,   3   )     ref  ->  rsi        
+;  V12 tmp8         [V12,T23] (  4,   3   )     ref  ->  rsi        
 ;* V13 tmp9         [V13    ] (  0,   0   )     ref  ->  zero-ref    class-hnd single-def "Inline stloc first use temp" <System.Linq.Enumerable+Iterator`1[int]>
 ;* V14 tmp10        [V14    ] (  0,   0   )     int  ->  zero-ref    "non-inline candidate call"
-;  V15 tmp11        [V15,T11] (  6, 305.15)     int  ->  rsi         "Inline stloc first use temp"
-;  V16 tmp12        [V16,T07] ( 12, 404.14)     int  ->  r12         "Inline stloc first use temp"
-;  V17 tmp13        [V17,T20] (  6, 103.07)     ref  ->  rax         "guarded devirt return temp"
-;  V18 tmp14        [V18,T22] (  8,   6.10)     ref  ->  rax         "guarded devirt arg temp"
+;  V15 tmp11        [V15,T09] (  6, 299.00)     int  ->  rsi         "Inline stloc first use temp"
+;  V16 tmp12        [V16,T11] ( 12, 296.97)     int  ->  r12         "Inline stloc first use temp"
+;  V17 tmp13        [V17,T19] (  6, 100.99)     ref  ->  rax         "guarded devirt return temp"
+;  V18 tmp14        [V18,T21] (  8,   5.98)     ref  ->  rax         "guarded devirt arg temp"
 ;* V19 tmp15        [V19    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V20 tmp16        [V20    ] (  0,   0   )     int  ->  zero-ref    "guarded devirt return temp"
-;  V21 tmp17        [V21,T01] ( 13,1010.34)     ref  ->  rcx         "guarded devirt arg temp"
+;  V21 tmp17        [V21,T01] ( 13, 989.90)     ref  ->  rcx         "guarded devirt arg temp"
 ;* V22 tmp18        [V22    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V23 tmp19        [V23,T18] (  4, 202.07)     int  ->  rax         "guarded devirt return temp"
-;  V24 tmp20        [V24,T03] ( 10, 808.27)     ref  ->  r10         "guarded devirt arg temp"
+;  V23 tmp19        [V23,T31] (  4,   0   )     int  ->  rax         "guarded devirt return temp"
+;  V24 tmp20        [V24,T05] ( 10, 395.96)     ref  ->   r8         "guarded devirt arg temp"
 ;* V25 tmp21        [V25    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V26 tmp22        [V26,T17] (  6, 202.07)     int  ->  r12         "guarded devirt return temp"
-;  V27 tmp23        [V27,T08] (  8, 404.14)     ref  ->  rsi         "guarded devirt arg temp"
+;  V26 tmp22        [V26,T17] (  6, 197.98)     int  ->  r12         "guarded devirt return temp"
+;  V27 tmp23        [V27,T06] (  8, 395.96)     ref  ->  r15         "guarded devirt arg temp"
 ;* V28 tmp24        [V28    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V29 tmp25        [V29,T06] (  4, 204.11)     int  ->  rax         "guarded devirt return temp"
-;  V30 tmp26        [V30,T00] ( 14,1426.77)     ref  ->  rcx         "guarded devirt arg temp"
+;  V29 tmp25        [V29,T14] (  4,   0   )     int  ->  rax         "guarded devirt return temp"
+;  V30 tmp26        [V30,T00] ( 14,1198.00)     ref  ->  rcx         "guarded devirt arg temp"
 ;* V31 tmp27        [V31    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V32 tmp28        [V32,T10] (  6, 305.16)     int  ->  rax         "Inline stloc first use temp"
-;  V33 tmp29        [V33,T27] (  6,   2.04)     ref  ->  r11         "guarded devirt arg temp"
+;  V32 tmp28        [V32,T08] (  6, 299.01)     int  ->  rax         "Inline stloc first use temp"
+;  V33 tmp29        [V33,T26] (  6,   2.02)     ref  ->  rcx         "guarded devirt arg temp"
 ;* V34 tmp30        [V34    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V35 tmp31        [V35,T28] (  6,   2.01)     ref  ->  rax         "guarded devirt arg temp"
+;  V35 tmp31        [V35,T28] (  6,   1.98)     ref  ->  rax         "guarded devirt arg temp"
 ;* V36 tmp32        [V36    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V37 tmp33        [V37,T04] (  6, 606.20)     ref  ->  r13         "arr expr"
-;  V38 tmp34        [V38,T05] (  6, 606.20)     int  ->   r8         "index expr"
-;  V39 PSPSym       [V39,T30] (  1,   1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
-;  V40 cse0         [V40,T12] (  3, 303.10)     int  ->  rsi         "CSE #05: moderate"
-;  V41 cse1         [V41,T13] (  3, 300.07)     int  ->   r8         "CSE #03: moderate"
-;  V42 cse2         [V42,T24] (  3,   3.06)     int  ->  rsi         "CSE #09: moderate"
-;  V43 cse3         [V43,T25] (  3,   3.03)     int  ->   r8         "CSE #08: moderate"
-;  V44 cse4         [V44,T31] (  3,   0.03)     ref  ->  r11         "CSE #10: conservative"
-;  V45 cse5         [V45,T23] (  7,   5.02)    long  ->  rdi         multi-def "CSE #01: moderate"
-;  V46 cse6         [V46,T09] ( 12, 306.66)    long  ->  r15         multi-def "CSE #04: aggressive"
+;  V37 tmp33        [V37,T03] (  6, 593.94)     ref  ->  r13         "arr expr"
+;  V38 tmp34        [V38,T04] (  6, 593.94)     int  ->  rdx         "index expr"
+;  V39 PSPSym       [V39,T29] (  1,   1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
+;  V40 cse0         [V40,T10] (  3, 296.99)     int  ->  r11         "CSE #05: moderate"
+;  V41 cse1         [V41,T12] (  3, 294.00)     int  ->  rdx         "CSE #03: moderate"
+;  V42 cse2         [V42,T24] (  3,   3.00)     int  ->  rdx         "CSE #09: moderate"
+;  V43 cse3         [V43,T25] (  3,   2.97)     int  ->  rdx         "CSE #08: moderate"
+;  V44 cse4         [V44,T30] (  3,   0.03)     ref  ->  rcx         "CSE #10: conservative"
+;  V45 cse5         [V45,T22] (  7,   4.99)    long  ->  rdi         multi-def "CSE #01: moderate"
+;  V46 cse6         [V46,T07] ( 12, 300.48)    long  ->  r15         multi-def "CSE #04: aggressive"
 ;
 ; Lcl frame size = 56
 
@@ -387,13 +387,13 @@ G_M32802_IG01:
 G_M32802_IG02:
        mov      rdi, 0xD1FFAB1E      ; System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]
        cmp      qword ptr [rsi], rdi
-       jne      G_M32802_IG60
+       jne      G_M32802_IG58
        cmp      dword ptr [rsi+0x0C], 0
-       jne      G_M32802_IG59
+       jne      G_M32802_IG57
        mov      r14d, dword ptr [rsi+0x08]
        call     <unknown method>
        cmp      r14d, eax
-       jne      G_M32802_IG59
+       jne      G_M32802_IG57
 						;; size=47 bbWeight=1 PerfScore 12.50
 G_M32802_IG03:
        mov      dword ptr [rsi+0x0C], 1
@@ -404,345 +404,331 @@ G_M32802_IG04:
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M32802_IG05:
        test     rcx, rcx
-       je       G_M32802_IG36
+       je       G_M32802_IG22
        cmp      qword ptr [rcx], rdi
-       jne      G_M32802_IG36
+       jne      G_M32802_IG22
        jmp      SHORT G_M32802_IG07
 						;; size=20 bbWeight=1 PerfScore 7.25
 G_M32802_IG06:
        mov      rcx, gword ptr [rbp-0x40]
-       mov      r13d, dword ptr [rcx+0x10]
-       mov      dword ptr [rbx+0x38], r13d
-       mov      rcx, gword ptr [rbp-0x40]
-						;; size=16 bbWeight=100.04 PerfScore 500.22
+       mov      esi, dword ptr [rcx+0x10]
+       mov      dword ptr [rbx+0x38], esi
+						;; size=10 bbWeight=98.01 PerfScore 392.03
 G_M32802_IG07:
        mov      r14, rcx
        mov      esi, dword ptr [r14+0x0C]
        cmp      esi, 1
-       je       SHORT G_M32802_IG13
-						;; size=12 bbWeight=101.03 PerfScore 353.62
+       je       G_M32802_IG20
+						;; size=16 bbWeight=99.00 PerfScore 346.49
 G_M32802_IG08:
        cmp      esi, 2
-       jne      G_M32802_IG54
-						;; size=9 bbWeight=100.03 PerfScore 125.03
+       jne      G_M32802_IG52
+						;; size=9 bbWeight=98.01 PerfScore 122.51
 G_M32802_IG09:
        mov      rcx, gword ptr [r14+0x30]
        mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], r15
-       jne      G_M32802_IG19
+       jne      G_M32802_IG33
        mov      eax, dword ptr [rcx+0x08]
        inc      eax
-       mov      esi, dword ptr [rcx+0x0C]
-       cmp      eax, esi
-       jae      SHORT G_M32802_IG15
-						;; size=35 bbWeight=101.03 PerfScore 1187.15
+       mov      r11d, dword ptr [rcx+0x0C]
+       cmp      eax, r11d
+       jae      G_M32802_IG15
+						;; size=41 bbWeight=99.00 PerfScore 1163.23
 G_M32802_IG10:
        mov      dword ptr [rcx+0x08], eax
-       jmp      SHORT G_M32802_IG16
-						;; size=5 bbWeight=100.04 PerfScore 300.13
+						;; size=3 bbWeight=98.02 PerfScore 98.02
 G_M32802_IG11:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rsi+0x08]
-       call     [rsi+0x18]<unknown method>
-       mov      r12d, eax
-       jmp      G_M32802_IG18
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M32802_IG12:
-       mov      rcx, r11
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       jmp      G_M32802_IG22
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M32802_IG13:
-       mov      rax, gword ptr [r14+0x18]
-       mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
-       cmp      qword ptr [rax], r11
+       mov      rcx, gword ptr [r14+0x30]
+       cmp      qword ptr [rcx], r15
+       jne      G_M32802_IG31
+       mov      edx, dword ptr [rcx+0x08]
+       cmp      edx, dword ptr [rcx+0x0C]
+       jae      G_M32802_IG44
+       mov      r13, gword ptr [rcx+0x10]
+       cmp      edx, dword ptr [r13+0x08]
+       jae      G_M32802_IG29
+       mov      r11d, edx
+       mov      r12d, dword ptr [r13+4*r11+0x10]
+       mov      r8, gword ptr [r14+0x20]
+       mov      rcx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereSelect>b__6_0(int):ubyte:this
+       cmp      qword ptr [r8+0x18], rcx
        jne      G_M32802_IG32
-       mov      rcx, gword ptr [rax+0x08]
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-						;; size=40 bbWeight=1.01 PerfScore 11.58
+       test     r12d, r12d
+       jl       SHORT G_M32802_IG09
+						;; size=76 bbWeight=98.00 PerfScore 2719.49
+G_M32802_IG12:
+       mov      r15, gword ptr [r14+0x28]
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereSelect>b__6_1(int):int:this
+       cmp      qword ptr [r15+0x18], rax
+       jne      G_M32802_IG35
+       inc      r12d
+						;; size=27 bbWeight=98.00 PerfScore 637.00
+G_M32802_IG13:
+       mov      dword ptr [r14+0x10], r12d
+       jmp      G_M32802_IG06
+						;; size=9 bbWeight=98.00 PerfScore 294.00
 G_M32802_IG14:
        lea      rcx, bword ptr [r14+0x30]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
        mov      dword ptr [r14+0x0C], 2
        jmp      G_M32802_IG09
-						;; size=25 bbWeight=101.03 PerfScore 479.91
+						;; size=25 bbWeight=99.00 PerfScore 470.24
 G_M32802_IG15:
-       mov      dword ptr [rcx+0x08], esi
-       jmp      G_M32802_IG20
-						;; size=8 bbWeight=101.03 PerfScore 303.10
+       mov      dword ptr [rcx+0x08], r11d
+						;; size=4 bbWeight=99.00 PerfScore 99.00
 G_M32802_IG16:
+       cmp      gword ptr [r14+0x30], 0
+       je       SHORT G_M32802_IG19
+						;; size=7 bbWeight=1.00 PerfScore 3.99
+G_M32802_IG17:
        mov      rcx, gword ptr [r14+0x30]
        cmp      qword ptr [rcx], r15
-       jne      G_M32802_IG31
-       mov      r8d, dword ptr [rcx+0x08]
-       cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M32802_IG25
-       mov      r13, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r13+0x08]
-       jae      G_M32802_IG24
-       mov      edx, r8d
-       mov      r12d, dword ptr [r13+4*rdx+0x10]
-       mov      r10, gword ptr [r14+0x20]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereSelect>b__6_0(int):ubyte:this
-       cmp      qword ptr [r10+0x18], rdx
-       jne      G_M32802_IG33
-       test     r12d, r12d
-       jl       G_M32802_IG09
-						;; size=82 bbWeight=100.02 PerfScore 2775.65
-G_M32802_IG17:
-       mov      rsi, gword ptr [r14+0x28]
-       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<WhereSelect>b__6_1(int):int:this
-       cmp      qword ptr [rsi+0x18], rax
-       jne      G_M32802_IG11
-       inc      r12d
-						;; size=27 bbWeight=100.02 PerfScore 650.15
+       jne      G_M32802_IG34
+						;; size=13 bbWeight=0.50 PerfScore 2.99
 G_M32802_IG18:
-       mov      dword ptr [r14+0x10], r12d
-       jmp      G_M32802_IG06
-						;; size=9 bbWeight=100.02 PerfScore 300.07
+       xor      rcx, rcx
+       mov      gword ptr [r14+0x30], rcx
+						;; size=6 bbWeight=0.50 PerfScore 0.62
 G_M32802_IG19:
+       xor      ecx, ecx
+       mov      dword ptr [r14+0x10], ecx
+       mov      dword ptr [r14+0x0C], -1
+       jmp      G_M32802_IG52
+						;; size=19 bbWeight=99.00 PerfScore 420.74
+G_M32802_IG20:
+       mov      rax, gword ptr [r14+0x18]
+       mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
+       cmp      qword ptr [rax], r11
+       jne      G_M32802_IG30
+       mov      rcx, gword ptr [rax+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M32802_IG16
-						;; size=21 bbWeight=101.03 PerfScore 454.65
-G_M32802_IG20:
-       cmp      gword ptr [r14+0x30], 0
-       je       SHORT G_M32802_IG23
-						;; size=7 bbWeight=1.01 PerfScore 4.04
+       jmp      SHORT G_M32802_IG14
+						;; size=42 bbWeight=0.99 PerfScore 13.32
 G_M32802_IG21:
-       mov      r11, gword ptr [r14+0x30]
-       cmp      qword ptr [r11], r15
-       jne      G_M32802_IG12
-						;; size=13 bbWeight=0.51 PerfScore 3.03
+       mov      dword ptr [rbx+0x38], esi
+       mov      rcx, gword ptr [rbp-0x40]
+						;; size=7 bbWeight=0.99 PerfScore 1.98
 G_M32802_IG22:
-       xor      rax, rax
-       mov      gword ptr [r14+0x30], rax
-						;; size=6 bbWeight=0.51 PerfScore 0.63
+       cmp      qword ptr [rcx], rdi
+       jne      G_M32802_IG37
+       mov      r14, rcx
+       mov      esi, dword ptr [r14+0x0C]
+       cmp      esi, 1
+       je       G_M32802_IG45
+						;; size=25 bbWeight=1.00 PerfScore 7.50
 G_M32802_IG23:
-       xor      eax, eax
-       mov      dword ptr [r14+0x10], eax
-       mov      dword ptr [r14+0x0C], -1
-       jmp      G_M32802_IG54
-						;; size=19 bbWeight=101.03 PerfScore 429.40
+       cmp      esi, 2
+       jne      G_M32802_IG52
+						;; size=9 bbWeight=0.99 PerfScore 1.24
 G_M32802_IG24:
+       mov      rcx, gword ptr [r14+0x30]
+       mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
+       cmp      qword ptr [rcx], r15
+       jne      G_M32802_IG39
+       mov      eax, dword ptr [rcx+0x08]
+       inc      eax
+       mov      edx, dword ptr [rcx+0x0C]
+       cmp      eax, edx
+       jae      G_M32802_IG47
+						;; size=39 bbWeight=1.00 PerfScore 11.75
+G_M32802_IG25:
+       mov      dword ptr [rcx+0x08], eax
+						;; size=3 bbWeight=0.99 PerfScore 0.99
+G_M32802_IG26:
+       mov      rcx, gword ptr [r14+0x30]
+       cmp      qword ptr [rcx], r15
+       jne      G_M32802_IG40
+       mov      edx, dword ptr [rcx+0x08]
+       cmp      edx, dword ptr [rcx+0x0C]
+       jae      G_M32802_IG44
+       mov      r13, gword ptr [rcx+0x10]
+       cmp      edx, dword ptr [r13+0x08]
+       jae      SHORT G_M32802_IG29
+       mov      ecx, edx
+       mov      r12d, dword ptr [r13+4*rcx+0x10]
+       mov      r8, gword ptr [r14+0x20]
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r8+0x18], rcx
+       jne      G_M32802_IG41
+       test     r12d, r12d
+       jl       SHORT G_M32802_IG24
+						;; size=71 bbWeight=0.99 PerfScore 27.47
+G_M32802_IG27:
+       mov      r15, gword ptr [r14+0x28]
+       mov      rax, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r15+0x18], rax
+       jne      G_M32802_IG43
+       inc      r12d
+						;; size=27 bbWeight=0.99 PerfScore 6.43
+G_M32802_IG28:
+       mov      dword ptr [r14+0x10], r12d
+       mov      rcx, gword ptr [rbp-0x40]
+       mov      esi, dword ptr [rcx+0x10]
+       jmp      G_M32802_IG21
+						;; size=16 bbWeight=0.99 PerfScore 5.94
+G_M32802_IG29:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M32802_IG25:
-       mov      ecx, dword ptr [rcx+0x08]
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M32802_IG26:
-       mov      rcx, r11
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       jmp      G_M32802_IG49
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M32802_IG27:
-       mov      edx, r12d
-       mov      rcx, gword ptr [rsi+0x08]
-       call     [rsi+0x18]<unknown method>
-       mov      r12d, eax
-       jmp      G_M32802_IG48
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M32802_IG28:
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       mov      r12d, eax
-       mov      r10, gword ptr [r14+0x20]
-       jmp      G_M32802_IG44
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M32802_IG29:
-       mov      rcx, rax
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       jmp      G_M32802_IG41
-						;; size=21 bbWeight=0 PerfScore 0.00
 G_M32802_IG30:
-       mov      rcx, gword ptr [rbp-0x40]
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       mov      r13d, eax
-       mov      rcx, gword ptr [rbp-0x40]
-       jmp      SHORT G_M32802_IG35
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M32802_IG31:
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       mov      r12d, eax
-       mov      r10, gword ptr [r14+0x20]
-       jmp      SHORT G_M32802_IG33
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M32802_IG32:
        mov      rcx, rax
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        jmp      G_M32802_IG14
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M32802_IG33:
+G_M32802_IG31:
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       mov      r12d, eax
+       mov      r8, gword ptr [r14+0x20]
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M32802_IG32:
        mov      edx, r12d
-       mov      rcx, gword ptr [r10+0x08]
-       call     [r10+0x18]<unknown method>
+       mov      rcx, gword ptr [r8+0x08]
+       call     [r8+0x18]<unknown method>
        test     eax, eax
-       jne      G_M32802_IG17
+       jne      G_M32802_IG12
        jmp      G_M32802_IG09
-						;; size=24 bbWeight=100.02 PerfScore 850.20
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M32802_IG33:
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      G_M32802_IG11
+       jmp      G_M32802_IG16
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M32802_IG34:
-       mov      rcx, gword ptr [rbp-0x40]
-       mov      r13d, dword ptr [rcx+0x10]
-						;; size=8 bbWeight=1.01 PerfScore 3.03
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       jmp      G_M32802_IG18
+						;; size=18 bbWeight=0 PerfScore 0.00
 G_M32802_IG35:
-       mov      dword ptr [rbx+0x38], r13d
-						;; size=4 bbWeight=1.01 PerfScore 1.01
+       mov      edx, r12d
+       mov      rcx, gword ptr [r15+0x08]
+       call     [r15+0x18]<unknown method>
+       mov      r12d, eax
+       jmp      G_M32802_IG13
+						;; size=19 bbWeight=0 PerfScore 0.00
 G_M32802_IG36:
-       cmp      qword ptr [rcx], rdi
-       jne      G_M32802_IG53
-       mov      r14, rcx
-       mov      esi, dword ptr [r14+0x0C]
-       cmp      esi, 1
-       je       SHORT G_M32802_IG40
-						;; size=21 bbWeight=1.02 PerfScore 7.65
+       mov      rcx, gword ptr [rbp-0x40]
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      esi, eax
+       jmp      G_M32802_IG21
+						;; size=24 bbWeight=0 PerfScore 0.00
 G_M32802_IG37:
-       cmp      esi, 2
-       jne      G_M32802_IG54
-						;; size=9 bbWeight=1.01 PerfScore 1.26
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M32802_IG36
+       jmp      G_M32802_IG52
+						;; size=22 bbWeight=0 PerfScore 0.00
 G_M32802_IG38:
-       mov      rcx, gword ptr [r14+0x30]
-       mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       cmp      qword ptr [rcx], r15
-       jne      G_M32802_IG45
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      esi, dword ptr [rcx+0x0C]
-       cmp      eax, esi
-       jae      SHORT G_M32802_IG42
-						;; size=35 bbWeight=1.02 PerfScore 11.99
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       jmp      G_M32802_IG50
+						;; size=18 bbWeight=0 PerfScore 0.00
 G_M32802_IG39:
-       mov      dword ptr [rcx+0x08], eax
-       jmp      SHORT G_M32802_IG43
-						;; size=5 bbWeight=1.01 PerfScore 3.03
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      G_M32802_IG26
+       jmp      G_M32802_IG48
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M32802_IG40:
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      r12d, eax
+       mov      r8, gword ptr [r14+0x20]
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M32802_IG41:
+       mov      edx, r12d
+       mov      rcx, gword ptr [r8+0x08]
+       call     [r8+0x18]<unknown method>
+       test     eax, eax
+       jne      G_M32802_IG27
+       jmp      G_M32802_IG24
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M32802_IG42:
+       mov      rcx, rax
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       jmp      SHORT G_M32802_IG46
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M32802_IG43:
+       mov      edx, r12d
+       mov      rcx, gword ptr [r15+0x08]
+       call     [r15+0x18]<unknown method>
+       mov      r12d, eax
+       jmp      G_M32802_IG28
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M32802_IG44:
+       mov      ecx, dword ptr [rcx+0x08]
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M32802_IG45:
        mov      rax, gword ptr [r14+0x18]
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rax], r11
-       jne      G_M32802_IG29
+       jne      SHORT G_M32802_IG42
        mov      rcx, gword ptr [rax+0x08]
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-						;; size=40 bbWeight=0.01 PerfScore 0.12
-G_M32802_IG41:
+						;; size=36 bbWeight=0.01 PerfScore 0.11
+G_M32802_IG46:
        lea      rcx, bword ptr [r14+0x30]
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
        mov      dword ptr [r14+0x0C], 2
-       jmp      SHORT G_M32802_IG38
-						;; size=22 bbWeight=1.02 PerfScore 4.85
-G_M32802_IG42:
-       mov      dword ptr [rcx+0x08], esi
-       jmp      G_M32802_IG50
-						;; size=8 bbWeight=1.02 PerfScore 3.06
-G_M32802_IG43:
-       mov      rcx, gword ptr [r14+0x30]
-       cmp      qword ptr [rcx], r15
-       jne      G_M32802_IG28
-       mov      r8d, dword ptr [rcx+0x08]
-       cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M32802_IG25
-       mov      r13, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r13+0x08]
-       jae      G_M32802_IG24
-       mov      edx, r8d
-       mov      r12d, dword ptr [r13+4*rdx+0x10]
-       mov      r10, gword ptr [r14+0x20]
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [r10+0x18], rdx
-       jne      SHORT G_M32802_IG44
-       test     r12d, r12d
-       jl       G_M32802_IG38
-       jmp      SHORT G_M32802_IG47
-						;; size=80 bbWeight=1.01 PerfScore 30.06
-G_M32802_IG44:
-       mov      edx, r12d
-       mov      rcx, gword ptr [r10+0x08]
-       call     [r10+0x18]<unknown method>
-       test     eax, eax
-       jne      SHORT G_M32802_IG47
-       jmp      G_M32802_IG38
-						;; size=20 bbWeight=1.01 PerfScore 8.59
-G_M32802_IG45:
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      SHORT G_M32802_IG43
-						;; size=17 bbWeight=1.02 PerfScore 4.59
-G_M32802_IG46:
-       jmp      SHORT G_M32802_IG50
-						;; size=2 bbWeight=0.01 PerfScore 0.02
+       jmp      G_M32802_IG24
+						;; size=25 bbWeight=1.00 PerfScore 4.75
 G_M32802_IG47:
-       mov      rsi, gword ptr [r14+0x28]
-       mov      rcx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rsi+0x18], rcx
-       jne      G_M32802_IG27
-       inc      r12d
-						;; size=27 bbWeight=1.01 PerfScore 6.57
+       mov      dword ptr [rcx+0x08], edx
+						;; size=3 bbWeight=1.00 PerfScore 1.00
 G_M32802_IG48:
-       mov      dword ptr [r14+0x10], r12d
-       jmp      G_M32802_IG34
-						;; size=9 bbWeight=1.01 PerfScore 3.03
-G_M32802_IG49:
-       xor      rax, rax
-       mov      gword ptr [r14+0x30], rax
-       jmp      SHORT G_M32802_IG52
-						;; size=8 bbWeight=0.01 PerfScore 0.02
-G_M32802_IG50:
-       mov      r11, gword ptr [r14+0x30]
-       test     r11, r11
-       je       SHORT G_M32802_IG52
+       mov      rcx, gword ptr [r14+0x30]
+       test     rcx, rcx
+       je       SHORT G_M32802_IG51
 						;; size=9 bbWeight=0.01 PerfScore 0.03
+G_M32802_IG49:
+       cmp      qword ptr [rcx], r15
+       jne      G_M32802_IG38
+						;; size=9 bbWeight=0.01 PerfScore 0.02
+G_M32802_IG50:
+       xor      rcx, rcx
+       mov      gword ptr [r14+0x30], rcx
+						;; size=6 bbWeight=0.01 PerfScore 0.01
 G_M32802_IG51:
-       cmp      qword ptr [r11], r15
-       jne      G_M32802_IG26
-       jmp      SHORT G_M32802_IG49
-						;; size=11 bbWeight=0.01 PerfScore 0.03
-G_M32802_IG52:
-       xor      r11d, r11d
-       mov      dword ptr [r14+0x10], r11d
+       xor      ecx, ecx
+       mov      dword ptr [r14+0x10], ecx
        mov      dword ptr [r14+0x0C], -1
-       jmp      SHORT G_M32802_IG54
-						;; size=17 bbWeight=1.02 PerfScore 4.34
-G_M32802_IG53:
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M32802_IG30
-						;; size=21 bbWeight=1.02 PerfScore 4.59
-G_M32802_IG54:
+						;; size=14 bbWeight=0.01 PerfScore 0.02
+G_M32802_IG52:
        mov      rcx, gword ptr [rbp-0x40]
        cmp      qword ptr [rcx], rdi
-       jne      G_M32802_IG62
+       jne      G_M32802_IG60
        cmp      gword ptr [rcx+0x30], 0
-       je       SHORT G_M32802_IG57
-						;; size=20 bbWeight=1.00 PerfScore 9.02
-G_M32802_IG55:
+       je       SHORT G_M32802_IG55
+						;; size=20 bbWeight=0.99 PerfScore 8.90
+G_M32802_IG53:
        mov      rax, gword ptr [rcx+0x30]
        mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rax], r15
-       jne      SHORT G_M32802_IG61
-						;; size=19 bbWeight=0.50 PerfScore 3.13
-G_M32802_IG56:
+       jne      SHORT G_M32802_IG59
+						;; size=19 bbWeight=0.49 PerfScore 3.09
+G_M32802_IG54:
        xor      rax, rax
        mov      gword ptr [rcx+0x30], rax
-						;; size=6 bbWeight=0.50 PerfScore 0.63
-G_M32802_IG57:
+						;; size=6 bbWeight=0.49 PerfScore 0.62
+G_M32802_IG55:
        xor      eax, eax
        mov      dword ptr [rcx+0x10], eax
        mov      dword ptr [rcx+0x0C], -1
-						;; size=12 bbWeight=1.00 PerfScore 2.26
-G_M32802_IG58:
+						;; size=12 bbWeight=0.99 PerfScore 2.22
+G_M32802_IG56:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -754,32 +740,32 @@ G_M32802_IG58:
        pop      rbp
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M32802_IG59:
+G_M32802_IG57:
        mov      rcx, rsi
        call     [System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]:Clone():System.Linq.Enumerable+Iterator`1[int]:this]
        mov      rsi, rax
        jmp      G_M32802_IG03
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M32802_IG60:
+G_M32802_IG58:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, rax
        jmp      G_M32802_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M32802_IG61:
+G_M32802_IG59:
        mov      rcx, rax
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, gword ptr [rbp-0x40]
-       jmp      SHORT G_M32802_IG56
+       jmp      SHORT G_M32802_IG54
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M32802_IG62:
+G_M32802_IG60:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M32802_IG58
+       jmp      SHORT G_M32802_IG56
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M32802_IG63:
+G_M32802_IG61:
        push     rbp
        push     r15
        push     r14
@@ -793,42 +779,42 @@ G_M32802_IG63:
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x70]
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M32802_IG64:
+G_M32802_IG62:
        cmp      gword ptr [rbp-0x40], 0
-       je       SHORT G_M32802_IG68
+       je       SHORT G_M32802_IG66
        mov      rdi, 0xD1FFAB1E      ; System.Linq.Enumerable+WhereSelectEnumerableIterator`2[int,int]
        mov      rcx, gword ptr [rbp-0x40]
        cmp      qword ptr [rcx], rdi
-       jne      SHORT G_M32802_IG67
+       jne      SHORT G_M32802_IG65
        cmp      gword ptr [rcx+0x30], 0
-       je       SHORT G_M32802_IG66
+       je       SHORT G_M32802_IG64
        mov      rax, gword ptr [rcx+0x30]
        mov      r15, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rax], r15
-       je       SHORT G_M32802_IG65
+       je       SHORT G_M32802_IG63
        mov      rcx, rax
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=68 bbWeight=0 PerfScore 0.00
-G_M32802_IG65:
+G_M32802_IG63:
        xor      r11, r11
        mov      rcx, gword ptr [rbp-0x40]
        mov      gword ptr [rcx+0x30], r11
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M32802_IG66:
+G_M32802_IG64:
        xor      r11d, r11d
        mov      dword ptr [rcx+0x10], r11d
        mov      dword ptr [rcx+0x0C], -1
-       jmp      SHORT G_M32802_IG68
+       jmp      SHORT G_M32802_IG66
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M32802_IG67:
+G_M32802_IG65:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M32802_IG68:
+G_M32802_IG66:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M32802_IG69:
+G_M32802_IG67:
        add      rsp, 40
        pop      rbx
        pop      rsi
@@ -841,6 +827,6 @@ G_M32802_IG69:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1358, prolog size 31, PerfScore 8879.00, instruction count 333, allocated bytes for code 1358 (MethodHash=95f57fdd) for method BenchmarkDotNet.Engines.ConsumerExtensions:Consume[int](System.Collections.Generic.IEnumerable`1[int],BenchmarkDotNet.Engines.Consumer) (Tier1)
+; Total bytes of code 1339, prolog size 31, PerfScore 6905.26, instruction count 323, allocated bytes for code 1339 (MethodHash=95f57fdd) for method BenchmarkDotNet.Engines.ConsumerExtensions:Consume[int](System.Collections.Generic.IEnumerable`1[int],BenchmarkDotNet.Engines.Consumer) (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.AnyWithPredicate_LastElementMatches(input: Array)``

Hot functions:

- (90.35%) ``Enumerable.Any`` (Tier-1)
  - **Has diffs**
- (1.16%) ``Perf_Enumerable.AnyWithPredicate_LastElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.Any(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 60936
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 59136
 ; 2 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T10] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] (  9,302.89)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 loc0         [V02,T00] ( 27,704.76)     ref  ->  [rbp-0x28]  class-hnd EH-live spill-single-def <<unknown class>>
-;  V03 loc1         [V03,T04] (  7,299.89)     int  ->  rdx        
-;* V04 loc2         [V04,T14] (  0,  0   )   ubyte  ->  zero-ref   
+;  V00 arg0         [V00,T09] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] (  7,  5.00)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 loc0         [V02,T00] ( 27,703.62)     ref  ->  [rbp-0x18]  class-hnd EH-live spill-single-def <<unknown class>>
+;  V03 loc1         [V03,T06] (  6,199.89)     int  ->  rdx        
+;* V04 loc2         [V04,T13] (  0,  0   )   ubyte  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V08 tmp3         [V08,T09] (  4,199.92)     int  ->  rax         "guarded devirt return temp"
+;  V08 tmp3         [V08,T15] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V09 tmp4         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V10 tmp5         [V10,T08] (  2,  2.00)     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp5         [V10,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V11 tmp6         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V12 tmp7         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V13 tmp8         [V13,T05] (  6,299.89)     int  ->  rax         "Inline stloc first use temp"
-;  V14 tmp9         [V14,T01] (  6,599.77)     ref  ->  r14         "arr expr"
-;  V15 tmp10        [V15,T02] (  6,599.77)     int  ->   r8         "index expr"
-;  V16 PSPSym       [V16,T15] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
-;  V17 cse0         [V17,T06] (  3,296.89)     int  ->   r8         "CSE #03: aggressive"
-;  V18 cse1         [V18,T07] (  3,296.89)     int  ->  rdi         "CSE #04: aggressive"
-;  V19 cse2         [V19,T12] (  3,  3.00)     int  ->   r8         "CSE #05: aggressive"
-;  V20 cse3         [V20,T13] (  3,  3.00)     int  ->  rdi         "CSE #07: aggressive"
-;  V21 cse4         [V21,T11] (  7,  4.02)    long  ->  rsi         hoist multi-def "CSE #02: aggressive"
+;  V13 tmp8         [V13,T03] (  6,299.83)     int  ->  rdx         "Inline stloc first use temp"
+;  V14 tmp9         [V14,T01] (  6,599.66)     ref  ->  registers   "arr expr"
+;  V15 tmp10        [V15,T02] (  6,599.66)     int  ->   r8         "index expr"
+;  V16 PSPSym       [V16,T14] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
+;  V17 cse0         [V17,T04] (  3,296.83)     int  ->   r8         "CSE #03: aggressive"
+;  V18 cse1         [V18,T05] (  3,296.83)     int  ->  rax         "CSE #04: aggressive"
+;  V19 cse2         [V19,T11] (  3,  3.00)     int  ->   r8         "CSE #05: aggressive"
+;  V20 cse3         [V20,T12] (  3,  3.00)     int  ->  rax         "CSE #07: aggressive"
+;  V21 cse4         [V21,T10] (  7,  4.01)    long  ->  rsi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 48
 
 G_M16263_IG01:
        push     rbp
-       push     r14
-       push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
-       lea      rbp, [rsp+0x50]
-       mov      qword ptr [rbp-0x30], rsp
+       lea      rbp, [rsp+0x40]
+       mov      qword ptr [rbp-0x20], rsp
        mov      rbx, rdx
-						;; size=22 bbWeight=1 PerfScore 7.00
+						;; size=19 bbWeight=1 PerfScore 5.00
 G_M16263_IG02:
        test     rcx, rcx
-       je       G_M16263_IG23
+       je       G_M16263_IG21
        test     rbx, rbx
-       je       G_M16263_IG24
+       je       G_M16263_IG22
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, rax
-       mov      gword ptr [rbp-0x28], rcx
+       mov      gword ptr [rbp-0x18], rcx
 						;; size=38 bbWeight=1 PerfScore 7.00
 G_M16263_IG03:
        test     rcx, rcx
@@ -756,203 +754,184 @@ G_M16263_IG03:
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], rsi
        jne      SHORT G_M16263_IG10
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<AnyWithPredicate_LastElementMatches>b__14_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M16263_IG10
        jmp      SHORT G_M16263_IG08
-						;; size=26 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG04]
+						;; size=42 bbWeight=1 PerfScore 11.75
 G_M16263_IG04:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M16263_IG17
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M16263_IG06
-       mov      edx, r8d
-       mov      edx, dword ptr [r14+4*rdx+0x10]
-       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<AnyWithPredicate_LastElementMatches>b__14_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rax
-       jne      SHORT G_M16263_IG07
+       jae      G_M16263_IG15
+       mov      rbx, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [rbx+0x08]
+       jae      SHORT G_M16263_IG07
+       mov      eax, r8d
+       mov      edx, dword ptr [rbx+4*rax+0x10]
        cmp      edx, 99
-       mov      rcx, gword ptr [rbp-0x28]
        jl       SHORT G_M16263_IG08
-						;; size=57 bbWeight=98.96 PerfScore 2053.47
+						;; size=36 bbWeight=98.94 PerfScore 1533.64
 G_M16263_IG05:
-       jmp      G_M16263_IG20
+       jmp      G_M16263_IG18
 						;; size=5 bbWeight=1 PerfScore 2.00
 G_M16263_IG06:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M16263_IG07:
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
-       jne      G_M16263_IG20
-						;; size=15 bbWeight=98.96 PerfScore 618.51
+       mov      rcx, gword ptr [rbp-0x18]
+       jne      G_M16263_IG18
+       jmp      SHORT G_M16263_IG12
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M16263_IG07:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M16263_IG08:
-       mov      rcx, gword ptr [rbp-0x28]
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M16263_IG09
-       mov      dword ptr [rcx+0x08], eax
+       mov      dword ptr [rcx+0x08], edx
        jmp      SHORT G_M16263_IG04
-						;; size=21 bbWeight=98.96 PerfScore 940.14
+						;; size=17 bbWeight=98.94 PerfScore 841.03
 G_M16263_IG09:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      G_M16263_IG18
-						;; size=8 bbWeight=98.96 PerfScore 296.89
+       mov      dword ptr [rcx+0x08], eax
+       jmp      G_M16263_IG16
+						;; size=8 bbWeight=98.94 PerfScore 296.83
 G_M16263_IG10:
        cmp      dword ptr [rcx], ecx
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M16263_IG13
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M16263_IG12
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M16263_IG11:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M16263_IG17
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M16263_IG06
+       jae      SHORT G_M16263_IG15
+       mov      rax, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [rax+0x08]
+       jae      SHORT G_M16263_IG07
        mov      edx, r8d
-       mov      edx, dword ptr [r14+4*rdx+0x10]
+       mov      edx, dword ptr [rax+4*rdx+0x10]
        mov      rax, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rax
-       jne      SHORT G_M16263_IG12
+       jne      SHORT G_M16263_IG06
        cmp      edx, 99
-       mov      rcx, gword ptr [rbp-0x28]
-       jl       SHORT G_M16263_IG13
-       jmp      SHORT G_M16263_IG20
-						;; size=59 bbWeight=1.00 PerfScore 22.74
+       jge      SHORT G_M16263_IG18
+						;; size=48 bbWeight=1.00 PerfScore 19.74
 G_M16263_IG12:
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      SHORT G_M16263_IG20
-						;; size=11 bbWeight=1.00 PerfScore 6.25
-G_M16263_IG13:
-       mov      rcx, gword ptr [rbp-0x28]
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M16263_IG15
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
-       jae      SHORT G_M16263_IG14
-       mov      dword ptr [rcx+0x08], eax
+       jne      SHORT G_M16263_IG14
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
+       jae      SHORT G_M16263_IG13
+       mov      dword ptr [rcx+0x08], edx
        jmp      SHORT G_M16263_IG11
-						;; size=26 bbWeight=1.00 PerfScore 13.49
-G_M16263_IG14:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      SHORT G_M16263_IG18
+						;; size=22 bbWeight=1.00 PerfScore 12.49
+G_M16263_IG13:
+       mov      dword ptr [rcx+0x08], eax
+       jmp      SHORT G_M16263_IG16
 						;; size=5 bbWeight=1.00 PerfScore 3.00
-G_M16263_IG15:
+G_M16263_IG14:
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       SHORT G_M16263_IG18
-						;; size=17 bbWeight=1.00 PerfScore 4.50
-G_M16263_IG16:
-       mov      rcx, gword ptr [rbp-0x28]
+       je       SHORT G_M16263_IG16
+       mov      rcx, gword ptr [rbp-0x18]
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        mov      edx, eax
-       jmp      SHORT G_M16263_IG12
-						;; size=21 bbWeight=0 PerfScore 0.00
-G_M16263_IG17:
+       jmp      G_M16263_IG06
+						;; size=41 bbWeight=0 PerfScore 0.00
+G_M16263_IG15:
        mov      ecx, dword ptr [rcx+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16263_IG18:
-       mov      rcx, gword ptr [rbp-0x28]
+G_M16263_IG16:
+       mov      rcx, gword ptr [rbp-0x18]
        mov      rcx, rsp
-       call     G_M16263_IG28
+       call     G_M16263_IG26
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M16263_IG19:
-       jmp      SHORT G_M16263_IG26
+G_M16263_IG17:
+       jmp      SHORT G_M16263_IG24
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M16263_IG20:
-       mov      rcx, gword ptr [rbp-0x28]
+G_M16263_IG18:
        cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M16263_IG25
-						;; size=9 bbWeight=1 PerfScore 5.00
-G_M16263_IG21:
+       jne      SHORT G_M16263_IG23
+						;; size=5 bbWeight=1 PerfScore 4.00
+G_M16263_IG19:
        mov      eax, 1
 						;; size=5 bbWeight=1 PerfScore 0.25
-G_M16263_IG22:
+G_M16263_IG20:
        add      rsp, 48
        pop      rbx
        pop      rsi
-       pop      rdi
-       pop      r14
        pop      rbp
        ret      
-						;; size=11 bbWeight=1 PerfScore 3.75
-G_M16263_IG23:
+						;; size=8 bbWeight=1 PerfScore 2.75
+G_M16263_IG21:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M16263_IG24:
+G_M16263_IG22:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M16263_IG25:
+G_M16263_IG23:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M16263_IG21
+       jmp      SHORT G_M16263_IG19
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M16263_IG26:
+G_M16263_IG24:
        xor      eax, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M16263_IG27:
+G_M16263_IG25:
        add      rsp, 48
        pop      rbx
        pop      rsi
-       pop      rdi
-       pop      r14
        pop      rbp
        ret      
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16263_IG28:
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M16263_IG26:
        push     rbp
-       push     r14
-       push     rdi
        push     rsi
        push     rbx
        sub      rsp, 48
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x50]
-						;; size=23 bbWeight=0.01 PerfScore 0.06
-G_M16263_IG29:
-       cmp      gword ptr [rbp-0x28], 0
-       je       SHORT G_M16263_IG32
-						;; size=7 bbWeight=0.01 PerfScore 0.02
-G_M16263_IG30:
+       lea      rbp, [rbp+0x40]
+						;; size=20 bbWeight=0.00 PerfScore 0.03
+G_M16263_IG27:
+       cmp      gword ptr [rbp-0x18], 0
+       je       SHORT G_M16263_IG30
+						;; size=7 bbWeight=0.00 PerfScore 0.01
+G_M16263_IG28:
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rcx, gword ptr [rbp-0x28]
+       mov      rcx, gword ptr [rbp-0x18]
        cmp      qword ptr [rcx], rsi
-       je       SHORT G_M16263_IG32
-						;; size=19 bbWeight=0.01 PerfScore 0.04
-G_M16263_IG31:
-       mov      rcx, gword ptr [rbp-0x28]
+       je       SHORT G_M16263_IG30
+						;; size=19 bbWeight=0.00 PerfScore 0.03
+G_M16263_IG29:
+       mov      rcx, gword ptr [rbp-0x18]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M16263_IG32:
+G_M16263_IG30:
        nop      
-						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M16263_IG33:
+						;; size=1 bbWeight=0.00 PerfScore 0.00
+G_M16263_IG31:
        add      rsp, 48
        pop      rbx
        pop      rsi
-       pop      rdi
-       pop      r14
        pop      rbp
        ret      
-						;; size=11 bbWeight=0.01 PerfScore 0.03
+						;; size=8 bbWeight=0.00 PerfScore 0.01
 
-; Total bytes of code 529, prolog size 22, PerfScore 3991.69, instruction count 157, allocated bytes for code 529 (MethodHash=bbfdc078) for method System.Linq.Enumerable:Any[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte]):ubyte (Tier1)
+; Total bytes of code 484, prolog size 19, PerfScore 2739.56, instruction count 140, allocated bytes for code 488 (MethodHash=bbfdc078) for method System.Linq.Enumerable:Any[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte]):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.SingleWithPredicate_LastElementMatches(input: Array)``

Hot functions:

- (90.12%) ``Enumerable.TryGetSingle`` (Tier-1)
  - **Has diffs**
- (1.43%) ``Perf_Enumerable.SingleWithPredicate_LastElementMatches`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetSingle(class System.Collections.Generic.IEnumerable`1<!!0>,class System.Func`2<!!0,bool>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 57472
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 53760
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T11] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T03] ( 11,301.70)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
-;  V02 arg2         [V02,T12] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 35,806.55)     ref  ->  [rbp-0x30]  class-hnd EH-live spill-single-def <<unknown class>>
-;  V04 loc1         [V04,T04] (  8,299.70)     int  ->  r15        
+;  V00 arg0         [V00,T09] (  4,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T08] ( 11,  4.99)     ref  ->  rbx         class-hnd single-def <System.Func`2[int,ubyte]>
+;  V02 arg2         [V02,T11] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 40,704.11)     ref  ->  [rbp-0x28]  class-hnd EH-live spill-single-def <<unknown class>>
+;  V04 loc1         [V04,T06] (  7,199.88)     int  ->  r14        
 ;* V05 loc2         [V05    ] (  0,  0   )     int  ->  zero-ref   
 ;* V06 loc3         [V06    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V08 tmp1         [V08    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V09 tmp2         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V10 tmp3         [V10,T09] (  4,199.13)     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp3         [V10,T20] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V11 tmp4         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V12 tmp5         [V12,T13] (  2,  2   )     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp5         [V12,T16] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V13 tmp6         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V14 tmp7         [V14,T08] (  2,  1.99)     int  ->  rax         "guarded devirt return temp"
+;  V14 tmp7         [V14,T07] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V15 tmp8         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V16 tmp9         [V16    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V17 tmp10        [V17,T15] (  3,  2.99)     int  ->  r11         "Inline stloc first use temp"
-;  V18 tmp11        [V18,T05] (  6,297.72)     int  ->  rax         "Inline stloc first use temp"
-;  V19 tmp12        [V19,T01] (  6,597.39)     ref  ->  r14         "arr expr"
-;  V20 tmp13        [V20,T02] (  6,597.39)     int  ->   r8         "index expr"
-;  V21 tmp14        [V21,T19] (  2,  0   )     int  ->  rdx         "argument with side effect"
-;  V22 PSPSym       [V22,T18] (  1,  1   )    long  ->  [rbp-0x40]  do-not-enreg[V] "PSPSym"
-;  V23 cse0         [V23,T06] (  3,295.71)     int  ->   r8         "CSE #03: aggressive"
-;  V24 cse1         [V24,T07] (  3,295.71)     int  ->  rdi         "CSE #04: aggressive"
-;  V25 cse2         [V25,T14] (  3,  3   )     int  ->  rax         "CSE #08: moderate"
-;  V26 cse3         [V26,T16] (  3,  2.99)     int  ->   r8         "CSE #05: moderate"
-;  V27 cse4         [V27,T17] (  3,  2.99)     int  ->  rdi         "CSE #07: moderate"
-;  V28 cse5         [V28,T10] (  9,104.58)    long  ->  rsi         hoist multi-def "CSE #02: aggressive"
+;  V17 tmp10        [V17,T12] (  6,  3.01)     int  ->  rax         "Inline stloc first use temp"
+;  V18 tmp11        [V18,T03] (  6,297.33)     int  ->  rdx         "Inline stloc first use temp"
+;  V19 tmp12        [V19,T01] (  6,596.63)     ref  ->  rdi         "arr expr"
+;  V20 tmp13        [V20,T02] (  6,596.63)     int  ->   r8         "index expr"
+;  V21 tmp14        [V21,T19] (  4,  0   )     int  ->  rax         "argument with side effect"
+;  V22 PSPSym       [V22,T17] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V23 cse0         [V23,T04] (  3,295.33)     int  ->   r8         "CSE #03: aggressive"
+;  V24 cse1         [V24,T05] (  3,295.33)     int  ->  rax         "CSE #04: aggressive"
+;  V25 cse2         [V25,T13] (  3,  2.98)     int  ->   r8         "CSE #05: moderate"
+;  V26 cse3         [V26,T14] (  3,  2.98)     int  ->  rax         "CSE #07: moderate"
+;  V27 cse4         [V27,T15] (  3,  2.99)     int  ->  rdx         "CSE #08: moderate"
+;  V28 cse5         [V28,T18] (  3,  0.03)     int  ->  rdx         "CSE #09: conservative"
+;  V29 cse6         [V29,T10] (  9,  5.02)    long  ->  rsi         hoist multi-def "CSE #02: aggressive"
 ;
-; Lcl frame size = 56
+; Lcl frame size = 48
 
 G_M59240_IG01:
        push     rbp
-       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 56
-       lea      rbp, [rsp+0x60]
-       mov      qword ptr [rbp-0x40], rsp
+       sub      rsp, 48
+       lea      rbp, [rsp+0x50]
+       mov      qword ptr [rbp-0x30], rsp
        mov      bword ptr [rbp+0x20], r8
        mov      rbx, rdx
-						;; size=28 bbWeight=1 PerfScore 9.00
+						;; size=26 bbWeight=1 PerfScore 8.00
 G_M59240_IG02:
        test     rcx, rcx
-       je       G_M59240_IG30
+       je       G_M59240_IG35
        test     rbx, rbx
-       je       G_M59240_IG31
+       je       G_M59240_IG36
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rcx, rax
-       mov      gword ptr [rbp-0x30], rcx
+       mov      gword ptr [rbp-0x28], rcx
 						;; size=38 bbWeight=1 PerfScore 7.00
 G_M59240_IG03:
        test     rcx, rcx
@@ -957,258 +957,271 @@ G_M59240_IG03:
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      qword ptr [rcx], rsi
        jne      G_M59240_IG13
+       mov      rax, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_LastElementMatches>b__19_0(int):ubyte:this
+       cmp      qword ptr [rbx+0x18], rax
+       jne      SHORT G_M59240_IG13
        jmp      SHORT G_M59240_IG10
-						;; size=30 bbWeight=1 PerfScore 7.50
+       align    [0 bytes for IG04]
+						;; size=46 bbWeight=1 PerfScore 11.75
 G_M59240_IG04:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M59240_IG22
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M59240_IG08
-       mov      edx, r8d
-       mov      r15d, dword ptr [r14+4*rdx+0x10]
-       mov      rdx, 0xD1FFAB1E      ; code for System.Linq.Tests.Perf_Enumerable+<>c:<SingleWithPredicate_LastElementMatches>b__19_0(int):ubyte:this
-       cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG09
-       cmp      r15d, 99
+       jae      G_M59240_IG21
+       mov      rdi, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [rdi+0x08]
+       jae      SHORT G_M59240_IG09
+       mov      eax, r8d
+       mov      r14d, dword ptr [rdi+4*rax+0x10]
+       cmp      r14d, 99
        jl       SHORT G_M59240_IG10
-						;; size=54 bbWeight=98.57 PerfScore 1946.76
+						;; size=38 bbWeight=98.44 PerfScore 1525.88
 G_M59240_IG05:
-       mov      rcx, gword ptr [rbp-0x30]
        cmp      qword ptr [rcx], rsi
-       jne      G_M59240_IG25
-						;; size=13 bbWeight=100.57 PerfScore 502.83
+       jne      G_M59240_IG24
+						;; size=9 bbWeight=1 PerfScore 4.00
 G_M59240_IG06:
-       mov      r11d, dword ptr [rcx+0x08]
-       inc      r11d
-       mov      eax, dword ptr [rcx+0x0C]
-       cmp      r11d, eax
-       jae      G_M59240_IG18
-						;; size=19 bbWeight=1 PerfScore 5.50
+       mov      eax, dword ptr [rcx+0x08]
+       inc      eax
+       mov      edx, dword ptr [rcx+0x0C]
+       cmp      eax, edx
+       jae      G_M59240_IG23
+						;; size=16 bbWeight=1 PerfScore 5.50
 G_M59240_IG07:
-       mov      dword ptr [rcx+0x08], r11d
-       jmp      G_M59240_IG24
-						;; size=9 bbWeight=0.99 PerfScore 2.97
+       mov      dword ptr [rcx+0x08], eax
+       jmp      G_M59240_IG22
+						;; size=8 bbWeight=0.98 PerfScore 2.94
 G_M59240_IG08:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M59240_IG09:
-       mov      edx, r15d
+       mov      edx, r14d
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
+       mov      rcx, gword ptr [rbp-0x28]
        jne      SHORT G_M59240_IG05
-						;; size=14 bbWeight=98.57 PerfScore 640.71
+       jmp      SHORT G_M59240_IG15
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M59240_IG09:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M59240_IG10:
-       mov      rcx, gword ptr [rbp-0x30]
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M59240_IG12
-						;; size=16 bbWeight=98.57 PerfScore 640.71
+						;; size=12 bbWeight=98.44 PerfScore 541.44
 G_M59240_IG11:
-       mov      dword ptr [rcx+0x08], eax
-       jmp      G_M59240_IG04
-						;; size=8 bbWeight=97.60 PerfScore 292.80
+       mov      dword ptr [rcx+0x08], edx
+       jmp      SHORT G_M59240_IG04
+						;; size=5 bbWeight=97.47 PerfScore 292.40
 G_M59240_IG12:
-       mov      dword ptr [rcx+0x08], edi
-       jmp      G_M59240_IG32
-						;; size=8 bbWeight=98.57 PerfScore 295.71
+       mov      dword ptr [rcx+0x08], eax
+       jmp      G_M59240_IG30
+						;; size=8 bbWeight=98.44 PerfScore 295.33
 G_M59240_IG13:
        cmp      dword ptr [rcx], ecx
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M59240_IG16
-						;; size=14 bbWeight=0.01 PerfScore 0.05
+       jmp      SHORT G_M59240_IG15
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M59240_IG14:
        mov      r8d, dword ptr [rcx+0x08]
        cmp      r8d, dword ptr [rcx+0x0C]
-       jae      G_M59240_IG22
-       mov      r14, gword ptr [rcx+0x10]
-       cmp      r8d, dword ptr [r14+0x08]
-       jae      SHORT G_M59240_IG08
-       mov      edx, r8d
-       mov      r15d, dword ptr [r14+4*rdx+0x10]
+       jae      G_M59240_IG21
+       mov      rdi, gword ptr [rcx+0x10]
+       cmp      r8d, dword ptr [rdi+0x08]
+       jae      SHORT G_M59240_IG09
+       mov      eax, r8d
+       mov      r14d, dword ptr [rdi+4*rax+0x10]
        mov      rdx, 0xD1FFAB1E      ; function address
        cmp      qword ptr [rbx+0x18], rdx
-       jne      SHORT G_M59240_IG15
-       cmp      r15d, 99
-       mov      rcx, gword ptr [rbp-0x30]
-       jl       SHORT G_M59240_IG16
-       jmp      G_M59240_IG05
-						;; size=63 bbWeight=1.00 PerfScore 22.65
+       jne      SHORT G_M59240_IG08
+       cmp      r14d, 99
+       jge      G_M59240_IG05
+						;; size=58 bbWeight=0.99 PerfScore 19.64
 G_M59240_IG15:
-       mov      edx, r15d
-       mov      rcx, gword ptr [rbx+0x08]
-       call     [rbx+0x18]<unknown method>
-       test     eax, eax
-       jne      G_M59240_IG05
-						;; size=18 bbWeight=1.00 PerfScore 6.47
-G_M59240_IG16:
-       mov      rcx, gword ptr [rbp-0x30]
        cmp      qword ptr [rcx], rsi
        jne      SHORT G_M59240_IG20
-       mov      eax, dword ptr [rcx+0x08]
-       inc      eax
-       mov      edi, dword ptr [rcx+0x0C]
-       cmp      eax, edi
+						;; size=5 bbWeight=0.99 PerfScore 3.98
+G_M59240_IG16:
+       mov      edx, dword ptr [rcx+0x08]
+       inc      edx
+       mov      eax, dword ptr [rcx+0x0C]
+       cmp      edx, eax
        jae      SHORT G_M59240_IG19
-						;; size=21 bbWeight=1.00 PerfScore 10.45
+						;; size=12 bbWeight=0.99 PerfScore 5.47
 G_M59240_IG17:
-       mov      dword ptr [rcx+0x08], eax
+       mov      dword ptr [rcx+0x08], edx
        jmp      SHORT G_M59240_IG14
-						;; size=5 bbWeight=0.99 PerfScore 2.96
+						;; size=5 bbWeight=0.98 PerfScore 2.95
 G_M59240_IG18:
-       mov      dword ptr [rcx+0x08], eax
-       jmp      G_M59240_IG26
-						;; size=8 bbWeight=1 PerfScore 3.00
-G_M59240_IG19:
-       mov      dword ptr [rcx+0x08], edi
+       mov      r8, bword ptr [rbp+0x20]
+       mov      byte  ptr [r8], 1
        jmp      G_M59240_IG32
-						;; size=8 bbWeight=1.00 PerfScore 2.99
+						;; size=13 bbWeight=1 PerfScore 4.00
+G_M59240_IG19:
+       mov      dword ptr [rcx+0x08], eax
+       jmp      G_M59240_IG30
+						;; size=8 bbWeight=0.99 PerfScore 2.98
 G_M59240_IG20:
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       je       G_M59240_IG32
-						;; size=21 bbWeight=1.00 PerfScore 4.48
-G_M59240_IG21:
-       mov      rcx, gword ptr [rbp-0x30]
+       je       G_M59240_IG30
+       mov      rcx, gword ptr [rbp-0x28]
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
-       mov      r15d, eax
-       jmp      SHORT G_M59240_IG15
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M59240_IG22:
+       mov      r14d, eax
+       jmp      G_M59240_IG08
+						;; size=46 bbWeight=0 PerfScore 0.00
+G_M59240_IG21:
        mov      ecx, dword ptr [rcx+0x08]
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG23:
-       call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M59240_IG24:
-       mov      rcx, gword ptr [rbp-0x30]
+G_M59240_IG22:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      edx, eax
        mov      rcx, gword ptr [rbx+0x08]
        call     [rbx+0x18]<unknown method>
        test     eax, eax
-       jne      SHORT G_M59240_IG23
-       mov      rcx, gword ptr [rbp-0x30]
+       jne      SHORT G_M59240_IG29
+       mov      rcx, gword ptr [rbp-0x28]
+       jmp      G_M59240_IG06
+						;; size=35 bbWeight=0 PerfScore 0.00
+G_M59240_IG23:
+       mov      dword ptr [rcx+0x08], edx
+       jmp      SHORT G_M59240_IG18
+						;; size=5 bbWeight=0.99 PerfScore 2.97
+G_M59240_IG24:
+       mov      rcx, gword ptr [rbp-0x28]
        cmp      qword ptr [rcx], rsi
-       je       G_M59240_IG06
-						;; size=43 bbWeight=0 PerfScore 0.00
+       jne      SHORT G_M59240_IG27
+       mov      eax, dword ptr [rcx+0x08]
+       inc      eax
+       mov      edx, dword ptr [rcx+0x0C]
+       cmp      eax, edx
+       jae      SHORT G_M59240_IG26
+						;; size=21 bbWeight=0.01 PerfScore 0.11
 G_M59240_IG25:
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       mov      dword ptr [rcx+0x08], eax
+       jmp      SHORT G_M59240_IG28
+						;; size=5 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG26:
+       mov      dword ptr [rcx+0x08], edx
+       jmp      G_M59240_IG18
+						;; size=8 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG27:
+       mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       jne      SHORT G_M59240_IG24
-						;; size=17 bbWeight=1 PerfScore 4.50
-G_M59240_IG26:
-       mov      rcx, gword ptr [rbp-0x30]
-       mov      r8, bword ptr [rbp+0x20]
-       mov      byte  ptr [r8], 1
-						;; size=12 bbWeight=1 PerfScore 3.00
-G_M59240_IG27:
-       cmp      qword ptr [rcx], rsi
-       jne      SHORT G_M59240_IG34
-						;; size=5 bbWeight=1 PerfScore 4.00
+       mov      rcx, gword ptr [rbp-0x28]
+       je       G_M59240_IG18
+						;; size=25 bbWeight=0 PerfScore 0.00
 G_M59240_IG28:
-       mov      eax, r15d
-						;; size=3 bbWeight=1 PerfScore 0.25
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       mov      edx, eax
+       mov      rcx, gword ptr [rbx+0x08]
+       call     [rbx+0x18]<unknown method>
+       test     eax, eax
+       je       SHORT G_M59240_IG24
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M59240_IG29:
-       add      rsp, 56
+       call     [System.Linq.ThrowHelper:ThrowMoreThanOneMatchException()]
+       int3     
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M59240_IG30:
+       mov      rcx, gword ptr [rbp-0x28]
+       mov      rcx, rsp
+       call     G_M59240_IG40
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M59240_IG31:
+       jmp      SHORT G_M59240_IG38
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M59240_IG32:
+       cmp      qword ptr [rcx], rsi
+       jne      SHORT G_M59240_IG37
+						;; size=5 bbWeight=1 PerfScore 4.00
+G_M59240_IG33:
+       mov      eax, r14d
+						;; size=3 bbWeight=1 PerfScore 0.25
+G_M59240_IG34:
+       add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M59240_IG30:
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M59240_IG35:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG31:
+G_M59240_IG36:
        mov      ecx, 12
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG32:
-       mov      rcx, gword ptr [rbp-0x30]
-       mov      rcx, rsp
-       call     G_M59240_IG37
-						;; size=12 bbWeight=0 PerfScore 0.00
-G_M59240_IG33:
-       jmp      SHORT G_M59240_IG35
-						;; size=2 bbWeight=0 PerfScore 0.00
-G_M59240_IG34:
+G_M59240_IG37:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M59240_IG28
+       jmp      SHORT G_M59240_IG33
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M59240_IG35:
+G_M59240_IG38:
        mov      r8, bword ptr [rbp+0x20]
        mov      byte  ptr [r8], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M59240_IG36:
-       add      rsp, 56
+G_M59240_IG39:
+       add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M59240_IG37:
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M59240_IG40:
        push     rbp
-       push     r15
        push     r14
        push     rdi
        push     rsi
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 48
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0x60]
-						;; size=25 bbWeight=0.01 PerfScore 0.06
-G_M59240_IG38:
-       cmp      gword ptr [rbp-0x30], 0
-       je       SHORT G_M59240_IG41
-						;; size=7 bbWeight=0.01 PerfScore 0.02
-G_M59240_IG39:
+       lea      rbp, [rbp+0x50]
+						;; size=23 bbWeight=0.01 PerfScore 0.08
+G_M59240_IG41:
+       cmp      gword ptr [rbp-0x28], 0
+       je       SHORT G_M59240_IG44
+						;; size=7 bbWeight=0.01 PerfScore 0.03
+G_M59240_IG42:
        mov      rsi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       mov      rcx, gword ptr [rbp-0x30]
+       mov      rcx, gword ptr [rbp-0x28]
        cmp      qword ptr [rcx], rsi
-       je       SHORT G_M59240_IG41
-						;; size=19 bbWeight=0.01 PerfScore 0.03
-G_M59240_IG40:
-       mov      rcx, gword ptr [rbp-0x30]
+       je       SHORT G_M59240_IG44
+						;; size=19 bbWeight=0.01 PerfScore 0.05
+G_M59240_IG43:
+       mov      rcx, gword ptr [rbp-0x28]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M59240_IG41:
+G_M59240_IG44:
        nop      
 						;; size=1 bbWeight=0.01 PerfScore 0.00
-G_M59240_IG42:
-       add      rsp, 40
+G_M59240_IG45:
+       add      rsp, 48
        pop      rbx
        pop      rsi
        pop      rdi
        pop      r14
-       pop      r15
        pop      rbp
        ret      
-						;; size=13 bbWeight=0.01 PerfScore 0.03
+						;; size=11 bbWeight=0.01 PerfScore 0.04
 
-; Total bytes of code 690, prolog size 28, PerfScore 4420.67, instruction count 196, allocated bytes for code 690 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
+; Total bytes of code 705, prolog size 26, PerfScore 2744.59, instruction count 202, allocated bytes for code 709 (MethodHash=92d61897) for method System.Linq.Enumerable:TryGetSingle[int](System.Collections.Generic.IEnumerable`1[int],System.Func`2[int,ubyte],byref):int (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.IndexerSet<Int32>.Array(Size: 512)``

Hot functions:

- (93.89%) ``System.Collections.IndexerSet`1.Array`` (Tier-1)
  - **Has diffs**
- (1.41%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.IndexerSet`1[System.Int32].Array()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 102736
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 175104
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T03] (  3,   3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.IndexerSet`1[int]>
-;  V01 loc0         [V01,T01] (  4, 507.82)     ref  ->  rax         class-hnd single-def <int[]>
-;  V02 loc1         [V02,T00] (  5,2020.29)     int  ->  rcx        
+;  V01 loc0         [V01,T01] (  4, 505.64)     ref  ->  rax         class-hnd single-def <int[]>
+;* V02 loc1         [V02,T04] (  0,   0   )     int  ->  zero-ref   
 ;* V03 loc2         [V03    ] (  0,   0   )     int  ->  zero-ref    ld-addr-op
 ;  V04 OutArgs      [V04    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V05 cse0         [V05,T02] (  3, 506.82)     int  ->  rdx         "CSE #01: aggressive"
+;  V05 cse0         [V05,T02] (  3, 504.64)     int  ->  rdx         "CSE #01: aggressive"
+;  V06 rat0         [V06,T00] (  5,2011.57)    long  ->  rcx         "Widened IV V02"
 ;
 ; Lcl frame size = 40
 
@@ -231,21 +232,20 @@ G_M8068_IG02:
        mov      edx, dword ptr [rax+0x08]
        test     edx, edx
        jle      SHORT G_M8068_IG04
-       align    [15 bytes for IG03]
-						;; size=28 bbWeight=1 PerfScore 5.75
+       align    [0 bytes for IG03]
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M8068_IG03:
-       mov      r8d, ecx
-       xor      r10d, r10d
-       mov      dword ptr [rax+4*r8+0x10], r10d
+       xor      r8d, r8d
+       mov      dword ptr [rax+4*rcx+0x10], r8d
        inc      ecx
        cmp      edx, ecx
        jg       SHORT G_M8068_IG03
-						;; size=17 bbWeight=504.82 PerfScore 1514.47
+						;; size=14 bbWeight=502.64 PerfScore 1382.27
 G_M8068_IG04:
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 54, prolog size 4, PerfScore 1521.72, instruction count 15, allocated bytes for code 54 (MethodHash=b125e07b) for method System.Collections.IndexerSet`1[int]:Array():int[]:this (Tier1)
+; Total bytes of code 36, prolog size 4, PerfScore 1389.27, instruction count 14, allocated bytes for code 36 (MethodHash=b125e07b) for method System.Collections.IndexerSet`1[int]:Array():int[]:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.IndexerSet<Int32>.Span(Size: 512)``

Hot functions:

- (96.65%) ``System.Collections.IndexerSet`1.Span`` (Tier-1)
  - **Has diffs**
- (1.95%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.IndexerSet`1[System.Int32].Span()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 106864
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 174368
 ; 1 inlinees with PGO data; 0 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T04] (  3,   3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.IndexerSet`1[int]>
 ;* V01 loc0         [V01,T05] (  0,   0   )     int  ->  zero-ref    ld-addr-op single-def
 ;* V02 loc1         [V02    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[int]>
-;  V03 loc2         [V03,T00] (  5,2016.50)     int  ->  rax        
+;* V03 loc2         [V03,T06] (  0,   0   )     int  ->  zero-ref   
 ;  V04 OutArgs      [V04    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V05 tmp1         [V05,T03] (  4,   8   )     ref  ->  rax         class-hnd single-def "Inlining Arg" <int[]>
-;  V06 tmp2         [V06,T02] (  3, 504.87)   byref  ->  rcx         "field V02._reference (fldOffset=0x0)" P-INDEP
-;  V07 tmp3         [V07,T01] (  4, 505.87)     int  ->  rdx         "field V02._length (fldOffset=0x8)" P-INDEP
+;  V06 tmp2         [V06,T02] (  3, 503.13)   byref  ->  rcx         "field V02._reference (fldOffset=0x0)" P-INDEP
+;  V07 tmp3         [V07,T01] (  4, 504.13)     int  ->  rdx         "field V02._length (fldOffset=0x8)" P-INDEP
+;  V08 rat0         [V08,T00] (  5,2009.54)    long  ->  rax         "Widened IV V03"
 ;
 ; Lcl frame size = 40
 
@@ -211,13 +212,12 @@ G_M30807_IG03:
        align    [6 bytes for IG04]
 						;; size=12 bbWeight=1 PerfScore 1.75
 G_M30807_IG04:
-       mov      r8d, eax
-       xor      r10d, r10d
-       mov      dword ptr [rcx+4*r8], r10d
+       xor      r8d, r8d
+       mov      dword ptr [rcx+4*rax], r8d
        inc      eax
        cmp      eax, edx
        jl       SHORT G_M30807_IG04
-						;; size=16 bbWeight=503.87 PerfScore 1511.62
+						;; size=13 bbWeight=502.13 PerfScore 1380.87
 G_M30807_IG05:
        xor      eax, eax
 						;; size=2 bbWeight=1 PerfScore 0.25
@@ -231,6 +231,6 @@ G_M30807_IG07:
        jmp      SHORT G_M30807_IG03
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 61, prolog size 4, PerfScore 1520.87, instruction count 22, allocated bytes for code 61 (MethodHash=462f87a8) for method System.Collections.IndexerSet`1[int]:Span():int:this (Tier1)
+; Total bytes of code 58, prolog size 4, PerfScore 1390.12, instruction count 21, allocated bytes for code 58 (MethodHash=462f87a8) for method System.Collections.IndexerSet`1[int]:Span():int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Tests.Perf_String.IndexerCheckLengthHoisting``

Hot functions:

- (91.96%) ``Perf_String.IndexerCheckLengthHoisting`` (Tier-1)
  - **Has diffs**
- (5.73%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]Perf_String.IndexerCheckLengthHoisting()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1092352
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 669184
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Tests.Perf_String>
 ;* V01 loc0         [V01,T02] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
-;  V02 loc1         [V02,T01] (  4,141.49)     int  ->  rax        
-;  V03 loc2         [V03,T00] (  5,279.98)     int  ->  rcx        
+;  V02 loc1         [V02,T01] (  4,143.98)     int  ->  rax        
+;* V03 loc2         [V03,T03] (  0,  0   )     int  ->  zero-ref   
 ;  V04 OutArgs      [V04    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V05 rat0         [V05,T00] (  5,284.96)    long  ->  rcx         "Widened IV V03"
 ;
 ; Lcl frame size = 40
 
@@ -195,22 +196,21 @@ G_M54085_IG01:
 G_M54085_IG02:
        xor      eax, eax
        xor      ecx, ecx
-       align    [8 bytes for IG03]
-						;; size=12 bbWeight=1 PerfScore 0.75
+       align    [0 bytes for IG03]
+						;; size=4 bbWeight=1 PerfScore 0.50
 G_M54085_IG03:
-       mov      edx, ecx
-       mov      r8, 0xD1FFAB1E
-       movzx    rdx, word  ptr [r8+2*rdx+0x0C]
+       mov      rdx, 0xD1FFAB1E
+       movzx    rdx, word  ptr [rdx+2*rcx+0x0C]
        add      eax, edx
        inc      ecx
        cmp      ecx, 71
        jl       SHORT G_M54085_IG03
-						;; size=27 bbWeight=69.74 PerfScore 296.41
+						;; size=24 bbWeight=70.99 PerfScore 283.96
 G_M54085_IG04:
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 48, prolog size 4, PerfScore 298.66, instruction count 13, allocated bytes for code 48 (MethodHash=aa5b2cba) for method System.Tests.Perf_String:IndexerCheckLengthHoisting():int:this (Tier1)
+; Total bytes of code 37, prolog size 4, PerfScore 285.96, instruction count 12, allocated bytes for code 37 (MethodHash=aa5b2cba) for method System.Tests.Perf_String:IndexerCheckLengthHoisting():int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Tests.Perf_String.Trim(s: " Te st  ")``

Hot functions:

- (30.19%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (29.90%) ``String.Trim`` (Tier-1)
  - **Has diffs**
- (1.23%) ``Perf_String.Trim`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]String.Trim()``

```diff
 ;
 ;  V00 this         [V00,T00] (  7,  5.89)     ref  ->  rbx         this class-hnd single-def <System.String>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T04] (  2,  1.94)   ubyte  ->  rax         "Inline return value spill temp"
-;  V03 tmp2         [V03,T01] (  4,  7.75)  ushort  ->  rcx         "Inlining Arg"
+;  V02 tmp1         [V02,T05] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V03 tmp2         [V03,T01] (  4,  5.81)  ushort  ->  rcx         "Inlining Arg"
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V05 tmp4         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V06 tmp5         [V06    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V07 tmp6         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V08 tmp7         [V08,T05] (  2,  1.83)   ubyte  ->  rax         "Inline return value spill temp"
-;  V09 tmp8         [V09,T02] (  4,  7.33)  ushort  ->  rcx         "Inlining Arg"
+;  V08 tmp7         [V08,T06] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V09 tmp8         [V09,T02] (  4,  5.50)  ushort  ->  rcx         "Inlining Arg"
 ;* V10 tmp9         [V10    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V11 tmp10        [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V12 tmp11        [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
@@ -109,7 +109,7 @@ G_M14318_IG03:
 ;* V27 tmp26        [V27    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V28 tmp27        [V28    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V13._reference (fldOffset=0x0)" P-INDEP
 ;* V29 tmp28        [V29    ] (  0,  0   )     int  ->  zero-ref    "field V13._length (fldOffset=0x8)" P-INDEP
-;  V30 cse0         [V30,T06] (  2,  1.83)     int  ->  rsi         "CSE #02: aggressive"
+;  V30 cse0         [V30,T04] (  2,  1.83)     int  ->  rsi         "CSE #02: aggressive"
 ;  V31 cse1         [V31,T03] (  3,  2.92)     int  ->  rsi         "CSE #01: aggressive"
 ;
 ; Lcl frame size = 40
@@ -123,58 +123,46 @@ G_M60261_IG01:
 G_M60261_IG02:
        mov      esi, dword ptr [rbx+0x08]
        test     esi, esi
-       je       SHORT G_M60261_IG08
+       je       SHORT G_M60261_IG06
 						;; size=7 bbWeight=1 PerfScore 3.25
 G_M60261_IG03:
        movzx    rcx, word  ptr [rbx+0x0C]
        cmp      ecx, 256
-       jae      SHORT G_M60261_IG04
+       jae      G_M60261_IG11
        mov      rax, 0xD1FFAB1E      ; static handle
        test     byte  ptr [rcx+rax], 128
-       jne      SHORT G_M60261_IG11
-       jmp      SHORT G_M60261_IG05
-						;; size=30 bbWeight=0.97 PerfScore 9.21
+       jne      SHORT G_M60261_IG09
+						;; size=32 bbWeight=0.97 PerfScore 7.27
 G_M60261_IG04:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       jne      SHORT G_M60261_IG11
-						;; size=10 bbWeight=0.97 PerfScore 4.12
-G_M60261_IG05:
        dec      esi
        mov      ecx, esi
        movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
        cmp      ecx, 256
-       jae      SHORT G_M60261_IG06
+       jae      SHORT G_M60261_IG12
        mov      rax, 0xD1FFAB1E      ; static handle
        test     byte  ptr [rcx+rax], 128
-       jne      SHORT G_M60261_IG10
-       jmp      SHORT G_M60261_IG07
-						;; size=35 bbWeight=0.92 PerfScore 9.17
-G_M60261_IG06:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       jne      SHORT G_M60261_IG10
-						;; size=10 bbWeight=0.92 PerfScore 3.90
-G_M60261_IG07:
+       jne      SHORT G_M60261_IG08
+						;; size=33 bbWeight=0.92 PerfScore 7.33
+G_M60261_IG05:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
 						;; size=15 bbWeight=0.46 PerfScore 0.57
-G_M60261_IG08:
+G_M60261_IG06:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      rax, rbx
 						;; size=18 bbWeight=0.95 PerfScore 1.42
-G_M60261_IG09:
+G_M60261_IG07:
        add      rsp, 40
        pop      rbx
        pop      rsi
        ret      
 						;; size=7 bbWeight=0.95 PerfScore 2.13
-G_M60261_IG10:
+G_M60261_IG08:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
 						;; size=15 bbWeight=0.46 PerfScore 0.57
-G_M60261_IG11:
+G_M60261_IG09:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      rcx, rbx
@@ -182,14 +170,26 @@ G_M60261_IG11:
        call     [System.String:TrimWhiteSpaceHelper(int):System.String:this]
        nop      
 						;; size=30 bbWeight=0.05 PerfScore 0.26
-G_M60261_IG12:
+G_M60261_IG10:
        add      rsp, 40
        pop      rbx
        pop      rsi
        ret      
 						;; size=7 bbWeight=0.05 PerfScore 0.12
+G_M60261_IG11:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       jne      SHORT G_M60261_IG09
+       jmp      G_M60261_IG04
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M60261_IG12:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       jne      SHORT G_M60261_IG08
+       jmp      SHORT G_M60261_IG05
+						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 193, prolog size 6, PerfScore 37.21, instruction count 50, allocated bytes for code 193 (MethodHash=ccb0149a) for method System.String:Trim():System.String:this (Instrumented Tier1)
+; Total bytes of code 200, prolog size 6, PerfScore 25.43, instruction count 50, allocated bytes for code 200 (MethodHash=ccb0149a) for method System.String:Trim():System.String:this (Instrumented Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Tests.Perf_String:Trim(System.String):System.String:this (Tier1)
@@ -227,40 +227,40 @@ G_M14318_IG03:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 134816
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 142624
 ; 12 inlinees with PGO data; 20 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T04] ( 11, 10.01)     ref  ->  rbx         this class-hnd single-def <System.String>
+;  V00 this         [V00,T02] ( 11, 10.01)     ref  ->  rbx         this class-hnd single-def <System.String>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T11] (  2,  2   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V03 tmp2         [V03,T05] (  4,  8   )  ushort  ->  rcx         "Inlining Arg"
+;  V02 tmp1         [V02,T16] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V03 tmp2         [V03,T07] (  4,  6   )  ushort  ->  rcx         "Inlining Arg"
 ;* V04 tmp3         [V04    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V05 tmp4         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V06 tmp5         [V06    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V07 tmp6         [V07    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V08 tmp7         [V08,T01] ( 14, 16.13)     int  ->  rbp         "Inline stloc first use temp"
-;  V09 tmp8         [V09,T03] ( 11, 14.64)     int  ->  rdi         "Inline stloc first use temp"
-;  V10 tmp9         [V10,T08] (  2,  4.00)   ubyte  ->  rax         "Inline return value spill temp"
-;  V11 tmp10        [V11,T02] (  4, 15.99)  ushort  ->  rcx         "Inlining Arg"
+;  V08 tmp7         [V08,T01] ( 14, 16.10)     int  ->  r14         "Inline stloc first use temp"
+;  V09 tmp8         [V09,T06] (  8,  7.30)     int  ->  rdi         "Inline stloc first use temp"
+;  V10 tmp9         [V10,T17] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V11 tmp10        [V11,T03] (  4, 11.98)  ushort  ->  rcx         "Inlining Arg"
 ;* V12 tmp11        [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V13 tmp12        [V13    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V14 tmp13        [V14    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V15 tmp14        [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V16 tmp15        [V16,T07] (  4,  6.04)   ubyte  ->  rax         "Inline return value spill temp"
-;  V17 tmp16        [V17,T00] (  8, 24.17)  ushort  ->  rcx         "Inlining Arg"
+;  V16 tmp15        [V16,T15] (  4,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V17 tmp16        [V17,T00] (  8, 18.09)  ushort  ->  rcx         "Inlining Arg"
 ;* V18 tmp17        [V18    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V19 tmp18        [V19    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V20 tmp19        [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V21 tmp20        [V21    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V22 tmp21        [V22,T10] (  4,  2   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
-;  V23 tmp22        [V23,T09] (  5,  2.33)     int  ->  rbp         "Inline stloc first use temp"
+;  V22 tmp21        [V22,T09] (  4,  2   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
+;  V23 tmp22        [V23,T08] (  5,  2.33)     int  ->  r14         "Inline stloc first use temp"
 ;* V24 tmp23        [V24    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline return value spill temp" <System.String>
-;  V25 tmp24        [V25,T13] (  4,  0.43)     ref  ->  rsi         class-hnd exact single-def "Inline stloc first use temp" <System.String>
-;  V26 tmp25        [V26,T16] (  2,  0.22)    long  ->   r8         "Inline stloc first use temp"
-;  V27 tmp26        [V27,T14] (  3,  0.43)   byref  ->  rcx         single-def "Inlining Arg"
-;  V28 tmp27        [V28,T15] (  3,  0.43)   byref  ->  rdx         single-def "Inlining Arg"
-;  V29 tmp28        [V29,T12] (  3,  0.54)    long  ->   r8         "spilling arg"
+;  V25 tmp24        [V25,T11] (  4,  0.43)     ref  ->  rbp         class-hnd exact single-def "Inline stloc first use temp" <System.String>
+;  V26 tmp25        [V26,T14] (  2,  0.22)    long  ->   r8         "Inline stloc first use temp"
+;  V27 tmp26        [V27,T12] (  3,  0.43)   byref  ->  rcx         single-def "Inlining Arg"
+;  V28 tmp27        [V28,T13] (  3,  0.43)   byref  ->  rdx         single-def "Inlining Arg"
+;  V29 tmp28        [V29,T10] (  3,  0.54)    long  ->   r8         "spilling arg"
 ;* V30 tmp29        [V30    ] (  0,  0   )   byref  ->  zero-ref    "field V04._reference (fldOffset=0x0)" P-INDEP
 ;* V31 tmp30        [V31    ] (  0,  0   )     int  ->  zero-ref    "field V04._length (fldOffset=0x8)" P-INDEP
 ;* V32 tmp31        [V32    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V05._reference (fldOffset=0x0)" P-INDEP
@@ -285,191 +285,198 @@ G_M14318_IG03:
 ;* V51 tmp50        [V51    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V52 tmp51        [V52    ] (  0,  0   )   byref  ->  zero-ref    "field V21._reference (fldOffset=0x0)" P-INDEP
 ;* V53 tmp52        [V53    ] (  0,  0   )     int  ->  zero-ref    "field V21._length (fldOffset=0x8)" P-INDEP
-;  V54 cse0         [V54,T06] (  9,  7.54)     int  ->  rsi         "CSE #01: aggressive"
+;  V54 cse0         [V54,T05] (  9,  7.53)     int  ->  rsi         "CSE #01: aggressive"
+;  V55 rat0         [V55,T04] (  6,  9.65)    long  ->  rbp         "Widened IV V09"
 ;
-; Lcl frame size = 40
+; Lcl frame size = 32
 
 G_M60261_IG01:
+       push     r14
        push     rdi
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 40
+       sub      rsp, 32
        mov      rbx, rcx
-						;; size=11 bbWeight=1 PerfScore 4.50
+						;; size=13 bbWeight=1 PerfScore 5.50
 G_M60261_IG02:
        mov      esi, dword ptr [rbx+0x08]
        test     esi, esi
-       je       G_M60261_IG28
+       je       G_M60261_IG26
        movzx    rcx, word  ptr [rbx+0x0C]
        cmp      ecx, 256
-       jae      SHORT G_M60261_IG03
+       jae      G_M60261_IG24
        mov      rax, 0xD1FFAB1E      ; static handle
        test     byte  ptr [rcx+rax], 128
-       jne      SHORT G_M60261_IG04
-       jmp      G_M60261_IG27
-						;; size=44 bbWeight=1 PerfScore 12.75
+       je       G_M60261_IG25
+						;; size=47 bbWeight=1 PerfScore 10.75
 G_M60261_IG03:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       je       G_M60261_IG27
-						;; size=14 bbWeight=1 PerfScore 4.25
-G_M60261_IG04:
        xor      edi, edi
+       xor      ebp, ebp
        test     esi, esi
-       jle      SHORT G_M60261_IG08
-						;; size=6 bbWeight=1.00 PerfScore 1.51
-G_M60261_IG05:
-       mov      ecx, edi
-       movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
-       cmp      ecx, 256
-       jae      SHORT G_M60261_IG06
-       mov      rax, 0xD1FFAB1E      ; static handle
-       test     byte  ptr [rcx+rax], 128
-       je       SHORT G_M60261_IG08
-       jmp      SHORT G_M60261_IG07
-						;; size=33 bbWeight=2.00 PerfScore 19.49
-G_M60261_IG06:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       je       SHORT G_M60261_IG08
-						;; size=10 bbWeight=2.00 PerfScore 8.49
-G_M60261_IG07:
-       inc      edi
-       cmp      esi, edi
-       jg       SHORT G_M60261_IG05
-						;; size=6 bbWeight=2.00 PerfScore 3.00
-G_M60261_IG08:
-       lea      ebp, [rsi-0x01]
-       cmp      ebp, edi
-       jl       SHORT G_M60261_IG17
-						;; size=7 bbWeight=1.01 PerfScore 1.76
-G_M60261_IG09:
-       mov      ecx, ebp
-       or       ecx, edi
-       jl       SHORT G_M60261_IG14
-       cmp      esi, ebp
-       jle      SHORT G_M60261_IG14
-						;; size=10 bbWeight=0.50 PerfScore 1.39
-G_M60261_IG10:
-       mov      ecx, ebp
-       movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
-       cmp      ecx, 256
-       jae      SHORT G_M60261_IG11
-       mov      rax, 0xD1FFAB1E      ; static handle
-       test     byte  ptr [rcx+rax], 128
-       je       SHORT G_M60261_IG17
-       jmp      SHORT G_M60261_IG12
-						;; size=33 bbWeight=2.99 PerfScore 29.16
-G_M60261_IG11:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       je       SHORT G_M60261_IG17
-						;; size=10 bbWeight=2.99 PerfScore 12.71
-G_M60261_IG12:
-       dec      ebp
-       cmp      ebp, edi
-       jge      SHORT G_M60261_IG10
-						;; size=6 bbWeight=2.99 PerfScore 4.49
-G_M60261_IG13:
-       jmp      SHORT G_M60261_IG17
-						;; size=2 bbWeight=1 PerfScore 2.00
-G_M60261_IG14:
-       cmp      ebp, esi
-       jae      G_M60261_IG26
-       mov      ecx, ebp
-       movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
-       cmp      ecx, 256
-       jae      SHORT G_M60261_IG15
-       mov      rax, 0xD1FFAB1E      ; static handle
-       test     byte  ptr [rcx+rax], 128
-       je       SHORT G_M60261_IG17
-       jmp      SHORT G_M60261_IG16
-						;; size=41 bbWeight=0.03 PerfScore 0.33
-G_M60261_IG15:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       je       SHORT G_M60261_IG17
-						;; size=10 bbWeight=0.03 PerfScore 0.13
-G_M60261_IG16:
-       dec      ebp
-       cmp      ebp, edi
-       jge      SHORT G_M60261_IG14
-						;; size=6 bbWeight=0.03 PerfScore 0.05
-G_M60261_IG17:
-       sub      ebp, edi
-       inc      ebp
-       cmp      esi, ebp
-       jne      SHORT G_M60261_IG20
+       jle      SHORT G_M60261_IG07
 						;; size=8 bbWeight=1 PerfScore 1.75
-G_M60261_IG18:
+G_M60261_IG04:
+       movzx    rcx, word  ptr [rbx+2*rbp+0x0C]
+       cmp      ecx, 256
+       jae      G_M60261_IG28
+       mov      rax, 0xD1FFAB1E      ; static handle
+       test     byte  ptr [rcx+rax], 128
+       je       SHORT G_M60261_IG06
+						;; size=33 bbWeight=2.00 PerfScore 14.97
+G_M60261_IG05:
+       lea      ecx, [rbp+0x01]
+       mov      ebp, ecx
+       cmp      esi, ebp
+       jg       SHORT G_M60261_IG04
+						;; size=9 bbWeight=2.00 PerfScore 3.99
+G_M60261_IG06:
+       mov      edi, ebp
+						;; size=2 bbWeight=0.67 PerfScore 0.17
+G_M60261_IG07:
+       lea      r14d, [rsi-0x01]
+       cmp      r14d, edi
+       jl       SHORT G_M60261_IG14
+						;; size=9 bbWeight=1.00 PerfScore 1.75
+G_M60261_IG08:
+       mov      ecx, r14d
+       or       ecx, edi
+       jl       SHORT G_M60261_IG12
+       cmp      esi, r14d
+       jle      SHORT G_M60261_IG12
+						;; size=12 bbWeight=0.50 PerfScore 1.38
+G_M60261_IG09:
+       mov      ecx, r14d
+       movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
+       cmp      ecx, 256
+       jae      G_M60261_IG29
+       mov      rax, 0xD1FFAB1E      ; static handle
+       test     byte  ptr [rcx+rax], 128
+       je       SHORT G_M60261_IG14
+						;; size=36 bbWeight=2.98 PerfScore 23.13
+G_M60261_IG10:
+       dec      r14d
+       cmp      r14d, edi
+       jge      SHORT G_M60261_IG09
+						;; size=8 bbWeight=2.98 PerfScore 4.48
+G_M60261_IG11:
+       jmp      SHORT G_M60261_IG14
+						;; size=2 bbWeight=1 PerfScore 2.00
+G_M60261_IG12:
+       cmp      r14d, esi
+       jae      G_M60261_IG23
+       mov      ecx, r14d
+       movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
+       cmp      ecx, 256
+       jae      G_M60261_IG30
+       mov      rax, 0xD1FFAB1E      ; static handle
+       test     byte  ptr [rcx+rax], 128
+       je       SHORT G_M60261_IG14
+						;; size=45 bbWeight=0.03 PerfScore 0.27
+G_M60261_IG13:
+       dec      r14d
+       cmp      r14d, edi
+       jge      SHORT G_M60261_IG12
+						;; size=8 bbWeight=0.03 PerfScore 0.05
+G_M60261_IG14:
+       sub      r14d, edi
+       inc      r14d
+       cmp      esi, r14d
+       jne      SHORT G_M60261_IG17
+						;; size=11 bbWeight=1 PerfScore 1.75
+G_M60261_IG15:
        mov      rax, rbx
 						;; size=3 bbWeight=0.89 PerfScore 0.22
-G_M60261_IG19:
-       add      rsp, 40
+G_M60261_IG16:
+       add      rsp, 32
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=1 PerfScore 3.25
-G_M60261_IG20:
-       test     ebp, ebp
-       je       SHORT G_M60261_IG25
-						;; size=4 bbWeight=0.11 PerfScore 0.14
-G_M60261_IG21:
-       mov      ecx, ebp
+						;; size=11 bbWeight=1 PerfScore 3.75
+G_M60261_IG17:
+       test     r14d, r14d
+       je       SHORT G_M60261_IG22
+						;; size=5 bbWeight=0.11 PerfScore 0.14
+G_M60261_IG18:
+       mov      ecx, r14d
        call     <unknown method>
-       mov      rsi, rax
-       mov      r8d, ebp
-       cmp      byte  ptr [rsi], sil
-       lea      rcx, bword ptr [rsi+0x0C]
+       mov      rbp, rax
+       mov      r8d, r14d
+       cmp      byte  ptr [rbp], bpl
+       lea      rcx, bword ptr [rbp+0x0C]
        mov      edx, edi
        lea      rdx, bword ptr [rbx+2*rdx+0x0C]
        add      r8, r8
        cmp      r8, 10
-       jne      SHORT G_M60261_IG23
-						;; size=36 bbWeight=0.11 PerfScore 0.87
-G_M60261_IG22:
+       jne      SHORT G_M60261_IG20
+						;; size=38 bbWeight=0.11 PerfScore 0.87
+G_M60261_IG19:
        mov      rax, qword ptr [rdx]
        mov      r8, qword ptr [rdx+0x02]
        mov      qword ptr [rcx], rax
        mov      qword ptr [rcx+0x02], r8
-       jmp      SHORT G_M60261_IG24
+       jmp      SHORT G_M60261_IG21
 						;; size=16 bbWeight=0.05 PerfScore 0.43
-G_M60261_IG23:
+G_M60261_IG20:
        call     [<unknown method>]
 						;; size=6 bbWeight=0.05 PerfScore 0.16
-G_M60261_IG24:
-       mov      rax, rsi
-       jmp      SHORT G_M60261_IG19
+G_M60261_IG21:
+       mov      rax, rbp
+       jmp      SHORT G_M60261_IG16
 						;; size=5 bbWeight=0.11 PerfScore 0.24
-G_M60261_IG25:
+G_M60261_IG22:
        mov      rax, 0xD1FFAB1E
-       jmp      SHORT G_M60261_IG19
+       jmp      SHORT G_M60261_IG16
 						;; size=12 bbWeight=0.01 PerfScore 0.01
-G_M60261_IG26:
+G_M60261_IG23:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M60261_IG27:
+G_M60261_IG24:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       jne      G_M60261_IG03
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M60261_IG25:
        lea      ecx, [rsi-0x01]
        movzx    rcx, word  ptr [rbx+2*rcx+0x0C]
        call     [System.Char:IsWhiteSpace(ushort):ubyte]
        test     eax, eax
-       jne      G_M60261_IG04
+       jne      G_M60261_IG03
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M60261_IG28:
+G_M60261_IG26:
        mov      rax, rbx
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M60261_IG29:
-       add      rsp, 40
+G_M60261_IG27:
+       add      rsp, 32
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r14
        ret      
-						;; size=9 bbWeight=0 PerfScore 0.00
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M60261_IG28:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       je       G_M60261_IG06
+       jmp      G_M60261_IG05
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M60261_IG29:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       je       G_M60261_IG14
+       jmp      G_M60261_IG10
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M60261_IG30:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       je       G_M60261_IG14
+       jmp      G_M60261_IG13
+						;; size=19 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 387, prolog size 11, PerfScore 113.07, instruction count 122, allocated bytes for code 387 (MethodHash=ccb0149a) for method System.String:Trim():System.String:this (Tier1)
+; Total bytes of code 451, prolog size 13, PerfScore 77.77, instruction count 126, allocated bytes for code 451 (MethodHash=ccb0149a) for method System.String:Trim():System.String:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Tests.Perf_String.IndexerCheckBoundCheckHoist``

Hot functions:

- (91.56%) ``Perf_String.IndexerCheckBoundCheckHoist`` (Tier-1)
  - **Has diffs**
- (6.51%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]Perf_String.IndexerCheckBoundCheckHoist()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 706944
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 700672
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Tests.Perf_String>
 ;* V01 loc0         [V01,T03] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
-;  V02 loc1         [V02,T01] (  4,142.28)     int  ->  rax        
+;  V02 loc1         [V02,T01] (  4,142.49)     int  ->  rax        
 ;* V03 loc2         [V03,T04] (  0,  0   )     int  ->  zero-ref    single-def
-;  V04 loc3         [V04,T00] (  5,281.56)     int  ->  rcx        
+;* V04 loc3         [V04,T05] (  0,  0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 cse0         [V06,T02] (  0,  0   )     ref  ->  zero-ref    "CSE #01: aggressive"
+;  V07 rat0         [V07,T00] (  5,281.99)    long  ->  rcx         "Widened IV V04"
 ;
 ; Lcl frame size = 40
 
@@ -212,22 +213,21 @@ G_M25933_IG01:
 G_M25933_IG02:
        xor      eax, eax
        xor      ecx, ecx
-       align    [8 bytes for IG03]
-						;; size=12 bbWeight=1 PerfScore 0.75
+       align    [0 bytes for IG03]
+						;; size=4 bbWeight=1 PerfScore 0.50
 G_M25933_IG03:
-       mov      edx, ecx
-       mov      r8, 0xD1FFAB1E
-       movzx    rdx, word  ptr [r8+2*rdx+0x0C]
+       mov      rdx, 0xD1FFAB1E
+       movzx    rdx, word  ptr [rdx+2*rcx+0x0C]
        add      eax, edx
        inc      ecx
        cmp      ecx, 71
        jl       SHORT G_M25933_IG03
-						;; size=27 bbWeight=70.14 PerfScore 298.09
+						;; size=24 bbWeight=70.25 PerfScore 280.99
 G_M25933_IG04:
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=1 PerfScore 1.25
 
-; Total bytes of code 48, prolog size 4, PerfScore 300.34, instruction count 13, allocated bytes for code 48 (MethodHash=089a9ab2) for method System.Tests.Perf_String:IndexerCheckBoundCheckHoist():int:this (Tier1)
+; Total bytes of code 37, prolog size 4, PerfScore 282.99, instruction count 12, allocated bytes for code 37 (MethodHash=089a9ab2) for method System.Tests.Perf_String:IndexerCheckBoundCheckHoist():int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Numerics.Tests.Perf_BigInteger.Multiply(arguments: 1024,1024 bits)``

Hot functions:

- (81.98%) ``BigIntegerCalculator.MultiplyNearLength`` (FullOpt)
  - **Has diffs**
- (5.24%) ``BigIntegerCalculator.SubtractCore`` (Tier-1)
  - No diffs
- (3.44%) ``BigIntegerCalculator.Add`` (Tier-1)
  - No diffs
- (3.31%) ``BigIntegerCalculator.AddSelf`` (Tier-1)
  - No diffs
- (1.11%) ``BigInteger.Multiply`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Runtime.Numerics]BigIntegerCalculator.MultiplyNearLength(value class System.ReadOnlySpan`1<unsigned int32>,value class System.ReadOnlySpan`1<unsigned int32>,value class System.Span`1<unsigned int32>)``

```diff
 ;  V03 loc0         [V03,T06] (  3, 20.50)   byref  ->  rbx         single-def
 ;  V04 loc1         [V04,T04] (  7, 33.50)     int  ->  rcx        
 ;  V05 loc2         [V05,T03] (  4, 40   )    long  ->  rdx        
-;  V06 loc3         [V06,T00] (  6, 84   )     int  ->   r8        
+;* V06 loc3         [V06,T19] (  0,  0   )     int  ->  zero-ref   
 ;  V07 loc4         [V07,T01] (  3, 48   )   byref  ->  r10        
 ;  V08 loc5         [V08,T02] (  3, 48   )    long  ->  rdx        
 ;  V09 loc6         [V09,T14] ( 10,  5   )     int  ->  r12        
-;  V10 loc7         [V10,T28] (  5,  2.50)     int  ->  [rbp+0xD4]  spill-single-def
+;  V10 loc7         [V10,T29] (  5,  2.50)     int  ->  [rbp+0xD4]  spill-single-def
 ;* V11 loc8         [V11    ] (  0,  0   )  struct (16) zero-ref    <System.ReadOnlySpan`1[uint]>
 ;* V12 loc9         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[uint]>
 ;* V13 loc10        [V13    ] (  0,  0   )  struct (16) zero-ref    <System.ReadOnlySpan`1[uint]>
 ;* V14 loc11        [V14    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[uint]>
 ;* V15 loc12        [V15    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
 ;* V16 loc13        [V16    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
-;  V17 loc14        [V17,T19] (  7,  3.50)     int  ->  [rbp+0xD0]  spill-single-def
-;  V18 loc15        [V18,T21] (  7,  3.06)     ref  ->  [rbp+0x70]  class-hnd <uint[]>
+;  V17 loc14        [V17,T20] (  7,  3.50)     int  ->  [rbp+0xD0]  spill-single-def
+;  V18 loc15        [V18,T22] (  7,  3.06)     ref  ->  [rbp+0x70]  class-hnd <uint[]>
 ;* V19 loc16        [V19    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
-;  V20 loc17        [V20,T20] (  7,  3.50)     int  ->  [rbp+0xCC]  spill-single-def
-;  V21 loc18        [V21,T22] (  7,  3.06)     ref  ->  [rbp+0x68]  class-hnd <uint[]>
+;  V20 loc17        [V20,T21] (  7,  3.50)     int  ->  [rbp+0xCC]  spill-single-def
+;  V21 loc18        [V21,T23] (  7,  3.06)     ref  ->  [rbp+0x68]  class-hnd <uint[]>
 ;* V22 loc19        [V22    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;  V23 loc20        [V23,T15] (  8,  4   )     int  ->  [rbp+0xC8]  spill-single-def
-;  V24 loc21        [V24,T23] (  7,  3.06)     ref  ->  [rbp+0x60]  class-hnd <uint[]>
+;  V24 loc21        [V24,T24] (  7,  3.06)     ref  ->  [rbp+0x60]  class-hnd <uint[]>
 ;* V25 loc22        [V25    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;* V26 loc23        [V26    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;* V27 loc24        [V27    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
 ;* V28 loc25        [V28    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;* V29 loc26        [V29    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;  V30 OutArgs      [V30    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V31 tmp1         [V31,T36] (  2,  2   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
-;  V32 tmp2         [V32,T37] (  2,  2   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
-;  V33 tmp3         [V33,T38] (  2,  2   )     ref  ->   r8         class-hnd single-def "dup spill" <uint[]>
+;  V31 tmp1         [V31,T37] (  2,  2   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
+;  V32 tmp2         [V32,T38] (  2,  2   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
+;  V33 tmp3         [V33,T39] (  2,  2   )     ref  ->   r8         class-hnd single-def "dup spill" <uint[]>
 ;* V34 tmp4         [V34    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[uint]>
 ;* V35 tmp5         [V35    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[uint]>
 ;* V36 tmp6         [V36    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[uint]>
@@ -55,27 +55,27 @@
 ;* V44 tmp14        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
 ;* V45 tmp15        [V45    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V46 tmp16        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
-;  V47 tmp17        [V47,T39] (  2,  2   )   byref  ->   r9         single-def "Inlining Arg"
-;  V48 tmp18        [V48,T26] (  3,  3   )     int  ->  r13         "Inlining Arg"
+;  V47 tmp17        [V47,T40] (  2,  2   )   byref  ->   r9         single-def "Inlining Arg"
+;  V48 tmp18        [V48,T27] (  3,  3   )     int  ->  r13         "Inlining Arg"
 ;* V49 tmp19        [V49    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
 ;* V50 tmp20        [V50    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V51 tmp21        [V51    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
-;  V52 tmp22        [V52,T40] (  2,  2   )   byref  ->   r8         single-def "Inlining Arg"
-;  V53 tmp23        [V53,T27] (  3,  3   )     int  ->  r14         "Inlining Arg"
+;  V52 tmp22        [V52,T41] (  2,  2   )   byref  ->   r8         single-def "Inlining Arg"
+;  V53 tmp23        [V53,T28] (  3,  3   )     int  ->  r14         "Inlining Arg"
 ;* V54 tmp24        [V54    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V55 tmp25        [V55    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V56 tmp26        [V56    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;  V57 tmp27        [V57,T17] (  3,  3   )   byref  ->  [rbp+0x58]  spill-single-def "Inlining Arg"
 ;  V58 tmp28        [V58,T18] (  3,  3   )     int  ->  [rbp+0xC4]  spill-single-def "Inlining Arg"
-;  V59 tmp29        [V59,T48] (  2,  2   )    long  ->   r9         "Inlining Arg"
+;  V59 tmp29        [V59,T49] (  2,  2   )    long  ->   r9         "Inlining Arg"
 ;* V60 tmp30        [V60    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V61 tmp31        [V61    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V62 tmp32        [V62    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V63 tmp33        [V63,T49] (  2,  2   )    long  ->   r9         "Inlining Arg"
+;  V63 tmp33        [V63,T50] (  2,  2   )    long  ->   r9         "Inlining Arg"
 ;* V64 tmp34        [V64    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V65 tmp35        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V66 tmp36        [V66    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V67 tmp37        [V67,T50] (  2,  2   )    long  ->  r10         "Inlining Arg"
+;  V67 tmp37        [V67,T51] (  2,  2   )    long  ->  r10         "Inlining Arg"
 ;* V68 tmp38        [V68    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V69 tmp39        [V69    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V70 tmp40        [V70    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -96,8 +96,8 @@
 ;* V85 tmp55        [V85    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V86 tmp56        [V86    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V87 tmp57        [V87    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
-;  V88 tmp58        [V88,T41] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
-;  V89 tmp59        [V89,T51] (  2,  2   )     int  ->  rsi         "Inlining Arg"
+;  V88 tmp58        [V88,T42] (  2,  2   )   byref  ->  rdi         single-def "Inlining Arg"
+;  V89 tmp59        [V89,T52] (  2,  2   )     int  ->  rsi         "Inlining Arg"
 ;* V90 tmp60        [V90    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[uint]>
 ;* V91 tmp61        [V91    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
 ;* V92 tmp62        [V92    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
@@ -107,7 +107,7 @@
 ;  V96 tmp66        [V96,T08] (  3, 17.50)   byref  ->  rdi         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
 ;  V97 tmp67        [V97,T13] (  7,  8   )     int  ->  r14         "field V01._length (fldOffset=0x8)" P-INDEP
 ;  V98 tmp68        [V98,T16] (  6,  3.50)   byref  ->  rbx         single-def "field V02._reference (fldOffset=0x0)" P-INDEP
-;  V99 tmp69        [V99,T25] (  5,  3   )     int  ->  rsi         "field V02._length (fldOffset=0x8)" P-INDEP
+;  V99 tmp69        [V99,T26] (  5,  3   )     int  ->  rsi         "field V02._length (fldOffset=0x8)" P-INDEP
 ;* V100 tmp70       [V100    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V101 tmp71       [V101    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V102 tmp72       [V102    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V12._reference (fldOffset=0x0)" P-INDEP
@@ -126,14 +126,14 @@
 ;* V115 tmp85       [V115    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
 ;* V116 tmp86       [V116    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V25._reference (fldOffset=0x0)" P-INDEP
 ;* V117 tmp87       [V117    ] (  0,  0   )     int  ->  zero-ref    "field V25._length (fldOffset=0x8)" P-INDEP
-;  V118 tmp88       [V118,T29] (  4,  2   )   byref  ->  [rbp+0x50]  "field V26._reference (fldOffset=0x0)" P-INDEP
-;  V119 tmp89       [V119,T56] (  3,  1.50)     int  ->  r11         "field V26._length (fldOffset=0x8)" P-INDEP
+;  V118 tmp88       [V118,T30] (  4,  2   )   byref  ->  [rbp+0x50]  "field V26._reference (fldOffset=0x0)" P-INDEP
+;  V119 tmp89       [V119,T57] (  3,  1.50)     int  ->  r11         "field V26._length (fldOffset=0x8)" P-INDEP
 ;* V120 tmp90       [V120    ] (  0,  0   )   byref  ->  zero-ref    "field V27._reference (fldOffset=0x0)" P-INDEP
 ;* V121 tmp91       [V121    ] (  0,  0   )     int  ->  zero-ref    "field V27._length (fldOffset=0x8)" P-INDEP
-;  V122 tmp92       [V122,T30] (  4,  2   )   byref  ->  [rbp+0x48]  "field V28._reference (fldOffset=0x0)" P-INDEP
-;  V123 tmp93       [V123,T57] (  3,  1.50)     int  ->  r11         "field V28._length (fldOffset=0x8)" P-INDEP
-;  V124 tmp94       [V124,T31] (  4,  2   )   byref  ->  [rbp+0x40]  "field V29._reference (fldOffset=0x0)" P-INDEP
-;  V125 tmp95       [V125,T58] (  3,  1.50)     int  ->   r9         "field V29._length (fldOffset=0x8)" P-INDEP
+;  V122 tmp92       [V122,T31] (  4,  2   )   byref  ->  [rbp+0x48]  "field V28._reference (fldOffset=0x0)" P-INDEP
+;  V123 tmp93       [V123,T58] (  3,  1.50)     int  ->  r11         "field V28._length (fldOffset=0x8)" P-INDEP
+;  V124 tmp94       [V124,T32] (  4,  2   )   byref  ->  [rbp+0x40]  "field V29._reference (fldOffset=0x0)" P-INDEP
+;  V125 tmp95       [V125,T59] (  3,  1.50)     int  ->   r9         "field V29._length (fldOffset=0x8)" P-INDEP
 ;* V126 tmp96       [V126    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V34._reference (fldOffset=0x0)" P-INDEP
 ;* V127 tmp97       [V127    ] (  0,  0   )     int  ->  zero-ref    "field V34._length (fldOffset=0x8)" P-INDEP
 ;* V128 tmp98       [V128    ] (  0,  0   )   byref  ->  zero-ref    "field V35._reference (fldOffset=0x0)" P-INDEP
@@ -146,75 +146,76 @@
 ;* V135 tmp105      [V135    ] (  0,  0   )     int  ->  zero-ref    "field V38._length (fldOffset=0x8)" P-INDEP
 ;* V136 tmp106      [V136    ] (  0,  0   )   byref  ->  zero-ref    "field V39._reference (fldOffset=0x0)" P-INDEP
 ;* V137 tmp107      [V137    ] (  0,  0   )     int  ->  zero-ref    "field V39._length (fldOffset=0x8)" P-INDEP
-;  V138 tmp108      [V138,T70] (  2,  1   )   byref  ->  r10         single-def "field V40._reference (fldOffset=0x0)" P-INDEP
-;* V139 tmp109      [V139,T88] (  0,  0   )     int  ->  zero-ref    "field V40._length (fldOffset=0x8)" P-INDEP
-;  V140 tmp110      [V140,T71] (  2,  1   )   byref  ->   r9         single-def "field V41._reference (fldOffset=0x0)" P-INDEP
-;* V141 tmp111      [V141,T89] (  0,  0   )     int  ->  zero-ref    "field V41._length (fldOffset=0x8)" P-INDEP
-;  V142 tmp112      [V142,T72] (  2,  1   )   byref  ->   r9         single-def "field V42._reference (fldOffset=0x0)" P-INDEP
-;* V143 tmp113      [V143,T90] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
+;  V138 tmp108      [V138,T71] (  2,  1   )   byref  ->  r10         single-def "field V40._reference (fldOffset=0x0)" P-INDEP
+;* V139 tmp109      [V139,T89] (  0,  0   )     int  ->  zero-ref    "field V40._length (fldOffset=0x8)" P-INDEP
+;  V140 tmp110      [V140,T72] (  2,  1   )   byref  ->   r9         single-def "field V41._reference (fldOffset=0x0)" P-INDEP
+;* V141 tmp111      [V141,T90] (  0,  0   )     int  ->  zero-ref    "field V41._length (fldOffset=0x8)" P-INDEP
+;  V142 tmp112      [V142,T73] (  2,  1   )   byref  ->   r9         single-def "field V42._reference (fldOffset=0x0)" P-INDEP
+;* V143 tmp113      [V143,T91] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
 ;* V144 tmp114      [V144    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V43._reference (fldOffset=0x0)" P-INDEP
 ;* V145 tmp115      [V145    ] (  0,  0   )     int  ->  zero-ref    "field V43._length (fldOffset=0x8)" P-INDEP
-;  V146 tmp116      [V146,T32] (  4,  2   )   byref  ->  r15         single-def "field V44._reference (fldOffset=0x0)" P-INDEP
-;  V147 tmp117      [V147,T24] (  5,  2.50)     int  ->  rcx         "field V44._length (fldOffset=0x8)" P-INDEP
-;  V148 tmp118      [V148,T52] (  3,  1.50)   byref  ->  [rbp+0x38]  spill-single-def "field V46._reference (fldOffset=0x0)" P-INDEP
-;  V149 tmp119      [V149,T59] (  3,  1.50)     int  ->  [rbp+0xC0]  spill-single-def "field V46._length (fldOffset=0x8)" P-INDEP
-;  V150 tmp120      [V150,T33] (  4,  2   )   byref  ->  rdi         single-def "field V49._reference (fldOffset=0x0)" P-INDEP
-;* V151 tmp121      [V151,T91] (  0,  0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
-;  V152 tmp122      [V152,T53] (  3,  1.50)   byref  ->  [rbp+0x30]  spill-single-def "field V51._reference (fldOffset=0x0)" P-INDEP
-;  V153 tmp123      [V153,T60] (  3,  1.50)     int  ->  [rbp+0xBC]  spill-single-def "field V51._length (fldOffset=0x8)" P-INDEP
-;  V154 tmp124      [V154,T73] (  2,  1   )   byref  ->  [rbp+0x28]  spill-single-def "field V54._reference (fldOffset=0x0)" P-INDEP
-;  V155 tmp125      [V155,T61] (  3,  1.50)     int  ->  rcx         "field V54._length (fldOffset=0x8)" P-INDEP
-;* V156 tmp126      [V156,T86] (  0,  0   )   byref  ->  zero-ref    single-def "field V56._reference (fldOffset=0x0)" P-INDEP
-;* V157 tmp127      [V157,T92] (  0,  0   )     int  ->  zero-ref    "field V56._length (fldOffset=0x8)" P-INDEP
-;  V158 tmp128      [V158,T64] (  3,  1.00)   byref  ->   r9         "field V60._reference (fldOffset=0x0)" P-INDEP
-;  V159 tmp129      [V159,T67] (  3,  1.00)     int  ->  r11         "field V60._length (fldOffset=0x8)" P-INDEP
-;  V160 tmp130      [V160,T54] (  3,  1.50)   byref  ->  [rbp+0x20]  spill-single-def "field V61._reference (fldOffset=0x0)" P-INDEP
-;  V161 tmp131      [V161,T62] (  3,  1.50)     int  ->  [rbp+0xB8]  spill-single-def "field V61._length (fldOffset=0x8)" P-INDEP
-;  V162 tmp132      [V162,T65] (  3,  1.00)   byref  ->   r9         "field V64._reference (fldOffset=0x0)" P-INDEP
-;  V163 tmp133      [V163,T68] (  3,  1.00)     int  ->  r11         "field V64._length (fldOffset=0x8)" P-INDEP
-;  V164 tmp134      [V164,T55] (  3,  1.50)   byref  ->  [rbp+0x18]  spill-single-def "field V65._reference (fldOffset=0x0)" P-INDEP
-;  V165 tmp135      [V165,T63] (  3,  1.50)     int  ->  [rbp+0xB4]  spill-single-def "field V65._length (fldOffset=0x8)" P-INDEP
-;  V166 tmp136      [V166,T66] (  3,  1.00)   byref  ->  r10         "field V68._reference (fldOffset=0x0)" P-INDEP
-;  V167 tmp137      [V167,T69] (  3,  1.00)     int  ->   r9         "field V68._length (fldOffset=0x8)" P-INDEP
-;  V168 tmp138      [V168,T34] (  4,  2   )   byref  ->  [rbp+0x10]  spill-single-def "field V69._reference (fldOffset=0x0)" P-INDEP
-;  V169 tmp139      [V169,T79] (  2,  1   )     int  ->  rdx         "field V69._length (fldOffset=0x8)" P-INDEP
+;  V146 tmp116      [V146,T33] (  4,  2   )   byref  ->  r15         single-def "field V44._reference (fldOffset=0x0)" P-INDEP
+;  V147 tmp117      [V147,T25] (  5,  2.50)     int  ->  rcx         "field V44._length (fldOffset=0x8)" P-INDEP
+;  V148 tmp118      [V148,T53] (  3,  1.50)   byref  ->  [rbp+0x38]  spill-single-def "field V46._reference (fldOffset=0x0)" P-INDEP
+;  V149 tmp119      [V149,T60] (  3,  1.50)     int  ->  [rbp+0xC0]  spill-single-def "field V46._length (fldOffset=0x8)" P-INDEP
+;  V150 tmp120      [V150,T34] (  4,  2   )   byref  ->  rdi         single-def "field V49._reference (fldOffset=0x0)" P-INDEP
+;* V151 tmp121      [V151,T92] (  0,  0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
+;  V152 tmp122      [V152,T54] (  3,  1.50)   byref  ->  [rbp+0x30]  spill-single-def "field V51._reference (fldOffset=0x0)" P-INDEP
+;  V153 tmp123      [V153,T61] (  3,  1.50)     int  ->  [rbp+0xBC]  spill-single-def "field V51._length (fldOffset=0x8)" P-INDEP
+;  V154 tmp124      [V154,T74] (  2,  1   )   byref  ->  [rbp+0x28]  spill-single-def "field V54._reference (fldOffset=0x0)" P-INDEP
+;  V155 tmp125      [V155,T62] (  3,  1.50)     int  ->  rcx         "field V54._length (fldOffset=0x8)" P-INDEP
+;* V156 tmp126      [V156,T87] (  0,  0   )   byref  ->  zero-ref    single-def "field V56._reference (fldOffset=0x0)" P-INDEP
+;* V157 tmp127      [V157,T93] (  0,  0   )     int  ->  zero-ref    "field V56._length (fldOffset=0x8)" P-INDEP
+;  V158 tmp128      [V158,T65] (  3,  1.00)   byref  ->   r9         "field V60._reference (fldOffset=0x0)" P-INDEP
+;  V159 tmp129      [V159,T68] (  3,  1.00)     int  ->  r11         "field V60._length (fldOffset=0x8)" P-INDEP
+;  V160 tmp130      [V160,T55] (  3,  1.50)   byref  ->  [rbp+0x20]  spill-single-def "field V61._reference (fldOffset=0x0)" P-INDEP
+;  V161 tmp131      [V161,T63] (  3,  1.50)     int  ->  [rbp+0xB8]  spill-single-def "field V61._length (fldOffset=0x8)" P-INDEP
+;  V162 tmp132      [V162,T66] (  3,  1.00)   byref  ->   r9         "field V64._reference (fldOffset=0x0)" P-INDEP
+;  V163 tmp133      [V163,T69] (  3,  1.00)     int  ->  r11         "field V64._length (fldOffset=0x8)" P-INDEP
+;  V164 tmp134      [V164,T56] (  3,  1.50)   byref  ->  [rbp+0x18]  spill-single-def "field V65._reference (fldOffset=0x0)" P-INDEP
+;  V165 tmp135      [V165,T64] (  3,  1.50)     int  ->  [rbp+0xB4]  spill-single-def "field V65._length (fldOffset=0x8)" P-INDEP
+;  V166 tmp136      [V166,T67] (  3,  1.00)   byref  ->  r10         "field V68._reference (fldOffset=0x0)" P-INDEP
+;  V167 tmp137      [V167,T70] (  3,  1.00)     int  ->   r9         "field V68._length (fldOffset=0x8)" P-INDEP
+;  V168 tmp138      [V168,T35] (  4,  2   )   byref  ->  [rbp+0x10]  spill-single-def "field V69._reference (fldOffset=0x0)" P-INDEP
+;  V169 tmp139      [V169,T80] (  2,  1   )     int  ->  rdx         "field V69._length (fldOffset=0x8)" P-INDEP
 ;* V170 tmp140      [V170    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V71._reference (fldOffset=0x0)" P-INDEP
 ;* V171 tmp141      [V171    ] (  0,  0   )     int  ->  zero-ref    "field V71._length (fldOffset=0x8)" P-INDEP
-;  V172 tmp142      [V172,T74] (  2,  1   )   byref  ->  r13         single-def "field V72._reference (fldOffset=0x0)" P-INDEP
-;  V173 tmp143      [V173,T80] (  2,  1   )     int  ->  r15         "field V72._length (fldOffset=0x8)" P-INDEP
+;  V172 tmp142      [V172,T75] (  2,  1   )   byref  ->  r13         single-def "field V72._reference (fldOffset=0x0)" P-INDEP
+;  V173 tmp143      [V173,T81] (  2,  1   )     int  ->  r15         "field V72._length (fldOffset=0x8)" P-INDEP
 ;* V174 tmp144      [V174    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V75._reference (fldOffset=0x0)" P-INDEP
 ;* V175 tmp145      [V175    ] (  0,  0   )     int  ->  zero-ref    "field V75._length (fldOffset=0x8)" P-INDEP
-;  V176 tmp146      [V176,T75] (  2,  1   )   byref  ->  rcx         single-def "field V76._reference (fldOffset=0x0)" P-INDEP
-;  V177 tmp147      [V177,T81] (  2,  1   )     int  ->  rdi         "field V76._length (fldOffset=0x8)" P-INDEP
+;  V176 tmp146      [V176,T76] (  2,  1   )   byref  ->  rcx         single-def "field V76._reference (fldOffset=0x0)" P-INDEP
+;  V177 tmp147      [V177,T82] (  2,  1   )     int  ->  rdi         "field V76._length (fldOffset=0x8)" P-INDEP
 ;* V178 tmp148      [V178    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V79._reference (fldOffset=0x0)" P-INDEP
 ;* V179 tmp149      [V179    ] (  0,  0   )     int  ->  zero-ref    "field V79._length (fldOffset=0x8)" P-INDEP
-;  V180 tmp150      [V180,T76] (  2,  1   )   byref  ->  r14         single-def "field V80._reference (fldOffset=0x0)" P-INDEP
-;  V181 tmp151      [V181,T82] (  2,  1   )     int  ->  r13         "field V80._length (fldOffset=0x8)" P-INDEP
+;  V180 tmp150      [V180,T77] (  2,  1   )   byref  ->  r14         single-def "field V80._reference (fldOffset=0x0)" P-INDEP
+;  V181 tmp151      [V181,T83] (  2,  1   )     int  ->  r13         "field V80._length (fldOffset=0x8)" P-INDEP
 ;* V182 tmp152      [V182    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V83._reference (fldOffset=0x0)" P-INDEP
 ;* V183 tmp153      [V183    ] (  0,  0   )     int  ->  zero-ref    "field V83._length (fldOffset=0x8)" P-INDEP
-;* V184 tmp154      [V184,T87] (  0,  0   )   byref  ->  zero-ref    single-def "field V84._reference (fldOffset=0x0)" P-INDEP
-;  V185 tmp155      [V185,T83] (  2,  1   )     int  ->  rcx         "field V84._length (fldOffset=0x8)" P-INDEP
-;  V186 tmp156      [V186,T77] (  2,  1   )   byref  ->  rdi         single-def "field V87._reference (fldOffset=0x0)" P-INDEP
-;  V187 tmp157      [V187,T84] (  2,  1   )     int  ->  rsi         "field V87._length (fldOffset=0x8)" P-INDEP
+;* V184 tmp154      [V184,T88] (  0,  0   )   byref  ->  zero-ref    single-def "field V84._reference (fldOffset=0x0)" P-INDEP
+;  V185 tmp155      [V185,T84] (  2,  1   )     int  ->  rcx         "field V84._length (fldOffset=0x8)" P-INDEP
+;  V186 tmp156      [V186,T78] (  2,  1   )   byref  ->  rdi         single-def "field V87._reference (fldOffset=0x0)" P-INDEP
+;  V187 tmp157      [V187,T85] (  2,  1   )     int  ->  rsi         "field V87._length (fldOffset=0x8)" P-INDEP
 ;* V188 tmp158      [V188    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V90._reference (fldOffset=0x0)" P-INDEP
 ;* V189 tmp159      [V189    ] (  0,  0   )     int  ->  zero-ref    "field V90._length (fldOffset=0x8)" P-INDEP
-;  V190 tmp160      [V190,T78] (  2,  1   )   byref  ->  rbx         single-def "field V91._reference (fldOffset=0x0)" P-INDEP
-;  V191 tmp161      [V191,T85] (  2,  1   )     int  ->  r15         "field V91._length (fldOffset=0x8)" P-INDEP
+;  V190 tmp160      [V190,T79] (  2,  1   )   byref  ->  rbx         single-def "field V91._reference (fldOffset=0x0)" P-INDEP
+;  V191 tmp161      [V191,T86] (  2,  1   )     int  ->  r15         "field V91._length (fldOffset=0x8)" P-INDEP
 ;* V192 tmp162      [V192    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[uint]>
 ;* V193 tmp163      [V193    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[uint]>
 ;* V194 tmp164      [V194    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[uint]>
 ;  V195 tmp165      [V195    ] ( 21, 21   )  struct (16) [rbp+0xA0]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[uint]>
 ;  V196 tmp166      [V196    ] ( 18, 18   )  struct (16) [rbp+0x90]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[uint]>
 ;  V197 tmp167      [V197    ] ( 21, 21   )  struct (16) [rbp+0x80]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[uint]>
-;  V198 tmp168      [V198,T42] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V199 tmp169      [V199,T43] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V200 tmp170      [V200,T44] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V201 tmp171      [V201,T45] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V202 tmp172      [V202,T46] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
-;  V203 tmp173      [V203,T47] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V198 tmp168      [V198,T43] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V199 tmp169      [V199,T44] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V200 tmp170      [V200,T45] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V201 tmp171      [V201,T46] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V202 tmp172      [V202,T47] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
+;  V203 tmp173      [V203,T48] (  2,  2   )     ref  ->  rcx         single-def "argument with side effect"
 ;  V204 GsCookie    [V204    ] (  1,  1   )    long  ->  [rbp+0x08]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
-;  V205 cse0        [V205,T35] (  4,  2   )    long  ->  [rbp+0x78]  spill-single-def "CSE #03: conservative"
+;  V205 cse0        [V205,T36] (  4,  2   )    long  ->  [rbp+0x78]  spill-single-def "CSE #03: conservative"
 ;  V206 cse1        [V206,T09] (  2, 17   )    long  ->  rax         hoist "CSE #01: aggressive"
+;  V207 rat0        [V207,T00] (  6, 84   )    long  ->   r8         "Widened IV V06"
 ;
 ; Lcl frame size = 248
 
@@ -266,8 +267,7 @@ G_M35412_IG06:
        lea      r10, bword ptr [rbx+4*r10]
        mov      r9d, dword ptr [r10]
        add      rdx, r9
-       mov      r9d, r8d
-       mov      r9d, dword ptr [r15+4*r9]
+       mov      r9d, dword ptr [r15+4*r8]
        mov      r11d, dword ptr [rdi+4*rax]
        imul     r9, r11
        add      rdx, r9
@@ -276,7 +276,7 @@ G_M35412_IG06:
        inc      r8d
        cmp      r8d, r13d
        jl       SHORT G_M35412_IG06
-						;; size=50 bbWeight=16 PerfScore 208.00
+						;; size=47 bbWeight=16 PerfScore 204.00
 G_M35412_IG07:
        lea      r8d, [rcx+r13]
        movsxd   r8, r8d
@@ -645,6 +645,6 @@ G_M35412_IG31:
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1674, prolog size 58, PerfScore 399.21, instruction count 364, allocated bytes for code 1674 (MethodHash=700975ab) for method System.Numerics.BigIntegerCalculator:MultiplyNearLength(System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (Tier0-FullOpts)
+; Total bytes of code 1671, prolog size 58, PerfScore 395.21, instruction count 363, allocated bytes for code 1671 (MethodHash=700975ab) for method System.Numerics.BigIntegerCalculator:MultiplyNearLength(System.ReadOnlySpan`1[uint],System.ReadOnlySpan`1[uint],System.Span`1[uint]) (Tier0-FullOpts)
 ; ============================================================
 


```

### ``[System.Runtime.Numerics]BigInteger.Multiply(value class System.ReadOnlySpan`1<unsigned int32>,int32,value class System.ReadOnlySpan`1<unsigned int32>,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 12508
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 12974
 ; 2 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
@@ -2243,7 +2243,7 @@ G_M5307_IG11:
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 12788
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 13538
 ; 19 inlinees with PGO data; 31 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
@@ -2252,70 +2252,70 @@ G_M5307_IG11:
 ;  V02 arg1         [V02,T06] (  9,  3.01)     int  ->  rsi         single-def
 ;  V03 arg2         [V03,T01] (  4,  8   )   byref  ->   r9         ld-addr-op single-def
 ;  V04 arg3         [V04,T19] (  7,  1.01)     int  ->  rdi         single-def
-;* V05 loc0         [V05,T22] (  0,  0   )   ubyte  ->  zero-ref   
-;  V06 loc1         [V06,T17] (  2,  2.01)   ubyte  ->  rax        
+;* V05 loc0         [V05,T21] (  0,  0   )   ubyte  ->  zero-ref   
+;  V06 loc1         [V06,T17] (  2,  2.00)   ubyte  ->  rax        
 ;  V07 loc2         [V07    ] (  7,  3.01)  struct (16) [rbp+0x98]  do-not-enreg[XS] must-init addr-exposed ld-addr-op <System.Numerics.BigInteger>
 ;  V08 loc3         [V08,T18] ( 23,  2   )     ref  ->  [rbp+0x20]  class-hnd <uint[]>
-;  V09 loc4         [V09,T23] (  6,  0.01)     int  ->  r12        
+;  V09 loc4         [V09,T22] (  6,  0.01)     int  ->  r12        
 ;* V10 loc5         [V10    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
 ;* V11 loc6         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;* V12 loc7         [V12    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
-;  V13 loc8         [V13,T34] (  5,  0   )     int  ->  r15        
+;  V13 loc8         [V13,T33] (  5,  0   )     int  ->  r15        
 ;* V14 loc9         [V14    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
 ;* V15 loc10        [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
-;  V16 loc11        [V16,T35] (  5,  0   )     int  ->  r15        
+;  V16 loc11        [V16,T34] (  5,  0   )     int  ->  r15        
 ;* V17 loc12        [V17    ] (  0,  0   )  struct (16) zero-ref    <System.Span`1[uint]>
 ;* V18 loc13        [V18    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
-;  V19 loc14        [V19,T36] (  5,  0   )     int  ->  [rbp+0x94]  spill-single-def
+;  V19 loc14        [V19,T35] (  5,  0   )     int  ->  [rbp+0x94]  spill-single-def
 ;* V20 loc15        [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;* V21 loc16        [V21    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
-;  V22 loc17        [V22,T05] (  9,  6.05)     int  ->  [rbp+0x90]  spill-single-def
+;  V22 loc17        [V22,T05] (  8,  6.03)     int  ->  [rbp+0x90]  spill-single-def
 ;* V23 loc18        [V23    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;* V24 loc19        [V24    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.Span`1[uint]>
 ;  V25 OutArgs      [V25    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V26 tmp1         [V26,T60] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
+;  V26 tmp1         [V26,T59] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
 ;* V27 tmp2         [V27    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[uint]>
 ;* V28 tmp3         [V28    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
-;  V29 tmp4         [V29,T61] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
+;  V29 tmp4         [V29,T60] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
 ;  V30 tmp5         [V30    ] (  2,  0   )  struct (16) [rbp+0x80]  do-not-enreg[HS] must-init hidden-struct-arg "spilled call-like call argument" <System.ReadOnlySpan`1[uint]>
 ;* V31 tmp6         [V31    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
-;  V32 tmp7         [V32,T62] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
+;  V32 tmp7         [V32,T61] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
 ;  V33 tmp8         [V33    ] (  2,  0   )  struct (16) [rbp+0x70]  do-not-enreg[HS] must-init hidden-struct-arg "spilled call-like call argument" <System.ReadOnlySpan`1[uint]>
 ;* V34 tmp9         [V34    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
-;  V35 tmp10        [V35,T63] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
+;  V35 tmp10        [V35,T62] (  2,  0   )     ref  ->  r10         class-hnd single-def "dup spill" <uint[]>
 ;* V36 tmp11        [V36    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[uint]>
 ;  V37 tmp12        [V37    ] (  2,  0   )  struct (16) [rbp+0x60]  do-not-enreg[HS] must-init hidden-struct-arg "spilled call-like call argument" <System.ReadOnlySpan`1[uint]>
 ;* V38 tmp13        [V38    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
-;  V39 tmp14        [V39,T64] (  2,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <uint[]>
+;  V39 tmp14        [V39,T63] (  2,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <uint[]>
 ;* V40 tmp15        [V40    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[uint]>
 ;* V41 tmp16        [V41    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[uint]>
 ;* V42 tmp17        [V42    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
-;  V43 tmp18        [V43,T24] (  2,  0.00)    long  ->  r13         "Inlining Arg"
+;  V43 tmp18        [V43,T23] (  2,  0.00)    long  ->  r13         "Inlining Arg"
 ;* V44 tmp19        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V45 tmp20        [V45    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V46 tmp21        [V46    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V47 tmp22        [V47,T26] (  3,  0.00)     int  ->  rdx         "Inline stloc first use temp"
+;  V47 tmp22        [V47,T25] (  3,  0.00)     int  ->  rdx         "Inline stloc first use temp"
 ;* V48 tmp23        [V48    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[uint]>
 ;* V49 tmp24        [V49    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
 ;* V50 tmp25        [V50    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V51 tmp26        [V51    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V52 tmp27        [V52,T77] (  2,  0   )    long  ->  r14         "Inlining Arg"
+;  V52 tmp27        [V52,T76] (  2,  0   )    long  ->  r14         "Inlining Arg"
 ;* V53 tmp28        [V53    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V54 tmp29        [V54    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V55 tmp30        [V55    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V56 tmp31        [V56,T49] (  3,  0   )     int  ->  rdx         "Inline stloc first use temp"
-;* V57 tmp32        [V57,T20] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V56 tmp31        [V56,T48] (  3,  0   )     int  ->  rdx         "Inline stloc first use temp"
+;* V57 tmp32        [V57,T82] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V58 tmp33        [V58    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[uint]>
 ;* V59 tmp34        [V59    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[uint]>
-;  V60 tmp35        [V60,T78] (  2,  0   )    long  ->  r14         "Inlining Arg"
+;  V60 tmp35        [V60,T77] (  2,  0   )    long  ->  r14         "Inlining Arg"
 ;* V61 tmp36        [V61    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V62 tmp37        [V62    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V63 tmp38        [V63    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V64 tmp39        [V64,T79] (  2,  0   )    long  ->   r8         "Inlining Arg"
+;  V64 tmp39        [V64,T78] (  2,  0   )    long  ->   r8         "Inlining Arg"
 ;* V65 tmp40        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V66 tmp41        [V66    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V67 tmp42        [V67    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V68 tmp43        [V68,T07] (  2,  4.03)    long  ->   r8         "Inlining Arg"
+;  V68 tmp43        [V68,T07] (  2,  4.02)    long  ->   r8         "Inlining Arg"
 ;* V69 tmp44        [V69    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V70 tmp45        [V70    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[uint]>
 ;* V71 tmp46        [V71    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -2326,86 +2326,86 @@ G_M5307_IG11:
 ;* V76 tmp51        [V76    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[uint]>
 ;* V77 tmp52        [V77    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V78 tmp53        [V78    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V79 tmp54        [V79,T11] (  7,  3.02)   byref  ->  r13         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
-;  V80 tmp55        [V80,T02] ( 14,  7.04)     int  ->  r12         "field V01._length (fldOffset=0x8)" P-INDEP
-;  V81 tmp56        [V81,T10] (  6,  3.02)   byref  ->  r14         single-def "field V03._reference (fldOffset=0x0)" P-INDEP
-;  V82 tmp57        [V82,T03] ( 13,  7.04)     int  ->  r15         "field V03._length (fldOffset=0x8)" P-INDEP
+;  V79 tmp54        [V79,T11] (  7,  3.01)   byref  ->  r13         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
+;  V80 tmp55        [V80,T02] ( 14,  7.02)     int  ->  r12         "field V01._length (fldOffset=0x8)" P-INDEP
+;  V81 tmp56        [V81,T10] (  6,  3.01)   byref  ->  r14         single-def "field V03._reference (fldOffset=0x0)" P-INDEP
+;  V82 tmp57        [V82,T03] ( 13,  7.03)     int  ->  r15         "field V03._length (fldOffset=0x8)" P-INDEP
 ;  V83 tmp58        [V83    ] (  6,  2.01)     ref  ->  [rbp+0x98]  do-not-enreg[X] addr-exposed "field V07._bits (fldOffset=0x0)" P-DEP
 ;  V84 tmp59        [V84    ] (  6,  2.01)     int  ->  [rbp+0xA0]  do-not-enreg[X] addr-exposed "field V07._sign (fldOffset=0x8)" P-DEP
 ;* V85 tmp60        [V85    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V10._reference (fldOffset=0x0)" P-INDEP
 ;* V86 tmp61        [V86    ] (  0,  0   )     int  ->  zero-ref    "field V10._length (fldOffset=0x8)" P-INDEP
-;  V87 tmp62        [V87,T25] (  4,  0.00)   byref  ->  registers   "field V11._reference (fldOffset=0x0)" P-INDEP
-;  V88 tmp63        [V88,T27] (  3,  0.00)     int  ->   r9         "field V11._length (fldOffset=0x8)" P-INDEP
+;  V87 tmp62        [V87,T24] (  4,  0.00)   byref  ->  registers   "field V11._reference (fldOffset=0x0)" P-INDEP
+;  V88 tmp63        [V88,T26] (  3,  0.00)     int  ->   r9         "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V89 tmp64        [V89    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V90 tmp65        [V90    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;* V91 tmp66        [V91    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V14._reference (fldOffset=0x0)" P-INDEP
 ;* V92 tmp67        [V92    ] (  0,  0   )     int  ->  zero-ref    "field V14._length (fldOffset=0x8)" P-INDEP
-;  V93 tmp68        [V93,T39] (  3,  0   )   byref  ->  registers   "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V94 tmp69        [V94,T50] (  3,  0   )     int  ->  rax         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V93 tmp68        [V93,T38] (  3,  0   )   byref  ->  registers   "field V15._reference (fldOffset=0x0)" P-INDEP
+;  V94 tmp69        [V94,T49] (  3,  0   )     int  ->  rax         "field V15._length (fldOffset=0x8)" P-INDEP
 ;* V95 tmp70        [V95    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V17._reference (fldOffset=0x0)" P-INDEP
 ;* V96 tmp71        [V96    ] (  0,  0   )     int  ->  zero-ref    "field V17._length (fldOffset=0x8)" P-INDEP
-;  V97 tmp72        [V97,T40] (  3,  0   )   byref  ->  registers   "field V18._reference (fldOffset=0x0)" P-INDEP
-;  V98 tmp73        [V98,T51] (  3,  0   )     int  ->  rax         "field V18._length (fldOffset=0x8)" P-INDEP
+;  V97 tmp72        [V97,T39] (  3,  0   )   byref  ->  registers   "field V18._reference (fldOffset=0x0)" P-INDEP
+;  V98 tmp73        [V98,T50] (  3,  0   )     int  ->  rax         "field V18._length (fldOffset=0x8)" P-INDEP
 ;* V99 tmp74        [V99    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V100 tmp75       [V100    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
-;  V101 tmp76       [V101,T41] (  3,  0   )   byref  ->   r8         "field V21._reference (fldOffset=0x0)" P-INDEP
-;  V102 tmp77       [V102,T52] (  3,  0   )     int  ->   r9         "field V21._length (fldOffset=0x8)" P-INDEP
+;  V101 tmp76       [V101,T40] (  3,  0   )   byref  ->   r8         "field V21._reference (fldOffset=0x0)" P-INDEP
+;  V102 tmp77       [V102,T51] (  3,  0   )     int  ->   r9         "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V103 tmp78       [V103    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V23._reference (fldOffset=0x0)" P-INDEP
 ;* V104 tmp79       [V104    ] (  0,  0   )     int  ->  zero-ref    "field V23._length (fldOffset=0x8)" P-INDEP
-;  V105 tmp80       [V105,T08] (  4,  3.02)   byref  ->  [rbp+0x18]  "field V24._reference (fldOffset=0x0)" P-INDEP
-;  V106 tmp81       [V106,T12] (  4,  2.02)     int  ->   r9         "field V24._length (fldOffset=0x8)" P-INDEP
+;  V105 tmp80       [V105,T08] (  4,  3.01)   byref  ->  [rbp+0x18]  "field V24._reference (fldOffset=0x0)" P-INDEP
+;  V106 tmp81       [V106,T12] (  3,  2.01)     int  ->   r9         "field V24._length (fldOffset=0x8)" P-INDEP
 ;* V107 tmp82       [V107    ] (  0,  0   )   byref  ->  zero-ref    "field V27._reference (fldOffset=0x0)" P-INDEP
 ;* V108 tmp83       [V108    ] (  0,  0   )     int  ->  zero-ref    "field V27._length (fldOffset=0x8)" P-INDEP
-;  V109 tmp84       [V109,T13] (  2,  2.02)   byref  ->   r8         single-def "field V28._reference (fldOffset=0x0)" P-INDEP
-;* V110 tmp85       [V110,T21] (  0,  0   )     int  ->  zero-ref    "field V28._length (fldOffset=0x8)" P-INDEP
-;  V111 tmp86       [V111,T65] (  2,  0   )   byref  ->  [rbp+0x80]  do-not-enreg[H] hidden-struct-arg "field V30._reference (fldOffset=0x0)" P-DEP
-;  V112 tmp87       [V112,T80] (  2,  0   )     int  ->  [rbp+0x88]  do-not-enreg[H] hidden-struct-arg "field V30._length (fldOffset=0x8)" P-DEP
-;  V113 tmp88       [V113,T66] (  2,  0   )   byref  ->   r8         single-def "field V31._reference (fldOffset=0x0)" P-INDEP
+;  V109 tmp84       [V109,T13] (  2,  2.01)   byref  ->   r8         single-def "field V28._reference (fldOffset=0x0)" P-INDEP
+;* V110 tmp85       [V110,T20] (  0,  0   )     int  ->  zero-ref    "field V28._length (fldOffset=0x8)" P-INDEP
+;  V111 tmp86       [V111,T64] (  2,  0   )   byref  ->  [rbp+0x80]  do-not-enreg[H] hidden-struct-arg "field V30._reference (fldOffset=0x0)" P-DEP
+;  V112 tmp87       [V112,T79] (  2,  0   )     int  ->  [rbp+0x88]  do-not-enreg[H] hidden-struct-arg "field V30._length (fldOffset=0x8)" P-DEP
+;  V113 tmp88       [V113,T65] (  2,  0   )   byref  ->   r8         single-def "field V31._reference (fldOffset=0x0)" P-INDEP
 ;* V114 tmp89       [V114,T83] (  0,  0   )     int  ->  zero-ref    "field V31._length (fldOffset=0x8)" P-INDEP
-;  V115 tmp90       [V115,T67] (  2,  0   )   byref  ->  [rbp+0x70]  do-not-enreg[H] hidden-struct-arg "field V33._reference (fldOffset=0x0)" P-DEP
-;  V116 tmp91       [V116,T81] (  2,  0   )     int  ->  [rbp+0x78]  do-not-enreg[H] hidden-struct-arg "field V33._length (fldOffset=0x8)" P-DEP
-;  V117 tmp92       [V117,T68] (  2,  0   )   byref  ->  r14         single-def "field V34._reference (fldOffset=0x0)" P-INDEP
+;  V115 tmp90       [V115,T66] (  2,  0   )   byref  ->  [rbp+0x70]  do-not-enreg[H] hidden-struct-arg "field V33._reference (fldOffset=0x0)" P-DEP
+;  V116 tmp91       [V116,T80] (  2,  0   )     int  ->  [rbp+0x78]  do-not-enreg[H] hidden-struct-arg "field V33._length (fldOffset=0x8)" P-DEP
+;  V117 tmp92       [V117,T67] (  2,  0   )   byref  ->  r14         single-def "field V34._reference (fldOffset=0x0)" P-INDEP
 ;* V118 tmp93       [V118,T84] (  0,  0   )     int  ->  zero-ref    "field V34._length (fldOffset=0x8)" P-INDEP
 ;* V119 tmp94       [V119    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V36._reference (fldOffset=0x0)" P-INDEP
 ;* V120 tmp95       [V120    ] (  0,  0   )     int  ->  zero-ref    "field V36._length (fldOffset=0x8)" P-INDEP
-;  V121 tmp96       [V121,T69] (  2,  0   )   byref  ->  [rbp+0x60]  do-not-enreg[H] hidden-struct-arg "field V37._reference (fldOffset=0x0)" P-DEP
-;  V122 tmp97       [V122,T82] (  2,  0   )     int  ->  [rbp+0x68]  do-not-enreg[H] hidden-struct-arg "field V37._length (fldOffset=0x8)" P-DEP
-;  V123 tmp98       [V123,T70] (  2,  0   )   byref  ->  r14         single-def "field V38._reference (fldOffset=0x0)" P-INDEP
+;  V121 tmp96       [V121,T68] (  2,  0   )   byref  ->  [rbp+0x60]  do-not-enreg[H] hidden-struct-arg "field V37._reference (fldOffset=0x0)" P-DEP
+;  V122 tmp97       [V122,T81] (  2,  0   )     int  ->  [rbp+0x68]  do-not-enreg[H] hidden-struct-arg "field V37._length (fldOffset=0x8)" P-DEP
+;  V123 tmp98       [V123,T69] (  2,  0   )   byref  ->  r14         single-def "field V38._reference (fldOffset=0x0)" P-INDEP
 ;* V124 tmp99       [V124,T85] (  0,  0   )     int  ->  zero-ref    "field V38._length (fldOffset=0x8)" P-INDEP
 ;* V125 tmp100      [V125    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V40._reference (fldOffset=0x0)" P-INDEP
 ;* V126 tmp101      [V126    ] (  0,  0   )     int  ->  zero-ref    "field V40._length (fldOffset=0x8)" P-INDEP
 ;* V127 tmp102      [V127    ] (  0,  0   )   byref  ->  zero-ref    "field V41._reference (fldOffset=0x0)" P-INDEP
 ;* V128 tmp103      [V128    ] (  0,  0   )     int  ->  zero-ref    "field V41._length (fldOffset=0x8)" P-INDEP
-;  V129 tmp104      [V129,T28] (  2,  0.00)   byref  ->  r13         single-def "field V42._reference (fldOffset=0x0)" P-INDEP
-;* V130 tmp105      [V130,T32] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V131 tmp106      [V131,T42] (  3,  0   )   byref  ->  rcx         "field V44._reference (fldOffset=0x0)" P-INDEP
-;  V132 tmp107      [V132,T53] (  3,  0   )     int  ->   r9         "field V44._length (fldOffset=0x8)" P-INDEP
-;  V133 tmp108      [V133,T29] (  2,  0.00)   byref  ->  rcx         single-def "field V45._reference (fldOffset=0x0)" P-INDEP
-;* V134 tmp109      [V134,T33] (  0,  0   )     int  ->  zero-ref    "field V45._length (fldOffset=0x8)" P-INDEP
+;  V129 tmp104      [V129,T27] (  2,  0.00)   byref  ->  r13         single-def "field V42._reference (fldOffset=0x0)" P-INDEP
+;* V130 tmp105      [V130,T31] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
+;  V131 tmp106      [V131,T41] (  3,  0   )   byref  ->  rcx         "field V44._reference (fldOffset=0x0)" P-INDEP
+;  V132 tmp107      [V132,T52] (  3,  0   )     int  ->   r9         "field V44._length (fldOffset=0x8)" P-INDEP
+;  V133 tmp108      [V133,T28] (  2,  0.00)   byref  ->  rcx         single-def "field V45._reference (fldOffset=0x0)" P-INDEP
+;* V134 tmp109      [V134,T32] (  0,  0   )     int  ->  zero-ref    "field V45._length (fldOffset=0x8)" P-INDEP
 ;* V135 tmp110      [V135    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V48._reference (fldOffset=0x0)" P-INDEP
 ;* V136 tmp111      [V136    ] (  0,  0   )     int  ->  zero-ref    "field V48._length (fldOffset=0x8)" P-INDEP
-;  V137 tmp112      [V137,T30] (  2,  0.00)   byref  ->  r13         single-def "field V49._reference (fldOffset=0x0)" P-INDEP
-;  V138 tmp113      [V138,T31] (  2,  0.00)     int  ->  r12         "field V49._length (fldOffset=0x8)" P-INDEP
-;  V139 tmp114      [V139,T43] (  3,  0   )   byref  ->  rcx         "field V53._reference (fldOffset=0x0)" P-INDEP
-;  V140 tmp115      [V140,T54] (  3,  0   )     int  ->  rax         "field V53._length (fldOffset=0x8)" P-INDEP
-;  V141 tmp116      [V141,T44] (  3,  0   )   byref  ->  r14         single-def "field V54._reference (fldOffset=0x0)" P-INDEP
-;  V142 tmp117      [V142,T55] (  3,  0   )     int  ->  r15         "field V54._length (fldOffset=0x8)" P-INDEP
+;  V137 tmp112      [V137,T29] (  2,  0.00)   byref  ->  r13         single-def "field V49._reference (fldOffset=0x0)" P-INDEP
+;  V138 tmp113      [V138,T30] (  2,  0.00)     int  ->  r12         "field V49._length (fldOffset=0x8)" P-INDEP
+;  V139 tmp114      [V139,T42] (  3,  0   )   byref  ->  rcx         "field V53._reference (fldOffset=0x0)" P-INDEP
+;  V140 tmp115      [V140,T53] (  3,  0   )     int  ->  rax         "field V53._length (fldOffset=0x8)" P-INDEP
+;  V141 tmp116      [V141,T43] (  3,  0   )   byref  ->  r14         single-def "field V54._reference (fldOffset=0x0)" P-INDEP
+;  V142 tmp117      [V142,T54] (  3,  0   )     int  ->  r15         "field V54._length (fldOffset=0x8)" P-INDEP
 ;* V143 tmp118      [V143    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V58._reference (fldOffset=0x0)" P-INDEP
 ;* V144 tmp119      [V144    ] (  0,  0   )     int  ->  zero-ref    "field V58._length (fldOffset=0x8)" P-INDEP
 ;* V145 tmp120      [V145    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V59._reference (fldOffset=0x0)" P-INDEP
 ;* V146 tmp121      [V146    ] (  0,  0   )     int  ->  zero-ref    "field V59._length (fldOffset=0x8)" P-INDEP
-;  V147 tmp122      [V147,T45] (  3,  0   )   byref  ->  rcx         "field V61._reference (fldOffset=0x0)" P-INDEP
-;  V148 tmp123      [V148,T56] (  3,  0   )     int  ->  rax         "field V61._length (fldOffset=0x8)" P-INDEP
-;  V149 tmp124      [V149,T46] (  3,  0   )   byref  ->  r14         single-def "field V62._reference (fldOffset=0x0)" P-INDEP
-;  V150 tmp125      [V150,T57] (  3,  0   )     int  ->  r15         "field V62._length (fldOffset=0x8)" P-INDEP
-;  V151 tmp126      [V151,T47] (  3,  0   )   byref  ->   r8         "field V65._reference (fldOffset=0x0)" P-INDEP
-;  V152 tmp127      [V152,T58] (  3,  0   )     int  ->   r9         "field V65._length (fldOffset=0x8)" P-INDEP
-;  V153 tmp128      [V153,T37] (  4,  0   )   byref  ->  [rbp+0x10]  spill-single-def "field V66._reference (fldOffset=0x0)" P-INDEP
-;  V154 tmp129      [V154,T38] (  4,  0   )     int  ->  [rbp+0x5C]  spill-single-def "field V66._length (fldOffset=0x8)" P-INDEP
-;  V155 tmp130      [V155,T48] (  3,  0   )   byref  ->  rcx         "field V69._reference (fldOffset=0x0)" P-INDEP
-;  V156 tmp131      [V156,T59] (  3,  0   )     int  ->   r9         "field V69._length (fldOffset=0x8)" P-INDEP
-;  V157 tmp132      [V157,T09] (  4,  3.02)   byref  ->  [rbp+0x08]  spill-single-def "field V70._reference (fldOffset=0x0)" P-INDEP
-;  V158 tmp133      [V158,T15] (  2,  2.02)     int  ->  rdx         "field V70._length (fldOffset=0x8)" P-INDEP
+;  V147 tmp122      [V147,T44] (  3,  0   )   byref  ->  rcx         "field V61._reference (fldOffset=0x0)" P-INDEP
+;  V148 tmp123      [V148,T55] (  3,  0   )     int  ->  rax         "field V61._length (fldOffset=0x8)" P-INDEP
+;  V149 tmp124      [V149,T45] (  3,  0   )   byref  ->  r14         single-def "field V62._reference (fldOffset=0x0)" P-INDEP
+;  V150 tmp125      [V150,T56] (  3,  0   )     int  ->  r15         "field V62._length (fldOffset=0x8)" P-INDEP
+;  V151 tmp126      [V151,T46] (  3,  0   )   byref  ->   r8         "field V65._reference (fldOffset=0x0)" P-INDEP
+;  V152 tmp127      [V152,T57] (  3,  0   )     int  ->   r9         "field V65._length (fldOffset=0x8)" P-INDEP
+;  V153 tmp128      [V153,T36] (  4,  0   )   byref  ->  [rbp+0x10]  spill-single-def "field V66._reference (fldOffset=0x0)" P-INDEP
+;  V154 tmp129      [V154,T37] (  4,  0   )     int  ->  [rbp+0x5C]  spill-single-def "field V66._length (fldOffset=0x8)" P-INDEP
+;  V155 tmp130      [V155,T47] (  3,  0   )   byref  ->  rcx         "field V69._reference (fldOffset=0x0)" P-INDEP
+;  V156 tmp131      [V156,T58] (  3,  0   )     int  ->   r9         "field V69._length (fldOffset=0x8)" P-INDEP
+;  V157 tmp132      [V157,T09] (  4,  3.01)   byref  ->  [rbp+0x08]  spill-single-def "field V70._reference (fldOffset=0x0)" P-INDEP
+;  V158 tmp133      [V158,T15] (  2,  2.01)     int  ->  rdx         "field V70._length (fldOffset=0x8)" P-INDEP
 ;* V159 tmp134      [V159    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V72._reference (fldOffset=0x0)" P-INDEP
 ;* V160 tmp135      [V160    ] (  0,  0   )     int  ->  zero-ref    "field V72._length (fldOffset=0x8)" P-INDEP
 ;* V161 tmp136      [V161    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V73._reference (fldOffset=0x0)" P-INDEP
@@ -2414,19 +2414,19 @@ G_M5307_IG11:
 ;* V164 tmp139      [V164    ] (  0,  0   )     int  ->  zero-ref    "field V74._length (fldOffset=0x8)" P-INDEP
 ;* V165 tmp140      [V165    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V75._reference (fldOffset=0x0)" P-INDEP
 ;* V166 tmp141      [V166    ] (  0,  0   )     int  ->  zero-ref    "field V75._length (fldOffset=0x8)" P-INDEP
-;  V167 tmp142      [V167,T14] (  2,  2.02)   byref  ->  r15         single-def "field V76._reference (fldOffset=0x0)" P-INDEP
-;  V168 tmp143      [V168,T16] (  2,  2.02)     int  ->  r14         "field V76._length (fldOffset=0x8)" P-INDEP
+;  V167 tmp142      [V167,T14] (  2,  2.01)   byref  ->  r15         single-def "field V76._reference (fldOffset=0x0)" P-INDEP
+;  V168 tmp143      [V168,T16] (  2,  2.01)     int  ->  r14         "field V76._length (fldOffset=0x8)" P-INDEP
 ;* V169 tmp144      [V169    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[uint]>
 ;* V170 tmp145      [V170    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[uint]>
-;  V171 tmp146      [V171,T71] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
-;  V172 tmp147      [V172,T72] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
-;  V173 tmp148      [V173    ] ( 30, 12.11)  struct (16) [rbp+0x48]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[uint]>
-;  V174 tmp149      [V174    ] (  9,  6.05)  struct (16) [rbp+0x38]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[uint]>
-;  V175 tmp150      [V175    ] ( 27,  6.05)  struct (16) [rbp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[uint]>
-;  V176 tmp151      [V176,T73] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
-;  V177 tmp152      [V177,T74] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
-;  V178 tmp153      [V178,T75] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
-;  V179 tmp154      [V179,T76] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
+;  V171 tmp146      [V171,T70] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
+;  V172 tmp147      [V172,T71] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
+;  V173 tmp148      [V173    ] ( 30, 12.07)  struct (16) [rbp+0x48]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[uint]>
+;  V174 tmp149      [V174    ] (  9,  6.03)  struct (16) [rbp+0x38]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[uint]>
+;  V175 tmp150      [V175    ] ( 27,  6.03)  struct (16) [rbp+0x28]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[uint]>
+;  V176 tmp151      [V176,T72] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
+;  V177 tmp152      [V177,T73] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
+;  V178 tmp153      [V178,T74] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
+;  V179 tmp154      [V179,T75] (  2,  0   )     ref  ->  rcx         single-def "argument with side effect"
 ;  V180 GsCookie    [V180    ] (  1,  1   )    long  ->  [rbp+0x00]  do-not-enreg[X] addr-exposed "GSSecurityCookie"
 ;
 ; Lcl frame size = 200
@@ -2467,31 +2467,31 @@ G_M50331_IG02:
        xor      r10, r10
        mov      gword ptr [rbp+0x20], r10
        test     r12d, r12d
-       je       G_M50331_IG11
+       je       G_M50331_IG12
 						;; size=38 bbWeight=1 PerfScore 12.00
 G_M50331_IG03:
        test     eax, eax
-       jne      G_M50331_IG13
+       jne      G_M50331_IG16
        cmp      r12d, r15d
        jne      SHORT G_M50331_IG04
        cmp      r13, r14
-       je       G_M50331_IG20
-						;; size=22 bbWeight=1.01 PerfScore 3.78
+       je       G_M50331_IG23
+						;; size=22 bbWeight=1.00 PerfScore 3.77
 G_M50331_IG04:
        cmp      r12d, r15d
-       jl       G_M50331_IG27
+       jl       G_M50331_IG30
        lea      eax, [r12+r15]
        mov      dword ptr [rbp+0x90], eax
        cmp      eax, 64
-       ja       G_M50331_IG34
+       ja       G_M50331_IG37
        test     dword ptr [rsp], esp
        sub      rsp, 256
        lea      r8, [rsp+0x20]
        mov      r9d, 64
-       cmp      eax, r9d
-       ja       G_M50331_IG37
-						;; size=58 bbWeight=1.01 PerfScore 9.32
+						;; size=49 bbWeight=1.00 PerfScore 8.04
 G_M50331_IG05:
+       cmp      eax, r9d
+       ja       G_M50331_IG40
        mov      bword ptr [rbp+0x18], r8
        mov      r11, r8
        mov      bword ptr [rbp+0x08], r11
@@ -2502,7 +2502,7 @@ G_M50331_IG05:
        mov      ecx, r12d
        sub      ecx, r15d
        cmp      ecx, 3
-       jge      G_M50331_IG39
+       jge      G_M50331_IG41
        mov      bword ptr [rbp+0x48], r13
        mov      dword ptr [rbp+0x50], r12d
        mov      bword ptr [rbp+0x38], r14
@@ -2515,7 +2515,7 @@ G_M50331_IG05:
        lea      rdx, [rbp+0x38]
        lea      r8, [rbp+0x28]
        call     [<unknown method>]
-						;; size=94 bbWeight=1.01 PerfScore 20.66
+						;; size=103 bbWeight=1.00 PerfScore 21.85
 G_M50331_IG06:
        mov      r15, bword ptr [rbp+0x18]
        mov      bword ptr [rbp+0x48], r15
@@ -2528,11 +2528,11 @@ G_M50331_IG06:
        xor      r8d, ecx
        lea      rcx, [rbp+0x98]
        call     [System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[uint],ubyte):this]
-						;; size=44 bbWeight=1.01 PerfScore 8.82
+						;; size=44 bbWeight=1.00 PerfScore 8.79
 G_M50331_IG07:
        mov      r14, gword ptr [rbp+0x20]
        test     r14, r14
-       jne      G_M50331_IG40
+       jne      G_M50331_IG42
 						;; size=13 bbWeight=1 PerfScore 2.25
 G_M50331_IG08:
        mov      rdx, gword ptr [rbp+0x98]
@@ -2562,17 +2562,8 @@ G_M50331_IG10:
        ret      
 						;; size=20 bbWeight=1 PerfScore 5.50
 G_M50331_IG11:
-       lea      r12d, [r15+0x01]
-       cmp      r12d, 64
-       ja       G_M50331_IG41
-       test     dword ptr [rsp], esp
-       sub      rsp, 256
-       lea      r13, [rsp+0x20]
-       mov      r9d, 64
-						;; size=35 bbWeight=0.00 PerfScore 0.01
-G_M50331_IG12:
        cmp      r12d, r9d
-       ja       G_M50331_IG37
+       ja       G_M50331_IG40
        mov      rcx, r13
        mov      edx, esi
        sar      edx, 31
@@ -2599,17 +2590,52 @@ G_M50331_IG12:
        call     [System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[uint],ubyte):this]
        jmp      G_M50331_IG07
 						;; size=100 bbWeight=0.00 PerfScore 0.02
+G_M50331_IG12:
+       lea      r12d, [r15+0x01]
+       cmp      r12d, 64
+       ja       SHORT G_M50331_IG13
+       test     dword ptr [rsp], esp
+       sub      rsp, 256
+       lea      r13, [rsp+0x20]
+       mov      r9d, 64
+       jmp      G_M50331_IG11
+						;; size=36 bbWeight=0.00 PerfScore 0.01
 G_M50331_IG13:
+       mov      rcx, 0xD1FFAB1E
+       mov      edx, 36
+       call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
+       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
+       mov      rcx, gword ptr [rcx]
+       mov      edx, r12d
+       cmp      dword ptr [rcx], ecx
+       call     [<unknown method>]
+       mov      r13, rax
+       test     r13, r13
+       jne      SHORT G_M50331_IG14
+       xor      rcx, rcx
+       xor      r9d, r9d
+       jmp      SHORT G_M50331_IG15
+						;; size=59 bbWeight=0 PerfScore 0.00
+G_M50331_IG14:
+       lea      rcx, bword ptr [r13+0x10]
+       mov      r9d, dword ptr [r13+0x08]
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M50331_IG15:
+       mov      gword ptr [rbp+0x20], r13
+       mov      r13, rcx
+       jmp      G_M50331_IG11
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M50331_IG16:
        lea      r15d, [r12+0x01]
        cmp      r15d, 64
-       ja       SHORT G_M50331_IG14
+       ja       SHORT G_M50331_IG17
        test     dword ptr [rsp], esp
        sub      rsp, 256
        lea      r14, [rsp+0x20]
        mov      eax, 64
-       jmp      SHORT G_M50331_IG17
+       jmp      SHORT G_M50331_IG20
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M50331_IG14:
+G_M50331_IG17:
        mov      rcx, 0xD1FFAB1E
        mov      edx, 36
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -2621,24 +2647,24 @@ G_M50331_IG14:
        mov      r10, rax
        mov      r14, r10
        test     r14, r14
-       jne      SHORT G_M50331_IG15
+       jne      SHORT G_M50331_IG18
        xor      rcx, rcx
        xor      eax, eax
-       jmp      SHORT G_M50331_IG16
+       jmp      SHORT G_M50331_IG19
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M50331_IG15:
+G_M50331_IG18:
        lea      rcx, bword ptr [r14+0x10]
        mov      gword ptr [rbp+0x20], r14
        mov      eax, dword ptr [r14+0x08]
        mov      r14, gword ptr [rbp+0x20]
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M50331_IG16:
+G_M50331_IG19:
        mov      gword ptr [rbp+0x20], r14
        mov      r14, rcx
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M50331_IG17:
+G_M50331_IG20:
        cmp      r15d, eax
-       ja       G_M50331_IG37
+       ja       G_M50331_IG40
        mov      edx, edi
        sar      edx, 31
        mov      bword ptr [rbp+0x48], r13
@@ -2658,11 +2684,11 @@ G_M50331_IG17:
        lea      rcx, [rbp+0x60]
        call     [System.Span`1[uint]:op_Implicit(System.Span`1[uint]):System.ReadOnlySpan`1[uint]]
 						;; size=74 bbWeight=0 PerfScore 0.00
-G_M50331_IG18:
+G_M50331_IG21:
        vmovdqu  xmm0, xmmword ptr [rbp+0x60]
        vmovdqu  xmmword ptr [rbp+0x48], xmm0
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M50331_IG19:
+G_M50331_IG22:
        lea      rdx, [rbp+0x48]
        mov      r8d, esi
        shr      r8d, 31
@@ -2673,17 +2699,17 @@ G_M50331_IG19:
        call     [System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[uint],ubyte):this]
        jmp      G_M50331_IG07
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M50331_IG20:
+G_M50331_IG23:
        add      r15d, r12d
        cmp      r15d, 64
-       ja       SHORT G_M50331_IG21
+       ja       SHORT G_M50331_IG24
        test     dword ptr [rsp], esp
        sub      rsp, 256
        lea      r14, [rsp+0x20]
        mov      eax, 64
-       jmp      SHORT G_M50331_IG24
+       jmp      SHORT G_M50331_IG27
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M50331_IG21:
+G_M50331_IG24:
        mov      rcx, 0xD1FFAB1E
        mov      edx, 36
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -2695,24 +2721,24 @@ G_M50331_IG21:
        mov      r10, rax
        mov      r14, r10
        test     r14, r14
-       jne      SHORT G_M50331_IG22
+       jne      SHORT G_M50331_IG25
        xor      rcx, rcx
        xor      eax, eax
-       jmp      SHORT G_M50331_IG23
+       jmp      SHORT G_M50331_IG26
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M50331_IG22:
+G_M50331_IG25:
        lea      rcx, bword ptr [r14+0x10]
        mov      gword ptr [rbp+0x20], r14
        mov      eax, dword ptr [r14+0x08]
        mov      r14, gword ptr [rbp+0x20]
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M50331_IG23:
+G_M50331_IG26:
        mov      gword ptr [rbp+0x20], r14
        mov      r14, rcx
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M50331_IG24:
+G_M50331_IG27:
        cmp      r15d, eax
-       ja       G_M50331_IG37
+       ja       G_M50331_IG40
        mov      bword ptr [rbp+0x48], r13
        mov      dword ptr [rbp+0x50], r12d
        mov      bword ptr [rbp+0x28], r14
@@ -2726,11 +2752,11 @@ G_M50331_IG24:
        lea      rcx, [rbp+0x70]
        call     [System.Span`1[uint]:op_Implicit(System.Span`1[uint]):System.ReadOnlySpan`1[uint]]
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M50331_IG25:
+G_M50331_IG28:
        vmovdqu  xmm0, xmmword ptr [rbp+0x70]
        vmovdqu  xmmword ptr [rbp+0x48], xmm0
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M50331_IG26:
+G_M50331_IG29:
        lea      rdx, [rbp+0x48]
        mov      r8d, esi
        shr      r8d, 31
@@ -2741,18 +2767,18 @@ G_M50331_IG26:
        call     [System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[uint],ubyte):this]
        jmp      G_M50331_IG07
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M50331_IG27:
+G_M50331_IG30:
        lea      eax, [r12+r15]
        mov      dword ptr [rbp+0x94], eax
        cmp      eax, 64
-       ja       SHORT G_M50331_IG28
+       ja       SHORT G_M50331_IG31
        test     dword ptr [rsp], esp
        sub      rsp, 256
        lea      r8, [rsp+0x20]
        mov      r9d, 64
-       jmp      SHORT G_M50331_IG31
+       jmp      SHORT G_M50331_IG34
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M50331_IG28:
+G_M50331_IG31:
        mov      rcx, 0xD1FFAB1E
        mov      edx, 36
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -2764,24 +2790,24 @@ G_M50331_IG28:
        mov      r10, rax
        mov      rax, r10
        test     rax, rax
-       jne      SHORT G_M50331_IG29
+       jne      SHORT G_M50331_IG32
        xor      r8, r8
        xor      r9d, r9d
-       jmp      SHORT G_M50331_IG30
+       jmp      SHORT G_M50331_IG33
 						;; size=66 bbWeight=0 PerfScore 0.00
-G_M50331_IG29:
+G_M50331_IG32:
        lea      r8, bword ptr [rax+0x10]
        mov      gword ptr [rbp+0x20], rax
        mov      r9d, dword ptr [rax+0x08]
        mov      rax, gword ptr [rbp+0x20]
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M50331_IG30:
+G_M50331_IG33:
        mov      gword ptr [rbp+0x20], rax
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M50331_IG31:
+G_M50331_IG34:
        mov      eax, dword ptr [rbp+0x94]
        cmp      eax, r9d
-       ja       G_M50331_IG37
+       ja       G_M50331_IG40
        mov      bword ptr [rbp+0x10], r8
        mov      dword ptr [rbp+0x5C], eax
        mov      edx, eax
@@ -2806,11 +2832,11 @@ G_M50331_IG31:
        lea      rcx, [rbp+0x80]
        call     [System.Span`1[uint]:op_Implicit(System.Span`1[uint]):System.ReadOnlySpan`1[uint]]
 						;; size=112 bbWeight=0 PerfScore 0.00
-G_M50331_IG32:
+G_M50331_IG35:
        vmovdqu  xmm0, xmmword ptr [rbp+0x80]
        vmovdqu  xmmword ptr [rbp+0x48], xmm0
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M50331_IG33:
+G_M50331_IG36:
        lea      rdx, [rbp+0x48]
        mov      r8d, esi
        shr      r8d, 31
@@ -2821,7 +2847,7 @@ G_M50331_IG33:
        call     [System.Numerics.BigInteger:.ctor(System.ReadOnlySpan`1[uint],ubyte):this]
        jmp      G_M50331_IG07
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M50331_IG34:
+G_M50331_IG37:
        mov      rcx, 0xD1FFAB1E
        mov      edx, 36
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -2833,31 +2859,26 @@ G_M50331_IG34:
        mov      r10, rax
        mov      rax, r10
        test     rax, rax
-       jne      SHORT G_M50331_IG35
+       jne      SHORT G_M50331_IG38
        xor      rcx, rcx
        xor      r9d, r9d
-       jmp      SHORT G_M50331_IG36
+       jmp      SHORT G_M50331_IG39
 						;; size=65 bbWeight=0 PerfScore 0.00
-G_M50331_IG35:
+G_M50331_IG38:
        lea      rcx, bword ptr [rax+0x10]
        mov      r9d, dword ptr [rax+0x08]
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M50331_IG36:
-       mov      edx, dword ptr [rbp+0x90]
-       cmp      edx, r9d
+G_M50331_IG39:
        mov      gword ptr [rbp+0x20], rax
        mov      r8, rcx
-       jbe      SHORT G_M50331_IG38
+       mov      eax, dword ptr [rbp+0x90]
+       jmp      G_M50331_IG05
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M50331_IG37:
+G_M50331_IG40:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M50331_IG38:
-       mov      eax, edx
-       jmp      G_M50331_IG05
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M50331_IG39:
+G_M50331_IG41:
        mov      bword ptr [rbp+0x48], r13
        mov      dword ptr [rbp+0x50], r12d
        mov      bword ptr [rbp+0x38], r14
@@ -2872,7 +2893,7 @@ G_M50331_IG39:
        call     [<unknown method>]
        jmp      G_M50331_IG06
 						;; size=58 bbWeight=0 PerfScore 0.00
-G_M50331_IG40:
+G_M50331_IG42:
        mov      rcx, 0xD1FFAB1E
        mov      edx, 36
        call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
@@ -2884,33 +2905,8 @@ G_M50331_IG40:
        call     [<unknown method>]
        jmp      G_M50331_IG08
 						;; size=52 bbWeight=0 PerfScore 0.00
-G_M50331_IG41:
-       mov      rcx, 0xD1FFAB1E
-       mov      edx, 36
-       call     CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rcx, gword ptr [rcx]
-       mov      edx, r12d
-       cmp      dword ptr [rcx], ecx
-       call     [<unknown method>]
-       mov      r13, rax
-       test     r13, r13
-       jne      SHORT G_M50331_IG42
-       xor      rcx, rcx
-       xor      r9d, r9d
-       jmp      SHORT G_M50331_IG43
-						;; size=59 bbWeight=0 PerfScore 0.00
-G_M50331_IG42:
-       lea      rcx, bword ptr [r13+0x10]
-       mov      r9d, dword ptr [r13+0x08]
-						;; size=8 bbWeight=0 PerfScore 0.00
-G_M50331_IG43:
-       mov      gword ptr [rbp+0x20], r13
-       mov      r13, rcx
-       jmp      G_M50331_IG12
-						;; size=12 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1604, prolog size 78, PerfScore 93.45, instruction count 392, allocated bytes for code 1604 (MethodHash=57623b64) for method System.Numerics.BigInteger:Multiply(System.ReadOnlySpan`1[uint],int,System.ReadOnlySpan`1[uint],int):System.Numerics.BigInteger (Tier1)
+; Total bytes of code 1598, prolog size 78, PerfScore 93.31, instruction count 390, allocated bytes for code 1598 (MethodHash=57623b64) for method System.Numerics.BigInteger:Multiply(System.ReadOnlySpan`1[uint],int,System.ReadOnlySpan`1[uint],int):System.Numerics.BigInteger (Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Number+BigInteger:Multiply(byref,uint,byref) (Instrumented Tier1)


```

</details>

# ``System.Numerics.Tests.Perf_BigInteger.ToByteArray(numberString: 12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890)``

Hot functions:

- (78.60%) ``BigInteger.TryGetBytes`` (Tier-1)
  - **Has diffs**
- (2.76%) ``Perf_BigInteger.ToByteArray`` (Tier-1)
  - No diffs
- (1.81%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Runtime.Numerics]BigInteger.TryGetBytes(value class GetBytesMode,value class System.Span`1<unsigned int8>,bool,bool,int32&)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 540672
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 1018880
 ; 1 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T11] (  4,  4.01)   byref  ->  rcx         this single-def
-;  V01 arg1         [V01,T15] (  6,  3.02)     int  ->  rdx         single-def
+;  V01 arg1         [V01,T14] (  6,  3.01)     int  ->  rdx         single-def
 ;  V02 arg2         [V02,T09] (  4,  8   )   byref  ->   r8         ld-addr-op single-def
-;  V03 arg3         [V03,T17] (  4,  3.00)   ubyte  ->   r9         single-def
-;  V04 arg4         [V04,T32] (  1,  1.01)   ubyte  ->  rbx         single-def
-;  V05 arg5         [V05,T33] (  4,  0.01)   byref  ->  [rsp+0xA8]  single-def
-;  V06 loc0         [V06,T08] (  7, 22.82)     int  ->  rbp        
-;  V07 loc1         [V07,T19] (  8,  4.03)   ubyte  ->  r13        
+;  V03 arg3         [V03,T13] (  4,  3.01)   ubyte  ->   r9         single-def
+;  V04 arg4         [V04,T32] (  1,  1.00)   ubyte  ->  rbx         single-def
+;  V05 arg5         [V05,T35] (  4,  0.00)   byref  ->  [rsp+0xA8]  single-def
+;  V06 loc0         [V06,T08] (  7, 22.41)     int  ->  rbp        
+;  V07 loc1         [V07,T21] (  8,  4.01)   ubyte  ->  r13        
 ;  V08 loc2         [V08,T31] (  7,  1.01)     int  ->  r14        
-;  V09 loc3         [V09,T12] ( 14,  6.01)     int  ->  r12        
-;  V10 loc4         [V10,T06] ( 12, 27.87)     ref  ->  r15         class-hnd single-def <<unknown class>>
-;  V11 loc5         [V11,T14] (  8,  5.02)   ubyte  ->  rcx        
-;  V12 loc6         [V12,T16] (  8,  5.01)     int  ->  [rsp+0x34] 
-;  V13 loc7         [V13,T25] (  3,  3.02)   ubyte  ->  [rsp+0x30]  spill-single-def
-;  V14 loc8         [V14,T13] (  8,  5.04)     int  ->  [rsp+0x2C] 
+;  V09 loc3         [V09,T12] ( 14,  5.99)     int  ->  r12        
+;  V10 loc4         [V10,T06] ( 12, 27.43)     ref  ->  r15         class-hnd single-def <<unknown class>>
+;  V11 loc5         [V11,T16] (  8,  4.99)   ubyte  ->  rcx        
+;  V12 loc6         [V12,T15] (  8,  4.99)     int  ->  [rsp+0x34] 
+;  V13 loc7         [V13,T24] (  3,  3.01)   ubyte  ->  [rsp+0x30]  spill-single-def
+;  V14 loc8         [V14,T17] (  8,  4.99)     int  ->  [rsp+0x2C] 
 ;  V15 loc9         [V15,T20] (  5,  4.01)     ref  ->  rax         class-hnd <ubyte[]>
-;  V16 loc10        [V16,T00] ( 35,327.94)     int  ->  rdx        
-;  V17 loc11        [V17,T04] (  9, 82.24)     int  ->   r8        
-;  V18 loc12        [V18,T05] (  6, 80.25)     int  ->  rcx        
-;  V19 loc13        [V19,T01] (  9, 99.05)     int  ->   r9        
+;  V16 loc10        [V16,T00] ( 35,321.29)     int  ->  rdx        
+;  V17 loc11        [V17,T04] (  9, 80.58)     int  ->   r8        
+;* V18 loc12        [V18,T33] (  0,  0   )     int  ->  zero-ref   
+;  V19 loc13        [V19,T01] (  9, 96.98)     int  ->   r9        
 ;  V20 OutArgs      [V20    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V21 tmp1         [V21,T18] (  2,  4.03)     int  ->  rcx         "dup spill"
-;  V22 tmp2         [V22,T23] (  2,  4.00)     int  ->  rcx         "dup spill"
-;  V23 tmp3         [V23,T37] (  2,  0.00)     int  ->  rcx         "dup spill"
-;  V24 tmp4         [V24,T26] (  3,  2.02)     int  ->  rcx        
-;  V25 tmp5         [V25,T21] (  2,  4.01)     ref  ->  rax         class-hnd exact single-def "dup spill" <ubyte[]>
-;  V26 tmp6         [V26,T27] (  2,  2.02)     int  ->  rdx        
-;  V27 tmp7         [V27,T28] (  2,  2.02)     int  ->   r8        
+;  V21 tmp1         [V21,T18] (  2,  4.02)     int  ->  rcx         "dup spill"
+;  V22 tmp2         [V22,T23] (  2,  3.95)     int  ->  rcx         "dup spill"
+;  V23 tmp3         [V23,T38] (  2,  0.00)     int  ->  rcx         "dup spill"
+;  V24 tmp4         [V24,T26] (  3,  2.01)     int  ->  rcx        
+;  V25 tmp5         [V25,T19] (  2,  4.02)     ref  ->  rax         class-hnd exact single-def "dup spill" <ubyte[]>
+;  V26 tmp6         [V26,T29] (  2,  2.01)     int  ->  rdx        
+;  V27 tmp7         [V27,T30] (  2,  2.01)     int  ->   r8        
 ;  V28 tmp8         [V28,T34] (  2,  0.00)     int  ->  rcx        
-;  V29 tmp9         [V29,T35] (  3,  0   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V29 tmp9         [V29,T36] (  3,  0   )     ref  ->  r14         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;* V30 tmp10        [V30    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[ubyte]>
 ;  V31 tmp11        [V31,T22] (  4,  4   )     ref  ->  rax         "Single return block return value"
-;  V32 tmp12        [V32,T03] ( 12, 84.23)   byref  ->  rsi         "field V02._reference (fldOffset=0x0)" P-INDEP
-;  V33 tmp13        [V33,T02] ( 13, 84.24)     int  ->  rdi         "field V02._length (fldOffset=0x8)" P-INDEP
-;  V34 tmp14        [V34,T29] (  2,  2.00)   byref  ->  rsi         "field V30._reference (fldOffset=0x0)" P-INDEP
-;  V35 tmp15        [V35,T30] (  2,  2.00)     int  ->  rdi         "field V30._length (fldOffset=0x8)" P-INDEP
+;  V32 tmp12        [V32,T03] ( 12, 82.58)   byref  ->  rsi         "field V02._reference (fldOffset=0x0)" P-INDEP
+;  V33 tmp13        [V33,T02] ( 13, 82.58)     int  ->  rdi         "field V02._length (fldOffset=0x8)" P-INDEP
+;  V34 tmp14        [V34,T27] (  2,  2.01)   byref  ->  rsi         "field V30._reference (fldOffset=0x0)" P-INDEP
+;  V35 tmp15        [V35,T28] (  2,  2.01)     int  ->  rdi         "field V30._length (fldOffset=0x8)" P-INDEP
 ;* V36 tmp16        [V36    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[ubyte]>
-;  V37 tmp17        [V37,T36] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
-;  V38 cse0         [V38,T07] ( 10, 24.85)     int  ->  registers   multi-def "CSE #02: aggressive"
-;  V39 cse1         [V39,T24] (  3,  3.03)     int  ->  rcx         "CSE #10: moderate"
-;  V40 cse2         [V40,T10] ( 11,  7.04)     int  ->  registers   multi-def "CSE #01: aggressive"
+;  V37 tmp17        [V37,T37] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
+;  V38 cse0         [V38,T07] ( 10, 24.42)     int  ->  registers   multi-def "CSE #02: aggressive"
+;  V39 cse1         [V39,T25] (  3,  3.01)     int  ->  rcx         "CSE #10: moderate"
+;  V40 cse2         [V40,T10] ( 11,  7.00)     int  ->  registers   multi-def "CSE #01: aggressive"
+;  V41 rat0         [V41,T05] (  6, 78.59)    long  ->  rcx         "Widened IV V18"
 ;
 ; Lcl frame size = 56
 
@@ -1412,7 +1413,7 @@ G_M14351_IG03:
        xor      r14d, r14d
        mov      r15, gword ptr [rcx]
        test     r15, r15
-       je       G_M14351_IG26
+       je       G_M14351_IG25
 						;; size=15 bbWeight=1.01 PerfScore 3.53
 G_M14351_IG04:
        cmp      ebp, -1
@@ -1433,27 +1434,27 @@ G_M14351_IG06:
        movzx    rcx, cl
        cmp      ecx, r13d
        jne      G_M14351_IG23
-						;; size=18 bbWeight=1.01 PerfScore 2.27
+						;; size=18 bbWeight=1.01 PerfScore 2.26
 G_M14351_IG07:
        mov      ecx, r12d
        shr      ecx, 16
        movzx    rcx, cl
        cmp      ecx, r13d
        je       G_M14351_IG30
-						;; size=18 bbWeight=1.00 PerfScore 2.25
+						;; size=18 bbWeight=0.99 PerfScore 2.22
 G_M14351_IG08:
        mov      r8d, 2
-						;; size=6 bbWeight=1.00 PerfScore 0.25
+						;; size=6 bbWeight=0.99 PerfScore 0.25
 G_M14351_IG09:
        and      ecx, 128
        mov      eax, r13d
        and      eax, 128
        cmp      ecx, eax
-       jne      G_M14351_IG25
-						;; size=22 bbWeight=1.01 PerfScore 2.02
+       jne      G_M14351_IG24
+						;; size=22 bbWeight=1.01 PerfScore 2.01
 G_M14351_IG10:
        xor      ecx, ecx
-						;; size=2 bbWeight=1.01 PerfScore 0.25
+						;; size=2 bbWeight=0.99 PerfScore 0.25
 G_M14351_IG11:
        movzx    rax, cl
        mov      dword ptr [rsp+0x30], eax
@@ -1464,7 +1465,7 @@ G_M14351_IG11:
        lea      ecx, [r8+rcx+0x01]
        test     r15, r15
        je       SHORT G_M14351_IG13
-						;; size=29 bbWeight=1.01 PerfScore 6.05
+						;; size=29 bbWeight=1.01 PerfScore 6.03
 G_M14351_IG12:
        mov      r10d, dword ptr [r15+0x08]
        sub      r10d, 1
@@ -1473,10 +1474,10 @@ G_M14351_IG12:
        jo       G_M14351_IG32
        add      ecx, r10d
        jo       G_M14351_IG32
-						;; size=33 bbWeight=1.00 PerfScore 7.51
+						;; size=33 bbWeight=0.99 PerfScore 7.40
 G_M14351_IG13:
        test     edx, edx
-       jne      G_M14351_IG24
+       jne      G_M14351_IG26
 						;; size=8 bbWeight=1.01 PerfScore 1.26
 G_M14351_IG14:
        mov      dword ptr [rsp+0x2C], ecx
@@ -1485,7 +1486,7 @@ G_M14351_IG14:
        call     CORINFO_HELP_NEWARR_1_VC
        lea      rsi, bword ptr [rax+0x10]
        mov      edi, dword ptr [rax+0x08]
-						;; size=29 bbWeight=1.00 PerfScore 5.01
+						;; size=29 bbWeight=1.00 PerfScore 5.02
 G_M14351_IG15:
        movzx    rcx, bl
        mov      ebx, dword ptr [rsp+0x2C]
@@ -1499,7 +1500,7 @@ G_M14351_IG15:
        cmove    r8d, r10d
        test     r15, r15
        je       G_M14351_IG19
-						;; size=46 bbWeight=1.01 PerfScore 4.79
+						;; size=46 bbWeight=1.00 PerfScore 4.77
 G_M14351_IG16:
        xor      ecx, ecx
        mov      r10d, dword ptr [r15+0x08]
@@ -1507,13 +1508,12 @@ G_M14351_IG16:
        test     r10d, r10d
        jle      SHORT G_M14351_IG19
        align    [0 bytes for IG17]
-						;; size=14 bbWeight=1.01 PerfScore 3.78
+						;; size=14 bbWeight=1.00 PerfScore 3.76
 G_M14351_IG17:
-       mov      r9d, ecx
-       mov      r9d, dword ptr [r15+4*r9+0x10]
+       mov      r9d, dword ptr [r15+4*rcx+0x10]
        cmp      ebp, -1
        je       G_M14351_IG39
-						;; size=17 bbWeight=19.81 PerfScore 69.34
+						;; size=14 bbWeight=19.40 PerfScore 63.04
 G_M14351_IG18:
        cmp      edx, edi
        jae      G_M14351_IG33
@@ -1543,7 +1543,7 @@ G_M14351_IG18:
        inc      ecx
        cmp      r10d, ecx
        jg       SHORT G_M14351_IG17
-						;; size=95 bbWeight=19.81 PerfScore 287.25
+						;; size=95 bbWeight=19.40 PerfScore 281.26
 G_M14351_IG19:
        cmp      edx, edi
        jae      G_M14351_IG33
@@ -1572,7 +1572,7 @@ G_M14351_IG20:
        mov      byte  ptr [rsi+rcx], r10b
        cmp      ebx, 2
        jne      G_M14351_IG27
-						;; size=62 bbWeight=1.00 PerfScore 9.46
+						;; size=62 bbWeight=0.99 PerfScore 9.42
 G_M14351_IG21:
        cmp      dword ptr [rsp+0x30], 0
        jne      G_M14351_IG40
@@ -1592,8 +1592,23 @@ G_M14351_IG22:
 G_M14351_IG23:
        mov      r8d, 3
        jmp      G_M14351_IG09
-						;; size=11 bbWeight=0.01 PerfScore 0.02
+						;; size=11 bbWeight=0.02 PerfScore 0.04
 G_M14351_IG24:
+       xor      ecx, ecx
+       test     r9b, r9b
+       sete     cl
+       jmp      G_M14351_IG11
+						;; size=13 bbWeight=0.01 PerfScore 0.04
+G_M14351_IG25:
+       mov      ecx, 255
+       xor      eax, eax
+       test     ebp, ebp
+       cmovge   ecx, eax
+       movzx    r13, cl
+       mov      r12d, ebp
+       jmp      G_M14351_IG06
+						;; size=24 bbWeight=0.00 PerfScore 0.00
+G_M14351_IG26:
        cmp      edx, 1
        je       G_M14351_IG31
        mov      r10, bword ptr [rsp+0xA8]
@@ -1607,22 +1622,7 @@ G_M14351_IG24:
        mov      rax, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      rax, gword ptr [rax]
        jmp      G_M14351_IG15
-						;; size=70 bbWeight=0.01 PerfScore 0.08
-G_M14351_IG25:
-       xor      ecx, ecx
-       test     r9b, r9b
-       sete     cl
-       jmp      G_M14351_IG11
-						;; size=13 bbWeight=0.00 PerfScore 0.01
-G_M14351_IG26:
-       mov      ecx, 255
-       xor      eax, eax
-       test     ebp, ebp
-       cmovge   ecx, eax
-       movzx    r13, cl
-       mov      r12d, ebp
-       jmp      G_M14351_IG06
-						;; size=24 bbWeight=0.00 PerfScore 0.00
+						;; size=70 bbWeight=0.00 PerfScore 0.01
 G_M14351_IG27:
        add      edx, r8d
        cmp      edx, edi
@@ -1760,6 +1760,6 @@ G_M14351_IG44:
        jmp      G_M14351_IG09
 						;; size=11 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1071, prolog size 23, PerfScore 443.44, instruction count 284, allocated bytes for code 1075 (MethodHash=f46ec7f0) for method System.Numerics.BigInteger:TryGetBytes(int,System.Span`1[ubyte],ubyte,ubyte,byref):ubyte[]:this (Tier1)
+; Total bytes of code 1068, prolog size 23, PerfScore 430.87, instruction count 283, allocated bytes for code 1072 (MethodHash=f46ec7f0) for method System.Numerics.BigInteger:TryGetBytes(int,System.Span`1[ubyte],ubyte,ubyte,byref):ubyte[]:this (Tier1)
 ; ============================================================
 


```

</details>

# ``Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark.Indexer_FirstElement_String``

Hot functions:

- (45.39%) ``StringValuesBenchmark.Indexer_FirstElement_String`` (Tier-1)
  - **Has diffs**
- (38.59%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]StringValuesBenchmark.Indexer_FirstElement_String()``

```diff
 ;
 ;  V00 this         [V00,T00] (  3,  3   )     ref  ->  rcx         this class-hnd single-def <Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark>
 ;  V01 OutArgs      [V01    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V02 tmp1         [V02,T03] (  3,  1   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
+;  V02 tmp1         [V02,T02] (  3,  1   )     ref  ->  rax         class-hnd "Inline return value spill temp" <System.String>
 ;* V03 tmp2         [V03    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V04 tmp3         [V04,T01] (  7,  3.25)     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V04 tmp3         [V04,T01] (  7,  3   )     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
 ;* V05 tmp4         [V05    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "spilling qmarkNull" <System.String>
-;  V06 tmp5         [V06,T02] (  2,  1   )     ref  ->  rax         class-hnd exact "Inline stloc first use temp" <System.String>
+;  V06 tmp5         [V06,T03] (  2,  0.88)     ref  ->  rax         class-hnd exact "Inline stloc first use temp" <System.String>
 ;* V07 tmp6         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "updating class info" <<unknown class>>
 ;
 ; Lcl frame size = 40
@@ -97,40 +97,36 @@ G_M29743_IG01:
 G_M29743_IG02:
        mov      rcx, gword ptr [rcx+0x18]
        test     rcx, rcx
-       jne      SHORT G_M29743_IG04
+       je       SHORT G_M29743_IG04
 						;; size=9 bbWeight=1 PerfScore 3.25
 G_M29743_IG03:
-       mov      rax, rcx
-       test     rcx, rcx
-       je       SHORT G_M29743_IG09
-       jmp      SHORT G_M29743_IG06
-						;; size=10 bbWeight=0.50 PerfScore 1.75
-G_M29743_IG04:
        mov      rax, 0xD1FFAB1E      ; System.String
        cmp      qword ptr [rcx], rax
-       je       SHORT G_M29743_IG03
+       jne      SHORT G_M29743_IG07
 						;; size=15 bbWeight=0.25 PerfScore 1.06
+G_M29743_IG04:
+       mov      rax, rcx
+       test     rcx, rcx
+       je       SHORT G_M29743_IG08
+						;; size=8 bbWeight=0.38 PerfScore 0.56
 G_M29743_IG05:
-       jmp      SHORT G_M29743_IG08
-						;; size=2 bbWeight=0.12 PerfScore 0.25
-G_M29743_IG06:
        add      rsp, 40
        ret      
 						;; size=5 bbWeight=0.50 PerfScore 0.62
-G_M29743_IG07:
+G_M29743_IG06:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M29743_IG08:
+G_M29743_IG07:
        cmp      dword ptr [rcx+0x08], 0
-       jbe      SHORT G_M29743_IG07
+       jbe      SHORT G_M29743_IG06
        mov      rax, gword ptr [rcx+0x10]
-       jmp      SHORT G_M29743_IG06
+       jmp      SHORT G_M29743_IG05
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M29743_IG09:
+G_M29743_IG08:
        add      rsp, 40
        tail.jmp [<unknown method>]
 						;; size=10 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 72, prolog size 4, PerfScore 7.19, instruction count 21, allocated bytes for code 72 (MethodHash=c1c38bd0) for method Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark:Indexer_FirstElement_String():System.String:this (Tier1)
+; Total bytes of code 68, prolog size 4, PerfScore 5.75, instruction count 19, allocated bytes for code 68 (MethodHash=c1c38bd0) for method Microsoft.Extensions.Primitives.Performance.StringValuesBenchmark:Indexer_FirstElement_String():System.String:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.ContainsTrueComparer<Int32>.ImmutableHashSet(Size: 512)``

Hot functions:

- (98.27%) ``System.Collections.ContainsTrueComparer`1.ImmutableHashSet`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.ContainsTrueComparer`1[System.Int32].ImmutableHashSet()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2660
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2860
 ; 6 inlinees with PGO data; 14 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T22] (  4,    4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsTrueComparer`1[int]>
-;  V01 loc0         [V01,T11] (  4, 1015.22)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T12] (  3, 1014.22)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Immutable.ImmutableHashSet`1[int]>
-;  V03 loc2         [V03,T19] (  3,  508.61)     ref  ->  rdi         class-hnd single-def <<unknown class>>
-;  V04 loc3         [V04,T05] (  5, 2027.44)     int  ->  rbp        
+;  V00 this         [V00,T21] (  4,    4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsTrueComparer`1[int]>
+;  V01 loc0         [V01,T09] (  4, 1019.02)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T10] (  3, 1018.02)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Immutable.ImmutableHashSet`1[int]>
+;  V03 loc2         [V03,T18] (  3,  510.51)     ref  ->  rdi         class-hnd single-def <<unknown class>>
+;* V04 loc3         [V04,T22] (  0,    0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,    1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T04] (  6, 4050.84)     int  ->  r15         "Inlining Arg"
+;  V06 tmp1         [V06,T04] (  6, 3032.76)     int  ->  r15         "Inlining Arg"
 ;* V07 tmp2         [V07    ] (  0,    0   )  struct (32) zero-ref    do-not-enreg[S] "spilled call-like call argument" <System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]>
 ;* V08 tmp3         [V08    ] (  0,    0   )  struct (32) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]>
-;  V09 tmp4         [V09,T15] (  3, 1013.22)   ubyte  ->  r13         "Inline return value spill temp"
+;  V09 tmp4         [V09,T15] (  3, 1017.02)   ubyte  ->  r13         "Inline return value spill temp"
 ;* V10 tmp5         [V10    ] (  0,    0   )  struct (32) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]>
 ;* V11 tmp6         [V11    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "spilling ret_expr" <System.Collections.Generic.IEqualityComparer`1[int]>
 ;* V12 tmp7         [V12    ] (  0,    0   )     int  ->  zero-ref   
-;  V13 tmp8         [V13,T03] (  3, 7985.11)     int  ->  rcx         "Inline stloc first use temp"
+;  V13 tmp8         [V13,T03] (  3, 8017.51)     int  ->  rax         "Inline stloc first use temp"
 ;* V14 tmp9         [V14    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]>
-;  V15 tmp10        [V15,T18] (  3, 1012.20)     int  ->  rcx         "guarded devirt return temp"
+;  V15 tmp10        [V15,T17] (  3, 1007.87)     int  ->  rax         "guarded devirt return temp"
 ;* V16 tmp11        [V16    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.ContainsTrueComparer`1+WrapDefaultComparer[int]>
 ;* V17 tmp12        [V17    ] (  0,    0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V18 tmp13        [V18    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
-;* V19 tmp14        [V19,T21] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V19 tmp14        [V19,T20] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V20 tmp15        [V20    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V21 tmp16        [V21,T00] (  8,14737.25)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V22 tmp17        [V22,T14] (  4, 1013.22)   ubyte  ->  r13         "Inline return value spill temp"
+;  V21 tmp16        [V21,T00] (  8,14802.73)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V22 tmp17        [V22,T13] (  4, 1017.02)   ubyte  ->  r13         "Inline return value spill temp"
 ;* V23 tmp18        [V23    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Collections.Generic.IEqualityComparer`1[int]>
-;  V24 tmp19        [V24,T17] (  2, 1013.22)     int  ->  rax         "guarded devirt return temp"
+;  V24 tmp19        [V24,T23] (  2,    0   )     int  ->  rax         "guarded devirt return temp"
 ;* V25 tmp20        [V25    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.ContainsTrueComparer`1+WrapDefaultComparer[int]>
 ;* V26 tmp21        [V26    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp22        [V27    ] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V28 tmp23        [V28    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V29 tmp24        [V29    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableList`1+Node[int]>
-;  V30 tmp25        [V30,T08] (  3, 1519.83)     ref  ->  r13         "field V08._root (fldOffset=0x0)" P-INDEP
-;  V31 tmp26        [V31,T16] (  2, 1013.22)     ref  ->  r12         "field V08._equalityComparer (fldOffset=0x8)" P-INDEP
+;  V30 tmp25        [V30,T06] (  3, 1525.53)     ref  ->  r13         "field V08._root (fldOffset=0x0)" P-INDEP
+;  V31 tmp26        [V31,T16] (  2, 1017.02)     ref  ->  r12         "field V08._equalityComparer (fldOffset=0x8)" P-INDEP
 ;* V32 tmp27        [V32    ] (  0,    0   )     ref  ->  zero-ref    "field V08._hashBucketEqualityComparer (fldOffset=0x10)" P-INDEP
 ;* V33 tmp28        [V33    ] (  0,    0   )     int  ->  zero-ref    "field V08._count (fldOffset=0x18)" P-INDEP
 ;* V34 tmp29        [V34    ] (  0,    0   )     ref  ->  zero-ref    "field V10._root (fldOffset=0x0)" P-INDEP
-;  V35 tmp30        [V35,T06] (  5, 1519.83)     ref  ->  r12         "field V10._equalityComparer (fldOffset=0x8)" P-INDEP
+;  V35 tmp30        [V35,T11] (  5, 1017.02)     ref  ->  r12         "field V10._equalityComparer (fldOffset=0x8)" P-INDEP
 ;* V36 tmp31        [V36    ] (  0,    0   )     ref  ->  zero-ref    "field V10._hashBucketEqualityComparer (fldOffset=0x10)" P-INDEP
 ;* V37 tmp32        [V37    ] (  0,    0   )     int  ->  zero-ref    "field V10._count (fldOffset=0x18)" P-INDEP
-;  V38 tmp33        [V38,T13] (  4, 1013.22)     ref  ->  [rsp+0x30]  spill-single-def "field V14._additionalElements (fldOffset=0x0)" P-INDEP
-;  V39 tmp34        [V39,T07] (  3, 1519.83)     int  ->   r8         "field V14._firstValue (fldOffset=0x8)" P-INDEP
-;  V40 cse0         [V40,T01] (  3,11471.05)     int  ->  rdx         "CSE #01: aggressive"
-;  V41 cse1         [V41,T02] (  3, 9724.68)     ref  ->   r8         "CSE #02: aggressive"
-;  V42 cse2         [V42,T20] (  3,  508.61)     int  ->  r14         "CSE #05: moderate"
-;  V43 cse3         [V43,T09] (  3, 1519.83)    long  ->  [rsp+0x40]  spill-single-def "CSE #03: aggressive"
-;  V44 cse4         [V44,T10] (  3, 1519.83)    long  ->  [rsp+0x38]  spill-single-def "CSE #04: aggressive"
+;  V38 tmp33        [V38,T12] (  4, 1017.02)     ref  ->  [rsp+0x30]  spill-single-def "field V14._additionalElements (fldOffset=0x0)" P-INDEP
+;  V39 tmp34        [V39,T14] (  3, 1017.02)     int  ->  r11         "field V14._firstValue (fldOffset=0x8)" P-INDEP
+;  V40 cse0         [V40,T01] (  3,11517.75)     int  ->  rdx         "CSE #01: aggressive"
+;  V41 cse1         [V41,T02] (  3, 9758.30)     ref  ->  rcx         "CSE #02: aggressive"
+;  V42 cse2         [V42,T19] (  3,  510.51)     int  ->  r14         "CSE #05: moderate"
+;  V43 cse3         [V43,T07] (  3, 1525.53)    long  ->  [rsp+0x40]  spill-single-def "CSE #03: aggressive"
+;  V44 cse4         [V44,T08] (  3, 1525.53)    long  ->  [rsp+0x38]  spill-single-def "CSE #04: aggressive"
+;  V45 rat0         [V45,T05] (  5, 2035.04)    long  ->  rbp         "Widened IV V04"
 ;
 ; Lcl frame size = 72
 
@@ -326,83 +327,74 @@ G_M15566_IG02:
        xor      ebp, ebp
        mov      r14d, dword ptr [rdi+0x08]
        test     r14d, r14d
-       jle      G_M15566_IG15
+       jle      G_M15566_IG14
 						;; size=25 bbWeight=1 PerfScore 7.75
 G_M15566_IG03:
-       mov      ecx, ebp
-       mov      r15d, dword ptr [rdi+4*rcx+0x10]
+       mov      r15d, dword ptr [rdi+4*rbp+0x10]
        mov      r13, gword ptr [rsi+0x10]
        mov      r12, gword ptr [rsi+0x08]
-       mov      rax, qword ptr [r12]
-       mov      qword ptr [rsp+0x40], rax
+       mov      r8, qword ptr [r12]
+       mov      qword ptr [rsp+0x40], r8
        mov      r10, 0xD1FFAB1E      ; System.Collections.ContainsTrueComparer`1+WrapDefaultComparer[int]
        mov      qword ptr [rsp+0x38], r10
-       cmp      rax, r10
-       jne      G_M15566_IG17
-						;; size=48 bbWeight=506.61 PerfScore 5952.67
+       cmp      r8, r10
+       jne      SHORT G_M15566_IG16
+		  ;; NOP compensation instructions of 4 bytes.
+						;; size=46 bbWeight=508.51 PerfScore 5847.85
 G_M15566_IG04:
-       mov      ecx, r15d
-						;; size=3 bbWeight=505.59 PerfScore 126.40
+       mov      eax, r15d
+						;; size=3 bbWeight=499.36 PerfScore 124.84
 G_M15566_IG05:
        cmp      byte  ptr [r13], r13b
-       align    [0 bytes for IG06]
-						;; size=4 bbWeight=506.61 PerfScore 1519.83
+       align    [2 bytes for IG06]
+						;; size=6 bbWeight=508.51 PerfScore 1652.65
 G_M15566_IG06:
-       mov      r8, gword ptr [r13+0x08]
-       test     r8, r8
+       mov      rcx, gword ptr [r13+0x08]
+       test     rcx, rcx
        je       G_M15566_IG20
        mov      edx, dword ptr [r13+0x18]
-       cmp      ecx, edx
+       cmp      eax, edx
        je       SHORT G_M15566_IG10
-						;; size=21 bbWeight=3992.55 PerfScore 25951.60
+						;; size=21 bbWeight=4008.75 PerfScore 26056.89
 G_M15566_IG07:
-       cmp      ecx, edx
+       cmp      eax, edx
        jle      SHORT G_M15566_IG09
-						;; size=4 bbWeight=3485.94 PerfScore 4357.43
+						;; size=4 bbWeight=3500.24 PerfScore 4375.30
 G_M15566_IG08:
        mov      r13, gword ptr [r13+0x10]
        jmp      SHORT G_M15566_IG06
-						;; size=6 bbWeight=1746.37 PerfScore 6985.47
+						;; size=6 bbWeight=1759.45 PerfScore 7037.80
 G_M15566_IG09:
-       mov      r13, r8
+       mov      r13, rcx
        jmp      SHORT G_M15566_IG06
-						;; size=5 bbWeight=1739.58 PerfScore 3914.05
+						;; size=5 bbWeight=1740.79 PerfScore 3916.79
 G_M15566_IG10:
        mov      r9, gword ptr [r13+0x20]
        mov      gword ptr [rsp+0x30], r9
-       mov      r8d, dword ptr [r13+0x28]
+       mov      r11d, dword ptr [r13+0x28]
        test     r9, r9
-       je       SHORT G_M15566_IG18
-						;; size=18 bbWeight=506.61 PerfScore 3166.32
+       je       SHORT G_M15566_IG17
+						;; size=18 bbWeight=508.51 PerfScore 3178.18
 G_M15566_IG11:
-       cmp      rax, r10
-       jne      SHORT G_M15566_IG12
-       cmp      r15d, r8d
-       je       SHORT G_M15566_IG13
-       jmp      SHORT G_M15566_IG19
-						;; size=12 bbWeight=506.61 PerfScore 2279.75
+       cmp      r8, r10
+       jne      SHORT G_M15566_IG18
+       cmp      r15d, r11d
+       jne      SHORT G_M15566_IG19
+						;; size=10 bbWeight=508.51 PerfScore 1271.27
 G_M15566_IG12:
-       mov      rcx, r12
-       mov      edx, r15d
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       je       SHORT G_M15566_IG19
-						;; size=23 bbWeight=506.61 PerfScore 2533.05
-G_M15566_IG13:
        mov      r13d, 1
-						;; size=6 bbWeight=506.61 PerfScore 126.65
-G_M15566_IG14:
+						;; size=6 bbWeight=508.51 PerfScore 127.13
+G_M15566_IG13:
        xor      ebx, r13d
        movzx    rbx, bl
        inc      ebp
        cmp      r14d, ebp
        jg       G_M15566_IG03
-						;; size=17 bbWeight=506.61 PerfScore 1013.22
-G_M15566_IG15:
+						;; size=17 bbWeight=508.51 PerfScore 1017.02
+G_M15566_IG14:
        mov      eax, ebx
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M15566_IG16:
+G_M15566_IG15:
        add      rsp, 72
        pop      rbx
        pop      rbp
@@ -414,20 +406,28 @@ G_M15566_IG16:
        pop      r15
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M15566_IG17:
+G_M15566_IG16:
        mov      rcx, r12
        mov      edx, r15d
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       mov      ecx, eax
-       mov      rax, qword ptr [rsp+0x40]
+       mov      r8, qword ptr [rsp+0x40]
        mov      r10, qword ptr [rsp+0x38]
        jmp      G_M15566_IG05
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M15566_IG18:
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M15566_IG17:
        xor      r13d, r13d
-       jmp      SHORT G_M15566_IG14
+       jmp      SHORT G_M15566_IG13
 						;; size=5 bbWeight=0 PerfScore 0.00
+G_M15566_IG18:
+       mov      rcx, r12
+       mov      r8d, r11d
+       mov      edx, r15d
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M15566_IG12
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M15566_IG19:
        mov      gword ptr [rsp+0x20], r12
        mov      r9, gword ptr [rsp+0x30]
@@ -439,13 +439,13 @@ G_M15566_IG19:
        mov      r13d, eax
        not      r13d
        shr      r13d, 31
-       jmp      SHORT G_M15566_IG14
-						;; size=43 bbWeight=0 PerfScore 0.00
+       jmp      G_M15566_IG13
+						;; size=46 bbWeight=0 PerfScore 0.00
 G_M15566_IG20:
        xor      r13d, r13d
-       jmp      SHORT G_M15566_IG14
-						;; size=5 bbWeight=0 PerfScore 0.00
+       jmp      G_M15566_IG13
+						;; size=8 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 316, prolog size 16, PerfScore 57947.94, instruction count 97, allocated bytes for code 316 (MethodHash=1dccc331) for method System.Collections.ContainsTrueComparer`1[int]:ImmutableHashSet():ubyte:this (Tier1)
+; Total bytes of code 321, prolog size 16, PerfScore 54627.23, instruction count 95, allocated bytes for code 321 (MethodHash=1dccc331) for method System.Collections.ContainsTrueComparer`1[int]:ImmutableHashSet():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.CtorFromCollectionNonGeneric<String>.Hashtable(Size: 512)``

Hot functions:

- (46.28%) ``Marvin.ComputeHash32`` (Tier-1)
  - No diffs
- (35.41%) ``Hashtable.Insert`` (Tier-1)
  - **Has diffs**
- (4.78%) ``Hashtable..ctor`` (Tier-1)
  - **Has diffs**
- (2.26%) ``Hashtable.GetHash`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]Hashtable.Insert(class System.Object,class System.Object,bool)``

```diff
 ;  V01 arg1         [V01,T02] ( 14,  6.50)     ref  ->  rsi         class-hnd single-def <System.Object>
 ;  V02 arg2         [V02,T07] (  5,  3   )     ref  ->  rdi         class-hnd single-def <System.Object>
 ;  V03 arg3         [V03,T09] (  3,  2.01)   ubyte  ->  rbp         single-def
-;  V04 loc0         [V04,T14] (  5,  3.27)     int  ->  r15        
+;  V04 loc0         [V04,T13] (  5,  3.27)     int  ->  r15        
 ;* V05 loc1         [V05    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
 ;  V06 loc2         [V06,T26] (  2,  1.25)     int  ->  r14         ld-addr-op
 ;  V07 loc3         [V07,T22] (  4,  1.72)     int  ->  r13        
-;  V08 loc4         [V08,T13] ( 13,  3.49)     int  ->  registers  
+;  V08 loc4         [V08,T18] ( 13,  2.47)     int  ->  registers  
 ;  V09 loc5         [V09,T01] ( 20,  9.07)     int  ->  [rsp+0x34] 
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V11 tmp1         [V11,T05] (  3,  5.92)   byref  ->  rbp         single-def "dup spill"
 ;  V12 tmp2         [V12,T27] (  2,  0.93)     int  ->  r13         "dup spill"
-;  V13 tmp3         [V13,T36] (  3,  0   )     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
+;  V13 tmp3         [V13,T36] (  3,  0   )     ref  ->  rbx         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;  V14 tmp4         [V14,T37] (  3,  0   )   byref  ->  rcx         single-def "dup spill"
 ;  V15 tmp5         [V15,T28] (  3,  0.89)   byref  ->  rax         "dup spill"
-;  V16 tmp6         [V16,T38] (  3,  0   )     ref  ->  rdi         class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V16 tmp6         [V16,T38] (  3,  0   )     ref  ->  r12         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V17 tmp7         [V17    ] (  0,  0   )     ref  ->  zero-ref    "handle histogram profile tmp"
-;  V18 tmp8         [V18,T16] (  3,  3.06)     int  ->  r15         "Inline stloc first use temp"
+;  V18 tmp8         [V18,T15] (  3,  3.06)     int  ->  r15         "Inline stloc first use temp"
 ;  V19 tmp9         [V19,T08] (  2,  4.08)     int  ->  r14         "Inlining Arg"
 ;  V20 tmp10        [V20,T19] (  4,  2.20)     int  ->  rax         "guarded devirt return temp"
 ;* V21 tmp11        [V21    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Collections.Hashtable>
@@ -57,12 +57,12 @@
 ;  V45 tmp35        [V45,T06] (  3,  5.92)     ref  ->  rcx         single-def "arr expr"
 ;* V46 tmp36        [V46,T20] (  0,  0   )     ref  ->  zero-ref    single-def "arr expr"
 ;* V47 tmp37        [V47,T21] (  0,  0   )     ref  ->  zero-ref    single-def "arr expr"
-;  V48 cse0         [V48,T18] (  3,  2.71)     ref  ->  rcx         "CSE #11: moderate"
-;  V49 cse1         [V49,T10] (  4,  3.94)   byref  ->  rbp         "CSE #22: moderate"
-;  V50 cse2         [V50,T15] (  9,  3.12)    long  ->  [rsp+0x28]  spill-single-def "CSE #09: moderate"
+;  V48 cse0         [V48,T17] (  3,  2.71)     ref  ->  rcx         "CSE #11: moderate"
+;  V49 cse1         [V49,T10] (  4,  3.94)   byref  ->  rbp         "CSE #22: aggressive"
+;  V50 cse2         [V50,T14] (  9,  3.12)    long  ->  [rsp+0x28]  spill-single-def "CSE #09: aggressive"
 ;  V51 cse3         [V51,T11] (  2,  1.97)     ref  ->  rcx         "CSE #18: moderate"
 ;  V52 cse4         [V52,T12] (  4,  3.75)     ref  ->  rdx         "CSE #14: moderate"
-;  V53 cse5         [V53,T17] (  3,  2.85)     int  ->  r14         "CSE #01: moderate"
+;  V53 cse5         [V53,T16] (  3,  2.85)     int  ->  r14         "CSE #01: moderate"
 ;  V54 cse6         [V54,T30] (  3,  0.70)     ref  ->  rcx         "CSE #13: conservative"
 ;
 ; Lcl frame size = 56
@@ -84,15 +84,15 @@ G_M9145_IG01:
 						;; size=28 bbWeight=1 PerfScore 9.25
 G_M9145_IG02:
        test     rsi, rsi
-       je       G_M9145_IG37
+       je       G_M9145_IG34
        mov      ecx, dword ptr [rbx+0x28]
        mov      r14d, dword ptr [rbx+0x30]
        cmp      ecx, r14d
-       jge      G_M9145_IG13
+       jge      G_M9145_IG25
 						;; size=25 bbWeight=1 PerfScore 6.50
 G_M9145_IG03:
        cmp      dword ptr [rbx+0x2C], r14d
-       jg       G_M9145_IG38
+       jg       G_M9145_IG35
 						;; size=10 bbWeight=0.85 PerfScore 3.41
 G_M9145_IG04:
        mov      rcx, 0xD1FFAB1E
@@ -103,16 +103,16 @@ G_M9145_IG05:
        mov      r14d, dword ptr [rcx+0x08]
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Hashtable
        cmp      qword ptr [rbx], rcx
-       jne      G_M9145_IG21
+       jne      G_M9145_IG26
 						;; size=27 bbWeight=1.02 PerfScore 8.41
 G_M9145_IG06:
        cmp      gword ptr [rbx+0x20], 0
-       jne      SHORT G_M9145_IG10
-						;; size=7 bbWeight=0.91 PerfScore 3.63
+       jne      G_M9145_IG24
+						;; size=11 bbWeight=0.91 PerfScore 3.63
 G_M9145_IG07:
        mov      rcx, 0xD1FFAB1E      ; System.String
        cmp      qword ptr [rsi], rcx
-       jne      G_M9145_IG20
+       jne      G_M9145_IG16
 						;; size=19 bbWeight=0.74 PerfScore 3.15
 G_M9145_IG08:
        lea      rcx, bword ptr [rsi+0x0C]
@@ -137,70 +137,48 @@ G_M9145_IG09:
        xor      edx, edx
        div      edx:eax, dword ptr [rcx+0x08]
        mov      eax, edx
-       jmp      SHORT G_M9145_IG14
-						;; size=51 bbWeight=1.02 PerfScore 59.87
+						;; size=49 bbWeight=1.02 PerfScore 57.83
 G_M9145_IG10:
-       mov      rcx, gword ptr [rbx+0x20]
-       mov      rdx, rsi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       jmp      SHORT G_M9145_IG09
-						;; size=22 bbWeight=0.17 PerfScore 1.24
-G_M9145_IG11:
-       cmp      r12d, -1
-       mov      eax, dword ptr [rsp+0x34]
-       je       SHORT G_M9145_IG14
-						;; size=10 bbWeight=1.25 PerfScore 2.82
-G_M9145_IG12:
-       mov      dword ptr [rsp+0x34], eax
-       jmp      SHORT G_M9145_IG16
-						;; size=6 bbWeight=1.23 PerfScore 3.70
-G_M9145_IG13:
-       mov      rcx, rbx
-       call     [System.Collections.Hashtable:expand():this]
-       jmp      G_M9145_IG05
-						;; size=14 bbWeight=0.17 PerfScore 0.87
-G_M9145_IG14:
        mov      rdx, gword ptr [rbx+0x08]
        mov      rcx, rdx
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
+       jae      G_M9145_IG33
        mov      dword ptr [rsp+0x34], eax
        mov      r8d, eax
        lea      r8, [r8+2*r8]
        cmp      gword ptr [rcx+8*r8+0x10], rdx
-       je       G_M9145_IG41
+       je       G_M9145_IG37
 						;; size=38 bbWeight=1.25 PerfScore 15.00
-G_M9145_IG15:
+G_M9145_IG11:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
 						;; size=15 bbWeight=0.62 PerfScore 0.78
-G_M9145_IG16:
+G_M9145_IG12:
        mov      rcx, gword ptr [rbx+0x08]
        mov      eax, dword ptr [rsp+0x34]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
-       mov      dword ptr [rsp+0x34], eax
+       jae      G_M9145_IG33
        mov      edx, eax
-       lea      rdx, [rdx+2*rdx]
-       mov      qword ptr [rsp+0x28], rdx
-       mov      rcx, gword ptr [rcx+8*rdx+0x10]
+       lea      r8, [rdx+2*rdx]
+       mov      qword ptr [rsp+0x28], r8
+       mov      rcx, gword ptr [rcx+8*r8+0x10]
        test     rcx, rcx
-       jne      G_M9145_IG27
-						;; size=46 bbWeight=1.23 PerfScore 16.02
-G_M9145_IG17:
+       jne      G_M9145_IG17
+						;; size=42 bbWeight=1.23 PerfScore 14.79
+G_M9145_IG13:
        cmp      r12d, -1
-       jne      G_M9145_IG39
-						;; size=10 bbWeight=0.99 PerfScore 1.23
-G_M9145_IG18:
+       mov      dword ptr [rsp+0x34], eax
+       jne      G_M9145_IG36
+						;; size=14 bbWeight=0.99 PerfScore 2.22
+G_M9145_IG14:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      byte  ptr [rbx+0x3C], 1
        mov      rcx, gword ptr [rbx+0x08]
-       mov      ebp, dword ptr [rsp+0x34]
-       cmp      ebp, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
-       mov      edx, ebp
+       mov      r14d, dword ptr [rsp+0x34]
+       cmp      r14d, dword ptr [rcx+0x08]
+       jae      G_M9145_IG33
+       mov      edx, r14d
        lea      rdx, [rdx+2*rdx]
        lea      rbp, bword ptr [rcx+8*rdx+0x10]
        lea      rcx, bword ptr [rbp+0x08]
@@ -214,8 +192,8 @@ G_M9145_IG18:
        inc      dword ptr [rbx+0x28]
        inc      dword ptr [rbx+0x38]
        mov      byte  ptr [rbx+0x3C], 0
-						;; size=88 bbWeight=0.99 PerfScore 24.16
-G_M9145_IG19:
+						;; size=91 bbWeight=0.99 PerfScore 24.16
+G_M9145_IG15:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -227,58 +205,54 @@ G_M9145_IG19:
        pop      r15
        ret      
 						;; size=17 bbWeight=0.99 PerfScore 5.18
-G_M9145_IG20:
+G_M9145_IG16:
        mov      rcx, rsi
        mov      rax, qword ptr [rsi]
        mov      rax, qword ptr [rax+0x40]
        call     [rax+0x18]<unknown method>
        jmp      G_M9145_IG09
 						;; size=18 bbWeight=0.31 PerfScore 2.88
-G_M9145_IG21:
-       mov      rcx, rbx
-       mov      rdx, rsi
-       mov      rax, qword ptr [rbx]
-       mov      rax, qword ptr [rax+0x50]
-       call     [rax]System.Collections.Hashtable:GetHash(System.Object):int:this
-       jmp      G_M9145_IG09
-						;; size=20 bbWeight=0.11 PerfScore 1.06
-G_M9145_IG22:
+G_M9145_IG17:
+       cmp      rcx, gword ptr [rbx+0x08]
+       je       G_M9145_IG38
+						;; size=10 bbWeight=0.25 PerfScore 0.98
+G_M9145_IG18:
        mov      rcx, gword ptr [rbx+0x08]
-       mov      eax, dword ptr [rsp+0x34]
+       mov      dword ptr [rsp+0x34], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
-       mov      ecx, dword ptr [rcx+8*rdx+0x20]
+       jae      G_M9145_IG33
+       mov      ecx, dword ptr [rcx+8*r8+0x20]
        and      ecx, 0xD1FFAB1E
        movsxd   rcx, ecx
-       mov      r8d, r15d
-       cmp      rcx, r8
-       je       G_M9145_IG28
-						;; size=42 bbWeight=0.25 PerfScore 2.71
-G_M9145_IG23:
+       mov      edx, r15d
+       cmp      rcx, rdx
+       je       G_M9145_IG22
+						;; size=43 bbWeight=0.25 PerfScore 2.71
+G_M9145_IG19:
        cmp      r12d, -1
-       jne      SHORT G_M9145_IG25
+       jne      SHORT G_M9145_IG21
        mov      rcx, gword ptr [rbx+0x08]
        mov      eax, dword ptr [rsp+0x34]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
-       mov      rdx, qword ptr [rsp+0x28]
-       cmp      dword ptr [rcx+8*rdx+0x20], 0
-       jl       G_M9145_IG30
-						;; size=39 bbWeight=0.23 PerfScore 3.08
-G_M9145_IG24:
+       jae      G_M9145_IG33
+       mov      r8, qword ptr [rsp+0x28]
+       cmp      dword ptr [rcx+8*r8+0x20], 0
+       jl       G_M9145_IG27
+						;; size=40 bbWeight=0.23 PerfScore 3.08
+G_M9145_IG20:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      rax, gword ptr [rbx+0x08]
        mov      r8d, dword ptr [rsp+0x34]
        cmp      r8d, dword ptr [rax+0x08]
-       jae      G_M9145_IG36
+       jae      G_M9145_IG33
        mov      r10, qword ptr [rsp+0x28]
        lea      rax, bword ptr [rax+8*r10+0x20]
        or       dword ptr [rax], 0xD1FFAB1E
        inc      dword ptr [rbx+0x2C]
        mov      dword ptr [rsp+0x34], r8d
 						;; size=58 bbWeight=0.15 PerfScore 2.56
-G_M9145_IG25:
+G_M9145_IG21:
        movsxd   rax, dword ptr [rsp+0x34]
        mov      edx, r14d
        add      rax, rdx
@@ -290,19 +264,16 @@ G_M9145_IG25:
        mov      dword ptr [rsp+0x34], eax
        inc      r13d
        cmp      dword ptr [rcx+0x08], r13d
-       jle      G_M9145_IG33
-						;; size=43 bbWeight=0.23 PerfScore 18.92
-G_M9145_IG26:
+       jle      G_M9145_IG30
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M9145_IG11
-						;; size=20 bbWeight=0.12 PerfScore 0.38
-G_M9145_IG27:
-       cmp      rcx, gword ptr [rbx+0x08]
-       je       G_M9145_IG40
-       jmp      G_M9145_IG22
-						;; size=15 bbWeight=0.25 PerfScore 1.48
-G_M9145_IG28:
+       cmp      r12d, -1
+       mov      eax, dword ptr [rsp+0x34]
+       je       G_M9145_IG10
+       mov      dword ptr [rsp+0x34], eax
+       jmp      G_M9145_IG12
+						;; size=81 bbWeight=0.23 PerfScore 20.42
+G_M9145_IG22:
        mov      rcx, rbx
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_CLASSPROFILE32
@@ -310,7 +281,7 @@ G_M9145_IG28:
        mov      rcx, gword ptr [rcx+0x08]
        mov      eax, dword ptr [rsp+0x34]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
+       jae      G_M9145_IG33
        mov      r10, qword ptr [rsp+0x28]
        mov      rdx, gword ptr [rcx+8*r10+0x10]
        mov      rcx, rbx
@@ -319,36 +290,56 @@ G_M9145_IG28:
        mov      r9, qword ptr [r9+0x50]
        call     [r9+0x20]<unknown method>
        test     eax, eax
-       jne      SHORT G_M9145_IG31
+       jne      SHORT G_M9145_IG28
 						;; size=69 bbWeight=0.01 PerfScore 0.28
-G_M9145_IG29:
+G_M9145_IG23:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M9145_IG23
+       jmp      G_M9145_IG19
 						;; size=20 bbWeight=0.01 PerfScore 0.02
-G_M9145_IG30:
+G_M9145_IG24:
+       mov      rcx, gword ptr [rbx+0x20]
+       mov      rdx, rsi
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       jmp      G_M9145_IG09
+						;; size=25 bbWeight=0.17 PerfScore 1.24
+G_M9145_IG25:
+       mov      rcx, rbx
+       call     [System.Collections.Hashtable:expand():this]
+       jmp      G_M9145_IG05
+						;; size=14 bbWeight=0.17 PerfScore 0.87
+G_M9145_IG26:
+       mov      rcx, rbx
+       mov      rdx, rsi
+       mov      rax, qword ptr [rbx]
+       mov      rax, qword ptr [rax+0x50]
+       call     [rax]System.Collections.Hashtable:GetHash(System.Object):int:this
+       jmp      G_M9145_IG09
+						;; size=20 bbWeight=0.11 PerfScore 1.06
+G_M9145_IG27:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M9145_IG25
+       jmp      G_M9145_IG21
 						;; size=20 bbWeight=0.12 PerfScore 0.38
-G_M9145_IG31:
+G_M9145_IG28:
        test     bpl, bpl
-       jne      G_M9145_IG45
+       jne      G_M9145_IG42
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      byte  ptr [rbx+0x3C], 1
        mov      rcx, gword ptr [rbx+0x08]
-       mov      ebp, dword ptr [rsp+0x34]
-       cmp      ebp, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
+       mov      r14d, dword ptr [rsp+0x34]
+       cmp      r14d, dword ptr [rcx+0x08]
+       jae      G_M9145_IG33
        mov      rsi, qword ptr [rsp+0x28]
        lea      rcx, bword ptr [rcx+8*rsi+0x18]
        mov      rdx, rdi
        call     CORINFO_HELP_ASSIGN_REF
        inc      dword ptr [rbx+0x38]
        mov      byte  ptr [rbx+0x3C], 0
-						;; size=70 bbWeight=0.01 PerfScore 0.25
-G_M9145_IG32:
+						;; size=72 bbWeight=0.01 PerfScore 0.25
+G_M9145_IG29:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -360,15 +351,15 @@ G_M9145_IG32:
        pop      r15
        ret      
 						;; size=17 bbWeight=0.01 PerfScore 0.07
-G_M9145_IG33:
+G_M9145_IG30:
        cmp      r12d, -1
-       je       G_M9145_IG35
+       je       G_M9145_IG32
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      byte  ptr [rbx+0x3C], 1
        mov      rcx, gword ptr [rbx+0x08]
        cmp      r12d, dword ptr [rcx+0x08]
-       jae      G_M9145_IG36
+       jae      G_M9145_IG33
        mov      edx, r12d
        lea      rdx, [rdx+2*rdx]
        lea      rcx, bword ptr [rcx+8*rdx+0x18]
@@ -376,7 +367,7 @@ G_M9145_IG33:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, gword ptr [rbx+0x08]
        cmp      r12d, dword ptr [rcx+0x08]
-       jae      SHORT G_M9145_IG36
+       jae      SHORT G_M9145_IG33
        mov      edx, r12d
        lea      rdx, [rdx+2*rdx]
        lea      rcx, bword ptr [rcx+8*rdx+0x10]
@@ -384,7 +375,7 @@ G_M9145_IG33:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, gword ptr [rbx+0x08]
        cmp      r12d, dword ptr [rcx+0x08]
-       jae      SHORT G_M9145_IG36
+       jae      SHORT G_M9145_IG33
        mov      eax, r12d
        lea      rax, [rax+2*rax]
        lea      rcx, bword ptr [rcx+8*rax+0x20]
@@ -394,7 +385,7 @@ G_M9145_IG33:
        call     [System.Collections.Hashtable:UpdateVersion():this]
        mov      byte  ptr [rbx+0x3C], 0
 						;; size=134 bbWeight=0 PerfScore 0.00
-G_M9145_IG34:
+G_M9145_IG31:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -406,22 +397,22 @@ G_M9145_IG34:
        pop      r15
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M9145_IG35:
+G_M9145_IG32:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
-       mov      r12, rax
+       mov      rbx, rax
        call     [<unknown method>]
        mov      rdx, rax
-       mov      rcx, r12
+       mov      rcx, rbx
        call     [<unknown method>]
-       mov      rcx, r12
+       mov      rcx, rbx
        call     CORINFO_HELP_THROW
        int3     
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M9145_IG36:
+G_M9145_IG33:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M9145_IG37:
+G_M9145_IG34:
        mov      ecx, 0x14136
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -429,9 +420,9 @@ G_M9145_IG37:
        call     [System.ArgumentNullException:Throw(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M9145_IG38:
+G_M9145_IG35:
        cmp      dword ptr [rbx+0x28], 100
-       jle      G_M9145_IG44
+       jle      G_M9145_IG41
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      rdx, gword ptr [rbx+0x08]
@@ -440,78 +431,80 @@ G_M9145_IG38:
        call     [<unknown method>]
        jmp      G_M9145_IG05
 						;; size=46 bbWeight=0 PerfScore 0.00
-G_M9145_IG39:
+G_M9145_IG36:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      dword ptr [rsp+0x34], r12d
-       jmp      G_M9145_IG18
+       jmp      G_M9145_IG14
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M9145_IG40:
-       mov      rcx, gword ptr [rbx+0x08]
-       mov      eax, dword ptr [rsp+0x34]
-       cmp      eax, dword ptr [rcx+0x08]
-       jae      SHORT G_M9145_IG36
-       test     dword ptr [rcx+8*rdx+0x20], 0xD1FFAB1E
-       je       SHORT G_M9145_IG42
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      rdx, qword ptr [rsp+0x28]
-       jmp      G_M9145_IG22
-						;; size=48 bbWeight=0 PerfScore 0.00
-G_M9145_IG41:
+G_M9145_IG37:
        mov      eax, dword ptr [rsp+0x34]
        cmp      eax, dword ptr [rdx+0x08]
-       jae      G_M9145_IG36
+       jae      SHORT G_M9145_IG33
        mov      dword ptr [rsp+0x34], eax
        mov      ecx, eax
        lea      rcx, [rcx+2*rcx]
        cmp      dword ptr [rdx+8*rcx+0x20], 0
-       jge      SHORT G_M9145_IG43
+       jge      SHORT G_M9145_IG40
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      r12d, dword ptr [rsp+0x34]
        mov      eax, r12d
        mov      r12d, eax
-       jmp      G_M9145_IG16
-						;; size=61 bbWeight=0 PerfScore 0.00
-G_M9145_IG42:
+       jmp      G_M9145_IG12
+						;; size=57 bbWeight=0 PerfScore 0.00
+G_M9145_IG38:
+       mov      rcx, gword ptr [rbx+0x08]
+       mov      dword ptr [rsp+0x34], eax
+       cmp      eax, dword ptr [rcx+0x08]
+       jae      G_M9145_IG33
+       test     dword ptr [rcx+8*r8+0x20], 0xD1FFAB1E
+       je       SHORT G_M9145_IG39
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M9145_IG17
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M9145_IG43:
+       mov      eax, dword ptr [rsp+0x34]
+       mov      r8, qword ptr [rsp+0x28]
+       jmp      G_M9145_IG18
+						;; size=57 bbWeight=0 PerfScore 0.00
+G_M9145_IG39:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M9145_IG16
+       mov      eax, dword ptr [rsp+0x34]
+       jmp      G_M9145_IG13
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M9145_IG40:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M9145_IG12
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M9145_IG44:
+G_M9145_IG41:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        jmp      G_M9145_IG05
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M9145_IG45:
+G_M9145_IG42:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
-       mov      rdi, rax
+       mov      r12, rax
        call     [<unknown method>]
        mov      rcx, rax
        mov      rdx, gword ptr [rbx+0x08]
-       mov      r12d, dword ptr [rsp+0x34]
-       cmp      r12d, dword ptr [rdx+0x08]
-       jae      G_M9145_IG36
+       mov      r14d, dword ptr [rsp+0x34]
+       cmp      r14d, dword ptr [rdx+0x08]
+       jae      G_M9145_IG33
        mov      rbx, qword ptr [rsp+0x28]
        mov      rdx, gword ptr [rdx+8*rbx+0x10]
        mov      r8, rsi
        call     [<unknown method>]
        mov      rdx, rax
-       mov      rcx, rdi
+       mov      rcx, r12
        call     [<unknown method>]
-       mov      rcx, rdi
+       mov      rcx, r12
        call     CORINFO_HELP_THROW
        int3     
 						;; size=86 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1483, prolog size 28, PerfScore 202.49, instruction count 353, allocated bytes for code 1483 (MethodHash=3240dc46) for method System.Collections.Hashtable:Insert(System.Object,System.Object,ubyte):this (Instrumented Tier1)
+; Total bytes of code 1501, prolog size 28, PerfScore 194.34, instruction count 352, allocated bytes for code 1501 (MethodHash=3240dc46) for method System.Collections.Hashtable:Insert(System.Object,System.Object,ubyte):this (Instrumented Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Collections.Hashtable:Insert(System.Object,System.Object,ubyte):this (Tier1)
@@ -521,38 +514,38 @@ G_M9145_IG45:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 81296
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 86560
 ; 2 inlinees with PGO data; 4 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 43, 21.94)     ref  ->  rbx         this class-hnd single-def <System.Collections.Hashtable>
-;  V01 arg1         [V01,T04] (  8,  5.04)     ref  ->  rsi         class-hnd single-def <System.Object>
-;  V02 arg2         [V02,T09] (  5,  3   )     ref  ->  rdi         class-hnd single-def <System.Object>
-;  V03 arg3         [V03,T18] (  3,  2   )   ubyte  ->  rbp         single-def
-;  V04 loc0         [V04,T20] (  5,  3.76)     int  ->  r15        
+;  V00 this         [V00,T00] ( 43, 21.15)     ref  ->  rbx         this class-hnd single-def <System.Collections.Hashtable>
+;  V01 arg1         [V01,T04] (  8,  5.01)     ref  ->  rsi         class-hnd single-def <System.Object>
+;  V02 arg2         [V02,T07] (  5,  3   )     ref  ->  rdi         class-hnd single-def <System.Object>
+;  V03 arg3         [V03,T15] (  3,  2   )   ubyte  ->  rbp         single-def
+;  V04 loc0         [V04,T17] (  5,  3.59)     int  ->  r15        
 ;* V05 loc1         [V05    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op
-;  V06 loc2         [V06,T29] (  2,  1.72)     int  ->  r14         ld-addr-op
-;  V07 loc3         [V07,T22] (  4,  3.09)     int  ->  r13        
-;  V08 loc4         [V08,T11] ( 13,  4.41)     int  ->  r12        
-;  V09 loc5         [V09,T01] ( 19, 14.59)     int  ->  [rsp+0x34] 
+;  V06 loc2         [V06,T28] (  2,  1.58)     int  ->  r14         ld-addr-op
+;  V07 loc3         [V07,T23] (  4,  2.71)     int  ->  r13        
+;  V08 loc4         [V08,T11] ( 13,  4.14)     int  ->  r12        
+;  V09 loc5         [V09,T01] ( 19, 13.55)     int  ->  [rsp+0x34] 
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V11 tmp1         [V11,T05] (  3,  6   )   byref  ->  r12         single-def "dup spill"
-;  V12 tmp2         [V12,T25] (  2,  2.73)     int  ->  r13         "dup spill"
+;  V11 tmp1         [V11,T05] (  3,  6   )   byref  ->  rbp         single-def "dup spill"
+;  V12 tmp2         [V12,T25] (  2,  2.26)     int  ->  r13         "dup spill"
 ;  V13 tmp3         [V13,T32] (  3,  0   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <<unknown class>>
 ;  V14 tmp4         [V14,T33] (  3,  0   )   byref  ->  rcx         single-def "dup spill"
-;  V15 tmp5         [V15,T24] (  3,  2.93)   byref  ->  rax         "dup spill"
+;  V15 tmp5         [V15,T24] (  3,  2.45)   byref  ->  rax         "dup spill"
 ;  V16 tmp6         [V16,T34] (  3,  0   )     ref  ->  rdi         class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V17 tmp7         [V17,T21] (  3,  3.12)     int  ->  r15         "Inline stloc first use temp"
-;  V18 tmp8         [V18,T12] (  2,  4.16)     int  ->  r14         "Inlining Arg"
-;  V19 tmp9         [V19,T02] (  3, 10.33)     ref  ->  rax         "arr expr"
+;  V17 tmp7         [V17,T21] (  3,  3.04)     int  ->  r15         "Inline stloc first use temp"
+;  V18 tmp8         [V18,T12] (  2,  4.05)     int  ->  r14         "Inlining Arg"
+;  V19 tmp9         [V19,T02] (  3,  9.46)     ref  ->  rax         "arr expr"
 ;  V20 tmp10        [V20,T35] (  3,  0   )     ref  ->   r8         "arr expr"
-;  V21 tmp11        [V21,T03] (  3, 10.11)     ref  ->  rdx         "arr expr"
+;  V21 tmp11        [V21,T03] (  3,  9.39)     ref  ->  rdx         "arr expr"
 ;* V22 tmp12        [V22,T30] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;  V23 tmp13        [V23,T36] (  3,  0   )     ref  ->  r10         "arr expr"
-;  V24 tmp14        [V24,T13] (  3,  4.11)     ref  ->  rax         "arr expr"
+;  V24 tmp14        [V24,T18] (  3,  3.39)     ref  ->  rax         "arr expr"
 ;* V25 tmp15        [V25,T47] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;  V26 tmp16        [V26,T42] (  2,  0   )     ref  ->  rdx         "argument with side effect"
-;  V27 tmp17        [V27,T14] (  3,  4.10)     ref  ->  r10         "arr expr"
+;  V27 tmp17        [V27,T19] (  3,  3.37)     ref  ->  r10         "arr expr"
 ;* V28 tmp18        [V28,T31] (  0,  0   )     ref  ->  zero-ref    "arr expr"
 ;  V29 tmp19        [V29,T43] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
 ;  V30 tmp20        [V30,T37] (  3,  0   )     ref  ->  rcx         single-def "arr expr"
@@ -566,15 +559,15 @@ G_M9145_IG45:
 ;  V38 tmp28        [V38,T06] (  3,  6   )     ref  ->  rdx         single-def "arr expr"
 ;* V39 tmp29        [V39,T26] (  0,  0   )     ref  ->  zero-ref    single-def "arr expr"
 ;* V40 tmp30        [V40,T27] (  0,  0   )     ref  ->  zero-ref    single-def "arr expr"
-;  V41 cse0         [V41,T15] (  4,  4.05)     ref  ->  rdx         "CSE #08: moderate"
-;  V42 cse1         [V42,T16] (  4,  4   )   byref  ->  r12         "CSE #28: moderate"
-;  V43 cse2         [V43,T28] (  3,  1.86)   byref  ->  rax         "CSE #14: moderate"
-;  V44 cse3         [V44,T10] (  7,  4.74)    long  ->  [rsp+0x28]  spill-single-def "CSE #06: moderate"
-;  V45 cse4         [V45,T07] (  5,  4.74)     ref  ->  rax         "CSE #03: aggressive"
-;  V46 cse5         [V46,T17] (  2,  2   )     ref  ->  rdx         "CSE #24: moderate"
-;  V47 cse6         [V47,T08] (  4,  5.16)     ref  ->   r8         "CSE #20: aggressive"
-;  V48 cse7         [V48,T19] (  5,  3.42)     ref  ->  r10         multi-def "CSE #12: moderate"
-;  V49 cse8         [V49,T23] (  3,  3.00)     int  ->  r14         "CSE #01: moderate"
+;  V41 cse0         [V41,T16] (  4,  3.69)     ref  ->  rdx         "CSE #08: moderate"
+;  V42 cse1         [V42,T13] (  4,  4   )   byref  ->  rbp         "CSE #28: moderate"
+;  V43 cse2         [V43,T29] (  3,  1.53)   byref  ->  rax         "CSE #14: moderate"
+;  V44 cse3         [V44,T10] (  7,  4.26)    long  ->  [rsp+0x28]  spill-single-def "CSE #06: moderate"
+;  V45 cse4         [V45,T14] (  2,  2   )     ref  ->  rdx         "CSE #24: moderate"
+;  V46 cse5         [V46,T08] (  5,  4.26)     ref  ->  rax         "CSE #03: moderate"
+;  V47 cse6         [V47,T09] (  4,  4.73)     ref  ->   r8         "CSE #20: moderate"
+;  V48 cse7         [V48,T22] (  3,  3.01)     int  ->  r14         "CSE #01: moderate"
+;  V49 cse8         [V49,T20] (  5,  2.82)     ref  ->  r10         multi-def "CSE #12: moderate"
 ;
 ; Lcl frame size = 56
 
@@ -595,16 +588,16 @@ G_M9145_IG01:
 						;; size=28 bbWeight=1 PerfScore 9.25
 G_M9145_IG02:
        test     rsi, rsi
-       je       G_M9145_IG22
+       je       G_M9145_IG26
        mov      ecx, dword ptr [rbx+0x28]
        mov      r14d, dword ptr [rbx+0x30]
        cmp      ecx, r14d
-       jge      SHORT G_M9145_IG05
-						;; size=21 bbWeight=1 PerfScore 6.50
+       jge      G_M9145_IG16
+						;; size=25 bbWeight=1 PerfScore 6.50
 G_M9145_IG03:
        cmp      dword ptr [rbx+0x2C], r14d
-       jg       G_M9145_IG23
-						;; size=10 bbWeight=1.00 PerfScore 4.00
+       jg       G_M9145_IG27
+						;; size=10 bbWeight=1.01 PerfScore 4.03
 G_M9145_IG04:
        mov      rcx, gword ptr [rbx+0x08]
        mov      r14d, dword ptr [rcx+0x08]
@@ -627,106 +620,51 @@ G_M9145_IG04:
        xor      edx, edx
        div      edx:eax, dword ptr [rcx+0x08]
        mov      ecx, edx
-       jmp      G_M9145_IG13
-						;; size=77 bbWeight=1.04 PerfScore 72.99
+						;; size=72 bbWeight=1.01 PerfScore 69.15
 G_M9145_IG05:
-       mov      rcx, rbx
-       call     [System.Collections.Hashtable:expand():this]
-       jmp      SHORT G_M9145_IG04
-						;; size=11 bbWeight=0.04 PerfScore 0.21
+       mov      r8, gword ptr [rbx+0x08]
+       mov      rax, r8
+       cmp      ecx, dword ptr [rax+0x08]
+       jae      G_M9145_IG25
+       mov      edx, ecx
+       lea      rdx, [rdx+2*rdx]
+       cmp      gword ptr [rax+8*rdx+0x10], r8
+       je       G_M9145_IG28
+						;; size=33 bbWeight=1.58 PerfScore 17.34
 G_M9145_IG06:
        mov      rax, gword ptr [rbx+0x08]
        mov      rdx, rax
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M9145_IG21
+       jae      G_M9145_IG25
        mov      r8d, ecx
        lea      r8, [r8+2*r8]
        mov      qword ptr [rsp+0x28], r8
        mov      rdx, gword ptr [rdx+8*r8+0x10]
        test     rdx, rdx
-       je       G_M9145_IG15
-						;; size=42 bbWeight=1.68 PerfScore 18.95
+       jne      SHORT G_M9145_IG09
+						;; size=38 bbWeight=1.56 PerfScore 17.60
 G_M9145_IG07:
-       cmp      rdx, rax
-       je       G_M9145_IG24
-						;; size=9 bbWeight=0.68 PerfScore 0.86
-G_M9145_IG08:
-       cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M9145_IG21
-       mov      eax, dword ptr [rax+8*r8+0x20]
-       and      eax, 0xD1FFAB1E
-       cdqe     
-       mov      r10d, r15d
-       cmp      rax, r10
-       je       G_M9145_IG25
-						;; size=33 bbWeight=0.68 PerfScore 5.48
-G_M9145_IG09:
-       cmp      r12d, -1
-       jne      SHORT G_M9145_IG12
-						;; size=6 bbWeight=0.68 PerfScore 0.86
-G_M9145_IG10:
-       mov      r10, gword ptr [rbx+0x08]
-       cmp      ecx, dword ptr [r10+0x08]
-       jae      G_M9145_IG21
-       lea      rax, bword ptr [r10+8*r8+0x10]
-       cmp      dword ptr [rax+0x10], 0
-       jl       SHORT G_M9145_IG12
-						;; size=25 bbWeight=0.68 PerfScore 7.53
-G_M9145_IG11:
-       add      rax, 16
-       or       dword ptr [rax], 0xD1FFAB1E
-       inc      dword ptr [rbx+0x2C]
-						;; size=13 bbWeight=0.49 PerfScore 3.05
-G_M9145_IG12:
-       movsxd   rax, ecx
-       mov      edx, r14d
-       add      rax, rdx
-       mov      r10, gword ptr [rbx+0x08]
-       mov      ecx, dword ptr [r10+0x08]
-       cqo      
-       idiv     rdx:rax, rcx
-       mov      ecx, edx
-       inc      r13d
-       cmp      dword ptr [r10+0x08], r13d
-       jle      G_M9145_IG26
-       cmp      r12d, -1
-       jne      G_M9145_IG06
-						;; size=47 bbWeight=0.68 PerfScore 54.01
-G_M9145_IG13:
-       mov      r8, gword ptr [rbx+0x08]
-       mov      rax, r8
-       cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M9145_IG21
-       mov      edx, ecx
-       lea      rdx, [rdx+2*rdx]
-       cmp      gword ptr [rax+8*rdx+0x10], r8
-       je       G_M9145_IG28
-						;; size=33 bbWeight=1.72 PerfScore 18.93
-G_M9145_IG14:
-       jmp      G_M9145_IG06
-						;; size=5 bbWeight=1.68 PerfScore 3.37
-G_M9145_IG15:
        cmp      r12d, -1
        cmovne   ecx, r12d
        mov      byte  ptr [rbx+0x3C], 1
        mov      rdx, gword ptr [rbx+0x08]
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M9145_IG21
+       jae      G_M9145_IG25
        lea      rcx, [rcx+2*rcx]
-       lea      r12, bword ptr [rdx+8*rcx+0x10]
-       lea      rcx, bword ptr [r12+0x08]
+       lea      rbp, bword ptr [rdx+8*rcx+0x10]
+       lea      rcx, bword ptr [rbp+0x08]
        mov      rdx, rdi
        call     CORINFO_HELP_ASSIGN_REF
-       mov      rcx, r12
+       mov      rcx, rbp
        mov      rdx, rsi
        call     CORINFO_HELP_ASSIGN_REF
-       add      r12, 16
-       or       dword ptr [r12], r15d
+       add      rbp, 16
+       or       dword ptr [rbp], r15d
        inc      dword ptr [rbx+0x28]
        inc      dword ptr [rbx+0x38]
        mov      byte  ptr [rbx+0x3C], 0
-						;; size=76 bbWeight=1 PerfScore 22.50
-G_M9145_IG16:
+						;; size=75 bbWeight=1 PerfScore 22.50
+G_M9145_IG08:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -738,39 +676,118 @@ G_M9145_IG16:
        pop      r15
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
+G_M9145_IG09:
+       cmp      rdx, rax
+       je       G_M9145_IG17
+						;; size=9 bbWeight=0.56 PerfScore 0.71
+G_M9145_IG10:
+       cmp      ecx, dword ptr [rax+0x08]
+       jae      G_M9145_IG25
+       mov      eax, dword ptr [rax+8*r8+0x20]
+       and      eax, 0xD1FFAB1E
+       cdqe     
+       mov      r10d, r15d
+       cmp      rax, r10
+       je       G_M9145_IG18
+						;; size=33 bbWeight=0.56 PerfScore 4.52
+G_M9145_IG11:
+       cmp      r12d, -1
+       jne      SHORT G_M9145_IG14
+						;; size=6 bbWeight=0.56 PerfScore 0.71
+G_M9145_IG12:
+       mov      r10, gword ptr [rbx+0x08]
+       cmp      ecx, dword ptr [r10+0x08]
+       jae      G_M9145_IG25
+       lea      rax, bword ptr [r10+8*r8+0x10]
+       cmp      dword ptr [rax+0x10], 0
+       jl       SHORT G_M9145_IG14
+						;; size=25 bbWeight=0.56 PerfScore 6.18
+G_M9145_IG13:
+       add      rax, 16
+       or       dword ptr [rax], 0xD1FFAB1E
+       inc      dword ptr [rbx+0x2C]
+						;; size=13 bbWeight=0.41 PerfScore 2.56
+G_M9145_IG14:
+       movsxd   rax, ecx
+       mov      edx, r14d
+       add      rax, rdx
+       mov      r10, gword ptr [rbx+0x08]
+       mov      ecx, dword ptr [r10+0x08]
+       cqo      
+       idiv     rdx:rax, rcx
+       mov      ecx, edx
+       inc      r13d
+       cmp      dword ptr [r10+0x08], r13d
+       jle      G_M9145_IG19
+       cmp      r12d, -1
+       je       G_M9145_IG05
+						;; size=47 bbWeight=0.56 PerfScore 44.62
+G_M9145_IG15:
+       jmp      G_M9145_IG06
+						;; size=5 bbWeight=0.00 PerfScore 0.00
+G_M9145_IG16:
+       mov      rcx, rbx
+       call     [System.Collections.Hashtable:expand():this]
+       jmp      G_M9145_IG04
+						;; size=14 bbWeight=0.01 PerfScore 0.04
 G_M9145_IG17:
+       mov      r10, rax
        mov      dword ptr [rsp+0x34], ecx
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       call     CORINFO_HELP_NEWSFAST
-       mov      rdi, rax
-       call     [<unknown method>]
-       mov      rcx, rax
-       mov      rdx, gword ptr [rbx+0x08]
-       mov      ebx, dword ptr [rsp+0x34]
-       cmp      ebx, dword ptr [rdx+0x08]
-       jae      G_M9145_IG21
-       mov      rbx, qword ptr [rsp+0x28]
-       mov      rdx, gword ptr [rdx+8*rbx+0x10]
-       mov      r8, rsi
-       call     [<unknown method>]
-       mov      rdx, rax
-       mov      rcx, rdi
-       call     [<unknown method>]
-       mov      rcx, rdi
-       call     CORINFO_HELP_THROW
-						;; size=87 bbWeight=0 PerfScore 0.00
+       cmp      ecx, dword ptr [r10+0x08]
+       jae      G_M9145_IG25
+       test     dword ptr [r10+8*r8+0x20], 0xD1FFAB1E
+       mov      ecx, dword ptr [rsp+0x34]
+       je       G_M9145_IG07
+       mov      r8, qword ptr [rsp+0x28]
+       jmp      G_M9145_IG10
+						;; size=46 bbWeight=0 PerfScore 0.00
 G_M9145_IG18:
+       mov      dword ptr [rsp+0x34], ecx
+       mov      rcx, rbx
+       mov      r8, rsi
+       mov      rax, qword ptr [rbx]
+       mov      rax, qword ptr [rax+0x50]
+       call     [rax+0x20]<unknown method>
+       test     eax, eax
+       mov      ecx, dword ptr [rsp+0x34]
+       mov      r8, qword ptr [rsp+0x28]
+       je       G_M9145_IG11
+       test     bpl, bpl
+       je       G_M9145_IG22
+       jmp      G_M9145_IG21
+						;; size=51 bbWeight=0 PerfScore 0.00
+G_M9145_IG19:
+       cmp      r12d, -1
+       je       G_M9145_IG24
        mov      byte  ptr [rbx+0x3C], 1
-       mov      rdx, gword ptr [rbx+0x08]
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      SHORT G_M9145_IG21
-       lea      rcx, bword ptr [rdx+8*r8+0x18]
+       mov      rcx, gword ptr [rbx+0x08]
+       cmp      r12d, dword ptr [rcx+0x08]
+       jae      G_M9145_IG25
+       mov      edx, r12d
+       lea      rdx, [rdx+2*rdx]
+       lea      rcx, bword ptr [rcx+8*rdx+0x18]
        mov      rdx, rdi
        call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [rbx+0x08]
+       cmp      r12d, dword ptr [rcx+0x08]
+       jae      G_M9145_IG25
+       mov      edx, r12d
+       lea      rdx, [rdx+2*rdx]
+       lea      rcx, bword ptr [rcx+8*rdx+0x10]
+       mov      rdx, rsi
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [rbx+0x08]
+       cmp      r12d, dword ptr [rcx+0x08]
+       jae      G_M9145_IG25
+       mov      edx, r12d
+       lea      rdx, [rdx+2*rdx]
+       lea      rcx, bword ptr [rcx+8*rdx+0x20]
+       or       dword ptr [rcx], r15d
+       inc      dword ptr [rbx+0x28]
        inc      dword ptr [rbx+0x38]
        mov      byte  ptr [rbx+0x3C], 0
-						;; size=33 bbWeight=0 PerfScore 0.00
-G_M9145_IG19:
+						;; size=121 bbWeight=0 PerfScore 0.00
+G_M9145_IG20:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -782,7 +799,51 @@ G_M9145_IG19:
        pop      r15
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M9145_IG20:
+G_M9145_IG21:
+       mov      dword ptr [rsp+0x34], ecx
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     CORINFO_HELP_NEWSFAST
+       mov      rdi, rax
+       call     [<unknown method>]
+       mov      rcx, rax
+       mov      rdx, gword ptr [rbx+0x08]
+       mov      ebx, dword ptr [rsp+0x34]
+       cmp      ebx, dword ptr [rdx+0x08]
+       jae      G_M9145_IG25
+       mov      rbx, qword ptr [rsp+0x28]
+       mov      rdx, gword ptr [rdx+8*rbx+0x10]
+       mov      r8, rsi
+       call     [<unknown method>]
+       mov      rdx, rax
+       mov      rcx, rdi
+       call     [<unknown method>]
+       mov      rcx, rdi
+       call     CORINFO_HELP_THROW
+						;; size=87 bbWeight=0 PerfScore 0.00
+G_M9145_IG22:
+       mov      byte  ptr [rbx+0x3C], 1
+       mov      rdx, gword ptr [rbx+0x08]
+       cmp      ecx, dword ptr [rdx+0x08]
+       jae      SHORT G_M9145_IG25
+       lea      rcx, bword ptr [rdx+8*r8+0x18]
+       mov      rdx, rdi
+       call     CORINFO_HELP_ASSIGN_REF
+       inc      dword ptr [rbx+0x38]
+       mov      byte  ptr [rbx+0x3C], 0
+						;; size=33 bbWeight=0 PerfScore 0.00
+G_M9145_IG23:
+       add      rsp, 56
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       pop      r12
+       pop      r13
+       pop      r14
+       pop      r15
+       ret      
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M9145_IG24:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rdi, rax
@@ -794,10 +855,10 @@ G_M9145_IG20:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M9145_IG21:
+G_M9145_IG25:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M9145_IG22:
+G_M9145_IG26:
        mov      ecx, 0x14136
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -805,7 +866,7 @@ G_M9145_IG22:
        call     [System.ArgumentNullException:Throw(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M9145_IG23:
+G_M9145_IG27:
        cmp      dword ptr [rbx+0x28], 100
        jle      G_M9145_IG04
        mov      rdx, gword ptr [rbx+0x08]
@@ -814,86 +875,17 @@ G_M9145_IG23:
        call     [<unknown method>]
        jmp      G_M9145_IG04
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M9145_IG24:
-       mov      r10, rax
-       mov      dword ptr [rsp+0x34], ecx
-       cmp      ecx, dword ptr [r10+0x08]
-       jae      SHORT G_M9145_IG21
-       test     dword ptr [r10+8*r8+0x20], 0xD1FFAB1E
-       mov      ecx, dword ptr [rsp+0x34]
-       je       G_M9145_IG15
-       mov      r8, qword ptr [rsp+0x28]
-       jmp      G_M9145_IG08
-						;; size=42 bbWeight=0 PerfScore 0.00
-G_M9145_IG25:
-       mov      dword ptr [rsp+0x34], ecx
-       mov      rcx, rbx
-       mov      r8, rsi
-       mov      rax, qword ptr [rbx]
-       mov      rax, qword ptr [rax+0x50]
-       call     [rax+0x20]<unknown method>
-       test     eax, eax
-       mov      ecx, dword ptr [rsp+0x34]
-       mov      r8, qword ptr [rsp+0x28]
-       je       G_M9145_IG09
-       test     bpl, bpl
-       je       G_M9145_IG18
-       jmp      G_M9145_IG17
-						;; size=51 bbWeight=0 PerfScore 0.00
-G_M9145_IG26:
-       cmp      r12d, -1
-       je       G_M9145_IG20
-       mov      byte  ptr [rbx+0x3C], 1
-       mov      rcx, gword ptr [rbx+0x08]
-       cmp      r12d, dword ptr [rcx+0x08]
-       jae      G_M9145_IG21
-       mov      edx, r12d
-       lea      rdx, [rdx+2*rdx]
-       lea      rcx, bword ptr [rcx+8*rdx+0x18]
-       mov      rdx, rdi
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rcx, gword ptr [rbx+0x08]
-       cmp      r12d, dword ptr [rcx+0x08]
-       jae      G_M9145_IG21
-       mov      edx, r12d
-       lea      rdx, [rdx+2*rdx]
-       lea      rcx, bword ptr [rcx+8*rdx+0x10]
-       mov      rdx, rsi
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rcx, gword ptr [rbx+0x08]
-       cmp      r12d, dword ptr [rcx+0x08]
-       jae      G_M9145_IG21
-       mov      edx, r12d
-       lea      rdx, [rdx+2*rdx]
-       lea      rcx, bword ptr [rcx+8*rdx+0x20]
-       or       dword ptr [rcx], r15d
-       inc      dword ptr [rbx+0x28]
-       inc      dword ptr [rbx+0x38]
-       mov      byte  ptr [rbx+0x3C], 0
-						;; size=121 bbWeight=0 PerfScore 0.00
-G_M9145_IG27:
-       add      rsp, 56
-       pop      rbx
-       pop      rbp
-       pop      rsi
-       pop      rdi
-       pop      r12
-       pop      r13
-       pop      r14
-       pop      r15
-       ret      
-						;; size=17 bbWeight=0 PerfScore 0.00
 G_M9145_IG28:
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M9145_IG21
+       jae      SHORT G_M9145_IG25
        mov      edx, ecx
        lea      rdx, [rdx+2*rdx]
        cmp      dword ptr [r8+8*rdx+0x20], 0
        jge      G_M9145_IG06
        mov      r12d, ecx
        jmp      G_M9145_IG06
-						;; size=36 bbWeight=0 PerfScore 0.00
+						;; size=32 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 968, prolog size 28, PerfScore 233.72, instruction count 259, allocated bytes for code 968 (MethodHash=3240dc46) for method System.Collections.Hashtable:Insert(System.Object,System.Object,ubyte):this (Tier1)
+; Total bytes of code 965, prolog size 28, PerfScore 210.94, instruction count 258, allocated bytes for code 965 (MethodHash=3240dc46) for method System.Collections.Hashtable:Insert(System.Object,System.Object,ubyte):this (Tier1)
 ; ============================================================
 


```

### ``[System.Private.CoreLib]Hashtable..ctor(class System.Collections.IDictionary,float32,class System.Collections.IEqualityComparer)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 6498
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 3102
 ; 4 inlinees with PGO data; 8 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T17] ( 10,  525.00)     ref  ->  rbx         this class-hnd single-def <System.Collections.Hashtable>
+;  V00 this         [V00,T17] ( 10,  518.12)     ref  ->  rbx         this class-hnd single-def <System.Collections.Hashtable>
 ;  V01 arg1         [V01,T25] ( 12,   10.00)     ref  ->  rbp         class-hnd single-def <System.Collections.IDictionary>
 ;  V02 arg2         [V02,T33] (  3,    3   )   float  ->  [rsp+0xA0]  single-def
 ;  V03 arg3         [V03,T28] (  3,    3   )     ref  ->  r14         class-hnd single-def <System.Collections.IEqualityComparer>
-;  V04 loc0         [V04,T18] (  9,  524.57)     ref  ->  r15         class-hnd single-def <System.Collections.IDictionaryEnumerator>
+;  V04 loc0         [V04,T18] (  9,  517.13)     ref  ->  r15         class-hnd single-def <System.Collections.IDictionaryEnumerator>
 ;  V05 OutArgs      [V05    ] (  1,    1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V06 tmp1         [V06    ] (  0,    0   )     ref  ->  zero-ref    single-def
 ;* V07 tmp2         [V07    ] (  0,    0   )     ref  ->  zero-ref   
 ;  V08 tmp3         [V08,T29] (  3,    2.00)     int  ->  rdx        
-;  V09 tmp4         [V09,T05] (  6, 2059.39)     ref  ->  r12         class-hnd "impAppendStmt" <System.Object>
-;  V10 tmp5         [V10,T04] (  6, 2059.48)     ref  ->   r8         class-hnd "spilling ret_expr" <System.Object>
+;  V09 tmp4         [V09,T08] (  6, 2032.15)     ref  ->  r12         class-hnd "impAppendStmt" <System.Object>
+;  V10 tmp5         [V10,T09] (  6, 2032.15)     ref  ->   r8         class-hnd "spilling ret_expr" <System.Object>
 ;  V11 tmp6         [V11,T30] (  3,    2.00)     int  ->  rdx         "guarded devirt return temp"
 ;* V12 tmp7         [V12    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <<unknown class>>
 ;  V13 tmp8         [V13,T31] (  3,    2   )     ref  ->  r15         "guarded devirt return temp"
@@ -384,37 +384,37 @@ RWD00  	dd	3F800000h		;         1
 ;* V16 tmp11        [V16    ] (  0,    0   )     ref  ->  zero-ref    "guarded devirt return temp"
 ;* V17 tmp12        [V17    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.String,System.String]>
 ;* V18 tmp13        [V18    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Hashtable>
-;  V19 tmp14        [V19,T14] (  2,   10.23)     int  ->  rax         "guarded devirt return temp"
+;  V19 tmp14        [V19,T14] (  2,    0   )     int  ->  rax         "guarded devirt return temp"
 ;* V20 tmp15        [V20    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.String,System.String]>
 ;  V21 tmp16        [V21,T27] (  3,    6   )  struct (40) [rsp+0x20]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Generic.Dictionary`2+Enumerator[System.String,System.String]>
 ;  V22 tmp17        [V22,T26] (  6,   12   )     ref  ->  r15         class-hnd exact single-def "Single-def Box Helper" <System.Collections.Generic.Dictionary`2+Enumerator[System.String,System.String]>
-;  V23 tmp18        [V23,T01] (  8, 4078.63)   byref  ->  rax         "Inlining Arg"
+;  V23 tmp18        [V23,T01] (  8, 4065.00)   byref  ->  rax         "Inlining Arg"
 ;* V24 tmp19        [V24    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V25 tmp20        [V25,T03] (  4, 2059.57)   byref  ->  rsi         "Inlining Arg"
+;  V25 tmp20        [V25,T10] (  4, 2032.15)   byref  ->  rsi         "Inlining Arg"
 ;* V26 tmp21        [V26    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V27 tmp22        [V27,T00] ( 21,11231.39)   byref  ->  rdi         "Inlining Arg"
-;  V28 tmp23        [V28,T08] (  8, 2041.38)     int  ->  rax         "Inline stloc first use temp"
-;  V29 tmp24        [V29,T02] (  6, 3062.07)     ref  ->  r14         class-hnd exact "impAppendStmt" <<unknown class>>
-;  V30 tmp25        [V30,T07] (  8, 2041.38)   byref  ->  r13         "Inline stloc first use temp"
+;  V27 tmp22        [V27,T00] ( 21,11180.85)   byref  ->  rdi         "Inlining Arg"
+;  V28 tmp23        [V28,T05] (  8, 2032.24)     int  ->  rax         "Inline stloc first use temp"
+;  V29 tmp24        [V29,T02] (  6, 3048.35)     ref  ->  r14         class-hnd exact "impAppendStmt" <<unknown class>>
+;  V30 tmp25        [V30,T04] (  8, 2032.24)   byref  ->  r13         "Inline stloc first use temp"
 ;* V31 tmp26        [V31    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[System.String,System.String]>
-;  V32 tmp27        [V32,T09] (  4, 2041.38)     ref  ->  rdx         class-hnd "Inlining Arg" <System.__Canon>
-;  V33 tmp28        [V33,T10] (  4, 2041.38)     ref  ->  r12         class-hnd "Inlining Arg" <System.__Canon>
-;  V34 tmp29        [V34,T15] (  4, 1020.69)     ref  ->  rdx         "field V31.key (fldOffset=0x0)" P-INDEP
-;  V35 tmp30        [V35,T16] (  4, 1020.69)     ref  ->  r12         "field V31.value (fldOffset=0x8)" P-INDEP
+;  V32 tmp27        [V32,T06] (  4, 2032.24)     ref  ->  rdx         class-hnd "Inlining Arg" <System.__Canon>
+;  V33 tmp28        [V33,T07] (  4, 2032.24)     ref  ->  r12         class-hnd "Inlining Arg" <System.__Canon>
+;  V34 tmp29        [V34,T15] (  4, 1016.12)     ref  ->  rdx         "field V31.key (fldOffset=0x0)" P-INDEP
+;  V35 tmp30        [V35,T16] (  4, 1016.12)     ref  ->  r12         "field V31.value (fldOffset=0x8)" P-INDEP
 ;* V36 tmp31        [V36    ] (  0,    0   )     ref  ->  zero-ref    single-def "V21.[000..008)"
 ;  V37 tmp32        [V37,T32] (  2,    2   )     int  ->  r14         "V21.[008..012)"
 ;* V38 tmp33        [V38    ] (  0,    0   )     int  ->  zero-ref    "V21.[012..016)"
 ;* V39 tmp34        [V39    ] (  0,    0   )     int  ->  zero-ref    "V21.[016..020)"
-;  V40 cse0         [V40,T11] (  3, 1518.70)     int  ->  rcx         "CSE #10: moderate"
-;  V41 cse1         [V41,T19] (  3,   15.34)     int  ->  rdx         "CSE #16: moderate"
-;  V42 cse2         [V42,T12] (  3, 1517.71)     int  ->  rax         "CSE #08: moderate"
-;  V43 cse3         [V43,T13] (  3, 1509.22)     int  ->  rcx         "CSE #05: moderate"
-;  V44 cse4         [V44,T21] (  3,   15.33)     int  ->  rax         "CSE #14: moderate"
-;  V45 cse5         [V45,T22] (  3,   15.24)     int  ->  rcx         "CSE #11: moderate"
-;  V46 cse6         [V46,T06] (  8, 2047.93)   byref  ->  rsi         multi-def "CSE #06: aggressive"
-;  V47 cse7         [V47,T24] (  4,   12.23)    long  ->  rbp         multi-def "CSE #04: moderate"
-;  V48 cse8         [V48,T23] (  6,   14.23)    long  ->  rcx         multi-def "CSE #03: moderate"
-;  V49 cse9         [V49,T20] (  3,   15.33)     ref  ->  rcx         "CSE #15: moderate"
+;  V40 cse0         [V40,T11] (  3, 1511.84)     int  ->  rcx         "CSE #10: moderate"
+;  V41 cse1         [V41,T19] (  3,   15.27)     int  ->  rdx         "CSE #16: moderate"
+;  V42 cse2         [V42,T13] (  3, 1509.21)     int  ->  rcx         "CSE #05: moderate"
+;  V43 cse3         [V43,T12] (  3, 1510.88)     int  ->  rax         "CSE #08: moderate"
+;  V44 cse4         [V44,T22] (  3,   15.24)     int  ->  rcx         "CSE #11: moderate"
+;  V45 cse5         [V45,T21] (  3,   15.26)     int  ->  rax         "CSE #14: moderate"
+;  V46 cse6         [V46,T03] (  8, 2034.15)   byref  ->  rsi         multi-def "CSE #06: aggressive"
+;  V47 cse7         [V47,T24] (  4,   12.18)    long  ->  rbp         multi-def "CSE #04: moderate"
+;  V48 cse8         [V48,T23] (  6,   14.18)    long  ->  rcx         multi-def "CSE #03: moderate"
+;  V49 cse9         [V49,T20] (  3,   15.26)     ref  ->  rcx         "CSE #15: moderate"
 ;
 ; Lcl frame size = 72
 
@@ -443,7 +443,7 @@ G_M16736_IG02:
 G_M16736_IG03:
        mov      rdx, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rbp], rdx
-       jne      G_M16736_IG28
+       jne      G_M16736_IG26
        mov      edx, dword ptr [rbp+0x38]
        sub      edx, dword ptr [rbp+0x40]
 						;; size=26 bbWeight=1.00 PerfScore 9.25
@@ -454,10 +454,10 @@ G_M16736_IG04:
        mov      rdx, r14
        call     CORINFO_HELP_ASSIGN_REF
        test     rbp, rbp
-       je       G_M16736_IG29
+       je       G_M16736_IG27
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rbp], rcx
-       jne      G_M16736_IG30
+       jne      G_M16736_IG28
        mov      r14d, dword ptr [rbp+0x44]
        vxorps   xmm0, xmm0, xmm0
        vmovdqu  xmmword ptr [rsp+0x38], xmm0
@@ -479,14 +479,14 @@ G_M16736_IG04:
 						;; size=133 bbWeight=1 PerfScore 25.58
 G_M16736_IG05:
        test     r15, r15
-       je       G_M16736_IG17
+       je       G_M16736_IG15
        mov      rbp, qword ptr [r15]
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.Dictionary`2+Enumerator[System.String,System.String]
        cmp      rbp, rcx
-       jne      G_M16736_IG17
+       jne      G_M16736_IG15
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Hashtable
        cmp      qword ptr [rbx], rcx
-       jne      G_M16736_IG17
+       jne      G_M16736_IG15
 						;; size=50 bbWeight=1 PerfScore 9.00
 G_M16736_IG06:
        lea      rsi, bword ptr [r15+0x08]
@@ -494,9 +494,9 @@ G_M16736_IG06:
        mov      ecx, dword ptr [rdi+0x08]
        mov      rdx, gword ptr [rdi]
        cmp      ecx, dword ptr [rdx+0x44]
-       jne      G_M16736_IG26
+       jne      G_M16736_IG24
        align    [0 bytes for IG07]
-						;; size=22 bbWeight=506.23 PerfScore 4429.53
+						;; size=22 bbWeight=503.95 PerfScore 4409.55
 G_M16736_IG07:
        mov      eax, dword ptr [rdi+0x0C]
        mov      rcx, gword ptr [rdi]
@@ -508,7 +508,7 @@ G_M16736_IG07:
        xor      ecx, ecx
        mov      qword ptr [rdi+0x18], rcx
        mov      qword ptr [rdi+0x20], rcx
-						;; size=28 bbWeight=506.23 PerfScore 5441.99
+						;; size=28 bbWeight=503.95 PerfScore 5417.44
 G_M16736_IG08:
        add      rsp, 72
        pop      rbx
@@ -520,25 +520,25 @@ G_M16736_IG08:
        pop      r14
        pop      r15
        ret      
-						;; size=17 bbWeight=1 PerfScore 5.25
+						;; size=17 bbWeight=1.67 PerfScore 8.78
 G_M16736_IG09:
        xor      edx, edx
        jmp      G_M16736_IG04
-       align    [0 bytes for IG18]
+       align    [0 bytes for IG16]
 						;; size=7 bbWeight=0.00 PerfScore 0.00
 G_M16736_IG10:
        mov      rax, rsi
        mov      ecx, dword ptr [rax+0x0C]
        test     ecx, ecx
-       je       G_M16736_IG25
-						;; size=14 bbWeight=505.24 PerfScore 1768.35
+       je       G_M16736_IG23
+						;; size=14 bbWeight=502.96 PerfScore 1760.35
 G_M16736_IG11:
        mov      rdx, gword ptr [rax]
        mov      edx, dword ptr [rdx+0x38]
        inc      edx
        cmp      ecx, edx
-       je       G_M16736_IG25
-						;; size=16 bbWeight=498.74 PerfScore 2743.06
+       je       G_M16736_IG23
+						;; size=16 bbWeight=503.30 PerfScore 2768.14
 G_M16736_IG12:
        mov      r12, gword ptr [rax+0x18]
        mov      r8, gword ptr [rsi+0x20]
@@ -547,20 +547,20 @@ G_M16736_IG12:
        mov      r9d, 1
        call     [<unknown method>]
        jmp      G_M16736_IG06
-						;; size=31 bbWeight=509.74 PerfScore 4970.00
+						;; size=31 bbWeight=502.96 PerfScore 4903.84
 G_M16736_IG13:
        mov      rcx, gword ptr [rdi]
        mov      r14, gword ptr [rcx+0x10]
        lea      ecx, [rax+0x01]
        mov      dword ptr [rdi+0x0C], ecx
        cmp      eax, dword ptr [r14+0x08]
-       jae      G_M16736_IG27
+       jae      G_M16736_IG25
        mov      ecx, eax
        lea      rcx, [rcx+2*rcx]
        lea      r13, bword ptr [r14+8*rcx+0x10]
        cmp      dword ptr [r13+0x14], -1
        jl       G_M16736_IG07
-						;; size=45 bbWeight=505.24 PerfScore 7704.94
+						;; size=45 bbWeight=502.98 PerfScore 7670.42
 G_M16736_IG14:
        mov      rdx, gword ptr [r13]
        mov      r12, gword ptr [r13+0x08]
@@ -570,78 +570,70 @@ G_M16736_IG14:
        mov      rdx, r12
        call     CORINFO_HELP_ASSIGN_REF
        jmp      G_M16736_IG10
-						;; size=34 bbWeight=505.24 PerfScore 4673.49
+						;; size=34 bbWeight=502.98 PerfScore 4652.55
 G_M16736_IG15:
-       mov      r8, gword ptr [rsi+0x20]
-       mov      rcx, 0xD1FFAB1E      ; System.Collections.Hashtable
-       cmp      qword ptr [rbx], rcx
-       jne      G_M16736_IG32
-						;; size=23 bbWeight=5.15 PerfScore 32.18
-G_M16736_IG16:
-       mov      rcx, rbx
-       mov      rdx, r12
-       mov      r9d, 1
-       call     [<unknown method>]
-						;; size=18 bbWeight=5.10 PerfScore 19.14
-G_M16736_IG17:
        mov      rbp, qword ptr [r15]
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.Dictionary`2+Enumerator[System.String,System.String]
        cmp      rbp, rcx
-       jne      SHORT G_M16736_IG21
+       jne      G_M16736_IG22
        lea      rsi, bword ptr [r15+0x08]
        mov      rdi, rsi
        mov      ecx, dword ptr [rdi+0x08]
        mov      rdx, gword ptr [rdi]
        cmp      ecx, dword ptr [rdx+0x44]
-       jne      G_M16736_IG26
-						;; size=40 bbWeight=5.11 PerfScore 62.64
-G_M16736_IG18:
+       jne      G_M16736_IG24
+						;; size=44 bbWeight=5.09 PerfScore 62.36
+G_M16736_IG16:
        mov      eax, dword ptr [rdi+0x0C]
        mov      rcx, gword ptr [rdi]
        mov      edx, dword ptr [rcx+0x38]
        cmp      eax, edx
-       jb       SHORT G_M16736_IG23
+       jb       SHORT G_M16736_IG20
        inc      edx
        mov      dword ptr [rdi+0x0C], edx
        xor      ecx, ecx
        mov      qword ptr [rdi+0x18], rcx
        mov      qword ptr [rdi+0x20], rcx
        jmp      G_M16736_IG08
-						;; size=33 bbWeight=5.11 PerfScore 65.20
-G_M16736_IG19:
+						;; size=33 bbWeight=5.09 PerfScore 64.90
+G_M16736_IG17:
+       mov      rax, rsi
+       mov      ecx, dword ptr [rax+0x0C]
+       test     ecx, ecx
+       je       G_M16736_IG23
+						;; size=14 bbWeight=5.08 PerfScore 17.78
+G_M16736_IG18:
        mov      rdx, gword ptr [rax]
        mov      edx, dword ptr [rdx+0x38]
        inc      edx
        cmp      ecx, edx
-       je       SHORT G_M16736_IG25
-						;; size=12 bbWeight=5.04 PerfScore 27.71
-G_M16736_IG20:
+       je       G_M16736_IG23
+						;; size=16 bbWeight=5.08 PerfScore 27.96
+G_M16736_IG19:
        mov      r12, gword ptr [rax+0x18]
+       mov      r8, gword ptr [rsi+0x20]
+       mov      rcx, 0xD1FFAB1E      ; System.Collections.Hashtable
+       cmp      qword ptr [rbx], rcx
+       jne      G_M16736_IG30
+       mov      rcx, rbx
+       mov      rdx, r12
+       mov      r9d, 1
+       call     [<unknown method>]
        jmp      G_M16736_IG15
-						;; size=9 bbWeight=5.10 PerfScore 20.41
-G_M16736_IG21:
-       mov      rcx, r15
-       mov      r11, 0xD1FFAB1E      ; function address
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M16736_IG31
-						;; size=24 bbWeight=5.11 PerfScore 24.29
-G_M16736_IG22:
-       jmp      G_M16736_IG08
-						;; size=5 bbWeight=1 PerfScore 2.00
-G_M16736_IG23:
+						;; size=50 bbWeight=5.08 PerfScore 71.13
+G_M16736_IG20:
        mov      r14, gword ptr [rcx+0x10]
        lea      edx, [rax+0x01]
        mov      dword ptr [rdi+0x0C], edx
        cmp      eax, dword ptr [r14+0x08]
-       jae      SHORT G_M16736_IG27
+       jae      SHORT G_M16736_IG25
        mov      ecx, eax
        lea      rcx, [rcx+2*rcx]
        lea      r13, bword ptr [r14+8*rcx+0x10]
        cmp      dword ptr [r13+0x14], -1
-       jl       SHORT G_M16736_IG18
-						;; size=34 bbWeight=5.10 PerfScore 67.62
-G_M16736_IG24:
+       jl       G_M16736_IG16
+						;; size=38 bbWeight=5.08 PerfScore 67.32
+G_M16736_IG21:
        mov      rdx, gword ptr [r13]
        mov      r12, gword ptr [r13+0x08]
        lea      rcx, bword ptr [rdi+0x18]
@@ -649,23 +641,28 @@ G_M16736_IG24:
        lea      rcx, bword ptr [rdi+0x20]
        mov      rdx, r12
        call     CORINFO_HELP_ASSIGN_REF
-       mov      rax, rsi
-       mov      ecx, dword ptr [rax+0x0C]
-       test     ecx, ecx
-       jne      SHORT G_M16736_IG19
-						;; size=39 bbWeight=5.10 PerfScore 54.86
-G_M16736_IG25:
+       jmp      G_M16736_IG17
+						;; size=34 bbWeight=5.08 PerfScore 47.00
+G_M16736_IG22:
+       mov      rcx, r15
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M16736_IG29
+       jmp      G_M16736_IG08
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16736_IG23:
        call     [System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M16736_IG26:
+G_M16736_IG24:
        call     [System.ThrowHelper:ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M16736_IG27:
+G_M16736_IG25:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M16736_IG28:
+G_M16736_IG26:
        vmovss   dword ptr [rsp+0xA0], xmm2
        mov      rcx, rbp
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
@@ -674,7 +671,7 @@ G_M16736_IG28:
        vmovss   xmm2, dword ptr [rsp+0xA0]
        jmp      G_M16736_IG04
 						;; size=41 bbWeight=0 PerfScore 0.00
-G_M16736_IG29:
+G_M16736_IG27:
        mov      ecx, 0x1DFF
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -682,14 +679,14 @@ G_M16736_IG29:
        call     [System.ArgumentNullException:Throw(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16736_IG30:
+G_M16736_IG28:
        mov      rcx, rbp
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      r15, rax
        jmp      G_M16736_IG05
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16736_IG31:
+G_M16736_IG29:
        mov      rcx, r15
        mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
@@ -699,16 +696,16 @@ G_M16736_IG31:
        call     [r11]<unknown method>
        mov      r8, rax
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M16736_IG32:
+G_M16736_IG30:
        mov      rcx, rbx
        mov      rdx, r12
        mov      rax, qword ptr [rbx]
        mov      rax, qword ptr [rax+0x40]
        call     [rax+0x20]System.Collections.Hashtable:Add(System.Object,System.Object):this
-       jmp      G_M16736_IG17
+       jmp      G_M16736_IG15
 						;; size=21 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 884, prolog size 42, PerfScore 32170.33, instruction count 225, allocated bytes for code 884 (MethodHash=a69dbe9f) for method System.Collections.Hashtable:.ctor(System.Collections.IDictionary,float,System.Collections.IEqualityComparer):this (Tier1)
+; Total bytes of code 901, prolog size 42, PerfScore 32007.20, instruction count 226, allocated bytes for code 901 (MethodHash=a69dbe9f) for method System.Collections.Hashtable:.ctor(System.Collections.IDictionary,float,System.Collections.IEqualityComparer):this (Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Collections.Hashtable:.ctor(int,float):this (Tier1)
@@ -718,7 +715,7 @@ G_M16736_IG32:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 6610
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 3210
 ; 1 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;


```

</details>

# ``System.Collections.Tests.Perf_PriorityQueue<Int32, Int32>.K_Max_Elements(Size: 100)``

Hot functions:

- (98.65%) ``System.Collections.Tests.Perf_PriorityQueue`2.K_Max_Elements`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.Tests.Perf_PriorityQueue`2[System.Int32,System.Int32].K_Max_Elements()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 81104
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 83840
 ; 14 inlinees with PGO data; 14 single block inlinees; 7 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T20] (  6, 99.58)     ref  ->  rbx         this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
-;  V01 loc0         [V01,T04] ( 39,403.33)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.PriorityQueue`2[int,int]>
-;  V02 loc1         [V02,T19] (  7,102.55)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
-;  V03 loc2         [V03,T59] ( 10, 21.40)     int  ->  rbp        
+;  V00 this         [V00,T19] (  6, 99.38)     ref  ->  [rsp+0x90]  this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
+;  V01 loc0         [V01,T04] ( 39,401.98)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.PriorityQueue`2[int,int]>
+;  V02 loc1         [V02,T18] (  7,102.33)     ref  ->  [rsp+0x20]  class-hnd exact spill-single-def <<unknown class>>
+;  V03 loc2         [V03,T59] ( 10, 21.31)     int  ->  rbp        
 ;* V04 loc3         [V04    ] (  0,  0   )     int  ->  zero-ref   
 ;* V05 loc4         [V05    ] (  0,  0   )     int  ->  zero-ref   
-;  V06 loc5         [V06,T03] (  6,473.90)     int  ->  [rsp+0x44] 
+;* V06 loc5         [V06,T87] (  0,  0   )     int  ->  zero-ref   
 ;* V07 loc6         [V07    ] (  0,  0   )     int  ->  zero-ref   
 ;* V08 loc7         [V08    ] (  0,  0   )     int  ->  zero-ref   
-;  V09 loc8         [V09,T73] (  4, 16.33)     int  ->  r12        
+;  V09 loc8         [V09,T70] (  4, 16.16)     int  ->  r12        
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )  struct ( 8) zero-ref    "dup spill" <System.ValueTuple`2[int,int]>
 ;* V12 tmp2         [V12    ] (  0,  0   )  struct ( 8) zero-ref    "dup spill" <System.ValueTuple`2[int,int]>
-;  V13 tmp3         [V13,T64] ( 14, 20.35)     int  ->  r12         "Inline stloc first use temp"
+;  V13 tmp3         [V13,T60] ( 14, 20.26)     int  ->  r12         "Inline stloc first use temp"
 ;* V14 tmp4         [V14    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.ValueTuple`2[int,int]>
 ;* V15 tmp5         [V15    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.ValueTuple`2[int,int]>
-;  V16 tmp6         [V16,T42] ( 15, 39.88)     ref  ->  rdx         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V17 tmp7         [V17,T21] ( 18, 97.42)     int  ->  r12         "Inlining Arg"
-;  V18 tmp8         [V18,T70] (  8, 17.58)     int  ->  rcx         "Inline stloc first use temp"
+;  V16 tmp6         [V16,T39] ( 15, 35.75)     ref  ->  rdx         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V17 tmp7         [V17,T22] ( 18, 89.21)     int  ->  r12         "Inlining Arg"
+;  V18 tmp8         [V18,T68] (  8, 17.34)     int  ->  rcx         "Inline stloc first use temp"
 ;* V19 tmp9         [V19    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
 ;* V20 tmp10        [V20    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.ValueTuple`2[int,int]>
 ;* V21 tmp11        [V21    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V22 tmp12        [V22    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V23 tmp13        [V23    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V24 tmp14        [V24,T83] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V24 tmp14        [V24,T85] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V25 tmp15        [V25    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V26 tmp16        [V26    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
 ;* V27 tmp17        [V27    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.ValueTuple`2[int,int]>
@@ -393,109 +393,110 @@ G_M24577_IG16:
 ;* V29 tmp19        [V29    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V30 tmp20        [V30    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V31 tmp21        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V32 tmp22        [V32,T10] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V33 tmp23        [V33,T24] (  5, 95.16)     ref  ->  r10         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V34 tmp24        [V34,T32] (  5, 59.45)     int  ->   r9         "Inline stloc first use temp"
-;  V35 tmp25        [V35,T06] (  7,281.60)     int  ->  rax         "Inlining Arg"
-;  V36 tmp26        [V36,T11] (  6,179.54)     int  ->  r11         "dup spill"
-;  V37 tmp27        [V37,T12] (  9,177.53)     int  ->  registers   "Inline stloc first use temp"
+;* V32 tmp22        [V32,T16] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V33 tmp23        [V33,T23] (  5, 89.17)     ref  ->  r10         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V34 tmp24        [V34,T32] (  5, 59.20)     int  ->   r9         "Inline stloc first use temp"
+;  V35 tmp25        [V35,T07] (  7,258.65)     int  ->  rax         "Inlining Arg"
+;  V36 tmp26        [V36,T10] (  6,178.53)     int  ->  r11         "dup spill"
+;  V37 tmp27        [V37,T11] (  9,176.25)     int  ->  registers   "Inline stloc first use temp"
 ;* V38 tmp28        [V38    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
-;  V39 tmp29        [V39,T26] (  4, 69.09)     int  ->  r11         "Inline stloc first use temp"
-;  V40 tmp30        [V40,T36] (  3, 51.98)     int  ->  [rsp+0x40]  spill-single-def "Inline stloc first use temp"
-;  V41 tmp31        [V41,T05] (  7,328.52)     int  ->   r8         "dup spill"
+;  V39 tmp29        [V39,T26] (  4, 68.58)     int  ->  r11         "Inline stloc first use temp"
+;  V40 tmp30        [V40,T35] (  3, 51.54)     int  ->  rbx         "Inline stloc first use temp"
+;  V41 tmp31        [V41,T05] (  7,325.65)     int  ->   r8         "dup spill"
 ;* V42 tmp32        [V42    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
 ;* V43 tmp33        [V43    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.ValueTuple`2[int,int]>
-;  V44 tmp34        [V44,T57] (  3, 22.73)     int  ->  rbp         "Inline return value spill temp"
-;  V45 tmp35        [V45,T28] (  3, 63.65)     int  ->  rbp         "Inlining Arg"
+;  V44 tmp34        [V44,T57] (  3, 22.54)     int  ->  rbx         "Inline return value spill temp"
+;  V45 tmp35        [V45,T28] (  3, 63.11)     int  ->  rbx         "Inlining Arg"
 ;* V46 tmp36        [V46    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V47 tmp37        [V47    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V48 tmp38        [V48    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V49 tmp39        [V49,T34] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V49 tmp39        [V49,T48] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V50 tmp40        [V50    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V51 tmp41        [V51    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V52 tmp42        [V52    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V53 tmp43        [V53,T60] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V53 tmp43        [V53,T76] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V54 tmp44        [V54    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V55 tmp45        [V55,T89] (  3,  0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V56 tmp46        [V56,T55] (  5, 23.55)     int  ->  rdx         "Inline stloc first use temp"
+;  V55 tmp45        [V55,T90] (  3,  0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V56 tmp46        [V56,T55] (  5, 23.33)     int  ->  rax         "Inline stloc first use temp"
 ;* V57 tmp47        [V57    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V58 tmp48        [V58    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
-;  V59 tmp49        [V59,T45] (  5, 32.64)     ref  ->  r10         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V60 tmp50        [V60,T63] (  5, 20.39)     int  ->  rax         "Inline stloc first use temp"
-;  V61 tmp51        [V61,T22] (  7, 96.59)     int  ->  rbx         "Inlining Arg"
-;  V62 tmp52        [V62,T29] (  6, 61.58)     int  ->  rdi         "dup spill"
-;  V63 tmp53        [V63,T30] (  9, 60.89)     int  ->  registers   "Inline stloc first use temp"
+;  V59 tmp49        [V59,T42] (  5, 30.43)     ref  ->  rdx         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V60 tmp50        [V60,T62] (  5, 20.20)     int  ->  rcx         "Inline stloc first use temp"
+;  V61 tmp51        [V61,T24] (  7, 88.27)     int  ->   r9         "Inlining Arg"
+;  V62 tmp52        [V62,T29] (  6, 60.93)     int  ->  r11         "dup spill"
+;  V63 tmp53        [V63,T30] (  9, 60.15)     int  ->  registers   "Inline stloc first use temp"
 ;* V64 tmp54        [V64    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
-;  V65 tmp55        [V65,T54] (  4, 23.70)     int  ->  rdi         "Inline stloc first use temp"
-;  V66 tmp56        [V66,T69] (  3, 17.83)     int  ->   r8         "Inline stloc first use temp"
-;  V67 tmp57        [V67,T16] (  7,112.68)     int  ->  rdx         "dup spill"
+;  V65 tmp55        [V65,T54] (  4, 23.41)     int  ->  r11         "Inline stloc first use temp"
+;  V66 tmp56        [V66,T67] (  3, 17.59)     int  ->  r14         "Inline stloc first use temp"
+;  V67 tmp57        [V67,T14] (  7,111.13)     int  ->  r13         "dup spill"
 ;* V68 tmp58        [V68    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
-;  V69 tmp59        [V69,T85] (  3,  7.80)     int  ->   r8         "Inline return value spill temp"
-;  V70 tmp60        [V70,T58] (  3, 21.83)     int  ->  rcx         "Inlining Arg"
+;  V69 tmp59        [V69,T84] (  3,  7.69)     int  ->  r14         "Inline return value spill temp"
+;  V70 tmp60        [V70,T58] (  3, 21.54)     int  ->  rbp         "Inlining Arg"
 ;* V71 tmp61        [V71    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V72 tmp62        [V72    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V73 tmp63        [V73    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V74 tmp64        [V74,T66] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V74 tmp64        [V74,T82] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V75 tmp65        [V75    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V76 tmp66        [V76    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V77 tmp67        [V77    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V78 tmp68        [V78,T86] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V79 tmp69        [V79,T79] (  6, 10.17)     int  ->  r15         "field V11.Item1 (fldOffset=0x0)" P-INDEP
-;  V80 tmp70        [V80,T80] (  6, 10.17)     int  ->  r13         "field V11.Item2 (fldOffset=0x4)" P-INDEP
-;  V81 tmp71        [V81,T17] (  3,106.56)     int  ->  r15         "field V12.Item1 (fldOffset=0x0)" P-INDEP
-;  V82 tmp72        [V82,T08] (  6,216.64)     int  ->  r13         "field V12.Item2 (fldOffset=0x4)" P-INDEP
-;  V83 tmp73        [V83,T87] (  4,  0   )     int  ->  rax         "field V14.Item1 (fldOffset=0x0)" P-INDEP
-;  V84 tmp74        [V84,T88] (  4,  0   )     int  ->  r10         "field V14.Item2 (fldOffset=0x4)" P-INDEP
-;  V85 tmp75        [V85,T81] (  4, 10.17)     int  ->  r15         "field V15.Item1 (fldOffset=0x0)" P-INDEP
-;  V86 tmp76        [V86,T82] (  4, 10.17)     int  ->  r13         "field V15.Item2 (fldOffset=0x4)" P-INDEP
-;  V87 tmp77        [V87,T84] (  4,  9.25)     int  ->  rax         "field V19.Item1 (fldOffset=0x0)" P-INDEP
-;  V88 tmp78        [V88,T77] (  8, 14.09)     int  ->  r10         "field V19.Item2 (fldOffset=0x4)" P-INDEP
-;  V89 tmp79        [V89,T78] (  4, 12.10)     int  ->  r15         "field V20.Item1 (fldOffset=0x0)" P-INDEP
-;  V90 tmp80        [V90,T71] (  8, 16.94)     int  ->  r13         "field V20.Item2 (fldOffset=0x4)" P-INDEP
+;  V79 tmp69        [V79,T77] (  6, 10.13)     int  ->  r15         "field V11.Item1 (fldOffset=0x0)" P-INDEP
+;  V80 tmp70        [V80,T78] (  6, 10.13)     int  ->  r13         "field V11.Item2 (fldOffset=0x4)" P-INDEP
+;  V81 tmp71        [V81,T15] (  3,106.34)     int  ->  r15         "field V12.Item1 (fldOffset=0x0)" P-INDEP
+;  V82 tmp72        [V82,T08] (  6,216.09)     int  ->  r13         "field V12.Item2 (fldOffset=0x4)" P-INDEP
+;  V83 tmp73        [V83,T88] (  4,  0   )     int  ->  rax         "field V14.Item1 (fldOffset=0x0)" P-INDEP
+;  V84 tmp74        [V84,T89] (  4,  0   )     int  ->  r10         "field V14.Item2 (fldOffset=0x4)" P-INDEP
+;  V85 tmp75        [V85,T79] (  4, 10.13)     int  ->  r15         "field V15.Item1 (fldOffset=0x0)" P-INDEP
+;  V86 tmp76        [V86,T80] (  4, 10.13)     int  ->  r13         "field V15.Item2 (fldOffset=0x4)" P-INDEP
+;  V87 tmp77        [V87,T83] (  4,  9.16)     int  ->  rax         "field V19.Item1 (fldOffset=0x0)" P-INDEP
+;  V88 tmp78        [V88,T75] (  8, 13.91)     int  ->  r10         "field V19.Item2 (fldOffset=0x4)" P-INDEP
+;  V89 tmp79        [V89,T81] (  4, 10.13)     int  ->  r15         "field V20.Item1 (fldOffset=0x0)" P-INDEP
+;  V90 tmp80        [V90,T72] (  8, 14.88)     int  ->  r13         "field V20.Item2 (fldOffset=0x4)" P-INDEP
 ;* V91 tmp81        [V91    ] (  0,  0   )     int  ->  zero-ref    "field V26.Item1 (fldOffset=0x0)" P-INDEP
-;  V92 tmp82        [V92,T09] (  4,204.80)     int  ->   r8         "field V26.Item2 (fldOffset=0x4)" P-INDEP
-;  V93 tmp83        [V93,T91] (  2,  0   )     int  ->  rdx         "field V27.Item1 (fldOffset=0x0)" P-INDEP
-;  V94 tmp84        [V94,T92] (  2,  0   )     int  ->  rcx         "field V27.Item2 (fldOffset=0x4)" P-INDEP
-;  V95 tmp85        [V95,T52] (  2, 23.96)     int  ->  r15         "field V28.Item1 (fldOffset=0x0)" P-INDEP
-;  V96 tmp86        [V96,T53] (  2, 23.96)     int  ->  r13         "field V28.Item2 (fldOffset=0x4)" P-INDEP
-;  V97 tmp87        [V97,T33] (  3, 57.73)     int  ->  rcx         "field V38.Item1 (fldOffset=0x0)" P-INDEP
-;  V98 tmp88        [V98,T18] (  7,104.93)     int  ->  rdx         "field V38.Item2 (fldOffset=0x4)" P-INDEP
-;  V99 tmp89        [V99,T35] (  2, 53.77)     int  ->  rbp         "field V42.Item1 (fldOffset=0x0)" P-INDEP
-;  V100 tmp90       [V100,T25] (  4, 87.76)     int  ->  r13         "field V42.Item2 (fldOffset=0x4)" P-INDEP
-;  V101 tmp91       [V101,T44] (  2, 32.70)     int  ->  [rsp+0x3C]  spill-single-def "field V43.Item1 (fldOffset=0x0)" P-INDEP
-;  V102 tmp92       [V102,T37] (  4, 45.90)     int  ->  [rsp+0x38]  spill-single-def "field V43.Item2 (fldOffset=0x4)" P-INDEP
-;  V103 tmp93       [V103,T74] (  3, 16.32)     int  ->  [rsp+0x34]  spill-single-def "field V58.Item1 (fldOffset=0x0)" P-INDEP
-;  V104 tmp94       [V104,T61] (  5, 20.85)     int  ->  r15         "field V58.Item2 (fldOffset=0x4)" P-INDEP
-;  V105 tmp95       [V105,T65] (  3, 19.80)     int  ->  r14         "field V64.Item1 (fldOffset=0x0)" P-INDEP
-;  V106 tmp96       [V106,T43] (  7, 35.99)     int  ->   r9         "field V64.Item2 (fldOffset=0x4)" P-INDEP
-;  V107 tmp97       [V107,T67] (  2, 18.44)     int  ->  rbp         "field V68.Item1 (fldOffset=0x0)" P-INDEP
-;  V108 tmp98       [V108,T49] (  4, 30.10)     int  ->  rcx         "field V68.Item2 (fldOffset=0x4)" P-INDEP
-;  V109 tmp99       [V109,T47] (  6, 30.52)   byref  ->  rdx         "BlockOp address local"
-;  V110 tmp100      [V110,T46] ( 12, 30.65)  struct ( 8) [rsp+0x28]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
-;  V111 tmp101      [V111,T50] (  6, 24.99)   byref  ->   r8         "BlockOp address local"
-;  V112 tmp102      [V112,T48] (  6, 30.52)   byref  ->   r8         "BlockOp address local"
-;  V113 tmp103      [V113,T41] (  6, 42.07)   byref  ->  rcx         "BlockOp address local"
-;  V114 tmp104      [V114,T02] (  3,567.48)   byref  ->  rdx         "BlockOp address local"
-;  V115 tmp105      [V115,T00] (  3,568.37)     ref  ->  rdx         "arr expr"
-;  V116 tmp106      [V116,T01] (  3,568.37)   byref  ->  rdx         "BlockOp address local"
-;  V117 tmp107      [V117,T27] (  3, 68.19)   byref  ->  rdx         "BlockOp address local"
-;  V118 tmp108      [V118,T13] (  3,175.52)   byref  ->  r13         "BlockOp address local"
-;  V119 tmp109      [V119,T14] (  3,131.09)   byref  ->  rax         "BlockOp address local"
-;  V120 tmp110      [V120,T15] (  3,124.29)   byref  ->  rdx         "BlockOp address local"
-;  V121 tmp111      [V121,T62] (  2, 20.43)     ref  ->  rdx         "arr expr"
-;  V122 tmp112      [V122,T72] (  2, 16.44)     ref  ->  rcx         "arr expr"
-;  V123 tmp113      [V123,T51] (  3, 24.66)   byref  ->  rdx         "BlockOp address local"
-;  V124 tmp114      [V124,T56] (  3, 23.39)   byref  ->  rcx         "BlockOp address local"
-;  V125 tmp115      [V125,T31] (  3, 60.21)   byref  ->  rcx         "BlockOp address local"
-;  V126 tmp116      [V126,T38] (  3, 44.96)   byref  ->  rdx         "BlockOp address local"
-;  V127 tmp117      [V127,T40] (  3, 42.63)   byref  ->  r10         "BlockOp address local"
-;  V128 tmp118      [V128,T90] (  2,  0   )     ref  ->  rdx         "argument with side effect"
-;  V129 cse0        [V129,T76] (  3, 14.33)     int  ->  rax         "CSE #13: conservative"
-;  V130 cse1        [V130,T68] (  4, 18.44)     ref  ->  r10         "CSE #11: conservative"
-;  V131 cse2        [V131,T75] (  3, 15.33)     int  ->  rax         "CSE #10: conservative"
-;  V132 cse3        [V132,T23] (  5, 96.35)     int  ->  r14         multi-def "CSE #03: moderate"
-;  V133 cse4        [V133,T07] (  6,272.64)     int  ->  r12         "CSE #08: aggressive"
-;  V134 cse5        [V134,T39] (  7, 42.86)     int  ->  r13         "CSE #12: conservative"
+;  V92 tmp82        [V92,T09] (  4,204.19)     int  ->   r8         "field V26.Item2 (fldOffset=0x4)" P-INDEP
+;  V93 tmp83        [V93,T92] (  2,  0   )     int  ->  rdx         "field V27.Item1 (fldOffset=0x0)" P-INDEP
+;  V94 tmp84        [V94,T93] (  2,  0   )     int  ->  rcx         "field V27.Item2 (fldOffset=0x4)" P-INDEP
+;  V95 tmp85        [V95,T52] (  2, 23.93)     int  ->  r15         "field V28.Item1 (fldOffset=0x0)" P-INDEP
+;  V96 tmp86        [V96,T53] (  2, 23.93)     int  ->  r13         "field V28.Item2 (fldOffset=0x4)" P-INDEP
+;  V97 tmp87        [V97,T33] (  3, 57.31)     int  ->  rdx         "field V38.Item1 (fldOffset=0x0)" P-INDEP
+;  V98 tmp88        [V98,T17] (  7,104.10)     int  ->  rcx         "field V38.Item2 (fldOffset=0x4)" P-INDEP
+;  V99 tmp89        [V99,T34] (  2, 53.29)     int  ->  r14         "field V42.Item1 (fldOffset=0x0)" P-INDEP
+;  V100 tmp90       [V100,T25] (  4, 86.99)     int  ->  rdi         "field V42.Item2 (fldOffset=0x4)" P-INDEP
+;  V101 tmp91       [V101,T49] (  2, 27.16)     int  ->  r15         "field V43.Item1 (fldOffset=0x0)" P-INDEP
+;  V102 tmp92       [V102,T38] (  4, 40.26)     int  ->  r13         "field V43.Item2 (fldOffset=0x4)" P-INDEP
+;  V103 tmp93       [V103,T73] (  3, 14.32)     int  ->  [rsp+0x44]  spill-single-def "field V58.Item1 (fldOffset=0x0)" P-INDEP
+;  V104 tmp94       [V104,T64] (  5, 18.79)     int  ->  rax         "field V58.Item2 (fldOffset=0x4)" P-INDEP
+;  V105 tmp95       [V105,T63] (  3, 19.56)     int  ->  rbx         "field V64.Item1 (fldOffset=0x0)" P-INDEP
+;  V106 tmp96       [V106,T40] (  7, 35.53)     int  ->  registers   "field V64.Item2 (fldOffset=0x4)" P-INDEP
+;  V107 tmp97       [V107,T66] (  2, 18.19)     int  ->  r10         "field V68.Item1 (fldOffset=0x0)" P-INDEP
+;  V108 tmp98       [V108,T47] (  4, 29.69)     int  ->  r15         "field V68.Item2 (fldOffset=0x4)" P-INDEP
+;  V109 tmp99       [V109,T43] (  6, 30.38)   byref  ->  rdx         "BlockOp address local"
+;  V110 tmp100      [V110,T46] ( 12, 30.33)  struct ( 8) [rsp+0x38]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
+;  V111 tmp101      [V111,T50] (  6, 24.56)   byref  ->   r8         "BlockOp address local"
+;  V112 tmp102      [V112,T44] (  6, 30.38)   byref  ->   r8         "BlockOp address local"
+;  V113 tmp103      [V113,T45] (  6, 30.38)   byref  ->  rcx         "BlockOp address local"
+;  V114 tmp104      [V114,T02] (  3,566.25)   byref  ->  rdx         "BlockOp address local"
+;  V115 tmp105      [V115,T00] (  3,566.67)     ref  ->  rdx         "arr expr"
+;  V116 tmp106      [V116,T01] (  3,566.67)   byref  ->  rdx         "BlockOp address local"
+;  V117 tmp107      [V117,T27] (  3, 67.63)   byref  ->  rcx         "BlockOp address local"
+;  V118 tmp108      [V118,T12] (  3,173.97)   byref  ->  rdi         "BlockOp address local"
+;  V119 tmp109      [V119,T13] (  3,130.46)   byref  ->  rax         "BlockOp address local"
+;  V120 tmp110      [V120,T21] (  3, 91.18)   byref  ->  rdx         "BlockOp address local"
+;  V121 tmp111      [V121,T61] (  2, 20.22)     ref  ->   r8         "arr expr"
+;  V122 tmp112      [V122,T69] (  2, 16.33)     ref  ->  r10         "arr expr"
+;  V123 tmp113      [V123,T51] (  3, 24.50)   byref  ->  rax         "BlockOp address local"
+;  V124 tmp114      [V124,T56] (  3, 23.08)   byref  ->  rdi         "BlockOp address local"
+;  V125 tmp115      [V125,T31] (  3, 59.37)   byref  ->  r15         "BlockOp address local"
+;  V126 tmp116      [V126,T36] (  3, 44.52)   byref  ->   r9         "BlockOp address local"
+;  V127 tmp117      [V127,T41] (  3, 31.12)   byref  ->   r8         "BlockOp address local"
+;  V128 tmp118      [V128,T91] (  2,  0   )     ref  ->  rdx         "argument with side effect"
+;  V129 cse0        [V129,T74] (  3, 14.19)     int  ->  rcx         "CSE #13: conservative"
+;  V130 cse1        [V130,T65] (  4, 18.27)     ref  ->  rdx         "CSE #11: conservative"
+;  V131 cse2        [V131,T71] (  3, 15.16)     int  ->  rcx         "CSE #10: conservative"
+;  V132 cse3        [V132,T20] (  5, 96.15)     int  ->  [rsp+0x34]  multi-def "CSE #03: moderate"
+;  V133 cse4        [V133,T06] (  6,266.10)     int  ->  r12         "CSE #08: aggressive"
+;  V134 cse5        [V134,T37] (  7, 40.54)     int  ->   r8         "CSE #12: conservative"
+;  V135 rat0        [V135,T03] (  6,472.88)    long  ->  [rsp+0x28]  "Widened IV V06"
 ;
 ; Lcl frame size = 72
 
@@ -514,15 +515,16 @@ G_M24577_IG01:
 G_M24577_IG02:
        mov      rsi, gword ptr [rbx+0x10]
        mov      rdi, gword ptr [rbx+0x08]
+       mov      gword ptr [rsp+0x20], rdi
        xor      ebp, ebp
        test     rdi, rdi
-       je       G_M24577_IG22
-						;; size=19 bbWeight=1 PerfScore 5.50
+       je       G_M24577_IG21
+						;; size=24 bbWeight=1 PerfScore 6.50
 G_M24577_IG03:
        mov      r14d, dword ptr [rdi+0x08]
        cmp      r14d, 5
-       jl       G_M24577_IG22
-						;; size=14 bbWeight=0.84 PerfScore 2.72
+       jl       G_M24577_IG21
+						;; size=14 bbWeight=0.84 PerfScore 2.71
 G_M24577_IG04:
        mov      edx, ebp
        lea      rdx, bword ptr [rdi+8*rdx+0x10]
@@ -537,16 +539,16 @@ G_M24577_IG04:
        mov      dword ptr [rsi+0x20], edx
        cmp      gword ptr [rsi+0x10], 0
        jne      G_M24577_IG73
-						;; size=54 bbWeight=5.04 PerfScore 109.53
+						;; size=54 bbWeight=5.01 PerfScore 109.04
 G_M24577_IG05:
        mov      rdx, gword ptr [rsi+0x08]
        test     r12d, r12d
        jle      SHORT G_M24577_IG09
-						;; size=9 bbWeight=5.04 PerfScore 16.37
+						;; size=9 bbWeight=5.01 PerfScore 16.29
 G_M24577_IG06:
        mov      ecx, dword ptr [rdx+0x08]
        align    [0 bytes for IG07]
-						;; size=3 bbWeight=2.27 PerfScore 4.53
+						;; size=3 bbWeight=2.24 PerfScore 4.48
 G_M24577_IG07:
        lea      ecx, [r12-0x01]
        sar      ecx, 2
@@ -558,7 +560,7 @@ G_M24577_IG07:
        mov      r10d, dword ptr [r8+0x04]
        cmp      r13d, r10d
        jge      SHORT G_M24577_IG12
-						;; size=37 bbWeight=4.12 PerfScore 47.43
+						;; size=37 bbWeight=4.05 PerfScore 46.60
 G_M24577_IG08:
        cmp      r12d, dword ptr [rdx+0x08]
        jae      G_M24577_IG71
@@ -569,7 +571,7 @@ G_M24577_IG08:
        mov      r12d, ecx
        test     r12d, r12d
        jg       SHORT G_M24577_IG07
-						;; size=33 bbWeight=5.04 PerfScore 44.06
+						;; size=33 bbWeight=5.01 PerfScore 43.87
 G_M24577_IG09:
        cmp      r12d, dword ptr [rdx+0x08]
        jae      G_M24577_IG71
@@ -577,42 +579,41 @@ G_M24577_IG09:
        lea      rcx, bword ptr [rdx+8*rcx+0x10]
        mov      dword ptr [rcx], r15d
        mov      dword ptr [rcx+0x04], r13d
-						;; size=25 bbWeight=6.94 PerfScore 50.33
+						;; size=25 bbWeight=5.01 PerfScore 36.35
 G_M24577_IG10:
        inc      ebp
        cmp      ebp, 5
        jl       G_M24577_IG04
-						;; size=11 bbWeight=5.04 PerfScore 7.55
+						;; size=11 bbWeight=5.01 PerfScore 7.52
 G_M24577_IG11:
        jmp      SHORT G_M24577_IG15
 						;; size=2 bbWeight=1 PerfScore 2.00
 G_M24577_IG12:
        cmp      r13d, r10d
        jg       SHORT G_M24577_IG09
-						;; size=5 bbWeight=0.67 PerfScore 0.84
+						;; size=5 bbWeight=0.66 PerfScore 0.82
 G_M24577_IG13:
        jmp      SHORT G_M24577_IG09
-						;; size=2 bbWeight=4.12 PerfScore 8.25
+						;; size=2 bbWeight=0.59 PerfScore 1.19
 G_M24577_IG14:
        inc      ebp
        cmp      ebp, 5
-       jl       G_M24577_IG22
+       jl       G_M24577_IG21
 						;; size=11 bbWeight=0.05 PerfScore 0.08
 G_M24577_IG15:
        mov      ebp, 5
        cmp      dword ptr [rbx+0x20], 5
-       jle      G_M24577_IG49
+       jle      G_M24577_IG58
 						;; size=15 bbWeight=1 PerfScore 4.25
 G_M24577_IG16:
        cmp      ebp, r14d
        jae      G_M24577_IG71
-       mov      edx, ebp
-       lea      rdx, bword ptr [rdi+8*rdx+0x10]
+       lea      rdx, bword ptr [rdi+8*rbp+0x10]
        mov      r15d, dword ptr [rdx]
        mov      r13d, dword ptr [rdx+0x04]
        cmp      dword ptr [rsi+0x20], 0
-       je       G_M24577_IG27
-						;; size=33 bbWeight=94.58 PerfScore 993.09
+       je       G_M24577_IG26
+						;; size=31 bbWeight=94.38 PerfScore 967.35
 G_M24577_IG17:
        mov      rdx, gword ptr [rsi+0x08]
        mov      r12d, dword ptr [rdx+0x08]
@@ -623,31 +624,27 @@ G_M24577_IG17:
        mov      r8d, dword ptr [rdx+0x04]
        cmp      gword ptr [rsi+0x10], 0
        jne      G_M24577_IG76
-						;; size=38 bbWeight=94.73 PerfScore 1373.56
+       cmp      r13d, r8d
+       jl       G_M24577_IG26
+						;; size=47 bbWeight=94.45 PerfScore 1487.52
 G_M24577_IG18:
        cmp      r13d, r8d
-       jl       G_M24577_IG27
-						;; size=9 bbWeight=94.73 PerfScore 118.41
+       jle      G_M24577_IG26
+						;; size=9 bbWeight=15.30 PerfScore 19.13
 G_M24577_IG19:
-       cmp      r13d, r8d
-       jle      G_M24577_IG27
-						;; size=9 bbWeight=15.35 PerfScore 19.18
-G_M24577_IG20:
-       mov      dword ptr [rsp+0x3C], r15d
-       mov      dword ptr [rsp+0x38], r13d
        xor      eax, eax
        mov      r10, gword ptr [rsi+0x08]
        mov      r9d, dword ptr [rsi+0x20]
        mov      r11d, 1
        mov      r8d, 1
        cmp      r9d, 1
-       jle      G_M24577_IG38
-						;; size=42 bbWeight=11.98 PerfScore 95.85
+       jle      G_M24577_IG37
+						;; size=32 bbWeight=11.96 PerfScore 71.78
+G_M24577_IG20:
+       mov      gword ptr [rsp+0x90], rbx
+       jmp      G_M24577_IG39
+						;; size=13 bbWeight=11.27 PerfScore 33.81
 G_M24577_IG21:
-       mov      dword ptr [rsp+0x44], ebp
-       jmp      G_M24577_IG41
-						;; size=9 bbWeight=11.36 PerfScore 34.09
-G_M24577_IG22:
        mov      r14d, dword ptr [rdi+0x08]
        cmp      ebp, r14d
        jae      G_M24577_IG71
@@ -665,12 +662,12 @@ G_M24577_IG22:
        cmp      gword ptr [rsi+0x10], 0
        jne      G_M24577_IG75
 						;; size=68 bbWeight=0.05 PerfScore 1.27
-G_M24577_IG23:
+G_M24577_IG22:
        mov      rdx, gword ptr [rsi+0x08]
        test     r12d, r12d
-       jle      SHORT G_M24577_IG26
-						;; size=9 bbWeight=0.05 PerfScore 0.17
-G_M24577_IG24:
+       jle      SHORT G_M24577_IG25
+						;; size=9 bbWeight=0.05 PerfScore 0.16
+G_M24577_IG23:
        lea      ecx, [r12-0x01]
        sar      ecx, 2
        cmp      ecx, dword ptr [rdx+0x08]
@@ -680,9 +677,9 @@ G_M24577_IG24:
        mov      eax, dword ptr [r8]
        mov      r10d, dword ptr [r8+0x04]
        cmp      r13d, r10d
-       jge      SHORT G_M24577_IG29
-						;; size=37 bbWeight=0.04 PerfScore 0.48
-G_M24577_IG25:
+       jge      SHORT G_M24577_IG28
+						;; size=37 bbWeight=0.04 PerfScore 0.47
+G_M24577_IG24:
        cmp      r12d, dword ptr [rdx+0x08]
        jae      G_M24577_IG71
        mov      r8d, r12d
@@ -691,9 +688,9 @@ G_M24577_IG25:
        mov      dword ptr [r8+0x04], r10d
        mov      r12d, ecx
        test     r12d, r12d
-       jg       SHORT G_M24577_IG24
-						;; size=33 bbWeight=0.05 PerfScore 0.45
-G_M24577_IG26:
+       jg       SHORT G_M24577_IG23
+						;; size=33 bbWeight=0.05 PerfScore 0.44
+G_M24577_IG25:
        cmp      r12d, dword ptr [rdx+0x08]
        jae      G_M24577_IG71
        mov      ecx, r12d
@@ -701,267 +698,273 @@ G_M24577_IG26:
        mov      dword ptr [rcx], r15d
        mov      dword ptr [rcx+0x04], r13d
        jmp      G_M24577_IG14
-						;; size=30 bbWeight=0.07 PerfScore 0.65
-G_M24577_IG27:
+						;; size=30 bbWeight=0.05 PerfScore 0.47
+G_M24577_IG26:
        inc      ebp
        cmp      ebp, dword ptr [rbx+0x20]
        jl       G_M24577_IG16
-						;; size=11 bbWeight=94.58 PerfScore 401.96
-G_M24577_IG28:
-       jmp      G_M24577_IG49
+						;; size=11 bbWeight=94.38 PerfScore 401.10
+G_M24577_IG27:
+       jmp      G_M24577_IG58
 						;; size=5 bbWeight=1 PerfScore 2.00
-G_M24577_IG29:
+G_M24577_IG28:
        cmp      r13d, r10d
-       jg       SHORT G_M24577_IG26
+       jg       SHORT G_M24577_IG25
 						;; size=5 bbWeight=0.01 PerfScore 0.01
+G_M24577_IG29:
+       jmp      SHORT G_M24577_IG25
+       align    [0 bytes for IG33]
+						;; size=2 bbWeight=0.01 PerfScore 0.01
 G_M24577_IG30:
-       jmp      SHORT G_M24577_IG26
-       align    [6 bytes for IG33]
-						;; size=8 bbWeight=0.04 PerfScore 0.08
+       mov      qword ptr [rsp+0x28], rbp
+						;; size=5 bbWeight=9.01 PerfScore 9.01
 G_M24577_IG31:
-       mov      dword ptr [rsp+0x40], ebp
        inc      r8d
-       mov      r15d, r8d
-       cmp      r15d, ebp
-       jge      G_M24577_IG43
-						;; size=19 bbWeight=11.36 PerfScore 31.25
+       mov      ebp, r8d
+       cmp      ebp, ebx
+       jge      G_M24577_IG41
+						;; size=14 bbWeight=11.27 PerfScore 19.72
 G_M24577_IG32:
-						;; size=0 bbWeight=5.68 PerfScore 0.00
+       mov      dword ptr [rsp+0x34], r14d
+						;; size=5 bbWeight=5.64 PerfScore 5.64
 G_M24577_IG33:
        cmp      r8d, r12d
        jae      G_M24577_IG71
-       mov      r13d, r8d
-       lea      r13, bword ptr [r10+8*r13+0x10]
-       mov      ebp, dword ptr [r13]
-       mov      r13d, dword ptr [r13+0x04]
-       cmp      r13d, edx
+       mov      edi, r8d
+       lea      rdi, bword ptr [r10+8*rdi+0x10]
+       mov      r14d, dword ptr [rdi]
+       mov      edi, dword ptr [rdi+0x04]
+       cmp      edi, ecx
        jge      G_M24577_IG46
-						;; size=34 bbWeight=29.25 PerfScore 226.72
+						;; size=31 bbWeight=29.00 PerfScore 224.72
 G_M24577_IG34:
-       mov      ecx, ebp
-       mov      edx, r13d
+       mov      edx, r14d
+       mov      ecx, edi
        mov      r11d, r8d
-						;; size=8 bbWeight=24.51 PerfScore 18.39
+						;; size=8 bbWeight=24.30 PerfScore 18.22
 G_M24577_IG35:
-       lea      r8d, [r15+0x01]
-       mov      r15d, r8d
-       mov      ebp, dword ptr [rsp+0x40]
-       cmp      r15d, ebp
+       lea      r8d, [rbp+0x01]
+       mov      ebp, r8d
+       cmp      ebp, ebx
        jl       SHORT G_M24577_IG33
-						;; size=16 bbWeight=29.25 PerfScore 87.76
+						;; size=11 bbWeight=29.00 PerfScore 57.99
 G_M24577_IG36:
-       mov      r13d, dword ptr [rsp+0x38]
-       jmp      SHORT G_M24577_IG43
-						;; size=7 bbWeight=11.36 PerfScore 34.09
+       mov      rdi, gword ptr [rsp+0x20]
+       mov      r14d, dword ptr [rsp+0x34]
+       jmp      SHORT G_M24577_IG41
+						;; size=12 bbWeight=11.27 PerfScore 45.08
 G_M24577_IG37:
-       cmp      eax, r12d
-       jae      G_M24577_IG71
-       mov      eax, eax
-       lea      rax, bword ptr [r10+8*rax+0x10]
-       mov      dword ptr [rax], ecx
-       mov      dword ptr [rax+0x04], edx
-       mov      eax, r11d
-       lea      r11d, [4*rax+0x01]
-       mov      r8d, r11d
-       cmp      r8d, r9d
-       jl       SHORT G_M24577_IG40
-						;; size=40 bbWeight=21.85 PerfScore 147.47
-G_M24577_IG38:
        cmp      eax, r12d
        jae      G_M24577_IG71
        mov      edx, eax
        lea      rdx, bword ptr [r10+8*rdx+0x10]
        mov      dword ptr [rdx], r15d
        mov      dword ptr [rdx+0x04], r13d
-						;; size=23 bbWeight=20.71 PerfScore 93.22
-G_M24577_IG39:
+						;; size=23 bbWeight=15.20 PerfScore 68.38
+G_M24577_IG38:
        inc      dword ptr [rsi+0x24]
-       jmp      G_M24577_IG27
-						;; size=8 bbWeight=11.98 PerfScore 59.91
-G_M24577_IG40:
-       mov      dword ptr [rsp+0x44], ebp
-						;; size=4 bbWeight=10.92 PerfScore 10.92
-G_M24577_IG41:
+       jmp      G_M24577_IG26
+						;; size=8 bbWeight=11.96 PerfScore 59.82
+G_M24577_IG39:
        cmp      r11d, r12d
        jae      G_M24577_IG71
        mov      edx, r11d
-       lea      rdx, bword ptr [r10+8*rdx+0x10]
-       mov      ecx, dword ptr [rdx]
-       mov      edx, dword ptr [rdx+0x04]
-       lea      ebp, [r11+0x04]
-       cmp      ebp, r9d
-       jle      G_M24577_IG31
-						;; size=35 bbWeight=11.36 PerfScore 93.76
-G_M24577_IG42:
-       mov      ebp, r9d
+       lea      rcx, bword ptr [r10+8*rdx+0x10]
+       mov      edx, dword ptr [rcx]
+       mov      ecx, dword ptr [rcx+0x04]
+       lea      ebx, [r11+0x04]
+       cmp      ebx, r9d
+       jle      G_M24577_IG30
+						;; size=35 bbWeight=11.27 PerfScore 92.99
+G_M24577_IG40:
+       mov      ebx, r9d
+       mov      qword ptr [rsp+0x28], rbp
        jmp      G_M24577_IG31
-						;; size=8 bbWeight=2.27 PerfScore 5.11
+       align    [0 bytes for IG50]
+						;; size=13 bbWeight=2.26 PerfScore 7.34
+G_M24577_IG41:
+       cmp      r13d, ecx
+       mov      rbx, gword ptr [rsp+0x90]
+       mov      rbp, qword ptr [rsp+0x28]
+       jl       SHORT G_M24577_IG37
+						;; size=18 bbWeight=11.27 PerfScore 36.63
+G_M24577_IG42:
+       cmp      r13d, ecx
+       jle      SHORT G_M24577_IG37
+						;; size=5 bbWeight=1.83 PerfScore 2.28
 G_M24577_IG43:
-       cmp      r13d, edx
-       mov      ebp, dword ptr [rsp+0x44]
-       mov      r15d, dword ptr [rsp+0x3C]
-       jl       SHORT G_M24577_IG38
-						;; size=14 bbWeight=11.36 PerfScore 36.93
+       cmp      eax, r12d
+       jae      G_M24577_IG71
+       mov      eax, eax
+       lea      rax, bword ptr [r10+8*rax+0x10]
+       mov      dword ptr [rax], edx
+       mov      dword ptr [rax+0x04], ecx
+       mov      eax, r11d
+       lea      r11d, [4*rax+0x01]
+       mov      r8d, r11d
+       cmp      r8d, r9d
+       jl       SHORT G_M24577_IG45
+						;; size=40 bbWeight=21.74 PerfScore 146.76
 G_M24577_IG44:
-       cmp      r13d, edx
-       jle      SHORT G_M24577_IG38
-						;; size=5 bbWeight=1.84 PerfScore 2.30
-G_M24577_IG45:
        jmp      G_M24577_IG37
-       align    [7 bytes for IG56]
-						;; size=12 bbWeight=0.17 PerfScore 0.35
+						;; size=5 bbWeight=15.20 PerfScore 30.39
+G_M24577_IG45:
+       mov      gword ptr [rsp+0x90], rbx
+       jmp      SHORT G_M24577_IG39
+						;; size=10 bbWeight=10.87 PerfScore 32.61
 G_M24577_IG46:
-       cmp      r13d, edx
-       jle      G_M24577_IG35
-						;; size=9 bbWeight=4.74 PerfScore 5.92
+       cmp      edi, ecx
+       jg       G_M24577_IG35
+						;; size=8 bbWeight=4.70 PerfScore 5.87
 G_M24577_IG47:
        jmp      G_M24577_IG35
-						;; size=5 bbWeight=0.45 PerfScore 0.90
+						;; size=5 bbWeight=4.25 PerfScore 8.51
 G_M24577_IG48:
-       mov      r8d, ecx
-       jmp      G_M24577_IG55
-						;; size=8 bbWeight=3.12 PerfScore 7.02
-G_M24577_IG49:
-       xor      r12d, r12d
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M24577_IG50:
-       mov      eax, dword ptr [rsi+0x20]
-       test     eax, eax
-       je       G_M24577_IG77
-						;; size=11 bbWeight=5.11 PerfScore 16.60
-G_M24577_IG51:
-       mov      r10, gword ptr [rsi+0x08]
-       mov      rdx, r10
-       mov      r13d, dword ptr [rdx+0x08]
-       test     r13d, r13d
-       je       G_M24577_IG71
-       dec      eax
-       mov      edx, eax
-       mov      dword ptr [rsi+0x20], edx
-       inc      dword ptr [rsi+0x24]
-       test     edx, edx
-       jle      G_M24577_IG64
-						;; size=38 bbWeight=5.11 PerfScore 57.47
-G_M24577_IG52:
-       mov      rcx, r10
-       cmp      edx, r13d
-       jae      G_M24577_IG71
-       mov      edx, edx
-       lea      rdx, bword ptr [rcx+8*rdx+0x10]
-       mov      ebp, dword ptr [rdx]
-       mov      dword ptr [rsp+0x34], ebp
-       mov      r15d, dword ptr [rdx+0x04]
-       cmp      gword ptr [rsi+0x10], 0
-       jne      G_M24577_IG69
-       xor      ebx, ebx
-       mov      edi, 1
-       mov      edx, 1
-       cmp      eax, 1
-       jle      G_M24577_IG63
-						;; size=61 bbWeight=4.11 PerfScore 56.51
-G_M24577_IG53:
-       cmp      edi, r13d
-       jae      G_M24577_IG71
-       mov      ecx, edi
-       lea      rcx, bword ptr [r10+8*rcx+0x10]
-       mov      r14d, dword ptr [rcx]
-       mov      r9d, dword ptr [rcx+0x04]
-       lea      ecx, [rdi+0x04]
-       cmp      ecx, eax
-       jle      G_M24577_IG48
-						;; size=34 bbWeight=3.90 PerfScore 32.16
-G_M24577_IG54:
-       mov      r8d, eax
-						;; size=3 bbWeight=0.78 PerfScore 0.19
-G_M24577_IG55:
-       inc      edx
-       mov      r11d, edx
-       cmp      r11d, r8d
-       jge      G_M24577_IG66
-						;; size=14 bbWeight=3.90 PerfScore 6.82
-G_M24577_IG56:
-       cmp      edx, r13d
-       jae      G_M24577_IG71
-       mov      ecx, edx
-       lea      rcx, bword ptr [r10+8*rcx+0x10]
-       mov      ebp, dword ptr [rcx]
-       mov      ecx, dword ptr [rcx+0x04]
-       cmp      ecx, r9d
-       jge      SHORT G_M24577_IG60
-						;; size=26 bbWeight=10.03 PerfScore 77.76
-G_M24577_IG57:
        mov      r14d, ebp
-       mov      r9d, ecx
-       mov      edi, edx
-						;; size=8 bbWeight=8.41 PerfScore 6.31
-G_M24577_IG58:
-       lea      edx, [r11+0x01]
-       mov      r11d, edx
-       cmp      r11d, r8d
-       jl       SHORT G_M24577_IG56
-						;; size=12 bbWeight=10.03 PerfScore 20.07
-G_M24577_IG59:
-       jmp      SHORT G_M24577_IG66
-						;; size=2 bbWeight=3.90 PerfScore 7.80
-G_M24577_IG60:
-       cmp      ecx, r9d
-       jg       SHORT G_M24577_IG58
-						;; size=5 bbWeight=1.63 PerfScore 2.03
-G_M24577_IG61:
-       jmp      SHORT G_M24577_IG58
-						;; size=2 bbWeight=10.03 PerfScore 20.07
-G_M24577_IG62:
-       cmp      ebx, r13d
+						;; size=3 bbWeight=3.08 PerfScore 0.77
+G_M24577_IG49:
+       inc      r13d
+       mov      ebp, r13d
+       cmp      ebp, r14d
+       jge      G_M24577_IG65
+						;; size=15 bbWeight=3.85 PerfScore 6.73
+G_M24577_IG50:
+       cmp      r13d, r8d
        jae      G_M24577_IG71
-       mov      edx, ebx
-       lea      rdx, bword ptr [r10+8*rdx+0x10]
-       mov      dword ptr [rdx], r14d
-       mov      dword ptr [rdx+0x04], r9d
-       mov      ebx, edi
-       lea      edi, [4*rbx+0x01]
-       mov      r11d, edi
-       cmp      r11d, eax
-       mov      edx, r11d
-       jl       G_M24577_IG53
-						;; size=47 bbWeight=7.49 PerfScore 52.46
-G_M24577_IG63:
-       cmp      ebx, r13d
-       jae      SHORT G_M24577_IG71
-       mov      r9d, ebx
-       lea      r10, bword ptr [r10+8*r9+0x10]
-       mov      ebp, dword ptr [rsp+0x34]
-       mov      dword ptr [r10], ebp
-       mov      dword ptr [r10+0x04], r15d
-						;; size=24 bbWeight=7.11 PerfScore 39.08
-G_M24577_IG64:
+       mov      r15d, r13d
+       lea      r15, bword ptr [rdx+8*r15+0x10]
+       mov      r10d, dword ptr [r15]
+       mov      r15d, dword ptr [r15+0x04]
+       cmp      r15d, edi
+       jge      G_M24577_IG68
+						;; size=33 bbWeight=9.90 PerfScore 76.69
+G_M24577_IG51:
+       mov      ebx, r10d
+       mov      edi, r15d
+       mov      r11d, r13d
+						;; size=9 bbWeight=8.29 PerfScore 6.22
+G_M24577_IG52:
+       lea      r13d, [rbp+0x01]
+       mov      ebp, r13d
+       cmp      ebp, r14d
+       jl       SHORT G_M24577_IG50
+						;; size=12 bbWeight=9.90 PerfScore 19.79
+G_M24577_IG53:
+       jmp      G_M24577_IG65
+						;; size=5 bbWeight=3.85 PerfScore 7.69
+G_M24577_IG54:
+       cmp      r9d, r8d
+       jae      G_M24577_IG71
+       mov      r9d, r9d
+       lea      r9, bword ptr [rdx+8*r9+0x10]
+       mov      dword ptr [r9], ebx
+       mov      dword ptr [r9+0x04], r15d
+       mov      r9d, r11d
+       lea      r11d, [4*r9+0x01]
+       mov      ebp, r11d
+       cmp      ebp, ecx
+       mov      r13d, ebp
+       jl       G_M24577_IG62
+						;; size=49 bbWeight=7.42 PerfScore 51.94
+G_M24577_IG55:
+       cmp      r9d, r8d
+       jae      G_M24577_IG71
+       mov      r11d, r9d
+       lea      r8, bword ptr [rdx+8*r11+0x10]
+       mov      r10d, dword ptr [rsp+0x44]
+       mov      dword ptr [r8], r10d
+       mov      dword ptr [r8+0x04], eax
+						;; size=29 bbWeight=5.19 PerfScore 28.52
+G_M24577_IG56:
        inc      r12d
        cmp      r12d, 5
-       jl       G_M24577_IG50
-						;; size=13 bbWeight=5.11 PerfScore 7.66
-G_M24577_IG65:
-       jmp      SHORT G_M24577_IG70
-						;; size=2 bbWeight=1 PerfScore 2.00
-G_M24577_IG66:
-       cmp      r15d, r9d
-       jl       SHORT G_M24577_IG63
-						;; size=5 bbWeight=3.90 PerfScore 4.87
-G_M24577_IG67:
-       cmp      r15d, r9d
-       jle      SHORT G_M24577_IG63
-						;; size=5 bbWeight=0.63 PerfScore 0.79
-G_M24577_IG68:
-       jmp      SHORT G_M24577_IG62
-						;; size=2 bbWeight=0.06 PerfScore 0.12
-G_M24577_IG69:
-       mov      ebp, dword ptr [rsp+0x34]
-       mov      dword ptr [rsp+0x28], ebp
-       mov      dword ptr [rsp+0x2C], r15d
-       mov      rdx, qword ptr [rsp+0x28]
+       jl       SHORT G_M24577_IG59
+						;; size=9 bbWeight=5.05 PerfScore 7.58
+G_M24577_IG57:
+       jmp      G_M24577_IG70
+						;; size=5 bbWeight=1 PerfScore 2.00
+G_M24577_IG58:
+       xor      r12d, r12d
+						;; size=3 bbWeight=1 PerfScore 0.25
+G_M24577_IG59:
+       mov      ecx, dword ptr [rsi+0x20]
+       test     ecx, ecx
+       je       G_M24577_IG77
+						;; size=11 bbWeight=5.05 PerfScore 16.43
+G_M24577_IG60:
+       mov      rdx, gword ptr [rsi+0x08]
+       mov      r8, rdx
+       mov      r8d, dword ptr [r8+0x08]
+       test     r8d, r8d
+       je       G_M24577_IG71
+       dec      ecx
+       mov      eax, ecx
+       mov      dword ptr [rsi+0x20], eax
+       inc      dword ptr [rsi+0x24]
+       test     eax, eax
+       jle      SHORT G_M24577_IG56
+						;; size=34 bbWeight=5.05 PerfScore 56.86
+G_M24577_IG61:
+       mov      r10, rdx
+       cmp      eax, r8d
+       jae      G_M24577_IG71
+       mov      eax, eax
+       lea      rax, bword ptr [r10+8*rax+0x10]
+       mov      r10d, dword ptr [rax]
+       mov      dword ptr [rsp+0x44], r10d
+       mov      eax, dword ptr [rax+0x04]
+       cmp      gword ptr [rsi+0x10], 0
+       jne      SHORT G_M24577_IG64
+       xor      r9d, r9d
+       mov      r11d, 1
+       mov      r13d, 1
+       cmp      ecx, 1
+       jle      G_M24577_IG55
+						;; size=61 bbWeight=4.08 PerfScore 56.14
+G_M24577_IG62:
+       cmp      r11d, r8d
+       jae      G_M24577_IG71
+       mov      ebx, r11d
+       lea      rdi, bword ptr [rdx+8*rbx+0x10]
+       mov      ebx, dword ptr [rdi]
+       mov      edi, dword ptr [rdi+0x04]
+       lea      ebp, [r11+0x04]
+       cmp      ebp, ecx
+       jle      G_M24577_IG48
+						;; size=34 bbWeight=3.85 PerfScore 31.73
+G_M24577_IG63:
+       mov      r14d, ecx
+       jmp      G_M24577_IG49
+						;; size=8 bbWeight=0.77 PerfScore 1.73
+G_M24577_IG64:
+       mov      r10d, dword ptr [rsp+0x44]
+       mov      dword ptr [rsp+0x38], r10d
+       mov      dword ptr [rsp+0x3C], eax
+       mov      rdx, qword ptr [rsp+0x38]
        mov      rcx, rsi
        xor      r8d, r8d
        call     [System.Collections.Generic.PriorityQueue`2[int,int]:MoveDownCustomComparer(System.ValueTuple`2[int,int],int):this]
-       jmp      SHORT G_M24577_IG64
-						;; size=32 bbWeight=5.11 PerfScore 48.53
+       jmp      G_M24577_IG56
+						;; size=36 bbWeight=5.05 PerfScore 48.01
+G_M24577_IG65:
+       cmp      eax, edi
+       jl       G_M24577_IG55
+						;; size=8 bbWeight=3.85 PerfScore 4.81
+G_M24577_IG66:
+       cmp      eax, edi
+       jle      G_M24577_IG55
+						;; size=8 bbWeight=0.62 PerfScore 0.78
+G_M24577_IG67:
+       mov      r15d, edi
+       jmp      G_M24577_IG54
+						;; size=8 bbWeight=0.06 PerfScore 0.13
+G_M24577_IG68:
+       cmp      r15d, edi
+       jg       G_M24577_IG52
+						;; size=9 bbWeight=1.60 PerfScore 2.00
+G_M24577_IG69:
+       jmp      G_M24577_IG52
+						;; size=5 bbWeight=1.45 PerfScore 2.90
 G_M24577_IG70:
        add      rsp, 72
        pop      rbx
@@ -989,9 +992,9 @@ G_M24577_IG72:
 G_M24577_IG73:
        mov      eax, r15d
        mov      r10d, r13d
-       mov      dword ptr [rsp+0x28], eax
-       mov      dword ptr [rsp+0x2C], r10d
-       mov      rdx, qword ptr [rsp+0x28]
+       mov      dword ptr [rsp+0x38], eax
+       mov      dword ptr [rsp+0x3C], r10d
+       mov      rdx, qword ptr [rsp+0x38]
        mov      rcx, rsi
        mov      r8d, r12d
        call     [System.Collections.Generic.PriorityQueue`2[int,int]:MoveUpCustomComparer(System.ValueTuple`2[int,int],int):this]
@@ -1004,14 +1007,14 @@ G_M24577_IG74:
        lea      edx, [r12+0x01]
        mov      dword ptr [rsi+0x20], edx
        cmp      gword ptr [rsi+0x10], 0
-       je       G_M24577_IG23
+       je       G_M24577_IG22
 						;; size=33 bbWeight=0 PerfScore 0.00
 G_M24577_IG75:
        mov      eax, r15d
        mov      r10d, r13d
-       mov      dword ptr [rsp+0x28], eax
-       mov      dword ptr [rsp+0x2C], r10d
-       mov      rdx, qword ptr [rsp+0x28]
+       mov      dword ptr [rsp+0x38], eax
+       mov      dword ptr [rsp+0x3C], r10d
+       mov      rdx, qword ptr [rsp+0x38]
        mov      rcx, rsi
        mov      r8d, r12d
        call     [System.Collections.Generic.PriorityQueue`2[int,int]:MoveUpCustomComparer(System.ValueTuple`2[int,int],int):this]
@@ -1023,16 +1026,16 @@ G_M24577_IG76:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        test     eax, eax
-       jle      G_M24577_IG27
+       jle      G_M24577_IG26
        mov      edx, r15d
        mov      ecx, r13d
-       mov      dword ptr [rsp+0x28], edx
-       mov      dword ptr [rsp+0x2C], ecx
-       mov      rdx, qword ptr [rsp+0x28]
+       mov      dword ptr [rsp+0x38], edx
+       mov      dword ptr [rsp+0x3C], ecx
+       mov      rdx, qword ptr [rsp+0x38]
        mov      rcx, rsi
        xor      r8d, r8d
        call     [System.Collections.Generic.PriorityQueue`2[int,int]:MoveDownCustomComparer(System.ValueTuple`2[int,int],int):this]
-       jmp      G_M24577_IG39
+       jmp      G_M24577_IG38
 						;; size=64 bbWeight=0 PerfScore 0.00
 G_M24577_IG77:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
@@ -1047,6 +1050,6 @@ G_M24577_IG77:
        int3     
 						;; size=45 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1480, prolog size 19, PerfScore 4680.01, instruction count 393, allocated bytes for code 1480 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1)
+; Total bytes of code 1517, prolog size 19, PerfScore 4582.67, instruction count 395, allocated bytes for code 1520 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Tests.Perf_PriorityQueue<Int32, Int32>.K_Max_Elements(Size: 1000)``

Hot functions:

- (89.74%) ``System.Collections.Tests.Perf_PriorityQueue`2.K_Max_Elements`` (Tier-1)
  - **Has diffs**
- (9.60%) ``System.Collections.Generic.PriorityQueue`2.MoveDownDefaultComparer`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.Tests.Perf_PriorityQueue`2[System.Int32,System.Int32].K_Max_Elements()``

```diff
 ;
 ;  V00 this         [V00,T15] (  4,  401.70)     ref  ->  rbx         this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
 ;  V01 loc0         [V01,T01] (  8, 7692.73)     ref  ->  rsi         class-hnd <System.Collections.Generic.PriorityQueue`2[int,int]>
-;  V02 loc1         [V02,T16] (  2,  199.80)     ref  ->  rbp         class-hnd exact <<unknown class>>
+;  V02 loc1         [V02,T16] (  2,  199.80)     ref  ->  rdi         class-hnd exact <<unknown class>>
 ;* V03 loc2         [V03    ] (  0,    0   )     int  ->  zero-ref   
 ;* V04 loc3         [V04    ] (  0,    0   )     int  ->  zero-ref   
 ;* V05 loc4         [V05    ] (  0,    0   )     int  ->  zero-ref   
-;  V06 loc5         [V06,T10] (  6, 1398.70)     int  ->  rdi        
+;  V06 loc5         [V06,T18] (  2,    0.20)     int  ->  rcx        
 ;* V07 loc6         [V07    ] (  0,    0   )     int  ->  zero-ref   
 ;* V08 loc7         [V08    ] (  0,    0   )     int  ->  zero-ref   
 ;  V09 loc8         [V09,T17] (  4,    1.44)     int  ->  rbx        
@@ -272,6 +272,7 @@ G_M24577_IG16:
 ;  V83 tmp73        [V83,T09] (  3, 2397.59)   byref  ->  rcx         "BlockOp address local"
 ;  V84 tmp74        [V84,T00] (  6,21578.33)  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
 ;  V85 cse0         [V85,T05] (  3, 3995.99)     ref  ->  rcx         "CSE #01: aggressive"
+;  V86 rat0         [V86,T10] (  6, 1398.70)    long  ->  rbp         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -284,43 +285,45 @@ G_M24577_IG01:
        mov      qword ptr [rsp+0xD8], rbx
        mov      rbx, gword ptr [rsp+0x110]
        mov      rsi, gword ptr [rsp+0xC0]
-       mov      rbp, gword ptr [rsp+0xB8]
-       mov      edi, dword ptr [rsp+0xA8]
+       mov      rdi, gword ptr [rsp+0xB8]
+       mov      ecx, dword ptr [rsp+0xA8]
 						;; size=75 bbWeight=0.10 PerfScore 1.33
 G_M24577_IG02:
-       cmp      edi, dword ptr [rbx+0x20]
-       jge      G_M24577_IG11
+       cmp      ecx, dword ptr [rbx+0x20]
+       jge      G_M24577_IG12
 						;; size=9 bbWeight=0.10 PerfScore 0.40
 G_M24577_IG03:
-       cmp      edi, dword ptr [rbp+0x08]
-       jae      G_M24577_IG14
-       mov      ecx, edi
-       lea      rcx, bword ptr [rbp+8*rcx+0x10]
+       mov      ebp, ecx
+						;; size=2 bbWeight=0.10 PerfScore 0.03
+G_M24577_IG04:
+       cmp      ebp, dword ptr [rdi+0x08]
+       jae      G_M24577_IG15
+       lea      rcx, bword ptr [rdi+8*rbp+0x10]
        mov      r14d, dword ptr [rcx]
        mov      r15d, dword ptr [rcx+0x04]
        cmp      dword ptr [rsi+0x20], 0
-       je       G_M24577_IG10
-						;; size=33 bbWeight=99.90 PerfScore 1423.57
-G_M24577_IG04:
+       je       G_M24577_IG11
+						;; size=31 bbWeight=99.90 PerfScore 1298.70
+G_M24577_IG05:
        mov      rcx, gword ptr [rsi+0x08]
        cmp      dword ptr [rcx+0x08], 0
-       jbe      G_M24577_IG14
+       jbe      G_M24577_IG15
        add      rcx, 16
        cmp      dword ptr [rcx], ecx
        mov      r8d, dword ptr [rcx+0x04]
        mov      rcx, gword ptr [rsi+0x10]
        test     rcx, rcx
-       jne      SHORT G_M24577_IG09
+       jne      SHORT G_M24577_IG10
 						;; size=33 bbWeight=399.60 PerfScore 5794.18
-G_M24577_IG05:
-       cmp      r15d, r8d
-       jl       SHORT G_M24577_IG10
-						;; size=5 bbWeight=99.90 PerfScore 124.87
 G_M24577_IG06:
        cmp      r15d, r8d
-       jle      SHORT G_M24577_IG10
-						;; size=5 bbWeight=16.19 PerfScore 20.23
+       jl       SHORT G_M24577_IG11
+						;; size=5 bbWeight=99.90 PerfScore 124.87
 G_M24577_IG07:
+       cmp      r15d, r8d
+       jle      SHORT G_M24577_IG11
+						;; size=5 bbWeight=16.19 PerfScore 20.23
+G_M24577_IG08:
        mov      edx, r14d
        mov      ecx, r15d
        mov      dword ptr [rsp+0x20], edx
@@ -330,41 +333,41 @@ G_M24577_IG07:
        xor      r8d, r8d
        call     [<unknown method>]
 						;; size=31 bbWeight=399.60 PerfScore 2797.19
-G_M24577_IG08:
-       inc      dword ptr [rsi+0x24]
-       jmp      SHORT G_M24577_IG10
-						;; size=5 bbWeight=1598.39 PerfScore 7991.97
 G_M24577_IG09:
+       inc      dword ptr [rsi+0x24]
+       jmp      SHORT G_M24577_IG11
+						;; size=5 bbWeight=1598.39 PerfScore 7991.97
+G_M24577_IG10:
        mov      edx, r15d
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        test     eax, eax
-       jle      SHORT G_M24577_IG10
+       jle      SHORT G_M24577_IG11
        mov      dword ptr [rsp+0x20], r14d
        mov      dword ptr [rsp+0x24], r15d
        mov      rdx, qword ptr [rsp+0x20]
        mov      rcx, rsi
        xor      r8d, r8d
        call     [<unknown method>]
-       jmp      SHORT G_M24577_IG08
+       jmp      SHORT G_M24577_IG09
 						;; size=49 bbWeight=3196.79 PerfScore 42357.46
-G_M24577_IG10:
-       inc      edi
-       cmp      edi, dword ptr [rbx+0x20]
-       jl       G_M24577_IG03
-						;; size=11 bbWeight=399.60 PerfScore 1698.29
 G_M24577_IG11:
+       inc      ebp
+       cmp      ebp, dword ptr [rbx+0x20]
+       jl       G_M24577_IG04
+						;; size=11 bbWeight=399.60 PerfScore 1698.29
+G_M24577_IG12:
        xor      ebx, ebx
 						;; size=2 bbWeight=0.09 PerfScore 0.02
-G_M24577_IG12:
+G_M24577_IG13:
        mov      rcx, rsi
        cmp      dword ptr [rcx], ecx
        call     [System.Collections.Generic.PriorityQueue`2[int,int]:Dequeue():int:this]
        inc      ebx
        cmp      ebx, 5
-       jl       SHORT G_M24577_IG12
+       jl       SHORT G_M24577_IG13
 						;; size=18 bbWeight=0.45 PerfScore 3.50
-G_M24577_IG13:
+G_M24577_IG14:
        add      rsp, 216
        pop      rbx
        pop      rsi
@@ -374,12 +377,12 @@ G_M24577_IG13:
        pop      rbp
        ret      
 						;; size=16 bbWeight=0.09 PerfScore 0.38
-G_M24577_IG14:
+G_M24577_IG15:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 298, prolog size 75, PerfScore 62213.42, instruction count 75, allocated bytes for code 298 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1-OSR)
+; Total bytes of code 298, prolog size 75, PerfScore 62088.57, instruction count 75, allocated bytes for code 298 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Instrumented Tier0)
@@ -566,20 +569,20 @@ G_M24577_IG16:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 137052.4
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 132833.5
 ; 5 inlinees with PGO data; 7 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T09] (  4,102   )     ref  ->  rbx         this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
-;  V01 loc0         [V01,T04] (  9,310.07)     ref  ->  rdi         class-hnd <System.Collections.Generic.PriorityQueue`2[int,int]>
-;  V02 loc1         [V02,T07] (  2,200.00)     ref  ->  rbp         class-hnd exact <<unknown class>>
+;  V00 this         [V00,T08] (  4,102   )     ref  ->  rbx         this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
+;  V01 loc0         [V01,T04] (  9,310.90)     ref  ->  rsi         class-hnd <System.Collections.Generic.PriorityQueue`2[int,int]>
+;  V02 loc1         [V02,T07] (  2,200.00)     ref  ->  rdi         class-hnd exact <<unknown class>>
 ;* V03 loc2         [V03    ] (  0,  0   )     int  ->  zero-ref   
 ;* V04 loc3         [V04    ] (  0,  0   )     int  ->  zero-ref   
 ;* V05 loc4         [V05    ] (  0,  0   )     int  ->  zero-ref   
-;  V06 loc5         [V06,T03] (  6,500.00)     int  ->  rsi        
+;  V06 loc5         [V06,T15] (  2,  0.00)     int  ->  rdx        
 ;* V07 loc6         [V07    ] (  0,  0   )     int  ->  zero-ref   
 ;* V08 loc7         [V08    ] (  0,  0   )     int  ->  zero-ref   
-;  V09 loc8         [V09,T14] (  4,  0.00)     int  ->  r14        
+;  V09 loc8         [V09,T14] (  4,  0.00)     int  ->  rbx        
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )  struct ( 8) zero-ref    "dup spill" <System.ValueTuple`2[int,int]>
 ;* V12 tmp2         [V12    ] (  0,  0   )  struct ( 8) zero-ref    "dup spill" <System.ValueTuple`2[int,int]>
@@ -602,11 +605,11 @@ G_M24577_IG16:
 ;* V29 tmp19        [V29    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V30 tmp20        [V30    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V31 tmp21        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;* V32 tmp22        [V32,T08] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V32 tmp22        [V32,T10] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V33 tmp23        [V33    ] (  0,  0   )     int  ->  zero-ref    "field V11.Item1 (fldOffset=0x0)" P-INDEP
 ;* V34 tmp24        [V34    ] (  0,  0   )     int  ->  zero-ref    "field V11.Item2 (fldOffset=0x4)" P-INDEP
-;  V35 tmp25        [V35,T10] (  3,103.39)     int  ->  r14         "field V12.Item1 (fldOffset=0x0)" P-INDEP
-;  V36 tmp26        [V36,T05] (  6,219.54)     int  ->  r15         "field V12.Item2 (fldOffset=0x4)" P-INDEP
+;  V35 tmp25        [V35,T09] (  3,103.42)     int  ->  r14         "field V12.Item1 (fldOffset=0x0)" P-INDEP
+;  V36 tmp26        [V36,T05] (  6,219.99)     int  ->  r15         "field V12.Item2 (fldOffset=0x4)" P-INDEP
 ;* V37 tmp27        [V37    ] (  0,  0   )     int  ->  zero-ref    "field V14.Item1 (fldOffset=0x0)" P-INDEP
 ;* V38 tmp28        [V38    ] (  0,  0   )     int  ->  zero-ref    "field V14.Item2 (fldOffset=0x4)" P-INDEP
 ;* V39 tmp29        [V39    ] (  0,  0   )     int  ->  zero-ref    "field V15.Item1 (fldOffset=0x0)" P-INDEP
@@ -616,19 +619,20 @@ G_M24577_IG16:
 ;* V43 tmp33        [V43    ] (  0,  0   )     int  ->  zero-ref    "field V20.Item1 (fldOffset=0x0)" P-INDEP
 ;* V44 tmp34        [V44    ] (  0,  0   )     int  ->  zero-ref    "field V20.Item2 (fldOffset=0x4)" P-INDEP
 ;* V45 tmp35        [V45    ] (  0,  0   )     int  ->  zero-ref    "field V26.Item1 (fldOffset=0x0)" P-INDEP
-;  V46 tmp36        [V46,T06] (  4,216.11)     int  ->   r8         "field V26.Item2 (fldOffset=0x4)" P-INDEP
-;  V47 tmp37        [V47,T15] (  2,  0   )     int  ->  rdx         "field V27.Item1 (fldOffset=0x0)" P-INDEP
-;  V48 tmp38        [V48,T16] (  2,  0   )     int  ->  rcx         "field V27.Item2 (fldOffset=0x4)" P-INDEP
-;  V49 tmp39        [V49,T12] (  2,  6.77)     int  ->  r14         "field V28.Item1 (fldOffset=0x0)" P-INDEP
-;  V50 tmp40        [V50,T13] (  2,  6.77)     int  ->  r15         "field V28.Item2 (fldOffset=0x4)" P-INDEP
+;  V46 tmp36        [V46,T06] (  4,216.88)     int  ->   r8         "field V26.Item2 (fldOffset=0x4)" P-INDEP
+;  V47 tmp37        [V47,T16] (  2,  0   )     int  ->  rdx         "field V27.Item1 (fldOffset=0x0)" P-INDEP
+;  V48 tmp38        [V48,T17] (  2,  0   )     int  ->  rcx         "field V27.Item2 (fldOffset=0x4)" P-INDEP
+;  V49 tmp39        [V49,T12] (  2,  6.85)     int  ->  r14         "field V28.Item1 (fldOffset=0x0)" P-INDEP
+;  V50 tmp40        [V50,T13] (  2,  6.85)     int  ->  r15         "field V28.Item2 (fldOffset=0x4)" P-INDEP
 ;* V51 tmp41        [V51    ] (  0,  0   )   byref  ->  zero-ref    "BlockOp address local"
-;  V52 tmp42        [V52,T11] (  6, 20.31)  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
+;  V52 tmp42        [V52,T11] (  6, 20.55)  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
 ;* V53 tmp43        [V53    ] (  0,  0   )   byref  ->  zero-ref    "BlockOp address local"
 ;* V54 tmp44        [V54    ] (  0,  0   )   byref  ->  zero-ref    "BlockOp address local"
 ;* V55 tmp45        [V55    ] (  0,  0   )   byref  ->  zero-ref    "BlockOp address local"
-;  V56 tmp46        [V56,T00] (  3,600.00)   byref  ->  rcx         "BlockOp address local"
-;  V57 tmp47        [V57,T01] (  3,599.74)     ref  ->  rcx         "arr expr"
-;  V58 tmp48        [V58,T02] (  3,599.74)   byref  ->  rcx         "BlockOp address local"
+;  V56 tmp46        [V56,T02] (  3,600.00)   byref  ->  rdx         "BlockOp address local"
+;  V57 tmp47        [V57,T00] (  3,601.88)     ref  ->  rdx         "arr expr"
+;  V58 tmp48        [V58,T01] (  3,601.88)   byref  ->  rdx         "BlockOp address local"
+;  V59 rat0         [V59,T03] (  6,500.00)    long  ->  rbp         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -640,68 +644,72 @@ G_M24577_IG01:
        mov      qword ptr [rsp+0xE0], rsi
        mov      qword ptr [rsp+0xD8], rbx
        mov      rbx, gword ptr [rsp+0x110]
-       mov      rdi, gword ptr [rsp+0xC0]
-       mov      rbp, gword ptr [rsp+0xB8]
-       mov      esi, dword ptr [rsp+0xA8]
+       mov      rsi, gword ptr [rsp+0xC0]
+       mov      rdi, gword ptr [rsp+0xB8]
+       mov      edx, dword ptr [rsp+0xA8]
 						;; size=75 bbWeight=0.00 PerfScore 0.00
 G_M24577_IG02:
-       cmp      esi, dword ptr [rbx+0x20]
-       jge      SHORT G_M24577_IG09
+       cmp      edx, dword ptr [rbx+0x20]
+       jge      SHORT G_M24577_IG11
 						;; size=5 bbWeight=0.00 PerfScore 0.00
 G_M24577_IG03:
-       cmp      esi, dword ptr [rbp+0x08]
-       jae      G_M24577_IG12
-       mov      ecx, esi
-       lea      rcx, bword ptr [rbp+8*rcx+0x10]
-       mov      r14d, dword ptr [rcx]
-       mov      r15d, dword ptr [rcx+0x04]
-       cmp      dword ptr [rdi+0x20], 0
-       je       SHORT G_M24577_IG08
-						;; size=29 bbWeight=100.00 PerfScore 1425.00
+       mov      ebp, edx
+						;; size=2 bbWeight=0.00 PerfScore 0.00
 G_M24577_IG04:
-       mov      rcx, gword ptr [rdi+0x08]
-       cmp      dword ptr [rcx+0x08], 0
-       jbe      SHORT G_M24577_IG12
-       add      rcx, 16
-       cmp      dword ptr [rcx], ecx
-       mov      r8d, dword ptr [rcx+0x04]
-       cmp      gword ptr [rdi+0x10], 0
-       jne      SHORT G_M24577_IG13
-       cmp      r15d, r8d
-       jl       SHORT G_M24577_IG08
-						;; size=32 bbWeight=99.96 PerfScore 1649.28
+       cmp      ebp, dword ptr [rdi+0x08]
+       jae      G_M24577_IG14
+       lea      rdx, bword ptr [rdi+8*rbp+0x10]
+       mov      r14d, dword ptr [rdx]
+       mov      r15d, dword ptr [rdx+0x04]
+       cmp      dword ptr [rsi+0x20], 0
+       je       SHORT G_M24577_IG10
+						;; size=27 bbWeight=100.00 PerfScore 1300.00
 G_M24577_IG05:
-       cmp      r15d, r8d
-       jle      SHORT G_M24577_IG08
-						;; size=5 bbWeight=16.19 PerfScore 20.24
+       mov      rdx, gword ptr [rsi+0x08]
+       cmp      dword ptr [rdx+0x08], 0
+       jbe      SHORT G_M24577_IG14
+       add      rdx, 16
+       cmp      dword ptr [rdx], edx
+       mov      r8d, dword ptr [rdx+0x04]
+       cmp      gword ptr [rsi+0x10], 0
+       jne      SHORT G_M24577_IG15
+						;; size=27 bbWeight=100.31 PerfScore 1529.78
 G_M24577_IG06:
+       cmp      r15d, r8d
+       jl       SHORT G_M24577_IG10
+						;; size=5 bbWeight=100.31 PerfScore 125.39
+G_M24577_IG07:
+       cmp      r15d, r8d
+       jle      SHORT G_M24577_IG10
+						;; size=5 bbWeight=16.25 PerfScore 20.32
+G_M24577_IG08:
        mov      dword ptr [rsp+0x20], r14d
        mov      dword ptr [rsp+0x24], r15d
        mov      rdx, qword ptr [rsp+0x20]
-       mov      rcx, rdi
+       mov      rcx, rsi
        xor      r8d, r8d
        call     [<unknown method>]
-						;; size=27 bbWeight=3.39 PerfScore 22.01
-G_M24577_IG07:
-       inc      dword ptr [rdi+0x24]
-						;; size=3 bbWeight=3.39 PerfScore 10.16
-G_M24577_IG08:
-       inc      esi
-       cmp      esi, dword ptr [rbx+0x20]
-       jl       SHORT G_M24577_IG03
-						;; size=7 bbWeight=100.00 PerfScore 425.00
+						;; size=27 bbWeight=3.43 PerfScore 22.26
 G_M24577_IG09:
-       xor      r14d, r14d
-						;; size=3 bbWeight=0.00 PerfScore 0.00
+       inc      dword ptr [rsi+0x24]
+						;; size=3 bbWeight=3.43 PerfScore 10.28
 G_M24577_IG10:
-       mov      rcx, rdi
+       inc      ebp
+       cmp      ebp, dword ptr [rbx+0x20]
+       jl       SHORT G_M24577_IG04
+						;; size=7 bbWeight=100.00 PerfScore 425.00
+G_M24577_IG11:
+       xor      ebx, ebx
+						;; size=2 bbWeight=0.00 PerfScore 0.00
+G_M24577_IG12:
+       mov      rcx, rsi
        cmp      dword ptr [rcx], ecx
        call     [System.Collections.Generic.PriorityQueue`2[int,int]:Dequeue():int:this]
-       inc      r14d
-       cmp      r14d, 5
-       jl       SHORT G_M24577_IG10
-						;; size=20 bbWeight=0.00 PerfScore 0.01
-G_M24577_IG11:
+       inc      ebx
+       cmp      ebx, 5
+       jl       SHORT G_M24577_IG12
+						;; size=18 bbWeight=0.00 PerfScore 0.01
+G_M24577_IG13:
        add      rsp, 216
        pop      rbx
        pop      rsi
@@ -711,28 +719,28 @@ G_M24577_IG11:
        pop      rbp
        ret      
 						;; size=16 bbWeight=0.00 PerfScore 0.00
-G_M24577_IG12:
+G_M24577_IG14:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M24577_IG13:
-       mov      rcx, gword ptr [rdi+0x10]
+G_M24577_IG15:
+       mov      rcx, gword ptr [rsi+0x10]
        mov      edx, r15d
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        test     eax, eax
-       jle      SHORT G_M24577_IG08
+       jle      SHORT G_M24577_IG10
        mov      edx, r14d
        mov      ecx, r15d
        mov      dword ptr [rsp+0x20], edx
        mov      dword ptr [rsp+0x24], ecx
        mov      rdx, qword ptr [rsp+0x20]
-       mov      rcx, rdi
+       mov      rcx, rsi
        xor      r8d, r8d
        call     [<unknown method>]
-       jmp      SHORT G_M24577_IG07
+       jmp      SHORT G_M24577_IG09
 						;; size=57 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 284, prolog size 75, PerfScore 3551.69, instruction count 73, allocated bytes for code 284 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1-OSR)
+; Total bytes of code 281, prolog size 75, PerfScore 3433.03, instruction count 73, allocated bytes for code 281 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1)
@@ -746,31 +754,31 @@ G_M24577_IG13:
 ; 6 inlinees with PGO data; 8 single block inlinees; 3 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T11] (  6, 810899.22)     ref  ->  rbx         this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
-;  V01 loc0         [V01,T04] ( 40,2543052.49)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.PriorityQueue`2[int,int]>
-;  V02 loc1         [V02,T09] (  7, 815034.18)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
-;  V03 loc2         [V03,T22] ( 10,  16425.96)     int  ->  rbp        
+;  V00 this         [V00,T11] (  6, 781885.89)     ref  ->  rbx         this class-hnd single-def <System.Collections.Tests.Perf_PriorityQueue`2[int,int]>
+;  V01 loc0         [V01,T04] ( 40,2459096.82)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.PriorityQueue`2[int,int]>
+;  V02 loc1         [V02,T09] (  7, 785948.13)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
+;  V03 loc2         [V03,T22] ( 10,  16137.24)     int  ->  rbp        
 ;* V04 loc3         [V04    ] (  0,      0   )     int  ->  zero-ref   
 ;* V05 loc4         [V05    ] (  0,      0   )     int  ->  zero-ref   
-;  V06 loc5         [V06,T03] (  6,4054472.11)     int  ->  rbp        
+;* V06 loc5         [V06,T42] (  0,      0   )     int  ->  zero-ref   
 ;* V07 loc6         [V07    ] (  0,      0   )     int  ->  zero-ref   
 ;* V08 loc7         [V08    ] (  0,      0   )     int  ->  zero-ref   
 ;  V09 loc8         [V09,T38] (  4,     16   )     int  ->  r15        
 ;  V10 OutArgs      [V10    ] (  1,      1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,      0   )  struct ( 8) zero-ref    "dup spill" <System.ValueTuple`2[int,int]>
 ;* V12 tmp2         [V12    ] (  0,      0   )  struct ( 8) zero-ref    "dup spill" <System.ValueTuple`2[int,int]>
-;  V13 tmp3         [V13,T23] ( 14,  16384   )     int  ->  r12         "Inline stloc first use temp"
+;  V13 tmp3         [V13,T23] ( 14,  16096   )     int  ->  r12         "Inline stloc first use temp"
 ;* V14 tmp4         [V14    ] (  0,      0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.ValueTuple`2[int,int]>
 ;* V15 tmp5         [V15    ] (  0,      0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.ValueTuple`2[int,int]>
-;  V16 tmp6         [V16,T17] ( 14,  24627.61)     ref  ->  rdx         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V17 tmp7         [V17,T13] ( 18,  78221.30)     int  ->  r12         "Inlining Arg"
-;  V18 tmp8         [V18,T24] (  8,  13990.49)     int  ->   r8         "Inline stloc first use temp"
+;  V16 tmp6         [V16,T19] ( 14,  21210.76)     ref  ->  rdx         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V17 tmp7         [V17,T13] ( 18,  70875.05)     int  ->  r12         "Inlining Arg"
+;  V18 tmp8         [V18,T24] (  8,  13760.57)     int  ->   r8         "Inline stloc first use temp"
 ;* V19 tmp9         [V19    ] (  0,      0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
 ;* V20 tmp10        [V20    ] (  0,      0   )  struct ( 8) zero-ref    "Inlining Arg" <System.ValueTuple`2[int,int]>
 ;* V21 tmp11        [V21    ] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V22 tmp12        [V22    ] (  0,      0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V23 tmp13        [V23    ] (  0,      0   )     int  ->  zero-ref    "Inlining Arg"
-;* V24 tmp14        [V24,T32] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V24 tmp14        [V24,T33] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V25 tmp15        [V25    ] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V26 tmp16        [V26    ] (  0,      0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
 ;* V27 tmp17        [V27    ] (  0,      0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.ValueTuple`2[int,int]>
@@ -778,47 +786,48 @@ G_M24577_IG13:
 ;* V29 tmp19        [V29    ] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V30 tmp20        [V30    ] (  0,      0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V31 tmp21        [V31    ] (  0,      0   )     int  ->  zero-ref    "Inlining Arg"
-;* V32 tmp22        [V32,T07] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V32 tmp22        [V32,T08] (  0,      0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V33 tmp23        [V33    ] (  0,      0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V34 tmp24        [V34,T44] (  3,      0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V34 tmp24        [V34,T45] (  3,      0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;  V35 tmp25        [V35,T36] (  5,     23   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V36 tmp26        [V36    ] (  0,      0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V37 tmp27        [V37    ] (  0,      0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.ValueTuple`2[int,int]>
-;  V38 tmp28        [V38,T28] (  6,   8192   )     int  ->  r15         "field V11.Item1 (fldOffset=0x0)" P-INDEP
-;  V39 tmp29        [V39,T29] (  6,   8192   )     int  ->  r13         "field V11.Item2 (fldOffset=0x4)" P-INDEP
-;  V40 tmp30        [V40,T08] (  3, 838346.26)     int  ->  r15         "field V12.Item1 (fldOffset=0x0)" P-INDEP
-;  V41 tmp31        [V41,T05] (  6,1780214.21)     int  ->  r13         "field V12.Item2 (fldOffset=0x4)" P-INDEP
-;  V42 tmp32        [V42,T42] (  4,      0   )     int  ->  rax         "field V14.Item1 (fldOffset=0x0)" P-INDEP
-;  V43 tmp33        [V43,T43] (  4,      0   )     int  ->  r10         "field V14.Item2 (fldOffset=0x4)" P-INDEP
-;  V44 tmp34        [V44,T30] (  4,   8192   )     int  ->  r15         "field V15.Item1 (fldOffset=0x0)" P-INDEP
-;  V45 tmp35        [V45,T31] (  4,   8192   )     int  ->  r13         "field V15.Item2 (fldOffset=0x4)" P-INDEP
-;  V46 tmp36        [V46,T33] (  4,   7394.16)     int  ->  r10         "field V19.Item1 (fldOffset=0x0)" P-INDEP
-;  V47 tmp37        [V47,T26] (  8,  11226.70)     int  ->   r9         "field V19.Item2 (fldOffset=0x4)" P-INDEP
-;  V48 tmp38        [V48,T27] (  4,   9714.24)     int  ->  r15         "field V20.Item1 (fldOffset=0x0)" P-INDEP
-;  V49 tmp39        [V49,T25] (  8,  13546.78)     int  ->  r13         "field V20.Item2 (fldOffset=0x4)" P-INDEP
+;  V38 tmp28        [V38,T27] (  6,   8048   )     int  ->  r15         "field V11.Item1 (fldOffset=0x0)" P-INDEP
+;  V39 tmp29        [V39,T28] (  6,   8048   )     int  ->  r13         "field V11.Item2 (fldOffset=0x4)" P-INDEP
+;  V40 tmp30        [V40,T07] (  3, 808660.50)     int  ->  r15         "field V12.Item1 (fldOffset=0x0)" P-INDEP
+;  V41 tmp31        [V41,T05] (  6,1720071.28)     int  ->  r13         "field V12.Item2 (fldOffset=0x4)" P-INDEP
+;  V42 tmp32        [V42,T43] (  4,      0   )     int  ->  rax         "field V14.Item1 (fldOffset=0x0)" P-INDEP
+;  V43 tmp33        [V43,T44] (  4,      0   )     int  ->  r10         "field V14.Item2 (fldOffset=0x4)" P-INDEP
+;  V44 tmp34        [V44,T29] (  4,   8048   )     int  ->  r15         "field V15.Item1 (fldOffset=0x0)" P-INDEP
+;  V45 tmp35        [V45,T30] (  4,   8048   )     int  ->  r13         "field V15.Item2 (fldOffset=0x4)" P-INDEP
+;  V46 tmp36        [V46,T32] (  4,   7269.52)     int  ->  r10         "field V19.Item1 (fldOffset=0x0)" P-INDEP
+;  V47 tmp37        [V47,T26] (  8,  11040.89)     int  ->   r9         "field V19.Item2 (fldOffset=0x4)" P-INDEP
+;  V48 tmp38        [V48,T31] (  4,   8048   )     int  ->  r15         "field V20.Item1 (fldOffset=0x0)" P-INDEP
+;  V49 tmp39        [V49,T25] (  8,  11819.36)     int  ->  r13         "field V20.Item2 (fldOffset=0x4)" P-INDEP
 ;* V50 tmp40        [V50    ] (  0,      0   )     int  ->  zero-ref    "field V26.Item1 (fldOffset=0x0)" P-INDEP
-;  V51 tmp41        [V51,T06] (  4,1752411.54)     int  ->   r8         "field V26.Item2 (fldOffset=0x4)" P-INDEP
-;  V52 tmp42        [V52,T46] (  2,      0   )     int  ->  rdx         "field V27.Item1 (fldOffset=0x0)" P-INDEP
-;  V53 tmp43        [V53,T47] (  2,      0   )     int  ->  rcx         "field V27.Item2 (fldOffset=0x4)" P-INDEP
-;  V54 tmp44        [V54,T14] (  2,  54904.07)     int  ->  r15         "field V28.Item1 (fldOffset=0x0)" P-INDEP
-;  V55 tmp45        [V55,T15] (  2,  54904.07)     int  ->  r13         "field V28.Item2 (fldOffset=0x4)" P-INDEP
+;  V51 tmp41        [V51,T06] (  4,1695743.83)     int  ->   r8         "field V26.Item2 (fldOffset=0x4)" P-INDEP
+;  V52 tmp42        [V52,T47] (  2,      0   )     int  ->  rdx         "field V27.Item1 (fldOffset=0x0)" P-INDEP
+;  V53 tmp43        [V53,T48] (  2,      0   )     int  ->  rcx         "field V27.Item2 (fldOffset=0x4)" P-INDEP
+;  V54 tmp44        [V54,T14] (  2,  53559.22)     int  ->  r15         "field V28.Item1 (fldOffset=0x0)" P-INDEP
+;  V55 tmp45        [V55,T15] (  2,  53559.22)     int  ->  r13         "field V28.Item2 (fldOffset=0x4)" P-INDEP
 ;  V56 tmp46        [V56,T40] (  3,     13   )     int  ->  r13         "field V37.Item1 (fldOffset=0x0)" P-INDEP
 ;  V57 tmp47        [V57,T41] (  3,     13   )     int  ->  rbp         "field V37.Item2 (fldOffset=0x4)" P-INDEP
-;  V58 tmp48        [V58,T18] (  6,  24576   )   byref  ->  rdx         "BlockOp address local"
-;  V59 tmp49        [V59,T12] ( 18, 164766.20)  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
-;  V60 tmp50        [V60,T21] (  6,  19788.99)   byref  ->  rax         "BlockOp address local"
-;  V61 tmp51        [V61,T19] (  6,  24576   )   byref  ->  rax         "BlockOp address local"
-;  V62 tmp52        [V62,T16] (  6,  33709.45)   byref  ->  rcx         "BlockOp address local"
-;  V63 tmp53        [V63,T00] (  3,4865365.33)   byref  ->  rdx         "BlockOp address local"
-;  V64 tmp54        [V64,T01] (  3,4863261.51)     ref  ->  rdx         "arr expr"
-;  V65 tmp55        [V65,T02] (  3,4863261.51)   byref  ->  rdx         "BlockOp address local"
+;  V58 tmp48        [V58,T16] (  6,  24144   )   byref  ->  rdx         "BlockOp address local"
+;  V59 tmp49        [V59,T12] ( 18, 160731.67)  struct ( 8) [rsp+0x20]  do-not-enreg[SF] "by-value struct argument" <System.ValueTuple`2[int,int]>
+;  V60 tmp50        [V60,T20] (  6,  19473.14)   byref  ->  rax         "BlockOp address local"
+;  V61 tmp51        [V61,T17] (  6,  24144   )   byref  ->  rax         "BlockOp address local"
+;  V62 tmp52        [V62,T18] (  6,  24144   )   byref  ->  rcx         "BlockOp address local"
+;  V63 tmp53        [V63,T02] (  3,4691285.33)   byref  ->  rdx         "BlockOp address local"
+;  V64 tmp54        [V64,T00] (  3,4705998.28)     ref  ->  rdx         "arr expr"
+;  V65 tmp55        [V65,T01] (  3,4705998.28)   byref  ->  rdx         "BlockOp address local"
 ;  V66 tmp56        [V66,T37] (  2,     20   )     ref  ->  rcx         "arr expr"
 ;  V67 tmp57        [V67,T34] (  3,     24   )     ref  ->  rcx         "arr expr"
 ;  V68 tmp58        [V68,T35] (  3,     24   )   byref  ->  rdx         "BlockOp address local"
-;  V69 tmp59        [V69,T45] (  2,      0   )     ref  ->  rdx         "argument with side effect"
+;  V69 tmp59        [V69,T46] (  2,      0   )     ref  ->  rdx         "argument with side effect"
 ;  V70 cse0         [V70,T39] (  3,     15   )     int  ->  rdx         "CSE #08: conservative"
-;  V71 cse1         [V71,T10] (  5, 810978.14)     int  ->  r14         multi-def "CSE #03: moderate"
-;  V72 cse2         [V72,T20] (  5,  20253.09)     int  ->  rcx         hoist multi-def "CSE #02: moderate"
+;  V71 cse1         [V71,T10] (  5, 781963.37)     int  ->  r14         multi-def "CSE #03: moderate"
+;  V72 cse2         [V72,T21] (  5,  16942.92)     int  ->  rcx         hoist multi-def "CSE #02: moderate"
+;  V73 rat0         [V73,T03] (  6,3909405.44)    long  ->  rbp         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -860,16 +869,16 @@ G_M24577_IG04:
        mov      dword ptr [rsi+0x20], edx
        cmp      gword ptr [rsi+0x10], 0
        jne      G_M24577_IG40
-						;; size=54 bbWeight=4055.04 PerfScore 88197.12
+						;; size=54 bbWeight=3983.76 PerfScore 86646.78
 G_M24577_IG05:
        mov      rdx, gword ptr [rsi+0x08]
        test     r12d, r12d
        jle      SHORT G_M24577_IG09
-						;; size=9 bbWeight=4055.04 PerfScore 13178.88
+						;; size=9 bbWeight=3983.76 PerfScore 12947.22
 G_M24577_IG06:
        mov      ecx, dword ptr [rdx+0x08]
        align    [0 bytes for IG07]
-						;; size=3 bbWeight=1808.75 PerfScore 3617.50
+						;; size=3 bbWeight=1778.57 PerfScore 3557.15
 G_M24577_IG07:
        lea      r8d, [r12-0x01]
        sar      r8d, 2
@@ -881,7 +890,7 @@ G_M24577_IG07:
        mov      r9d, dword ptr [rax+0x04]
        cmp      r13d, r9d
        jge      SHORT G_M24577_IG12
-						;; size=38 bbWeight=3265.18 PerfScore 28570.35
+						;; size=38 bbWeight=3213.07 PerfScore 28114.35
 G_M24577_IG08:
        cmp      r12d, ecx
        jae      G_M24577_IG38
@@ -892,7 +901,7 @@ G_M24577_IG08:
        mov      r12d, r8d
        test     r12d, r12d
        jg       SHORT G_M24577_IG07
-						;; size=32 bbWeight=4055.04 PerfScore 24330.24
+						;; size=32 bbWeight=3983.76 PerfScore 23902.56
 G_M24577_IG09:
        mov      ecx, dword ptr [rdx+0x08]
        cmp      r12d, ecx
@@ -901,12 +910,12 @@ G_M24577_IG09:
        lea      rcx, bword ptr [rdx+8*r8+0x10]
        mov      dword ptr [rcx], r15d
        mov      dword ptr [rcx+0x04], r13d
-						;; size=27 bbWeight=5562.06 PerfScore 36153.39
+						;; size=27 bbWeight=3983.76 PerfScore 25894.44
 G_M24577_IG10:
        inc      ebp
        cmp      ebp, 5
        jl       G_M24577_IG04
-						;; size=11 bbWeight=4055.04 PerfScore 6082.56
+						;; size=11 bbWeight=3983.76 PerfScore 5975.64
 G_M24577_IG11:
        jmp      SHORT G_M24577_IG15
        align    [0 bytes for IG23]
@@ -914,15 +923,15 @@ G_M24577_IG11:
 G_M24577_IG12:
        cmp      r13d, r9d
        jg       SHORT G_M24577_IG09
-						;; size=5 bbWeight=529.03 PerfScore 661.28
+						;; size=5 bbWeight=520.58 PerfScore 650.73
 G_M24577_IG13:
        jmp      SHORT G_M24577_IG09
-						;; size=2 bbWeight=3265.18 PerfScore 6530.37
+						;; size=2 bbWeight=471.36 PerfScore 942.72
 G_M24577_IG14:
        inc      ebp
        cmp      ebp, 5
        jl       SHORT G_M24577_IG20
-						;; size=7 bbWeight=40.96 PerfScore 61.44
+						;; size=7 bbWeight=40.24 PerfScore 60.36
 G_M24577_IG15:
        mov      ebp, 5
        cmp      dword ptr [rbx+0x20], 5
@@ -931,13 +940,12 @@ G_M24577_IG15:
 G_M24577_IG16:
        cmp      ebp, r14d
        jae      G_M24577_IG38
-       mov      edx, ebp
-       lea      rdx, bword ptr [rdi+8*rdx+0x10]
+       lea      rdx, bword ptr [rdi+8*rbp+0x10]
        mov      r15d, dword ptr [rdx]
        mov      r13d, dword ptr [rdx+0x04]
        cmp      dword ptr [rsi+0x20], 0
        je       G_M24577_IG26
-						;; size=33 bbWeight=810894.22 PerfScore 8514389.33
+						;; size=31 bbWeight=781880.89 PerfScore 8014279.11
 G_M24577_IG17:
        mov      rdx, gword ptr [rsi+0x08]
        cmp      dword ptr [rdx+0x08], 0
@@ -949,14 +957,14 @@ G_M24577_IG17:
        jne      G_M24577_IG43
        cmp      r13d, r8d
        jl       G_M24577_IG26
-						;; size=44 bbWeight=810543.58 PerfScore 13373969.14
+						;; size=44 bbWeight=784333.05 PerfScore 12941495.28
 G_M24577_IG18:
        cmp      r13d, r8d
        jle      G_M24577_IG26
-						;; size=9 bbWeight=131324.37 PerfScore 164155.46
+						;; size=9 bbWeight=127077.73 PerfScore 158847.17
 G_M24577_IG19:
        jmp      G_M24577_IG30
-						;; size=5 bbWeight=12417.10 PerfScore 24834.21
+						;; size=5 bbWeight=12015.57 PerfScore 24031.15
 G_M24577_IG20:
        mov      r14d, dword ptr [rdi+0x08]
        cmp      ebp, r14d
@@ -974,15 +982,15 @@ G_M24577_IG20:
        mov      dword ptr [rsi+0x20], r9d
        cmp      gword ptr [rsi+0x10], 0
        jne      G_M24577_IG42
-						;; size=68 bbWeight=40.96 PerfScore 1024.00
+						;; size=68 bbWeight=40.24 PerfScore 1006.00
 G_M24577_IG21:
        mov      rdx, gword ptr [rsi+0x08]
        test     r12d, r12d
        jle      SHORT G_M24577_IG25
-						;; size=9 bbWeight=40.96 PerfScore 133.12
+						;; size=9 bbWeight=40.24 PerfScore 130.78
 G_M24577_IG22:
        mov      eax, dword ptr [rdx+0x08]
-						;; size=3 bbWeight=18.27 PerfScore 36.54
+						;; size=3 bbWeight=17.97 PerfScore 35.93
 G_M24577_IG23:
        lea      r8d, [r12-0x01]
        sar      r8d, 2
@@ -994,7 +1002,7 @@ G_M24577_IG23:
        mov      r9d, dword ptr [rax+0x04]
        cmp      r13d, r9d
        jge      SHORT G_M24577_IG28
-						;; size=39 bbWeight=32.98 PerfScore 379.29
+						;; size=39 bbWeight=32.46 PerfScore 373.24
 G_M24577_IG24:
        cmp      r12d, dword ptr [rdx+0x08]
        jae      G_M24577_IG38
@@ -1005,7 +1013,7 @@ G_M24577_IG24:
        mov      r12d, r8d
        test     r12d, r12d
        jg       SHORT G_M24577_IG23
-						;; size=33 bbWeight=40.96 PerfScore 358.40
+						;; size=33 bbWeight=40.24 PerfScore 352.10
 G_M24577_IG25:
        cmp      r12d, dword ptr [rdx+0x08]
        jae      G_M24577_IG38
@@ -1014,22 +1022,22 @@ G_M24577_IG25:
        mov      dword ptr [rcx], r15d
        mov      dword ptr [rcx+0x04], r13d
        jmp      G_M24577_IG14
-						;; size=30 bbWeight=56.18 PerfScore 519.69
+						;; size=30 bbWeight=40.24 PerfScore 372.22
 G_M24577_IG26:
        inc      ebp
        cmp      ebp, dword ptr [rbx+0x20]
        jl       G_M24577_IG16
-						;; size=11 bbWeight=810894.22 PerfScore 3446300.44
+						;; size=11 bbWeight=781880.89 PerfScore 3322993.78
 G_M24577_IG27:
        jmp      SHORT G_M24577_IG32
 						;; size=2 bbWeight=1 PerfScore 2.00
 G_M24577_IG28:
        cmp      r13d, r9d
        jg       SHORT G_M24577_IG25
-						;; size=5 bbWeight=5.34 PerfScore 6.68
+						;; size=5 bbWeight=5.26 PerfScore 6.57
 G_M24577_IG29:
        jmp      SHORT G_M24577_IG25
-						;; size=2 bbWeight=32.98 PerfScore 65.96
+						;; size=2 bbWeight=4.76 PerfScore 9.52
 G_M24577_IG30:
        mov      dword ptr [rsp+0x20], r15d
        mov      dword ptr [rsp+0x24], r13d
@@ -1037,11 +1045,11 @@ G_M24577_IG30:
        mov      rcx, rsi
        xor      r8d, r8d
        call     [<unknown method>]
-						;; size=27 bbWeight=27452.03 PerfScore 178438.22
+						;; size=27 bbWeight=26779.61 PerfScore 174067.48
 G_M24577_IG31:
        inc      dword ptr [rsi+0x24]
        jmp      SHORT G_M24577_IG26
-						;; size=5 bbWeight=27452.03 PerfScore 137260.17
+						;; size=5 bbWeight=26779.61 PerfScore 133898.06
 G_M24577_IG32:
        xor      r15d, r15d
 						;; size=3 bbWeight=1 PerfScore 0.25
@@ -1174,6 +1182,6 @@ G_M24577_IG44:
        int3     
 						;; size=45 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 989, prolog size 19, PerfScore 26049493.54, instruction count 263, allocated bytes for code 989 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1)
+; Total bytes of code 987, prolog size 19, PerfScore 24960830.07, instruction count 262, allocated bytes for code 987 (MethodHash=ad649ffe) for method System.Collections.Tests.Perf_PriorityQueue`2[int,int]:K_Max_Elements():this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Tests.Perf_Boolean.Parse(value: " True ")``

Hot functions:

- (45.85%) ``Boolean.<TryParse>g__TryParseUncommon|20_0`` (Tier-1)
  - **Has diffs**
- (29.95%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (16.64%) ``Perf_Boolean.Parse`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]Boolean.<TryParse>g__TryParseUncommon|20_0(value class System.ReadOnlySpan`1<wchar>,bool&)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 204960
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 213920
 ; 8 inlinees with PGO data; 14 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T05] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T08] (  5,  3   )   byref  ->  rbx         single-def
-;  V02 loc0         [V02,T04] (  8,  9.96)     int  ->  rdi        
+;  V01 arg1         [V01,T09] (  5,  3   )   byref  ->  rbx         single-def
+;  V02 loc0         [V02,T03] (  8,  9.95)     int  ->  rdi        
 ;  V03 OutArgs      [V03    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V04 tmp1         [V04,T00] ( 11, 15.93)     int  ->  rbp         "Inline stloc first use temp"
+;  V04 tmp1         [V04,T06] (  7,  7.98)     int  ->  rbp         "Inline stloc first use temp"
 ;* V05 tmp2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V06 tmp3         [V06,T03] (  9, 13.88)     int  ->  r14         "Inline stloc first use temp"
-;  V07 tmp4         [V07,T09] (  2,  3.97)   ubyte  ->  rax         "Inline return value spill temp"
-;  V08 tmp5         [V08,T01] (  4, 15.90)  ushort  ->  rcx         "Inlining Arg"
+;  V06 tmp3         [V06,T10] (  4,  4   )     int  ->  rdx         "Inline stloc first use temp"
+;  V07 tmp4         [V07,T17] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V08 tmp5         [V08,T01] (  4, 11.91)  ushort  ->  rcx         "Inlining Arg"
 ;* V09 tmp6         [V09    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V10 tmp7         [V10    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V11 tmp8         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V12 tmp9         [V12    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V13 tmp10        [V13,T10] (  2,  3.95)   ubyte  ->  rax         "Inline return value spill temp"
-;  V14 tmp11        [V14,T02] (  4, 15.79)  ushort  ->  rcx         "Inlining Arg"
+;  V13 tmp10        [V13,T18] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
+;  V14 tmp11        [V14,T02] (  4, 11.78)  ushort  ->  rcx         "Inlining Arg"
 ;* V15 tmp12        [V15    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V16 tmp13        [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V17 tmp14        [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V18 tmp15        [V18    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V19 tmp16        [V19,T07] (  3,  6   )     int  ->  rcx         "Inlining Arg"
+;  V19 tmp16        [V19,T08] (  3,  6   )     int  ->  rdx         "Inlining Arg"
 ;* V20 tmp17        [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V21 tmp18        [V21    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V22 tmp19        [V22    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;* V23 tmp20        [V23,T14] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
+;* V23 tmp20        [V23,T15] (  0,  0   )     int  ->  zero-ref    "spilling unroll qmark"
 ;  V24 tmp21        [V24,T12] (  2,  2   )   byref  ->  rsi         "field V00._reference (fldOffset=0x0)" P-INDEP
 ;  V25 tmp22        [V25,T13] (  2,  2   )     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
-;  V26 tmp23        [V26,T06] (  6,  7.95)   byref  ->  rsi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;  V26 tmp23        [V26,T07] (  6,  7.93)   byref  ->  rsi         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
 ;* V27 tmp24        [V27,T16] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
 ;* V28 tmp25        [V28    ] (  0,  0   )   byref  ->  zero-ref    "field V09._reference (fldOffset=0x0)" P-INDEP
 ;* V29 tmp26        [V29    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0x8)" P-INDEP
@@ -164,17 +164,21 @@ G_M5502_IG14:
 ;* V41 tmp38        [V41    ] (  0,  0   )     int  ->  zero-ref    "field V17._length (fldOffset=0x8)" P-INDEP
 ;* V42 tmp39        [V42    ] (  0,  0   )   byref  ->  zero-ref    "field V18._reference (fldOffset=0x0)" P-INDEP
 ;* V43 tmp40        [V43    ] (  0,  0   )     int  ->  zero-ref    "field V18._length (fldOffset=0x8)" P-INDEP
-;  V44 tmp41        [V44,T15] (  3,  1.50)   byref  ->  rsi         single-def "field V20._reference (fldOffset=0x0)" P-INDEP
-;  V45 tmp42        [V45,T11] (  4,  3   )     int  ->  rcx         "field V20._length (fldOffset=0x8)" P-INDEP
+;  V44 tmp41        [V44,T14] (  3,  1.50)   byref  ->  r13         single-def "field V20._reference (fldOffset=0x0)" P-INDEP
+;  V45 tmp42        [V45,T11] (  4,  3   )     int  ->  rdx         "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V46 tmp43        [V46    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V22._reference (fldOffset=0x0)" P-INDEP
 ;* V47 tmp44        [V47    ] (  0,  0   )     int  ->  zero-ref    "field V22._length (fldOffset=0x8)" P-INDEP
 ;* V48 tmp45        [V48    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V49 tmp46        [V49    ] (  3,  0   )  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V50 rat0         [V50,T04] (  7, 10.95)    long  ->  r14         "Widened IV V04"
+;  V51 rat1         [V51,T00] (  9, 13.84)    long  ->  r15         "Widened IV V06"
 ;
 ; Lcl frame size = 48
 
 G_M5502_IG01:
+       push     r15
        push     r14
+       push     r13
        push     rdi
        push     rsi
        push     rbp
@@ -183,97 +187,90 @@ G_M5502_IG01:
        xor      eax, eax
        mov      qword ptr [rsp+0x20], rax
        mov      rbx, rdx
-						;; size=20 bbWeight=1 PerfScore 6.75
+						;; size=24 bbWeight=1 PerfScore 8.75
 G_M5502_IG02:
        mov      rsi, bword ptr [rcx]
        mov      edi, dword ptr [rcx+0x08]
        cmp      edi, 5
-       jl       G_M5502_IG20
+       jl       G_M5502_IG18
        xor      ebp, ebp
+       xor      r14d, r14d
        test     edi, edi
        jle      SHORT G_M5502_IG07
-						;; size=21 bbWeight=1 PerfScore 6.75
+						;; size=24 bbWeight=1 PerfScore 7.00
 G_M5502_IG03:
-       mov      ecx, ebp
-       movzx    rcx, word  ptr [rsi+2*rcx]
+       movzx    rcx, word  ptr [rsi+2*r14]
        cmp      ecx, 256
-       jae      SHORT G_M5502_IG04
-       mov      rax, 0xD1FFAB1E      ; static handle
-       test     byte  ptr [rcx+rax], 128
-       jne      SHORT G_M5502_IG06
-       jmp      SHORT G_M5502_IG05
-						;; size=32 bbWeight=1.99 PerfScore 19.37
+       jae      G_M5502_IG21
+       mov      eax, ecx
+       mov      rcx, 0xD1FFAB1E      ; static handle
+       test     byte  ptr [rax+rcx], 128
+       jne      SHORT G_M5502_IG05
+						;; size=35 bbWeight=1.99 PerfScore 15.38
 G_M5502_IG04:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
+       cmp      word  ptr [rsi+2*r14], 0
        jne      SHORT G_M5502_IG06
-						;; size=10 bbWeight=1.99 PerfScore 8.45
+						;; size=8 bbWeight=1.00 PerfScore 3.98
 G_M5502_IG05:
-       mov      ecx, ebp
-       cmp      word  ptr [rsi+2*rcx], 0
-       jne      SHORT G_M5502_IG07
-						;; size=9 bbWeight=1.00 PerfScore 4.24
-G_M5502_IG06:
-       inc      ebp
-       cmp      ebp, edi
-       jl       SHORT G_M5502_IG03
-						;; size=6 bbWeight=1.99 PerfScore 2.99
-G_M5502_IG07:
-       lea      r14d, [rdi-0x01]
-       cmp      r14d, ebp
-       jl       SHORT G_M5502_IG12
-						;; size=9 bbWeight=1 PerfScore 1.75
-G_M5502_IG08:
+       inc      r14d
        cmp      r14d, edi
-       jae      G_M5502_IG16
-       mov      ecx, r14d
-       movzx    rcx, word  ptr [rsi+2*rcx]
+       jl       SHORT G_M5502_IG03
+						;; size=8 bbWeight=1.99 PerfScore 2.98
+G_M5502_IG06:
+       mov      ebp, r14d
+						;; size=3 bbWeight=1 PerfScore 0.25
+G_M5502_IG07:
+       lea      edx, [rdi-0x01]
+       mov      r15d, edx
+       cmp      r15d, ebp
+       jl       SHORT G_M5502_IG12
+						;; size=11 bbWeight=1 PerfScore 2.00
+G_M5502_IG08:
+       cmp      r15d, edi
+       jae      G_M5502_IG20
+       movzx    rcx, word  ptr [rsi+2*r15]
        cmp      ecx, 256
-       jae      SHORT G_M5502_IG09
-       mov      rax, 0xD1FFAB1E      ; static handle
-       test     byte  ptr [rcx+rax], 128
-       jne      SHORT G_M5502_IG11
-       jmp      SHORT G_M5502_IG10
-						;; size=42 bbWeight=1.97 PerfScore 21.71
-G_M5502_IG09:
-       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
-       test     eax, eax
-       jne      SHORT G_M5502_IG11
-						;; size=10 bbWeight=1.97 PerfScore 8.39
-G_M5502_IG10:
-       mov      eax, r14d
-       cmp      word  ptr [rsi+2*rax], 0
-       jne      SHORT G_M5502_IG12
-						;; size=10 bbWeight=0.99 PerfScore 4.22
-G_M5502_IG11:
-       dec      r14d
-       cmp      r14d, ebp
-       jge      SHORT G_M5502_IG08
-						;; size=8 bbWeight=1.98 PerfScore 2.97
-G_M5502_IG12:
-       mov      ecx, r14d
-       sub      ecx, ebp
-       inc      ecx
-       mov      eax, ebp
+       jae      G_M5502_IG22
        mov      edx, ecx
-       add      rax, rdx
-       mov      edx, edi
-       cmp      rax, rdx
-       ja       SHORT G_M5502_IG17
+       mov      rax, 0xD1FFAB1E      ; static handle
+       test     byte  ptr [rdx+rax], 128
+       jne      SHORT G_M5502_IG10
+						;; size=44 bbWeight=1.96 PerfScore 17.67
+G_M5502_IG09:
+       cmp      word  ptr [rsi+2*r15], 0
+       jne      SHORT G_M5502_IG11
+						;; size=8 bbWeight=0.99 PerfScore 3.95
+G_M5502_IG10:
+       dec      r15d
+       cmp      r15d, ebp
+       jge      SHORT G_M5502_IG08
+						;; size=8 bbWeight=1.98 PerfScore 2.96
+G_M5502_IG11:
+       mov      edx, r15d
+						;; size=3 bbWeight=1 PerfScore 0.25
+G_M5502_IG12:
+       sub      edx, ebp
+       inc      edx
        mov      eax, ebp
-       lea      rsi, bword ptr [rsi+2*rax]
-       cmp      ecx, edi
-       je       SHORT G_M5502_IG20
-       cmp      ecx, 4
-       jne      SHORT G_M5502_IG18
-						;; size=36 bbWeight=1 PerfScore 6.25
+       mov      ecx, edx
+       add      rax, rcx
+       mov      ecx, edi
+       cmp      rax, rcx
+       ja       G_M5502_IG23
+       mov      eax, ebp
+       lea      r13, bword ptr [rsi+2*rax]
+       cmp      edx, edi
+       je       SHORT G_M5502_IG18
+       cmp      edx, 4
+       jne      SHORT G_M5502_IG16
+						;; size=37 bbWeight=1 PerfScore 6.00
 G_M5502_IG13:
        mov      rax, 0xD1FFAB1E
-       or       rax, qword ptr [rsi]
-       mov      rdx, 0xD1FFAB1E
-       cmp      rax, rdx
-       jne      SHORT G_M5502_IG18
-						;; size=28 bbWeight=0.50 PerfScore 2.38
+       or       rax, qword ptr [r13]
+       mov      rcx, 0xD1FFAB1E
+       cmp      rax, rcx
+       jne      SHORT G_M5502_IG16
+						;; size=29 bbWeight=0.50 PerfScore 2.38
 G_M5502_IG14:
        mov      byte  ptr [rbx], 1
        mov      eax, 1
@@ -284,47 +281,65 @@ G_M5502_IG15:
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r13
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=1 PerfScore 3.75
+						;; size=15 bbWeight=1 PerfScore 4.75
 G_M5502_IG16:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M5502_IG17:
-       call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M5502_IG18:
        mov      byte  ptr [rbx], 0
-       mov      bword ptr [rsp+0x20], rsi
-       mov      dword ptr [rsp+0x28], ecx
+       mov      bword ptr [rsp+0x20], r13
+       mov      dword ptr [rsp+0x28], edx
        lea      rcx, [rsp+0x20]
        call     [System.Boolean:IsFalseStringIgnoreCase(System.ReadOnlySpan`1[ushort]):ubyte]
        nop      
 						;; size=24 bbWeight=0 PerfScore 0.00
+G_M5502_IG17:
+       add      rsp, 48
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       pop      r13
+       pop      r14
+       pop      r15
+       ret      
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M5502_IG18:
+       mov      byte  ptr [rbx], 0
+       xor      eax, eax
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M5502_IG19:
        add      rsp, 48
        pop      rbx
        pop      rbp
        pop      rsi
        pop      rdi
+       pop      r13
        pop      r14
+       pop      r15
        ret      
-						;; size=11 bbWeight=0 PerfScore 0.00
+						;; size=15 bbWeight=0 PerfScore 0.00
 G_M5502_IG20:
-       mov      byte  ptr [rbx], 0
-       xor      eax, eax
+       call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
 G_M5502_IG21:
-       add      rsp, 48
-       pop      rbx
-       pop      rbp
-       pop      rsi
-       pop      rdi
-       pop      r14
-       ret      
-						;; size=11 bbWeight=0 PerfScore 0.00
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       jne      G_M5502_IG05
+       jmp      G_M5502_IG04
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M5502_IG22:
+       call     [System.Globalization.CharUnicodeInfo:GetIsWhiteSpace(ushort):ubyte]
+       test     eax, eax
+       jne      G_M5502_IG10
+       jmp      G_M5502_IG09
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M5502_IG23:
+       call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
+       int3     
+						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 323, prolog size 20, PerfScore 101.20, instruction count 109, allocated bytes for code 323 (MethodHash=b214ea81) for method System.Boolean:<TryParse>g__TryParseUncommon|20_0(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
+; Total bytes of code 374, prolog size 24, PerfScore 79.56, instruction count 118, allocated bytes for code 374 (MethodHash=b214ea81) for method System.Boolean:<TryParse>g__TryParseUncommon|20_0(System.ReadOnlySpan`1[ushort],byref):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Sort<IntStruct>.Array(Size: 512)``

Hot functions:

- (62.97%) ``System.Collections.Generic.GenericArraySortHelper`1.PickPivotAndPartition`` (Tier-1)
  - **Has diffs**
- (31.49%) ``System.Collections.Generic.GenericArraySortHelper`1.IntroSort`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct].PickPivotAndPartition(value class System.Span`1<!0>)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 184896
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 184601.5
 ; 8 inlinees with PGO data; 12 single block inlinees; 5 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T12] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 loc0         [V01,T09] ( 17, 60.43)   byref  ->  rdx         single-def
-;  V02 loc1         [V02,T15] (  7,  4.83)   byref  ->   r8         single-def
-;  V03 loc2         [V03,T13] ( 10,  7.23)   byref  ->  r10         single-def
-;  V04 loc3         [V04,T10] (  9, 41.01)   byref  ->  rcx         single-def
+;  V01 loc0         [V01,T07] ( 17, 49.37)   byref  ->  rdx         single-def
+;  V02 loc1         [V02,T15] (  7,  4.84)   byref  ->   r8         single-def
+;  V03 loc2         [V03,T13] ( 10,  7.22)   byref  ->  rcx         single-def
+;  V04 loc3         [V04,T08] (  9, 41.08)   byref  ->   r8         single-def
 ;* V05 loc4         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.IntStruct>
-;  V06 loc5         [V06,T01] ( 12,181.58)   byref  ->  rax        
-;  V07 loc6         [V07,T00] (  8,203.06)   byref  ->  r10        
+;  V06 loc5         [V06,T01] ( 12,182.25)   byref  ->  rax        
+;  V07 loc6         [V07,T00] (  8,192.88)   byref  ->   r9        
 ;# V08 OutArgs      [V08    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T02] (  2,146.44)   byref  ->  r10         "dup spill"
-;  V10 tmp2         [V10,T03] (  2,132.21)   byref  ->  rax         "dup spill"
+;  V09 tmp1         [V09,T02] (  2,147.09)   byref  ->   r9         "dup spill"
+;  V10 tmp2         [V10,T03] (  2,132.49)   byref  ->  rax         "dup spill"
 ;* V11 tmp3         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V13 tmp5         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V15 tmp7         [V15,T22] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V15 tmp7         [V15,T25] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V16 tmp8         [V16    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V18 tmp10        [V18    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
@@ -504,44 +504,44 @@ G_M50248_IG23:
 ;* V26 tmp18        [V26    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V27 tmp19        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V28 tmp20        [V28    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V29 tmp21        [V29,T23] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V29 tmp21        [V29,T27] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V30 tmp22        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V31 tmp23        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp24        [V32    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V33 tmp25        [V33    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V34 tmp26        [V34    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V35 tmp27        [V35    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V36 tmp28        [V36,T08] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V36 tmp28        [V36,T10] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V37 tmp29        [V37    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V38 tmp30        [V38    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V39 tmp31        [V39    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V40 tmp32        [V40,T07] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V40 tmp32        [V40,T09] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V42 tmp34        [V42    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V43 tmp35        [V43    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
-;  V44 tmp36        [V44,T24] (  2,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V45 tmp37        [V45,T16] (  3,  3   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
-;  V46 tmp38        [V46,T04] (  5, 98.23)     int  ->   r9         "field V05._value (fldOffset=0x0)" P-INDEP
+;  V44 tmp36        [V44,T22] (  2,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V45 tmp37        [V45,T17] (  3,  3.00)     int  ->  rax         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V46 tmp38        [V46,T04] (  5, 97.95)     int  ->  r10         "field V05._value (fldOffset=0x0)" P-INDEP
 ;* V47 tmp39        [V47    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V48 tmp40        [V48    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V49 tmp41        [V49    ] (  0,  0   )     int  ->  zero-ref    "field V12._value (fldOffset=0x0)" P-INDEP
-;  V50 tmp42        [V50,T19] (  3,  2.39)     int  ->  rax         "field V14._value (fldOffset=0x0)" P-INDEP
-;  V51 tmp43        [V51,T28] (  2,  0.92)     int  ->  rax         "field V18._value (fldOffset=0x0)" P-INDEP
+;  V50 tmp42        [V50,T19] (  3,  2.39)     int  ->  r10         "field V14._value (fldOffset=0x0)" P-INDEP
+;  V51 tmp43        [V51,T28] (  2,  0.92)     int  ->   r9         "field V18._value (fldOffset=0x0)" P-INDEP
 ;* V52 tmp44        [V52    ] (  0,  0   )     int  ->  zero-ref    "field V19._value (fldOffset=0x0)" P-INDEP
-;  V53 tmp45        [V53,T20] (  3,  2.39)     int  ->  rax         "field V21._value (fldOffset=0x0)" P-INDEP
-;  V54 tmp46        [V54,T29] (  2,  0.92)     int  ->  rax         "field V25._value (fldOffset=0x0)" P-INDEP
+;  V53 tmp45        [V53,T20] (  3,  2.39)     int  ->   r9         "field V21._value (fldOffset=0x0)" P-INDEP
+;  V54 tmp46        [V54,T29] (  2,  0.92)     int  ->  r10         "field V25._value (fldOffset=0x0)" P-INDEP
 ;* V55 tmp47        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V26._value (fldOffset=0x0)" P-INDEP
-;  V56 tmp48        [V56,T21] (  3,  2.39)     int  ->  rax         "field V28._value (fldOffset=0x0)" P-INDEP
-;  V57 tmp49        [V57,T30] (  2,  0.92)     int  ->  rax         "field V32._value (fldOffset=0x0)" P-INDEP
-;  V58 tmp50        [V58,T25] (  2,  2   )     int  ->  rax         "field V33._value (fldOffset=0x0)" P-INDEP
-;  V59 tmp51        [V59,T06] (  3, 79.18)     int  ->   r8         "field V35._value (fldOffset=0x0)" P-INDEP
-;  V60 tmp52        [V60,T05] (  3, 87.71)     int  ->   r8         "field V39._value (fldOffset=0x0)" P-INDEP
-;  V61 tmp53        [V61,T11] (  2, 29.61)     int  ->   r8         "field V42._value (fldOffset=0x0)" P-INDEP
-;  V62 tmp54        [V62,T27] (  2,  1.92)     int  ->  r10         "field V43._value (fldOffset=0x0)" P-INDEP
+;  V56 tmp48        [V56,T21] (  3,  2.39)     int  ->  r10         "field V28._value (fldOffset=0x0)" P-INDEP
+;  V57 tmp49        [V57,T30] (  2,  0.92)     int  ->   r9         "field V32._value (fldOffset=0x0)" P-INDEP
+;  V58 tmp50        [V58,T23] (  2,  2.00)     int  ->  rax         "field V33._value (fldOffset=0x0)" P-INDEP
+;  V59 tmp51        [V59,T06] (  3, 79.07)     int  ->  rcx         "field V35._value (fldOffset=0x0)" P-INDEP
+;  V60 tmp52        [V60,T05] (  3, 87.78)     int  ->  rcx         "field V39._value (fldOffset=0x0)" P-INDEP
+;  V61 tmp53        [V61,T11] (  2, 29.87)     int  ->  rcx         "field V42._value (fldOffset=0x0)" P-INDEP
+;  V62 tmp54        [V62,T24] (  2,  1.97)     int  ->  r10         "field V43._value (fldOffset=0x0)" P-INDEP
 ;* V63 tmp55        [V63    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[System.Collections.IntStruct]>
-;  V64 cse0         [V64,T17] (  3,  3   )     int  ->  rax         "CSE #01: moderate"
-;  V65 cse1         [V65,T18] (  3,  3   )     int  ->  rax         "CSE #05: moderate"
-;  V66 rat0         [V66,T14] (  3,  6   )    long  ->  rax         "ReplaceWithLclVar is creating a new local variable"
+;  V64 cse0         [V64,T16] (  3,  3   )     int  ->  rcx         "CSE #01: moderate"
+;  V65 cse1         [V65,T18] (  3,  2.99)     int  ->  rax         "CSE #05: moderate"
+;  V66 rat0         [V66,T14] (  3,  5.99)    long  ->  rax         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 0
 
@@ -549,149 +549,143 @@ G_M50248_IG01:
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M50248_IG02:
        mov      rdx, bword ptr [rcx]
-       mov      ecx, dword ptr [rcx+0x08]
-       lea      eax, [rcx-0x01]
+       mov      eax, dword ptr [rcx+0x08]
+       lea      ecx, [rax-0x01]
+       movsxd   r8, ecx
+       lea      r8, bword ptr [rdx+4*r8]
+       sar      ecx, 1
+       movsxd   rcx, ecx
+       lea      rcx, bword ptr [rdx+4*rcx]
+       cmp      byte  ptr [rdx], dl
+       mov      r10d, dword ptr [rcx]
+       cmp      dword ptr [rdx], r10d
+       jge      SHORT G_M50248_IG10
+						;; size=35 bbWeight=1 PerfScore 15.50
+G_M50248_IG03:
+       mov      r9d, dword ptr [r8]
+       cmp      dword ptr [rdx], r9d
+       jge      SHORT G_M50248_IG16
+						;; size=8 bbWeight=1 PerfScore 6.00
+G_M50248_IG04:
+       mov      r10d, dword ptr [r8]
+       cmp      dword ptr [rcx], r10d
+       jge      G_M50248_IG18
+						;; size=12 bbWeight=1 PerfScore 6.00
+G_M50248_IG05:
+       add      eax, -2
        movsxd   r8, eax
        lea      r8, bword ptr [rdx+4*r8]
-       sar      eax, 1
-       cdqe     
-       lea      r10, bword ptr [rdx+4*rax]
-       cmp      byte  ptr [rdx], dl
-       mov      eax, dword ptr [r10]
-       cmp      dword ptr [rdx], eax
-       jl       SHORT G_M50248_IG04
-						;; size=33 bbWeight=1 PerfScore 15.50
-G_M50248_IG03:
-       cmp      dword ptr [rdx], eax
-       jg       SHORT G_M50248_IG07
-						;; size=4 bbWeight=0.39 PerfScore 1.58
-G_M50248_IG04:
-       mov      eax, dword ptr [r8]
-       cmp      dword ptr [rdx], eax
-       jl       SHORT G_M50248_IG10
-						;; size=7 bbWeight=1 PerfScore 6.00
-G_M50248_IG05:
-       cmp      dword ptr [rdx], eax
-       jle      SHORT G_M50248_IG10
-						;; size=4 bbWeight=0.39 PerfScore 1.58
-G_M50248_IG06:
-       jmp      SHORT G_M50248_IG20
-       align    [0 bytes for IG08]
-						;; size=2 bbWeight=0.39 PerfScore 0.79
-G_M50248_IG07:
-       mov      eax, dword ptr [rdx]
-       mov      r9d, dword ptr [r10]
-       mov      dword ptr [rdx], r9d
-       mov      dword ptr [r10], eax
-       jmp      SHORT G_M50248_IG04
-						;; size=13 bbWeight=0.46 PerfScore 3.66
-G_M50248_IG08:
-       cmp      r10, rdx
-       jbe      SHORT G_M50248_IG22
-						;; size=5 bbWeight=47.81 PerfScore 59.77
-G_M50248_IG09:
-       jmp      SHORT G_M50248_IG17
-						;; size=2 bbWeight=36.61 PerfScore 73.22
-G_M50248_IG10:
-       mov      eax, dword ptr [r8]
-       cmp      dword ptr [r10], eax
-       jl       SHORT G_M50248_IG12
-						;; size=8 bbWeight=1 PerfScore 6.00
-G_M50248_IG11:
-       cmp      dword ptr [r10], eax
-       jg       SHORT G_M50248_IG21
-						;; size=5 bbWeight=0.39 PerfScore 1.58
-G_M50248_IG12:
-       add      ecx, -2
-       movsxd   rax, ecx
-       lea      rcx, bword ptr [rdx+4*rax]
-       mov      eax, dword ptr [r10]
-       mov      r9d, eax
-       mov      r8d, dword ptr [rcx]
-       mov      dword ptr [r10], r8d
-       mov      dword ptr [rcx], eax
+       mov      eax, dword ptr [rcx]
+       mov      r10d, eax
+       mov      r9d, dword ptr [r8]
+       mov      dword ptr [rcx], r9d
+       mov      dword ptr [r8], eax
        mov      rax, rdx
-       mov      r10, rcx
-       cmp      rdx, rcx
-       jae      SHORT G_M50248_IG24
-						;; size=35 bbWeight=1 PerfScore 9.00
-G_M50248_IG13:
-       cmp      rax, rcx
-       jae      SHORT G_M50248_IG08
-						;; size=5 bbWeight=33.09 PerfScore 41.36
-G_M50248_IG14:
+       mov      r9, r8
+       cmp      rdx, r8
+       jae      G_M50248_IG22
+						;; size=39 bbWeight=1.00 PerfScore 8.98
+G_M50248_IG06:
+       cmp      rax, r8
+       jae      SHORT G_M50248_IG12
+						;; size=5 bbWeight=33.13 PerfScore 41.41
+G_M50248_IG07:
        add      rax, 4
-       mov      r8d, dword ptr [rax]
-       cmp      r9d, r8d
-       jl       SHORT G_M50248_IG08
-						;; size=12 bbWeight=33.05 PerfScore 115.68
+       mov      ecx, dword ptr [rax]
+       cmp      r10d, ecx
+       jl       SHORT G_M50248_IG12
+						;; size=11 bbWeight=33.12 PerfScore 115.93
+G_M50248_IG08:
+       cmp      r10d, ecx
+       jle      SHORT G_M50248_IG12
+						;; size=5 bbWeight=12.82 PerfScore 16.03
+G_M50248_IG09:
+       jmp      SHORT G_M50248_IG06
+						;; size=2 bbWeight=12.82 PerfScore 25.63
+G_M50248_IG10:
+       cmp      dword ptr [rdx], r10d
+       jle      SHORT G_M50248_IG03
+						;; size=5 bbWeight=0.39 PerfScore 1.55
+G_M50248_IG11:
+       mov      r9d, dword ptr [rdx]
+       mov      r10d, dword ptr [rcx]
+       mov      dword ptr [rdx], r10d
+       mov      dword ptr [rcx], r9d
+       jmp      SHORT G_M50248_IG03
+       align    [0 bytes for IG12]
+						;; size=14 bbWeight=0.46 PerfScore 3.67
+G_M50248_IG12:
+       cmp      r9, rdx
+       jbe      SHORT G_M50248_IG20
+						;; size=5 bbWeight=36.77 PerfScore 45.96
+G_M50248_IG13:
+       add      r9, -4
+       mov      ecx, dword ptr [r9]
+       cmp      r10d, ecx
+       jl       SHORT G_M50248_IG12
+						;; size=12 bbWeight=36.77 PerfScore 128.70
+G_M50248_IG14:
+       cmp      r10d, ecx
+       jle      SHORT G_M50248_IG20
+						;; size=5 bbWeight=14.24 PerfScore 17.80
 G_M50248_IG15:
-       cmp      r9d, r8d
-       jle      SHORT G_M50248_IG08
-						;; size=5 bbWeight=13.08 PerfScore 16.35
+       jmp      SHORT G_M50248_IG20
+						;; size=2 bbWeight=14.23 PerfScore 28.46
 G_M50248_IG16:
-       jmp      SHORT G_M50248_IG13
-						;; size=2 bbWeight=13.07 PerfScore 26.14
+       cmp      dword ptr [rdx], r9d
+       jle      SHORT G_M50248_IG04
+						;; size=5 bbWeight=0.39 PerfScore 1.55
 G_M50248_IG17:
-       add      r10, -4
-       mov      r8d, dword ptr [r10]
-       cmp      r9d, r8d
-       jl       SHORT G_M50248_IG08
-						;; size=12 bbWeight=36.61 PerfScore 128.14
-G_M50248_IG18:
-       cmp      r9d, r8d
-       jle      SHORT G_M50248_IG22
-						;; size=5 bbWeight=14.49 PerfScore 18.11
-G_M50248_IG19:
-       jmp      SHORT G_M50248_IG22
-						;; size=2 bbWeight=14.48 PerfScore 28.96
-G_M50248_IG20:
-       mov      eax, dword ptr [rdx]
+       mov      r10d, dword ptr [rdx]
        mov      r9d, dword ptr [r8]
        mov      dword ptr [rdx], r9d
-       mov      dword ptr [r8], eax
-       jmp      SHORT G_M50248_IG10
-						;; size=13 bbWeight=0.46 PerfScore 3.66
-G_M50248_IG21:
-       mov      eax, dword ptr [r10]
-       mov      r9d, dword ptr [r8]
-       mov      dword ptr [r10], r9d
-       mov      dword ptr [r8], eax
-       jmp      SHORT G_M50248_IG12
-						;; size=14 bbWeight=0.46 PerfScore 3.66
-G_M50248_IG22:
-       cmp      rax, r10
-       jae      SHORT G_M50248_IG24
-						;; size=5 bbWeight=14.81 PerfScore 18.51
-G_M50248_IG23:
-       mov      r8d, dword ptr [rax]
-       mov      r11d, dword ptr [r10]
-       mov      dword ptr [rax], r11d
-       mov      dword ptr [r10], r8d
-       jmp      SHORT G_M50248_IG13
-						;; size=14 bbWeight=14.80 PerfScore 118.43
-G_M50248_IG24:
-       cmp      rax, rcx
-       je       SHORT G_M50248_IG26
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M50248_IG25:
-       mov      r10d, dword ptr [rax]
+       mov      dword ptr [r8], r10d
+       jmp      G_M50248_IG04
+						;; size=17 bbWeight=0.46 PerfScore 3.67
+G_M50248_IG18:
+       cmp      dword ptr [rcx], r10d
+       jle      G_M50248_IG05
+						;; size=9 bbWeight=0.39 PerfScore 1.55
+G_M50248_IG19:
        mov      r9d, dword ptr [rcx]
-       mov      dword ptr [rax], r9d
+       mov      r10d, dword ptr [r8]
        mov      dword ptr [rcx], r10d
-						;; size=12 bbWeight=0.96 PerfScore 5.76
-G_M50248_IG26:
+       mov      dword ptr [r8], r9d
+       jmp      G_M50248_IG05
+						;; size=17 bbWeight=0.46 PerfScore 3.67
+G_M50248_IG20:
+       cmp      rax, r9
+       jae      SHORT G_M50248_IG22
+						;; size=5 bbWeight=14.93 PerfScore 18.66
+G_M50248_IG21:
+       mov      ecx, dword ptr [rax]
+       mov      r11d, dword ptr [r9]
+       mov      dword ptr [rax], r11d
+       mov      dword ptr [r9], ecx
+       jmp      G_M50248_IG06
+						;; size=16 bbWeight=14.94 PerfScore 119.50
+G_M50248_IG22:
+       cmp      rax, r8
+       je       SHORT G_M50248_IG24
+						;; size=5 bbWeight=1.00 PerfScore 1.25
+G_M50248_IG23:
+       mov      r10d, dword ptr [rax]
+       mov      r9d, dword ptr [r8]
+       mov      dword ptr [rax], r9d
+       mov      dword ptr [r8], r10d
+						;; size=12 bbWeight=0.98 PerfScore 5.91
+G_M50248_IG24:
        sub      rax, rdx
-       mov      rcx, rax
-       sar      rcx, 63
-       and      rcx, 3
-       add      rax, rcx
+       mov      rdx, rax
+       sar      rdx, 63
+       and      rdx, 3
+       add      rax, rdx
        sar      rax, 2
-						;; size=21 bbWeight=1 PerfScore 2.00
-G_M50248_IG27:
+						;; size=21 bbWeight=1.00 PerfScore 2.00
+G_M50248_IG25:
        ret      
-						;; size=1 bbWeight=1 PerfScore 1.00
+						;; size=1 bbWeight=1.00 PerfScore 1.00
 
-; Total bytes of code 246, prolog size 0, PerfScore 707.69, instruction count 92, allocated bytes for code 249 (MethodHash=e6183bb7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:PickPivotAndPartition(System.Span`1[System.Collections.IntStruct]):int (Tier1)
+; Total bytes of code 268, prolog size 0, PerfScore 620.36, instruction count 90, allocated bytes for code 276 (MethodHash=e6183bb7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:PickPivotAndPartition(System.Span`1[System.Collections.IntStruct]):int (Tier1)
 ; ============================================================
 


```

### ``[System.Private.CoreLib]System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct].IntroSort(value class System.Span`1<!0>,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 181364
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 182360
 ; 14 inlinees with PGO data; 18 single block inlinees; 5 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T10] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T11] (  6,  6.93)     int  ->  rbx        
-;  V02 loc0         [V02,T09] ( 13, 13.55)     int  ->  rbp        
-;  V03 loc1         [V03,T17] (  3,  3.95)     int  ->  r14        
+;  V01 arg1         [V01,T11] (  6,  6.89)     int  ->  rbx        
+;  V02 loc0         [V02,T08] ( 13, 13.48)     int  ->  rbp        
+;  V03 loc1         [V03,T17] (  3,  3.91)     int  ->  r14        
 ;  V04 loc2         [V04,T25] (  7,  0.42)   byref  ->  rax         single-def
 ;  V05 loc3         [V05,T26] (  6,  0.38)   byref  ->  rdx         single-def
 ;* V06 loc4         [V06    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V07 loc5         [V07,T19] (  3,  2.95)     int  ->  rcx        
+;  V07 loc5         [V07,T19] (  3,  2.91)     int  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.IntStruct]>
 ;* V10 tmp2         [V10    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.IntStruct]>
@@ -690,7 +690,7 @@ G_M61030_IG21:
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.IntStruct]>
 ;* V13 tmp5         [V13    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
-;  V15 tmp7         [V15,T34] (  4,  0.13)   byref  ->  rcx         single-def "Inlining Arg"
+;  V15 tmp7         [V15,T31] (  4,  0.13)   byref  ->  rcx         single-def "Inlining Arg"
 ;* V16 tmp8         [V16    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V17 tmp9         [V17    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
 ;* V18 tmp10        [V18,T39] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
@@ -700,7 +700,7 @@ G_M61030_IG21:
 ;* V22 tmp14        [V22    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V23 tmp15        [V23    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V24 tmp16        [V24    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V25 tmp17        [V25,T31] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V25 tmp17        [V25,T32] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V26 tmp18        [V26    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V27 tmp19        [V27    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V28 tmp20        [V28    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
@@ -714,17 +714,17 @@ G_M61030_IG21:
 ;* V36 tmp28        [V36    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V37 tmp29        [V37    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V38 tmp30        [V38    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V39 tmp31        [V39,T32] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V39 tmp31        [V39,T34] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V40 tmp32        [V40    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V42 tmp34        [V42    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V43 tmp35        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V45 tmp37        [V45,T06] (  5, 83.75)     int  ->  rdx         "Inline stloc first use temp"
+;  V45 tmp37        [V45,T05] (  5, 43.32)     int  ->  rax         "Inline stloc first use temp"
 ;* V46 tmp38        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V47 tmp39        [V47    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.IntStruct>
-;  V48 tmp40        [V48,T00] (  8,210.94)     int  ->  rdx         "Inline stloc first use temp"
-;  V49 tmp41        [V49,T02] (  2,102.41)   byref  ->  r10         "impAppendStmt"
+;  V48 tmp40        [V48,T00] (  8,185.91)     int  ->  rax         "Inline stloc first use temp"
+;  V49 tmp41        [V49,T02] (  2, 98.93)   byref  ->   r8         "impAppendStmt"
 ;* V50 tmp42        [V50    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V51 tmp43        [V51    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V52 tmp44        [V52    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
@@ -732,18 +732,18 @@ G_M61030_IG21:
 ;* V54 tmp46        [V54    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V55 tmp47        [V55    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V56 tmp48        [V56    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V57 tmp49        [V57,T05] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V57 tmp49        [V57,T06] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V58 tmp50        [V58    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V59 tmp51        [V59    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V60 tmp52        [V60    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V61 tmp53        [V61    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V62 tmp54        [V62    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V63 tmp55        [V63    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V64 tmp56        [V64,T12] (  3,  7.90)     int  ->  rbp         "Inlining Arg"
+;  V64 tmp56        [V64,T12] (  3,  7.83)     int  ->  rbp         "Inlining Arg"
 ;* V65 tmp57        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V66 tmp58        [V66    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V67 tmp59        [V67,T13] ( 22,  5.59)   byref  ->  rsi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V68 tmp60        [V68,T14] (  8,  5.92)     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V67 tmp59        [V67,T13] ( 22,  5.57)   byref  ->  rsi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V68 tmp60        [V68,T14] (  8,  5.90)     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V69 tmp61        [V69    ] (  0,  0   )   byref  ->  zero-ref    "field V09._reference (fldOffset=0x0)" P-INDEP
 ;* V70 tmp62        [V70    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0x8)" P-INDEP
 ;* V71 tmp63        [V71    ] (  0,  0   )   byref  ->  zero-ref    "field V10._reference (fldOffset=0x0)" P-INDEP
@@ -759,16 +759,16 @@ G_M61030_IG21:
 ;  V81 tmp73        [V81,T28] (  3,  0.21)     int  ->  rcx         "field V24._value (fldOffset=0x0)" P-INDEP
 ;  V82 tmp74        [V82,T35] (  2,  0.08)     int  ->  rcx         "field V28._value (fldOffset=0x0)" P-INDEP
 ;* V83 tmp75        [V83    ] (  0,  0   )     int  ->  zero-ref    "field V29._value (fldOffset=0x0)" P-INDEP
-;  V84 tmp76        [V84,T29] (  3,  0.21)     int  ->  rcx         "field V31._value (fldOffset=0x0)" P-INDEP
+;  V84 tmp76        [V84,T29] (  3,  0.21)     int  ->   r8         "field V31._value (fldOffset=0x0)" P-INDEP
 ;  V85 tmp77        [V85,T36] (  2,  0.08)     int  ->  rcx         "field V35._value (fldOffset=0x0)" P-INDEP
 ;* V86 tmp78        [V86    ] (  0,  0   )     int  ->  zero-ref    "field V36._value (fldOffset=0x0)" P-INDEP
 ;  V87 tmp79        [V87,T30] (  3,  0.21)     int  ->  rcx         "field V38._value (fldOffset=0x0)" P-INDEP
-;  V88 tmp80        [V88,T37] (  2,  0.08)     int  ->   r8         "field V42._value (fldOffset=0x0)" P-INDEP
+;  V88 tmp80        [V88,T37] (  2,  0.08)     int  ->  r10         "field V42._value (fldOffset=0x0)" P-INDEP
 ;  V89 tmp81        [V89,T21] (  2,  1.74)   byref  ->  rsi         single-def "field V43._reference (fldOffset=0x0)" P-INDEP
-;  V90 tmp82        [V90,T22] (  2,  1.74)     int  ->  rax         "field V43._length (fldOffset=0x8)" P-INDEP
-;  V91 tmp83        [V91,T01] (  6,126.25)   byref  ->  rsi         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
-;  V92 tmp84        [V92,T23] (  2,  1.74)     int  ->  rax         "field V46._length (fldOffset=0x8)" P-INDEP
-;  V93 tmp85        [V93,T04] (  4, 87.11)     int  ->   r8         "field V47._value (fldOffset=0x0)" P-INDEP
+;  V90 tmp82        [V90,T22] (  2,  1.74)     int  ->  rdx         "field V43._length (fldOffset=0x8)" P-INDEP
+;  V91 tmp83        [V91,T01] (  6,103.55)   byref  ->  rsi         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
+;  V92 tmp84        [V92,T23] (  2,  1.74)     int  ->  rdx         "field V46._length (fldOffset=0x8)" P-INDEP
+;  V93 tmp85        [V93,T04] (  3, 53.22)     int  ->  rcx         "field V47._value (fldOffset=0x0)" P-INDEP
 ;* V94 tmp86        [V94    ] (  0,  0   )   byref  ->  zero-ref    "field V50._reference (fldOffset=0x0)" P-INDEP
 ;* V95 tmp87        [V95    ] (  0,  0   )     int  ->  zero-ref    "field V50._length (fldOffset=0x8)" P-INDEP
 ;* V96 tmp88        [V96    ] (  0,  0   )   byref  ->  zero-ref    "field V51._reference (fldOffset=0x0)" P-INDEP
@@ -777,21 +777,21 @@ G_M61030_IG21:
 ;* V99 tmp91        [V99    ] (  0,  0   )     int  ->  zero-ref    "field V52._length (fldOffset=0x8)" P-INDEP
 ;* V100 tmp92       [V100    ] (  0,  0   )   byref  ->  zero-ref    "field V53._reference (fldOffset=0x0)" P-INDEP
 ;* V101 tmp93       [V101    ] (  0,  0   )     int  ->  zero-ref    "field V53._length (fldOffset=0x8)" P-INDEP
-;  V102 tmp94       [V102,T03] (  3, 78.41)     int  ->  r10         "field V56._value (fldOffset=0x0)" P-INDEP
+;  V102 tmp94       [V102,T03] (  2, 64.00)     int  ->   r8         "field V56._value (fldOffset=0x0)" P-INDEP
 ;* V103 tmp95       [V103    ] (  0,  0   )   byref  ->  zero-ref    "field V59._reference (fldOffset=0x0)" P-INDEP
 ;* V104 tmp96       [V104    ] (  0,  0   )     int  ->  zero-ref    "field V59._length (fldOffset=0x8)" P-INDEP
 ;  V105 tmp97       [V105,T41] (  2,  0   )   byref  ->  rcx         single-def "field V60._reference (fldOffset=0x0)" P-INDEP
 ;  V106 tmp98       [V106,T42] (  2,  0   )     int  ->  rax         "field V60._length (fldOffset=0x8)" P-INDEP
 ;* V107 tmp99       [V107,T24] (  0,  0   )   byref  ->  zero-ref    "field V62._reference (fldOffset=0x0)" P-INDEP
-;  V108 tmp100      [V108,T20] (  2,  1.97)     int  ->  rcx         "field V62._length (fldOffset=0x8)" P-INDEP
-;  V109 tmp101      [V109,T15] (  2,  3.97)   byref  ->  rcx         "field V65._reference (fldOffset=0x0)" P-INDEP
-;  V110 tmp102      [V110,T16] (  2,  3.97)     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
+;  V108 tmp100      [V108,T20] (  2,  1.94)     int  ->  rcx         "field V62._length (fldOffset=0x8)" P-INDEP
+;  V109 tmp101      [V109,T15] (  2,  3.94)   byref  ->  rcx         "field V65._reference (fldOffset=0x0)" P-INDEP
+;  V110 tmp102      [V110,T16] (  2,  3.94)     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
 ;* V111 tmp103      [V111    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[System.Collections.IntStruct]>
-;  V112 tmp104      [V112    ] (  9, 17.80)  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[System.Collections.IntStruct]>
-;  V113 cse0        [V113,T27] (  4,  0.25)     int  ->   r8         "CSE #07: conservative"
-;  V114 cse1        [V114,T08] (  3, 34.43)     int  ->  rax         "CSE #08: moderate"
-;  V115 cse2        [V115,T07] (  3, 50.19)     int  ->  rcx         "CSE #12: aggressive"
-;  V116 cse3        [V116,T18] (  3,  3.95)    long  ->  rcx         "CSE #01: moderate"
+;  V112 tmp104      [V112    ] (  9, 17.66)  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[System.Collections.IntStruct]>
+;  V113 cse0        [V113,T27] (  4,  0.25)     int  ->  r10         "CSE #07: conservative"
+;  V114 cse1        [V114,T09] (  3, 14.12)     int  ->  rdx         "CSE #08: moderate"
+;  V115 cse2        [V115,T07] (  3, 30.07)     int  ->  r10         "CSE #12: aggressive"
+;  V116 cse3        [V116,T18] (  3,  3.91)    long  ->  rcx         "CSE #01: moderate"
 ;
 ; Lcl frame size = 48
 
@@ -811,18 +811,18 @@ G_M61030_IG02:
        mov      edi, dword ptr [rcx+0x08]
        mov      ebp, edi
        cmp      edi, 1
-       jle      G_M61030_IG22
+       jle      G_M61030_IG19
 						;; size=17 bbWeight=1 PerfScore 5.50
 G_M61030_IG03:
        cmp      ebp, 16
        jle      SHORT G_M61030_IG07
-						;; size=5 bbWeight=1.96 PerfScore 2.45
+						;; size=5 bbWeight=1.95 PerfScore 2.44
 G_M61030_IG04:
        test     ebx, ebx
-       je       G_M61030_IG34
+       je       G_M61030_IG33
        dec      ebx
        cmp      ebp, edi
-       ja       G_M61030_IG35
+       ja       G_M61030_IG34
        mov      ecx, ebp
        mov      bword ptr [rsp+0x20], rsi
        mov      dword ptr [rsp+0x28], ecx
@@ -835,8 +835,8 @@ G_M61030_IG04:
        add      rdx, rcx
        mov      eax, edi
        cmp      rdx, rax
-       ja       G_M61030_IG35
-						;; size=65 bbWeight=0.98 PerfScore 11.31
+       ja       G_M61030_IG34
+						;; size=65 bbWeight=0.97 PerfScore 11.17
 G_M61030_IG05:
        lea      rcx, bword ptr [rsi+4*rcx]
        mov      bword ptr [rsp+0x20], rcx
@@ -847,92 +847,82 @@ G_M61030_IG05:
        mov      ebp, r14d
        cmp      ebp, 1
        jg       SHORT G_M61030_IG03
-						;; size=34 bbWeight=1.98 PerfScore 15.37
+						;; size=34 bbWeight=1.97 PerfScore 15.28
 G_M61030_IG06:
-       jmp      G_M61030_IG22
-       align    [3 bytes for IG11]
-						;; size=8 bbWeight=0.02 PerfScore 0.04
+       jmp      SHORT G_M61030_IG19
+       align    [0 bytes for IG11]
+						;; size=2 bbWeight=0.02 PerfScore 0.04
 G_M61030_IG07:
        cmp      ebp, 2
-       je       SHORT G_M61030_IG19
+       je       SHORT G_M61030_IG16
 						;; size=5 bbWeight=0.98 PerfScore 1.22
 G_M61030_IG08:
        cmp      ebp, 3
-       je       G_M61030_IG23
-						;; size=9 bbWeight=0.96 PerfScore 1.20
+       je       SHORT G_M61030_IG20
+						;; size=5 bbWeight=0.96 PerfScore 1.20
 G_M61030_IG09:
        cmp      ebp, edi
-       ja       G_M61030_IG35
-       mov      eax, ebp
-       xor      edx, edx
-       dec      eax
-       test     eax, eax
-       jle      SHORT G_M61030_IG22
-						;; size=18 bbWeight=0.87 PerfScore 2.83
-G_M61030_IG10:
-       lea      ecx, [rdx+0x01]
-       movsxd   r8, ecx
-       mov      r8d, dword ptr [rsi+4*r8]
-       jmp      SHORT G_M61030_IG12
-						;; size=12 bbWeight=8.75 PerfScore 41.57
-G_M61030_IG11:
-       lea      r10d, [rdx+0x01]
-       movsxd   r10, r10d
-       lea      r10, bword ptr [rsi+4*r10]
-       movsxd   r9, edx
-       mov      r9d, dword ptr [rsi+4*r9]
-       mov      dword ptr [r10], r9d
+       ja       G_M61030_IG34
+       mov      edx, ebp
+       xor      eax, eax
        dec      edx
-						;; size=23 bbWeight=25.60 PerfScore 121.61
-G_M61030_IG12:
        test     edx, edx
-       jl       SHORT G_M61030_IG15
-						;; size=4 bbWeight=34.35 PerfScore 42.94
+       jle      SHORT G_M61030_IG19
+						;; size=18 bbWeight=0.87 PerfScore 2.82
+G_M61030_IG10:
+       lea      r10d, [rax+0x01]
+       movsxd   rcx, r10d
+       mov      ecx, dword ptr [rsi+4*rcx]
+       jmp      SHORT G_M61030_IG12
+						;; size=12 bbWeight=8.85 PerfScore 42.02
+G_M61030_IG11:
+       lea      r8d, [rax+0x01]
+       movsxd   r8, r8d
+       lea      r8, bword ptr [rsi+4*r8]
+       movsxd   r9, eax
+       mov      r9d, dword ptr [rsi+4*r9]
+       mov      dword ptr [r8], r9d
+       dec      eax
+						;; size=23 bbWeight=24.73 PerfScore 117.47
+G_M61030_IG12:
+       test     eax, eax
+       jl       SHORT G_M61030_IG14
+						;; size=4 bbWeight=33.77 PerfScore 42.21
 G_M61030_IG13:
-       movsxd   r10, edx
-       mov      r10d, dword ptr [rsi+4*r10]
-       cmp      r8d, r10d
-       jge      SHORT G_M61030_IG17
-						;; size=12 bbWeight=32.74 PerfScore 114.59
+       movsxd   r8, eax
+       mov      r8d, dword ptr [rsi+4*r8]
+       cmp      ecx, r8d
+       jl       SHORT G_M61030_IG11
+						;; size=12 bbWeight=32.00 PerfScore 111.99
 G_M61030_IG14:
-       jmp      SHORT G_M61030_IG11
-						;; size=2 bbWeight=19.75 PerfScore 39.51
-G_M61030_IG15:
-       inc      edx
-       movsxd   rdx, edx
-       mov      dword ptr [rsi+4*rdx], r8d
-       mov      edx, ecx
-       cmp      edx, eax
+       inc      eax
+       cdqe     
+       mov      dword ptr [rsi+4*rax], ecx
+       mov      eax, r10d
+       cmp      eax, edx
        jl       SHORT G_M61030_IG10
-						;; size=15 bbWeight=32.69 PerfScore 98.07
-G_M61030_IG16:
-       jmp      SHORT G_M61030_IG22
+						;; size=14 bbWeight=12.38 PerfScore 37.14
+G_M61030_IG15:
+       jmp      SHORT G_M61030_IG19
 						;; size=2 bbWeight=0.87 PerfScore 1.74
-G_M61030_IG17:
-       cmp      r8d, r10d
-       jle      SHORT G_M61030_IG15
-						;; size=5 bbWeight=12.93 PerfScore 16.17
-G_M61030_IG18:
-       jmp      SHORT G_M61030_IG15
-						;; size=2 bbWeight=12.93 PerfScore 25.85
-G_M61030_IG19:
+G_M61030_IG16:
        lea      rcx, bword ptr [rsi+0x04]
        cmp      byte  ptr [rsi], sil
        mov      eax, dword ptr [rcx]
        cmp      dword ptr [rsi], eax
-       jl       SHORT G_M61030_IG22
+       jl       SHORT G_M61030_IG19
 						;; size=13 bbWeight=0.02 PerfScore 0.21
-G_M61030_IG20:
+G_M61030_IG17:
        cmp      dword ptr [rsi], eax
-       jle      SHORT G_M61030_IG22
+       jle      SHORT G_M61030_IG19
 						;; size=4 bbWeight=0.01 PerfScore 0.03
-G_M61030_IG21:
+G_M61030_IG18:
        mov      eax, dword ptr [rsi]
        mov      edx, dword ptr [rcx]
        mov      dword ptr [rsi], edx
        mov      dword ptr [rcx], eax
 						;; size=8 bbWeight=0.01 PerfScore 0.06
-G_M61030_IG22:
+G_M61030_IG19:
        add      rsp, 48
        pop      rbx
        pop      rbp
@@ -941,80 +931,87 @@ G_M61030_IG22:
        pop      r14
        ret      
 						;; size=11 bbWeight=0.02 PerfScore 0.08
-G_M61030_IG23:
+G_M61030_IG20:
        cmp      edi, 2
-       jbe      SHORT G_M61030_IG33
+       jbe      SHORT G_M61030_IG32
        lea      rax, bword ptr [rsi+0x08]
        lea      rdx, bword ptr [rsi+0x04]
        cmp      byte  ptr [rsi], sil
        mov      ecx, dword ptr [rdx]
        cmp      dword ptr [rsi], ecx
-       jl       SHORT G_M61030_IG25
+       jge      SHORT G_M61030_IG28
 						;; size=22 bbWeight=0.09 PerfScore 0.98
-G_M61030_IG24:
-       cmp      dword ptr [rsi], ecx
-       jg       SHORT G_M61030_IG28
-						;; size=4 bbWeight=0.03 PerfScore 0.14
-G_M61030_IG25:
+G_M61030_IG21:
+       mov      r8d, dword ptr [rax]
+       cmp      dword ptr [rsi], r8d
+       jge      SHORT G_M61030_IG30
+						;; size=8 bbWeight=0.09 PerfScore 0.53
+G_M61030_IG22:
        mov      ecx, dword ptr [rax]
-       cmp      dword ptr [rsi], ecx
-       jl       SHORT G_M61030_IG30
-						;; size=6 bbWeight=0.09 PerfScore 0.52
-G_M61030_IG26:
-       cmp      dword ptr [rsi], ecx
-       jle      SHORT G_M61030_IG30
-						;; size=4 bbWeight=0.03 PerfScore 0.14
-G_M61030_IG27:
-       jmp      SHORT G_M61030_IG29
+       mov      r10d, dword ptr [rdx]
+       cmp      r10d, ecx
+       jl       SHORT G_M61030_IG19
+						;; size=10 bbWeight=0.09 PerfScore 0.46
+G_M61030_IG23:
+       cmp      r10d, ecx
+       jle      SHORT G_M61030_IG19
+						;; size=5 bbWeight=0.03 PerfScore 0.04
+G_M61030_IG24:
+       jmp      SHORT G_M61030_IG27
 						;; size=2 bbWeight=0.03 PerfScore 0.07
-G_M61030_IG28:
+G_M61030_IG25:
        mov      ecx, dword ptr [rsi]
        mov      r8d, dword ptr [rdx]
        mov      dword ptr [rsi], r8d
        mov      dword ptr [rdx], ecx
-       jmp      SHORT G_M61030_IG25
+       jmp      SHORT G_M61030_IG21
 						;; size=12 bbWeight=0.04 PerfScore 0.32
-G_M61030_IG29:
+G_M61030_IG26:
        mov      ecx, dword ptr [rsi]
        mov      r8d, dword ptr [rax]
        mov      dword ptr [rsi], r8d
        mov      dword ptr [rax], ecx
-						;; size=10 bbWeight=0.04 PerfScore 0.24
-G_M61030_IG30:
-       mov      ecx, dword ptr [rax]
-       mov      r8d, dword ptr [rdx]
-       cmp      r8d, ecx
-       jl       SHORT G_M61030_IG22
-						;; size=10 bbWeight=0.09 PerfScore 0.46
-G_M61030_IG31:
-       cmp      r8d, ecx
-       jle      SHORT G_M61030_IG22
-						;; size=5 bbWeight=0.03 PerfScore 0.04
-G_M61030_IG32:
+       jmp      SHORT G_M61030_IG22
+						;; size=12 bbWeight=0.04 PerfScore 0.32
+G_M61030_IG27:
        mov      ecx, dword ptr [rax]
        mov      dword ptr [rdx], ecx
-       mov      dword ptr [rax], r8d
-       jmp      SHORT G_M61030_IG22
+       mov      dword ptr [rax], r10d
+       jmp      SHORT G_M61030_IG19
 						;; size=9 bbWeight=0.04 PerfScore 0.24
-G_M61030_IG33:
+G_M61030_IG28:
+       cmp      dword ptr [rsi], ecx
+       jle      SHORT G_M61030_IG21
+						;; size=4 bbWeight=0.03 PerfScore 0.14
+G_M61030_IG29:
+       jmp      SHORT G_M61030_IG25
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M61030_IG30:
+       cmp      dword ptr [rsi], r8d
+       jle      SHORT G_M61030_IG22
+						;; size=5 bbWeight=0.03 PerfScore 0.14
+G_M61030_IG31:
+       jmp      SHORT G_M61030_IG26
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M61030_IG32:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M61030_IG34:
+G_M61030_IG33:
        cmp      ebp, edi
-       ja       SHORT G_M61030_IG35
+       ja       SHORT G_M61030_IG34
        mov      rcx, rsi
        mov      eax, ebp
        mov      bword ptr [rsp+0x20], rcx
        mov      dword ptr [rsp+0x28], eax
        lea      rcx, [rsp+0x20]
        call     [System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:HeapSort(System.Span`1[System.Collections.IntStruct])]
-       jmp      G_M61030_IG22
+       jmp      G_M61030_IG19
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M61030_IG35:
+G_M61030_IG34:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 423, prolog size 19, PerfScore 552.24, instruction count 149, allocated bytes for code 423 (MethodHash=a0751199) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int) (Tier1)
+; Total bytes of code 412, prolog size 19, PerfScore 402.74, instruction count 148, allocated bytes for code 415 (MethodHash=a0751199) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int) (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Sort<IntStruct>.List(Size: 512)``

Hot functions:

- (55.48%) ``System.Collections.Generic.GenericArraySortHelper`1.PickPivotAndPartition`` (Tier-1)
  - **Has diffs**
- (35.16%) ``System.Collections.Generic.GenericArraySortHelper`1.IntroSort`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct].PickPivotAndPartition(value class System.Span`1<!0>)``

```diff
 ; Total bytes of code 759, prolog size 51, PerfScore 159.89, instruction count 159, allocated bytes for code 759 (MethodHash=e6183bb7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:PickPivotAndPartition(System.Span`1[System.Collections.IntStruct]):int (Instrumented Tier0)
 ; ============================================================
 
+; Assembly listing for method System.Collections.Generic.GenericArraySortHelper`1[BenchmarkDotNet.Reports.Measurement]:PickPivotAndPartition(System.Span`1[BenchmarkDotNet.Reports.Measurement]):int (Instrumented Tier0)
+; Emitting BLENDED_CODE for X64 with AVX - Windows
+; Instrumented Tier0 code
+; rbp based frame
+; partially interruptible
+; Final local variable assignments
+;
+;  V00 arg0         [V00    ] (  1,  1   )   byref  ->  [rbp+0x10]  do-not-enreg[] ld-addr-op
+;  V01 loc0         [V01    ] (  1,  1   )   byref  ->  [rbp-0x40]  do-not-enreg[] must-init
+;  V02 loc1         [V02    ] (  1,  1   )   byref  ->  [rbp-0x48]  do-not-enreg[] must-init
+;  V03 loc2         [V03    ] (  1,  1   )   byref  ->  [rbp-0x50]  do-not-enreg[] must-init
+;  V04 loc3         [V04    ] (  1,  1   )   byref  ->  [rbp-0x58]  do-not-enreg[] must-init
+;  V05 loc4         [V05    ] (  1,  1   )  struct (32) [rbp-0x78]  do-not-enreg[XS] addr-exposed ld-addr-op <BenchmarkDotNet.Reports.Measurement>
+;  V06 loc5         [V06    ] (  1,  1   )   byref  ->  [rbp-0x80]  do-not-enreg[] must-init
+;  V07 loc6         [V07    ] (  1,  1   )   byref  ->  [rbp-0x88]  do-not-enreg[] must-init
+;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
+;  V09 tmp1         [V09    ] (  1,  1   )   byref  ->  [rbp-0x90]  do-not-enreg[] must-init "DUP instruction"
+;  V10 tmp2         [V10    ] (  1,  1   )   byref  ->  [rbp-0x98]  do-not-enreg[] must-init "DUP instruction"
+;  V11 tmp3         [V11    ] (  1,  1   )     int  ->  [rbp-0xA0]  do-not-enreg[X] addr-exposed "patchpoint counter"
+;  V12 tmp4         [V12    ] (  1,  1   )  struct (16) [rbp-0xB0]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.Span`1[BenchmarkDotNet.Reports.Measurement]>
+;  V13 tmp5         [V13    ] (  1,  1   )    long  ->  [rbp-0xB8]  "ReplaceWithLclVar is creating a new local variable"
+;
+; Lcl frame size = 224
+
+G_M40648_IG01:
+       push     rbp
+       sub      rsp, 224
+       lea      rbp, [rsp+0xE0]
+       vxorps   xmm4, xmm4, xmm4
+       vmovdqu  ymmword ptr [rbp-0xB0], ymm4
+       vmovdqu  ymmword ptr [rbp-0x90], ymm4
+       vmovdqu  ymmword ptr [rbp-0x70], ymm4
+       vmovdqa  xmmword ptr [rbp-0x50], xmm4
+       xor      eax, eax
+       mov      qword ptr [rbp-0x40], rax
+       mov      bword ptr [rbp+0x10], rcx
+						;; size=56 bbWeight=1 PerfScore 12.33
+G_M40648_IG02:
+       mov      rax, bword ptr [rbp+0x10]
+						;; size=4 bbWeight=1 PerfScore 1.00
+G_M40648_IG03:
+       vmovdqu  xmm0, xmmword ptr [rax]
+       vmovdqu  xmmword ptr [rbp-0xB0], xmm0
+						;; size=12 bbWeight=1 PerfScore 5.00
+G_M40648_IG04:
+       lea      rcx, [rbp-0xB0]
+       call     [<unknown method>]
+       mov      bword ptr [rbp-0x40], rax
+       mov      rax, bword ptr [rbp+0x10]
+       mov      eax, dword ptr [rax+0x08]
+       dec      eax
+       cdqe     
+       shl      rax, 5
+       add      rax, bword ptr [rbp-0x40]
+       mov      bword ptr [rbp-0x48], rax
+       mov      rax, bword ptr [rbp+0x10]
+       mov      eax, dword ptr [rax+0x08]
+       dec      eax
+       sar      eax, 1
+       cdqe     
+       shl      rax, 5
+       add      rax, bword ptr [rbp-0x40]
+       mov      bword ptr [rbp-0x50], rax
+       mov      rcx, bword ptr [rbp-0x40]
+       mov      rdx, bword ptr [rbp-0x50]
+       call     [<unknown method>]
+       mov      rcx, bword ptr [rbp-0x40]
+       mov      rdx, bword ptr [rbp-0x48]
+       call     [<unknown method>]
+       mov      rcx, bword ptr [rbp-0x50]
+       mov      rdx, bword ptr [rbp-0x48]
+       call     [<unknown method>]
+       mov      rax, bword ptr [rbp+0x10]
+       mov      eax, dword ptr [rax+0x08]
+       add      eax, -2
+       cdqe     
+       shl      rax, 5
+       add      rax, bword ptr [rbp-0x40]
+       mov      bword ptr [rbp-0x58], rax
+       mov      rax, bword ptr [rbp-0x50]
+       vmovdqu  ymm0, ymmword ptr [rax]
+       vmovdqu  ymmword ptr [rbp-0x78], ymm0
+       mov      rcx, bword ptr [rbp-0x50]
+       mov      rdx, bword ptr [rbp-0x58]
+       call     [<unknown method>]
+       mov      rax, bword ptr [rbp-0x40]
+       mov      bword ptr [rbp-0x80], rax
+       mov      rax, bword ptr [rbp-0x58]
+       mov      bword ptr [rbp-0x88], rax
+       mov      dword ptr [rbp-0xA0], 0x3E8
+       jmp      G_M40648_IG14
+						;; size=192 bbWeight=1 PerfScore 60.00
+G_M40648_IG05:
+       mov      eax, dword ptr [rbp-0xA0]
+       dec      eax
+       mov      dword ptr [rbp-0xA0], eax
+       cmp      dword ptr [rbp-0xA0], 0
+       jg       SHORT G_M40648_IG07
+						;; size=23 bbWeight=1 PerfScore 5.25
+G_M40648_IG06:
+       lea      rcx, [rbp-0xA0]
+       mov      edx, 181
+       call     CORINFO_HELP_PATCHPOINT
+						;; size=17 bbWeight=0.01 PerfScore 0.02
+G_M40648_IG07:
+       mov      rax, bword ptr [rbp-0x80]
+       cmp      rax, bword ptr [rbp-0x58]
+       jae      SHORT G_M40648_IG09
+       mov      rax, bword ptr [rbp-0x80]
+       add      rax, 32
+       mov      bword ptr [rbp-0x98], rax
+       mov      rax, bword ptr [rbp-0x98]
+       mov      bword ptr [rbp-0x80], rax
+       lea      rcx, [rbp-0x78]
+       mov      rdx, bword ptr [rbp-0x98]
+       call     [<unknown method>]
+       test     eax, eax
+       jne      G_M40648_IG23
+						;; size=61 bbWeight=1 PerfScore 14.00
+G_M40648_IG08:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+						;; size=15 bbWeight=0.50 PerfScore 0.62
+G_M40648_IG09:
+       mov      eax, dword ptr [rbp-0xA0]
+       dec      eax
+       mov      dword ptr [rbp-0xA0], eax
+       cmp      dword ptr [rbp-0xA0], 0
+       jg       SHORT G_M40648_IG11
+						;; size=23 bbWeight=1 PerfScore 5.25
+G_M40648_IG10:
+       lea      rcx, [rbp-0xA0]
+       mov      edx, 211
+       call     CORINFO_HELP_PATCHPOINT
+						;; size=17 bbWeight=0.01 PerfScore 0.02
+G_M40648_IG11:
+       mov      rax, bword ptr [rbp-0x88]
+       cmp      rax, bword ptr [rbp-0x40]
+       jbe      G_M40648_IG22
+       mov      eax, 32
+       neg      rax
+       add      rax, bword ptr [rbp-0x88]
+       mov      bword ptr [rbp-0x90], rax
+       mov      rax, bword ptr [rbp-0x90]
+       mov      bword ptr [rbp-0x88], rax
+       lea      rcx, [rbp-0x78]
+       mov      rdx, bword ptr [rbp-0x90]
+       call     [<unknown method>]
+       test     eax, eax
+       jne      G_M40648_IG21
+						;; size=78 bbWeight=1 PerfScore 15.25
+G_M40648_IG12:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+						;; size=15 bbWeight=0.50 PerfScore 0.62
+G_M40648_IG13:
+       mov      rax, bword ptr [rbp-0x80]
+       cmp      rax, bword ptr [rbp-0x88]
+       jae      G_M40648_IG20
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      rcx, bword ptr [rbp-0x80]
+       mov      rdx, bword ptr [rbp-0x88]
+       call     [<unknown method>]
+						;; size=49 bbWeight=1 PerfScore 10.25
+G_M40648_IG14:
+       mov      eax, dword ptr [rbp-0xA0]
+       dec      eax
+       mov      dword ptr [rbp-0xA0], eax
+       cmp      dword ptr [rbp-0xA0], 0
+       jg       SHORT G_M40648_IG16
+						;; size=23 bbWeight=1 PerfScore 5.25
+G_M40648_IG15:
+       lea      rcx, [rbp-0xA0]
+       mov      edx, 261
+       call     CORINFO_HELP_PATCHPOINT
+						;; size=17 bbWeight=0.01 PerfScore 0.02
+G_M40648_IG16:
+       mov      rax, bword ptr [rbp-0x80]
+       cmp      rax, bword ptr [rbp-0x88]
+       jb       G_M40648_IG05
+						;; size=17 bbWeight=1 PerfScore 4.00
+G_M40648_IG17:
+       mov      rax, bword ptr [rbp-0x80]
+       cmp      rax, bword ptr [rbp-0x58]
+       je       SHORT G_M40648_IG18
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      rcx, bword ptr [rbp-0x80]
+       mov      rdx, bword ptr [rbp-0x58]
+       call     [<unknown method>]
+						;; size=39 bbWeight=1 PerfScore 10.25
+G_M40648_IG18:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      rax, bword ptr [rbp-0x80]
+       sub      rax, qword ptr [rbp-0x40]
+       mov      qword ptr [rbp-0xB8], rax
+       mov      rax, qword ptr [rbp-0xB8]
+       sar      rax, 63
+       and      rax, 31
+       add      rax, qword ptr [rbp-0xB8]
+       sar      rax, 5
+						;; size=56 bbWeight=1 PerfScore 9.50
+G_M40648_IG19:
+       vzeroupper 
+       add      rsp, 224
+       pop      rbp
+       ret      
+						;; size=12 bbWeight=1 PerfScore 2.75
+G_M40648_IG20:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      SHORT G_M40648_IG17
+						;; size=17 bbWeight=0.50 PerfScore 1.62
+G_M40648_IG21:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M40648_IG09
+						;; size=20 bbWeight=0.50 PerfScore 1.62
+G_M40648_IG22:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M40648_IG13
+						;; size=20 bbWeight=0.50 PerfScore 1.62
+G_M40648_IG23:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M40648_IG05
+						;; size=20 bbWeight=0.50 PerfScore 1.62
+
+; Total bytes of code 803, prolog size 52, PerfScore 167.89, instruction count 160, allocated bytes for code 803 (MethodHash=f0416137) for method System.Collections.Generic.GenericArraySortHelper`1[BenchmarkDotNet.Reports.Measurement]:PickPivotAndPartition(System.Span`1[BenchmarkDotNet.Reports.Measurement]):int (Instrumented Tier0)
+; ============================================================
+
 ; Assembly listing for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:PickPivotAndPartition(System.Span`1[System.Collections.IntStruct]):int (Instrumented Tier0)
 ; Emitting BLENDED_CODE for X64 with AVX - Windows
 ; Instrumented Tier0 code
@@ -471,26 +705,26 @@ G_M50248_IG23:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 158464
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 149248
 ; 8 inlinees with PGO data; 12 single block inlinees; 5 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T12] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 loc0         [V01,T09] ( 17, 60.33)   byref  ->  rdx         single-def
-;  V02 loc1         [V02,T15] (  7,  4.83)   byref  ->   r8         single-def
-;  V03 loc2         [V03,T13] ( 10,  7.22)   byref  ->  r10         single-def
-;  V04 loc3         [V04,T10] (  9, 40.98)   byref  ->  rcx         single-def
+;  V01 loc0         [V01,T07] ( 17, 49.63)   byref  ->  rdx         single-def
+;  V02 loc1         [V02,T15] (  7,  4.84)   byref  ->   r8         single-def
+;  V03 loc2         [V03,T13] ( 10,  7.23)   byref  ->  rcx         single-def
+;  V04 loc3         [V04,T08] (  9, 41.48)   byref  ->   r8         single-def
 ;* V05 loc4         [V05    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op <System.Collections.IntStruct>
-;  V06 loc5         [V06,T01] ( 12,181.25)   byref  ->  rax        
-;  V07 loc6         [V07,T00] (  8,202.32)   byref  ->  r10        
+;  V06 loc5         [V06,T01] ( 12,183.55)   byref  ->  rax        
+;  V07 loc6         [V07,T00] (  8,193.67)   byref  ->   r9        
 ;# V08 OutArgs      [V08    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T02] (  2,145.81)   byref  ->  r10         "dup spill"
-;  V10 tmp2         [V10,T03] (  2,132.02)   byref  ->  rax         "dup spill"
+;  V09 tmp1         [V09,T02] (  2,148.03)   byref  ->   r9         "dup spill"
+;  V10 tmp2         [V10,T03] (  2,133.90)   byref  ->  rax         "dup spill"
 ;* V11 tmp3         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V13 tmp5         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V15 tmp7         [V15,T22] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V15 tmp7         [V15,T25] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V16 tmp8         [V16    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V18 tmp10        [V18    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
@@ -504,42 +738,42 @@ G_M50248_IG23:
 ;* V26 tmp18        [V26    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V27 tmp19        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V28 tmp20        [V28    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V29 tmp21        [V29,T23] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V29 tmp21        [V29,T27] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V30 tmp22        [V30    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V31 tmp23        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp24        [V32    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V33 tmp25        [V33    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V34 tmp26        [V34    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V35 tmp27        [V35    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V36 tmp28        [V36,T08] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V36 tmp28        [V36,T10] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V37 tmp29        [V37    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V38 tmp30        [V38    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V39 tmp31        [V39    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V40 tmp32        [V40,T07] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V40 tmp32        [V40,T09] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V42 tmp34        [V42    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V43 tmp35        [V43    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
-;  V44 tmp36        [V44,T24] (  2,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V45 tmp37        [V45,T16] (  3,  3   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
-;  V46 tmp38        [V46,T04] (  5, 97.74)     int  ->   r9         "field V05._value (fldOffset=0x0)" P-INDEP
+;  V44 tmp36        [V44,T22] (  2,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V45 tmp37        [V45,T16] (  3,  3   )     int  ->  rax         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V46 tmp38        [V46,T04] (  4, 84.68)     int  ->  r10         "field V05._value (fldOffset=0x0)" P-INDEP
 ;* V47 tmp39        [V47    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V48 tmp40        [V48    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V49 tmp41        [V49    ] (  0,  0   )     int  ->  zero-ref    "field V12._value (fldOffset=0x0)" P-INDEP
-;  V50 tmp42        [V50,T19] (  3,  2.39)     int  ->  rax         "field V14._value (fldOffset=0x0)" P-INDEP
-;  V51 tmp43        [V51,T28] (  2,  0.92)     int  ->  rax         "field V18._value (fldOffset=0x0)" P-INDEP
+;  V50 tmp42        [V50,T19] (  3,  2.39)     int  ->  r10         "field V14._value (fldOffset=0x0)" P-INDEP
+;  V51 tmp43        [V51,T28] (  2,  0.92)     int  ->   r9         "field V18._value (fldOffset=0x0)" P-INDEP
 ;* V52 tmp44        [V52    ] (  0,  0   )     int  ->  zero-ref    "field V19._value (fldOffset=0x0)" P-INDEP
-;  V53 tmp45        [V53,T20] (  3,  2.39)     int  ->  rax         "field V21._value (fldOffset=0x0)" P-INDEP
-;  V54 tmp46        [V54,T29] (  2,  0.92)     int  ->  rax         "field V25._value (fldOffset=0x0)" P-INDEP
+;  V53 tmp45        [V53,T20] (  3,  2.39)     int  ->   r9         "field V21._value (fldOffset=0x0)" P-INDEP
+;  V54 tmp46        [V54,T29] (  2,  0.92)     int  ->  r10         "field V25._value (fldOffset=0x0)" P-INDEP
 ;* V55 tmp47        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V26._value (fldOffset=0x0)" P-INDEP
-;  V56 tmp48        [V56,T21] (  3,  2.39)     int  ->  rax         "field V28._value (fldOffset=0x0)" P-INDEP
-;  V57 tmp49        [V57,T30] (  2,  0.92)     int  ->  rax         "field V32._value (fldOffset=0x0)" P-INDEP
-;  V58 tmp50        [V58,T25] (  2,  2   )     int  ->  rax         "field V33._value (fldOffset=0x0)" P-INDEP
-;  V59 tmp51        [V59,T06] (  3, 78.98)     int  ->   r8         "field V35._value (fldOffset=0x0)" P-INDEP
-;  V60 tmp52        [V60,T05] (  3, 87.22)     int  ->   r8         "field V39._value (fldOffset=0x0)" P-INDEP
-;  V61 tmp53        [V61,T11] (  2, 29.50)     int  ->   r8         "field V42._value (fldOffset=0x0)" P-INDEP
-;  V62 tmp54        [V62,T27] (  2,  1.94)     int  ->  r10         "field V43._value (fldOffset=0x0)" P-INDEP
+;  V56 tmp48        [V56,T21] (  3,  2.39)     int  ->  r10         "field V28._value (fldOffset=0x0)" P-INDEP
+;  V57 tmp49        [V57,T30] (  2,  0.92)     int  ->   r9         "field V32._value (fldOffset=0x0)" P-INDEP
+;  V58 tmp50        [V58,T23] (  2,  2   )     int  ->  rax         "field V33._value (fldOffset=0x0)" P-INDEP
+;  V59 tmp51        [V59,T06] (  3, 80.15)     int  ->  rcx         "field V35._value (fldOffset=0x0)" P-INDEP
+;  V60 tmp52        [V60,T05] (  2, 74.02)     int  ->  rcx         "field V39._value (fldOffset=0x0)" P-INDEP
+;  V61 tmp53        [V61,T11] (  2, 29.76)     int  ->  rcx         "field V42._value (fldOffset=0x0)" P-INDEP
+;  V62 tmp54        [V62,T24] (  2,  1.97)     int  ->  r10         "field V43._value (fldOffset=0x0)" P-INDEP
 ;* V63 tmp55        [V63    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[System.Collections.IntStruct]>
-;  V64 cse0         [V64,T17] (  3,  3   )     int  ->  rax         "CSE #01: moderate"
+;  V64 cse0         [V64,T17] (  3,  3   )     int  ->  rcx         "CSE #01: moderate"
 ;  V65 cse1         [V65,T18] (  3,  3   )     int  ->  rax         "CSE #05: moderate"
 ;  V66 rat0         [V66,T14] (  3,  6   )    long  ->  rax         "ReplaceWithLclVar is creating a new local variable"
 ;
@@ -549,383 +783,137 @@ G_M50248_IG01:
 						;; size=0 bbWeight=1 PerfScore 0.00
 G_M50248_IG02:
        mov      rdx, bword ptr [rcx]
-       mov      ecx, dword ptr [rcx+0x08]
-       lea      eax, [rcx-0x01]
+       mov      eax, dword ptr [rcx+0x08]
+       lea      ecx, [rax-0x01]
+       movsxd   r8, ecx
+       lea      r8, bword ptr [rdx+4*r8]
+       sar      ecx, 1
+       movsxd   rcx, ecx
+       lea      rcx, bword ptr [rdx+4*rcx]
+       cmp      byte  ptr [rdx], dl
+       mov      r10d, dword ptr [rcx]
+       cmp      dword ptr [rdx], r10d
+       jge      SHORT G_M50248_IG10
+						;; size=35 bbWeight=1 PerfScore 15.50
+G_M50248_IG03:
+       mov      r9d, dword ptr [r8]
+       cmp      dword ptr [rdx], r9d
+       jge      SHORT G_M50248_IG15
+						;; size=8 bbWeight=1 PerfScore 6.00
+G_M50248_IG04:
+       mov      r10d, dword ptr [r8]
+       cmp      dword ptr [rcx], r10d
+       jge      G_M50248_IG18
+						;; size=12 bbWeight=1 PerfScore 6.00
+G_M50248_IG05:
+       add      eax, -2
        movsxd   r8, eax
        lea      r8, bword ptr [rdx+4*r8]
-       sar      eax, 1
-       cdqe     
-       lea      r10, bword ptr [rdx+4*rax]
-       cmp      byte  ptr [rdx], dl
-       mov      eax, dword ptr [r10]
-       cmp      dword ptr [rdx], eax
-       jl       SHORT G_M50248_IG04
-						;; size=33 bbWeight=1 PerfScore 15.50
-G_M50248_IG03:
-       cmp      dword ptr [rdx], eax
-       jg       SHORT G_M50248_IG07
-						;; size=4 bbWeight=0.39 PerfScore 1.56
-G_M50248_IG04:
-       mov      eax, dword ptr [r8]
-       cmp      dword ptr [rdx], eax
-       jl       SHORT G_M50248_IG10
-						;; size=7 bbWeight=1 PerfScore 6.00
-G_M50248_IG05:
-       cmp      dword ptr [rdx], eax
-       jle      SHORT G_M50248_IG10
-						;; size=4 bbWeight=0.39 PerfScore 1.56
-G_M50248_IG06:
-       jmp      SHORT G_M50248_IG20
-       align    [0 bytes for IG08]
-						;; size=2 bbWeight=0.39 PerfScore 0.78
-G_M50248_IG07:
-       mov      eax, dword ptr [rdx]
-       mov      r9d, dword ptr [r10]
-       mov      dword ptr [rdx], r9d
-       mov      dword ptr [r10], eax
-       jmp      SHORT G_M50248_IG04
-						;; size=13 bbWeight=0.46 PerfScore 3.66
-G_M50248_IG08:
-       cmp      r10, rdx
-       jbe      SHORT G_M50248_IG22
-						;; size=5 bbWeight=47.71 PerfScore 59.64
-G_M50248_IG09:
-       jmp      SHORT G_M50248_IG17
-						;; size=2 bbWeight=36.45 PerfScore 72.90
-G_M50248_IG10:
-       mov      eax, dword ptr [r8]
-       cmp      dword ptr [r10], eax
-       jl       SHORT G_M50248_IG12
-						;; size=8 bbWeight=1 PerfScore 6.00
-G_M50248_IG11:
-       cmp      dword ptr [r10], eax
-       jg       SHORT G_M50248_IG21
-						;; size=5 bbWeight=0.39 PerfScore 1.56
-G_M50248_IG12:
-       add      ecx, -2
-       movsxd   rax, ecx
-       lea      rcx, bword ptr [rdx+4*rax]
-       mov      eax, dword ptr [r10]
-       mov      r9d, eax
-       mov      r8d, dword ptr [rcx]
-       mov      dword ptr [r10], r8d
-       mov      dword ptr [rcx], eax
+       mov      eax, dword ptr [rcx]
+       mov      r10d, eax
+       mov      r9d, dword ptr [r8]
+       mov      dword ptr [rcx], r9d
+       mov      dword ptr [r8], eax
        mov      rax, rdx
-       mov      r10, rcx
-       cmp      rdx, rcx
-       jae      SHORT G_M50248_IG24
-						;; size=35 bbWeight=1 PerfScore 9.00
-G_M50248_IG13:
-       cmp      rax, rcx
-       jae      SHORT G_M50248_IG08
-						;; size=5 bbWeight=33.04 PerfScore 41.30
-G_M50248_IG14:
+       mov      r9, r8
+       cmp      rdx, r8
+       jae      G_M50248_IG20
+						;; size=39 bbWeight=1 PerfScore 9.00
+G_M50248_IG06:
+       cmp      rax, r8
+       jae      SHORT G_M50248_IG12
+						;; size=5 bbWeight=33.51 PerfScore 41.89
+G_M50248_IG07:
        add      rax, 4
-       mov      r8d, dword ptr [rax]
-       cmp      r9d, r8d
-       jl       SHORT G_M50248_IG08
-						;; size=12 bbWeight=33.00 PerfScore 115.52
+       mov      ecx, dword ptr [rax]
+       cmp      r10d, ecx
+       jl       SHORT G_M50248_IG12
+						;; size=11 bbWeight=33.48 PerfScore 117.16
+G_M50248_IG08:
+       cmp      r10d, ecx
+       jle      SHORT G_M50248_IG12
+						;; size=5 bbWeight=13.20 PerfScore 16.50
+G_M50248_IG09:
+       jmp      SHORT G_M50248_IG06
+						;; size=2 bbWeight=13.19 PerfScore 26.38
+G_M50248_IG10:
+       cmp      dword ptr [rdx], r10d
+       jle      SHORT G_M50248_IG03
+						;; size=5 bbWeight=0.39 PerfScore 1.58
+G_M50248_IG11:
+       mov      r9d, dword ptr [rdx]
+       mov      r10d, dword ptr [rcx]
+       mov      dword ptr [rdx], r10d
+       mov      dword ptr [rcx], r9d
+       jmp      SHORT G_M50248_IG03
+       align    [0 bytes for IG12]
+						;; size=14 bbWeight=0.46 PerfScore 3.67
+G_M50248_IG12:
+       cmp      r9, rdx
+       jbe      SHORT G_M50248_IG13
+       add      r9, -4
+       mov      ecx, dword ptr [r9]
+       cmp      r10d, ecx
+       jl       SHORT G_M50248_IG12
+						;; size=17 bbWeight=37.01 PerfScore 175.79
+G_M50248_IG13:
+       cmp      rax, r9
+       jae      SHORT G_M50248_IG20
+						;; size=5 bbWeight=14.88 PerfScore 18.60
+G_M50248_IG14:
+       jmp      SHORT G_M50248_IG17
+						;; size=2 bbWeight=14.88 PerfScore 29.76
 G_M50248_IG15:
-       cmp      r9d, r8d
-       jle      SHORT G_M50248_IG08
-						;; size=5 bbWeight=12.97 PerfScore 16.21
+       cmp      dword ptr [rdx], r9d
+       jle      SHORT G_M50248_IG04
+						;; size=5 bbWeight=0.39 PerfScore 1.58
 G_M50248_IG16:
-       jmp      SHORT G_M50248_IG13
-						;; size=2 bbWeight=12.96 PerfScore 25.92
-G_M50248_IG17:
-       add      r10, -4
-       mov      r8d, dword ptr [r10]
-       cmp      r9d, r8d
-       jl       SHORT G_M50248_IG08
-						;; size=12 bbWeight=36.45 PerfScore 127.58
-G_M50248_IG18:
-       cmp      r9d, r8d
-       jle      SHORT G_M50248_IG22
-						;; size=5 bbWeight=14.32 PerfScore 17.90
-G_M50248_IG19:
-       jmp      SHORT G_M50248_IG22
-						;; size=2 bbWeight=14.31 PerfScore 28.62
-G_M50248_IG20:
-       mov      eax, dword ptr [rdx]
+       mov      r10d, dword ptr [rdx]
        mov      r9d, dword ptr [r8]
        mov      dword ptr [rdx], r9d
-       mov      dword ptr [r8], eax
-       jmp      SHORT G_M50248_IG10
-						;; size=13 bbWeight=0.46 PerfScore 3.66
-G_M50248_IG21:
-       mov      eax, dword ptr [r10]
-       mov      r9d, dword ptr [r8]
-       mov      dword ptr [r10], r9d
-       mov      dword ptr [r8], eax
-       jmp      SHORT G_M50248_IG12
-						;; size=14 bbWeight=0.46 PerfScore 3.66
-G_M50248_IG22:
-       cmp      rax, r10
-       jae      SHORT G_M50248_IG24
-						;; size=5 bbWeight=14.75 PerfScore 18.44
-G_M50248_IG23:
-       mov      r8d, dword ptr [rax]
-       mov      r11d, dword ptr [r10]
+       mov      dword ptr [r8], r10d
+       jmp      G_M50248_IG04
+						;; size=17 bbWeight=0.46 PerfScore 3.67
+G_M50248_IG17:
+       mov      ecx, dword ptr [rax]
+       mov      r11d, dword ptr [r9]
        mov      dword ptr [rax], r11d
-       mov      dword ptr [r10], r8d
-       jmp      SHORT G_M50248_IG13
-						;; size=14 bbWeight=14.75 PerfScore 118.01
-G_M50248_IG24:
-       cmp      rax, rcx
-       je       SHORT G_M50248_IG26
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M50248_IG25:
-       mov      r10d, dword ptr [rax]
+       mov      dword ptr [r9], ecx
+       jmp      SHORT G_M50248_IG06
+						;; size=13 bbWeight=14.88 PerfScore 119.03
+G_M50248_IG18:
+       cmp      dword ptr [rcx], r10d
+       jle      G_M50248_IG05
+						;; size=9 bbWeight=0.39 PerfScore 1.58
+G_M50248_IG19:
        mov      r9d, dword ptr [rcx]
-       mov      dword ptr [rax], r9d
+       mov      r10d, dword ptr [r8]
        mov      dword ptr [rcx], r10d
-						;; size=12 bbWeight=0.97 PerfScore 5.81
-G_M50248_IG26:
+       mov      dword ptr [r8], r9d
+       jmp      G_M50248_IG05
+						;; size=17 bbWeight=0.46 PerfScore 3.67
+G_M50248_IG20:
+       cmp      rax, r8
+       je       SHORT G_M50248_IG22
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M50248_IG21:
+       mov      r10d, dword ptr [rax]
+       mov      r9d, dword ptr [r8]
+       mov      dword ptr [rax], r9d
+       mov      dword ptr [r8], r10d
+						;; size=12 bbWeight=0.98 PerfScore 5.91
+G_M50248_IG22:
        sub      rax, rdx
-       mov      rcx, rax
-       sar      rcx, 63
-       and      rcx, 3
-       add      rax, rcx
+       mov      r9, rax
+       sar      r9, 63
+       and      r9, 3
+       add      rax, r9
        sar      rax, 2
 						;; size=21 bbWeight=1 PerfScore 2.00
-G_M50248_IG27:
+G_M50248_IG23:
        ret      
 						;; size=1 bbWeight=1 PerfScore 1.00
 
-; Total bytes of code 246, prolog size 0, PerfScore 705.06, instruction count 92, allocated bytes for code 249 (MethodHash=e6183bb7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:PickPivotAndPartition(System.Span`1[System.Collections.IntStruct]):int (Tier1)
-; ============================================================
-
-; Assembly listing for method System.Collections.Generic.GenericArraySortHelper`1[BenchmarkDotNet.Reports.Measurement]:PickPivotAndPartition(System.Span`1[BenchmarkDotNet.Reports.Measurement]):int (Instrumented Tier0)
-; Emitting BLENDED_CODE for X64 with AVX - Windows
-; Instrumented Tier0 code
-; rbp based frame
-; partially interruptible
-; Final local variable assignments
-;
-;  V00 arg0         [V00    ] (  1,  1   )   byref  ->  [rbp+0x10]  do-not-enreg[] ld-addr-op
-;  V01 loc0         [V01    ] (  1,  1   )   byref  ->  [rbp-0x40]  do-not-enreg[] must-init
-;  V02 loc1         [V02    ] (  1,  1   )   byref  ->  [rbp-0x48]  do-not-enreg[] must-init
-;  V03 loc2         [V03    ] (  1,  1   )   byref  ->  [rbp-0x50]  do-not-enreg[] must-init
-;  V04 loc3         [V04    ] (  1,  1   )   byref  ->  [rbp-0x58]  do-not-enreg[] must-init
-;  V05 loc4         [V05    ] (  1,  1   )  struct (32) [rbp-0x78]  do-not-enreg[XS] addr-exposed ld-addr-op <BenchmarkDotNet.Reports.Measurement>
-;  V06 loc5         [V06    ] (  1,  1   )   byref  ->  [rbp-0x80]  do-not-enreg[] must-init
-;  V07 loc6         [V07    ] (  1,  1   )   byref  ->  [rbp-0x88]  do-not-enreg[] must-init
-;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09    ] (  1,  1   )   byref  ->  [rbp-0x90]  do-not-enreg[] must-init "DUP instruction"
-;  V10 tmp2         [V10    ] (  1,  1   )   byref  ->  [rbp-0x98]  do-not-enreg[] must-init "DUP instruction"
-;  V11 tmp3         [V11    ] (  1,  1   )     int  ->  [rbp-0xA0]  do-not-enreg[X] addr-exposed "patchpoint counter"
-;  V12 tmp4         [V12    ] (  1,  1   )  struct (16) [rbp-0xB0]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.Span`1[BenchmarkDotNet.Reports.Measurement]>
-;  V13 tmp5         [V13    ] (  1,  1   )    long  ->  [rbp-0xB8]  "ReplaceWithLclVar is creating a new local variable"
-;
-; Lcl frame size = 224
-
-G_M40648_IG01:
-       push     rbp
-       sub      rsp, 224
-       lea      rbp, [rsp+0xE0]
-       vxorps   xmm4, xmm4, xmm4
-       vmovdqu  ymmword ptr [rbp-0xB0], ymm4
-       vmovdqu  ymmword ptr [rbp-0x90], ymm4
-       vmovdqu  ymmword ptr [rbp-0x70], ymm4
-       vmovdqa  xmmword ptr [rbp-0x50], xmm4
-       xor      eax, eax
-       mov      qword ptr [rbp-0x40], rax
-       mov      bword ptr [rbp+0x10], rcx
-						;; size=56 bbWeight=1 PerfScore 12.33
-G_M40648_IG02:
-       mov      rax, bword ptr [rbp+0x10]
-						;; size=4 bbWeight=1 PerfScore 1.00
-G_M40648_IG03:
-       vmovdqu  xmm0, xmmword ptr [rax]
-       vmovdqu  xmmword ptr [rbp-0xB0], xmm0
-						;; size=12 bbWeight=1 PerfScore 5.00
-G_M40648_IG04:
-       lea      rcx, [rbp-0xB0]
-       call     [<unknown method>]
-       mov      bword ptr [rbp-0x40], rax
-       mov      rax, bword ptr [rbp+0x10]
-       mov      eax, dword ptr [rax+0x08]
-       dec      eax
-       cdqe     
-       shl      rax, 5
-       add      rax, bword ptr [rbp-0x40]
-       mov      bword ptr [rbp-0x48], rax
-       mov      rax, bword ptr [rbp+0x10]
-       mov      eax, dword ptr [rax+0x08]
-       dec      eax
-       sar      eax, 1
-       cdqe     
-       shl      rax, 5
-       add      rax, bword ptr [rbp-0x40]
-       mov      bword ptr [rbp-0x50], rax
-       mov      rcx, bword ptr [rbp-0x40]
-       mov      rdx, bword ptr [rbp-0x50]
-       call     [<unknown method>]
-       mov      rcx, bword ptr [rbp-0x40]
-       mov      rdx, bword ptr [rbp-0x48]
-       call     [<unknown method>]
-       mov      rcx, bword ptr [rbp-0x50]
-       mov      rdx, bword ptr [rbp-0x48]
-       call     [<unknown method>]
-       mov      rax, bword ptr [rbp+0x10]
-       mov      eax, dword ptr [rax+0x08]
-       add      eax, -2
-       cdqe     
-       shl      rax, 5
-       add      rax, bword ptr [rbp-0x40]
-       mov      bword ptr [rbp-0x58], rax
-       mov      rax, bword ptr [rbp-0x50]
-       vmovdqu  ymm0, ymmword ptr [rax]
-       vmovdqu  ymmword ptr [rbp-0x78], ymm0
-       mov      rcx, bword ptr [rbp-0x50]
-       mov      rdx, bword ptr [rbp-0x58]
-       call     [<unknown method>]
-       mov      rax, bword ptr [rbp-0x40]
-       mov      bword ptr [rbp-0x80], rax
-       mov      rax, bword ptr [rbp-0x58]
-       mov      bword ptr [rbp-0x88], rax
-       mov      dword ptr [rbp-0xA0], 0x3E8
-       jmp      G_M40648_IG14
-						;; size=192 bbWeight=1 PerfScore 60.00
-G_M40648_IG05:
-       mov      eax, dword ptr [rbp-0xA0]
-       dec      eax
-       mov      dword ptr [rbp-0xA0], eax
-       cmp      dword ptr [rbp-0xA0], 0
-       jg       SHORT G_M40648_IG07
-						;; size=23 bbWeight=1 PerfScore 5.25
-G_M40648_IG06:
-       lea      rcx, [rbp-0xA0]
-       mov      edx, 181
-       call     CORINFO_HELP_PATCHPOINT
-						;; size=17 bbWeight=0.01 PerfScore 0.02
-G_M40648_IG07:
-       mov      rax, bword ptr [rbp-0x80]
-       cmp      rax, bword ptr [rbp-0x58]
-       jae      SHORT G_M40648_IG09
-       mov      rax, bword ptr [rbp-0x80]
-       add      rax, 32
-       mov      bword ptr [rbp-0x98], rax
-       mov      rax, bword ptr [rbp-0x98]
-       mov      bword ptr [rbp-0x80], rax
-       lea      rcx, [rbp-0x78]
-       mov      rdx, bword ptr [rbp-0x98]
-       call     [<unknown method>]
-       test     eax, eax
-       jne      G_M40648_IG23
-						;; size=61 bbWeight=1 PerfScore 14.00
-G_M40648_IG08:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-						;; size=15 bbWeight=0.50 PerfScore 0.62
-G_M40648_IG09:
-       mov      eax, dword ptr [rbp-0xA0]
-       dec      eax
-       mov      dword ptr [rbp-0xA0], eax
-       cmp      dword ptr [rbp-0xA0], 0
-       jg       SHORT G_M40648_IG11
-						;; size=23 bbWeight=1 PerfScore 5.25
-G_M40648_IG10:
-       lea      rcx, [rbp-0xA0]
-       mov      edx, 211
-       call     CORINFO_HELP_PATCHPOINT
-						;; size=17 bbWeight=0.01 PerfScore 0.02
-G_M40648_IG11:
-       mov      rax, bword ptr [rbp-0x88]
-       cmp      rax, bword ptr [rbp-0x40]
-       jbe      G_M40648_IG22
-       mov      eax, 32
-       neg      rax
-       add      rax, bword ptr [rbp-0x88]
-       mov      bword ptr [rbp-0x90], rax
-       mov      rax, bword ptr [rbp-0x90]
-       mov      bword ptr [rbp-0x88], rax
-       lea      rcx, [rbp-0x78]
-       mov      rdx, bword ptr [rbp-0x90]
-       call     [<unknown method>]
-       test     eax, eax
-       jne      G_M40648_IG21
-						;; size=78 bbWeight=1 PerfScore 15.25
-G_M40648_IG12:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-						;; size=15 bbWeight=0.50 PerfScore 0.62
-G_M40648_IG13:
-       mov      rax, bword ptr [rbp-0x80]
-       cmp      rax, bword ptr [rbp-0x88]
-       jae      G_M40648_IG20
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      rcx, bword ptr [rbp-0x80]
-       mov      rdx, bword ptr [rbp-0x88]
-       call     [<unknown method>]
-						;; size=49 bbWeight=1 PerfScore 10.25
-G_M40648_IG14:
-       mov      eax, dword ptr [rbp-0xA0]
-       dec      eax
-       mov      dword ptr [rbp-0xA0], eax
-       cmp      dword ptr [rbp-0xA0], 0
-       jg       SHORT G_M40648_IG16
-						;; size=23 bbWeight=1 PerfScore 5.25
-G_M40648_IG15:
-       lea      rcx, [rbp-0xA0]
-       mov      edx, 261
-       call     CORINFO_HELP_PATCHPOINT
-						;; size=17 bbWeight=0.01 PerfScore 0.02
-G_M40648_IG16:
-       mov      rax, bword ptr [rbp-0x80]
-       cmp      rax, bword ptr [rbp-0x88]
-       jb       G_M40648_IG05
-						;; size=17 bbWeight=1 PerfScore 4.00
-G_M40648_IG17:
-       mov      rax, bword ptr [rbp-0x80]
-       cmp      rax, bword ptr [rbp-0x58]
-       je       SHORT G_M40648_IG18
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      rcx, bword ptr [rbp-0x80]
-       mov      rdx, bword ptr [rbp-0x58]
-       call     [<unknown method>]
-						;; size=39 bbWeight=1 PerfScore 10.25
-G_M40648_IG18:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      rax, bword ptr [rbp-0x80]
-       sub      rax, qword ptr [rbp-0x40]
-       mov      qword ptr [rbp-0xB8], rax
-       mov      rax, qword ptr [rbp-0xB8]
-       sar      rax, 63
-       and      rax, 31
-       add      rax, qword ptr [rbp-0xB8]
-       sar      rax, 5
-						;; size=56 bbWeight=1 PerfScore 9.50
-G_M40648_IG19:
-       vzeroupper 
-       add      rsp, 224
-       pop      rbp
-       ret      
-						;; size=12 bbWeight=1 PerfScore 2.75
-G_M40648_IG20:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M40648_IG17
-						;; size=17 bbWeight=0.50 PerfScore 1.62
-G_M40648_IG21:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M40648_IG09
-						;; size=20 bbWeight=0.50 PerfScore 1.62
-G_M40648_IG22:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M40648_IG13
-						;; size=20 bbWeight=0.50 PerfScore 1.62
-G_M40648_IG23:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M40648_IG05
-						;; size=20 bbWeight=0.50 PerfScore 1.62
-
-; Total bytes of code 803, prolog size 52, PerfScore 167.89, instruction count 160, allocated bytes for code 803 (MethodHash=f0416137) for method System.Collections.Generic.GenericArraySortHelper`1[BenchmarkDotNet.Reports.Measurement]:PickPivotAndPartition(System.Span`1[BenchmarkDotNet.Reports.Measurement]):int (Instrumented Tier0)
+; Total bytes of code 260, prolog size 0, PerfScore 607.52, instruction count 88, allocated bytes for code 268 (MethodHash=e6183bb7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:PickPivotAndPartition(System.Span`1[System.Collections.IntStruct]):int (Tier1)
 ; ============================================================
 


```

### ``[System.Private.CoreLib]System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct].IntroSort(value class System.Span`1<!0>,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 153320
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 158682
 ; 14 inlinees with PGO data; 18 single block inlinees; 5 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T10] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T11] (  6,  6.94)     int  ->  rbx        
-;  V02 loc0         [V02,T09] ( 13, 13.57)     int  ->  rbp        
-;  V03 loc1         [V03,T17] (  3,  3.96)     int  ->  r14        
+;  V01 arg1         [V01,T11] (  6,  6.89)     int  ->  rbx        
+;  V02 loc0         [V02,T08] ( 13, 13.48)     int  ->  rbp        
+;  V03 loc1         [V03,T17] (  3,  3.91)     int  ->  r14        
 ;  V04 loc2         [V04,T25] (  7,  0.42)   byref  ->  rax         single-def
 ;  V05 loc3         [V05,T26] (  6,  0.38)   byref  ->  rdx         single-def
 ;* V06 loc4         [V06    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V07 loc5         [V07,T19] (  3,  2.96)     int  ->  rcx        
+;  V07 loc5         [V07,T19] (  3,  2.91)     int  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.IntStruct]>
 ;* V10 tmp2         [V10    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.IntStruct]>
@@ -690,7 +690,7 @@ G_M61030_IG21:
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.IntStruct]>
 ;* V13 tmp5         [V13    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
-;  V15 tmp7         [V15,T34] (  4,  0.13)   byref  ->  rcx         single-def "Inlining Arg"
+;  V15 tmp7         [V15,T31] (  4,  0.13)   byref  ->  rcx         single-def "Inlining Arg"
 ;* V16 tmp8         [V16    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V17 tmp9         [V17    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
 ;* V18 tmp10        [V18,T39] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
@@ -700,7 +700,7 @@ G_M61030_IG21:
 ;* V22 tmp14        [V22    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V23 tmp15        [V23    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V24 tmp16        [V24    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V25 tmp17        [V25,T31] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V25 tmp17        [V25,T32] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V26 tmp18        [V26    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V27 tmp19        [V27    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V28 tmp20        [V28    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
@@ -714,17 +714,17 @@ G_M61030_IG21:
 ;* V36 tmp28        [V36    ] (  0,  0   )  struct ( 8) zero-ref    "spilling side-effects" <System.Collections.IntStruct>
 ;* V37 tmp29        [V37    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V38 tmp30        [V38    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V39 tmp31        [V39,T32] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V39 tmp31        [V39,T34] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V40 tmp32        [V40    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V42 tmp34        [V42    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Collections.IntStruct>
 ;* V43 tmp35        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V45 tmp37        [V45,T06] (  5, 84.03)     int  ->  rdx         "Inline stloc first use temp"
+;  V45 tmp37        [V45,T05] (  5, 44.06)     int  ->  rax         "Inline stloc first use temp"
 ;* V46 tmp38        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V47 tmp39        [V47    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Collections.IntStruct>
-;  V48 tmp40        [V48,T00] (  8,210.76)     int  ->  rdx         "Inline stloc first use temp"
-;  V49 tmp41        [V49,T02] (  2,102.03)   byref  ->  r10         "impAppendStmt"
+;  V48 tmp40        [V48,T00] (  8,189.01)     int  ->  rax         "Inline stloc first use temp"
+;  V49 tmp41        [V49,T02] (  2,100.93)   byref  ->   r8         "impAppendStmt"
 ;* V50 tmp42        [V50    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V51 tmp43        [V51    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V52 tmp44        [V52    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
@@ -732,18 +732,18 @@ G_M61030_IG21:
 ;* V54 tmp46        [V54    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V55 tmp47        [V55    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V56 tmp48        [V56    ] (  0,  0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.IntStruct>
-;* V57 tmp49        [V57,T05] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;* V57 tmp49        [V57,T06] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V58 tmp50        [V58    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V59 tmp51        [V59    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.IntStruct]>
 ;* V60 tmp52        [V60    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V61 tmp53        [V61    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V62 tmp54        [V62    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V63 tmp55        [V63    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V64 tmp56        [V64,T12] (  3,  7.91)     int  ->  rbp         "Inlining Arg"
+;  V64 tmp56        [V64,T12] (  3,  7.83)     int  ->  rbp         "Inlining Arg"
 ;* V65 tmp57        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.IntStruct]>
 ;* V66 tmp58        [V66    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V67 tmp59        [V67,T13] ( 22,  5.60)   byref  ->  rsi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V68 tmp60        [V68,T14] (  8,  5.93)     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V67 tmp59        [V67,T13] ( 22,  5.57)   byref  ->  rsi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V68 tmp60        [V68,T14] (  8,  5.90)     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V69 tmp61        [V69    ] (  0,  0   )   byref  ->  zero-ref    "field V09._reference (fldOffset=0x0)" P-INDEP
 ;* V70 tmp62        [V70    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0x8)" P-INDEP
 ;* V71 tmp63        [V71    ] (  0,  0   )   byref  ->  zero-ref    "field V10._reference (fldOffset=0x0)" P-INDEP
@@ -759,16 +759,16 @@ G_M61030_IG21:
 ;  V81 tmp73        [V81,T28] (  3,  0.21)     int  ->  rcx         "field V24._value (fldOffset=0x0)" P-INDEP
 ;  V82 tmp74        [V82,T35] (  2,  0.08)     int  ->  rcx         "field V28._value (fldOffset=0x0)" P-INDEP
 ;* V83 tmp75        [V83    ] (  0,  0   )     int  ->  zero-ref    "field V29._value (fldOffset=0x0)" P-INDEP
-;  V84 tmp76        [V84,T29] (  3,  0.21)     int  ->  rcx         "field V31._value (fldOffset=0x0)" P-INDEP
+;  V84 tmp76        [V84,T29] (  3,  0.21)     int  ->   r8         "field V31._value (fldOffset=0x0)" P-INDEP
 ;  V85 tmp77        [V85,T36] (  2,  0.08)     int  ->  rcx         "field V35._value (fldOffset=0x0)" P-INDEP
 ;* V86 tmp78        [V86    ] (  0,  0   )     int  ->  zero-ref    "field V36._value (fldOffset=0x0)" P-INDEP
 ;  V87 tmp79        [V87,T30] (  3,  0.21)     int  ->  rcx         "field V38._value (fldOffset=0x0)" P-INDEP
-;  V88 tmp80        [V88,T37] (  2,  0.08)     int  ->   r8         "field V42._value (fldOffset=0x0)" P-INDEP
+;  V88 tmp80        [V88,T37] (  2,  0.08)     int  ->  r10         "field V42._value (fldOffset=0x0)" P-INDEP
 ;  V89 tmp81        [V89,T21] (  2,  1.74)   byref  ->  rsi         single-def "field V43._reference (fldOffset=0x0)" P-INDEP
-;  V90 tmp82        [V90,T22] (  2,  1.74)     int  ->  rax         "field V43._length (fldOffset=0x8)" P-INDEP
-;  V91 tmp83        [V91,T01] (  6,126.15)   byref  ->  rsi         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
-;  V92 tmp84        [V92,T23] (  2,  1.74)     int  ->  rax         "field V46._length (fldOffset=0x8)" P-INDEP
-;  V93 tmp85        [V93,T04] (  4, 87.08)     int  ->   r8         "field V47._value (fldOffset=0x0)" P-INDEP
+;  V90 tmp82        [V90,T22] (  2,  1.74)     int  ->  rdx         "field V43._length (fldOffset=0x8)" P-INDEP
+;  V91 tmp83        [V91,T01] (  6,105.25)   byref  ->  rsi         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
+;  V92 tmp84        [V92,T23] (  2,  1.74)     int  ->  rdx         "field V46._length (fldOffset=0x8)" P-INDEP
+;  V93 tmp85        [V93,T04] (  3, 53.91)     int  ->  rcx         "field V47._value (fldOffset=0x0)" P-INDEP
 ;* V94 tmp86        [V94    ] (  0,  0   )   byref  ->  zero-ref    "field V50._reference (fldOffset=0x0)" P-INDEP
 ;* V95 tmp87        [V95    ] (  0,  0   )     int  ->  zero-ref    "field V50._length (fldOffset=0x8)" P-INDEP
 ;* V96 tmp88        [V96    ] (  0,  0   )   byref  ->  zero-ref    "field V51._reference (fldOffset=0x0)" P-INDEP
@@ -777,21 +777,21 @@ G_M61030_IG21:
 ;* V99 tmp91        [V99    ] (  0,  0   )     int  ->  zero-ref    "field V52._length (fldOffset=0x8)" P-INDEP
 ;* V100 tmp92       [V100    ] (  0,  0   )   byref  ->  zero-ref    "field V53._reference (fldOffset=0x0)" P-INDEP
 ;* V101 tmp93       [V101    ] (  0,  0   )     int  ->  zero-ref    "field V53._length (fldOffset=0x8)" P-INDEP
-;  V102 tmp94       [V102,T03] (  3, 78.18)     int  ->  r10         "field V56._value (fldOffset=0x0)" P-INDEP
+;  V102 tmp94       [V102,T03] (  2, 64.64)     int  ->   r8         "field V56._value (fldOffset=0x0)" P-INDEP
 ;* V103 tmp95       [V103    ] (  0,  0   )   byref  ->  zero-ref    "field V59._reference (fldOffset=0x0)" P-INDEP
 ;* V104 tmp96       [V104    ] (  0,  0   )     int  ->  zero-ref    "field V59._length (fldOffset=0x8)" P-INDEP
 ;  V105 tmp97       [V105,T41] (  2,  0   )   byref  ->  rcx         single-def "field V60._reference (fldOffset=0x0)" P-INDEP
 ;  V106 tmp98       [V106,T42] (  2,  0   )     int  ->  rax         "field V60._length (fldOffset=0x8)" P-INDEP
 ;* V107 tmp99       [V107,T24] (  0,  0   )   byref  ->  zero-ref    "field V62._reference (fldOffset=0x0)" P-INDEP
-;  V108 tmp100      [V108,T20] (  2,  1.97)     int  ->  rcx         "field V62._length (fldOffset=0x8)" P-INDEP
-;  V109 tmp101      [V109,T15] (  2,  3.97)   byref  ->  rcx         "field V65._reference (fldOffset=0x0)" P-INDEP
-;  V110 tmp102      [V110,T16] (  2,  3.97)     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
+;  V108 tmp100      [V108,T20] (  2,  1.94)     int  ->  rcx         "field V62._length (fldOffset=0x8)" P-INDEP
+;  V109 tmp101      [V109,T15] (  2,  3.94)   byref  ->  rcx         "field V65._reference (fldOffset=0x0)" P-INDEP
+;  V110 tmp102      [V110,T16] (  2,  3.94)     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
 ;* V111 tmp103      [V111    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[System.Collections.IntStruct]>
-;  V112 tmp104      [V112    ] (  9, 17.83)  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[System.Collections.IntStruct]>
-;  V113 cse0        [V113,T27] (  4,  0.25)     int  ->   r8         "CSE #07: conservative"
-;  V114 cse1        [V114,T08] (  3, 34.36)     int  ->  rax         "CSE #08: moderate"
-;  V115 cse2        [V115,T07] (  3, 50.54)     int  ->  rcx         "CSE #12: aggressive"
-;  V116 cse3        [V116,T18] (  3,  3.96)    long  ->  rcx         "CSE #01: moderate"
+;  V112 tmp104      [V112    ] (  9, 17.66)  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[System.Collections.IntStruct]>
+;  V113 cse0        [V113,T27] (  4,  0.25)     int  ->  r10         "CSE #07: conservative"
+;  V114 cse1        [V114,T09] (  3, 14.40)     int  ->  rdx         "CSE #08: moderate"
+;  V115 cse2        [V115,T07] (  3, 30.53)     int  ->  r10         "CSE #12: aggressive"
+;  V116 cse3        [V116,T18] (  3,  3.91)    long  ->  rcx         "CSE #01: moderate"
 ;
 ; Lcl frame size = 48
 
@@ -811,18 +811,18 @@ G_M61030_IG02:
        mov      edi, dword ptr [rcx+0x08]
        mov      ebp, edi
        cmp      edi, 1
-       jle      G_M61030_IG22
+       jle      G_M61030_IG19
 						;; size=17 bbWeight=1 PerfScore 5.50
 G_M61030_IG03:
        cmp      ebp, 16
        jle      SHORT G_M61030_IG07
-						;; size=5 bbWeight=1.96 PerfScore 2.46
+						;; size=5 bbWeight=1.95 PerfScore 2.44
 G_M61030_IG04:
        test     ebx, ebx
-       je       G_M61030_IG34
+       je       G_M61030_IG33
        dec      ebx
        cmp      ebp, edi
-       ja       G_M61030_IG35
+       ja       G_M61030_IG34
        mov      ecx, ebp
        mov      bword ptr [rsp+0x20], rsi
        mov      dword ptr [rsp+0x28], ecx
@@ -835,8 +835,8 @@ G_M61030_IG04:
        add      rdx, rcx
        mov      eax, edi
        cmp      rdx, rax
-       ja       G_M61030_IG35
-						;; size=65 bbWeight=0.99 PerfScore 11.34
+       ja       G_M61030_IG34
+						;; size=65 bbWeight=0.97 PerfScore 11.17
 G_M61030_IG05:
        lea      rcx, bword ptr [rsi+4*rcx]
        mov      bword ptr [rsp+0x20], rcx
@@ -847,92 +847,82 @@ G_M61030_IG05:
        mov      ebp, r14d
        cmp      ebp, 1
        jg       SHORT G_M61030_IG03
-						;; size=34 bbWeight=1.99 PerfScore 15.39
+						;; size=34 bbWeight=1.97 PerfScore 15.28
 G_M61030_IG06:
-       jmp      G_M61030_IG22
-       align    [3 bytes for IG11]
-						;; size=8 bbWeight=0.02 PerfScore 0.04
+       jmp      SHORT G_M61030_IG19
+       align    [0 bytes for IG11]
+						;; size=2 bbWeight=0.02 PerfScore 0.04
 G_M61030_IG07:
        cmp      ebp, 2
-       je       SHORT G_M61030_IG19
+       je       SHORT G_M61030_IG16
 						;; size=5 bbWeight=0.98 PerfScore 1.22
 G_M61030_IG08:
        cmp      ebp, 3
-       je       G_M61030_IG23
-						;; size=9 bbWeight=0.96 PerfScore 1.20
+       je       SHORT G_M61030_IG20
+						;; size=5 bbWeight=0.96 PerfScore 1.20
 G_M61030_IG09:
        cmp      ebp, edi
-       ja       G_M61030_IG35
-       mov      eax, ebp
-       xor      edx, edx
-       dec      eax
-       test     eax, eax
-       jle      SHORT G_M61030_IG22
+       ja       G_M61030_IG34
+       mov      edx, ebp
+       xor      eax, eax
+       dec      edx
+       test     edx, edx
+       jle      SHORT G_M61030_IG19
 						;; size=18 bbWeight=0.87 PerfScore 2.83
 G_M61030_IG10:
-       lea      ecx, [rdx+0x01]
-       movsxd   r8, ecx
-       mov      r8d, dword ptr [rsi+4*r8]
+       lea      r10d, [rax+0x01]
+       movsxd   rcx, r10d
+       mov      ecx, dword ptr [rsi+4*rcx]
        jmp      SHORT G_M61030_IG12
-						;; size=12 bbWeight=8.96 PerfScore 42.56
+						;; size=12 bbWeight=8.93 PerfScore 42.43
 G_M61030_IG11:
-       lea      r10d, [rdx+0x01]
-       movsxd   r10, r10d
-       lea      r10, bword ptr [rsi+4*r10]
-       movsxd   r9, edx
+       lea      r8d, [rax+0x01]
+       movsxd   r8, r8d
+       lea      r8, bword ptr [rsi+4*r8]
+       movsxd   r9, eax
        mov      r9d, dword ptr [rsi+4*r9]
-       mov      dword ptr [r10], r9d
-       dec      edx
-						;; size=23 bbWeight=25.51 PerfScore 121.16
+       mov      dword ptr [r8], r9d
+       dec      eax
+						;; size=23 bbWeight=25.23 PerfScore 119.86
 G_M61030_IG12:
-       test     edx, edx
-       jl       SHORT G_M61030_IG15
-						;; size=4 bbWeight=34.47 PerfScore 43.08
+       test     eax, eax
+       jl       SHORT G_M61030_IG14
+						;; size=4 bbWeight=34.17 PerfScore 42.71
 G_M61030_IG13:
-       movsxd   r10, edx
-       mov      r10d, dword ptr [rsi+4*r10]
-       cmp      r8d, r10d
-       jge      SHORT G_M61030_IG17
-						;; size=12 bbWeight=32.68 PerfScore 114.40
+       movsxd   r8, eax
+       mov      r8d, dword ptr [rsi+4*r8]
+       cmp      ecx, r8d
+       jl       SHORT G_M61030_IG11
+						;; size=12 bbWeight=32.32 PerfScore 113.12
 G_M61030_IG14:
-       jmp      SHORT G_M61030_IG11
-						;; size=2 bbWeight=19.81 PerfScore 39.61
-G_M61030_IG15:
-       inc      edx
-       movsxd   rdx, edx
-       mov      dword ptr [rsi+4*rdx], r8d
-       mov      edx, ecx
-       cmp      edx, eax
+       inc      eax
+       cdqe     
+       mov      dword ptr [rsi+4*rax], ecx
+       mov      eax, r10d
+       cmp      eax, edx
        jl       SHORT G_M61030_IG10
-						;; size=15 bbWeight=32.62 PerfScore 97.86
-G_M61030_IG16:
-       jmp      SHORT G_M61030_IG22
+						;; size=14 bbWeight=12.66 PerfScore 37.98
+G_M61030_IG15:
+       jmp      SHORT G_M61030_IG19
 						;; size=2 bbWeight=0.87 PerfScore 1.74
-G_M61030_IG17:
-       cmp      r8d, r10d
-       jle      SHORT G_M61030_IG15
-						;; size=5 bbWeight=12.81 PerfScore 16.02
-G_M61030_IG18:
-       jmp      SHORT G_M61030_IG15
-						;; size=2 bbWeight=12.81 PerfScore 25.62
-G_M61030_IG19:
+G_M61030_IG16:
        lea      rcx, bword ptr [rsi+0x04]
        cmp      byte  ptr [rsi], sil
        mov      eax, dword ptr [rcx]
        cmp      dword ptr [rsi], eax
-       jl       SHORT G_M61030_IG22
+       jl       SHORT G_M61030_IG19
 						;; size=13 bbWeight=0.02 PerfScore 0.21
-G_M61030_IG20:
+G_M61030_IG17:
        cmp      dword ptr [rsi], eax
-       jle      SHORT G_M61030_IG22
+       jle      SHORT G_M61030_IG19
 						;; size=4 bbWeight=0.01 PerfScore 0.03
-G_M61030_IG21:
+G_M61030_IG18:
        mov      eax, dword ptr [rsi]
        mov      edx, dword ptr [rcx]
        mov      dword ptr [rsi], edx
        mov      dword ptr [rcx], eax
 						;; size=8 bbWeight=0.01 PerfScore 0.06
-G_M61030_IG22:
+G_M61030_IG19:
        add      rsp, 48
        pop      rbx
        pop      rbp
@@ -941,80 +931,87 @@ G_M61030_IG22:
        pop      r14
        ret      
 						;; size=11 bbWeight=0.02 PerfScore 0.08
-G_M61030_IG23:
+G_M61030_IG20:
        cmp      edi, 2
-       jbe      SHORT G_M61030_IG33
+       jbe      SHORT G_M61030_IG32
        lea      rax, bword ptr [rsi+0x08]
        lea      rdx, bword ptr [rsi+0x04]
        cmp      byte  ptr [rsi], sil
        mov      ecx, dword ptr [rdx]
        cmp      dword ptr [rsi], ecx
-       jl       SHORT G_M61030_IG25
+       jge      SHORT G_M61030_IG28
 						;; size=22 bbWeight=0.09 PerfScore 0.98
-G_M61030_IG24:
-       cmp      dword ptr [rsi], ecx
-       jg       SHORT G_M61030_IG28
-						;; size=4 bbWeight=0.03 PerfScore 0.14
-G_M61030_IG25:
+G_M61030_IG21:
+       mov      r8d, dword ptr [rax]
+       cmp      dword ptr [rsi], r8d
+       jge      SHORT G_M61030_IG30
+						;; size=8 bbWeight=0.09 PerfScore 0.52
+G_M61030_IG22:
        mov      ecx, dword ptr [rax]
-       cmp      dword ptr [rsi], ecx
-       jl       SHORT G_M61030_IG30
-						;; size=6 bbWeight=0.09 PerfScore 0.52
-G_M61030_IG26:
-       cmp      dword ptr [rsi], ecx
-       jle      SHORT G_M61030_IG30
-						;; size=4 bbWeight=0.03 PerfScore 0.14
-G_M61030_IG27:
-       jmp      SHORT G_M61030_IG29
+       mov      r10d, dword ptr [rdx]
+       cmp      r10d, ecx
+       jl       SHORT G_M61030_IG19
+						;; size=10 bbWeight=0.09 PerfScore 0.46
+G_M61030_IG23:
+       cmp      r10d, ecx
+       jle      SHORT G_M61030_IG19
+						;; size=5 bbWeight=0.03 PerfScore 0.04
+G_M61030_IG24:
+       jmp      SHORT G_M61030_IG27
 						;; size=2 bbWeight=0.03 PerfScore 0.07
-G_M61030_IG28:
+G_M61030_IG25:
        mov      ecx, dword ptr [rsi]
        mov      r8d, dword ptr [rdx]
        mov      dword ptr [rsi], r8d
        mov      dword ptr [rdx], ecx
-       jmp      SHORT G_M61030_IG25
+       jmp      SHORT G_M61030_IG21
 						;; size=12 bbWeight=0.04 PerfScore 0.32
-G_M61030_IG29:
+G_M61030_IG26:
        mov      ecx, dword ptr [rsi]
        mov      r8d, dword ptr [rax]
        mov      dword ptr [rsi], r8d
        mov      dword ptr [rax], ecx
-						;; size=10 bbWeight=0.04 PerfScore 0.24
-G_M61030_IG30:
-       mov      ecx, dword ptr [rax]
-       mov      r8d, dword ptr [rdx]
-       cmp      r8d, ecx
-       jl       SHORT G_M61030_IG22
-						;; size=10 bbWeight=0.09 PerfScore 0.46
-G_M61030_IG31:
-       cmp      r8d, ecx
-       jle      SHORT G_M61030_IG22
-						;; size=5 bbWeight=0.03 PerfScore 0.04
-G_M61030_IG32:
+       jmp      SHORT G_M61030_IG22
+						;; size=12 bbWeight=0.04 PerfScore 0.32
+G_M61030_IG27:
        mov      ecx, dword ptr [rax]
        mov      dword ptr [rdx], ecx
-       mov      dword ptr [rax], r8d
-       jmp      SHORT G_M61030_IG22
+       mov      dword ptr [rax], r10d
+       jmp      SHORT G_M61030_IG19
 						;; size=9 bbWeight=0.04 PerfScore 0.24
-G_M61030_IG33:
+G_M61030_IG28:
+       cmp      dword ptr [rsi], ecx
+       jle      SHORT G_M61030_IG21
+						;; size=4 bbWeight=0.03 PerfScore 0.14
+G_M61030_IG29:
+       jmp      SHORT G_M61030_IG25
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M61030_IG30:
+       cmp      dword ptr [rsi], r8d
+       jle      SHORT G_M61030_IG22
+						;; size=5 bbWeight=0.03 PerfScore 0.14
+G_M61030_IG31:
+       jmp      SHORT G_M61030_IG26
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M61030_IG32:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M61030_IG34:
+G_M61030_IG33:
        cmp      ebp, edi
-       ja       SHORT G_M61030_IG35
+       ja       SHORT G_M61030_IG34
        mov      rcx, rsi
        mov      eax, ebp
        mov      bword ptr [rsp+0x20], rcx
        mov      dword ptr [rsp+0x28], eax
        lea      rcx, [rsp+0x20]
        call     [System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:HeapSort(System.Span`1[System.Collections.IntStruct])]
-       jmp      G_M61030_IG22
+       jmp      G_M61030_IG19
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M61030_IG35:
+G_M61030_IG34:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 423, prolog size 19, PerfScore 552.28, instruction count 149, allocated bytes for code 423 (MethodHash=a0751199) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int) (Tier1)
+; Total bytes of code 412, prolog size 19, PerfScore 408.00, instruction count 148, allocated bytes for code 415 (MethodHash=a0751199) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.IntStruct]:IntroSort(System.Span`1[System.Collections.IntStruct],int) (Tier1)
 ; ============================================================
 


```

</details>

# ``Span.IndexerBench.CoveredIndex2(length: 1024)``

Hot functions:

- (98.38%) ``IndexerBench.TestCoveredIndex2`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]IndexerBench.TestCoveredIndex2(value class System.Span`1<unsigned int8>,int32,int32)``

```diff
 ;  V00 arg0         [V00,T06] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 arg2         [V02,T04] (  4,102.69)     int  ->   r8         single-def
-;  V03 loc0         [V03,T02] (  3,201.27)   ubyte  ->  rdx        
-;  V04 loc1         [V04,T03] (  4,201.16)   ubyte  ->  r10        
+;  V03 loc0         [V03,T02] (  3,201.27)   ubyte  ->  rax        
+;  V04 loc1         [V04,T03] (  4,201.16)   ubyte  ->  rdx        
 ;* V05 loc2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V06 loc3         [V06,T00] (  7,603.63)     int  ->  rax        
+;  V06 loc3         [V06,T07] (  2,  0.20)     int  ->  r10        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V08 tmp1         [V08,T01] (  3,202.08)   byref  ->   r9         single-def "V00.[000..008)"
 ;  V09 tmp2         [V09,T05] (  2,101.59)     int  ->  rcx         single-def "V00.[008..012)"
+;  V10 rat0         [V10,T00] (  7,603.63)    long  ->  r10         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -137,43 +138,42 @@ G_M40692_IG01:
        sub      rsp, 40
        mov      rcx, bword ptr [rsp+0xB0]
        mov      r8d, dword ptr [rsp+0xC0]
-       mov      edx, dword ptr [rsp+0x64]
-       mov      r10d, dword ptr [rsp+0x60]
-       mov      eax, dword ptr [rsp+0x58]
+       mov      eax, dword ptr [rsp+0x64]
+       mov      edx, dword ptr [rsp+0x60]
+       mov      r10d, dword ptr [rsp+0x58]
 						;; size=33 bbWeight=1 PerfScore 10.25
 G_M40692_IG02:
        mov      r9, bword ptr [rcx]
        mov      ecx, dword ptr [rcx+0x08]
-       cmp      eax, r8d
+       cmp      r10d, r8d
        jge      SHORT G_M40692_IG06
+       mov      r10d, r10d
        align    [0 bytes for IG03]
-						;; size=11 bbWeight=1 PerfScore 5.25
+						;; size=14 bbWeight=1 PerfScore 5.50
 G_M40692_IG03:
-       cmp      eax, ecx
+       cmp      r10d, ecx
        jae      SHORT G_M40692_IG08
-       mov      r11d, eax
-       movzx    r11, byte  ptr [r9+r11]
-       xor      edx, r11d
-       movzx    rdx, dl
-       cmp      eax, 100
+       movzx    r11, byte  ptr [r9+r10]
+       xor      eax, r11d
+       movzx    rax, al
+       cmp      r10d, 100
        je       SHORT G_M40692_IG05
-						;; size=23 bbWeight=100.59 PerfScore 528.09
+						;; size=22 bbWeight=100.59 PerfScore 502.95
 G_M40692_IG04:
        movzx    r11, byte  ptr [r9]
-       xor      r10d, r11d
-       movzx    r10, r10b
-						;; size=11 bbWeight=100.49 PerfScore 251.22
+       xor      edx, r11d
+       movzx    rdx, dl
+						;; size=10 bbWeight=100.49 PerfScore 251.22
 G_M40692_IG05:
-       inc      eax
-       cmp      eax, r8d
+       inc      r10d
+       cmp      r10d, r8d
        jl       SHORT G_M40692_IG03
-						;; size=7 bbWeight=100.59 PerfScore 150.88
+						;; size=8 bbWeight=100.59 PerfScore 150.88
 G_M40692_IG06:
-       mov      eax, r10d
        xor      eax, edx
-       xor      eax, r10d
+       xor      eax, edx
        movzx    rax, al
-						;; size=11 bbWeight=0.09 PerfScore 0.09
+						;; size=7 bbWeight=0.09 PerfScore 0.07
 G_M40692_IG07:
        add      rsp, 160
        pop      rbp
@@ -184,7 +184,7 @@ G_M40692_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 111, prolog size 33, PerfScore 945.94, instruction count 34, allocated bytes for code 111 (MethodHash=2be6610b) for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 109, prolog size 33, PerfScore 921.02, instruction count 33, allocated bytes for code 109 (MethodHash=2be6610b) for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Instrumented Tier0)
@@ -306,19 +306,20 @@ G_M40692_IG09:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 433766.6
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 442040.5
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T06] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
-;  V02 arg2         [V02,T04] (  4,102.00)     int  ->   r8         single-def
-;  V03 loc0         [V03,T01] (  3,200.00)   ubyte  ->  rdx        
-;  V04 loc1         [V04,T03] (  4,197.73)   ubyte  ->  r10        
+;  V02 arg2         [V02,T04] (  4,102   )     int  ->   r8         single-def
+;  V03 loc0         [V03,T01] (  3,200.00)   ubyte  ->  rax        
+;  V04 loc1         [V04,T03] (  4,197.59)   ubyte  ->  rdx        
 ;* V05 loc2         [V05    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V06 loc3         [V06,T00] (  7,600.00)     int  ->  rax        
+;  V06 loc3         [V06,T07] (  2,  0.00)     int  ->  r10        
 ;  V07 OutArgs      [V07    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T02] (  3,199.87)   byref  ->   r9         single-def "V00.[000..008)"
+;  V08 tmp1         [V08,T02] (  3,199.80)   byref  ->   r9         single-def "V00.[000..008)"
 ;  V09 tmp2         [V09,T05] (  2,101.00)     int  ->  rcx         single-def "V00.[008..012)"
+;  V10 rat0         [V10,T00] (  7,600.00)    long  ->  r10         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -326,54 +327,55 @@ G_M40692_IG01:
        sub      rsp, 40
        mov      rcx, bword ptr [rsp+0xB0]
        mov      r8d, dword ptr [rsp+0xC0]
-       mov      edx, dword ptr [rsp+0x64]
-       mov      r10d, dword ptr [rsp+0x60]
-       mov      eax, dword ptr [rsp+0x58]
+       mov      eax, dword ptr [rsp+0x64]
+       mov      edx, dword ptr [rsp+0x60]
+       mov      r10d, dword ptr [rsp+0x58]
 						;; size=33 bbWeight=1 PerfScore 10.25
 G_M40692_IG02:
        mov      r9, bword ptr [rcx]
        mov      ecx, dword ptr [rcx+0x08]
-       cmp      eax, r8d
-       jge      SHORT G_M40692_IG06
-       align    [0 bytes for IG03]
+       cmp      r10d, r8d
+       jge      SHORT G_M40692_IG07
 						;; size=11 bbWeight=1 PerfScore 5.25
 G_M40692_IG03:
-       cmp      eax, ecx
-       jae      SHORT G_M40692_IG08
-       mov      r11d, eax
-       movzx    r11, byte  ptr [r9+r11]
+       mov      r10d, r10d
+       align    [0 bytes for IG04]
+						;; size=3 bbWeight=0.00 PerfScore 0.00
+G_M40692_IG04:
+       cmp      r10d, ecx
+       jae      SHORT G_M40692_IG09
+       movzx    r11, byte  ptr [r9+r10]
+       xor      eax, r11d
+       movzx    rax, al
+       cmp      r10d, 100
+       je       SHORT G_M40692_IG06
+						;; size=22 bbWeight=100.00 PerfScore 500.00
+G_M40692_IG05:
+       movzx    r11, byte  ptr [r9]
        xor      edx, r11d
        movzx    rdx, dl
-       cmp      eax, 100
-       je       SHORT G_M40692_IG05
-						;; size=23 bbWeight=100.00 PerfScore 525.00
-G_M40692_IG04:
-       movzx    r11, byte  ptr [r9]
-       xor      r10d, r11d
-       movzx    r10, r10b
-						;; size=11 bbWeight=98.87 PerfScore 247.17
-G_M40692_IG05:
-       inc      eax
-       cmp      eax, r8d
-       jl       SHORT G_M40692_IG03
-						;; size=7 bbWeight=100.00 PerfScore 150.00
+						;; size=10 bbWeight=98.80 PerfScore 246.99
 G_M40692_IG06:
-       mov      eax, r10d
-       xor      eax, edx
-       xor      eax, r10d
-       movzx    rax, al
-						;; size=11 bbWeight=0.00 PerfScore 0.00
+       inc      r10d
+       cmp      r10d, r8d
+       jl       SHORT G_M40692_IG04
+						;; size=8 bbWeight=100.00 PerfScore 150.00
 G_M40692_IG07:
+       xor      eax, edx
+       xor      eax, edx
+       movzx    rax, al
+						;; size=7 bbWeight=0.00 PerfScore 0.00
+G_M40692_IG08:
        add      rsp, 160
        pop      rbp
        ret      
 						;; size=9 bbWeight=0.00 PerfScore 0.00
-G_M40692_IG08:
+G_M40692_IG09:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 111, prolog size 33, PerfScore 937.67, instruction count 34, allocated bytes for code 111 (MethodHash=2be6610b) for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 109, prolog size 33, PerfScore 912.49, instruction count 33, allocated bytes for code 109 (MethodHash=2be6610b) for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1)
@@ -388,15 +390,16 @@ G_M40692_IG08:
 ;
 ;  V00 arg0         [V00,T06] (  4,       8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T07] (  3,       3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T04] (  4, 2411181.67)     int  ->   r8         single-def
-;  V03 loc0         [V03,T01] (  4, 4822359.33)   ubyte  ->  r10        
-;  V04 loc1         [V04,T03] (  5, 4765926.56)   ubyte  ->   r9        
+;  V02 arg2         [V02,T04] (  4, 2459423.44)     int  ->   r8         single-def
+;  V03 loc0         [V03,T01] (  4, 4918842.89)   ubyte  ->  r10        
+;  V04 loc1         [V04,T03] (  5, 4855128.33)   ubyte  ->   r9        
 ;* V05 loc2         [V05    ] (  0,       0   )   ubyte  ->  zero-ref   
-;  V06 loc3         [V06,T00] (  8,14467074   )     int  ->  rdx        
+;  V06 loc3         [V06,T08] (  2,       2   )     int  ->  rdx        
 ;  V07 OutArgs      [V07    ] (  1,       1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V08 tmp1         [V08,T02] (  3, 4794141.44)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V09 tmp2         [V09,T05] (  2, 2411179.67)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
+;  V08 tmp1         [V08,T02] (  3, 4886984.11)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V09 tmp2         [V09,T05] (  2, 2459421.44)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V10 tmp3         [V10    ] (  0,       0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[ubyte]>
+;  V11 rat0         [V11,T00] (  8,14756524.67)    long  ->  rdx         "Widened IV V06"
 ;
 ; Lcl frame size = 40
 
@@ -408,30 +411,30 @@ G_M40692_IG02:
        mov      ecx, dword ptr [rcx+0x08]
        xor      r10d, r10d
        xor      r9d, r9d
+       mov      edx, edx
        cmp      edx, r8d
        jge      SHORT G_M40692_IG06
        align    [0 bytes for IG03]
-						;; size=17 bbWeight=1 PerfScore 5.75
+						;; size=19 bbWeight=1 PerfScore 6.00
 G_M40692_IG03:
        cmp      edx, ecx
        jae      SHORT G_M40692_IG08
-       mov      r11d, edx
-       movzx    r11, byte  ptr [rax+r11]
+       movzx    r11, byte  ptr [rax+rdx]
        xor      r10d, r11d
        movzx    r10, r10b
        cmp      edx, 100
        je       SHORT G_M40692_IG05
-						;; size=24 bbWeight=2411178.67 PerfScore 12658688.00
+						;; size=21 bbWeight=2459420.44 PerfScore 12297102.22
 G_M40692_IG04:
        movzx    r11, byte  ptr [rax]
        xor      r9d, r11d
        movzx    r9, r9b
-						;; size=11 bbWeight=2382961.78 PerfScore 5957404.44
+						;; size=11 bbWeight=2427562.67 PerfScore 6068906.67
 G_M40692_IG05:
        inc      edx
        cmp      edx, r8d
        jl       SHORT G_M40692_IG03
-						;; size=7 bbWeight=2411178.67 PerfScore 3616768.00
+						;; size=7 bbWeight=2459420.44 PerfScore 3689130.67
 G_M40692_IG06:
        mov      eax, r9d
        xor      eax, r10d
@@ -447,6 +450,6 @@ G_M40692_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 86, prolog size 4, PerfScore 22232868.69, instruction count 30, allocated bytes for code 86 (MethodHash=2be6610b) for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1)
+; Total bytes of code 85, prolog size 4, PerfScore 22055148.06, instruction count 30, allocated bytes for code 85 (MethodHash=2be6610b) for method Span.IndexerBench:TestCoveredIndex2(System.Span`1[ubyte],int,int):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``Span.IndexerBench.CoveredIndex3(length: 1024)``

Hot functions:

- (98.84%) ``IndexerBench.TestCoveredIndex3`` (Tier-1)
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
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 399851.7
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 408207.5
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T07] (  5,  9   )   byref  ->  rcx         ld-addr-op single-def
 ;* V01 arg1         [V01    ] (  0,  0   )     int  ->  zero-ref    single-def
 ;  V02 arg2         [V02,T06] (  4,102   )     int  ->   r8         single-def
-;  V03 loc0         [V03,T03] (  3,200.00)   ubyte  ->  rdx        
-;  V04 loc1         [V04,T04] (  4,199.02)   ubyte  ->  r10        
-;  V05 loc2         [V05,T05] (  4,199.02)   ubyte  ->   r9        
+;  V03 loc0         [V03,T03] (  3,200.00)   ubyte  ->  rax        
+;  V04 loc1         [V04,T04] (  4,198.19)   ubyte  ->  rdx        
+;  V05 loc2         [V05,T05] (  4,198.19)   ubyte  ->  r10        
 ;* V06 loc3         [V06    ] (  0,  0   )   ubyte  ->  zero-ref   
-;  V07 loc4         [V07,T00] (  7,600.00)     int  ->  rax        
+;  V07 loc4         [V07,T08] (  2,  0.00)     int  ->   r9        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T01] (  4,300.02)   byref  ->  r11         single-def "V00.[000..008)"
-;  V10 tmp2         [V10,T02] (  3,200.51)     int  ->  rcx         single-def "V00.[008..012)"
+;  V09 tmp1         [V09,T01] (  4,299.19)   byref  ->  r11         single-def "V00.[000..008)"
+;  V10 tmp2         [V10,T02] (  3,200.10)     int  ->  rcx         single-def "V00.[008..012)"
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
-						;; size=29 bbWeight=99.51 PerfScore 621.93
-G_M31285_IG05:
-       inc      eax
-       cmp      eax, r8d
-       jl       SHORT G_M31285_IG03
-						;; size=7 bbWeight=100.00 PerfScore 150.00
+						;; size=27 bbWeight=99.10 PerfScore 619.36
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
 
-; Total bytes of code 154, prolog size 46, PerfScore 1315.68, instruction count 44, allocated bytes for code 154 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
+; Total bytes of code 151, prolog size 46, PerfScore 1287.86, instruction count 44, allocated bytes for code 151 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1)
@@ -442,16 +446,17 @@ G_M31285_IG08:
 ;
 ;  V00 arg0         [V00,T07] (  4,       8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T08] (  3,       3   )     int  ->  rdx         single-def
-;  V02 arg2         [V02,T06] (  4, 2221855.44)     int  ->   r8         single-def
-;  V03 loc0         [V03,T02] (  4, 4443706.89)   ubyte  ->  r10        
-;  V04 loc1         [V04,T04] (  5, 4423683   )   ubyte  ->   r9        
-;  V05 loc2         [V05,T05] (  5, 4423683   )   ubyte  ->  r11        
+;  V02 arg2         [V02,T06] (  4, 2270552.33)     int  ->   r8         single-def
+;  V03 loc0         [V03,T02] (  4, 4541100.67)   ubyte  ->  r10        
+;  V04 loc1         [V04,T04] (  5, 4497411   )   ubyte  ->   r9        
+;  V05 loc2         [V05,T05] (  5, 4497411   )   ubyte  ->  r11        
 ;* V06 loc3         [V06    ] (  0,       0   )   ubyte  ->  zero-ref   
-;  V07 loc4         [V07,T00] (  8,13331116.67)     int  ->  rdx        
+;  V07 loc4         [V07,T09] (  2,       2   )     int  ->  rdx        
 ;  V08 OutArgs      [V08    ] (  1,       1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T01] (  4, 6645533.44)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V10 tmp2         [V10,T03] (  3, 4433693.44)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
+;  V09 tmp1         [V09,T01] (  4, 6767958.33)   byref  ->  rax         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V10 tmp2         [V10,T03] (  3, 4519254.33)     int  ->  rcx         single-def "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V11 tmp3         [V11    ] (  0,       0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[ubyte]>
+;  V12 rat0         [V12,T00] (  8,13623298   )    long  ->  rdx         "Widened IV V07"
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
-						;; size=22 bbWeight=2221852.44 PerfScore 11664725.33
+						;; size=20 bbWeight=2270549.33 PerfScore 11352746.67
 G_M31285_IG04:
        cmp      ecx, 50
        jbe      SHORT G_M31285_IG08
@@ -488,12 +493,12 @@ G_M31285_IG04:
        movzx    rbx, byte  ptr [rax+0x19]
        xor      r11d, ebx
        movzx    r11, r11b
-						;; size=27 bbWeight=2211840 PerfScore 13824000.00
+						;; size=27 bbWeight=2248704 PerfScore 14054400.00
 G_M31285_IG05:
        inc      edx
        cmp      edx, r8d
        jl       SHORT G_M31285_IG03
-						;; size=7 bbWeight=2221852.44 PerfScore 3332778.67
+						;; size=7 bbWeight=2270549.33 PerfScore 3405824.00
 G_M31285_IG06:
        mov      eax, r11d
        xor      eax, r9d
@@ -512,6 +517,6 @@ G_M31285_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 118, prolog size 5, PerfScore 28821514.75, instruction count 40, allocated bytes for code 118 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1)
+; Total bytes of code 116, prolog size 5, PerfScore 28812981.67, instruction count 40, allocated bytes for code 116 (MethodHash=a77785ca) for method Span.IndexerBench:TestCoveredIndex3(System.Span`1[ubyte],int,int):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.ContainsTrue<Int32>.ImmutableHashSet(Size: 512)``

Hot functions:

- (99.23%) ``System.Collections.ContainsTrue`1.ImmutableHashSet`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.ContainsTrue`1[System.Int32].ImmutableHashSet()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 3163
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 3297
 ; 4 inlinees with PGO data; 12 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T22] (  4,    4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsTrue`1[int]>
-;  V01 loc0         [V01,T14] (  4, 1020.66)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T11] (  3, 1030.63)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Immutable.ImmutableHashSet`1[int]>
-;  V03 loc2         [V03,T19] (  3,  516.82)     ref  ->  rdi         class-hnd single-def <<unknown class>>
-;  V04 loc3         [V04,T05] (  5, 2043.80)     int  ->  rbp        
+;  V00 this         [V00,T21] (  4,    4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsTrue`1[int]>
+;  V01 loc0         [V01,T09] (  4, 1027.09)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T10] (  3, 1026.09)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Immutable.ImmutableHashSet`1[int]>
+;  V03 loc2         [V03,T18] (  3,  514.54)     ref  ->  rdi         class-hnd single-def <<unknown class>>
+;* V04 loc3         [V04,T22] (  0,    0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,    1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T04] (  6, 4096.58)     int  ->  r15         "Inlining Arg"
+;  V06 tmp1         [V06,T04] (  6, 3072.38)     int  ->  r15         "Inlining Arg"
 ;* V07 tmp2         [V07    ] (  0,    0   )  struct (32) zero-ref    do-not-enreg[S] "spilled call-like call argument" <System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]>
 ;* V08 tmp3         [V08    ] (  0,    0   )  struct (32) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]>
-;  V09 tmp4         [V09,T17] (  3, 1018.66)   ubyte  ->  r13         "Inline return value spill temp"
+;  V09 tmp4         [V09,T15] (  3, 1025.09)   ubyte  ->  r13         "Inline return value spill temp"
 ;* V10 tmp5         [V10    ] (  0,    0   )  struct (32) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.Immutable.ImmutableHashSet`1+MutationInput[int]>
 ;* V11 tmp6         [V11    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "spilling ret_expr" <System.Collections.Generic.IEqualityComparer`1[int]>
 ;* V12 tmp7         [V12    ] (  0,    0   )     int  ->  zero-ref   
-;  V13 tmp8         [V13,T03] (  3, 8431.99)     int  ->  rcx         "Inline stloc first use temp"
+;  V13 tmp8         [V13,T03] (  3, 8418.71)     int  ->  rax         "Inline stloc first use temp"
 ;* V14 tmp9         [V14    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]>
-;  V15 tmp10        [V15,T12] (  3, 1029.63)     int  ->  rcx         "guarded devirt return temp"
+;  V15 tmp10        [V15,T17] (  3, 1023.65)     int  ->  rax         "guarded devirt return temp"
 ;* V16 tmp11        [V16    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[int]>
 ;* V17 tmp12        [V17    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
-;* V18 tmp13        [V18,T21] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V18 tmp13        [V18,T20] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V19 tmp14        [V19    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V20 tmp15        [V20,T00] (  8,15480.63)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V21 tmp16        [V21,T16] (  4, 1018.66)   ubyte  ->  r13         "Inline return value spill temp"
+;  V20 tmp15        [V20,T00] (  8,15470.04)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V21 tmp16        [V21,T13] (  4, 1025.09)   ubyte  ->  r13         "Inline return value spill temp"
 ;* V22 tmp17        [V22    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Collections.Generic.IEqualityComparer`1[int]>
-;  V23 tmp18        [V23,T18] (  2, 1018.66)     int  ->  rax         "guarded devirt return temp"
+;  V23 tmp18        [V23,T23] (  2,    0   )     int  ->  rax         "guarded devirt return temp"
 ;* V24 tmp19        [V24    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[int]>
 ;* V25 tmp20        [V25    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V26 tmp21        [V26    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V27 tmp22        [V27    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableList`1+Node[int]>
-;  V28 tmp23        [V28,T06] (  3, 1544.45)     ref  ->  r13         "field V08._root (fldOffset=0x0)" P-INDEP
-;  V29 tmp24        [V29,T13] (  2, 1029.63)     ref  ->  r12         "field V08._equalityComparer (fldOffset=0x8)" P-INDEP
+;  V28 tmp23        [V28,T06] (  3, 1537.63)     ref  ->  r13         "field V08._root (fldOffset=0x0)" P-INDEP
+;  V29 tmp24        [V29,T16] (  2, 1025.09)     ref  ->  r12         "field V08._equalityComparer (fldOffset=0x8)" P-INDEP
 ;* V30 tmp25        [V30    ] (  0,    0   )     ref  ->  zero-ref    "field V08._hashBucketEqualityComparer (fldOffset=0x10)" P-INDEP
 ;* V31 tmp26        [V31    ] (  0,    0   )     int  ->  zero-ref    "field V08._count (fldOffset=0x18)" P-INDEP
 ;* V32 tmp27        [V32    ] (  0,    0   )     ref  ->  zero-ref    "field V10._root (fldOffset=0x0)" P-INDEP
-;  V33 tmp28        [V33,T07] (  5, 1538.96)     ref  ->  r12         "field V10._equalityComparer (fldOffset=0x8)" P-INDEP
+;  V33 tmp28        [V33,T11] (  5, 1025.09)     ref  ->  r12         "field V10._equalityComparer (fldOffset=0x8)" P-INDEP
 ;* V34 tmp29        [V34    ] (  0,    0   )     ref  ->  zero-ref    "field V10._hashBucketEqualityComparer (fldOffset=0x10)" P-INDEP
 ;* V35 tmp30        [V35    ] (  0,    0   )     int  ->  zero-ref    "field V10._count (fldOffset=0x18)" P-INDEP
-;  V36 tmp31        [V36,T15] (  4, 1018.66)     ref  ->  [rsp+0x30]  spill-single-def "field V14._additionalElements (fldOffset=0x0)" P-INDEP
-;  V37 tmp32        [V37,T10] (  3, 1527.99)     int  ->   r8         "field V14._firstValue (fldOffset=0x8)" P-INDEP
-;  V38 cse0         [V38,T01] (  3,12130.42)     int  ->  rdx         "CSE #01: aggressive"
-;  V39 cse1         [V39,T02] (  3,10313.69)     ref  ->   r8         "CSE #02: aggressive"
-;  V40 cse2         [V40,T20] (  3,  511.33)     int  ->  r14         "CSE #05: moderate"
-;  V41 cse3         [V41,T08] (  3, 1538.96)    long  ->  [rsp+0x40]  spill-single-def "CSE #03: aggressive"
-;  V42 cse4         [V42,T09] (  3, 1538.96)    long  ->  [rsp+0x38]  spill-single-def "CSE #04: aggressive"
+;  V36 tmp31        [V36,T12] (  4, 1025.09)     ref  ->  [rsp+0x30]  spill-single-def "field V14._additionalElements (fldOffset=0x0)" P-INDEP
+;  V37 tmp32        [V37,T14] (  3, 1025.09)     int  ->  r11         "field V14._firstValue (fldOffset=0x8)" P-INDEP
+;  V38 cse0         [V38,T01] (  3,12115.52)     int  ->  rdx         "CSE #01: aggressive"
+;  V39 cse1         [V39,T02] (  3,10298.63)     ref  ->  rcx         "CSE #02: aggressive"
+;  V40 cse2         [V40,T19] (  3,  514.54)     int  ->  r14         "CSE #05: moderate"
+;  V41 cse3         [V41,T07] (  3, 1537.63)    long  ->  [rsp+0x40]  spill-single-def "CSE #03: aggressive"
+;  V42 cse4         [V42,T08] (  3, 1537.63)    long  ->  [rsp+0x38]  spill-single-def "CSE #04: aggressive"
+;  V43 rat0         [V43,T05] (  5, 2051.17)    long  ->  rbp         "Widened IV V04"
 ;
 ; Lcl frame size = 72
 
@@ -309,79 +310,69 @@ G_M47963_IG02:
        xor      ebp, ebp
        mov      r14d, dword ptr [rdi+0x08]
        test     r14d, r14d
-       jle      G_M47963_IG13
+       jle      G_M47963_IG14
 						;; size=25 bbWeight=1 PerfScore 7.75
 G_M47963_IG03:
-       mov      ecx, ebp
-       mov      r15d, dword ptr [rdi+4*rcx+0x10]
+       mov      r15d, dword ptr [rdi+4*rbp+0x10]
        mov      r13, gword ptr [rsi+0x10]
        mov      r12, gword ptr [rsi+0x08]
-       mov      rax, qword ptr [r12]
-       mov      qword ptr [rsp+0x40], rax
+       mov      r8, qword ptr [r12]
+       mov      qword ptr [rsp+0x40], r8
        mov      r10, 0xD1FFAB1E      ; System.Collections.Generic.GenericEqualityComparer`1[int]
        mov      qword ptr [rsp+0x38], r10
-       cmp      rax, r10
-       jne      G_M47963_IG15
-       mov      ecx, r15d
-						;; size=51 bbWeight=514.82 PerfScore 6177.79
+       cmp      r8, r10
+       jne      SHORT G_M47963_IG17
+		  ;; NOP compensation instructions of 4 bytes.
+						;; size=46 bbWeight=512.54 PerfScore 5894.25
 G_M47963_IG04:
-       cmp      byte  ptr [r13], r13b
-       align    [0 bytes for IG05]
-						;; size=4 bbWeight=514.82 PerfScore 1544.45
+       mov      eax, r15d
+						;; size=3 bbWeight=511.10 PerfScore 127.78
 G_M47963_IG05:
-       mov      r8, gword ptr [r13+0x08]
-       test     r8, r8
-       je       G_M47963_IG18
-       mov      edx, dword ptr [r13+0x18]
-       cmp      ecx, edx
-       je       SHORT G_M47963_IG09
-						;; size=21 bbWeight=4213.25 PerfScore 27386.13
+       cmp      byte  ptr [r13], r13b
+       align    [2 bytes for IG06]
+						;; size=6 bbWeight=512.54 PerfScore 1665.77
 G_M47963_IG06:
-       cmp      ecx, edx
-       jle      SHORT G_M47963_IG08
-						;; size=4 bbWeight=3703.92 PerfScore 4629.90
-G_M47963_IG07:
-       mov      r13, gword ptr [r13+0x10]
-       jmp      SHORT G_M47963_IG05
-						;; size=6 bbWeight=1816.73 PerfScore 7266.92
-G_M47963_IG08:
-       mov      r13, r8
-       jmp      SHORT G_M47963_IG05
-						;; size=5 bbWeight=1887.19 PerfScore 4246.18
-G_M47963_IG09:
-       mov      r9, gword ptr [r13+0x20]
-       mov      gword ptr [rsp+0x30], r9
-       mov      r8d, dword ptr [r13+0x28]
-       test     r9, r9
+       mov      rcx, gword ptr [r13+0x08]
+       test     rcx, rcx
+       je       G_M47963_IG21
+       mov      edx, dword ptr [r13+0x18]
+       cmp      eax, edx
        je       SHORT G_M47963_IG16
-       cmp      rax, r10
-       jne      SHORT G_M47963_IG10
-       cmp      r15d, r8d
-       je       SHORT G_M47963_IG11
-       jmp      SHORT G_M47963_IG17
-						;; size=30 bbWeight=509.33 PerfScore 5475.29
+						;; size=21 bbWeight=4209.36 PerfScore 27360.81
+G_M47963_IG07:
+       cmp      eax, edx
+       jle      SHORT G_M47963_IG09
+						;; size=4 bbWeight=3696.81 PerfScore 4621.01
+G_M47963_IG08:
+       mov      r13, gword ptr [r13+0x10]
+       jmp      SHORT G_M47963_IG06
+						;; size=6 bbWeight=1816.89 PerfScore 7267.56
+G_M47963_IG09:
+       mov      r13, rcx
+       jmp      SHORT G_M47963_IG06
+						;; size=5 bbWeight=1879.92 PerfScore 4229.82
 G_M47963_IG10:
-       mov      rcx, r12
-       mov      edx, r15d
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       je       SHORT G_M47963_IG17
-						;; size=23 bbWeight=509.33 PerfScore 2546.65
+       cmp      r8, r10
+       jne      SHORT G_M47963_IG19
+						;; size=5 bbWeight=512.54 PerfScore 640.68
 G_M47963_IG11:
-       mov      r13d, 1
-						;; size=6 bbWeight=509.33 PerfScore 127.33
+       cmp      r15d, r11d
+       jne      G_M47963_IG20
+						;; size=9 bbWeight=512.54 PerfScore 640.68
 G_M47963_IG12:
+       mov      r13d, 1
+						;; size=6 bbWeight=512.54 PerfScore 128.14
+G_M47963_IG13:
        xor      ebx, r13d
        movzx    rbx, bl
        inc      ebp
        cmp      r14d, ebp
-       jg       G_M47963_IG03
-						;; size=17 bbWeight=509.33 PerfScore 1018.66
-G_M47963_IG13:
+       jg       SHORT G_M47963_IG03
+						;; size=13 bbWeight=512.54 PerfScore 1025.09
+G_M47963_IG14:
        mov      eax, ebx
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M47963_IG14:
+G_M47963_IG15:
        add      rsp, 72
        pop      rbx
        pop      rbp
@@ -393,21 +384,37 @@ G_M47963_IG14:
        pop      r15
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M47963_IG15:
+G_M47963_IG16:
+       mov      r9, gword ptr [r13+0x20]
+       mov      gword ptr [rsp+0x30], r9
+       mov      r11d, dword ptr [r13+0x28]
+       test     r9, r9
+       je       SHORT G_M47963_IG18
+       jmp      SHORT G_M47963_IG10
+						;; size=20 bbWeight=512.54 PerfScore 4228.48
+G_M47963_IG17:
        mov      rcx, r12
        mov      edx, r15d
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       mov      ecx, eax
-       mov      rax, qword ptr [rsp+0x40]
+       mov      r8, qword ptr [rsp+0x40]
        mov      r10, qword ptr [rsp+0x38]
-       jmp      G_M47963_IG04
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M47963_IG16:
+       jmp      G_M47963_IG05
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M47963_IG18:
        xor      r13d, r13d
-       jmp      SHORT G_M47963_IG12
+       jmp      SHORT G_M47963_IG13
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M47963_IG17:
+G_M47963_IG19:
+       mov      rcx, r12
+       mov      r8d, r11d
+       mov      edx, r15d
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M47963_IG12
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M47963_IG20:
        mov      gword ptr [rsp+0x20], r12
        mov      r9, gword ptr [rsp+0x30]
        mov      r9d, dword ptr [r9+0x1C]
@@ -418,13 +425,13 @@ G_M47963_IG17:
        mov      r13d, eax
        not      r13d
        shr      r13d, 31
-       jmp      SHORT G_M47963_IG12
-						;; size=43 bbWeight=0 PerfScore 0.00
-G_M47963_IG18:
+       jmp      G_M47963_IG13
+						;; size=46 bbWeight=0 PerfScore 0.00
+G_M47963_IG21:
        xor      r13d, r13d
-       jmp      SHORT G_M47963_IG12
-						;; size=5 bbWeight=0 PerfScore 0.00
+       jmp      G_M47963_IG13
+						;; size=8 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 316, prolog size 16, PerfScore 60440.81, instruction count 97, allocated bytes for code 316 (MethodHash=827b44a4) for method System.Collections.ContainsTrue`1[int]:ImmutableHashSet():ubyte:this (Tier1)
+; Total bytes of code 323, prolog size 16, PerfScore 57851.56, instruction count 96, allocated bytes for code 327 (MethodHash=827b44a4) for method System.Collections.ContainsTrue`1[int]:ImmutableHashSet():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Buffers.Text.Tests.Utf8ParserTests.TryParseUInt32Hex(value: FFFFFFFFFFFFFFFF)``

Hot functions:

- (54.52%) ``Utf8Parser.TryParseUInt32X`` (Tier-1)
  - **Has diffs**
- (21.27%) ``Utf8Parser.TryParse`` (Tier-1)
  - No diffs
- (14.79%) ``Utf8ParserTests.TryParseUInt32Hex`` (Tier-1)
  - No diffs
- (3.88%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]Utf8Parser.TryParseUInt32X(value class System.ReadOnlySpan`1<unsigned int8>,unsigned int32&,int32&)``

```diff
 ;  V04 loc1         [V04,T00] ( 12, 37.50)   ubyte  ->  registers  
 ;* V05 loc2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ubyte]>
 ;  V06 loc3         [V06,T01] (  9, 29   )     int  ->  r13        
-;  V07 loc4         [V07,T03] (  6, 17   )     int  ->  r12        
-;  V08 loc5         [V08,T04] (  6, 17   )     int  ->  r12        
-;  V09 loc6         [V09,T05] (  6, 17   )     int  ->  r12        
+;  V07 loc4         [V07,T12] (  2,  1   )     int  ->  rdi        
+;  V08 loc5         [V08,T13] (  2,  1   )     int  ->  rdi        
+;  V09 loc6         [V09,T14] (  2,  1   )     int  ->  rbp        
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V12 tmp2         [V12,T06] (  5, 13.50)   byref  ->  rdi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
 ;  V13 tmp3         [V13,T08] (  7, 11.50)     int  ->  rbp         "field V00._length (fldOffset=0x8)" P-INDEP
 ;  V14 tmp4         [V14,T07] (  4, 12.50)   byref  ->  r14         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;* V15 tmp5         [V15,T14] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
-;  V16 tmp6         [V16,T13] (  2,  1.00)   byref  ->  r14         single-def "field V11._reference (fldOffset=0x0)" P-INDEP
-;* V17 tmp7         [V17,T15] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
+;* V15 tmp5         [V15,T17] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;  V16 tmp6         [V16,T16] (  2,  1.00)   byref  ->  r14         single-def "field V11._reference (fldOffset=0x0)" P-INDEP
+;* V17 tmp7         [V17,T18] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V18 tmp8         [V18    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ubyte]>
-;  V19 cse0         [V19,T12] (  3,  1.50)    long  ->  rcx         "CSE #01: moderate"
+;  V19 cse0         [V19,T15] (  3,  1.50)    long  ->  rcx         "CSE #01: moderate"
+;  V20 rat0         [V20,T03] (  6, 17   )    long  ->  r12         "Widened IV V08"
+;  V21 rat1         [V21,T04] (  6, 17   )    long  ->  r12         "Widened IV V09"
+;  V22 rat2         [V22,T05] (  6, 17   )    long  ->  r12         "Widened IV V07"
 ;
 ; Lcl frame size = 40
 
@@ -77,8 +80,7 @@ G_M43717_IG06:
        jle      G_M43717_IG21
 						;; size=20 bbWeight=0.50 PerfScore 1.38
 G_M43717_IG07:
-       mov      ecx, r12d
-       movzx    r15, byte  ptr [rdi+rcx]
+       movzx    r15, byte  ptr [rdi+r12]
        mov      ecx, r15d
        movzx    rcx, byte  ptr [r14+rcx]
        mov      r15d, ecx
@@ -91,22 +93,22 @@ G_M43717_IG07:
        inc      r12d
        cmp      r12d, ebp
        jl       SHORT G_M43717_IG07
-						;; size=58 bbWeight=4 PerfScore 38.00
+						;; size=55 bbWeight=4 PerfScore 37.00
 G_M43717_IG08:
        jmp      G_M43717_IG21
 						;; size=5 bbWeight=0.50 PerfScore 1.00
 G_M43717_IG09:
+       mov      edi, r12d
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      dword ptr [rbx], r12d
+       mov      dword ptr [rbx], edi
        jmp      G_M43717_IG22
-						;; size=23 bbWeight=0.50 PerfScore 2.12
+						;; size=25 bbWeight=0.50 PerfScore 2.25
 G_M43717_IG10:
        mov      r12d, 1
 						;; size=6 bbWeight=0.50 PerfScore 0.12
 G_M43717_IG11:
-       mov      ecx, r12d
-       movzx    r15, byte  ptr [rdi+rcx]
+       movzx    r15, byte  ptr [rdi+r12]
        mov      ecx, r15d
        movzx    r15, byte  ptr [r14+rcx]
        cmp      r15d, 255
@@ -118,13 +120,12 @@ G_M43717_IG11:
        inc      r12d
        cmp      r12d, 8
        jl       SHORT G_M43717_IG11
-						;; size=60 bbWeight=4 PerfScore 37.00
+						;; size=57 bbWeight=4 PerfScore 36.00
 G_M43717_IG12:
        mov      r12d, 8
 						;; size=6 bbWeight=0.50 PerfScore 0.12
 G_M43717_IG13:
-       mov      ecx, r12d
-       movzx    r15, byte  ptr [rdi+rcx]
+       movzx    r15, byte  ptr [rdi+r12]
        mov      ecx, r15d
        movzx    r15, byte  ptr [r14+rcx]
        cmp      r15d, 255
@@ -138,24 +139,26 @@ G_M43717_IG13:
        inc      r12d
        cmp      r12d, ebp
        jl       SHORT G_M43717_IG13
-						;; size=64 bbWeight=4 PerfScore 42.00
+						;; size=61 bbWeight=4 PerfScore 41.00
 G_M43717_IG14:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        jmp      SHORT G_M43717_IG21
 						;; size=17 bbWeight=0.25 PerfScore 0.81
 G_M43717_IG15:
+       mov      ebp, r12d
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      dword ptr [rbx], r12d
+       mov      dword ptr [rbx], ebp
        jmp      SHORT G_M43717_IG22
-						;; size=20 bbWeight=0.50 PerfScore 2.12
+						;; size=22 bbWeight=0.50 PerfScore 2.25
 G_M43717_IG16:
+       mov      edi, r12d
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      dword ptr [rbx], r12d
+       mov      dword ptr [rbx], edi
        jmp      SHORT G_M43717_IG22
-						;; size=20 bbWeight=0.50 PerfScore 2.12
+						;; size=22 bbWeight=0.50 PerfScore 2.25
 G_M43717_IG17:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
@@ -201,7 +204,7 @@ G_M43717_IG23:
        ret      
 						;; size=17 bbWeight=0.50 PerfScore 2.62
 
-; Total bytes of code 485, prolog size 22, PerfScore 155.81, instruction count 123, allocated bytes for code 485 (MethodHash=cec7553a) for method System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (Instrumented Tier1)
+; Total bytes of code 482, prolog size 22, PerfScore 153.19, instruction count 123, allocated bytes for code 482 (MethodHash=cec7553a) for method System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (Instrumented Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (Tier1)
@@ -211,30 +214,32 @@ G_M43717_IG23:
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 70560
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 62504
 ; 1 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T05] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
 ;  V01 arg1         [V01,T09] (  4,  3   )   byref  ->  rdx         single-def
 ;  V02 arg2         [V02,T07] (  7,  3   )   byref  ->   r8         single-def
-;  V03 loc0         [V03,T03] (  8, 18.04)   ubyte  ->  registers  
-;  V04 loc1         [V04,T01] ( 12, 27.06)   ubyte  ->  registers  
+;  V03 loc0         [V03,T03] (  8, 18.02)   ubyte  ->  registers  
+;  V04 loc1         [V04,T01] ( 12, 27.02)   ubyte  ->  registers  
 ;* V05 loc2         [V05    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ubyte]>
-;  V06 loc3         [V06,T02] (  9, 18.04)     int  ->  r11        
-;  V07 loc4         [V07,T15] (  6,  0   )     int  ->  rax        
-;  V08 loc5         [V08,T00] (  6, 29.08)     int  ->  rax        
-;  V09 loc6         [V09,T08] (  6,  5   )     int  ->  rax        
+;  V06 loc3         [V06,T02] (  9, 18.02)     int  ->  r11        
+;  V07 loc4         [V07,T17] (  6,  0   )     int  ->  rax        
+;  V08 loc5         [V08,T13] (  2,  0   )     int  ->  rax        
+;  V09 loc6         [V09,T14] (  2,  0   )     int  ->  rax        
 ;  V10 OutArgs      [V10    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V11 tmp1         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V12 tmp2         [V12,T04] (  5, 10.02)   byref  ->  r10         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V12 tmp2         [V12,T04] (  5, 10.01)   byref  ->  r10         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
 ;  V13 tmp3         [V13,T10] (  6,  4   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
-;  V14 tmp4         [V14,T06] (  4,  9.02)   byref  ->   r9         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
-;* V15 tmp5         [V15,T13] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
+;  V14 tmp4         [V14,T06] (  4,  9.01)   byref  ->   r9         single-def "field V05._reference (fldOffset=0x0)" P-INDEP
+;* V15 tmp5         [V15,T15] (  0,  0   )     int  ->  zero-ref    "field V05._length (fldOffset=0x8)" P-INDEP
 ;  V16 tmp6         [V16,T12] (  2,  2   )   byref  ->   r9         single-def "field V11._reference (fldOffset=0x0)" P-INDEP
-;* V17 tmp7         [V17,T14] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
+;* V17 tmp7         [V17,T16] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
 ;* V18 tmp8         [V18    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ubyte]>
 ;  V19 cse0         [V19,T11] (  3,  3   )    long  ->  rax         "CSE #01: aggressive"
+;  V20 rat0         [V20,T00] (  6, 29.03)    long  ->  rax         "Widened IV V08"
+;  V21 rat1         [V21,T08] (  6,  5   )    long  ->  rax         "Widened IV V09"
 ;
 ; Lcl frame size = 32
 
@@ -259,8 +264,7 @@ G_M43717_IG02:
        align    [0 bytes for IG03]
 						;; size=55 bbWeight=1 PerfScore 12.50
 G_M43717_IG03:
-       mov      ebx, eax
-       movzx    rbx, byte  ptr [r10+rbx]
+       movzx    rbx, byte  ptr [r10+rax]
        movzx    rbx, byte  ptr [r9+rbx]
        cmp      ebx, 255
        je       G_M43717_IG17
@@ -269,13 +273,12 @@ G_M43717_IG03:
        inc      eax
        cmp      eax, 8
        jl       SHORT G_M43717_IG03
-						;; size=38 bbWeight=7.02 PerfScore 54.40
+						;; size=36 bbWeight=7.01 PerfScore 52.56
 G_M43717_IG04:
        mov      eax, 8
 						;; size=5 bbWeight=1 PerfScore 0.25
 G_M43717_IG05:
-       mov      ebx, eax
-       movzx    rbx, byte  ptr [r10+rbx]
+       movzx    rbx, byte  ptr [r10+rax]
        movzx    rbx, byte  ptr [r9+rbx]
        cmp      ebx, 255
        je       SHORT G_M43717_IG16
@@ -287,7 +290,7 @@ G_M43717_IG05:
        cmp      eax, ecx
        jge      SHORT G_M43717_IG15
        jmp      SHORT G_M43717_IG05
-						;; size=44 bbWeight=1 PerfScore 11.00
+						;; size=42 bbWeight=1 PerfScore 10.75
 G_M43717_IG06:
        xor      eax, eax
        mov      dword ptr [r8], eax
@@ -345,6 +348,6 @@ G_M43717_IG17:
        jmp      SHORT G_M43717_IG09
 						;; size=5 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 236, prolog size 5, PerfScore 83.40, instruction count 72, allocated bytes for code 240 (MethodHash=cec7553a) for method System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (Tier1)
+; Total bytes of code 232, prolog size 5, PerfScore 81.31, instruction count 70, allocated bytes for code 236 (MethodHash=cec7553a) for method System.Buffers.Text.Utf8Parser:TryParseUInt32X(System.ReadOnlySpan`1[ubyte],byref,byref):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.Perf_Utf8Encoding.GetBytes(Input: Chinese)``

Hot functions:

- (54.46%) ``Utf8Utility.TranscodeToUtf8`` (Tier-1)
  - **Has diffs**
- (6.89%) ``Utf16Utility.GetPointerToFirstInvalidChar`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]Utf8Utility.TranscodeToUtf8(wchar*,int32,unsigned int8*,int32,wchar*&,unsigned int8*&)``

```diff
 ;  V00 arg0         [V00,T01] ( 61, 38.08)    long  ->  rbx        
 ;  V01 arg1         [V01,T04] ( 12,  5.97)     int  ->  rbp        
 ;  V02 arg2         [V02,T02] ( 60, 33.87)    long  ->  rsi        
-;  V03 arg3         [V03,T03] ( 45, 27.87)     int  ->  rdi        
+;  V03 arg3         [V03,T03] ( 45, 26.23)     int  ->  rdi        
 ;  V04 arg4         [V04,T21] (  2,  1   )   byref  ->  [rsp+0xC0]  single-def
 ;  V05 arg5         [V05,T22] (  2,  1   )   byref  ->  [rsp+0xC8]  single-def
 ;  V06 loc0         [V06,T05] ( 10,  6.97)    long  ->  r13        
 ;  V07 loc1         [V07,T33] (  2,  1.72)  simd16  ->  mm6         ld-addr-op <System.Runtime.Intrinsics.Vector128`1[short]>
-;  V08 loc2         [V08,T00] ( 45, 45.47)     int  ->  [rsp+0x2C] 
+;  V08 loc2         [V08,T00] ( 45, 45.37)     int  ->  [rsp+0x2C] 
 ;  V09 loc3         [V09,T28] ( 12,  0.44)     int  ->  r13        
-;  V10 loc4         [V10,T29] (  5,  0.29)     int  ->  r12        
-;  V11 loc5         [V11,T09] (  6,  4.29)    long  ->  rax        
+;  V10 loc4         [V10,T29] (  5,  0.29)     int  ->  r13        
+;  V11 loc5         [V11,T07] (  6,  4.29)    long  ->  rax        
 ;* V12 loc6         [V12    ] (  0,  0   )     int  ->  zero-ref   
 ;* V13 loc7         [V13    ] (  0,  0   )     int  ->  zero-ref   
 ;  V14 loc8         [V14,T26] (  3,  0.62)     int  ->  r12        
-;  V15 loc9         [V15,T14] (  3,  2.19)     int  ->  [rsp+0x28]  spill-single-def
+;  V15 loc9         [V15,T10] (  3,  2.19)     int  ->  [rsp+0x28]  spill-single-def
 ;  V16 loc10        [V16,T24] (  8,  0.81)    long  ->  r12        
 ;  V17 loc11        [V17,T06] (  6,  5.45)     int  ->  [rsp+0x24] 
 ;  V18 loc12        [V18,T32] ( 11,  6.79)  simd16  ->  mm7         <System.Runtime.Intrinsics.Vector128`1[short]>
@@ -37,34 +37,34 @@
 ;* V25 loc19        [V25    ] (  0,  0   )     int  ->  zero-ref   
 ;* V26 loc20        [V26    ] (  0,  0   )     int  ->  zero-ref   
 ;  V27 OutArgs      [V27    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V28 tmp1         [V28,T16] (  2,  2   )     int  ->   r8         "Inline return value spill temp"
+;  V28 tmp1         [V28,T12] (  2,  2   )     int  ->   r8         "Inline return value spill temp"
 ;  V29 tmp2         [V29,T27] (  3,  0.56)    long  ->  r12         "Inline return value spill temp"
 ;  V30 tmp3         [V30,T19] (  3,  1.42)    long  ->  r12         "Inlining Arg"
 ;  V31 tmp4         [V31,T20] (  3,  1.40)    long  ->  rax         "Inlining Arg"
-;* V32 tmp5         [V32,T12] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V33 tmp6         [V33,T13] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V34 tmp7         [V34,T08] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V35 tmp8         [V35,T07] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V32 tmp5         [V32,T14] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V33 tmp6         [V33,T15] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V34 tmp7         [V34,T09] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V35 tmp8         [V35,T08] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V36 tmp9         [V36    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V37 tmp10        [V37    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V38 tmp11        [V38,T25] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V39 tmp12        [V39,T10] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V40 tmp13        [V40,T18] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V41 tmp14        [V41,T11] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V39 tmp12        [V39,T16] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V40 tmp13        [V40,T17] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V41 tmp14        [V41,T18] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V42 tmp15        [V42    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V43 tmp16        [V43    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;* V44 tmp17        [V44,T15] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V44 tmp17        [V44,T11] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V45 tmp18        [V45    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V46 tmp19        [V46    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;* V47 tmp20        [V47,T31] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V48 tmp21        [V48,T30] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V47 tmp20        [V47,T30] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V48 tmp21        [V48,T31] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V49 tmp22        [V49,T35] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;  V50 tmp23        [V50,T34] (  5,  0   )     int  ->  rcx         "Inlining Arg"
 ;* V51 tmp24        [V51    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V52 tmp25        [V52    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V53 tmp26        [V53    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V54 tmp27        [V54    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V55 rat0         [V55,T17] (  3,  1.69)    long  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
+;  V55 rat0         [V55,T13] (  3,  1.69)    long  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;  V56 rat1         [V56,T23] (  3,  0.89)    long  ->  r13         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 88
@@ -96,7 +96,7 @@ G_M33313_IG02:
        lea      rbx, [rbx+2*rax]
        add      rsi, rax
        cmp      eax, ebp
-       jne      G_M33313_IG09
+       jne      G_M33313_IG10
 						;; size=36 bbWeight=1 PerfScore 6.25
 G_M33313_IG03:
        mov      rcx, 0xD1FFAB1E
@@ -124,11 +124,13 @@ G_M33313_IG04:
 G_M33313_IG05:
        lea      ecx, [r12+D1FFAB1EH]
        cmp      ecx, 0xD1FFAB1E
-       ja       SHORT G_M33313_IG10
-       cmp      edi, 4
-       jl       G_M33313_IG88
-						;; size=25 bbWeight=4.10 PerfScore 12.29
+       ja       SHORT G_M33313_IG11
+						;; size=16 bbWeight=4.10 PerfScore 7.17
 G_M33313_IG06:
+       cmp      edi, 4
+       jl       G_M33313_IG74
+						;; size=9 bbWeight=3.40 PerfScore 4.25
+G_M33313_IG07:
        mov      ecx, r12d
        shr      ecx, 6
        and      ecx, 0xD1FFAB1E
@@ -142,30 +144,30 @@ G_M33313_IG06:
        add      rsi, 4
        add      edi, -4
        cmp      rbx, r13
-       ja       G_M33313_IG63
+       ja       G_M33313_IG52
 						;; size=53 bbWeight=3.39 PerfScore 18.65
-G_M33313_IG07:
+G_M33313_IG08:
        mov      r12d, dword ptr [rbx]
        lea      ecx, [r12-0x80]
        movzx    rcx, cx
        cmp      ecx, 0x780
-       jae      G_M33313_IG23
+       jae      G_M33313_IG19
 						;; size=23 bbWeight=3.32 PerfScore 13.28
-G_M33313_IG08:
+G_M33313_IG09:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        jmp      SHORT G_M33313_IG05
-						;; size=17 bbWeight=3.32 PerfScore 10.79
-G_M33313_IG09:
+						;; size=17 bbWeight=2.61 PerfScore 8.50
+G_M33313_IG10:
        sub      ebp, eax
        sub      edi, eax
        cmp      ebp, 2
-       jl       G_M33313_IG64
-       jmp      G_M33313_IG22
+       jl       G_M33313_IG53
+       jmp      G_M33313_IG43
 						;; size=18 bbWeight=0.15 PerfScore 0.55
-G_M33313_IG10:
+G_M33313_IG11:
        cmp      edi, 2
-       jl       G_M33313_IG51
+       jl       G_M33313_IG38
        lea      ecx, [4*r12]
        and      ecx, 0x1F00
        mov      eax, r12d
@@ -174,9 +176,9 @@ G_M33313_IG10:
        movzx    rcx, cx
        movbe    word  ptr [rsi], cx
        cmp      r12d, 0xD1FFAB1E
-       jae      G_M33313_IG84
+       jae      G_M33313_IG87
        cmp      edi, 3
-       jl       G_M33313_IG57
+       jl       G_M33313_IG66
        mov      ecx, r12d
        shr      ecx, 16
        mov      byte  ptr [rsi+0x02], cl
@@ -184,35 +186,71 @@ G_M33313_IG10:
        add      rsi, 3
        add      edi, -3
 						;; size=86 bbWeight=0.71 PerfScore 6.88
-G_M33313_IG11:
-       cmp      rbx, r13
-       ja       G_M33313_IG49
-						;; size=9 bbWeight=0.76 PerfScore 0.95
 G_M33313_IG12:
+       cmp      rbx, r13
+       ja       G_M33313_IG36
+						;; size=9 bbWeight=0.76 PerfScore 0.95
+G_M33313_IG13:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
 						;; size=15 bbWeight=0.38 PerfScore 0.48
-G_M33313_IG13:
+G_M33313_IG14:
        mov      r12d, dword ptr [rbx]
 						;; size=3 bbWeight=0.87 PerfScore 1.75
-G_M33313_IG14:
-       test     r12d, 0xD1FFAB1E
-       je       SHORT G_M33313_IG18
-						;; size=9 bbWeight=1.70 PerfScore 2.12
 G_M33313_IG15:
-       test     r12d, 0xFF80
+       test     r12d, 0xD1FFAB1E
        je       G_M33313_IG24
-						;; size=13 bbWeight=1.64 PerfScore 2.05
+						;; size=13 bbWeight=1.70 PerfScore 2.12
 G_M33313_IG16:
-       test     r12d, 0xF800
-       jne      SHORT G_M33313_IG20
-						;; size=9 bbWeight=1.64 PerfScore 2.05
+       test     r12d, 0xFF80
+       je       G_M33313_IG35
+						;; size=13 bbWeight=1.64 PerfScore 2.05
 G_M33313_IG17:
+       test     r12d, 0xF800
+       jne      G_M33313_IG26
+						;; size=13 bbWeight=1.64 PerfScore 2.05
+G_M33313_IG18:
        jmp      G_M33313_IG05
 						;; size=5 bbWeight=0.83 PerfScore 1.66
-G_M33313_IG18:
+G_M33313_IG19:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      SHORT G_M33313_IG15
+						;; size=17 bbWeight=1.66 PerfScore 5.40
+G_M33313_IG20:
+       mov      eax, r12d
+       shr      eax, 3
+       mov      dword ptr [rsp+0x28], eax
+       xor      edx, edx
+       mov      dword ptr [rsp+0x24], edx
+       test     eax, eax
+       je       G_M33313_IG45
+						;; size=24 bbWeight=0.28 PerfScore 1.20
+G_M33313_IG21:
+       vmovups  xmm7, xmmword ptr [rbx]
+       vptest   xmm7, xmm6
+       jne      G_M33313_IG48
+						;; size=15 bbWeight=1.57 PerfScore 12.56
+G_M33313_IG22:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       vpackuswb xmm0, xmm7, xmm7
+       vmovq    qword ptr [rsi], xmm0
+       add      rbx, 16
+       add      rsi, 8
+       mov      edx, dword ptr [rsp+0x24]
+       inc      edx
+       mov      ecx, dword ptr [rsp+0x28]
+       cmp      edx, ecx
+       mov      dword ptr [rsp+0x24], edx
+       jb       SHORT G_M33313_IG21
+						;; size=49 bbWeight=1.63 PerfScore 15.05
+G_M33313_IG23:
+       jmp      G_M33313_IG45
+						;; size=5 bbWeight=0.06 PerfScore 0.11
+G_M33313_IG24:
        cmp      edi, 2
-       jl       G_M33313_IG55
+       jl       G_M33313_IG65
        mov      ecx, r12d
        shr      ecx, 8
        or       ecx, r12d
@@ -230,149 +268,25 @@ G_M33313_IG18:
        mov      r12d, ecx
        movsxd   rax, edi
        cmp      r12, rax
-       jle      SHORT G_M33313_IG26
-						;; size=65 bbWeight=0.28 PerfScore 2.25
-G_M33313_IG19:
+       jle      G_M33313_IG20
+						;; size=69 bbWeight=0.28 PerfScore 2.25
+G_M33313_IG25:
        mov      r12, rax
-       jmp      SHORT G_M33313_IG26
-						;; size=5 bbWeight=0.14 PerfScore 0.31
-G_M33313_IG20:
+       jmp      G_M33313_IG20
+						;; size=8 bbWeight=0.14 PerfScore 0.31
+G_M33313_IG26:
        lea      ecx, [r12-0xD800]
        test     ecx, 0xF800
-       je       G_M33313_IG86
+       je       G_M33313_IG89
        test     r12d, 0xD1FFAB1E
-       je       G_M33313_IG46
+       je       G_M33313_IG31
+						;; size=33 bbWeight=1.54 PerfScore 4.61
+G_M33313_IG27:
        lea      ecx, [r12+D1FFAB1EH]
        cmp      ecx, 0xD1FFAB1E
-       jb       G_M33313_IG45
-						;; size=53 bbWeight=1.54 PerfScore 7.31
-G_M33313_IG21:
-       jmp      G_M33313_IG40
-						;; size=5 bbWeight=1.44 PerfScore 2.88
-G_M33313_IG22:
-       mov      ecx, ebp
-       lea      r13, [rbx+2*rcx-0x04]
-       vmovups  xmm6, xmmword ptr [reloc @RWD00]
-       jmp      G_M33313_IG13
-						;; size=20 bbWeight=0.15 PerfScore 0.94
-G_M33313_IG23:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG14
-						;; size=20 bbWeight=1.66 PerfScore 5.40
-G_M33313_IG24:
-       test     edi, edi
-       je       G_M33313_IG56
-						;; size=8 bbWeight=1.64 PerfScore 2.05
-G_M33313_IG25:
-       jmp      G_M33313_IG42
-						;; size=5 bbWeight=0.69 PerfScore 1.39
-G_M33313_IG26:
-       mov      eax, r12d
-       shr      eax, 3
-       mov      dword ptr [rsp+0x28], eax
-       xor      edx, edx
-       mov      dword ptr [rsp+0x24], edx
-       test     eax, eax
-       je       SHORT G_M33313_IG33
-						;; size=20 bbWeight=0.28 PerfScore 1.20
-G_M33313_IG27:
-       vmovups  xmm7, xmmword ptr [rbx]
-       vptest   xmm7, xmm6
-       jne      SHORT G_M33313_IG34
-						;; size=11 bbWeight=1.57 PerfScore 12.56
-G_M33313_IG28:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       vpackuswb xmm0, xmm7, xmm7
-       vmovq    qword ptr [rsi], xmm0
-       add      rbx, 16
-       add      rsi, 8
-       mov      edx, dword ptr [rsp+0x24]
-       inc      edx
-       mov      ecx, dword ptr [rsp+0x28]
-       cmp      edx, ecx
-       jb       SHORT G_M33313_IG32
-						;; size=45 bbWeight=1.63 PerfScore 13.43
-G_M33313_IG29:
-       shl      edx, 3
-       sub      edi, edx
-       test     r12b, 4
-       je       G_M33313_IG53
-						;; size=15 bbWeight=0.06 PerfScore 0.11
-G_M33313_IG30:
-       mov      r12, qword ptr [rbx]
-       mov      rcx, 0xD1FFAB1E
-       test     r12, rcx
-       jne      SHORT G_M33313_IG36
-						;; size=18 bbWeight=0.02 PerfScore 0.07
-G_M33313_IG31:
-       jmp      G_M33313_IG52
-						;; size=5 bbWeight=0.02 PerfScore 0.04
-G_M33313_IG32:
-       mov      dword ptr [rsp+0x24], edx
-       jmp      SHORT G_M33313_IG27
-						;; size=6 bbWeight=0.81 PerfScore 2.44
-G_M33313_IG33:
-       mov      edx, dword ptr [rsp+0x24]
-       jmp      SHORT G_M33313_IG29
-						;; size=6 bbWeight=0.14 PerfScore 0.42
-G_M33313_IG34:
-       mov      edx, dword ptr [rsp+0x24]
-       lea      ecx, [8*rdx]
-       sub      edi, ecx
-       vmovd    r12, xmm7
-       mov      rcx, 0xD1FFAB1E
-       test     r12, rcx
-       je       SHORT G_M33313_IG39
-						;; size=33 bbWeight=0.22 PerfScore 1.18
-G_M33313_IG35:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-						;; size=15 bbWeight=0.11 PerfScore 0.14
-G_M33313_IG36:
-       mov      eax, r12d
-       mov      dword ptr [rsp+0x2C], eax
-       test     eax, 0xD1FFAB1E
-       je       SHORT G_M33313_IG38
-						;; size=14 bbWeight=0.22 PerfScore 0.56
-G_M33313_IG37:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      r12d, dword ptr [rsp+0x2C]
-       jmp      G_M33313_IG15
-						;; size=25 bbWeight=0.11 PerfScore 0.47
-G_M33313_IG38:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      eax, dword ptr [rsp+0x2C]
-       mov      ecx, eax
-       shr      ecx, 8
-       or       ecx, eax
-       mov      word  ptr [rsi], cx
-       add      rbx, 4
-       add      rsi, 2
-       add      edi, -2
-       shr      r12, 32
-       mov      eax, r12d
-       mov      dword ptr [rsp+0x2C], eax
-       mov      r12d, dword ptr [rsp+0x2C]
-       jmp      G_M33313_IG15
-						;; size=61 bbWeight=0.05 PerfScore 0.46
-G_M33313_IG39:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       vpackuswb xmm0, xmm7, xmm7
-       vmovd    dword ptr [rsi], xmm0
-       add      rbx, 8
-       add      rsi, 4
-       add      edi, -4
-       vpextrq  r12, xmm7, 1
-       jmp      G_M33313_IG36
-						;; size=45 bbWeight=0.04 PerfScore 0.38
-G_M33313_IG40:
+       jb       G_M33313_IG88
        cmp      edi, 6
-       jl       G_M33313_IG44
+       jl       G_M33313_IG30
        lea      ecx, [4*r12]
        and      ecx, 0x3F00
        mov      eax, r12d
@@ -402,43 +316,25 @@ G_M33313_IG40:
        add      rsi, 6
        add      edi, -6
        cmp      rbx, r13
-       ja       G_M33313_IG47
-						;; size=118 bbWeight=1.44 PerfScore 18.02
-G_M33313_IG41:
-       jmp      SHORT G_M33313_IG43
-						;; size=2 bbWeight=1.40 PerfScore 2.80
-G_M33313_IG42:
-       mov      byte  ptr [rsi], r12b
-       add      rbx, 2
-       inc      rsi
-       dec      edi
-       cmp      rbx, r13
-       ja       G_M33313_IG54
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      r12d, dword ptr [rbx]
-       jmp      G_M33313_IG16
-						;; size=44 bbWeight=0.69 PerfScore 5.73
-G_M33313_IG43:
+       ja       G_M33313_IG33
+						;; size=138 bbWeight=1.44 PerfScore 20.54
+G_M33313_IG28:
        mov      r12d, dword ptr [rbx]
        test     r12d, 0xF800
-       je       G_M33313_IG48
+       je       G_M33313_IG34
+						;; size=16 bbWeight=1.40 PerfScore 4.56
+G_M33313_IG29:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG20
-						;; size=36 bbWeight=1.40 PerfScore 9.12
-G_M33313_IG44:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG46
-						;; size=17 bbWeight=0.72 PerfScore 2.34
-G_M33313_IG45:
+       jmp      G_M33313_IG26
+						;; size=20 bbWeight=1.37 PerfScore 4.47
+G_M33313_IG30:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
 						;; size=15 bbWeight=0.72 PerfScore 0.90
-G_M33313_IG46:
+G_M33313_IG31:
        cmp      edi, 3
-       jl       G_M33313_IG60
+       jl       G_M33313_IG71
        lea      ecx, [4*r12]
        and      ecx, 0x3F00
        movzx    rax, r12w
@@ -454,9 +350,9 @@ G_M33313_IG46:
        add      rsi, 3
        add      edi, -3
        cmp      r12d, 0xD1FFAB1E
-       jae      G_M33313_IG85
+       jae      G_M33313_IG39
        test     edi, edi
-       je       G_M33313_IG59
+       je       G_M33313_IG70
        mov      ecx, r12d
        shr      ecx, 16
        mov      byte  ptr [rsi], cl
@@ -464,100 +360,135 @@ G_M33313_IG46:
        inc      rsi
        dec      edi
        cmp      rbx, r13
-       ja       G_M33313_IG58
+       ja       G_M33313_IG67
        mov      r12d, dword ptr [rbx]
        test     r12d, 0xF800
-       je       SHORT G_M33313_IG50
+       jne      G_M33313_IG37
+						;; size=127 bbWeight=0.10 PerfScore 1.57
+G_M33313_IG32:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG20
-						;; size=143 bbWeight=0.10 PerfScore 1.88
-G_M33313_IG47:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG63
-						;; size=20 bbWeight=0.72 PerfScore 2.34
-G_M33313_IG48:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG14
-						;; size=20 bbWeight=0.70 PerfScore 2.28
-G_M33313_IG49:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG63
-						;; size=20 bbWeight=0.38 PerfScore 1.24
-G_M33313_IG50:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG14
+       jmp      G_M33313_IG15
 						;; size=20 bbWeight=0.05 PerfScore 0.16
-G_M33313_IG51:
+G_M33313_IG33:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG82
+       jmp      G_M33313_IG52
+						;; size=20 bbWeight=0.72 PerfScore 2.34
+G_M33313_IG34:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG15
+						;; size=20 bbWeight=0.70 PerfScore 2.28
+G_M33313_IG35:
+       test     edi, edi
+       je       G_M33313_IG44
+       mov      byte  ptr [rsi], r12b
+       add      rbx, 2
+       inc      rsi
+       dec      edi
+       cmp      rbx, r13
+       ja       G_M33313_IG42
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      r12d, dword ptr [rbx]
+       jmp      G_M33313_IG17
+						;; size=52 bbWeight=0.69 PerfScore 6.60
+G_M33313_IG36:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG52
+						;; size=20 bbWeight=0.38 PerfScore 1.24
+G_M33313_IG37:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG26
+						;; size=20 bbWeight=0.05 PerfScore 0.15
+G_M33313_IG38:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG85
 						;; size=20 bbWeight=0.35 PerfScore 1.15
-G_M33313_IG52:
+G_M33313_IG39:
+       cmp      rbx, r13
+       ja       G_M33313_IG72
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      r12d, dword ptr [rbx]
+       jmp      G_M33313_IG16
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M33313_IG40:
        vmovd    xmm7, r12
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        vpackuswb xmm0, xmm7, xmm7
        vmovd    dword ptr [rsi], xmm0
        add      rbx, 8
-       jmp      G_M33313_IG87
+       jmp      G_M33313_IG90
 						;; size=37 bbWeight=0.02 PerfScore 0.16
-G_M33313_IG53:
+G_M33313_IG41:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG11
+       jmp      G_M33313_IG12
 						;; size=20 bbWeight=0.03 PerfScore 0.09
-G_M33313_IG54:
+G_M33313_IG42:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG63
+       jmp      G_M33313_IG52
 						;; size=20 bbWeight=0.35 PerfScore 1.13
-G_M33313_IG55:
+G_M33313_IG43:
+       mov      ecx, ebp
+       lea      r13, [rbx+2*rcx-0x04]
+       vmovups  xmm6, xmmword ptr [reloc @RWD00]
+       jmp      G_M33313_IG14
+						;; size=20 bbWeight=0.15 PerfScore 0.94
+G_M33313_IG44:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG88
-						;; size=20 bbWeight=0.14 PerfScore 0.46
-G_M33313_IG56:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG82
+       jmp      G_M33313_IG85
 						;; size=20 bbWeight=0.35 PerfScore 1.13
-G_M33313_IG57:
+G_M33313_IG45:
+       mov      edx, dword ptr [rsp+0x24]
+       shl      edx, 3
+       sub      edi, edx
+       test     r12b, 4
+       je       SHORT G_M33313_IG41
+						;; size=15 bbWeight=0.06 PerfScore 0.17
+G_M33313_IG46:
+       mov      r12, qword ptr [rbx]
+       mov      rcx, 0xD1FFAB1E
+       test     r12, rcx
+       jne      SHORT G_M33313_IG50
+						;; size=18 bbWeight=0.02 PerfScore 0.07
+G_M33313_IG47:
+       jmp      G_M33313_IG40
+						;; size=5 bbWeight=0.02 PerfScore 0.04
+G_M33313_IG48:
+       mov      edx, dword ptr [rsp+0x24]
+       lea      ecx, [8*rdx]
+       sub      edi, ecx
+       vmovd    r12, xmm7
+       mov      rcx, 0xD1FFAB1E
+       test     r12, rcx
+       je       G_M33313_IG60
+						;; size=37 bbWeight=0.22 PerfScore 1.18
+G_M33313_IG49:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       add      rbx, 2
-       add      rsi, 2
-       jmp      G_M33313_IG82
-						;; size=28 bbWeight=0 PerfScore 0.00
-G_M33313_IG58:
+						;; size=15 bbWeight=0.11 PerfScore 0.14
+G_M33313_IG50:
+       mov      eax, r12d
+       mov      dword ptr [rsp+0x2C], eax
+       test     eax, 0xD1FFAB1E
+       je       SHORT G_M33313_IG57
+						;; size=14 bbWeight=0.22 PerfScore 0.56
+G_M33313_IG51:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG63
-						;; size=17 bbWeight=0.05 PerfScore 0.16
-G_M33313_IG59:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG82
-						;; size=20 bbWeight=0.05 PerfScore 0.16
-G_M33313_IG60:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      G_M33313_IG82
-						;; size=20 bbWeight=0.05 PerfScore 0.16
-G_M33313_IG61:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG63
-						;; size=17 bbWeight=0 PerfScore 0.00
-G_M33313_IG62:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M33313_IG63:
+       mov      r12d, dword ptr [rsp+0x2C]
+       jmp      G_M33313_IG16
+						;; size=25 bbWeight=0.11 PerfScore 0.47
+G_M33313_IG52:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        sub      r13, rbx
@@ -567,82 +498,72 @@ G_M33313_IG63:
        sar      rbp, 1
        add      ebp, 2
 						;; size=34 bbWeight=0.15 PerfScore 0.48
-G_M33313_IG64:
+G_M33313_IG53:
        test     ebp, ebp
-       je       G_M33313_IG72
+       je       G_M33313_IG62
 						;; size=8 bbWeight=0.15 PerfScore 0.18
-G_M33313_IG65:
+G_M33313_IG54:
        movzx    r13, word  ptr [rbx]
 						;; size=4 bbWeight=0.09 PerfScore 0.18
-G_M33313_IG66:
+G_M33313_IG55:
        cmp      r13d, 127
-       jbe      G_M33313_IG80
+       ja       G_M33313_IG68
 						;; size=10 bbWeight=0.09 PerfScore 0.11
-G_M33313_IG67:
-       cmp      r13d, 0x800
-       jae      SHORT G_M33313_IG69
-						;; size=9 bbWeight=0.06 PerfScore 0.07
-G_M33313_IG68:
-       cmp      edi, 2
-       jl       G_M33313_IG81
+G_M33313_IG56:
+       jmp      G_M33313_IG75
+						;; size=5 bbWeight=0.03 PerfScore 0.06
+G_M33313_IG57:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      ecx, r13d
-       and      ecx, 63
-       or       ecx, -128
-       mov      byte  ptr [rsi+0x01], cl
-       shr      r13d, 6
-       or       r13d, -64
-       mov      byte  ptr [rsi], r13b
-       add      rbx, 2
+       mov      eax, dword ptr [rsp+0x2C]
+       mov      ecx, eax
+       shr      ecx, 8
+       or       ecx, eax
+       mov      word  ptr [rsi], cx
+       add      rbx, 4
        add      rsi, 2
-       jmp      SHORT G_M33313_IG70
-						;; size=57 bbWeight=0.03 PerfScore 0.25
-G_M33313_IG69:
-       lea      ecx, [r13-0xD800]
-       cmp      ecx, 0x7FF
-       jbe      G_M33313_IG77
-       cmp      edi, 3
-       jl       G_M33313_IG76
+       add      edi, -2
+       shr      r12, 32
+       mov      eax, r12d
+       mov      dword ptr [rsp+0x2C], eax
+       mov      r12d, dword ptr [rsp+0x2C]
+       jmp      G_M33313_IG16
+						;; size=61 bbWeight=0.05 PerfScore 0.46
+G_M33313_IG58:
+       cmp      ebp, 1
+       jg       G_M33313_IG76
+						;; size=9 bbWeight=0.09 PerfScore 0.11
+G_M33313_IG59:
+       jmp      SHORT G_M33313_IG61
+						;; size=2 bbWeight=0.04 PerfScore 0.09
+G_M33313_IG60:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      ecx, r13d
-       and      ecx, 63
-       or       ecx, -128
-       mov      byte  ptr [rsi+0x02], cl
-       mov      ecx, r13d
-       shr      ecx, 6
-       and      ecx, 63
-       or       ecx, -128
-       mov      byte  ptr [rsi+0x01], cl
-       mov      ecx, r13d
-       shr      ecx, 12
-       or       ecx, -32
-       mov      byte  ptr [rsi], cl
-       add      rbx, 2
-       add      rsi, 3
-						;; size=89 bbWeight=0.03 PerfScore 0.32
-G_M33313_IG70:
-       cmp      ebp, 1
-       jg       SHORT G_M33313_IG75
-						;; size=5 bbWeight=0.09 PerfScore 0.11
-G_M33313_IG71:
+       vpackuswb xmm0, xmm7, xmm7
+       vmovd    dword ptr [rsi], xmm0
+       add      rbx, 8
+       add      rsi, 4
+       add      edi, -4
+       vpextrq  r12, xmm7, 1
+       jmp      G_M33313_IG50
+						;; size=45 bbWeight=0.04 PerfScore 0.38
+G_M33313_IG61:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
 						;; size=15 bbWeight=0.04 PerfScore 0.05
-G_M33313_IG72:
-       xor      r12d, r12d
+G_M33313_IG62:
+       xor      r13d, r13d
 						;; size=3 bbWeight=0.15 PerfScore 0.04
-G_M33313_IG73:
+G_M33313_IG63:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      r14, bword ptr [rsp+0xC0]
        mov      qword ptr [r14], rbx
        mov      r15, bword ptr [rsp+0xC8]
        mov      qword ptr [r15], rsi
-       mov      eax, r12d
+       mov      eax, r13d
 						;; size=40 bbWeight=0.15 PerfScore 0.81
-G_M33313_IG74:
+G_M33313_IG64:
        vmovaps  xmm6, xmmword ptr [rsp+0x40]
        vmovaps  xmm7, xmmword ptr [rsp+0x30]
        add      rsp, 88
@@ -656,80 +577,175 @@ G_M33313_IG74:
        pop      r15
        ret      
 						;; size=29 bbWeight=0.15 PerfScore 1.95
+G_M33313_IG65:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG74
+						;; size=20 bbWeight=0.14 PerfScore 0.46
+G_M33313_IG66:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       add      rbx, 2
+       add      rsi, 2
+       jmp      G_M33313_IG85
+						;; size=28 bbWeight=0 PerfScore 0.00
+G_M33313_IG67:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG52
+						;; size=20 bbWeight=0.05 PerfScore 0.16
+G_M33313_IG68:
+       cmp      r13d, 0x800
+       jae      G_M33313_IG78
+						;; size=13 bbWeight=0.06 PerfScore 0.07
+G_M33313_IG69:
+       jmp      G_M33313_IG77
+						;; size=5 bbWeight=0.03 PerfScore 0.06
+G_M33313_IG70:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG85
+						;; size=20 bbWeight=0.05 PerfScore 0.16
+G_M33313_IG71:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG85
+						;; size=20 bbWeight=0.05 PerfScore 0.16
+G_M33313_IG72:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG52
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M33313_IG73:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      G_M33313_IG52
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M33313_IG74:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       movzx    r13, r12w
+       jmp      G_M33313_IG55
+						;; size=24 bbWeight=0 PerfScore 0.00
 G_M33313_IG75:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG82
-						;; size=17 bbWeight=0.04 PerfScore 0.14
-G_M33313_IG76:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG82
-						;; size=17 bbWeight=0.01 PerfScore 0.05
-G_M33313_IG77:
-       cmp      r13d, 0xDBFF
-       ja       SHORT G_M33313_IG83
-       jmp      G_M33313_IG89
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M33313_IG78:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG82
-						;; size=17 bbWeight=0 PerfScore 0.00
-G_M33313_IG79:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       jmp      SHORT G_M33313_IG83
-						;; size=17 bbWeight=0 PerfScore 0.00
-G_M33313_IG80:
        test     edi, edi
-       je       SHORT G_M33313_IG82
+       je       G_M33313_IG85
        mov      byte  ptr [rsi], r13b
        add      rbx, 2
        inc      rsi
-       jmp      G_M33313_IG70
-						;; size=19 bbWeight=0.03 PerfScore 0.14
-G_M33313_IG81:
+       jmp      G_M33313_IG58
+						;; size=23 bbWeight=0.03 PerfScore 0.14
+G_M33313_IG76:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-						;; size=15 bbWeight=0.01 PerfScore 0.02
+       jmp      G_M33313_IG85
+						;; size=20 bbWeight=0.04 PerfScore 0.14
+G_M33313_IG77:
+       cmp      edi, 2
+       jl       G_M33313_IG80
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      ecx, r13d
+       and      ecx, 63
+       or       ecx, -128
+       mov      byte  ptr [rsi+0x01], cl
+       mov      ecx, r13d
+       shr      ecx, 6
+       or       ecx, -64
+       mov      byte  ptr [rsi], cl
+       add      rbx, 2
+       add      rsi, 2
+       jmp      G_M33313_IG58
+						;; size=60 bbWeight=0.03 PerfScore 0.26
+G_M33313_IG78:
+       lea      ecx, [r13-0xD800]
+       cmp      ecx, 0x7FF
+       jbe      SHORT G_M33313_IG81
+       cmp      edi, 3
+       jl       SHORT G_M33313_IG79
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      ecx, r13d
+       and      ecx, 63
+       or       ecx, -128
+       mov      byte  ptr [rsi+0x02], cl
+       mov      ecx, r13d
+       shr      ecx, 6
+       and      ecx, 63
+       or       ecx, -128
+       mov      byte  ptr [rsi+0x01], cl
+       shr      r13d, 12
+       or       r13d, -32
+       mov      byte  ptr [rsi], r13b
+       add      rbx, 2
+       add      rsi, 3
+       jmp      G_M33313_IG58
+						;; size=86 bbWeight=0.03 PerfScore 0.37
+G_M33313_IG79:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      SHORT G_M33313_IG85
+						;; size=17 bbWeight=0.01 PerfScore 0.05
+G_M33313_IG80:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       jmp      SHORT G_M33313_IG85
+						;; size=17 bbWeight=0.01 PerfScore 0.05
+G_M33313_IG81:
+       cmp      r13d, 0xDBFF
+       ja       SHORT G_M33313_IG86
+       jmp      SHORT G_M33313_IG84
+						;; size=11 bbWeight=0 PerfScore 0.00
 G_M33313_IG82:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      r12d, 1
-       jmp      G_M33313_IG73
-						;; size=26 bbWeight=0 PerfScore 0.00
+       jmp      SHORT G_M33313_IG85
+						;; size=17 bbWeight=0 PerfScore 0.00
 G_M33313_IG83:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      r12d, 3
-       jmp      G_M33313_IG73
-						;; size=26 bbWeight=0 PerfScore 0.00
+       jmp      SHORT G_M33313_IG86
+						;; size=17 bbWeight=0 PerfScore 0.00
 G_M33313_IG84:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      r13d, 2
+       jmp      G_M33313_IG63
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M33313_IG85:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      r13d, 1
+       jmp      G_M33313_IG63
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M33313_IG86:
+       mov      rcx, 0xD1FFAB1E
+       call     CORINFO_HELP_COUNTPROFILE32
+       mov      r13d, 3
+       jmp      G_M33313_IG63
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M33313_IG87:
        add      rbx, 2
        add      rsi, 2
        add      edi, -2
        cmp      rbx, r13
-       ja       G_M33313_IG62
+       ja       G_M33313_IG73
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      r12d, dword ptr [rbx]
-       jmp      G_M33313_IG20
+       jmp      G_M33313_IG26
 						;; size=43 bbWeight=0 PerfScore 0.00
-G_M33313_IG85:
-       cmp      rbx, r13
-       ja       G_M33313_IG61
+G_M33313_IG88:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
-       mov      r12d, dword ptr [rbx]
-       jmp      G_M33313_IG15
-						;; size=32 bbWeight=0 PerfScore 0.00
-G_M33313_IG86:
+       jmp      G_M33313_IG31
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M33313_IG89:
        lea      ecx, [r12+D1FFAB1EH]
        test     ecx, 0xD1FFAB1E
-       jne      G_M33313_IG79
+       jne      G_M33313_IG83
        cmp      edi, 4
-       jl       G_M33313_IG78
+       jl       G_M33313_IG82
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        lea      ecx, [r12+0x40]
@@ -752,27 +768,15 @@ G_M33313_IG86:
        mov      dword ptr [rsi], ecx
        add      rbx, 4
 						;; size=107 bbWeight=0 PerfScore 0.00
-G_M33313_IG87:
+G_M33313_IG90:
        add      rsi, 4
        add      edi, -4
-       jmp      G_M33313_IG11
+       jmp      G_M33313_IG12
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M33313_IG88:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       movzx    r13, r12w
-       jmp      G_M33313_IG66
-						;; size=24 bbWeight=0 PerfScore 0.00
-G_M33313_IG89:
-       mov      rcx, 0xD1FFAB1E
-       call     CORINFO_HELP_COUNTPROFILE32
-       mov      r12d, 2
-       jmp      G_M33313_IG73
-						;; size=26 bbWeight=0 PerfScore 0.00
 RWD00  	dq	FF80FF80FF80FF80h, FF80FF80FF80FF80h
 
 
-; Total bytes of code 2352, prolog size 39, PerfScore 221.25, instruction count 522, allocated bytes for code 2352 (MethodHash=85587dde) for method System.Text.Unicode.Utf8Utility:TranscodeToUtf8(ulong,int,ulong,int,byref,byref):int (Instrumented Tier1)
+; Total bytes of code 2405, prolog size 39, PerfScore 206.30, instruction count 524, allocated bytes for code 2405 (MethodHash=85587dde) for method System.Text.Unicode.Utf8Utility:TranscodeToUtf8(ulong,int,ulong,int,byref,byref):int (Instrumented Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Text.Unicode.Utf8Utility:TranscodeToUtf8(ulong,int,ulong,int,byref,byref):int (Tier1)
@@ -782,29 +786,29 @@ RWD00  	dq	FF80FF80FF80FF80h, FF80FF80FF80FF80h
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 622
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 601
 ; 13 inlinees with PGO data; 12 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T02] ( 61,126412.32)    long  ->  rsi        
-;  V01 arg1         [V01,T22] ( 12,    29.78)     int  ->  rbp        
-;  V02 arg2         [V02,T01] ( 60,127109.21)    long  ->  rbx        
-;  V03 arg3         [V03,T03] ( 45, 94948.99)     int  ->  rdi        
+;  V00 arg0         [V00,T02] ( 61,126018.50)    long  ->  rsi        
+;  V01 arg1         [V01,T23] ( 12,    13.77)     int  ->  rbp        
+;  V02 arg2         [V02,T01] ( 60,126760.10)    long  ->  rbx        
+;  V03 arg3         [V03,T03] ( 45, 93756.24)     int  ->  rdi        
 ;  V04 arg4         [V04,T29] (  2,     1   )   byref  ->  [rsp+0x80]  single-def
 ;  V05 arg5         [V05,T30] (  2,     1   )   byref  ->  [rsp+0x88]  single-def
-;  V06 loc0         [V06,T07] ( 10, 28192.16)    long  ->  rcx        
-;  V07 loc1         [V07,T32] (  2,  3869.13)  simd16  ->  mm0         ld-addr-op <System.Runtime.Intrinsics.Vector128`1[short]>
-;  V08 loc2         [V08,T00] ( 45,298934.65)     int  ->  registers  
-;  V09 loc3         [V09,T26] ( 12,     3.00)     int  ->  rcx        
-;  V10 loc4         [V10,T28] (  5,     2.00)     int  ->  rax        
-;  V11 loc5         [V11,T24] (  6,     6.00)    long  ->  rax        
+;  V06 loc0         [V06,T05] ( 10, 28125.61)    long  ->  rcx        
+;  V07 loc1         [V07,T32] (  2,  3791.81)  simd16  ->  mm0         ld-addr-op <System.Runtime.Intrinsics.Vector128`1[short]>
+;  V08 loc2         [V08,T00] ( 45,296230.01)     int  ->  registers  
+;  V09 loc3         [V09,T26] ( 12,     3   )     int  ->  rcx        
+;  V10 loc4         [V10,T27] (  5,     2   )     int  ->  rax        
+;  V11 loc5         [V11,T24] (  6,     6   )    long  ->  rax        
 ;* V12 loc6         [V12    ] (  0,     0   )     int  ->  zero-ref   
 ;* V13 loc7         [V13    ] (  0,     0   )     int  ->  zero-ref   
-;  V14 loc8         [V14,T17] (  3,  2808.13)     int  ->  rdx        
-;  V15 loc9         [V15,T13] (  3,  6658.47)     int  ->  rax        
-;  V16 loc10        [V16,T14] (  8,  4897.49)    long  ->  rdx        
-;  V17 loc11        [V17,T09] (  6, 14365.91)     int  ->   r8        
-;  V18 loc12        [V18,T31] ( 11, 17775.21)  simd16  ->  mm1         <System.Runtime.Intrinsics.Vector128`1[short]>
+;  V14 loc8         [V14,T15] (  3,  2803.08)     int  ->  rdx        
+;  V15 loc9         [V15,T13] (  3,  6592.12)     int  ->  rax        
+;  V16 loc10        [V16,T14] (  8,  4909.46)    long  ->  rdx        
+;  V17 loc11        [V17,T09] (  6, 14177.01)     int  ->   r8        
+;  V18 loc12        [V18,T31] ( 11, 17523.86)  simd16  ->  mm1         <System.Runtime.Intrinsics.Vector128`1[short]>
 ;* V19 loc13        [V19    ] (  0,     0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;* V20 loc14        [V20    ] (  0,     0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;* V21 loc15        [V21    ] (  0,     0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
@@ -814,35 +818,35 @@ RWD00  	dq	FF80FF80FF80FF80h, FF80FF80FF80FF80h
 ;* V25 loc19        [V25    ] (  0,     0   )     int  ->  zero-ref   
 ;* V26 loc20        [V26    ] (  0,     0   )     int  ->  zero-ref   
 ;  V27 OutArgs      [V27    ] (  1,     1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V28 tmp1         [V28,T27] (  2,     2   )     int  ->   r8         "Inline return value spill temp"
-;  V29 tmp2         [V29,T18] (  3,  2804.75)    long  ->  rdx         "Inline return value spill temp"
-;  V30 tmp3         [V30,T11] (  3,  7052.14)    long  ->  rax         "Inlining Arg"
-;  V31 tmp4         [V31,T12] (  3,  6971.62)    long  ->  rdx         "Inlining Arg"
-;* V32 tmp5         [V32,T15] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V33 tmp6         [V33,T16] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V28 tmp1         [V28,T28] (  2,     2   )     int  ->   r8         "Inline return value spill temp"
+;  V29 tmp2         [V29,T16] (  3,  2799.68)    long  ->  rdx         "Inline return value spill temp"
+;  V30 tmp3         [V30,T11] (  3,  7039.40)    long  ->  rax         "Inlining Arg"
+;  V31 tmp4         [V31,T12] (  3,  6959.02)    long  ->  rdx         "Inlining Arg"
+;* V32 tmp5         [V32,T17] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V33 tmp6         [V33,T18] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V34 tmp7         [V34,T21] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V35 tmp8         [V35,T34] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V36 tmp9         [V36    ] (  0,     0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V37 tmp10        [V37    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;* V38 tmp11        [V38,T23] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V39 tmp12        [V39,T04] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V40 tmp13        [V40,T08] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V41 tmp14        [V41,T05] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V38 tmp11        [V38,T22] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V39 tmp12        [V39,T07] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V40 tmp13        [V40,T06] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V41 tmp14        [V41,T08] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V42 tmp15        [V42    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V43 tmp16        [V43    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;* V44 tmp17        [V44,T06] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V44 tmp17        [V44,T04] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V45 tmp18        [V45    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V46 tmp19        [V46    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;* V47 tmp20        [V47,T20] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;* V48 tmp21        [V48,T19] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V47 tmp20        [V47,T19] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V48 tmp21        [V48,T20] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V49 tmp22        [V49,T35] (  0,     0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;  V50 tmp23        [V50,T33] (  5,     0   )     int  ->  rdx         "Inlining Arg"
 ;* V51 tmp24        [V51    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V52 tmp25        [V52    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V53 tmp26        [V53    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V54 tmp27        [V54    ] (  0,     0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V55 rat0         [V55,T10] (  3,  8414.26)    long  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
-;  V56 rat1         [V56,T25] (  3,     5.99)    long  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
+;  V55 rat0         [V55,T10] (  3,  8399.05)    long  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V56 rat1         [V56,T25] (  3,     6   )    long  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 40
 
@@ -869,29 +873,27 @@ G_M33313_IG02:
        lea      rsi, [rsi+2*rax]
        add      rbx, rax
        cmp      eax, ebp
-       je       SHORT G_M33313_IG09
-						;; size=32 bbWeight=1 PerfScore 6.25
-G_M33313_IG03:
+       je       G_M33313_IG52
        sub      ebp, eax
        sub      edi, eax
        cmp      ebp, 2
-       jl       G_M33313_IG54
-						;; size=13 bbWeight=1.00 PerfScore 1.75
-G_M33313_IG04:
+       jl       G_M33313_IG46
+						;; size=49 bbWeight=1 PerfScore 8.00
+G_M33313_IG03:
        mov      eax, ebp
        lea      rcx, [rsi+2*rax-0x04]
        vmovups  xmm0, xmmword ptr [reloc @RWD00]
-						;; size=15 bbWeight=18.79 PerfScore 79.87
-G_M33313_IG05:
+						;; size=15 bbWeight=2.77 PerfScore 11.77
+G_M33313_IG04:
        mov      edx, dword ptr [rsi]
-						;; size=2 bbWeight=19.79 PerfScore 39.58
-G_M33313_IG06:
+						;; size=2 bbWeight=3.77 PerfScore 7.54
+G_M33313_IG05:
        test     edx, 0xD1FFAB1E
-       jne      G_M33313_IG24
-						;; size=12 bbWeight=2108.54 PerfScore 2635.67
-G_M33313_IG07:
+       jne      G_M33313_IG18
+						;; size=12 bbWeight=2061.25 PerfScore 2576.56
+G_M33313_IG06:
        cmp      edi, 2
-       jl       G_M33313_IG35
+       jl       G_M33313_IG33
        mov      eax, edx
        shr      eax, 8
        or       eax, edx
@@ -908,113 +910,80 @@ G_M33313_IG07:
        add      eax, 2
        movsxd   rdx, edi
        cmp      rax, rdx
-       jle      SHORT G_M33313_IG14
-						;; size=60 bbWeight=1402.38 PerfScore 10868.42
+       jle      SHORT G_M33313_IG08
+						;; size=60 bbWeight=1399.84 PerfScore 10848.78
+G_M33313_IG07:
+       jmp      SHORT G_M33313_IG09
+       align    [0 bytes for IG10]
+						;; size=2 bbWeight=679.83 PerfScore 1359.65
 G_M33313_IG08:
-       jmp      SHORT G_M33313_IG15
-       align    [0 bytes for IG12]
-						;; size=2 bbWeight=681.06 PerfScore 1362.11
-G_M33313_IG09:
-       mov      r14, bword ptr [rsp+0x80]
-       mov      qword ptr [r14], rsi
-       mov      r15, bword ptr [rsp+0x88]
-       mov      qword ptr [r15], rbx
-       xor      eax, eax
-						;; size=24 bbWeight=0.00 PerfScore 0.01
-G_M33313_IG10:
-       add      rsp, 40
-       pop      rbx
-       pop      rbp
-       pop      rsi
-       pop      rdi
-       pop      r14
-       pop      r15
-       ret      
-						;; size=13 bbWeight=0.00 PerfScore 0.01
-G_M33313_IG11:
-						;; size=0 bbWeight=0.00 PerfScore 0.00
-G_M33313_IG12:
-       lea      eax, [rdx-0xD800]
-       test     eax, 0xF800
-       je       G_M33313_IG51
-       test     edx, 0xD1FFAB1E
-       je       G_M33313_IG41
-       lea      eax, [rdx+D1FFAB1EH]
-       cmp      eax, 0xD1FFAB1E
-       jb       G_M33313_IG41
-						;; size=46 bbWeight=25728.18 PerfScore 122208.85
-G_M33313_IG13:
-       jmp      G_M33313_IG31
-						;; size=5 bbWeight=24679.10 PerfScore 49358.20
-G_M33313_IG14:
        mov      rdx, rax
-						;; size=3 bbWeight=721.32 PerfScore 180.33
-G_M33313_IG15:
+						;; size=3 bbWeight=720.02 PerfScore 180.00
+G_M33313_IG09:
        mov      eax, edx
        shr      eax, 3
        xor      r8d, r8d
        test     eax, eax
-       je       SHORT G_M33313_IG18
-       align    [0 bytes for IG16]
-						;; size=12 bbWeight=1402.38 PerfScore 3155.35
-G_M33313_IG16:
+       je       SHORT G_M33313_IG12
+						;; size=12 bbWeight=1399.84 PerfScore 3149.64
+G_M33313_IG10:
        vmovups  xmm1, xmmword ptr [rsi]
        vptest   xmm1, xmm0
-       jne      SHORT G_M33313_IG21
-						;; size=11 bbWeight=3850.34 PerfScore 30802.73
-G_M33313_IG17:
+       jne      SHORT G_M33313_IG15
+						;; size=11 bbWeight=3789.04 PerfScore 30312.36
+G_M33313_IG11:
        vpackuswb xmm1, xmm1, xmm1
        vmovq    qword ptr [rbx], xmm1
        add      rsi, 16
        add      rbx, 8
        inc      r8d
        cmp      r8d, eax
-       jb       SHORT G_M33313_IG16
-						;; size=24 bbWeight=3853.72 PerfScore 19268.60
-G_M33313_IG18:
+       jb       SHORT G_M33313_IG10
+						;; size=24 bbWeight=3792.44 PerfScore 18962.20
+G_M33313_IG12:
        shl      r8d, 3
        sub      edi, r8d
        test     dl, 4
-       je       G_M33313_IG47
-						;; size=16 bbWeight=3.38 PerfScore 6.76
-G_M33313_IG19:
+       je       G_M33313_IG43
+						;; size=16 bbWeight=3.40 PerfScore 6.79
+G_M33313_IG13:
        mov      rdx, qword ptr [rsi]
        mov      rax, 0xD1FFAB1E
        test     rdx, rax
-       jne      SHORT G_M33313_IG22
-						;; size=18 bbWeight=2.38 PerfScore 8.33
-G_M33313_IG20:
-       jmp      G_M33313_IG49
-       align    [0 bytes for IG33]
-						;; size=5 bbWeight=1.00 PerfScore 2.00
-G_M33313_IG21:
+       jne      SHORT G_M33313_IG16
+						;; size=18 bbWeight=2.40 PerfScore 8.39
+G_M33313_IG14:
+       jmp      G_M33313_IG45
+       align    [0 bytes for IG22]
+						;; size=5 bbWeight=1 PerfScore 2.00
+G_M33313_IG15:
        lea      edx, [8*r8]
        sub      edi, edx
        vmovd    rdx, xmm1
        mov      rax, 0xD1FFAB1E
        test     rdx, rax
-       je       SHORT G_M33313_IG28
-						;; size=30 bbWeight=1399.00 PerfScore 5945.74
-G_M33313_IG22:
+       je       G_M33313_IG30
+						;; size=34 bbWeight=1396.45 PerfScore 5934.90
+G_M33313_IG16:
        mov      r8d, edx
        test     r8d, 0xD1FFAB1E
-       je       SHORT G_M33313_IG27
-						;; size=12 bbWeight=1382.59 PerfScore 2073.88
-G_M33313_IG23:
+       je       SHORT G_M33313_IG21
+						;; size=12 bbWeight=1396.07 PerfScore 2094.11
+G_M33313_IG17:
        mov      edx, r8d
-						;; size=3 bbWeight=691.29 PerfScore 172.82
-G_M33313_IG24:
+						;; size=3 bbWeight=698.04 PerfScore 174.51
+G_M33313_IG18:
        test     edx, 0xFF80
-       je       SHORT G_M33313_IG29
-						;; size=8 bbWeight=2818.28 PerfScore 3522.85
-G_M33313_IG25:
+       je       G_M33313_IG29
+						;; size=12 bbWeight=2794.47 PerfScore 3493.09
+G_M33313_IG19:
        test     edx, 0xF800
-       jne      G_M33313_IG12
-						;; size=12 bbWeight=2094.74 PerfScore 2618.42
-G_M33313_IG26:
-       jmp      G_M33313_IG33
-						;; size=5 bbWeight=1064.85 PerfScore 2129.69
-G_M33313_IG27:
+       jne      SHORT G_M33313_IG22
+						;; size=8 bbWeight=2063.48 PerfScore 2579.35
+G_M33313_IG20:
+       jmp      G_M33313_IG31
+						;; size=5 bbWeight=1048.96 PerfScore 2097.91
+G_M33313_IG21:
        mov      eax, r8d
        shr      eax, 8
        or       eax, r8d
@@ -1025,34 +994,21 @@ G_M33313_IG27:
        shr      rdx, 32
        mov      r8d, edx
        mov      edx, r8d
-       jmp      SHORT G_M33313_IG24
-						;; size=35 bbWeight=389.45 PerfScore 2239.36
-G_M33313_IG28:
-       vpackuswb xmm2, xmm1, xmm1
-       vmovd    dword ptr [rbx], xmm2
-       add      rsi, 8
-       add      rbx, 4
-       add      edi, -4
-       vpextrq  rdx, xmm1, 1
-       jmp      SHORT G_M33313_IG22
-						;; size=27 bbWeight=321.70 PerfScore 2814.86
-G_M33313_IG29:
-       test     edi, edi
-       je       G_M33313_IG58
-						;; size=8 bbWeight=2094.74 PerfScore 2618.42
-G_M33313_IG30:
-       mov      byte  ptr [rbx], dl
-       add      rsi, 2
-       inc      rbx
-       dec      edi
-       cmp      rsi, rcx
-       ja       G_M33313_IG48
-       mov      edx, dword ptr [rsi]
-       jmp      SHORT G_M33313_IG25
-						;; size=24 bbWeight=1045.81 PerfScore 7320.69
-G_M33313_IG31:
+       jmp      SHORT G_M33313_IG18
+						;; size=35 bbWeight=394.22 PerfScore 2266.78
+G_M33313_IG22:
+       lea      eax, [rdx-0xD800]
+       test     eax, 0xF800
+       je       G_M33313_IG41
+       test     edx, 0xD1FFAB1E
+       je       G_M33313_IG25
+						;; size=29 bbWeight=25682.19 PerfScore 77046.58
+G_M33313_IG23:
+       lea      eax, [rdx+D1FFAB1EH]
+       cmp      eax, 0xD1FFAB1E
+       jb       G_M33313_IG25
        cmp      edi, 6
-       jl       G_M33313_IG41
+       jl       G_M33313_IG25
        lea      eax, [4*rdx]
        and      eax, 0x3F00
        mov      r8d, edx
@@ -1081,63 +1037,19 @@ G_M33313_IG31:
        add      rbx, 6
        add      edi, -6
        cmp      rsi, rcx
-       ja       G_M33313_IG48
+       ja       G_M33313_IG44
        mov      edx, dword ptr [rsi]
        test     edx, 0xF800
-       jne      G_M33313_IG12
-						;; size=135 bbWeight=24679.10 PerfScore 382526.05
-G_M33313_IG32:
-       jmp      G_M33313_IG06
-						;; size=5 bbWeight=12545.47 PerfScore 25090.93
-G_M33313_IG33:
-       lea      eax, [rdx+D1FFAB1EH]
-       cmp      eax, 0xD1FFAB1E
-       ja       G_M33313_IG45
-						;; size=17 bbWeight=1066.32 PerfScore 1866.05
-G_M33313_IG34:
-       cmp      edi, 4
-       jge      G_M33313_IG60
-						;; size=9 bbWeight=18.06 PerfScore 22.57
-G_M33313_IG35:
-       movzx    rcx, dx
-						;; size=3 bbWeight=0 PerfScore 0.00
-G_M33313_IG36:
-       cmp      ecx, 127
-       ja       G_M33313_IG55
-       test     edi, edi
-       je       G_M33313_IG58
-       mov      byte  ptr [rbx], cl
-       add      rsi, 2
-       inc      rbx
-						;; size=26 bbWeight=1.00 PerfScore 3.99
-G_M33313_IG37:
-       cmp      ebp, 1
-       jg       G_M33313_IG58
-						;; size=9 bbWeight=1.00 PerfScore 1.25
-G_M33313_IG38:
-       xor      eax, eax
-						;; size=2 bbWeight=1.00 PerfScore 0.25
-G_M33313_IG39:
-       mov      r14, bword ptr [rsp+0x80]
-       mov      qword ptr [r14], rsi
-       mov      r15, bword ptr [rsp+0x88]
-       mov      qword ptr [r15], rbx
-						;; size=22 bbWeight=1.00 PerfScore 3.99
-G_M33313_IG40:
-       add      rsp, 40
-       pop      rbx
-       pop      rbp
-       pop      rsi
-       pop      rdi
-       pop      r14
-       pop      r15
-       ret      
-						;; size=13 bbWeight=1.00 PerfScore 4.24
-G_M33313_IG41:
+       jne      G_M33313_IG22
+						;; size=152 bbWeight=24625.84 PerfScore 424795.69
+G_M33313_IG24:
+       jmp      G_M33313_IG05
+						;; size=5 bbWeight=12518.39 PerfScore 25036.78
+G_M33313_IG25:
        cmp      edi, 3
-       jl       G_M33313_IG58
-						;; size=9 bbWeight=1612.24 PerfScore 2015.31
-G_M33313_IG42:
+       jl       G_M33313_IG50
+						;; size=9 bbWeight=1609.36 PerfScore 2011.70
+G_M33313_IG26:
        lea      eax, [4*rdx]
        and      eax, 0x3F00
        movzx    r8, dx
@@ -1153,28 +1065,94 @@ G_M33313_IG42:
        add      rbx, 3
        add      edi, -3
        cmp      edx, 0xD1FFAB1E
-       jae      G_M33313_IG62
+       jae      G_M33313_IG56
        test     edi, edi
-       je       G_M33313_IG58
-						;; size=73 bbWeight=1049.08 PerfScore 8392.63
-G_M33313_IG43:
+       je       G_M33313_IG50
+						;; size=73 bbWeight=1056.36 PerfScore 8450.85
+G_M33313_IG27:
        shr      edx, 16
        mov      byte  ptr [rbx], dl
        add      rsi, 2
        inc      rbx
        dec      edi
        cmp      rsi, rcx
-       ja       SHORT G_M33313_IG48
+       ja       G_M33313_IG44
        mov      edx, dword ptr [rsi]
        test     edx, 0xF800
-       jne      G_M33313_IG12
-						;; size=33 bbWeight=1043.09 PerfScore 7040.84
-G_M33313_IG44:
-       jmp      G_M33313_IG06
-						;; size=5 bbWeight=530.25 PerfScore 1060.49
-G_M33313_IG45:
+       jne      G_M33313_IG22
+						;; size=37 bbWeight=1050.36 PerfScore 7089.90
+G_M33313_IG28:
+       jmp      G_M33313_IG05
+						;; size=5 bbWeight=533.94 PerfScore 1067.88
+G_M33313_IG29:
+       test     edi, edi
+       je       G_M33313_IG50
+       mov      byte  ptr [rbx], dl
+       add      rsi, 2
+       inc      rbx
+       dec      edi
+       cmp      rsi, rcx
+       ja       G_M33313_IG44
+       mov      edx, dword ptr [rsi]
+       jmp      G_M33313_IG19
+						;; size=35 bbWeight=1043.81 PerfScore 8611.41
+G_M33313_IG30:
+       vpackuswb xmm2, xmm1, xmm1
+       vmovd    dword ptr [rbx], xmm2
+       add      rsi, 8
+       add      rbx, 4
+       add      edi, -4
+       vpextrq  rdx, xmm1, 1
+       jmp      G_M33313_IG16
+       align    [0 bytes for IG31]
+						;; size=30 bbWeight=320.48 PerfScore 2804.19
+G_M33313_IG31:
+       lea      eax, [rdx+D1FFAB1EH]
+       cmp      eax, 0xD1FFAB1E
+       ja       SHORT G_M33313_IG39
+						;; size=13 bbWeight=17.88 PerfScore 31.29
+G_M33313_IG32:
+       cmp      edi, 4
+       jge      G_M33313_IG54
+						;; size=9 bbWeight=14.82 PerfScore 18.53
+G_M33313_IG33:
+       movzx    rcx, dx
+						;; size=3 bbWeight=0 PerfScore 0.00
+G_M33313_IG34:
+       cmp      ecx, 127
+       ja       G_M33313_IG47
+       test     edi, edi
+       je       G_M33313_IG50
+       mov      byte  ptr [rbx], cl
+       add      rsi, 2
+       inc      rbx
+						;; size=26 bbWeight=1 PerfScore 4.00
+G_M33313_IG35:
+       cmp      ebp, 1
+       jg       G_M33313_IG50
+						;; size=9 bbWeight=1 PerfScore 1.25
+G_M33313_IG36:
+       xor      eax, eax
+						;; size=2 bbWeight=1 PerfScore 0.25
+G_M33313_IG37:
+       mov      r14, bword ptr [rsp+0x80]
+       mov      qword ptr [r14], rsi
+       mov      r15, bword ptr [rsp+0x88]
+       mov      qword ptr [r15], rbx
+						;; size=22 bbWeight=1 PerfScore 4.00
+G_M33313_IG38:
+       add      rsp, 40
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       pop      r14
+       pop      r15
+       ret      
+						;; size=13 bbWeight=1 PerfScore 4.25
+G_M33313_IG39:
        cmp      edi, 2
-       jl       G_M33313_IG58
+       jl       G_M33313_IG50
        lea      eax, [4*rdx]
        and      eax, 0x1F00
        mov      r8d, edx
@@ -1183,53 +1161,23 @@ G_M33313_IG45:
        movzx    rax, ax
        movbe    word  ptr [rbx], ax
        cmp      edx, 0xD1FFAB1E
-       jb       SHORT G_M33313_IG50
-						;; size=52 bbWeight=18.06 PerfScore 108.35
-G_M33313_IG46:
+       jb       G_M33313_IG57
+						;; size=56 bbWeight=17.88 PerfScore 107.28
+G_M33313_IG40:
        add      rsi, 2
        add      rbx, 2
        add      edi, -2
        cmp      rsi, rcx
-       ja       SHORT G_M33313_IG48
+       ja       SHORT G_M33313_IG44
        mov      edx, dword ptr [rsi]
-       jmp      G_M33313_IG12
+       jmp      G_M33313_IG22
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M33313_IG47:
-       cmp      rsi, rcx
-       jbe      G_M33313_IG05
-						;; size=9 bbWeight=2.00 PerfScore 2.50
-G_M33313_IG48:
-       sub      rcx, rsi
-       mov      rbp, rcx
-       shr      rbp, 63
-       add      rbp, rcx
-       sar      rbp, 1
-       add      ebp, 2
-       jmp      G_M33313_IG54
-						;; size=24 bbWeight=1.00 PerfScore 3.99
-G_M33313_IG49:
-       vmovd    xmm1, rdx
-       vpackuswb xmm1, xmm1, xmm1
-       vmovd    dword ptr [rbx], xmm1
-       add      rsi, 8
-       jmp      SHORT G_M33313_IG52
-						;; size=19 bbWeight=1.00 PerfScore 7.24
-G_M33313_IG50:
-       cmp      edi, 3
-       jl       G_M33313_IG53
-       shr      edx, 16
-       mov      byte  ptr [rbx+0x02], dl
-       add      rsi, 4
-       add      rbx, 3
-       add      edi, -3
-       jmp      SHORT G_M33313_IG47
-						;; size=28 bbWeight=0 PerfScore 0.00
-G_M33313_IG51:
+G_M33313_IG41:
        lea      eax, [rdx+D1FFAB1EH]
        test     eax, 0xD1FFAB1E
-       jne      G_M33313_IG59
+       jne      G_M33313_IG51
        cmp      edi, 4
-       jl       G_M33313_IG58
+       jl       G_M33313_IG50
        add      edx, 64
        mov      eax, edx
        and      eax, 3
@@ -1250,27 +1198,41 @@ G_M33313_IG51:
        mov      dword ptr [rbx], eax
        add      rsi, 4
 						;; size=96 bbWeight=0 PerfScore 0.00
-G_M33313_IG52:
+G_M33313_IG42:
        add      rbx, 4
        add      edi, -4
-       jmp      G_M33313_IG47
-						;; size=12 bbWeight=0 PerfScore 0.00
-G_M33313_IG53:
-       add      rsi, 2
-       add      rbx, 2
-       jmp      G_M33313_IG58
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M33313_IG54:
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M33313_IG43:
+       cmp      rsi, rcx
+       jbe      G_M33313_IG04
+						;; size=9 bbWeight=2 PerfScore 2.50
+G_M33313_IG44:
+       sub      rcx, rsi
+       mov      rbp, rcx
+       shr      rbp, 63
+       add      rbp, rcx
+       sar      rbp, 1
+       add      ebp, 2
+       jmp      SHORT G_M33313_IG46
+						;; size=21 bbWeight=1 PerfScore 4.00
+G_M33313_IG45:
+       vmovd    xmm1, rdx
+       vpackuswb xmm1, xmm1, xmm1
+       vmovd    dword ptr [rbx], xmm1
+       add      rsi, 8
+       jmp      SHORT G_M33313_IG42
+						;; size=19 bbWeight=1 PerfScore 7.25
+G_M33313_IG46:
        test     ebp, ebp
-       je       G_M33313_IG38
+       je       G_M33313_IG36
        movzx    rcx, word  ptr [rsi]
-       jmp      G_M33313_IG36
-						;; size=16 bbWeight=1.00 PerfScore 5.24
-G_M33313_IG55:
+       jmp      G_M33313_IG34
+						;; size=16 bbWeight=1 PerfScore 5.25
+G_M33313_IG47:
        cmp      ecx, 0x800
-       jae      SHORT G_M33313_IG56
+       jae      SHORT G_M33313_IG48
        cmp      edi, 2
-       jl       SHORT G_M33313_IG58
+       jl       SHORT G_M33313_IG50
        mov      eax, ecx
        and      eax, 63
        or       eax, -128
@@ -1280,14 +1242,14 @@ G_M33313_IG55:
        mov      byte  ptr [rbx], cl
        add      rsi, 2
        add      rbx, 2
-       jmp      G_M33313_IG37
+       jmp      G_M33313_IG35
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M33313_IG56:
+G_M33313_IG48:
        lea      eax, [rcx-0xD800]
        cmp      eax, 0x7FF
-       jbe      SHORT G_M33313_IG57
+       jbe      SHORT G_M33313_IG49
        cmp      edi, 3
-       jl       SHORT G_M33313_IG58
+       jl       SHORT G_M33313_IG50
        mov      eax, ecx
        and      eax, 63
        or       eax, -128
@@ -1302,23 +1264,40 @@ G_M33313_IG56:
        mov      byte  ptr [rbx], cl
        add      rsi, 2
        add      rbx, 3
-       jmp      G_M33313_IG37
+       jmp      G_M33313_IG35
 						;; size=64 bbWeight=0 PerfScore 0.00
-G_M33313_IG57:
+G_M33313_IG49:
        cmp      ecx, 0xDBFF
-       ja       SHORT G_M33313_IG59
+       ja       SHORT G_M33313_IG51
        mov      eax, 2
-       jmp      G_M33313_IG39
+       jmp      G_M33313_IG37
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M33313_IG58:
+G_M33313_IG50:
        mov      eax, 1
-       jmp      G_M33313_IG39
+       jmp      G_M33313_IG37
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M33313_IG59:
+G_M33313_IG51:
        mov      eax, 3
-       jmp      G_M33313_IG39
+       jmp      G_M33313_IG37
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M33313_IG60:
+G_M33313_IG52:
+       mov      r14, bword ptr [rsp+0x80]
+       mov      qword ptr [r14], rsi
+       mov      r15, bword ptr [rsp+0x88]
+       mov      qword ptr [r15], rbx
+       xor      eax, eax
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M33313_IG53:
+       add      rsp, 40
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       pop      r14
+       pop      r15
+       ret      
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M33313_IG54:
        mov      eax, edx
        shr      eax, 6
        and      eax, 0xD1FFAB1E
@@ -1331,25 +1310,40 @@ G_M33313_IG60:
        add      rbx, 4
        add      edi, -4
        cmp      rsi, rcx
-       ja       G_M33313_IG48
+       ja       G_M33313_IG44
        mov      edx, dword ptr [rsi]
        lea      eax, [rdx-0x80]
        movzx    rax, ax
        cmp      eax, 0x780
-       jb       G_M33313_IG33
+       jb       G_M33313_IG31
 						;; size=67 bbWeight=0 PerfScore 0.00
-G_M33313_IG61:
-       jmp      G_M33313_IG06
+G_M33313_IG55:
+       jmp      G_M33313_IG05
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M33313_IG62:
+G_M33313_IG56:
        cmp      rsi, rcx
-       ja       G_M33313_IG48
+       ja       G_M33313_IG44
        mov      edx, dword ptr [rsi]
-       jmp      G_M33313_IG24
+       jmp      G_M33313_IG18
 						;; size=16 bbWeight=0 PerfScore 0.00
+G_M33313_IG57:
+       cmp      edi, 3
+       jl       SHORT G_M33313_IG58
+       shr      edx, 16
+       mov      byte  ptr [rbx+0x02], dl
+       add      rsi, 4
+       add      rbx, 3
+       add      edi, -3
+       jmp      G_M33313_IG43
+						;; size=27 bbWeight=0 PerfScore 0.00
+G_M33313_IG58:
+       add      rsi, 2
+       add      rbx, 2
+       jmp      G_M33313_IG50
+						;; size=13 bbWeight=0 PerfScore 0.00
 RWD00  	dq	FF80FF80FF80FF80h, FF80FF80FF80FF80h
 
 
-; Total bytes of code 1388, prolog size 23, PerfScore 699604.70, instruction count 377, allocated bytes for code 1388 (MethodHash=85587dde) for method System.Text.Unicode.Utf8Utility:TranscodeToUtf8(ulong,int,ulong,int,byref,byref):int (Tier1)
+; Total bytes of code 1392, prolog size 23, PerfScore 643186.42, instruction count 375, allocated bytes for code 1392 (MethodHash=85587dde) for method System.Text.Unicode.Utf8Utility:TranscodeToUtf8(ulong,int,ulong,int,byref,byref):int (Tier1)
 ; ============================================================
 


```

</details>

