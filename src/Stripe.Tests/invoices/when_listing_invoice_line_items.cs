using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_invoice_line_items
    {
        private static StripeCustomer _stripeCustomer;
        private static StripeInvoiceService _stripeInvoiceService;
        private static StripeInvoiceItemService _stripeInvoiceItemService;
        private static List<StripeInvoiceLineItem> _stripeInvoiceLineItemsList;
        

        private static StripeInvoice _stripeInvoice;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            var stripePlan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var stripeCouponService = new StripeCouponService();
            var stripeCoupon = stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
            _stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            _stripeInvoiceItemService = new StripeInvoiceItemService();
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));



            _stripeInvoiceService = new StripeInvoiceService();
            _stripeInvoice = _stripeInvoiceService.Create(_stripeCustomer.Id);
        };

        private Because of =
            () =>
            _stripeInvoiceLineItemsList =  _stripeInvoiceService.ListLineItems(_stripeInvoice.Id).ToList();

        It should_have_atleast_4_entries = () =>
            _stripeInvoiceLineItemsList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}