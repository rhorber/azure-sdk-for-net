// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessmentGroupResource : IJsonModel<MigrationAssessmentGroupData>
    {
        private static MigrationAssessmentGroupData s_dataDeserializationInstance;
        private static MigrationAssessmentGroupData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MigrationAssessmentGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentGroupData>)Data).Write(writer, options);

        MigrationAssessmentGroupData IJsonModel<MigrationAssessmentGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentGroupData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MigrationAssessmentGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MigrationAssessmentGroupData>(Data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        MigrationAssessmentGroupData IPersistableModel<MigrationAssessmentGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MigrationAssessmentGroupData>(data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        string IPersistableModel<MigrationAssessmentGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MigrationAssessmentGroupData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
