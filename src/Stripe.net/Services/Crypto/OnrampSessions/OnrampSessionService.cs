// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OnrampSessionService : Service,
        ICreatable<OnrampSession, OnrampSessionCreateOptions>,
        IListable<OnrampSession, OnrampSessionListOptions>,
        IRetrievable<OnrampSession, OnrampSessionGetOptions>
    {
        public OnrampSessionService()
        {
        }

        internal OnrampSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public OnrampSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Completes a headless CryptoOnrampSession.</p>.
        ///
        /// <p>This method will attempt to confirm the payment and execute the quote to deliver the
        /// crypto to the customer.</p>.
        /// </summary>
        public virtual OnrampSession Checkout(string id, OnrampSessionCheckoutOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OnrampSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/onramp_sessions/{WebUtility.UrlEncode(id)}/checkout", options, requestOptions);
        }

        /// <summary>
        /// <p>Completes a headless CryptoOnrampSession.</p>.
        ///
        /// <p>This method will attempt to confirm the payment and execute the quote to deliver the
        /// crypto to the customer.</p>.
        /// </summary>
        public virtual Task<OnrampSession> CheckoutAsync(string id, OnrampSessionCheckoutOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnrampSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/onramp_sessions/{WebUtility.UrlEncode(id)}/checkout", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a CryptoOnrampSession object.</p>.
        ///
        /// <p>After the CryptoOnrampSession is created, display the onramp session modal using the
        /// <c>client_secret</c>.</p>.
        ///
        /// <p>Related guide: <a href="https://stripe.com/docs/crypto/integrate-the-onramp">Set up
        /// an onramp integration</a></p>.
        /// </summary>
        public virtual OnrampSession Create(OnrampSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OnrampSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/onramp_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a CryptoOnrampSession object.</p>.
        ///
        /// <p>After the CryptoOnrampSession is created, display the onramp session modal using the
        /// <c>client_secret</c>.</p>.
        ///
        /// <p>Related guide: <a href="https://stripe.com/docs/crypto/integrate-the-onramp">Set up
        /// an onramp integration</a></p>.
        /// </summary>
        public virtual Task<OnrampSession> CreateAsync(OnrampSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnrampSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/onramp_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a CryptoOnrampSession that was previously created.</p>.
        /// </summary>
        public virtual OnrampSession Get(string id, OnrampSessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OnrampSession>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a CryptoOnrampSession that was previously created.</p>.
        /// </summary>
        public virtual Task<OnrampSession> GetAsync(string id, OnrampSessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnrampSession>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of onramp sessions that match the filter criteria. The onramp sessions
        /// are returned in sorted order, with the most recent onramp sessions appearing first.</p>.
        /// </summary>
        public virtual StripeList<OnrampSession> List(OnrampSessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<OnrampSession>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of onramp sessions that match the filter criteria. The onramp sessions
        /// are returned in sorted order, with the most recent onramp sessions appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<OnrampSession>> ListAsync(OnrampSessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<OnrampSession>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of onramp sessions that match the filter criteria. The onramp sessions
        /// are returned in sorted order, with the most recent onramp sessions appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<OnrampSession> ListAutoPaging(OnrampSessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OnrampSession>($"/v1/crypto/onramp_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of onramp sessions that match the filter criteria. The onramp sessions
        /// are returned in sorted order, with the most recent onramp sessions appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<OnrampSession> ListAutoPagingAsync(OnrampSessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OnrampSession>($"/v1/crypto/onramp_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Refreshes an executable quote for a CryptoOnrampSession.</p>.
        /// </summary>
        public virtual OnrampSession Quote(string id, OnrampSessionQuoteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OnrampSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/onramp_sessions/{WebUtility.UrlEncode(id)}/quote", options, requestOptions);
        }

        /// <summary>
        /// <p>Refreshes an executable quote for a CryptoOnrampSession.</p>.
        /// </summary>
        public virtual Task<OnrampSession> QuoteAsync(string id, OnrampSessionQuoteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnrampSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/onramp_sessions/{WebUtility.UrlEncode(id)}/quote", options, requestOptions, cancellationToken);
        }
    }
}
