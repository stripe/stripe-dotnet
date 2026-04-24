// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LicenseFeeVersionTier : StripeEntity<LicenseFeeVersionTier>
    {
        /// <summary>
        /// Price for the entire tier, represented as a decimal string in minor currency units with
        /// at most 12 decimal places.
        /// </summary>
        [JsonProperty("flat_amount")]
        [STJS.JsonPropertyName("flat_amount")]
        public string FlatAmount { get; set; }

        /// <summary>
        /// Per-unit price for units included in this tier, represented as a decimal string in minor
        /// currency units with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }

        /// <summary>
        /// Up to and including this quantity is contained in the tier. Only one of
        /// <c>up_to_decimal</c> and <c>up_to_inf</c> may be set.
        /// </summary>
        [JsonProperty("up_to_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("up_to_decimal")]
        public decimal? UpToDecimal { get; set; }

        /// <summary>
        /// No upper bound to this tier. Only one of <c>up_to_decimal</c> and <c>up_to_inf</c> may
        /// be set.
        /// </summary>
        [JsonProperty("up_to_inf")]
        [STJS.JsonPropertyName("up_to_inf")]
        public string UpToInf { get; set; }
    }
}
