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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerVirtualNetworkRuleResource"/> and their operations.
    /// Each <see cref="SqlServerVirtualNetworkRuleResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerVirtualNetworkRuleCollection"/> instance call the GetSqlServerVirtualNetworkRules method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerVirtualNetworkRuleCollection : ArmCollection, IEnumerable<SqlServerVirtualNetworkRuleResource>, IAsyncEnumerable<SqlServerVirtualNetworkRuleResource>
    {
        private readonly ClientDiagnostics _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics;
        private readonly VirtualNetworkRulesRestOperations _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerVirtualNetworkRuleCollection"/> class for mocking. </summary>
        protected SqlServerVirtualNetworkRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerVirtualNetworkRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerVirtualNetworkRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerVirtualNetworkRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerVirtualNetworkRuleResource.ResourceType, out string sqlServerVirtualNetworkRuleVirtualNetworkRulesApiVersion);
            _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient = new VirtualNetworkRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerVirtualNetworkRuleVirtualNetworkRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an existing virtual network rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="data"> The requested virtual Network Rule Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerVirtualNetworkRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkRuleName, SqlServerVirtualNetworkRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerVirtualNetworkRuleResource>(new SqlServerVirtualNetworkRuleOperationSource(Client), _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing virtual network rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="data"> The requested virtual Network Rule Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerVirtualNetworkRuleResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkRuleName, SqlServerVirtualNetworkRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerVirtualNetworkRuleResource>(new SqlServerVirtualNetworkRuleOperationSource(Client), _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a virtual network rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<SqlServerVirtualNetworkRuleResource>> GetAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerVirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual network rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<SqlServerVirtualNetworkRuleResource> Get(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerVirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of virtual network rules in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerVirtualNetworkRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerVirtualNetworkRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerVirtualNetworkRuleResource(Client, SqlServerVirtualNetworkRuleData.DeserializeSqlServerVirtualNetworkRuleData(e)), _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, "SqlServerVirtualNetworkRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of virtual network rules in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerVirtualNetworkRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerVirtualNetworkRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerVirtualNetworkRuleResource(Client, SqlServerVirtualNetworkRuleData.DeserializeSqlServerVirtualNetworkRuleData(e)), _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, "SqlServerVirtualNetworkRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerVirtualNetworkRuleResource>> GetIfExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerVirtualNetworkRuleResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerVirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerVirtualNetworkRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual NullableResponse<SqlServerVirtualNetworkRuleResource> GetIfExists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _sqlServerVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("SqlServerVirtualNetworkRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerVirtualNetworkRuleVirtualNetworkRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerVirtualNetworkRuleResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerVirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerVirtualNetworkRuleResource> IEnumerable<SqlServerVirtualNetworkRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerVirtualNetworkRuleResource> IAsyncEnumerable<SqlServerVirtualNetworkRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
