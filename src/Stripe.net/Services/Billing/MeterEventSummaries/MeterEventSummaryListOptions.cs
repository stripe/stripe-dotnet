// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MeterEventSummaryListOptions : ListOptions
    {
        /// <summary>
        /// The customer for which to fetch event summaries.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The timestamp from when to stop aggregating meter events (exclusive).
        /// </summary>
        [JsonProperty("end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The timestamp from when to start aggregating meter events (inclusive).
        /// </summary>
        [JsonProperty("start_time")]
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
        public string ValueGroupingWindow { get; set; }
    }
}
