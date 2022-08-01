namespace Stripe
{
    public class UsageRecordTimestamp : StringEnum
    {
        /// <summary>Special value used to record usage for the current time.</summary>
        public static readonly UsageRecordTimestamp Now = new UsageRecordTimestamp("now");

        private UsageRecordTimestamp(string value)
            : base(value)
        {
        }
    }
}
