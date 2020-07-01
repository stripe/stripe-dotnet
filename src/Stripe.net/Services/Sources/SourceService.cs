namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source, SourceGetOptions>,
        IUpdatable<Source, SourceUpdateOptions>,
        INestedListable<Source, SourceListOptions>
    {
        public SourceService()
            : base(null)
        {
        }

        public SourceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/sources";

        public virtual Source Attach(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(HttpMethod.Post, $"/v1/customers/{customerId}/sources", options, requestOptions);
        }

        public virtual Task<Source> AttachAsync(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(HttpMethod.Post, $"/v1/customers/{customerId}/sources", options, requestOptions, cancellationToken);
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Source Detach(string customerId, string id, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(HttpMethod.Delete, $"/v1/customers/{customerId}/sources/{id}", null, requestOptions);
        }

        public virtual Task<Source> DetachAsync(string customerId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(HttpMethod.Delete, $"/v1/customers/{customerId}/sources/{id}", null, requestOptions, cancellationToken);
        }

        public virtual Source Get(string id, SourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Source> GetAsync(string id, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Source> List(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Source>>(HttpMethod.Get, $"/v1/customers/{customerId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        public virtual Task<StripeList<Source>> ListAsync(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Source>>(HttpMethod.Get, $"/v1/customers/{customerId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Source> ListAutoPaging(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Source>($"/v1/customers/{customerId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        public virtual IAsyncEnumerable<Source> ListAutoPagingAsync(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Source>($"/v1/customers/{customerId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }

        public virtual Source Update(string id, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Source> UpdateAsync(string id, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string id, SourceVerifyOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions);
        }

        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
