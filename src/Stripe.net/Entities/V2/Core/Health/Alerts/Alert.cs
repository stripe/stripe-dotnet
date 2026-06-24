// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A health alert represents a detected problem affecting a merchant's Stripe integration.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Alert : StripeEntity<Alert>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the health alert.
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
        public AlertApiError ApiError { get; set; }

        /// <summary>
        /// Populated when type is api_latency.
        /// </summary>
        [JsonProperty("api_latency")]
        [STJS.JsonPropertyName("api_latency")]
        public AlertApiLatency ApiLatency { get; set; }

        /// <summary>
        /// Populated when type is authorization_rate_drop.
        /// </summary>
        [JsonProperty("authorization_rate_drop")]
        [STJS.JsonPropertyName("authorization_rate_drop")]
        public AlertAuthorizationRateDrop AuthorizationRateDrop { get; set; }

        /// <summary>
        /// Time at which the health alert was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Links to relevant documentation for diagnosing and resolving the alert.
        /// </summary>
        [JsonProperty("documentation_links")]
        [STJS.JsonPropertyName("documentation_links")]
        public List<AlertDocumentationLink> DocumentationLinks { get; set; }

        /// <summary>
        /// Populated when type is elements_error.
        /// </summary>
        [JsonProperty("elements_error")]
        [STJS.JsonPropertyName("elements_error")]
        public AlertElementsError ElementsError { get; set; }

        /// <summary>
        /// Populated when type is event_generation_failure.
        /// </summary>
        [JsonProperty("event_generation_failure")]
        [STJS.JsonPropertyName("event_generation_failure")]
        public AlertEventGenerationFailure EventGenerationFailure { get; set; }

        /// <summary>
        /// Populated when type is fraud_rate.
        /// </summary>
        [JsonProperty("fraud_rate")]
        [STJS.JsonPropertyName("fraud_rate")]
        public AlertFraudRate FraudRate { get; set; }

        /// <summary>
        /// The grouping key for the alert.
        /// </summary>
        [JsonProperty("grouping_key")]
        [STJS.JsonPropertyName("grouping_key")]
        public string GroupingKey { get; set; }

        /// <summary>
        /// Whether the alert is linked to an incident or is a self-contained problem.
        /// One of: <c>incident</c>, or <c>standalone</c>.
        /// </summary>
        [JsonProperty("grouping_type")]
        [STJS.JsonPropertyName("grouping_type")]
        public string GroupingType { get; set; }

        /// <summary>
        /// Populated when type is invoice_count_dropped.
        /// </summary>
        [JsonProperty("invoice_count_dropped")]
        [STJS.JsonPropertyName("invoice_count_dropped")]
        public AlertInvoiceCountDropped InvoiceCountDropped { get; set; }

        /// <summary>
        /// Populated when type is issuing_authorization_request_errors.
        /// </summary>
        [JsonProperty("issuing_authorization_request_errors")]
        [STJS.JsonPropertyName("issuing_authorization_request_errors")]
        public AlertIssuingAuthorizationRequestErrors IssuingAuthorizationRequestErrors { get; set; }

        /// <summary>
        /// Populated when type is issuing_authorization_request_timeout.
        /// </summary>
        [JsonProperty("issuing_authorization_request_timeout")]
        [STJS.JsonPropertyName("issuing_authorization_request_timeout")]
        public AlertIssuingAuthorizationRequestTimeout IssuingAuthorizationRequestTimeout { get; set; }

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
        public AlertMeterEventSummariesDelayed MeterEventSummariesDelayed { get; set; }

        /// <summary>
        /// Populated when type is metronome_notification_latency.
        /// </summary>
        [JsonProperty("metronome_notification_latency")]
        [STJS.JsonPropertyName("metronome_notification_latency")]
        public AlertMetronomeNotificationLatency MetronomeNotificationLatency { get; set; }

        /// <summary>
        /// Populated when type is payment_method_error.
        /// </summary>
        [JsonProperty("payment_method_error")]
        [STJS.JsonPropertyName("payment_method_error")]
        public AlertPaymentMethodError PaymentMethodError { get; set; }

        /// <summary>
        /// The time when the user experience has returned to expected levels. Null if the alert is
        /// still open.
        /// </summary>
        [JsonProperty("resolved_at")]
        [STJS.JsonPropertyName("resolved_at")]
        public DateTime? ResolvedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Populated when type is sepa_debit_delayed.
        /// </summary>
        [JsonProperty("sepa_debit_delayed")]
        [STJS.JsonPropertyName("sepa_debit_delayed")]
        public AlertSepaDebitDelayed SepaDebitDelayed { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// One of: <c>critical</c>, or <c>non_critical</c>.
        /// </summary>
        [JsonProperty("severity")]
        [STJS.JsonPropertyName("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// The time when impact on the user experience was first detected.
        /// </summary>
        [JsonProperty("started_at")]
        [STJS.JsonPropertyName("started_at")]
        public DateTime StartedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The current status of the alert.
        /// One of: <c>open</c>, or <c>resolved</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// A short description of the alert.
        /// </summary>
        [JsonProperty("summary")]
        [STJS.JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Populated when type is traffic_volume_drop.
        /// </summary>
        [JsonProperty("traffic_volume_drop")]
        [STJS.JsonPropertyName("traffic_volume_drop")]
        public AlertTrafficVolumeDrop TrafficVolumeDrop { get; set; }

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
        public AlertWebhookLatency WebhookLatency { get; set; }
    }
}
