using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceSubscription
    {
        [JsonProperty("amount")]
        public int? AmountInCents { get; set; }

        [JsonProperty("plan")]
        public StripePlan Plan { get; set; }

        [JsonProperty("period")]
        public StripePeriod Period { get; set; }
    }
}