namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public abstract class WebhookEndpointSharedOptions : BaseOptions
    {
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
