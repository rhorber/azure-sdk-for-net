// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the FrontDoorRoute data model.
    /// Friendly Routes name mapping to the any Routes or secret related information.
    /// Serialized Name: Route
    /// </summary>
    public partial class FrontDoorRouteData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorRouteData"/>. </summary>
        public FrontDoorRouteData()
        {
            CustomDomains = new ChangeTrackingList<FrontDoorActivatedResourceInfo>();
            RuleSets = new ChangeTrackingList<WritableSubResource>();
            SupportedProtocols = new ChangeTrackingList<FrontDoorEndpointProtocol>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorRouteData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="endpointName">
        /// The name of the endpoint which holds the route.
        /// Serialized Name: Route.properties.endpointName
        /// </param>
        /// <param name="customDomains">
        /// Domains referenced by this endpoint.
        /// Serialized Name: Route.properties.customDomains
        /// </param>
        /// <param name="originGroup">
        /// A reference to the origin group.
        /// Serialized Name: Route.properties.originGroup
        /// </param>
        /// <param name="originPath">
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// Serialized Name: Route.properties.originPath
        /// </param>
        /// <param name="ruleSets">
        /// rule sets referenced by this endpoint.
        /// Serialized Name: Route.properties.ruleSets
        /// </param>
        /// <param name="supportedProtocols">
        /// List of supported protocols for this route.
        /// Serialized Name: Route.properties.supportedProtocols
        /// </param>
        /// <param name="patternsToMatch">
        /// The route patterns of the rule.
        /// Serialized Name: Route.properties.patternsToMatch
        /// </param>
        /// <param name="cacheConfiguration">
        /// The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object.
        /// Serialized Name: Route.properties.cacheConfiguration
        /// </param>
        /// <param name="forwardingProtocol">
        /// Protocol this rule will use when forwarding traffic to backends.
        /// Serialized Name: Route.properties.forwardingProtocol
        /// </param>
        /// <param name="linkToDefaultDomain">
        /// whether this route will be linked to the default endpoint domain.
        /// Serialized Name: Route.properties.linkToDefaultDomain
        /// </param>
        /// <param name="httpsRedirect">
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
        /// Serialized Name: Route.properties.httpsRedirect
        /// </param>
        /// <param name="enabledState">
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// Serialized Name: Route.properties.enabledState
        /// </param>
        /// <param name="provisioningState">
        /// Provisioning status
        /// Serialized Name: Route.properties.provisioningState
        /// </param>
        /// <param name="deploymentStatus"> Serialized Name: Route.properties.deploymentStatus. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorRouteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string endpointName, IList<FrontDoorActivatedResourceInfo> customDomains, WritableSubResource originGroup, string originPath, IList<WritableSubResource> ruleSets, IList<FrontDoorEndpointProtocol> supportedProtocols, IList<string> patternsToMatch, FrontDoorRouteCacheConfiguration cacheConfiguration, ForwardingProtocol? forwardingProtocol, LinkToDefaultDomain? linkToDefaultDomain, HttpsRedirect? httpsRedirect, EnabledState? enabledState, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            EndpointName = endpointName;
            CustomDomains = customDomains;
            OriginGroup = originGroup;
            OriginPath = originPath;
            RuleSets = ruleSets;
            SupportedProtocols = supportedProtocols;
            PatternsToMatch = patternsToMatch;
            CacheConfiguration = cacheConfiguration;
            ForwardingProtocol = forwardingProtocol;
            LinkToDefaultDomain = linkToDefaultDomain;
            HttpsRedirect = httpsRedirect;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The name of the endpoint which holds the route.
        /// Serialized Name: Route.properties.endpointName
        /// </summary>
        public string EndpointName { get; }
        /// <summary>
        /// Domains referenced by this endpoint.
        /// Serialized Name: Route.properties.customDomains
        /// </summary>
        public IList<FrontDoorActivatedResourceInfo> CustomDomains { get; }
        /// <summary>
        /// A reference to the origin group.
        /// Serialized Name: Route.properties.originGroup
        /// </summary>
        internal WritableSubResource OriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup is null ? default : OriginGroup.Id;
            set
            {
                if (OriginGroup is null)
                    OriginGroup = new WritableSubResource();
                OriginGroup.Id = value;
            }
        }

        /// <summary>
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// Serialized Name: Route.properties.originPath
        /// </summary>
        public string OriginPath { get; set; }
        /// <summary>
        /// rule sets referenced by this endpoint.
        /// Serialized Name: Route.properties.ruleSets
        /// </summary>
        public IList<WritableSubResource> RuleSets { get; }
        /// <summary>
        /// List of supported protocols for this route.
        /// Serialized Name: Route.properties.supportedProtocols
        /// </summary>
        public IList<FrontDoorEndpointProtocol> SupportedProtocols { get; }
        /// <summary>
        /// The route patterns of the rule.
        /// Serialized Name: Route.properties.patternsToMatch
        /// </summary>
        public IList<string> PatternsToMatch { get; }
        /// <summary>
        /// The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object.
        /// Serialized Name: Route.properties.cacheConfiguration
        /// </summary>
        public FrontDoorRouteCacheConfiguration CacheConfiguration { get; set; }
        /// <summary>
        /// Protocol this rule will use when forwarding traffic to backends.
        /// Serialized Name: Route.properties.forwardingProtocol
        /// </summary>
        public ForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary>
        /// whether this route will be linked to the default endpoint domain.
        /// Serialized Name: Route.properties.linkToDefaultDomain
        /// </summary>
        public LinkToDefaultDomain? LinkToDefaultDomain { get; set; }
        /// <summary>
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
        /// Serialized Name: Route.properties.httpsRedirect
        /// </summary>
        public HttpsRedirect? HttpsRedirect { get; set; }
        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// Serialized Name: Route.properties.enabledState
        /// </summary>
        public EnabledState? EnabledState { get; set; }
        /// <summary>
        /// Provisioning status
        /// Serialized Name: Route.properties.provisioningState
        /// </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Serialized Name: Route.properties.deploymentStatus. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
    }
}
