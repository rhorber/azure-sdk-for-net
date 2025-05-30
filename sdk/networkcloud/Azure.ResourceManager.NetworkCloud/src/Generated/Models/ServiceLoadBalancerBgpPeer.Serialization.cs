// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ServiceLoadBalancerBgpPeer : IUtf8JsonSerializable, IJsonModel<ServiceLoadBalancerBgpPeer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceLoadBalancerBgpPeer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceLoadBalancerBgpPeer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadBalancerBgpPeer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BfdEnabled))
            {
                writer.WritePropertyName("bfdEnabled"u8);
                writer.WriteStringValue(BfdEnabled.Value.ToString());
            }
            if (Optional.IsDefined(BgpMultiHop))
            {
                writer.WritePropertyName("bgpMultiHop"u8);
                writer.WriteStringValue(BgpMultiHop.Value.ToString());
            }
            if (Optional.IsDefined(HoldTime))
            {
                writer.WritePropertyName("holdTime"u8);
                writer.WriteStringValue(HoldTime);
            }
            if (Optional.IsDefined(KeepAliveTime))
            {
                writer.WritePropertyName("keepAliveTime"u8);
                writer.WriteStringValue(KeepAliveTime);
            }
            if (Optional.IsDefined(MyAsn))
            {
                writer.WritePropertyName("myAsn"u8);
                writer.WriteNumberValue(MyAsn.Value);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            writer.WritePropertyName("peerAddress"u8);
            writer.WriteStringValue(PeerAddress);
            writer.WritePropertyName("peerAsn"u8);
            writer.WriteNumberValue(PeerAsn);
            if (Optional.IsDefined(PeerPort))
            {
                writer.WritePropertyName("peerPort"u8);
                writer.WriteNumberValue(PeerPort.Value);
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

        ServiceLoadBalancerBgpPeer IJsonModel<ServiceLoadBalancerBgpPeer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadBalancerBgpPeer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceLoadBalancerBgpPeer(document.RootElement, options);
        }

        internal static ServiceLoadBalancerBgpPeer DeserializeServiceLoadBalancerBgpPeer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BfdEnabled? bfdEnabled = default;
            BgpMultiHop? bgpMultiHop = default;
            string holdTime = default;
            string keepAliveTime = default;
            long? myAsn = default;
            string name = default;
            string password = default;
            string peerAddress = default;
            long peerAsn = default;
            long? peerPort = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdEnabled = new BfdEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bgpMultiHop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpMultiHop = new BgpMultiHop(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("holdTime"u8))
                {
                    holdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keepAliveTime"u8))
                {
                    keepAliveTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("myAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    myAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerAddress"u8))
                {
                    peerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerPort = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServiceLoadBalancerBgpPeer(
                bfdEnabled,
                bgpMultiHop,
                holdTime,
                keepAliveTime,
                myAsn,
                name,
                password,
                peerAddress,
                peerAsn,
                peerPort,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceLoadBalancerBgpPeer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadBalancerBgpPeer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkCloudContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceLoadBalancerBgpPeer IPersistableModel<ServiceLoadBalancerBgpPeer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadBalancerBgpPeer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeServiceLoadBalancerBgpPeer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceLoadBalancerBgpPeer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
