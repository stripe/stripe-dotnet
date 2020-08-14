namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceTierOptions : INestedOptions
    {
        /// <summary>
        /// The flat billing amount for an entire tier, regardless of the number of units in the
        /// tier.
        /// </summary>
        [JsonProperty("flat_amount")]
        public long? FlatAmount { get; set; }

        /// <summary>
        /// Same as <c>flat_amount</c>, but accepts a decimal value representing an integer in the
        /// minor units of the currency. Only one of <c>flat_amount</c> and
        /// <c>flat_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("flat_amount_decimal")]
        public decimal? FlatAmountDecimal { get; set; }

        /// <summary>
        /// The per unit billing amount for each individual unit for which this tier applies.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value with at most 12 decimal places.
        /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }

        /// <summary>
        /// Specifies the upper bound of this tier. The lower bound of a tier is the upper bound of
        /// the previous tier adding one. Use <c>inf</c> to define a fallback tier.
        /// </summary>
        [JsonProperty("up_to")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<long?, PriceTierUpTo> UpTo { get; set; }
    }
}
