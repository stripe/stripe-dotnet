namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ChargeService : StripeService,
        ICreatable<Charge, ChargeCreateOptions>,
        IListable<Charge, ChargeListOptions>,
        IRetrievable<Charge>,
        IUpdatable<Charge, ChargeUpdateOptions>
    {
        public ChargeService()
            : base(null)
        {
        }

        public ChargeService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandApplication { get; set; }

        public bool ExpandApplicationFee { get; set; }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCustomer { get; set; }

        public bool ExpandDestination { get; set; }

        public bool ExpandDispute { get; set; }

        public bool ExpandInvoice { get; set; }

        public bool ExpandOnBehalfOf { get; set; }

        public bool ExpandOrder { get; set; }

        public bool ExpandReview { get; set; }

        public bool ExpandSourceTransfer { get; set; }

        public bool ExpandTransfer { get; set; }

        public virtual Charge Create(ChargeCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Charge>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Charges, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Charge Update(string chargeId, ChargeUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Charge>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Charge Get(string chargeId, RequestOptions requestOptions = null)
        {
            return Mapper<Charge>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Charge> List(ChargeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Charge>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Charges, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Charge Capture(string chargeId, ChargeCaptureOptions captureOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Charge>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(captureOptions, $"{Urls.Charges}/{chargeId}/capture", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Charge> CreateAsync(ChargeCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Charge>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Charges, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Charge> UpdateAsync(string chargeId, ChargeUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Charge>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Charge> GetAsync(string chargeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Charge>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Charge>> ListAsync(ChargeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Charge>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Charges, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Charge> CaptureAsync(string chargeId, ChargeCaptureOptions captureOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Charge>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(captureOptions, $"{Urls.Charges}/{chargeId}/capture", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
