using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_updating_an_invoice
	{
		private static StripeInvoiceUpdateOptions StripeInvoiceUpdateOptions;
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

			_stripeInvoiceService = new StripeInvoiceService(ConfigurationManager.AppSettings["StripeApiKey"]);
			_stripeInvoiceList = _stripeInvoiceService.List(new StripeInvoiceListOptions { CustomerId = stripeCustomer.Id }).ToList();

			StripeInvoiceUpdateOptions = test_data.stripe_invoice_update_options.Valid();
		};

		Because of = () =>
			_stripeInvoice = _stripeInvoiceService.Update(_stripeInvoiceList.First().Id, StripeInvoiceUpdateOptions);
		
		It should_have_the_correct_value_for_closed = () =>
			_stripeInvoice.Closed.ShouldEqual(_stripeInvoiceList.First().Closed);

		It should_have_the_correct_description = () =>
			_stripeInvoice.Description.ShouldEqual(StripeInvoiceUpdateOptions.Description);

		It should_have_the_correct_statement_description = () =>
			_stripeInvoice.StatementDescription.ShouldEqual(StripeInvoiceUpdateOptions.StatementDescription);

		It should_have_the_correct_value_for_forgiven = () =>
			_stripeInvoice.Forgiven.ShouldEqual(false);

		It should_have_metadata = () =>
			_stripeInvoice.Metadata.Count.ShouldEqual(3);

		It should_have_the_correct_metadata = () =>
			_stripeInvoice.Metadata.ShouldContainOnly(StripeInvoiceUpdateOptions.Metadata);
	}
}
