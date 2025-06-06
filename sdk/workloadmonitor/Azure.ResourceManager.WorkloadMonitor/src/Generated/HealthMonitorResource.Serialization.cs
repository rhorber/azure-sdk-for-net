// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.WorkloadMonitor
{
    public partial class HealthMonitorResource : IJsonModel<HealthMonitorData>
    {
        private static HealthMonitorData s_dataDeserializationInstance;
        private static HealthMonitorData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<HealthMonitorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HealthMonitorData>)Data).Write(writer, options);

        HealthMonitorData IJsonModel<HealthMonitorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HealthMonitorData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<HealthMonitorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<HealthMonitorData>(Data, options, AzureResourceManagerWorkloadMonitorContext.Default);

        HealthMonitorData IPersistableModel<HealthMonitorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HealthMonitorData>(data, options, AzureResourceManagerWorkloadMonitorContext.Default);

        string IPersistableModel<HealthMonitorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HealthMonitorData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
