// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the volume. </summary>
    public readonly partial struct VolumeDetailedStatus : IEquatable<VolumeDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VolumeDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VolumeDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string ActiveValue = "Active";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Error. </summary>
        public static VolumeDetailedStatus Error { get; } = new VolumeDetailedStatus(ErrorValue);
        /// <summary> Active. </summary>
        public static VolumeDetailedStatus Active { get; } = new VolumeDetailedStatus(ActiveValue);
        /// <summary> Provisioning. </summary>
        public static VolumeDetailedStatus Provisioning { get; } = new VolumeDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="VolumeDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(VolumeDetailedStatus left, VolumeDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VolumeDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(VolumeDetailedStatus left, VolumeDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VolumeDetailedStatus"/>. </summary>
        public static implicit operator VolumeDetailedStatus(string value) => new VolumeDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VolumeDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VolumeDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
