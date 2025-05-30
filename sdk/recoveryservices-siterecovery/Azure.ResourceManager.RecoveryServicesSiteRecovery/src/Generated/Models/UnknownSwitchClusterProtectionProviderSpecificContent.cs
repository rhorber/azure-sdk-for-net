// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unknown version of SwitchClusterProtectionProviderSpecificInput. </summary>
    internal partial class UnknownSwitchClusterProtectionProviderSpecificContent : SwitchClusterProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSwitchClusterProtectionProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSwitchClusterProtectionProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSwitchClusterProtectionProviderSpecificContent"/> for deserialization. </summary>
        internal UnknownSwitchClusterProtectionProviderSpecificContent()
        {
        }
    }
}
