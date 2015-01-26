using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_invoiceitems
    {
        private static List<StripeInvoiceLineItem> _stripeInvoiceItemList;
        private static StripeInvoiceItemService _stripeInvoiceItemService;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _stripeInvoiceItemService = new StripeInvoiceItemService();
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id));
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id));
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id));
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id));
        };

        Because of = () =>
            _stripeInvoiceItemList = _stripeInvoiceItemService.List().ToList();

        It should_have_atleast_4_entries = () =>
            _stripeInvoiceItemList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}