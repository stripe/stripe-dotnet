// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class WebhookEndpointService : Service<WebhookEndpoint>,
        ICreatable<WebhookEndpoint, WebhookEndpointCreateOptions>,
        IDeletable<WebhookEndpoint, WebhookEndpointDeleteOptions>,
        IListable<WebhookEndpoint, WebhookEndpointListOptions>,
        IRetrievable<WebhookEndpoint, WebhookEndpointGetOptions>,
        IUpdatable<WebhookEndpoint, WebhookEndpointUpdateOptions>
    {
        public WebhookEndpointService()
        {
        }

        public WebhookEndpointService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/webhook_endpoints";

        /// <summary>
        /// <p>A webhook endpoint must have a <c>url</c> and a list of <c>enabled_events</c>. You
        /// may optionally specify the Boolean <c>connect</c> parameter. If set to true, then a
        /// Connect webhook endpoint that notifies the specified <c>url</c> about events from all
        /// connected accounts is created; otherwise an account webhook endpoint that notifies the
        /// specified <c>url</c> only about events from your account is created. You can also create
        /// webhook endpoints in the <a
        /// href="https://dashboard.stripe.com/account/webhooks">webhooks settings</a> section of
        /// the Dashboard.</p>.
        /// </summary>
        public virtual WebhookEndpoint Create(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints", options, requestOptions);
        }

        /// <summary>
        /// <p>A webhook endpoint must have a <c>url</c> and a list of <c>enabled_events</c>. You
        /// may optionally specify the Boolean <c>connect</c> parameter. If set to true, then a
        /// Connect webhook endpoint that notifies the specified <c>url</c> about events from all
        /// connected accounts is created; otherwise an account webhook endpoint that notifies the
        /// specified <c>url</c> only about events from your account is created. You can also create
        /// webhook endpoints in the <a
        /// href="https://dashboard.stripe.com/account/webhooks">webhooks settings</a> section of
        /// the Dashboard.</p>.
        /// </summary>
        public virtual Task<WebhookEndpoint> CreateAsync(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can also delete webhook endpoints via the <a
        /// href="https://dashboard.stripe.com/account/webhooks">webhook endpoint management</a>
        /// page of the Stripe dashboard.</p>.
        /// </summary>
        public virtual WebhookEndpoint Delete(string id, WebhookEndpointDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Delete, $"/v1/webhook_endpoints/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>You can also delete webhook endpoints via the <a
        /// href="https://dashboard.stripe.com/account/webhooks">webhook endpoint management</a>
        /// page of the Stripe dashboard.</p>.
        /// </summary>
        public virtual Task<WebhookEndpoint> DeleteAsync(string id, WebhookEndpointDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Delete, $"/v1/webhook_endpoints/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the webhook endpoint with the given ID.</p>.
        /// </summary>
        public virtual WebhookEndpoint Get(string id, WebhookEndpointGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Get, $"/v1/webhook_endpoints/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the webhook endpoint with the given ID.</p>.
        /// </summary>
        public virtual Task<WebhookEndpoint> GetAsync(string id, WebhookEndpointGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Get, $"/v1/webhook_endpoints/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your webhook endpoints.</p>.
        /// </summary>
        public virtual StripeList<WebhookEndpoint> List(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<WebhookEndpoint>>(HttpMethod.Get, $"/v1/webhook_endpoints", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your webhook endpoints.</p>.
        /// </summary>
        public virtual Task<StripeList<WebhookEndpoint>> ListAsync(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<WebhookEndpoint>>(HttpMethod.Get, $"/v1/webhook_endpoints", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your webhook endpoints.</p>.
        /// </summary>
        public virtual IEnumerable<WebhookEndpoint> ListAutoPaging(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<WebhookEndpoint>($"/v1/webhook_endpoints", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your webhook endpoints.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<WebhookEndpoint> ListAutoPagingAsync(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<WebhookEndpoint>($"/v1/webhook_endpoints", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the webhook endpoint. You may edit the <c>url</c>, the list of
        /// <c>enabled_events</c>, and the status of your endpoint.</p>.
        /// </summary>
        public virtual WebhookEndpoint Update(string id, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the webhook endpoint. You may edit the <c>url</c>, the list of
        /// <c>enabled_events</c>, and the status of your endpoint.</p>.
        /// </summary>
        public virtual Task<WebhookEndpoint> UpdateAsync(string id, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints/{id}", options, requestOptions, cancellationToken);
        }
    }
}
