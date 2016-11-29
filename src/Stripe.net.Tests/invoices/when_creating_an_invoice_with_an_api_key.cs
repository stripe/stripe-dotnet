using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_invoice_with_an_api_key
    {
        private static StripeInvoice _stripeInvoice;
        private static List<StripeInvoice> _stripeInvoiceList;
        private static StripeInvoiceService _stripeInvoiceService;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            var stripePlan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var stripeCouponService = new StripeCouponService();
            var stripeCoupon = stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
            var stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            _stripeInvoiceService = new StripeInvoiceService();
            _stripeInvoiceList = _stripeInvoiceService.List(new StripeInvoiceListOptions { CustomerId = stripeCustomer.Id }).ToList();
        };

        Because of = () =>
            _stripeInvoice = _stripeInvoiceService.Get(_stripeInvoiceList.First().Id);

        It should_have_the_correct_id = () =>
            _stripeInvoice.Id.ShouldEqual(_stripeInvoiceList.First().Id);

        It should_have_a_valid_date = () =>
            _stripeInvoice.Date.ShouldBeLessThanOrEqualTo(DateTime.UtcNow.AddMinutes(1));

        It should_have_a_subtotal = () =>
            _stripeInvoice.Subtotal.ShouldBeGreaterThanOrEqualTo(0);

        It should_have_a_total = () =>
            _stripeInvoice.Total.ShouldBeGreaterThanOrEqualTo(0);

        It should_have_a_lines_object = () =>
            _stripeInvoice.StripeInvoiceLineItems.ShouldNotBeNull();

        It should_have_a_null_tax_value = () =>
            _stripeInvoice.Tax.ShouldBeNull();
    }
}
