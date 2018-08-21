namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TopupService : StripeService
    {
        public TopupService(string apiKey = null)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandSource { get; set; }

        public virtual StripeTopup Cancel(string topupId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}/cancel", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeTopup> CancelAsync(string topupId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}/cancel", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeTopup Create(TopupCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Topups, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeTopup> CreateAsync(TopupCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Topups, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }

        public virtual StripeTopup Get(string topupId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeTopup> GetAsync(string topupId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }

        public virtual StripeList<StripeTopup> List(TopupListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeTopup>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Topups, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<StripeTopup>> ListAsync(TopupListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeTopup>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Topups, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }

        public virtual StripeTopup Update(string topupId, TopupUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeTopup> UpdateAsync(string topupId, TopupUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }
    }
}
