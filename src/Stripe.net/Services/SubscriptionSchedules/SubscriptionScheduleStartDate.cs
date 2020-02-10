namespace Stripe
{
    public class SubscriptionScheduleStartDate : StringEnum
    {
        public static readonly SubscriptionScheduleStartDate Now = new SubscriptionScheduleStartDate("now");

        private SubscriptionScheduleStartDate(string value)
            : base(value)
        {
        }
    }
}
