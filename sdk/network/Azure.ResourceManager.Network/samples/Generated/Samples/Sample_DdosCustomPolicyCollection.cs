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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_DdosCustomPolicyCollection
    {
        // Get DDoS custom policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDDoSCustomPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/DdosCustomPolicyGet.json
            // this example is just showing the usage of "DdosCustomPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DdosCustomPolicyResource
            DdosCustomPolicyCollection collection = resourceGroupResource.GetDdosCustomPolicies();

            // invoke the operation
            string ddosCustomPolicyName = "test-ddos-custom-policy";
            DdosCustomPolicyResource result = await collection.GetAsync(ddosCustomPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DdosCustomPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get DDoS custom policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDDoSCustomPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/DdosCustomPolicyGet.json
            // this example is just showing the usage of "DdosCustomPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DdosCustomPolicyResource
            DdosCustomPolicyCollection collection = resourceGroupResource.GetDdosCustomPolicies();

            // invoke the operation
            string ddosCustomPolicyName = "test-ddos-custom-policy";
            bool result = await collection.ExistsAsync(ddosCustomPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create DDoS custom policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateDDoSCustomPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/DdosCustomPolicyCreate.json
            // this example is just showing the usage of "DdosCustomPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DdosCustomPolicyResource
            DdosCustomPolicyCollection collection = resourceGroupResource.GetDdosCustomPolicies();

            // invoke the operation
            string ddosCustomPolicyName = "test-ddos-custom-policy";
            DdosCustomPolicyData data = new DdosCustomPolicyData()
            {
                Location = new AzureLocation("centraluseuap"),
            };
            ArmOperation<DdosCustomPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ddosCustomPolicyName, data);
            DdosCustomPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DdosCustomPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
