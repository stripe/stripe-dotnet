using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_deleting_an_invoiceitem
    {
		protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
		protected static StripeInvoiceItem StripeInvoiceItem;
		protected static string StripeInvoiceItemId;

		private static StripeInvoiceItemService _stripeInvoiceItemService;
		private static StripeCustomer _stripeCustomer;
		private static string _createdInvoiceItemId;

		Establish context = () =>
		{
			var stripeCustomerService = new StripeCustomerService();
			_stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

			_stripeInvoiceItemService = new StripeInvoiceItemService();
			StripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id);

			StripeInvoiceItem = _stripeInvoiceItemService.Create(StripeInvoiceItemCreateOptions);
			_createdInvoiceItemId = StripeInvoiceItem.Id;
		};

        Because of = () =>
            _stripeInvoiceItemService.Delete(_createdInvoiceItemId);

        It should_throw_exception_when_getting = () =>
        {
            var exception = Catch.Exception(() => _stripeInvoiceItemService.Get(_createdInvoiceItemId));
            exception.Message.ShouldContain("No such invoiceitem");
        };
    }
}