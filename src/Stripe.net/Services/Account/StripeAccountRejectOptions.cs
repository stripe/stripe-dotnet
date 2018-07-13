namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeAccountRejectOptions : StripeBaseOptions
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
