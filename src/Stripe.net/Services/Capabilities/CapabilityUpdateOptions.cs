namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CapabilityUpdateOptions : BaseOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
