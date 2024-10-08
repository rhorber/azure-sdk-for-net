// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> VM disk types which are disallowed. </summary>
    public readonly partial struct VirtualMachineDiskType : IEquatable<VirtualMachineDiskType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineDiskType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string UnmanagedValue = "Unmanaged";

        /// <summary> None. </summary>
        public static VirtualMachineDiskType None { get; } = new VirtualMachineDiskType(NoneValue);
        /// <summary> Unmanaged. </summary>
        public static VirtualMachineDiskType Unmanaged { get; } = new VirtualMachineDiskType(UnmanagedValue);
        /// <summary> Determines if two <see cref="VirtualMachineDiskType"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineDiskType left, VirtualMachineDiskType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineDiskType"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineDiskType left, VirtualMachineDiskType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VirtualMachineDiskType"/>. </summary>
        public static implicit operator VirtualMachineDiskType(string value) => new VirtualMachineDiskType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineDiskType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineDiskType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
