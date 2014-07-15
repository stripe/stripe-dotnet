using System;
using System.Collections.Generic;
using System.Configuration;

namespace Stripe.Tests.test_data
{
	public class stripe_transfer_create_options
	{
		public static StripeTransferCreateOptions Valid()
		{
			var stripeTransferCreateOptions = new StripeTransferCreateOptions()
			{
				Amount = 50,
                Currency = ConfigurationManager.AppSettings["StripeCurrency"],
				Recipient = "self",
				Description = "test-transfer-description-" + Guid.NewGuid(),
				StatementDescription = "test-transfer-statement-descriptor" + Guid.NewGuid(),
				Metadata = new Dictionary<string, string>
				{
					{ "A", "Value-A" },
					{ "B", "Value-B" }
				}
			};

			return stripeTransferCreateOptions;
		}
	}
}
