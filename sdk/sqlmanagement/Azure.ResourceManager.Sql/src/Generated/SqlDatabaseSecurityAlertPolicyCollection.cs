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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlDatabaseSecurityAlertPolicyResource"/> and their operations.
    /// Each <see cref="SqlDatabaseSecurityAlertPolicyResource"/> in the collection will belong to the same instance of <see cref="SqlDatabaseResource"/>.
    /// To get a <see cref="SqlDatabaseSecurityAlertPolicyCollection"/> instance call the GetSqlDatabaseSecurityAlertPolicies method from an instance of <see cref="SqlDatabaseResource"/>.
    /// </summary>
    public partial class SqlDatabaseSecurityAlertPolicyCollection : ArmCollection, IEnumerable<SqlDatabaseSecurityAlertPolicyResource>, IAsyncEnumerable<SqlDatabaseSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics;
        private readonly DatabaseSecurityAlertPoliciesRestOperations _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected SqlDatabaseSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlDatabaseSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlDatabaseSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlDatabaseSecurityAlertPolicyResource.ResourceType, out string sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesApiVersion);
            _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient = new DatabaseSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlDatabaseSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlSecurityAlertPolicyName securityAlertPolicyName, SqlDatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var uri = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<SqlDatabaseSecurityAlertPolicyResource>(Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlDatabaseSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SqlSecurityAlertPolicyName securityAlertPolicyName, SqlDatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var uri = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<SqlDatabaseSecurityAlertPolicyResource>(Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlDatabaseSecurityAlertPolicyResource>> GetAsync(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlDatabaseSecurityAlertPolicyResource> Get(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database's security alert policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlDatabaseSecurityAlertPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlDatabaseSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlDatabaseSecurityAlertPolicyResource(Client, SqlDatabaseSecurityAlertPolicyData.DeserializeSqlDatabaseSecurityAlertPolicyData(e)), _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics, Pipeline, "SqlDatabaseSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of database's security alert policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlDatabaseSecurityAlertPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlDatabaseSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlDatabaseSecurityAlertPolicyResource(Client, SqlDatabaseSecurityAlertPolicyData.DeserializeSqlDatabaseSecurityAlertPolicyData(e)), _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics, Pipeline, "SqlDatabaseSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SqlDatabaseSecurityAlertPolicyResource>> GetIfExistsAsync(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlDatabaseSecurityAlertPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SqlDatabaseSecurityAlertPolicyResource> GetIfExists(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlDatabaseSecurityAlertPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlDatabaseSecurityAlertPolicyResource> IEnumerable<SqlDatabaseSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlDatabaseSecurityAlertPolicyResource> IAsyncEnumerable<SqlDatabaseSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
