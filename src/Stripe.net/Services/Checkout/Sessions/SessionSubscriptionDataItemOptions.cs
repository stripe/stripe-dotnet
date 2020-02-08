namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionSubscriptionDataItemOptions : INestedOptions
    {
        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
