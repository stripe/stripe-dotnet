namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeFileLinkService : StripeService
    {
        private static string classUrl = Urls.BaseUrl + "/file_links";

        public StripeFileLinkService()
            : base(null)
        {
        }

        public StripeFileLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeFileLink Create(StripeFileLinkCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return CreateAsync(createOptions, requestOptions).Result;
        }

        public virtual async Task<StripeFileLink> CreateAsync(StripeFileLinkCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileLink>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeFileLink Get(string fileLinkId, StripeRequestOptions requestOptions = null)
        {
            return GetAsync(fileLinkId, requestOptions).Result;
        }

        public virtual async Task<StripeFileLink> GetAsync(string fileLinkId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileLink>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<StripeFileLink> List(StripeFileLinkListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return ListAsync(listOptions, requestOptions).Result;
        }

        public virtual async Task<StripeList<StripeFileLink>> ListAsync(StripeFileLinkListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeFileLink>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeFileLink Update(string fileLinkId, StripeFileLinkUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return UpdateAsync(fileLinkId, updateOptions, requestOptions).Result;
        }

        public virtual async Task<StripeFileLink> UpdateAsync(string fileLinkId, StripeFileLinkUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileLink>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{WebUtility.UrlEncode(fileLinkId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
