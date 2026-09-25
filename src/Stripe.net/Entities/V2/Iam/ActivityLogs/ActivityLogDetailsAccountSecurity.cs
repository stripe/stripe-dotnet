// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsAccountSecurity : StripeEntity<ActivityLogDetailsAccountSecurity>
    {
        /// <summary>
        /// Anomaly detection settings after the change.
        /// </summary>
        [JsonProperty("new_anomaly_settings")]
        [STJS.JsonPropertyName("new_anomaly_settings")]
        public ActivityLogDetailsAccountSecurityNewAnomalySettings NewAnomalySettings { get; set; }

        /// <summary>
        /// Anomaly detection settings before the change.
        /// </summary>
        [JsonProperty("old_anomaly_settings")]
        [STJS.JsonPropertyName("old_anomaly_settings")]
        public ActivityLogDetailsAccountSecurityOldAnomalySettings OldAnomalySettings { get; set; }
    }
}
