namespace Stripe
{
    public class PlanTierUpTo : StringEnum
    {
        public static readonly PlanTierUpTo Inf = new PlanTierUpTo("inf");

        private PlanTierUpTo(string value)
            : base(value)
        {
        }
    }
}
