namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeSubscription GetSubscription()
        {
            if (Items.ContainsKey("subscription")) return (StripeSubscription) Items["subscription"];

            var subscription = new StripeSubscriptionService(ApiKey).Create(GetCustomer().Id, GetPlan().Id, GetSubscriptionCreateOptions());
            Items.Add("subscription", subscription);

            return subscription;
        }

        public static StripeSubscriptionCreateOptions GetSubscriptionCreateOptions()
        {
            if (Items.ContainsKey("subscription_create_options")) return (StripeSubscriptionCreateOptions) Items["subscription_create_options"];

            var options = new StripeSubscriptionCreateOptions
            {
            };
            Items.Add("subscription_create_options", options);

            return options;
        }
    }
}
