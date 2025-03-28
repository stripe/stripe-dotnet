// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventListOptions : ListOptions
    {
        /// <summary>
        /// Only return events that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Filter events by whether all webhooks were successfully delivered. If false, events
        /// which are still pending or have failed all delivery attempts to a webhook endpoint will
        /// be returned.
        /// </summary>
        [JsonProperty("delivery_success")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_success")]
#endif
        public bool? DeliverySuccess { get; set; }

        /// <summary>
        /// A string containing a specific event name, or group of events using * as a wildcard. The
        /// list will be filtered to include only events with a matching event property.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// An array of up to 20 strings containing specific event names. The list will be filtered
        /// to include only events with a matching event property. You may pass either <c>type</c>
        /// or <c>types</c>, but not both.
        /// </summary>
        [JsonProperty("types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("types")]
#endif
        public List<string> Types { get; set; }
    }
}
