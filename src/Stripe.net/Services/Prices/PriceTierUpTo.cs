namespace Stripe
{
    public class PriceTierUpTo : StringEnum
    {
        /// <summary>Use this value to define a fallback tier.</summary>
        public static readonly PriceTierUpTo Inf = new PriceTierUpTo("inf");

        private PriceTierUpTo(string value)
            : base(value)
        {
        }
    }
}
