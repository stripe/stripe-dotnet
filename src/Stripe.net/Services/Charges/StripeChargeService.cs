using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeChargeService : StripeService
    {
        public StripeChargeService() : base(null) { }
        public StripeChargeService(string apiKey) : base(apiKey) { }

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



        //Sync
        public virtual StripeCharge Create(StripeChargeCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Charges, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCharge Update(string chargeId, StripeChargeUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCharge Get(string chargeId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeCharge> List(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCharge>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Charges, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCharge Capture(string chargeId, StripeChargeCaptureOptions captureOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(captureOptions, $"{Urls.Charges}/{chargeId}/capture", false),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeCharge> CreateAsync(StripeChargeCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Charges, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCharge> UpdateAsync(string chargeId, StripeChargeUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCharge> GetAsync(string chargeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeCharge>> ListAsync(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCharge>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Charges, true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCharge> CaptureAsync(string chargeId, StripeChargeCaptureOptions captureOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(captureOptions, $"{Urls.Charges}/{chargeId}/capture", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
