namespace Stripe.Tests.test_data
{
	public class stripe_recipient_create_options
	{
		public static StripeRecipientCreateOptions ValidIndividual()
		{
			var stripeRecipientCreateOptions = new StripeRecipientCreateOptions()
			{
				Name = "Johnny Tenderloin",
				Type = StripeRecipientCreateOptions.RecipientType.individual,
				TaxId = "123456789",
				AccountNumber = "1234567890",
				RoutingNumber = "1000000000",
				Email = "pork@email.com",
				Description = "Johnny Tenderloin (pork@email.com)"
			};

			return stripeRecipientCreateOptions;
		}

		public static StripeRecipientCreateOptions ValidCorporation()
		{
			var stripeRecipientCreateOptions = new StripeRecipientCreateOptions()
			{
				Name = "Tenderloin International, Ltd.",
				Type = StripeRecipientCreateOptions.RecipientType.corporation,
				TaxId = "0987654321",
				AccountNumber = "1000100012",
				RoutingNumber = "1000000000",
				Email = "tenderloins@email.com",
				Description = "Tenderloin International (tenderloins@email.com)"
			};

			return stripeRecipientCreateOptions;
		}
	}
}