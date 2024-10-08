// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Object reference to a Kubernetes object on a cluster. </summary>
    public partial class KubernetesObjectReference
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

        /// <summary> Initializes a new instance of <see cref="KubernetesObjectReference"/>. </summary>
        internal KubernetesObjectReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesObjectReference"/>. </summary>
        /// <param name="name"> Name of the object. </param>
        /// <param name="namespace"> Namespace of the object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesObjectReference(string name, string @namespace, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Namespace = @namespace;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the object. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Namespace of the object. </summary>
        [WirePath("namespace")]
        public string Namespace { get; }
    }
}
