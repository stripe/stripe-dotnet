// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluationSignalsFraudRiskData : StripeEntity<IssuingAuthorizationEvaluationSignalsFraudRiskData>
    {
        /// <summary>
        /// The time when this signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Risk level, based on the score.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("level")]
        [STJS.JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// Fraud risk score for this evaluation. Score in the range [0,100], formatted as a 2
        /// decimal float, with higher scores indicating a higher likelihood of fraud.
        /// </summary>
        [JsonProperty("score")]
        [STJS.JsonPropertyName("score")]
        public decimal Score { get; set; }
    }
}
