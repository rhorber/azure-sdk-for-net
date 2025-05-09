// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace
{
    internal class DynatraceTagRuleOperationSource : IOperationSource<DynatraceTagRuleResource>
    {
        private readonly ArmClient _client;

        internal DynatraceTagRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        DynatraceTagRuleResource IOperationSource<DynatraceTagRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DynatraceTagRuleData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDynatraceContext.Default);
            return new DynatraceTagRuleResource(_client, data);
        }

        async ValueTask<DynatraceTagRuleResource> IOperationSource<DynatraceTagRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DynatraceTagRuleData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDynatraceContext.Default);
            return await Task.FromResult(new DynatraceTagRuleResource(_client, data)).ConfigureAwait(false);
        }
    }
}
