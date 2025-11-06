// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransitBalanceBalance : StripeEntity<TransitBalanceBalance>
    {
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public long Available { get; set; }

        [JsonProperty("pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending")]
#endif
        public long Pending { get; set; }
    }
}
