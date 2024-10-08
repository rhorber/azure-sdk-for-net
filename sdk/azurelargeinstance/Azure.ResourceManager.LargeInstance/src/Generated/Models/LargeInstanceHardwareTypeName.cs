// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LargeInstance.Models
{
    /// <summary> Enum of the hardware options (vendor and/or their product name) for an Azure Large Instance. </summary>
    public readonly partial struct LargeInstanceHardwareTypeName : IEquatable<LargeInstanceHardwareTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LargeInstanceHardwareTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LargeInstanceHardwareTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CiscoUcsValue = "Cisco_UCS";
        private const string HpeValue = "HPE";
        private const string SDFlexValue = "SDFLEX";

        /// <summary> Hardware type of UCS from vendor Cisco. </summary>
        public static LargeInstanceHardwareTypeName CiscoUcs { get; } = new LargeInstanceHardwareTypeName(CiscoUcsValue);
        /// <summary> Hardware type of HPE from vendor Hewlett Packard Enterprise. </summary>
        public static LargeInstanceHardwareTypeName Hpe { get; } = new LargeInstanceHardwareTypeName(HpeValue);
        /// <summary> Hardware type of SDFLEX. </summary>
        public static LargeInstanceHardwareTypeName SDFlex { get; } = new LargeInstanceHardwareTypeName(SDFlexValue);
        /// <summary> Determines if two <see cref="LargeInstanceHardwareTypeName"/> values are the same. </summary>
        public static bool operator ==(LargeInstanceHardwareTypeName left, LargeInstanceHardwareTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LargeInstanceHardwareTypeName"/> values are not the same. </summary>
        public static bool operator !=(LargeInstanceHardwareTypeName left, LargeInstanceHardwareTypeName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LargeInstanceHardwareTypeName"/>. </summary>
        public static implicit operator LargeInstanceHardwareTypeName(string value) => new LargeInstanceHardwareTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LargeInstanceHardwareTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LargeInstanceHardwareTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
