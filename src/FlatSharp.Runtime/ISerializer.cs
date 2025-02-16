﻿/*
 * Copyright 2018 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace FlatSharp
{
    using System;
    using System.Reflection;

    /// <summary>
    /// An object that can read and write a FlatBuffer table from a buffer. The type
    /// of table this ISerializer supports is indicated by the <see cref="RootType"/> property.
    /// The use of other types may cause undefined behavior.
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// The type of object that this serializer can read and write.
        /// </summary>
        Type RootType { get; }

        /// <summary>
        /// Gets the C# code that FlatSharp generated to produce this serializer.
        /// </summary>
        string? CSharp { get; }

        /// <summary>
        /// Gets the Assembly FlatSharp generated to produce this serializer.
        /// </summary>
        Assembly? Assembly { get; }

        /// <summary>
        /// Gets the raw data of the <see cref="Assembly"/> property. Can be saved to disk and decompiled, referenced, etc.
        /// </summary>
        byte[]? AssemblyBytes { get; }

        /// <summary>
        /// Writes the given item to the buffer using the given spanwriter.
        /// </summary>
        /// <param name="writer">The span writer.</param>
        /// <param name="destination">The span to write to.</param>
        /// <param name="item">The object to serialize.</param>
        /// <returns>The number of bytes written.</returns>
        int Write<TSpanWriter>(TSpanWriter writer, Span<byte> destination, object item) where TSpanWriter : ISpanWriter;

        /// <summary>
        /// Computes the maximum size necessary to serialize the given instance of <typeparamref name="T"/>.
        /// </summary>
        int GetMaxSize(object item);

        /// <summary>
        /// Parses the given buffer as an instance of <typeparamref name="T"/>.
        /// </summary>
        object Parse<TInputBuffer>(TInputBuffer buffer) where TInputBuffer : IInputBuffer;
    }

    /// <summary>
    /// An object that can read and write <typeparamref name="T"/> from a buffer.
    /// </summary>
    public interface ISerializer<T> : ISerializer
        where T : class
    {
        /// <summary>
        /// Writes the given item to the buffer using the given spanwriter.
        /// </summary>
        /// <param name="writer">The span writer.</param>
        /// <param name="destination">The span to write to.</param>
        /// <param name="item">The object to serialize.</param>
        /// <returns>The number of bytes written.</returns>
        int Write<TSpanWriter>(TSpanWriter writer, Span<byte> destination, T item) where TSpanWriter : ISpanWriter;

        /// <summary>
        /// Computes the maximum size necessary to serialize the given instance of <typeparamref name="T"/>.
        /// </summary>
        int GetMaxSize(T item);

        /// <summary>
        /// Parses the given buffer as an instance of <typeparamref name="T"/>.
        /// </summary>
        new T Parse<TInputBuffer>(TInputBuffer buffer) where TInputBuffer : IInputBuffer;

        /// <summary>
        /// Returns a new <see cref="ISerializer{T}"/> instance based on the current one with the given settings.
        /// </summary>
        ISerializer<T> WithSettings(SerializerSettings settings);
    }
}
