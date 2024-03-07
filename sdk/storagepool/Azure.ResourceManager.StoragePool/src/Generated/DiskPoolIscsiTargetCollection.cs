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
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary>
    /// A class representing a collection of <see cref="DiskPoolIscsiTargetResource"/> and their operations.
    /// Each <see cref="DiskPoolIscsiTargetResource"/> in the collection will belong to the same instance of <see cref="DiskPoolResource"/>.
    /// To get a <see cref="DiskPoolIscsiTargetCollection"/> instance call the GetDiskPoolIscsiTargets method from an instance of <see cref="DiskPoolResource"/>.
    /// </summary>
    public partial class DiskPoolIscsiTargetCollection : ArmCollection, IEnumerable<DiskPoolIscsiTargetResource>, IAsyncEnumerable<DiskPoolIscsiTargetResource>
    {
        private readonly ClientDiagnostics _diskPoolIscsiTargetIscsiTargetsClientDiagnostics;
        private readonly IscsiTargetsRestOperations _diskPoolIscsiTargetIscsiTargetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskPoolIscsiTargetCollection"/> class for mocking. </summary>
        protected DiskPoolIscsiTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskPoolIscsiTargetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskPoolIscsiTargetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskPoolIscsiTargetIscsiTargetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StoragePool", DiskPoolIscsiTargetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskPoolIscsiTargetResource.ResourceType, out string diskPoolIscsiTargetIscsiTargetsApiVersion);
            _diskPoolIscsiTargetIscsiTargetsRestClient = new IscsiTargetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskPoolIscsiTargetIscsiTargetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DiskPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DiskPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="content"> Request payload for iSCSI Target create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskPoolIscsiTargetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string iscsiTargetName, DiskPoolIscsiTargetCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content, cancellationToken).ConfigureAwait(false);
                var operation = new StoragePoolArmOperation<DiskPoolIscsiTargetResource>(new DiskPoolIscsiTargetOperationSource(Client), _diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, _diskPoolIscsiTargetIscsiTargetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or Update an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="content"> Request payload for iSCSI Target create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DiskPoolIscsiTargetResource> CreateOrUpdate(WaitUntil waitUntil, string iscsiTargetName, DiskPoolIscsiTargetCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content, cancellationToken);
                var operation = new StoragePoolArmOperation<DiskPoolIscsiTargetResource>(new DiskPoolIscsiTargetOperationSource(Client), _diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, _diskPoolIscsiTargetIscsiTargetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual async Task<Response<DiskPoolIscsiTargetResource>> GetAsync(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPoolIscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual Response<DiskPoolIscsiTargetResource> Get(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPoolIscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get iSCSI Targets in a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_ListByDiskPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPoolIscsiTargetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskPoolIscsiTargetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskPoolIscsiTargetIscsiTargetsRestClient.CreateListByDiskPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskPoolIscsiTargetIscsiTargetsRestClient.CreateListByDiskPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskPoolIscsiTargetResource(Client, DiskPoolIscsiTargetData.DeserializeDiskPoolIscsiTargetData(e)), _diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, "DiskPoolIscsiTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get iSCSI Targets in a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_ListByDiskPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPoolIscsiTargetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskPoolIscsiTargetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskPoolIscsiTargetIscsiTargetsRestClient.CreateListByDiskPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskPoolIscsiTargetIscsiTargetsRestClient.CreateListByDiskPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskPoolIscsiTargetResource(Client, DiskPoolIscsiTargetData.DeserializeDiskPoolIscsiTargetData(e)), _diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, "DiskPoolIscsiTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual Response<bool> Exists(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DiskPoolIscsiTargetResource>> GetIfExistsAsync(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DiskPoolIscsiTargetResource>(response.GetRawResponse());
                return Response.FromValue(new DiskPoolIscsiTargetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual NullableResponse<DiskPoolIscsiTargetResource> GetIfExists(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DiskPoolIscsiTargetResource>(response.GetRawResponse());
                return Response.FromValue(new DiskPoolIscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskPoolIscsiTargetResource> IEnumerable<DiskPoolIscsiTargetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskPoolIscsiTargetResource> IAsyncEnumerable<DiskPoolIscsiTargetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
