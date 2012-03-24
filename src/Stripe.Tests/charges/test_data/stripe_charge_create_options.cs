namespace Stripe.Tests.test_data
{
	public static class stripe_charge_create_options
	{
		public static StripeChargeCreateOptions ValidCard()
		{
			return new StripeChargeCreateOptions()
			{
				CardAddressCountry = "US",
				CardAddressLine1 = "24 Beef Flank St",
				CardAddressLine2 = "Apt 24",
				CardAddressState = "NC",
				CardAddressZip = "27617",
				CardCvc = "1223",
				CardExpirationMonth = "10",
				CardExpirationYear = "2012",
				CardName = "Joe Meatballs",
				CardNumber = "4242424242424242",
				Description = "Joe Meatball Charge",
				AmountInCents = 5153,
				Currency = "usd"
			};
		}

		public static StripeChargeCreateOptions ValidCustomer(string customerId)
		{
			return new StripeChargeCreateOptions()
			{
				Description = "Buddy Roast (beef@email.com)",
				AmountInCents = 2994,
				Currency = "usd",
				CustomerId = customerId
			};
		}

		public static StripeChargeCreateOptions ValidToken(string _tokenId)
		{
			return new StripeChargeCreateOptions()
			{
				AmountInCents = 2001,
				Currency = "usd",
				TokenId = _tokenId
			};
		}
	}
}