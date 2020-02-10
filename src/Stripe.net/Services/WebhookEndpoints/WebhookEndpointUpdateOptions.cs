namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class WebhookEndpointUpdateOptions : BaseOptions
    {
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
