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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="PolicyRestrictionContractResource"/> and their operations.
    /// Each <see cref="PolicyRestrictionContractResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get a <see cref="PolicyRestrictionContractCollection"/> instance call the GetPolicyRestrictionContracts method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class PolicyRestrictionContractCollection : ArmCollection, IEnumerable<PolicyRestrictionContractResource>, IAsyncEnumerable<PolicyRestrictionContractResource>
    {
        private readonly ClientDiagnostics _policyRestrictionContractPolicyRestrictionClientDiagnostics;
        private readonly PolicyRestrictionRestOperations _policyRestrictionContractPolicyRestrictionRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyRestrictionContractCollection"/> class for mocking. </summary>
        protected PolicyRestrictionContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyRestrictionContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PolicyRestrictionContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyRestrictionContractPolicyRestrictionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", PolicyRestrictionContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PolicyRestrictionContractResource.ResourceType, out string policyRestrictionContractPolicyRestrictionApiVersion);
            _policyRestrictionContractPolicyRestrictionRestClient = new PolicyRestrictionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyRestrictionContractPolicyRestrictionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the policy restriction configuration of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="data"> The policy restriction to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyRestrictionContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyRestrictionId, PolicyRestrictionContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyRestrictionContractPolicyRestrictionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _policyRestrictionContractPolicyRestrictionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<PolicyRestrictionContractResource>(Response.FromValue(new PolicyRestrictionContractResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates the policy restriction configuration of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="data"> The policy restriction to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyRestrictionContractResource> CreateOrUpdate(WaitUntil waitUntil, string policyRestrictionId, PolicyRestrictionContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyRestrictionContractPolicyRestrictionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, data, ifMatch, cancellationToken);
                var uri = _policyRestrictionContractPolicyRestrictionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<PolicyRestrictionContractResource>(Response.FromValue(new PolicyRestrictionContractResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get the policy restriction of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> is null. </exception>
        public virtual async Task<Response<PolicyRestrictionContractResource>> GetAsync(string policyRestrictionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyRestrictionContractPolicyRestrictionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyRestrictionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy restriction of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> is null. </exception>
        public virtual Response<PolicyRestrictionContractResource> Get(string policyRestrictionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.Get");
            scope.Start();
            try
            {
                var response = _policyRestrictionContractPolicyRestrictionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyRestrictionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all policy restrictions of API Management services.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyRestrictionContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyRestrictionContractResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _policyRestrictionContractPolicyRestrictionRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyRestrictionContractPolicyRestrictionRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PolicyRestrictionContractResource(Client, PolicyRestrictionContractData.DeserializePolicyRestrictionContractData(e)), _policyRestrictionContractPolicyRestrictionClientDiagnostics, Pipeline, "PolicyRestrictionContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all policy restrictions of API Management services.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyRestrictionContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyRestrictionContractResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _policyRestrictionContractPolicyRestrictionRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyRestrictionContractPolicyRestrictionRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PolicyRestrictionContractResource(Client, PolicyRestrictionContractData.DeserializePolicyRestrictionContractData(e)), _policyRestrictionContractPolicyRestrictionClientDiagnostics, Pipeline, "PolicyRestrictionContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyRestrictionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _policyRestrictionContractPolicyRestrictionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> is null. </exception>
        public virtual Response<bool> Exists(string policyRestrictionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _policyRestrictionContractPolicyRestrictionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> is null. </exception>
        public virtual async Task<NullableResponse<PolicyRestrictionContractResource>> GetIfExistsAsync(string policyRestrictionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _policyRestrictionContractPolicyRestrictionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PolicyRestrictionContractResource>(response.GetRawResponse());
                return Response.FromValue(new PolicyRestrictionContractResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyRestrictions/{policyRestrictionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestriction_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRestrictionContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyRestrictionId"> Policy restrictions after an entity level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyRestrictionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyRestrictionId"/> is null. </exception>
        public virtual NullableResponse<PolicyRestrictionContractResource> GetIfExists(string policyRestrictionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyRestrictionId, nameof(policyRestrictionId));

            using var scope = _policyRestrictionContractPolicyRestrictionClientDiagnostics.CreateScope("PolicyRestrictionContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _policyRestrictionContractPolicyRestrictionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyRestrictionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PolicyRestrictionContractResource>(response.GetRawResponse());
                return Response.FromValue(new PolicyRestrictionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PolicyRestrictionContractResource> IEnumerable<PolicyRestrictionContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PolicyRestrictionContractResource> IAsyncEnumerable<PolicyRestrictionContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
