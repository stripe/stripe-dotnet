// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterEventSummaryListOptions : ListOptions
    {
        /// <summary>
        /// The customer for which to fetch event summaries.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// The timestamp from when to stop aggregating meter events (exclusive). Must be aligned
        /// with minute boundaries.
        /// </summary>
        [JsonProperty("end_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_time")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The timestamp from when to start aggregating meter events (inclusive). Must be aligned
        /// with minute boundaries.
        /// </summary>
        [JsonProperty("start_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_time")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Specifies what granularity to use when generating event summaries. If not specified, a
        /// single event summary would be returned for the specified time range. For hourly
        /// granularity, start and end times must align with hour boundaries (e.g., 00:00, 01:00,
        /// ..., 23:00). For daily granularity, start and end times must align with UTC day
        /// boundaries (00:00 UTC).
        /// One of: <c>day</c>, or <c>hour</c>.
        /// </summary>
        [JsonProperty("value_grouping_window")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value_grouping_window")]
#endif

        public string ValueGroupingWindow { get; set; }
    }
}
