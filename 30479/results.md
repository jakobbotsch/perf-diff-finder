# ``System.Collections.Sort<BigStruct>.Array(Size: 512)``

Hot functions:

- (64.52%) ``System.Collections.Generic.GenericArraySortHelper`1.PickPivotAndPartition`` (Tier-1)
  - **Has diffs**
- (30.17%) ``System.Collections.Generic.GenericArraySortHelper`1.IntroSort`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct].PickPivotAndPartition(value class System.Span`1<!0>)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 133744.5
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 106216.6
 ; 8 inlinees with PGO data; 12 single block inlinees; 5 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T12] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 loc0         [V01,T09] ( 14, 58.94)   byref  ->  rdx         single-def
+;  V01 loc0         [V01,T07] ( 14, 47.91)   byref  ->  rdx         single-def
 ;  V02 loc1         [V02,T15] (  7,  4.84)   byref  ->   r8         single-def
-;  V03 loc2         [V03,T13] ( 10,  7.84)   byref  ->  r10         single-def
-;  V04 loc3         [V04,T10] (  9, 41.33)   byref  ->  rcx         single-def
+;  V03 loc2         [V03,T13] ( 10,  7.83)   byref  ->  rcx         single-def
+;  V04 loc3         [V04,T08] (  9, 40.80)   byref  ->   r9         single-def
 ;* V05 loc4         [V05    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op <System.Collections.BigStruct>
-;  V06 loc5         [V06,T01] ( 12,183.18)   byref  ->  rax        
-;  V07 loc6         [V07,T00] (  8,206.12)   byref  ->   r8        
+;  V06 loc5         [V06,T01] ( 12,181.51)   byref  ->  rax        
+;  V07 loc6         [V07,T00] (  8,194.52)   byref  ->  rbx        
 ;# V08 OutArgs      [V08    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T04] (  2,148.98)   byref  ->   r8         "dup spill"
-;  V10 tmp2         [V10,T05] (  2,132.75)   byref  ->  rax         "dup spill"
+;  V09 tmp1         [V09,T04] (  2,148.30)   byref  ->  rbx         "dup spill"
+;  V10 tmp2         [V10,T05] (  2,131.32)   byref  ->  rax         "dup spill"
 ;* V11 tmp3         [V11    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.BigStruct]>
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
 ;* V13 tmp5         [V13    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V15 tmp7         [V15,T25] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V16 tmp8         [V16,T16] (  3,  4.81)   byref  ->  r11         single-def "Inlining Arg"
+;* V15 tmp7         [V15,T28] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V16 tmp8         [V16,T16] (  3,  4.79)   byref  ->  r11         single-def "Inlining Arg"
 ;* V17 tmp9         [V17    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V18 tmp10        [V18,T31] (  2,  0.92)  struct (32) [rsp+0xA8]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V18 tmp10        [V18,T31] (  2,  0.92)  struct (32) [rsp+0xA0]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
 ;* V19 tmp11        [V19    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
 ;* V20 tmp12        [V20    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V21 tmp13        [V21    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V22 tmp14        [V22,T28] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V23 tmp15        [V23,T17] (  3,  4.81)   byref  ->   r9         single-def "Inlining Arg"
+;* V22 tmp14        [V22,T29] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V23 tmp15        [V23,T17] (  3,  4.79)   byref  ->   r9         single-def "Inlining Arg"
 ;* V24 tmp16        [V24    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V25 tmp17        [V25,T32] (  2,  0.92)  struct (32) [rsp+0x88]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V25 tmp17        [V25,T32] (  2,  0.92)  struct (32) [rsp+0x80]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
 ;* V26 tmp18        [V26    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
 ;* V27 tmp19        [V27    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V28 tmp20        [V28    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V29 tmp21        [V29,T26] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V30 tmp22        [V30,T18] (  3,  4.81)   byref  ->   r9         single-def "Inlining Arg"
+;* V29 tmp21        [V29,T30] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V30 tmp22        [V30,T18] (  3,  4.79)   byref  ->   r9         single-def "Inlining Arg"
 ;* V31 tmp23        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V32 tmp24        [V32,T33] (  2,  0.92)  struct (32) [rsp+0x68]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
-;  V33 tmp25        [V33,T29] (  2,  2   )  struct (32) [rsp+0x48]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V32 tmp24        [V32,T33] (  2,  0.92)  struct (32) [rsp+0x60]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V33 tmp25        [V33,T26] (  2,  2.00)  struct (32) [rsp+0x40]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
 ;* V34 tmp26        [V34    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V35 tmp27        [V35    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V36 tmp28        [V36,T08] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V37 tmp29        [V37,T03] (  3,159.58)     int  ->  r10         "Inlining Arg"
+;* V36 tmp28        [V36,T10] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V37 tmp29        [V37,T03] (  3,157.12)     int  ->  rcx         "Inlining Arg"
 ;* V38 tmp30        [V38    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V39 tmp31        [V39    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V40 tmp32        [V40,T07] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V41 tmp33        [V41,T02] (  3,179.10)     int  ->  r10         "Inlining Arg"
-;  V42 tmp34        [V42,T11] (  2, 30.19)  struct (32) [rsp+0x28]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
-;  V43 tmp35        [V43,T30] (  2,  1.97)  struct (32) [rsp+0x08]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
-;  V44 tmp36        [V44,T27] (  2,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V45 tmp37        [V45,T21] (  3,  3   )     int  ->  rcx         "field V00._length (fldOffset=0x8)" P-INDEP
+;* V40 tmp32        [V40,T09] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V41 tmp33        [V41,T02] (  2,148.30)     int  ->  rcx         "Inlining Arg"
+;  V42 tmp34        [V42,T11] (  2, 30.14)  struct (32) [rsp+0x20]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V43 tmp35        [V43,T27] (  2,  1.94)  struct (32) [rsp+0x00]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V44 tmp36        [V44,T25] (  2,  2   )   byref  ->  rdx         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V45 tmp37        [V45,T21] (  3,  3.00)     int  ->  rax         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V46 tmp38        [V46    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V11._reference (fldOffset=0x0)" P-INDEP
 ;* V47 tmp39        [V47    ] (  0,  0   )     int  ->  zero-ref    "field V11._length (fldOffset=0x8)" P-INDEP
-;  V48 tmp40        [V48,T06] (  5, 99.91)     int  ->   r9         "V05.[012..016)"
-;  V49 tmp41        [V49,T22] (  3,  2.40)     int  ->  rax         "V14.[012..016)"
-;  V50 tmp42        [V50,T23] (  3,  2.40)     int  ->  rax         "V21.[012..016)"
-;  V51 tmp43        [V51,T24] (  3,  2.40)     int  ->  rax         "V28.[012..016)"
+;  V48 tmp40        [V48,T06] (  4, 83.81)     int  ->  r11         "V05.[012..016)"
+;  V49 tmp41        [V49,T22] (  3,  2.39)     int  ->  r10         "V14.[012..016)"
+;  V50 tmp42        [V50,T23] (  3,  2.39)     int  ->  rbx         "V21.[012..016)"
+;  V51 tmp43        [V51,T24] (  3,  2.39)     int  ->  r10         "V28.[012..016)"
 ;* V52 tmp44        [V52    ] (  0,  0   )     int  ->  zero-ref    "V35.[012..016)"
 ;* V53 tmp45        [V53    ] (  0,  0   )     int  ->  zero-ref    "V39.[012..016)"
 ;* V54 tmp46        [V54    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[System.Collections.BigStruct]>
-;  V55 cse0         [V55,T20] (  3,  3   )     int  ->  rax         "CSE #01: moderate"
+;  V55 cse0         [V55,T20] (  3,  3   )     int  ->  rcx         "CSE #01: moderate"
 ;  V56 cse1         [V56,T19] (  3,  3   )   byref  ->   r9         "CSE #03: moderate"
-;  V57 rat0         [V57,T14] (  3,  6.00)    long  ->  rax         "ReplaceWithLclVar is creating a new local variable"
+;  V57 rat0         [V57,T14] (  3,  5.99)    long  ->  rax         "ReplaceWithLclVar is creating a new local variable"
 ;
-; Lcl frame size = 200
+; Lcl frame size = 192
 
 G_M35080_IG01:
-       sub      rsp, 200
-						;; size=7 bbWeight=1 PerfScore 0.25
+       push     rbx
+       sub      rsp, 192
+						;; size=8 bbWeight=1 PerfScore 1.25
 G_M35080_IG02:
        mov      rdx, bword ptr [rcx]
-       mov      ecx, dword ptr [rcx+0x08]
-       lea      eax, [rcx-0x01]
-       movsxd   r8, eax
+       mov      eax, dword ptr [rcx+0x08]
+       lea      ecx, [rax-0x01]
+       movsxd   r8, ecx
        shl      r8, 5
        add      r8, rdx
-       sar      eax, 1
-       movsxd   r10, eax
-       shl      r10, 5
-       add      r10, rdx
-       cmp      byte  ptr [rdx], dl
-       mov      eax, dword ptr [r10+0x0C]
-       lea      r9, bword ptr [rdx+0x0C]
-       mov      r11, r9
-       cmp      dword ptr [r11], eax
-       jl       SHORT G_M35080_IG04
-						;; size=49 bbWeight=1 PerfScore 16.75
-G_M35080_IG03:
-       cmp      dword ptr [r11], eax
-       jg       SHORT G_M35080_IG07
-						;; size=5 bbWeight=0.40 PerfScore 1.62
-G_M35080_IG04:
-       mov      eax, dword ptr [r8+0x0C]
-       cmp      dword ptr [r9], eax
-       jl       SHORT G_M35080_IG10
-						;; size=9 bbWeight=1 PerfScore 6.00
-G_M35080_IG05:
-       cmp      dword ptr [r9], eax
-       jle      SHORT G_M35080_IG10
-						;; size=5 bbWeight=0.40 PerfScore 1.62
-G_M35080_IG06:
-       jmp      G_M35080_IG20
-       align    [0 bytes for IG08]
-						;; size=5 bbWeight=0.40 PerfScore 0.81
-G_M35080_IG07:
-       vmovdqu  ymm0, ymmword ptr [rdx]
-       vmovdqu  ymmword ptr [rsp+0xA8], ymm0
-       vmovdqu  ymm0, ymmword ptr [r10]
-       vmovdqu  ymmword ptr [rdx], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0xA8]
-       vmovdqu  ymmword ptr [r10], ymm0
-       jmp      SHORT G_M35080_IG04
-						;; size=38 bbWeight=0.46 PerfScore 9.64
-G_M35080_IG08:
-       cmp      r8, rdx
-       jbe      G_M35080_IG22
-						;; size=9 bbWeight=48.10 PerfScore 60.12
-G_M35080_IG09:
-       jmp      SHORT G_M35080_IG17
-						;; size=2 bbWeight=37.24 PerfScore 74.49
-G_M35080_IG10:
-       mov      eax, dword ptr [r8+0x0C]
-       lea      r9, bword ptr [r10+0x0C]
-       cmp      dword ptr [r9], eax
-       jl       SHORT G_M35080_IG12
-						;; size=13 bbWeight=1 PerfScore 6.50
-G_M35080_IG11:
-       cmp      dword ptr [r9], eax
-       jg       G_M35080_IG21
-						;; size=9 bbWeight=0.40 PerfScore 1.62
-G_M35080_IG12:
-       add      ecx, -2
+       sar      ecx, 1
        movsxd   rcx, ecx
        shl      rcx, 5
        add      rcx, rdx
-       mov      r9d, dword ptr [r10+0x0C]
-       vmovdqu  ymm0, ymmword ptr [r10]
-       vmovdqu  ymmword ptr [rsp+0x48], ymm0
-       vmovdqu  ymm0, ymmword ptr [rcx]
-       vmovdqu  ymmword ptr [r10], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x48]
-       vmovdqu  ymmword ptr [rcx], ymm0
-       mov      rax, rdx
-       mov      r8, rcx
-       cmp      rdx, rcx
-       jae      G_M35080_IG24
-						;; size=62 bbWeight=1 PerfScore 24.00
-G_M35080_IG13:
-       cmp      rax, rcx
-       jae      SHORT G_M35080_IG08
-						;; size=5 bbWeight=33.36 PerfScore 41.70
-G_M35080_IG14:
-       add      rax, 32
-       mov      r10d, dword ptr [rax+0x0C]
-       cmp      r9d, r10d
-       jl       SHORT G_M35080_IG08
-						;; size=13 bbWeight=33.19 PerfScore 116.15
-G_M35080_IG15:
-       cmp      r9d, r10d
-       jle      SHORT G_M35080_IG08
-						;; size=5 bbWeight=13.42 PerfScore 16.77
-G_M35080_IG16:
-       jmp      SHORT G_M35080_IG13
-						;; size=2 bbWeight=13.41 PerfScore 26.82
-G_M35080_IG17:
-       add      r8, -32
+       cmp      byte  ptr [rdx], dl
+       mov      r10d, dword ptr [rcx+0x0C]
+       lea      r9, bword ptr [rdx+0x0C]
+       mov      r11, r9
+       cmp      dword ptr [r11], r10d
+       jge      SHORT G_M35080_IG10
+						;; size=49 bbWeight=1 PerfScore 16.75
+G_M35080_IG03:
+       mov      ebx, dword ptr [r8+0x0C]
+       cmp      dword ptr [r9], ebx
+       jge      G_M35080_IG16
+						;; size=13 bbWeight=1 PerfScore 6.00
+G_M35080_IG04:
        mov      r10d, dword ptr [r8+0x0C]
-       cmp      r9d, r10d
-       jl       G_M35080_IG08
-						;; size=17 bbWeight=37.24 PerfScore 130.36
-G_M35080_IG18:
-       cmp      r9d, r10d
-       jle      SHORT G_M35080_IG22
-						;; size=5 bbWeight=15.06 PerfScore 18.82
-G_M35080_IG19:
-       jmp      SHORT G_M35080_IG22
-						;; size=2 bbWeight=15.05 PerfScore 30.10
-G_M35080_IG20:
+       lea      r9, bword ptr [rcx+0x0C]
+       cmp      dword ptr [r9], r10d
+       jge      G_M35080_IG19
+						;; size=17 bbWeight=1 PerfScore 6.50
+G_M35080_IG05:
+       add      eax, -2
+       movsxd   r9, eax
+       shl      r9, 5
+       add      r9, rdx
+       mov      r11d, dword ptr [rcx+0x0C]
+       vmovdqu  ymm0, ymmword ptr [rcx]
+       vmovdqu  ymmword ptr [rsp+0x40], ymm0
+       vmovdqu  ymm0, ymmword ptr [r9]
+       vmovdqu  ymmword ptr [rcx], ymm0
+       vmovdqu  ymm0, ymmword ptr [rsp+0x40]
+       vmovdqu  ymmword ptr [r9], ymm0
+       mov      rax, rdx
+       mov      rbx, r9
+       cmp      rdx, r9
+       jae      G_M35080_IG21
+						;; size=62 bbWeight=1.00 PerfScore 23.98
+G_M35080_IG06:
+       cmp      rax, r9
+       jae      SHORT G_M35080_IG12
+						;; size=5 bbWeight=32.87 PerfScore 41.08
+G_M35080_IG07:
+       add      rax, 32
+       mov      ecx, dword ptr [rax+0x0C]
+       cmp      r11d, ecx
+       jl       SHORT G_M35080_IG12
+						;; size=12 bbWeight=32.83 PerfScore 114.90
+G_M35080_IG08:
+       cmp      r11d, ecx
+       jle      SHORT G_M35080_IG12
+						;; size=5 bbWeight=12.90 PerfScore 16.13
+G_M35080_IG09:
+       jmp      SHORT G_M35080_IG06
+						;; size=2 bbWeight=12.90 PerfScore 25.79
+G_M35080_IG10:
+       cmp      dword ptr [r11], r10d
+       jle      SHORT G_M35080_IG03
+						;; size=5 bbWeight=0.39 PerfScore 1.57
+G_M35080_IG11:
        vmovdqu  ymm0, ymmword ptr [rdx]
-       vmovdqu  ymmword ptr [rsp+0x88], ymm0
+       vmovdqu  ymmword ptr [rsp+0xA0], ymm0
+       vmovdqu  ymm0, ymmword ptr [rcx]
+       vmovdqu  ymmword ptr [rdx], ymm0
+       vmovdqu  ymm0, ymmword ptr [rsp+0xA0]
+       vmovdqu  ymmword ptr [rcx], ymm0
+       jmp      G_M35080_IG03
+       align    [7 bytes for IG12]
+						;; size=46 bbWeight=0.46 PerfScore 9.65
+G_M35080_IG12:
+       cmp      rbx, rdx
+       jbe      SHORT G_M35080_IG14
+						;; size=5 bbWeight=37.08 PerfScore 46.34
+G_M35080_IG13:
+       add      rbx, -32
+       mov      ecx, dword ptr [rbx+0x0C]
+       cmp      r11d, ecx
+       jl       SHORT G_M35080_IG12
+						;; size=12 bbWeight=37.08 PerfScore 129.76
+G_M35080_IG14:
+       cmp      rax, rbx
+       jae      G_M35080_IG21
+						;; size=9 bbWeight=15.08 PerfScore 18.84
+G_M35080_IG15:
+       jmp      SHORT G_M35080_IG18
+						;; size=2 bbWeight=15.07 PerfScore 30.14
+G_M35080_IG16:
+       cmp      dword ptr [r9], ebx
+       jle      G_M35080_IG04
+						;; size=9 bbWeight=0.39 PerfScore 1.57
+G_M35080_IG17:
+       vmovdqu  ymm0, ymmword ptr [rdx]
+       vmovdqu  ymmword ptr [rsp+0x80], ymm0
        vmovdqu  ymm0, ymmword ptr [r8]
        vmovdqu  ymmword ptr [rdx], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x88]
+       vmovdqu  ymm0, ymmword ptr [rsp+0x80]
        vmovdqu  ymmword ptr [r8], ymm0
-       jmp      G_M35080_IG10
-						;; size=41 bbWeight=0.46 PerfScore 9.64
-G_M35080_IG21:
-       vmovdqu  ymm0, ymmword ptr [r10]
-       vmovdqu  ymmword ptr [rsp+0x68], ymm0
-       vmovdqu  ymm0, ymmword ptr [r8]
-       vmovdqu  ymmword ptr [r10], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x68]
-       vmovdqu  ymmword ptr [r8], ymm0
-       jmp      G_M35080_IG12
-						;; size=37 bbWeight=0.46 PerfScore 9.64
-G_M35080_IG22:
-       cmp      rax, r8
-       jae      SHORT G_M35080_IG24
-						;; size=5 bbWeight=15.10 PerfScore 18.88
-G_M35080_IG23:
+       jmp      G_M35080_IG04
+						;; size=41 bbWeight=0.46 PerfScore 9.65
+G_M35080_IG18:
        vmovdqu  ymm0, ymmword ptr [rax]
-       vmovdqu  ymmword ptr [rsp+0x28], ymm0
-       vmovdqu  ymm0, ymmword ptr [r8]
+       vmovdqu  ymmword ptr [rsp+0x20], ymm0
+       vmovdqu  ymm0, ymmword ptr [rbx]
        vmovdqu  ymmword ptr [rax], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x28]
-       vmovdqu  ymmword ptr [r8], ymm0
-       jmp      G_M35080_IG13
-						;; size=35 bbWeight=15.10 PerfScore 317.00
-G_M35080_IG24:
-       cmp      rax, rcx
-       je       SHORT G_M35080_IG26
-						;; size=5 bbWeight=1.00 PerfScore 1.25
-G_M35080_IG25:
-       vmovdqu  ymm0, ymmword ptr [rax]
-       vmovdqu  ymmword ptr [rsp+0x08], ymm0
+       vmovdqu  ymm0, ymmword ptr [rsp+0x20]
+       vmovdqu  ymmword ptr [rbx], ymm0
+       jmp      G_M35080_IG06
+						;; size=33 bbWeight=15.07 PerfScore 316.46
+G_M35080_IG19:
+       cmp      dword ptr [r9], r10d
+       jle      G_M35080_IG05
+						;; size=9 bbWeight=0.39 PerfScore 1.57
+G_M35080_IG20:
        vmovdqu  ymm0, ymmword ptr [rcx]
-       vmovdqu  ymmword ptr [rax], ymm0
-       vmovdqu  ymm0, ymmword ptr [rsp+0x08]
+       vmovdqu  ymmword ptr [rsp+0x60], ymm0
+       vmovdqu  ymm0, ymmword ptr [r8]
        vmovdqu  ymmword ptr [rcx], ymm0
-						;; size=28 bbWeight=0.98 PerfScore 18.69
-G_M35080_IG26:
+       vmovdqu  ymm0, ymmword ptr [rsp+0x60]
+       vmovdqu  ymmword ptr [r8], ymm0
+       jmp      G_M35080_IG05
+						;; size=35 bbWeight=0.46 PerfScore 9.65
+G_M35080_IG21:
+       cmp      rax, r9
+       je       SHORT G_M35080_IG23
+						;; size=5 bbWeight=1.00 PerfScore 1.25
+G_M35080_IG22:
+       vmovdqu  ymm0, ymmword ptr [rax]
+       vmovdqu  ymmword ptr [rsp], ymm0
+       vmovdqu  ymm0, ymmword ptr [r9]
+       vmovdqu  ymmword ptr [rax], ymm0
+       vmovdqu  ymm0, ymmword ptr [rsp]
+       vmovdqu  ymmword ptr [r9], ymm0
+						;; size=28 bbWeight=0.97 PerfScore 18.46
+G_M35080_IG23:
        sub      rax, rdx
-       mov      r8, rax
-       sar      r8, 63
-       and      r8, 31
-       add      rax, r8
+       mov      r11, rax
+       sar      r11, 63
+       and      r11, 31
+       add      rax, r11
        sar      rax, 5
 						;; size=21 bbWeight=1.00 PerfScore 2.00
-G_M35080_IG27:
+G_M35080_IG24:
        vzeroupper 
-       add      rsp, 200
+       add      rsp, 192
+       pop      rbx
        ret      
-						;; size=11 bbWeight=1.00 PerfScore 2.25
+						;; size=12 bbWeight=1.00 PerfScore 2.75
 
-; Total bytes of code 445, prolog size 7, PerfScore 963.51, instruction count 113, allocated bytes for code 445 (MethodHash=1e7376f7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:PickPivotAndPartition(System.Span`1[System.Collections.BigStruct]):int (Tier1)
+; Total bytes of code 445, prolog size 8, PerfScore 852.05, instruction count 111, allocated bytes for code 445 (MethodHash=1e7376f7) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:PickPivotAndPartition(System.Span`1[System.Collections.BigStruct]):int (Tier1)
+; ============================================================
+
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
 ; ============================================================
 


```

### ``[System.Private.CoreLib]System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct].IntroSort(value class System.Span`1<!0>,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 131082
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 102996
 ; 14 inlinees with PGO data; 18 single block inlinees; 5 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 arg0         [V00,T13] (  4,  8   )   byref  ->  rcx         ld-addr-op single-def
-;  V01 arg1         [V01,T14] (  6,  6.88)     int  ->  rbx        
-;  V02 loc0         [V02,T12] ( 13, 13.48)     int  ->  rbp        
-;  V03 loc1         [V03,T21] (  3,  3.91)     int  ->  r14        
+;  V01 arg1         [V01,T15] (  6,  6.87)     int  ->  rbx        
+;  V02 loc0         [V02,T11] ( 13, 13.45)     int  ->  rbp        
+;  V03 loc1         [V03,T21] (  3,  3.90)     int  ->  r14        
 ;  V04 loc2         [V04,T29] (  7,  0.42)   byref  ->  rax         single-def
 ;  V05 loc3         [V05,T30] (  7,  0.42)   byref  ->   r8         single-def
 ;* V06 loc4         [V06    ] (  0,  0   )   byref  ->  zero-ref    single-def
-;  V07 loc5         [V07,T23] (  3,  2.91)     int  ->  rcx        
+;  V07 loc5         [V07,T23] (  3,  2.90)     int  ->  rcx        
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V09 tmp1         [V09    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.BigStruct]>
 ;* V10 tmp2         [V10    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.BigStruct]>
@@ -690,7 +690,7 @@ G_M52646_IG21:
 ;* V12 tmp4         [V12    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[System.Collections.BigStruct]>
 ;* V13 tmp5         [V13    ] (  0,  0   )   byref  ->  zero-ref    single-def "Inlining Arg"
 ;* V14 tmp6         [V14    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
-;  V15 tmp7         [V15,T43] (  4,  0.13)   byref  ->  rcx         single-def "Inlining Arg"
+;  V15 tmp7         [V15,T40] (  4,  0.13)   byref  ->  rcx         single-def "Inlining Arg"
 ;* V16 tmp8         [V16    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V17 tmp9         [V17    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
 ;* V18 tmp10        [V18,T49] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
@@ -700,31 +700,31 @@ G_M52646_IG21:
 ;* V22 tmp14        [V22    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
 ;* V23 tmp15        [V23    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V24 tmp16        [V24    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V25 tmp17        [V25,T40] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V26 tmp18        [V26,T31] (  2,  0.35)   byref  ->  rdx         single-def "Inlining Arg"
+;* V25 tmp17        [V25,T41] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V26 tmp18        [V26,T31] (  2,  0.34)   byref  ->  rdx         single-def "Inlining Arg"
 ;* V27 tmp19        [V27    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V28 tmp20        [V28,T45] (  2,  0.08)  struct (32) [rsp+0x70]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
 ;* V29 tmp21        [V29    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
 ;* V30 tmp22        [V30    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V31 tmp23        [V31    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
 ;* V32 tmp24        [V32,T42] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V33 tmp25        [V33,T32] (  2,  0.35)   byref  ->  rdx         single-def "Inlining Arg"
+;  V33 tmp25        [V33,T32] (  2,  0.34)   byref  ->  rcx         single-def "Inlining Arg"
 ;* V34 tmp26        [V34    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V35 tmp27        [V35,T46] (  2,  0.08)  struct (32) [rsp+0x50]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
 ;* V36 tmp28        [V36    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[S] "spilling side-effects" <System.Collections.BigStruct>
 ;* V37 tmp29        [V37    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V38 tmp30        [V38    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V39 tmp31        [V39,T41] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V40 tmp32        [V40,T33] (  2,  0.35)   byref  ->  rdx         single-def "Inlining Arg"
+;* V39 tmp31        [V39,T43] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V40 tmp32        [V40,T33] (  2,  0.34)   byref  ->  r10         single-def "Inlining Arg"
 ;* V41 tmp33        [V41    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;  V42 tmp34        [V42,T47] (  2,  0.08)  struct (32) [rsp+0x30]  do-not-enreg[S] "Inline stloc first use temp" <System.Collections.BigStruct>
 ;* V43 tmp35        [V43    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.BigStruct]>
 ;* V44 tmp36        [V44    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V45 tmp37        [V45,T09] (  5, 82.18)     int  ->   r8         "Inline stloc first use temp"
+;  V45 tmp37        [V45,T08] (  5, 43.54)     int  ->  rax         "Inline stloc first use temp"
 ;* V46 tmp38        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.BigStruct]>
-;* V47 tmp39        [V47,T15] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "Inline stloc first use temp" <System.Collections.BigStruct>
-;  V48 tmp40        [V48,T00] (  7,181.97)     int  ->   r8         "Inline stloc first use temp"
-;  V49 tmp41        [V49,T03] (  2,100.34)   byref  ->   r9         "impAppendStmt"
+;* V47 tmp39        [V47,T14] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] ld-addr-op "Inline stloc first use temp" <System.Collections.BigStruct>
+;  V48 tmp40        [V48,T00] (  7,159.65)     int  ->  rax         "Inline stloc first use temp"
+;  V49 tmp41        [V49,T03] (  2, 97.73)   byref  ->   r9         "impAppendStmt"
 ;* V50 tmp42        [V50    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.BigStruct]>
 ;* V51 tmp43        [V51    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.BigStruct]>
 ;* V52 tmp44        [V52    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.BigStruct]>
@@ -732,18 +732,18 @@ G_M52646_IG21:
 ;* V54 tmp46        [V54    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V55 tmp47        [V55    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V56 tmp48        [V56    ] (  0,  0   )  struct (32) zero-ref    do-not-enreg[SF] "Inlining Arg" <System.Collections.BigStruct>
-;* V57 tmp49        [V57,T07] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V58 tmp50        [V58,T01] (  3,154.55)     int  ->   r9         "Inlining Arg"
+;* V57 tmp49        [V57,T09] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
+;  V58 tmp50        [V58,T01] (  2,126.01)     int  ->   r9         "Inlining Arg"
 ;* V59 tmp51        [V59    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[System.Collections.BigStruct]>
 ;* V60 tmp52        [V60    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.BigStruct]>
 ;* V61 tmp53        [V61    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V62 tmp54        [V62    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.BigStruct]>
 ;* V63 tmp55        [V63    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V64 tmp56        [V64,T16] (  3,  7.83)     int  ->  rbp         "Inlining Arg"
+;  V64 tmp56        [V64,T16] (  3,  7.80)     int  ->  rbp         "Inlining Arg"
 ;* V65 tmp57        [V65    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[System.Collections.BigStruct]>
 ;* V66 tmp58        [V66    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V67 tmp59        [V67,T17] ( 19,  5.49)   byref  ->  rsi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
-;  V68 tmp60        [V68,T18] (  8,  5.90)     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
+;  V67 tmp59        [V67,T17] ( 19,  5.48)   byref  ->  rsi         single-def "field V00._reference (fldOffset=0x0)" P-INDEP
+;  V68 tmp60        [V68,T18] (  8,  5.89)     int  ->  rdi         "field V00._length (fldOffset=0x8)" P-INDEP
 ;* V69 tmp61        [V69    ] (  0,  0   )   byref  ->  zero-ref    "field V09._reference (fldOffset=0x0)" P-INDEP
 ;* V70 tmp62        [V70    ] (  0,  0   )     int  ->  zero-ref    "field V09._length (fldOffset=0x8)" P-INDEP
 ;* V71 tmp63        [V71    ] (  0,  0   )   byref  ->  zero-ref    "field V10._reference (fldOffset=0x0)" P-INDEP
@@ -753,9 +753,9 @@ G_M52646_IG21:
 ;* V75 tmp67        [V75    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V76 tmp68        [V76    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
 ;  V77 tmp69        [V77,T25] (  2,  1.74)   byref  ->  rsi         single-def "field V43._reference (fldOffset=0x0)" P-INDEP
-;  V78 tmp70        [V78,T26] (  2,  1.74)     int  ->  rax         "field V43._length (fldOffset=0x8)" P-INDEP
-;  V79 tmp71        [V79,T02] (  6,123.89)   byref  ->  rsi         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
-;  V80 tmp72        [V80,T27] (  2,  1.74)     int  ->  rax         "field V46._length (fldOffset=0x8)" P-INDEP
+;  V78 tmp70        [V78,T26] (  2,  1.74)     int  ->   r8         "field V43._length (fldOffset=0x8)" P-INDEP
+;  V79 tmp71        [V79,T02] (  6,102.57)   byref  ->  rsi         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
+;  V80 tmp72        [V80,T27] (  2,  1.74)     int  ->   r8         "field V46._length (fldOffset=0x8)" P-INDEP
 ;* V81 tmp73        [V81    ] (  0,  0   )   byref  ->  zero-ref    "field V50._reference (fldOffset=0x0)" P-INDEP
 ;* V82 tmp74        [V82    ] (  0,  0   )     int  ->  zero-ref    "field V50._length (fldOffset=0x8)" P-INDEP
 ;* V83 tmp75        [V83    ] (  0,  0   )   byref  ->  zero-ref    "field V51._reference (fldOffset=0x0)" P-INDEP
@@ -769,27 +769,27 @@ G_M52646_IG21:
 ;  V91 tmp83        [V91,T52] (  2,  0   )   byref  ->  rcx         single-def "field V60._reference (fldOffset=0x0)" P-INDEP
 ;  V92 tmp84        [V92,T53] (  2,  0   )     int  ->  rax         "field V60._length (fldOffset=0x8)" P-INDEP
 ;* V93 tmp85        [V93,T28] (  0,  0   )   byref  ->  zero-ref    "field V62._reference (fldOffset=0x0)" P-INDEP
-;  V94 tmp86        [V94,T24] (  2,  1.94)     int  ->  rcx         "field V62._length (fldOffset=0x8)" P-INDEP
-;  V95 tmp87        [V95,T19] (  2,  3.94)   byref  ->  rcx         "field V65._reference (fldOffset=0x0)" P-INDEP
-;  V96 tmp88        [V96,T20] (  2,  3.94)     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
+;  V94 tmp86        [V94,T24] (  2,  1.93)     int  ->  rcx         "field V62._length (fldOffset=0x8)" P-INDEP
+;  V95 tmp87        [V95,T19] (  2,  3.93)   byref  ->  rcx         "field V65._reference (fldOffset=0x0)" P-INDEP
+;  V96 tmp88        [V96,T20] (  2,  3.93)     int  ->  rbp         "field V65._length (fldOffset=0x8)" P-INDEP
 ;  V97 tmp89        [V97,T48] (  3,  0.05)     int  ->  rax         "V17.[012..016)"
 ;  V98 tmp90        [V98,T35] (  3,  0.21)     int  ->  rcx         "V24.[012..016)"
-;  V99 tmp91        [V99,T36] (  3,  0.21)     int  ->  rcx         "V31.[012..016)"
+;  V99 tmp91        [V99,T36] (  3,  0.21)     int  ->  r10         "V31.[012..016)"
 ;  V100 tmp92       [V100,T37] (  3,  0.21)     int  ->  rcx         "V38.[012..016)"
-;  V101 tmp93       [V101,T06] (  4, 85.74)     int  ->  r10         "V47.[012..016)"
+;  V101 tmp93       [V101,T05] (  3, 52.84)     int  ->  r10         "V47.[012..016)"
 ;* V102 tmp94       [V102    ] (  0,  0   )     int  ->  zero-ref    "V56.[012..016)"
-;  V103 tmp95       [V103,T08] (  3, 52.66)   byref  ->  rdx         "Spilling address for field-by-field copy"
-;  V104 tmp96       [V104,T04] (  3,191.27)   byref  ->  rdx         "Spilling address for field-by-field copy"
+;  V103 tmp95       [V103,T06] (  3, 53.78)   byref  ->  rdx         "Spilling address for field-by-field copy"
+;  V104 tmp96       [V104,T07] (  3, 74.22)   byref  ->  rax         "Spilling address for field-by-field copy"
 ;* V105 tmp97       [V105    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.Span`1[System.Collections.BigStruct]>
-;  V106 tmp98       [V106    ] (  9, 17.65)  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[System.Collections.BigStruct]>
+;  V106 tmp98       [V106    ] (  9, 17.60)  struct (16) [rsp+0x20]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Span`1[System.Collections.BigStruct]>
 ;  V107 cse0        [V107,T34] (  6,  0.26)     int  ->  rdx         multi-def "CSE #02: conservative"
-;  V108 cse1        [V108,T38] (  3,  0.21)     int  ->  rdx         "CSE #07: conservative"
+;  V108 cse1        [V108,T38] (  3,  0.21)     int  ->  rcx         "CSE #07: conservative"
 ;  V109 cse2        [V109,T39] (  3,  0.21)     int  ->  rdx         "CSE #08: conservative"
-;  V110 cse3        [V110,T05] (  3, 89.47)    long  ->  rdx         "CSE #11: aggressive"
-;  V111 cse4        [V111,T11] (  3, 33.62)     int  ->  rax         "CSE #09: moderate"
-;  V112 cse5        [V112,T51] (  2, 40.65)  simd32  ->  mm0         "CSE #16: aggressive"
-;  V113 cse6        [V113,T10] (  3, 49.43)     int  ->  rcx         "CSE #17: aggressive"
-;  V114 cse7        [V114,T22] (  3,  3.91)    long  ->  rcx         "CSE #01: moderate"
+;  V110 cse3        [V110,T04] (  3, 87.44)    long  ->  rdx         "CSE #11: aggressive"
+;  V111 cse4        [V111,T12] (  3, 14.11)     int  ->   r8         "CSE #09: moderate"
+;  V112 cse5        [V112,T51] (  2, 21.33)  simd32  ->  mm0         "CSE #16: aggressive"
+;  V113 cse6        [V113,T10] (  3, 30.30)     int  ->  rcx         "CSE #17: aggressive"
+;  V114 cse7        [V114,T22] (  3,  3.90)    long  ->  rcx         "CSE #01: moderate"
 ;
 ; Lcl frame size = 176
 
@@ -809,18 +809,18 @@ G_M52646_IG02:
        mov      edi, dword ptr [rcx+0x08]
        mov      ebp, edi
        cmp      edi, 1
-       jle      G_M52646_IG22
+       jle      G_M52646_IG19
 						;; size=17 bbWeight=1 PerfScore 5.50
 G_M52646_IG03:
        cmp      ebp, 16
        jle      SHORT G_M52646_IG07
-						;; size=5 bbWeight=1.95 PerfScore 2.44
+						;; size=5 bbWeight=1.94 PerfScore 2.43
 G_M52646_IG04:
        test     ebx, ebx
-       je       G_M52646_IG34
+       je       G_M52646_IG33
        dec      ebx
        cmp      ebp, edi
-       ja       G_M52646_IG35
+       ja       G_M52646_IG34
        mov      ecx, ebp
        mov      bword ptr [rsp+0x20], rsi
        mov      dword ptr [rsp+0x28], ecx
@@ -833,8 +833,8 @@ G_M52646_IG04:
        add      rdx, rcx
        mov      eax, edi
        cmp      rdx, rax
-       ja       G_M52646_IG35
-						;; size=65 bbWeight=0.97 PerfScore 11.17
+       ja       G_M52646_IG34
+						;; size=65 bbWeight=0.97 PerfScore 11.11
 G_M52646_IG05:
        shl      rcx, 5
        add      rcx, rsi
@@ -846,95 +846,85 @@ G_M52646_IG05:
        mov      ebp, r14d
        cmp      ebp, 1
        jg       SHORT G_M52646_IG03
-						;; size=37 bbWeight=1.97 PerfScore 15.77
+						;; size=37 bbWeight=1.97 PerfScore 15.73
 G_M52646_IG06:
-       jmp      G_M52646_IG22
-       align    [0 bytes for IG11]
-						;; size=5 bbWeight=0.02 PerfScore 0.04
+       jmp      G_M52646_IG19
+       align    [7 bytes for IG11]
+						;; size=12 bbWeight=0.02 PerfScore 0.04
 G_M52646_IG07:
        cmp      ebp, 2
-       je       G_M52646_IG19
+       je       G_M52646_IG16
 						;; size=9 bbWeight=0.98 PerfScore 1.22
 G_M52646_IG08:
        cmp      ebp, 3
-       je       G_M52646_IG23
+       je       G_M52646_IG20
 						;; size=9 bbWeight=0.96 PerfScore 1.20
 G_M52646_IG09:
        cmp      ebp, edi
-       ja       G_M52646_IG35
-       mov      eax, ebp
-       xor      r8d, r8d
-       dec      eax
-       test     eax, eax
-       jle      G_M52646_IG22
-						;; size=23 bbWeight=0.87 PerfScore 2.83
+       ja       G_M52646_IG34
+       mov      r8d, ebp
+       xor      eax, eax
+       dec      r8d
+       test     r8d, r8d
+       jle      G_M52646_IG19
+						;; size=25 bbWeight=0.87 PerfScore 2.83
 G_M52646_IG10:
-       lea      ecx, [r8+0x01]
+       lea      ecx, [rax+0x01]
        movsxd   rdx, ecx
        shl      rdx, 5
        add      rdx, rsi
        mov      r10d, dword ptr [rdx+0x0C]
        vmovups  ymm0, ymmword ptr [rdx]
        jmp      SHORT G_M52646_IG12
-						;; size=24 bbWeight=8.78 PerfScore 92.15
+						;; size=23 bbWeight=8.96 PerfScore 94.12
 G_M52646_IG11:
-       lea      r9d, [r8+0x01]
+       lea      r9d, [rax+0x01]
        movsxd   r9, r9d
        shl      r9, 5
        add      r9, rsi
        vmovdqu  ymm1, ymmword ptr [rsi+rdx]
        vmovdqu  ymmword ptr [r9], ymm1
-       dec      r8d
-						;; size=27 bbWeight=25.09 PerfScore 219.50
+       dec      eax
+						;; size=26 bbWeight=24.43 PerfScore 213.79
 G_M52646_IG12:
-       test     r8d, r8d
-       jl       SHORT G_M52646_IG15
-						;; size=5 bbWeight=33.86 PerfScore 42.33
+       test     eax, eax
+       jl       SHORT G_M52646_IG14
+						;; size=4 bbWeight=33.52 PerfScore 41.90
 G_M52646_IG13:
-       movsxd   rdx, r8d
+       movsxd   rdx, eax
        shl      rdx, 5
        mov      r9d, dword ptr [rsi+rdx+0x0C]
        cmp      r10d, r9d
-       jge      SHORT G_M52646_IG17
-						;; size=17 bbWeight=32.19 PerfScore 128.77
+       jl       SHORT G_M52646_IG11
+						;; size=17 bbWeight=31.50 PerfScore 126.01
 G_M52646_IG14:
-       jmp      SHORT G_M52646_IG11
-						;; size=2 bbWeight=18.99 PerfScore 37.98
-G_M52646_IG15:
-       lea      edx, [r8+0x01]
-       movsxd   rdx, edx
-       shl      rdx, 5
-       add      rdx, rsi
-       vmovups  ymmword ptr [rdx], ymm0
-       mov      dword ptr [rdx+0x0C], r10d
-       mov      r8d, ecx
-       cmp      r8d, eax
+       inc      eax
+       cdqe     
+       shl      rax, 5
+       add      rax, rsi
+       vmovups  ymmword ptr [rax], ymm0
+       mov      dword ptr [rax+0x0C], r10d
+       mov      eax, ecx
+       cmp      eax, r8d
        jl       SHORT G_M52646_IG10
-						;; size=30 bbWeight=31.88 PerfScore 191.27
-G_M52646_IG16:
-       jmp      SHORT G_M52646_IG22
+						;; size=26 bbWeight=12.37 PerfScore 71.13
+G_M52646_IG15:
+       jmp      SHORT G_M52646_IG19
 						;; size=2 bbWeight=0.87 PerfScore 1.74
-G_M52646_IG17:
-       cmp      r10d, r9d
-       jle      SHORT G_M52646_IG15
-						;; size=5 bbWeight=12.89 PerfScore 16.11
-G_M52646_IG18:
-       jmp      SHORT G_M52646_IG15
-						;; size=2 bbWeight=12.88 PerfScore 25.77
-G_M52646_IG19:
+G_M52646_IG16:
        lea      rcx, bword ptr [rsi+0x20]
        cmp      byte  ptr [rsi], sil
        mov      eax, dword ptr [rcx+0x0C]
        lea      rdx, bword ptr [rsi+0x0C]
        mov      edx, dword ptr [rdx]
        cmp      edx, eax
-       jl       SHORT G_M52646_IG22
+       jl       SHORT G_M52646_IG19
 						;; size=20 bbWeight=0.02 PerfScore 0.20
-G_M52646_IG20:
+G_M52646_IG17:
        cmp      edx, eax
-       jle      SHORT G_M52646_IG22
+       jle      SHORT G_M52646_IG19
 						;; size=4 bbWeight=0.01 PerfScore 0.01
-G_M52646_IG21:
+G_M52646_IG18:
        vmovdqu  ymm0, ymmword ptr [rsi]
        vmovdqu  ymmword ptr [rsp+0x90], ymm0
        vmovdqu  ymm0, ymmword ptr [rcx]
@@ -942,7 +932,7 @@ G_M52646_IG21:
        vmovdqu  ymm0, ymmword ptr [rsp+0x90]
        vmovdqu  ymmword ptr [rcx], ymm0
 						;; size=34 bbWeight=0.01 PerfScore 0.19
-G_M52646_IG22:
+G_M52646_IG19:
        vzeroupper 
        add      rsp, 176
        pop      rbx
@@ -952,9 +942,9 @@ G_M52646_IG22:
        pop      r14
        ret      
 						;; size=17 bbWeight=0.02 PerfScore 0.10
-G_M52646_IG23:
+G_M52646_IG20:
        cmp      edi, 2
-       jbe      G_M52646_IG33
+       jbe      G_M52646_IG32
        lea      rax, bword ptr [rsi+0x40]
        lea      r8, bword ptr [rsi+0x20]
        cmp      byte  ptr [rsi], sil
@@ -962,82 +952,89 @@ G_M52646_IG23:
        lea      rdx, bword ptr [rsi+0x0C]
        mov      edx, dword ptr [rdx]
        cmp      edx, ecx
-       jl       SHORT G_M52646_IG25
-						;; size=34 bbWeight=0.09 PerfScore 0.95
-G_M52646_IG24:
-       cmp      edx, ecx
-       jg       SHORT G_M52646_IG28
-						;; size=4 bbWeight=0.04 PerfScore 0.04
-G_M52646_IG25:
+       jge      G_M52646_IG28
+						;; size=38 bbWeight=0.09 PerfScore 0.95
+G_M52646_IG21:
+       mov      r10d, dword ptr [rax+0x0C]
+       lea      rcx, bword ptr [rsi+0x0C]
+       mov      ecx, dword ptr [rcx]
+       cmp      ecx, r10d
+       jge      G_M52646_IG30
+						;; size=19 bbWeight=0.09 PerfScore 0.50
+G_M52646_IG22:
        mov      ecx, dword ptr [rax+0x0C]
-       lea      rdx, bword ptr [rsi+0x0C]
-       mov      edx, dword ptr [rdx]
+       lea      r10, bword ptr [r8+0x0C]
+       mov      edx, dword ptr [r10]
        cmp      edx, ecx
-       jl       SHORT G_M52646_IG30
-						;; size=13 bbWeight=0.09 PerfScore 0.50
-G_M52646_IG26:
+       jl       SHORT G_M52646_IG19
+						;; size=14 bbWeight=0.09 PerfScore 0.50
+G_M52646_IG23:
        cmp      edx, ecx
-       jle      SHORT G_M52646_IG30
-						;; size=4 bbWeight=0.04 PerfScore 0.04
-G_M52646_IG27:
-       jmp      SHORT G_M52646_IG29
-						;; size=2 bbWeight=0.04 PerfScore 0.07
-G_M52646_IG28:
+       jle      SHORT G_M52646_IG19
+						;; size=4 bbWeight=0.03 PerfScore 0.04
+G_M52646_IG24:
+       jmp      SHORT G_M52646_IG27
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M52646_IG25:
        vmovdqu  ymm0, ymmword ptr [rsi]
        vmovdqu  ymmword ptr [rsp+0x70], ymm0
        vmovdqu  ymm0, ymmword ptr [r8]
        vmovdqu  ymmword ptr [rsi], ymm0
        vmovdqu  ymm0, ymmword ptr [rsp+0x70]
        vmovdqu  ymmword ptr [r8], ymm0
-       jmp      SHORT G_M52646_IG25
-						;; size=32 bbWeight=0.04 PerfScore 0.84
-G_M52646_IG29:
+       jmp      SHORT G_M52646_IG21
+						;; size=32 bbWeight=0.04 PerfScore 0.83
+G_M52646_IG26:
        vmovdqu  ymm0, ymmword ptr [rsi]
        vmovdqu  ymmword ptr [rsp+0x50], ymm0
        vmovdqu  ymm0, ymmword ptr [rax]
        vmovdqu  ymmword ptr [rsi], ymm0
        vmovdqu  ymm0, ymmword ptr [rsp+0x50]
        vmovdqu  ymmword ptr [rax], ymm0
-						;; size=28 bbWeight=0.04 PerfScore 0.76
-G_M52646_IG30:
-       mov      ecx, dword ptr [rax+0x0C]
-       lea      rdx, bword ptr [r8+0x0C]
-       mov      edx, dword ptr [rdx]
-       cmp      edx, ecx
-       jl       G_M52646_IG22
-						;; size=17 bbWeight=0.09 PerfScore 0.50
-G_M52646_IG31:
-       cmp      edx, ecx
-       jle      G_M52646_IG22
-						;; size=8 bbWeight=0.04 PerfScore 0.04
-G_M52646_IG32:
+       jmp      SHORT G_M52646_IG22
+						;; size=30 bbWeight=0.04 PerfScore 0.83
+G_M52646_IG27:
        vmovdqu  ymm0, ymmword ptr [r8]
        vmovdqu  ymmword ptr [rsp+0x30], ymm0
        vmovdqu  ymm0, ymmword ptr [rax]
        vmovdqu  ymmword ptr [r8], ymm0
        vmovdqu  ymm0, ymmword ptr [rsp+0x30]
        vmovdqu  ymmword ptr [rax], ymm0
-       jmp      G_M52646_IG22
-						;; size=35 bbWeight=0.04 PerfScore 0.84
-G_M52646_IG33:
+       jmp      G_M52646_IG19
+						;; size=35 bbWeight=0.04 PerfScore 0.83
+G_M52646_IG28:
+       cmp      edx, ecx
+       jle      G_M52646_IG21
+						;; size=8 bbWeight=0.03 PerfScore 0.04
+G_M52646_IG29:
+       jmp      SHORT G_M52646_IG25
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M52646_IG30:
+       cmp      ecx, r10d
+       jle      G_M52646_IG22
+						;; size=9 bbWeight=0.03 PerfScore 0.04
+G_M52646_IG31:
+       jmp      SHORT G_M52646_IG26
+						;; size=2 bbWeight=0.03 PerfScore 0.07
+G_M52646_IG32:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M52646_IG34:
+G_M52646_IG33:
        cmp      ebp, edi
-       ja       SHORT G_M52646_IG35
+       ja       SHORT G_M52646_IG34
        mov      rcx, rsi
        mov      eax, ebp
        mov      bword ptr [rsp+0x20], rcx
        mov      dword ptr [rsp+0x28], eax
        lea      rcx, [rsp+0x20]
        call     [System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:HeapSort(System.Span`1[System.Collections.BigStruct])]
-       jmp      G_M52646_IG22
+       jmp      G_M52646_IG19
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M52646_IG35:
+G_M52646_IG34:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 604, prolog size 22, PerfScore 807.61, instruction count 174, allocated bytes for code 604 (MethodHash=b8643259) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:IntroSort(System.Span`1[System.Collections.BigStruct],int) (Tier1)
+; Total bytes of code 615, prolog size 22, PerfScore 600.76, instruction count 173, allocated bytes for code 615 (MethodHash=b8643259) for method System.Collections.Generic.GenericArraySortHelper`1[System.Collections.BigStruct]:IntroSort(System.Span`1[System.Collections.BigStruct],int) (Tier1)
 ; ============================================================
 


```

</details>

# ``System.IO.Tests.UnmanagedMemoryStreamTests.ReadAsBytes``

Hot functions:

- (56.87%) ``UnmanagedMemoryStream.ReadByte`` (Tier-1)
  - **Has diffs**
- (35.55%) ``UnmanagedMemoryStream.get_CanRead`` (Tier-1)
  - No diffs
- (6.00%) ``UnmanagedMemoryStreamTests.ReadAsBytes`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]UnmanagedMemoryStream.ReadByte()``

```diff
 ; 3 inlinees with PGO data; 0 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 15, 12.00)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.IO.UnmanagedMemoryStream>
+;  V00 this         [V00,T00] ( 15, 10.00)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.IO.UnmanagedMemoryStream>
 ;  V01 loc0         [V01,T01] (  5,  4.00)    long  ->  rbx        
 ;* V02 loc1         [V02    ] (  0,  0   )    long  ->  zero-ref   
-;  V03 loc2         [V03,T03] (  3,  2.00)     int  ->  [rbp-0x0C]  do-not-enreg[Z] EH-live
+;  V03 loc2         [V03,T02] (  3,  2.00)     int  ->  [rbp-0x0C]  do-not-enreg[Z] EH-live
 ;  V04 loc3         [V04    ] (  4,  0   )    long  ->  [rbp-0x18]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T02] (  2,  2   )     int  ->  rax         "guarded devirt return temp"
+;  V06 tmp1         [V06,T04] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <<unknown class>>
-;  V08 PSPSym       [V08,T04] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
+;  V08 PSPSym       [V08,T03] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
 ;
 ; Lcl frame size = 56
 
@@ -31,34 +31,25 @@ G_M44716_IG01:
 						;; size=19 bbWeight=1 PerfScore 4.75
 G_M44716_IG02:
        cmp      byte  ptr [rcx+0x44], 0
-       je       G_M44716_IG15
+       je       G_M44716_IG14
        mov      rax, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rcx], rax
-       jne      SHORT G_M44716_IG04
-						;; size=25 bbWeight=1 PerfScore 8.25
+       jne      G_M44716_IG15
+						;; size=29 bbWeight=1 PerfScore 8.25
 G_M44716_IG03:
        test     byte  ptr [rcx+0x40], 1
-       jne      SHORT G_M44716_IG05
-       jmp      G_M44716_IG16
-						;; size=11 bbWeight=1.00 PerfScore 6.00
-G_M44716_IG04:
-       mov      rax, qword ptr [rcx]
-       mov      rax, qword ptr [rax+0x40]
-       call     [rax+0x28]<unknown method>
-       test     eax, eax
-       mov      rcx, gword ptr [rbp+0x10]
        je       G_M44716_IG16
-						;; size=22 bbWeight=1 PerfScore 9.25
-G_M44716_IG05:
+						;; size=10 bbWeight=1.00 PerfScore 4.00
+G_M44716_IG04:
        mov      rbx, qword ptr [rcx+0x38]
        cmp      rbx, qword ptr [rcx+0x30]
-       jge      SHORT G_M44716_IG09
+       jge      SHORT G_M44716_IG08
 						;; size=10 bbWeight=1 PerfScore 6.00
-G_M44716_IG06:
+G_M44716_IG05:
        lea      rax, [rbx+0x01]
        mov      qword ptr [rcx+0x38], rax
        cmp      gword ptr [rcx+0x10], 0
-       jne      SHORT G_M44716_IG11
+       jne      SHORT G_M44716_IG10
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      rcx, gword ptr [rbp+0x10]
@@ -66,33 +57,33 @@ G_M44716_IG06:
        movzx    rcx, byte  ptr [rcx+rbx]
        mov      dword ptr [rbp-0x0C], ecx
 						;; size=45 bbWeight=1.00 PerfScore 12.75
-G_M44716_IG07:
+G_M44716_IG06:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      eax, dword ptr [rbp-0x0C]
 						;; size=18 bbWeight=1.00 PerfScore 2.25
-G_M44716_IG08:
+G_M44716_IG07:
        add      rsp, 56
        pop      rbx
        pop      rbp
        ret      
 						;; size=7 bbWeight=1.00 PerfScore 2.25
-G_M44716_IG09:
+G_M44716_IG08:
        mov      rcx, 0xD1FFAB1E
        call     CORINFO_HELP_COUNTPROFILE32
        mov      eax, -1
 						;; size=20 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG10:
+G_M44716_IG09:
        add      rsp, 56
        pop      rbx
        pop      rbp
        ret      
 						;; size=7 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG11:
+G_M44716_IG10:
        xor      edx, edx
        mov      qword ptr [rbp-0x18], rdx
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M44716_IG12:
+G_M44716_IG11:
        mov      rcx, gword ptr [rbp+0x10]
        mov      rcx, gword ptr [rcx+0x10]
        lea      rdx, [rbp-0x18]
@@ -104,18 +95,26 @@ G_M44716_IG12:
        movzx    rax, byte  ptr [rbx+rax]
        mov      dword ptr [rbp-0x0C], eax
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M44716_IG13:
+G_M44716_IG12:
        mov      rcx, rsp
        call     G_M44716_IG17
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M44716_IG14:
-       jmp      SHORT G_M44716_IG07
+G_M44716_IG13:
+       jmp      SHORT G_M44716_IG06
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M44716_IG15:
+G_M44716_IG14:
        xor      rcx, rcx
        call     [System.ThrowHelper:ThrowObjectDisposedException_StreamClosed(System.String)]
        int3     
 						;; size=9 bbWeight=0 PerfScore 0.00
+G_M44716_IG15:
+       mov      rax, qword ptr [rcx]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x28]<unknown method>
+       test     eax, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       jne      G_M44716_IG04
+						;; size=22 bbWeight=0 PerfScore 0.00
 G_M44716_IG16:
        call     [System.ThrowHelper:ThrowNotSupportedException_UnreadableStream()]
        int3     
@@ -150,7 +149,7 @@ G_M44716_IG20:
        ret      
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 335, prolog size 19, PerfScore 51.50, instruction count 88, allocated bytes for code 335 (MethodHash=fdba5153) for method System.IO.UnmanagedMemoryStream:ReadByte():int:this (Instrumented Tier1)
+; Total bytes of code 338, prolog size 19, PerfScore 40.25, instruction count 87, allocated bytes for code 338 (MethodHash=fdba5153) for method System.IO.UnmanagedMemoryStream:ReadByte():int:this (Instrumented Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.IO.UnmanagedMemoryStream:ReadByte():int:this (Tier1)
@@ -160,19 +159,19 @@ G_M44716_IG20:
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 200532
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 210197
 ; 3 inlinees with PGO data; 0 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] ( 15, 12.00)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.IO.UnmanagedMemoryStream>
+;  V00 this         [V00,T00] ( 15, 10.01)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.IO.UnmanagedMemoryStream>
 ;  V01 loc0         [V01,T01] (  5,  4.00)    long  ->  rbx        
 ;* V02 loc1         [V02    ] (  0,  0   )    long  ->  zero-ref   
-;  V03 loc2         [V03,T03] (  3,  2.00)     int  ->  [rbp-0x0C]  do-not-enreg[Z] EH-live
-;  V04 loc3         [V04    ] (  4,  0.00)    long  ->  [rbp-0x18]  do-not-enreg[X] addr-exposed ld-addr-op
+;  V03 loc2         [V03,T02] (  3,  2.00)     int  ->  [rbp-0x0C]  do-not-enreg[Z] EH-live
+;  V04 loc3         [V04    ] (  4,  0.03)    long  ->  [rbp-0x18]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T02] (  2,  2.00)     int  ->  rax         "guarded devirt return temp"
+;  V06 tmp1         [V06,T04] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <<unknown class>>
-;  V08 PSPSym       [V08,T04] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
+;  V08 PSPSym       [V08,T03] (  1,  1   )    long  ->  [rbp-0x20]  do-not-enreg[V] "PSPSym"
 ;
 ; Lcl frame size = 56
 
@@ -186,56 +185,43 @@ G_M44716_IG01:
 						;; size=19 bbWeight=1 PerfScore 4.75
 G_M44716_IG02:
        cmp      byte  ptr [rcx+0x44], 0
-       je       G_M44716_IG17
+       je       G_M44716_IG14
        mov      rax, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rcx], rax
-       jne      SHORT G_M44716_IG05
-						;; size=25 bbWeight=1 PerfScore 8.25
-G_M44716_IG03:
+       jne      G_M44716_IG15
        test     byte  ptr [rcx+0x40], 1
-       jne      SHORT G_M44716_IG06
-						;; size=6 bbWeight=1.00 PerfScore 4.00
-G_M44716_IG04:
-       jmp      G_M44716_IG18
-						;; size=5 bbWeight=1.00 PerfScore 2.00
-G_M44716_IG05:
-       mov      rax, qword ptr [rcx]
-       mov      rax, qword ptr [rax+0x40]
-       call     [rax+0x28]<unknown method>
-       test     eax, eax
-       mov      rcx, gword ptr [rbp+0x10]
-       je       SHORT G_M44716_IG18
-						;; size=18 bbWeight=1.00 PerfScore 9.25
-G_M44716_IG06:
+       je       G_M44716_IG16
+						;; size=39 bbWeight=1 PerfScore 12.25
+G_M44716_IG03:
        mov      rbx, qword ptr [rcx+0x38]
        cmp      rbx, qword ptr [rcx+0x30]
-       jge      SHORT G_M44716_IG15
+       jge      SHORT G_M44716_IG12
 						;; size=10 bbWeight=1 PerfScore 6.00
-G_M44716_IG07:
+G_M44716_IG04:
        lea      rdx, [rbx+0x01]
        mov      qword ptr [rcx+0x38], rdx
        cmp      gword ptr [rcx+0x10], 0
-       jne      SHORT G_M44716_IG11
+       jne      SHORT G_M44716_IG08
 						;; size=15 bbWeight=1.00 PerfScore 5.50
-G_M44716_IG08:
+G_M44716_IG05:
        mov      rax, qword ptr [rcx+0x18]
        movzx    rax, byte  ptr [rax+rbx]
        mov      dword ptr [rbp-0x0C], eax
-						;; size=11 bbWeight=1.00 PerfScore 5.00
-G_M44716_IG09:
+						;; size=11 bbWeight=0.99 PerfScore 4.95
+G_M44716_IG06:
        mov      eax, dword ptr [rbp-0x0C]
 						;; size=3 bbWeight=1.00 PerfScore 1.00
-G_M44716_IG10:
+G_M44716_IG07:
        add      rsp, 56
        pop      rbx
        pop      rbp
        ret      
 						;; size=7 bbWeight=1.00 PerfScore 2.25
-G_M44716_IG11:
+G_M44716_IG08:
        xor      edx, edx
        mov      qword ptr [rbp-0x18], rdx
-						;; size=6 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG12:
+						;; size=6 bbWeight=0.01 PerfScore 0.01
+G_M44716_IG09:
        mov      rcx, gword ptr [rcx+0x10]
        lea      rdx, [rbp-0x18]
        cmp      dword ptr [rcx], ecx
@@ -245,33 +231,41 @@ G_M44716_IG12:
        mov      rax, qword ptr [rcx+0x28]
        movzx    rax, byte  ptr [rbx+rax]
        mov      dword ptr [rbp-0x0C], eax
-						;; size=35 bbWeight=0.00 PerfScore 0.01
-G_M44716_IG13:
+						;; size=35 bbWeight=0.01 PerfScore 0.16
+G_M44716_IG10:
        mov      rcx, rsp
-       call     G_M44716_IG19
-						;; size=8 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG14:
-       jmp      SHORT G_M44716_IG09
-						;; size=2 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG15:
+       call     G_M44716_IG17
+						;; size=8 bbWeight=0.01 PerfScore 0.01
+G_M44716_IG11:
+       jmp      SHORT G_M44716_IG06
+						;; size=2 bbWeight=0.01 PerfScore 0.02
+G_M44716_IG12:
        mov      eax, -1
 						;; size=5 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG16:
+G_M44716_IG13:
        add      rsp, 56
        pop      rbx
        pop      rbp
        ret      
 						;; size=7 bbWeight=0.00 PerfScore 0.00
-G_M44716_IG17:
+G_M44716_IG14:
        xor      rcx, rcx
        call     [System.ThrowHelper:ThrowObjectDisposedException_StreamClosed(System.String)]
        int3     
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M44716_IG18:
+G_M44716_IG15:
+       mov      rax, qword ptr [rcx]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x28]<unknown method>
+       test     eax, eax
+       mov      rcx, gword ptr [rbp+0x10]
+       jne      G_M44716_IG03
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M44716_IG16:
        call     [System.ThrowHelper:ThrowNotSupportedException_UnreadableStream()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M44716_IG19:
+G_M44716_IG17:
        push     rbp
        push     rbx
        sub      rsp, 40
@@ -279,24 +273,24 @@ G_M44716_IG19:
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x40]
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M44716_IG20:
+G_M44716_IG18:
        cmp      qword ptr [rbp-0x18], 0
-       je       SHORT G_M44716_IG21
+       je       SHORT G_M44716_IG19
        mov      rcx, gword ptr [rbp+0x10]
        mov      rcx, gword ptr [rcx+0x10]
        cmp      dword ptr [rcx], ecx
        call     [System.Runtime.InteropServices.SafeBuffer:ReleasePointer():this]
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M44716_IG21:
+G_M44716_IG19:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M44716_IG22:
+G_M44716_IG20:
        add      rsp, 40
        pop      rbx
        pop      rbp
        ret      
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 248, prolog size 19, PerfScore 48.00, instruction count 76, allocated bytes for code 248 (MethodHash=fdba5153) for method System.IO.UnmanagedMemoryStream:ReadByte():int:this (Tier1)
+; Total bytes of code 255, prolog size 19, PerfScore 36.90, instruction count 75, allocated bytes for code 255 (MethodHash=fdba5153) for method System.IO.UnmanagedMemoryStream:ReadByte():int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.ContainsTrue<String>.LinkedList(Size: 512)``

Hot functions:

- (89.07%) ``System.Collections.Generic.LinkedList`1.Find`` (Tier-1)
  - **Has diffs**
- (4.39%) ``SpanHelpers.SequenceEqual`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Collections]System.Collections.Generic.LinkedList`1[System.__Canon].Find(!0)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 81232
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 80000
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T05] (  7, 259.09)     ref  ->  rsi         this class-hnd single-def <System.Collections.Generic.LinkedList`1[System.__Canon]>
-;  V01 arg1         [V01,T02] ( 10, 519.38)     ref  ->  rbx         class-hnd single-def <System.__Canon>
-;  V02 loc0         [V02,T01] ( 15,1024.37)     ref  ->  rdi         class-hnd <System.Collections.Generic.LinkedListNode`1[System.__Canon]>
-;  V03 loc1         [V03,T08] (  6,   5.56)     ref  ->  rbp         class-hnd single-def <System.Collections.Generic.EqualityComparer`1[System.__Canon]>
+;  V00 this         [V00,T06] (  7,   4   )     ref  ->  rsi         this class-hnd single-def <System.Collections.Generic.LinkedList`1[System.__Canon]>
+;  V01 arg1         [V01,T01] ( 10, 514.54)     ref  ->  rbx         class-hnd single-def <System.__Canon>
+;  V02 loc0         [V02,T03] ( 15, 255.62)     ref  ->  rdi         class-hnd <System.Collections.Generic.LinkedListNode`1[System.__Canon]>
+;  V03 loc1         [V03,T08] (  6,   5.54)     ref  ->  rbp         class-hnd single-def <System.Collections.Generic.EqualityComparer`1[System.__Canon]>
 ;  V04 OutArgs      [V04    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V05 tmp1         [V05    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
-;  V06 tmp2         [V06,T03] (  5, 512.18)     int  ->  r14         "guarded devirt return temp"
-;  V07 tmp3         [V07,T00] ( 13,2067.61)     ref  ->  rdx         "guarded devirt arg temp"
+;  V06 tmp2         [V06,T04] (  5, 253.62)     int  ->  r14         "guarded devirt return temp"
+;  V07 tmp3         [V07,T00] ( 13,2047.98)     ref  ->  rdx         "guarded devirt arg temp"
 ;* V08 tmp4         [V08    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
 ;* V09 tmp5         [V09    ] (  0,   0   )     ref  ->  zero-ref    ld-addr-op class-hnd "Inlining Arg" <System.String>
-;  V10 tmp6         [V10,T04] (  8, 262.38)   ubyte  ->  r14         "Inline return value spill temp"
+;  V10 tmp6         [V10,T02] (  8, 259.74)   ubyte  ->  r14         "Inline return value spill temp"
 ;* V11 tmp7         [V11    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V12 tmp8         [V12,T06] (  4,  20.96)   byref  ->  rcx         "impAppendStmt"
+;  V12 tmp8         [V12,T05] (  4,  20.83)   byref  ->  rcx         "impAppendStmt"
 ;  V13 rat0         [V13,T09] (  3,   4.40)    long  ->  rcx         "Spilling to split statement for tree"
 ;  V14 rat1         [V14,T10] (  3,   4   )    long  ->  rdx         "runtime lookup"
 ;  V15 rat2         [V15,T07] (  3,   5.60)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
@@ -408,34 +408,34 @@ G_M62180_IG02:
        mov      rdx, qword ptr [rdx]
        mov      rdx, qword ptr [rdx+0x28]
        test     rdx, rdx
-       je       G_M62180_IG12
+       je       G_M62180_IG11
 						;; size=27 bbWeight=1 PerfScore 11.25
 G_M62180_IG03:
        mov      rcx, rdx
        call     [System.Collections.Generic.EqualityComparer`1[System.__Canon]:get_Default():System.Collections.Generic.EqualityComparer`1[System.__Canon]]
        mov      rbp, rax
        test     rdi, rdi
-       je       G_M62180_IG21
+       je       G_M62180_IG26
        test     rbx, rbx
-       je       G_M62180_IG20
+       je       G_M62180_IG25
        test     rbp, rbp
-       je       SHORT G_M62180_IG10
+       je       SHORT G_M62180_IG09
        mov      r8, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rbp], r8
-       jne      SHORT G_M62180_IG10
+       jne      SHORT G_M62180_IG09
 						;; size=51 bbWeight=1 PerfScore 11.50
 G_M62180_IG04:
        mov      rdx, gword ptr [rdi+0x20]
        test     rdx, rdx
-       je       SHORT G_M62180_IG08
+       je       G_M62180_IG17
        cmp      rdx, rbx
-       je       SHORT G_M62180_IG09
-						;; size=14 bbWeight=253.53 PerfScore 1140.89
+       je       SHORT G_M62180_IG08
+						;; size=18 bbWeight=251.08 PerfScore 1129.88
 G_M62180_IG05:
        mov      r8d, dword ptr [rdx+0x08]
        cmp      r8d, dword ptr [rbx+0x08]
-       jne      G_M62180_IG23
-						;; size=14 bbWeight=252.50 PerfScore 1514.97
+       jne      G_M62180_IG15
+						;; size=14 bbWeight=250.19 PerfScore 1501.11
 G_M62180_IG06:
        lea      rcx, bword ptr [rdx+0x0C]
        mov      r8d, dword ptr [rdx+0x08]
@@ -443,46 +443,39 @@ G_M62180_IG06:
        lea      rdx, bword ptr [rbx+0x0C]
        call     [<unknown method>]
        mov      r14d, eax
-						;; size=24 bbWeight=5.19 PerfScore 33.72
+						;; size=24 bbWeight=5.16 PerfScore 33.52
 G_M62180_IG07:
-       test     r14d, r14d
-       jne      G_M62180_IG18
-						;; size=9 bbWeight=253.53 PerfScore 316.91
+       jmp      SHORT G_M62180_IG16
+						;; size=2 bbWeight=251.08 PerfScore 502.17
 G_M62180_IG08:
-       mov      rdi, gword ptr [rdi+0x10]
-       cmp      rdi, gword ptr [rsi+0x08]
-       je       G_M62180_IG21
-       jmp      SHORT G_M62180_IG04
-						;; size=16 bbWeight=252.54 PerfScore 2020.33
-G_M62180_IG09:
        mov      r14d, 1
        jmp      SHORT G_M62180_IG07
-						;; size=8 bbWeight=1.04 PerfScore 2.33
-G_M62180_IG10:
+						;; size=8 bbWeight=0.90 PerfScore 2.02
+G_M62180_IG09:
        mov      rdx, gword ptr [rdi+0x20]
        mov      r8, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rbp], r8
-       jne      G_M62180_IG25
+       jne      SHORT G_M62180_IG20
        test     rdx, rdx
-       je       SHORT G_M62180_IG16
+       je       G_M62180_IG22
        cmp      rdx, rbx
-       jne      SHORT G_M62180_IG13
-						;; size=34 bbWeight=2.56 PerfScore 22.41
-G_M62180_IG11:
-       jmp      SHORT G_M62180_IG17
+       jne      SHORT G_M62180_IG12
+						;; size=34 bbWeight=2.54 PerfScore 22.19
+G_M62180_IG10:
+       jmp      SHORT G_M62180_IG18
 						;; size=2 bbWeight=0.01 PerfScore 0.02
-G_M62180_IG12:
+G_M62180_IG11:
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rdx, rax
        jmp      G_M62180_IG03
 						;; size=23 bbWeight=0.20 PerfScore 0.70
-G_M62180_IG13:
+G_M62180_IG12:
        mov      r8d, dword ptr [rdx+0x08]
        cmp      r8d, dword ptr [rbx+0x08]
-       jne      SHORT G_M62180_IG24
-						;; size=10 bbWeight=2.55 PerfScore 15.30
-G_M62180_IG14:
+       jne      SHORT G_M62180_IG19
+						;; size=10 bbWeight=2.53 PerfScore 15.16
+G_M62180_IG13:
        lea      rcx, bword ptr [rdx+0x0C]
        mov      r8d, dword ptr [rdx+0x08]
        add      r8d, r8d
@@ -490,43 +483,53 @@ G_M62180_IG14:
        call     [<unknown method>]
        mov      r14d, eax
 						;; size=24 bbWeight=0.05 PerfScore 0.34
+G_M62180_IG14:
+       jmp      SHORT G_M62180_IG21
+						;; size=2 bbWeight=2.54 PerfScore 5.07
 G_M62180_IG15:
-       test     r14d, r14d
-       jne      SHORT G_M62180_IG18
-						;; size=5 bbWeight=2.56 PerfScore 3.20
+       xor      r14d, r14d
+       jmp      SHORT G_M62180_IG07
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M62180_IG16:
-       mov      rdi, gword ptr [rdi+0x10]
-       cmp      rdi, gword ptr [rsi+0x08]
-       je       SHORT G_M62180_IG21
-       jmp      SHORT G_M62180_IG10
-						;; size=12 bbWeight=2.55 PerfScore 20.41
+       test     r14d, r14d
+       jne      SHORT G_M62180_IG23
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M62180_IG17:
-       mov      r14d, 1
-       jmp      SHORT G_M62180_IG15
-						;; size=8 bbWeight=0.01 PerfScore 0.02
-G_M62180_IG18:
-       mov      rax, rdi
-						;; size=3 bbWeight=1 PerfScore 0.25
-G_M62180_IG19:
-       add      rsp, 48
-       pop      rbx
-       pop      rbp
-       pop      rsi
-       pop      rdi
-       pop      r14
-       ret      
-						;; size=11 bbWeight=1 PerfScore 3.75
-G_M62180_IG20:
-       cmp      gword ptr [rdi+0x20], 0
-       je       SHORT G_M62180_IG18
        mov      rdi, gword ptr [rdi+0x10]
        cmp      rdi, gword ptr [rsi+0x08]
-       jne      SHORT G_M62180_IG20
-						;; size=17 bbWeight=0 PerfScore 0.00
+       jne      G_M62180_IG04
+       jmp      SHORT G_M62180_IG26
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M62180_IG18:
+       mov      r14d, 1
+       jmp      SHORT G_M62180_IG14
+						;; size=8 bbWeight=0.01 PerfScore 0.02
+G_M62180_IG19:
+       xor      r14d, r14d
+       jmp      SHORT G_M62180_IG14
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M62180_IG20:
+       mov      rcx, rbp
+       mov      r8, rbx
+       mov      rax, qword ptr [rbp]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x20]<unknown method>
+       mov      r14d, eax
+						;; size=20 bbWeight=0 PerfScore 0.00
 G_M62180_IG21:
-       xor      rax, rax
-						;; size=2 bbWeight=0 PerfScore 0.00
+       test     r14d, r14d
+       jne      SHORT G_M62180_IG23
+						;; size=5 bbWeight=0 PerfScore 0.00
 G_M62180_IG22:
+       mov      rdi, gword ptr [rdi+0x10]
+       cmp      rdi, gword ptr [rsi+0x08]
+       jne      G_M62180_IG09
+       jmp      SHORT G_M62180_IG26
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M62180_IG23:
+       mov      rax, rdi
+						;; size=3 bbWeight=0 PerfScore 0.00
+G_M62180_IG24:
        add      rsp, 48
        pop      rbx
        pop      rbp
@@ -535,24 +538,26 @@ G_M62180_IG22:
        pop      r14
        ret      
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M62180_IG23:
-       xor      r14d, r14d
-       jmp      G_M62180_IG07
-						;; size=8 bbWeight=0 PerfScore 0.00
-G_M62180_IG24:
-       xor      r14d, r14d
-       jmp      SHORT G_M62180_IG15
-						;; size=5 bbWeight=0 PerfScore 0.00
 G_M62180_IG25:
-       mov      rcx, rbp
-       mov      r8, rbx
-       mov      rax, qword ptr [rbp]
-       mov      rax, qword ptr [rax+0x40]
-       call     [rax+0x20]<unknown method>
-       mov      r14d, eax
-       jmp      SHORT G_M62180_IG15
-						;; size=22 bbWeight=0 PerfScore 0.00
+       cmp      gword ptr [rdi+0x20], 0
+       je       SHORT G_M62180_IG23
+       mov      rdi, gword ptr [rdi+0x10]
+       cmp      rdi, gword ptr [rsi+0x08]
+       jne      SHORT G_M62180_IG25
+						;; size=17 bbWeight=0 PerfScore 0.00
+G_M62180_IG26:
+       xor      rax, rax
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M62180_IG27:
+       add      rsp, 48
+       pop      rbx
+       pop      rbp
+       pop      rsi
+       pop      rdi
+       pop      r14
+       ret      
+						;; size=11 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 381, prolog size 21, PerfScore 5125.06, instruction count 112, allocated bytes for code 381 (MethodHash=00b80d1b) for method System.Collections.Generic.LinkedList`1[System.__Canon]:Find(System.__Canon):System.Collections.Generic.LinkedListNode`1[System.__Canon]:this (Tier1)
+; Total bytes of code 384, prolog size 21, PerfScore 3241.70, instruction count 113, allocated bytes for code 384 (MethodHash=00b80d1b) for method System.Collections.Generic.LinkedList`1[System.__Canon]:Find(System.__Canon):System.Collections.Generic.LinkedListNode`1[System.__Canon]:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.ElementAt(input: IEnumerable)``

Hot functions:

- (70.97%) ``Enumerable.TryGetElement`` (Tier-1)
  - **Has diffs**
- (4.39%) ``Enumerable.ElementAt`` (Tier-1)
  - No diffs
- (3.47%) ``SZArrayHelper.GetEnumerator`` (Tier-1)
  - No diffs
- (2.20%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.TryGetElement(class System.Collections.Generic.IEnumerable`1<!!0>,int32,!!0&)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 287104
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 271168
 ; 3 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T06] (  5,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 arg1         [V01,T02] (  7,152.86)     int  ->  rbx        
-;  V02 arg2         [V02,T09] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
-;  V03 loc0         [V03,T00] ( 18,309.46)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;* V04 loc1         [V04,T13] (  0,  0   )   ubyte  ->  zero-ref   
+;  V00 arg0         [V00,T05] (  5,  4   )     ref  ->  rcx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 arg1         [V01,T01] (  9,152.97)     int  ->  rbx        
+;  V02 arg2         [V02,T08] (  4,  3   )   byref  ->  [rbp+0x20]  EH-live single-def
+;  V03 loc0         [V03,T00] ( 24,210.14)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;* V04 loc1         [V04,T14] (  0,  0   )   ubyte  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V06 tmp1         [V06,T11] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
 ;* V07 tmp2         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;  V08 tmp3         [V08,T12] (  3,  2   )     int  ->  r14         "guarded devirt return temp"
 ;* V09 tmp4         [V09    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V10 tmp5         [V10,T01] (  2,101.15)     int  ->  rax         "guarded devirt return temp"
+;  V10 tmp5         [V10,T04] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V11 tmp6         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V12 tmp7         [V12    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V13 tmp8         [V13,T03] (  3,151.73)     int  ->  rcx         "Inline stloc first use temp"
-;  V14 tmp9         [V14,T07] (  3,  6   )     ref  ->  rax         "arr expr"
-;  V15 tmp10        [V15,T08] (  3,  6   )     int  ->  rcx         "index expr"
-;  V16 PSPSym       [V16,T14] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
-;  V17 cse0         [V17,T04] (  3,151.73)     int  ->  r11         "CSE #03: aggressive"
-;  V18 cse1         [V18,T10] (  4,  3   )     int  ->  rcx         "CSE #04: aggressive"
-;  V19 cse2         [V19,T05] (  6, 53.58)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
+;  V13 tmp8         [V13,T02] (  6,151.97)     int  ->  rdx         "Inline stloc first use temp"
+;  V14 tmp9         [V14,T06] (  3,  6   )     ref  ->  rax         "arr expr"
+;  V15 tmp10        [V15,T07] (  3,  6   )     int  ->  rcx         "index expr"
+;  V16 PSPSym       [V16,T15] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V17 cse0         [V17,T03] (  3,150.45)     int  ->  rax         "CSE #03: aggressive"
+;  V18 cse1         [V18,T10] (  4,  3   )     int  ->  rcx         "CSE #05: aggressive"
+;  V19 cse2         [V19,T13] (  3,  1.52)     int  ->  rcx         "CSE #04: moderate"
+;  V20 cse3         [V20,T09] (  8,  4.51)    long  ->  rdi         hoist multi-def "CSE #02: aggressive"
 ;
 ; Lcl frame size = 48
 
@@ -422,10 +423,10 @@ G_M33330_IG01:
 						;; size=25 bbWeight=1 PerfScore 8.00
 G_M33330_IG02:
        test     ebx, ebx
-       jl       G_M33330_IG22
+       jl       G_M33330_IG27
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M33330_IG20
+       jne      G_M33330_IG25
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
@@ -435,86 +436,114 @@ G_M33330_IG03:
        mov      gword ptr [rbp-0x28], rsi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M33330_IG04:
-       cmp      dword ptr [rsi], esi
+       test     rsi, rsi
+       je       SHORT G_M33330_IG09
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
-       jmp      SHORT G_M33330_IG07
-						;; size=14 bbWeight=1 PerfScore 5.25
-G_M33330_IG05:
-       test     ebx, ebx
-       je       SHORT G_M33330_IG10
-						;; size=4 bbWeight=0.13 PerfScore 0.16
-G_M33330_IG06:
-       dec      ebx
-						;; size=2 bbWeight=49.58 PerfScore 12.39
-G_M33330_IG07:
        cmp      qword ptr [rsi], rdi
        jne      SHORT G_M33330_IG09
-       mov      ecx, dword ptr [rsi+0x08]
-       inc      ecx
-       mov      r11d, dword ptr [rsi+0x0C]
-       cmp      ecx, r11d
-       jae      SHORT G_M33330_IG08
-       mov      dword ptr [rsi+0x08], ecx
-       jmp      SHORT G_M33330_IG05
-						;; size=24 bbWeight=50.58 PerfScore 632.21
-G_M33330_IG08:
-       mov      dword ptr [rsi+0x08], r11d
-       jmp      SHORT G_M33330_IG15
-						;; size=6 bbWeight=50.58 PerfScore 151.73
-G_M33330_IG09:
-       mov      rcx, rsi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       je       SHORT G_M33330_IG15
+       jmp      SHORT G_M33330_IG07
+       align    [0 bytes for IG05]
+						;; size=22 bbWeight=1 PerfScore 7.50
+G_M33330_IG05:
        test     ebx, ebx
-       jne      SHORT G_M33330_IG06
-						;; size=24 bbWeight=50.58 PerfScore 303.46
+       je       SHORT G_M33330_IG13
+						;; size=4 bbWeight=50.15 PerfScore 62.69
+G_M33330_IG06:
+       dec      ebx
+						;; size=2 bbWeight=49.16 PerfScore 12.29
+G_M33330_IG07:
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rsi+0x0C]
+       cmp      edx, eax
+       jae      SHORT G_M33330_IG08
+       mov      dword ptr [rsi+0x08], edx
+       jmp      SHORT G_M33330_IG05
+						;; size=17 bbWeight=50.15 PerfScore 426.29
+G_M33330_IG08:
+       mov      dword ptr [rsi+0x08], eax
+       jmp      G_M33330_IG20
+						;; size=8 bbWeight=50.15 PerfScore 150.45
+G_M33330_IG09:
+       cmp      dword ptr [rsi], esi
+       mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
+       jmp      SHORT G_M33330_IG12
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M33330_IG10:
+       test     ebx, ebx
+       je       SHORT G_M33330_IG13
+						;; size=4 bbWeight=0.51 PerfScore 0.63
+G_M33330_IG11:
+       dec      ebx
+						;; size=2 bbWeight=0.50 PerfScore 0.12
+G_M33330_IG12:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M33330_IG13
+       jne      SHORT G_M33330_IG16
+       mov      edx, dword ptr [rsi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rsi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M33330_IG15
+       mov      dword ptr [rsi+0x08], edx
+       jmp      SHORT G_M33330_IG10
+						;; size=22 bbWeight=0.51 PerfScore 6.33
+G_M33330_IG13:
+       cmp      qword ptr [rsi], rdi
+       jne      SHORT G_M33330_IG19
        mov      ecx, dword ptr [rsi+0x08]
        cmp      ecx, dword ptr [rsi+0x0C]
-       jae      SHORT G_M33330_IG14
+       jae      SHORT G_M33330_IG17
        mov      rax, gword ptr [rsi+0x10]
        cmp      ecx, dword ptr [rax+0x08]
-       jae      SHORT G_M33330_IG12
+       jae      SHORT G_M33330_IG18
        mov      r14d, dword ptr [rax+4*rcx+0x10]
 						;; size=27 bbWeight=1 PerfScore 18.00
-G_M33330_IG11:
+G_M33330_IG14:
        mov      r8, bword ptr [rbp+0x20]
        mov      dword ptr [r8], r14d
-       jmp      SHORT G_M33330_IG17
+       jmp      SHORT G_M33330_IG22
 						;; size=9 bbWeight=1 PerfScore 4.00
-G_M33330_IG12:
+G_M33330_IG15:
+       mov      dword ptr [rsi+0x08], ecx
+       jmp      SHORT G_M33330_IG20
+						;; size=5 bbWeight=0.51 PerfScore 1.52
+G_M33330_IG16:
+       mov      rcx, rsi
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      SHORT G_M33330_IG10
+       jmp      SHORT G_M33330_IG20
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M33330_IG17:
+       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
+       int3     
+						;; size=7 bbWeight=0 PerfScore 0.00
+G_M33330_IG18:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M33330_IG13:
+G_M33330_IG19:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      r14d, eax
-       jmp      SHORT G_M33330_IG11
+       jmp      SHORT G_M33330_IG14
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M33330_IG14:
-       call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
-       int3     
-						;; size=7 bbWeight=0 PerfScore 0.00
-G_M33330_IG15:
+G_M33330_IG20:
        mov      rcx, rsp
-       call     G_M33330_IG24
+       call     G_M33330_IG29
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M33330_IG16:
-       jmp      SHORT G_M33330_IG22
+G_M33330_IG21:
+       jmp      SHORT G_M33330_IG27
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M33330_IG17:
+G_M33330_IG22:
        cmp      qword ptr [rsi], rdi
-       jne      SHORT G_M33330_IG21
-						;; size=5 bbWeight=1.00 PerfScore 3.99
-G_M33330_IG18:
+       jne      SHORT G_M33330_IG26
+						;; size=5 bbWeight=1.00 PerfScore 4.00
+G_M33330_IG23:
        mov      eax, 1
 						;; size=5 bbWeight=1 PerfScore 0.25
-G_M33330_IG19:
+G_M33330_IG24:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -523,24 +552,24 @@ G_M33330_IG19:
        pop      rbp
        ret      
 						;; size=11 bbWeight=1 PerfScore 3.75
-G_M33330_IG20:
+G_M33330_IG25:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M33330_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M33330_IG21:
+G_M33330_IG26:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M33330_IG18
+       jmp      SHORT G_M33330_IG23
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M33330_IG22:
+G_M33330_IG27:
        xor      eax, eax
        mov      r8, bword ptr [rbp+0x20]
        mov      dword ptr [r8], eax
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M33330_IG23:
+G_M33330_IG28:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -549,7 +578,7 @@ G_M33330_IG23:
        pop      rbp
        ret      
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M33330_IG24:
+G_M33330_IG29:
        push     rbp
        push     r14
        push     rdi
@@ -560,21 +589,21 @@ G_M33330_IG24:
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x50]
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M33330_IG25:
+G_M33330_IG30:
        cmp      gword ptr [rbp-0x28], 0
-       je       SHORT G_M33330_IG26
+       je       SHORT G_M33330_IG31
        mov      rdi, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        mov      rsi, gword ptr [rbp-0x28]
        cmp      qword ptr [rsi], rdi
-       je       SHORT G_M33330_IG26
+       je       SHORT G_M33330_IG31
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M33330_IG26:
+G_M33330_IG31:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M33330_IG27:
+G_M33330_IG32:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -584,6 +613,6 @@ G_M33330_IG27:
        ret      
 						;; size=11 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 386, prolog size 25, PerfScore 1155.19, instruction count 121, allocated bytes for code 386 (MethodHash=3df47dcd) for method System.Linq.Enumerable:TryGetElement[int](System.Collections.Generic.IEnumerable`1[int],int,byref):ubyte (Tier1)
+; Total bytes of code 434, prolog size 25, PerfScore 717.82, instruction count 139, allocated bytes for code 434 (MethodHash=3df47dcd) for method System.Linq.Enumerable:TryGetElement[int](System.Collections.Generic.IEnumerable`1[int],int,byref):ubyte (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.ElementAt(input: IList)``

Hot functions:

- (55.06%) ``Enumerable.ElementAt`` (Tier-1)
  - No diffs
- (18.36%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (9.21%) ``Perf_Enumerable.ElementAt`` (Tier-1)
  - No diffs

# ``System.Linq.Tests.Perf_Enumerable.Count(input: IEnumerable)``

Hot functions:

- (81.21%) ``Enumerable.Count`` (Tier-1)
  - **Has diffs**
- (2.14%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (2.06%) ``SZArrayHelper.GetEnumerator`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]Enumerable.Count(class System.Collections.Generic.IEnumerable`1<!!0>)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 264256
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 140416
 ; 2 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 arg0         [V00,T06] ( 12,  8   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
-;  V01 loc0         [V01,T10] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
-;  V02 loc1         [V02,T11] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
-;  V03 loc2         [V03,T12] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
-;  V04 loc3         [V04,T04] (  4,200.87)     int  ->  rsi        
-;  V05 loc4         [V05,T00] ( 12,602.60)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V00 arg0         [V00,T05] ( 12,  8   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[int]>
+;  V01 loc0         [V01,T11] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
+;  V02 loc1         [V02,T12] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
+;  V03 loc2         [V03,T13] (  5,  2   )     ref  ->  rcx         class-hnd single-def <<unknown class>>
+;  V04 loc3         [V04,T03] (  6,195.52)     int  ->  rsi        
+;  V05 loc4         [V05,T00] ( 19,394.04)     ref  ->  [rbp-0x28]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T13] (  3,  2   )     ref  ->  rdi         "guarded devirt return temp"
+;  V07 tmp1         [V07,T14] (  3,  2   )     ref  ->  rdi         "guarded devirt return temp"
 ;* V08 tmp2         [V08    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
-;  V09 tmp3         [V09,T01] (  2,200.87)     int  ->  rax         "guarded devirt return temp"
+;  V09 tmp3         [V09,T04] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V10 tmp4         [V10    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
 ;* V11 tmp5         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
-;  V12 tmp6         [V12,T03] (  3,300.30)     int  ->  rcx         "Inline stloc first use temp"
-;  V13 PSPSym       [V13,T14] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
-;  V14 cse0         [V14,T02] (  3,301.30)     int  ->  r11         "CSE #03: aggressive"
-;  V15 cse1         [V15,T05] (  4,101.43)    long  ->  r14         hoist multi-def "CSE #02: aggressive"
-;  V16 rat0         [V16,T07] (  6,  8   )     ref  ->  rcx         "replacement local"
-;  V17 rat1         [V17,T08] (  6,  8   )     ref  ->  rcx         "replacement local"
-;  V18 rat2         [V18,T09] (  6,  8   )     ref  ->  rcx         "replacement local"
+;  V12 tmp6         [V12,T01] (  6,292.31)     int  ->  rdx         "Inline stloc first use temp"
+;  V13 PSPSym       [V13,T15] (  1,  1   )    long  ->  [rbp-0x30]  do-not-enreg[V] "PSPSym"
+;  V14 cse0         [V14,T02] (  3,290.34)     int  ->  rax         "CSE #03: aggressive"
+;  V15 cse1         [V15,T10] (  3,  2.93)     int  ->  rcx         "CSE #04: aggressive"
+;  V16 cse2         [V16,T09] (  7,  3.97)    long  ->  r14         hoist multi-def "CSE #02: aggressive"
+;  V17 rat0         [V17,T06] (  6,  8   )     ref  ->  rcx         "replacement local"
+;  V18 rat1         [V18,T07] (  6,  8   )     ref  ->  rcx         "replacement local"
+;  V19 rat2         [V19,T08] (  6,  8   )     ref  ->  rcx         "replacement local"
 ;
 ; Lcl frame size = 48
 
@@ -1007,38 +1008,38 @@ G_M42867_IG01:
 						;; size=22 bbWeight=1 PerfScore 7.00
 G_M42867_IG02:
        test     rbx, rbx
-       je       G_M42867_IG17
+       je       G_M42867_IG22
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M42867_IG18
+       jne      G_M42867_IG23
        xor      rcx, rcx
        test     rcx, rcx
-       jne      G_M42867_IG19
+       jne      G_M42867_IG24
 						;; size=42 bbWeight=1 PerfScore 7.25
 G_M42867_IG03:
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M42867_IG21
+       jne      G_M42867_IG26
        xor      rcx, rcx
        test     rcx, rcx
-       jne      G_M42867_IG22
+       jne      G_M42867_IG27
 						;; size=33 bbWeight=1 PerfScore 6.00
 G_M42867_IG04:
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M42867_IG24
+       jne      G_M42867_IG29
        xor      rcx, rcx
        test     rcx, rcx
-       jne      G_M42867_IG25
+       jne      G_M42867_IG30
 						;; size=33 bbWeight=1 PerfScore 6.00
 G_M42867_IG05:
        xor      esi, esi
        mov      rcx, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rbx], rcx
-       jne      G_M42867_IG27
+       jne      G_M42867_IG32
        mov      rcx, gword ptr [rbx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
@@ -1048,48 +1049,77 @@ G_M42867_IG06:
        mov      gword ptr [rbp-0x28], rdi
 						;; size=4 bbWeight=1 PerfScore 1.00
 G_M42867_IG07:
-       cmp      dword ptr [rdi], edi
+       test     rdi, rdi
+       je       SHORT G_M42867_IG12
        mov      r14, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rdi], r14
+       jne      SHORT G_M42867_IG12
        jmp      SHORT G_M42867_IG09
-						;; size=14 bbWeight=1 PerfScore 5.25
+       align    [0 bytes for IG08]
+						;; size=22 bbWeight=1 PerfScore 7.50
 G_M42867_IG08:
        add      esi, 1
        jo       SHORT G_M42867_IG11
-						;; size=5 bbWeight=99.43 PerfScore 124.29
+						;; size=5 bbWeight=95.79 PerfScore 119.74
 G_M42867_IG09:
-       cmp      qword ptr [rdi], r14
-       jne      SHORT G_M42867_IG13
-       mov      ecx, dword ptr [rdi+0x08]
-       inc      ecx
-       mov      r11d, dword ptr [rdi+0x0C]
-       cmp      ecx, r11d
-       jae      SHORT G_M42867_IG12
-						;; size=19 bbWeight=100.43 PerfScore 954.12
+       mov      edx, dword ptr [rdi+0x08]
+       inc      edx
+       mov      eax, dword ptr [rdi+0x0C]
+       cmp      edx, eax
+       jae      SHORT G_M42867_IG14
+						;; size=12 bbWeight=96.78 PerfScore 532.29
 G_M42867_IG10:
-       mov      dword ptr [rdi+0x08], ecx
+       mov      dword ptr [rdi+0x08], edx
        jmp      SHORT G_M42867_IG08
-						;; size=5 bbWeight=99.43 PerfScore 298.29
+						;; size=5 bbWeight=95.83 PerfScore 287.48
 G_M42867_IG11:
        call     CORINFO_HELP_OVERFLOW
 						;; size=5 bbWeight=0 PerfScore 0.00
 G_M42867_IG12:
-       mov      dword ptr [rdi+0x08], r11d
-       jmp      SHORT G_M42867_IG15
-						;; size=6 bbWeight=100.43 PerfScore 301.30
+       cmp      dword ptr [rdi], edi
+       mov      r14, 0xD1FFAB1E      ; <unknown class>
+       jmp      SHORT G_M42867_IG16
+						;; size=14 bbWeight=0 PerfScore 0.00
 G_M42867_IG13:
        mov      rcx, rdi
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       mov      r11, 0xD1FFAB1E      ; function address
        call     [r11]<unknown method>
        test     eax, eax
-       jne      SHORT G_M42867_IG08
-						;; size=20 bbWeight=100.43 PerfScore 477.06
+       jne      SHORT G_M42867_IG15
+       jmp      SHORT G_M42867_IG19
+						;; size=22 bbWeight=0 PerfScore 0.00
 G_M42867_IG14:
-       jmp      G_M42867_IG28
-						;; size=5 bbWeight=1.00 PerfScore 1.99
+       mov      dword ptr [rdi+0x08], eax
+       jmp      SHORT G_M42867_IG19
+						;; size=5 bbWeight=96.78 PerfScore 290.34
 G_M42867_IG15:
+       add      esi, 1
+       jo       SHORT G_M42867_IG11
+						;; size=5 bbWeight=0.97 PerfScore 1.21
+G_M42867_IG16:
+       cmp      qword ptr [rdi], r14
+       jne      SHORT G_M42867_IG13
+       mov      edx, dword ptr [rdi+0x08]
+       inc      edx
+       mov      ecx, dword ptr [rdi+0x0C]
+       cmp      edx, ecx
+       jae      SHORT G_M42867_IG18
+						;; size=17 bbWeight=0.98 PerfScore 9.29
+G_M42867_IG17:
+       mov      dword ptr [rdi+0x08], edx
+       jmp      SHORT G_M42867_IG15
+						;; size=5 bbWeight=0.97 PerfScore 2.90
+G_M42867_IG18:
+       mov      dword ptr [rdi+0x08], ecx
+						;; size=3 bbWeight=0.98 PerfScore 0.98
+G_M42867_IG19:
+       cmp      qword ptr [rdi], r14
+       jne      G_M42867_IG33
+						;; size=9 bbWeight=0.99 PerfScore 3.97
+G_M42867_IG20:
        mov      eax, esi
 						;; size=2 bbWeight=1 PerfScore 0.25
-G_M42867_IG16:
+G_M42867_IG21:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -1098,12 +1128,12 @@ G_M42867_IG16:
        pop      rbp
        ret      
 						;; size=11 bbWeight=1 PerfScore 3.75
-G_M42867_IG17:
+G_M42867_IG22:
        mov      ecx, 17
        call     [System.Linq.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M42867_IG18:
+G_M42867_IG23:
        mov      rdx, rbx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFINTERFACE
@@ -1111,10 +1141,10 @@ G_M42867_IG18:
        test     rcx, rcx
        je       G_M42867_IG03
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M42867_IG19:
+G_M42867_IG24:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M42867_IG20:
+G_M42867_IG25:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -1123,7 +1153,7 @@ G_M42867_IG20:
        pop      rbp
        tail.jmp [r11]<unknown method>
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M42867_IG21:
+G_M42867_IG26:
        mov      rdx, rbx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFINTERFACE
@@ -1131,11 +1161,11 @@ G_M42867_IG21:
        test     rcx, rcx
        je       G_M42867_IG04
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M42867_IG22:
+G_M42867_IG27:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        xor      edx, edx
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M42867_IG23:
+G_M42867_IG28:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -1144,7 +1174,7 @@ G_M42867_IG23:
        pop      rbp
        tail.jmp [r11]<unknown method>
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M42867_IG24:
+G_M42867_IG29:
        mov      rdx, rbx
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_ISINSTANCEOFINTERFACE
@@ -1152,10 +1182,10 @@ G_M42867_IG24:
        test     rcx, rcx
        je       G_M42867_IG05
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M42867_IG25:
+G_M42867_IG30:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M42867_IG26:
+G_M42867_IG31:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -1164,20 +1194,20 @@ G_M42867_IG26:
        pop      rbp
        tail.jmp [r11]<unknown method>
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M42867_IG27:
+G_M42867_IG32:
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rdi, rax
        jmp      G_M42867_IG06
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M42867_IG28:
+G_M42867_IG33:
        mov      rcx, rdi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      G_M42867_IG15
+       jmp      G_M42867_IG20
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M42867_IG29:
+G_M42867_IG34:
        push     rbp
        push     r14
        push     rdi
@@ -1188,21 +1218,21 @@ G_M42867_IG29:
        mov      qword ptr [rsp+0x20], rbp
        lea      rbp, [rbp+0x50]
 						;; size=23 bbWeight=0 PerfScore 0.00
-G_M42867_IG30:
+G_M42867_IG35:
        cmp      gword ptr [rbp-0x28], 0
-       je       SHORT G_M42867_IG31
+       je       SHORT G_M42867_IG36
        mov      r14, 0xD1FFAB1E      ; <unknown class>
        mov      rdi, gword ptr [rbp-0x28]
        cmp      qword ptr [rdi], r14
-       je       SHORT G_M42867_IG31
+       je       SHORT G_M42867_IG36
        mov      rcx, rdi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M42867_IG31:
+G_M42867_IG36:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M42867_IG32:
+G_M42867_IG37:
        add      rsp, 48
        pop      rbx
        pop      rsi
@@ -1212,7 +1242,7 @@ G_M42867_IG32:
        ret      
 						;; size=11 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 562, prolog size 22, PerfScore 2203.55, instruction count 153, allocated bytes for code 562 (MethodHash=f484588c) for method System.Linq.Enumerable:Count[int](System.Collections.Generic.IEnumerable`1[int]):int (Tier1)
+; Total bytes of code 612, prolog size 22, PerfScore 1296.95, instruction count 172, allocated bytes for code 612 (MethodHash=f484588c) for method System.Linq.Enumerable:Count[int](System.Collections.Generic.IEnumerable`1[int]):int (Tier1)
 ; ============================================================
 
 ; Assembly listing for method System.Linq.Enumerable:TryGetNonEnumeratedCount[int](System.Collections.Generic.IEnumerable`1[int],byref):ubyte (Tier0)


```

</details>

# ``System.Collections.ContainsKeyTrue<Int32, Int32>.ImmutableDictionary(Size: 512)``

Hot functions:

- (99.23%) ``System.Collections.ContainsKeyTrue`2.ImmutableDictionary`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.ContainsKeyTrue`2[System.Int32,System.Int32].ImmutableDictionary()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 6630
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 5618
 ; 3 inlinees with PGO data; 19 single block inlinees; 3 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T20] (  4,    4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsKeyTrue`2[int,int]>
-;  V01 loc0         [V01,T21] (  4,    2   )   ubyte  ->  rbx        
-;  V02 loc1         [V02,T12] (  3, 1001.37)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Immutable.ImmutableDictionary`2[int,int]>
-;  V03 loc2         [V03,T17] (  4,  502.18)     ref  ->  rdi         class-hnd single-def <<unknown class>>
-;  V04 loc3         [V04,T18] (  5,  501.18)     int  ->  rbp        
+;  V00 this         [V00,T19] (  4,    4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsKeyTrue`2[int,int]>
+;  V01 loc0         [V01,T20] (  4,    2   )   ubyte  ->  rbx        
+;  V02 loc1         [V02,T11] (  3, 1000.03)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Immutable.ImmutableDictionary`2[int,int]>
+;  V03 loc2         [V03,T16] (  4,  501.51)     ref  ->  rdi         class-hnd single-def <<unknown class>>
+;* V04 loc3         [V04,T21] (  0,    0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,    1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T04] (  6, 4001.48)     int  ->  r14         "Inlining Arg"
+;  V06 tmp1         [V06,T04] (  6, 2997.09)     int  ->  r14         "Inlining Arg"
 ;* V07 tmp2         [V07    ] (  0,    0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Collections.Immutable.ImmutableDictionary`2+MutationInput[int,int]>
 ;* V08 tmp3         [V08    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableDictionary`2+MutationInput[int,int]>
 ;  V09 tmp4         [V09,T23] (  3,    0   )   ubyte  ->  r15         "Inline return value spill temp"
 ;* V10 tmp5         [V10    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.Immutable.ImmutableDictionary`2+MutationInput[int,int]>
-;  V11 tmp6         [V11,T07] (  3, 2000.74)     ref  ->  rcx         class-hnd "spilling ret_expr" <System.Collections.Generic.IEqualityComparer`1[int]>
-;  V12 tmp7         [V12,T03] (  3, 8187.57)     int  ->  rcx         "Inline stloc first use temp"
+;  V11 tmp6         [V11,T06] (  3, 1998.06)     ref  ->  rcx         class-hnd "spilling ret_expr" <System.Collections.Generic.IEqualityComparer`1[int]>
+;  V12 tmp7         [V12,T03] (  3, 8210.46)     int  ->  rax         "Inline stloc first use temp"
 ;* V13 tmp8         [V13    ] (  0,    0   )  struct (16) zero-ref    do-not-enreg[SF] ld-addr-op "Inline ldloca(s) first use temp" <System.Collections.Immutable.ImmutableDictionary`2+HashBucket[int,int]>
 ;* V14 tmp9         [V14    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inline ldloca(s) first use temp"
-;  V15 tmp10        [V15,T14] (  3, 1000.37)     int  ->  rcx         "guarded devirt return temp"
+;  V15 tmp10        [V15,T14] (  3,  999.03)     int  ->  rax         "guarded devirt return temp"
 ;* V16 tmp11        [V16    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[int]>
 ;* V17 tmp12        [V17    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableDictionary`2+Comparers[int,int]>
 ;* V18 tmp13        [V18    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
-;* V19 tmp14        [V19,T19] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;* V19 tmp14        [V19,T18] (  0,    0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V20 tmp15        [V20    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[int,int]]>
-;  V21 tmp16        [V21,T00] (  7,14552.04)     ref  ->  r15         class-hnd "Inline stloc first use temp" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[int,int]]>
+;  V21 tmp16        [V21,T00] (  7,14582.93)     ref  ->  r15         class-hnd "Inline stloc first use temp" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[int,int]]>
 ;  V22 tmp17        [V22,T24] (  3,    0   )   ubyte  ->  r15         "Inline return value spill temp"
 ;* V23 tmp18        [V23    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableDictionary`2+Comparers[int,int]>
-;  V24 tmp19        [V24,T05] (  3, 3001.11)     ref  ->  rcx         class-hnd "impAppendStmt" <System.Collections.Generic.IEqualityComparer`1[int]>
+;  V24 tmp19        [V24,T07] (  3, 1998.06)     ref  ->  rcx         class-hnd "impAppendStmt" <System.Collections.Generic.IEqualityComparer`1[int]>
 ;* V25 tmp20        [V25    ] (  0,    0   )     int  ->  zero-ref    "spilling ret_expr"
 ;* V26 tmp21        [V26    ] (  0,    0   )  struct ( 8) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Collections.Generic.KeyValuePair`2[int,int]>
 ;* V27 tmp22        [V27    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inline ldloca(s) first use temp"
 ;* V28 tmp23        [V28    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.Collections.Immutable.ImmutableList`1+Node[System.Collections.Generic.KeyValuePair`2[int,int]]>
 ;* V29 tmp24        [V29    ] (  0,    0   )  struct ( 8) zero-ref    "impAppendStmt" <System.Collections.Generic.KeyValuePair`2[int,int]>
-;  V30 tmp25        [V30,T25] (  3,    0   )     int  ->  registers   "Inline stloc first use temp"
-;  V31 tmp26        [V31,T16] (  2, 1000.37)     int  ->  rax         "guarded devirt return temp"
+;  V30 tmp25        [V30,T25] (  3,    0   )     int  ->  rax         "Inline stloc first use temp"
+;  V31 tmp26        [V31,T27] (  2,    0   )     int  ->  rax         "guarded devirt return temp"
 ;* V32 tmp27        [V32    ] (  0,    0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericEqualityComparer`1[int]>
 ;* V33 tmp28        [V33    ] (  0,    0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
 ;* V34 tmp29        [V34    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V35 tmp30        [V35    ] (  0,    0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V36 tmp31        [V36    ] (  0,    0   )     ref  ->  zero-ref    "field V07._root (fldOffset=0x0)" P-INDEP
 ;* V37 tmp32        [V37    ] (  0,    0   )     ref  ->  zero-ref    "field V07._comparers (fldOffset=0x8)" P-INDEP
-;  V38 tmp33        [V38,T10] (  3, 1500.55)     ref  ->  r15         "field V08._root (fldOffset=0x0)" P-INDEP
-;  V39 tmp34        [V39,T15] (  2, 1000.37)     ref  ->  r13         "field V08._comparers (fldOffset=0x8)" P-INDEP
+;  V38 tmp33        [V38,T09] (  3, 1498.54)     ref  ->  r15         "field V08._root (fldOffset=0x0)" P-INDEP
+;  V39 tmp34        [V39,T15] (  2,  999.03)     ref  ->  r13         "field V08._comparers (fldOffset=0x8)" P-INDEP
 ;* V40 tmp35        [V40    ] (  0,    0   )     ref  ->  zero-ref    "field V10._root (fldOffset=0x0)" P-INDEP
-;  V41 tmp36        [V41,T08] (  4, 1500.55)     ref  ->  r13         "field V10._comparers (fldOffset=0x8)" P-INDEP
-;  V42 tmp37        [V42,T27] (  2,    0   )     int  ->  r14         "field V26.key (fldOffset=0x0)" P-INDEP
-;* V43 tmp38        [V43,T28] (  0,    0   )     int  ->  zero-ref    "field V26.value (fldOffset=0x4)" P-INDEP
+;  V41 tmp36        [V41,T08] (  4, 1498.54)     ref  ->  r13         "field V10._comparers (fldOffset=0x8)" P-INDEP
+;  V42 tmp37        [V42,T28] (  2,    0   )     int  ->  r14         "field V26.key (fldOffset=0x0)" P-INDEP
+;* V43 tmp38        [V43,T29] (  0,    0   )     int  ->  zero-ref    "field V26.value (fldOffset=0x4)" P-INDEP
 ;* V44 tmp39        [V44    ] (  0,    0   )     int  ->  zero-ref    "field V29.key (fldOffset=0x0)" P-INDEP
 ;* V45 tmp40        [V45    ] (  0,    0   )     int  ->  zero-ref    "field V29.value (fldOffset=0x4)" P-INDEP
-;  V46 tmp41        [V46,T13] (  5, 1000.37)     ref  ->  [rsp+0x28]  spill-single-def "V13.[000..008)"
-;  V47 tmp42        [V47,T09] (  3, 1500.55)     int  ->  rdx         "V13.[008..012)"
-;  V48 tmp43        [V48,T06] (  3, 3001.11)   byref  ->  r15         "Spilling address for field-by-field copy"
+;  V46 tmp41        [V46,T12] (  5,  999.03)     ref  ->  [rsp+0x28]  spill-single-def "V13.[000..008)"
+;  V47 tmp42        [V47,T13] (  3,  999.03)     int  ->  rdx         "V13.[008..012)"
+;  V48 tmp43        [V48,T05] (  3, 2997.09)   byref  ->  r15         "Spilling address for field-by-field copy"
 ;  V49 tmp44        [V49,T26] (  3,    0   )  struct ( 8) [rsp+0x30]  do-not-enreg[SF] "by-value struct argument" <System.Collections.Generic.KeyValuePair`2[int,int]>
 ;  V50 tmp45        [V50,T22] (  2,    0   )   byref  ->  rax         "Field obj"
-;  V51 cse0         [V51,T01] (  3,11781.17)     int  ->  rdx         "CSE #01: aggressive"
-;  V52 cse1         [V52,T02] (  3,10010.67)     ref  ->   r8         "CSE #02: aggressive"
-;  V53 cse2         [V53,T11] (  3, 1500.55)    long  ->  r12         "CSE #03: aggressive"
+;  V51 cse0         [V51,T01] (  3,11816.18)     int  ->  rdx         "CSE #01: aggressive"
+;  V52 cse1         [V52,T02] (  3,10048.46)     ref  ->  rcx         "CSE #02: aggressive"
+;  V53 cse2         [V53,T10] (  3, 1498.54)    long  ->  r12         "CSE #03: aggressive"
+;  V54 rat0         [V54,T17] (  5,  500.51)    long  ->  rbp         "Widened IV V04"
 ;
 ; Lcl frame size = 56
 
@@ -278,63 +279,73 @@ G_M24184_IG02:
        jle      G_M24184_IG16
 						;; size=22 bbWeight=1 PerfScore 8.50
 G_M24184_IG03:
-       mov      ecx, ebp
-       mov      r14d, dword ptr [rdi+4*rcx+0x10]
+       mov      r14d, dword ptr [rdi+4*rbp+0x10]
        mov      r15, gword ptr [rsi+0x08]
        mov      r13, gword ptr [rsi+0x10]
        mov      rcx, gword ptr [r13+0x08]
        mov      r12, 0xD1FFAB1E      ; System.Collections.Generic.GenericEqualityComparer`1[int]
        cmp      qword ptr [rcx], r12
        jne      G_M24184_IG18
-       mov      ecx, r14d
-						;; size=41 bbWeight=500.18 PerfScore 6377.35
+       mov      eax, r14d
+						;; size=39 bbWeight=499.51 PerfScore 6243.93
 G_M24184_IG04:
        cmp      byte  ptr [r15], r15b
-       align    [14 bytes for IG05]
-						;; size=17 bbWeight=500.18 PerfScore 1625.60
+       align    [0 bytes for IG05]
+						;; size=3 bbWeight=499.51 PerfScore 1498.54
 G_M24184_IG05:
-       mov      r8, gword ptr [r15+0x08]
-       test     r8, r8
-       je       SHORT G_M24184_IG14
+       mov      rcx, gword ptr [r15+0x08]
+       test     rcx, rcx
+       je       G_M24184_IG14
        mov      edx, dword ptr [r15+0x18]
-       cmp      ecx, edx
+       cmp      eax, edx
        je       SHORT G_M24184_IG09
-						;; size=17 bbWeight=4093.78 PerfScore 26609.60
+						;; size=21 bbWeight=4105.23 PerfScore 26684.01
 G_M24184_IG06:
-       cmp      ecx, edx
+       cmp      eax, edx
        jle      SHORT G_M24184_IG08
-						;; size=4 bbWeight=3593.60 PerfScore 4492.00
+						;; size=4 bbWeight=3605.72 PerfScore 4507.15
 G_M24184_IG07:
        mov      r15, gword ptr [r15+0x10]
        jmp      SHORT G_M24184_IG05
-						;; size=6 bbWeight=1770.50 PerfScore 7081.98
+						;; size=6 bbWeight=1767.72 PerfScore 7070.89
 G_M24184_IG08:
-       mov      r15, r8
+       mov      r15, rcx
        jmp      SHORT G_M24184_IG05
-						;; size=5 bbWeight=1823.10 PerfScore 4101.98
+						;; size=5 bbWeight=1837.99 PerfScore 4135.49
 G_M24184_IG09:
        add      r15, 32
-       mov      rax, gword ptr [r15]
-       mov      gword ptr [rsp+0x28], rax
+       mov      r8, gword ptr [r15]
+       mov      gword ptr [rsp+0x28], r8
        mov      edx, dword ptr [r15+0x08]
-       test     rax, rax
-       je       SHORT G_M24184_IG19
-						;; size=21 bbWeight=500.18 PerfScore 3251.20
+       test     r8, r8
+       je       G_M24184_IG19
+						;; size=25 bbWeight=499.51 PerfScore 3246.84
 G_M24184_IG10:
        mov      rcx, gword ptr [r13+0x08]
        cmp      qword ptr [rcx], r12
-       jne      SHORT G_M24184_IG11
+       jne      G_M24184_IG20
        cmp      edx, r14d
-       jne      SHORT G_M24184_IG20
-       jmp      SHORT G_M24184_IG12
-						;; size=16 bbWeight=500.18 PerfScore 4626.71
+       je       SHORT G_M24184_IG12
+						;; size=18 bbWeight=499.51 PerfScore 3621.48
 G_M24184_IG11:
-       mov      r8d, r14d
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
+       mov      dword ptr [rsp+0x30], r14d
+       xor      edx, edx
+       mov      dword ptr [rsp+0x34], edx
+       mov      gword ptr [rsp+0x20], r13
+       mov      rdx, qword ptr [rsp+0x30]
+       mov      r8, gword ptr [rsp+0x28]
+       mov      r9d, dword ptr [r8+0x18]
+       mov      rcx, r8
+       xor      r8d, r8d
+       call     [<unknown method>]
        test     eax, eax
-       je       SHORT G_M24184_IG20
-						;; size=20 bbWeight=500.18 PerfScore 2375.88
+       jl       SHORT G_M24184_IG19
+       mov      r8, gword ptr [rsp+0x28]
+       mov      rcx, r8
+       mov      edx, eax
+       call     [System.Collections.Immutable.ImmutableList`1+Node[System.Collections.Generic.KeyValuePair`2[int,int]]:ItemRef(int):byref:this]
+       cmp      byte  ptr [rax], al
+						;; size=64 bbWeight=0 PerfScore 0.00
 G_M24184_IG12:
        mov      r15d, 1
 						;; size=6 bbWeight=0 PerfScore 0.00
@@ -370,34 +381,21 @@ G_M24184_IG18:
        mov      edx, r14d
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       mov      ecx, eax
        jmp      G_M24184_IG04
-						;; size=23 bbWeight=0 PerfScore 0.00
+						;; size=21 bbWeight=0 PerfScore 0.00
 G_M24184_IG19:
        xor      r15d, r15d
        jmp      SHORT G_M24184_IG13
 						;; size=5 bbWeight=0 PerfScore 0.00
 G_M24184_IG20:
-       mov      dword ptr [rsp+0x30], r14d
-       xor      edx, edx
-       mov      dword ptr [rsp+0x34], edx
-       mov      gword ptr [rsp+0x20], r13
-       mov      rdx, qword ptr [rsp+0x30]
-       mov      rax, gword ptr [rsp+0x28]
-       mov      r9d, dword ptr [rax+0x18]
-       mov      rcx, rax
-       xor      r8d, r8d
-       call     [<unknown method>]
+       mov      r8d, r14d
+       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
+       call     [r11]<unknown method>
        test     eax, eax
-       jl       SHORT G_M24184_IG19
-       mov      edx, eax
-       mov      rax, gword ptr [rsp+0x28]
-       mov      rcx, rax
-       call     [System.Collections.Immutable.ImmutableList`1+Node[System.Collections.Generic.KeyValuePair`2[int,int]]:ItemRef(int):byref:this]
-       cmp      byte  ptr [rax], al
-       jmp      G_M24184_IG12
-						;; size=69 bbWeight=0 PerfScore 0.00
+       je       G_M24184_IG11
+       jmp      SHORT G_M24184_IG12
+						;; size=26 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 329, prolog size 16, PerfScore 60564.56, instruction count 99, allocated bytes for code 329 (MethodHash=b939a187) for method System.Collections.ContainsKeyTrue`2[int,int]:ImmutableDictionary():ubyte:this (Tier1)
+; Total bytes of code 322, prolog size 16, PerfScore 57030.58, instruction count 96, allocated bytes for code 322 (MethodHash=b939a187) for method System.Collections.ContainsKeyTrue`2[int,int]:ImmutableDictionary():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.ContainsKeyTrue<Int32, Int32>.Dictionary(Size: 512)``

Hot functions:

- (91.07%) ``System.Collections.Generic.Dictionary`2.FindValue`` (Tier-1)
  - No diffs
- (8.43%) ``System.Collections.ContainsKeyTrue`2.Dictionary`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.ContainsKeyTrue`2[System.Int32,System.Int32].Dictionary()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 85888
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 86928
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T06] (  4,   4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.ContainsKeyTrue`2[int,int]>
-;  V01 loc0         [V01,T02] (  4,1023.33)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T05] (  3, 512.66)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.Dictionary`2[int,int]>
-;  V03 loc2         [V03,T03] (  3, 512.66)     ref  ->  rdi         class-hnd single-def <<unknown class>>
-;  V04 loc3         [V04,T00] (  5,2043.66)     int  ->  rbp        
+;  V01 loc0         [V01,T02] (  4,1019.21)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T05] (  3, 510.61)     ref  ->  rsi         class-hnd single-def <System.Collections.Generic.Dictionary`2[int,int]>
+;  V03 loc2         [V03,T03] (  3, 510.61)     ref  ->  rdi         class-hnd single-def <<unknown class>>
+;* V04 loc3         [V04,T07] (  0,   0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T01] (  2,2042.66)     int  ->  rdx         "Inlining Arg"
-;  V07 cse0         [V07,T04] (  3, 512.66)     int  ->  r14         "CSE #01: aggressive"
+;  V06 tmp1         [V06,T01] (  2,2034.43)     int  ->  rdx         "Inlining Arg"
+;  V07 cse0         [V07,T04] (  3, 510.61)     int  ->  r14         "CSE #01: aggressive"
+;  V08 rat0         [V08,T00] (  5,2035.43)    long  ->  rbp         "Widened IV V04"
 ;
 ; Lcl frame size = 32
 
@@ -233,8 +234,7 @@ G_M10106_IG03:
        cmp      byte  ptr [rsi], sil
 						;; size=3 bbWeight=1.00 PerfScore 2.99
 G_M10106_IG04:
-       mov      ecx, ebp
-       mov      edx, dword ptr [rdi+4*rcx+0x10]
+       mov      edx, dword ptr [rdi+4*rbp+0x10]
        mov      rcx, rsi
        call     [<unknown method>]
        test     rax, rax
@@ -245,7 +245,7 @@ G_M10106_IG04:
        inc      ebp
        cmp      r14d, ebp
        jg       SHORT G_M10106_IG04
-						;; size=36 bbWeight=510.66 PerfScore 4595.98
+						;; size=34 bbWeight=508.61 PerfScore 4450.31
 G_M10106_IG05:
        mov      eax, ebx
 						;; size=2 bbWeight=1 PerfScore 0.25
@@ -259,6 +259,6 @@ G_M10106_IG06:
        ret      
 						;; size=11 bbWeight=1 PerfScore 3.75
 
-; Total bytes of code 83, prolog size 10, PerfScore 4615.98, instruction count 34, allocated bytes for code 83 (MethodHash=a0efd885) for method System.Collections.ContainsKeyTrue`2[int,int]:Dictionary():ubyte:this (Tier1)
+; Total bytes of code 81, prolog size 10, PerfScore 4470.31, instruction count 33, allocated bytes for code 81 (MethodHash=a0efd885) for method System.Collections.ContainsKeyTrue`2[int,int]:Dictionary():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.CreateAddAndRemove<Int32>.SortedSet(Size: 512)``

Hot functions:

- (47.81%) ``System.Collections.Generic.SortedSet`1.DoRemove`` (Tier-1)
  - **Has diffs**
- (26.08%) ``System.Collections.Generic.SortedSet`1.AddIfNotPresent`` (Tier-1)
  - **Has diffs**
- (2.74%) ``System.Collections.Generic.SortedSet`1.InsertionBalance`` (Tier-1)
  - No diffs
- (2.48%) ``System.Collections.Generic.SortedSet`1+Node.Rotate`` (Tier-1)
  - No diffs
- (1.40%) ``System.Collections.CreateAddAndRemove`1.SortedSet`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Collections]System.Collections.Generic.SortedSet`1[System.Int32].DoRemove(!0)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 237568
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 244224
 ; 18 inlinees with PGO data; 76 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T09] ( 12, 14.46)     ref  ->  rsi         this class-hnd single-def <System.Collections.Generic.SortedSet`1[int]>
-;  V01 arg1         [V01,T08] (  5,  9.39)     int  ->  rbx         single-def
-;  V02 loc0         [V02,T00] ( 14, 53.56)     ref  ->  rdi         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V03 loc1         [V03,T01] ( 29, 37.30)     ref  ->  rbp         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V04 loc2         [V04,T16] ( 14, 12.57)     ref  ->  r14         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V05 loc3         [V05,T19] ( 12,  8.31)     ref  ->  r15         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V06 loc4         [V06,T23] (  8,  5.25)     ref  ->  r13         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V07 loc5         [V07,T18] (  4, 10.63)   ubyte  ->  r12        
-;  V08 loc6         [V08,T05] (  3, 22.94)     int  ->  rax        
-;  V09 loc7         [V09,T20] (  7,  6.68)     ref  ->  rdx         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V10 loc8         [V10,T30] (  6,  2.68)     ref  ->  [rsp+0x30]  class-hnd exact spill-single-def <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V00 this         [V00,T08] ( 12, 14.44)     ref  ->  rsi         this class-hnd single-def <System.Collections.Generic.SortedSet`1[int]>
+;  V01 arg1         [V01,T07] (  5,  9.37)     int  ->  rbx         single-def
+;  V02 loc0         [V02,T00] ( 14, 51.31)     ref  ->  rdi         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V03 loc1         [V03,T01] ( 29, 37.43)     ref  ->  rbp         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V04 loc2         [V04,T15] ( 14, 12.61)     ref  ->  r14         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V05 loc3         [V05,T18] ( 12,  8.29)     ref  ->  r15         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V06 loc4         [V06,T22] (  8,  5.25)     ref  ->  r13         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V07 loc5         [V07,T17] (  4, 10.64)   ubyte  ->  r12        
+;  V08 loc6         [V08,T05] (  3, 22.97)     int  ->  rax        
+;  V09 loc7         [V09,T20] (  7,  6.33)     ref  ->  rdx         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V10 loc8         [V10,T29] (  6,  2.72)     ref  ->  [rsp+0x30]  class-hnd exact <System.Collections.Generic.SortedSet`1+Node[int]>
 ;  V11 OutArgs      [V11    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V12 tmp1         [V12,T11] (  3, 15.29)     int  ->  rax        
-;  V13 tmp2         [V13,T10] (  3, 15.29)     ref  ->  rdi        
-;  V14 tmp3         [V14,T04] (  3, 25.42)     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
-;  V15 tmp4         [V15,T03] (  4, 27.48)     int  ->   r8         "spilling ret_expr"
-;  V16 tmp5         [V16,T25] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V17 tmp6         [V17,T29] (  3,  2.99)     ref  ->  rax         single-def
-;  V18 tmp7         [V18,T14] (  3, 12.71)     int  ->  rax         "guarded devirt return temp"
+;  V12 tmp1         [V12,T10] (  3, 15.32)     int  ->  rax        
+;  V13 tmp2         [V13,T09] (  3, 15.32)     ref  ->  rdi        
+;  V14 tmp3         [V14,T04] (  3, 25.38)     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
+;  V15 tmp4         [V15,T03] (  4, 27.44)     int  ->   r8         "spilling ret_expr"
+;  V16 tmp5         [V16,T24] (  2,  4   )     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V17 tmp6         [V17,T28] (  3,  2.99)     ref  ->  rax         single-def
+;  V18 tmp7         [V18,T13] (  3, 12.69)     int  ->  rax         "guarded devirt return temp"
 ;* V19 tmp8         [V19    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericComparer`1[int]>
-;  V20 tmp9         [V20,T06] (  2, 15.29)   ubyte  ->  rcx         "Inline return value spill temp"
-;* V21 tmp10        [V21,T21] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V22 tmp11        [V22,T02] (  3, 31.18)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V23 tmp12        [V23,T17] (  3, 10.87)   ubyte  ->  rcx         "Inline return value spill temp"
-;  V24 tmp13        [V24,T07] (  3, 27.42)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V25 tmp14        [V25,T26] (  9,  3.10)     ref  ->  [rsp+0x28]  class-hnd "Inline return value spill temp" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V26 tmp15        [V26,T41] (  3,  0.22)     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V27 tmp16        [V27,T31] (  2,  1.86)   ubyte  ->  rcx         "Inline return value spill temp"
-;* V28 tmp17        [V28,T39] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V29 tmp18        [V29,T22] (  3,  5.33)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V30 tmp19        [V30,T38] (  3,  1.10)   ubyte  ->  rcx         "Inline return value spill temp"
-;  V31 tmp20        [V31,T27] (  3,  4.68)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V32 tmp21        [V32,T33] (  2,  2.18)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V33 tmp22        [V33,T34] (  2,  2.18)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V34 tmp23        [V34,T35] (  5,  1.52)   ubyte  ->  rdx         "Inline return value spill temp"
-;  V35 tmp24        [V35,T36] (  3,  1.94)   ubyte  ->  rcx         "Inline stloc first use temp"
-;* V36 tmp25        [V36,T40] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V37 tmp26        [V37,T24] (  3,  4.37)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V20 tmp9         [V20,T16] (  2,  6.50)   ubyte  ->  rcx         "Inline return value spill temp"
+;* V21 tmp10        [V21,T38] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V22 tmp11        [V22,T02] (  3, 31.09)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V23 tmp12        [V23,T19] (  3,  6.50)   ubyte  ->  rcx         "Inline return value spill temp"
+;  V24 tmp13        [V24,T06] (  3, 18.27)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V25 tmp14        [V25,T26] (  9,  3.12)     ref  ->  [rsp+0x28]  class-hnd "Inline return value spill temp" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V26 tmp15        [V26,T39] (  3,  0.22)     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V27 tmp16        [V27,T33] (  2,  1.12)   ubyte  ->  rcx         "Inline return value spill temp"
+;* V28 tmp17        [V28,T40] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V29 tmp18        [V29,T21] (  3,  5.34)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V30 tmp19        [V30,T37] (  3,  1.12)   ubyte  ->  rcx         "Inline return value spill temp"
+;  V31 tmp20        [V31,T25] (  3,  3.14)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V32 tmp21        [V32,T31] (  2,  2.18)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V33 tmp22        [V33,T32] (  2,  2.18)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V34 tmp23        [V34,T34] (  5,  1.54)   ubyte  ->  rdx         "Inline return value spill temp"
+;  V35 tmp24        [V35,T35] (  3,  1.54)   ubyte  ->  rcx         "Inline stloc first use temp"
+;* V36 tmp25        [V36,T41] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V37 tmp26        [V37,T23] (  3,  4.42)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;* V38 tmp27        [V38    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;* V39 tmp28        [V39,T15] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V40 tmp29        [V40,T13] (  4, 12.71)     int  ->  rax         "Inline return value spill temp"
-;  V41 tmp30        [V41,T12] ( 12, 14.57)     ref  ->  rbx         class-hnd "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V42 tmp31        [V42,T32] (  2,  2.38)     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V43 tmp32        [V43,T37] (  3,  1.28)     ref  ->  rax         single-def
+;* V39 tmp28        [V39,T14] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
+;  V40 tmp29        [V40,T12] (  4, 12.69)     int  ->  rax         "Inline return value spill temp"
+;  V41 tmp30        [V41,T11] ( 12, 14.49)     ref  ->  rbx         class-hnd "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V42 tmp31        [V42,T30] (  2,  2.33)     ref  ->  rax         class-hnd exact single-def "dup spill" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V43 tmp32        [V43,T36] (  3,  1.26)     ref  ->  rax         single-def
 ;* V44 tmp33        [V44    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;* V45 tmp34        [V45    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;* V46 tmp35        [V46    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;* V47 tmp36        [V47    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V48 cse0         [V48,T28] (  3,  3   )     ref  ->  rdi         "CSE #01: moderate"
+;  V48 cse0         [V48,T27] (  3,  3   )     ref  ->  rdi         "CSE #01: moderate"
 ;
 ; Lcl frame size = 56
 
@@ -755,7 +755,7 @@ G_M57124_IG01:
 G_M57124_IG02:
        mov      rdi, gword ptr [rsi+0x08]
        test     rdi, rdi
-       je       G_M57124_IG98
+       je       G_M57124_IG100
        inc      dword ptr [rsi+0x24]
        xor      rbp, rbp
        xor      r14, r14
@@ -765,229 +765,223 @@ G_M57124_IG02:
 						;; size=30 bbWeight=1 PerfScore 7.50
 G_M57124_IG03:
        cmp      byte  ptr [rdi+0x1C], 0
-       jne      SHORT G_M57124_IG09
-						;; size=6 bbWeight=7.65 PerfScore 30.59
+       jne      SHORT G_M57124_IG14
+						;; size=6 bbWeight=7.66 PerfScore 30.63
 G_M57124_IG04:
        mov      rcx, gword ptr [rdi+0x08]
        test     rcx, rcx
        je       SHORT G_M57124_IG06
-						;; size=9 bbWeight=5.55 PerfScore 18.05
+						;; size=9 bbWeight=5.53 PerfScore 17.97
 G_M57124_IG05:
        cmp      byte  ptr [rcx+0x1C], 0
-       jne      SHORT G_M57124_IG09
+       jne      SHORT G_M57124_IG14
 						;; size=6 bbWeight=4.48 PerfScore 17.94
 G_M57124_IG06:
        mov      rcx, gword ptr [rdi+0x10]
        test     rcx, rcx
-       je       G_M57124_IG92
-						;; size=13 bbWeight=5.55 PerfScore 18.05
+       je       SHORT G_M57124_IG10
+						;; size=9 bbWeight=3.25 PerfScore 10.56
 G_M57124_IG07:
        cmp      byte  ptr [rcx+0x1C], 0
        sete     cl
        movzx    rcx, cl
-						;; size=10 bbWeight=2.60 PerfScore 11.06
+						;; size=10 bbWeight=2.64 PerfScore 11.20
 G_M57124_IG08:
        test     ecx, ecx
-       jne      SHORT G_M57124_IG19
-						;; size=4 bbWeight=7.65 PerfScore 9.56
+       je       SHORT G_M57124_IG14
+						;; size=4 bbWeight=3.25 PerfScore 4.06
 G_M57124_IG09:
-       test     r12d, r12d
-       jne      G_M57124_IG42
-						;; size=9 bbWeight=7.65 PerfScore 9.56
+       jmp      SHORT G_M57124_IG21
+						;; size=2 bbWeight=1.92 PerfScore 3.84
 G_M57124_IG10:
+       mov      ecx, 1
+       jmp      SHORT G_M57124_IG08
+						;; size=7 bbWeight=0.61 PerfScore 1.38
+G_M57124_IG11:
+       mov      eax, -1
+						;; size=5 bbWeight=1.31 PerfScore 0.33
+G_M57124_IG12:
+       test     eax, eax
+       jne      SHORT G_M57124_IG19
+						;; size=4 bbWeight=7.66 PerfScore 9.57
+G_M57124_IG13:
+       jmp      SHORT G_M57124_IG18
+						;; size=2 bbWeight=0.99 PerfScore 1.97
+G_M57124_IG14:
+       test     r12d, r12d
+       jne      SHORT G_M57124_IG11
+						;; size=5 bbWeight=7.66 PerfScore 9.57
+G_M57124_IG15:
        mov      rcx, gword ptr [rsi+0x10]
        mov      r8d, dword ptr [rdi+0x18]
        mov      rax, 0xD1FFAB1E      ; System.Collections.Generic.GenericComparer`1[int]
        cmp      qword ptr [rcx], rax
-       jne      G_M57124_IG100
+       jne      G_M57124_IG102
        cmp      ebx, r8d
-       jge      G_M57124_IG43
-						;; size=36 bbWeight=6.36 PerfScore 60.38
-G_M57124_IG11:
+       jge      G_M57124_IG41
+						;; size=36 bbWeight=6.35 PerfScore 60.28
+G_M57124_IG16:
        mov      eax, -1
-						;; size=5 bbWeight=5.33 PerfScore 1.33
-G_M57124_IG12:
-       test     eax, eax
-       je       SHORT G_M57124_IG15
-						;; size=4 bbWeight=7.65 PerfScore 9.56
-G_M57124_IG13:
-       mov      r14, rbp
-       mov      rbp, rdi
-       test     eax, eax
-       jl       SHORT G_M57124_IG16
-						;; size=10 bbWeight=7.65 PerfScore 13.38
-G_M57124_IG14:
-       mov      rdi, gword ptr [rbp+0x10]
-       jmp      SHORT G_M57124_IG17
-						;; size=6 bbWeight=3.79 PerfScore 15.18
-G_M57124_IG15:
+						;; size=5 bbWeight=5.32 PerfScore 1.33
+G_M57124_IG17:
+       jmp      SHORT G_M57124_IG12
+						;; size=2 bbWeight=6.35 PerfScore 12.69
+G_M57124_IG18:
        mov      r12d, 1
        mov      r15, rdi
        mov      r13, rbp
-       jmp      SHORT G_M57124_IG13
-						;; size=14 bbWeight=0.99 PerfScore 2.71
-G_M57124_IG16:
+						;; size=12 bbWeight=0.99 PerfScore 0.74
+G_M57124_IG19:
+       mov      r14, rbp
+       mov      rbp, rdi
+       test     eax, eax
+       jl       SHORT G_M57124_IG25
+						;; size=10 bbWeight=7.66 PerfScore 13.40
+G_M57124_IG20:
+       jmp      G_M57124_IG40
+						;; size=5 bbWeight=3.77 PerfScore 7.53
+G_M57124_IG21:
+       test     rbp, rbp
+       je       SHORT G_M57124_IG24
+						;; size=5 bbWeight=1.92 PerfScore 2.40
+G_M57124_IG22:
+       cmp      rdi, gword ptr [rbp+0x08]
+       je       SHORT G_M57124_IG28
+						;; size=6 bbWeight=1.31 PerfScore 5.26
+G_M57124_IG23:
+       mov      rax, gword ptr [rbp+0x08]
+       jmp      SHORT G_M57124_IG29
+						;; size=6 bbWeight=0.64 PerfScore 2.56
+G_M57124_IG24:
+       mov      byte  ptr [rdi+0x1C], 1
+       jmp      SHORT G_M57124_IG14
+						;; size=6 bbWeight=0.61 PerfScore 1.82
+G_M57124_IG25:
        mov      rdi, gword ptr [rbp+0x08]
-						;; size=4 bbWeight=3.85 PerfScore 7.70
-G_M57124_IG17:
+						;; size=4 bbWeight=3.89 PerfScore 7.78
+G_M57124_IG26:
        test     rdi, rdi
        jne      G_M57124_IG03
-						;; size=9 bbWeight=7.65 PerfScore 9.56
-G_M57124_IG18:
-       jmp      G_M57124_IG46
+						;; size=9 bbWeight=7.66 PerfScore 9.57
+G_M57124_IG27:
+       jmp      G_M57124_IG48
 						;; size=5 bbWeight=1 PerfScore 2.00
-G_M57124_IG19:
-       test     rbp, rbp
-       je       SHORT G_M57124_IG22
-						;; size=5 bbWeight=1.90 PerfScore 2.38
-G_M57124_IG20:
-       cmp      rdi, gword ptr [rbp+0x08]
-       je       SHORT G_M57124_IG23
-						;; size=6 bbWeight=1.31 PerfScore 5.22
-G_M57124_IG21:
-       mov      rax, gword ptr [rbp+0x08]
-       jmp      SHORT G_M57124_IG24
-						;; size=6 bbWeight=0.64 PerfScore 2.55
-G_M57124_IG22:
-       mov      byte  ptr [rdi+0x1C], 1
-       jmp      SHORT G_M57124_IG09
-						;; size=6 bbWeight=0.59 PerfScore 1.78
-G_M57124_IG23:
+G_M57124_IG28:
        mov      rax, gword ptr [rbp+0x10]
-						;; size=4 bbWeight=0.67 PerfScore 1.34
-G_M57124_IG24:
+						;; size=4 bbWeight=0.67 PerfScore 1.35
+G_M57124_IG29:
        mov      rdx, rax
        cmp      byte  ptr [rdx+0x1C], 1
-       je       SHORT G_M57124_IG29
-						;; size=9 bbWeight=1.31 PerfScore 5.55
-G_M57124_IG25:
+       je       SHORT G_M57124_IG34
+						;; size=9 bbWeight=1.31 PerfScore 5.59
+G_M57124_IG30:
        cmp      byte  ptr [rdx+0x1C], 0
-       jne      G_M57124_IG67
-						;; size=10 bbWeight=1.31 PerfScore 5.22
-G_M57124_IG26:
+       jne      G_M57124_IG69
+						;; size=10 bbWeight=1.31 PerfScore 5.26
+G_M57124_IG31:
        mov      rcx, gword ptr [rdx+0x08]
        test     rcx, rcx
-       je       G_M57124_IG51
+       je       G_M57124_IG62
 						;; size=13 bbWeight=0.95 PerfScore 3.08
-G_M57124_IG27:
+G_M57124_IG32:
        cmp      byte  ptr [rcx+0x1C], 0
-       jne      G_M57124_IG67
-						;; size=10 bbWeight=0.77 PerfScore 3.06
-G_M57124_IG28:
-       jmp      G_M57124_IG51
-						;; size=5 bbWeight=0.77 PerfScore 1.53
-G_M57124_IG29:
+       jne      G_M57124_IG69
+						;; size=10 bbWeight=0.77 PerfScore 3.08
+G_M57124_IG33:
+       jmp      G_M57124_IG62
+						;; size=5 bbWeight=0.56 PerfScore 1.12
+G_M57124_IG34:
        mov      gword ptr [rsp+0x28], rax
        cmp      gword ptr [rbp+0x10], rax
-       jne      SHORT G_M57124_IG34
-						;; size=11 bbWeight=0.11 PerfScore 0.54
-G_M57124_IG30:
+       jne      SHORT G_M57124_IG39
+						;; size=11 bbWeight=0.11 PerfScore 0.55
+G_M57124_IG35:
        mov      rcx, rbp
        call     [System.Collections.Generic.SortedSet`1+Node[int]:RotateLeft():System.Collections.Generic.SortedSet`1+Node[int]:this]
 						;; size=9 bbWeight=0.06 PerfScore 0.20
-G_M57124_IG31:
+G_M57124_IG36:
        mov      byte  ptr [rbp+0x1C], 1
        mov      rax, gword ptr [rsp+0x28]
        mov      byte  ptr [rax+0x1C], 0
        test     r14, r14
-       je       SHORT G_M57124_IG45
-						;; size=18 bbWeight=0.11 PerfScore 0.46
-G_M57124_IG32:
+       je       SHORT G_M57124_IG50
+						;; size=18 bbWeight=0.11 PerfScore 0.47
+G_M57124_IG37:
        cmp      gword ptr [r14+0x08], rbp
-       jne      SHORT G_M57124_IG37
+       jne      SHORT G_M57124_IG43
 						;; size=6 bbWeight=0.10 PerfScore 0.40
-G_M57124_IG33:
+G_M57124_IG38:
        lea      rcx, bword ptr [r14+0x08]
        mov      gword ptr [rsp+0x28], rax
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M57124_IG38
+       jmp      SHORT G_M57124_IG44
 						;; size=19 bbWeight=0.05 PerfScore 0.24
-G_M57124_IG34:
+G_M57124_IG39:
        mov      rcx, rbp
        call     [System.Collections.Generic.SortedSet`1+Node[int]:RotateRight():System.Collections.Generic.SortedSet`1+Node[int]:this]
-       jmp      SHORT G_M57124_IG31
+       jmp      SHORT G_M57124_IG36
 						;; size=11 bbWeight=0.05 PerfScore 0.25
-G_M57124_IG35:
-       test     ecx, ecx
-       je       G_M57124_IG67
-						;; size=8 bbWeight=1.31 PerfScore 1.63
-G_M57124_IG36:
-       jmp      G_M57124_IG65
-						;; size=5 bbWeight=0.55 PerfScore 1.09
-G_M57124_IG37:
+G_M57124_IG40:
+       mov      rdi, gword ptr [rbp+0x10]
+       jmp      G_M57124_IG26
+						;; size=9 bbWeight=3.77 PerfScore 15.07
+G_M57124_IG41:
+       cmp      ebx, r8d
+       jle      G_M57124_IG97
+						;; size=9 bbWeight=1.03 PerfScore 1.29
+G_M57124_IG42:
+       jmp      G_M57124_IG96
+						;; size=5 bbWeight=0.10 PerfScore 0.19
+G_M57124_IG43:
        lea      rcx, bword ptr [r14+0x10]
        mov      gword ptr [rsp+0x28], rax
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-						;; size=17 bbWeight=0.10 PerfScore 0.27
-G_M57124_IG38:
+						;; size=17 bbWeight=0.10 PerfScore 0.28
+G_M57124_IG44:
        mov      r14, gword ptr [rsp+0x28]
        cmp      rbp, r15
-       je       SHORT G_M57124_IG41
-						;; size=10 bbWeight=0.11 PerfScore 0.24
-G_M57124_IG39:
-       cmp      rdi, gword ptr [rbp+0x08]
-       je       SHORT G_M57124_IG48
-						;; size=6 bbWeight=0.11 PerfScore 0.43
-G_M57124_IG40:
-       mov      rdx, gword ptr [rbp+0x08]
-       jmp      SHORT G_M57124_IG49
-						;; size=6 bbWeight=0.05 PerfScore 0.21
-G_M57124_IG41:
-       mov      r13, r14
-       jmp      SHORT G_M57124_IG39
-						;; size=5 bbWeight=0.01 PerfScore 0.03
-G_M57124_IG42:
-       mov      eax, -1
-       jmp      G_M57124_IG12
-						;; size=10 bbWeight=1.29 PerfScore 2.90
-G_M57124_IG43:
-       cmp      ebx, r8d
-       jle      G_M57124_IG93
-						;; size=9 bbWeight=1.03 PerfScore 1.29
-G_M57124_IG44:
-       jmp      G_M57124_IG96
-						;; size=5 bbWeight=0.10 PerfScore 0.19
+       je       SHORT G_M57124_IG47
+						;; size=10 bbWeight=0.11 PerfScore 0.25
 G_M57124_IG45:
+       cmp      rdi, gword ptr [rbp+0x08]
+       je       SHORT G_M57124_IG52
+						;; size=6 bbWeight=0.11 PerfScore 0.44
+G_M57124_IG46:
+       mov      rdx, gword ptr [rbp+0x08]
+       jmp      SHORT G_M57124_IG53
+						;; size=6 bbWeight=0.05 PerfScore 0.21
+G_M57124_IG47:
+       mov      r13, r14
+       jmp      SHORT G_M57124_IG45
+						;; size=5 bbWeight=0.01 PerfScore 0.03
+G_M57124_IG48:
+       test     r15, r15
+       je       SHORT G_M57124_IG56
+						;; size=5 bbWeight=1 PerfScore 1.25
+G_M57124_IG49:
+       jmp      SHORT G_M57124_IG60
+						;; size=2 bbWeight=0.97 PerfScore 1.94
+G_M57124_IG50:
        lea      rcx, bword ptr [rsi+0x08]
        mov      gword ptr [rsp+0x28], rax
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M57124_IG38
+       jmp      SHORT G_M57124_IG44
 						;; size=19 bbWeight=0.01 PerfScore 0.04
-G_M57124_IG46:
-       test     r15, r15
-       je       SHORT G_M57124_IG56
-						;; size=5 bbWeight=1 PerfScore 1.25
-G_M57124_IG47:
-       jmp      SHORT G_M57124_IG60
-						;; size=2 bbWeight=0.97 PerfScore 1.95
-G_M57124_IG48:
-       mov      rdx, gword ptr [rbp+0x10]
-						;; size=4 bbWeight=0.06 PerfScore 0.11
-G_M57124_IG49:
-       jmp      G_M57124_IG25
-						;; size=5 bbWeight=0.11 PerfScore 0.22
-G_M57124_IG50:
+G_M57124_IG51:
        lea      rcx, bword ptr [rsi+0x08]
        mov      rdx, rbx
        call     CORINFO_HELP_ASSIGN_REF
        jmp      SHORT G_M57124_IG55
-						;; size=14 bbWeight=0.08 PerfScore 0.31
-G_M57124_IG51:
-       mov      rcx, gword ptr [rdx+0x10]
-       test     rcx, rcx
-       je       SHORT G_M57124_IG62
-						;; size=9 bbWeight=0.95 PerfScore 3.08
+						;; size=14 bbWeight=0.08 PerfScore 0.30
 G_M57124_IG52:
-       cmp      byte  ptr [rcx+0x1C], 0
-       sete     cl
-       movzx    rcx, cl
-						;; size=10 bbWeight=0.44 PerfScore 1.89
+       mov      rdx, gword ptr [rbp+0x10]
+						;; size=4 bbWeight=0.06 PerfScore 0.11
 G_M57124_IG53:
-       jmp      G_M57124_IG35
-						;; size=5 bbWeight=0.55 PerfScore 1.10
+       jmp      G_M57124_IG30
+						;; size=5 bbWeight=0.11 PerfScore 0.22
 G_M57124_IG54:
        lea      rcx, bword ptr [r13+0x10]
        mov      rdx, rbx
@@ -995,7 +989,7 @@ G_M57124_IG54:
 						;; size=12 bbWeight=0.89 PerfScore 1.56
 G_M57124_IG55:
        dec      dword ptr [rsi+0x20]
-						;; size=3 bbWeight=0.97 PerfScore 2.92
+						;; size=3 bbWeight=0.97 PerfScore 2.91
 G_M57124_IG56:
        mov      rax, gword ptr [rsi+0x08]
        test     rax, rax
@@ -1022,182 +1016,194 @@ G_M57124_IG59:
 G_M57124_IG60:
        mov      rbx, rbp
        cmp      rbx, r15
-       jne      SHORT G_M57124_IG63
+       jne      SHORT G_M57124_IG67
 						;; size=8 bbWeight=0.97 PerfScore 1.46
 G_M57124_IG61:
        mov      rbx, gword ptr [r15+0x08]
-       jmp      G_M57124_IG86
-						;; size=9 bbWeight=0.38 PerfScore 1.52
+       jmp      G_M57124_IG90
+						;; size=9 bbWeight=0.39 PerfScore 1.55
 G_M57124_IG62:
-       mov      ecx, 1
-       jmp      SHORT G_M57124_IG53
-						;; size=7 bbWeight=0.11 PerfScore 0.24
+       mov      rcx, gword ptr [rdx+0x10]
+       test     rcx, rcx
+       je       SHORT G_M57124_IG66
+						;; size=9 bbWeight=0.56 PerfScore 1.81
 G_M57124_IG63:
+       cmp      byte  ptr [rcx+0x1C], 0
+       sete     cl
+       movzx    rcx, cl
+						;; size=10 bbWeight=0.45 PerfScore 1.92
+G_M57124_IG64:
+       test     ecx, ecx
+       je       SHORT G_M57124_IG69
+						;; size=4 bbWeight=0.56 PerfScore 0.70
+G_M57124_IG65:
+       jmp      SHORT G_M57124_IG73
+						;; size=2 bbWeight=0.55 PerfScore 1.09
+G_M57124_IG66:
+       mov      ecx, 1
+       jmp      SHORT G_M57124_IG64
+						;; size=7 bbWeight=0.11 PerfScore 0.24
+G_M57124_IG67:
        mov      rax, gword ptr [rbx+0x10]
        test     rax, rax
-       je       G_M57124_IG78
-						;; size=13 bbWeight=0.59 PerfScore 1.93
-G_M57124_IG64:
-       jmp      SHORT G_M57124_IG66
-						;; size=2 bbWeight=0.09 PerfScore 0.19
-G_M57124_IG65:
-       mov      byte  ptr [rbp+0x1C], 0
-       mov      rcx, gword ptr [rbp+0x08]
-       mov      byte  ptr [rcx+0x1C], 1
-       mov      rcx, gword ptr [rbp+0x10]
-       mov      byte  ptr [rcx+0x1C], 1
-       jmp      G_M57124_IG09
-						;; size=25 bbWeight=0.55 PerfScore 4.91
-G_M57124_IG66:
-       mov      byte  ptr [rax+0x1C], 0
-       jmp      SHORT G_M57124_IG78
-						;; size=6 bbWeight=0.09 PerfScore 0.28
-G_M57124_IG67:
+       je       G_M57124_IG82
+						;; size=13 bbWeight=0.58 PerfScore 1.89
+G_M57124_IG68:
+       jmp      SHORT G_M57124_IG74
+						;; size=2 bbWeight=0.09 PerfScore 0.18
+G_M57124_IG69:
        xor      ecx, ecx
        cmp      gword ptr [rbp+0x08], rdi
        sete     cl
        mov      rdx, gword ptr [rdx+0x08]
        test     rdx, rdx
-       je       SHORT G_M57124_IG71
-						;; size=18 bbWeight=0.76 PerfScore 5.70
-G_M57124_IG68:
-       cmp      byte  ptr [rdx+0x1C], 1
-       jne      SHORT G_M57124_IG71
-						;; size=6 bbWeight=0.66 PerfScore 2.65
-G_M57124_IG69:
-       test     ecx, ecx
-       jne      SHORT G_M57124_IG77
-						;; size=4 bbWeight=0.42 PerfScore 0.53
+       je       SHORT G_M57124_IG75
+						;; size=18 bbWeight=0.77 PerfScore 5.77
 G_M57124_IG70:
-       jmp      SHORT G_M57124_IG73
-						;; size=2 bbWeight=0.28 PerfScore 0.55
+       cmp      byte  ptr [rdx+0x1C], 1
+       jne      SHORT G_M57124_IG75
+						;; size=6 bbWeight=0.67 PerfScore 2.68
 G_M57124_IG71:
        test     ecx, ecx
-       je       SHORT G_M57124_IG80
-						;; size=4 bbWeight=0.76 PerfScore 0.95
+       jne      SHORT G_M57124_IG81
+						;; size=4 bbWeight=0.43 PerfScore 0.53
 G_M57124_IG72:
-       xor      edx, edx
-       jmp      SHORT G_M57124_IG74
-						;; size=4 bbWeight=0.26 PerfScore 0.59
+       jmp      SHORT G_M57124_IG77
+						;; size=2 bbWeight=0.28 PerfScore 0.56
 G_M57124_IG73:
+       mov      byte  ptr [rbp+0x1C], 0
+       mov      rcx, gword ptr [rbp+0x08]
+       mov      byte  ptr [rcx+0x1C], 1
+       mov      rcx, gword ptr [rbp+0x10]
+       mov      byte  ptr [rcx+0x1C], 1
+       jmp      G_M57124_IG14
+						;; size=25 bbWeight=0.55 PerfScore 4.91
+G_M57124_IG74:
+       mov      byte  ptr [rax+0x1C], 0
+       jmp      SHORT G_M57124_IG82
+						;; size=6 bbWeight=0.09 PerfScore 0.27
+G_M57124_IG75:
+       test     ecx, ecx
+       je       SHORT G_M57124_IG84
+						;; size=4 bbWeight=0.34 PerfScore 0.43
+G_M57124_IG76:
+       xor      edx, edx
+       jmp      SHORT G_M57124_IG78
+						;; size=4 bbWeight=0.26 PerfScore 0.60
+G_M57124_IG77:
        mov      edx, 2
 						;; size=5 bbWeight=0.28 PerfScore 0.07
-G_M57124_IG74:
+G_M57124_IG78:
        mov      rcx, rbp
        call     [System.Collections.Generic.SortedSet`1+Node[int]:Rotate(ubyte):System.Collections.Generic.SortedSet`1+Node[int]:this]
-       mov      gword ptr [rsp+0x30], rax
        movzx    rcx, byte  ptr [rbp+0x1C]
        mov      byte  ptr [rax+0x1C], cl
        mov      byte  ptr [rbp+0x1C], 0
        mov      byte  ptr [rdi+0x1C], 1
        test     r14, r14
-       je       SHORT G_M57124_IG88
-						;; size=34 bbWeight=0.76 PerfScore 7.98
-G_M57124_IG75:
+       je       G_M57124_IG92
+						;; size=33 bbWeight=0.77 PerfScore 7.31
+G_M57124_IG79:
        cmp      gword ptr [r14+0x08], rbp
-       jne      SHORT G_M57124_IG82
-						;; size=6 bbWeight=0.70 PerfScore 2.78
-G_M57124_IG76:
+       jne      SHORT G_M57124_IG86
+						;; size=6 bbWeight=0.70 PerfScore 2.82
+G_M57124_IG80:
        lea      rcx, bword ptr [r14+0x08]
+       mov      gword ptr [rsp+0x30], rax
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M57124_IG83
-						;; size=14 bbWeight=0.35 PerfScore 1.30
-G_M57124_IG77:
-       mov      edx, 3
-       jmp      SHORT G_M57124_IG74
-						;; size=7 bbWeight=0.14 PerfScore 0.32
-G_M57124_IG78:
-       cmp      r14, r15
-       je       SHORT G_M57124_IG85
-						;; size=5 bbWeight=0.59 PerfScore 0.74
-G_M57124_IG79:
-       jmp      SHORT G_M57124_IG81
-						;; size=2 bbWeight=0.36 PerfScore 0.71
-G_M57124_IG80:
-       mov      edx, 1
-       jmp      SHORT G_M57124_IG74
-						;; size=7 bbWeight=0.08 PerfScore 0.18
+       jmp      SHORT G_M57124_IG87
+						;; size=19 bbWeight=0.35 PerfScore 1.68
 G_M57124_IG81:
+       mov      edx, 3
+       jmp      SHORT G_M57124_IG78
+						;; size=7 bbWeight=0.15 PerfScore 0.33
+G_M57124_IG82:
+       cmp      r14, r15
+       je       SHORT G_M57124_IG89
+						;; size=5 bbWeight=0.58 PerfScore 0.73
+G_M57124_IG83:
+       jmp      SHORT G_M57124_IG85
+						;; size=2 bbWeight=0.35 PerfScore 0.71
+G_M57124_IG84:
+       mov      edx, 1
+       jmp      SHORT G_M57124_IG78
+						;; size=7 bbWeight=0.08 PerfScore 0.18
+G_M57124_IG85:
        mov      rdx, gword ptr [rbx+0x10]
        lea      rcx, bword ptr [r14+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [r15+0x10]
        lea      rcx, bword ptr [rbx+0x10]
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M57124_IG85
-						;; size=28 bbWeight=0.36 PerfScore 3.21
-G_M57124_IG82:
+       jmp      SHORT G_M57124_IG89
+						;; size=28 bbWeight=0.35 PerfScore 3.18
+G_M57124_IG86:
        lea      rcx, bword ptr [r14+0x10]
+       mov      gword ptr [rsp+0x30], rax
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-						;; size=12 bbWeight=0.70 PerfScore 1.22
-G_M57124_IG83:
+						;; size=17 bbWeight=0.70 PerfScore 1.94
+G_M57124_IG87:
        cmp      rbp, r15
-       jne      G_M57124_IG09
-						;; size=9 bbWeight=0.76 PerfScore 0.95
-G_M57124_IG84:
+       jne      G_M57124_IG14
+						;; size=9 bbWeight=0.77 PerfScore 0.96
+G_M57124_IG88:
        mov      r13, gword ptr [rsp+0x30]
-       jmp      G_M57124_IG09
+       jmp      G_M57124_IG14
 						;; size=10 bbWeight=0.06 PerfScore 0.17
-G_M57124_IG85:
+G_M57124_IG89:
        mov      rdx, gword ptr [r15+0x08]
        lea      rcx, bword ptr [rbx+0x08]
        call     CORINFO_HELP_ASSIGN_REF
-						;; size=13 bbWeight=0.59 PerfScore 2.08
-G_M57124_IG86:
+						;; size=13 bbWeight=0.58 PerfScore 2.04
+G_M57124_IG90:
        test     rbx, rbx
-       je       SHORT G_M57124_IG90
-						;; size=5 bbWeight=0.97 PerfScore 1.22
-G_M57124_IG87:
-       jmp      SHORT G_M57124_IG89
+       je       SHORT G_M57124_IG94
+						;; size=5 bbWeight=0.97 PerfScore 1.21
+G_M57124_IG91:
+       jmp      SHORT G_M57124_IG93
 						;; size=2 bbWeight=0.66 PerfScore 1.32
-G_M57124_IG88:
+G_M57124_IG92:
        lea      rcx, bword ptr [rsi+0x08]
+       mov      gword ptr [rsp+0x30], rax
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M57124_IG83
-						;; size=14 bbWeight=0.06 PerfScore 0.24
-G_M57124_IG89:
+       jmp      SHORT G_M57124_IG87
+						;; size=19 bbWeight=0.06 PerfScore 0.31
+G_M57124_IG93:
        movzx    rcx, byte  ptr [r15+0x1C]
        mov      byte  ptr [rbx+0x1C], cl
 						;; size=8 bbWeight=0.66 PerfScore 1.98
-G_M57124_IG90:
-       test     r13, r13
-       je       G_M57124_IG50
-						;; size=9 bbWeight=0.97 PerfScore 1.22
-G_M57124_IG91:
-       jmp      SHORT G_M57124_IG94
-						;; size=2 bbWeight=0.89 PerfScore 1.78
-G_M57124_IG92:
-       mov      ecx, 1
-       jmp      G_M57124_IG08
-						;; size=10 bbWeight=0.62 PerfScore 1.39
-G_M57124_IG93:
-       xor      eax, eax
-       jmp      G_M57124_IG12
-						;; size=7 bbWeight=0.93 PerfScore 2.10
 G_M57124_IG94:
+       test     r13, r13
+       je       G_M57124_IG51
+						;; size=9 bbWeight=0.97 PerfScore 1.21
+G_M57124_IG95:
+       jmp      SHORT G_M57124_IG98
+						;; size=2 bbWeight=0.89 PerfScore 1.78
+G_M57124_IG96:
+       mov      eax, 1
+       jmp      G_M57124_IG17
+						;; size=10 bbWeight=0.10 PerfScore 0.22
+G_M57124_IG97:
+       xor      eax, eax
+       jmp      G_M57124_IG17
+						;; size=7 bbWeight=0.93 PerfScore 2.09
+G_M57124_IG98:
        cmp      gword ptr [r13+0x08], r15
        jne      G_M57124_IG54
 						;; size=10 bbWeight=0.89 PerfScore 3.56
-G_M57124_IG95:
-       jmp      SHORT G_M57124_IG97
-						;; size=2 bbWeight=0.44 PerfScore 0.89
-G_M57124_IG96:
-       mov      eax, 1
-       jmp      G_M57124_IG12
-						;; size=10 bbWeight=0.10 PerfScore 0.22
-G_M57124_IG97:
+G_M57124_IG99:
        lea      rcx, bword ptr [r13+0x08]
        mov      rdx, rbx
        call     CORINFO_HELP_ASSIGN_REF
        jmp      G_M57124_IG55
-						;; size=17 bbWeight=0.44 PerfScore 1.67
-G_M57124_IG98:
+						;; size=17 bbWeight=0.45 PerfScore 1.67
+G_M57124_IG100:
        xor      eax, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M57124_IG99:
+G_M57124_IG101:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -1209,13 +1215,13 @@ G_M57124_IG99:
        pop      r15
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M57124_IG100:
+G_M57124_IG102:
        mov      edx, ebx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      G_M57124_IG12
+       jmp      G_M57124_IG17
 						;; size=20 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 946, prolog size 21, PerfScore 379.95, instruction count 276, allocated bytes for code 946 (MethodHash=767f20db) for method System.Collections.Generic.SortedSet`1[int]:DoRemove(int):ubyte:this (Tier1)
+; Total bytes of code 942, prolog size 21, PerfScore 384.11, instruction count 278, allocated bytes for code 942 (MethodHash=767f20db) for method System.Collections.Generic.SortedSet`1[int]:DoRemove(int):ubyte:this (Tier1)
 ; ============================================================
 


```

### ``[System.Collections]System.Collections.Generic.SortedSet`1[System.Int32].AddIfNotPresent(!0)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 211783
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 219317
 ; 5 inlinees with PGO data; 32 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T07] ( 16, 16.42)     ref  ->  rbx         this class-hnd single-def <System.Collections.Generic.SortedSet`1[int]>
-;  V01 arg1         [V01,T12] (  7, 12.33)     int  ->  rsi         single-def
-;  V02 loc0         [V02,T00] ( 13, 57.95)     ref  ->  rdi         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V03 loc1         [V03    ] (  9, 20.01)     ref  ->  [rsp+0x30]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V04 loc2         [V04,T08] (  5, 17.45)     ref  ->  rbp         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V05 loc3         [V05,T14] (  4,  9.42)     ref  ->  r14         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V06 loc4         [V06,T05] (  6, 25.08)     int  ->  r15        
+;  V00 this         [V00,T05] ( 16, 16.37)     ref  ->  rbx         this class-hnd single-def <System.Collections.Generic.SortedSet`1[int]>
+;  V01 arg1         [V01,T10] (  7, 12.27)     int  ->  rsi         single-def
+;  V02 loc0         [V02,T00] ( 13, 52.42)     ref  ->  rdi         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V03 loc1         [V03    ] (  9, 19.91)     ref  ->  [rsp+0x30]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V04 loc2         [V04,T06] (  5, 17.35)     ref  ->  rbp         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V05 loc3         [V05,T13] (  4,  9.37)     ref  ->  r14         class-hnd <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V06 loc4         [V06,T04] (  6, 24.93)     int  ->  r15        
 ;* V07 loc5         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <System.Collections.Generic.SortedSet`1+Node[int]>
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V09 tmp1         [V09,T03] (  3, 32.11)     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
-;  V10 tmp2         [V10,T02] (  4, 34.71)     int  ->   r8         "spilling ret_expr"
-;  V11 tmp3         [V11,T11] (  3, 16.05)     ref  ->  rcx        
-;  V12 tmp4         [V12,T15] (  6,  8.56)     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V09 tmp1         [V09,T03] (  3, 31.91)     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
+;  V10 tmp2         [V10,T02] (  4, 34.50)     int  ->   r8         "spilling ret_expr"
+;  V11 tmp3         [V11,T09] (  3, 15.96)     ref  ->   r8        
+;  V12 tmp4         [V12,T14] (  6,  8.56)     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;  V13 tmp5         [V13,T26] (  3,  0.01)     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V14 tmp6         [V14,T09] (  4, 16.05)     int  ->  r15         "guarded devirt return temp"
+;  V14 tmp6         [V14,T07] (  4, 15.96)     int  ->  r15         "guarded devirt return temp"
 ;* V15 tmp7         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Collections.Generic.GenericComparer`1[int]>
 ;* V16 tmp8         [V16    ] (  0,  0   )     int  ->  zero-ref    ld-addr-op "Inlining Arg"
-;  V17 tmp9         [V17,T10] (  4, 16.05)     int  ->  r15         "Inline return value spill temp"
+;  V17 tmp9         [V17,T08] (  4, 15.96)     int  ->  r15         "Inline return value spill temp"
 ;  V18 tmp10        [V18,T27] (  2,  0   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V19 tmp11        [V19,T06] (  2, 16.05)   ubyte  ->  r12         "Inline return value spill temp"
-;* V20 tmp12        [V20,T16] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V21 tmp13        [V21,T01] (  3, 46.10)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V22 tmp14        [V22,T13] (  3,  9.81)   ubyte  ->  r12         "Inline return value spill temp"
-;  V23 tmp15        [V23,T04] (  3, 31.09)     ref  ->  r13         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V24 tmp16        [V24,T21] (  2,  2.25)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V25 tmp17        [V25,T22] (  2,  2.25)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V19 tmp11        [V19,T12] (  2,  3.53)   ubyte  ->  r12         "Inline return value spill temp"
+;* V20 tmp12        [V20,T24] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
+;  V21 tmp13        [V21,T01] (  3, 45.82)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V22 tmp14        [V22,T17] (  3,  3.53)   ubyte  ->  r12         "Inline return value spill temp"
+;  V23 tmp15        [V23,T11] (  3, 10.15)     ref  ->  r13         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V24 tmp16        [V24,T20] (  2,  2.24)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V25 tmp17        [V25,T21] (  2,  2.24)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
 ;* V26 tmp18        [V26,T25] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V27 tmp19        [V27,T19] (  3,  3.23)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V28 tmp20        [V28,T24] (  2,  1.85)     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V29 tmp21        [V29,T23] (  2,  2.14)     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V30 tmp22        [V30,T17] (  2,  3.99)     ref  ->   r8         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V31 tmp23        [V31,T18] (  2,  3.99)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
-;  V32 cse0         [V32,T20] (  3,  3.00)     ref  ->  rdi         "CSE #01: moderate"
+;  V27 tmp19        [V27,T18] (  3,  3.22)     ref  ->   r8         class-hnd exact "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V28 tmp20        [V28,T23] (  2,  1.85)     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V29 tmp21        [V29,T22] (  2,  2.15)     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V30 tmp22        [V30,T15] (  2,  3.99)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V31 tmp23        [V31,T16] (  2,  3.99)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.SortedSet`1+Node[int]>
+;  V32 cse0         [V32,T19] (  3,  3.00)     ref  ->  rdi         "CSE #01: moderate"
 ;
 ; Lcl frame size = 56
 
@@ -571,7 +571,7 @@ G_M41817_IG01:
 G_M41817_IG02:
        mov      rdi, gword ptr [rbx+0x08]
        test     rdi, rdi
-       je       SHORT G_M41817_IG14
+       je       SHORT G_M41817_IG12
 						;; size=9 bbWeight=1 PerfScore 3.25
 G_M41817_IG03:
        xor      r8, r8
@@ -589,37 +589,30 @@ G_M41817_IG06:
        mov      r8d, dword ptr [rdi+0x18]
        mov      rdx, 0xD1FFAB1E      ; System.Collections.Generic.GenericComparer`1[int]
        cmp      qword ptr [rcx], rdx
-       jne      G_M41817_IG37
-						;; size=27 bbWeight=8.03 PerfScore 66.22
-G_M41817_IG07:
+       jne      G_M41817_IG38
        cmp      esi, r8d
-       jge      G_M41817_IG16
-						;; size=9 bbWeight=8.03 PerfScore 10.03
-G_M41817_IG08:
+       jge      G_M41817_IG17
+						;; size=36 bbWeight=7.98 PerfScore 75.79
+G_M41817_IG07:
        mov      r15d, -1
-						;; size=6 bbWeight=6.73 PerfScore 1.68
-G_M41817_IG09:
+						;; size=6 bbWeight=6.69 PerfScore 1.67
+G_M41817_IG08:
        test     r15d, r15d
-       je       G_M41817_IG38
-						;; size=9 bbWeight=8.03 PerfScore 10.03
-G_M41817_IG10:
+       je       G_M41817_IG39
+						;; size=9 bbWeight=7.98 PerfScore 9.97
+G_M41817_IG09:
        mov      r8, gword ptr [rdi+0x08]
        test     r8, r8
-       je       G_M41817_IG22
-						;; size=13 bbWeight=8.03 PerfScore 26.09
-G_M41817_IG11:
+       je       SHORT G_M41817_IG19
+						;; size=9 bbWeight=7.98 PerfScore 25.93
+G_M41817_IG10:
        cmp      byte  ptr [r8+0x1C], 1
-       jne      G_M41817_IG22
-						;; size=11 bbWeight=7.00 PerfScore 27.98
+       jne      SHORT G_M41817_IG19
+						;; size=7 bbWeight=6.95 PerfScore 27.82
+G_M41817_IG11:
+       jmp      G_M41817_IG21
+						;; size=5 bbWeight=1.77 PerfScore 3.53
 G_M41817_IG12:
-       mov      r13, gword ptr [rdi+0x10]
-       test     r13, r13
-       je       SHORT G_M41817_IG18
-						;; size=9 bbWeight=7.00 PerfScore 22.73
-G_M41817_IG13:
-       jmp      SHORT G_M41817_IG20
-						;; size=2 bbWeight=1.56 PerfScore 3.11
-G_M41817_IG14:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.SortedSet`1+Node[int]
        call     CORINFO_HELP_NEWSFAST
        mov      rdi, rax
@@ -634,7 +627,7 @@ G_M41817_IG14:
        inc      dword ptr [rbx+0x24]
        mov      eax, 1
 						;; size=59 bbWeight=0.00 PerfScore 0.02
-G_M41817_IG15:
+G_M41817_IG13:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -646,43 +639,56 @@ G_M41817_IG15:
        pop      r15
        ret      
 						;; size=17 bbWeight=0.00 PerfScore 0.01
+G_M41817_IG14:
+       mov      r8, gword ptr [rdi+0x08]
+						;; size=4 bbWeight=3.99 PerfScore 7.98
+G_M41817_IG15:
+       mov      rdi, r8
+       test     rdi, rdi
+       jne      G_M41817_IG06
+						;; size=12 bbWeight=7.98 PerfScore 11.97
 G_M41817_IG16:
-       cmp      esi, r8d
-       jg       SHORT G_M41817_IG19
-						;; size=5 bbWeight=1.30 PerfScore 1.63
+       jmp      G_M41817_IG30
+						;; size=5 bbWeight=1.00 PerfScore 2.00
 G_M41817_IG17:
-       xor      r15d, r15d
-       jmp      G_M41817_IG09
-						;; size=8 bbWeight=1.18 PerfScore 2.65
+       cmp      esi, r8d
+       jg       SHORT G_M41817_IG23
+						;; size=5 bbWeight=1.29 PerfScore 1.62
 G_M41817_IG18:
-       xor      r12d, r12d
-       jmp      SHORT G_M41817_IG21
-						;; size=5 bbWeight=0.23 PerfScore 0.52
+       xor      r15d, r15d
+       jmp      G_M41817_IG08
+						;; size=8 bbWeight=1.17 PerfScore 2.63
 G_M41817_IG19:
-       mov      r15d, 1
-       jmp      G_M41817_IG09
-						;; size=11 bbWeight=0.12 PerfScore 0.28
-G_M41817_IG20:
-       xor      r12d, r12d
-       cmp      byte  ptr [r13+0x1C], 1
-       sete     r12b
-						;; size=12 bbWeight=1.56 PerfScore 6.61
-G_M41817_IG21:
-       test     r12d, r12d
-       jne      SHORT G_M41817_IG24
-						;; size=5 bbWeight=8.03 PerfScore 10.03
-G_M41817_IG22:
        mov      r14, rbp
        mov      rbp, gword ptr [rsp+0x30]
        mov      gword ptr [rsp+0x30], rdi
        test     r15d, r15d
-       jl       SHORT G_M41817_IG26
-						;; size=18 bbWeight=8.03 PerfScore 28.09
+       jl       SHORT G_M41817_IG14
+						;; size=18 bbWeight=7.98 PerfScore 27.92
+G_M41817_IG20:
+       mov      r8, gword ptr [rdi+0x10]
+       jmp      SHORT G_M41817_IG15
+						;; size=6 bbWeight=3.99 PerfScore 15.96
+G_M41817_IG21:
+       mov      r13, gword ptr [rdi+0x10]
+       test     r13, r13
+       je       SHORT G_M41817_IG24
+						;; size=9 bbWeight=1.77 PerfScore 5.74
+G_M41817_IG22:
+       jmp      SHORT G_M41817_IG29
+						;; size=2 bbWeight=1.54 PerfScore 3.08
 G_M41817_IG23:
-       mov      rcx, gword ptr [rdi+0x10]
-       jmp      SHORT G_M41817_IG27
-						;; size=6 bbWeight=4.01 PerfScore 16.05
+       mov      r15d, 1
+       jmp      G_M41817_IG08
+						;; size=11 bbWeight=0.12 PerfScore 0.27
 G_M41817_IG24:
+       xor      r12d, r12d
+						;; size=3 bbWeight=0.23 PerfScore 0.06
+G_M41817_IG25:
+       test     r12d, r12d
+       je       SHORT G_M41817_IG19
+						;; size=5 bbWeight=1.77 PerfScore 2.21
+G_M41817_IG26:
        mov      byte  ptr [rdi+0x1C], 1
        mov      r8, gword ptr [rdi+0x08]
        mov      byte  ptr [r8+0x1C], 0
@@ -690,67 +696,72 @@ G_M41817_IG24:
        mov      byte  ptr [r8+0x1C], 0
        mov      r8, gword ptr [rsp+0x30]
        test     r8, r8
-       je       SHORT G_M41817_IG22
-						;; size=32 bbWeight=0.56 PerfScore 5.21
-G_M41817_IG25:
-       cmp      byte  ptr [r8+0x1C], 1
-       jne      SHORT G_M41817_IG22
-       jmp      SHORT G_M41817_IG29
-						;; size=9 bbWeight=0.49 PerfScore 2.94
-G_M41817_IG26:
-       mov      rcx, gword ptr [rdi+0x08]
-						;; size=4 bbWeight=4.01 PerfScore 8.03
+       je       SHORT G_M41817_IG19
+						;; size=32 bbWeight=0.56 PerfScore 5.18
 G_M41817_IG27:
-       mov      rdi, rcx
-       test     rdi, rdi
-       jne      G_M41817_IG06
-						;; size=12 bbWeight=8.03 PerfScore 12.04
+       cmp      byte  ptr [r8+0x1C], 1
+       jne      SHORT G_M41817_IG19
+						;; size=7 bbWeight=0.49 PerfScore 1.95
 G_M41817_IG28:
-       jmp      SHORT G_M41817_IG30
-						;; size=2 bbWeight=1.00 PerfScore 2.00
-G_M41817_IG29:
        mov      gword ptr [rsp+0x20], r14
        lea      r8, [rsp+0x30]
        mov      rcx, rbx
        mov      rdx, rdi
        mov      r9, rbp
        call     [System.Collections.Generic.SortedSet`1[int]:InsertionBalance(System.Collections.Generic.SortedSet`1+Node[int],byref,System.Collections.Generic.SortedSet`1+Node[int],System.Collections.Generic.SortedSet`1+Node[int]):this]
-       jmp      SHORT G_M41817_IG22
-						;; size=27 bbWeight=0.11 PerfScore 0.79
+       jmp      SHORT G_M41817_IG19
+						;; size=27 bbWeight=0.11 PerfScore 0.80
+G_M41817_IG29:
+       xor      r12d, r12d
+       cmp      byte  ptr [r13+0x1C], 1
+       sete     r12b
+       jmp      SHORT G_M41817_IG25
+						;; size=14 bbWeight=1.54 PerfScore 9.63
 G_M41817_IG30:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.SortedSet`1+Node[int]
        call     CORINFO_HELP_NEWSFAST
-       mov      rdi, rax
-       mov      dword ptr [rdi+0x18], esi
-       mov      byte  ptr [rdi+0x1C], 1
+       mov      r12, rax
+       mov      dword ptr [r12+0x18], esi
+       mov      byte  ptr [r12+0x1C], 1
        test     r15d, r15d
-       jle      SHORT G_M41817_IG32
-						;; size=30 bbWeight=1.00 PerfScore 4.74
+       jg       SHORT G_M41817_IG34
+						;; size=34 bbWeight=1.00 PerfScore 4.74
 G_M41817_IG31:
-       mov      rcx, gword ptr [rsp+0x30]
-       lea      rcx, bword ptr [rcx+0x10]
-       mov      rdx, rdi
-       call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M41817_IG33
-						;; size=19 bbWeight=0.46 PerfScore 2.20
-G_M41817_IG32:
        mov      rcx, gword ptr [rsp+0x30]
        lea      rcx, bword ptr [rcx+0x08]
-       mov      rdx, rdi
+       mov      rdx, r12
        call     CORINFO_HELP_ASSIGN_REF
-						;; size=17 bbWeight=0.53 PerfScore 1.47
+						;; size=17 bbWeight=0.54 PerfScore 1.48
+G_M41817_IG32:
+       mov      rax, gword ptr [rsp+0x30]
+       cmp      byte  ptr [rax+0x1C], 1
+       jne      SHORT G_M41817_IG36
+						;; size=11 bbWeight=1.00 PerfScore 4.99
 G_M41817_IG33:
-       mov      r8, gword ptr [rsp+0x30]
-       cmp      byte  ptr [r8+0x1C], 1
-       je       SHORT G_M41817_IG36
-						;; size=12 bbWeight=1.00 PerfScore 4.99
+       jmp      SHORT G_M41817_IG35
+						;; size=2 bbWeight=0.29 PerfScore 0.57
 G_M41817_IG34:
+       mov      rcx, gword ptr [rsp+0x30]
+       lea      rcx, bword ptr [rcx+0x10]
+       mov      rdx, r12
+       call     CORINFO_HELP_ASSIGN_REF
+       jmp      SHORT G_M41817_IG32
+						;; size=19 bbWeight=0.46 PerfScore 2.19
+G_M41817_IG35:
+       mov      gword ptr [rsp+0x20], r14
+       lea      r8, [rsp+0x30]
+       mov      rcx, rbx
+       mov      rdx, r12
+       mov      r9, rbp
+       call     [System.Collections.Generic.SortedSet`1[int]:InsertionBalance(System.Collections.Generic.SortedSet`1+Node[int],byref,System.Collections.Generic.SortedSet`1+Node[int],System.Collections.Generic.SortedSet`1+Node[int]):this]
+						;; size=25 bbWeight=0.29 PerfScore 1.51
+G_M41817_IG36:
        mov      rax, gword ptr [rbx+0x08]
        mov      byte  ptr [rax+0x1C], 0
        inc      dword ptr [rbx+0x20]
        mov      eax, 1
 						;; size=16 bbWeight=1.00 PerfScore 6.24
-G_M41817_IG35:
+G_M41817_IG37:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -762,29 +773,20 @@ G_M41817_IG35:
        pop      r15
        ret      
 						;; size=17 bbWeight=1.00 PerfScore 5.24
-G_M41817_IG36:
-       mov      gword ptr [rsp+0x20], r14
-       lea      r8, [rsp+0x30]
-       mov      rcx, rbx
-       mov      rdx, rdi
-       mov      r9, rbp
-       call     [System.Collections.Generic.SortedSet`1[int]:InsertionBalance(System.Collections.Generic.SortedSet`1+Node[int],byref,System.Collections.Generic.SortedSet`1+Node[int],System.Collections.Generic.SortedSet`1+Node[int]):this]
-       jmp      SHORT G_M41817_IG34
-						;; size=27 bbWeight=0.29 PerfScore 2.09
-G_M41817_IG37:
+G_M41817_IG38:
        mov      edx, esi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      r15d, eax
        test     r15d, r15d
-       jne      G_M41817_IG10
+       jne      G_M41817_IG09
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M41817_IG38:
+G_M41817_IG39:
        mov      rax, gword ptr [rbx+0x08]
        mov      byte  ptr [rax+0x1C], 0
        xor      eax, eax
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M41817_IG39:
+G_M41817_IG40:
        add      rsp, 56
        pop      rbx
        pop      rbp
@@ -797,6 +799,6 @@ G_M41817_IG39:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 563, prolog size 28, PerfScore 309.73, instruction count 165, allocated bytes for code 563 (MethodHash=ce145ca6) for method System.Collections.Generic.SortedSet`1[int]:AddIfNotPresent(int):ubyte:this (Tier1)
+; Total bytes of code 564, prolog size 28, PerfScore 288.69, instruction count 165, allocated bytes for code 564 (MethodHash=ce145ca6) for method System.Collections.Generic.SortedSet`1[int]:AddIfNotPresent(int):ubyte:this (Tier1)
 ; ============================================================
 


```

### ``[MicroBenchmarks]System.Collections.CreateAddAndRemove`1[System.Int32].SortedSet()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2786.75
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2837.31
 ; 2 inlinees with PGO data; 3 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
@@ -391,7 +391,7 @@ G_M43024_IG12:
 ;* V02 loc1         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd <<unknown class>>
 ;* V03 loc2         [V03    ] (  0,  0   )     int  ->  zero-ref   
 ;* V04 loc3         [V04    ] (  0,  0   )     int  ->  zero-ref   
-;  V05 loc4         [V05,T03] (  3,100.00)     ref  ->  rdi         class-hnd <<unknown class>>
+;  V05 loc4         [V05,T03] (  3,100   )     ref  ->  rdi         class-hnd <<unknown class>>
 ;  V06 loc5         [V06,T00] ( 11,400.99)     int  ->  rbx        
 ;* V07 loc6         [V07    ] (  0,  0   )     int  ->  zero-ref   
 ;  V08 OutArgs      [V08    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
@@ -474,17 +474,19 @@ G_M43024_IG09:
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T07] (  4,    4   )     ref  ->  rbx         this class-hnd single-def <System.Collections.CreateAddAndRemove`1[int]>
-;  V01 loc0         [V01,T02] (  4,32965.56)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Generic.SortedSet`1[int]>
-;  V02 loc1         [V02,T03] (  3,16937.11)     ref  ->  rdi         class-hnd single-def <<unknown class>>
-;  V03 loc2         [V03,T00] (  5,67741.44)     int  ->  rbp        
+;  V01 loc0         [V01,T02] (  4,33520.22)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Generic.SortedSet`1[int]>
+;  V02 loc1         [V02,T03] (  3,17196.67)     ref  ->  rdi         class-hnd single-def <<unknown class>>
+;* V03 loc2         [V03,T09] (  0,    0   )     int  ->  zero-ref   
 ;* V04 loc3         [V04    ] (  0,    0   )     int  ->  zero-ref   
-;  V05 loc4         [V05,T05] (  3,16030.44)     ref  ->  rbx         class-hnd single-def <<unknown class>>
-;  V06 loc5         [V06,T01] (  5,64114.78)     int  ->  rdi        
+;  V05 loc4         [V05,T05] (  3,16325.56)     ref  ->  rbx         class-hnd single-def <<unknown class>>
+;* V06 loc5         [V06,T10] (  0,    0   )     int  ->  zero-ref   
 ;* V07 loc6         [V07    ] (  0,    0   )     int  ->  zero-ref   
 ;  V08 OutArgs      [V08    ] (  1,    1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V09 tmp1         [V09,T08] (  3,    6   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.SortedSet`1[int]>
-;  V10 cse0         [V10,T04] (  3,16937.11)     int  ->  r14         "CSE #01: aggressive"
-;  V11 cse1         [V11,T06] (  3,16030.44)     int  ->  rbp         "CSE #02: aggressive"
+;  V10 cse0         [V10,T04] (  3,17196.67)     int  ->  r14         "CSE #01: aggressive"
+;  V11 cse1         [V11,T06] (  3,16325.56)     int  ->  rbp         "CSE #02: aggressive"
+;  V12 rat0         [V12,T00] (  5,68779.67)    long  ->  rbp         "Widened IV V03"
+;  V13 rat1         [V13,T01] (  5,65295.22)    long  ->  rdi         "Widened IV V06"
 ;
 ; Lcl frame size = 32
 
@@ -512,14 +514,13 @@ G_M43024_IG02:
        jle      SHORT G_M43024_IG04
 						;; size=55 bbWeight=1 PerfScore 10.75
 G_M43024_IG03:
-       mov      edx, ebp
-       mov      edx, dword ptr [rdi+4*rdx+0x10]
+       mov      edx, dword ptr [rdi+4*rbp+0x10]
        mov      rcx, rsi
        call     [<unknown method>]
        inc      ebp
        cmp      r14d, ebp
        jg       SHORT G_M43024_IG03
-						;; size=22 bbWeight=16935.11 PerfScore 118545.78
+						;; size=20 bbWeight=17194.67 PerfScore 116064.00
 G_M43024_IG04:
        mov      rbx, gword ptr [rbx+0x08]
        xor      edi, edi
@@ -528,14 +529,13 @@ G_M43024_IG04:
        jle      SHORT G_M43024_IG06
 						;; size=13 bbWeight=1 PerfScore 5.50
 G_M43024_IG05:
-       mov      edx, edi
-       mov      edx, dword ptr [rbx+4*rdx+0x10]
+       mov      edx, dword ptr [rbx+4*rdi+0x10]
        mov      rcx, rsi
        call     [<unknown method>]
        inc      edi
        cmp      ebp, edi
        jg       SHORT G_M43024_IG05
-						;; size=21 bbWeight=16028.44 PerfScore 112199.11
+						;; size=19 bbWeight=16323.56 PerfScore 110184.00
 G_M43024_IG06:
        mov      rax, rsi
 						;; size=3 bbWeight=1 PerfScore 0.25
@@ -549,6 +549,6 @@ G_M43024_IG07:
        ret      
 						;; size=11 bbWeight=1 PerfScore 3.75
 
-; Total bytes of code 138, prolog size 10, PerfScore 230770.64, instruction count 46, allocated bytes for code 138 (MethodHash=511c57ef) for method System.Collections.CreateAddAndRemove`1[int]:SortedSet():System.Collections.Generic.SortedSet`1[int]:this (Tier1)
+; Total bytes of code 134, prolog size 10, PerfScore 226273.75, instruction count 44, allocated bytes for code 134 (MethodHash=511c57ef) for method System.Collections.CreateAddAndRemove`1[int]:SortedSet():System.Collections.Generic.SortedSet`1[int]:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.CtorFromCollection<String>.ConcurrentQueue(Size: 512)``

Hot functions:

- (50.40%) ``System.Collections.Concurrent.ConcurrentQueue`1..ctor`` (Tier-1)
  - **Has diffs**
- (9.27%) ``System.Collections.Concurrent.ConcurrentQueueSegment`1..ctor`` (Tier-1)
  - **Has diffs**
- (5.40%) ``System.SZGenericArrayEnumerator`1.get_Current`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Private.CoreLib]System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]..ctor(class System.Collections.Generic.IEnumerable`1<!0>)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 681
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 758
 ; 4 inlinees with PGO data; 3 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T13] (  9,1028.50)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]>
-;  V01 arg1         [V01,T18] (  5,   5   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[System.__Canon]>
-;  V02 loc0         [V02,T34] (  3,   3.00)     int  ->  rsi        
-;  V03 loc1         [V03,T33] (  3,   3.00)     ref  ->  r14         class-hnd single-def <<unknown class>>
-;  V04 loc2         [V04,T31] (  3,   3.00)     int  ->  rax        
+;  V00 this         [V00,T12] ( 12,1045.03)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]>
+;  V01 arg1         [V01,T23] (  5,   5   )     ref  ->  rbx         class-hnd single-def <System.Collections.Generic.IEnumerable`1[System.__Canon]>
+;  V02 loc0         [V02,T39] (  3,   3.00)     int  ->  rsi        
+;  V03 loc1         [V03,T38] (  3,   3.00)     ref  ->  r14         class-hnd single-def <<unknown class>>
+;  V04 loc2         [V04,T36] (  3,   3.00)     int  ->  rax        
 ;* V05 loc3         [V05    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
-;  V06 loc4         [V06,T01] ( 12,3583.74)     ref  ->  [rbp-0x48]  class-hnd EH-live single-def <<unknown class>>
-;  V07 loc5         [V07,T14] (  3,1022.50)     ref  ->  rdx         class-hnd <System.__Canon>
+;  V06 loc4         [V06,T04] ( 20,2608.77)     ref  ->  [rbp-0x50]  class-hnd EH-live single-def <<unknown class>>
+;  V07 loc5         [V07,T14] (  6,1039.03)     ref  ->  rdx         class-hnd <System.__Canon>
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
-;  V16 tmp8         [V16,T03] (  4,3067.49)    long  ->  r11         "VirtualCall with runtime lookup"
+;  V16 tmp8         [V16,T02] (  8,3117.09)    long  ->  r11         "VirtualCall with runtime lookup"
 ;* V17 tmp9         [V17    ] (  0,   0   )    long  ->  zero-ref    "spilling helperCall"
-;  V18 tmp10        [V18,T19] (  4,   6.01)    long  ->  r11         "VirtualCall with runtime lookup"
-;  V19 tmp11        [V19,T06] (  2,1024.50)     int  ->  rax         "guarded devirt return temp"
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
-;  V26 tmp18        [V26,T00] (  5,5112.48)     ref  ->  rdi         class-hnd exact "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
-;  V27 tmp19        [V27,T10] (  3,1533.74)     ref  ->  r14         class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V28 tmp20        [V28,T02] (  6,3067.49)     int  ->  [rbp-0x3C]  spill-single-def "Inline stloc first use temp"
-;  V29 tmp21        [V29,T11] (  3,1533.74)     int  ->  r11         "Inline stloc first use temp"
+;  V26 tmp18        [V26,T00] ( 10,5195.15)     ref  ->  rdi         class-hnd exact "Inlining Arg" <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
+;  V27 tmp19        [V27,T08] (  6,1558.54)     ref  ->  r14         class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V28 tmp20        [V28,T01] ( 12,3117.09)     int  ->  [rbp-0x44]  "Inline stloc first use temp"
+;  V29 tmp21        [V29,T09] (  6,1558.54)     int  ->  r15         "Inline stloc first use temp"
 ;* V30 tmp22        [V30    ] (  0,   0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V31 tmp23        [V31,T15] (  3,1022.50)     int  ->   r8         "Inline stloc first use temp"
-;  V32 tmp24        [V32,T09] (  3,1535.75)     int  ->  rcx         "Inline stloc first use temp"
-;  V33 tmp25        [V33,T30] (  2,   4   )    long  ->  rax         "argument with side effect"
-;  V34 PSPSym       [V34,T36] (  1,   1   )    long  ->  [rbp-0x50]  do-not-enreg[V] "PSPSym"
-;  V35 cse0         [V35,T07] (  4,2044.99)   byref  ->  r15         "CSE #05: aggressive"
-;  V36 cse1         [V36,T08] (  3,1536.74)     int  ->  rsi         "CSE #07: aggressive"
-;  V37 cse2         [V37,T12] (  3,1533.74)     int  ->  r13         "CSE #06: aggressive"
-;  V38 cse3         [V38,T22] (  8,   5.60)    long  ->  rdi         "CSE #01: moderate"
-;  V39 rat0         [V39,T26] (  3,   4.40)    long  ->  rdx         "Spilling to split statement for tree"
-;  V40 rat1         [V40,T27] (  3,   4   )    long  ->  rax         "runtime lookup"
-;  V41 rat2         [V41,T23] (  3,   5.60)    long  ->  rax         "fgMakeTemp is creating a new local variable"
-;  V42 rat3         [V42,T21] (  3,   5.61)    long  ->  r11         "fgMakeTemp is creating a new local variable"
-;  V43 rat4         [V43,T28] (  3,   4   )    long  ->  rcx         "runtime lookup"
-;  V44 rat5         [V44,T24] (  3,   5.60)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
-;  V45 rat6         [V45,T25] (  3,   5.60)    long  ->  r11         "fgMakeTemp is creating a new local variable"
-;  V46 rat7         [V46,T05] (  3,2249.49)    long  ->  rdx         "Spilling to split statement for tree"
-;  V47 rat8         [V47,T04] (  3,2862.99)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V31 tmp23        [V31,T15] (  6,1039.03)     int  ->   r8         "Inline stloc first use temp"
+;  V32 tmp24        [V32,T07] (  6,1560.53)     int  ->  rax         "Inline stloc first use temp"
+;  V33 tmp25        [V33,T35] (  2,   4   )    long  ->  rax         "argument with side effect"
+;  V34 PSPSym       [V34,T41] (  1,   1   )    long  ->  [rbp-0x60]  do-not-enreg[V] "PSPSym"
+;  V35 cse0         [V35,T06] (  4,2057.28)   byref  ->  r13         "CSE #05: aggressive"
+;  V36 cse1         [V36,T19] (  4,  20.78)   byref  ->  rsi         "CSE #12: moderate"
+;  V37 cse2         [V37,T10] (  3,1545.93)     int  ->  rsi         "CSE #07: aggressive"
+;  V38 cse3         [V38,T20] (  3,  15.62)     int  ->  r13         "CSE #16: moderate"
+;  V39 cse4         [V39,T11] (  3,1542.96)     int  ->  r12         "CSE #06: aggressive"
+;  V40 cse5         [V40,T21] (  3,  15.59)     int  ->  r15         "CSE #13: moderate"
+;  V41 cse6         [V41,T27] (  8,   5.60)    long  ->  rdi         "CSE #01: moderate"
+;  V42 rat0         [V42,T31] (  3,   4.40)    long  ->  rdx         "Spilling to split statement for tree"
+;  V43 rat1         [V43,T32] (  3,   4   )    long  ->  rax         "runtime lookup"
+;  V44 rat2         [V44,T28] (  3,   5.60)    long  ->  rax         "fgMakeTemp is creating a new local variable"
+;  V45 rat3         [V45,T26] (  3,   5.61)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V46 rat4         [V46,T33] (  3,   4   )    long  ->  rcx         "runtime lookup"
+;  V47 rat5         [V47,T29] (  3,   5.60)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V48 rat6         [V48,T30] (  3,   5.60)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V49 rat7         [V49,T05] (  3,2263.01)    long  ->  rdx         "Spilling to split statement for tree"
+;  V50 rat8         [V50,T03] (  3,2880.19)    long  ->  r11         "fgMakeTemp is creating a new local variable"
+;  V51 rat9         [V51,T18] (  3,  22.86)    long  ->  rdx         "Spilling to split statement for tree"
+;  V52 rat10        [V52,T17] (  3,  29.09)    long  ->  r11         "fgMakeTemp is creating a new local variable"
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
+       je       G_M38014_IG41
        mov      rcx, 0xD1FFAB1E      ; System.Object
        call     CORINFO_HELP_NEWSFAST
        mov      rcx, gword ptr [rbp+0x10]
@@ -411,7 +417,7 @@ G_M38014_IG02:
        mov      rax, qword ptr [rax]
        mov      rax, qword ptr [rax+0x38]
        test     rax, rax
-       je       G_M38014_IG21
+       je       G_M38014_IG38
 						;; size=75 bbWeight=1 PerfScore 16.00
 G_M38014_IG03:
        mov      rcx, rax
@@ -419,20 +425,22 @@ G_M38014_IG03:
        call     [CORINFO_HELP_ISINSTANCEOFINTERFACE]
        mov      r14, rax
        test     r14, r14
-       je       SHORT G_M38014_IG06
+       je       SHORT G_M38014_IG07
 						;; size=20 bbWeight=1 PerfScore 5.00
 G_M38014_IG04:
        mov      rcx, qword ptr [rdi+0x30]
        mov      rcx, qword ptr [rcx]
        mov      r11, qword ptr [rcx+0x58]
        test     r11, r11
-       je       G_M38014_IG22
+       je       G_M38014_IG37
 						;; size=20 bbWeight=1.00 PerfScore 7.26
 G_M38014_IG05:
        mov      rcx, r14
        call     [r11]
        cmp      eax, 32
-       jle      SHORT G_M38014_IG06
+       jle      SHORT G_M38014_IG07
+						;; size=11 bbWeight=1.00 PerfScore 4.51
+G_M38014_IG06:
        dec      eax
        xor      ecx, ecx
        lzcnt    ecx, eax
@@ -441,15 +449,15 @@ G_M38014_IG05:
        mov      ecx, 0xD1FFAB1E
        cmp      esi, 0xD1FFAB1E
        cmova    esi, ecx
-						;; size=48 bbWeight=1.00 PerfScore 8.51
-G_M38014_IG06:
+						;; size=37 bbWeight=1.00 PerfScore 4.01
+G_M38014_IG07:
        mov      rcx, qword ptr [rdi+0x30]
        mov      rcx, qword ptr [rcx]
        mov      rcx, qword ptr [rcx+0x40]
        test     rcx, rcx
-       je       G_M38014_IG23
+       je       G_M38014_IG39
 						;; size=20 bbWeight=1 PerfScore 7.25
-G_M38014_IG07:
+G_M38014_IG08:
        call     CORINFO_HELP_NEWSFAST
        mov      r14, rax
        mov      rcx, r14
@@ -467,189 +475,287 @@ G_M38014_IG07:
        mov      rcx, qword ptr [rcx]
        mov      r11, qword ptr [rcx+0x48]
        test     r11, r11
-       je       G_M38014_IG24
+       je       G_M38014_IG40
 						;; size=71 bbWeight=1 PerfScore 17.50
-G_M38014_IG08:
+G_M38014_IG09:
        mov      rcx, rbx
        call     [r11]
        mov      rbx, rax
-       mov      gword ptr [rbp-0x48], rbx
+       mov      gword ptr [rbp-0x50], rbx
 						;; size=13 bbWeight=1 PerfScore 4.50
-G_M38014_IG09:
-       jmp      G_M38014_IG15
-						;; size=5 bbWeight=1 PerfScore 2.00
 G_M38014_IG10:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
+       test     rbx, rbx
+       je       G_M38014_IG27
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbx], rcx
+       jne      G_M38014_IG27
+       jmp      G_M38014_IG19
+       align    [1 bytes for IG13]
+						;; size=34 bbWeight=1 PerfScore 7.50
 G_M38014_IG11:
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
-						;; size=27 bbWeight=511.25 PerfScore 5240.29
-G_M38014_IG13:
+       je       SHORT G_M38014_IG15
+						;; size=23 bbWeight=514.32 PerfScore 5271.77
+G_M38014_IG12:
        mov      rcx, rbx
        call     [r11]
        mov      rdx, rax
        mov      rcx, gword ptr [rbp+0x10]
        mov      rdi, gword ptr [rcx+0x10]
        mov      r14, gword ptr [rdi+0x08]
-						;; size=21 bbWeight=511.25 PerfScore 4345.61
-G_M38014_IG14:
+						;; size=21 bbWeight=514.32 PerfScore 4371.71
+G_M38014_IG13:
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
+       jae      SHORT G_M38014_IG16
+       mov      r8d, r15d
+       shl      r8, 4
+       lea      r13, bword ptr [r14+r8+0x10]
+       mov      r8d, dword ptr [r13+0x08]
        sub      r8d, eax
-       jne      SHORT G_M38014_IG11
-       lea      r11, bword ptr [rdi+0xA0]
-       lea      r13d, [rax+0x01]
+       jne      SHORT G_M38014_IG17
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
-						;; size=73 bbWeight=511.25 PerfScore 20066.49
+       cmpxchg  dword ptr [r8], r12d
+       cmp      eax, dword ptr [rbp-0x44]
+       jne      SHORT G_M38014_IG13
+						;; size=64 bbWeight=514.32 PerfScore 19158.40
+G_M38014_IG14:
+       jmp      SHORT G_M38014_IG18
+						;; size=2 bbWeight=514.32 PerfScore 1028.64
 G_M38014_IG15:
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       cmp      qword ptr [rbx], rcx
-       jne      SHORT G_M38014_IG19
-       mov      ecx, dword ptr [rbx+0x08]
-       inc      ecx
-       mov      esi, dword ptr [rbx+0x0C]
-       cmp      ecx, esi
-       jae      SHORT G_M38014_IG17
-						;; size=27 bbWeight=512.25 PerfScore 4994.42
-G_M38014_IG16:
-       mov      dword ptr [rbx+0x08], ecx
-       jmp      G_M38014_IG12
-						;; size=8 bbWeight=511.25 PerfScore 1533.76
-G_M38014_IG17:
-       mov      dword ptr [rbx+0x08], esi
-       jmp      G_M38014_IG25
-						;; size=8 bbWeight=512.25 PerfScore 1536.74
-G_M38014_IG18:
        mov      rcx, rdx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      r11, rax
-       jmp      G_M38014_IG13
-						;; size=26 bbWeight=102.25 PerfScore 383.44
+       jmp      SHORT G_M38014_IG12
+						;; size=23 bbWeight=102.86 PerfScore 385.74
+G_M38014_IG16:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M38014_IG17:
+       test     r8d, r8d
+       jge      SHORT G_M38014_IG13
+       jmp      G_M38014_IG33
+       align    [0 bytes for IG24]
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M38014_IG18:
+       mov      rcx, r13
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      dword ptr [r13+0x08], r12d
+						;; size=12 bbWeight=514.32 PerfScore 1157.22
 G_M38014_IG19:
-       mov      rcx, rbx
-       mov      r11, 0xD1FFAB1E      ; code for <unknown method>
-       call     [r11]<unknown method>
-       test     eax, eax
-       jne      G_M38014_IG12
-						;; size=24 bbWeight=512.25 PerfScore 2433.18
+       mov      eax, dword ptr [rbx+0x08]
+       inc      eax
+       mov      esi, dword ptr [rbx+0x0C]
+       cmp      eax, esi
+       jae      SHORT G_M38014_IG21
+						;; size=12 bbWeight=515.31 PerfScore 2834.20
 G_M38014_IG20:
-       jmp      G_M38014_IG27
-						;; size=5 bbWeight=1 PerfScore 2.00
+       mov      dword ptr [rbx+0x08], eax
+       jmp      G_M38014_IG11
+						;; size=8 bbWeight=514.31 PerfScore 1542.93
 G_M38014_IG21:
+       mov      dword ptr [rbx+0x08], esi
+       jmp      G_M38014_IG35
+						;; size=8 bbWeight=515.31 PerfScore 1545.93
+G_M38014_IG22:
+       mov      rcx, gword ptr [rbp+0x10]
+       mov      rdx, qword ptr [rcx]
+       mov      rax, qword ptr [rdx+0x30]
+       mov      rax, qword ptr [rax]
+       mov      r11, qword ptr [rax+0x50]
+       test     r11, r11
+       je       SHORT G_M38014_IG26
+						;; size=23 bbWeight=5.20 PerfScore 53.25
+G_M38014_IG23:
+       mov      rcx, rbx
+       call     [r11]
+       mov      rdx, rax
+       mov      rcx, gword ptr [rbp+0x10]
+       mov      rdi, gword ptr [rcx+0x10]
+       mov      r14, gword ptr [rdi+0x08]
+						;; size=21 bbWeight=5.20 PerfScore 44.16
+G_M38014_IG24:
+       mov      eax, dword ptr [rdi+0xA0]
+       mov      r15d, eax
+       and      r15d, dword ptr [rdi+0x18]
+       cmp      r15d, dword ptr [r14+0x08]
+       jae      SHORT G_M38014_IG16
+       mov      r8d, r15d
+       shl      r8, 4
+       lea      rsi, bword ptr [r14+r8+0x10]
+       mov      r8d, dword ptr [rsi+0x08]
+       sub      r8d, eax
+       jne      SHORT G_M38014_IG32
+       lea      r8, bword ptr [rdi+0xA0]
+       lea      r15d, [rax+0x01]
+       mov      dword ptr [rbp-0x44], eax
+       lock     
+       cmpxchg  dword ptr [r8], r15d
+       cmp      eax, dword ptr [rbp-0x44]
+       jne      SHORT G_M38014_IG24
+						;; size=64 bbWeight=5.20 PerfScore 193.52
+G_M38014_IG25:
+       jmp      SHORT G_M38014_IG30
+						;; size=2 bbWeight=5.20 PerfScore 10.39
+G_M38014_IG26:
        mov      rcx, rdx
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp      G_M38014_IG03
-						;; size=23 bbWeight=0.20 PerfScore 0.70
-G_M38014_IG22:
+       mov      r11, rax
+       jmp      SHORT G_M38014_IG23
+						;; size=23 bbWeight=1.04 PerfScore 3.90
+G_M38014_IG27:
+       mov      rdx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbx], rdx
+       jne      SHORT G_M38014_IG34
+       mov      eax, dword ptr [rbx+0x08]
+       inc      eax
+       mov      r13d, dword ptr [rbx+0x0C]
+       cmp      eax, r13d
+       jae      SHORT G_M38014_IG29
+						;; size=29 bbWeight=5.21 PerfScore 50.75
+G_M38014_IG28:
+       mov      dword ptr [rbx+0x08], eax
+       jmp      G_M38014_IG22
+						;; size=8 bbWeight=5.20 PerfScore 15.59
+G_M38014_IG29:
+       mov      dword ptr [rbx+0x08], r13d
+       jmp      SHORT G_M38014_IG35
+						;; size=6 bbWeight=5.21 PerfScore 15.62
+G_M38014_IG30:
+       mov      rcx, rsi
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      dword ptr [rsi+0x08], r15d
+       jmp      SHORT G_M38014_IG27
+						;; size=14 bbWeight=5.20 PerfScore 22.08
+G_M38014_IG31:
+       mov      rcx, gword ptr [rbp+0x10]
+       call     [<unknown method>]
+       jmp      SHORT G_M38014_IG27
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M38014_IG32:
+       test     r8d, r8d
+       jge      G_M38014_IG24
+       jmp      SHORT G_M38014_IG31
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M38014_IG33:
+       call     [<unknown method>]
+       jmp      G_M38014_IG19
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M38014_IG34:
+       mov      rcx, rbx
+       mov      r11, 0xD1FFAB1E      ; function address
+       call     [r11]<unknown method>
+       test     eax, eax
+       jne      G_M38014_IG22
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M38014_IG35:
+       mov      rdx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbx], rdx
+       jne      G_M38014_IG42
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M38014_IG36:
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
+G_M38014_IG37:
        mov      rcx, rdi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      r11, rax
        jmp      G_M38014_IG05
 						;; size=26 bbWeight=0.20 PerfScore 0.75
-G_M38014_IG23:
+G_M38014_IG38:
+       mov      rcx, rdx
+       mov      rdx, 0xD1FFAB1E      ; global ptr
+       call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp      G_M38014_IG03
+						;; size=23 bbWeight=0.20 PerfScore 0.70
+G_M38014_IG39:
        mov      rcx, rdi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
-       jmp      G_M38014_IG07
+       jmp      G_M38014_IG08
 						;; size=26 bbWeight=0.20 PerfScore 0.75
-G_M38014_IG24:
+G_M38014_IG40:
        mov      rcx, rdi
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      r11, rax
-       jmp      G_M38014_IG08
+       jmp      G_M38014_IG09
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
+G_M38014_IG41:
        mov      ecx, 23
        call     [System.ThrowHelper:ThrowArgumentNullException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M38014_IG27:
+G_M38014_IG42:
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
-       jmp      SHORT G_M38014_IG25
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M38014_IG28:
+       jmp      G_M38014_IG36
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M38014_IG43:
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
+G_M38014_IG44:
+       cmp      gword ptr [rbp-0x50], 0
+       je       SHORT G_M38014_IG45
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       mov      rbx, gword ptr [rbp-0x48]
+       mov      rbx, gword ptr [rbp-0x50]
        cmp      qword ptr [rbx], rcx
-       je       SHORT G_M38014_IG30
+       je       SHORT G_M38014_IG45
        mov      rcx, rbx
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M38014_IG30:
+G_M38014_IG45:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M38014_IG31:
-       add      rsp, 48
+G_M38014_IG46:
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
 
-; Total bytes of code 778, prolog size 34, PerfScore 40622.66, instruction count 208, allocated bytes for code 778 (MethodHash=ba4f6b81) for method System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]:.ctor(System.Collections.Generic.IEnumerable`1[System.__Canon]):this (Tier1)
+; Total bytes of code 1038, prolog size 39, PerfScore 37803.76, instruction count 279, allocated bytes for code 1042 (MethodHash=ba4f6b81) for method System.Collections.Concurrent.ConcurrentQueue`1[System.__Canon]:.ctor(System.Collections.Generic.IEnumerable`1[System.__Canon]):this (Tier1)
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
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 972
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1176
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T03] (  7, 515.50)     ref  ->  rbx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
+;  V00 this         [V00,T03] (  7, 512.78)     ref  ->  rbx         this class-hnd single-def <System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]>
 ;  V01 arg1         [V01,T04] (  4,   4   )     int  ->  rsi         single-def
-;  V02 loc0         [V02,T00] (  7,3057.99)     int  ->  rax        
+;* V02 loc0         [V02,T08] (  0,   0   )     int  ->  zero-ref   
 ;  V03 OutArgs      [V03    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V04 tmp1         [V04,T07] (  3,   4   )    long  ->  rcx         "spilling helperCall"
-;  V05 tmp2         [V05,T01] (  3,3056.99)     ref  ->  rdx         "arr expr"
-;  V06 cse0         [V06,T02] (  3,1528.49)     ref  ->  rcx         "CSE #01: aggressive"
-;  V07 rat0         [V07,T06] (  3,   4.40)    long  ->  rcx         "Spilling to split statement for tree"
-;  V08 rat1         [V08,T05] (  3,   5.60)    long  ->  rdx         "fgMakeTemp is creating a new local variable"
+;  V05 tmp2         [V05,T01] (  3,3040.65)     ref  ->  rdx         "arr expr"
+;  V06 cse0         [V06,T02] (  3,1520.33)     ref  ->  rcx         "CSE #01: aggressive"
+;  V07 rat0         [V07,T00] (  7,3041.65)    long  ->  rax         "Widened IV V02"
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
-						;; size=31 bbWeight=509.50 PerfScore 6241.35
+						;; size=31 bbWeight=506.78 PerfScore 6208.00
 G_M62791_IG07:
        add      rsp, 40
        pop      rbx
@@ -177,6 +179,6 @@ G_M62791_IG08:
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 140, prolog size 16, PerfScore 6269.20, instruction count 45, allocated bytes for code 140 (MethodHash=ae010ab8) for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Tier1)
+; Total bytes of code 140, prolog size 16, PerfScore 6235.85, instruction count 45, allocated bytes for code 140 (MethodHash=ae010ab8) for method System.Collections.Concurrent.ConcurrentQueueSegment`1[System.__Canon]:.ctor(int):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 12, Options: Compiled)``

Hot functions:

- (21.49%) ``Regex.RunSingleMatch`` (Tier-1)
  - **Has diffs**
- (19.36%) ``dynamicClass.Regex1_TryMatchAtCurrentPosition`` (FullOpt)
  - No diffs
- (18.09%) ``dynamicClass.Regex1_Scan`` (FullOpt)
  - No diffs
- (7.38%) ``Match.AddMatch`` (Tier-1)
  - **Has diffs**
- (7.17%) ``dynamicClass.Regex1_TryFindNextPossibleStartingPosition`` (FullOpt)
  - No diffs
- (5.82%) ``Perf_Regex_Industry_BoostDocs_Simple.IsMatch`` (Tier-1)
  - No diffs
- (3.00%) ``Regex.IsMatch`` (Tier-1)
  - No diffs
- (1.78%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs
- (1.49%) ``RegexRunner.InitializeTimeout`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]Regex.RunSingleMatch(value class System.Text.RegularExpressions.RegexRunnerMode,int32,class System.String,int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 98224
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 93008
 ; 5 inlinees with PGO data; 13 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
@@ -449,13 +449,13 @@ G_M21592_IG22:
 ;  V01 arg1         [V01,T04] (  5,  4   )     int  ->  rsi         single-def
 ;  V02 arg2         [V02,T09] (  3,  3   )     int  ->  rdi         single-def
 ;  V03 arg3         [V03,T03] (  6,  5   )     ref  ->  rbx         class-hnd single-def <System.String>
-;  V04 arg4         [V04,T18] (  4,  3   )     int  ->  r14         single-def
-;  V05 arg5         [V05,T19] (  3,  3   )     int  ->  r15         single-def
+;  V04 arg4         [V04,T20] (  4,  3   )     int  ->  r14         single-def
+;  V05 arg5         [V05,T21] (  3,  3   )     int  ->  r15         single-def
 ;  V06 arg6         [V06,T27] (  2,  2   )     int  ->  r13         single-def
-;  V07 loc0         [V07,T00] ( 44, 20.00)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V07 loc0         [V07,T00] ( 44, 20.02)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
 ;* V08 loc1         [V08    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V09 loc2         [V09,T41] (  3,  0   )     int  ->  rcx        
-;  V10 loc3         [V10,T42] (  3,  0   )     int  ->  rax        
+;  V09 loc2         [V09,T42] (  3,  0   )     int  ->  rcx        
+;  V10 loc3         [V10,T43] (  3,  0   )     int  ->  rax        
 ;  V11 loc4         [V11,T23] (  3,  2   )     ref  ->  r12         class-hnd <System.Text.RegularExpressions.Match>
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T15] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
@@ -466,33 +466,33 @@ G_M21592_IG22:
 ;* V18 tmp6         [V18    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;  V19 tmp7         [V19,T07] (  3,  6   )     int  ->  r13         "Inlining Arg"
 ;* V20 tmp8         [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp9         [V21,T02] (  8,  8.00)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp10        [V22,T43] (  2,  0   )     int  ->  rdx         "dup spill"
-;  V23 tmp11        [V23,T37] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
-;  V24 tmp12        [V24,T38] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V21 tmp9         [V21,T02] (  8,  8.05)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp10        [V22,T44] (  2,  0   )     int  ->  rdx         "dup spill"
+;  V23 tmp11        [V23,T38] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V24 tmp12        [V24,T39] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V25 tmp13        [V25    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V26 tmp14        [V26,T39] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp14        [V26,T40] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp15        [V27    ] (  0,  0   )     ref  ->  zero-ref   
-;  V28 tmp16        [V28,T36] (  3,  0.00)     ref  ->  rdx        
-;  V29 tmp17        [V29,T31] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp18        [V30,T33] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp16        [V28,T37] (  3,  0.00)     ref  ->  rdx        
+;  V29 tmp17        [V29,T32] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp18        [V30,T34] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp19        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp20        [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp21        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp22        [V34,T34] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp23        [V35,T12] (  2,  4.00)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V34 tmp22        [V34,T35] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp23        [V35,T12] (  2,  4.03)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V36 tmp24        [V36    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp25        [V37,T20] (  3,  2.99)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V38 tmp26        [V38,T10] (  5,  4.96)     int  ->  rdx         "Inline stloc first use temp"
-;  V39 tmp27        [V39,T11] (  3,  4.00)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp25        [V37,T17] (  3,  3.01)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;* V38 tmp26        [V38,T30] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V39 tmp27        [V39,T11] (  3,  4.03)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp28        [V40    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V41 tmp29        [V41,T22] (  4,  2   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp30        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V43 tmp31        [V43,T17] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V43 tmp31        [V43,T19] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V44 tmp32        [V44    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V45 tmp33        [V45    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Text.RegularExpressions.CompiledRegexRunner>
 ;  V46 tmp34        [V46,T24] (  3,  2   )   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
-;  V47 tmp35        [V47,T13] (  8,  4.00)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
+;  V47 tmp35        [V47,T13] (  8,  4.01)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
 ;  V48 tmp36        [V48,T25] (  2,  2   )   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
 ;  V49 tmp37        [V49,T28] (  2,  2   )     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
 ;  V50 tmp38        [V50,T26] (  2,  2   )   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
@@ -503,16 +503,17 @@ G_M21592_IG22:
 ;* V55 tmp43        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V56 tmp44        [V56    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
 ;* V57 tmp45        [V57    ] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp46        [V58,T40] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
+;  V58 tmp46        [V58,T41] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
 ;  V59 tmp47        [V59    ] (  6,  6   )  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;  V60 tmp48        [V60,T05] (  3,  6   )     ref  ->  rax         single-def "argument with side effect"
 ;  V61 tmp49        [V61,T06] (  3,  6   )     ref  ->  rcx         single-def "arr expr"
-;  V62 PSPSym       [V62,T30] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
-;  V63 cse0         [V63,T35] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
-;  V64 cse1         [V64,T16] (  3,  3.00)     ref  ->   r8         "CSE #08: moderate"
-;  V65 cse2         [V65,T32] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
+;  V62 PSPSym       [V62,T31] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
+;  V63 cse0         [V63,T36] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
+;  V64 cse1         [V64,T16] (  3,  3.02)     ref  ->   r8         "CSE #08: moderate"
+;  V65 cse2         [V65,T33] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
 ;  V66 cse3         [V66,T14] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
-;  V67 cse4         [V67,T21] (  3,  2.99)     int  ->  rcx         "CSE #07: moderate"
+;  V67 cse4         [V67,T18] (  3,  3.01)     int  ->  rcx         "CSE #07: moderate"
+;  V68 rat0         [V68,T10] (  5,  4.99)    long  ->  rdx         "Widened IV V38"
 ;
 ; Lcl frame size = 120
 
@@ -601,27 +602,26 @@ G_M21592_IG05:
        mov      ecx, dword ptr [r8+0x08]
        test     ecx, ecx
        jle      SHORT G_M21592_IG07
-						;; size=41 bbWeight=1.00 PerfScore 11.51
+						;; size=41 bbWeight=1.01 PerfScore 11.59
 G_M21592_IG06:
-       mov      eax, edx
-       xor      r10d, r10d
-       mov      dword ptr [r8+4*rax+0x10], r10d
+       xor      eax, eax
+       mov      dword ptr [r8+4*rdx+0x10], eax
        inc      edx
        cmp      ecx, edx
        jg       SHORT G_M21592_IG06
-						;; size=16 bbWeight=0.99 PerfScore 2.97
+						;; size=13 bbWeight=1.00 PerfScore 2.74
 G_M21592_IG07:
        mov      byte  ptr [r13+0x60], 0
        mov      r13, gword ptr [r13+0x38]
        test     r13, r13
        jne      G_M21592_IG19
-						;; size=18 bbWeight=1.00 PerfScore 4.25
+						;; size=18 bbWeight=1.01 PerfScore 4.28
 G_M21592_IG08:
        mov      r13, gword ptr [rbp-0x58]
        mov      r8, gword ptr [r13+0x20]
        test     r8, r8
        je       G_M21592_IG20
-						;; size=17 bbWeight=1.00 PerfScore 4.25
+						;; size=17 bbWeight=1.01 PerfScore 4.28
 G_M21592_IG09:
        mov      rdx, gword ptr [r13+0x10]
        mov      edx, dword ptr [rdx+0x08]
@@ -691,7 +691,7 @@ G_M21592_IG15:
        mov      rdx, gword ptr [rbp-0x78]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp-0x70]
-						;; size=100 bbWeight=0.00 PerfScore 0.02
+						;; size=100 bbWeight=0.00 PerfScore 0.03
 G_M21592_IG16:
        lea      rcx, bword ptr [r13+0x28]
        call     CORINFO_HELP_ASSIGN_REF
@@ -904,6 +904,6 @@ G_M21592_IG35:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1217, prolog size 61, PerfScore 152.51, instruction count 317, allocated bytes for code 1217 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
+; Total bytes of code 1214, prolog size 61, PerfScore 152.43, instruction count 316, allocated bytes for code 1214 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Match.AddMatch(int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 2753024
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 2882048
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  5,  5   )     ref  ->  rsi         this class-hnd single-def <System.Text.RegularExpressions.Match>
@@ -451,7 +451,7 @@ G_M41154_IG10:
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
 ;  V09 loc5         [V09,T19] (  3,  0   )     ref  ->  [rsp+0x20]  class-hnd spill-single-def <<unknown class>>
 ;  V10 loc6         [V10,T18] (  4,  0   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
-;  V11 loc7         [V11,T17] (  8,  0   )     int  ->  rdx        
+;* V11 loc7         [V11,T22] (  0,  0   )     int  ->  zero-ref   
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T21] (  2,  0   )     int  ->   r8         "Strict ordering of exceptions for Array store"
 ;  V14 tmp2         [V14,T20] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
@@ -464,6 +464,7 @@ G_M41154_IG10:
 ;  V21 cse3         [V21,T14] (  3,  3   )     int  ->  rax         "CSE #11: aggressive"
 ;  V22 cse4         [V22,T16] (  2,  2   )     int  ->  rcx         "CSE #12: aggressive"
 ;  V23 cse5         [V23,T02] (  7,  6   )    long  ->  r15         "CSE #01: aggressive"
+;  V24 rat0         [V24,T17] (  8,  0   )    long  ->  rdx         "Widened IV V11"
 ;
 ; Lcl frame size = 40
 
@@ -561,14 +562,12 @@ G_M41154_IG09:
        mov      rcx, gword ptr [rsp+0x20]
        cmp      edx, dword ptr [rcx+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r8d, edx
-       mov      r8d, dword ptr [rcx+4*r8+0x10]
+       mov      r8d, dword ptr [rcx+4*rdx+0x10]
        cmp      edx, dword ptr [rax+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r10d, edx
-       mov      dword ptr [rax+4*r10+0x10], r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
        inc      edx
-						;; size=33 bbWeight=0 PerfScore 0.00
+						;; size=27 bbWeight=0 PerfScore 0.00
 G_M41154_IG10:
        cmp      edx, esi
        jl       SHORT G_M41154_IG09
@@ -579,6 +578,6 @@ G_M41154_IG10:
        jmp      G_M41154_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 297, prolog size 27, PerfScore 55.00, instruction count 91, allocated bytes for code 297 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
+; Total bytes of code 291, prolog size 27, PerfScore 55.00, instruction count 89, allocated bytes for code 291 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 13, Options: Compiled)``

Hot functions:

- (19.99%) ``dynamicClass.Regex1_Scan`` (FullOpt)
  - No diffs
- (19.92%) ``dynamicClass.Regex1_TryMatchAtCurrentPosition`` (FullOpt)
  - No diffs
- (19.49%) ``Regex.RunSingleMatch`` (Tier-1)
  - **Has diffs**
- (7.86%) ``Match.AddMatch`` (Tier-1)
  - **Has diffs**
- (6.40%) ``dynamicClass.Regex1_TryFindNextPossibleStartingPosition`` (FullOpt)
  - No diffs
- (6.13%) ``Perf_Regex_Industry_BoostDocs_Simple.IsMatch`` (Tier-1)
  - No diffs
- (3.61%) ``Regex.IsMatch`` (Tier-1)
  - No diffs
- (1.91%) ``RegexRunner.InitializeTimeout`` (Tier-1)
  - No diffs
- (1.51%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]Regex.RunSingleMatch(value class System.Text.RegularExpressions.RegexRunnerMode,int32,class System.String,int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 102432
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 98368
 ; 5 inlinees with PGO data; 13 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] ( 10,  7   )     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
 ;  V01 arg1         [V01,T04] (  5,  4   )     int  ->  rsi         single-def
-;  V02 arg2         [V02,T10] (  3,  3   )     int  ->  rdi         single-def
+;  V02 arg2         [V02,T09] (  3,  3   )     int  ->  rdi         single-def
 ;  V03 arg3         [V03,T03] (  6,  5   )     ref  ->  rbx         class-hnd single-def <System.String>
-;  V04 arg4         [V04,T20] (  4,  3   )     int  ->  r14         single-def
-;  V05 arg5         [V05,T21] (  3,  3   )     int  ->  r15         single-def
+;  V04 arg4         [V04,T18] (  4,  3   )     int  ->  r14         single-def
+;  V05 arg5         [V05,T19] (  3,  3   )     int  ->  r15         single-def
 ;  V06 arg6         [V06,T27] (  2,  2   )     int  ->  r13         single-def
-;  V07 loc0         [V07,T00] ( 44, 20.03)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V07 loc0         [V07,T00] ( 44, 20.01)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
 ;* V08 loc1         [V08    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V09 loc2         [V09,T41] (  3,  0   )     int  ->  rcx        
-;  V10 loc3         [V10,T42] (  3,  0   )     int  ->  rax        
+;  V09 loc2         [V09,T42] (  3,  0   )     int  ->  rcx        
+;  V10 loc3         [V10,T43] (  3,  0   )     int  ->  rax        
 ;  V11 loc4         [V11,T23] (  3,  2   )     ref  ->  r12         class-hnd <System.Text.RegularExpressions.Match>
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T15] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V14 tmp2         [V14,T09] (  6,  5   )     ref  ->  [rbp-0x60] 
+;  V14 tmp2         [V14,T08] (  6,  5   )     ref  ->  [rbp-0x60] 
 ;* V15 tmp3         [V15    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V16 tmp4         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V17 tmp5         [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
 ;* V18 tmp6         [V18    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;  V19 tmp7         [V19,T07] (  3,  6   )     int  ->  r13         "Inlining Arg"
 ;* V20 tmp8         [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp9         [V21,T02] (  8,  8.08)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp10        [V22,T43] (  2,  0   )     int  ->  rdx         "dup spill"
-;  V23 tmp11        [V23,T37] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
-;  V24 tmp12        [V24,T38] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V21 tmp9         [V21,T02] (  8,  8.02)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp10        [V22,T44] (  2,  0   )     int  ->  rdx         "dup spill"
+;  V23 tmp11        [V23,T38] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V24 tmp12        [V24,T39] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V25 tmp13        [V25    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V26 tmp14        [V26,T39] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp14        [V26,T40] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp15        [V27    ] (  0,  0   )     ref  ->  zero-ref   
-;  V28 tmp16        [V28,T36] (  3,  0.00)     ref  ->  rdx        
-;  V29 tmp17        [V29,T31] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp18        [V30,T33] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp16        [V28,T37] (  3,  0.00)     ref  ->  rdx        
+;  V29 tmp17        [V29,T32] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp18        [V30,T34] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp19        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp20        [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp21        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp22        [V34,T34] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp23        [V35,T12] (  2,  4.05)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V34 tmp22        [V34,T35] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp23        [V35,T12] (  2,  4.01)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V36 tmp24        [V36    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp25        [V37,T16] (  3,  3.03)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V38 tmp26        [V38,T08] (  5,  5.02)     int  ->  rdx         "Inline stloc first use temp"
-;  V39 tmp27        [V39,T11] (  3,  4.05)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp25        [V37,T20] (  3,  3.00)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;* V38 tmp26        [V38,T30] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V39 tmp27        [V39,T11] (  3,  4.01)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp28        [V40    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V41 tmp29        [V41,T22] (  4,  2   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp30        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V43 tmp31        [V43,T19] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V43 tmp31        [V43,T17] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V44 tmp32        [V44    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V45 tmp33        [V45    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Text.RegularExpressions.CompiledRegexRunner>
 ;  V46 tmp34        [V46,T24] (  3,  2   )   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
-;  V47 tmp35        [V47,T13] (  8,  4.01)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
+;  V47 tmp35        [V47,T13] (  8,  4.00)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
 ;  V48 tmp36        [V48,T25] (  2,  2   )   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
 ;  V49 tmp37        [V49,T28] (  2,  2   )     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
 ;  V50 tmp38        [V50,T26] (  2,  2   )   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
@@ -503,16 +503,17 @@ G_M21592_IG22:
 ;* V55 tmp43        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V56 tmp44        [V56    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
 ;* V57 tmp45        [V57    ] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp46        [V58,T40] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
+;  V58 tmp46        [V58,T41] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
 ;  V59 tmp47        [V59    ] (  6,  6   )  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;  V60 tmp48        [V60,T05] (  3,  6   )     ref  ->  rax         single-def "argument with side effect"
 ;  V61 tmp49        [V61,T06] (  3,  6   )     ref  ->  rcx         single-def "arr expr"
-;  V62 PSPSym       [V62,T30] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
-;  V63 cse0         [V63,T35] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
-;  V64 cse1         [V64,T18] (  3,  3.03)     ref  ->   r8         "CSE #08: moderate"
-;  V65 cse2         [V65,T32] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
+;  V62 PSPSym       [V62,T31] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
+;  V63 cse0         [V63,T36] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
+;  V64 cse1         [V64,T16] (  3,  3.01)     ref  ->   r8         "CSE #08: moderate"
+;  V65 cse2         [V65,T33] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
 ;  V66 cse3         [V66,T14] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
-;  V67 cse4         [V67,T17] (  3,  3.03)     int  ->  rcx         "CSE #07: moderate"
+;  V67 cse4         [V67,T21] (  3,  3.00)     int  ->  rcx         "CSE #07: moderate"
+;  V68 rat0         [V68,T10] (  5,  4.96)    long  ->  rdx         "Widened IV V38"
 ;
 ; Lcl frame size = 120
 
@@ -601,27 +602,26 @@ G_M21592_IG05:
        mov      ecx, dword ptr [r8+0x08]
        test     ecx, ecx
        jle      SHORT G_M21592_IG07
-						;; size=41 bbWeight=1.01 PerfScore 11.66
+						;; size=41 bbWeight=1.00 PerfScore 11.54
 G_M21592_IG06:
-       mov      eax, edx
-       xor      r10d, r10d
-       mov      dword ptr [r8+4*rax+0x10], r10d
+       xor      eax, eax
+       mov      dword ptr [r8+4*rdx+0x10], eax
        inc      edx
        cmp      ecx, edx
        jg       SHORT G_M21592_IG06
-						;; size=16 bbWeight=1.00 PerfScore 3.00
+						;; size=13 bbWeight=0.99 PerfScore 2.72
 G_M21592_IG07:
        mov      byte  ptr [r13+0x60], 0
        mov      r13, gword ptr [r13+0x38]
        test     r13, r13
        jne      G_M21592_IG19
-						;; size=18 bbWeight=1.01 PerfScore 4.31
+						;; size=18 bbWeight=1.00 PerfScore 4.27
 G_M21592_IG08:
        mov      r13, gword ptr [rbp-0x58]
        mov      r8, gword ptr [r13+0x20]
        test     r8, r8
        je       G_M21592_IG20
-						;; size=17 bbWeight=1.01 PerfScore 4.31
+						;; size=17 bbWeight=1.00 PerfScore 4.27
 G_M21592_IG09:
        mov      rdx, gword ptr [r13+0x10]
        mov      edx, dword ptr [rdx+0x08]
@@ -904,6 +904,6 @@ G_M21592_IG35:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1217, prolog size 61, PerfScore 152.80, instruction count 317, allocated bytes for code 1217 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
+; Total bytes of code 1214, prolog size 61, PerfScore 152.33, instruction count 316, allocated bytes for code 1214 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Match.AddMatch(int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 3951616
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 2798080
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  5,  5   )     ref  ->  rsi         this class-hnd single-def <System.Text.RegularExpressions.Match>
@@ -451,7 +451,7 @@ G_M41154_IG10:
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
 ;  V09 loc5         [V09,T19] (  3,  0   )     ref  ->  [rsp+0x20]  class-hnd spill-single-def <<unknown class>>
 ;  V10 loc6         [V10,T18] (  4,  0   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
-;  V11 loc7         [V11,T17] (  8,  0   )     int  ->  rdx        
+;* V11 loc7         [V11,T22] (  0,  0   )     int  ->  zero-ref   
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T21] (  2,  0   )     int  ->   r8         "Strict ordering of exceptions for Array store"
 ;  V14 tmp2         [V14,T20] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
@@ -464,6 +464,7 @@ G_M41154_IG10:
 ;  V21 cse3         [V21,T14] (  3,  3   )     int  ->  rax         "CSE #11: aggressive"
 ;  V22 cse4         [V22,T16] (  2,  2   )     int  ->  rcx         "CSE #12: aggressive"
 ;  V23 cse5         [V23,T02] (  7,  6   )    long  ->  r15         "CSE #01: aggressive"
+;  V24 rat0         [V24,T17] (  8,  0   )    long  ->  rdx         "Widened IV V11"
 ;
 ; Lcl frame size = 40
 
@@ -561,14 +562,12 @@ G_M41154_IG09:
        mov      rcx, gword ptr [rsp+0x20]
        cmp      edx, dword ptr [rcx+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r8d, edx
-       mov      r8d, dword ptr [rcx+4*r8+0x10]
+       mov      r8d, dword ptr [rcx+4*rdx+0x10]
        cmp      edx, dword ptr [rax+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r10d, edx
-       mov      dword ptr [rax+4*r10+0x10], r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
        inc      edx
-						;; size=33 bbWeight=0 PerfScore 0.00
+						;; size=27 bbWeight=0 PerfScore 0.00
 G_M41154_IG10:
        cmp      edx, esi
        jl       SHORT G_M41154_IG09
@@ -579,6 +578,6 @@ G_M41154_IG10:
        jmp      G_M41154_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 297, prolog size 27, PerfScore 55.00, instruction count 91, allocated bytes for code 297 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
+; Total bytes of code 291, prolog size 27, PerfScore 55.00, instruction count 89, allocated bytes for code 291 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsMatch(Options: IgnoreCase, Compiled)``

Hot functions:

- (30.10%) ``dynamicClass.Regex4_TryMatchAtCurrentPosition`` (FullOpt)
  - No diffs
- (16.64%) ``Regex.RunSingleMatch`` (Tier-1)
  - **Has diffs**
- (10.74%) ``SpanHelpers.IndexOf`` (Tier-1)
  - No diffs
- (9.80%) ``dynamicClass.Regex4_Scan`` (FullOpt)
  - No diffs
- (8.72%) ``dynamicClass.Regex4_TryFindNextPossibleStartingPosition`` (FullOpt)
  - No diffs
- (6.10%) ``Match.AddMatch`` (Tier-1)
  - **Has diffs**
- (3.93%) ``Perf_Regex_Common.Uri_IsMatch`` (Tier-1)
  - No diffs
- (3.72%) ``SpanHelpers.SequenceEqual`` (Tier-1)
  - No diffs
- (1.02%) ``RegexRunner.InitializeTimeout`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]Regex.RunSingleMatch(value class System.Text.RegularExpressions.RegexRunnerMode,int32,class System.String,int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 99856
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 97472
 ; 5 inlinees with PGO data; 13 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] ( 10,  7   )     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
 ;  V01 arg1         [V01,T04] (  5,  4   )     int  ->  rsi         single-def
 ;  V02 arg2         [V02,T09] (  3,  3   )     int  ->  rdi         single-def
-;  V03 arg3         [V03,T03] (  6,  5.00)     ref  ->  rbx         class-hnd single-def <System.String>
-;  V04 arg4         [V04,T17] (  4,  3.00)     int  ->  r14         single-def
-;  V05 arg5         [V05,T19] (  3,  3.00)     int  ->  r15         single-def
-;  V06 arg6         [V06,T27] (  2,  2.00)     int  ->  r13         single-def
-;  V07 loc0         [V07,T00] ( 44, 20.00)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V03 arg3         [V03,T03] (  6,  5   )     ref  ->  rbx         class-hnd single-def <System.String>
+;  V04 arg4         [V04,T17] (  4,  3   )     int  ->  r14         single-def
+;  V05 arg5         [V05,T19] (  3,  3   )     int  ->  r15         single-def
+;  V06 arg6         [V06,T27] (  2,  2   )     int  ->  r13         single-def
+;  V07 loc0         [V07,T00] ( 44, 20.01)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
 ;* V08 loc1         [V08    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V09 loc2         [V09,T41] (  3,  0   )     int  ->  rcx        
-;  V10 loc3         [V10,T42] (  3,  0   )     int  ->  rax        
+;  V09 loc2         [V09,T42] (  3,  0   )     int  ->  rcx        
+;  V10 loc3         [V10,T43] (  3,  0   )     int  ->  rax        
 ;  V11 loc4         [V11,T23] (  3,  2   )     ref  ->  r12         class-hnd <System.Text.RegularExpressions.Match>
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T13] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
@@ -464,55 +464,56 @@ G_M21592_IG22:
 ;* V16 tmp4         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V17 tmp5         [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
 ;* V18 tmp6         [V18    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V19 tmp7         [V19,T07] (  3,  6.00)     int  ->  r13         "Inlining Arg"
+;  V19 tmp7         [V19,T07] (  3,  6   )     int  ->  r13         "Inlining Arg"
 ;* V20 tmp8         [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp9         [V21,T02] (  8,  7.99)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp10        [V22,T43] (  2,  0   )     int  ->  rdx         "dup spill"
-;  V23 tmp11        [V23,T37] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
-;  V24 tmp12        [V24,T38] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V21 tmp9         [V21,T02] (  8,  7.96)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp10        [V22,T44] (  2,  0   )     int  ->  rdx         "dup spill"
+;  V23 tmp11        [V23,T38] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V24 tmp12        [V24,T39] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V25 tmp13        [V25    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V26 tmp14        [V26,T39] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp14        [V26,T40] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp15        [V27    ] (  0,  0   )     ref  ->  zero-ref   
-;  V28 tmp16        [V28,T36] (  3,  0.00)     ref  ->  rdx        
-;  V29 tmp17        [V29,T31] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp18        [V30,T33] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp16        [V28,T37] (  3,  0.01)     ref  ->  rdx        
+;  V29 tmp17        [V29,T32] (  4,  0.05)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp18        [V30,T34] (  2,  0.03)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp19        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp20        [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp21        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp22        [V34,T34] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp23        [V35,T15] (  2,  4.00)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V34 tmp22        [V34,T35] (  2,  0.03)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp23        [V35,T15] (  2,  3.97)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V36 tmp24        [V36    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp25        [V37,T20] (  3,  2.98)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V38 tmp26        [V38,T10] (  5,  4.94)     int  ->  rdx         "Inline stloc first use temp"
-;  V39 tmp27        [V39,T14] (  3,  4.00)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp25        [V37,T20] (  3,  2.96)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;* V38 tmp26        [V38,T31] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V39 tmp27        [V39,T14] (  3,  3.97)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp28        [V40    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V41 tmp29        [V41,T22] (  4,  2   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp30        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V43 tmp31        [V43,T16] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V44 tmp32        [V44    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V45 tmp33        [V45    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Text.RegularExpressions.CompiledRegexRunner>
-;  V46 tmp34        [V46,T24] (  3,  2.00)   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
-;  V47 tmp35        [V47,T11] (  8,  4.00)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
-;  V48 tmp36        [V48,T25] (  2,  2.00)   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V49 tmp37        [V49,T28] (  2,  2.00)     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
-;  V50 tmp38        [V50,T26] (  2,  2.00)   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
-;  V51 tmp39        [V51,T29] (  2,  2.00)     int  ->  r15         "field V16._length (fldOffset=0x8)" P-INDEP
+;  V46 tmp34        [V46,T24] (  3,  2   )   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
+;  V47 tmp35        [V47,T11] (  8,  4   )     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
+;  V48 tmp36        [V48,T25] (  2,  2   )   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
+;  V49 tmp37        [V49,T28] (  2,  2   )     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V50 tmp38        [V50,T26] (  2,  2   )   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
+;  V51 tmp39        [V51,T29] (  2,  2   )     int  ->  r15         "field V16._length (fldOffset=0x8)" P-INDEP
 ;* V52 tmp40        [V52    ] (  0,  0   )   byref  ->  zero-ref    "field V17._reference (fldOffset=0x0)" P-INDEP
 ;* V53 tmp41        [V53    ] (  0,  0   )     int  ->  zero-ref    "field V17._length (fldOffset=0x8)" P-INDEP
 ;* V54 tmp42        [V54    ] (  0,  0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V55 tmp43        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V56 tmp44        [V56    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
 ;* V57 tmp45        [V57    ] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp46        [V58,T40] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
+;  V58 tmp46        [V58,T41] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
 ;  V59 tmp47        [V59    ] (  6,  6   )  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;  V60 tmp48        [V60,T05] (  3,  6   )     ref  ->  rax         single-def "argument with side effect"
 ;  V61 tmp49        [V61,T06] (  3,  6   )     ref  ->  rcx         single-def "arr expr"
 ;  V62 PSPSym       [V62,T30] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
-;  V63 cse0         [V63,T35] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
+;  V63 cse0         [V63,T36] (  3,  0.02)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
 ;  V64 cse1         [V64,T18] (  3,  3   )     ref  ->   r8         "CSE #08: moderate"
-;  V65 cse2         [V65,T32] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
+;  V65 cse2         [V65,T33] (  6,  0.03)     ref  ->  r13         "CSE #03: conservative"
 ;  V66 cse3         [V66,T12] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
-;  V67 cse4         [V67,T21] (  3,  2.98)     int  ->  rcx         "CSE #07: moderate"
+;  V67 cse4         [V67,T21] (  3,  2.96)     int  ->  rcx         "CSE #07: moderate"
+;  V68 rat0         [V68,T10] (  5,  4.90)    long  ->  rdx         "Widened IV V38"
 ;
 ; Lcl frame size = 120
 
@@ -587,7 +588,7 @@ G_M21592_IG04:
        mov      r13, gword ptr [rdx+0x28]
        test     r13, r13
        je       G_M21592_IG14
-						;; size=121 bbWeight=1.00 PerfScore 28.75
+						;; size=121 bbWeight=1 PerfScore 28.75
 G_M21592_IG05:
        mov      rax, gword ptr [rdx+0x08]
        lea      rcx, bword ptr [r13+0x08]
@@ -601,21 +602,20 @@ G_M21592_IG05:
        mov      ecx, dword ptr [r8+0x08]
        test     ecx, ecx
        jle      SHORT G_M21592_IG07
-						;; size=41 bbWeight=1.00 PerfScore 11.49
+						;; size=41 bbWeight=0.99 PerfScore 11.43
 G_M21592_IG06:
-       mov      eax, edx
-       xor      r10d, r10d
-       mov      dword ptr [r8+4*rax+0x10], r10d
+       xor      eax, eax
+       mov      dword ptr [r8+4*rdx+0x10], eax
        inc      edx
        cmp      ecx, edx
        jg       SHORT G_M21592_IG06
-						;; size=16 bbWeight=0.98 PerfScore 2.95
+						;; size=13 bbWeight=0.98 PerfScore 2.68
 G_M21592_IG07:
        mov      byte  ptr [r13+0x60], 0
        mov      r13, gword ptr [r13+0x38]
        test     r13, r13
        jne      G_M21592_IG18
-						;; size=18 bbWeight=1.00 PerfScore 4.25
+						;; size=18 bbWeight=0.99 PerfScore 4.22
 G_M21592_IG08:
        mov      r13, gword ptr [rbp-0x58]
        mov      r8, gword ptr [r13+0x20]
@@ -689,12 +689,12 @@ G_M21592_IG14:
        mov      rdx, gword ptr [rbp-0x78]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp-0x70]
-						;; size=100 bbWeight=0.00 PerfScore 0.03
+						;; size=100 bbWeight=0.01 PerfScore 0.16
 G_M21592_IG15:
        lea      rcx, bword ptr [r13+0x28]
        call     CORINFO_HELP_ASSIGN_REF
        jmp      G_M21592_IG08
-						;; size=14 bbWeight=0.00 PerfScore 0.00
+						;; size=14 bbWeight=0.01 PerfScore 0.02
 G_M21592_IG16:
        mov      ecx, 33
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
@@ -902,6 +902,6 @@ G_M21592_IG34:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1217, prolog size 61, PerfScore 152.47, instruction count 317, allocated bytes for code 1217 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
+; Total bytes of code 1214, prolog size 61, PerfScore 152.27, instruction count 316, allocated bytes for code 1214 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Match.AddMatch(int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1458176
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 3638272
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  5,  5   )     ref  ->  rsi         this class-hnd single-def <System.Text.RegularExpressions.Match>
@@ -451,7 +451,7 @@ G_M41154_IG10:
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
 ;  V09 loc5         [V09,T19] (  3,  0   )     ref  ->  [rsp+0x20]  class-hnd spill-single-def <<unknown class>>
 ;  V10 loc6         [V10,T18] (  4,  0   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
-;  V11 loc7         [V11,T17] (  8,  0   )     int  ->  rdx        
+;* V11 loc7         [V11,T22] (  0,  0   )     int  ->  zero-ref   
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T21] (  2,  0   )     int  ->   r8         "Strict ordering of exceptions for Array store"
 ;  V14 tmp2         [V14,T20] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
@@ -464,6 +464,7 @@ G_M41154_IG10:
 ;  V21 cse3         [V21,T14] (  3,  3   )     int  ->  rax         "CSE #11: aggressive"
 ;  V22 cse4         [V22,T16] (  2,  2   )     int  ->  rcx         "CSE #12: aggressive"
 ;  V23 cse5         [V23,T02] (  7,  6   )    long  ->  r15         "CSE #01: aggressive"
+;  V24 rat0         [V24,T17] (  8,  0   )    long  ->  rdx         "Widened IV V11"
 ;
 ; Lcl frame size = 40
 
@@ -561,14 +562,12 @@ G_M41154_IG09:
        mov      rcx, gword ptr [rsp+0x20]
        cmp      edx, dword ptr [rcx+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r8d, edx
-       mov      r8d, dword ptr [rcx+4*r8+0x10]
+       mov      r8d, dword ptr [rcx+4*rdx+0x10]
        cmp      edx, dword ptr [rax+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r10d, edx
-       mov      dword ptr [rax+4*r10+0x10], r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
        inc      edx
-						;; size=33 bbWeight=0 PerfScore 0.00
+						;; size=27 bbWeight=0 PerfScore 0.00
 G_M41154_IG10:
        cmp      edx, esi
        jl       SHORT G_M41154_IG09
@@ -579,6 +578,6 @@ G_M41154_IG10:
        jmp      G_M41154_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 297, prolog size 27, PerfScore 55.00, instruction count 91, allocated bytes for code 297 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
+; Total bytes of code 291, prolog size 27, PerfScore 55.00, instruction count 89, allocated bytes for code 291 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsMatch(Options: Compiled)``

Hot functions:

- (29.84%) ``dynamicClass.Regex4_TryMatchAtCurrentPosition`` (FullOpt)
  - No diffs
- (16.47%) ``Regex.RunSingleMatch`` (Tier-1)
  - **Has diffs**
- (11.10%) ``SpanHelpers.IndexOf`` (Tier-1)
  - No diffs
- (10.89%) ``dynamicClass.Regex4_Scan`` (FullOpt)
  - No diffs
- (8.69%) ``dynamicClass.Regex4_TryFindNextPossibleStartingPosition`` (FullOpt)
  - No diffs
- (6.23%) ``Match.AddMatch`` (Tier-1)
  - **Has diffs**
- (3.95%) ``SpanHelpers.SequenceEqual`` (Tier-1)
  - No diffs
- (3.38%) ``Perf_Regex_Common.Uri_IsMatch`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]Regex.RunSingleMatch(value class System.Text.RegularExpressions.RegexRunnerMode,int32,class System.String,int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 95904
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 99056
 ; 5 inlinees with PGO data; 13 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] ( 10,  7   )     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
 ;  V01 arg1         [V01,T04] (  5,  4   )     int  ->  rsi         single-def
-;  V02 arg2         [V02,T09] (  3,  3   )     int  ->  rdi         single-def
+;  V02 arg2         [V02,T10] (  3,  3   )     int  ->  rdi         single-def
 ;  V03 arg3         [V03,T03] (  6,  5   )     ref  ->  rbx         class-hnd single-def <System.String>
-;  V04 arg4         [V04,T17] (  4,  3   )     int  ->  r14         single-def
-;  V05 arg5         [V05,T19] (  3,  3   )     int  ->  r15         single-def
+;  V04 arg4         [V04,T20] (  4,  3   )     int  ->  r14         single-def
+;  V05 arg5         [V05,T21] (  3,  3   )     int  ->  r15         single-def
 ;  V06 arg6         [V06,T27] (  2,  2   )     int  ->  r13         single-def
-;  V07 loc0         [V07,T00] ( 44, 20.03)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V07 loc0         [V07,T00] ( 44, 20.01)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
 ;* V08 loc1         [V08    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V09 loc2         [V09,T41] (  3,  0   )     int  ->  rcx        
-;  V10 loc3         [V10,T42] (  3,  0   )     int  ->  rax        
+;  V09 loc2         [V09,T42] (  3,  0   )     int  ->  rcx        
+;  V10 loc3         [V10,T43] (  3,  0   )     int  ->  rax        
 ;  V11 loc4         [V11,T23] (  3,  2   )     ref  ->  r12         class-hnd <System.Text.RegularExpressions.Match>
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V13 tmp1         [V13,T13] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V14 tmp2         [V14,T08] (  6,  5   )     ref  ->  [rbp-0x60] 
+;  V13 tmp1         [V13,T15] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V14 tmp2         [V14,T09] (  6,  5   )     ref  ->  [rbp-0x60] 
 ;* V15 tmp3         [V15    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V16 tmp4         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V17 tmp5         [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
 ;* V18 tmp6         [V18    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;  V19 tmp7         [V19,T07] (  3,  6   )     int  ->  r13         "Inlining Arg"
 ;* V20 tmp8         [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp9         [V21,T02] (  8,  7.92)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp10        [V22,T43] (  2,  0   )     int  ->  rdx         "dup spill"
-;  V23 tmp11        [V23,T37] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
-;  V24 tmp12        [V24,T38] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V21 tmp9         [V21,T02] (  8,  8.02)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp10        [V22,T44] (  2,  0   )     int  ->  rdx         "dup spill"
+;  V23 tmp11        [V23,T38] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V24 tmp12        [V24,T39] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V25 tmp13        [V25    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V26 tmp14        [V26,T39] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp14        [V26,T40] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp15        [V27    ] (  0,  0   )     ref  ->  zero-ref   
-;  V28 tmp16        [V28,T36] (  3,  0.03)     ref  ->  rdx        
-;  V29 tmp17        [V29,T31] (  4,  0.10)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp18        [V30,T33] (  2,  0.05)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp16        [V28,T37] (  3,  0.00)     ref  ->  rdx        
+;  V29 tmp17        [V29,T32] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp18        [V30,T34] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp19        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp20        [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp21        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp22        [V34,T34] (  2,  0.05)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp23        [V35,T15] (  2,  3.95)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V34 tmp22        [V34,T35] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp23        [V35,T12] (  2,  4.01)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V36 tmp24        [V36    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp25        [V37,T20] (  3,  2.96)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;  V38 tmp26        [V38,T10] (  5,  4.93)     int  ->  rdx         "Inline stloc first use temp"
-;  V39 tmp27        [V39,T14] (  3,  3.95)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp25        [V37,T16] (  3,  3.02)     ref  ->   r8         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;* V38 tmp26        [V38,T30] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V39 tmp27        [V39,T11] (  3,  4.01)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp28        [V40    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V41 tmp29        [V41,T22] (  4,  2   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp30        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V43 tmp31        [V43,T16] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V43 tmp31        [V43,T19] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V44 tmp32        [V44    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
 ;* V45 tmp33        [V45    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def "guarded devirt this exact temp" <System.Text.RegularExpressions.CompiledRegexRunner>
 ;  V46 tmp34        [V46,T24] (  3,  2   )   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
-;  V47 tmp35        [V47,T11] (  8,  4.00)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
+;  V47 tmp35        [V47,T13] (  8,  4.00)     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
 ;  V48 tmp36        [V48,T25] (  2,  2   )   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
 ;  V49 tmp37        [V49,T28] (  2,  2   )     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
 ;  V50 tmp38        [V50,T26] (  2,  2   )   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
@@ -503,16 +503,17 @@ G_M21592_IG22:
 ;* V55 tmp43        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V56 tmp44        [V56    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
 ;* V57 tmp45        [V57    ] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V58 tmp46        [V58,T40] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
+;  V58 tmp46        [V58,T41] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
 ;  V59 tmp47        [V59    ] (  6,  6   )  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
 ;  V60 tmp48        [V60,T05] (  3,  6   )     ref  ->  rax         single-def "argument with side effect"
 ;  V61 tmp49        [V61,T06] (  3,  6   )     ref  ->  rcx         single-def "arr expr"
-;  V62 PSPSym       [V62,T30] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
-;  V63 cse0         [V63,T35] (  3,  0.04)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
-;  V64 cse1         [V64,T18] (  3,  3   )     ref  ->   r8         "CSE #08: moderate"
-;  V65 cse2         [V65,T32] (  6,  0.05)     ref  ->  r13         "CSE #03: conservative"
-;  V66 cse3         [V66,T12] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
-;  V67 cse4         [V67,T21] (  3,  2.96)     int  ->  rcx         "CSE #07: moderate"
+;  V62 PSPSym       [V62,T31] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
+;  V63 cse0         [V63,T36] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
+;  V64 cse1         [V64,T18] (  3,  3.01)     ref  ->   r8         "CSE #08: moderate"
+;  V65 cse2         [V65,T33] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
+;  V66 cse3         [V66,T14] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
+;  V67 cse4         [V67,T17] (  3,  3.02)     int  ->  rcx         "CSE #07: moderate"
+;  V68 rat0         [V68,T08] (  5,  5.04)    long  ->  rdx         "Widened IV V38"
 ;
 ; Lcl frame size = 120
 
@@ -541,15 +542,15 @@ G_M21592_IG01:
 G_M21592_IG02:
        mov      r12d, dword ptr [rbx+0x08]
        cmp      r12d, r13d
-       jb       G_M21592_IG29
-       cmp      r12d, r15d
        jb       G_M21592_IG30
+       cmp      r12d, r15d
+       jb       G_M21592_IG31
        cmp      byte  ptr [rcx], cl
        lea      rdx, bword ptr [rcx+0x38]
        xor      rax, rax
        xchg     gword ptr [rdx], rax
        test     rax, rax
-       je       G_M21592_IG31
+       je       G_M21592_IG32
 						;; size=42 bbWeight=1 PerfScore 29.50
 G_M21592_IG03:
        mov      gword ptr [rbp-0x58], rax
@@ -569,7 +570,7 @@ G_M21592_IG04:
        add      rcx, rdx
        mov      edx, r12d
        cmp      rcx, rdx
-       ja       G_M21592_IG16
+       ja       G_M21592_IG17
        mov      ecx, r14d
        lea      r12, bword ptr [rbx+2*rcx+0x0C]
        sub      r13d, r14d
@@ -586,7 +587,7 @@ G_M21592_IG04:
        mov      dword ptr [rdx+0x4C], r13d
        mov      r13, gword ptr [rdx+0x28]
        test     r13, r13
-       je       G_M21592_IG14
+       je       G_M21592_IG15
 						;; size=121 bbWeight=1 PerfScore 28.75
 G_M21592_IG05:
        mov      rax, gword ptr [rdx+0x08]
@@ -601,26 +602,27 @@ G_M21592_IG05:
        mov      ecx, dword ptr [r8+0x08]
        test     ecx, ecx
        jle      SHORT G_M21592_IG07
-						;; size=41 bbWeight=0.99 PerfScore 11.35
+						;; size=41 bbWeight=1.00 PerfScore 11.54
 G_M21592_IG06:
-       mov      eax, edx
-       xor      r10d, r10d
-       mov      dword ptr [r8+4*rax+0x10], r10d
+       xor      eax, eax
+       mov      dword ptr [r8+4*rdx+0x10], eax
        inc      edx
        cmp      ecx, edx
        jg       SHORT G_M21592_IG06
-						;; size=16 bbWeight=0.99 PerfScore 2.96
+						;; size=13 bbWeight=1.01 PerfScore 2.78
 G_M21592_IG07:
        mov      byte  ptr [r13+0x60], 0
        mov      r13, gword ptr [r13+0x38]
        test     r13, r13
-       jne      G_M21592_IG18
-						;; size=18 bbWeight=0.99 PerfScore 4.20
+       jne      G_M21592_IG19
+						;; size=18 bbWeight=1.00 PerfScore 4.26
 G_M21592_IG08:
        mov      r13, gword ptr [rbp-0x58]
        mov      r8, gword ptr [r13+0x20]
        test     r8, r8
-       je       G_M21592_IG19
+       je       G_M21592_IG20
+						;; size=17 bbWeight=1.00 PerfScore 4.26
+G_M21592_IG09:
        mov      rdx, gword ptr [r13+0x10]
        mov      edx, dword ptr [rdx+0x08]
        mov      dword ptr [r13+0x50], edx
@@ -629,15 +631,15 @@ G_M21592_IG08:
        mov      dword ptr [r13+0x54], edx
        mov      r8d, dword ptr [r8+0x08]
        mov      dword ptr [r13+0x58], r8d
-						;; size=47 bbWeight=1 PerfScore 17.25
-G_M21592_IG09:
+						;; size=30 bbWeight=1.00 PerfScore 13.00
+G_M21592_IG10:
        test     edi, edi
-       je       G_M21592_IG20
+       je       G_M21592_IG21
        mov      r8, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
        cmp      qword ptr [r13], r8
-       jne      G_M21592_IG24
+       jne      G_M21592_IG25
 						;; size=28 bbWeight=1 PerfScore 5.50
-G_M21592_IG10:
+G_M21592_IG11:
        mov      rax, gword ptr [r13+0x70]
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
@@ -646,30 +648,30 @@ G_M21592_IG10:
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
 						;; size=26 bbWeight=1 PerfScore 9.75
-G_M21592_IG11:
+G_M21592_IG12:
        mov      r12, gword ptr [r13+0x28]
        mov      rcx, gword ptr [r12+0x50]
        cmp      dword ptr [rcx+0x08], 0
-       jbe      G_M21592_IG22
+       jbe      G_M21592_IG23
        cmp      dword ptr [rcx+0x10], 0
-       jle      G_M21592_IG26
+       jle      G_M21592_IG27
        test     esi, esi
-       jne      G_M21592_IG25
+       jne      G_M21592_IG26
        xor      rcx, rcx
        mov      gword ptr [r12+0x08], rcx
 						;; size=44 bbWeight=1 PerfScore 14.50
-G_M21592_IG12:
+G_M21592_IG13:
        xor      r12, r12
 						;; size=3 bbWeight=1 PerfScore 0.25
-G_M21592_IG13:
-       jmp      G_M21592_IG27
-						;; size=5 bbWeight=1 PerfScore 2.00
 G_M21592_IG14:
+       jmp      G_M21592_IG28
+						;; size=5 bbWeight=1 PerfScore 2.00
+G_M21592_IG15:
        mov      r13, gword ptr [rdx+0x30]
        mov      rax, gword ptr [r13+0x18]
        mov      gword ptr [rbp-0x80], rax
        test     rax, rax
-       je       SHORT G_M21592_IG17
+       je       SHORT G_M21592_IG18
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      rdx, rax
@@ -689,18 +691,18 @@ G_M21592_IG14:
        mov      rdx, gword ptr [rbp-0x78]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp-0x70]
-						;; size=100 bbWeight=0.01 PerfScore 0.32
-G_M21592_IG15:
+						;; size=100 bbWeight=0.00 PerfScore 0.02
+G_M21592_IG16:
        lea      rcx, bword ptr [r13+0x28]
        call     CORINFO_HELP_ASSIGN_REF
        jmp      G_M21592_IG08
-						;; size=14 bbWeight=0.01 PerfScore 0.04
-G_M21592_IG16:
+						;; size=14 bbWeight=0.00 PerfScore 0.00
+G_M21592_IG17:
        mov      ecx, 33
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M21592_IG17:
+G_M21592_IG18:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x68], rax
@@ -712,14 +714,14 @@ G_M21592_IG17:
        mov      rcx, gword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
        mov      rdx, gword ptr [rbp-0x68]
-       jmp      SHORT G_M21592_IG15
+       jmp      SHORT G_M21592_IG16
 						;; size=55 bbWeight=0 PerfScore 0.00
-G_M21592_IG18:
+G_M21592_IG19:
        xor      rcx, rcx
        mov      gword ptr [r13+0x18], rcx
        jmp      G_M21592_IG08
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M21592_IG19:
+G_M21592_IG20:
        mov      rcx, r13
        mov      rax, qword ptr [r13]
        mov      rax, qword ptr [rax+0x40]
@@ -758,37 +760,37 @@ G_M21592_IG19:
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
        mov      dword ptr [r13+0x58], 32
-       jmp      G_M21592_IG09
+       jmp      G_M21592_IG10
 						;; size=171 bbWeight=0 PerfScore 0.00
-G_M21592_IG20:
+G_M21592_IG21:
        mov      ecx, r15d
        mov      eax, 1
        mov      rdx, gword ptr [rbp+0x10]
        test     byte  ptr [rdx+0x40], 64
-       je       SHORT G_M21592_IG21
+       je       SHORT G_M21592_IG22
        xor      ecx, ecx
        mov      eax, -1
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M21592_IG21:
+G_M21592_IG22:
        cmp      dword ptr [r13+0x48], ecx
-       jne      SHORT G_M21592_IG23
+       jne      SHORT G_M21592_IG24
        mov      rcx, 0xD1FFAB1E
        mov      edx, 33
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov      rdx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      r12, gword ptr [rdx]
-       jmp      G_M21592_IG27
+       jmp      G_M21592_IG28
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M21592_IG22:
+G_M21592_IG23:
        call     CORINFO_HELP_RNGCHKFAIL
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M21592_IG23:
+G_M21592_IG24:
        add      dword ptr [r13+0x4C], eax
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
        cmp      qword ptr [r13], rcx
-       je       G_M21592_IG10
+       je       G_M21592_IG11
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M21592_IG24:
+G_M21592_IG25:
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
        lea      rdx, [rbp-0x50]
@@ -796,9 +798,9 @@ G_M21592_IG24:
        mov      rax, qword ptr [r13]
        mov      rax, qword ptr [rax+0x40]
        call     [rax+0x20]<unknown method>
-       jmp      G_M21592_IG11
+       jmp      G_M21592_IG12
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M21592_IG25:
+G_M21592_IG26:
        lea      rcx, bword ptr [r12+0x08]
        mov      rdx, rbx
        call     CORINFO_HELP_ASSIGN_REF
@@ -809,9 +811,9 @@ G_M21592_IG25:
        mov      r8d, r14d
        mov      r9d, esi
        call     [System.Text.RegularExpressions.Match:Tidy(int,int,int):this]
-       jmp      G_M21592_IG13
+       jmp      G_M21592_IG14
 						;; size=43 bbWeight=0 PerfScore 0.00
-G_M21592_IG26:
+G_M21592_IG27:
        xor      rcx, rcx
        mov      gword ptr [r12+0x08], rcx
        mov      rcx, 0xD1FFAB1E
@@ -819,9 +821,9 @@ G_M21592_IG26:
        call     CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
        mov      r12, gword ptr [rcx]
-       jmp      G_M21592_IG13
+       jmp      G_M21592_IG14
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M21592_IG27:
+G_M21592_IG28:
        xor      rcx, rcx
        mov      gword ptr [r13+0x08], rcx
        mov      rdx, gword ptr [rbp+0x10]
@@ -830,7 +832,7 @@ G_M21592_IG27:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rax, r12
 						;; size=25 bbWeight=1 PerfScore 4.25
-G_M21592_IG28:
+G_M21592_IG29:
        add      rsp, 120
        pop      rbx
        pop      rsi
@@ -842,19 +844,19 @@ G_M21592_IG28:
        pop      rbp
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M21592_IG29:
+G_M21592_IG30:
        mov      ecx, 14
        xor      edx, edx
        call     [System.Text.RegularExpressions.ThrowHelper:ThrowArgumentOutOfRangeException(int,int)]
        int3     
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M21592_IG30:
+G_M21592_IG31:
        mov      ecx, 8
        mov      edx, 2
        call     [System.Text.RegularExpressions.ThrowHelper:ThrowArgumentOutOfRangeException(int,int)]
        int3     
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M21592_IG31:
+G_M21592_IG32:
        mov      rax, gword ptr [rcx+0x10]
        mov      rcx, rax
        mov      rax, qword ptr [rax]
@@ -865,7 +867,7 @@ G_M21592_IG31:
        mov      rcx, gword ptr [rbp+0x10]
        jmp      G_M21592_IG03
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M21592_IG32:
+G_M21592_IG33:
        push     rbp
        push     r15
        push     r14
@@ -879,7 +881,7 @@ G_M21592_IG32:
        mov      qword ptr [rsp+0x28], rbp
        lea      rbp, [rbp+0xB0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M21592_IG33:
+G_M21592_IG34:
        xor      rcx, rcx
        mov      r13, gword ptr [rbp-0x58]
        mov      gword ptr [r13+0x08], rcx
@@ -889,7 +891,7 @@ G_M21592_IG33:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M21592_IG34:
+G_M21592_IG35:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -902,6 +904,6 @@ G_M21592_IG34:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1217, prolog size 61, PerfScore 152.62, instruction count 317, allocated bytes for code 1217 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
+; Total bytes of code 1214, prolog size 61, PerfScore 152.37, instruction count 316, allocated bytes for code 1214 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Match.AddMatch(int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1696256
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1362688
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  5,  5   )     ref  ->  rsi         this class-hnd single-def <System.Text.RegularExpressions.Match>
@@ -451,7 +451,7 @@ G_M41154_IG10:
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
 ;  V09 loc5         [V09,T19] (  3,  0   )     ref  ->  [rsp+0x20]  class-hnd spill-single-def <<unknown class>>
 ;  V10 loc6         [V10,T18] (  4,  0   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
-;  V11 loc7         [V11,T17] (  8,  0   )     int  ->  rdx        
+;* V11 loc7         [V11,T22] (  0,  0   )     int  ->  zero-ref   
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T21] (  2,  0   )     int  ->   r8         "Strict ordering of exceptions for Array store"
 ;  V14 tmp2         [V14,T20] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
@@ -464,6 +464,7 @@ G_M41154_IG10:
 ;  V21 cse3         [V21,T14] (  3,  3   )     int  ->  rax         "CSE #11: aggressive"
 ;  V22 cse4         [V22,T16] (  2,  2   )     int  ->  rcx         "CSE #12: aggressive"
 ;  V23 cse5         [V23,T02] (  7,  6   )    long  ->  r15         "CSE #01: aggressive"
+;  V24 rat0         [V24,T17] (  8,  0   )    long  ->  rdx         "Widened IV V11"
 ;
 ; Lcl frame size = 40
 
@@ -561,14 +562,12 @@ G_M41154_IG09:
        mov      rcx, gword ptr [rsp+0x20]
        cmp      edx, dword ptr [rcx+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r8d, edx
-       mov      r8d, dword ptr [rcx+4*r8+0x10]
+       mov      r8d, dword ptr [rcx+4*rdx+0x10]
        cmp      edx, dword ptr [rax+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r10d, edx
-       mov      dword ptr [rax+4*r10+0x10], r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
        inc      edx
-						;; size=33 bbWeight=0 PerfScore 0.00
+						;; size=27 bbWeight=0 PerfScore 0.00
 G_M41154_IG10:
        cmp      edx, esi
        jl       SHORT G_M41154_IG09
@@ -579,6 +578,6 @@ G_M41154_IG10:
        jmp      G_M41154_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 297, prolog size 27, PerfScore 55.00, instruction count 91, allocated bytes for code 297 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
+; Total bytes of code 291, prolog size 27, PerfScore 55.00, instruction count 89, allocated bytes for code 291 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.CreateAddAndClear<Int32>.SortedDictionary(Size: 512)``

Hot functions:

- (57.09%) ``System.Collections.Generic.SortedSet`1.AddIfNotPresent`` (Tier-1)
  - No diffs
- (14.12%) ``System.Collections.CreateAddAndClear`1.SortedDictionary`` (Tier-1)
  - **Has diffs**
- (4.05%) ``System.Collections.Generic.SortedSet`1.InsertionBalance`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.CreateAddAndClear`1[System.Int32].SortedDictionary()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; partially interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1241
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 1289
 ; 5 inlinees with PGO data; 12 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T14] (  3,   3   )     ref  ->  rbx         this class-hnd single-def <System.Collections.CreateAddAndClear`1[int]>
-;  V01 loc0         [V01,T07] (  4, 508.30)     ref  ->  rsi         class-hnd exact single-def <System.Collections.Generic.SortedDictionary`2[int,int]>
-;  V02 loc1         [V02,T08] (  3, 507.30)     ref  ->  rbx         class-hnd single-def <<unknown class>>
-;  V03 loc2         [V03,T02] (  5,2022.18)     int  ->  rdi        
-;  V04 loc3         [V04,T05] (  2,1010.59)     int  ->  rdx        
+;  V01 loc0         [V01,T07] (  4, 515   )     ref  ->  rsi         class-hnd exact single-def <System.Collections.Generic.SortedDictionary`2[int,int]>
+;  V02 loc1         [V02,T08] (  3, 514   )     ref  ->  rbx         class-hnd single-def <<unknown class>>
+;* V03 loc2         [V03,T17] (  0,   0   )     int  ->  zero-ref   
+;  V04 loc3         [V04,T05] (  2,1024   )     int  ->  rdx        
 ;  V05 OutArgs      [V05    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V06 tmp1         [V06,T12] (  3,   6   )     ref  ->  rsi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.SortedDictionary`2[int,int]>
 ;  V07 tmp2         [V07,T13] (  3,   6   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[int,int]>
@@ -230,21 +230,22 @@ G_M4403_IG08:
 ;  V14 tmp9         [V14,T15] (  2,   2   )     ref  ->  rdx         single-def
 ;* V15 tmp10        [V15    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Single-def Box Helper" <<unknown class>>
 ;* V16 tmp11        [V16    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Generic.KeyValuePair`2[int,int]>
-;  V17 tmp12        [V17,T00] (  3,3031.77)     ref  ->  rcx         class-hnd exact "impAppendStmt" <System.Collections.Generic.TreeSet`1[System.Collections.Generic.KeyValuePair`2[int,int]]>
+;  V17 tmp12        [V17,T00] (  3,3072   )     ref  ->  rcx         class-hnd exact "impAppendStmt" <System.Collections.Generic.TreeSet`1[System.Collections.Generic.KeyValuePair`2[int,int]]>
 ;* V18 tmp13        [V18    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <<unknown class>>
 ;* V19 tmp14        [V19    ] (  0,   0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.Generic.KeyValuePair`2[int,int]>
-;  V20 tmp15        [V20,T06] (  2,1010.59)   ubyte  ->  rax         "Inline stloc first use temp"
-;  V21 tmp16        [V21,T17] (  4,   0   )     ref  ->  rbx         class-hnd exact "Single-def Box Helper" <System.Collections.Generic.KeyValuePair`2[int,int]>
-;  V22 tmp17        [V22,T19] (  2,   0   )     ref  ->  rsi         class-hnd exact "impImportAndPushBox" <System.String>
-;  V23 tmp18        [V23,T18] (  3,   0   )     ref  ->  rdi         class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V20 tmp15        [V20,T06] (  2,1024   )   ubyte  ->  rax         "Inline stloc first use temp"
+;  V21 tmp16        [V21,T18] (  4,   0   )     ref  ->  rbx         class-hnd exact "Single-def Box Helper" <System.Collections.Generic.KeyValuePair`2[int,int]>
+;  V22 tmp17        [V22,T20] (  2,   0   )     ref  ->  rsi         class-hnd exact "impImportAndPushBox" <System.String>
+;  V23 tmp18        [V23,T19] (  3,   0   )     ref  ->  rdi         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;  V24 tmp19        [V24,T10] (  5,  10   )     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.Collections.Generic.TreeSet`1[System.Collections.Generic.KeyValuePair`2[int,int]]>
-;  V25 tmp20        [V25,T03] (  3,1515.89)     int  ->  rdx         "field V16.key (fldOffset=0x0)" P-INDEP
-;  V26 tmp21        [V26,T04] (  4,1010.59)     int  ->  r14         "field V16.value (fldOffset=0x4)" P-INDEP
+;  V25 tmp20        [V25,T03] (  3,1536   )     int  ->  rdx         "field V16.key (fldOffset=0x0)" P-INDEP
+;  V26 tmp21        [V26,T04] (  4,1024   )     int  ->  r14         "field V16.value (fldOffset=0x4)" P-INDEP
 ;* V27 tmp22        [V27    ] (  0,   0   )     int  ->  zero-ref    "field V19.key (fldOffset=0x0)" P-INDEP
 ;* V28 tmp23        [V28    ] (  0,   0   )     int  ->  zero-ref    "field V19.value (fldOffset=0x4)" P-INDEP
-;  V29 tmp24        [V29,T01] (  3,3031.77)  struct ( 8) [rsp+0x28]  do-not-enreg[SF] "by-value struct argument" <System.Collections.Generic.KeyValuePair`2[int,int]>
-;  V30 tmp25        [V30,T20] (  2,   0   )     ref  ->  rdx         "argument with side effect"
-;  V31 cse0         [V31,T09] (  3, 507.30)     int  ->  rbp         "CSE #01: aggressive"
+;  V29 tmp24        [V29,T01] (  3,3072   )  struct ( 8) [rsp+0x28]  do-not-enreg[SF] "by-value struct argument" <System.Collections.Generic.KeyValuePair`2[int,int]>
+;  V30 tmp25        [V30,T21] (  2,   0   )     ref  ->  rdx         "argument with side effect"
+;  V31 cse0         [V31,T09] (  3, 514   )     int  ->  rbp         "CSE #01: aggressive"
+;  V32 rat0         [V32,T02] (  5,2049   )    long  ->  rdi         "Widened IV V03"
 ;
 ; Lcl frame size = 48
 
@@ -284,8 +285,7 @@ G_M4403_IG02:
        jle      SHORT G_M4403_IG04
 						;; size=113 bbWeight=1 PerfScore 17.25
 G_M4403_IG03:
-       mov      edx, edi
-       mov      edx, dword ptr [rbx+4*rdx+0x10]
+       mov      edx, dword ptr [rbx+4*rdi+0x10]
        mov      rcx, gword ptr [rsi+0x18]
        mov      r14d, edx
        cmp      byte  ptr [rcx], cl
@@ -298,7 +298,7 @@ G_M4403_IG03:
        inc      edi
        cmp      ebp, edi
        jg       SHORT G_M4403_IG03
-						;; size=45 bbWeight=505.30 PerfScore 8211.06
+						;; size=43 bbWeight=512 PerfScore 8192.00
 G_M4403_IG04:
        mov      rax, gword ptr [rsi+0x18]
        xor      rcx, rcx
@@ -340,6 +340,6 @@ G_M4403_IG07:
        int3     
 						;; size=86 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 287, prolog size 10, PerfScore 8245.06, instruction count 77, allocated bytes for code 287 (MethodHash=18c1eecc) for method System.Collections.CreateAddAndClear`1[int]:SortedDictionary():System.Collections.Generic.SortedDictionary`2[int,int]:this (Tier1)
+; Total bytes of code 285, prolog size 10, PerfScore 8226.00, instruction count 76, allocated bytes for code 285 (MethodHash=18c1eecc) for method System.Collections.CreateAddAndClear`1[int]:SortedDictionary():System.Collections.Generic.SortedDictionary`2[int,int]:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "[\\w]+://[^/\\s?#]+[^\\s?#]+(?:\\?[^\\s#]*)?(?:#[^\\s]*)?", Options: Compiled)``

Hot functions:

- (39.47%) ``dynamicClass.Regex1_TryMatchAtCurrentPosition`` (FullOpt)
  - No diffs
- (36.32%) ``SpanHelpers.IndexOf`` (Tier-1)
  - No diffs
- (5.66%) ``dynamicClass.Regex1_TryFindNextPossibleStartingPosition`` (FullOpt)
  - No diffs
- (5.45%) ``Regex.RunAllMatchesWithCallback`` (Tier-1)
  - **Has diffs**
- (4.21%) ``dynamicClass.Regex1_Scan`` (FullOpt)
  - No diffs
- (2.65%) ``Match.AddMatch`` (Tier-1)
  - **Has diffs**
- (1.73%) ``SpanHelpers.SequenceEqual`` (Tier-1)
  - No diffs
- (1.39%) ``Match.Tidy`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]Regex.RunAllMatchesWithCallback(class System.String,value class System.ReadOnlySpan`1<wchar>,int32,!!0&,class System.Text.RegularExpressions.MatchCallback`1<!!0>,value class System.Text.RegularExpressions.RegexRunnerMode,bool)``

```diff
 ; 1 inlinees with PGO data; 24 single block inlinees; 4 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T40] (  6,  102.01)     ref  ->  [rbp+0x110]  this class-hnd EH-live single-def tier0-frame <System.Text.RegularExpressions.Regex>
-;  V01 arg1         [V01,T30] (  3,  402   )     ref  ->  r14         class-hnd single-def <System.String>
-;  V02 arg2         [V02,T29] (  6,  405   )   byref  ->  rdi         ld-addr-op single-def
-;  V03 arg3         [V03,T31] (  8,  401.96)     int  ->  registers  
-;  V04 arg4         [V04,T36] (  3,  299.94)   byref  ->  r13         single-def
-;  V05 arg5         [V05,T37] (  3,  299.94)     ref  ->  r12         class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
-;  V06 arg6         [V06,T26] (  2,  500   )     int  ->  rbx         single-def
-;  V07 arg7         [V07,T27] (  2,  499.98)   ubyte  ->  rsi         single-def
-;  V08 loc0         [V08,T02] ( 45,10699.88)     ref  ->  [rbp+0xC0]  do-not-enreg[H] class-hnd EH-live tier0-frame <System.Text.RegularExpressions.RegexRunner>
-;  V09 loc1         [V09,T39] (  3,  199.98)     int  ->  [rbp+0xBC]  tier0-frame
+;  V00 this         [V00,T38] (  8,  102.01)     ref  ->  [rbp+0x110]  this class-hnd EH-live single-def tier0-frame <System.Text.RegularExpressions.Regex>
+;  V01 arg1         [V01,T30] (  4,  402   )     ref  ->  r14         class-hnd single-def <System.String>
+;  V02 arg2         [V02,T29] (  9,  405   )   byref  ->  rdi         ld-addr-op single-def
+;  V03 arg3         [V03,T31] ( 14,  401.96)     int  ->  registers  
+;  V04 arg4         [V04,T37] (  5,  199.96)   byref  ->  r13         single-def
+;  V05 arg5         [V05,T41] (  5,    1.08)     ref  ->  r12         class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
+;  V06 arg6         [V06,T26] (  4,  500   )     int  ->  rbx         single-def
+;  V07 arg7         [V07,T27] (  4,  499.98)   ubyte  ->  rsi         single-def
+;  V08 loc0         [V08,T02] ( 87,10703.88)     ref  ->  [rbp+0xC0]  do-not-enreg[H] class-hnd EH-live tier0-frame <System.Text.RegularExpressions.RegexRunner>
+;  V09 loc1         [V09,T36] (  6,  199.98)     int  ->  [rbp+0xBC]  tier0-frame
 ;* V10 loc2         [V10    ] (  0,    0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.Match>
-;  V11 loc3         [V11,T43] (  3,    0   )     int  ->  rcx        
-;  V12 loc4         [V12,T44] (  3,    0   )     int  ->   r8        
+;  V11 loc3         [V11,T44] (  6,    0   )     int  ->  registers  
+;  V12 loc4         [V12,T45] (  6,    0   )     int  ->   r8        
 ;  V13 OutArgs      [V13    ] (  1,    1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V14 tmp1         [V14    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "dup spill" <<unknown class>>
 ;* V15 tmp2         [V15    ] (  0,    0   )     ref  ->  zero-ref   
-;  V16 tmp3         [V16,T34] (  2,  399.92)     int  ->  rcx         "dup spill"
-;  V17 tmp4         [V17,T38] (  2,  199.96)     int  ->  rax         "guarded devirt return temp"
+;  V16 tmp3         [V16,T34] (  4,  399.92)     int  ->  rax         "dup spill"
+;  V17 tmp4         [V17,T39] (  2,    0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp5         [V18    ] (  0,    0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Text.RegularExpressions.Regex+<>c>
-;* V19 tmp6         [V19,T41] (  0,    0   )     int  ->  zero-ref    "OSR entry state var"
+;* V19 tmp6         [V19,T42] (  0,    0   )     int  ->  zero-ref    "OSR entry state var"
 ;* V20 tmp7         [V20    ] (  0,    0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp8         [V21,T24] (  8,  800   )     ref  ->  r15         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp9         [V22,T17] (  2, 1600   )     int  ->  r15         "dup spill"
-;  V23 tmp10        [V23,T04] (  7, 2800   )     int  ->  r15         "Inline stloc first use temp"
-;  V24 tmp11        [V24,T09] (  4, 1600   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V21 tmp8         [V21,T24] ( 16,  800   )     ref  ->  r15         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp9         [V22,T19] (  4, 1600   )     int  ->  r15         "dup spill"
+;  V23 tmp10        [V23,T04] ( 14, 2800   )     int  ->  r15         "Inline stloc first use temp"
+;  V24 tmp11        [V24,T11] (  8, 1600   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
 ;* V25 tmp12        [V25    ] (  0,    0   )     ref  ->  zero-ref   
-;  V26 tmp13        [V26,T01] ( 14,11200   )     ref  ->  [rbp-0x60]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp13        [V26,T01] ( 28,11200   )     ref  ->  [rbp-0x60]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp14        [V27    ] (  0,    0   )     ref  ->  zero-ref   
-;  V28 tmp15        [V28,T20] (  3, 1200   )     ref  ->  r15        
-;  V29 tmp16        [V29,T00] ( 15,12000   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp17        [V30,T10] (  2, 1600   )     ref  ->  [rbp-0x70]  class-hnd spill-single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
-;  V31 tmp18        [V31,T18] (  2, 1600   )     int  ->  r15         "Inlining Arg"
-;  V32 tmp19        [V32,T11] (  2, 1600   )     ref  ->  [rbp-0x78]  class-hnd exact spill-single-def "Inlining Arg" <System.String>
+;  V28 tmp15        [V28,T20] (  6, 1200   )     ref  ->  r15        
+;  V29 tmp16        [V29,T00] ( 30,12000   )     ref  ->  [rbp-0x68]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp17        [V30,T12] (  4, 1600   )     ref  ->  [rbp-0x70]  class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V31 tmp18        [V31,T09] (  5, 1608   )     int  ->  r15         "Inlining Arg"
+;  V32 tmp19        [V32,T13] (  4, 1600   )     ref  ->  [rbp-0x78]  class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp20        [V33    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp21        [V34,T12] (  2, 1600   )     ref  ->  [rbp-0x80]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
+;  V34 tmp21        [V34,T14] (  4, 1600   )     ref  ->  [rbp-0x80]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
 ;* V35 tmp22        [V35    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V36 tmp23        [V36    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V37 tmp24        [V37    ] (  0,    0   )     ref  ->  zero-ref   
@@ -419,10 +419,10 @@ G_M16487_IG28:
 ;* V44 tmp31        [V44    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V45 tmp32        [V45    ] (  0,    0   )     int  ->  zero-ref   
 ;* V46 tmp33        [V46    ] (  0,    0   )     int  ->  zero-ref   
-;  V47 tmp34        [V47,T13] (  2, 1600   )     ref  ->  [rbp-0x88]  class-hnd exact spill-single-def "Inlining Arg" <int[]>
-;  V48 tmp35        [V48,T14] (  2, 1600   )     ref  ->  [rbp-0x90]  class-hnd exact spill-single-def "Inlining Arg" <System.String>
-;  V49 tmp36        [V49,T15] (  2, 1600   )     ref  ->  [rbp-0x98]  class-hnd spill-single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
-;  V50 tmp37        [V50,T19] (  2, 1600   )     int  ->  r15         "Inlining Arg"
+;  V47 tmp34        [V47,T15] (  4, 1600   )     ref  ->  [rbp-0x88]  class-hnd exact "Inlining Arg" <int[]>
+;  V48 tmp35        [V48,T16] (  4, 1600   )     ref  ->  [rbp-0x90]  class-hnd exact "Inlining Arg" <System.String>
+;  V49 tmp36        [V49,T17] (  4, 1600   )     ref  ->  [rbp-0x98]  class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V50 tmp37        [V50,T10] (  5, 1608   )     int  ->  r15         "Inlining Arg"
 ;* V51 tmp38        [V51    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V52 tmp39        [V52    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V53 tmp40        [V53    ] (  0,    0   )     ref  ->  zero-ref   
@@ -436,47 +436,48 @@ G_M16487_IG28:
 ;* V61 tmp48        [V61    ] (  0,    0   )     ref  ->  zero-ref   
 ;* V62 tmp49        [V62    ] (  0,    0   )     int  ->  zero-ref   
 ;* V63 tmp50        [V63    ] (  0,    0   )     int  ->  zero-ref   
-;  V64 tmp51        [V64,T16] (  2, 1600   )     ref  ->  [rbp-0xA0]  class-hnd exact spill-single-def "Inlining Arg" <int[]>
-;  V65 tmp52        [V65,T33] (  2,  400   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
+;  V64 tmp51        [V64,T18] (  4, 1600   )     ref  ->  [rbp-0xA0]  class-hnd exact "Inlining Arg" <int[]>
+;  V65 tmp52        [V65,T33] (  4,  400   )     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
 ;* V66 tmp53        [V66    ] (  0,    0   )     int  ->  zero-ref    "Inlining Arg"
-;  V67 tmp54        [V67,T35] (  4,  399.03)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <int[]>
-;  V68 tmp55        [V68,T28] (  5,  498.07)     int  ->  rax         "Inline stloc first use temp"
-;  V69 tmp56        [V69,T32] (  3,  400.00)     ref  ->  r15         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V67 tmp54        [V67,T35] (  8,  399.03)     ref  ->  rax         class-hnd "Inline stloc first use temp" <int[]>
+;  V68 tmp55        [V68,T28] ( 10,  498.07)     int  ->  rcx         "Inline stloc first use temp"
+;  V69 tmp56        [V69,T32] (  6,  400.00)     ref  ->  registers   class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V70 tmp57        [V70    ] (  0,    0   )     ref  ->  zero-ref   
-;  V71 tmp58        [V71,T23] (  5, 1099.96)     ref  ->  r15         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
+;  V71 tmp58        [V71,T23] (  9,  999.98)     ref  ->  r15         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V72 tmp59        [V72    ] (  0,    0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V73 tmp60        [V73,T08] (  6, 1800   )     ref  ->  r15         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V73 tmp60        [V73,T08] ( 12, 1800   )     ref  ->  r15         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V74 tmp61        [V74    ] (  0,    0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
-;  V75 tmp62        [V75,T22] (  5, 1100   )     int  ->  [rbp-0x40]  spill-single-def "field V20._length (fldOffset=0x8)" P-INDEP
+;  V75 tmp62        [V75,T22] ( 10, 1100   )     int  ->  [rbp-0x40]  "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V76 tmp63        [V76    ] (  0,    0   )   byref  ->  zero-ref    "field V72._reference (fldOffset=0x0)" P-INDEP
 ;* V77 tmp64        [V77    ] (  0,    0   )     int  ->  zero-ref    "field V72._length (fldOffset=0x8)" P-INDEP
 ;* V78 tmp65        [V78    ] (  0,    0   )     ref  ->  zero-ref    "argument with side effect"
-;  V79 tmp66        [V79    ] (  2,  400   )  struct (16) [rbp-0x50]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V80 tmp67        [V80,T25] (  3,  600   )     ref  ->  rcx         "arr expr"
-;  V81 PSPSym       [V81,T42] (  1,    1   )    long  ->  [rbp-0xB0]  do-not-enreg[V] "PSPSym"
-;  V82 cse0         [V82,T21] (  3, 1200   )     ref  ->  [rbp-0xA8]  spill-single-def "CSE #02: moderate"
-;  V83 cse1         [V83,T05] (  6, 2400   )     ref  ->  r15         "CSE #01: aggressive"
-;  V84 cse2         [V84,T07] (  3, 2000   )     ref  ->  rcx         "CSE #10: aggressive"
-;  V85 cse3         [V85,T03] ( 10, 4000   )    long  ->  [rbp-0x58]  multi-def "CSE #03: aggressive"
-;  V86 cse4         [V86,T06] (  6, 2400   )    long  ->  r15         multi-def "CSE #04: aggressive"
+;  V79 tmp66        [V79    ] (  4,  400   )  struct (16) [rbp-0x50]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V80 tmp67        [V80,T25] (  6,  600   )     ref  ->  rax         "arr expr"
+;  V81 PSPSym       [V81,T43] (  1,    1   )    long  ->  [rbp-0xC0]  do-not-enreg[V] "PSPSym"
+;  V82 cse0         [V82,T21] (  3, 1188   )     ref  ->  [rbp-0xA8]  spill-single-def "CSE #02: moderate"
+;  V83 cse1         [V83,T40] (  3,   12.00)     ref  ->  [rbp-0xB0]  spill-single-def "CSE #15: conservative"
+;  V84 cse2         [V84,T05] ( 12, 2400   )     ref  ->  r15         multi-def "CSE #01: aggressive"
+;  V85 cse3         [V85,T07] (  3, 1980   )     ref  ->  rcx         "CSE #10: aggressive"
+;  V86 cse4         [V86,T03] ( 20, 4000   )    long  ->  [rbp-0x58]  multi-def "CSE #03: aggressive"
+;  V87 cse5         [V87,T06] (  6, 2376   )    long  ->  r15         multi-def "CSE #04: aggressive"
 ;
-; Lcl frame size = 152
+; Lcl frame size = 168
 
 G_M16487_IG01:
        mov      rax, qword ptr [rbp]
        push     rax
-       sub      rsp, 208
-       mov      qword ptr [rsp+0x1C8], r15
-       mov      qword ptr [rsp+0x1C0], r14
-       mov      qword ptr [rsp+0x1B8], r13
-       mov      qword ptr [rsp+0x1B0], r12
-       mov      qword ptr [rsp+0x1A8], rdi
-       mov      qword ptr [rsp+0x1A0], rsi
-       mov      qword ptr [rsp+0x198], rbx
-       lea      rbp, [rsp+0xD0]
+       sub      rsp, 224
+       mov      qword ptr [rsp+0x1D8], r15
+       mov      qword ptr [rsp+0x1D0], r14
+       mov      qword ptr [rsp+0x1C8], r13
+       mov      qword ptr [rsp+0x1C0], r12
+       mov      qword ptr [rsp+0x1B8], rdi
+       mov      qword ptr [rsp+0x1B0], rsi
+       mov      qword ptr [rsp+0x1A8], rbx
+       lea      rbp, [rsp+0xE0]
        xor      eax, eax
        mov      qword ptr [rbp-0x50], rax
-       mov      qword ptr [rbp-0xB0], rsp
+       mov      qword ptr [rbp-0xC0], rsp
        mov      rdx, gword ptr [rbp+0x110]
        mov      r14, gword ptr [rbp+0x118]
        mov      rdi, bword ptr [rbp+0x120]
@@ -485,10 +486,16 @@ G_M16487_IG01:
        mov      r12, gword ptr [rbp+0x138]
        mov      ebx, dword ptr [rbp+0x140]
        mov      esi, dword ptr [rbp+0x148]
-						;; size=143 bbWeight=100 PerfScore 2900.00
+						;; size=143 bbWeight=0.04 PerfScore 1.12
 G_M16487_IG02:
-       mov      eax, dword ptr [rdi+0x08]
-       mov      dword ptr [rbp-0x40], eax
+       test     r12, r12
+       je       G_M16487_IG29
+       mov      rcx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
+       cmp      qword ptr [r12+0x18], rcx
+       jne      G_M16487_IG29
+						;; size=30 bbWeight=0.04 PerfScore 0.21
+G_M16487_IG03:
+       mov      r12d, dword ptr [rdi+0x08]
        mov      rcx, gword ptr [rbp+0xC0]
        mov      dword ptr [rcx+0x60], ebx
        mov      rcx, gword ptr [rbp+0xC0]
@@ -500,22 +507,21 @@ G_M16487_IG02:
        xor      eax, eax
        mov      dword ptr [rcx+0x40], eax
        mov      rcx, gword ptr [rbp+0xC0]
-       mov      eax, dword ptr [rbp-0x40]
-       mov      dword ptr [rcx+0x44], eax
+       mov      dword ptr [rcx+0x44], r12d
        mov      rcx, gword ptr [rbp+0xC0]
        mov      dword ptr [rcx+0x4C], r15d
        mov      rcx, gword ptr [rbp+0xC0]
        mov      r15, gword ptr [rcx+0x28]
        test     r15, r15
-       jne      G_M16487_IG09
-						;; size=99 bbWeight=100 PerfScore 2100.00
-G_M16487_IG03:
+       jne      G_M16487_IG10
+						;; size=95 bbWeight=99 PerfScore 1881.00
+G_M16487_IG04:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      r15, gword ptr [rcx+0x30]
-       mov      rdx, gword ptr [r15+0x18]
-       mov      gword ptr [rbp-0xA8], rdx
-       test     rdx, rdx
-       je       G_M16487_IG06
+       mov      rax, gword ptr [r15+0x18]
+       mov      gword ptr [rbp-0xA8], rax
+       test     rax, rax
+       je       G_M16487_IG07
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x68], rax
@@ -539,6 +545,7 @@ G_M16487_IG03:
        xor      ecx, ecx
        mov      rdx, gword ptr [rbp-0x68]
        mov      qword ptr [rdx+0x10], rcx
+       mov      gword ptr [rbp-0x68], rdx
        lea      rcx, bword ptr [rdx+0x18]
        mov      rdx, gword ptr [rbp-0x88]
        call     CORINFO_HELP_ASSIGN_REF
@@ -547,6 +554,7 @@ G_M16487_IG03:
        mov      dword ptr [rdx+0x30], ecx
        mov      rcx, 0xD1FFAB1E
        mov      gword ptr [rdx+0x28], rcx
+       mov      gword ptr [rbp-0x68], rdx
        lea      rcx, bword ptr [rdx+0x40]
        mov      rdx, gword ptr [rbp-0x70]
        call     CORINFO_HELP_ASSIGN_REF
@@ -557,8 +565,8 @@ G_M16487_IG03:
        mov      rdx, gword ptr [rbp-0x68]
        lea      rcx, bword ptr [rdx+0x50]
        mov      rdx, rax
-						;; size=223 bbWeight=400 PerfScore 16300.00
-G_M16487_IG04:
+						;; size=231 bbWeight=396 PerfScore 16929.00
+G_M16487_IG05:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, r15
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
@@ -571,21 +579,20 @@ G_M16487_IG04:
        mov      r8, gword ptr [r15+0x18]
        xor      edx, edx
        call     [CORINFO_HELP_ARRADDR_ST]
-       mov      eax, dword ptr [rbp-0x40]
-       mov      dword ptr [r15+0x5C], eax
+       mov      dword ptr [r15+0x5C], r12d
        mov      byte  ptr [r15+0x60], 0
        lea      rcx, bword ptr [r15+0x68]
        mov      rdx, gword ptr [rbp-0x80]
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      G_M16487_IG08
-						;; size=85 bbWeight=400 PerfScore 8000.00
-G_M16487_IG05:
-       xor      rcx, rcx
-       mov      gword ptr [r15+0x18], rcx
-       jmp      G_M16487_IG12
-       align    [6 bytes for IG10]
-						;; size=17 bbWeight=0 PerfScore 0.00
+       jmp      G_M16487_IG09
+						;; size=82 bbWeight=396 PerfScore 7524.00
 G_M16487_IG06:
+       xor      r8, r8
+       mov      gword ptr [rdx+0x18], r8
+       jmp      G_M16487_IG14
+       align    [6 bytes for IG12]
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M16487_IG07:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x60], rax
@@ -608,6 +615,7 @@ G_M16487_IG06:
        xor      ecx, ecx
        mov      rax, gword ptr [rbp-0x60]
        mov      qword ptr [rax+0x10], rcx
+       mov      gword ptr [rbp-0x60], rax
        lea      rcx, bword ptr [rax+0x18]
        mov      rdx, gword ptr [rbp-0xA0]
        call     CORINFO_HELP_ASSIGN_REF
@@ -616,6 +624,7 @@ G_M16487_IG06:
        mov      dword ptr [rax+0x30], ecx
        mov      rcx, 0xD1FFAB1E
        mov      gword ptr [rax+0x28], rcx
+       mov      gword ptr [rbp-0x60], rax
        lea      rcx, bword ptr [rax+0x40]
        mov      rdx, gword ptr [rbp-0x98]
        call     CORINFO_HELP_ASSIGN_REF
@@ -631,61 +640,60 @@ G_M16487_IG06:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWARR_1_OBJ
        mov      r15, gword ptr [rbp-0x60]
+						;; size=231 bbWeight=396 PerfScore 14751.00
+G_M16487_IG08:
        lea      rcx, bword ptr [r15+0x48]
        mov      rdx, rax
-						;; size=230 bbWeight=400 PerfScore 14400.00
-G_M16487_IG07:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, gword ptr [r15+0x48]
        mov      r8, gword ptr [r15+0x18]
        xor      edx, edx
        call     [CORINFO_HELP_ARRADDR_ST]
-       mov      eax, dword ptr [rbp-0x40]
-       mov      dword ptr [r15+0x5C], eax
+       mov      dword ptr [r15+0x5C], r12d
        mov      byte  ptr [r15+0x60], 0
-						;; size=33 bbWeight=400 PerfScore 4500.00
-G_M16487_IG08:
+						;; size=37 bbWeight=396 PerfScore 4356.00
+G_M16487_IG09:
        mov      rcx, gword ptr [rbp+0xC0]
        lea      rcx, bword ptr [rcx+0x28]
        mov      rdx, r15
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      SHORT G_M16487_IG12
-						;; size=21 bbWeight=400 PerfScore 1900.00
-G_M16487_IG09:
+       jmp      SHORT G_M16487_IG14
+						;; size=21 bbWeight=396 PerfScore 1881.00
+G_M16487_IG10:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rdx, gword ptr [rcx+0x08]
        lea      rcx, bword ptr [r15+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        xor      ecx, ecx
        mov      dword ptr [r15+0x34], ecx
-       mov      ecx, dword ptr [rbp-0x40]
-       mov      dword ptr [r15+0x5C], ecx
-       mov      rcx, gword ptr [r15+0x50]
-       xor      eax, eax
-       cmp      dword ptr [rcx+0x08], 0
-       jle      SHORT G_M16487_IG11
-						;; size=45 bbWeight=100 PerfScore 1400.00
-G_M16487_IG10:
-       mov      edx, eax
-       xor      r8d, r8d
-       mov      dword ptr [rcx+4*rdx+0x10], r8d
-       inc      eax
-       cmp      dword ptr [rcx+0x08], eax
-       jg       SHORT G_M16487_IG10
-						;; size=17 bbWeight=99.52 PerfScore 572.22
+       mov      dword ptr [r15+0x5C], r12d
+       mov      rax, gword ptr [r15+0x50]
+						;; size=34 bbWeight=99 PerfScore 866.25
 G_M16487_IG11:
-       mov      byte  ptr [r15+0x60], 0
-       mov      r15, gword ptr [r15+0x38]
-       test     r15, r15
-       jne      G_M16487_IG05
-						;; size=18 bbWeight=100.00 PerfScore 425.00
+       cmp      dword ptr [rax+0x08], 0
+       jle      SHORT G_M16487_IG13
+						;; size=6 bbWeight=99 PerfScore 396.00
 G_M16487_IG12:
+       mov      edx, ecx
+       xor      r8d, r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
+       inc      ecx
+       cmp      dword ptr [rax+0x08], ecx
+       jg       SHORT G_M16487_IG12
+						;; size=17 bbWeight=98.52 PerfScore 566.50
+G_M16487_IG13:
+       mov      byte  ptr [r15+0x60], 0
+       mov      rdx, gword ptr [r15+0x38]
+       test     rdx, rdx
+       jne      G_M16487_IG06
+						;; size=18 bbWeight=99.00 PerfScore 420.75
+G_M16487_IG14:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rcx, gword ptr [rcx+0x20]
        test     rcx, rcx
-       je       G_M16487_IG24
-						;; size=20 bbWeight=800 PerfScore 3400.00
-G_M16487_IG13:
+       je       G_M16487_IG25
+						;; size=20 bbWeight=792 PerfScore 3366.00
+G_M16487_IG15:
        mov      rax, gword ptr [rbp+0xC0]
        mov      rax, gword ptr [rax+0x10]
        mov      eax, dword ptr [rax+0x08]
@@ -699,17 +707,17 @@ G_M16487_IG13:
        mov      ecx, dword ptr [rcx+0x08]
        mov      rax, gword ptr [rbp+0xC0]
        mov      dword ptr [rax+0x58], ecx
-						;; size=61 bbWeight=400 PerfScore 7200.00
-G_M16487_IG14:
+						;; size=61 bbWeight=396 PerfScore 7128.00
+G_M16487_IG16:
        mov      rdx, gword ptr [rbp+0xC0]
-       mov      r15d, dword ptr [rbp+0xBC]
-       mov      dword ptr [rdx+0x4C], r15d
-						;; size=18 bbWeight=100 PerfScore 300.00
-G_M16487_IG15:
+       mov      r12d, dword ptr [rbp+0xBC]
+       mov      dword ptr [rdx+0x4C], r12d
+						;; size=18 bbWeight=99 PerfScore 297.00
+G_M16487_IG17:
        vmovdqu  xmm0, xmmword ptr [rdi]
        vmovdqu  xmmword ptr [rbp-0x50], xmm0
-						;; size=9 bbWeight=100 PerfScore 500.00
-G_M16487_IG16:
+						;; size=9 bbWeight=99 PerfScore 495.00
+G_M16487_IG18:
        lea      rdx, [rbp-0x50]
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rax, gword ptr [rbp+0xC0]
@@ -718,53 +726,48 @@ G_M16487_IG16:
        call     [rax+0x20]<unknown method>
        mov      rcx, gword ptr [rbp+0xC0]
        mov      r15, gword ptr [rcx+0x28]
-       mov      rcx, gword ptr [r15+0x50]
-       cmp      dword ptr [rcx+0x08], 0
-       jbe      G_M16487_IG29
-       cmp      dword ptr [rcx+0x10], 0
-       jle      G_M16487_IG27
-						;; size=63 bbWeight=100 PerfScore 2250.00
-G_M16487_IG17:
+       mov      rax, gword ptr [r15+0x50]
+       cmp      dword ptr [rax+0x08], 0
+       jbe      G_M16487_IG54
+       cmp      dword ptr [rax+0x10], 0
+       jle      G_M16487_IG28
+						;; size=63 bbWeight=99 PerfScore 2227.50
+G_M16487_IG19:
        test     sil, sil
-       jne      SHORT G_M16487_IG18
+       jne      SHORT G_M16487_IG20
        lea      rcx, bword ptr [r15+0x08]
        mov      rdx, r14
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp+0xC0]
        xor      rcx, rcx
        mov      gword ptr [rdx+0x28], rcx
-						;; size=30 bbWeight=400 PerfScore 2100.00
-G_M16487_IG18:
+						;; size=30 bbWeight=396 PerfScore 2079.00
+G_M16487_IG20:
        mov      rdx, gword ptr [rbp+0xC0]
        mov      edx, dword ptr [rdx+0x4C]
        mov      rcx, r15
        mov      r9d, ebx
        xor      r8d, r8d
        call     [<unknown method>]
-						;; size=25 bbWeight=400 PerfScore 2700.00
-G_M16487_IG19:
-       cmp      dword ptr [r15+0x30], 0
-       je       G_M16487_IG33
-						;; size=11 bbWeight=100 PerfScore 400.00
-G_M16487_IG20:
-       test     sil, sil
-       je       G_M16487_IG32
-						;; size=9 bbWeight=99.98 PerfScore 124.98
+						;; size=25 bbWeight=396 PerfScore 2673.00
 G_M16487_IG21:
-       mov      rdx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
-       cmp      qword ptr [r12+0x18], rdx
-       jne      G_M16487_IG28
-       inc      dword ptr [r13]
-						;; size=25 bbWeight=99.98 PerfScore 724.86
+       cmp      dword ptr [r15+0x30], 0
+       je       G_M16487_IG63
+						;; size=11 bbWeight=99 PerfScore 396.00
 G_M16487_IG22:
-       mov      rcx, gword ptr [rbp+0xC0]
-       mov      ecx, dword ptr [rcx+0x4C]
-       mov      eax, ecx
-       mov      r8d, eax
-       cmp      dword ptr [r15+0x14], 0
-       je       G_M16487_IG30
-						;; size=26 bbWeight=99.98 PerfScore 749.86
+       test     sil, sil
+       je       G_M16487_IG58
+						;; size=9 bbWeight=98.98 PerfScore 123.73
 G_M16487_IG23:
+       inc      dword ptr [r13]
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      eax, dword ptr [rcx+0x4C]
+       mov      r12d, eax
+       mov      dword ptr [rbp+0xBC], r12d
+       cmp      dword ptr [r15+0x14], 0
+       je       G_M16487_IG59
+						;; size=35 bbWeight=98.98 PerfScore 1113.53
+G_M16487_IG24:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rcx, gword ptr [rcx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
@@ -780,12 +783,283 @@ G_M16487_IG23:
        mov      ecx, dword ptr [rcx+0x08]
        mov      rdx, gword ptr [rbp+0xC0]
        mov      dword ptr [rdx+0x58], ecx
-       mov      dword ptr [rbp+0xBC], r8d
-       mov      r15d, eax
+       mov      r15d, r12d
        mov      rdx, gword ptr [rbp+0x110]
-       jmp      G_M16487_IG02
-						;; size=94 bbWeight=99.98 PerfScore 2524.51
-G_M16487_IG24:
+       jmp      G_M16487_IG03
+						;; size=87 bbWeight=98.98 PerfScore 2400.29
+G_M16487_IG25:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rax, gword ptr [rbp+0xC0]
+       mov      rax, qword ptr [rax]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x38]<unknown method>
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      r15d, dword ptr [rdx+0x5C]
+       shl      r15d, 3
+       mov      r12d, r15d
+       cmp      r15d, 32
+       jge      SHORT G_M16487_IG26
+       mov      r12d, 32
+						;; size=54 bbWeight=396 PerfScore 5643.00
+G_M16487_IG26:
+       cmp      r15d, 16
+       jge      SHORT G_M16487_IG27
+       mov      r15d, 16
+						;; size=12 bbWeight=396 PerfScore 594.00
+G_M16487_IG27:
+       movsxd   rdx, r12d
+       mov      rcx, 0xD1FFAB1E      ; int[]
+       mov      rax, rcx
+       mov      qword ptr [rbp-0x58], rax
+       mov      rcx, rax
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      rcx, gword ptr [rbp+0xC0]
+       lea      rcx, bword ptr [rcx+0x10]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x50], r12d
+       movsxd   rdx, r15d
+       mov      rcx, qword ptr [rbp-0x58]
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      rcx, gword ptr [rbp+0xC0]
+       lea      rcx, bword ptr [rcx+0x18]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rcx+0x54], r15d
+       mov      rcx, qword ptr [rbp-0x58]
+       mov      edx, 32
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      rcx, gword ptr [rbp+0xC0]
+       lea      rcx, bword ptr [rcx+0x20]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x58], 32
+       jmp      G_M16487_IG16
+						;; size=152 bbWeight=396 PerfScore 9405.00
+G_M16487_IG28:
+       xor      rcx, rcx
+       mov      gword ptr [r15+0x08], rcx
+       mov      rcx, 0xD1FFAB1E      ; const ptr
+       mov      r15, gword ptr [rcx]
+       jmp      G_M16487_IG21
+						;; size=24 bbWeight=396 PerfScore 2178.00
+G_M16487_IG29:
+       mov      ecx, dword ptr [rdi+0x08]
+       mov      dword ptr [rbp-0x40], ecx
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rcx+0x60], ebx
+       mov      rcx, gword ptr [rbp+0xC0]
+       lea      rcx, bword ptr [rcx+0x30]
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rcx+0x48], r15d
+       mov      rcx, gword ptr [rbp+0xC0]
+       xor      eax, eax
+       mov      dword ptr [rcx+0x40], eax
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      eax, dword ptr [rbp-0x40]
+       mov      dword ptr [rcx+0x44], eax
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rcx+0x4C], r15d
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      r15, gword ptr [rcx+0x28]
+       test     r15, r15
+       jne      G_M16487_IG35
+						;; size=99 bbWeight=1.00 PerfScore 21.00
+G_M16487_IG30:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      r15, gword ptr [rcx+0x30]
+       mov      rdx, gword ptr [r15+0x18]
+       mov      gword ptr [rbp-0xB0], rdx
+       test     rdx, rdx
+       je       G_M16487_IG32
+       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
+       call     CORINFO_HELP_NEWSFAST
+       mov      gword ptr [rbp-0x68], rax
+       mov      gword ptr [rbp-0x70], r15
+       mov      rdx, gword ptr [rbp-0xB0]
+       mov      gword ptr [rbp-0x80], rdx
+       mov      r15d, dword ptr [r15+0x44]
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rdx, gword ptr [rcx+0x08]
+       mov      gword ptr [rbp-0x78], rdx
+       mov      rcx, 0xD1FFAB1E      ; int[]
+       mov      r11, rcx
+       mov      qword ptr [rbp-0x58], r11
+       mov      rcx, r11
+       mov      edx, 2
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      gword ptr [rbp-0x88], rax
+       mov      r8, gword ptr [rbp-0x68]
+       lea      rcx, bword ptr [r8+0x08]
+       mov      rdx, gword ptr [rbp-0x78]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      rax, gword ptr [rbp-0x68]
+       mov      qword ptr [rax+0x10], rcx
+       mov      gword ptr [rbp-0x68], rax
+       lea      rcx, bword ptr [rax+0x18]
+       mov      rdx, gword ptr [rbp-0x88]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      rax, gword ptr [rbp-0x68]
+       mov      dword ptr [rax+0x30], ecx
+       mov      rcx, 0xD1FFAB1E
+       mov      gword ptr [rax+0x28], rcx
+       mov      gword ptr [rbp-0x68], rax
+       lea      rcx, bword ptr [rax+0x40]
+       mov      rdx, gword ptr [rbp-0x70]
+       call     CORINFO_HELP_ASSIGN_REF
+       movsxd   rdx, r15d
+       mov      rcx, qword ptr [rbp-0x58]
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      r8, gword ptr [rbp-0x68]
+       lea      rcx, bword ptr [r8+0x50]
+       mov      rdx, rax
+						;; size=231 bbWeight=4.00 PerfScore 171.00
+G_M16487_IG31:
+       call     CORINFO_HELP_ASSIGN_REF
+       movsxd   rdx, r15d
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     CORINFO_HELP_NEWARR_1_OBJ
+       mov      r15, gword ptr [rbp-0x68]
+       lea      rcx, bword ptr [r15+0x48]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [r15+0x48]
+       mov      r8, gword ptr [r15+0x18]
+       xor      edx, edx
+       call     [CORINFO_HELP_ARRADDR_ST]
+       mov      eax, dword ptr [rbp-0x40]
+       mov      dword ptr [r15+0x5C], eax
+       mov      byte  ptr [r15+0x60], 0
+       lea      rcx, bword ptr [r15+0x68]
+       mov      rdx, gword ptr [rbp-0x80]
+       call     CORINFO_HELP_ASSIGN_REF
+       jmp      G_M16487_IG34
+						;; size=85 bbWeight=4.00 PerfScore 80.00
+G_M16487_IG32:
+       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
+       call     CORINFO_HELP_NEWSFAST
+       mov      gword ptr [rbp-0x60], rax
+       mov      gword ptr [rbp-0x98], r15
+       mov      r15d, dword ptr [r15+0x44]
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rdx, gword ptr [rcx+0x08]
+       mov      gword ptr [rbp-0x90], rdx
+       mov      rcx, 0xD1FFAB1E      ; int[]
+       mov      r9, rcx
+       mov      qword ptr [rbp-0x58], r9
+       mov      rcx, r9
+       mov      edx, 2
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      gword ptr [rbp-0xA0], rax
+       mov      r8, gword ptr [rbp-0x60]
+       lea      rcx, bword ptr [r8+0x08]
+       mov      rdx, gword ptr [rbp-0x90]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      rax, gword ptr [rbp-0x60]
+       mov      qword ptr [rax+0x10], rcx
+       mov      gword ptr [rbp-0x60], rax
+       lea      rcx, bword ptr [rax+0x18]
+       mov      rdx, gword ptr [rbp-0xA0]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      rax, gword ptr [rbp-0x60]
+       mov      dword ptr [rax+0x30], ecx
+       mov      rcx, 0xD1FFAB1E
+       mov      gword ptr [rax+0x28], rcx
+       mov      gword ptr [rbp-0x60], rax
+       lea      rcx, bword ptr [rax+0x40]
+       mov      rdx, gword ptr [rbp-0x98]
+       call     CORINFO_HELP_ASSIGN_REF
+       movsxd   rdx, r15d
+       mov      rcx, qword ptr [rbp-0x58]
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      r8, gword ptr [rbp-0x60]
+       lea      rcx, bword ptr [r8+0x50]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       movsxd   rdx, r15d
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     CORINFO_HELP_NEWARR_1_OBJ
+       mov      r15, gword ptr [rbp-0x60]
+       lea      rcx, bword ptr [r15+0x48]
+						;; size=232 bbWeight=4.00 PerfScore 150.00
+G_M16487_IG33:
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [r15+0x48]
+       mov      r8, gword ptr [r15+0x18]
+       xor      edx, edx
+       call     [CORINFO_HELP_ARRADDR_ST]
+       mov      eax, dword ptr [rbp-0x40]
+       mov      dword ptr [r15+0x5C], eax
+       mov      byte  ptr [r15+0x60], 0
+						;; size=36 bbWeight=4.00 PerfScore 46.00
+G_M16487_IG34:
+       mov      rcx, gword ptr [rbp+0xC0]
+       lea      rcx, bword ptr [rcx+0x28]
+       mov      rdx, r15
+       call     CORINFO_HELP_ASSIGN_REF
+       jmp      SHORT G_M16487_IG38
+						;; size=21 bbWeight=4.00 PerfScore 19.00
+G_M16487_IG35:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rdx, gword ptr [rcx+0x08]
+       lea      rcx, bword ptr [r15+0x08]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      dword ptr [r15+0x34], ecx
+       mov      ecx, dword ptr [rbp-0x40]
+       mov      dword ptr [r15+0x5C], ecx
+       mov      rax, gword ptr [r15+0x50]
+       xor      ecx, ecx
+       cmp      dword ptr [rax+0x08], 0
+       jle      SHORT G_M16487_IG37
+						;; size=45 bbWeight=1.00 PerfScore 14.00
+G_M16487_IG36:
+       mov      edx, ecx
+       xor      r8d, r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
+       inc      ecx
+       cmp      dword ptr [rax+0x08], ecx
+       jg       SHORT G_M16487_IG36
+						;; size=17 bbWeight=1.00 PerfScore 5.72
+G_M16487_IG37:
+       mov      byte  ptr [r15+0x60], 0
+       mov      rdx, gword ptr [r15+0x38]
+       test     rdx, rdx
+       jne      G_M16487_IG57
+						;; size=18 bbWeight=1.00 PerfScore 4.25
+G_M16487_IG38:
+       mov      rcx, gword ptr [rbp+0xC0]
+       cmp      gword ptr [rcx+0x20], 0
+       je       SHORT G_M16487_IG40
+						;; size=14 bbWeight=8.00 PerfScore 40.00
+G_M16487_IG39:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rcx, gword ptr [rcx+0x10]
+       mov      ecx, dword ptr [rcx+0x08]
+       mov      rax, gword ptr [rbp+0xC0]
+       mov      dword ptr [rax+0x50], ecx
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rcx, gword ptr [rcx+0x18]
+       mov      ecx, dword ptr [rcx+0x08]
+       mov      rax, gword ptr [rbp+0xC0]
+       mov      dword ptr [rax+0x54], ecx
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rcx, gword ptr [rcx+0x20]
+       mov      ecx, dword ptr [rcx+0x08]
+       mov      rax, gword ptr [rbp+0xC0]
+       mov      dword ptr [rax+0x58], ecx
+       jmp      G_M16487_IG43
+						;; size=77 bbWeight=4.00 PerfScore 92.00
+G_M16487_IG40:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rax, gword ptr [rbp+0xC0]
        mov      rax, qword ptr [rax]
@@ -796,15 +1070,15 @@ G_M16487_IG24:
        shl      r15d, 3
        mov      eax, r15d
        cmp      r15d, 32
-       jge      SHORT G_M16487_IG25
+       jge      SHORT G_M16487_IG41
        mov      eax, 32
-						;; size=53 bbWeight=400 PerfScore 5700.00
-G_M16487_IG25:
+						;; size=53 bbWeight=4.00 PerfScore 57.00
+G_M16487_IG41:
        cmp      r15d, 16
-       jge      SHORT G_M16487_IG26
+       jge      SHORT G_M16487_IG42
        mov      r15d, 16
-						;; size=12 bbWeight=400 PerfScore 600.00
-G_M16487_IG26:
+						;; size=12 bbWeight=4.00 PerfScore 6.00
+G_M16487_IG42:
        mov      dword ptr [rbp-0x3C], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; int[]
@@ -837,51 +1111,162 @@ G_M16487_IG26:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp+0xC0]
        mov      dword ptr [rdx+0x58], 32
-       jmp      G_M16487_IG14
-						;; size=157 bbWeight=400 PerfScore 10300.00
-G_M16487_IG27:
-       xor      rdx, rdx
-       mov      gword ptr [r15+0x08], rdx
-       mov      rdx, 0xD1FFAB1E      ; const ptr
-       mov      r15, gword ptr [rdx]
-       jmp      G_M16487_IG19
-						;; size=24 bbWeight=400 PerfScore 2200.00
-G_M16487_IG28:
+						;; size=152 bbWeight=4.00 PerfScore 95.00
+G_M16487_IG43:
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      r15d, dword ptr [rbp+0xBC]
+       mov      dword ptr [rdx+0x4C], r15d
+						;; size=18 bbWeight=1.00 PerfScore 3.00
+G_M16487_IG44:
+       vmovdqu  xmm0, xmmword ptr [rdi]
+       vmovdqu  xmmword ptr [rbp-0x50], xmm0
+						;; size=9 bbWeight=1.00 PerfScore 5.00
+G_M16487_IG45:
+       lea      rdx, [rbp-0x50]
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rax, gword ptr [rbp+0xC0]
+       mov      rax, qword ptr [rax]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x20]<unknown method>
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      r15, gword ptr [rcx+0x28]
+       mov      rax, gword ptr [r15+0x50]
+       cmp      dword ptr [rax+0x08], 0
+       jbe      G_M16487_IG54
+       cmp      dword ptr [rax+0x10], 0
+       jle      SHORT G_M16487_IG48
+						;; size=59 bbWeight=1.00 PerfScore 22.50
+G_M16487_IG46:
+       test     sil, sil
+       jne      SHORT G_M16487_IG47
+       lea      rcx, bword ptr [r15+0x08]
+       mov      rdx, r14
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rdx, gword ptr [rbp+0xC0]
+       xor      rcx, rcx
+       mov      gword ptr [rdx+0x28], rcx
+						;; size=30 bbWeight=4.00 PerfScore 21.00
+G_M16487_IG47:
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      edx, dword ptr [rdx+0x4C]
+       mov      rcx, r15
+       mov      r9d, ebx
+       xor      r8d, r8d
+       call     [<unknown method>]
+       jmp      SHORT G_M16487_IG49
+						;; size=27 bbWeight=4.00 PerfScore 35.00
+G_M16487_IG48:
+       xor      rcx, rcx
+       mov      gword ptr [r15+0x08], rcx
+       mov      rcx, 0xD1FFAB1E      ; const ptr
+       mov      r15, gword ptr [rcx]
+						;; size=19 bbWeight=4.00 PerfScore 14.00
+G_M16487_IG49:
+       cmp      dword ptr [r15+0x30], 0
+       je       G_M16487_IG63
+						;; size=11 bbWeight=1.00 PerfScore 4.00
+G_M16487_IG50:
+       test     sil, sil
+       je       G_M16487_IG56
+						;; size=9 bbWeight=1.00 PerfScore 1.25
+G_M16487_IG51:
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r12+0x18], rcx
+       jne      G_M16487_IG55
+       inc      dword ptr [r13]
+						;; size=25 bbWeight=1.00 PerfScore 7.25
+G_M16487_IG52:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      eax, dword ptr [rcx+0x4C]
+       mov      r8d, eax
+       cmp      dword ptr [r15+0x14], 0
+       je       G_M16487_IG61
+						;; size=24 bbWeight=1.00 PerfScore 7.25
+G_M16487_IG53:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rcx, gword ptr [rcx+0x10]
+       mov      ecx, dword ptr [rcx+0x08]
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x50], ecx
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rcx, gword ptr [rcx+0x18]
+       mov      ecx, dword ptr [rcx+0x08]
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x54], ecx
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rcx, gword ptr [rcx+0x20]
+       mov      ecx, dword ptr [rcx+0x08]
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x58], ecx
+       mov      dword ptr [rbp+0xBC], r8d
+       mov      r15d, eax
+       mov      rdx, gword ptr [rbp+0x110]
+       jmp      G_M16487_IG29
+						;; size=94 bbWeight=1.00 PerfScore 25.25
+G_M16487_IG54:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M16487_IG55:
        mov      rdx, r13
        mov      r8, r15
        mov      rcx, gword ptr [r12+0x08]
        call     [r12+0x18]<unknown method>
        test     eax, eax
-       je       SHORT G_M16487_IG33
-       jmp      G_M16487_IG22
-						;; size=25 bbWeight=99.98 PerfScore 874.83
-G_M16487_IG29:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M16487_IG30:
+       jne      G_M16487_IG52
+       jmp      G_M16487_IG63
+						;; size=29 bbWeight=0 PerfScore 0.00
+G_M16487_IG56:
+       mov      r8, gword ptr [rbp+0xC0]
+       xor      rcx, rcx
+       mov      gword ptr [r8+0x28], rcx
+       jmp      G_M16487_IG51
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M16487_IG57:
+       mov      r8, rdx
+       xor      rcx, rcx
+       mov      gword ptr [r8+0x18], rcx
+       jmp      G_M16487_IG38
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M16487_IG58:
+       mov      rdx, gword ptr [rbp+0xC0]
+       xor      r8, r8
+       mov      gword ptr [rdx+0x28], r8
+       jmp      G_M16487_IG23
+						;; size=19 bbWeight=0 PerfScore 0.00
+G_M16487_IG59:
+       mov      eax, dword ptr [rdi+0x08]
+       mov      r8d, 1
+       mov      rdx, gword ptr [rbp+0x110]
+       test     byte  ptr [rdx+0x40], 64
+       je       SHORT G_M16487_IG60
+       xor      eax, eax
+       mov      r8d, -1
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M16487_IG60:
+       cmp      r12d, eax
+       je       SHORT G_M16487_IG63
+       add      r8d, r12d
+       mov      r15d, r8d
+       mov      dword ptr [rbp+0xBC], r15d
+       jmp      G_M16487_IG24
+						;; size=23 bbWeight=0 PerfScore 0.00
+G_M16487_IG61:
        mov      ecx, dword ptr [rdi+0x08]
        mov      r8d, 1
        mov      rdx, gword ptr [rbp+0x110]
        test     byte  ptr [rdx+0x40], 64
-       je       SHORT G_M16487_IG31
+       je       SHORT G_M16487_IG62
        xor      ecx, ecx
        mov      r8d, -1
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG31:
+G_M16487_IG62:
        cmp      eax, ecx
-       je       SHORT G_M16487_IG33
-       add      r8d, eax
-       mov      r15d, r8d
+       je       SHORT G_M16487_IG63
+       lea      r15d, [rax+r8]
        mov      r8d, r15d
-       jmp      G_M16487_IG23
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M16487_IG32:
-       mov      rcx, gword ptr [rbp+0xC0]
-       xor      rdx, rdx
-       mov      gword ptr [rcx+0x28], rdx
-       jmp      G_M16487_IG21
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M16487_IG33:
+       jmp      G_M16487_IG53
+						;; size=16 bbWeight=0 PerfScore 0.00
+G_M16487_IG63:
        mov      rcx, gword ptr [rbp+0xC0]
        xor      rdx, rdx
        mov      gword ptr [rcx+0x08], rdx
@@ -891,8 +1276,8 @@ G_M16487_IG33:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=37 bbWeight=0.01 PerfScore 0.06
-G_M16487_IG34:
-       add      rsp, 408
+G_M16487_IG64:
+       add      rsp, 424
        pop      rbx
        pop      rsi
        pop      rdi
@@ -903,7 +1288,7 @@ G_M16487_IG34:
        pop      rbp
        ret      
 						;; size=20 bbWeight=0.01 PerfScore 0.05
-G_M16487_IG35:
+G_M16487_IG65:
        push     rbp
        push     r15
        push     r14
@@ -915,9 +1300,9 @@ G_M16487_IG35:
        sub      rsp, 40
        mov      rbp, qword ptr [rcx+0x20]
        mov      qword ptr [rsp+0x20], rbp
-       lea      rbp, [rbp+0xD0]
+       lea      rbp, [rbp+0xE0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M16487_IG36:
+G_M16487_IG66:
        mov      rcx, gword ptr [rbp+0xC0]
        xor      rdx, rdx
        mov      gword ptr [rcx+0x08], rdx
@@ -927,7 +1312,7 @@ G_M16487_IG36:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M16487_IG37:
+G_M16487_IG67:
        add      rsp, 40
        pop      rbx
        pop      rsi
@@ -940,7 +1325,7 @@ G_M16487_IG37:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1807, prolog size 143, PerfScore 95146.36, instruction count 403, allocated bytes for code 1807 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
+; Total bytes of code 3317, prolog size 143, PerfScore 90638.45, instruction count 727, allocated bytes for code 3317 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Instrumented Tier0)
@@ -1313,72 +1698,73 @@ G_M16487_IG28:
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 5230.75
+; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 5116.19
 ; 4 inlinees with PGO data; 12 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T21] (  8, 102.00)     ref  ->  [rbp+0x110]  this class-hnd EH-live single-def tier0-frame <System.Text.RegularExpressions.Regex>
-;  V01 arg1         [V01,T25] (  4,   3.14)     ref  ->  r13         class-hnd single-def <System.String>
+;  V00 this         [V00,T20] (  8, 102.00)     ref  ->  [rbp+0x110]  this class-hnd EH-live single-def tier0-frame <System.Text.RegularExpressions.Regex>
+;  V01 arg1         [V01,T25] (  4,   2.81)     ref  ->  r15         class-hnd single-def <System.String>
 ;  V02 arg2         [V02,T24] (  5,   9   )   byref  ->   r8         ld-addr-op single-def
 ;  V03 arg3         [V03,T05] ( 14, 402.00)     int  ->  registers  
-;  V04 arg4         [V04,T13] (  6, 300.00)   byref  ->  rsi         single-def
-;  V05 arg5         [V05,T14] (  6, 300.00)     ref  ->  rdi         class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
-;  V06 arg6         [V06,T18] (  4, 200   )     int  ->  r14         single-def
-;  V07 arg7         [V07,T20] (  4, 200.00)   ubyte  ->  r15         single-def
-;  V08 loc0         [V08,T00] ( 92,2602.78)     ref  ->  [rbp+0xC0]  do-not-enreg[H] class-hnd EH-live tier0-frame <System.Text.RegularExpressions.RegexRunner>
-;  V09 loc1         [V09,T19] (  6, 200.00)     int  ->  [rbp+0xBC]  tier0-frame
+;  V04 arg4         [V04,T19] (  5, 200.00)   byref  ->  r14         single-def
+;  V05 arg5         [V05,T28] (  6,   1.00)     ref  ->  registers   class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
+;  V06 arg6         [V06,T16] (  4, 200   )     int  ->  rsi         single-def
+;  V07 arg7         [V07,T18] (  4, 200.00)   ubyte  ->  rdi         single-def
+;  V08 loc0         [V08,T00] ( 93,2602.63)     ref  ->  [rbp+0xC0]  do-not-enreg[H] class-hnd EH-live tier0-frame <System.Text.RegularExpressions.RegexRunner>
+;  V09 loc1         [V09,T17] (  6, 200.00)     int  ->  [rbp+0xBC]  tier0-frame
 ;* V10 loc2         [V10    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.Match>
-;  V11 loc3         [V11,T40] (  6,   0   )     int  ->  registers  
-;  V12 loc4         [V12,T41] (  6,   0   )     int  ->   r8        
+;  V11 loc3         [V11,T41] (  6,   0   )     int  ->  registers  
+;  V12 loc4         [V12,T42] (  6,   0   )     int  ->  registers  
 ;  V13 OutArgs      [V13    ] (  1,   1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V14 tmp1         [V14    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "dup spill" <<unknown class>>
 ;* V15 tmp2         [V15    ] (  0,   0   )     ref  ->  zero-ref   
-;  V16 tmp3         [V16,T11] (  4, 400.00)     int  ->   r8         "dup spill"
-;  V17 tmp4         [V17,T15] (  4, 200.00)     int  ->  rax         "guarded devirt return temp"
+;  V16 tmp3         [V16,T10] (  4, 400.00)     int  ->  rax         "dup spill"
+;  V17 tmp4         [V17,T23] (  2,   0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp5         [V18    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Text.RegularExpressions.Regex+<>c>
-;* V19 tmp6         [V19,T28] (  0,   0   )     int  ->  zero-ref    "OSR entry state var"
+;* V19 tmp6         [V19,T29] (  0,   0   )     int  ->  zero-ref    "OSR entry state var"
 ;* V20 tmp7         [V20    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp8         [V21,T01] ( 16, 801.02)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp9         [V22,T42] (  4,   0   )     int  ->  rbx         "dup spill"
-;  V23 tmp10        [V23,T37] ( 14,   0   )     int  ->  rbx         "Inline stloc first use temp"
-;  V24 tmp11        [V24,T38] (  8,   0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V21 tmp8         [V21,T01] ( 16, 801.57)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp9         [V22,T43] (  4,   0   )     int  ->  rbx         "dup spill"
+;  V23 tmp10        [V23,T38] ( 14,   0   )     int  ->  rbx         "Inline stloc first use temp"
+;  V24 tmp11        [V24,T39] (  8,   0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
 ;* V25 tmp12        [V25    ] (  0,   0   )     ref  ->  zero-ref   
-;  V26 tmp13        [V26,T39] (  6,   0   )     ref  ->  [rbp-0x58]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp13        [V26,T40] (  6,   0   )     ref  ->  [rbp-0x58]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp14        [V27    ] (  0,   0   )     ref  ->  zero-ref   
-;  V28 tmp15        [V28,T35] (  6,   0.20)     ref  ->  rdx        
-;  V29 tmp16        [V29,T30] (  8,   0.80)     ref  ->  [rbp-0x60]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp17        [V30,T32] (  4,   0.40)     ref  ->  rax         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp15        [V28,T36] (  6,   0.20)     ref  ->  rdx        
+;  V29 tmp16        [V29,T31] (  8,   0.80)     ref  ->  [rbp-0x60]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp17        [V30,T33] (  4,   0.40)     ref  ->  rax         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp18        [V31    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp19        [V32    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp20        [V33    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp21        [V34,T33] (  4,   0.40)     ref  ->  [rbp-0x68]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp22        [V35,T09] (  4, 400.68)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
+;  V34 tmp21        [V34,T34] (  4,   0.40)     ref  ->  [rbp-0x68]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp22        [V35,T08] (  4, 401.04)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
 ;* V36 tmp23        [V36    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp24        [V37,T12] (  7, 398.83)     ref  ->  r10         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V38 tmp25        [V38,T04] ( 10, 499.15)     int  ->   r8         "Inline stloc first use temp"
-;  V39 tmp26        [V39,T08] (  6, 400.68)     ref  ->   r9         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp24        [V37,T11] (  6, 301.24)     ref  ->  registers   class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V38 tmp25        [V38,T04] ( 10, 503.14)     int  ->  registers   "Inline stloc first use temp"
+;  V39 tmp26        [V39,T07] (  6, 401.04)     ref  ->  r10         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp27        [V40    ] (  0,   0   )     ref  ->  zero-ref   
-;  V41 tmp28        [V41,T10] ( 10, 400.00)     ref  ->  rbx         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
+;  V41 tmp28        [V41,T12] (  9, 300.00)     ref  ->  rbx         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp29        [V42    ] (  0,   0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V43 tmp30        [V43,T07] ( 12, 401.14)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V43 tmp30        [V43,T09] ( 12, 400.81)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V44 tmp31        [V44    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Text.RegularExpressions.CompiledRegexRunner>
 ;* V45 tmp32        [V45    ] (  0,   0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V46 tmp33        [V46    ] (  0,   0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
-;* V47 tmp34        [V47,T22] (  0,   0   )   byref  ->  zero-ref    "field V42._reference (fldOffset=0x0)" P-INDEP
-;* V48 tmp35        [V48,T23] (  0,   0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V49 tmp36        [V49,T17] (  4, 101   )   byref  ->  r12         single-def "V02.[000..008)"
-;  V50 tmp37        [V50,T06] ( 14, 301.27)     int  ->  [rbp-0x40]  spill-single-def "V02.[008..012)"
+;* V47 tmp34        [V47,T21] (  0,   0   )   byref  ->  zero-ref    "field V42._reference (fldOffset=0x0)" P-INDEP
+;* V48 tmp35        [V48,T22] (  0,   0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
+;  V49 tmp36        [V49,T15] (  4, 101.00)   byref  ->  r12         single-def "V02.[000..008)"
+;  V50 tmp37        [V50,T06] ( 14, 301.36)     int  ->  [rbp-0x40]  spill-single-def "V02.[008..012)"
 ;* V51 tmp38        [V51    ] (  0,   0   )     ref  ->  zero-ref    "argument with side effect"
-;  V52 tmp39        [V52    ] (  9, 600   )  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V53 tmp40        [V53,T02] (  6, 600   )     ref  ->  r11         "argument with side effect"
-;  V54 tmp41        [V54,T03] (  6, 600   )     ref  ->  rax         "arr expr"
-;  V55 PSPSym       [V55,T29] (  1,   1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
-;  V56 cse0         [V56,T34] (  3,   0.30)     ref  ->  [rbp-0x70]  spill-single-def "CSE #02: conservative"
-;  V57 cse1         [V57,T36] (  3,   0.00)     ref  ->  [rbp-0x78]  spill-single-def "CSE #12: conservative"
-;  V58 cse2         [V58,T16] (  3, 297.34)     ref  ->   r8         "CSE #06: moderate"
-;  V59 cse3         [V59,T26] (  5,   3.00)     ref  ->  rbx         "CSE #17: moderate"
-;  V60 cse4         [V60,T31] ( 12,   0.40)     ref  ->  rbx         multi-def "CSE #01: conservative"
-;  V61 cse5         [V61,T27] (  3,   3.00)     int  ->  rdx         "CSE #16: moderate"
+;  V52 tmp39        [V52    ] (  9, 600.00)  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V53 tmp40        [V53,T02] (  6, 600.00)     ref  ->   r9         "argument with side effect"
+;  V54 tmp41        [V54,T03] (  6, 600.00)     ref  ->  rax         "arr expr"
+;  V55 PSPSym       [V55,T30] (  1,   1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
+;  V56 cse0         [V56,T35] (  3,   0.30)     ref  ->  [rbp-0x70]  spill-single-def "CSE #02: conservative"
+;  V57 cse1         [V57,T37] (  3,   0.00)     ref  ->  [rbp-0x78]  spill-single-def "CSE #12: conservative"
+;  V58 cse2         [V58,T14] (  5, 297.52)     ref  ->  rbx         "CSE #06: aggressive"
+;  V59 cse3         [V59,T27] (  5,   3.01)     ref  ->  rbx         "CSE #17: moderate"
+;  V60 cse4         [V60,T32] ( 12,   0.40)     ref  ->  rbx         multi-def "CSE #01: conservative"
+;  V61 cse5         [V61,T13] (  3, 298.23)     int  ->  rdx         "CSE #05: aggressive"
+;  V62 cse6         [V62,T26] (  3,   3.01)     int  ->  rcx         "CSE #16: moderate"
 ;
 ; Lcl frame size = 120
 
@@ -1398,14 +1784,14 @@ G_M16487_IG01:
        mov      qword ptr [rbp-0x50], rax
        mov      qword ptr [rbp-0x88], rsp
        mov      rax, gword ptr [rbp+0x110]
-       mov      r13, gword ptr [rbp+0x118]
+       mov      r15, gword ptr [rbp+0x118]
        mov      r8, bword ptr [rbp+0x120]
        mov      ebx, dword ptr [rbp+0x128]
-       mov      rsi, bword ptr [rbp+0x130]
-       mov      rdi, gword ptr [rbp+0x138]
-       mov      r14d, dword ptr [rbp+0x140]
-       mov      r15d, dword ptr [rbp+0x148]
-						;; size=144 bbWeight=1 PerfScore 29.00
+       mov      r14, bword ptr [rbp+0x130]
+       mov      r13, gword ptr [rbp+0x138]
+       mov      esi, dword ptr [rbp+0x140]
+       mov      edi, dword ptr [rbp+0x148]
+						;; size=142 bbWeight=1 PerfScore 29.00
 G_M16487_IG02:
        mov      r12, bword ptr [r8]
        mov      r8d, dword ptr [r8+0x08]
@@ -1413,15 +1799,20 @@ G_M16487_IG02:
 						;; size=11 bbWeight=1 PerfScore 5.00
 G_M16487_IG03:
        cmp      gword ptr [rbp+0xC0], 0
-       je       G_M16487_IG40
+       je       G_M16487_IG31
+       test     r13, r13
+       je       G_M16487_IG31
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rdx, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
        cmp      qword ptr [rcx], rdx
-       jne      G_M16487_IG40
-						;; size=40 bbWeight=0.00 PerfScore 0.01
+       jne      G_M16487_IG31
+       mov      rcx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
+       cmp      qword ptr [r13+0x18], rcx
+       jne      G_M16487_IG31
+						;; size=69 bbWeight=0.00 PerfScore 0.02
 G_M16487_IG04:
        mov      rcx, gword ptr [rbp+0xC0]
-       mov      dword ptr [rcx+0x60], r14d
+       mov      dword ptr [rcx+0x60], esi
        mov      rcx, gword ptr [rbp+0xC0]
        lea      rcx, bword ptr [rcx+0x30]
        mov      rdx, rax
@@ -1432,15 +1823,15 @@ G_M16487_IG04:
        xor      eax, eax
        mov      dword ptr [rcx+0x40], eax
        mov      rcx, gword ptr [rbp+0xC0]
-       mov      eax, dword ptr [rbp-0x40]
-       mov      dword ptr [rcx+0x44], eax
+       mov      r13d, dword ptr [rbp-0x40]
+       mov      dword ptr [rcx+0x44], r13d
        mov      rcx, gword ptr [rbp+0xC0]
        mov      dword ptr [rcx+0x4C], ebx
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [rcx+0x28]
        test     rbx, rbx
-       je       G_M16487_IG23
-						;; size=95 bbWeight=99 PerfScore 1806.75
+       je       G_M16487_IG40
+						;; size=96 bbWeight=99.00 PerfScore 1806.75
 G_M16487_IG05:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rdx, gword ptr [rcx+0x08]
@@ -1448,134 +1839,100 @@ G_M16487_IG05:
        call     CORINFO_HELP_ASSIGN_REF
        xor      r8d, r8d
        mov      dword ptr [rbx+0x34], r8d
-       mov      eax, dword ptr [rbp-0x40]
-       mov      dword ptr [rbx+0x5C], eax
-       mov      r10, gword ptr [rbx+0x50]
-						;; size=37 bbWeight=99.17 PerfScore 966.90
+       mov      dword ptr [rbx+0x5C], r13d
+       mov      rax, gword ptr [rbx+0x50]
+						;; size=35 bbWeight=99.26 PerfScore 868.51
 G_M16487_IG06:
-       cmp      dword ptr [r10+0x08], 0
+       mov      edx, dword ptr [rax+0x08]
+       test     edx, edx
        jle      SHORT G_M16487_IG08
-       align    [2 bytes for IG07]
-						;; size=9 bbWeight=99.17 PerfScore 421.47
+       align    [0 bytes for IG07]
+						;; size=7 bbWeight=99.26 PerfScore 322.59
 G_M16487_IG07:
-       mov      edx, r8d
-       xor      ecx, ecx
-       mov      dword ptr [r10+4*rdx+0x10], ecx
+       mov      ecx, r8d
+       xor      r10d, r10d
+       mov      dword ptr [rax+4*rcx+0x10], r10d
        inc      r8d
-       cmp      dword ptr [r10+0x08], r8d
+       cmp      edx, r8d
        jg       SHORT G_M16487_IG07
-						;; size=19 bbWeight=98.75 PerfScore 567.79
+						;; size=19 bbWeight=99.71 PerfScore 299.14
 G_M16487_IG08:
        mov      byte  ptr [rbx+0x60], 0
-       mov      r9, gword ptr [rbx+0x38]
-       test     r9, r9
-       jne      G_M16487_IG17
-						;; size=17 bbWeight=99.17 PerfScore 421.47
+       mov      r10, gword ptr [rbx+0x38]
+       test     r10, r10
+       jne      G_M16487_IG46
+						;; size=17 bbWeight=99.26 PerfScore 421.85
 G_M16487_IG09:
        mov      r8, gword ptr [rbp+0xC0]
-       mov      r8, gword ptr [r8+0x20]
-       test     r8, r8
-       je       G_M16487_IG49
-						;; size=20 bbWeight=99.17 PerfScore 421.47
+       mov      rbx, gword ptr [r8+0x20]
+       test     rbx, rbx
+       je       G_M16487_IG42
+						;; size=20 bbWeight=99.16 PerfScore 421.43
 G_M16487_IG10:
-       mov      rdx, gword ptr [rbp+0xC0]
-       mov      rdx, gword ptr [rdx+0x10]
-       mov      edx, dword ptr [rdx+0x08]
-       mov      rcx, gword ptr [rbp+0xC0]
-       mov      dword ptr [rcx+0x50], edx
-       mov      rdx, gword ptr [rbp+0xC0]
-       mov      rdx, gword ptr [rdx+0x18]
-       mov      edx, dword ptr [rdx+0x08]
-       mov      rcx, gword ptr [rbp+0xC0]
-       mov      dword ptr [rcx+0x54], edx
+       mov      r8, gword ptr [rbp+0xC0]
+       mov      r8, gword ptr [r8+0x10]
        mov      r8d, dword ptr [r8+0x08]
        mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x50], r8d
+       mov      r8, gword ptr [rbp+0xC0]
+       mov      r8, gword ptr [r8+0x18]
+       mov      r8d, dword ptr [r8+0x08]
+       mov      rdx, gword ptr [rbp+0xC0]
+       mov      dword ptr [rdx+0x54], r8d
+       mov      r8d, dword ptr [rbx+0x08]
+       mov      rdx, gword ptr [rbp+0xC0]
        mov      dword ptr [rdx+0x58], r8d
-						;; size=63 bbWeight=99 PerfScore 1782.00
+						;; size=67 bbWeight=99.00 PerfScore 1782.00
 G_M16487_IG11:
        mov      r8, gword ptr [rbp+0xC0]
        mov      ebx, dword ptr [rbp+0xBC]
        mov      dword ptr [r8+0x4C], ebx
        mov      r8, gword ptr [rbp+0xC0]
-       mov      r11, gword ptr [r8+0x70]
+       mov      r9, gword ptr [r8+0x70]
        mov      bword ptr [rbp-0x50], r12
-       mov      dword ptr [rbp-0x48], eax
+       mov      dword ptr [rbp-0x48], r13d
        lea      r8, [rbp-0x50]
        mov      rdx, gword ptr [rbp+0xC0]
-       mov      rcx, gword ptr [r11+0x08]
-       call     [r11+0x18]<unknown method>
+       mov      rcx, gword ptr [r9+0x08]
+       call     [r9+0x18]<unknown method>
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [rcx+0x28]
        mov      rax, gword ptr [rbx+0x50]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M16487_IG46
+       jbe      G_M16487_IG57
        cmp      dword ptr [rax+0x10], 0
-       jle      G_M16487_IG53
-						;; size=89 bbWeight=99 PerfScore 2722.50
+       jle      G_M16487_IG47
+						;; size=90 bbWeight=99.00 PerfScore 2722.50
 G_M16487_IG12:
-       test     r15b, r15b
-       je       SHORT G_M16487_IG19
-						;; size=5 bbWeight=99.00 PerfScore 123.75
+       test     dil, dil
+       je       G_M16487_IG39
+						;; size=9 bbWeight=99 PerfScore 123.75
 G_M16487_IG13:
        mov      rdx, gword ptr [rbp+0xC0]
        mov      edx, dword ptr [rdx+0x4C]
        mov      rcx, rbx
-       mov      r9d, r14d
+       mov      r9d, esi
        xor      r8d, r8d
        call     [<unknown method>]
-						;; size=25 bbWeight=99.00 PerfScore 668.25
+						;; size=25 bbWeight=99 PerfScore 668.25
 G_M16487_IG14:
        cmp      dword ptr [rbx+0x30], 0
-       je       G_M16487_IG64
-						;; size=10 bbWeight=99 PerfScore 396.00
+       je       G_M16487_IG60
+						;; size=10 bbWeight=99.00 PerfScore 396.00
 G_M16487_IG15:
-       test     r15b, r15b
-       je       SHORT G_M16487_IG18
-						;; size=5 bbWeight=99.00 PerfScore 123.75
+       test     dil, dil
+       je       G_M16487_IG37
+						;; size=9 bbWeight=99.00 PerfScore 123.75
 G_M16487_IG16:
-       mov      rdx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
-       cmp      qword ptr [rdi+0x18], rdx
-       jne      SHORT G_M16487_IG20
-       inc      dword ptr [rsi]
-       jmp      SHORT G_M16487_IG21
-						;; size=20 bbWeight=99.00 PerfScore 915.74
-G_M16487_IG17:
-       xor      rcx, rcx
-       mov      gword ptr [r9+0x18], rcx
-       jmp      G_M16487_IG09
-						;; size=11 bbWeight=0 PerfScore 0.00
-G_M16487_IG18:
+       inc      dword ptr [r14]
        mov      rcx, gword ptr [rbp+0xC0]
-       xor      rax, rax
-       mov      gword ptr [rcx+0x28], rax
-       jmp      SHORT G_M16487_IG16
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M16487_IG19:
-       lea      rcx, bword ptr [rbx+0x08]
-       mov      rdx, r13
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rdx, gword ptr [rbp+0xC0]
-       xor      rcx, rcx
-       mov      gword ptr [rdx+0x28], rcx
-       jmp      SHORT G_M16487_IG13
-						;; size=27 bbWeight=1.13 PerfScore 6.78
-G_M16487_IG20:
-       mov      rdx, rsi
-       mov      r8, rbx
-       mov      rcx, gword ptr [rdi+0x08]
-       call     [rdi+0x18]<unknown method>
-       test     eax, eax
-       je       G_M16487_IG64
-						;; size=21 bbWeight=99.00 PerfScore 668.25
-G_M16487_IG21:
-       mov      rcx, gword ptr [rbp+0xC0]
-       mov      r8d, dword ptr [rcx+0x4C]
-       mov      r10d, r8d
-       mov      dword ptr [rbp+0xBC], r10d
+       mov      eax, dword ptr [rcx+0x4C]
+       mov      r8d, eax
+       mov      dword ptr [rbp+0xBC], r8d
        cmp      dword ptr [rbx+0x14], 0
-       je       G_M16487_IG54
-						;; size=31 bbWeight=99.00 PerfScore 816.75
-G_M16487_IG22:
+       je       G_M16487_IG35
+						;; size=33 bbWeight=99.00 PerfScore 1113.74
+G_M16487_IG17:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rcx, gword ptr [rcx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
@@ -1591,46 +1948,11 @@ G_M16487_IG22:
        mov      ecx, dword ptr [rcx+0x08]
        mov      rdx, gword ptr [rbp+0xC0]
        mov      dword ptr [rdx+0x58], ecx
-       mov      ebx, r10d
+       mov      ebx, r8d
        mov      rax, gword ptr [rbp+0x110]
        jmp      G_M16487_IG04
 						;; size=87 bbWeight=99.00 PerfScore 2400.74
-G_M16487_IG23:
-       mov      rcx, gword ptr [rbp+0xC0]
-       mov      rbx, gword ptr [rcx+0x30]
-       mov      rdx, gword ptr [rbx+0x18]
-       mov      gword ptr [rbp-0x70], rdx
-       test     rdx, rdx
-       je       G_M16487_IG52
-       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
-       call     CORINFO_HELP_NEWSFAST
-       mov      rdx, rax
-       mov      rax, rbx
-       mov      r10, gword ptr [rbp-0x70]
-       mov      gword ptr [rbp-0x68], r10
-       mov      r11d, dword ptr [rbp-0x40]
-       mov      dword ptr [rsp+0x20], r11d
-       mov      r8d, dword ptr [rbx+0x44]
-       mov      r9, gword ptr [rbp+0xC0]
-       mov      r9, gword ptr [r9+0x08]
-       mov      gword ptr [rbp-0x60], rdx
-       mov      rcx, rdx
-       mov      rdx, rax
-       call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
-       mov      rbx, gword ptr [rbp-0x60]
-       lea      rcx, bword ptr [rbx+0x68]
-       mov      rdx, gword ptr [rbp-0x68]
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rdx, rbx
-						;; size=117 bbWeight=0.10 PerfScore 2.60
-G_M16487_IG24:
-       mov      rcx, gword ptr [rbp+0xC0]
-       lea      rcx, bword ptr [rcx+0x28]
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      eax, dword ptr [rbp-0x40]
-       jmp      G_M16487_IG09
-						;; size=24 bbWeight=0.10 PerfScore 0.54
-G_M16487_IG25:
+G_M16487_IG18:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rdx, gword ptr [rcx+0x08]
        lea      rcx, bword ptr [rbx+0x08]
@@ -1639,34 +1961,33 @@ G_M16487_IG25:
        mov      dword ptr [rbx+0x34], r8d
        mov      eax, dword ptr [rbp-0x40]
        mov      dword ptr [rbx+0x5C], eax
-       mov      r10, gword ptr [rbx+0x50]
-						;; size=37 bbWeight=1.00 PerfScore 9.77
-G_M16487_IG26:
-       mov      edx, dword ptr [r10+0x08]
-       test     edx, edx
-       jle      SHORT G_M16487_IG28
-						;; size=8 bbWeight=1.00 PerfScore 3.26
-G_M16487_IG27:
-       mov      ecx, r8d
+       mov      r8, gword ptr [rbx+0x50]
+       xor      edx, edx
+       mov      ecx, dword ptr [r8+0x08]
+       test     ecx, ecx
+       jle      SHORT G_M16487_IG20
+						;; size=47 bbWeight=1.00 PerfScore 13.28
+G_M16487_IG19:
+       mov      r10d, edx
        xor      r9d, r9d
-       mov      dword ptr [r10+4*rcx+0x10], r9d
-       inc      r8d
-       cmp      edx, r8d
-       jg       SHORT G_M16487_IG27
-						;; size=19 bbWeight=1.00 PerfScore 2.99
-G_M16487_IG28:
+       mov      dword ptr [r8+4*r10+0x10], r9d
+       inc      edx
+       cmp      ecx, edx
+       jg       SHORT G_M16487_IG19
+						;; size=17 bbWeight=1.01 PerfScore 3.02
+G_M16487_IG20:
        mov      byte  ptr [rbx+0x60], 0
-       mov      r9, gword ptr [rbx+0x38]
-       test     r9, r9
-       jne      G_M16487_IG57
+       mov      r10, gword ptr [rbx+0x38]
+       test     r10, r10
+       jne      G_M16487_IG49
 						;; size=17 bbWeight=1.00 PerfScore 4.26
-G_M16487_IG29:
+G_M16487_IG21:
        mov      r8, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [r8+0x20]
        test     rbx, rbx
-       je       G_M16487_IG43
+       je       G_M16487_IG34
 						;; size=20 bbWeight=1.00 PerfScore 4.26
-G_M16487_IG30:
+G_M16487_IG22:
        mov      r8, gword ptr [rbp+0xC0]
        mov      r8, gword ptr [r8+0x10]
        mov      r8d, dword ptr [r8+0x08]
@@ -1681,67 +2002,64 @@ G_M16487_IG30:
        mov      rdx, gword ptr [rbp+0xC0]
        mov      dword ptr [rdx+0x58], r8d
 						;; size=67 bbWeight=1.00 PerfScore 18.00
-G_M16487_IG31:
+G_M16487_IG23:
        mov      r8, gword ptr [rbp+0xC0]
        mov      ebx, dword ptr [rbp+0xBC]
        mov      dword ptr [r8+0x4C], ebx
        mov      r8, gword ptr [rbp+0xC0]
        mov      rdx, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
        cmp      qword ptr [r8], rdx
-       jne      G_M16487_IG61
-						;; size=43 bbWeight=1.00 PerfScore 8.25
-G_M16487_IG32:
+       jne      G_M16487_IG53
        mov      r8, gword ptr [rbp+0xC0]
-       mov      r11, gword ptr [r8+0x70]
+       mov      r9, gword ptr [r8+0x70]
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], eax
        lea      r8, [rbp-0x50]
        mov      rdx, gword ptr [rbp+0xC0]
-       mov      rcx, gword ptr [r11+0x08]
-       call     [r11+0x18]<unknown method>
-						;; size=37 bbWeight=1.00 PerfScore 11.50
-G_M16487_IG33:
+       mov      rcx, gword ptr [r9+0x08]
+       call     [r9+0x18]<unknown method>
+						;; size=80 bbWeight=1.00 PerfScore 19.75
+G_M16487_IG24:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [rcx+0x28]
        mov      rax, gword ptr [rbx+0x50]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M16487_IG46
+       jbe      G_M16487_IG57
        cmp      dword ptr [rax+0x10], 0
-       jle      G_M16487_IG62
-       test     r15b, r15b
-       je       G_M16487_IG44
+       jle      G_M16487_IG54
+       test     dil, dil
+       je       G_M16487_IG38
 						;; size=44 bbWeight=1.00 PerfScore 14.25
-G_M16487_IG34:
+G_M16487_IG25:
        mov      rdx, gword ptr [rbp+0xC0]
        mov      edx, dword ptr [rdx+0x4C]
        mov      rcx, rbx
-       mov      r9d, r14d
+       mov      r9d, esi
        xor      r8d, r8d
        call     [<unknown method>]
 						;; size=25 bbWeight=1.00 PerfScore 6.75
-G_M16487_IG35:
+G_M16487_IG26:
        cmp      dword ptr [rbx+0x30], 0
-       je       G_M16487_IG64
+       je       G_M16487_IG60
 						;; size=10 bbWeight=1.00 PerfScore 4.00
-G_M16487_IG36:
-       test     r15b, r15b
-       je       G_M16487_IG63
-						;; size=9 bbWeight=1.00 PerfScore 1.25
-G_M16487_IG37:
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rdi+0x18], rdx
-       jne      G_M16487_IG45
-       inc      dword ptr [rsi]
-						;; size=22 bbWeight=1.00 PerfScore 7.25
-G_M16487_IG38:
+G_M16487_IG27:
+       test     dil, dil
+       je       G_M16487_IG55
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r13+0x18], rcx
+       jne      G_M16487_IG56
+						;; size=29 bbWeight=1.00 PerfScore 5.50
+G_M16487_IG28:
+       inc      dword ptr [r14]
+						;; size=3 bbWeight=1.00 PerfScore 3.00
+G_M16487_IG29:
        mov      rcx, gword ptr [rbp+0xC0]
-       mov      r8d, dword ptr [rcx+0x4C]
-       mov      eax, r8d
+       mov      eax, dword ptr [rcx+0x4C]
        mov      r8d, eax
        cmp      dword ptr [rbx+0x14], 0
-       je       G_M16487_IG47
-						;; size=27 bbWeight=1.00 PerfScore 7.50
-G_M16487_IG39:
+       je       G_M16487_IG58
+						;; size=23 bbWeight=1.00 PerfScore 7.25
+G_M16487_IG30:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rcx, gword ptr [rcx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
@@ -1761,9 +2079,9 @@ G_M16487_IG39:
        mov      ebx, eax
        mov      rax, gword ptr [rbp+0x110]
 						;; size=88 bbWeight=1.00 PerfScore 23.25
-G_M16487_IG40:
+G_M16487_IG31:
        mov      rcx, gword ptr [rbp+0xC0]
-       mov      dword ptr [rcx+0x60], r14d
+       mov      dword ptr [rcx+0x60], esi
        mov      rcx, gword ptr [rbp+0xC0]
        lea      rcx, bword ptr [rcx+0x30]
        mov      rdx, rax
@@ -1781,15 +2099,15 @@ G_M16487_IG40:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [rcx+0x28]
        test     rbx, rbx
-       jne      G_M16487_IG25
-						;; size=95 bbWeight=1.00 PerfScore 18.25
-G_M16487_IG41:
+       jne      G_M16487_IG18
+						;; size=94 bbWeight=1.00 PerfScore 18.25
+G_M16487_IG32:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [rcx+0x30]
        mov      rdx, gword ptr [rbx+0x18]
        mov      gword ptr [rbp-0x78], rdx
        test     rdx, rdx
-       je       G_M16487_IG56
+       je       G_M16487_IG48
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      rdx, rax
@@ -1811,75 +2129,114 @@ G_M16487_IG41:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, rbx
 						;; size=117 bbWeight=0.00 PerfScore 0.03
-G_M16487_IG42:
+G_M16487_IG33:
        mov      rcx, gword ptr [rbp+0xC0]
        lea      rcx, bword ptr [rcx+0x28]
        call     CORINFO_HELP_ASSIGN_REF
        mov      eax, dword ptr [rbp-0x40]
-       jmp      G_M16487_IG29
+       jmp      G_M16487_IG21
 						;; size=24 bbWeight=0.00 PerfScore 0.01
-G_M16487_IG43:
-       jmp      G_M16487_IG58
+G_M16487_IG34:
+       jmp      G_M16487_IG50
 						;; size=5 bbWeight=0.50 PerfScore 1.00
-G_M16487_IG44:
+G_M16487_IG35:
+       mov      r13d, dword ptr [rbp-0x40]
+       mov      eax, r13d
+       mov      ecx, 1
+       mov      rdx, gword ptr [rbp+0x110]
+       test     byte  ptr [rdx+0x40], 64
+       je       SHORT G_M16487_IG36
+       xor      eax, eax
+       mov      ecx, -1
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M16487_IG36:
+       cmp      r8d, eax
+       je       G_M16487_IG60
+       add      ecx, r8d
+       mov      ebx, ecx
+       mov      dword ptr [rbp+0xBC], ebx
+       jmp      G_M16487_IG17
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16487_IG37:
+       mov      rcx, gword ptr [rbp+0xC0]
+       xor      rax, rax
+       mov      gword ptr [rcx+0x28], rax
+       jmp      G_M16487_IG16
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M16487_IG38:
        lea      rcx, bword ptr [rbx+0x08]
-       mov      rdx, r13
+       mov      rdx, r15
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp+0xC0]
        xor      rcx, rcx
        mov      gword ptr [rdx+0x28], rcx
-       jmp      G_M16487_IG34
-						;; size=30 bbWeight=0.01 PerfScore 0.07
-G_M16487_IG45:
-       mov      rdx, rsi
-       mov      r8, rbx
-       mov      rcx, gword ptr [rdi+0x08]
-       call     [rdi+0x18]<unknown method>
-       test     eax, eax
-       je       G_M16487_IG64
-       jmp      G_M16487_IG38
-						;; size=26 bbWeight=1.00 PerfScore 8.75
-G_M16487_IG46:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M16487_IG47:
-       mov      ebx, dword ptr [rbp-0x40]
-       mov      ecx, ebx
-       mov      r8d, 1
-       mov      rdx, gword ptr [rbp+0x110]
-       test     byte  ptr [rdx+0x40], 64
-       je       SHORT G_M16487_IG48
-       xor      ecx, ecx
-       mov      r8d, -1
-						;; size=32 bbWeight=0 PerfScore 0.00
-G_M16487_IG48:
-       cmp      eax, ecx
-       je       G_M16487_IG64
-       add      r8d, eax
-       mov      ecx, r8d
-       mov      r8d, ecx
-       jmp      G_M16487_IG39
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M16487_IG49:
-       mov      rcx, gword ptr [rbp+0xC0]
+       jmp      G_M16487_IG25
+						;; size=30 bbWeight=0.01 PerfScore 0.05
+G_M16487_IG39:
+       lea      rcx, bword ptr [rbx+0x08]
+       mov      rdx, r15
+       call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp+0xC0]
-       mov      rdx, qword ptr [rdx]
-       mov      rdx, qword ptr [rdx+0x40]
-       call     [rdx+0x38]<unknown method>
+       xor      rcx, rcx
+       mov      gword ptr [rdx+0x28], rcx
+       jmp      G_M16487_IG13
+						;; size=30 bbWeight=0.80 PerfScore 4.81
+G_M16487_IG40:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rbx, gword ptr [rcx+0x30]
+       mov      rax, gword ptr [rbx+0x18]
+       mov      gword ptr [rbp-0x70], rax
+       test     rax, rax
+       je       G_M16487_IG45
+       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
+       call     CORINFO_HELP_NEWSFAST
+       mov      rdx, rax
+       mov      rax, rbx
+       mov      r10, gword ptr [rbp-0x70]
+       mov      gword ptr [rbp-0x68], r10
+       mov      dword ptr [rsp+0x20], r13d
+       mov      r8d, dword ptr [rbx+0x44]
+       mov      r9, gword ptr [rbp+0xC0]
+       mov      r9, gword ptr [r9+0x08]
+       mov      gword ptr [rbp-0x60], rdx
+       mov      rcx, rdx
+       mov      rdx, rax
+       call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
+       mov      rbx, gword ptr [rbp-0x60]
+       lea      rcx, bword ptr [rbx+0x68]
+       mov      rdx, gword ptr [rbp-0x68]
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rdx, rbx
+						;; size=113 bbWeight=0.10 PerfScore 2.50
+G_M16487_IG41:
+       mov      rcx, gword ptr [rbp+0xC0]
+       lea      rcx, bword ptr [rcx+0x28]
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rbx, gword ptr [rcx+0x20]
+       test     rbx, rbx
+       jne      G_M16487_IG10
+						;; size=36 bbWeight=0.10 PerfScore 0.67
+G_M16487_IG42:
+       mov      rcx, gword ptr [rbp+0xC0]
+       mov      rax, gword ptr [rbp+0xC0]
+       mov      rax, qword ptr [rax]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x38]<unknown method>
        mov      rdx, gword ptr [rbp+0xC0]
        mov      ebx, dword ptr [rdx+0x5C]
        shl      ebx, 3
        mov      eax, ebx
        cmp      ebx, 32
-       jge      SHORT G_M16487_IG50
+       jge      SHORT G_M16487_IG43
        mov      eax, 32
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M16487_IG50:
+G_M16487_IG43:
        cmp      ebx, 16
-       jge      SHORT G_M16487_IG51
+       jge      SHORT G_M16487_IG44
        mov      ebx, 16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG51:
+G_M16487_IG44:
        mov      dword ptr [rbp-0x3C], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
@@ -1909,15 +2266,13 @@ G_M16487_IG51:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, gword ptr [rbp+0xC0]
        mov      dword ptr [rcx+0x58], 32
-       mov      eax, dword ptr [rbp-0x40]
        jmp      G_M16487_IG11
-						;; size=161 bbWeight=0 PerfScore 0.00
-G_M16487_IG52:
+						;; size=158 bbWeight=0 PerfScore 0.00
+G_M16487_IG45:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x58], rax
-       mov      eax, dword ptr [rbp-0x40]
-       mov      dword ptr [rsp+0x20], eax
+       mov      dword ptr [rsp+0x20], r13d
        mov      r8d, dword ptr [rbx+0x44]
        mov      rdx, rbx
        mov      r9, gword ptr [rbp+0xC0]
@@ -1926,33 +2281,21 @@ G_M16487_IG52:
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
        mov      rbx, gword ptr [rbp-0x58]
        mov      rdx, rbx
-       jmp      G_M16487_IG24
-						;; size=66 bbWeight=0 PerfScore 0.00
-G_M16487_IG53:
+       jmp      G_M16487_IG41
+						;; size=64 bbWeight=0 PerfScore 0.00
+G_M16487_IG46:
+       xor      rcx, rcx
+       mov      gword ptr [r10+0x18], rcx
+       jmp      G_M16487_IG09
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M16487_IG47:
        xor      rcx, rcx
        mov      gword ptr [rbx+0x08], rcx
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rbx, gword ptr [rcx]
        jmp      G_M16487_IG14
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16487_IG54:
-       mov      ebx, dword ptr [rbp-0x40]
-       mov      eax, ebx
-       mov      r8d, 1
-       mov      rdx, gword ptr [rbp+0x110]
-       test     byte  ptr [rdx+0x40], 64
-       je       SHORT G_M16487_IG55
-       xor      eax, eax
-       mov      r8d, -1
-						;; size=32 bbWeight=0 PerfScore 0.00
-G_M16487_IG55:
-       cmp      r10d, eax
-       je       G_M16487_IG64
-       add      r8d, r10d
-       mov      dword ptr [rbp+0xBC], r8d
-       jmp      G_M16487_IG22
-						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16487_IG56:
+G_M16487_IG48:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x58], rax
@@ -1966,17 +2309,17 @@ G_M16487_IG56:
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
        mov      rbx, gword ptr [rbp-0x58]
        mov      rdx, rbx
-       jmp      G_M16487_IG42
+       jmp      G_M16487_IG33
 						;; size=66 bbWeight=0 PerfScore 0.00
-G_M16487_IG57:
+G_M16487_IG49:
        xor      rcx, rcx
-       mov      gword ptr [r9+0x18], rcx
+       mov      gword ptr [r10+0x18], rcx
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rbx, gword ptr [rcx+0x20]
        test     rbx, rbx
-       jne      G_M16487_IG30
+       jne      G_M16487_IG22
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M16487_IG58:
+G_M16487_IG50:
        mov      rcx, gword ptr [rbp+0xC0]
        mov      rdx, gword ptr [rbp+0xC0]
        mov      rdx, qword ptr [rdx]
@@ -1987,15 +2330,15 @@ G_M16487_IG58:
        shl      ebx, 3
        mov      eax, ebx
        cmp      ebx, 32
-       jge      SHORT G_M16487_IG59
+       jge      SHORT G_M16487_IG51
        mov      eax, 32
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M16487_IG59:
+G_M16487_IG51:
        cmp      ebx, 16
-       jge      SHORT G_M16487_IG60
+       jge      SHORT G_M16487_IG52
        mov      ebx, 16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG60:
+G_M16487_IG52:
        mov      dword ptr [rbp-0x3C], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
@@ -2026,9 +2369,9 @@ G_M16487_IG60:
        mov      rdx, gword ptr [rbp+0xC0]
        mov      dword ptr [rdx+0x58], 32
        mov      eax, dword ptr [rbp-0x40]
-       jmp      G_M16487_IG31
+       jmp      G_M16487_IG23
 						;; size=161 bbWeight=0 PerfScore 0.00
-G_M16487_IG61:
+G_M16487_IG53:
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], eax
        lea      rdx, [rbp-0x50]
@@ -2037,22 +2380,55 @@ G_M16487_IG61:
        mov      r8, qword ptr [r8]
        mov      r8, qword ptr [r8+0x40]
        call     [r8+0x20]<unknown method>
-       jmp      G_M16487_IG33
+       jmp      G_M16487_IG24
 						;; size=41 bbWeight=0 PerfScore 0.00
-G_M16487_IG62:
-       xor      rcx, rcx
-       mov      gword ptr [rbx+0x08], rcx
-       mov      rcx, 0xD1FFAB1E      ; const ptr
-       mov      rbx, gword ptr [rcx]
-       jmp      G_M16487_IG35
+G_M16487_IG54:
+       xor      rdx, rdx
+       mov      gword ptr [rbx+0x08], rdx
+       mov      rdx, 0xD1FFAB1E      ; const ptr
+       mov      rbx, gword ptr [rdx]
+       jmp      G_M16487_IG26
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16487_IG63:
+G_M16487_IG55:
        mov      rcx, gword ptr [rbp+0xC0]
-       xor      rax, rax
-       mov      gword ptr [rcx+0x28], rax
-       jmp      G_M16487_IG37
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M16487_IG64:
+       xor      rdx, rdx
+       mov      gword ptr [rcx+0x28], rdx
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r13+0x18], rcx
+       je       G_M16487_IG28
+						;; size=33 bbWeight=0 PerfScore 0.00
+G_M16487_IG56:
+       mov      rdx, r14
+       mov      r8, rbx
+       mov      rcx, gword ptr [r13+0x08]
+       call     [r13+0x18]<unknown method>
+       test     eax, eax
+       jne      G_M16487_IG29
+       jmp      SHORT G_M16487_IG60
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M16487_IG57:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M16487_IG58:
+       mov      ebx, dword ptr [rbp-0x40]
+       mov      ecx, ebx
+       mov      edx, 1
+       mov      r8, gword ptr [rbp+0x110]
+       test     byte  ptr [r8+0x40], 64
+       je       SHORT G_M16487_IG59
+       xor      ecx, ecx
+       mov      edx, -1
+						;; size=31 bbWeight=0 PerfScore 0.00
+G_M16487_IG59:
+       cmp      eax, ecx
+       je       SHORT G_M16487_IG60
+       mov      rbx, r13
+       lea      ecx, [rax+rdx]
+       mov      r8d, ecx
+       mov      r13, rbx
+       jmp      G_M16487_IG30
+						;; size=21 bbWeight=0 PerfScore 0.00
+G_M16487_IG60:
        mov      rcx, gword ptr [rbp+0xC0]
        xor      rdx, rdx
        mov      gword ptr [rcx+0x08], rdx
@@ -2062,7 +2438,7 @@ G_M16487_IG64:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=37 bbWeight=0.00 PerfScore 0.00
-G_M16487_IG65:
+G_M16487_IG61:
        add      rsp, 376
        pop      rbx
        pop      rsi
@@ -2074,7 +2450,7 @@ G_M16487_IG65:
        pop      rbp
        ret      
 						;; size=20 bbWeight=0.00 PerfScore 0.00
-G_M16487_IG66:
+G_M16487_IG62:
        push     rbp
        push     r15
        push     r14
@@ -2088,17 +2464,17 @@ G_M16487_IG66:
        mov      qword ptr [rsp+0x28], rbp
        lea      rbp, [rbp+0xB0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M16487_IG67:
+G_M16487_IG63:
        mov      rcx, gword ptr [rbp+0xC0]
        xor      rdx, rdx
        mov      gword ptr [rcx+0x08], rdx
-       mov      rdx, gword ptr [rbp+0x110]
-       lea      rcx, bword ptr [rdx+0x38]
+       mov      r8, gword ptr [rbp+0x110]
+       lea      rcx, bword ptr [r8+0x38]
        mov      rdx, gword ptr [rbp+0xC0]
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M16487_IG68:
+G_M16487_IG64:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -2111,7 +2487,7 @@ G_M16487_IG68:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 2675, prolog size 144, PerfScore 15422.14, instruction count 592, allocated bytes for code 2675 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
+; Total bytes of code 2690, prolog size 142, PerfScore 13658.91, instruction count 590, allocated bytes for code 2690 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1-OSR)
 ; ============================================================
 
 ; Assembly listing for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
@@ -2202,44 +2578,44 @@ G_M11802_IG06:
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are invalid, and fgCalledCount is 2
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 2
 ; 4 inlinees with PGO data; 18 single block inlinees; 1 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T20] ( 12, 276359.50)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
-;  V01 arg1         [V01,T24] (  5,   3156.30)     ref  ->  r13         class-hnd single-def <System.String>
-;  V02 arg2         [V02,T33] (  4,      8   )   byref  ->   r8         ld-addr-op single-def
-;  V03 arg3         [V03,T08] ( 15,1105413   )     int  ->  registers  
-;  V04 arg4         [V04,T13] (  6, 829056   )   byref  ->  rsi         single-def
-;  V05 arg5         [V05,T14] (  6, 829056   )     ref  ->  rdi         class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
-;  V06 arg6         [V06,T18] (  4, 552706.00)     int  ->  r14         single-def
-;  V07 arg7         [V07,T19] (  4, 552705   )   ubyte  ->  r15         single-def
-;  V08 loc0         [V08,T00] ( 92,7192863.97)     ref  ->  [rbp-0x60]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
-;  V09 loc1         [V09,T17] (  7, 552706   )     int  ->  [rbp-0x3C] 
+;  V00 this         [V00,T19] ( 12, 270983.50)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
+;  V01 arg1         [V01,T26] (  5,   2198.78)     ref  ->  r13         class-hnd single-def <System.String>
+;  V02 arg2         [V02,T35] (  4,      8   )   byref  ->   r8         ld-addr-op single-def
+;  V03 arg3         [V03,T08] ( 15,1083909   )     int  ->  registers  
+;  V04 arg4         [V04,T18] (  5, 541952   )   byref  ->  r14         single-def
+;  V05 arg5         [V05,T25] (  6,   2711.76)     ref  ->  registers   class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[int]>
+;  V06 arg6         [V06,T16] (  4, 541954   )     int  ->  rsi         single-def
+;  V07 arg7         [V07,T17] (  4, 541953   )   ubyte  ->  rdi         single-def
+;  V08 loc0         [V08,T00] ( 93,7052531.29)     ref  ->  [rbp-0x60]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V09 loc1         [V09,T15] (  7, 541954   )     int  ->  [rbp-0x3C] 
 ;* V10 loc2         [V10    ] (  0,      0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.Match>
-;  V11 loc3         [V11,T42] (  6,      0   )     int  ->  registers  
-;  V12 loc4         [V12,T43] (  6,      0   )     int  ->   r8        
+;  V11 loc3         [V11,T44] (  6,      0   )     int  ->  registers  
+;  V12 loc4         [V12,T45] (  6,      0   )     int  ->  registers  
 ;  V13 OutArgs      [V13    ] (  1,      1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V14 tmp1         [V14,T36] (  2,      4   )     ref  ->   r8         class-hnd single-def "dup spill" <<unknown class>>
-;  V15 tmp2         [V15,T35] (  6,      5.50)     ref  ->  [rbp-0x68] 
-;  V16 tmp3         [V16,T10] (  4,1105408   )     int  ->   r8         "dup spill"
-;  V17 tmp4         [V17,T15] (  4, 552704   )     int  ->  rax         "guarded devirt return temp"
+;  V14 tmp1         [V14,T38] (  2,      4   )     ref  ->   r8         class-hnd single-def "dup spill" <<unknown class>>
+;  V15 tmp2         [V15,T37] (  6,      5.50)     ref  ->  [rbp-0x68] 
+;  V16 tmp3         [V16,T09] (  4,1083904   )     int  ->  rax         "dup spill"
+;  V17 tmp4         [V17,T21] (  2,      0   )     int  ->  rax         "guarded devirt return temp"
 ;* V18 tmp5         [V18    ] (  0,      0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Text.RegularExpressions.Regex+<>c>
 ;* V19 tmp6         [V19    ] (  0,      0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V20 tmp7         [V20,T01] ( 16,2213656.24)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V21 tmp8         [V21,T44] (  4,      0   )     int  ->  rbx         "dup spill"
-;  V22 tmp9         [V22,T39] ( 14,      0   )     int  ->  rbx         "Inline stloc first use temp"
-;  V23 tmp10        [V23,T40] (  8,      0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V20 tmp7         [V20,T01] ( 16,2172060.42)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V21 tmp8         [V21,T46] (  4,      0   )     int  ->  rbx         "dup spill"
+;  V22 tmp9         [V22,T41] ( 14,      0   )     int  ->  rbx         "Inline stloc first use temp"
+;  V23 tmp10        [V23,T42] (  8,      0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V24 tmp11        [V24    ] (  0,      0   )     ref  ->  zero-ref   
-;  V25 tmp12        [V25,T41] (  6,      0   )     ref  ->  [rbp-0x70]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V25 tmp12        [V25,T43] (  6,      0   )     ref  ->  [rbp-0x70]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V26 tmp13        [V26    ] (  0,      0   )     ref  ->  zero-ref   
-;  V27 tmp14        [V27,T32] (  6,    552.71)     ref  ->  rdx        
-;  V28 tmp15        [V28,T23] ( 30,   8290.59)     ref  ->  [rbp-0x78]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V29 tmp16        [V29,T27] (  4,   1105.41)     ref  ->  [rbp-0x80]  class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
-;  V30 tmp17        [V30,T25] (  6,   1658.12)     int  ->  rbx         "Inlining Arg"
-;  V31 tmp18        [V31,T28] (  4,   1105.41)     ref  ->  [rbp-0x88]  class-hnd exact "Inlining Arg" <System.String>
+;  V27 tmp14        [V27,T34] (  6,    541.95)     ref  ->  rdx        
+;  V28 tmp15        [V28,T24] ( 30,   8129.31)     ref  ->  [rbp-0x78]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V29 tmp16        [V29,T29] (  4,   1083.91)     ref  ->  [rbp-0x80]  class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V30 tmp17        [V30,T27] (  6,   1625.86)     int  ->  rbx         "Inlining Arg"
+;  V31 tmp18        [V31,T30] (  4,   1083.91)     ref  ->  [rbp-0x88]  class-hnd exact "Inlining Arg" <System.String>
 ;* V32 tmp19        [V32    ] (  0,      0   )     int  ->  zero-ref    "Inlining Arg"
-;  V33 tmp20        [V33,T29] (  4,   1105.41)     ref  ->  [rbp-0x90]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
+;  V33 tmp20        [V33,T31] (  4,   1083.91)     ref  ->  [rbp-0x90]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
 ;* V34 tmp21        [V34    ] (  0,      0   )     ref  ->  zero-ref   
 ;* V35 tmp22        [V35    ] (  0,      0   )     ref  ->  zero-ref   
 ;* V36 tmp23        [V36    ] (  0,      0   )     ref  ->  zero-ref   
@@ -2252,34 +2628,36 @@ G_M11802_IG06:
 ;* V43 tmp30        [V43    ] (  0,      0   )     ref  ->  zero-ref   
 ;* V44 tmp31        [V44    ] (  0,      0   )     int  ->  zero-ref   
 ;* V45 tmp32        [V45    ] (  0,      0   )     int  ->  zero-ref   
-;  V46 tmp33        [V46,T30] (  4,   1105.41)     ref  ->  [rbp-0x98]  class-hnd exact "Inlining Arg" <int[]>
-;  V47 tmp34        [V47,T07] (  4,1107300.16)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
+;  V46 tmp33        [V46,T32] (  4,   1083.91)     ref  ->  [rbp-0x98]  class-hnd exact "Inlining Arg" <int[]>
+;  V47 tmp34        [V47,T06] (  4,1086737.61)     ref  ->  [rbp-0xA0]  class-hnd exact "Inlining Arg" <System.String>
 ;* V48 tmp35        [V48    ] (  0,      0   )     int  ->  zero-ref    "Inlining Arg"
-;  V49 tmp36        [V49,T11] (  8,1104941.54)     ref  ->  r10         class-hnd "Inline stloc first use temp" <int[]>
-;  V50 tmp37        [V50,T04] ( 10,1379407.97)     int  ->   r8         "Inline stloc first use temp"
-;  V51 tmp38        [V51,T06] (  6,1107300.16)     ref  ->   r9         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V49 tmp36        [V49,T10] (  6, 816294.96)     ref  ->  registers   class-hnd "Inline stloc first use temp" <int[]>
+;  V50 tmp37        [V50,T04] ( 10,1363389.01)     int  ->  registers   "Inline stloc first use temp"
+;  V51 tmp38        [V51,T05] (  6,1086737.61)     ref  ->  r10         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V52 tmp39        [V52    ] (  0,      0   )     ref  ->  zero-ref   
-;  V53 tmp40        [V53,T09] ( 10,1105410   )     ref  ->  rbx         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
+;  V53 tmp40        [V53,T12] (  9, 812930   )     ref  ->  rbx         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V54 tmp41        [V54    ] (  0,      0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V55 tmp42        [V55,T05] ( 12,1108565.30)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V55 tmp42        [V55,T07] ( 12,1086103.78)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V56 tmp43        [V56    ] (  0,      0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Text.RegularExpressions.CompiledRegexRunner>
-;  V57 tmp44        [V57,T21] (  4, 276354.00)   byref  ->  r12         single-def "field V02._reference (fldOffset=0x0)" P-INDEP
-;  V58 tmp45        [V58,T12] ( 14, 829808.39)     int  ->  [rbp-0x44]  spill-single-def "field V02._length (fldOffset=0x8)" P-INDEP
+;  V57 tmp44        [V57,T20] (  4, 270978   )   byref  ->  r12         single-def "field V02._reference (fldOffset=0x0)" P-INDEP
+;  V58 tmp45        [V58,T11] ( 14, 813910.38)     int  ->  [rbp-0x44]  spill-single-def "field V02._length (fldOffset=0x8)" P-INDEP
 ;* V59 tmp46        [V59    ] (  0,      0   )   byref  ->  zero-ref    "field V19._reference (fldOffset=0x0)" P-INDEP
 ;* V60 tmp47        [V60    ] (  0,      0   )     int  ->  zero-ref    "field V19._length (fldOffset=0x8)" P-INDEP
 ;* V61 tmp48        [V61    ] (  0,      0   )   byref  ->  zero-ref    "field V54._reference (fldOffset=0x0)" P-INDEP
 ;* V62 tmp49        [V62    ] (  0,      0   )     int  ->  zero-ref    "field V54._length (fldOffset=0x8)" P-INDEP
 ;* V63 tmp50        [V63    ] (  0,      0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V64 tmp51        [V64,T37] (  3,      3   )     ref  ->  rcx         single-def "argument with side effect"
-;  V65 tmp52        [V65    ] (  9,1658118.00)  struct (16) [rbp-0x58]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V66 tmp53        [V66,T02] (  6,1658118.00)     ref  ->  r11         "argument with side effect"
-;  V67 tmp54        [V67,T03] (  6,1658118.00)     ref  ->  rax         "arr expr"
-;  V68 PSPSym       [V68,T38] (  1,      1   )    long  ->  [rbp-0xB8]  do-not-enreg[V] "PSPSym"
-;  V69 cse0         [V69,T31] (  3,    820.77)     ref  ->  [rbp-0xA0]  spill-single-def "CSE #02: moderate"
-;  V70 cse1         [V70,T34] (  3,      8.29)     ref  ->  [rbp-0xA8]  spill-single-def "CSE #13: conservative"
-;  V71 cse2         [V71,T16] (  3, 821703.05)     ref  ->  rdx         "CSE #08: moderate"
-;  V72 cse3         [V72,T22] (  5,   8300.03)     ref  ->  rbx         "CSE #21: moderate"
-;  V73 cse4         [V73,T26] ( 12,   1105.41)     ref  ->  rbx         multi-def "CSE #01: moderate"
+;  V64 tmp51        [V64,T39] (  3,      3   )     ref  ->  rcx         single-def "argument with side effect"
+;  V65 tmp52        [V65    ] (  9,1625862   )  struct (16) [rbp-0x58]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V66 tmp53        [V66,T02] (  6,1625862   )     ref  ->   r9         "argument with side effect"
+;  V67 tmp54        [V67,T03] (  6,1625862   )     ref  ->  rax         "arr expr"
+;  V68 PSPSym       [V68,T40] (  1,      1   )    long  ->  [rbp-0xB8]  do-not-enreg[V] "PSPSym"
+;  V69 cse0         [V69,T33] (  3,    804.80)     ref  ->  [rbp-0xA8]  spill-single-def "CSE #02: moderate"
+;  V70 cse1         [V70,T36] (  3,      8.13)     ref  ->  [rbp-0xB0]  spill-single-def "CSE #13: conservative"
+;  V71 cse2         [V71,T14] (  5, 806202.35)     ref  ->   r9         "CSE #08: moderate"
+;  V72 cse3         [V72,T23] (  5,   8143.46)     ref  ->  rbx         "CSE #21: moderate"
+;  V73 cse4         [V73,T28] ( 12,   1083.91)     ref  ->  rbx         multi-def "CSE #01: moderate"
+;  V74 cse5         [V74,T13] (  3, 808132.01)     int  ->  rdx         "CSE #07: moderate"
+;  V75 cse6         [V75,T22] (  3,   8162.95)     int  ->  rcx         "CSE #20: moderate"
 ;
 ; Lcl frame size = 168
 
@@ -2301,11 +2679,11 @@ G_M16487_IG01:
        mov      rax, rcx
        mov      r13, rdx
        mov      ebx, r9d
-       mov      rsi, bword ptr [rbp+0x30]
-       mov      rdi, gword ptr [rbp+0x38]
-       mov      r14d, dword ptr [rbp+0x40]
-       mov      r15d, dword ptr [rbp+0x48]
-						;; size=69 bbWeight=1 PerfScore 16.75
+       mov      r14, bword ptr [rbp+0x30]
+       mov      r15, gword ptr [rbp+0x38]
+       mov      esi, dword ptr [rbp+0x40]
+       mov      edi, dword ptr [rbp+0x48]
+						;; size=67 bbWeight=1 PerfScore 16.75
 G_M16487_IG02:
        mov      r12, bword ptr [r8]
        mov      edx, dword ptr [r8+0x08]
@@ -2315,12 +2693,20 @@ G_M16487_IG02:
        xor      r8, r8
        xchg     gword ptr [rcx], r8
        test     r8, r8
-       je       G_M16487_IG65
-						;; size=31 bbWeight=1 PerfScore 30.00
+       jne      SHORT G_M16487_IG04
+						;; size=27 bbWeight=1 PerfScore 30.00
 G_M16487_IG03:
+       mov      rcx, gword ptr [rax+0x10]
+       mov      r8, qword ptr [rcx]
+       mov      r8, qword ptr [r8+0x40]
+       call     [r8+0x20]<unknown method>
+       mov      r8, rax
+       mov      rax, gword ptr [rbp+0x10]
+						;; size=22 bbWeight=0.50 PerfScore 5.12
+G_M16487_IG04:
        mov      gword ptr [rbp-0x60], r8
 						;; size=4 bbWeight=1 PerfScore 1.00
-G_M16487_IG04:
+G_M16487_IG05:
        mov      gword ptr [rbp-0x68], r8
        lea      rcx, bword ptr [r8+0x08]
        mov      rdx, r13
@@ -2330,13 +2716,18 @@ G_M16487_IG04:
        mov      rcx, gword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.RegexRunner:InitializeTimeout(System.TimeSpan):this]
        mov      dword ptr [rbp-0x3C], ebx
+       test     r15, r15
+       je       G_M16487_IG32
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
        mov      r8, gword ptr [rbp-0x60]
        cmp      qword ptr [r8], rcx
-       jne      G_M16487_IG40
-						;; size=60 bbWeight=1 PerfScore 16.00
-G_M16487_IG05:
-       mov      dword ptr [r8+0x60], r14d
+       jne      G_M16487_IG32
+       mov      rcx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
+       cmp      qword ptr [r15+0x18], rcx
+       jne      G_M16487_IG32
+						;; size=89 bbWeight=1 PerfScore 21.50
+G_M16487_IG06:
+       mov      dword ptr [r8+0x60], esi
        lea      rcx, bword ptr [r8+0x30]
        mov      rdx, gword ptr [rbp+0x10]
        call     CORINFO_HELP_ASSIGN_REF
@@ -2344,140 +2735,104 @@ G_M16487_IG05:
        mov      dword ptr [r8+0x48], ebx
        xor      ecx, ecx
        mov      dword ptr [r8+0x40], ecx
-       mov      eax, dword ptr [rbp-0x44]
-       mov      dword ptr [r8+0x44], eax
+       mov      r15d, dword ptr [rbp-0x44]
+       mov      dword ptr [r8+0x44], r15d
        mov      dword ptr [r8+0x4C], ebx
        mov      rbx, gword ptr [r8+0x28]
        test     rbx, rbx
-       je       G_M16487_IG23
-						;; size=55 bbWeight=273589.47 PerfScore 3556663.11
-G_M16487_IG06:
+       je       G_M16487_IG38
+						;; size=56 bbWeight=268267.23 PerfScore 3487473.99
+G_M16487_IG07:
        mov      rdx, gword ptr [r8+0x08]
        lea      rcx, bword ptr [rbx+0x08]
        call     CORINFO_HELP_ASSIGN_REF
        xor      r8d, r8d
        mov      dword ptr [rbx+0x34], r8d
-       mov      eax, dword ptr [rbp-0x44]
-       mov      dword ptr [rbx+0x5C], eax
-       mov      r10, gword ptr [rbx+0x50]
-						;; size=30 bbWeight=274056.79 PerfScore 2397996.91
-G_M16487_IG07:
-       cmp      dword ptr [r10+0x08], 0
-       jle      SHORT G_M16487_IG09
-       align    [0 bytes for IG08]
-						;; size=7 bbWeight=274056.79 PerfScore 1096227.16
+       mov      dword ptr [rbx+0x5C], r15d
+       mov      rax, gword ptr [rbx+0x50]
+						;; size=28 bbWeight=268967.56 PerfScore 2084498.58
 G_M16487_IG08:
-       mov      edx, r8d
-       xor      ecx, ecx
-       mov      dword ptr [r10+4*rdx+0x10], ecx
-       inc      r8d
-       cmp      dword ptr [r10+0x08], r8d
-       jg       SHORT G_M16487_IG08
-						;; size=19 bbWeight=272889.28 PerfScore 1569113.33
+       mov      edx, dword ptr [rax+0x08]
+       test     edx, edx
+       jle      SHORT G_M16487_IG10
+       align    [0 bytes for IG09]
+						;; size=7 bbWeight=268967.56 PerfScore 874144.57
 G_M16487_IG09:
-       mov      byte  ptr [rbx+0x60], 0
-       mov      r9, gword ptr [rbx+0x38]
-       test     r9, r9
-       jne      G_M16487_IG17
-						;; size=17 bbWeight=274056.79 PerfScore 1164741.35
+       mov      ecx, r8d
+       xor      r10d, r10d
+       mov      dword ptr [rax+4*rcx+0x10], r10d
+       inc      r8d
+       cmp      edx, r8d
+       jg       SHORT G_M16487_IG09
+						;; size=19 bbWeight=270196.89 PerfScore 810590.67
 G_M16487_IG10:
-       mov      r8, gword ptr [rbp-0x60]
-       mov      rdx, gword ptr [r8+0x20]
-       test     rdx, rdx
-       je       G_M16487_IG50
-						;; size=17 bbWeight=274056.79 PerfScore 1164741.35
+       mov      byte  ptr [rbx+0x60], 0
+       mov      r10, gword ptr [rbx+0x38]
+       test     r10, r10
+       jne      G_M16487_IG46
+						;; size=17 bbWeight=268967.56 PerfScore 1143112.13
 G_M16487_IG11:
-       mov      rcx, gword ptr [r8+0x10]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x50], ecx
-       mov      rcx, gword ptr [r8+0x18]
-       mov      ecx, dword ptr [rcx+0x08]
-       mov      dword ptr [r8+0x54], ecx
-       mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r8+0x58], edx
-						;; size=29 bbWeight=273589.47 PerfScore 3556663.11
+       mov      r8, gword ptr [rbp-0x60]
+       mov      r9, gword ptr [r8+0x20]
+       test     r9, r9
+       je       G_M16487_IG47
+						;; size=17 bbWeight=268967.56 PerfScore 1143112.13
 G_M16487_IG12:
+       mov      rdx, gword ptr [r8+0x10]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x50], edx
+       mov      rdx, gword ptr [r8+0x18]
+       mov      edx, dword ptr [rdx+0x08]
+       mov      dword ptr [r8+0x54], edx
+       mov      edx, dword ptr [r9+0x08]
+       mov      dword ptr [r8+0x58], edx
+						;; size=30 bbWeight=268267.23 PerfScore 3487473.99
+G_M16487_IG13:
        mov      ebx, dword ptr [rbp-0x3C]
        mov      dword ptr [r8+0x4C], ebx
-       mov      r11, gword ptr [r8+0x70]
+       mov      r9, gword ptr [r8+0x70]
        mov      bword ptr [rbp-0x58], r12
-       mov      dword ptr [rbp-0x50], eax
+       mov      dword ptr [rbp-0x50], r15d
        lea      r8, [rbp-0x58]
        mov      rdx, gword ptr [rbp-0x60]
-       mov      rcx, gword ptr [r11+0x08]
-       call     [r11+0x18]<unknown method>
+       mov      rcx, gword ptr [r9+0x08]
+       call     [r9+0x18]<unknown method>
        mov      rdx, gword ptr [rbp-0x60]
        mov      rbx, gword ptr [rdx+0x28]
        mov      rax, gword ptr [rbx+0x50]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M16487_IG47
+       jbe      G_M16487_IG60
        cmp      dword ptr [rax+0x10], 0
-       jle      G_M16487_IG54
-       test     r15b, r15b
-       je       SHORT G_M16487_IG19
-						;; size=71 bbWeight=273589.47 PerfScore 7318518.32
-G_M16487_IG13:
+       jle      G_M16487_IG50
+       test     dil, dil
+       je       G_M16487_IG37
+						;; size=76 bbWeight=268267.23 PerfScore 7176148.40
+G_M16487_IG14:
        mov      rdx, gword ptr [rbp-0x60]
        mov      edx, dword ptr [rdx+0x4C]
        mov      rcx, rbx
-       mov      r9d, r14d
+       mov      r9d, esi
        xor      r8d, r8d
        call     [<unknown method>]
-						;; size=22 bbWeight=273589.47 PerfScore 1846728.92
-G_M16487_IG14:
-       cmp      dword ptr [rbx+0x30], 0
-       je       G_M16487_IG66
-						;; size=10 bbWeight=273589.47 PerfScore 1094357.88
+						;; size=22 bbWeight=268267.23 PerfScore 1810803.80
 G_M16487_IG15:
-       test     r15b, r15b
-       je       SHORT G_M16487_IG18
-						;; size=5 bbWeight=273588.48 PerfScore 341985.60
+       cmp      dword ptr [rbx+0x30], 0
+       je       G_M16487_IG63
+						;; size=10 bbWeight=268267.23 PerfScore 1073068.92
 G_M16487_IG16:
-       mov      rdx, 0xD1FFAB1E      ; code for System.Text.RegularExpressions.Regex+<>c:<Count>b__57_0(byref,System.Text.RegularExpressions.Match):ubyte:this
-       cmp      qword ptr [rdi+0x18], rdx
-       jne      SHORT G_M16487_IG20
-       inc      dword ptr [rsi]
-       jmp      SHORT G_M16487_IG21
-						;; size=20 bbWeight=273588.48 PerfScore 2530693.44
+       test     dil, dil
+       je       G_M16487_IG44
+						;; size=9 bbWeight=268266.24 PerfScore 335332.80
 G_M16487_IG17:
-       mov      rbx, gword ptr [rbp-0x60]
-       xor      rcx, rcx
-       mov      gword ptr [r9+0x18], rcx
-       jmp      G_M16487_IG10
-       align    [0 bytes for IG28]
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M16487_IG18:
-       xor      rcx, rcx
+       inc      dword ptr [r14]
        mov      rdx, gword ptr [rbp-0x60]
-       mov      gword ptr [rdx+0x28], rcx
-       jmp      SHORT G_M16487_IG16
-						;; size=12 bbWeight=0 PerfScore 0.00
-G_M16487_IG19:
-       lea      rcx, bword ptr [rbx+0x08]
-       mov      rdx, r13
-       call     CORINFO_HELP_ASSIGN_REF
-       xor      rdx, rdx
-       mov      rax, gword ptr [rbp-0x60]
-       mov      gword ptr [rax+0x28], rdx
-       jmp      SHORT G_M16487_IG13
-						;; size=24 bbWeight=3121.77 PerfScore 18730.59
-G_M16487_IG20:
-       mov      rdx, rsi
-       mov      r8, rbx
-       mov      rcx, gword ptr [rdi+0x08]
-       call     [rdi+0x18]<unknown method>
-       test     eax, eax
-       je       G_M16487_IG66
-						;; size=21 bbWeight=273588.48 PerfScore 1846722.24
-G_M16487_IG21:
-       mov      rdx, gword ptr [rbp-0x60]
-       mov      r8d, dword ptr [rdx+0x4C]
-       mov      r10d, r8d
-       mov      dword ptr [rbp-0x3C], r10d
+       mov      eax, dword ptr [rdx+0x4C]
+       mov      r8d, eax
+       mov      dword ptr [rbp-0x3C], r8d
        cmp      dword ptr [rbx+0x14], 0
-       je       G_M16487_IG55
-						;; size=25 bbWeight=273588.48 PerfScore 2257104.96
-G_M16487_IG22:
+       je       G_M16487_IG42
+						;; size=27 bbWeight=268266.24 PerfScore 3017995.20
+G_M16487_IG18:
        mov      rcx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [rdx+0x50], ecx
@@ -2487,185 +2842,111 @@ G_M16487_IG22:
        mov      rcx, gword ptr [rdx+0x20]
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [rdx+0x58], ecx
-       mov      ebx, r10d
+       mov      ebx, r8d
        mov      r8, rdx
-       jmp      G_M16487_IG05
-						;; size=41 bbWeight=273588.48 PerfScore 4787798.40
-G_M16487_IG23:
-       mov      rbx, gword ptr [r8+0x30]
-       mov      rdx, gword ptr [rbx+0x18]
-       mov      gword ptr [rbp-0xA0], rdx
-       test     rdx, rdx
-       je       G_M16487_IG53
-       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
-       call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x78], rax
-       mov      gword ptr [rbp-0x80], rbx
-       mov      r8, gword ptr [rbp-0xA0]
-       mov      gword ptr [rbp-0x90], r8
-       mov      ebx, dword ptr [rbx+0x44]
-       mov      r10, gword ptr [rbp-0x60]
-       mov      r9, gword ptr [r10+0x08]
-       mov      gword ptr [rbp-0x88], r9
-       mov      rcx, 0xD1FFAB1E      ; int[]
-       mov      edx, 2
-       call     CORINFO_HELP_NEWARR_1_VC
-       mov      gword ptr [rbp-0x98], rax
-       mov      rdx, gword ptr [rbp-0x78]
-       lea      rcx, bword ptr [rdx+0x08]
-       mov      rdx, gword ptr [rbp-0x88]
-       call     CORINFO_HELP_ASSIGN_REF
-       xor      ecx, ecx
-       mov      rdx, gword ptr [rbp-0x78]
-       mov      qword ptr [rdx+0x10], rcx
-       mov      gword ptr [rbp-0x78], rdx
-       lea      rcx, bword ptr [rdx+0x18]
-       mov      rdx, gword ptr [rbp-0x98]
-       call     CORINFO_HELP_ASSIGN_REF
-       xor      ecx, ecx
-       mov      rdx, gword ptr [rbp-0x78]
-       mov      dword ptr [rdx+0x30], ecx
-       mov      rcx, 0xD1FFAB1E
-       mov      gword ptr [rdx+0x28], rcx
-       mov      gword ptr [rbp-0x78], rdx
-       lea      rcx, bword ptr [rdx+0x40]
-       mov      rdx, gword ptr [rbp-0x80]
-       call     CORINFO_HELP_ASSIGN_REF
-       movsxd   rdx, ebx
-       mov      rcx, 0xD1FFAB1E      ; int[]
-       call     CORINFO_HELP_NEWARR_1_VC
-       mov      rdx, gword ptr [rbp-0x78]
-       lea      rcx, bword ptr [rdx+0x50]
-       mov      rdx, rax
-       call     CORINFO_HELP_ASSIGN_REF
-       movsxd   rdx, ebx
-						;; size=233 bbWeight=273.59 PerfScore 11148.77
-G_M16487_IG24:
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       call     CORINFO_HELP_NEWARR_1_OBJ
-       mov      rbx, gword ptr [rbp-0x78]
-       lea      rcx, bword ptr [rbx+0x48]
-       mov      rdx, rax
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rcx, gword ptr [rbx+0x48]
-       mov      r8, gword ptr [rbx+0x18]
-       xor      edx, edx
-       call     [CORINFO_HELP_ARRADDR_ST]
-       mov      eax, dword ptr [rbp-0x44]
-       mov      dword ptr [rbx+0x5C], eax
-       mov      byte  ptr [rbx+0x60], 0
-       lea      rcx, bword ptr [rbx+0x68]
-       mov      rdx, gword ptr [rbp-0x90]
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      rdx, rbx
-						;; size=76 bbWeight=273.59 PerfScore 4651.02
-G_M16487_IG25:
-       mov      r10, gword ptr [rbp-0x60]
-       lea      rcx, bword ptr [r10+0x28]
-       call     CORINFO_HELP_ASSIGN_REF
-       mov      eax, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG10
-						;; size=21 bbWeight=273.59 PerfScore 1504.74
-G_M16487_IG26:
-       mov      rdx, gword ptr [r8+0x08]
+       jmp      G_M16487_IG06
+       align    [0 bytes for IG20]
+						;; size=41 bbWeight=268266.24 PerfScore 4694659.20
+G_M16487_IG19:
+       mov      rcx, gword ptr [rdx+0x08]
+       mov      gword ptr [rbp-0xA0], rcx
        lea      rcx, bword ptr [rbx+0x08]
+       mov      rdx, gword ptr [rbp-0xA0]
        call     CORINFO_HELP_ASSIGN_REF
        xor      r8d, r8d
        mov      dword ptr [rbx+0x34], r8d
        mov      eax, dword ptr [rbp-0x44]
        mov      dword ptr [rbx+0x5C], eax
-       mov      r10, gword ptr [rbx+0x50]
-						;; size=30 bbWeight=2768.25 PerfScore 24222.19
-G_M16487_IG27:
-       cmp      dword ptr [r10+0x08], 0
-       jle      SHORT G_M16487_IG29
-						;; size=7 bbWeight=2768.25 PerfScore 11073.00
-G_M16487_IG28:
-       mov      edx, r8d
-       xor      ecx, ecx
-       mov      dword ptr [r10+4*rdx+0x10], ecx
-       inc      r8d
-       cmp      dword ptr [r10+0x08], r8d
-       jg       SHORT G_M16487_IG28
-						;; size=19 bbWeight=2756.46 PerfScore 15849.63
-G_M16487_IG29:
+       mov      r8, gword ptr [rbx+0x50]
+       xor      edx, edx
+       mov      ecx, dword ptr [r8+0x08]
+       test     ecx, ecx
+       jle      SHORT G_M16487_IG21
+						;; size=54 bbWeight=2716.84 PerfScore 38715.03
+G_M16487_IG20:
+       mov      r10d, edx
+       xor      r9d, r9d
+       mov      dword ptr [r8+4*r10+0x10], r9d
+       inc      edx
+       cmp      ecx, edx
+       jg       SHORT G_M16487_IG20
+						;; size=17 bbWeight=2729.26 PerfScore 8187.78
+G_M16487_IG21:
        mov      byte  ptr [rbx+0x60], 0
-       mov      r9, gword ptr [rbx+0x38]
-       test     r9, r9
-       jne      G_M16487_IG58
-						;; size=17 bbWeight=2768.25 PerfScore 11765.06
-G_M16487_IG30:
-       mov      r8, gword ptr [rbp-0x60]
-       mov      rbx, gword ptr [r8+0x20]
+       mov      r10, gword ptr [rbx+0x38]
+       test     r10, r10
+       jne      G_M16487_IG52
+						;; size=17 bbWeight=2716.84 PerfScore 11546.59
+G_M16487_IG22:
+       mov      rdx, gword ptr [rbp-0x60]
+       mov      rbx, gword ptr [rdx+0x20]
        test     rbx, rbx
-       je       G_M16487_IG44
-						;; size=17 bbWeight=2768.25 PerfScore 11765.06
-G_M16487_IG31:
-       mov      rdx, gword ptr [r8+0x10]
-       mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r8+0x50], edx
-       mov      rdx, gword ptr [r8+0x18]
-       mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r8+0x54], edx
-       mov      edx, dword ptr [rbx+0x08]
-       mov      dword ptr [r8+0x58], edx
-						;; size=29 bbWeight=2763.53 PerfScore 35925.89
-G_M16487_IG32:
+       je       G_M16487_IG36
+						;; size=17 bbWeight=2716.84 PerfScore 11546.59
+G_M16487_IG23:
+       mov      r8, gword ptr [rdx+0x10]
+       mov      r8d, dword ptr [r8+0x08]
+       mov      dword ptr [rdx+0x50], r8d
+       mov      r8, gword ptr [rdx+0x18]
+       mov      r8d, dword ptr [r8+0x08]
+       mov      dword ptr [rdx+0x54], r8d
+       mov      r8d, dword ptr [rbx+0x08]
+       mov      dword ptr [rdx+0x58], r8d
+						;; size=32 bbWeight=2709.77 PerfScore 35227.01
+G_M16487_IG24:
        mov      ebx, dword ptr [rbp-0x3C]
-       mov      dword ptr [r8+0x4C], ebx
-       mov      rdx, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
-       cmp      qword ptr [r8], rdx
-       jne      G_M16487_IG62
-       mov      r11, gword ptr [r8+0x70]
+       mov      dword ptr [rdx+0x4C], ebx
+       mov      r8, 0xD1FFAB1E      ; System.Text.RegularExpressions.CompiledRegexRunner
+       cmp      qword ptr [rdx], r8
+       jne      G_M16487_IG56
+       mov      r9, gword ptr [rdx+0x70]
        mov      bword ptr [rbp-0x58], r12
        mov      dword ptr [rbp-0x50], eax
        lea      r8, [rbp-0x58]
-       mov      rdx, gword ptr [rbp-0x60]
-       mov      rcx, gword ptr [r11+0x08]
-       call     [r11+0x18]<unknown method>
-						;; size=53 bbWeight=2763.53 PerfScore 46289.13
-G_M16487_IG33:
+       mov      rcx, gword ptr [r9+0x08]
+       call     [r9+0x18]<unknown method>
+						;; size=48 bbWeight=2709.77 PerfScore 42678.88
+G_M16487_IG25:
        mov      rdx, gword ptr [rbp-0x60]
        mov      rbx, gword ptr [rdx+0x28]
        mov      rax, gword ptr [rbx+0x50]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M16487_IG47
+       jbe      G_M16487_IG60
        cmp      dword ptr [rax+0x10], 0
-       jle      G_M16487_IG63
-       test     r15b, r15b
-       je       G_M16487_IG45
-						;; size=41 bbWeight=2763.53 PerfScore 39380.30
-G_M16487_IG34:
+       jle      G_M16487_IG57
+       test     dil, dil
+       je       G_M16487_IG41
+						;; size=41 bbWeight=2709.77 PerfScore 38614.22
+G_M16487_IG26:
        mov      rdx, gword ptr [rbp-0x60]
        mov      edx, dword ptr [rdx+0x4C]
        mov      rcx, rbx
-       mov      r9d, r14d
+       mov      r9d, esi
        xor      r8d, r8d
        call     [<unknown method>]
-						;; size=22 bbWeight=2763.53 PerfScore 18653.83
-G_M16487_IG35:
+						;; size=22 bbWeight=2709.77 PerfScore 18290.95
+G_M16487_IG27:
        cmp      dword ptr [rbx+0x30], 0
-       je       G_M16487_IG66
-						;; size=10 bbWeight=2763.53 PerfScore 11054.12
-G_M16487_IG36:
-       test     r15b, r15b
-       je       G_M16487_IG64
-						;; size=9 bbWeight=2763.52 PerfScore 3454.40
-G_M16487_IG37:
-       mov      rdx, 0xD1FFAB1E      ; function address
-       cmp      qword ptr [rdi+0x18], rdx
-       jne      G_M16487_IG46
-       inc      dword ptr [rsi]
-						;; size=22 bbWeight=2763.52 PerfScore 20035.52
-G_M16487_IG38:
+       je       G_M16487_IG63
+						;; size=10 bbWeight=2709.77 PerfScore 10839.08
+G_M16487_IG28:
+       test     dil, dil
+       je       G_M16487_IG58
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r15+0x18], rcx
+       jne      G_M16487_IG59
+						;; size=29 bbWeight=2709.76 PerfScore 14903.68
+G_M16487_IG29:
+       inc      dword ptr [r14]
+						;; size=3 bbWeight=2709.76 PerfScore 8129.28
+G_M16487_IG30:
        mov      rdx, gword ptr [rbp-0x60]
-       mov      r8d, dword ptr [rdx+0x4C]
-       mov      eax, r8d
+       mov      eax, dword ptr [rdx+0x4C]
        mov      r8d, eax
        cmp      dword ptr [rbx+0x14], 0
-       je       G_M16487_IG48
-						;; size=24 bbWeight=2763.52 PerfScore 20726.40
-G_M16487_IG39:
+       je       G_M16487_IG61
+						;; size=20 bbWeight=2709.76 PerfScore 19645.76
+G_M16487_IG31:
        mov      rcx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [rdx+0x50], ecx
@@ -2677,35 +2958,35 @@ G_M16487_IG39:
        mov      dword ptr [rdx+0x58], ecx
        mov      dword ptr [rbp-0x3C], r8d
        mov      ebx, eax
-       mov      r8, rdx
-						;; size=39 bbWeight=2763.52 PerfScore 45598.08
-G_M16487_IG40:
-       mov      dword ptr [r8+0x60], r14d
-       lea      rcx, bword ptr [r8+0x30]
+						;; size=36 bbWeight=2709.76 PerfScore 44033.60
+G_M16487_IG32:
+       mov      rdx, gword ptr [rbp-0x60]
+       mov      dword ptr [rdx+0x60], esi
+       lea      rcx, bword ptr [rdx+0x30]
        mov      rdx, gword ptr [rbp+0x10]
        call     CORINFO_HELP_ASSIGN_REF
-       mov      r8, gword ptr [rbp-0x60]
-       mov      dword ptr [r8+0x48], ebx
+       mov      rdx, gword ptr [rbp-0x60]
+       mov      dword ptr [rdx+0x48], ebx
        xor      ecx, ecx
-       mov      dword ptr [r8+0x40], ecx
+       mov      dword ptr [rdx+0x40], ecx
        mov      eax, dword ptr [rbp-0x44]
-       mov      dword ptr [r8+0x44], eax
-       mov      dword ptr [r8+0x4C], ebx
-       mov      rbx, gword ptr [r8+0x28]
+       mov      dword ptr [rdx+0x44], eax
+       mov      dword ptr [rdx+0x4C], ebx
+       mov      rbx, gword ptr [rdx+0x28]
        test     rbx, rbx
-       jne      G_M16487_IG26
-						;; size=55 bbWeight=2763.53 PerfScore 35925.89
-G_M16487_IG41:
-       mov      rbx, gword ptr [r8+0x30]
-       mov      rdx, gword ptr [rbx+0x18]
-       mov      gword ptr [rbp-0xA8], rdx
-       test     rdx, rdx
-       je       G_M16487_IG57
+       jne      G_M16487_IG19
+						;; size=54 bbWeight=2709.77 PerfScore 37936.78
+G_M16487_IG33:
+       mov      rbx, gword ptr [rdx+0x30]
+       mov      r8, gword ptr [rbx+0x18]
+       mov      gword ptr [rbp-0xB0], r8
+       test     r8, r8
+       je       G_M16487_IG51
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x78], rax
        mov      gword ptr [rbp-0x80], rbx
-       mov      rcx, gword ptr [rbp-0xA8]
+       mov      rcx, gword ptr [rbp-0xB0]
        mov      gword ptr [rbp-0x90], rcx
        mov      ebx, dword ptr [rbx+0x44]
        mov      r10, gword ptr [rbp-0x60]
@@ -2743,8 +3024,8 @@ G_M16487_IG41:
        mov      rdx, rax
        call     CORINFO_HELP_ASSIGN_REF
        movsxd   rdx, ebx
-						;; size=233 bbWeight=2.76 PerfScore 112.61
-G_M16487_IG42:
+						;; size=233 bbWeight=2.71 PerfScore 110.42
+G_M16487_IG34:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWARR_1_OBJ
        mov      rbx, gword ptr [rbp-0x78]
@@ -2762,76 +3043,175 @@ G_M16487_IG42:
        mov      rdx, gword ptr [rbp-0x90]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, rbx
-						;; size=76 bbWeight=2.76 PerfScore 46.98
-G_M16487_IG43:
+						;; size=76 bbWeight=2.71 PerfScore 46.07
+G_M16487_IG35:
        mov      r10, gword ptr [rbp-0x60]
        lea      rcx, bword ptr [r10+0x28]
        call     CORINFO_HELP_ASSIGN_REF
        mov      eax, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG30
-						;; size=21 bbWeight=2.76 PerfScore 15.20
-G_M16487_IG44:
-       jmp      G_M16487_IG59
-						;; size=5 bbWeight=1384.13 PerfScore 2768.25
-G_M16487_IG45:
+       jmp      G_M16487_IG22
+						;; size=21 bbWeight=2.71 PerfScore 14.90
+G_M16487_IG36:
+       jmp      G_M16487_IG53
+						;; size=5 bbWeight=1358.42 PerfScore 2716.84
+G_M16487_IG37:
        lea      rcx, bword ptr [rbx+0x08]
        mov      rdx, r13
        call     CORINFO_HELP_ASSIGN_REF
        xor      rdx, rdx
        mov      rax, gword ptr [rbp-0x60]
        mov      gword ptr [rax+0x28], rdx
-       jmp      G_M16487_IG34
-						;; size=27 bbWeight=31.53 PerfScore 189.20
-G_M16487_IG46:
-       mov      rdx, rsi
-       mov      r8, rbx
-       mov      rcx, gword ptr [rdi+0x08]
-       call     [rdi+0x18]<unknown method>
-       test     eax, eax
-       je       G_M16487_IG66
-       jmp      G_M16487_IG38
-						;; size=26 bbWeight=2763.52 PerfScore 24180.80
-G_M16487_IG47:
-       call     CORINFO_HELP_RNGCHKFAIL
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M16487_IG48:
-       mov      ebx, dword ptr [rbp-0x44]
-       mov      ecx, ebx
-       mov      r8d, 1
+       jmp      G_M16487_IG14
+						;; size=27 bbWeight=2173.82 PerfScore 13042.92
+G_M16487_IG38:
+       mov      rbx, gword ptr [r8+0x30]
+       mov      rax, gword ptr [rbx+0x18]
+       mov      gword ptr [rbp-0xA8], rax
+       test     rax, rax
+       je       G_M16487_IG45
+       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
+       call     CORINFO_HELP_NEWSFAST
+       mov      gword ptr [rbp-0x78], rax
+       mov      gword ptr [rbp-0x80], rbx
+       mov      r8, gword ptr [rbp-0xA8]
+       mov      gword ptr [rbp-0x90], r8
+       mov      ebx, dword ptr [rbx+0x44]
+       mov      r10, gword ptr [rbp-0x60]
+       mov      r9, gword ptr [r10+0x08]
+       mov      gword ptr [rbp-0x88], r9
+       mov      rcx, 0xD1FFAB1E      ; int[]
+       mov      edx, 2
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      gword ptr [rbp-0x98], rax
+       mov      rdx, gword ptr [rbp-0x78]
+       lea      rcx, bword ptr [rdx+0x08]
+       mov      rdx, gword ptr [rbp-0x88]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      rdx, gword ptr [rbp-0x78]
+       mov      qword ptr [rdx+0x10], rcx
+       mov      gword ptr [rbp-0x78], rdx
+       lea      rcx, bword ptr [rdx+0x18]
+       mov      rdx, gword ptr [rbp-0x98]
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      ecx, ecx
+       mov      rdx, gword ptr [rbp-0x78]
+       mov      dword ptr [rdx+0x30], ecx
+       mov      rcx, 0xD1FFAB1E
+       mov      gword ptr [rdx+0x28], rcx
+       mov      gword ptr [rbp-0x78], rdx
+       lea      rcx, bword ptr [rdx+0x40]
+       mov      rdx, gword ptr [rbp-0x80]
+       call     CORINFO_HELP_ASSIGN_REF
+       movsxd   rdx, ebx
+       mov      rcx, 0xD1FFAB1E      ; int[]
+       call     CORINFO_HELP_NEWARR_1_VC
+       mov      rdx, gword ptr [rbp-0x78]
+       lea      rcx, bword ptr [rdx+0x50]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       movsxd   rdx, ebx
+						;; size=233 bbWeight=268.27 PerfScore 10931.89
+G_M16487_IG39:
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       call     CORINFO_HELP_NEWARR_1_OBJ
+       mov      rbx, gword ptr [rbp-0x78]
+       lea      rcx, bword ptr [rbx+0x48]
+       mov      rdx, rax
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rcx, gword ptr [rbx+0x48]
+       mov      r8, gword ptr [rbx+0x18]
+       xor      edx, edx
+       call     [CORINFO_HELP_ARRADDR_ST]
+       mov      dword ptr [rbx+0x5C], r15d
+       mov      byte  ptr [rbx+0x60], 0
+       lea      rcx, bword ptr [rbx+0x68]
+       mov      rdx, gword ptr [rbp-0x90]
+       call     CORINFO_HELP_ASSIGN_REF
+       mov      rdx, rbx
+						;; size=74 bbWeight=268.27 PerfScore 4292.28
+G_M16487_IG40:
+       mov      r10, gword ptr [rbp-0x60]
+       lea      rcx, bword ptr [r10+0x28]
+       call     CORINFO_HELP_ASSIGN_REF
+       jmp      G_M16487_IG11
+						;; size=18 bbWeight=268.27 PerfScore 1207.20
+G_M16487_IG41:
+       lea      rcx, bword ptr [rbx+0x08]
+       mov      rdx, r13
+       call     CORINFO_HELP_ASSIGN_REF
+       xor      rdx, rdx
+       mov      rax, gword ptr [rbp-0x60]
+       mov      gword ptr [rax+0x28], rdx
+       jmp      G_M16487_IG26
+						;; size=27 bbWeight=21.96 PerfScore 131.75
+G_M16487_IG42:
+       mov      eax, r15d
+       mov      ecx, 1
        mov      r10, gword ptr [rbp+0x10]
        test     byte  ptr [r10+0x40], 64
-       je       SHORT G_M16487_IG49
-       xor      ecx, ecx
-       mov      r8d, -1
-						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG49:
-       cmp      eax, ecx
-       je       G_M16487_IG66
-       add      r8d, eax
-       mov      ecx, r8d
-       mov      r8d, ecx
-       mov      rdx, gword ptr [rbp-0x60]
-       jmp      G_M16487_IG39
+       je       SHORT G_M16487_IG43
+       xor      eax, eax
+       mov      ecx, -1
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M16487_IG50:
+G_M16487_IG43:
+       cmp      r8d, eax
+       je       G_M16487_IG63
+       mov      r15d, dword ptr [rbp-0x44]
+       add      ecx, r8d
+       mov      ebx, ecx
+       mov      dword ptr [rbp-0x3C], ebx
+       mov      rdx, gword ptr [rbp-0x60]
+       jmp      G_M16487_IG18
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M16487_IG44:
+       xor      rcx, rcx
+       mov      rdx, gword ptr [rbp-0x60]
+       mov      gword ptr [rdx+0x28], rcx
+       jmp      G_M16487_IG17
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M16487_IG45:
+       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
+       call     CORINFO_HELP_NEWSFAST
+       mov      gword ptr [rbp-0x70], rax
+       mov      dword ptr [rsp+0x20], r15d
+       mov      r8d, dword ptr [rbx+0x44]
+       mov      rdx, rbx
+       mov      rbx, gword ptr [rbp-0x60]
+       mov      r9, gword ptr [rbx+0x08]
+       mov      rcx, gword ptr [rbp-0x70]
+       call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
+       mov      rdx, gword ptr [rbp-0x70]
+       jmp      G_M16487_IG40
+						;; size=58 bbWeight=0 PerfScore 0.00
+G_M16487_IG46:
+       xor      rcx, rcx
+       mov      gword ptr [r10+0x18], rcx
+       mov      rbx, gword ptr [rbp-0x60]
+       mov      r9, gword ptr [rbx+0x20]
+       test     r9, r9
+       mov      r8, rbx
+       jne      G_M16487_IG12
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M16487_IG47:
        mov      rcx, r8
-       mov      rdx, qword ptr [r8]
-       mov      rdx, qword ptr [rdx+0x40]
-       call     [rdx+0x38]<unknown method>
+       mov      rax, qword ptr [r8]
+       mov      rax, qword ptr [rax+0x40]
+       call     [rax+0x38]<unknown method>
        mov      rcx, gword ptr [rbp-0x60]
        mov      ebx, dword ptr [rcx+0x5C]
        shl      ebx, 3
        mov      eax, ebx
        cmp      ebx, 32
-       jge      SHORT G_M16487_IG51
+       jge      SHORT G_M16487_IG48
        mov      eax, 32
 						;; size=35 bbWeight=0 PerfScore 0.00
-G_M16487_IG51:
+G_M16487_IG48:
        cmp      ebx, 16
-       jge      SHORT G_M16487_IG52
+       jge      SHORT G_M16487_IG49
        mov      ebx, 16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG52:
+G_M16487_IG49:
        mov      dword ptr [rbp-0x40], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; int[]
@@ -2862,50 +3242,16 @@ G_M16487_IG52:
        mov      rcx, gword ptr [rbp-0x60]
        mov      dword ptr [rcx+0x58], 32
        mov      r8, rcx
-       mov      eax, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG12
-						;; size=146 bbWeight=0 PerfScore 0.00
-G_M16487_IG53:
-       mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
-       call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rbp-0x70], rax
-       mov      eax, dword ptr [rbp-0x44]
-       mov      dword ptr [rsp+0x20], eax
-       mov      r8d, dword ptr [rbx+0x44]
-       mov      rdx, rbx
-       mov      rbx, gword ptr [rbp-0x60]
-       mov      r9, gword ptr [rbx+0x08]
-       mov      rcx, gword ptr [rbp-0x70]
-       call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
-       mov      rdx, gword ptr [rbp-0x70]
-       jmp      G_M16487_IG25
-						;; size=60 bbWeight=0 PerfScore 0.00
-G_M16487_IG54:
+       jmp      G_M16487_IG13
+						;; size=143 bbWeight=0 PerfScore 0.00
+G_M16487_IG50:
        xor      rcx, rcx
        mov      gword ptr [rbx+0x08], rcx
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rbx, gword ptr [rcx]
-       jmp      G_M16487_IG14
+       jmp      G_M16487_IG15
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16487_IG55:
-       mov      ebx, dword ptr [rbp-0x44]
-       mov      eax, ebx
-       mov      r8d, 1
-       mov      r9, gword ptr [rbp+0x10]
-       test     byte  ptr [r9+0x40], 64
-       je       SHORT G_M16487_IG56
-       xor      eax, eax
-       mov      r8d, -1
-						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG56:
-       cmp      r10d, eax
-       je       G_M16487_IG66
-       add      r8d, r10d
-       mov      dword ptr [rbp-0x3C], r8d
-       mov      rdx, gword ptr [rbp-0x60]
-       jmp      G_M16487_IG22
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M16487_IG57:
+G_M16487_IG51:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x70], rax
@@ -2919,36 +3265,36 @@ G_M16487_IG57:
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
        mov      rbx, gword ptr [rbp-0x70]
        mov      rdx, rbx
-       jmp      G_M16487_IG43
+       jmp      G_M16487_IG35
 						;; size=63 bbWeight=0 PerfScore 0.00
-G_M16487_IG58:
+G_M16487_IG52:
        xor      rcx, rcx
-       mov      gword ptr [r9+0x18], rcx
+       mov      gword ptr [r10+0x18], rcx
        mov      rcx, gword ptr [rbp-0x60]
        mov      rbx, gword ptr [rcx+0x20]
        test     rbx, rbx
-       mov      r8, rcx
-       jne      G_M16487_IG31
+       mov      rdx, rcx
+       jne      G_M16487_IG23
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M16487_IG59:
-       mov      rcx, r8
-       mov      rdx, qword ptr [r8]
-       mov      rdx, qword ptr [rdx+0x40]
-       call     [rdx+0x38]<unknown method>
+G_M16487_IG53:
+       mov      rcx, rdx
+       mov      r8, qword ptr [rdx]
+       mov      r8, qword ptr [r8+0x40]
+       call     [r8+0x38]<unknown method>
        mov      rcx, gword ptr [rbp-0x60]
        mov      ebx, dword ptr [rcx+0x5C]
        shl      ebx, 3
        mov      eax, ebx
        cmp      ebx, 32
-       jge      SHORT G_M16487_IG60
+       jge      SHORT G_M16487_IG54
        mov      eax, 32
-						;; size=35 bbWeight=0 PerfScore 0.00
-G_M16487_IG60:
+						;; size=36 bbWeight=0 PerfScore 0.00
+G_M16487_IG54:
        cmp      ebx, 16
-       jge      SHORT G_M16487_IG61
+       jge      SHORT G_M16487_IG55
        mov      ebx, 16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M16487_IG61:
+G_M16487_IG55:
        mov      dword ptr [rbp-0x40], eax
        movsxd   rdx, eax
        mov      rcx, 0xD1FFAB1E      ; int[]
@@ -2978,43 +3324,70 @@ G_M16487_IG61:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rcx, gword ptr [rbp-0x60]
        mov      dword ptr [rcx+0x58], 32
-       mov      r8, rcx
        mov      eax, dword ptr [rbp-0x44]
-       jmp      G_M16487_IG32
-						;; size=146 bbWeight=0 PerfScore 0.00
-G_M16487_IG62:
+       mov      rdx, gword ptr [rbp-0x60]
+       jmp      G_M16487_IG24
+						;; size=147 bbWeight=0 PerfScore 0.00
+G_M16487_IG56:
        mov      bword ptr [rbp-0x58], r12
        mov      dword ptr [rbp-0x50], eax
        lea      rdx, [rbp-0x58]
-       mov      rcx, r8
-       mov      r10, qword ptr [r8]
-       mov      r10, qword ptr [r10+0x40]
-       call     [r10+0x20]<unknown method>
-       jmp      G_M16487_IG33
-						;; size=30 bbWeight=0 PerfScore 0.00
-G_M16487_IG63:
-       xor      rcx, rcx
-       mov      gword ptr [rbx+0x08], rcx
-       mov      rcx, 0xD1FFAB1E      ; const ptr
-       mov      rbx, gword ptr [rcx]
-       jmp      G_M16487_IG35
-						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16487_IG64:
-       xor      rcx, rcx
-       mov      rdx, gword ptr [rbp-0x60]
-       mov      gword ptr [rdx+0x28], rcx
-       jmp      G_M16487_IG37
-						;; size=15 bbWeight=0 PerfScore 0.00
-G_M16487_IG65:
-       mov      rcx, gword ptr [rax+0x10]
+       mov      rcx, gword ptr [rbp-0x60]
        mov      r8, qword ptr [rcx]
        mov      r8, qword ptr [r8+0x40]
        call     [r8+0x20]<unknown method>
-       mov      r8, rax
-       mov      rax, gword ptr [rbp+0x10]
-       jmp      G_M16487_IG03
-						;; size=27 bbWeight=0.50 PerfScore 6.12
-G_M16487_IG66:
+       jmp      G_M16487_IG25
+						;; size=31 bbWeight=0 PerfScore 0.00
+G_M16487_IG57:
+       xor      r8, r8
+       mov      gword ptr [rbx+0x08], r8
+       mov      r8, 0xD1FFAB1E      ; const ptr
+       mov      rbx, gword ptr [r8]
+       jmp      G_M16487_IG27
+						;; size=25 bbWeight=0 PerfScore 0.00
+G_M16487_IG58:
+       xor      rcx, rcx
+       mov      rdx, gword ptr [rbp-0x60]
+       mov      gword ptr [rdx+0x28], rcx
+       mov      rcx, 0xD1FFAB1E      ; function address
+       cmp      qword ptr [r15+0x18], rcx
+       je       G_M16487_IG29
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M16487_IG59:
+       mov      rdx, r14
+       mov      r8, rbx
+       mov      rcx, gword ptr [r15+0x08]
+       call     [r15+0x18]<unknown method>
+       test     eax, eax
+       jne      G_M16487_IG30
+       jmp      SHORT G_M16487_IG63
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M16487_IG60:
+       call     CORINFO_HELP_RNGCHKFAIL
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M16487_IG61:
+       mov      ebx, dword ptr [rbp-0x44]
+       mov      ecx, ebx
+       mov      r8d, 1
+       mov      r10, gword ptr [rbp+0x10]
+       test     byte  ptr [r10+0x40], 64
+       je       SHORT G_M16487_IG62
+       xor      ecx, ecx
+       mov      r8d, -1
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M16487_IG62:
+       cmp      eax, ecx
+       je       SHORT G_M16487_IG63
+       mov      ecx, ebx
+       mov      rbx, r15
+       mov      r15d, ecx
+       lea      ecx, [rax+r8]
+       mov      r8d, ecx
+       mov      r15, rbx
+       mov      rdx, gword ptr [rbp-0x60]
+       jmp      G_M16487_IG31
+						;; size=31 bbWeight=0 PerfScore 0.00
+G_M16487_IG63:
        xor      rcx, rcx
        mov      rdx, gword ptr [rbp-0x60]
        mov      gword ptr [rdx+0x08], rcx
@@ -3023,7 +3396,7 @@ G_M16487_IG66:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=24 bbWeight=1 PerfScore 5.00
-G_M16487_IG67:
+G_M16487_IG64:
        add      rsp, 168
        pop      rbx
        pop      rsi
@@ -3035,7 +3408,7 @@ G_M16487_IG67:
        pop      rbp
        ret      
 						;; size=20 bbWeight=1 PerfScore 5.25
-G_M16487_IG68:
+G_M16487_IG65:
        push     rbp
        push     r15
        push     r14
@@ -3049,7 +3422,7 @@ G_M16487_IG68:
        mov      qword ptr [rsp+0x28], rbp
        lea      rbp, [rbp+0xE0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M16487_IG69:
+G_M16487_IG66:
        xor      rcx, rcx
        mov      rdx, gword ptr [rbp-0x60]
        mov      gword ptr [rdx+0x08], rcx
@@ -3058,7 +3431,7 @@ G_M16487_IG69:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M16487_IG70:
+G_M16487_IG67:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -3071,6 +3444,6 @@ G_M16487_IG70:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 2600, prolog size 69, PerfScore 36945202.89, instruction count 647, allocated bytes for code 2600 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
+; Total bytes of code 2624, prolog size 67, PerfScore 31511288.50, instruction count 648, allocated bytes for code 2624 (MethodHash=ce88bf98) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[int](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[int],int,ubyte):this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Match.AddMatch(int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 856832
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 840960
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T01] (  5,  5   )     ref  ->  rsi         this class-hnd single-def <System.Text.RegularExpressions.Match>
@@ -451,7 +451,7 @@ G_M41154_IG10:
 ;* V08 loc4         [V08    ] (  0,  0   )     int  ->  zero-ref   
 ;  V09 loc5         [V09,T19] (  3,  0   )     ref  ->  [rsp+0x20]  class-hnd spill-single-def <<unknown class>>
 ;  V10 loc6         [V10,T18] (  4,  0   )     ref  ->  rax         class-hnd exact single-def <<unknown class>>
-;  V11 loc7         [V11,T17] (  8,  0   )     int  ->  rdx        
+;* V11 loc7         [V11,T22] (  0,  0   )     int  ->  zero-ref   
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V13 tmp1         [V13,T21] (  2,  0   )     int  ->   r8         "Strict ordering of exceptions for Array store"
 ;  V14 tmp2         [V14,T20] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
@@ -464,6 +464,7 @@ G_M41154_IG10:
 ;  V21 cse3         [V21,T14] (  3,  3   )     int  ->  rax         "CSE #11: aggressive"
 ;  V22 cse4         [V22,T16] (  2,  2   )     int  ->  rcx         "CSE #12: aggressive"
 ;  V23 cse5         [V23,T02] (  7,  6   )    long  ->  r15         "CSE #01: aggressive"
+;  V24 rat0         [V24,T17] (  8,  0   )    long  ->  rdx         "Widened IV V11"
 ;
 ; Lcl frame size = 40
 
@@ -561,14 +562,12 @@ G_M41154_IG09:
        mov      rcx, gword ptr [rsp+0x20]
        cmp      edx, dword ptr [rcx+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r8d, edx
-       mov      r8d, dword ptr [rcx+4*r8+0x10]
+       mov      r8d, dword ptr [rcx+4*rdx+0x10]
        cmp      edx, dword ptr [rax+0x08]
        jae      SHORT G_M41154_IG06
-       mov      r10d, edx
-       mov      dword ptr [rax+4*r10+0x10], r8d
+       mov      dword ptr [rax+4*rdx+0x10], r8d
        inc      edx
-						;; size=33 bbWeight=0 PerfScore 0.00
+						;; size=27 bbWeight=0 PerfScore 0.00
 G_M41154_IG10:
        cmp      edx, esi
        jl       SHORT G_M41154_IG09
@@ -579,6 +578,6 @@ G_M41154_IG10:
        jmp      G_M41154_IG04
 						;; size=24 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 297, prolog size 27, PerfScore 55.00, instruction count 91, allocated bytes for code 297 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
+; Total bytes of code 291, prolog size 27, PerfScore 55.00, instruction count 89, allocated bytes for code 291 (MethodHash=c6df5f3d) for method System.Text.RegularExpressions.Match:AddMatch(int,int,int):this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Match.Tidy(int32,int32,value class System.Text.RegularExpressions.RegexRunnerMode)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: edge weights are valid, and fgCalledCount is 846720
+; with Dynamic PGO: edge weights are valid, and fgCalledCount is 831104
 ; 0 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
@@ -470,15 +470,17 @@ G_M61392_IG19:
 ;  V04 loc0         [V04,T07] (  5,  3   )     ref  ->  rsi         class-hnd single-def <<unknown class>>
 ;  V05 loc1         [V05,T08] (  5,  3   )     ref  ->  rdi         class-hnd single-def <<unknown class>>
 ;  V06 loc2         [V06,T04] (  4,  4   )     ref  ->  rax         class-hnd single-def <<unknown class>>
-;  V07 loc3         [V07,T10] (  7,  0   )     int  ->  rax        
+;* V07 loc3         [V07,T15] (  0,  0   )     int  ->  zero-ref   
 ;  V08 loc4         [V08,T12] (  4,  0   )     ref  ->  rcx         class-hnd <<unknown class>>
 ;  V09 loc5         [V09,T14] (  2,  0   )     int  ->  rdx        
-;  V10 loc6         [V10,T11] (  6,  0   )     int  ->   r8        
+;* V10 loc6         [V10,T16] (  0,  0   )     int  ->  zero-ref   
 ;  V11 OutArgs      [V11    ] (  1,  1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;  V12 tmp1         [V12,T13] (  3,  0   )   byref  ->  r10         "dup spill"
 ;  V13 tmp2         [V13,T05] (  2,  4   )     int  ->  rdx         "Inlining Arg"
 ;  V14 tmp3         [V14,T06] (  2,  4   )     int  ->  rdx         "Inlining Arg"
 ;  V15 cse0         [V15,T09] (  2,  2   )     int  ->  rdx         "CSE #01: aggressive"
+;  V16 rat0         [V16,T10] (  7,  0   )    long  ->  rax         "Widened IV V07"
+;  V17 rat1         [V17,T11] (  6,  0   )    long  ->   r8         "Widened IV V10"
 ;
 ; Lcl frame size = 32
 
@@ -536,26 +538,23 @@ G_M61392_IG06:
        jmp      SHORT G_M61392_IG11
 						;; size=8 bbWeight=0 PerfScore 0.00
 G_M61392_IG07:
-       mov      ecx, eax
-       mov      rcx, gword ptr [rdi+8*rcx+0x10]
+       mov      rcx, gword ptr [rdi+8*rax+0x10]
        test     rcx, rcx
        je       SHORT G_M61392_IG10
        cmp      eax, dword ptr [rsi+0x08]
        jae      SHORT G_M61392_IG04
-       mov      edx, eax
-       mov      edx, dword ptr [rsi+4*rdx+0x10]
+       mov      edx, dword ptr [rsi+4*rax+0x10]
        add      edx, edx
        xor      r8d, r8d
        jmp      SHORT G_M61392_IG09
-						;; size=30 bbWeight=0 PerfScore 0.00
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M61392_IG08:
        cmp      r8d, dword ptr [rcx+0x08]
        jae      SHORT G_M61392_IG04
-       mov      r10d, r8d
-       lea      r10, bword ptr [rcx+4*r10+0x10]
+       lea      r10, bword ptr [rcx+4*r8+0x10]
        add      dword ptr [r10], ebx
        add      r8d, 2
-						;; size=21 bbWeight=0 PerfScore 0.00
+						;; size=18 bbWeight=0 PerfScore 0.00
 G_M61392_IG09:
        cmp      r8d, edx
        jl       SHORT G_M61392_IG08
@@ -569,6 +568,6 @@ G_M61392_IG11:
        jmp      SHORT G_M61392_IG03
 						;; size=7 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 177, prolog size 10, PerfScore 40.25, instruction count 64, allocated bytes for code 177 (MethodHash=23a8102f) for method System.Text.RegularExpressions.Match:Tidy(int,int,int):this (Tier1)
+; Total bytes of code 170, prolog size 10, PerfScore 40.25, instruction count 61, allocated bytes for code 170 (MethodHash=23a8102f) for method System.Text.RegularExpressions.Match:Tidy(int,int,int):this (Tier1)
 ; ============================================================
 


```

</details>

