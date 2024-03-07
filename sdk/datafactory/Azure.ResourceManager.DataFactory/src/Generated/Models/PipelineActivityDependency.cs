// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Activity dependency information. </summary>
    public partial class PipelineActivityDependency
    {
        /// <summary> Initializes a new instance of <see cref="PipelineActivityDependency"/>. </summary>
        /// <param name="activity"> Activity name. </param>
        /// <param name="dependencyConditions"> Match-Condition for the dependency. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activity"/> or <paramref name="dependencyConditions"/> is null. </exception>
        public PipelineActivityDependency(string activity, IEnumerable<DependencyCondition> dependencyConditions)
        {
            Argument.AssertNotNull(activity, nameof(activity));
            Argument.AssertNotNull(dependencyConditions, nameof(dependencyConditions));

            Activity = activity;
            DependencyConditions = dependencyConditions.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="PipelineActivityDependency"/>. </summary>
        /// <param name="activity"> Activity name. </param>
        /// <param name="dependencyConditions"> Match-Condition for the dependency. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineActivityDependency(string activity, IList<DependencyCondition> dependencyConditions, IDictionary<string, BinaryData> additionalProperties)
        {
            Activity = activity;
            DependencyConditions = dependencyConditions;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineActivityDependency"/> for deserialization. </summary>
        internal PipelineActivityDependency()
        {
        }

        /// <summary> Activity name. </summary>
        public string Activity { get; set; }
        /// <summary> Match-Condition for the dependency. </summary>
        public IList<DependencyCondition> DependencyConditions { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
