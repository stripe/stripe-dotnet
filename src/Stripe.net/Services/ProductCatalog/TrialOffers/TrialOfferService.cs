// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TrialOfferService : Service,
        ICreatable<TrialOffer, TrialOfferCreateOptions>
    {
        public TrialOfferService()
        {
        }

        internal TrialOfferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TrialOfferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a trial offer.</p>.
        /// </summary>
        public virtual TrialOffer Create(TrialOfferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TrialOffer>(BaseAddress.Api, HttpMethod.Post, $"/v1/product_catalog/trial_offers", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a trial offer.</p>.
        /// </summary>
        public virtual Task<TrialOffer> CreateAsync(TrialOfferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TrialOffer>(BaseAddress.Api, HttpMethod.Post, $"/v1/product_catalog/trial_offers", options, requestOptions, cancellationToken);
        }
    }
}
