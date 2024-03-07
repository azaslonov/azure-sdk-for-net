// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A class representing the StorageMoverEndpoint data model.
    /// The Endpoint resource, which contains information about file sources and targets.
    /// </summary>
    public partial class StorageMoverEndpointData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="StorageMoverEndpointData"/>. </summary>
        /// <param name="properties">
        /// The resource specific properties for the Storage Mover resource.
        /// Please note <see cref="EndpointBaseProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureStorageBlobContainerEndpointProperties"/>, <see cref="AzureStorageSmbFileShareEndpointProperties"/>, <see cref="NfsMountEndpointProperties"/> and <see cref="SmbMountEndpointProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public StorageMoverEndpointData(EndpointBaseProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="StorageMoverEndpointData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// The resource specific properties for the Storage Mover resource.
        /// Please note <see cref="EndpointBaseProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureStorageBlobContainerEndpointProperties"/>, <see cref="AzureStorageSmbFileShareEndpointProperties"/>, <see cref="NfsMountEndpointProperties"/> and <see cref="SmbMountEndpointProperties"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageMoverEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EndpointBaseProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageMoverEndpointData"/> for deserialization. </summary>
        internal StorageMoverEndpointData()
        {
        }

        /// <summary>
        /// The resource specific properties for the Storage Mover resource.
        /// Please note <see cref="EndpointBaseProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureStorageBlobContainerEndpointProperties"/>, <see cref="AzureStorageSmbFileShareEndpointProperties"/>, <see cref="NfsMountEndpointProperties"/> and <see cref="SmbMountEndpointProperties"/>.
        /// </summary>
        public EndpointBaseProperties Properties { get; set; }
    }
}
