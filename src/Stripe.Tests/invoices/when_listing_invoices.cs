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
            StripePlan stripePlan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid()).Await();

			var stripeCouponService = new StripeCouponService();
            StripeCoupon stripeCoupon = stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid()).Await();

			var stripeCustomerService = new StripeCustomerService();
			var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
            _stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions).Await();

			_stripeInvoiceService = new StripeInvoiceService();
		};

		Because of = () =>
            _stripeInvoiceList = _stripeInvoiceService.List(10, 0, _stripeCustomer.Id).Await();

		It should_have_atleast_1_entry = () =>
			_stripeInvoiceList.Count.ShouldBeGreaterThanOrEqualTo(1);
	}
}