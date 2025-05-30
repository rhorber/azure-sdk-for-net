// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RulesCreate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Rules_Create.json
            // this example is just showing the usage of "FrontDoorRules_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // get the collection of this FrontDoorRuleResource
            FrontDoorRuleCollection collection = frontDoorRuleSet.GetFrontDoorRules();

            // invoke the operation
            string ruleName = "rule1";
            FrontDoorRuleData data = new FrontDoorRuleData
            {
                Order = 1,
                Conditions = {new DeliveryRuleRequestMethodCondition(new RequestMethodMatchCondition(RequestMethodOperator.Equal)
{
NegateCondition = false,
MatchValues = {RequestMethodMatchConditionMatchValue.Get},
})},
                Actions = {new DeliveryRuleResponseHeaderAction(new HeaderActionProperties(HeaderAction.Overwrite, "X-CDN")
{
Value = "MSFT",
})},
            };
            ArmOperation<FrontDoorRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleName, data);
            FrontDoorRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RulesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Rules_Get.json
            // this example is just showing the usage of "FrontDoorRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // get the collection of this FrontDoorRuleResource
            FrontDoorRuleCollection collection = frontDoorRuleSet.GetFrontDoorRules();

            // invoke the operation
            string ruleName = "rule1";
            FrontDoorRuleResource result = await collection.GetAsync(ruleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RulesListByRuleSet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Rules_ListByRuleSet.json
            // this example is just showing the usage of "FrontDoorRules_ListByRuleSet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // get the collection of this FrontDoorRuleResource
            FrontDoorRuleCollection collection = frontDoorRuleSet.GetFrontDoorRules();

            // invoke the operation and iterate over the result
            await foreach (FrontDoorRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RulesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Rules_Get.json
            // this example is just showing the usage of "FrontDoorRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // get the collection of this FrontDoorRuleResource
            FrontDoorRuleCollection collection = frontDoorRuleSet.GetFrontDoorRules();

            // invoke the operation
            string ruleName = "rule1";
            bool result = await collection.ExistsAsync(ruleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RulesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Rules_Get.json
            // this example is just showing the usage of "FrontDoorRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // get the collection of this FrontDoorRuleResource
            FrontDoorRuleCollection collection = frontDoorRuleSet.GetFrontDoorRules();

            // invoke the operation
            string ruleName = "rule1";
            NullableResponse<FrontDoorRuleResource> response = await collection.GetIfExistsAsync(ruleName);
            FrontDoorRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
