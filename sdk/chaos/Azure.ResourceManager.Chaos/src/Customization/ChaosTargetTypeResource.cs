﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Azure.Core.Pipeline;
using Azure.Core;
using Azure.ResourceManager.Resources;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A Class representing a ChaosTargetType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ChaosTargetTypeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetChaosTargetTypeResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetChaosTargetType method.
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `ChaosTargetMetadataResource` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ChaosTargetTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ChaosTargetTypeResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="targetTypeName"> The targetTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string targetTypeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _chaosTargetTypeTargetTypesClientDiagnostics;
        private readonly TargetTypesRestOperations _chaosTargetTypeTargetTypesRestClient;
        private readonly ChaosTargetTypeData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Chaos/locations/targetTypes";

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetTypeResource"/> class for mocking. </summary>
        protected ChaosTargetTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ChaosTargetTypeResource(ArmClient client, ChaosTargetTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ChaosTargetTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _chaosTargetTypeTargetTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string chaosTargetTypeTargetTypesApiVersion);
            _chaosTargetTypeTargetTypesRestClient = new TargetTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, chaosTargetTypeTargetTypesApiVersion);
#if DEBUG
            ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ChaosTargetTypeData Data
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

        /// <summary> Gets a collection of ChaosCapabilityTypeResources in the ChaosTargetType. </summary>
        /// <returns> An object representing collection of ChaosCapabilityTypeResources and their operations over a ChaosCapabilityTypeResource. </returns>
        public virtual ChaosCapabilityTypeCollection GetChaosCapabilityTypes()
        {
            return GetCachedClient(client => new ChaosCapabilityTypeCollection(client, Id));
        }

        /// <summary>
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityTypeName"> String that represents a Capability Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="capabilityTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ChaosCapabilityTypeResource>> GetChaosCapabilityTypeAsync(string capabilityTypeName, CancellationToken cancellationToken = default)
        {
            return await GetChaosCapabilityTypes().GetAsync(capabilityTypeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityTypeName"> String that represents a Capability Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="capabilityTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ChaosCapabilityTypeResource> GetChaosCapabilityType(string capabilityTypeName, CancellationToken cancellationToken = default)
        {
            return GetChaosCapabilityTypes().Get(capabilityTypeName, cancellationToken);
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ChaosTargetTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _chaosTargetTypeTargetTypesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                var targetTypeResponse = CustomizationHelper.GetTargetTypeData(response.Value);
                return Response.FromValue(new ChaosTargetTypeResource(Client, targetTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ChaosTargetTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeResource.Get");
            scope.Start();
            try
            {
                var response = _chaosTargetTypeTargetTypesRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                var targetTypeResponse = CustomizationHelper.GetTargetTypeData(response.Value);
                return Response.FromValue(new ChaosTargetTypeResource(Client, targetTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
