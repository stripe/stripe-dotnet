using Newtonsoft.Json;

namespace Stripe
{
    public class StripeEphemeralKeyAssociatedObject : StripeEntityWithId
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}