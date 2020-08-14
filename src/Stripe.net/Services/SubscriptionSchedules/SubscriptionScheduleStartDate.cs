namespace Stripe
{
    public class SubscriptionScheduleStartDate : StringEnum
    {
        /// <summary>Special value used to start a subscription schedule immediately.</summary>
        public static readonly SubscriptionScheduleStartDate Now = new SubscriptionScheduleStartDate("now");

        private SubscriptionScheduleStartDate(string value)
            : base(value)
        {
        }
    }
}
