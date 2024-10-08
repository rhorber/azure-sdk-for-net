// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The authentication type. </summary>
    public readonly partial struct DataBoxEdgeAuthenticationType : IEquatable<DataBoxEdgeAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AzureActiveDirectoryValue = "AzureActiveDirectory";

        /// <summary> Invalid. </summary>
        public static DataBoxEdgeAuthenticationType Invalid { get; } = new DataBoxEdgeAuthenticationType(InvalidValue);
        /// <summary> AzureActiveDirectory. </summary>
        public static DataBoxEdgeAuthenticationType AzureActiveDirectory { get; } = new DataBoxEdgeAuthenticationType(AzureActiveDirectoryValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeAuthenticationType left, DataBoxEdgeAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeAuthenticationType left, DataBoxEdgeAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxEdgeAuthenticationType"/>. </summary>
        public static implicit operator DataBoxEdgeAuthenticationType(string value) => new DataBoxEdgeAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
