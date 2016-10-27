using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOAuthToken : StripeEntity
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }

        [JsonProperty("stripe_publishable_key")]
        public string StripePublishableKey { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
