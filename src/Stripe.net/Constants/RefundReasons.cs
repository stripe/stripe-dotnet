namespace Stripe
{
    public static class RefundReasons
    {
        public static string Unknown => null;

        public static string Duplicate => "duplicate";

        public static string Fraudulent => "fraudulent";

        public static string RequestedByCustomer => "requested_by_customer";
    }
}
