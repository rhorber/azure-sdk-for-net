// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the execution mode. In Audit mode, the system acts as if it is enforcing the access control policy, including emitting access denial entries in the logs but it does not actually deny any requests to host endpoints. In Enforce mode, the system will enforce the access control and it is the recommended mode of operation. </summary>
    public readonly partial struct HostEndpointSettingsMode : IEquatable<HostEndpointSettingsMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostEndpointSettingsMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostEndpointSettingsMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuditValue = "Audit";
        private const string EnforceValue = "Enforce";
        private const string DisabledValue = "Disabled";

        /// <summary> Audit. </summary>
        public static HostEndpointSettingsMode Audit { get; } = new HostEndpointSettingsMode(AuditValue);
        /// <summary> Enforce. </summary>
        public static HostEndpointSettingsMode Enforce { get; } = new HostEndpointSettingsMode(EnforceValue);
        /// <summary> Disabled. </summary>
        public static HostEndpointSettingsMode Disabled { get; } = new HostEndpointSettingsMode(DisabledValue);
        /// <summary> Determines if two <see cref="HostEndpointSettingsMode"/> values are the same. </summary>
        public static bool operator ==(HostEndpointSettingsMode left, HostEndpointSettingsMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostEndpointSettingsMode"/> values are not the same. </summary>
        public static bool operator !=(HostEndpointSettingsMode left, HostEndpointSettingsMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HostEndpointSettingsMode"/>. </summary>
        public static implicit operator HostEndpointSettingsMode(string value) => new HostEndpointSettingsMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostEndpointSettingsMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostEndpointSettingsMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
