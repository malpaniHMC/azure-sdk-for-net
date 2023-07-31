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
using Azure.ResourceManager.CognitiveServices;
using Azure.ResourceManager.CognitiveServices.Models;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CommitmentPlanCollection
    {
        // ListCommitmentPlans
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCommitmentPlans()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/ListCommitmentPlans.json
            // this example is just showing the usage of "CommitmentPlans_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CommitmentPlanResource
            CommitmentPlanCollection collection = cognitiveServicesAccount.GetCommitmentPlans();

            // invoke the operation and iterate over the result
            await foreach (CommitmentPlanResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CommitmentPlanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetCommitmentPlan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/GetCommitmentPlan.json
            // this example is just showing the usage of "CommitmentPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CommitmentPlanResource
            CommitmentPlanCollection collection = cognitiveServicesAccount.GetCommitmentPlans();

            // invoke the operation
            string commitmentPlanName = "commitmentPlanName";
            CommitmentPlanResource result = await collection.GetAsync(commitmentPlanName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommitmentPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetCommitmentPlan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/GetCommitmentPlan.json
            // this example is just showing the usage of "CommitmentPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CommitmentPlanResource
            CommitmentPlanCollection collection = cognitiveServicesAccount.GetCommitmentPlans();

            // invoke the operation
            string commitmentPlanName = "commitmentPlanName";
            bool result = await collection.ExistsAsync(commitmentPlanName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PutCommitmentPlan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/PutCommitmentPlan.json
            // this example is just showing the usage of "CommitmentPlans_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CommitmentPlanResource
            CommitmentPlanCollection collection = cognitiveServicesAccount.GetCommitmentPlans();

            // invoke the operation
            string commitmentPlanName = "commitmentPlanName";
            CommitmentPlanData data = new CommitmentPlanData()
            {
                Properties = new CommitmentPlanProperties()
                {
                    HostingModel = ServiceAccountHostingModel.Web,
                    PlanType = "Speech2Text",
                    Current = new CommitmentPeriod()
                    {
                        Tier = "T1",
                    },
                    AutoRenew = true,
                },
            };
            ArmOperation<CommitmentPlanResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, commitmentPlanName, data);
            CommitmentPlanResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommitmentPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
