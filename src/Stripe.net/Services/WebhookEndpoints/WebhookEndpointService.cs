namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class WebhookEndpointService : Service<WebhookEndpoint>,
        ICreatable<WebhookEndpoint, WebhookEndpointCreateOptions>,
        IDeletable<WebhookEndpoint>,
        IListable<WebhookEndpoint, WebhookEndpointListOptions>,
        IRetrievable<WebhookEndpoint>,
        IUpdatable<WebhookEndpoint, WebhookEndpointUpdateOptions>
    {
        public WebhookEndpointService()
            : base(null)
        {
        }

        public WebhookEndpointService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/webhook_endpoints";

        public virtual WebhookEndpoint Create(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> CreateAsync(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Delete(string endpointId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(endpointId, null, requestOptions);
        }

        public virtual Task<WebhookEndpoint> DeleteAsync(string endpointId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(endpointId, null, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Get(string endpointId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(endpointId, null, requestOptions);
        }

        public virtual Task<WebhookEndpoint> GetAsync(string endpointId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(endpointId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<WebhookEndpoint> List(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<WebhookEndpoint>> ListAsync(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<WebhookEndpoint> ListAutoPaging(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual WebhookEndpoint Update(string endpointId, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(endpointId, options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> UpdateAsync(string endpointId, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(endpointId, options, requestOptions, cancellationToken);
        }
    }
}
