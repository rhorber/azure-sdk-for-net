// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Identity used to authenticate with key vault. </summary>
    public partial class NetAppEncryptionIdentity
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

        /// <summary> Initializes a new instance of <see cref="NetAppEncryptionIdentity"/>. </summary>
        public NetAppEncryptionIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppEncryptionIdentity"/>. </summary>
        /// <param name="principalId"> The principal ID (object ID) of the identity used to authenticate with key vault. Read-only. </param>
        /// <param name="userAssignedIdentity"> The ARM resource identifier of the user assigned identity used to authenticate with key vault. Applicable if identity.type has 'UserAssigned'. It should match key of identity.userAssignedIdentities. </param>
        /// <param name="federatedClientId"> ClientId of the multi-tenant AAD Application. Used to access cross-tenant keyvaults. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppEncryptionIdentity(string principalId, string userAssignedIdentity, string federatedClientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrincipalId = principalId;
            UserAssignedIdentity = userAssignedIdentity;
            FederatedClientId = federatedClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The principal ID (object ID) of the identity used to authenticate with key vault. Read-only. </summary>
        public string PrincipalId { get; }
        /// <summary> The ARM resource identifier of the user assigned identity used to authenticate with key vault. Applicable if identity.type has 'UserAssigned'. It should match key of identity.userAssignedIdentities. </summary>
        public string UserAssignedIdentity { get; set; }
        /// <summary> ClientId of the multi-tenant AAD Application. Used to access cross-tenant keyvaults. </summary>
        public string FederatedClientId { get; set; }
    }
}
