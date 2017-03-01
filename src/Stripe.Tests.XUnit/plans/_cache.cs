using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripePlan GetPlan()
        {
            if (Items.ContainsKey("plan")) return (StripePlan) Items["plan"];

            var plan = new StripePlanService(ApiKey).Create(GetPlanCreateOptions());
            Items.Add("plan", plan);

            return plan;
        }

        public static StripePlanCreateOptions GetPlanCreateOptions()
        {
            if (Items.ContainsKey("plan_create_options")) return (StripePlanCreateOptions) Items["plan_create_options"];

            var options = new StripePlanCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                Name = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                Interval = StripePlanIntervals.Week
            };
            Items.Add("plan_create_options", options);

            return options;
        }
    }
}
