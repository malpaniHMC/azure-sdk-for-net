// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DataBox;
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBox.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // ValidateAddressPost
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateAddress_ValidateAddressPost()
        {
            // Generated from example definition: specification/databox/resource-manager/Microsoft.DataBox/stable/2022-12-01/examples/ValidateAddressPost.json
            // this example is just showing the usage of "Service_ValidateAddress" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "YourSubscriptionId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            DataBoxValidateAddressContent content = new DataBoxValidateAddressContent(new DataBoxShippingAddress("XXXX XXXX", "XX", "00000")
            {
                StreetAddress2 = "XXXX XXXX",
                City = "XXXX XXXX",
                StateOrProvince = "XX",
                CompanyName = "XXXX XXXX",
                AddressType = DataBoxShippingAddressType.Commercial,
            }, DataBoxSkuName.DataBox);
            AddressValidationOutput result = await subscriptionResource.ValidateAddressAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ValidateInputs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateInputs_ValidateInputs()
        {
            // Generated from example definition: specification/databox/resource-manager/Microsoft.DataBox/stable/2022-12-01/examples/ValidateInputs.json
            // this example is just showing the usage of "Service_ValidateInputs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "YourSubscriptionId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            DataBoxValidationContent content = new CreateJobValidationContent(new DataBoxValidationInputContent[]
            {
new DataTransferDetailsValidationContent(DataBoxSkuName.DataBox,DataBoxJobTransferType.ImportToAzure)
{
DataImportDetails =
{
new DataImportDetails(new DataBoxStorageAccountDetails(new ResourceIdentifier("/subscriptions/YourSubscriptionId/resourcegroups/YourResourceGroupName/providers/Microsoft.Storage/storageAccounts/YourStorageAccountName")))
},
},new DataBoxValidateAddressContent(new DataBoxShippingAddress("XXXX XXXX","XX","00000")
{
StreetAddress2 = "XXXX XXXX",
City = "XXXX XXXX",
StateOrProvince = "XX",
CompanyName = "XXXX XXXX",
AddressType = DataBoxShippingAddressType.Commercial,
},DataBoxSkuName.DataBox)
{
TransportPreferences = new TransportPreferences(TransportShipmentType.MicrosoftManaged),
},new SubscriptionIsAllowedToCreateJobValidationContent(),new SkuAvailabilityValidationContent(DataBoxSkuName.DataBox,DataBoxJobTransferType.ImportToAzure,"XX",new AzureLocation("westus")),new CreateOrderLimitForSubscriptionValidationContent(DataBoxSkuName.DataBox),new PreferencesValidationContent(DataBoxSkuName.DataBox)
{
Preference = new DataBoxOrderPreferences()
{
TransportPreferences = new TransportPreferences(TransportShipmentType.MicrosoftManaged),
},
}
            });
            DataBoxValidationResult result = await subscriptionResource.ValidateInputsAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RegionConfiguration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRegionConfiguration_RegionConfiguration()
        {
            // Generated from example definition: specification/databox/resource-manager/Microsoft.DataBox/stable/2022-12-01/examples/RegionConfiguration.json
            // this example is just showing the usage of "Service_RegionConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "YourSubscriptionId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            RegionConfigurationContent content = new RegionConfigurationContent()
            {
                ScheduleAvailabilityRequest = new DataBoxScheduleAvailabilityContent(new AzureLocation("westus")),
            };
            RegionConfigurationResult result = await subscriptionResource.GetRegionConfigurationAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
