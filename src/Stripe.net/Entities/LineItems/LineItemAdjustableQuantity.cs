// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LineItemAdjustableQuantity : StripeEntity<LineItemAdjustableQuantity>
    {
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
