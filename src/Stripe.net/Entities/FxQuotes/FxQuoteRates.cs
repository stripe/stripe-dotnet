// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteRates : StripeEntity<FxQuoteRates>
    {
        /// <summary>
        /// The rate that includes the FX fee rate.
        /// </summary>
        [JsonProperty("exchange_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exchange_rate")]
#endif
        public decimal ExchangeRate { get; set; }

        [JsonProperty("rate_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_details")]
#endif
        public FxQuoteRatesRateDetails RateDetails { get; set; }
    }
}
