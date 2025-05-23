// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using MgmtTypeSpec.Models;

namespace MgmtTypeSpec
{
    internal partial class GetAllPrivateLinkResourcesCollectionResultOfT : Pageable<PrivateLinkResourceData>
    {
        /// <summary> Gets the pages of GetAllPrivateLinkResourcesCollectionResultOfT as an enumerable collection. </summary>
        /// <param name="continuationToken"> The continuation token. </param>
        /// <param name="pageSizeHint"> The page size hint. </param>
        /// <returns> The pages of GetAllPrivateLinkResourcesCollectionResultOfT as an enumerable collection. </returns>
        public override IEnumerable<Page<PrivateLinkResourceData>> AsPages(string continuationToken = null, int? pageSizeHint = null) => throw null;
    }
}
