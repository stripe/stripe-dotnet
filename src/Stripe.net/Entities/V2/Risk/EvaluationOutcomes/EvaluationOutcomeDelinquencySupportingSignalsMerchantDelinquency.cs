// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencySupportingSignalsMerchantDelinquency : StripeEntity<EvaluationOutcomeDelinquencySupportingSignalsMerchantDelinquency>
    {
        /// <summary>
        /// Time the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Probability of delinquency, represented as a decimal string. Null when the risk level is
        /// unknown or the account signal does not include a numeric score.
        /// </summary>
        [JsonProperty("probability")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("probability")]
        public decimal? Probability { get; set; }

        /// <summary>
        /// Assessed risk level.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// ID of the supporting account signal.
        /// </summary>
        [JsonProperty("signal")]
        [STJS.JsonPropertyName("signal")]
        public string Signal { get; set; }
    }
}
