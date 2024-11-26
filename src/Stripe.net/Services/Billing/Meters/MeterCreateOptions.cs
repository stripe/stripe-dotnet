// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterCreateOptions : BaseOptions
    {
        /// <summary>
        /// Fields that specify how to map a meter event to a customer.
        /// </summary>
        [JsonProperty("customer_mapping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_mapping")]
#endif
        public MeterCustomerMappingOptions CustomerMapping { get; set; }

        /// <summary>
        /// The default settings to aggregate a meter's events with.
        /// </summary>
        [JsonProperty("default_aggregation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_aggregation")]
#endif
        public MeterDefaultAggregationOptions DefaultAggregation { get; set; }

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
        /// Fields that specify how to calculate a meter event's value.
        /// </summary>
        [JsonProperty("value_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value_settings")]
#endif
        public MeterValueSettingsOptions ValueSettings { get; set; }
    }
}
