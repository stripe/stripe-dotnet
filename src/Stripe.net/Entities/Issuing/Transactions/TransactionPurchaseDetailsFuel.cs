namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFuel : StripeEntity<TransactionPurchaseDetailsFuel>
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unit_cost_decimal")]
        public decimal UnitCostDecimal { get; set; }

        [JsonProperty("volume_decimal")]
        public decimal? VolumeDecimal { get; set; }
    }
}
