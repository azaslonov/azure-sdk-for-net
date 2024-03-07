// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a MongoDB shard key. </summary>
    public partial class MongoDBShardKeySetting
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

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeySetting"/>. </summary>
        /// <param name="fields"> The fields within the shard key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fields"/> is null. </exception>
        public MongoDBShardKeySetting(IEnumerable<MongoDBShardKeyField> fields)
        {
            Argument.AssertNotNull(fields, nameof(fields));

            Fields = fields.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeySetting"/>. </summary>
        /// <param name="fields"> The fields within the shard key. </param>
        /// <param name="isUnique"> Whether the shard key is unique. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBShardKeySetting(IList<MongoDBShardKeyField> fields, bool? isUnique, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Fields = fields;
            IsUnique = isUnique;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeySetting"/> for deserialization. </summary>
        internal MongoDBShardKeySetting()
        {
        }

        /// <summary> The fields within the shard key. </summary>
        public IList<MongoDBShardKeyField> Fields { get; }
        /// <summary> Whether the shard key is unique. </summary>
        public bool? IsUnique { get; set; }
    }
}
