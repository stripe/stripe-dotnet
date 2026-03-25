// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A billing alert is a resource that notifies you when a certain usage threshold on a
    /// meter is crossed. For example, you might create a billing alert to notify you when a
    /// certain user made 100 API requests.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Alert : StripeEntity<Alert>, IHasId, IHasObject
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
        /// Defines the type of the alert.
        /// One of: <c>credit_balance_threshold</c>, <c>spend_threshold</c>, or
        /// <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
        [STJS.JsonPropertyName("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// Encapsulates configuration of the alert to monitor billing credit balance.
        /// </summary>
        [JsonProperty("credit_balance_threshold")]
        [STJS.JsonPropertyName("credit_balance_threshold")]
        public AlertCreditBalanceThreshold CreditBalanceThreshold { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Encapsulates the alert's configuration to monitor spend on pricing plan subscriptions.
        /// </summary>
        [JsonProperty("spend_threshold")]
        [STJS.JsonPropertyName("spend_threshold")]
        public AlertSpendThreshold SpendThreshold { get; set; }

        /// <summary>
        /// Status of the alert. This can be active, inactive or archived.
        /// One of: <c>active</c>, <c>archived</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Title of the alert.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Encapsulates configuration of the alert to monitor usage on a specific <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a>.
        /// </summary>
        [JsonProperty("usage_threshold")]
        [STJS.JsonPropertyName("usage_threshold")]
        public AlertUsageThreshold UsageThreshold { get; set; }
    }
}
