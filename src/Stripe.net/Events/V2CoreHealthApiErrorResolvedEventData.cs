// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthApiErrorResolvedEventData : StripeEntity<V2CoreHealthApiErrorResolvedEventData>
    {
        /// <summary>
        /// The alert ID.
        /// </summary>
        [JsonProperty("alert_id")]
        [STJS.JsonPropertyName("alert_id")]
        public string AlertId { get; set; }

        /// <summary>
        /// The grouping key for the alert.
        /// </summary>
        [JsonProperty("grouping_key")]
        [STJS.JsonPropertyName("grouping_key")]
        public string GroupingKey { get; set; }

        /// <summary>
        /// The user impact.
        /// </summary>
        [JsonProperty("impact")]
        [STJS.JsonPropertyName("impact")]
        public V2CoreHealthApiErrorResolvedEventDataImpact Impact { get; set; }

        /// <summary>
        /// The time when the user experience has returned to expected levels.
        /// </summary>
        [JsonProperty("resolved_at")]
        [STJS.JsonPropertyName("resolved_at")]
        public DateTime ResolvedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time when impact on the user experience was first detected.
        /// </summary>
        [JsonProperty("started_at")]
        [STJS.JsonPropertyName("started_at")]
        public DateTime StartedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A short description of the alert.
        /// </summary>
        [JsonProperty("summary")]
        [STJS.JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}
