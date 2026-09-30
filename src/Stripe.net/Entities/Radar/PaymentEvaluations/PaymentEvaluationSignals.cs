// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationSignals : StripeEntity<PaymentEvaluationSignals>
    {
        /// <summary>
        /// The likelihood that this <c>PaymentEvaluation</c> results in an early fraud warning.
        /// </summary>
        [JsonProperty("early_fraud_warning")]
        [STJS.JsonPropertyName("early_fraud_warning")]
        public PaymentEvaluationSignalsEarlyFraudWarning EarlyFraudWarning { get; set; }

        /// <summary>
        /// The likelihood that this <c>PaymentEvaluation</c> results in a dispute with reason code
        /// <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("fraudulent_dispute")]
        [STJS.JsonPropertyName("fraudulent_dispute")]
        public PaymentEvaluationSignalsFraudulentDispute FraudulentDispute { get; set; }

        /// <summary>
        /// A payment evaluation signal with evaluated_at, risk_level, and score fields.
        /// </summary>
        [JsonProperty("fraudulent_payment")]
        [STJS.JsonPropertyName("fraudulent_payment")]
        public PaymentEvaluationSignalsFraudulentPayment FraudulentPayment { get; set; }
    }
}
