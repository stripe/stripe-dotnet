namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceSofortCreateOptions : INestedOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
