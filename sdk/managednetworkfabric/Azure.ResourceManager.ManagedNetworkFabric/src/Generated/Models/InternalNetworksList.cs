// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of Internal Networks. </summary>
    internal partial class InternalNetworksList
    {
        /// <summary> Initializes a new instance of InternalNetworksList. </summary>
        internal InternalNetworksList()
        {
            Value = new ChangeTrackingList<NetworkFabricInternalNetworkData>();
        }

        /// <summary> Initializes a new instance of InternalNetworksList. </summary>
        /// <param name="value"> List of Internal Network resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal InternalNetworksList(IReadOnlyList<NetworkFabricInternalNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Internal Network resources. </summary>
        public IReadOnlyList<NetworkFabricInternalNetworkData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
