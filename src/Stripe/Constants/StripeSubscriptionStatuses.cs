namespace Stripe
{
    /// <summary>
    /// https://stripe.com/docs/api#subscription_object-status
    /// </summary>
    public static class StripeSubscriptionStatuses
    {
        public const string Trialing = "trialing";
        public const string Active = "active";
        public const string PastDue = "past_due";
        public const string Canceled = "canceled";
        public const string Unpaid = "unpaid";
    }
}
