// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Specifies the assessment mode. </summary>
    public readonly partial struct AssessmentModeType : IEquatable<AssessmentModeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssessmentModeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssessmentModeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImageDefaultValue = "ImageDefault";
        private const string AutomaticByPlatformValue = "AutomaticByPlatform";

        /// <summary> ImageDefault. </summary>
        public static AssessmentModeType ImageDefault { get; } = new AssessmentModeType(ImageDefaultValue);
        /// <summary> AutomaticByPlatform. </summary>
        public static AssessmentModeType AutomaticByPlatform { get; } = new AssessmentModeType(AutomaticByPlatformValue);
        /// <summary> Determines if two <see cref="AssessmentModeType"/> values are the same. </summary>
        public static bool operator ==(AssessmentModeType left, AssessmentModeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssessmentModeType"/> values are not the same. </summary>
        public static bool operator !=(AssessmentModeType left, AssessmentModeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AssessmentModeType"/>. </summary>
        public static implicit operator AssessmentModeType(string value) => new AssessmentModeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssessmentModeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssessmentModeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
