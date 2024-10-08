// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The implementation effort required to remediate this assessment. </summary>
    public readonly partial struct ImplementationEffort : IEquatable<ImplementationEffort>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImplementationEffort"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImplementationEffort(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "Low";
        private const string ModerateValue = "Moderate";
        private const string HighValue = "High";

        /// <summary> Low. </summary>
        public static ImplementationEffort Low { get; } = new ImplementationEffort(LowValue);
        /// <summary> Moderate. </summary>
        public static ImplementationEffort Moderate { get; } = new ImplementationEffort(ModerateValue);
        /// <summary> High. </summary>
        public static ImplementationEffort High { get; } = new ImplementationEffort(HighValue);
        /// <summary> Determines if two <see cref="ImplementationEffort"/> values are the same. </summary>
        public static bool operator ==(ImplementationEffort left, ImplementationEffort right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImplementationEffort"/> values are not the same. </summary>
        public static bool operator !=(ImplementationEffort left, ImplementationEffort right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ImplementationEffort"/>. </summary>
        public static implicit operator ImplementationEffort(string value) => new ImplementationEffort(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImplementationEffort other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImplementationEffort other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
