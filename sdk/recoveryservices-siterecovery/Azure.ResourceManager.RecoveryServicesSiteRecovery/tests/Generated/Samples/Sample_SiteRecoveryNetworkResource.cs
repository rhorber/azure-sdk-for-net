// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryNetworkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsANetworkWithSpecifiedServerIdAndNetworkName()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2025-01-01/examples/ReplicationNetworks_Get.json
            // this example is just showing the usage of "ReplicationNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryNetworkResource created on azure
            // for more information of creating SiteRecoveryNetworkResource, please refer to the document of SiteRecoveryNetworkResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "srcBvte2a14C27";
            string resourceName = "srce2avaultbvtaC27";
            string fabricName = "b0cef6e9a4437b81803d0b55ada4f700ab66caae59c35d62723a1589c0cd13ac";
            string networkName = "93ce99d7-1219-4914-aa61-73fe5023988e";
            ResourceIdentifier siteRecoveryNetworkResourceId = SiteRecoveryNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, networkName);
            SiteRecoveryNetworkResource siteRecoveryNetwork = client.GetSiteRecoveryNetworkResource(siteRecoveryNetworkResourceId);

            // invoke the operation
            SiteRecoveryNetworkResource result = await siteRecoveryNetwork.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
