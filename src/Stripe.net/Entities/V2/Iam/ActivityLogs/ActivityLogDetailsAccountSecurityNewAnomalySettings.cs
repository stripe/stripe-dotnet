// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsAccountSecurityNewAnomalySettings : StripeEntity<ActivityLogDetailsAccountSecurityNewAnomalySettings>
    {
        /// <summary>
        /// Whether dormant API key protection is enabled.
        /// </summary>
        [JsonProperty("dormant_api_key_protection_enabled")]
        [STJS.JsonPropertyName("dormant_api_key_protection_enabled")]
        public bool? DormantApiKeyProtectionEnabled { get; set; }

        /// <summary>
        /// Whether money movement anomaly detection is enabled.
        /// </summary>
        [JsonProperty("money_movement_anomaly_detection_enabled")]
        [STJS.JsonPropertyName("money_movement_anomaly_detection_enabled")]
        public bool? MoneyMovementAnomalyDetectionEnabled { get; set; }

        /// <summary>
        /// Whether request-level anomaly detection is enabled.
        /// </summary>
        [JsonProperty("request_level_anomaly_detection_enabled")]
        [STJS.JsonPropertyName("request_level_anomaly_detection_enabled")]
        public bool? RequestLevelAnomalyDetectionEnabled { get; set; }
    }
}
