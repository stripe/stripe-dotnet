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

		public virtual StripeCharge Refund(string chargeId, int? refundAmount = null, bool? refundApplicationFee = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);

			if (refundAmount.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
			if(refundApplicationFee.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "refund_application_fee", refundApplicationFee.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeCharge> List(int limit = 10, string customerId = null)
		{
			var url = Urls.Charges;
			url = ParameterBuilder.ApplyParameterToUrl(url, "limit", limit.ToString());

			if (!string.IsNullOrEmpty(customerId))
				url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCharge>.MapCollectionFromJson(response);
		}

		public virtual StripeCharge Capture(string chargeId, int? captureAmount = null, int? applicationFee = null)
		{
			var url = string.Format("{0}/{1}/capture", Urls.Charges, chargeId);

			if (captureAmount.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmount.Value.ToString());
			if (applicationFee.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFee.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}
	}
}
