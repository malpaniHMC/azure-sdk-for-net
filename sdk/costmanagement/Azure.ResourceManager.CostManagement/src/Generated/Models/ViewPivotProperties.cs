// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Each pivot must contain a 'type' and 'name'. </summary>
    public partial class ViewPivotProperties
    {
        /// <summary> Initializes a new instance of ViewPivotProperties. </summary>
        public ViewPivotProperties()
        {
        }

        /// <summary> Initializes a new instance of ViewPivotProperties. </summary>
        /// <param name="pivotType"> Data type to show in view. </param>
        /// <param name="name"> Data field to show in view. </param>
        internal ViewPivotProperties(ViewPivotType? pivotType, string name)
        {
            PivotType = pivotType;
            Name = name;
        }

        /// <summary> Data type to show in view. </summary>
        public ViewPivotType? PivotType { get; set; }
        /// <summary> Data field to show in view. </summary>
        public string Name { get; set; }
    }
}
