// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the metric alert criteria for multiple resource that has multiple metric criteria. </summary>
    public partial class MetricAlertMultipleResourceMultipleMetricCriteria : MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of MetricAlertMultipleResourceMultipleMetricCriteria. </summary>
        public MetricAlertMultipleResourceMultipleMetricCriteria()
        {
            AllOf = new ChangeTrackingList<MultiMetricCriteria>();
            OdataType = MonitorOdataType.MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria;
        }

        /// <summary> Initializes a new instance of MetricAlertMultipleResourceMultipleMetricCriteria. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="allOf">
        /// the list of multiple metric criteria for this 'all of' operation.
        /// Please note <see cref="MultiMetricCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicMetricCriteria"/> and <see cref="MetricCriteria"/>.
        /// </param>
        internal MetricAlertMultipleResourceMultipleMetricCriteria(MonitorOdataType odataType, IDictionary<string, BinaryData> additionalProperties, IList<MultiMetricCriteria> allOf) : base(odataType, additionalProperties)
        {
            AllOf = allOf;
            OdataType = odataType;
        }

        /// <summary>
        /// the list of multiple metric criteria for this 'all of' operation.
        /// Please note <see cref="MultiMetricCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicMetricCriteria"/> and <see cref="MetricCriteria"/>.
        /// </summary>
        public IList<MultiMetricCriteria> AllOf { get; }
    }
}
