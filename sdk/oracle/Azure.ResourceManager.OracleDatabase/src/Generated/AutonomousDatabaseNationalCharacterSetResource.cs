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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A Class representing an AutonomousDatabaseNationalCharacterSet along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutonomousDatabaseNationalCharacterSetResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutonomousDatabaseNationalCharacterSetResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetAutonomousDatabaseNationalCharacterSet method.
    /// </summary>
    public partial class AutonomousDatabaseNationalCharacterSetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutonomousDatabaseNationalCharacterSetResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="adbsncharsetname"> The adbsncharsetname. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string adbsncharsetname)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _autonomousDatabaseNationalCharacterSetClientDiagnostics;
        private readonly AutonomousDatabaseNationalCharacterSetsRestOperations _autonomousDatabaseNationalCharacterSetRestClient;
        private readonly AutonomousDatabaseNationalCharacterSetData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Oracle.Database/locations/autonomousDatabaseNationalCharacterSets";

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseNationalCharacterSetResource"/> class for mocking. </summary>
        protected AutonomousDatabaseNationalCharacterSetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseNationalCharacterSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutonomousDatabaseNationalCharacterSetResource(ArmClient client, AutonomousDatabaseNationalCharacterSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseNationalCharacterSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutonomousDatabaseNationalCharacterSetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autonomousDatabaseNationalCharacterSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string autonomousDatabaseNationalCharacterSetApiVersion);
            _autonomousDatabaseNationalCharacterSetRestClient = new AutonomousDatabaseNationalCharacterSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autonomousDatabaseNationalCharacterSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutonomousDatabaseNationalCharacterSetData Data
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
        /// Get a AutonomousDatabaseNationalCharacterSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutonomousDatabaseNationalCharacterSetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetResource.Get");
            scope.Start();
            try
            {
                var response = await _autonomousDatabaseNationalCharacterSetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseNationalCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AutonomousDatabaseNationalCharacterSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutonomousDatabaseNationalCharacterSetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetResource.Get");
            scope.Start();
            try
            {
                var response = _autonomousDatabaseNationalCharacterSetRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseNationalCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
