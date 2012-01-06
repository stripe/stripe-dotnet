using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using System;

namespace Stripe.Tests
{
    public class when_listing_invoices
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
		};

		Because of = () =>
			_stripeInvoiceList = _stripeInvoiceService.List(10,0,StripeCustomer.Id).ToList();

		It should_have_atleast_1_entry = () =>
			_stripeInvoiceList.Count.ShouldBeGreaterThanOrEqualTo(1);

    }
}