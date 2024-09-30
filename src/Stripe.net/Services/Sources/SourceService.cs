namespace Stripe
{
    using System;
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
            : base()
        {
        }

        internal SourceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        [Obsolete("This member is deprecated. Access this service directly via the client with client.V1.Sources")]
        public SourceService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Source Attach(string parentId, SourceAttachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions);
        }

        public virtual Task<Source> AttachAsync(string parentId, SourceAttachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions, cancellationToken);
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources", options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources", options, requestOptions, cancellationToken);
        }

        public virtual Source Detach(string parentId, string id, SourceDetachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", null, requestOptions);
        }

        public virtual Task<Source> DetachAsync(string parentId, string id, SourceDetachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", null, requestOptions, cancellationToken);
        }

        public virtual Source Get(string id, SourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Get, $"/v1/sources/{id}", options, requestOptions);
        }

        public virtual Task<Source> GetAsync(string id, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Get, $"/v1/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Source> List(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Source>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        public virtual Task<StripeList<Source>> ListAsync(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Source>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Source> ListAutoPaging(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Source>($"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        public virtual IAsyncEnumerable<Source> ListAutoPagingAsync(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Source>($"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }

        public virtual Source Update(string id, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{id}", options, requestOptions);
        }

        public virtual Task<Source> UpdateAsync(string id, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{id}/verify", options, requestOptions);
        }

        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{id}/verify", options, requestOptions, cancellationToken);
        }
    }
}
