// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A billing meter event summary represents an aggregated view of a customer's billing
    /// meter events within a specified timeframe. It indicates how much usage was accrued by a
    /// customer for that period.
    ///
    /// Note: Meters events are aggregated asynchronously so the meter event summaries provide
    /// an eventually consistent view of the reported usage.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterEventSummary : StripeEntity<MeterEventSummary>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Aggregated value of all the events within <c>start_time</c> (inclusive) and
        /// <c>end_time</c> (inclusive). The aggregation strategy is defined on meter via
        /// <c>default_aggregation</c>.
        /// </summary>
        [JsonProperty("aggregated_value")]
        [STJS.JsonPropertyName("aggregated_value")]
        public decimal AggregatedValue { get; set; }

        /// <summary>
        /// Key-value pairs of dimension values for event summaries with grouping on dimensions.
        /// </summary>
        [JsonProperty("dimensions")]
        [STJS.JsonPropertyName("dimensions")]
        public Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// End timestamp for this event summary (exclusive). Must be aligned with minute
        /// boundaries.
        /// </summary>
        [JsonProperty("end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("end_time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EndTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The meter associated with this event summary.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Start timestamp for this event summary (inclusive). Must be aligned with minute
        /// boundaries.
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("start_time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime StartTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
