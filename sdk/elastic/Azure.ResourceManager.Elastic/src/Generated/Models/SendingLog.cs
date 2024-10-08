// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Flag indicating the status of the resource for sending logs operation to Elastic. </summary>
    public readonly partial struct SendingLog : IEquatable<SendingLog>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SendingLog"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SendingLog(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static SendingLog True { get; } = new SendingLog(TrueValue);
        /// <summary> False. </summary>
        public static SendingLog False { get; } = new SendingLog(FalseValue);
        /// <summary> Determines if two <see cref="SendingLog"/> values are the same. </summary>
        public static bool operator ==(SendingLog left, SendingLog right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SendingLog"/> values are not the same. </summary>
        public static bool operator !=(SendingLog left, SendingLog right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SendingLog"/>. </summary>
        public static implicit operator SendingLog(string value) => new SendingLog(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SendingLog other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SendingLog other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
