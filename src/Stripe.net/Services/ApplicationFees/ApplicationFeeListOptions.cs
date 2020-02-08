namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
