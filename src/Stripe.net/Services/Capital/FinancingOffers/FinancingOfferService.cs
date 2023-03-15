// File generated from our OpenAPI spec
namespace Stripe.Capital
{
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

        public override string BasePath => "/v1/capital/financing_offers";

        public virtual FinancingOffer Get(string id, FinancingOfferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<FinancingOffer> GetAsync(string id, FinancingOfferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<FinancingOffer> List(FinancingOfferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<FinancingOffer>> ListAsync(FinancingOfferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FinancingOffer> ListAutoPaging(FinancingOfferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<FinancingOffer> ListAutoPagingAsync(FinancingOfferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual FinancingOffer MarkDelivered(string id, FinancingOfferMarkDeliveredOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_delivered", options, requestOptions);
        }

        public virtual Task<FinancingOffer> MarkDeliveredAsync(string id, FinancingOfferMarkDeliveredOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_delivered", options, requestOptions, cancellationToken);
        }
    }
}
