﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

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
    /// A class representing a collection of <see cref="ServiceObjectiveResource"/> and their operations.
    /// Each <see cref="ServiceObjectiveResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="ServiceObjectiveCollection"/> instance call the GetServiceObjectives method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class ServiceObjectiveCollection : ArmCollection, IEnumerable<ServiceObjectiveResource>, IAsyncEnumerable<ServiceObjectiveResource>
    {
        private readonly ClientDiagnostics _serviceObjectiveClientDiagnostics;
        private readonly ServiceObjectivesRestOperations _serviceObjectiveRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceObjectiveCollection"/> class for mocking. </summary>
        protected ServiceObjectiveCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceObjectiveCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceObjectiveCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceObjectiveClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServiceObjectiveResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceObjectiveResource.ResourceType, out string serviceObjectiveApiVersion);
            _serviceObjectiveRestClient = new ServiceObjectivesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceObjectiveApiVersion);
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
        /// Gets a database service objective.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual async Task<Response<ServiceObjectiveResource>> GetAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceObjectiveRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database service objective.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<ServiceObjectiveResource> Get(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceObjectiveRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns database service objectives.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceObjectiveResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceObjectiveResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceObjectiveRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ServiceObjectiveResource(Client, ServiceObjectiveData.DeserializeServiceObjectiveData(e)), _serviceObjectiveClientDiagnostics, Pipeline, "ServiceObjectiveCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns database service objectives.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceObjectiveResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceObjectiveResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceObjectiveRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ServiceObjectiveResource(Client, ServiceObjectiveData.DeserializeServiceObjectiveData(e)), _serviceObjectiveClientDiagnostics, Pipeline, "ServiceObjectiveCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceObjectiveRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceObjectiveRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceObjectiveResource>> GetIfExistsAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceObjectiveRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceObjectiveResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceObjectives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceObjectiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual NullableResponse<ServiceObjectiveResource> GetIfExists(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceObjectiveRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceObjectiveResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceObjectiveResource> IEnumerable<ServiceObjectiveResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceObjectiveResource> IAsyncEnumerable<ServiceObjectiveResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
