// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationEvaluatedSignalsUserBuyerClassification : StripeEntity<AccountEvaluationEvaluatedSignalsUserBuyerClassification>
    {
        /// <summary>
        /// Predicted type of buyer behind the user.
        /// One of: <c>business</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("buyer_type")]
        [STJS.JsonPropertyName("buyer_type")]
        public string BuyerType { get; set; }

        /// <summary>
        /// The score for the predicted buyer type, between 0.00 and 100.00. Absent when buyer_type
        /// is unknown.
        /// </summary>
        [JsonProperty("buyer_type_score")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("buyer_type_score")]
        public decimal? BuyerTypeScore { get; set; }

        /// <summary>
        /// Timestamp at which the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime? EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The account signal ID containing the full user buyer classification signal result.
        /// </summary>
        [JsonProperty("signal")]
        [STJS.JsonPropertyName("signal")]
        public string Signal { get; set; }
    }
}
