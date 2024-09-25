// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Defines the type of the alert.
        /// </summary>
        [JsonProperty("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Status of the alert. This can be active, inactive or archived.
        /// One of: <c>active</c>, <c>archived</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Title of the alert.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Encapsulates configuration of the alert to monitor usage on a specific <a
        /// href="https://stripe.com/docs/api/billing/meter">Billing Meter</a>.
        /// </summary>
        [JsonProperty("usage_threshold")]
        public AlertUsageThreshold UsageThreshold { get; set; }
    }
}
