namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardService : Service<Card>,
        ICreatable<Card, CardCreateOptions>,
        IListable<Card, CardListOptions>,
        IRetrievable<Card, CardGetOptions>,
        IUpdatable<Card, CardUpdateOptions>
    {
        public CardService()
            : base(null)
        {
        }

        public CardService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/cards";

        public virtual Card Create(CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Card> CreateAsync(CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual CardDetails Details(string cardId, RequestOptions requestOptions = null)
        {
            return this.Request<CardDetails>(HttpMethod.Get, $"{this.InstanceUrl(cardId)}/details", null, requestOptions);
        }

        public virtual Task<CardDetails> DetailsAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CardDetails>(HttpMethod.Get, $"{this.InstanceUrl(cardId)}/details", null, requestOptions, cancellationToken);
        }

        public virtual Card Get(string cardId, CardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(cardId, options, requestOptions);
        }

        public virtual Task<Card> GetAsync(string cardId, CardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(cardId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Card>> ListAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Card> ListAutoPaging(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Card> ListAutoPagingAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Card Update(string cardId, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(cardId, options, requestOptions);
        }

        public virtual Task<Card> UpdateAsync(string cardId, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(cardId, options, requestOptions, cancellationToken);
        }
    }
}
