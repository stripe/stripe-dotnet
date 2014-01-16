using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeOAuthTokenService : BaseStripeService
	{
		public StripeOAuthTokenService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeOAuthToken> Create(StripeOAuthTokenCreateOptions createOptions)
		{
            var data = ParameterBuilder.GenerateFormData(createOptions);
			var response = await Requestor.PostStringBearerAsync(Urls.OAuthToken, data, ApiKey);

			return Mapper<StripeOAuthToken>.MapFromJson(response);
		}
	}
}
