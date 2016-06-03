using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_invoices
    {
        private static List<StripeInvoice> _stripeInvoiceList;
        private static StripeCustomer _stripeCustomer;
        private static StripeInvoiceService _stripeInvoiceService;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            var stripePlan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var stripeCouponService = new StripeCouponService();
            var stripeCoupon = stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
            _stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            _stripeInvoiceService = new StripeInvoiceService();
        };

        Because of = () =>
            _stripeInvoiceList = _stripeInvoiceService.List(new StripeInvoiceListOptions { CustomerId = _stripeCustomer.Id }).ToList();

        It should_have_atleast_1_entry = () =>
            _stripeInvoiceList.Count.ShouldBeGreaterThanOrEqualTo(1);
    }
}