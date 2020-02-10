namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceThreeDSecureCreateOptions : INestedOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }
    }
}
