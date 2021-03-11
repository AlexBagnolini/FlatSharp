// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpTests.Oracle
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct NestedStructs : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static NestedStructs GetRootAsNestedStructs(ByteBuffer _bb) { return GetRootAsNestedStructs(_bb, new NestedStructs()); }
  public static NestedStructs GetRootAsNestedStructs(ByteBuffer _bb, NestedStructs obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public NestedStructs __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatSharpTests.Oracle.OuterStruct? Outer { get { int o = __p.__offset(4); return o != 0 ? (FlatSharpTests.Oracle.OuterStruct?)(new FlatSharpTests.Oracle.OuterStruct()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartNestedStructs(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddOuter(FlatBufferBuilder builder, Offset<FlatSharpTests.Oracle.OuterStruct> OuterOffset) { builder.AddStruct(0, OuterOffset.Value, 0); }
  public static Offset<FlatSharpTests.Oracle.NestedStructs> EndNestedStructs(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatSharpTests.Oracle.NestedStructs>(o);
  }
  public NestedStructsT UnPack() {
    var _o = new NestedStructsT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(NestedStructsT _o) {
    _o.Outer = this.Outer.HasValue ? this.Outer.Value.UnPack() : null;
  }
  public static Offset<FlatSharpTests.Oracle.NestedStructs> Pack(FlatBufferBuilder builder, NestedStructsT _o) {
    if (_o == null) return default(Offset<FlatSharpTests.Oracle.NestedStructs>);
    StartNestedStructs(builder);
    AddOuter(builder, FlatSharpTests.Oracle.OuterStruct.Pack(builder, _o.Outer));
    return EndNestedStructs(builder);
  }
};

public class NestedStructsT
{
  public FlatSharpTests.Oracle.OuterStructT Outer { get; set; }

  public NestedStructsT() {
    this.Outer = new FlatSharpTests.Oracle.OuterStructT();
  }
}


}
