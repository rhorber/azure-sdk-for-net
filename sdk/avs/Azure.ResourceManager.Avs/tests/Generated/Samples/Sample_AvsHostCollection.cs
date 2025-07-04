// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_AvsHostCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_HostsGet()
        {
            // Generated from example definition: 2024-09-01/Hosts_Get.json
            // this example is just showing the usage of "Host_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsHostResource
            AvsHostCollection collection = avsPrivateCloudCluster.GetAvsHosts();

            // invoke the operation
            string hostId = "esx03-r52.1111111111111111111.westcentralus.prod.azure.com";
            AvsHostResource result = await collection.GetAsync(hostId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_HostsList()
        {
            // Generated from example definition: 2024-09-01/Hosts_List.json
            // this example is just showing the usage of "Host_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsHostResource
            AvsHostCollection collection = avsPrivateCloudCluster.GetAvsHosts();

            // invoke the operation and iterate over the result
            await foreach (AvsHostResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsHostData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_HostsGet()
        {
            // Generated from example definition: 2024-09-01/Hosts_Get.json
            // this example is just showing the usage of "Host_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsHostResource
            AvsHostCollection collection = avsPrivateCloudCluster.GetAvsHosts();

            // invoke the operation
            string hostId = "esx03-r52.1111111111111111111.westcentralus.prod.azure.com";
            bool result = await collection.ExistsAsync(hostId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_HostsGet()
        {
            // Generated from example definition: 2024-09-01/Hosts_Get.json
            // this example is just showing the usage of "Host_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsHostResource
            AvsHostCollection collection = avsPrivateCloudCluster.GetAvsHosts();

            // invoke the operation
            string hostId = "esx03-r52.1111111111111111111.westcentralus.prod.azure.com";
            NullableResponse<AvsHostResource> response = await collection.GetIfExistsAsync(hostId);
            AvsHostResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsHostData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
