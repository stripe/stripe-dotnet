using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeApplicationFeeService : BaseStripeService
	{
		public StripeApplicationFeeService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeApplicationFee> Get(string applicationFeeId)
		{
			var url = string.Format("{0}/{1}", Urls.ApplicationFees, applicationFeeId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeApplicationFee>.MapFromJson(response);
		}

		public virtual async Task<StripeApplicationFee> Refund(string applicationFeeId, int? refundAmountInCents = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.ApplicationFees, applicationFeeId);

		    var data = new List<KeyValuePair<string, string>>();
		    if (refundAmountInCents.HasValue)
		    {
		        data.Add(new KeyValuePair<string, string>("amount", refundAmountInCents.GetValueOrDefault().ToString()));
		    }

		    var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeApplicationFee>.MapFromJson(response);
		}
	}
}