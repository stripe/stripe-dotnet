// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Capital
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Capital;

    public class FinancingOfferService : Service
    {
        public FinancingOfferService()
        {
        }

        internal FinancingOfferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FinancingOfferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a test financing offer for a connected account.</p>.
        /// </summary>
        public virtual Stripe.Capital.FinancingOffer Create(FinancingOfferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Capital.FinancingOffer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/capital/financing_offers", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a test financing offer for a connected account.</p>.
        /// </summary>
        public virtual Task<Stripe.Capital.FinancingOffer> CreateAsync(FinancingOfferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Capital.FinancingOffer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/capital/financing_offers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Refills a test financing offer for a connected account.</p>.
        /// </summary>
        public virtual Stripe.Capital.FinancingOffer Refill(string id, FinancingOfferRefillOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Capital.FinancingOffer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/capital/financing_offers/{WebUtility.UrlEncode(id)}/refill", options, requestOptions);
        }

        /// <summary>
        /// <p>Refills a test financing offer for a connected account.</p>.
        /// </summary>
        public virtual Task<Stripe.Capital.FinancingOffer> RefillAsync(string id, FinancingOfferRefillOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Capital.FinancingOffer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/capital/financing_offers/{WebUtility.UrlEncode(id)}/refill", options, requestOptions, cancellationToken);
        }
    }
}
