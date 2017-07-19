using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountRejectOptions
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
