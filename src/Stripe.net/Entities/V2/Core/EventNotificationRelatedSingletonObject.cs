#nullable disable

namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Reference to a singleton API resource, which lacks an id.
    /// </summary>
    public class EventNotificationRelatedSingletonObject
    {
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        [STJS.JsonInclude]
        public string Type { get; internal set; }

        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        [STJS.JsonInclude]
        public string Url { get; internal set; }
    }
}
