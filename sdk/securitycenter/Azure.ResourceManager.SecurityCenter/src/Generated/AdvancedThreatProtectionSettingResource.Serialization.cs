// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class AdvancedThreatProtectionSettingResource : IJsonModel<AdvancedThreatProtectionSettingData>
    {
        private static AdvancedThreatProtectionSettingData s_dataDeserializationInstance;
        private static AdvancedThreatProtectionSettingData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<AdvancedThreatProtectionSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AdvancedThreatProtectionSettingData>)Data).Write(writer, options);

        AdvancedThreatProtectionSettingData IJsonModel<AdvancedThreatProtectionSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AdvancedThreatProtectionSettingData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<AdvancedThreatProtectionSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AdvancedThreatProtectionSettingData>(Data, options, AzureResourceManagerSecurityCenterContext.Default);

        AdvancedThreatProtectionSettingData IPersistableModel<AdvancedThreatProtectionSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AdvancedThreatProtectionSettingData>(data, options, AzureResourceManagerSecurityCenterContext.Default);

        string IPersistableModel<AdvancedThreatProtectionSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AdvancedThreatProtectionSettingData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
