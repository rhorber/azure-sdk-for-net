// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Details about a user assigned identity. </summary>
    public partial class ContainerServiceUserAssignedIdentity
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceUserAssignedIdentity"/>. </summary>
        public ContainerServiceUserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceUserAssignedIdentity"/>. </summary>
        /// <param name="resourceId"> The resource ID of the user assigned identity. </param>
        /// <param name="clientId"> The client ID of the user assigned identity. </param>
        /// <param name="objectId"> The object ID of the user assigned identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceUserAssignedIdentity(ResourceIdentifier resourceId, Guid? clientId, Guid? objectId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            ClientId = clientId;
            ObjectId = objectId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the user assigned identity. </summary>
        [WirePath("resourceId")]
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The client ID of the user assigned identity. </summary>
        [WirePath("clientId")]
        public Guid? ClientId { get; set; }
        /// <summary> The object ID of the user assigned identity. </summary>
        [WirePath("objectId")]
        public Guid? ObjectId { get; set; }
    }
}
