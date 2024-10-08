// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Type of orchestrator. It cannot be changed once the cluster is created. </summary>
    public readonly partial struct OrchestratorType : IEquatable<OrchestratorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OrchestratorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrchestratorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KubernetesValue = "Kubernetes";
        private const string NoneValue = "None";

        /// <summary> Kubernetes. </summary>
        public static OrchestratorType Kubernetes { get; } = new OrchestratorType(KubernetesValue);
        /// <summary> None. </summary>
        public static OrchestratorType None { get; } = new OrchestratorType(NoneValue);
        /// <summary> Determines if two <see cref="OrchestratorType"/> values are the same. </summary>
        public static bool operator ==(OrchestratorType left, OrchestratorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrchestratorType"/> values are not the same. </summary>
        public static bool operator !=(OrchestratorType left, OrchestratorType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OrchestratorType"/>. </summary>
        public static implicit operator OrchestratorType(string value) => new OrchestratorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrchestratorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrchestratorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
