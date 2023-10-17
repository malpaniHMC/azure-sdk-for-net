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
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class StorageCacheResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="StorageCacheResourceGroupMockingExtension"/> class for mocking. </summary>
        protected StorageCacheResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageCacheResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageCacheResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AmlFileSystemResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AmlFileSystemResources and their operations over a AmlFileSystemResource. </returns>
        public virtual AmlFileSystemCollection GetAmlFileSystems()
        {
            return GetCachedClient(client => new AmlFileSystemCollection(client, Id));
        }

        /// <summary>
        /// Returns an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AmlFileSystemResource>> GetAmlFileSystemAsync(string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            return await GetAmlFileSystems().GetAsync(amlFileSystemName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AmlFileSystemResource> GetAmlFileSystem(string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            return GetAmlFileSystems().Get(amlFileSystemName, cancellationToken);
        }

        /// <summary> Gets a collection of StorageCacheResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StorageCacheResources and their operations over a StorageCacheResource. </returns>
        public virtual StorageCacheCollection GetStorageCaches()
        {
            return GetCachedClient(client => new StorageCacheCollection(client, Id));
        }

        /// <summary>
        /// Returns a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StorageCacheResource>> GetStorageCacheAsync(string cacheName, CancellationToken cancellationToken = default)
        {
            return await GetStorageCaches().GetAsync(cacheName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StorageCacheResource> GetStorageCache(string cacheName, CancellationToken cancellationToken = default)
        {
            return GetStorageCaches().Get(cacheName, cancellationToken);
        }
    }
}
