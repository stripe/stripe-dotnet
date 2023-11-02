// File generated from our OpenAPI spec
namespace Stripe
{
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
            : base(null)
        {
        }

        public WebhookEndpointService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/webhook_endpoints";

        public virtual WebhookEndpoint Create(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints", options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> CreateAsync(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints", options, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Delete(string id, WebhookEndpointDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Delete, $"/v1/webhook_endpoints/{id}", options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> DeleteAsync(string id, WebhookEndpointDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Delete, $"/v1/webhook_endpoints/{id}", options, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Get(string id, WebhookEndpointGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Get, $"/v1/webhook_endpoints/{id}", options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> GetAsync(string id, WebhookEndpointGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Get, $"/v1/webhook_endpoints/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<WebhookEndpoint> List(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<WebhookEndpoint>>(HttpMethod.Get, $"/v1/webhook_endpoints", options, requestOptions);
        }

        public virtual Task<StripeList<WebhookEndpoint>> ListAsync(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<WebhookEndpoint>>(HttpMethod.Get, $"/v1/webhook_endpoints", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<WebhookEndpoint> ListAutoPaging(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<WebhookEndpoint>($"/v1/webhook_endpoints", options, requestOptions);
        }

        public virtual IAsyncEnumerable<WebhookEndpoint> ListAutoPagingAsync(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<WebhookEndpoint>($"/v1/webhook_endpoints", options, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Update(string id, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints/{id}", options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> UpdateAsync(string id, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WebhookEndpoint>(HttpMethod.Post, $"/v1/webhook_endpoints/{id}", options, requestOptions, cancellationToken);
        }
    }
}
