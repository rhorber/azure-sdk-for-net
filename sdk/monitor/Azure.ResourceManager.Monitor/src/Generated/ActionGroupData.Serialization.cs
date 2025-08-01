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
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class ActionGroupData : IUtf8JsonSerializable, IJsonModel<ActionGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActionGroupData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ActionGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActionGroupData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, ModelSerializationExtensions.WireV3Options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupShortName))
            {
                writer.WritePropertyName("groupShortName"u8);
                writer.WriteStringValue(GroupShortName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(EmailReceivers))
            {
                writer.WritePropertyName("emailReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in EmailReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SmsReceivers))
            {
                writer.WritePropertyName("smsReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in SmsReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WebhookReceivers))
            {
                writer.WritePropertyName("webhookReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in WebhookReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ItsmReceivers))
            {
                writer.WritePropertyName("itsmReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in ItsmReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AzureAppPushReceivers))
            {
                writer.WritePropertyName("azureAppPushReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in AzureAppPushReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AutomationRunbookReceivers))
            {
                writer.WritePropertyName("automationRunbookReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in AutomationRunbookReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VoiceReceivers))
            {
                writer.WritePropertyName("voiceReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in VoiceReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogicAppReceivers))
            {
                writer.WritePropertyName("logicAppReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in LogicAppReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AzureFunctionReceivers))
            {
                writer.WritePropertyName("azureFunctionReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in AzureFunctionReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ArmRoleReceivers))
            {
                writer.WritePropertyName("armRoleReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in ArmRoleReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubReceivers))
            {
                writer.WritePropertyName("eventHubReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in EventHubReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncidentReceivers))
            {
                writer.WritePropertyName("incidentReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in IncidentReceivers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        ActionGroupData IJsonModel<ActionGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActionGroupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActionGroupData(document.RootElement, options);
        }

        internal static ActionGroupData DeserializeActionGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string groupShortName = default;
            bool? enabled = default;
            IList<MonitorEmailReceiver> emailReceivers = default;
            IList<MonitorSmsReceiver> smsReceivers = default;
            IList<MonitorWebhookReceiver> webhookReceivers = default;
            IList<MonitorItsmReceiver> itsmReceivers = default;
            IList<MonitorAzureAppPushReceiver> azureAppPushReceivers = default;
            IList<MonitorAutomationRunbookReceiver> automationRunbookReceivers = default;
            IList<MonitorVoiceReceiver> voiceReceivers = default;
            IList<MonitorLogicAppReceiver> logicAppReceivers = default;
            IList<MonitorAzureFunctionReceiver> azureFunctionReceivers = default;
            IList<MonitorArmRoleReceiver> armRoleReceivers = default;
            IList<MonitorEventHubReceiver> eventHubReceivers = default;
            IList<IncidentReceiver> incidentReceivers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireV3Options, AzureResourceManagerMonitorContext.Default);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerMonitorContext.Default);
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
                        if (property0.NameEquals("groupShortName"u8))
                        {
                            groupShortName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("emailReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorEmailReceiver> array = new List<MonitorEmailReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorEmailReceiver.DeserializeMonitorEmailReceiver(item, options));
                            }
                            emailReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("smsReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorSmsReceiver> array = new List<MonitorSmsReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorSmsReceiver.DeserializeMonitorSmsReceiver(item, options));
                            }
                            smsReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("webhookReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorWebhookReceiver> array = new List<MonitorWebhookReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorWebhookReceiver.DeserializeMonitorWebhookReceiver(item, options));
                            }
                            webhookReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("itsmReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorItsmReceiver> array = new List<MonitorItsmReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorItsmReceiver.DeserializeMonitorItsmReceiver(item, options));
                            }
                            itsmReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("azureAppPushReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorAzureAppPushReceiver> array = new List<MonitorAzureAppPushReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorAzureAppPushReceiver.DeserializeMonitorAzureAppPushReceiver(item, options));
                            }
                            azureAppPushReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("automationRunbookReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorAutomationRunbookReceiver> array = new List<MonitorAutomationRunbookReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorAutomationRunbookReceiver.DeserializeMonitorAutomationRunbookReceiver(item, options));
                            }
                            automationRunbookReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("voiceReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorVoiceReceiver> array = new List<MonitorVoiceReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorVoiceReceiver.DeserializeMonitorVoiceReceiver(item, options));
                            }
                            voiceReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("logicAppReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorLogicAppReceiver> array = new List<MonitorLogicAppReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorLogicAppReceiver.DeserializeMonitorLogicAppReceiver(item, options));
                            }
                            logicAppReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("azureFunctionReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorAzureFunctionReceiver> array = new List<MonitorAzureFunctionReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorAzureFunctionReceiver.DeserializeMonitorAzureFunctionReceiver(item, options));
                            }
                            azureFunctionReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("armRoleReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorArmRoleReceiver> array = new List<MonitorArmRoleReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorArmRoleReceiver.DeserializeMonitorArmRoleReceiver(item, options));
                            }
                            armRoleReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("eventHubReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MonitorEventHubReceiver> array = new List<MonitorEventHubReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorEventHubReceiver.DeserializeMonitorEventHubReceiver(item, options));
                            }
                            eventHubReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("incidentReceivers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IncidentReceiver> array = new List<IncidentReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IncidentReceiver.DeserializeIncidentReceiver(item, options));
                            }
                            incidentReceivers = array;
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
            return new ActionGroupData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                groupShortName,
                enabled,
                emailReceivers ?? new ChangeTrackingList<MonitorEmailReceiver>(),
                smsReceivers ?? new ChangeTrackingList<MonitorSmsReceiver>(),
                webhookReceivers ?? new ChangeTrackingList<MonitorWebhookReceiver>(),
                itsmReceivers ?? new ChangeTrackingList<MonitorItsmReceiver>(),
                azureAppPushReceivers ?? new ChangeTrackingList<MonitorAzureAppPushReceiver>(),
                automationRunbookReceivers ?? new ChangeTrackingList<MonitorAutomationRunbookReceiver>(),
                voiceReceivers ?? new ChangeTrackingList<MonitorVoiceReceiver>(),
                logicAppReceivers ?? new ChangeTrackingList<MonitorLogicAppReceiver>(),
                azureFunctionReceivers ?? new ChangeTrackingList<MonitorAzureFunctionReceiver>(),
                armRoleReceivers ?? new ChangeTrackingList<MonitorArmRoleReceiver>(),
                eventHubReceivers ?? new ChangeTrackingList<MonitorEventHubReceiver>(),
                incidentReceivers ?? new ChangeTrackingList<IncidentReceiver>(),
                identity,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ActionGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ActionGroupData)} does not support writing '{options.Format}' format.");
            }
        }

        ActionGroupData IPersistableModel<ActionGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeActionGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActionGroupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActionGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
