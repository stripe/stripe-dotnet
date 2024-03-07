namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/files";

        public virtual File Create(FileCreateOptions options, RequestOptions requestOptions = null)
        {
            requestOptions = this.SetupRequestOptionsForFilesRequest(requestOptions);
            return this.Request<File>(HttpMethod.Post, $"/v1/files", options, requestOptions);
        }

        public virtual Task<File> CreateAsync(FileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions = this.SetupRequestOptionsForFilesRequest(requestOptions);
            return this.RequestAsync<File>(HttpMethod.Post, $"/v1/files", options, requestOptions, cancellationToken);
        }

        public virtual File Get(string id, FileGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<File>(HttpMethod.Get, $"/v1/files/{id}", options, requestOptions);
        }

        public virtual Task<File> GetAsync(string id, FileGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<File>(HttpMethod.Get, $"/v1/files/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<File> List(FileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<File>>(HttpMethod.Get, $"/v1/files", options, requestOptions);
        }

        public virtual Task<StripeList<File>> ListAsync(FileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<File>>(HttpMethod.Get, $"/v1/files", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<File> ListAutoPaging(FileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<File>($"/v1/files", options, requestOptions);
        }

        public virtual IAsyncEnumerable<File> ListAutoPagingAsync(FileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<File>($"/v1/files", options, requestOptions, cancellationToken);
        }

        private RequestOptions SetupRequestOptionsForFilesRequest(RequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new RequestOptions();
            }

            if (requestOptions.BaseUrl == null)
            {
                requestOptions = requestOptions.Clone();
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return requestOptions;
        }
    }
}
