using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeDisputeService : BaseStripeService
	{
		public StripeDisputeService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeDispute> Update(string chargeId, string evidence = null)
		{
			var url = string.Format("{0}/dispute", chargeId);

			var data = new List<KeyValuePair<string,string>>{new KeyValuePair<string,string>("evidence", evidence)};

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeDispute>.MapFromJson(response);
		}
	}
}