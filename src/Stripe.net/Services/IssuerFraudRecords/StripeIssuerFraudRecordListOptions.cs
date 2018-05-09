﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeIssuerFraudRecordListOptions : StripeListOptions
    {
        [JsonProperty("charge")]
        public string? ChargeId { get; set; }

        [JsonProperty("date")]
        public StripeDateFilter Date { get; set; }
    }
}
