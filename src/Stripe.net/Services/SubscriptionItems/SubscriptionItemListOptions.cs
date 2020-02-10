namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemListOptions : ListOptions
    {
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
