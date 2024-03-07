// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Parameters required for content purge. </summary>
    public partial class FrontDoorEndpointPurgeContent
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

        /// <summary> Initializes a new instance of <see cref="FrontDoorEndpointPurgeContent"/>. </summary>
        /// <param name="contentPaths"> The path to the content to be purged. Can describe a file path or a wild card directory. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentPaths"/> is null. </exception>
        public FrontDoorEndpointPurgeContent(IEnumerable<string> contentPaths)
        {
            Argument.AssertNotNull(contentPaths, nameof(contentPaths));

            ContentPaths = contentPaths.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorEndpointPurgeContent"/>. </summary>
        /// <param name="contentPaths"> The path to the content to be purged. Can describe a file path or a wild card directory. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorEndpointPurgeContent(IList<string> contentPaths, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentPaths = contentPaths;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorEndpointPurgeContent"/> for deserialization. </summary>
        internal FrontDoorEndpointPurgeContent()
        {
        }

        /// <summary> The path to the content to be purged. Can describe a file path or a wild card directory. </summary>
        public IList<string> ContentPaths { get; }
    }
}
