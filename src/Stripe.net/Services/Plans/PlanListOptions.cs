namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PlanListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
