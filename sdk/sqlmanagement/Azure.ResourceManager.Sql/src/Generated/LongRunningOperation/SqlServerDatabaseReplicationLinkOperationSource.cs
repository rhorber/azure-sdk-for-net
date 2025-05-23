// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class SqlServerDatabaseReplicationLinkOperationSource : IOperationSource<SqlServerDatabaseReplicationLinkResource>
    {
        private readonly ArmClient _client;

        internal SqlServerDatabaseReplicationLinkOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerDatabaseReplicationLinkResource IOperationSource<SqlServerDatabaseReplicationLinkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SqlServerDatabaseReplicationLinkData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return new SqlServerDatabaseReplicationLinkResource(_client, data);
        }

        async ValueTask<SqlServerDatabaseReplicationLinkResource> IOperationSource<SqlServerDatabaseReplicationLinkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SqlServerDatabaseReplicationLinkData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return await Task.FromResult(new SqlServerDatabaseReplicationLinkResource(_client, data)).ConfigureAwait(false);
        }
    }
}
