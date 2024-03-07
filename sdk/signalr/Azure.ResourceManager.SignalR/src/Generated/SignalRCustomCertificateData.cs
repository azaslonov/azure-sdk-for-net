// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing the SignalRCustomCertificate data model.
    /// A custom certificate.
    /// </summary>
    public partial class SignalRCustomCertificateData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SignalRCustomCertificateData"/>. </summary>
        /// <param name="keyVaultBaseUri"> Base uri of the KeyVault that stores certificate. </param>
        /// <param name="keyVaultSecretName"> Certificate secret name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultBaseUri"/> or <paramref name="keyVaultSecretName"/> is null. </exception>
        public SignalRCustomCertificateData(Uri keyVaultBaseUri, string keyVaultSecretName)
        {
            Argument.AssertNotNull(keyVaultBaseUri, nameof(keyVaultBaseUri));
            Argument.AssertNotNull(keyVaultSecretName, nameof(keyVaultSecretName));

            KeyVaultBaseUri = keyVaultBaseUri;
            KeyVaultSecretName = keyVaultSecretName;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="keyVaultBaseUri"> Base uri of the KeyVault that stores certificate. </param>
        /// <param name="keyVaultSecretName"> Certificate secret name. </param>
        /// <param name="keyVaultSecretVersion"> Certificate secret version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRCustomCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SignalRProvisioningState? provisioningState, Uri keyVaultBaseUri, string keyVaultSecretName, string keyVaultSecretVersion, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            KeyVaultBaseUri = keyVaultBaseUri;
            KeyVaultSecretName = keyVaultSecretName;
            KeyVaultSecretVersion = keyVaultSecretVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomCertificateData"/> for deserialization. </summary>
        internal SignalRCustomCertificateData()
        {
        }

        /// <summary> Provisioning state of the resource. </summary>
        public SignalRProvisioningState? ProvisioningState { get; }
        /// <summary> Base uri of the KeyVault that stores certificate. </summary>
        public Uri KeyVaultBaseUri { get; set; }
        /// <summary> Certificate secret name. </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary> Certificate secret version. </summary>
        public string KeyVaultSecretVersion { get; set; }
    }
}
