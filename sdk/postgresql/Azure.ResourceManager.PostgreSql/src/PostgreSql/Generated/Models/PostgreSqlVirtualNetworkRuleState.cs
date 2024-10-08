// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Virtual Network Rule State. </summary>
    public readonly partial struct PostgreSqlVirtualNetworkRuleState : IEquatable<PostgreSqlVirtualNetworkRuleState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlVirtualNetworkRuleState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlVirtualNetworkRuleState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitializingValue = "Initializing";
        private const string InProgressValue = "InProgress";
        private const string ReadyValue = "Ready";
        private const string DeletingValue = "Deleting";
        private const string UnknownValue = "Unknown";

        /// <summary> Initializing. </summary>
        public static PostgreSqlVirtualNetworkRuleState Initializing { get; } = new PostgreSqlVirtualNetworkRuleState(InitializingValue);
        /// <summary> InProgress. </summary>
        public static PostgreSqlVirtualNetworkRuleState InProgress { get; } = new PostgreSqlVirtualNetworkRuleState(InProgressValue);
        /// <summary> Ready. </summary>
        public static PostgreSqlVirtualNetworkRuleState Ready { get; } = new PostgreSqlVirtualNetworkRuleState(ReadyValue);
        /// <summary> Deleting. </summary>
        public static PostgreSqlVirtualNetworkRuleState Deleting { get; } = new PostgreSqlVirtualNetworkRuleState(DeletingValue);
        /// <summary> Unknown. </summary>
        public static PostgreSqlVirtualNetworkRuleState Unknown { get; } = new PostgreSqlVirtualNetworkRuleState(UnknownValue);
        /// <summary> Determines if two <see cref="PostgreSqlVirtualNetworkRuleState"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlVirtualNetworkRuleState left, PostgreSqlVirtualNetworkRuleState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlVirtualNetworkRuleState"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlVirtualNetworkRuleState left, PostgreSqlVirtualNetworkRuleState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlVirtualNetworkRuleState"/>. </summary>
        public static implicit operator PostgreSqlVirtualNetworkRuleState(string value) => new PostgreSqlVirtualNetworkRuleState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlVirtualNetworkRuleState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlVirtualNetworkRuleState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
