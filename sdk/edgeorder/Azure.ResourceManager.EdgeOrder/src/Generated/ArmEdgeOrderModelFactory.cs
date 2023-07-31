// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmEdgeOrderModelFactory
    {
        /// <summary> Initializes a new instance of EdgeOrderAddressData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="shippingAddress"> Shipping details for the address. </param>
        /// <param name="contactDetails"> Contact details for the address. </param>
        /// <param name="addressValidationStatus"> Status of address validation. </param>
        /// <returns> A new <see cref="EdgeOrder.EdgeOrderAddressData"/> instance for mocking. </returns>
        public static EdgeOrderAddressData EdgeOrderAddressData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, EdgeOrderShippingAddress shippingAddress = null, EdgeOrderAddressContactDetails contactDetails = null, EdgeOrderAddressValidationStatus? addressValidationStatus = null)
        {
            tags ??= new Dictionary<string, string>();

            return new EdgeOrderAddressData(id, name, resourceType, systemData, tags, location, shippingAddress, contactDetails, addressValidationStatus);
        }

        /// <summary> Initializes a new instance of EdgeOrderItemAddressProperties. </summary>
        /// <param name="shippingAddress"> Shipping details for the address. </param>
        /// <param name="contactDetails"> Contact details for the address. </param>
        /// <param name="addressValidationStatus"> Status of address validation. </param>
        /// <returns> A new <see cref="Models.EdgeOrderItemAddressProperties"/> instance for mocking. </returns>
        public static EdgeOrderItemAddressProperties EdgeOrderItemAddressProperties(EdgeOrderShippingAddress shippingAddress = null, EdgeOrderAddressContactDetails contactDetails = null, EdgeOrderAddressValidationStatus? addressValidationStatus = null)
        {
            return new EdgeOrderItemAddressProperties(shippingAddress, contactDetails, addressValidationStatus);
        }

        /// <summary> Initializes a new instance of ProductFamily. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="productLines"> List of product lines supported in the product family. </param>
        /// <param name="resourceProviderDetails"> Contains details related to resource provider. </param>
        /// <returns> A new <see cref="Models.ProductFamily"/> instance for mocking. </returns>
        public static ProductFamily ProductFamily(string displayName = null, ProductDescription description = null, IEnumerable<EdgeOrderProductImageInformation> imageInformation = null, EdgeOrderProductCostInformation costInformation = null, ProductAvailabilityInformation availabilityInformation = null, HierarchyInformation hierarchyInformation = null, IEnumerable<FilterableProperty> filterableProperties = null, IEnumerable<ProductLine> productLines = null, IEnumerable<ResourceProviderDetails> resourceProviderDetails = null)
        {
            imageInformation ??= new List<EdgeOrderProductImageInformation>();
            filterableProperties ??= new List<FilterableProperty>();
            productLines ??= new List<ProductLine>();
            resourceProviderDetails ??= new List<ResourceProviderDetails>();

            return new ProductFamily(displayName, description, imageInformation?.ToList(), costInformation, availabilityInformation, hierarchyInformation, filterableProperties?.ToList(), productLines?.ToList(), resourceProviderDetails?.ToList());
        }

        /// <summary> Initializes a new instance of ProductLine. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="products"> List of products in the product line. </param>
        /// <returns> A new <see cref="Models.ProductLine"/> instance for mocking. </returns>
        public static ProductLine ProductLine(string displayName = null, ProductDescription description = null, IEnumerable<EdgeOrderProductImageInformation> imageInformation = null, EdgeOrderProductCostInformation costInformation = null, ProductAvailabilityInformation availabilityInformation = null, HierarchyInformation hierarchyInformation = null, IEnumerable<FilterableProperty> filterableProperties = null, IEnumerable<EdgeOrderProduct> products = null)
        {
            imageInformation ??= new List<EdgeOrderProductImageInformation>();
            filterableProperties ??= new List<FilterableProperty>();
            products ??= new List<EdgeOrderProduct>();

            return new ProductLine(displayName, description, imageInformation?.ToList(), costInformation, availabilityInformation, hierarchyInformation, filterableProperties?.ToList(), products?.ToList());
        }

        /// <summary> Initializes a new instance of EdgeOrderProduct. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="configurations"> List of configurations for the product. </param>
        /// <returns> A new <see cref="Models.EdgeOrderProduct"/> instance for mocking. </returns>
        public static EdgeOrderProduct EdgeOrderProduct(string displayName = null, ProductDescription description = null, IEnumerable<EdgeOrderProductImageInformation> imageInformation = null, EdgeOrderProductCostInformation costInformation = null, ProductAvailabilityInformation availabilityInformation = null, HierarchyInformation hierarchyInformation = null, IEnumerable<FilterableProperty> filterableProperties = null, IEnumerable<ProductConfiguration> configurations = null)
        {
            imageInformation ??= new List<EdgeOrderProductImageInformation>();
            filterableProperties ??= new List<FilterableProperty>();
            configurations ??= new List<ProductConfiguration>();

            return new EdgeOrderProduct(displayName, description, imageInformation?.ToList(), costInformation, availabilityInformation, hierarchyInformation, filterableProperties?.ToList(), configurations?.ToList());
        }

        /// <summary> Initializes a new instance of ProductConfiguration. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="specifications"> Specifications of the configuration. </param>
        /// <param name="dimensions"> Dimensions of the configuration. </param>
        /// <returns> A new <see cref="Models.ProductConfiguration"/> instance for mocking. </returns>
        public static ProductConfiguration ProductConfiguration(string displayName = null, ProductDescription description = null, IEnumerable<EdgeOrderProductImageInformation> imageInformation = null, EdgeOrderProductCostInformation costInformation = null, ProductAvailabilityInformation availabilityInformation = null, HierarchyInformation hierarchyInformation = null, IEnumerable<FilterableProperty> filterableProperties = null, IEnumerable<ProductSpecification> specifications = null, ProductDimensions dimensions = null)
        {
            imageInformation ??= new List<EdgeOrderProductImageInformation>();
            filterableProperties ??= new List<FilterableProperty>();
            specifications ??= new List<ProductSpecification>();

            return new ProductConfiguration(displayName, description, imageInformation?.ToList(), costInformation, availabilityInformation, hierarchyInformation, filterableProperties?.ToList(), specifications?.ToList(), dimensions);
        }

        /// <summary> Initializes a new instance of ProductSpecification. </summary>
        /// <param name="name"> Name of the specification. </param>
        /// <param name="value"> Value of the specification. </param>
        /// <returns> A new <see cref="Models.ProductSpecification"/> instance for mocking. </returns>
        public static ProductSpecification ProductSpecification(string name = null, string value = null)
        {
            return new ProductSpecification(name, value);
        }

        /// <summary> Initializes a new instance of ProductDimensions. </summary>
        /// <param name="length"> Length of the device. </param>
        /// <param name="height"> Height of the device. </param>
        /// <param name="width"> Width of the device. </param>
        /// <param name="lengthHeightUnit"> Unit for the dimensions of length, height and width. </param>
        /// <param name="weight"> Weight of the device. </param>
        /// <param name="depth"> Depth of the device. </param>
        /// <param name="weightUnit"> Unit for the dimensions of weight. </param>
        /// <returns> A new <see cref="Models.ProductDimensions"/> instance for mocking. </returns>
        public static ProductDimensions ProductDimensions(double? length = null, double? height = null, double? width = null, ProductLengthHeightWidthUnit? lengthHeightUnit = null, double? weight = null, double? depth = null, ProductWeightMeasurementUnit? weightUnit = null)
        {
            return new ProductDimensions(length, height, width, lengthHeightUnit, weight, depth, weightUnit);
        }

        /// <summary> Initializes a new instance of ProductDescription. </summary>
        /// <param name="descriptionType"> Type of description. </param>
        /// <param name="shortDescription"> Short description of the product system. </param>
        /// <param name="longDescription"> Long description of the product system. </param>
        /// <param name="keywords"> Keywords for the product system. </param>
        /// <param name="attributes"> Attributes for the product system. </param>
        /// <param name="links"> Links for the product system. </param>
        /// <returns> A new <see cref="Models.ProductDescription"/> instance for mocking. </returns>
        public static ProductDescription ProductDescription(ProductDescriptionType? descriptionType = null, string shortDescription = null, string longDescription = null, IEnumerable<string> keywords = null, IEnumerable<string> attributes = null, IEnumerable<ProductLink> links = null)
        {
            keywords ??= new List<string>();
            attributes ??= new List<string>();
            links ??= new List<ProductLink>();

            return new ProductDescription(descriptionType, shortDescription, longDescription, keywords?.ToList(), attributes?.ToList(), links?.ToList());
        }

        /// <summary> Initializes a new instance of ProductLink. </summary>
        /// <param name="linkType"> Type of link. </param>
        /// <param name="linkUri"> Url of the link. </param>
        /// <returns> A new <see cref="Models.ProductLink"/> instance for mocking. </returns>
        public static ProductLink ProductLink(ProductLinkType? linkType = null, Uri linkUri = null)
        {
            return new ProductLink(linkType, linkUri);
        }

        /// <summary> Initializes a new instance of EdgeOrderProductImageInformation. </summary>
        /// <param name="imageType"> Type of the image. </param>
        /// <param name="imageUri"> Url of the image. </param>
        /// <returns> A new <see cref="Models.EdgeOrderProductImageInformation"/> instance for mocking. </returns>
        public static EdgeOrderProductImageInformation EdgeOrderProductImageInformation(EdgeOrderProductImageType? imageType = null, Uri imageUri = null)
        {
            return new EdgeOrderProductImageInformation(imageType, imageUri);
        }

        /// <summary> Initializes a new instance of EdgeOrderProductCostInformation. </summary>
        /// <param name="billingMeterDetails"> Details on the various billing aspects for the product system. </param>
        /// <param name="billingInfoUri"> Default url to display billing information. </param>
        /// <returns> A new <see cref="Models.EdgeOrderProductCostInformation"/> instance for mocking. </returns>
        public static EdgeOrderProductCostInformation EdgeOrderProductCostInformation(IEnumerable<EdgeOrderProductBillingMeterDetails> billingMeterDetails = null, Uri billingInfoUri = null)
        {
            billingMeterDetails ??= new List<EdgeOrderProductBillingMeterDetails>();

            return new EdgeOrderProductCostInformation(billingMeterDetails?.ToList(), billingInfoUri);
        }

        /// <summary> Initializes a new instance of EdgeOrderProductBillingMeterDetails. </summary>
        /// <param name="name"> Represents Billing type name. </param>
        /// <param name="meterDetails">
        /// Represents MeterDetails
        /// Please note <see cref="EdgeOrderProductMeterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Pav2MeterDetails"/> and <see cref="PurchaseMeterDetails"/>.
        /// </param>
        /// <param name="meteringType"> Represents Metering type (eg one-time or recurrent). </param>
        /// <param name="frequency"> Frequency of recurrence. </param>
        /// <returns> A new <see cref="Models.EdgeOrderProductBillingMeterDetails"/> instance for mocking. </returns>
        public static EdgeOrderProductBillingMeterDetails EdgeOrderProductBillingMeterDetails(string name = null, EdgeOrderProductMeterDetails meterDetails = null, EdgeOrderProductMeteringType? meteringType = null, string frequency = null)
        {
            return new EdgeOrderProductBillingMeterDetails(name, meterDetails, meteringType, frequency);
        }

        /// <summary> Initializes a new instance of EdgeOrderProductMeterDetails. </summary>
        /// <param name="billingType"> Represents billing type. </param>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        /// <returns> A new <see cref="Models.EdgeOrderProductMeterDetails"/> instance for mocking. </returns>
        public static EdgeOrderProductMeterDetails EdgeOrderProductMeterDetails(string billingType = "Unknown", double? multiplier = null, EdgeOrderProductChargingType? chargingType = null)
        {
            return new UnknownMeterDetails(billingType, multiplier, chargingType);
        }

        /// <summary> Initializes a new instance of ProductAvailabilityInformation. </summary>
        /// <param name="availabilityStage"> Current availability stage of the product. Availability stage. </param>
        /// <param name="disabledReason"> Reason why the product is disabled. </param>
        /// <param name="disabledReasonMessage"> Message for why the product is disabled. </param>
        /// <returns> A new <see cref="Models.ProductAvailabilityInformation"/> instance for mocking. </returns>
        public static ProductAvailabilityInformation ProductAvailabilityInformation(ProductAvailabilityStage? availabilityStage = null, ProductDisabledReason? disabledReason = null, string disabledReasonMessage = null)
        {
            return new ProductAvailabilityInformation(availabilityStage, disabledReason, disabledReasonMessage);
        }

        /// <summary> Initializes a new instance of ResourceProviderDetails. </summary>
        /// <param name="resourceProviderNamespace"> Resource provider namespace. </param>
        /// <returns> A new <see cref="Models.ResourceProviderDetails"/> instance for mocking. </returns>
        public static ResourceProviderDetails ResourceProviderDetails(string resourceProviderNamespace = null)
        {
            return new ResourceProviderDetails(resourceProviderNamespace);
        }

        /// <summary> Initializes a new instance of ProductFamiliesMetadata. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="productLines"> List of product lines supported in the product family. </param>
        /// <param name="resourceProviderDetails"> Contains details related to resource provider. </param>
        /// <returns> A new <see cref="Models.ProductFamiliesMetadata"/> instance for mocking. </returns>
        public static ProductFamiliesMetadata ProductFamiliesMetadata(string displayName = null, ProductDescription description = null, IEnumerable<EdgeOrderProductImageInformation> imageInformation = null, EdgeOrderProductCostInformation costInformation = null, ProductAvailabilityInformation availabilityInformation = null, HierarchyInformation hierarchyInformation = null, IEnumerable<FilterableProperty> filterableProperties = null, IEnumerable<ProductLine> productLines = null, IEnumerable<ResourceProviderDetails> resourceProviderDetails = null)
        {
            imageInformation ??= new List<EdgeOrderProductImageInformation>();
            filterableProperties ??= new List<FilterableProperty>();
            productLines ??= new List<ProductLine>();
            resourceProviderDetails ??= new List<ResourceProviderDetails>();

            return new ProductFamiliesMetadata(displayName, description, imageInformation?.ToList(), costInformation, availabilityInformation, hierarchyInformation, filterableProperties?.ToList(), productLines?.ToList(), resourceProviderDetails?.ToList());
        }

        /// <summary> Initializes a new instance of EdgeOrderData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="orderItemIds"> List of order item ARM Ids which are part of an order. </param>
        /// <param name="currentStage"> Order current status. </param>
        /// <param name="orderStageHistory"> Order status history. </param>
        /// <returns> A new <see cref="EdgeOrder.EdgeOrderData"/> instance for mocking. </returns>
        public static EdgeOrderData EdgeOrderData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<ResourceIdentifier> orderItemIds = null, EdgeOrderStageDetails currentStage = null, IEnumerable<EdgeOrderStageDetails> orderStageHistory = null)
        {
            orderItemIds ??= new List<ResourceIdentifier>();
            orderStageHistory ??= new List<EdgeOrderStageDetails>();

            return new EdgeOrderData(id, name, resourceType, systemData, orderItemIds?.ToList(), currentStage, orderStageHistory?.ToList());
        }

        /// <summary> Initializes a new instance of EdgeOrderStageDetails. </summary>
        /// <param name="stageStatus"> Stage status. </param>
        /// <param name="stageName"> Stage name. </param>
        /// <param name="displayName"> Display name of the resource stage. </param>
        /// <param name="startOn"> Stage start time. </param>
        /// <returns> A new <see cref="Models.EdgeOrderStageDetails"/> instance for mocking. </returns>
        public static EdgeOrderStageDetails EdgeOrderStageDetails(EdgeOrderStageStatus? stageStatus = null, EdgeOrderStageName? stageName = null, string displayName = null, DateTimeOffset? startOn = null)
        {
            return new EdgeOrderStageDetails(stageStatus, stageName, displayName, startOn);
        }

        /// <summary> Initializes a new instance of EdgeOrderItemData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="orderItemDetails"> Represents order item details. </param>
        /// <param name="addressDetails"> Represents shipping and return address for order item. </param>
        /// <param name="startOn"> Start time of order item. </param>
        /// <param name="orderId"> Id of the order to which order item belongs to. </param>
        /// <returns> A new <see cref="EdgeOrder.EdgeOrderItemData"/> instance for mocking. </returns>
        public static EdgeOrderItemData EdgeOrderItemData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, EdgeOrderItemDetails orderItemDetails = null, EdgeOrderItemAddressDetails addressDetails = null, DateTimeOffset? startOn = null, ResourceIdentifier orderId = null)
        {
            tags ??= new Dictionary<string, string>();

            return new EdgeOrderItemData(id, name, resourceType, systemData, tags, location, orderItemDetails, addressDetails, startOn, orderId);
        }

        /// <summary> Initializes a new instance of EdgeOrderItemDetails. </summary>
        /// <param name="productDetails"> Unique identifier for configuration. </param>
        /// <param name="orderItemType"> Order item type. </param>
        /// <param name="currentStage"> Current Order item Status. </param>
        /// <param name="orderItemStageHistory"> Order item status history. </param>
        /// <param name="preferences"> Customer notification Preferences. </param>
        /// <param name="forwardShippingDetails"> Forward Package Shipping details. </param>
        /// <param name="reverseShippingDetails"> Reverse Package Shipping details. </param>
        /// <param name="notificationEmailList"> Additional notification email list. </param>
        /// <param name="cancellationReason"> Cancellation reason. </param>
        /// <param name="cancellationStatus"> Describes whether the order item is cancellable or not. </param>
        /// <param name="deletionStatus"> Describes whether the order item is deletable or not. </param>
        /// <param name="returnReason"> Return reason. </param>
        /// <param name="returnStatus"> Describes whether the order item is returnable or not. </param>
        /// <param name="firstOrDefaultManagementResourceProviderNamespace"> Parent RP details - this returns only the first or default parent RP from the entire list. </param>
        /// <param name="managementRPDetailsList"> List of parent RP details supported for configuration. </param>
        /// <param name="error"> Top level error for the job. </param>
        /// <returns> A new <see cref="Models.EdgeOrderItemDetails"/> instance for mocking. </returns>
        public static EdgeOrderItemDetails EdgeOrderItemDetails(ProductDetails productDetails = null, OrderItemType orderItemType = default, EdgeOrderStageDetails currentStage = null, IEnumerable<EdgeOrderStageDetails> orderItemStageHistory = null, OrderItemPreferences preferences = null, ForwardShippingDetails forwardShippingDetails = null, ReverseShippingDetails reverseShippingDetails = null, IEnumerable<string> notificationEmailList = null, string cancellationReason = null, OrderItemCancellationStatus? cancellationStatus = null, EdgeOrderActionStatus? deletionStatus = null, string returnReason = null, OrderItemReturnStatus? returnStatus = null, string firstOrDefaultManagementResourceProviderNamespace = null, IEnumerable<ResourceProviderDetails> managementRPDetailsList = null, ResponseError error = null)
        {
            orderItemStageHistory ??= new List<EdgeOrderStageDetails>();
            notificationEmailList ??= new List<string>();
            managementRPDetailsList ??= new List<ResourceProviderDetails>();

            return new EdgeOrderItemDetails(productDetails, orderItemType, currentStage, orderItemStageHistory?.ToList(), preferences, forwardShippingDetails, reverseShippingDetails, notificationEmailList?.ToList(), cancellationReason, cancellationStatus, deletionStatus, returnReason, returnStatus, firstOrDefaultManagementResourceProviderNamespace != null ? new ResourceProviderDetails(firstOrDefaultManagementResourceProviderNamespace) : null, managementRPDetailsList?.ToList(), error);
        }

        /// <summary> Initializes a new instance of ProductDetails. </summary>
        /// <param name="displayInfo"> Display details of the product. </param>
        /// <param name="hierarchyInformation"> Hierarchy of the product which uniquely identifies the product. </param>
        /// <param name="count"> Quantity of the product. </param>
        /// <param name="productDoubleEncryptionStatus"> Double encryption status of the configuration. Read-only field. </param>
        /// <param name="deviceDetails"> list of device details. </param>
        /// <returns> A new <see cref="Models.ProductDetails"/> instance for mocking. </returns>
        public static ProductDetails ProductDetails(ProductDisplayInfo displayInfo = null, HierarchyInformation hierarchyInformation = null, int? count = null, DoubleEncryptionStatus? productDoubleEncryptionStatus = null, IEnumerable<EdgeOrderProductDeviceDetails> deviceDetails = null)
        {
            deviceDetails ??= new List<EdgeOrderProductDeviceDetails>();

            return new ProductDetails(displayInfo, hierarchyInformation, count, productDoubleEncryptionStatus, deviceDetails?.ToList());
        }

        /// <summary> Initializes a new instance of ProductDisplayInfo. </summary>
        /// <param name="productFamilyDisplayName"> Product family display name. </param>
        /// <param name="configurationDisplayName"> Configuration display name. </param>
        /// <returns> A new <see cref="Models.ProductDisplayInfo"/> instance for mocking. </returns>
        public static ProductDisplayInfo ProductDisplayInfo(string productFamilyDisplayName = null, string configurationDisplayName = null)
        {
            return new ProductDisplayInfo(productFamilyDisplayName, configurationDisplayName);
        }

        /// <summary> Initializes a new instance of EdgeOrderProductDeviceDetails. </summary>
        /// <param name="serialNumber"> device serial number. </param>
        /// <param name="managementResourceId"> Management Resource Id. </param>
        /// <param name="managementResourceTenantId"> Management Resource Tenant ID. </param>
        /// <returns> A new <see cref="Models.EdgeOrderProductDeviceDetails"/> instance for mocking. </returns>
        public static EdgeOrderProductDeviceDetails EdgeOrderProductDeviceDetails(string serialNumber = null, string managementResourceId = null, string managementResourceTenantId = null)
        {
            return new EdgeOrderProductDeviceDetails(serialNumber, managementResourceId, managementResourceTenantId);
        }

        /// <summary> Initializes a new instance of ForwardShippingDetails. </summary>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="carrierDisplayName"> Carrier Name for display purpose. Not to be used for any processing. </param>
        /// <param name="trackingId"> TrackingId of the package. </param>
        /// <param name="trackingUri"> TrackingUrl of the package. </param>
        /// <returns> A new <see cref="Models.ForwardShippingDetails"/> instance for mocking. </returns>
        public static ForwardShippingDetails ForwardShippingDetails(string carrierName = null, string carrierDisplayName = null, string trackingId = null, Uri trackingUri = null)
        {
            return new ForwardShippingDetails(carrierName, carrierDisplayName, trackingId, trackingUri);
        }

        /// <summary> Initializes a new instance of ReverseShippingDetails. </summary>
        /// <param name="sasKeyForLabel"> SAS key to download the reverse shipment label of the package. </param>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="carrierDisplayName"> Carrier Name for display purpose. Not to be used for any processing. </param>
        /// <param name="trackingId"> TrackingId of the package. </param>
        /// <param name="trackingUri"> TrackingUrl of the package. </param>
        /// <returns> A new <see cref="Models.ReverseShippingDetails"/> instance for mocking. </returns>
        public static ReverseShippingDetails ReverseShippingDetails(string sasKeyForLabel = null, string carrierName = null, string carrierDisplayName = null, string trackingId = null, Uri trackingUri = null)
        {
            return new ReverseShippingDetails(sasKeyForLabel, carrierName, carrierDisplayName, trackingId, trackingUri);
        }

        /// <summary> Initializes a new instance of EdgeOrderItemAddressDetails. </summary>
        /// <param name="forwardAddress"> Customer address and contact details. It should be address resource. </param>
        /// <param name="returnAddress"> Return shipping address. </param>
        /// <returns> A new <see cref="Models.EdgeOrderItemAddressDetails"/> instance for mocking. </returns>
        public static EdgeOrderItemAddressDetails EdgeOrderItemAddressDetails(EdgeOrderItemAddressProperties forwardAddress = null, EdgeOrderItemAddressProperties returnAddress = null)
        {
            return new EdgeOrderItemAddressDetails(forwardAddress, returnAddress);
        }

        /// <summary> Initializes a new instance of Pav2MeterDetails. </summary>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        /// <param name="meterGuid"> Validation status of requested data center and transport. </param>
        /// <returns> A new <see cref="Models.Pav2MeterDetails"/> instance for mocking. </returns>
        public static Pav2MeterDetails Pav2MeterDetails(double? multiplier = null, EdgeOrderProductChargingType? chargingType = null, Guid? meterGuid = null)
        {
            return new Pav2MeterDetails(BillingType.Pav2, multiplier, chargingType, meterGuid);
        }

        /// <summary> Initializes a new instance of PurchaseMeterDetails. </summary>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        /// <param name="productId"> Product Id. </param>
        /// <param name="skuId"> Sku Id. </param>
        /// <param name="termId"> Term Id. </param>
        /// <returns> A new <see cref="Models.PurchaseMeterDetails"/> instance for mocking. </returns>
        public static PurchaseMeterDetails PurchaseMeterDetails(double? multiplier = null, EdgeOrderProductChargingType? chargingType = null, string productId = null, string skuId = null, string termId = null)
        {
            return new PurchaseMeterDetails(BillingType.Purchase, multiplier, chargingType, productId, skuId, termId);
        }
    }
}
