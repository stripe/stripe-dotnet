// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RateCardSubscriptionService : Service
    {
        internal RateCardSubscriptionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RateCardSubscriptionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel an existing, active RateCardSubscription.
        /// </summary>
        public virtual RateCardSubscription Cancel(string id, RateCardSubscriptionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel an existing, active RateCardSubscription.
        /// </summary>
        public virtual Task<RateCardSubscription> CancelAsync(string id, RateCardSubscriptionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a RateCardSubscription to bill a RateCard on a specified billing Cadence.
        /// </summary>
        public virtual RateCardSubscription Create(RateCardSubscriptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// Create a RateCardSubscription to bill a RateCard on a specified billing Cadence.
        /// </summary>
        public virtual Task<RateCardSubscription> CreateAsync(RateCardSubscriptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a RateCardSubscription by ID.
        /// </summary>
        public virtual RateCardSubscription Get(string id, RateCardSubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a RateCardSubscription by ID.
        /// </summary>
        public virtual Task<RateCardSubscription> GetAsync(string id, RateCardSubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all RateCardSubscription objects.
        /// </summary>
        public virtual V2.StripeList<RateCardSubscription> List(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<RateCardSubscription>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// List all RateCardSubscription objects.
        /// </summary>
        public virtual Task<V2.StripeList<RateCardSubscription>> ListAsync(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<RateCardSubscription>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all RateCardSubscription objects.
        /// </summary>
        public virtual IEnumerable<RateCardSubscription> ListAutoPaging(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RateCardSubscription>($"/v2/billing/rate_card_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// List all RateCardSubscription objects.
        /// </summary>
        public virtual IAsyncEnumerable<RateCardSubscription> ListAutoPagingAsync(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RateCardSubscription>($"/v2/billing/rate_card_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update fields on an existing, active RateCardSubscription.
        /// </summary>
        public virtual RateCardSubscription Update(string id, RateCardSubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update fields on an existing, active RateCardSubscription.
        /// </summary>
        public virtual Task<RateCardSubscription> UpdateAsync(string id, RateCardSubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
