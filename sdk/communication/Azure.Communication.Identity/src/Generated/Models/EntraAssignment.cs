// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Identity.Models
{
    /// <summary> The EntraAssignment. </summary>
    internal partial class EntraAssignment
    {
        /// <summary> Initializes a new instance of <see cref="EntraAssignment"/>. </summary>
        /// <param name="objectId"></param>
        /// <param name="tenantId"></param>
        /// <param name="principalType"></param>
        /// <param name="clientIds"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/>, <paramref name="tenantId"/> or <paramref name="clientIds"/> is null. </exception>
        internal EntraAssignment(string objectId, string tenantId, EntraPrincipalType principalType, IEnumerable<string> clientIds)
        {
            Argument.AssertNotNull(objectId, nameof(objectId));
            Argument.AssertNotNull(tenantId, nameof(tenantId));
            Argument.AssertNotNull(clientIds, nameof(clientIds));

            ObjectId = objectId;
            TenantId = tenantId;
            PrincipalType = principalType;
            ClientIds = clientIds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="EntraAssignment"/>. </summary>
        /// <param name="objectId"></param>
        /// <param name="tenantId"></param>
        /// <param name="principalType"></param>
        /// <param name="clientIds"></param>
        internal EntraAssignment(string objectId, string tenantId, EntraPrincipalType principalType, IReadOnlyList<string> clientIds)
        {
            ObjectId = objectId;
            TenantId = tenantId;
            PrincipalType = principalType;
            ClientIds = clientIds;
        }

        /// <summary> Gets the object id. </summary>
        public string ObjectId { get; }
        /// <summary> Gets the tenant id. </summary>
        public string TenantId { get; }
        /// <summary> Gets the principal type. </summary>
        public EntraPrincipalType PrincipalType { get; }
        /// <summary> Gets the client ids. </summary>
        public IReadOnlyList<string> ClientIds { get; }
    }
}
