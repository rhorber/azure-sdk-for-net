// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ReachabilityAnalysisIntentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ReachabilityAnalysisIntentCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ReachabilityAnalysisIntentPut.json
            // this example is just showing the usage of "ReachabilityAnalysisIntents_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVerifierWorkspaceResource created on azure
            // for more information of creating NetworkVerifierWorkspaceResource, please refer to the document of NetworkVerifierWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string workspaceName = "testWorkspace";
            ResourceIdentifier networkVerifierWorkspaceResourceId = NetworkVerifierWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, workspaceName);
            NetworkVerifierWorkspaceResource networkVerifierWorkspace = client.GetNetworkVerifierWorkspaceResource(networkVerifierWorkspaceResourceId);

            // get the collection of this ReachabilityAnalysisIntentResource
            ReachabilityAnalysisIntentCollection collection = networkVerifierWorkspace.GetReachabilityAnalysisIntents();

            // invoke the operation
            string reachabilityAnalysisIntentName = "testAnalysisIntentName";
            ReachabilityAnalysisIntentData data = new ReachabilityAnalysisIntentData(new ReachabilityAnalysisIntentProperties(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/testVmSrc"), new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/testVmDest"), new NetworkVerifierIPTraffic(new string[] { "10.4.0.0" }, new string[] { "10.4.0.1" }, new string[] { "0" }, new string[] { "0" }, new NetworkProtocol[] { NetworkProtocol.Any }))
            {
                Description = "A sample reachability analysis intent",
            });
            ArmOperation<ReachabilityAnalysisIntentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, reachabilityAnalysisIntentName, data);
            ReachabilityAnalysisIntentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReachabilityAnalysisIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ReachabilityAnalysisIntentGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ReachabilityAnalysisIntentGet.json
            // this example is just showing the usage of "ReachabilityAnalysisIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVerifierWorkspaceResource created on azure
            // for more information of creating NetworkVerifierWorkspaceResource, please refer to the document of NetworkVerifierWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string workspaceName = "testWorkspace";
            ResourceIdentifier networkVerifierWorkspaceResourceId = NetworkVerifierWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, workspaceName);
            NetworkVerifierWorkspaceResource networkVerifierWorkspace = client.GetNetworkVerifierWorkspaceResource(networkVerifierWorkspaceResourceId);

            // get the collection of this ReachabilityAnalysisIntentResource
            ReachabilityAnalysisIntentCollection collection = networkVerifierWorkspace.GetReachabilityAnalysisIntents();

            // invoke the operation
            string reachabilityAnalysisIntentName = "testAnalysisIntentName";
            ReachabilityAnalysisIntentResource result = await collection.GetAsync(reachabilityAnalysisIntentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReachabilityAnalysisIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ReachabilityAnalysisIntentList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ReachabilityAnalysisIntentList.json
            // this example is just showing the usage of "ReachabilityAnalysisIntents_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVerifierWorkspaceResource created on azure
            // for more information of creating NetworkVerifierWorkspaceResource, please refer to the document of NetworkVerifierWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string workspaceName = "testVerifierWorkspace1";
            ResourceIdentifier networkVerifierWorkspaceResourceId = NetworkVerifierWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, workspaceName);
            NetworkVerifierWorkspaceResource networkVerifierWorkspace = client.GetNetworkVerifierWorkspaceResource(networkVerifierWorkspaceResourceId);

            // get the collection of this ReachabilityAnalysisIntentResource
            ReachabilityAnalysisIntentCollection collection = networkVerifierWorkspace.GetReachabilityAnalysisIntents();

            // invoke the operation and iterate over the result
            await foreach (ReachabilityAnalysisIntentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReachabilityAnalysisIntentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ReachabilityAnalysisIntentGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ReachabilityAnalysisIntentGet.json
            // this example is just showing the usage of "ReachabilityAnalysisIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVerifierWorkspaceResource created on azure
            // for more information of creating NetworkVerifierWorkspaceResource, please refer to the document of NetworkVerifierWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string workspaceName = "testWorkspace";
            ResourceIdentifier networkVerifierWorkspaceResourceId = NetworkVerifierWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, workspaceName);
            NetworkVerifierWorkspaceResource networkVerifierWorkspace = client.GetNetworkVerifierWorkspaceResource(networkVerifierWorkspaceResourceId);

            // get the collection of this ReachabilityAnalysisIntentResource
            ReachabilityAnalysisIntentCollection collection = networkVerifierWorkspace.GetReachabilityAnalysisIntents();

            // invoke the operation
            string reachabilityAnalysisIntentName = "testAnalysisIntentName";
            bool result = await collection.ExistsAsync(reachabilityAnalysisIntentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ReachabilityAnalysisIntentGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ReachabilityAnalysisIntentGet.json
            // this example is just showing the usage of "ReachabilityAnalysisIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVerifierWorkspaceResource created on azure
            // for more information of creating NetworkVerifierWorkspaceResource, please refer to the document of NetworkVerifierWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string workspaceName = "testWorkspace";
            ResourceIdentifier networkVerifierWorkspaceResourceId = NetworkVerifierWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, workspaceName);
            NetworkVerifierWorkspaceResource networkVerifierWorkspace = client.GetNetworkVerifierWorkspaceResource(networkVerifierWorkspaceResourceId);

            // get the collection of this ReachabilityAnalysisIntentResource
            ReachabilityAnalysisIntentCollection collection = networkVerifierWorkspace.GetReachabilityAnalysisIntents();

            // invoke the operation
            string reachabilityAnalysisIntentName = "testAnalysisIntentName";
            NullableResponse<ReachabilityAnalysisIntentResource> response = await collection.GetIfExistsAsync(reachabilityAnalysisIntentName);
            ReachabilityAnalysisIntentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReachabilityAnalysisIntentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
