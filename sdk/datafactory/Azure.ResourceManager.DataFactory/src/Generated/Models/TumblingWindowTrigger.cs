// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Trigger that schedules pipeline runs for all fixed time interval windows from a start time without gaps and also supports backfill scenarios (when start time is in the past). </summary>
    public partial class TumblingWindowTrigger : DataFactoryTriggerDefinition
    {
        /// <summary> Initializes a new instance of TumblingWindowTrigger. </summary>
        /// <param name="pipeline"> Pipeline for which runs are created when an event is fired for trigger window that is ready. </param>
        /// <param name="frequency"> The frequency of the time windows. </param>
        /// <param name="interval"> The interval of the time windows. The minimum interval allowed is 15 Minutes. </param>
        /// <param name="startOn"> The start time for the time period for the trigger during which events are fired for windows that are ready. Only UTC time is currently supported. </param>
        /// <param name="maxConcurrency"> The max number of parallel time windows (ready for execution) for which a new run is triggered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> is null. </exception>
        public TumblingWindowTrigger(TriggerPipelineReference pipeline, TumblingWindowFrequency frequency, int interval, DateTimeOffset startOn, int maxConcurrency)
        {
            Argument.AssertNotNull(pipeline, nameof(pipeline));

            Pipeline = pipeline;
            Frequency = frequency;
            Interval = interval;
            StartOn = startOn;
            MaxConcurrency = maxConcurrency;
            DependsOn = new ChangeTrackingList<DependencyReference>();
            TriggerType = "TumblingWindowTrigger";
        }

        /// <summary> Initializes a new instance of TumblingWindowTrigger. </summary>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="pipeline"> Pipeline for which runs are created when an event is fired for trigger window that is ready. </param>
        /// <param name="frequency"> The frequency of the time windows. </param>
        /// <param name="interval"> The interval of the time windows. The minimum interval allowed is 15 Minutes. </param>
        /// <param name="startOn"> The start time for the time period for the trigger during which events are fired for windows that are ready. Only UTC time is currently supported. </param>
        /// <param name="endOn"> The end time for the time period for the trigger during which events are fired for windows that are ready. Only UTC time is currently supported. </param>
        /// <param name="delay"> Specifies how long the trigger waits past due time before triggering new run. It doesn't alter window start and end time. The default is 0. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrency"> The max number of parallel time windows (ready for execution) for which a new run is triggered. </param>
        /// <param name="retryPolicy"> Retry policy that will be applied for failed pipeline runs. </param>
        /// <param name="dependsOn">
        /// Triggers that this trigger depends on. Only tumbling window triggers are supported.
        /// Please note <see cref="DependencyReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SelfDependencyTumblingWindowTriggerReference"/>, <see cref="TriggerDependencyReference"/> and <see cref="TumblingWindowTriggerDependencyReference"/>.
        /// </param>
        internal TumblingWindowTrigger(string triggerType, string description, DataFactoryTriggerRuntimeState? runtimeState, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, TriggerPipelineReference pipeline, TumblingWindowFrequency frequency, int interval, DateTimeOffset startOn, DateTimeOffset? endOn, DataFactoryElement<string> delay, int maxConcurrency, RetryPolicy retryPolicy, IList<DependencyReference> dependsOn) : base(triggerType, description, runtimeState, annotations, additionalProperties)
        {
            Pipeline = pipeline;
            Frequency = frequency;
            Interval = interval;
            StartOn = startOn;
            EndOn = endOn;
            Delay = delay;
            MaxConcurrency = maxConcurrency;
            RetryPolicy = retryPolicy;
            DependsOn = dependsOn;
            TriggerType = triggerType ?? "TumblingWindowTrigger";
        }

        /// <summary> Pipeline for which runs are created when an event is fired for trigger window that is ready. </summary>
        public TriggerPipelineReference Pipeline { get; set; }
        /// <summary> The frequency of the time windows. </summary>
        public TumblingWindowFrequency Frequency { get; set; }
        /// <summary> The interval of the time windows. The minimum interval allowed is 15 Minutes. </summary>
        public int Interval { get; set; }
        /// <summary> The start time for the time period for the trigger during which events are fired for windows that are ready. Only UTC time is currently supported. </summary>
        public DateTimeOffset StartOn { get; set; }
        /// <summary> The end time for the time period for the trigger during which events are fired for windows that are ready. Only UTC time is currently supported. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Specifies how long the trigger waits past due time before triggering new run. It doesn't alter window start and end time. The default is 0. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> Delay { get; set; }
        /// <summary> The max number of parallel time windows (ready for execution) for which a new run is triggered. </summary>
        public int MaxConcurrency { get; set; }
        /// <summary> Retry policy that will be applied for failed pipeline runs. </summary>
        public RetryPolicy RetryPolicy { get; set; }
        /// <summary>
        /// Triggers that this trigger depends on. Only tumbling window triggers are supported.
        /// Please note <see cref="DependencyReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SelfDependencyTumblingWindowTriggerReference"/>, <see cref="TriggerDependencyReference"/> and <see cref="TumblingWindowTriggerDependencyReference"/>.
        /// </summary>
        public IList<DependencyReference> DependsOn { get; }
    }
}
