// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineScaleSetExtensionResource : IJsonModel<VirtualMachineScaleSetExtensionData>
    {
        private static VirtualMachineScaleSetExtensionData s_dataDeserializationInstance;
        private static VirtualMachineScaleSetExtensionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<VirtualMachineScaleSetExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetExtensionData>)Data).Write(writer, options);

        VirtualMachineScaleSetExtensionData IJsonModel<VirtualMachineScaleSetExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetExtensionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<VirtualMachineScaleSetExtensionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<VirtualMachineScaleSetExtensionData>(Data, options, AzureResourceManagerComputeContext.Default);

        VirtualMachineScaleSetExtensionData IPersistableModel<VirtualMachineScaleSetExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VirtualMachineScaleSetExtensionData>(data, options, AzureResourceManagerComputeContext.Default);

        string IPersistableModel<VirtualMachineScaleSetExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VirtualMachineScaleSetExtensionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
