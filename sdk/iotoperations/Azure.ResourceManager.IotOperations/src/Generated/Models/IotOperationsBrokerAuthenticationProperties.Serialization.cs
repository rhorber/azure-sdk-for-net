// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class IotOperationsBrokerAuthenticationProperties : IUtf8JsonSerializable, IJsonModel<IotOperationsBrokerAuthenticationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotOperationsBrokerAuthenticationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotOperationsBrokerAuthenticationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsBrokerAuthenticationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotOperationsBrokerAuthenticationProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("authenticationMethods"u8);
            writer.WriteStartArray();
            foreach (var item in AuthenticationMethods)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        IotOperationsBrokerAuthenticationProperties IJsonModel<IotOperationsBrokerAuthenticationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsBrokerAuthenticationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotOperationsBrokerAuthenticationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotOperationsBrokerAuthenticationProperties(document.RootElement, options);
        }

        internal static IotOperationsBrokerAuthenticationProperties DeserializeIotOperationsBrokerAuthenticationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BrokerAuthenticatorMethods> authenticationMethods = default;
            IotOperationsProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationMethods"u8))
                {
                    List<BrokerAuthenticatorMethods> array = new List<BrokerAuthenticatorMethods>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BrokerAuthenticatorMethods.DeserializeBrokerAuthenticatorMethods(item, options));
                    }
                    authenticationMethods = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new IotOperationsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotOperationsBrokerAuthenticationProperties(authenticationMethods, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotOperationsBrokerAuthenticationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsBrokerAuthenticationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotOperationsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IotOperationsBrokerAuthenticationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IotOperationsBrokerAuthenticationProperties IPersistableModel<IotOperationsBrokerAuthenticationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotOperationsBrokerAuthenticationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotOperationsBrokerAuthenticationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotOperationsBrokerAuthenticationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotOperationsBrokerAuthenticationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
