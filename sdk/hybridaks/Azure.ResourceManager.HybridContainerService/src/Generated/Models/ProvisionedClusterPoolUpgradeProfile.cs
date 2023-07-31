// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The list of available upgrade versions. </summary>
    public partial class ProvisionedClusterPoolUpgradeProfile
    {
        /// <summary> Initializes a new instance of ProvisionedClusterPoolUpgradeProfile. </summary>
        public ProvisionedClusterPoolUpgradeProfile()
        {
            Upgrades = new ChangeTrackingList<ProvisionedClusterPoolUpgradeProfileProperties>();
        }

        /// <summary> Initializes a new instance of ProvisionedClusterPoolUpgradeProfile. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="name"> The Agent Pool name. </param>
        /// <param name="osType"> OsType - OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux. Possible values include: 'Linux', 'Windows'. </param>
        /// <param name="upgrades"> List of orchestrator types and versions available for upgrade. </param>
        internal ProvisionedClusterPoolUpgradeProfile(string kubernetesVersion, string name, OSType? osType, IList<ProvisionedClusterPoolUpgradeProfileProperties> upgrades)
        {
            KubernetesVersion = kubernetesVersion;
            Name = name;
            OSType = osType;
            Upgrades = upgrades;
        }

        /// <summary> The Kubernetes version (major.minor.patch). </summary>
        public string KubernetesVersion { get; }
        /// <summary> The Agent Pool name. </summary>
        public string Name { get; }
        /// <summary> OsType - OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux. Possible values include: 'Linux', 'Windows'. </summary>
        public OSType? OSType { get; }
        /// <summary> List of orchestrator types and versions available for upgrade. </summary>
        public IList<ProvisionedClusterPoolUpgradeProfileProperties> Upgrades { get; }
    }
}
