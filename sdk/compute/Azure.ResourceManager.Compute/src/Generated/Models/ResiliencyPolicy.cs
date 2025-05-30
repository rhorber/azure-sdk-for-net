// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an resiliency policy - AutomaticZoneRebalancingPolicy, ResilientVMCreationPolicy and/or ResilientVMDeletionPolicy. </summary>
    public partial class ResiliencyPolicy
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

        /// <summary> Initializes a new instance of <see cref="ResiliencyPolicy"/>. </summary>
        public ResiliencyPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResiliencyPolicy"/>. </summary>
        /// <param name="resilientVmCreationPolicy"> The configuration parameters used while performing resilient VM creation. </param>
        /// <param name="resilientVmDeletionPolicy"> The configuration parameters used while performing resilient VM deletion. </param>
        /// <param name="automaticZoneRebalancingPolicy"> The configuration parameters used while performing automatic AZ balancing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResiliencyPolicy(ResilientVmCreationPolicy resilientVmCreationPolicy, ResilientVmDeletionPolicy resilientVmDeletionPolicy, AutomaticZoneRebalancingPolicy automaticZoneRebalancingPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResilientVmCreationPolicy = resilientVmCreationPolicy;
            ResilientVmDeletionPolicy = resilientVmDeletionPolicy;
            AutomaticZoneRebalancingPolicy = automaticZoneRebalancingPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration parameters used while performing resilient VM creation. </summary>
        internal ResilientVmCreationPolicy ResilientVmCreationPolicy { get; set; }
        /// <summary> Specifies whether resilient VM creation should be enabled on the virtual machine scale set. The default value is false. </summary>
        public bool? ResilientVmCreationPolicyEnabled
        {
            get => ResilientVmCreationPolicy is null ? default : ResilientVmCreationPolicy.Enabled;
            set
            {
                if (ResilientVmCreationPolicy is null)
                    ResilientVmCreationPolicy = new ResilientVmCreationPolicy();
                ResilientVmCreationPolicy.Enabled = value;
            }
        }

        /// <summary> The configuration parameters used while performing resilient VM deletion. </summary>
        internal ResilientVmDeletionPolicy ResilientVmDeletionPolicy { get; set; }
        /// <summary> Specifies whether resilient VM deletion should be enabled on the virtual machine scale set. The default value is false. </summary>
        public bool? ResilientVmDeletionPolicyEnabled
        {
            get => ResilientVmDeletionPolicy is null ? default : ResilientVmDeletionPolicy.Enabled;
            set
            {
                if (ResilientVmDeletionPolicy is null)
                    ResilientVmDeletionPolicy = new ResilientVmDeletionPolicy();
                ResilientVmDeletionPolicy.Enabled = value;
            }
        }

        /// <summary> The configuration parameters used while performing automatic AZ balancing. </summary>
        public AutomaticZoneRebalancingPolicy AutomaticZoneRebalancingPolicy { get; set; }
    }
}
