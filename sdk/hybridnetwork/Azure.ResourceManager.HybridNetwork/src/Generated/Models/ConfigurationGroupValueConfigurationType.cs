// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The secret type which indicates if secret or not. </summary>
    internal readonly partial struct ConfigurationGroupValueConfigurationType : IEquatable<ConfigurationGroupValueConfigurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfigurationGroupValueConfigurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigurationGroupValueConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SecretValue = "Secret";
        private const string OpenValue = "Open";

        /// <summary> Unknown. </summary>
        public static ConfigurationGroupValueConfigurationType Unknown { get; } = new ConfigurationGroupValueConfigurationType(UnknownValue);
        /// <summary> Secret. </summary>
        public static ConfigurationGroupValueConfigurationType Secret { get; } = new ConfigurationGroupValueConfigurationType(SecretValue);
        /// <summary> Open. </summary>
        public static ConfigurationGroupValueConfigurationType Open { get; } = new ConfigurationGroupValueConfigurationType(OpenValue);
        /// <summary> Determines if two <see cref="ConfigurationGroupValueConfigurationType"/> values are the same. </summary>
        public static bool operator ==(ConfigurationGroupValueConfigurationType left, ConfigurationGroupValueConfigurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigurationGroupValueConfigurationType"/> values are not the same. </summary>
        public static bool operator !=(ConfigurationGroupValueConfigurationType left, ConfigurationGroupValueConfigurationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConfigurationGroupValueConfigurationType"/>. </summary>
        public static implicit operator ConfigurationGroupValueConfigurationType(string value) => new ConfigurationGroupValueConfigurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigurationGroupValueConfigurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigurationGroupValueConfigurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
