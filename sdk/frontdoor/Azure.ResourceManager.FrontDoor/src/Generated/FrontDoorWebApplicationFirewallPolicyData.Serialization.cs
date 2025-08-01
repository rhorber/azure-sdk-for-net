// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorWebApplicationFirewallPolicyData : IUtf8JsonSerializable, IJsonModel<FrontDoorWebApplicationFirewallPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorWebApplicationFirewallPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FrontDoorWebApplicationFirewallPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorWebApplicationFirewallPolicyData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicySettings))
            {
                writer.WritePropertyName("policySettings"u8);
                writer.WriteObjectValue(PolicySettings, options);
            }
            if (Optional.IsDefined(CustomRuleList))
            {
                writer.WritePropertyName("customRules"u8);
                writer.WriteObjectValue(CustomRuleList, options);
            }
            if (Optional.IsDefined(ManagedRules))
            {
                writer.WritePropertyName("managedRules"u8);
                writer.WriteObjectValue(ManagedRules, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FrontendEndpointLinks))
            {
                writer.WritePropertyName("frontendEndpointLinks"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendEndpointLinks)
                {
                    ((IJsonModel<SubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RoutingRuleLinks))
            {
                writer.WritePropertyName("routingRuleLinks"u8);
                writer.WriteStartArray();
                foreach (var item in RoutingRuleLinks)
                {
                    ((IJsonModel<SubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SecurityPolicyLinks))
            {
                writer.WritePropertyName("securityPolicyLinks"u8);
                writer.WriteStartArray();
                foreach (var item in SecurityPolicyLinks)
                {
                    ((IJsonModel<SubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        FrontDoorWebApplicationFirewallPolicyData IJsonModel<FrontDoorWebApplicationFirewallPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorWebApplicationFirewallPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorWebApplicationFirewallPolicyData(document.RootElement, options);
        }

        internal static FrontDoorWebApplicationFirewallPolicyData DeserializeFrontDoorWebApplicationFirewallPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            FrontDoorSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            FrontDoorWebApplicationFirewallPolicySettings policySettings = default;
            CustomRuleList customRules = default;
            ManagedRuleSetList managedRules = default;
            IReadOnlyList<SubResource> frontendEndpointLinks = default;
            IReadOnlyList<SubResource> routingRuleLinks = default;
            IReadOnlyList<SubResource> securityPolicyLinks = default;
            string provisioningState = default;
            FrontDoorWebApplicationFirewallPolicyResourceState? resourceState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = FrontDoorSku.DeserializeFrontDoorSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerFrontDoorContext.Default);
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
                        if (property0.NameEquals("policySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policySettings = FrontDoorWebApplicationFirewallPolicySettings.DeserializeFrontDoorWebApplicationFirewallPolicySettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customRules = CustomRuleList.DeserializeCustomRuleList(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedRules = ManagedRuleSetList.DeserializeManagedRuleSetList(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("frontendEndpointLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<SubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerFrontDoorContext.Default));
                            }
                            frontendEndpointLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("routingRuleLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<SubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerFrontDoorContext.Default));
                            }
                            routingRuleLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("securityPolicyLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<SubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerFrontDoorContext.Default));
                            }
                            securityPolicyLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorWebApplicationFirewallPolicyResourceState(property0.Value.GetString());
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
            return new FrontDoorWebApplicationFirewallPolicyData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                etag,
                sku,
                policySettings,
                customRules,
                managedRules,
                frontendEndpointLinks ?? new ChangeTrackingList<SubResource>(),
                routingRuleLinks ?? new ChangeTrackingList<SubResource>(),
                securityPolicyLinks ?? new ChangeTrackingList<SubResource>(),
                provisioningState,
                resourceState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerFrontDoorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorWebApplicationFirewallPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        FrontDoorWebApplicationFirewallPolicyData IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFrontDoorWebApplicationFirewallPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorWebApplicationFirewallPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorWebApplicationFirewallPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
