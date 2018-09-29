namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class FileLinkService : Service<FileLink>,
        ICreatable<FileLink, FileLinkCreateOptions>,
        IListable<FileLink, FileLinkListOptions>,
        IRetrievable<FileLink>,
        IUpdatable<FileLink, FileLinkUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/file_links";

        public FileLinkService()
            : base(null)
        {
        }

        public FileLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual FileLink Create(FileLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual Task<FileLink> CreateAsync(FileLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual FileLink Get(string fileLinkId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{fileLinkId}", requestOptions);
        }

        public virtual Task<FileLink> GetAsync(string fileLinkId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{fileLinkId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<FileLink> List(FileLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Task<StripeList<FileLink>> ListAsync(FileLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual FileLink Update(string fileLinkId, FileLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{fileLinkId}", requestOptions, options);
        }

        public virtual Task<FileLink> UpdateAsync(string fileLinkId, FileLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{fileLinkId}", requestOptions, cancellationToken, options);
        }
    }
}
