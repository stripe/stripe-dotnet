// File generated from our OpenAPI spec
namespace Stripe
{
    public class SubscriptionCancelAt : StringEnum
    {
        public static readonly SubscriptionCancelAt MaxPeriodEnd = new SubscriptionCancelAt("max_period_end");
        public static readonly SubscriptionCancelAt MinPeriodEnd = new SubscriptionCancelAt("min_period_end");

        private SubscriptionCancelAt(string value)
            : base(value)
        {
        }
    }
}
