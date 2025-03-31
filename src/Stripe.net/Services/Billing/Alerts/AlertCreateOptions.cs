// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreateOptions : BaseOptions
    {
        /// <summary>
        /// The type of alert to create.
        /// </summary>
        [JsonProperty("alert_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert_type")]
#endif
        public string AlertType { get; set; }

        /// <summary>
        /// The title of the alert.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }

        /// <summary>
        /// The configuration of the usage threshold.
        /// </summary>
        [JsonProperty("usage_threshold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_threshold")]
#endif
        public AlertUsageThresholdOptions UsageThreshold { get; set; }
    }
}
