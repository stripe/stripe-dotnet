using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_plan_create_options
    {
        public static StripePlanCreateOptions Valid()
        {
            return new StripePlanCreateOptions()
            {
                Id = "test-plan-" + Guid.NewGuid(),
                Amount = 5000,
                Currency = "usd",
                Interval = "month",
                Name = "Test Plan",
                TrialPeriodDays = 1,
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                },
                StatementDescriptor = "heyyyy ya!"
            };
        }

        public static StripePlanCreateOptions ThirtyDayIntervalWithFiveDollars()
        {
            return new StripePlanCreateOptions()
            {
                Id = "test-plan-thirty-" + Guid.NewGuid(),
                Amount = 500,
                Currency = "usd",
                Interval = "month",
                Name = "Thirty Days and Five Dollars"
            };
        }
    }
}
