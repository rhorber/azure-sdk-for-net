// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> An agreement. </summary>
    public partial class BillingAgreementProperties
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

        /// <summary> Initializes a new instance of <see cref="BillingAgreementProperties"/>. </summary>
        public BillingAgreementProperties()
        {
            BillingProfileInfo = new ChangeTrackingList<BillingProfileInfo>();
            Participants = new ChangeTrackingList<BillingAgreementParticipant>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingAgreementProperties"/>. </summary>
        /// <param name="acceptanceMode"> The mode of acceptance for an agreement. </param>
        /// <param name="agreementLink"> The URL to download the agreement. </param>
        /// <param name="billingProfileInfo"> The list of billing profiles associated with agreement and present only for specific agreements. </param>
        /// <param name="category"> The category of the agreement. </param>
        /// <param name="displayName"> The name of the agreement signed by a customer. </param>
        /// <param name="effectiveOn"> The date from which the agreement is effective. </param>
        /// <param name="expireOn"> The date when the agreement expires. </param>
        /// <param name="participants"> The list of participants that participates in acceptance of an agreement. </param>
        /// <param name="status"> The current status of the agreement. </param>
        /// <param name="leadBillingAccountName"> The ID of the lead billing account if this agreement is part of the Customer Affiliate Purchase Terms. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingAgreementProperties(AgreementAcceptanceMode? acceptanceMode, string agreementLink, IReadOnlyList<BillingProfileInfo> billingProfileInfo, BillingAgreementCategory? category, string displayName, DateTimeOffset? effectiveOn, DateTimeOffset? expireOn, IReadOnlyList<BillingAgreementParticipant> participants, string status, string leadBillingAccountName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AcceptanceMode = acceptanceMode;
            AgreementLink = agreementLink;
            BillingProfileInfo = billingProfileInfo;
            Category = category;
            DisplayName = displayName;
            EffectiveOn = effectiveOn;
            ExpireOn = expireOn;
            Participants = participants;
            Status = status;
            LeadBillingAccountName = leadBillingAccountName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The mode of acceptance for an agreement. </summary>
        [WirePath("acceptanceMode")]
        public AgreementAcceptanceMode? AcceptanceMode { get; }
        /// <summary> The URL to download the agreement. </summary>
        [WirePath("agreementLink")]
        public string AgreementLink { get; }
        /// <summary> The list of billing profiles associated with agreement and present only for specific agreements. </summary>
        [WirePath("billingProfileInfo")]
        public IReadOnlyList<BillingProfileInfo> BillingProfileInfo { get; }
        /// <summary> The category of the agreement. </summary>
        [WirePath("category")]
        public BillingAgreementCategory? Category { get; }
        /// <summary> The name of the agreement signed by a customer. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; }
        /// <summary> The date from which the agreement is effective. </summary>
        [WirePath("effectiveDate")]
        public DateTimeOffset? EffectiveOn { get; }
        /// <summary> The date when the agreement expires. </summary>
        [WirePath("expirationDate")]
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> The list of participants that participates in acceptance of an agreement. </summary>
        [WirePath("participants")]
        public IReadOnlyList<BillingAgreementParticipant> Participants { get; }
        /// <summary> The current status of the agreement. </summary>
        [WirePath("status")]
        public string Status { get; }
        /// <summary> The ID of the lead billing account if this agreement is part of the Customer Affiliate Purchase Terms. </summary>
        [WirePath("leadBillingAccountName")]
        public string LeadBillingAccountName { get; }
    }
}
