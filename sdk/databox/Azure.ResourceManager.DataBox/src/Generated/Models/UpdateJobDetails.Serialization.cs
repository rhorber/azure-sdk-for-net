// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class UpdateJobDetails : IUtf8JsonSerializable, IJsonModel<UpdateJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateJobDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateJobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateJobDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ContactDetails))
            {
                writer.WritePropertyName("contactDetails"u8);
                writer.WriteObjectValue(ContactDetails, options);
            }
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress, options);
            }
            if (Optional.IsDefined(ReverseShippingDetails))
            {
                writer.WritePropertyName("reverseShippingDetails"u8);
                writer.WriteObjectValue(ReverseShippingDetails, options);
            }
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue(Preferences, options);
            }
            if (Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey, options);
            }
            if (Optional.IsDefined(ReturnToCustomerPackageDetails))
            {
                writer.WritePropertyName("returnToCustomerPackageDetails"u8);
                writer.WriteObjectValue(ReturnToCustomerPackageDetails, options);
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

        UpdateJobDetails IJsonModel<UpdateJobDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateJobDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateJobDetails(document.RootElement, options);
        }

        internal static UpdateJobDetails DeserializeUpdateJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxContactDetails contactDetails = default;
            DataBoxShippingAddress shippingAddress = default;
            ReverseShippingDetails reverseShippingDetails = default;
            DataBoxOrderPreferences preferences = default;
            DataBoxKeyEncryptionKey keyEncryptionKey = default;
            PackageCarrierDetails returnToCustomerPackageDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contactDetails = DataBoxContactDetails.DeserializeDataBoxContactDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = DataBoxOrderPreferences.DeserializeDataBoxOrderPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = DataBoxKeyEncryptionKey.DeserializeDataBoxKeyEncryptionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnToCustomerPackageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnToCustomerPackageDetails = PackageCarrierDetails.DeserializePackageCarrierDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateJobDetails(
                contactDetails,
                shippingAddress,
                reverseShippingDetails,
                preferences,
                keyEncryptionKey,
                returnToCustomerPackageDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateJobDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxContext.Default);
                default:
                    throw new FormatException($"The model {nameof(UpdateJobDetails)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateJobDetails IPersistableModel<UpdateJobDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateJobDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateJobDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateJobDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
