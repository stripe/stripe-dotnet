// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FileLinkService : Service<FileLink>,
        ICreatable<FileLink, FileLinkCreateOptions>,
        IListable<FileLink, FileLinkListOptions>,
        IRetrievable<FileLink, FileLinkGetOptions>,
        IUpdatable<FileLink, FileLinkUpdateOptions>
    {
        public FileLinkService()
            : base(null)
        {
        }

        public FileLinkService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/file_links";

        public virtual FileLink Create(FileLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FileLink>(HttpMethod.Post, $"/v1/file_links", options, requestOptions);
        }

        public virtual Task<FileLink> CreateAsync(FileLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FileLink>(HttpMethod.Post, $"/v1/file_links", options, requestOptions, cancellationToken);
        }

        public virtual FileLink Get(string id, FileLinkGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FileLink>(HttpMethod.Get, $"/v1/file_links/{id}", options, requestOptions);
        }

        public virtual Task<FileLink> GetAsync(string id, FileLinkGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FileLink>(HttpMethod.Get, $"/v1/file_links/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<FileLink> List(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FileLink>>(HttpMethod.Get, $"/v1/file_links", options, requestOptions);
        }

        public virtual Task<StripeList<FileLink>> ListAsync(FileLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FileLink>>(HttpMethod.Get, $"/v1/file_links", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FileLink> ListAutoPaging(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FileLink>($"/v1/file_links", options, requestOptions);
        }

        public virtual IAsyncEnumerable<FileLink> ListAutoPagingAsync(FileLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FileLink>($"/v1/file_links", options, requestOptions, cancellationToken);
        }

        public virtual FileLink Update(string id, FileLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FileLink>(HttpMethod.Post, $"/v1/file_links/{id}", options, requestOptions);
        }

        public virtual Task<FileLink> UpdateAsync(string id, FileLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FileLink>(HttpMethod.Post, $"/v1/file_links/{id}", options, requestOptions, cancellationToken);
        }
    }
}
