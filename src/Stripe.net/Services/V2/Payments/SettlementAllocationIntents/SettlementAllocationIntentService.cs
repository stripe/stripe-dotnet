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
        /// Cancels an existing SettlementAllocationIntent. Only SettlementAllocationIntent with
        /// status <c>pending</c>, <c>submitted</c> and <c>errored</c> can be <c>canceled</c>.
        /// </summary>
        public virtual SettlementAllocationIntent Cancel(string id, SettlementAllocationIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an existing SettlementAllocationIntent. Only SettlementAllocationIntent with
        /// status <c>pending</c>, <c>submitted</c> and <c>errored</c> can be <c>canceled</c>.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> CancelAsync(string id, SettlementAllocationIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a new SettlementAllocationIntent.
        /// </summary>
        public virtual SettlementAllocationIntent Create(SettlementAllocationIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents", options, requestOptions);
        }

        /// <summary>
        /// Create a new SettlementAllocationIntent.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> CreateAsync(SettlementAllocationIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve an existing SettlementAllocationIntent.
        /// </summary>
        public virtual SettlementAllocationIntent Get(string id, SettlementAllocationIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve an existing SettlementAllocationIntent.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> GetAsync(string id, SettlementAllocationIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Submits a SettlementAllocationIntent. Only SettlementAllocationIntent with status
        /// <c>pending</c> can be <c>submitted</c>. The net sum of SettlementAllocationIntentSplit
        /// amount must be equal to SettlementAllocationIntent amount to be eligible to be
        /// submitted.
        /// </summary>
        public virtual SettlementAllocationIntent Submit(string id, SettlementAllocationIntentSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/submit", options, requestOptions);
        }

        /// <summary>
        /// Submits a SettlementAllocationIntent. Only SettlementAllocationIntent with status
        /// <c>pending</c> can be <c>submitted</c>. The net sum of SettlementAllocationIntentSplit
        /// amount must be equal to SettlementAllocationIntent amount to be eligible to be
        /// submitted.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> SubmitAsync(string id, SettlementAllocationIntentSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}/submit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates SettlementAllocationIntent. Only SettlementAllocationIntent with status
        /// <c>pending</c>, <c>submitted</c> and <c>errored</c> can be updated. Only amount and
        /// reference fields can be updated for a SettlementAllocationIntent and at least one must
        /// be present. Updating an <c>amount</c> moves the SettlementAllocationIntent
        /// <c>pending</c> status and updating the <c>reference</c> for <c>errored</c>
        /// SettlementAllocationIntent moves it to <c>submitted</c>.
        /// </summary>
        public virtual SettlementAllocationIntent Update(string id, SettlementAllocationIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates SettlementAllocationIntent. Only SettlementAllocationIntent with status
        /// <c>pending</c>, <c>submitted</c> and <c>errored</c> can be updated. Only amount and
        /// reference fields can be updated for a SettlementAllocationIntent and at least one must
        /// be present. Updating an <c>amount</c> moves the SettlementAllocationIntent
        /// <c>pending</c> status and updating the <c>reference</c> for <c>errored</c>
        /// SettlementAllocationIntent moves it to <c>submitted</c>.
        /// </summary>
        public virtual Task<SettlementAllocationIntent> UpdateAsync(string id, SettlementAllocationIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SettlementAllocationIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/settlement_allocation_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
