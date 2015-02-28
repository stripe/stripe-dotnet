using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.invoices
{
    public class when_updating_tax_percent_of_invoice
    {
        private static StripeInvoice _stripeInvoice;
        private static List<StripeInvoice> _stripeInvoiceList;
        private static StripeInvoiceService _stripeInvoiceService;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            var stripePlan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id);
            var stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            var stripeInvoiceItemService = new StripeInvoiceItemService();
            stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id));

            _stripeInvoiceService = new StripeInvoiceService();
            _stripeInvoiceService.Create(stripeCustomer.Id);
            _stripeInvoiceList = _stripeInvoiceService.List(new StripeInvoiceListOptions { CustomerId = stripeCustomer.Id }).ToList();
        };

        Because of = () =>
            _stripeInvoice = _stripeInvoiceService.Update(_stripeInvoiceList.First().Id, new StripeInvoiceUpdateOptions { TaxPercent = 10});

        It should_have_the_correct_id = () =>
            _stripeInvoice.Id.ShouldEqual(_stripeInvoiceList.First().Id);

        It should_have_total = () =>
            _stripeInvoice.Total.ShouldEqual(1100);

    }
}
