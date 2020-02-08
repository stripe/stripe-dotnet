namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
