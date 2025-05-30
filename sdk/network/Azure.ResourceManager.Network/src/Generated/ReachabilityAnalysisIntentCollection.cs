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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ReachabilityAnalysisIntentResource"/> and their operations.
    /// Each <see cref="ReachabilityAnalysisIntentResource"/> in the collection will belong to the same instance of <see cref="NetworkVerifierWorkspaceResource"/>.
    /// To get a <see cref="ReachabilityAnalysisIntentCollection"/> instance call the GetReachabilityAnalysisIntents method from an instance of <see cref="NetworkVerifierWorkspaceResource"/>.
    /// </summary>
    public partial class ReachabilityAnalysisIntentCollection : ArmCollection, IEnumerable<ReachabilityAnalysisIntentResource>, IAsyncEnumerable<ReachabilityAnalysisIntentResource>
    {
        private readonly ClientDiagnostics _reachabilityAnalysisIntentClientDiagnostics;
        private readonly ReachabilityAnalysisIntentsRestOperations _reachabilityAnalysisIntentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ReachabilityAnalysisIntentCollection"/> class for mocking. </summary>
        protected ReachabilityAnalysisIntentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReachabilityAnalysisIntentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ReachabilityAnalysisIntentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reachabilityAnalysisIntentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ReachabilityAnalysisIntentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReachabilityAnalysisIntentResource.ResourceType, out string reachabilityAnalysisIntentApiVersion);
            _reachabilityAnalysisIntentRestClient = new ReachabilityAnalysisIntentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reachabilityAnalysisIntentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkVerifierWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkVerifierWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates Reachability Analysis Intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="data"> Reachability Analysis Intent object to create/update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ReachabilityAnalysisIntentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string reachabilityAnalysisIntentName, ReachabilityAnalysisIntentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _reachabilityAnalysisIntentRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, data, cancellationToken).ConfigureAwait(false);
                var uri = _reachabilityAnalysisIntentRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<ReachabilityAnalysisIntentResource>(Response.FromValue(new ReachabilityAnalysisIntentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates Reachability Analysis Intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="data"> Reachability Analysis Intent object to create/update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ReachabilityAnalysisIntentResource> CreateOrUpdate(WaitUntil waitUntil, string reachabilityAnalysisIntentName, ReachabilityAnalysisIntentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _reachabilityAnalysisIntentRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, data, cancellationToken);
                var uri = _reachabilityAnalysisIntentRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<ReachabilityAnalysisIntentResource>(Response.FromValue(new ReachabilityAnalysisIntentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get the Reachability Analysis Intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> is null. </exception>
        public virtual async Task<Response<ReachabilityAnalysisIntentResource>> GetAsync(string reachabilityAnalysisIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.Get");
            scope.Start();
            try
            {
                var response = await _reachabilityAnalysisIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReachabilityAnalysisIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Reachability Analysis Intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> is null. </exception>
        public virtual Response<ReachabilityAnalysisIntentResource> Get(string reachabilityAnalysisIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.Get");
            scope.Start();
            try
            {
                var response = _reachabilityAnalysisIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReachabilityAnalysisIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets list of Reachability Analysis Intents .
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Optional skip token. </param>
        /// <param name="skip"> Optional num entries to skip. </param>
        /// <param name="top"> Optional num entries to show. </param>
        /// <param name="sortKey"> Optional key by which to sort. </param>
        /// <param name="sortValue"> Optional sort value for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReachabilityAnalysisIntentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReachabilityAnalysisIntentResource> GetAllAsync(string skipToken = null, int? skip = null, int? top = null, string sortKey = null, string sortValue = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reachabilityAnalysisIntentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, skip, top, sortKey, sortValue);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reachabilityAnalysisIntentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, skip, top, sortKey, sortValue);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReachabilityAnalysisIntentResource(Client, ReachabilityAnalysisIntentData.DeserializeReachabilityAnalysisIntentData(e)), _reachabilityAnalysisIntentClientDiagnostics, Pipeline, "ReachabilityAnalysisIntentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets list of Reachability Analysis Intents .
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Optional skip token. </param>
        /// <param name="skip"> Optional num entries to skip. </param>
        /// <param name="top"> Optional num entries to show. </param>
        /// <param name="sortKey"> Optional key by which to sort. </param>
        /// <param name="sortValue"> Optional sort value for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReachabilityAnalysisIntentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReachabilityAnalysisIntentResource> GetAll(string skipToken = null, int? skip = null, int? top = null, string sortKey = null, string sortValue = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reachabilityAnalysisIntentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, skip, top, sortKey, sortValue);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reachabilityAnalysisIntentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, skip, top, sortKey, sortValue);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReachabilityAnalysisIntentResource(Client, ReachabilityAnalysisIntentData.DeserializeReachabilityAnalysisIntentData(e)), _reachabilityAnalysisIntentClientDiagnostics, Pipeline, "ReachabilityAnalysisIntentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string reachabilityAnalysisIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _reachabilityAnalysisIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> is null. </exception>
        public virtual Response<bool> Exists(string reachabilityAnalysisIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = _reachabilityAnalysisIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> is null. </exception>
        public virtual async Task<NullableResponse<ReachabilityAnalysisIntentResource>> GetIfExistsAsync(string reachabilityAnalysisIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _reachabilityAnalysisIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ReachabilityAnalysisIntentResource>(response.GetRawResponse());
                return Response.FromValue(new ReachabilityAnalysisIntentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/verifierWorkspaces/{workspaceName}/reachabilityAnalysisIntents/{reachabilityAnalysisIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReachabilityAnalysisIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReachabilityAnalysisIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reachabilityAnalysisIntentName"> Reachability Analysis Intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reachabilityAnalysisIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reachabilityAnalysisIntentName"/> is null. </exception>
        public virtual NullableResponse<ReachabilityAnalysisIntentResource> GetIfExists(string reachabilityAnalysisIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reachabilityAnalysisIntentName, nameof(reachabilityAnalysisIntentName));

            using var scope = _reachabilityAnalysisIntentClientDiagnostics.CreateScope("ReachabilityAnalysisIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _reachabilityAnalysisIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reachabilityAnalysisIntentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ReachabilityAnalysisIntentResource>(response.GetRawResponse());
                return Response.FromValue(new ReachabilityAnalysisIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReachabilityAnalysisIntentResource> IEnumerable<ReachabilityAnalysisIntentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReachabilityAnalysisIntentResource> IAsyncEnumerable<ReachabilityAnalysisIntentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
