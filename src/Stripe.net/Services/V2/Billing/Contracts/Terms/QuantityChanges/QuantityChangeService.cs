// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts.Terms
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
        /// List quantity changes for a licensed recurring-price term.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.ContractTermQuantityChange> ListContractTermQuantityChanges(string parentId, string id, QuantityChangeListContractTermQuantityChangesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.ContractTermQuantityChange>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/terms/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions);
        }

        /// <summary>
        /// List quantity changes for a licensed recurring-price term.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.ContractTermQuantityChange>> ListContractTermQuantityChangesAsync(string parentId, string id, QuantityChangeListContractTermQuantityChangesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.ContractTermQuantityChange>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/terms/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List quantity changes for a licensed recurring-price term.
        /// </summary>
        public virtual IEnumerable<V2.Billing.ContractTermQuantityChange> ListContractTermQuantityChangesAutoPaging(string parentId, string id, QuantityChangeListContractTermQuantityChangesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.ContractTermQuantityChange>($"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/terms/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions);
        }

        /// <summary>
        /// List quantity changes for a licensed recurring-price term.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.ContractTermQuantityChange> ListContractTermQuantityChangesAutoPagingAsync(string parentId, string id, QuantityChangeListContractTermQuantityChangesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.ContractTermQuantityChange>($"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/terms/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions, cancellationToken);
        }
    }
}
