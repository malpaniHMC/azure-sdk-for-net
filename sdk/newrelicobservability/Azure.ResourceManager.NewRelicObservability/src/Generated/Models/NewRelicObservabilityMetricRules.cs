// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
    public partial class NewRelicObservabilityMetricRules
    {
        /// <summary> Initializes a new instance of NewRelicObservabilityMetricRules. </summary>
        public NewRelicObservabilityMetricRules()
        {
            FilteringTags = new ChangeTrackingList<NewRelicObservabilityFilteringTag>();
        }

        /// <summary> Initializes a new instance of NewRelicObservabilityMetricRules. </summary>
        /// <param name="sendMetrics"> Flag specifying if metrics should be sent for the Monitor resource. </param>
        /// <param name="filteringTags"> List of filtering tags to be used for capturing metrics. </param>
        /// <param name="userEmail"> User Email. </param>
        internal NewRelicObservabilityMetricRules(NewRelicObservabilitySendMetricsStatus? sendMetrics, IList<NewRelicObservabilityFilteringTag> filteringTags, string userEmail)
        {
            SendMetrics = sendMetrics;
            FilteringTags = filteringTags;
            UserEmail = userEmail;
        }

        /// <summary> Flag specifying if metrics should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendMetricsStatus? SendMetrics { get; set; }
        /// <summary> List of filtering tags to be used for capturing metrics. </summary>
        public IList<NewRelicObservabilityFilteringTag> FilteringTags { get; }
        /// <summary> User Email. </summary>
        public string UserEmail { get; set; }
    }
}
