// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A billing alert is a resource that notifies you when a certain usage threshold on a
    /// meter is crossed. For example, you might create a billing alert to notify you when a
    /// certain user made 100 API requests.
    /// </summary>
    public class Alert : StripeEntity<Alert>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Defines the type of the alert.
        /// </summary>
        [JsonProperty("alert_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert_type")]
#endif
        public string AlertType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Status of the alert. This can be active, inactive or archived.
        /// One of: <c>active</c>, <c>archived</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Title of the alert.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }

        /// <summary>
        /// Encapsulates configuration of the alert to monitor usage on a specific <a
        /// href="https://stripe.com/docs/api/billing/meter">Billing Meter</a>.
        /// </summary>
        [JsonProperty("usage_threshold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_threshold")]
#endif
        public AlertUsageThreshold UsageThreshold { get; set; }
    }
}
