namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CardService : Service<Card>,
        INestedCreatable<Card, CardCreateOptions>,
        INestedDeletable<Card>,
        INestedListable<Card, CardListOptions>,
        INestedRetrievable<Card>,
        INestedUpdatable<Card, CardUpdateOptions>
    {
        public CardService()
            : base(null)
        {
        }

        public CardService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public bool ExpandRecipient { get; set; }

        public virtual Card Create(string customerId, CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, options);
        }

        public virtual Task<Card> CreateAsync(string customerId, CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Card Delete(string customerId, string bankAccountId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions);
        }

        public virtual Task<Card> DeleteAsync(string customerId, string bankAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, cancellationToken);
        }

        public virtual Card Get(string customerId, string bankAccountId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions);
        }

        public virtual Task<Card> GetAsync(string customerId, string bankAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(string customerId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, options);
        }

        public virtual Task<StripeList<Card>> ListAsync(string customerId, CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Card Update(string customerId, string bankAccountId, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, options);
        }

        public virtual Task<Card> UpdateAsync(string customerId, string bankAccountId, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, cancellationToken, options);
        }
    }
}
