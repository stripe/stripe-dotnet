// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardholderService : Service<Cardholder>,
        ICreatable<Cardholder, CardholderCreateOptions>,
        IListable<Cardholder, CardholderListOptions>,
        IRetrievable<Cardholder, CardholderGetOptions>,
        IUpdatable<Cardholder, CardholderUpdateOptions>
    {
        public CardholderService()
            : base(null)
        {
        }

        public CardholderService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/cardholders";

        public virtual Cardholder Create(CardholderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders", options, requestOptions);
        }

        public virtual Task<Cardholder> CreateAsync(CardholderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders", options, requestOptions, cancellationToken);
        }

        public virtual Cardholder Get(string id, CardholderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Cardholder>(HttpMethod.Get, $"/v1/issuing/cardholders/{id}", options, requestOptions);
        }

        public virtual Task<Cardholder> GetAsync(string id, CardholderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cardholder>(HttpMethod.Get, $"/v1/issuing/cardholders/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Cardholder> List(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Cardholder>>(HttpMethod.Get, $"/v1/issuing/cardholders", options, requestOptions);
        }

        public virtual Task<StripeList<Cardholder>> ListAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Cardholder>>(HttpMethod.Get, $"/v1/issuing/cardholders", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Cardholder> ListAutoPaging(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Cardholder>($"/v1/issuing/cardholders", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Cardholder> ListAutoPagingAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Cardholder>($"/v1/issuing/cardholders", options, requestOptions, cancellationToken);
        }

        public virtual Cardholder Update(string id, CardholderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders/{id}", options, requestOptions);
        }

        public virtual Task<Cardholder> UpdateAsync(string id, CardholderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders/{id}", options, requestOptions, cancellationToken);
        }
    }
}
