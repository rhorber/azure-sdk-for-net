// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ConditionalQueueSelectorAttachment : IUtf8JsonSerializable, IJsonModel<ConditionalQueueSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConditionalQueueSelectorAttachment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConditionalQueueSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConditionalQueueSelectorAttachment)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("condition"u8);
            writer.WriteObjectValue(Condition, options);
            writer.WritePropertyName("queueSelectors"u8);
            writer.WriteStartArray();
            foreach (var item in QueueSelectors)
            {
                writer.WriteObjectValue<RouterQueueSelector>(item, options);
            }
            writer.WriteEndArray();
        }

        ConditionalQueueSelectorAttachment IJsonModel<ConditionalQueueSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConditionalQueueSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConditionalQueueSelectorAttachment(document.RootElement, options);
        }

        internal static ConditionalQueueSelectorAttachment DeserializeConditionalQueueSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule condition = default;
            IList<RouterQueueSelector> queueSelectors = default;
            QueueSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("condition"u8))
                {
                    condition = RouterRule.DeserializeRouterRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("queueSelectors"u8))
                {
                    List<RouterQueueSelector> array = new List<RouterQueueSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterQueueSelector.DeserializeRouterQueueSelector(item, options));
                    }
                    queueSelectors = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new QueueSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConditionalQueueSelectorAttachment(kind, serializedAdditionalRawData, condition, queueSelectors);
        }

        BinaryData IPersistableModel<ConditionalQueueSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureCommunicationJobRouterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConditionalQueueSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        ConditionalQueueSelectorAttachment IPersistableModel<ConditionalQueueSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConditionalQueueSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConditionalQueueSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConditionalQueueSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ConditionalQueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeConditionalQueueSelectorAttachment(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
