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
        {
        }

        public CardholderService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/cardholders";

        /// <summary>
        /// <p>Creates a new Issuing <c>Cardholder</c> object that can be issued cards.</p>.
        /// </summary>
        public virtual Cardholder Create(CardholderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new Issuing <c>Cardholder</c> object that can be issued cards.</p>.
        /// </summary>
        public virtual Task<Cardholder> CreateAsync(CardholderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Cardholder</c> object.</p>.
        /// </summary>
        public virtual Cardholder Get(string id, CardholderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Cardholder>(HttpMethod.Get, $"/v1/issuing/cardholders/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Cardholder</c> object.</p>.
        /// </summary>
        public virtual Task<Cardholder> GetAsync(string id, CardholderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cardholder>(HttpMethod.Get, $"/v1/issuing/cardholders/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Cardholder</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<Cardholder> List(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Cardholder>>(HttpMethod.Get, $"/v1/issuing/cardholders", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Cardholder</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<Cardholder>> ListAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Cardholder>>(HttpMethod.Get, $"/v1/issuing/cardholders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Cardholder</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<Cardholder> ListAutoPaging(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Cardholder>($"/v1/issuing/cardholders", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Cardholder</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Cardholder> ListAutoPagingAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Cardholder>($"/v1/issuing/cardholders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified Issuing <c>Cardholder</c> object by setting the values of the
        /// parameters passed. Any parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Cardholder Update(string id, CardholderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified Issuing <c>Cardholder</c> object by setting the values of the
        /// parameters passed. Any parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Cardholder> UpdateAsync(string id, CardholderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cardholder>(HttpMethod.Post, $"/v1/issuing/cardholders/{id}", options, requestOptions, cancellationToken);
        }
    }
}
