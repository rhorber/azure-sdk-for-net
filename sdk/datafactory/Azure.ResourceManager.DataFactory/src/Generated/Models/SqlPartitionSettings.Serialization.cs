// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlPartitionSettings : IUtf8JsonSerializable, IJsonModel<SqlPartitionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlPartitionSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlPartitionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlPartitionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlPartitionSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName"u8);
                JsonSerializer.Serialize(writer, PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                JsonSerializer.Serialize(writer, PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                JsonSerializer.Serialize(writer, PartitionLowerBound);
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

        SqlPartitionSettings IJsonModel<SqlPartitionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlPartitionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlPartitionSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlPartitionSettings(document.RootElement, options);
        }

        internal static SqlPartitionSettings DeserializeSqlPartitionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> partitionColumnName = default;
            DataFactoryElement<string> partitionUpperBound = default;
            DataFactoryElement<string> partitionLowerBound = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlPartitionSettings(partitionColumnName, partitionUpperBound, partitionLowerBound, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlPartitionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlPartitionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SqlPartitionSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SqlPartitionSettings IPersistableModel<SqlPartitionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlPartitionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSqlPartitionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlPartitionSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlPartitionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
