// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArtifactStorePropertiesFormat : IUtf8JsonSerializable, IJsonModel<ArtifactStorePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArtifactStorePropertiesFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArtifactStorePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArtifactStorePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArtifactStorePropertiesFormat)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(StoreType))
            {
                writer.WritePropertyName("storeType"u8);
                writer.WriteStringValue(StoreType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationStrategy))
            {
                writer.WritePropertyName("replicationStrategy"u8);
                writer.WriteStringValue(ReplicationStrategy.Value.ToString());
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageResourceId))
            {
                writer.WritePropertyName("storageResourceId"u8);
                writer.WriteStringValue(StorageResourceId);
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

        ArtifactStorePropertiesFormat IJsonModel<ArtifactStorePropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArtifactStorePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArtifactStorePropertiesFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArtifactStorePropertiesFormat(document.RootElement, options);
        }

        internal static ArtifactStorePropertiesFormat DeserializeArtifactStorePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            ArtifactStoreType? storeType = default;
            ArtifactReplicationStrategy? replicationStrategy = default;
            ArtifactStorePropertiesFormatManagedResourceGroupConfiguration managedResourceGroupConfiguration = default;
            ResourceIdentifier storageResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storeType = new ArtifactStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationStrategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationStrategy = new ArtifactReplicationStrategy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedResourceGroupConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedResourceGroupConfiguration = ArtifactStorePropertiesFormatManagedResourceGroupConfiguration.DeserializeArtifactStorePropertiesFormatManagedResourceGroupConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArtifactStorePropertiesFormat(
                provisioningState,
                storeType,
                replicationStrategy,
                managedResourceGroupConfiguration,
                storageResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArtifactStorePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArtifactStorePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ArtifactStorePropertiesFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ArtifactStorePropertiesFormat IPersistableModel<ArtifactStorePropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArtifactStorePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeArtifactStorePropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArtifactStorePropertiesFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArtifactStorePropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
