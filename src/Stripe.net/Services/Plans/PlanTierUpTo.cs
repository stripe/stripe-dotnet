namespace Stripe
{
    public class PlanTierUpTo : StringEnum
    {
        /// <summary>Use this value to define a fallback tier.</summary>
        public static readonly PlanTierUpTo Inf = new PlanTierUpTo("inf");

        private PlanTierUpTo(string value)
            : base(value)
        {
        }
    }
}
