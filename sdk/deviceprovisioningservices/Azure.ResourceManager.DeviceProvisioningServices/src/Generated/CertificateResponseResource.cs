// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceProvisioningServices.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A Class representing a CertificateResponse along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CertificateResponseResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCertificateResponseResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProvisioningServiceDescriptionResource" /> using the GetCertificateResponse method.
    /// </summary>
    public partial class CertificateResponseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CertificateResponseResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string provisioningServiceName, string certificateName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _certificateResponseDpsCertificateClientDiagnostics;
        private readonly DpsCertificateRestOperations _certificateResponseDpsCertificateRestClient;
        private readonly CertificateResponseData _data;

        /// <summary> Initializes a new instance of the <see cref="CertificateResponseResource"/> class for mocking. </summary>
        protected CertificateResponseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CertificateResponseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CertificateResponseResource(ArmClient client, CertificateResponseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CertificateResponseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CertificateResponseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _certificateResponseDpsCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string certificateResponseDpsCertificateApiVersion);
            _certificateResponseDpsCertificateRestClient = new DpsCertificateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, certificateResponseDpsCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Devices/provisioningServices/certificates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CertificateResponseData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the certificate from the provisioning service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}
        /// Operation Id: DpsCertificate_Get
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CertificateResponseResource>> GetAsync(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.Get");
            scope.Start();
            try
            {
                var response = await _certificateResponseDpsCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the certificate from the provisioning service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}
        /// Operation Id: DpsCertificate_Get
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CertificateResponseResource> Get(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.Get");
            scope.Start();
            try
            {
                var response = _certificateResponseDpsCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified certificate associated with the Provisioning Service
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}
        /// Operation Id: DpsCertificate_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="certificateName1"> This is optional, and it is the Common Name of the certificate. </param>
        /// <param name="certificateRawBytes"> Raw data within the certificate. </param>
        /// <param name="certificateIsVerified"> Indicates if certificate has been verified by owner of the private key. </param>
        /// <param name="certificatePurpose"> A description that mentions the purpose of the certificate. </param>
        /// <param name="certificateCreated"> Time the certificate is created. </param>
        /// <param name="certificateLastUpdated"> Time the certificate is last updated. </param>
        /// <param name="certificateHasPrivateKey"> Indicates if the certificate contains a private key. </param>
        /// <param name="certificateNonce"> Random number generated to indicate Proof of Possession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch, string certificateName1 = null, byte[] certificateRawBytes = null, bool? certificateIsVerified = null, CertificatePurpose? certificatePurpose = null, DateTimeOffset? certificateCreated = null, DateTimeOffset? certificateLastUpdated = null, bool? certificateHasPrivateKey = null, string certificateNonce = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.Delete");
            scope.Start();
            try
            {
                var response = await _certificateResponseDpsCertificateRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, certificateName1, certificateRawBytes, certificateIsVerified, certificatePurpose, certificateCreated, certificateLastUpdated, certificateHasPrivateKey, certificateNonce, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified certificate associated with the Provisioning Service
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}
        /// Operation Id: DpsCertificate_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="certificateName1"> This is optional, and it is the Common Name of the certificate. </param>
        /// <param name="certificateRawBytes"> Raw data within the certificate. </param>
        /// <param name="certificateIsVerified"> Indicates if certificate has been verified by owner of the private key. </param>
        /// <param name="certificatePurpose"> A description that mentions the purpose of the certificate. </param>
        /// <param name="certificateCreated"> Time the certificate is created. </param>
        /// <param name="certificateLastUpdated"> Time the certificate is last updated. </param>
        /// <param name="certificateHasPrivateKey"> Indicates if the certificate contains a private key. </param>
        /// <param name="certificateNonce"> Random number generated to indicate Proof of Possession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string ifMatch, string certificateName1 = null, byte[] certificateRawBytes = null, bool? certificateIsVerified = null, CertificatePurpose? certificatePurpose = null, DateTimeOffset? certificateCreated = null, DateTimeOffset? certificateLastUpdated = null, bool? certificateHasPrivateKey = null, string certificateNonce = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.Delete");
            scope.Start();
            try
            {
                var response = _certificateResponseDpsCertificateRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, certificateName1, certificateRawBytes, certificateIsVerified, certificatePurpose, certificateCreated, certificateLastUpdated, certificateHasPrivateKey, certificateNonce, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add new certificate or update an existing certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}
        /// Operation Id: DpsCertificate_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CertificateResponseResource>> UpdateAsync(WaitUntil waitUntil, CertificateResponseData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.Update");
            scope.Start();
            try
            {
                var response = await _certificateResponseDpsCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation<CertificateResponseResource>(Response.FromValue(new CertificateResponseResource(Client, response), response.GetRawResponse()));
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
        /// Add new certificate or update an existing certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}
        /// Operation Id: DpsCertificate_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CertificateResponseResource> Update(WaitUntil waitUntil, CertificateResponseData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.Update");
            scope.Start();
            try
            {
                var response = _certificateResponseDpsCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation<CertificateResponseResource>(Response.FromValue(new CertificateResponseResource(Client, response), response.GetRawResponse()));
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
        /// Generate verification code for Proof of Possession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/generateVerificationCode
        /// Operation Id: DpsCertificate_GenerateVerificationCode
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="certificateName1"> Common Name for the certificate. </param>
        /// <param name="certificateRawBytes"> Raw data of certificate. </param>
        /// <param name="certificateIsVerified"> Indicates if the certificate has been verified by owner of the private key. </param>
        /// <param name="certificatePurpose"> Description mentioning the purpose of the certificate. </param>
        /// <param name="certificateCreated"> Certificate creation time. </param>
        /// <param name="certificateLastUpdated"> Certificate last updated time. </param>
        /// <param name="certificateHasPrivateKey"> Indicates if the certificate contains private key. </param>
        /// <param name="certificateNonce"> Random number generated to indicate Proof of Possession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<Response<VerificationCodeResponse>> GenerateVerificationCodeAsync(string ifMatch, string certificateName1 = null, byte[] certificateRawBytes = null, bool? certificateIsVerified = null, CertificatePurpose? certificatePurpose = null, DateTimeOffset? certificateCreated = null, DateTimeOffset? certificateLastUpdated = null, bool? certificateHasPrivateKey = null, string certificateNonce = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.GenerateVerificationCode");
            scope.Start();
            try
            {
                var response = await _certificateResponseDpsCertificateRestClient.GenerateVerificationCodeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, certificateName1, certificateRawBytes, certificateIsVerified, certificatePurpose, certificateCreated, certificateLastUpdated, certificateHasPrivateKey, certificateNonce, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generate verification code for Proof of Possession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/generateVerificationCode
        /// Operation Id: DpsCertificate_GenerateVerificationCode
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="certificateName1"> Common Name for the certificate. </param>
        /// <param name="certificateRawBytes"> Raw data of certificate. </param>
        /// <param name="certificateIsVerified"> Indicates if the certificate has been verified by owner of the private key. </param>
        /// <param name="certificatePurpose"> Description mentioning the purpose of the certificate. </param>
        /// <param name="certificateCreated"> Certificate creation time. </param>
        /// <param name="certificateLastUpdated"> Certificate last updated time. </param>
        /// <param name="certificateHasPrivateKey"> Indicates if the certificate contains private key. </param>
        /// <param name="certificateNonce"> Random number generated to indicate Proof of Possession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual Response<VerificationCodeResponse> GenerateVerificationCode(string ifMatch, string certificateName1 = null, byte[] certificateRawBytes = null, bool? certificateIsVerified = null, CertificatePurpose? certificatePurpose = null, DateTimeOffset? certificateCreated = null, DateTimeOffset? certificateLastUpdated = null, bool? certificateHasPrivateKey = null, string certificateNonce = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.GenerateVerificationCode");
            scope.Start();
            try
            {
                var response = _certificateResponseDpsCertificateRestClient.GenerateVerificationCode(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, certificateName1, certificateRawBytes, certificateIsVerified, certificatePurpose, certificateCreated, certificateLastUpdated, certificateHasPrivateKey, certificateNonce, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the certificate&apos;s private key possession by providing the leaf cert issued by the verifying pre uploaded certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/verify
        /// Operation Id: DpsCertificate_VerifyCertificate
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="content"> The name of the certificate. </param>
        /// <param name="certificateName1"> Common Name for the certificate. </param>
        /// <param name="certificateRawBytes"> Raw data of certificate. </param>
        /// <param name="certificateIsVerified"> Indicates if the certificate has been verified by owner of the private key. </param>
        /// <param name="certificatePurpose"> Describe the purpose of the certificate. </param>
        /// <param name="certificateCreated"> Certificate creation time. </param>
        /// <param name="certificateLastUpdated"> Certificate last updated time. </param>
        /// <param name="certificateHasPrivateKey"> Indicates if the certificate contains private key. </param>
        /// <param name="certificateNonce"> Random number generated to indicate Proof of Possession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CertificateResponseResource>> VerifyCertificateAsync(string ifMatch, VerificationCodeContent content, string certificateName1 = null, byte[] certificateRawBytes = null, bool? certificateIsVerified = null, CertificatePurpose? certificatePurpose = null, DateTimeOffset? certificateCreated = null, DateTimeOffset? certificateLastUpdated = null, bool? certificateHasPrivateKey = null, string certificateNonce = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.VerifyCertificate");
            scope.Start();
            try
            {
                var response = await _certificateResponseDpsCertificateRestClient.VerifyCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, content, certificateName1, certificateRawBytes, certificateIsVerified, certificatePurpose, certificateCreated, certificateLastUpdated, certificateHasPrivateKey, certificateNonce, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CertificateResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the certificate&apos;s private key possession by providing the leaf cert issued by the verifying pre uploaded certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/verify
        /// Operation Id: DpsCertificate_VerifyCertificate
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="content"> The name of the certificate. </param>
        /// <param name="certificateName1"> Common Name for the certificate. </param>
        /// <param name="certificateRawBytes"> Raw data of certificate. </param>
        /// <param name="certificateIsVerified"> Indicates if the certificate has been verified by owner of the private key. </param>
        /// <param name="certificatePurpose"> Describe the purpose of the certificate. </param>
        /// <param name="certificateCreated"> Certificate creation time. </param>
        /// <param name="certificateLastUpdated"> Certificate last updated time. </param>
        /// <param name="certificateHasPrivateKey"> Indicates if the certificate contains private key. </param>
        /// <param name="certificateNonce"> Random number generated to indicate Proof of Possession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="content"/> is null. </exception>
        public virtual Response<CertificateResponseResource> VerifyCertificate(string ifMatch, VerificationCodeContent content, string certificateName1 = null, byte[] certificateRawBytes = null, bool? certificateIsVerified = null, CertificatePurpose? certificatePurpose = null, DateTimeOffset? certificateCreated = null, DateTimeOffset? certificateLastUpdated = null, bool? certificateHasPrivateKey = null, string certificateNonce = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _certificateResponseDpsCertificateClientDiagnostics.CreateScope("CertificateResponseResource.VerifyCertificate");
            scope.Start();
            try
            {
                var response = _certificateResponseDpsCertificateRestClient.VerifyCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, content, certificateName1, certificateRawBytes, certificateIsVerified, certificatePurpose, certificateCreated, certificateLastUpdated, certificateHasPrivateKey, certificateNonce, cancellationToken);
                return Response.FromValue(new CertificateResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
