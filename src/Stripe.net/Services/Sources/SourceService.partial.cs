namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source, SourceGetOptions>,
        IUpdatable<Source, SourceUpdateOptions>,
        INestedListable<Source, SourceListOptions>
    {
        [Obsolete("Use CustomerPaymentSourceService.Create instead.")]
        public virtual Source Attach(string parentId, SourceAttachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions);
        }

        [Obsolete("Use CustomerPaymentSourceService.CreateAsync instead.")]
        public virtual Task<Source> AttachAsync(string parentId, SourceAttachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions, cancellationToken);
        }

        [Obsolete("Use CustomerPaymentSourceService.Delete instead.")]
        public virtual Source Detach(string parentId, string id, SourceDetachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{WebUtility.UrlEncode(id)}", null, requestOptions);
        }

        [Obsolete("Use CustomerPaymentSourceService.DeleteAsync instead.")]
        public virtual Task<Source> DetachAsync(string parentId, string id, SourceDetachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{WebUtility.UrlEncode(id)}", null, requestOptions, cancellationToken);
        }

        [Obsolete("Use CustomerPaymentSourceService.List instead.")]
        public virtual StripeList<Source> List(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Source>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        [Obsolete("Use CustomerPaymentSourceService.ListAsync instead.")]
        public virtual Task<StripeList<Source>> ListAsync(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Source>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }

        [Obsolete("Use CustomerPaymentSourceService.ListAutoPaging instead.")]
        public virtual IEnumerable<Source> ListAutoPaging(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Source>($"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        [Obsolete("Use CustomerPaymentSourceService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<Source> ListAutoPagingAsync(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Source>($"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }
    }
}
