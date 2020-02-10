namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ConnectionTokenCreateOptions : BaseOptions
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
