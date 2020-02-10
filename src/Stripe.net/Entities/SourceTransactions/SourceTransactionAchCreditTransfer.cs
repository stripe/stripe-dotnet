namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceTransactionAchCreditTransfer : StripeEntity<SourceTransactionAchCreditTransfer>
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
