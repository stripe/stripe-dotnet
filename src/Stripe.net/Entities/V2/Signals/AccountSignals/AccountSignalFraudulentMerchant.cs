// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalFraudulentMerchant : StripeEntity<AccountSignalFraudulentMerchant>
    {
        /// <summary>
        /// Array of objects representing individual factors that contributed to the calculated
        /// probability. Absent when risk level is not_assessed or unknown, or when the user is not
        /// on a product tier that includes indicators.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<AccountSignalFraudulentMerchantIndicator> Indicators { get; set; }

        /// <summary>
        /// The probability of the merchant being fraudulent. Can be between 0.00 and 100.00. Absent
        /// when risk level is not_assessed or unknown, or when the user is not on a product tier
        /// that includes numeric scores.
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
