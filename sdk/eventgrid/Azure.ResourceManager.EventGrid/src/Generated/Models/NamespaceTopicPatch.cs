// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the namespace topic update. </summary>
    public partial class NamespaceTopicPatch
    {
        /// <summary> Initializes a new instance of NamespaceTopicPatch. </summary>
        public NamespaceTopicPatch()
        {
        }

        /// <summary>
        /// Event retention for the namespace topic expressed in days. The property default value is 1 day.
        /// Min event retention duration value is 1 day and max event retention duration value is 1 day.
        /// </summary>
        public int? EventRetentionInDays { get; set; }
    }
}
