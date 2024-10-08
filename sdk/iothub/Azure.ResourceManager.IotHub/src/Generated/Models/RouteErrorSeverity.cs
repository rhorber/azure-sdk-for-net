// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Severity of the route error. </summary>
    public readonly partial struct RouteErrorSeverity : IEquatable<RouteErrorSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouteErrorSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouteErrorSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "error";
        private const string WarningValue = "warning";

        /// <summary> error. </summary>
        public static RouteErrorSeverity Error { get; } = new RouteErrorSeverity(ErrorValue);
        /// <summary> warning. </summary>
        public static RouteErrorSeverity Warning { get; } = new RouteErrorSeverity(WarningValue);
        /// <summary> Determines if two <see cref="RouteErrorSeverity"/> values are the same. </summary>
        public static bool operator ==(RouteErrorSeverity left, RouteErrorSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouteErrorSeverity"/> values are not the same. </summary>
        public static bool operator !=(RouteErrorSeverity left, RouteErrorSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RouteErrorSeverity"/>. </summary>
        public static implicit operator RouteErrorSeverity(string value) => new RouteErrorSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouteErrorSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouteErrorSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
