// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a RestorableDroppedDatabase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RestorableDroppedDatabaseResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRestorableDroppedDatabaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource"/> using the GetRestorableDroppedDatabase method.
    /// </summary>
    public partial class RestorableDroppedDatabaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RestorableDroppedDatabaseResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="restorableDroppedDatabaseId"> The restorableDroppedDatabaseId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string restorableDroppedDatabaseId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _restorableDroppedDatabaseClientDiagnostics;
        private readonly RestorableDroppedDatabasesRestOperations _restorableDroppedDatabaseRestClient;
        private readonly RestorableDroppedDatabaseData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/restorableDroppedDatabases";

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedDatabaseResource"/> class for mocking. </summary>
        protected RestorableDroppedDatabaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedDatabaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RestorableDroppedDatabaseResource(ArmClient client, RestorableDroppedDatabaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedDatabaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RestorableDroppedDatabaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDroppedDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string restorableDroppedDatabaseApiVersion);
            _restorableDroppedDatabaseRestClient = new RestorableDroppedDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableDroppedDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RestorableDroppedDatabaseData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a restorable dropped database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableDroppedDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RestorableDroppedDatabaseResource>> GetAsync(string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseResource.Get");
            scope.Start();
            try
            {
                var response = await _restorableDroppedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a restorable dropped database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableDroppedDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableDroppedDatabaseResource> Get(string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseResource.Get");
            scope.Start();
            try
            {
                var response = _restorableDroppedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
