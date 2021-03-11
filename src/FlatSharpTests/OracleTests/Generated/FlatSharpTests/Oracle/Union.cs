// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpTests.Oracle
{

public enum Union : byte
{
  NONE = 0,
  BasicTypes = 1,
  Location = 2,
  stringValue = 3,
};

public class UnionUnion {
  public Union Type { get; set; }
  public object Value { get; set; }

  public UnionUnion() {
    this.Type = Union.NONE;
    this.Value = null;
  }

  public T As<T>() where T : class { return this.Value as T; }
  public FlatSharpTests.Oracle.BasicTypesT AsBasicTypes() { return this.As<FlatSharpTests.Oracle.BasicTypesT>(); }
  public FlatSharpTests.Oracle.LocationT AsLocation() { return this.As<FlatSharpTests.Oracle.LocationT>(); }
  public string AsstringValue() { return this.As<string>(); }

  public static int Pack(FlatBuffers.FlatBufferBuilder builder, UnionUnion _o) {
    switch (_o.Type) {
      default: return 0;
      case Union.BasicTypes: return FlatSharpTests.Oracle.BasicTypes.Pack(builder, _o.AsBasicTypes()).Value;
      case Union.Location: return FlatSharpTests.Oracle.Location.Pack(builder, _o.AsLocation()).Value;
      case Union.stringValue: return builder.CreateString(_o.AsstringValue()).Value;
    }
  }
}


}
