using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class plans_fixture : IDisposable
    {
        public StripePlanCreateOptions PlanCreateOptions { get; set; }
        public StripePlanUpdateOptions PlanUpdateOptions { get; set; }

        public StripePlan Plan { get; set; }
        public StripePlan PlanRetrieved { get; set; }
        public StripePlan PlanUpdated { get; set; }
        public StripeDeleted PlanDeleted { get; set; }
        public StripeList<StripePlan> PlansList { get; }

        public plans_fixture()
        {
            PlanCreateOptions = new StripePlanCreateOptions() {
                // Add a space at the end to ensure the ID is properly URL encoded
                // when passed in the URL for other methods
                Id = "test-plan-" + Guid.NewGuid().ToString() + " ",
                Nickname = "plan-name",
                Amount = 5000,
                Currency = "usd",
                Interval = "month",
            };

            PlanUpdateOptions = new StripePlanUpdateOptions {
              Nickname = "plan-name-2"
            };

            var service = new StripePlanService(Cache.ApiKey);
            Plan = service.Create(PlanCreateOptions);
            PlanRetrieved = service.Get(Plan.Id);
            PlanUpdated = service.Update(Plan.Id, PlanUpdateOptions);
            PlansList = service.List();
            PlanDeleted = service.Delete(Plan.Id);
        }

        public void Dispose() { }
    }
}
