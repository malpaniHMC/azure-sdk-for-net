// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Hourly Schedule properties. </summary>
    public partial class SnapshotPolicyHourlySchedule
    {
        /// <summary> Initializes a new instance of SnapshotPolicyHourlySchedule. </summary>
        public SnapshotPolicyHourlySchedule()
        {
        }

        /// <summary> Initializes a new instance of SnapshotPolicyHourlySchedule. </summary>
        /// <param name="snapshotsToKeep"> Hourly snapshot count to keep. </param>
        /// <param name="minute"> Indicates which minute snapshot should be taken. </param>
        /// <param name="usedBytes"> Resource size in bytes, current storage usage for the volume in bytes. </param>
        internal SnapshotPolicyHourlySchedule(int? snapshotsToKeep, int? minute, long? usedBytes)
        {
            SnapshotsToKeep = snapshotsToKeep;
            Minute = minute;
            UsedBytes = usedBytes;
        }

        /// <summary> Hourly snapshot count to keep. </summary>
        public int? SnapshotsToKeep { get; set; }
        /// <summary> Indicates which minute snapshot should be taken. </summary>
        public int? Minute { get; set; }
        /// <summary> Resource size in bytes, current storage usage for the volume in bytes. </summary>
        public long? UsedBytes { get; set; }
    }
}
