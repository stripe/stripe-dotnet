using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeInvoiceListLineItemsOptions : StripeListOptions
    {
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("subscription_plan")]
        public string SubscriptionPlanId { get; set; }

        // this will actually send subscription_items. this is to flag it for the middleware
        // to process it as a plugin
        [JsonProperty("subscription_items_array_invoice")]
        public List<StripeInvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }
    }
}