namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeSubscription GetSubscription()
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
