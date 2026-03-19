namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    ///  The non-StripeEntity version of a Reason.
    /// </summary>
    public class EventNotificationReason
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
        public EventNotificationReasonRequest Request { get; set; }
    }
}