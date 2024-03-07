// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm specific provider input. </summary>
    public partial class InMageRcmReprotectContent : ReverseReplicationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmReprotectContent"/>. </summary>
        /// <param name="reprotectAgentId"> The reprotect agent Id. </param>
        /// <param name="datastoreName"> The target datastore name. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reprotectAgentId"/>, <paramref name="datastoreName"/> or <paramref name="logStorageAccountId"/> is null. </exception>
        public InMageRcmReprotectContent(string reprotectAgentId, string datastoreName, ResourceIdentifier logStorageAccountId)
        {
            Argument.AssertNotNull(reprotectAgentId, nameof(reprotectAgentId));
            Argument.AssertNotNull(datastoreName, nameof(datastoreName));
            Argument.AssertNotNull(logStorageAccountId, nameof(logStorageAccountId));

            ReprotectAgentId = reprotectAgentId;
            DatastoreName = datastoreName;
            LogStorageAccountId = logStorageAccountId;
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmReprotectContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="reprotectAgentId"> The reprotect agent Id. </param>
        /// <param name="datastoreName"> The target datastore name. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="policyId"> The Policy Id. </param>
        internal InMageRcmReprotectContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string reprotectAgentId, string datastoreName, ResourceIdentifier logStorageAccountId, ResourceIdentifier policyId) : base(instanceType, serializedAdditionalRawData)
        {
            ReprotectAgentId = reprotectAgentId;
            DatastoreName = datastoreName;
            LogStorageAccountId = logStorageAccountId;
            PolicyId = policyId;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmReprotectContent"/> for deserialization. </summary>
        internal InMageRcmReprotectContent()
        {
        }

        /// <summary> The reprotect agent Id. </summary>
        public string ReprotectAgentId { get; }
        /// <summary> The target datastore name. </summary>
        public string DatastoreName { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The Policy Id. </summary>
        public ResourceIdentifier PolicyId { get; set; }
    }
}
