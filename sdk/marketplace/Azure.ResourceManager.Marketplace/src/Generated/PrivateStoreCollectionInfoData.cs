// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing the PrivateStoreCollectionInfo data model.
    /// The Collection data structure.
    /// </summary>
    public partial class PrivateStoreCollectionInfoData : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateStoreCollectionInfoData. </summary>
        public PrivateStoreCollectionInfoData()
        {
            SubscriptionsList = new ChangeTrackingList<string>();
            AppliedRules = new ChangeTrackingList<MarketplaceRule>();
        }

        /// <summary> Initializes a new instance of PrivateStoreCollectionInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="collectionId"> Gets collection Id. </param>
        /// <param name="collectionName"> Gets or sets collection name. </param>
        /// <param name="claim"> Gets or sets the association with Commercial's Billing Account. </param>
        /// <param name="areAllSubscriptionsSelected"> Indicating whether all subscriptions are selected (=true) or not (=false). </param>
        /// <param name="areAllItemsApproved"> Indicating whether all items are approved for this collection (=true) or not (=false). </param>
        /// <param name="approveAllItemsModifiedOn"> Gets the modified date of all items approved. </param>
        /// <param name="subscriptionsList"> Gets or sets subscription ids list. Empty list indicates all subscriptions are selected, null indicates no update is done, explicit list indicates the explicit selected subscriptions. On insert, null is considered as bad request. </param>
        /// <param name="isEnabled"> Indicating whether the collection is enabled or disabled. </param>
        /// <param name="numberOfOffers"> Gets the number of offers associated with the collection. </param>
        /// <param name="appliedRules"> Gets list of collection rules. </param>
        internal PrivateStoreCollectionInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? collectionId, string collectionName, string claim, bool? areAllSubscriptionsSelected, bool? areAllItemsApproved, DateTimeOffset? approveAllItemsModifiedOn, IList<string> subscriptionsList, bool? isEnabled, long? numberOfOffers, IReadOnlyList<MarketplaceRule> appliedRules) : base(id, name, resourceType, systemData)
        {
            CollectionId = collectionId;
            CollectionName = collectionName;
            Claim = claim;
            AreAllSubscriptionsSelected = areAllSubscriptionsSelected;
            AreAllItemsApproved = areAllItemsApproved;
            ApproveAllItemsModifiedOn = approveAllItemsModifiedOn;
            SubscriptionsList = subscriptionsList;
            IsEnabled = isEnabled;
            NumberOfOffers = numberOfOffers;
            AppliedRules = appliedRules;
        }

        /// <summary> Gets collection Id. </summary>
        public Guid? CollectionId { get; }
        /// <summary> Gets or sets collection name. </summary>
        public string CollectionName { get; set; }
        /// <summary> Gets or sets the association with Commercial's Billing Account. </summary>
        public string Claim { get; set; }
        /// <summary> Indicating whether all subscriptions are selected (=true) or not (=false). </summary>
        public bool? AreAllSubscriptionsSelected { get; set; }
        /// <summary> Indicating whether all items are approved for this collection (=true) or not (=false). </summary>
        public bool? AreAllItemsApproved { get; }
        /// <summary> Gets the modified date of all items approved. </summary>
        public DateTimeOffset? ApproveAllItemsModifiedOn { get; }
        /// <summary> Gets or sets subscription ids list. Empty list indicates all subscriptions are selected, null indicates no update is done, explicit list indicates the explicit selected subscriptions. On insert, null is considered as bad request. </summary>
        public IList<string> SubscriptionsList { get; }
        /// <summary> Indicating whether the collection is enabled or disabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Gets the number of offers associated with the collection. </summary>
        public long? NumberOfOffers { get; }
        /// <summary> Gets list of collection rules. </summary>
        public IReadOnlyList<MarketplaceRule> AppliedRules { get; }
    }
}
