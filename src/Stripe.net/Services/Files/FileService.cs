namespace Stripe
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
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
            return this.CreateAsync(options, requestOptions)
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public virtual async Task<File> CreateAsync(FileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            requestOptions = this.SetupRequestOptions(requestOptions);
            requestOptions.BaseUrl = StripeConfiguration.FilesBase;
            var url = requestOptions.BaseUrl + this.BasePath;
            var wr = Requestor.GetRequestMessage(
                url,
                HttpMethod.Post,
                requestOptions);
            Requestor.ApplyMultiPartFileToRequest(wr, options.File, options.Purpose);
            return await Requestor.ExecuteRequestAsync<File>(wr);
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
