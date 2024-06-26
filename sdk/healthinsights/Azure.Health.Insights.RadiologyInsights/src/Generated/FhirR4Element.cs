// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// The base definition for all elements contained inside a resource.
    /// Based on [FHIR Element](https://www.hl7.org/fhir/R4/element.html)
    /// </summary>
    public partial class FhirR4Element
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FhirR4Element"/>. </summary>
        internal FhirR4Element()
        {
            Extension = new ChangeTrackingList<FhirR4Extension>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Element"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FhirR4Element(string id, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Extension = extension;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique id for inter-element referencing. </summary>
        public string Id { get; }
        /// <summary> Additional Content defined by implementations. </summary>
        public IReadOnlyList<FhirR4Extension> Extension { get; }
    }
}
