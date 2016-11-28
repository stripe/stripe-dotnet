using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeChargeService : StripeService
    {
        public StripeChargeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCustomer { get; set; }
        public bool ExpandDestination { get; set; }
        public bool ExpandInvoice { get; set; }
        public bool ExpandReview { get; set; }



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

        public virtual IEnumerable<StripeCharge> List(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCharge>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Charges, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCharge Capture(string chargeId, int? captureAmount = null, int? applicationFee = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}/capture", false);

            if (captureAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmount.Value.ToString());
            if (applicationFee.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFee.Value.ToString());

            return Mapper<StripeCharge>.MapFromJson(
                Requestor.PostString(url,
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeCharge> CreateAsync(StripeChargeCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Charges, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeCharge> UpdateAsync(string chargeId, StripeChargeUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeCharge> GetAsync(string chargeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<IEnumerable<StripeCharge>> ListAsync(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCharge>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Charges, true),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeCharge> CaptureAsync(string chargeId, int? captureAmount = null, int? applicationFee = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}/capture", false);

            if (captureAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmount.Value.ToString());
            if (applicationFee.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFee.Value.ToString());

            return Mapper<StripeCharge>.MapFromJson(
                await Requestor.PostStringAsync(url,
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
