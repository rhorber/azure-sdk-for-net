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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationFabricResource"/> and their operations.
    /// Each <see cref="DataReplicationFabricResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DataReplicationFabricCollection"/> instance call the GetDataReplicationFabrics method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DataReplicationFabricCollection : ArmCollection, IEnumerable<DataReplicationFabricResource>, IAsyncEnumerable<DataReplicationFabricResource>
    {
        private readonly ClientDiagnostics _dataReplicationFabricFabricClientDiagnostics;
        private readonly FabricRestOperations _dataReplicationFabricFabricRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationFabricCollection"/> class for mocking. </summary>
        protected DataReplicationFabricCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationFabricCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationFabricCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationFabricFabricClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationFabricResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationFabricResource.ResourceType, out string dataReplicationFabricFabricApiVersion);
            _dataReplicationFabricFabricRestClient = new FabricRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationFabricFabricApiVersion);
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
        /// Creates the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="data"> Fabric properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataReplicationFabricResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fabricName, DataReplicationFabricData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataReplicationFabricFabricRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, fabricName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationFabricResource>(new DataReplicationFabricOperationSource(Client), _dataReplicationFabricFabricClientDiagnostics, Pipeline, _dataReplicationFabricFabricRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, fabricName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="data"> Fabric properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataReplicationFabricResource> CreateOrUpdate(WaitUntil waitUntil, string fabricName, DataReplicationFabricData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataReplicationFabricFabricRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, fabricName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationFabricResource>(new DataReplicationFabricOperationSource(Client), _dataReplicationFabricFabricClientDiagnostics, Pipeline, _dataReplicationFabricFabricRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, fabricName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the details of the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationFabricResource>> GetAsync(string fabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationFabricFabricRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fabricName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual Response<DataReplicationFabricResource> Get(string fabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationFabricFabricRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fabricName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of fabrics in the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> Continuation token from the previous call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationFabricResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationFabricResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationFabricFabricRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationFabricFabricRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataReplicationFabricResource(Client, DataReplicationFabricData.DeserializeDataReplicationFabricData(e)), _dataReplicationFabricFabricClientDiagnostics, Pipeline, "DataReplicationFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of fabrics in the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> Continuation token from the previous call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationFabricResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationFabricResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationFabricFabricRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationFabricFabricRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataReplicationFabricResource(Client, DataReplicationFabricData.DeserializeDataReplicationFabricData(e)), _dataReplicationFabricFabricClientDiagnostics, Pipeline, "DataReplicationFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationFabricFabricRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fabricName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual Response<bool> Exists(string fabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationFabricFabricRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fabricName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataReplicationFabricResource>> GetIfExistsAsync(string fabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataReplicationFabricFabricRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fabricName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationFabricResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationFabricResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FabricModel_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual NullableResponse<DataReplicationFabricResource> GetIfExists(string fabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _dataReplicationFabricFabricClientDiagnostics.CreateScope("DataReplicationFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataReplicationFabricFabricRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fabricName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationFabricResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationFabricResource> IEnumerable<DataReplicationFabricResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationFabricResource> IAsyncEnumerable<DataReplicationFabricResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
