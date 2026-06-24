// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PayoutIntentService : Service
    {
        internal PayoutIntentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PayoutIntentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels a PayoutIntent. Only pending PayoutIntents or processing PayoutIntents with
        /// cancelable OutboundPayment/Transfer can be canceled.
        /// </summary>
        public virtual PayoutIntent Cancel(string id, PayoutIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels a PayoutIntent. Only pending PayoutIntents or processing PayoutIntents with
        /// cancelable OutboundPayment/Transfer can be canceled.
        /// </summary>
        public virtual Task<PayoutIntent> CancelAsync(string id, PayoutIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a PayoutIntent.
        /// </summary>
        public virtual PayoutIntent Create(PayoutIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_intents", options, requestOptions);
        }

        /// <summary>
        /// Creates a PayoutIntent.
        /// </summary>
        public virtual Task<PayoutIntent> CreateAsync(PayoutIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing PayoutIntent by passing the unique PayoutIntent ID.
        /// </summary>
        public virtual PayoutIntent Get(string id, PayoutIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing PayoutIntent by passing the unique PayoutIntent ID.
        /// </summary>
        public virtual Task<PayoutIntent> GetAsync(string id, PayoutIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of PayoutIntents.
        /// </summary>
        public virtual V2.StripeList<PayoutIntent> List(PayoutIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<PayoutIntent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_intents", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of PayoutIntents.
        /// </summary>
        public virtual Task<V2.StripeList<PayoutIntent>> ListAsync(PayoutIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<PayoutIntent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of PayoutIntents.
        /// </summary>
        public virtual IEnumerable<PayoutIntent> ListAutoPaging(PayoutIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PayoutIntent>($"/v2/money_management/payout_intents", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of PayoutIntents.
        /// </summary>
        public virtual IAsyncEnumerable<PayoutIntent> ListAutoPagingAsync(PayoutIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PayoutIntent>($"/v2/money_management/payout_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates a PayoutIntent. Only pending or requires_action PayoutIntents that are editable
        /// can be updated.
        /// </summary>
        public virtual PayoutIntent Update(string id, PayoutIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates a PayoutIntent. Only pending or requires_action PayoutIntents that are editable
        /// can be updated.
        /// </summary>
        public virtual Task<PayoutIntent> UpdateAsync(string id, PayoutIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
