// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteConfigAppsettingCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAzureKeyVaultAppSettingReference()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetKeyVaultReferencesForAppSetting.json
            // this example is just showing the usage of "WebApps_GetAppSettingKeyVaultReference" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteConfigAppsettingResource
            SiteConfigAppsettingCollection collection = webSite.GetSiteConfigAppsettings();

            // invoke the operation
            string appSettingKey = "setting";
            SiteConfigAppsettingResource result = await collection.GetAsync(appSettingKey);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiKeyVaultReferenceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAzureKeyVaultReferencesForAppSettings()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetKeyVaultReferencesForAppSettings.json
            // this example is just showing the usage of "WebApps_GetAppSettingsKeyVaultReferences" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteConfigAppsettingResource
            SiteConfigAppsettingCollection collection = webSite.GetSiteConfigAppsettings();

            // invoke the operation and iterate over the result
            await foreach (SiteConfigAppsettingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiKeyVaultReferenceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAzureKeyVaultAppSettingReference()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetKeyVaultReferencesForAppSetting.json
            // this example is just showing the usage of "WebApps_GetAppSettingKeyVaultReference" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteConfigAppsettingResource
            SiteConfigAppsettingCollection collection = webSite.GetSiteConfigAppsettings();

            // invoke the operation
            string appSettingKey = "setting";
            bool result = await collection.ExistsAsync(appSettingKey);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAzureKeyVaultAppSettingReference()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetKeyVaultReferencesForAppSetting.json
            // this example is just showing the usage of "WebApps_GetAppSettingKeyVaultReference" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteConfigAppsettingResource
            SiteConfigAppsettingCollection collection = webSite.GetSiteConfigAppsettings();

            // invoke the operation
            string appSettingKey = "setting";
            NullableResponse<SiteConfigAppsettingResource> response = await collection.GetIfExistsAsync(appSettingKey);
            SiteConfigAppsettingResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiKeyVaultReferenceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
