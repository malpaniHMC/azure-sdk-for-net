// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The updatable properties of the GlobalRulestackResource. </summary>
    public partial class GlobalRulestackUpdateProperties
    {
        /// <summary> Initializes a new instance of GlobalRulestackUpdateProperties. </summary>
        public GlobalRulestackUpdateProperties()
        {
            AssociatedSubscriptions = new ChangeTrackingList<string>();
        }

        /// <summary> PanEtag info. </summary>
        public ETag? PanETag { get; set; }
        /// <summary> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </summary>
        public AzureLocation? PanLocation { get; set; }
        /// <summary> Rulestack Type. </summary>
        public RulestackScopeType? Scope { get; set; }
        /// <summary> subscription scope of global rulestack. </summary>
        public IList<string> AssociatedSubscriptions { get; }
        /// <summary> rulestack description. </summary>
        public string Description { get; set; }
        /// <summary> Mode for default rules creation. </summary>
        public RuleCreationDefaultMode? DefaultMode { get; set; }
        /// <summary> minimum version. </summary>
        public string MinAppIdVersion { get; set; }
        /// <summary> Security Profile. </summary>
        public RulestackSecurityServices SecurityServices { get; set; }
    }
}
