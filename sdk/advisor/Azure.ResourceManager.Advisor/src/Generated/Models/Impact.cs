// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The business impact of the recommendation. </summary>
    public readonly partial struct Impact : IEquatable<Impact>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Impact"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Impact(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HighValue = "High";
        private const string MediumValue = "Medium";
        private const string LowValue = "Low";

        /// <summary> High. </summary>
        public static Impact High { get; } = new Impact(HighValue);
        /// <summary> Medium. </summary>
        public static Impact Medium { get; } = new Impact(MediumValue);
        /// <summary> Low. </summary>
        public static Impact Low { get; } = new Impact(LowValue);
        /// <summary> Determines if two <see cref="Impact"/> values are the same. </summary>
        public static bool operator ==(Impact left, Impact right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Impact"/> values are not the same. </summary>
        public static bool operator !=(Impact left, Impact right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="Impact"/>. </summary>
        public static implicit operator Impact(string value) => new Impact(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Impact other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Impact other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
