namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeLevel3LineItemOptions : INestedOptions
    {
        [JsonProperty("discount_amount")]
        public int? DiscountAmount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("tax_amount")]
        public int? TaxAmount { get; set; }

        [JsonProperty("unit_cost")]
        public int? UnitCost { get; set; }
    }
}
