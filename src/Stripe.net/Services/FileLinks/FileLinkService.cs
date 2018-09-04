namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class FileLinkService : StripeService,
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

        public virtual FileLink Create(FileLinkCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<FileLink>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<FileLink> CreateAsync(FileLinkCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<FileLink>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual FileLink Get(string fileLinkId, RequestOptions requestOptions = null)
        {
            return Mapper<FileLink>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<FileLink> GetAsync(string fileLinkId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<FileLink>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<FileLink> List(FileLinkListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<FileLink>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<FileLink>> ListAsync(FileLinkListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<FileLink>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual FileLink Update(string fileLinkId, FileLinkUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<FileLink>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<FileLink> UpdateAsync(string fileLinkId, FileLinkUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<FileLink>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
