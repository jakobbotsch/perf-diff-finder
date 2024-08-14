# ``System.Reflection.Invoke.Property_Set_int``

Hot functions:

- (26.80%) ``MethodBaseInvoker.InvokePropertySetter`` (Tier-1)
  - No diffs
- (22.27%) ``Invoke.Property_Set_int`` (Tier-1)
  - No diffs
- (3.91%) ``Invoke+MyClass.set_I`` (Tier-1)
  - No diffs
- (3.57%) ``RuntimeMethodInfo.get_DeclaringType`` (Tier-1)
  - No diffs

# ``System.Collections.IterateForEach<Int32>.ImmutableHashSet(Size: 512)``

Hot functions:

- (33.53%) ``System.Collections.IterateForEach`1.ImmutableHashSet`` (Tier-1)
  - **Has diffs**
- (11.92%) ``System.Collections.Immutable.ImmutableHashSet`1+HashBucket+Enumerator..ctor`` (Tier-1)
  - No diffs
- (7.17%) ``System.Collections.Generic.Stack`1.Push`` (Tier-1)
  - No diffs
- (6.77%) ``System.Collections.Immutable.SortedInt32KeyNode`1.get_Value`` (Tier-1)
  - No diffs
- (6.43%) ``System.Collections.Immutable.ImmutableHashSet`1+HashBucket+Enumerator.MoveNext`` (Tier-1)
  - No diffs
- (4.84%) ``System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator.ThrowIfDisposed`` (Tier-1)
  - No diffs
- (1.57%) ``Buffer.BulkMoveWithWriteBarrier`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]System.Collections.IterateForEach`1[System.Int32].ImmutableHashSet()``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 11840
+; with Dynamic PGO: fgCalledCount is 11794
 ; 25 inlinees with PGO data; 35 single block inlinees; 3 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T19] (  3,   3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.IterateForEach`1[int]>
-;  V01 loc0         [V01,T11] (  3, 509.42)     int  ->  rbx         ld-addr-op
+;  V00 this         [V00,T21] (  3,   3   )     ref  ->  rcx         this class-hnd single-def <System.Collections.IterateForEach`1[int]>
+;  V01 loc0         [V01,T10] (  3, 513.65)     int  ->  rbx         ld-addr-op
 ;* V02 loc1         [V02    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact <System.Collections.Immutable.ImmutableHashSet`1[int]>
-;  V03 loc2         [V03    ] ( 54,7365.71)  struct (128) [rbp-0xB8]  do-not-enreg[XSF] must-init addr-exposed ld-addr-op <System.Collections.Immutable.ImmutableHashSet`1+Enumerator[int]>
+;  V03 loc2         [V03    ] ( 54,7715.35)  struct (128) [rbp-0xB8]  do-not-enreg[XSF] must-init addr-exposed ld-addr-op <System.Collections.Immutable.ImmutableHashSet`1+Enumerator[int]>
 ;* V04 loc3         [V04    ] (  0,   0   )     int  ->  zero-ref   
 ;  V05 OutArgs      [V05    ] (  1,   1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V06 tmp1         [V06,T25] (  2,   4.00)  struct (128) [rbp-0x138]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableHashSet`1+Enumerator[int]>
-;  V07 tmp2         [V07,T13] (  4,   8   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V06 tmp1         [V06,T23] (  2,   4   )  struct (128) [rbp-0x138]  do-not-enreg[SF] must-init ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableHashSet`1+Enumerator[int]>
+;  V07 tmp2         [V07,T15] (  4,   8   )     ref  ->  rcx         class-hnd exact single-def "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
 ;* V08 tmp3         [V08    ] (  0,   0   )  struct (32) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
 ;* V09 tmp4         [V09    ] (  0,   0   )   byref  ->  zero-ref   
 ;* V10 tmp5         [V10    ] (  0,   0   )   byref  ->  zero-ref   
 ;* V11 tmp6         [V11    ] (  0,   0   )     int  ->  zero-ref   
 ;* V12 tmp7         [V12    ] (  0,   0   )  struct (32) zero-ref    do-not-enreg[S] "impAppendStmt" <System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
 ;  V13 tmp8         [V13,T44] (  3,   0   )     ref  ->  r15         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]>
-;  V14 tmp9         [V14,T27] (  4,   3   )     int  ->  rdi         "Inline stloc first use temp"
+;  V14 tmp9         [V14,T29] (  4,   3   )     int  ->  rdi         "Inline stloc first use temp"
 ;* V15 tmp10        [V15    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
 ;* V16 tmp11        [V16    ] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;* V17 tmp12        [V17    ] (  0,   0   )  struct (32) zero-ref    ld-addr-op "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
 ;* V18 tmp13        [V18    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "impAppendStmt" <System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]>
 ;* V19 tmp14        [V19    ] (  0,   0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V20 tmp15        [V20,T14] (  8,   7   )     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V20 tmp15        [V20,T16] (  8,   6.95)     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
 ;* V21 tmp16        [V21    ] (  0,   0   )  struct ( 8) zero-ref    "location for address-of(RValue)" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]]>
 ;* V22 tmp17        [V22    ] (  0,   0   )  struct ( 8) zero-ref    "Inline return value spill temp" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]]>
-;  V23 tmp18        [V23,T23] (  4,   4   )     int  ->  rdx         single-def "Inline stloc first use temp"
-;  V24 tmp19        [V24,T28] (  3,   3   )     ref  ->  rax         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;  V23 tmp18        [V23,T26] (  4,   3.97)     int  ->  rdx         single-def "Inline stloc first use temp"
+;  V24 tmp19        [V24,T30] (  3,   2.98)     ref  ->  rax         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
 ;* V25 tmp20        [V25    ] (  0,   0   )  struct ( 8) zero-ref    <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]]>
 ;* V26 tmp21        [V26    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]]>
 ;* V27 tmp22        [V27    ] (  0,   0   )  struct ( 8) zero-ref    <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]]>
 ;* V28 tmp23        [V28    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V29 tmp24        [V29,T12] (  7,  10.20)     ref  ->  r13         class-hnd "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V30 tmp25        [V30,T15] (  7,   6.13)     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]>
+;  V29 tmp24        [V29,T14] (  7,  10.22)     ref  ->  r13         class-hnd "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V30 tmp25        [V30,T17] (  7,   6.14)     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]>
 ;* V31 tmp26        [V31    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]>
 ;* V32 tmp27        [V32    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact single-def "Inlining Arg" <System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]>
-;  V33 tmp28        [V33,T20] (  4,   4.10)     int  ->  rdi         "Inline stloc first use temp"
-;  V34 tmp29        [V34,T26] (  3,   3.08)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V33 tmp28        [V33,T22] (  4,   4.12)     int  ->  rdi         "Inline stloc first use temp"
+;  V34 tmp29        [V34,T28] (  3,   3.09)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;* V35 tmp30        [V35    ] (  0,   0   )  struct ( 8) zero-ref    "Inlining Arg" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]>
-;  V36 tmp31        [V36,T02] (  2,2010.56)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]>
-;  V37 tmp32        [V37,T06] (  3,1015.34)     int  ->  rcx         "Inline stloc first use temp"
-;  V38 tmp33        [V38,T08] (  3,1014.83)     int  ->  rbx         "Inline stloc first use temp"
+;  V36 tmp31        [V36,T02] (  2,2044.59)     ref  ->  rcx         class-hnd exact "Inlining Arg" <System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]>
+;  V37 tmp32        [V37,T05] (  3,1033.70)     int  ->  rcx         "Inline stloc first use temp"
+;  V38 tmp33        [V38,T07] (  3,1023.31)     int  ->  rbx         "Inline stloc first use temp"
 ;  V39 tmp34        [V39,T45] (  3,   0   )     ref  ->  r12         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;  V40 tmp35        [V40,T46] (  3,   0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V41 tmp36        [V41,T40] (  2,   0.84)     ref  ->  rcx         class-hnd exact "Inlining Arg" <<unknown class>>
+;  V41 tmp36        [V41,T12] (  2,  17.29)     ref  ->  rcx         class-hnd exact "Inlining Arg" <<unknown class>>
 ;* V42 tmp37        [V42    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableList`1+Node[int]>
-;  V43 tmp38        [V43,T07] (  2,1014.85)   ubyte  ->  rax         "Inline return value spill temp"
-;  V44 tmp39        [V44    ] (  2,1014.85)  struct (24) [rbp-0x150]  do-not-enreg[XHS] must-init addr-exposed hidden-struct-arg ld-addr-op "Inline stloc first use temp" <System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V45 tmp40        [V45    ] (  3,3044.54)  struct (80) [rbp-0x1A0]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableHashSet`1+HashBucket+Enumerator[int]>
+;  V43 tmp38        [V43,T06] (  2,1023.31)   ubyte  ->  rax         "Inline return value spill temp"
+;  V44 tmp39        [V44    ] (  2,1023.31)  struct (24) [rbp-0x150]  do-not-enreg[XHS] must-init addr-exposed hidden-struct-arg ld-addr-op "Inline stloc first use temp" <System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V45 tmp40        [V45    ] (  3,3069.92)  struct (80) [rbp-0x1A0]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.ImmutableHashSet`1+HashBucket+Enumerator[int]>
 ;* V46 tmp41        [V46    ] (  0,   0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]>
 ;  V47 tmp42        [V47,T47] (  3,   0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V48 tmp43        [V48    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Collections.Immutable.ImmutableHashSet`1+Builder[int]>
@@ -346,25 +346,25 @@ G_M61964_IG14:
 ;* V63 tmp58        [V63    ] (  0,   0   )  struct ( 8) zero-ref    <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]>
 ;* V64 tmp59        [V64    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]>
 ;* V65 tmp60        [V65    ] (  0,   0   )  struct ( 8) zero-ref    <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]>
-;  V66 tmp61        [V66,T00] (  7,4162.87)     ref  ->  r14         class-hnd "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
-;  V67 tmp62        [V67,T09] (  2, 520.36)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]>
+;  V66 tmp61        [V66,T00] (  7,4240.45)     ref  ->  r14         class-hnd "Inlining Arg" <System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V67 tmp62        [V67,T08] (  2, 530.06)     ref  ->  r13         class-hnd "Inline stloc first use temp" <System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]>
 ;* V68 tmp63        [V68    ] (  0,   0   )  struct ( 8) zero-ref    ld-addr-op "NewObj constructor temp" <System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]>
 ;  V69 tmp64        [V69,T50] (  3,   0   )     ref  ->  r15         class-hnd exact "Inlining Arg" <System.Collections.Immutable.SecurePooledObject`1[System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]]>
 ;  V70 tmp65        [V70,T51] (  3,   0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
-;  V71 tmp66        [V71,T21] (  6,   4   )     ref  ->  rsi         single-def "field V08._root (fldOffset=0x0)" P-INDEP
-;  V72 tmp67        [V72,T16] (  8,   6   )     ref  ->  r15         "field V08._stack (fldOffset=0x8)" P-INDEP
-;* V73 tmp68        [V73,T37] (  0,   0   )     ref  ->  zero-ref    single-def "field V08._current (fldOffset=0x10)" P-INDEP
-;  V74 tmp69        [V74,T22] (  5,   4   )     int  ->  r14         single-def "field V08._poolUserId (fldOffset=0x18)" P-INDEP
+;  V71 tmp66        [V71,T24] (  6,   3.99)     ref  ->  rsi         single-def "field V08._root (fldOffset=0x0)" P-INDEP
+;  V72 tmp67        [V72,T18] (  8,   5.97)     ref  ->  r15         "field V08._stack (fldOffset=0x8)" P-INDEP
+;* V73 tmp68        [V73,T38] (  0,   0   )     ref  ->  zero-ref    single-def "field V08._current (fldOffset=0x10)" P-INDEP
+;  V74 tmp69        [V74,T25] (  5,   3.99)     int  ->  r14         single-def "field V08._poolUserId (fldOffset=0x18)" P-INDEP
 ;* V75 tmp70        [V75    ] (  0,   0   )     ref  ->  zero-ref    "field V17._root (fldOffset=0x0)" P-INDEP
 ;* V76 tmp71        [V76    ] (  0,   0   )     ref  ->  zero-ref    "field V17._stack (fldOffset=0x8)" P-INDEP
 ;* V77 tmp72        [V77    ] (  0,   0   )     ref  ->  zero-ref    "field V17._current (fldOffset=0x10)" P-INDEP
 ;* V78 tmp73        [V78    ] (  0,   0   )     int  ->  zero-ref    single-def "field V17._poolUserId (fldOffset=0x18)" P-INDEP
 ;* V79 tmp74        [V79    ] (  0,   0   )     ref  ->  zero-ref    single-def "field V21.Value (fldOffset=0x0)" P-INDEP
 ;* V80 tmp75        [V80    ] (  0,   0   )     ref  ->  zero-ref    "field V22.Value (fldOffset=0x0)" P-INDEP
-;  V81 tmp76        [V81,T32] (  2,   2   )     ref  ->  r15         single-def "field V25.Value (fldOffset=0x0)" P-INDEP
+;  V81 tmp76        [V81,T35] (  2,   1.99)     ref  ->  r15         single-def "field V25.Value (fldOffset=0x0)" P-INDEP
 ;* V82 tmp77        [V82    ] (  0,   0   )     ref  ->  zero-ref    single-def "field V26.Value (fldOffset=0x0)" P-INDEP
 ;* V83 tmp78        [V83    ] (  0,   0   )     ref  ->  zero-ref    "field V27.Value (fldOffset=0x0)" P-INDEP
-;* V84 tmp79        [V84,T36] (  0,   0   )     ref  ->  zero-ref    "field V31.Value (fldOffset=0x0)" P-INDEP
+;* V84 tmp79        [V84,T37] (  0,   0   )     ref  ->  zero-ref    "field V31.Value (fldOffset=0x0)" P-INDEP
 ;* V85 tmp80        [V85    ] (  0,   0   )     ref  ->  zero-ref    "field V35.Value (fldOffset=0x0)" P-INDEP
 ;* V86 tmp81        [V86    ] (  0,   0   )     ref  ->  zero-ref    "field V46._additionalElements (fldOffset=0x0)" P-INDEP
 ;* V87 tmp82        [V87    ] (  0,   0   )     int  ->  zero-ref    "field V46._firstValue (fldOffset=0x8)" P-INDEP
@@ -373,31 +373,31 @@ G_M61964_IG14:
 ;  V90 tmp85        [V90,T52] (  3,   0   )     ref  ->  rcx         "field V63.Value (fldOffset=0x0)" P-INDEP
 ;* V91 tmp86        [V91    ] (  0,   0   )     ref  ->  zero-ref    "field V64.Value (fldOffset=0x0)" P-INDEP
 ;* V92 tmp87        [V92    ] (  0,   0   )     ref  ->  zero-ref    "field V65.Value (fldOffset=0x0)" P-INDEP
-;* V93 tmp88        [V93,T10] (  0,   0   )     ref  ->  zero-ref    "field V68.Value (fldOffset=0x0)" P-INDEP
-;* V94 tmp89        [V94,T38] (  0,   0   )     ref  ->  zero-ref    single-def "V06.[000..008)"
+;* V93 tmp88        [V93,T09] (  0,   0   )     ref  ->  zero-ref    "field V68.Value (fldOffset=0x0)" P-INDEP
+;* V94 tmp89        [V94,T39] (  0,   0   )     ref  ->  zero-ref    single-def "V06.[000..008)"
 ;* V95 tmp90        [V95    ] (  0,   0   )     int  ->  zero-ref    "V06.[008..012)"
 ;* V96 tmp91        [V96    ] (  0,   0   )     ref  ->  zero-ref    single-def "V06.[016..024)"
 ;* V97 tmp92        [V97    ] (  0,   0   )     ref  ->  zero-ref    single-def "V06.[024..032)"
 ;* V98 tmp93        [V98    ] (  0,   0   )     ref  ->  zero-ref    single-def "V06.[032..040)"
 ;* V99 tmp94        [V99    ] (  0,   0   )     int  ->  zero-ref    single-def "V06.[040..044)"
-;  V100 tmp95       [V100    ] ( 18,  19.10)  struct (32) [rbp-0x1F8]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
+;  V100 tmp95       [V100    ] ( 18,   2.02)  struct (32) [rbp-0x1F8]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]>
 ;  V101 tmp96       [V101    ] (  4,   0   )  struct (80) [rbp-0x248]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.Collections.Immutable.ImmutableHashSet`1+HashBucket+Enumerator[int]>
-;  V102 tmp97       [V102    ] (  2,   1.64)  struct (56) [rbp-0x280]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.Collections.Immutable.ImmutableList`1+Enumerator[int]>
+;  V102 tmp97       [V102    ] (  2,  33.78)  struct (56) [rbp-0x280]  do-not-enreg[XS] must-init addr-exposed "by-value struct argument" <System.Collections.Immutable.ImmutableList`1+Enumerator[int]>
 ;  V103 tmp98       [V103,T55] (  2,   0   )     ref  ->  rdx         "argument with side effect"
-;  V104 PSPSym      [V104,T39] (  1,   1   )    long  ->  [rbp-0x290]  do-not-enreg[V] "PSPSym"
-;  V105 cse0        [V105,T29] (  3,   3   )   byref  ->  rcx         "CSE #05: moderate"
-;  V106 cse1        [V106,T30] (  3,   3   )     int  ->  rdx         "CSE #02: moderate"
-;  V107 cse2        [V107,T03] (  3,1522.27)     ref  ->  rcx         "CSE #18: aggressive"
-;  V108 cse3        [V108,T04] (  3,1507.92)     ref  ->  rcx         "CSE #07: aggressive"
-;  V109 cse4        [V109,T05] (  3,1271.72)     ref  ->  rcx         "CSE #11: aggressive"
-;  V110 cse5        [V110,T34] (  2,   2   )     int  ->   r8         "CSE #03: moderate"
-;  V111 cse6        [V111,T31] (  2,   2.05)     int  ->  rdx         "CSE #06: moderate"
-;  V112 cse7        [V112,T33] (  2,   2   )   byref  ->  rdx         hoist "CSE #01: moderate"
-;  V113 cse8        [V113,T35] (  3,   1.52)     ref  ->  rcx         "CSE #09: moderate"
-;  V114 rat0        [V114,T24] (  3,   4   )   byref  ->  rax         "TLS field access"
-;  V115 rat1        [V115,T18] (  3,   6   )    long  ->  rcx         "TLS access"
-;  V116 rat2        [V116,T17] (  3,   6   )   byref  ->  rax         "ThreadStaticBlockBase access"
-;  V117 rat3        [V117,T01] (  3,3047.50)     int  ->  rax         "ReplaceWithLclVar is creating a new local variable"
+;  V104 PSPSym      [V104,T40] (  1,   1   )    long  ->  [rbp-0x290]  do-not-enreg[V] "PSPSym"
+;  V105 cse0        [V105,T31] (  3,   2.98)   byref  ->  rcx         "CSE #05: moderate"
+;  V106 cse1        [V106,T32] (  3,   2.98)     int  ->  rdx         "CSE #02: moderate"
+;  V107 cse2        [V107,T03] (  3,1534.96)     ref  ->  rcx         "CSE #18: aggressive"
+;  V108 cse3        [V108,T04] (  3,1533.44)     ref  ->  rcx         "CSE #07: aggressive"
+;  V109 cse4        [V109,T11] (  3,  31.17)     ref  ->  rcx         "CSE #09: aggressive"
+;  V110 cse5        [V110,T13] (  3,  15.13)     ref  ->  rcx         "CSE #08: aggressive"
+;  V111 cse6        [V111,T36] (  2,   1.99)     int  ->   r8         "CSE #03: moderate"
+;  V112 cse7        [V112,T33] (  2,   2.06)     int  ->  rdx         "CSE #06: moderate"
+;  V113 cse8        [V113,T34] (  2,   2   )   byref  ->  rdx         hoist "CSE #01: moderate"
+;  V114 rat0        [V114,T27] (  3,   3.97)   byref  ->  rax         "TLS field access"
+;  V115 rat1        [V115,T20] (  3,   5.96)    long  ->  rcx         "TLS access"
+;  V116 rat2        [V116,T19] (  3,   5.96)   byref  ->  rax         "ThreadStaticBlockBase access"
+;  V117 rat3        [V117,T01] (  3,3072.92)     int  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 648
 
@@ -427,7 +427,7 @@ G_M61964_IG02:
        mov      rcx, gword ptr [rcx+0x88]
        mov      rcx, gword ptr [rcx+0x10]
        test     rcx, rcx
-       je       G_M61964_IG66
+       je       G_M61964_IG71
        mov      rsi, rcx
        mov      rdx, 0xD1FFAB1E      ; static handle
 						;; size=35 bbWeight=1 PerfScore 6.00
@@ -442,28 +442,34 @@ G_M61964_IG03:
        mov      r14d, edi
        xor      r15, r15
        cmp      gword ptr [rcx+0x08], 0
-       je       G_M61964_IG09
+       je       G_M61964_IG13
+						;; size=35 bbWeight=1 PerfScore 23.50
+G_M61964_IG04:
        mov      rcx, qword ptr GS:[0x0058]
-       mov      rcx, qword ptr [rcx+0x20]
+       mov      rcx, qword ptr [rcx+0x18]
        cmp      dword ptr [rcx+0x208], 5
-       jle      G_M61964_IG60
+       jle      G_M61964_IG65
        mov      rcx, gword ptr [rcx+0x210]
        mov      rax, bword ptr [rcx+0x28]
        test     rax, rax
-       je       G_M61964_IG60
-						;; size=81 bbWeight=1 PerfScore 35.75
-G_M61964_IG04:
+       je       G_M61964_IG65
+						;; size=46 bbWeight=0.99 PerfScore 12.17
+G_M61964_IG05:
        mov      rcx, gword ptr [rax+0x10]
        test     rcx, rcx
-       je       G_M61964_IG62
+       je       G_M61964_IG67
+						;; size=13 bbWeight=0.99 PerfScore 3.23
+G_M61964_IG06:
        mov      edx, dword ptr [rcx+0x10]
        test     edx, edx
-       jle      G_M61964_IG62
+       jle      G_M61964_IG67
+						;; size=11 bbWeight=0.99 PerfScore 3.23
+G_M61964_IG07:
        dec      edx
        mov      rax, gword ptr [rcx+0x08]
        mov      r8d, dword ptr [rax+0x08]
        cmp      r8d, edx
-       jbe      G_M61964_IG61
+       jbe      G_M61964_IG66
        inc      dword ptr [rcx+0x14]
        mov      dword ptr [rcx+0x10], edx
        mov      ecx, edx
@@ -472,23 +478,25 @@ G_M61964_IG04:
        xor      edx, edx
        mov      qword ptr [rcx], rdx
        mov      dword ptr [r15+0x10], r14d
-						;; size=68 bbWeight=1 PerfScore 21.50
-G_M61964_IG05:
+						;; size=44 bbWeight=0.99 PerfScore 14.90
+G_M61964_IG08:
        mov      r13, rsi
        cmp      r14d, dword ptr [r15+0x10]
-       jne      G_M61964_IG64
-						;; size=13 bbWeight=1 PerfScore 4.25
-G_M61964_IG06:
+       jne      G_M61964_IG69
+						;; size=13 bbWeight=0.99 PerfScore 4.22
+G_M61964_IG09:
        mov      r12, gword ptr [r15+0x08]
        cmp      gword ptr [rsi+0x08], 0
-       je       SHORT G_M61964_IG09
-						;; size=11 bbWeight=1.00 PerfScore 6.00
-G_M61964_IG07:
+       je       SHORT G_M61964_IG13
+						;; size=11 bbWeight=0.99 PerfScore 5.96
+G_M61964_IG10:
        mov      edi, dword ptr [r12+0x10]
        mov      rcx, gword ptr [r12+0x08]
        mov      edx, dword ptr [rcx+0x08]
        cmp      edx, edi
-       jbe      G_M61964_IG65
+       jbe      G_M61964_IG70
+						;; size=21 bbWeight=1.03 PerfScore 7.46
+G_M61964_IG11:
        mov      edx, edi
        lea      rcx, bword ptr [rcx+8*rdx+0x10]
        mov      rdx, r13
@@ -496,13 +504,13 @@ G_M61964_IG07:
        inc      dword ptr [r12+0x14]
        inc      edi
        mov      dword ptr [r12+0x10], edi
-						;; size=48 bbWeight=1.03 PerfScore 14.36
-G_M61964_IG08:
+						;; size=27 bbWeight=1.03 PerfScore 6.95
+G_M61964_IG12:
        mov      r13, gword ptr [r13+0x08]
        cmp      gword ptr [r13+0x08], 0
-       jne      SHORT G_M61964_IG07
-						;; size=11 bbWeight=1.03 PerfScore 6.15
-G_M61964_IG09:
+       jne      SHORT G_M61964_IG10
+						;; size=11 bbWeight=1.03 PerfScore 6.17
+G_M61964_IG13:
        vxorps   ymm0, ymm0, ymm0
        vmovdqu  ymmword ptr [rbp-0x108], ymm0
        vmovdqu  ymmword ptr [rbp-0xE8], ymm0
@@ -516,61 +524,64 @@ G_M61964_IG09:
        mov      dword ptr [rbp-0xB0], -1
        mov      gword ptr [rbp-0xA8], rsi
        mov      gword ptr [rbp-0xA0], r15
-						;; size=87 bbWeight=1.00 PerfScore 11.83
-G_M61964_IG10:
+						;; size=87 bbWeight=1 PerfScore 11.83
+G_M61964_IG14:
        mov      gword ptr [rbp-0x98], rcx
        mov      dword ptr [rbp-0x90], r14d
-						;; size=14 bbWeight=1.00 PerfScore 2.00
-G_M61964_IG11:
-       cmp      gword ptr [rbp-0xB8], 0
-       jne      G_M61964_IG34
-						;; size=14 bbWeight=508.42 PerfScore 1525.25
-G_M61964_IG12:
-       cmp      byte  ptr [rbp-0x84], 0
-       jne      G_M61964_IG35
-						;; size=13 bbWeight=508.42 PerfScore 1525.25
-G_M61964_IG13:
-       mov      rcx, gword ptr [rbp-0x80]
-       test     rcx, rcx
-       je       SHORT G_M61964_IG16
-						;; size=9 bbWeight=508.42 PerfScore 1143.94
-G_M61964_IG14:
-       mov      eax, dword ptr [rbp-0x88]
-       cmp      eax, 3
-       ja       G_M61964_IG36
-       lea      rdx, [reloc @RWD00]
-       mov      edx, dword ptr [rdx+4*rax]
-       lea      r8, G_M61964_IG02
-       add      rdx, r8
-       jmp      rdx
-						;; size=37 bbWeight=507.92 PerfScore 4063.34
+						;; size=14 bbWeight=1 PerfScore 2.00
 G_M61964_IG15:
-       cmp      gword ptr [rcx+0x08], 0
-       jne      G_M61964_IG37
-						;; size=11 bbWeight=254.88 PerfScore 1019.54
+       cmp      gword ptr [rbp-0xB8], 0
+       jne      G_M61964_IG39
+						;; size=14 bbWeight=512.65 PerfScore 1537.96
 G_M61964_IG16:
-       mov      dword ptr [rbp-0x88], 3
-       jmp      G_M61964_IG40
-						;; size=15 bbWeight=0.50 PerfScore 1.50
+       cmp      byte  ptr [rbp-0x84], 0
+       jne      G_M61964_IG40
+						;; size=13 bbWeight=512.65 PerfScore 1537.96
 G_M61964_IG17:
-       mov      dword ptr [rbp-0x88], 1
-       jmp      G_M61964_IG20
-						;; size=15 bbWeight=253.03 PerfScore 759.10
+       cmp      gword ptr [rbp-0x80], 0
+       je       SHORT G_M61964_IG21
+						;; size=7 bbWeight=512.65 PerfScore 1537.96
 G_M61964_IG18:
+       mov      ecx, dword ptr [rbp-0x88]
+       cmp      ecx, 3
+       ja       G_M61964_IG41
+						;; size=15 bbWeight=512.15 PerfScore 1152.34
+G_M61964_IG19:
+       mov      ecx, ecx
+       lea      rax, [reloc @RWD00]
+       mov      eax, dword ptr [rax+4*rcx]
+       lea      rdx, G_M61964_IG02
+       add      rax, rdx
+       jmp      rax
+						;; size=24 bbWeight=512.15 PerfScore 3072.92
+G_M61964_IG20:
+       mov      rcx, gword ptr [rbp-0x80]
+       cmp      gword ptr [rcx+0x08], 0
+       jne      G_M61964_IG42
+						;; size=15 bbWeight=255.49 PerfScore 1277.43
+G_M61964_IG21:
+       mov      dword ptr [rbp-0x88], 3
+       jmp      G_M61964_IG45
+						;; size=15 bbWeight=0.50 PerfScore 1.50
+G_M61964_IG22:
+       mov      dword ptr [rbp-0x88], 1
+       jmp      G_M61964_IG25
+						;; size=15 bbWeight=256.67 PerfScore 770.00
+G_M61964_IG23:
        mov      rcx, r13
        mov      rdx, r14
        cmp      dword ptr [rcx], ecx
        call     [System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.__Canon]]:Push(System.Collections.Immutable.RefAsValueType`1[System.__Canon]):this]
        mov      r14, gword ptr [r14+0x08]
        cmp      gword ptr [r14+0x08], 0
-       jne      SHORT G_M61964_IG18
-						;; size=25 bbWeight=520.36 PerfScore 6504.48
-G_M61964_IG19:
+       jne      SHORT G_M61964_IG23
+						;; size=25 bbWeight=530.06 PerfScore 6625.70
+G_M61964_IG24:
        lea      rcx, [rbp-0xA8]
        call     [System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]:ThrowIfDisposed():this]
        mov      rcx, gword ptr [rbp-0x98]
        test     rcx, rcx
-       je       G_M61964_IG53
+       je       G_M61964_IG58
        lea      rdx, [rbp-0x150]
        cmp      dword ptr [rcx], ecx
        call     [System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]:get_Value():System.Collections.Generic.KeyValuePair`2[int,System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]:this]
@@ -588,94 +599,94 @@ G_M61964_IG19:
        lea      rcx, [rbp-0x88]
        call     [System.Collections.Immutable.ImmutableHashSet`1+HashBucket+Enumerator[int]:MoveNext():ubyte:this]
        test     eax, eax
-       je       G_M61964_IG58
-						;; size=139 bbWeight=507.42 PerfScore 14503.84
-G_M61964_IG20:
+       je       G_M61964_IG63
+						;; size=139 bbWeight=511.65 PerfScore 14624.75
+G_M61964_IG25:
        cmp      gword ptr [rbp-0xA8], 0
-       je       SHORT G_M61964_IG26
-						;; size=10 bbWeight=507.42 PerfScore 1522.25
-G_M61964_IG21:
+       je       SHORT G_M61964_IG31
+						;; size=10 bbWeight=511.65 PerfScore 1534.96
+G_M61964_IG26:
        mov      rcx, gword ptr [rbp-0xA0]
        test     rcx, rcx
-       je       SHORT G_M61964_IG22
+       je       SHORT G_M61964_IG27
        mov      eax, dword ptr [rbp-0x90]
        cmp      eax, dword ptr [rcx+0x10]
-       jne      SHORT G_M61964_IG26
-						;; size=23 bbWeight=502.64 PerfScore 3644.15
-G_M61964_IG22:
+       jne      SHORT G_M61964_IG31
+						;; size=23 bbWeight=511.15 PerfScore 3705.81
+G_M61964_IG27:
        cmp      byte  ptr [rbp-0x84], 0
-       jne      G_M61964_IG50
-						;; size=13 bbWeight=507.42 PerfScore 1522.25
-G_M61964_IG23:
+       jne      G_M61964_IG55
+						;; size=13 bbWeight=511.65 PerfScore 1534.96
+G_M61964_IG28:
        mov      ecx, dword ptr [rbp-0x88]
        cmp      ecx, 1
-       jne      SHORT G_M61964_IG28
-						;; size=11 bbWeight=507.42 PerfScore 1141.69
-G_M61964_IG24:
+       jne      SHORT G_M61964_IG33
+						;; size=11 bbWeight=511.65 PerfScore 1151.22
+G_M61964_IG29:
        mov      ebx, dword ptr [rbp-0x78]
-						;; size=3 bbWeight=506.91 PerfScore 506.91
-G_M61964_IG25:
-       jmp      G_M61964_IG11
-						;; size=5 bbWeight=507.42 PerfScore 1014.83
-G_M61964_IG26:
+						;; size=3 bbWeight=501.26 PerfScore 501.26
+G_M61964_IG30:
+       jmp      G_M61964_IG15
+						;; size=5 bbWeight=511.65 PerfScore 1023.31
+G_M61964_IG31:
        vmovdqu  ymm0, ymmword ptr [rbp-0xA8]
        vmovdqu  ymmword ptr [rbp-0x1F8], ymm0
-						;; size=16 bbWeight=4.78 PerfScore 23.88
-G_M61964_IG27:
+						;; size=16 bbWeight=0.51 PerfScore 2.53
+G_M61964_IG32:
        lea      rcx, [rbp-0x1F8]
        call     [<unknown method>]
-       jmp      SHORT G_M61964_IG22
-						;; size=15 bbWeight=4.78 PerfScore 26.26
-G_M61964_IG28:
+       jmp      SHORT G_M61964_IG27
+						;; size=15 bbWeight=0.51 PerfScore 2.78
+G_M61964_IG33:
        cmp      ecx, 2
-       jne      G_M61964_IG52
+       jne      G_M61964_IG57
        cmp      gword ptr [rbp-0x68], 0
-       je       SHORT G_M61964_IG31
-						;; size=16 bbWeight=0.51 PerfScore 2.15
-G_M61964_IG29:
-       cmp      gword ptr [rbp-0x60], 0
-       je       SHORT G_M61964_IG33
-						;; size=7 bbWeight=0.26 PerfScore 0.79
-G_M61964_IG30:
+       je       SHORT G_M61964_IG36
+						;; size=16 bbWeight=10.39 PerfScore 44.16
+G_M61964_IG34:
        mov      rcx, gword ptr [rbp-0x60]
+       test     rcx, rcx
+       je       SHORT G_M61964_IG38
+						;; size=9 bbWeight=5.40 PerfScore 12.16
+G_M61964_IG35:
        mov      eax, dword ptr [rbp-0x50]
        cmp      eax, dword ptr [rcx+0x10]
-       je       SHORT G_M61964_IG33
-						;; size=12 bbWeight=0.21 PerfScore 1.26
-G_M61964_IG31:
+       je       SHORT G_M61964_IG38
+						;; size=8 bbWeight=4.32 PerfScore 21.61
+G_M61964_IG36:
        vmovdqu  ymm0, ymmword ptr [rbp-0x70]
        vmovdqu  ymmword ptr [rbp-0x280], ymm0
        vmovdqu  ymm0, ymmword ptr [rbp-0x58]
        vmovdqu  ymmword ptr [rbp-0x268], ymm0
-						;; size=26 bbWeight=0.41 PerfScore 4.11
-G_M61964_IG32:
+						;; size=26 bbWeight=8.44 PerfScore 84.45
+G_M61964_IG37:
        lea      rcx, [rbp-0x280]
        call     [<unknown method>]
-						;; size=13 bbWeight=0.41 PerfScore 1.44
-G_M61964_IG33:
+						;; size=13 bbWeight=8.44 PerfScore 29.56
+G_M61964_IG38:
        mov      rcx, gword ptr [rbp-0x58]
        test     rcx, rcx
-       je       G_M61964_IG51
+       je       G_M61964_IG56
        mov      ebx, dword ptr [rcx+0x18]
-       jmp      SHORT G_M61964_IG25
-						;; size=18 bbWeight=0.51 PerfScore 3.16
-G_M61964_IG34:
+       jmp      SHORT G_M61964_IG30
+						;; size=18 bbWeight=10.39 PerfScore 64.94
+G_M61964_IG39:
        mov      rcx, gword ptr [rbp-0xB8]
        mov      ecx, dword ptr [rcx+0x2C]
        cmp      ecx, dword ptr [rbp-0xB0]
-       je       G_M61964_IG12
-       jmp      G_M61964_IG57
+       je       G_M61964_IG16
+       jmp      G_M61964_IG62
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M61964_IG35:
+G_M61964_IG40:
        lea      rcx, bword ptr [rbp-0x248]
        lea      rdx, [rbp-0x88]
        mov      r8d, 80
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
        lea      rcx, [rbp-0x248]
        call     [<unknown method>]
-       jmp      G_M61964_IG13
+       jmp      G_M61964_IG17
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M61964_IG36:
+G_M61964_IG41:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
@@ -685,7 +696,7 @@ G_M61964_IG36:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M61964_IG37:
+G_M61964_IG42:
        mov      dword ptr [rbp-0x88], 2
        vxorps   ymm0, ymm0, ymm0
        vmovdqu  ymmword ptr [rbp-0x1D8], ymm0
@@ -699,61 +710,61 @@ G_M61964_IG37:
        mov      r9d, -1
        call     [System.Collections.Immutable.ImmutableList`1+Enumerator[int]:.ctor(System.Collections.Immutable.ImmutableList`1+Node[int],System.Collections.Immutable.ImmutableList`1+Builder[int],int,int,ubyte):this]
 						;; size=70 bbWeight=0 PerfScore 0.00
-G_M61964_IG38:
+G_M61964_IG43:
        vmovdqu  ymm0, ymmword ptr [rbp-0x1D8]
        vmovdqu  ymmword ptr [rbp-0x70], ymm0
        vmovdqu  ymm0, ymmword ptr [rbp-0x1C0]
        vmovdqu  ymmword ptr [rbp-0x58], ymm0
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M61964_IG39:
+G_M61964_IG44:
        lea      rcx, [rbp-0x70]
        call     [System.Collections.Immutable.ImmutableList`1+Enumerator[int]:MoveNext():ubyte:this]
        test     eax, eax
-       jne      G_M61964_IG20
+       jne      G_M61964_IG25
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M61964_IG40:
+G_M61964_IG45:
        cmp      gword ptr [rbp-0xA8], 0
-       je       SHORT G_M61964_IG41
+       je       SHORT G_M61964_IG46
        cmp      gword ptr [rbp-0xA0], 0
-       je       SHORT G_M61964_IG43
+       je       SHORT G_M61964_IG48
        mov      rcx, gword ptr [rbp-0xA0]
        mov      eax, dword ptr [rbp-0x90]
        cmp      eax, dword ptr [rcx+0x10]
-       je       SHORT G_M61964_IG43
+       je       SHORT G_M61964_IG48
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M61964_IG41:
+G_M61964_IG46:
        vmovdqu  ymm0, ymmword ptr [rbp-0xA8]
        vmovdqu  ymmword ptr [rbp-0x1F8], ymm0
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M61964_IG42:
+G_M61964_IG47:
        lea      rcx, [rbp-0x1F8]
        call     [<unknown method>]
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M61964_IG43:
+G_M61964_IG48:
        cmp      gword ptr [rbp-0xA0], 0
-       je       G_M61964_IG56
+       je       G_M61964_IG61
        mov      rsi, gword ptr [rbp-0xA0]
        mov      ecx, dword ptr [rbp-0x90]
        cmp      ecx, dword ptr [rsi+0x10]
-       je       SHORT G_M61964_IG46
+       je       SHORT G_M61964_IG51
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M61964_IG44:
+G_M61964_IG49:
        vmovdqu  ymm0, ymmword ptr [rbp-0xA8]
        vmovdqu  ymmword ptr [rbp-0x1F8], ymm0
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M61964_IG45:
+G_M61964_IG50:
        lea      rcx, [rbp-0x1F8]
        call     [<unknown method>]
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M61964_IG46:
+G_M61964_IG51:
        mov      rcx, gword ptr [rsi+0x08]
        cmp      dword ptr [rcx+0x10], 0
-       jle      G_M61964_IG56
+       jle      G_M61964_IG61
        mov      eax, dword ptr [rcx+0x10]
        dec      eax
        mov      rdx, gword ptr [rcx+0x08]
        cmp      dword ptr [rdx+0x08], eax
-       jbe      G_M61964_IG55
+       jbe      G_M61964_IG60
        inc      dword ptr [rcx+0x14]
        mov      dword ptr [rcx+0x10], eax
        mov      ecx, eax
@@ -763,36 +774,36 @@ G_M61964_IG46:
        mov      gword ptr [rbp-0x98], rcx
        mov      r14, gword ptr [rcx+0x10]
        test     r14, r14
-       je       G_M61964_IG54
+       je       G_M61964_IG59
        mov      r15, gword ptr [rbp-0xA0]
        mov      ecx, dword ptr [rbp-0x90]
        cmp      ecx, dword ptr [r15+0x10]
-       je       SHORT G_M61964_IG49
+       je       SHORT G_M61964_IG54
 						;; size=92 bbWeight=0 PerfScore 0.00
-G_M61964_IG47:
+G_M61964_IG52:
        vmovdqu  ymm0, ymmword ptr [rbp-0xA8]
        vmovdqu  ymmword ptr [rbp-0x1F8], ymm0
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M61964_IG48:
+G_M61964_IG53:
        lea      rcx, [rbp-0x1F8]
        call     [<unknown method>]
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M61964_IG49:
+G_M61964_IG54:
        mov      r13, gword ptr [r15+0x08]
        cmp      gword ptr [r14+0x08], 0
-       je       G_M61964_IG19
-       jmp      G_M61964_IG18
+       je       G_M61964_IG24
+       jmp      G_M61964_IG23
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M61964_IG50:
+G_M61964_IG55:
        lea      rcx, bword ptr [rbp-0x248]
        lea      rdx, [rbp-0x88]
        mov      r8d, 80
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
        lea      rcx, [rbp-0x248]
        call     [<unknown method>]
-       jmp      G_M61964_IG23
+       jmp      G_M61964_IG28
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M61964_IG51:
+G_M61964_IG56:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
@@ -802,7 +813,7 @@ G_M61964_IG51:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M61964_IG52:
+G_M61964_IG57:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      r12, rax
@@ -812,7 +823,7 @@ G_M61964_IG52:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M61964_IG53:
+G_M61964_IG58:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
@@ -822,7 +833,7 @@ G_M61964_IG53:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M61964_IG54:
+G_M61964_IG59:
        mov      ecx, 0x83D
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -830,16 +841,16 @@ G_M61964_IG54:
        call     [System.Collections.Immutable.Requires:FailArgumentNullException(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M61964_IG55:
+G_M61964_IG60:
        call     [System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.__Canon]]:ThrowForEmptyStack():this]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M61964_IG56:
+G_M61964_IG61:
        xor      rcx, rcx
        mov      gword ptr [rbp-0x98], rcx
-       jmp      SHORT G_M61964_IG58
+       jmp      SHORT G_M61964_IG63
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M61964_IG57:
+G_M61964_IG62:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
@@ -851,12 +862,12 @@ G_M61964_IG57:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M61964_IG58:
+G_M61964_IG63:
        lea      rcx, [rbp-0xB8]
        call     [System.Collections.Immutable.ImmutableHashSet`1+Enumerator[int]:Dispose():this]
        mov      eax, ebx
 						;; size=15 bbWeight=1.00 PerfScore 3.75
-G_M61964_IG59:
+G_M61964_IG64:
        vzeroupper 
        add      rsp, 648
        pop      rbx
@@ -869,16 +880,16 @@ G_M61964_IG59:
        pop      rbp
        ret      
 						;; size=23 bbWeight=1.00 PerfScore 6.25
-G_M61964_IG60:
+G_M61964_IG65:
        mov      ecx, 5
        call     CORINFO_HELP_GETDYNAMIC_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
-       jmp      G_M61964_IG04
+       jmp      G_M61964_IG05
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M61964_IG61:
+G_M61964_IG66:
        call     [System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.__Canon]]:ThrowForEmptyStack():this]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M61964_IG62:
+G_M61964_IG67:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.Stack`1[System.Collections.Immutable.RefAsValueType`1[System.Collections.Immutable.SortedInt32KeyNode`1[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]]
        call     CORINFO_HELP_NEWSFAST
        mov      r15, rax
@@ -889,7 +900,7 @@ G_M61964_IG62:
        xor      rdx, rdx
        mov      gword ptr [rbp-0x1F0], rdx
 						;; size=47 bbWeight=0 PerfScore 0.00
-G_M61964_IG63:
+G_M61964_IG68:
        mov      gword ptr [rbp-0x1E8], rdx
        mov      dword ptr [rbp-0x1E0], edi
        lea      rdx, [rbp-0x1F8]
@@ -897,9 +908,9 @@ G_M61964_IG63:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     [System.Collections.Immutable.SecureObjectPool`2[System.__Canon,System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]]]:PrepNew(System.Collections.Immutable.SortedInt32KeyNode`1+Enumerator[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[int]],System.__Canon):System.Collections.Immutable.SecurePooledObject`1[System.__Canon]]
        mov      r15, rax
-       jmp      G_M61964_IG05
+       jmp      G_M61964_IG08
 						;; size=47 bbWeight=0 PerfScore 0.00
-G_M61964_IG64:
+G_M61964_IG69:
        mov      gword ptr [rbp-0x1F8], r13
        mov      gword ptr [rbp-0x1F0], r15
        xor      rcx, rcx
@@ -907,15 +918,15 @@ G_M61964_IG64:
        mov      dword ptr [rbp-0x1E0], r14d
        lea      rcx, [rbp-0x1F8]
        call     [<unknown method>]
-       jmp      G_M61964_IG06
+       jmp      G_M61964_IG09
 						;; size=48 bbWeight=0 PerfScore 0.00
-G_M61964_IG65:
+G_M61964_IG70:
        mov      rcx, r12
        mov      rdx, r13
        call     [<unknown method>]
-       jmp      G_M61964_IG08
+       jmp      G_M61964_IG12
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M61964_IG66:
+G_M61964_IG71:
        mov      ecx, 0x4AB
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -923,7 +934,7 @@ G_M61964_IG66:
        call     [System.Collections.Immutable.Requires:FailArgumentNullException(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M61964_IG67:
+G_M61964_IG72:
        push     rbp
        push     r15
        push     r14
@@ -937,12 +948,12 @@ G_M61964_IG67:
        mov      qword ptr [rsp+0x30], rbp
        lea      rbp, [rbp+0x2C0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M61964_IG68:
+G_M61964_IG73:
        lea      rcx, [rbp-0xB8]
        call     [System.Collections.Immutable.ImmutableHashSet`1+Enumerator[int]:Dispose():this]
        nop      
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M61964_IG69:
+G_M61964_IG74:
        vzeroupper 
        add      rsp, 56
        pop      rbx
@@ -955,12 +966,12 @@ G_M61964_IG69:
        pop      rbp
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-RWD00  	dd	G_M61964_IG17 - G_M61964_IG02
-       	dd	G_M61964_IG15 - G_M61964_IG02
-       	dd	G_M61964_IG39 - G_M61964_IG02
-       	dd	G_M61964_IG40 - G_M61964_IG02
+RWD00  	dd	G_M61964_IG22 - G_M61964_IG02
+       	dd	G_M61964_IG20 - G_M61964_IG02
+       	dd	G_M61964_IG44 - G_M61964_IG02
+       	dd	G_M61964_IG45 - G_M61964_IG02
 
 
-; Total bytes of code 1960, prolog size 76, PerfScore 40597.75, instruction count 416, allocated bytes for code 1960 (MethodHash=5ba70df3) for method System.Collections.IterateForEach`1[int]:ImmutableHashSet():int:this (Tier1)
+; Total bytes of code 1962, prolog size 76, PerfScore 41988.41, instruction count 417, allocated bytes for code 1962 (MethodHash=5ba70df3) for method System.Collections.IterateForEach`1[int]:ImmutableHashSet():int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Tests.Perf_PriorityQueue<Int32, Int32>.Enumerate(Size: 10)``

Hot functions:

- (86.25%) ``System.Collections.Tests.Perf_PriorityQueue`2.Enumerate`` (Tier-1)
  - No diffs
- (7.58%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

# ``System.Tests.Perf_String.IndexerCheckBoundCheckHoist``

Hot functions:

- (87.56%) ``Perf_String.IndexerCheckBoundCheckHoist`` (Tier-1)
  - **Has diffs**
- (9.61%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]Perf_String.IndexerCheckBoundCheckHoist()``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 378368
+; with Dynamic PGO: fgCalledCount is 389696
 ; Final local variable assignments
 ;
 ;* V00 this         [V00    ] (  0,  0   )     ref  ->  zero-ref    this class-hnd single-def <System.Tests.Perf_String>
-;* V01 loc0         [V01,T03] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
-;  V02 loc1         [V02,T01] (  4,141.91)     int  ->  rax        
-;* V03 loc2         [V03,T04] (  0,  0   )     int  ->  zero-ref    single-def
-;* V04 loc3         [V04,T05] (  0,  0   )     int  ->  zero-ref   
+;* V01 loc0         [V01,T04] (  0,  0   )     ref  ->  zero-ref    class-hnd exact single-def <<unknown class>>
+;  V02 loc1         [V02,T02] (  4,142.09)     int  ->  rax        
+;* V03 loc2         [V03,T05] (  0,  0   )     int  ->  zero-ref    single-def
+;* V04 loc3         [V04,T06] (  0,  0   )     int  ->  zero-ref   
 ;# V05 OutArgs      [V05    ] (  1,  1   )  struct ( 0) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;* V06 cse0         [V06,T02] (  0,  0   )     ref  ->  zero-ref    "CSE #01: aggressive"
-;  V07 rat0         [V07,T00] (  5,280.83)    long  ->  rcx         "Widened IV V04"
+;* V06 cse0         [V06,T03] (  0,  0   )     ref  ->  zero-ref    "CSE #01: aggressive"
+;  V07 rat0         [V07,T00] (  4,211.14)    long  ->  rcx         "Strength reduced derived IV"
+;  V08 rat1         [V08,T01] (  4,211.14)     int  ->  rdx         "Trip count IV"
 ;
 ; Lcl frame size = 0
 
@@ -209,21 +210,22 @@ G_M25933_IG01:
 						;; size=0 bbWeight=0.99 PerfScore 0.00
 G_M25933_IG02:
        xor      eax, eax
-       xor      ecx, ecx
-       align    [0 bytes for IG03]
-						;; size=4 bbWeight=0.99 PerfScore 0.49
+       mov      ecx, 12
+       mov      edx, 71
+       align    [4 bytes for IG03]
+						;; size=16 bbWeight=0.99 PerfScore 0.99
 G_M25933_IG03:
-       mov      rdx, 0xD1FFAB1E
-       movzx    rdx, word  ptr [rdx+2*rcx+0x0C]
-       add      eax, edx
-       inc      ecx
-       cmp      ecx, 71
-       jl       SHORT G_M25933_IG03
-						;; size=24 bbWeight=69.96 PerfScore 279.85
+       mov      r8, 0xD1FFAB1E
+       movzx    r8, word  ptr [r8+rcx]
+       add      eax, r8d
+       add      rcx, 2
+       dec      edx
+       jne      SHORT G_M25933_IG03
+						;; size=26 bbWeight=70.05 PerfScore 280.20
 G_M25933_IG04:
        ret      
 						;; size=1 bbWeight=1.00 PerfScore 1.00
 
-; Total bytes of code 29, prolog size 0, PerfScore 281.34, instruction count 10, allocated bytes for code 29 (MethodHash=089a9ab2) for method System.Tests.Perf_String:IndexerCheckBoundCheckHoist():int:this (Tier1)
+; Total bytes of code 43, prolog size 0, PerfScore 282.19, instruction count 11, allocated bytes for code 43 (MethodHash=089a9ab2) for method System.Tests.Perf_String:IndexerCheckBoundCheckHoist():int:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Collections.Perf_LengthBucketsFrozenDictionary.TryGetValue_False_FrozenDictionary(Count: 10000, ItemsPerBucket: 1)``

Hot functions:

- (97.45%) ``Perf_FrozenDictionary_String.TryGetValue_False_FrozenDictionary`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[MicroBenchmarks]Perf_FrozenDictionary_String.TryGetValue_False_FrozenDictionary()``

```diff
 G_M15923_IG02:
        mov      r14d, dword ptr [rbp+0x08]
        cmp      r14d, ebx
-       jle      SHORT G_M15923_IG10
+       jle      SHORT G_M15923_IG09
 						;; size=9 bbWeight=0.60 PerfScore 1.93
 G_M15923_IG03:
        test     rsi, rsi
-       je       SHORT G_M15923_IG12
+       je       SHORT G_M15923_IG11
        mov      rax, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rsi], rax
-       jne      SHORT G_M15923_IG12
+       jne      SHORT G_M15923_IG11
 						;; size=20 bbWeight=0.59 PerfScore 3.25
 G_M15923_IG04:
        cmp      ebx, r14d
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      eax, ebx
        mov      r15, gword ptr [rbp+8*rax+0x10]
        test     r15, r15
-       je       G_M15923_IG32
-						;; size=25 bbWeight=98.41 PerfScore 467.45
-G_M15923_IG05:
+       je       G_M15923_IG30
        mov      eax, dword ptr [r15+0x08]
        sub      eax, dword ptr [rsi+0x28]
        lea      r13d, [rax+4*rax]
        lea      r12d, [r13+0x05]
        mov      r8, gword ptr [rsi+0x10]
        test     r13d, r13d
-       jl       SHORT G_M15923_IG07
-						;; size=24 bbWeight=98.41 PerfScore 910.30
-G_M15923_IG06:
+       jl       SHORT G_M15923_IG06
+						;; size=49 bbWeight=98.41 PerfScore 1377.75
+G_M15923_IG05:
        cmp      dword ptr [r8+0x08], r12d
-       jge      G_M15923_IG19
+       jge      G_M15923_IG17
 						;; size=10 bbWeight=98.31 PerfScore 393.25
-G_M15923_IG07:
+G_M15923_IG06:
        xor      r10, r10
 						;; size=3 bbWeight=98.41 PerfScore 24.60
-G_M15923_IG08:
+G_M15923_IG07:
        test     r10, r10
-       jne      G_M15923_IG24
+       jne      G_M15923_IG22
        xor      eax, eax
 						;; size=11 bbWeight=98.41 PerfScore 147.62
-G_M15923_IG09:
+G_M15923_IG08:
        xor      eax, edi
        movzx    rdi, al
        inc      ebx
        cmp      r14d, ebx
        jg       SHORT G_M15923_IG04
 						;; size=13 bbWeight=98.41 PerfScore 196.82
-G_M15923_IG10:
+G_M15923_IG09:
        mov      eax, edi
 						;; size=2 bbWeight=0.60 PerfScore 0.15
-G_M15923_IG11:
+G_M15923_IG10:
        add      rsp, 232
        pop      rbx
        pop      rsi
@@ -407,21 +405,19 @@ G_M15923_IG11:
        pop      rbp
        ret      
 						;; size=20 bbWeight=0.60 PerfScore 3.12
-G_M15923_IG12:
+G_M15923_IG11:
        cmp      ebx, r14d
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      r8d, ebx
        mov      r15, gword ptr [rbp+8*r8+0x10]
        cmp      byte  ptr [rsi], sil
        test     r15, r15
-       je       G_M15923_IG32
+       je       G_M15923_IG30
 						;; size=29 bbWeight=0.99 PerfScore 7.70
-G_M15923_IG13:
+G_M15923_IG12:
        mov      r10, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rsi], r10
-       jne      G_M15923_IG30
-						;; size=19 bbWeight=0.99 PerfScore 4.22
-G_M15923_IG14:
+       jne      G_M15923_IG28
        mov      edx, dword ptr [r15+0x08]
        sub      edx, dword ptr [rsi+0x28]
        lea      r13d, [rdx+4*rdx]
@@ -429,46 +425,46 @@ G_M15923_IG14:
        mov      r8, gword ptr [rsi+0x10]
        mov      rax, r8
        test     r13d, r13d
-       jl       SHORT G_M15923_IG16
-						;; size=27 bbWeight=0.99 PerfScore 9.44
-G_M15923_IG15:
+       jl       SHORT G_M15923_IG14
+						;; size=46 bbWeight=0.99 PerfScore 13.67
+G_M15923_IG13:
        cmp      dword ptr [rax+0x08], r12d
-       jge      G_M15923_IG25
+       jge      G_M15923_IG23
 						;; size=10 bbWeight=0.99 PerfScore 3.97
-G_M15923_IG16:
+G_M15923_IG14:
        xor      r10, r10
 						;; size=3 bbWeight=0.99 PerfScore 0.25
-G_M15923_IG17:
+G_M15923_IG15:
        test     r10, r10
-       jne      G_M15923_IG31
+       jne      G_M15923_IG29
        xor      eax, eax
 						;; size=11 bbWeight=0.99 PerfScore 1.49
-G_M15923_IG18:
+G_M15923_IG16:
        mov      edx, edi
        xor      edx, eax
        movzx    rdi, dl
        inc      ebx
        cmp      r14d, ebx
-       jg       SHORT G_M15923_IG12
-       jmp      G_M15923_IG10
+       jg       SHORT G_M15923_IG11
+       jmp      G_M15923_IG09
 						;; size=20 bbWeight=0.99 PerfScore 4.22
-G_M15923_IG19:
+G_M15923_IG17:
        mov      r9, gword ptr [rsi+0x18]
        mov      r11, gword ptr [rsi+0x20]
        cmp      byte  ptr [rsi+0x2C], 0
-       jne      G_M15923_IG22
+       jne      G_M15923_IG20
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M15923_IG20:
+G_M15923_IG18:
        cmp      r13d, r12d
-       jge      G_M15923_IG07
+       jge      G_M15923_IG06
        cmp      r13d, dword ptr [r8+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      edx, r13d
        mov      gword ptr [rsp+0x38], r8
        mov      ecx, dword ptr [r8+4*rdx+0x10]
        cmp      dword ptr [r9+0x08], ecx
        mov      gword ptr [rsp+0x28], r11
-       jbe      G_M15923_IG07
+       jbe      G_M15923_IG06
        mov      dword ptr [rsp+0x40], ecx
        mov      edx, ecx
        mov      gword ptr [rsp+0x30], r9
@@ -476,33 +472,33 @@ G_M15923_IG20:
        mov      rcx, r15
        call     [System.String:Equals(System.String,System.String):ubyte]
        test     eax, eax
-       jne      SHORT G_M15923_IG21
+       jne      SHORT G_M15923_IG19
        inc      r13d
        mov      r8, gword ptr [rsp+0x38]
        mov      r9, gword ptr [rsp+0x30]
        mov      r11, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG20
+       jmp      SHORT G_M15923_IG18
 						;; size=96 bbWeight=0 PerfScore 0.00
-G_M15923_IG21:
+G_M15923_IG19:
        mov      r15d, dword ptr [rsp+0x40]
        mov      r13, gword ptr [rsp+0x28]
        cmp      r15d, dword ptr [r13+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      r8d, r15d
        lea      r10, bword ptr [r13+8*r8+0x10]
-       jmp      G_M15923_IG08
+       jmp      G_M15923_IG07
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M15923_IG22:
+G_M15923_IG20:
        cmp      r13d, r12d
-       jge      G_M15923_IG07
+       jge      G_M15923_IG06
        cmp      r13d, dword ptr [r8+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      ecx, r13d
        mov      gword ptr [rsp+0x38], r8
        mov      eax, dword ptr [r8+4*rcx+0x10]
        cmp      dword ptr [r9+0x08], eax
        mov      gword ptr [rsp+0x28], r11
-       jbe      G_M15923_IG07
+       jbe      G_M15923_IG06
        mov      dword ptr [rsp+0x44], eax
        mov      ecx, eax
        mov      gword ptr [rsp+0x30], r9
@@ -512,46 +508,46 @@ G_M15923_IG22:
        mov      rdx, r15
        call     [<unknown method>]
        test     eax, eax
-       jne      SHORT G_M15923_IG23
+       jne      SHORT G_M15923_IG21
        inc      r13d
        mov      r8, gword ptr [rsp+0x38]
        mov      r9, gword ptr [rsp+0x30]
        mov      r11, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG22
+       jmp      SHORT G_M15923_IG20
 						;; size=109 bbWeight=0 PerfScore 0.00
-G_M15923_IG23:
+G_M15923_IG21:
        mov      r15d, dword ptr [rsp+0x44]
        mov      r13, gword ptr [rsp+0x28]
        cmp      r15d, dword ptr [r13+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      edx, r15d
        lea      r10, bword ptr [r13+8*rdx+0x10]
-       jmp      G_M15923_IG08
+       jmp      G_M15923_IG07
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M15923_IG24:
+G_M15923_IG22:
        mov      eax, 1
-       jmp      G_M15923_IG09
+       jmp      G_M15923_IG08
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M15923_IG25:
+G_M15923_IG23:
        mov      r9, gword ptr [rsi+0x18]
        mov      r8, r9
        mov      rdx, gword ptr [rsi+0x20]
        mov      r9, rdx
        cmp      byte  ptr [rsi+0x2C], 0
-       jne      G_M15923_IG28
+       jne      G_M15923_IG26
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M15923_IG26:
+G_M15923_IG24:
        cmp      r13d, r12d
-       jge      G_M15923_IG16
+       jge      G_M15923_IG14
        cmp      r13d, dword ptr [rax+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      edx, r13d
        mov      gword ptr [rsp+0x38], rax
        mov      edx, dword ptr [rax+4*rdx+0x10]
        mov      r10d, edx
        cmp      dword ptr [r8+0x08], r10d
        mov      gword ptr [rsp+0x28], r9
-       jbe      G_M15923_IG16
+       jbe      G_M15923_IG14
        mov      dword ptr [rsp+0x40], r10d
        mov      edx, r10d
        mov      gword ptr [rsp+0x30], r8
@@ -559,34 +555,34 @@ G_M15923_IG26:
        mov      rcx, r15
        call     [System.String:Equals(System.String,System.String):ubyte]
        test     eax, eax
-       jne      SHORT G_M15923_IG27
+       jne      SHORT G_M15923_IG25
        inc      r13d
        mov      rax, gword ptr [rsp+0x38]
        mov      r8, gword ptr [rsp+0x30]
        mov      r9, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG26
+       jmp      SHORT G_M15923_IG24
 						;; size=100 bbWeight=0 PerfScore 0.00
-G_M15923_IG27:
+G_M15923_IG25:
        mov      r15d, dword ptr [rsp+0x40]
        mov      r13, gword ptr [rsp+0x28]
        cmp      r15d, dword ptr [r13+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      r8d, r15d
        lea      r10, bword ptr [r13+8*r8+0x10]
-       jmp      G_M15923_IG17
+       jmp      G_M15923_IG15
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M15923_IG28:
+G_M15923_IG26:
        cmp      r13d, r12d
-       jge      G_M15923_IG16
+       jge      G_M15923_IG14
        cmp      r13d, dword ptr [rax+0x08]
-       jae      G_M15923_IG33
+       jae      G_M15923_IG31
        mov      ecx, r13d
        mov      gword ptr [rsp+0x38], rax
        mov      ecx, dword ptr [rax+4*rcx+0x10]
        mov      r10d, ecx
        cmp      dword ptr [r8+0x08], r10d
        mov      gword ptr [rsp+0x28], r9
-       jbe      G_M15923_IG16
+       jbe      G_M15923_IG14
        mov      dword ptr [rsp+0x44], r10d
        mov      ecx, r10d
        mov      gword ptr [rsp+0x30], r8
@@ -596,36 +592,36 @@ G_M15923_IG28:
        mov      rdx, r15
        call     [<unknown method>]
        test     eax, eax
-       jne      SHORT G_M15923_IG29
+       jne      SHORT G_M15923_IG27
        inc      r13d
        mov      rax, gword ptr [rsp+0x38]
        mov      r8, gword ptr [rsp+0x30]
        mov      r9, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG28
+       jmp      SHORT G_M15923_IG26
 						;; size=113 bbWeight=0 PerfScore 0.00
-G_M15923_IG29:
+G_M15923_IG27:
        mov      r15d, dword ptr [rsp+0x44]
        mov      r13, gword ptr [rsp+0x28]
        cmp      r15d, dword ptr [r13+0x08]
-       jae      SHORT G_M15923_IG33
+       jae      SHORT G_M15923_IG31
        mov      ecx, r15d
        lea      r10, bword ptr [r13+8*rcx+0x10]
-       jmp      G_M15923_IG17
+       jmp      G_M15923_IG15
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M15923_IG30:
+G_M15923_IG28:
        mov      rcx, rsi
        mov      rdx, r15
        mov      rax, qword ptr [rsi]
        mov      rax, qword ptr [rax+0x50]
        call     [rax+0x38]<unknown method>
        mov      r10, rax
-       jmp      G_M15923_IG17
+       jmp      G_M15923_IG15
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M15923_IG31:
+G_M15923_IG29:
        mov      eax, 1
-       jmp      G_M15923_IG18
+       jmp      G_M15923_IG16
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M15923_IG32:
+G_M15923_IG30:
        mov      ecx, 0x6BD
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -633,7 +629,7 @@ G_M15923_IG32:
        call     [System.Collections.ThrowHelper:ThrowArgumentNullException(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M15923_IG33:
+G_M15923_IG31:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
@@ -652,29 +648,33 @@ G_M15923_IG33:
 ; 3 inlinees with PGO data; 2 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T11] (  4,   4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Perf_FrozenDictionary_String>
-;  V01 loc0         [V01,T04] (  6, 336.13)   ubyte  ->  rbx        
-;  V02 loc1         [V02,T03] ( 17, 340.46)     ref  ->  rsi         class-hnd single-def <<unknown class>>
-;  V03 loc2         [V03,T09] (  4, 169.07)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
-;  V04 loc3         [V04,T01] (  9, 669.27)     int  ->  rbp        
+;  V00 this         [V00,T10] (  4,   4   )     ref  ->  rcx         this class-hnd single-def <System.Collections.Perf_FrozenDictionary_String>
+;  V01 loc0         [V01,T05] (  6, 336.13)   ubyte  ->  rbx        
+;  V02 loc1         [V02,T04] ( 17, 340.46)     ref  ->  rsi         class-hnd single-def <<unknown class>>
+;  V03 loc2         [V03,T13] (  4,   3.00)     ref  ->  rdi         class-hnd exact single-def <<unknown class>>
+;* V04 loc3         [V04,T15] (  0,   0   )     int  ->  zero-ref   
 ;* V05 loc4         [V05    ] (  0,   0   )     ref  ->  zero-ref    ld-addr-op class-hnd <System.String>
 ;  V06 OutArgs      [V06    ] (  1,   1   )  struct (32) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V07 tmp1         [V07,T06] (  6, 334.13)   ubyte  ->  rax         "Inline return value spill temp"
-;  V08 tmp2         [V08,T00] ( 11,1002.40)     ref  ->  r15         class-hnd exact "Inlining Arg" <System.String>
+;  V07 tmp1         [V07,T07] (  6, 334.13)   ubyte  ->  rax         "Inline return value spill temp"
+;  V08 tmp2         [V08,T00] ( 11,1002.40)     ref  ->  r14         class-hnd exact "Inlining Arg" <System.String>
 ;* V09 tmp3         [V09    ] (  0,   0   )   byref  ->  zero-ref    "Inline stloc first use temp"
-;  V10 tmp4         [V10,T05] (  9, 334.13)   byref  ->  r10         "guarded devirt return temp"
+;  V10 tmp4         [V10,T06] (  9, 334.13)   byref  ->   r8         "guarded devirt return temp"
 ;* V11 tmp5         [V11    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
-;  V12 tmp6         [V12,T02] ( 26, 501.20)     int  ->  r13         "Inline stloc first use temp"
-;  V13 tmp7         [V13,T08] (  8, 333.97)     int  ->  r12         "Inline stloc first use temp"
-;  V14 tmp8         [V14,T07] ( 12, 333.97)     ref  ->  [rsp+0x38]  class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V15 tmp9         [V15,T12] ( 10,   0   )     ref  ->  [rsp+0x30]  class-hnd exact "Inline stloc first use temp" <<unknown class>>
-;  V16 tmp10        [V16,T13] ( 10,   0   )     ref  ->  [rsp+0x28]  class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V17 tmp11        [V17,T14] ( 10,   0   )     int  ->  [rsp+0x44]  "Inline stloc first use temp"
-;  V18 tmp12        [V18,T15] ( 10,   0   )     int  ->  [rsp+0x40]  "Inline stloc first use temp"
+;  V12 tmp6         [V12,T01] ( 26, 501.20)     int  ->  r15         "Inline stloc first use temp"
+;  V13 tmp7         [V13,T09] (  8, 333.97)     int  ->  r13         "Inline stloc first use temp"
+;  V14 tmp8         [V14,T08] ( 12, 333.97)     ref  ->  r12         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V15 tmp9         [V15,T16] ( 10,   0   )     ref  ->  [rsp+0x28]  class-hnd exact "Inline stloc first use temp" <<unknown class>>
+;  V16 tmp10        [V16,T17] ( 10,   0   )     ref  ->  [rsp+0x20]  class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V17 tmp11        [V17,T18] ( 10,   0   )     int  ->  [rsp+0x34]  "Inline stloc first use temp"
+;  V18 tmp12        [V18,T19] ( 10,   0   )     int  ->  [rsp+0x30]  "Inline stloc first use temp"
 ;* V19 tmp13        [V19    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
-;  V20 cse0         [V20,T10] (  4, 169.07)     int  ->  r14         "CSE #07: aggressive"
+;  V20 cse0         [V20,T14] (  4,   3.00)     int  ->  rbp         "CSE #07: aggressive"
+;  V21 rat0         [V21,T11] (  4,   5.02)   byref  ->  rdi         "Strength reduced derived IV"
+;  V22 rat1         [V22,T12] (  4,   5.02)     int  ->  rbp         "Trip count IV"
+;  V23 rat2         [V23,T02] (  4, 497.18)   byref  ->  rdi         "Strength reduced derived IV"
+;  V24 rat3         [V24,T03] (  4, 497.18)     int  ->  rbp         "Trip count IV"
 ;
-; Lcl frame size = 72
+; Lcl frame size = 56
 
 G_M15923_IG01:
        push     r15
@@ -685,61 +685,60 @@ G_M15923_IG01:
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 72
+       sub      rsp, 56
 						;; size=16 bbWeight=1 PerfScore 8.25
 G_M15923_IG02:
        xor      ebx, ebx
        mov      rsi, gword ptr [rcx+0x28]
        mov      rdi, gword ptr [rcx+0x10]
-       xor      ebp, ebp
-       mov      r14d, dword ptr [rdi+0x08]
-       test     r14d, r14d
+       mov      ebp, dword ptr [rdi+0x08]
+       test     ebp, ebp
        jle      SHORT G_M15923_IG09
-						;; size=21 bbWeight=1 PerfScore 7.75
+						;; size=17 bbWeight=1 PerfScore 7.50
 G_M15923_IG03:
        test     rsi, rsi
        je       SHORT G_M15923_IG11
        mov      rax, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rsi], rax
        jne      SHORT G_M15923_IG11
-						;; size=20 bbWeight=0.99 PerfScore 5.47
+       add      rdi, 16
+						;; size=24 bbWeight=0.99 PerfScore 5.72
 G_M15923_IG04:
-       mov      eax, ebp
-       mov      r15, gword ptr [rdi+8*rax+0x10]
-       test     r15, r15
-       je       G_M15923_IG29
-       mov      eax, dword ptr [r15+0x08]
+       mov      r14, gword ptr [rdi]
+       test     r14, r14
+       je       G_M15923_IG30
+       mov      eax, dword ptr [r14+0x08]
        sub      eax, dword ptr [rsi+0x28]
-       lea      r13d, [rax+4*rax]
-       lea      r12d, [r13+0x05]
-       mov      r8, gword ptr [rsi+0x10]
-       test     r13d, r13d
+       lea      r15d, [rax+4*rax]
+       lea      r13d, [r15+0x05]
+       mov      r12, gword ptr [rsi+0x10]
+       test     r15d, r15d
        jl       SHORT G_M15923_IG06
-						;; size=40 bbWeight=165.40 PerfScore 2108.81
+						;; size=36 bbWeight=165.40 PerfScore 2067.46
 G_M15923_IG05:
-       cmp      dword ptr [r8+0x08], r12d
-       jge      G_M15923_IG16
-						;; size=10 bbWeight=165.23 PerfScore 660.92
+       cmp      dword ptr [r12+0x08], r13d
+       jge      G_M15923_IG17
+						;; size=11 bbWeight=165.23 PerfScore 660.92
 G_M15923_IG06:
-       xor      r10, r10
+       xor      r8, r8
 						;; size=3 bbWeight=165.40 PerfScore 41.35
 G_M15923_IG07:
-       test     r10, r10
-       jne      G_M15923_IG21
+       test     r8, r8
+       jne      G_M15923_IG22
        xor      eax, eax
 						;; size=11 bbWeight=165.40 PerfScore 248.09
 G_M15923_IG08:
        xor      eax, ebx
        movzx    rbx, al
-       inc      ebp
-       cmp      r14d, ebp
-       jg       SHORT G_M15923_IG04
-						;; size=12 bbWeight=165.40 PerfScore 330.79
+       add      rdi, 8
+       dec      ebp
+       jne      SHORT G_M15923_IG04
+						;; size=13 bbWeight=165.40 PerfScore 330.79
 G_M15923_IG09:
        mov      eax, ebx
 						;; size=2 bbWeight=1.00 PerfScore 0.25
 G_M15923_IG10:
-       add      rsp, 72
+       add      rsp, 56
        pop      rbx
        pop      rbp
        pop      rsi
@@ -751,218 +750,211 @@ G_M15923_IG10:
        ret      
 						;; size=17 bbWeight=1.00 PerfScore 5.25
 G_M15923_IG11:
-       mov      r8d, ebp
-       mov      r15, gword ptr [rdi+8*r8+0x10]
-       cmp      byte  ptr [rsi], sil
-       test     r15, r15
-       je       G_M15923_IG29
-       mov      r10, 0xD1FFAB1E      ; <unknown class>
-       cmp      qword ptr [rsi], r10
-       jne      G_M15923_IG27
-       mov      edx, dword ptr [r15+0x08]
-       sub      edx, dword ptr [rsi+0x28]
-       lea      r13d, [rdx+4*rdx]
-       lea      r12d, [r13+0x05]
-       mov      r8, gword ptr [rsi+0x10]
-       mov      rax, r8
-       test     r13d, r13d
-       jl       SHORT G_M15923_IG13
-						;; size=66 bbWeight=1.67 PerfScore 33.83
+       add      rdi, 16
+						;; size=4 bbWeight=0.01 PerfScore 0.00
 G_M15923_IG12:
-       cmp      dword ptr [rax+0x08], r12d
-       jge      G_M15923_IG22
-						;; size=10 bbWeight=1.67 PerfScore 6.68
-G_M15923_IG13:
-       xor      r10, r10
-						;; size=3 bbWeight=1.67 PerfScore 0.42
-G_M15923_IG14:
-       test     r10, r10
+       mov      r14, gword ptr [rdi]
+       cmp      byte  ptr [rsi], sil
+       test     r14, r14
+       je       G_M15923_IG30
+       mov      r8, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rsi], r8
        jne      G_M15923_IG28
+       mov      edx, dword ptr [r14+0x08]
+       sub      edx, dword ptr [rsi+0x28]
+       lea      r15d, [rdx+4*rdx]
+       lea      r13d, [r15+0x05]
+       mov      r12, gword ptr [rsi+0x10]
+       test     r15d, r15d
+       jl       SHORT G_M15923_IG14
+						;; size=58 bbWeight=1.67 PerfScore 33.00
+G_M15923_IG13:
+       cmp      dword ptr [r12+0x08], r13d
+       jge      G_M15923_IG23
+						;; size=11 bbWeight=1.67 PerfScore 6.68
+G_M15923_IG14:
+       xor      r8, r8
+						;; size=3 bbWeight=1.67 PerfScore 0.42
+G_M15923_IG15:
+       test     r8, r8
+       jne      G_M15923_IG29
        xor      eax, eax
 						;; size=11 bbWeight=1.67 PerfScore 2.51
-G_M15923_IG15:
+G_M15923_IG16:
        mov      edx, ebx
        xor      edx, eax
        movzx    rbx, dl
-       inc      ebp
-       cmp      r14d, ebp
-       jg       SHORT G_M15923_IG11
+       add      rdi, 8
+       dec      ebp
+       jne      SHORT G_M15923_IG12
        jmp      SHORT G_M15923_IG09
-						;; size=16 bbWeight=1.67 PerfScore 7.10
-G_M15923_IG16:
-       mov      r9, gword ptr [rsi+0x18]
-       mov      r11, gword ptr [rsi+0x20]
-       cmp      byte  ptr [rsi+0x2C], 0
-       jne      G_M15923_IG19
-						;; size=18 bbWeight=0 PerfScore 0.00
+						;; size=17 bbWeight=1.67 PerfScore 7.10
 G_M15923_IG17:
-       cmp      r13d, r12d
+       mov      r10, gword ptr [rsi+0x18]
+       mov      r9, gword ptr [rsi+0x20]
+       cmp      byte  ptr [rsi+0x2C], 0
+       jne      SHORT G_M15923_IG20
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M15923_IG18:
+       cmp      r15d, r13d
        jge      G_M15923_IG06
-       cmp      r13d, dword ptr [r8+0x08]
-       jae      G_M15923_IG30
-       mov      edx, r13d
-       mov      gword ptr [rsp+0x38], r8
-       mov      ecx, dword ptr [r8+4*rdx+0x10]
-       cmp      dword ptr [r9+0x08], ecx
-       mov      gword ptr [rsp+0x28], r11
+       cmp      r15d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      edx, r15d
+       mov      r11d, dword ptr [r12+4*rdx+0x10]
+       cmp      dword ptr [r10+0x08], r11d
+       mov      gword ptr [rsp+0x20], r9
        jbe      G_M15923_IG06
-       mov      dword ptr [rsp+0x40], ecx
-       mov      edx, ecx
-       mov      gword ptr [rsp+0x30], r9
-       mov      rdx, gword ptr [r9+8*rdx+0x10]
-       mov      rcx, r15
+       mov      dword ptr [rsp+0x30], r11d
+       mov      edx, r11d
+       mov      gword ptr [rsp+0x28], r10
+       mov      rdx, gword ptr [r10+8*rdx+0x10]
+       mov      rcx, r14
        call     [System.String:Equals(System.String,System.String):ubyte]
        test     eax, eax
-       jne      SHORT G_M15923_IG18
-       inc      r13d
-       mov      r8, gword ptr [rsp+0x38]
-       mov      r9, gword ptr [rsp+0x30]
-       mov      r11, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG17
-						;; size=96 bbWeight=0 PerfScore 0.00
-G_M15923_IG18:
-       mov      r15d, dword ptr [rsp+0x40]
-       mov      r13, gword ptr [rsp+0x28]
-       cmp      r15d, dword ptr [r13+0x08]
-       jae      G_M15923_IG30
-       mov      r8d, r15d
-       lea      r10, bword ptr [r13+8*r8+0x10]
-       jmp      G_M15923_IG07
-						;; size=33 bbWeight=0 PerfScore 0.00
+       jne      SHORT G_M15923_IG19
+       inc      r15d
+       mov      r9, gword ptr [rsp+0x20]
+       mov      r10, gword ptr [rsp+0x28]
+       jmp      SHORT G_M15923_IG18
+						;; size=89 bbWeight=0 PerfScore 0.00
 G_M15923_IG19:
-       cmp      r13d, r12d
+       mov      r14d, dword ptr [rsp+0x30]
+       mov      r12, gword ptr [rsp+0x20]
+       cmp      r14d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      r8d, r14d
+       lea      r8, bword ptr [r12+8*r8+0x10]
+       jmp      G_M15923_IG07
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M15923_IG20:
+       cmp      r15d, r13d
        jge      G_M15923_IG06
-       cmp      r13d, dword ptr [r8+0x08]
-       jae      G_M15923_IG30
-       mov      ecx, r13d
-       mov      gword ptr [rsp+0x38], r8
-       mov      eax, dword ptr [r8+4*rcx+0x10]
-       cmp      dword ptr [r9+0x08], eax
-       mov      gword ptr [rsp+0x28], r11
+       cmp      r15d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      r8d, r15d
+       mov      eax, dword ptr [r12+4*r8+0x10]
+       cmp      dword ptr [r10+0x08], eax
+       mov      gword ptr [rsp+0x20], r9
        jbe      G_M15923_IG06
-       mov      dword ptr [rsp+0x44], eax
-       mov      ecx, eax
-       mov      gword ptr [rsp+0x30], r9
-       mov      r8, gword ptr [r9+8*rcx+0x10]
+       mov      dword ptr [rsp+0x34], eax
+       mov      r8d, eax
+       mov      gword ptr [rsp+0x28], r10
+       mov      r8, gword ptr [r10+8*r8+0x10]
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rcx, gword ptr [rcx]
-       mov      rdx, r15
+       mov      rdx, r14
        call     [<unknown method>]
        test     eax, eax
-       jne      SHORT G_M15923_IG20
-       inc      r13d
-       mov      r8, gword ptr [rsp+0x38]
-       mov      r9, gword ptr [rsp+0x30]
-       mov      r11, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG19
-						;; size=109 bbWeight=0 PerfScore 0.00
-G_M15923_IG20:
-       mov      r15d, dword ptr [rsp+0x44]
-       mov      r13, gword ptr [rsp+0x28]
-       cmp      r15d, dword ptr [r13+0x08]
-       jae      G_M15923_IG30
-       mov      edx, r15d
-       lea      r10, bword ptr [r13+8*rdx+0x10]
-       jmp      G_M15923_IG07
-						;; size=33 bbWeight=0 PerfScore 0.00
+       jne      SHORT G_M15923_IG21
+       inc      r15d
+       mov      r9, gword ptr [rsp+0x20]
+       mov      r10, gword ptr [rsp+0x28]
+       jmp      SHORT G_M15923_IG20
+						;; size=101 bbWeight=0 PerfScore 0.00
 G_M15923_IG21:
+       mov      r14d, dword ptr [rsp+0x34]
+       mov      r12, gword ptr [rsp+0x20]
+       cmp      r14d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      edx, r14d
+       lea      r8, bword ptr [r12+8*rdx+0x10]
+       jmp      G_M15923_IG07
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M15923_IG22:
        mov      eax, 1
        jmp      G_M15923_IG08
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M15923_IG22:
-       mov      r9, gword ptr [rsi+0x18]
-       mov      r8, r9
-       mov      rdx, gword ptr [rsi+0x20]
-       mov      r9, rdx
-       cmp      byte  ptr [rsi+0x2C], 0
-       jne      G_M15923_IG25
-						;; size=24 bbWeight=0 PerfScore 0.00
 G_M15923_IG23:
-       cmp      r13d, r12d
-       jge      G_M15923_IG13
-       cmp      r13d, dword ptr [rax+0x08]
-       jae      G_M15923_IG30
-       mov      edx, r13d
-       mov      gword ptr [rsp+0x38], rax
-       mov      edx, dword ptr [rax+4*rdx+0x10]
-       mov      r10d, edx
-       cmp      dword ptr [r8+0x08], r10d
-       mov      gword ptr [rsp+0x28], r9
-       jbe      G_M15923_IG13
-       mov      dword ptr [rsp+0x40], r10d
-       mov      edx, r10d
-       mov      gword ptr [rsp+0x30], r8
-       mov      rdx, gword ptr [r8+8*rdx+0x10]
-       mov      rcx, r15
+       mov      r10, gword ptr [rsi+0x18]
+       mov      rax, r10
+       mov      rdx, gword ptr [rsi+0x20]
+       mov      r10, rdx
+       cmp      byte  ptr [rsi+0x2C], 0
+       jne      G_M15923_IG26
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M15923_IG24:
+       cmp      r15d, r13d
+       jge      G_M15923_IG14
+       cmp      r15d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      edx, r15d
+       mov      edx, dword ptr [r12+4*rdx+0x10]
+       mov      r8d, edx
+       cmp      dword ptr [rax+0x08], r8d
+       mov      gword ptr [rsp+0x20], r10
+       jbe      G_M15923_IG14
+       mov      dword ptr [rsp+0x30], r8d
+       mov      edx, r8d
+       mov      gword ptr [rsp+0x28], rax
+       mov      rdx, gword ptr [rax+8*rdx+0x10]
+       mov      rcx, r14
        call     [System.String:Equals(System.String,System.String):ubyte]
        test     eax, eax
-       jne      SHORT G_M15923_IG24
-       inc      r13d
-       mov      rax, gword ptr [rsp+0x38]
-       mov      r8, gword ptr [rsp+0x30]
-       mov      r9, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG23
-						;; size=100 bbWeight=0 PerfScore 0.00
-G_M15923_IG24:
-       mov      r15d, dword ptr [rsp+0x40]
-       mov      r13, gword ptr [rsp+0x28]
-       cmp      r15d, dword ptr [r13+0x08]
-       jae      G_M15923_IG30
-       mov      r8d, r15d
-       lea      r10, bword ptr [r13+8*r8+0x10]
-       jmp      G_M15923_IG14
-						;; size=33 bbWeight=0 PerfScore 0.00
+       jne      SHORT G_M15923_IG25
+       inc      r15d
+       mov      rax, gword ptr [rsp+0x28]
+       mov      r10, gword ptr [rsp+0x20]
+       jmp      SHORT G_M15923_IG24
+						;; size=92 bbWeight=0 PerfScore 0.00
 G_M15923_IG25:
-       cmp      r13d, r12d
-       jge      G_M15923_IG13
-       cmp      r13d, dword ptr [rax+0x08]
-       jae      G_M15923_IG30
-       mov      ecx, r13d
-       mov      gword ptr [rsp+0x38], rax
-       mov      ecx, dword ptr [rax+4*rcx+0x10]
-       mov      r10d, ecx
-       cmp      dword ptr [r8+0x08], r10d
-       mov      gword ptr [rsp+0x28], r9
-       jbe      G_M15923_IG13
-       mov      dword ptr [rsp+0x44], r10d
-       mov      ecx, r10d
-       mov      gword ptr [rsp+0x30], r8
-       mov      r8, gword ptr [r8+8*rcx+0x10]
+       mov      r14d, dword ptr [rsp+0x30]
+       mov      r12, gword ptr [rsp+0x20]
+       cmp      r14d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      r8d, r14d
+       lea      r8, bword ptr [r12+8*r8+0x10]
+       jmp      G_M15923_IG15
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M15923_IG26:
+       cmp      r15d, r13d
+       jge      G_M15923_IG14
+       cmp      r15d, dword ptr [r12+0x08]
+       jae      G_M15923_IG31
+       mov      r8d, r15d
+       mov      r8d, dword ptr [r12+4*r8+0x10]
+       mov      r9d, r8d
+       cmp      dword ptr [rax+0x08], r9d
+       mov      gword ptr [rsp+0x20], r10
+       jbe      G_M15923_IG14
+       mov      dword ptr [rsp+0x34], r9d
+       mov      r8d, r9d
+       mov      gword ptr [rsp+0x28], rax
+       mov      r8, gword ptr [rax+8*r8+0x10]
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rcx, gword ptr [rcx]
-       mov      rdx, r15
+       mov      rdx, r14
        call     [<unknown method>]
        test     eax, eax
-       jne      SHORT G_M15923_IG26
-       inc      r13d
-       mov      rax, gword ptr [rsp+0x38]
-       mov      r8, gword ptr [rsp+0x30]
-       mov      r9, gword ptr [rsp+0x28]
-       jmp      SHORT G_M15923_IG25
-						;; size=113 bbWeight=0 PerfScore 0.00
-G_M15923_IG26:
-       mov      r15d, dword ptr [rsp+0x44]
-       mov      r13, gword ptr [rsp+0x28]
-       cmp      r15d, dword ptr [r13+0x08]
-       jae      SHORT G_M15923_IG30
-       mov      ecx, r15d
-       lea      r10, bword ptr [r13+8*rcx+0x10]
-       jmp      G_M15923_IG14
-						;; size=29 bbWeight=0 PerfScore 0.00
+       jne      SHORT G_M15923_IG27
+       inc      r15d
+       mov      rax, gword ptr [rsp+0x28]
+       mov      r10, gword ptr [rsp+0x20]
+       jmp      SHORT G_M15923_IG26
+						;; size=105 bbWeight=0 PerfScore 0.00
 G_M15923_IG27:
+       mov      r14d, dword ptr [rsp+0x34]
+       mov      r12, gword ptr [rsp+0x20]
+       cmp      r14d, dword ptr [r12+0x08]
+       jae      SHORT G_M15923_IG31
+       mov      ecx, r14d
+       lea      r8, bword ptr [r12+8*rcx+0x10]
+       jmp      G_M15923_IG15
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M15923_IG28:
        mov      rcx, rsi
-       mov      rdx, r15
+       mov      rdx, r14
        mov      rax, qword ptr [rsi]
        mov      rax, qword ptr [rax+0x50]
        call     [rax+0x38]<unknown method>
-       mov      r10, rax
-       jmp      G_M15923_IG14
-						;; size=24 bbWeight=0 PerfScore 0.00
-G_M15923_IG28:
-       mov      eax, 1
+       mov      r8, rax
        jmp      G_M15923_IG15
-						;; size=10 bbWeight=0 PerfScore 0.00
+						;; size=24 bbWeight=0 PerfScore 0.00
 G_M15923_IG29:
+       mov      eax, 1
+       jmp      G_M15923_IG16
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M15923_IG30:
        mov      ecx, 0x6BD
        mov      rdx, 0xD1FFAB1E
        call     CORINFO_HELP_STRCNS
@@ -970,11 +962,11 @@ G_M15923_IG29:
        call     [System.Collections.ThrowHelper:ThrowArgumentNullException(System.String)]
        int3     
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M15923_IG30:
+G_M15923_IG31:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 926, prolog size 16, PerfScore 3467.47, instruction count 238, allocated bytes for code 926 (MethodHash=53f5c1cc) for method System.Collections.Perf_FrozenDictionary_String:TryGetValue_False_FrozenDictionary():ubyte:this (Tier1)
+; Total bytes of code 891, prolog size 16, PerfScore 3425.28, instruction count 228, allocated bytes for code 891 (MethodHash=53f5c1cc) for method System.Collections.Perf_FrozenDictionary_String:TryGetValue_False_FrozenDictionary():ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_Enumerable.Repeat``

Hot functions:

- (81.76%) ``ConsumerExtensions.Consume`` (Tier-1)
  - No diffs
- (4.29%) ``Perf_Enumerable.Repeat`` (Tier-1)
  - No diffs
- (2.13%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

# ``System.Linq.Tests.Perf_Enumerable.SelectToList(input: IEnumerable)``

Hot functions:

- (62.67%) ``System.Linq.Enumerable+IEnumerableSelectIterator`2.ToList`` (Tier-1)
  - **Has diffs**
- (7.74%) ``System.Collections.Generic.SegmentedArrayBuilder`1.Expand`` (Tier-1)
  - No diffs
- (3.72%) ``EventSource.WriteEventWithRelatedActivityIdCore`` (Tier-1)
  - No diffs
- (1.94%) ``ArrayPoolEventSource.BufferRented`` (Tier-1)
  - No diffs
- (1.80%) ``EventSource.WriteEvent`` (Tier-1)
  - No diffs
- (1.42%) ``System.Collections.Generic.SegmentedArrayBuilder`1.AddSlow`` (Tier-1)
  - No diffs
- (1.38%) ``SpanHelpers.Memmove`` (Tier-1)
  - **Has diffs**
- (1.23%) ``Enumerable.Select`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Linq]System.Linq.Enumerable+IEnumerableSelectIterator`2[System.Int32,System.Int32].ToList()``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 41904
+; with Dynamic PGO: fgCalledCount is 60688
 ; 25 inlinees with PGO data; 34 single block inlinees; 6 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T34] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Linq.Enumerable+IEnumerableSelectIterator`2[int,int]>
+;  V00 this         [V00,T35] (  4,  4   )     ref  ->  rcx         this class-hnd single-def <System.Linq.Enumerable+IEnumerableSelectIterator`2[int,int]>
 ;  V01 loc0         [V01    ] (  3,  3   )  struct (32) [rbp-0x58]  do-not-enreg[XS] addr-exposed ld-addr-op <System.Collections.Generic.SegmentedArrayBuilder`1+ScratchBuffer[int]>
-;  V02 loc1         [V02    ] ( 21,517.77)  struct (264) [rbp-0x160]  do-not-enreg[XSF] must-init addr-exposed ld-addr-op <System.Collections.Generic.SegmentedArrayBuilder`1[int]>
-;  V03 loc2         [V03,T12] (  4,101.36)     ref  ->  rbx         class-hnd single-def <<unknown class>>
-;  V04 loc3         [V04,T00] ( 16,707.54)     ref  ->  [rbp-0x188]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
-;  V05 loc4         [V05,T08] (  4,200.72)     int  ->  rdx        
+;  V02 loc1         [V02    ] ( 21,521.21)  struct (264) [rbp-0x160]  do-not-enreg[XSF] must-init addr-exposed ld-addr-op <System.Collections.Generic.SegmentedArrayBuilder`1[int]>
+;  V03 loc2         [V03,T12] (  4,102.05)     ref  ->  rbx         class-hnd single-def <<unknown class>>
+;  V04 loc3         [V04,T00] ( 16,712.40)     ref  ->  [rbp-0x188]  class-hnd EH-live single-def <System.Collections.Generic.IEnumerator`1[int]>
+;  V05 loc4         [V05,T08] (  4,202.11)     int  ->  rdx        
 ;  V06 OutArgs      [V06    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V07 tmp1         [V07    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[int]>
-;  V08 tmp2         [V08,T44] (  2,  4.00)     ref  ->  rdi         class-hnd single-def "impAppendStmt" <System.Collections.Generic.List`1[int]>
-;  V09 tmp3         [V09,T58] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
-;  V10 tmp4         [V10,T35] (  4,  6   )     ref  ->  rcx         single-def "guarded devirt arg temp"
+;  V08 tmp2         [V08,T45] (  2,  4.00)     ref  ->  rdi         class-hnd single-def "impAppendStmt" <System.Collections.Generic.List`1[int]>
+;  V09 tmp3         [V09,T59] (  3,  2   )     ref  ->  rsi         "guarded devirt return temp"
+;  V10 tmp4         [V10,T36] (  4,  6   )     ref  ->  rcx         single-def "guarded devirt arg temp"
 ;* V11 tmp5         [V11    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]>
 ;* V12 tmp6         [V12    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V13 tmp7         [V13    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
-;  V14 tmp8         [V14,T09] (  4,200.72)     int  ->  rdx         "guarded devirt return temp"
+;  V14 tmp8         [V14,T09] (  4,202.11)     int  ->  rdx         "guarded devirt return temp"
 ;* V15 tmp9         [V15    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Linq.Tests.Perf_Enumerable+<>c>
-;  V16 tmp10        [V16,T99] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
+;  V16 tmp10        [V16,T100] (  2,  0   )     int  ->  rax         "guarded devirt return temp"
 ;* V17 tmp11        [V17    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V18 tmp12        [V18    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <System.SZGenericArrayEnumerator`1[int]>
 ;* V19 tmp13        [V19    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
 ;* V20 tmp14        [V20    ] (  0,  0   )  struct (16) zero-ref    "Inline stloc first use temp" <System.Span`1[int]>
 ;* V21 tmp15        [V21    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Span`1[int]>
-;  V22 tmp16        [V22,T05] (  3,298.08)     int  ->   r8         "Inline stloc first use temp"
-;  V23 tmp17        [V23,T03] (  3,303.09)     int  ->  rcx         "Inline stloc first use temp"
-;  V24 tmp18        [V24,T33] (  8,  6.00)     int  ->  rbx         "Inline stloc first use temp"
-;  V25 tmp19        [V25,T87] (  3,  0   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.List`1[int]>
-;  V26 tmp20        [V26,T31] ( 11,  7.00)     ref  ->  rdi         class-hnd "Inline stloc first use temp" <System.Collections.Generic.List`1[int]>
-;  V27 tmp21        [V27,T36] (  3,  6.00)     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.List`1[int]>
+;  V22 tmp16        [V22,T05] (  3,300.19)     int  ->   r8         "Inline stloc first use temp"
+;  V23 tmp17        [V23,T03] (  3,305.16)     int  ->  rcx         "Inline stloc first use temp"
+;  V24 tmp18        [V24,T34] (  8,  6.00)     int  ->  rbx         "Inline stloc first use temp"
+;  V25 tmp19        [V25,T88] (  3,  0   )     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.List`1[int]>
+;  V26 tmp20        [V26,T30] ( 11,  7.00)     ref  ->  rdi         class-hnd "Inline stloc first use temp" <System.Collections.Generic.List`1[int]>
+;  V27 tmp21        [V27,T37] (  3,  6.00)     ref  ->  rdi         class-hnd exact single-def "NewObj constructor temp" <System.Collections.Generic.List`1[int]>
 ;* V28 tmp22        [V28    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.Span`1[int]>
-;  V29 tmp23        [V29,T79] (  3,  0.00)     int  ->  rdx        
-;  V30 tmp24        [V30,T78] (  8,  0.01)     int  ->  rdx         "Inline stloc first use temp"
+;  V29 tmp23        [V29,T80] (  3,  0.01)     int  ->  rdx        
+;  V30 tmp24        [V30,T79] (  8,  0.04)     int  ->  rdx         "Inline stloc first use temp"
 ;* V31 tmp25        [V31    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.Span`1[int]>
 ;* V32 tmp26        [V32    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.Span`1[int]>
-;  V33 tmp27        [V33,T53] (  3,  3.00)     int  ->  rsi         "Inline stloc first use temp"
-;  V34 tmp28        [V34,T52] (  3,  3.00)     ref  ->  rbx         class-hnd single-def "Inline stloc first use temp" <int[]>
+;  V33 tmp27        [V33,T53] (  3,  2.99)     int  ->  rsi         "Inline stloc first use temp"
+;  V34 tmp28        [V34,T52] (  3,  2.99)     ref  ->  rbx         class-hnd single-def "Inline stloc first use temp" <int[]>
 ;* V35 tmp29        [V35    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
 ;* V36 tmp30        [V36    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V37 tmp31        [V37,T32] (  7,  7.00)     int  ->  r13         "Inline stloc first use temp"
+;  V37 tmp31        [V37,T31] (  7,  7.00)     int  ->  r13         "Inline stloc first use temp"
 ;* V38 tmp32        [V38    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Span`1[int]>
 ;* V39 tmp33        [V39    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
 ;* V40 tmp34        [V40    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[int]>
 ;* V41 tmp35        [V41    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[int[]]>
 ;* V42 tmp36        [V42    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[int[]]>
-;* V43 tmp37        [V43,T72] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;* V43 tmp37        [V43,T73] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V44 tmp38        [V44    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[int]>
 ;* V45 tmp39        [V45    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
 ;* V46 tmp40        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[int]>
@@ -468,12 +468,12 @@ G_M45160_IG17:
 ;* V52 tmp46        [V52    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V53 tmp47        [V53    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V54 tmp48        [V54    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
-;  V55 tmp49        [V55,T45] (  2,  4.00)   byref  ->   r8         single-def "Inlining Arg"
-;  V56 tmp50        [V56,T46] (  2,  4.00)     int  ->  rsi         "Inlining Arg"
+;  V55 tmp49        [V55,T46] (  2,  4.00)   byref  ->   r8         single-def "Inlining Arg"
+;  V56 tmp50        [V56,T47] (  2,  4.00)     int  ->  rsi         "Inlining Arg"
 ;* V57 tmp51        [V57    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[int[]]>
 ;* V58 tmp52        [V58    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[int[]]>
 ;* V59 tmp53        [V59    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V60 tmp54        [V60,T23] (  4, 11.82)     ref  ->  r13         class-hnd "Inlining Arg" <int[]>
+;  V60 tmp54        [V60,T23] (  4, 11.67)     ref  ->  r13         class-hnd "Inlining Arg" <int[]>
 ;* V61 tmp55        [V61    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[int]>
 ;* V62 tmp56        [V62    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
 ;* V63 tmp57        [V63    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
@@ -481,9 +481,9 @@ G_M45160_IG17:
 ;* V65 tmp59        [V65    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V66 tmp60        [V66    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V67 tmp61        [V67    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
-;  V68 tmp62        [V68,T29] (  2,  7.98)   byref  ->  r14         "Inlining Arg"
-;  V69 tmp63        [V69,T30] (  2,  7.98)     int  ->  r15         "Inlining Arg"
-;  V70 tmp64        [V70,T28] (  4,  8.00)     int  ->   r8         "Inlining Arg"
+;  V68 tmp62        [V68,T28] (  2,  7.88)   byref  ->  r14         "Inlining Arg"
+;  V69 tmp63        [V69,T29] (  2,  7.88)     int  ->  r15         "Inlining Arg"
+;  V70 tmp64        [V70,T27] (  4,  8.00)     int  ->   r8         "Inlining Arg"
 ;* V71 tmp65        [V71    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Span`1[int]>
 ;* V72 tmp66        [V72    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V73 tmp67        [V73    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.Span`1[int]>
@@ -492,31 +492,31 @@ G_M45160_IG17:
 ;* V76 tmp70        [V76    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V77 tmp71        [V77    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V78 tmp72        [V78    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[int[]]>
-;* V79 tmp73        [V79,T75] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V80 tmp74        [V80,T15] ( 10, 16.83)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <int[]>
-;  V81 tmp75        [V81,T19] (  2, 11.87)     ref  ->  rsi         class-hnd exact "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
-;  V82 tmp76        [V82,T54] (  6,  2.97)     ref  ->  rsi         class-hnd exact "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
+;* V79 tmp73        [V79,T76] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V80 tmp74        [V80,T15] ( 10, 16.74)     ref  ->  rbx         class-hnd "Inline stloc first use temp" <int[]>
+;  V81 tmp75        [V81,T19] (  2, 11.81)     ref  ->  rsi         class-hnd exact "spilling ret_expr" <System.Buffers.SharedArrayPool`1[int]>
+;  V82 tmp76        [V82,T54] (  6,  2.95)     ref  ->  rsi         class-hnd exact "guarded devirt this exact temp" <System.Buffers.SharedArrayPool`1[int]>
 ;* V83 tmp77        [V83    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[int[]]>
-;  V84 tmp78        [V84,T22] (  8, 11.86)     int  ->  r14         "Inline stloc first use temp"
-;  V85 tmp79        [V85,T20] (  2, 11.87)     ref  ->   r8         class-hnd exact "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V86 tmp80        [V86,T21] (  5, 11.87)     ref  ->   r8        
+;  V84 tmp78        [V84,T22] (  8, 11.81)     int  ->  r14         "Inline stloc first use temp"
+;  V85 tmp79        [V85,T20] (  2, 11.81)     ref  ->   r8         class-hnd exact "dup spill" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
+;  V86 tmp80        [V86,T21] (  5, 11.81)     ref  ->   r8        
 ;* V87 tmp81        [V87    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Buffers.SharedArrayPoolThreadLocalArray[]>
-;  V88 tmp82        [V88,T39] (  4,  5.93)   ubyte  ->  r15         "Inline stloc first use temp"
-;  V89 tmp83        [V89,T55] (  3,  2.97)   ubyte  ->  r12         "Inline stloc first use temp"
-;  V90 tmp84        [V90,T37] (  4,  5.94)     ref  ->  [rbp-0x190]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
-;  V91 tmp85        [V91,T100] (  2,  0   )     int  ->  [rbp-0x164]  spill-single-def "impAppendStmt"
-;  V92 tmp86        [V92,T101] (  2,  0   )     int  ->  [rbp-0x168]  spill-single-def "impAppendStmt"
-;  V93 tmp87        [V93,T102] (  2,  0   )     int  ->  r12         "impAppendStmt"
-;  V94 tmp88        [V94,T103] (  2,  0   )     int  ->  rbx         "impAppendStmt"
+;  V88 tmp82        [V88,T40] (  4,  5.90)   ubyte  ->  r15         "Inline stloc first use temp"
+;  V89 tmp83        [V89,T55] (  3,  2.95)   ubyte  ->  r12         "Inline stloc first use temp"
+;  V90 tmp84        [V90,T38] (  4,  5.91)     ref  ->  [rbp-0x190]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Buffers.ArrayPoolEventSource>
+;  V91 tmp85        [V91,T101] (  2,  0   )     int  ->  [rbp-0x164]  spill-single-def "impAppendStmt"
+;  V92 tmp86        [V92,T102] (  2,  0   )     int  ->  [rbp-0x168]  spill-single-def "impAppendStmt"
+;  V93 tmp87        [V93,T103] (  2,  0   )     int  ->  r12         "impAppendStmt"
+;  V94 tmp88        [V94,T104] (  2,  0   )     int  ->  rbx         "impAppendStmt"
 ;* V95 tmp89        [V95    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V96 tmp90        [V96    ] (  0,  0   )     int  ->  zero-ref   
 ;* V97 tmp91        [V97    ] (  0,  0   )     int  ->  zero-ref   
-;  V98 tmp92        [V98,T104] (  2,  0   )     int  ->   r9        
+;  V98 tmp92        [V98,T105] (  2,  0   )     int  ->   r9        
 ;* V99 tmp93        [V99    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V100 tmp94       [V100    ] (  0,  0   )     int  ->  zero-ref   
 ;* V101 tmp95       [V101    ] (  0,  0   )     int  ->  zero-ref   
 ;* V102 tmp96       [V102    ] (  0,  0   )     int  ->  zero-ref   
-;  V103 tmp97       [V103,T91] (  3,  0   )     int  ->  rcx        
+;  V103 tmp97       [V103,T92] (  3,  0   )     int  ->  rcx        
 ;* V104 tmp98       [V104    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V105 tmp99       [V105    ] (  0,  0   )     int  ->  zero-ref   
 ;* V106 tmp100      [V106    ] (  0,  0   )     int  ->  zero-ref   
@@ -527,104 +527,105 @@ G_M45160_IG17:
 ;* V111 tmp105      [V111    ] (  0,  0   )     int  ->  zero-ref   
 ;* V112 tmp106      [V112    ] (  0,  0   )     int  ->  zero-ref   
 ;* V113 tmp107      [V113    ] (  0,  0   )     int  ->  zero-ref   
-;  V114 tmp108      [V114,T92] (  3,  0   )     int  ->  rdx        
+;  V114 tmp108      [V114,T93] (  3,  0   )     int  ->  rdx        
 ;* V115 tmp109      [V115    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
-;  V116 tmp110      [V116,T13] (  4, 23.72)   byref  ->  [rbp-0x198]  spill-single-def "dup spill"
-;  V117 tmp111      [V117,T40] (  3,  5.93)     ref  ->  [rbp-0x1A0]  class-hnd "Inline stloc first use temp" <System.Array>
+;  V116 tmp110      [V116,T13] (  4, 23.60)   byref  ->  [rbp-0x198]  spill-single-def "dup spill"
+;  V117 tmp111      [V117,T41] (  3,  5.90)     ref  ->  [rbp-0x1A0]  class-hnd "Inline stloc first use temp" <System.Array>
 ;* V118 tmp112      [V118    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.Buffers.SharedArrayPoolThreadLocalArray>
-;  V119 tmp113      [V119,T96] (  2,  0   )     ref  ->  rax         class-hnd exact "dup spill" <System.Buffers.SharedArrayPoolPartitions>
-;  V120 tmp114      [V120,T84] (  4,  0   )     ref  ->  rax        
-;  V121 tmp115      [V121,T88] (  3,  0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
+;  V119 tmp113      [V119,T97] (  2,  0   )     ref  ->  rax         class-hnd exact "dup spill" <System.Buffers.SharedArrayPoolPartitions>
+;  V120 tmp114      [V120,T85] (  4,  0   )     ref  ->  rax        
+;  V121 tmp115      [V121,T89] (  3,  0   )     ref  ->  rbx         class-hnd exact "NewObj constructor temp" <<unknown class>>
 ;* V122 tmp116      [V122    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V123 tmp117      [V123    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
 ;* V124 tmp118      [V124    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V125 tmp119      [V125,T93] (  3,  0   )   ubyte  ->  rcx         "Inline return value spill temp"
-;  V126 tmp120      [V126,T82] (  5,  0   )     ref  ->  [rbp-0x1A8]  class-hnd exact spill-single-def "Inline stloc first use temp" <<unknown class>>
-;  V127 tmp121      [V127,T81] (  7,  0   )     int  ->  [rbp-0x16C]  "Inline stloc first use temp"
-;  V128 tmp122      [V128,T85] (  4,  0   )     int  ->  [rbp-0x170]  "Inline stloc first use temp"
-;  V129 tmp123      [V129,T105] (  2,  0   )     int  ->  rax         "dup spill"
+;  V125 tmp119      [V125,T94] (  3,  0   )   ubyte  ->  rcx         "Inline return value spill temp"
+;  V126 tmp120      [V126,T83] (  5,  0   )     ref  ->  [rbp-0x1A8]  class-hnd exact spill-single-def "Inline stloc first use temp" <<unknown class>>
+;  V127 tmp121      [V127,T82] (  7,  0   )     int  ->  [rbp-0x16C]  "Inline stloc first use temp"
+;  V128 tmp122      [V128,T86] (  4,  0   )     int  ->  [rbp-0x170]  "Inline stloc first use temp"
+;  V129 tmp123      [V129,T106] (  2,  0   )     int  ->  rax         "dup spill"
 ;* V130 tmp124      [V130    ] (  0,  0   )     int  ->  zero-ref    "Inline return value spill temp"
-;  V131 tmp125      [V131,T94] (  3,  0   )     int  ->  [rbp-0x174]  "Inline return value spill temp"
-;  V132 tmp126      [V132,T86] (  4,  0   )     int  ->  [rbp-0x178]  spill-single-def "dup spill"
+;  V131 tmp125      [V131,T95] (  3,  0   )     int  ->  [rbp-0x174]  "Inline return value spill temp"
+;  V132 tmp126      [V132,T87] (  4,  0   )     int  ->  [rbp-0x178]  spill-single-def "dup spill"
 ;* V133 tmp127      [V133    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V134 tmp128      [V134    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V135 tmp129      [V135,T95] (  3,  0   )   ubyte  ->  [rbp-0x17C]  "Inline stloc first use temp"
-;  V136 tmp130      [V136,T80] (  8,  0   )     ref  ->  [rbp-0x1B0]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
-;  V137 tmp131      [V137,T89] (  3,  0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V138 tmp132      [V138,T83] (  5,  0   )     int  ->  [rbp-0x180]  spill-single-def "Inline stloc first use temp"
-;  V139 tmp133      [V139,T106] (  2,  0   )     int  ->  rax         "Inlining Arg"
+;  V135 tmp129      [V135,T96] (  3,  0   )   ubyte  ->  [rbp-0x17C]  "Inline stloc first use temp"
+;  V136 tmp130      [V136,T81] (  8,  0   )     ref  ->  [rbp-0x1B0]  class-hnd exact spill-single-def "Inlining Arg" <System.Buffers.SharedArrayPoolPartitions+Partition>
+;  V137 tmp131      [V137,T90] (  3,  0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V138 tmp132      [V138,T84] (  5,  0   )     int  ->  [rbp-0x180]  spill-single-def "Inline stloc first use temp"
+;  V139 tmp133      [V139,T107] (  2,  0   )     int  ->  rax         "Inlining Arg"
 ;* V140 tmp134      [V140    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V07._reference (fldOffset=0x0)" P-INDEP
 ;* V141 tmp135      [V141    ] (  0,  0   )     int  ->  zero-ref    "field V07._length (fldOffset=0x8)" P-INDEP
-;* V142 tmp136      [V142,T66] (  0,  0   )   byref  ->  zero-ref    single-def "field V19._reference (fldOffset=0x0)" P-INDEP
-;* V143 tmp137      [V143,T67] (  0,  0   )     int  ->  zero-ref    "field V19._length (fldOffset=0x8)" P-INDEP
+;* V142 tmp136      [V142,T67] (  0,  0   )   byref  ->  zero-ref    single-def "field V19._reference (fldOffset=0x0)" P-INDEP
+;* V143 tmp137      [V143,T68] (  0,  0   )     int  ->  zero-ref    "field V19._length (fldOffset=0x8)" P-INDEP
 ;* V144 tmp138      [V144    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V145 tmp139      [V145    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
-;  V146 tmp140      [V146,T11] (  2,197.72)   byref  ->  rcx         "field V21._reference (fldOffset=0x0)" P-INDEP
-;  V147 tmp141      [V147,T10] (  2,200.72)     int  ->  rax         "field V21._length (fldOffset=0x8)" P-INDEP
+;  V146 tmp140      [V146,T11] (  2,199.14)   byref  ->  rcx         "field V21._reference (fldOffset=0x0)" P-INDEP
+;  V147 tmp141      [V147,T10] (  2,202.11)     int  ->  rax         "field V21._length (fldOffset=0x8)" P-INDEP
 ;* V148 tmp142      [V148    ] (  0,  0   )   byref  ->  zero-ref    "field V28._reference (fldOffset=0x0)" P-INDEP
 ;* V149 tmp143      [V149    ] (  0,  0   )     int  ->  zero-ref    "field V28._length (fldOffset=0x8)" P-INDEP
 ;* V150 tmp144      [V150    ] (  0,  0   )   byref  ->  zero-ref    "field V31._reference (fldOffset=0x0)" P-INDEP
 ;* V151 tmp145      [V151    ] (  0,  0   )     int  ->  zero-ref    "field V31._length (fldOffset=0x8)" P-INDEP
-;  V152 tmp146      [V152,T41] (  4,  4.00)   byref  ->  rbx         "field V32._reference (fldOffset=0x0)" P-INDEP
-;  V153 tmp147      [V153,T42] (  4,  4.00)     int  ->  rsi         "field V32._length (fldOffset=0x8)" P-INDEP
-;  V154 tmp148      [V154,T59] (  2,  2.00)   byref  ->  rbx         single-def "field V35._reference (fldOffset=0x0)" P-INDEP
-;  V155 tmp149      [V155,T61] (  2,  2.00)     int  ->  rsi         "field V35._length (fldOffset=0x8)" P-INDEP
+;  V152 tmp146      [V152,T43] (  4,  4.00)   byref  ->  rbx         "field V32._reference (fldOffset=0x0)" P-INDEP
+;  V153 tmp147      [V153,T44] (  4,  4.00)     int  ->  rsi         "field V32._length (fldOffset=0x8)" P-INDEP
+;  V154 tmp148      [V154,T60] (  2,  2.00)   byref  ->  rbx         single-def "field V35._reference (fldOffset=0x0)" P-INDEP
+;  V155 tmp149      [V155,T62] (  2,  2.00)     int  ->  rsi         "field V35._length (fldOffset=0x8)" P-INDEP
 ;* V156 tmp150      [V156    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V38._reference (fldOffset=0x0)" P-INDEP
 ;* V157 tmp151      [V157    ] (  0,  0   )     int  ->  zero-ref    "field V38._length (fldOffset=0x8)" P-INDEP
-;  V158 tmp152      [V158,T25] (  6,  8.99)   byref  ->  r14         "field V39._reference (fldOffset=0x0)" P-INDEP
-;  V159 tmp153      [V159,T26] (  6,  8.99)     int  ->  r15         "field V39._length (fldOffset=0x8)" P-INDEP
+;  V158 tmp152      [V158,T25] (  6,  8.91)   byref  ->  r14         "field V39._reference (fldOffset=0x0)" P-INDEP
+;  V159 tmp153      [V159,T26] (  6,  8.91)     int  ->  r15         "field V39._length (fldOffset=0x8)" P-INDEP
 ;* V160 tmp154      [V160    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V40._reference (fldOffset=0x0)" P-INDEP
 ;* V161 tmp155      [V161    ] (  0,  0   )     int  ->  zero-ref    "field V40._length (fldOffset=0x8)" P-INDEP
 ;* V162 tmp156      [V162    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V41._reference (fldOffset=0x0)" P-INDEP
 ;* V163 tmp157      [V163    ] (  0,  0   )     int  ->  zero-ref    "field V41._length (fldOffset=0x8)" P-INDEP
-;* V164 tmp158      [V164,T69] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
-;  V165 tmp159      [V165,T47] (  3,  3.99)     int  ->  rbx         "field V42._length (fldOffset=0x8)" P-INDEP
+;* V164 tmp158      [V164,T70] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
+;  V165 tmp159      [V165,T58] (  3,  2.66)     int  ->  rbx         "field V42._length (fldOffset=0x8)" P-INDEP
 ;* V166 tmp160      [V166    ] (  0,  0   )   byref  ->  zero-ref    "field V44._reference (fldOffset=0x0)" P-INDEP
 ;* V167 tmp161      [V167    ] (  0,  0   )     int  ->  zero-ref    "field V44._length (fldOffset=0x8)" P-INDEP
-;  V168 tmp162      [V168,T62] (  2,  2.00)   byref  ->  rdx         single-def "field V45._reference (fldOffset=0x0)" P-INDEP
-;  V169 tmp163      [V169,T43] (  5,  5.00)     int  ->  r14         "field V45._length (fldOffset=0x8)" P-INDEP
+;  V168 tmp162      [V168,T63] (  2,  2.00)   byref  ->  rdx         single-def "field V45._reference (fldOffset=0x0)" P-INDEP
+;  V169 tmp163      [V169,T42] (  5,  5.00)     int  ->  r14         "field V45._length (fldOffset=0x8)" P-INDEP
 ;* V170 tmp164      [V170    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V46._reference (fldOffset=0x0)" P-INDEP
 ;* V171 tmp165      [V171    ] (  0,  0   )     int  ->  zero-ref    "field V46._length (fldOffset=0x8)" P-INDEP
 ;* V172 tmp166      [V172    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V49._reference (fldOffset=0x0)" P-INDEP
 ;* V173 tmp167      [V173    ] (  0,  0   )     int  ->  zero-ref    "field V49._length (fldOffset=0x8)" P-INDEP
-;  V174 tmp168      [V174,T63] (  2,  2.00)   byref  ->  r14         single-def "field V54._reference (fldOffset=0x0)" P-INDEP
-;  V175 tmp169      [V175,T64] (  2,  2.00)     int  ->  r15         "field V54._length (fldOffset=0x8)" P-INDEP
-;* V176 tmp170      [V176,T70] (  0,  0   )   byref  ->  zero-ref    single-def "field V57._reference (fldOffset=0x0)" P-INDEP
+;  V174 tmp168      [V174,T64] (  2,  2.00)   byref  ->  r14         single-def "field V54._reference (fldOffset=0x0)" P-INDEP
+;  V175 tmp169      [V175,T65] (  2,  2.00)     int  ->  r15         "field V54._length (fldOffset=0x8)" P-INDEP
+;* V176 tmp170      [V176,T71] (  0,  0   )   byref  ->  zero-ref    single-def "field V57._reference (fldOffset=0x0)" P-INDEP
 ;* V177 tmp171      [V177    ] (  0,  0   )     int  ->  zero-ref    "field V57._length (fldOffset=0x8)" P-INDEP
-;* V178 tmp172      [V178,T71] (  0,  0   )   byref  ->  zero-ref    single-def "field V58._reference (fldOffset=0x0)" P-INDEP
-;  V179 tmp173      [V179,T65] (  2,  2.00)     int  ->  rbx         "field V58._length (fldOffset=0x8)" P-INDEP
-;  V180 tmp174      [V180,T48] (  3,  3.99)   byref  ->  rdx         "field V61._reference (fldOffset=0x0)" P-INDEP
-;  V181 tmp175      [V181,T24] (  6,  9.98)     int  ->  r12         "field V61._length (fldOffset=0x8)" P-INDEP
+;* V178 tmp172      [V178,T72] (  0,  0   )   byref  ->  zero-ref    single-def "field V58._reference (fldOffset=0x0)" P-INDEP
+;  V179 tmp173      [V179,T66] (  2,  2.00)     int  ->  rbx         "field V58._length (fldOffset=0x8)" P-INDEP
+;  V180 tmp174      [V180,T48] (  3,  3.94)   byref  ->  rdx         "field V61._reference (fldOffset=0x0)" P-INDEP
+;  V181 tmp175      [V181,T24] (  6,  9.85)     int  ->  r12         "field V61._length (fldOffset=0x8)" P-INDEP
 ;* V182 tmp176      [V182    ] (  0,  0   )   byref  ->  zero-ref    "field V62._reference (fldOffset=0x0)" P-INDEP
 ;* V183 tmp177      [V183    ] (  0,  0   )     int  ->  zero-ref    "field V62._length (fldOffset=0x8)" P-INDEP
-;  V184 tmp178      [V184,T49] (  2,  3.99)   byref  ->  r14         "field V67._reference (fldOffset=0x0)" P-INDEP
-;  V185 tmp179      [V185,T50] (  2,  3.99)     int  ->  r15         "field V67._length (fldOffset=0x8)" P-INDEP
-;  V186 tmp180      [V186,T60] (  2,  2.00)   byref  ->  rdx         single-def "field V71._reference (fldOffset=0x0)" P-INDEP
+;  V184 tmp178      [V184,T49] (  2,  3.94)   byref  ->  r14         "field V67._reference (fldOffset=0x0)" P-INDEP
+;  V185 tmp179      [V185,T50] (  2,  3.94)     int  ->  r15         "field V67._length (fldOffset=0x8)" P-INDEP
+;  V186 tmp180      [V186,T61] (  2,  2.00)   byref  ->  rdx         single-def "field V71._reference (fldOffset=0x0)" P-INDEP
 ;* V187 tmp181      [V187    ] (  0,  0   )     int  ->  zero-ref    "field V71._length (fldOffset=0x8)" P-INDEP
 ;* V188 tmp182      [V188    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V73._reference (fldOffset=0x0)" P-INDEP
 ;* V189 tmp183      [V189    ] (  0,  0   )     int  ->  zero-ref    "field V73._length (fldOffset=0x8)" P-INDEP
-;* V190 tmp184      [V190,T73] (  0,  0   )   byref  ->  zero-ref    single-def "field V78._reference (fldOffset=0x0)" P-INDEP
-;* V191 tmp185      [V191,T76] (  0,  0   )     int  ->  zero-ref    "field V78._length (fldOffset=0x8)" P-INDEP
-;* V192 tmp186      [V192,T74] (  0,  0   )   byref  ->  zero-ref    single-def "field V83._reference (fldOffset=0x0)" P-INDEP
-;* V193 tmp187      [V193,T77] (  0,  0   )     int  ->  zero-ref    "field V83._length (fldOffset=0x8)" P-INDEP
+;* V190 tmp184      [V190,T74] (  0,  0   )   byref  ->  zero-ref    single-def "field V78._reference (fldOffset=0x0)" P-INDEP
+;* V191 tmp185      [V191,T77] (  0,  0   )     int  ->  zero-ref    "field V78._length (fldOffset=0x8)" P-INDEP
+;* V192 tmp186      [V192,T75] (  0,  0   )   byref  ->  zero-ref    single-def "field V83._reference (fldOffset=0x0)" P-INDEP
+;* V193 tmp187      [V193,T78] (  0,  0   )     int  ->  zero-ref    "field V83._length (fldOffset=0x8)" P-INDEP
 ;* V194 tmp188      [V194,T56] (  0,  0   )     ref  ->  zero-ref    "field V118.Array (fldOffset=0x0)" P-INDEP
 ;* V195 tmp189      [V195,T57] (  0,  0   )     int  ->  zero-ref    "field V118.MillisecondsTimeStamp (fldOffset=0x8)" P-INDEP
-;  V196 tmp190      [V196,T01] (  3,602.17)     ref  ->  rdx         "arr expr"
-;  V197 tmp191      [V197,T02] (  3,602.17)     int  ->  rcx         "index expr"
-;  V198 tmp192      [V198,T90] (  3,  0   )     ref  ->  rcx         "arr expr"
-;  V199 tmp193      [V199,T97] (  2,  0   )     ref  ->  rsi         "argument with side effect"
-;  V200 tmp194      [V200,T98] (  2,  0   )     ref  ->   r8         "argument with side effect"
-;  V201 PSPSym      [V201,T68] (  1,  1   )    long  ->  [rbp-0x1C0]  do-not-enreg[V] "PSPSym"
-;  V202 cse0        [V202,T51] (  3,  3.00)     int  ->  rsi         "CSE #07: conservative"
-;  V203 cse1        [V203,T04] (  4,301.09)     int  ->  rcx         "CSE #03: aggressive"
-;  V204 cse2        [V204,T06] (  4,202.72)    long  ->  rdi         multi-def "CSE #01: aggressive"
-;  V205 cse3        [V205,T07] (  4,202.72)    long  ->  r14         multi-def "CSE #02: aggressive"
-;  V206 cse4        [V206,T38] (  2,  5.94)     int  ->  rcx         "CSE #14: moderate"
-;  V207 rat0        [V207,T27] (  5,  8.98)    long  ->  rsi         "Widened IV V43"
-;  V208 rat1        [V208,T14] (  6, 20.83)    long  ->  r13         "Widened IV V79"
-;  V209 rat2        [V209,T18] (  3, 11.87)   byref  ->  rax         "TLS field access"
-;  V210 rat3        [V210,T17] (  3, 17.81)    long  ->  rcx         "TLS access"
-;  V211 rat4        [V211,T16] (  3, 17.81)   byref  ->  rax         "ThreadStaticBlockBase access"
+;  V196 tmp190      [V196,T01] (  3,606.32)     ref  ->  rdx         "arr expr"
+;  V197 tmp191      [V197,T02] (  3,606.32)     int  ->  rcx         "index expr"
+;  V198 tmp192      [V198,T91] (  3,  0   )     ref  ->  rcx         "arr expr"
+;  V199 tmp193      [V199,T98] (  2,  0   )     ref  ->  rsi         "argument with side effect"
+;  V200 tmp194      [V200,T99] (  2,  0   )     ref  ->   r8         "argument with side effect"
+;  V201 PSPSym      [V201,T69] (  1,  1   )    long  ->  [rbp-0x1C0]  do-not-enreg[V] "PSPSym"
+;  V202 cse0        [V202,T51] (  3,  2.99)     int  ->  rsi         "CSE #07: conservative"
+;  V203 cse1        [V203,T04] (  4,303.16)     int  ->  rcx         "CSE #03: aggressive"
+;  V204 cse2        [V204,T06] (  4,204.11)    long  ->  rdi         multi-def "CSE #01: aggressive"
+;  V205 cse3        [V205,T07] (  4,204.11)    long  ->  r14         multi-def "CSE #02: aggressive"
+;  V206 cse4        [V206,T39] (  2,  5.91)     int  ->  rcx         "CSE #14: moderate"
+;  V207 rat0        [V207,T32] (  4,  6.58)    long  ->  rsi         "Strength reduced derived IV"
+;  V208 rat1        [V208,T33] (  4,  6.58)     int  ->  rbx         "Trip count IV"
+;  V209 rat2        [V209,T14] (  6, 20.74)    long  ->  r13         "Widened IV V79"
+;  V210 rat3        [V210,T18] (  3, 11.81)   byref  ->  rax         "TLS field access"
+;  V211 rat4        [V211,T17] (  3, 17.72)    long  ->  rcx         "TLS access"
+;  V212 rat5        [V212,T16] (  3, 17.72)   byref  ->  rax         "ThreadStaticBlockBase access"
 ;
 ; Lcl frame size = 440
 
@@ -663,7 +664,7 @@ G_M45160_IG02:
        mov      rcx, gword ptr [rcx+0x18]
        mov      r11, 0xD1FFAB1E      ; System.Linq.Tests.LinqTestData+IEnumerableWrapper`1[int]
        cmp      qword ptr [rcx], r11
-       jne      G_M45160_IG38
+       jne      G_M45160_IG42
        mov      rcx, gword ptr [rcx+0x08]
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
@@ -681,7 +682,7 @@ G_M45160_IG04:
        inc      ecx
        cmp      ecx, dword ptr [rsi+0x0C]
        jae      SHORT G_M45160_IG08
-						;; size=32 bbWeight=101.36 PerfScore 988.28
+						;; size=32 bbWeight=102.05 PerfScore 995.02
 G_M45160_IG05:
        mov      dword ptr [rsi+0x08], ecx
        mov      ecx, dword ptr [rsi+0x08]
@@ -695,14 +696,14 @@ G_M45160_IG05:
        cmp      qword ptr [rbx+0x18], rcx
        jne      SHORT G_M45160_IG12
        inc      edx
-						;; size=46 bbWeight=100.36 PerfScore 1957.06
+						;; size=46 bbWeight=101.05 PerfScore 1970.54
 G_M45160_IG06:
        mov      rcx, bword ptr [rbp-0x68]
        mov      eax, dword ptr [rbp-0x60]
        mov      r8d, dword ptr [rbp-0x158]
        cmp      r8d, eax
        jae      SHORT G_M45160_IG09
-						;; size=19 bbWeight=100.36 PerfScore 426.54
+						;; size=19 bbWeight=101.05 PerfScore 429.48
 G_M45160_IG07:
        mov      eax, r8d
        mov      dword ptr [rcx+4*rax], edx
@@ -710,17 +711,17 @@ G_M45160_IG07:
        inc      ecx
        mov      dword ptr [rbp-0x158], ecx
        jmp      SHORT G_M45160_IG04
-						;; size=22 bbWeight=97.36 PerfScore 535.47
+						;; size=22 bbWeight=98.08 PerfScore 539.46
 G_M45160_IG08:
        mov      ecx, dword ptr [rsi+0x0C]
        mov      dword ptr [rsi+0x08], ecx
        jmp      SHORT G_M45160_IG14
-						;; size=8 bbWeight=1.00 PerfScore 5.01
+						;; size=8 bbWeight=1.01 PerfScore 5.07
 G_M45160_IG09:
        lea      rcx, [rbp-0x160]
        call     [<unknown method>]
        jmp      G_M45160_IG04
-						;; size=18 bbWeight=3.00 PerfScore 16.52
+						;; size=18 bbWeight=2.97 PerfScore 16.33
 G_M45160_IG10:
        call     [System.ThrowHelper:ThrowInvalidOperationException_EnumCurrent(int)]
        int3     
@@ -730,7 +731,7 @@ G_M45160_IG11:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        test     eax, eax
-       je       G_M45160_IG39
+       je       G_M45160_IG43
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
@@ -749,15 +750,17 @@ G_M45160_IG13:
 G_M45160_IG14:
        mov      esi, dword ptr [rbp-0x15C]
        add      esi, dword ptr [rbp-0x158]
-       jo       G_M45160_IG64
+       jo       G_M45160_IG68
        mov      ebx, esi
        test     ebx, ebx
-       je       G_M45160_IG44
+       je       G_M45160_IG48
+						;; size=28 bbWeight=1.00 PerfScore 5.50
+G_M45160_IG15:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.List`1[int]
        call     CORINFO_HELP_NEWSFAST
        mov      rdi, rax
        test     ebx, ebx
-       jl       G_M45160_IG43
+       jl       G_M45160_IG47
        movsxd   rdx, ebx
        mov      rcx, 0xD1FFAB1E      ; int[]
        call     CORINFO_HELP_NEWARR_1_VC
@@ -767,27 +770,27 @@ G_M45160_IG14:
        inc      dword ptr [rdi+0x14]
        mov      r8, gword ptr [rdi+0x08]
        cmp      dword ptr [r8+0x08], ebx
-       jl       G_M45160_IG33
-						;; size=101 bbWeight=1.00 PerfScore 20.50
-G_M45160_IG15:
+       jl       G_M45160_IG37
+						;; size=73 bbWeight=1.00 PerfScore 15.00
+G_M45160_IG16:
        mov      dword ptr [rdi+0x10], ebx
        mov      rbx, gword ptr [rdi+0x08]
        cmp      dword ptr [rbx+0x08], esi
-       jb       G_M45160_IG42
-						;; size=16 bbWeight=1.00 PerfScore 6.99
-G_M45160_IG16:
+       jb       G_M45160_IG46
+						;; size=16 bbWeight=0.99 PerfScore 6.95
+G_M45160_IG17:
        add      rbx, 16
        mov      r14, rbx
        mov      r15d, esi
        mov      r13d, dword ptr [rbp-0x160]
        test     r13d, r13d
-       je       G_M45160_IG21
+       je       G_M45160_IG24
 						;; size=26 bbWeight=1.00 PerfScore 3.00
-G_M45160_IG17:
+G_M45160_IG18:
        mov      rdx, bword ptr [rbp-0x78]
        mov      r14d, dword ptr [rbp-0x70]
        cmp      r14d, esi
-       ja       G_M45160_IG40
+       ja       G_M45160_IG44
        mov      r8d, r14d
        shl      r8, 2
        mov      rcx, rbx
@@ -798,27 +801,31 @@ G_M45160_IG17:
        mov      r14, r8
        mov      r15d, esi
        dec      r13d
-       je       SHORT G_M45160_IG21
+       je       SHORT G_M45160_IG24
        cmp      r13d, 27
-       ja       G_M45160_IG41
+       ja       G_M45160_IG45
        mov      ebx, r13d
-       xor      esi, esi
        test     ebx, ebx
-       jle      SHORT G_M45160_IG21
-						;; size=73 bbWeight=1.00 PerfScore 12.99
-G_M45160_IG18:
-       lea      r8, bword ptr [rbp-0x150]
-       mov      r13, gword ptr [r8+8*rsi]
-       test     r13, r13
-       jne      G_M45160_IG37
-						;; size=20 bbWeight=2.00 PerfScore 7.49
+       jle      SHORT G_M45160_IG24
+						;; size=71 bbWeight=1.00 PerfScore 12.74
 G_M45160_IG19:
+       xor      esi, esi
+						;; size=2 bbWeight=0.66 PerfScore 0.17
+G_M45160_IG20:
+       lea      r8, bword ptr [rbp-0x150]
+       mov      r13, gword ptr [r8+rsi]
+       test     r13, r13
+       jne      G_M45160_IG41
+						;; size=20 bbWeight=1.97 PerfScore 7.39
+G_M45160_IG21:
        xor      rdx, rdx
        xor      r12d, r12d
-						;; size=5 bbWeight=1.04 PerfScore 0.52
-G_M45160_IG20:
+						;; size=5 bbWeight=1.02 PerfScore 0.51
+G_M45160_IG22:
        cmp      r12d, r15d
-       ja       G_M45160_IG40
+       ja       G_M45160_IG44
+						;; size=9 bbWeight=1.97 PerfScore 2.46
+G_M45160_IG23:
        mov      r8d, r12d
        shl      r8, 2
        mov      rcx, r14
@@ -826,37 +833,40 @@ G_M45160_IG20:
        mov      r8d, r12d
        lea      r14, bword ptr [r14+4*r8]
        sub      r15d, r12d
-       inc      esi
-       cmp      esi, ebx
-       jl       SHORT G_M45160_IG18
-						;; size=41 bbWeight=2.00 PerfScore 15.47
-G_M45160_IG21:
+       add      rsi, 8
+       dec      ebx
+       jne      SHORT G_M45160_IG20
+						;; size=34 bbWeight=1.97 PerfScore 12.81
+G_M45160_IG24:
        mov      r8d, dword ptr [rbp-0x158]
        cmp      r8d, dword ptr [rbp-0x60]
-       ja       G_M45160_IG41
+       ja       G_M45160_IG45
+						;; size=17 bbWeight=1.00 PerfScore 4.00
+G_M45160_IG25:
        mov      rdx, bword ptr [rbp-0x68]
        cmp      r8d, r15d
-       ja       G_M45160_IG40
+       ja       G_M45160_IG44
+       mov      r8d, r8d
        shl      r8, 2
        mov      rcx, r14
        call     [<unknown method>]
-						;; size=43 bbWeight=1.00 PerfScore 10.00
-G_M45160_IG22:
+						;; size=29 bbWeight=1.00 PerfScore 6.25
+G_M45160_IG26:
        cmp      dword ptr [rbp-0x160], 0
-       je       G_M45160_IG31
+       je       G_M45160_IG35
 						;; size=13 bbWeight=1.00 PerfScore 3.00
-G_M45160_IG23:
+G_M45160_IG27:
        xor      r13d, r13d
 						;; size=3 bbWeight=1.00 PerfScore 0.25
-G_M45160_IG24:
+G_M45160_IG28:
        cmp      r13d, 27
-       jae      G_M45160_IG63
+       jae      G_M45160_IG67
        lea      rcx, bword ptr [rbp-0x150]
        mov      rbx, gword ptr [rcx+8*r13]
        test     rbx, rbx
-       je       G_M45160_IG31
-						;; size=30 bbWeight=3.97 PerfScore 19.83
-G_M45160_IG25:
+       je       G_M45160_IG35
+						;; size=30 bbWeight=3.94 PerfScore 19.72
+G_M45160_IG29:
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rsi, gword ptr [rcx]
        mov      ecx, dword ptr [rbx+0x08]
@@ -869,30 +879,30 @@ G_M45160_IG25:
        mov      rcx, qword ptr GS:[0x0058]
        mov      rcx, qword ptr [rcx+0x20]
        cmp      dword ptr [rcx+0x208], 5
-       jle      G_M45160_IG45
+       jle      G_M45160_IG49
        mov      rcx, gword ptr [rcx+0x210]
        mov      rax, bword ptr [rcx+0x28]
        test     rax, rax
-       je       G_M45160_IG45
-						;; size=83 bbWeight=2.97 PerfScore 58.61
-G_M45160_IG26:
+       je       G_M45160_IG49
+						;; size=83 bbWeight=2.95 PerfScore 58.32
+G_M45160_IG30:
        mov      r8, gword ptr [rax+0x10]
        test     r8, r8
-       je       G_M45160_IG46
-						;; size=13 bbWeight=2.97 PerfScore 9.64
-G_M45160_IG27:
+       je       G_M45160_IG50
+						;; size=13 bbWeight=2.95 PerfScore 9.60
+G_M45160_IG31:
        xor      r15d, r15d
        mov      r12d, 1
        mov      ecx, dword ptr [r8+0x08]
        cmp      ecx, r14d
-       jbe      SHORT G_M45160_IG29
-						;; size=18 bbWeight=2.97 PerfScore 11.13
-G_M45160_IG28:
+       jbe      SHORT G_M45160_IG33
+						;; size=18 bbWeight=2.95 PerfScore 11.07
+G_M45160_IG32:
        mov      r15d, 1
        mov      ecx, 16
        shlx     ecx, ecx, r14d
        cmp      dword ptr [rbx+0x08], ecx
-       jne      G_M45160_IG59
+       jne      G_M45160_IG63
        mov      ecx, r14d
        shl      rcx, 4
        lea      rax, bword ptr [r8+rcx+0x10]
@@ -907,24 +917,24 @@ G_M45160_IG28:
        mov      dword ptr [rcx+0x08], eax
        mov      r8, gword ptr [rbp-0x1A0]
        test     r8, r8
-       jne      G_M45160_IG47
-						;; size=93 bbWeight=2.96 PerfScore 49.66
-G_M45160_IG29:
+       jne      G_M45160_IG51
+						;; size=93 bbWeight=2.95 PerfScore 49.41
+G_M45160_IG33:
        mov      rax, 0xD1FFAB1E      ; const ptr
        mov      r10, gword ptr [rax]
        mov      gword ptr [rbp-0x190], r10
        cmp      byte  ptr [r10+0x9D], 0
-       jne      G_M45160_IG60
-						;; size=34 bbWeight=2.97 PerfScore 21.52
-G_M45160_IG30:
+       jne      G_M45160_IG64
+						;; size=34 bbWeight=2.95 PerfScore 21.41
+G_M45160_IG34:
        inc      r13d
        cmp      r13d, 27
-       jl       G_M45160_IG24
-						;; size=13 bbWeight=3.97 PerfScore 5.95
-G_M45160_IG31:
+       jl       G_M45160_IG28
+						;; size=13 bbWeight=3.95 PerfScore 5.93
+G_M45160_IG35:
        mov      rax, rdi
 						;; size=3 bbWeight=1.00 PerfScore 0.25
-G_M45160_IG32:
+G_M45160_IG36:
        add      rsp, 440
        pop      rbx
        pop      rsi
@@ -936,15 +946,15 @@ G_M45160_IG32:
        pop      rbp
        ret      
 						;; size=20 bbWeight=1.00 PerfScore 5.25
-G_M45160_IG33:
+G_M45160_IG37:
        mov      rcx, gword ptr [rdi+0x08]
        cmp      dword ptr [rcx+0x08], 0
-       jne      SHORT G_M45160_IG36
-						;; size=10 bbWeight=0.00 PerfScore 0.01
-G_M45160_IG34:
+       jne      SHORT G_M45160_IG40
+						;; size=10 bbWeight=0.00 PerfScore 0.03
+G_M45160_IG38:
        mov      edx, 4
 						;; size=5 bbWeight=0.00 PerfScore 0.00
-G_M45160_IG35:
+G_M45160_IG39:
        mov      ecx, 0xD1FFAB1E
        cmp      edx, 0xD1FFAB1E
        cmova    edx, ecx
@@ -952,82 +962,82 @@ G_M45160_IG35:
        cmovl    edx, ebx
        mov      rcx, rdi
        call     [System.Collections.Generic.List`1[int]:set_Capacity(int):this]
-       jmp      G_M45160_IG15
-						;; size=33 bbWeight=0.00 PerfScore 0.01
-G_M45160_IG36:
+       jmp      G_M45160_IG16
+						;; size=33 bbWeight=0.00 PerfScore 0.03
+G_M45160_IG40:
        mov      rdx, gword ptr [rdi+0x08]
        mov      edx, dword ptr [rdx+0x08]
        add      edx, edx
-       jmp      SHORT G_M45160_IG35
-						;; size=11 bbWeight=0.00 PerfScore 0.00
-G_M45160_IG37:
+       jmp      SHORT G_M45160_IG39
+						;; size=11 bbWeight=0.00 PerfScore 0.01
+G_M45160_IG41:
        lea      rdx, bword ptr [r13+0x10]
        mov      r12d, dword ptr [r13+0x08]
-       jmp      G_M45160_IG20
-						;; size=13 bbWeight=0.96 PerfScore 4.31
-G_M45160_IG38:
+       jmp      G_M45160_IG22
+						;; size=13 bbWeight=0.95 PerfScore 4.26
+G_M45160_IG42:
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        mov      rsi, rax
        jmp      G_M45160_IG03
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M45160_IG39:
+G_M45160_IG43:
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
        jmp      G_M45160_IG14
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M45160_IG40:
+G_M45160_IG44:
        call     [System.ThrowHelper:ThrowArgumentException_DestinationTooShort()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M45160_IG41:
+G_M45160_IG45:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M45160_IG42:
+G_M45160_IG46:
        call     [System.ThrowHelper:ThrowInvalidOperationException_ConcurrentOperationsNotSupported()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M45160_IG43:
+G_M45160_IG47:
        mov      ecx, 22
        mov      edx, 13
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int,int)]
        int3     
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M45160_IG44:
+G_M45160_IG48:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.Generic.List`1[int]
        call     CORINFO_HELP_NEWSFAST
        mov      rdi, rax
        mov      rcx, rdi
        call     [System.Collections.Generic.List`1[int]:.ctor():this]
-       jmp      G_M45160_IG22
+       jmp      G_M45160_IG26
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M45160_IG45:
+G_M45160_IG49:
        mov      ecx, 5
        call     CORINFO_HELP_GETDYNAMIC_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
-       jmp      G_M45160_IG26
+       jmp      G_M45160_IG30
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M45160_IG46:
+G_M45160_IG50:
        mov      rcx, rsi
        call     [System.Buffers.SharedArrayPool`1[int]:InitializeTlsBucketsAndTrimming():System.Buffers.SharedArrayPoolThreadLocalArray[]:this]
        mov      r8, rax
-       jmp      G_M45160_IG27
+       jmp      G_M45160_IG31
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M45160_IG47:
+G_M45160_IG51:
        mov      r12, r8
        mov      rcx, gword ptr [rsi+0x10]
        cmp      r14d, dword ptr [rcx+0x08]
-       jae      G_M45160_IG63
+       jae      G_M45160_IG67
        mov      edx, r14d
        mov      rax, gword ptr [rcx+8*rdx+0x10]
        test     rax, rax
-       jne      SHORT G_M45160_IG48
+       jne      SHORT G_M45160_IG52
        mov      rcx, rsi
        mov      edx, r14d
        call     [System.Buffers.SharedArrayPool`1[int]:CreatePerCorePartitions(int):System.Buffers.SharedArrayPoolPartitions:this]
 						;; size=42 bbWeight=0 PerfScore 0.00
-G_M45160_IG48:
+G_M45160_IG52:
        mov      rax, gword ptr [rax+0x08]
        mov      gword ptr [rbp-0x1A8], rax
        mov      ecx, 76
@@ -1041,18 +1051,18 @@ G_M45160_IG48:
        mov      dword ptr [rax+0x10], edx
        movzx    rax, cx
        test     eax, eax
-       jne      SHORT G_M45160_IG49
+       jne      SHORT G_M45160_IG53
        call     [System.Threading.ProcessorIdCache:RefreshCurrentProcessorId():int]
        mov      edx, eax
        mov      dword ptr [rbp-0x174], edx
-       jmp      SHORT G_M45160_IG50
+       jmp      SHORT G_M45160_IG54
 						;; size=75 bbWeight=0 PerfScore 0.00
-G_M45160_IG49:
+G_M45160_IG53:
        mov      edx, ecx
        sar      edx, 16
        mov      dword ptr [rbp-0x174], edx
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M45160_IG50:
+G_M45160_IG54:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_GET_NONGCSTATIC_BASE
        mov      eax, dword ptr [rbp-0x174]
@@ -1061,13 +1071,13 @@ G_M45160_IG50:
        mov      eax, edx
        xor      edx, edx
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M45160_IG51:
+G_M45160_IG55:
        mov      r8, gword ptr [rbp-0x1A8]
        mov      dword ptr [rbp-0x170], edx
        cmp      dword ptr [r8+0x08], edx
-       jle      G_M45160_IG57
+       jle      G_M45160_IG61
        cmp      eax, dword ptr [r8+0x08]
-       jae      G_M45160_IG63
+       jae      G_M45160_IG67
        mov      dword ptr [rbp-0x16C], eax
        mov      ecx, eax
        mov      r10, gword ptr [r8+8*rcx+0x10]
@@ -1082,13 +1092,13 @@ G_M45160_IG51:
        mov      r8d, dword ptr [rax+0x10]
        mov      dword ptr [rbp-0x180], r8d
        cmp      dword ptr [rcx+0x08], r8d
-       jbe      SHORT G_M45160_IG53
+       jbe      SHORT G_M45160_IG57
        test     r8d, r8d
-       jne      SHORT G_M45160_IG54
+       jne      SHORT G_M45160_IG58
        xor      edx, edx
        mov      dword ptr [rax+0x14], edx
 						;; size=112 bbWeight=0 PerfScore 0.00
-G_M45160_IG52:
+G_M45160_IG56:
        movsxd   rdx, r8d
        lea      rcx, bword ptr [rcx+8*rdx+0x10]
        mov      rdx, r12
@@ -1099,40 +1109,40 @@ G_M45160_IG52:
        mov      dword ptr [rax+0x10], ecx
        mov      dword ptr [rbp-0x17C], 1
 						;; size=44 bbWeight=0 PerfScore 0.00
-G_M45160_IG53:
+G_M45160_IG57:
        mov      rcx, rax
        call     <unknown method>
        cmp      dword ptr [rbp-0x17C], 0
-       je       SHORT G_M45160_IG55
+       je       SHORT G_M45160_IG59
        mov      ecx, 1
-       jmp      SHORT G_M45160_IG58
+       jmp      SHORT G_M45160_IG62
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M45160_IG54:
-       jmp      SHORT G_M45160_IG52
+G_M45160_IG58:
+       jmp      SHORT G_M45160_IG56
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M45160_IG55:
+G_M45160_IG59:
        mov      eax, dword ptr [rbp-0x16C]
        inc      eax
        mov      ecx, eax
        mov      r8, gword ptr [rbp-0x1A8]
        cmp      dword ptr [r8+0x08], ecx
-       jne      SHORT G_M45160_IG56
+       jne      SHORT G_M45160_IG60
        xor      ecx, ecx
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M45160_IG56:
+G_M45160_IG60:
        mov      edx, dword ptr [rbp-0x170]
        inc      edx
        mov      eax, ecx
-       jmp      G_M45160_IG51
+       jmp      G_M45160_IG55
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M45160_IG57:
+G_M45160_IG61:
        xor      ecx, ecx
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M45160_IG58:
+G_M45160_IG62:
        mov      r12d, ecx
-       jmp      G_M45160_IG29
+       jmp      G_M45160_IG33
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M45160_IG59:
+G_M45160_IG63:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        call     CORINFO_HELP_NEWSFAST
        mov      rbx, rax
@@ -1149,9 +1159,9 @@ G_M45160_IG59:
        call     CORINFO_HELP_THROW
        int3     
 						;; size=71 bbWeight=0 PerfScore 0.00
-G_M45160_IG60:
+G_M45160_IG64:
        cmp      dword ptr [rbx+0x08], 0
-       je       G_M45160_IG30
+       je       G_M45160_IG34
        mov      rcx, rbx
        call     <unknown method>
        mov      dword ptr [rbp-0x164], eax
@@ -1166,7 +1176,7 @@ G_M45160_IG60:
        mov      edx, 3
        call     [<unknown method>]
        test     r15d, r12d
-       jne      G_M45160_IG30
+       jne      G_M45160_IG34
        mov      rcx, rbx
        call     <unknown method>
        mov      r12d, eax
@@ -1175,33 +1185,33 @@ G_M45160_IG60:
        call     <unknown method>
        mov      r9d, eax
        test     r15d, r15d
-       jne      SHORT G_M45160_IG61
+       jne      SHORT G_M45160_IG65
        mov      ecx, -1
        mov      edx, 1
-       jmp      SHORT G_M45160_IG62
+       jmp      SHORT G_M45160_IG66
 						;; size=128 bbWeight=0 PerfScore 0.00
-G_M45160_IG61:
+G_M45160_IG65:
        mov      ecx, r14d
        xor      edx, edx
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M45160_IG62:
+G_M45160_IG66:
        mov      dword ptr [rsp+0x20], ecx
        mov      dword ptr [rsp+0x28], edx
        mov      rcx, gword ptr [rbp-0x190]
        mov      edx, r12d
        mov      r8d, ebx
        call     [<unknown method>]
-       jmp      G_M45160_IG30
+       jmp      G_M45160_IG34
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M45160_IG63:
+G_M45160_IG67:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M45160_IG64:
+G_M45160_IG68:
        call     CORINFO_HELP_OVERFLOW
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M45160_IG65:
+G_M45160_IG69:
        push     rbp
        push     r15
        push     r14
@@ -1215,22 +1225,22 @@ G_M45160_IG65:
        mov      qword ptr [rsp+0x30], rbp
        lea      rbp, [rbp+0x1F0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M45160_IG66:
+G_M45160_IG70:
        cmp      gword ptr [rbp-0x188], 0
-       je       SHORT G_M45160_IG67
+       je       SHORT G_M45160_IG71
        mov      rsi, gword ptr [rbp-0x188]
        mov      rdi, qword ptr [rsi]
        mov      r14, 0xD1FFAB1E      ; System.SZGenericArrayEnumerator`1[int]
        cmp      rdi, r14
-       je       SHORT G_M45160_IG67
+       je       SHORT G_M45160_IG71
        mov      rcx, rsi
        mov      r11, 0xD1FFAB1E      ; code for <unknown method>
        call     [r11]<unknown method>
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M45160_IG67:
+G_M45160_IG71:
        nop      
 						;; size=1 bbWeight=0 PerfScore 0.00
-G_M45160_IG68:
+G_M45160_IG72:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -1243,6 +1253,6 @@ G_M45160_IG68:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1994, prolog size 84, PerfScore 4236.91, instruction count 478, allocated bytes for code 1994 (MethodHash=b3614f97) for method System.Linq.Enumerable+IEnumerableSelectIterator`2[int,int]:ToList():System.Collections.Generic.List`1[int]:this (Tier1)
+; Total bytes of code 1999, prolog size 84, PerfScore 4262.89, instruction count 479, allocated bytes for code 1999 (MethodHash=b3614f97) for method System.Linq.Enumerable+IEnumerableSelectIterator`2[int,int]:ToList():System.Collections.Generic.List`1[int]:this (Tier1)
 ; ============================================================
 


```

### ``[System.Private.CoreLib]SpanHelpers.Memmove(unsigned int8&,unsigned int8&,unsigned int)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 20170
+; with Dynamic PGO: fgCalledCount is 20800
 ; 0 inlinees with PGO data; 1 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
@@ -281,46 +281,31 @@ G_M10072_IG02:
        mov      rax, rcx
        sub      rax, rdx
        cmp      rax, r8
-       jb       G_M10072_IG16
+       jb       G_M10072_IG19
        mov      rax, rdx
        sub      rax, rcx
        cmp      rax, r8
-       jb       G_M10072_IG16
+       jb       G_M10072_IG19
        lea      rax, bword ptr [rdx+r8]
        lea      r10, bword ptr [rcx+r8]
        cmp      r8, 16
        jbe      G_M10072_IG13
-       cmp      r8, 64
-       ja       SHORT G_M10072_IG06
-						;; size=54 bbWeight=1 PerfScore 7.00
+						;; size=48 bbWeight=1 PerfScore 5.75
 G_M10072_IG03:
-       vmovups  xmm0, xmmword ptr [rdx]
-       vmovups  xmmword ptr [rcx], xmm0
-       cmp      r8, 32
-       jbe      SHORT G_M10072_IG10
-						;; size=14 bbWeight=0.75 PerfScore 5.44
+       cmp      r8, 64
+       jbe      SHORT G_M10072_IG08
+						;; size=6 bbWeight=1.00 PerfScore 1.25
 G_M10072_IG04:
-       vmovups  xmm0, xmmword ptr [rdx+0x10]
-       vmovups  xmmword ptr [rcx+0x10], xmm0
-       cmp      r8, 48
-       jbe      SHORT G_M10072_IG10
-						;; size=16 bbWeight=0.50 PerfScore 3.62
-G_M10072_IG05:
-       vmovups  xmm0, xmmword ptr [rdx+0x20]
-       vmovups  xmmword ptr [rcx+0x20], xmm0
-       jmp      SHORT G_M10072_IG10
-						;; size=12 bbWeight=0.25 PerfScore 2.00
-G_M10072_IG06:
        cmp      r8, 0x800
-       ja       G_M10072_IG17
+       ja       G_M10072_IG20
        cmp      r8, 256
-       jae      SHORT G_M10072_IG12
-						;; size=22 bbWeight=0.50 PerfScore 1.25
-G_M10072_IG07:
+       jae      G_M10072_IG17
+						;; size=26 bbWeight=0.50 PerfScore 1.25
+G_M10072_IG05:
        mov      r9, r8
        shr      r9, 6
 						;; size=7 bbWeight=0.50 PerfScore 0.37
-G_M10072_IG08:
+G_M10072_IG06:
        vmovdqu  ymm0, ymmword ptr [rdx]
        vmovdqu  ymmword ptr [rcx], ymm0
        vmovdqu  ymm0, ymmword ptr [rdx+0x20]
@@ -328,22 +313,60 @@ G_M10072_IG08:
        add      rcx, 64
        add      rdx, 64
        dec      r9
-       jne      SHORT G_M10072_IG08
-						;; size=31 bbWeight=1.00 PerfScore 15.72
-G_M10072_IG09:
+       jne      SHORT G_M10072_IG06
+						;; size=31 bbWeight=1.00 PerfScore 15.71
+G_M10072_IG07:
        and      r8, 63
        cmp      r8, 16
-       ja       SHORT G_M10072_IG03
+       jbe      SHORT G_M10072_IG11
 						;; size=10 bbWeight=0.50 PerfScore 0.75
+G_M10072_IG08:
+       vmovups  xmm0, xmmword ptr [rdx]
+       vmovups  xmmword ptr [rcx], xmm0
+       cmp      r8, 32
+       jbe      SHORT G_M10072_IG11
+						;; size=14 bbWeight=0.75 PerfScore 5.43
+G_M10072_IG09:
+       vmovups  xmm0, xmmword ptr [rdx+0x10]
+       vmovups  xmmword ptr [rcx+0x10], xmm0
+       cmp      r8, 48
+       jbe      SHORT G_M10072_IG11
+						;; size=16 bbWeight=0.50 PerfScore 3.62
 G_M10072_IG10:
+       vmovups  xmm0, xmmword ptr [rdx+0x20]
+       vmovups  xmmword ptr [rcx+0x20], xmm0
+						;; size=10 bbWeight=0.25 PerfScore 1.50
+G_M10072_IG11:
        vmovups  xmm0, xmmword ptr [rax-0x10]
        vmovups  xmmword ptr [r10-0x10], xmm0
 						;; size=11 bbWeight=0.75 PerfScore 4.50
-G_M10072_IG11:
+G_M10072_IG12:
        vzeroupper 
        ret      
 						;; size=4 bbWeight=1 PerfScore 2.00
-G_M10072_IG12:
+G_M10072_IG13:
+       test     r8b, 24
+       jne      SHORT G_M10072_IG16
+						;; size=6 bbWeight=0.00 PerfScore 0.00
+G_M10072_IG14:
+       test     r8b, 4
+       je       SHORT G_M10072_IG18
+						;; size=6 bbWeight=0.00 PerfScore 0.00
+G_M10072_IG15:
+       mov      edx, dword ptr [rdx]
+       mov      dword ptr [rcx], edx
+       mov      ecx, dword ptr [rax-0x04]
+       mov      dword ptr [r10-0x04], ecx
+       jmp      SHORT G_M10072_IG12
+						;; size=13 bbWeight=0.00 PerfScore 0.00
+G_M10072_IG16:
+       mov      r8, qword ptr [rdx]
+       mov      qword ptr [rcx], r8
+       mov      rax, qword ptr [rax-0x08]
+       mov      qword ptr [r10-0x08], rax
+       jmp      SHORT G_M10072_IG12
+						;; size=16 bbWeight=0.00 PerfScore 0.00
+G_M10072_IG17:
        mov      r9, rcx
        and      r9, 63
        neg      r9
@@ -355,52 +378,34 @@ G_M10072_IG12:
        add      rdx, r9
        add      rcx, r9
        sub      r8, r9
-       jmp      SHORT G_M10072_IG07
-						;; size=43 bbWeight=0 PerfScore 0.00
-G_M10072_IG13:
-       test     r8b, 24
-       jne      SHORT G_M10072_IG15
-       test     r8b, 4
-       jne      SHORT G_M10072_IG14
+       jmp      G_M10072_IG05
+						;; size=46 bbWeight=0 PerfScore 0.00
+G_M10072_IG18:
        test     r8, r8
-       je       SHORT G_M10072_IG11
+       je       SHORT G_M10072_IG12
        movzx    rdx, byte  ptr [rdx]
        mov      byte  ptr [rcx], dl
        test     r8b, 2
-       je       SHORT G_M10072_IG11
+       je       SHORT G_M10072_IG12
        movsx    rcx, word  ptr [rax-0x02]
        mov      word  ptr [r10-0x02], cx
-       jmp      SHORT G_M10072_IG11
-						;; size=40 bbWeight=0 PerfScore 0.00
-G_M10072_IG14:
-       mov      edx, dword ptr [rdx]
-       mov      dword ptr [rcx], edx
-       mov      ecx, dword ptr [rax-0x04]
-       mov      dword ptr [r10-0x04], ecx
-       jmp      SHORT G_M10072_IG11
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M10072_IG15:
-       mov      rdx, qword ptr [rdx]
-       mov      qword ptr [rcx], rdx
-       mov      rcx, qword ptr [rax-0x08]
-       mov      qword ptr [r10-0x08], rcx
-       jmp      SHORT G_M10072_IG11
-						;; size=16 bbWeight=0 PerfScore 0.00
-G_M10072_IG16:
+       jmp      SHORT G_M10072_IG12
+						;; size=28 bbWeight=0.00 PerfScore 0.00
+G_M10072_IG19:
        cmp      rcx, rdx
-       jne      SHORT G_M10072_IG17
+       jne      SHORT G_M10072_IG20
        cmp      byte  ptr [rdx], dl
-       jmp      SHORT G_M10072_IG11
+       jmp      SHORT G_M10072_IG12
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M10072_IG17:
+G_M10072_IG20:
        cmp      byte  ptr [rcx], cl
        cmp      byte  ptr [rdx], dl
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M10072_IG18:
+G_M10072_IG21:
        vzeroupper 
        tail.jmp [<unknown method>]
 						;; size=9 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 315, prolog size 0, PerfScore 42.66, instruction count 89, allocated bytes for code 315 (MethodHash=79d0d8a7) for method System.SpanHelpers:Memmove(byref,byref,ulong) (Tier1)
+; Total bytes of code 320, prolog size 0, PerfScore 42.14, instruction count 88, allocated bytes for code 320 (MethodHash=79d0d8a7) for method System.SpanHelpers:Memmove(byref,byref,ulong) (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Linq.Tests.Perf_OrderBy.OrderByCustomComparer(NumberOfPeople: 512)``

Hot functions:

- (49.81%) ``System.Collections.Generic.ArraySortHelper`1.PickPivotAndPartition`` (Tier-1)
  - No diffs
- (24.33%) ``System.Collections.Generic.ArraySortHelper`1.IntroSort`` (Tier-1)
  - No diffs
- (12.43%) ``ConsumerExtensions.Consume`` (Tier-1)
  - No diffs

# ``System.Collections.CtorFromCollection<Int32>.LinkedList(Size: 512)``

Hot functions:

- (48.87%) ``System.Collections.Generic.LinkedList`1..ctor`` (Tier-1)
  - No diffs

# ``System.Text.Json.Serialization.Tests.ReadJson<MyEventsListerViewModel>.DeserializeFromReader(Mode: Reflection)``

Hot functions:

- (11.82%) ``Utf8JsonReader.ReadSingleSegment`` (Tier-1)
  - No diffs
- (11.61%) ``IndexOfAnyAsciiSearcher.IndexOfAnyCore`` (Tier-1)
  - No diffs
- (10.26%) ``Utf8JsonReader.ConsumeNextToken`` (Tier-1)
  - No diffs
- (8.31%) ``JsonHelpers.TryParseDateTimeOffset`` (Tier-1)
  - No diffs
- (7.95%) ``System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1.OnTryRead`` (Tier-1)
  - **Has diffs**
- (6.05%) ``Utf8JsonReader.ConsumeValue`` (Tier-1)
  - No diffs
- (4.08%) ``System.Text.Json.Serialization.JsonCollectionConverter`2.OnTryRead`` (Tier-1)
  - **Has diffs**
- (4.05%) ``Utf8JsonReader.TryGetDateTimeOffsetCore`` (Tier-1)
  - No diffs
- (2.34%) ``JsonSerializer.GetReaderScopedToNextValue`` (Tier-1)
  - No diffs
- (1.95%) ``Utf8JsonReader.ConsumePropertyName`` (Tier-1)
  - No diffs
- (1.71%) ``System.Text.Json.Serialization.Metadata.JsonPropertyInfo`1.ReadJsonAndSetMember`` (Tier-1)
  - No diffs
- (1.40%) ``System.Text.Json.Serialization.Metadata.JsonPropertyInfo`1.ReadJsonAndSetMember`` (Tier-1)
  - No diffs
- (1.40%) ``JsonReaderHelper.TranscodeHelper`` (Tier-1)
  - No diffs
- (1.06%) ``Utf8JsonReader.EndObject`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Text.Json]System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon].OnTryRead(value class System.Text.Json.Utf8JsonReader&,class System.Type,class System.Text.Json.JsonSerializerOptions,value class System.Text.Json.ReadStack&,!0&)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 175264
+; with Dynamic PGO: fgCalledCount is 195936
 ; 38 inlinees with PGO data; 106 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T47] ( 12,  4.00)     ref  ->  [rsp+0x2C0]  this class-hnd single-def <System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]>
-;  V01 arg1         [V01,T00] ( 70, 79.03)   byref  ->  rbx         single-def
+;  V00 this         [V00,T47] ( 12,  4   )     ref  ->  [rsp+0x2B0]  this class-hnd single-def <System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]>
+;  V01 arg1         [V01,T00] ( 70, 75.99)   byref  ->  rbx         single-def
 ;* V02 arg2         [V02    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Type>
-;  V03 arg3         [V03,T57] (  7,  2   )     ref  ->  [rsp+0x2D8]  class-hnd single-def <System.Text.Json.JsonSerializerOptions>
-;  V04 arg4         [V04,T01] ( 80, 51.23)   byref  ->  rsi         single-def
-;  V05 arg5         [V05,T70] (  6,  1.00)   byref  ->  [rsp+0x2E8]  single-def
-;  V06 loc0         [V06,T20] ( 29, 11.96)     ref  ->  [rsp+0xD0]  class-hnd single-def <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
-;  V07 loc1         [V07,T46] ( 22,  6.41)     ref  ->  [rsp+0xC8]  class-hnd <System.Object>
-;  V08 loc2         [V08,T84] (  6,  0   )     ref  ->  r13         class-hnd single-def <System.Text.Json.Serialization.JsonConverter>
-;  V09 loc3         [V09,T118] (  3,  0   )   ubyte  ->  r15        
-;  V10 loc4         [V10    ] (  2,  0   )     ref  ->  [rsp+0x268]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.Object>
-;  V11 loc5         [V11,T83] (  7,  0   )     ref  ->  r12         class-hnd <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V03 arg3         [V03,T57] (  7,  2   )     ref  ->  [rsp+0x2C8]  class-hnd single-def <System.Text.Json.JsonSerializerOptions>
+;  V04 arg4         [V04,T01] ( 80, 51.64)   byref  ->  rsi         single-def
+;  V05 arg5         [V05,T70] (  6,  1   )   byref  ->  [rsp+0x2D8]  single-def
+;  V06 loc0         [V06,T19] ( 29, 12.00)     ref  ->  [rsp+0xC0]  class-hnd single-def <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
+;  V07 loc1         [V07,T46] ( 22,  6.56)     ref  ->  [rsp+0xB8]  class-hnd <System.Object>
+;  V08 loc2         [V08,T84] (  6,  0   )     ref  ->  r15         class-hnd single-def <System.Text.Json.Serialization.JsonConverter>
+;  V09 loc3         [V09,T118] (  3,  0   )   ubyte  ->  r14        
+;  V10 loc4         [V10    ] (  2,  0   )     ref  ->  [rsp+0x258]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.Object>
+;  V11 loc5         [V11,T83] (  7,  0   )     ref  ->  r13         class-hnd <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;* V12 loc6         [V12    ] (  0,  0   )  struct (16) zero-ref    <System.ReadOnlySpan`1[ubyte]>
 ;* V13 loc7         [V13,T150] (  0,  0   )   ubyte  ->  zero-ref    ld-addr-op
-;  V14 loc8         [V14    ] (  2,  0   )   ubyte  ->  [rsp+0x260]  do-not-enreg[X] addr-exposed ld-addr-op
+;  V14 loc8         [V14    ] (  2,  0   )   ubyte  ->  [rsp+0x250]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V15 OutArgs      [V15    ] (  1,  1   )  struct (48) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
 ;* V16 tmp1         [V16    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;  V17 tmp2         [V17,T87] (  4,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
@@ -1950,25 +1950,25 @@ G_M27315_IG70:
 ;  V28 tmp13        [V28,T151] (  2,  0   )     int  ->  rax        
 ;* V29 tmp14        [V29    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;  V30 tmp15        [V30,T63] (  4,  2   )     ref  ->  rcx         class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V31 tmp16        [V31,T58] (  4,  4.00)     ref  ->  r12         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
+;  V31 tmp16        [V31,T58] (  4,  4   )     ref  ->  r13         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
 ;* V32 tmp17        [V32    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;  V33 tmp18        [V33,T59] (  4,  4.00)     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
 ;* V34 tmp19        [V34    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V35 tmp20        [V35    ] (  0,  0   )   ubyte  ->  zero-ref    ld-addr-op "Inline ldloca(s) first use temp"
 ;* V36 tmp21        [V36    ] (  0,  0   )  struct (16) zero-ref    "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
-;  V37 tmp22        [V37,T41] (  3,  9.12)   ubyte  ->  [rsp+0x25C]  ld-addr-op "Inline ldloca(s) first use temp"
+;  V37 tmp22        [V37,T41] (  3,  9.31)   ubyte  ->  [rsp+0x24C]  ld-addr-op "Inline ldloca(s) first use temp"
 ;* V38 tmp23        [V38    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;* V39 tmp24        [V39    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
-;  V40 tmp25        [V40,T65] (  2,  2.00)   byref  ->  r12         single-def "Inlining Arg"
-;  V41 tmp26        [V41,T104] (  3,  0   )     ref  ->  [rsp+0xC0]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Collections.BitArray>
+;  V40 tmp25        [V40,T65] (  2,  2   )   byref  ->  r12         single-def "Inlining Arg"
+;  V41 tmp26        [V41,T104] (  3,  0   )     ref  ->  r13         class-hnd exact single-def "NewObj constructor temp" <System.Collections.BitArray>
 ;* V42 tmp27        [V42    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V43 tmp28        [V43,T21] (  3, 11.93)     int  ->  rax        
+;  V43 tmp28        [V43,T18] (  3, 12.00)     int  ->  rax        
 ;* V44 tmp29        [V44    ] (  0,  0   )     int  ->  zero-ref   
 ;* V45 tmp30        [V45    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V46 tmp31        [V46    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V47 tmp32        [V47    ] (  0,  0   )  struct (16) zero-ref    "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
-;  V48 tmp33        [V48,T120] (  3,  0   )  struct (16) [rsp+0x248]  do-not-enreg[HS] must-init hidden-struct-arg "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
-;  V49 tmp34        [V49    ] (  2,  0   )  struct (24) [rsp+0x230]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Buffers.ReadOnlySequence`1[ubyte]>
+;  V48 tmp33        [V48,T120] (  3,  0   )  struct (16) [rsp+0x238]  do-not-enreg[HS] must-init hidden-struct-arg "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
+;  V49 tmp34        [V49    ] (  2,  0   )  struct (24) [rsp+0x220]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Buffers.ReadOnlySequence`1[ubyte]>
 ;* V50 tmp35        [V50    ] (  0,  0   )  struct (16) zero-ref    <System.ReadOnlySpan`1[ubyte]>
 ;* V51 tmp36        [V51    ] (  0,  0   )  struct (16) zero-ref    "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V52 tmp37        [V52,T89] (  4,  0   )     ref  ->  rax         class-hnd "Inlining Arg" <ubyte[]>
@@ -1978,53 +1978,53 @@ G_M27315_IG70:
 ;* V56 tmp41        [V56    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver>
 ;* V57 tmp42        [V57    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.Json.JsonSerializerOptions>
 ;* V58 tmp43        [V58    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V59 tmp44        [V59,T23] (  7,  9.93)     ref  ->  [rsp+0xB8]  class-hnd spill-single-def "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
-;  V60 tmp45        [V60,T24] (  5,  9.93)     ref  ->  registers   ld-addr-op class-hnd "Inline ldloca(s) first use temp" <ubyte[]>
-;  V61 tmp46        [V61,T04] ( 12, 35.14)     ref  ->  rdi         class-hnd "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V62 tmp47        [V62,T05] (  3, 29.80)   byref  ->  rax         "dup spill"
+;  V59 tmp44        [V59,T22] (  7, 10.00)     ref  ->  [rsp+0xB0]  class-hnd spill-single-def "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
+;  V60 tmp45        [V60,T23] (  5, 10.00)     ref  ->  [rsp+0xA8]  ld-addr-op class-hnd "Inline ldloca(s) first use temp" <ubyte[]>
+;  V61 tmp46        [V61,T04] ( 12, 35.98)     ref  ->  rbp         class-hnd "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V62 tmp47        [V62,T05] (  3, 30.00)   byref  ->  rcx         "dup spill"
 ;* V63 tmp48        [V63    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
-;  V64 tmp49        [V64,T85] (  6,  0   )     ref  ->  rdi         class-hnd "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V64 tmp49        [V64,T85] (  6,  0   )     ref  ->  rbp         class-hnd "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;* V65 tmp50        [V65    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
 ;  V66 tmp51        [V66,T137] (  2,  0   )     ref  ->  rdx         class-hnd exact "Inline stloc first use temp" <System.String>
-;  V67 tmp52        [V67,T32] (  3,  9.93)     ref  ->  registers   class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V68 tmp53        [V68,T09] (  6, 19.86)     ref  ->  [rsp+0xB0]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.PropertyRef[]>
+;  V67 tmp52        [V67,T31] (  3, 10.00)     ref  ->  registers   class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V68 tmp53        [V68,T09] (  6, 20.00)     ref  ->  [rsp+0xA0]  class-hnd exact spill-single-def "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.PropertyRef[]>
 ;* V69 tmp54        [V69    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[System.Text.Json.Serialization.Metadata.PropertyRef]>
-;  V70 tmp55        [V70    ] ( 14, 59.59)  struct (16) [rsp+0x220]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
-;  V71 tmp56        [V71,T25] (  5,  9.93)    long  ->  r14         "Inline stloc first use temp"
-;  V72 tmp57        [V72    ] (  6,  4.97)     ref  ->  [rsp+0x218]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline ldloca(s) first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V73 tmp58        [V73,T10] (  3, 19.86)   byref  ->  [rsp+0xA8]  spill-single-def "Inlining Arg"
-;  V74 tmp59        [V74,T76] (  4,  0.00)   byref  ->  [rsp+0xA0]  spill-single-def "Inline stloc first use temp"
+;  V70 tmp55        [V70    ] ( 14, 59.99)  struct (16) [rsp+0x210]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
+;  V71 tmp56        [V71,T24] (  5, 10.00)    long  ->  rdi         "Inline stloc first use temp"
+;  V72 tmp57        [V72    ] (  6,  5.00)     ref  ->  [rsp+0x208]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd "Inline ldloca(s) first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V73 tmp58        [V73,T10] (  3, 20.00)   byref  ->  [rsp+0x98]  spill-single-def "Inlining Arg"
+;  V74 tmp59        [V74,T76] (  4,  0.00)   byref  ->  [rsp+0x90]  spill-single-def "Inline stloc first use temp"
 ;  V75 tmp60        [V75,T71] (  3,  0.00)     ref  ->  rcx         class-hnd "dup spill" <System.Object>
 ;* V76 tmp61        [V76    ] (  0,  0   )     ref  ->  zero-ref   
 ;  V77 tmp62        [V77,T79] (  4,  0.00)     int  ->  registers  
 ;  V78 tmp63        [V78,T72] (  2,  0.00)     ref  ->  rcx         class-hnd "dup spill" <System.Object>
 ;  V79 tmp64        [V79,T77] (  4,  0.00)     ref  ->  rcx        
 ;* V80 tmp65        [V80    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "NewObj constructor temp" <System.Text.Json.Serialization.Metadata.PropertyRef>
-;  V81 tmp66        [V81,T78] (  4,  0.00)     ref  ->  [rsp+0x98]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder>
+;  V81 tmp66        [V81,T78] (  4,  0.00)     ref  ->  [rsp+0x88]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder>
 ;* V82 tmp67        [V82    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder>
 ;* V83 tmp68        [V83    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ubyte]>
 ;* V84 tmp69        [V84    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ubyte]>
-;  V85 tmp70        [V85,T14] (  6, 16.30)     int  ->  rdi         "Inline stloc first use temp"
-;  V86 tmp71        [V86,T06] (  3, 27.00)     int  ->  rbp         "impAppendStmt"
-;  V87 tmp72        [V87,T07] (  7, 24.83)     int  ->  [rsp+0x214]  "Inline stloc first use temp"
-;  V88 tmp73        [V88,T54] (  9,  4.97)     int  ->  [rsp+0x210]  "Inline stloc first use temp"
+;  V85 tmp70        [V85,T14] (  6, 16.40)     int  ->  [rsp+0x204]  "Inline stloc first use temp"
+;  V86 tmp71        [V86,T06] (  3, 27.18)     int  ->  rbp         "impAppendStmt"
+;  V87 tmp72        [V87,T07] (  7, 25.00)     int  ->  [rsp+0x200]  "Inline stloc first use temp"
+;  V88 tmp73        [V88,T53] (  9,  5.00)     int  ->  [rsp+0x1FC]  "Inline stloc first use temp"
 ;* V89 tmp74        [V89    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.PropertyRef>
 ;* V90 tmp75        [V90    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[System.Text.Json.Serialization.Metadata.PropertyRef]>
 ;* V91 tmp76        [V91    ] (  0,  0   )    long  ->  zero-ref    "Inline return value spill temp"
 ;* V92 tmp77        [V92    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V93 tmp78        [V93    ] (  0,  0   )   byref  ->  zero-ref    "Inline stloc first use temp"
 ;* V94 tmp79        [V94    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V95 tmp80        [V95,T08] ( 18, 22.60)    long  ->  rdi         "Inline stloc first use temp"
-;  V96 tmp81        [V96,T56] (  3,  4.12)     int  ->  rbp         "Inline stloc first use temp"
+;  V95 tmp80        [V95,T08] ( 18, 22.74)    long  ->  rdi         "Inline stloc first use temp"
+;  V96 tmp81        [V96,T56] (  3,  4.20)     int  ->  rbp         "Inline stloc first use temp"
 ;* V97 tmp82        [V97    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
-;  V98 tmp83        [V98,T40] (  3,  9.93)     int  ->  rbp         "Inline return value spill temp"
-;  V99 tmp84        [V99,T51] (  2,  5.55)   ubyte  ->  rax         "Inline return value spill temp"
+;  V98 tmp83        [V98,T39] (  3, 10.00)     int  ->  rbp         "Inline return value spill temp"
+;  V99 tmp84        [V99,T51] (  2,  5.59)   ubyte  ->  rax         "Inline return value spill temp"
 ;* V100 tmp85       [V100    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V101 tmp86       [V101    ] (  0,  0   )  struct (16) zero-ref    "impAppendStmt" <System.ReadOnlySpan`1[ubyte]>
 ;* V102 tmp87       [V102    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ubyte]>
 ;* V103 tmp88       [V103    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <ubyte[]>
 ;* V104 tmp89       [V104    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V105 tmp90       [V105,T52] (  3,  5.55)   ubyte  ->  registers   "Inline return value spill temp"
+;  V105 tmp90       [V105,T52] (  3,  5.59)   ubyte  ->  registers   "Inline return value spill temp"
 ;* V106 tmp91       [V106    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V107 tmp92       [V107    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V108 tmp93       [V108    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
@@ -2070,8 +2070,8 @@ G_M27315_IG70:
 ;* V148 tmp133      [V148    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V149 tmp134      [V149    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
 ;* V150 tmp135      [V150    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.Json.JsonSerializerOptions>
-;  V151 tmp136      [V151,T138] (  2,  0   )     ref  ->   r9         class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V152 tmp137      [V152,T91] (  4,  0   )     ref  ->   r9         class-hnd "Inlining Arg" <ubyte[]>
+;  V151 tmp136      [V151,T138] (  2,  0   )     ref  ->  rdx         class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V152 tmp137      [V152,T91] (  4,  0   )     ref  ->  rdx         class-hnd "Inlining Arg" <ubyte[]>
 ;* V153 tmp138      [V153    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V154 tmp139      [V154,T123] (  2,  0   )   ubyte  ->  rax         "Inline return value spill temp"
 ;* V155 tmp140      [V155    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ubyte]>
@@ -2091,88 +2091,88 @@ G_M27315_IG70:
 ;* V169 tmp154      [V169    ] (  0,  0   )     int  ->  zero-ref    "guarded devirt return temp"
 ;* V170 tmp155      [V170    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
 ;* V171 tmp156      [V171    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V172 tmp157      [V172,T152] (  2,  0   )  struct (192) [rsp+0x150]  do-not-enreg[S] must-init "Inline stloc first use temp" <System.Text.Json.Utf8JsonReader>
+;  V172 tmp157      [V172,T152] (  2,  0   )  struct (192) [rsp+0x138]  do-not-enreg[S] must-init "Inline stloc first use temp" <System.Text.Json.Utf8JsonReader>
 ;  V173 tmp158      [V173,T153] (  2,  0   )     int  ->  rax         "dup spill"
 ;* V174 tmp159      [V174    ] (  0,  0   )     int  ->  zero-ref   
-;  V175 tmp160      [V175,T62] (  3,  2.40)   ubyte  ->  rcx         "Inline stloc first use temp"
+;  V175 tmp160      [V175,T62] (  3,  2.06)   ubyte  ->  rcx         "Inline stloc first use temp"
 ;* V176 tmp161      [V176    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V177 tmp162      [V177,T53] (  2,  5.47)     int  ->  r14         "Inline stloc first use temp"
-;  V178 tmp163      [V178,T67] (  3,  1.56)     int  ->  rax        
+;  V177 tmp162      [V177,T54] (  2,  4.68)     int  ->  rdi         "Inline stloc first use temp"
+;  V178 tmp163      [V178,T67] (  3,  1.34)     int  ->  rax        
 ;* V179 tmp164      [V179    ] (  0,  0   )     int  ->  zero-ref   
 ;* V180 tmp165      [V180    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V181 tmp166      [V181    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V182 tmp167      [V182,T22] (  3, 10.88)     int  ->  rax        
+;  V182 tmp167      [V182,T40] (  3,  9.31)     int  ->  rax        
 ;* V183 tmp168      [V183    ] (  0,  0   )     int  ->  zero-ref   
 ;* V184 tmp169      [V184    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V185 tmp170      [V185    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V186 tmp171      [V186    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Text.Json.BitStack>
-;  V187 tmp172      [V187,T16] (  3, 12.87)     int  ->  rdx         "Inline stloc first use temp"
-;  V188 tmp173      [V188,T15] (  3, 14.75)   ubyte  ->  rax         "Inline stloc first use temp"
+;  V187 tmp172      [V187,T20] (  3, 10.99)     int  ->  rdx         "Inline stloc first use temp"
+;  V188 tmp173      [V188,T17] (  3, 12.54)   ubyte  ->  rax         "Inline stloc first use temp"
 ;* V189 tmp174      [V189    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V190 tmp175      [V190,T43] (  3,  8.32)     int  ->  rax        
+;  V190 tmp175      [V190,T42] (  3,  8.61)     int  ->  rax        
 ;* V191 tmp176      [V191    ] (  0,  0   )     int  ->  zero-ref   
 ;* V192 tmp177      [V192    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V193 tmp178      [V193    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V194 tmp179      [V194,T02] (  5, 49.66)   byref  ->  rdx         "Inlining Arg"
-;  V195 tmp180      [V195,T64] (  3,  2.00)   byref  ->  rbx         single-def "Inlining Arg"
-;  V196 tmp181      [V196,T139] (  2,  0   )   byref  ->  r12         single-def "Inlining Arg"
-;  V197 tmp182      [V197,T106] (  3,  0   )     ref  ->  [rsp+0x90]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Collections.BitArray>
+;  V194 tmp179      [V194,T02] (  5, 49.99)   byref  ->  rdx         "Inlining Arg"
+;  V195 tmp180      [V195,T64] (  3,  2.00)   byref  ->  rbp         single-def "Inlining Arg"
+;  V196 tmp181      [V196,T139] (  2,  0   )   byref  ->  r13         single-def "Inlining Arg"
+;  V197 tmp182      [V197,T106] (  3,  0   )     ref  ->  r12         class-hnd exact single-def "NewObj constructor temp" <System.Collections.BitArray>
 ;* V198 tmp183      [V198    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V199 tmp184      [V199    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver>
 ;* V200 tmp185      [V200    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.Json.JsonSerializerOptions>
 ;* V201 tmp186      [V201    ] (  0,  0   )  struct (16) zero-ref    "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
-;  V202 tmp187      [V202,T86] (  6,  0   )  struct (16) [rsp+0x140]  do-not-enreg[HS] must-init hidden-struct-arg "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
-;  V203 tmp188      [V203    ] (  2,  0   )  struct (24) [rsp+0x128]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Buffers.ReadOnlySequence`1[ubyte]>
+;  V202 tmp187      [V202,T86] (  6,  0   )  struct (16) [rsp+0x128]  do-not-enreg[HS] must-init hidden-struct-arg "Inline return value spill temp" <System.ReadOnlySpan`1[ubyte]>
+;  V203 tmp188      [V203    ] (  2,  0   )  struct (24) [rsp+0x110]  do-not-enreg[XS] must-init addr-exposed ld-addr-op "Inline stloc first use temp" <System.Buffers.ReadOnlySequence`1[ubyte]>
 ;* V204 tmp189      [V204    ] (  0,  0   )  struct (16) zero-ref    <System.ReadOnlySpan`1[ubyte]>
 ;* V205 tmp190      [V205    ] (  0,  0   )  struct (16) zero-ref    "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V206 tmp191      [V206,T92] (  4,  0   )     ref  ->  rax         class-hnd "Inlining Arg" <ubyte[]>
 ;* V207 tmp192      [V207    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
 ;  V208 tmp193      [V208,T107] (  3,  0   )     ref  ->  rdx         class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;  V209 tmp194      [V209,T93] (  4,  0   )   byref  ->  rcx         "Inlining Arg"
-;  V210 tmp195      [V210,T108] (  3,  0   )   byref  ->  r12         single-def "Inlining Arg"
-;  V211 tmp196      [V211,T154] (  2,  0   )     int  ->  r15         "Single return block return value"
+;  V210 tmp195      [V210,T108] (  3,  0   )   byref  ->  r13         single-def "Inlining Arg"
+;  V211 tmp196      [V211,T154] (  2,  0   )     int  ->  r14         "Single return block return value"
 ;* V212 tmp197      [V212    ] (  0,  0   )   byref  ->  zero-ref    "field V12._reference (fldOffset=0x0)" P-INDEP
 ;* V213 tmp198      [V213    ] (  0,  0   )     int  ->  zero-ref    "field V12._length (fldOffset=0x8)" P-INDEP
-;  V214 tmp199      [V214,T26] (  4,  9.93)   byref  ->  r12         "field V36._reference (fldOffset=0x0)" P-INDEP
-;  V215 tmp200      [V215,T29] (  4,  9.93)     int  ->  [rsp+0x124]  spill-single-def "field V36._length (fldOffset=0x8)" P-INDEP
+;  V214 tmp199      [V214,T25] (  4, 10.00)   byref  ->  r12         "field V36._reference (fldOffset=0x0)" P-INDEP
+;  V215 tmp200      [V215,T28] (  4, 10.00)     int  ->  r13         "field V36._length (fldOffset=0x8)" P-INDEP
 ;  V216 tmp201      [V216,T140] (  2,  0   )   byref  ->   r9         "field V45._reference (fldOffset=0x0)" P-INDEP
 ;* V217 tmp202      [V217,T161] (  0,  0   )     int  ->  zero-ref    "field V45._length (fldOffset=0x8)" P-INDEP
-;  V218 tmp203      [V218,T27] (  4,  9.93)   byref  ->  r12         "field V47._reference (fldOffset=0x0)" P-INDEP
-;  V219 tmp204      [V219,T30] (  4,  9.93)     int  ->  [rsp+0x120]  spill-single-def "field V47._length (fldOffset=0x8)" P-INDEP
-;  V220 tmp205      [V220,T28] (  4,  9.93)   byref  ->  r12         "field V50._reference (fldOffset=0x0)" P-INDEP
-;  V221 tmp206      [V221,T31] (  4,  9.93)     int  ->  r10         "field V50._length (fldOffset=0x8)" P-INDEP
+;  V218 tmp203      [V218,T26] (  4, 10.00)   byref  ->  r12         "field V47._reference (fldOffset=0x0)" P-INDEP
+;  V219 tmp204      [V219,T29] (  4, 10.00)     int  ->  r13         "field V47._length (fldOffset=0x8)" P-INDEP
+;  V220 tmp205      [V220,T27] (  4, 10.00)   byref  ->  r12         "field V50._reference (fldOffset=0x0)" P-INDEP
+;  V221 tmp206      [V221,T30] (  4, 10.00)     int  ->  r13         "field V50._length (fldOffset=0x8)" P-INDEP
 ;* V222 tmp207      [V222    ] (  0,  0   )   byref  ->  zero-ref    "field V51._reference (fldOffset=0x0)" P-INDEP
 ;* V223 tmp208      [V223    ] (  0,  0   )     int  ->  zero-ref    "field V51._length (fldOffset=0x8)" P-INDEP
 ;  V224 tmp209      [V224,T109] (  3,  0   )   byref  ->  r12         "field V53._reference (fldOffset=0x0)" P-INDEP
-;  V225 tmp210      [V225,T124] (  3,  0   )     int  ->  r10         "field V53._length (fldOffset=0x8)" P-INDEP
-;  V226 tmp211      [V226,T37] (  4,  9.93)   byref  ->  [rsp+0x88]  spill-single-def "field V69._reference (fldOffset=0x0)" P-INDEP
-;  V227 tmp212      [V227,T11] (  4, 19.86)     int  ->  [rsp+0x11C]  spill-single-def "field V69._length (fldOffset=0x8)" P-INDEP
-;  V228 tmp213      [V228    ] (  8, 14.90)   byref  ->  [rsp+0x220]  do-not-enreg[X] addr-exposed "field V70._reference (fldOffset=0x0)" P-DEP
-;  V229 tmp214      [V229    ] (  8, 14.90)     int  ->  [rsp+0x228]  do-not-enreg[X] addr-exposed "field V70._length (fldOffset=0x8)" P-DEP
+;  V225 tmp210      [V225,T124] (  3,  0   )     int  ->  r13         "field V53._length (fldOffset=0x8)" P-INDEP
+;  V226 tmp211      [V226,T36] (  4, 10.00)   byref  ->  [rsp+0x80]  spill-single-def "field V69._reference (fldOffset=0x0)" P-INDEP
+;  V227 tmp212      [V227,T11] (  4, 20.00)     int  ->  [rsp+0x10C]  spill-single-def "field V69._length (fldOffset=0x8)" P-INDEP
+;  V228 tmp213      [V228    ] (  8, 15.00)   byref  ->  [rsp+0x210]  do-not-enreg[X] addr-exposed "field V70._reference (fldOffset=0x0)" P-DEP
+;  V229 tmp214      [V229    ] (  8, 15.00)     int  ->  [rsp+0x218]  do-not-enreg[X] addr-exposed "field V70._length (fldOffset=0x8)" P-DEP
 ;  V230 tmp215      [V230,T80] (  2,  0.00)     ref  ->  rdx         "field V80.Info (fldOffset=0x0)" P-INDEP
 ;* V231 tmp216      [V231,T82] (  0,  0   )     ref  ->  zero-ref    "field V80.Utf8PropertyName (fldOffset=0x8)" P-INDEP
-;  V232 tmp217      [V232,T81] (  2,  0.00)    long  ->  r14         "field V80.Key (fldOffset=0x10)" P-INDEP
+;  V232 tmp217      [V232,T81] (  2,  0.00)    long  ->  rdi         "field V80.Key (fldOffset=0x10)" P-INDEP
 ;  V233 tmp218      [V233,T141] (  2,  0   )   byref  ->  rcx         "field V83._reference (fldOffset=0x0)" P-INDEP
-;  V234 tmp219      [V234,T155] (  2,  0   )     int  ->  rax         "field V83._length (fldOffset=0x8)" P-INDEP
+;  V234 tmp219      [V234,T155] (  2,  0   )     int  ->   r8         "field V83._length (fldOffset=0x8)" P-INDEP
 ;* V235 tmp220      [V235    ] (  0,  0   )   byref  ->  zero-ref    "field V84._reference (fldOffset=0x0)" P-INDEP
 ;* V236 tmp221      [V236    ] (  0,  0   )     int  ->  zero-ref    "field V84._length (fldOffset=0x8)" P-INDEP
-;  V237 tmp222      [V237,T39] (  4,  9.93)     ref  ->  [rsp+0x80]  "field V89.Info (fldOffset=0x0)" P-INDEP
-;  V238 tmp223      [V238,T13] ( 13, 18.20)     ref  ->  [rsp+0x78]  "field V89.Utf8PropertyName (fldOffset=0x8)" P-INDEP
-;  V239 tmp224      [V239,T38] (  6,  9.93)    long  ->  [rsp+0x110]  "field V89.Key (fldOffset=0x10)" P-INDEP
-;  V240 tmp225      [V240,T33] (  3,  9.93)   byref  ->   r9         "field V90._reference (fldOffset=0x0)" P-INDEP
-;  V241 tmp226      [V241,T35] (  3,  9.93)     int  ->  r11         "field V90._length (fldOffset=0x8)" P-INDEP
-;  V242 tmp227      [V242,T19] ( 11, 12.48)   byref  ->  r14         "field V92._reference (fldOffset=0x0)" P-INDEP
-;  V243 tmp228      [V243,T12] (  5, 18.44)     int  ->  rbp         "field V92._length (fldOffset=0x8)" P-INDEP
+;  V237 tmp222      [V237,T38] (  4, 10.00)     ref  ->  [rsp+0x78]  "field V89.Info (fldOffset=0x0)" P-INDEP
+;  V238 tmp223      [V238,T13] ( 13, 18.33)     ref  ->  [rsp+0x70]  "field V89.Utf8PropertyName (fldOffset=0x8)" P-INDEP
+;  V239 tmp224      [V239,T37] (  6, 10.00)    long  ->  [rsp+0x100]  "field V89.Key (fldOffset=0x10)" P-INDEP
+;  V240 tmp225      [V240,T32] (  3, 10.00)   byref  ->  registers   "field V90._reference (fldOffset=0x0)" P-INDEP
+;  V241 tmp226      [V241,T34] (  3, 10.00)     int  ->  rcx         "field V90._length (fldOffset=0x8)" P-INDEP
+;  V242 tmp227      [V242,T16] ( 11, 12.56)   byref  ->  rcx         "field V92._reference (fldOffset=0x0)" P-INDEP
+;  V243 tmp228      [V243,T12] (  5, 18.61)     int  ->  rbp         "field V92._length (fldOffset=0x8)" P-INDEP
 ;* V244 tmp229      [V244    ] (  0,  0   )   byref  ->  zero-ref    "field V97._reference (fldOffset=0x0)" P-INDEP
 ;* V245 tmp230      [V245    ] (  0,  0   )     int  ->  zero-ref    "field V97._length (fldOffset=0x8)" P-INDEP
-;  V246 tmp231      [V246,T44] (  2,  7.74)   byref  ->  [rsp+0x70]  spill-single-def "field V100._reference (fldOffset=0x0)" P-INDEP
-;  V247 tmp232      [V247,T18] (  3, 12.71)     int  ->  r13         "field V100._length (fldOffset=0x8)" P-INDEP
+;  V246 tmp231      [V246,T44] (  2,  7.80)   byref  ->  [rsp+0x68]  spill-single-def "field V100._reference (fldOffset=0x0)" P-INDEP
+;  V247 tmp232      [V247,T15] (  3, 12.79)     int  ->  r15         "field V100._length (fldOffset=0x8)" P-INDEP
 ;* V248 tmp233      [V248    ] (  0,  0   )   byref  ->  zero-ref    "field V101._reference (fldOffset=0x0)" P-INDEP
 ;* V249 tmp234      [V249    ] (  0,  0   )     int  ->  zero-ref    "field V101._length (fldOffset=0x8)" P-INDEP
 ;* V250 tmp235      [V250    ] (  0,  0   )   byref  ->  zero-ref    "field V102._reference (fldOffset=0x0)" P-INDEP
 ;* V251 tmp236      [V251    ] (  0,  0   )     int  ->  zero-ref    "field V102._length (fldOffset=0x8)" P-INDEP
-;  V252 tmp237      [V252,T50] (  3,  5.55)   byref  ->  [rsp+0x68]  "field V104._reference (fldOffset=0x0)" P-INDEP
-;  V253 tmp238      [V253,T42] (  4,  8.32)     int  ->   r9         "field V104._length (fldOffset=0x8)" P-INDEP
+;  V252 tmp237      [V252,T50] (  3,  5.59)   byref  ->  [rsp+0x60]  "field V104._reference (fldOffset=0x0)" P-INDEP
+;  V253 tmp238      [V253,T43] (  4,  8.39)     int  ->   r8         "field V104._length (fldOffset=0x8)" P-INDEP
 ;* V254 tmp239      [V254    ] (  0,  0   )   byref  ->  zero-ref    "field V106._reference (fldOffset=0x0)" P-INDEP
 ;* V255 tmp240      [V255    ] (  0,  0   )     int  ->  zero-ref    "field V106._length (fldOffset=0x8)" P-INDEP
 ;* V256 tmp241      [V256    ] (  0,  0   )   byref  ->  zero-ref    "field V108._reference (fldOffset=0x0)" P-INDEP
@@ -2185,14 +2185,14 @@ G_M27315_IG70:
 ;* V263 tmp248      [V263    ] (  0,  0   )     int  ->  zero-ref    "field V114._length (fldOffset=0x8)" P-INDEP
 ;* V264 tmp249      [V264    ] (  0,  0   )   byref  ->  zero-ref    "field V115._reference (fldOffset=0x0)" P-INDEP
 ;* V265 tmp250      [V265    ] (  0,  0   )     int  ->  zero-ref    "field V115._length (fldOffset=0x8)" P-INDEP
-;  V266 tmp251      [V266,T142] (  2,  0   )   byref  ->  [rsp+0x60]  "field V117._reference (fldOffset=0x0)" P-INDEP
-;  V267 tmp252      [V267,T125] (  3,  0   )     int  ->  [rsp+0x10C]  "field V117._length (fldOffset=0x8)" P-INDEP
+;  V266 tmp251      [V266,T142] (  2,  0   )   byref  ->  [rsp+0x58]  "field V117._reference (fldOffset=0x0)" P-INDEP
+;  V267 tmp252      [V267,T125] (  3,  0   )     int  ->  [rsp+0xFC]  "field V117._length (fldOffset=0x8)" P-INDEP
 ;* V268 tmp253      [V268    ] (  0,  0   )   byref  ->  zero-ref    "field V118._reference (fldOffset=0x0)" P-INDEP
 ;* V269 tmp254      [V269    ] (  0,  0   )     int  ->  zero-ref    "field V118._length (fldOffset=0x8)" P-INDEP
 ;* V270 tmp255      [V270    ] (  0,  0   )   byref  ->  zero-ref    "field V119._reference (fldOffset=0x0)" P-INDEP
 ;* V271 tmp256      [V271    ] (  0,  0   )     int  ->  zero-ref    "field V119._length (fldOffset=0x8)" P-INDEP
-;  V272 tmp257      [V272,T110] (  3,  0   )   byref  ->  [rsp+0x58]  "field V121._reference (fldOffset=0x0)" P-INDEP
-;  V273 tmp258      [V273,T99] (  4,  0   )     int  ->  [rsp+0x108]  "field V121._length (fldOffset=0x8)" P-INDEP
+;  V272 tmp257      [V272,T110] (  3,  0   )   byref  ->  [rsp+0x50]  "field V121._reference (fldOffset=0x0)" P-INDEP
+;  V273 tmp258      [V273,T99] (  4,  0   )     int  ->  [rsp+0xF8]  "field V121._length (fldOffset=0x8)" P-INDEP
 ;* V274 tmp259      [V274    ] (  0,  0   )   byref  ->  zero-ref    "field V123._reference (fldOffset=0x0)" P-INDEP
 ;* V275 tmp260      [V275    ] (  0,  0   )     int  ->  zero-ref    "field V123._length (fldOffset=0x8)" P-INDEP
 ;* V276 tmp261      [V276    ] (  0,  0   )   byref  ->  zero-ref    "field V125._reference (fldOffset=0x0)" P-INDEP
@@ -2205,13 +2205,13 @@ G_M27315_IG70:
 ;* V283 tmp268      [V283    ] (  0,  0   )     int  ->  zero-ref    "field V131._length (fldOffset=0x8)" P-INDEP
 ;* V284 tmp269      [V284    ] (  0,  0   )   byref  ->  zero-ref    "field V132._reference (fldOffset=0x0)" P-INDEP
 ;* V285 tmp270      [V285    ] (  0,  0   )     int  ->  zero-ref    "field V132._length (fldOffset=0x8)" P-INDEP
-;  V286 tmp271      [V286,T143] (  2,  0   )   byref  ->  [rsp+0x50]  "field V134._reference (fldOffset=0x0)" P-INDEP
-;  V287 tmp272      [V287,T126] (  3,  0   )     int  ->  [rsp+0x104]  "field V134._length (fldOffset=0x8)" P-INDEP
+;  V286 tmp271      [V286,T143] (  2,  0   )   byref  ->  [rsp+0x48]  "field V134._reference (fldOffset=0x0)" P-INDEP
+;  V287 tmp272      [V287,T126] (  3,  0   )     int  ->  [rsp+0xF4]  "field V134._length (fldOffset=0x8)" P-INDEP
 ;* V288 tmp273      [V288    ] (  0,  0   )   byref  ->  zero-ref    "field V135._reference (fldOffset=0x0)" P-INDEP
 ;* V289 tmp274      [V289    ] (  0,  0   )     int  ->  zero-ref    "field V135._length (fldOffset=0x8)" P-INDEP
 ;* V290 tmp275      [V290    ] (  0,  0   )   byref  ->  zero-ref    "field V136._reference (fldOffset=0x0)" P-INDEP
 ;* V291 tmp276      [V291    ] (  0,  0   )     int  ->  zero-ref    "field V136._length (fldOffset=0x8)" P-INDEP
-;  V292 tmp277      [V292,T111] (  3,  0   )   byref  ->  [rsp+0x48]  "field V138._reference (fldOffset=0x0)" P-INDEP
+;  V292 tmp277      [V292,T111] (  3,  0   )   byref  ->  [rsp+0x40]  "field V138._reference (fldOffset=0x0)" P-INDEP
 ;  V293 tmp278      [V293,T100] (  4,  0   )     int  ->  rbp         "field V138._length (fldOffset=0x8)" P-INDEP
 ;* V294 tmp279      [V294    ] (  0,  0   )   byref  ->  zero-ref    "field V140._reference (fldOffset=0x0)" P-INDEP
 ;* V295 tmp280      [V295    ] (  0,  0   )     int  ->  zero-ref    "field V140._length (fldOffset=0x8)" P-INDEP
@@ -2225,8 +2225,8 @@ G_M27315_IG70:
 ;* V303 tmp288      [V303    ] (  0,  0   )     int  ->  zero-ref    "field V148._length (fldOffset=0x8)" P-INDEP
 ;* V304 tmp289      [V304    ] (  0,  0   )   byref  ->  zero-ref    "field V149._reference (fldOffset=0x0)" P-INDEP
 ;* V305 tmp290      [V305    ] (  0,  0   )     int  ->  zero-ref    "field V149._length (fldOffset=0x8)" P-INDEP
-;  V306 tmp291      [V306,T112] (  3,  0   )   byref  ->  r11         "field V153._reference (fldOffset=0x0)" P-INDEP
-;  V307 tmp292      [V307,T101] (  4,  0   )     int  ->   r9         "field V153._length (fldOffset=0x8)" P-INDEP
+;  V306 tmp291      [V306,T112] (  3,  0   )   byref  ->  rax         "field V153._reference (fldOffset=0x0)" P-INDEP
+;  V307 tmp292      [V307,T101] (  4,  0   )     int  ->  rdx         "field V153._length (fldOffset=0x8)" P-INDEP
 ;* V308 tmp293      [V308    ] (  0,  0   )   byref  ->  zero-ref    "field V155._reference (fldOffset=0x0)" P-INDEP
 ;* V309 tmp294      [V309    ] (  0,  0   )     int  ->  zero-ref    "field V155._length (fldOffset=0x8)" P-INDEP
 ;* V310 tmp295      [V310    ] (  0,  0   )   byref  ->  zero-ref    "field V157._reference (fldOffset=0x0)" P-INDEP
@@ -2245,27 +2245,27 @@ G_M27315_IG70:
 ;* V323 tmp308      [V323,T163] (  0,  0   )     int  ->  zero-ref    "field V184._length (fldOffset=0x8)" P-INDEP
 ;* V324 tmp309      [V324    ] (  0,  0   )     ref  ->  zero-ref    "field V186._array (fldOffset=0x0)" P-INDEP
 ;* V325 tmp310      [V325    ] (  0,  0   )    long  ->  zero-ref    "field V186._allocationFreeContainer (fldOffset=0x8)" P-INDEP
-;  V326 tmp311      [V326,T17] (  3, 12.87)     int  ->  rcx         "field V186._currentDepth (fldOffset=0x10)" P-INDEP
+;  V326 tmp311      [V326,T21] (  3, 10.99)     int  ->  rcx         "field V186._currentDepth (fldOffset=0x10)" P-INDEP
 ;  V327 tmp312      [V327,T146] (  2,  0   )   byref  ->   r9         "field V192._reference (fldOffset=0x0)" P-INDEP
 ;* V328 tmp313      [V328,T164] (  0,  0   )     int  ->  zero-ref    "field V192._length (fldOffset=0x8)" P-INDEP
 ;* V329 tmp314      [V329    ] (  0,  0   )   byref  ->  zero-ref    "field V201._reference (fldOffset=0x0)" P-INDEP
 ;* V330 tmp315      [V330    ] (  0,  0   )     int  ->  zero-ref    "field V201._length (fldOffset=0x8)" P-INDEP
-;  V331 tmp316      [V331,T94] (  4,  0   )   byref  ->  r12         "field V204._reference (fldOffset=0x0)" P-INDEP
-;  V332 tmp317      [V332,T102] (  4,  0   )     int  ->  rax         "field V204._length (fldOffset=0x8)" P-INDEP
+;  V331 tmp316      [V331,T94] (  4,  0   )   byref  ->  r13         "field V204._reference (fldOffset=0x0)" P-INDEP
+;  V332 tmp317      [V332,T102] (  4,  0   )     int  ->  r12         "field V204._length (fldOffset=0x8)" P-INDEP
 ;* V333 tmp318      [V333    ] (  0,  0   )   byref  ->  zero-ref    "field V205._reference (fldOffset=0x0)" P-INDEP
 ;* V334 tmp319      [V334    ] (  0,  0   )     int  ->  zero-ref    "field V205._length (fldOffset=0x8)" P-INDEP
-;  V335 tmp320      [V335,T113] (  3,  0   )   byref  ->  r12         "field V207._reference (fldOffset=0x0)" P-INDEP
-;  V336 tmp321      [V336,T127] (  3,  0   )     int  ->  rax         "field V207._length (fldOffset=0x8)" P-INDEP
-;  V337 tmp322      [V337,T34] (  3,  9.93)   byref  ->  r12         "V48.[000..008)"
-;  V338 tmp323      [V338,T36] (  3,  9.93)     int  ->  registers   "V48.[008..012)"
-;  V339 tmp324      [V339,T68] (  3,  1.04)     ref  ->  rcx         single-def "arr expr"
-;  V340 tmp325      [V340,T69] (  3,  1.04)     int  ->  rax         "index expr"
-;  V341 tmp326      [V341    ] ( 38,  0.00)  struct (16) [rsp+0xF0]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
-;  V342 tmp327      [V342,T75] (  2,  0.00)     ref  ->   r9         "argument with side effect"
-;  V343 tmp328      [V343    ] (  4,  0.00)  struct (24) [rsp+0xD8]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Text.Json.Serialization.Metadata.PropertyRef>
-;  V344 tmp329      [V344,T95] (  4,  0   )   byref  ->  [rsp+0x40]  spill-single-def "BlockOp address local"
-;  V345 tmp330      [V345,T03] (  4, 39.73)   byref  ->  r13         "BlockOp address local"
-;  V346 tmp331      [V346,T96] (  4,  0   )   byref  ->  [rsp+0x38]  spill-single-def "BlockOp address local"
+;  V335 tmp320      [V335,T113] (  3,  0   )   byref  ->  r13         "field V207._reference (fldOffset=0x0)" P-INDEP
+;  V336 tmp321      [V336,T127] (  3,  0   )     int  ->  r12         "field V207._length (fldOffset=0x8)" P-INDEP
+;  V337 tmp322      [V337,T33] (  3, 10.00)   byref  ->  r12         "V48.[000..008)"
+;  V338 tmp323      [V338,T35] (  3, 10.00)     int  ->  r13         "V48.[008..012)"
+;  V339 tmp324      [V339,T68] (  3,  1.02)     ref  ->  rcx         single-def "arr expr"
+;  V340 tmp325      [V340,T69] (  3,  1.02)     int  ->  rax         "index expr"
+;  V341 tmp326      [V341    ] ( 38,  0.00)  struct (16) [rsp+0xE0]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
+;  V342 tmp327      [V342,T75] (  2,  0.00)     ref  ->  rdx         "argument with side effect"
+;  V343 tmp328      [V343    ] (  4,  0.00)  struct (24) [rsp+0xC8]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.Text.Json.Serialization.Metadata.PropertyRef>
+;  V344 tmp329      [V344,T95] (  4,  0   )   byref  ->  [rsp+0x38]  spill-single-def "BlockOp address local"
+;  V345 tmp330      [V345,T03] (  4, 39.99)   byref  ->  r15         "BlockOp address local"
+;  V346 tmp331      [V346,T96] (  4,  0   )   byref  ->  [rsp+0x30]  spill-single-def "BlockOp address local"
 ;  V347 tmp332      [V347,T147] (  2,  0   )     ref  ->  rcx         "argument with side effect"
 ;  V348 tmp333      [V348,T148] (  2,  0   )     ref  ->  rcx         "argument with side effect"
 ;  V349 tmp334      [V349,T156] (  2,  0   )     int  ->  rdx         "argument with side effect"
@@ -2275,7 +2275,7 @@ G_M27315_IG70:
 ;  V353 tmp338      [V353,T159] (  2,  0   )    long  ->  rcx         "argument with side effect"
 ;  V354 tmp339      [V354,T149] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
 ;  V355 tmp340      [V355,T160] (  2,  0   )    long  ->  rcx         "argument with side effect"
-;  V356 rat0        [V356,T60] (  2,  3.00)    long  ->  rcx         "Spilling to split statement for tree"
+;  V356 rat0        [V356,T60] (  2,  3   )    long  ->  rcx         "Spilling to split statement for tree"
 ;  V357 rat1        [V357,T45] (  5,  7.50)     ref  ->  rdx         "replacement local"
 ;  V358 rat2        [V358,T61] (  3,  2.50)    long  ->  rcx         "CSE for expectedClsNode"
 ;* V359 rat3        [V359,T55] (  0,  0   )    long  ->  zero-ref    "Spilling to split statement for tree"
@@ -2295,7 +2295,7 @@ G_M27315_IG70:
 ;  V373 rat17       [V373,T116] (  3,  0   )   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;  V374 rat18       [V374,T117] (  3,  0   )     ref  ->  rax         "delegate invoke call"
 ;
-; Lcl frame size = 632
+; Lcl frame size = 616
 
 G_M27315_IG01:
        push     r15
@@ -2306,539 +2306,542 @@ G_M27315_IG01:
        push     rsi
        push     rbp
        push     rbx
-       sub      rsp, 632
+       sub      rsp, 616
        xor      eax, eax
-       mov      qword ptr [rsp+0xD8], rax
+       mov      qword ptr [rsp+0xC8], rax
        vxorps   xmm4, xmm4, xmm4
-       vmovdqa  xmmword ptr [rsp+0xE0], xmm4
+       vmovdqa  xmmword ptr [rsp+0xD0], xmm4
        mov      rax, -384
+       vmovdqa  xmmword ptr [rsp+rax+0x260], xmm4
        vmovdqa  xmmword ptr [rsp+rax+0x270], xmm4
        vmovdqa  xmmword ptr [rsp+rax+0x280], xmm4
-       vmovdqa  xmmword ptr [rsp+rax+0x290], xmm4
        add      rax, 48
        jne      SHORT  -5 instr
-       mov      qword ptr [rsp+0x270], rcx
-       mov      gword ptr [rsp+0x2D8], r9
+       mov      qword ptr [rsp+0x260], rcx
+       mov      gword ptr [rsp+0x2C8], r9
        mov      rdi, rcx
        mov      rbx, rdx
-       mov      rsi, bword ptr [rsp+0x2E0]
+       mov      rsi, bword ptr [rsp+0x2D0]
 						;; size=115 bbWeight=1 PerfScore 22.83
 G_M27315_IG02:
-       mov      r15, gword ptr [rsi+0x58]
+       mov      r14, gword ptr [rsi+0x58]
        cmp      byte  ptr [rsi+0x28], 0
-       mov      r14, bword ptr [rsp+0x2E8]
        jne      SHORT G_M27315_IG04
        cmp      byte  ptr [rsi+0x8B], 0
        jne      SHORT G_M27315_IG03
        cmp      byte  ptr [rbx+0x28], 1
        je       SHORT G_M27315_IG05
-       jmp      G_M27315_IG149
-						;; size=38 bbWeight=1 PerfScore 17.00
+       jmp      G_M27315_IG151
+						;; size=30 bbWeight=1 PerfScore 16.00
 G_M27315_IG03:
-       mov      rbp, gword ptr [rsp+0x2D8]
-       jmp      G_M27315_IG148
+       mov      rbp, gword ptr [rsp+0x2C8]
+       jmp      G_M27315_IG150
 						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG04:
-       mov      rbp, gword ptr [rsp+0x2D8]
-       jmp      G_M27315_IG148
+       mov      rbp, gword ptr [rsp+0x2C8]
+       jmp      G_M27315_IG150
 						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG05:
        cmp      byte  ptr [rsi+0x8F], 0
-       jne      G_M27315_IG25
+       jne      G_M27315_IG26
 						;; size=13 bbWeight=1 PerfScore 4.00
 G_M27315_IG06:
        xor      rcx, rcx
 						;; size=2 bbWeight=0.83 PerfScore 0.21
 G_M27315_IG07:
        test     rcx, rcx
-       jne      G_M27315_IG86
+       jne      G_M27315_IG87
 						;; size=9 bbWeight=1 PerfScore 1.25
 G_M27315_IG08:
-       cmp      gword ptr [r15+0x58], 0
-       je       G_M27315_IG87
+       cmp      gword ptr [r14+0x58], 0
+       je       G_M27315_IG88
 						;; size=11 bbWeight=1.00 PerfScore 4.00
 G_M27315_IG09:
-       mov      rax, gword ptr [r15+0x58]
+       mov      rax, gword ptr [r14+0x58]
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
-       mov      gword ptr [rsp+0xC8], rax
+       mov      gword ptr [rsp+0xB8], rax
 						;; size=19 bbWeight=1.00 PerfScore 7.99
 G_M27315_IG10:
-       mov      gword ptr [rsp+0x2C0], rdi
+       mov      gword ptr [rsp+0x2B0], rdi
        cmp      dword ptr [rdi], edi
-       mov      r12, gword ptr [r15+0x38]
-       test     r12, r12
-       jne      G_M27315_IG89
-						;; size=23 bbWeight=1.00 PerfScore 7.25
+       mov      r13, gword ptr [r14+0x38]
+       test     r13, r13
+       jne      G_M27315_IG90
+						;; size=23 bbWeight=1 PerfScore 7.25
 G_M27315_IG11:
        lea      r12, bword ptr [rsi+0x30]
-       cmp      dword ptr [r15+0x104], 0
+       cmp      dword ptr [r14+0x104], 0
        jle      SHORT G_M27315_IG16
-       jmp      G_M27315_IG90
-						;; size=19 bbWeight=1.00 PerfScore 6.50
+       jmp      G_M27315_IG91
+						;; size=19 bbWeight=1 PerfScore 6.50
 G_M27315_IG12:
-       mov      rcx, rdi
-       mov      rdx, gword ptr [rsp+0xC8]
+       mov      rcx, rbp
+       mov      rdx, gword ptr [rsp+0xB8]
        mov      r8, rsi
        mov      r9, rbx
-       mov      rax, qword ptr [rdi]
-       mov      rax, qword ptr [rax+0x48]
-       call     [rax+0x30]<unknown method>
-						;; size=27 bbWeight=2.00 PerfScore 17.46
+       call     [System.Text.Json.Serialization.Metadata.JsonPropertyInfo`1[System.__Canon]:ReadJsonAndSetMember(System.Object,byref,byref):ubyte:this]
+						;; size=23 bbWeight=1.94 PerfScore 9.21
 G_M27315_IG13:
        lea      rdx, bword ptr [rsi+0x30]
        xor      r8, r8
        mov      gword ptr [rdx], r8
-						;; size=10 bbWeight=4.97 PerfScore 8.69
+						;; size=10 bbWeight=5.00 PerfScore 8.75
 G_M27315_IG14:
        mov      gword ptr [rdx+0x08], r8
-						;; size=4 bbWeight=4.97 PerfScore 4.97
+						;; size=4 bbWeight=5.00 PerfScore 5.00
 G_M27315_IG15:
        mov      gword ptr [rdx+0x10], r8
        mov      byte  ptr [rdx+0x58], 0
-       mov      r14, bword ptr [rsp+0x2E8]
-						;; size=16 bbWeight=4.97 PerfScore 14.90
+						;; size=8 bbWeight=5.00 PerfScore 10.00
 G_M27315_IG16:
        cmp      byte  ptr [rbx+0x2B], 0
-       jne      G_M27315_IG91
+       jne      G_M27315_IG92
        mov      rcx, rbx
        call     [<unknown method>]
-						;; size=19 bbWeight=5.97 PerfScore 43.25
+						;; size=19 bbWeight=6.00 PerfScore 43.49
 G_M27315_IG17:
        test     eax, eax
-       je       G_M27315_IG26
-						;; size=8 bbWeight=5.97 PerfScore 7.46
+       je       G_M27315_IG27
+						;; size=8 bbWeight=6.00 PerfScore 7.50
 G_M27315_IG18:
        cmp      byte  ptr [rbx+0x28], 2
-       je       G_M27315_IG77
-						;; size=10 bbWeight=5.97 PerfScore 23.86
+       je       G_M27315_IG78
+						;; size=10 bbWeight=6.00 PerfScore 24.00
 G_M27315_IG19:
        cmp      byte  ptr [rbx+0x2D], 0
-       jne      G_M27315_IG93
+       jne      G_M27315_IG94
        mov      r12, bword ptr [rbx+0x98]
-       mov      r10d, dword ptr [rbx+0xA0]
-						;; size=24 bbWeight=4.97 PerfScore 39.73
+       mov      r13d, dword ptr [rbx+0xA0]
+						;; size=24 bbWeight=5.00 PerfScore 39.99
 G_M27315_IG20:
        cmp      byte  ptr [rbx+0x2E], 0
-       jne      G_M27315_IG98
-       mov      r9d, r10d
-						;; size=13 bbWeight=4.97 PerfScore 21.11
-G_M27315_IG21:
-       mov      r11d, r9d
-       mov      dword ptr [rsp+0x120], r11d
-       cmp      byte  ptr [rsi+0x8B], 0
        jne      G_M27315_IG99
-						;; size=24 bbWeight=4.97 PerfScore 26.07
+						;; size=10 bbWeight=5.00 PerfScore 20.00
+G_M27315_IG21:
+       cmp      byte  ptr [rsi+0x8B], 0
+       jne      G_M27315_IG100
+						;; size=13 bbWeight=5.00 PerfScore 20.00
 G_M27315_IG22:
-       mov      edx, r11d
-       mov      dword ptr [rsp+0x124], edx
-       cmp      byte  ptr [r15+0x113], 0
-       jne      G_M27315_IG144
-       mov      rcx, gword ptr [rsi+0x58]
-       mov      gword ptr [rsp+0xB8], rcx
-       xor      r8d, r8d
-       mov      dword ptr [rsp+0x25C], r8d
-       mov      bword ptr [rsp+0x220], r12
-       mov      dword ptr [rsp+0x228], edx
-       lea      rax, bword ptr [rsi+0x30]
-       mov      bword ptr [rsp+0xA8], rax
-       mov      r10, gword ptr [rcx+0x20]
+       cmp      byte  ptr [r14+0x113], 0
+       jne      G_M27315_IG146
+       mov      r10, gword ptr [rsi+0x58]
        mov      gword ptr [rsp+0xB0], r10
-       test     r10, r10
-       je       G_M27315_IG104
-       lea      r9, bword ptr [r10+0x10]
-       mov      r11d, dword ptr [r10+0x08]
-       mov      bword ptr [rsp+0x2E8], r14
-						;; size=111 bbWeight=4.97 PerfScore 103.05
+       xor      r9d, r9d
+       mov      dword ptr [rsp+0x24C], r9d
+       mov      bword ptr [rsp+0x210], r12
+       mov      dword ptr [rsp+0x218], r13d
+       lea      rax, bword ptr [rsi+0x30]
+       mov      bword ptr [rsp+0x98], rax
+       mov      r11, gword ptr [r10+0x20]
+       mov      gword ptr [rsp+0xA0], r11
+       test     r11, r11
+       je       G_M27315_IG105
+       lea      rdx, bword ptr [r11+0x10]
+       mov      ecx, dword ptr [r11+0x08]
+						;; size=94 bbWeight=5.00 PerfScore 92.48
 G_M27315_IG23:
-       mov      bword ptr [rsp+0x88], r9
-       mov      dword ptr [rsp+0x11C], r11d
-       mov      r14, bword ptr [rsp+0x220]
-       mov      ebp, dword ptr [rsp+0x228]
+       mov      r8, rdx
+       mov      bword ptr [rsp+0x80], r8
+       mov      edx, ecx
+       mov      dword ptr [rsp+0x10C], edx
+       mov      rcx, bword ptr [rsp+0x210]
+       mov      ebp, dword ptr [rsp+0x218]
        movzx    rdi, bpl
        shl      rdi, 56
        cmp      ebp, 7
-       ja       SHORT G_M27315_IG27
-						;; size=44 bbWeight=4.97 PerfScore 29.80
+       ja       SHORT G_M27315_IG28
+						;; size=48 bbWeight=5.00 PerfScore 32.49
 G_M27315_IG24:
-       mov      ecx, ebp
-       lea      rdx, [reloc @RWD00]
-       mov      edx, dword ptr [rdx+4*rcx]
-       lea      r8, G_M27315_IG02
-       add      rdx, r8
-       jmp      rdx
-						;; size=24 bbWeight=2.17 PerfScore 13.00
+       mov      edx, ebp
+       lea      r8, [reloc @RWD00]
+       mov      r8d, dword ptr [r8+4*rdx]
+       lea      r9, G_M27315_IG02
+       add      r8, r9
+       jmp      r8
+						;; size=26 bbWeight=2.21 PerfScore 13.26
 G_M27315_IG25:
+       mov      edx, dword ptr [rsp+0x10C]
+       mov      r8, bword ptr [rsp+0x80]
+       jmp      SHORT G_M27315_IG29
+						;; size=17 bbWeight=0.02 PerfScore 0.08
+G_M27315_IG26:
        mov      rcx, gword ptr [rsi]
        mov      eax, dword ptr [rsi+0x20]
        add      eax, -2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M27315_IG198
+       jae      G_M27315_IG200
        imul     rax, rax, 112
        mov      rcx, gword ptr [rcx+rax+0x10]
        jmp      G_M27315_IG07
-						;; size=32 bbWeight=0.17 PerfScore 2.47
-G_M27315_IG26:
+						;; size=32 bbWeight=0.17 PerfScore 2.41
+G_M27315_IG27:
        cmp      byte  ptr [rbx+0x24], 0
        je       G_M27315_IG18
        cmp      byte  ptr [rbx+0x28], 0
        jne      G_M27315_IG18
-       jmp      G_M27315_IG92
+       jmp      G_M27315_IG93
 						;; size=25 bbWeight=0.00 PerfScore 0.01
-G_M27315_IG27:
-       mov      rbp, 0xD1FFAB1E
-       and      rbp, qword ptr [r14]
-       or       rdi, rbp
-						;; size=16 bbWeight=2.80 PerfScore 9.80
 G_M27315_IG28:
-       mov      r14, rdi
-       test     r11d, r11d
-       je       SHORT G_M27315_IG30
-						;; size=8 bbWeight=4.97 PerfScore 7.45
+       mov      rbp, 0xD1FFAB1E
+       and      rbp, qword ptr [rcx]
+       or       rdi, rbp
+						;; size=16 bbWeight=2.79 PerfScore 9.76
 G_M27315_IG29:
-       mov      ebp, dword ptr [rax+0x54]
-       mov      edi, r11d
-       cmp      ebp, edi
-       jle      SHORT G_M27315_IG31
-       jmp      G_M27315_IG50
-						;; size=15 bbWeight=4.97 PerfScore 27.31
+       test     edx, edx
+       je       SHORT G_M27315_IG31
+						;; size=4 bbWeight=5.00 PerfScore 6.25
 G_M27315_IG30:
-       jmp      G_M27315_IG52
-						;; size=5 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG31:
-       lea      r13d, [rbp-0x01]
-       mov      dword ptr [rsp+0x210], r13d
-						;; size=12 bbWeight=4.97 PerfScore 7.45
-G_M27315_IG32:
-       cmp      ebp, r11d
-       jge      G_M27315_IG116
-       cmp      ebp, edi
-       jae      G_M27315_IG198
-       mov      r13d, ebp
-       lea      r13, [r13+2*r13]
-       lea      r13, bword ptr [r9+8*r13]
-       mov      r8, gword ptr [r13]
-       mov      gword ptr [rsp+0x80], r8
-       mov      r8, gword ptr [r13+0x08]
-       mov      r13, qword ptr [r13+0x10]
-       mov      qword ptr [rsp+0x110], r13
-       mov      r13, bword ptr [rsp+0x220]
-       mov      bword ptr [rsp+0x70], r13
-       mov      r13d, dword ptr [rsp+0x228]
-       cmp      r14, qword ptr [rsp+0x110]
-       jne      SHORT G_M27315_IG34
-       cmp      r13d, 7
-       jle      SHORT G_M27315_IG38
-						;; size=94 bbWeight=4.97 PerfScore 101.80
-G_M27315_IG33:
-       test     r8, r8
-       jne      SHORT G_M27315_IG35
+       mov      ebp, dword ptr [rax+0x54]
+       mov      ecx, edx
+       cmp      ebp, ecx
+       jle      SHORT G_M27315_IG32
        jmp      G_M27315_IG51
-						;; size=10 bbWeight=2.77 PerfScore 9.02
+						;; size=14 bbWeight=5.00 PerfScore 27.49
+G_M27315_IG31:
+       jmp      G_M27315_IG53
+						;; size=5 bbWeight=0.00 PerfScore 0.00
+G_M27315_IG32:
+       lea      r15d, [rbp-0x01]
+       mov      dword ptr [rsp+0x1FC], r15d
+						;; size=12 bbWeight=5.00 PerfScore 7.50
+G_M27315_IG33:
+       cmp      ebp, edx
+       jge      G_M27315_IG118
+       mov      dword ptr [rsp+0x204], ecx
+       cmp      ebp, ecx
+       jae      G_M27315_IG200
+       mov      r15d, ebp
+       lea      r15, [r15+2*r15]
+       lea      r15, bword ptr [r8+8*r15]
+       mov      r9, gword ptr [r15]
+       mov      gword ptr [rsp+0x78], r9
+       mov      r9, gword ptr [r15+0x08]
+       mov      r15, qword ptr [r15+0x10]
+       mov      qword ptr [rsp+0x100], r15
+       mov      r15, bword ptr [rsp+0x210]
+       mov      bword ptr [rsp+0x68], r15
+       mov      r15d, dword ptr [rsp+0x218]
+       cmp      rdi, qword ptr [rsp+0x100]
+       jne      SHORT G_M27315_IG35
+       cmp      r15d, 7
+       jle      SHORT G_M27315_IG39
+						;; size=95 bbWeight=5.00 PerfScore 99.98
 G_M27315_IG34:
-       mov      r13, gword ptr [rsp+0xC8]
-       jmp      G_M27315_IG109
-						;; size=13 bbWeight=0 PerfScore 0.00
+       test     r9, r9
+       jne      SHORT G_M27315_IG36
+       jmp      G_M27315_IG52
+						;; size=10 bbWeight=2.80 PerfScore 9.09
 G_M27315_IG35:
-       lea      r9, bword ptr [r8+0x10]
-       mov      bword ptr [rsp+0x68], r9
-       mov      gword ptr [rsp+0x78], r8
-       mov      r9d, dword ptr [r8+0x08]
-						;; size=18 bbWeight=2.75 PerfScore 12.36
-G_M27315_IG36:
-       cmp      r13d, r9d
-       jne      G_M27315_IG108
-       mov      r8d, r9d
-       mov      rcx, bword ptr [rsp+0x70]
-       mov      rdx, bword ptr [rsp+0x68]
-       call     [<unknown method>]
-						;; size=28 bbWeight=2.77 PerfScore 18.03
-G_M27315_IG37:
-       test     eax, eax
-       mov      r8, gword ptr [rsp+0x78]
-       je       SHORT G_M27315_IG40
-						;; size=9 bbWeight=2.77 PerfScore 6.24
-G_M27315_IG38:
-       mov      r14, r8
-       mov      rdi, gword ptr [rsp+0x80]
-						;; size=11 bbWeight=4.97 PerfScore 6.21
-G_M27315_IG39:
-       xor      rax, rax
-       mov      gword ptr [rsp+0x218], rax
-       lea      rax, bword ptr [rsi+0x84]
-       inc      dword ptr [rax]
-       lea      rcx, bword ptr [rsi+0x38]
-       mov      rdx, r14
-       call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       test     rdi, rdi
-       jne      SHORT G_M27315_IG41
-       jmp      G_M27315_IG133
-						;; size=41 bbWeight=4.97 PerfScore 48.42
-G_M27315_IG40:
-       mov      r13, gword ptr [rsp+0xC8]
-       jmp      G_M27315_IG109
+       mov      r15, gword ptr [rsp+0xB8]
+       jmp      G_M27315_IG111
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M27315_IG41:
-       lea      rcx, bword ptr [rsi+0x30]
+G_M27315_IG36:
+       lea      r8, bword ptr [r9+0x10]
+       mov      bword ptr [rsp+0x60], r8
+       mov      gword ptr [rsp+0x70], r9
+       mov      r8d, dword ptr [r9+0x08]
+						;; size=18 bbWeight=2.77 PerfScore 12.46
+G_M27315_IG37:
+       cmp      r15d, r8d
+       jne      G_M27315_IG110
+       mov      r8d, r8d
+       mov      rcx, bword ptr [rsp+0x68]
+       mov      rdx, bword ptr [rsp+0x60]
+       call     [<unknown method>]
+						;; size=28 bbWeight=2.80 PerfScore 18.17
+G_M27315_IG38:
+       test     eax, eax
+       mov      r9, gword ptr [rsp+0x70]
+       je       SHORT G_M27315_IG41
+						;; size=9 bbWeight=2.80 PerfScore 6.29
+G_M27315_IG39:
+       mov      rdi, r9
+       mov      rbp, gword ptr [rsp+0x78]
+						;; size=8 bbWeight=5.00 PerfScore 6.25
+G_M27315_IG40:
+       xor      rcx, rcx
+       mov      gword ptr [rsp+0x208], rcx
+       lea      rcx, bword ptr [rsi+0x84]
+       inc      dword ptr [rcx]
+       lea      rcx, bword ptr [rsi+0x38]
        mov      rdx, rdi
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov      rcx, qword ptr [rdi+0xC8]
-       mov      qword ptr [rsi+0x94], rcx
-       cmp      byte  ptr [rdi+0xAD], 0
-       je       G_M27315_IG63
-						;; size=39 bbWeight=4.97 PerfScore 43.45
+       test     rbp, rbp
+       jne      SHORT G_M27315_IG42
+       jmp      G_M27315_IG135
+						;; size=41 bbWeight=5.00 PerfScore 48.74
+G_M27315_IG41:
+       mov      r15, gword ptr [rsp+0xB8]
+       jmp      G_M27315_IG111
+						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG42:
+       lea      rcx, bword ptr [rsi+0x30]
+       mov      rdx, rbp
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov      rcx, qword ptr [rbp+0xC8]
+       mov      qword ptr [rsi+0x94], rcx
+       cmp      byte  ptr [rbp+0xAD], 0
+       je       G_M27315_IG64
+						;; size=39 bbWeight=5.00 PerfScore 43.74
+G_M27315_IG43:
        cmp      byte  ptr [rbx+0x2B], 0
-       jne      G_M27315_IG136
+       jne      G_M27315_IG138
        mov      rcx, rbx
        call     [<unknown method>]
-						;; size=19 bbWeight=4.16 PerfScore 30.14
-G_M27315_IG43:
-       test     eax, eax
-       je       G_M27315_IG62
-						;; size=8 bbWeight=4.16 PerfScore 5.20
+						;; size=19 bbWeight=4.31 PerfScore 31.23
 G_M27315_IG44:
-       cmp      dword ptr [rsp+0x25C], 0
-       jne      G_M27315_IG138
-       mov      rcx, 0xD1FFAB1E      ; <unknown class>
-       cmp      qword ptr [rdi], rcx
-       jne      G_M27315_IG12
-						;; size=33 bbWeight=4.16 PerfScore 30.14
+       test     eax, eax
+       je       G_M27315_IG63
+						;; size=8 bbWeight=4.31 PerfScore 5.38
 G_M27315_IG45:
-       mov      rcx, rdi
-       mov      rdx, gword ptr [rsp+0xC8]
+       cmp      dword ptr [rsp+0x24C], 0
+       jne      G_M27315_IG140
+       mov      rcx, 0xD1FFAB1E      ; <unknown class>
+       cmp      qword ptr [rbp], rcx
+       je       G_M27315_IG12
+						;; size=34 bbWeight=4.31 PerfScore 31.23
+G_M27315_IG46:
+       mov      rcx, rbp
+       mov      rdx, gword ptr [rsp+0xB8]
        mov      r8, rsi
        mov      r9, rbx
-       call     [System.Text.Json.Serialization.Metadata.JsonPropertyInfo`1[System.__Canon]:ReadJsonAndSetMember(System.Object,byref,byref):ubyte:this]
+       mov      rax, qword ptr [rbp]
+       mov      rax, qword ptr [rax+0x48]
+       call     [rax+0x30]<unknown method>
        jmp      G_M27315_IG13
-						;; size=28 bbWeight=2.16 PerfScore 14.59
-G_M27315_IG46:
-       mov      ecx, dword ptr [r14]
-       or       rcx, rdi
-       movzx    rdi, word  ptr [r14+0x04]
-       shl      rdi, 32
-       or       rdi, rcx
-						;; size=18 bbWeight=1.18 PerfScore 5.88
+						;; size=33 bbWeight=2.37 PerfScore 25.47
 G_M27315_IG47:
+       mov      edx, dword ptr [rcx]
+       or       rdx, rdi
+       movzx    rdi, word  ptr [rcx+0x04]
+       shl      rdi, 32
+       or       rdi, rdx
+						;; size=16 bbWeight=1.19 PerfScore 5.96
+G_M27315_IG48:
        dec      ebp
-       movsxd   rcx, ebp
-       movzx    rcx, byte  ptr [r14+rcx]
+       movsxd   rdx, ebp
+       movzx    rcx, byte  ptr [rcx+rdx]
        shl      ebp, 3
        shlx     rcx, rcx, rbp
        or       rcx, rdi
        mov      rdi, rcx
-       jmp      G_M27315_IG28
-						;; size=29 bbWeight=1.37 PerfScore 8.24
-G_M27315_IG48:
-       mov      ecx, dword ptr [r14]
-       or       rdi, rcx
-       jmp      SHORT G_M27315_IG47
-						;; size=8 bbWeight=0.20 PerfScore 0.84
+       mov      edx, dword ptr [rsp+0x10C]
+       mov      r8, bword ptr [rsp+0x80]
+       jmp      G_M27315_IG29
+						;; size=43 bbWeight=1.40 PerfScore 11.19
 G_M27315_IG49:
-       mov      ecx, dword ptr [r14]
-       or       rdi, rcx
-       jmp      G_M27315_IG28
-						;; size=11 bbWeight=0.79 PerfScore 3.35
+       mov      edx, dword ptr [rcx]
+       or       rdi, rdx
+       jmp      SHORT G_M27315_IG48
+						;; size=7 bbWeight=0.20 PerfScore 0.85
 G_M27315_IG50:
-       mov      ebp, edi
-       jmp      G_M27315_IG31
-						;; size=7 bbWeight=1.40 PerfScore 3.15
+       mov      ecx, dword ptr [rcx]
+       or       rdi, rcx
+       mov      edx, dword ptr [rsp+0x10C]
+       mov      r8, bword ptr [rsp+0x80]
+       jmp      G_M27315_IG29
+						;; size=25 bbWeight=0.79 PerfScore 4.95
 G_M27315_IG51:
-       xor      r9, r9
-       mov      bword ptr [rsp+0x68], r9
-       xor      r9d, r9d
-       mov      gword ptr [rsp+0x78], r8
-       jmp      G_M27315_IG36
-						;; size=21 bbWeight=0.03 PerfScore 0.12
+       mov      ebp, ecx
+       jmp      G_M27315_IG32
+						;; size=7 bbWeight=1.41 PerfScore 3.16
 G_M27315_IG52:
-       mov      rcx, gword ptr [rsp+0xB8]
-       mov      r9, gword ptr [rcx+0x18]
-						;; size=12 bbWeight=0.00 PerfScore 0.00
+       xor      r8, r8
+       mov      bword ptr [rsp+0x60], r8
+       xor      r8d, r8d
+       mov      gword ptr [rsp+0x70], r9
+       jmp      G_M27315_IG37
+						;; size=21 bbWeight=0.03 PerfScore 0.13
 G_M27315_IG53:
-       vmovdqu  xmm0, xmmword ptr [rsp+0x220]
-       vmovdqu  xmmword ptr [rsp+0xF0], xmm0
-						;; size=18 bbWeight=0.00 PerfScore 0.00
+       mov      r10, gword ptr [rsp+0xB0]
+       mov      rdx, gword ptr [r10+0x18]
+						;; size=12 bbWeight=0.00 PerfScore 0.00
 G_M27315_IG54:
-       mov      rdx, r9
-       lea      r8, [rsp+0xF0]
-       lea      r9, [rsp+0x218]
+       vmovdqu  xmm0, xmmword ptr [rsp+0x210]
+       vmovdqu  xmmword ptr [rsp+0xE0], xmm0
+						;; size=18 bbWeight=0.00 PerfScore 0.00
+G_M27315_IG55:
+       lea      r8, [rsp+0xE0]
+       lea      r9, [rsp+0x208]
        mov      rcx, 0xD1FFAB1E      ; <unknown method>
        call     [System.Text.Json.JsonHelpers:TryLookupUtf8Key[System.__Canon](System.Collections.Generic.Dictionary`2[System.__Canon,System.__Canon],System.ReadOnlySpan`1[ubyte],byref):ubyte]
        test     eax, eax
-       je       SHORT G_M27315_IG55
-       mov      rdi, gword ptr [rsp+0xB8]
-       mov      rcx, gword ptr [rdi+0xB0]
-       cmp      byte  ptr [rcx+0x9B], 0
        je       SHORT G_M27315_IG56
-       jmp      G_M27315_IG126
-						;; size=68 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG55:
-       mov      r13, gword ptr [rsp+0xC8]
-       jmp      G_M27315_IG130
-						;; size=13 bbWeight=0 PerfScore 0.00
+       mov      rbp, gword ptr [rsp+0xB0]
+       mov      rcx, gword ptr [rbp+0xB0]
+       cmp      byte  ptr [rcx+0x9B], 0
+       je       SHORT G_M27315_IG57
+       jmp      G_M27315_IG128
+						;; size=65 bbWeight=0.00 PerfScore 0.00
 G_M27315_IG56:
-       mov      rcx, gword ptr [rsp+0x218]
-       mov      rcx, gword ptr [rcx+0x70]
-       mov      rbp, rcx
-						;; size=15 bbWeight=0.00 PerfScore 0.00
+       mov      r15, gword ptr [rsp+0xB8]
+       jmp      G_M27315_IG132
+						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG57:
-       mov      rax, bword ptr [rsp+0xA8]
-       add      rax, 56
-       mov      bword ptr [rsp+0xA0], rax
-       mov      rcx, gword ptr [rax]
-       test     rcx, rcx
-       je       G_M27315_IG131
-						;; size=32 bbWeight=0.00 PerfScore 0.00
+       mov      rcx, gword ptr [rsp+0x208]
+       mov      rcx, gword ptr [rcx+0x70]
+       mov      gword ptr [rsp+0xA8], rcx
+						;; size=20 bbWeight=0.00 PerfScore 0.00
 G_M27315_IG58:
+       mov      rdx, bword ptr [rsp+0x98]
+       add      rdx, 56
+       mov      bword ptr [rsp+0x90], rdx
+       mov      rcx, gword ptr [rdx]
+       test     rcx, rcx
+       je       G_M27315_IG133
+						;; size=32 bbWeight=0.00 PerfScore 0.00
+G_M27315_IG59:
        call     [System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder:get_TotalCount():int:this]
        cmp      eax, 64
-       jge      SHORT G_M27315_IG61
+       jge      SHORT G_M27315_IG62
 						;; size=11 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG59:
-       mov      r8, bword ptr [rsp+0xA0]
+G_M27315_IG60:
+       mov      r8, bword ptr [rsp+0x90]
        mov      rcx, gword ptr [r8]
        test     rcx, rcx
-       je       G_M27315_IG132
+       je       G_M27315_IG134
 						;; size=20 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG60:
-       mov      rdx, gword ptr [rsp+0x218]
-       mov      gword ptr [rsp+0xD8], rdx
-       mov      gword ptr [rsp+0xE0], rbp
-       mov      qword ptr [rsp+0xE8], r14
-       lea      rdx, [rsp+0xD8]
+G_M27315_IG61:
+       mov      rdx, gword ptr [rsp+0x208]
+       mov      gword ptr [rsp+0xC8], rdx
+       mov      r10, gword ptr [rsp+0xA8]
+       mov      gword ptr [rsp+0xD0], r10
+       mov      qword ptr [rsp+0xD8], rdi
+       lea      rdx, [rsp+0xC8]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder:TryAdd(System.Text.Json.Serialization.Metadata.PropertyRef):this]
-						;; size=48 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG61:
-       mov      rcx, gword ptr [rsp+0x218]
-       mov      rdi, rcx
-       mov      r14, rbp
-       jmp      G_M27315_IG39
-						;; size=19 bbWeight=0.00 PerfScore 0.00
+						;; size=56 bbWeight=0.00 PerfScore 0.00
 G_M27315_IG62:
-       cmp      byte  ptr [rbx+0x24], 0
-       je       G_M27315_IG44
-       cmp      byte  ptr [rbx+0x28], 0
-       jne      G_M27315_IG44
-       jmp      G_M27315_IG137
-						;; size=25 bbWeight=0.00 PerfScore 0.01
+       mov      rcx, gword ptr [rsp+0x208]
+       mov      rbp, rcx
+       mov      rdi, gword ptr [rsp+0xA8]
+       jmp      G_M27315_IG40
+						;; size=24 bbWeight=0.00 PerfScore 0.00
 G_M27315_IG63:
        cmp      byte  ptr [rbx+0x24], 0
-       je       G_M27315_IG143
-       cmp      byte  ptr [rbx+0x28], 5
-       jne      SHORT G_M27315_IG66
-						;; size=16 bbWeight=0.81 PerfScore 6.47
+       je       G_M27315_IG45
+       cmp      byte  ptr [rbx+0x28], 0
+       jne      G_M27315_IG45
+       jmp      G_M27315_IG139
+						;; size=25 bbWeight=0.00 PerfScore 0.01
 G_M27315_IG64:
-       cmp      byte  ptr [rbx+0x2B], 0
-       jne      G_M27315_IG139
-       mov      rcx, rbx
-       call     [<unknown method>]
-						;; size=19 bbWeight=0.78 PerfScore 5.67
+       cmp      byte  ptr [rbx+0x24], 0
+       je       G_M27315_IG145
+       cmp      byte  ptr [rbx+0x28], 5
+       jne      SHORT G_M27315_IG67
+						;; size=16 bbWeight=0.69 PerfScore 5.54
 G_M27315_IG65:
-       test     eax, eax
-       je       SHORT G_M27315_IG74
-						;; size=4 bbWeight=0.78 PerfScore 0.98
-G_M27315_IG66:
-       movzx    rcx, byte  ptr [rbx+0x28]
-       cmp      ecx, 1
-       je       SHORT G_M27315_IG68
-						;; size=9 bbWeight=0.81 PerfScore 2.63
-G_M27315_IG67:
-       cmp      ecx, 3
-       jne      G_M27315_IG13
-						;; size=9 bbWeight=0.79 PerfScore 0.98
-G_M27315_IG68:
-       mov      rcx, rbx
-       call     [System.Text.Json.Utf8JsonReader:get_CurrentDepth():int:this]
-       mov      r14d, eax
-						;; size=12 bbWeight=0.03 PerfScore 0.11
-G_M27315_IG69:
        cmp      byte  ptr [rbx+0x2B], 0
        jne      G_M27315_IG141
        mov      rcx, rbx
        call     [<unknown method>]
-						;; size=19 bbWeight=5.44 PerfScore 39.45
-G_M27315_IG70:
+						;; size=19 bbWeight=0.67 PerfScore 4.86
+G_M27315_IG66:
        test     eax, eax
        je       SHORT G_M27315_IG75
-						;; size=4 bbWeight=5.44 PerfScore 6.80
+						;; size=4 bbWeight=0.67 PerfScore 0.84
+G_M27315_IG67:
+       movzx    rcx, byte  ptr [rbx+0x28]
+       cmp      ecx, 1
+       je       SHORT G_M27315_IG69
+						;; size=9 bbWeight=0.69 PerfScore 2.25
+G_M27315_IG68:
+       cmp      ecx, 3
+       jne      G_M27315_IG13
+						;; size=9 bbWeight=0.67 PerfScore 0.84
+G_M27315_IG69:
+       mov      rcx, rbx
+       call     [System.Text.Json.Utf8JsonReader:get_CurrentDepth():int:this]
+       mov      edi, eax
+						;; size=11 bbWeight=0.03 PerfScore 0.10
+G_M27315_IG70:
+       cmp      byte  ptr [rbx+0x2B], 0
+       jne      G_M27315_IG143
+       mov      rcx, rbx
+       call     [<unknown method>]
+						;; size=19 bbWeight=4.66 PerfScore 33.76
 G_M27315_IG71:
+       test     eax, eax
+       je       SHORT G_M27315_IG76
+						;; size=4 bbWeight=4.66 PerfScore 5.82
+G_M27315_IG72:
        mov      ecx, dword ptr [rbx+0x58]
        mov      edx, ecx
        movzx    rax, byte  ptr [rbx+0x28]
        cmp      eax, 1
-       je       SHORT G_M27315_IG76
-						;; size=14 bbWeight=5.44 PerfScore 29.92
-G_M27315_IG72:
-       cmp      eax, 3
-       je       SHORT G_M27315_IG76
-						;; size=5 bbWeight=3.87 PerfScore 4.83
+       je       SHORT G_M27315_IG77
+						;; size=14 bbWeight=4.66 PerfScore 25.61
 G_M27315_IG73:
-       cmp      r14d, edx
-       jl       SHORT G_M27315_IG69
-       jmp      G_M27315_IG13
-						;; size=10 bbWeight=5.44 PerfScore 17.68
+       cmp      eax, 3
+       je       SHORT G_M27315_IG77
+						;; size=5 bbWeight=3.23 PerfScore 4.04
 G_M27315_IG74:
-       cmp      byte  ptr [rbx+0x24], 0
-       je       SHORT G_M27315_IG66
-       cmp      byte  ptr [rbx+0x28], 0
-       jne      SHORT G_M27315_IG66
-       jmp      G_M27315_IG140
-						;; size=17 bbWeight=0.00 PerfScore 0.00
+       cmp      edi, edx
+       jl       SHORT G_M27315_IG70
+       jmp      G_M27315_IG13
+						;; size=9 bbWeight=4.66 PerfScore 15.13
 G_M27315_IG75:
        cmp      byte  ptr [rbx+0x24], 0
-       je       SHORT G_M27315_IG71
+       je       SHORT G_M27315_IG67
        cmp      byte  ptr [rbx+0x28], 0
-       jne      SHORT G_M27315_IG71
+       jne      SHORT G_M27315_IG67
        jmp      G_M27315_IG142
-						;; size=17 bbWeight=0.00 PerfScore 0.01
+						;; size=17 bbWeight=0.00 PerfScore 0.00
 G_M27315_IG76:
-       lea      edx, [rcx-0x01]
-       jmp      SHORT G_M27315_IG73
-						;; size=5 bbWeight=1.99 PerfScore 4.98
+       cmp      byte  ptr [rbx+0x24], 0
+       je       SHORT G_M27315_IG72
+       cmp      byte  ptr [rbx+0x28], 0
+       jne      SHORT G_M27315_IG72
+       jmp      G_M27315_IG144
+						;; size=17 bbWeight=0.00 PerfScore 0.01
 G_M27315_IG77:
-       mov      rax, gword ptr [r15+0x40]
-       test     rax, rax
-       jne      G_M27315_IG145
-						;; size=13 bbWeight=1.00 PerfScore 3.25
+       lea      edx, [rcx-0x01]
+       jmp      SHORT G_M27315_IG74
+						;; size=5 bbWeight=1.68 PerfScore 4.20
 G_M27315_IG78:
-       lea      rbx, bword ptr [rsi+0x30]
-       cmp      dword ptr [r15+0x104], 0
-       jg       G_M27315_IG146
-						;; size=18 bbWeight=1.00 PerfScore 4.50
-G_M27315_IG79:
-       cmp      gword ptr [rsi+0x68], 0
+       mov      rax, gword ptr [r14+0x40]
+       test     rax, rax
        jne      G_M27315_IG147
-						;; size=11 bbWeight=1.00 PerfScore 4.00
+						;; size=13 bbWeight=1.00 PerfScore 3.25
+G_M27315_IG79:
+       lea      rbp, bword ptr [rsi+0x30]
+       cmp      dword ptr [r14+0x104], 0
+       jg       G_M27315_IG148
+						;; size=18 bbWeight=1.00 PerfScore 4.50
 G_M27315_IG80:
-       mov      rdi, gword ptr [rsp+0x2C0]
+       cmp      gword ptr [rsi+0x68], 0
+       jne      G_M27315_IG149
+						;; size=11 bbWeight=1.00 PerfScore 4.00
+G_M27315_IG81:
+       mov      rdi, gword ptr [rsp+0x2B0]
        mov      rcx, qword ptr [rdi]
        mov      rcx, qword ptr [rcx+0x30]
        mov      rcx, qword ptr [rcx+0x18]
        mov      rcx, qword ptr [rcx]
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      rdx, r13
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      rdx, r15
        test     rdx, rdx
-       je       SHORT G_M27315_IG83
-						;; size=38 bbWeight=1.00 PerfScore 11.50
-G_M27315_IG81:
-       cmp      qword ptr [rdx], rcx
-       je       SHORT G_M27315_IG83
-						;; size=5 bbWeight=0.50 PerfScore 2.00
+       je       SHORT G_M27315_IG84
+						;; size=38 bbWeight=1 PerfScore 11.50
 G_M27315_IG82:
-       mov      rdx, r13
+       cmp      qword ptr [rdx], rcx
+       je       SHORT G_M27315_IG84
+						;; size=5 bbWeight=0.50 PerfScore 2.00
+G_M27315_IG83:
+       mov      rdx, r15
        call     CORINFO_HELP_CHKCASTANY
        mov      rdx, rax
 						;; size=11 bbWeight=0.25 PerfScore 0.38
-G_M27315_IG83:
-       mov      rcx, r14
-       call     CORINFO_HELP_CHECKED_ASSIGN_REF
-						;; size=8 bbWeight=1.00 PerfScore 1.25
 G_M27315_IG84:
-       mov      eax, 1
-						;; size=5 bbWeight=1.00 PerfScore 0.25
+       mov      rcx, bword ptr [rsp+0x2D8]
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+						;; size=13 bbWeight=1 PerfScore 2.00
 G_M27315_IG85:
-       add      rsp, 632
+       mov      eax, 1
+						;; size=5 bbWeight=1 PerfScore 0.25
+G_M27315_IG86:
+       add      rsp, 616
        pop      rbx
        pop      rbp
        pop      rsi
@@ -2848,541 +2851,522 @@ G_M27315_IG85:
        pop      r14
        pop      r15
        ret      
-						;; size=20 bbWeight=1.00 PerfScore 5.25
-G_M27315_IG86:
+						;; size=20 bbWeight=1 PerfScore 5.25
+G_M27315_IG87:
        mov      rdx, rsi
        call     [System.Text.Json.Serialization.Metadata.JsonPropertyInfo:TryGetPrePopulatedValue(byref):ubyte:this]
        test     eax, eax
        je       G_M27315_IG08
-       jmp      SHORT G_M27315_IG88
+       jmp      SHORT G_M27315_IG89
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M27315_IG87:
-       mov      rcx, r15
+G_M27315_IG88:
+       mov      rcx, r14
        mov      rdx, rbx
        mov      r8, rsi
        call     [System.Text.Json.ThrowHelper:ThrowNotSupportedException_DeserializeNoConstructor(System.Text.Json.Serialization.Metadata.JsonTypeInfo,byref,byref)]
        jmp      G_M27315_IG09
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M27315_IG88:
-       mov      r13, gword ptr [rsi+0x50]
-       mov      gword ptr [rsp+0xC8], r13
+G_M27315_IG89:
+       mov      r15, gword ptr [rsi+0x50]
+       mov      gword ptr [rsp+0xB8], r15
        jmp      G_M27315_IG10
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M27315_IG89:
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      rdx, r13
-       mov      rcx, gword ptr [r12+0x08]
-       call     [r12+0x18]<unknown method>
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG11
-						;; size=34 bbWeight=0 PerfScore 0.00
 G_M27315_IG90:
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      rdx, r15
+       mov      rcx, gword ptr [r13+0x08]
+       call     [r13+0x18]<unknown method>
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG11
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M27315_IG91:
        mov      rcx, 0xD1FFAB1E      ; System.Collections.BitArray
        call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rsp+0xC0], rax
-       mov      edx, dword ptr [r15+0x104]
-       mov      rcx, rax
+       mov      r13, rax
+       mov      edx, dword ptr [r14+0x104]
+       mov      rcx, r13
        xor      r8d, r8d
        call     [System.Collections.BitArray:.ctor(int,ubyte):this]
        lea      rcx, bword ptr [r12+0x48]
-       mov      rdx, gword ptr [rsp+0xC0]
+       mov      rdx, r13
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        jmp      G_M27315_IG16
-						;; size=65 bbWeight=0 PerfScore 0.00
-G_M27315_IG91:
+						;; size=55 bbWeight=0 PerfScore 0.00
+G_M27315_IG92:
        mov      rcx, rbx
        call     [<unknown method>]
        jmp      G_M27315_IG17
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M27315_IG92:
+G_M27315_IG93:
        cmp      byte  ptr [rbx+0x46], 0
        jne      G_M27315_IG18
        xor      r9, r9
-       mov      bword ptr [rsp+0xF0], r9
+       mov      bword ptr [rsp+0xE0], r9
        xor      r9d, r9d
-       mov      dword ptr [rsp+0xF8], r9d
-       lea      r9, [rsp+0xF0]
+       mov      dword ptr [rsp+0xE8], r9d
+       lea      r9, [rsp+0xE0]
        mov      rcx, rbx
        mov      edx, 32
        xor      r8d, r8d
        call     [System.Text.Json.ThrowHelper:ThrowJsonReaderException(byref,int,ubyte,System.ReadOnlySpan`1[ubyte])]
        int3     
 						;; size=58 bbWeight=0 PerfScore 0.00
-G_M27315_IG93:
-       mov      r13, gword ptr [rsp+0xC8]
-						;; size=8 bbWeight=0 PerfScore 0.00
 G_M27315_IG94:
-       vmovdqu  xmm0, xmmword ptr [rbx+0xA8]
-       vmovdqu  xmmword ptr [rsp+0x230], xmm0
-       mov      rcx, qword ptr [rbx+0xB8]
-       mov      qword ptr [rsp+0x240], rcx
-						;; size=32 bbWeight=0 PerfScore 0.00
+       mov      r15, gword ptr [rsp+0xB8]
+						;; size=8 bbWeight=0 PerfScore 0.00
 G_M27315_IG95:
-       lea      rcx, [rsp+0x230]
+       vmovdqu  xmm0, xmmword ptr [rbx+0xA8]
+       vmovdqu  xmmword ptr [rsp+0x220], xmm0
+       mov      rcx, qword ptr [rbx+0xB8]
+       mov      qword ptr [rsp+0x230], rcx
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M27315_IG96:
+       lea      rcx, [rsp+0x220]
        call     [System.Buffers.BuffersExtensions:ToArray[ubyte](byref):ubyte[]]
        test     rax, rax
-       je       SHORT G_M27315_IG96
+       je       SHORT G_M27315_IG97
        lea      r12, bword ptr [rax+0x10]
-       mov      r10d, dword ptr [rax+0x08]
-       jmp      SHORT G_M27315_IG97
+       mov      r13d, dword ptr [rax+0x08]
+       jmp      SHORT G_M27315_IG98
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M27315_IG96:
-       xor      r12, r12
-       xor      r10d, r10d
-						;; size=6 bbWeight=0 PerfScore 0.00
 G_M27315_IG97:
-       mov      gword ptr [rsp+0xC8], r13
+       xor      r12, r12
+       xor      r13d, r13d
+						;; size=6 bbWeight=0 PerfScore 0.00
+G_M27315_IG98:
+       mov      gword ptr [rsp+0xB8], r15
        jmp      G_M27315_IG20
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M27315_IG98:
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      bword ptr [rsp+0xF0], r12
-       mov      dword ptr [rsp+0xF8], r10d
-       lea      rdx, [rsp+0xF0]
-       lea      rcx, [rsp+0x248]
-       call     [System.Text.Json.JsonReaderHelper:GetUnescapedSpan(System.ReadOnlySpan`1[ubyte]):System.ReadOnlySpan`1[ubyte]]
-       mov      r12, bword ptr [rsp+0x248]
-       mov      r9d, dword ptr [rsp+0x250]
-       mov      ecx, r9d
-       mov      gword ptr [rsp+0xC8], r13
-       mov      r9d, ecx
-       jmp      G_M27315_IG21
-						;; size=81 bbWeight=0 PerfScore 0.00
 G_M27315_IG99:
-       mov      r13, gword ptr [rsp+0xC8]
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      bword ptr [rsp+0xE0], r12
+       mov      dword ptr [rsp+0xE8], r13d
+       lea      rdx, [rsp+0xE0]
+       lea      rcx, [rsp+0x238]
+       call     [System.Text.Json.JsonReaderHelper:GetUnescapedSpan(System.ReadOnlySpan`1[ubyte]):System.ReadOnlySpan`1[ubyte]]
+       mov      r12, bword ptr [rsp+0x238]
+       mov      r13d, dword ptr [rsp+0x240]
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG21
+						;; size=75 bbWeight=0 PerfScore 0.00
+G_M27315_IG100:
+       mov      r15, gword ptr [rsp+0xB8]
        lea      rcx, bword ptr [rsi+0x30]
        cmp      byte  ptr [rcx+0x5E], 1
-       je       SHORT G_M27315_IG100
+       je       SHORT G_M27315_IG101
        mov      rdx, gword ptr [rcx+0x28]
-       jmp      SHORT G_M27315_IG101
+       jmp      SHORT G_M27315_IG102
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M27315_IG100:
+G_M27315_IG101:
        mov      rdx, gword ptr [rcx+0x30]
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M27315_IG101:
-       mov      bword ptr [rsp+0xF0], r12
-       mov      dword ptr [rsp+0xF8], r11d
-       lea      rcx, [rsp+0xF0]
+G_M27315_IG102:
+       mov      bword ptr [rsp+0xE0], r12
+       mov      dword ptr [rsp+0xE8], r13d
+       lea      rcx, [rsp+0xE0]
        mov      rdx, gword ptr [rdx+0x98]
        call     [System.Text.Json.JsonSerializer:IsMetadataPropertyName(System.ReadOnlySpan`1[ubyte],System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver):ubyte]
        test     eax, eax
-       mov      r11d, dword ptr [rsp+0x120]
-       je       SHORT G_M27315_IG103
-       mov      rbp, gword ptr [rsp+0x2D8]
+       je       SHORT G_M27315_IG104
+       mov      rbp, gword ptr [rsp+0x2C8]
        cmp      byte  ptr [rbp+0x93], 0
-       mov      gword ptr [rsp+0x2D8], rbp
-       jne      SHORT G_M27315_IG102
-       mov      bword ptr [rsp+0xF0], r12
-       mov      dword ptr [rsp+0xF8], r11d
-       lea      rcx, [rsp+0xF0]
+       mov      gword ptr [rsp+0x2C8], rbp
+       jne      SHORT G_M27315_IG103
+       mov      bword ptr [rsp+0xE0], r12
+       mov      dword ptr [rsp+0xE8], r13d
+       lea      rcx, [rsp+0xE0]
        mov      rdx, rbx
        mov      r8, rsi
        call     [System.Text.Json.ThrowHelper:ThrowUnexpectedMetadataException(System.ReadOnlySpan`1[ubyte],byref,byref)]
-       mov      gword ptr [rsp+0xC8], r13
-       mov      r11d, dword ptr [rsp+0x120]
+       mov      gword ptr [rsp+0xB8], r15
        jmp      G_M27315_IG22
-						;; size=131 bbWeight=0 PerfScore 0.00
-G_M27315_IG102:
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG22
-						;; size=13 bbWeight=0 PerfScore 0.00
+						;; size=115 bbWeight=0 PerfScore 0.00
 G_M27315_IG103:
-       mov      gword ptr [rsp+0xC8], r13
+       mov      gword ptr [rsp+0xB8], r15
        jmp      G_M27315_IG22
 						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG104:
-       mov      r13, gword ptr [rsp+0xC8]
-       xor      r9, r9
-       xor      r11d, r11d
-       mov      gword ptr [rsp+0xC8], r13
-       mov      bword ptr [rsp+0x2E8], r14
-       jmp      G_M27315_IG23
-						;; size=35 bbWeight=0 PerfScore 0.00
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG22
+						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG105:
-       mov      gword ptr [rsp+0xD0], r15
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      r15d, dword ptr [r14]
-       or       r15, rdi
-       movzx    rdi, word  ptr [r14+0x04]
-       shl      rdi, 32
-       or       rdi, r15
-       mov      gword ptr [rsp+0xC8], r13
-       mov      r15, gword ptr [rsp+0xD0]
-       jmp      G_M27315_IG28
-						;; size=55 bbWeight=0 PerfScore 0.00
+       mov      r15, gword ptr [rsp+0xB8]
+       xor      rdx, rdx
+       xor      r8, r8
+						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG106:
-       mov      gword ptr [rsp+0xD0], r15
-       mov      r13, gword ptr [rsp+0xC8]
-       movzx    r15, word  ptr [r14]
-       or       rdi, r15
-       mov      gword ptr [rsp+0xC8], r13
-       mov      r15, gword ptr [rsp+0xD0]
-       jmp      G_M27315_IG47
-						;; size=44 bbWeight=0 PerfScore 0.00
+       xor      ecx, ecx
+       mov      gword ptr [rsp+0xB8], r15
+       mov      rdx, r8
+       jmp      G_M27315_IG23
+						;; size=18 bbWeight=0 PerfScore 0.00
 G_M27315_IG107:
-       mov      r13, gword ptr [rsp+0xC8]
-       movzx    rbp, word  ptr [r14]
-       or       rdi, rbp
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG28
-						;; size=28 bbWeight=0 PerfScore 0.00
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      r8d, dword ptr [rcx]
+       or       r8, rdi
+       movzx    rdi, word  ptr [rcx+0x04]
+       shl      rdi, 32
+       or       rdi, r8
+       mov      gword ptr [rsp+0xB8], r15
+       mov      edx, dword ptr [rsp+0x10C]
+       mov      r8, bword ptr [rsp+0x80]
+       jmp      G_M27315_IG29
+						;; size=53 bbWeight=0 PerfScore 0.00
 G_M27315_IG108:
-       mov      gword ptr [rsp+0xD0], r15
-       mov      r13, gword ptr [rsp+0xC8]
-       xor      r15d, r15d
-       mov      gword ptr [rsp+0xC8], r13
-       mov      eax, r15d
-       mov      r15, gword ptr [rsp+0xD0]
-       jmp      G_M27315_IG37
-						;; size=43 bbWeight=0 PerfScore 0.00
+       mov      r15, gword ptr [rsp+0xB8]
+       movzx    r8, word  ptr [rcx]
+       or       rdi, r8
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG48
+						;; size=28 bbWeight=0 PerfScore 0.00
 G_M27315_IG109:
+       mov      r15, gword ptr [rsp+0xB8]
+       movzx    r8, word  ptr [rcx]
+       or       rdi, r8
+       mov      gword ptr [rsp+0xB8], r15
+       mov      edx, dword ptr [rsp+0x10C]
+       mov      r8, bword ptr [rsp+0x80]
+       jmp      G_M27315_IG29
+						;; size=43 bbWeight=0 PerfScore 0.00
+G_M27315_IG110:
+       mov      r15, gword ptr [rsp+0xB8]
+       xor      r8d, r8d
+       mov      gword ptr [rsp+0xB8], r15
+       mov      eax, r8d
+       jmp      G_M27315_IG38
+						;; size=27 bbWeight=0 PerfScore 0.00
+G_M27315_IG111:
        inc      ebp
-       mov      r8d, dword ptr [rsp+0x210]
-       test     r8d, r8d
-       mov      gword ptr [rsp+0xC8], r13
-       mov      dword ptr [rsp+0x210], r8d
-       mov      r9, bword ptr [rsp+0x88]
-       jl       G_M27315_IG110
-       mov      gword ptr [rsp+0xD0], r15
-       mov      r13d, dword ptr [rsp+0x210]
-       cmp      r13d, edi
-       jae      G_M27315_IG198
-       mov      r15d, r13d
-       lea      r15, [r15+2*r15]
-       lea      r15, bword ptr [r9+8*r15]
-       mov      bword ptr [rsp+0x38], r15
-       mov      r15, gword ptr [r15]
+       mov      r9d, dword ptr [rsp+0x1FC]
+       test     r9d, r9d
+       mov      gword ptr [rsp+0xB8], r15
+       mov      dword ptr [rsp+0x1FC], r9d
+       mov      ecx, dword ptr [rsp+0x204]
+       mov      r8, bword ptr [rsp+0x80]
+       jl       G_M27315_IG112
+       mov      gword ptr [rsp+0xC0], r14
+       mov      r15d, dword ptr [rsp+0x1FC]
+       mov      dword ptr [rsp+0x204], ecx
+       cmp      r15d, ecx
+       jae      G_M27315_IG200
+       mov      r14d, r15d
+       lea      r14, [r14+2*r14]
+       lea      r14, bword ptr [r8+8*r14]
+       mov      bword ptr [rsp+0x30], r14
+       mov      r14, gword ptr [r14]
+       mov      rax, bword ptr [rsp+0x30]
+       mov      rax, gword ptr [rax+0x08]
+       mov      r11, bword ptr [rsp+0x30]
+       mov      r11, qword ptr [r11+0x10]
+       mov      rdx, bword ptr [rsp+0x210]
+       mov      bword ptr [rsp+0x58], rdx
+       mov      edx, dword ptr [rsp+0x218]
+       cmp      rdi, r11
+       jne      G_M27315_IG127
+       cmp      edx, 7
+       mov      gword ptr [rsp+0x78], r14
+       mov      dword ptr [rsp+0x1FC], r15d
+       mov      dword ptr [rsp+0xFC], edx
+       mov      r9, rax
+       mov      r14, gword ptr [rsp+0xC0]
+       jle      G_M27315_IG39
+       test     r9, r9
+       jne      SHORT G_M27315_IG113
+       jmp      SHORT G_M27315_IG114
+						;; size=195 bbWeight=0 PerfScore 0.00
+G_M27315_IG112:
+       mov      edx, dword ptr [rsp+0x10C]
+       jmp      G_M27315_IG33
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M27315_IG113:
+       mov      gword ptr [rsp+0xC0], r14
+       lea      r14, bword ptr [r9+0x10]
+       mov      bword ptr [rsp+0x50], r14
+       mov      gword ptr [rsp+0x70], r9
+       mov      r14d, dword ptr [r9+0x08]
+       mov      dword ptr [rsp+0xF8], r14d
+       jmp      SHORT G_M27315_IG115
+						;; size=36 bbWeight=0 PerfScore 0.00
+G_M27315_IG114:
+       mov      gword ptr [rsp+0xC0], r14
+       xor      r14, r14
+       mov      bword ptr [rsp+0x50], r14
+       xor      r14d, r14d
+       mov      dword ptr [rsp+0xF8], r14d
+       mov      gword ptr [rsp+0x70], r9
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M27315_IG115:
+       mov      r14d, dword ptr [rsp+0xFC]
+       cmp      r14d, dword ptr [rsp+0xF8]
+       jne      SHORT G_M27315_IG116
+       mov      r8d, dword ptr [rsp+0xF8]
+       mov      rcx, bword ptr [rsp+0x58]
+       mov      rdx, bword ptr [rsp+0x50]
+       call     [<unknown method>]
+       jmp      SHORT G_M27315_IG117
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M27315_IG116:
+       xor      r14d, r14d
+       mov      eax, r14d
+						;; size=6 bbWeight=0 PerfScore 0.00
+G_M27315_IG117:
+       test     eax, eax
+       mov      r9, gword ptr [rsp+0x70]
+       mov      r15d, dword ptr [rsp+0x1FC]
+       je       G_M27315_IG127
+       mov      r14, gword ptr [rsp+0xC0]
+       jmp      G_M27315_IG39
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M27315_IG118:
+       mov      r15d, dword ptr [rsp+0x1FC]
+       test     r15d, r15d
+       mov      dword ptr [rsp+0x200], ebp
+       mov      dword ptr [rsp+0x1FC], r15d
+       jl       G_M27315_IG53
+       mov      gword ptr [rsp+0xC0], r14
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      r14d, dword ptr [rsp+0x1FC]
+       mov      dword ptr [rsp+0x204], ecx
+       cmp      r14d, ecx
+       jae      G_M27315_IG200
+       mov      ebp, r14d
+       lea      rbp, [rbp+2*rbp]
+       lea      rbp, bword ptr [r8+8*rbp]
+       mov      bword ptr [rsp+0x38], rbp
+       mov      rbp, gword ptr [rbp]
        mov      rax, bword ptr [rsp+0x38]
        mov      rax, gword ptr [rax+0x08]
-       mov      r10, bword ptr [rsp+0x38]
-       mov      r10, qword ptr [r10+0x10]
-       mov      r11, bword ptr [rsp+0x220]
-       mov      bword ptr [rsp+0x60], r11
-       mov      r11d, dword ptr [rsp+0x228]
-       cmp      r14, r10
-       jne      G_M27315_IG125
-       cmp      r11d, 7
-       mov      gword ptr [rsp+0x80], r15
-       mov      dword ptr [rsp+0x210], r13d
-       mov      dword ptr [rsp+0x10C], r11d
-       mov      r8, rax
-       mov      r15, gword ptr [rsp+0xD0]
-       jle      G_M27315_IG38
-       test     r8, r8
-       jne      SHORT G_M27315_IG111
-       jmp      SHORT G_M27315_IG112
-						;; size=187 bbWeight=0 PerfScore 0.00
-G_M27315_IG110:
-       mov      r11d, dword ptr [rsp+0x11C]
-       jmp      G_M27315_IG32
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M27315_IG111:
-       mov      gword ptr [rsp+0xD0], r15
-       lea      r15, bword ptr [r8+0x10]
-       mov      bword ptr [rsp+0x58], r15
-       mov      gword ptr [rsp+0x78], r8
-       mov      r15d, dword ptr [r8+0x08]
-       mov      dword ptr [rsp+0x108], r15d
-       jmp      SHORT G_M27315_IG113
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M27315_IG112:
-       mov      gword ptr [rsp+0xD0], r15
-       xor      r15, r15
-       mov      bword ptr [rsp+0x58], r15
-       xor      r15d, r15d
-       mov      dword ptr [rsp+0x108], r15d
-       mov      gword ptr [rsp+0x78], r8
-						;; size=32 bbWeight=0 PerfScore 0.00
-G_M27315_IG113:
-       mov      r15d, dword ptr [rsp+0x10C]
-       cmp      r15d, dword ptr [rsp+0x108]
-       jne      SHORT G_M27315_IG114
-       mov      r8d, dword ptr [rsp+0x108]
-       mov      rcx, bword ptr [rsp+0x60]
-       mov      rdx, bword ptr [rsp+0x58]
-       call     [<unknown method>]
-       jmp      SHORT G_M27315_IG115
-						;; size=44 bbWeight=0 PerfScore 0.00
-G_M27315_IG114:
-       xor      r15d, r15d
-       mov      eax, r15d
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M27315_IG115:
-       test     eax, eax
-       mov      r8, gword ptr [rsp+0x78]
-       mov      r13d, dword ptr [rsp+0x210]
-       je       G_M27315_IG125
-       mov      r15, gword ptr [rsp+0xD0]
-       jmp      G_M27315_IG38
-						;; size=34 bbWeight=0 PerfScore 0.00
-G_M27315_IG116:
-       mov      r13d, dword ptr [rsp+0x210]
-       test     r13d, r13d
-       mov      dword ptr [rsp+0x214], ebp
-       mov      dword ptr [rsp+0x210], r13d
-       jl       G_M27315_IG52
-       mov      gword ptr [rsp+0xD0], r15
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      r15d, dword ptr [rsp+0x210]
-       cmp      r15d, edi
-       jae      G_M27315_IG198
-       mov      ebp, r15d
-       lea      rbp, [rbp+2*rbp]
-       lea      rbp, bword ptr [r9+8*rbp]
-       mov      bword ptr [rsp+0x40], rbp
-       mov      rbp, gword ptr [rbp]
-       mov      rax, bword ptr [rsp+0x40]
-       mov      rax, gword ptr [rax+0x08]
-       mov      r10, bword ptr [rsp+0x40]
-       mov      r10, qword ptr [r10+0x10]
-       mov      r11, bword ptr [rsp+0x220]
-       mov      bword ptr [rsp+0x50], r11
-       mov      r11d, dword ptr [rsp+0x228]
-       cmp      r14, r10
-       jne      SHORT G_M27315_IG118
-       cmp      r11d, 7
-       mov      gword ptr [rsp+0x80], rbp
-       mov      dword ptr [rsp+0x210], r15d
-       mov      dword ptr [rsp+0x104], r11d
-       mov      r8, rax
-       mov      r15, gword ptr [rsp+0xD0]
-       jle      SHORT G_M27315_IG117
-       mov      ebp, dword ptr [rsp+0x214]
-       test     r8, r8
-       jne      SHORT G_M27315_IG119
-       jmp      SHORT G_M27315_IG120
-						;; size=185 bbWeight=0 PerfScore 0.00
-G_M27315_IG117:
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG38
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M27315_IG118:
-       mov      gword ptr [rsp+0xC8], r13
-       mov      r13d, r15d
-       mov      ebp, dword ptr [rsp+0x214]
-       jmp      G_M27315_IG125
-						;; size=23 bbWeight=0 PerfScore 0.00
+       mov      r11, bword ptr [rsp+0x38]
+       mov      r11, qword ptr [r11+0x10]
+       mov      rdx, bword ptr [rsp+0x210]
+       mov      bword ptr [rsp+0x48], rdx
+       mov      edx, dword ptr [rsp+0x218]
+       cmp      rdi, r11
+       jne      SHORT G_M27315_IG120
+       cmp      edx, 7
+       mov      gword ptr [rsp+0x78], rbp
+       mov      dword ptr [rsp+0x1FC], r14d
+       mov      dword ptr [rsp+0xF4], edx
+       mov      r9, rax
+       mov      r14, gword ptr [rsp+0xC0]
+       jle      SHORT G_M27315_IG119
+       mov      ebp, dword ptr [rsp+0x200]
+       test     r9, r9
+       jne      SHORT G_M27315_IG121
+       jmp      SHORT G_M27315_IG122
+						;; size=186 bbWeight=0 PerfScore 0.00
 G_M27315_IG119:
-       mov      dword ptr [rsp+0x214], ebp
-       mov      gword ptr [rsp+0xD0], r15
-       lea      r15, bword ptr [r8+0x10]
-       mov      gword ptr [rsp+0x78], r8
-       mov      ebp, dword ptr [r8+0x08]
-       mov      bword ptr [rsp+0x48], r15
-       jmp      SHORT G_M27315_IG121
-						;; size=35 bbWeight=0 PerfScore 0.00
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG39
+						;; size=13 bbWeight=0 PerfScore 0.00
 G_M27315_IG120:
-       mov      dword ptr [rsp+0x214], ebp
-       mov      gword ptr [rsp+0xD0], r15
-       xor      r15, r15
-       mov      bword ptr [rsp+0x48], r15
-       xor      ebp, ebp
-       mov      gword ptr [rsp+0x78], r8
-						;; size=30 bbWeight=0 PerfScore 0.00
+       mov      gword ptr [rsp+0xB8], r15
+       mov      r15d, r14d
+       mov      ebp, dword ptr [rsp+0x200]
+       jmp      G_M27315_IG127
+						;; size=23 bbWeight=0 PerfScore 0.00
 G_M27315_IG121:
-       mov      r15d, dword ptr [rsp+0x104]
-       cmp      r15d, ebp
-       jne      SHORT G_M27315_IG122
-       mov      r8d, ebp
-       mov      rcx, bword ptr [rsp+0x50]
-       mov      rdx, bword ptr [rsp+0x48]
-       call     [<unknown method>]
+       mov      dword ptr [rsp+0x200], ebp
+       mov      gword ptr [rsp+0xC0], r14
+       lea      r14, bword ptr [r9+0x10]
+       mov      gword ptr [rsp+0x70], r9
+       mov      ebp, dword ptr [r9+0x08]
+       mov      bword ptr [rsp+0x40], r14
        jmp      SHORT G_M27315_IG123
-						;; size=34 bbWeight=0 PerfScore 0.00
+						;; size=35 bbWeight=0 PerfScore 0.00
 G_M27315_IG122:
+       mov      dword ptr [rsp+0x200], ebp
+       mov      gword ptr [rsp+0xC0], r14
+       xor      r14, r14
+       mov      bword ptr [rsp+0x40], r14
+       xor      ebp, ebp
+       mov      gword ptr [rsp+0x70], r9
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M27315_IG123:
+       mov      r14d, dword ptr [rsp+0xF4]
+       cmp      r14d, ebp
+       jne      SHORT G_M27315_IG124
+       mov      r8d, ebp
+       mov      rcx, bword ptr [rsp+0x48]
+       mov      rdx, bword ptr [rsp+0x40]
+       call     [<unknown method>]
+       jmp      SHORT G_M27315_IG125
+						;; size=34 bbWeight=0 PerfScore 0.00
+G_M27315_IG124:
        xor      ebp, ebp
        mov      eax, ebp
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M27315_IG123:
-       test     eax, eax
-       mov      gword ptr [rsp+0xC8], r13
-       mov      ebp, dword ptr [rsp+0x214]
-       mov      r8, gword ptr [rsp+0x78]
-       je       SHORT G_M27315_IG124
-       mov      r15, gword ptr [rsp+0xD0]
-       jmp      G_M27315_IG38
-						;; size=37 bbWeight=0 PerfScore 0.00
-G_M27315_IG124:
-       mov      r13d, dword ptr [rsp+0x210]
-						;; size=8 bbWeight=0 PerfScore 0.00
 G_M27315_IG125:
-       dec      r13d
-       mov      dword ptr [rsp+0x210], r13d
-       mov      r9, bword ptr [rsp+0x88]
-       mov      r11d, dword ptr [rsp+0x11C]
-       mov      r15, gword ptr [rsp+0xD0]
-       jmp      G_M27315_IG32
-						;; size=40 bbWeight=0 PerfScore 0.00
+       test     eax, eax
+       mov      gword ptr [rsp+0xB8], r15
+       mov      ebp, dword ptr [rsp+0x200]
+       mov      r9, gword ptr [rsp+0x70]
+       je       SHORT G_M27315_IG126
+       mov      r14, gword ptr [rsp+0xC0]
+       jmp      G_M27315_IG39
+						;; size=37 bbWeight=0 PerfScore 0.00
 G_M27315_IG126:
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      rcx, bword ptr [rsp+0x220]
-       mov      eax, dword ptr [rsp+0x228]
-       mov      r9, gword ptr [rsp+0x218]
-       mov      r9, gword ptr [r9+0x70]
-       test     r9, r9
-       je       SHORT G_M27315_IG127
-       lea      r11, bword ptr [r9+0x10]
-       mov      r9d, dword ptr [r9+0x08]
-       jmp      SHORT G_M27315_IG128
-						;; size=50 bbWeight=0 PerfScore 0.00
+       mov      r15d, dword ptr [rsp+0x1FC]
+						;; size=8 bbWeight=0 PerfScore 0.00
 G_M27315_IG127:
-       xor      r11, r11
-       xor      r9d, r9d
-						;; size=6 bbWeight=0 PerfScore 0.00
+       dec      r15d
+       mov      dword ptr [rsp+0x1FC], r15d
+       mov      ecx, dword ptr [rsp+0x204]
+       mov      edx, dword ptr [rsp+0x10C]
+       mov      r8, bword ptr [rsp+0x80]
+       mov      r14, gword ptr [rsp+0xC0]
+       jmp      G_M27315_IG33
+						;; size=46 bbWeight=0 PerfScore 0.00
 G_M27315_IG128:
-       cmp      eax, r9d
-       jne      SHORT G_M27315_IG130
-       mov      r8d, r9d
-       mov      rdx, r11
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      rcx, bword ptr [rsp+0x210]
+       mov      r8d, dword ptr [rsp+0x218]
+       mov      rdx, gword ptr [rsp+0x208]
+       mov      rdx, gword ptr [rdx+0x70]
+       test     rdx, rdx
+       je       SHORT G_M27315_IG129
+       lea      rax, bword ptr [rdx+0x10]
+       mov      edx, dword ptr [rdx+0x08]
+       jmp      SHORT G_M27315_IG130
+						;; size=50 bbWeight=0 PerfScore 0.00
+G_M27315_IG129:
+       xor      rax, rax
+       xor      edx, edx
+						;; size=4 bbWeight=0 PerfScore 0.00
+G_M27315_IG130:
+       cmp      r8d, edx
+       jne      SHORT G_M27315_IG132
+       mov      r8d, edx
+       mov      rdx, rax
        call     [<unknown method>]
        test     eax, eax
-       je       SHORT G_M27315_IG129
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG56
-						;; size=34 bbWeight=0 PerfScore 0.00
-G_M27315_IG129:
-						;; size=0 bbWeight=0 PerfScore 0.00
-G_M27315_IG130:
-       lea      rcx, [rsp+0x220]
-       call     [System.ReadOnlySpan`1[ubyte]:ToArray():ubyte[]:this]
-       mov      rbp, rax
-       mov      gword ptr [rsp+0xC8], r13
-       mov      rdi, gword ptr [rsp+0xB8]
+       je       SHORT G_M27315_IG131
+       mov      gword ptr [rsp+0xB8], r15
        jmp      G_M27315_IG57
-						;; size=38 bbWeight=0 PerfScore 0.00
+						;; size=34 bbWeight=0 PerfScore 0.00
 G_M27315_IG131:
-       mov      rdx, gword ptr [rsp+0xB0]
-       mov      ecx, dword ptr [rdx+0x08]
-       cmp      ecx, 64
-       jge      G_M27315_IG61
-       jmp      G_M27315_IG59
-						;; size=25 bbWeight=0.00 PerfScore 0.00
+						;; size=0 bbWeight=0 PerfScore 0.00
 G_M27315_IG132:
+       lea      rcx, [rsp+0x210]
+       call     [System.ReadOnlySpan`1[ubyte]:ToArray():ubyte[]:this]
+       mov      rcx, rax
+       mov      gword ptr [rsp+0xA8], rcx
+       mov      gword ptr [rsp+0xB8], r15
+       mov      rbp, gword ptr [rsp+0xB0]
+       jmp      G_M27315_IG58
+						;; size=46 bbWeight=0 PerfScore 0.00
+G_M27315_IG133:
+       mov      r8, gword ptr [rsp+0xA0]
+       mov      ecx, dword ptr [r8+0x08]
+       cmp      ecx, 64
+       jge      G_M27315_IG62
+       jmp      G_M27315_IG60
+						;; size=26 bbWeight=0.00 PerfScore 0.00
+G_M27315_IG134:
        mov      rcx, 0xD1FFAB1E      ; System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder
        call     CORINFO_HELP_NEWSFAST
        mov      rcx, rax
-       mov      gword ptr [rsp+0x98], rcx
-       mov      rdx, gword ptr [rsp+0xB0]
+       mov      gword ptr [rsp+0x88], rcx
+       mov      rdx, gword ptr [rsp+0xA0]
        call     [System.Text.Json.Serialization.Metadata.PropertyRefCacheBuilder:.ctor(System.Text.Json.Serialization.Metadata.PropertyRef[]):this]
-       mov      rcx, bword ptr [rsp+0xA0]
-       mov      rdx, gword ptr [rsp+0x98]
+       mov      rcx, bword ptr [rsp+0x90]
+       mov      rdx, gword ptr [rsp+0x88]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov      rcx, gword ptr [rsp+0x98]
-       jmp      G_M27315_IG60
+       mov      rcx, gword ptr [rsp+0x88]
+       jmp      G_M27315_IG61
 						;; size=74 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG133:
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      rdi, gword ptr [rsp+0xB8]
-       cmp      dword ptr [rdi+0x10C], 1
-       jne      SHORT G_M27315_IG134
+G_M27315_IG135:
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      rbp, gword ptr [rsp+0xB0]
+       cmp      dword ptr [rbp+0x10C], 1
+       jne      SHORT G_M27315_IG136
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rcx, gword ptr [rcx]
-       mov      bword ptr [rsp+0xF0], r12
-       mov      esi, dword ptr [rsp+0x124]
-       mov      dword ptr [rsp+0xF8], esi
-       lea      rdx, [rsp+0xF0]
+       mov      bword ptr [rsp+0xE0], r12
+       mov      dword ptr [rsp+0xE8], r13d
+       lea      rdx, [rsp+0xE0]
        call     [System.Text.Encoding:GetString(System.ReadOnlySpan`1[ubyte]):System.String:this]
        mov      rdx, rax
-       mov      rcx, gword ptr [rdi+0xB8]
+       mov      rcx, gword ptr [rbp+0xB8]
        call     [System.Text.Json.ThrowHelper:ThrowJsonException_UnmappedJsonProperty(System.Type,System.String)]
        int3     
-						;; size=91 bbWeight=0 PerfScore 0.00
-G_M27315_IG134:
-       mov      rdi, gword ptr [rdi+0x90]
-       test     rdi, rdi
-       je       SHORT G_M27315_IG135
-       cmp      gword ptr [rdi+0x20], 0
-       je       SHORT G_M27315_IG135
-       cmp      gword ptr [rdi+0x28], 0
-       je       SHORT G_M27315_IG135
+						;; size=85 bbWeight=0 PerfScore 0.00
+G_M27315_IG136:
+       mov      rbp, gword ptr [rbp+0x90]
+       test     rbp, rbp
+       je       SHORT G_M27315_IG137
+       cmp      gword ptr [rbp+0x20], 0
+       je       SHORT G_M27315_IG137
+       cmp      gword ptr [rbp+0x28], 0
+       je       SHORT G_M27315_IG137
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rcx, gword ptr [rcx]
-       mov      bword ptr [rsp+0xF0], r12
-       mov      ebp, dword ptr [rsp+0x124]
-       mov      dword ptr [rsp+0xF8], ebp
-       lea      rdx, [rsp+0xF0]
+       mov      bword ptr [rsp+0xE0], r12
+       mov      dword ptr [rsp+0xE8], r13d
+       lea      rdx, [rsp+0xE0]
        call     [System.Text.Encoding:GetString(System.ReadOnlySpan`1[ubyte]):System.String:this]
        lea      rcx, bword ptr [rsi+0x40]
        mov      rdx, rax
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov      rcx, r13
-       mov      rdx, rdi
-       mov      r8, gword ptr [rsp+0x2D8]
+       mov      rcx, r15
+       mov      rdx, rbp
+       mov      r8, gword ptr [rsp+0x2C8]
        call     [System.Text.Json.JsonSerializer:CreateExtensionDataProperty(System.Object,System.Text.Json.Serialization.Metadata.JsonPropertyInfo,System.Text.Json.JsonSerializerOptions)]
-       mov      ebp, 1
-       mov      dword ptr [rsp+0x25C], ebp
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG41
-						;; size=132 bbWeight=0 PerfScore 0.00
-G_M27315_IG135:
+       mov      edi, 1
+       mov      dword ptr [rsp+0x24C], edi
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG42
+						;; size=126 bbWeight=0 PerfScore 0.00
+G_M27315_IG137:
        mov      rcx, 0xD1FFAB1E      ; System.Text.Json.Serialization.Metadata.JsonPropertyInfo
        call     CORINFO_HELP_GET_GCSTATIC_BASE
        mov      rcx, 0xD1FFAB1E      ; data for <unknown class>:<unknown field>
-       mov      rdi, gword ptr [rcx]
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG41
+       mov      rbp, gword ptr [rcx]
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG42
 						;; size=41 bbWeight=0 PerfScore 0.00
-G_M27315_IG136:
+G_M27315_IG138:
        mov      rcx, rbx
        call     [<unknown method>]
-       jmp      G_M27315_IG43
+       jmp      G_M27315_IG44
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M27315_IG137:
+G_M27315_IG139:
        cmp      byte  ptr [rbx+0x46], 0
-       jne      G_M27315_IG44
+       jne      G_M27315_IG45
        xor      r9, r9
-       mov      bword ptr [rsp+0xF0], r9
+       mov      bword ptr [rsp+0xE0], r9
        xor      r9d, r9d
-       mov      dword ptr [rsp+0xF8], r9d
-       lea      r9, [rsp+0xF0]
+       mov      dword ptr [rsp+0xE8], r9d
+       lea      r9, [rsp+0xE0]
        mov      rcx, rbx
        mov      edx, 32
        xor      r8d, r8d
        call     [System.Text.Json.ThrowHelper:ThrowJsonReaderException(byref,int,ubyte,System.ReadOnlySpan`1[ubyte])]
        int3     
 						;; size=58 bbWeight=0 PerfScore 0.00
-G_M27315_IG138:
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      rcx, rdi
-       mov      rdx, r13
+G_M27315_IG140:
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      rcx, rbp
+       mov      rdx, r15
        mov      r8, rsi
        mov      r9, rbx
        call     [System.Text.Json.Serialization.Metadata.JsonPropertyInfo:ReadJsonAndAddExtensionProperty(System.Object,byref,byref):ubyte:this]
-       mov      gword ptr [rsp+0xC8], r13
+       mov      gword ptr [rsp+0xB8], r15
        jmp      G_M27315_IG13
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M27315_IG139:
-       mov      rcx, rbx
-       call     [<unknown method>]
-       jmp      G_M27315_IG65
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M27315_IG140:
-       cmp      byte  ptr [rbx+0x46], 0
-       jne      G_M27315_IG66
-       xor      r9, r9
-       mov      bword ptr [rsp+0xF0], r9
-       xor      r9d, r9d
-       mov      dword ptr [rsp+0xF8], r9d
-       lea      r9, [rsp+0xF0]
-       mov      rcx, rbx
-       mov      edx, 32
-       xor      r8d, r8d
-       call     [System.Text.Json.ThrowHelper:ThrowJsonReaderException(byref,int,ubyte,System.ReadOnlySpan`1[ubyte])]
-       int3     
-						;; size=58 bbWeight=0 PerfScore 0.00
 G_M27315_IG141:
        mov      rcx, rbx
        call     [<unknown method>]
-       jmp      G_M27315_IG70
+       jmp      G_M27315_IG66
 						;; size=14 bbWeight=0 PerfScore 0.00
 G_M27315_IG142:
        cmp      byte  ptr [rbx+0x46], 0
-       jne      G_M27315_IG71
+       jne      G_M27315_IG67
        xor      r9, r9
-       mov      bword ptr [rsp+0xF0], r9
+       mov      bword ptr [rsp+0xE0], r9
        xor      r9d, r9d
-       mov      dword ptr [rsp+0xF8], r9d
-       lea      r9, [rsp+0xF0]
+       mov      dword ptr [rsp+0xE8], r9d
+       lea      r9, [rsp+0xE0]
        mov      rcx, rbx
        mov      edx, 32
        xor      r8d, r8d
@@ -3390,7 +3374,26 @@ G_M27315_IG142:
        int3     
 						;; size=58 bbWeight=0 PerfScore 0.00
 G_M27315_IG143:
-       lea      rcx, bword ptr [rsp+0x150]
+       mov      rcx, rbx
+       call     [<unknown method>]
+       jmp      G_M27315_IG71
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M27315_IG144:
+       cmp      byte  ptr [rbx+0x46], 0
+       jne      G_M27315_IG72
+       xor      r9, r9
+       mov      bword ptr [rsp+0xE0], r9
+       xor      r9d, r9d
+       mov      dword ptr [rsp+0xE8], r9d
+       lea      r9, [rsp+0xE0]
+       mov      rcx, rbx
+       mov      edx, 32
+       xor      r8d, r8d
+       call     [System.Text.Json.ThrowHelper:ThrowJsonReaderException(byref,int,ubyte,System.ReadOnlySpan`1[ubyte])]
+       int3     
+						;; size=58 bbWeight=0 PerfScore 0.00
+G_M27315_IG145:
+       lea      rcx, bword ptr [rsp+0x138]
        mov      rdx, rbx
        cmp      byte  ptr [rdx], dl
        mov      r8d, 192
@@ -3404,140 +3407,140 @@ G_M27315_IG143:
        jne      G_M27315_IG13
        mov      rcx, rbx
        cmp      byte  ptr [rcx], cl
-       lea      rdx, [rsp+0x150]
+       lea      rdx, [rsp+0x138]
        mov      r8d, 192
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
        jmp      G_M27315_IG13
 						;; size=83 bbWeight=0 PerfScore 0.00
-G_M27315_IG144:
-       mov      rcx, gword ptr [r15+0xB0]
+G_M27315_IG146:
+       mov      rcx, gword ptr [r14+0xB0]
        mov      rcx, gword ptr [rcx+0x20]
-       mov      rdx, gword ptr [r15+0xB8]
+       mov      rdx, gword ptr [r14+0xB8]
        call     [System.Text.Json.ThrowHelper:ThrowInvalidOperationException_NoMetadataForTypeProperties(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver,System.Type)]
        int3     
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG145:
-       mov      r13, gword ptr [rsp+0xC8]
-       mov      rdx, r13
+G_M27315_IG147:
+       mov      r15, gword ptr [rsp+0xB8]
+       mov      rdx, r15
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
-       mov      gword ptr [rsp+0xC8], r13
-       jmp      G_M27315_IG78
+       mov      gword ptr [rsp+0xB8], r15
+       jmp      G_M27315_IG79
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M27315_IG146:
-       mov      rcx, gword ptr [rbx+0x48]
+G_M27315_IG148:
+       mov      rcx, gword ptr [rbp+0x48]
        cmp      dword ptr [rcx], ecx
        call     [System.Collections.BitArray:HasAllSet():ubyte:this]
        test     eax, eax
-       jne      G_M27315_IG79
-       mov      rdx, gword ptr [rbx+0x48]
-       mov      rcx, r15
+       jne      G_M27315_IG80
+       mov      rdx, gword ptr [rbp+0x48]
+       mov      rcx, r14
        call     [System.Text.Json.ThrowHelper:ThrowJsonException_JsonRequiredPropertyMissing(System.Text.Json.Serialization.Metadata.JsonTypeInfo,System.Collections.BitArray)]
        int3     
 						;; size=34 bbWeight=0 PerfScore 0.00
-G_M27315_IG147:
-       lea      rdx, bword ptr [rsi+0x30]
-       mov      rcx, r15
-       call     [System.Text.Json.Serialization.Metadata.JsonTypeInfo:UpdateUtf8PropertyCache(byref):this]
-       jmp      G_M27315_IG80
-						;; size=18 bbWeight=0.00 PerfScore 0.00
-G_M27315_IG148:
-       cmp      byte  ptr [rsi+0x8A], 0
-       jne      SHORT G_M27315_IG151
-       cmp      byte  ptr [rbx+0x28], 1
-       je       SHORT G_M27315_IG150
-						;; size=15 bbWeight=0 PerfScore 0.00
 G_M27315_IG149:
+       lea      rdx, bword ptr [rsi+0x30]
+       mov      rcx, r14
+       call     [System.Text.Json.Serialization.Metadata.JsonTypeInfo:UpdateUtf8PropertyCache(byref):this]
+       jmp      G_M27315_IG81
+						;; size=18 bbWeight=0.00 PerfScore 0.00
+G_M27315_IG150:
+       cmp      byte  ptr [rsi+0x8A], 0
+       jne      SHORT G_M27315_IG153
+       cmp      byte  ptr [rbx+0x28], 1
+       je       SHORT G_M27315_IG152
+						;; size=15 bbWeight=0 PerfScore 0.00
+G_M27315_IG151:
        mov      rcx, gword ptr [rdi+0x20]
        call     [System.Text.Json.ThrowHelper:ThrowJsonException_DeserializeUnableToConvertValue(System.Type)]
        int3     
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M27315_IG150:
+G_M27315_IG152:
        mov      byte  ptr [rsi+0x8A], 1
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M27315_IG151:
+G_M27315_IG153:
        cmp      byte  ptr [rsi+0x8B], 0
-       je       SHORT G_M27315_IG155
+       je       G_M27315_IG157
        cmp      byte  ptr [rsi+0x8A], 2
-       jae      SHORT G_M27315_IG155
+       jae      SHORT G_M27315_IG157
        mov      rcx, rdi
-       mov      rdx, r15
+       mov      rdx, r14
        mov      r8, rbx
        mov      r9, rsi
        call     [<unknown method>]
        test     eax, eax
-       je       G_M27315_IG196
+       je       G_M27315_IG198
        cmp      byte  ptr [rsi+0x8D], 4
-       je       SHORT G_M27315_IG152
+       je       SHORT G_M27315_IG154
        mov      byte  ptr [rsi+0x8A], 2
-       jmp      SHORT G_M27315_IG155
-						;; size=62 bbWeight=0 PerfScore 0.00
-G_M27315_IG152:
+       jmp      SHORT G_M27315_IG157
+						;; size=66 bbWeight=0 PerfScore 0.00
+G_M27315_IG154:
        mov      rcx, qword ptr [rdi]
        mov      rdx, qword ptr [rcx+0x30]
        mov      rdx, qword ptr [rdx+0x18]
        mov      rax, qword ptr [rdx+0x18]
        test     rax, rax
-       je       SHORT G_M27315_IG153
+       je       SHORT G_M27315_IG155
        mov      rcx, rax
-       jmp      SHORT G_M27315_IG154
+       jmp      SHORT G_M27315_IG156
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG153:
+G_M27315_IG155:
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M27315_IG154:
+G_M27315_IG156:
        mov      rdx, rsi
        call     [<unknown method>]
+       mov      rcx, bword ptr [rsp+0x2D8]
        mov      rdx, rax
-       mov      rcx, r14
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       jmp      G_M27315_IG84
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG155:
+       jmp      G_M27315_IG85
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M27315_IG157:
        test     byte  ptr [rsi+0x8D], 8
-       je       G_M27315_IG157
+       je       G_M27315_IG159
        cmp      byte  ptr [rsi+0x8E], 1
-       je       G_M27315_IG157
+       je       G_M27315_IG159
        mov      rcx, rdi
-       mov      rdx, r15
+       mov      rdx, r14
        mov      r8, rsi
        call     [System.Text.Json.Serialization.JsonConverter:ResolvePolymorphicConverter(System.Text.Json.Serialization.Metadata.JsonTypeInfo,byref):System.Text.Json.Serialization.JsonConverter:this]
-       mov      r13, rax
-       test     r13, r13
-       je       G_M27315_IG157
-       mov      rcx, r13
-       mov      rax, qword ptr [r13]
+       mov      r15, rax
+       test     r15, r15
+       je       G_M27315_IG159
+       mov      rcx, r15
+       mov      rax, qword ptr [r15]
        mov      rax, qword ptr [rax+0x40]
        call     [rax+0x20]<unknown method>
        mov      r8, rax
        mov      bword ptr [rsp+0x20], rsi
-       lea      rdx, [rsp+0x268]
+       lea      rdx, [rsp+0x258]
        mov      qword ptr [rsp+0x28], rdx
        mov      rdx, rbx
-       mov      rcx, r13
+       mov      rcx, r15
        mov      r9, rbp
-       mov      rax, qword ptr [r13]
+       mov      rax, qword ptr [r15]
        mov      rax, qword ptr [rax+0x50]
        call     [rax+0x10]<unknown method>
-       mov      r15d, eax
+       mov      r14d, eax
        mov      rcx, qword ptr [rdi]
        mov      rcx, qword ptr [rcx+0x30]
        mov      rcx, qword ptr [rcx+0x18]
        mov      rcx, qword ptr [rcx]
-       mov      rdx, gword ptr [rsp+0x268]
+       mov      rdx, gword ptr [rsp+0x258]
        call     CORINFO_HELP_CHKCASTANY
+       mov      rcx, bword ptr [rsp+0x2D8]
        mov      rdx, rax
-       mov      rcx, r14
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        mov      rcx, rsi
-       mov      edx, r15d
+       mov      edx, r14d
        call     [System.Text.Json.ReadStack:ExitPolymorphicConverter(ubyte):this]
-       movzx    rax, r15b
-						;; size=165 bbWeight=0 PerfScore 0.00
-G_M27315_IG156:
-       add      rsp, 632
+       movzx    rax, r14b
+						;; size=168 bbWeight=0 PerfScore 0.00
+G_M27315_IG158:
+       add      rsp, 616
        pop      rbx
        pop      rbp
        pop      rsi
@@ -3548,352 +3551,353 @@ G_M27315_IG156:
        pop      r15
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M27315_IG157:
+G_M27315_IG159:
        cmp      byte  ptr [rsi+0x8A], 4
-       jae      G_M27315_IG167
+       jae      G_M27315_IG169
        cmp      byte  ptr [rsi+0x8B], 0
-       je       SHORT G_M27315_IG158
+       je       SHORT G_M27315_IG160
        mov      rcx, rsi
        call     [System.Text.Json.JsonSerializer:ValidateMetadataForObjectConverter(byref)]
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M27315_IG158:
+G_M27315_IG160:
        cmp      byte  ptr [rsi+0x8D], 4
-       je       G_M27315_IG164
+       je       G_M27315_IG166
        mov      rcx, rsi
        call     [System.Text.Json.ReadStack:get_ParentProperty():System.Text.Json.Serialization.Metadata.JsonPropertyInfo:this]
        test     rax, rax
-       je       SHORT G_M27315_IG159
+       je       SHORT G_M27315_IG161
        mov      rcx, rax
        mov      rdx, rsi
        call     [System.Text.Json.Serialization.Metadata.JsonPropertyInfo:TryGetPrePopulatedValue(byref):ubyte:this]
        test     eax, eax
-       je       SHORT G_M27315_IG159
-       mov      r13, gword ptr [rsi+0x50]
-       jmp      SHORT G_M27315_IG161
+       je       SHORT G_M27315_IG161
+       mov      r15, gword ptr [rsi+0x50]
+       jmp      SHORT G_M27315_IG163
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M27315_IG159:
-       cmp      gword ptr [r15+0x58], 0
-       jne      SHORT G_M27315_IG160
-       mov      rcx, r15
+G_M27315_IG161:
+       cmp      gword ptr [r14+0x58], 0
+       jne      SHORT G_M27315_IG162
+       mov      rcx, r14
        mov      rdx, rbx
        mov      r8, rsi
        call     [System.Text.Json.ThrowHelper:ThrowNotSupportedException_DeserializeNoConstructor(System.Text.Json.Serialization.Metadata.JsonTypeInfo,byref,byref)]
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M27315_IG160:
-       mov      rax, gword ptr [r15+0x58]
+G_M27315_IG162:
+       mov      rax, gword ptr [r14+0x58]
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
-       mov      r13, rax
+       mov      r15, rax
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M27315_IG161:
+G_M27315_IG163:
        test     byte  ptr [rsi+0x8D], 2
-       je       SHORT G_M27315_IG162
+       je       SHORT G_M27315_IG164
        mov      rcx, gword ptr [rsi+0x08]
        mov      rdx, gword ptr [rsi+0x10]
-       mov      r8, r13
+       mov      r8, r15
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x40]
        call     [rax+0x20]<unknown method>
        xor      rdx, rdx
        mov      gword ptr [rsi+0x10], rdx
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M27315_IG162:
-       mov      rax, gword ptr [r15+0x38]
+G_M27315_IG164:
+       mov      rax, gword ptr [r14+0x38]
        test     rax, rax
-       je       SHORT G_M27315_IG163
-       mov      rdx, r13
+       je       SHORT G_M27315_IG165
+       mov      rdx, r15
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M27315_IG163:
+G_M27315_IG165:
        lea      rcx, bword ptr [rsi+0x50]
-       mov      rdx, r13
+       mov      rdx, r15
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        mov      byte  ptr [rsi+0x8A], 4
-       lea      r12, bword ptr [rsi+0x30]
-       cmp      dword ptr [r15+0x104], 0
-       jle      G_M27315_IG168
+       lea      r13, bword ptr [rsi+0x30]
+       cmp      dword ptr [r14+0x104], 0
+       jle      G_M27315_IG170
        mov      rcx, 0xD1FFAB1E      ; System.Collections.BitArray
        call     CORINFO_HELP_NEWSFAST
-       mov      gword ptr [rsp+0x90], rax
-       mov      edx, dword ptr [r15+0x104]
-       mov      rcx, rax
+       mov      r12, rax
+       mov      edx, dword ptr [r14+0x104]
+       mov      rcx, r12
        xor      r8d, r8d
        call     [System.Collections.BitArray:.ctor(int,ubyte):this]
-       lea      rcx, bword ptr [r12+0x48]
-       mov      rdx, gword ptr [rsp+0x90]
+       lea      rcx, bword ptr [r13+0x48]
+       mov      rdx, r12
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       jmp      SHORT G_M27315_IG168
-						;; size=99 bbWeight=0 PerfScore 0.00
-G_M27315_IG164:
+       jmp      SHORT G_M27315_IG170
+						;; size=88 bbWeight=0 PerfScore 0.00
+G_M27315_IG166:
        mov      rcx, qword ptr [rdi]
        mov      rdx, qword ptr [rcx+0x30]
        mov      rdx, qword ptr [rdx+0x18]
        mov      rax, qword ptr [rdx+0x18]
        test     rax, rax
-       je       SHORT G_M27315_IG165
+       je       SHORT G_M27315_IG167
        mov      rcx, rax
-       jmp      SHORT G_M27315_IG166
+       jmp      SHORT G_M27315_IG168
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG165:
+G_M27315_IG167:
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M27315_IG166:
+G_M27315_IG168:
        mov      rdx, rsi
        call     [<unknown method>]
+       mov      rcx, bword ptr [rsp+0x2D8]
        mov      rdx, rax
-       mov      rcx, r14
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       jmp      G_M27315_IG84
-						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG167:
-       mov      r13, gword ptr [rsi+0x50]
+       jmp      G_M27315_IG85
+						;; size=30 bbWeight=0 PerfScore 0.00
+G_M27315_IG169:
+       mov      r15, gword ptr [rsi+0x50]
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M27315_IG168:
+G_M27315_IG170:
        cmp      byte  ptr [rsi+0x88], 0
-       jne      SHORT G_M27315_IG169
+       jne      SHORT G_M27315_IG171
        mov      rcx, rbx
        call     [System.Text.Json.Utf8JsonReader:Read():ubyte:this]
        test     eax, eax
-       je       G_M27315_IG195
+       je       G_M27315_IG197
        mov      byte  ptr [rsi+0x88], 1
 						;; size=33 bbWeight=0 PerfScore 0.00
-G_M27315_IG169:
-       cmp      byte  ptr [rsi+0x88], 2
-       jae      G_M27315_IG187
-       cmp      byte  ptr [rbx+0x28], 2
-       je       G_M27315_IG184
-       cmp      byte  ptr [r15+0x113], 0
-       jne      G_M27315_IG183
-       cmp      byte  ptr [rbx+0x2D], 0
-       jne      SHORT G_M27315_IG170
-       mov      r12, bword ptr [rbx+0x98]
-       mov      eax, dword ptr [rbx+0xA0]
-       jmp      SHORT G_M27315_IG173
-						;; size=58 bbWeight=0 PerfScore 0.00
-G_M27315_IG170:
-       vmovdqu  xmm0, xmmword ptr [rbx+0xA8]
-       vmovdqu  xmmword ptr [rsp+0x128], xmm0
-       mov      rcx, qword ptr [rbx+0xB8]
-       mov      qword ptr [rsp+0x138], rcx
-						;; size=32 bbWeight=0 PerfScore 0.00
 G_M27315_IG171:
-       lea      rcx, [rsp+0x128]
+       cmp      byte  ptr [rsi+0x88], 2
+       jae      G_M27315_IG189
+       cmp      byte  ptr [rbx+0x28], 2
+       je       G_M27315_IG186
+       cmp      byte  ptr [r14+0x113], 0
+       jne      G_M27315_IG185
+       cmp      byte  ptr [rbx+0x2D], 0
+       jne      SHORT G_M27315_IG172
+       mov      r13, bword ptr [rbx+0x98]
+       mov      r12d, dword ptr [rbx+0xA0]
+       jmp      SHORT G_M27315_IG175
+						;; size=59 bbWeight=0 PerfScore 0.00
+G_M27315_IG172:
+       vmovdqu  xmm0, xmmword ptr [rbx+0xA8]
+       vmovdqu  xmmword ptr [rsp+0x110], xmm0
+       mov      rcx, qword ptr [rbx+0xB8]
+       mov      qword ptr [rsp+0x120], rcx
+						;; size=32 bbWeight=0 PerfScore 0.00
+G_M27315_IG173:
+       lea      rcx, [rsp+0x110]
        call     [System.Buffers.BuffersExtensions:ToArray[ubyte](byref):ubyte[]]
        test     rax, rax
-       je       SHORT G_M27315_IG172
-       lea      r12, bword ptr [rax+0x10]
-       mov      eax, dword ptr [rax+0x08]
-       jmp      SHORT G_M27315_IG173
-						;; size=28 bbWeight=0 PerfScore 0.00
-G_M27315_IG172:
-       xor      r12, r12
-       xor      eax, eax
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M27315_IG173:
-       cmp      byte  ptr [rbx+0x2E], 0
-       jne      SHORT G_M27315_IG174
-       mov      bword ptr [rsp+0x140], r12
-       mov      dword ptr [rsp+0x148], eax
+       je       SHORT G_M27315_IG174
+       lea      r13, bword ptr [rax+0x10]
+       mov      r12d, dword ptr [rax+0x08]
        jmp      SHORT G_M27315_IG175
-						;; size=23 bbWeight=0 PerfScore 0.00
+						;; size=29 bbWeight=0 PerfScore 0.00
 G_M27315_IG174:
-       mov      bword ptr [rsp+0xF0], r12
-       mov      dword ptr [rsp+0xF8], eax
-       lea      rdx, [rsp+0xF0]
-       lea      rcx, [rsp+0x140]
-       call     [System.Text.Json.JsonReaderHelper:GetUnescapedSpan(System.ReadOnlySpan`1[ubyte]):System.ReadOnlySpan`1[ubyte]]
-						;; size=37 bbWeight=0 PerfScore 0.00
+       xor      r13, r13
+       xor      r12d, r12d
+						;; size=6 bbWeight=0 PerfScore 0.00
 G_M27315_IG175:
+       cmp      byte  ptr [rbx+0x2E], 0
+       jne      SHORT G_M27315_IG176
+       mov      bword ptr [rsp+0x128], r13
+       mov      dword ptr [rsp+0x130], r12d
+       jmp      SHORT G_M27315_IG177
+						;; size=24 bbWeight=0 PerfScore 0.00
+G_M27315_IG176:
+       mov      bword ptr [rsp+0xE0], r13
+       mov      dword ptr [rsp+0xE8], r12d
+       lea      rdx, [rsp+0xE0]
+       lea      rcx, [rsp+0x128]
+       call     [System.Text.Json.JsonReaderHelper:GetUnescapedSpan(System.ReadOnlySpan`1[ubyte]):System.ReadOnlySpan`1[ubyte]]
+						;; size=38 bbWeight=0 PerfScore 0.00
+G_M27315_IG177:
        cmp      byte  ptr [rsi+0x8B], 0
-       je       G_M27315_IG181
+       je       G_M27315_IG183
        lea      rcx, bword ptr [rsi+0x30]
        cmp      byte  ptr [rcx+0x5E], 1
-       je       SHORT G_M27315_IG176
+       je       SHORT G_M27315_IG178
        mov      rdx, gword ptr [rcx+0x28]
-       jmp      SHORT G_M27315_IG177
+       jmp      SHORT G_M27315_IG179
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M27315_IG176:
+G_M27315_IG178:
        mov      rdx, gword ptr [rcx+0x30]
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M27315_IG177:
-       vmovdqu  xmm0, xmmword ptr [rsp+0x140]
-       vmovdqu  xmmword ptr [rsp+0xF0], xmm0
+G_M27315_IG179:
+       vmovdqu  xmm0, xmmword ptr [rsp+0x128]
+       vmovdqu  xmmword ptr [rsp+0xE0], xmm0
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M27315_IG178:
-       lea      rcx, [rsp+0xF0]
+G_M27315_IG180:
+       lea      rcx, [rsp+0xE0]
        mov      rdx, gword ptr [rdx+0x98]
        call     [System.Text.Json.JsonSerializer:IsMetadataPropertyName(System.ReadOnlySpan`1[ubyte],System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver):ubyte]
        test     eax, eax
-       je       SHORT G_M27315_IG181
+       je       SHORT G_M27315_IG183
        cmp      byte  ptr [rbp+0x93], 0
-       je       SHORT G_M27315_IG179
+       je       SHORT G_M27315_IG181
        mov      rcx, rbx
        call     [System.Text.Json.Utf8JsonReader:get_CurrentDepth():int:this]
        mov      edx, eax
        mov      rcx, rbx
        call     [System.Text.Json.Utf8JsonReader:TrySkipPartial(int):ubyte:this]
-       jmp      G_M27315_IG194
+       jmp      G_M27315_IG196
 						;; size=59 bbWeight=0 PerfScore 0.00
-G_M27315_IG179:
-       vmovdqu  xmm0, xmmword ptr [rsp+0x140]
-       vmovdqu  xmmword ptr [rsp+0xF0], xmm0
+G_M27315_IG181:
+       vmovdqu  xmm0, xmmword ptr [rsp+0x128]
+       vmovdqu  xmmword ptr [rsp+0xE0], xmm0
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M27315_IG180:
-       lea      rcx, [rsp+0xF0]
+G_M27315_IG182:
+       lea      rcx, [rsp+0xE0]
        mov      rdx, rbx
        mov      r8, rsi
        call     [System.Text.Json.ThrowHelper:ThrowUnexpectedMetadataException(System.ReadOnlySpan`1[ubyte],byref,byref)]
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M27315_IG181:
-       vmovdqu  xmm0, xmmword ptr [rsp+0x140]
-       vmovdqu  xmmword ptr [rsp+0xF0], xmm0
+G_M27315_IG183:
+       vmovdqu  xmm0, xmmword ptr [rsp+0x128]
+       vmovdqu  xmmword ptr [rsp+0xE0], xmm0
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M27315_IG182:
-       lea      rdx, [rsp+0x260]
+G_M27315_IG184:
+       lea      rdx, [rsp+0x250]
        mov      qword ptr [rsp+0x20], rdx
        mov      dword ptr [rsp+0x28], 1
-       lea      rdx, [rsp+0xF0]
-       mov      rcx, r13
+       lea      rdx, [rsp+0xE0]
+       mov      rcx, r15
        mov      r8, rsi
        mov      r9, rbp
        call     [System.Text.Json.JsonSerializer:LookupProperty(System.Object,System.ReadOnlySpan`1[ubyte],byref,System.Text.Json.JsonSerializerOptions,byref,ubyte):System.Text.Json.Serialization.Metadata.JsonPropertyInfo]
-       mov      r12, rax
-       mov      ecx, dword ptr [rsp+0x260]
+       mov      r13, rax
+       mov      ecx, dword ptr [rsp+0x250]
        mov      byte  ptr [rsi+0x89], cl
        mov      byte  ptr [rsi+0x88], 2
-       jmp      G_M27315_IG188
+       jmp      G_M27315_IG190
 						;; size=72 bbWeight=0 PerfScore 0.00
-G_M27315_IG183:
-       mov      rcx, gword ptr [r15+0xB0]
+G_M27315_IG185:
+       mov      rcx, gword ptr [r14+0xB0]
        mov      rcx, gword ptr [rcx+0x20]
-       mov      rdx, gword ptr [r15+0xB8]
+       mov      rdx, gword ptr [r14+0xB8]
        call     [System.Text.Json.ThrowHelper:ThrowInvalidOperationException_NoMetadataForTypeProperties(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver,System.Type)]
        int3     
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG184:
-       mov      rax, gword ptr [r15+0x40]
+G_M27315_IG186:
+       mov      rax, gword ptr [r14+0x40]
        test     rax, rax
-       je       SHORT G_M27315_IG185
-       mov      rdx, r13
+       je       SHORT G_M27315_IG187
+       mov      rdx, r15
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M27315_IG185:
-       lea      r12, bword ptr [rsi+0x30]
-       cmp      dword ptr [r15+0x104], 0
-       jle      SHORT G_M27315_IG186
-       mov      rcx, gword ptr [r12+0x48]
+G_M27315_IG187:
+       lea      r13, bword ptr [rsi+0x30]
+       cmp      dword ptr [r14+0x104], 0
+       jle      SHORT G_M27315_IG188
+       mov      rcx, gword ptr [r13+0x48]
        cmp      dword ptr [rcx], ecx
        call     [System.Collections.BitArray:HasAllSet():ubyte:this]
        test     eax, eax
-       jne      SHORT G_M27315_IG186
-       mov      rdx, gword ptr [r12+0x48]
-       mov      rcx, r15
+       jne      SHORT G_M27315_IG188
+       mov      rdx, gword ptr [r13+0x48]
+       mov      rcx, r14
        call     [System.Text.Json.ThrowHelper:ThrowJsonException_JsonRequiredPropertyMissing(System.Text.Json.Serialization.Metadata.JsonTypeInfo,System.Collections.BitArray)]
        int3     
-						;; size=46 bbWeight=0 PerfScore 0.00
-G_M27315_IG186:
+						;; size=44 bbWeight=0 PerfScore 0.00
+G_M27315_IG188:
        mov      rcx, qword ptr [rdi]
        mov      rcx, qword ptr [rcx+0x30]
        mov      rcx, qword ptr [rcx+0x18]
        mov      rcx, qword ptr [rcx]
-       mov      rdx, r13
+       mov      rdx, r15
        call     CORINFO_HELP_CHKCASTANY
+       mov      rcx, bword ptr [rsp+0x2D8]
        mov      rdx, rax
-       mov      rcx, r14
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        cmp      gword ptr [rsi+0x68], 0
-       je       G_M27315_IG84
+       je       G_M27315_IG85
        lea      rdx, bword ptr [rsi+0x30]
-       mov      rcx, r15
+       mov      rcx, r14
        call     [System.Text.Json.Serialization.Metadata.JsonTypeInfo:UpdateUtf8PropertyCache(byref):this]
-       jmp      G_M27315_IG84
-						;; size=62 bbWeight=0 PerfScore 0.00
-G_M27315_IG187:
-       mov      r12, gword ptr [rsi+0x30]
+       jmp      G_M27315_IG85
+						;; size=67 bbWeight=0 PerfScore 0.00
+G_M27315_IG189:
+       mov      r13, gword ptr [rsi+0x30]
 						;; size=4 bbWeight=0 PerfScore 0.00
-G_M27315_IG188:
+G_M27315_IG190:
        cmp      byte  ptr [rsi+0x88], 3
-       jae      SHORT G_M27315_IG192
-       cmp      byte  ptr [r12+0xAD], 0
-       jne      SHORT G_M27315_IG189
+       jae      SHORT G_M27315_IG194
+       cmp      byte  ptr [r13+0xAD], 0
+       jne      SHORT G_M27315_IG191
        mov      edx, dword ptr [rsi+0x80]
        inc      edx
        mov      rcx, rbx
        call     [System.Text.Json.Utf8JsonReader:TrySkipPartial(int):ubyte:this]
        test     eax, eax
-       je       G_M27315_IG195
-       jmp      G_M27315_IG194
-						;; size=50 bbWeight=0 PerfScore 0.00
-G_M27315_IG189:
+       je       G_M27315_IG197
+       jmp      G_M27315_IG196
+						;; size=49 bbWeight=0 PerfScore 0.00
+G_M27315_IG191:
        mov      rcx, qword ptr [rdi]
        mov      rdx, qword ptr [rcx+0x30]
        mov      rdx, qword ptr [rdx+0x18]
        mov      rax, qword ptr [rdx+0x10]
        test     rax, rax
-       je       SHORT G_M27315_IG190
+       je       SHORT G_M27315_IG192
        mov      rcx, rax
-       jmp      SHORT G_M27315_IG191
+       jmp      SHORT G_M27315_IG193
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M27315_IG190:
+G_M27315_IG192:
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M27315_IG191:
+G_M27315_IG193:
        mov      rdx, rsi
        mov      r8, rbx
-       mov      r9, r12
+       mov      r9, r13
        call     [System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:ReadAheadPropertyValue(byref,byref,System.Text.Json.Serialization.Metadata.JsonPropertyInfo):ubyte]
        test     eax, eax
-       je       SHORT G_M27315_IG195
+       je       SHORT G_M27315_IG197
        mov      byte  ptr [rsi+0x88], 3
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M27315_IG192:
+G_M27315_IG194:
        cmp      byte  ptr [rsi+0x88], 5
-       jae      G_M27315_IG168
+       jae      G_M27315_IG170
        cmp      byte  ptr [rsi+0x89], 0
-       jne      SHORT G_M27315_IG193
-       mov      rcx, r12
-       mov      rdx, r13
+       jne      SHORT G_M27315_IG195
+       mov      rcx, r13
+       mov      rdx, r15
        mov      r8, rsi
        mov      r9, rbx
-       mov      rax, qword ptr [r12]
+       mov      rax, qword ptr [r13]
        mov      rax, qword ptr [rax+0x48]
        call     [rax+0x30]<unknown method>
        test     eax, eax
-       jne      SHORT G_M27315_IG194
-       jmp      SHORT G_M27315_IG195
+       jne      SHORT G_M27315_IG196
+       jmp      SHORT G_M27315_IG197
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M27315_IG193:
-       mov      rcx, r12
-       mov      rdx, r13
+G_M27315_IG195:
+       mov      rcx, r13
+       mov      rdx, r15
        mov      r8, rsi
        mov      r9, rbx
        cmp      dword ptr [rcx], ecx
        call     [System.Text.Json.Serialization.Metadata.JsonPropertyInfo:ReadJsonAndAddExtensionProperty(System.Object,byref,byref):ubyte:this]
        test     eax, eax
-       je       SHORT G_M27315_IG195
+       je       SHORT G_M27315_IG197
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M27315_IG194:
+G_M27315_IG196:
        lea      rcx, bword ptr [rsi+0x30]
        call     [System.Text.Json.ReadStackFrame:EndProperty():this]
-       jmp      G_M27315_IG168
+       jmp      G_M27315_IG170
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M27315_IG195:
+G_M27315_IG197:
        lea      rcx, bword ptr [rsi+0x50]
-       mov      rdx, r13
+       mov      rdx, r15
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M27315_IG196:
+G_M27315_IG198:
        xor      rax, rax
-       mov      gword ptr [r14], rax
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M27315_IG197:
-       add      rsp, 632
+       mov      rbx, bword ptr [rsp+0x2D8]
+       mov      gword ptr [rbx], rax
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M27315_IG199:
+       add      rsp, 616
        pop      rbx
        pop      rbp
        pop      rsi
@@ -3904,20 +3908,20 @@ G_M27315_IG197:
        pop      r15
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M27315_IG198:
+G_M27315_IG200:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-RWD00  	dd	G_M27315_IG28 - G_M27315_IG02
-       	dd	G_M27315_IG47 - G_M27315_IG02
-       	dd	G_M27315_IG107 - G_M27315_IG02
-       	dd	G_M27315_IG106 - G_M27315_IG02
-       	dd	G_M27315_IG49 - G_M27315_IG02
+RWD00  	dd	G_M27315_IG25 - G_M27315_IG02
        	dd	G_M27315_IG48 - G_M27315_IG02
-       	dd	G_M27315_IG105 - G_M27315_IG02
-       	dd	G_M27315_IG46 - G_M27315_IG02
+       	dd	G_M27315_IG109 - G_M27315_IG02
+       	dd	G_M27315_IG108 - G_M27315_IG02
+       	dd	G_M27315_IG50 - G_M27315_IG02
+       	dd	G_M27315_IG49 - G_M27315_IG02
+       	dd	G_M27315_IG107 - G_M27315_IG02
+       	dd	G_M27315_IG47 - G_M27315_IG02
 
 
-; Total bytes of code 5786, prolog size 115, PerfScore 978.97, instruction count 1216, allocated bytes for code 5786 (MethodHash=5452954c) for method System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (Tier1)
+; Total bytes of code 5773, prolog size 115, PerfScore 950.10, instruction count 1216, allocated bytes for code 5773 (MethodHash=5452954c) for method System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.Json]System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon].OnTryRead(value class System.Text.Json.Utf8JsonReader&,class System.Type,class System.Text.Json.JsonSerializerOptions,value class System.Text.Json.ReadStack&,!0&)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 61312
+; with Dynamic PGO: fgCalledCount is 63136
 ; 16 inlinees with PGO data; 70 single block inlinees; 2 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T52] ( 18,  4.84)     ref  ->  [rsp+0x2C0]  this class-hnd single-def <System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon]>
-;  V01 arg1         [V01,T03] ( 43, 34.97)   byref  ->  rsi         single-def
+;  V00 this         [V00,T52] ( 18,  4.98)     ref  ->  [rsp+0x2C0]  this class-hnd single-def <System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon]>
+;  V01 arg1         [V01,T03] ( 43, 34.16)   byref  ->  rsi         single-def
 ;  V02 arg2         [V02,T59] (  3,  2   )     ref  ->  r14         class-hnd single-def <System.Type>
-;  V03 arg3         [V03,T49] ( 15,  6.89)     ref  ->  rdi         class-hnd single-def <System.Text.Json.JsonSerializerOptions>
-;  V04 arg4         [V04,T00] (127,138.59)   byref  ->  rbx         single-def
-;  V05 arg5         [V05,T72] (  4,  1.00)   byref  ->  [rsp+0x2E8]  single-def
-;  V06 loc0         [V06,T60] (  7,  4.00)     ref  ->  [rsp+0xA0]  class-hnd spill-single-def <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
+;  V03 arg3         [V03,T49] ( 15,  6.80)     ref  ->  rdi         class-hnd single-def <System.Text.Json.JsonSerializerOptions>
+;  V04 arg4         [V04,T00] (127,135.49)   byref  ->  rbx         single-def
+;  V05 arg5         [V05,T72] (  4,  1   )   byref  ->  [rsp+0x2E8]  single-def
+;  V06 loc0         [V06,T60] (  7,  3.98)     ref  ->  [rsp+0xA0]  class-hnd spill-single-def <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;* V07 loc1         [V07    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;  V08 loc2         [V08,T69] (  4,  2.25)     ref  ->  rsi         class-hnd single-def <System.Object>
-;  V09 loc3         [V09,T18] ( 24, 21.27)     ref  ->  r13         class-hnd single-def <System.Text.Json.Serialization.JsonConverter`1[System.__Canon]>
+;  V09 loc3         [V09,T18] ( 24, 20.75)     ref  ->  r13         class-hnd single-def <System.Text.Json.Serialization.JsonConverter`1[System.__Canon]>
 ;  V10 loc4         [V10    ] (  2,  0   )     ref  ->  [rsp+0x268]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
-;  V11 loc5         [V11    ] (  9,  9.64)     ref  ->  [rsp+0x260]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
-;  V12 loc6         [V12    ] (  3,  4.82)   ubyte  ->  [rsp+0x258]  do-not-enreg[X] addr-exposed ld-addr-op
+;  V11 loc5         [V11    ] (  9,  9.39)     ref  ->  [rsp+0x260]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
+;  V12 loc6         [V12    ] (  3,  4.70)   ubyte  ->  [rsp+0x258]  do-not-enreg[X] addr-exposed ld-addr-op
 ;  V13 loc7         [V13,T75] (  6,  0   )     ref  ->  r12         class-hnd single-def <System.Text.Json.Serialization.JsonConverter>
 ;  V14 loc8         [V14,T96] (  3,  0   )   ubyte  ->  rsi        
 ;  V15 loc9         [V15    ] (  2,  0   )     ref  ->  [rsp+0x250]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.Object>
 ;  V16 loc10        [V16,T79] (  3,  0   )     ref  ->  [rsp+0x98]  class-hnd spill-single-def <System.Text.Json.Serialization.JsonConverter`1[System.__Canon]>
 ;  V17 loc11        [V17    ] (  2,  0   )     ref  ->  [rsp+0x248]  do-not-enreg[X] must-init addr-exposed ld-addr-op class-hnd <System.__Canon>
 ;  V18 OutArgs      [V18    ] (  1,  1   )  struct (56) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V19 tmp1         [V19,T58] (  4,  4.00)     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
+;  V19 tmp1         [V19,T58] (  4,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
 ;* V20 tmp2         [V20    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V21 tmp3         [V21    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V22 tmp4         [V22    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
 ;  V23 tmp5         [V23,T76] (  4,  0   )     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
 ;* V24 tmp6         [V24    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V25 tmp7         [V25    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
-;  V26 tmp8         [V26,T61] (  4,  3.98)     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
+;  V26 tmp8         [V26,T61] (  4,  3.92)     ref  ->  rax         class-hnd single-def "dup spill" <System.Action`1[System.Object]>
 ;* V27 tmp9         [V27    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V28 tmp10        [V28    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
 ;* V29 tmp11        [V29    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
@@ -2095,15 +2095,15 @@ G_M47095_IG67:
 ;* V31 tmp13        [V31    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
 ;* V32 tmp14        [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "guarded devirt this exact temp" <<unknown class>>
 ;* V33 tmp15        [V33    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
-;  V34 tmp16        [V34,T48] (  9,  9.49)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
+;  V34 tmp16        [V34,T40] (  9,  9.43)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;* V35 tmp17        [V35    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V36 tmp18        [V36    ] (  0,  0   )     ref  ->  zero-ref    single-def
 ;* V37 tmp19        [V37    ] (  0,  0   )     ref  ->  zero-ref    class-hnd single-def "dup spill" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;* V38 tmp20        [V38    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V39 tmp21        [V39,T71] (  2,  1.85)     int  ->  rcx        
+;  V39 tmp21        [V39,T71] (  2,  1.81)     int  ->  rcx        
 ;* V40 tmp22        [V40    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
-;  V41 tmp23        [V41,T66] (  5,  2.78)     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V42 tmp24        [V42,T70] (  3,  1.85)   ubyte  ->  rcx         "Inline return value spill temp"
+;  V41 tmp23        [V41,T66] (  5,  2.73)     ref  ->  rax         class-hnd "Inline return value spill temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V42 tmp24        [V42,T70] (  3,  1.81)   ubyte  ->  rcx         "Inline return value spill temp"
 ;* V43 tmp25        [V43    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "impAppendStmt" <System.Func`2[System.Object,System.Object]>
 ;  V44 tmp26        [V44,T77] (  4,  0   )     ref  ->  [rsp+0x90]  class-hnd spill-single-def "Inline stloc first use temp" <System.Object>
 ;* V45 tmp27        [V45    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
@@ -2113,17 +2113,17 @@ G_M47095_IG67:
 ;* V49 tmp31        [V49    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V50 tmp32        [V50    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[System.__Canon]>
 ;* V51 tmp33        [V51    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
-;  V52 tmp34        [V52,T35] (  3, 11.63)     int  ->  rax        
+;  V52 tmp34        [V52,T35] (  3, 11.35)     int  ->  rax        
 ;* V53 tmp35        [V53    ] (  0,  0   )     int  ->  zero-ref   
 ;* V54 tmp36        [V54    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ubyte]>
 ;* V55 tmp37        [V55    ] (  0,  0   )   byref  ->  zero-ref    "Inlining Arg"
 ;* V56 tmp38        [V56    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
-;  V57 tmp39        [V57,T41] (  2,  9.61)   ubyte  ->  [rsp+0x244]  spill-single-def "Inline stloc first use temp"
-;  V58 tmp40        [V58,T33] (  3, 14.34)     ref  ->  [rsp+0x88]  class-hnd spill-single-def "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
-;  V59 tmp41        [V59,T21] (  2, 19.22)     ref  ->  [rsp+0x80]  class-hnd spill-single-def "impAppendStmt" <System.Object>
+;  V57 tmp39        [V57,T42] (  2,  9.39)   ubyte  ->  [rsp+0x244]  spill-single-def "Inline stloc first use temp"
+;  V58 tmp40        [V58,T30] (  3, 14.08)     ref  ->  [rsp+0x88]  class-hnd spill-single-def "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V59 tmp41        [V59,T20] (  2, 18.78)     ref  ->  [rsp+0x80]  class-hnd spill-single-def "impAppendStmt" <System.Object>
 ;* V60 tmp42        [V60    ] (  0,  0   )     ref  ->  zero-ref   
-;  V61 tmp43        [V61,T40] (  2,  9.64)   ubyte  ->  rax         "Inline stloc first use temp"
-;  V62 tmp44        [V62,T20] (  2, 19.26)   byref  ->  rax         "impAppendStmt"
+;  V61 tmp43        [V61,T41] (  2,  9.39)   ubyte  ->  rax         "Inline stloc first use temp"
+;  V62 tmp44        [V62,T21] (  2, 18.77)   byref  ->  rax         "impAppendStmt"
 ;  V63 tmp45        [V63,T123] (  2,  0   )   ubyte  ->  [rsp+0x240]  spill-single-def "Inline stloc first use temp"
 ;  V64 tmp46        [V64,T124] (  2,  0   )     int  ->  [rsp+0x23C]  spill-single-def "Inline stloc first use temp"
 ;  V65 tmp47        [V65,T125] (  2,  0   )    long  ->  [rsp+0x230]  spill-single-def "Inline stloc first use temp"
@@ -2136,48 +2136,48 @@ G_M47095_IG67:
 ;  V72 tmp54        [V72,T80] (  3,  0   )     ref  ->  [rsp+0x78]  class-hnd exact spill-single-def "Strict ordering of exceptions for Array store" <<unknown class>>
 ;  V73 tmp55        [V73,T98] (  3,  0   )     int  ->  [rsp+0x22C]  spill-single-def "Strict ordering of exceptions for Array store"
 ;  V74 tmp56        [V74,T126] (  2,  0   )  struct (112) [rsp+0x1B8]  do-not-enreg[S] must-init "Strict ordering of exceptions for Array store" <System.Text.Json.ReadStackFrame>
-;  V75 tmp57        [V75,T15] (  3, 28.71)     ref  ->  rcx         class-hnd "dup spill" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V75 tmp57        [V75,T15] (  3, 28.01)     ref  ->  rcx         class-hnd "dup spill" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;* V76 tmp58        [V76    ] (  0,  0   )     ref  ->  zero-ref   
-;  V77 tmp59        [V77,T43] (  3,  9.57)     ref  ->  rax        
-;  V78 tmp60        [V78,T17] (  6, 23.93)     ref  ->  [rsp+0x70] 
+;  V77 tmp59        [V77,T44] (  3,  9.34)     ref  ->  rax        
+;  V78 tmp60        [V78,T17] (  6, 23.35)     ref  ->  [rsp+0x70] 
 ;* V79 tmp61        [V79    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;* V80 tmp62        [V80    ] (  0,  0   )  struct ( 8) zero-ref    "Inline stloc first use temp" <System.Nullable`1[int]>
-;  V81 tmp63        [V81,T09] (  3, 28.72)     ref  ->  r15         class-hnd exact "Strict ordering of exceptions for Array store" <<unknown class>>
-;  V82 tmp64        [V82,T14] (  3, 28.72)     int  ->  [rsp+0x1B4]  spill-single-def "Strict ordering of exceptions for Array store"
-;  V83 tmp65        [V83,T23] (  2, 19.15)  struct (112) [rsp+0x140]  do-not-enreg[S] must-init "Strict ordering of exceptions for Array store" <System.Text.Json.ReadStackFrame>
+;  V81 tmp63        [V81,T09] (  3, 28.02)     ref  ->  r15         class-hnd exact "Strict ordering of exceptions for Array store" <<unknown class>>
+;  V82 tmp64        [V82,T14] (  3, 28.02)     int  ->  [rsp+0x1B4]  spill-single-def "Strict ordering of exceptions for Array store"
+;  V83 tmp65        [V83,T23] (  2, 18.68)  struct (112) [rsp+0x140]  do-not-enreg[S] must-init "Strict ordering of exceptions for Array store" <System.Text.Json.ReadStackFrame>
 ;* V84 tmp66        [V84    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
 ;* V85 tmp67        [V85    ] (  0,  0   )  struct ( 8) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Nullable`1[int]>
-;  V86 tmp68        [V86,T10] (  3, 28.72)   byref  ->  rax         "impAppendStmt"
+;  V86 tmp68        [V86,T10] (  3, 28.02)   byref  ->  rax         "impAppendStmt"
 ;* V87 tmp69        [V87    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V88 tmp70        [V88    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V89 tmp71        [V89    ] (  0,  0   )  struct ( 8) zero-ref    <System.Nullable`1[int]>
 ;* V90 tmp72        [V90    ] (  0,  0   )   byref  ->  zero-ref    "impAppendStmt"
-;  V91 tmp73        [V91,T47] (  2,  9.57)   byref  ->  rbp        
+;  V91 tmp73        [V91,T48] (  2,  9.34)   byref  ->  rbp        
 ;* V92 tmp74        [V92    ] (  0,  0   )   byref  ->  zero-ref   
-;  V93 tmp75        [V93,T42] (  4,  9.57)     int  ->  r11        
-;  V94 tmp76        [V94,T22] (  3, 19.15)     ref  ->   r9         class-hnd exact "dup spill" <System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver>
+;  V93 tmp75        [V93,T43] (  4,  9.34)     int  ->  r11        
+;  V94 tmp76        [V94,T22] (  3, 18.68)     ref  ->   r9         class-hnd exact "dup spill" <System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver>
 ;* V95 tmp77        [V95    ] (  0,  0   )   byref  ->  zero-ref   
 ;* V96 tmp78        [V96    ] (  0,  0   )     ref  ->  zero-ref   
-;  V97 tmp79        [V97,T16] (  4, 28.69)     ref  ->  [rsp+0x68]  class-hnd spill-single-def "dup spill" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
+;  V97 tmp79        [V97,T16] (  4, 27.99)     ref  ->  [rsp+0x68]  class-hnd spill-single-def "dup spill" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;  V98 tmp80        [V98,T115] (  2,  0   )     ref  ->  rcx         class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonParameterInfo>
 ;* V99 tmp81        [V99    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;  V100 tmp82       [V100,T78] (  4,  0   )     ref  ->  [rsp+0x60]  class-hnd spill-single-def "dup spill" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
-;  V101 tmp83       [V101,T11] (  3, 28.72)     ref  ->  rcx         class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
+;  V101 tmp83       [V101,T11] (  3, 28.02)     ref  ->  rcx         class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonPropertyInfo>
 ;  V102 tmp84       [V102,T81] (  3,  0   )   byref  ->  [rsp+0x58]  "Inline stloc first use temp"
 ;* V103 tmp85       [V103    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "NewObj constructor temp" <System.Text.Json.ArgumentState>
 ;* V104 tmp86       [V104    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonTypeInfo>
 ;* V105 tmp87       [V105    ] (  0,  0   )  struct (24) zero-ref    ld-addr-op "Inline stloc first use temp" <System.Text.Json.BitStack>
-;  V106 tmp88       [V106,T36] (  3, 11.39)     int  ->  r10         "Inline stloc first use temp"
-;  V107 tmp89       [V107,T34] (  3, 13.05)   ubyte  ->  rcx         "Inline stloc first use temp"
+;  V106 tmp88       [V106,T36] (  3, 11.08)     int  ->  r10         "Inline stloc first use temp"
+;  V107 tmp89       [V107,T34] (  3, 12.64)   ubyte  ->  rcx         "Inline stloc first use temp"
 ;* V108 tmp90       [V108    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline stloc first use temp"
-;  V109 tmp91       [V109,T28] (  9, 14.46)     int  ->  rax         "Inline stloc first use temp"
+;  V109 tmp91       [V109,T28] (  9, 14.09)     int  ->  rax         "Inline stloc first use temp"
 ;  V110 tmp92       [V110,T82] (  3,  0   )     ref  ->  [rsp+0x50]  class-hnd exact spill-single-def "Strict ordering of exceptions for Array store" <<unknown class>>
 ;  V111 tmp93       [V111,T99] (  3,  0   )     int  ->  [rsp+0x13C]  spill-single-def "Strict ordering of exceptions for Array store"
 ;  V112 tmp94       [V112,T127] (  2,  0   )  struct (112) [rsp+0xC8]  do-not-enreg[S] must-init "Strict ordering of exceptions for Array store" <System.Text.Json.ReadStackFrame>
-;  V113 tmp95       [V113,T01] (  7, 48.59)     ref  ->  rcx         class-hnd "Inlining Arg" <<unknown class>>
-;  V114 tmp96       [V114,T38] (  3, 11.25)     ref  ->  rax         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V115 tmp97       [V115,T30] (  4, 14.41)     int  ->  rdx         "Inline stloc first use temp"
-;  V116 tmp98       [V116,T27] (  3, 16.20)     ref  ->   r8         class-hnd "Inlining Arg" <System.__Canon>
+;  V113 tmp95       [V113,T01] (  7, 45.65)     ref  ->  rcx         class-hnd "Inlining Arg" <<unknown class>>
+;  V114 tmp96       [V114,T38] (  3, 10.56)     ref  ->  rax         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V115 tmp97       [V115,T33] (  4, 13.50)     int  ->  rdx         "Inline stloc first use temp"
+;  V116 tmp98       [V116,T27] (  3, 15.22)     ref  ->   r8         class-hnd "Inlining Arg" <System.__Canon>
 ;* V117 tmp99       [V117    ] (  0,  0   )    long  ->  zero-ref    "Inlining Arg"
 ;* V118 tmp100      [V118    ] (  0,  0   )    long  ->  zero-ref    "spilling helperCall"
 ;* V119 tmp101      [V119    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[System.__Canon]>
@@ -2188,27 +2188,27 @@ G_M47095_IG67:
 ;  V124 tmp106      [V124,T128] (  2,  0   )     int  ->  rsi         "Single return block return value"
 ;  V125 tmp107      [V125,T116] (  2,  0   )   byref  ->   r9         "field V54._reference (fldOffset=0x0)" P-INDEP
 ;* V126 tmp108      [V126,T132] (  0,  0   )     int  ->  zero-ref    "field V54._length (fldOffset=0x8)" P-INDEP
-;  V127 tmp109      [V127,T44] (  3,  9.57)   ubyte  ->  [rsp+0xC4]  spill-single-def "field V80.hasValue (fldOffset=0x0)" P-INDEP
-;  V128 tmp110      [V128,T55] (  2,  4.79)     int  ->  [rsp+0xC0]  spill-single-def "field V80.value (fldOffset=0x4)" P-INDEP
+;  V127 tmp109      [V127,T45] (  3,  9.34)   ubyte  ->  [rsp+0xC4]  spill-single-def "field V80.hasValue (fldOffset=0x0)" P-INDEP
+;  V128 tmp110      [V128,T55] (  2,  4.67)     int  ->  [rsp+0xC0]  spill-single-def "field V80.value (fldOffset=0x4)" P-INDEP
 ;* V129 tmp111      [V129    ] (  0,  0   )   ubyte  ->  zero-ref    "field V85.hasValue (fldOffset=0x0)" P-INDEP
 ;* V130 tmp112      [V130    ] (  0,  0   )     int  ->  zero-ref    "field V85.value (fldOffset=0x4)" P-INDEP
-;  V131 tmp113      [V131,T45] (  3,  9.57)   ubyte  ->   r8         "field V89.hasValue (fldOffset=0x0)" P-INDEP
-;  V132 tmp114      [V132,T46] (  3,  9.57)     int  ->  r10         "field V89.value (fldOffset=0x4)" P-INDEP
+;  V131 tmp113      [V131,T46] (  3,  9.34)   ubyte  ->   r8         "field V89.hasValue (fldOffset=0x0)" P-INDEP
+;  V132 tmp114      [V132,T47] (  3,  9.34)     int  ->  r10         "field V89.value (fldOffset=0x4)" P-INDEP
 ;* V133 tmp115      [V133    ] (  0,  0   )     ref  ->  zero-ref    "field V105._array (fldOffset=0x0)" P-INDEP
 ;* V134 tmp116      [V134    ] (  0,  0   )    long  ->  zero-ref    "field V105._allocationFreeContainer (fldOffset=0x8)" P-INDEP
-;  V135 tmp117      [V135,T37] (  3, 11.39)     int  ->   r8         "field V105._currentDepth (fldOffset=0x10)" P-INDEP
-;  V136 tmp118      [V136,T73] (  3,  0.96)     ref  ->  rax         single-def "arr expr"
-;  V137 tmp119      [V137,T74] (  3,  0.96)     int  ->  rcx         "index expr"
+;  V135 tmp117      [V135,T37] (  3, 11.08)     int  ->   r8         "field V105._currentDepth (fldOffset=0x10)" P-INDEP
+;  V136 tmp118      [V136,T73] (  3,  0.93)     ref  ->  rax         single-def "arr expr"
+;  V137 tmp119      [V137,T74] (  3,  0.93)     int  ->  rcx         "index expr"
 ;  V138 tmp120      [V138,T117] (  2,  0   )     ref  ->  rdx         single-def "argument with side effect"
 ;  V139 tmp121      [V139,T84] (  3,  0   )     ref  ->  [rsp+0x48]  spill-single-def "argument with side effect"
-;  V140 tmp122      [V140,T57] (  3,  4.38)    long  ->  rcx         "argument with side effect"
-;  V141 tmp123      [V141,T65] (  3,  2.99)    long  ->  rcx         "argument with side effect"
+;  V140 tmp122      [V140,T57] (  3,  4.31)    long  ->  rcx         "argument with side effect"
+;  V141 tmp123      [V141,T65] (  3,  2.94)    long  ->  rcx         "argument with side effect"
 ;  V142 tmp124      [V142    ] (  3,  0   )  struct (16) [rsp+0xB0]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ubyte]>
 ;  V143 tmp125      [V143,T85] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V144 tmp126      [V144,T102] (  3,  0   )     int  ->  rdx         "index expr"
-;  V145 tmp127      [V145,T19] (  2, 19.28)     ref  ->   r8         "argument with side effect"
-;  V146 tmp128      [V146,T05] (  3, 28.89)     ref  ->  rcx         "arr expr"
-;  V147 tmp129      [V147,T08] (  3, 28.89)     int  ->  rdx         "index expr"
+;  V145 tmp127      [V145,T19] (  2, 18.79)     ref  ->   r8         "argument with side effect"
+;  V146 tmp128      [V146,T05] (  3, 28.15)     ref  ->  rcx         "arr expr"
+;  V147 tmp129      [V147,T08] (  3, 28.15)     int  ->  rdx         "index expr"
 ;  V148 tmp130      [V148,T86] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V149 tmp131      [V149,T103] (  3,  0   )     int  ->  rdx         "index expr"
 ;  V150 tmp132      [V150,T118] (  2,  0   )     ref  ->   r8         "argument with side effect"
@@ -2221,25 +2221,25 @@ G_M47095_IG67:
 ;  V157 tmp139      [V157,T121] (  2,  0   )     ref  ->   r8         "argument with side effect"
 ;  V158 tmp140      [V158,T122] (  2,  0   )     ref  ->   r8         single-def "argument with side effect"
 ;  V159 tmp141      [V159,T131] (  2,  0   )    long  ->  rcx         "argument with side effect"
-;  V160 cse0        [V160,T63] (  4,  3.70)     ref  ->  rax         "CSE #03: conservative"
-;  V161 cse1        [V161,T26] (  6, 16.46)     int  ->  registers   multi-def "CSE #06: moderate"
-;  V162 cse2        [V162,T29] (  5, 14.43)     int  ->   r9         multi-def "CSE #15: moderate"
-;  V163 cse3        [V163,T31] (  3, 14.36)     ref  ->  rcx         "CSE #16: moderate"
-;  V164 cse4        [V164,T02] ( 17, 43.20)   byref  ->  [rsp+0x40]  multi-def "CSE #18: aggressive"
-;  V165 cse5        [V165,T25] ( 26, 16.67)    long  ->  r12         multi-def "CSE #04: moderate"
-;  V166 cse6        [V166,T50] (  5,  8.81)    long  ->  [rsp+0xA8]  multi-def "CSE #22: moderate"
-;  V167 cse7        [V167,T32] (  4, 14.35)     ref  ->  rcx         "CSE #17: moderate"
-;  V168 rat0        [V168,T56] (  4,  4.48)     ref  ->  rax         "replacement local"
-;  V169 rat1        [V169,T68] (  3,  2.49)    long  ->  rcx         "CSE for expectedClsNode"
-;  V170 rat2        [V170,T24] (  3, 18.22)     ref  ->  rdx         "Spilling to split statement for tree"
-;  V171 rat3        [V171,T04] (  5, 30.37)     ref  ->  rcx         "replacement local"
-;  V172 rat4        [V172,T39] (  3, 10.12)    long  ->  rax         "CSE for expectedClsNode"
-;  V173 rat5        [V173,T64] (  2,  3.00)    long  ->  rcx         "Spilling to split statement for tree"
+;  V160 cse0        [V160,T63] (  4,  3.65)     ref  ->  rax         "CSE #03: conservative"
+;  V161 cse1        [V161,T26] (  6, 16.05)     int  ->  registers   multi-def "CSE #06: moderate"
+;  V162 cse2        [V162,T29] (  5, 14.08)     int  ->   r9         multi-def "CSE #15: moderate"
+;  V163 cse3        [V163,T31] (  3, 14.05)     ref  ->  rcx         "CSE #16: moderate"
+;  V164 cse4        [V164,T02] ( 17, 42.12)   byref  ->  [rsp+0x40]  multi-def "CSE #18: aggressive"
+;  V165 cse5        [V165,T25] ( 26, 16.53)    long  ->  r12         multi-def "CSE #04: moderate"
+;  V166 cse6        [V166,T50] (  5,  8.66)    long  ->  [rsp+0xA8]  multi-def "CSE #22: moderate"
+;  V167 cse7        [V167,T32] (  4, 14.00)     ref  ->  rcx         "CSE #17: moderate"
+;  V168 rat0        [V168,T56] (  4,  4.41)     ref  ->  rax         "replacement local"
+;  V169 rat1        [V169,T68] (  3,  2.45)    long  ->  rcx         "CSE for expectedClsNode"
+;  V170 rat2        [V170,T24] (  3, 17.12)     ref  ->  rdx         "Spilling to split statement for tree"
+;  V171 rat3        [V171,T04] (  5, 28.53)     ref  ->  rcx         "replacement local"
+;  V172 rat4        [V172,T39] (  3,  9.51)    long  ->  rax         "CSE for expectedClsNode"
+;  V173 rat5        [V173,T64] (  2,  3   )    long  ->  rcx         "Spilling to split statement for tree"
 ;  V174 rat6        [V174,T51] (  5,  7.50)     ref  ->  rdx         "replacement local"
 ;  V175 rat7        [V175,T67] (  3,  2.50)    long  ->  rcx         "CSE for expectedClsNode"
-;  V176 rat8        [V176,T62] (  3,  3.98)    long  ->  rcx         "runtime lookup"
-;  V177 rat9        [V177,T53] (  3,  5.58)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
-;  V178 rat10       [V178,T54] (  3,  5.58)    long  ->  rax         "fgMakeTemp is creating a new local variable"
+;  V176 rat8        [V176,T62] (  3,  3.92)    long  ->  rcx         "runtime lookup"
+;  V177 rat9        [V177,T53] (  3,  5.49)    long  ->  rcx         "fgMakeTemp is creating a new local variable"
+;  V178 rat10       [V178,T54] (  3,  5.49)    long  ->  rax         "fgMakeTemp is creating a new local variable"
 ;  V179 rat11       [V179,T105] (  3,  0   )    long  ->  r12         "Spilling to split statement for tree"
 ;  V180 rat12       [V180,T106] (  3,  0   )    long  ->  rcx         "runtime lookup"
 ;  V181 rat13       [V181,T107] (  3,  0   )    long  ->  rcx         "fgMakeTemp is creating a new local variable"
@@ -2248,10 +2248,10 @@ G_M47095_IG67:
 ;  V184 rat16       [V184,T110] (  3,  0   )    long  ->  rax         "fgMakeTemp is creating a new local variable"
 ;  V185 rat17       [V185,T111] (  3,  0   )    long  ->  rcx         "runtime lookup"
 ;  V186 rat18       [V186,T112] (  3,  0   )    long  ->  rax         "fgMakeTemp is creating a new local variable"
-;  V187 rat19       [V187,T12] (  3, 28.72)   byref  ->  rbp         "ReplaceWithLclVar is creating a new local variable"
-;  V188 rat20       [V188,T13] (  3, 28.72)   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
-;  V189 rat21       [V189,T06] (  3, 28.89)   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
-;  V190 rat22       [V190,T07] (  3, 28.89)   byref  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
+;  V187 rat19       [V187,T12] (  3, 28.02)   byref  ->  rbp         "ReplaceWithLclVar is creating a new local variable"
+;  V188 rat20       [V188,T13] (  3, 28.02)   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
+;  V189 rat21       [V189,T06] (  3, 28.15)   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
+;  V190 rat22       [V190,T07] (  3, 28.15)   byref  ->  rdx         "ReplaceWithLclVar is creating a new local variable"
 ;  V191 rat23       [V191,T88] (  3,  0   )   byref  ->  r14         "ReplaceWithLclVar is creating a new local variable"
 ;  V192 rat24       [V192,T89] (  3,  0   )   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
 ;  V193 rat25       [V193,T90] (  3,  0   )   byref  ->  rcx         "ReplaceWithLclVar is creating a new local variable"
@@ -2295,61 +2295,63 @@ G_M47095_IG02:
        test     r13, r13
        je       SHORT G_M47095_IG03
        cmp      byte  ptr [r13+0x115], 2
-       jne      G_M47095_IG79
+       jne      G_M47095_IG81
 						;; size=38 bbWeight=1 PerfScore 10.25
 G_M47095_IG03:
        cmp      byte  ptr [rbx+0x28], 0
-       jne      G_M47095_IG64
+       jne      G_M47095_IG65
 						;; size=10 bbWeight=1 PerfScore 4.00
 G_M47095_IG04:
        cmp      byte  ptr [rbx+0x8B], 0
-       jne      G_M47095_IG64
+       jne      G_M47095_IG65
        cmp      byte  ptr [rsi+0x28], 3
-       jne      G_M47095_IG148
+       jne      G_M47095_IG149
        mov      r12, qword ptr [rbp]
        mov      r14, 0xD1FFAB1E      ; <unknown class>
        cmp      r12, r14
-       jne      G_M47095_IG53
-						;; size=46 bbWeight=1.00 PerfScore 11.45
+       jne      G_M47095_IG54
+						;; size=46 bbWeight=0.98 PerfScore 11.27
 G_M47095_IG05:
        cmp      byte  ptr [rbx+0x8F], 0
-       jne      G_M47095_IG52
-						;; size=13 bbWeight=0.93 PerfScore 3.70
+       jne      G_M47095_IG53
+						;; size=13 bbWeight=0.91 PerfScore 3.65
 G_M47095_IG06:
        xor      rax, rax
-						;; size=2 bbWeight=0.77 PerfScore 0.19
+						;; size=2 bbWeight=0.76 PerfScore 0.19
 G_M47095_IG07:
        test     rax, rax
-       je       SHORT G_M47095_IG10
-						;; size=5 bbWeight=0.93 PerfScore 1.16
+       je       SHORT G_M47095_IG11
+						;; size=5 bbWeight=0.91 PerfScore 1.14
 G_M47095_IG08:
        cmp      dword ptr [rax+0x90], 1
-       je       G_M47095_IG80
-       xor      ecx, ecx
-						;; size=15 bbWeight=0.93 PerfScore 3.93
+       je       G_M47095_IG82
+						;; size=13 bbWeight=0.91 PerfScore 3.62
 G_M47095_IG09:
-       test     ecx, ecx
-       jne      SHORT G_M47095_IG12
-						;; size=4 bbWeight=0.93 PerfScore 1.16
+       xor      ecx, ecx
+						;; size=2 bbWeight=0.91 PerfScore 0.23
 G_M47095_IG10:
+       test     ecx, ecx
+       jne      SHORT G_M47095_IG13
+						;; size=4 bbWeight=0.91 PerfScore 1.13
+G_M47095_IG11:
        mov      rcx, gword ptr [rbx+0x58]
        mov      rax, gword ptr [rcx+0x58]
        test     rax, rax
-       je       G_M47095_IG81
-						;; size=17 bbWeight=0.93 PerfScore 4.86
-G_M47095_IG11:
+       je       G_M47095_IG83
+						;; size=17 bbWeight=0.91 PerfScore 4.78
+G_M47095_IG12:
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
        lea      rcx, bword ptr [rbx+0x50]
        mov      rdx, rax
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-						;; size=19 bbWeight=0.93 PerfScore 6.25
-G_M47095_IG12:
+						;; size=19 bbWeight=0.91 PerfScore 6.15
+G_M47095_IG13:
        mov      rax, gword ptr [r15+0x38]
        test     rax, rax
-       jne      G_M47095_IG82
-						;; size=13 bbWeight=1.00 PerfScore 3.24
-G_M47095_IG13:
+       jne      G_M47095_IG84
+						;; size=13 bbWeight=0.98 PerfScore 3.18
+G_M47095_IG14:
        mov      rdx, gword ptr [r13+0xC8]
        lea      rcx, bword ptr [rbx+0x30]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
@@ -2357,118 +2359,118 @@ G_M47095_IG13:
        mov      rcx, qword ptr [rcx+0x10]
        mov      rcx, qword ptr [rcx+0x20]
        test     rcx, rcx
-       je       G_M47095_IG54
-						;; size=38 bbWeight=1.00 PerfScore 10.71
-G_M47095_IG14:
+       je       G_M47095_IG55
+						;; size=38 bbWeight=0.98 PerfScore 10.53
+G_M47095_IG15:
        mov      rdx, qword ptr [rcx+0x30]
        mov      rdx, qword ptr [rdx+0x10]
        mov      rax, qword ptr [rdx+0x30]
        test     rax, rax
-       je       G_M47095_IG55
-						;; size=21 bbWeight=1.00 PerfScore 7.22
-G_M47095_IG15:
-       mov      rcx, rax
-						;; size=3 bbWeight=0.80 PerfScore 0.20
+       je       G_M47095_IG56
+						;; size=21 bbWeight=0.98 PerfScore 7.10
 G_M47095_IG16:
+       mov      rcx, rax
+						;; size=3 bbWeight=0.78 PerfScore 0.20
+G_M47095_IG17:
        mov      rax, r13
        cmp      qword ptr [rax], rcx
-       je       SHORT G_M47095_IG18
-						;; size=8 bbWeight=0.50 PerfScore 2.12
-G_M47095_IG17:
+       je       SHORT G_M47095_IG19
+						;; size=8 bbWeight=0.49 PerfScore 2.08
+G_M47095_IG18:
        mov      rdx, r13
        call     CORINFO_HELP_CHKCASTCLASS
-						;; size=8 bbWeight=0.25 PerfScore 0.31
-G_M47095_IG18:
+						;; size=8 bbWeight=0.24 PerfScore 0.31
+G_M47095_IG19:
        mov      r13, gword ptr [rax+0x150]
        cmp      byte  ptr [r13+0x11], 0
-       je       SHORT G_M47095_IG20
-       jmp      G_M47095_IG83
-						;; size=19 bbWeight=1.00 PerfScore 7.97
-G_M47095_IG19:
+       je       SHORT G_M47095_IG21
+       jmp      G_M47095_IG85
+						;; size=19 bbWeight=0.98 PerfScore 7.84
+G_M47095_IG20:
        lea      r10d, [rdx+0x01]
        mov      dword ptr [rcx+0x10], r10d
        movsxd   rdx, edx
        mov      rcx, rax
        call     CORINFO_HELP_ARRADDR_ST
        mov      rbp, gword ptr [rsp+0x2C0]
-						;; size=27 bbWeight=3.16 PerfScore 12.62
-G_M47095_IG20:
+						;; size=27 bbWeight=2.95 PerfScore 11.79
+G_M47095_IG21:
        cmp      byte  ptr [rsi+0x2B], 0
-       jne      G_M47095_IG85
+       jne      G_M47095_IG87
        mov      rcx, rsi
        call     [<unknown method>]
-						;; size=19 bbWeight=5.82 PerfScore 42.17
-G_M47095_IG21:
-       test     eax, eax
-       je       G_M47095_IG56
-						;; size=8 bbWeight=5.82 PerfScore 7.27
+						;; size=19 bbWeight=5.68 PerfScore 41.15
 G_M47095_IG22:
+       test     eax, eax
+       je       G_M47095_IG57
+						;; size=8 bbWeight=5.68 PerfScore 7.10
+G_M47095_IG23:
        movzx    r10, byte  ptr [rsi+0x28]
        cmp      r10d, 4
-       je       G_M47095_IG71
-						;; size=15 bbWeight=5.82 PerfScore 18.90
-G_M47095_IG23:
-       cmp      r10d, 11
-       je       G_M47095_IG87
-						;; size=10 bbWeight=4.82 PerfScore 6.03
+       je       G_M47095_IG72
+						;; size=15 bbWeight=5.68 PerfScore 18.45
 G_M47095_IG24:
-       cmp      byte  ptr [r13+0x10], 2
-       je       G_M47095_IG108
-						;; size=11 bbWeight=4.82 PerfScore 19.28
+       cmp      r10d, 11
+       je       G_M47095_IG89
+						;; size=10 bbWeight=4.70 PerfScore 5.87
 G_M47095_IG25:
+       cmp      byte  ptr [r13+0x10], 2
+       je       G_M47095_IG110
+						;; size=11 bbWeight=4.70 PerfScore 18.79
+G_M47095_IG26:
        mov      r9d, dword ptr [rbx+0x24]
        test     r9d, r9d
        setne    r11b
        movzx    r11, r11b
        mov      dword ptr [rsp+0x244], r11d
        cmp      byte  ptr [r13+0x12], 0
-       jne      G_M47095_IG107
-						;; size=34 bbWeight=4.82 PerfScore 40.97
-G_M47095_IG26:
+       jne      G_M47095_IG109
+						;; size=34 bbWeight=4.70 PerfScore 39.92
+G_M47095_IG27:
        mov      rcx, gword ptr [rbx+0x30]
        mov      gword ptr [rsp+0x88], rcx
        mov      rdx, gword ptr [rbx+0x50]
        mov      gword ptr [rsp+0x80], rdx
        test     r9d, r9d
-       jne      G_M47095_IG97
+       jne      G_M47095_IG99
        cmp      dword ptr [rbx+0x20], 0
-       je       G_M47095_IG59
-						;; size=43 bbWeight=4.79 PerfScore 53.86
-G_M47095_IG27:
-       test     rcx, rcx
-       je       G_M47095_IG57
-						;; size=9 bbWeight=4.79 PerfScore 5.98
+       je       G_M47095_IG60
+						;; size=43 bbWeight=4.69 PerfScore 52.78
 G_M47095_IG28:
+       test     rcx, rcx
+       je       G_M47095_IG58
+						;; size=9 bbWeight=4.67 PerfScore 5.84
+G_M47095_IG29:
        mov      rcx, gword ptr [rcx+0x88]
        mov      gword ptr [rsp+0x68], rcx
        cmp      byte  ptr [rcx+0x115], 2
-       jne      G_M47095_IG90
-						;; size=25 bbWeight=4.78 PerfScore 33.47
-G_M47095_IG29:
-       mov      rax, rcx
-						;; size=3 bbWeight=4.78 PerfScore 1.20
+       jne      G_M47095_IG92
+						;; size=25 bbWeight=4.66 PerfScore 32.65
 G_M47095_IG30:
+       mov      rax, rcx
+						;; size=3 bbWeight=4.66 PerfScore 1.17
+G_M47095_IG31:
        mov      gword ptr [rsp+0x70], rax
        test     rax, rax
-       je       G_M47095_IG91
-						;; size=14 bbWeight=4.79 PerfScore 10.77
-G_M47095_IG31:
+       je       G_M47095_IG93
+						;; size=14 bbWeight=4.67 PerfScore 10.51
+G_M47095_IG32:
        movzx    r10, byte  ptr [rbx+0x94]
        mov      byte  ptr [rsp+0xC4], r10b
        mov      r9d, dword ptr [rbx+0x98]
        mov      dword ptr [rsp+0xC0], r9d
        mov      rcx, gword ptr [rbx]
        test     rcx, rcx
-       je       G_M47095_IG58
-						;; size=43 bbWeight=4.79 PerfScore 44.28
-G_M47095_IG32:
+       je       G_M47095_IG59
+						;; size=43 bbWeight=4.67 PerfScore 43.19
+G_M47095_IG33:
        mov      r15d, dword ptr [rbx+0x20]
        dec      r15d
        cmp      r15d, dword ptr [rcx+0x08]
-       je       G_M47095_IG93
+       je       G_M47095_IG95
        mov      gword ptr [rsp+0x2C0], rbp
-						;; size=25 bbWeight=4.78 PerfScore 34.63
-G_M47095_IG33:
+						;; size=25 bbWeight=4.66 PerfScore 33.78
+G_M47095_IG34:
        mov      r15, gword ptr [rbx]
        mov      ecx, dword ptr [rbx+0x20]
        dec      ecx
@@ -2483,7 +2485,7 @@ G_M47095_IG33:
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
        mov      ebp, dword ptr [rsp+0x1B4]
        cmp      ebp, dword ptr [r15+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        mov      ecx, ebp
        imul     rcx, rcx, 112
        lea      rcx, bword ptr [r15+rcx+0x10]
@@ -2516,69 +2518,69 @@ G_M47095_IG33:
        mov      rax, rbp
        movzx    rdx, byte  ptr [rsp+0xC4]
        test     edx, edx
-       jne      G_M47095_IG94
+       jne      G_M47095_IG96
        mov      rcx, gword ptr [rbx+0x30]
        movzx    r8, byte  ptr [rcx+0xC8]
        mov      r10d, dword ptr [rcx+0xCC]
-						;; size=236 bbWeight=4.79 PerfScore 292.39
-G_M47095_IG34:
+						;; size=236 bbWeight=4.67 PerfScore 285.23
+G_M47095_IG35:
        mov      byte  ptr [rax+0x64], r8b
        mov      dword ptr [rax+0x68], r10d
        cmp      byte  ptr [rbx+0x29], 0
-       jne      G_M47095_IG96
+       jne      G_M47095_IG98
        mov      r9, gword ptr [r15+0x98]
        test     r9, r9
-       jne      G_M47095_IG95
+       jne      G_M47095_IG97
        xor      r11d, r11d
-						;; size=37 bbWeight=4.79 PerfScore 45.47
-G_M47095_IG35:
-       mov      byte  ptr [rbp+0x5B], r11b
-						;; size=4 bbWeight=4.79 PerfScore 4.79
+						;; size=37 bbWeight=4.67 PerfScore 44.36
 G_M47095_IG36:
+       mov      byte  ptr [rbp+0x5B], r11b
+						;; size=4 bbWeight=4.67 PerfScore 4.67
+G_M47095_IG37:
        mov      rcx, gword ptr [rbx+0x58]
        cmp      gword ptr [rcx+0x08], 0
-       jne      G_M47095_IG100
-						;; size=15 bbWeight=4.79 PerfScore 28.73
-G_M47095_IG37:
-       cmp      dword ptr [rsp+0x244], 0
-       jne      SHORT G_M47095_IG43
-						;; size=10 bbWeight=4.79 PerfScore 14.36
+       jne      G_M47095_IG102
+						;; size=15 bbWeight=4.69 PerfScore 28.15
 G_M47095_IG38:
+       cmp      dword ptr [rsp+0x244], 0
+       jne      SHORT G_M47095_IG44
+						;; size=10 bbWeight=4.69 PerfScore 14.08
+G_M47095_IG39:
        lea      rbp, bword ptr [rbx+0x30]
        mov      rax, rbp
        mov      r8d, dword ptr [rsi+0x58]
        mov      r10d, r8d
        movzx    rcx, byte  ptr [rsi+0x28]
        cmp      ecx, 1
-       je       SHORT G_M47095_IG41
-						;; size=23 bbWeight=4.82 PerfScore 30.10
-G_M47095_IG39:
-       cmp      ecx, 3
-       jne      SHORT G_M47095_IG42
-						;; size=5 bbWeight=3.42 PerfScore 4.28
+       je       SHORT G_M47095_IG42
+						;; size=23 bbWeight=4.69 PerfScore 29.32
 G_M47095_IG40:
-       mov      rbp, gword ptr [rsp+0x2C0]
-       jmp      G_M47095_IG60
-						;; size=13 bbWeight=0.31 PerfScore 0.92
+       cmp      ecx, 3
+       jne      SHORT G_M47095_IG43
+						;; size=5 bbWeight=3.25 PerfScore 4.07
 G_M47095_IG41:
        mov      rbp, gword ptr [rsp+0x2C0]
-       jmp      G_M47095_IG60
-						;; size=13 bbWeight=1.39 PerfScore 4.18
+       jmp      G_M47095_IG61
+						;; size=13 bbWeight=0.29 PerfScore 0.88
 G_M47095_IG42:
-       mov      dword ptr [rax+0x50], r10d
-						;; size=4 bbWeight=4.82 PerfScore 4.82
+       mov      rbp, gword ptr [rsp+0x2C0]
+       jmp      G_M47095_IG61
+						;; size=13 bbWeight=1.44 PerfScore 4.32
 G_M47095_IG43:
-       cmp      gword ptr [rsp+0x80], 0
-       je       SHORT G_M47095_IG45
-						;; size=11 bbWeight=4.82 PerfScore 14.46
+       mov      dword ptr [rax+0x50], r10d
+						;; size=4 bbWeight=4.69 PerfScore 4.69
 G_M47095_IG44:
+       cmp      gword ptr [rsp+0x80], 0
+       je       SHORT G_M47095_IG46
+						;; size=11 bbWeight=4.70 PerfScore 14.09
+G_M47095_IG45:
        mov      r15, gword ptr [rsp+0x88]
        test     r15, r15
-       je       SHORT G_M47095_IG45
+       je       SHORT G_M47095_IG46
        cmp      byte  ptr [r15+0xAA], 0
-       je       G_M47095_IG61
-						;; size=27 bbWeight=4.78 PerfScore 29.87
-G_M47095_IG45:
+       je       G_M47095_IG62
+						;; size=27 bbWeight=4.69 PerfScore 29.32
+G_M47095_IG46:
        mov      rcx, qword ptr [r12+0x30]
        mov      rcx, qword ptr [rcx+0x10]
        mov      rcx, qword ptr [rcx+0x08]
@@ -2596,19 +2598,19 @@ G_M47095_IG45:
        movzx    rcx, byte  ptr [rbx+0x90]
        mov      dword ptr [rsp+0x258], ecx
        test     eax, eax
-       je       G_M47095_IG102
+       je       G_M47095_IG104
        mov      eax, dword ptr [rbx+0x20]
        dec      eax
        mov      dword ptr [rbx+0x20], eax
        test     eax, eax
-       jle      SHORT G_M47095_IG47
-						;; size=93 bbWeight=4.82 PerfScore 126.54
-G_M47095_IG46:
+       jle      SHORT G_M47095_IG48
+						;; size=93 bbWeight=4.70 PerfScore 123.28
+G_M47095_IG47:
        mov      rcx, gword ptr [rbx]
        mov      edx, dword ptr [rbx+0x20]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        imul     rdx, rdx, 112
        lea      rdx, bword ptr [rcx+rdx+0x10]
        cmp      byte  ptr [rdx], dl
@@ -2617,47 +2619,47 @@ G_M47095_IG46:
        cmp      byte  ptr [rcx], cl
        mov      r8d, 112
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
-						;; size=49 bbWeight=4.82 PerfScore 102.33
-G_M47095_IG47:
-       cmp      r12, r14
-       jne      G_M47095_IG63
-						;; size=9 bbWeight=4.82 PerfScore 6.03
+						;; size=49 bbWeight=4.69 PerfScore 99.70
 G_M47095_IG48:
+       cmp      r12, r14
+       jne      G_M47095_IG64
+						;; size=9 bbWeight=4.70 PerfScore 5.87
+G_M47095_IG49:
        mov      rdx, gword ptr [rbx+0x50]
        mov      rcx, rdx
        test     rcx, rcx
-       je       SHORT G_M47095_IG51
-						;; size=12 bbWeight=4.05 PerfScore 14.17
-G_M47095_IG49:
+       je       SHORT G_M47095_IG52
+						;; size=12 bbWeight=3.80 PerfScore 13.31
+G_M47095_IG50:
        mov      rax, 0xD1FFAB1E      ; <unknown class>
        cmp      qword ptr [rcx], rax
-       je       SHORT G_M47095_IG51
-						;; size=15 bbWeight=2.02 PerfScore 8.60
-G_M47095_IG50:
+       je       SHORT G_M47095_IG52
+						;; size=15 bbWeight=1.90 PerfScore 8.08
+G_M47095_IG51:
        mov      rcx, rax
        call     [CORINFO_HELP_CHKCASTCLASS_SPECIAL]
        mov      rcx, rax
-						;; size=12 bbWeight=1.01 PerfScore 3.54
-G_M47095_IG51:
+						;; size=12 bbWeight=0.95 PerfScore 3.33
+G_M47095_IG52:
        mov      r8, gword ptr [rsp+0x260]
        inc      dword ptr [rcx+0x14]
        mov      rax, gword ptr [rcx+0x08]
        mov      edx, dword ptr [rcx+0x10]
        cmp      dword ptr [rax+0x08], edx
-       jbe      G_M47095_IG62
-       jmp      G_M47095_IG19
-						;; size=32 bbWeight=4.05 PerfScore 56.69
-G_M47095_IG52:
+       jbe      G_M47095_IG63
+       jmp      G_M47095_IG20
+						;; size=32 bbWeight=3.80 PerfScore 53.26
+G_M47095_IG53:
        mov      rax, gword ptr [rbx]
        mov      ecx, dword ptr [rbx+0x20]
        add      ecx, -2
        cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        imul     rcx, rcx, 112
        mov      rax, gword ptr [rax+rcx+0x10]
        jmp      G_M47095_IG07
-						;; size=32 bbWeight=0.16 PerfScore 2.29
-G_M47095_IG53:
+						;; size=32 bbWeight=0.15 PerfScore 2.20
+G_M47095_IG54:
        mov      gword ptr [rsp+0x2C0], rbp
        mov      rcx, rbp
        mov      rdx, rsi
@@ -2666,35 +2668,35 @@ G_M47095_IG53:
        mov      rax, qword ptr [r12+0x68]
        call     [rax+0x28]<unknown method>
        mov      rbp, gword ptr [rsp+0x2C0]
-       jmp      G_M47095_IG12
-						;; size=41 bbWeight=0.07 PerfScore 0.70
-G_M47095_IG54:
+       jmp      G_M47095_IG13
+						;; size=41 bbWeight=0.07 PerfScore 0.69
+G_M47095_IG55:
        mov      rcx, r12
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
-       jmp      G_M47095_IG14
-						;; size=26 bbWeight=0.20 PerfScore 0.75
-G_M47095_IG55:
+       jmp      G_M47095_IG15
+						;; size=26 bbWeight=0.20 PerfScore 0.73
+G_M47095_IG56:
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
-       jmp      G_M47095_IG16
-						;; size=23 bbWeight=0.20 PerfScore 0.70
-G_M47095_IG56:
+       jmp      G_M47095_IG17
+						;; size=23 bbWeight=0.20 PerfScore 0.69
+G_M47095_IG57:
        cmp      byte  ptr [rsi+0x24], 0
-       je       G_M47095_IG22
+       je       G_M47095_IG23
        movzx    r10, byte  ptr [rsi+0x28]
        mov      eax, r10d
        test     eax, eax
-       jne      G_M47095_IG22
-       jmp      G_M47095_IG86
+       jne      G_M47095_IG23
+       jmp      G_M47095_IG88
 						;; size=31 bbWeight=0.00 PerfScore 0.01
-G_M47095_IG57:
-       xor      rax, rax
-       jmp      G_M47095_IG30
-						;; size=7 bbWeight=0.00 PerfScore 0.01
 G_M47095_IG58:
+       xor      rax, rax
+       jmp      G_M47095_IG31
+						;; size=7 bbWeight=0.00 PerfScore 0.01
+G_M47095_IG59:
        mov      rcx, 0xD1FFAB1E      ; <unknown class>
        mov      edx, 4
        call     CORINFO_HELP_NEWARR_1_VC
@@ -2702,105 +2704,105 @@ G_M47095_IG58:
        mov      rcx, rbx
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG33
+       jmp      G_M47095_IG34
 						;; size=44 bbWeight=0.01 PerfScore 0.06
-G_M47095_IG59:
+G_M47095_IG60:
        mov      dword ptr [rbx+0x20], 1
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG36
-						;; size=20 bbWeight=0.00 PerfScore 0.00
-G_M47095_IG60:
+       jmp      G_M47095_IG37
+						;; size=20 bbWeight=0.02 PerfScore 0.09
+G_M47095_IG61:
        lea      r10d, [r8-0x01]
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG42
-						;; size=17 bbWeight=1.76 PerfScore 6.17
-G_M47095_IG61:
+       jmp      G_M47095_IG43
+						;; size=17 bbWeight=1.69 PerfScore 5.93
+G_M47095_IG62:
        mov      rbp, gword ptr [rsp+0x2C0]
        mov      byte  ptr [rbx+0x8F], 1
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG45
-						;; size=28 bbWeight=0.83 PerfScore 4.15
-G_M47095_IG62:
+       jmp      G_M47095_IG46
+						;; size=28 bbWeight=0.80 PerfScore 4.01
+G_M47095_IG63:
        mov      rbp, gword ptr [rsp+0x2C0]
        mov      rdx, r8
        call     [<unknown method>]
-       jmp      G_M47095_IG20
-						;; size=22 bbWeight=0.89 PerfScore 5.58
-G_M47095_IG63:
+       jmp      G_M47095_IG21
+						;; size=22 bbWeight=0.86 PerfScore 5.35
+G_M47095_IG64:
        mov      rbp, gword ptr [rsp+0x2C0]
        lea      rdx, [rsp+0x260]
        mov      rcx, rbp
        mov      r8, rbx
        mov      rax, qword ptr [r12+0x68]
        call     [rax+0x20]<unknown method>
-       jmp      G_M47095_IG20
-						;; size=35 bbWeight=0.77 PerfScore 6.94
-G_M47095_IG64:
-       cmp      byte  ptr [rbx+0x8A], 0
-       je       G_M47095_IG114
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+       jmp      G_M47095_IG21
+						;; size=35 bbWeight=0.89 PerfScore 8.03
 G_M47095_IG65:
-       cmp      byte  ptr [rbx+0x8B], 0
-       jne      G_M47095_IG116
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+       cmp      byte  ptr [rbx+0x8A], 0
+       je       G_M47095_IG116
+						;; size=13 bbWeight=0.02 PerfScore 0.08
 G_M47095_IG66:
-       test     byte  ptr [rbx+0x8D], 8
-       jne      G_M47095_IG120
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+       cmp      byte  ptr [rbx+0x8B], 0
+       jne      G_M47095_IG118
+						;; size=13 bbWeight=0.02 PerfScore 0.08
 G_M47095_IG67:
-       cmp      byte  ptr [rbx+0x8A], 4
-       jb       G_M47095_IG122
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+       test     byte  ptr [rbx+0x8D], 8
+       jne      G_M47095_IG122
+						;; size=13 bbWeight=0.02 PerfScore 0.08
 G_M47095_IG68:
-       cmp      byte  ptr [rbx+0x8A], 5
-       jb       G_M47095_IG126
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+       cmp      byte  ptr [rbx+0x8A], 4
+       jb       G_M47095_IG124
+						;; size=13 bbWeight=0.02 PerfScore 0.08
 G_M47095_IG69:
-       cmp      byte  ptr [rbx+0x8A], 6
-       jb       G_M47095_IG138
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+       cmp      byte  ptr [rbx+0x8A], 5
+       jb       G_M47095_IG128
+						;; size=13 bbWeight=0.02 PerfScore 0.08
 G_M47095_IG70:
-       cmp      byte  ptr [rbx+0x8A], 7
+       cmp      byte  ptr [rbx+0x8A], 6
        jb       G_M47095_IG140
-						;; size=13 bbWeight=0.00 PerfScore 0.02
+						;; size=13 bbWeight=0.02 PerfScore 0.08
 G_M47095_IG71:
+       cmp      byte  ptr [rbx+0x8A], 7
+       jb       G_M47095_IG142
+						;; size=13 bbWeight=0.02 PerfScore 0.08
+G_M47095_IG72:
        mov      r12, qword ptr [rbp]
        mov      r14, 0xD1FFAB1E      ; <unknown class>
        cmp      r12, r14
-       jne      G_M47095_IG142
-						;; size=23 bbWeight=1.00 PerfScore 3.50
-G_M47095_IG72:
+       jne      SHORT G_M47095_IG80
+						;; size=19 bbWeight=1 PerfScore 3.50
+G_M47095_IG73:
        mov      rsi, gword ptr [rbx+0x50]
        mov      r15, gword ptr [rsp+0xA0]
        mov      rax, gword ptr [r15+0x40]
        test     rax, rax
-       jne      G_M47095_IG143
-						;; size=25 bbWeight=1.00 PerfScore 6.25
-G_M47095_IG73:
+       jne      G_M47095_IG144
+						;; size=25 bbWeight=1 PerfScore 6.25
+G_M47095_IG74:
        mov      rcx, qword ptr [r12+0x30]
        mov      rcx, qword ptr [rcx+0x10]
        mov      rcx, qword ptr [rcx]
        mov      rdx, rsi
        test     rdx, rdx
-       je       SHORT G_M47095_IG76
-						;; size=20 bbWeight=1.00 PerfScore 7.50
-G_M47095_IG74:
-       cmp      qword ptr [rdx], rcx
-       je       SHORT G_M47095_IG76
-						;; size=5 bbWeight=0.50 PerfScore 2.00
+       je       SHORT G_M47095_IG77
+						;; size=20 bbWeight=1 PerfScore 7.50
 G_M47095_IG75:
+       cmp      qword ptr [rdx], rcx
+       je       SHORT G_M47095_IG77
+						;; size=5 bbWeight=0.50 PerfScore 2.00
+G_M47095_IG76:
        mov      rdx, rsi
        call     CORINFO_HELP_CHKCASTANY
        mov      rdx, rax
-						;; size=11 bbWeight=0.25 PerfScore 0.37
-G_M47095_IG76:
+						;; size=11 bbWeight=0.25 PerfScore 0.38
+G_M47095_IG77:
        mov      rcx, bword ptr [rsp+0x2E8]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-						;; size=13 bbWeight=1.00 PerfScore 2.00
-G_M47095_IG77:
-       mov      eax, 1
-						;; size=5 bbWeight=1.00 PerfScore 0.25
+						;; size=13 bbWeight=1 PerfScore 2.00
 G_M47095_IG78:
+       mov      eax, 1
+						;; size=5 bbWeight=1 PerfScore 0.25
+G_M47095_IG79:
        add      rsp, 632
        pop      rbx
        pop      rbp
@@ -2811,13 +2813,21 @@ G_M47095_IG78:
        pop      r14
        pop      r15
        ret      
-						;; size=20 bbWeight=1.00 PerfScore 5.25
-G_M47095_IG79:
+						;; size=20 bbWeight=1 PerfScore 5.25
+G_M47095_IG80:
+       mov      rcx, rbp
+       mov      rdx, rbx
+       mov      r8, rdi
+       mov      rax, qword ptr [r12+0x68]
+       call     [rax+0x30]System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon]:ConvertCollection(byref,System.Text.Json.JsonSerializerOptions):this
+       jmp      SHORT G_M47095_IG73
+						;; size=19 bbWeight=0.04 PerfScore 0.31
+G_M47095_IG81:
        mov      rcx, r13
        call     [<unknown method>]
        jmp      G_M47095_IG03
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M47095_IG80:
+G_M47095_IG82:
        mov      rax, gword ptr [rax+0x20]
        mov      gword ptr [rsp+0x48], rax
        mov      rcx, rbx
@@ -2837,29 +2847,29 @@ G_M47095_IG80:
        test     rcx, rcx
        setne    cl
        movzx    rcx, cl
-       jmp      G_M47095_IG09
+       jmp      G_M47095_IG10
 						;; size=88 bbWeight=0 PerfScore 0.00
-G_M47095_IG81:
+G_M47095_IG83:
        mov      rcx, gword ptr [rbx+0x58]
        mov      rcx, gword ptr [rcx+0xB8]
        call     [System.Text.Json.ThrowHelper:ThrowNotSupportedException_SerializationNotSupported(System.Type)]
        int3     
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M47095_IG82:
+G_M47095_IG84:
        mov      rdx, gword ptr [rbx+0x50]
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
-       jmp      G_M47095_IG13
+       jmp      G_M47095_IG14
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M47095_IG83:
+G_M47095_IG85:
        cmp      byte  ptr [rbx+0x94], 0
-       jne      G_M47095_IG20
+       jne      G_M47095_IG21
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M47095_IG84:
+G_M47095_IG86:
        mov      rcx, rsi
        call     [System.Text.Json.Utf8JsonReader:Read():ubyte:this]
        cmp      byte  ptr [rsi+0x28], 4
-       je       G_M47095_IG71
+       je       G_M47095_IG72
        mov      r8, gword ptr [r13+0x20]
        mov      rcx, r13
        mov      rdx, rsi
@@ -2873,16 +2883,16 @@ G_M47095_IG84:
        mov      r8, rbx
        mov      rax, qword ptr [r12+0x68]
        call     [rax+0x20]<unknown method>
-       jmp      SHORT G_M47095_IG84
+       jmp      SHORT G_M47095_IG86
 						;; size=75 bbWeight=0 PerfScore 0.00
-G_M47095_IG85:
+G_M47095_IG87:
        mov      rcx, rsi
        call     [<unknown method>]
-       jmp      G_M47095_IG21
+       jmp      G_M47095_IG22
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M47095_IG86:
+G_M47095_IG88:
        cmp      byte  ptr [rsi+0x46], 0
-       jne      G_M47095_IG22
+       jne      G_M47095_IG23
        xor      r9, r9
        mov      bword ptr [rsp+0xB0], r9
        xor      r9d, r9d
@@ -2894,30 +2904,30 @@ G_M47095_IG86:
        call     [System.Text.Json.ThrowHelper:ThrowJsonReaderException(byref,int,ubyte,System.ReadOnlySpan`1[ubyte])]
        int3     
 						;; size=58 bbWeight=0 PerfScore 0.00
-G_M47095_IG87:
+G_M47095_IG89:
        mov      r15, gword ptr [rsp+0xA0]
        cmp      byte  ptr [r13+0x16], 0
-       jne      SHORT G_M47095_IG89
+       jne      SHORT G_M47095_IG91
        mov      r9d, dword ptr [rbx+0x24]
        test     r9d, r9d
-       jne      SHORT G_M47095_IG88
+       jne      SHORT G_M47095_IG90
        xor      rcx, rcx
        mov      gword ptr [rsp+0x260], rcx
-       jmp      G_M47095_IG113
+       jmp      G_M47095_IG115
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M47095_IG88:
-       jmp      G_M47095_IG24
-						;; size=5 bbWeight=0 PerfScore 0.00
-G_M47095_IG89:
-       jmp      G_M47095_IG24
-						;; size=5 bbWeight=0 PerfScore 0.00
 G_M47095_IG90:
+       jmp      G_M47095_IG25
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M47095_IG91:
+       jmp      G_M47095_IG25
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M47095_IG92:
        mov      r15, gword ptr [rsp+0xA0]
        call     [<unknown method>]
        mov      rcx, gword ptr [rsp+0x68]
-       jmp      G_M47095_IG29
+       jmp      G_M47095_IG30
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M47095_IG91:
+G_M47095_IG93:
        mov      r15, gword ptr [rsp+0xA0]
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x20]
@@ -2925,45 +2935,45 @@ G_M47095_IG91:
        mov      rax, gword ptr [rcx+0x88]
        mov      gword ptr [rsp+0x60], rax
        cmp      byte  ptr [rax+0x115], 2
-       je       SHORT G_M47095_IG92
+       je       SHORT G_M47095_IG94
        mov      rcx, rax
        call     [<unknown method>]
        mov      rax, gword ptr [rsp+0x60]
 						;; size=55 bbWeight=0 PerfScore 0.00
-G_M47095_IG92:
+G_M47095_IG94:
        mov      gword ptr [rsp+0x70], rax
-       jmp      G_M47095_IG31
+       jmp      G_M47095_IG32
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M47095_IG93:
+G_M47095_IG95:
        mov      r15, gword ptr [rsp+0xA0]
        mov      ecx, dword ptr [rcx+0x08]
        lea      edx, [rcx+rcx]
        mov      rcx, rbx
        call     [System.Array:Resize[System.Text.Json.ReadStackFrame](byref,int)]
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG33
+       jmp      G_M47095_IG34
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M47095_IG94:
+G_M47095_IG96:
        movzx    rdx, byte  ptr [rsp+0xC4]
        movzx    r8, dl
        mov      r10d, dword ptr [rsp+0xC0]
-       jmp      G_M47095_IG34
+       jmp      G_M47095_IG35
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M47095_IG95:
-       movzx    r11, byte  ptr [r9+0x34]
-       jmp      G_M47095_IG35
-						;; size=10 bbWeight=0 PerfScore 0.00
-G_M47095_IG96:
-       mov      r11d, 1
-       jmp      G_M47095_IG35
-						;; size=11 bbWeight=0 PerfScore 0.00
 G_M47095_IG97:
+       movzx    r11, byte  ptr [r9+0x34]
+       jmp      G_M47095_IG36
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M47095_IG98:
+       mov      r11d, 1
+       jmp      G_M47095_IG36
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M47095_IG99:
        mov      r15, gword ptr [rsp+0xA0]
        mov      ecx, dword ptr [rbx+0x20]
        lea      eax, [rcx+0x01]
        mov      dword ptr [rbx+0x20], eax
        test     ecx, ecx
-       jle      G_M47095_IG98
+       jle      G_M47095_IG100
        mov      qword ptr [rsp+0xA8], r14
        mov      rax, gword ptr [rbx]
        mov      gword ptr [rsp+0x78], rax
@@ -2982,7 +2992,7 @@ G_M47095_IG97:
        mov      r14d, dword ptr [rsp+0x22C]
        mov      rcx, gword ptr [rsp+0x78]
        cmp      r14d, dword ptr [rcx+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        mov      edx, r14d
        imul     rdx, rdx, 112
        lea      rcx, bword ptr [rcx+rdx+0x10]
@@ -2994,7 +3004,7 @@ G_M47095_IG97:
        mov      edx, dword ptr [rbx+0x20]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        imul     rdx, rdx, 112
        lea      rdx, bword ptr [rcx+rdx+0x10]
        cmp      byte  ptr [rdx], dl
@@ -3005,68 +3015,68 @@ G_M47095_IG97:
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
        mov      r14, qword ptr [rsp+0xA8]
 						;; size=213 bbWeight=0 PerfScore 0.00
-G_M47095_IG98:
+G_M47095_IG100:
        mov      ecx, dword ptr [rbx+0x24]
        cmp      ecx, dword ptr [rbx+0x20]
-       jne      SHORT G_M47095_IG99
+       jne      SHORT G_M47095_IG101
        xor      ecx, ecx
        mov      dword ptr [rbx+0x24], ecx
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG36
-						;; size=26 bbWeight=0 PerfScore 0.00
-G_M47095_IG99:
-       mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG36
-						;; size=13 bbWeight=0 PerfScore 0.00
-G_M47095_IG100:
-       mov      rbp, gword ptr [rsp+0x2C0]
-       mov      r15, gword ptr [rsp+0xA0]
-       lea      rax, bword ptr [rbx+0x70]
-       cmp      gword ptr [rax], 0
-       mov      bword ptr [rsp+0x58], rax
-       jne      SHORT G_M47095_IG101
-       mov      rcx, 0xD1FFAB1E      ; System.Text.Json.ArgumentState
-       call     CORINFO_HELP_NEWSFAST
-       mov      rcx, bword ptr [rsp+0x58]
-       mov      rdx, rax
-       call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov      gword ptr [rsp+0x2C0], rbp
        jmp      G_M47095_IG37
-						;; size=72 bbWeight=0 PerfScore 0.00
+						;; size=26 bbWeight=0 PerfScore 0.00
 G_M47095_IG101:
        mov      gword ptr [rsp+0x2C0], rbp
        jmp      G_M47095_IG37
 						;; size=13 bbWeight=0 PerfScore 0.00
 G_M47095_IG102:
+       mov      rbp, gword ptr [rsp+0x2C0]
+       mov      r15, gword ptr [rsp+0xA0]
+       lea      rax, bword ptr [rbx+0x70]
+       cmp      gword ptr [rax], 0
+       mov      bword ptr [rsp+0x58], rax
+       jne      SHORT G_M47095_IG103
+       mov      rcx, 0xD1FFAB1E      ; System.Text.Json.ArgumentState
+       call     CORINFO_HELP_NEWSFAST
+       mov      rcx, bword ptr [rsp+0x58]
+       mov      rdx, rax
+       call     CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov      gword ptr [rsp+0x2C0], rbp
+       jmp      G_M47095_IG38
+						;; size=72 bbWeight=0 PerfScore 0.00
+G_M47095_IG103:
+       mov      gword ptr [rsp+0x2C0], rbp
+       jmp      G_M47095_IG38
+						;; size=13 bbWeight=0 PerfScore 0.00
+G_M47095_IG104:
        mov      rbp, gword ptr [rsp+0x2C0]
        mov      r15, gword ptr [rsp+0xA0]
        cmp      dword ptr [rbx+0x24], 0
-       jne      SHORT G_M47095_IG104
+       jne      SHORT G_M47095_IG106
        cmp      dword ptr [rbx+0x20], 1
-       je       SHORT G_M47095_IG103
+       je       SHORT G_M47095_IG105
        mov      rcx, rbx
        call     [System.Text.Json.ReadStack:EnsurePushCapacity():this]
        mov      eax, dword ptr [rbx+0x20]
        lea      ecx, [rax-0x01]
        mov      dword ptr [rbx+0x20], ecx
        mov      dword ptr [rbx+0x24], eax
-       jmp      SHORT G_M47095_IG105
+       jmp      SHORT G_M47095_IG107
 						;; size=51 bbWeight=0 PerfScore 0.00
-G_M47095_IG103:
+G_M47095_IG105:
        mov      dword ptr [rbx+0x24], 1
        xor      eax, eax
        mov      dword ptr [rbx+0x20], eax
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG47
+       jmp      G_M47095_IG48
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M47095_IG104:
+G_M47095_IG106:
        mov      eax, dword ptr [rbx+0x20]
        dec      eax
        mov      dword ptr [rbx+0x20], eax
        test     eax, eax
-       je       G_M47095_IG106
+       je       G_M47095_IG108
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M47095_IG105:
+G_M47095_IG107:
        mov      rax, gword ptr [rbx]
        mov      gword ptr [rsp+0x50], rax
        mov      r10d, dword ptr [rbx+0x20]
@@ -3082,7 +3092,7 @@ G_M47095_IG105:
        mov      ecx, dword ptr [rsp+0x13C]
        mov      rdx, gword ptr [rsp+0x50]
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        imul     rcx, rcx, 112
        lea      rcx, bword ptr [rdx+rcx+0x10]
        cmp      byte  ptr [rcx], cl
@@ -3093,7 +3103,7 @@ G_M47095_IG105:
        mov      edx, dword ptr [rbx+0x20]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M47095_IG149
+       jae      G_M47095_IG150
        imul     rdx, rdx, 112
        lea      rdx, bword ptr [rcx+rdx+0x10]
        cmp      byte  ptr [rdx], dl
@@ -3103,13 +3113,13 @@ G_M47095_IG105:
        mov      r8d, 112
        call     [CORINFO_HELP_BULK_WRITEBARRIER]
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG47
+       jmp      G_M47095_IG48
 						;; size=172 bbWeight=0 PerfScore 0.00
-G_M47095_IG106:
+G_M47095_IG108:
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG47
+       jmp      G_M47095_IG48
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M47095_IG107:
+G_M47095_IG109:
        mov      r15, gword ptr [rsp+0xA0]
        mov      rcx, qword ptr [r12+0x30]
        mov      rcx, qword ptr [rcx+0x10]
@@ -3125,16 +3135,16 @@ G_M47095_IG107:
        mov      rax, qword ptr [r13]
        mov      rax, qword ptr [rax+0x60]
        call     [rax+0x18]<unknown method>
-       jmp      G_M47095_IG113
+       jmp      G_M47095_IG115
 						;; size=72 bbWeight=0 PerfScore 0.00
-G_M47095_IG108:
+G_M47095_IG110:
        mov      r15, gword ptr [rsp+0xA0]
        cmp      byte  ptr [r13+0x19], 0
-       je       SHORT G_M47095_IG110
+       je       SHORT G_M47095_IG112
        cmp      byte  ptr [rbx+0x94], 0
-       je       SHORT G_M47095_IG109
+       je       SHORT G_M47095_IG111
        cmp      byte  ptr [r13+0x1A], 0
-       je       SHORT G_M47095_IG109
+       je       SHORT G_M47095_IG111
        lea      r8, bword ptr [rbx+0x94]
        mov      r8d, dword ptr [r8+0x04]
        mov      rcx, r13
@@ -3144,47 +3154,8 @@ G_M47095_IG108:
        mov      rax, qword ptr [rax+0x68]
        call     [rax+0x10]<unknown method>
        mov      gword ptr [rsp+0x260], rax
-       jmp      G_M47095_IG113
+       jmp      G_M47095_IG115
 						;; size=75 bbWeight=0 PerfScore 0.00
-G_M47095_IG109:
-       mov      rcx, qword ptr [r12+0x30]
-       mov      rcx, qword ptr [rcx+0x10]
-       mov      rcx, qword ptr [rcx+0x08]
-       call     CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
-       mov      r8, rax
-       mov      rdx, rsi
-       mov      rcx, r13
-       mov      r9, rdi
-       mov      rax, qword ptr [r13]
-       mov      rax, qword ptr [rax+0x60]
-       call     [rax+0x20]<unknown method>
-       mov      gword ptr [rsp+0x260], rax
-       jmp      G_M47095_IG113
-						;; size=54 bbWeight=0 PerfScore 0.00
-G_M47095_IG110:
-       mov      dword ptr [rsp+0x240], r10d
-       mov      rcx, rsi
-       call     [System.Text.Json.Utf8JsonReader:get_CurrentDepth():int:this]
-       mov      dword ptr [rsp+0x23C], eax
-       mov      r10, qword ptr [rsi+0x10]
-       movsxd   r11, dword ptr [rsi+0x20]
-       add      r10, r11
-       mov      qword ptr [rsp+0x230], r10
-       cmp      byte  ptr [rbx+0x94], 0
-       je       SHORT G_M47095_IG111
-       cmp      byte  ptr [r13+0x1A], 0
-       je       SHORT G_M47095_IG111
-       lea      r8, bword ptr [rbx+0x94]
-       mov      r8d, dword ptr [r8+0x04]
-       mov      rcx, r13
-       mov      rdx, rsi
-       mov      r9, rdi
-       mov      r11, qword ptr [r13]
-       mov      r11, qword ptr [r11+0x68]
-       call     [r11+0x10]<unknown method>
-       mov      gword ptr [rsp+0x260], rax
-       jmp      SHORT G_M47095_IG112
-						;; size=101 bbWeight=0 PerfScore 0.00
 G_M47095_IG111:
        mov      rcx, qword ptr [r12+0x30]
        mov      rcx, qword ptr [rcx+0x10]
@@ -3198,8 +3169,47 @@ G_M47095_IG111:
        mov      rax, qword ptr [rax+0x60]
        call     [rax+0x20]<unknown method>
        mov      gword ptr [rsp+0x260], rax
-						;; size=49 bbWeight=0 PerfScore 0.00
+       jmp      G_M47095_IG115
+						;; size=54 bbWeight=0 PerfScore 0.00
 G_M47095_IG112:
+       mov      dword ptr [rsp+0x240], r10d
+       mov      rcx, rsi
+       call     [System.Text.Json.Utf8JsonReader:get_CurrentDepth():int:this]
+       mov      dword ptr [rsp+0x23C], eax
+       mov      r10, qword ptr [rsi+0x10]
+       movsxd   r11, dword ptr [rsi+0x20]
+       add      r10, r11
+       mov      qword ptr [rsp+0x230], r10
+       cmp      byte  ptr [rbx+0x94], 0
+       je       SHORT G_M47095_IG113
+       cmp      byte  ptr [r13+0x1A], 0
+       je       SHORT G_M47095_IG113
+       lea      r8, bword ptr [rbx+0x94]
+       mov      r8d, dword ptr [r8+0x04]
+       mov      rcx, r13
+       mov      rdx, rsi
+       mov      r9, rdi
+       mov      r11, qword ptr [r13]
+       mov      r11, qword ptr [r11+0x68]
+       call     [r11+0x10]<unknown method>
+       mov      gword ptr [rsp+0x260], rax
+       jmp      SHORT G_M47095_IG114
+						;; size=101 bbWeight=0 PerfScore 0.00
+G_M47095_IG113:
+       mov      rcx, qword ptr [r12+0x30]
+       mov      rcx, qword ptr [rcx+0x10]
+       mov      rcx, qword ptr [rcx+0x08]
+       call     CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
+       mov      r8, rax
+       mov      rdx, rsi
+       mov      rcx, r13
+       mov      r9, rdi
+       mov      rax, qword ptr [r13]
+       mov      rax, qword ptr [rax+0x60]
+       call     [rax+0x20]<unknown method>
+       mov      gword ptr [rsp+0x260], rax
+						;; size=49 bbWeight=0 PerfScore 0.00
+G_M47095_IG114:
        mov      dword ptr [rsp+0x20], 1
        mov      bword ptr [rsp+0x28], rsi
        mov      rcx, r13
@@ -3208,74 +3218,74 @@ G_M47095_IG112:
        mov      r9, qword ptr [rsp+0x230]
        call     [System.Text.Json.Serialization.JsonConverter`1[System.__Canon]:VerifyRead(ubyte,int,long,ubyte,byref):this]
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M47095_IG113:
+G_M47095_IG115:
        xor      ecx, ecx
        mov      dword ptr [rsp+0x258], ecx
        mov      gword ptr [rsp+0x2C0], rbp
-       jmp      G_M47095_IG47
+       jmp      G_M47095_IG48
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M47095_IG114:
-       cmp      byte  ptr [rsi+0x28], 3
-       jne      SHORT G_M47095_IG115
-       mov      byte  ptr [rbx+0x8A], 2
-       jmp      G_M47095_IG65
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M47095_IG115:
-       cmp      byte  ptr [rbx+0x8B], 0
-       je       G_M47095_IG148
-       cmp      byte  ptr [rsi+0x28], 1
-       jne      G_M47095_IG148
-       mov      byte  ptr [rbx+0x8A], 1
-       jmp      G_M47095_IG65
-						;; size=35 bbWeight=0 PerfScore 0.00
 G_M47095_IG116:
+       cmp      byte  ptr [rsi+0x28], 3
+       jne      SHORT G_M47095_IG117
+       mov      byte  ptr [rbx+0x8A], 2
+       jmp      G_M47095_IG66
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M47095_IG117:
+       cmp      byte  ptr [rbx+0x8B], 0
+       je       G_M47095_IG149
+       cmp      byte  ptr [rsi+0x28], 1
+       jne      G_M47095_IG149
+       mov      byte  ptr [rbx+0x8A], 1
+       jmp      G_M47095_IG66
+						;; size=35 bbWeight=0 PerfScore 0.00
+G_M47095_IG118:
        cmp      byte  ptr [rbx+0x8A], 2
-       jae      G_M47095_IG66
+       jae      G_M47095_IG67
        mov      rcx, rbp
        mov      rdx, r15
        mov      r8, rsi
        mov      r9, rbx
        call     [<unknown method>]
        test     eax, eax
-       je       G_M47095_IG146
+       je       G_M47095_IG147
        cmp      byte  ptr [rbx+0x8D], 4
-       je       SHORT G_M47095_IG117
+       je       SHORT G_M47095_IG119
        mov      byte  ptr [rbx+0x8A], 2
-       jmp      G_M47095_IG66
+       jmp      G_M47095_IG67
 						;; size=60 bbWeight=0 PerfScore 0.00
-G_M47095_IG117:
+G_M47095_IG119:
        mov      r12, qword ptr [rbp]
        mov      rcx, qword ptr [r12+0x30]
        mov      rcx, qword ptr [rcx+0x10]
        mov      rcx, qword ptr [rcx+0x28]
        test     rcx, rcx
-       je       SHORT G_M47095_IG118
-       jmp      SHORT G_M47095_IG119
+       je       SHORT G_M47095_IG120
+       jmp      SHORT G_M47095_IG121
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M47095_IG118:
+G_M47095_IG120:
        mov      rcx, r12
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M47095_IG119:
+G_M47095_IG121:
        mov      rdx, rbx
        call     [<unknown method>]
        mov      rcx, bword ptr [rsp+0x2E8]
        mov      rdx, rax
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
-       jmp      G_M47095_IG77
+       jmp      G_M47095_IG78
 						;; size=30 bbWeight=0 PerfScore 0.00
-G_M47095_IG120:
+G_M47095_IG122:
        cmp      byte  ptr [rbx+0x8E], 1
-       je       G_M47095_IG67
+       je       G_M47095_IG68
        mov      rcx, rbp
        mov      rdx, r15
        mov      r8, rbx
        call     [System.Text.Json.Serialization.JsonConverter:ResolvePolymorphicConverter(System.Text.Json.Serialization.Metadata.JsonTypeInfo,byref):System.Text.Json.Serialization.JsonConverter:this]
        mov      r12, rax
        test     r12, r12
-       je       G_M47095_IG67
+       je       G_M47095_IG68
        mov      rcx, r12
        mov      rax, qword ptr [r12]
        mov      rax, qword ptr [rax+0x40]
@@ -3305,7 +3315,7 @@ G_M47095_IG120:
        call     [System.Text.Json.ReadStack:ExitPolymorphicConverter(ubyte):this]
        movzx    rax, sil
 						;; size=157 bbWeight=0 PerfScore 0.00
-G_M47095_IG121:
+G_M47095_IG123:
        add      rsp, 632
        pop      rbx
        pop      rbp
@@ -3317,15 +3327,15 @@ G_M47095_IG121:
        pop      r15
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M47095_IG122:
+G_M47095_IG124:
        cmp      byte  ptr [rbx+0x8B], 0
-       je       SHORT G_M47095_IG123
+       je       SHORT G_M47095_IG125
        mov      rcx, rbp
        mov      rdx, rsi
        mov      r8, rbx
        call     [System.Text.Json.JsonSerializer:ValidateMetadataForArrayConverter(System.Text.Json.Serialization.JsonConverter,byref,byref)]
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M47095_IG123:
+G_M47095_IG125:
        mov      rcx, rbp
        mov      rdx, rsi
        mov      r8, rbx
@@ -3334,7 +3344,7 @@ G_M47095_IG123:
        mov      rax, qword ptr [r12+0x68]
        call     [rax+0x28]<unknown method>
        test     byte  ptr [rbx+0x8D], 2
-       je       SHORT G_M47095_IG124
+       je       SHORT G_M47095_IG126
        mov      rcx, gword ptr [rbx+0x08]
        mov      rdx, gword ptr [rbx+0x10]
        mov      r8, gword ptr [rbx+0x50]
@@ -3344,49 +3354,49 @@ G_M47095_IG123:
        xor      rdx, rdx
        mov      gword ptr [rbx+0x10], rdx
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M47095_IG124:
+G_M47095_IG126:
        mov      rax, gword ptr [r15+0x38]
        test     rax, rax
-       je       SHORT G_M47095_IG125
+       je       SHORT G_M47095_IG127
        mov      rdx, gword ptr [rbx+0x50]
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M47095_IG125:
+G_M47095_IG127:
        mov      byte  ptr [rbx+0x8A], 4
-       jmp      G_M47095_IG68
+       jmp      G_M47095_IG69
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M47095_IG126:
+G_M47095_IG128:
        mov      r12, qword ptr [rbp]
        mov      rcx, r12
        mov      rdx, qword ptr [rcx+0x30]
        mov      rdx, qword ptr [rdx+0x10]
        mov      rax, qword ptr [rdx+0x20]
        test     rax, rax
-       je       SHORT G_M47095_IG127
-       mov      rcx, rax
-       jmp      SHORT G_M47095_IG128
-						;; size=29 bbWeight=0 PerfScore 0.00
-G_M47095_IG127:
-       mov      rdx, 0xD1FFAB1E      ; global ptr
-       call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov      rcx, rax
-						;; size=18 bbWeight=0 PerfScore 0.00
-G_M47095_IG128:
-       mov      rdx, qword ptr [rcx+0x30]
-       mov      rdx, qword ptr [rdx+0x10]
-       mov      rax, qword ptr [rdx+0x30]
-       test     rax, rax
        je       SHORT G_M47095_IG129
        mov      rcx, rax
        jmp      SHORT G_M47095_IG130
-						;; size=22 bbWeight=0 PerfScore 0.00
+						;; size=29 bbWeight=0 PerfScore 0.00
 G_M47095_IG129:
        mov      rdx, 0xD1FFAB1E      ; global ptr
        call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov      rcx, rax
 						;; size=18 bbWeight=0 PerfScore 0.00
 G_M47095_IG130:
+       mov      rdx, qword ptr [rcx+0x30]
+       mov      rdx, qword ptr [rdx+0x10]
+       mov      rax, qword ptr [rdx+0x30]
+       test     rax, rax
+       je       SHORT G_M47095_IG131
+       mov      rcx, rax
+       jmp      SHORT G_M47095_IG132
+						;; size=22 bbWeight=0 PerfScore 0.00
+G_M47095_IG131:
+       mov      rdx, 0xD1FFAB1E      ; global ptr
+       call     CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov      rcx, rax
+						;; size=18 bbWeight=0 PerfScore 0.00
+G_M47095_IG132:
        mov      rdx, r13
        call     CORINFO_HELP_CHKCASTCLASS
        mov      rax, gword ptr [rax+0x150]
@@ -3395,98 +3405,90 @@ G_M47095_IG130:
        lea      rcx, bword ptr [rbx+0x30]
        call     CORINFO_HELP_CHECKED_ASSIGN_REF
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M47095_IG131:
+G_M47095_IG133:
        cmp      byte  ptr [rbx+0x88], 3
-       jae      SHORT G_M47095_IG133
+       jae      SHORT G_M47095_IG135
        mov      r13, gword ptr [rsp+0x98]
        cmp      byte  ptr [r13+0x13], 0
-       je       SHORT G_M47095_IG132
+       je       SHORT G_M47095_IG134
        cmp      byte  ptr [rsi+0x24], 0
        sete     cl
        movzx    rcx, cl
        test     ecx, ecx
-       jne      SHORT G_M47095_IG134
+       jne      SHORT G_M47095_IG136
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M47095_IG132:
+G_M47095_IG134:
        mov      rcx, rsi
        call     [System.Text.Json.Utf8JsonReader:Read():ubyte:this]
-       jmp      SHORT G_M47095_IG135
+       jmp      SHORT G_M47095_IG137
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M47095_IG133:
+G_M47095_IG135:
        mov      r13, gword ptr [rsp+0x98]
-       jmp      SHORT G_M47095_IG136
+       jmp      SHORT G_M47095_IG138
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M47095_IG134:
+G_M47095_IG136:
        mov      rcx, rsi
        call     [System.Text.Json.JsonHelpers:TryAdvanceWithReadAhead(byref):ubyte]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M47095_IG135:
+G_M47095_IG137:
        test     eax, eax
-       je       G_M47095_IG146
+       je       G_M47095_IG147
        mov      byte  ptr [rbx+0x88], 3
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M47095_IG136:
-       cmp      byte  ptr [rbx+0x88], 4
-       jae      G_M47095_IG144
-       cmp      byte  ptr [rsi+0x28], 4
-       je       SHORT G_M47095_IG137
-       mov      byte  ptr [rbx+0x88], 4
-       jmp      G_M47095_IG144
-						;; size=31 bbWeight=0 PerfScore 0.00
-G_M47095_IG137:
-       mov      byte  ptr [rbx+0x8A], 5
-       jmp      G_M47095_IG69
-						;; size=12 bbWeight=0 PerfScore 0.00
 G_M47095_IG138:
-       test     byte  ptr [rbx+0x8D], 1
+       cmp      byte  ptr [rbx+0x88], 4
+       jae      G_M47095_IG145
+       cmp      byte  ptr [rsi+0x28], 4
        je       SHORT G_M47095_IG139
-       mov      rcx, rsi
-       call     [System.Text.Json.Utf8JsonReader:Read():ubyte:this]
-       test     eax, eax
-       je       G_M47095_IG146
-						;; size=26 bbWeight=0 PerfScore 0.00
+       mov      byte  ptr [rbx+0x88], 4
+       jmp      G_M47095_IG145
+						;; size=31 bbWeight=0 PerfScore 0.00
 G_M47095_IG139:
-       mov      byte  ptr [rbx+0x8A], 6
+       mov      byte  ptr [rbx+0x8A], 5
        jmp      G_M47095_IG70
 						;; size=12 bbWeight=0 PerfScore 0.00
 G_M47095_IG140:
        test     byte  ptr [rbx+0x8D], 1
-       je       G_M47095_IG71
-       cmp      byte  ptr [rsi+0x28], 2
-       je       G_M47095_IG71
-       cmp      byte  ptr [rdi+0x93], 0
        je       SHORT G_M47095_IG141
        mov      rcx, rsi
+       call     [System.Text.Json.Utf8JsonReader:Read():ubyte:this]
+       test     eax, eax
+       je       G_M47095_IG147
+						;; size=26 bbWeight=0 PerfScore 0.00
+G_M47095_IG141:
+       mov      byte  ptr [rbx+0x8A], 6
+       jmp      G_M47095_IG71
+						;; size=12 bbWeight=0 PerfScore 0.00
+G_M47095_IG142:
+       test     byte  ptr [rbx+0x8D], 1
+       je       G_M47095_IG72
+       cmp      byte  ptr [rsi+0x28], 2
+       je       G_M47095_IG72
+       cmp      byte  ptr [rdi+0x93], 0
+       je       SHORT G_M47095_IG143
+       mov      rcx, rsi
        call     [System.Text.Json.Utf8JsonReader:get_CurrentDepth():int:this]
        lea      edx, [rax-0x01]
        mov      rcx, rsi
        call     [System.Text.Json.Utf8JsonReader:TrySkipPartial(int):ubyte:this]
-       jmp      G_M47095_IG71
+       jmp      G_M47095_IG72
 						;; size=58 bbWeight=0 PerfScore 0.00
-G_M47095_IG141:
+G_M47095_IG143:
        mov      rcx, rbx
        mov      rdx, r14
        mov      r8, rsi
        call     [System.Text.Json.ThrowHelper:ThrowJsonException_MetadataInvalidPropertyInArrayMetadata(byref,System.Type,byref)]
-       jmp      G_M47095_IG71
-						;; size=20 bbWeight=0 PerfScore 0.00
-G_M47095_IG142:
-       mov      rcx, rbp
-       mov      rdx, rbx
-       mov      r8, rdi
-       mov      rax, qword ptr [r12+0x68]
-       call     [rax+0x30]System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon]:ConvertCollection(byref,System.Text.Json.JsonSerializerOptions):this
        jmp      G_M47095_IG72
-						;; size=22 bbWeight=0 PerfScore 0.00
-G_M47095_IG143:
+						;; size=20 bbWeight=0 PerfScore 0.00
+G_M47095_IG144:
        mov      rdx, rsi
        mov      rcx, gword ptr [rax+0x08]
        call     [rax+0x18]<unknown method>
-       jmp      G_M47095_IG73
+       jmp      G_M47095_IG74
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M47095_IG144:
+G_M47095_IG145:
        cmp      byte  ptr [rbx+0x88], 5
-       jae      SHORT G_M47095_IG145
+       jae      SHORT G_M47095_IG146
        mov      rcx, qword ptr [r12+0x30]
        mov      rcx, qword ptr [rcx+0x10]
        mov      rcx, qword ptr [rcx+0x08]
@@ -3503,7 +3505,7 @@ G_M47095_IG144:
        cmp      dword ptr [rcx], ecx
        call     [System.Text.Json.Serialization.JsonConverter`1[System.__Canon]:TryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref,byref):ubyte:this]
        test     eax, eax
-       je       SHORT G_M47095_IG146
+       je       SHORT G_M47095_IG147
        lea      rdx, [rsp+0x248]
        mov      rcx, rbp
        mov      r8, rbx
@@ -3513,17 +3515,17 @@ G_M47095_IG144:
        xor      rcx, rcx
        mov      gword ptr [rax+0x10], rcx
        mov      byte  ptr [rax+0x58], 0
-       jmp      G_M47095_IG131
+       jmp      G_M47095_IG133
 						;; size=123 bbWeight=0 PerfScore 0.00
-G_M47095_IG145:
-       jmp      G_M47095_IG131
-						;; size=5 bbWeight=0 PerfScore 0.00
 G_M47095_IG146:
+       jmp      G_M47095_IG133
+						;; size=5 bbWeight=0 PerfScore 0.00
+G_M47095_IG147:
        xor      rax, rax
        mov      rbx, bword ptr [rsp+0x2E8]
        mov      gword ptr [rbx], rax
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M47095_IG147:
+G_M47095_IG148:
        add      rsp, 632
        pop      rbx
        pop      rbp
@@ -3535,16 +3537,16 @@ G_M47095_IG147:
        pop      r15
        ret      
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M47095_IG148:
+G_M47095_IG149:
        mov      rcx, gword ptr [rbp+0x20]
        call     [System.Text.Json.ThrowHelper:ThrowJsonException_DeserializeUnableToConvertValue(System.Type)]
        int3     
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M47095_IG149:
+G_M47095_IG150:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 4440, prolog size 103, PerfScore 1278.10, instruction count 983, allocated bytes for code 4440 (MethodHash=93464808) for method System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (Tier1)
+; Total bytes of code 4433, prolog size 103, PerfScore 1247.54, instruction count 983, allocated bytes for code 4433 (MethodHash=93464808) for method System.Text.Json.Serialization.JsonCollectionConverter`2[System.__Canon,System.__Canon]:OnTryRead(byref,System.Type,System.Text.Json.JsonSerializerOptions,byref,byref):ubyte:this (Tier1)
 ; ============================================================
 


```

</details>

# ``Microsoft.Extensions.Primitives.StringSegmentBenchmark.Equals_Object_Valid``

Hot functions:

- (45.47%) ``SpanHelpers.SequenceEqual`` (Tier-1)
  - No diffs
- (37.36%) ``StringSegmentBenchmark.Equals_Object_Valid`` (Tier-1)
  - No diffs
- (12.22%) ``Runnable_0.WorkloadActionUnroll`` (FullOpt)
  - No diffs

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Common.ReplaceWords(Options: None)``

Hot functions:

- (76.42%) ``RegexInterpreter.TryMatchAtCurrentPosition`` (Tier-1)
  - **Has diffs**
- (8.39%) ``PackedSpanHelpers.IndexOfAny`` (Tier-1)
  - No diffs
- (7.90%) ``RegexFindOptimizations.TryFindNextStartingPositionLeftToRight`` (Tier-1)
  - No diffs
- (3.20%) ``Regex.RunAllMatchesWithCallback`` (Tier-1)
  - **Has diffs**

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]RegexInterpreter.TryMatchAtCurrentPosition(value class System.ReadOnlySpan`1<wchar>)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 655488
+; with Dynamic PGO: fgCalledCount is 847360
 ; 13 inlinees with PGO data; 162 single block inlinees; 11 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (490,208.61)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexInterpreter>
+;  V00 this         [V00,T00] (490,207.27)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexInterpreter>
 ;  V01 arg1         [V01,T35] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 loc0         [V02,T17] (  9, 22.31)     int  ->  rbp        
-;  V03 loc1         [V03,T01] (  7, 56.38)     int  ->  r14        
+;  V02 loc0         [V02,T17] (  9, 22.20)     int  ->  rbp        
+;  V03 loc1         [V03,T01] (  7, 56.13)     int  ->  r14        
 ;  V04 loc2         [V04,T102] (  5,  0   )     int  ->  rdx        
 ;  V05 loc3         [V05,T241] (  3,  0   )     int  ->  r12        
 ;  V06 loc4         [V06,T108] (  4,  0   )     int  ->  rdx        
@@ -5369,7 +5369,7 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;* V57 tmp9         [V57    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V58 tmp10        [V58    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V59 tmp11        [V59    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
-;  V60 tmp12        [V60,T51] (  2,  4.07)     int  ->  rdx         "impAppendStmt"
+;  V60 tmp12        [V60,T55] (  2,  4.09)     int  ->  rdx         "impAppendStmt"
 ;* V61 tmp13        [V61    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V62 tmp14        [V62    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V63 tmp15        [V63    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
@@ -5390,24 +5390,24 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V78 tmp30        [V78,T258] (  3,  0   )     int  ->  r14         "impSpillLclRefs"
 ;  V79 tmp31        [V79,T259] (  3,  0   )     int  ->  r14         "impSpillLclRefs"
 ;  V80 tmp32        [V80,T49] (  3,  6   )     int  ->  rax         "Inlining Arg"
-;  V81 tmp33        [V81,T03] (  3, 30.85)     int  ->  rax         "Inlining Arg"
+;  V81 tmp33        [V81,T03] (  3, 30.71)     int  ->  rax         "Inlining Arg"
 ;* V82 tmp34        [V82    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.RegularExpressions.Match>
 ;  V83 tmp35        [V83,T371] (  2,  0   )     int  ->  rdx         "Inlining Arg"
 ;* V84 tmp36        [V84    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V85 tmp37        [V85,T05] (  5, 29.94)     ref  ->  rax         class-hnd "impAppendStmt" <<unknown class>>
-;  V86 tmp38        [V86,T14] (  4, 23.95)     int  ->  rdx         "dup spill"
-;  V87 tmp39        [V87,T32] (  2, 11.98)     int  ->  rcx         "Inlining Arg"
-;  V88 tmp40        [V88,T15] (  4, 23.95)     int  ->  rdx         "dup spill"
-;  V89 tmp41        [V89,T33] (  2, 11.98)     int  ->  rcx         "Strict ordering of exceptions for Array store"
-;  V90 tmp42        [V90,T16] (  4, 23.85)     int  ->  r15         "Inlining Arg"
-;  V91 tmp43        [V91,T38] (  3,  8.95)     int  ->  r13         "Inline stloc first use temp"
-;  V92 tmp44        [V92,T25] (  3, 17.89)     int  ->  rax         "Inlining Arg"
-;  V93 tmp45        [V93,T54] (  4,  4.07)     int  ->  rcx         "Inline stloc first use temp"
-;  V94 tmp46        [V94,T44] (  3,  6.10)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
-;  V95 tmp47        [V95,T56] (  2,  4.07)     int  ->  rax         "Inlining Arg"
-;  V96 tmp48        [V96,T55] (  4,  4.07)     int  ->  rdx         "Inline stloc first use temp"
-;  V97 tmp49        [V97,T45] (  3,  6.10)     ref  ->  rax         class-hnd "impAppendStmt" <<unknown class>>
-;  V98 tmp50        [V98,T57] (  2,  4.07)     int  ->  rcx         "Strict ordering of exceptions for Array store"
+;  V85 tmp37        [V85,T05] (  5, 30.19)     ref  ->   r8         class-hnd "impAppendStmt" <<unknown class>>
+;  V86 tmp38        [V86,T14] (  4, 24.15)     int  ->   r9         "dup spill"
+;  V87 tmp39        [V87,T32] (  2, 12.07)     int  ->  rdx         "Inlining Arg"
+;  V88 tmp40        [V88,T15] (  4, 24.15)     int  ->   r9         "dup spill"
+;  V89 tmp41        [V89,T33] (  2, 12.07)     int  ->  rdx         "Strict ordering of exceptions for Array store"
+;  V90 tmp42        [V90,T16] (  4, 23.36)     int  ->  r15         "Inlining Arg"
+;  V91 tmp43        [V91,T38] (  3,  8.76)     int  ->  r13         "Inline stloc first use temp"
+;  V92 tmp44        [V92,T25] (  3, 17.52)     int  ->  rax         "Inlining Arg"
+;  V93 tmp45        [V93,T50] (  4,  4.13)     int  ->   r9         "Inline stloc first use temp"
+;  V94 tmp46        [V94,T43] (  3,  6.19)     ref  ->   r8         class-hnd "impAppendStmt" <<unknown class>>
+;  V95 tmp47        [V95,T52] (  2,  4.13)     int  ->  rdx         "Inlining Arg"
+;  V96 tmp48        [V96,T51] (  4,  4.13)     int  ->   r8         "Inline stloc first use temp"
+;  V97 tmp49        [V97,T44] (  3,  6.19)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
+;  V98 tmp50        [V98,T53] (  2,  4.13)     int  ->   r9         "Strict ordering of exceptions for Array store"
 ;  V99 tmp51        [V99,T121] (  4,  0   )     int  ->  rax         "Inline stloc first use temp"
 ;  V100 tmp52       [V100,T144] (  3,  0   )     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
 ;  V101 tmp53       [V101,T122] (  4,  0   )     int  ->  rdx         "Inline stloc first use temp"
@@ -5431,15 +5431,15 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V119 tmp71       [V119,T151] (  3,  0   )     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
 ;  V120 tmp72       [V120,T377] (  2,  0   )     int  ->  rax         "Inlining Arg"
 ;* V121 tmp73       [V121    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V122 tmp74       [V122,T34] (  5, 10.18)     ref  ->   r9         class-hnd "impAppendStmt" <<unknown class>>
-;  V123 tmp75       [V123,T39] (  4,  8.15)     int  ->  rcx         "dup spill"
-;  V124 tmp76       [V124,T40] (  4,  8.15)     int  ->  rcx         "dup spill"
-;  V125 tmp77       [V125,T52] (  2,  4.07)     int  ->   r8         "Inlining Arg"
-;  V126 tmp78       [V126,T50] (  4,  4.07)     int  ->   r8         "Inline stloc first use temp"
-;  V127 tmp79       [V127,T43] (  3,  6.11)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
-;  V128 tmp80       [V128,T53] (  2,  4.07)     int  ->   r9         "Strict ordering of exceptions for Array store"
+;  V122 tmp74       [V122,T34] (  5, 10.22)     ref  ->   r9         class-hnd "impAppendStmt" <<unknown class>>
+;  V123 tmp75       [V123,T39] (  4,  8.17)     int  ->  rcx         "dup spill"
+;  V124 tmp76       [V124,T40] (  4,  8.17)     int  ->  rcx         "dup spill"
+;  V125 tmp77       [V125,T56] (  2,  4.09)     int  ->   r8         "Inlining Arg"
+;  V126 tmp78       [V126,T54] (  4,  4.09)     int  ->   r8         "Inline stloc first use temp"
+;  V127 tmp79       [V127,T45] (  3,  6.13)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
+;  V128 tmp80       [V128,T57] (  2,  4.09)     int  ->   r9         "Strict ordering of exceptions for Array store"
 ;  V129 tmp81       [V129,T378] (  2,  0   )     int  ->  rcx         "Inlining Arg"
-;  V130 tmp82       [V130,T76] (  2,  0.11)     int  ->  rdx         "Inlining Arg"
+;  V130 tmp82       [V130,T75] (  2,  0.11)     int  ->  rdx         "Inlining Arg"
 ;  V131 tmp83       [V131,T129] (  4,  0   )   ubyte  ->  r14         "Inline return value spill temp"
 ;  V132 tmp84       [V132,T152] (  3,  0   )   byref  ->  rax         "Inlining Arg"
 ;  V133 tmp85       [V133,T98] (  5,  0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
@@ -5450,11 +5450,11 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V138 tmp90       [V138,T261] (  3,  0   )     int  ->  rdx         "Inline stloc first use temp"
 ;* V139 tmp91       [V139    ] (  0,  0   )   ubyte  ->  zero-ref    "Inline return value spill temp"
 ;  V140 tmp92       [V140,T12] (  5, 25.29)     ref  ->  r14         class-hnd exact "Inlining Arg" <System.String>
-;  V141 tmp93       [V141,T11] ( 10, 25.56)     int  ->  r12         "Inline stloc first use temp"
+;  V141 tmp93       [V141,T11] ( 10, 25.57)     int  ->  r12         "Inline stloc first use temp"
 ;  V142 tmp94       [V142,T28] (  9, 16.31)     int  ->  r15         "Inline stloc first use temp"
-;  V143 tmp95       [V143,T30] (  2, 13.23)     int  ->  r12         "dup spill"
+;  V143 tmp95       [V143,T30] (  2, 13.24)     int  ->  r12         "dup spill"
 ;* V144 tmp96       [V144    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V145 tmp97       [V145,T31] (  2, 13.23)     int  ->  r15         "dup spill"
+;  V145 tmp97       [V145,T31] (  2, 13.24)     int  ->  r15         "dup spill"
 ;  V146 tmp98       [V146,T131] (  4,  0   )   ubyte  ->  r14         "Inline return value spill temp"
 ;  V147 tmp99       [V147,T99] (  5,  0   )     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
 ;  V148 tmp100      [V148,T95] (  6,  0   )  ushort  ->  rax         "Inlining Arg"
@@ -5503,16 +5503,16 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V191 tmp143      [V191,T280] (  3,  0   )     int  ->  rcx         "Inline stloc first use temp"
 ;  V192 tmp144      [V192,T281] (  3,  0   )     int  ->  rdx         "Inline stloc first use temp"
 ;  V193 tmp145      [V193,T282] (  3,  0   )     int  ->   r8         "Inline return value spill temp"
-;  V194 tmp146      [V194,T13] (  7, 24.92)     int  ->  r12         "Inline stloc first use temp"
-;  V195 tmp147      [V195,T36] (  3,  9.97)     int  ->  rax         "Inline stloc first use temp"
-;  V196 tmp148      [V196,T08] (  3, 29.91)     int  ->  rax         "Inlining Arg"
-;  V197 tmp149      [V197,T29] (  3, 14.95)     int  ->  r15         "Inline stloc first use temp"
+;  V194 tmp146      [V194,T13] (  7, 24.71)     int  ->  r12         "Inline stloc first use temp"
+;  V195 tmp147      [V195,T36] (  3,  9.88)     int  ->  rax         "Inline stloc first use temp"
+;  V196 tmp148      [V196,T08] (  3, 29.65)     int  ->  rax         "Inlining Arg"
+;  V197 tmp149      [V197,T29] (  3, 14.82)     int  ->  r15         "Inline stloc first use temp"
 ;  V198 tmp150      [V198,T42] ( 23,  4.31)   byref  ->  rsi         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
 ;  V199 tmp151      [V199,T41] ( 29,  7.31)     int  ->  rdi         "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V200 tmp152      [V200    ] (  0,  0   )   byref  ->  zero-ref    "field V74._reference (fldOffset=0x0)" P-INDEP
 ;* V201 tmp153      [V201    ] (  0,  0   )     int  ->  zero-ref    "field V74._length (fldOffset=0x8)" P-INDEP
 ;* V202 tmp154      [V202,T58] (  0,  0   )   byref  ->  zero-ref    "field V144._reference (fldOffset=0x0)" P-INDEP
-;  V203 tmp155      [V203,T46] (  2,  6.00)     int  ->  rcx         "field V144._length (fldOffset=0x8)" P-INDEP
+;  V203 tmp155      [V203,T46] (  2,  6.00)     int  ->  rdx         "field V144._length (fldOffset=0x8)" P-INDEP
 ;  V204 tmp156      [V204,T156] (  3,  0   )   byref  ->  rcx         "field V158._reference (fldOffset=0x0)" P-INDEP
 ;* V205 tmp157      [V205    ] (  0,  0   )     int  ->  zero-ref    "field V158._length (fldOffset=0x8)" P-INDEP
 ;* V206 tmp158      [V206    ] (  0,  0   )   byref  ->  zero-ref    "field V161._reference (fldOffset=0x0)" P-INDEP
@@ -5523,8 +5523,8 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;* V211 tmp163      [V211    ] (  0,  0   )     int  ->  zero-ref    "field V169._length (fldOffset=0x8)" P-INDEP
 ;* V212 tmp164      [V212    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
 ;  V213 tmp165      [V213,T47] (  3,  6   )     ref  ->  rax         single-def "arr expr"
-;  V214 tmp166      [V214,T02] (  3, 30.85)     ref  ->  rax         "arr expr"
-;  V215 tmp167      [V215,T04] (  3, 30.85)     int  ->  rdx         "index expr"
+;  V214 tmp166      [V214,T02] (  3, 30.71)     ref  ->  rax         "arr expr"
+;  V215 tmp167      [V215,T04] (  3, 30.71)     int  ->  rdx         "index expr"
 ;  V216 tmp168      [V216,T157] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V217 tmp169      [V217,T283] (  3,  0   )     int  ->   r8         "index expr"
 ;  V218 tmp170      [V218,T158] (  3,  0   )     ref  ->   r8         "arr expr"
@@ -5600,11 +5600,11 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V288 tmp240      [V288,T186] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V289 tmp241      [V289,T312] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V290 tmp242      [V290,T393] (  2,  0   )     int  ->  rdx         "argument with side effect"
-;  V291 tmp243      [V291,T22] (  3, 17.89)     ref  ->  rdx         "arr expr"
-;  V292 tmp244      [V292,T26] (  3, 17.89)     int  ->  rax         "index expr"
-;  V293 tmp245      [V293,T23] (  3, 17.89)     ref  ->  rax         "arr expr"
-;  V294 tmp246      [V294,T27] (  3, 17.89)     int  ->  rdx         "index expr"
-;  V295 tmp247      [V295,T24] (  3, 17.89)     ref  ->  rax         "arr expr"
+;  V291 tmp243      [V291,T22] (  3, 17.52)     ref  ->  rdx         "arr expr"
+;  V292 tmp244      [V292,T26] (  3, 17.52)     int  ->  rax         "index expr"
+;  V293 tmp245      [V293,T23] (  3, 17.52)     ref  ->  rax         "arr expr"
+;  V294 tmp246      [V294,T27] (  3, 17.52)     int  ->  rdx         "index expr"
+;  V295 tmp247      [V295,T24] (  3, 17.52)     ref  ->  rax         "arr expr"
 ;  V296 tmp248      [V296,T187] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V297 tmp249      [V297,T313] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V298 tmp250      [V298,T188] (  3,  0   )     ref  ->  rdx         "arr expr"
@@ -5637,11 +5637,11 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V325 tmp277      [V325,T80] (  2,  0.08)     int  ->  rdx         "argument with side effect"
 ;  V326 tmp278      [V326,T200] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V327 tmp279      [V327,T325] (  3,  0   )     int  ->  rdx         "index expr"
-;  V328 tmp280      [V328,T65] (  3,  0.16)     ref  ->  rdx         "arr expr"
-;  V329 tmp281      [V329,T67] (  3,  0.16)     int  ->  rcx         "index expr"
-;  V330 tmp282      [V330,T66] (  3,  0.16)     ref  ->  rdx         "arr expr"
-;  V331 tmp283      [V331,T68] (  3,  0.16)     int  ->  rcx         "index expr"
-;  V332 tmp284      [V332,T77] (  2,  0.11)     int  ->  rdx         "argument with side effect"
+;  V328 tmp280      [V328,T59] (  3,  0.16)     ref  ->  rdx         "arr expr"
+;  V329 tmp281      [V329,T61] (  3,  0.16)     int  ->  rcx         "index expr"
+;  V330 tmp282      [V330,T60] (  3,  0.16)     ref  ->  rdx         "arr expr"
+;  V331 tmp283      [V331,T62] (  3,  0.16)     int  ->  rcx         "index expr"
+;  V332 tmp284      [V332,T76] (  2,  0.11)     int  ->  rdx         "argument with side effect"
 ;  V333 tmp285      [V333,T201] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V334 tmp286      [V334,T326] (  3,  0   )     int  ->  rax         "index expr"
 ;  V335 tmp287      [V335,T202] (  3,  0   )     ref  ->  rax         "arr expr"
@@ -5651,12 +5651,12 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V339 tmp291      [V339,T394] (  2,  0   )     int  ->  rdx         "argument with side effect"
 ;  V340 tmp292      [V340,T204] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V341 tmp293      [V341,T329] (  3,  0   )     int  ->  rdx         "index expr"
-;  V342 tmp294      [V342,T59] (  3,  0.16)     ref  ->  rdx         "arr expr"
-;  V343 tmp295      [V343,T62] (  3,  0.16)     int  ->   r8         "index expr"
+;  V342 tmp294      [V342,T63] (  3,  0.16)     ref  ->  rdx         "arr expr"
+;  V343 tmp295      [V343,T66] (  3,  0.16)     int  ->   r8         "index expr"
 ;  V344 tmp296      [V344,T205] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V345 tmp297      [V345,T330] (  3,  0   )     int  ->  rdx         "index expr"
-;  V346 tmp298      [V346,T60] (  3,  0.16)     ref  ->  rdx         "arr expr"
-;  V347 tmp299      [V347,T63] (  3,  0.16)     int  ->   r8         "index expr"
+;  V346 tmp298      [V346,T64] (  3,  0.16)     ref  ->  rdx         "arr expr"
+;  V347 tmp299      [V347,T67] (  3,  0.16)     int  ->   r8         "index expr"
 ;  V348 tmp300      [V348,T69] (  3,  0.16)     ref  ->  rdx         "arr expr"
 ;  V349 tmp301      [V349,T71] (  3,  0.16)     int  ->   r8         "index expr"
 ;  V350 tmp302      [V350,T70] (  3,  0.16)     ref  ->   r8         "arr expr"
@@ -5672,9 +5672,9 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V360 tmp312      [V360,T87] (  2,  0.00)     int  ->  rdx         "argument with side effect"
 ;  V361 tmp313      [V361,T88] (  2,  0.00)     int  ->   r8         "argument with side effect"
 ;  V362 tmp314      [V362,T89] (  2,  0.00)     int  ->   r9         "argument with side effect"
-;  V363 tmp315      [V363,T61] (  3,  0.16)     ref  ->  rdx         "arr expr"
-;  V364 tmp316      [V364,T64] (  3,  0.16)     int  ->  rcx         "index expr"
-;  V365 tmp317      [V365,T75] (  2,  0.11)     int  ->  rdx         "argument with side effect"
+;  V363 tmp315      [V363,T65] (  3,  0.16)     ref  ->  rdx         "arr expr"
+;  V364 tmp316      [V364,T68] (  3,  0.16)     int  ->  rcx         "index expr"
+;  V365 tmp317      [V365,T77] (  2,  0.11)     int  ->  rdx         "argument with side effect"
 ;  V366 tmp318      [V366,T206] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V367 tmp319      [V367,T331] (  3,  0   )     int  ->  rdx         "index expr"
 ;  V368 tmp320      [V368,T207] (  3,  0   )     ref  ->  rcx         "arr expr"
@@ -5718,10 +5718,10 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V406 tmp358      [V406,T346] (  3,  0   )     int  ->  rdx         "index expr"
 ;  V407 tmp359      [V407,T404] (  2,  0   )     int  ->  r14         "argument with side effect"
 ;  V408 tmp360      [V408,T405] (  2,  0   )     int  ->   r8         "argument with side effect"
-;  V409 tmp361      [V409,T18] (  3, 18.00)     ref  ->  rcx         "arr expr"
-;  V410 tmp362      [V410,T20] (  3, 18.00)     int  ->  rax         "index expr"
-;  V411 tmp363      [V411,T19] (  3, 18.00)     ref  ->  rax         "arr expr"
-;  V412 tmp364      [V412,T21] (  3, 18.00)     int  ->  rdx         "index expr"
+;  V409 tmp361      [V409,T18] (  3, 18.00)     ref  ->  rdx         "arr expr"
+;  V410 tmp362      [V410,T20] (  3, 18.00)     int  ->   r8         "index expr"
+;  V411 tmp363      [V411,T19] (  3, 18.00)     ref  ->   r8         "arr expr"
+;  V412 tmp364      [V412,T21] (  3, 18.00)     int  ->   r9         "index expr"
 ;  V413 tmp365      [V413,T222] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V414 tmp366      [V414,T347] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V415 tmp367      [V415,T223] (  3,  0   )     ref  ->  rcx         "arr expr"
@@ -5757,11 +5757,11 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V445 tmp397      [V445,T361] (  3,  0   )     int  ->  rax         "index expr"
 ;  V446 tmp398      [V446,T240] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V447 tmp399      [V447,T362] (  3,  0   )     int  ->  rcx         "index expr"
-;  V448 tmp400      [V448,T06] (  3, 29.91)     ref  ->  rax         "arr expr"
-;  V449 tmp401      [V449,T09] (  3, 29.91)     int  ->  rdx         "index expr"
-;  V450 tmp402      [V450,T07] (  3, 29.91)     ref  ->  rdx         "arr expr"
-;  V451 tmp403      [V451,T10] (  4, 27.97)     int  ->  r14         "fgMakeTemp is creating a new local variable"
-;  V452 cse0        [V452,T37] ( 24,  8.95)     int  ->  rax         multi-def "CSE #09: conservative"
+;  V448 tmp400      [V448,T06] (  3, 29.65)     ref  ->  rax         "arr expr"
+;  V449 tmp401      [V449,T09] (  3, 29.65)     int  ->  rdx         "index expr"
+;  V450 tmp402      [V450,T07] (  3, 29.65)     ref  ->  rdx         "arr expr"
+;  V451 tmp403      [V451,T10] (  4, 27.38)     int  ->  r14         "fgMakeTemp is creating a new local variable"
+;  V452 cse0        [V452,T37] ( 24,  8.76)     int  ->  rax         multi-def "CSE #09: conservative"
 ;  V453 rat0        [V453,T363] (  3,  0   )     int  ->  r15         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 56
@@ -5786,7 +5786,7 @@ G_M19968_IG02:
        mov      rax, gword ptr [rbx+0x70]
        mov      rax, gword ptr [rax+0x10]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M19968_IG171
+       jbe      G_M19968_IG170
        mov      eax, dword ptr [rax+0x10]
        mov      edx, eax
        and      edx, -65
@@ -5796,36 +5796,30 @@ G_M19968_IG02:
        mov      byte  ptr [rbx+0x69], al
        xor      eax, eax
        mov      dword ptr [rbx+0x88], eax
-       jmp      G_M19968_IG08
-						;; size=59 bbWeight=1 PerfScore 21.00
+       jmp      SHORT G_M19968_IG08
+						;; size=56 bbWeight=1 PerfScore 21.00
 G_M19968_IG03:
-       mov      eax, dword ptr [rbx+0x4C]
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
-       mov      dword ptr [rbx+0x54], ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
-       mov      dword ptr [rdx+4*rcx+0x10], eax
-       mov      rax, gword ptr [rbx+0x10]
-       mov      edx, dword ptr [rbx+0x50]
-       dec      edx
-       mov      dword ptr [rbx+0x50], edx
-       mov      ecx, dword ptr [rbx+0x88]
-       cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
-       mov      dword ptr [rax+4*rdx+0x10], ecx
-						;; size=59 bbWeight=1.02 PerfScore 24.90
+       jae      G_M19968_IG170
+       mov      edx, dword ptr [rdx+4*rcx+0x10]
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
+       mov      ebp, 2
+       jmp      SHORT G_M19968_IG07
+						;; size=38 bbWeight=0.03 PerfScore 0.41
 G_M19968_IG04:
        xor      ebp, ebp
        jmp      SHORT G_M19968_IG07
-						;; size=4 bbWeight=1.02 PerfScore 2.29
+						;; size=4 bbWeight=1.03 PerfScore 2.32
 G_M19968_IG05:
        mov      dword ptr [rbx+0x4C], r15d
 						;; size=4 bbWeight=0.03 PerfScore 0.03
 G_M19968_IG06:
        mov      ebp, 1
-						;; size=5 bbWeight=2.99 PerfScore 0.75
+						;; size=5 bbWeight=3.02 PerfScore 0.75
 G_M19968_IG07:
        add      ebp, dword ptr [rbx+0x88]
        inc      ebp
@@ -5834,7 +5828,7 @@ G_M19968_IG07:
        mov      rax, gword ptr [rax+0x10]
        mov      edx, dword ptr [rbx+0x88]
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      eax, dword ptr [rax+4*rdx+0x10]
        mov      edx, eax
        and      edx, -65
@@ -5842,17 +5836,17 @@ G_M19968_IG07:
        test     al, 64
        setne    al
        mov      byte  ptr [rbx+0x69], al
-						;; size=60 bbWeight=5.14 PerfScore 102.82
+						;; size=60 bbWeight=5.12 PerfScore 102.38
 G_M19968_IG08:
        mov      ebp, -1
-						;; size=5 bbWeight=5.14 PerfScore 1.29
+						;; size=5 bbWeight=5.12 PerfScore 1.28
 G_M19968_IG09:
        mov      r14d, dword ptr [rbx+0x84]
        cmp      r14d, 164
-       jg       G_M19968_IG157
+       jg       G_M19968_IG156
        cmp      r14d, 46
        ja       SHORT G_M19968_IG11
-						;; size=26 bbWeight=14.09 PerfScore 63.43
+						;; size=26 bbWeight=14.03 PerfScore 63.14
 G_M19968_IG10:
        mov      eax, r14d
        lea      rdx, [reloc @RWD00]
@@ -5860,12 +5854,12 @@ G_M19968_IG10:
        lea      rcx, G_M19968_IG02
        add      rdx, rcx
        jmp      rdx
-						;; size=25 bbWeight=9.11 PerfScore 54.64
+						;; size=25 bbWeight=9.15 PerfScore 54.90
 G_M19968_IG11:
        add      r14d, -131
        cmp      r14d, 20
        jne      G_M19968_IG15
-						;; size=17 bbWeight=4.99 PerfScore 7.48
+						;; size=17 bbWeight=4.88 PerfScore 7.32
 G_M19968_IG12:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
@@ -5873,7 +5867,7 @@ G_M19968_IG12:
        mov      rdx, gword ptr [rbx+0x10]
        dec      eax
        cmp      eax, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      eax, dword ptr [rdx+4*rax+0x10]
        mov      dword ptr [rbx+0x4C], eax
        mov      rax, gword ptr [rbx+0x70]
@@ -5881,23 +5875,23 @@ G_M19968_IG12:
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r15d, dword ptr [rax+4*rdx+0x10]
        mov      r13d, dword ptr [rbx+0x5C]
        shl      r13d, 2
        cmp      dword ptr [rbx+0x54], r13d
-       jl       G_M19968_IG54
-						;; size=78 bbWeight=2.98 PerfScore 93.18
+       jl       G_M19968_IG52
+						;; size=78 bbWeight=2.92 PerfScore 91.24
 G_M19968_IG13:
        cmp      dword ptr [rbx+0x50], r13d
-       jl       G_M19968_IG55
-						;; size=10 bbWeight=2.98 PerfScore 11.93
+       jl       G_M19968_IG53
+						;; size=10 bbWeight=2.92 PerfScore 11.68
 G_M19968_IG14:
        mov      dword ptr [rbx+0x88], r15d
        mov      rax, gword ptr [rbx+0x70]
        mov      rax, gword ptr [rax+0x10]
        cmp      r15d, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, r15d
        mov      eax, dword ptr [rax+4*rdx+0x10]
        mov      edx, eax
@@ -5906,41 +5900,45 @@ G_M19968_IG14:
        test     al, 64
        setne    al
        mov      byte  ptr [rbx+0x69], al
-       jmp      G_M19968_IG22
-						;; size=56 bbWeight=2.98 PerfScore 50.69
+       jmp      G_M19968_IG23
+						;; size=56 bbWeight=2.92 PerfScore 49.63
 G_M19968_IG15:
        cmp      r14d, 33
-       ja       SHORT G_M19968_IG17
+       ja       SHORT G_M19968_IG18
        mov      ecx, r14d
        lea      rax, [reloc @RWD188]
        mov      eax, dword ptr [rax+4*rcx]
        lea      rdx, G_M19968_IG02
        add      rax, rdx
        jmp      rax
-						;; size=31 bbWeight=2.01 PerfScore 14.54
+						;; size=31 bbWeight=1.96 PerfScore 14.23
 G_M19968_IG16:
        inc      dword ptr [rbx+0x54]
-						;; size=3 bbWeight=1.02 PerfScore 3.05
+       jmp      SHORT G_M19968_IG18
+						;; size=5 bbWeight=0.98 PerfScore 4.90
 G_M19968_IG17:
-       cmp      byte  ptr [rbx+0x68], 0
-       jne      G_M19968_IG166
-						;; size=10 bbWeight=4.98 PerfScore 19.94
+       add      dword ptr [rbx+0x54], 2
+						;; size=4 bbWeight=0.98 PerfScore 2.94
 G_M19968_IG18:
+       cmp      byte  ptr [rbx+0x68], 0
+       jne      G_M19968_IG165
+						;; size=10 bbWeight=4.94 PerfScore 19.77
+G_M19968_IG19:
        mov      rax, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r12d, dword ptr [rax+4*rdx+0x10]
        inc      dword ptr [rbx+0x50]
        mov      eax, 128
        test     r12d, r12d
-       jl       G_M19968_IG168
-						;; size=38 bbWeight=4.98 PerfScore 72.28
-G_M19968_IG19:
+       jl       G_M19968_IG167
+						;; size=38 bbWeight=4.94 PerfScore 71.65
+G_M19968_IG20:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        cmp      r12d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, r12d
        or       eax, dword ptr [rdx+4*rcx+0x10]
        mov      edx, eax
@@ -5952,29 +5950,25 @@ G_M19968_IG19:
        mov      r15d, dword ptr [rbx+0x5C]
        shl      r15d, 2
        cmp      dword ptr [rbx+0x54], r15d
-       jl       G_M19968_IG169
-						;; size=62 bbWeight=4.98 PerfScore 107.17
-G_M19968_IG20:
-       cmp      dword ptr [rbx+0x50], r15d
-       jl       G_M19968_IG170
-						;; size=10 bbWeight=4.98 PerfScore 19.94
+       jl       G_M19968_IG168
+						;; size=62 bbWeight=4.94 PerfScore 106.24
 G_M19968_IG21:
-       mov      dword ptr [rbx+0x88], r12d
-						;; size=7 bbWeight=4.98 PerfScore 4.98
+       cmp      dword ptr [rbx+0x50], r15d
+       jl       G_M19968_IG169
+						;; size=10 bbWeight=4.94 PerfScore 19.77
 G_M19968_IG22:
+       mov      dword ptr [rbx+0x88], r12d
+						;; size=7 bbWeight=4.94 PerfScore 4.94
+G_M19968_IG23:
        test     ebp, ebp
        jl       G_M19968_IG09
        jmp      G_M19968_IG07
-						;; size=13 bbWeight=7.99 PerfScore 25.95
-G_M19968_IG23:
-       add      dword ptr [rbx+0x54], 2
-       jmp      G_M19968_IG17
-						;; size=9 bbWeight=0.99 PerfScore 4.95
+						;; size=13 bbWeight=7.88 PerfScore 25.61
 G_M19968_IG24:
        mov      rax, gword ptr [rbx+0x28]
        mov      rax, gword ptr [rax+0x50]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M19968_IG171
+       jbe      G_M19968_IG170
        cmp      dword ptr [rax+0x10], 0
        setg     al
        movzx    rax, al
@@ -5997,11 +5991,11 @@ G_M19968_IG26:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
-       jmp      SHORT G_M19968_IG22
+       jmp      SHORT G_M19968_IG23
 						;; size=40 bbWeight=0.02 PerfScore 0.34
 G_M19968_IG27:
        add      dword ptr [rbx+0x54], 2
@@ -6009,7 +6003,7 @@ G_M19968_IG27:
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
@@ -6019,16 +6013,16 @@ G_M19968_IG27:
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
        jmp      G_M19968_IG04
-						;; size=75 bbWeight=0.03 PerfScore 0.91
+						;; size=75 bbWeight=0.03 PerfScore 0.90
 G_M19968_IG28:
        cmp      byte  ptr [rbx+0x68], 0
-       jne      G_M19968_IG78
-						;; size=10 bbWeight=1.02 PerfScore 4.07
+       jne      G_M19968_IG76
+						;; size=10 bbWeight=1.02 PerfScore 4.09
 G_M19968_IG29:
        mov      rdx, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rdx+0x08]
@@ -6040,12 +6034,12 @@ G_M19968_IG29:
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [r9+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      eax, ecx
        mov      dword ptr [r9+4*rax+0x10], edx
        dec      ecx
        cmp      ecx, dword ptr [r9+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, ecx
        mov      dword ptr [r9+4*rdx+0x10], r8d
        mov      dword ptr [rbx+0x54], ecx
@@ -6055,20 +6049,20 @@ G_M19968_IG29:
        mov      dword ptr [rbx+0x50], r8d
        mov      r9d, dword ptr [rbx+0x88]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rdx+4*r8+0x10], r9d
        jmp      G_M19968_IG04
-						;; size=112 bbWeight=1.02 PerfScore 45.06
+						;; size=112 bbWeight=1.02 PerfScore 45.21
 G_M19968_IG30:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      r8d, dword ptr [rbx+0x88]
        add      r8d, 2
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      dword ptr [rdx+4*r8+0x10], -1
-       jne      G_M19968_IG80
-						;; size=41 bbWeight=0.03 PerfScore 0.38
+       jne      G_M19968_IG78
+						;; size=41 bbWeight=0.03 PerfScore 0.37
 G_M19968_IG31:
        inc      dword ptr [rbx+0x54]
        mov      rdx, gword ptr [rbx+0x70]
@@ -6076,144 +6070,123 @@ G_M19968_IG31:
        mov      r8d, dword ptr [rbx+0x88]
        add      r8d, 2
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      dword ptr [rdx+4*r8+0x10], -1
-       jne      SHORT G_M19968_IG34
-						;; size=40 bbWeight=0.03 PerfScore 0.46
+       jne      G_M19968_IG79
+						;; size=44 bbWeight=0.03 PerfScore 0.45
 G_M19968_IG32:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      r8d, dword ptr [rbx+0x88]
        inc      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      r9d, dword ptr [rbx+0x54]
        dec      r9d
        cmp      r9d, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*r9+0x10]
        mov      r9d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Capture(int,int,int):this]
-						;; size=72 bbWeight=0.03 PerfScore 0.73
+       jmp      G_M19968_IG03
+						;; size=77 bbWeight=0.03 PerfScore 0.78
 G_M19968_IG33:
-       mov      rdx, gword ptr [rbx+0x18]
-       mov      ecx, dword ptr [rbx+0x54]
-       dec      ecx
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
-       mov      edx, dword ptr [rdx+4*rcx+0x10]
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
-       mov      ebp, 2
-       jmp      G_M19968_IG07
-						;; size=41 bbWeight=0.03 PerfScore 0.42
-G_M19968_IG34:
-       mov      rdx, gword ptr [rbx+0x70]
-       mov      rdx, gword ptr [rdx+0x10]
-       mov      r8d, dword ptr [rbx+0x88]
-       inc      r8d
+       mov      edx, dword ptr [rbx+0x4C]
+       mov      r8, gword ptr [rbx+0x18]
+       mov      r9d, dword ptr [rbx+0x54]
+       dec      r9d
+       mov      dword ptr [rbx+0x54], r9d
+       cmp      r9d, dword ptr [r8+0x08]
+       jae      G_M19968_IG170
+       mov      dword ptr [r8+4*r9+0x10], edx
+       mov      rdx, gword ptr [rbx+0x10]
+       mov      r8d, dword ptr [rbx+0x50]
+       dec      r8d
+       mov      dword ptr [rbx+0x50], r8d
+       mov      r9d, dword ptr [rbx+0x88]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
-       mov      edx, dword ptr [rdx+4*r8+0x10]
+       jae      G_M19968_IG170
+       mov      dword ptr [rdx+4*r8+0x10], r9d
+       jmp      G_M19968_IG04
+						;; size=75 bbWeight=1.03 PerfScore 27.36
+G_M19968_IG34:
+       mov      edx, dword ptr [rbx+0x4C]
+       mov      r8, gword ptr [rbx+0x10]
+       mov      r9d, dword ptr [rbx+0x50]
+       dec      r9d
+       cmp      r9d, dword ptr [r8+0x08]
+       jae      G_M19968_IG170
+       mov      ecx, r9d
+       mov      dword ptr [r8+4*rcx+0x10], edx
+       dec      r9d
+       mov      edx, dword ptr [rbx+0x88]
+       cmp      r9d, dword ptr [r8+0x08]
+       jae      G_M19968_IG170
+       mov      ecx, r9d
+       mov      dword ptr [r8+4*rcx+0x10], edx
+       mov      dword ptr [rbx+0x50], r9d
+       jmp      G_M19968_IG06
+						;; size=68 bbWeight=3.02 PerfScore 66.41
+G_M19968_IG35:
+       mov      rdx, gword ptr [rbx+0x70]
+       mov      rdx, gword ptr [rdx+0x18]
        mov      r8, gword ptr [rbx+0x70]
        mov      r8, gword ptr [r8+0x10]
        mov      r9d, dword ptr [rbx+0x88]
-       add      r9d, 2
+       inc      r9d
        cmp      r9d, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*r9+0x10]
-       mov      r9, gword ptr [rbx+0x18]
-       mov      ecx, dword ptr [rbx+0x54]
-       dec      ecx
-       cmp      ecx, dword ptr [r9+0x08]
-       jae      G_M19968_IG171
-       mov      r9d, dword ptr [r9+4*rcx+0x10]
-       mov      ecx, dword ptr [rbx+0x4C]
-       mov      dword ptr [rsp+0x20], ecx
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexRunner:TransferCapture(int,int,int,int):this]
-       jmp      G_M19968_IG33
-						;; size=112 bbWeight=0.00 PerfScore 0.01
-G_M19968_IG35:
-       mov      ecx, dword ptr [rbx+0x4C]
-       mov      rax, gword ptr [rbx+0x10]
-       mov      edx, dword ptr [rbx+0x50]
-       dec      edx
-       cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
-       mov      r8d, edx
-       mov      dword ptr [rax+4*r8+0x10], ecx
-       dec      edx
-       mov      ecx, dword ptr [rbx+0x88]
-       cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
-       mov      r8d, edx
-       mov      dword ptr [rax+4*r8+0x10], ecx
-       mov      dword ptr [rbx+0x50], edx
-       jmp      G_M19968_IG06
-						;; size=62 bbWeight=2.99 PerfScore 65.87
-G_M19968_IG36:
-       mov      rcx, gword ptr [rbx+0x70]
-       mov      rcx, gword ptr [rcx+0x18]
-       mov      rax, gword ptr [rbx+0x70]
-       mov      rax, gword ptr [rax+0x10]
-       mov      edx, dword ptr [rbx+0x88]
-       inc      edx
-       cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
-       mov      eax, dword ptr [rax+4*rdx+0x10]
-       cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
-       mov      r14, gword ptr [rcx+8*rax+0x10]
-       mov      ecx, edi
+       cmp      r8d, dword ptr [rdx+0x08]
+       jae      G_M19968_IG170
+       mov      r14, gword ptr [rdx+8*r8+0x10]
+       mov      edx, edi
        mov      r12d, dword ptr [r14+0x08]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG104
-						;; size=67 bbWeight=3.00 PerfScore 85.52
-G_M19968_IG37:
-       sub      ecx, dword ptr [rbx+0x4C]
-       cmp      ecx, r12d
-       jl       G_M19968_IG17
-						;; size=12 bbWeight=3.00 PerfScore 12.75
-G_M19968_IG38:
+       jne      G_M19968_IG103
+       sub      edx, dword ptr [rbx+0x4C]
+       cmp      edx, r12d
+       jl       G_M19968_IG18
+						;; size=84 bbWeight=3.00 PerfScore 98.26
+G_M19968_IG36:
        mov      r15d, r12d
        add      r15d, dword ptr [rbx+0x4C]
-						;; size=7 bbWeight=3.00 PerfScore 9.74
-G_M19968_IG39:
+						;; size=7 bbWeight=2.99 PerfScore 9.73
+G_M19968_IG37:
        test     r12d, r12d
-       je       SHORT G_M19968_IG41
-						;; size=5 bbWeight=3.33 PerfScore 4.17
-G_M19968_IG40:
+       je       SHORT G_M19968_IG39
+						;; size=5 bbWeight=3.34 PerfScore 4.17
+G_M19968_IG38:
        dec      r12d
        dec      r15d
        cmp      r12d, dword ptr [r14+0x08]
-       jae      G_M19968_IG171
-       mov      ecx, r12d
-       movzx    rcx, word  ptr [r14+2*rcx+0x0C]
+       jae      G_M19968_IG170
+       mov      edx, r12d
+       movzx    rdx, word  ptr [r14+2*rdx+0x0C]
        cmp      r15d, edi
-       jae      G_M19968_IG171
-       mov      eax, r15d
-       cmp      cx, word  ptr [rsi+2*rax]
-       jne      G_M19968_IG17
-       jmp      SHORT G_M19968_IG39
-						;; size=49 bbWeight=3.31 PerfScore 47.14
-G_M19968_IG41:
+       jae      G_M19968_IG170
+       mov      r8d, r15d
+       cmp      dx, word  ptr [rsi+2*r8]
+       jne      G_M19968_IG18
+       jmp      SHORT G_M19968_IG37
+						;; size=50 bbWeight=3.31 PerfScore 47.16
+G_M19968_IG39:
        cmp      byte  ptr [rbx+0x69], 0
        jne      G_M19968_IG05
-						;; size=10 bbWeight=0.03 PerfScore 0.10
-G_M19968_IG42:
+						;; size=10 bbWeight=0.03 PerfScore 0.11
+G_M19968_IG40:
        add      r15d, dword ptr [r14+0x08]
        jmp      G_M19968_IG05
 						;; size=9 bbWeight=0.03 PerfScore 0.13
-G_M19968_IG43:
+G_M19968_IG41:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
        mov      dword ptr [rbx+0x50], eax
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M19968_IG44:
+G_M19968_IG42:
        mov      rcx, gword ptr [rbx+0x20]
        mov      ecx, dword ptr [rcx+0x08]
        sub      ecx, dword ptr [rbx+0x58]
@@ -6221,46 +6194,46 @@ G_M19968_IG44:
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      ecx, dword ptr [rax+4*rdx+0x10]
-       je       G_M19968_IG17
+       je       G_M19968_IG18
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
-       jmp      SHORT G_M19968_IG44
+       jmp      SHORT G_M19968_IG42
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M19968_IG45:
+G_M19968_IG43:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
        mov      dword ptr [rbx+0x50], eax
        mov      rcx, gword ptr [rbx+0x10]
        dec      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rax+0x10]
        mov      rax, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rax+4*rdx+0x10], ecx
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=57 bbWeight=0 PerfScore 0.00
-G_M19968_IG46:
+G_M19968_IG44:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
        mov      dword ptr [rbx+0x50], eax
        mov      rcx, gword ptr [rbx+0x10]
        dec      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rax+0x10]
        mov      rax, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rax+4*rdx+0x10], ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
@@ -6269,57 +6242,57 @@ G_M19968_IG46:
        mov      eax, dword ptr [rbx+0x88]
        inc      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      dword ptr [rcx+4*rax+0x10], -1
-       je       G_M19968_IG17
+       je       G_M19968_IG18
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      dword ptr [rcx+4*rax+0x10], -1
-       je       G_M19968_IG17
+       je       G_M19968_IG18
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=148 bbWeight=0 PerfScore 0.00
-G_M19968_IG47:
+G_M19968_IG45:
        add      dword ptr [rbx+0x50], 3
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r13d, dword ptr [r8+4*rdx+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        add      edx, -3
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [r8+4*rdx+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      r8d, dword ptr [rcx+4*rax+0x10]
-       jge      SHORT G_M19968_IG49
+       jge      SHORT G_M19968_IG47
        cmp      edx, r13d
-       je       SHORT G_M19968_IG49
+       je       SHORT G_M19968_IG47
        mov      dword ptr [rbx+0x4C], edx
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        inc      r8d
        mov      rcx, rbx
@@ -6332,32 +6305,32 @@ G_M19968_IG47:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
 						;; size=193 bbWeight=0 PerfScore 0.00
-G_M19968_IG48:
+G_M19968_IG46:
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M19968_IG49:
+G_M19968_IG47:
        mov      rdx, gword ptr [rbx+0x10]
        mov      r8d, dword ptr [rbx+0x50]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=65 bbWeight=0 PerfScore 0.00
-G_M19968_IG50:
+G_M19968_IG48:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
        mov      dword ptr [rbx+0x50], eax
@@ -6366,62 +6339,62 @@ G_M19968_IG50:
        mov      r8d, dword ptr [rbx+0x54]
        add      r8d, -2
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      dword ptr [rdx+4*r8+0x10], 0
-       jle      SHORT G_M19968_IG51
+       jle      SHORT G_M19968_IG49
        mov      rdx, gword ptr [rbx+0x18]
        mov      r8d, dword ptr [rbx+0x54]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      dword ptr [rbx+0x4C], edx
        mov      rdx, gword ptr [rbx+0x10]
        lea      r8d, [rax-0x01]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        dec      r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=136 bbWeight=0 PerfScore 0.00
-G_M19968_IG51:
+G_M19968_IG49:
        mov      rdx, gword ptr [rbx+0x10]
        lea      r8d, [rax-0x01]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        dec      r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=65 bbWeight=0 PerfScore 0.00
-G_M19968_IG52:
+G_M19968_IG50:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r12d, dword ptr [rdx+4*rcx+0x10]
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
@@ -6430,7 +6403,7 @@ G_M19968_IG52:
        dec      ecx
        mov      dword ptr [rbx+0x54], ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rdx+4*rcx+0x10], r12d
        mov      dword ptr [rbx+0x4C], r12d
        mov      rdx, gword ptr [rbx+0x70]
@@ -6438,49 +6411,49 @@ G_M19968_IG52:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=132 bbWeight=0 PerfScore 0.00
-G_M19968_IG53:
+G_M19968_IG51:
        add      dword ptr [rbx+0x50], 2
        inc      dword ptr [rbx+0x54]
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], edx
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
-       jmp      G_M19968_IG161
+       jmp      G_M19968_IG160
 						;; size=69 bbWeight=0 PerfScore 0.00
-G_M19968_IG54:
+G_M19968_IG52:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleStack():this]
        jmp      G_M19968_IG13
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG55:
+G_M19968_IG53:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleTrack():this]
        jmp      G_M19968_IG14
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG56:
+G_M19968_IG54:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r14d
        mov      rdx, gword ptr [rbx+0x70]
@@ -6488,7 +6461,7 @@ G_M19968_IG56:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r15d, dword ptr [rdx+4*rcx+0x10]
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -6499,7 +6472,7 @@ G_M19968_IG56:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x18]
        cmp      r15d, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, r15d
        mov      r12, gword ptr [rcx+8*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
@@ -6509,13 +6482,13 @@ G_M19968_IG56:
        call     [CORINFO_HELP_LDELEMA_REF]
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M19968_IG58
+       je       SHORT G_M19968_IG56
        mov      edx, r13d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M19968_IG58
+       jbe      SHORT G_M19968_IG56
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r13d
        and      edx, 15
@@ -6523,111 +6496,111 @@ G_M19968_IG56:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M19968_IG58
+       je       SHORT G_M19968_IG56
        add      edx, edx
        test     ecx, edx
 						;; size=200 bbWeight=0 PerfScore 0.00
-G_M19968_IG57:
+G_M19968_IG55:
        setne    r15b
        movzx    r15, r15b
-       jmp      SHORT G_M19968_IG60
+       jmp      SHORT G_M19968_IG58
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG58:
+G_M19968_IG56:
        cmp      r13d, 128
-       jl       SHORT G_M19968_IG59
+       jl       SHORT G_M19968_IG57
        mov      ecx, r13d
        mov      rdx, r12
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r15d, eax
-       jmp      SHORT G_M19968_IG60
+       jmp      SHORT G_M19968_IG58
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M19968_IG59:
+G_M19968_IG57:
        mov      ecx, r13d
        mov      rdx, r12
        mov      r8, rax
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
        mov      r15d, eax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M19968_IG60:
+G_M19968_IG58:
        test     r15d, r15d
-       je       G_M19968_IG17
+       je       G_M19968_IG18
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [r8+4*rdx+0x10]
        test     edx, edx
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG61
+       jne      SHORT G_M19968_IG59
        mov      r8d, 1
-       jmp      SHORT G_M19968_IG62
+       jmp      SHORT G_M19968_IG60
 						;; size=55 bbWeight=0 PerfScore 0.00
+G_M19968_IG59:
+       mov      r8d, -1
+						;; size=6 bbWeight=0 PerfScore 0.00
+G_M19968_IG60:
+       add      r8d, r14d
+       dec      edx
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
+       jmp      G_M19968_IG155
+						;; size=19 bbWeight=0 PerfScore 0.00
 G_M19968_IG61:
-       mov      r8d, -1
-						;; size=6 bbWeight=0 PerfScore 0.00
+       add      dword ptr [rbx+0x50], 2
+       mov      rdx, gword ptr [rbx+0x10]
+       mov      ecx, dword ptr [rbx+0x50]
+       add      ecx, -2
+       cmp      ecx, dword ptr [rdx+0x08]
+       jae      G_M19968_IG170
+       mov      r14d, dword ptr [rdx+4*rcx+0x10]
+       mov      dword ptr [rbx+0x4C], r14d
+       mov      bword ptr [rsp+0x28], rsi
+       mov      dword ptr [rsp+0x30], edi
+       lea      rdx, [rsp+0x28]
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
+       mov      r8, gword ptr [rbx+0x70]
+       mov      r8, gword ptr [r8+0x10]
+       mov      edx, dword ptr [rbx+0x88]
+       inc      edx
+       cmp      edx, dword ptr [r8+0x08]
+       jae      G_M19968_IG170
+       movzx    r8, word  ptr [r8+4*rdx+0x10]
+       cmp      eax, r8d
+       je       G_M19968_IG18
+       mov      r8, gword ptr [rbx+0x10]
+       mov      edx, dword ptr [rbx+0x50]
+       dec      edx
+       cmp      edx, dword ptr [r8+0x08]
+       jae      G_M19968_IG170
+       mov      edx, dword ptr [r8+4*rdx+0x10]
+       test     edx, edx
+       jle      G_M19968_IG155
+       cmp      byte  ptr [rbx+0x69], 0
+       jne      SHORT G_M19968_IG62
+       mov      r8d, 1
+       jmp      SHORT G_M19968_IG63
+						;; size=142 bbWeight=0 PerfScore 0.00
 G_M19968_IG62:
-       add      r8d, r14d
-       dec      edx
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
-						;; size=19 bbWeight=0 PerfScore 0.00
+       mov      r8d, -1
+						;; size=6 bbWeight=0 PerfScore 0.00
 G_M19968_IG63:
-       add      dword ptr [rbx+0x50], 2
-       mov      rdx, gword ptr [rbx+0x10]
-       mov      ecx, dword ptr [rbx+0x50]
-       add      ecx, -2
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
-       mov      r14d, dword ptr [rdx+4*rcx+0x10]
-       mov      dword ptr [rbx+0x4C], r14d
-       mov      bword ptr [rsp+0x28], rsi
-       mov      dword ptr [rsp+0x30], edi
-       lea      rdx, [rsp+0x28]
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
-       mov      r8, gword ptr [rbx+0x70]
-       mov      r8, gword ptr [r8+0x10]
-       mov      edx, dword ptr [rbx+0x88]
-       inc      edx
-       cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
-       movzx    r8, word  ptr [r8+4*rdx+0x10]
-       cmp      eax, r8d
-       je       G_M19968_IG17
-       mov      r8, gword ptr [rbx+0x10]
-       mov      edx, dword ptr [rbx+0x50]
+       add      r8d, r14d
        dec      edx
-       cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
-       mov      edx, dword ptr [r8+4*rdx+0x10]
-       test     edx, edx
-       jle      G_M19968_IG156
-       cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG64
-       mov      r8d, 1
-       jmp      SHORT G_M19968_IG65
-						;; size=142 bbWeight=0 PerfScore 0.00
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
+       jmp      G_M19968_IG155
+						;; size=19 bbWeight=0 PerfScore 0.00
 G_M19968_IG64:
-       mov      r8d, -1
-						;; size=6 bbWeight=0 PerfScore 0.00
-G_M19968_IG65:
-       add      r8d, r14d
-       dec      edx
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
-						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG66:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r14d
        mov      bword ptr [rsp+0x28], rsi
@@ -6640,129 +6613,129 @@ G_M19968_IG66:
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        movzx    r8, word  ptr [r8+4*rdx+0x10]
        cmp      eax, r8d
-       jne      G_M19968_IG17
+       jne      G_M19968_IG18
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [r8+4*rdx+0x10]
        test     edx, edx
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG67
+       jne      SHORT G_M19968_IG65
        mov      r8d, 1
-       jmp      SHORT G_M19968_IG68
+       jmp      SHORT G_M19968_IG66
 						;; size=142 bbWeight=0 PerfScore 0.00
-G_M19968_IG67:
+G_M19968_IG65:
        mov      r8d, -1
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M19968_IG68:
+G_M19968_IG66:
        add      r8d, r14d
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG69:
+G_M19968_IG67:
        add      dword ptr [rbx+0x50], 2
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [r8+4*rdx+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r8d
        test     edx, edx
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG70
+       jne      SHORT G_M19968_IG68
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG71
+       jmp      SHORT G_M19968_IG69
 						;; size=78 bbWeight=0 PerfScore 0.00
-G_M19968_IG70:
+G_M19968_IG68:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG71:
+G_M19968_IG69:
        sub      r8d, ecx
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG72:
+G_M19968_IG70:
        mov      rcx, gword ptr [rbx+0x10]
        mov      rdx, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rdx+0x08]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        lea      rcx, bword ptr [rcx+4*rdx+0x10]
        mov      edx, dword ptr [rcx]
        cmp      edx, dword ptr [rbx+0x4C]
-       jge      G_M19968_IG103
+       jge      G_M19968_IG102
        mov      edx, dword ptr [rbx+0x4C]
        mov      dword ptr [rcx], edx
-       jmp      G_M19968_IG103
+       jmp      G_M19968_IG102
 						;; size=48 bbWeight=0 PerfScore 0.00
+G_M19968_IG71:
+       mov      bword ptr [rsp+0x28], rsi
+       mov      dword ptr [rsp+0x30], edi
+       lea      rcx, [rsp+0x28]
+       mov      edx, dword ptr [rbx+0x4C]
+       call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
+       test     eax, eax
+       jne      G_M19968_IG18
+       jmp      G_M19968_IG102
+						;; size=36 bbWeight=0 PerfScore 0.00
+G_M19968_IG72:
+       mov      bword ptr [rsp+0x28], rsi
+       mov      dword ptr [rsp+0x30], edi
+       lea      rcx, [rsp+0x28]
+       mov      edx, dword ptr [rbx+0x4C]
+       call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
+       test     eax, eax
+       je       G_M19968_IG18
+       jmp      G_M19968_IG102
+						;; size=36 bbWeight=0 PerfScore 0.00
 G_M19968_IG73:
-       mov      bword ptr [rsp+0x28], rsi
-       mov      dword ptr [rsp+0x30], edi
-       lea      rcx, [rsp+0x28]
-       mov      edx, dword ptr [rbx+0x4C]
-       call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
-       test     eax, eax
-       jne      G_M19968_IG17
-       jmp      G_M19968_IG103
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG74:
-       mov      bword ptr [rsp+0x28], rsi
-       mov      dword ptr [rsp+0x30], edi
-       lea      rcx, [rsp+0x28]
-       mov      edx, dword ptr [rbx+0x4C]
-       call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
-       test     eax, eax
-       je       G_M19968_IG17
-       jmp      G_M19968_IG103
-						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG75:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x28]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Match:IsMatched(int):ubyte:this]
        test     eax, eax
-       je       G_M19968_IG17
-       jmp      G_M19968_IG161
+       je       G_M19968_IG18
+       jmp      G_M19968_IG160
 						;; size=54 bbWeight=0 PerfScore 0.00
-G_M19968_IG76:
+G_M19968_IG74:
        add      dword ptr [rbx+0x54], 2
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        dec      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rax+0x10]
        mov      rax, gword ptr [rbx+0x10]
        mov      eax, dword ptr [rax+0x08]
        sub      eax, ecx
        mov      dword ptr [rbx+0x50], eax
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M19968_IG77:
+G_M19968_IG75:
        mov      rcx, gword ptr [rbx+0x20]
        mov      ecx, dword ptr [rcx+0x08]
        sub      ecx, dword ptr [rbx+0x58]
@@ -6770,26 +6743,26 @@ G_M19968_IG77:
        mov      edx, dword ptr [rbx+0x54]
        add      edx, -2
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      ecx, dword ptr [rax+4*rdx+0x10]
-       je       G_M19968_IG17
+       je       G_M19968_IG18
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
-       jmp      SHORT G_M19968_IG77
+       jmp      SHORT G_M19968_IG75
 						;; size=50 bbWeight=0 PerfScore 0.00
-G_M19968_IG78:
+G_M19968_IG76:
        call     <unknown method>
        cmp      rax, qword ptr [rbx+0x38]
        jl       G_M19968_IG29
-       jmp      G_M19968_IG167
+       jmp      G_M19968_IG166
 						;; size=20 bbWeight=0 PerfScore 0.00
-G_M19968_IG79:
+G_M19968_IG77:
        inc      dword ptr [rbx+0x54]
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
@@ -6797,54 +6770,81 @@ G_M19968_IG79:
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      dword ptr [rbx+0x4C], ecx
-       jmp      G_M19968_IG103
+       jmp      G_M19968_IG102
 						;; size=64 bbWeight=0 PerfScore 0.00
-G_M19968_IG80:
+G_M19968_IG78:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      edx, dword ptr [rbx+0x88]
        add      edx, 2
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x28]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Match:IsMatched(int):ubyte:this]
        test     eax, eax
-       je       G_M19968_IG17
+       je       G_M19968_IG18
        jmp      G_M19968_IG31
 						;; size=55 bbWeight=0 PerfScore 0.00
-G_M19968_IG81:
+G_M19968_IG79:
+       mov      rdx, gword ptr [rbx+0x70]
+       mov      rdx, gword ptr [rdx+0x10]
+       mov      r8d, dword ptr [rbx+0x88]
+       inc      r8d
+       cmp      r8d, dword ptr [rdx+0x08]
+       jae      G_M19968_IG170
+       mov      edx, dword ptr [rdx+4*r8+0x10]
+       mov      r8, gword ptr [rbx+0x70]
+       mov      r8, gword ptr [r8+0x10]
+       mov      r9d, dword ptr [rbx+0x88]
+       add      r9d, 2
+       cmp      r9d, dword ptr [r8+0x08]
+       jae      G_M19968_IG170
+       mov      r8d, dword ptr [r8+4*r9+0x10]
+       mov      r9, gword ptr [rbx+0x18]
+       mov      ecx, dword ptr [rbx+0x54]
+       dec      ecx
+       cmp      ecx, dword ptr [r9+0x08]
+       jae      G_M19968_IG170
+       mov      r9d, dword ptr [r9+4*rcx+0x10]
+       mov      ecx, dword ptr [rbx+0x4C]
+       mov      dword ptr [rsp+0x20], ecx
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexRunner:TransferCapture(int,int,int,int):this]
+       jmp      G_M19968_IG03
+						;; size=112 bbWeight=0.00 PerfScore 0.00
+G_M19968_IG80:
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        dec      eax
        mov      dword ptr [rbx+0x54], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rcx+4*rax+0x10], -1
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush():this]
-       jmp      G_M19968_IG103
+       jmp      G_M19968_IG102
 						;; size=43 bbWeight=0 PerfScore 0.00
-G_M19968_IG82:
+G_M19968_IG81:
        add      dword ptr [rbx+0x54], 2
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        add      eax, -2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rcx+4*rax+0x10]
        test     r14d, r14d
-       jge      SHORT G_M19968_IG83
+       jge      SHORT G_M19968_IG82
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
        mov      edx, dword ptr [rbx+0x4C]
@@ -6856,32 +6856,32 @@ G_M19968_IG82:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=123 bbWeight=0 PerfScore 0.00
-G_M19968_IG83:
+G_M19968_IG82:
        mov      r9d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        mov      r8d, r14d
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M19968_IG84:
+G_M19968_IG83:
        add      dword ptr [rbx+0x54], 2
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        add      eax, -2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rcx+4*rax+0x10]
        mov      ecx, dword ptr [rbx+0x4C]
        sub      ecx, edx
@@ -6890,15 +6890,15 @@ G_M19968_IG84:
        mov      r8d, dword ptr [rbx+0x88]
        add      r8d, 2
        cmp      r8d, dword ptr [rax+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      dword ptr [rax+4*r8+0x10], r14d
-       jle      SHORT G_M19968_IG86
+       jle      SHORT G_M19968_IG85
        test     ecx, ecx
-       jne      SHORT G_M19968_IG85
+       jne      SHORT G_M19968_IG84
        test     r14d, r14d
-       jge      SHORT G_M19968_IG86
+       jge      SHORT G_M19968_IG85
 						;; size=100 bbWeight=0 PerfScore 0.00
-G_M19968_IG85:
+G_M19968_IG84:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
        mov      edx, dword ptr [rbx+0x4C]
@@ -6910,105 +6910,105 @@ G_M19968_IG85:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=68 bbWeight=0 PerfScore 0.00
-G_M19968_IG86:
+G_M19968_IG85:
        mov      rcx, rbx
        mov      r8d, r14d
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG87:
+G_M19968_IG86:
        mov      edx, dword ptr [rbx+0x4C]
        mov      r8, gword ptr [rbx+0x70]
        mov      r8, gword ptr [r8+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      SHORT G_M19968_IG89
+       jmp      SHORT G_M19968_IG88
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M19968_IG88:
+G_M19968_IG87:
        mov      r8, gword ptr [rbx+0x70]
        mov      r8, gword ptr [r8+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        mov      edx, -1
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M19968_IG89:
+G_M19968_IG88:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush():this]
-       jmp      G_M19968_IG161
+       jmp      G_M19968_IG160
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG90:
+G_M19968_IG89:
        inc      dword ptr [rbx+0x54]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [r8+4*rcx+0x10]
        cmp      dword ptr [rbx+0x4C], edx
-       je       SHORT G_M19968_IG92
-       cmp      edx, -1
        je       SHORT G_M19968_IG91
+       cmp      edx, -1
+       je       SHORT G_M19968_IG90
        mov      r8d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG161
+       jmp      G_M19968_IG160
 						;; size=55 bbWeight=0 PerfScore 0.00
-G_M19968_IG91:
+G_M19968_IG90:
        mov      r8d, dword ptr [rbx+0x4C]
        mov      edx, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG161
+       jmp      G_M19968_IG160
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M19968_IG92:
+G_M19968_IG91:
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        dec      eax
        mov      dword ptr [rbx+0x54], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rcx+4*rax+0x10], edx
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
-       jmp      G_M19968_IG161
+       jmp      G_M19968_IG160
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M19968_IG93:
+G_M19968_IG92:
        inc      dword ptr [rbx+0x54]
        mov      edx, dword ptr [rbx+0x4C]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      edx, dword ptr [r8+4*rcx+0x10]
-       je       SHORT G_M19968_IG94
+       je       SHORT G_M19968_IG93
        mov      rdx, gword ptr [rbx+0x18]
        mov      r8d, dword ptr [rbx+0x54]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
@@ -7019,59 +7019,69 @@ G_M19968_IG93:
        dec      eax
        mov      dword ptr [rbx+0x54], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rcx+4*rax+0x10], edx
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=142 bbWeight=0 PerfScore 0.00
-G_M19968_IG94:
+G_M19968_IG93:
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
-       jmp      G_M19968_IG161
+       jmp      G_M19968_IG160
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG95:
+G_M19968_IG94:
        cmp      dword ptr [rbx+0x4C], edi
-       jl       G_M19968_IG17
-       jmp      G_M19968_IG103
+       jl       G_M19968_IG18
+       jmp      G_M19968_IG102
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG96:
+G_M19968_IG95:
        mov      ecx, dword ptr [rbx+0x4C]
        lea      edx, [rdi-0x01]
        cmp      ecx, edx
-       jl       G_M19968_IG17
+       jl       G_M19968_IG18
        cmp      ecx, edi
-       jae      G_M19968_IG103
+       jae      G_M19968_IG102
        cmp      ecx, edi
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      word  ptr [rsi+2*rcx], 10
-       jne      G_M19968_IG17
-       jmp      G_M19968_IG103
+       jne      G_M19968_IG18
+       jmp      G_M19968_IG102
 						;; size=46 bbWeight=0 PerfScore 0.00
-G_M19968_IG97:
+G_M19968_IG96:
        mov      ecx, dword ptr [rbx+0x4C]
        cmp      ecx, dword ptr [rbx+0x48]
-       jne      G_M19968_IG17
-       jmp      G_M19968_IG103
+       jne      G_M19968_IG18
+       jmp      G_M19968_IG102
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG98:
+G_M19968_IG97:
        cmp      dword ptr [rbx+0x4C], 0
-       jg       G_M19968_IG17
-       jmp      SHORT G_M19968_IG103
+       jg       G_M19968_IG18
+       jmp      SHORT G_M19968_IG102
 						;; size=12 bbWeight=0 PerfScore 0.00
+G_M19968_IG98:
+       mov      bword ptr [rsp+0x28], rsi
+       mov      dword ptr [rsp+0x30], edi
+       lea      rcx, [rsp+0x28]
+       mov      edx, dword ptr [rbx+0x4C]
+       call     [System.Text.RegularExpressions.RegexRunner:IsBoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
+       test     eax, eax
+       jne      G_M19968_IG18
+       jmp      SHORT G_M19968_IG102
+						;; size=33 bbWeight=0 PerfScore 0.00
 G_M19968_IG99:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -7079,62 +7089,52 @@ G_M19968_IG99:
        mov      edx, dword ptr [rbx+0x4C]
        call     [System.Text.RegularExpressions.RegexRunner:IsBoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
        test     eax, eax
-       jne      G_M19968_IG17
-       jmp      SHORT G_M19968_IG103
+       je       G_M19968_IG18
+       jmp      SHORT G_M19968_IG102
 						;; size=33 bbWeight=0 PerfScore 0.00
 G_M19968_IG100:
-       mov      bword ptr [rsp+0x28], rsi
-       mov      dword ptr [rsp+0x30], edi
-       lea      rcx, [rsp+0x28]
-       mov      edx, dword ptr [rbx+0x4C]
-       call     [System.Text.RegularExpressions.RegexRunner:IsBoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
-       test     eax, eax
-       je       G_M19968_IG17
-       jmp      SHORT G_M19968_IG103
-						;; size=33 bbWeight=0 PerfScore 0.00
-G_M19968_IG101:
        mov      ecx, dword ptr [rbx+0x4C]
        cmp      ecx, edi
-       jae      SHORT G_M19968_IG103
+       jae      SHORT G_M19968_IG102
        cmp      ecx, edi
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      word  ptr [rsi+2*rcx], 10
-       jne      G_M19968_IG17
-       jmp      SHORT G_M19968_IG103
+       jne      G_M19968_IG18
+       jmp      SHORT G_M19968_IG102
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG102:
+G_M19968_IG101:
        mov      ecx, dword ptr [rbx+0x4C]
        dec      ecx
        cmp      ecx, edi
-       jae      SHORT G_M19968_IG103
+       jae      SHORT G_M19968_IG102
        cmp      ecx, edi
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        cmp      word  ptr [rsi+2*rcx], 10
-       jne      G_M19968_IG17
+       jne      G_M19968_IG18
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG103:
+G_M19968_IG102:
        xor      ebp, ebp
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M19968_IG104:
+G_M19968_IG103:
        cmp      dword ptr [rbx+0x4C], r12d
-       jl       G_M19968_IG17
+       jl       G_M19968_IG18
        mov      r15d, dword ptr [rbx+0x4C]
        test     r12d, r12d
        je       G_M19968_IG05
-       jmp      G_M19968_IG40
+       jmp      G_M19968_IG38
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG105:
+G_M19968_IG104:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        test     eax, eax
-       jle      G_M19968_IG17
+       jle      G_M19968_IG18
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rdx+4*rcx+0x10]
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -7145,7 +7145,7 @@ G_M19968_IG105:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x18]
        cmp      r14d, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, r14d
        mov      r13, gword ptr [rcx+8*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
@@ -7155,13 +7155,13 @@ G_M19968_IG105:
        call     [CORINFO_HELP_LDELEMA_REF]
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M19968_IG107
+       je       SHORT G_M19968_IG106
        mov      edx, r15d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M19968_IG107
+       jbe      SHORT G_M19968_IG106
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r15d
        and      edx, 15
@@ -7169,42 +7169,63 @@ G_M19968_IG105:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M19968_IG107
+       je       SHORT G_M19968_IG106
        add      edx, edx
        test     ecx, edx
        setne    r14b
        movzx    r14, r14b
 						;; size=193 bbWeight=0 PerfScore 0.00
-G_M19968_IG106:
-       jmp      SHORT G_M19968_IG109
+G_M19968_IG105:
+       jmp      SHORT G_M19968_IG108
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M19968_IG107:
+G_M19968_IG106:
        cmp      r15d, 128
-       jl       SHORT G_M19968_IG108
+       jl       SHORT G_M19968_IG107
        mov      ecx, r15d
        mov      rdx, r13
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r14d, eax
-       jmp      SHORT G_M19968_IG109
+       jmp      SHORT G_M19968_IG108
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M19968_IG108:
+G_M19968_IG107:
        mov      ecx, r15d
        mov      rdx, r13
        mov      r8, rax
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
        mov      r14d, eax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M19968_IG109:
+G_M19968_IG108:
        test     r14d, r14d
-       je       G_M19968_IG17
-       jmp      G_M19968_IG161
+       je       G_M19968_IG18
+       jmp      G_M19968_IG160
 						;; size=14 bbWeight=0 PerfScore 0.00
+G_M19968_IG109:
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
+       test     eax, eax
+       jle      G_M19968_IG18
+       mov      bword ptr [rsp+0x28], rsi
+       mov      dword ptr [rsp+0x30], edi
+       lea      rdx, [rsp+0x28]
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
+       mov      rcx, gword ptr [rbx+0x70]
+       mov      rcx, gword ptr [rcx+0x10]
+       mov      edx, dword ptr [rbx+0x88]
+       inc      edx
+       cmp      edx, dword ptr [rcx+0x08]
+       jae      G_M19968_IG170
+       movzx    rcx, word  ptr [rcx+4*rdx+0x10]
+       cmp      eax, ecx
+       je       G_M19968_IG18
+       jmp      G_M19968_IG160
+						;; size=83 bbWeight=0 PerfScore 0.00
 G_M19968_IG110:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        test     eax, eax
-       jle      G_M19968_IG17
+       jle      G_M19968_IG18
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7215,89 +7236,68 @@ G_M19968_IG110:
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        movzx    rcx, word  ptr [rcx+4*rdx+0x10]
        cmp      eax, ecx
-       je       G_M19968_IG17
-       jmp      G_M19968_IG161
+       jne      G_M19968_IG18
+       jmp      G_M19968_IG160
 						;; size=83 bbWeight=0 PerfScore 0.00
 G_M19968_IG111:
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
-       test     eax, eax
-       jle      G_M19968_IG17
-       mov      bword ptr [rsp+0x28], rsi
-       mov      dword ptr [rsp+0x30], edi
-       lea      rdx, [rsp+0x28]
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
-       mov      rcx, gword ptr [rbx+0x70]
-       mov      rcx, gword ptr [rcx+0x10]
-       mov      edx, dword ptr [rbx+0x88]
-       inc      edx
-       cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
-       movzx    rcx, word  ptr [rcx+4*rdx+0x10]
-       cmp      eax, ecx
-       jne      G_M19968_IG17
-       jmp      G_M19968_IG161
-						;; size=83 bbWeight=0 PerfScore 0.00
-G_M19968_IG112:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ebp, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      ebp, eax
-       jg       SHORT G_M19968_IG113
+       jg       SHORT G_M19968_IG112
        mov      edx, ebp
-       jmp      SHORT G_M19968_IG114
+       jmp      SHORT G_M19968_IG113
 						;; size=47 bbWeight=0 PerfScore 0.00
-G_M19968_IG113:
+G_M19968_IG112:
        mov      edx, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M19968_IG114:
+G_M19968_IG113:
        test     edx, edx
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        mov      r8d, dword ptr [rbx+0x4C]
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG115:
+G_M19968_IG114:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ebp, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      ebp, eax
-       jg       SHORT G_M19968_IG116
-       jmp      SHORT G_M19968_IG117
+       jg       SHORT G_M19968_IG115
+       jmp      SHORT G_M19968_IG116
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M19968_IG116:
+G_M19968_IG115:
        mov      ebp, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M19968_IG117:
+G_M19968_IG116:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x18]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, edx
        mov      r14, gword ptr [rcx+8*r8+0x10]
        mov      rcx, gword ptr [rbx+0x70]
@@ -7308,9 +7308,9 @@ G_M19968_IG117:
        mov      r15, rax
        mov      r13d, ebp
        test     ebp, ebp
-       jle      G_M19968_IG123
+       jle      G_M19968_IG122
 						;; size=95 bbWeight=0 PerfScore 0.00
-G_M19968_IG118:
+G_M19968_IG117:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7318,13 +7318,13 @@ G_M19968_IG118:
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        mov      rcx, gword ptr [r15]
        test     rcx, rcx
-       je       SHORT G_M19968_IG119
+       je       SHORT G_M19968_IG118
        mov      edx, eax
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M19968_IG119
+       jbe      SHORT G_M19968_IG118
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, eax
        and      edx, 15
@@ -7332,267 +7332,267 @@ G_M19968_IG118:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M19968_IG119
+       je       SHORT G_M19968_IG118
        add      edx, edx
        test     ecx, edx
        setne    r12b
        movzx    r12, r12b
-       jmp      SHORT G_M19968_IG121
+       jmp      SHORT G_M19968_IG120
 						;; size=90 bbWeight=0 PerfScore 0.00
-G_M19968_IG119:
+G_M19968_IG118:
        cmp      eax, 128
-       jl       SHORT G_M19968_IG120
+       jl       SHORT G_M19968_IG119
        mov      ecx, eax
        mov      rdx, r14
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r12d, eax
-       jmp      SHORT G_M19968_IG121
+       jmp      SHORT G_M19968_IG120
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M19968_IG120:
+G_M19968_IG119:
        mov      ecx, eax
        mov      rdx, r14
        mov      r8, r15
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
        mov      r12d, eax
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG121:
+G_M19968_IG120:
        test     r12d, r12d
-       je       SHORT G_M19968_IG122
+       je       SHORT G_M19968_IG121
        dec      r13d
        test     r13d, r13d
-       jg       G_M19968_IG118
-       jmp      SHORT G_M19968_IG123
+       jg       G_M19968_IG117
+       jmp      SHORT G_M19968_IG122
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG122:
+G_M19968_IG121:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Backwardnext():this]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG123:
+G_M19968_IG122:
        cmp      ebp, r13d
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        cmp      dword ptr [rbx+0x84], 5
-       jne      G_M19968_IG156
+       jne      G_M19968_IG155
        mov      r8d, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG124
+       jne      SHORT G_M19968_IG123
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG125
+       jmp      SHORT G_M19968_IG124
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M19968_IG124:
+G_M19968_IG123:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG125:
+G_M19968_IG124:
        mov      edx, ebp
        sub      edx, r13d
        dec      edx
        sub      r8d, ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M19968_IG126:
+G_M19968_IG125:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ebp, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      ebp, eax
-       jg       SHORT G_M19968_IG127
-       jmp      SHORT G_M19968_IG128
+       jg       SHORT G_M19968_IG126
+       jmp      SHORT G_M19968_IG127
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M19968_IG127:
+G_M19968_IG126:
        mov      ebp, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M19968_IG128:
+G_M19968_IG127:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        movzx    r14, word  ptr [rdx+4*rcx+0x10]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG133
+       jne      SHORT G_M19968_IG132
        mov      edx, dword ptr [rbx+0x4C]
        mov      ecx, edx
        mov      r8d, ebp
        add      rcx, r8
        mov      r8d, edi
        cmp      rcx, r8
-       ja       SHORT G_M19968_IG132
+       ja       SHORT G_M19968_IG131
        lea      rcx, bword ptr [rsi+2*rdx]
        movsx    rdx, r14w
        movzx    r8, dx
        dec      r8d
        cmp      r8d, 254
-       jae      SHORT G_M19968_IG129
+       jae      SHORT G_M19968_IG128
        mov      r8d, ebp
        call     [<unknown method>]
-       jmp      SHORT G_M19968_IG130
+       jmp      SHORT G_M19968_IG129
 						;; size=91 bbWeight=0 PerfScore 0.00
-G_M19968_IG129:
+G_M19968_IG128:
        mov      r8d, ebp
        call     [<unknown method>]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG130:
+G_M19968_IG129:
        cmp      eax, -1
-       jne      SHORT G_M19968_IG131
+       jne      SHORT G_M19968_IG130
        add      dword ptr [rbx+0x4C], ebp
        xor      r15d, r15d
-       jmp      SHORT G_M19968_IG136
+       jmp      SHORT G_M19968_IG135
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG131:
+G_M19968_IG130:
        add      dword ptr [rbx+0x4C], eax
        mov      r15d, ebp
        sub      r15d, eax
-       jmp      SHORT G_M19968_IG136
+       jmp      SHORT G_M19968_IG135
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M19968_IG132:
+G_M19968_IG131:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M19968_IG133:
+G_M19968_IG132:
        mov      r15d, ebp
        test     ebp, ebp
-       jle      SHORT G_M19968_IG136
+       jle      SHORT G_M19968_IG135
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M19968_IG134:
+G_M19968_IG133:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        cmp      eax, r14d
-       je       SHORT G_M19968_IG135
+       je       SHORT G_M19968_IG134
        dec      r15d
        test     r15d, r15d
-       jg       SHORT G_M19968_IG134
-       jmp      SHORT G_M19968_IG136
+       jg       SHORT G_M19968_IG133
+       jmp      SHORT G_M19968_IG135
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M19968_IG135:
+G_M19968_IG134:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Backwardnext():this]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG136:
+G_M19968_IG135:
        cmp      ebp, r15d
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        cmp      dword ptr [rbx+0x84], 4
-       jne      G_M19968_IG156
+       jne      G_M19968_IG155
        mov      r8d, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG137
+       jne      SHORT G_M19968_IG136
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG138
+       jmp      SHORT G_M19968_IG137
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M19968_IG137:
+G_M19968_IG136:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG138:
+G_M19968_IG137:
        mov      edx, ebp
        sub      edx, r15d
        dec      edx
        sub      r8d, ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M19968_IG139:
+G_M19968_IG138:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ebp, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      ebp, eax
-       jg       SHORT G_M19968_IG140
-       jmp      SHORT G_M19968_IG141
+       jg       SHORT G_M19968_IG139
+       jmp      SHORT G_M19968_IG140
 						;; size=45 bbWeight=0 PerfScore 0.00
-G_M19968_IG140:
+G_M19968_IG139:
        mov      ebp, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M19968_IG141:
+G_M19968_IG140:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        movzx    r14, word  ptr [rdx+4*rcx+0x10]
        mov      r15d, ebp
        test     ebp, ebp
-       jle      SHORT G_M19968_IG144
+       jle      SHORT G_M19968_IG143
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M19968_IG142:
+G_M19968_IG141:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        cmp      eax, r14d
-       jne      SHORT G_M19968_IG143
+       jne      SHORT G_M19968_IG142
        dec      r15d
        test     r15d, r15d
-       jg       SHORT G_M19968_IG142
-       jmp      SHORT G_M19968_IG144
+       jg       SHORT G_M19968_IG141
+       jmp      SHORT G_M19968_IG143
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M19968_IG143:
+G_M19968_IG142:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Backwardnext():this]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG144:
+G_M19968_IG143:
        cmp      ebp, r15d
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        cmp      dword ptr [rbx+0x84], 3
-       jne      G_M19968_IG156
+       jne      G_M19968_IG155
        mov      r8d, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG145
+       jne      SHORT G_M19968_IG144
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG146
+       jmp      SHORT G_M19968_IG145
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M19968_IG145:
+G_M19968_IG144:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG146:
+G_M19968_IG145:
        mov      edx, ebp
        sub      edx, r15d
        dec      edx
        sub      r8d, ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG156
+       jmp      G_M19968_IG155
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M19968_IG147:
+G_M19968_IG146:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      eax, r14d
-       jl       G_M19968_IG17
+       jl       G_M19968_IG18
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x18]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, edx
        mov      r15, gword ptr [rcx+8*r8+0x10]
        mov      rcx, gword ptr [rbx+0x70]
@@ -7602,11 +7602,11 @@ G_M19968_IG147:
        call     [CORINFO_HELP_LDELEMA_REF]
        mov      r13, rax
 						;; size=133 bbWeight=0 PerfScore 0.00
-G_M19968_IG148:
+G_M19968_IG147:
        lea      edx, [r14-0x01]
        mov      r12d, edx
        test     r14d, r14d
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7614,13 +7614,13 @@ G_M19968_IG148:
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        mov      rcx, gword ptr [r13]
        test     rcx, rcx
-       je       SHORT G_M19968_IG149
+       je       SHORT G_M19968_IG148
        mov      edx, eax
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M19968_IG149
+       jbe      SHORT G_M19968_IG148
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, eax
        and      edx, 15
@@ -7628,61 +7628,61 @@ G_M19968_IG148:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M19968_IG149
+       je       SHORT G_M19968_IG148
        add      edx, edx
        test     ecx, edx
        setne    r14b
        movzx    r14, r14b
-       jmp      SHORT G_M19968_IG151
+       jmp      SHORT G_M19968_IG150
 						;; size=107 bbWeight=0 PerfScore 0.00
-G_M19968_IG149:
+G_M19968_IG148:
        cmp      eax, 128
-       jl       SHORT G_M19968_IG150
+       jl       SHORT G_M19968_IG149
        mov      ecx, eax
        mov      rdx, r15
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r14d, eax
-       jmp      SHORT G_M19968_IG151
+       jmp      SHORT G_M19968_IG150
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M19968_IG150:
+G_M19968_IG149:
        mov      ecx, eax
        mov      rdx, r15
        mov      r8, r13
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
        mov      r14d, eax
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG151:
+G_M19968_IG150:
        test     r14d, r14d
        mov      r14d, r12d
-       je       G_M19968_IG17
-       jmp      G_M19968_IG148
+       je       G_M19968_IG18
+       jmp      G_M19968_IG147
 						;; size=17 bbWeight=0 PerfScore 0.00
+G_M19968_IG151:
+       mov      rcx, gword ptr [rbx+0x70]
+       mov      rcx, gword ptr [rcx+0x10]
+       mov      eax, dword ptr [rbx+0x88]
+       add      eax, 2
+       cmp      eax, dword ptr [rcx+0x08]
+       jae      G_M19968_IG170
+       mov      r14d, dword ptr [rcx+4*rax+0x10]
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
+       cmp      eax, r14d
+       jl       G_M19968_IG18
+       mov      rdx, gword ptr [rbx+0x70]
+       mov      rdx, gword ptr [rdx+0x10]
+       mov      ecx, dword ptr [rbx+0x88]
+       inc      ecx
+       cmp      ecx, dword ptr [rdx+0x08]
+       jae      G_M19968_IG170
+       movzx    r15, word  ptr [rdx+4*rcx+0x10]
+						;; size=80 bbWeight=0 PerfScore 0.00
 G_M19968_IG152:
-       mov      rcx, gword ptr [rbx+0x70]
-       mov      rcx, gword ptr [rcx+0x10]
-       mov      eax, dword ptr [rbx+0x88]
-       add      eax, 2
-       cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
-       mov      r14d, dword ptr [rcx+4*rax+0x10]
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
-       cmp      eax, r14d
-       jl       G_M19968_IG17
-       mov      rdx, gword ptr [rbx+0x70]
-       mov      rdx, gword ptr [rdx+0x10]
-       mov      ecx, dword ptr [rbx+0x88]
-       inc      ecx
-       cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
-       movzx    r15, word  ptr [rdx+4*rcx+0x10]
-						;; size=80 bbWeight=0 PerfScore 0.00
-G_M19968_IG153:
        lea      edx, [r14-0x01]
        mov      r13d, edx
        test     r14d, r14d
-       jle      G_M19968_IG156
+       jle      G_M19968_IG155
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7690,34 +7690,34 @@ G_M19968_IG153:
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        cmp      eax, r15d
        mov      r14d, r13d
-       je       G_M19968_IG17
-       jmp      SHORT G_M19968_IG153
+       je       G_M19968_IG18
+       jmp      SHORT G_M19968_IG152
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M19968_IG154:
+G_M19968_IG153:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r14d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      eax, r14d
-       jl       G_M19968_IG17
+       jl       G_M19968_IG18
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        movzx    r15, word  ptr [rdx+4*rcx+0x10]
 						;; size=80 bbWeight=0 PerfScore 0.00
-G_M19968_IG155:
+G_M19968_IG154:
        lea      edx, [r14-0x01]
        mov      r13d, edx
        test     r14d, r14d
-       jle      SHORT G_M19968_IG156
+       jle      SHORT G_M19968_IG155
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7725,17 +7725,17 @@ G_M19968_IG155:
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        cmp      eax, r15d
        mov      r14d, r13d
-       jne      G_M19968_IG17
-       jmp      SHORT G_M19968_IG155
+       jne      G_M19968_IG18
+       jmp      SHORT G_M19968_IG154
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M19968_IG156:
+G_M19968_IG155:
        mov      ebp, 2
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG157:
+G_M19968_IG156:
        lea      r15d, [r14-0x118]
        cmp      r15d, 5
-       ja       SHORT G_M19968_IG158
+       ja       SHORT G_M19968_IG157
        mov      edx, r15d
        lea      r8, [reloc @RWD324]
        mov      r8d, dword ptr [r8+4*rdx]
@@ -7743,24 +7743,24 @@ G_M19968_IG157:
        add      r8, rcx
        jmp      r8
 						;; size=40 bbWeight=0 PerfScore 0.00
-G_M19968_IG158:
+G_M19968_IG157:
        cmp      r14d, 525
-       jne      G_M19968_IG17
+       jne      G_M19968_IG18
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG159:
+G_M19968_IG158:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r15d, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x28]
        mov      edx, r15d
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Match:IsMatched(int):ubyte:this]
        test     eax, eax
-       je       SHORT G_M19968_IG160
+       je       SHORT G_M19968_IG159
        mov      rcx, gword ptr [rbx+0x28]
        mov      edx, r15d
        cmp      dword ptr [rcx], ecx
@@ -7782,19 +7782,19 @@ G_M19968_IG159:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:MatchRef(int,int,System.ReadOnlySpan`1[ushort],ubyte):ubyte:this]
        test     eax, eax
-       jne      SHORT G_M19968_IG161
-       jmp      G_M19968_IG17
+       jne      SHORT G_M19968_IG160
+       jmp      G_M19968_IG18
 						;; size=140 bbWeight=0 PerfScore 0.00
-G_M19968_IG160:
+G_M19968_IG159:
        mov      rax, gword ptr [rbx+0x30]
        test     dword ptr [rax+0x40], 256
-       je       G_M19968_IG17
+       je       G_M19968_IG18
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG161:
+G_M19968_IG160:
        mov      ebp, 1
-       jmp      G_M19968_IG22
+       jmp      G_M19968_IG23
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG162:
+G_M19968_IG161:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
        mov      dword ptr [rbx+0x50], eax
@@ -7802,38 +7802,38 @@ G_M19968_IG162:
        mov      rdx, gword ptr [rbx+0x10]
        lea      r8d, [rax-0x01]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        dec      r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=77 bbWeight=0 PerfScore 0.00
-G_M19968_IG163:
+G_M19968_IG162:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      r8d, dword ptr [rbx+0x50]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=69 bbWeight=0 PerfScore 0.00
-G_M19968_IG164:
+G_M19968_IG163:
        inc      dword ptr [rbx+0x54]
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
@@ -7841,79 +7841,78 @@ G_M19968_IG164:
        mov      rcx, gword ptr [rbx+0x10]
        dec      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      eax, dword ptr [rcx+4*rax+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG171
+       jae      G_M19968_IG170
        mov      dword ptr [rcx+4*rdx+0x10], eax
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=60 bbWeight=0 PerfScore 0.00
-G_M19968_IG165:
+G_M19968_IG164:
        mov      eax, dword ptr [rbx+0x50]
        inc      eax
        mov      dword ptr [rbx+0x50], eax
        mov      rcx, gword ptr [rbx+0x10]
        dec      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      SHORT G_M19968_IG171
+       jae      SHORT G_M19968_IG170
        mov      eax, dword ptr [rcx+4*rax+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      SHORT G_M19968_IG171
+       jae      SHORT G_M19968_IG170
        mov      dword ptr [rcx+4*rdx+0x10], eax
-       jmp      G_M19968_IG17
+       jmp      G_M19968_IG18
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M19968_IG166:
+G_M19968_IG165:
        call     <unknown method>
        cmp      rax, qword ptr [rbx+0x38]
-       jl       G_M19968_IG18
+       jl       G_M19968_IG19
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M19968_IG167:
+G_M19968_IG166:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:<CheckTimeout>g__ThrowRegexTimeout|25_0():this]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG168:
+G_M19968_IG167:
        neg      r12d
        mov      eax, 256
-       jmp      G_M19968_IG19
+       jmp      G_M19968_IG20
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG169:
+G_M19968_IG168:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleStack():this]
-       jmp      G_M19968_IG20
-						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG170:
-       mov      rcx, rbx
-       call     [System.Text.RegularExpressions.RegexRunner:DoubleTrack():this]
        jmp      G_M19968_IG21
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG171:
+G_M19968_IG169:
+       mov      rcx, rbx
+       call     [System.Text.RegularExpressions.RegexRunner:DoubleTrack():this]
+       jmp      G_M19968_IG22
+						;; size=14 bbWeight=0 PerfScore 0.00
+G_M19968_IG170:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-RWD00  	dd	G_M19968_IG154 - G_M19968_IG02
-       	dd	G_M19968_IG152 - G_M19968_IG02
-       	dd	G_M19968_IG147 - G_M19968_IG02
-       	dd	G_M19968_IG139 - G_M19968_IG02
-       	dd	G_M19968_IG126 - G_M19968_IG02
-       	dd	G_M19968_IG115 - G_M19968_IG02
-       	dd	G_M19968_IG112 - G_M19968_IG02
-       	dd	G_M19968_IG112 - G_M19968_IG02
-       	dd	G_M19968_IG112 - G_M19968_IG02
+RWD00  	dd	G_M19968_IG153 - G_M19968_IG02
+       	dd	G_M19968_IG151 - G_M19968_IG02
+       	dd	G_M19968_IG146 - G_M19968_IG02
+       	dd	G_M19968_IG138 - G_M19968_IG02
+       	dd	G_M19968_IG125 - G_M19968_IG02
+       	dd	G_M19968_IG114 - G_M19968_IG02
+       	dd	G_M19968_IG111 - G_M19968_IG02
+       	dd	G_M19968_IG111 - G_M19968_IG02
        	dd	G_M19968_IG111 - G_M19968_IG02
        	dd	G_M19968_IG110 - G_M19968_IG02
-       	dd	G_M19968_IG105 - G_M19968_IG02
-       	dd	G_M19968_IG36 - G_M19968_IG02
-       	dd	G_M19968_IG159 - G_M19968_IG02
-       	dd	G_M19968_IG102 - G_M19968_IG02
+       	dd	G_M19968_IG109 - G_M19968_IG02
+       	dd	G_M19968_IG104 - G_M19968_IG02
+       	dd	G_M19968_IG35 - G_M19968_IG02
+       	dd	G_M19968_IG158 - G_M19968_IG02
        	dd	G_M19968_IG101 - G_M19968_IG02
        	dd	G_M19968_IG100 - G_M19968_IG02
        	dd	G_M19968_IG99 - G_M19968_IG02
@@ -7921,73 +7920,74 @@ RWD00  	dd	G_M19968_IG154 - G_M19968_IG02
        	dd	G_M19968_IG97 - G_M19968_IG02
        	dd	G_M19968_IG96 - G_M19968_IG02
        	dd	G_M19968_IG95 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG35 - G_M19968_IG02
-       	dd	G_M19968_IG93 - G_M19968_IG02
-       	dd	G_M19968_IG90 - G_M19968_IG02
-       	dd	G_M19968_IG88 - G_M19968_IG02
+       	dd	G_M19968_IG94 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG34 - G_M19968_IG02
+       	dd	G_M19968_IG92 - G_M19968_IG02
+       	dd	G_M19968_IG89 - G_M19968_IG02
        	dd	G_M19968_IG87 - G_M19968_IG02
-       	dd	G_M19968_IG84 - G_M19968_IG02
-       	dd	G_M19968_IG82 - G_M19968_IG02
+       	dd	G_M19968_IG86 - G_M19968_IG02
+       	dd	G_M19968_IG83 - G_M19968_IG02
        	dd	G_M19968_IG81 - G_M19968_IG02
-       	dd	G_M19968_IG03 - G_M19968_IG02
+       	dd	G_M19968_IG80 - G_M19968_IG02
+       	dd	G_M19968_IG33 - G_M19968_IG02
        	dd	G_M19968_IG30 - G_M19968_IG02
-       	dd	G_M19968_IG79 - G_M19968_IG02
+       	dd	G_M19968_IG77 - G_M19968_IG02
        	dd	G_M19968_IG28 - G_M19968_IG02
-       	dd	G_M19968_IG76 - G_M19968_IG02
-       	dd	G_M19968_IG27 - G_M19968_IG02
-       	dd	G_M19968_IG75 - G_M19968_IG02
-       	dd	G_M19968_IG26 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG24 - G_M19968_IG02
        	dd	G_M19968_IG74 - G_M19968_IG02
+       	dd	G_M19968_IG27 - G_M19968_IG02
        	dd	G_M19968_IG73 - G_M19968_IG02
-       	dd	G_M19968_IG139 - G_M19968_IG02
-       	dd	G_M19968_IG126 - G_M19968_IG02
-       	dd	G_M19968_IG115 - G_M19968_IG02
+       	dd	G_M19968_IG26 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG24 - G_M19968_IG02
        	dd	G_M19968_IG72 - G_M19968_IG02
-RWD188 	dd	G_M19968_IG69 - G_M19968_IG02
-       	dd	G_M19968_IG69 - G_M19968_IG02
-       	dd	G_M19968_IG69 - G_M19968_IG02
-       	dd	G_M19968_IG66 - G_M19968_IG02
-       	dd	G_M19968_IG63 - G_M19968_IG02
-       	dd	G_M19968_IG56 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
+       	dd	G_M19968_IG71 - G_M19968_IG02
+       	dd	G_M19968_IG138 - G_M19968_IG02
+       	dd	G_M19968_IG125 - G_M19968_IG02
+       	dd	G_M19968_IG114 - G_M19968_IG02
+       	dd	G_M19968_IG70 - G_M19968_IG02
+RWD188 	dd	G_M19968_IG67 - G_M19968_IG02
+       	dd	G_M19968_IG67 - G_M19968_IG02
+       	dd	G_M19968_IG67 - G_M19968_IG02
+       	dd	G_M19968_IG64 - G_M19968_IG02
+       	dd	G_M19968_IG61 - G_M19968_IG02
+       	dd	G_M19968_IG54 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
-       	dd	G_M19968_IG53 - G_M19968_IG02
-       	dd	G_M19968_IG52 - G_M19968_IG02
-       	dd	G_M19968_IG23 - G_M19968_IG02
-       	dd	G_M19968_IG23 - G_M19968_IG02
+       	dd	G_M19968_IG51 - G_M19968_IG02
        	dd	G_M19968_IG50 - G_M19968_IG02
-       	dd	G_M19968_IG47 - G_M19968_IG02
-       	dd	G_M19968_IG16 - G_M19968_IG02
-       	dd	G_M19968_IG16 - G_M19968_IG02
-       	dd	G_M19968_IG46 - G_M19968_IG02
+       	dd	G_M19968_IG17 - G_M19968_IG02
+       	dd	G_M19968_IG17 - G_M19968_IG02
+       	dd	G_M19968_IG48 - G_M19968_IG02
        	dd	G_M19968_IG45 - G_M19968_IG02
-       	dd	G_M19968_IG23 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
+       	dd	G_M19968_IG16 - G_M19968_IG02
+       	dd	G_M19968_IG16 - G_M19968_IG02
+       	dd	G_M19968_IG44 - G_M19968_IG02
        	dd	G_M19968_IG43 - G_M19968_IG02
-RWD324 	dd	G_M19968_IG165 - G_M19968_IG02
-       	dd	G_M19968_IG164 - G_M19968_IG02
-       	dd	G_M19968_IG17 - G_M19968_IG02
        	dd	G_M19968_IG17 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG41 - G_M19968_IG02
+RWD324 	dd	G_M19968_IG164 - G_M19968_IG02
        	dd	G_M19968_IG163 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG18 - G_M19968_IG02
        	dd	G_M19968_IG162 - G_M19968_IG02
+       	dd	G_M19968_IG161 - G_M19968_IG02
 
 
-; Total bytes of code 7094, prolog size 26, PerfScore 1012.30, instruction count 1791, allocated bytes for code 7094 (MethodHash=588bb1ff) for method System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1)
+; Total bytes of code 7122, prolog size 26, PerfScore 1008.87, instruction count 1793, allocated bytes for code 7122 (MethodHash=588bb1ff) for method System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Regex.RunAllMatchesWithCallback(class System.String,value class System.ReadOnlySpan`1<wchar>,int32,!!0&,class System.Text.RegularExpressions.MatchCallback`1<!!0>,value class System.Text.RegularExpressions.RegexRunnerMode,bool)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 3029
+; with Dynamic PGO: fgCalledCount is 3438
 ; 9 inlinees with PGO data; 18 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T41] ( 11,  20.90)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
+;  V00 this         [V00,T42] ( 11,  21.04)     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
 ;* V01 TypeCtx      [V01    ] (  0,   0   )    long  ->  zero-ref    single-def
-;  V02 arg1         [V02,T46] (  5,   3.01)     ref  ->  r15         class-hnd single-def <System.String>
-;  V03 arg2         [V03,T45] (  4,   8   )   byref  ->   r9         ld-addr-op single-def
-;  V04 arg3         [V04,T18] ( 13,  62.58)     int  ->  registers  
-;  V05 arg4         [V05,T13] ( 13,  89.38)   byref  ->  rbx         single-def
-;  V06 arg5         [V06,T49] (  5,   2.15)     ref  ->  registers   class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]]>
-;  V07 arg6         [V07,T37] (  4,  30.80)     int  ->  rdi         single-def
-;  V08 arg7         [V08,T39] (  4,  29.80)   ubyte  ->  r14         single-def
-;  V09 loc0         [V09,T05] ( 89, 392.62)     ref  ->  [rbp-0x68]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
-;  V10 loc1         [V10,T36] (  7,  31.79)     int  ->  [rbp-0x3C] 
+;  V02 arg1         [V02,T48] (  5,   3.01)     ref  ->  r15         class-hnd single-def <System.String>
+;  V03 arg2         [V03,T47] (  4,   8   )   byref  ->   r9         ld-addr-op single-def
+;  V04 arg3         [V04,T17] ( 13,  63.17)     int  ->  registers  
+;  V05 arg4         [V05,T12] ( 13,  90.26)   byref  ->  rbx         single-def
+;  V06 arg5         [V06,T51] (  5,   2.15)     ref  ->  registers   class-hnd single-def <System.Text.RegularExpressions.MatchCallback`1[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]]>
+;  V07 arg6         [V07,T38] (  4,  31.09)     int  ->  rdi         single-def
+;  V08 arg7         [V08,T39] (  4,  30.09)   ubyte  ->  r14         single-def
+;  V09 loc0         [V09,T05] ( 89, 396.30)     ref  ->  [rbp-0x68]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
+;  V10 loc1         [V10,T37] (  7,  32.09)     int  ->  [rbp-0x3C] 
 ;* V11 loc2         [V11    ] (  0,   0   )     ref  ->  zero-ref    class-hnd <System.Text.RegularExpressions.Match>
-;  V12 loc3         [V12,T65] (  6,   0   )     int  ->  registers  
-;  V13 loc4         [V13,T66] (  6,   0   )     int  ->  r10        
+;  V12 loc3         [V12,T67] (  6,   0   )     int  ->  registers  
+;  V13 loc4         [V13,T68] (  6,   0   )     int  ->  r10        
 ;  V14 OutArgs      [V14    ] (  1,   1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V15 tmp1         [V15,T48] (  2,   4   )     ref  ->   r8         class-hnd single-def "dup spill" <System.__Canon>
-;  V16 tmp2         [V16,T47] (  6,   5.00)     ref  ->  [rbp-0x70] 
-;  V17 tmp3         [V17,T25] (  4,  59.58)     int  ->  r10         "dup spill"
-;  V18 tmp4         [V18,T69] (  2,   0   )     int  ->  rax         "guarded devirt return temp"
+;  V15 tmp1         [V15,T50] (  2,   4   )     ref  ->   r8         class-hnd single-def "dup spill" <System.__Canon>
+;  V16 tmp2         [V16,T49] (  6,   5.00)     ref  ->  [rbp-0x70] 
+;  V17 tmp3         [V17,T21] (  4,  60.17)     int  ->  r10         "dup spill"
+;  V18 tmp4         [V18,T71] (  2,   0   )     int  ->  rax         "guarded devirt return temp"
 ;* V19 tmp5         [V19    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "guarded devirt this exact temp" <System.Text.RegularExpressions.RegexReplacement+<>c>
 ;* V20 tmp6         [V20    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V21 tmp7         [V21,T07] ( 16, 127.07)     ref  ->  rsi         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp8         [V22,T68] (  4,   0   )     int  ->  rax         "dup spill"
-;  V23 tmp9         [V23,T62] ( 14,   0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
-;  V24 tmp10        [V24,T63] (  8,   0   )     int  ->  [rbp-0x44]  "Inline stloc first use temp"
+;  V21 tmp7         [V21,T07] ( 16, 128.25)     ref  ->  rsi         class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V22 tmp8         [V22,T70] (  4,   0   )     int  ->  rax         "dup spill"
+;  V23 tmp9         [V23,T64] ( 14,   0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V24 tmp10        [V24,T65] (  8,   0   )     int  ->  [rbp-0x44]  "Inline stloc first use temp"
 ;* V25 tmp11        [V25    ] (  0,   0   )     ref  ->  zero-ref   
-;  V26 tmp12        [V26,T64] (  6,   0   )     ref  ->  [rbp-0x78]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp12        [V26,T66] (  6,   0   )     ref  ->  [rbp-0x78]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp13        [V27    ] (  0,   0   )     ref  ->  zero-ref   
-;  V28 tmp14        [V28,T59] (  6,   0.03)     ref  ->  rdx        
-;  V29 tmp15        [V29,T54] (  8,   0.13)     ref  ->  [rbp-0x80]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp16        [V30,T56] (  4,   0.06)     ref  ->  rax         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp14        [V28,T61] (  6,   0.03)     ref  ->  rdx        
+;  V29 tmp15        [V29,T56] (  8,   0.13)     ref  ->  [rbp-0x80]  class-hnd exact "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp16        [V30,T58] (  4,   0.06)     ref  ->  rax         class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp17        [V31    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp18        [V32    ] (  0,   0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp19        [V33    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp20        [V34,T57] (  4,   0.06)     ref  ->  [rbp-0x88]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp21        [V35,T17] (  4,  63.52)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
+;  V34 tmp20        [V34,T59] (  4,   0.06)     ref  ->  [rbp-0x88]  class-hnd "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp21        [V35,T16] (  4,  64.11)     ref  ->  rdx         class-hnd exact "Inlining Arg" <System.String>
 ;* V36 tmp22        [V36    ] (  0,   0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp23        [V37,T28] (  7,  47.97)     ref  ->  registers   class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V38 tmp24        [V38,T15] ( 10,  80.08)     int  ->  registers   "Inline stloc first use temp"
-;  V39 tmp25        [V39,T16] (  6,  63.52)     ref  ->  r10         class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp23        [V37,T35] (  7,  40.34)     ref  ->  rcx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V38 tmp24        [V38,T44] (  5,   0.81)     int  ->  rdx         "Inline stloc first use temp"
+;  V39 tmp25        [V39,T15] (  6,  64.11)     ref  ->  registers   class-hnd "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp26        [V40    ] (  0,   0   )     ref  ->  zero-ref   
-;  V41 tmp27        [V41,T11] ( 15,  91.38)     ref  ->  [rbp-0x90]  class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
+;  V41 tmp27        [V41,T11] ( 15,  92.26)     ref  ->  [rbp-0x90]  class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp28        [V42    ] (  0,   0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V43 tmp29        [V43,T06] ( 30, 166.95)     ref  ->  [rbp-0x98]  class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V44 tmp30        [V44,T00] ( 63,7433.89)     ref  ->  [rbp-0xA0]  class-hnd exact "guarded devirt this exact temp" <System.Text.RegularExpressions.RegexInterpreter>
+;  V43 tmp29        [V43,T06] ( 30, 168.49)     ref  ->  [rbp-0x98]  class-hnd "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V44 tmp30        [V44,T00] ( 63,7505.63)     ref  ->  [rbp-0xA0]  class-hnd exact "guarded devirt this exact temp" <System.Text.RegularExpressions.RegexInterpreter>
 ;* V45 tmp31        [V45    ] (  0,   0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V46 tmp32        [V46    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V47 tmp33        [V47    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V48 tmp34        [V48,T20] (  4,  59.62)     int  ->  r10         "Inlining Arg"
+;  V48 tmp34        [V48,T22] (  4,  60.17)     int  ->  r10         "Inlining Arg"
 ;* V49 tmp35        [V49    ] (  0,   0   )     ref  ->  zero-ref    class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V50 tmp36        [V50,T19] (  9,  59.77)     ref  ->   r9         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V51 tmp37        [V51,T21] (  4,  59.62)     int  ->  r11         "Inlining Arg"
-;  V52 tmp38        [V52,T22] (  4,  59.62)     int  ->  rdx         "Inlining Arg"
-;  V53 tmp39        [V53,T08] ( 10, 119.17)   byref  ->  registers   "impAppendStmt"
+;  V50 tmp36        [V50,T18] (  9,  60.32)     ref  ->   r9         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V51 tmp37        [V51,T23] (  4,  60.17)     int  ->  r11         "Inlining Arg"
+;  V52 tmp38        [V52,T24] (  4,  60.17)     int  ->  rdx         "Inlining Arg"
+;  V53 tmp39        [V53,T08] ( 10, 120.35)   byref  ->  registers   "impAppendStmt"
 ;* V54 tmp40        [V54    ] (  0,   0   )     int  ->  zero-ref    "impAppendStmt"
-;  V55 tmp41        [V55,T14] (  6,  89.38)   byref  ->  registers   "dup spill"
-;  V56 tmp42        [V56,T33] (  6,  44.69)     int  ->   r8         "Inline stloc first use temp"
-;  V57 tmp43        [V57,T09] ( 10, 119.17)   byref  ->  registers   "Inlining Arg"
-;  V58 tmp44        [V58,T34] (  7,  44.36)     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V59 tmp45        [V59,T26] (  9,  58.79)     int  ->  r10         "Inline stloc first use temp"
-;  V60 tmp46        [V60,T23] (  6,  59.58)     int  ->  rdx         "Inlining Arg"
-;  V61 tmp47        [V61,T35] (  7,  44.36)     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V62 tmp48        [V62,T27] (  9,  58.79)     int  ->  r10         "Inline stloc first use temp"
-;  V63 tmp49        [V63,T24] (  6,  59.58)     int  ->  rdx         "Inlining Arg"
-;  V64 tmp50        [V64,T04] ( 10,1158.66)   byref  ->  r12         single-def "field V03._reference (fldOffset=0x0)" P-INDEP
-;  V65 tmp51        [V65,T02] ( 22,1753.88)     int  ->  [rbp-0x48]  spill-single-def "field V03._length (fldOffset=0x8)" P-INDEP
+;  V55 tmp41        [V55,T13] (  6,  90.26)   byref  ->  registers   "dup spill"
+;  V56 tmp42        [V56,T32] (  6,  45.13)     int  ->   r8         "Inline stloc first use temp"
+;  V57 tmp43        [V57,T09] ( 10, 120.35)   byref  ->  registers   "Inlining Arg"
+;  V58 tmp44        [V58,T33] (  7,  44.80)     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V59 tmp45        [V59,T25] (  9,  59.37)     int  ->  r10         "Inline stloc first use temp"
+;  V60 tmp46        [V60,T19] (  6,  60.17)     int  ->  rdx         "Inlining Arg"
+;  V61 tmp47        [V61,T34] (  7,  44.80)     ref  ->   r8         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V62 tmp48        [V62,T26] (  9,  59.37)     int  ->  r10         "Inline stloc first use temp"
+;  V63 tmp49        [V63,T20] (  6,  60.17)     int  ->  rdx         "Inlining Arg"
+;  V64 tmp50        [V64,T04] ( 10,1169.82)   byref  ->  r12         single-def "field V03._reference (fldOffset=0x0)" P-INDEP
+;  V65 tmp51        [V65,T02] ( 22,1770.78)     int  ->  [rbp-0x48]  spill-single-def "field V03._length (fldOffset=0x8)" P-INDEP
 ;* V66 tmp52        [V66    ] (  0,   0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V67 tmp53        [V67    ] (  0,   0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V68 tmp54        [V68    ] (  0,   0   )   byref  ->  zero-ref    "field V42._reference (fldOffset=0x0)" P-INDEP
 ;* V69 tmp55        [V69    ] (  0,   0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;* V70 tmp56        [V70,T43] (  0,   0   )   byref  ->  zero-ref    "field V45._reference (fldOffset=0x0)" P-INDEP
-;* V71 tmp57        [V71,T44] (  0,   0   )     int  ->  zero-ref    "field V45._length (fldOffset=0x8)" P-INDEP
+;* V70 tmp56        [V70,T45] (  0,   0   )   byref  ->  zero-ref    "field V45._reference (fldOffset=0x0)" P-INDEP
+;* V71 tmp57        [V71,T46] (  0,   0   )     int  ->  zero-ref    "field V45._length (fldOffset=0x8)" P-INDEP
 ;* V72 tmp58        [V72    ] (  0,   0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V73 tmp59        [V73,T60] (  3,   0.00)     ref  ->  rcx         single-def "argument with side effect"
-;  V74 tmp60        [V74    ] ( 27,6945.96)  struct (16) [rbp-0x58]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V75 tmp61        [V75,T67] (  4,   0   )     ref  ->  rcx         "argument with side effect"
-;  V76 tmp62        [V76,T01] (  4,2317.31)     ref  ->  rcx         "argument with side effect"
-;  V77 tmp63        [V77,T10] (  6,  95.38)     ref  ->   r8         "arr expr"
-;* V78 tmp64        [V78,T38] (  0,   0   )     ref  ->  zero-ref    "arr expr"
-;  V79 tmp65        [V79,T12] (  6,  89.44)     ref  ->   r8         "arr expr"
-;  V80 PSPSym       [V80,T50] (  1,   1   )    long  ->  [rbp-0xB8]  do-not-enreg[V] "PSPSym"
-;  V81 cse0         [V81,T32] (  3,  46.23)     int  ->  [rbp-0x5C]  spill-single-def "CSE #16: moderate"
-;  V82 cse1         [V82,T53] (  3,   0.47)     int  ->  [rbp-0x60]  spill-single-def "CSE #35: conservative"
-;  V83 cse2         [V83,T58] (  3,   0.05)     ref  ->  [rbp-0xA8]  spill-single-def "CSE #02: conservative"
-;  V84 cse3         [V84,T61] (  3,   0.00)     ref  ->  [rbp-0xB0]  spill-single-def "CSE #23: conservative"
-;  V85 cse4         [V85,T03] (  3,1673.39)     int  ->  rcx         "CSE #10: aggressive"
-;  V86 cse5         [V86,T30] (  3,  47.21)     ref  ->  rcx         "CSE #06: moderate"
-;  V87 cse6         [V87,T31] (  2,  31.47)     ref  ->   r8         "CSE #13: moderate"
-;  V88 cse7         [V88,T42] (  3,  16.90)     int  ->  rcx         "CSE #31: conservative"
-;  V89 cse8         [V89,T51] (  3,   0.48)     ref  ->  rcx         "CSE #28: conservative"
-;  V90 cse9         [V90,T52] (  2,   0.32)     ref  ->   r8         "CSE #32: conservative"
-;  V91 cse10        [V91,T55] ( 12,   0.06)     ref  ->  rsi         multi-def "CSE #01: conservative"
-;  V92 cse11        [V92,T29] (  3,  47.33)     int  ->  rdx         "CSE #05: moderate"
-;  V93 cse12        [V93,T40] (  2,  29.51)     int  ->  rcx         "CSE #17: moderate"
+;  V73 tmp59        [V73,T62] (  3,   0.00)     ref  ->  rcx         single-def "argument with side effect"
+;  V74 tmp60        [V74    ] ( 27,7012.93)  struct (16) [rbp-0x58]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V75 tmp61        [V75,T69] (  4,   0   )     ref  ->  rcx         "argument with side effect"
+;  V76 tmp62        [V76,T01] (  4,2339.66)     ref  ->  rcx         "argument with side effect"
+;  V77 tmp63        [V77,T10] (  6,  96.26)     ref  ->   r8         "arr expr"
+;* V78 tmp64        [V78,T40] (  0,   0   )     ref  ->  zero-ref    "arr expr"
+;  V79 tmp65        [V79,T14] (  6,  90.26)     ref  ->   r8         "arr expr"
+;  V80 PSPSym       [V80,T52] (  1,   1   )    long  ->  [rbp-0xB8]  do-not-enreg[V] "PSPSym"
+;  V81 cse0         [V81,T31] (  3,  46.66)     int  ->  [rbp-0x5C]  spill-single-def "CSE #16: moderate"
+;  V82 cse1         [V82,T55] (  3,   0.47)     int  ->  [rbp-0x60]  spill-single-def "CSE #35: conservative"
+;  V83 cse2         [V83,T60] (  3,   0.05)     ref  ->  [rbp-0xA8]  spill-single-def "CSE #02: conservative"
+;  V84 cse3         [V84,T63] (  3,   0.00)     ref  ->  [rbp-0xB0]  spill-single-def "CSE #23: conservative"
+;  V85 cse4         [V85,T03] (  3,1689.55)     int  ->  rcx         "CSE #10: aggressive"
+;  V86 cse5         [V86,T29] (  3,  47.65)     ref  ->  rcx         "CSE #06: moderate"
+;  V87 cse6         [V87,T30] (  2,  31.77)     ref  ->   r8         "CSE #13: moderate"
+;  V88 cse7         [V88,T43] (  3,  17.07)     int  ->  rcx         "CSE #31: conservative"
+;  V89 cse8         [V89,T53] (  3,   0.48)     ref  ->  rcx         "CSE #28: conservative"
+;  V90 cse9         [V90,T54] (  2,   0.32)     ref  ->   r8         "CSE #32: conservative"
+;  V91 cse10        [V91,T57] ( 12,   0.06)     ref  ->  rsi         multi-def "CSE #01: conservative"
+;  V92 cse11        [V92,T36] (  3,  39.70)     int  ->  rdx         "CSE #05: moderate"
+;  V93 cse12        [V93,T41] (  2,  29.79)     int  ->  rcx         "CSE #17: moderate"
+;  V94 rat0         [V94,T27] (  4,  55.90)   byref  ->  rcx         "Strength reduced derived IV"
+;  V95 rat1         [V95,T28] (  4,  55.90)     int  ->  rdx         "Trip count IV"
 ;
 ; Lcl frame size = 168
 
@@ -1045,8 +1047,8 @@ G_M29863_IG04:
        mov      r8, rax
        mov      rdx, gword ptr [rbp+0x10]
        jmp      SHORT G_M29863_IG03
-       align    [13 bytes for IG10]
-						;; size=37 bbWeight=0.00 PerfScore 0.00
+       align    [9 bytes for IG10]
+						;; size=33 bbWeight=0.00 PerfScore 0.00
 G_M29863_IG05:
        mov      gword ptr [rbp-0x70], r8
        lea      rcx, bword ptr [r8+0x08]
@@ -1080,7 +1082,7 @@ G_M29863_IG06:
        mov      dword ptr [rsi+0x58], ecx
        mov      r8, rsi
        mov      esi, r9d
-						;; size=36 bbWeight=14.75 PerfScore 228.58
+						;; size=36 bbWeight=14.89 PerfScore 230.84
 G_M29863_IG07:
        mov      dword ptr [r8+0x60], edi
        lea      rcx, bword ptr [r8+0x30]
@@ -1096,7 +1098,7 @@ G_M29863_IG07:
        mov      rsi, gword ptr [r8+0x28]
        test     rsi, rsi
        je       G_M29863_IG19
-						;; size=56 bbWeight=15.74 PerfScore 204.58
+						;; size=56 bbWeight=15.88 PerfScore 206.48
 G_M29863_IG08:
        mov      rdx, gword ptr [r8+0x08]
        lea      rcx, bword ptr [rsi+0x08]
@@ -1104,27 +1106,27 @@ G_M29863_IG08:
        xor      ecx, ecx
        mov      dword ptr [rsi+0x34], ecx
        mov      dword ptr [rsi+0x5C], r13d
-       mov      rax, gword ptr [rsi+0x50]
-						;; size=26 bbWeight=15.72 PerfScore 121.84
-G_M29863_IG09:
-       mov      edx, dword ptr [rax+0x08]
+       mov      rcx, gword ptr [rsi+0x50]
+       mov      edx, dword ptr [rcx+0x08]
        test     edx, edx
        jle      SHORT G_M29863_IG11
-						;; size=7 bbWeight=15.72 PerfScore 51.09
+						;; size=33 bbWeight=15.87 PerfScore 174.54
+G_M29863_IG09:
+       add      rcx, 16
+						;; size=4 bbWeight=7.96 PerfScore 1.99
 G_M29863_IG10:
-       mov      r9d, ecx
-       xor      r8d, r8d
-       mov      dword ptr [rax+4*r9+0x10], r8d
-       inc      ecx
-       cmp      edx, ecx
-       jg       SHORT G_M29863_IG10
-						;; size=17 bbWeight=15.89 PerfScore 47.67
+       xor      r9d, r9d
+       mov      dword ptr [rcx], r9d
+       add      rcx, 4
+       dec      edx
+       jne      SHORT G_M29863_IG10
+						;; size=14 bbWeight=15.98 PerfScore 43.95
 G_M29863_IG11:
        mov      byte  ptr [rsi+0x60], 0
-       mov      r10, gword ptr [rsi+0x38]
-       test     r10, r10
+       mov      rax, gword ptr [rsi+0x38]
+       test     rax, rax
        jne      G_M29863_IG66
-						;; size=17 bbWeight=15.72 PerfScore 66.82
+						;; size=17 bbWeight=15.87 PerfScore 67.44
 G_M29863_IG12:
        mov      r8, gword ptr [rbp-0x68]
        mov      rcx, gword ptr [r8+0x20]
@@ -1138,7 +1140,7 @@ G_M29863_IG12:
        mov      dword ptr [r8+0x54], edx
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [r8+0x58], ecx
-						;; size=46 bbWeight=15.74 PerfScore 271.46
+						;; size=46 bbWeight=15.88 PerfScore 273.99
 G_M29863_IG13:
        mov      esi, dword ptr [rbp-0x3C]
        mov      dword ptr [r8+0x4C], esi
@@ -1147,7 +1149,7 @@ G_M29863_IG13:
        test     byte  ptr [rcx+0x40], 64
        je       SHORT G_M29863_IG15
        jmp      G_M29863_IG72
-						;; size=25 bbWeight=15.74 PerfScore 161.30
+						;; size=25 bbWeight=15.88 PerfScore 162.80
 G_M29863_IG14:
        mov      rax, gword ptr [rsi+0x10]
        mov      eax, dword ptr [rax+0x08]
@@ -1160,7 +1162,7 @@ G_M29863_IG14:
        mov      dword ptr [rsi+0x58], eax
        inc      ecx
        mov      dword ptr [rsi+0x4C], ecx
-						;; size=35 bbWeight=557.80 PerfScore 9064.21
+						;; size=35 bbWeight=563.18 PerfScore 9151.74
 G_M29863_IG15:
        mov      rcx, gword ptr [rsi+0x70]
        mov      rcx, gword ptr [rcx+0x08]
@@ -1173,11 +1175,11 @@ G_M29863_IG15:
        call     [<unknown method>]
        test     eax, eax
        je       G_M29863_IG21
-						;; size=44 bbWeight=573.53 PerfScore 9319.93
+						;; size=44 bbWeight=579.07 PerfScore 9409.84
 G_M29863_IG16:
        cmp      byte  ptr [rsi+0x68], 0
        jne      G_M29863_IG71
-						;; size=10 bbWeight=572.55 PerfScore 2290.19
+						;; size=10 bbWeight=578.07 PerfScore 2312.27
 G_M29863_IG17:
        mov      bword ptr [rbp-0x58], r12
        mov      dword ptr [rbp-0x50], r13d
@@ -1186,13 +1188,13 @@ G_M29863_IG17:
        call     [<unknown method>]
        test     eax, eax
        jne      G_M29863_IG21
-						;; size=29 bbWeight=572.55 PerfScore 4007.84
+						;; size=29 bbWeight=578.07 PerfScore 4046.47
 G_M29863_IG18:
        mov      ecx, dword ptr [rsi+0x4C]
        cmp      ecx, r13d
        je       G_M29863_IG21
        jmp      G_M29863_IG14
-						;; size=17 bbWeight=557.80 PerfScore 2928.44
+						;; size=17 bbWeight=563.18 PerfScore 2956.72
 G_M29863_IG19:
        mov      rsi, gword ptr [r8+0x30]
        mov      rax, gword ptr [rsi+0x18]
@@ -1223,7 +1225,7 @@ G_M29863_IG20:
        lea      rcx, bword ptr [rsi+0x28]
        call     CORINFO_HELP_ASSIGN_REF
        jmp      G_M29863_IG12
-						;; size=14 bbWeight=0.02 PerfScore 0.05
+						;; size=14 bbWeight=0.02 PerfScore 0.06
 G_M29863_IG21:
        mov      rsi, gword ptr [rbp-0x68]
        mov      rax, gword ptr [rsi+0x28]
@@ -1234,11 +1236,11 @@ G_M29863_IG21:
        mov      dword ptr [rbp-0x5C], r8d
        test     r8d, r8d
        jle      G_M29863_IG33
-						;; size=40 bbWeight=15.74 PerfScore 208.52
+						;; size=40 bbWeight=15.88 PerfScore 210.45
 G_M29863_IG22:
        test     r14b, r14b
        je       G_M29863_IG32
-						;; size=9 bbWeight=14.76 PerfScore 18.45
+						;; size=9 bbWeight=14.89 PerfScore 18.62
 G_M29863_IG23:
        mov      r10d, dword ptr [rsi+0x4C]
        mov      r8d, dword ptr [rbp-0x5C]
@@ -1261,19 +1263,19 @@ G_M29863_IG23:
        mov      dword ptr [rax+0x10], edx
        cmp      edi, 2
        je       G_M29863_IG74
-						;; size=83 bbWeight=14.76 PerfScore 409.50
+						;; size=83 bbWeight=14.89 PerfScore 413.27
 G_M29863_IG24:
        mov      rcx, rax
-						;; size=3 bbWeight=14.76 PerfScore 3.69
+						;; size=3 bbWeight=14.89 PerfScore 3.72
 G_M29863_IG25:
        mov      gword ptr [rbp-0x90], rcx
        cmp      dword ptr [rcx+0x30], 0
        je       G_M29863_IG97
-						;; size=17 bbWeight=15.74 PerfScore 78.69
+						;; size=17 bbWeight=15.88 PerfScore 79.42
 G_M29863_IG26:
        test     r14b, r14b
        je       G_M29863_IG75
-						;; size=9 bbWeight=14.75 PerfScore 18.43
+						;; size=9 bbWeight=14.89 PerfScore 18.62
 G_M29863_IG27:
        lea      rax, bword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x10]
@@ -1281,13 +1283,13 @@ G_M29863_IG27:
        mov      r10d, dword ptr [rax+0x08]
        cmp      dword ptr [r8+0x08], r10d
        jbe      G_M29863_IG34
-						;; size=24 bbWeight=14.75 PerfScore 154.84
+						;; size=24 bbWeight=14.89 PerfScore 156.38
 G_M29863_IG28:
        mov      r9d, r10d
        mov      dword ptr [r8+4*r9+0x10], edx
        inc      r10d
        mov      dword ptr [rax+0x08], r10d
-						;; size=15 bbWeight=14.28 PerfScore 35.71
+						;; size=15 bbWeight=14.42 PerfScore 36.06
 G_M29863_IG29:
        lea      rax, bword ptr [rbx+0x18]
        mov      rcx, gword ptr [rbp-0x90]
@@ -1297,13 +1299,13 @@ G_M29863_IG29:
        mov      r10d, dword ptr [rax+0x08]
        cmp      dword ptr [r8+0x08], r10d
        jbe      G_M29863_IG35
-						;; size=34 bbWeight=14.75 PerfScore 213.83
+						;; size=34 bbWeight=14.89 PerfScore 215.95
 G_M29863_IG30:
        mov      r9d, r10d
        mov      dword ptr [r8+4*r9+0x10], edx
        inc      r10d
        mov      dword ptr [rax+0x08], r10d
-						;; size=15 bbWeight=14.28 PerfScore 35.71
+						;; size=15 bbWeight=14.42 PerfScore 36.06
 G_M29863_IG31:
        mov      rcx, gword ptr [rbp-0x90]
        mov      edx, dword ptr [rcx+0x10]
@@ -1321,7 +1323,7 @@ G_M29863_IG31:
        cmp      dword ptr [rcx+0x14], 0
        jne      G_M29863_IG06
        jmp      G_M29863_IG76
-						;; size=64 bbWeight=14.75 PerfScore 313.37
+						;; size=64 bbWeight=14.89 PerfScore 316.48
 G_M29863_IG32:
        mov      gword ptr [rbp-0x98], rax
        lea      rcx, bword ptr [rax+0x08]
@@ -1338,17 +1340,17 @@ G_M29863_IG33:
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rcx, gword ptr [rcx]
        jmp      G_M29863_IG25
-						;; size=24 bbWeight=0.98 PerfScore 5.39
+						;; size=24 bbWeight=0.99 PerfScore 5.45
 G_M29863_IG34:
        mov      rcx, rax
        call     [<unknown method>]
        jmp      G_M29863_IG29
-						;; size=14 bbWeight=0.46 PerfScore 2.43
+						;; size=14 bbWeight=0.47 PerfScore 2.46
 G_M29863_IG35:
        mov      rcx, rax
        call     [<unknown method>]
        jmp      G_M29863_IG31
-						;; size=14 bbWeight=0.46 PerfScore 2.43
+						;; size=14 bbWeight=0.47 PerfScore 2.46
 G_M29863_IG36:
        mov      rcx, gword ptr [rsi+0x10]
        mov      ecx, dword ptr [rcx+0x08]
@@ -1361,7 +1363,7 @@ G_M29863_IG36:
        mov      dword ptr [rsi+0x58], ecx
        mov      dword ptr [rbp-0x3C], r10d
        mov      esi, r8d
-						;; size=37 bbWeight=0.15 PerfScore 2.42
+						;; size=37 bbWeight=0.15 PerfScore 2.44
 G_M29863_IG37:
        mov      r9, gword ptr [rbp-0x68]
        mov      dword ptr [r9+0x60], edi
@@ -1378,7 +1380,7 @@ G_M29863_IG37:
        mov      rsi, gword ptr [rax+0x28]
        test     rsi, rsi
        je       G_M29863_IG48
-						;; size=57 bbWeight=0.16 PerfScore 2.23
+						;; size=57 bbWeight=0.16 PerfScore 2.25
 G_M29863_IG38:
        mov      rdx, gword ptr [rax+0x08]
        lea      rcx, bword ptr [rsi+0x08]
@@ -1391,7 +1393,7 @@ G_M29863_IG38:
        xor      edx, edx
        cmp      dword ptr [rcx+0x08], 0
        jle      SHORT G_M29863_IG40
-						;; size=36 bbWeight=0.16 PerfScore 2.06
+						;; size=36 bbWeight=0.16 PerfScore 2.08
 G_M29863_IG39:
        mov      r9d, edx
        xor      r8d, r8d
@@ -1399,13 +1401,13 @@ G_M29863_IG39:
        inc      edx
        cmp      dword ptr [rcx+0x08], edx
        jg       SHORT G_M29863_IG39
-						;; size=18 bbWeight=0.16 PerfScore 0.92
+						;; size=18 bbWeight=0.16 PerfScore 0.93
 G_M29863_IG40:
        mov      byte  ptr [rsi+0x60], 0
-       mov      r10, gword ptr [rsi+0x38]
-       test     r10, r10
+       mov      rcx, gword ptr [rsi+0x38]
+       test     rcx, rcx
        jne      G_M29863_IG78
-						;; size=17 bbWeight=0.16 PerfScore 0.67
+						;; size=17 bbWeight=0.16 PerfScore 0.68
 G_M29863_IG41:
        mov      rsi, gword ptr [rbp-0x68]
        mov      rcx, gword ptr [rsi+0x20]
@@ -1419,19 +1421,19 @@ G_M29863_IG41:
        mov      dword ptr [rsi+0x54], edx
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [rsi+0x58], ecx
-						;; size=43 bbWeight=0.16 PerfScore 2.74
+						;; size=43 bbWeight=0.16 PerfScore 2.77
 G_M29863_IG42:
-       mov      r11d, dword ptr [rbp-0x3C]
-       mov      dword ptr [rsi+0x4C], r11d
+       mov      r10d, dword ptr [rbp-0x3C]
+       mov      dword ptr [rsi+0x4C], r10d
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.RegexInterpreter
        cmp      qword ptr [rsi], rcx
        jne      G_M29863_IG90
-       mov      r8, rsi
-       mov      rcx, gword ptr [r8+0x30]
+       mov      r11, rsi
+       mov      rcx, gword ptr [r11+0x30]
        test     byte  ptr [rcx+0x40], 64
        je       SHORT G_M29863_IG44
        jmp      G_M29863_IG85
-						;; size=45 bbWeight=0.16 PerfScore 2.30
+						;; size=45 bbWeight=0.16 PerfScore 2.33
 G_M29863_IG43:
        mov      r8, gword ptr [rax+0x10]
        mov      r8d, dword ptr [r8+0x08]
@@ -1444,28 +1446,28 @@ G_M29863_IG43:
        mov      dword ptr [rax+0x58], r8d
        inc      ecx
        mov      dword ptr [rax+0x4C], ecx
-       mov      r8, rax
+       mov      r11, rax
        mov      eax, dword ptr [rbp-0x48]
-						;; size=47 bbWeight=5.63 PerfScore 98.60
+						;; size=47 bbWeight=5.69 PerfScore 99.55
 G_M29863_IG44:
-       mov      rcx, gword ptr [r8+0x70]
+       mov      rcx, gword ptr [r11+0x70]
        mov      rcx, gword ptr [rcx+0x08]
        mov      bword ptr [rbp-0x58], r12
        mov      dword ptr [rbp-0x50], eax
        lea      rdx, [rbp-0x58]
-       mov      r9d, dword ptr [r8+0x48]
-       mov      gword ptr [rbp-0xA0], r8
-       add      r8, 76
+       mov      r9d, dword ptr [r11+0x48]
+       mov      gword ptr [rbp-0xA0], r11
+       lea      r8, bword ptr [r11+0x4C]
        cmp      dword ptr [rcx], ecx
        call     [<unknown method>]
        test     eax, eax
        je       G_M29863_IG50
-						;; size=50 bbWeight=5.79 PerfScore 98.49
+						;; size=50 bbWeight=5.85 PerfScore 100.90
 G_M29863_IG45:
        mov      rax, gword ptr [rbp-0xA0]
        cmp      byte  ptr [rax+0x68], 0
        jne      G_M29863_IG83
-						;; size=17 bbWeight=5.78 PerfScore 28.92
+						;; size=17 bbWeight=5.84 PerfScore 29.20
 G_M29863_IG46:
        mov      bword ptr [rbp-0x58], r12
        mov      r8d, dword ptr [rbp-0x48]
@@ -1476,7 +1478,7 @@ G_M29863_IG46:
        call     [<unknown method>]
        test     eax, eax
        jne      G_M29863_IG50
-						;; size=40 bbWeight=5.78 PerfScore 52.05
+						;; size=40 bbWeight=5.84 PerfScore 52.55
 G_M29863_IG47:
        mov      rax, gword ptr [rbp-0xA0]
        mov      ecx, dword ptr [rax+0x4C]
@@ -1484,7 +1486,7 @@ G_M29863_IG47:
        cmp      ecx, edx
        je       G_M29863_IG50
        jmp      G_M29863_IG43
-						;; size=26 bbWeight=5.63 PerfScore 40.85
+						;; size=26 bbWeight=5.69 PerfScore 41.24
 G_M29863_IG48:
        mov      rsi, gword ptr [rax+0x30]
        mov      rdx, gword ptr [rsi+0x18]
@@ -1528,7 +1530,7 @@ G_M29863_IG50:
        mov      dword ptr [rbp-0x60], eax
        test     eax, eax
        jle      G_M29863_IG63
-						;; size=37 bbWeight=0.16 PerfScore 1.99
+						;; size=37 bbWeight=0.16 PerfScore 2.01
 G_M29863_IG51:
        test     r14b, r14b
        je       G_M29863_IG62
@@ -1556,7 +1558,7 @@ G_M29863_IG52:
        mov      dword ptr [rcx+0x10], edx
        cmp      edi, 2
        je       G_M29863_IG91
-						;; size=90 bbWeight=0.15 PerfScore 4.84
+						;; size=90 bbWeight=0.15 PerfScore 4.89
 G_M29863_IG53:
        mov      rax, rcx
 						;; size=3 bbWeight=0.15 PerfScore 0.04
@@ -1564,7 +1566,7 @@ G_M29863_IG54:
        mov      gword ptr [rbp-0x90], rax
        cmp      dword ptr [rax+0x30], 0
        je       G_M29863_IG97
-						;; size=17 bbWeight=0.16 PerfScore 0.79
+						;; size=17 bbWeight=0.16 PerfScore 0.80
 G_M29863_IG55:
        test     r14b, r14b
        je       G_M29863_IG92
@@ -1579,7 +1581,7 @@ G_M29863_IG56:
        mov      r10d, dword ptr [rcx+0x08]
        cmp      dword ptr [r8+0x08], r10d
        jbe      G_M29863_IG64
-						;; size=44 bbWeight=0.15 PerfScore 2.20
+						;; size=44 bbWeight=0.15 PerfScore 2.22
 G_M29863_IG57:
        cmp      r10d, dword ptr [r8+0x08]
        jae      G_M29863_IG96
@@ -1587,7 +1589,7 @@ G_M29863_IG57:
        mov      dword ptr [r8+4*r9+0x10], edx
        lea      edx, [r10+0x01]
        mov      dword ptr [rcx+0x08], edx
-						;; size=25 bbWeight=0.14 PerfScore 0.97
+						;; size=25 bbWeight=0.15 PerfScore 0.98
 G_M29863_IG58:
        lea      rcx, bword ptr [rbx+0x18]
        mov      rax, gword ptr [rbp-0x90]
@@ -1597,7 +1599,7 @@ G_M29863_IG58:
        mov      r10d, dword ptr [rcx+0x08]
        cmp      dword ptr [r8+0x08], r10d
        jbe      G_M29863_IG65
-						;; size=34 bbWeight=0.15 PerfScore 2.16
+						;; size=34 bbWeight=0.15 PerfScore 2.18
 G_M29863_IG59:
        cmp      r10d, dword ptr [r8+0x08]
        jae      G_M29863_IG96
@@ -1605,7 +1607,7 @@ G_M29863_IG59:
        mov      dword ptr [r8+4*r9+0x10], edx
        lea      edx, [r10+0x01]
        mov      dword ptr [rcx+0x08], edx
-						;; size=25 bbWeight=0.14 PerfScore 0.97
+						;; size=25 bbWeight=0.15 PerfScore 0.98
 G_M29863_IG60:
        mov      rax, gword ptr [rbp-0x90]
        mov      ecx, dword ptr [rax+0x10]
@@ -1617,7 +1619,7 @@ G_M29863_IG60:
        mov      dword ptr [rcx], r8d
        test     r8d, r8d
        je       G_M29863_IG97
-						;; size=38 bbWeight=0.15 PerfScore 1.79
+						;; size=38 bbWeight=0.15 PerfScore 1.81
 G_M29863_IG61:
        mov      r10d, dword ptr [rsi+0x4C]
        mov      r8d, r10d
@@ -1625,7 +1627,7 @@ G_M29863_IG61:
        cmp      dword ptr [rax+0x14], 0
        jne      G_M29863_IG36
        jmp      G_M29863_IG94
-						;; size=25 bbWeight=0.15 PerfScore 1.27
+						;; size=25 bbWeight=0.15 PerfScore 1.28
 G_M29863_IG62:
        mov      gword ptr [rbp-0x98], rcx
        lea      rcx, bword ptr [rcx+0x08]
@@ -1642,7 +1644,7 @@ G_M29863_IG63:
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      rax, gword ptr [rcx]
        jmp      G_M29863_IG54
-						;; size=24 bbWeight=0.01 PerfScore 0.05
+						;; size=24 bbWeight=0.01 PerfScore 0.06
 G_M29863_IG64:
        call     [<unknown method>]
        jmp      G_M29863_IG58
@@ -1653,7 +1655,7 @@ G_M29863_IG65:
 						;; size=11 bbWeight=0.00 PerfScore 0.02
 G_M29863_IG66:
        xor      rcx, rcx
-       mov      gword ptr [r10+0x18], rcx
+       mov      gword ptr [rax+0x18], rcx
        jmp      G_M29863_IG12
 						;; size=11 bbWeight=0 PerfScore 0.00
 G_M29863_IG67:
@@ -1798,10 +1800,10 @@ G_M29863_IG77:
        jmp      G_M29863_IG06
 						;; size=28 bbWeight=0 PerfScore 0.00
 G_M29863_IG78:
-       xor      rcx, rcx
-       mov      gword ptr [r10+0x18], rcx
+       xor      r10, r10
+       mov      gword ptr [rcx+0x18], r10
        jmp      G_M29863_IG41
-						;; size=11 bbWeight=0 PerfScore 0.00
+						;; size=12 bbWeight=0 PerfScore 0.00
 G_M29863_IG79:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
@@ -1877,14 +1879,14 @@ G_M29863_IG84:
        jmp      G_M29863_IG46
 						;; size=8 bbWeight=0 PerfScore 0.00
 G_M29863_IG85:
-       mov      rcx, gword ptr [r8+0x70]
+       mov      rcx, gword ptr [r11+0x70]
        mov      rcx, gword ptr [rcx+0x08]
        mov      bword ptr [rbp-0x58], r12
        mov      dword ptr [rbp-0x50], eax
        lea      rdx, [rbp-0x58]
-       mov      r9d, dword ptr [r8+0x48]
-       mov      gword ptr [rbp-0xA0], r8
-       add      r8, 76
+       mov      r9d, dword ptr [r11+0x48]
+       mov      gword ptr [rbp-0xA0], r11
+       lea      r8, bword ptr [r11+0x4C]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionRightToLeft(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this]
        test     eax, eax
@@ -1935,7 +1937,7 @@ G_M29863_IG89:
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [rdx+0x58], ecx
        dec      dword ptr [rdx+0x4C]
-       mov      r8, rdx
+       mov      r11, rdx
        mov      eax, dword ptr [rbp-0x48]
        jmp      G_M29863_IG85
 						;; size=115 bbWeight=0 PerfScore 0.00
@@ -2009,7 +2011,7 @@ G_M29863_IG97:
        mov      rdx, rsi
        call     CORINFO_HELP_ASSIGN_REF
        nop      
-						;; size=23 bbWeight=1 PerfScore 4.25
+						;; size=23 bbWeight=1.00 PerfScore 4.25
 G_M29863_IG98:
        add      rsp, 168
        pop      rbx
@@ -2021,7 +2023,7 @@ G_M29863_IG98:
        pop      r15
        pop      rbp
        ret      
-						;; size=20 bbWeight=1 PerfScore 5.25
+						;; size=20 bbWeight=1.00 PerfScore 5.25
 G_M29863_IG99:
        push     rbp
        push     r15
@@ -2059,6 +2061,6 @@ G_M29863_IG101:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 3473, prolog size 68, PerfScore 30695.77, instruction count 856, allocated bytes for code 3473 (MethodHash=7f4f8b58) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]],int,ubyte):this (Tier1)
+; Total bytes of code 3471, prolog size 68, PerfScore 30990.10, instruction count 856, allocated bytes for code 3471 (MethodHash=7f4f8b58) for method System.Text.RegularExpressions.Regex:RunAllMatchesWithCallback[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]](System.String,System.ReadOnlySpan`1[ushort],int,byref,System.Text.RegularExpressions.MatchCallback`1[System.ValueTuple`6[System.__Canon,System.__Canon,System.Text.StructListBuilder`1[int],System.ReadOnlyMemory`1[ushort],int,int]],int,ubyte):this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsNotMatch(Options: None)``

Hot functions:

- (68.66%) ``RegexInterpreter.TryMatchAtCurrentPosition`` (Tier-1)
  - **Has diffs**
- (12.20%) ``RegexFindOptimizations.TryFindNextStartingPositionLeftToRight`` (Tier-1)
  - No diffs
- (9.71%) ``Regex.RunSingleMatch`` (Tier-1)
  - **Has diffs**
- (5.42%) ``CastHelpers.LdelemaRef`` (Tier-1)
  - No diffs

<details>

<summary>Diffs</summary>

### ``[System.Text.RegularExpressions]RegexInterpreter.TryMatchAtCurrentPosition(value class System.ReadOnlySpan`1<wchar>)``

```diff
 ; optimized using Dynamic PGO
 ; rsp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 550656
+; with Dynamic PGO: fgCalledCount is 529664
 ; 28 inlinees with PGO data; 164 single block inlinees; 7 inlinees without PGO data
 ; Final local variable assignments
 ;
-;  V00 this         [V00,T00] (490,134.53)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexInterpreter>
-;  V01 arg1         [V01,T18] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
-;  V02 loc0         [V02,T05] (  9, 16.67)     int  ->  rbp        
-;  V03 loc1         [V03,T01] (  7, 38.77)     int  ->  r14        
+;  V00 this         [V00,T00] (490,133.74)     ref  ->  rbx         this class-hnd single-def <System.Text.RegularExpressions.RegexInterpreter>
+;  V01 arg1         [V01,T17] (  4,  8   )   byref  ->  rdx         ld-addr-op single-def
+;  V02 loc0         [V02,T05] (  9, 16.58)     int  ->  rbp        
+;  V03 loc1         [V03,T01] (  7, 38.59)     int  ->  r14        
 ;  V04 loc2         [V04,T103] (  5,  0   )     int  ->  rdx        
 ;  V05 loc3         [V05,T235] (  3,  0   )     int  ->  r12        
 ;  V06 loc4         [V06,T108] (  4,  0   )     int  ->  rdx        
@@ -5331,21 +5331,21 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V19 loc17        [V19,T363] (  2,  0   )  ushort  ->  r14        
 ;  V20 loc18        [V20,T116] (  4,  0   )     int  ->  registers  
 ;  V21 loc19        [V21,T364] (  2,  0   )  ushort  ->  r14        
-;  V22 loc20        [V22,T27] (  6,  7.92)     int  ->  registers  
-;  V23 loc21        [V23,T66] (  4,  4.95)     int  ->  rdx        
-;  V24 loc22        [V24,T93] (  3,  1.24)     ref  ->  r12         class-hnd exact <System.String>
-;  V25 loc23        [V25,T83] (  3,  2.73)   byref  ->  r13        
+;  V22 loc20        [V22,T26] (  6,  7.88)     int  ->  registers  
+;  V23 loc21        [V23,T60] (  4,  4.96)     int  ->  rdx        
+;  V24 loc22        [V24,T92] (  3,  1.24)     ref  ->  r12         class-hnd exact <System.String>
+;  V25 loc23        [V25,T83] (  3,  2.70)   byref  ->  r13        
 ;  V26 loc24        [V26,T106] (  5,  0   )     int  ->  r15        
 ;  V27 loc25        [V27,T365] (  2,  0   )  ushort  ->  rbp        
 ;  V28 loc26        [V28,T98] (  6,  0   )     int  ->  r14        
 ;  V29 loc27        [V29,T96] ( 10,  0   )     int  ->  r15        
 ;  V30 loc28        [V30,T238] (  3,  0   )  ushort  ->  rbp        
 ;  V31 loc29        [V31,T97] (  8,  0   )     int  ->  r14        
-;  V32 loc30        [V32,T60] (  5,  5.03)     int  ->  r12        
-;  V33 loc31        [V33,T61] (  4,  5.03)     int  ->  rdx        
-;  V34 loc32        [V34,T92] (  3,  1.26)     ref  ->  r14         class-hnd exact <System.String>
-;  V35 loc33        [V35,T82] (  3,  2.76)   byref  ->  r13        
-;  V36 loc34        [V36,T17] (  6, 10.05)     int  ->  rbp        
+;  V32 loc30        [V32,T62] (  5,  4.94)     int  ->  r12        
+;  V33 loc31        [V33,T63] (  4,  4.94)     int  ->  rdx        
+;  V34 loc32        [V34,T93] (  3,  1.24)     ref  ->  r14         class-hnd exact <System.String>
+;  V35 loc33        [V35,T82] (  3,  2.71)   byref  ->  r13        
+;  V36 loc34        [V36,T20] (  6,  9.84)     int  ->  rbp        
 ;  V37 loc35        [V37,T239] (  3,  0   )     int  ->  rdx        
 ;  V38 loc36        [V38,T240] (  3,  0   )     int  ->   r8        
 ;* V39 loc37        [V39    ] (  0,  0   )     int  ->  zero-ref   
@@ -5379,35 +5379,35 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;* V67 tmp19        [V67    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;* V68 tmp20        [V68    ] (  0,  0   )     int  ->  zero-ref    "impAppendStmt"
 ;  V69 tmp21        [V69,T247] (  3,  0   )     int  ->  r15         "impAppendStmt"
-;  V70 tmp22        [V70,T30] (  3,  7.54)     int  ->  r12         "impAppendStmt"
+;  V70 tmp22        [V70,T34] (  3,  7.41)     int  ->  r12         "impAppendStmt"
 ;  V71 tmp23        [V71,T366] (  2,  0   )     int  ->   r8         "impAppendStmt"
 ;  V72 tmp24        [V72,T248] (  3,  0   )     int  ->  r15         "impAppendStmt"
 ;  V73 tmp25        [V73,T367] (  2,  0   )     int  ->   r8         "impAppendStmt"
 ;* V74 tmp26        [V74    ] (  0,  0   )  struct (16) zero-ref    "spilled call-like call argument" <System.ReadOnlySpan`1[ushort]>
 ;  V75 tmp27        [V75,T249] (  3,  0   )     int  ->  r15         "impAppendStmt"
 ;  V76 tmp28        [V76,T368] (  2,  0   )     int  ->   r8         "impAppendStmt"
-;  V77 tmp29        [V77,T06] (  6, 16.35)     int  ->  r14         "impSpillLclRefs"
+;  V77 tmp29        [V77,T06] (  6, 16.20)     int  ->  r14         "impSpillLclRefs"
 ;  V78 tmp30        [V78,T250] (  3,  0   )     int  ->  r15         "impSpillLclRefs"
 ;  V79 tmp31        [V79,T251] (  3,  0   )     int  ->  r15         "impSpillLclRefs"
-;  V80 tmp32        [V80,T49] (  3,  6   )     int  ->  rax         "Inlining Arg"
-;  V81 tmp33        [V81,T03] (  3, 33.65)     int  ->  rcx         "Inlining Arg"
+;  V80 tmp32        [V80,T44] (  3,  6   )     int  ->  rax         "Inlining Arg"
+;  V81 tmp33        [V81,T03] (  3, 33.47)     int  ->  rcx         "Inlining Arg"
 ;* V82 tmp34        [V82    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.RegularExpressions.Match>
 ;  V83 tmp35        [V83,T369] (  2,  0   )     int  ->  rdx         "Inlining Arg"
 ;* V84 tmp36        [V84    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V85 tmp37        [V85,T21] (  5,  9.93)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
-;  V86 tmp38        [V86,T25] (  4,  7.95)     int  ->   r8         "dup spill"
-;  V87 tmp39        [V87,T73] (  2,  3.97)     int  ->  rcx         "Inlining Arg"
-;  V88 tmp40        [V88,T26] (  4,  7.95)     int  ->   r8         "dup spill"
-;  V89 tmp41        [V89,T74] (  2,  3.97)     int  ->  rcx         "Strict ordering of exceptions for Array store"
-;  V90 tmp42        [V90,T24] (  4,  8.00)     int  ->  r12         "Inlining Arg"
-;  V91 tmp43        [V91,T81] (  3,  3.00)     int  ->  r13         "Inline stloc first use temp"
-;  V92 tmp44        [V92,T50] (  3,  6.00)     int  ->  rcx         "Inlining Arg"
-;  V93 tmp45        [V93,T75] (  4,  3.94)     int  ->   r8         "Inline stloc first use temp"
-;  V94 tmp46        [V94,T56] (  3,  5.91)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
-;  V95 tmp47        [V95,T77] (  2,  3.94)     int  ->  rcx         "Inlining Arg"
-;  V96 tmp48        [V96,T76] (  4,  3.94)     int  ->  rdx         "Inline stloc first use temp"
-;  V97 tmp49        [V97,T57] (  3,  5.91)     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
-;  V98 tmp50        [V98,T78] (  2,  3.94)     int  ->  r15         "Strict ordering of exceptions for Array store"
+;  V85 tmp37        [V85,T18] (  5,  9.98)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
+;  V86 tmp38        [V86,T24] (  4,  7.98)     int  ->   r8         "dup spill"
+;  V87 tmp39        [V87,T72] (  2,  3.99)     int  ->  rcx         "Inlining Arg"
+;  V88 tmp40        [V88,T25] (  4,  7.98)     int  ->   r8         "dup spill"
+;  V89 tmp41        [V89,T73] (  2,  3.99)     int  ->  rcx         "Strict ordering of exceptions for Array store"
+;  V90 tmp42        [V90,T27] (  4,  7.87)     int  ->  r12         "Inlining Arg"
+;  V91 tmp43        [V91,T81] (  3,  2.95)     int  ->  r13         "Inline stloc first use temp"
+;  V92 tmp44        [V92,T51] (  3,  5.91)     int  ->  rcx         "Inlining Arg"
+;  V93 tmp45        [V93,T75] (  4,  3.95)     int  ->   r8         "Inline stloc first use temp"
+;  V94 tmp46        [V94,T46] (  3,  5.92)     ref  ->  rdx         class-hnd "impAppendStmt" <<unknown class>>
+;  V95 tmp47        [V95,T77] (  2,  3.95)     int  ->  rcx         "Inlining Arg"
+;  V96 tmp48        [V96,T76] (  4,  3.95)     int  ->  rdx         "Inline stloc first use temp"
+;  V97 tmp49        [V97,T47] (  3,  5.92)     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
+;  V98 tmp50        [V98,T78] (  2,  3.95)     int  ->  r15         "Strict ordering of exceptions for Array store"
 ;  V99 tmp51        [V99,T118] (  4,  0   )     int  ->  rax         "Inline stloc first use temp"
 ;  V100 tmp52       [V100,T133] (  3,  0   )     ref  ->  rcx         class-hnd "impAppendStmt" <<unknown class>>
 ;  V101 tmp53       [V101,T119] (  4,  0   )     int  ->  rdx         "Inline stloc first use temp"
@@ -5432,25 +5432,25 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V120 tmp72       [V120,T375] (  2,  0   )     int  ->  rax         "Inlining Arg"
 ;  V121 tmp73       [V121,T376] (  2,  0   )     int  ->  rcx         "Inlining Arg"
 ;  V122 tmp74       [V122,T377] (  2,  0   )     int  ->  rdx         "Inlining Arg"
-;  V123 tmp75       [V123,T09] (  5, 12.41)     int  ->  r14         "Inlining Arg"
-;  V124 tmp76       [V124,T63] (  4,  4.96)     int  ->  rcx         "Inline stloc first use temp"
+;  V123 tmp75       [V123,T09] (  5, 12.27)     int  ->  r14         "Inlining Arg"
+;  V124 tmp76       [V124,T65] (  4,  4.91)     int  ->  rcx         "Inline stloc first use temp"
 ;* V125 tmp77       [V125    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V126 tmp78       [V126,T88] (  3,  2.48)     int  ->  r13        
+;  V126 tmp78       [V126,T89] (  3,  2.45)     int  ->  r13        
 ;* V127 tmp79       [V127    ] (  0,  0   )     int  ->  zero-ref   
 ;* V128 tmp80       [V128    ] (  0,  0   )     int  ->  zero-ref   
-;  V129 tmp81       [V129,T89] (  3,  2.48)     int  ->  r12        
-;  V130 tmp82       [V130,T86] (  4,  2.48)   ubyte  ->  r13         "Inline return value spill temp"
+;  V129 tmp81       [V129,T90] (  3,  2.45)     int  ->  r12        
+;  V130 tmp82       [V130,T87] (  4,  2.45)   ubyte  ->  r13         "Inline return value spill temp"
 ;* V131 tmp83       [V131    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
-;  V132 tmp84       [V132,T35] (  6,  7.45)  ushort  ->  r13         "Inlining Arg"
-;  V133 tmp85       [V133,T64] (  4,  4.96)     int  ->  rcx         "Inline stloc first use temp"
+;  V132 tmp84       [V132,T38] (  6,  7.36)  ushort  ->  r13         "Inlining Arg"
+;  V133 tmp85       [V133,T66] (  4,  4.91)     int  ->  rcx         "Inline stloc first use temp"
 ;* V134 tmp86       [V134    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V135 tmp87       [V135,T87] (  4,  2.48)   ubyte  ->  r12         "Inline return value spill temp"
+;  V135 tmp87       [V135,T88] (  4,  2.45)   ubyte  ->  r12         "Inline return value spill temp"
 ;* V136 tmp88       [V136    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline stloc first use temp" <System.ReadOnlySpan`1[ubyte]>
-;  V137 tmp89       [V137,T36] (  6,  7.45)  ushort  ->  r12         "Inlining Arg"
-;  V138 tmp90       [V138,T65] (  4,  4.96)     int  ->  rcx         "Inline stloc first use temp"
+;  V137 tmp89       [V137,T39] (  6,  7.36)  ushort  ->  r12         "Inlining Arg"
+;  V138 tmp90       [V138,T67] (  4,  4.91)     int  ->  rcx         "Inline stloc first use temp"
 ;* V139 tmp91       [V139    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ubyte]>
-;  V140 tmp92       [V140,T91] (  3,  1.97)     int  ->  rax         "Inline return value spill temp"
-;  V141 tmp93       [V141,T79] (  6,  3.93)     int  ->  r10         "Inline stloc first use temp"
+;  V140 tmp92       [V140,T91] (  3,  1.96)     int  ->  rax         "Inline return value spill temp"
+;  V141 tmp93       [V141,T79] (  6,  3.92)     int  ->  r10         "Inline stloc first use temp"
 ;* V142 tmp94       [V142    ] (  0,  0   )     int  ->  zero-ref   
 ;* V143 tmp95       [V143    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V144 tmp96       [V144    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
@@ -5462,17 +5462,17 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V150 tmp102      [V150,T127] (  4,  0   )     int  ->  rdx         "Inline stloc first use temp"
 ;  V151 tmp103      [V151,T252] (  3,  0   )     int  ->  rcx         "Inline stloc first use temp"
 ;  V152 tmp104      [V152,T253] (  3,  0   )     int  ->  rdx         "Inline stloc first use temp"
-;  V153 tmp105      [V153,T90] (  3,  2.47)     int  ->  rax         "Inline return value spill temp"
-;  V154 tmp106      [V154,T54] (  6,  5.96)     int  ->  rax         "Inline stloc first use temp"
+;  V153 tmp105      [V153,T84] (  3,  2.48)     int  ->  rax         "Inline return value spill temp"
+;  V154 tmp106      [V154,T58] (  6,  5.85)     int  ->  rax         "Inline stloc first use temp"
 ;* V155 tmp107      [V155    ] (  0,  0   )     int  ->  zero-ref   
 ;* V156 tmp108      [V156    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V157 tmp109      [V157    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V158 tmp110      [V158,T254] (  3,  0   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V159 tmp111      [V159,T37] (  5,  7.44)     ref  ->  rax         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V160 tmp112      [V160,T23] (  6,  8.93)  ushort  ->  rcx         "Inlining Arg"
-;  V161 tmp113      [V161,T55] (  4,  5.96)     int  ->  rdx         "Inline stloc first use temp"
-;  V162 tmp114      [V162,T70] (  3,  4.47)     int  ->  rax         "Inline stloc first use temp"
-;  V163 tmp115      [V163,T71] (  3,  4.47)     int  ->  rdx         "Inline stloc first use temp"
+;  V159 tmp111      [V159,T41] (  5,  7.31)     ref  ->  rax         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V160 tmp112      [V160,T23] (  6,  8.77)  ushort  ->  rcx         "Inlining Arg"
+;  V161 tmp113      [V161,T59] (  4,  5.85)     int  ->  rdx         "Inline stloc first use temp"
+;  V162 tmp114      [V162,T70] (  3,  4.39)     int  ->  rax         "Inline stloc first use temp"
+;  V163 tmp115      [V163,T71] (  3,  4.39)     int  ->  rdx         "Inline stloc first use temp"
 ;  V164 tmp116      [V164,T255] (  3,  0   )     int  ->  r15         "Inline return value spill temp"
 ;  V165 tmp117      [V165,T256] (  3,  0   )     int  ->  rax         "Inlining Arg"
 ;  V166 tmp118      [V166,T257] (  3,  0   )     int  ->  rcx         "Inline return value spill temp"
@@ -5492,24 +5492,24 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;* V180 tmp132      [V180    ] (  0,  0   )  ushort  ->  zero-ref    "Inlining Arg"
 ;* V181 tmp133      [V181    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V182 tmp134      [V182,T261] (  3,  0   )     int  ->  rcx         "Inline return value spill temp"
-;  V183 tmp135      [V183,T84] (  4,  2.51)     int  ->  r14         "Inline return value spill temp"
-;  V184 tmp136      [V184,T85] (  3,  2.51)     int  ->  r12         "Inline return value spill temp"
-;  V185 tmp137      [V185,T42] (  6,  6.01)     int  ->  rax         "Inline stloc first use temp"
+;  V183 tmp135      [V183,T85] (  4,  2.47)     int  ->  r14         "Inline return value spill temp"
+;  V184 tmp136      [V184,T86] (  3,  2.47)     int  ->  r12         "Inline return value spill temp"
+;  V185 tmp137      [V185,T54] (  6,  5.88)     int  ->  rax         "Inline stloc first use temp"
 ;* V186 tmp138      [V186    ] (  0,  0   )     int  ->  zero-ref   
 ;* V187 tmp139      [V187    ] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
 ;* V188 tmp140      [V188    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V189 tmp141      [V189,T262] (  3,  0   )   ubyte  ->  rax         "Inline return value spill temp"
-;  V190 tmp142      [V190,T33] (  5,  7.51)     ref  ->  rdx         class-hnd "Inline stloc first use temp" <<unknown class>>
-;  V191 tmp143      [V191,T22] (  6,  9.01)  ushort  ->  rcx         "Inlining Arg"
-;  V192 tmp144      [V192,T43] (  4,  6.01)     int  ->   r8         "Inline stloc first use temp"
-;  V193 tmp145      [V193,T68] (  3,  4.50)     int  ->  rdx         "Inline stloc first use temp"
-;  V194 tmp146      [V194,T69] (  3,  4.50)     int  ->   r8         "Inline stloc first use temp"
-;  V195 tmp147      [V195,T94] (  2,  0.98)     int  ->  rcx         "impAppendStmt"
+;  V190 tmp142      [V190,T40] (  5,  7.35)     ref  ->  rdx         class-hnd "Inline stloc first use temp" <<unknown class>>
+;  V191 tmp143      [V191,T22] (  6,  8.82)  ushort  ->  rcx         "Inlining Arg"
+;  V192 tmp144      [V192,T55] (  4,  5.88)     int  ->   r8         "Inline stloc first use temp"
+;  V193 tmp145      [V193,T68] (  3,  4.41)     int  ->  rdx         "Inline stloc first use temp"
+;  V194 tmp146      [V194,T69] (  3,  4.41)     int  ->   r8         "Inline stloc first use temp"
+;  V195 tmp147      [V195,T94] (  2,  0.99)     int  ->  rcx         "impAppendStmt"
 ;* V196 tmp148      [V196    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V197 tmp149      [V197    ] (  0,  0   )     int  ->  zero-ref   
 ;* V198 tmp150      [V198    ] (  0,  0   )     ref  ->  zero-ref   
 ;* V199 tmp151      [V199    ] (  0,  0   )     int  ->  zero-ref   
-;  V200 tmp152      [V200,T95] (  3,  0.49)     int  ->  rdx        
+;  V200 tmp152      [V200,T95] (  3,  0.50)     int  ->  rdx        
 ;  V201 tmp153      [V201,T263] (  3,  0   )     int  ->  rcx         "Inline return value spill temp"
 ;  V202 tmp154      [V202,T264] (  3,  0   )     int  ->  rcx         "Inline return value spill temp"
 ;  V203 tmp155      [V203,T129] (  4,  0   )     int  ->  rdx         "Inline return value spill temp"
@@ -5525,12 +5525,12 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V213 tmp165      [V213,T268] (  3,  0   )     int  ->  rcx         "Inline stloc first use temp"
 ;  V214 tmp166      [V214,T269] (  3,  0   )     int  ->  rdx         "Inline stloc first use temp"
 ;  V215 tmp167      [V215,T270] (  3,  0   )     int  ->   r8         "Inline return value spill temp"
-;  V216 tmp168      [V216,T20] (  7,  9.93)     int  ->  r14         "Inline stloc first use temp"
-;  V217 tmp169      [V217,T72] (  3,  3.97)     int  ->  rcx         "Inline stloc first use temp"
-;  V218 tmp170      [V218,T13] (  3, 11.92)     int  ->  rcx         "Inlining Arg"
-;  V219 tmp171      [V219,T53] (  3,  5.96)     int  ->  r15         "Inline stloc first use temp"
-;  V220 tmp172      [V220,T34] ( 24,  7.46)   byref  ->  rsi         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
-;  V221 tmp173      [V221,T19] ( 31,  9.94)     int  ->  rdi         "field V01._length (fldOffset=0x8)" P-INDEP
+;  V216 tmp168      [V216,T19] (  7,  9.90)     int  ->  r14         "Inline stloc first use temp"
+;  V217 tmp169      [V217,T74] (  3,  3.96)     int  ->  rcx         "Inline stloc first use temp"
+;  V218 tmp170      [V218,T13] (  3, 11.88)     int  ->  rcx         "Inlining Arg"
+;  V219 tmp171      [V219,T45] (  3,  5.94)     int  ->  r15         "Inline stloc first use temp"
+;  V220 tmp172      [V220,T37] ( 24,  7.36)   byref  ->  rsi         single-def "field V01._reference (fldOffset=0x0)" P-INDEP
+;  V221 tmp173      [V221,T21] ( 31,  9.82)     int  ->  rdi         "field V01._length (fldOffset=0x8)" P-INDEP
 ;* V222 tmp174      [V222    ] (  0,  0   )   byref  ->  zero-ref    "field V74._reference (fldOffset=0x0)" P-INDEP
 ;* V223 tmp175      [V223    ] (  0,  0   )     int  ->  zero-ref    "field V74._length (fldOffset=0x8)" P-INDEP
 ;* V224 tmp176      [V224    ] (  0,  0   )   byref  ->  zero-ref    "field V125._reference (fldOffset=0x0)" P-INDEP
@@ -5558,9 +5558,9 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;* V246 tmp198      [V246    ] (  0,  0   )   byref  ->  zero-ref    "field V188._reference (fldOffset=0x0)" P-INDEP
 ;* V247 tmp199      [V247    ] (  0,  0   )     int  ->  zero-ref    "field V188._length (fldOffset=0x8)" P-INDEP
 ;* V248 tmp200      [V248    ] (  0,  0   )  struct (16) zero-ref    "Promoted implicit byref" <System.ReadOnlySpan`1[ushort]>
-;  V249 tmp201      [V249,T44] (  3,  6   )     ref  ->  rax         single-def "arr expr"
-;  V250 tmp202      [V250,T02] (  3, 33.65)     ref  ->  rcx         "arr expr"
-;  V251 tmp203      [V251,T04] (  3, 33.65)     int  ->  rdx         "index expr"
+;  V249 tmp201      [V249,T42] (  3,  6   )     ref  ->  rax         single-def "arr expr"
+;  V250 tmp202      [V250,T02] (  3, 33.47)     ref  ->  rcx         "arr expr"
+;  V251 tmp203      [V251,T04] (  3, 33.47)     int  ->  rdx         "index expr"
 ;  V252 tmp204      [V252,T146] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V253 tmp205      [V253,T271] (  3,  0   )     int  ->   r8         "index expr"
 ;  V254 tmp206      [V254,T147] (  3,  0   )     ref  ->   r8         "arr expr"
@@ -5636,11 +5636,11 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V324 tmp276      [V324,T175] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V325 tmp277      [V325,T300] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V326 tmp278      [V326,T392] (  2,  0   )     int  ->  rdx         "argument with side effect"
-;  V327 tmp279      [V327,T45] (  3,  6.00)     ref  ->  rax         "arr expr"
-;  V328 tmp280      [V328,T51] (  3,  6.00)     int  ->  rcx         "index expr"
-;  V329 tmp281      [V329,T46] (  3,  6.00)     ref  ->  rcx         "arr expr"
-;  V330 tmp282      [V330,T52] (  3,  6.00)     int  ->  rax         "index expr"
-;  V331 tmp283      [V331,T47] (  3,  6.00)     ref  ->  rcx         "arr expr"
+;  V327 tmp279      [V327,T48] (  3,  5.91)     ref  ->  rax         "arr expr"
+;  V328 tmp280      [V328,T52] (  3,  5.91)     int  ->  rcx         "index expr"
+;  V329 tmp281      [V329,T49] (  3,  5.91)     ref  ->  rcx         "arr expr"
+;  V330 tmp282      [V330,T53] (  3,  5.91)     int  ->  rax         "index expr"
+;  V331 tmp283      [V331,T50] (  3,  5.91)     ref  ->  rcx         "arr expr"
 ;  V332 tmp284      [V332,T176] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V333 tmp285      [V333,T301] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V334 tmp286      [V334,T177] (  3,  0   )     ref  ->  rdx         "arr expr"
@@ -5667,7 +5667,7 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V355 tmp307      [V355,T311] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V356 tmp308      [V356,T188] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V357 tmp309      [V357,T312] (  3,  0   )     int  ->  rdx         "index expr"
-;  V358 tmp310      [V358,T48] (  3,  6.00)     ref  ->  rax         single-def "arr expr"
+;  V358 tmp310      [V358,T43] (  3,  6.00)     ref  ->  rax         single-def "arr expr"
 ;  V359 tmp311      [V359,T189] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V360 tmp312      [V360,T313] (  3,  0   )     int  ->  rcx         "index expr"
 ;  V361 tmp313      [V361,T393] (  2,  0   )     int  ->  rdx         "argument with side effect"
@@ -5764,15 +5764,15 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V452 tmp404      [V452,T224] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V453 tmp405      [V453,T225] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V454 tmp406      [V454,T349] (  3,  0   )     int  ->  rdx         "index expr"
-;  V455 tmp407      [V455,T58] (  3,  5.90)     ref  ->   r9         "arr expr"
-;  V456 tmp408      [V456,T59] (  3,  5.90)     int  ->  rdx         "index expr"
+;  V455 tmp407      [V455,T56] (  3,  5.87)     ref  ->   r9         "arr expr"
+;  V456 tmp408      [V456,T57] (  3,  5.87)     int  ->  rdx         "index expr"
 ;  V457 tmp409      [V457,T226] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V458 tmp410      [V458,T350] (  3,  0   )     int  ->  rax         "index expr"
-;  V459 tmp411      [V459,T28] (  3,  7.54)     ref  ->  rdx         "arr expr"
-;  V460 tmp412      [V460,T31] (  3,  7.54)     int  ->   r8         "index expr"
-;  V461 tmp413      [V461,T62] (  2,  5.03)     ref  ->  rcx         "arr expr"
-;  V462 tmp414      [V462,T32] (  3,  7.54)     int  ->  rdx         "index expr"
-;  V463 tmp415      [V463,T29] (  3,  7.54)     ref  ->  rcx         "arr expr"
+;  V459 tmp411      [V459,T32] (  3,  7.41)     ref  ->  rdx         "arr expr"
+;  V460 tmp412      [V460,T35] (  3,  7.41)     int  ->   r8         "index expr"
+;  V461 tmp413      [V461,T64] (  2,  4.94)     ref  ->  rcx         "arr expr"
+;  V462 tmp414      [V462,T36] (  3,  7.41)     int  ->  rdx         "index expr"
+;  V463 tmp415      [V463,T33] (  3,  7.41)     ref  ->  rcx         "arr expr"
 ;  V464 tmp416      [V464,T227] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V465 tmp417      [V465,T351] (  3,  0   )     int  ->  rax         "index expr"
 ;  V466 tmp418      [V466,T228] (  3,  0   )     ref  ->  rdx         "arr expr"
@@ -5781,11 +5781,11 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V469 tmp421      [V469,T353] (  3,  0   )     int  ->  rax         "index expr"
 ;  V470 tmp422      [V470,T230] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V471 tmp423      [V471,T354] (  3,  0   )     int  ->  rcx         "index expr"
-;  V472 tmp424      [V472,T38] (  3,  7.42)     ref  ->  rdx         "arr expr"
-;  V473 tmp425      [V473,T40] (  3,  7.42)     int  ->   r8         "index expr"
-;  V474 tmp426      [V474,T67] (  2,  4.95)     ref  ->  rcx         "arr expr"
-;  V475 tmp427      [V475,T41] (  3,  7.42)     int  ->  rdx         "index expr"
-;  V476 tmp428      [V476,T39] (  3,  7.42)     ref  ->  rcx         "arr expr"
+;  V472 tmp424      [V472,T28] (  3,  7.43)     ref  ->  rdx         "arr expr"
+;  V473 tmp425      [V473,T30] (  3,  7.43)     int  ->   r8         "index expr"
+;  V474 tmp426      [V474,T61] (  2,  4.96)     ref  ->  rcx         "arr expr"
+;  V475 tmp427      [V475,T31] (  3,  7.43)     int  ->  rdx         "index expr"
+;  V476 tmp428      [V476,T29] (  3,  7.43)     ref  ->  rcx         "arr expr"
 ;  V477 tmp429      [V477,T231] (  3,  0   )     ref  ->  rcx         "arr expr"
 ;  V478 tmp430      [V478,T355] (  3,  0   )     int  ->  rax         "index expr"
 ;  V479 tmp431      [V479,T232] (  3,  0   )     ref  ->  rdx         "arr expr"
@@ -5794,15 +5794,15 @@ RWD324 	dd	G_M19968_IG41 - G_M19968_IG02
 ;  V482 tmp434      [V482,T357] (  3,  0   )     int  ->  rax         "index expr"
 ;  V483 tmp435      [V483,T234] (  3,  0   )     ref  ->  rdx         "arr expr"
 ;  V484 tmp436      [V484,T358] (  3,  0   )     int  ->  rcx         "index expr"
-;  V485 tmp437      [V485,T11] (  3, 11.92)     ref  ->  rcx         "arr expr"
-;  V486 tmp438      [V486,T14] (  3, 11.92)     int  ->  rax         "index expr"
-;  V487 tmp439      [V487,T12] (  3, 11.92)     ref  ->  rax         "arr expr"
-;  V488 cse0        [V488,T15] ( 41, 11.45)     ref  ->  registers   multi-def "CSE #02: moderate"
-;  V489 cse1        [V489,T80] ( 24,  3.00)     int  ->  rcx         multi-def "CSE #09: conservative"
-;  V490 cse2        [V490,T16] ( 41, 11.45)     int  ->  r11         multi-def "CSE #05: moderate"
-;  V491 cse3        [V491,T08] ( 43, 13.94)     ref  ->   r9         multi-def "CSE #01: aggressive"
-;  V492 cse4        [V492,T07] ( 45, 15.40)     int  ->  r15         multi-def "CSE #03: aggressive"
-;  V493 rat0        [V493,T10] (  3, 11.97)     int  ->  r14         "ReplaceWithLclVar is creating a new local variable"
+;  V485 tmp437      [V485,T11] (  3, 11.88)     ref  ->  rcx         "arr expr"
+;  V486 tmp438      [V486,T14] (  3, 11.88)     int  ->  rax         "index expr"
+;  V487 tmp439      [V487,T12] (  3, 11.88)     ref  ->  rax         "arr expr"
+;  V488 cse0        [V488,T15] ( 41, 11.35)     ref  ->  registers   multi-def "CSE #02: moderate"
+;  V489 cse1        [V489,T80] ( 24,  2.95)     int  ->  rcx         multi-def "CSE #09: conservative"
+;  V490 cse2        [V490,T16] ( 41, 11.35)     int  ->  r11         multi-def "CSE #05: moderate"
+;  V491 cse3        [V491,T08] ( 43, 13.82)     ref  ->   r9         multi-def "CSE #01: aggressive"
+;  V492 cse4        [V492,T07] ( 45, 15.32)     int  ->  r15         multi-def "CSE #03: aggressive"
+;  V493 rat0        [V493,T10] (  3, 11.89)     int  ->  r14         "ReplaceWithLclVar is creating a new local variable"
 ;  V494 rat1        [V494,T359] (  3,  0   )     int  ->  r15         "ReplaceWithLclVar is creating a new local variable"
 ;
 ; Lcl frame size = 56
@@ -5827,7 +5827,7 @@ G_M19968_IG02:
        mov      rax, gword ptr [rbx+0x70]
        mov      rax, gword ptr [rax+0x10]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M19968_IG189
+       jbe      G_M19968_IG190
        mov      eax, dword ptr [rax+0x10]
        mov      ecx, eax
        and      ecx, -65
@@ -5842,11 +5842,11 @@ G_M19968_IG02:
 G_M19968_IG03:
        xor      ebp, ebp
        jmp      SHORT G_M19968_IG06
-						;; size=4 bbWeight=0.50 PerfScore 1.11
+						;; size=4 bbWeight=0.49 PerfScore 1.11
 G_M19968_IG04:
        mov      ebp, 1
        jmp      SHORT G_M19968_IG06
-						;; size=7 bbWeight=0.74 PerfScore 1.66
+						;; size=7 bbWeight=0.73 PerfScore 1.65
 G_M19968_IG05:
        mov      ebp, 2
 						;; size=5 bbWeight=1.24 PerfScore 0.31
@@ -5858,7 +5858,7 @@ G_M19968_IG06:
        mov      rcx, gword ptr [rcx+0x10]
        mov      edx, dword ptr [rbx+0x88]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, ecx
        and      edx, -65
@@ -5866,17 +5866,17 @@ G_M19968_IG06:
        test     cl, 64
        setne    cl
        mov      byte  ptr [rbx+0x69], cl
-						;; size=61 bbWeight=5.61 PerfScore 112.15
+						;; size=61 bbWeight=5.58 PerfScore 111.57
 G_M19968_IG07:
        mov      ebp, -1
-						;; size=5 bbWeight=5.61 PerfScore 1.40
+						;; size=5 bbWeight=5.58 PerfScore 1.39
 G_M19968_IG08:
        mov      r14d, dword ptr [rbx+0x84]
        cmp      r14d, 164
-       jg       G_M19968_IG175
+       jg       G_M19968_IG176
        cmp      r14d, 46
        ja       SHORT G_M19968_IG10
-						;; size=26 bbWeight=9.69 PerfScore 43.62
+						;; size=26 bbWeight=9.65 PerfScore 43.41
 G_M19968_IG09:
        mov      eax, r14d
        lea      rcx, [reloc @RWD00]
@@ -5884,7 +5884,7 @@ G_M19968_IG09:
        lea      rdx, G_M19968_IG02
        add      rcx, rdx
        jmp      rcx
-						;; size=25 bbWeight=7.70 PerfScore 46.18
+						;; size=25 bbWeight=7.67 PerfScore 46.00
 G_M19968_IG10:
        add      r14d, -131
        cmp      r14d, 33
@@ -5895,30 +5895,30 @@ G_M19968_IG10:
        lea      rdx, G_M19968_IG02
        add      rax, rdx
        jmp      rax
-						;; size=38 bbWeight=2.00 PerfScore 14.97
+						;; size=38 bbWeight=1.98 PerfScore 14.86
 G_M19968_IG11:
        inc      dword ptr [rbx+0x54]
 						;; size=3 bbWeight=1.00 PerfScore 2.99
 G_M19968_IG12:
        cmp      byte  ptr [rbx+0x68], 0
-       jne      G_M19968_IG184
-						;; size=10 bbWeight=1.99 PerfScore 7.95
+       jne      G_M19968_IG185
+						;; size=10 bbWeight=1.98 PerfScore 7.92
 G_M19968_IG13:
        mov      rcx, gword ptr [rbx+0x10]
        mov      eax, dword ptr [rbx+0x50]
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rcx+4*rax+0x10]
        inc      dword ptr [rbx+0x50]
        mov      ecx, 128
        test     r14d, r14d
-       jl       G_M19968_IG186
-						;; size=38 bbWeight=1.99 PerfScore 28.80
+       jl       G_M19968_IG187
+						;; size=38 bbWeight=1.98 PerfScore 28.70
 G_M19968_IG14:
        mov      rax, gword ptr [rbx+0x70]
        mov      rax, gword ptr [rax+0x10]
        cmp      r14d, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, r14d
        or       ecx, dword ptr [rax+4*rdx+0x10]
        mov      eax, ecx
@@ -5930,20 +5930,20 @@ G_M19968_IG14:
        mov      r15d, dword ptr [rbx+0x5C]
        shl      r15d, 2
        cmp      dword ptr [rbx+0x54], r15d
-       jl       G_M19968_IG187
-						;; size=63 bbWeight=1.99 PerfScore 42.71
+       jl       G_M19968_IG188
+						;; size=63 bbWeight=1.98 PerfScore 42.55
 G_M19968_IG15:
        cmp      dword ptr [rbx+0x50], r15d
-       jl       G_M19968_IG188
-						;; size=10 bbWeight=1.99 PerfScore 7.95
+       jl       G_M19968_IG189
+						;; size=10 bbWeight=1.98 PerfScore 7.92
 G_M19968_IG16:
        mov      dword ptr [rbx+0x88], r14d
-						;; size=7 bbWeight=1.99 PerfScore 1.99
+						;; size=7 bbWeight=1.98 PerfScore 1.98
 G_M19968_IG17:
        test     ebp, ebp
        jl       G_M19968_IG08
        jmp      G_M19968_IG06
-						;; size=13 bbWeight=2.99 PerfScore 9.71
+						;; size=13 bbWeight=2.96 PerfScore 9.63
 G_M19968_IG18:
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
@@ -5951,7 +5951,7 @@ G_M19968_IG18:
        mov      rax, gword ptr [rbx+0x10]
        dec      ecx
        cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rax+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], ecx
        mov      r9, gword ptr [rbx+0x70]
@@ -5960,23 +5960,23 @@ G_M19968_IG18:
        lea      eax, [r15+0x01]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r12d, dword ptr [rcx+4*rax+0x10]
        mov      r13d, dword ptr [rbx+0x5C]
        shl      r13d, 2
        cmp      dword ptr [rbx+0x54], r13d
-       jl       G_M19968_IG60
-						;; size=85 bbWeight=1.00 PerfScore 30.75
+       jl       G_M19968_IG61
+						;; size=85 bbWeight=0.98 PerfScore 30.27
 G_M19968_IG19:
        cmp      dword ptr [rbx+0x50], r13d
-       jl       G_M19968_IG61
-						;; size=10 bbWeight=1.00 PerfScore 4.00
+       jl       G_M19968_IG62
+						;; size=10 bbWeight=0.98 PerfScore 3.94
 G_M19968_IG20:
        mov      dword ptr [rbx+0x88], r12d
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x10]
        cmp      r12d, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      eax, r12d
        mov      ecx, dword ptr [rcx+4*rax+0x10]
        mov      eax, ecx
@@ -5986,12 +5986,12 @@ G_M19968_IG20:
        setne    cl
        mov      byte  ptr [rbx+0x69], cl
        jmp      G_M19968_IG17
-						;; size=57 bbWeight=1.00 PerfScore 17.00
+						;; size=57 bbWeight=0.98 PerfScore 16.73
 G_M19968_IG21:
        mov      rax, gword ptr [rbx+0x28]
        mov      rax, gword ptr [rax+0x50]
        cmp      dword ptr [rax+0x08], 0
-       jbe      G_M19968_IG189
+       jbe      G_M19968_IG190
        cmp      dword ptr [rax+0x10], 0
        setg     al
        movzx    rax, al
@@ -6015,7 +6015,7 @@ G_M19968_IG23:
        dec      r8d
        mov      dword ptr [rbx+0x54], r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rdx+4*r8+0x10], ecx
        mov      rcx, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
@@ -6023,98 +6023,95 @@ G_M19968_IG23:
        mov      dword ptr [rbx+0x50], edx
        mov      r15d, dword ptr [rbx+0x88]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rcx+4*rdx+0x10], r15d
        jmp      G_M19968_IG03
-						;; size=71 bbWeight=0.98 PerfScore 26.10
+						;; size=71 bbWeight=0.99 PerfScore 26.14
 G_M19968_IG24:
        mov      ecx, dword ptr [rbx+0x4C]
        mov      rdx, gword ptr [rbx+0x10]
        mov      r8d, dword ptr [rbx+0x50]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      eax, r8d
        mov      dword ptr [rdx+4*rax+0x10], ecx
        dec      r8d
        mov      r15d, dword ptr [rbx+0x88]
        mov      ecx, r15d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      eax, r8d
        mov      dword ptr [rdx+4*rax+0x10], ecx
        mov      dword ptr [rbx+0x50], r8d
        jmp      G_M19968_IG04
-						;; size=70 bbWeight=0.99 PerfScore 22.10
+						;; size=70 bbWeight=1.00 PerfScore 22.21
 G_M19968_IG25:
        mov      r14d, dword ptr [rbx+0x4C]
        lea      ecx, [r14-0x01]
        cmp      ecx, edi
-       jae      G_M19968_IG115
-						;; size=16 bbWeight=1.24 PerfScore 4.65
-G_M19968_IG26:
+       jae      G_M19968_IG116
        cmp      ecx, edi
-       jae      G_M19968_IG189
-       mov      ecx, ecx
+       jae      G_M19968_IG190
        movzx    r13, word  ptr [rsi+2*rcx]
        mov      ecx, r13d
        sar      ecx, 3
        cmp      ecx, 16
-       jae      G_M19968_IG113
+       jae      G_M19968_IG114
        cmp      ecx, 16
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      rdx, 0xD1FFAB1E      ; static handle
        movzx    rcx, byte  ptr [rcx+rdx]
        and      r13d, 7
        bt       ecx, r13d
        setb     r13b
        movzx    r13, r13b
-						;; size=69 bbWeight=1.24 PerfScore 13.65
-G_M19968_IG27:
+						;; size=83 bbWeight=1.23 PerfScore 17.79
+G_M19968_IG26:
        cmp      r14d, edi
-       jae      G_M19968_IG118
-						;; size=9 bbWeight=1.24 PerfScore 1.55
-G_M19968_IG28:
+       jae      G_M19968_IG119
        cmp      r14d, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, r14d
        movzx    r12, word  ptr [rsi+2*rcx]
        mov      ecx, r12d
        sar      ecx, 3
        cmp      ecx, 16
-       jae      G_M19968_IG116
+       jae      G_M19968_IG117
        cmp      ecx, 16
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      rdx, 0xD1FFAB1E      ; static handle
        movzx    rcx, byte  ptr [rcx+rdx]
        and      r12d, 7
        bt       ecx, r12d
        setb     r12b
        movzx    r12, r12b
-						;; size=71 bbWeight=1.24 PerfScore 13.65
-G_M19968_IG29:
+						;; size=80 bbWeight=1.23 PerfScore 15.03
+G_M19968_IG27:
        cmp      r13d, r12d
        je       G_M19968_IG12
        jmp      G_M19968_IG03
-						;; size=14 bbWeight=1.24 PerfScore 4.03
-G_M19968_IG30:
-       cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG129
-       mov      eax, dword ptr [rbx+0x44]
-       sub      eax, dword ptr [rbx+0x4C]
-						;; size=16 bbWeight=0.98 PerfScore 8.85
-G_M19968_IG31:
-       test     eax, eax
-       jle      G_M19968_IG12
+						;; size=14 bbWeight=1.23 PerfScore 3.99
+G_M19968_IG28:
        cmp      byte  ptr [rbx+0x69], 0
        jne      G_M19968_IG130
+       mov      eax, dword ptr [rbx+0x44]
+       sub      eax, dword ptr [rbx+0x4C]
+						;; size=16 bbWeight=0.98 PerfScore 8.81
+G_M19968_IG29:
+       test     eax, eax
+       jle      G_M19968_IG12
+						;; size=8 bbWeight=0.98 PerfScore 1.22
+G_M19968_IG30:
+       cmp      byte  ptr [rbx+0x69], 0
+       jne      G_M19968_IG131
        mov      r10d, dword ptr [rbx+0x4C]
        lea      ecx, [r10+0x01]
        mov      dword ptr [rbx+0x4C], ecx
-						;; size=29 bbWeight=0.98 PerfScore 8.60
-G_M19968_IG32:
+						;; size=21 bbWeight=0.98 PerfScore 7.34
+G_M19968_IG31:
        cmp      r10d, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, r10d
        movzx    rcx, word  ptr [rsi+2*rcx]
        mov      r9, gword ptr [rbx+0x70]
@@ -6123,13 +6120,13 @@ G_M19968_IG32:
        lea      edx, [r15+0x01]
        mov      r11d, dword ptr [r9+0x08]
        cmp      edx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r11d, edx
        cmp      cx, word  ptr [r9+4*r11+0x10]
        jne      G_M19968_IG12
        jmp      G_M19968_IG04
-						;; size=68 bbWeight=0.98 PerfScore 19.17
-G_M19968_IG33:
+						;; size=68 bbWeight=0.98 PerfScore 19.09
+G_M19968_IG32:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      rdx, rcx
@@ -6137,25 +6134,25 @@ G_M19968_IG33:
        lea      r8d, [r15+0x02]
        mov      r11d, dword ptr [rdx+0x08]
        cmp      r8d, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r12d, dword ptr [rdx+4*r8+0x10]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG134
+       jne      G_M19968_IG135
        mov      r14d, dword ptr [rbx+0x44]
        sub      r14d, dword ptr [rbx+0x4C]
-						;; size=58 bbWeight=1.26 PerfScore 26.38
-G_M19968_IG34:
+						;; size=58 bbWeight=1.24 PerfScore 25.95
+G_M19968_IG33:
        cmp      r12d, r14d
-       jg       G_M19968_IG135
-						;; size=9 bbWeight=1.26 PerfScore 1.57
-G_M19968_IG35:
+       jg       G_M19968_IG136
+						;; size=9 bbWeight=1.24 PerfScore 1.54
+G_M19968_IG34:
        lea      edx, [r15+0x01]
        cmp      edx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [r9+0x18]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, edx
        mov      r14, gword ptr [rcx+8*r8+0x10]
        mov      rcx, gword ptr [r9+0x20]
@@ -6165,29 +6162,29 @@ G_M19968_IG35:
        mov      r13, rax
        mov      ebp, r12d
        test     r12d, r12d
-       jle      SHORT G_M19968_IG39
-						;; size=71 bbWeight=1.26 PerfScore 21.67
-G_M19968_IG36:
+       jle      SHORT G_M19968_IG38
+						;; size=71 bbWeight=1.24 PerfScore 21.31
+G_M19968_IG35:
        cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG136
+       jne      G_M19968_IG137
        mov      eax, dword ptr [rbx+0x4C]
        lea      ecx, [rax+0x01]
        mov      dword ptr [rbx+0x4C], ecx
-						;; size=19 bbWeight=1.50 PerfScore 11.26
-G_M19968_IG37:
+						;; size=19 bbWeight=1.47 PerfScore 11.02
+G_M19968_IG36:
        cmp      eax, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, eax
        movzx    rcx, word  ptr [rsi+2*rcx]
        mov      rdx, gword ptr [r13]
        test     rdx, rdx
-       je       G_M19968_IG137
+       je       G_M19968_IG138
        mov      r8d, ecx
        sar      r8d, 4
        cmp      dword ptr [rdx+0x08], r8d
-       jbe      G_M19968_IG137
+       jbe      G_M19968_IG138
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8d, ecx
        and      r8d, 15
@@ -6195,37 +6192,37 @@ G_M19968_IG37:
        mov      eax, 1
        shlx     r8d, eax, r8d
        test     edx, r8d
-       je       G_M19968_IG137
+       je       G_M19968_IG138
        add      r8d, r8d
        test     edx, r8d
-       je       SHORT G_M19968_IG41
-						;; size=96 bbWeight=1.50 PerfScore 32.66
-G_M19968_IG38:
+       je       SHORT G_M19968_IG40
+						;; size=96 bbWeight=1.47 PerfScore 31.97
+G_M19968_IG37:
        dec      ebp
        test     ebp, ebp
-       jg       SHORT G_M19968_IG36
-						;; size=6 bbWeight=2.51 PerfScore 3.77
-G_M19968_IG39:
+       jg       SHORT G_M19968_IG35
+						;; size=6 bbWeight=2.46 PerfScore 3.69
+G_M19968_IG38:
        cmp      r12d, ebp
        jle      G_M19968_IG05
-						;; size=9 bbWeight=1.26 PerfScore 1.57
-G_M19968_IG40:
+						;; size=9 bbWeight=1.24 PerfScore 1.54
+G_M19968_IG39:
        cmp      dword ptr [rbx+0x84], 5
        jne      G_M19968_IG05
-       jmp      G_M19968_IG141
-						;; size=18 bbWeight=1.24 PerfScore 7.45
-G_M19968_IG41:
+       jmp      G_M19968_IG142
+						;; size=18 bbWeight=1.23 PerfScore 7.40
+G_M19968_IG40:
        mov      ecx, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG140
+       jne      G_M19968_IG141
        mov      edx, -1
-						;; size=18 bbWeight=0.24 PerfScore 1.53
-G_M19968_IG42:
+						;; size=18 bbWeight=0.25 PerfScore 1.55
+G_M19968_IG41:
        add      ecx, edx
        mov      dword ptr [rbx+0x4C], ecx
-       jmp      SHORT G_M19968_IG39
-						;; size=7 bbWeight=0.24 PerfScore 0.80
-G_M19968_IG43:
+       jmp      SHORT G_M19968_IG38
+						;; size=7 bbWeight=0.25 PerfScore 0.80
+G_M19968_IG42:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      rdx, rcx
@@ -6233,23 +6230,25 @@ G_M19968_IG43:
        lea      r8d, [r15+0x02]
        mov      r11d, dword ptr [rdx+0x08]
        cmp      r8d, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rdx+4*r8+0x10]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG165
+       jne      G_M19968_IG166
        mov      eax, dword ptr [rbx+0x44]
        sub      eax, dword ptr [rbx+0x4C]
-						;; size=56 bbWeight=1.24 PerfScore 25.97
-G_M19968_IG44:
+						;; size=56 bbWeight=1.24 PerfScore 26.01
+G_M19968_IG43:
        cmp      eax, r14d
        jl       G_M19968_IG12
+						;; size=9 bbWeight=1.24 PerfScore 1.55
+G_M19968_IG44:
        lea      edx, [r15+0x01]
        cmp      edx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [r9+0x18]
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, edx
        mov      r12, gword ptr [rcx+8*r8+0x10]
        mov      rcx, gword ptr [r9+0x20]
@@ -6261,28 +6260,30 @@ G_M19968_IG44:
        mov      r15d, ecx
        test     r14d, r14d
        jle      G_M19968_IG05
-						;; size=88 bbWeight=1.24 PerfScore 23.50
+						;; size=79 bbWeight=1.24 PerfScore 21.99
 G_M19968_IG45:
        cmp      byte  ptr [rbx+0x69], 0
-       jne      G_M19968_IG166
+       jne      G_M19968_IG167
        mov      eax, dword ptr [rbx+0x4C]
        lea      ecx, [rax+0x01]
        mov      dword ptr [rbx+0x4C], ecx
-						;; size=19 bbWeight=1.49 PerfScore 11.17
+						;; size=19 bbWeight=1.46 PerfScore 10.96
 G_M19968_IG46:
        cmp      eax, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, eax
        movzx    rcx, word  ptr [rsi+2*rcx]
        mov      rax, gword ptr [r13]
        test     rax, rax
-       je       G_M19968_IG167
+       je       G_M19968_IG168
+						;; size=27 bbWeight=1.46 PerfScore 9.87
+G_M19968_IG47:
        mov      edx, ecx
        sar      edx, 4
        cmp      dword ptr [rax+0x08], edx
-       jbe      G_M19968_IG167
+       jbe      G_M19968_IG168
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      eax, dword ptr [rax+4*rdx+0x10]
        mov      edx, ecx
        and      edx, 15
@@ -6290,24 +6291,24 @@ G_M19968_IG46:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     eax, edx
-       je       G_M19968_IG167
+       je       G_M19968_IG168
        add      edx, edx
        test     eax, edx
        je       G_M19968_IG12
-						;; size=90 bbWeight=1.49 PerfScore 32.38
-G_M19968_IG47:
+						;; size=63 bbWeight=1.46 PerfScore 21.93
+G_M19968_IG48:
        mov      r14d, r15d
        lea      r15d, [r14-0x01]
        test     r14d, r14d
        jg       SHORT G_M19968_IG45
        jmp      G_M19968_IG05
-						;; size=17 bbWeight=1.49 PerfScore 5.96
-G_M19968_IG48:
+						;; size=17 bbWeight=1.46 PerfScore 5.85
+G_M19968_IG49:
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
        mov      dword ptr [rbx+0x50], ecx
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M19968_IG49:
+G_M19968_IG50:
        mov      rcx, gword ptr [rbx+0x20]
        mov      ecx, dword ptr [rcx+0x08]
        sub      ecx, dword ptr [rbx+0x58]
@@ -6315,31 +6316,13 @@ G_M19968_IG49:
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      ecx, dword ptr [rax+4*rdx+0x10]
        je       G_M19968_IG12
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
-       jmp      SHORT G_M19968_IG49
+       jmp      SHORT G_M19968_IG50
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M19968_IG50:
-       mov      ecx, dword ptr [rbx+0x50]
-       inc      ecx
-       mov      dword ptr [rbx+0x50], ecx
-       mov      rax, gword ptr [rbx+0x10]
-       dec      ecx
-       cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
-       mov      ecx, dword ptr [rax+4*rcx+0x10]
-       mov      rax, gword ptr [rbx+0x18]
-       mov      edx, dword ptr [rbx+0x54]
-       dec      edx
-       mov      dword ptr [rbx+0x54], edx
-       cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
-       mov      dword ptr [rax+4*rdx+0x10], ecx
-       jmp      G_M19968_IG12
-						;; size=57 bbWeight=0 PerfScore 0.00
 G_M19968_IG51:
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
@@ -6347,14 +6330,32 @@ G_M19968_IG51:
        mov      rax, gword ptr [rbx+0x10]
        dec      ecx
        cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rax+4*rcx+0x10]
        mov      rax, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
+       mov      dword ptr [rax+4*rdx+0x10], ecx
+       jmp      G_M19968_IG12
+						;; size=57 bbWeight=0 PerfScore 0.00
+G_M19968_IG52:
+       mov      ecx, dword ptr [rbx+0x50]
+       inc      ecx
+       mov      dword ptr [rbx+0x50], ecx
+       mov      rax, gword ptr [rbx+0x10]
+       dec      ecx
+       cmp      ecx, dword ptr [rax+0x08]
+       jae      G_M19968_IG190
+       mov      ecx, dword ptr [rax+4*rcx+0x10]
+       mov      rax, gword ptr [rbx+0x18]
+       mov      edx, dword ptr [rbx+0x54]
+       dec      edx
+       mov      dword ptr [rbx+0x54], edx
+       cmp      edx, dword ptr [rax+0x08]
+       jae      G_M19968_IG190
        mov      dword ptr [rax+4*rdx+0x10], ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
@@ -6363,7 +6364,7 @@ G_M19968_IG51:
        mov      eax, dword ptr [rbx+0x88]
        inc      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      dword ptr [rcx+4*rax+0x10], -1
        je       G_M19968_IG12
        mov      rcx, gword ptr [rbx+0x70]
@@ -6371,32 +6372,32 @@ G_M19968_IG51:
        mov      eax, dword ptr [rbx+0x88]
        add      eax, 2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      dword ptr [rcx+4*rax+0x10], -1
        je       G_M19968_IG12
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
        jmp      G_M19968_IG12
 						;; size=148 bbWeight=0 PerfScore 0.00
-G_M19968_IG52:
+G_M19968_IG53:
        add      dword ptr [rbx+0x50], 3
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r13d, dword ptr [r8+4*rdx+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        add      edx, -3
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [r8+4*rdx+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
@@ -6404,17 +6405,17 @@ G_M19968_IG52:
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      r8d, dword ptr [rcx+4*rax+0x10]
-       jge      SHORT G_M19968_IG54
+       jge      SHORT G_M19968_IG55
        cmp      edx, r13d
-       je       SHORT G_M19968_IG54
+       je       SHORT G_M19968_IG55
        mov      dword ptr [rbx+0x4C], edx
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        inc      r8d
        mov      rcx, rbx
@@ -6428,31 +6429,31 @@ G_M19968_IG52:
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
 						;; size=193 bbWeight=0 PerfScore 0.00
-G_M19968_IG53:
-       jae      G_M19968_IG189
+G_M19968_IG54:
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
        jmp      G_M19968_IG17
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M19968_IG54:
+G_M19968_IG55:
        mov      rdx, gword ptr [rbx+0x10]
        mov      r8d, dword ptr [rbx+0x50]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
        jmp      G_M19968_IG12
 						;; size=65 bbWeight=0 PerfScore 0.00
-G_M19968_IG55:
+G_M19968_IG56:
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
        mov      dword ptr [rbx+0x50], ecx
@@ -6461,66 +6462,66 @@ G_M19968_IG55:
        mov      r8d, dword ptr [rbx+0x54]
        add      r8d, -2
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      dword ptr [rdx+4*r8+0x10], 0
-       jle      SHORT G_M19968_IG56
+       jle      SHORT G_M19968_IG57
        mov      rdx, gword ptr [rbx+0x18]
        mov      r8d, dword ptr [rbx+0x54]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      dword ptr [rbx+0x4C], edx
        mov      rdx, gword ptr [rbx+0x10]
        lea      r8d, [rcx-0x01]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        dec      r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=136 bbWeight=0 PerfScore 0.00
-G_M19968_IG56:
+G_M19968_IG57:
        mov      rdx, gword ptr [rbx+0x10]
        lea      r8d, [rcx-0x01]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        dec      r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
        jmp      G_M19968_IG12
 						;; size=65 bbWeight=0 PerfScore 0.00
-G_M19968_IG57:
+G_M19968_IG58:
        add      dword ptr [rbx+0x54], 2
        jmp      G_M19968_IG12
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG58:
+G_M19968_IG59:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r12d, dword ptr [rdx+4*rcx+0x10]
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
@@ -6529,7 +6530,7 @@ G_M19968_IG58:
        dec      ecx
        mov      dword ptr [rbx+0x54], ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rdx+4*rcx+0x10], r12d
        mov      dword ptr [rbx+0x4C], r12d
        mov      rdx, gword ptr [rbx+0x70]
@@ -6537,49 +6538,49 @@ G_M19968_IG58:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
        jmp      G_M19968_IG17
 						;; size=132 bbWeight=0 PerfScore 0.00
-G_M19968_IG59:
+G_M19968_IG60:
        add      dword ptr [rbx+0x50], 2
        inc      dword ptr [rbx+0x54]
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], edx
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=69 bbWeight=0 PerfScore 0.00
-G_M19968_IG60:
+G_M19968_IG61:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleStack():this]
        jmp      G_M19968_IG19
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG61:
+G_M19968_IG62:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleTrack():this]
        jmp      G_M19968_IG20
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG62:
+G_M19968_IG63:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r14d
        mov      r9, gword ptr [rbx+0x70]
@@ -6589,7 +6590,7 @@ G_M19968_IG62:
        lea      ecx, [r15+0x01]
        mov      r11d, dword ptr [rdx+0x08]
        cmp      ecx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rdx+4*rcx+0x10]
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -6600,7 +6601,7 @@ G_M19968_IG62:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x18]
        cmp      r15d, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, r15d
        mov      r12, gword ptr [rcx+8*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
@@ -6610,13 +6611,13 @@ G_M19968_IG62:
        call     CORINFO_HELP_LDELEMA_REF
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M19968_IG64
+       je       SHORT G_M19968_IG65
        mov      edx, r13d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M19968_IG64
+       jbe      SHORT G_M19968_IG65
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r13d
        and      edx, 15
@@ -6624,65 +6625,65 @@ G_M19968_IG62:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M19968_IG64
+       je       SHORT G_M19968_IG65
 						;; size=205 bbWeight=0 PerfScore 0.00
-G_M19968_IG63:
+G_M19968_IG64:
        add      edx, edx
        test     ecx, edx
        setne    r15b
        movzx    r15, r15b
-       jmp      SHORT G_M19968_IG66
+       jmp      SHORT G_M19968_IG67
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG64:
+G_M19968_IG65:
        cmp      r13d, 128
-       jl       SHORT G_M19968_IG65
+       jl       SHORT G_M19968_IG66
        mov      ecx, r13d
        mov      rdx, r12
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r15d, eax
-       jmp      SHORT G_M19968_IG66
+       jmp      SHORT G_M19968_IG67
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M19968_IG65:
+G_M19968_IG66:
        mov      ecx, r13d
        mov      rdx, r12
        mov      r8, rax
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
        mov      r15d, eax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M19968_IG66:
+G_M19968_IG67:
        test     r15d, r15d
        je       G_M19968_IG12
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [r8+4*rdx+0x10]
        test     edx, edx
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG67
+       jne      SHORT G_M19968_IG68
        mov      r8d, 1
-       jmp      SHORT G_M19968_IG68
+       jmp      SHORT G_M19968_IG69
 						;; size=55 bbWeight=0 PerfScore 0.00
-G_M19968_IG67:
+G_M19968_IG68:
        mov      r8d, -1
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M19968_IG68:
+G_M19968_IG69:
        add      r8d, r14d
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG69:
+G_M19968_IG70:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r14d
        mov      bword ptr [rsp+0x28], rsi
@@ -6695,7 +6696,7 @@ G_M19968_IG69:
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    r8, word  ptr [r8+4*rdx+0x10]
        cmp      eax, r8d
        je       G_M19968_IG12
@@ -6703,32 +6704,32 @@ G_M19968_IG69:
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [r8+4*rdx+0x10]
        test     edx, edx
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG70
+       jne      SHORT G_M19968_IG71
        mov      r8d, 1
-       jmp      SHORT G_M19968_IG71
+       jmp      SHORT G_M19968_IG72
 						;; size=142 bbWeight=0 PerfScore 0.00
-G_M19968_IG70:
+G_M19968_IG71:
        mov      r8d, -1
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M19968_IG71:
+G_M19968_IG72:
        add      r8d, r14d
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG72:
+G_M19968_IG73:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rdx+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r14d
        mov      bword ptr [rsp+0x28], rsi
@@ -6741,7 +6742,7 @@ G_M19968_IG72:
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    r8, word  ptr [r8+4*rdx+0x10]
        cmp      eax, r8d
        jne      G_M19968_IG12
@@ -6749,82 +6750,72 @@ G_M19968_IG72:
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [r8+4*rdx+0x10]
        test     edx, edx
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG73
+       jne      SHORT G_M19968_IG74
        mov      r8d, 1
-       jmp      SHORT G_M19968_IG74
+       jmp      SHORT G_M19968_IG75
 						;; size=142 bbWeight=0 PerfScore 0.00
-G_M19968_IG73:
+G_M19968_IG74:
        mov      r8d, -1
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M19968_IG74:
+G_M19968_IG75:
        add      r8d, r14d
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG75:
+G_M19968_IG76:
        add      dword ptr [rbx+0x50], 2
        mov      r8, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rbx+0x50]
        dec      edx
        cmp      edx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [r8+4*rdx+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      dword ptr [rbx+0x4C], r8d
        test     edx, edx
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG76
+       jne      SHORT G_M19968_IG77
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG77
+       jmp      SHORT G_M19968_IG78
 						;; size=78 bbWeight=0 PerfScore 0.00
-G_M19968_IG76:
+G_M19968_IG77:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG77:
+G_M19968_IG78:
        sub      r8d, ecx
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=19 bbWeight=0 PerfScore 0.00
-G_M19968_IG78:
+G_M19968_IG79:
        mov      rcx, gword ptr [rbx+0x10]
        mov      rdx, gword ptr [rbx+0x10]
        mov      edx, dword ptr [rdx+0x08]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        lea      rcx, bword ptr [rcx+4*rdx+0x10]
        mov      edx, dword ptr [rcx]
        cmp      edx, dword ptr [rbx+0x4C]
-       jge      G_M19968_IG121
+       jge      G_M19968_IG122
        mov      edx, dword ptr [rbx+0x4C]
        mov      dword ptr [rcx], edx
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=48 bbWeight=0 PerfScore 0.00
-G_M19968_IG79:
-       mov      bword ptr [rsp+0x28], rsi
-       mov      dword ptr [rsp+0x30], edi
-       lea      rcx, [rsp+0x28]
-       mov      edx, dword ptr [rbx+0x4C]
-       call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
-       test     eax, eax
-       jne      G_M19968_IG12
-       jmp      G_M19968_IG121
-						;; size=36 bbWeight=0 PerfScore 0.00
 G_M19968_IG80:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -6832,10 +6823,20 @@ G_M19968_IG80:
        mov      edx, dword ptr [rbx+0x4C]
        call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
        test     eax, eax
-       je       G_M19968_IG12
-       jmp      G_M19968_IG121
+       jne      G_M19968_IG12
+       jmp      G_M19968_IG122
 						;; size=36 bbWeight=0 PerfScore 0.00
 G_M19968_IG81:
+       mov      bword ptr [rsp+0x28], rsi
+       mov      dword ptr [rsp+0x30], edi
+       lea      rcx, [rsp+0x28]
+       mov      edx, dword ptr [rbx+0x4C]
+       call     [System.Text.RegularExpressions.RegexRunner:IsECMABoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
+       test     eax, eax
+       je       G_M19968_IG12
+       jmp      G_M19968_IG122
+						;; size=36 bbWeight=0 PerfScore 0.00
+G_M19968_IG82:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      rdx, rcx
@@ -6843,35 +6844,35 @@ G_M19968_IG81:
        lea      ecx, [r15+0x01]
        mov      r11d, dword ptr [rdx+0x08]
        cmp      ecx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
        jmp      G_M19968_IG17
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M19968_IG82:
+G_M19968_IG83:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      r15d, dword ptr [rbx+0x88]
        lea      edx, [r15+0x01]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      edx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x28]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Match:IsMatched(int):ubyte:this]
        test     eax, eax
        je       G_M19968_IG12
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M19968_IG83:
+G_M19968_IG84:
        add      dword ptr [rbx+0x54], 2
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rcx+0x08]
@@ -6881,26 +6882,26 @@ G_M19968_IG83:
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=75 bbWeight=0 PerfScore 0.00
-G_M19968_IG84:
+G_M19968_IG85:
        add      dword ptr [rbx+0x54], 2
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        dec      eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rcx+4*rax+0x10]
        mov      rax, gword ptr [rbx+0x10]
        mov      eax, dword ptr [rax+0x08]
        sub      eax, ecx
        mov      dword ptr [rbx+0x50], eax
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M19968_IG85:
+G_M19968_IG86:
        mov      rcx, gword ptr [rbx+0x20]
        mov      ecx, dword ptr [rcx+0x08]
        sub      ecx, dword ptr [rbx+0x58]
@@ -6908,21 +6909,21 @@ G_M19968_IG85:
        mov      edx, dword ptr [rbx+0x54]
        add      edx, -2
        cmp      edx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      ecx, dword ptr [rax+4*rdx+0x10]
        je       G_M19968_IG12
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Uncapture():this]
-       jmp      SHORT G_M19968_IG85
+       jmp      SHORT G_M19968_IG86
 						;; size=50 bbWeight=0 PerfScore 0.00
-G_M19968_IG86:
+G_M19968_IG87:
        cmp      byte  ptr [rbx+0x68], 0
-       je       SHORT G_M19968_IG87
+       je       SHORT G_M19968_IG88
        call     <unknown method>
        cmp      rax, qword ptr [rbx+0x38]
-       jge      G_M19968_IG185
+       jge      G_M19968_IG186
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M19968_IG87:
+G_M19968_IG88:
        mov      r8, gword ptr [rbx+0x20]
        mov      r8d, dword ptr [r8+0x08]
        sub      r8d, dword ptr [rbx+0x58]
@@ -6931,15 +6932,15 @@ G_M19968_IG87:
        sub      edx, dword ptr [rbx+0x50]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      G_M19968_IG94
+       jmp      G_M19968_IG95
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG88:
+G_M19968_IG89:
        inc      dword ptr [rbx+0x54]
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
@@ -6947,12 +6948,12 @@ G_M19968_IG88:
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      dword ptr [rbx+0x4C], ecx
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=64 bbWeight=0 PerfScore 0.00
-G_M19968_IG89:
+G_M19968_IG90:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      rdx, rcx
@@ -6960,12 +6961,12 @@ G_M19968_IG89:
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rdx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      dword ptr [rdx+4*rax+0x10], -1
-       je       SHORT G_M19968_IG90
+       je       SHORT G_M19968_IG91
        lea      edx, [r15+0x02]
        cmp      edx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x28]
        cmp      dword ptr [rcx], ecx
@@ -6973,101 +6974,101 @@ G_M19968_IG89:
        test     eax, eax
        je       G_M19968_IG12
 						;; size=79 bbWeight=0 PerfScore 0.00
-G_M19968_IG90:
+G_M19968_IG91:
        inc      dword ptr [rbx+0x54]
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      r8d, dword ptr [rbx+0x88]
        add      r8d, 2
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      dword ptr [rdx+4*r8+0x10], -1
-       je       SHORT G_M19968_IG91
+       je       SHORT G_M19968_IG92
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      r8d, dword ptr [rbx+0x88]
        inc      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x70]
        mov      r8, gword ptr [r8+0x10]
        mov      r9d, dword ptr [rbx+0x88]
        add      r9d, 2
        cmp      r9d, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*r9+0x10]
        mov      r9, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [r9+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r9d, dword ptr [r9+4*rcx+0x10]
        mov      ecx, dword ptr [rbx+0x4C]
        mov      dword ptr [rsp+0x20], ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:TransferCapture(int,int,int,int):this]
-       jmp      SHORT G_M19968_IG92
+       jmp      SHORT G_M19968_IG93
 						;; size=149 bbWeight=0 PerfScore 0.00
-G_M19968_IG91:
+G_M19968_IG92:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      r8d, dword ptr [rbx+0x88]
        inc      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      r9d, dword ptr [rbx+0x54]
        dec      r9d
        cmp      r9d, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*r9+0x10]
        mov      r9d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:Capture(int,int,int):this]
 						;; size=72 bbWeight=0 PerfScore 0.00
-G_M19968_IG92:
+G_M19968_IG93:
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG93:
+G_M19968_IG94:
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        dec      eax
        mov      dword ptr [rbx+0x54], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rcx+4*rax+0x10], -1
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M19968_IG94:
+G_M19968_IG95:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush():this]
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG95:
+G_M19968_IG96:
        add      dword ptr [rbx+0x54], 2
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        add      eax, -2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rcx+4*rax+0x10]
        test     r15d, r15d
-       jge      SHORT G_M19968_IG96
+       jge      SHORT G_M19968_IG97
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
        mov      edx, dword ptr [rbx+0x4C]
@@ -7079,32 +7080,32 @@ G_M19968_IG95:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
        jmp      G_M19968_IG17
 						;; size=123 bbWeight=0 PerfScore 0.00
-G_M19968_IG96:
+G_M19968_IG97:
        mov      r9d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        mov      r8d, r15d
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M19968_IG97:
+G_M19968_IG98:
        add      dword ptr [rbx+0x54], 2
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        add      eax, -2
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rcx+4*rax+0x10]
        mov      ecx, dword ptr [rbx+0x4C]
        sub      ecx, edx
@@ -7114,15 +7115,15 @@ G_M19968_IG97:
        lea      r8d, [r15+0x02]
        mov      r11d, dword ptr [rax+0x08]
        cmp      r8d, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      dword ptr [rax+4*r8+0x10], r14d
-       jle      SHORT G_M19968_IG99
+       jle      SHORT G_M19968_IG100
        test     ecx, ecx
-       jne      SHORT G_M19968_IG98
+       jne      SHORT G_M19968_IG99
        test     r14d, r14d
-       jge      SHORT G_M19968_IG99
+       jge      SHORT G_M19968_IG100
 						;; size=103 bbWeight=0 PerfScore 0.00
-G_M19968_IG98:
+G_M19968_IG99:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int):this]
        mov      edx, dword ptr [rbx+0x4C]
@@ -7134,19 +7135,19 @@ G_M19968_IG98:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
        jmp      G_M19968_IG17
 						;; size=68 bbWeight=0 PerfScore 0.00
-G_M19968_IG99:
+G_M19968_IG100:
        mov      rcx, rbx
        mov      r8d, r14d
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG100:
+G_M19968_IG101:
        mov      edx, dword ptr [rbx+0x4C]
        mov      r9, gword ptr [rbx+0x70]
        mov      rax, gword ptr [r9+0x10]
@@ -7155,13 +7156,13 @@ G_M19968_IG100:
        lea      ecx, [r15+0x01]
        mov      r11d, dword ptr [r8+0x08]
        cmp      ecx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
-       jmp      SHORT G_M19968_IG102
+       jmp      SHORT G_M19968_IG103
 						;; size=54 bbWeight=0 PerfScore 0.00
-G_M19968_IG101:
+G_M19968_IG102:
        mov      r9, gword ptr [rbx+0x70]
        mov      rax, gword ptr [r9+0x10]
        mov      r8, rax
@@ -7169,74 +7170,74 @@ G_M19968_IG101:
        lea      ecx, [r15+0x01]
        mov      r11d, dword ptr [r8+0x08]
        cmp      ecx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        mov      edx, -1
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
 						;; size=54 bbWeight=0 PerfScore 0.00
-G_M19968_IG102:
+G_M19968_IG103:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush():this]
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG103:
+G_M19968_IG104:
        inc      dword ptr [rbx+0x54]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [r8+4*rcx+0x10]
        cmp      dword ptr [rbx+0x4C], edx
-       je       SHORT G_M19968_IG105
+       je       SHORT G_M19968_IG106
        cmp      edx, -1
-       je       SHORT G_M19968_IG104
+       je       SHORT G_M19968_IG105
        mov      r8d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=55 bbWeight=0 PerfScore 0.00
-G_M19968_IG104:
+G_M19968_IG105:
        mov      r8d, dword ptr [rbx+0x4C]
        mov      edx, dword ptr [rbx+0x4C]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=21 bbWeight=0 PerfScore 0.00
-G_M19968_IG105:
+G_M19968_IG106:
        mov      rcx, gword ptr [rbx+0x18]
        mov      eax, dword ptr [rbx+0x54]
        dec      eax
        mov      dword ptr [rbx+0x54], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rcx+4*rax+0x10], edx
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=61 bbWeight=0 PerfScore 0.00
-G_M19968_IG106:
+G_M19968_IG107:
        inc      dword ptr [rbx+0x54]
        mov      edx, dword ptr [rbx+0x4C]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      edx, dword ptr [r8+4*rcx+0x10]
-       je       SHORT G_M19968_IG107
+       je       SHORT G_M19968_IG108
        mov      rdx, gword ptr [rbx+0x18]
        mov      r8d, dword ptr [rbx+0x54]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8d, dword ptr [rbx+0x4C]
        mov      rcx, rbx
@@ -7247,60 +7248,60 @@ G_M19968_IG106:
        dec      eax
        mov      dword ptr [rbx+0x54], eax
        cmp      eax, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rcx+4*rax+0x10], edx
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Goto(int):this]
        jmp      G_M19968_IG17
 						;; size=142 bbWeight=0 PerfScore 0.00
-G_M19968_IG107:
+G_M19968_IG108:
        mov      rdx, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        dec      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush2(int):this]
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG108:
+G_M19968_IG109:
        cmp      dword ptr [rbx+0x4C], edi
        jl       G_M19968_IG12
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG109:
+G_M19968_IG110:
        mov      ecx, dword ptr [rbx+0x4C]
        lea      edx, [rdi-0x01]
        cmp      ecx, edx
        jl       G_M19968_IG12
        cmp      ecx, edi
-       jae      G_M19968_IG121
+       jae      G_M19968_IG122
        cmp      ecx, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      word  ptr [rsi+2*rcx], 10
        jne      G_M19968_IG12
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=46 bbWeight=0 PerfScore 0.00
-G_M19968_IG110:
+G_M19968_IG111:
        mov      ecx, dword ptr [rbx+0x4C]
        cmp      ecx, dword ptr [rbx+0x48]
        jne      G_M19968_IG12
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG111:
+G_M19968_IG112:
        cmp      dword ptr [rbx+0x4C], 0
        jg       G_M19968_IG12
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M19968_IG112:
+G_M19968_IG113:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rcx, [rsp+0x28]
@@ -7308,15 +7309,15 @@ G_M19968_IG112:
        call     [System.Text.RegularExpressions.RegexRunner:IsBoundary(System.ReadOnlySpan`1[ushort],int):ubyte]
        test     eax, eax
        jne      G_M19968_IG12
-       jmp      G_M19968_IG121
+       jmp      G_M19968_IG122
 						;; size=36 bbWeight=0 PerfScore 0.00
-G_M19968_IG113:
+G_M19968_IG114:
        mov      ecx, r13d
        call     [System.Globalization.CharUnicodeInfo:GetUnicodeCategoryNoBoundsChecks(uint):int]
        mov      ecx, 1
        shlx     ecx, ecx, eax
        test     ecx, 0xD1FFAB1E
-       jne      SHORT G_M19968_IG114
+       jne      SHORT G_M19968_IG115
        cmp      r13d, 0x200D
        sete     cl
        movzx    rcx, cl
@@ -7324,23 +7325,23 @@ G_M19968_IG113:
        sete     r13b
        movzx    r13, r13b
        or       r13d, ecx
-       jmp      G_M19968_IG27
+       jmp      G_M19968_IG26
 						;; size=63 bbWeight=0 PerfScore 0.00
-G_M19968_IG114:
-       mov      r13d, 1
-       jmp      G_M19968_IG27
-						;; size=11 bbWeight=0 PerfScore 0.00
 G_M19968_IG115:
-       xor      r13d, r13d
-       jmp      G_M19968_IG27
-						;; size=8 bbWeight=0 PerfScore 0.00
+       mov      r13d, 1
+       jmp      G_M19968_IG26
+						;; size=11 bbWeight=0 PerfScore 0.00
 G_M19968_IG116:
+       xor      r13d, r13d
+       jmp      G_M19968_IG26
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M19968_IG117:
        mov      ecx, r12d
        call     [System.Globalization.CharUnicodeInfo:GetUnicodeCategoryNoBoundsChecks(uint):int]
        mov      edx, 1
        shlx     edx, edx, eax
        test     edx, 0xD1FFAB1E
-       jne      SHORT G_M19968_IG117
+       jne      SHORT G_M19968_IG118
        cmp      r12d, 0x200D
        sete     dl
        movzx    rdx, dl
@@ -7348,41 +7349,41 @@ G_M19968_IG116:
        sete     r12b
        movzx    r12, r12b
        or       r12d, edx
-       jmp      G_M19968_IG29
+       jmp      G_M19968_IG27
 						;; size=63 bbWeight=0 PerfScore 0.00
-G_M19968_IG117:
-       mov      r12d, 1
-       jmp      G_M19968_IG29
-						;; size=11 bbWeight=0 PerfScore 0.00
 G_M19968_IG118:
-       xor      r12d, r12d
-       jmp      G_M19968_IG29
-						;; size=8 bbWeight=0 PerfScore 0.00
+       mov      r12d, 1
+       jmp      G_M19968_IG27
+						;; size=11 bbWeight=0 PerfScore 0.00
 G_M19968_IG119:
+       xor      r12d, r12d
+       jmp      G_M19968_IG27
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M19968_IG120:
        mov      edx, dword ptr [rbx+0x4C]
        cmp      edx, edi
-       jae      SHORT G_M19968_IG121
+       jae      SHORT G_M19968_IG122
        cmp      edx, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      word  ptr [rsi+2*rdx], 10
        jne      G_M19968_IG12
-       jmp      SHORT G_M19968_IG121
+       jmp      SHORT G_M19968_IG122
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG120:
+G_M19968_IG121:
        mov      edx, dword ptr [rbx+0x4C]
        dec      edx
        cmp      edx, edi
-       jae      SHORT G_M19968_IG121
+       jae      SHORT G_M19968_IG122
        cmp      edx, edi
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        cmp      word  ptr [rsi+2*rdx], 10
        jne      G_M19968_IG12
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG121:
+G_M19968_IG122:
        xor      ebp, ebp
        jmp      G_M19968_IG17
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M19968_IG122:
+G_M19968_IG123:
        mov      r9, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [r9+0x18]
        mov      rax, gword ptr [r9+0x10]
@@ -7391,10 +7392,10 @@ G_M19968_IG122:
        lea      ecx, [r15+0x01]
        mov      r11d, dword ptr [r8+0x08]
        cmp      ecx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      rdx, gword ptr [rdx+8*r8+0x10]
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -7403,9 +7404,9 @@ G_M19968_IG122:
        call     [System.Text.RegularExpressions.RegexInterpreter:MatchString(System.String,System.ReadOnlySpan`1[ushort]):ubyte:this]
        test     eax, eax
        je       G_M19968_IG12
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=95 bbWeight=0 PerfScore 0.00
-G_M19968_IG123:
+G_M19968_IG124:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        test     eax, eax
@@ -7415,7 +7416,7 @@ G_M19968_IG123:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rdx+4*rcx+0x10]
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
@@ -7426,7 +7427,7 @@ G_M19968_IG123:
        mov      rcx, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [rcx+0x18]
        cmp      r15d, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, r15d
        mov      r13, gword ptr [rcx+8*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x70]
@@ -7436,13 +7437,13 @@ G_M19968_IG123:
        call     CORINFO_HELP_LDELEMA_REF
        mov      rcx, gword ptr [rax]
        test     rcx, rcx
-       je       SHORT G_M19968_IG125
+       je       SHORT G_M19968_IG126
        mov      edx, r14d
        sar      edx, 4
        cmp      dword ptr [rcx+0x08], edx
-       jbe      SHORT G_M19968_IG125
+       jbe      SHORT G_M19968_IG126
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      ecx, dword ptr [rcx+4*rdx+0x10]
        mov      edx, r14d
        and      edx, 15
@@ -7450,38 +7451,38 @@ G_M19968_IG123:
        mov      r8d, 1
        shlx     edx, r8d, edx
        test     ecx, edx
-       je       SHORT G_M19968_IG125
+       je       SHORT G_M19968_IG126
        add      edx, edx
        test     ecx, edx
        setne    r15b
        movzx    r15, r15b
 						;; size=192 bbWeight=0 PerfScore 0.00
-G_M19968_IG124:
-       jmp      SHORT G_M19968_IG127
-						;; size=2 bbWeight=0 PerfScore 0.00
 G_M19968_IG125:
+       jmp      SHORT G_M19968_IG128
+						;; size=2 bbWeight=0 PerfScore 0.00
+G_M19968_IG126:
        cmp      r14d, 128
-       jl       SHORT G_M19968_IG126
+       jl       SHORT G_M19968_IG127
        mov      ecx, r14d
        mov      rdx, r13
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
        mov      r15d, eax
-       jmp      SHORT G_M19968_IG127
+       jmp      SHORT G_M19968_IG128
 						;; size=29 bbWeight=0 PerfScore 0.00
-G_M19968_IG126:
+G_M19968_IG127:
        mov      ecx, r14d
        mov      rdx, r13
        mov      r8, rax
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
        mov      r15d, eax
 						;; size=18 bbWeight=0 PerfScore 0.00
-G_M19968_IG127:
+G_M19968_IG128:
        test     r15d, r15d
        je       G_M19968_IG12
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG128:
+G_M19968_IG129:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        test     eax, eax
@@ -7496,23 +7497,23 @@ G_M19968_IG128:
        mov      edx, dword ptr [rbx+0x88]
        inc      edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    rcx, word  ptr [rcx+4*rdx+0x10]
        cmp      eax, ecx
        je       G_M19968_IG12
-       jmp      G_M19968_IG179
+       jmp      G_M19968_IG180
 						;; size=83 bbWeight=0 PerfScore 0.00
-G_M19968_IG129:
-       mov      eax, dword ptr [rbx+0x4C]
-       jmp      G_M19968_IG31
-						;; size=8 bbWeight=0 PerfScore 0.00
 G_M19968_IG130:
+       mov      eax, dword ptr [rbx+0x4C]
+       jmp      G_M19968_IG29
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M19968_IG131:
        mov      r10d, dword ptr [rbx+0x4C]
        dec      r10d
        mov      dword ptr [rbx+0x4C], r10d
-       jmp      G_M19968_IG32
+       jmp      G_M19968_IG31
 						;; size=16 bbWeight=0 PerfScore 0.00
-G_M19968_IG131:
+G_M19968_IG132:
        mov      r9, gword ptr [rbx+0x70]
        mov      rax, gword ptr [r9+0x10]
        mov      rcx, rax
@@ -7520,74 +7521,74 @@ G_M19968_IG131:
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      r15d, eax
-       jg       SHORT G_M19968_IG132
+       jg       SHORT G_M19968_IG133
        mov      edx, r15d
-       jmp      SHORT G_M19968_IG133
+       jmp      SHORT G_M19968_IG134
 						;; size=59 bbWeight=0 PerfScore 0.00
-G_M19968_IG132:
+G_M19968_IG133:
        mov      edx, eax
 						;; size=2 bbWeight=0 PerfScore 0.00
-G_M19968_IG133:
+G_M19968_IG134:
        test     edx, edx
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        mov      r8d, dword ptr [rbx+0x4C]
        dec      edx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=28 bbWeight=0 PerfScore 0.00
-G_M19968_IG134:
-       mov      r14d, dword ptr [rbx+0x4C]
-       jmp      G_M19968_IG34
-						;; size=9 bbWeight=0 PerfScore 0.00
 G_M19968_IG135:
-       mov      r12d, r14d
-       jmp      G_M19968_IG35
-						;; size=8 bbWeight=0 PerfScore 0.00
+       mov      r14d, dword ptr [rbx+0x4C]
+       jmp      G_M19968_IG33
+						;; size=9 bbWeight=0 PerfScore 0.00
 G_M19968_IG136:
+       mov      r12d, r14d
+       jmp      G_M19968_IG34
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M19968_IG137:
        mov      eax, dword ptr [rbx+0x4C]
        dec      eax
        mov      dword ptr [rbx+0x4C], eax
-       jmp      G_M19968_IG37
+       jmp      G_M19968_IG36
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG137:
+G_M19968_IG138:
        cmp      ecx, 128
-       jl       SHORT G_M19968_IG138
+       jl       SHORT G_M19968_IG139
        mov      rdx, r14
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
-       jmp      SHORT G_M19968_IG139
+       jmp      SHORT G_M19968_IG140
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M19968_IG138:
+G_M19968_IG139:
        mov      rdx, r14
        mov      r8, r13
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M19968_IG139:
-       test     eax, eax
-       jne      G_M19968_IG38
-       jmp      G_M19968_IG41
-						;; size=13 bbWeight=0 PerfScore 0.00
 G_M19968_IG140:
-       mov      edx, 1
-       jmp      G_M19968_IG42
-						;; size=10 bbWeight=0 PerfScore 0.00
+       test     eax, eax
+       jne      G_M19968_IG37
+       jmp      G_M19968_IG40
+						;; size=13 bbWeight=0 PerfScore 0.00
 G_M19968_IG141:
+       mov      edx, 1
+       jmp      G_M19968_IG41
+						;; size=10 bbWeight=0 PerfScore 0.00
+G_M19968_IG142:
        mov      r8d, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG142
+       jne      SHORT G_M19968_IG143
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG143
+       jmp      SHORT G_M19968_IG144
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG142:
+G_M19968_IG143:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG143:
+G_M19968_IG144:
        mov      edx, r12d
        sub      edx, ebp
        dec      edx
@@ -7596,223 +7597,223 @@ G_M19968_IG143:
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
        jmp      G_M19968_IG05
 						;; size=24 bbWeight=0 PerfScore 0.00
-G_M19968_IG144:
+G_M19968_IG145:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      r15d, dword ptr [rbx+0x88]
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      r15d, eax
-       jg       SHORT G_M19968_IG145
-       jmp      SHORT G_M19968_IG146
+       jg       SHORT G_M19968_IG146
+       jmp      SHORT G_M19968_IG147
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M19968_IG145:
+G_M19968_IG146:
        mov      r15d, eax
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M19968_IG146:
+G_M19968_IG147:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    rbp, word  ptr [rdx+4*rcx+0x10]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG151
+       jne      SHORT G_M19968_IG152
        mov      edx, dword ptr [rbx+0x4C]
        mov      ecx, edx
        mov      r8d, r15d
        add      rcx, r8
        mov      r8d, edi
        cmp      rcx, r8
-       ja       SHORT G_M19968_IG150
+       ja       SHORT G_M19968_IG151
        lea      rcx, bword ptr [rsi+2*rdx]
        movsx    rdx, bp
        movzx    r8, dx
        dec      r8d
        cmp      r8d, 254
-       jae      SHORT G_M19968_IG147
+       jae      SHORT G_M19968_IG148
        mov      r8d, r15d
        call     [<unknown method>]
-       jmp      SHORT G_M19968_IG148
+       jmp      SHORT G_M19968_IG149
 						;; size=90 bbWeight=0 PerfScore 0.00
-G_M19968_IG147:
+G_M19968_IG148:
        mov      r8d, r15d
        call     [<unknown method>]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG148:
+G_M19968_IG149:
        cmp      eax, -1
-       jne      SHORT G_M19968_IG149
+       jne      SHORT G_M19968_IG150
        add      dword ptr [rbx+0x4C], r15d
        xor      r14d, r14d
-       jmp      SHORT G_M19968_IG154
+       jmp      SHORT G_M19968_IG155
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG149:
+G_M19968_IG150:
        add      dword ptr [rbx+0x4C], eax
        mov      r14d, r15d
        sub      r14d, eax
-       jmp      SHORT G_M19968_IG154
+       jmp      SHORT G_M19968_IG155
 						;; size=11 bbWeight=0 PerfScore 0.00
-G_M19968_IG150:
+G_M19968_IG151:
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException()]
        int3     
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M19968_IG151:
+G_M19968_IG152:
        mov      r14d, r15d
        test     r15d, r15d
-       jle      SHORT G_M19968_IG154
+       jle      SHORT G_M19968_IG155
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M19968_IG152:
+G_M19968_IG153:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        cmp      eax, ebp
-       je       SHORT G_M19968_IG153
+       je       SHORT G_M19968_IG154
        dec      r14d
        test     r14d, r14d
-       jg       SHORT G_M19968_IG152
-       jmp      SHORT G_M19968_IG154
+       jg       SHORT G_M19968_IG153
+       jmp      SHORT G_M19968_IG155
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M19968_IG153:
+G_M19968_IG154:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Backwardnext():this]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG154:
+G_M19968_IG155:
        cmp      r15d, r14d
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        cmp      dword ptr [rbx+0x84], 4
-       jne      G_M19968_IG174
+       jne      G_M19968_IG175
        mov      r8d, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG155
+       jne      SHORT G_M19968_IG156
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG156
+       jmp      SHORT G_M19968_IG157
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M19968_IG155:
+G_M19968_IG156:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG156:
+G_M19968_IG157:
        mov      edx, r15d
        sub      edx, r14d
        dec      edx
        sub      r8d, ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M19968_IG157:
+G_M19968_IG158:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      r15d, dword ptr [rbx+0x88]
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
        cmp      r15d, eax
-       jg       SHORT G_M19968_IG158
-       jmp      SHORT G_M19968_IG159
+       jg       SHORT G_M19968_IG159
+       jmp      SHORT G_M19968_IG160
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M19968_IG158:
+G_M19968_IG159:
        mov      r15d, eax
 						;; size=3 bbWeight=0 PerfScore 0.00
-G_M19968_IG159:
+G_M19968_IG160:
        mov      rdx, gword ptr [rbx+0x70]
        mov      rdx, gword ptr [rdx+0x10]
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    rbp, word  ptr [rdx+4*rcx+0x10]
        mov      r14d, r15d
        test     r15d, r15d
-       jle      SHORT G_M19968_IG162
+       jle      SHORT G_M19968_IG163
 						;; size=38 bbWeight=0 PerfScore 0.00
-G_M19968_IG160:
+G_M19968_IG161:
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardcharnext(System.ReadOnlySpan`1[ushort]):ushort:this]
        cmp      eax, ebp
-       jne      SHORT G_M19968_IG161
+       jne      SHORT G_M19968_IG162
        dec      r14d
        test     r14d, r14d
-       jg       SHORT G_M19968_IG160
-       jmp      SHORT G_M19968_IG162
+       jg       SHORT G_M19968_IG161
+       jmp      SHORT G_M19968_IG163
 						;; size=37 bbWeight=0 PerfScore 0.00
-G_M19968_IG161:
+G_M19968_IG162:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Backwardnext():this]
 						;; size=9 bbWeight=0 PerfScore 0.00
-G_M19968_IG162:
+G_M19968_IG163:
        cmp      r15d, r14d
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        cmp      dword ptr [rbx+0x84], 3
-       jne      G_M19968_IG174
+       jne      G_M19968_IG175
        mov      r8d, dword ptr [rbx+0x4C]
        cmp      byte  ptr [rbx+0x69], 0
-       jne      SHORT G_M19968_IG163
+       jne      SHORT G_M19968_IG164
        mov      ecx, 1
-       jmp      SHORT G_M19968_IG164
+       jmp      SHORT G_M19968_IG165
 						;; size=39 bbWeight=0 PerfScore 0.00
-G_M19968_IG163:
+G_M19968_IG164:
        mov      ecx, -1
 						;; size=5 bbWeight=0 PerfScore 0.00
-G_M19968_IG164:
+G_M19968_IG165:
        mov      edx, r15d
        sub      edx, r14d
        dec      edx
        sub      r8d, ecx
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:TrackPush(int,int):this]
-       jmp      G_M19968_IG174
+       jmp      G_M19968_IG175
 						;; size=25 bbWeight=0 PerfScore 0.00
-G_M19968_IG165:
-       mov      eax, dword ptr [rbx+0x4C]
-       jmp      G_M19968_IG44
-						;; size=8 bbWeight=0 PerfScore 0.00
 G_M19968_IG166:
+       mov      eax, dword ptr [rbx+0x4C]
+       jmp      G_M19968_IG43
+						;; size=8 bbWeight=0 PerfScore 0.00
+G_M19968_IG167:
        mov      eax, dword ptr [rbx+0x4C]
        dec      eax
        mov      dword ptr [rbx+0x4C], eax
        jmp      G_M19968_IG46
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG167:
+G_M19968_IG168:
        cmp      ecx, 128
-       jl       SHORT G_M19968_IG168
+       jl       SHORT G_M19968_IG169
        mov      rdx, r12
        xor      r8d, r8d
        call     [System.Text.RegularExpressions.RegexCharClass:CharInClassRecursive(ushort,System.String,int):ubyte]
-       jmp      SHORT G_M19968_IG169
+       jmp      SHORT G_M19968_IG170
 						;; size=22 bbWeight=0 PerfScore 0.00
-G_M19968_IG168:
+G_M19968_IG169:
        mov      rdx, r12
        mov      r8, r13
        call     [System.Text.RegularExpressions.RegexCharClass:<CharInClass>g__InitializeValue|127_0(ushort,System.String,byref):ubyte]
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M19968_IG169:
+G_M19968_IG170:
        test     eax, eax
        je       G_M19968_IG12
-       jmp      G_M19968_IG47
+       jmp      G_M19968_IG48
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG170:
+G_M19968_IG171:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      r15d, dword ptr [rbx+0x88]
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
@@ -7823,14 +7824,14 @@ G_M19968_IG170:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    r14, word  ptr [rdx+4*rcx+0x10]
 						;; size=86 bbWeight=0 PerfScore 0.00
-G_M19968_IG171:
+G_M19968_IG172:
        lea      edx, [r15-0x01]
        mov      r13d, edx
        test     r15d, r15d
-       jle      G_M19968_IG174
+       jle      G_M19968_IG175
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7839,16 +7840,16 @@ G_M19968_IG171:
        cmp      eax, r14d
        mov      r15d, r13d
        je       G_M19968_IG12
-       jmp      SHORT G_M19968_IG171
+       jmp      SHORT G_M19968_IG172
 						;; size=53 bbWeight=0 PerfScore 0.00
-G_M19968_IG172:
+G_M19968_IG173:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      r15d, dword ptr [rbx+0x88]
        lea      eax, [r15+0x02]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      eax, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r15d, dword ptr [rcx+4*rax+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:Forwardchars():int:this]
@@ -7859,14 +7860,14 @@ G_M19968_IG172:
        mov      ecx, dword ptr [rbx+0x88]
        inc      ecx
        cmp      ecx, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        movzx    r14, word  ptr [rdx+4*rcx+0x10]
 						;; size=86 bbWeight=0 PerfScore 0.00
-G_M19968_IG173:
+G_M19968_IG174:
        lea      edx, [r15-0x01]
        mov      r13d, edx
        test     r15d, r15d
-       jle      SHORT G_M19968_IG174
+       jle      SHORT G_M19968_IG175
        mov      bword ptr [rsp+0x28], rsi
        mov      dword ptr [rsp+0x30], edi
        lea      rdx, [rsp+0x28]
@@ -7875,16 +7876,16 @@ G_M19968_IG173:
        cmp      eax, r14d
        mov      r15d, r13d
        jne      G_M19968_IG12
-       jmp      SHORT G_M19968_IG173
+       jmp      SHORT G_M19968_IG174
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M19968_IG174:
+G_M19968_IG175:
        mov      ebp, 2
        jmp      G_M19968_IG17
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG175:
+G_M19968_IG176:
        lea      r15d, [r14-0x118]
        cmp      r15d, 5
-       ja       SHORT G_M19968_IG176
+       ja       SHORT G_M19968_IG177
        mov      edx, r15d
        lea      r8, [reloc @RWD324]
        mov      r8d, dword ptr [r8+4*rdx]
@@ -7892,25 +7893,25 @@ G_M19968_IG175:
        add      r8, rcx
        jmp      r8
 						;; size=40 bbWeight=0 PerfScore 0.00
-G_M19968_IG176:
+G_M19968_IG177:
        cmp      r14d, 525
        jne      G_M19968_IG12
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG177:
+G_M19968_IG178:
        mov      r9, gword ptr [rbx+0x70]
        mov      rcx, gword ptr [r9+0x10]
        mov      r15d, dword ptr [rbx+0x88]
        lea      edx, [r15+0x01]
        mov      r11d, dword ptr [rcx+0x08]
        cmp      edx, r11d
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r14d, dword ptr [rcx+4*rdx+0x10]
        mov      rcx, gword ptr [rbx+0x28]
        mov      edx, r14d
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.Match:IsMatched(int):ubyte:this]
        test     eax, eax
-       je       SHORT G_M19968_IG178
+       je       SHORT G_M19968_IG179
        mov      rcx, gword ptr [rbx+0x28]
        mov      edx, r14d
        cmp      dword ptr [rcx], ecx
@@ -7932,19 +7933,19 @@ G_M19968_IG177:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:MatchRef(int,int,System.ReadOnlySpan`1[ushort],ubyte):ubyte:this]
        test     eax, eax
-       jne      SHORT G_M19968_IG179
+       jne      SHORT G_M19968_IG180
        jmp      G_M19968_IG12
 						;; size=147 bbWeight=0 PerfScore 0.00
-G_M19968_IG178:
+G_M19968_IG179:
        mov      rax, gword ptr [rbx+0x30]
        test     dword ptr [rax+0x40], 256
        je       G_M19968_IG12
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M19968_IG179:
+G_M19968_IG180:
        mov      ebp, 1
        jmp      G_M19968_IG17
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG180:
+G_M19968_IG181:
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
        mov      dword ptr [rbx+0x50], ecx
@@ -7952,38 +7953,38 @@ G_M19968_IG180:
        mov      rdx, gword ptr [rbx+0x10]
        lea      r8d, [rcx-0x01]
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x18]
        mov      ecx, dword ptr [rbx+0x54]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        dec      r8d
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
        jmp      G_M19968_IG12
 						;; size=77 bbWeight=0 PerfScore 0.00
-G_M19968_IG181:
+G_M19968_IG182:
        add      dword ptr [rbx+0x50], 2
        mov      rdx, gword ptr [rbx+0x10]
        mov      r8d, dword ptr [rbx+0x50]
        dec      r8d
        cmp      r8d, dword ptr [rdx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      edx, dword ptr [rdx+4*r8+0x10]
        mov      r8, gword ptr [rbx+0x10]
        mov      ecx, dword ptr [rbx+0x50]
        add      ecx, -2
        cmp      ecx, dword ptr [r8+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      r8d, dword ptr [r8+4*rcx+0x10]
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexInterpreter:StackPush(int,int):this]
        jmp      G_M19968_IG12
 						;; size=69 bbWeight=0 PerfScore 0.00
-G_M19968_IG182:
+G_M19968_IG183:
        inc      dword ptr [rbx+0x54]
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
@@ -7991,117 +7992,117 @@ G_M19968_IG182:
        mov      rax, gword ptr [rbx+0x10]
        dec      ecx
        cmp      ecx, dword ptr [rax+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      eax, dword ptr [rax+4*rcx+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      G_M19968_IG189
+       jae      G_M19968_IG190
        mov      dword ptr [rcx+4*rdx+0x10], eax
        jmp      G_M19968_IG12
 						;; size=60 bbWeight=0 PerfScore 0.00
-G_M19968_IG183:
+G_M19968_IG184:
        mov      ecx, dword ptr [rbx+0x50]
        inc      ecx
        mov      dword ptr [rbx+0x50], ecx
        mov      rax, gword ptr [rbx+0x10]
        dec      ecx
        cmp      ecx, dword ptr [rax+0x08]
-       jae      SHORT G_M19968_IG189
+       jae      SHORT G_M19968_IG190
        mov      eax, dword ptr [rax+4*rcx+0x10]
        mov      rcx, gword ptr [rbx+0x18]
        mov      edx, dword ptr [rbx+0x54]
        dec      edx
        mov      dword ptr [rbx+0x54], edx
        cmp      edx, dword ptr [rcx+0x08]
-       jae      SHORT G_M19968_IG189
+       jae      SHORT G_M19968_IG190
        mov      dword ptr [rcx+4*rdx+0x10], eax
        jmp      G_M19968_IG12
 						;; size=49 bbWeight=0 PerfScore 0.00
-G_M19968_IG184:
+G_M19968_IG185:
        call     <unknown method>
        cmp      rax, qword ptr [rbx+0x38]
        jl       G_M19968_IG13
 						;; size=15 bbWeight=0 PerfScore 0.00
-G_M19968_IG185:
+G_M19968_IG186:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:<CheckTimeout>g__ThrowRegexTimeout|25_0():this]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M19968_IG186:
+G_M19968_IG187:
        neg      r14d
        mov      ecx, 256
        jmp      G_M19968_IG14
 						;; size=13 bbWeight=0 PerfScore 0.00
-G_M19968_IG187:
+G_M19968_IG188:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleStack():this]
        jmp      G_M19968_IG15
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG188:
+G_M19968_IG189:
        mov      rcx, rbx
        call     [System.Text.RegularExpressions.RegexRunner:DoubleTrack():this]
        jmp      G_M19968_IG16
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M19968_IG189:
+G_M19968_IG190:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-RWD00  	dd	G_M19968_IG172 - G_M19968_IG02
-       	dd	G_M19968_IG170 - G_M19968_IG02
-       	dd	G_M19968_IG43 - G_M19968_IG02
-       	dd	G_M19968_IG157 - G_M19968_IG02
-       	dd	G_M19968_IG144 - G_M19968_IG02
-       	dd	G_M19968_IG33 - G_M19968_IG02
-       	dd	G_M19968_IG131 - G_M19968_IG02
-       	dd	G_M19968_IG131 - G_M19968_IG02
-       	dd	G_M19968_IG131 - G_M19968_IG02
-       	dd	G_M19968_IG30 - G_M19968_IG02
-       	dd	G_M19968_IG128 - G_M19968_IG02
+RWD00  	dd	G_M19968_IG173 - G_M19968_IG02
+       	dd	G_M19968_IG171 - G_M19968_IG02
+       	dd	G_M19968_IG42 - G_M19968_IG02
+       	dd	G_M19968_IG158 - G_M19968_IG02
+       	dd	G_M19968_IG145 - G_M19968_IG02
+       	dd	G_M19968_IG32 - G_M19968_IG02
+       	dd	G_M19968_IG132 - G_M19968_IG02
+       	dd	G_M19968_IG132 - G_M19968_IG02
+       	dd	G_M19968_IG132 - G_M19968_IG02
+       	dd	G_M19968_IG28 - G_M19968_IG02
+       	dd	G_M19968_IG129 - G_M19968_IG02
+       	dd	G_M19968_IG124 - G_M19968_IG02
        	dd	G_M19968_IG123 - G_M19968_IG02
-       	dd	G_M19968_IG122 - G_M19968_IG02
-       	dd	G_M19968_IG177 - G_M19968_IG02
+       	dd	G_M19968_IG178 - G_M19968_IG02
+       	dd	G_M19968_IG121 - G_M19968_IG02
        	dd	G_M19968_IG120 - G_M19968_IG02
-       	dd	G_M19968_IG119 - G_M19968_IG02
        	dd	G_M19968_IG25 - G_M19968_IG02
+       	dd	G_M19968_IG113 - G_M19968_IG02
        	dd	G_M19968_IG112 - G_M19968_IG02
        	dd	G_M19968_IG111 - G_M19968_IG02
        	dd	G_M19968_IG110 - G_M19968_IG02
        	dd	G_M19968_IG109 - G_M19968_IG02
-       	dd	G_M19968_IG108 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG24 - G_M19968_IG02
-       	dd	G_M19968_IG106 - G_M19968_IG02
-       	dd	G_M19968_IG103 - G_M19968_IG02
+       	dd	G_M19968_IG107 - G_M19968_IG02
+       	dd	G_M19968_IG104 - G_M19968_IG02
+       	dd	G_M19968_IG102 - G_M19968_IG02
        	dd	G_M19968_IG101 - G_M19968_IG02
-       	dd	G_M19968_IG100 - G_M19968_IG02
-       	dd	G_M19968_IG97 - G_M19968_IG02
-       	dd	G_M19968_IG95 - G_M19968_IG02
-       	dd	G_M19968_IG93 - G_M19968_IG02
+       	dd	G_M19968_IG98 - G_M19968_IG02
+       	dd	G_M19968_IG96 - G_M19968_IG02
+       	dd	G_M19968_IG94 - G_M19968_IG02
        	dd	G_M19968_IG23 - G_M19968_IG02
+       	dd	G_M19968_IG90 - G_M19968_IG02
        	dd	G_M19968_IG89 - G_M19968_IG02
-       	dd	G_M19968_IG88 - G_M19968_IG02
-       	dd	G_M19968_IG86 - G_M19968_IG02
+       	dd	G_M19968_IG87 - G_M19968_IG02
+       	dd	G_M19968_IG85 - G_M19968_IG02
        	dd	G_M19968_IG84 - G_M19968_IG02
        	dd	G_M19968_IG83 - G_M19968_IG02
        	dd	G_M19968_IG82 - G_M19968_IG02
-       	dd	G_M19968_IG81 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG21 - G_M19968_IG02
+       	dd	G_M19968_IG81 - G_M19968_IG02
        	dd	G_M19968_IG80 - G_M19968_IG02
+       	dd	G_M19968_IG158 - G_M19968_IG02
+       	dd	G_M19968_IG145 - G_M19968_IG02
+       	dd	G_M19968_IG32 - G_M19968_IG02
        	dd	G_M19968_IG79 - G_M19968_IG02
-       	dd	G_M19968_IG157 - G_M19968_IG02
-       	dd	G_M19968_IG144 - G_M19968_IG02
-       	dd	G_M19968_IG33 - G_M19968_IG02
-       	dd	G_M19968_IG78 - G_M19968_IG02
-RWD188 	dd	G_M19968_IG75 - G_M19968_IG02
-       	dd	G_M19968_IG75 - G_M19968_IG02
-       	dd	G_M19968_IG75 - G_M19968_IG02
-       	dd	G_M19968_IG72 - G_M19968_IG02
-       	dd	G_M19968_IG69 - G_M19968_IG02
-       	dd	G_M19968_IG62 - G_M19968_IG02
+RWD188 	dd	G_M19968_IG76 - G_M19968_IG02
+       	dd	G_M19968_IG76 - G_M19968_IG02
+       	dd	G_M19968_IG76 - G_M19968_IG02
+       	dd	G_M19968_IG73 - G_M19968_IG02
+       	dd	G_M19968_IG70 - G_M19968_IG02
+       	dd	G_M19968_IG63 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
@@ -8117,27 +8118,27 @@ RWD188 	dd	G_M19968_IG75 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG18 - G_M19968_IG02
+       	dd	G_M19968_IG60 - G_M19968_IG02
        	dd	G_M19968_IG59 - G_M19968_IG02
        	dd	G_M19968_IG58 - G_M19968_IG02
-       	dd	G_M19968_IG57 - G_M19968_IG02
-       	dd	G_M19968_IG57 - G_M19968_IG02
-       	dd	G_M19968_IG55 - G_M19968_IG02
+       	dd	G_M19968_IG58 - G_M19968_IG02
+       	dd	G_M19968_IG56 - G_M19968_IG02
+       	dd	G_M19968_IG53 - G_M19968_IG02
+       	dd	G_M19968_IG11 - G_M19968_IG02
+       	dd	G_M19968_IG11 - G_M19968_IG02
        	dd	G_M19968_IG52 - G_M19968_IG02
-       	dd	G_M19968_IG11 - G_M19968_IG02
-       	dd	G_M19968_IG11 - G_M19968_IG02
        	dd	G_M19968_IG51 - G_M19968_IG02
-       	dd	G_M19968_IG50 - G_M19968_IG02
-       	dd	G_M19968_IG57 - G_M19968_IG02
+       	dd	G_M19968_IG58 - G_M19968_IG02
+       	dd	G_M19968_IG12 - G_M19968_IG02
+       	dd	G_M19968_IG49 - G_M19968_IG02
+RWD324 	dd	G_M19968_IG184 - G_M19968_IG02
+       	dd	G_M19968_IG183 - G_M19968_IG02
+       	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG12 - G_M19968_IG02
-       	dd	G_M19968_IG48 - G_M19968_IG02
-RWD324 	dd	G_M19968_IG183 - G_M19968_IG02
        	dd	G_M19968_IG182 - G_M19968_IG02
-       	dd	G_M19968_IG12 - G_M19968_IG02
-       	dd	G_M19968_IG12 - G_M19968_IG02
        	dd	G_M19968_IG181 - G_M19968_IG02
-       	dd	G_M19968_IG180 - G_M19968_IG02
 
 
-; Total bytes of code 7498, prolog size 26, PerfScore 753.47, instruction count 1864, allocated bytes for code 7498 (MethodHash=588bb1ff) for method System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1)
+; Total bytes of code 7496, prolog size 26, PerfScore 747.72, instruction count 1863, allocated bytes for code 7496 (MethodHash=588bb1ff) for method System.Text.RegularExpressions.RegexInterpreter:TryMatchAtCurrentPosition(System.ReadOnlySpan`1[ushort]):ubyte:this (Tier1)
 ; ============================================================
 


```

### ``[System.Text.RegularExpressions]Regex.RunSingleMatch(value class System.Text.RegularExpressions.RegexRunnerMode,int32,class System.String,int32,int32,int32)``

```diff
 ; optimized using Dynamic PGO
 ; rbp based frame
 ; fully interruptible
-; with Dynamic PGO: fgCalledCount is 99520
+; with Dynamic PGO: fgCalledCount is 105504
 ; 7 inlinees with PGO data; 14 single block inlinees; 0 inlinees without PGO data
 ; Final local variable assignments
 ;
 ;  V00 this         [V00,T06] (  9,  6   )     ref  ->  [rbp+0x10]  this class-hnd EH-live single-def <System.Text.RegularExpressions.Regex>
-;  V01 arg1         [V01,T13] (  5,  3   )     int  ->  rsi         single-def
-;  V02 arg2         [V02,T14] (  3,  3   )     int  ->  rdi         single-def
+;  V01 arg1         [V01,T12] (  5,  3   )     int  ->  rsi         single-def
+;  V02 arg2         [V02,T13] (  3,  3   )     int  ->  rdi         single-def
 ;  V03 arg3         [V03,T08] (  6,  5   )     ref  ->  rbx         class-hnd single-def <System.String>
-;  V04 arg4         [V04,T23] (  4,  3   )     int  ->  r14         single-def
-;  V05 arg5         [V05,T25] (  3,  3   )     int  ->  r15         single-def
-;  V06 arg6         [V06,T31] (  2,  2   )     int  ->  r13         single-def
+;  V04 arg4         [V04,T22] (  4,  3   )     int  ->  r14         single-def
+;  V05 arg5         [V05,T24] (  3,  3   )     int  ->  r15         single-def
+;  V06 arg6         [V06,T32] (  2,  2   )     int  ->  r13         single-def
 ;  V07 loc0         [V07,T02] ( 42, 19.00)     ref  ->  [rbp-0x58]  class-hnd EH-live spill-single-def <System.Text.RegularExpressions.RegexRunner>
 ;* V08 loc1         [V08    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op <System.ReadOnlySpan`1[ushort]>
-;  V09 loc2         [V09,T46] (  3,  0   )     int  ->  rax        
-;  V10 loc3         [V10,T47] (  3,  0   )     int  ->  rcx        
-;  V11 loc4         [V11,T27] (  3,  2   )     ref  ->  r12         class-hnd <System.Text.RegularExpressions.Match>
+;  V09 loc2         [V09,T47] (  3,  0   )     int  ->  rax        
+;  V10 loc3         [V10,T48] (  3,  0   )     int  ->  rcx        
+;  V11 loc4         [V11,T28] (  3,  2   )     ref  ->  r12         class-hnd <System.Text.RegularExpressions.Match>
 ;  V12 OutArgs      [V12    ] (  1,  1   )  struct (40) [rsp+0x00]  do-not-enreg[XS] addr-exposed "OutgoingArgSpace"
-;  V13 tmp1         [V13,T17] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
-;  V14 tmp2         [V14,T12] (  6,  5   )     ref  ->  [rbp-0x60] 
+;  V13 tmp1         [V13,T16] (  2,  4   )     ref  ->  rax         class-hnd single-def "dup spill" <<unknown class>>
+;  V14 tmp2         [V14,T11] (  6,  5   )     ref  ->  [rbp-0x60] 
 ;* V15 tmp3         [V15    ] (  0,  0   )  struct (16) zero-ref    "Inline return value spill temp" <System.ReadOnlySpan`1[ushort]>
 ;* V16 tmp4         [V16    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "NewObj constructor temp" <System.ReadOnlySpan`1[ushort]>
 ;* V17 tmp5         [V17    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inline ldloca(s) first use temp" <System.ReadOnlySpan`1[ushort]>
@@ -465,59 +465,60 @@ G_M21592_IG22:
 ;  V19 tmp7         [V19,T10] (  3,  6   )     int  ->  r13         "Inlining Arg"
 ;* V20 tmp8         [V20    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;  V21 tmp9         [V21,T07] (  8,  8.00)     ref  ->  r13         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
-;  V22 tmp10        [V22,T49] (  2,  0   )     int  ->  rdx         "dup spill"
-;  V23 tmp11        [V23,T42] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
-;  V24 tmp12        [V24,T43] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
+;  V22 tmp10        [V22,T50] (  2,  0   )     int  ->  rdx         "dup spill"
+;  V23 tmp11        [V23,T43] (  8,  0   )     int  ->  [rbp-0x3C]  "Inline stloc first use temp"
+;  V24 tmp12        [V24,T44] (  5,  0   )     int  ->  [rbp-0x40]  "Inline stloc first use temp"
 ;* V25 tmp13        [V25    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V26 tmp14        [V26,T44] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
+;  V26 tmp14        [V26,T45] (  3,  0   )     ref  ->  [rbp-0x68]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.Match>
 ;* V27 tmp15        [V27    ] (  0,  0   )     ref  ->  zero-ref   
-;  V28 tmp16        [V28,T41] (  3,  0.00)     ref  ->  rdx        
-;  V29 tmp17        [V29,T36] (  4,  0.00)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
-;  V30 tmp18        [V30,T38] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
+;  V28 tmp16        [V28,T42] (  3,  0.00)     ref  ->  rdx        
+;  V29 tmp17        [V29,T37] (  4,  0.01)     ref  ->  [rbp-0x70]  class-hnd exact spill-single-def "NewObj constructor temp" <System.Text.RegularExpressions.MatchSparse>
+;  V30 tmp18        [V30,T39] (  2,  0.00)     ref  ->  rax         class-hnd single-def "Inlining Arg" <System.Text.RegularExpressions.Regex>
 ;* V31 tmp19        [V31    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
 ;* V32 tmp20        [V32    ] (  0,  0   )     ref  ->  zero-ref    class-hnd exact "Inlining Arg" <System.String>
 ;* V33 tmp21        [V33    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V34 tmp22        [V34,T39] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
-;  V35 tmp23        [V35,T19] (  2,  4.00)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
+;  V34 tmp22        [V34,T40] (  2,  0.00)     ref  ->  [rbp-0x78]  class-hnd spill-single-def "Inlining Arg" <System.Collections.Hashtable>
+;  V35 tmp23        [V35,T18] (  2,  4.00)     ref  ->  rax         class-hnd exact single-def "Inlining Arg" <System.String>
 ;* V36 tmp24        [V36    ] (  0,  0   )     int  ->  zero-ref    "Inlining Arg"
-;  V37 tmp25        [V37,T20] (  3,  3.01)     ref  ->  rcx         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
-;* V38 tmp26        [V38,T35] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
-;  V39 tmp27        [V39,T18] (  3,  4.00)     ref  ->  r13         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
+;  V37 tmp25        [V37,T25] (  3,  2.50)     ref  ->  rax         class-hnd single-def "Inline stloc first use temp" <<unknown class>>
+;* V38 tmp26        [V38,T36] (  0,  0   )     int  ->  zero-ref    "Inline stloc first use temp"
+;  V39 tmp27        [V39,T17] (  3,  4.00)     ref  ->  r11         class-hnd single-def "dup spill" <System.Text.RegularExpressions.GroupCollection>
 ;* V40 tmp28        [V40    ] (  0,  0   )     ref  ->  zero-ref    single-def
-;  V41 tmp29        [V41,T26] (  4,  2   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
+;  V41 tmp29        [V41,T27] (  4,  2   )     ref  ->  r12         class-hnd "Inline return value spill temp" <System.Text.RegularExpressions.Match>
 ;* V42 tmp30        [V42    ] (  0,  0   )  struct (16) zero-ref    "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
-;  V43 tmp31        [V43,T22] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
+;  V43 tmp31        [V43,T21] (  7,  3   )     ref  ->  r12         class-hnd single-def "Inline stloc first use temp" <System.Text.RegularExpressions.Match>
 ;* V44 tmp32        [V44    ] (  0,  0   )   ubyte  ->  zero-ref    "Inlining Arg"
-;  V45 tmp33        [V45,T00] ( 32, 56.65)     ref  ->  r13         class-hnd exact single-def "guarded devirt this exact temp" <System.Text.RegularExpressions.RegexInterpreter>
+;  V45 tmp33        [V45,T00] ( 32, 57.70)     ref  ->  rdi         class-hnd exact single-def "guarded devirt this exact temp" <System.Text.RegularExpressions.RegexInterpreter>
 ;* V46 tmp34        [V46    ] (  0,  0   )  struct (16) zero-ref    ld-addr-op "Inlining Arg" <System.ReadOnlySpan`1[ushort]>
 ;* V47 tmp35        [V47    ] (  0,  0   )     ref  ->  zero-ref    class-hnd "Inlining Arg" <System.Text.RegularExpressions.Regex>
-;  V48 tmp36        [V48,T28] (  3,  2   )   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
-;  V49 tmp37        [V49,T15] (  8,  4   )     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
-;  V50 tmp38        [V50,T29] (  2,  2   )   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
-;  V51 tmp39        [V51,T32] (  2,  2   )     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
-;  V52 tmp40        [V52,T30] (  2,  2   )   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
-;  V53 tmp41        [V53,T33] (  2,  2   )     int  ->  r15         "field V16._length (fldOffset=0x8)" P-INDEP
+;  V48 tmp36        [V48,T29] (  3,  2   )   byref  ->  r12         single-def "field V08._reference (fldOffset=0x0)" P-INDEP
+;  V49 tmp37        [V49,T14] (  8,  4   )     int  ->  r15         "field V08._length (fldOffset=0x8)" P-INDEP
+;  V50 tmp38        [V50,T30] (  2,  2   )   byref  ->  r12         single-def "field V15._reference (fldOffset=0x0)" P-INDEP
+;  V51 tmp39        [V51,T33] (  2,  2   )     int  ->  r15         "field V15._length (fldOffset=0x8)" P-INDEP
+;  V52 tmp40        [V52,T31] (  2,  2   )   byref  ->  r12         single-def "field V16._reference (fldOffset=0x0)" P-INDEP
+;  V53 tmp41        [V53,T34] (  2,  2   )     int  ->  r15         "field V16._length (fldOffset=0x8)" P-INDEP
 ;* V54 tmp42        [V54    ] (  0,  0   )   byref  ->  zero-ref    "field V17._reference (fldOffset=0x0)" P-INDEP
 ;* V55 tmp43        [V55    ] (  0,  0   )     int  ->  zero-ref    "field V17._length (fldOffset=0x8)" P-INDEP
 ;* V56 tmp44        [V56    ] (  0,  0   )   byref  ->  zero-ref    "field V20._reference (fldOffset=0x0)" P-INDEP
 ;* V57 tmp45        [V57    ] (  0,  0   )     int  ->  zero-ref    "field V20._length (fldOffset=0x8)" P-INDEP
 ;* V58 tmp46        [V58    ] (  0,  0   )   byref  ->  zero-ref    single-def "field V42._reference (fldOffset=0x0)" P-INDEP
 ;* V59 tmp47        [V59    ] (  0,  0   )     int  ->  zero-ref    "field V42._length (fldOffset=0x8)" P-INDEP
-;  V60 tmp48        [V60,T05] (  5,  9.95)   byref  ->  r12         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
-;  V61 tmp49        [V61,T03] (  6, 13.92)     int  ->  r15         "field V46._length (fldOffset=0x8)" P-INDEP
-;  V62 tmp50        [V62,T45] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
-;  V63 tmp51        [V63    ] ( 15, 53.67)  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
-;  V64 tmp52        [V64,T48] (  2,  0   )     ref  ->  rcx         "argument with side effect"
-;  V65 tmp53        [V65,T01] (  2, 19.89)     ref  ->  rcx         "argument with side effect"
+;  V60 tmp48        [V60,T05] (  5, 10.11)   byref  ->  r12         single-def "field V46._reference (fldOffset=0x0)" P-INDEP
+;  V61 tmp49        [V61,T03] (  6, 14.16)     int  ->  r15         "field V46._length (fldOffset=0x8)" P-INDEP
+;  V62 tmp50        [V62,T46] (  3,  0   )     ref  ->  rax         single-def "argument with side effect"
+;  V63 tmp51        [V63    ] ( 15, 54.65)  struct (16) [rbp-0x50]  do-not-enreg[XSF] must-init addr-exposed "by-value struct argument" <System.ReadOnlySpan`1[ushort]>
+;  V64 tmp52        [V64,T49] (  2,  0   )     ref  ->  rcx         "argument with side effect"
+;  V65 tmp53        [V65,T01] (  2, 20.22)     ref  ->  rcx         "argument with side effect"
 ;  V66 tmp54        [V66,T09] (  3,  6   )     ref  ->  rcx         single-def "arr expr"
-;  V67 PSPSym       [V67,T34] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
-;  V68 cse0         [V68,T40] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
-;  V69 cse1         [V69,T04] (  3, 11.92)     int  ->  rcx         "CSE #12: aggressive"
-;  V70 cse2         [V70,T24] (  3,  3   )     ref  ->  rcx         "CSE #08: moderate"
-;  V71 cse3         [V71,T37] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
-;  V72 cse4         [V72,T16] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
-;  V73 cse5         [V73,T21] (  3,  3.01)     int  ->   r9         "CSE #07: moderate"
-;  V74 rat0         [V74,T11] (  5,  5.04)    long  ->  rdx         "Widened IV V38"
+;  V67 PSPSym       [V67,T35] (  1,  1   )    long  ->  [rbp-0x88]  do-not-enreg[V] "PSPSym"
+;  V68 cse0         [V68,T41] (  3,  0.00)     ref  ->  [rbp-0x80]  spill-single-def "CSE #04: conservative"
+;  V69 cse1         [V69,T04] (  3, 12.16)     int  ->  rcx         "CSE #12: aggressive"
+;  V70 cse2         [V70,T23] (  3,  3   )     ref  ->  rcx         "CSE #08: moderate"
+;  V71 cse3         [V71,T38] (  6,  0.00)     ref  ->  r13         "CSE #03: conservative"
+;  V72 cse4         [V72,T15] (  4,  4   )     int  ->  r12         "CSE #01: moderate"
+;  V73 cse5         [V73,T26] (  3,  2.50)     int  ->  r10         "CSE #07: moderate"
+;  V74 rat0         [V74,T19] (  4,  3.49)   byref  ->  rax         "Strength reduced derived IV"
+;  V75 rat1         [V75,T20] (  4,  3.49)     int  ->  r10         "Trip count IV"
 ;
 ; Lcl frame size = 120
 
@@ -546,14 +547,14 @@ G_M21592_IG01:
 G_M21592_IG02:
        mov      r12d, dword ptr [rbx+0x08]
        cmp      r12d, r13d
-       jb       G_M21592_IG40
+       jb       G_M21592_IG42
        cmp      r12d, r15d
-       jb       G_M21592_IG39
+       jb       G_M21592_IG41
        lea      rdx, bword ptr [rcx+0x38]
        xor      rax, rax
        xchg     gword ptr [rdx], rax
        test     rax, rax
-       je       G_M21592_IG38
+       je       G_M21592_IG40
 						;; size=40 bbWeight=1 PerfScore 26.50
 G_M21592_IG03:
        mov      gword ptr [rbp-0x58], rax
@@ -573,7 +574,7 @@ G_M21592_IG04:
        add      rcx, rdx
        mov      edx, r12d
        cmp      rcx, rdx
-       ja       G_M21592_IG34
+       ja       G_M21592_IG36
        mov      ecx, r14d
        lea      r12, bword ptr [rbx+2*rcx+0x0C]
        sub      r13d, r14d
@@ -590,7 +591,7 @@ G_M21592_IG04:
        mov      dword ptr [rdx+0x4C], r13d
        mov      r13, gword ptr [rdx+0x28]
        test     r13, r13
-       je       G_M21592_IG16
+       je       G_M21592_IG18
 						;; size=121 bbWeight=1 PerfScore 28.75
 G_M21592_IG05:
        mov      rax, gword ptr [rdx+0x08]
@@ -600,30 +601,22 @@ G_M21592_IG05:
        xor      ecx, ecx
        mov      dword ptr [r13+0x34], ecx
        mov      dword ptr [r13+0x5C], r15d
-       mov      rcx, gword ptr [r13+0x50]
-       xor      edx, edx
-       mov      r9d, dword ptr [rcx+0x08]
-       test     r9d, r9d
-       jle      SHORT G_M21592_IG07
-						;; size=41 bbWeight=1.00 PerfScore 11.49
+       mov      rax, gword ptr [r13+0x50]
+       mov      r10d, dword ptr [rax+0x08]
+       test     r10d, r10d
+       jg       G_M21592_IG16
+						;; size=43 bbWeight=1.00 PerfScore 11.24
 G_M21592_IG06:
-       xor      r8d, r8d
-       mov      dword ptr [rcx+4*rdx+0x10], r8d
-       inc      edx
-       cmp      r9d, edx
-       jg       SHORT G_M21592_IG06
-						;; size=15 bbWeight=1.01 PerfScore 2.78
-G_M21592_IG07:
        mov      byte  ptr [r13+0x60], 0
-       mov      r13, gword ptr [r13+0x38]
-       test     r13, r13
-       jne      G_M21592_IG20
+       mov      r11, gword ptr [r13+0x38]
+       test     r11, r11
+       jne      G_M21592_IG22
 						;; size=18 bbWeight=1.00 PerfScore 4.25
-G_M21592_IG08:
+G_M21592_IG07:
        mov      rdx, gword ptr [rbp-0x58]
        mov      rcx, gword ptr [rdx+0x20]
        test     rcx, rcx
-       je       G_M21592_IG22
+       je       G_M21592_IG24
        mov      r9, gword ptr [rdx+0x10]
        mov      r9d, dword ptr [r9+0x08]
        mov      dword ptr [rdx+0x50], r9d
@@ -633,71 +626,84 @@ G_M21592_IG08:
        mov      ecx, dword ptr [rcx+0x08]
        mov      dword ptr [rdx+0x58], ecx
 						;; size=47 bbWeight=1 PerfScore 17.25
-G_M21592_IG09:
+G_M21592_IG08:
        test     edi, edi
-       je       G_M21592_IG23
+       je       G_M21592_IG25
 						;; size=8 bbWeight=1 PerfScore 1.25
-G_M21592_IG10:
+G_M21592_IG09:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.RegexInterpreter
        cmp      qword ptr [rdx], rcx
-       jne      G_M21592_IG30
-       mov      r13, rdx
-       mov      rcx, gword ptr [r13+0x30]
+       jne      G_M21592_IG32
+						;; size=19 bbWeight=1 PerfScore 4.25
+G_M21592_IG10:
+       mov      rdi, rdx
+       mov      rcx, gword ptr [rdi+0x30]
        test     byte  ptr [rcx+0x40], 64
        je       SHORT G_M21592_IG12
-       jmp      G_M21592_IG27
-						;; size=37 bbWeight=1 PerfScore 12.50
+       jmp      G_M21592_IG29
+						;; size=18 bbWeight=1.00 PerfScore 8.25
 G_M21592_IG11:
-       mov      rax, gword ptr [r13+0x10]
+       mov      rax, gword ptr [rdi+0x10]
        mov      eax, dword ptr [rax+0x08]
-       mov      dword ptr [r13+0x50], eax
-       mov      rax, gword ptr [r13+0x18]
+       mov      dword ptr [rdi+0x50], eax
+       mov      rax, gword ptr [rdi+0x18]
        mov      eax, dword ptr [rax+0x08]
-       mov      dword ptr [r13+0x54], eax
-       mov      rax, gword ptr [r13+0x20]
+       mov      dword ptr [rdi+0x54], eax
+       mov      rax, gword ptr [rdi+0x20]
        mov      eax, dword ptr [rax+0x08]
-       mov      dword ptr [r13+0x58], eax
+       mov      dword ptr [rdi+0x58], eax
        inc      ecx
-       mov      dword ptr [r13+0x4C], ecx
-						;; size=39 bbWeight=3.97 PerfScore 64.56
+       mov      dword ptr [rdi+0x4C], ecx
+						;; size=35 bbWeight=4.05 PerfScore 65.87
 G_M21592_IG12:
-       mov      rcx, gword ptr [r13+0x70]
+       mov      rcx, gword ptr [rdi+0x70]
        mov      rcx, gword ptr [rcx+0x08]
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
        lea      rdx, [rbp-0x50]
-       mov      r9d, dword ptr [r13+0x48]
-       lea      r8, bword ptr [r13+0x4C]
+       mov      r9d, dword ptr [rdi+0x48]
+       lea      r8, bword ptr [rdi+0x4C]
        cmp      dword ptr [rcx], ecx
        call     [<unknown method>]
        test     eax, eax
-       je       G_M21592_IG18
-						;; size=44 bbWeight=4.97 PerfScore 80.81
+       je       G_M21592_IG20
+						;; size=44 bbWeight=5.05 PerfScore 82.12
 G_M21592_IG13:
-       cmp      byte  ptr [r13+0x68], 0
-       jne      G_M21592_IG26
-						;; size=11 bbWeight=3.97 PerfScore 15.89
+       cmp      byte  ptr [rdi+0x68], 0
+       jne      G_M21592_IG28
+						;; size=10 bbWeight=4.05 PerfScore 16.22
 G_M21592_IG14:
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
        lea      rdx, [rbp-0x50]
-       mov      rcx, r13
+       mov      rcx, rdi
        call     [<unknown method>]
        test     eax, eax
-       jne      G_M21592_IG18
-						;; size=29 bbWeight=3.97 PerfScore 27.81
+       jne      G_M21592_IG20
+						;; size=29 bbWeight=4.05 PerfScore 28.38
 G_M21592_IG15:
-       mov      ecx, dword ptr [r13+0x4C]
+       mov      ecx, dword ptr [rdi+0x4C]
        cmp      ecx, r15d
-       je       SHORT G_M21592_IG18
+       je       G_M21592_IG20
        jmp      G_M21592_IG11
-						;; size=14 bbWeight=3.97 PerfScore 20.86
+						;; size=17 bbWeight=4.05 PerfScore 21.28
 G_M21592_IG16:
+       add      rax, 16
+						;; size=4 bbWeight=0.50 PerfScore 0.12
+G_M21592_IG17:
+       xor      ecx, ecx
+       mov      dword ptr [rax], ecx
+       add      rax, 4
+       dec      r10d
+       jne      SHORT G_M21592_IG17
+       jmp      G_M21592_IG06
+						;; size=18 bbWeight=1.00 PerfScore 4.73
+G_M21592_IG18:
        mov      r13, gword ptr [rdx+0x30]
        mov      rax, gword ptr [r13+0x18]
        mov      gword ptr [rbp-0x80], rax
        test     rax, rax
-       je       G_M21592_IG21
+       je       G_M21592_IG23
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.MatchSparse
        call     CORINFO_HELP_NEWSFAST
        mov      rdx, rax
@@ -717,34 +723,34 @@ G_M21592_IG16:
        mov      rdx, gword ptr [rbp-0x78]
        call     CORINFO_HELP_ASSIGN_REF
        mov      rdx, gword ptr [rbp-0x70]
-						;; size=104 bbWeight=0.00 PerfScore 0.01
-G_M21592_IG17:
+						;; size=104 bbWeight=0.00 PerfScore 0.02
+G_M21592_IG19:
        lea      rcx, bword ptr [r13+0x28]
        call     CORINFO_HELP_ASSIGN_REF
-       jmp      G_M21592_IG08
+       jmp      G_M21592_IG07
 						;; size=14 bbWeight=0.00 PerfScore 0.00
-G_M21592_IG18:
+G_M21592_IG20:
        mov      r13, gword ptr [rbp-0x58]
        mov      r12, gword ptr [r13+0x28]
        mov      rcx, gword ptr [r12+0x50]
        cmp      dword ptr [rcx+0x08], 0
-       jbe      G_M21592_IG35
+       jbe      G_M21592_IG37
        cmp      dword ptr [rcx+0x10], 0
-       jg       G_M21592_IG31
+       jg       G_M21592_IG33
        xor      rcx, rcx
        mov      gword ptr [r12+0x08], rcx
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      r12, gword ptr [rcx]
 						;; size=53 bbWeight=1 PerfScore 16.50
-G_M21592_IG19:
-       jmp      G_M21592_IG36
-						;; size=5 bbWeight=1 PerfScore 2.00
-G_M21592_IG20:
-       xor      rcx, rcx
-       mov      gword ptr [r13+0x18], rcx
-       jmp      G_M21592_IG08
-						;; size=11 bbWeight=0 PerfScore 0.00
 G_M21592_IG21:
+       jmp      G_M21592_IG38
+						;; size=5 bbWeight=1 PerfScore 2.00
+G_M21592_IG22:
+       xor      rcx, rcx
+       mov      gword ptr [r11+0x18], rcx
+       jmp      G_M21592_IG07
+						;; size=11 bbWeight=0 PerfScore 0.00
+G_M21592_IG23:
        mov      rcx, 0xD1FFAB1E      ; System.Text.RegularExpressions.Match
        call     CORINFO_HELP_NEWSFAST
        mov      gword ptr [rbp-0x68], rax
@@ -756,9 +762,9 @@ G_M21592_IG21:
        mov      rcx, gword ptr [rbp-0x68]
        call     [System.Text.RegularExpressions.Match:.ctor(System.Text.RegularExpressions.Regex,int,System.String,int):this]
        mov      rdx, gword ptr [rbp-0x68]
-       jmp      G_M21592_IG17
+       jmp      G_M21592_IG19
 						;; size=58 bbWeight=0 PerfScore 0.00
-G_M21592_IG22:
+G_M21592_IG24:
        mov      rcx, rdx
        mov      rax, qword ptr [rdx]
        mov      rax, qword ptr [rax+0x40]
@@ -799,82 +805,82 @@ G_M21592_IG22:
        call     CORINFO_HELP_ASSIGN_REF
        mov      dword ptr [r13+0x58], 32
        mov      rdx, r13
-       jmp      G_M21592_IG09
+       jmp      G_M21592_IG08
 						;; size=177 bbWeight=0 PerfScore 0.00
-G_M21592_IG23:
+G_M21592_IG25:
        mov      eax, r15d
        mov      ecx, 1
        mov      r8, gword ptr [rbp+0x10]
        test     byte  ptr [r8+0x40], 64
-       je       SHORT G_M21592_IG24
+       je       SHORT G_M21592_IG26
        xor      eax, eax
        mov      ecx, -1
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M21592_IG24:
+G_M21592_IG26:
        cmp      dword ptr [rdx+0x48], eax
-       jne      SHORT G_M21592_IG25
+       jne      SHORT G_M21592_IG27
        mov      rcx, 0xD1FFAB1E      ; const ptr
        mov      r12, gword ptr [rcx]
        mov      r13, rdx
-       jmp      G_M21592_IG36
+       jmp      G_M21592_IG38
 						;; size=26 bbWeight=0 PerfScore 0.00
-G_M21592_IG25:
+G_M21592_IG27:
        add      dword ptr [rdx+0x4C], ecx
        mov      rdx, gword ptr [rbp-0x58]
-       jmp      G_M21592_IG10
+       jmp      G_M21592_IG09
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M21592_IG26:
+G_M21592_IG28:
        call     <unknown method>
-       cmp      rax, qword ptr [r13+0x38]
+       cmp      rax, qword ptr [rdi+0x38]
        jl       G_M21592_IG14
-       jmp      SHORT G_M21592_IG28
+       jmp      SHORT G_M21592_IG30
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M21592_IG27:
-       mov      rcx, gword ptr [r13+0x70]
+G_M21592_IG29:
+       mov      rcx, gword ptr [rdi+0x70]
        mov      rcx, gword ptr [rcx+0x08]
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
        lea      rdx, [rbp-0x50]
-       mov      r9d, dword ptr [r13+0x48]
-       lea      r8, bword ptr [r13+0x4C]
+       mov      r9d, dword ptr [rdi+0x48]
+       lea      r8, bword ptr [rdi+0x4C]
        cmp      dword ptr [rcx], ecx
        call     [System.Text.RegularExpressions.RegexFindOptimizations:TryFindNextStartingPositionRightToLeft(System.ReadOnlySpan`1[ushort],byref,int):ubyte:this]
        test     eax, eax
-       je       G_M21592_IG18
-       cmp      byte  ptr [r13+0x68], 0
-       je       SHORT G_M21592_IG29
+       je       G_M21592_IG20
+       cmp      byte  ptr [rdi+0x68], 0
+       je       SHORT G_M21592_IG31
        call     <unknown method>
-       cmp      rax, qword ptr [r13+0x38]
-       jl       SHORT G_M21592_IG29
-						;; size=62 bbWeight=0 PerfScore 0.00
-G_M21592_IG28:
-       mov      rcx, r13
+       cmp      rax, qword ptr [rdi+0x38]
+       jl       SHORT G_M21592_IG31
+						;; size=61 bbWeight=0 PerfScore 0.00
+G_M21592_IG30:
+       mov      rcx, rdi
        call     [System.Text.RegularExpressions.RegexRunner:<CheckTimeout>g__ThrowRegexTimeout|25_0():this]
        int3     
 						;; size=10 bbWeight=0 PerfScore 0.00
-G_M21592_IG29:
+G_M21592_IG31:
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
        lea      rdx, [rbp-0x50]
-       mov      rcx, r13
+       mov      rcx, rdi
        call     [<unknown method>]
        test     eax, eax
-       jne      G_M21592_IG18
-       cmp      dword ptr [r13+0x4C], 0
-       je       G_M21592_IG18
-       mov      rdx, gword ptr [r13+0x10]
+       jne      G_M21592_IG20
+       cmp      dword ptr [rdi+0x4C], 0
+       je       G_M21592_IG20
+       mov      rdx, gword ptr [rdi+0x10]
        mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r13+0x50], edx
-       mov      rdx, gword ptr [r13+0x18]
+       mov      dword ptr [rdi+0x50], edx
+       mov      rdx, gword ptr [rdi+0x18]
        mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r13+0x54], edx
-       mov      rdx, gword ptr [r13+0x20]
+       mov      dword ptr [rdi+0x54], edx
+       mov      rdx, gword ptr [rdi+0x20]
        mov      edx, dword ptr [rdx+0x08]
-       mov      dword ptr [r13+0x58], edx
-       dec      dword ptr [r13+0x4C]
-       jmp      G_M21592_IG27
-						;; size=82 bbWeight=0 PerfScore 0.00
-G_M21592_IG30:
+       mov      dword ptr [rdi+0x58], edx
+       dec      dword ptr [rdi+0x4C]
+       jmp      G_M21592_IG29
+						;; size=77 bbWeight=0 PerfScore 0.00
+G_M21592_IG32:
        mov      bword ptr [rbp-0x50], r12
        mov      dword ptr [rbp-0x48], r15d
        lea      rdx, [rbp-0x50]
@@ -882,11 +888,11 @@ G_M21592_IG30:
        mov      rax, qword ptr [rcx]
        mov      rax, qword ptr [rax+0x40]
        call     [rax+0x20]<unknown method>
-       jmp      G_M21592_IG18
+       jmp      G_M21592_IG20
 						;; size=31 bbWeight=0 PerfScore 0.00
-G_M21592_IG31:
+G_M21592_IG33:
        test     esi, esi
-       je       SHORT G_M21592_IG32
+       je       SHORT G_M21592_IG34
        lea      rcx, bword ptr [r12+0x08]
        mov      rdx, rbx
        call     CORINFO_HELP_ASSIGN_REF
@@ -897,26 +903,26 @@ G_M21592_IG31:
        mov      r8d, r14d
        mov      r9d, esi
        call     [System.Text.RegularExpressions.Match:Tidy(int,int,int):this]
-       jmp      G_M21592_IG19
+       jmp      G_M21592_IG21
 						;; size=47 bbWeight=0 PerfScore 0.00
-G_M21592_IG32:
+G_M21592_IG34:
        xor      rcx, rcx
        mov      gword ptr [r12+0x08], rcx
 						;; size=7 bbWeight=0 PerfScore 0.00
-G_M21592_IG33:
+G_M21592_IG35:
        xor      r12, r12
-       jmp      G_M21592_IG19
+       jmp      G_M21592_IG21
 						;; size=8 bbWeight=0 PerfScore 0.00
-G_M21592_IG34:
+G_M21592_IG36:
        mov      ecx, 33
        call     [System.ThrowHelper:ThrowArgumentOutOfRangeException(int)]
        int3     
 						;; size=12 bbWeight=0 PerfScore 0.00
-G_M21592_IG35:
+G_M21592_IG37:
        call     CORINFO_HELP_RNGCHKFAIL
        int3     
 						;; size=6 bbWeight=0 PerfScore 0.00
-G_M21592_IG36:
+G_M21592_IG38:
        xor      rcx, rcx
        mov      gword ptr [r13+0x08], rcx
        mov      rdx, gword ptr [rbp+0x10]
@@ -925,7 +931,7 @@ G_M21592_IG36:
        call     CORINFO_HELP_ASSIGN_REF
        mov      rax, r12
 						;; size=25 bbWeight=1 PerfScore 4.25
-G_M21592_IG37:
+G_M21592_IG39:
        add      rsp, 120
        pop      rbx
        pop      rsi
@@ -937,7 +943,7 @@ G_M21592_IG37:
        pop      rbp
        ret      
 						;; size=17 bbWeight=1 PerfScore 5.25
-G_M21592_IG38:
+G_M21592_IG40:
        mov      rax, gword ptr [rcx+0x10]
        mov      rcx, rax
        mov      rax, qword ptr [rax]
@@ -948,19 +954,19 @@ G_M21592_IG38:
        mov      rcx, gword ptr [rbp+0x10]
        jmp      G_M21592_IG03
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M21592_IG39:
+G_M21592_IG41:
        mov      ecx, 8
        mov      edx, 2
        call     [System.Text.RegularExpressions.ThrowHelper:ThrowArgumentOutOfRangeException(int,int)]
        int3     
 						;; size=17 bbWeight=0 PerfScore 0.00
-G_M21592_IG40:
+G_M21592_IG42:
        mov      ecx, 14
        xor      edx, edx
        call     [System.Text.RegularExpressions.ThrowHelper:ThrowArgumentOutOfRangeException(int,int)]
        int3     
 						;; size=14 bbWeight=0 PerfScore 0.00
-G_M21592_IG41:
+G_M21592_IG43:
        push     rbp
        push     r15
        push     r14
@@ -974,7 +980,7 @@ G_M21592_IG41:
        mov      qword ptr [rsp+0x28], rbp
        lea      rbp, [rbp+0xB0]
 						;; size=32 bbWeight=0 PerfScore 0.00
-G_M21592_IG42:
+G_M21592_IG44:
        xor      rcx, rcx
        mov      r13, gword ptr [rbp-0x58]
        mov      gword ptr [r13+0x08], rcx
@@ -984,7 +990,7 @@ G_M21592_IG42:
        call     CORINFO_HELP_ASSIGN_REF
        nop      
 						;; size=27 bbWeight=0 PerfScore 0.00
-G_M21592_IG43:
+G_M21592_IG45:
        add      rsp, 56
        pop      rbx
        pop      rsi
@@ -997,6 +1003,6 @@ G_M21592_IG43:
        ret      
 						;; size=17 bbWeight=0 PerfScore 0.00
 
-; Total bytes of code 1478, prolog size 61, PerfScore 359.46, instruction count 389, allocated bytes for code 1478 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
+; Total bytes of code 1479, prolog size 61, PerfScore 365.23, instruction count 390, allocated bytes for code 1479 (MethodHash=777caba7) for method System.Text.RegularExpressions.Regex:RunSingleMatch(int,int,System.String,int,int,int):System.Text.RegularExpressions.Match:this (Tier1)
 ; ============================================================
 


```

</details>

# ``System.Tests.Perf_String.Concat_CharEnumerable``

Hot functions:

- (88.59%) ``String.JoinCore`` (Tier-1)
  - No diffs
- (1.35%) ``ValueStringBuilder.Grow`` (Tier-1)
  - No diffs
- (1.32%) ``SpanHelpers.Memmove`` (Tier-1)
  - No diffs

# ``Struct.SpanWrapper.WrapperSum``

Hot functions:

- (98.00%) ``SpanWrapper.SumSpanWrapper`` (Tier-1)
  - No diffs

