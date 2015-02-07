using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeChargeService : StripeService
    {
        public StripeChargeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCustomer { get; set; }
        public bool ExpandInvoice { get; set; }

        public virtual StripeCharge Create(StripeChargeCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Charges, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCharge> CreateAsync(StripeChargeCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Charges, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }
#endif

        public virtual StripeCharge Get(string chargeId)
        {
            var url = FormatGetUrl(chargeId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCharge> GetAsync(string chargeId)
        {
            var url = FormatGetUrl(chargeId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }
#endif

        public virtual StripeCharge Refund(string chargeId, int? refundAmount = null, bool? refundApplicationFee = null)
        {
            var url = FormatRefundUrl(chargeId, refundAmount, refundApplicationFee);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCharge> RefundAsync(string chargeId, int? refundAmount = null, bool? refundApplicationFee = null)
        {
            var url = FormatRefundUrl(chargeId, refundAmount, refundApplicationFee);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }
#endif

        public virtual IEnumerable<StripeCharge> List(StripeChargeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCharge>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeCharge>> ListAsync(StripeChargeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCharge>.MapCollectionFromJson(response);
        }
#endif

        public virtual StripeCharge Capture(string chargeId, int? captureAmount = null, int? applicationFee = null)
        {
            var url = FormatCaptureUrl(chargeId, captureAmount, applicationFee);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCharge> CaptureAsync(string chargeId, int? captureAmount = null, int? applicationFee = null)
        {
            var url = FormatCaptureUrl(chargeId, captureAmount, applicationFee);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCharge>.MapFromJson(response);
        }
#endif

        private string FormatCaptureUrl(string chargeId, int? captureAmount, int? applicationFee)
        {
            var url = string.Format("{0}/{1}/capture", Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);

            if (captureAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmount.Value.ToString());
            if (applicationFee.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFee.Value.ToString());
            return url;
        }

        private string FormatListUrl(StripeChargeListOptions listOptions)
        {
            var url = Urls.Charges;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatGetUrl(string chargeId)
        {
            var url = string.Format("{0}/{1}", Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatRefundUrl(string chargeId, int? refundAmount, bool? refundApplicationFee)
        {
            var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            if (refundApplicationFee.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "refund_application_fee", refundApplicationFee.Value.ToString());
            return url;
        }
    }
}
