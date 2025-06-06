// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Agents.Persistent
{
    [PersistableModelProxy(typeof(UnknownOpenApiAuthDetails))]
    public partial class OpenApiAuthDetails : IUtf8JsonSerializable, IJsonModel<OpenApiAuthDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenApiAuthDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenApiAuthDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAuthDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiAuthDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        OpenApiAuthDetails IJsonModel<OpenApiAuthDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAuthDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiAuthDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenApiAuthDetails(document.RootElement, options);
        }

        internal static OpenApiAuthDetails DeserializeOpenApiAuthDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "anonymous": return OpenApiAnonymousAuthDetails.DeserializeOpenApiAnonymousAuthDetails(element, options);
                    case "connection": return OpenApiConnectionAuthDetails.DeserializeOpenApiConnectionAuthDetails(element, options);
                    case "managed_identity": return OpenApiManagedAuthDetails.DeserializeOpenApiManagedAuthDetails(element, options);
                }
            }
            return UnknownOpenApiAuthDetails.DeserializeUnknownOpenApiAuthDetails(element, options);
        }

        BinaryData IPersistableModel<OpenApiAuthDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAuthDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIAgentsPersistentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OpenApiAuthDetails)} does not support writing '{options.Format}' format.");
            }
        }

        OpenApiAuthDetails IPersistableModel<OpenApiAuthDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAuthDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOpenApiAuthDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenApiAuthDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenApiAuthDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OpenApiAuthDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeOpenApiAuthDetails(document.RootElement);
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
