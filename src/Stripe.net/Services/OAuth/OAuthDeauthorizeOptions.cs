namespace Stripe
{
    using Newtonsoft.Json;

    public class OAuthDeauthorizeOptions : BaseOptions
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }
    }
}
