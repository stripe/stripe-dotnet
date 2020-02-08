namespace Stripe
{
    using Newtonsoft.Json;

    public class OAuthDeauthorize : StripeEntity<OAuthDeauthorize>
    {
        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }
    }
}
