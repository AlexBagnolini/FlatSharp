
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the FlatSharp FBS to C# compiler (source hash: 5.4.0.Dd4XpMMrQkTqe5INlMb/XiI+ITbJPOIZvxcEAlj9Tf4=)
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
#pragma warning disable 0618
#nullable enable
namespace FlatSharp.Compiler.Generated
{
    internal static class CloneHelpers_8d718d98bfe148378c633c82e980f7c3
    {
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static BenchmarkCore.Normal Clone(BenchmarkCore.Normal item)
        {
            checked
            {
                return item;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static System.Byte Clone(System.Byte item)
        {
            checked
            {
                return item;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static BenchmarkCore.Flags Clone(BenchmarkCore.Flags item)
        {
            checked
            {
                return item;
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static BenchmarkCore.SomeTable? Clone(BenchmarkCore.SomeTable? item)
        {
            checked
            {
                return item is null ? null : new BenchmarkCore.SomeTable(item);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static System.Collections.Generic.IList<BenchmarkCore.Vec3>? Clone(System.Collections.Generic.IList<BenchmarkCore.Vec3>? item)
        {
            checked
            {
                return VectorCloneHelpers.Clone<BenchmarkCore.Vec3>(item, FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static BenchmarkCore.Vec3? Clone(BenchmarkCore.Vec3? item)
        {
            checked
            {
                return item is null ? null : new BenchmarkCore.Vec3(item);
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static System.Single Clone(System.Single item)
        {
            checked
            {
                return item;
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static BenchmarkCore.Struct? Clone(BenchmarkCore.Struct? item)
        {
            checked
            {
                return item is null ? null : new BenchmarkCore.Struct(item);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static BenchmarkCore.OtherStruct? Clone(BenchmarkCore.OtherStruct? item)
        {
            checked
            {
                return item is null ? null : new BenchmarkCore.OtherStruct(item);
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static System.Int64 Clone(System.Int64 item)
        {
            checked
            {
                return item;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static System.Int32 Clone(System.Int32 item)
        {
            checked
            {
                return item;
            }
        }
    }

}

namespace BenchmarkCore
{
    [FlatBufferEnum(typeof(System.Byte))]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public enum Normal : System.Byte
    {
        A = (byte)(0),
        B = (byte)(1),
        C = (byte)(2),
        D = (byte)(3),
    }

    [FlatBufferEnum(typeof(System.Byte))]
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.Flags]
    public enum Flags : System.Byte
    {
        A = (byte)(1),
        B = (byte)(2),
        C = (byte)(4),
        D = (byte)(8),
        None = (byte)(0),
        All = (byte)(15),
    }

    [FlatBufferTable(PoolSize = 0)]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class SomeTable
        : object
        , IFlatBufferSerializable<SomeTable>
    {
        public SomeTable()
        {
            checked
            {
                this.Points = null!;
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected SomeTable(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public SomeTable(SomeTable source)
        {
            checked
            {
                this.Points = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.Points);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItemAttribute(0)]
        public virtual IList<global::BenchmarkCore.Vec3>? Points { get; set; }

        public static ISerializer<BenchmarkCore.SomeTable> Serializer { get; } = new GeneratedSerializer().AsISerializer();

        ISerializer IFlatBufferSerializable.Serializer => Serializer;
        ISerializer<BenchmarkCore.SomeTable> IFlatBufferSerializable<BenchmarkCore.SomeTable>.Serializer => Serializer;

        #region Serializer for BenchmarkCore.SomeTable

        [FlatSharpGeneratedSerializerAttribute(FlatBufferDeserializationOption.GreedyMutable)]
        private sealed class GeneratedSerializer : IGeneratedSerializer<BenchmarkCore.SomeTable>
        {
            // Method generated to help AOT compilers make good decisions about generics.
            public void __AotHelper()
            {
                checked
                {
                    this.Write<ISpanWriter>(default!, new byte[10], default!, default!, default!);
                    this.Write<SpanWriter>(default!, new byte[10], default!, default!, default!);

                    this.Parse<IInputBuffer>(default!, 0);
                    this.Parse<MemoryInputBuffer.Wrapper>(default!, 0);
                    this.Parse<MemoryInputBuffer>(default!, 0);
                    this.Parse<ReadOnlyMemoryInputBuffer.Wrapper>(default!, 0);
                    this.Parse<ReadOnlyMemoryInputBuffer>(default!, 0);
                    this.Parse<ArrayInputBuffer.Wrapper>(default!, 0);
                    this.Parse<ArrayInputBuffer>(default!, 0);

#if FLATSHARP_UNSAFE
                        this.Parse<FlatSharp.Unsafe.UnsafeArrayInputBuffer>(default!, 0);
                        this.Parse<FlatSharp.Unsafe.UnsafeArrayInputBuffer.Wrapper>(default!, 0);
                        this.Parse<FlatSharp.Unsafe.UnsafeMemoryInputBuffer>(default!, 0);
                        this.Parse<FlatSharp.Unsafe.UnsafeMemoryInputBuffer.Wrapper>(default!, 0);
                        this.Write<FlatSharp.Unsafe.UnsafeSpanWriter>(default!, new byte[10], default!, default!, default!);
                        this.Write<FlatSharp.Unsafe.UnsafeSpanWriter.Wrapper>(default!, new byte[10], default!, default!, default!);
#endif

                    throw new InvalidOperationException("__AotHelper is not intended to be invoked");
                }
            }

            public void Write<TSpanWriter>(TSpanWriter writer, Span<byte> target, BenchmarkCore.SomeTable root, int offset, SerializationContext context)
                where TSpanWriter : ISpanWriter
            {
                checked
                {
                    WriteInlineValueOf_c077ba40689a48148bd935889d680255(writer, target, root, offset, context);
                }
            }

            public int GetMaxSize(BenchmarkCore.SomeTable root)
            {
                checked
                {
                    return GetMaxSizeOf_c077ba40689a48148bd935889d680255(root);
                }
            }

            public BenchmarkCore.SomeTable Parse<TInputBuffer>(TInputBuffer buffer, int offset)
                where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return Read_c077ba40689a48148bd935889d680255(buffer, offset);
                }
            }

            private static int GetMaxSizeOf_c077ba40689a48148bd935889d680255(BenchmarkCore.SomeTable value)
            {
                checked
                {

                    int runningSum = 14 + 7;
                    var index0Value = value.Points;

                    if (!(index0Value is null))
                    {
                        runningSum += GetMaxSizeOf_0952ade9ba744db490fc3dd4d5cc738d(index0Value);
                    };
                    return runningSum;

                }
            }

            private static BenchmarkCore.SomeTable Read_c077ba40689a48148bd935889d680255<TInputBuffer>(
                TInputBuffer buffer,
                int offset) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return tableReader_1a58de572ee74ed9b3808d946ed3500f<TInputBuffer>.GetOrCreate(buffer, offset + buffer.ReadUOffset(offset));
                }
            }

            private sealed class tableReader_1a58de572ee74ed9b3808d946ed3500f<TInputBuffer>
                : BenchmarkCore.SomeTable
                , FlatSharp.IFlatBufferDeserializedObject
                where TInputBuffer : IInputBuffer
            {
                private static readonly FlatSharp.FlatBufferDeserializationContext __CtorContext
                    = new FlatSharp.FlatBufferDeserializationContext(FlatSharp.FlatBufferDeserializationOption.GreedyMutable);



                private System.Collections.Generic.IList<BenchmarkCore.Vec3>? __index0Value;

                public static tableReader_1a58de572ee74ed9b3808d946ed3500f<TInputBuffer> GetOrCreate(TInputBuffer buffer, int offset)
                {
                    checked
                    {

                        var item = new tableReader_1a58de572ee74ed9b3808d946ed3500f<TInputBuffer>(buffer, offset);
                        return item;

                    }
                }

                private tableReader_1a58de572ee74ed9b3808d946ed3500f(TInputBuffer buffer, int offset) : base(__CtorContext)
                {
                    checked
                    {
                        buffer.InitializeVTable(offset, out var __vtableLocation, out var __vtableMaxIndex);
                        this.__index0Value = ReadIndex0Value(buffer, offset, __vtableLocation, __vtableMaxIndex);
                        base.OnFlatSharpDeserialized(__CtorContext);
                    }
                }

                System.Type IFlatBufferDeserializedObject.TableOrStructType => typeof(BenchmarkCore.SomeTable);
                FlatSharp.FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;
                FlatSharp.IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

                void IFlatBufferDeserializedObject.Release()
                {
                    checked
                    {

                    }
                }

                public override System.Collections.Generic.IList<BenchmarkCore.Vec3>? Points
                {
                    get
                    {
                        checked
                        {
                            return this.__index0Value;
                        }
                    }

                    set
                    {
                        checked
                        {
                            this.__index0Value = value;
                        }
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.Collections.Generic.IList<BenchmarkCore.Vec3>? ReadIndex0Value(
                    TInputBuffer buffer,
                    int offset,
                    int vtableOffset,
                    int maxVtableIndex)
                {
                    checked
                    {

                        if (0 > maxVtableIndex)
                        {
                            return null;
                        }

                        ushort relativeOffset = buffer.ReadUShort(vtableOffset + 4);
                        if (relativeOffset == 0)
                        {
                            return null;
                        }

                        int absoluteLocation = offset + relativeOffset;
                        return Read_0952ade9ba744db490fc3dd4d5cc738d(buffer, absoluteLocation); ;
                    }
                }
            }



            private static void WriteInlineValueOf_c077ba40689a48148bd935889d680255<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                BenchmarkCore.SomeTable value,
                int offset
                , SerializationContext context) where TSpanWriter : ISpanWriter
            {
                checked
                {

                    int tableStart = context.AllocateSpace(11, sizeof(int));
                    spanWriter.WriteUOffset(span, offset, tableStart);
                    int currentOffset = tableStart + sizeof(int); // skip past vtable soffset_t.

                    int vtableLength = 4;
                    Span<byte> vtable = stackalloc byte[6];

                    var index0Value = value.Points;

                    var index0Offset = tableStart;
                    if (!(index0Value is null))
                    {

                        currentOffset += SerializationHelpers.GetAlignmentError(currentOffset, 4);
                        index0Offset = currentOffset;
                        currentOffset += 4;

                        vtableLength = 6;
                    }

                    spanWriter.WriteUShort(vtable, (ushort)(index0Offset - tableStart), 4);
                    int tableLength = currentOffset - tableStart;
                    context.Offset -= 11 - tableLength;
                    spanWriter.WriteUShort(vtable, (ushort)vtableLength, 0);
                    spanWriter.WriteUShort(vtable, (ushort)tableLength, sizeof(ushort));
                    int vtablePosition = context.FinishVTable(span, vtable.Slice(0, vtableLength));
                    spanWriter.WriteInt(span, tableStart - vtablePosition, tableStart);

                    if (index0Offset != tableStart)
                    {


                        WriteInlineValueOf_0952ade9ba744db490fc3dd4d5cc738d(spanWriter, span, index0Value!, index0Offset, context);

                    }

                }
            }

            private static int GetMaxSizeOf_0952ade9ba744db490fc3dd4d5cc738d(System.Collections.Generic.IList<BenchmarkCore.Vec3> value)
            {
                checked
                {
                    return 10 + (12 * value.Count);
                }
            }

            private static System.Collections.Generic.IList<BenchmarkCore.Vec3> Read_0952ade9ba744db490fc3dd4d5cc738d<TInputBuffer>(
                TInputBuffer buffer,
                int offset) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return (new FlatBufferVector_cc3c46a9405e4ce289f3a82914192d3c<TInputBuffer>(
                        buffer,
                        offset + buffer.ReadUOffset(offset),
                        12)).FlatBufferVectorToList();
                }
            }

            public sealed class FlatBufferVector_cc3c46a9405e4ce289f3a82914192d3c<TInputBuffer> : FlatBufferVector<BenchmarkCore.Vec3, TInputBuffer>
                where TInputBuffer : IInputBuffer
            {
                public FlatBufferVector_cc3c46a9405e4ce289f3a82914192d3c(
                    TInputBuffer memory,
                    int offset,
                    int itemSize) : base(memory, offset, itemSize)
                {
                    checked
                    {
                    }
                }

                protected override BenchmarkCore.Vec3 ParseItem(TInputBuffer memory, int offset)
                {
                    checked
                    {
                        return Read_9dc998901feb4d5a9479b063f161796d(memory, offset);
                    }
                }
            }



            private static void WriteInlineValueOf_0952ade9ba744db490fc3dd4d5cc738d<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                System.Collections.Generic.IList<BenchmarkCore.Vec3> value,
                int offset
                , SerializationContext context) where TSpanWriter : ISpanWriter
            {
                checked
                {

                    int count = value.Count;
                    int vectorOffset = context.AllocateVector(4, count, 12);
                    spanWriter.WriteUOffset(span, offset, vectorOffset);
                    spanWriter.WriteInt(span, count, vectorOffset);
                    vectorOffset += sizeof(int);


                    if (value is BenchmarkCore.Vec3[] array)
                    {

                        for (int i = 0; i < array.Length; i = unchecked(i + 1))
                        {
                            var current = array[i];

                            SerializationHelpers.EnsureNonNull(current);
                            WriteInlineValueOf_9dc998901feb4d5a9479b063f161796d(spanWriter, span, current, vectorOffset);
                            vectorOffset += 12;
                        }
                    }
                    else if (value is List<BenchmarkCore.Vec3> realList)
                    {

                        int i;
                        for (i = 0; i < count; i = unchecked(i + 1))
                        {
                            var current = realList[i];

                            SerializationHelpers.EnsureNonNull(current);
                            WriteInlineValueOf_9dc998901feb4d5a9479b063f161796d(spanWriter, span, current, vectorOffset);
                            vectorOffset += 12;
                        }
                    }
                    else
                    {

                        int i;
                        for (i = 0; i < count; i = unchecked(i + 1))
                        {
                            var current = value[i];

                            SerializationHelpers.EnsureNonNull(current);
                            WriteInlineValueOf_9dc998901feb4d5a9479b063f161796d(spanWriter, span, current, vectorOffset);
                            vectorOffset += 12;
                        }
                    }
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            private static int GetMaxSizeOf_9dc998901feb4d5a9479b063f161796d(BenchmarkCore.Vec3 value)
            {
                checked
                {
                    return 15;
                }
            }

            private static BenchmarkCore.Vec3 Read_9dc998901feb4d5a9479b063f161796d<TInputBuffer>(
                TInputBuffer buffer,
                int offset) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>.GetOrCreate(buffer, offset);
                }
            }

            private sealed class structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>
                : BenchmarkCore.Vec3
                , FlatSharp.IFlatBufferDeserializedObject
                where TInputBuffer : IInputBuffer
            {
                private static readonly FlatSharp.FlatBufferDeserializationContext __CtorContext
                    = new FlatSharp.FlatBufferDeserializationContext(FlatSharp.FlatBufferDeserializationOption.GreedyMutable);


                [ThreadStatic]
                private static Queue<structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>> __Pool = new Queue<structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>>();


                private static Queue<structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>> __Queue => __Pool ?? (__Pool = new Queue<structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>>());


                private string __poolDiag_allocationStack;
                private string __poolDiag_releaseStack;
                private bool __poolDiag_released;

                public static structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer> GetOrCreate(TInputBuffer buffer, int offset)
                {
                    checked
                    {

                        if (!__Queue.TryDequeue(out var item))
                        {
                            item = new structReader_594f6c2c2c7f456d8746e030050038c2<TInputBuffer>();
                        }

                        item.Initialize(buffer, offset);

                        item.__poolDiag_released = false;
                        item.__poolDiag_allocationStack = null;
                        item.__poolDiag_releaseStack = null;

                        if (FlatSharpGlobalSettings.CollectPooledObjectStackTraces)
                        {
                            item.__poolDiag_allocationStack = Environment.StackTrace;
                        }

                        return item;

                    }
                }

                private structReader_594f6c2c2c7f456d8746e030050038c2() : base(__CtorContext)
                {
                    checked
                    {
                    }
                }

                private void Initialize(TInputBuffer buffer, int offset)
                {
                    checked
                    {
                        base.X = ReadIndex0Value(buffer, offset, default, default);
                        base.Y = ReadIndex1Value(buffer, offset, default, default);
                        base.Z = ReadIndex2Value(buffer, offset, default, default);
                        base.OnFlatSharpDeserialized(__CtorContext);
                    }
                }

                System.Type IFlatBufferDeserializedObject.TableOrStructType => typeof(BenchmarkCore.Vec3);
                FlatSharp.FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;
                FlatSharp.IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

                void IFlatBufferDeserializedObject.Release()
                {
                    checked
                    {

                        if (this.__poolDiag_released)
                        {
                            throw new InvalidOperationException(
                                $"FlatSharp pooled object released twice. Type = 'BenchmarkCore.Vec3', \r\n\r\n AllocationStack = '{this.__poolDiag_allocationStack}', \r\n\r\n ReleaseStack = '{this.__poolDiag_releaseStack}'");
                        }

                        this.__poolDiag_released = true;
                        if (FlatSharpGlobalSettings.CollectPooledObjectStackTraces)
                        {
                            this.__poolDiag_releaseStack = Environment.StackTrace;
                        }


                        __Queue.Enqueue(this);

                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.Single ReadIndex0Value(
                    TInputBuffer buffer,
                    int offset,
                    int vtableOffset,
                    int maxVtableIndex)
                {
                    checked
                    {
                        return Read_8fd7c66735f248fe96e0608299be9888(buffer, offset + 0); ;
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.Single ReadIndex1Value(
                    TInputBuffer buffer,
                    int offset,
                    int vtableOffset,
                    int maxVtableIndex)
                {
                    checked
                    {
                        return Read_8fd7c66735f248fe96e0608299be9888(buffer, offset + 4); ;
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.Single ReadIndex2Value(
                    TInputBuffer buffer,
                    int offset,
                    int vtableOffset,
                    int maxVtableIndex)
                {
                    checked
                    {
                        return Read_8fd7c66735f248fe96e0608299be9888(buffer, offset + 8); ;
                    }
                }
            }



            private static void WriteInlineValueOf_9dc998901feb4d5a9479b063f161796d<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                BenchmarkCore.Vec3 value,
                int offset
                ) where TSpanWriter : ISpanWriter
            {
                checked
                {
                    Span<byte> scopedSpan = span.Slice(offset, 12);

                    if (value is null)
                    {
                        scopedSpan.Clear();
                        return;
                    }

                    WriteInlineValueOf_8fd7c66735f248fe96e0608299be9888(spanWriter, scopedSpan, value.X, 0);
                    WriteInlineValueOf_8fd7c66735f248fe96e0608299be9888(spanWriter, scopedSpan, value.Y, 4);
                    WriteInlineValueOf_8fd7c66735f248fe96e0608299be9888(spanWriter, scopedSpan, value.Z, 8);
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            private static int GetMaxSizeOf_8fd7c66735f248fe96e0608299be9888(System.Single value)
            {
                checked
                {
                    return 7;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            private static System.Single Read_8fd7c66735f248fe96e0608299be9888<TInputBuffer>(
                TInputBuffer buffer,
                int offset) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return buffer.ReadFloat(offset);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void WriteInlineValueOf_8fd7c66735f248fe96e0608299be9888<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                System.Single value,
                int offset
                ) where TSpanWriter : ISpanWriter
            {
                checked
                {
                    spanWriter.WriteFloat(span, value, offset);
                }
            }
        }

        #endregion
    }
    [FlatBufferStruct(PoolSize = -1)]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class Vec3
        : object
    {
        public Vec3()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected Vec3(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Vec3(Vec3 source)
        {
            checked
            {
                this.X = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.X);
                this.Y = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.Y);
                this.Z = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.Z);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItemAttribute(0)]
        public System.Single X { get; set; }

        [FlatBufferItemAttribute(1)]
        public System.Single Y { get; set; }

        [FlatBufferItemAttribute(2)]
        public System.Single Z { get; set; }

    }
    [FlatBufferStruct(PoolSize = 0)]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class Struct
        : object
    {
        public Struct()
        {
            checked
            {
                this.Other = new BenchmarkCore.OtherStruct();
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected Struct(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Struct(Struct source)
        {
            checked
            {
                this.Other = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.Other);
                this.Int = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.Int);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItemAttribute(0, WriteThrough = true)]
        public virtual global::BenchmarkCore.OtherStruct Other { get; set; }

        [FlatBufferItemAttribute(1, WriteThrough = true)]
        public virtual System.Int32 Int { get; set; }

    }
    [FlatBufferStruct(PoolSize = 0)]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class OtherStruct
        : object
    {
        public OtherStruct()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected OtherStruct(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public OtherStruct(OtherStruct source)
        {
            checked
            {
                this.Long = FlatSharp.Compiler.Generated.CloneHelpers_8d718d98bfe148378c633c82e980f7c3.Clone(source.Long);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItemAttribute(0, WriteThrough = true)]
        public virtual System.Int64 Long { get; set; }

    }
}
#nullable restore
#pragma warning restore 0618
