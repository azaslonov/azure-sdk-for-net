// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dataFactoryFactoriesClientDiagnostics;
        private FactoriesRestOperations _dataFactoryFactoriesRestClient;
        private ClientDiagnostics _exposureControlClientDiagnostics;
        private ExposureControlRestOperations _exposureControlRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataFactoryFactoriesClientDiagnostics => _dataFactoryFactoriesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryResource.ResourceType.Namespace, Diagnostics);
        private FactoriesRestOperations DataFactoryFactoriesRestClient => _dataFactoryFactoriesRestClient ??= new FactoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataFactoryResource.ResourceType));
        private ClientDiagnostics ExposureControlClientDiagnostics => _exposureControlClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataFactory", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExposureControlRestOperations ExposureControlRestClient => _exposureControlRestClient ??= new ExposureControlRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories
        /// Operation Id: Factories_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryResource> GetDataFactoriesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataFactoryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataFactories");
                scope.Start();
                try
                {
                    var response = await DataFactoryFactoriesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataFactoryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataFactories");
                scope.Start();
                try
                {
                    var response = await DataFactoryFactoriesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories
        /// Operation Id: Factories_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryResource> GetDataFactories(CancellationToken cancellationToken = default)
        {
            Page<DataFactoryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataFactories");
                scope.Start();
                try
                {
                    var response = DataFactoryFactoriesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataFactoryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataFactories");
                scope.Start();
                try
                {
                    var response = DataFactoryFactoriesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Updates a factory&apos;s repo information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo
        /// Operation Id: Factories_ConfigureFactoryRepo
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="factoryRepoUpdate"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFactoryResource>> ConfigureFactoryRepoInformationAsync(ResourceIdentifier locationId, FactoryRepoUpdate factoryRepoUpdate, CancellationToken cancellationToken = default)
        {
            using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ConfigureFactoryRepoInformation");
            scope.Start();
            try
            {
                var response = await DataFactoryFactoriesRestClient.ConfigureFactoryRepoAsync(Id.SubscriptionId, locationId, factoryRepoUpdate, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a factory&apos;s repo information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo
        /// Operation Id: Factories_ConfigureFactoryRepo
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="factoryRepoUpdate"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFactoryResource> ConfigureFactoryRepoInformation(ResourceIdentifier locationId, FactoryRepoUpdate factoryRepoUpdate, CancellationToken cancellationToken = default)
        {
            using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ConfigureFactoryRepoInformation");
            scope.Start();
            try
            {
                var response = DataFactoryFactoriesRestClient.ConfigureFactoryRepo(Id.SubscriptionId, locationId, factoryRepoUpdate, cancellationToken);
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue
        /// Operation Id: ExposureControl_GetFeatureValue
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExposureControlResult>> GetFeatureValueExposureControlAsync(ResourceIdentifier locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ExposureControlClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFeatureValueExposureControl");
            scope.Start();
            try
            {
                var response = await ExposureControlRestClient.GetFeatureValueAsync(Id.SubscriptionId, locationId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue
        /// Operation Id: ExposureControl_GetFeatureValue
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExposureControlResult> GetFeatureValueExposureControl(ResourceIdentifier locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ExposureControlClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFeatureValueExposureControl");
            scope.Start();
            try
            {
                var response = ExposureControlRestClient.GetFeatureValue(Id.SubscriptionId, locationId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
