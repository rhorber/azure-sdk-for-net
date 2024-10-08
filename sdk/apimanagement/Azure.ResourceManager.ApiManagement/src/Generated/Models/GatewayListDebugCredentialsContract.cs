// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> List debug credentials properties. </summary>
    public partial class GatewayListDebugCredentialsContract
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

        /// <summary> Initializes a new instance of <see cref="GatewayListDebugCredentialsContract"/>. </summary>
        /// <param name="purposes"> Purposes of debug credential. </param>
        /// <param name="apiId"> Full resource Id of an API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="purposes"/> or <paramref name="apiId"/> is null. </exception>
        public GatewayListDebugCredentialsContract(IEnumerable<GatewayListDebugCredentialsContractPurpose> purposes, ResourceIdentifier apiId)
        {
            Argument.AssertNotNull(purposes, nameof(purposes));
            Argument.AssertNotNull(apiId, nameof(apiId));

            Purposes = purposes.ToList();
            ApiId = apiId;
        }

        /// <summary> Initializes a new instance of <see cref="GatewayListDebugCredentialsContract"/>. </summary>
        /// <param name="credentialsExpireAfter"> Credentials expiration in ISO8601 format. Maximum duration of the credentials is PT1H. When property is not specified, them value PT1H is used. </param>
        /// <param name="purposes"> Purposes of debug credential. </param>
        /// <param name="apiId"> Full resource Id of an API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GatewayListDebugCredentialsContract(TimeSpan? credentialsExpireAfter, IList<GatewayListDebugCredentialsContractPurpose> purposes, ResourceIdentifier apiId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CredentialsExpireAfter = credentialsExpireAfter;
            Purposes = purposes;
            ApiId = apiId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GatewayListDebugCredentialsContract"/> for deserialization. </summary>
        internal GatewayListDebugCredentialsContract()
        {
        }

        /// <summary> Credentials expiration in ISO8601 format. Maximum duration of the credentials is PT1H. When property is not specified, them value PT1H is used. </summary>
        [WirePath("credentialsExpireAfter")]
        public TimeSpan? CredentialsExpireAfter { get; set; }
        /// <summary> Purposes of debug credential. </summary>
        [WirePath("purposes")]
        public IList<GatewayListDebugCredentialsContractPurpose> Purposes { get; }
        /// <summary> Full resource Id of an API. </summary>
        [WirePath("apiId")]
        public ResourceIdentifier ApiId { get; }
    }
}
