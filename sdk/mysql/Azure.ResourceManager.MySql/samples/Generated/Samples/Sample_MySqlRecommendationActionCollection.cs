// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlRecommendationActionCollection
    {
        // RecommendedActionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RecommendedActionsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/RecommendedActionsGet.json
            // this example is just showing the usage of "RecommendedActions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlAdvisorResource created on azure
            // for more information of creating MySqlAdvisorResource, please refer to the document of MySqlAdvisorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            string advisorName = "Index";
            ResourceIdentifier mySqlAdvisorResourceId = MySqlAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advisorName);
            MySqlAdvisorResource mySqlAdvisor = client.GetMySqlAdvisorResource(mySqlAdvisorResourceId);

            // get the collection of this MySqlRecommendationActionResource
            MySqlRecommendationActionCollection collection = mySqlAdvisor.GetMySqlRecommendationActions();

            // invoke the operation
            string recommendedActionName = "Index-1";
            MySqlRecommendationActionResource result = await collection.GetAsync(recommendedActionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlRecommendationActionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RecommendedActionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RecommendedActionsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/RecommendedActionsGet.json
            // this example is just showing the usage of "RecommendedActions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlAdvisorResource created on azure
            // for more information of creating MySqlAdvisorResource, please refer to the document of MySqlAdvisorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            string advisorName = "Index";
            ResourceIdentifier mySqlAdvisorResourceId = MySqlAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advisorName);
            MySqlAdvisorResource mySqlAdvisor = client.GetMySqlAdvisorResource(mySqlAdvisorResourceId);

            // get the collection of this MySqlRecommendationActionResource
            MySqlRecommendationActionCollection collection = mySqlAdvisor.GetMySqlRecommendationActions();

            // invoke the operation
            string recommendedActionName = "Index-1";
            bool result = await collection.ExistsAsync(recommendedActionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RecommendedActionsListByServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RecommendedActionsListByServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/RecommendedActionsListByServer.json
            // this example is just showing the usage of "RecommendedActions_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlAdvisorResource created on azure
            // for more information of creating MySqlAdvisorResource, please refer to the document of MySqlAdvisorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            string advisorName = "Index";
            ResourceIdentifier mySqlAdvisorResourceId = MySqlAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advisorName);
            MySqlAdvisorResource mySqlAdvisor = client.GetMySqlAdvisorResource(mySqlAdvisorResourceId);

            // get the collection of this MySqlRecommendationActionResource
            MySqlRecommendationActionCollection collection = mySqlAdvisor.GetMySqlRecommendationActions();

            // invoke the operation and iterate over the result
            await foreach (MySqlRecommendationActionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlRecommendationActionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
