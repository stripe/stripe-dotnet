// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertNotificationListOptions : ListOptions
    {
        /// <summary>
        /// Filter results to only include triggered or recovered notifications.
        /// One of: <c>recovered</c>, or <c>triggered</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Filter results to only include notifications for the given billing cadence.
        /// </summary>
        [JsonProperty("cadence")]
        [STJS.JsonPropertyName("cadence")]
        public string Cadence { get; set; }

        /// <summary>
        /// The customer to list notifications for.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Filter results to only include notifications for the given meter.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Filter results according to when the notification was sent.
        /// </summary>
        [JsonProperty("notified_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("notified_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> NotifiedAt { get; set; }

        /// <summary>
        /// Filter results to only include notifications for the given subscription.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
