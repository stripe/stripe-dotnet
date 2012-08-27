using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

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

		public virtual StripeCharge Refund(string chargeId, int? refundAmountInCents = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);

			if (refundAmountInCents.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmountInCents.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeCharge> List(int count = 10, int offset = 0, string customerId = null)
		{
			var url = Urls.Charges;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			if (!string.IsNullOrEmpty(customerId))
				url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCharge>.MapCollectionFromJson(response);
		}
	}
}