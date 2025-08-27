// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthTrafficVolumeDropFiringEventData : StripeEntity<V2CoreHealthTrafficVolumeDropFiringEventData>
    {
        /// <summary>
        /// The alert ID.
        /// </summary>
        [JsonProperty("alert_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert_id")]
#endif
        public string AlertId { get; set; }

        /// <summary>
        /// The grouping key for the alert.
        /// </summary>
        [JsonProperty("grouping_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grouping_key")]
#endif
        public string GroupingKey { get; set; }

        /// <summary>
        /// The user impact.
        /// </summary>
        [JsonProperty("impact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impact")]
#endif
        public V2CoreHealthTrafficVolumeDropFiringEventDataImpact Impact { get; set; }

        /// <summary>
        /// The time when impact on the user experience was first detected.
        /// </summary>
        [JsonProperty("started_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("started_at")]
#endif
        public DateTime StartedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A short description of the alert.
        /// </summary>
        [JsonProperty("summary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("summary")]
#endif
        public string Summary { get; set; }
    }
}
