namespace Stripe.Tests.test_data
{
	public static class stripe_token_create_options
	{
		public static StripeTokenCreateOptions Valid()
		{
			return new StripeTokenCreateOptions()
			{
				CardAddressCountry = "US",
				CardAddressLine1 = "24 Chicken Leg Ave",
				CardAddressLine2 = "Unit B",
				CardAddressState = "NC",
				CardAddressZip = "27617",
				CardCvc = "1223",
				CardExpirationMonth = "10",
				CardExpirationYear = "2012",
				CardName = "Bob Winghead",
				CardNumber = "4242424242424242",
				AmountInCents = 5153,
				Currency = "usd"
			};
		}
	}
}
