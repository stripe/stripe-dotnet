using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeDeleted : StripeObject
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}