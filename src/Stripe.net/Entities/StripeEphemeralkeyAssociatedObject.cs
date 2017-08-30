using Newtonsoft.Json;

namespace Stripe
{
    public class StripeEphemeralkeyAssociatedObject : StripeEntityWithId
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}