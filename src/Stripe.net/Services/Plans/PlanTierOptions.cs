namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PlanTierOptions : INestedOptions
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
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<long?, PlanTierUpTo> UpTo { get; set; }
    }
}
