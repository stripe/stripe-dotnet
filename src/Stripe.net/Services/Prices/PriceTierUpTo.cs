namespace Stripe
{
    public class PriceTierUpTo : StringEnum
    {
        public static readonly PriceTierUpTo Inf = new PriceTierUpTo("inf");

        private PriceTierUpTo(string value)
            : base(value)
        {
        }
    }
}
