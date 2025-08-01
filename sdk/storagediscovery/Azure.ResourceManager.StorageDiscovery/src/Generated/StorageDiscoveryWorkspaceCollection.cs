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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StorageDiscovery
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageDiscoveryWorkspaceResource"/> and their operations.
    /// Each <see cref="StorageDiscoveryWorkspaceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="StorageDiscoveryWorkspaceCollection"/> instance call the GetStorageDiscoveryWorkspaces method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class StorageDiscoveryWorkspaceCollection : ArmCollection, IEnumerable<StorageDiscoveryWorkspaceResource>, IAsyncEnumerable<StorageDiscoveryWorkspaceResource>
    {
        private readonly ClientDiagnostics _storageDiscoveryWorkspaceClientDiagnostics;
        private readonly StorageDiscoveryWorkspacesRestOperations _storageDiscoveryWorkspaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageDiscoveryWorkspaceCollection"/> class for mocking. </summary>
        protected StorageDiscoveryWorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageDiscoveryWorkspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageDiscoveryWorkspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageDiscoveryWorkspaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageDiscovery", StorageDiscoveryWorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageDiscoveryWorkspaceResource.ResourceType, out string storageDiscoveryWorkspaceApiVersion);
            _storageDiscoveryWorkspaceRestClient = new StorageDiscoveryWorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageDiscoveryWorkspaceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a StorageDiscoveryWorkspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageDiscoveryWorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageDiscoveryWorkspaceName, StorageDiscoveryWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageDiscoveryWorkspaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, data, cancellationToken).ConfigureAwait(false);
                var uri = _storageDiscoveryWorkspaceRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StorageDiscoveryArmOperation<StorageDiscoveryWorkspaceResource>(Response.FromValue(new StorageDiscoveryWorkspaceResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a StorageDiscoveryWorkspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageDiscoveryWorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string storageDiscoveryWorkspaceName, StorageDiscoveryWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageDiscoveryWorkspaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, data, cancellationToken);
                var uri = _storageDiscoveryWorkspaceRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StorageDiscoveryArmOperation<StorageDiscoveryWorkspaceResource>(Response.FromValue(new StorageDiscoveryWorkspaceResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a StorageDiscoveryWorkspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> is null. </exception>
        public virtual async Task<Response<StorageDiscoveryWorkspaceResource>> GetAsync(string storageDiscoveryWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageDiscoveryWorkspaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageDiscoveryWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StorageDiscoveryWorkspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> is null. </exception>
        public virtual Response<StorageDiscoveryWorkspaceResource> Get(string storageDiscoveryWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _storageDiscoveryWorkspaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageDiscoveryWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List StorageDiscoveryWorkspace resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageDiscoveryWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageDiscoveryWorkspaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageDiscoveryWorkspaceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageDiscoveryWorkspaceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageDiscoveryWorkspaceResource(Client, StorageDiscoveryWorkspaceData.DeserializeStorageDiscoveryWorkspaceData(e)), _storageDiscoveryWorkspaceClientDiagnostics, Pipeline, "StorageDiscoveryWorkspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List StorageDiscoveryWorkspace resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageDiscoveryWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageDiscoveryWorkspaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageDiscoveryWorkspaceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageDiscoveryWorkspaceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageDiscoveryWorkspaceResource(Client, StorageDiscoveryWorkspaceData.DeserializeStorageDiscoveryWorkspaceData(e)), _storageDiscoveryWorkspaceClientDiagnostics, Pipeline, "StorageDiscoveryWorkspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageDiscoveryWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageDiscoveryWorkspaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageDiscoveryWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageDiscoveryWorkspaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageDiscoveryWorkspaceResource>> GetIfExistsAsync(string storageDiscoveryWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageDiscoveryWorkspaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageDiscoveryWorkspaceResource>(response.GetRawResponse());
                return Response.FromValue(new StorageDiscoveryWorkspaceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageDiscovery/storageDiscoveryWorkspaces/{storageDiscoveryWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageDiscoveryWorkspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageDiscoveryWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageDiscoveryWorkspaceName"> The name of the StorageDiscoveryWorkspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageDiscoveryWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiscoveryWorkspaceName"/> is null. </exception>
        public virtual NullableResponse<StorageDiscoveryWorkspaceResource> GetIfExists(string storageDiscoveryWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageDiscoveryWorkspaceName, nameof(storageDiscoveryWorkspaceName));

            using var scope = _storageDiscoveryWorkspaceClientDiagnostics.CreateScope("StorageDiscoveryWorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageDiscoveryWorkspaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageDiscoveryWorkspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageDiscoveryWorkspaceResource>(response.GetRawResponse());
                return Response.FromValue(new StorageDiscoveryWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageDiscoveryWorkspaceResource> IEnumerable<StorageDiscoveryWorkspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageDiscoveryWorkspaceResource> IAsyncEnumerable<StorageDiscoveryWorkspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
