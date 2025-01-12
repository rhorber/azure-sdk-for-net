// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Indicates whether the replication is cross zone or cross region. </summary>
    public readonly partial struct NetAppReplicationType : IEquatable<NetAppReplicationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppReplicationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppReplicationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CrossRegionReplicationValue = "CrossRegionReplication";
        private const string CrossZoneReplicationValue = "CrossZoneReplication";

        /// <summary> Cross region replication. </summary>
        public static NetAppReplicationType CrossRegionReplication { get; } = new NetAppReplicationType(CrossRegionReplicationValue);
        /// <summary> Cross zone replication. </summary>
        public static NetAppReplicationType CrossZoneReplication { get; } = new NetAppReplicationType(CrossZoneReplicationValue);
        /// <summary> Determines if two <see cref="NetAppReplicationType"/> values are the same. </summary>
        public static bool operator ==(NetAppReplicationType left, NetAppReplicationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppReplicationType"/> values are not the same. </summary>
        public static bool operator !=(NetAppReplicationType left, NetAppReplicationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppReplicationType"/>. </summary>
        public static implicit operator NetAppReplicationType(string value) => new NetAppReplicationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppReplicationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppReplicationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
