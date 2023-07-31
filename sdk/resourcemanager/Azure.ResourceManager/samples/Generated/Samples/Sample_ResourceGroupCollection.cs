// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_ResourceGroupCollection
    {
        // Create or update a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAResourceGroup()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/CreateResourceGroup.json
            // this example is just showing the usage of "ResourceGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ResourceGroupResource
            ResourceGroupCollection collection = subscription.GetResourceGroups();

            // invoke the operation
            string resourceGroupName = "my-resource-group";
            ResourceGroupData data = new ResourceGroupData(new AzureLocation("eastus"));
            ArmOperation<ResourceGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceGroupName, data);
            ResourceGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
