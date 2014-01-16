using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeAccountService : BaseStripeService
	{
        public StripeAccountService(string apiKey = null):base(apiKey)
		{
		}

		public virtual async Task<StripeAccount> Get()
		{
			var response = await Requestor.GetStringAsync(Urls.Account, ApiKey);

			return Mapper<StripeAccount>.MapFromJson(response);
		}
	}
}