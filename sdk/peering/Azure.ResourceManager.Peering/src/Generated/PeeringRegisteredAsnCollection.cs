// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing a collection of <see cref="PeeringRegisteredAsnResource"/> and their operations.
    /// Each <see cref="PeeringRegisteredAsnResource"/> in the collection will belong to the same instance of <see cref="PeeringResource"/>.
    /// To get a <see cref="PeeringRegisteredAsnCollection"/> instance call the GetPeeringRegisteredAsns method from an instance of <see cref="PeeringResource"/>.
    /// </summary>
    public partial class PeeringRegisteredAsnCollection : ArmCollection, IEnumerable<PeeringRegisteredAsnResource>, IAsyncEnumerable<PeeringRegisteredAsnResource>
    {
        private readonly ClientDiagnostics _peeringRegisteredAsnRegisteredAsnsClientDiagnostics;
        private readonly RegisteredAsnsRestOperations _peeringRegisteredAsnRegisteredAsnsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredAsnCollection"/> class for mocking. </summary>
        protected PeeringRegisteredAsnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredAsnCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeeringRegisteredAsnCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peeringRegisteredAsnRegisteredAsnsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", PeeringRegisteredAsnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeeringRegisteredAsnResource.ResourceType, out string peeringRegisteredAsnRegisteredAsnsApiVersion);
            _peeringRegisteredAsnRegisteredAsnsRestClient = new RegisteredAsnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peeringRegisteredAsnRegisteredAsnsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PeeringResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PeeringResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="registeredAsnName"> The name of the ASN. </param>
        /// <param name="data"> The properties needed to create a registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeeringRegisteredAsnResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string registeredAsnName, PeeringRegisteredAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation<PeeringRegisteredAsnResource>(Response.FromValue(new PeeringRegisteredAsnResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="registeredAsnName"> The name of the ASN. </param>
        /// <param name="data"> The properties needed to create a registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeeringRegisteredAsnResource> CreateOrUpdate(WaitUntil waitUntil, string registeredAsnName, PeeringRegisteredAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, data, cancellationToken);
                var operation = new PeeringArmOperation<PeeringRegisteredAsnResource>(Response.FromValue(new PeeringRegisteredAsnResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredAsnName"> The name of the registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> is null. </exception>
        public virtual async Task<Response<PeeringRegisteredAsnResource>> GetAsync(string registeredAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.Get");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredAsnName"> The name of the registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> is null. </exception>
        public virtual Response<PeeringRegisteredAsnResource> Get(string registeredAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.Get");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all registered ASNs under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_ListByPeering</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeeringRegisteredAsnResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeeringRegisteredAsnResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringRegisteredAsnRegisteredAsnsRestClient.CreateListByPeeringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringRegisteredAsnRegisteredAsnsRestClient.CreateListByPeeringNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PeeringRegisteredAsnResource(Client, PeeringRegisteredAsnData.DeserializePeeringRegisteredAsnData(e)), _peeringRegisteredAsnRegisteredAsnsClientDiagnostics, Pipeline, "PeeringRegisteredAsnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all registered ASNs under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_ListByPeering</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeeringRegisteredAsnResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeeringRegisteredAsnResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringRegisteredAsnRegisteredAsnsRestClient.CreateListByPeeringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringRegisteredAsnRegisteredAsnsRestClient.CreateListByPeeringNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PeeringRegisteredAsnResource(Client, PeeringRegisteredAsnData.DeserializePeeringRegisteredAsnData(e)), _peeringRegisteredAsnRegisteredAsnsClientDiagnostics, Pipeline, "PeeringRegisteredAsnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredAsnName"> The name of the registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string registeredAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.Exists");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredAsnName"> The name of the registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> is null. </exception>
        public virtual Response<bool> Exists(string registeredAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.Exists");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredAsnName"> The name of the registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> is null. </exception>
        public virtual async Task<NullableResponse<PeeringRegisteredAsnResource>> GetIfExistsAsync(string registeredAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PeeringRegisteredAsnResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredAsnName"> The name of the registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredAsnName"/> is null. </exception>
        public virtual NullableResponse<PeeringRegisteredAsnResource> GetIfExists(string registeredAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredAsnName, nameof(registeredAsnName));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredAsnName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PeeringRegisteredAsnResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeeringRegisteredAsnResource> IEnumerable<PeeringRegisteredAsnResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeeringRegisteredAsnResource> IAsyncEnumerable<PeeringRegisteredAsnResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
