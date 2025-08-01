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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionPatch : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GalleryImageVersionPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionPatch)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublishingProfile))
            {
                writer.WritePropertyName("publishingProfile"u8);
                writer.WriteObjectValue(PublishingProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile, options);
            }
            if (Optional.IsDefined(SafetyProfile))
            {
                writer.WritePropertyName("safetyProfile"u8);
                writer.WriteObjectValue(SafetyProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationStatus))
            {
                writer.WritePropertyName("replicationStatus"u8);
                writer.WriteObjectValue(ReplicationStatus, options);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile, options);
            }
            if (Optional.IsDefined(Restore))
            {
                writer.WritePropertyName("restore"u8);
                writer.WriteBooleanValue(Restore.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ValidationsProfile))
            {
                writer.WritePropertyName("validationsProfile"u8);
                writer.WriteObjectValue(ValidationsProfile, options);
            }
            writer.WriteEndObject();
        }

        GalleryImageVersionPatch IJsonModel<GalleryImageVersionPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionPatch(document.RootElement, options);
        }

        internal static GalleryImageVersionPatch DeserializeGalleryImageVersionPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            GalleryImageVersionPublishingProfile publishingProfile = default;
            GalleryProvisioningState? provisioningState = default;
            GalleryImageVersionStorageProfile storageProfile = default;
            GalleryImageVersionSafetyProfile safetyProfile = default;
            ReplicationStatus replicationStatus = default;
            ImageVersionSecurityProfile securityProfile = default;
            bool? restore = default;
            GalleryImageValidationsProfile validationsProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerComputeContext.Default);
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
                        if (property0.NameEquals("publishingProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishingProfile = GalleryImageVersionPublishingProfile.DeserializeGalleryImageVersionPublishingProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new GalleryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = GalleryImageVersionStorageProfile.DeserializeGalleryImageVersionStorageProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("safetyProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            safetyProfile = GalleryImageVersionSafetyProfile.DeserializeGalleryImageVersionSafetyProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("replicationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationStatus = ReplicationStatus.DeserializeReplicationStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = ImageVersionSecurityProfile.DeserializeImageVersionSecurityProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("restore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restore = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("validationsProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationsProfile = GalleryImageValidationsProfile.DeserializeGalleryImageValidationsProfile(property0.Value, options);
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
            return new GalleryImageVersionPatch(
                id,
                name,
                type,
                systemData,
                publishingProfile,
                provisioningState,
                storageProfile,
                safetyProfile,
                replicationStatus,
                securityProfile,
                restore,
                validationsProfile,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryImageVersionPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionPatch)} does not support writing '{options.Format}' format.");
            }
        }

        GalleryImageVersionPatch IPersistableModel<GalleryImageVersionPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGalleryImageVersionPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersionPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
