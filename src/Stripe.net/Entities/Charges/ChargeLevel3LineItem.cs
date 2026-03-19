namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class ChargeLevel3LineItem : StripeEntity<ChargeLevel3LineItem>
    {
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long? DiscountAmount { get; set; }

        [JsonProperty("product_code")]
        [STJS.JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("product_description")]
        [STJS.JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_amount")]
        [STJS.JsonPropertyName("tax_amount")]
        public long? TaxAmount { get; set; }

        [JsonProperty("unit_cost")]
        [STJS.JsonPropertyName("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
