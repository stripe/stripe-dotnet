using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOAuthDeauthorize : StripeEntity
    {
        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
