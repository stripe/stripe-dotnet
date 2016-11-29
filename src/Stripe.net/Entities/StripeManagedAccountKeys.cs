using Newtonsoft.Json;

namespace Stripe
{
    public class StripeManagedAccountKeys : StripeEntity
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("publishable")]
        public string Publishable { get; set; }
    }
}
