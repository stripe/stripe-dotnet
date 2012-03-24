using System;

namespace Stripe.Tests.test_data
{
	public static class stripe_invoiceitem_create_options
	{
		public static StripeInvoiceItemCreateOptions Valid(string customerId)
		{
			var stripeInvoiceItemCreateOptions = new StripeInvoiceItemCreateOptions()
			{
				AmountInCents = 1000,
				Currency = "usd",
				CustomerId = customerId,
				Description = "Test Invoice Item"
			};

			return stripeInvoiceItemCreateOptions;
		}
	}
}