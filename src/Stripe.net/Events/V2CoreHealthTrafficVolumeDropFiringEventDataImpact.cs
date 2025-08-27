// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthTrafficVolumeDropFiringEventDataImpact : StripeEntity<V2CoreHealthTrafficVolumeDropFiringEventDataImpact>
    {
        /// <summary>
        /// The total volume of payment requests within the latest observation time window.
        /// </summary>
        [JsonProperty("actual_traffic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("actual_traffic")]
#endif
        public long ActualTraffic { get; set; }

        /// <summary>
        /// The expected volume of payment requests within the latest observation time window.
        /// </summary>
        [JsonProperty("expected_traffic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_traffic")]
#endif
        public long? ExpectedTraffic { get; set; }

        /// <summary>
        /// The size of the observation time window.
        /// </summary>
        [JsonProperty("time_window")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time_window")]
#endif
        public string TimeWindow { get; set; }
    }
}
