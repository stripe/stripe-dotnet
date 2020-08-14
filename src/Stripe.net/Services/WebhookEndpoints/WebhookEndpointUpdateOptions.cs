namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class WebhookEndpointUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
