// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a node type sku. </summary>
    public partial class NodeTypeSku
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

        /// <summary> Initializes a new instance of <see cref="NodeTypeSku"/>. </summary>
        /// <param name="capacity"> The number of nodes in the node type. If present in request it will override properties.vmInstanceCount. </param>
        public NodeTypeSku(int capacity)
        {
            Capacity = capacity;
        }

        /// <summary> Initializes a new instance of <see cref="NodeTypeSku"/>. </summary>
        /// <param name="name"> The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed to other values than generated. To avoid deployment errors please omit the property. </param>
        /// <param name="tier"> Specifies the tier of the node type. Possible Values: **Standard**. </param>
        /// <param name="capacity"> The number of nodes in the node type. If present in request it will override properties.vmInstanceCount. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NodeTypeSku(string name, string tier, int capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NodeTypeSku"/> for deserialization. </summary>
        internal NodeTypeSku()
        {
        }

        /// <summary> The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed to other values than generated. To avoid deployment errors please omit the property. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the tier of the node type. Possible Values: **Standard**. </summary>
        public string Tier { get; set; }
        /// <summary> The number of nodes in the node type. If present in request it will override properties.vmInstanceCount. </summary>
        public int Capacity { get; set; }
    }
}
