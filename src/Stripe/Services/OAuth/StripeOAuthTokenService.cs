﻿namespace Stripe
{
	public class StripeOAuthTokenService : StripeService
	{
		public StripeOAuthTokenService(string apiKey = null)
			: base(apiKey) { }

		public virtual StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.OAuthToken);

			var response = Requestor.PostStringBearer(url, ApiKey);

			return Mapper<StripeOAuthToken>.MapFromJson(response);
		}
	}
}
