// File generated from our OpenAPI spec
namespace Stripe
{
    public class UsageRecordTimestamp : StringEnum
    {
        public static readonly UsageRecordTimestamp Now = new UsageRecordTimestamp("now");

        private UsageRecordTimestamp(string value)
            : base(value)
        {
        }
    }
}
