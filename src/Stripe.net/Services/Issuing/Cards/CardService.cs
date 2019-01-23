namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardService : Service<Card>,
        ICreatable<Card, CardCreateOptions>,
        IListable<Card, CardListOptions>,
        IRetrievable<Card>,
        IUpdatable<Card, CardUpdateOptions>
    {
        public CardService()
            : base(null)
        {
        }

        public CardService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/issuing/cards";

        public virtual Card Create(CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Card> CreateAsync(CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual CardDetails Details(string cardId, RequestOptions requestOptions = null)
        {
            return this.GetRequest<CardDetails>($"{this.InstanceUrl(cardId)}/details", null, requestOptions, false);
        }

        public virtual Task<CardDetails> DetailsAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetRequestAsync<CardDetails>($"{this.InstanceUrl(cardId)}/details", null, requestOptions, false, cancellationToken);
        }

        public virtual Card Get(string cardId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(cardId, null, requestOptions);
        }

        public virtual Task<Card> GetAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(cardId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Card>> ListAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Card> ListAutoPaging(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Card Update(string cardId, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(cardId, options, requestOptions);
        }

        public virtual Task<Card> UpdateAsync(string cardId, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(cardId, options, requestOptions, cancellationToken);
        }
    }
}
