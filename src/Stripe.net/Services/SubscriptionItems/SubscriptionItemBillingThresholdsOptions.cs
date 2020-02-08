namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemBillingThresholdsOptions : INestedOptions
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
