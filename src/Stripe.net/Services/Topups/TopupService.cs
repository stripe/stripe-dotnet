namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TopupService : StripeService,
        ICreatable<Topup, TopupCreateOptions>,
        IListable<Topup, TopupListOptions>,
        IRetrievable<Topup>,
        IUpdatable<Topup, TopupUpdateOptions>
    {
        public TopupService(string apiKey = null)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandSource { get; set; }

        public virtual Topup Cancel(string topupId, RequestOptions requestOptions = null)
        {
            return Mapper<Topup>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}/cancel", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Topup> CancelAsync(string topupId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Topup>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}/cancel", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Topup Create(TopupCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Topup>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Topups, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Topup> CreateAsync(TopupCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Topup>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Topups, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }

        public virtual Topup Get(string topupId, RequestOptions requestOptions = null)
        {
            return Mapper<Topup>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Topup> GetAsync(string topupId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Topup>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }

        public virtual StripeList<Topup> List(TopupListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Topup>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Topups, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<Topup>> ListAsync(TopupListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Topup>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Topups, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }

        public virtual Topup Update(string topupId, TopupUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Topup>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Topup> UpdateAsync(string topupId, TopupUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Topup>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Topups}/{topupId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken));
        }
    }
}
