// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardBundleService : Service<CardBundle>,
        IListable<CardBundle, CardBundleListOptions>,
        IRetrievable<CardBundle, CardBundleGetOptions>
    {
        public CardBundleService()
            : base(null)
        {
        }

        public CardBundleService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/card_bundles";

        public virtual CardBundle Get(string id, CardBundleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<CardBundle> GetAsync(string id, CardBundleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CardBundle> List(CardBundleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CardBundle>> ListAsync(CardBundleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CardBundle> ListAutoPaging(CardBundleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<CardBundle> ListAutoPagingAsync(CardBundleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
