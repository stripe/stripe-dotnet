// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationEvaluatedSignalsUserAccountSharing : StripeEntity<AccountEvaluationEvaluatedSignalsUserAccountSharing>
    {
        /// <summary>
        /// Timestamp at which the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime? EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Categorical assessment of the account-sharing risk.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// The specific risk score for the account, between 0.00 and 100.00, when available.
        /// </summary>
        [JsonProperty("score")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("score")]
        public decimal? Score { get; set; }

        /// <summary>
        /// The account signal ID containing the full user account-sharing signal result.
        /// </summary>
        [JsonProperty("signal")]
        [STJS.JsonPropertyName("signal")]
        public string Signal { get; set; }
    }
}
