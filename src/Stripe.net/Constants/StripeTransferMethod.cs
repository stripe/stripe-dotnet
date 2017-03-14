namespace Stripe
{
    public static class StripeTransferMethod
    {
        /// <summary>
        /// Standard is the default method.
        /// </summary>
        public const string Standard = "standard";

        /// <summary>
        /// Only supported for transfers to debit cards.
        /// </summary>
        public const string Instant = "instant";
    }
}
