// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsServiceBusProperties : IUtf8JsonSerializable, IJsonModel<DigitalTwinsServiceBusProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigitalTwinsServiceBusProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DigitalTwinsServiceBusProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PrimaryConnectionString))
            {
                if (PrimaryConnectionString != null)
                {
                    writer.WritePropertyName("primaryConnectionString"u8);
                    writer.WriteStringValue(PrimaryConnectionString);
                }
                else
                {
                    writer.WriteNull("primaryConnectionString");
                }
            }
            if (Optional.IsDefined(SecondaryConnectionString))
            {
                if (SecondaryConnectionString != null)
                {
                    writer.WritePropertyName("secondaryConnectionString"u8);
                    writer.WriteStringValue(SecondaryConnectionString);
                }
                else
                {
                    writer.WriteNull("secondaryConnectionString");
                }
            }
            if (Optional.IsDefined(EndpointUri))
            {
                if (EndpointUri != null)
                {
                    writer.WritePropertyName("endpointUri"u8);
                    writer.WriteStringValue(EndpointUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("endpointUri");
                }
            }
            if (Optional.IsDefined(EntityPath))
            {
                if (EntityPath != null)
                {
                    writer.WritePropertyName("entityPath"u8);
                    writer.WriteStringValue(EntityPath);
                }
                else
                {
                    writer.WriteNull("entityPath");
                }
            }
        }

        DigitalTwinsServiceBusProperties IJsonModel<DigitalTwinsServiceBusProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsServiceBusProperties(document.RootElement, options);
        }

        internal static DigitalTwinsServiceBusProperties DeserializeDigitalTwinsServiceBusProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryConnectionString = default;
            string secondaryConnectionString = default;
            Uri endpointUri = default;
            string entityPath = default;
            EndpointType endpointType = default;
            DigitalTwinsEndpointProvisioningState? provisioningState = default;
            DateTimeOffset? createdTime = default;
            DigitalTwinsAuthenticationType? authenticationType = default;
            string deadLetterSecret = default;
            Uri deadLetterUri = default;
            DigitalTwinsManagedIdentityReference identity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryConnectionString = null;
                        continue;
                    }
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secondaryConnectionString = null;
                        continue;
                    }
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpointUri = null;
                        continue;
                    }
                    endpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("entityPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entityPath = null;
                        continue;
                    }
                    entityPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new DigitalTwinsEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdTime = null;
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new DigitalTwinsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deadLetterSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterSecret = null;
                        continue;
                    }
                    deadLetterSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterUri = null;
                        continue;
                    }
                    deadLetterUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DigitalTwinsServiceBusProperties(
                endpointType,
                provisioningState,
                createdTime,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData,
                primaryConnectionString,
                secondaryConnectionString,
                endpointUri,
                entityPath);
        }

        BinaryData IPersistableModel<DigitalTwinsServiceBusProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDigitalTwinsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DigitalTwinsServiceBusProperties IPersistableModel<DigitalTwinsServiceBusProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDigitalTwinsServiceBusProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigitalTwinsServiceBusProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
