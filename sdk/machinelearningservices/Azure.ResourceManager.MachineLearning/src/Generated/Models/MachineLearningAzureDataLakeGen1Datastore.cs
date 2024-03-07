// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure Data Lake Gen1 datastore configuration. </summary>
    public partial class MachineLearningAzureDataLakeGen1Datastore : MachineLearningDatastoreProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAzureDataLakeGen1Datastore"/>. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="storeName"> [Required] Azure Data Lake store name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> or <paramref name="storeName"/> is null. </exception>
        public MachineLearningAzureDataLakeGen1Datastore(MachineLearningDatastoreCredentials credentials, string storeName) : base(credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));
            Argument.AssertNotNull(storeName, nameof(storeName));

            StoreName = storeName;
            DatastoreType = DatastoreType.AzureDataLakeGen1;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAzureDataLakeGen1Datastore"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="intellectualProperty"> Intellectual Property details. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer's storage. </param>
        /// <param name="storeName"> [Required] Azure Data Lake store name. </param>
        /// <param name="resourceGroup"> Azure Resource Group name. </param>
        /// <param name="subscriptionId"> Azure Subscription Id. </param>
        internal MachineLearningAzureDataLakeGen1Datastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningDatastoreCredentials credentials, DatastoreType datastoreType, IntellectualProperty intellectualProperty, bool? isDefault, MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity, string storeName, string resourceGroup, string subscriptionId) : base(description, properties, tags, serializedAdditionalRawData, credentials, datastoreType, intellectualProperty, isDefault)
        {
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            StoreName = storeName;
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            DatastoreType = datastoreType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAzureDataLakeGen1Datastore"/> for deserialization. </summary>
        internal MachineLearningAzureDataLakeGen1Datastore()
        {
        }

        /// <summary> Indicates which identity to use to authenticate service data access to customer's storage. </summary>
        public MachineLearningServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
        /// <summary> [Required] Azure Data Lake store name. </summary>
        public string StoreName { get; set; }
        /// <summary> Azure Resource Group name. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Azure Subscription Id. </summary>
        public string SubscriptionId { get; set; }
    }
}
