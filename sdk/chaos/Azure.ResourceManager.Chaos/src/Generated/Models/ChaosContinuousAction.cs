// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a continuous action. </summary>
    public partial class ChaosContinuousAction : ChaosExperimentAction
    {
        /// <summary> Initializes a new instance of <see cref="ChaosContinuousAction"/>. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="parameters"/> or <paramref name="selectorId"/> is null. </exception>
        public ChaosContinuousAction(string name, TimeSpan duration, IEnumerable<ChaosKeyValuePair> parameters, string selectorId) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(selectorId, nameof(selectorId));

            Duration = duration;
            Parameters = parameters.ToList();
            SelectorId = selectorId;
            Type = ExperimentActionType.Continuous;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosContinuousAction"/>. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="type"> Chaos experiment action discriminator type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        internal ChaosContinuousAction(string name, ExperimentActionType type, IDictionary<string, BinaryData> serializedAdditionalRawData, TimeSpan duration, IList<ChaosKeyValuePair> parameters, string selectorId) : base(name, type, serializedAdditionalRawData)
        {
            Duration = duration;
            Parameters = parameters;
            SelectorId = selectorId;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosContinuousAction"/> for deserialization. </summary>
        internal ChaosContinuousAction()
        {
        }

        /// <summary> ISO8601 formatted string that represents a duration. </summary>
        public TimeSpan Duration { get; set; }
        /// <summary> List of key value pairs. </summary>
        public IList<ChaosKeyValuePair> Parameters { get; }
        /// <summary> String that represents a selector. </summary>
        public string SelectorId { get; set; }
    }
}
