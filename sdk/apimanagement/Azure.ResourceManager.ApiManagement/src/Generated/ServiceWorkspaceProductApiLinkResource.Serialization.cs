// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceProductApiLinkResource : IJsonModel<ProductApiLinkContractData>
    {
        private static ProductApiLinkContractData s_dataDeserializationInstance;
        private static ProductApiLinkContractData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ProductApiLinkContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ProductApiLinkContractData>)Data).Write(writer, options);

        ProductApiLinkContractData IJsonModel<ProductApiLinkContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ProductApiLinkContractData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ProductApiLinkContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ProductApiLinkContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ProductApiLinkContractData IPersistableModel<ProductApiLinkContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ProductApiLinkContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ProductApiLinkContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ProductApiLinkContractData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
