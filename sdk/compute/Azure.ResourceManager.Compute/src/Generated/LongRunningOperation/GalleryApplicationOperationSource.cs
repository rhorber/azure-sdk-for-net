// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    internal class GalleryApplicationOperationSource : IOperationSource<GalleryApplicationResource>
    {
        private readonly ArmClient _client;

        internal GalleryApplicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        GalleryApplicationResource IOperationSource<GalleryApplicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GalleryApplicationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerComputeContext.Default);
            return new GalleryApplicationResource(_client, data);
        }

        async ValueTask<GalleryApplicationResource> IOperationSource<GalleryApplicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GalleryApplicationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerComputeContext.Default);
            return await Task.FromResult(new GalleryApplicationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
