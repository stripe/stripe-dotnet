namespace Stripe
{
    public class SubscriptionTrialEnd : StringEnum
    {
        /// <summary>Special value used to end a customer's trial immediately.</summary>
        public static readonly SubscriptionTrialEnd Now = new SubscriptionTrialEnd("now");

        private SubscriptionTrialEnd(string value)
            : base(value)
        {
        }
    }
}
