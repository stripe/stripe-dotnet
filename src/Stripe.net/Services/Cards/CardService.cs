namespace Stripe
{
    using System;
    using System.Collections.Generic;
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

        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public virtual Card Create(string customerId, CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<Card> CreateAsync(string customerId, CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual Card Delete(string customerId, string cardId, CardDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(customerId, cardId, options, requestOptions);
        }

        public virtual Task<Card> DeleteAsync(string customerId, string cardId, CardDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(customerId, cardId, options, requestOptions, cancellationToken);
        }

        public virtual Card Get(string customerId, string cardId, CardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, cardId, options, requestOptions);
        }

        public virtual Task<Card> GetAsync(string customerId, string cardId, CardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(customerId, cardId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(string customerId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options ?? new CardListOptions(), requestOptions);
        }

        public virtual Task<StripeList<Card>> ListAsync(string customerId, CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(customerId, options ?? new CardListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Card> ListAutoPaging(string customerId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options ?? new CardListOptions(), requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Card> ListAutoPagingAsync(string customerId, CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(customerId, options ?? new CardListOptions(), requestOptions, cancellationToken);
        }
#endif

        public virtual Card Update(string customerId, string cardId, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(customerId, cardId, options, requestOptions);
        }

        public virtual Task<Card> UpdateAsync(string customerId, string cardId, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(customerId, cardId, options, requestOptions, cancellationToken);
        }
    }
}
