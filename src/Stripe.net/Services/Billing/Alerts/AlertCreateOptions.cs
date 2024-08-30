// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertCreateOptions : BaseOptions
    {
        /// <summary>
        /// The type of alert to create.
        /// One of: <c>spend_threshold</c>, or <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// Filters to limit the scope of an alert.
        /// </summary>
        [JsonProperty("filter")]
        public AlertFilterOptions Filter { get; set; }

        /// <summary>
        /// The configuration of the spend threshold.
        /// </summary>
        [JsonProperty("spend_threshold_config")]
        public AlertSpendThresholdConfigOptions SpendThresholdConfig { get; set; }

        /// <summary>
        /// The title of the alert.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The configuration of the usage threshold.
        /// </summary>
        [JsonProperty("usage_threshold_config")]
        public AlertUsageThresholdConfigOptions UsageThresholdConfig { get; set; }
    }
}
