// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A ShareSubscriptionSynchronization data transfer object. </summary>
    public partial class ShareSubscriptionSynchronization
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

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionSynchronization"/>. </summary>
        /// <param name="synchronizationId"> Synchronization id. </param>
        public ShareSubscriptionSynchronization(Guid synchronizationId)
        {
            SynchronizationId = synchronizationId;
        }

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionSynchronization"/>. </summary>
        /// <param name="durationInMilliSeconds"> Synchronization duration. </param>
        /// <param name="endOn"> End time of synchronization. </param>
        /// <param name="message"> message of Synchronization. </param>
        /// <param name="startOn"> start time of synchronization. </param>
        /// <param name="status"> Raw Status. </param>
        /// <param name="synchronizationId"> Synchronization id. </param>
        /// <param name="synchronizationMode"> Synchronization Mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareSubscriptionSynchronization(int? durationInMilliSeconds, DateTimeOffset? endOn, string message, DateTimeOffset? startOn, string status, Guid synchronizationId, SynchronizationMode? synchronizationMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DurationInMilliSeconds = durationInMilliSeconds;
            EndOn = endOn;
            Message = message;
            StartOn = startOn;
            Status = status;
            SynchronizationId = synchronizationId;
            SynchronizationMode = synchronizationMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionSynchronization"/> for deserialization. </summary>
        internal ShareSubscriptionSynchronization()
        {
        }

        /// <summary> Synchronization duration. </summary>
        public int? DurationInMilliSeconds { get; }
        /// <summary> End time of synchronization. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> message of Synchronization. </summary>
        public string Message { get; }
        /// <summary> start time of synchronization. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Raw Status. </summary>
        public string Status { get; }
        /// <summary> Synchronization id. </summary>
        public Guid SynchronizationId { get; set; }
        /// <summary> Synchronization Mode. </summary>
        public SynchronizationMode? SynchronizationMode { get; }
    }
}
