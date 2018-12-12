namespace Stripe
{
    public static class TransferMethod
    {
        /// <summary>
        /// Standard is the default method.
        /// </summary>
        public static string Standard => "standard";

        /// <summary>
        /// Only supported for transfers to debit cards.
        /// </summary>
        public static string Instant => "instant";
    }
}
