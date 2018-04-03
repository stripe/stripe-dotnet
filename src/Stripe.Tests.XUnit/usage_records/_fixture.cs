using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class usage_record_fixture : IDisposable
    {
        public StripeUsageRecordCreateOptions UsageRecordCreateOptions { get; set; }

        public StripeUsageRecord UsageRecord { get; set; }

        public usage_record_fixture()
        {
            var subOptions = new StripeSubscriptionCreateOptions
            {
                Items = new List<StripeSubscriptionItemOption>
                {
                    new StripeSubscriptionItemOption { PlanId = Cache.GetPlan("Metered Plan", "metered").Id }
                }
            };

            var service = new StripeSubscriptionService(Cache.ApiKey);
            var customer_id = Cache.GetCustomer().Id;
            var subscription = service.Create(customer_id, subOptions);
            var subscription_item_id = subscription.Items.Data[0].Id;

            UsageRecordCreateOptions = new StripeUsageRecordCreateOptions() {
                SubscriptionItem = subscription_item_id,
                Timestamp = DateTime.Now,
                Quantity = 2000
            };

            var usageRecordService = new StripeUsageRecordService(Cache.ApiKey);
            UsageRecord = usageRecordService.Create(UsageRecordCreateOptions);
        }

        public void Dispose() { }
    }
}
