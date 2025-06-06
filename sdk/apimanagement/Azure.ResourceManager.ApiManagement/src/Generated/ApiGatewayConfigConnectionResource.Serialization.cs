// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiGatewayConfigConnectionResource : IJsonModel<ApiGatewayConfigConnectionData>
    {
        private static ApiGatewayConfigConnectionData s_dataDeserializationInstance;
        private static ApiGatewayConfigConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ApiGatewayConfigConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiGatewayConfigConnectionData>)Data).Write(writer, options);

        ApiGatewayConfigConnectionData IJsonModel<ApiGatewayConfigConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiGatewayConfigConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ApiGatewayConfigConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ApiGatewayConfigConnectionData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ApiGatewayConfigConnectionData IPersistableModel<ApiGatewayConfigConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiGatewayConfigConnectionData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ApiGatewayConfigConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiGatewayConfigConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
