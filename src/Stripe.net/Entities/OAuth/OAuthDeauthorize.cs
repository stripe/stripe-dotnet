namespace Stripe
{
    using Newtonsoft.Json;

    public class OAuthDeauthorize : StripeEntity<OAuthDeauthorize>
    {
        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
