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

        public static StripePlan GetPlan2()
        {
            if (Items.ContainsKey("plan2")) return (StripePlan)Items["plan2"];

            var plan = new StripePlanService(ApiKey).Create(GetPlan2CreateOptions());
            Items.Add("plan2", plan);

            return plan;
        }

        public static StripePlanCreateOptions GetPlan2CreateOptions()
        {
            if (Items.ContainsKey("plan2_create_options")) return (StripePlanCreateOptions)Items["plan2_create_options"];

            var options = new StripePlanCreateOptions
            {
                Amount = 500,
                Currency = "usd",
                Name = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                Interval = StripePlanIntervals.Week
            };
            Items.Add("plan2_create_options", options);

            return options;
        }
    }
}
