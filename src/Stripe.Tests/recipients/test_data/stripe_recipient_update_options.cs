namespace Stripe.Tests.test_data
{
	public class stripe_recipient_update_options
	{
		public static StripeRecipientUpdateOptions ValidIndividual()
		{
			var stripeRecipientUpdateOptions = new StripeRecipientUpdateOptions()
			{
				Description = "John Doe (john@doe.com)"
			};

			return stripeRecipientUpdateOptions;
		}

		public static StripeRecipientUpdateOptions ValidCorporation()
		{
			var stripeRecipientUpdateOptions = new StripeRecipientUpdateOptions()
			{
				Description = "Timothy's Ice Rink (speed@example.com"
			};

			return stripeRecipientUpdateOptions;
		}
	}
}