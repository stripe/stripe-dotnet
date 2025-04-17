// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteRatesRateDetails : StripeEntity<FxQuoteRatesRateDetails>
    {
        /// <summary>
        /// The rate for the currency pair.
        /// </summary>
        [JsonProperty("base_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("base_rate")]
#endif
        public decimal BaseRate { get; set; }

        /// <summary>
        /// The fee for locking the conversion rates.
        /// </summary>
        [JsonProperty("duration_premium")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration_premium")]
#endif
        public decimal DurationPremium { get; set; }

        /// <summary>
        /// The FX fee for the currency pair.
        /// </summary>
        [JsonProperty("fx_fee_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_fee_rate")]
#endif
        public decimal FxFeeRate { get; set; }

        /// <summary>
        /// A reference rate for the currency pair provided by the reference rate provider.
        /// </summary>
        [JsonProperty("reference_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_rate")]
#endif
        public decimal? ReferenceRate { get; set; }

        /// <summary>
        /// The reference rate provider.
        /// </summary>
        [JsonProperty("reference_rate_provider")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_rate_provider")]
#endif
        public string ReferenceRateProvider { get; set; }
    }
}
