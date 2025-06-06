// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HDInsight.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HDInsight.Samples
{
    public partial class Sample_HDInsightApplicationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetApplicationOnHDInsightClusterCreationInProgress()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2025-01-15-preview/examples/GetApplicationInProgress.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightApplicationResource created on azure
            // for more information of creating HDInsightApplicationResource, please refer to the document of HDInsightApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            string applicationName = "app";
            ResourceIdentifier hdInsightApplicationResourceId = HDInsightApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            HDInsightApplicationResource hdInsightApplication = client.GetHDInsightApplicationResource(hdInsightApplicationResourceId);

            // invoke the operation
            HDInsightApplicationResource result = await hdInsightApplication.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetApplicationOnHDInsightClusterSuccessfullyCreated()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2025-01-15-preview/examples/GetApplicationCreated.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightApplicationResource created on azure
            // for more information of creating HDInsightApplicationResource, please refer to the document of HDInsightApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            string applicationName = "app";
            ResourceIdentifier hdInsightApplicationResourceId = HDInsightApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            HDInsightApplicationResource hdInsightApplication = client.GetHDInsightApplicationResource(hdInsightApplicationResourceId);

            // invoke the operation
            HDInsightApplicationResource result = await hdInsightApplication.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteApplicationFromHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2025-01-15-preview/examples/DeleteApplication.json
            // this example is just showing the usage of "Applications_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightApplicationResource created on azure
            // for more information of creating HDInsightApplicationResource, please refer to the document of HDInsightApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            string applicationName = "hue";
            ResourceIdentifier hdInsightApplicationResourceId = HDInsightApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            HDInsightApplicationResource hdInsightApplication = client.GetHDInsightApplicationResource(hdInsightApplicationResourceId);

            // invoke the operation
            await hdInsightApplication.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateApplication()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2025-01-15-preview/examples/CreateApplication.json
            // this example is just showing the usage of "Applications_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightApplicationResource created on azure
            // for more information of creating HDInsightApplicationResource, please refer to the document of HDInsightApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            string applicationName = "hue";
            ResourceIdentifier hdInsightApplicationResourceId = HDInsightApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            HDInsightApplicationResource hdInsightApplication = client.GetHDInsightApplicationResource(hdInsightApplicationResourceId);

            // invoke the operation
            HDInsightApplicationData data = new HDInsightApplicationData
            {
                Properties = new HDInsightApplicationProperties
                {
                    ComputeRoles = {new HDInsightClusterRole
{
Name = "edgenode",
TargetInstanceCount = 1,
HardwareVmSize = "Standard_D12_v2",
}},
                    InstallScriptActions = {new RuntimeScriptAction("app-install-app1", new Uri("https://.../install.sh"), new string[]{"edgenode"})
{
Parameters = "-version latest -port 20000",
}},
                    UninstallScriptActions = { },
                    HttpsEndpoints = {new HDInsightApplicationHttpsEndpoint
{
AccessModes = {"WebPage"},
DestinationPort = 20000,
SubDomainSuffix = "dss",
}},
                    ApplicationType = "CustomApplication",
                    Errors = { },
                },
            };
            ArmOperation<HDInsightApplicationResource> lro = await hdInsightApplication.UpdateAsync(WaitUntil.Completed, data);
            HDInsightApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAzureAsyncOperationStatus_GetTheAzureAsyncOperationStatus()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2025-01-15-preview/examples/GetApplicationCreationAsyncOperationStatus.json
            // this example is just showing the usage of "Applications_GetAzureAsyncOperationStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightApplicationResource created on azure
            // for more information of creating HDInsightApplicationResource, please refer to the document of HDInsightApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            string applicationName = "app";
            ResourceIdentifier hdInsightApplicationResourceId = HDInsightApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            HDInsightApplicationResource hdInsightApplication = client.GetHDInsightApplicationResource(hdInsightApplicationResourceId);

            // invoke the operation
            string operationId = "CF938302-6B4D-44A0-A6D2-C0D67E847AEC";
            HDInsightAsyncOperationResult result = await hdInsightApplication.GetAzureAsyncOperationStatusAsync(operationId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
