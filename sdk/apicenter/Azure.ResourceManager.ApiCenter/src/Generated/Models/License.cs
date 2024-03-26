// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiCenter.Models
{
    /// <summary> The license information for the API. </summary>
    public partial class License
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

        /// <summary> Initializes a new instance of <see cref="License"/>. </summary>
        public License()
        {
        }

        /// <summary> Initializes a new instance of <see cref="License"/>. </summary>
        /// <param name="name"> Name of the license. </param>
        /// <param name="uri">
        /// URL pointing to the license details. The URL field is mutually exclusive of the
        /// identifier field.
        /// </param>
        /// <param name="identifier">
        /// SPDX license information for the API. The identifier field is mutually
        /// exclusive of the URL field.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal License(string name, Uri uri, Uri identifier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Uri = uri;
            Identifier = identifier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the license. </summary>
        public string Name { get; set; }
        /// <summary>
        /// URL pointing to the license details. The URL field is mutually exclusive of the
        /// identifier field.
        /// </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// SPDX license information for the API. The identifier field is mutually
        /// exclusive of the URL field.
        /// </summary>
        public Uri Identifier { get; set; }
    }
}
