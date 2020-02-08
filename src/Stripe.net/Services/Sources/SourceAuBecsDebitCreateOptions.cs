namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceAuBecsDebitCreateOptions : INestedOptions
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }
    }
}
