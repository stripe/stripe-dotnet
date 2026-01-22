// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationEvent : StripeEntity<PaymentEvaluationEvent>
    {
        /// <summary>
        /// Dispute opened event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("dispute_opened")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute_opened")]
#endif
        public PaymentEvaluationEventDisputeOpened DisputeOpened { get; set; }

        /// <summary>
        /// Early Fraud Warning Received event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("early_fraud_warning_received")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("early_fraud_warning_received")]
#endif
        public PaymentEvaluationEventEarlyFraudWarningReceived EarlyFraudWarningReceived { get; set; }

        /// <summary>
        /// Timestamp when the event occurred.
        /// </summary>
        [JsonProperty("occurred_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("occurred_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime OccurredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Refunded Event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunded")]
#endif
        public PaymentEvaluationEventRefunded Refunded { get; set; }

        /// <summary>
        /// Indicates the type of event attached to the payment evaluation.
        /// One of: <c>dispute_opened</c>, <c>early_fraud_warning_received</c>, <c>refunded</c>,
        /// <c>user_intervention_raised</c>, or <c>user_intervention_resolved</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// User intervention raised event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("user_intervention_raised")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_intervention_raised")]
#endif
        public PaymentEvaluationEventUserInterventionRaised UserInterventionRaised { get; set; }

        /// <summary>
        /// User Intervention Resolved Event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("user_intervention_resolved")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_intervention_resolved")]
#endif
        public PaymentEvaluationEventUserInterventionResolved UserInterventionResolved { get; set; }
    }
}
