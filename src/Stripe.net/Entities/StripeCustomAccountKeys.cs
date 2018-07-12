using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCustomAccountKeys : StripeEntity
    {
        [JsonProperty("publishable")]
        public string Publishable { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
