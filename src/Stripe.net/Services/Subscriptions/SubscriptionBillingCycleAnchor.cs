namespace Stripe
{
    public class SubscriptionBillingCycleAnchor : StringEnum
    {
        public static readonly SubscriptionBillingCycleAnchor Now
            = new SubscriptionBillingCycleAnchor("now");

        public static readonly SubscriptionBillingCycleAnchor Unchanged
            = new SubscriptionBillingCycleAnchor("unchanged");

        private SubscriptionBillingCycleAnchor(string value)
            : base(value)
        {
        }
    }
}
