// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A billing meter event summary represents an aggregated view of a customer's billing
    /// meter events within a specified timeframe. It indicates how much usage was accrued by a
    /// customer for that period.
    /// </summary>
    public class MeterEventSummary : StripeEntity<MeterEventSummary>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Aggregated value of all the events within <c>start_time</c> (inclusive) and
        /// <c>end_time</c> (inclusive). The aggregation strategy is defined on meter via
        /// <c>default_aggregation</c>.
        /// </summary>
        [JsonProperty("aggregated_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aggregated_value")]
#endif

        public decimal AggregatedValue { get; set; }

        /// <summary>
        /// End timestamp for this event summary (exclusive). Must be aligned with minute
        /// boundaries.
        /// </summary>
        [JsonProperty("end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_time")]
#endif

        public DateTime EndTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// The meter associated with this event summary.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif

        public string Meter { get; set; }

        /// <summary>
        /// Start timestamp for this event summary (inclusive). Must be aligned with minute
        /// boundaries.
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_time")]
#endif

        public DateTime StartTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
