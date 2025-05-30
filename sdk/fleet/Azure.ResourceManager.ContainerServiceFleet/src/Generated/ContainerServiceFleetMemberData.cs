// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing the ContainerServiceFleetMember data model.
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    /// </summary>
    public partial class ContainerServiceFleetMemberData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetMemberData"/>. </summary>
        public ContainerServiceFleetMemberData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetMemberData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="clusterResourceId"> The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'. </param>
        /// <param name="group"> The group this member belongs to for multi-cluster update management. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="status"> Status information of the last operation for fleet member. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceFleetMemberData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? eTag, ResourceIdentifier clusterResourceId, string group, FleetMemberProvisioningState? provisioningState, ContainerServiceFleetMemberStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = eTag;
            ClusterResourceId = clusterResourceId;
            Group = group;
            ProvisioningState = provisioningState;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </summary>
        public ETag? ETag { get; }
        /// <summary> The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'. </summary>
        public ResourceIdentifier ClusterResourceId { get; set; }
        /// <summary> The group this member belongs to for multi-cluster update management. </summary>
        public string Group { get; set; }
        /// <summary> The status of the last operation. </summary>
        public FleetMemberProvisioningState? ProvisioningState { get; }
        /// <summary> Status information of the last operation for fleet member. </summary>
        public ContainerServiceFleetMemberStatus Status { get; }
    }
}
