namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeLevel3LineItem : StripeEntity<ChargeLevel3LineItem>
    {
        [JsonProperty("discount_amount")]
        public long? DiscountAmount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_amount")]
        public long? TaxAmount { get; set; }

        [JsonProperty("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
