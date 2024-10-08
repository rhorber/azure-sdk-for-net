// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The hypothesis status of the hunt. </summary>
    public readonly partial struct HypothesisStatus : IEquatable<HypothesisStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HypothesisStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HypothesisStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string InvalidatedValue = "Invalidated";
        private const string ValidatedValue = "Validated";

        /// <summary> Unknown. </summary>
        public static HypothesisStatus Unknown { get; } = new HypothesisStatus(UnknownValue);
        /// <summary> Invalidated. </summary>
        public static HypothesisStatus Invalidated { get; } = new HypothesisStatus(InvalidatedValue);
        /// <summary> Validated. </summary>
        public static HypothesisStatus Validated { get; } = new HypothesisStatus(ValidatedValue);
        /// <summary> Determines if two <see cref="HypothesisStatus"/> values are the same. </summary>
        public static bool operator ==(HypothesisStatus left, HypothesisStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HypothesisStatus"/> values are not the same. </summary>
        public static bool operator !=(HypothesisStatus left, HypothesisStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HypothesisStatus"/>. </summary>
        public static implicit operator HypothesisStatus(string value) => new HypothesisStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HypothesisStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HypothesisStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
