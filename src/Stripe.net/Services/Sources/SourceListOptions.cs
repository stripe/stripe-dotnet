namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceListOptions : ListOptions
    {
        [JsonProperty("object")]
        internal string Object => "source";

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
