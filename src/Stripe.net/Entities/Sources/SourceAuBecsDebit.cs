namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceAuBecsDebit : StripeEntity<SourceAuBecsDebit>
    {
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
