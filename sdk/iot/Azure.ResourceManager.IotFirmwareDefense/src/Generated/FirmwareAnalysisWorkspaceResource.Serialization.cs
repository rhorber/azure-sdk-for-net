// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.IotFirmwareDefense
{
    public partial class FirmwareAnalysisWorkspaceResource : IJsonModel<FirmwareAnalysisWorkspaceData>
    {
        void IJsonModel<FirmwareAnalysisWorkspaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FirmwareAnalysisWorkspaceData>)Data).Write(writer, options);

        FirmwareAnalysisWorkspaceData IJsonModel<FirmwareAnalysisWorkspaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FirmwareAnalysisWorkspaceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FirmwareAnalysisWorkspaceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FirmwareAnalysisWorkspaceData>(Data, options, AzureResourceManagerIotFirmwareDefenseContext.Default);

        FirmwareAnalysisWorkspaceData IPersistableModel<FirmwareAnalysisWorkspaceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FirmwareAnalysisWorkspaceData>(data, options, AzureResourceManagerIotFirmwareDefenseContext.Default);

        string IPersistableModel<FirmwareAnalysisWorkspaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FirmwareAnalysisWorkspaceData>)Data).GetFormatFromOptions(options);
    }
}
