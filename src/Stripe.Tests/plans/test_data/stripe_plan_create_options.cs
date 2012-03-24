using System;

namespace Stripe.Tests.test_data
{
	public static class stripe_plan_create_options
	{
		public static StripePlanCreateOptions Valid()
		{
			return new StripePlanCreateOptions()
			{
				Id = "test-plan-" + Guid.NewGuid(),
				AmountInCents = 5000,
				Currency = "usd",
				Interval = "month",
				Name = "Test Plan",
				TrialPeriodDays = 1
			};
		}
	}
}
