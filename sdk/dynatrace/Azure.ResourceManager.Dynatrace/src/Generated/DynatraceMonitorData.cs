// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Dynatrace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A class representing the DynatraceMonitor data model.
    /// Dynatrace Monitor Resource
    /// </summary>
    public partial class DynatraceMonitorData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DynatraceMonitorData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="monitoringStatus"> Status of the monitor. </param>
        /// <param name="marketplaceSubscriptionStatus"> Marketplace subscription status. </param>
        /// <param name="dynatraceEnvironmentProperties"> Properties of the Dynatrace environment. </param>
        /// <param name="userInfo"> User info. </param>
        /// <param name="planData"> Billing plan information. </param>
        /// <param name="liftrResourceCategory"> Liftr Resource category. </param>
        /// <param name="liftrResourcePreference"> The priority of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceMonitorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, DynatraceMonitoringStatus? monitoringStatus, DynatraceMonitorMarketplaceSubscriptionStatus? marketplaceSubscriptionStatus, DynatraceEnvironmentProperties dynatraceEnvironmentProperties, DynatraceMonitorUserInfo userInfo, DynatraceBillingPlanInfo planData, LiftrResourceCategory? liftrResourceCategory, int? liftrResourcePreference, DynatraceProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            MonitoringStatus = monitoringStatus;
            MarketplaceSubscriptionStatus = marketplaceSubscriptionStatus;
            DynatraceEnvironmentProperties = dynatraceEnvironmentProperties;
            UserInfo = userInfo;
            PlanData = planData;
            LiftrResourceCategory = liftrResourceCategory;
            LiftrResourcePreference = liftrResourcePreference;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorData"/> for deserialization. </summary>
        internal DynatraceMonitorData()
        {
        }
        /// <summary> Status of the monitor. </summary>
        public DynatraceMonitoringStatus? MonitoringStatus { get; set; }
        /// <summary> Marketplace subscription status. </summary>
        public DynatraceMonitorMarketplaceSubscriptionStatus? MarketplaceSubscriptionStatus { get; set; }
        /// <summary> Properties of the Dynatrace environment. </summary>
        public DynatraceEnvironmentProperties DynatraceEnvironmentProperties { get; set; }
        /// <summary> User info. </summary>
        public DynatraceMonitorUserInfo UserInfo { get; set; }
        /// <summary> Billing plan information. </summary>
        public DynatraceBillingPlanInfo PlanData { get; set; }
        /// <summary> Liftr Resource category. </summary>
        public LiftrResourceCategory? LiftrResourceCategory { get; }
        /// <summary> The priority of the resource. </summary>
        public int? LiftrResourcePreference { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public DynatraceProvisioningState? ProvisioningState { get; }
    }
}
