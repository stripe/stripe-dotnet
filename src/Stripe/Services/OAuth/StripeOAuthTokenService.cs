using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeOAuthTokenService : IStripeOAuthTokenService
	{
		private string ApiKey { get; set; }

		public StripeOAuthTokenService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.OAuthToken);

			var response = Requestor.PostStringBearer(url, ApiKey);

			return Mapper<StripeOAuthToken>.MapFromJson(response);
		}
	}
}
