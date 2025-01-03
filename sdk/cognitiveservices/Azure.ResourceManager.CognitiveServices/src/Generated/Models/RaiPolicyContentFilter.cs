// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Azure OpenAI Content Filter. </summary>
    public partial class RaiPolicyContentFilter
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

        /// <summary> Initializes a new instance of <see cref="RaiPolicyContentFilter"/>. </summary>
        public RaiPolicyContentFilter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RaiPolicyContentFilter"/>. </summary>
        /// <param name="name"> Name of ContentFilter. </param>
        /// <param name="enabled"> If the ContentFilter is enabled. </param>
        /// <param name="severityThreshold"> Level at which content is filtered. </param>
        /// <param name="blocking"> If blocking would occur. </param>
        /// <param name="source"> Content source to apply the Content Filters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RaiPolicyContentFilter(string name, bool? enabled, RaiPolicyContentLevel? severityThreshold, bool? blocking, RaiPolicyContentSource? source, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Enabled = enabled;
            SeverityThreshold = severityThreshold;
            Blocking = blocking;
            Source = source;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of ContentFilter. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> If the ContentFilter is enabled. </summary>
        [WirePath("enabled")]
        public bool? Enabled { get; set; }
        /// <summary> Level at which content is filtered. </summary>
        [WirePath("severityThreshold")]
        public RaiPolicyContentLevel? SeverityThreshold { get; set; }
        /// <summary> If blocking would occur. </summary>
        [WirePath("blocking")]
        public bool? Blocking { get; set; }
        /// <summary> Content source to apply the Content Filters. </summary>
        [WirePath("source")]
        public RaiPolicyContentSource? Source { get; set; }
    }
}
