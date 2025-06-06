// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OnlineExperimentation.Models
{
    /// <summary> The type of identity to use. </summary>
    public readonly partial struct KeyEncryptionKeyIdentityType : IEquatable<KeyEncryptionKeyIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyEncryptionKeyIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyEncryptionKeyIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAssignedIdentityValue = "SystemAssignedIdentity";
        private const string UserAssignedIdentityValue = "UserAssignedIdentity";

        /// <summary> System assigned identity. </summary>
        public static KeyEncryptionKeyIdentityType SystemAssignedIdentity { get; } = new KeyEncryptionKeyIdentityType(SystemAssignedIdentityValue);
        /// <summary> User assigned identity. </summary>
        public static KeyEncryptionKeyIdentityType UserAssignedIdentity { get; } = new KeyEncryptionKeyIdentityType(UserAssignedIdentityValue);
        /// <summary> Determines if two <see cref="KeyEncryptionKeyIdentityType"/> values are the same. </summary>
        public static bool operator ==(KeyEncryptionKeyIdentityType left, KeyEncryptionKeyIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyEncryptionKeyIdentityType"/> values are not the same. </summary>
        public static bool operator !=(KeyEncryptionKeyIdentityType left, KeyEncryptionKeyIdentityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KeyEncryptionKeyIdentityType"/>. </summary>
        public static implicit operator KeyEncryptionKeyIdentityType(string value) => new KeyEncryptionKeyIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyEncryptionKeyIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyEncryptionKeyIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
