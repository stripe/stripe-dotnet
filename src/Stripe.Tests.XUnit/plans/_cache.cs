using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripePlan GetPlan(string planName = "plan")
        {
            if (Items.ContainsKey(planName)) return (StripePlan) Items[planName];

            var plan = new StripePlanService(ApiKey).Create(GetPlanCreateOptions(planName));
            Items.Add(planName, plan);

            return plan;
        }

        public static StripePlanCreateOptions GetPlanCreateOptions(string planName = "plan")
        {
            if (Items.ContainsKey($"{planName}_create_options")) return (StripePlanCreateOptions) Items[$"{planName}_create_options"];

            var options = new StripePlanCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                Name = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                Interval = StripePlanIntervals.Week
            };
            Items.Add($"{planName}_create_options", options);

            return options;
        }
    }
}
