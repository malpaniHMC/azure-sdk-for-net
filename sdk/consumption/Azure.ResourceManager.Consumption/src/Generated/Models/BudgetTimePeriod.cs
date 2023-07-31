// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The start and end date for a budget. </summary>
    public partial class BudgetTimePeriod
    {
        /// <summary> Initializes a new instance of BudgetTimePeriod. </summary>
        /// <param name="startOn"> The start date for the budget. </param>
        public BudgetTimePeriod(DateTimeOffset startOn)
        {
            StartOn = startOn;
        }

        /// <summary> Initializes a new instance of BudgetTimePeriod. </summary>
        /// <param name="startOn"> The start date for the budget. </param>
        /// <param name="endOn"> The end date for the budget. If not provided, we default this to 10 years from the start date. </param>
        internal BudgetTimePeriod(DateTimeOffset startOn, DateTimeOffset? endOn)
        {
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> The start date for the budget. </summary>
        public DateTimeOffset StartOn { get; set; }
        /// <summary> The end date for the budget. If not provided, we default this to 10 years from the start date. </summary>
        public DateTimeOffset? EndOn { get; set; }
    }
}
