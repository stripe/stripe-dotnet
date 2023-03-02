// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardDesignService : Service<CardDesign>,
        IListable<CardDesign, CardDesignListOptions>,
        IRetrievable<CardDesign, CardDesignGetOptions>,
        IUpdatable<CardDesign, CardDesignUpdateOptions>
    {
        public CardDesignService()
            : base(null)
        {
        }

        public CardDesignService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/card_designs";

        public virtual CardDesign Get(string id, CardDesignGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<CardDesign> GetAsync(string id, CardDesignGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CardDesign> List(CardDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CardDesign>> ListAsync(CardDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CardDesign> ListAutoPaging(CardDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<CardDesign> ListAutoPagingAsync(CardDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual CardDesign Update(string id, CardDesignUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<CardDesign> UpdateAsync(string id, CardDesignUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
