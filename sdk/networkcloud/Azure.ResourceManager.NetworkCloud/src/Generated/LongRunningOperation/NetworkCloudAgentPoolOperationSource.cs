// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudAgentPoolOperationSource : IOperationSource<NetworkCloudAgentPoolResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudAgentPoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudAgentPoolResource IOperationSource<NetworkCloudAgentPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkCloudAgentPoolData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkCloudContext.Default);
            return new NetworkCloudAgentPoolResource(_client, data);
        }

        async ValueTask<NetworkCloudAgentPoolResource> IOperationSource<NetworkCloudAgentPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkCloudAgentPoolData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkCloudContext.Default);
            return await Task.FromResult(new NetworkCloudAgentPoolResource(_client, data)).ConfigureAwait(false);
        }
    }
}
