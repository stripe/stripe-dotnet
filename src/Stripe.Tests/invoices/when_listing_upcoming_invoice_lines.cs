using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_upcoming_invoices_lines
    {
        private static List<StripeInvoiceLineItem> _invoiceLineItems;
        private static StripeCustomer _customer;
        private static StripePlan _plan;
        private static StripeCoupon _coupon;
        private static StripeInvoiceService _invoiceService;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            _plan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var stripeCouponService = new StripeCouponService();
            _coupon = stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(_plan.Id, _coupon.Id);
            _customer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            _invoiceService = new StripeInvoiceService();
        };

        Because of = () =>
            _invoiceLineItems = _invoiceService.ListUpcomingLineItems(_customer.Id).ToList();

        It should_have_one_entry = () =>
            _invoiceLineItems.Count.ShouldBeGreaterThanOrEqualTo(1);

        It should_have_the_correct_plan = () =>
            _invoiceLineItems.Single().Plan.Id.ShouldEqual(_plan.Id);
    }
}
