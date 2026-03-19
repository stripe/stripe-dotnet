// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationEvent : StripeEntity<PaymentEvaluationEvent>
    {
        /// <summary>
        /// Dispute opened event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("dispute_opened")]
        [STJS.JsonPropertyName("dispute_opened")]
        public PaymentEvaluationEventDisputeOpened DisputeOpened { get; set; }

        /// <summary>
        /// Early Fraud Warning Received event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("early_fraud_warning_received")]
        [STJS.JsonPropertyName("early_fraud_warning_received")]
        public PaymentEvaluationEventEarlyFraudWarningReceived EarlyFraudWarningReceived { get; set; }

        /// <summary>
        /// Timestamp when the event occurred.
        /// </summary>
        [JsonProperty("occurred_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("occurred_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime OccurredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Refunded Event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("refunded")]
        [STJS.JsonPropertyName("refunded")]
        public PaymentEvaluationEventRefunded Refunded { get; set; }

        /// <summary>
        /// Indicates the type of event attached to the payment evaluation.
        /// One of: <c>dispute_opened</c>, <c>early_fraud_warning_received</c>, <c>refunded</c>,
        /// <c>user_intervention_raised</c>, or <c>user_intervention_resolved</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// User intervention raised event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("user_intervention_raised")]
        [STJS.JsonPropertyName("user_intervention_raised")]
        public PaymentEvaluationEventUserInterventionRaised UserInterventionRaised { get; set; }

        /// <summary>
        /// User Intervention Resolved Event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("user_intervention_resolved")]
        [STJS.JsonPropertyName("user_intervention_resolved")]
        public PaymentEvaluationEventUserInterventionResolved UserInterventionResolved { get; set; }
    }
}
