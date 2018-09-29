namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CardService : Service<Card>,
        ICreatable<Card, CardCreateOptions>,
        IListable<Card, CardListOptions>,
        IRetrievable<Card>,
        IUpdatable<Card, CardUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/cards";

        public CardService()
            : base(null)
        {
        }

        public CardService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Card Create(CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual CardDetails Details(string cardId, RequestOptions requestOptions = null)
        {
            return this.GetRequest<CardDetails>($"{classUrl}/{cardId}/details", null, requestOptions);
        }

        public virtual Card Get(string cardId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{cardId}", requestOptions);
        }

        public virtual StripeList<Card> List(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Card Update(string cardId, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{cardId}", requestOptions, options);
        }

        public virtual Task<Card> CreateAsync(CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<CardDetails> DetailsAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetRequestAsync<CardDetails>($"{classUrl}/{cardId}/details", null, requestOptions, cancellationToken);
        }

        public virtual Task<Card> GetAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{cardId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Card>> ListAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Card> UpdateAsync(string cardId, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{cardId}", requestOptions, cancellationToken, options);
        }
    }
}
