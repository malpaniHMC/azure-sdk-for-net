// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotaByPeriodKeysOperations.
    /// </summary>
    public static partial class QuotaByPeriodKeysOperationsExtensions
    {
            /// <summary>
            /// Gets the value of the quota counter associated with the counter-key in the
            /// policy for the specific period in service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-product-with-rules#a-namepolicies-ato-configure-call-rate-limit-and-quota-policies" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='quotaPeriodKey'>
            /// Quota period key identifier.
            /// </param>
            public static QuotaCounterContract Get(this IQuotaByPeriodKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey)
            {
                return operations.GetAsync(resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the value of the quota counter associated with the counter-key in the
            /// policy for the specific period in service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-product-with-rules#a-namepolicies-ato-configure-call-rate-limit-and-quota-policies" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='quotaPeriodKey'>
            /// Quota period key identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QuotaCounterContract> GetAsync(this IQuotaByPeriodKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing quota counter value in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='quotaPeriodKey'>
            /// Quota period key identifier.
            /// </param>
            /// <param name='parameters'>
            /// The value of the Quota counter to be applied on the specified period.
            /// </param>
            public static QuotaCounterContract Update(this IQuotaByPeriodKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, QuotaCounterValueUpdateContract parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing quota counter value in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='quotaPeriodKey'>
            /// Quota period key identifier.
            /// </param>
            /// <param name='parameters'>
            /// The value of the Quota counter to be applied on the specified period.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QuotaCounterContract> UpdateAsync(this IQuotaByPeriodKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, string quotaPeriodKey, QuotaCounterValueUpdateContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, quotaCounterKey, quotaPeriodKey, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
