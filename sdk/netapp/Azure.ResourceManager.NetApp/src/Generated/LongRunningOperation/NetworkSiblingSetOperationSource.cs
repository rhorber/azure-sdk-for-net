// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    internal class NetworkSiblingSetOperationSource : IOperationSource<NetworkSiblingSet>
    {
        NetworkSiblingSet IOperationSource<NetworkSiblingSet>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return NetworkSiblingSet.DeserializeNetworkSiblingSet(document.RootElement);
        }

        async ValueTask<NetworkSiblingSet> IOperationSource<NetworkSiblingSet>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return NetworkSiblingSet.DeserializeNetworkSiblingSet(document.RootElement);
        }
    }
}
