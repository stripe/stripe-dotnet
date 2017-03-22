namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeSubscription GetSubscription(string subscriptionName = "subscription")
        {
            if (Items.ContainsKey(subscriptionName)) return (StripeSubscription) Items[subscriptionName];

            var subscription = new StripeSubscriptionService(ApiKey).Create(GetCustomer().Id, GetPlan().Id, GetSubscriptionCreateOptions());
            Items.Add(subscriptionName, subscription);

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
