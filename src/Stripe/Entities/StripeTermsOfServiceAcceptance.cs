using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTermsOfServiceAcceptance
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
