// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class If : IJsonModel<If>
    {
        internal If() => throw null;

        void IJsonModel<If>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        If IJsonModel<If>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual If JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<If>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        If IPersistableModel<If>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual If PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<If>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="if"> The <see cref="If"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(If @if) => throw null;
    }
}
