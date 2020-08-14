namespace Stripe
{
    public class SubscriptionBillingCycleAnchor : StringEnum
    {
        /// <summary>Resets the subscription's billing cycle anchor to the current time.</summary>
        public static readonly SubscriptionBillingCycleAnchor Now
            = new SubscriptionBillingCycleAnchor("now");

        /// <summary>Leaves the subscription's billing cycle anchor unchanged.</summary>
        public static readonly SubscriptionBillingCycleAnchor Unchanged
            = new SubscriptionBillingCycleAnchor("unchanged");

        private SubscriptionBillingCycleAnchor(string value)
            : base(value)
        {
        }
    }
}
