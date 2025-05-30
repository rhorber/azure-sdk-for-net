// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class HanaDBProviderInstanceProperties : IUtf8JsonSerializable, IJsonModel<HanaDBProviderInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HanaDBProviderInstanceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HanaDBProviderInstanceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HanaDBProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HanaDBProviderInstanceProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(DBName))
            {
                writer.WritePropertyName("dbName"u8);
                writer.WriteStringValue(DBName);
            }
            if (Optional.IsDefined(SqlPort))
            {
                writer.WritePropertyName("sqlPort"u8);
                writer.WriteStringValue(SqlPort);
            }
            if (Optional.IsDefined(InstanceNumber))
            {
                writer.WritePropertyName("instanceNumber"u8);
                writer.WriteStringValue(InstanceNumber);
            }
            if (Optional.IsDefined(DBUsername))
            {
                writer.WritePropertyName("dbUsername"u8);
                writer.WriteStringValue(DBUsername);
            }
            if (Optional.IsDefined(DBPassword))
            {
                writer.WritePropertyName("dbPassword"u8);
                writer.WriteStringValue(DBPassword);
            }
            if (Optional.IsDefined(DBPasswordUri))
            {
                writer.WritePropertyName("dbPasswordUri"u8);
                writer.WriteStringValue(DBPasswordUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SslHostNameInCertificate))
            {
                writer.WritePropertyName("sslHostNameInCertificate"u8);
                writer.WriteStringValue(SslHostNameInCertificate);
            }
            if (Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Optional.IsDefined(SapSid))
            {
                writer.WritePropertyName("sapSid"u8);
                writer.WriteStringValue(SapSid);
            }
        }

        HanaDBProviderInstanceProperties IJsonModel<HanaDBProviderInstanceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HanaDBProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HanaDBProviderInstanceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHanaDBProviderInstanceProperties(document.RootElement, options);
        }

        internal static HanaDBProviderInstanceProperties DeserializeHanaDBProviderInstanceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostname = default;
            string dbName = default;
            string sqlPort = default;
            string instanceNumber = default;
            string dbUsername = default;
            string dbPassword = default;
            Uri dbPasswordUri = default;
            Uri sslCertificateUri = default;
            string sslHostNameInCertificate = default;
            SapSslPreference? sslPreference = default;
            string sapSid = default;
            string providerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbName"u8))
                {
                    dbName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlPort"u8))
                {
                    sqlPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceNumber"u8))
                {
                    instanceNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUsername"u8))
                {
                    dbUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPassword"u8))
                {
                    dbPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbPasswordUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslHostNameInCertificate"u8))
                {
                    sslHostNameInCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapSid"u8))
                {
                    sapSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HanaDBProviderInstanceProperties(
                providerType,
                serializedAdditionalRawData,
                hostname,
                dbName,
                sqlPort,
                instanceNumber,
                dbUsername,
                dbPassword,
                dbPasswordUri,
                sslCertificateUri,
                sslHostNameInCertificate,
                sslPreference,
                sapSid);
        }

        BinaryData IPersistableModel<HanaDBProviderInstanceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HanaDBProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerWorkloadsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HanaDBProviderInstanceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HanaDBProviderInstanceProperties IPersistableModel<HanaDBProviderInstanceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HanaDBProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHanaDBProviderInstanceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HanaDBProviderInstanceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HanaDBProviderInstanceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
