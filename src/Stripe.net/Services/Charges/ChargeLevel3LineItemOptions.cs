// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargeLevel3LineItemOptions : INestedOptions
    {
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif

        public long? DiscountAmount { get; set; }

        [JsonProperty("product_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_code")]
#endif

        public string ProductCode { get; set; }

        [JsonProperty("product_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
#endif

        public string ProductDescription { get; set; }

        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif

        public long? Quantity { get; set; }

        [JsonProperty("tax_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amount")]
#endif

        public long? TaxAmount { get; set; }

        [JsonProperty("unit_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_cost")]
#endif

        public long? UnitCost { get; set; }
    }
}
