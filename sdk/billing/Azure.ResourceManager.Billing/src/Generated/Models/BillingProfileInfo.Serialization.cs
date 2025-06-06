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

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingProfileInfo : IUtf8JsonSerializable, IJsonModel<BillingProfileInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingProfileInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingProfileInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProfileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingProfileInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BillingAccountId))
            {
                writer.WritePropertyName("billingAccountId"u8);
                writer.WriteStringValue(BillingAccountId);
            }
            if (Optional.IsDefined(BillingProfileDisplayName))
            {
                writer.WritePropertyName("billingProfileDisplayName"u8);
                writer.WriteStringValue(BillingProfileDisplayName);
            }
            if (Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (Optional.IsDefined(BillingProfileSystemId))
            {
                writer.WritePropertyName("billingProfileSystemId"u8);
                writer.WriteStringValue(BillingProfileSystemId);
            }
            if (Optional.IsDefined(IndirectRelationshipOrganizationName))
            {
                writer.WritePropertyName("indirectRelationshipOrganizationName"u8);
                writer.WriteStringValue(IndirectRelationshipOrganizationName);
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

        BillingProfileInfo IJsonModel<BillingProfileInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProfileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingProfileInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingProfileInfo(document.RootElement, options);
        }

        internal static BillingProfileInfo DeserializeBillingProfileInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier billingAccountId = default;
            string billingProfileDisplayName = default;
            ResourceIdentifier billingProfileId = default;
            string billingProfileSystemId = default;
            string indirectRelationshipOrganizationName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfileDisplayName"u8))
                {
                    billingProfileDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfileId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfileSystemId"u8))
                {
                    billingProfileSystemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indirectRelationshipOrganizationName"u8))
                {
                    indirectRelationshipOrganizationName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingProfileInfo(
                billingAccountId,
                billingProfileDisplayName,
                billingProfileId,
                billingProfileSystemId,
                indirectRelationshipOrganizationName,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingAccountId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingAccountId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingAccountId))
                {
                    builder.Append("  billingAccountId: ");
                    builder.AppendLine($"'{BillingAccountId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileDisplayName))
                {
                    builder.Append("  billingProfileDisplayName: ");
                    if (BillingProfileDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingProfileDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingProfileDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileId))
                {
                    builder.Append("  billingProfileId: ");
                    builder.AppendLine($"'{BillingProfileId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileSystemId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileSystemId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileSystemId))
                {
                    builder.Append("  billingProfileSystemId: ");
                    if (BillingProfileSystemId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingProfileSystemId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingProfileSystemId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IndirectRelationshipOrganizationName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  indirectRelationshipOrganizationName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IndirectRelationshipOrganizationName))
                {
                    builder.Append("  indirectRelationshipOrganizationName: ");
                    if (IndirectRelationshipOrganizationName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{IndirectRelationshipOrganizationName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{IndirectRelationshipOrganizationName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingProfileInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProfileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerBillingContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingProfileInfo)} does not support writing '{options.Format}' format.");
            }
        }

        BillingProfileInfo IPersistableModel<BillingProfileInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProfileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBillingProfileInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingProfileInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingProfileInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
