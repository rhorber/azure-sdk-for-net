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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteContainerResource"/> and their operations.
    /// Each <see cref="SiteContainerResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="SiteContainerCollection"/> instance call the GetSiteContainers method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class SiteContainerCollection : ArmCollection, IEnumerable<SiteContainerResource>, IAsyncEnumerable<SiteContainerResource>
    {
        private readonly ClientDiagnostics _siteContainerWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteContainerWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteContainerCollection"/> class for mocking. </summary>
        protected SiteContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteContainerWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteContainerResource.ResourceType, out string siteContainerWebAppsApiVersion);
            _siteContainerWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteContainerWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a site container for a site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="data"> Container Entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string containerName, SiteContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteContainerWebAppsRestClient.CreateOrUpdateSiteContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, data, cancellationToken).ConfigureAwait(false);
                var uri = _siteContainerWebAppsRestClient.CreateCreateOrUpdateSiteContainerRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<SiteContainerResource>(Response.FromValue(new SiteContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or Updates a site container for a site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="data"> Container Entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteContainerResource> CreateOrUpdate(WaitUntil waitUntil, string containerName, SiteContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteContainerWebAppsRestClient.CreateOrUpdateSiteContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, data, cancellationToken);
                var uri = _siteContainerWebAppsRestClient.CreateCreateOrUpdateSiteContainerRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<SiteContainerResource>(Response.FromValue(new SiteContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a site container of a site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<SiteContainerResource>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteContainerWebAppsRestClient.GetSiteContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a site container of a site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<SiteContainerResource> Get(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _siteContainerWebAppsRestClient.GetSiteContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the site containers of a site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListSiteContainers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteContainerWebAppsRestClient.CreateListSiteContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteContainerWebAppsRestClient.CreateListSiteContainersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteContainerResource(Client, SiteContainerData.DeserializeSiteContainerData(e)), _siteContainerWebAppsClientDiagnostics, Pipeline, "SiteContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the site containers of a site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListSiteContainers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteContainerWebAppsRestClient.CreateListSiteContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteContainerWebAppsRestClient.CreateListSiteContainersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteContainerResource(Client, SiteContainerData.DeserializeSiteContainerData(e)), _siteContainerWebAppsClientDiagnostics, Pipeline, "SiteContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteContainerWebAppsRestClient.GetSiteContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteContainerWebAppsRestClient.GetSiteContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteContainerResource>> GetIfExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteContainerWebAppsRestClient.GetSiteContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteContainerResource>(response.GetRawResponse());
                return Response.FromValue(new SiteContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sitecontainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteContainer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Site Container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual NullableResponse<SiteContainerResource> GetIfExists(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _siteContainerWebAppsClientDiagnostics.CreateScope("SiteContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteContainerWebAppsRestClient.GetSiteContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, containerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteContainerResource>(response.GetRawResponse());
                return Response.FromValue(new SiteContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteContainerResource> IEnumerable<SiteContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteContainerResource> IAsyncEnumerable<SiteContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
