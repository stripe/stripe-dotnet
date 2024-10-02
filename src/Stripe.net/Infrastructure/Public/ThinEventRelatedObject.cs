#nullable disable

namespace Stripe
{
    using Newtonsoft.Json;

    public class ThinEventRelatedObject
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("url")]
        public string Url { get; internal set; }
    }
}
