namespace Stripe
{
	public class StripeOAuthTokenService
	{
		private string ApiKey { get; set; }

		public StripeOAuthTokenService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeOAuthToken> Create(StripeOAuthTokenCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.OAuthToken);

		    return url.PostBearerResponse<StripeOAuthToken>(ApiKey);
		}
	}
}
