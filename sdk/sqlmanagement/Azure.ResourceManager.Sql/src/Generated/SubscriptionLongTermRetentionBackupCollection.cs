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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionLongTermRetentionBackupResource"/> and their operations.
    /// Each <see cref="SubscriptionLongTermRetentionBackupResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SubscriptionLongTermRetentionBackupCollection"/> instance call the GetSubscriptionLongTermRetentionBackups method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SubscriptionLongTermRetentionBackupCollection : ArmCollection, IEnumerable<SubscriptionLongTermRetentionBackupResource>, IAsyncEnumerable<SubscriptionLongTermRetentionBackupResource>
    {
        private readonly ClientDiagnostics _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient;
        private readonly AzureLocation _locationName;
        private readonly string _longTermRetentionServerName;
        private readonly string _longTermRetentionDatabaseName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackupCollection"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="longTermRetentionServerName"/> or <paramref name="longTermRetentionDatabaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="longTermRetentionServerName"/> or <paramref name="longTermRetentionDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SubscriptionLongTermRetentionBackupCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName) : base(client, id)
        {
            _locationName = locationName;
            _longTermRetentionServerName = longTermRetentionServerName;
            _longTermRetentionDatabaseName = longTermRetentionDatabaseName;
            _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SubscriptionLongTermRetentionBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionLongTermRetentionBackupResource.ResourceType, out string subscriptionLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
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
        /// Gets a long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionLongTermRetentionBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLongTermRetentionBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all long term retention backups for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionBackupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionLongTermRetentionBackupResource> GetAllAsync(bool? onlyLatestPerDatabase = null, SqlDatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionLongTermRetentionBackupResource(Client, LongTermRetentionBackupData.DeserializeLongTermRetentionBackupData(e)), _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, "SubscriptionLongTermRetentionBackupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all long term retention backups for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionBackupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionLongTermRetentionBackupResource> GetAll(bool? onlyLatestPerDatabase = null, SqlDatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionLongTermRetentionBackupResource(Client, LongTermRetentionBackupData.DeserializeLongTermRetentionBackupData(e)), _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, "SubscriptionLongTermRetentionBackupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<NullableResponse<SubscriptionLongTermRetentionBackupResource>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionLongTermRetentionBackupResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionLongTermRetentionBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual NullableResponse<SubscriptionLongTermRetentionBackupResource> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionLongTermRetentionBackupResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionLongTermRetentionBackupResource> IEnumerable<SubscriptionLongTermRetentionBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionLongTermRetentionBackupResource> IAsyncEnumerable<SubscriptionLongTermRetentionBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
