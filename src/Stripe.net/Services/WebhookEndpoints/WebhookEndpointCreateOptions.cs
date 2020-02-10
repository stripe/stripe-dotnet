namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class WebhookEndpointCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("connect")]
        public bool? Connect { get; set; }

        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
