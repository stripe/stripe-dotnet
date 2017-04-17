using Newtonsoft.Json;

namespace Stripe
{
    public class StripeShipping : StripeEntity
    {
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}