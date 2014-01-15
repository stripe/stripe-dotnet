using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_closing_an_invoice
	{
		private static StripeInvoice _stripeInvoice;
		private static List<StripeInvoice> _stripeInvoiceList;
		private static StripeInvoiceService _stripeInvoiceService;

		Establish context = () =>
		{
			var stripePlanService = new StripePlanService();
            StripePlan stripePlan = stripePlanService.Create(test_data.stripe_plan_create_options.Valid()).Await();

			var stripeCouponService = new StripeCouponService();
            StripeCoupon stripeCoupon = stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid()).Await();

			var stripeCustomerService = new StripeCustomerService();
			var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
            StripeCustomer stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions).Await();

			var stripeInvoiceItemService = new StripeInvoiceItemService();
            stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id)).Await();

			_stripeInvoiceService = new StripeInvoiceService();
            _stripeInvoiceService.Create(stripeCustomer.Id).Await();
            _stripeInvoiceList = _stripeInvoiceService.List(10, 0, stripeCustomer.Id).Await();
		};

		Because of = () =>
            _stripeInvoice = _stripeInvoiceService.Update(_stripeInvoiceList.First().Id, new StripeInvoiceUpdateOptions { Closed = true }).Await();

		It should_have_the_correct_id = () =>
			_stripeInvoice.Id.ShouldEqual(_stripeInvoiceList.First().Id);

		It should_be_closed = () =>
			_stripeInvoice.Closed.ShouldEqual(true);
	}
}
