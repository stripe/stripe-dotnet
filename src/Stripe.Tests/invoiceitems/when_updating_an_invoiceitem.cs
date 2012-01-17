using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_updating_an_invoiceitem
    {
		private static StripeInvoiceItem _stripeInvoiceItem;
		private static string _stripeInvoiceItemId;
		private static StripeInvoiceItemService _stripeInvoiceItemService;

		Establish context = () =>
		{
			var stripeCustomerService = new StripeCustomerService();
			var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

			_stripeInvoiceItemService = new StripeInvoiceItemService();
            var _stripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id);

            var createdInvoice = _stripeInvoiceItemService.Create(_stripeInvoiceItemCreateOptions);
            _stripeInvoiceItemId = createdInvoice.Id;
		};

		Because of = () =>
            _stripeInvoiceItem = _stripeInvoiceItemService.Update(_stripeInvoiceItemId, test_data.stripe_invoiceitem_update_options.Valid());

        It should_have_the_correct_amount = () =>
            _stripeInvoiceItem.AmountInCents.ShouldEqual(test_data.stripe_invoiceitem_update_options.Valid().AmountInCents);

        It should_have_the_correct_description = () =>
            _stripeInvoiceItem.Description.ShouldEqual(test_data.stripe_invoiceitem_update_options.Valid().Description);
    }
}