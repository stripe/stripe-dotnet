
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeShippingMethod
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("delivery_estimate")]
        public StripeDeliveryEstimate DeliveryEstimate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
