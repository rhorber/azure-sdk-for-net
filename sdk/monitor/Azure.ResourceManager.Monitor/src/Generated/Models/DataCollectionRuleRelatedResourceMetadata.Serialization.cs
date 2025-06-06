// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleRelatedResourceMetadata : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleRelatedResourceMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleRelatedResourceMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataCollectionRuleRelatedResourceMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleRelatedResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleRelatedResourceMetadata)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisionedBy))
            {
                writer.WritePropertyName("provisionedBy"u8);
                writer.WriteStringValue(ProvisionedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisionedByResourceId))
            {
                writer.WritePropertyName("provisionedByResourceId"u8);
                writer.WriteStringValue(ProvisionedByResourceId);
            }
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

        DataCollectionRuleRelatedResourceMetadata IJsonModel<DataCollectionRuleRelatedResourceMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleRelatedResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleRelatedResourceMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleRelatedResourceMetadata(document.RootElement, options);
        }

        internal static DataCollectionRuleRelatedResourceMetadata DeserializeDataCollectionRuleRelatedResourceMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisionedBy = default;
            string provisionedByResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisionedBy"u8))
                {
                    provisionedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisionedByResourceId"u8))
                {
                    provisionedByResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataCollectionRuleRelatedResourceMetadata(provisionedBy, provisionedByResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleRelatedResourceMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleRelatedResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleRelatedResourceMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionRuleRelatedResourceMetadata IPersistableModel<DataCollectionRuleRelatedResourceMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleRelatedResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataCollectionRuleRelatedResourceMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleRelatedResourceMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleRelatedResourceMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
