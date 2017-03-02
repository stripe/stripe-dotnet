using System;

namespace Stripe.Tests.Xunit
{
    public class subscription_item_fixture : IDisposable
    {
        public StripeSubscriptionItemCreateOptions SubscriptionItemCreateOptions { get; }
        public StripeSubscriptionItem SubscriptionItem { get; }

        public subscription_item_fixture()
        {
            SubscriptionItemCreateOptions = new StripeSubscriptionItemCreateOptions
            {
                SubscriptionId = Cache.GetSubscription().Id,
                PlanId = Cache.GetPlan2().Id, // GetPlan() in the cache is used to create the original subscription
                Quantity = 1
            };

            SubscriptionItem = new StripeSubscriptionItemService(Cache.ApiKey).Create(SubscriptionItemCreateOptions);
        }

        public void Dispose()
        {
            new StripeSubscriptionItemService(Cache.ApiKey).Delete(SubscriptionItem.Id);
        }
    }
}
