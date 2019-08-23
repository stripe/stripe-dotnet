namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTier : StripeEntity<PlanTier>
    {
        /// <summary>
        /// Price for the entire tier.
        /// </summary>
        [JsonProperty("flat_amount")]
        public long? FlatAmount { get; set; }

        /// <summary>
        /// Same as <see cref="FlatAmount"/>, but contains a decimal value with at most 12 decimal
        /// places.
        /// </summary>
        [JsonProperty("flat_amount_decimal")]
        public decimal? FlatAmountDecimal { get; set; }

        /// <summary>
        /// Per unit price for units relevant to the tier.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <see cref="UnitAmount"/>, but contains a decimal value with at most 12 decimal
        /// places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecinal { get; set; }

        /// <summary>
        /// Up to and including to this quantity will be contained in the tier.
        /// </summary>
        [JsonProperty("up_to")]
        public long? UpTo { get; set; }
    }
}
