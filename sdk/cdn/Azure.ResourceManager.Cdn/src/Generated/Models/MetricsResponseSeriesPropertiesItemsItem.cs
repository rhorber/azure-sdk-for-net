// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The MetricsResponseSeriesPropertiesItemsItem.
    /// Serialized Name: MetricsResponseSeriesPropertiesItemsItem
    /// </summary>
    public partial class MetricsResponseSeriesPropertiesItemsItem
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

        /// <summary> Initializes a new instance of <see cref="MetricsResponseSeriesPropertiesItemsItem"/>. </summary>
        internal MetricsResponseSeriesPropertiesItemsItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetricsResponseSeriesPropertiesItemsItem"/>. </summary>
        /// <param name="name"> Serialized Name: MetricsResponseSeriesPropertiesItemsItem.name. </param>
        /// <param name="value"> Serialized Name: MetricsResponseSeriesPropertiesItemsItem.value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricsResponseSeriesPropertiesItemsItem(string name, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Serialized Name: MetricsResponseSeriesPropertiesItemsItem.name. </summary>
        public string Name { get; }
        /// <summary> Serialized Name: MetricsResponseSeriesPropertiesItemsItem.value. </summary>
        public string Value { get; }
    }
}
