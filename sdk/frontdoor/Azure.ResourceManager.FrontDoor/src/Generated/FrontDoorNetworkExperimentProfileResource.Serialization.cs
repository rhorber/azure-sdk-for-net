// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorNetworkExperimentProfileResource : IJsonModel<FrontDoorNetworkExperimentProfileData>
    {
        private static FrontDoorNetworkExperimentProfileData s_dataDeserializationInstance;
        private static FrontDoorNetworkExperimentProfileData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<FrontDoorNetworkExperimentProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorNetworkExperimentProfileData>)Data).Write(writer, options);

        FrontDoorNetworkExperimentProfileData IJsonModel<FrontDoorNetworkExperimentProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorNetworkExperimentProfileData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorNetworkExperimentProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FrontDoorNetworkExperimentProfileData>(Data, options, AzureResourceManagerFrontDoorContext.Default);

        FrontDoorNetworkExperimentProfileData IPersistableModel<FrontDoorNetworkExperimentProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorNetworkExperimentProfileData>(data, options, AzureResourceManagerFrontDoorContext.Default);

        string IPersistableModel<FrontDoorNetworkExperimentProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorNetworkExperimentProfileData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
