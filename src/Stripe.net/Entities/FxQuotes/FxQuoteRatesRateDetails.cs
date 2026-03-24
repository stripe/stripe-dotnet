// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FxQuoteRatesRateDetails : StripeEntity<FxQuoteRatesRateDetails>
    {
        /// <summary>
        /// The rate for the currency pair.
        /// </summary>
        [JsonProperty("base_rate")]
        [STJS.JsonPropertyName("base_rate")]
        public decimal BaseRate { get; set; }

        /// <summary>
        /// The fee for locking the conversion rates.
        /// </summary>
        [JsonProperty("duration_premium")]
        [STJS.JsonPropertyName("duration_premium")]
        public decimal DurationPremium { get; set; }

        /// <summary>
        /// The FX fee for the currency pair.
        /// </summary>
        [JsonProperty("fx_fee_rate")]
        [STJS.JsonPropertyName("fx_fee_rate")]
        public decimal FxFeeRate { get; set; }

        /// <summary>
        /// A reference rate for the currency pair provided by the reference rate provider.
        /// </summary>
        [JsonProperty("reference_rate")]
        [STJS.JsonPropertyName("reference_rate")]
        public decimal? ReferenceRate { get; set; }

        /// <summary>
        /// The reference rate provider.
        /// </summary>
        [JsonProperty("reference_rate_provider")]
        [STJS.JsonPropertyName("reference_rate_provider")]
        public string ReferenceRateProvider { get; set; }
    }
}
