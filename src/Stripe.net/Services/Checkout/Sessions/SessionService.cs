// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
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
            : base(null)
        {
        }

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/checkout/sessions";

        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/checkout/sessions", options, requestOptions);
        }

        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        public virtual Session Expire(string id, SessionExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/checkout/sessions/{id}/expire", options, requestOptions);
        }

        public virtual Task<Session> ExpireAsync(string id, SessionExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/checkout/sessions/{id}/expire", options, requestOptions, cancellationToken);
        }

        public virtual Session Get(string id, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Get, $"/v1/checkout/sessions/{id}", options, requestOptions);
        }

        public virtual Task<Session> GetAsync(string id, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Get, $"/v1/checkout/sessions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Session> List(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Session>>(HttpMethod.Get, $"/v1/checkout/sessions", options, requestOptions);
        }

        public virtual Task<StripeList<Session>> ListAsync(SessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Session>>(HttpMethod.Get, $"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Session> ListAutoPaging(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Session>($"/v1/checkout/sessions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Session> ListAutoPagingAsync(SessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Session>($"/v1/checkout/sessions", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/checkout/sessions/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/checkout/sessions/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/checkout/sessions/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/checkout/sessions/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
