namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceAttachOptions : BaseOptions
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
