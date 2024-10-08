// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A value indicating whether the auto protection is enabled. </summary>
    public readonly partial struct AutoProtectionOfDataDisk : IEquatable<AutoProtectionOfDataDisk>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutoProtectionOfDataDisk"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutoProtectionOfDataDisk(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static AutoProtectionOfDataDisk Disabled { get; } = new AutoProtectionOfDataDisk(DisabledValue);
        /// <summary> Enabled. </summary>
        public static AutoProtectionOfDataDisk Enabled { get; } = new AutoProtectionOfDataDisk(EnabledValue);
        /// <summary> Determines if two <see cref="AutoProtectionOfDataDisk"/> values are the same. </summary>
        public static bool operator ==(AutoProtectionOfDataDisk left, AutoProtectionOfDataDisk right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutoProtectionOfDataDisk"/> values are not the same. </summary>
        public static bool operator !=(AutoProtectionOfDataDisk left, AutoProtectionOfDataDisk right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutoProtectionOfDataDisk"/>. </summary>
        public static implicit operator AutoProtectionOfDataDisk(string value) => new AutoProtectionOfDataDisk(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutoProtectionOfDataDisk other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutoProtectionOfDataDisk other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
