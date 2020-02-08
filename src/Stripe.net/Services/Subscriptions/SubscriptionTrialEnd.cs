namespace Stripe
{
    public class SubscriptionTrialEnd : StringEnum
    {
        public static readonly SubscriptionTrialEnd Now = new SubscriptionTrialEnd("now");

        private SubscriptionTrialEnd(string value)
            : base(value)
        {
        }
    }
}
