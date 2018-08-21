namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class FileLinkService : StripeService
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

        public virtual StripeFileLink Create(FileLinkCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeFileLink>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeFileLink> CreateAsync(FileLinkCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileLink>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeFileLink Get(string fileLinkId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeFileLink>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeFileLink> GetAsync(string fileLinkId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileLink>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<StripeFileLink> List(FileLinkListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeFileLink>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<StripeFileLink>> ListAsync(FileLinkListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeFileLink>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeFileLink Update(string fileLinkId, FileLinkUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeFileLink>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeFileLink> UpdateAsync(string fileLinkId, FileLinkUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileLink>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
