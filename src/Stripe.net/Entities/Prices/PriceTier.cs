// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceTier : StripeEntity<PriceTier>
    {
        /// <summary>
        /// Price for the entire tier.
        /// </summary>
        [JsonProperty("flat_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flat_amount")]
#endif
        public long? FlatAmount { get; set; }

        /// <summary>
        /// Same as <c>flat_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonProperty("flat_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flat_amount_decimal")]
#endif
        public decimal? FlatAmountDecimal { get; set; }

        /// <summary>
        /// Per unit price for units relevant to the tier.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }

        /// <summary>
        /// Up to and including to this quantity will be contained in the tier.
        /// </summary>
        [JsonProperty("up_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("up_to")]
#endif
        public long? UpTo { get; set; }
    }
}
