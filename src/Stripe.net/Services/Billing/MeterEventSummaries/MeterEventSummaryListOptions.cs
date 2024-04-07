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
        /// The timestamp from when to stop aggregating usage events (exclusive).
        /// </summary>
        [JsonProperty("end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The timestamp from when to start aggregating usage events (inclusive).
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Specifies what granularity to use when generating event summaries. If not specified, a
        /// single event summary would be returned for the specified time range.
        /// </summary>
        [JsonProperty("value_grouping_window")]
        public string ValueGroupingWindow { get; set; }
    }
}
