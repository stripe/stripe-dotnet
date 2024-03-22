// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SessionService : Service<Session>,
        ICreatable<Session, SessionCreateOptions>,
        IListable<Session, SessionListOptions>,
        IRetrievable<Session, SessionGetOptions>
    {
        public SessionService()
        {
        }

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/checkout/sessions";

        /// <summary>
        /// <p>Creates a Session object.</p>.
        /// </summary>
        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/checkout/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a Session object.</p>.
        /// </summary>
        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A Session can be expired when it is in one of these statuses: <c>open</c> </p>.
        ///
        /// <p>After it expires, a customer can’t complete a Session and customers loading the
        /// Session see a message saying the Session is expired.</p>.
        /// </summary>
        public virtual Session Expire(string id, SessionExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/checkout/sessions/{id}/expire", options, requestOptions);
        }

        /// <summary>
        /// <p>A Session can be expired when it is in one of these statuses: <c>open</c> </p>.
        ///
        /// <p>After it expires, a customer can’t complete a Session and customers loading the
        /// Session see a message saying the Session is expired.</p>.
        /// </summary>
        public virtual Task<Session> ExpireAsync(string id, SessionExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/checkout/sessions/{id}/expire", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a Session object.</p>.
        /// </summary>
        public virtual Session Get(string id, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Get, $"/v1/checkout/sessions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Session object.</p>.
        /// </summary>
        public virtual Task<Session> GetAsync(string id, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Get, $"/v1/checkout/sessions/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Checkout Sessions.</p>.
        /// </summary>
        public virtual StripeList<Session> List(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Session>>(HttpMethod.Get, $"/v1/checkout/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Checkout Sessions.</p>.
        /// </summary>
        public virtual Task<StripeList<Session>> ListAsync(SessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Session>>(HttpMethod.Get, $"/v1/checkout/sessions", options, requestOptions, cancellationToken);
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
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> ListLineItems(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/checkout/sessions/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/checkout/sessions/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/checkout/sessions/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/checkout/sessions/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
