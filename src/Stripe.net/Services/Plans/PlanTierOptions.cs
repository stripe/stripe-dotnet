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
        /// The per unit billing amount for each individual unit for which this tier applies.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Specifies the upper bound of this tier. The lower bound of a tier is the upper bound of
        /// the previous tier adding one. Use <see cref="PlanTierUpTo.Inf"/> to define a fallback
        /// tier.
        /// </summary>
        [JsonProperty("up_to")]
        public AnyOf<long?, PlanTierUpTo?> UpTo { get; set; }
    }
}
