namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Obsolete("Use InvoiceLineItemListOptions instead.")]
    public class InvoiceListLineItemsOptions : ListOptions
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
