// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class GlobalServiceConfiguration : IUtf8JsonSerializable, IJsonModel<GlobalServiceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GlobalServiceConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GlobalServiceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalServiceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GlobalServiceConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Ssl))
            {
                writer.WritePropertyName("ssl"u8);
                writer.WriteObjectValue(Ssl, options);
            }
            if (Optional.IsDefined(ServiceAuth))
            {
                writer.WritePropertyName("serviceAuth"u8);
                writer.WriteObjectValue(ServiceAuth, options);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale"u8);
                writer.WriteObjectValue(AutoScale, options);
            }
            foreach (var item in AdditionalProperties)
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

        GlobalServiceConfiguration IJsonModel<GlobalServiceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalServiceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GlobalServiceConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGlobalServiceConfiguration(document.RootElement, options);
        }

        internal static GlobalServiceConfiguration DeserializeGlobalServiceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            SslConfiguration ssl = default;
            ServiceAuthConfiguration serviceAuth = default;
            AutoScaleConfiguration autoScale = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ssl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssl = SslConfiguration.DeserializeSslConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceAuth = ServiceAuthConfiguration.DeserializeServiceAuthConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("autoScale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScale = AutoScaleConfiguration.DeserializeAutoScaleConfiguration(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GlobalServiceConfiguration(etag, ssl, serviceAuth, autoScale, additionalProperties);
        }

        BinaryData IPersistableModel<GlobalServiceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalServiceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningComputeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(GlobalServiceConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        GlobalServiceConfiguration IPersistableModel<GlobalServiceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalServiceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGlobalServiceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GlobalServiceConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GlobalServiceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
