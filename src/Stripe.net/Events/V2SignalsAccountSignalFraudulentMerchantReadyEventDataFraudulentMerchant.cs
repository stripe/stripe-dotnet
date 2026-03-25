// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2SignalsAccountSignalFraudulentMerchantReadyEventDataFraudulentMerchant : StripeEntity<V2SignalsAccountSignalFraudulentMerchantReadyEventDataFraudulentMerchant>
    {
        /// <summary>
        /// Array of objects representing individual factors that contributed to the calculated
        /// probability. Maximum of 3.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<V2SignalsAccountSignalFraudulentMerchantReadyEventDataFraudulentMerchantIndicator> Indicators { get; set; }

        /// <summary>
        /// The probability of the merchant being fraudulent. Can be between 0.00 and 100.00. May be
        /// empty if the risk_level is UNKNOWN or NOT_ASSESSED.
        /// </summary>
        [JsonProperty("probability")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("probability")]
        public decimal? Probability { get; set; }

        /// <summary>
        /// Categorical assessment of the fraudulent merchant risk based on probability.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }
    }
}
