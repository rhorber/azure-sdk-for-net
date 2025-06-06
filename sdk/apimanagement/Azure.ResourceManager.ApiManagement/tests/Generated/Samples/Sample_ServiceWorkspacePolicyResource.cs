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
    public partial class Sample_ServiceWorkspacePolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspacePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspacePolicy.json
            // this example is just showing the usage of "WorkspacePolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspacePolicyResource created on azure
            // for more information of creating ServiceWorkspacePolicyResource, please refer to the document of ServiceWorkspacePolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspacePolicyResourceId = ServiceWorkspacePolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, policyId);
            ServiceWorkspacePolicyResource serviceWorkspacePolicy = client.GetServiceWorkspacePolicyResource(serviceWorkspacePolicyResourceId);

            // invoke the operation
            ServiceWorkspacePolicyResource result = await serviceWorkspacePolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspacePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteWorkspacePolicy.json
            // this example is just showing the usage of "WorkspacePolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspacePolicyResource created on azure
            // for more information of creating ServiceWorkspacePolicyResource, please refer to the document of ServiceWorkspacePolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspacePolicyResourceId = ServiceWorkspacePolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, policyId);
            ServiceWorkspacePolicyResource serviceWorkspacePolicy = client.GetServiceWorkspacePolicyResource(serviceWorkspacePolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspacePolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspacePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspacePolicy.json
            // this example is just showing the usage of "WorkspacePolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspacePolicyResource created on azure
            // for more information of creating ServiceWorkspacePolicyResource, please refer to the document of ServiceWorkspacePolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspacePolicyResourceId = ServiceWorkspacePolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, policyId);
            ServiceWorkspacePolicyResource serviceWorkspacePolicy = client.GetServiceWorkspacePolicyResource(serviceWorkspacePolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData
            {
                Value = "<policies> <inbound /> <backend>    <forward-request />  </backend>  <outbound /></policies>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ServiceWorkspacePolicyResource> lro = await serviceWorkspacePolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ServiceWorkspacePolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspacePolicyNonXmlEncoded()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspacePolicyNonXmlEncoded.json
            // this example is just showing the usage of "WorkspacePolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspacePolicyResource created on azure
            // for more information of creating ServiceWorkspacePolicyResource, please refer to the document of ServiceWorkspacePolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspacePolicyResourceId = ServiceWorkspacePolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, policyId);
            ServiceWorkspacePolicyResource serviceWorkspacePolicy = client.GetServiceWorkspacePolicyResource(serviceWorkspacePolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData
            {
                Value = "<policies>\r\n     <inbound>\r\n     <base />\r\n  <set-header name=\"newvalue\" exists-action=\"override\">\r\n   <value>\"@(context.Request.Headers.FirstOrDefault(h => h.Ke==\"Via\"))\" </value>\r\n    </set-header>\r\n  </inbound>\r\n      </policies>",
                Format = PolicyContentFormat.RawXml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ServiceWorkspacePolicyResource> lro = await serviceWorkspacePolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ServiceWorkspacePolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadWorkspacePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadWorkspacePolicy.json
            // this example is just showing the usage of "WorkspacePolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspacePolicyResource created on azure
            // for more information of creating ServiceWorkspacePolicyResource, please refer to the document of ServiceWorkspacePolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspacePolicyResourceId = ServiceWorkspacePolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, policyId);
            ServiceWorkspacePolicyResource serviceWorkspacePolicy = client.GetServiceWorkspacePolicyResource(serviceWorkspacePolicyResourceId);

            // invoke the operation
            bool result = await serviceWorkspacePolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
