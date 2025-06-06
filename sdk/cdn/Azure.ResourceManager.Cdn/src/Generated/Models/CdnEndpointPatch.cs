// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Properties required to create or update an endpoint.
    /// Serialized Name: EndpointUpdateParameters
    /// </summary>
    public partial class CdnEndpointPatch
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

        /// <summary> Initializes a new instance of <see cref="CdnEndpointPatch"/>. </summary>
        public CdnEndpointPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ContentTypesToCompress = new ChangeTrackingList<string>();
            GeoFilters = new ChangeTrackingList<GeoFilter>();
            UriSigningKeys = new ChangeTrackingList<UriSigningKey>();
        }

        /// <summary> Initializes a new instance of <see cref="CdnEndpointPatch"/>. </summary>
        /// <param name="tags">
        /// Endpoint tags.
        /// Serialized Name: EndpointUpdateParameters.tags
        /// </param>
        /// <param name="originPath">
        /// A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// Serialized Name: EndpointUpdateParameters.properties.originPath
        /// </param>
        /// <param name="contentTypesToCompress">
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// Serialized Name: EndpointUpdateParameters.properties.contentTypesToCompress
        /// </param>
        /// <param name="originHostHeader">
        /// The host header value sent to the origin with each request. This property at Endpoint is only allowed when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
        /// Serialized Name: EndpointUpdateParameters.properties.originHostHeader
        /// </param>
        /// <param name="isCompressionEnabled">
        /// Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// Serialized Name: EndpointUpdateParameters.properties.isCompressionEnabled
        /// </param>
        /// <param name="isHttpAllowed">
        /// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// Serialized Name: EndpointUpdateParameters.properties.isHttpAllowed
        /// </param>
        /// <param name="isHttpsAllowed">
        /// Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// Serialized Name: EndpointUpdateParameters.properties.isHttpsAllowed
        /// </param>
        /// <param name="queryStringCachingBehavior">
        /// Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// Serialized Name: EndpointUpdateParameters.properties.queryStringCachingBehavior
        /// </param>
        /// <param name="optimizationType">
        /// Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media services. With this information, CDN can apply scenario driven optimization.
        /// Serialized Name: EndpointUpdateParameters.properties.optimizationType
        /// </param>
        /// <param name="probePath">
        /// Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single origin.
        /// Serialized Name: EndpointUpdateParameters.properties.probePath
        /// </param>
        /// <param name="geoFilters">
        /// List of rules defining the user's geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/
        /// Serialized Name: EndpointUpdateParameters.properties.geoFilters
        /// </param>
        /// <param name="defaultOriginGroup">
        /// A reference to the origin group.
        /// Serialized Name: EndpointUpdateParameters.properties.defaultOriginGroup
        /// </param>
        /// <param name="uriSigningKeys">
        /// List of keys used to validate the signed URL hashes.
        /// Serialized Name: EndpointUpdateParameters.properties.urlSigningKeys
        /// </param>
        /// <param name="deliveryPolicy">
        /// A policy that specifies the delivery rules to be used for an endpoint.
        /// Serialized Name: EndpointUpdateParameters.properties.deliveryPolicy
        /// </param>
        /// <param name="webApplicationFirewallPolicyLink">
        /// Defines the Web Application Firewall policy for the endpoint (if applicable)
        /// Serialized Name: EndpointUpdateParameters.properties.webApplicationFirewallPolicyLink
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnEndpointPatch(IDictionary<string, string> tags, string originPath, IList<string> contentTypesToCompress, string originHostHeader, bool? isCompressionEnabled, bool? isHttpAllowed, bool? isHttpsAllowed, QueryStringCachingBehavior? queryStringCachingBehavior, OptimizationType? optimizationType, string probePath, IList<GeoFilter> geoFilters, WritableSubResource defaultOriginGroup, IList<UriSigningKey> uriSigningKeys, EndpointDeliveryPolicy deliveryPolicy, EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink webApplicationFirewallPolicyLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            OriginHostHeader = originHostHeader;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            OptimizationType = optimizationType;
            ProbePath = probePath;
            GeoFilters = geoFilters;
            DefaultOriginGroup = defaultOriginGroup;
            UriSigningKeys = uriSigningKeys;
            DeliveryPolicy = deliveryPolicy;
            WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Endpoint tags.
        /// Serialized Name: EndpointUpdateParameters.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// Serialized Name: EndpointUpdateParameters.properties.originPath
        /// </summary>
        public string OriginPath { get; set; }
        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// Serialized Name: EndpointUpdateParameters.properties.contentTypesToCompress
        /// </summary>
        public IList<string> ContentTypesToCompress { get; }
        /// <summary>
        /// The host header value sent to the origin with each request. This property at Endpoint is only allowed when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
        /// Serialized Name: EndpointUpdateParameters.properties.originHostHeader
        /// </summary>
        public string OriginHostHeader { get; set; }
        /// <summary>
        /// Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// Serialized Name: EndpointUpdateParameters.properties.isCompressionEnabled
        /// </summary>
        public bool? IsCompressionEnabled { get; set; }
        /// <summary>
        /// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// Serialized Name: EndpointUpdateParameters.properties.isHttpAllowed
        /// </summary>
        public bool? IsHttpAllowed { get; set; }
        /// <summary>
        /// Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// Serialized Name: EndpointUpdateParameters.properties.isHttpsAllowed
        /// </summary>
        public bool? IsHttpsAllowed { get; set; }
        /// <summary>
        /// Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// Serialized Name: EndpointUpdateParameters.properties.queryStringCachingBehavior
        /// </summary>
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }
        /// <summary>
        /// Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media services. With this information, CDN can apply scenario driven optimization.
        /// Serialized Name: EndpointUpdateParameters.properties.optimizationType
        /// </summary>
        public OptimizationType? OptimizationType { get; set; }
        /// <summary>
        /// Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single origin.
        /// Serialized Name: EndpointUpdateParameters.properties.probePath
        /// </summary>
        public string ProbePath { get; set; }
        /// <summary>
        /// List of rules defining the user's geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/
        /// Serialized Name: EndpointUpdateParameters.properties.geoFilters
        /// </summary>
        public IList<GeoFilter> GeoFilters { get; }
        /// <summary>
        /// A reference to the origin group.
        /// Serialized Name: EndpointUpdateParameters.properties.defaultOriginGroup
        /// </summary>
        internal WritableSubResource DefaultOriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultOriginGroupId
        {
            get => DefaultOriginGroup is null ? default : DefaultOriginGroup.Id;
            set
            {
                if (DefaultOriginGroup is null)
                    DefaultOriginGroup = new WritableSubResource();
                DefaultOriginGroup.Id = value;
            }
        }

        /// <summary>
        /// List of keys used to validate the signed URL hashes.
        /// Serialized Name: EndpointUpdateParameters.properties.urlSigningKeys
        /// </summary>
        public IList<UriSigningKey> UriSigningKeys { get; set; }
        /// <summary>
        /// A policy that specifies the delivery rules to be used for an endpoint.
        /// Serialized Name: EndpointUpdateParameters.properties.deliveryPolicy
        /// </summary>
        public EndpointDeliveryPolicy DeliveryPolicy { get; set; }
        /// <summary>
        /// Defines the Web Application Firewall policy for the endpoint (if applicable)
        /// Serialized Name: EndpointUpdateParameters.properties.webApplicationFirewallPolicyLink
        /// </summary>
        internal EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink { get; set; }
        /// <summary>
        /// Resource ID.
        /// Serialized Name: EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.id
        /// </summary>
        public ResourceIdentifier WebApplicationFirewallPolicyLinkId
        {
            get => WebApplicationFirewallPolicyLink is null ? default : WebApplicationFirewallPolicyLink.Id;
            set
            {
                if (WebApplicationFirewallPolicyLink is null)
                    WebApplicationFirewallPolicyLink = new EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink();
                WebApplicationFirewallPolicyLink.Id = value;
            }
        }
    }
}
