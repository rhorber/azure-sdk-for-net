// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the certification record synchronized from app compliance. </summary>
    public partial class CertSyncRecord
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

        /// <summary> Initializes a new instance of <see cref="CertSyncRecord"/>. </summary>
        public CertSyncRecord()
        {
            Controls = new ChangeTrackingList<ControlSyncRecord>();
        }

        /// <summary> Initializes a new instance of <see cref="CertSyncRecord"/>. </summary>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="certificationStatus"> Indicates the status of certification process. </param>
        /// <param name="ingestionStatus"> Indicates the status of compliance process. </param>
        /// <param name="controls"> The control records list to be synchronized. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CertSyncRecord(string offerGuid, string certificationStatus, string ingestionStatus, IList<ControlSyncRecord> controls, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferGuid = offerGuid;
            CertificationStatus = certificationStatus;
            IngestionStatus = ingestionStatus;
            Controls = controls;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The offerGuid which mapping to the reports. </summary>
        public string OfferGuid { get; set; }
        /// <summary> Indicates the status of certification process. </summary>
        public string CertificationStatus { get; set; }
        /// <summary> Indicates the status of compliance process. </summary>
        public string IngestionStatus { get; set; }
        /// <summary> The control records list to be synchronized. </summary>
        public IList<ControlSyncRecord> Controls { get; }
    }
}
