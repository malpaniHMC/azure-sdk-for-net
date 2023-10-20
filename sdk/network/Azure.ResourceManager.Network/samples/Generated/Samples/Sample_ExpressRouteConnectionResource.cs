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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteConnectionResource
    {
        // ExpressRouteConnectionCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ExpressRouteConnectionCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteConnectionCreate.json
            // this example is just showing the usage of "ExpressRouteConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteConnectionResource created on azure
            // for more information of creating ExpressRouteConnectionResource, please refer to the document of ExpressRouteConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "resourceGroupName";
            string expressRouteGatewayName = "gateway-2";
            string connectionName = "connectionName";
            ResourceIdentifier expressRouteConnectionResourceId = ExpressRouteConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRouteGatewayName, connectionName);
            ExpressRouteConnectionResource expressRouteConnection = client.GetExpressRouteConnectionResource(expressRouteConnectionResourceId);

            // invoke the operation
            ExpressRouteConnectionData data = new ExpressRouteConnectionData()
            {
                ExpressRouteCircuitPeeringId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/expressRouteCircuits/circuitName/peerings/AzurePrivatePeering"),
                AuthorizationKey = "authorizationKey",
                RoutingWeight = 2,
                RoutingConfiguration = new RoutingConfiguration()
                {
                    AssociatedRouteTableId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable1"),
                    PropagatedRouteTables = new PropagatedRouteTable()
                    {
                        Labels =
{
"label1","label2"
},
                        Ids =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable1"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable2"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable3"),
}
},
                    },
                    InboundRouteMapId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap1"),
                    OutboundRouteMapId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap2"),
                },
                Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/expressRouteGateways/gateway-2/expressRouteConnections/connectionName"),
                Name = "connectionName",
            };
            ArmOperation<ExpressRouteConnectionResource> lro = await expressRouteConnection.UpdateAsync(WaitUntil.Completed, data);
            ExpressRouteConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRouteConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ExpressRouteConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteConnectionGet.json
            // this example is just showing the usage of "ExpressRouteConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteConnectionResource created on azure
            // for more information of creating ExpressRouteConnectionResource, please refer to the document of ExpressRouteConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "resourceGroupName";
            string expressRouteGatewayName = "expressRouteGatewayName";
            string connectionName = "connectionName";
            ResourceIdentifier expressRouteConnectionResourceId = ExpressRouteConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRouteGatewayName, connectionName);
            ExpressRouteConnectionResource expressRouteConnection = client.GetExpressRouteConnectionResource(expressRouteConnectionResourceId);

            // invoke the operation
            ExpressRouteConnectionResource result = await expressRouteConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRouteConnectionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ExpressRouteConnectionDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteConnectionDelete.json
            // this example is just showing the usage of "ExpressRouteConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteConnectionResource created on azure
            // for more information of creating ExpressRouteConnectionResource, please refer to the document of ExpressRouteConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "resourceGroupName";
            string expressRouteGatewayName = "expressRouteGatewayName";
            string connectionName = "connectionName";
            ResourceIdentifier expressRouteConnectionResourceId = ExpressRouteConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRouteGatewayName, connectionName);
            ExpressRouteConnectionResource expressRouteConnection = client.GetExpressRouteConnectionResource(expressRouteConnectionResourceId);

            // invoke the operation
            await expressRouteConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
