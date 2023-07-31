// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The parameters used to update an Azure Cognitive Search service. </summary>
    public partial class SearchServicePatch : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SearchServicePatch. </summary>
        /// <param name="location"> The location. </param>
        public SearchServicePatch(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<SearchPrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<SharedSearchServicePrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of SearchServicePatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the Search Service, which determines price tier and capacity limits. This property is required when creating a new Search Service. </param>
        /// <param name="identity"> The identity of the resource. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="replicaCount"> The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. </param>
        /// <param name="partitionCount"> The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. </param>
        /// <param name="hostingMode"> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </param>
        /// <param name="publicNetworkAccess"> This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </param>
        /// <param name="status"> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. If your service is in the degraded, disabled, or error states, it means the Azure Cognitive Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </param>
        /// <param name="statusDetails"> The details of the search service status. </param>
        /// <param name="provisioningState"> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'succeeded' or 'failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up. </param>
        /// <param name="networkRuleSet"> Network specific rules that determine how the Azure Cognitive Search service may be reached. </param>
        /// <param name="encryptionWithCmk"> Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys within a search service. </param>
        /// <param name="isLocalAuthDisabled"> When set to true, calls to the search service will not be permitted to utilize API keys for authentication. This cannot be set to true if 'dataPlaneAuthOptions' are defined. </param>
        /// <param name="authOptions"> Defines the options for how the data plane API of a search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections to the Azure Cognitive Search service. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources managed by the Azure Cognitive Search service. </param>
        internal SearchServicePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SearchSku sku, ManagedServiceIdentity identity, int? replicaCount, int? partitionCount, SearchServiceHostingMode? hostingMode, SearchServicePublicNetworkAccess? publicNetworkAccess, SearchServiceStatus? status, string statusDetails, SearchServiceProvisioningState? provisioningState, NetworkRuleSet networkRuleSet, SearchEncryptionWithCmk encryptionWithCmk, bool? isLocalAuthDisabled, SearchAadAuthDataPlaneAuthOptions authOptions, IReadOnlyList<SearchPrivateEndpointConnectionData> privateEndpointConnections, IReadOnlyList<SharedSearchServicePrivateLinkResourceData> sharedPrivateLinkResources) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ReplicaCount = replicaCount;
            PartitionCount = partitionCount;
            HostingMode = hostingMode;
            PublicNetworkAccess = publicNetworkAccess;
            Status = status;
            StatusDetails = statusDetails;
            ProvisioningState = provisioningState;
            NetworkRuleSet = networkRuleSet;
            EncryptionWithCmk = encryptionWithCmk;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            AuthOptions = authOptions;
            PrivateEndpointConnections = privateEndpointConnections;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
        }

        /// <summary> The SKU of the Search Service, which determines price tier and capacity limits. This property is required when creating a new Search Service. </summary>
        internal SearchSku Sku { get; set; }
        /// <summary> The SKU of the search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). 'storage_optimized_l1': Supports 1TB per partition, up to 12 partitions. 'storage_optimized_l2': Supports 2TB per partition, up to 12 partitions.'. </summary>
        public SearchSkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new SearchSku();
                Sku.Name = value;
            }
        }

        /// <summary> The identity of the resource. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. </summary>
        public int? ReplicaCount { get; set; }
        /// <summary> The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. </summary>
        public int? PartitionCount { get; set; }
        /// <summary> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </summary>
        public SearchServiceHostingMode? HostingMode { get; set; }
        /// <summary> This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </summary>
        public SearchServicePublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. If your service is in the degraded, disabled, or error states, it means the Azure Cognitive Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </summary>
        public SearchServiceStatus? Status { get; }
        /// <summary> The details of the search service status. </summary>
        public string StatusDetails { get; }
        /// <summary> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'succeeded' or 'failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up. </summary>
        public SearchServiceProvisioningState? ProvisioningState { get; }
        /// <summary> Network specific rules that determine how the Azure Cognitive Search service may be reached. </summary>
        internal NetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> A list of IP restriction rules that defines the inbound network(s) with allowing access to the search service endpoint. At the meantime, all other public IP networks are blocked by the firewall. These restriction rules are applied only when the 'publicNetworkAccess' of the search service is 'enabled'; otherwise, traffic over public interface is not allowed even with any public IP rules, and private endpoint connections would be the exclusive access method. </summary>
        public IList<SearchServiceIPRule> IPRules
        {
            get
            {
                if (NetworkRuleSet is null)
                    NetworkRuleSet = new NetworkRuleSet();
                return NetworkRuleSet.IPRules;
            }
        }

        /// <summary> Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys within a search service. </summary>
        public SearchEncryptionWithCmk EncryptionWithCmk { get; set; }
        /// <summary> When set to true, calls to the search service will not be permitted to utilize API keys for authentication. This cannot be set to true if 'dataPlaneAuthOptions' are defined. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary> Defines the options for how the data plane API of a search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </summary>
        public SearchAadAuthDataPlaneAuthOptions AuthOptions { get; set; }
        /// <summary> The list of private endpoint connections to the Azure Cognitive Search service. </summary>
        public IReadOnlyList<SearchPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The list of shared private link resources managed by the Azure Cognitive Search service. </summary>
        public IReadOnlyList<SharedSearchServicePrivateLinkResourceData> SharedPrivateLinkResources { get; }
    }
}
