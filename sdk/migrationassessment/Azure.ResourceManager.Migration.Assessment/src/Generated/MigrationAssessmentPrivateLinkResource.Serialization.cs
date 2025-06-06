// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessmentPrivateLinkResource : IJsonModel<MigrationAssessmentPrivateLinkResourceData>
    {
        private static MigrationAssessmentPrivateLinkResourceData s_dataDeserializationInstance;
        private static MigrationAssessmentPrivateLinkResourceData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MigrationAssessmentPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentPrivateLinkResourceData>)Data).Write(writer, options);

        MigrationAssessmentPrivateLinkResourceData IJsonModel<MigrationAssessmentPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentPrivateLinkResourceData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MigrationAssessmentPrivateLinkResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MigrationAssessmentPrivateLinkResourceData>(Data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        MigrationAssessmentPrivateLinkResourceData IPersistableModel<MigrationAssessmentPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MigrationAssessmentPrivateLinkResourceData>(data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        string IPersistableModel<MigrationAssessmentPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MigrationAssessmentPrivateLinkResourceData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
