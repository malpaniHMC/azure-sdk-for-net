// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class NetworkCloudResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="NetworkCloudResourceGroupMockingExtension"/> class for mocking. </summary>
        protected NetworkCloudResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkCloudResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of NetworkCloudBareMetalMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudBareMetalMachineResources and their operations over a NetworkCloudBareMetalMachineResource. </returns>
        public virtual NetworkCloudBareMetalMachineCollection GetNetworkCloudBareMetalMachines()
        {
            return GetCachedClient(client => new NetworkCloudBareMetalMachineCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided bare metal machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines/{bareMetalMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineName"> The name of the bare metal machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudBareMetalMachineResource>> GetNetworkCloudBareMetalMachineAsync(string bareMetalMachineName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudBareMetalMachines().GetAsync(bareMetalMachineName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided bare metal machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines/{bareMetalMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineName"> The name of the bare metal machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudBareMetalMachineResource> GetNetworkCloudBareMetalMachine(string bareMetalMachineName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudBareMetalMachines().Get(bareMetalMachineName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudCloudServicesNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudCloudServicesNetworkResources and their operations over a NetworkCloudCloudServicesNetworkResource. </returns>
        public virtual NetworkCloudCloudServicesNetworkCollection GetNetworkCloudCloudServicesNetworks()
        {
            return GetCachedClient(client => new NetworkCloudCloudServicesNetworkCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided cloud services network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudCloudServicesNetworkResource>> GetNetworkCloudCloudServicesNetworkAsync(string cloudServicesNetworkName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudCloudServicesNetworks().GetAsync(cloudServicesNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided cloud services network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudCloudServicesNetworkResource> GetNetworkCloudCloudServicesNetwork(string cloudServicesNetworkName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudCloudServicesNetworks().Get(cloudServicesNetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudClusterManagerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudClusterManagerResources and their operations over a NetworkCloudClusterManagerResource. </returns>
        public virtual NetworkCloudClusterManagerCollection GetNetworkCloudClusterManagers()
        {
            return GetCachedClient(client => new NetworkCloudClusterManagerCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of the provided cluster manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudClusterManagerResource>> GetNetworkCloudClusterManagerAsync(string clusterManagerName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudClusterManagers().GetAsync(clusterManagerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of the provided cluster manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudClusterManagerResource> GetNetworkCloudClusterManager(string clusterManagerName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudClusterManagers().Get(clusterManagerName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudClusterResources and their operations over a NetworkCloudClusterResource. </returns>
        public virtual NetworkCloudClusterCollection GetNetworkCloudClusters()
        {
            return GetCachedClient(client => new NetworkCloudClusterCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudClusterResource>> GetNetworkCloudClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudClusterResource> GetNetworkCloudCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudKubernetesClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudKubernetesClusterResources and their operations over a NetworkCloudKubernetesClusterResource. </returns>
        public virtual NetworkCloudKubernetesClusterCollection GetNetworkCloudKubernetesClusters()
        {
            return GetCachedClient(client => new NetworkCloudKubernetesClusterCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided the Kubernetes cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudKubernetesClusterResource>> GetNetworkCloudKubernetesClusterAsync(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudKubernetesClusters().GetAsync(kubernetesClusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided the Kubernetes cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudKubernetesClusterResource> GetNetworkCloudKubernetesCluster(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudKubernetesClusters().Get(kubernetesClusterName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudL2NetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudL2NetworkResources and their operations over a NetworkCloudL2NetworkResource. </returns>
        public virtual NetworkCloudL2NetworkCollection GetNetworkCloudL2Networks()
        {
            return GetCachedClient(client => new NetworkCloudL2NetworkCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided layer 2 (L2) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudL2NetworkResource>> GetNetworkCloudL2NetworkAsync(string l2NetworkName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudL2Networks().GetAsync(l2NetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided layer 2 (L2) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudL2NetworkResource> GetNetworkCloudL2Network(string l2NetworkName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudL2Networks().Get(l2NetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudL3NetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudL3NetworkResources and their operations over a NetworkCloudL3NetworkResource. </returns>
        public virtual NetworkCloudL3NetworkCollection GetNetworkCloudL3Networks()
        {
            return GetCachedClient(client => new NetworkCloudL3NetworkCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided layer 3 (L3) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudL3NetworkResource>> GetNetworkCloudL3NetworkAsync(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudL3Networks().GetAsync(l3NetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided layer 3 (L3) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudL3NetworkResource> GetNetworkCloudL3Network(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudL3Networks().Get(l3NetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudRackResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudRackResources and their operations over a NetworkCloudRackResource. </returns>
        public virtual NetworkCloudRackCollection GetNetworkCloudRacks()
        {
            return GetCachedClient(client => new NetworkCloudRackCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided rack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudRackResource>> GetNetworkCloudRackAsync(string rackName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudRacks().GetAsync(rackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided rack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudRackResource> GetNetworkCloudRack(string rackName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudRacks().Get(rackName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudStorageApplianceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudStorageApplianceResources and their operations over a NetworkCloudStorageApplianceResource. </returns>
        public virtual NetworkCloudStorageApplianceCollection GetNetworkCloudStorageAppliances()
        {
            return GetCachedClient(client => new NetworkCloudStorageApplianceCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided storage appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/storageAppliances/{storageApplianceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAppliances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageApplianceName"> The name of the storage appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageApplianceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageApplianceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudStorageApplianceResource>> GetNetworkCloudStorageApplianceAsync(string storageApplianceName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudStorageAppliances().GetAsync(storageApplianceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided storage appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/storageAppliances/{storageApplianceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAppliances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageApplianceName"> The name of the storage appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageApplianceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageApplianceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudStorageApplianceResource> GetNetworkCloudStorageAppliance(string storageApplianceName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudStorageAppliances().Get(storageApplianceName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudTrunkedNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudTrunkedNetworkResources and their operations over a NetworkCloudTrunkedNetworkResource. </returns>
        public virtual NetworkCloudTrunkedNetworkCollection GetNetworkCloudTrunkedNetworks()
        {
            return GetCachedClient(client => new NetworkCloudTrunkedNetworkCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> GetNetworkCloudTrunkedNetworkAsync(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudTrunkedNetworks().GetAsync(trunkedNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudTrunkedNetworkResource> GetNetworkCloudTrunkedNetwork(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudTrunkedNetworks().Get(trunkedNetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudVirtualMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudVirtualMachineResources and their operations over a NetworkCloudVirtualMachineResource. </returns>
        public virtual NetworkCloudVirtualMachineCollection GetNetworkCloudVirtualMachines()
        {
            return GetCachedClient(client => new NetworkCloudVirtualMachineCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudVirtualMachineResource>> GetNetworkCloudVirtualMachineAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudVirtualMachines().GetAsync(virtualMachineName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudVirtualMachineResource> GetNetworkCloudVirtualMachine(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudVirtualMachines().Get(virtualMachineName, cancellationToken);
        }

        /// <summary> Gets a collection of NetworkCloudVolumeResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NetworkCloudVolumeResources and their operations over a NetworkCloudVolumeResource. </returns>
        public virtual NetworkCloudVolumeCollection GetNetworkCloudVolumes()
        {
            return GetCachedClient(client => new NetworkCloudVolumeCollection(client, Id));
        }

        /// <summary>
        /// Get properties of the provided volume.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NetworkCloudVolumeResource>> GetNetworkCloudVolumeAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkCloudVolumes().GetAsync(volumeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the provided volume.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NetworkCloudVolumeResource> GetNetworkCloudVolume(string volumeName, CancellationToken cancellationToken = default)
        {
            return GetNetworkCloudVolumes().Get(volumeName, cancellationToken);
        }
    }
}
