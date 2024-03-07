// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies a metric dimension. </summary>
    public partial class MetricDimension
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MetricDimension"/>. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="operator"> the dimension operator. Only 'Include' and 'Exclude' are supported. </param>
        /// <param name="values"> list of dimension values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="operator"/> or <paramref name="values"/> is null. </exception>
        public MetricDimension(string name, string @operator, IEnumerable<string> values)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(@operator, nameof(@operator));
            Argument.AssertNotNull(values, nameof(values));

            Name = name;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MetricDimension"/>. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="operator"> the dimension operator. Only 'Include' and 'Exclude' are supported. </param>
        /// <param name="values"> list of dimension values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricDimension(string name, string @operator, IList<string> values, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Operator = @operator;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MetricDimension"/> for deserialization. </summary>
        internal MetricDimension()
        {
        }

        /// <summary> Name of the dimension. </summary>
        public string Name { get; set; }
        /// <summary> the dimension operator. Only 'Include' and 'Exclude' are supported. </summary>
        public string Operator { get; set; }
        /// <summary> list of dimension values. </summary>
        public IList<string> Values { get; }
    }
}
