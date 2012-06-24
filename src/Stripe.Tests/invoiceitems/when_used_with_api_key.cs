using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.invoiceitems
{
    public class when_used_with_api_key
    {
        protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
        protected static StripeInvoiceItem StripeInvoiceItem;
        protected static string StripeInvoiceItemId;

        private static StripeInvoiceItemService _stripeInvoiceItemService;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _stripeInvoiceItemService = new StripeInvoiceItemService("[your api key here]");
            StripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id);
        };

        Because of = () =>
            StripeInvoiceItem = _stripeInvoiceItemService.Create(StripeInvoiceItemCreateOptions);

        Behaves_like<invoiceitem_behaviors> behaviors;
    }
}
