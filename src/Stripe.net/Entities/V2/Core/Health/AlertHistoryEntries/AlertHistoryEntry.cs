// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An alert history entry representing a state transition of a health alert.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntry : StripeEntity<AlertHistoryEntry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the alert history entry.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Populated when type is api_error.
        /// </summary>
        [JsonProperty("api_error")]
        [STJS.JsonPropertyName("api_error")]
        public AlertHistoryEntryApiError ApiError { get; set; }

        /// <summary>
        /// Populated when type is api_latency.
        /// </summary>
        [JsonProperty("api_latency")]
        [STJS.JsonPropertyName("api_latency")]
        public AlertHistoryEntryApiLatency ApiLatency { get; set; }

        /// <summary>
        /// The time at which this transition occurred.
        /// </summary>
        [JsonProperty("at")]
        [STJS.JsonPropertyName("at")]
        public DateTime At { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Populated when type is authorization_rate_drop.
        /// </summary>
        [JsonProperty("authorization_rate_drop")]
        [STJS.JsonPropertyName("authorization_rate_drop")]
        public AlertHistoryEntryAuthorizationRateDrop AuthorizationRateDrop { get; set; }

        /// <summary>
        /// Populated when type is elements_error.
        /// </summary>
        [JsonProperty("elements_error")]
        [STJS.JsonPropertyName("elements_error")]
        public AlertHistoryEntryElementsError ElementsError { get; set; }

        /// <summary>
        /// Populated when type is event_generation_failure.
        /// </summary>
        [JsonProperty("event_generation_failure")]
        [STJS.JsonPropertyName("event_generation_failure")]
        public AlertHistoryEntryEventGenerationFailure EventGenerationFailure { get; set; }

        /// <summary>
        /// Populated when type is fraud_rate.
        /// </summary>
        [JsonProperty("fraud_rate")]
        [STJS.JsonPropertyName("fraud_rate")]
        public AlertHistoryEntryFraudRate FraudRate { get; set; }

        /// <summary>
        /// Populated when type is invoice_count_dropped.
        /// </summary>
        [JsonProperty("invoice_count_dropped")]
        [STJS.JsonPropertyName("invoice_count_dropped")]
        public AlertHistoryEntryInvoiceCountDropped InvoiceCountDropped { get; set; }

        /// <summary>
        /// Populated when type is issuing_authorization_request_errors.
        /// </summary>
        [JsonProperty("issuing_authorization_request_errors")]
        [STJS.JsonPropertyName("issuing_authorization_request_errors")]
        public AlertHistoryEntryIssuingAuthorizationRequestErrors IssuingAuthorizationRequestErrors { get; set; }

        /// <summary>
        /// Populated when type is issuing_authorization_request_timeout.
        /// </summary>
        [JsonProperty("issuing_authorization_request_timeout")]
        [STJS.JsonPropertyName("issuing_authorization_request_timeout")]
        public AlertHistoryEntryIssuingAuthorizationRequestTimeout IssuingAuthorizationRequestTimeout { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Populated when type is meter_event_summaries_delayed.
        /// </summary>
        [JsonProperty("meter_event_summaries_delayed")]
        [STJS.JsonPropertyName("meter_event_summaries_delayed")]
        public AlertHistoryEntryMeterEventSummariesDelayed MeterEventSummariesDelayed { get; set; }

        /// <summary>
        /// Populated when type is metronome_notification_latency.
        /// </summary>
        [JsonProperty("metronome_notification_latency")]
        [STJS.JsonPropertyName("metronome_notification_latency")]
        public AlertHistoryEntryMetronomeNotificationLatency MetronomeNotificationLatency { get; set; }

        /// <summary>
        /// Populated when type is payment_method_error.
        /// </summary>
        [JsonProperty("payment_method_error")]
        [STJS.JsonPropertyName("payment_method_error")]
        public AlertHistoryEntryPaymentMethodError PaymentMethodError { get; set; }

        /// <summary>
        /// Populated when type is sepa_debit_delayed.
        /// </summary>
        [JsonProperty("sepa_debit_delayed")]
        [STJS.JsonPropertyName("sepa_debit_delayed")]
        public AlertHistoryEntrySepaDebitDelayed SepaDebitDelayed { get; set; }

        /// <summary>
        /// Populated when type is traffic_volume_drop.
        /// </summary>
        [JsonProperty("traffic_volume_drop")]
        [STJS.JsonPropertyName("traffic_volume_drop")]
        public AlertHistoryEntryTrafficVolumeDrop TrafficVolumeDrop { get; set; }

        /// <summary>
        /// The type of transition that occurred.
        /// One of: <c>impact_updated</c>, <c>opened</c>, or <c>resolved</c>.
        /// </summary>
        [JsonProperty("transition")]
        [STJS.JsonPropertyName("transition")]
        public string Transition { get; set; }

        /// <summary>
        /// The type of the alert. Determines which sub-hash field is populated.
        /// One of: <c>api_error</c>, <c>api_latency</c>, <c>authorization_rate_drop</c>,
        /// <c>elements_error</c>, <c>event_generation_failure</c>, <c>fraud_rate</c>,
        /// <c>invoice_count_dropped</c>, <c>issuing_authorization_request_errors</c>,
        /// <c>issuing_authorization_request_timeout</c>, <c>meter_event_summaries_delayed</c>,
        /// <c>metronome_notification_latency</c>, <c>payment_method_error</c>,
        /// <c>sepa_debit_delayed</c>, <c>traffic_volume_drop</c>, or <c>webhook_latency</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Populated when type is webhook_latency.
        /// </summary>
        [JsonProperty("webhook_latency")]
        [STJS.JsonPropertyName("webhook_latency")]
        public AlertHistoryEntryWebhookLatency WebhookLatency { get; set; }
    }
}
