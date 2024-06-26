// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ReRegisterSubscriptionMetadata. </summary>
    public partial class ReRegisterSubscriptionMetadata
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

        /// <summary> Initializes a new instance of <see cref="ReRegisterSubscriptionMetadata"/>. </summary>
        /// <param name="isEnabled"></param>
        internal ReRegisterSubscriptionMetadata(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="ReRegisterSubscriptionMetadata"/>. </summary>
        /// <param name="isEnabled"></param>
        /// <param name="concurrencyLimit"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReRegisterSubscriptionMetadata(bool isEnabled, int? concurrencyLimit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            ConcurrencyLimit = concurrencyLimit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ReRegisterSubscriptionMetadata"/> for deserialization. </summary>
        internal ReRegisterSubscriptionMetadata()
        {
        }

        /// <summary> Gets the is enabled. </summary>
        public bool IsEnabled { get; }
        /// <summary> Gets the concurrency limit. </summary>
        public int? ConcurrencyLimit { get; }
    }
}
