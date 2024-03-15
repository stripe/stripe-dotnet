// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancingOfferService : Service<FinancingOffer>,
        IListable<FinancingOffer, FinancingOfferListOptions>,
        IRetrievable<FinancingOffer, FinancingOfferGetOptions>
    {
        public FinancingOfferService()
            : base(null)
        {
        }

        public FinancingOfferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/capital/financing_offers";

        /// <summary>
        /// <p>Get the details of the financing offer</p>.
        /// </summary>
        public virtual FinancingOffer Get(string id, FinancingOfferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancingOffer>(HttpMethod.Get, $"/v1/capital/financing_offers/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Get the details of the financing offer</p>.
        /// </summary>
        public virtual Task<FinancingOffer> GetAsync(string id, FinancingOfferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingOffer>(HttpMethod.Get, $"/v1/capital/financing_offers/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the financing offers available for Connected accounts that belong to your
        /// platform.</p>.
        /// </summary>
        public virtual StripeList<FinancingOffer> List(FinancingOfferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancingOffer>>(HttpMethod.Get, $"/v1/capital/financing_offers", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the financing offers available for Connected accounts that belong to your
        /// platform.</p>.
        /// </summary>
        public virtual Task<StripeList<FinancingOffer>> ListAsync(FinancingOfferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancingOffer>>(HttpMethod.Get, $"/v1/capital/financing_offers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the financing offers available for Connected accounts that belong to your
        /// platform.</p>.
        /// </summary>
        public virtual IEnumerable<FinancingOffer> ListAutoPaging(FinancingOfferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancingOffer>($"/v1/capital/financing_offers", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the financing offers available for Connected accounts that belong to your
        /// platform.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FinancingOffer> ListAutoPagingAsync(FinancingOfferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancingOffer>($"/v1/capital/financing_offers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Acknowledges that platform has received and delivered the financing_offer to the
        /// intended merchant recipient.</p>.
        /// </summary>
        public virtual FinancingOffer MarkDelivered(string id, FinancingOfferMarkDeliveredOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancingOffer>(HttpMethod.Post, $"/v1/capital/financing_offers/{id}/mark_delivered", options, requestOptions);
        }

        /// <summary>
        /// <p>Acknowledges that platform has received and delivered the financing_offer to the
        /// intended merchant recipient.</p>.
        /// </summary>
        public virtual Task<FinancingOffer> MarkDeliveredAsync(string id, FinancingOfferMarkDeliveredOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingOffer>(HttpMethod.Post, $"/v1/capital/financing_offers/{id}/mark_delivered", options, requestOptions, cancellationToken);
        }
    }
}
