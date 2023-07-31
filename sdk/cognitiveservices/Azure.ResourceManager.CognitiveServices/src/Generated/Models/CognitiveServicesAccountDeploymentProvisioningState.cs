// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Gets the status of the resource at the time the operation was called. </summary>
    public readonly partial struct CognitiveServicesAccountDeploymentProvisioningState : IEquatable<CognitiveServicesAccountDeploymentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountDeploymentProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CognitiveServicesAccountDeploymentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string DisabledValue = "Disabled";
        private const string CanceledValue = "Canceled";

        /// <summary> Accepted. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Accepted { get; } = new CognitiveServicesAccountDeploymentProvisioningState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Creating { get; } = new CognitiveServicesAccountDeploymentProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Deleting { get; } = new CognitiveServicesAccountDeploymentProvisioningState(DeletingValue);
        /// <summary> Moving. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Moving { get; } = new CognitiveServicesAccountDeploymentProvisioningState(MovingValue);
        /// <summary> Failed. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Failed { get; } = new CognitiveServicesAccountDeploymentProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Succeeded { get; } = new CognitiveServicesAccountDeploymentProvisioningState(SucceededValue);
        /// <summary> Disabled. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Disabled { get; } = new CognitiveServicesAccountDeploymentProvisioningState(DisabledValue);
        /// <summary> Canceled. </summary>
        public static CognitiveServicesAccountDeploymentProvisioningState Canceled { get; } = new CognitiveServicesAccountDeploymentProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="CognitiveServicesAccountDeploymentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CognitiveServicesAccountDeploymentProvisioningState left, CognitiveServicesAccountDeploymentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CognitiveServicesAccountDeploymentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CognitiveServicesAccountDeploymentProvisioningState left, CognitiveServicesAccountDeploymentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CognitiveServicesAccountDeploymentProvisioningState"/>. </summary>
        public static implicit operator CognitiveServicesAccountDeploymentProvisioningState(string value) => new CognitiveServicesAccountDeploymentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CognitiveServicesAccountDeploymentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CognitiveServicesAccountDeploymentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
