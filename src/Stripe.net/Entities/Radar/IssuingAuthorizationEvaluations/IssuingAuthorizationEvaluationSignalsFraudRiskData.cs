// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationSignalsFraudRiskData : StripeEntity<IssuingAuthorizationEvaluationSignalsFraudRiskData>
    {
        /// <summary>
        /// The time when this signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Risk level, based on the score.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("level")]
#endif
        public string Level { get; set; }

        /// <summary>
        /// Fraud risk score for this evaluation. Score in the range [0,100], formatted as a 2
        /// decimal float, with higher scores indicating a higher likelihood of fraud.
        /// </summary>
        [JsonProperty("score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("score")]
#endif
        public decimal Score { get; set; }
    }
}
