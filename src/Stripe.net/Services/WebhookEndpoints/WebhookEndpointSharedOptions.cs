namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public abstract class WebhookEndpointSharedOptions : BaseOptions
    {
        /// <summary>
        /// The list of events to enable for this endpoint.
        /// </summary>
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
