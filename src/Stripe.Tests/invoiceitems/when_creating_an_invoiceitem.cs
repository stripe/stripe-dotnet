using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_invoiceitem
    {
		protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
		protected static StripeInvoiceItem StripeInvoiceItem;

		private static StripeInvoiceItemService _stripeInvoiceItemService;
		private static StripeCustomer _stripeCustomer;
		protected static string StripeInvoiceItemId;

        Establish context = () =>
		{
			var stripeCustomerService = new StripeCustomerService();
			_stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

			_stripeInvoiceItemService = new StripeInvoiceItemService();
			StripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id);
        };

        Because of = () =>
			StripeInvoiceItem = _stripeInvoiceItemService.Create(StripeInvoiceItemCreateOptions);

        Behaves_like<invoiceitem_behaviors> behaviors;
    }
}