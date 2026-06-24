// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertTrafficVolumeDrop : StripeEntity<AlertTrafficVolumeDrop>
    {
        /// <summary>
        /// The total volume of payment requests within the latest observation time window.
        /// </summary>
        [JsonProperty("actual_traffic")]
        [STJS.JsonPropertyName("actual_traffic")]
        public long ActualTraffic { get; set; }

        /// <summary>
        /// The canonical path.
        /// </summary>
        [JsonProperty("canonical_path")]
        [STJS.JsonPropertyName("canonical_path")]
        public string CanonicalPath { get; set; }

        /// <summary>
        /// The expected volume of payment requests within the latest observation time window.
        /// </summary>
        [JsonProperty("expected_traffic")]
        [STJS.JsonPropertyName("expected_traffic")]
        public long? ExpectedTraffic { get; set; }

        /// <summary>
        /// The size of the observation time window.
        /// </summary>
        [JsonProperty("time_window")]
        [STJS.JsonPropertyName("time_window")]
        public string TimeWindow { get; set; }
    }
}
