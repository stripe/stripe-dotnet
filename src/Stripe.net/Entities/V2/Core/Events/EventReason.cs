// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventReason : StripeEntity<EventReason>
    {
        /// <summary>
        /// Event reason type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Information on the API request that instigated the event.
        /// </summary>
        [JsonProperty("request")]
        [STJS.JsonPropertyName("request")]
        public EventReasonRequest Request { get; set; }
    }
}
