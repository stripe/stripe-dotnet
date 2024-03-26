// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterCreateOptions : BaseOptions
    {
        /// <summary>
        /// Fields that specify how to map a meter event to a customer.
        /// </summary>
        [JsonProperty("customer_mapping")]
        public MeterCustomerMappingOptions CustomerMapping { get; set; }

        /// <summary>
        /// The default settings to aggregate a meter's events with.
        /// </summary>
        [JsonProperty("default_aggregation")]
        public MeterDefaultAggregationOptions DefaultAggregation { get; set; }

        /// <summary>
        /// The meter's name.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the usage event to record usage for. Corresponds with the <c>event_name</c>
        /// field on usage events.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// The time window to pre-aggregate usage events for, if any.
        /// One of: <c>day</c>, or <c>hour</c>.
        /// </summary>
        [JsonProperty("event_time_window")]
        public string EventTimeWindow { get; set; }

        /// <summary>
        /// Fields that specify how to calculate a usage event's value.
        /// </summary>
        [JsonProperty("value_settings")]
        public MeterValueSettingsOptions ValueSettings { get; set; }
    }
}
