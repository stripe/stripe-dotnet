namespace Stripe
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class FileService : BasicService<File>,
        ICreatable<File, FileCreateOptions>,
        IListable<File, FileListOptions>,
        IRetrievable<File>
    {
        private static string classPath = "/files";

        public FileService()
            : base(null)
        {
        }

        public FileService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual File Create(FileCreateOptions options, RequestOptions requestOptions = null)
        {
            return Mapper<File>.MapFromJson(
                Requestor.PostFile(
                    $"{Urls.BaseFilesUrl}{classPath}",
                    options.File,
                    options.Purpose,
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<File> CreateAsync(FileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<File>.MapFromJson(
                await Requestor.PostFileAsync(
                    $"{Urls.BaseFilesUrl}{classPath}",
                    options.File,
                    options.Purpose,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual File Get(string fileId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}{classPath}/{fileId}", requestOptions);
        }

        public virtual Task<File> GetAsync(string fileId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}{classPath}/{fileId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<File> List(FileListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}{classPath}", requestOptions, listOptions);
        }

        public virtual Task<StripeList<File>> ListAsync(FileListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}{classPath}", requestOptions, cancellationToken, listOptions);
        }
    }
}
