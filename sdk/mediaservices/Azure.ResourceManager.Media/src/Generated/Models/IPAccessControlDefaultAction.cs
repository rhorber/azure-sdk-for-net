// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The behavior for IP access control in Key Delivery. </summary>
    public readonly partial struct IPAccessControlDefaultAction : IEquatable<IPAccessControlDefaultAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPAccessControlDefaultAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPAccessControlDefaultAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> All public IP addresses are allowed. </summary>
        public static IPAccessControlDefaultAction Allow { get; } = new IPAccessControlDefaultAction(AllowValue);
        /// <summary> Public IP addresses are blocked. </summary>
        public static IPAccessControlDefaultAction Deny { get; } = new IPAccessControlDefaultAction(DenyValue);
        /// <summary> Determines if two <see cref="IPAccessControlDefaultAction"/> values are the same. </summary>
        public static bool operator ==(IPAccessControlDefaultAction left, IPAccessControlDefaultAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPAccessControlDefaultAction"/> values are not the same. </summary>
        public static bool operator !=(IPAccessControlDefaultAction left, IPAccessControlDefaultAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IPAccessControlDefaultAction"/>. </summary>
        public static implicit operator IPAccessControlDefaultAction(string value) => new IPAccessControlDefaultAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPAccessControlDefaultAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPAccessControlDefaultAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
