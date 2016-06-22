using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeUpcomingInvoiceLinesOptions : StripeListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("subscription_plan")]
        public string SubscriptionPlan { get; set; }

        [JsonProperty("subscription_prorate")]
        public string SubscriptionProrate { get; set; }

        [JsonProperty("subscription_proration_date")]
        public int? SubscriptionProrationDate { get; set; }

        [JsonProperty("subscription_quantity")]
        public int? SubscriptionQuantity { get; set; }


    }
}