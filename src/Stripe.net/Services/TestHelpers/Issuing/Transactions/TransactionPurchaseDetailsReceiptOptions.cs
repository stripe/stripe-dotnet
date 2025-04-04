// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetailsReceiptOptions : INestedOptions
    {
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public decimal? Quantity { get; set; }

        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public long? Total { get; set; }

        [JsonProperty("unit_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_cost")]
#endif
        public long? UnitCost { get; set; }
    }
}
