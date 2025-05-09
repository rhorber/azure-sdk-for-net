// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class UpdateNetworkSiblingSetContent : IUtf8JsonSerializable, IJsonModel<UpdateNetworkSiblingSetContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateNetworkSiblingSetContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateNetworkSiblingSetContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateNetworkSiblingSetContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("networkSiblingSetId"u8);
            writer.WriteStringValue(NetworkSiblingSetId);
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("networkSiblingSetStateId"u8);
            writer.WriteStringValue(NetworkSiblingSetStateId);
            writer.WritePropertyName("networkFeatures"u8);
            writer.WriteStringValue(NetworkFeatures.ToString());
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

        UpdateNetworkSiblingSetContent IJsonModel<UpdateNetworkSiblingSetContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateNetworkSiblingSetContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateNetworkSiblingSetContent(document.RootElement, options);
        }

        internal static UpdateNetworkSiblingSetContent DeserializeUpdateNetworkSiblingSetContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string networkSiblingSetId = default;
            ResourceIdentifier subnetId = default;
            string networkSiblingSetStateId = default;
            NetAppNetworkFeature networkFeatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSiblingSetId"u8))
                {
                    networkSiblingSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkSiblingSetStateId"u8))
                {
                    networkSiblingSetStateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFeatures"u8))
                {
                    networkFeatures = new NetAppNetworkFeature(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateNetworkSiblingSetContent(networkSiblingSetId, subnetId, networkSiblingSetStateId, networkFeatures, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateNetworkSiblingSetContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetAppContext.Default);
                default:
                    throw new FormatException($"The model {nameof(UpdateNetworkSiblingSetContent)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateNetworkSiblingSetContent IPersistableModel<UpdateNetworkSiblingSetContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateNetworkSiblingSetContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateNetworkSiblingSetContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateNetworkSiblingSetContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
