// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery. </summary>
    public readonly partial struct VaultSubResourceType : IEquatable<VaultSubResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VaultSubResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VaultSubResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureBackupValue = "AzureBackup";
        private const string AzureBackupSecondaryValue = "AzureBackup_secondary";
        private const string AzureSiteRecoveryValue = "AzureSiteRecovery";

        /// <summary> AzureBackup. </summary>
        public static VaultSubResourceType AzureBackup { get; } = new VaultSubResourceType(AzureBackupValue);
        /// <summary> AzureBackup_secondary. </summary>
        public static VaultSubResourceType AzureBackupSecondary { get; } = new VaultSubResourceType(AzureBackupSecondaryValue);
        /// <summary> AzureSiteRecovery. </summary>
        public static VaultSubResourceType AzureSiteRecovery { get; } = new VaultSubResourceType(AzureSiteRecoveryValue);
        /// <summary> Determines if two <see cref="VaultSubResourceType"/> values are the same. </summary>
        public static bool operator ==(VaultSubResourceType left, VaultSubResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VaultSubResourceType"/> values are not the same. </summary>
        public static bool operator !=(VaultSubResourceType left, VaultSubResourceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VaultSubResourceType"/>. </summary>
        public static implicit operator VaultSubResourceType(string value) => new VaultSubResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VaultSubResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VaultSubResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
