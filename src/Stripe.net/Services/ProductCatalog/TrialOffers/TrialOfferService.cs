// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TrialOfferService : Service,
        ICreatable<TrialOffer, TrialOfferCreateOptions>,
        IListable<TrialOffer, TrialOfferListOptions>,
        IRetrievable<TrialOffer, TrialOfferGetOptions>
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

        /// <summary>
        /// <p>Retrieves the trial offer with the given ID.</p>.
        /// </summary>
        public virtual TrialOffer Get(string id, TrialOfferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TrialOffer>(BaseAddress.Api, HttpMethod.Get, $"/v1/product_catalog/trial_offers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the trial offer with the given ID.</p>.
        /// </summary>
        public virtual Task<TrialOffer> GetAsync(string id, TrialOfferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TrialOffer>(BaseAddress.Api, HttpMethod.Get, $"/v1/product_catalog/trial_offers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of trial offers.</p>.
        /// </summary>
        public virtual StripeList<TrialOffer> List(TrialOfferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TrialOffer>>(BaseAddress.Api, HttpMethod.Get, $"/v1/product_catalog/trial_offers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of trial offers.</p>.
        /// </summary>
        public virtual Task<StripeList<TrialOffer>> ListAsync(TrialOfferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TrialOffer>>(BaseAddress.Api, HttpMethod.Get, $"/v1/product_catalog/trial_offers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of trial offers.</p>.
        /// </summary>
        public virtual IEnumerable<TrialOffer> ListAutoPaging(TrialOfferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TrialOffer>($"/v1/product_catalog/trial_offers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of trial offers.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TrialOffer> ListAutoPagingAsync(TrialOfferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TrialOffer>($"/v1/product_catalog/trial_offers", options, requestOptions, cancellationToken);
        }
    }
}
