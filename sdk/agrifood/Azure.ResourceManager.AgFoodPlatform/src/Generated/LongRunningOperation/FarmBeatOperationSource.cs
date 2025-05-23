// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AgFoodPlatform
{
    internal class FarmBeatOperationSource : IOperationSource<FarmBeatResource>
    {
        private readonly ArmClient _client;

        internal FarmBeatOperationSource(ArmClient client)
        {
            _client = client;
        }

        FarmBeatResource IOperationSource<FarmBeatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FarmBeatData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAgFoodPlatformContext.Default);
            return new FarmBeatResource(_client, data);
        }

        async ValueTask<FarmBeatResource> IOperationSource<FarmBeatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FarmBeatData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAgFoodPlatformContext.Default);
            return await Task.FromResult(new FarmBeatResource(_client, data)).ConfigureAwait(false);
        }
    }
}
