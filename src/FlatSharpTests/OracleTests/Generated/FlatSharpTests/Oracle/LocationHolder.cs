// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpTests.Oracle
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct LocationHolder : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static LocationHolder GetRootAsLocationHolder(ByteBuffer _bb) { return GetRootAsLocationHolder(_bb, new LocationHolder()); }
  public static LocationHolder GetRootAsLocationHolder(ByteBuffer _bb, LocationHolder obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocationHolder __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatSharpTests.Oracle.Location? SingleLocation { get { int o = __p.__offset(4); return o != 0 ? (FlatSharpTests.Oracle.Location?)(new FlatSharpTests.Oracle.Location()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string Fake { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFakeBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFakeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFakeArray() { return __p.__vector_as_array<byte>(6); }
  public FlatSharpTests.Oracle.Location? LocationVector(int j) { int o = __p.__offset(8); return o != 0 ? (FlatSharpTests.Oracle.Location?)(new FlatSharpTests.Oracle.Location()).__assign(__p.__vector(o) + j * 12, __p.bb) : null; }
  public int LocationVectorLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static void StartLocationHolder(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddSingleLocation(FlatBufferBuilder builder, Offset<FlatSharpTests.Oracle.Location> SingleLocationOffset) { builder.AddStruct(0, SingleLocationOffset.Value, 0); }
  public static void AddFake(FlatBufferBuilder builder, StringOffset FakeOffset) { builder.AddOffset(1, FakeOffset.Value, 0); }
  public static void AddLocationVector(FlatBufferBuilder builder, VectorOffset LocationVectorOffset) { builder.AddOffset(2, LocationVectorOffset.Value, 0); }
  public static void StartLocationVectorVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(12, numElems, 4); }
  public static Offset<FlatSharpTests.Oracle.LocationHolder> EndLocationHolder(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatSharpTests.Oracle.LocationHolder>(o);
  }
  public LocationHolderT UnPack() {
    var _o = new LocationHolderT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LocationHolderT _o) {
    _o.SingleLocation = this.SingleLocation.HasValue ? this.SingleLocation.Value.UnPack() : null;
    _o.Fake = this.Fake;
    _o.LocationVector = new List<FlatSharpTests.Oracle.LocationT>();
    for (var _j = 0; _j < this.LocationVectorLength; ++_j) {_o.LocationVector.Add(this.LocationVector(_j).HasValue ? this.LocationVector(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatSharpTests.Oracle.LocationHolder> Pack(FlatBufferBuilder builder, LocationHolderT _o) {
    if (_o == null) return default(Offset<FlatSharpTests.Oracle.LocationHolder>);
    var _Fake = _o.Fake == null ? default(StringOffset) : builder.CreateString(_o.Fake);
    var _LocationVector = default(VectorOffset);
    if (_o.LocationVector != null) {
      StartLocationVectorVector(builder, _o.LocationVector.Count);
      for (var _j = _o.LocationVector.Count - 1; _j >= 0; --_j) { FlatSharpTests.Oracle.Location.Pack(builder, _o.LocationVector[_j]); }
      _LocationVector = builder.EndVector();
    }
    StartLocationHolder(builder);
    AddSingleLocation(builder, FlatSharpTests.Oracle.Location.Pack(builder, _o.SingleLocation));
    AddFake(builder, _Fake);
    AddLocationVector(builder, _LocationVector);
    return EndLocationHolder(builder);
  }
};

public class LocationHolderT
{
  public FlatSharpTests.Oracle.LocationT SingleLocation { get; set; }
  public string Fake { get; set; }
  public List<FlatSharpTests.Oracle.LocationT> LocationVector { get; set; }

  public LocationHolderT() {
    this.SingleLocation = new FlatSharpTests.Oracle.LocationT();
    this.Fake = null;
    this.LocationVector = null;
  }
}


}
