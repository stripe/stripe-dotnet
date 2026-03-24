// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FxQuoteRates : StripeEntity<FxQuoteRates>
    {
        /// <summary>
        /// The rate that includes the FX fee rate.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public decimal ExchangeRate { get; set; }

        [JsonProperty("rate_details")]
        [STJS.JsonPropertyName("rate_details")]
        public FxQuoteRatesRateDetails RateDetails { get; set; }
    }
}
