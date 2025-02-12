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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.PlaywrightTesting.Models;

namespace Azure.ResourceManager.PlaywrightTesting
{
    /// <summary>
    /// A class representing a collection of <see cref="PlaywrightTestingAccountQuotaResource"/> and their operations.
    /// Each <see cref="PlaywrightTestingAccountQuotaResource"/> in the collection will belong to the same instance of <see cref="PlaywrightTestingAccountResource"/>.
    /// To get a <see cref="PlaywrightTestingAccountQuotaCollection"/> instance call the GetPlaywrightTestingAccountQuotas method from an instance of <see cref="PlaywrightTestingAccountResource"/>.
    /// </summary>
    public partial class PlaywrightTestingAccountQuotaCollection : ArmCollection, IEnumerable<PlaywrightTestingAccountQuotaResource>, IAsyncEnumerable<PlaywrightTestingAccountQuotaResource>
    {
        private readonly ClientDiagnostics _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics;
        private readonly AccountQuotasRestOperations _playwrightTestingAccountQuotaAccountQuotasRestClient;

        /// <summary> Initializes a new instance of the <see cref="PlaywrightTestingAccountQuotaCollection"/> class for mocking. </summary>
        protected PlaywrightTestingAccountQuotaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PlaywrightTestingAccountQuotaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PlaywrightTestingAccountQuotaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PlaywrightTesting", PlaywrightTestingAccountQuotaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PlaywrightTestingAccountQuotaResource.ResourceType, out string playwrightTestingAccountQuotaAccountQuotasApiVersion);
            _playwrightTestingAccountQuotaAccountQuotasRestClient = new AccountQuotasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, playwrightTestingAccountQuotaAccountQuotasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PlaywrightTestingAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PlaywrightTestingAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get quota by name for an account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The Playwright service account quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PlaywrightTestingAccountQuotaResource>> GetAsync(PlaywrightTestingQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics.CreateScope("PlaywrightTestingAccountQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountQuotaAccountQuotasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get quota by name for an account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The Playwright service account quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PlaywrightTestingAccountQuotaResource> Get(PlaywrightTestingQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics.CreateScope("PlaywrightTestingAccountQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountQuotaAccountQuotasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List quotas for a given account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PlaywrightTestingAccountQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PlaywrightTestingAccountQuotaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _playwrightTestingAccountQuotaAccountQuotasRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _playwrightTestingAccountQuotaAccountQuotasRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PlaywrightTestingAccountQuotaResource(Client, PlaywrightTestingAccountQuotaData.DeserializePlaywrightTestingAccountQuotaData(e)), _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics, Pipeline, "PlaywrightTestingAccountQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List quotas for a given account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PlaywrightTestingAccountQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PlaywrightTestingAccountQuotaResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _playwrightTestingAccountQuotaAccountQuotasRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _playwrightTestingAccountQuotaAccountQuotasRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PlaywrightTestingAccountQuotaResource(Client, PlaywrightTestingAccountQuotaData.DeserializePlaywrightTestingAccountQuotaData(e)), _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics, Pipeline, "PlaywrightTestingAccountQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The Playwright service account quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PlaywrightTestingQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics.CreateScope("PlaywrightTestingAccountQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountQuotaAccountQuotasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The Playwright service account quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PlaywrightTestingQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics.CreateScope("PlaywrightTestingAccountQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountQuotaAccountQuotasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The Playwright service account quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<PlaywrightTestingAccountQuotaResource>> GetIfExistsAsync(PlaywrightTestingQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics.CreateScope("PlaywrightTestingAccountQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountQuotaAccountQuotasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PlaywrightTestingAccountQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountQuotaResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{accountName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The Playwright service account quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<PlaywrightTestingAccountQuotaResource> GetIfExists(PlaywrightTestingQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightTestingAccountQuotaAccountQuotasClientDiagnostics.CreateScope("PlaywrightTestingAccountQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountQuotaAccountQuotasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PlaywrightTestingAccountQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PlaywrightTestingAccountQuotaResource> IEnumerable<PlaywrightTestingAccountQuotaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PlaywrightTestingAccountQuotaResource> IAsyncEnumerable<PlaywrightTestingAccountQuotaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
