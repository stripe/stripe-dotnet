using Newtonsoft.Json;

namespace Stripe
{
	public class StripeOAuthTokenCreateOptions
	{
		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }

		[JsonProperty("grant_type")]
		public string GrantType { get; set; }
	}
}
