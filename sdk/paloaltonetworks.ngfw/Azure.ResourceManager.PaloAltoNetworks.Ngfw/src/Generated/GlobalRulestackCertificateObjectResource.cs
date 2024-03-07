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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a GlobalRulestackCertificateObject along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GlobalRulestackCertificateObjectResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGlobalRulestackCertificateObjectResource method.
    /// Otherwise you can get one from its parent resource <see cref="GlobalRulestackResource"/> using the GetGlobalRulestackCertificateObject method.
    /// </summary>
    public partial class GlobalRulestackCertificateObjectResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GlobalRulestackCertificateObjectResource"/> instance. </summary>
        /// <param name="globalRulestackName"> The globalRulestackName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string globalRulestackName, string name)
        {
            var resourceId = $"/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics;
        private readonly CertificateObjectGlobalRulestackRestOperations _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient;
        private readonly GlobalRulestackCertificateObjectData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/globalRulestacks/certificates";

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCertificateObjectResource"/> class for mocking. </summary>
        protected GlobalRulestackCertificateObjectResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCertificateObjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GlobalRulestackCertificateObjectResource(ArmClient client, GlobalRulestackCertificateObjectData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCertificateObjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GlobalRulestackCertificateObjectResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string globalRulestackCertificateObjectCertificateObjectGlobalRulestackApiVersion);
            _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient = new CertificateObjectGlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalRulestackCertificateObjectCertificateObjectGlobalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GlobalRulestackCertificateObjectData Data
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
        /// Get a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackCertificateObjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GlobalRulestackCertificateObjectResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectResource.Get");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackCertificateObjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GlobalRulestackCertificateObjectResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectResource.Get");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackCertificateObjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectResource.Delete");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackCertificateObjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectResource.Delete");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackCertificateObjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalRulestackCertificateObjectResource>> UpdateAsync(WaitUntil waitUntil, GlobalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectResource.Update");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<GlobalRulestackCertificateObjectResource>(new GlobalRulestackCertificateObjectOperationSource(Client), _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackCertificateObjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalRulestackCertificateObjectResource> Update(WaitUntil waitUntil, GlobalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectResource.Update");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<GlobalRulestackCertificateObjectResource>(new GlobalRulestackCertificateObjectOperationSource(Client), _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
