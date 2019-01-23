namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class FileService : Service<File>,
        ICreatable<File, FileCreateOptions>,
        IListable<File, FileListOptions>,
        IRetrievable<File>
    {
        public FileService()
            : base(null)
        {
        }

        public FileService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/files";

        public virtual File Create(FileCreateOptions options, RequestOptions requestOptions = null)
        {
            return Mapper<File>.MapFromJson(
                Requestor.PostFile(
                    this.ClassUrl(StripeConfiguration.FilesBase),
                    options.File,
                    options.Purpose,
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<File> CreateAsync(FileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<File>.MapFromJson(
                await Requestor.PostFileAsync(
                    this.ClassUrl(StripeConfiguration.FilesBase),
                    options.File,
                    options.Purpose,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual File Get(string fileId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(fileId, null, requestOptions);
        }

        public virtual Task<File> GetAsync(string fileId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(fileId, null, requestOptions, cancellationToken);
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
    }
}
