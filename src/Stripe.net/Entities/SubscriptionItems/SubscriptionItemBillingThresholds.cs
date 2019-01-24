namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemBillingThresholds : StripeEntity<SubscriptionItemBillingThresholds>
    {
        /// <summary>
        /// Usage threshold that triggers the subscription to create an invoice.
        /// </summary>
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
