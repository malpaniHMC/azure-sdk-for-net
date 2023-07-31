// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> HDInsight streaming activity type. </summary>
    public partial class HDInsightStreamingActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightStreamingActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="mapper"> Mapper executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="reducer"> Reducer executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="input"> Input blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="output"> Output blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="filePaths"> Paths to streaming job files. Can be directories. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="mapper"/>, <paramref name="reducer"/>, <paramref name="input"/>, <paramref name="output"/> or <paramref name="filePaths"/> is null. </exception>
        public HDInsightStreamingActivity(string name, DataFactoryElement<string> mapper, DataFactoryElement<string> reducer, DataFactoryElement<string> input, DataFactoryElement<string> output, IEnumerable<BinaryData> filePaths) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(mapper, nameof(mapper));
            Argument.AssertNotNull(reducer, nameof(reducer));
            Argument.AssertNotNull(input, nameof(input));
            Argument.AssertNotNull(output, nameof(output));
            Argument.AssertNotNull(filePaths, nameof(filePaths));

            StorageLinkedServices = new ChangeTrackingList<DataFactoryLinkedServiceReference>();
            Arguments = new ChangeTrackingList<BinaryData>();
            Mapper = mapper;
            Reducer = reducer;
            Input = input;
            Output = output;
            FilePaths = filePaths.ToList();
            CommandEnvironment = new ChangeTrackingList<BinaryData>();
            Defines = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "HDInsightStreaming";
        }

        /// <summary> Initializes a new instance of HDInsightStreamingActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="mapper"> Mapper executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="reducer"> Reducer executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="input"> Input blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="output"> Output blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="filePaths"> Paths to streaming job files. Can be directories. </param>
        /// <param name="fileLinkedService"> Linked service reference where the files are located. </param>
        /// <param name="combiner"> Combiner executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="commandEnvironment"> Command line environment values. </param>
        /// <param name="defines"> Allows user to specify defines for streaming job request. </param>
        internal HDInsightStreamingActivity(string name, string activityType, string description, ActivityState? state, ActivityOnInactiveMarkA? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<DataFactoryLinkedServiceReference> storageLinkedServices, IList<BinaryData> arguments, HDInsightActivityDebugInfoOptionSetting? getDebugInfo, DataFactoryElement<string> mapper, DataFactoryElement<string> reducer, DataFactoryElement<string> input, DataFactoryElement<string> output, IList<BinaryData> filePaths, DataFactoryLinkedServiceReference fileLinkedService, DataFactoryElement<string> combiner, IList<BinaryData> commandEnvironment, IDictionary<string, BinaryData> defines) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            Mapper = mapper;
            Reducer = reducer;
            Input = input;
            Output = output;
            FilePaths = filePaths;
            FileLinkedService = fileLinkedService;
            Combiner = combiner;
            CommandEnvironment = commandEnvironment;
            Defines = defines;
            ActivityType = activityType ?? "HDInsightStreaming";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<DataFactoryLinkedServiceReference> StorageLinkedServices { get; }
        /// <summary>
        /// User specified arguments to HDInsightActivity.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IList<BinaryData> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOptionSetting? GetDebugInfo { get; set; }
        /// <summary> Mapper executable name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Mapper { get; set; }
        /// <summary> Reducer executable name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Reducer { get; set; }
        /// <summary> Input blob path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Input { get; set; }
        /// <summary> Output blob path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Output { get; set; }
        /// <summary>
        /// Paths to streaming job files. Can be directories.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IList<BinaryData> FilePaths { get; }
        /// <summary> Linked service reference where the files are located. </summary>
        public DataFactoryLinkedServiceReference FileLinkedService { get; set; }
        /// <summary> Combiner executable name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Combiner { get; set; }
        /// <summary>
        /// Command line environment values.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IList<BinaryData> CommandEnvironment { get; }
        /// <summary>
        /// Allows user to specify defines for streaming job request.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> Defines { get; }
    }
}
