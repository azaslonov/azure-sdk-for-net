// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> An object describing the location and semantic content of a document. </summary>
    public partial class AnalyzedDocument
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

        /// <summary> Initializes a new instance of <see cref="AnalyzedDocument"/>. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="spans"> Location of the document in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="docType"/> or <paramref name="spans"/> is null. </exception>
        internal AnalyzedDocument(string docType, IEnumerable<DocumentSpan> spans, float confidence)
        {
            Argument.AssertNotNull(docType, nameof(docType));
            Argument.AssertNotNull(spans, nameof(spans));

            DocType = docType;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Fields = new ChangeTrackingDictionary<string, DocumentField>();
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzedDocument"/>. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="boundingRegions"> Bounding regions covering the document. </param>
        /// <param name="spans"> Location of the document in the reading order concatenated content. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        /// <param name="confidence"> Confidence of correctly extracting the document. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzedDocument(string docType, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IReadOnlyDictionary<string, DocumentField> fields, float confidence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DocType = docType;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Fields = fields;
            Confidence = confidence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzedDocument"/> for deserialization. </summary>
        internal AnalyzedDocument()
        {
        }

        /// <summary> Document type. </summary>
        public string DocType { get; }
        /// <summary> Bounding regions covering the document. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the document in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Dictionary of named field values. </summary>
        public IReadOnlyDictionary<string, DocumentField> Fields { get; }
        /// <summary> Confidence of correctly extracting the document. </summary>
        public float Confidence { get; }
    }
}
