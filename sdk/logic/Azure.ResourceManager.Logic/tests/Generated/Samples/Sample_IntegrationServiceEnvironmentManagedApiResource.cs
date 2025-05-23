// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationServiceEnvironmentManagedApiResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheIntegrationServiceEnvironmentManagedApis()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_ManagedApis_Get.json
            // this example is just showing the usage of "IntegrationServiceEnvironmentManagedApis_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentManagedApiResource created on azure
            // for more information of creating IntegrationServiceEnvironmentManagedApiResource, please refer to the document of IntegrationServiceEnvironmentManagedApiResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            string apiName = "servicebus";
            ResourceIdentifier integrationServiceEnvironmentManagedApiResourceId = IntegrationServiceEnvironmentManagedApiResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            IntegrationServiceEnvironmentManagedApiResource integrationServiceEnvironmentManagedApi = client.GetIntegrationServiceEnvironmentManagedApiResource(integrationServiceEnvironmentManagedApiResourceId);

            // invoke the operation
            IntegrationServiceEnvironmentManagedApiResource result = await integrationServiceEnvironmentManagedApi.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationServiceEnvironmentManagedApiData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesTheIntegrationServiceEnvironmentManagedApis()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_ManagedApis_Delete.json
            // this example is just showing the usage of "IntegrationServiceEnvironmentManagedApis_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentManagedApiResource created on azure
            // for more information of creating IntegrationServiceEnvironmentManagedApiResource, please refer to the document of IntegrationServiceEnvironmentManagedApiResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            string apiName = "servicebus";
            ResourceIdentifier integrationServiceEnvironmentManagedApiResourceId = IntegrationServiceEnvironmentManagedApiResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            IntegrationServiceEnvironmentManagedApiResource integrationServiceEnvironmentManagedApi = client.GetIntegrationServiceEnvironmentManagedApiResource(integrationServiceEnvironmentManagedApiResourceId);

            // invoke the operation
            await integrationServiceEnvironmentManagedApi.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_GetsTheIntegrationServiceEnvironmentManagedApis()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_ManagedApis_Put.json
            // this example is just showing the usage of "IntegrationServiceEnvironmentManagedApis_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentManagedApiResource created on azure
            // for more information of creating IntegrationServiceEnvironmentManagedApiResource, please refer to the document of IntegrationServiceEnvironmentManagedApiResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            string apiName = "servicebus";
            ResourceIdentifier integrationServiceEnvironmentManagedApiResourceId = IntegrationServiceEnvironmentManagedApiResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            IntegrationServiceEnvironmentManagedApiResource integrationServiceEnvironmentManagedApi = client.GetIntegrationServiceEnvironmentManagedApiResource(integrationServiceEnvironmentManagedApiResourceId);

            // invoke the operation
            IntegrationServiceEnvironmentManagedApiData data = new IntegrationServiceEnvironmentManagedApiData(new AzureLocation("brazilsouth"));
            ArmOperation<IntegrationServiceEnvironmentManagedApiResource> lro = await integrationServiceEnvironmentManagedApi.UpdateAsync(WaitUntil.Completed, data);
            IntegrationServiceEnvironmentManagedApiResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationServiceEnvironmentManagedApiData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIntegrationServiceEnvironmentManagedApiOperations_GetsTheIntegrationServiceEnvironmentManagedApis()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_ManagedApis_ListApiOperations.json
            // this example is just showing the usage of "IntegrationServiceEnvironmentManagedApiOperations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentManagedApiResource created on azure
            // for more information of creating IntegrationServiceEnvironmentManagedApiResource, please refer to the document of IntegrationServiceEnvironmentManagedApiResource
            string subscriptionId = "80d4fe69-c95b-4dd2-a938-9250f1c8ab03";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            string apiName = "servicebus";
            ResourceIdentifier integrationServiceEnvironmentManagedApiResourceId = IntegrationServiceEnvironmentManagedApiResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            IntegrationServiceEnvironmentManagedApiResource integrationServiceEnvironmentManagedApi = client.GetIntegrationServiceEnvironmentManagedApiResource(integrationServiceEnvironmentManagedApiResourceId);

            // invoke the operation and iterate over the result
            await foreach (LogicApiOperationInfo item in integrationServiceEnvironmentManagedApi.GetIntegrationServiceEnvironmentManagedApiOperationsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
