// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedCache.Models
{
    /// <summary> Auto update Ring type. </summary>
    public readonly partial struct AutoUpdateRingType : IEquatable<AutoUpdateRingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutoUpdateRingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutoUpdateRingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreviewValue = "Preview";
        private const string SlowValue = "Slow";
        private const string FastValue = "Fast";

        /// <summary> customer selection of preview update install mcc on their physical vm. </summary>
        public static AutoUpdateRingType Preview { get; } = new AutoUpdateRingType(PreviewValue);
        /// <summary> customer selection of slow update to install mcc on their physical vm. </summary>
        public static AutoUpdateRingType Slow { get; } = new AutoUpdateRingType(SlowValue);
        /// <summary> customer selection of fast / auto update to install mcc on their physical vm. </summary>
        public static AutoUpdateRingType Fast { get; } = new AutoUpdateRingType(FastValue);
        /// <summary> Determines if two <see cref="AutoUpdateRingType"/> values are the same. </summary>
        public static bool operator ==(AutoUpdateRingType left, AutoUpdateRingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutoUpdateRingType"/> values are not the same. </summary>
        public static bool operator !=(AutoUpdateRingType left, AutoUpdateRingType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutoUpdateRingType"/>. </summary>
        public static implicit operator AutoUpdateRingType(string value) => new AutoUpdateRingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutoUpdateRingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutoUpdateRingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
