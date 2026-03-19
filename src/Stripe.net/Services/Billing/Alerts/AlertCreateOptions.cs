// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertCreateOptions : BaseOptions
    {
        /// <summary>
        /// The type of alert to create.
        /// </summary>
        [JsonProperty("alert_type")]
        [STJS.JsonPropertyName("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// The title of the alert.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The configuration of the usage threshold.
        /// </summary>
        [JsonProperty("usage_threshold")]
        [STJS.JsonPropertyName("usage_threshold")]
        public AlertUsageThresholdOptions UsageThreshold { get; set; }
    }
}
