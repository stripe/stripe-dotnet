using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_listing_invoiceitems
	{
		private static List<StripeInvoiceItem> _stripeInvoiceItemList;
		private static StripeInvoiceItemService _stripeInvoiceItemService;

		Establish context = () =>
		{
			var stripeCustomerService = new StripeCustomerService();
            StripeCustomer stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();

			_stripeInvoiceItemService = new StripeInvoiceItemService();
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id)).Await();
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id)).Await();
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id)).Await();
            _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id)).Await();
		};

		Because of = () =>
            _stripeInvoiceItemList = _stripeInvoiceItemService.List().Await();

		It should_have_atleast_4_entries = () =>
			_stripeInvoiceItemList.Count.ShouldBeGreaterThanOrEqualTo(4);
	}
}