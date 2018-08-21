namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ChargeService : StripeService
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

        public virtual StripeCharge Create(ChargeCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Charges, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCharge Update(string chargeId, ChargeUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCharge Get(string chargeId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeCharge> List(ChargeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCharge>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Charges, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCharge Capture(string chargeId, ChargeCaptureOptions captureOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(captureOptions, $"{Urls.Charges}/{chargeId}/capture", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeCharge> CreateAsync(ChargeCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Charges, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCharge> UpdateAsync(string chargeId, ChargeUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCharge> GetAsync(string chargeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeCharge>> ListAsync(ChargeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCharge>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Charges, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCharge> CaptureAsync(string chargeId, ChargeCaptureOptions captureOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(captureOptions, $"{Urls.Charges}/{chargeId}/capture", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
