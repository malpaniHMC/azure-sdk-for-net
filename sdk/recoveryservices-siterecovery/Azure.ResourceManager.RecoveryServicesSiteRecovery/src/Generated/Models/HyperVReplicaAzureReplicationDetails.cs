// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper V Replica Azure provider specific settings. </summary>
    public partial class HyperVReplicaAzureReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzureReplicationDetails. </summary>
        internal HyperVReplicaAzureReplicationDetails()
        {
            AzureVmDiskDetails = new ChangeTrackingList<SiteRecoveryVmDiskDetails>();
            VmNics = new ChangeTrackingList<VmNicDetails>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            ProtectedManagedDisks = new ChangeTrackingList<HyperVReplicaAzureManagedDiskDetails>();
            AllAvailableOSUpgradeConfigurations = new ChangeTrackingList<OSUpgradeSupportedVersions>();
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> Initializes a new instance of HyperVReplicaAzureReplicationDetails. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="azureVmDiskDetails"> Azure VM Disk details. </param>
        /// <param name="recoveryAzureVmName"> Recovery Azure given name. </param>
        /// <param name="recoveryAzureVmSize"> The Recovery Azure VM size. </param>
        /// <param name="recoveryAzureStorageAccount"> The recovery Azure storage account. </param>
        /// <param name="recoveryAzureLogStorageAccountId"> The ARM id of the log storage account used for replication. This will be set to null if no log storage account was provided during enable protection. </param>
        /// <param name="lastReplicatedOn"> The Last replication time. </param>
        /// <param name="rpoInSeconds"> Last RPO value. </param>
        /// <param name="lastRpoCalculatedOn"> The last RPO calculated time. </param>
        /// <param name="vmId"> The virtual machine Id. </param>
        /// <param name="vmProtectionState"> The protection state for the vm. </param>
        /// <param name="vmProtectionStateDescription"> The protection state description for the vm. </param>
        /// <param name="initialReplicationDetails"> Initial replication details. </param>
        /// <param name="vmNics"> The PE Network details. </param>
        /// <param name="selectedRecoveryAzureNetworkId"> The selected recovery azure network Id. </param>
        /// <param name="selectedSourceNicId"> The selected source nic Id which will be used as the primary nic during failover. </param>
        /// <param name="encryption"> The encryption info. </param>
        /// <param name="osDetails"> The operating system info. </param>
        /// <param name="sourceVmRamSizeInMB"> The RAM size of the VM on the primary side. </param>
        /// <param name="sourceVmCpuCount"> The CPU count of the VM on the primary side. </param>
        /// <param name="enableRdpOnTargetOption"> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </param>
        /// <param name="recoveryAzureResourceGroupId"> The target resource group Id. </param>
        /// <param name="recoveryAvailabilitySetId"> The recovery availability set Id. </param>
        /// <param name="targetAvailabilityZone"> The target availability zone. </param>
        /// <param name="targetProximityPlacementGroupId"> The target proximity placement group Id. </param>
        /// <param name="useManagedDisks"> A value indicating whether managed disks should be used during failover. </param>
        /// <param name="licenseType"> License Type of the VM to be used. </param>
        /// <param name="sqlServerLicenseType"> The SQL Server license type. </param>
        /// <param name="lastRecoveryPointReceived"> The last recovery point received time. </param>
        /// <param name="targetVmTags"> The target VM tags. </param>
        /// <param name="seedManagedDiskTags"> The tags for the seed managed disks. </param>
        /// <param name="targetManagedDiskTags"> The tags for the target managed disks. </param>
        /// <param name="targetNicTags"> The tags for the target NICs. </param>
        /// <param name="protectedManagedDisks"> The list of protected managed disks. </param>
        /// <param name="allAvailableOSUpgradeConfigurations"> A value indicating all available inplace OS Upgrade configurations. </param>
        internal HyperVReplicaAzureReplicationDetails(string instanceType, IReadOnlyList<SiteRecoveryVmDiskDetails> azureVmDiskDetails, string recoveryAzureVmName, string recoveryAzureVmSize, string recoveryAzureStorageAccount, ResourceIdentifier recoveryAzureLogStorageAccountId, DateTimeOffset? lastReplicatedOn, long? rpoInSeconds, DateTimeOffset? lastRpoCalculatedOn, string vmId, string vmProtectionState, string vmProtectionStateDescription, InitialReplicationDetails initialReplicationDetails, IReadOnlyList<VmNicDetails> vmNics, ResourceIdentifier selectedRecoveryAzureNetworkId, string selectedSourceNicId, string encryption, SiteRecoveryOSDetails osDetails, int? sourceVmRamSizeInMB, int? sourceVmCpuCount, string enableRdpOnTargetOption, ResourceIdentifier recoveryAzureResourceGroupId, ResourceIdentifier recoveryAvailabilitySetId, string targetAvailabilityZone, ResourceIdentifier targetProximityPlacementGroupId, string useManagedDisks, string licenseType, string sqlServerLicenseType, DateTimeOffset? lastRecoveryPointReceived, IReadOnlyDictionary<string, string> targetVmTags, IReadOnlyDictionary<string, string> seedManagedDiskTags, IReadOnlyDictionary<string, string> targetManagedDiskTags, IReadOnlyDictionary<string, string> targetNicTags, IReadOnlyList<HyperVReplicaAzureManagedDiskDetails> protectedManagedDisks, IReadOnlyList<OSUpgradeSupportedVersions> allAvailableOSUpgradeConfigurations) : base(instanceType)
        {
            AzureVmDiskDetails = azureVmDiskDetails;
            RecoveryAzureVmName = recoveryAzureVmName;
            RecoveryAzureVmSize = recoveryAzureVmSize;
            RecoveryAzureStorageAccount = recoveryAzureStorageAccount;
            RecoveryAzureLogStorageAccountId = recoveryAzureLogStorageAccountId;
            LastReplicatedOn = lastReplicatedOn;
            RpoInSeconds = rpoInSeconds;
            LastRpoCalculatedOn = lastRpoCalculatedOn;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            InitialReplicationDetails = initialReplicationDetails;
            VmNics = vmNics;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedSourceNicId = selectedSourceNicId;
            Encryption = encryption;
            OSDetails = osDetails;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            SourceVmCpuCount = sourceVmCpuCount;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            UseManagedDisks = useManagedDisks;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            TargetVmTags = targetVmTags;
            SeedManagedDiskTags = seedManagedDiskTags;
            TargetManagedDiskTags = targetManagedDiskTags;
            TargetNicTags = targetNicTags;
            ProtectedManagedDisks = protectedManagedDisks;
            AllAvailableOSUpgradeConfigurations = allAvailableOSUpgradeConfigurations;
            InstanceType = instanceType ?? "HyperVReplicaAzure";
        }

        /// <summary> Azure VM Disk details. </summary>
        public IReadOnlyList<SiteRecoveryVmDiskDetails> AzureVmDiskDetails { get; }
        /// <summary> Recovery Azure given name. </summary>
        public string RecoveryAzureVmName { get; }
        /// <summary> The Recovery Azure VM size. </summary>
        public string RecoveryAzureVmSize { get; }
        /// <summary> The recovery Azure storage account. </summary>
        public string RecoveryAzureStorageAccount { get; }
        /// <summary> The ARM id of the log storage account used for replication. This will be set to null if no log storage account was provided during enable protection. </summary>
        public ResourceIdentifier RecoveryAzureLogStorageAccountId { get; }
        /// <summary> The Last replication time. </summary>
        public DateTimeOffset? LastReplicatedOn { get; }
        /// <summary> Last RPO value. </summary>
        public long? RpoInSeconds { get; }
        /// <summary> The last RPO calculated time. </summary>
        public DateTimeOffset? LastRpoCalculatedOn { get; }
        /// <summary> The virtual machine Id. </summary>
        public string VmId { get; }
        /// <summary> The protection state for the vm. </summary>
        public string VmProtectionState { get; }
        /// <summary> The protection state description for the vm. </summary>
        public string VmProtectionStateDescription { get; }
        /// <summary> Initial replication details. </summary>
        public InitialReplicationDetails InitialReplicationDetails { get; }
        /// <summary> The PE Network details. </summary>
        public IReadOnlyList<VmNicDetails> VmNics { get; }
        /// <summary> The selected recovery azure network Id. </summary>
        public ResourceIdentifier SelectedRecoveryAzureNetworkId { get; }
        /// <summary> The selected source nic Id which will be used as the primary nic during failover. </summary>
        public string SelectedSourceNicId { get; }
        /// <summary> The encryption info. </summary>
        public string Encryption { get; }
        /// <summary> The operating system info. </summary>
        public SiteRecoveryOSDetails OSDetails { get; }
        /// <summary> The RAM size of the VM on the primary side. </summary>
        public int? SourceVmRamSizeInMB { get; }
        /// <summary> The CPU count of the VM on the primary side. </summary>
        public int? SourceVmCpuCount { get; }
        /// <summary> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </summary>
        public string EnableRdpOnTargetOption { get; }
        /// <summary> The target resource group Id. </summary>
        public ResourceIdentifier RecoveryAzureResourceGroupId { get; }
        /// <summary> The recovery availability set Id. </summary>
        public ResourceIdentifier RecoveryAvailabilitySetId { get; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; }
        /// <summary> The target proximity placement group Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; }
        /// <summary> A value indicating whether managed disks should be used during failover. </summary>
        public string UseManagedDisks { get; }
        /// <summary> License Type of the VM to be used. </summary>
        public string LicenseType { get; }
        /// <summary> The SQL Server license type. </summary>
        public string SqlServerLicenseType { get; }
        /// <summary> The last recovery point received time. </summary>
        public DateTimeOffset? LastRecoveryPointReceived { get; }
        /// <summary> The target VM tags. </summary>
        public IReadOnlyDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the seed managed disks. </summary>
        public IReadOnlyDictionary<string, string> SeedManagedDiskTags { get; }
        /// <summary> The tags for the target managed disks. </summary>
        public IReadOnlyDictionary<string, string> TargetManagedDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IReadOnlyDictionary<string, string> TargetNicTags { get; }
        /// <summary> The list of protected managed disks. </summary>
        public IReadOnlyList<HyperVReplicaAzureManagedDiskDetails> ProtectedManagedDisks { get; }
        /// <summary> A value indicating all available inplace OS Upgrade configurations. </summary>
        public IReadOnlyList<OSUpgradeSupportedVersions> AllAvailableOSUpgradeConfigurations { get; }
    }
}
