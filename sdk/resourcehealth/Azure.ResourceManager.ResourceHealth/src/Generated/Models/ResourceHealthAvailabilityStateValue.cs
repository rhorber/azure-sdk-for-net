// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Impacted resource status of the resource. </summary>
    public readonly partial struct ResourceHealthAvailabilityStateValue : IEquatable<ResourceHealthAvailabilityStateValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthAvailabilityStateValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceHealthAvailabilityStateValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string UnavailableValue = "Unavailable";
        private const string DegradedValue = "Degraded";
        private const string UnknownValue = "Unknown";

        /// <summary> Available. </summary>
        public static ResourceHealthAvailabilityStateValue Available { get; } = new ResourceHealthAvailabilityStateValue(AvailableValue);
        /// <summary> Unavailable. </summary>
        public static ResourceHealthAvailabilityStateValue Unavailable { get; } = new ResourceHealthAvailabilityStateValue(UnavailableValue);
        /// <summary> Degraded. </summary>
        public static ResourceHealthAvailabilityStateValue Degraded { get; } = new ResourceHealthAvailabilityStateValue(DegradedValue);
        /// <summary> Unknown. </summary>
        public static ResourceHealthAvailabilityStateValue Unknown { get; } = new ResourceHealthAvailabilityStateValue(UnknownValue);
        /// <summary> Determines if two <see cref="ResourceHealthAvailabilityStateValue"/> values are the same. </summary>
        public static bool operator ==(ResourceHealthAvailabilityStateValue left, ResourceHealthAvailabilityStateValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceHealthAvailabilityStateValue"/> values are not the same. </summary>
        public static bool operator !=(ResourceHealthAvailabilityStateValue left, ResourceHealthAvailabilityStateValue right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceHealthAvailabilityStateValue"/>. </summary>
        public static implicit operator ResourceHealthAvailabilityStateValue(string value) => new ResourceHealthAvailabilityStateValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceHealthAvailabilityStateValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceHealthAvailabilityStateValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
