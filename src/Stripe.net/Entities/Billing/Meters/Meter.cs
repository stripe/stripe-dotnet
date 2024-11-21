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
    /// A billing meter is a resource that allows you to track usage of a particular event. For
    /// example, you might create a billing meter to track the number of API calls made by a
    /// particular user. You can then attach the billing meter to a price and attach the price
    /// to a subscription to charge the user for the number of API calls they make.
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("customer_mapping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_mapping")]
#endif

        public MeterCustomerMapping CustomerMapping { get; set; }

        [JsonProperty("default_aggregation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_aggregation")]
#endif

        public MeterDefaultAggregation DefaultAggregation { get; set; }

        /// <summary>
        /// The meter's name.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif

        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the meter event to record usage for. Corresponds with the <c>event_name</c>
        /// field on meter events.
        /// </summary>
        [JsonProperty("event_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_name")]
#endif

        public string EventName { get; set; }

        /// <summary>
        /// The time window to pre-aggregate meter events for, if any.
        /// One of: <c>day</c>, or <c>hour</c>.
        /// </summary>
        [JsonProperty("event_time_window")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_time_window")]
#endif

        public string EventTimeWindow { get; set; }

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
        /// The meter's status.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif

        public MeterStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("value_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value_settings")]
#endif

        public MeterValueSettings ValueSettings { get; set; }
    }
}
