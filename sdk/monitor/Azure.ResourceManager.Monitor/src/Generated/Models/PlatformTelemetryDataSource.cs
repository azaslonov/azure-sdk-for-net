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
    /// <summary> Definition of platform telemetry data source configuration. </summary>
    public partial class PlatformTelemetryDataSource
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

        /// <summary> Initializes a new instance of <see cref="PlatformTelemetryDataSource"/>. </summary>
        /// <param name="streams"> List of platform telemetry streams to collect. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streams"/> is null. </exception>
        public PlatformTelemetryDataSource(IEnumerable<string> streams)
        {
            Argument.AssertNotNull(streams, nameof(streams));

            Streams = streams.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PlatformTelemetryDataSource"/>. </summary>
        /// <param name="streams"> List of platform telemetry streams to collect. </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PlatformTelemetryDataSource(IList<string> streams, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Streams = streams;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PlatformTelemetryDataSource"/> for deserialization. </summary>
        internal PlatformTelemetryDataSource()
        {
        }

        /// <summary> List of platform telemetry streams to collect. </summary>
        public IList<string> Streams { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
