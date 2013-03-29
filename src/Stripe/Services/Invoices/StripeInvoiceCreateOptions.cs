using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceCreateOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
