// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Describes whether user engagement tracking is enabled or disabled. </summary>
    public readonly partial struct UserEngagementTracking : IEquatable<UserEngagementTracking>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UserEngagementTracking"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UserEngagementTracking(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static UserEngagementTracking Disabled { get; } = new UserEngagementTracking(DisabledValue);
        /// <summary> Enabled. </summary>
        public static UserEngagementTracking Enabled { get; } = new UserEngagementTracking(EnabledValue);
        /// <summary> Determines if two <see cref="UserEngagementTracking"/> values are the same. </summary>
        public static bool operator ==(UserEngagementTracking left, UserEngagementTracking right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UserEngagementTracking"/> values are not the same. </summary>
        public static bool operator !=(UserEngagementTracking left, UserEngagementTracking right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="UserEngagementTracking"/>. </summary>
        public static implicit operator UserEngagementTracking(string value) => new UserEngagementTracking(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UserEngagementTracking other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UserEngagementTracking other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
