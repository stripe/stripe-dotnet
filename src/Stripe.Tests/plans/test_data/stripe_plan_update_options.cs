using System;

namespace Stripe.Tests.test_data
{
	public static class stripe_plan_update_options
	{
		public static StripePlanUpdateOptions Valid()
		{
			return new StripePlanUpdateOptions()
			{
				Name = "Test Plan Modified",
			};
		}
	}
}
