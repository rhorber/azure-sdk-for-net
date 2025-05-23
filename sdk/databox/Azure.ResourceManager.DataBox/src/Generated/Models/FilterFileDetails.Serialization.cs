// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class FilterFileDetails : IUtf8JsonSerializable, IJsonModel<FilterFileDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FilterFileDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FilterFileDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilterFileDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FilterFileDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("filterFileType"u8);
            writer.WriteStringValue(FilterFileType.ToSerialString());
            writer.WritePropertyName("filterFilePath"u8);
            writer.WriteStringValue(FilterFilePath);
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

        FilterFileDetails IJsonModel<FilterFileDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilterFileDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FilterFileDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFilterFileDetails(document.RootElement, options);
        }

        internal static FilterFileDetails DeserializeFilterFileDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FilterFileType filterFileType = default;
            string filterFilePath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterFileType"u8))
                {
                    filterFileType = property.Value.GetString().ToFilterFileType();
                    continue;
                }
                if (property.NameEquals("filterFilePath"u8))
                {
                    filterFilePath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FilterFileDetails(filterFileType, filterFilePath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FilterFileDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilterFileDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FilterFileDetails)} does not support writing '{options.Format}' format.");
            }
        }

        FilterFileDetails IPersistableModel<FilterFileDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilterFileDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFilterFileDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FilterFileDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FilterFileDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
