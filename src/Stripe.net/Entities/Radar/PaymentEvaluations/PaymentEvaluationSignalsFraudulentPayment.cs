// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationSignalsFraudulentPayment : StripeEntity<PaymentEvaluationSignalsFraudulentPayment>
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
        /// Risk level of this signal, based on the score.
        /// One of: <c>elevated</c>, <c>highest</c>, or <c>normal</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Score for this insight. Possible values for evaluated payments are -1 and any value
        /// between 0 and 100. The value is returned with two decimal places. A score of -1
        /// indicates a test integration and higher scores indicate a higher likelihood of the
        /// signal being true.
        /// </summary>
        [JsonProperty("score")]
        [STJS.JsonPropertyName("score")]
        public decimal Score { get; set; }
    }
}
