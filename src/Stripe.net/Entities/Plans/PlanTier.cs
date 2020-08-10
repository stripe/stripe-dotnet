namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTier : StripeEntity<PlanTier>
    {
        [JsonProperty("flat_amount")]
        public long? FlatAmount { get; set; }

        [JsonProperty("flat_amount_decimal")]
        public decimal? FlatAmountDecimal { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }

        [JsonProperty("up_to")]
        public long? UpTo { get; set; }
    }
}
