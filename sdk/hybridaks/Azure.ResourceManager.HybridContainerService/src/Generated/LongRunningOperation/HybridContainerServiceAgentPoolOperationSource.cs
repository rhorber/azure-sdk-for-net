// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService
{
    internal class HybridContainerServiceAgentPoolOperationSource : IOperationSource<HybridContainerServiceAgentPoolResource>
    {
        private readonly ArmClient _client;

        internal HybridContainerServiceAgentPoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        HybridContainerServiceAgentPoolResource IOperationSource<HybridContainerServiceAgentPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HybridContainerServiceAgentPoolData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHybridContainerServiceContext.Default);
            return new HybridContainerServiceAgentPoolResource(_client, data);
        }

        async ValueTask<HybridContainerServiceAgentPoolResource> IOperationSource<HybridContainerServiceAgentPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HybridContainerServiceAgentPoolData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHybridContainerServiceContext.Default);
            return await Task.FromResult(new HybridContainerServiceAgentPoolResource(_client, data)).ConfigureAwait(false);
        }
    }
}
