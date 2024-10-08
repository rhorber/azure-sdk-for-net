// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The status of a private endpoint connection. </summary>
    public readonly partial struct IotHubPrivateLinkServiceConnectionStatus : IEquatable<IotHubPrivateLinkServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateLinkServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotHubPrivateLinkServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static IotHubPrivateLinkServiceConnectionStatus Pending { get; } = new IotHubPrivateLinkServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static IotHubPrivateLinkServiceConnectionStatus Approved { get; } = new IotHubPrivateLinkServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static IotHubPrivateLinkServiceConnectionStatus Rejected { get; } = new IotHubPrivateLinkServiceConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static IotHubPrivateLinkServiceConnectionStatus Disconnected { get; } = new IotHubPrivateLinkServiceConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="IotHubPrivateLinkServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(IotHubPrivateLinkServiceConnectionStatus left, IotHubPrivateLinkServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotHubPrivateLinkServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(IotHubPrivateLinkServiceConnectionStatus left, IotHubPrivateLinkServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IotHubPrivateLinkServiceConnectionStatus"/>. </summary>
        public static implicit operator IotHubPrivateLinkServiceConnectionStatus(string value) => new IotHubPrivateLinkServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotHubPrivateLinkServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotHubPrivateLinkServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
