using System.Collections.Generic;

namespace Stripe
{
	public class StripeChargeService
	{
		private string ApiKey { get; set; }

		public StripeChargeService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeCharge Create(StripeChargeCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Charges);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual StripeCharge Get(string chargeId)
		{
			var url = string.Format("{0}/{1}", Urls.Charges, chargeId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual StripeCharge Refund(string chargeId, int? refundAmountInCents = null, bool? refundApplicationFee = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);

			if (refundAmountInCents.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmountInCents.Value.ToString());
			if (refundApplicationFee.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "refund_application_fee", refundApplicationFee.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeCharge> List(StripeChargeListOptions options = null)
		{
			var url = Urls.Charges;
			if (options != null)
			{
				url = ParameterBuilder.ApplyAllParameters(options, url);
			}

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCharge>.MapCollectionFromJson(response);
		}

		public virtual StripeCharge Capture(string chargeId, int? captureAmountInCents = null, int? applicationFeeInCents = null)
		{
			var url = string.Format("{0}/{1}/capture", Urls.Charges, chargeId);

			if (captureAmountInCents.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmountInCents.Value.ToString());
			if (applicationFeeInCents.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFeeInCents.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}
	}
}
