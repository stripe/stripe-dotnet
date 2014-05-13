using System.Collections.Generic;
using System.Globalization;

namespace Stripe
{
	public class StripeChargeService
	{
		private string ApiKey { get; set; }

		public StripeChargeService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeCharge> Create(StripeChargeCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Charges);
		    return url.PostResponse<StripeCharge>(ApiKey);
		}

        public virtual StripeResponse<StripeCharge> Get(string chargeId)
		{
			var url = string.Format("{0}/{1}", Urls.Charges, chargeId);

            return url.GetResponse<StripeCharge>(ApiKey);
		}

        public virtual StripeResponse<StripeCharge> Refund(string chargeId, int? refundAmount = null, bool? refundApplicationFee = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);
            if (refundAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString(CultureInfo.InvariantCulture));
            }
            if (refundApplicationFee.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "refund_application_fee", refundApplicationFee.Value.ToString());
            }

            return url.PostResponse<StripeCharge>(ApiKey);
		}

		public virtual StripeResponse<List<StripeCharge>> List(StripeChargeListOptions listOptions = null)
		{
			var url = Urls.Charges;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeCharge>(ApiKey);
		}

        public virtual StripeResponse<StripeCharge> Capture(string chargeId, int? captureAmount = null, int? applicationFee = null)
		{
			var url = string.Format("{0}/{1}/capture", Urls.Charges, chargeId);
            if (captureAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmount.Value.ToString(CultureInfo.InvariantCulture));
            }
            if (applicationFee.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFee.Value.ToString(CultureInfo.InvariantCulture));
            }
            return url.PostResponse<StripeCharge>(ApiKey);
		}
	}
}
