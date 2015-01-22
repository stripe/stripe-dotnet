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

        public static StripeInvoiceItemUpdateOptions MetadataOnly()
        {
            var stripeInvoiceItemUpdateOptions = new StripeInvoiceItemUpdateOptions()
            {
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A1" },
                    { "B", "Value-B1" },
                    { "C", "Value-C1" },
                    { "D", "Value-D1" }
                }
            };

            return stripeInvoiceItemUpdateOptions;
        }
    }
}
