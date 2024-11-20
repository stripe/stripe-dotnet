// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class LineItemAdjustableQuantity : StripeEntity<LineItemAdjustableQuantity>
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("maximum")]
        public long? Maximum { get; set; }

        [JsonProperty("minimum")]
        public long? Minimum { get; set; }
    }
}
