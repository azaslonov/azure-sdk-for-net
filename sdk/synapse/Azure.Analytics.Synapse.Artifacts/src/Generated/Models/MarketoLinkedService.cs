// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Marketo server linked service. </summary>
    public partial class MarketoLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="MarketoLinkedService"/>. </summary>
        /// <param name="endpoint"> The endpoint of the Marketo server. (i.e. 123-ABC-321.mktorest.com). </param>
        /// <param name="clientId"> The client Id of your Marketo service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="clientId"/> is null. </exception>
        public MarketoLinkedService(object endpoint, object clientId)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(clientId, nameof(clientId));

            Endpoint = endpoint;
            ClientId = clientId;
            Type = "Marketo";
        }

        /// <summary> Initializes a new instance of <see cref="MarketoLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of the Marketo server. (i.e. 123-ABC-321.mktorest.com). </param>
        /// <param name="clientId"> The client Id of your Marketo service. </param>
        /// <param name="clientSecret">
        /// The client secret of your Marketo service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal MarketoLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object endpoint, object clientId, SecretBase clientSecret, object useEncryptedEndpoints, object useHostVerification, object usePeerVerification, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Marketo";
        }

        /// <summary> The endpoint of the Marketo server. (i.e. 123-ABC-321.mktorest.com). </summary>
        public object Endpoint { get; set; }
        /// <summary> The client Id of your Marketo service. </summary>
        public object ClientId { get; set; }
        /// <summary>
        /// The client secret of your Marketo service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public object UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public object UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public object UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
