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
        /// Cancel an existing, active Rate Card Subscription.
        /// </summary>
        public virtual RateCardSubscription Cancel(string id, RateCardSubscriptionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel an existing, active Rate Card Subscription.
        /// </summary>
        public virtual Task<RateCardSubscription> CancelAsync(string id, RateCardSubscriptionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a Rate Card Subscription to bill a Rate Card on a specified Billing Cadence.
        /// </summary>
        public virtual RateCardSubscription Create(RateCardSubscriptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// Create a Rate Card Subscription to bill a Rate Card on a specified Billing Cadence.
        /// </summary>
        public virtual Task<RateCardSubscription> CreateAsync(RateCardSubscriptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Rate Card Subscription by ID.
        /// </summary>
        public virtual RateCardSubscription Get(string id, RateCardSubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Rate Card Subscription by ID.
        /// </summary>
        public virtual Task<RateCardSubscription> GetAsync(string id, RateCardSubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rate Card Subscription objects.
        /// </summary>
        public virtual V2.StripeList<RateCardSubscription> List(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<RateCardSubscription>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// List all Rate Card Subscription objects.
        /// </summary>
        public virtual Task<V2.StripeList<RateCardSubscription>> ListAsync(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<RateCardSubscription>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_card_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rate Card Subscription objects.
        /// </summary>
        public virtual IEnumerable<RateCardSubscription> ListAutoPaging(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RateCardSubscription>($"/v2/billing/rate_card_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// List all Rate Card Subscription objects.
        /// </summary>
        public virtual IAsyncEnumerable<RateCardSubscription> ListAutoPagingAsync(RateCardSubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RateCardSubscription>($"/v2/billing/rate_card_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update fields on an existing, active Rate Card Subscription.
        /// </summary>
        public virtual RateCardSubscription Update(string id, RateCardSubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update fields on an existing, active Rate Card Subscription.
        /// </summary>
        public virtual Task<RateCardSubscription> UpdateAsync(string id, RateCardSubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCardSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_card_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
