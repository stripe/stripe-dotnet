using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_invoice_update_options
    {
        public static StripeInvoiceUpdateOptions Valid()
        {
            var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions()
            {
                Description = "Invoice Description",
				StatementDescriptor = "ST_DESC", // must be less than 15 char
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                }
            };

            return stripeInvoiceUpdateOptions;
        }

        public static StripeInvoiceUpdateOptions ForgivenOnly()
        {
            var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions()
            {
                Forgiven = true
            };

            return stripeInvoiceUpdateOptions;
        }

        public static StripeInvoiceUpdateOptions StatementDescriptionOnly()
        {
            var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions()
            {
				StatementDescriptor = "ST_DESC NEW" // must be less than 15 char
            };

            return stripeInvoiceUpdateOptions;
        }

        public static StripeInvoiceUpdateOptions MetadataOnly()
        {
            var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions()
            {
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A1" },
                    { "B", "Value-B1" },
                    { "C", "Value-C1" },
                    { "D", "Value-D1" }
                }
            };

            return stripeInvoiceUpdateOptions;
        }
    }
}
