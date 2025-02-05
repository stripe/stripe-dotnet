// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Meters specify how to aggregate meter events over a billing period. Meter events
    /// represent the actions that customers take in your system. Meters attach to prices and
    /// form the basis of the bill.
    ///
    /// Related guide: <a href="https://docs.stripe.com/billing/subscriptions/usage-based">Usage
    /// based billing</a>.
    /// </summary>
    public class Meter : StripeEntity<Meter>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("customer_mapping")]
        public MeterCustomerMapping CustomerMapping { get; set; }

        [JsonProperty("default_aggregation")]
        public MeterDefaultAggregation DefaultAggregation { get; set; }

        /// <summary>
        /// The meter's name.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the meter event to record usage for. Corresponds with the <c>event_name</c>
        /// field on meter events.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// The time window to pre-aggregate meter events for, if any.
        /// One of: <c>day</c>, or <c>hour</c>.
        /// </summary>
        [JsonProperty("event_time_window")]
        public string EventTimeWindow { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The meter's status.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public MeterStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("value_settings")]
        public MeterValueSettings ValueSettings { get; set; }
    }
}
