// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> A specific data exfiltration scenario that is disabled for the service. </summary>
    public readonly partial struct SearchDataExfiltrationProtection : IEquatable<SearchDataExfiltrationProtection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchDataExfiltrationProtection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchDataExfiltrationProtection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BlockAllValue = "BlockAll";

        /// <summary> Indicates that all data exfiltration scenarios are disabled. </summary>
        public static SearchDataExfiltrationProtection BlockAll { get; } = new SearchDataExfiltrationProtection(BlockAllValue);
        /// <summary> Determines if two <see cref="SearchDataExfiltrationProtection"/> values are the same. </summary>
        public static bool operator ==(SearchDataExfiltrationProtection left, SearchDataExfiltrationProtection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchDataExfiltrationProtection"/> values are not the same. </summary>
        public static bool operator !=(SearchDataExfiltrationProtection left, SearchDataExfiltrationProtection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SearchDataExfiltrationProtection"/>. </summary>
        public static implicit operator SearchDataExfiltrationProtection(string value) => new SearchDataExfiltrationProtection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchDataExfiltrationProtection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchDataExfiltrationProtection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
