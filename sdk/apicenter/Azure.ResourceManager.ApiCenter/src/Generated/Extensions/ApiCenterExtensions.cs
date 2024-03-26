// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiCenter.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApiCenter
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ApiCenter. </summary>
    public static partial class ApiCenterExtensions
    {
        private static MockableApiCenterArmClient GetMockableApiCenterArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableApiCenterArmClient(client0));
        }

        private static MockableApiCenterResourceGroupResource GetMockableApiCenterResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableApiCenterResourceGroupResource(client, resource.Id));
        }

        private static MockableApiCenterSubscriptionResource GetMockableApiCenterSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableApiCenterSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="ApiCenterServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApiCenterServiceResource.CreateResourceIdentifier" /> to create an <see cref="ApiCenterServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetApiCenterServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ApiCenterServiceResource"/> object. </returns>
        public static ApiCenterServiceResource GetApiCenterServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetApiCenterServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MetadataSchemaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MetadataSchemaResource.CreateResourceIdentifier" /> to create a <see cref="MetadataSchemaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetMetadataSchemaResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="MetadataSchemaResource"/> object. </returns>
        public static MetadataSchemaResource GetMetadataSchemaResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetMetadataSchemaResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="WorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetWorkspaceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="WorkspaceResource"/> object. </returns>
        public static WorkspaceResource GetWorkspaceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetWorkspaceResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ApiResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApiResource.CreateResourceIdentifier" /> to create an <see cref="ApiResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetApiResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ApiResource"/> object. </returns>
        public static ApiResource GetApiResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetApiResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeploymentResource.CreateResourceIdentifier" /> to create a <see cref="DeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetDeploymentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeploymentResource"/> object. </returns>
        public static DeploymentResource GetDeploymentResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetDeploymentResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ApiVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApiVersionResource.CreateResourceIdentifier" /> to create an <see cref="ApiVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetApiVersionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ApiVersionResource"/> object. </returns>
        public static ApiVersionResource GetApiVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetApiVersionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ApiDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApiDefinitionResource.CreateResourceIdentifier" /> to create an <see cref="ApiDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetApiDefinitionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ApiDefinitionResource"/> object. </returns>
        public static ApiDefinitionResource GetApiDefinitionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetApiDefinitionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EnvironmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EnvironmentResource.CreateResourceIdentifier" /> to create an <see cref="EnvironmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterArmClient.GetEnvironmentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="EnvironmentResource"/> object. </returns>
        public static EnvironmentResource GetEnvironmentResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableApiCenterArmClient(client).GetEnvironmentResource(id);
        }

        /// <summary>
        /// Gets a collection of ApiCenterServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterResourceGroupResource.GetApiCenterServices()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ApiCenterServiceResources and their operations over a ApiCenterServiceResource. </returns>
        public static ApiCenterServiceCollection GetApiCenterServices(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableApiCenterResourceGroupResource(resourceGroupResource).GetApiCenterServices();
        }

        /// <summary>
        /// Returns details of the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterResourceGroupResource.GetApiCenterServiceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serviceName"> The name of Azure API Center service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ApiCenterServiceResource>> GetApiCenterServiceAsync(this ResourceGroupResource resourceGroupResource, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableApiCenterResourceGroupResource(resourceGroupResource).GetApiCenterServiceAsync(serviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns details of the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiCenter/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterResourceGroupResource.GetApiCenterService(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serviceName"> The name of Azure API Center service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ApiCenterServiceResource> GetApiCenterService(this ResourceGroupResource resourceGroupResource, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableApiCenterResourceGroupResource(resourceGroupResource).GetApiCenterService(serviceName, cancellationToken);
        }

        /// <summary>
        /// Lists services within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiCenter/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterSubscriptionResource.GetApiCenterServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ApiCenterServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ApiCenterServiceResource> GetApiCenterServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableApiCenterSubscriptionResource(subscriptionResource).GetApiCenterServicesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists services within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiCenter/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiCenterServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableApiCenterSubscriptionResource.GetApiCenterServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ApiCenterServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ApiCenterServiceResource> GetApiCenterServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableApiCenterSubscriptionResource(subscriptionResource).GetApiCenterServices(cancellationToken);
        }
    }
}
