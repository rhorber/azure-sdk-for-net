// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the event properties. </summary>
    public partial class DeviceRegistryEvent : DeviceRegistryEventBase
    {
        /// <summary> Initializes a new instance of <see cref="DeviceRegistryEvent"/>. </summary>
        /// <param name="name"> The name of the event. </param>
        /// <param name="eventNotifier"> The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="eventNotifier"/> is null. </exception>
        public DeviceRegistryEvent(string name, string eventNotifier) : base(name, eventNotifier)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(eventNotifier, nameof(eventNotifier));
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryEvent"/>. </summary>
        /// <param name="name"> The name of the event. </param>
        /// <param name="eventNotifier"> The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset. </param>
        /// <param name="eventConfiguration"> Stringified JSON that contains connector-specific configuration for the event. For OPC UA, this could include configuration like, publishingInterval, samplingInterval, and queueSize. </param>
        /// <param name="topic"> Object that describes the topic information for the specific event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="observabilityMode"> An indication of how the event should be mapped to OpenTelemetry. </param>
        internal DeviceRegistryEvent(string name, string eventNotifier, string eventConfiguration, DeviceRegistryTopic topic, IDictionary<string, BinaryData> serializedAdditionalRawData, EventObservabilityMode? observabilityMode) : base(name, eventNotifier, eventConfiguration, topic, serializedAdditionalRawData)
        {
            ObservabilityMode = observabilityMode;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryEvent"/> for deserialization. </summary>
        internal DeviceRegistryEvent()
        {
        }

        /// <summary> An indication of how the event should be mapped to OpenTelemetry. </summary>
        public EventObservabilityMode? ObservabilityMode { get; set; }
    }
}
