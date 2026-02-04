// File generated from our OpenAPI spec
namespace Stripe.V2.Payments.SettlementAllocationIntents
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SplitService : Service
    {
        internal SplitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SplitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel SettlementAllocationIntentSplit API.
        /// </summary>
        public virtual V2.Payments.SettlementAllocationIntentSplit Cancel(string parentId, string id, SplitCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Payments.SettlementAllocationIntentSplit>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(parentId)}/splits/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel SettlementAllocationIntentSplit API.
        /// </summary>
        public virtual Task<V2.Payments.SettlementAllocationIntentSplit> CancelAsync(string parentId, string id, SplitCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Payments.SettlementAllocationIntentSplit>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(parentId)}/splits/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create SettlementAllocationIntentSplit API.
        /// </summary>
        public virtual V2.Payments.SettlementAllocationIntentSplit Create(string id, SplitCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Payments.SettlementAllocationIntentSplit>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/splits", options, requestOptions);
        }

        /// <summary>
        /// Create SettlementAllocationIntentSplit API.
        /// </summary>
        public virtual Task<V2.Payments.SettlementAllocationIntentSplit> CreateAsync(string id, SplitCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Payments.SettlementAllocationIntentSplit>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/splits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve SettlementAllocationIntentSplit API.
        /// </summary>
        public virtual V2.Payments.SettlementAllocationIntentSplit Get(string parentId, string id, SplitGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Payments.SettlementAllocationIntentSplit>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(parentId)}/splits/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve SettlementAllocationIntentSplit API.
        /// </summary>
        public virtual Task<V2.Payments.SettlementAllocationIntentSplit> GetAsync(string parentId, string id, SplitGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Payments.SettlementAllocationIntentSplit>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(parentId)}/splits/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List SettlementAllocationIntentSplits API.
        /// </summary>
        public virtual V2.StripeList<V2.Payments.SettlementAllocationIntentSplit> List(string id, SplitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Payments.SettlementAllocationIntentSplit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/splits", options, requestOptions);
        }

        /// <summary>
        /// List SettlementAllocationIntentSplits API.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Payments.SettlementAllocationIntentSplit>> ListAsync(string id, SplitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Payments.SettlementAllocationIntentSplit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/splits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List SettlementAllocationIntentSplits API.
        /// </summary>
        public virtual IEnumerable<V2.Payments.SettlementAllocationIntentSplit> ListAutoPaging(string id, SplitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Payments.SettlementAllocationIntentSplit>($"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/splits", options, requestOptions);
        }

        /// <summary>
        /// List SettlementAllocationIntentSplits API.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Payments.SettlementAllocationIntentSplit> ListAutoPagingAsync(string id, SplitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Payments.SettlementAllocationIntentSplit>($"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/splits", options, requestOptions, cancellationToken);
        }
    }
}
