// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeNetworkAdapter : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeNetworkAdapter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeNetworkAdapter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxEdgeNetworkAdapter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapter)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AdapterId))
            {
                writer.WritePropertyName("adapterId"u8);
                writer.WriteStringValue(AdapterId);
            }
            if (options.Format != "W" && Optional.IsDefined(AdapterPosition))
            {
                writer.WritePropertyName("adapterPosition"u8);
                writer.WriteObjectValue(AdapterPosition, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Index))
            {
                writer.WritePropertyName("index"u8);
                writer.WriteNumberValue(Index.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeId))
            {
                writer.WritePropertyName("nodeId"u8);
                writer.WriteStringValue(NodeId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkAdapterName))
            {
                writer.WritePropertyName("networkAdapterName"u8);
                writer.WriteStringValue(NetworkAdapterName);
            }
            if (options.Format != "W" && Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (options.Format != "W" && Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkSpeed))
            {
                writer.WritePropertyName("linkSpeed"u8);
                writer.WriteNumberValue(LinkSpeed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(RdmaStatus))
            {
                writer.WritePropertyName("rdmaStatus"u8);
                writer.WriteStringValue(RdmaStatus.Value.ToString());
            }
            if (Optional.IsDefined(DhcpStatus))
            {
                writer.WritePropertyName("dhcpStatus"u8);
                writer.WriteStringValue(DhcpStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IPv4Configuration))
            {
                writer.WritePropertyName("ipv4Configuration"u8);
                writer.WriteObjectValue(IPv4Configuration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(IPv6Configuration))
            {
                writer.WritePropertyName("ipv6Configuration"u8);
                writer.WriteObjectValue(IPv6Configuration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(IPv6LinkLocalAddress))
            {
                writer.WritePropertyName("ipv6LinkLocalAddress"u8);
                writer.WriteStringValue(IPv6LinkLocalAddress);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        DataBoxEdgeNetworkAdapter IJsonModel<DataBoxEdgeNetworkAdapter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeNetworkAdapter(document.RootElement, options);
        }

        internal static DataBoxEdgeNetworkAdapter DeserializeDataBoxEdgeNetworkAdapter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adapterId = default;
            DataBoxEdgeNetworkAdapterPosition adapterPosition = default;
            int? index = default;
            Guid? nodeId = default;
            string networkAdapterName = default;
            string label = default;
            string macAddress = default;
            long? linkSpeed = default;
            DataBoxEdgeNetworkAdapterStatus? status = default;
            DataBoxEdgeNetworkAdapterRdmaStatus? rdmaStatus = default;
            DataBoxEdgeNetworkAdapterDhcpStatus? dhcpStatus = default;
            DataBoxEdgeIPv4Config ipv4Configuration = default;
            DataBoxEdgeIPv6Config ipv6Configuration = default;
            string ipv6LinkLocalAddress = default;
            IReadOnlyList<string> dnsServers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adapterId"u8))
                {
                    adapterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adapterPosition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adapterPosition = DataBoxEdgeNetworkAdapterPosition.DeserializeDataBoxEdgeNetworkAdapterPosition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("networkAdapterName"u8))
                {
                    networkAdapterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataBoxEdgeNetworkAdapterStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdmaStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdmaStatus = new DataBoxEdgeNetworkAdapterRdmaStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dhcpStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dhcpStatus = new DataBoxEdgeNetworkAdapterDhcpStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv4Configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4Configuration = DataBoxEdgeIPv4Config.DeserializeDataBoxEdgeIPv4Config(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipv6Configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6Configuration = DataBoxEdgeIPv6Config.DeserializeDataBoxEdgeIPv6Config(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipv6LinkLocalAddress"u8))
                {
                    ipv6LinkLocalAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxEdgeNetworkAdapter(
                adapterId,
                adapterPosition,
                index,
                nodeId,
                networkAdapterName,
                label,
                macAddress,
                linkSpeed,
                status,
                rdmaStatus,
                dhcpStatus,
                ipv4Configuration,
                ipv6Configuration,
                ipv6LinkLocalAddress,
                dnsServers ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeNetworkAdapter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapter)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeNetworkAdapter IPersistableModel<DataBoxEdgeNetworkAdapter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxEdgeNetworkAdapter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeNetworkAdapter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
