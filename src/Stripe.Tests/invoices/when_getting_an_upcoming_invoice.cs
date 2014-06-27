using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_getting_an_upcoming_invoice
	{
		private static StripePlanCreateOptions _stripePlanCreateOptions;
		private static StripeCouponCreateOptions _stripeCouponCreateOptions;
		private static StripeCustomer _stripeCustomer;
		private static StripeInvoiceItemCreateOptions _stripeInvoiceItemCreateOptions;
		private static StripeInvoiceService _stripeInvoiceService;
		private static StripeInvoice _stripeInvoice;

		Establish context = () =>
		{
			var stripePlanService = new StripePlanService();
			_stripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
			var stripePlan = stripePlanService.Create(_stripePlanCreateOptions);

			var stripeCouponService = new StripeCouponService();
			_stripeCouponCreateOptions = test_data.stripe_coupon_create_options.Valid();
			var stripeCoupon = stripeCouponService.Create(_stripeCouponCreateOptions);

			var stripeCustomerService = new StripeCustomerService();
			var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
			_stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

			var stripeInvoiceItemService = new StripeInvoiceItemService();
			_stripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id);
			stripeInvoiceItemService.Create(_stripeInvoiceItemCreateOptions);

			_stripeInvoiceService = new StripeInvoiceService();
		};

		Because of = () =>
			_stripeInvoice = _stripeInvoiceService.Upcoming(_stripeCustomer.Id);
		
		It should_have_a_valid_id = () =>
			_stripeInvoice.Id.ShouldBeNull();

		It should_have_a_subtotal = () =>
			_stripeInvoice.Subtotal.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_a_total = () =>
			_stripeInvoice.Total.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_a_lines_object = () =>
			_stripeInvoice.StripeInvoiceLines.ShouldNotBeNull();

		It should_have_a_valid_invoiceitems_object = () =>
			_stripeInvoice.StripeInvoiceLines.StripeInvoiceItems.ShouldNotBeNull();

		It should_have_the_correct_invoiceitems_object = () =>
			_stripeInvoice.StripeInvoiceLines.StripeInvoiceItems[0].Amount.ShouldEqual(_stripeInvoiceItemCreateOptions.Amount);

		It should_have_a_valid_invoiceitems_plan_object = () =>
			_stripeInvoice.StripeInvoiceLines.StripeInvoiceItems[1].Plan.ShouldNotBeNull();

		It should_have_the_correct_invoiceitems_plan_object = () =>
			_stripeInvoice.StripeInvoiceLines.StripeInvoiceItems[1].Plan.Amount.ShouldEqual(_stripePlanCreateOptions.Amount);
	}
}