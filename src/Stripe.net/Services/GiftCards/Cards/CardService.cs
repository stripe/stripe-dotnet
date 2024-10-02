// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System;
    using System.Collections.Generic;
    using System.Net;
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
        {
        }

        public CardService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/gift_cards/cards";

        /// <summary>
        /// <p>Creates a new gift card object.</p>.
        /// </summary>
        public virtual Card Create(CardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/gift_cards/cards", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new gift card object.</p>.
        /// </summary>
        public virtual Task<Card> CreateAsync(CardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/gift_cards/cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a gift card by id</p>.
        /// </summary>
        public virtual Card Get(string id, CardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Get, $"/v1/gift_cards/cards/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a gift card by id</p>.
        /// </summary>
        public virtual Task<Card> GetAsync(string id, CardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Get, $"/v1/gift_cards/cards/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List gift cards for an account</p>.
        /// </summary>
        public virtual StripeList<Card> List(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Card>>(HttpMethod.Get, $"/v1/gift_cards/cards", options, requestOptions);
        }

        /// <summary>
        /// <p>List gift cards for an account</p>.
        /// </summary>
        public virtual Task<StripeList<Card>> ListAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Card>>(HttpMethod.Get, $"/v1/gift_cards/cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List gift cards for an account</p>.
        /// </summary>
        public virtual IEnumerable<Card> ListAutoPaging(CardListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Card>($"/v1/gift_cards/cards", options, requestOptions);
        }

        /// <summary>
        /// <p>List gift cards for an account</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Card> ListAutoPagingAsync(CardListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Card>($"/v1/gift_cards/cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update a gift card</p>.
        /// </summary>
        public virtual Card Update(string id, CardUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/gift_cards/cards/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Update a gift card</p>.
        /// </summary>
        public virtual Task<Card> UpdateAsync(string id, CardUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/gift_cards/cards/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Validates a gift card code, returning the matching gift card object if it exists.</p>.
        /// </summary>
        public virtual Card Validate(CardValidateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Card>(HttpMethod.Post, $"/v1/gift_cards/cards/validate", options, requestOptions);
        }

        /// <summary>
        /// <p>Validates a gift card code, returning the matching gift card object if it exists.</p>.
        /// </summary>
        public virtual Task<Card> ValidateAsync(CardValidateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Card>(HttpMethod.Post, $"/v1/gift_cards/cards/validate", options, requestOptions, cancellationToken);
        }
    }
}
