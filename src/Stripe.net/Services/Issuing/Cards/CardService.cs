// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/cards";

        public virtual Card Create(CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/issuing/cards", options, requestOptions);
        }

        public virtual Task<Card> CreateAsync(CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/issuing/cards", options, requestOptions, cancellationToken);
        }

        public virtual Card Get(string id, CardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Get, $"/v1/issuing/cards/{id}", options, requestOptions);
        }

        public virtual Task<Card> GetAsync(string id, CardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Get, $"/v1/issuing/cards/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Card>>(HttpMethod.Get, $"/v1/issuing/cards", options, requestOptions);
        }

        public virtual Task<StripeList<Card>> ListAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Card>>(HttpMethod.Get, $"/v1/issuing/cards", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Card> ListAutoPaging(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Card>($"/v1/issuing/cards", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Card> ListAutoPagingAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Card>($"/v1/issuing/cards", options, requestOptions, cancellationToken);
        }

        public virtual Card Update(string id, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/issuing/cards/{id}", options, requestOptions);
        }

        public virtual Task<Card> UpdateAsync(string id, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/issuing/cards/{id}", options, requestOptions, cancellationToken);
        }
    }
}
