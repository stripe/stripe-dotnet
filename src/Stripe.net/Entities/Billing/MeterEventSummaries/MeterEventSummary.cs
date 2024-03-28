// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Aggregated value of all the events within start_time (inclusive) and end_time
        /// (inclusive). The aggregation strategy is defined on meter via `default_aggregation``.
        /// </summary>
        [JsonProperty("aggregated_value")]
        public decimal AggregatedValue { get; set; }

        /// <summary>
        /// End timestamp for this usage summary (inclusive).
        /// </summary>
        [JsonProperty("end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The meter associated with this usage summary.
        /// </summary>
        [JsonProperty("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Start timestamp for this usage summary (inclusive).
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
