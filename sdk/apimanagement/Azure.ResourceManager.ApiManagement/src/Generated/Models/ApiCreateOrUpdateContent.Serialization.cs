// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<ApiCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiCreateOrUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdateContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AuthenticationSettings))
            {
                writer.WritePropertyName("authenticationSettings"u8);
                writer.WriteObjectValue(AuthenticationSettings, options);
            }
            if (Optional.IsDefined(SubscriptionKeyParameterNames))
            {
                writer.WritePropertyName("subscriptionKeyParameterNames"u8);
                writer.WriteObjectValue(SubscriptionKeyParameterNames, options);
            }
            if (Optional.IsDefined(ApiType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ApiType.Value.ToString());
            }
            if (Optional.IsDefined(ApiRevision))
            {
                writer.WritePropertyName("apiRevision"u8);
                writer.WriteStringValue(ApiRevision);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(IsCurrent))
            {
                writer.WritePropertyName("isCurrent"u8);
                writer.WriteBooleanValue(IsCurrent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsOnline))
            {
                writer.WritePropertyName("isOnline"u8);
                writer.WriteBooleanValue(IsOnline.Value);
            }
            if (Optional.IsDefined(ApiRevisionDescription))
            {
                writer.WritePropertyName("apiRevisionDescription"u8);
                writer.WriteStringValue(ApiRevisionDescription);
            }
            if (Optional.IsDefined(ApiVersionDescription))
            {
                writer.WritePropertyName("apiVersionDescription"u8);
                writer.WriteStringValue(ApiVersionDescription);
            }
            if (Optional.IsDefined(ApiVersionSetId))
            {
                writer.WritePropertyName("apiVersionSetId"u8);
                writer.WriteStringValue(ApiVersionSetId);
            }
            if (Optional.IsDefined(IsSubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired"u8);
                writer.WriteBooleanValue(IsSubscriptionRequired.Value);
            }
            if (Optional.IsDefined(TermsOfServiceLink))
            {
                writer.WritePropertyName("termsOfServiceUrl"u8);
                writer.WriteStringValue(TermsOfServiceLink);
            }
            if (Optional.IsDefined(Contact))
            {
                writer.WritePropertyName("contact"u8);
                writer.WriteObjectValue(Contact, options);
            }
            if (Optional.IsDefined(License))
            {
                writer.WritePropertyName("license"u8);
                writer.WriteObjectValue(License, options);
            }
            if (Optional.IsDefined(SourceApiId))
            {
                writer.WritePropertyName("sourceApiId"u8);
                writer.WriteStringValue(SourceApiId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(ServiceLink))
            {
                writer.WritePropertyName("serviceUrl"u8);
                writer.WriteStringValue(ServiceLink);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApiVersionSet))
            {
                writer.WritePropertyName("apiVersionSet"u8);
                writer.WriteObjectValue(ApiVersionSet, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            if (Optional.IsDefined(WsdlSelector))
            {
                writer.WritePropertyName("wsdlSelector"u8);
                writer.WriteObjectValue(WsdlSelector, options);
            }
            if (Optional.IsDefined(SoapApiType))
            {
                writer.WritePropertyName("apiType"u8);
                writer.WriteStringValue(SoapApiType.Value.ToString());
            }
            if (Optional.IsDefined(TranslateRequiredQueryParametersConduct))
            {
                writer.WritePropertyName("translateRequiredQueryParameters"u8);
                writer.WriteStringValue(TranslateRequiredQueryParametersConduct.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
        }

        ApiCreateOrUpdateContent IJsonModel<ApiCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiCreateOrUpdateContent(document.RootElement, options);
        }

        internal static ApiCreateOrUpdateContent DeserializeApiCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            AuthenticationSettingsContract authenticationSettings = default;
            SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default;
            ApiType? type = default;
            string apiRevision = default;
            string apiVersion = default;
            bool? isCurrent = default;
            bool? isOnline = default;
            string apiRevisionDescription = default;
            string apiVersionDescription = default;
            ResourceIdentifier apiVersionSetId = default;
            bool? subscriptionRequired = default;
            string termsOfServiceUri = default;
            ApiContactInformation contact = default;
            ApiLicenseInformation license = default;
            ResourceIdentifier sourceApiId = default;
            string displayName = default;
            string serviceUri = default;
            string path = default;
            IList<ApiOperationInvokableProtocol> protocols = default;
            ApiVersionSetContractDetails apiVersionSet = default;
            string provisioningState = default;
            string value = default;
            ContentFormat? format = default;
            ApiCreateOrUpdatePropertiesWsdlSelector wsdlSelector = default;
            SoapApiType? apiType = default;
            TranslateRequiredQueryParametersConduct? translateRequiredQueryParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("subscriptionKeyParameterNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type = new ApiType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiRevision"u8))
                        {
                            apiRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersion"u8))
                        {
                            apiVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCurrent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCurrent = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isOnline"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isOnline = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiRevisionDescription"u8))
                        {
                            apiRevisionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionDescription"u8))
                        {
                            apiVersionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersionSetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("termsOfServiceUrl"u8))
                        {
                            termsOfServiceUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contact = ApiContactInformation.DeserializeApiContactInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("license"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            license = ApiLicenseInformation.DeserializeApiLicenseInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sourceApiId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceApiId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceUrl"u8))
                        {
                            serviceUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApiOperationInvokableProtocol> array = new List<ApiOperationInvokableProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ApiOperationInvokableProtocol(item.GetString()));
                            }
                            protocols = array;
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersionSet = ApiVersionSetContractDetails.DeserializeApiVersionSetContractDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("value"u8))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("format"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            format = new ContentFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("wsdlSelector"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            wsdlSelector = ApiCreateOrUpdatePropertiesWsdlSelector.DeserializeApiCreateOrUpdatePropertiesWsdlSelector(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("apiType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiType = new SoapApiType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("translateRequiredQueryParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            translateRequiredQueryParameters = new TranslateRequiredQueryParametersConduct(property0.Value.GetString());
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
            return new ApiCreateOrUpdateContent(
                description,
                authenticationSettings,
                subscriptionKeyParameterNames,
                type,
                apiRevision,
                apiVersion,
                isCurrent,
                isOnline,
                apiRevisionDescription,
                apiVersionDescription,
                apiVersionSetId,
                subscriptionRequired,
                termsOfServiceUri,
                contact,
                license,
                sourceApiId,
                displayName,
                serviceUri,
                path,
                protocols ?? new ChangeTrackingList<ApiOperationInvokableProtocol>(),
                apiVersionSet,
                provisioningState,
                value,
                format,
                wsdlSelector,
                apiType,
                translateRequiredQueryParameters,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApiCreateOrUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        ApiCreateOrUpdateContent IPersistableModel<ApiCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiCreateOrUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
