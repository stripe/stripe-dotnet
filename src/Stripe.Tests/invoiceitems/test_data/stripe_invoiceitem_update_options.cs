using System;

namespace Stripe.Tests.test_data
{
    public static class stripe_invoiceitem_update_options
    {
        public static StripeInvoiceItemUpdateOptions Valid()
        {
			var stripeInvoiceItemUpdateOptions = new StripeInvoiceItemUpdateOptions()
            {
				AmountInCents = 1000,
				Currency = "usd",
				Description = "Test Invoice Item"    
            };

			return stripeInvoiceItemUpdateOptions;
        }
    }
}
