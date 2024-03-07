// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a CosmosDBSqlRoleDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CosmosDBSqlRoleDefinitionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCosmosDBSqlRoleDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBAccountResource"/> using the GetCosmosDBSqlRoleDefinition method.
    /// </summary>
    public partial class CosmosDBSqlRoleDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBSqlRoleDefinitionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="roleDefinitionId"> The roleDefinitionId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string roleDefinitionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlRoleDefinitionSqlResourcesRestClient;
        private readonly CosmosDBSqlRoleDefinitionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/sqlRoleDefinitions";

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleDefinitionResource"/> class for mocking. </summary>
        protected CosmosDBSqlRoleDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBSqlRoleDefinitionResource(ArmClient client, CosmosDBSqlRoleDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBSqlRoleDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBSqlRoleDefinitionSqlResourcesApiVersion);
            _cosmosDBSqlRoleDefinitionSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlRoleDefinitionSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBSqlRoleDefinitionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBSqlRoleDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBSqlRoleDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing Azure Cosmos DB SQL Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_DeleteSqlRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.DeleteSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation(_cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateDeleteSqlRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing Azure Cosmos DB SQL Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_DeleteSqlRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.DeleteSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CosmosDBArmOperation(_cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateDeleteSqlRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB SQL Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlRoleDefinitionResource>> UpdateAsync(WaitUntil waitUntil, CosmosDBSqlRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateUpdateSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleDefinitionResource>(new CosmosDBSqlRoleDefinitionOperationSource(Client), _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateCreateUpdateSqlRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB SQL Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlRoleDefinitionResource> Update(WaitUntil waitUntil, CosmosDBSqlRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateUpdateSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleDefinitionResource>(new CosmosDBSqlRoleDefinitionOperationSource(Client), _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateCreateUpdateSqlRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
    }
}
