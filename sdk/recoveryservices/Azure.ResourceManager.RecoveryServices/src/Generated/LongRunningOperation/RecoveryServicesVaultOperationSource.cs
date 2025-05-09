// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices
{
    internal class RecoveryServicesVaultOperationSource : IOperationSource<RecoveryServicesVaultResource>
    {
        private readonly ArmClient _client;

        internal RecoveryServicesVaultOperationSource(ArmClient client)
        {
            _client = client;
        }

        RecoveryServicesVaultResource IOperationSource<RecoveryServicesVaultResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RecoveryServicesVaultData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerRecoveryServicesContext.Default);
            return new RecoveryServicesVaultResource(_client, data);
        }

        async ValueTask<RecoveryServicesVaultResource> IOperationSource<RecoveryServicesVaultResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RecoveryServicesVaultData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerRecoveryServicesContext.Default);
            return await Task.FromResult(new RecoveryServicesVaultResource(_client, data)).ConfigureAwait(false);
        }
    }
}
