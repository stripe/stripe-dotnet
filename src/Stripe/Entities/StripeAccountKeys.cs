using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountKeys : StripeObject
    {
        [JsonProperty("secret")]
        public string SecretKey { get; set; }

        [JsonProperty("publishable")]
        public string PublishableKey { get; set; }
    }
}
