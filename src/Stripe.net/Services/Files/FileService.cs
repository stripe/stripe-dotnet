namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class FileService : Service<File>,
        ICreatable<File, FileCreateOptions>,
        IListable<File, FileListOptions>,
        IRetrievable<File, FileGetOptions>
    {
        public FileService()
            : base(null)
        {
        }

        public FileService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/files";

        public virtual File Create(FileCreateOptions options, RequestOptions requestOptions = null)
        {
            requestOptions = this.SetupRequestOptionsForFilesRequest(requestOptions);
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<File> CreateAsync(FileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            requestOptions = this.SetupRequestOptionsForFilesRequest(requestOptions);
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual File Get(string fileId, FileGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(fileId, options, requestOptions);
        }

        public virtual Task<File> GetAsync(string fileId, FileGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(fileId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<File> List(FileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<File>> ListAsync(FileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<File> ListAutoPaging(FileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        private RequestOptions SetupRequestOptionsForFilesRequest(RequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new RequestOptions();
            }

            if (requestOptions.BaseUrl == null)
            {
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return requestOptions;
        }
    }
}
