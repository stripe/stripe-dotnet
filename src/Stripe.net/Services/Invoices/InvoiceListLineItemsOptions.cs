namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class InvoiceListLineItemsOptions : ListOptions
    {
        [FormProperty("coupon")]
        public string CouponId { get; set; }

        [FormProperty("customer")]
        public string CustomerId { get; set; }

        [FormProperty("subscription")]
        public string SubscriptionId { get; set; }

        [FormProperty("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [FormProperty("subscription_plan")]
        public string SubscriptionPlanId { get; set; }
    }
}
