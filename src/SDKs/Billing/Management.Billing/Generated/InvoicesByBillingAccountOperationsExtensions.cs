// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InvoicesByBillingAccountOperations.
    /// </summary>
    public static partial class InvoicesByBillingAccountOperationsExtensions
    {
            /// <summary>
            /// List of invoices for a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            public static InvoiceListResult List(this IInvoicesByBillingAccountOperations operations, string billingAccountName, string periodStartDate, string periodEndDate)
            {
                return operations.ListAsync(billingAccountName, periodStartDate, periodEndDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of invoices for a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceListResult> ListAsync(this IInvoicesByBillingAccountOperations operations, string billingAccountName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountName, periodStartDate, periodEndDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}