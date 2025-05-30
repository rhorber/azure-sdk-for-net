// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProductCostInformation : IUtf8JsonSerializable, IJsonModel<EdgeOrderProductCostInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderProductCostInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeOrderProductCostInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductCostInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductCostInformation)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(BillingMeterDetails))
            {
                writer.WritePropertyName("billingMeterDetails"u8);
                writer.WriteStartArray();
                foreach (var item in BillingMeterDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(BillingInfoUri))
            {
                writer.WritePropertyName("billingInfoUrl"u8);
                writer.WriteStringValue(BillingInfoUri.AbsoluteUri);
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

        EdgeOrderProductCostInformation IJsonModel<EdgeOrderProductCostInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductCostInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductCostInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderProductCostInformation(document.RootElement, options);
        }

        internal static EdgeOrderProductCostInformation DeserializeEdgeOrderProductCostInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<EdgeOrderProductBillingMeterDetails> billingMeterDetails = default;
            Uri billingInfoUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingMeterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdgeOrderProductBillingMeterDetails> array = new List<EdgeOrderProductBillingMeterDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeOrderProductBillingMeterDetails.DeserializeEdgeOrderProductBillingMeterDetails(item, options));
                    }
                    billingMeterDetails = array;
                    continue;
                }
                if (property.NameEquals("billingInfoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingInfoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeOrderProductCostInformation(billingMeterDetails ?? new ChangeTrackingList<EdgeOrderProductBillingMeterDetails>(), billingInfoUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderProductCostInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductCostInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerEdgeOrderContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductCostInformation)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeOrderProductCostInformation IPersistableModel<EdgeOrderProductCostInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductCostInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeOrderProductCostInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductCostInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderProductCostInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
