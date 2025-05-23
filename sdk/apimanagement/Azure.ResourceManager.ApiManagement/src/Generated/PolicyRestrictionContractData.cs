// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the PolicyRestrictionContract data model.
    /// Policy restriction contract details.
    /// </summary>
    public partial class PolicyRestrictionContractData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PolicyRestrictionContractData"/>. </summary>
        public PolicyRestrictionContractData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyRestrictionContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> Path to the policy document. </param>
        /// <param name="requireBase"> Indicates if base policy should be enforced for the policy document. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyRestrictionContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, PolicyRestrictionRequireBase? requireBase, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RequireBase = requireBase;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Path to the policy document. </summary>
        [WirePath("properties.scope")]
        public string Scope { get; set; }
        /// <summary> Indicates if base policy should be enforced for the policy document. </summary>
        [WirePath("properties.requireBase")]
        public PolicyRestrictionRequireBase? RequireBase { get; set; }
    }
}
