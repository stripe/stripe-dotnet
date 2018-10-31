namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class WebhookEndpointUpdateOptions : WebhookEndpointSharedOptions
    {
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
    }
}
