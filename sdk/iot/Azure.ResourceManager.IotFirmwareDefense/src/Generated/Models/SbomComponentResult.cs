// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> The object representing a firmware analysis SBOM component result resource. </summary>
    public partial class SbomComponentResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SbomComponentResult"/>. </summary>
        public SbomComponentResult()
        {
            FilePaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SbomComponentResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="componentId"> ID for the component. </param>
        /// <param name="componentName"> Name for the component. </param>
        /// <param name="version"> Version for the component. </param>
        /// <param name="license"> License for the component. </param>
        /// <param name="filePaths"> File paths related to the component. Note, relatedFiles should be used instead of this property. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SbomComponentResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string componentId, string componentName, string version, string license, IList<string> filePaths, FirmwareProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ComponentId = componentId;
            ComponentName = componentName;
            Version = version;
            License = license;
            FilePaths = filePaths;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID for the component. </summary>
        public string ComponentId { get; set; }
        /// <summary> Name for the component. </summary>
        public string ComponentName { get; set; }
        /// <summary> Version for the component. </summary>
        public string Version { get; set; }
        /// <summary> License for the component. </summary>
        public string License { get; set; }
        /// <summary> File paths related to the component. Note, relatedFiles should be used instead of this property. </summary>
        public IList<string> FilePaths { get; }
        /// <summary> The status of the last operation. </summary>
        public FirmwareProvisioningState? ProvisioningState { get; }
    }
}
