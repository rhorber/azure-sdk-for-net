// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;

namespace _Type.Property.Nullable
{
    public partial class CollectionsModelProperty : IJsonModel<CollectionsModelProperty>
    {
        internal CollectionsModelProperty() => throw null;

        void IJsonModel<CollectionsModelProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        CollectionsModelProperty IJsonModel<CollectionsModelProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual CollectionsModelProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<CollectionsModelProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        CollectionsModelProperty IPersistableModel<CollectionsModelProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual CollectionsModelProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<CollectionsModelProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static explicit operator CollectionsModelProperty(Response result) => throw null;
    }
}
