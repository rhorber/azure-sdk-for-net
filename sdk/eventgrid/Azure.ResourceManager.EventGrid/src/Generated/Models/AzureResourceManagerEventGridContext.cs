// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// Context class which will be filled in by the System.ClientModel.SourceGeneration.
    /// For more information see 'https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/System.ClientModel/src/docs/ModelReaderWriterContext.md'
    /// </summary>
    [ModelReaderWriterBuildable(typeof(AdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(AzureADPartnerClientAuthentication))]
    [ModelReaderWriterBuildable(typeof(AzureFunctionEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(BoolEqualsAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(BoolEqualsFilter))]
    [ModelReaderWriterBuildable(typeof(CaCertificateData))]
    [ModelReaderWriterBuildable(typeof(CaCertificateResource))]
    [ModelReaderWriterBuildable(typeof(CaCertificatesListResult))]
    [ModelReaderWriterBuildable(typeof(ChannelsListResult))]
    [ModelReaderWriterBuildable(typeof(ClientAuthenticationSettings))]
    [ModelReaderWriterBuildable(typeof(ClientCertificateAuthentication))]
    [ModelReaderWriterBuildable(typeof(ClientGroupsListResult))]
    [ModelReaderWriterBuildable(typeof(ClientsListResult))]
    [ModelReaderWriterBuildable(typeof(CustomDomainConfiguration))]
    [ModelReaderWriterBuildable(typeof(CustomDomainIdentity))]
    [ModelReaderWriterBuildable(typeof(CustomDomainOwnershipValidationResult))]
    [ModelReaderWriterBuildable(typeof(CustomJwtAuthenticationManagedIdentity))]
    [ModelReaderWriterBuildable(typeof(CustomJwtAuthenticationSettings))]
    [ModelReaderWriterBuildable(typeof(CustomWebhookAuthenticationManagedIdentity))]
    [ModelReaderWriterBuildable(typeof(DeadLetterDestination))]
    [ModelReaderWriterBuildable(typeof(DeadLetterWithResourceIdentity))]
    [ModelReaderWriterBuildable(typeof(DeliveryAttributeListResult))]
    [ModelReaderWriterBuildable(typeof(DeliveryAttributeMapping))]
    [ModelReaderWriterBuildable(typeof(DeliveryConfiguration))]
    [ModelReaderWriterBuildable(typeof(DeliveryWithResourceIdentity))]
    [ModelReaderWriterBuildable(typeof(DomainEventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(DomainNetworkSecurityPerimeterConfigurationResource))]
    [ModelReaderWriterBuildable(typeof(DomainsListResult))]
    [ModelReaderWriterBuildable(typeof(DomainTopicData))]
    [ModelReaderWriterBuildable(typeof(DomainTopicEventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(DomainTopicResource))]
    [ModelReaderWriterBuildable(typeof(DomainTopicsListResult))]
    [ModelReaderWriterBuildable(typeof(DynamicDeliveryAttributeMapping))]
    [ModelReaderWriterBuildable(typeof(DynamicRoutingEnrichment))]
    [ModelReaderWriterBuildable(typeof(EncodedIssuerCertificateInfo))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainData))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainPatch))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainPrivateEndpointConnectionResource))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainPrivateLinkResource))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainRegenerateKeyContent))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainResource))]
    [ModelReaderWriterBuildable(typeof(EventGridDomainSharedAccessKeys))]
    [ModelReaderWriterBuildable(typeof(EventGridFilter))]
    [ModelReaderWriterBuildable(typeof(EventGridInboundIPRule))]
    [ModelReaderWriterBuildable(typeof(EventGridInputSchemaMapping))]
    [ModelReaderWriterBuildable(typeof(EventGridJsonInputSchemaMapping))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespaceClientData))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespaceClientGroupData))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespaceClientGroupResource))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespaceClientResource))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespaceData))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespacePatch))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespacePermissionBindingData))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespacePermissionBindingResource))]
    [ModelReaderWriterBuildable(typeof(EventGridNamespaceResource))]
    [ModelReaderWriterBuildable(typeof(EventGridPartnerContent))]
    [ModelReaderWriterBuildable(typeof(EventGridPartnerNamespacePrivateEndpointConnectionResource))]
    [ModelReaderWriterBuildable(typeof(EventGridPrivateEndpointConnectionData))]
    [ModelReaderWriterBuildable(typeof(EventGridPrivateEndpointConnectionListResult))]
    [ModelReaderWriterBuildable(typeof(EventGridPrivateEndpointConnectionState))]
    [ModelReaderWriterBuildable(typeof(EventGridPrivateLinkResourceData))]
    [ModelReaderWriterBuildable(typeof(EventGridSubscriptionData))]
    [ModelReaderWriterBuildable(typeof(EventGridSubscriptionPatch))]
    [ModelReaderWriterBuildable(typeof(EventGridTopicData))]
    [ModelReaderWriterBuildable(typeof(EventGridTopicPatch))]
    [ModelReaderWriterBuildable(typeof(EventGridTopicPrivateEndpointConnectionResource))]
    [ModelReaderWriterBuildable(typeof(EventGridTopicPrivateLinkResource))]
    [ModelReaderWriterBuildable(typeof(EventGridTopicResource))]
    [ModelReaderWriterBuildable(typeof(EventHubEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionFilter))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionFullUri))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionIdentity))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionRetryPolicy))]
    [ModelReaderWriterBuildable(typeof(EventSubscriptionsListResult))]
    [ModelReaderWriterBuildable(typeof(EventTypesListResult))]
    [ModelReaderWriterBuildable(typeof(EventTypeUnderTopic))]
    [ModelReaderWriterBuildable(typeof(ExtendedLocation))]
    [ModelReaderWriterBuildable(typeof(ExtensionTopicData))]
    [ModelReaderWriterBuildable(typeof(ExtensionTopicResource))]
    [ModelReaderWriterBuildable(typeof(FederatedIdentityCredentialInfo))]
    [ModelReaderWriterBuildable(typeof(FiltersConfiguration))]
    [ModelReaderWriterBuildable(typeof(HybridConnectionEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(InlineEventProperties))]
    [ModelReaderWriterBuildable(typeof(IsNotNullAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(IsNotNullFilter))]
    [ModelReaderWriterBuildable(typeof(IsNullOrUndefinedAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(IsNullOrUndefinedFilter))]
    [ModelReaderWriterBuildable(typeof(IssuerCertificateInfo))]
    [ModelReaderWriterBuildable(typeof(JsonField))]
    [ModelReaderWriterBuildable(typeof(JsonFieldWithDefault))]
    [ModelReaderWriterBuildable(typeof(ManagedServiceIdentity))]
    [ModelReaderWriterBuildable(typeof(MonitorAlertEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(NamespaceRegenerateKeyContent))]
    [ModelReaderWriterBuildable(typeof(NamespaceSharedAccessKeys))]
    [ModelReaderWriterBuildable(typeof(NamespaceSku))]
    [ModelReaderWriterBuildable(typeof(NamespacesListResult))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicData))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicEventSubscriptionData))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicEventSubscriptionPatch))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicEventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicPatch))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicResource))]
    [ModelReaderWriterBuildable(typeof(NamespaceTopicsListResult))]
    [ModelReaderWriterBuildable(typeof(NetworkSecurityPerimeterConfigurationData))]
    [ModelReaderWriterBuildable(typeof(NetworkSecurityPerimeterConfigurationIssues))]
    [ModelReaderWriterBuildable(typeof(NetworkSecurityPerimeterConfigurationList))]
    [ModelReaderWriterBuildable(typeof(NetworkSecurityPerimeterConfigurationProfile))]
    [ModelReaderWriterBuildable(typeof(NetworkSecurityPerimeterInfo))]
    [ModelReaderWriterBuildable(typeof(NetworkSecurityPerimeterProfileAccessRule))]
    [ModelReaderWriterBuildable(typeof(NumberGreaterThanAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberGreaterThanFilter))]
    [ModelReaderWriterBuildable(typeof(NumberGreaterThanOrEqualsAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberGreaterThanOrEqualsFilter))]
    [ModelReaderWriterBuildable(typeof(NumberInAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberInFilter))]
    [ModelReaderWriterBuildable(typeof(NumberInRangeAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberInRangeFilter))]
    [ModelReaderWriterBuildable(typeof(NumberLessThanAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberLessThanFilter))]
    [ModelReaderWriterBuildable(typeof(NumberLessThanOrEqualsAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberLessThanOrEqualsFilter))]
    [ModelReaderWriterBuildable(typeof(NumberNotInAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberNotInFilter))]
    [ModelReaderWriterBuildable(typeof(NumberNotInRangeAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(NumberNotInRangeFilter))]
    [ModelReaderWriterBuildable(typeof(PartnerAuthorization))]
    [ModelReaderWriterBuildable(typeof(PartnerClientAuthentication))]
    [ModelReaderWriterBuildable(typeof(PartnerConfigurationData))]
    [ModelReaderWriterBuildable(typeof(PartnerConfigurationPatch))]
    [ModelReaderWriterBuildable(typeof(PartnerConfigurationResource))]
    [ModelReaderWriterBuildable(typeof(PartnerConfigurationsListResult))]
    [ModelReaderWriterBuildable(typeof(PartnerDestinationData))]
    [ModelReaderWriterBuildable(typeof(PartnerDestinationInfo))]
    [ModelReaderWriterBuildable(typeof(PartnerDestinationPatch))]
    [ModelReaderWriterBuildable(typeof(PartnerDestinationResource))]
    [ModelReaderWriterBuildable(typeof(PartnerDestinationsListResult))]
    [ModelReaderWriterBuildable(typeof(PartnerDetails))]
    [ModelReaderWriterBuildable(typeof(PartnerEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceChannelData))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceChannelPatch))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceChannelResource))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceData))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespacePatch))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespacePrivateLinkResource))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceRegenerateKeyContent))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceResource))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespaceSharedAccessKeys))]
    [ModelReaderWriterBuildable(typeof(PartnerNamespacesListResult))]
    [ModelReaderWriterBuildable(typeof(PartnerRegistrationData))]
    [ModelReaderWriterBuildable(typeof(PartnerRegistrationPatch))]
    [ModelReaderWriterBuildable(typeof(PartnerRegistrationResource))]
    [ModelReaderWriterBuildable(typeof(PartnerRegistrationsListResult))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicData))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicEventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicEventTypeInfo))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicInfo))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicPatch))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicResource))]
    [ModelReaderWriterBuildable(typeof(PartnerTopicsListResult))]
    [ModelReaderWriterBuildable(typeof(PartnerUpdateDestinationInfo))]
    [ModelReaderWriterBuildable(typeof(PartnerUpdateTopicInfo))]
    [ModelReaderWriterBuildable(typeof(PermissionBindingsListResult))]
    [ModelReaderWriterBuildable(typeof(PrivateLinkResourcesListResult))]
    [ModelReaderWriterBuildable(typeof(PushInfo))]
    [ModelReaderWriterBuildable(typeof(QueueInfo))]
    [ModelReaderWriterBuildable(typeof(ResourceAssociation))]
    [ModelReaderWriterBuildable(typeof(ResourceMoveChangeHistory))]
    [ModelReaderWriterBuildable(typeof(ResourceSku))]
    [ModelReaderWriterBuildable(typeof(ResponseError))]
    [ModelReaderWriterBuildable(typeof(RoutingEnrichments))]
    [ModelReaderWriterBuildable(typeof(RoutingIdentityInfo))]
    [ModelReaderWriterBuildable(typeof(ServiceBusQueueEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(ServiceBusTopicEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(StaticDeliveryAttributeMapping))]
    [ModelReaderWriterBuildable(typeof(StaticRoutingEnrichment))]
    [ModelReaderWriterBuildable(typeof(StaticStringRoutingEnrichment))]
    [ModelReaderWriterBuildable(typeof(StorageBlobDeadLetterDestination))]
    [ModelReaderWriterBuildable(typeof(StorageQueueEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(StringBeginsWithAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringBeginsWithFilter))]
    [ModelReaderWriterBuildable(typeof(StringContainsAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringContainsFilter))]
    [ModelReaderWriterBuildable(typeof(StringEndsWithAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringEndsWithFilter))]
    [ModelReaderWriterBuildable(typeof(StringInAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringInFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotBeginsWithAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotBeginsWithFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotContainsAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotContainsFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotEndsWithAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotEndsWithFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotInAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(StringNotInFilter))]
    [ModelReaderWriterBuildable(typeof(SubscriptionFullUri))]
    [ModelReaderWriterBuildable(typeof(SubscriptionsListResult))]
    [ModelReaderWriterBuildable(typeof(SystemData))]
    [ModelReaderWriterBuildable(typeof(SystemTopicData))]
    [ModelReaderWriterBuildable(typeof(SystemTopicEventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(SystemTopicPatch))]
    [ModelReaderWriterBuildable(typeof(SystemTopicResource))]
    [ModelReaderWriterBuildable(typeof(SystemTopicsListResult))]
    [ModelReaderWriterBuildable(typeof(TopicEventSubscriptionResource))]
    [ModelReaderWriterBuildable(typeof(TopicNetworkSecurityPerimeterConfigurationResource))]
    [ModelReaderWriterBuildable(typeof(TopicRegenerateKeyContent))]
    [ModelReaderWriterBuildable(typeof(TopicsConfiguration))]
    [ModelReaderWriterBuildable(typeof(TopicSharedAccessKeys))]
    [ModelReaderWriterBuildable(typeof(TopicsListResult))]
    [ModelReaderWriterBuildable(typeof(TopicSpaceData))]
    [ModelReaderWriterBuildable(typeof(TopicSpaceResource))]
    [ModelReaderWriterBuildable(typeof(TopicSpacesConfiguration))]
    [ModelReaderWriterBuildable(typeof(TopicSpacesListResult))]
    [ModelReaderWriterBuildable(typeof(TopicTypeAdditionalEnforcedPermission))]
    [ModelReaderWriterBuildable(typeof(TopicTypeData))]
    [ModelReaderWriterBuildable(typeof(TopicTypeResource))]
    [ModelReaderWriterBuildable(typeof(TopicTypesListResult))]
    [ModelReaderWriterBuildable(typeof(UnknownAdvancedFilter))]
    [ModelReaderWriterBuildable(typeof(UnknownDeadLetterDestination))]
    [ModelReaderWriterBuildable(typeof(UnknownDeliveryAttributeMapping))]
    [ModelReaderWriterBuildable(typeof(UnknownEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(UnknownFilter))]
    [ModelReaderWriterBuildable(typeof(UnknownInputSchemaMapping))]
    [ModelReaderWriterBuildable(typeof(UnknownPartnerClientAuthentication))]
    [ModelReaderWriterBuildable(typeof(UnknownPartnerDestinationInfo))]
    [ModelReaderWriterBuildable(typeof(UnknownPartnerUpdateDestinationInfo))]
    [ModelReaderWriterBuildable(typeof(UnknownStaticRoutingEnrichment))]
    [ModelReaderWriterBuildable(typeof(UpdateTopicsConfigurationInfo))]
    [ModelReaderWriterBuildable(typeof(UpdateTopicSpacesConfigurationInfo))]
    [ModelReaderWriterBuildable(typeof(UserAssignedIdentity))]
    [ModelReaderWriterBuildable(typeof(VerifiedPartnerData))]
    [ModelReaderWriterBuildable(typeof(VerifiedPartnerResource))]
    [ModelReaderWriterBuildable(typeof(VerifiedPartnersListResult))]
    [ModelReaderWriterBuildable(typeof(WebhookAuthenticationSettings))]
    [ModelReaderWriterBuildable(typeof(WebHookEventSubscriptionDestination))]
    [ModelReaderWriterBuildable(typeof(WebhookPartnerDestinationInfo))]
    [ModelReaderWriterBuildable(typeof(WebhookUpdatePartnerDestinationInfo))]
    [ModelReaderWriterBuildable(typeof(WritableSubResource))]
    public partial class AzureResourceManagerEventGridContext : ModelReaderWriterContext
    {
    }
}
