// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The operator to compare properties by. </summary>
    public readonly partial struct OutputSelectorOperator : IEquatable<OutputSelectorOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OutputSelectorOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OutputSelectorOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IsValue = "is";
        private const string IsNotValue = "isNot";

        /// <summary> The property is of the type defined by value. </summary>
        public static OutputSelectorOperator Is { get; } = new OutputSelectorOperator(IsValue);
        /// <summary> The property is not of the type defined by value. </summary>
        public static OutputSelectorOperator IsNot { get; } = new OutputSelectorOperator(IsNotValue);
        /// <summary> Determines if two <see cref="OutputSelectorOperator"/> values are the same. </summary>
        public static bool operator ==(OutputSelectorOperator left, OutputSelectorOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OutputSelectorOperator"/> values are not the same. </summary>
        public static bool operator !=(OutputSelectorOperator left, OutputSelectorOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OutputSelectorOperator"/>. </summary>
        public static implicit operator OutputSelectorOperator(string value) => new OutputSelectorOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OutputSelectorOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OutputSelectorOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
