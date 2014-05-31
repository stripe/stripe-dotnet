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

		public bool ExpandCustomer { get; set; }
		public bool ExpandInvoice { get; set; }

		public virtual StripeCharge Create(StripeChargeCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Charges);
			url = ApplyExpandableProperties(url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual StripeCharge Get(string chargeId)
		{
			var url = string.Format("{0}/{1}", Urls.Charges, chargeId);
			url = ApplyExpandableProperties(url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual StripeCharge Refund(string chargeId, int? refundAmount = null, bool? refundApplicationFee = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);
			url = ApplyExpandableProperties(url);

			if (refundAmount.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
			if (refundApplicationFee.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "refund_application_fee", refundApplicationFee.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeCharge> List(StripeChargeListOptions listOptions = null)
		{
			var url = Urls.Charges;

			if (listOptions != null)
				url = ParameterBuilder.ApplyAllParameters(listOptions, url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCharge>.MapCollectionFromJson(response);
		}

		public virtual StripeCharge Capture(string chargeId, int? captureAmount = null, int? applicationFee = null)
		{
			var url = string.Format("{0}/{1}/capture", Urls.Charges, chargeId);
			url = ApplyExpandableProperties(url);

			if (captureAmount.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", captureAmount.Value.ToString());
			if (applicationFee.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", applicationFee.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		private string ApplyExpandableProperties(string url)
		{
			if (ExpandCustomer)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "customer");
			if (ExpandInvoice)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "invoice");

			return url;
		}
	}
}
