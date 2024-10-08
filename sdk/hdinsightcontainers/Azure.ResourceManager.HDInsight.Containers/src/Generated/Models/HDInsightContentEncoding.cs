// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> This property indicates if the content is encoded and is case-insensitive. Please set the value to base64 if the content is base64 encoded. Set it to none or skip it if the content is plain text. </summary>
    public readonly partial struct HDInsightContentEncoding : IEquatable<HDInsightContentEncoding>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightContentEncoding"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightContentEncoding(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Base64Value = "Base64";
        private const string NoneValue = "None";

        /// <summary> Base64. </summary>
        public static HDInsightContentEncoding Base64 { get; } = new HDInsightContentEncoding(Base64Value);
        /// <summary> None. </summary>
        public static HDInsightContentEncoding None { get; } = new HDInsightContentEncoding(NoneValue);
        /// <summary> Determines if two <see cref="HDInsightContentEncoding"/> values are the same. </summary>
        public static bool operator ==(HDInsightContentEncoding left, HDInsightContentEncoding right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightContentEncoding"/> values are not the same. </summary>
        public static bool operator !=(HDInsightContentEncoding left, HDInsightContentEncoding right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HDInsightContentEncoding"/>. </summary>
        public static implicit operator HDInsightContentEncoding(string value) => new HDInsightContentEncoding(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightContentEncoding other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightContentEncoding other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
