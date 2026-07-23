// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertNotification : StripeEntity<AlertNotification>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the alert was triggered or recovered.
        /// One of: <c>recovered</c>, or <c>triggered</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// End of the aggregation period for which this notification was sent. Only present for
        /// usage threshold alerts.
        /// </summary>
        [JsonProperty("aggregation_period_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("aggregation_period_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? AggregationPeriodEnd { get; set; }

        /// <summary>
        /// Start of the aggregation period for which this notification was sent. Only present for
        /// usage threshold alerts.
        /// </summary>
        [JsonProperty("aggregation_period_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("aggregation_period_start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? AggregationPeriodStart { get; set; }

        /// <summary>
        /// ID of the billing alert that generated this notification.
        /// </summary>
        [JsonProperty("alert")]
        [STJS.JsonPropertyName("alert")]
        public string Alert { get; set; }

        /// <summary>
        /// The type of billing alert that generated this notification.
        /// One of: <c>credit_balance_threshold</c>, <c>spend_threshold</c>, or
        /// <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
        [STJS.JsonPropertyName("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// The billing cadence associated with this notification. Only present for spend threshold
        /// alerts grouped by billing cadence.
        /// </summary>
        [JsonProperty("cadence")]
        [STJS.JsonPropertyName("cadence")]
        public string Cadence { get; set; }

        /// <summary>
        /// Three-letter ISO currency code for the value, in lowercase. Only present for spend and
        /// credit balance threshold alerts.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Custom pricing unit for the threshold value.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// ID of the customer for which the alert notification was sent.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// ID of the billing meter associated with this notification. Only present for usage
        /// threshold alerts.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// ID of the event delivered for this notification. Retrievable via the Events API for a
        /// limited time; for long-term audit scenarios, capture the full event payload at webhook
        /// delivery time.
        /// </summary>
        [JsonProperty("notification_event")]
        [STJS.JsonPropertyName("notification_event")]
        public string NotificationEvent { get; set; }

        /// <summary>
        /// Time at which the notification was sent. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("notified_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("notified_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime NotifiedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// ID of the subscription associated with this notification. Only present for spend
        /// threshold alerts grouped by subscription.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The value that triggered the alert. This may be a decimal string for custom pricing unit
        /// alerts. For usage threshold alerts, this is the meter event count. For credit balance
        /// and spend threshold alerts, this is the amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
