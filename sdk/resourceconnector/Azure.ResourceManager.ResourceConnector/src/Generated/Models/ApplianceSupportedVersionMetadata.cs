// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The SupportedVersionMetadata object for appliance. </summary>
    internal partial class ApplianceSupportedVersionMetadata
    {
        /// <summary> Initializes a new instance of ApplianceSupportedVersionMetadata. </summary>
        internal ApplianceSupportedVersionMetadata()
        {
        }

        /// <summary> Initializes a new instance of ApplianceSupportedVersionMetadata. </summary>
        /// <param name="catalogVersion"> The newer supported version catalog version. </param>
        internal ApplianceSupportedVersionMetadata(ApplianceSupportedVersionCatalogVersion catalogVersion)
        {
            CatalogVersion = catalogVersion;
        }

        /// <summary> The newer supported version catalog version. </summary>
        public ApplianceSupportedVersionCatalogVersion CatalogVersion { get; }
    }
}
