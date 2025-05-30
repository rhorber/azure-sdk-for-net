// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class DataflowEndpointFabricOneLakeNames : IUtf8JsonSerializable, IJsonModel<DataflowEndpointFabricOneLakeNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowEndpointFabricOneLakeNames>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowEndpointFabricOneLakeNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLakeNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLakeNames)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("lakehouseName"u8);
            writer.WriteStringValue(LakehouseName);
            writer.WritePropertyName("workspaceName"u8);
            writer.WriteStringValue(WorkspaceName);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DataflowEndpointFabricOneLakeNames IJsonModel<DataflowEndpointFabricOneLakeNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLakeNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLakeNames)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowEndpointFabricOneLakeNames(document.RootElement, options);
        }

        internal static DataflowEndpointFabricOneLakeNames DeserializeDataflowEndpointFabricOneLakeNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string lakehouseName = default;
            string workspaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lakehouseName"u8))
                {
                    lakehouseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"u8))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowEndpointFabricOneLakeNames(lakehouseName, workspaceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowEndpointFabricOneLakeNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLakeNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotOperationsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLakeNames)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowEndpointFabricOneLakeNames IPersistableModel<DataflowEndpointFabricOneLakeNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLakeNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataflowEndpointFabricOneLakeNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLakeNames)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowEndpointFabricOneLakeNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
