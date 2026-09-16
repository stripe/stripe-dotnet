namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Reference to a singleton API resource, which lacks an id.
    /// </summary>
    public class EventRelatedSingletonObject : StripeEntity<EventRelatedSingletonObject>
    {
        /// <summary>
        /// Type of the object relevant to the event.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL to retrieve the resource.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
