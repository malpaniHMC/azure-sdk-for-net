// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Gets or sets the workflow state. </summary>
    public readonly partial struct DataReplicationWorkflowState : IEquatable<DataReplicationWorkflowState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataReplicationWorkflowState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataReplicationWorkflowState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string StartedValue = "Started";
        private const string CancellingValue = "Cancelling";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string CompletedWithInformationValue = "CompletedWithInformation";
        private const string CompletedWithWarningsValue = "CompletedWithWarnings";
        private const string CompletedWithErrorsValue = "CompletedWithErrors";

        /// <summary> Pending. </summary>
        public static DataReplicationWorkflowState Pending { get; } = new DataReplicationWorkflowState(PendingValue);
        /// <summary> Started. </summary>
        public static DataReplicationWorkflowState Started { get; } = new DataReplicationWorkflowState(StartedValue);
        /// <summary> Cancelling. </summary>
        public static DataReplicationWorkflowState Cancelling { get; } = new DataReplicationWorkflowState(CancellingValue);
        /// <summary> Succeeded. </summary>
        public static DataReplicationWorkflowState Succeeded { get; } = new DataReplicationWorkflowState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DataReplicationWorkflowState Failed { get; } = new DataReplicationWorkflowState(FailedValue);
        /// <summary> Cancelled. </summary>
        public static DataReplicationWorkflowState Cancelled { get; } = new DataReplicationWorkflowState(CancelledValue);
        /// <summary> CompletedWithInformation. </summary>
        public static DataReplicationWorkflowState CompletedWithInformation { get; } = new DataReplicationWorkflowState(CompletedWithInformationValue);
        /// <summary> CompletedWithWarnings. </summary>
        public static DataReplicationWorkflowState CompletedWithWarnings { get; } = new DataReplicationWorkflowState(CompletedWithWarningsValue);
        /// <summary> CompletedWithErrors. </summary>
        public static DataReplicationWorkflowState CompletedWithErrors { get; } = new DataReplicationWorkflowState(CompletedWithErrorsValue);
        /// <summary> Determines if two <see cref="DataReplicationWorkflowState"/> values are the same. </summary>
        public static bool operator ==(DataReplicationWorkflowState left, DataReplicationWorkflowState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataReplicationWorkflowState"/> values are not the same. </summary>
        public static bool operator !=(DataReplicationWorkflowState left, DataReplicationWorkflowState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataReplicationWorkflowState"/>. </summary>
        public static implicit operator DataReplicationWorkflowState(string value) => new DataReplicationWorkflowState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataReplicationWorkflowState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataReplicationWorkflowState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
