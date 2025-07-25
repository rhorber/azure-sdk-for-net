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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class CdnOriginGroupData : IUtf8JsonSerializable, IJsonModel<CdnOriginGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnOriginGroupData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnOriginGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginGroupData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HealthProbeSettings))
            {
                if (HealthProbeSettings != null)
                {
                    writer.WritePropertyName("healthProbeSettings"u8);
                    writer.WriteObjectValue(HealthProbeSettings, options);
                }
                else
                {
                    writer.WriteNull("healthProbeSettings");
                }
            }
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes))
            {
                if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8);
                    writer.WriteNumberValue(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(ResponseBasedOriginErrorDetectionSettings))
            {
                if (ResponseBasedOriginErrorDetectionSettings != null)
                {
                    writer.WritePropertyName("responseBasedOriginErrorDetectionSettings"u8);
                    writer.WriteObjectValue(ResponseBasedOriginErrorDetectionSettings, options);
                }
                else
                {
                    writer.WriteNull("responseBasedOriginErrorDetectionSettings");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        CdnOriginGroupData IJsonModel<CdnOriginGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginGroupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnOriginGroupData(document.RootElement, options);
        }

        internal static CdnOriginGroupData DeserializeCdnOriginGroupData(JsonElement element, ModelReaderWriterOptions options = null)
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
            HealthProbeSettings healthProbeSettings = default;
            IList<WritableSubResource> origins = default;
            int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            ResponseBasedOriginErrorDetectionSettings responseBasedOriginErrorDetectionSettings = default;
            OriginGroupResourceState? resourceState = default;
            OriginGroupProvisioningState? provisioningState = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerCdnContext.Default);
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
                        if (property0.NameEquals("healthProbeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                healthProbeSettings = null;
                                continue;
                            }
                            healthProbeSettings = HealthProbeSettings.DeserializeHealthProbeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("origins"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerCdnContext.Default));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("responseBasedOriginErrorDetectionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                responseBasedOriginErrorDetectionSettings = null;
                                continue;
                            }
                            responseBasedOriginErrorDetectionSettings = ResponseBasedOriginErrorDetectionSettings.DeserializeResponseBasedOriginErrorDetectionSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new OriginGroupResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new OriginGroupProvisioningState(property0.Value.GetString());
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
            return new CdnOriginGroupData(
                id,
                name,
                type,
                systemData,
                healthProbeSettings,
                origins ?? new ChangeTrackingList<WritableSubResource>(),
                trafficRestorationTimeToHealedOrNewEndpointsInMinutes,
                responseBasedOriginErrorDetectionSettings,
                resourceState,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnOriginGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CdnOriginGroupData)} does not support writing '{options.Format}' format.");
            }
        }

        CdnOriginGroupData IPersistableModel<CdnOriginGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCdnOriginGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnOriginGroupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnOriginGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
