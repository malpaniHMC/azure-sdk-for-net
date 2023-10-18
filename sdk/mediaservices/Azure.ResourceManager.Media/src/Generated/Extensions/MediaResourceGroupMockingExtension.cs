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
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MediaResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MediaResourceGroupMockingExtension"/> class for mocking. </summary>
        protected MediaResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MediaResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MediaServicesAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MediaServicesAccountResources and their operations over a MediaServicesAccountResource. </returns>
        public virtual MediaServicesAccountCollection GetMediaServicesAccounts()
        {
            return GetCachedClient(client => new MediaServicesAccountCollection(client, Id));
        }

        /// <summary>
        /// Get the details of a Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Mediaservices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MediaServicesAccountResource>> GetMediaServicesAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetMediaServicesAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the details of a Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Mediaservices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MediaServicesAccountResource> GetMediaServicesAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetMediaServicesAccounts().Get(accountName, cancellationToken);
        }
    }
}
