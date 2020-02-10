namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemBillingThresholds : StripeEntity<SubscriptionItemBillingThresholds>
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
