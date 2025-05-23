// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationSourceControlResource : IJsonModel<AutomationSourceControlData>
    {
        private static AutomationSourceControlData s_dataDeserializationInstance;
        private static AutomationSourceControlData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<AutomationSourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutomationSourceControlData>)Data).Write(writer, options);

        AutomationSourceControlData IJsonModel<AutomationSourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutomationSourceControlData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<AutomationSourceControlData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AutomationSourceControlData>(Data, options, AzureResourceManagerAutomationContext.Default);

        AutomationSourceControlData IPersistableModel<AutomationSourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutomationSourceControlData>(data, options, AzureResourceManagerAutomationContext.Default);

        string IPersistableModel<AutomationSourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutomationSourceControlData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
