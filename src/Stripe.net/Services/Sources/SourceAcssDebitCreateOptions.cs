namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceAcssDebitCreateOptions : INestedOptions
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
