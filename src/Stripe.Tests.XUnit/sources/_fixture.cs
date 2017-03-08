using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class sources_fixture : IDisposable
    {
        public StripeSourceCreateOptions SourceCreateOptions { get; }
        //public StripeSubscriptionItemUpdateOptions SubscriptionItemUpdateOptions { get; }

        public StripeSource Source { get; }
        //public StripeSubscriptionItem SubscriptionItemUpdated { get; }
        //public StripeSubscriptionItem SubscriptionItemRetrieved { get; }
        //public IEnumerable<StripeSubscriptionItem> SubscriptionItemList { get; }

        public sources_fixture()
        {
            SourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = "bitcoin",
                Amount = 1,
                Currency = "usd"
            };

            //SubscriptionItemUpdateOptions = new StripeSubscriptionItemUpdateOptions
            //{
            //    Quantity = 2
            //};

            var service = new StripeSourceService(Cache.ApiKey);
            Source = service.Create(SourceCreateOptions);
            //SubscriptionItemUpdated = service.Update(SubscriptionItem.Id, SubscriptionItemUpdateOptions);
            //SubscriptionItemRetrieved = service.Get(SubscriptionItem.Id);
            //SubscriptionItemList = service.List(new StripeSubscriptionItemListOptions { SubscriptionId = Cache.GetSubscription().Id });
        }

        public void Dispose()
        {
            //new StripeSubscriptionItemService(Cache.ApiKey).Delete(SubscriptionItem.Id);
        }
    }
}
