// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure VM workload-specific protectable item representing SQL Availability Group. </summary>
    public partial class VmWorkloadSqlAvailabilityGroupProtectableItem : VmWorkloadProtectableItem
    {
        /// <summary> Initializes a new instance of VmWorkloadSqlAvailabilityGroupProtectableItem. </summary>
        public VmWorkloadSqlAvailabilityGroupProtectableItem()
        {
            ProtectableItemType = "SQLAvailabilityGroupContainer";
        }

        /// <summary> Initializes a new instance of VmWorkloadSqlAvailabilityGroupProtectableItem. </summary>
        /// <param name="backupManagementType"> Type of backup management to backup an item. </param>
        /// <param name="workloadType"> Type of workload for the backup management. </param>
        /// <param name="protectableItemType"> Type of the backup item. </param>
        /// <param name="friendlyName"> Friendly name of the backup item. </param>
        /// <param name="protectionState"> State of the back up item. </param>
        /// <param name="parentName"> Name for instance or AG. </param>
        /// <param name="parentUniqueName">
        /// Parent Unique Name is added to provide the service formatted URI Name of the Parent
        /// Only Applicable for data bases where the parent would be either Instance or a SQL AG.
        /// </param>
        /// <param name="serverName"> Host/Cluster Name for instance or AG. </param>
        /// <param name="isAutoProtectable"> Indicates if protectable item is auto-protectable. </param>
        /// <param name="isAutoProtected"> Indicates if protectable item is auto-protected. </param>
        /// <param name="subInquiredItemCount"> For instance or AG, indicates number of DB's present. </param>
        /// <param name="subProtectableItemCount"> For instance or AG, indicates number of DB's to be protected. </param>
        /// <param name="preBackupValidation"> Pre-backup validation for protectable objects. </param>
        internal VmWorkloadSqlAvailabilityGroupProtectableItem(string backupManagementType, string workloadType, string protectableItemType, string friendlyName, BackupProtectionStatus? protectionState, string parentName, string parentUniqueName, string serverName, bool? isAutoProtectable, bool? isAutoProtected, int? subInquiredItemCount, int? subProtectableItemCount, PreBackupValidation preBackupValidation) : base(backupManagementType, workloadType, protectableItemType, friendlyName, protectionState, parentName, parentUniqueName, serverName, isAutoProtectable, isAutoProtected, subInquiredItemCount, subProtectableItemCount, preBackupValidation)
        {
            ProtectableItemType = protectableItemType ?? "SQLAvailabilityGroupContainer";
        }
    }
}
