// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReason : StripeEntity<EventReason>
    {
        /// <summary>
        /// Event reason type.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Information on the API request that instigated the event.
        /// </summary>
        [JsonProperty("request")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request")]
#endif
        public EventReasonRequest Request { get; set; }
    }
}
