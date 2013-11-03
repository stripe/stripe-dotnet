using System;
namespace Stripe.Tests.test_data
{
	public class stripe_transfer_create_options
	{
		public static StripeTransferCreateOptions Valid()
		{
			var stripeTransferCreateOptions = new StripeTransferCreateOptions()
			{
				AmountInCents = 50,
				Currency = "usd",
				Recipient = "self",
				Description = "test-transfer-description-" + Guid.NewGuid().ToString(),
				StatementDescriptor = "test-transfer-statement-descriptor" + Guid.NewGuid().ToString()
			};

			return stripeTransferCreateOptions;
		}
	}
}
