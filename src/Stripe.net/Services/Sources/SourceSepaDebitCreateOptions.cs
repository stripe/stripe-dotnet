namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceSepaDebitCreateOptions : INestedOptions
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("ideal")]
        public string Ideal { get; set; }
    }
}
