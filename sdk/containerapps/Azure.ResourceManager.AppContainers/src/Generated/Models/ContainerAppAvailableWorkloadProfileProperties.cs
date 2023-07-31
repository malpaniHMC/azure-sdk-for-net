// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Revision resource specific properties. </summary>
    public partial class ContainerAppAvailableWorkloadProfileProperties
    {
        /// <summary> Initializes a new instance of ContainerAppAvailableWorkloadProfileProperties. </summary>
        public ContainerAppAvailableWorkloadProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppAvailableWorkloadProfileProperties. </summary>
        /// <param name="category"> Used to categorize workload profiles. </param>
        /// <param name="applicability"> indicates whether the profile is default for the location. </param>
        /// <param name="cores"> Number of cores in CPU. </param>
        /// <param name="memoryInGiB"> Memory in GiB. </param>
        /// <param name="displayName"> The everyday name of the workload profile. </param>
        internal ContainerAppAvailableWorkloadProfileProperties(string category, ContainerAppAvailableWorkloadProfileApplicability? applicability, int? cores, int? memoryInGiB, string displayName)
        {
            Category = category;
            Applicability = applicability;
            Cores = cores;
            MemoryInGiB = memoryInGiB;
            DisplayName = displayName;
        }

        /// <summary> Used to categorize workload profiles. </summary>
        public string Category { get; set; }
        /// <summary> indicates whether the profile is default for the location. </summary>
        public ContainerAppAvailableWorkloadProfileApplicability? Applicability { get; set; }
        /// <summary> Number of cores in CPU. </summary>
        public int? Cores { get; set; }
        /// <summary> Memory in GiB. </summary>
        public int? MemoryInGiB { get; set; }
        /// <summary> The everyday name of the workload profile. </summary>
        public string DisplayName { get; set; }
    }
}
