// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdatePrivateEndpointConnectionDetails : IUtf8JsonSerializable, IJsonModel<DeviceUpdatePrivateEndpointConnectionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdatePrivateEndpointConnectionDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceUpdatePrivateEndpointConnectionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointConnectionDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkIdentifier))
            {
                writer.WritePropertyName("linkIdentifier"u8);
                writer.WriteStringValue(LinkIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (options.Format != "W" && Optional.IsDefined(MemberName))
            {
                writer.WritePropertyName("memberName"u8);
                writer.WriteStringValue(MemberName);
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

        DeviceUpdatePrivateEndpointConnectionDetails IJsonModel<DeviceUpdatePrivateEndpointConnectionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointConnectionDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdatePrivateEndpointConnectionDetails(document.RootElement, options);
        }

        internal static DeviceUpdatePrivateEndpointConnectionDetails DeserializeDeviceUpdatePrivateEndpointConnectionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string privateIPAddress = default;
            string linkIdentifier = default;
            string groupId = default;
            string memberName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkIdentifier"u8))
                {
                    linkIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memberName"u8))
                {
                    memberName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceUpdatePrivateEndpointConnectionDetails(
                id,
                privateIPAddress,
                linkIdentifier,
                groupId,
                memberName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDeviceUpdateContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointConnectionDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceUpdatePrivateEndpointConnectionDetails IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDeviceUpdatePrivateEndpointConnectionDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointConnectionDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdatePrivateEndpointConnectionDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
