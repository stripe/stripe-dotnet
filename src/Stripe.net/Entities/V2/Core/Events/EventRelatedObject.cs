namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class EventRelatedObject : StripeEntity<EventRelatedObject>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object relevant to the event.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

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
