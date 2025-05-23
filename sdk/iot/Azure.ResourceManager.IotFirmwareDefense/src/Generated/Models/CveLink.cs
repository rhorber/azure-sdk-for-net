// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary>
    /// Properties of a reference link for a CVE.
    /// Serialized Name: CveLink
    /// </summary>
    public partial class CveLink
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

        /// <summary> Initializes a new instance of <see cref="CveLink"/>. </summary>
        internal CveLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CveLink"/>. </summary>
        /// <param name="href">
        /// The destination of the reference link.
        /// Serialized Name: CveLink.href
        /// </param>
        /// <param name="label">
        /// The label of the reference link.
        /// Serialized Name: CveLink.label
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CveLink(Uri href, string label, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Href = href;
            Label = label;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The destination of the reference link.
        /// Serialized Name: CveLink.href
        /// </summary>
        public Uri Href { get; }
        /// <summary>
        /// The label of the reference link.
        /// Serialized Name: CveLink.label
        /// </summary>
        public string Label { get; }
    }
}
