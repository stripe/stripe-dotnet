namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class FileLinkService : Service<FileLink>,
        ICreatable<FileLink, FileLinkCreateOptions>,
        IListable<FileLink, FileLinkListOptions>,
        IRetrievable<FileLink>,
        IUpdatable<FileLink, FileLinkUpdateOptions>
    {
        public FileLinkService()
            : base(null)
        {
        }

        public FileLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/file_links";

        public virtual FileLink Create(FileLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<FileLink> CreateAsync(FileLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual FileLink Get(string fileLinkId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(fileLinkId, null, requestOptions);
        }

        public virtual Task<FileLink> GetAsync(string fileLinkId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(fileLinkId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<FileLink> List(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<FileLink>> ListAsync(FileLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FileLink> ListAutoPaging(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual FileLink Update(string fileLinkId, FileLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(fileLinkId, options, requestOptions);
        }

        public virtual Task<FileLink> UpdateAsync(string fileLinkId, FileLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(fileLinkId, options, requestOptions, cancellationToken);
        }
    }
}
