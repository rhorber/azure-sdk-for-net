// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SelfHelp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SelfHelp.Samples
{
    public partial class Sample_TenantResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DiscoverSolutions_ListDiscoverySolutionsAtResourceScope()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2024-03-01-preview/examples/ListDiscoverySolutionsAtTenantScope.json
            // this example is just showing the usage of "DiscoverySolution_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation and iterate over the result
            string filter = "ProblemClassificationId eq 'SampleProblemClassificationId1'";
            await foreach (SelfHelpSolutionMetadata item in tenantResource.DiscoverSolutionsAsync(filter: filter))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSelfHelpSolutionById_SolutionGet()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2024-03-01-preview/examples/SelfHelpSolution_Get.json
            // this example is just showing the usage of "SolutionSelfHelp_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            string solutionId = "SolutionId1";
            SelfHelpSolutionResult result = await tenantResource.GetSelfHelpSolutionByIdAsync(solutionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DiscoverSolutionsNlp_DiscoverySolutionsUsingIssueSummaryAndServiceId()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2024-03-01-preview/examples/DiscoverSolutionsAtTenantScope.json
            // this example is just showing the usage of "DiscoverySolutionNLP_DiscoverSolutions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation and iterate over the result
            DiscoveryNlpContent content = new DiscoveryNlpContent("how to retrieve certs from deleted keyvault.")
            {
                ServiceId = "0d0fcd2e-c4fd-4349-8497-200edb39s3ca",
            };
            await foreach (SolutionNlpMetadata item in tenantResource.DiscoverSolutionsNlpAsync(content: content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
