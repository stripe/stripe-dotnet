// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SettlementAllocationIntentService : Service
    {
        private V2.Payments.SettlementAllocationIntents.SplitService splits;

        internal SettlementAllocationIntentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SettlementAllocationIntentService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Payments.SettlementAllocationIntents.SplitService Splits => this.splits ??= new V2.Payments.SettlementAllocationIntents.SplitService(
            this.Requestor);

        /// <summary>
        /// Cancel SettlementAllocationIntent API.
        /// </summary>
        public virtual SettlementAllocationIntent Cancel(string id, SettlementAllocationIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel SettlementAllocationIntent API.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> CancelAsync(string id, SettlementAllocationIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create SettlementAllocationIntent API.
        /// </summary>
        public virtual SettlementAllocationIntent Create(SettlementAllocationIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents", options, requestOptions);
        }

        /// <summary>
        /// Create SettlementAllocationIntent API.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> CreateAsync(SettlementAllocationIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve SettlementAllocationIntent API.
        /// </summary>
        public virtual SettlementAllocationIntent Get(string id, SettlementAllocationIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve SettlementAllocationIntent API.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> GetAsync(string id, SettlementAllocationIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Submit SettlementAllocationIntent API.
        /// </summary>
        public virtual SettlementAllocationIntent Submit(string id, SettlementAllocationIntentSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/submit", options, requestOptions);
        }

        /// <summary>
        /// Submit SettlementAllocationIntent API.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> SubmitAsync(string id, SettlementAllocationIntentSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/submit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update SettlementAllocationIntent API.
        /// </summary>
        public virtual SettlementAllocationIntent Update(string id, SettlementAllocationIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update SettlementAllocationIntent API.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> UpdateAsync(string id, SettlementAllocationIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
