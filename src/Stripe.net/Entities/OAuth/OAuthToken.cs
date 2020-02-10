namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class OAuthToken : StripeEntity<OAuthToken>
    {
        [Obsolete("Use StripeUserId instead.")]
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [Obsolete("Use StripeUserId instead.")]
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [Obsolete("Use StripeUserId instead.")]
        [JsonProperty("stripe_publishable_key")]
        public string StripePublishableKey { get; set; }

        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
