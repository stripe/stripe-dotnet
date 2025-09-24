// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LicenseFeeUpdateTierOptions : INestedOptions
    {
        /// <summary>
        /// Price for the entire tier, represented as a decimal string in minor currency units with
        /// at most 12 decimal places.
        /// </summary>
        [JsonProperty("flat_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flat_amount")]
#endif
        public string FlatAmount { get; set; }

        /// <summary>
        /// Per-unit price for units included in this tier, represented as a decimal string in minor
        /// currency units with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public string UnitAmount { get; set; }

        /// <summary>
        /// Up to and including this quantity will be contained in the tier. Only one of
        /// <c>up_to_decimal</c> and <c>up_to_inf</c> may be set.
        /// </summary>
        [JsonProperty("up_to_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("up_to_decimal")]
#endif
        public string UpToDecimal { get; set; }

        /// <summary>
        /// No upper bound to this tier. Only one of <c>up_to_decimal</c> and <c>up_to_inf</c> may
        /// be set.
        /// </summary>
        [JsonProperty("up_to_inf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("up_to_inf")]
#endif
        public string UpToInf { get; set; }
    }
}
