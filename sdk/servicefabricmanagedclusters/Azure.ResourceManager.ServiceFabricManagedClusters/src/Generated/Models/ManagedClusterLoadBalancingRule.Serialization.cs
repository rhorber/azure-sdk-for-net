// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterLoadBalancingRule : IUtf8JsonSerializable, IJsonModel<ManagedClusterLoadBalancingRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterLoadBalancingRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterLoadBalancingRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancingRule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("frontendPort"u8);
            writer.WriteNumberValue(FrontendPort);
            writer.WritePropertyName("backendPort"u8);
            writer.WriteNumberValue(BackendPort);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            if (Optional.IsDefined(ProbePort))
            {
                writer.WritePropertyName("probePort"u8);
                writer.WriteNumberValue(ProbePort.Value);
            }
            writer.WritePropertyName("probeProtocol"u8);
            writer.WriteStringValue(ProbeProtocol.ToString());
            if (Optional.IsDefined(ProbeRequestPath))
            {
                writer.WritePropertyName("probeRequestPath"u8);
                writer.WriteStringValue(ProbeRequestPath);
            }
            if (Optional.IsDefined(LoadDistribution))
            {
                writer.WritePropertyName("loadDistribution"u8);
                writer.WriteStringValue(LoadDistribution);
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

        ManagedClusterLoadBalancingRule IJsonModel<ManagedClusterLoadBalancingRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancingRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterLoadBalancingRule(document.RootElement, options);
        }

        internal static ManagedClusterLoadBalancingRule DeserializeManagedClusterLoadBalancingRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int frontendPort = default;
            int backendPort = default;
            ManagedClusterLoadBalancingRuleTransportProtocol protocol = default;
            int? probePort = default;
            ManagedClusterLoadBalanceProbeProtocol probeProtocol = default;
            string probeRequestPath = default;
            string loadDistribution = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frontendPort"u8))
                {
                    frontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    backendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new ManagedClusterLoadBalancingRuleTransportProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("probePort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probePort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probeProtocol"u8))
                {
                    probeProtocol = new ManagedClusterLoadBalanceProbeProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("probeRequestPath"u8))
                {
                    probeRequestPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadDistribution"u8))
                {
                    loadDistribution = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterLoadBalancingRule(
                frontendPort,
                backendPort,
                protocol,
                probePort,
                probeProtocol,
                probeRequestPath,
                loadDistribution,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterLoadBalancingRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceFabricManagedClustersContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancingRule)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterLoadBalancingRule IPersistableModel<ManagedClusterLoadBalancingRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedClusterLoadBalancingRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancingRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterLoadBalancingRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
