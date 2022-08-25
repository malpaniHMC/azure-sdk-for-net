// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The bulk collections response. The response contains two lists that indicate for each collection whether the operation succeeded or failed. </summary>
    public partial class BulkCollectionsResponse
    {
        /// <summary> Initializes a new instance of BulkCollectionsResponse. </summary>
        internal BulkCollectionsResponse()
        {
            Succeeded = new ChangeTrackingList<CollectionsDetails>();
            Failed = new ChangeTrackingList<CollectionsDetails>();
        }

        /// <summary> Initializes a new instance of BulkCollectionsResponse. </summary>
        /// <param name="succeeded"> Succeeded collections. </param>
        /// <param name="failed"> Failed collections. </param>
        internal BulkCollectionsResponse(IReadOnlyList<CollectionsDetails> succeeded, IReadOnlyList<CollectionsDetails> failed)
        {
            Succeeded = succeeded;
            Failed = failed;
        }

        /// <summary> Succeeded collections. </summary>
        public IReadOnlyList<CollectionsDetails> Succeeded { get; }
        /// <summary> Failed collections. </summary>
        public IReadOnlyList<CollectionsDetails> Failed { get; }
    }
}
