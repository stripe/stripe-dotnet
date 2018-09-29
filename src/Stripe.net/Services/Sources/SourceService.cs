namespace Stripe
{
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

        public virtual Source Attach(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, options);
        }

        public virtual Task<Source> AttachAsync(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/sources", requestOptions, options);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Source Detach(string customerId, string sourceId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/customers/{customerId}/sources/{sourceId}", requestOptions);
        }

        public virtual Task<Source> DetachAsync(string customerId, string sourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{sourceId}", requestOptions, cancellationToken);
        }

        public virtual Source Get(string sourceId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions);
        }

        public virtual Task<Source> GetAsync(string sourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<Source> List(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, options);
        }

        public virtual Task<StripeList<Source>> ListAsync(string customerId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Source Update(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, options);
        }

        public virtual Task<Source> UpdateAsync(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken, options);
        }
    }
}
