// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class SpanSentimentEvalSummary : IUtf8JsonSerializable, IJsonModel<SpanSentimentEvalSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpanSentimentEvalSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SpanSentimentEvalSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpanSentimentEvalSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpanSentimentEvalSummary)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("confusionMatrix"u8);
            writer.WriteStartObject();
            foreach (var item in ConfusionMatrix)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value, options);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("sentiments"u8);
            writer.WriteStartObject();
            foreach (var item in Sentiments)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value, options);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("microF1"u8);
            writer.WriteNumberValue(MicroF1);
            writer.WritePropertyName("microPrecision"u8);
            writer.WriteNumberValue(MicroPrecision);
            writer.WritePropertyName("microRecall"u8);
            writer.WriteNumberValue(MicroRecall);
            writer.WritePropertyName("macroF1"u8);
            writer.WriteNumberValue(MacroF1);
            writer.WritePropertyName("macroPrecision"u8);
            writer.WriteNumberValue(MacroPrecision);
            writer.WritePropertyName("macroRecall"u8);
            writer.WriteNumberValue(MacroRecall);
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

        SpanSentimentEvalSummary IJsonModel<SpanSentimentEvalSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpanSentimentEvalSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpanSentimentEvalSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpanSentimentEvalSummary(document.RootElement, options);
        }

        internal static SpanSentimentEvalSummary DeserializeSpanSentimentEvalSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, TextAuthoringConfusionMatrixRow> confusionMatrix = default;
            IReadOnlyDictionary<string, SentimentEvalSummary> sentiments = default;
            float microF1 = default;
            float microPrecision = default;
            float microRecall = default;
            float macroF1 = default;
            float macroPrecision = default;
            float macroRecall = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confusionMatrix"u8))
                {
                    Dictionary<string, TextAuthoringConfusionMatrixRow> dictionary = new Dictionary<string, TextAuthoringConfusionMatrixRow>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, TextAuthoringConfusionMatrixRow.DeserializeTextAuthoringConfusionMatrixRow(property0.Value, options));
                    }
                    confusionMatrix = dictionary;
                    continue;
                }
                if (property.NameEquals("sentiments"u8))
                {
                    Dictionary<string, SentimentEvalSummary> dictionary = new Dictionary<string, SentimentEvalSummary>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SentimentEvalSummary.DeserializeSentimentEvalSummary(property0.Value, options));
                    }
                    sentiments = dictionary;
                    continue;
                }
                if (property.NameEquals("microF1"u8))
                {
                    microF1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("microPrecision"u8))
                {
                    microPrecision = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("microRecall"u8))
                {
                    microRecall = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("macroF1"u8))
                {
                    macroF1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("macroPrecision"u8))
                {
                    macroPrecision = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("macroRecall"u8))
                {
                    macroRecall = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SpanSentimentEvalSummary(
                confusionMatrix,
                sentiments,
                microF1,
                microPrecision,
                microRecall,
                macroF1,
                macroPrecision,
                macroRecall,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpanSentimentEvalSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpanSentimentEvalSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SpanSentimentEvalSummary)} does not support writing '{options.Format}' format.");
            }
        }

        SpanSentimentEvalSummary IPersistableModel<SpanSentimentEvalSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpanSentimentEvalSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSpanSentimentEvalSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpanSentimentEvalSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpanSentimentEvalSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SpanSentimentEvalSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSpanSentimentEvalSummary(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
