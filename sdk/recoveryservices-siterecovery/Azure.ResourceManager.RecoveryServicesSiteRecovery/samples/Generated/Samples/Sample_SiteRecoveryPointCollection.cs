// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryPointCollection
    {
        // Gets the list of recovery points for a replication protected item.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsTheListOfRecoveryPointsForAReplicationProtectedItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/RecoveryPoints_ListByReplicationProtectedItems.json
            // this example is just showing the usage of "RecoveryPoints_ListByReplicationProtectedItems" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReplicationProtectedItemResource created on azure
            // for more information of creating ReplicationProtectedItemResource, please refer to the document of ReplicationProtectedItemResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string replicatedProtectedItemName = "f8491e4f-817a-40dd-a90c-af773978c75b";
            ResourceIdentifier replicationProtectedItemResourceId = ReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicatedProtectedItemName);
            ReplicationProtectedItemResource replicationProtectedItem = client.GetReplicationProtectedItemResource(replicationProtectedItemResourceId);

            // get the collection of this SiteRecoveryPointResource
            SiteRecoveryPointCollection collection = replicationProtectedItem.GetSiteRecoveryPoints();

            // invoke the operation and iterate over the result
            await foreach (SiteRecoveryPointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SiteRecoveryPointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a recovery point.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsARecoveryPoint()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/RecoveryPoints_Get.json
            // this example is just showing the usage of "RecoveryPoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReplicationProtectedItemResource created on azure
            // for more information of creating ReplicationProtectedItemResource, please refer to the document of ReplicationProtectedItemResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string replicatedProtectedItemName = "f8491e4f-817a-40dd-a90c-af773978c75b";
            ResourceIdentifier replicationProtectedItemResourceId = ReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicatedProtectedItemName);
            ReplicationProtectedItemResource replicationProtectedItem = client.GetReplicationProtectedItemResource(replicationProtectedItemResourceId);

            // get the collection of this SiteRecoveryPointResource
            SiteRecoveryPointCollection collection = replicationProtectedItem.GetSiteRecoveryPoints();

            // invoke the operation
            string recoveryPointName = "b22134ea-620c-474b-9fa5-3c1cb47708e3";
            SiteRecoveryPointResource result = await collection.GetAsync(recoveryPointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryPointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a recovery point.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsARecoveryPoint()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/RecoveryPoints_Get.json
            // this example is just showing the usage of "RecoveryPoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReplicationProtectedItemResource created on azure
            // for more information of creating ReplicationProtectedItemResource, please refer to the document of ReplicationProtectedItemResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string replicatedProtectedItemName = "f8491e4f-817a-40dd-a90c-af773978c75b";
            ResourceIdentifier replicationProtectedItemResourceId = ReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicatedProtectedItemName);
            ReplicationProtectedItemResource replicationProtectedItem = client.GetReplicationProtectedItemResource(replicationProtectedItemResourceId);

            // get the collection of this SiteRecoveryPointResource
            SiteRecoveryPointCollection collection = replicationProtectedItem.GetSiteRecoveryPoints();

            // invoke the operation
            string recoveryPointName = "b22134ea-620c-474b-9fa5-3c1cb47708e3";
            bool result = await collection.ExistsAsync(recoveryPointName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
