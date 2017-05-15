using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class subscription_fixture : IDisposable
    {
        public StripeSubscriptionCreateOptions SubscriptionCreateOptions { get; }
        public StripeSubscriptionUpdateOptions SubscriptionUpdateOptions { get; }
        public StripeSubscriptionUpdateOptions SubscriptionEndedOptions { get; }

        public StripeSubscription Subscription { get; }
        public StripeSubscription SubscriptionUpdated { get; }
        public StripeSubscription SubscriptionEnded { get; }

        public subscription_fixture()
        {
            SubscriptionCreateOptions = new StripeSubscriptionCreateOptions
            {
                TrialEnd = DateTime.Now.AddMinutes(5),
                Items = new List<StripeSubscriptionItemOption>
                {
                    new StripeSubscriptionItemOption { PlanId = Cache.GetPlan().Id, Quantity = 1 },
                    new StripeSubscriptionItemOption { PlanId = Cache.GetPlan("silver").Id, Quantity = 2 }
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

            SubscriptionEndedOptions = new StripeSubscriptionUpdateOptions
            {
                EndTrialNow = true
            };

            SubscriptionEnded = service.Update(Subscription.Id, SubscriptionEndedOptions);
        }

        public void Dispose()
        {
            // not implemented :(
        }
    }
}
