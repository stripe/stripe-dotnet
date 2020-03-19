namespace Stripe
{
    using System.Collections.Generic;
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
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<FileLink> CreateAsync(FileLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual FileLink Get(string fileLinkId, FileLinkGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(fileLinkId, options, requestOptions);
        }

        public virtual Task<FileLink> GetAsync(string fileLinkId, FileLinkGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(fileLinkId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<FileLink> List(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<FileLink>> ListAsync(FileLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FileLink> ListAutoPaging(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<FileLink> ListAutoPagingAsync(FileLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual FileLink Update(string fileLinkId, FileLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(fileLinkId, options, requestOptions);
        }

        public virtual Task<FileLink> UpdateAsync(string fileLinkId, FileLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(fileLinkId, options, requestOptions, cancellationToken);
        }
    }
}
