// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceVcoresCapability : IUtf8JsonSerializable, IJsonModel<ManagedInstanceVcoresCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceVcoresCapability>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedInstanceVcoresCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportedMemorySizesInGB))
            {
                writer.WritePropertyName("supportedMemorySizesInGB"u8);
                writer.WriteObjectValue(SupportedMemorySizesInGB, options);
            }
            if (options.Format != "W" && Optional.IsDefined(IncludedMaxSize))
            {
                writer.WritePropertyName("includedMaxSize"u8);
                writer.WriteObjectValue(IncludedMaxSize, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedStorageSizes))
            {
                writer.WritePropertyName("supportedStorageSizes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedStorageSizes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IncludedStorageIOps))
            {
                writer.WritePropertyName("includedStorageIOps"u8);
                writer.WriteNumberValue(IncludedStorageIOps.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportedStorageIOps))
            {
                writer.WritePropertyName("supportedStorageIOps"u8);
                writer.WriteObjectValue(SupportedStorageIOps, options);
            }
            if (options.Format != "W" && Optional.IsDefined(IopsMinValueOverrideFactorPerSelectedStorageGB))
            {
                writer.WritePropertyName("iopsMinValueOverrideFactorPerSelectedStorageGB"u8);
                writer.WriteNumberValue(IopsMinValueOverrideFactorPerSelectedStorageGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IopsIncludedValueOverrideFactorPerSelectedStorageGB))
            {
                writer.WritePropertyName("iopsIncludedValueOverrideFactorPerSelectedStorageGB"u8);
                writer.WriteNumberValue(IopsIncludedValueOverrideFactorPerSelectedStorageGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IncludedStorageThroughputMBps))
            {
                writer.WritePropertyName("includedStorageThroughputMBps"u8);
                writer.WriteNumberValue(IncludedStorageThroughputMBps.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportedStorageThroughputMBps))
            {
                writer.WritePropertyName("supportedStorageThroughputMBps"u8);
                writer.WriteObjectValue(SupportedStorageThroughputMBps, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ThroughputMBpsMinValueOverrideFactorPerSelectedStorageGB))
            {
                writer.WritePropertyName("throughputMBpsMinValueOverrideFactorPerSelectedStorageGB"u8);
                writer.WriteNumberValue(ThroughputMBpsMinValueOverrideFactorPerSelectedStorageGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ThroughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB))
            {
                writer.WritePropertyName("throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB"u8);
                writer.WriteNumberValue(ThroughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsInstancePoolSupported))
            {
                writer.WritePropertyName("instancePoolSupported"u8);
                writer.WriteBooleanValue(IsInstancePoolSupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsStandaloneSupported))
            {
                writer.WritePropertyName("standaloneSupported"u8);
                writer.WriteBooleanValue(IsStandaloneSupported.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedMaintenanceConfigurations))
            {
                writer.WritePropertyName("supportedMaintenanceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMaintenanceConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        ManagedInstanceVcoresCapability IJsonModel<ManagedInstanceVcoresCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceVcoresCapability(document.RootElement, options);
        }

        internal static ManagedInstanceVcoresCapability DeserializeManagedInstanceVcoresCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? value = default;
            MaxLimitRangeCapability supportedMemorySizesInGB = default;
            MaxSizeCapability includedMaxSize = default;
            IReadOnlyList<MaxSizeRangeCapability> supportedStorageSizes = default;
            long? includedStorageIOps = default;
            MaxLimitRangeCapability supportedStorageIOps = default;
            double? iopsMinValueOverrideFactorPerSelectedStorageGB = default;
            double? iopsIncludedValueOverrideFactorPerSelectedStorageGB = default;
            long? includedStorageThroughputMBps = default;
            MaxLimitRangeCapability supportedStorageThroughputMBps = default;
            double? throughputMBpsMinValueOverrideFactorPerSelectedStorageGB = default;
            double? throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB = default;
            bool? instancePoolSupported = default;
            bool? standaloneSupported = default;
            IReadOnlyList<ManagedInstanceMaintenanceConfigurationCapability> supportedMaintenanceConfigurations = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("supportedMemorySizesInGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedMemorySizesInGB = MaxLimitRangeCapability.DeserializeMaxLimitRangeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("includedMaxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedStorageSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item, options));
                    }
                    supportedStorageSizes = array;
                    continue;
                }
                if (property.NameEquals("includedStorageIOps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedStorageIOps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedStorageIOps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedStorageIOps = MaxLimitRangeCapability.DeserializeMaxLimitRangeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("iopsMinValueOverrideFactorPerSelectedStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iopsMinValueOverrideFactorPerSelectedStorageGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("iopsIncludedValueOverrideFactorPerSelectedStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iopsIncludedValueOverrideFactorPerSelectedStorageGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("includedStorageThroughputMBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedStorageThroughputMBps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedStorageThroughputMBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedStorageThroughputMBps = MaxLimitRangeCapability.DeserializeMaxLimitRangeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("throughputMBpsMinValueOverrideFactorPerSelectedStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputMBpsMinValueOverrideFactorPerSelectedStorageGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("instancePoolSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instancePoolSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("standaloneSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standaloneSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceMaintenanceConfigurationCapability> array = new List<ManagedInstanceMaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceMaintenanceConfigurationCapability.DeserializeManagedInstanceMaintenanceConfigurationCapability(item, options));
                    }
                    supportedMaintenanceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedInstanceVcoresCapability(
                name,
                value,
                supportedMemorySizesInGB,
                includedMaxSize,
                supportedStorageSizes ?? new ChangeTrackingList<MaxSizeRangeCapability>(),
                includedStorageIOps,
                supportedStorageIOps,
                iopsMinValueOverrideFactorPerSelectedStorageGB,
                iopsIncludedValueOverrideFactorPerSelectedStorageGB,
                includedStorageThroughputMBps,
                supportedStorageThroughputMBps,
                throughputMBpsMinValueOverrideFactorPerSelectedStorageGB,
                throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB,
                instancePoolSupported,
                standaloneSupported,
                supportedMaintenanceConfigurations ?? new ChangeTrackingList<ManagedInstanceMaintenanceConfigurationCapability>(),
                status,
                reason,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Value))
                {
                    builder.Append("  value: ");
                    builder.AppendLine($"{Value.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedMemorySizesInGB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedMemorySizesInGB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SupportedMemorySizesInGB))
                {
                    builder.Append("  supportedMemorySizesInGB: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SupportedMemorySizesInGB, options, 2, false, "  supportedMemorySizesInGB: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IncludedMaxSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  includedMaxSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IncludedMaxSize))
                {
                    builder.Append("  includedMaxSize: ");
                    BicepSerializationHelpers.AppendChildObject(builder, IncludedMaxSize, options, 2, false, "  includedMaxSize: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedStorageSizes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedStorageSizes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedStorageSizes))
                {
                    if (SupportedStorageSizes.Any())
                    {
                        builder.Append("  supportedStorageSizes: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedStorageSizes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedStorageSizes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IncludedStorageIOps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  includedStorageIOps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IncludedStorageIOps))
                {
                    builder.Append("  includedStorageIOps: ");
                    builder.AppendLine($"'{IncludedStorageIOps.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedStorageIOps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedStorageIOps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SupportedStorageIOps))
                {
                    builder.Append("  supportedStorageIOps: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SupportedStorageIOps, options, 2, false, "  supportedStorageIOps: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IopsMinValueOverrideFactorPerSelectedStorageGB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  iopsMinValueOverrideFactorPerSelectedStorageGB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IopsMinValueOverrideFactorPerSelectedStorageGB))
                {
                    builder.Append("  iopsMinValueOverrideFactorPerSelectedStorageGB: ");
                    builder.AppendLine($"'{IopsMinValueOverrideFactorPerSelectedStorageGB.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IopsIncludedValueOverrideFactorPerSelectedStorageGB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  iopsIncludedValueOverrideFactorPerSelectedStorageGB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IopsIncludedValueOverrideFactorPerSelectedStorageGB))
                {
                    builder.Append("  iopsIncludedValueOverrideFactorPerSelectedStorageGB: ");
                    builder.AppendLine($"'{IopsIncludedValueOverrideFactorPerSelectedStorageGB.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IncludedStorageThroughputMBps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  includedStorageThroughputMBps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IncludedStorageThroughputMBps))
                {
                    builder.Append("  includedStorageThroughputMBps: ");
                    builder.AppendLine($"'{IncludedStorageThroughputMBps.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedStorageThroughputMBps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedStorageThroughputMBps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SupportedStorageThroughputMBps))
                {
                    builder.Append("  supportedStorageThroughputMBps: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SupportedStorageThroughputMBps, options, 2, false, "  supportedStorageThroughputMBps: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThroughputMBpsMinValueOverrideFactorPerSelectedStorageGB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  throughputMBpsMinValueOverrideFactorPerSelectedStorageGB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThroughputMBpsMinValueOverrideFactorPerSelectedStorageGB))
                {
                    builder.Append("  throughputMBpsMinValueOverrideFactorPerSelectedStorageGB: ");
                    builder.AppendLine($"'{ThroughputMBpsMinValueOverrideFactorPerSelectedStorageGB.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThroughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThroughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB))
                {
                    builder.Append("  throughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB: ");
                    builder.AppendLine($"'{ThroughputMBpsIncludedValueOverrideFactorPerSelectedStorageGB.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsInstancePoolSupported), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  instancePoolSupported: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsInstancePoolSupported))
                {
                    builder.Append("  instancePoolSupported: ");
                    var boolValue = IsInstancePoolSupported.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStandaloneSupported), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  standaloneSupported: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStandaloneSupported))
                {
                    builder.Append("  standaloneSupported: ");
                    var boolValue = IsStandaloneSupported.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedMaintenanceConfigurations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedMaintenanceConfigurations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedMaintenanceConfigurations))
                {
                    if (SupportedMaintenanceConfigurations.Any())
                    {
                        builder.Append("  supportedMaintenanceConfigurations: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedMaintenanceConfigurations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedMaintenanceConfigurations: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Reason))
                {
                    builder.Append("  reason: ");
                    if (Reason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Reason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Reason}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedInstanceVcoresCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSqlContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedInstanceVcoresCapability IPersistableModel<ManagedInstanceVcoresCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedInstanceVcoresCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceVcoresCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
