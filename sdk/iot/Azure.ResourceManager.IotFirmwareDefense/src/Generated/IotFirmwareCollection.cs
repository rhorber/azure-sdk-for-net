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

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary>
    /// A class representing a collection of <see cref="IotFirmwareResource"/> and their operations.
    /// Each <see cref="IotFirmwareResource"/> in the collection will belong to the same instance of <see cref="FirmwareAnalysisWorkspaceResource"/>.
    /// To get an <see cref="IotFirmwareCollection"/> instance call the GetIotFirmwares method from an instance of <see cref="FirmwareAnalysisWorkspaceResource"/>.
    /// </summary>
    public partial class IotFirmwareCollection : ArmCollection, IEnumerable<IotFirmwareResource>, IAsyncEnumerable<IotFirmwareResource>
    {
        private readonly ClientDiagnostics _iotFirmwareFirmwaresClientDiagnostics;
        private readonly FirmwaresRestOperations _iotFirmwareFirmwaresRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotFirmwareCollection"/> class for mocking. </summary>
        protected IotFirmwareCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotFirmwareCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotFirmwareCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotFirmwareFirmwaresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotFirmwareDefense", IotFirmwareResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotFirmwareResource.ResourceType, out string iotFirmwareFirmwaresApiVersion);
            _iotFirmwareFirmwaresRestClient = new FirmwaresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotFirmwareFirmwaresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FirmwareAnalysisWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FirmwareAnalysisWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="data"> Details of the firmware being created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotFirmwareResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firmwareId, IotFirmwareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotFirmwareFirmwaresRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, data, cancellationToken).ConfigureAwait(false);
                var uri = _iotFirmwareFirmwaresRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new IotFirmwareDefenseArmOperation<IotFirmwareResource>(Response.FromValue(new IotFirmwareResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// The operation to create a firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="data"> Details of the firmware being created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotFirmwareResource> CreateOrUpdate(WaitUntil waitUntil, string firmwareId, IotFirmwareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotFirmwareFirmwaresRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, data, cancellationToken);
                var uri = _iotFirmwareFirmwaresRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new IotFirmwareDefenseArmOperation<IotFirmwareResource>(Response.FromValue(new IotFirmwareResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> is null. </exception>
        public virtual async Task<Response<IotFirmwareResource>> GetAsync(string firmwareId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotFirmwareFirmwaresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotFirmwareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> is null. </exception>
        public virtual Response<IotFirmwareResource> Get(string firmwareId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.Get");
            scope.Start();
            try
            {
                var response = _iotFirmwareFirmwaresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotFirmwareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of firmwares inside a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotFirmwareResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotFirmwareResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotFirmwareFirmwaresRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotFirmwareFirmwaresRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotFirmwareResource(Client, IotFirmwareData.DeserializeIotFirmwareData(e)), _iotFirmwareFirmwaresClientDiagnostics, Pipeline, "IotFirmwareCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of firmwares inside a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotFirmwareResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotFirmwareResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotFirmwareFirmwaresRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotFirmwareFirmwaresRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotFirmwareResource(Client, IotFirmwareData.DeserializeIotFirmwareData(e)), _iotFirmwareFirmwaresClientDiagnostics, Pipeline, "IotFirmwareCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firmwareId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotFirmwareFirmwaresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> is null. </exception>
        public virtual Response<bool> Exists(string firmwareId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotFirmwareFirmwaresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> is null. </exception>
        public virtual async Task<NullableResponse<IotFirmwareResource>> GetIfExistsAsync(string firmwareId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _iotFirmwareFirmwaresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IotFirmwareResource>(response.GetRawResponse());
                return Response.FromValue(new IotFirmwareResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmwares_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotFirmwareResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareId"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareId"/> is null. </exception>
        public virtual NullableResponse<IotFirmwareResource> GetIfExists(string firmwareId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareId, nameof(firmwareId));

            using var scope = _iotFirmwareFirmwaresClientDiagnostics.CreateScope("IotFirmwareCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _iotFirmwareFirmwaresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IotFirmwareResource>(response.GetRawResponse());
                return Response.FromValue(new IotFirmwareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotFirmwareResource> IEnumerable<IotFirmwareResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotFirmwareResource> IAsyncEnumerable<IotFirmwareResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
