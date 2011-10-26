using System;

namespace Stripe
{
    public class StripeCustomer
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("email")]
        public string Email { get; set; }

        [StripeArgument("description")]
        public string Description { get; set; }

        [StripeArgument("livemode")]
        public bool? LiveMode { get; set; }

        [StripeArgument("created")]
        public DateTime Created { get; set; }

        [StripeArgument("deleted")]
        public bool? Deleted { get; set; }

        public StripeNextRecurringCharge StripeNextRecurringCharge { get; set; }

        public StripeDiscount StripeDiscount { get; set; }

        public StripeSubscription StripeSubscription { get; set; }

        public StripeCard StripeCard { get; set; }
    }
}