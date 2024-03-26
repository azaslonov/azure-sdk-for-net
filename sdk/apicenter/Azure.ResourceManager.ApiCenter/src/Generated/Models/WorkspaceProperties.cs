// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApiCenter;

namespace Azure.ResourceManager.ApiCenter.Models
{
    /// <summary> Workspace properties. </summary>
    public partial class WorkspaceProperties
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

        /// <summary> Initializes a new instance of <see cref="WorkspaceProperties"/>. </summary>
        /// <param name="title"> Workspace title. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="title"/> is null. </exception>
        public WorkspaceProperties(string title)
        {
            Argument.AssertNotNull(title, nameof(title));

            Title = title;
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceProperties"/>. </summary>
        /// <param name="title"> Workspace title. </param>
        /// <param name="description"> Workspace description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceProperties(string title, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Title = title;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceProperties"/> for deserialization. </summary>
        internal WorkspaceProperties()
        {
        }

        /// <summary> Workspace title. </summary>
        public string Title { get; set; }
        /// <summary> Workspace description. </summary>
        public string Description { get; set; }
    }
}
