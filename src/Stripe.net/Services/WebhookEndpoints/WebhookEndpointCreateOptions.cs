namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class WebhookEndpointCreateOptions : WebhookEndpointSharedOptions
    {
        [JsonProperty("connect")]
        public bool? Connect { get; set; }
    }
}
