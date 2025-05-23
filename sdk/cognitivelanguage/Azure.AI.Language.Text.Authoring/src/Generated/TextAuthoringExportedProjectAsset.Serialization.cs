// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    [PersistableModelProxy(typeof(UnknownTextAuthoringExportedProjectAsset))]
    public partial class TextAuthoringExportedProjectAsset : IUtf8JsonSerializable, IJsonModel<TextAuthoringExportedProjectAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringExportedProjectAsset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringExportedProjectAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedProjectAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringExportedProjectAsset)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("projectKind"u8);
            writer.WriteStringValue(ProjectKind.ToString());
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

        TextAuthoringExportedProjectAsset IJsonModel<TextAuthoringExportedProjectAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedProjectAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringExportedProjectAsset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringExportedProjectAsset(document.RootElement, options);
        }

        internal static TextAuthoringExportedProjectAsset DeserializeTextAuthoringExportedProjectAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("projectKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CustomAbstractiveSummarization": return ExportedCustomAbstractiveSummarizationProjectAsset.DeserializeExportedCustomAbstractiveSummarizationProjectAsset(element, options);
                    case "CustomEntityRecognition": return ExportedCustomEntityRecognitionProjectAsset.DeserializeExportedCustomEntityRecognitionProjectAsset(element, options);
                    case "CustomHealthcare": return ExportedCustomHealthcareProjectAsset.DeserializeExportedCustomHealthcareProjectAsset(element, options);
                    case "CustomMultiLabelClassification": return ExportedCustomMultiLabelClassificationProjectAsset.DeserializeExportedCustomMultiLabelClassificationProjectAsset(element, options);
                    case "CustomSingleLabelClassification": return ExportedCustomSingleLabelClassificationProjectAsset.DeserializeExportedCustomSingleLabelClassificationProjectAsset(element, options);
                    case "CustomTextSentiment": return CustomTextSentimentProjectAssets.DeserializeCustomTextSentimentProjectAssets(element, options);
                }
            }
            return UnknownTextAuthoringExportedProjectAsset.DeserializeUnknownTextAuthoringExportedProjectAsset(element, options);
        }

        BinaryData IPersistableModel<TextAuthoringExportedProjectAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedProjectAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringExportedProjectAsset)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringExportedProjectAsset IPersistableModel<TextAuthoringExportedProjectAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedProjectAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringExportedProjectAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringExportedProjectAsset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringExportedProjectAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringExportedProjectAsset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringExportedProjectAsset(document.RootElement);
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
