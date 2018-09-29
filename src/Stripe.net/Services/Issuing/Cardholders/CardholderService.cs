namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CardholderService : Service<Cardholder>,
        ICreatable<Cardholder, CardholderCreateOptions>,
        IListable<Cardholder, CardholderListOptions>,
        IRetrievable<Cardholder>,
        IUpdatable<Cardholder, CardholderUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/cardholders";

        public CardholderService()
            : base(null)
        {
        }

        public CardholderService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Cardholder Create(CardholderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual Task<Cardholder> CreateAsync(CardholderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Cardholder Get(string cardholderId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{cardholderId}", requestOptions);
        }

        public virtual Task<Cardholder> GetAsync(string cardholderId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{cardholderId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<Cardholder> List(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Task<StripeList<Cardholder>> ListAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Cardholder Update(string cardholderId, CardholderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{cardholderId}", requestOptions, options);
        }

        public virtual Task<Cardholder> UpdateAsync(string cardholderId, CardholderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{cardholderId}", requestOptions, cancellationToken, options);
        }
    }
}
