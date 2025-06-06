// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessedMachineResource : IJsonModel<MigrationAssessedMachineData>
    {
        private static MigrationAssessedMachineData s_dataDeserializationInstance;
        private static MigrationAssessedMachineData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MigrationAssessedMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessedMachineData>)Data).Write(writer, options);

        MigrationAssessedMachineData IJsonModel<MigrationAssessedMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessedMachineData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MigrationAssessedMachineData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MigrationAssessedMachineData>(Data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        MigrationAssessedMachineData IPersistableModel<MigrationAssessedMachineData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MigrationAssessedMachineData>(data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        string IPersistableModel<MigrationAssessedMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MigrationAssessedMachineData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
