using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOAuthTokenCreateOptions : StripeBaseOptions
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
