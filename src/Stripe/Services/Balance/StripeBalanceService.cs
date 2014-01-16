using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeBalanceService : BaseStripeService
	{
        public StripeBalanceService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeBalance> Get()
		{
			var response = await Requestor.GetStringAsync(Urls.Balance, ApiKey);
			
			return Mapper<StripeBalance>.MapFromJson(response);
		}
	}
}
