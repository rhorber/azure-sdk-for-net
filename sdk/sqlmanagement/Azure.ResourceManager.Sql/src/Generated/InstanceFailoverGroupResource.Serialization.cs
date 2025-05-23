// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class InstanceFailoverGroupResource : IJsonModel<InstanceFailoverGroupData>
    {
        private static InstanceFailoverGroupData s_dataDeserializationInstance;
        private static InstanceFailoverGroupData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<InstanceFailoverGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<InstanceFailoverGroupData>)Data).Write(writer, options);

        InstanceFailoverGroupData IJsonModel<InstanceFailoverGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<InstanceFailoverGroupData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<InstanceFailoverGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<InstanceFailoverGroupData>(Data, options, AzureResourceManagerSqlContext.Default);

        InstanceFailoverGroupData IPersistableModel<InstanceFailoverGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<InstanceFailoverGroupData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<InstanceFailoverGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<InstanceFailoverGroupData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
