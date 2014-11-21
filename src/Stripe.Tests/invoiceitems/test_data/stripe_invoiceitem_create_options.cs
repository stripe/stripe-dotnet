using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_invoiceitem_create_options
    {
        public static StripeInvoiceItemCreateOptions Valid(string customerId)
        {
            var stripeInvoiceItemCreateOptions = new StripeInvoiceItemCreateOptions()
            {
                Amount = 1000,
                Currency = "usd",
                CustomerId = customerId,
                Description = "Test Invoice Item",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeInvoiceItemCreateOptions;
        }
    }
}