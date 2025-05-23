// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureMLExecutePipelineActivity : IUtf8JsonSerializable, IJsonModel<AzureMLExecutePipelineActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureMLExecutePipelineActivity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureMLExecutePipelineActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLExecutePipelineActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLExecutePipelineActivity)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MLPipelineId))
            {
                writer.WritePropertyName("mlPipelineId"u8);
                JsonSerializer.Serialize(writer, MLPipelineId);
            }
            if (Optional.IsDefined(MLPipelineEndpointId))
            {
                writer.WritePropertyName("mlPipelineEndpointId"u8);
                JsonSerializer.Serialize(writer, MLPipelineEndpointId);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                JsonSerializer.Serialize(writer, Version);
            }
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName"u8);
                JsonSerializer.Serialize(writer, ExperimentName);
            }
            if (Optional.IsDefined(MLPipelineParameters))
            {
                writer.WritePropertyName("mlPipelineParameters"u8);
                JsonSerializer.Serialize(writer, MLPipelineParameters);
            }
            if (Optional.IsDefined(DataPathAssignments))
            {
                writer.WritePropertyName("dataPathAssignments"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DataPathAssignments);
#else
                using (JsonDocument document = JsonDocument.Parse(DataPathAssignments, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(MLParentRunId))
            {
                writer.WritePropertyName("mlParentRunId"u8);
                JsonSerializer.Serialize(writer, MLParentRunId);
            }
            if (Optional.IsDefined(ContinueOnStepFailure))
            {
                writer.WritePropertyName("continueOnStepFailure"u8);
                JsonSerializer.Serialize(writer, ContinueOnStepFailure);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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

        AzureMLExecutePipelineActivity IJsonModel<AzureMLExecutePipelineActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLExecutePipelineActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLExecutePipelineActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMLExecutePipelineActivity(document.RootElement, options);
        }

        internal static AzureMLExecutePipelineActivity DeserializeAzureMLExecutePipelineActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryLinkedServiceReference linkedServiceName = default;
            PipelineActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            PipelineActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<PipelineActivityDependency> dependsOn = default;
            IList<PipelineActivityUserProperty> userProperties = default;
            DataFactoryElement<string> mlPipelineId = default;
            DataFactoryElement<string> mlPipelineEndpointId = default;
            DataFactoryElement<string> version = default;
            DataFactoryElement<string> experimentName = default;
            DataFactoryElement<IDictionary<string, string>> mlPipelineParameters = default;
            BinaryData dataPathAssignments = default;
            DataFactoryElement<string> mlParentRunId = default;
            DataFactoryElement<bool> continueOnStepFailure = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item, options));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("mlPipelineId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mlPipelineId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("mlPipelineEndpointId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mlPipelineEndpointId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("experimentName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            experimentName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("mlPipelineParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mlPipelineParameters = JsonSerializer.Deserialize<DataFactoryElement<IDictionary<string, string>>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("dataPathAssignments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataPathAssignments = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("mlParentRunId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mlParentRunId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("continueOnStepFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            continueOnStepFailure = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureMLExecutePipelineActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<PipelineActivityDependency>(),
                userProperties ?? new ChangeTrackingList<PipelineActivityUserProperty>(),
                additionalProperties,
                linkedServiceName,
                policy,
                mlPipelineId,
                mlPipelineEndpointId,
                version,
                experimentName,
                mlPipelineParameters,
                dataPathAssignments,
                mlParentRunId,
                continueOnStepFailure);
        }

        BinaryData IPersistableModel<AzureMLExecutePipelineActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLExecutePipelineActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureMLExecutePipelineActivity)} does not support writing '{options.Format}' format.");
            }
        }

        AzureMLExecutePipelineActivity IPersistableModel<AzureMLExecutePipelineActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLExecutePipelineActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureMLExecutePipelineActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureMLExecutePipelineActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureMLExecutePipelineActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
