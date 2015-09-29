using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountCreateOptions
    {
        [JsonProperty("managed")]
        public bool? Managed { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
