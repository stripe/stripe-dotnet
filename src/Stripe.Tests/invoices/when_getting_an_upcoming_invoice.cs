using Machine.Specifications;
using System;

namespace Stripe.Tests
{
	public class when_getting_an_upcoming_invoice
    {
		protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
		protected static StripeCustomer StripeCustomer;
		protected static StripePlan StripePlan;
		protected static StripeCoupon StripeCoupon;
		protected static StripeCard StripeCard;
		protected static StripeInvoice StripeInvoice;

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

		};

		Because of = () =>
		{
			var _stripeInvoiceService = new StripeInvoiceService();
			StripeInvoice = _stripeInvoiceService.Upcoming(StripeCustomer.Id);
		};
		
		It should_have_a_valid_id = () =>
			StripeInvoice.Id.ShouldBeNull();

		It should_have_a_subtotal = () =>
			StripeInvoice.SubtotalInCents.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_a_total = () =>
			StripeInvoice.TotalInCents.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_a_lines_object = () =>
			StripeInvoice.Lines.ShouldNotBeNull();



		
    }
}