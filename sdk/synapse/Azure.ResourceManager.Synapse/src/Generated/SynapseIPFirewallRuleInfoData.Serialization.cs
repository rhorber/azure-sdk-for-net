// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseIPFirewallRuleInfoData : IUtf8JsonSerializable, IJsonModel<SynapseIPFirewallRuleInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIPFirewallRuleInfoData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseIPFirewallRuleInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIPFirewallRuleInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIPFirewallRuleInfoData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EndIPAddress))
            {
                writer.WritePropertyName("endIpAddress"u8);
                writer.WriteStringValue(EndIPAddress.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(StartIPAddress))
            {
                writer.WritePropertyName("startIpAddress"u8);
                writer.WriteStringValue(StartIPAddress.ToString());
            }
            writer.WriteEndObject();
        }

        SynapseIPFirewallRuleInfoData IJsonModel<SynapseIPFirewallRuleInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIPFirewallRuleInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIPFirewallRuleInfoData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIPFirewallRuleInfoData(document.RootElement, options);
        }

        internal static SynapseIPFirewallRuleInfoData DeserializeSynapseIPFirewallRuleInfoData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IPAddress endIPAddress = default;
            SynapseProvisioningState? provisioningState = default;
            IPAddress startIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerSynapseContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endIPAddress = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SynapseProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startIPAddress = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseIPFirewallRuleInfoData(
                id,
                name,
                type,
                systemData,
                endIPAddress,
                provisioningState,
                startIPAddress,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIPFirewallRuleInfoData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIPFirewallRuleInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSynapseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SynapseIPFirewallRuleInfoData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseIPFirewallRuleInfoData IPersistableModel<SynapseIPFirewallRuleInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIPFirewallRuleInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseIPFirewallRuleInfoData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIPFirewallRuleInfoData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIPFirewallRuleInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
