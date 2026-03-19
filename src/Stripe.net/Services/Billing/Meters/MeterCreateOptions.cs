// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeterCreateOptions : BaseOptions
    {
        /// <summary>
        /// Fields that specify how to map a meter event to a customer.
        /// </summary>
        [JsonProperty("customer_mapping")]
        [STJS.JsonPropertyName("customer_mapping")]
        public MeterCustomerMappingOptions CustomerMapping { get; set; }

        /// <summary>
        /// The default settings to aggregate a meter's events with.
        /// </summary>
        [JsonProperty("default_aggregation")]
        [STJS.JsonPropertyName("default_aggregation")]
        public MeterDefaultAggregationOptions DefaultAggregation { get; set; }

        /// <summary>
        /// The meter’s name. Not visible to the customer.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the meter event to record usage for. Corresponds with the <c>event_name</c>
        /// field on meter events.
        /// </summary>
        [JsonProperty("event_name")]
        [STJS.JsonPropertyName("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// The time window which meter events have been pre-aggregated for, if any.
        /// One of: <c>day</c>, or <c>hour</c>.
        /// </summary>
        [JsonProperty("event_time_window")]
        [STJS.JsonPropertyName("event_time_window")]
        public string EventTimeWindow { get; set; }

        /// <summary>
        /// Fields that specify how to calculate a meter event's value.
        /// </summary>
        [JsonProperty("value_settings")]
        [STJS.JsonPropertyName("value_settings")]
        public MeterValueSettingsOptions ValueSettings { get; set; }
    }
}
