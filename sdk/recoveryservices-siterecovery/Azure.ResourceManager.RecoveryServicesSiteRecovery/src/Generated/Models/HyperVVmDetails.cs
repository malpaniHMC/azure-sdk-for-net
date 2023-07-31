// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Single Host fabric provider specific VM settings.
    /// Please note <see cref="HyperVVmDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="VmmVmDetails"/>.
    /// </summary>
    public partial class HyperVVmDetails : SiteRecoveryReplicationProviderSettings
    {
        /// <summary> Initializes a new instance of HyperVVmDetails. </summary>
        internal HyperVVmDetails()
        {
            DiskDetails = new ChangeTrackingList<SiteRecoveryDiskDetails>();
            InstanceType = "HyperVVirtualMachine";
        }

        /// <summary> Initializes a new instance of HyperVVmDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="sourceItemId"> The source id of the object. </param>
        /// <param name="generation"> The id of the object in fabric. </param>
        /// <param name="osDetails"> The Last replication time. </param>
        /// <param name="diskDetails"> The Last successful failover time. </param>
        /// <param name="hasPhysicalDisk"> A value indicating whether the VM has a physical disk attached. String value of SrsDataContract.PresenceStatus enum. </param>
        /// <param name="hasFibreChannelAdapter"> A value indicating whether the VM has a fibre channel adapter attached. String value of SrsDataContract.PresenceStatus enum. </param>
        /// <param name="hasSharedVhd"> A value indicating whether the VM has a shared VHD attached. String value of SrsDataContract.PresenceStatus enum. </param>
        /// <param name="hyperVHostId"> The Id of the hyper-v host in fabric. </param>
        internal HyperVVmDetails(string instanceType, string sourceItemId, string generation, SiteRecoveryOSDetails osDetails, IReadOnlyList<SiteRecoveryDiskDetails> diskDetails, HyperVVmDiskPresenceStatus? hasPhysicalDisk, HyperVVmDiskPresenceStatus? hasFibreChannelAdapter, HyperVVmDiskPresenceStatus? hasSharedVhd, string hyperVHostId) : base(instanceType)
        {
            SourceItemId = sourceItemId;
            Generation = generation;
            OSDetails = osDetails;
            DiskDetails = diskDetails;
            HasPhysicalDisk = hasPhysicalDisk;
            HasFibreChannelAdapter = hasFibreChannelAdapter;
            HasSharedVhd = hasSharedVhd;
            HyperVHostId = hyperVHostId;
            InstanceType = instanceType ?? "HyperVVirtualMachine";
        }

        /// <summary> The source id of the object. </summary>
        public string SourceItemId { get; }
        /// <summary> The id of the object in fabric. </summary>
        public string Generation { get; }
        /// <summary> The Last replication time. </summary>
        public SiteRecoveryOSDetails OSDetails { get; }
        /// <summary> The Last successful failover time. </summary>
        public IReadOnlyList<SiteRecoveryDiskDetails> DiskDetails { get; }
        /// <summary> A value indicating whether the VM has a physical disk attached. String value of SrsDataContract.PresenceStatus enum. </summary>
        public HyperVVmDiskPresenceStatus? HasPhysicalDisk { get; }
        /// <summary> A value indicating whether the VM has a fibre channel adapter attached. String value of SrsDataContract.PresenceStatus enum. </summary>
        public HyperVVmDiskPresenceStatus? HasFibreChannelAdapter { get; }
        /// <summary> A value indicating whether the VM has a shared VHD attached. String value of SrsDataContract.PresenceStatus enum. </summary>
        public HyperVVmDiskPresenceStatus? HasSharedVhd { get; }
        /// <summary> The Id of the hyper-v host in fabric. </summary>
        public string HyperVHostId { get; }
    }
}
