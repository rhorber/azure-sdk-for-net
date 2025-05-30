// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance
{
    public partial class SapApplicationServerInstanceResource : IJsonModel<SapApplicationServerInstanceData>
    {
        private static SapApplicationServerInstanceData s_dataDeserializationInstance;
        private static SapApplicationServerInstanceData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SapApplicationServerInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SapApplicationServerInstanceData>)Data).Write(writer, options);

        SapApplicationServerInstanceData IJsonModel<SapApplicationServerInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SapApplicationServerInstanceData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SapApplicationServerInstanceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SapApplicationServerInstanceData>(Data, options, AzureResourceManagerWorkloadsSapVirtualInstanceContext.Default);

        SapApplicationServerInstanceData IPersistableModel<SapApplicationServerInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SapApplicationServerInstanceData>(data, options, AzureResourceManagerWorkloadsSapVirtualInstanceContext.Default);

        string IPersistableModel<SapApplicationServerInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SapApplicationServerInstanceData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
