// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RateCardService : Service
    {
        private V2.Billing.RateCards.RateService rates;
        private V2.Billing.RateCards.VersionService versions;

        internal RateCardService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RateCardService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.RateCards.RateService Rates => this.rates ??= new V2.Billing.RateCards.RateService(
            this.Requestor);

        public virtual V2.Billing.RateCards.VersionService Versions => this.versions ??= new V2.Billing.RateCards.VersionService(
            this.Requestor);

        /// <summary>
        /// Create a Rate Card object.
        /// </summary>
        public virtual RateCard Create(RateCardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RateCard>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards", options, requestOptions);
        }

        /// <summary>
        /// Create a Rate Card object.
        /// </summary>
        public virtual Task<RateCard> CreateAsync(RateCardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCard>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve the latest version of a Rate Card object.
        /// </summary>
        public virtual RateCard Get(string id, RateCardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RateCard>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve the latest version of a Rate Card object.
        /// </summary>
        public virtual Task<RateCard> GetAsync(string id, RateCardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCard>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rate Card objects.
        /// </summary>
        public virtual V2.StripeList<RateCard> List(RateCardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<RateCard>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards", options, requestOptions);
        }

        /// <summary>
        /// List all Rate Card objects.
        /// </summary>
        public virtual Task<V2.StripeList<RateCard>> ListAsync(RateCardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<RateCard>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rate Card objects.
        /// </summary>
        public virtual IEnumerable<RateCard> ListAutoPaging(RateCardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RateCard>($"/v2/billing/rate_cards", options, requestOptions);
        }

        /// <summary>
        /// List all Rate Card objects.
        /// </summary>
        public virtual IAsyncEnumerable<RateCard> ListAutoPagingAsync(RateCardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RateCard>($"/v2/billing/rate_cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Rate Card object.
        /// </summary>
        public virtual RateCard Update(string id, RateCardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RateCard>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Rate Card object.
        /// </summary>
        public virtual Task<RateCard> UpdateAsync(string id, RateCardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RateCard>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
