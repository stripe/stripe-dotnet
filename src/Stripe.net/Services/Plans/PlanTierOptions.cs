namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTierOptions : INestedOptions
    {
        /// <summary>
        /// The flat billing amount for an entire tier, regardless of the number of units in the
        /// tier.
        /// </summary>
        [JsonProperty("flat_amount")]
        public long? FlatAmount { get; set; }

        /// <summary>
        /// Same as flat_amount, but accepts a decimal value representing an integer in the minor
        /// units of the currency. Only one of flat_amount and flat_amount_decimal can be set.
        /// </summary>
        [JsonProperty("flat_amount_decimal")]
        public decimal? FlatAmountDecimal { get; set; }

        /// <summary>
        /// The per unit billing amount for each individual unit for which this tier applies.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as unit_amount, but accepts a decimal value with at most 12 decimal places.
        /// Only one of unit_amount and unit_amount_decimal can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }

        /// <summary>
        /// Specifies the upper bound of this tier. The lower bound of a tier is the upper bound of
        /// the previous tier adding one. Use <see cref="PlanTierUpTo.Inf"/> to define a fallback
        /// tier.
        /// </summary>
        [JsonProperty("up_to")]
        public AnyOf<long?, PlanTierUpTo?> UpTo { get; set; }
    }
}
