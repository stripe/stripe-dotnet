using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class subscription_item_fixture : IDisposable
    {
        public StripeSubscriptionItemCreateOptions SubscriptionItemCreateOptions { get; }
        public StripeSubscriptionItemUpdateOptions SubscriptionItemUpdateOptions { get; }

        public StripeSubscriptionItem SubscriptionItem { get; }
        public StripeSubscriptionItem SubscriptionItemUpdated { get; }
        public StripeSubscriptionItem SubscriptionItemRetrieved { get; }
        public StripeList<StripeSubscriptionItem> SubscriptionItemList { get; }

        public subscription_item_fixture()
        {
            SubscriptionItemCreateOptions = new StripeSubscriptionItemCreateOptions
            {
                SubscriptionId = Cache.GetSubscription().Id,
                // GetPlan() in the cache is used to create the original subscription
                // you cannot have a subscription item with the same plan as the original sub plan
                PlanId = Cache.GetPlan("bronze").Id,
                Quantity = 1,
                Metadata = new Dictionary<string, string>() { { "key", "value1" } }
            };

            SubscriptionItemUpdateOptions = new StripeSubscriptionItemUpdateOptions
            {
                Quantity = 2,
                Metadata = new Dictionary<string, string>() { { "key", "value2" } }
            };

            var service = new StripeSubscriptionItemService(Cache.ApiKey);
            SubscriptionItem = service.Create(SubscriptionItemCreateOptions);
            SubscriptionItemUpdated = service.Update(SubscriptionItem.Id, SubscriptionItemUpdateOptions);
            SubscriptionItemRetrieved = service.Get(SubscriptionItem.Id);
            SubscriptionItemList = service.List(new StripeSubscriptionItemListOptions { SubscriptionId = Cache.GetSubscription().Id });
        }

        public void Dispose()
        {
            new StripeSubscriptionItemService(Cache.ApiKey).Delete(SubscriptionItem.Id);
        }
    }
}
