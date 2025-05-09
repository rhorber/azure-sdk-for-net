// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Current resource status. </summary>
    public readonly partial struct RedisEnterpriseClusterResourceState : IEquatable<RedisEnterpriseClusterResourceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseClusterResourceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisEnterpriseClusterResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string CreatingValue = "Creating";
        private const string CreateFailedValue = "CreateFailed";
        private const string UpdatingValue = "Updating";
        private const string UpdateFailedValue = "UpdateFailed";
        private const string DeletingValue = "Deleting";
        private const string DeleteFailedValue = "DeleteFailed";
        private const string EnablingValue = "Enabling";
        private const string EnableFailedValue = "EnableFailed";
        private const string DisablingValue = "Disabling";
        private const string DisableFailedValue = "DisableFailed";
        private const string DisabledValue = "Disabled";
        private const string ScalingValue = "Scaling";
        private const string ScalingFailedValue = "ScalingFailed";
        private const string MovingValue = "Moving";

        /// <summary> Running. </summary>
        public static RedisEnterpriseClusterResourceState Running { get; } = new RedisEnterpriseClusterResourceState(RunningValue);
        /// <summary> Creating. </summary>
        public static RedisEnterpriseClusterResourceState Creating { get; } = new RedisEnterpriseClusterResourceState(CreatingValue);
        /// <summary> CreateFailed. </summary>
        public static RedisEnterpriseClusterResourceState CreateFailed { get; } = new RedisEnterpriseClusterResourceState(CreateFailedValue);
        /// <summary> Updating. </summary>
        public static RedisEnterpriseClusterResourceState Updating { get; } = new RedisEnterpriseClusterResourceState(UpdatingValue);
        /// <summary> UpdateFailed. </summary>
        public static RedisEnterpriseClusterResourceState UpdateFailed { get; } = new RedisEnterpriseClusterResourceState(UpdateFailedValue);
        /// <summary> Deleting. </summary>
        public static RedisEnterpriseClusterResourceState Deleting { get; } = new RedisEnterpriseClusterResourceState(DeletingValue);
        /// <summary> DeleteFailed. </summary>
        public static RedisEnterpriseClusterResourceState DeleteFailed { get; } = new RedisEnterpriseClusterResourceState(DeleteFailedValue);
        /// <summary> Enabling. </summary>
        public static RedisEnterpriseClusterResourceState Enabling { get; } = new RedisEnterpriseClusterResourceState(EnablingValue);
        /// <summary> EnableFailed. </summary>
        public static RedisEnterpriseClusterResourceState EnableFailed { get; } = new RedisEnterpriseClusterResourceState(EnableFailedValue);
        /// <summary> Disabling. </summary>
        public static RedisEnterpriseClusterResourceState Disabling { get; } = new RedisEnterpriseClusterResourceState(DisablingValue);
        /// <summary> DisableFailed. </summary>
        public static RedisEnterpriseClusterResourceState DisableFailed { get; } = new RedisEnterpriseClusterResourceState(DisableFailedValue);
        /// <summary> Disabled. </summary>
        public static RedisEnterpriseClusterResourceState Disabled { get; } = new RedisEnterpriseClusterResourceState(DisabledValue);
        /// <summary> Scaling. </summary>
        public static RedisEnterpriseClusterResourceState Scaling { get; } = new RedisEnterpriseClusterResourceState(ScalingValue);
        /// <summary> ScalingFailed. </summary>
        public static RedisEnterpriseClusterResourceState ScalingFailed { get; } = new RedisEnterpriseClusterResourceState(ScalingFailedValue);
        /// <summary> Moving. </summary>
        public static RedisEnterpriseClusterResourceState Moving { get; } = new RedisEnterpriseClusterResourceState(MovingValue);
        /// <summary> Determines if two <see cref="RedisEnterpriseClusterResourceState"/> values are the same. </summary>
        public static bool operator ==(RedisEnterpriseClusterResourceState left, RedisEnterpriseClusterResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisEnterpriseClusterResourceState"/> values are not the same. </summary>
        public static bool operator !=(RedisEnterpriseClusterResourceState left, RedisEnterpriseClusterResourceState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RedisEnterpriseClusterResourceState"/>. </summary>
        public static implicit operator RedisEnterpriseClusterResourceState(string value) => new RedisEnterpriseClusterResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisEnterpriseClusterResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisEnterpriseClusterResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
