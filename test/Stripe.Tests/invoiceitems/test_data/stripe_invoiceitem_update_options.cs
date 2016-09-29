using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_invoiceitem_update_options
    {
        public static StripeInvoiceItemUpdateOptions Valid()
        {
            var stripeInvoiceItemUpdateOptions = new StripeInvoiceItemUpdateOptions()
            {
                Amount = 1001,
                Description = "Test Invoice Item Update",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                }
            };

            return stripeInvoiceItemUpdateOptions;
        }
    }
}
