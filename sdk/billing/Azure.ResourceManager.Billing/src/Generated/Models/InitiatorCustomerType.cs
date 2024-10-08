// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The type of customer of the transfer initiator. </summary>
    public readonly partial struct InitiatorCustomerType : IEquatable<InitiatorCustomerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InitiatorCustomerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InitiatorCustomerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PartnerValue = "Partner";
        private const string EAValue = "EA";

        /// <summary> Partner. </summary>
        public static InitiatorCustomerType Partner { get; } = new InitiatorCustomerType(PartnerValue);
        /// <summary> EA. </summary>
        public static InitiatorCustomerType EA { get; } = new InitiatorCustomerType(EAValue);
        /// <summary> Determines if two <see cref="InitiatorCustomerType"/> values are the same. </summary>
        public static bool operator ==(InitiatorCustomerType left, InitiatorCustomerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InitiatorCustomerType"/> values are not the same. </summary>
        public static bool operator !=(InitiatorCustomerType left, InitiatorCustomerType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InitiatorCustomerType"/>. </summary>
        public static implicit operator InitiatorCustomerType(string value) => new InitiatorCustomerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InitiatorCustomerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InitiatorCustomerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
