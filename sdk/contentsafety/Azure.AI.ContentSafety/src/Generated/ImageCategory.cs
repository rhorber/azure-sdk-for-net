// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.ContentSafety
{
    /// <summary> Image analyze category. </summary>
    public readonly partial struct ImageCategory : IEquatable<ImageCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HateValue = "Hate";
        private const string SelfHarmValue = "SelfHarm";
        private const string SexualValue = "Sexual";
        private const string ViolenceValue = "Violence";

        /// <summary> Hate. </summary>
        public static ImageCategory Hate { get; } = new ImageCategory(HateValue);
        /// <summary> SelfHarm. </summary>
        public static ImageCategory SelfHarm { get; } = new ImageCategory(SelfHarmValue);
        /// <summary> Sexual. </summary>
        public static ImageCategory Sexual { get; } = new ImageCategory(SexualValue);
        /// <summary> Violence. </summary>
        public static ImageCategory Violence { get; } = new ImageCategory(ViolenceValue);
        /// <summary> Determines if two <see cref="ImageCategory"/> values are the same. </summary>
        public static bool operator ==(ImageCategory left, ImageCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageCategory"/> values are not the same. </summary>
        public static bool operator !=(ImageCategory left, ImageCategory right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ImageCategory"/>. </summary>
        public static implicit operator ImageCategory(string value) => new ImageCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
