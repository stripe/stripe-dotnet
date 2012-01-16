using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_invoiceitems
	{
		protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
		private static List<StripeInvoiceItem> _stripeInvoiceItemList;
		private static StripeInvoiceItemService _stripeInvoiceItemService;
		private static StripeCustomer _stripeCustomer;

        Establish context = () =>
		{
			var stripeCustomerService = new StripeCustomerService(false);
			_stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

			_stripeInvoiceItemService = new StripeInvoiceItemService(false);
			_stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
			_stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
			_stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
			_stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
        };

        Because of = () =>
            _stripeInvoiceItemList = _stripeInvoiceItemService.List().ToList();

        It should_have_atleast_4_entries = () =>
            _stripeInvoiceItemList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}