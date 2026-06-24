// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts.PricingLines
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuantityChangeService : Service
    {
        internal QuantityChangeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal QuantityChangeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// List quantity changes for a pricing line on a contract.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.ContractPricingLineQuantityChange> ListContractPricingLineQuantityChanges(string parentId, string id, QuantityChangeListContractPricingLineQuantityChangesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.ContractPricingLineQuantityChange>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/pricing_lines/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions);
        }

        /// <summary>
        /// List quantity changes for a pricing line on a contract.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.ContractPricingLineQuantityChange>> ListContractPricingLineQuantityChangesAsync(string parentId, string id, QuantityChangeListContractPricingLineQuantityChangesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.ContractPricingLineQuantityChange>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/pricing_lines/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List quantity changes for a pricing line on a contract.
        /// </summary>
        public virtual IEnumerable<V2.Billing.ContractPricingLineQuantityChange> ListContractPricingLineQuantityChangesAutoPaging(string parentId, string id, QuantityChangeListContractPricingLineQuantityChangesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.ContractPricingLineQuantityChange>($"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/pricing_lines/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions);
        }

        /// <summary>
        /// List quantity changes for a pricing line on a contract.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.ContractPricingLineQuantityChange> ListContractPricingLineQuantityChangesAutoPagingAsync(string parentId, string id, QuantityChangeListContractPricingLineQuantityChangesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.ContractPricingLineQuantityChange>($"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/pricing_lines/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions, cancellationToken);
        }
    }
}
