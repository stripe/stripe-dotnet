using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeApplicationFeeRefundList
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        public List<StripeApplicationFeeRefund> StripeApplicationFeeRefunds { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}
