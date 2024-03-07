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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="CommunityGalleryResource"/> and their operations.
    /// Each <see cref="CommunityGalleryResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="CommunityGalleryCollection"/> instance call the GetCommunityGalleries method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class CommunityGalleryCollection : ArmCollection
    {
        private readonly ClientDiagnostics _communityGalleryClientDiagnostics;
        private readonly CommunityGalleriesRestOperations _communityGalleryRestClient;

        /// <summary> Initializes a new instance of the <see cref="CommunityGalleryCollection"/> class for mocking. </summary>
        protected CommunityGalleryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CommunityGalleryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CommunityGalleryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _communityGalleryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CommunityGalleryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CommunityGalleryResource.ResourceType, out string communityGalleryApiVersion);
            _communityGalleryRestClient = new CommunityGalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, communityGalleryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a community gallery by gallery public name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunityGalleryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicGalleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicGalleryName"/> is null. </exception>
        public virtual async Task<Response<CommunityGalleryResource>> GetAsync(AzureLocation location, string publicGalleryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));

            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryCollection.Get");
            scope.Start();
            try
            {
                var response = await _communityGalleryRestClient.GetAsync(Id.SubscriptionId, location, publicGalleryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CommunityGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, location, publicGalleryName);
                return Response.FromValue(new CommunityGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a community gallery by gallery public name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunityGalleryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicGalleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicGalleryName"/> is null. </exception>
        public virtual Response<CommunityGalleryResource> Get(AzureLocation location, string publicGalleryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));

            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryCollection.Get");
            scope.Start();
            try
            {
                var response = _communityGalleryRestClient.Get(Id.SubscriptionId, location, publicGalleryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CommunityGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, location, publicGalleryName);
                return Response.FromValue(new CommunityGalleryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunityGalleryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicGalleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicGalleryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string publicGalleryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));

            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _communityGalleryRestClient.GetAsync(Id.SubscriptionId, location, publicGalleryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunityGalleryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicGalleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicGalleryName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string publicGalleryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));

            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = _communityGalleryRestClient.Get(Id.SubscriptionId, location, publicGalleryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunityGalleryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicGalleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicGalleryName"/> is null. </exception>
        public virtual async Task<NullableResponse<CommunityGalleryResource>> GetIfExistsAsync(AzureLocation location, string publicGalleryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));

            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _communityGalleryRestClient.GetAsync(Id.SubscriptionId, location, publicGalleryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CommunityGalleryResource>(response.GetRawResponse());
                response.Value.Id = CommunityGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, location, publicGalleryName);
                return Response.FromValue(new CommunityGalleryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunityGalleryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicGalleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicGalleryName"/> is null. </exception>
        public virtual NullableResponse<CommunityGalleryResource> GetIfExists(AzureLocation location, string publicGalleryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));

            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _communityGalleryRestClient.Get(Id.SubscriptionId, location, publicGalleryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CommunityGalleryResource>(response.GetRawResponse());
                response.Value.Id = CommunityGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, location, publicGalleryName);
                return Response.FromValue(new CommunityGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
