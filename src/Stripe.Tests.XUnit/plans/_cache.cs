using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        private static Object cacheLock = new Object();

        public static StripePlan GetPlan(string planName = "plan", string planUsageType = "licensed")
        {
            // Ensures that creating a new plan only happens synchronously
            // Avoids parallel calls to end up with the same options (and id) twice.
            lock(cacheLock)
            {
                if (Items.ContainsKey(planName))
                {
                    return (StripePlan) Items[planName];
                }

                var plan = new StripePlanService(ApiKey).Create(GetPlanCreateOptions(planName, planUsageType));
                Items.Add(planName, plan);

                return plan;
            }
        }

        public static StripePlanCreateOptions GetPlanCreateOptions(string planName = "plan", string planUsageType = "licensed")
        {
            if (Items.ContainsKey($"{planName}_create_options")) return (StripePlanCreateOptions) Items[$"{planName}_create_options"];

            var options = new StripePlanCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                Nickname = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                Interval = StripePlanIntervals.Week,
                Product = new StripePlanProductCreateOptions
                {
                    Name = "Test Product",
                    StatementDescriptor = "TEST THIS PRODUCT"
                },
                UsageType = planUsageType,
            };
            Items.Add($"{planName}_create_options", options);

            return options;
        }
    }
}
