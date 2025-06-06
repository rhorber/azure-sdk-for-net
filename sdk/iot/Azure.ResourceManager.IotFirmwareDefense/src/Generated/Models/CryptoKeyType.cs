// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Different types of cryptographic keys. </summary>
    public readonly partial struct CryptoKeyType : IEquatable<CryptoKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CryptoKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CryptoKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "Public";
        private const string PrivateValue = "Private";

        /// <summary> The key is an asymmetric public key. </summary>
        public static CryptoKeyType Public { get; } = new CryptoKeyType(PublicValue);
        /// <summary> The key is an asymmetric private key. </summary>
        public static CryptoKeyType Private { get; } = new CryptoKeyType(PrivateValue);
        /// <summary> Determines if two <see cref="CryptoKeyType"/> values are the same. </summary>
        public static bool operator ==(CryptoKeyType left, CryptoKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CryptoKeyType"/> values are not the same. </summary>
        public static bool operator !=(CryptoKeyType left, CryptoKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CryptoKeyType"/>. </summary>
        public static implicit operator CryptoKeyType(string value) => new CryptoKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CryptoKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CryptoKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
