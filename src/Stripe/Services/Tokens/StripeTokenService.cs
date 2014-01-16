using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeTokenService : BaseStripeService
	{
		public StripeTokenService(string apiKey = null)
		{
		}

		public virtual async Task<StripeToken> Create(StripeTokenCreateOptions createOptions)
		{
            var data = ParameterBuilder.GenerateFormData(createOptions);
            var response = await Requestor.PostStringAsync(Urls.Tokens, data, ApiKey);

			return Mapper<StripeToken>.MapFromJson(response);
		}

		public virtual async Task<StripeToken> Get(string tokenId)
		{
			var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeToken>.MapFromJson(response);
		}
	}
}