// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseExtendedServerBlobAuditingPolicyResource" /> and their operations.
    /// Each <see cref="SynapseExtendedServerBlobAuditingPolicyResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseExtendedServerBlobAuditingPolicyCollection" /> instance call the GetSynapseExtendedServerBlobAuditingPolicies method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseExtendedServerBlobAuditingPolicyCollection : ArmCollection, IEnumerable<SynapseExtendedServerBlobAuditingPolicyResource>, IAsyncEnumerable<SynapseExtendedServerBlobAuditingPolicyResource>
    {
        private readonly ClientDiagnostics _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics;
        private readonly WorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestOperations _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseExtendedServerBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected SynapseExtendedServerBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseExtendedServerBlobAuditingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseExtendedServerBlobAuditingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseExtendedServerBlobAuditingPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseExtendedServerBlobAuditingPolicyResource.ResourceType, out string synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesApiVersion);
            _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient = new WorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a workspace managed sql server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseExtendedServerBlobAuditingPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseBlobAuditingPolicyName blobAuditingPolicyName, SynapseExtendedServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseExtendedServerBlobAuditingPolicyResource>(new SynapseExtendedServerBlobAuditingPolicyOperationSource(Client), _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update a workspace managed sql server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseExtendedServerBlobAuditingPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SynapseBlobAuditingPolicyName blobAuditingPolicyName, SynapseExtendedServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseExtendedServerBlobAuditingPolicyResource>(new SynapseExtendedServerBlobAuditingPolicyOperationSource(Client), _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace SQL server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseExtendedServerBlobAuditingPolicyResource>> GetAsync(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseExtendedServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace SQL server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseExtendedServerBlobAuditingPolicyResource> Get(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseExtendedServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List workspace managed sql server's extended blob auditing policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseExtendedServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseExtendedServerBlobAuditingPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseExtendedServerBlobAuditingPolicyResource(Client, SynapseExtendedServerBlobAuditingPolicyData.DeserializeSynapseExtendedServerBlobAuditingPolicyData(e)), _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics, Pipeline, "SynapseExtendedServerBlobAuditingPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List workspace managed sql server's extended blob auditing policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseExtendedServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseExtendedServerBlobAuditingPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseExtendedServerBlobAuditingPolicyResource(Client, SynapseExtendedServerBlobAuditingPolicyData.DeserializeSynapseExtendedServerBlobAuditingPolicyData(e)), _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics, Pipeline, "SynapseExtendedServerBlobAuditingPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseExtendedServerBlobAuditingPolicyResource> IEnumerable<SynapseExtendedServerBlobAuditingPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseExtendedServerBlobAuditingPolicyResource> IAsyncEnumerable<SynapseExtendedServerBlobAuditingPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
