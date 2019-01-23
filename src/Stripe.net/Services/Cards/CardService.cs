namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardService : ServiceNested<Card>,
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

        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public bool ExpandCustomer { get; set; }

        public bool ExpandRecipient { get; set; }

        public virtual Card Create(string customerId, CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<Card> CreateAsync(string customerId, CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual Card Delete(string customerId, string cardId, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(customerId, cardId, null, requestOptions);
        }

        public virtual Task<Card> DeleteAsync(string customerId, string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(customerId, cardId, null, requestOptions, cancellationToken);
        }

        public virtual Card Get(string customerId, string cardId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, cardId, null, requestOptions);
        }

        public virtual Task<Card> GetAsync(string customerId, string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(customerId, cardId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Card> List(string customerId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options, requestOptions);
        }

        public virtual Task<StripeList<Card>> ListAsync(string customerId, CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Card> ListAutoPaging(string customerId, CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options, requestOptions);
        }

        public virtual Card Update(string customerId, string cardId, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(customerId, cardId, options, requestOptions);
        }

        public virtual Task<Card> UpdateAsync(string customerId, string cardId, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(customerId, cardId, options, requestOptions, cancellationToken);
        }
    }
}
