namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardService : ServiceNested<Card>,
        INestedCreatable<Card, CardCreateOptions>,
        INestedDeletable<Card, CardDeleteOptions>,
        INestedListable<Card, CardListOptions>,
        INestedRetrievable<Card, CardGetOptions>,
        INestedUpdatable<Card, CardUpdateOptions>
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
        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public virtual Card Create(string parentId, CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions);
        }

        public virtual Task<Card> CreateAsync(string parentId, CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions, cancellationToken);
        }

        public virtual Card Delete(string parentId, string id, CardDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions);
        }

        public virtual Task<Card> DeleteAsync(string parentId, string id, CardDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Card Get(string parentId, string id, CardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Get, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions);
        }

        public virtual Task<Card> GetAsync(string parentId, string id, CardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Get, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(string parentId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Card>>(HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new CardListOptions(), requestOptions);
        }

        public virtual Task<StripeList<Card>> ListAsync(string parentId, CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Card>>(HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new CardListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Card> ListAutoPaging(string parentId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Card>($"/v1/customers/{parentId}/sources", options ?? new CardListOptions(), requestOptions);
        }

        public virtual IAsyncEnumerable<Card> ListAutoPagingAsync(string parentId, CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Card>($"/v1/customers/{parentId}/sources", options ?? new CardListOptions(), requestOptions, cancellationToken);
        }

        public virtual Card Update(string parentId, string id, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions);
        }

        public virtual Task<Card> UpdateAsync(string parentId, string id, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions, cancellationToken);
        }
    }
}
