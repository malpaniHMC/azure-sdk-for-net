// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the activity output type. </summary>
    public partial class ActivityOutputType
    {
        /// <summary> Initializes a new instance of ActivityOutputType. </summary>
        internal ActivityOutputType()
        {
        }

        /// <summary> Initializes a new instance of ActivityOutputType. </summary>
        /// <param name="name"> Gets or sets the name of the activity output type. </param>
        /// <param name="activityOutputTypeValue"> Gets or sets the type of the activity output type. </param>
        internal ActivityOutputType(string name, string activityOutputTypeValue)
        {
            Name = name;
            ActivityOutputTypeValue = activityOutputTypeValue;
        }

        /// <summary> Gets or sets the name of the activity output type. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the type of the activity output type. </summary>
        public string ActivityOutputTypeValue { get; }
    }
}
