// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FxQuoteService : Service,
        ICreatable<FxQuote, FxQuoteCreateOptions>,
        IListable<FxQuote, FxQuoteListOptions>,
        IRetrievable<FxQuote, FxQuoteGetOptions>
    {
        public FxQuoteService()
        {
        }

        internal FxQuoteService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FxQuoteService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates an FX Quote object</p>.
        /// </summary>
        public virtual FxQuote Create(FxQuoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FxQuote>(BaseAddress.Api, HttpMethod.Post, $"/v1/fx_quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an FX Quote object</p>.
        /// </summary>
        public virtual Task<FxQuote> CreateAsync(FxQuoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FxQuote>(BaseAddress.Api, HttpMethod.Post, $"/v1/fx_quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve an FX Quote object</p>.
        /// </summary>
        public virtual FxQuote Get(string id, FxQuoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FxQuote>(BaseAddress.Api, HttpMethod.Get, $"/v1/fx_quotes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve an FX Quote object</p>.
        /// </summary>
        public virtual Task<FxQuote> GetAsync(string id, FxQuoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FxQuote>(BaseAddress.Api, HttpMethod.Get, $"/v1/fx_quotes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of FX quotes that have been issued. The FX quotes are returned in
        /// sorted order, with the most recent FX quotes appearing first.</p>.
        /// </summary>
        public virtual StripeList<FxQuote> List(FxQuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FxQuote>>(BaseAddress.Api, HttpMethod.Get, $"/v1/fx_quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of FX quotes that have been issued. The FX quotes are returned in
        /// sorted order, with the most recent FX quotes appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<FxQuote>> ListAsync(FxQuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FxQuote>>(BaseAddress.Api, HttpMethod.Get, $"/v1/fx_quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of FX quotes that have been issued. The FX quotes are returned in
        /// sorted order, with the most recent FX quotes appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<FxQuote> ListAutoPaging(FxQuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FxQuote>($"/v1/fx_quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of FX quotes that have been issued. The FX quotes are returned in
        /// sorted order, with the most recent FX quotes appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FxQuote> ListAutoPagingAsync(FxQuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FxQuote>($"/v1/fx_quotes", options, requestOptions, cancellationToken);
        }
    }
}
