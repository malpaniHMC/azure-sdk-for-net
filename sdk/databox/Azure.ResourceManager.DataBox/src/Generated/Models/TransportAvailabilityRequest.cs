// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the transport availability for given sku. </summary>
    internal partial class TransportAvailabilityRequest
    {
        /// <summary> Initializes a new instance of TransportAvailabilityRequest. </summary>
        public TransportAvailabilityRequest()
        {
        }

        /// <summary> Type of the device. </summary>
        public DataBoxSkuName? SkuName { get; set; }
    }
}
