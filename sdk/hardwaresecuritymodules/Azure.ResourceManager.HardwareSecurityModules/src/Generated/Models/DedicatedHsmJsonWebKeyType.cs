// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Provisioning state. </summary>
    public readonly partial struct DedicatedHsmJsonWebKeyType : IEquatable<DedicatedHsmJsonWebKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DedicatedHsmJsonWebKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DedicatedHsmJsonWebKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string ProvisioningValue = "Provisioning";
        private const string AllocatingValue = "Allocating";
        private const string ConnectingValue = "Connecting";
        private const string FailedValue = "Failed";
        private const string CheckingQuotaValue = "CheckingQuota";
        private const string DeletingValue = "Deleting";

        /// <summary> The dedicated HSM has been fully provisioned. </summary>
        public static DedicatedHsmJsonWebKeyType Succeeded { get; } = new DedicatedHsmJsonWebKeyType(SucceededValue);
        /// <summary> The dedicated HSM is currently being provisioned. </summary>
        public static DedicatedHsmJsonWebKeyType Provisioning { get; } = new DedicatedHsmJsonWebKeyType(ProvisioningValue);
        /// <summary> A device is currently being allocated for the dedicated HSM resource. </summary>
        public static DedicatedHsmJsonWebKeyType Allocating { get; } = new DedicatedHsmJsonWebKeyType(AllocatingValue);
        /// <summary> The dedicated HSM is being connected to the virtual network. </summary>
        public static DedicatedHsmJsonWebKeyType Connecting { get; } = new DedicatedHsmJsonWebKeyType(ConnectingValue);
        /// <summary> Provisioning of the dedicated HSM has failed. </summary>
        public static DedicatedHsmJsonWebKeyType Failed { get; } = new DedicatedHsmJsonWebKeyType(FailedValue);
        /// <summary> Validating the subscription has sufficient quota to allocate a dedicated HSM device. </summary>
        public static DedicatedHsmJsonWebKeyType CheckingQuota { get; } = new DedicatedHsmJsonWebKeyType(CheckingQuotaValue);
        /// <summary> The dedicated HSM is currently being deleted. </summary>
        public static DedicatedHsmJsonWebKeyType Deleting { get; } = new DedicatedHsmJsonWebKeyType(DeletingValue);
        /// <summary> Determines if two <see cref="DedicatedHsmJsonWebKeyType"/> values are the same. </summary>
        public static bool operator ==(DedicatedHsmJsonWebKeyType left, DedicatedHsmJsonWebKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DedicatedHsmJsonWebKeyType"/> values are not the same. </summary>
        public static bool operator !=(DedicatedHsmJsonWebKeyType left, DedicatedHsmJsonWebKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DedicatedHsmJsonWebKeyType"/>. </summary>
        public static implicit operator DedicatedHsmJsonWebKeyType(string value) => new DedicatedHsmJsonWebKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DedicatedHsmJsonWebKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DedicatedHsmJsonWebKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
