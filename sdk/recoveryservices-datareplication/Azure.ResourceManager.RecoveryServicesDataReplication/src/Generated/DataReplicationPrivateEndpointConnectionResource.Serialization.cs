// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationPrivateEndpointConnectionResource : IJsonModel<DataReplicationPrivateEndpointConnectionData>
    {
        private static DataReplicationPrivateEndpointConnectionData s_dataDeserializationInstance;
        private static DataReplicationPrivateEndpointConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DataReplicationPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationPrivateEndpointConnectionData>)Data).Write(writer, options);

        DataReplicationPrivateEndpointConnectionData IJsonModel<DataReplicationPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationPrivateEndpointConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DataReplicationPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataReplicationPrivateEndpointConnectionData>(Data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        DataReplicationPrivateEndpointConnectionData IPersistableModel<DataReplicationPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataReplicationPrivateEndpointConnectionData>(data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        string IPersistableModel<DataReplicationPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataReplicationPrivateEndpointConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
