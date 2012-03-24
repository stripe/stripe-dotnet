namespace Stripe.Tests.test_data
{
	public static class stripe_customer_update_options
	{
		public static StripeCustomerUpdateOptions Valid()
		{
			var stripeCustomerUpdateOptions = new StripeCustomerUpdateOptions()
			{
				Description = "Gangster Pancakes (syrup@og.com)"
			};

			return stripeCustomerUpdateOptions;
		}
	}
}
