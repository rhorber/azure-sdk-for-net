// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> State of the log scrubbing config. Default value is Enabled. </summary>
    public readonly partial struct WebApplicationFirewallScrubbingState : IEquatable<WebApplicationFirewallScrubbingState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallScrubbingState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebApplicationFirewallScrubbingState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static WebApplicationFirewallScrubbingState Enabled { get; } = new WebApplicationFirewallScrubbingState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static WebApplicationFirewallScrubbingState Disabled { get; } = new WebApplicationFirewallScrubbingState(DisabledValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallScrubbingState"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallScrubbingState left, WebApplicationFirewallScrubbingState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallScrubbingState"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallScrubbingState left, WebApplicationFirewallScrubbingState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WebApplicationFirewallScrubbingState"/>. </summary>
        public static implicit operator WebApplicationFirewallScrubbingState(string value) => new WebApplicationFirewallScrubbingState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallScrubbingState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallScrubbingState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
