namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source>,
        IUpdatable<Source, SourceUpdateOptions>,
        INestedListable<Source, SourceListOptions>
    {
        public SourceService()
            : base(null)
        {
        }

        public SourceService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/sources";

        public virtual Source Attach(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<Source>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources", options, requestOptions);
        }

        public virtual Task<Source> AttachAsync(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Source>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources", options, requestOptions, cancellationToken);
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Source Detach(string customerId, string sourceId, RequestOptions requestOptions = null)
        {
            return this.DeleteRequest<Source>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources/{sourceId}", null, requestOptions);
        }

        public virtual Task<Source> DetachAsync(string customerId, string sourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteRequestAsync<Source>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources/{sourceId}", null, requestOptions, cancellationToken);
        }

        public virtual Source Get(string sourceId, RequestOptions requestOptions = null)
        {
            return this.Get(sourceId, null, requestOptions);
        }

        public virtual Task<Source> GetAsync(string sourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetAsync(sourceId, null, requestOptions, cancellationToken);
        }

        public virtual Source Get(string sourceId, SourceGetOptions options, RequestOptions requestOptions = null)
        {
            return this.GetEntity(sourceId, options, requestOptions);
        }

        public virtual Task<Source> GetAsync(string sourceId, SourceGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(sourceId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Source> List(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetRequest<StripeList<Source>>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources", options, requestOptions, true);
        }

        public virtual Task<StripeList<Source>> ListAsync(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetRequestAsync<StripeList<Source>>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources", options, requestOptions, true, cancellationToken);
        }

        public virtual IEnumerable<Source> ListAutoPaging(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Source>($"{StripeConfiguration.ApiBase}/v1/customers/{customerId}/sources", options, requestOptions);
        }

        public virtual Source Update(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(sourceId, options, requestOptions);
        }

        public virtual Task<Source> UpdateAsync(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(sourceId, options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string sourceId, SourceVerifyOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<Source>($"{this.InstanceUrl(sourceId)}/verify", options, requestOptions);
        }

        public virtual Task<Source> VerifyAsync(string sourceId, SourceVerifyOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Source>($"{this.InstanceUrl(sourceId)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
