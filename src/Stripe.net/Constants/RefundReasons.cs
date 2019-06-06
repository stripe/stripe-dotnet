namespace Stripe
{
    public static class RefundReasons
    {
        public const string Unknown = null;

        public const string Duplicate = "duplicate";

        public const string Fraudulent = "fraudulent";

        public const string RequestedByCustomer = "requested_by_customer";
    }
}
