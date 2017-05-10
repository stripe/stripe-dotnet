using Newtonsoft.Json;

namespace Stripe
{
    public class StripeApplication : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
     }
}
