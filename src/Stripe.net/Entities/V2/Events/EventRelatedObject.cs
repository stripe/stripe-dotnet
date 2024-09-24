namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventRelatedObject : StripeEntity<EventRelatedObject>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object relevant to the event.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Type of the object relevant to the event.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL to retrieve the resource.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
