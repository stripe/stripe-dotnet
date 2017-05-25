﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceListOptions : StripeListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }
 
        [JsonProperty("date")]
        public StripeDateFilter Date { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
