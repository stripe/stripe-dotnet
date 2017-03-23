namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeSubscription GetSubscription(string subscriptionName = "subscription")
        {
            return new StripeSubscriptionService(ApiKey).Create(GetCustomer().Id, GetPlan().Id, GetSubscriptionCreateOptions());
        }

        public static StripeSubscriptionCreateOptions GetSubscriptionCreateOptions()
        {
            return new StripeSubscriptionCreateOptions
            {
            };
        }
    }
}
