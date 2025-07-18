// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_SnapshotPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SnapshotPoliciesCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/SnapshotPolicies_Create.json
            // this example is just showing the usage of "SnapshotPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this SnapshotPolicyResource
            SnapshotPolicyCollection collection = netAppAccount.GetSnapshotPolicies();

            // invoke the operation
            string snapshotPolicyName = "snapshotPolicyName";
            SnapshotPolicyData data = new SnapshotPolicyData(new AzureLocation("eastus"))
            {
                HourlySchedule = new SnapshotPolicyHourlySchedule
                {
                    SnapshotsToKeep = 2,
                    Minute = 50,
                },
                DailySchedule = new SnapshotPolicyDailySchedule
                {
                    SnapshotsToKeep = 4,
                    Hour = 14,
                    Minute = 30,
                },
                WeeklySchedule = new SnapshotPolicyWeeklySchedule
                {
                    SnapshotsToKeep = 3,
                    Day = "Wednesday",
                    Hour = 14,
                    Minute = 45,
                },
                MonthlySchedule = new SnapshotPolicyMonthlySchedule
                {
                    SnapshotsToKeep = 5,
                    DaysOfMonth = "10,11,12",
                    Hour = 14,
                    Minute = 15,
                },
                IsEnabled = true,
            };
            ArmOperation<SnapshotPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotPolicyName, data);
            SnapshotPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SnapshotPoliciesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/SnapshotPolicies_Get.json
            // this example is just showing the usage of "SnapshotPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this SnapshotPolicyResource
            SnapshotPolicyCollection collection = netAppAccount.GetSnapshotPolicies();

            // invoke the operation
            string snapshotPolicyName = "snapshotPolicyName";
            SnapshotPolicyResource result = await collection.GetAsync(snapshotPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SnapshotPoliciesList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/SnapshotPolicies_List.json
            // this example is just showing the usage of "SnapshotPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this SnapshotPolicyResource
            SnapshotPolicyCollection collection = netAppAccount.GetSnapshotPolicies();

            // invoke the operation and iterate over the result
            await foreach (SnapshotPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SnapshotPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SnapshotPoliciesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/SnapshotPolicies_Get.json
            // this example is just showing the usage of "SnapshotPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this SnapshotPolicyResource
            SnapshotPolicyCollection collection = netAppAccount.GetSnapshotPolicies();

            // invoke the operation
            string snapshotPolicyName = "snapshotPolicyName";
            bool result = await collection.ExistsAsync(snapshotPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SnapshotPoliciesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/SnapshotPolicies_Get.json
            // this example is just showing the usage of "SnapshotPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this SnapshotPolicyResource
            SnapshotPolicyCollection collection = netAppAccount.GetSnapshotPolicies();

            // invoke the operation
            string snapshotPolicyName = "snapshotPolicyName";
            NullableResponse<SnapshotPolicyResource> response = await collection.GetIfExistsAsync(snapshotPolicyName);
            SnapshotPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SnapshotPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
