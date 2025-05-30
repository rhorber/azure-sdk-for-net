// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Quota.Samples
{
    public partial class Sample_CurrentUsagesBaseResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotasUsagesRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/stable/2025-03-01/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CurrentUsagesBaseResource created on azure
            // for more information of creating CurrentUsagesBaseResource, please refer to the document of CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            string resourceName = "standardNDSFamily";
            ResourceIdentifier currentUsagesBaseResourceId = CurrentUsagesBaseResource.CreateResourceIdentifier(scope, resourceName);
            CurrentUsagesBaseResource currentUsagesBase = client.GetCurrentUsagesBaseResource(currentUsagesBaseResourceId);

            // invoke the operation
            CurrentUsagesBaseResource result = await currentUsagesBase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CurrentUsagesBaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotasUsagesRequestForNetwork()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/stable/2025-03-01/examples/getNetworkOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CurrentUsagesBaseResource created on azure
            // for more information of creating CurrentUsagesBaseResource, please refer to the document of CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/locations/eastus";
            string resourceName = "MinPublicIpInterNetworkPrefixLength";
            ResourceIdentifier currentUsagesBaseResourceId = CurrentUsagesBaseResource.CreateResourceIdentifier(scope, resourceName);
            CurrentUsagesBaseResource currentUsagesBase = client.GetCurrentUsagesBaseResource(currentUsagesBaseResourceId);

            // invoke the operation
            CurrentUsagesBaseResource result = await currentUsagesBase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CurrentUsagesBaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
