// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Quota
{
    internal class SubscriptionQuotaAllocationsListOperationSource : IOperationSource<SubscriptionQuotaAllocationsListResource>
    {
        private readonly ArmClient _client;

        internal SubscriptionQuotaAllocationsListOperationSource(ArmClient client)
        {
            _client = client;
        }

        SubscriptionQuotaAllocationsListResource IOperationSource<SubscriptionQuotaAllocationsListResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SubscriptionQuotaAllocationsListData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerQuotaContext.Default);
            return new SubscriptionQuotaAllocationsListResource(_client, data);
        }

        async ValueTask<SubscriptionQuotaAllocationsListResource> IOperationSource<SubscriptionQuotaAllocationsListResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SubscriptionQuotaAllocationsListData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerQuotaContext.Default);
            return await Task.FromResult(new SubscriptionQuotaAllocationsListResource(_client, data)).ConfigureAwait(false);
        }
    }
}
