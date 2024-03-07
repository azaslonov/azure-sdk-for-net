// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing a collection of <see cref="QuotaRequestDetailResource"/> and their operations.
    /// Each <see cref="QuotaRequestDetailResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="QuotaRequestDetailCollection"/> instance call the GetQuotaRequestDetails method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class QuotaRequestDetailCollection : ArmCollection, IEnumerable<QuotaRequestDetailResource>, IAsyncEnumerable<QuotaRequestDetailResource>
    {
        private readonly ClientDiagnostics _quotaRequestDetailQuotaRequestStatusClientDiagnostics;
        private readonly QuotaRequestStatusRestOperations _quotaRequestDetailQuotaRequestStatusRestClient;

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailCollection"/> class for mocking. </summary>
        protected QuotaRequestDetailCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal QuotaRequestDetailCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _quotaRequestDetailQuotaRequestStatusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", QuotaRequestDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(QuotaRequestDetailResource.ResourceType, out string quotaRequestDetailQuotaRequestStatusApiVersion);
            _quotaRequestDetailQuotaRequestStatusRestClient = new QuotaRequestStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaRequestDetailQuotaRequestStatusApiVersion);
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<QuotaRequestDetailResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Get");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<QuotaRequestDetailResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Get");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field                    | Supported operators
        /// |---------------------|------------------------
        ///
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        ///
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuotaRequestDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuotaRequestDetailResource> GetAllAsync(string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListRequest(Id, filter, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListNextPageRequest(nextLink, Id, filter, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new QuotaRequestDetailResource(Client, QuotaRequestDetailData.DeserializeQuotaRequestDetailData(e)), _quotaRequestDetailQuotaRequestStatusClientDiagnostics, Pipeline, "QuotaRequestDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field                    | Supported operators
        /// |---------------------|------------------------
        ///
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        ///
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuotaRequestDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuotaRequestDetailResource> GetAll(string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListRequest(Id, filter, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListNextPageRequest(nextLink, Id, filter, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new QuotaRequestDetailResource(Client, QuotaRequestDetailData.DeserializeQuotaRequestDetailData(e)), _quotaRequestDetailQuotaRequestStatusClientDiagnostics, Pipeline, "QuotaRequestDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id, id, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<NullableResponse<QuotaRequestDetailResource>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<QuotaRequestDetailResource>(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual NullableResponse<QuotaRequestDetailResource> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id, id, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<QuotaRequestDetailResource>(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<QuotaRequestDetailResource> IEnumerable<QuotaRequestDetailResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<QuotaRequestDetailResource> IAsyncEnumerable<QuotaRequestDetailResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
