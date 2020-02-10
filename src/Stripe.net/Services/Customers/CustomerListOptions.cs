namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerListOptions : ListOptionsWithCreated
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
