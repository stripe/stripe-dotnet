// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventReason : StripeEntity<EventReason>
    {
        /// <summary>
        /// Event reason type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Information on the API request that instigated the event.
        /// </summary>
        [JsonProperty("request")]
        public EventReasonRequest Request { get; set; }
    }
}
