// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing the ContainerServiceFleet data model.
    /// The Fleet resource.
    /// </summary>
    public partial class ContainerServiceFleetData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ContainerServiceFleetData. </summary>
        /// <param name="location"> The location. </param>
        public ContainerServiceFleetData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ContainerServiceFleetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"> Managed identity. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="hubProfile"> The FleetHubProfile configures the Fleet's hub. </param>
        internal ContainerServiceFleetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? eTag, ManagedServiceIdentity identity, FleetProvisioningState? provisioningState, FleetHubProfile hubProfile) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = eTag;
            Identity = identity;
            ProvisioningState = provisioningState;
            HubProfile = hubProfile;
        }

        /// <summary> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </summary>
        public ETag? ETag { get; }
        /// <summary> Managed identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The status of the last operation. </summary>
        public FleetProvisioningState? ProvisioningState { get; }
        /// <summary> The FleetHubProfile configures the Fleet's hub. </summary>
        public FleetHubProfile HubProfile { get; set; }
    }
}
