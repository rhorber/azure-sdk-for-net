// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// Specifies the protocol of WinRM listener. Possible values are: **http,**
    /// **https.**
    /// </summary>
    public readonly partial struct ComputeFleetProtocolType : IEquatable<ComputeFleetProtocolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetProtocolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetProtocolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "Http";
        private const string HttpsValue = "Https";

        /// <summary> Http protocol. </summary>
        public static ComputeFleetProtocolType Http { get; } = new ComputeFleetProtocolType(HttpValue);
        /// <summary> Https protocol. </summary>
        public static ComputeFleetProtocolType Https { get; } = new ComputeFleetProtocolType(HttpsValue);
        /// <summary> Determines if two <see cref="ComputeFleetProtocolType"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetProtocolType left, ComputeFleetProtocolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetProtocolType"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetProtocolType left, ComputeFleetProtocolType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeFleetProtocolType"/>. </summary>
        public static implicit operator ComputeFleetProtocolType(string value) => new ComputeFleetProtocolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetProtocolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetProtocolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
