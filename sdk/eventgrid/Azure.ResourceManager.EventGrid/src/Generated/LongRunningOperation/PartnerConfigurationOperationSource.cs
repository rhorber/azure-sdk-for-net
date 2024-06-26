// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class PartnerConfigurationOperationSource : IOperationSource<PartnerConfigurationResource>
    {
        private readonly ArmClient _client;

        internal PartnerConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        PartnerConfigurationResource IOperationSource<PartnerConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PartnerConfigurationData.DeserializePartnerConfigurationData(document.RootElement);
            return new PartnerConfigurationResource(_client, data);
        }

        async ValueTask<PartnerConfigurationResource> IOperationSource<PartnerConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PartnerConfigurationData.DeserializePartnerConfigurationData(document.RootElement);
            return new PartnerConfigurationResource(_client, data);
        }
    }
}
