// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The type of the connection. </summary>
    public readonly partial struct SqlConnectionType : IEquatable<SqlConnectionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlConnectionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlConnectionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SqlOnDemandValue = "SqlOnDemand";
        private const string SqlPoolValue = "SqlPool";

        /// <summary> SqlOnDemand. </summary>
        public static SqlConnectionType SqlOnDemand { get; } = new SqlConnectionType(SqlOnDemandValue);
        /// <summary> SqlPool. </summary>
        public static SqlConnectionType SqlPool { get; } = new SqlConnectionType(SqlPoolValue);
        /// <summary> Determines if two <see cref="SqlConnectionType"/> values are the same. </summary>
        public static bool operator ==(SqlConnectionType left, SqlConnectionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlConnectionType"/> values are not the same. </summary>
        public static bool operator !=(SqlConnectionType left, SqlConnectionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlConnectionType"/>. </summary>
        public static implicit operator SqlConnectionType(string value) => new SqlConnectionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlConnectionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlConnectionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
