// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Filter events by whether all webhooks were successfully delivered. If false, events
        /// which are still pending or have failed all delivery attempts to a webhook endpoint will
        /// be returned.
        /// </summary>
        [JsonProperty("delivery_success")]
        public bool? DeliverySuccess { get; set; }

        /// <summary>
        /// A string containing a specific event name, or group of events using * as a wildcard. The
        /// list will be filtered to include only events with a matching event property.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// An array of up to 20 strings containing specific event names. The list will be filtered
        /// to include only events with a matching event property. You may pass either <c>type</c>
        /// or <c>types</c>, but not both.
        /// </summary>
        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
