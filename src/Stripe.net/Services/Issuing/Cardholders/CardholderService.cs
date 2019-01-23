namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardholderService : Service<Cardholder>,
        ICreatable<Cardholder, CardholderCreateOptions>,
        IListable<Cardholder, CardholderListOptions>,
        IRetrievable<Cardholder>,
        IUpdatable<Cardholder, CardholderUpdateOptions>
    {
        public CardholderService()
            : base(null)
        {
        }

        public CardholderService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/issuing/cardholders";

        public virtual Cardholder Create(CardholderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Cardholder> CreateAsync(CardholderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Cardholder Get(string cardholderId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(cardholderId, null, requestOptions);
        }

        public virtual Task<Cardholder> GetAsync(string cardholderId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(cardholderId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Cardholder> List(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Cardholder>> ListAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Cardholder> ListAutoPaging(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Cardholder Update(string cardholderId, CardholderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(cardholderId, options, requestOptions);
        }

        public virtual Task<Cardholder> UpdateAsync(string cardholderId, CardholderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(cardholderId, options, requestOptions, cancellationToken);
        }
    }
}
