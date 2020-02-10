namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Billing : StripeEntity<Billing>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
