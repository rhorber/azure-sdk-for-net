// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceApiPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceApiPolicy.json
            // this example is just showing the usage of "WorkspaceApiPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiPolicyResource, please refer to the document of ServiceWorkspaceApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "5600b59475ff190048040001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiPolicyResourceId = ServiceWorkspaceApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, policyId);
            ServiceWorkspaceApiPolicyResource serviceWorkspaceApiPolicy = client.GetServiceWorkspaceApiPolicyResource(serviceWorkspaceApiPolicyResourceId);

            // invoke the operation
            ServiceWorkspaceApiPolicyResource result = await serviceWorkspaceApiPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteWorkspaceApiPolicy.json
            // this example is just showing the usage of "WorkspaceApiPolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiPolicyResource, please refer to the document of ServiceWorkspaceApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "loggerId";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiPolicyResourceId = ServiceWorkspaceApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, policyId);
            ServiceWorkspaceApiPolicyResource serviceWorkspaceApiPolicy = client.GetServiceWorkspaceApiPolicyResource(serviceWorkspaceApiPolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceApiPolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspaceApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceApiPolicy.json
            // this example is just showing the usage of "WorkspaceApiPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiPolicyResource, please refer to the document of ServiceWorkspaceApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "5600b57e7e8880006a040001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiPolicyResourceId = ServiceWorkspaceApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, policyId);
            ServiceWorkspaceApiPolicyResource serviceWorkspaceApiPolicy = client.GetServiceWorkspaceApiPolicyResource(serviceWorkspaceApiPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData
            {
                Value = "<policies> <inbound /> <backend>    <forward-request />  </backend>  <outbound /></policies>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ServiceWorkspaceApiPolicyResource> lro = await serviceWorkspaceApiPolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ServiceWorkspaceApiPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadWorkspaceApiPolicy.json
            // this example is just showing the usage of "WorkspaceApiPolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiPolicyResource, please refer to the document of ServiceWorkspaceApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiPolicyResourceId = ServiceWorkspaceApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, policyId);
            ServiceWorkspaceApiPolicyResource serviceWorkspaceApiPolicy = client.GetServiceWorkspaceApiPolicyResource(serviceWorkspaceApiPolicyResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceApiPolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
