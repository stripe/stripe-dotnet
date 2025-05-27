// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class SessionService : Service,
        ICreatable<Session, SessionCreateOptions>,
        IListable<Session, SessionListOptions>,
        IRetrievable<Session, SessionGetOptions>,
        IUpdatable<Session, SessionUpdateOptions>
    {
        private SessionLineItemService lineItems;

        public SessionService()
        {
        }

        internal SessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        public virtual SessionLineItemService LineItems => this.lineItems ??= new SessionLineItemService(
            this.Requestor);

        /// <summary>
        /// <p>Creates a Checkout Session object.</p>.
        /// </summary>
        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/checkout/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a Checkout Session object.</p>.
        /// </summary>
        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A Checkout Session can be expired when it is in one of these statuses: <c>open</c>
        /// </p>.
        ///
        /// <p>After it expires, a customer can’t complete a Checkout Session and customers loading
        /// the Checkout Session see a message saying the Checkout Session is expired.</p>.
        /// </summary>
        public virtual Session Expire(string id, SessionExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/checkout/sessions/{WebUtility.UrlEncode(id)}/expire", options, requestOptions);
        }

        /// <summary>
        /// <p>A Checkout Session can be expired when it is in one of these statuses: <c>open</c>
        /// </p>.
        ///
        /// <p>After it expires, a customer can’t complete a Checkout Session and customers loading
        /// the Checkout Session see a message saying the Checkout Session is expired.</p>.
        /// </summary>
        public virtual Task<Session> ExpireAsync(string id, SessionExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/checkout/sessions/{WebUtility.UrlEncode(id)}/expire", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a Checkout Session object.</p>.
        /// </summary>
        public virtual Session Get(string id, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(BaseAddress.Api, HttpMethod.Get, $"/v1/checkout/sessions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Checkout Session object.</p>.
        /// </summary>
        public virtual Task<Session> GetAsync(string id, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(BaseAddress.Api, HttpMethod.Get, $"/v1/checkout/sessions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Checkout Sessions.</p>.
        /// </summary>
        public virtual StripeList<Session> List(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Session>>(BaseAddress.Api, HttpMethod.Get, $"/v1/checkout/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Checkout Sessions.</p>.
        /// </summary>
        public virtual Task<StripeList<Session>> ListAsync(SessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Session>>(BaseAddress.Api, HttpMethod.Get, $"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Checkout Sessions.</p>.
        /// </summary>
        public virtual IEnumerable<Session> ListAutoPaging(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Session>($"/v1/checkout/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Checkout Sessions.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Session> ListAutoPagingAsync(SessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Session>($"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a Checkout Session object.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/payments/checkout/dynamic-updates">Dynamically update
        /// Checkout</a></p>.
        /// </summary>
        public virtual Session Update(string id, SessionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/checkout/sessions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a Checkout Session object.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/payments/checkout/dynamic-updates">Dynamically update
        /// Checkout</a></p>.
        /// </summary>
        public virtual Task<Session> UpdateAsync(string id, SessionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/checkout/sessions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
