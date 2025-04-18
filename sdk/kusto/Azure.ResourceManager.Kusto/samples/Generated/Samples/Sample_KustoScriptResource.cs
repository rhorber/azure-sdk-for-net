// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Kusto.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Kusto.Samples
{
    public partial class Sample_KustoScriptResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoScriptsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoScriptsGet.json
            // this example is just showing the usage of "Scripts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoScriptResource created on azure
            // for more information of creating KustoScriptResource, please refer to the document of KustoScriptResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            string scriptName = "kustoScript";
            ResourceIdentifier kustoScriptResourceId = KustoScriptResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, scriptName);
            KustoScriptResource kustoScript = client.GetKustoScriptResource(kustoScriptResourceId);

            // invoke the operation
            KustoScriptResource result = await kustoScript.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_KustoScriptsDelete()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoScriptsDelete.json
            // this example is just showing the usage of "Scripts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoScriptResource created on azure
            // for more information of creating KustoScriptResource, please refer to the document of KustoScriptResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string scriptName = "kustoScript";
            ResourceIdentifier kustoScriptResourceId = KustoScriptResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, scriptName);
            KustoScriptResource kustoScript = client.GetKustoScriptResource(kustoScriptResourceId);

            // invoke the operation
            await kustoScript.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_KustoScriptsUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoScriptsUpdate.json
            // this example is just showing the usage of "Scripts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoScriptResource created on azure
            // for more information of creating KustoScriptResource, please refer to the document of KustoScriptResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string scriptName = "kustoScript";
            ResourceIdentifier kustoScriptResourceId = KustoScriptResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, scriptName);
            KustoScriptResource kustoScript = client.GetKustoScriptResource(kustoScriptResourceId);

            // invoke the operation
            KustoScriptData data = new KustoScriptData
            {
                ScriptUri = new Uri("https://mysa.blob.core.windows.net/container/script.txt"),
                ScriptUriSasToken = "?sv=2019-02-02&st=2019-04-29T22%3A18%3A26Z&se=2019-04-30T02%3A23%3A26Z&sr=b&sp=rw&sip=168.1.5.60-168.1.5.70&spr=https&sig=********************************",
                ForceUpdateTag = "2bcf3c21-ffd1-4444-b9dd-e52e00ee53fe",
                ShouldContinueOnErrors = true,
                ScriptLevel = KustoScriptLevel.Database,
                PrincipalPermissionsAction = PrincipalPermissionsAction.RemovePermissionOnScriptCompletion,
            };
            ArmOperation<KustoScriptResource> lro = await kustoScript.UpdateAsync(WaitUntil.Completed, data);
            KustoScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
