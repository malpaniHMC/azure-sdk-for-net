// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _accountsClientDiagnostics;
        private AccountsRestOperations _accountsRestClient;
        private ClientDiagnostics _newRelicMonitorResourceMonitorsClientDiagnostics;
        private MonitorsRestOperations _newRelicMonitorResourceMonitorsRestClient;
        private ClientDiagnostics _organizationsClientDiagnostics;
        private OrganizationsRestOperations _organizationsRestClient;
        private ClientDiagnostics _plansClientDiagnostics;
        private PlansRestOperations _plansRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AccountsClientDiagnostics => _accountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NewRelicObservability", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AccountsRestOperations AccountsRestClient => _accountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NewRelicMonitorResourceMonitorsClientDiagnostics => _newRelicMonitorResourceMonitorsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NewRelicObservability", NewRelicMonitorResource.ResourceType.Namespace, Diagnostics);
        private MonitorsRestOperations NewRelicMonitorResourceMonitorsRestClient => _newRelicMonitorResourceMonitorsRestClient ??= new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NewRelicMonitorResource.ResourceType));
        private ClientDiagnostics OrganizationsClientDiagnostics => _organizationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NewRelicObservability", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OrganizationsRestOperations OrganizationsRestClient => _organizationsRestClient ??= new OrganizationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PlansClientDiagnostics => _plansClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NewRelicObservability", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PlansRestOperations PlansRestClient => _plansRestClient ??= new PlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the existing accounts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicAccountResourceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NewRelicAccountResourceData> GetNewRelicAccountsAsync(string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AccountsRestClient.CreateListRequest(Id.SubscriptionId, userEmail, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, userEmail, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, NewRelicAccountResourceData.DeserializeNewRelicAccountResourceData, AccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the existing accounts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicAccountResourceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NewRelicAccountResourceData> GetNewRelicAccounts(string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AccountsRestClient.CreateListRequest(Id.SubscriptionId, userEmail, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, userEmail, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, NewRelicAccountResourceData.DeserializeNewRelicAccountResourceData, AccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List NewRelicMonitorResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NewRelicMonitorResource> GetNewRelicMonitorResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NewRelicMonitorResourceMonitorsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NewRelicMonitorResourceMonitorsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NewRelicMonitorResource(Client, NewRelicMonitorResourceData.DeserializeNewRelicMonitorResourceData(e)), NewRelicMonitorResourceMonitorsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicMonitorResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List NewRelicMonitorResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NewRelicMonitorResource> GetNewRelicMonitorResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NewRelicMonitorResourceMonitorsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NewRelicMonitorResourceMonitorsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NewRelicMonitorResource(Client, NewRelicMonitorResourceData.DeserializeNewRelicMonitorResourceData(e)), NewRelicMonitorResourceMonitorsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicMonitorResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the existing organizations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicOrganizationResourceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NewRelicOrganizationResourceData> GetNewRelicOrganizationsAsync(string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OrganizationsRestClient.CreateListRequest(Id.SubscriptionId, userEmail, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OrganizationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, userEmail, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, NewRelicOrganizationResourceData.DeserializeNewRelicOrganizationResourceData, OrganizationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicOrganizations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the existing organizations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicOrganizationResourceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NewRelicOrganizationResourceData> GetNewRelicOrganizations(string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OrganizationsRestClient.CreateListRequest(Id.SubscriptionId, userEmail, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OrganizationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, userEmail, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, NewRelicOrganizationResourceData.DeserializeNewRelicOrganizationResourceData, OrganizationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicOrganizations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List plans data
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/plans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Plans_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountId"> Account Id. </param>
        /// <param name="organizationId"> Organization Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicPlanData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NewRelicPlanData> GetNewRelicPlansAsync(string accountId = null, string organizationId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PlansRestClient.CreateListRequest(Id.SubscriptionId, accountId, organizationId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PlansRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, accountId, organizationId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, NewRelicPlanData.DeserializeNewRelicPlanData, PlansClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicPlans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List plans data
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/plans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Plans_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountId"> Account Id. </param>
        /// <param name="organizationId"> Organization Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicPlanData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NewRelicPlanData> GetNewRelicPlans(string accountId = null, string organizationId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PlansRestClient.CreateListRequest(Id.SubscriptionId, accountId, organizationId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PlansRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, accountId, organizationId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, NewRelicPlanData.DeserializeNewRelicPlanData, PlansClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNewRelicPlans", "value", "nextLink", cancellationToken);
        }
    }
}
