namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceLineItemListOptions : ListOptions
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("subscription_plan")]
        public string SubscriptionPlan { get; set; }
    }
}
