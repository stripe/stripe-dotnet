// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreHealthTrafficVolumeDropResolvedEventDataImpact : StripeEntity<V2CoreHealthTrafficVolumeDropResolvedEventDataImpact>
    {
        /// <summary>
        /// The total volume of payment requests within the latest observation time window.
        /// </summary>
        [JsonProperty("actual_traffic")]
        [STJS.JsonPropertyName("actual_traffic")]
        public long ActualTraffic { get; set; }

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
