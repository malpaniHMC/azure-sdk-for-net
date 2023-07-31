// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The domain JSON object required for domain creation or update. </summary>
    public partial class FrontDoorCustomDomainPatch
    {
        /// <summary> Initializes a new instance of FrontDoorCustomDomainPatch. </summary>
        public FrontDoorCustomDomainPatch()
        {
        }

        /// <summary> The name of the profile which holds the domain. </summary>
        public string ProfileName { get; }
        /// <summary> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </summary>
        public FrontDoorCustomDomainHttpsContent TlsSettings { get; set; }
        /// <summary> Resource reference to the Azure DNS zone. </summary>
        internal WritableSubResource DnsZone { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DnsZoneId
        {
            get => DnsZone is null ? default : DnsZone.Id;
            set
            {
                if (DnsZone is null)
                    DnsZone = new WritableSubResource();
                DnsZone.Id = value;
            }
        }

        /// <summary> Resource reference to the Azure resource where custom domain ownership was prevalidated. </summary>
        internal FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId PreValidatedCustomDomainResource { get; set; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier PreValidatedCustomDomainResourceId
        {
            get => PreValidatedCustomDomainResource is null ? default : PreValidatedCustomDomainResource.Id;
            set
            {
                if (PreValidatedCustomDomainResource is null)
                    PreValidatedCustomDomainResource = new FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId();
                PreValidatedCustomDomainResource.Id = value;
            }
        }
    }
}
