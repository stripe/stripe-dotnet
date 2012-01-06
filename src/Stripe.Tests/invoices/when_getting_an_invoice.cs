using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using System;

namespace Stripe.Tests
{
    public class when_gettting_an_invoice
	{
		protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
		protected static StripeCustomer StripeCustomer;
		protected static StripePlan StripePlan;
		protected static StripeCoupon StripeCoupon;
		protected static StripeCard StripeCard;
		protected static StripeInvoice StripeInvoice;

		private static List<StripeInvoice> _stripeInvoiceList;
		private static StripeInvoiceService _stripeInvoiceService;
		private static StripeCustomerService _stripeCustomerService;

		Establish context = () =>
		{
			var _stripePlanService = new StripePlanService();
			StripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

			var _stripeCouponService = new StripeCouponService();
			StripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

			_stripeCustomerService = new StripeCustomerService();
			StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(StripePlan.Id, StripeCoupon.Id);
			StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

			_stripeInvoiceService = new StripeInvoiceService();
			_stripeInvoiceList = _stripeInvoiceService.List(10, 0, StripeCustomer.Id).ToList();


		};

		Because of = () =>
			StripeInvoice = _stripeInvoiceService.Get(_stripeInvoiceList.First().Id);

		It should_have_the_correct_id = () =>
			StripeInvoice.Id.ShouldEqual(_stripeInvoiceList.First().Id);

		It should_have_a_valid_date = () =>
			StripeInvoice.Date.ShouldBeLessThanOrEqualTo(DateTime.UtcNow);

		It should_have_a_subtotal = () =>
			StripeInvoice.SubtotalInCents.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_a_total = () =>
			StripeInvoice.TotalInCents.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_a_lines_object = () =>
			StripeInvoice.Lines.ShouldNotBeNull();

    }
}