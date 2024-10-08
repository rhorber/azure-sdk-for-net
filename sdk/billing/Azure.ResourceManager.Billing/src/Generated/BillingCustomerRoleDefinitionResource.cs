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

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingCustomerRoleDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BillingCustomerRoleDefinitionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBillingCustomerRoleDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="BillingProfileCustomerResource"/> using the GetBillingCustomerRoleDefinition method.
    /// </summary>
    public partial class BillingCustomerRoleDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingCustomerRoleDefinitionResource"/> instance. </summary>
        /// <param name="billingAccountName"> The billingAccountName. </param>
        /// <param name="billingProfileName"> The billingProfileName. </param>
        /// <param name="customerName"> The customerName. </param>
        /// <param name="roleDefinitionName"> The roleDefinitionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName, string roleDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/customers/{customerName}/billingRoleDefinitions/{roleDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingCustomerRoleDefinitionBillingRoleDefinitionClientDiagnostics;
        private readonly BillingRoleDefinitionRestOperations _billingCustomerRoleDefinitionBillingRoleDefinitionRestClient;
        private readonly BillingRoleDefinitionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/billingProfiles/customers/billingRoleDefinitions";

        /// <summary> Initializes a new instance of the <see cref="BillingCustomerRoleDefinitionResource"/> class for mocking. </summary>
        protected BillingCustomerRoleDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingCustomerRoleDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingCustomerRoleDefinitionResource(ArmClient client, BillingRoleDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingCustomerRoleDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingCustomerRoleDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingCustomerRoleDefinitionBillingRoleDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingCustomerRoleDefinitionBillingRoleDefinitionApiVersion);
            _billingCustomerRoleDefinitionBillingRoleDefinitionRestClient = new BillingRoleDefinitionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingCustomerRoleDefinitionBillingRoleDefinitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingRoleDefinitionData Data
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
        /// Gets the definition for a role on a customer. The operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/customers/{customerName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByCustomer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingCustomerRoleDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _billingCustomerRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingCustomerRoleDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _billingCustomerRoleDefinitionBillingRoleDefinitionRestClient.GetByCustomerAsync(Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingCustomerRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the definition for a role on a customer. The operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/customers/{customerName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByCustomer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingCustomerRoleDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _billingCustomerRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingCustomerRoleDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _billingCustomerRoleDefinitionBillingRoleDefinitionRestClient.GetByCustomer(Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingCustomerRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
