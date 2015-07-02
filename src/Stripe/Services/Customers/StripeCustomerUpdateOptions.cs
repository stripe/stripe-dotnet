using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCustomerUpdateOptions
    {
        [JsonProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
