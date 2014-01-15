using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeChargeService : BaseStripeService
	{
		public StripeChargeService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeCharge> Create(StripeChargeCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.Charges, data, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual async Task<StripeCharge> Get(string chargeId)
		{
			var url = string.Format("{0}/{1}", Urls.Charges, chargeId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual async Task<StripeCharge> Refund(string chargeId, int? refundAmountInCents = null, bool? refundApplicationFee = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);
		    var data = new List<KeyValuePair<string, string>>();

			if (refundAmountInCents.HasValue)
				data.Add(new KeyValuePair<string, string>("amount", refundAmountInCents.GetValueOrDefault().ToString()));
			if(refundApplicationFee.HasValue)
				data.Add(new KeyValuePair<string, string>("refund_application_fee", refundApplicationFee.GetValueOrDefault().ToString()));

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}

		public virtual async Task<List<StripeCharge>> List(int count = 10, int offset = 0, string customerId = null)
		{
			var url = Urls.Charges;
		    var data = new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    };
            if (!string.IsNullOrEmpty(customerId))
				data.Add(new KeyValuePair<string, string>("customer", customerId));

		    url = ParameterBuilder.ApplyDataToUrl(url, data);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCharge>.MapCollectionFromJson(response);
		}

		public virtual async Task<StripeCharge> Capture(string chargeId, int? captureAmountInCents = null, int? applicationFeeInCents = null)
		{
			var url = string.Format("{0}/{1}/capture", Urls.Charges, chargeId);
		    var data = new List<KeyValuePair<string, string>>();

			if (captureAmountInCents.HasValue)
				data.Add(new KeyValuePair<string, string>("amount", captureAmountInCents.Value.ToString()));
			if (applicationFeeInCents.HasValue)
				data.Add(new KeyValuePair<string, string>("application_fee", applicationFeeInCents.Value.ToString()));

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeCharge>.MapFromJson(response);
		}
	}
}
