namespace Stripe
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class FileUploadService : StripeService
    {
        public FileUploadService()
            : base(null)
        {
        }

        public FileUploadService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual FileUpload Create(FileUploadCreateOptions options, RequestOptions requestOptions = null)
        {
            return Mapper<FileUpload>.MapFromJson(
                Requestor.PostFile(
                    Urls.FileUploads,
                    options.File,
                    options.Purpose,
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<FileUpload> CreateAsync(FileUploadCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<FileUpload>.MapFromJson(
                await Requestor.PostFileAsync(
                    Urls.FileUploads,
                    options.File,
                    options.Purpose,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual FileUpload Get(string fileUploadId, RequestOptions requestOptions = null)
        {
            return Mapper<FileUpload>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.FileUploads}/{fileUploadId}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<FileUpload> GetAsync(string fileUploadId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<FileUpload>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.FileUploads}/{fileUploadId}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<FileUpload> List(FileUploadListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<FileUpload>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.FileUploads, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<FileUpload>> ListAsync(FileUploadListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<FileUpload>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.FileUploads, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
