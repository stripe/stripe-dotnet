#nullable disable

namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class EventNotificationRelatedObject
    {
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        [STJS.JsonInclude]
        public string Id { get; internal set; }

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