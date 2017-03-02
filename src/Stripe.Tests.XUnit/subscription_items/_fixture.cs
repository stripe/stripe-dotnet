using System;

namespace Stripe.Tests.Xunit
{
    public class subscription_item_fixture : IDisposable
    {
        public StripeSubscriptionItemCreateOptions SubscriptionItemCreateOptions { get; }
        public StripeSubscriptionItemUpdateOptions StripeSubscriptionItemUpdateOptions { get; }

        public StripeSubscriptionItem SubscriptionItem { get; }
        public StripeSubscriptionItem SubscriptionItemUpdated { get; }

        public subscription_item_fixture()
        {
            SubscriptionItemCreateOptions = new StripeSubscriptionItemCreateOptions
            {
                SubscriptionId = Cache.GetSubscription().Id,
                // GetPlan() in the cache is used to create the original subscription
                // you cannot have a subscription item with the same plan as the original sub plan
                PlanId = Cache.GetPlan2().Id,
                Quantity = 1
            };

            StripeSubscriptionItemUpdateOptions = new StripeSubscriptionItemUpdateOptions
            {
                Quantity = 2
            };

            SubscriptionItem = new StripeSubscriptionItemService(Cache.ApiKey).Create(SubscriptionItemCreateOptions);
            SubscriptionItemUpdated = new StripeSubscriptionItemService(Cache.ApiKey).Update(SubscriptionItem.Id, StripeSubscriptionItemUpdateOptions);
        }

        public void Dispose()
        {
            new StripeSubscriptionItemService(Cache.ApiKey).Delete(SubscriptionItem.Id);
        }
    }
}
