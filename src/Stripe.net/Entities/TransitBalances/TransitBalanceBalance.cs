// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransitBalanceBalance : StripeEntity<TransitBalanceBalance>
    {
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public long Available { get; set; }

        [JsonProperty("pending")]
        [STJS.JsonPropertyName("pending")]
        public long Pending { get; set; }
    }
}
