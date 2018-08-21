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

        public virtual StripeFileUpload Create(string fileName, Stream fileStream, string purpose, RequestOptions requestOptions = null)
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                Requestor.PostFile(Urls.FileUploads, fileName, fileStream, purpose, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeFileUpload Get(string fileUploadId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.FileUploads}/{fileUploadId}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeFileUpload> List(FileUploadListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeFileUpload>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.FileUploads, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeFileUpload> CreateAsync(string fileName, Stream fileStream, string purpose, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                await Requestor.PostFileAsync(Urls.FileUploads, fileName, fileStream, purpose, this.SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeFileUpload> GetAsync(string fileUploadId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.FileUploads}/{fileUploadId}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeFileUpload>> ListAsync(FileUploadListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeFileUpload>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.FileUploads, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
