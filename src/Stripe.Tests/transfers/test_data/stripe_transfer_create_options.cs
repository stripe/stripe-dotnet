namespace Stripe.Tests.test_data
{
	public class stripe_transfer_create_options
	{
		public static StripeTransferCreateOptions Valid()
		{
			var stripeTransferCreateOptions = new StripeTransferCreateOptions()
			{
				Amount = 50,
				Currency = "usd",
				Recipient = "self",
				Description = "Test Transfer",
				StatementDescriptor = "Invoice 1234"
			};

			return stripeTransferCreateOptions;
		}
	}
}
