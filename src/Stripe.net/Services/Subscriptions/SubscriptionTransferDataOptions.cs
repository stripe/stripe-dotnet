namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionTransferDataOptions : INestedOptions
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
