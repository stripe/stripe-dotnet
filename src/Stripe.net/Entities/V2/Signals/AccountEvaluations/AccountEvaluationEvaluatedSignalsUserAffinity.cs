// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationEvaluatedSignalsUserAffinity : StripeEntity<AccountEvaluationEvaluatedSignalsUserAffinity>
    {
        /// <summary>
        /// Timestamp at which the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime? EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Categorical assessment of the user affinity.
        /// One of: <c>standard</c>, <c>strong</c>, <c>unknown</c>, or <c>very_strong</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("level")]
        [STJS.JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// The specific affinity score for the user, between 0.00 and 100.00. Absent when level is
        /// unknown.
        /// </summary>
        [JsonProperty("score")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("score")]
        public decimal? Score { get; set; }

        /// <summary>
        /// The account signal ID containing the full user affinity signal result.
        /// </summary>
        [JsonProperty("signal")]
        [STJS.JsonPropertyName("signal")]
        public string Signal { get; set; }
    }
}
