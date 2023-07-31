// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Observed deployment state of the Arc Agents on the target cluster. Possible values include: 'pending', 'provisioning', 'provisioned', 'deleting', 'failed', 'upgrading'. </summary>
    public readonly partial struct DeploymentState : IEquatable<DeploymentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "pending";
        private const string ProvisioningValue = "provisioning";
        private const string ProvisionedValue = "provisioned";
        private const string DeletingValue = "deleting";
        private const string FailedValue = "failed";
        private const string UpgradingValue = "upgrading";

        /// <summary> pending. </summary>
        public static DeploymentState Pending { get; } = new DeploymentState(PendingValue);
        /// <summary> provisioning. </summary>
        public static DeploymentState Provisioning { get; } = new DeploymentState(ProvisioningValue);
        /// <summary> provisioned. </summary>
        public static DeploymentState Provisioned { get; } = new DeploymentState(ProvisionedValue);
        /// <summary> deleting. </summary>
        public static DeploymentState Deleting { get; } = new DeploymentState(DeletingValue);
        /// <summary> failed. </summary>
        public static DeploymentState Failed { get; } = new DeploymentState(FailedValue);
        /// <summary> upgrading. </summary>
        public static DeploymentState Upgrading { get; } = new DeploymentState(UpgradingValue);
        /// <summary> Determines if two <see cref="DeploymentState"/> values are the same. </summary>
        public static bool operator ==(DeploymentState left, DeploymentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentState"/> values are not the same. </summary>
        public static bool operator !=(DeploymentState left, DeploymentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentState"/>. </summary>
        public static implicit operator DeploymentState(string value) => new DeploymentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
