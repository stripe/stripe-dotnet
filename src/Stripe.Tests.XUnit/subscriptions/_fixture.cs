using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class subscription_fixture : IDisposable
    {
        public StripeSubscriptionCreateOptions SubscriptionCreateOptions { get; }
        public StripeSubscriptionUpdateOptions SubscriptionUpdateOptions { get; }

        public StripeSubscription Subscription { get; }
        public StripeSubscription SubscriptionUpdated { get; }

        public subscription_fixture()
        {
            SubscriptionCreateOptions = new StripeSubscriptionCreateOptions
            {
                Items = new List<StripeSubscriptionItemOption>
                {
                    new StripeSubscriptionItemOption { PlanId = Cache.GetPlan().Id, Quantity = 1 },
                    new StripeSubscriptionItemOption { PlanId = Cache.GetPlan2().Id, Quantity = 2 }
                }
            };

            var service = new StripeSubscriptionService(Cache.ApiKey);
            Subscription = service.Create(Cache.GetCustomer().Id, SubscriptionCreateOptions);

            SubscriptionUpdateOptions = new StripeSubscriptionUpdateOptions
            {
                Items = new List<StripeSubscriptionItemUpdateOption>
                {
                    new StripeSubscriptionItemUpdateOption { Id = Subscription.Items.Data[0].Id, Deleted = true },
                    new StripeSubscriptionItemUpdateOption { Id = Subscription.Items.Data[1].Id, Quantity = 5 }
                }
            };

            SubscriptionUpdated = service.Update(Subscription.Id, SubscriptionUpdateOptions);
        }

        public void Dispose()
        {
            // not implemented :(
        }
    }
}
