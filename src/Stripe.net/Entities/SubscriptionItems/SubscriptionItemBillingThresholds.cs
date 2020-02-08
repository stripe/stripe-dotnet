namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemBillingThresholds : StripeEntity<SubscriptionItemBillingThresholds>
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
